#pragma warning disable 1717
namespace Android.App
{
		/// <summary>
		///  <para>A window feature at the top of the activity that may display the activity title, navigation modes, and other interactive items. </para> <para>Beginning with Android 3.0 (API level 11), the action bar appears at the top of an activity's window when the activity uses the system's Holo theme (or one of its descendant themes), which is the default. You may otherwise add the action bar by calling requestFeature(FEATURE_ACTION_BAR) or by declaring it in a custom theme with the windowActionBar property. </para> <para>By default, the action bar shows the application icon on the left, followed by the activity title. If your activity has an options menu, you can make select items accessible directly from the action bar as "action items". You can also modify various characteristics of the action bar or remove it completely.</para> <para>From your activity, you can retrieve an instance of ActionBar by calling getActionBar().</para> <para>In some cases, the action bar may be overlayed by another bar that enables contextual actions, using an android.view.ActionMode. For example, when the user selects one or more items in your activity, you can enable an action mode that offers actions specific to the selected items, with a UI that temporarily replaces the action bar. Although the UI may occupy the same space, the android.view.ActionMode APIs are distinct and independent from those for ActionBar.   <h3>Developer Guides</h3></para> <para> </para> <para>For information about how to use the action bar, including how to add action items, navigation modes and more, read the  developer guide.</para> <para>  </para>    
		/// </summary>
		/// <java-name>
		/// android/app/ActionBar
		/// </java-name>
		[Dot42.DexImport("android/app/ActionBar", AccessFlags = 1057)]
		public abstract partial class ActionBar
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Standard navigation mode. Consists of either a logo or icon and title text with an optional subtitle. Clicking any of these elements will dispatch onOptionsItemSelected to the host Activity with a MenuItem with item ID android.R.id.home. </para>        
				/// </summary>
				/// <java-name>
				/// NAVIGATION_MODE_STANDARD
				/// </java-name>
				[Dot42.DexImport("NAVIGATION_MODE_STANDARD", "I", AccessFlags = 25)]
				public const int NAVIGATION_MODE_STANDARD = 0;
				/// <summary>
				///  <para>List navigation mode. Instead of static title text this mode presents a list menu for navigation within the activity. e.g. this might be presented to the user as a dropdown list. </para>        
				/// </summary>
				/// <java-name>
				/// NAVIGATION_MODE_LIST
				/// </java-name>
				[Dot42.DexImport("NAVIGATION_MODE_LIST", "I", AccessFlags = 25)]
				public const int NAVIGATION_MODE_LIST = 1;
				/// <summary>
				///  <para>Tab navigation mode. Instead of static title text this mode presents a series of tabs for navigation within the activity. </para>        
				/// </summary>
				/// <java-name>
				/// NAVIGATION_MODE_TABS
				/// </java-name>
				[Dot42.DexImport("NAVIGATION_MODE_TABS", "I", AccessFlags = 25)]
				public const int NAVIGATION_MODE_TABS = 2;
				/// <summary>
				///  <para>Use logo instead of icon if available. This flag will cause appropriate navigation modes to use a wider logo in place of the standard icon.</para> <para> <para>setDisplayOptions(int) </para> <para>setDisplayOptions(int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// DISPLAY_USE_LOGO
				/// </java-name>
				[Dot42.DexImport("DISPLAY_USE_LOGO", "I", AccessFlags = 25)]
				public const int DISPLAY_USE_LOGO = 1;
				/// <summary>
				///  <para>Show 'home' elements in this action bar, leaving more space for other navigation elements. This includes logo and icon.</para> <para> <para>setDisplayOptions(int) </para> <para>setDisplayOptions(int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// DISPLAY_SHOW_HOME
				/// </java-name>
				[Dot42.DexImport("DISPLAY_SHOW_HOME", "I", AccessFlags = 25)]
				public const int DISPLAY_SHOW_HOME = 2;
				/// <summary>
				///  <para>Display the 'home' element such that it appears as an 'up' affordance. e.g. show an arrow to the left indicating the action that will be taken.</para> <para>Set this flag if selecting the 'home' button in the action bar to return up by a single level in your UI rather than back to the top level or front page.</para> <para>Setting this option will implicitly enable interaction with the home/up button. See setHomeButtonEnabled(boolean).</para> <para> <para>setDisplayOptions(int) </para> <para>setDisplayOptions(int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// DISPLAY_HOME_AS_UP
				/// </java-name>
				[Dot42.DexImport("DISPLAY_HOME_AS_UP", "I", AccessFlags = 25)]
				public const int DISPLAY_HOME_AS_UP = 4;
				/// <summary>
				///  <para>Show the activity title and subtitle, if present.</para> <para> <para>setTitle(CharSequence) </para> <para>setTitle(int) </para> <para>setSubtitle(CharSequence) </para> <para>setSubtitle(int) </para> <para>setDisplayOptions(int) </para> <para>setDisplayOptions(int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// DISPLAY_SHOW_TITLE
				/// </java-name>
				[Dot42.DexImport("DISPLAY_SHOW_TITLE", "I", AccessFlags = 25)]
				public const int DISPLAY_SHOW_TITLE = 8;
				/// <summary>
				///  <para>Show the custom view if one has been set.  <para>setCustomView(View) </para> <para>setDisplayOptions(int) </para> <para>setDisplayOptions(int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// DISPLAY_SHOW_CUSTOM
				/// </java-name>
				[Dot42.DexImport("DISPLAY_SHOW_CUSTOM", "I", AccessFlags = 25)]
				public const int DISPLAY_SHOW_CUSTOM = 16;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ActionBar() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Set the action bar into custom navigation mode, supplying a view for custom navigation.</para> <para>Custom navigation views appear between the application icon and any action buttons and may use any space available there. Common use cases for custom navigation views might include an auto-suggesting address bar for a browser or other navigation mechanisms that do not translate well to provided navigation modes.</para> <para>The display option DISPLAY_SHOW_CUSTOM must be set for the custom view to be displayed.</para> <para> <para>setDisplayOptions(int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// setCustomView
				/// </java-name>
				[Dot42.DexImport("setCustomView", "(Landroid/view/View;Landroid/app/ActionBar$LayoutParams;)V", AccessFlags = 1025)]
				public abstract void SetCustomView(global::Android.Views.View view, global::Android.App.ActionBar.LayoutParams layoutParams) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Set the action bar into custom navigation mode, supplying a view for custom navigation.</para> <para>Custom navigation views appear between the application icon and any action buttons and may use any space available there. Common use cases for custom navigation views might include an auto-suggesting address bar for a browser or other navigation mechanisms that do not translate well to provided navigation modes.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setCustomView
				/// </java-name>
				[Dot42.DexImport("setCustomView", "(I)V", AccessFlags = 1025)]
				public abstract void SetCustomView(int view) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Set the icon to display in the 'home' section of the action bar. The action bar will use an icon specified by its style or the activity icon by default.</para> <para>Whether the home section shows an icon or logo is controlled by the display option DISPLAY_USE_LOGO.</para> <para> <para>setDisplayUseLogoEnabled(boolean) </para> <para>setDisplayShowHomeEnabled(boolean) </para></para>        
				/// </summary>
				/// <java-name>
				/// setIcon
				/// </java-name>
				[Dot42.DexImport("setIcon", "(I)V", AccessFlags = 1025)]
				public abstract void SetIcon(int resId) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Set the icon to display in the 'home' section of the action bar. The action bar will use an icon specified by its style or the activity icon by default.</para> <para>Whether the home section shows an icon or logo is controlled by the display option DISPLAY_USE_LOGO.</para> <para> <para>setDisplayUseLogoEnabled(boolean) </para> <para>setDisplayShowHomeEnabled(boolean) </para></para>        
				/// </summary>
				/// <java-name>
				/// setIcon
				/// </java-name>
				[Dot42.DexImport("setIcon", "(Landroid/graphics/drawable/Drawable;)V", AccessFlags = 1025)]
				public abstract void SetIcon(global::Android.Graphics.Drawables.Drawable resId) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Set the logo to display in the 'home' section of the action bar. The action bar will use a logo specified by its style or the activity logo by default.</para> <para>Whether the home section shows an icon or logo is controlled by the display option DISPLAY_USE_LOGO.</para> <para> <para>setDisplayUseLogoEnabled(boolean) </para> <para>setDisplayShowHomeEnabled(boolean) </para></para>        
				/// </summary>
				/// <java-name>
				/// setLogo
				/// </java-name>
				[Dot42.DexImport("setLogo", "(I)V", AccessFlags = 1025)]
				public abstract void SetLogo(int resId) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Set the logo to display in the 'home' section of the action bar. The action bar will use a logo specified by its style or the activity logo by default.</para> <para>Whether the home section shows an icon or logo is controlled by the display option DISPLAY_USE_LOGO.</para> <para> <para>setDisplayUseLogoEnabled(boolean) </para> <para>setDisplayShowHomeEnabled(boolean) </para></para>        
				/// </summary>
				/// <java-name>
				/// setLogo
				/// </java-name>
				[Dot42.DexImport("setLogo", "(Landroid/graphics/drawable/Drawable;)V", AccessFlags = 1025)]
				public abstract void SetLogo(global::Android.Graphics.Drawables.Drawable resId) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Set the adapter and navigation callback for list navigation mode.</para> <para>The supplied adapter will provide views for the expanded list as well as the currently selected item. (These may be displayed differently.)</para> <para>The supplied OnNavigationListener will alert the application when the user changes the current list selection.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setListNavigationCallbacks
				/// </java-name>
				[Dot42.DexImport("setListNavigationCallbacks", "(Landroid/widget/SpinnerAdapter;Landroid/app/ActionBar$OnNavigationListener;)V", AccessFlags = 1025)]
				public abstract void SetListNavigationCallbacks(global::Android.Widget.ISpinnerAdapter adapter, global::Android.App.ActionBar.IOnNavigationListener callback) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Set the selected navigation item in list or tabbed navigation modes.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setSelectedNavigationItem
				/// </java-name>
				[Dot42.DexImport("setSelectedNavigationItem", "(I)V", AccessFlags = 1025)]
				public abstract void SetSelectedNavigationItem(int position) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Set the action bar's title. This will only be displayed if DISPLAY_SHOW_TITLE is set.</para> <para> <para>setTitle(CharSequence) </para> <para>setDisplayOptions(int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// setTitle
				/// </java-name>
				[Dot42.DexImport("setTitle", "(I)V", AccessFlags = 1025)]
				public abstract void SetTitle(int resId) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Set the action bar's subtitle. This will only be displayed if DISPLAY_SHOW_TITLE is set.</para> <para> <para>setSubtitle(CharSequence) </para> <para>setDisplayOptions(int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// setSubtitle
				/// </java-name>
				[Dot42.DexImport("setSubtitle", "(I)V", AccessFlags = 1025)]
				public abstract void SetSubtitle(int resId) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Set selected display options. Only the options specified by mask will be changed. To change all display option bits at once, see setDisplayOptions(int).</para> <para>Example: setDisplayOptions(0, DISPLAY_SHOW_HOME) will disable the DISPLAY_SHOW_HOME option. setDisplayOptions(DISPLAY_SHOW_HOME, DISPLAY_SHOW_HOME | DISPLAY_USE_LOGO) will enable DISPLAY_SHOW_HOME and disable DISPLAY_USE_LOGO.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setDisplayOptions
				/// </java-name>
				[Dot42.DexImport("setDisplayOptions", "(II)V", AccessFlags = 1025)]
				public abstract void SetDisplayOptions(int options, int mask) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Set whether to display the activity logo rather than the activity icon. A logo is often a wider, more detailed image.</para> <para>To set several display options at once, see the setDisplayOptions methods.</para> <para> <para>setDisplayOptions(int) </para> <para>setDisplayOptions(int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// setDisplayUseLogoEnabled
				/// </java-name>
				[Dot42.DexImport("setDisplayUseLogoEnabled", "(Z)V", AccessFlags = 1025)]
				public abstract void SetDisplayUseLogoEnabled(bool useLogo) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Set whether to include the application home affordance in the action bar. Home is presented as either an activity icon or logo.</para> <para>To set several display options at once, see the setDisplayOptions methods.</para> <para> <para>setDisplayOptions(int) </para> <para>setDisplayOptions(int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// setDisplayShowHomeEnabled
				/// </java-name>
				[Dot42.DexImport("setDisplayShowHomeEnabled", "(Z)V", AccessFlags = 1025)]
				public abstract void SetDisplayShowHomeEnabled(bool showHome) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Set whether home should be displayed as an "up" affordance. Set this to true if selecting "home" returns up by a single level in your UI rather than back to the top level or front page.</para> <para>To set several display options at once, see the setDisplayOptions methods.</para> <para> <para>setDisplayOptions(int) </para> <para>setDisplayOptions(int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// setDisplayHomeAsUpEnabled
				/// </java-name>
				[Dot42.DexImport("setDisplayHomeAsUpEnabled", "(Z)V", AccessFlags = 1025)]
				public abstract void SetDisplayHomeAsUpEnabled(bool showHomeAsUp) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Set whether an activity title/subtitle should be displayed.</para> <para>To set several display options at once, see the setDisplayOptions methods.</para> <para> <para>setDisplayOptions(int) </para> <para>setDisplayOptions(int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// setDisplayShowTitleEnabled
				/// </java-name>
				[Dot42.DexImport("setDisplayShowTitleEnabled", "(Z)V", AccessFlags = 1025)]
				public abstract void SetDisplayShowTitleEnabled(bool showTitle) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Set whether a custom view should be displayed, if set.</para> <para>To set several display options at once, see the setDisplayOptions methods.</para> <para> <para>setDisplayOptions(int) </para> <para>setDisplayOptions(int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// setDisplayShowCustomEnabled
				/// </java-name>
				[Dot42.DexImport("setDisplayShowCustomEnabled", "(Z)V", AccessFlags = 1025)]
				public abstract void SetDisplayShowCustomEnabled(bool showCustom) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Set the ActionBar's background. This will be used for the primary action bar.</para> <para> <para>setStackedBackgroundDrawable(Drawable) </para> <para>setSplitBackgroundDrawable(Drawable) </para></para>        
				/// </summary>
				/// <java-name>
				/// setBackgroundDrawable
				/// </java-name>
				[Dot42.DexImport("setBackgroundDrawable", "(Landroid/graphics/drawable/Drawable;)V", AccessFlags = 1025)]
				public abstract void SetBackgroundDrawable(global::Android.Graphics.Drawables.Drawable d) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Set the ActionBar's stacked background. This will appear in the second row/stacked bar on some devices and configurations.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setStackedBackgroundDrawable
				/// </java-name>
				[Dot42.DexImport("setStackedBackgroundDrawable", "(Landroid/graphics/drawable/Drawable;)V", AccessFlags = 1)]
				public virtual void SetStackedBackgroundDrawable(global::Android.Graphics.Drawables.Drawable d) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Set the ActionBar's split background. This will appear in the split action bar containing menu-provided action buttons on some devices and configurations. </para> <para>You can enable split action bar with android.R.attr#uiOptions</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setSplitBackgroundDrawable
				/// </java-name>
				[Dot42.DexImport("setSplitBackgroundDrawable", "(Landroid/graphics/drawable/Drawable;)V", AccessFlags = 1)]
				public virtual void SetSplitBackgroundDrawable(global::Android.Graphics.Drawables.Drawable d) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Create and return a new Tab. This tab will not be included in the action bar until it is added.</para> <para>Very often tabs will be used to switch between Fragment objects. Here is a typical implementation of such tabs:</para> <para>{ development/samples/ApiDemos/src/com/example/android/apis/app/FragmentTabs.java complete}</para> <para> <para>addTab(Tab) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>A new Tab</para>
				/// </returns>
				/// <java-name>
				/// newTab
				/// </java-name>
				[Dot42.DexImport("newTab", "()Landroid/app/ActionBar$Tab;", AccessFlags = 1025)]
				public abstract global::Android.App.ActionBar.Tab NewTab() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Add a tab for use in tabbed navigation mode. The tab will be added at the end of the list. If this is the first tab to be added it will become the selected tab.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// addTab
				/// </java-name>
				[Dot42.DexImport("addTab", "(Landroid/app/ActionBar$Tab;)V", AccessFlags = 1025)]
				public abstract void AddTab(global::Android.App.ActionBar.Tab tab) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Add a tab for use in tabbed navigation mode. The tab will be inserted at  <code>position</code>. If this is the first tab to be added it will become the selected tab.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// addTab
				/// </java-name>
				[Dot42.DexImport("addTab", "(Landroid/app/ActionBar$Tab;Z)V", AccessFlags = 1025)]
				public abstract void AddTab(global::Android.App.ActionBar.Tab tab, bool position) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Add a tab for use in tabbed navigation mode. The tab will be inserted at  <code>position</code>. If this is the first tab to be added it will become the selected tab.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// addTab
				/// </java-name>
				[Dot42.DexImport("addTab", "(Landroid/app/ActionBar$Tab;I)V", AccessFlags = 1025)]
				public abstract void AddTab(global::Android.App.ActionBar.Tab tab, int position) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Add a tab for use in tabbed navigation mode. The tab will be insterted at  <code>position</code>.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// addTab
				/// </java-name>
				[Dot42.DexImport("addTab", "(Landroid/app/ActionBar$Tab;IZ)V", AccessFlags = 1025)]
				public abstract void AddTab(global::Android.App.ActionBar.Tab tab, int position, bool setSelected) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Remove a tab from the action bar. If the removed tab was selected it will be deselected and another tab will be selected if present.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// removeTab
				/// </java-name>
				[Dot42.DexImport("removeTab", "(Landroid/app/ActionBar$Tab;)V", AccessFlags = 1025)]
				public abstract void RemoveTab(global::Android.App.ActionBar.Tab tab) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Remove a tab from the action bar. If the removed tab was selected it will be deselected and another tab will be selected if present.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// removeTabAt
				/// </java-name>
				[Dot42.DexImport("removeTabAt", "(I)V", AccessFlags = 1025)]
				public abstract void RemoveTabAt(int position) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Remove all tabs from the action bar and deselect the current tab. </para>        
				/// </summary>
				/// <java-name>
				/// removeAllTabs
				/// </java-name>
				[Dot42.DexImport("removeAllTabs", "()V", AccessFlags = 1025)]
				public abstract void RemoveAllTabs() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Select the specified tab. If it is not a child of this action bar it will be added.</para> <para>Note: If you want to select by index, use setSelectedNavigationItem(int).</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// selectTab
				/// </java-name>
				[Dot42.DexImport("selectTab", "(Landroid/app/ActionBar$Tab;)V", AccessFlags = 1025)]
				public abstract void SelectTab(global::Android.App.ActionBar.Tab tab) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns the tab at the specified index.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para></para>
				/// </returns>
				/// <java-name>
				/// getTabAt
				/// </java-name>
				[Dot42.DexImport("getTabAt", "(I)Landroid/app/ActionBar$Tab;", AccessFlags = 1025)]
				public abstract global::Android.App.ActionBar.Tab GetTabAt(int index) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Show the ActionBar if it is not currently showing. If the window hosting the ActionBar does not have the feature Window#FEATURE_ACTION_BAR_OVERLAY it will resize application content to fit the new space available.</para> <para>If you are hiding the ActionBar through View.SYSTEM_UI_FLAG_FULLSCREEN, you should not call this function directly. </para>        
				/// </summary>
				/// <java-name>
				/// show
				/// </java-name>
				[Dot42.DexImport("show", "()V", AccessFlags = 1025)]
				public abstract void Show() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Hide the ActionBar if it is currently showing. If the window hosting the ActionBar does not have the feature Window#FEATURE_ACTION_BAR_OVERLAY it will resize application content to fit the new space available.</para> <para>Instead of calling this function directly, you can also cause an ActionBar using the overlay feature to hide through View.SYSTEM_UI_FLAG_FULLSCREEN. Hiding the ActionBar through this system UI flag allows you to more seamlessly hide it in conjunction with other screen decorations. </para>        
				/// </summary>
				/// <java-name>
				/// hide
				/// </java-name>
				[Dot42.DexImport("hide", "()V", AccessFlags = 1025)]
				public abstract void Hide() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Add a listener that will respond to menu visibility change events.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// addOnMenuVisibilityListener
				/// </java-name>
				[Dot42.DexImport("addOnMenuVisibilityListener", "(Landroid/app/ActionBar$OnMenuVisibilityListener;)V", AccessFlags = 1025)]
				public abstract void AddOnMenuVisibilityListener(global::Android.App.ActionBar.IOnMenuVisibilityListener listener) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Remove a menu visibility listener. This listener will no longer receive menu visibility change events.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// removeOnMenuVisibilityListener
				/// </java-name>
				[Dot42.DexImport("removeOnMenuVisibilityListener", "(Landroid/app/ActionBar$OnMenuVisibilityListener;)V", AccessFlags = 1025)]
				public abstract void RemoveOnMenuVisibilityListener(global::Android.App.ActionBar.IOnMenuVisibilityListener listener) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Enable or disable the "home" button in the corner of the action bar. (Note that this is the application home/up affordance on the action bar, not the systemwide home button.)</para> <para>This defaults to true for packages targeting &lt; API 14. For packages targeting API 14 or greater, the application should call this method to enable interaction with the home/up affordance.</para> <para>Setting the DISPLAY_HOME_AS_UP display option will automatically enable the home button.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setHomeButtonEnabled
				/// </java-name>
				[Dot42.DexImport("setHomeButtonEnabled", "(Z)V", AccessFlags = 1)]
				public virtual void SetHomeButtonEnabled(bool enabled) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Set an alternate drawable to display next to the icon/logo/title when DISPLAY_HOME_AS_UP is enabled. This can be useful if you are using this mode to display an alternate selection for up navigation, such as a sliding drawer.</para> <para>If you pass  <code>null</code> to this method, the default drawable from the theme will be used.</para> <para>If you implement alternate or intermediate behavior around Up, you should also call setHomeActionContentDescription() to provide a correct description of the action for accessibility support.</para> <para> <para>setDisplayOptions(int, int) </para> <para>setDisplayHomeAsUpEnabled(boolean) </para> <para>setHomeActionContentDescription(int) </para></para>        
				/// </summary>
				/// <java-name>
				/// setHomeAsUpIndicator
				/// </java-name>
				[Dot42.DexImport("setHomeAsUpIndicator", "(Landroid/graphics/drawable/Drawable;)V", AccessFlags = 1)]
				public virtual void SetHomeAsUpIndicator(global::Android.Graphics.Drawables.Drawable indicator) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Set an alternate drawable to display next to the icon/logo/title when DISPLAY_HOME_AS_UP is enabled. This can be useful if you are using this mode to display an alternate selection for up navigation, such as a sliding drawer.</para> <para>If you pass  <code>null</code> to this method, the default drawable from the theme will be used.</para> <para>If you implement alternate or intermediate behavior around Up, you should also call setHomeActionContentDescription() to provide a correct description of the action for accessibility support.</para> <para> <para>setDisplayOptions(int, int) </para> <para>setDisplayHomeAsUpEnabled(boolean) </para> <para>setHomeActionContentDescription(int) </para></para>        
				/// </summary>
				/// <java-name>
				/// setHomeAsUpIndicator
				/// </java-name>
				[Dot42.DexImport("setHomeAsUpIndicator", "(I)V", AccessFlags = 1)]
				public virtual void SetHomeAsUpIndicator(int indicator) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Set an alternate description for the Home/Up action, when enabled.</para> <para>This description is commonly used for accessibility/screen readers when the Home action is enabled. (See setDisplayHomeAsUpEnabled(boolean).) Examples of this are, "Navigate Home" or "Navigate Up" depending on the DISPLAY_HOME_AS_UP display option. If you have changed the home-as-up indicator using setHomeAsUpIndicator(int) to indicate more specific functionality such as a sliding drawer, you should also set this to accurately describe the action.</para> <para>Setting this to  <code>0</code> will use the system default description.</para> <para> <para>setHomeAsUpIndicator(int) </para> <para>setHomeAsUpIndicator(android.graphics.drawable.Drawable) </para></para>        
				/// </summary>
				/// <java-name>
				/// setHomeActionContentDescription
				/// </java-name>
				[Dot42.DexImport("setHomeActionContentDescription", "(Ljava/lang/CharSequence;)V", AccessFlags = 1)]
				public virtual void SetHomeActionContentDescription(global::Java.Lang.ICharSequence resId) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Set an alternate description for the Home/Up action, when enabled.</para> <para>This description is commonly used for accessibility/screen readers when the Home action is enabled. (See setDisplayHomeAsUpEnabled(boolean).) Examples of this are, "Navigate Home" or "Navigate Up" depending on the DISPLAY_HOME_AS_UP display option. If you have changed the home-as-up indicator using setHomeAsUpIndicator(int) to indicate more specific functionality such as a sliding drawer, you should also set this to accurately describe the action.</para> <para>Setting this to  <code>0</code> will use the system default description.</para> <para> <para>setHomeAsUpIndicator(int) </para> <para>setHomeAsUpIndicator(android.graphics.drawable.Drawable) </para></para>        
				/// </summary>
				/// <java-name>
				/// setHomeActionContentDescription
				/// </java-name>
				[Dot42.DexImport("setHomeActionContentDescription", "(I)V", AccessFlags = 1)]
				public virtual void SetHomeActionContentDescription(int resId) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Get the position of the selected navigation item in list or tabbed navigation modes.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Position of the selected item. </para>
				/// </returns>
				/// <java-name>
				/// getSelectedNavigationIndex
				/// </java-name>
				public abstract int SelectedNavigationIndex
				{
						[Dot42.DexImport("getSelectedNavigationIndex", "()I", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Get the number of navigation items present in the current navigation mode.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Number of navigation items. </para>
				/// </returns>
				/// <java-name>
				/// getNavigationItemCount
				/// </java-name>
				public abstract int NavigationItemCount
				{
						[Dot42.DexImport("getNavigationItemCount", "()I", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The current custom view. </para>
				/// </returns>
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

				/// <summary>
				///  <para>Returns the current ActionBar title in standard mode. Returns null if getNavigationMode() would not return NAVIGATION_MODE_STANDARD.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The current ActionBar title or null. </para>
				/// </returns>
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

				/// <summary>
				///  <para>Returns the current ActionBar subtitle in standard mode. Returns null if getNavigationMode() would not return NAVIGATION_MODE_STANDARD.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The current ActionBar subtitle or null. </para>
				/// </returns>
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

				/// <summary>
				///  <para>Returns the current navigation mode. The result will be one of:  <ul> <li> <para>NAVIGATION_MODE_STANDARD </para></li> <li> <para>NAVIGATION_MODE_LIST </para></li> <li> <para>NAVIGATION_MODE_TABS </para></li></ul></para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The current navigation mode. </para>
				/// </returns>
				/// <java-name>
				/// getNavigationMode
				/// </java-name>
				public abstract int NavigationMode
				{
						[Dot42.DexImport("getNavigationMode", "()I", AccessFlags = 1025)]
						get;
						[Dot42.DexImport("setNavigationMode", "(I)V", AccessFlags = 1025)]
						set;
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The current set of display options. </para>
				/// </returns>
				/// <java-name>
				/// getDisplayOptions
				/// </java-name>
				public abstract int DisplayOptions
				{
						[Dot42.DexImport("getDisplayOptions", "()I", AccessFlags = 1025)]
						get;
						[Dot42.DexImport("setDisplayOptions", "(I)V", AccessFlags = 1025)]
						set;
				}

				/// <summary>
				///  <para>Returns the currently selected tab if in tabbed navigation mode and there is at least one tab present.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The currently selected tab or null </para>
				/// </returns>
				/// <java-name>
				/// getSelectedTab
				/// </java-name>
				public abstract global::Android.App.ActionBar.Tab SelectedTab
				{
						[Dot42.DexImport("getSelectedTab", "()Landroid/app/ActionBar$Tab;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Returns the number of tabs currently registered with the action bar. </para>        
				/// </summary>
				/// <returns>
				///  <para>Tab count </para>
				/// </returns>
				/// <java-name>
				/// getTabCount
				/// </java-name>
				public abstract int TabCount
				{
						[Dot42.DexImport("getTabCount", "()I", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Retrieve the current height of the ActionBar.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The ActionBar's height </para>
				/// </returns>
				/// <java-name>
				/// getHeight
				/// </java-name>
				public abstract int Height
				{
						[Dot42.DexImport("getHeight", "()I", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <code>true</code> if the ActionBar is showing,  <code>false</code> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isShowing
				/// </java-name>
				public abstract bool IsShowing
				{
						[Dot42.DexImport("isShowing", "()Z", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Returns a Context with an appropriate theme for creating views that will appear in the action bar. If you are inflating or instantiating custom views that will appear in an action bar, you should use the Context returned by this method. (This includes adapters used for list navigation mode.) This will ensure that views contrast properly against the action bar.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>A themed Context for creating views </para>
				/// </returns>
				/// <java-name>
				/// getThemedContext
				/// </java-name>
				public virtual global::Android.Content.Context ThemedContext
				{
						[Dot42.DexImport("getThemedContext", "()Landroid/content/Context;", AccessFlags = 1)]
						get{ return default(global::Android.Content.Context); }
				}

				/// <summary>
				///  <para>Per-child layout information associated with action bar custom views.</para> <para>ref android.R.styleable::ActionBar_LayoutParams_layout_gravity </para>    
				/// </summary>
				/// <java-name>
				/// android/app/ActionBar$LayoutParams
				/// </java-name>
				[Dot42.DexImport("android/app/ActionBar$LayoutParams", AccessFlags = 9)]
				public partial class LayoutParams : global::Android.Views.ViewGroup.MarginLayoutParams
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>Gravity for the view associated with these LayoutParams.</para> <para> <para>android.view.Gravity </para></para>        
						/// </summary>
						/// <java-name>
						/// gravity
						/// </java-name>
						[Dot42.DexImport("gravity", "I", AccessFlags = 1)]
						public int Gravity;
						[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
						public LayoutParams(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "(II)V", AccessFlags = 1)]
						public LayoutParams(int int32, int int321) /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "(III)V", AccessFlags = 1)]
						public LayoutParams(int int32, int int321, int int322) /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
						public LayoutParams(int int32) /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "(Landroid/app/ActionBar$LayoutParams;)V", AccessFlags = 1)]
						public LayoutParams(LayoutParams layoutParams) /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "(Landroid/view/ViewGroup$LayoutParams;)V", AccessFlags = 1)]
						public LayoutParams(global::Android.Views.ViewGroup.LayoutParams layoutParams) /* MethodBuilder.Create */ 
						{
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal LayoutParams() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

				}

				/// <summary>
				///  <para>Callback interface invoked when a tab is focused, unfocused, added, or removed. </para>    
				/// </summary>
				/// <java-name>
				/// android/app/ActionBar$TabListener
				/// </java-name>
				[Dot42.DexImport("android/app/ActionBar$TabListener", AccessFlags = 1545)]
				public partial interface ITabListener
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>Called when a tab enters the selected state.</para> <para></para>        
						/// </summary>
						/// <java-name>
						/// onTabSelected
						/// </java-name>
						[Dot42.DexImport("onTabSelected", "(Landroid/app/ActionBar$Tab;Landroid/app/FragmentTransaction;)V", AccessFlags = 1025)]
						void OnTabSelected(global::Android.App.ActionBar.Tab tab, global::Android.App.FragmentTransaction ft) /* MethodBuilder.Create */ ;

						/// <summary>
						///  <para>Called when a tab exits the selected state.</para> <para></para>        
						/// </summary>
						/// <java-name>
						/// onTabUnselected
						/// </java-name>
						[Dot42.DexImport("onTabUnselected", "(Landroid/app/ActionBar$Tab;Landroid/app/FragmentTransaction;)V", AccessFlags = 1025)]
						void OnTabUnselected(global::Android.App.ActionBar.Tab tab, global::Android.App.FragmentTransaction ft) /* MethodBuilder.Create */ ;

						/// <summary>
						///  <para>Called when a tab that is already selected is chosen again by the user. Some applications may use this action to return to the top level of a category.</para> <para></para>        
						/// </summary>
						/// <java-name>
						/// onTabReselected
						/// </java-name>
						[Dot42.DexImport("onTabReselected", "(Landroid/app/ActionBar$Tab;Landroid/app/FragmentTransaction;)V", AccessFlags = 1025)]
						void OnTabReselected(global::Android.App.ActionBar.Tab tab, global::Android.App.FragmentTransaction ft) /* MethodBuilder.Create */ ;

				}

				/// <summary>
				///  <para>A tab in the action bar.</para> <para>Tabs manage the hiding and showing of Fragments. </para>    
				/// </summary>
				/// <java-name>
				/// android/app/ActionBar$Tab
				/// </java-name>
				[Dot42.DexImport("android/app/ActionBar$Tab", AccessFlags = 1033)]
				public abstract partial class Tab
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>An invalid position for a tab.</para> <para> <para>getPosition() </para></para>        
						/// </summary>
						/// <java-name>
						/// INVALID_POSITION
						/// </java-name>
						[Dot42.DexImport("INVALID_POSITION", "I", AccessFlags = 25)]
						public const int INVALID_POSITION = -1;
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public Tab() /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Set the icon displayed on this tab.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>The current instance for call chaining </para>
						/// </returns>
						/// <java-name>
						/// setIcon
						/// </java-name>
						[Dot42.DexImport("setIcon", "(Landroid/graphics/drawable/Drawable;)Landroid/app/ActionBar$Tab;", AccessFlags = 1025)]
						public abstract Tab SetIcon(global::Android.Graphics.Drawables.Drawable icon) /* MethodBuilder.Create */ ;

						/// <summary>
						///  <para>Set the icon displayed on this tab.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>The current instance for call chaining </para>
						/// </returns>
						/// <java-name>
						/// setIcon
						/// </java-name>
						[Dot42.DexImport("setIcon", "(I)Landroid/app/ActionBar$Tab;", AccessFlags = 1025)]
						public abstract Tab SetIcon(int icon) /* MethodBuilder.Create */ ;

						/// <summary>
						///  <para>Set the text displayed on this tab. Text may be truncated if there is not room to display the entire string.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>The current instance for call chaining </para>
						/// </returns>
						/// <java-name>
						/// setText
						/// </java-name>
						[Dot42.DexImport("setText", "(Ljava/lang/CharSequence;)Landroid/app/ActionBar$Tab;", AccessFlags = 1025)]
						public abstract Tab SetText(global::Java.Lang.ICharSequence resId) /* MethodBuilder.Create */ ;

						/// <summary>
						///  <para>Set the text displayed on this tab. Text may be truncated if there is not room to display the entire string.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>The current instance for call chaining </para>
						/// </returns>
						/// <java-name>
						/// setText
						/// </java-name>
						[Dot42.DexImport("setText", "(I)Landroid/app/ActionBar$Tab;", AccessFlags = 1025)]
						public abstract Tab SetText(int resId) /* MethodBuilder.Create */ ;

						/// <summary>
						///  <para>Set a custom view to be used for this tab. This overrides values set by setText(CharSequence) and setIcon(Drawable).</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>The current instance for call chaining </para>
						/// </returns>
						/// <java-name>
						/// setCustomView
						/// </java-name>
						[Dot42.DexImport("setCustomView", "(Landroid/view/View;)Landroid/app/ActionBar$Tab;", AccessFlags = 1025)]
						public abstract Tab SetCustomView(global::Android.Views.View view) /* MethodBuilder.Create */ ;

						/// <summary>
						///  <para>Set a custom view to be used for this tab. This overrides values set by setText(CharSequence) and setIcon(Drawable).</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>The current instance for call chaining </para>
						/// </returns>
						/// <java-name>
						/// setCustomView
						/// </java-name>
						[Dot42.DexImport("setCustomView", "(I)Landroid/app/ActionBar$Tab;", AccessFlags = 1025)]
						public abstract Tab SetCustomView(int view) /* MethodBuilder.Create */ ;

						/// <summary>
						///  <para>Give this Tab an arbitrary object to hold for later use.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>The current instance for call chaining </para>
						/// </returns>
						/// <java-name>
						/// setTag
						/// </java-name>
						[Dot42.DexImport("setTag", "(Ljava/lang/Object;)Landroid/app/ActionBar$Tab;", AccessFlags = 1025)]
						public abstract Tab SetTag(object obj) /* MethodBuilder.Create */ ;

						/// <summary>
						///  <para>Set the TabListener that will handle switching to and from this tab. All tabs must have a TabListener set before being added to the ActionBar.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>The current instance for call chaining </para>
						/// </returns>
						/// <java-name>
						/// setTabListener
						/// </java-name>
						[Dot42.DexImport("setTabListener", "(Landroid/app/ActionBar$TabListener;)Landroid/app/ActionBar$Tab;", AccessFlags = 1025)]
						public abstract Tab SetTabListener(global::Android.App.ActionBar.ITabListener listener) /* MethodBuilder.Create */ ;

						/// <summary>
						///  <para>Select this tab. Only valid if the tab has been added to the action bar. </para>        
						/// </summary>
						/// <java-name>
						/// select
						/// </java-name>
						[Dot42.DexImport("select", "()V", AccessFlags = 1025)]
						public abstract void Select() /* MethodBuilder.Create */ ;

						/// <summary>
						///  <para>Set a description of this tab's content for use in accessibility support. If no content description is provided the title will be used.</para> <para> <para>setContentDescription(CharSequence) </para> <para>getContentDescription() </para></para>        
						/// </summary>
						/// <returns>
						///  <para>The current instance for call chaining </para>
						/// </returns>
						/// <java-name>
						/// setContentDescription
						/// </java-name>
						[Dot42.DexImport("setContentDescription", "(I)Landroid/app/ActionBar$Tab;", AccessFlags = 1025)]
						public abstract Tab SetContentDescription(int resId) /* MethodBuilder.Create */ ;

						/// <summary>
						///  <para>Set a description of this tab's content for use in accessibility support. If no content description is provided the title will be used.</para> <para> <para>setContentDescription(CharSequence) </para> <para>getContentDescription() </para></para>        
						/// </summary>
						/// <returns>
						///  <para>The current instance for call chaining </para>
						/// </returns>
						/// <java-name>
						/// setContentDescription
						/// </java-name>
						[Dot42.DexImport("setContentDescription", "(Ljava/lang/CharSequence;)Landroid/app/ActionBar$Tab;", AccessFlags = 1025)]
						public abstract Tab SetContentDescription(global::Java.Lang.ICharSequence resId) /* MethodBuilder.Create */ ;

						/// <summary>
						///  <para>Return the current position of this tab in the action bar.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>Current position, or INVALID_POSITION if this tab is not currently in the action bar. </para>
						/// </returns>
						/// <java-name>
						/// getPosition
						/// </java-name>
						public abstract int Position
						{
								[Dot42.DexImport("getPosition", "()I", AccessFlags = 1025)]
								get;
						}

						/// <summary>
						///  <para>Return the icon associated with this tab.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>The tab's icon </para>
						/// </returns>
						/// <java-name>
						/// getIcon
						/// </java-name>
						public abstract global::Android.Graphics.Drawables.Drawable Icon
						{
								[Dot42.DexImport("getIcon", "()Landroid/graphics/drawable/Drawable;", AccessFlags = 1025)]
								get;
						}

						/// <summary>
						///  <para>Return the text of this tab.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>The tab's text </para>
						/// </returns>
						/// <java-name>
						/// getText
						/// </java-name>
						public abstract global::Java.Lang.ICharSequence Text
						{
								[Dot42.DexImport("getText", "()Ljava/lang/CharSequence;", AccessFlags = 1025)]
								get;
						}

						/// <summary>
						///  <para>Retrieve a previously set custom view for this tab.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>The custom view set by setCustomView(View). </para>
						/// </returns>
						/// <java-name>
						/// getCustomView
						/// </java-name>
						public abstract global::Android.Views.View CustomView
						{
								[Dot42.DexImport("getCustomView", "()Landroid/view/View;", AccessFlags = 1025)]
								get;
						}

						/// <summary>
						///  <para></para>        
						/// </summary>
						/// <returns>
						///  <para>This Tab's tag object. </para>
						/// </returns>
						/// <java-name>
						/// getTag
						/// </java-name>
						public abstract object Tag
						{
								[Dot42.DexImport("getTag", "()Ljava/lang/Object;", AccessFlags = 1025)]
								get;
						}

						/// <summary>
						///  <para>Gets a brief description of this tab's content for use in accessibility support.</para> <para> <para>setContentDescription(CharSequence) </para> <para>setContentDescription(int) </para></para>        
						/// </summary>
						/// <returns>
						///  <para>Description of this tab's content </para>
						/// </returns>
						/// <java-name>
						/// getContentDescription
						/// </java-name>
						public abstract global::Java.Lang.ICharSequence ContentDescription
						{
								[Dot42.DexImport("getContentDescription", "()Ljava/lang/CharSequence;", AccessFlags = 1025)]
								get;
						}

				}

				/// <summary>
				///  <para>Listener for receiving events when action bar menus are shown or hidden. </para>    
				/// </summary>
				/// <java-name>
				/// android/app/ActionBar$OnMenuVisibilityListener
				/// </java-name>
				[Dot42.DexImport("android/app/ActionBar$OnMenuVisibilityListener", AccessFlags = 1545)]
				public partial interface IOnMenuVisibilityListener
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>Called when an action bar menu is shown or hidden. Applications may want to use this to tune auto-hiding behavior for the action bar or pause/resume video playback, gameplay, or other activity within the main content area.</para> <para></para>        
						/// </summary>
						/// <java-name>
						/// onMenuVisibilityChanged
						/// </java-name>
						[Dot42.DexImport("onMenuVisibilityChanged", "(Z)V", AccessFlags = 1025)]
						void OnMenuVisibilityChanged(bool isVisible) /* MethodBuilder.Create */ ;

				}

				/// <summary>
				///  <para>Listener interface for ActionBar navigation events. </para>    
				/// </summary>
				/// <java-name>
				/// android/app/ActionBar$OnNavigationListener
				/// </java-name>
				[Dot42.DexImport("android/app/ActionBar$OnNavigationListener", AccessFlags = 1545)]
				public partial interface IOnNavigationListener
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>This method is called whenever a navigation item in your action bar is selected.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>True if the event was handled, false otherwise. </para>
						/// </returns>
						/// <java-name>
						/// onNavigationItemSelected
						/// </java-name>
						[Dot42.DexImport("onNavigationItemSelected", "(IJ)Z", AccessFlags = 1025)]
						bool OnNavigationItemSelected(int itemPosition, long itemId) /* MethodBuilder.Create */ ;

				}

		}

		/// <summary>
		///  <para>An activity is a single, focused thing that the user can do. Almost all activities interact with the user, so the Activity class takes care of creating a window for you in which you can place your UI with setContentView. While activities are often presented to the user as full-screen windows, they can also be used in other ways: as floating windows (via a theme with android.R.attr#windowIsFloating set) or embedded inside of another activity (using ActivityGroup).</para> <para>There are two methods almost all subclasses of Activity will implement:</para> <para> <ul> <li> <para>onCreate is where you initialize your activity. Most importantly, here you will usually call setContentView(int) with a layout resource defining your UI, and using findViewById to retrieve the widgets in that UI that you need to interact with programmatically.</para> <para></para></li> <li> <para>onPause is where you deal with the user leaving your activity. Most importantly, any changes made by the user should at this point be committed (usually to the android.content.ContentProvider holding the data). </para></li></ul></para> <para>To be of use with Context.startActivity(), all activity classes must have a corresponding &lt;activity&gt; declaration in their package's  <code>AndroidManifest.xml</code>.</para> <para>Topics covered here:  <ol> <li> <para> </para></li> <li> <para> </para></li> <li> <para> </para></li> <li> <para> </para></li> <li> <para> </para></li> <li> <para> </para></li> <li> <para> </para></li></ol></para> <para>  <h3>Developer Guides</h3></para> <para> </para> <para>The Activity class is an important part of an application's overall lifecycle, and the way activities are launched and put together is a fundamental part of the platform's application model. For a detailed perspective on the structure of an Android application and how activities behave, please read the  and  developer guides.</para> <para></para> <para></para> <para>You can also find a detailed discussion about how to create activities in the  developer guide.</para> <para> </para> <para>  <h3>Fragments</h3></para> <para>Starting with android.os.Build.VERSION_CODES#HONEYCOMB, Activity implementations can make use of the Fragment class to better modularize their code, build more sophisticated user interfaces for larger screens, and help scale their application between small and large screens.</para> <para>  <h3>Activity Lifecycle</h3></para> <para>Activities in the system are managed as an  <b>activity stack</b>. When a new activity is started, it is placed on the top of the stack and becomes the running activity  the previous activity always remains below it in the stack, and will not come to the foreground again until the new activity exits.</para> <para>An activity has essentially four states:</para> <para> <ul> <li> <para>If an activity in the foreground of the screen (at the top of the stack), it is  <b>active</b> or  <b>running</b>.  </para></li> <li> <para>If an activity has lost focus but is still visible (that is, a new non-full-sized or transparent activity has focus on top of your activity), it is  <b>paused</b>. A paused activity is completely alive (it maintains all state and member information and remains attached to the window manager), but can be killed by the system in extreme low memory situations. </para></li> <li> <para>If an activity is completely obscured by another activity, it is  <b>stopped</b>. It still retains all state and member information, however, it is no longer visible to the user so its window is hidden and it will often be killed by the system when memory is needed elsewhere. </para></li> <li> <para>If an activity is paused or stopped, the system can drop the activity from memory by either asking it to finish, or simply killing its process. When it is displayed again to the user, it must be completely restarted and restored to its previous state. </para></li></ul></para> <para>The following diagram shows the important state paths of an Activity. The square rectangles represent callback methods you can implement to perform operations when the Activity moves between states. The colored ovals are major states the Activity can be in.</para> <para> <image></image></para> <para>There are three key loops you may be interested in monitoring within your activity:</para> <para> <ul> <li> <para>The  <b>entire lifetime</b> of an activity happens between the first call to android.app.Activity#onCreate through to a single final call to android.app.Activity#onDestroy. An activity will do all setup of "global" state in onCreate(), and release all remaining resources in onDestroy(). For example, if it has a thread running in the background to download data from the network, it may create that thread in onCreate() and then stop the thread in onDestroy().</para> <para></para></li> <li> <para>The  <b>visible lifetime</b> of an activity happens between a call to android.app.Activity#onStart until a corresponding call to android.app.Activity#onStop. During this time the user can see the activity on-screen, though it may not be in the foreground and interacting with the user. Between these two methods you can maintain resources that are needed to show the activity to the user. For example, you can register a android.content.BroadcastReceiver in onStart() to monitor for changes that impact your UI, and unregister it in onStop() when the user no longer sees what you are displaying. The onStart() and onStop() methods can be called multiple times, as the activity becomes visible and hidden to the user.</para> <para></para></li> <li> <para>The  <b>foreground lifetime</b> of an activity happens between a call to android.app.Activity#onResume until a corresponding call to android.app.Activity#onPause. During this time the activity is in front of all other activities and interacting with the user. An activity can frequently go between the resumed and paused states  for example when the device goes to sleep, when an activity result is delivered, when a new intent is delivered  so the code in these methods should be fairly lightweight. </para></li></ul></para> <para>The entire lifecycle of an activity is defined by the following Activity methods. All of these are hooks that you can override to do appropriate work when the activity changes state. All activities will implement android.app.Activity#onCreate to do their initial setup; many will also implement android.app.Activity#onPause to commit changes to data and otherwise prepare to stop interacting with the user. You should always call up to your superclass when implementing these methods.</para> <para> <pre>
		/// public class Activity extends ApplicationContext {
		///     protected void onCreate(Bundle savedInstanceState);</pre></para> <para> <pre>    protected void onStart();</pre></para> <para> <pre>    protected void onRestart();</pre></para> <para> <pre>    protected void onResume();</pre></para> <para> <pre>    protected void onPause();</pre></para> <para> <pre>    protected void onStop();</pre></para> <para> <pre>    protected void onDestroy();
		/// }
		/// </pre></para> <para>In general the movement through an activity's lifecycle looks like this:</para> <para> <table></table>&lt;colgroup align="left"&gt; &lt;colgroup align="center"&gt; &lt;colgroup align="center"&gt;</para> <para>&lt;thead&gt; </para> <para>Method </para> <para>Description </para> <para>Killable? </para> <para>Next &lt;/thead&gt;</para> <para>&lt;tbody&gt; </para> <para>onCreate() </para> <para>Called when the activity is first created. This is where you should do all of your normal static set up: create views, bind data to lists, etc. This method also provides you with a Bundle containing the activity's previously frozen state, if there was one. </para> <para>Always followed by  <code>onStart()</code>. </para> <para>No </para> <para> <code>onStart()</code> </para> <para>     </para> <para>onRestart() </para> <para>Called after your activity has been stopped, prior to it being started again. </para> <para>Always followed by  <code>onStart()</code> </para> <para>No </para> <para> <code>onStart()</code> </para> <para>onStart() </para> <para>Called when the activity is becoming visible to the user. </para> <para>Followed by  <code>onResume()</code> if the activity comes to the foreground, or  <code>onStop()</code> if it becomes hidden. </para> <para>No </para> <para> <code>onResume()</code> or  <code>onStop()</code> </para> <para>     </para> <para>onResume() </para> <para>Called when the activity will start interacting with the user. At this point your activity is at the top of the activity stack, with user input going to it. </para> <para>Always followed by  <code>onPause()</code>. </para> <para>No </para> <para> <code>onPause()</code> </para> <para>onPause() </para> <para>Called when the system is about to start resuming a previous activity. This is typically used to commit unsaved changes to persistent data, stop animations and other things that may be consuming CPU, etc. Implementations of this method must be very quick because the next activity will not be resumed until this method returns. </para> <para>Followed by either  <code>onResume()</code> if the activity returns back to the front, or  <code>onStop()</code> if it becomes invisible to the user. </para> <para>&lt;font color="#800000"&gt; <b>Pre-android.os.Build.VERSION_CODES#HONEYCOMB</b>&lt;/font&gt; </para> <para> <code>onResume()</code> or <br></br>  <code>onStop()</code> </para> <para>onStop() </para> <para>Called when the activity is no longer visible to the user, because another activity has been resumed and is covering this one. This may happen either because a new activity is being started, an existing one is being brought in front of this one, or this one is being destroyed. </para> <para>Followed by either  <code>onRestart()</code> if this activity is coming back to interact with the user, or  <code>onDestroy()</code> if this activity is going away. </para> <para>&lt;font color="#800000"&gt; <b>Yes</b>&lt;/font&gt; </para> <para> <code>onRestart()</code> or <br></br>  <code>onDestroy()</code> </para> <para>onDestroy() </para> <para>The final call you receive before your activity is destroyed. This can happen either because the activity is finishing (someone called Activity#finish on it, or because the system is temporarily destroying this instance of the activity to save space. You can distinguish between these two scenarios with the Activity#isFinishing method. </para> <para>&lt;font color="#800000"&gt; <b>Yes</b>&lt;/font&gt; </para> <para> <b>nothing</b>  &lt;/tbody&gt; </para> <para>Note the "Killable" column in the above table  for those methods that are marked as being killable, after that method returns the process hosting the activity may killed by the system  <b>at any time</b> without another line of its code being executed. Because of this, you should use the onPause method to write any persistent data (such as user edits) to storage. In addition, the method onSaveInstanceState(Bundle) is called before placing the activity in such a background state, allowing you to save away any dynamic instance state in your activity into the given Bundle, to be later received in onCreate if the activity needs to be re-created. See the  section for more information on how the lifecycle of a process is tied to the activities it is hosting. Note that it is important to save persistent data in onPause instead of onSaveInstanceState because the latter is not part of the lifecycle callbacks, so will not be called in every situation as described in its documentation.</para> <para>Be aware that these semantics will change slightly between applications targeting platforms starting with android.os.Build.VERSION_CODES#HONEYCOMB vs. those targeting prior platforms. Starting with Honeycomb, an application is not in the killable state until its onStop has returned. This impacts when onSaveInstanceState(Bundle) may be called (it may be safely called after onPause() and allows and application to safely wait until onStop() to save persistent state.</para> <para>For those methods that are not marked as being killable, the activity's process will not be killed by the system starting from the time the method is called and continuing after it returns. Thus an activity is in the killable state, for example, between after  <code>onPause()</code> to the start of  <code>onResume()</code>.</para> <para>  <h3>Configuration Changes</h3></para> <para>If the configuration of the device (as defined by the Resources.Configuration class) changes, then anything displaying a user interface will need to update to match that configuration. Because Activity is the primary mechanism for interacting with the user, it includes special support for handling configuration changes.</para> <para>Unless you specify otherwise, a configuration change (such as a change in screen orientation, language, input devices, etc) will cause your current activity to be  <b>destroyed</b>, going through the normal activity lifecycle process of onPause, onStop, and onDestroy as appropriate. If the activity had been in the foreground or visible to the user, once onDestroy is called in that instance then a new instance of the activity will be created, with whatever savedInstanceState the previous instance had generated from onSaveInstanceState.</para> <para>This is done because any application resource, including layout files, can change based on any configuration value. Thus the only safe way to handle a configuration change is to re-retrieve all resources, including layouts, drawables, and strings. Because activities must already know how to save their state and re-create themselves from that state, this is a convenient way to have an activity restart itself with a new configuration.</para> <para>In some special cases, you may want to bypass restarting of your activity based on one or more types of configuration changes. This is done with the android:configChanges attribute in its manifest. For any types of configuration changes you say that you handle there, you will receive a call to your current activity's onConfigurationChanged method instead of being restarted. If a configuration change involves any that you do not handle, however, the activity will still be restarted and onConfigurationChanged will not be called.</para> <para>  <h3>Starting Activities and Getting Results</h3></para> <para>The android.app.Activity#startActivity method is used to start a new activity, which will be placed at the top of the activity stack. It takes a single argument, an Intent, which describes the activity to be executed.</para> <para>Sometimes you want to get a result back from an activity when it ends. For example, you may start an activity that lets the user pick a person in a list of contacts; when it ends, it returns the person that was selected. To do this, you call the android.app.Activity#startActivityForResult(Intent, int) version with a second integer parameter identifying the call. The result will come back through your android.app.Activity#onActivityResult method.</para> <para>When an activity exits, it can call android.app.Activity#setResult(int) to return data back to its parent. It must always supply a result code, which can be the standard results RESULT_CANCELED, RESULT_OK, or any custom values starting at RESULT_FIRST_USER. In addition, it can optionally return back an Intent containing any additional data it wants. All of this information appears back on the parent's  <code>Activity.onActivityResult()</code>, along with the integer identifier it originally supplied.</para> <para>If a child activity fails for any reason (such as crashing), the parent activity will receive a result with the code RESULT_CANCELED.</para> <para> <pre>
		/// public class MyActivity extends Activity {
		///     ...</pre></para> <para> <pre>    static final int PICK_CONTACT_REQUEST = 0;</pre></para> <para> <pre>    protected boolean onKeyDown(int keyCode, KeyEvent event) {
		///         if (keyCode == KeyEvent.KEYCODE_DPAD_CENTER) {
		///             // When the user center presses, let them pick a contact.
		///             startActivityForResult(
		///                 new Intent(Intent.ACTION_PICK,
		///                 new Uri("content://contacts")),
		///                 PICK_CONTACT_REQUEST);
		///            return true;
		///         }
		///         return false;
		///     }</pre></para> <para> <pre>    protected void onActivityResult(int requestCode, int resultCode,
		///             Intent data) {
		///         if (requestCode == PICK_CONTACT_REQUEST) {
		///             if (resultCode == RESULT_OK) {
		///                 // A contact was picked.  Here we will just display it
		///                 // to the user.
		///                 startActivity(new Intent(Intent.ACTION_VIEW, data));
		///             }
		///         }
		///     }
		/// }
		/// </pre></para> <para>  <h3>Saving Persistent State</h3></para> <para>There are generally two kinds of persistent state than an activity will deal with: shared document-like data (typically stored in a SQLite database using a  android.content.ContentProvider content provider}) and internal state such as user preferences.</para> <para>For content provider data, we suggest that activities use a "edit in place" user model. That is, any edits a user makes are effectively made immediately without requiring an additional confirmation step. Supporting this model is generally a simple matter of following two rules:</para> <para> <ul> <li> <para></para> <para>When creating a new document, the backing database entry or file for it is created immediately. For example, if the user chooses to write a new e-mail, a new entry for that e-mail is created as soon as they start entering data, so that if they go to any other activity after that point this e-mail will now appear in the list of drafts.</para> <para></para></li> <li> <para></para> <para>When an activity's  <code>onPause()</code> method is called, it should commit to the backing content provider or file any changes the user has made. This ensures that those changes will be seen by any other activity that is about to run. You will probably want to commit your data even more aggressively at key times during your activity's lifecycle: for example before starting a new activity, before finishing your own activity, when the user switches between input fields, etc.</para> <para></para></li></ul></para> <para>This model is designed to prevent data loss when a user is navigating between activities, and allows the system to safely kill an activity (because system resources are needed somewhere else) at any time after it has been paused. Note this implies that the user pressing BACK from your activity does  <b>not</b> mean "cancel"  it means to leave the activity with its current contents saved away. Canceling edits in an activity must be provided through some other mechanism, such as an explicit "revert" or "undo" option.</para> <para>See the  android.content.ContentProvider content package} for more information about content providers. These are a key aspect of how different activities invoke and propagate data between themselves.</para> <para>The Activity class also provides an API for managing internal persistent state associated with an activity. This can be used, for example, to remember the user's preferred initial display in a calendar (day view or week view) or the user's default home page in a web browser.</para> <para>Activity persistent state is managed with the method getPreferences, allowing you to retrieve and modify a set of name/value pairs associated with the activity. To use preferences that are shared across multiple application components (activities, receivers, services, providers), you can use the underlying Context.getSharedPreferences() method to retrieve a preferences object stored under a specific name. (Note that it is not possible to share settings data across application packages  for that you will need a content provider.)</para> <para>Here is an excerpt from a calendar activity that stores the user's preferred view mode in its persistent settings:</para> <para> <pre>
		/// public class CalendarActivity extends Activity {
		///     ...</pre></para> <para> <pre>    static final int DAY_VIEW_MODE = 0;
		///     static final int WEEK_VIEW_MODE = 1;</pre></para> <para> <pre>    private SharedPreferences mPrefs;
		///     private int mCurViewMode;</pre></para> <para> <pre>    protected void onCreate(Bundle savedInstanceState) {
		///         super.onCreate(savedInstanceState);</pre></para> <para> <pre>        SharedPreferences mPrefs = getSharedPreferences();
		///         mCurViewMode = mPrefs.getInt("view_mode", DAY_VIEW_MODE);
		///     }</pre></para> <para> <pre>    protected void onPause() {
		///         super.onPause();</pre></para> <para> <pre>        SharedPreferences.Editor ed = mPrefs.edit();
		///         ed.putInt("view_mode", mCurViewMode);
		///         ed.commit();
		///     }
		/// }
		/// </pre></para> <para>  <h3>Permissions</h3></para> <para>The ability to start a particular Activity can be enforced when it is declared in its manifest's &lt;activity&gt; tag. By doing so, other applications will need to declare a corresponding &lt;uses-permission&gt; element in their own manifest to be able to start that activity.</para> <para>When starting an Activity you can set Intent.FLAG_GRANT_READ_URI_PERMISSION and/or Intent.FLAG_GRANT_WRITE_URI_PERMISSION on the Intent. This will grant the Activity access to the specific URIs in the Intent. Access will remain until the Activity has finished (it will remain across the hosting process being killed and other temporary destruction). As of android.os.Build.VERSION_CODES#GINGERBREAD, if the Activity was already created and a new Intent is being delivered to onNewIntent(Intent), any newly granted URI permissions will be added to the existing ones it holds.</para> <para>See the  document for more information on permissions and security in general.</para> <para>  <h3>Process Lifecycle</h3></para> <para>The Android system attempts to keep application process around for as long as possible, but eventually will need to remove old processes when memory runs low. As described in , the decision about which process to remove is intimately tied to the state of the user's interaction with it. In general, there are four states a process can be in based on the activities running in it, listed here in order of importance. The system will kill less important processes (the last ones) before it resorts to killing more important processes (the first ones).</para> <para> <ol> <li> <para></para> <para>The  <b>foreground activity</b> (the activity at the top of the screen that the user is currently interacting with) is considered the most important. Its process will only be killed as a last resort, if it uses more memory than is available on the device. Generally at this point the device has reached a memory paging state, so this is required in order to keep the user interface responsive. </para></li> <li> <para></para> <para>A  <b>visible activity</b> (an activity that is visible to the user but not in the foreground, such as one sitting behind a foreground dialog) is considered extremely important and will not be killed unless that is required to keep the foreground activity running. </para></li> <li> <para></para> <para>A  <b>background activity</b> (an activity that is not visible to the user and has been paused) is no longer critical, so the system may safely kill its process to reclaim memory for other foreground or visible processes. If its process needs to be killed, when the user navigates back to the activity (making it visible on the screen again), its onCreate method will be called with the savedInstanceState it had previously supplied in onSaveInstanceState so that it can restart itself in the same state as the user last left it. </para></li> <li> <para></para> <para>An  <b>empty process</b> is one hosting no activities or other application components (such as Service or android.content.BroadcastReceiver classes). These are killed very quickly by the system as memory becomes low. For this reason, any background operation you do outside of an activity must be executed in the context of an activity BroadcastReceiver or Service to ensure that the system knows it needs to keep your process around. </para></li></ol></para> <para>Sometimes an Activity may need to do a long-running operation that exists independently of the activity lifecycle itself. An example may be a camera application that allows you to upload a picture to a web site. The upload may take a long time, and the application should allow the user to leave the application will it is executing. To accomplish this, your Activity should start a Service in which the upload takes place. This allows the system to properly prioritize your process (considering it to be more important than other non-visible applications) for the duration of the upload, independent of whether the original activity is paused, stopped, or finished. </para>    
		/// </summary>
		/// <java-name>
		/// android/app/Activity
		/// </java-name>
		[Dot42.DexImport("android/app/Activity", AccessFlags = 33)]
		public partial class Activity : global::Android.Views.ContextThemeWrapper, global::Android.Views.LayoutInflater.IFactory2, global::Android.Views.Window.ICallback, global::Android.Views.KeyEvent.ICallback, global::Android.Views.View.IOnCreateContextMenuListener, global::Android.Content.IComponentCallbacks2
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Standard activity result: operation canceled. </para>        
				/// </summary>
				/// <java-name>
				/// RESULT_CANCELED
				/// </java-name>
				[Dot42.DexImport("RESULT_CANCELED", "I", AccessFlags = 25)]
				public const int RESULT_CANCELED = 0;
				/// <summary>
				///  <para>Standard activity result: operation succeeded. </para>        
				/// </summary>
				/// <java-name>
				/// RESULT_OK
				/// </java-name>
				[Dot42.DexImport("RESULT_OK", "I", AccessFlags = 25)]
				public const int RESULT_OK = -1;
				/// <summary>
				///  <para>Start of user-defined activity results. </para>        
				/// </summary>
				/// <java-name>
				/// RESULT_FIRST_USER
				/// </java-name>
				[Dot42.DexImport("RESULT_FIRST_USER", "I", AccessFlags = 25)]
				public const int RESULT_FIRST_USER = 1;
				/// <java-name>
				/// FOCUSED_STATE_SET
				/// </java-name>
				[Dot42.DexImport("FOCUSED_STATE_SET", "[I", AccessFlags = 28)]
				protected internal static readonly int[] FOCUSED_STATE_SET;
				/// <summary>
				///  <para>Use with setDefaultKeyMode to turn off default handling of keys.</para> <para> <para>setDefaultKeyMode </para></para>        
				/// </summary>
				/// <java-name>
				/// DEFAULT_KEYS_DISABLE
				/// </java-name>
				[Dot42.DexImport("DEFAULT_KEYS_DISABLE", "I", AccessFlags = 25)]
				public const int DEFAULT_KEYS_DISABLE = 0;
				/// <summary>
				///  <para>Use with setDefaultKeyMode to launch the dialer during default key handling.</para> <para> <para>setDefaultKeyMode </para></para>        
				/// </summary>
				/// <java-name>
				/// DEFAULT_KEYS_DIALER
				/// </java-name>
				[Dot42.DexImport("DEFAULT_KEYS_DIALER", "I", AccessFlags = 25)]
				public const int DEFAULT_KEYS_DIALER = 1;
				/// <summary>
				///  <para>Use with setDefaultKeyMode to execute a menu shortcut in default key handling.</para> <para>That is, the user does not need to hold down the menu key to execute menu shortcuts.</para> <para> <para>setDefaultKeyMode </para></para>        
				/// </summary>
				/// <java-name>
				/// DEFAULT_KEYS_SHORTCUT
				/// </java-name>
				[Dot42.DexImport("DEFAULT_KEYS_SHORTCUT", "I", AccessFlags = 25)]
				public const int DEFAULT_KEYS_SHORTCUT = 2;
				/// <summary>
				///  <para>Use with setDefaultKeyMode to specify that unhandled keystrokes will start an application-defined search. (If the application or activity does not actually define a search, the the keys will be ignored.)</para> <para>See android.app.SearchManager for more details.</para> <para> <para>setDefaultKeyMode </para></para>        
				/// </summary>
				/// <java-name>
				/// DEFAULT_KEYS_SEARCH_LOCAL
				/// </java-name>
				[Dot42.DexImport("DEFAULT_KEYS_SEARCH_LOCAL", "I", AccessFlags = 25)]
				public const int DEFAULT_KEYS_SEARCH_LOCAL = 3;
				/// <summary>
				///  <para>Use with setDefaultKeyMode to specify that unhandled keystrokes will start a global search (typically web search, but some platforms may define alternate methods for global search)</para> <para>See android.app.SearchManager for more details.</para> <para> <para>setDefaultKeyMode </para></para>        
				/// </summary>
				/// <java-name>
				/// DEFAULT_KEYS_SEARCH_GLOBAL
				/// </java-name>
				[Dot42.DexImport("DEFAULT_KEYS_SEARCH_GLOBAL", "I", AccessFlags = 25)]
				public const int DEFAULT_KEYS_SEARCH_GLOBAL = 4;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Activity() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Called when the activity is starting. This is where most initialization should go: calling setContentView(int) to inflate the activity's UI, using findViewById to programmatically interact with widgets in the UI, calling managedQuery(android.net.Uri , String[], String, String[], String) to retrieve cursors for data being displayed, etc.</para> <para>You can call finish from within this function, in which case onDestroy() will be immediately called without any of the rest of the activity lifecycle (onStart, onResume, onPause, etc) executing.</para> <para> <b>Derived classes must call through to the super class's implementation of this method. If they do not, an exception will be thrown.</b></para> <para> <para>onStart </para> <para>onSaveInstanceState </para> <para>onRestoreInstanceState </para> <para>onPostCreate </para></para>        
				/// </summary>
				/// <java-name>
				/// onCreate
				/// </java-name>
				[Dot42.DexImport("onCreate", "(Landroid/os/Bundle;)V", AccessFlags = 4)]
				protected internal virtual void OnCreate(global::Android.OS.Bundle savedInstanceState) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>This method is called after onStart when the activity is being re-initialized from a previously saved state, given here in  <b>savedInstanceState</b>. Most implementations will simply use onCreate to restore their state, but it is sometimes convenient to do it here after all of the initialization has been done or to allow subclasses to decide whether to use your default implementation. The default implementation of this method performs a restore of any view state that had previously been frozen by onSaveInstanceState.</para> <para>This method is called between onStart and onPostCreate.</para> <para> <para>onCreate </para> <para>onPostCreate </para> <para>onResume </para> <para>onSaveInstanceState </para></para>        
				/// </summary>
				/// <java-name>
				/// onRestoreInstanceState
				/// </java-name>
				[Dot42.DexImport("onRestoreInstanceState", "(Landroid/os/Bundle;)V", AccessFlags = 4)]
				protected internal virtual void OnRestoreInstanceState(global::Android.OS.Bundle savedInstanceState) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Called when activity start-up is complete (after onStart and onRestoreInstanceState have been called). Applications will generally not implement this method; it is intended for system classes to do final initialization after application code has run.</para> <para> <b>Derived classes must call through to the super class's implementation of this method. If they do not, an exception will be thrown.</b></para> <para> <para>onCreate </para></para>        
				/// </summary>
				/// <java-name>
				/// onPostCreate
				/// </java-name>
				[Dot42.DexImport("onPostCreate", "(Landroid/os/Bundle;)V", AccessFlags = 4)]
				protected internal virtual void OnPostCreate(global::Android.OS.Bundle savedInstanceState) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Called after onCreate  or after onRestart when the activity had been stopped, but is now again being displayed to the user. It will be followed by onResume.</para> <para> <b>Derived classes must call through to the super class's implementation of this method. If they do not, an exception will be thrown.</b></para> <para> <para>onCreate </para> <para>onStop </para> <para>onResume </para></para>        
				/// </summary>
				/// <java-name>
				/// onStart
				/// </java-name>
				[Dot42.DexImport("onStart", "()V", AccessFlags = 4)]
				protected internal virtual void OnStart() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Called after onStop when the current activity is being re-displayed to the user (the user has navigated back to it). It will be followed by onStart and then onResume.</para> <para>For activities that are using raw Cursor objects (instead of creating them through managedQuery(android.net.Uri , String[], String, String[], String), this is usually the place where the cursor should be requeried (because you had deactivated it in onStop.</para> <para> <b>Derived classes must call through to the super class's implementation of this method. If they do not, an exception will be thrown.</b></para> <para> <para>onStop </para> <para>onStart </para> <para>onResume </para></para>        
				/// </summary>
				/// <java-name>
				/// onRestart
				/// </java-name>
				[Dot42.DexImport("onRestart", "()V", AccessFlags = 4)]
				protected internal virtual void OnRestart() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Called after onRestoreInstanceState, onRestart, or onPause, for your activity to start interacting with the user. This is a good place to begin animations, open exclusive-access devices (such as the camera), etc.</para> <para>Keep in mind that onResume is not the best indicator that your activity is visible to the user; a system window such as the keyguard may be in front. Use onWindowFocusChanged to know for certain that your activity is visible to the user (for example, to resume a game).</para> <para> <b>Derived classes must call through to the super class's implementation of this method. If they do not, an exception will be thrown.</b></para> <para> <para>onRestoreInstanceState </para> <para>onRestart </para> <para>onPostResume </para> <para>onPause </para></para>        
				/// </summary>
				/// <java-name>
				/// onResume
				/// </java-name>
				[Dot42.DexImport("onResume", "()V", AccessFlags = 4)]
				protected internal virtual void OnResume() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Called when activity resume is complete (after onResume has been called). Applications will generally not implement this method; it is intended for system classes to do final setup after application resume code has run.</para> <para> <b>Derived classes must call through to the super class's implementation of this method. If they do not, an exception will be thrown.</b></para> <para> <para>onResume </para></para>        
				/// </summary>
				/// <java-name>
				/// onPostResume
				/// </java-name>
				[Dot42.DexImport("onPostResume", "()V", AccessFlags = 4)]
				protected internal virtual void OnPostResume() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>This is called for activities that set launchMode to "singleTop" in their package, or if a client used the Intent#FLAG_ACTIVITY_SINGLE_TOP flag when calling startActivity. In either case, when the activity is re-launched while at the top of the activity stack instead of a new instance of the activity being started, onNewIntent() will be called on the existing instance with the Intent that was used to re-launch it.</para> <para>An activity will always be paused before receiving a new intent, so you can count on onResume being called after this method.</para> <para>Note that getIntent still returns the original Intent. You can use setIntent to update it to this new Intent.</para> <para> <para>getIntent </para> <para>setIntent </para> <para>onResume </para></para>        
				/// </summary>
				/// <java-name>
				/// onNewIntent
				/// </java-name>
				[Dot42.DexImport("onNewIntent", "(Landroid/content/Intent;)V", AccessFlags = 4)]
				protected internal virtual void OnNewIntent(global::Android.Content.Intent intent) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Called to retrieve per-instance state from an activity before being killed so that the state can be restored in onCreate or onRestoreInstanceState (the Bundle populated by this method will be passed to both).</para> <para>This method is called before an activity may be killed so that when it comes back some time in the future it can restore its state. For example, if activity B is launched in front of activity A, and at some point activity A is killed to reclaim resources, activity A will have a chance to save the current state of its user interface via this method so that when the user returns to activity A, the state of the user interface can be restored via onCreate or onRestoreInstanceState.</para> <para>Do not confuse this method with activity lifecycle callbacks such as onPause, which is always called when an activity is being placed in the background or on its way to destruction, or onStop which is called before destruction. One example of when onPause and onStop is called and not this method is when a user navigates back from activity B to activity A: there is no need to call onSaveInstanceState on B because that particular instance will never be restored, so the system avoids calling it. An example when onPause is called and not onSaveInstanceState is when activity B is launched in front of activity A: the system may avoid calling onSaveInstanceState on activity A if it isn't killed during the lifetime of B since the state of the user interface of A will stay intact.</para> <para>The default implementation takes care of most of the UI per-instance state for you by calling android.view.View#onSaveInstanceState() on each view in the hierarchy that has an id, and by saving the id of the currently focused view (all of which is restored by the default implementation of onRestoreInstanceState). If you override this method to save additional information not captured by each individual view, you will likely want to call through to the default implementation, otherwise be prepared to save all of the state of each view yourself.</para> <para>If called, this method will occur before onStop. There are no guarantees about whether it will occur before or after onPause.</para> <para> <para>onCreate </para> <para>onRestoreInstanceState </para> <para>onPause </para></para>        
				/// </summary>
				/// <java-name>
				/// onSaveInstanceState
				/// </java-name>
				[Dot42.DexImport("onSaveInstanceState", "(Landroid/os/Bundle;)V", AccessFlags = 4)]
				protected internal virtual void OnSaveInstanceState(global::Android.OS.Bundle outState) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Called as part of the activity lifecycle when an activity is going into the background, but has not (yet) been killed. The counterpart to onResume.</para> <para>When activity B is launched in front of activity A, this callback will be invoked on A. B will not be created until A's onPause returns, so be sure to not do anything lengthy here.</para> <para>This callback is mostly used for saving any persistent state the activity is editing, to present a "edit in place" model to the user and making sure nothing is lost if there are not enough resources to start the new activity without first killing this one. This is also a good place to do things like stop animations and other things that consume a noticeable amount of CPU in order to make the switch to the next activity as fast as possible, or to close resources that are exclusive access such as the camera.</para> <para>In situations where the system needs more memory it may kill paused processes to reclaim resources. Because of this, you should be sure that all of your state is saved by the time you return from this function. In general onSaveInstanceState is used to save per-instance state in the activity and this method is used to store global persistent data (in content providers, files, etc.)</para> <para>After receiving this call you will usually receive a following call to onStop (after the next activity has been resumed and displayed), however in some cases there will be a direct call back to onResume without going through the stopped state.</para> <para> <b>Derived classes must call through to the super class's implementation of this method. If they do not, an exception will be thrown.</b></para> <para> <para>onResume </para> <para>onSaveInstanceState </para> <para>onStop </para></para>        
				/// </summary>
				/// <java-name>
				/// onPause
				/// </java-name>
				[Dot42.DexImport("onPause", "()V", AccessFlags = 4)]
				protected internal virtual void OnPause() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Called as part of the activity lifecycle when an activity is about to go into the background as the result of user choice. For example, when the user presses the Home key, onUserLeaveHint will be called, but when an incoming phone call causes the in-call Activity to be automatically brought to the foreground, onUserLeaveHint will not be called on the activity being interrupted. In cases when it is invoked, this method is called right before the activity's onPause callback.</para> <para>This callback and onUserInteraction are intended to help activities manage status bar notifications intelligently; specifically, for helping activities determine the proper time to cancel a notfication.</para> <para> <para>onUserInteraction() </para></para>        
				/// </summary>
				/// <java-name>
				/// onUserLeaveHint
				/// </java-name>
				[Dot42.DexImport("onUserLeaveHint", "()V", AccessFlags = 4)]
				protected internal virtual void OnUserLeaveHint() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Generate a new thumbnail for this activity. This method is called before pausing the activity, and should draw into  <b>outBitmap</b> the imagery for the desired thumbnail in the dimensions of that bitmap. It can use the given  <b>canvas</b>, which is configured to draw into the bitmap, for rendering if desired.</para> <para>The default implementation returns fails and does not draw a thumbnail; this will result in the platform creating its own thumbnail if needed.</para> <para> <para>onCreateDescription </para> <para>onSaveInstanceState </para> <para>onPause </para></para>        
				/// </summary>
				/// <returns>
				///  <para>Return true if you have drawn into the bitmap; otherwise after you return it will be filled with a default thumbnail.</para>
				/// </returns>
				/// <java-name>
				/// onCreateThumbnail
				/// </java-name>
				[Dot42.DexImport("onCreateThumbnail", "(Landroid/graphics/Bitmap;Landroid/graphics/Canvas;)Z", AccessFlags = 1)]
				public virtual bool OnCreateThumbnail(global::Android.Graphics.Bitmap outBitmap, global::Android.Graphics.Canvas canvas) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Generate a new description for this activity. This method is called before pausing the activity and can, if desired, return some textual description of its current state to be displayed to the user.</para> <para>The default implementation returns null, which will cause you to inherit the description from the previous activity. If all activities return null, generally the label of the top activity will be used as the description.</para> <para> <para>onCreateThumbnail </para> <para>onSaveInstanceState </para> <para>onPause </para></para>        
				/// </summary>
				/// <returns>
				///  <para>A description of what the user is doing. It should be short and sweet (only a few words).</para>
				/// </returns>
				/// <java-name>
				/// onCreateDescription
				/// </java-name>
				[Dot42.DexImport("onCreateDescription", "()Ljava/lang/CharSequence;", AccessFlags = 1)]
				public virtual global::Java.Lang.ICharSequence OnCreateDescription() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <summary>
				///  <para>This is called when the user is requesting an assist, to build a full Intent#ACTION_ASSIST Intent with all of the context of the current application. You can override this method to place into the bundle anything you would like to appear in the Intent#EXTRA_ASSIST_CONTEXT part of the assist Intent. The default implementation does nothing.</para> <para>This function will be called after any global assist callbacks that had been registered with Application.registerOnProvideAssistDataListener. </para>        
				/// </summary>
				/// <java-name>
				/// onProvideAssistData
				/// </java-name>
				[Dot42.DexImport("onProvideAssistData", "(Landroid/os/Bundle;)V", AccessFlags = 1)]
				public virtual void OnProvideAssistData(global::Android.OS.Bundle data) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Called when you are no longer visible to the user. You will next receive either onRestart, onDestroy, or nothing, depending on later user activity.</para> <para>Note that this method may never be called, in low memory situations where the system does not have enough memory to keep your activity's process running after its onPause method is called.</para> <para> <b>Derived classes must call through to the super class's implementation of this method. If they do not, an exception will be thrown.</b></para> <para> <para>onRestart </para> <para>onResume </para> <para>onSaveInstanceState </para> <para>onDestroy </para></para>        
				/// </summary>
				/// <java-name>
				/// onStop
				/// </java-name>
				[Dot42.DexImport("onStop", "()V", AccessFlags = 4)]
				protected internal virtual void OnStop() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Perform any final cleanup before an activity is destroyed. This can happen either because the activity is finishing (someone called finish on it, or because the system is temporarily destroying this instance of the activity to save space. You can distinguish between these two scenarios with the isFinishing method.</para> <para> <b>Note: do not count on this method being called as a place for saving data! For example, if an activity is editing data in a content provider, those edits should be committed in either onPause or onSaveInstanceState, not here.</b> This method is usually implemented to free resources like threads that are associated with an activity, so that a destroyed activity does not leave such things around while the rest of its application is still running. There are situations where the system will simply kill the activity's hosting process without calling this method (or any others) in it, so it should not be used to do things that are intended to remain around after the process goes away.</para> <para> <b>Derived classes must call through to the super class's implementation of this method. If they do not, an exception will be thrown.</b></para> <para> <para>onPause </para> <para>onStop </para> <para>finish </para> <para>isFinishing </para></para>        
				/// </summary>
				/// <java-name>
				/// onDestroy
				/// </java-name>
				[Dot42.DexImport("onDestroy", "()V", AccessFlags = 4)]
				protected internal virtual void OnDestroy() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Called by the system when the device configuration changes while your activity is running. Note that this will  <b>only</b> be called if you have selected configurations you would like to handle with the android.R.attr#configChanges attribute in your manifest. If any configuration change occurs that is not selected to be reported by that attribute, then instead of reporting it the system will stop and restart the activity (to have it launched with the new configuration).</para> <para>At the time that this function has been called, your Resources object will have been updated to return resource values matching the new configuration.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// onConfigurationChanged
				/// </java-name>
				[Dot42.DexImport("onConfigurationChanged", "(Landroid/content/res/Configuration;)V", AccessFlags = 1)]
				public virtual void OnConfigurationChanged(global::Android.Content.Res.Configuration newConfig) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Called by the system, as part of destroying an activity due to a configuration change, when it is known that a new instance will immediately be created for the new configuration. You can return any object you like here, including the activity instance itself, which can later be retrieved by calling getLastNonConfigurationInstance() in the new activity instance.</para> <para> <b>If you are targeting android.os.Build.VERSION_CODES#HONEYCOMB or later, consider instead using a Fragment with Fragment.setRetainInstance(boolean.</b></para> <para>This function is called purely as an optimization, and you must not rely on it being called. When it is called, a number of guarantees will be made to help optimize configuration switching:  <ul> <li> <para>The function will be called between onStop and onDestroy. </para></li> <li> <para>A new instance of the activity will  <b>always</b> be immediately created after this one's onDestroy() is called. In particular,  <b>no</b> messages will be dispatched during this time (when the returned object does not have an activity to be associated with). </para></li> <li> <para>The object you return here will  <b>always</b> be available from the getLastNonConfigurationInstance() method of the following activity instance as described there. </para></li></ul></para> <para>These guarantees are designed so that an activity can use this API to propagate extensive state from the old to new activity instance, from loaded bitmaps, to network connections, to evenly actively running threads. Note that you should  <b>not</b> propagate any data that may change based on the configuration, including any data loaded from resources such as strings, layouts, or drawables.</para> <para>The guarantee of no message handling during the switch to the next activity simplifies use with active objects. For example if your retained state is an android.os.AsyncTask you are guaranteed that its call back functions (like android.os.AsyncTask#onPostExecute) will not be called from the call here until you execute the next instance's onCreate(Bundle). (Note however that there is of course no such guarantee for android.os.AsyncTask#doInBackground since that is running in a separate thread.)</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use the new Fragment API Fragment#setRetainInstance(boolean) instead; this is also available on older platforms through the Android compatibility package. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				///  <para>Return any Object holding the desired state to propagate to the next activity instance.</para>
				/// </returns>
				/// <java-name>
				/// onRetainNonConfigurationInstance
				/// </java-name>
				[Dot42.DexImport("onRetainNonConfigurationInstance", "()Ljava/lang/Object;", AccessFlags = 1)]
				public virtual object OnRetainNonConfigurationInstance() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <summary>
				///  <para>This is called when the overall system is running low on memory, and actively running processes should trim their memory usage. While the exact point at which this will be called is not defined, generally it will happen when all background process have been killed. That is, before reaching the point of killing processes hosting service and foreground UI that we would like to avoid killing.</para> <para>You should implement this method to release any caches or other unnecessary resources you may be holding on to. The system will perform a garbage collection for you after returning from this method. </para> <para>Preferably, you should implement ComponentCallbacks2#onTrimMemory from ComponentCallbacks2 to incrementally unload your resources based on various levels of memory demands. That API is available for API level 14 and higher, so you should only use this onLowMemory method as a fallback for older versions, which can be treated the same as ComponentCallbacks2#onTrimMemory with the ComponentCallbacks2#TRIM_MEMORY_COMPLETE level.</para>        
				/// </summary>
				/// <java-name>
				/// onLowMemory
				/// </java-name>
				[Dot42.DexImport("onLowMemory", "()V", AccessFlags = 1)]
				public virtual void OnLowMemory() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Called when the operating system has determined that it is a good time for a process to trim unneeded memory from its process. This will happen for example when it goes in the background and there is not enough memory to keep as many background processes running as desired. You should never compare to exact values of the level, since new intermediate values may be added  you will typically want to compare if the value is greater or equal to a level you are interested in.</para> <para>To retrieve the processes current trim level at any point, you can use ActivityManager.getMyMemoryState(RunningAppProcessInfo).</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// onTrimMemory
				/// </java-name>
				[Dot42.DexImport("onTrimMemory", "(I)V", AccessFlags = 1)]
				public virtual void OnTrimMemory(int level) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Called when a Fragment is being attached to this activity, immediately after the call to its Fragment.onAttach() method and before Fragment.onCreate(). </para>        
				/// </summary>
				/// <java-name>
				/// onAttachFragment
				/// </java-name>
				[Dot42.DexImport("onAttachFragment", "(Landroid/app/Fragment;)V", AccessFlags = 1)]
				public virtual void OnAttachFragment(global::Android.App.Fragment fragment) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Wrapper around ContentResolver#query(android.net.Uri , String[], String, String[], String) that gives the resulting Cursor to call startManagingCursor so that the activity will manage its lifecycle for you.</para> <para> <b>If you are targeting android.os.Build.VERSION_CODES#HONEYCOMB or later, consider instead using LoaderManager instead, available via getLoaderManager().</b></para> <para> <b>Warning:</b> Do not call Cursor#close() on a cursor obtained using this method, because the activity will do that for you at the appropriate time. However, if you call stopManagingCursor on a cursor from a managed query, the system  <b>will not</b> automatically close the cursor and, in that case, you must call Cursor#close().</para> <para> <para>ContentResolver::query(android.net.Uri , String[], String, String[], String) </para> <para>startManagingCursor</para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use CursorLoader instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				///  <para>The Cursor that was returned by query().</para>
				/// </returns>
				/// <java-name>
				/// managedQuery
				/// </java-name>
				[Dot42.DexImport("managedQuery", "(Landroid/net/Uri;[Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/l" +
    "ang/String;)Landroid/database/Cursor;", AccessFlags = 17)]
				public global::Android.Database.ICursor ManagedQuery(global::Android.Net.Uri uri, string[] projection, string selection, string[] selectionArgs, string sortOrder) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Database.ICursor);
				}

				/// <summary>
				///  <para>This method allows the activity to take care of managing the given Cursor's lifecycle for you based on the activity's lifecycle. That is, when the activity is stopped it will automatically call Cursor#deactivate on the given Cursor, and when it is later restarted it will call Cursor#requery for you. When the activity is destroyed, all managed Cursors will be closed automatically.</para> <para> <b>If you are targeting android.os.Build.VERSION_CODES#HONEYCOMB or later, consider instead using LoaderManager instead, available via getLoaderManager().</b></para> <para> <b>Warning:</b> Do not call Cursor#close() on cursor obtained from managedQuery, because the activity will do that for you at the appropriate time. However, if you call stopManagingCursor on a cursor from a managed query, the system  <b>will not</b> automatically close the cursor and, in that case, you must call Cursor#close().</para> <para> <para>managedQuery(android.net.Uri , String[], String, String[], String) </para> <para>stopManagingCursor</para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use the new android.content.CursorLoader class with LoaderManager instead; this is also available on older platforms through the Android compatibility package. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// startManagingCursor
				/// </java-name>
				[Dot42.DexImport("startManagingCursor", "(Landroid/database/Cursor;)V", AccessFlags = 1)]
				public virtual void StartManagingCursor(global::Android.Database.ICursor c) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Given a Cursor that was previously given to startManagingCursor, stop the activity's management of that cursor.</para> <para> <b>Warning:</b> After calling this method on a cursor from a managed query, the system  <b>will not</b> automatically close the cursor and you must call Cursor#close().</para> <para> <para>startManagingCursor</para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use the new android.content.CursorLoader class with LoaderManager instead; this is also available on older platforms through the Android compatibility package. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// stopManagingCursor
				/// </java-name>
				[Dot42.DexImport("stopManagingCursor", "(Landroid/database/Cursor;)V", AccessFlags = 1)]
				public virtual void StopManagingCursor(global::Android.Database.ICursor c) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Finds a view that was identified by the id attribute from the XML that was processed in onCreate.</para> <para></para>        
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
				///  <para>Set the activity content from a layout resource. The resource will be inflated, adding all top-level views to the activity.</para> <para> <para>setContentView(android.view.View) </para> <para>setContentView(android.view.View, android.view.ViewGroup.LayoutParams) </para></para>        
				/// </summary>
				/// <java-name>
				/// setContentView
				/// </java-name>
				[Dot42.DexImport("setContentView", "(I)V", AccessFlags = 1)]
				public virtual void SetContentView(int layoutResID) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Set the activity content from a layout resource. The resource will be inflated, adding all top-level views to the activity.</para> <para> <para>setContentView(android.view.View) </para> <para>setContentView(android.view.View, android.view.ViewGroup.LayoutParams) </para></para>        
				/// </summary>
				/// <java-name>
				/// setContentView
				/// </java-name>
				[Dot42.DexImport("setContentView", "(Landroid/view/View;)V", AccessFlags = 1)]
				public virtual void SetContentView(global::Android.Views.View layoutResID) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Set the activity content to an explicit view. This view is placed directly into the activity's view hierarchy. It can itself be a complex view hierarchy.</para> <para> <para>setContentView(android.view.View) </para> <para>setContentView(int) </para></para>        
				/// </summary>
				/// <java-name>
				/// setContentView
				/// </java-name>
				[Dot42.DexImport("setContentView", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V", AccessFlags = 1)]
				public virtual void SetContentView(global::Android.Views.View view, global::Android.Views.ViewGroup.LayoutParams @params) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Add an additional content view to the activity. Added after any existing ones in the activity  existing views are NOT removed.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// addContentView
				/// </java-name>
				[Dot42.DexImport("addContentView", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V", AccessFlags = 1)]
				public virtual void AddContentView(global::Android.Views.View view, global::Android.Views.ViewGroup.LayoutParams @params) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets whether this activity is finished when touched outside its window's bounds. </para>        
				/// </summary>
				/// <java-name>
				/// setFinishOnTouchOutside
				/// </java-name>
				[Dot42.DexImport("setFinishOnTouchOutside", "(Z)V", AccessFlags = 1)]
				public virtual void SetFinishOnTouchOutside(bool finish) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Select the default key handling for this activity. This controls what will happen to key events that are not otherwise handled. The default mode (DEFAULT_KEYS_DISABLE) will simply drop them on the floor. Other modes allow you to launch the dialer (DEFAULT_KEYS_DIALER), execute a shortcut in your options menu without requiring the menu key be held down (DEFAULT_KEYS_SHORTCUT), or launch a search (DEFAULT_KEYS_SEARCH_LOCAL and DEFAULT_KEYS_SEARCH_GLOBAL).</para> <para>Note that the mode selected here does not impact the default handling of system keys, such as the "back" and "menu" keys, and your activity and its views always get a first chance to receive and handle all application keys.</para> <para> <para>DEFAULT_KEYS_DISABLE </para> <para>DEFAULT_KEYS_DIALER </para> <para>DEFAULT_KEYS_SHORTCUT </para> <para>DEFAULT_KEYS_SEARCH_LOCAL </para> <para>DEFAULT_KEYS_SEARCH_GLOBAL </para> <para>onKeyDown </para></para>        
				/// </summary>
				/// <java-name>
				/// setDefaultKeyMode
				/// </java-name>
				[Dot42.DexImport("setDefaultKeyMode", "(I)V", AccessFlags = 17)]
				public void SetDefaultKeyMode(int mode) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Called when a key was pressed down and not handled by any of the views inside of the activity. So, for example, key presses while the cursor is inside a TextView will not trigger the event (unless it is a navigation to another object) because TextView handles its own key presses.</para> <para>If the focused view didn't want this event, this method is called.</para> <para>The default implementation takes care of KeyEvent#KEYCODE_BACK by calling onBackPressed(), though the behavior varies based on the application compatibility mode: for android.os.Build.VERSION_CODES#ECLAIR or later applications, it will set up the dispatch to call onKeyUp where the action will be performed; for earlier applications, it will perform the action immediately in on-down, as those versions of the platform behaved.</para> <para>Other additional default key handling may be performed if configured with setDefaultKeyMode.</para> <para> <para>onKeyUp </para> <para>android.view.KeyEvent </para></para>        
				/// </summary>
				/// <returns>
				///  <para>Return  <code>true</code> to prevent this event from being propagated further, or  <code>false</code> to indicate that you have not handled this event and it should continue to be propagated. </para>
				/// </returns>
				/// <java-name>
				/// onKeyDown
				/// </java-name>
				[Dot42.DexImport("onKeyDown", "(ILandroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public virtual bool OnKeyDown(int keyCode, global::Android.Views.KeyEvent @event) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Default implementation of KeyEvent.Callback.onKeyLongPress(): always returns false (doesn't handle the event). </para>        
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
				///  <para>Called when a key was released and not handled by any of the views inside of the activity. So, for example, key presses while the cursor is inside a TextView will not trigger the event (unless it is a navigation to another object) because TextView handles its own key presses.</para> <para>The default implementation handles KEYCODE_BACK to stop the activity and go back.</para> <para> <para>onKeyDown </para> <para>KeyEvent </para></para>        
				/// </summary>
				/// <returns>
				///  <para>Return  <code>true</code> to prevent this event from being propagated further, or  <code>false</code> to indicate that you have not handled this event and it should continue to be propagated. </para>
				/// </returns>
				/// <java-name>
				/// onKeyUp
				/// </java-name>
				[Dot42.DexImport("onKeyUp", "(ILandroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public virtual bool OnKeyUp(int keyCode, global::Android.Views.KeyEvent @event) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Default implementation of KeyEvent.Callback.onKeyMultiple(): always returns false (doesn't handle the event). </para>        
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
				///  <para>Called when the activity has detected the user's press of the back key. The default implementation simply finishes the current activity, but you can override this to do whatever you want. </para>        
				/// </summary>
				/// <java-name>
				/// onBackPressed
				/// </java-name>
				[Dot42.DexImport("onBackPressed", "()V", AccessFlags = 1)]
				public virtual void OnBackPressed() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Called when a key shortcut event is not handled by any of the views in the Activity. Override this method to implement global key shortcuts for the Activity. Key shortcuts can also be implemented by setting the shortcut property of menu items.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>True if the key shortcut was handled. </para>
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
				///  <para>Called when a touch screen event was not handled by any of the views under it. This is most useful to process touch events that happen outside of your window bounds, where there is no view to receive it.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Return true if you have consumed the event, false if you haven't. The default implementation always returns false. </para>
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
				///  <para>Called when the trackball was moved and not handled by any of the views inside of the activity. So, for example, if the trackball moves while focus is on a button, you will receive a call here because buttons do not normally do anything with trackball events. The call here happens  <b>before</b> trackball movements are converted to DPAD key events, which then get sent back to the view hierarchy, and will be processed at the point for things like focus navigation.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Return true if you have consumed the event, false if you haven't. The default implementation always returns false. </para>
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
				///  <para>Called when a generic motion event was not handled by any of the views inside of the activity. </para> <para>Generic motion events describe joystick movements, mouse hovers, track pad touches, scroll wheel movements and other input events. The source of the motion event specifies the class of input that was received. Implementations of this method must examine the bits in the source before processing the event. The following code example shows how this is done. </para> <para>Generic motion events with source class android.view.InputDevice#SOURCE_CLASS_POINTER are delivered to the view under the pointer. All other generic motion events are delivered to the focused view. </para> <para>See View#onGenericMotionEvent(MotionEvent) for an example of how to handle this event. </para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Return true if you have consumed the event, false if you haven't. The default implementation always returns false. </para>
				/// </returns>
				/// <java-name>
				/// onGenericMotionEvent
				/// </java-name>
				[Dot42.DexImport("onGenericMotionEvent", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1)]
				public virtual bool OnGenericMotionEvent(global::Android.Views.MotionEvent @event) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Called whenever a key, touch, or trackball event is dispatched to the activity. Implement this method if you wish to know that the user has interacted with the device in some way while your activity is running. This callback and onUserLeaveHint are intended to help activities manage status bar notifications intelligently; specifically, for helping activities determine the proper time to cancel a notfication.</para> <para>All calls to your activity's onUserLeaveHint callback will be accompanied by calls to onUserInteraction. This ensures that your activity will be told of relevant user activity such as pulling down the notification pane and touching an item there.</para> <para>Note that this callback will be invoked for the touch down action that begins a touch gesture, but may not be invoked for the touch-moved and touch-up actions that follow.</para> <para> <para>onUserLeaveHint() </para></para>        
				/// </summary>
				/// <java-name>
				/// onUserInteraction
				/// </java-name>
				[Dot42.DexImport("onUserInteraction", "()V", AccessFlags = 1)]
				public virtual void OnUserInteraction() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onWindowAttributesChanged
				/// </java-name>
				[Dot42.DexImport("onWindowAttributesChanged", "(Landroid/view/WindowManager$LayoutParams;)V", AccessFlags = 1)]
				public virtual void OnWindowAttributesChanged(global::Android.Views.IWindowManager_LayoutParams @params) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>This hook is called whenever the content view of the screen changes (due to a call to Window.setContentView or Window.addContentView). </para>        
				/// </summary>
				/// <java-name>
				/// onContentChanged
				/// </java-name>
				[Dot42.DexImport("onContentChanged", "()V", AccessFlags = 1)]
				public virtual void OnContentChanged() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Called when the current Window of the activity gains or loses focus. This is the best indicator of whether this activity is visible to the user. The default implementation clears the key tracking state, so should always be called.</para> <para>Note that this provides information about global focus state, which is managed independently of activity lifecycles. As such, while focus changes will generally have some relation to lifecycle changes (an activity that is stopped will not generally get window focus), you should not rely on any particular order between the callbacks here and those in the other lifecycle methods such as onResume.</para> <para>As a general rule, however, a resumed activity will have window focus... unless it has displayed other dialogs or popups that take input focus, in which case the activity itself will not have focus when the other windows have it. Likewise, the system may display system-level windows (such as the status bar notification panel or a system alert) which will temporarily take window input focus without pausing the foreground activity.</para> <para> <para>hasWindowFocus() </para> <para>onResume </para> <para>View::onWindowFocusChanged(boolean) </para></para>        
				/// </summary>
				/// <java-name>
				/// onWindowFocusChanged
				/// </java-name>
				[Dot42.DexImport("onWindowFocusChanged", "(Z)V", AccessFlags = 1)]
				public virtual void OnWindowFocusChanged(bool hasFocus) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Called when the main window associated with the activity has been attached to the window manager. See View.onAttachedToWindow() for more information.  <para>View::onAttachedToWindow </para></para>        
				/// </summary>
				/// <java-name>
				/// onAttachedToWindow
				/// </java-name>
				[Dot42.DexImport("onAttachedToWindow", "()V", AccessFlags = 1)]
				public virtual void OnAttachedToWindow() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Called when the main window associated with the activity has been detached from the window manager. See View.onDetachedFromWindow() for more information.  <para>View::onDetachedFromWindow </para></para>        
				/// </summary>
				/// <java-name>
				/// onDetachedFromWindow
				/// </java-name>
				[Dot42.DexImport("onDetachedFromWindow", "()V", AccessFlags = 1)]
				public virtual void OnDetachedFromWindow() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Called to process key events. You can override this to intercept all key events before they are dispatched to the window. Be sure to call this implementation for key events that should be handled normally.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>boolean Return true if this event was consumed. </para>
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
				///  <para>Called to process a key shortcut event. You can override this to intercept all key shortcut events before they are dispatched to the window. Be sure to call this implementation for key shortcut events that should be handled normally.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>True if this event was consumed. </para>
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
				///  <para>Called to process touch screen events. You can override this to intercept all touch screen events before they are dispatched to the window. Be sure to call this implementation for touch screen events that should be handled normally.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>boolean Return true if this event was consumed. </para>
				/// </returns>
				/// <java-name>
				/// dispatchTouchEvent
				/// </java-name>
				[Dot42.DexImport("dispatchTouchEvent", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1)]
				public virtual bool DispatchTouchEvent(global::Android.Views.MotionEvent ev) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Called to process trackball events. You can override this to intercept all trackball events before they are dispatched to the window. Be sure to call this implementation for trackball events that should be handled normally.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>boolean Return true if this event was consumed. </para>
				/// </returns>
				/// <java-name>
				/// dispatchTrackballEvent
				/// </java-name>
				[Dot42.DexImport("dispatchTrackballEvent", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1)]
				public virtual bool DispatchTrackballEvent(global::Android.Views.MotionEvent ev) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Called to process generic motion events. You can override this to intercept all generic motion events before they are dispatched to the window. Be sure to call this implementation for generic motion events that should be handled normally.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>boolean Return true if this event was consumed. </para>
				/// </returns>
				/// <java-name>
				/// dispatchGenericMotionEvent
				/// </java-name>
				[Dot42.DexImport("dispatchGenericMotionEvent", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1)]
				public virtual bool DispatchGenericMotionEvent(global::Android.Views.MotionEvent ev) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Called to process population of AccessibilityEvents.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>boolean Return true if event population was completed. </para>
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
				///  <para>Default implementation of android.view.Window.Callback#onCreatePanelView for activities. This simply returns null so that all panel sub-windows will have the default menu behavior. </para>        
				/// </summary>
				/// <java-name>
				/// onCreatePanelView
				/// </java-name>
				[Dot42.DexImport("onCreatePanelView", "(I)Landroid/view/View;", AccessFlags = 1)]
				public virtual global::Android.Views.View OnCreatePanelView(int featureId) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.View);
				}

				/// <summary>
				///  <para>Default implementation of android.view.Window.Callback#onCreatePanelMenu for activities. This calls through to the new onCreateOptionsMenu method for the android.view.Window#FEATURE_OPTIONS_PANEL panel, so that subclasses of Activity don't need to deal with feature codes. </para>        
				/// </summary>
				/// <java-name>
				/// onCreatePanelMenu
				/// </java-name>
				[Dot42.DexImport("onCreatePanelMenu", "(ILandroid/view/Menu;)Z", AccessFlags = 1)]
				public virtual bool OnCreatePanelMenu(int featureId, global::Android.Views.IMenu menu) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Default implementation of android.view.Window.Callback#onPreparePanel for activities. This calls through to the new onPrepareOptionsMenu method for the android.view.Window#FEATURE_OPTIONS_PANEL panel, so that subclasses of Activity don't need to deal with feature codes. </para>        
				/// </summary>
				/// <java-name>
				/// onPreparePanel
				/// </java-name>
				[Dot42.DexImport("onPreparePanel", "(ILandroid/view/View;Landroid/view/Menu;)Z", AccessFlags = 1)]
				public virtual bool OnPreparePanel(int featureId, global::Android.Views.View view, global::Android.Views.IMenu menu) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para> <para>Called when a panel's menu is opened by the user. This may also be called when the menu is changing from one type to another (for example, from the icon menu to the expanded menu).</para> <para></para></para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Return true to allow the menu to open, or false to prevent the menu from opening.</para> <para>The default implementation returns true. </para>
				/// </returns>
				/// <java-name>
				/// onMenuOpened
				/// </java-name>
				[Dot42.DexImport("onMenuOpened", "(ILandroid/view/Menu;)Z", AccessFlags = 1)]
				public virtual bool OnMenuOpened(int featureId, global::Android.Views.IMenu menu) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Default implementation of android.view.Window.Callback#onMenuItemSelected for activities. This calls through to the new onOptionsItemSelected method for the android.view.Window#FEATURE_OPTIONS_PANEL panel, so that subclasses of Activity don't need to deal with feature codes. </para>        
				/// </summary>
				/// <java-name>
				/// onMenuItemSelected
				/// </java-name>
				[Dot42.DexImport("onMenuItemSelected", "(ILandroid/view/MenuItem;)Z", AccessFlags = 1)]
				public virtual bool OnMenuItemSelected(int featureId, global::Android.Views.IMenuItem item) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Default implementation of android.view.Window.Callback#onPanelClosed(int, Menu) for activities. This calls through to onOptionsMenuClosed(Menu) method for the android.view.Window#FEATURE_OPTIONS_PANEL panel, so that subclasses of Activity don't need to deal with feature codes. For context menus (Window#FEATURE_CONTEXT_MENU), the onContextMenuClosed(Menu) will be called. </para>        
				/// </summary>
				/// <java-name>
				/// onPanelClosed
				/// </java-name>
				[Dot42.DexImport("onPanelClosed", "(ILandroid/view/Menu;)V", AccessFlags = 1)]
				public virtual void OnPanelClosed(int featureId, global::Android.Views.IMenu menu) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Declare that the options menu has changed, so should be recreated. The onCreateOptionsMenu(Menu) method will be called the next time it needs to be displayed. </para>        
				/// </summary>
				/// <java-name>
				/// invalidateOptionsMenu
				/// </java-name>
				[Dot42.DexImport("invalidateOptionsMenu", "()V", AccessFlags = 1)]
				public virtual void InvalidateOptionsMenu() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Initialize the contents of the Activity's standard options menu. You should place your menu items in to  <b>menu</b>.</para> <para>This is only called once, the first time the options menu is displayed. To update the menu every time it is displayed, see onPrepareOptionsMenu.</para> <para>The default implementation populates the menu with standard system menu items. These are placed in the Menu#CATEGORY_SYSTEM group so that they will be correctly ordered with application-defined menu items. Deriving classes should always call through to the base implementation.</para> <para>You can safely hold on to  <b>menu</b> (and any items created from it), making modifications to it as desired, until the next time onCreateOptionsMenu() is called.</para> <para>When you add items to the menu, you can implement the Activity's onOptionsItemSelected method to handle them there.</para> <para> <para>onPrepareOptionsMenu </para> <para>onOptionsItemSelected </para></para>        
				/// </summary>
				/// <returns>
				///  <para>You must return true for the menu to be displayed; if you return false it will not be shown.</para>
				/// </returns>
				/// <java-name>
				/// onCreateOptionsMenu
				/// </java-name>
				[Dot42.DexImport("onCreateOptionsMenu", "(Landroid/view/Menu;)Z", AccessFlags = 1)]
				public virtual bool OnCreateOptionsMenu(global::Android.Views.IMenu menu) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Prepare the Screen's standard options menu to be displayed. This is called right before the menu is shown, every time it is shown. You can use this method to efficiently enable/disable items or otherwise dynamically modify the contents.</para> <para>The default implementation updates the system menu items based on the activity's state. Deriving classes should always call through to the base class implementation.</para> <para> <para>onCreateOptionsMenu </para></para>        
				/// </summary>
				/// <returns>
				///  <para>You must return true for the menu to be displayed; if you return false it will not be shown.</para>
				/// </returns>
				/// <java-name>
				/// onPrepareOptionsMenu
				/// </java-name>
				[Dot42.DexImport("onPrepareOptionsMenu", "(Landroid/view/Menu;)Z", AccessFlags = 1)]
				public virtual bool OnPrepareOptionsMenu(global::Android.Views.IMenu menu) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>This hook is called whenever an item in your options menu is selected. The default implementation simply returns false to have the normal processing happen (calling the item's Runnable or sending a message to its Handler as appropriate). You can use this method for any items for which you would like to do processing without those other facilities.</para> <para>Derived classes should call through to the base class for it to perform the default menu handling.</para> <para> <para>onCreateOptionsMenu </para></para>        
				/// </summary>
				/// <returns>
				///  <para>boolean Return false to allow normal menu processing to proceed, true to consume it here.</para>
				/// </returns>
				/// <java-name>
				/// onOptionsItemSelected
				/// </java-name>
				[Dot42.DexImport("onOptionsItemSelected", "(Landroid/view/MenuItem;)Z", AccessFlags = 1)]
				public virtual bool OnOptionsItemSelected(global::Android.Views.IMenuItem item) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>This method is called whenever the user chooses to navigate Up within your application's activity hierarchy from the action bar.</para> <para>If the attribute parentActivityName was specified in the manifest for this activity or an activity-alias to it, default Up navigation will be handled automatically. If any activity along the parent chain requires extra Intent arguments, the Activity subclass should override the method onPrepareNavigateUpTaskStack(TaskStackBuilder) to supply those arguments.</para> <para>See  from the developer guide and  from the design guide for more information about navigating within your app.</para> <para>See the TaskStackBuilder class and the Activity methods getParentActivityIntent(), shouldUpRecreateTask(Intent), and navigateUpTo(Intent) for help implementing custom Up navigation. The AppNavigation sample application in the Android SDK is also available for reference.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if Up navigation completed successfully and this Activity was finished, false otherwise. </para>
				/// </returns>
				/// <java-name>
				/// onNavigateUp
				/// </java-name>
				[Dot42.DexImport("onNavigateUp", "()Z", AccessFlags = 1)]
				public virtual bool OnNavigateUp() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>This is called when a child activity of this one attempts to navigate up. The default implementation simply calls onNavigateUp() on this activity (the parent).</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// onNavigateUpFromChild
				/// </java-name>
				[Dot42.DexImport("onNavigateUpFromChild", "(Landroid/app/Activity;)Z", AccessFlags = 1)]
				public virtual bool OnNavigateUpFromChild(global::Android.App.Activity child) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Define the synthetic task stack that will be generated during Up navigation from a different task.</para> <para>The default implementation of this method adds the parent chain of this activity as specified in the manifest to the supplied TaskStackBuilder. Applications may choose to override this method to construct the desired task stack in a different way.</para> <para>This method will be invoked by the default implementation of onNavigateUp() if shouldUpRecreateTask(Intent) returns true when supplied with the intent returned by getParentActivityIntent().</para> <para>Applications that wish to supply extra Intent parameters to the parent stack defined by the manifest should override onPrepareNavigateUpTaskStack(TaskStackBuilder).</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// onCreateNavigateUpTaskStack
				/// </java-name>
				[Dot42.DexImport("onCreateNavigateUpTaskStack", "(Landroid/app/TaskStackBuilder;)V", AccessFlags = 1)]
				public virtual void OnCreateNavigateUpTaskStack(global::Android.App.TaskStackBuilder builder) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Prepare the synthetic task stack that will be generated during Up navigation from a different task.</para> <para>This method receives the TaskStackBuilder with the constructed series of Intents as generated by onCreateNavigateUpTaskStack(TaskStackBuilder). If any extra data should be added to these intents before launching the new task, the application should override this method and add that data here.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// onPrepareNavigateUpTaskStack
				/// </java-name>
				[Dot42.DexImport("onPrepareNavigateUpTaskStack", "(Landroid/app/TaskStackBuilder;)V", AccessFlags = 1)]
				public virtual void OnPrepareNavigateUpTaskStack(global::Android.App.TaskStackBuilder builder) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>This hook is called whenever the options menu is being closed (either by the user canceling the menu with the back/menu button, or when an item is selected).</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// onOptionsMenuClosed
				/// </java-name>
				[Dot42.DexImport("onOptionsMenuClosed", "(Landroid/view/Menu;)V", AccessFlags = 1)]
				public virtual void OnOptionsMenuClosed(global::Android.Views.IMenu menu) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Programmatically opens the options menu. If the options menu is already open, this method does nothing. </para>        
				/// </summary>
				/// <java-name>
				/// openOptionsMenu
				/// </java-name>
				[Dot42.DexImport("openOptionsMenu", "()V", AccessFlags = 1)]
				public virtual void OpenOptionsMenu() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Progammatically closes the options menu. If the options menu is already closed, this method does nothing. </para>        
				/// </summary>
				/// <java-name>
				/// closeOptionsMenu
				/// </java-name>
				[Dot42.DexImport("closeOptionsMenu", "()V", AccessFlags = 1)]
				public virtual void CloseOptionsMenu() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Called when a context menu for the <c>view </c> is about to be shown. Unlike onCreateOptionsMenu(Menu), this will be called every time the context menu is about to be shown and should be populated for the view (or item inside the view for AdapterView subclasses, this can be found in the <c>menuInfo </c> )). </para> <para>Use onContextItemSelected(android.view.MenuItem) to know when an item has been selected. </para> <para>It is not safe to hold onto the context menu after this method returns. </para>        
				/// </summary>
				/// <java-name>
				/// onCreateContextMenu
				/// </java-name>
				[Dot42.DexImport("onCreateContextMenu", "(Landroid/view/ContextMenu;Landroid/view/View;Landroid/view/ContextMenu$ContextMe" +
    "nuInfo;)V", AccessFlags = 1)]
				public virtual void OnCreateContextMenu(global::Android.Views.IContextMenu menu, global::Android.Views.View v, global::Android.Views.IContextMenu_IContextMenuInfo menuInfo) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Registers a context menu to be shown for the given view (multiple views can show the context menu). This method will set the OnCreateContextMenuListener on the view to this activity, so onCreateContextMenu(ContextMenu, View, ContextMenuInfo) will be called when it is time to show the context menu.</para> <para> <para>unregisterForContextMenu(View) </para></para>        
				/// </summary>
				/// <java-name>
				/// registerForContextMenu
				/// </java-name>
				[Dot42.DexImport("registerForContextMenu", "(Landroid/view/View;)V", AccessFlags = 1)]
				public virtual void RegisterForContextMenu(global::Android.Views.View view) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Prevents a context menu to be shown for the given view. This method will remove the OnCreateContextMenuListener on the view.</para> <para> <para>registerForContextMenu(View) </para></para>        
				/// </summary>
				/// <java-name>
				/// unregisterForContextMenu
				/// </java-name>
				[Dot42.DexImport("unregisterForContextMenu", "(Landroid/view/View;)V", AccessFlags = 1)]
				public virtual void UnregisterForContextMenu(global::Android.Views.View view) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Programmatically opens the context menu for a particular <c>view </c> . The <c>view </c> should have been added via registerForContextMenu(View).</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// openContextMenu
				/// </java-name>
				[Dot42.DexImport("openContextMenu", "(Landroid/view/View;)V", AccessFlags = 1)]
				public virtual void OpenContextMenu(global::Android.Views.View view) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Programmatically closes the most recently opened context menu, if showing. </para>        
				/// </summary>
				/// <java-name>
				/// closeContextMenu
				/// </java-name>
				[Dot42.DexImport("closeContextMenu", "()V", AccessFlags = 1)]
				public virtual void CloseContextMenu() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>This hook is called whenever an item in a context menu is selected. The default implementation simply returns false to have the normal processing happen (calling the item's Runnable or sending a message to its Handler as appropriate). You can use this method for any items for which you would like to do processing without those other facilities. </para> <para>Use MenuItem#getMenuInfo() to get extra information set by the View that added this menu item. </para> <para>Derived classes should call through to the base class for it to perform the default menu handling.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>boolean Return false to allow normal context menu processing to proceed, true to consume it here. </para>
				/// </returns>
				/// <java-name>
				/// onContextItemSelected
				/// </java-name>
				[Dot42.DexImport("onContextItemSelected", "(Landroid/view/MenuItem;)Z", AccessFlags = 1)]
				public virtual bool OnContextItemSelected(global::Android.Views.IMenuItem item) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>This hook is called whenever the context menu is being closed (either by the user canceling the menu with the back/menu button, or when an item is selected).</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// onContextMenuClosed
				/// </java-name>
				[Dot42.DexImport("onContextMenuClosed", "(Landroid/view/Menu;)V", AccessFlags = 1)]
				public virtual void OnContextMenuClosed(global::Android.Views.IMenu menu) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Old no-arguments version of onCreateDialog(int, Bundle). </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// onCreateDialog
				/// </java-name>
				[Dot42.DexImport("onCreateDialog", "(I)Landroid/app/Dialog;", AccessFlags = 4)]
				protected internal virtual global::Android.App.Dialog OnCreateDialog(int id) /* MethodBuilder.Create */ 
				{
						return default(global::Android.App.Dialog);
				}

				/// <summary>
				///  <para>Callback for creating dialogs that are managed (saved and restored) for you by the activity. The default implementation calls through to onCreateDialog(int) for compatibility.</para> <para> <b>If you are targeting android.os.Build.VERSION_CODES#HONEYCOMB or later, consider instead using a DialogFragment instead.</b></para> <para>If you use showDialog(int), the activity will call through to this method the first time, and hang onto it thereafter. Any dialog that is created by this method will automatically be saved and restored for you, including whether it is showing.</para> <para>If you would like the activity to manage saving and restoring dialogs for you, you should override this method and handle any ids that are passed to showDialog.</para> <para>If you would like an opportunity to prepare your dialog before it is shown, override onPrepareDialog(int, Dialog, Bundle).</para> <para> <para>onPrepareDialog(int, Dialog, Bundle) </para> <para>showDialog(int, Bundle) </para> <para>dismissDialog(int) </para> <para>removeDialog(int)</para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use the new DialogFragment class with FragmentManager instead; this is also available on older platforms through the Android compatibility package. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				///  <para>The dialog. If you return null, the dialog will not be created.</para>
				/// </returns>
				/// <java-name>
				/// onCreateDialog
				/// </java-name>
				[Dot42.DexImport("onCreateDialog", "(ILandroid/os/Bundle;)Landroid/app/Dialog;", AccessFlags = 4)]
				protected internal virtual global::Android.App.Dialog OnCreateDialog(int id, global::Android.OS.Bundle args) /* MethodBuilder.Create */ 
				{
						return default(global::Android.App.Dialog);
				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Old no-arguments version of onPrepareDialog(int, Dialog, Bundle). </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// onPrepareDialog
				/// </java-name>
				[Dot42.DexImport("onPrepareDialog", "(ILandroid/app/Dialog;)V", AccessFlags = 4)]
				protected internal virtual void OnPrepareDialog(int id, global::Android.App.Dialog dialog) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Provides an opportunity to prepare a managed dialog before it is being shown. The default implementation calls through to onPrepareDialog(int, Dialog) for compatibility.</para> <para>Override this if you need to update a managed dialog based on the state of the application each time it is shown. For example, a time picker dialog might want to be updated with the current time. You should call through to the superclass's implementation. The default implementation will set this Activity as the owner activity on the Dialog.</para> <para> <para>onCreateDialog(int, Bundle) </para> <para>showDialog(int) </para> <para>dismissDialog(int) </para> <para>removeDialog(int)</para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use the new DialogFragment class with FragmentManager instead; this is also available on older platforms through the Android compatibility package. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// onPrepareDialog
				/// </java-name>
				[Dot42.DexImport("onPrepareDialog", "(ILandroid/app/Dialog;Landroid/os/Bundle;)V", AccessFlags = 4)]
				protected internal virtual void OnPrepareDialog(int id, global::Android.App.Dialog dialog, global::Android.OS.Bundle args) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Simple version of showDialog(int, Bundle) that does not take any arguments. Simply calls showDialog(int, Bundle) with null arguments.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use the new DialogFragment class with FragmentManager instead; this is also available on older platforms through the Android compatibility package. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// showDialog
				/// </java-name>
				[Dot42.DexImport("showDialog", "(I)V", AccessFlags = 17)]
				public void ShowDialog(int id) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Show a dialog managed by this activity. A call to onCreateDialog(int, Bundle) will be made with the same id the first time this is called for a given id. From thereafter, the dialog will be automatically saved and restored.</para> <para> <b>If you are targeting android.os.Build.VERSION_CODES#HONEYCOMB or later, consider instead using a DialogFragment instead.</b></para> <para>Each time a dialog is shown, onPrepareDialog(int, Dialog, Bundle) will be made to provide an opportunity to do any timely preparation.</para> <para> <para>Dialog </para> <para>onCreateDialog(int, Bundle) </para> <para>onPrepareDialog(int, Dialog, Bundle) </para> <para>dismissDialog(int) </para> <para>removeDialog(int)</para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use the new DialogFragment class with FragmentManager instead; this is also available on older platforms through the Android compatibility package. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns true if the Dialog was created; false is returned if it is not created because onCreateDialog(int, Bundle) returns false.</para>
				/// </returns>
				/// <java-name>
				/// showDialog
				/// </java-name>
				[Dot42.DexImport("showDialog", "(ILandroid/os/Bundle;)Z", AccessFlags = 17)]
				public bool ShowDialog(int id, global::Android.OS.Bundle args) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Dismiss a dialog that was previously shown via showDialog(int).</para> <para> <para>onCreateDialog(int, Bundle) </para> <para>onPrepareDialog(int, Dialog, Bundle) </para> <para>showDialog(int) </para> <para>removeDialog(int)</para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use the new DialogFragment class with FragmentManager instead; this is also available on older platforms through the Android compatibility package. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// dismissDialog
				/// </java-name>
				[Dot42.DexImport("dismissDialog", "(I)V", AccessFlags = 17)]
				public void DismissDialog(int id) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Removes any internal references to a dialog managed by this Activity. If the dialog is showing, it will dismiss it as part of the clean up.</para> <para>This can be useful if you know that you will never show a dialog again and want to avoid the overhead of saving and restoring it in the future.</para> <para>As of android.os.Build.VERSION_CODES#GINGERBREAD, this function will not throw an exception if you try to remove an ID that does not currently have an associated dialog.</para> <para> <para>onCreateDialog(int, Bundle) </para> <para>onPrepareDialog(int, Dialog, Bundle) </para> <para>showDialog(int) </para> <para>dismissDialog(int)</para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use the new DialogFragment class with FragmentManager instead; this is also available on older platforms through the Android compatibility package. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// removeDialog
				/// </java-name>
				[Dot42.DexImport("removeDialog", "(I)V", AccessFlags = 17)]
				public void RemoveDialog(int id) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>This hook is called when the user signals the desire to start a search.</para> <para>You can use this function as a simple way to launch the search UI, in response to a menu item, search button, or other widgets within your activity. Unless overidden, calling this function is the same as calling startSearch(null, false, null, false), which launches search for the current activity as specified in its manifest, see SearchManager.</para> <para>You can override this function to force global search, e.g. in response to a dedicated search key, or to block search entirely (by simply returning false).</para> <para> <para>android.app.SearchManager </para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns <c>true </c> if search launched, and <c>false </c> if activity blocks it. The default implementation always returns <c>true </c> .</para>
				/// </returns>
				/// <java-name>
				/// onSearchRequested
				/// </java-name>
				[Dot42.DexImport("onSearchRequested", "()Z", AccessFlags = 1)]
				public virtual bool OnSearchRequested() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>This hook is called to launch the search UI.</para> <para>It is typically called from onSearchRequested(), either directly from Activity.onSearchRequested() or from an overridden version in any given Activity. If your goal is simply to activate search, it is preferred to call onSearchRequested(), which may have been overriden elsewhere in your Activity. If your goal is to inject specific data such as context data, it is preferred to  <b>override</b> onSearchRequested(), so that any callers to it will benefit from the override.</para> <para> <para>android.app.SearchManager </para> <para>onSearchRequested </para></para>        
				/// </summary>
				/// <java-name>
				/// startSearch
				/// </java-name>
				[Dot42.DexImport("startSearch", "(Ljava/lang/String;ZLandroid/os/Bundle;Z)V", AccessFlags = 1)]
				public virtual void StartSearch(string initialQuery, bool selectInitialQuery, global::Android.OS.Bundle appSearchData, bool globalSearch) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Similar to startSearch, but actually fires off the search query after invoking the search dialog. Made available for testing purposes.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// triggerSearch
				/// </java-name>
				[Dot42.DexImport("triggerSearch", "(Ljava/lang/String;Landroid/os/Bundle;)V", AccessFlags = 1)]
				public virtual void TriggerSearch(string query, global::Android.OS.Bundle appSearchData) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Request that key events come to this activity. Use this if your activity has no views with focus, but the activity still wants a chance to process key events.</para> <para> <para>android.view.Window::takeKeyEvents </para></para>        
				/// </summary>
				/// <java-name>
				/// takeKeyEvents
				/// </java-name>
				[Dot42.DexImport("takeKeyEvents", "(Z)V", AccessFlags = 1)]
				public virtual void TakeKeyEvents(bool get) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Enable extended window features. This is a convenience for calling getWindow().requestFeature().</para> <para> <para>android.view.Window::requestFeature </para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns true if the requested feature is supported and now enabled.</para>
				/// </returns>
				/// <java-name>
				/// requestWindowFeature
				/// </java-name>
				[Dot42.DexImport("requestWindowFeature", "(I)Z", AccessFlags = 17)]
				public bool RequestWindowFeature(int featureId) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Convenience for calling android.view.Window#setFeatureDrawableResource. </para>        
				/// </summary>
				/// <java-name>
				/// setFeatureDrawableResource
				/// </java-name>
				[Dot42.DexImport("setFeatureDrawableResource", "(II)V", AccessFlags = 17)]
				public void SetFeatureDrawableResource(int featureId, int resId) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Convenience for calling android.view.Window#setFeatureDrawableUri. </para>        
				/// </summary>
				/// <java-name>
				/// setFeatureDrawableUri
				/// </java-name>
				[Dot42.DexImport("setFeatureDrawableUri", "(ILandroid/net/Uri;)V", AccessFlags = 17)]
				public void SetFeatureDrawableUri(int featureId, global::Android.Net.Uri uri) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Convenience for calling android.view.Window#setFeatureDrawable(int, Drawable). </para>        
				/// </summary>
				/// <java-name>
				/// setFeatureDrawable
				/// </java-name>
				[Dot42.DexImport("setFeatureDrawable", "(ILandroid/graphics/drawable/Drawable;)V", AccessFlags = 17)]
				public void SetFeatureDrawable(int featureId, global::Android.Graphics.Drawables.Drawable drawable) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Convenience for calling android.view.Window#setFeatureDrawableAlpha. </para>        
				/// </summary>
				/// <java-name>
				/// setFeatureDrawableAlpha
				/// </java-name>
				[Dot42.DexImport("setFeatureDrawableAlpha", "(II)V", AccessFlags = 17)]
				public void SetFeatureDrawableAlpha(int featureId, int alpha) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onApplyThemeResource
				/// </java-name>
				[Dot42.DexImport("onApplyThemeResource", "(Landroid/content/res/Resources$Theme;IZ)V", AccessFlags = 4)]
				protected internal override void OnApplyThemeResource(global::Android.Content.Res.Resources.Theme theme, int resid, bool first) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Same as calling startActivityForResult(Intent, int, Bundle) with no options.</para> <para> <para>startActivity </para></para>        
				/// </summary>
				/// <java-name>
				/// startActivityForResult
				/// </java-name>
				[Dot42.DexImport("startActivityForResult", "(Landroid/content/Intent;I)V", AccessFlags = 1)]
				public virtual void StartActivityForResult(global::Android.Content.Intent intent, int requestCode) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Launch an activity for which you would like a result when it finished. When this activity exits, your onActivityResult() method will be called with the given requestCode. Using a negative requestCode is the same as calling startActivity (the activity is not launched as a sub-activity).</para> <para>Note that this method should only be used with Intent protocols that are defined to return a result. In other protocols (such as Intent#ACTION_MAIN or Intent#ACTION_VIEW), you may not get the result when you expect. For example, if the activity you are launching uses the singleTask launch mode, it will not run in your task and thus you will immediately receive a cancel result.</para> <para>As a special case, if you call startActivityForResult() with a requestCode &gt;= 0 during the initial onCreate(Bundle savedInstanceState)/onResume() of your activity, then your window will not be displayed until a result is returned back from the started activity. This is to avoid visible flickering when redirecting to another activity.</para> <para>This method throws android.content.ActivityNotFoundException if there was no Activity found to run the given Intent.</para> <para> <para>startActivity </para></para>        
				/// </summary>
				/// <java-name>
				/// startActivityForResult
				/// </java-name>
				[Dot42.DexImport("startActivityForResult", "(Landroid/content/Intent;ILandroid/os/Bundle;)V", AccessFlags = 1)]
				public virtual void StartActivityForResult(global::Android.Content.Intent intent, int requestCode, global::Android.OS.Bundle options) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Same as calling int, Intent, int, int, int, Bundle) with no options.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// startIntentSenderForResult
				/// </java-name>
				[Dot42.DexImport("startIntentSenderForResult", "(Landroid/content/IntentSender;ILandroid/content/Intent;III)V", AccessFlags = 1)]
				public virtual void StartIntentSenderForResult(global::Android.Content.IntentSender intent, int requestCode, global::Android.Content.Intent fillInIntent, int flagsMask, int flagsValues, int extraFlags) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Like startActivityForResult(Intent, int), but allowing you to use a IntentSender to describe the activity to be started. If the IntentSender is for an activity, that activity will be started as if you had called the regular startActivityForResult(Intent, int) here; otherwise, its associated action will be executed (such as sending a broadcast) as if you had called IntentSender.sendIntent on it.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// startIntentSenderForResult
				/// </java-name>
				[Dot42.DexImport("startIntentSenderForResult", "(Landroid/content/IntentSender;ILandroid/content/Intent;IIILandroid/os/Bundle;)V", AccessFlags = 1)]
				public virtual void StartIntentSenderForResult(global::Android.Content.IntentSender intent, int requestCode, global::Android.Content.Intent fillInIntent, int flagsMask, int flagsValues, int extraFlags, global::Android.OS.Bundle options) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Same as startActivity(Intent, Bundle) with no options specified.</para> <para> <para>startActivity(Intent, Bundle) </para> <para>startActivityForResult </para></para>        
				/// </summary>
				/// <java-name>
				/// startActivity
				/// </java-name>
				[Dot42.DexImport("startActivity", "(Landroid/content/Intent;)V", AccessFlags = 1)]
				public override void StartActivity(global::Android.Content.Intent intent) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Launch a new activity. You will not receive any information about when the activity exits. This implementation overrides the base version, providing information about the activity performing the launch. Because of this additional information, the Intent#FLAG_ACTIVITY_NEW_TASK launch flag is not required; if not specified, the new activity will be added to the task of the caller.</para> <para>This method throws android.content.ActivityNotFoundException if there was no Activity found to run the given Intent.</para> <para> <para>startActivity(Intent) </para> <para>startActivityForResult </para></para>        
				/// </summary>
				/// <java-name>
				/// startActivity
				/// </java-name>
				[Dot42.DexImport("startActivity", "(Landroid/content/Intent;Landroid/os/Bundle;)V", AccessFlags = 1)]
				public override void StartActivity(global::Android.Content.Intent intent, global::Android.OS.Bundle options) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Same as startActivities(Intent[], Bundle) with no options specified.</para> <para> <para>startActivities(Intent[], Bundle) </para> <para>startActivityForResult </para></para>        
				/// </summary>
				/// <java-name>
				/// startActivities
				/// </java-name>
				[Dot42.DexImport("startActivities", "([Landroid/content/Intent;)V", AccessFlags = 1)]
				public override void StartActivities(global::Android.Content.Intent[] intents) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Launch a new activity. You will not receive any information about when the activity exits. This implementation overrides the base version, providing information about the activity performing the launch. Because of this additional information, the Intent#FLAG_ACTIVITY_NEW_TASK launch flag is not required; if not specified, the new activity will be added to the task of the caller.</para> <para>This method throws android.content.ActivityNotFoundException if there was no Activity found to run the given Intent.</para> <para> <para>startActivities(Intent[]) </para> <para>startActivityForResult </para></para>        
				/// </summary>
				/// <java-name>
				/// startActivities
				/// </java-name>
				[Dot42.DexImport("startActivities", "([Landroid/content/Intent;Landroid/os/Bundle;)V", AccessFlags = 1)]
				public override void StartActivities(global::Android.Content.Intent[] intents, global::Android.OS.Bundle options) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Same as calling startIntentSender(IntentSender, Intent, int, int, int, Bundle) with no options.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// startIntentSender
				/// </java-name>
				[Dot42.DexImport("startIntentSender", "(Landroid/content/IntentSender;Landroid/content/Intent;III)V", AccessFlags = 1)]
				public override void StartIntentSender(global::Android.Content.IntentSender intent, global::Android.Content.Intent fillInIntent, int flagsMask, int flagsValues, int extraFlags) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Like startActivity(Intent, Bundle), but taking a IntentSender to start; see startIntentSenderForResult(IntentSender, int, Intent, int, int, int, Bundle) for more information.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// startIntentSender
				/// </java-name>
				[Dot42.DexImport("startIntentSender", "(Landroid/content/IntentSender;Landroid/content/Intent;IIILandroid/os/Bundle;)V", AccessFlags = 1)]
				public override void StartIntentSender(global::Android.Content.IntentSender intent, global::Android.Content.Intent fillInIntent, int flagsMask, int flagsValues, int extraFlags, global::Android.OS.Bundle options) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Same as calling startActivityIfNeeded(Intent, int, Bundle) with no options.</para> <para> <para>startActivity </para> <para>startActivityForResult </para></para>        
				/// </summary>
				/// <returns>
				///  <para>If a new activity was launched then true is returned; otherwise false is returned and you must handle the Intent yourself.</para>
				/// </returns>
				/// <java-name>
				/// startActivityIfNeeded
				/// </java-name>
				[Dot42.DexImport("startActivityIfNeeded", "(Landroid/content/Intent;I)Z", AccessFlags = 1)]
				public virtual bool StartActivityIfNeeded(global::Android.Content.Intent intent, int requestCode) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>A special variation to launch an activity only if a new activity instance is needed to handle the given Intent. In other words, this is just like startActivityForResult(Intent, int) except: if you are using the Intent#FLAG_ACTIVITY_SINGLE_TOP flag, or singleTask or singleTop launchMode, and the activity that handles  <b>intent</b> is the same as your currently running activity, then a new instance is not needed. In this case, instead of the normal behavior of calling onNewIntent this function will return and you can handle the Intent yourself.</para> <para>This function can only be called from a top-level activity; if it is called from a child activity, a runtime exception will be thrown.</para> <para> <para>startActivity </para> <para>startActivityForResult </para></para>        
				/// </summary>
				/// <returns>
				///  <para>If a new activity was launched then true is returned; otherwise false is returned and you must handle the Intent yourself.</para>
				/// </returns>
				/// <java-name>
				/// startActivityIfNeeded
				/// </java-name>
				[Dot42.DexImport("startActivityIfNeeded", "(Landroid/content/Intent;ILandroid/os/Bundle;)Z", AccessFlags = 1)]
				public virtual bool StartActivityIfNeeded(global::Android.Content.Intent intent, int requestCode, global::Android.OS.Bundle options) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Same as calling startNextMatchingActivity(Intent, Bundle) with no options.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns a boolean indicating whether there was another Activity to start: true if there was a next activity to start, false if there wasn't. In general, if true is returned you will then want to call finish() on yourself. </para>
				/// </returns>
				/// <java-name>
				/// startNextMatchingActivity
				/// </java-name>
				[Dot42.DexImport("startNextMatchingActivity", "(Landroid/content/Intent;)Z", AccessFlags = 1)]
				public virtual bool StartNextMatchingActivity(global::Android.Content.Intent intent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Special version of starting an activity, for use when you are replacing other activity components. You can use this to hand the Intent off to the next Activity that can handle it. You typically call this in onCreate with the Intent returned by getIntent.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns a boolean indicating whether there was another Activity to start: true if there was a next activity to start, false if there wasn't. In general, if true is returned you will then want to call finish() on yourself. </para>
				/// </returns>
				/// <java-name>
				/// startNextMatchingActivity
				/// </java-name>
				[Dot42.DexImport("startNextMatchingActivity", "(Landroid/content/Intent;Landroid/os/Bundle;)Z", AccessFlags = 1)]
				public virtual bool StartNextMatchingActivity(global::Android.Content.Intent intent, global::Android.OS.Bundle options) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Same as calling startActivityFromChild(Activity, Intent, int, Bundle) with no options.</para> <para> <para>startActivity </para> <para>startActivityForResult </para></para>        
				/// </summary>
				/// <java-name>
				/// startActivityFromChild
				/// </java-name>
				[Dot42.DexImport("startActivityFromChild", "(Landroid/app/Activity;Landroid/content/Intent;I)V", AccessFlags = 1)]
				public virtual void StartActivityFromChild(global::Android.App.Activity child, global::Android.Content.Intent intent, int requestCode) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>This is called when a child activity of this one calls its startActivity or startActivityForResult method.</para> <para>This method throws android.content.ActivityNotFoundException if there was no Activity found to run the given Intent.</para> <para> <para>startActivity </para> <para>startActivityForResult </para></para>        
				/// </summary>
				/// <java-name>
				/// startActivityFromChild
				/// </java-name>
				[Dot42.DexImport("startActivityFromChild", "(Landroid/app/Activity;Landroid/content/Intent;ILandroid/os/Bundle;)V", AccessFlags = 1)]
				public virtual void StartActivityFromChild(global::Android.App.Activity child, global::Android.Content.Intent intent, int requestCode, global::Android.OS.Bundle options) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Same as calling startActivityFromFragment(Fragment, Intent, int, Bundle) with no options.</para> <para> <para>Fragment::startActivity </para> <para>Fragment::startActivityForResult </para></para>        
				/// </summary>
				/// <java-name>
				/// startActivityFromFragment
				/// </java-name>
				[Dot42.DexImport("startActivityFromFragment", "(Landroid/app/Fragment;Landroid/content/Intent;I)V", AccessFlags = 1)]
				public virtual void StartActivityFromFragment(global::Android.App.Fragment fragment, global::Android.Content.Intent intent, int requestCode) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>This is called when a Fragment in this activity calls its Fragment#startActivity or Fragment#startActivityForResult method.</para> <para>This method throws android.content.ActivityNotFoundException if there was no Activity found to run the given Intent.</para> <para> <para>Fragment::startActivity </para> <para>Fragment::startActivityForResult </para></para>        
				/// </summary>
				/// <java-name>
				/// startActivityFromFragment
				/// </java-name>
				[Dot42.DexImport("startActivityFromFragment", "(Landroid/app/Fragment;Landroid/content/Intent;ILandroid/os/Bundle;)V", AccessFlags = 1)]
				public virtual void StartActivityFromFragment(global::Android.App.Fragment fragment, global::Android.Content.Intent intent, int requestCode, global::Android.OS.Bundle options) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Same as calling IntentSender, int, Intent, int, int, int, Bundle) with no options. </para>        
				/// </summary>
				/// <java-name>
				/// startIntentSenderFromChild
				/// </java-name>
				[Dot42.DexImport("startIntentSenderFromChild", "(Landroid/app/Activity;Landroid/content/IntentSender;ILandroid/content/Intent;III" +
    ")V", AccessFlags = 1)]
				public virtual void StartIntentSenderFromChild(global::Android.App.Activity child, global::Android.Content.IntentSender intent, int requestCode, global::Android.Content.Intent fillInIntent, int flagsMask, int flagsValues, int extraFlags) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Like startActivityFromChild(Activity, Intent, int), but taking a IntentSender; see startIntentSenderForResult(IntentSender, int, Intent, int, int, int) for more information. </para>        
				/// </summary>
				/// <java-name>
				/// startIntentSenderFromChild
				/// </java-name>
				[Dot42.DexImport("startIntentSenderFromChild", "(Landroid/app/Activity;Landroid/content/IntentSender;ILandroid/content/Intent;III" +
    "Landroid/os/Bundle;)V", AccessFlags = 1)]
				public virtual void StartIntentSenderFromChild(global::Android.App.Activity child, global::Android.Content.IntentSender intent, int requestCode, global::Android.Content.Intent fillInIntent, int flagsMask, int flagsValues, int extraFlags, global::Android.OS.Bundle options) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Call immediately after one of the flavors of startActivity(Intent) or finish to specify an explicit transition animation to perform next.</para> <para>As of android.os.Build.VERSION_CODES#JELLY_BEAN an alternative to using this with starting activities is to supply the desired animation information through a ActivityOptions bundle to or a related function. This allows you to specify a custom animation even when starting an activity from outside the context of the current top activity.  enterAnim A resource ID of the animation resource to use for the incoming activity. Use 0 for no animation.  exitAnim A resource ID of the animation resource to use for the outgoing activity. Use 0 for no animation. </para>        
				/// </summary>
				/// <java-name>
				/// overridePendingTransition
				/// </java-name>
				[Dot42.DexImport("overridePendingTransition", "(II)V", AccessFlags = 1)]
				public virtual void OverridePendingTransition(int enterAnim, int exitAnim) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Call this to set the result that your activity will return to its caller.</para> <para> <para>RESULT_CANCELED </para> <para>RESULT_OK </para> <para>RESULT_FIRST_USER </para> <para>setResult(int, Intent) </para></para>        
				/// </summary>
				/// <java-name>
				/// setResult
				/// </java-name>
				[Dot42.DexImport("setResult", "(I)V", AccessFlags = 17)]
				public void SetResult(int resultCode) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Call this to set the result that your activity will return to its caller.</para> <para>As of android.os.Build.VERSION_CODES#GINGERBREAD, the Intent you supply here can have Intent.FLAG_GRANT_READ_URI_PERMISSION and/or Intent.FLAG_GRANT_WRITE_URI_PERMISSION set. This will grant the Activity receiving the result access to the specific URIs in the Intent. Access will remain until the Activity has finished (it will remain across the hosting process being killed and other temporary destruction) and will be added to any existing set of URI permissions it already holds.</para> <para> <para>RESULT_CANCELED </para> <para>RESULT_OK </para> <para>RESULT_FIRST_USER </para> <para>setResult(int) </para></para>        
				/// </summary>
				/// <java-name>
				/// setResult
				/// </java-name>
				[Dot42.DexImport("setResult", "(ILandroid/content/Intent;)V", AccessFlags = 17)]
				public void SetResult(int resultCode, global::Android.Content.Intent data) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Control whether this activity's main window is visible. This is intended only for the special case of an activity that is not going to show a UI itself, but can't just finish prior to onResume() because it needs to wait for a service binding or such. Setting this to false allows you to prevent your UI from being shown during that time.</para> <para>The default value for this is taken from the android.R.attr#windowNoDisplay attribute of the activity's theme. </para>        
				/// </summary>
				/// <java-name>
				/// setVisible
				/// </java-name>
				[Dot42.DexImport("setVisible", "(Z)V", AccessFlags = 1)]
				public virtual void SetVisible(bool visible) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Cause this Activity to be recreated with a new instance. This results in essentially the same flow as when the Activity is created due to a configuration change  the current instance will go through its lifecycle to onDestroy and a new instance then created after it. </para>        
				/// </summary>
				/// <java-name>
				/// recreate
				/// </java-name>
				[Dot42.DexImport("recreate", "()V", AccessFlags = 1)]
				public virtual void Recreate() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Call this when your activity is done and should be closed. The ActivityResult is propagated back to whoever launched you via onActivityResult(). </para>        
				/// </summary>
				/// <java-name>
				/// finish
				/// </java-name>
				[Dot42.DexImport("finish", "()V", AccessFlags = 1)]
				public virtual void Finish() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Finish this activity as well as all activities immediately below it in the current task that have the same affinity. This is typically used when an application can be launched on to another task (such as from an ACTION_VIEW of a content type it understands) and the user has used the up navigation to switch out of the current task and in to its own task. In this case, if the user has navigated down into any other activities of the second application, all of those should be removed from the original task as part of the task switch.</para> <para>Note that this finish does  <b>not</b> allow you to deliver results to the previous activity, and an exception will be thrown if you are trying to do so.</para>        
				/// </summary>
				/// <java-name>
				/// finishAffinity
				/// </java-name>
				[Dot42.DexImport("finishAffinity", "()V", AccessFlags = 1)]
				public virtual void FinishAffinity() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>This is called when a child activity of this one calls its finish method. The default implementation simply calls finish() on this activity (the parent), finishing the entire group.</para> <para> <para>finish </para></para>        
				/// </summary>
				/// <java-name>
				/// finishFromChild
				/// </java-name>
				[Dot42.DexImport("finishFromChild", "(Landroid/app/Activity;)V", AccessFlags = 1)]
				public virtual void FinishFromChild(global::Android.App.Activity child) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Force finish another activity that you had previously started with startActivityForResult.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// finishActivity
				/// </java-name>
				[Dot42.DexImport("finishActivity", "(I)V", AccessFlags = 1)]
				public virtual void FinishActivity(int requestCode) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>This is called when a child activity of this one calls its finishActivity().</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// finishActivityFromChild
				/// </java-name>
				[Dot42.DexImport("finishActivityFromChild", "(Landroid/app/Activity;I)V", AccessFlags = 1)]
				public virtual void FinishActivityFromChild(global::Android.App.Activity child, int requestCode) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Called when an activity you launched exits, giving you the requestCode you started it with, the resultCode it returned, and any additional data from it. The  <b>resultCode</b> will be RESULT_CANCELED if the activity explicitly returned that, didn't return any result, or crashed during its operation.</para> <para>You will receive this call immediately before onResume() when your activity is re-starting.</para> <para> <para>startActivityForResult </para> <para>createPendingResult </para> <para>setResult(int) </para></para>        
				/// </summary>
				/// <java-name>
				/// onActivityResult
				/// </java-name>
				[Dot42.DexImport("onActivityResult", "(IILandroid/content/Intent;)V", AccessFlags = 4)]
				protected internal virtual void OnActivityResult(int requestCode, int resultCode, global::Android.Content.Intent data) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Create a new PendingIntent object which you can hand to others for them to use to send result data back to your onActivityResult callback. The created object will be either one-shot (becoming invalid after a result is sent back) or multiple (allowing any number of results to be sent through it).</para> <para> <para>PendingIntent </para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns an existing or new PendingIntent matching the given parameters. May return null only if PendingIntent.FLAG_NO_CREATE has been supplied.</para>
				/// </returns>
				/// <java-name>
				/// createPendingResult
				/// </java-name>
				[Dot42.DexImport("createPendingResult", "(ILandroid/content/Intent;I)Landroid/app/PendingIntent;", AccessFlags = 1)]
				public virtual global::Android.App.PendingIntent CreatePendingResult(int requestCode, global::Android.Content.Intent data, int flags) /* MethodBuilder.Create */ 
				{
						return default(global::Android.App.PendingIntent);
				}

				/// <summary>
				///  <para>Move the task containing this activity to the back of the activity stack. The activity's order within the task is unchanged.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>If the task was moved (or it was already at the back) true is returned, else false. </para>
				/// </returns>
				/// <java-name>
				/// moveTaskToBack
				/// </java-name>
				[Dot42.DexImport("moveTaskToBack", "(Z)Z", AccessFlags = 1)]
				public virtual bool MoveTaskToBack(bool nonRoot) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Retrieve a SharedPreferences object for accessing preferences that are private to this activity. This simply calls the underlying getSharedPreferences(String, int) method by passing in this activity's class name as the preferences name.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns the single SharedPreferences instance that can be used to retrieve and modify the preference values. </para>
				/// </returns>
				/// <java-name>
				/// getPreferences
				/// </java-name>
				[Dot42.DexImport("getPreferences", "(I)Landroid/content/SharedPreferences;", AccessFlags = 1)]
				public virtual global::Android.Content.ISharedPreferences GetPreferences(int mode) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.ISharedPreferences);
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
				///  <para>Change the title associated with this activity. If this is a top-level activity, the title for its window will change. If it is an embedded activity, the parent can do whatever it wants with it. </para>        
				/// </summary>
				/// <java-name>
				/// setTitle
				/// </java-name>
				[Dot42.DexImport("setTitle", "(Ljava/lang/CharSequence;)V", AccessFlags = 1)]
				public virtual void SetTitle(global::Java.Lang.ICharSequence titleId) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Change the title associated with this activity. If this is a top-level activity, the title for its window will change. If it is an embedded activity, the parent can do whatever it wants with it. </para>        
				/// </summary>
				/// <java-name>
				/// setTitle
				/// </java-name>
				[Dot42.DexImport("setTitle", "(I)V", AccessFlags = 1)]
				public virtual void SetTitle(int titleId) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getTitle
				/// </java-name>
				[Dot42.DexImport("getTitle", "()Ljava/lang/CharSequence;", AccessFlags = 17)]
				public global::Java.Lang.ICharSequence JavaGetTitle() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <java-name>
				/// onTitleChanged
				/// </java-name>
				[Dot42.DexImport("onTitleChanged", "(Ljava/lang/CharSequence;I)V", AccessFlags = 4)]
				protected internal virtual void OnTitleChanged(global::Java.Lang.ICharSequence title, int color) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onChildTitleChanged
				/// </java-name>
				[Dot42.DexImport("onChildTitleChanged", "(Landroid/app/Activity;Ljava/lang/CharSequence;)V", AccessFlags = 4)]
				protected internal virtual void OnChildTitleChanged(global::Android.App.Activity childActivity, global::Java.Lang.ICharSequence title) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the visibility of the progress bar in the title. </para> <para>In order for the progress bar to be shown, the feature must be requested via requestWindowFeature(int).</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setProgressBarVisibility
				/// </java-name>
				[Dot42.DexImport("setProgressBarVisibility", "(Z)V", AccessFlags = 17)]
				public void SetProgressBarVisibility(bool visible) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the visibility of the indeterminate progress bar in the title. </para> <para>In order for the progress bar to be shown, the feature must be requested via requestWindowFeature(int).</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setProgressBarIndeterminateVisibility
				/// </java-name>
				[Dot42.DexImport("setProgressBarIndeterminateVisibility", "(Z)V", AccessFlags = 17)]
				public void SetProgressBarIndeterminateVisibility(bool visible) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets whether the horizontal progress bar in the title should be indeterminate (the circular is always indeterminate). </para> <para>In order for the progress bar to be shown, the feature must be requested via requestWindowFeature(int).</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setProgressBarIndeterminate
				/// </java-name>
				[Dot42.DexImport("setProgressBarIndeterminate", "(Z)V", AccessFlags = 17)]
				public void SetProgressBarIndeterminate(bool indeterminate) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the progress for the progress bars in the title. </para> <para>In order for the progress bar to be shown, the feature must be requested via requestWindowFeature(int).</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setProgress
				/// </java-name>
				[Dot42.DexImport("setProgress", "(I)V", AccessFlags = 17)]
				public void SetProgress(int progress) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the secondary progress for the progress bar in the title. This progress is drawn between the primary progress (set via setProgress(int) and the background. It can be ideal for media scenarios such as showing the buffering progress while the default progress shows the play progress. </para> <para>In order for the progress bar to be shown, the feature must be requested via requestWindowFeature(int).</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setSecondaryProgress
				/// </java-name>
				[Dot42.DexImport("setSecondaryProgress", "(I)V", AccessFlags = 17)]
				public void SetSecondaryProgress(int secondaryProgress) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Runs the specified action on the UI thread. If the current thread is the UI thread, then the action is executed immediately. If the current thread is not the UI thread, the action is posted to the event queue of the UI thread.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// runOnUiThread
				/// </java-name>
				[Dot42.DexImport("runOnUiThread", "(Ljava/lang/Runnable;)V", AccessFlags = 17)]
				public void RunOnUiThread(global::Java.Lang.IRunnable action) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Standard implementation of android.view.LayoutInflater.Factory#onCreateView used when inflating with the LayoutInflater returned by getSystemService. This implementation does nothing and is for pre-android.os.Build.VERSION_CODES#HONEYCOMB apps. Newer apps should use onCreateView(View, String, Context, AttributeSet).</para> <para> <para>android.view.LayoutInflater::createView </para> <para>android.view.Window::getLayoutInflater </para></para>        
				/// </summary>
				/// <java-name>
				/// onCreateView
				/// </java-name>
				[Dot42.DexImport("onCreateView", "(Ljava/lang/String;Landroid/content/Context;Landroid/util/AttributeSet;)Landroid/" +
    "view/View;", AccessFlags = 1)]
				public virtual global::Android.Views.View OnCreateView(string name, global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.View);
				}

				/// <summary>
				///  <para>Standard implementation of android.view.LayoutInflater.Factory2#onCreateView(View, String, Context, AttributeSet) used when inflating with the LayoutInflater returned by getSystemService. This implementation handles &lt;fragment&gt; tags to embed fragments inside of the activity.</para> <para> <para>android.view.LayoutInflater::createView </para> <para>android.view.Window::getLayoutInflater </para></para>        
				/// </summary>
				/// <java-name>
				/// onCreateView
				/// </java-name>
				[Dot42.DexImport("onCreateView", "(Landroid/view/View;Ljava/lang/String;Landroid/content/Context;Landroid/util/Attr" +
    "ibuteSet;)Landroid/view/View;", AccessFlags = 1)]
				public virtual global::Android.Views.View OnCreateView(global::Android.Views.View parent, string name, global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.View);
				}

				/// <summary>
				///  <para>Print the Activity's state into the given stream. This gets invoked if you run "adb shell dumpsys activity &amp;lt;activity_component_name&amp;gt;".</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// dump
				/// </java-name>
				[Dot42.DexImport("dump", "(Ljava/lang/String;Ljava/io/FileDescriptor;Ljava/io/PrintWriter;[Ljava/lang/Strin" +
    "g;)V", AccessFlags = 1)]
				public virtual void Dump(string prefix, global::Java.IO.FileDescriptor fd, global::Java.IO.PrintWriter writer, string[] args) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Start an action mode.</para> <para> <para>ActionMode </para></para>        
				/// </summary>
				/// <returns>
				///  <para>The ContextMode that was started, or null if it was canceled</para>
				/// </returns>
				/// <java-name>
				/// startActionMode
				/// </java-name>
				[Dot42.DexImport("startActionMode", "(Landroid/view/ActionMode$Callback;)Landroid/view/ActionMode;", AccessFlags = 1)]
				public virtual global::Android.Views.ActionMode StartActionMode(global::Android.Views.ActionMode.ICallback callback) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.ActionMode);
				}

				/// <summary>
				///  <para>Give the Activity a chance to control the UI for an action mode requested by the system.</para> <para>Note: If you are looking for a notification callback that an action mode has been started for this activity, see onActionModeStarted(ActionMode).</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The new action mode, or  <code>null</code> if the activity does not want to provide special handling for this action mode. (It will be handled by the system.) </para>
				/// </returns>
				/// <java-name>
				/// onWindowStartingActionMode
				/// </java-name>
				[Dot42.DexImport("onWindowStartingActionMode", "(Landroid/view/ActionMode$Callback;)Landroid/view/ActionMode;", AccessFlags = 1)]
				public virtual global::Android.Views.ActionMode OnWindowStartingActionMode(global::Android.Views.ActionMode.ICallback callback) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.ActionMode);
				}

				/// <summary>
				///  <para>Notifies the Activity that an action mode has been started. Activity subclasses overriding this method should call the superclass implementation.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// onActionModeStarted
				/// </java-name>
				[Dot42.DexImport("onActionModeStarted", "(Landroid/view/ActionMode;)V", AccessFlags = 1)]
				public virtual void OnActionModeStarted(global::Android.Views.ActionMode mode) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Notifies the activity that an action mode has finished. Activity subclasses overriding this method should call the superclass implementation.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// onActionModeFinished
				/// </java-name>
				[Dot42.DexImport("onActionModeFinished", "(Landroid/view/ActionMode;)V", AccessFlags = 1)]
				public virtual void OnActionModeFinished(global::Android.Views.ActionMode mode) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns true if the app should recreate the task when navigating 'up' from this activity by using targetIntent.</para> <para>If this method returns false the app can trivially call navigateUpTo(Intent) using the same parameters to correctly perform up navigation. If this method returns false, the app should synthesize a new task stack by using TaskStackBuilder or another similar mechanism to perform up navigation.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if navigating up should recreate a new task stack, false if the same task should be used for the destination </para>
				/// </returns>
				/// <java-name>
				/// shouldUpRecreateTask
				/// </java-name>
				[Dot42.DexImport("shouldUpRecreateTask", "(Landroid/content/Intent;)Z", AccessFlags = 1)]
				public virtual bool ShouldUpRecreateTask(global::Android.Content.Intent targetIntent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Navigate from this activity to the activity specified by upIntent, finishing this activity in the process. If the activity indicated by upIntent already exists in the task's history, this activity and all others before the indicated activity in the history stack will be finished.</para> <para>If the indicated activity does not appear in the history stack, this will finish each activity in this task until the root activity of the task is reached, resulting in an "in-app home" behavior. This can be useful in apps with a complex navigation hierarchy when an activity may be reached by a path not passing through a canonical parent activity.</para> <para>This method should be used when performing up navigation from within the same task as the destination. If up navigation should cross tasks in some cases, see shouldUpRecreateTask(Intent).</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if up navigation successfully reached the activity indicated by upIntent and upIntent was delivered to it. false if an instance of the indicated activity could not be found and this activity was simply finished normally. </para>
				/// </returns>
				/// <java-name>
				/// navigateUpTo
				/// </java-name>
				[Dot42.DexImport("navigateUpTo", "(Landroid/content/Intent;)Z", AccessFlags = 1)]
				public virtual bool NavigateUpTo(global::Android.Content.Intent upIntent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>This is called when a child activity of this one calls its navigateUpTo method. The default implementation simply calls navigateUpTo(upIntent) on this activity (the parent).</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if up navigation successfully reached the activity indicated by upIntent and upIntent was delivered to it. false if an instance of the indicated activity could not be found and this activity was simply finished normally. </para>
				/// </returns>
				/// <java-name>
				/// navigateUpToFromChild
				/// </java-name>
				[Dot42.DexImport("navigateUpToFromChild", "(Landroid/app/Activity;Landroid/content/Intent;)Z", AccessFlags = 1)]
				public virtual bool NavigateUpToFromChild(global::Android.App.Activity child, global::Android.Content.Intent upIntent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Return the intent that started this activity. </para>        
				/// </summary>
				/// <java-name>
				/// getIntent
				/// </java-name>
				public virtual global::Android.Content.Intent Intent
				{
						[Dot42.DexImport("getIntent", "()Landroid/content/Intent;", AccessFlags = 1)]
						get{ return default(global::Android.Content.Intent); }
						[Dot42.DexImport("setIntent", "(Landroid/content/Intent;)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Return the application that owns this activity. </para>        
				/// </summary>
				/// <java-name>
				/// getApplication
				/// </java-name>
				public global::Android.App.Application Application
				{
						[Dot42.DexImport("getApplication", "()Landroid/app/Application;", AccessFlags = 17)]
						get{ return default(global::Android.App.Application); }
				}

				/// <summary>
				///  <para>Is this activity embedded inside of another activity? </para>        
				/// </summary>
				/// <java-name>
				/// isChild
				/// </java-name>
				public bool IsChild
				{
						[Dot42.DexImport("isChild", "()Z", AccessFlags = 17)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Return the parent activity if this view is an embedded child. </para>        
				/// </summary>
				/// <java-name>
				/// getParent
				/// </java-name>
				public global::Android.App.Activity Parent
				{
						[Dot42.DexImport("getParent", "()Landroid/app/Activity;", AccessFlags = 17)]
						get{ return default(global::Android.App.Activity); }
				}

				/// <summary>
				///  <para>Retrieve the window manager for showing custom windows. </para>        
				/// </summary>
				/// <java-name>
				/// getWindowManager
				/// </java-name>
				public virtual global::Android.Views.IWindowManager WindowManager
				{
						[Dot42.DexImport("getWindowManager", "()Landroid/view/WindowManager;", AccessFlags = 1)]
						get{ return default(global::Android.Views.IWindowManager); }
				}

				/// <summary>
				///  <para>Retrieve the current android.view.Window for the activity. This can be used to directly access parts of the Window API that are not available through Activity/Screen.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Window The current window, or null if the activity is not visual. </para>
				/// </returns>
				/// <java-name>
				/// getWindow
				/// </java-name>
				public virtual global::Android.Views.Window Window
				{
						[Dot42.DexImport("getWindow", "()Landroid/view/Window;", AccessFlags = 1)]
						get{ return default(global::Android.Views.Window); }
				}

				/// <summary>
				///  <para>Return the LoaderManager for this fragment, creating it if needed. </para>        
				/// </summary>
				/// <java-name>
				/// getLoaderManager
				/// </java-name>
				public virtual global::Android.App.LoaderManager LoaderManager
				{
						[Dot42.DexImport("getLoaderManager", "()Landroid/app/LoaderManager;", AccessFlags = 1)]
						get{ return default(global::Android.App.LoaderManager); }
				}

				/// <summary>
				///  <para>Calls android.view.Window#getCurrentFocus on the Window of this Activity to return the currently focused view.</para> <para> <para>getWindow </para> <para>android.view.Window::getCurrentFocus </para></para>        
				/// </summary>
				/// <returns>
				///  <para>View The current View with focus or null.</para>
				/// </returns>
				/// <java-name>
				/// getCurrentFocus
				/// </java-name>
				public virtual global::Android.Views.View CurrentFocus
				{
						[Dot42.DexImport("getCurrentFocus", "()Landroid/view/View;", AccessFlags = 1)]
						get{ return default(global::Android.Views.View); }
				}

				/// <summary>
				///  <para>If this activity is being destroyed because it can not handle a configuration parameter being changed (and thus its onConfigurationChanged(Configuration) method is  <b>not</b> being called), then you can use this method to discover the set of changes that have occurred while in the process of being destroyed. Note that there is no guarantee that these will be accurate (other changes could have happened at any time), so you should only use this as an optimization hint.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns a bit field of the configuration parameters that are changing, as defined by the android.content.res.Configuration class. </para>
				/// </returns>
				/// <java-name>
				/// getChangingConfigurations
				/// </java-name>
				public virtual int ChangingConfigurations
				{
						[Dot42.DexImport("getChangingConfigurations", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Retrieve the non-configuration instance data that was previously returned by onRetainNonConfigurationInstance(). This will be available from the initial onCreate and onStart calls to the new instance, allowing you to extract any useful dynamic state from the previous instance.</para> <para>Note that the data you retrieve here should  <b>only</b> be used as an optimization for handling configuration changes. You should always be able to handle getting a null pointer back, and an activity must still be able to restore itself to its previous state (through the normal onSaveInstanceState(Bundle) mechanism) even if this function returns null.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use the new Fragment API Fragment#setRetainInstance(boolean) instead; this is also available on older platforms through the Android compatibility package. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns the object previously returned by onRetainNonConfigurationInstance().</para>
				/// </returns>
				/// <java-name>
				/// getLastNonConfigurationInstance
				/// </java-name>
				public virtual object LastNonConfigurationInstance
				{
						[Dot42.DexImport("getLastNonConfigurationInstance", "()Ljava/lang/Object;", AccessFlags = 1)]
						get{ return default(object); }
				}

				/// <summary>
				///  <para>Return the FragmentManager for interacting with fragments associated with this activity. </para>        
				/// </summary>
				/// <java-name>
				/// getFragmentManager
				/// </java-name>
				public virtual global::Android.App.FragmentManager FragmentManager
				{
						[Dot42.DexImport("getFragmentManager", "()Landroid/app/FragmentManager;", AccessFlags = 1)]
						get{ return default(global::Android.App.FragmentManager); }
				}

				/// <summary>
				///  <para>Retrieve a reference to this activity's ActionBar.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The Activity's ActionBar, or null if it does not have one. </para>
				/// </returns>
				/// <java-name>
				/// getActionBar
				/// </java-name>
				public virtual global::Android.App.ActionBar ActionBar
				{
						[Dot42.DexImport("getActionBar", "()Landroid/app/ActionBar;", AccessFlags = 1)]
						get{ return default(global::Android.App.ActionBar); }
				}

				/// <summary>
				///  <para>Returns true if this activity's  <b>main</b> window currently has window focus. Note that this is not the same as the view itself having focus.</para> <para> <para>onWindowAttributesChanged(android.view.WindowManager.LayoutParams) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>True if this activity's main window currently has window focus.</para>
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
				///  <para>Convenience for calling android.view.Window#getLayoutInflater. </para>        
				/// </summary>
				/// <java-name>
				/// getLayoutInflater
				/// </java-name>
				public virtual global::Android.Views.LayoutInflater LayoutInflater
				{
						[Dot42.DexImport("getLayoutInflater", "()Landroid/view/LayoutInflater;", AccessFlags = 1)]
						get{ return default(global::Android.Views.LayoutInflater); }
				}

				/// <summary>
				///  <para>Returns a MenuInflater with this context. </para>        
				/// </summary>
				/// <java-name>
				/// getMenuInflater
				/// </java-name>
				public virtual global::Android.Views.MenuInflater MenuInflater
				{
						[Dot42.DexImport("getMenuInflater", "()Landroid/view/MenuInflater;", AccessFlags = 1)]
						get{ return default(global::Android.Views.MenuInflater); }
				}

				/// <summary>
				///  <para>Return the name of the package that invoked this activity. This is who the data in setResult() will be sent to. You can use this information to validate that the recipient is allowed to receive the data.</para> <para>Note: if the calling activity is not expecting a result (that is it did not use the startActivityForResult form that includes a request code), then the calling package will be null.</para> <para>Note: prior to android.os.Build.VERSION_CODES#JELLY_BEAN_MR2, the result from this method was unstable. If the process hosting the calling package was no longer running, it would return null instead of the proper package name. You can use getCallingActivity() and retrieve the package name from that instead.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The package of the activity that will receive your reply, or null if none. </para>
				/// </returns>
				/// <java-name>
				/// getCallingPackage
				/// </java-name>
				public virtual string CallingPackage
				{
						[Dot42.DexImport("getCallingPackage", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>Return the name of the activity that invoked this activity. This is who the data in setResult() will be sent to. You can use this information to validate that the recipient is allowed to receive the data.</para> <para>Note: if the calling activity is not expecting a result (that is it did not use the startActivityForResult form that includes a request code), then the calling package will be null.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The ComponentName of the activity that will receive your reply, or null if none. </para>
				/// </returns>
				/// <java-name>
				/// getCallingActivity
				/// </java-name>
				public virtual global::Android.Content.ComponentName CallingActivity
				{
						[Dot42.DexImport("getCallingActivity", "()Landroid/content/ComponentName;", AccessFlags = 1)]
						get{ return default(global::Android.Content.ComponentName); }
				}

				/// <summary>
				///  <para>Check to see whether this activity is in the process of finishing, either because you called finish on it or someone else has requested that it finished. This is often used in onPause to determine whether the activity is simply pausing or completely finishing.</para> <para> <para>finish </para></para>        
				/// </summary>
				/// <returns>
				///  <para>If the activity is finishing, returns true; else returns false.</para>
				/// </returns>
				/// <java-name>
				/// isFinishing
				/// </java-name>
				public virtual bool IsFinishing
				{
						[Dot42.DexImport("isFinishing", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Returns true if the final onDestroy() call has been made on the Activity, so this instance is now dead. </para>        
				/// </summary>
				/// <java-name>
				/// isDestroyed
				/// </java-name>
				public virtual bool IsDestroyed
				{
						[Dot42.DexImport("isDestroyed", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Check to see whether this activity is in the process of being destroyed in order to be recreated with a new configuration. This is often used in onStop to determine whether the state needs to be cleaned up or will be passed on to the next instance of the activity via onRetainNonConfigurationInstance().</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>If the activity is being torn down in order to be recreated with a new configuration, returns true; else returns false. </para>
				/// </returns>
				/// <java-name>
				/// isChangingConfigurations
				/// </java-name>
				public virtual bool IsChangingConfigurations
				{
						[Dot42.DexImport("isChangingConfigurations", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Return the current requested orientation of the activity. This will either be the orientation requested in its component's manifest, or the last requested orientation given to setRequestedOrientation(int).</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns an orientation constant as used in ActivityInfo.screenOrientation. </para>
				/// </returns>
				/// <java-name>
				/// getRequestedOrientation
				/// </java-name>
				public virtual int RequestedOrientation
				{
						[Dot42.DexImport("getRequestedOrientation", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setRequestedOrientation", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Return the identifier of the task this activity is in. This identifier will remain the same for the lifetime of the activity.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Task identifier, an opaque integer. </para>
				/// </returns>
				/// <java-name>
				/// getTaskId
				/// </java-name>
				public virtual int TaskId
				{
						[Dot42.DexImport("getTaskId", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Return whether this activity is the root of a task. The root is the first activity in a task.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>True if this is the root activity, else false. </para>
				/// </returns>
				/// <java-name>
				/// isTaskRoot
				/// </java-name>
				public virtual bool IsTaskRoot
				{
						[Dot42.DexImport("isTaskRoot", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Returns class name for this activity with the package prefix removed. This is the default name used to read and write settings.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The local class name. </para>
				/// </returns>
				/// <java-name>
				/// getLocalClassName
				/// </java-name>
				public virtual string LocalClassName
				{
						[Dot42.DexImport("getLocalClassName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>Returns complete component name of this activity.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns the complete component name for this activity </para>
				/// </returns>
				/// <java-name>
				/// getComponentName
				/// </java-name>
				public virtual global::Android.Content.ComponentName ComponentName
				{
						[Dot42.DexImport("getComponentName", "()Landroid/content/ComponentName;", AccessFlags = 1)]
						get{ return default(global::Android.Content.ComponentName); }
				}

				/// <java-name>
				/// getTitleColor
				/// </java-name>
				public virtual int TitleColor
				{
						[Dot42.DexImport("getTitleColor", "()I", AccessFlags = 17)]
						get{ return default(int); }
						[Dot42.DexImport("setTitleColor", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Gets the suggested audio stream whose volume should be changed by the harwdare volume controls.</para> <para> <para>setVolumeControlStream(int) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>The suggested audio stream type whose volume should be changed by the hardware volume controls. </para>
				/// </returns>
				/// <java-name>
				/// getVolumeControlStream
				/// </java-name>
				public int VolumeControlStream
				{
						[Dot42.DexImport("getVolumeControlStream", "()I", AccessFlags = 17)]
						get{ return default(int); }
						[Dot42.DexImport("setVolumeControlStream", "(I)V", AccessFlags = 17)]
						set{ }
				}

				/// <summary>
				///  <para>Bit indicating that this activity is "immersive" and should not be interrupted by notifications if possible.</para> <para>This value is initially set by the manifest property  <code>android:immersive</code> but may be changed at runtime by setImmersive.</para> <para> <para>setImmersive(boolean) </para> <para>android.content.pm.ActivityInfo::FLAG_IMMERSIVE </para></para>        
				/// </summary>
				/// <java-name>
				/// isImmersive
				/// </java-name>
				public virtual bool IsImmersive
				{
						[Dot42.DexImport("isImmersive", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setImmersive", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Obtain an Intent that will launch an explicit target activity specified by this activity's logical parent. The logical parent is named in the application's manifest by the parentActivityName attribute. Activity subclasses may override this method to modify the Intent returned by super.getParentActivityIntent() or to implement a different mechanism of retrieving the parent intent entirely.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a new Intent targeting the defined parent of this activity or null if there is no valid parent. </para>
				/// </returns>
				/// <java-name>
				/// getParentActivityIntent
				/// </java-name>
				public virtual global::Android.Content.Intent ParentActivityIntent
				{
						[Dot42.DexImport("getParentActivityIntent", "()Landroid/content/Intent;", AccessFlags = 1)]
						get{ return default(global::Android.Content.Intent); }
				}

		}

		/// <summary>
		///  <para>A screen that contains and runs multiple embedded activities.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use the new Fragment and FragmentManager APIs instead; these are also available on older platforms through the Android compatibility package. </para></xrefdescription></xrefsect></para>    
		/// </summary>
		/// <java-name>
		/// android/app/ActivityGroup
		/// </java-name>
		[Dot42.DexImport("android/app/ActivityGroup", AccessFlags = 33)]
		public partial class ActivityGroup : global::Android.App.Activity
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ActivityGroup() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Z)V", AccessFlags = 1)]
				public ActivityGroup(bool singleActivityMode) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onCreate
				/// </java-name>
				[Dot42.DexImport("onCreate", "(Landroid/os/Bundle;)V", AccessFlags = 4)]
				protected internal override void OnCreate(global::Android.OS.Bundle savedInstanceState) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onResume
				/// </java-name>
				[Dot42.DexImport("onResume", "()V", AccessFlags = 4)]
				protected internal override void OnResume() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onSaveInstanceState
				/// </java-name>
				[Dot42.DexImport("onSaveInstanceState", "(Landroid/os/Bundle;)V", AccessFlags = 4)]
				protected internal override void OnSaveInstanceState(global::Android.OS.Bundle outState) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onPause
				/// </java-name>
				[Dot42.DexImport("onPause", "()V", AccessFlags = 4)]
				protected internal override void OnPause() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onStop
				/// </java-name>
				[Dot42.DexImport("onStop", "()V", AccessFlags = 4)]
				protected internal override void OnStop() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onDestroy
				/// </java-name>
				[Dot42.DexImport("onDestroy", "()V", AccessFlags = 4)]
				protected internal override void OnDestroy() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getCurrentActivity
				/// </java-name>
				public virtual global::Android.App.Activity CurrentActivity
				{
						[Dot42.DexImport("getCurrentActivity", "()Landroid/app/Activity;", AccessFlags = 1)]
						get{ return default(global::Android.App.Activity); }
				}

				/// <java-name>
				/// getLocalActivityManager
				/// </java-name>
				public global::Android.App.LocalActivityManager LocalActivityManager
				{
						[Dot42.DexImport("getLocalActivityManager", "()Landroid/app/LocalActivityManager;", AccessFlags = 17)]
						get{ return default(global::Android.App.LocalActivityManager); }
				}

		}

		/// <summary>
		///  <para>Interact with the overall activities running in the system. </para>    
		/// </summary>
		/// <java-name>
		/// android/app/ActivityManager
		/// </java-name>
		[Dot42.DexImport("android/app/ActivityManager", AccessFlags = 33)]
		public partial class ActivityManager
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Flag for use with getRecentTasks: return all tasks, even those that have set their android.content.Intent#FLAG_ACTIVITY_EXCLUDE_FROM_RECENTS flag. </para>        
				/// </summary>
				/// <java-name>
				/// RECENT_WITH_EXCLUDED
				/// </java-name>
				[Dot42.DexImport("RECENT_WITH_EXCLUDED", "I", AccessFlags = 25)]
				public const int RECENT_WITH_EXCLUDED = 1;
				/// <summary>
				///  <para>Provides a list that does not contain any recent tasks that currently are not available to the user. </para>        
				/// </summary>
				/// <java-name>
				/// RECENT_IGNORE_UNAVAILABLE
				/// </java-name>
				[Dot42.DexImport("RECENT_IGNORE_UNAVAILABLE", "I", AccessFlags = 25)]
				public const int RECENT_IGNORE_UNAVAILABLE = 2;
				/// <summary>
				///  <para>Flag for moveTaskToFront(int, int): also move the "home" activity along with the task, so it is positioned immediately behind the task. </para>        
				/// </summary>
				/// <java-name>
				/// MOVE_TASK_WITH_HOME
				/// </java-name>
				[Dot42.DexImport("MOVE_TASK_WITH_HOME", "I", AccessFlags = 25)]
				public const int MOVE_TASK_WITH_HOME = 1;
				/// <summary>
				///  <para>Flag for moveTaskToFront(int, int): don't count this as a user-instigated action, so the current activity will not receive a hint that the user is leaving. </para>        
				/// </summary>
				/// <java-name>
				/// MOVE_TASK_NO_USER_ACTION
				/// </java-name>
				[Dot42.DexImport("MOVE_TASK_NO_USER_ACTION", "I", AccessFlags = 25)]
				public const int MOVE_TASK_NO_USER_ACTION = 2;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal ActivityManager() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Return a list of the tasks that the user has recently launched, with the most recent being first and older ones after in order.</para> <para> <b>Note: this method is only intended for debugging and presenting task management user interfaces</b>. This should never be used for core logic in an application, such as deciding between different behaviors based on the information found here. Such uses are  <b>not</b> supported, and will likely break in the future. For example, if multiple applications can be actively running at the same time, assumptions made about the meaning of the data here for purposes of control flow will be incorrect.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns a list of RecentTaskInfo records describing each of the recent tasks.</para>
				/// </returns>
				/// <java-name>
				/// getRecentTasks
				/// </java-name>
				[Dot42.DexImport("getRecentTasks", "(II)Ljava/util/List;", AccessFlags = 1, Signature = "(II)Ljava/util/List<Landroid/app/ActivityManager$RecentTaskInfo;>;")]
				public virtual global::Java.Util.IList<global::Android.App.ActivityManager.RecentTaskInfo> GetRecentTasks(int maxNum, int flags) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<global::Android.App.ActivityManager.RecentTaskInfo>);
				}

				/// <summary>
				///  <para>Return a list of the tasks that are currently running, with the most recent being first and older ones after in order. Note that "running" does not mean any of the task's code is currently loaded or activity  the task may have been frozen by the system, so that it can be restarted in its previous state when next brought to the foreground.</para> <para> <b>Note: this method is only intended for debugging and presenting task management user interfaces</b>. This should never be used for core logic in an application, such as deciding between different behaviors based on the information found here. Such uses are  <b>not</b> supported, and will likely break in the future. For example, if multiple applications can be actively running at the same time, assumptions made about the meaning of the data here for purposes of control flow will be incorrect.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns a list of RunningTaskInfo records describing each of the running tasks.</para>
				/// </returns>
				/// <java-name>
				/// getRunningTasks
				/// </java-name>
				[Dot42.DexImport("getRunningTasks", "(I)Ljava/util/List;", AccessFlags = 1, Signature = "(I)Ljava/util/List<Landroid/app/ActivityManager$RunningTaskInfo;>;")]
				public virtual global::Java.Util.IList<global::Android.App.ActivityManager.RunningTaskInfo> GetRunningTasks(int maxNum) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<global::Android.App.ActivityManager.RunningTaskInfo>);
				}

				/// <summary>
				///  <para>Equivalent to calling moveTaskToFront(int, int, Bundle) with a null options argument.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// moveTaskToFront
				/// </java-name>
				[Dot42.DexImport("moveTaskToFront", "(II)V", AccessFlags = 1)]
				public virtual void MoveTaskToFront(int taskId, int flags) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Ask that the task associated with a given task ID be moved to the front of the stack, so it is now visible to the user. Requires that the caller hold permission android.Manifest.permission#REORDER_TASKS or a SecurityException will be thrown.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// moveTaskToFront
				/// </java-name>
				[Dot42.DexImport("moveTaskToFront", "(IILandroid/os/Bundle;)V", AccessFlags = 1)]
				public virtual void MoveTaskToFront(int taskId, int flags, global::Android.OS.Bundle options) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Return a list of the services that are currently running.</para> <para> <b>Note: this method is only intended for debugging or implementing service management type user interfaces.</b></para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns a list of RunningServiceInfo records describing each of the running tasks. </para>
				/// </returns>
				/// <java-name>
				/// getRunningServices
				/// </java-name>
				[Dot42.DexImport("getRunningServices", "(I)Ljava/util/List;", AccessFlags = 1, Signature = "(I)Ljava/util/List<Landroid/app/ActivityManager$RunningServiceInfo;>;")]
				public virtual global::Java.Util.IList<global::Android.App.ActivityManager.RunningServiceInfo> GetRunningServices(int maxNum) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<global::Android.App.ActivityManager.RunningServiceInfo>);
				}

				/// <summary>
				///  <para>Returns a PendingIntent you can start to show a control panel for the given running service. If the service does not have a control panel, null is returned. </para>        
				/// </summary>
				/// <java-name>
				/// getRunningServiceControlPanel
				/// </java-name>
				[Dot42.DexImport("getRunningServiceControlPanel", "(Landroid/content/ComponentName;)Landroid/app/PendingIntent;", AccessFlags = 1)]
				public virtual global::Android.App.PendingIntent GetRunningServiceControlPanel(global::Android.Content.ComponentName service) /* MethodBuilder.Create */ 
				{
						return default(global::Android.App.PendingIntent);
				}

				/// <summary>
				///  <para>Return general information about the memory state of the system. This can be used to help decide how to manage your own memory, though note that polling is not recommended and ComponentCallbacks2.onTrimMemory(int) is the preferred way to do this. Also see getMyMemoryState for how to retrieve the current trim level of your process as needed, which gives a better hint for how to manage its memory. </para>        
				/// </summary>
				/// <java-name>
				/// getMemoryInfo
				/// </java-name>
				[Dot42.DexImport("getMemoryInfo", "(Landroid/app/ActivityManager$MemoryInfo;)V", AccessFlags = 1)]
				public virtual void GetMemoryInfo(global::Android.App.ActivityManager.MemoryInfo outInfo) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Return global memory state information for the calling process. This does not fill in all fields of the RunningAppProcessInfo. The only fields that will be filled in are RunningAppProcessInfo#pid, RunningAppProcessInfo#uid, RunningAppProcessInfo#lastTrimLevel, RunningAppProcessInfo#importance, RunningAppProcessInfo#lru, and RunningAppProcessInfo#importanceReasonCode. </para>        
				/// </summary>
				/// <java-name>
				/// getMyMemoryState
				/// </java-name>
				[Dot42.DexImport("getMyMemoryState", "(Landroid/app/ActivityManager$RunningAppProcessInfo;)V", AccessFlags = 9)]
				public static void GetMyMemoryState(global::Android.App.ActivityManager.RunningAppProcessInfo outState) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Return information about the memory usage of one or more processes.</para> <para> <b>Note: this method is only intended for debugging or building a user-facing process management UI.</b></para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns an array of memory information, one for each requested pid. </para>
				/// </returns>
				/// <java-name>
				/// getProcessMemoryInfo
				/// </java-name>
				[Dot42.DexImport("getProcessMemoryInfo", "([I)[Landroid/os/Debug$MemoryInfo;", AccessFlags = 1)]
				public virtual global::Android.OS.Debug.MemoryInfo[] GetProcessMemoryInfo(int[] pids) /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.Debug.MemoryInfo[]);
				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>This is now just a wrapper for killBackgroundProcesses(String); the previous behavior here is no longer available to applications because it allows them to break other applications by removing their alarms, stopping their services, etc. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// restartPackage
				/// </java-name>
				[Dot42.DexImport("restartPackage", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void RestartPackage(string packageName) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Have the system immediately kill all background processes associated with the given package. This is the same as the kernel killing those processes to reclaim memory; the system will take care of restarting these processes in the future as needed.</para> <para>You must hold the permission android.Manifest.permission#KILL_BACKGROUND_PROCESSES to be able to call this method.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// killBackgroundProcesses
				/// </java-name>
				[Dot42.DexImport("killBackgroundProcesses", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void KillBackgroundProcesses(string packageName) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Return the approximate per-application memory class of the current device. This gives you an idea of how hard a memory limit you should impose on your application to let the overall system work best. The returned value is in megabytes; the baseline Android memory class is 16 (which happens to be the Java heap limit of those devices); some device with more memory may return 24 or even higher numbers. </para>        
				/// </summary>
				/// <java-name>
				/// getMemoryClass
				/// </java-name>
				public virtual int MemoryClass
				{
						[Dot42.DexImport("getMemoryClass", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Return the approximate per-application memory class of the current device when an application is running with a large heap. This is the space available for memory-intensive applications; most applications should not need this amount of memory, and should instead stay with the getMemoryClass() limit. The returned value is in megabytes. This may be the same size as getMemoryClass() on memory constrained devices, or it may be significantly larger on devices with a large amount of available RAM.</para> <para>The is the size of the application's Dalvik heap if it has specified  <code>android:largeHeap="true"</code> in its manifest. </para>        
				/// </summary>
				/// <java-name>
				/// getLargeMemoryClass
				/// </java-name>
				public virtual int LargeMemoryClass
				{
						[Dot42.DexImport("getLargeMemoryClass", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns a list of any processes that are currently in an error condition. The result will be null if all processes are running properly at this time.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns a list of ProcessErrorStateInfo records, or null if there are no current error conditions (it will not return an empty list). This list ordering is not specified. </para>
				/// </returns>
				/// <java-name>
				/// getProcessesInErrorState
				/// </java-name>
				public virtual global::Java.Util.IList<global::Android.App.ActivityManager.ProcessErrorStateInfo> ProcessesInErrorState
				{
						[Dot42.DexImport("getProcessesInErrorState", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Landroid/app/ActivityManager$ProcessErrorStateInfo;>;")]
						get{ return default(global::Java.Util.IList<global::Android.App.ActivityManager.ProcessErrorStateInfo>); }
				}

				/// <summary>
				///  <para>Returns a list of application processes that are running on the device.</para> <para> <b>Note: this method is only intended for debugging or building a user-facing process management UI.</b></para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns a list of RunningAppProcessInfo records, or null if there are no running processes (it will not return an empty list). This list ordering is not specified. </para>
				/// </returns>
				/// <java-name>
				/// getRunningAppProcesses
				/// </java-name>
				public virtual global::Java.Util.IList<global::Android.App.ActivityManager.RunningAppProcessInfo> RunningAppProcesses
				{
						[Dot42.DexImport("getRunningAppProcesses", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Landroid/app/ActivityManager$RunningAppProcessInfo;>;")]
						get{ return default(global::Java.Util.IList<global::Android.App.ActivityManager.RunningAppProcessInfo>); }
				}

				/// <summary>
				///  <para>Get the device configuration attributes. </para>        
				/// </summary>
				/// <java-name>
				/// getDeviceConfigurationInfo
				/// </java-name>
				public virtual global::Android.Content.PM.ConfigurationInfo DeviceConfigurationInfo
				{
						[Dot42.DexImport("getDeviceConfigurationInfo", "()Landroid/content/pm/ConfigurationInfo;", AccessFlags = 1)]
						get{ return default(global::Android.Content.PM.ConfigurationInfo); }
				}

				/// <summary>
				///  <para>Get the preferred density of icons for the launcher. This is used when custom drawables are created (e.g., for shortcuts).</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>density in terms of DPI </para>
				/// </returns>
				/// <java-name>
				/// getLauncherLargeIconDensity
				/// </java-name>
				public virtual int LauncherLargeIconDensity
				{
						[Dot42.DexImport("getLauncherLargeIconDensity", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Get the preferred launcher icon size. This is used when custom drawables are created (e.g., for shortcuts).</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>dimensions of square icons in terms of pixels </para>
				/// </returns>
				/// <java-name>
				/// getLauncherLargeIconSize
				/// </java-name>
				public virtual int LauncherLargeIconSize
				{
						[Dot42.DexImport("getLauncherLargeIconSize", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns "true" if the user interface is currently being messed with by a monkey. </para>        
				/// </summary>
				/// <java-name>
				/// isUserAMonkey
				/// </java-name>
				public static bool IsUserAMonkey
				{
						[Dot42.DexImport("isUserAMonkey", "()Z", AccessFlags = 9)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Returns "true" if device is running in a test harness. </para>        
				/// </summary>
				/// <java-name>
				/// isRunningInTestHarness
				/// </java-name>
				public static bool IsRunningInTestHarness
				{
						[Dot42.DexImport("isRunningInTestHarness", "()Z", AccessFlags = 9)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Information you can retrieve about a running process. </para>    
				/// </summary>
				/// <java-name>
				/// android/app/ActivityManager$RunningAppProcessInfo
				/// </java-name>
				[Dot42.DexImport("android/app/ActivityManager$RunningAppProcessInfo", AccessFlags = 9)]
				public partial class RunningAppProcessInfo : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>The name of the process that this object is associated with </para>        
						/// </summary>
						/// <java-name>
						/// processName
						/// </java-name>
						[Dot42.DexImport("processName", "Ljava/lang/String;", AccessFlags = 1)]
						public string ProcessName;
						/// <summary>
						///  <para>The pid of this process; 0 if none </para>        
						/// </summary>
						/// <java-name>
						/// pid
						/// </java-name>
						[Dot42.DexImport("pid", "I", AccessFlags = 1)]
						public int Pid;
						/// <summary>
						///  <para>The user id of this process. </para>        
						/// </summary>
						/// <java-name>
						/// uid
						/// </java-name>
						[Dot42.DexImport("uid", "I", AccessFlags = 1)]
						public int Uid;
						/// <summary>
						///  <para>All packages that have been loaded into the process. </para>        
						/// </summary>
						/// <java-name>
						/// pkgList
						/// </java-name>
						[Dot42.DexImport("pkgList", "[Ljava/lang/String;", AccessFlags = 1)]
						public string[] PkgList;
						/// <summary>
						///  <para>Last memory trim level reported to the process: corresponds to the values supplied to ComponentCallbacks2.onTrimMemory(int). </para>        
						/// </summary>
						/// <java-name>
						/// lastTrimLevel
						/// </java-name>
						[Dot42.DexImport("lastTrimLevel", "I", AccessFlags = 1)]
						public int LastTrimLevel;
						/// <summary>
						///  <para>Constant for importance: this process is running the foreground UI. </para>        
						/// </summary>
						/// <java-name>
						/// IMPORTANCE_FOREGROUND
						/// </java-name>
						[Dot42.DexImport("IMPORTANCE_FOREGROUND", "I", AccessFlags = 25)]
						public const int IMPORTANCE_FOREGROUND = 100;
						/// <summary>
						///  <para>Constant for importance: this process is running something that is actively visible to the user, though not in the immediate foreground. </para>        
						/// </summary>
						/// <java-name>
						/// IMPORTANCE_VISIBLE
						/// </java-name>
						[Dot42.DexImport("IMPORTANCE_VISIBLE", "I", AccessFlags = 25)]
						public const int IMPORTANCE_VISIBLE = 200;
						/// <summary>
						///  <para>Constant for importance: this process is running something that is considered to be actively perceptible to the user. An example would be an application performing background music playback. </para>        
						/// </summary>
						/// <java-name>
						/// IMPORTANCE_PERCEPTIBLE
						/// </java-name>
						[Dot42.DexImport("IMPORTANCE_PERCEPTIBLE", "I", AccessFlags = 25)]
						public const int IMPORTANCE_PERCEPTIBLE = 130;
						/// <summary>
						///  <para>Constant for importance: this process is contains services that should remain running. </para>        
						/// </summary>
						/// <java-name>
						/// IMPORTANCE_SERVICE
						/// </java-name>
						[Dot42.DexImport("IMPORTANCE_SERVICE", "I", AccessFlags = 25)]
						public const int IMPORTANCE_SERVICE = 300;
						/// <summary>
						///  <para>Constant for importance: this process process contains background code that is expendable. </para>        
						/// </summary>
						/// <java-name>
						/// IMPORTANCE_BACKGROUND
						/// </java-name>
						[Dot42.DexImport("IMPORTANCE_BACKGROUND", "I", AccessFlags = 25)]
						public const int IMPORTANCE_BACKGROUND = 400;
						/// <summary>
						///  <para>Constant for importance: this process is empty of any actively running code. </para>        
						/// </summary>
						/// <java-name>
						/// IMPORTANCE_EMPTY
						/// </java-name>
						[Dot42.DexImport("IMPORTANCE_EMPTY", "I", AccessFlags = 25)]
						public const int IMPORTANCE_EMPTY = 500;
						/// <summary>
						///  <para>The relative importance level that the system places on this process. May be one of IMPORTANCE_FOREGROUND, IMPORTANCE_VISIBLE, IMPORTANCE_SERVICE, IMPORTANCE_BACKGROUND, or IMPORTANCE_EMPTY. These constants are numbered so that "more important" values are always smaller than "less important" values. </para>        
						/// </summary>
						/// <java-name>
						/// importance
						/// </java-name>
						[Dot42.DexImport("importance", "I", AccessFlags = 1)]
						public int Importance;
						/// <summary>
						///  <para>An additional ordering within a particular importance category, providing finer-grained information about the relative utility of processes within a category. This number means nothing except that a smaller values are more recently used (and thus more important). Currently an LRU value is only maintained for the IMPORTANCE_BACKGROUND category, though others may be maintained in the future. </para>        
						/// </summary>
						/// <java-name>
						/// lru
						/// </java-name>
						[Dot42.DexImport("lru", "I", AccessFlags = 1)]
						public int Lru;
						/// <summary>
						///  <para>Constant for importanceReasonCode: nothing special has been specified for the reason for this level. </para>        
						/// </summary>
						/// <java-name>
						/// REASON_UNKNOWN
						/// </java-name>
						[Dot42.DexImport("REASON_UNKNOWN", "I", AccessFlags = 25)]
						public const int REASON_UNKNOWN = 0;
						/// <summary>
						///  <para>Constant for importanceReasonCode: one of the application's content providers is being used by another process. The pid of the client process is in importanceReasonPid and the target provider in this process is in importanceReasonComponent. </para>        
						/// </summary>
						/// <java-name>
						/// REASON_PROVIDER_IN_USE
						/// </java-name>
						[Dot42.DexImport("REASON_PROVIDER_IN_USE", "I", AccessFlags = 25)]
						public const int REASON_PROVIDER_IN_USE = 1;
						/// <summary>
						///  <para>Constant for importanceReasonCode: one of the application's content providers is being used by another process. The pid of the client process is in importanceReasonPid and the target provider in this process is in importanceReasonComponent. </para>        
						/// </summary>
						/// <java-name>
						/// REASON_SERVICE_IN_USE
						/// </java-name>
						[Dot42.DexImport("REASON_SERVICE_IN_USE", "I", AccessFlags = 25)]
						public const int REASON_SERVICE_IN_USE = 2;
						/// <summary>
						///  <para>The reason for importance, if any. </para>        
						/// </summary>
						/// <java-name>
						/// importanceReasonCode
						/// </java-name>
						[Dot42.DexImport("importanceReasonCode", "I", AccessFlags = 1)]
						public int ImportanceReasonCode;
						/// <summary>
						///  <para>For the specified values of importanceReasonCode, this is the process ID of the other process that is a client of this process. This will be 0 if no other process is using this one. </para>        
						/// </summary>
						/// <java-name>
						/// importanceReasonPid
						/// </java-name>
						[Dot42.DexImport("importanceReasonPid", "I", AccessFlags = 1)]
						public int ImportanceReasonPid;
						/// <summary>
						///  <para>For the specified values of importanceReasonCode, this is the name of the component that is being used in this process. </para>        
						/// </summary>
						/// <java-name>
						/// importanceReasonComponent
						/// </java-name>
						[Dot42.DexImport("importanceReasonComponent", "Landroid/content/ComponentName;", AccessFlags = 1)]
						public global::Android.Content.ComponentName ImportanceReasonComponent;
						/// <java-name>
						/// CREATOR
						/// </java-name>
						[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
						public static readonly global::Android.OS.IParcelable_ICreator<RunningAppProcessInfo> CREATOR;
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public RunningAppProcessInfo() /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "(Ljava/lang/String;I[Ljava/lang/String;)V", AccessFlags = 1)]
						public RunningAppProcessInfo(string @string, int int32, string[] string1) /* MethodBuilder.Create */ 
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

						/// <java-name>
						/// readFromParcel
						/// </java-name>
						[Dot42.DexImport("readFromParcel", "(Landroid/os/Parcel;)V", AccessFlags = 1)]
						public virtual void ReadFromParcel(global::Android.OS.Parcel source) /* MethodBuilder.Create */ 
						{
						}

				}

				/// <summary>
				///  <para>Information you can retrieve about any processes that are in an error condition. </para>    
				/// </summary>
				/// <java-name>
				/// android/app/ActivityManager$ProcessErrorStateInfo
				/// </java-name>
				[Dot42.DexImport("android/app/ActivityManager$ProcessErrorStateInfo", AccessFlags = 9)]
				public partial class ProcessErrorStateInfo : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>Condition codes </para>        
						/// </summary>
						/// <java-name>
						/// NO_ERROR
						/// </java-name>
						[Dot42.DexImport("NO_ERROR", "I", AccessFlags = 25)]
						public const int NO_ERROR = 0;
						/// <java-name>
						/// CRASHED
						/// </java-name>
						[Dot42.DexImport("CRASHED", "I", AccessFlags = 25)]
						public const int CRASHED = 1;
						/// <java-name>
						/// NOT_RESPONDING
						/// </java-name>
						[Dot42.DexImport("NOT_RESPONDING", "I", AccessFlags = 25)]
						public const int NOT_RESPONDING = 2;
						/// <summary>
						///  <para>The condition that the process is in. </para>        
						/// </summary>
						/// <java-name>
						/// condition
						/// </java-name>
						[Dot42.DexImport("condition", "I", AccessFlags = 1)]
						public int Condition;
						/// <summary>
						///  <para>The process name in which the crash or error occurred. </para>        
						/// </summary>
						/// <java-name>
						/// processName
						/// </java-name>
						[Dot42.DexImport("processName", "Ljava/lang/String;", AccessFlags = 1)]
						public string ProcessName;
						/// <summary>
						///  <para>The pid of this process; 0 if none </para>        
						/// </summary>
						/// <java-name>
						/// pid
						/// </java-name>
						[Dot42.DexImport("pid", "I", AccessFlags = 1)]
						public int Pid;
						/// <summary>
						///  <para>The kernel user-ID that has been assigned to this process; currently this is not a unique ID (multiple applications can have the same uid). </para>        
						/// </summary>
						/// <java-name>
						/// uid
						/// </java-name>
						[Dot42.DexImport("uid", "I", AccessFlags = 1)]
						public int Uid;
						/// <summary>
						///  <para>The activity name associated with the error, if known. May be null. </para>        
						/// </summary>
						/// <java-name>
						/// tag
						/// </java-name>
						[Dot42.DexImport("tag", "Ljava/lang/String;", AccessFlags = 1)]
						public string Tag;
						/// <summary>
						///  <para>A short message describing the error condition. </para>        
						/// </summary>
						/// <java-name>
						/// shortMsg
						/// </java-name>
						[Dot42.DexImport("shortMsg", "Ljava/lang/String;", AccessFlags = 1)]
						public string ShortMsg;
						/// <summary>
						///  <para>A long message describing the error condition. </para>        
						/// </summary>
						/// <java-name>
						/// longMsg
						/// </java-name>
						[Dot42.DexImport("longMsg", "Ljava/lang/String;", AccessFlags = 1)]
						public string LongMsg;
						/// <summary>
						///  <para>The stack trace where the error originated. May be null. </para>        
						/// </summary>
						/// <java-name>
						/// stackTrace
						/// </java-name>
						[Dot42.DexImport("stackTrace", "Ljava/lang/String;", AccessFlags = 1)]
						public string StackTrace;
						/// <summary>
						///  <para>to be deprecated: This value will always be null. </para>        
						/// </summary>
						/// <java-name>
						/// crashData
						/// </java-name>
						[Dot42.DexImport("crashData", "[B", AccessFlags = 1)]
						public sbyte[] CrashData;
						/// <java-name>
						/// CREATOR
						/// </java-name>
						[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
						public static readonly global::Android.OS.IParcelable_ICreator<ProcessErrorStateInfo> CREATOR;
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public ProcessErrorStateInfo() /* MethodBuilder.Create */ 
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

						/// <java-name>
						/// readFromParcel
						/// </java-name>
						[Dot42.DexImport("readFromParcel", "(Landroid/os/Parcel;)V", AccessFlags = 1)]
						public virtual void ReadFromParcel(global::Android.OS.Parcel source) /* MethodBuilder.Create */ 
						{
						}

				}

				/// <summary>
				///  <para>Information you can retrieve about the available memory through ActivityManager#getMemoryInfo. </para>    
				/// </summary>
				/// <java-name>
				/// android/app/ActivityManager$MemoryInfo
				/// </java-name>
				[Dot42.DexImport("android/app/ActivityManager$MemoryInfo", AccessFlags = 9)]
				public partial class MemoryInfo : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>The available memory on the system. This number should not be considered absolute: due to the nature of the kernel, a significant portion of this memory is actually in use and needed for the overall system to run well. </para>        
						/// </summary>
						/// <java-name>
						/// availMem
						/// </java-name>
						[Dot42.DexImport("availMem", "J", AccessFlags = 1)]
						public long AvailMem;
						/// <summary>
						///  <para>The total memory accessible by the kernel. This is basically the RAM size of the device, not including below-kernel fixed allocations like DMA buffers, RAM for the baseband CPU, etc. </para>        
						/// </summary>
						/// <java-name>
						/// totalMem
						/// </java-name>
						[Dot42.DexImport("totalMem", "J", AccessFlags = 1)]
						public long TotalMem;
						/// <summary>
						///  <para>The threshold of availMem at which we consider memory to be low and start killing background services and other non-extraneous processes. </para>        
						/// </summary>
						/// <java-name>
						/// threshold
						/// </java-name>
						[Dot42.DexImport("threshold", "J", AccessFlags = 1)]
						public long Threshold;
						/// <summary>
						///  <para>Set to true if the system considers itself to currently be in a low memory situation. </para>        
						/// </summary>
						/// <java-name>
						/// lowMemory
						/// </java-name>
						[Dot42.DexImport("lowMemory", "Z", AccessFlags = 1)]
						public bool LowMemory;
						/// <java-name>
						/// CREATOR
						/// </java-name>
						[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
						public static readonly global::Android.OS.IParcelable_ICreator<MemoryInfo> CREATOR;
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public MemoryInfo() /* MethodBuilder.Create */ 
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

						/// <java-name>
						/// readFromParcel
						/// </java-name>
						[Dot42.DexImport("readFromParcel", "(Landroid/os/Parcel;)V", AccessFlags = 1)]
						public virtual void ReadFromParcel(global::Android.OS.Parcel source) /* MethodBuilder.Create */ 
						{
						}

				}

				/// <summary>
				///  <para>Information you can retrieve about a particular Service that is currently running in the system. </para>    
				/// </summary>
				/// <java-name>
				/// android/app/ActivityManager$RunningServiceInfo
				/// </java-name>
				[Dot42.DexImport("android/app/ActivityManager$RunningServiceInfo", AccessFlags = 9)]
				public partial class RunningServiceInfo : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>The service component. </para>        
						/// </summary>
						/// <java-name>
						/// service
						/// </java-name>
						[Dot42.DexImport("service", "Landroid/content/ComponentName;", AccessFlags = 1)]
						public global::Android.Content.ComponentName Service;
						/// <summary>
						///  <para>If non-zero, this is the process the service is running in. </para>        
						/// </summary>
						/// <java-name>
						/// pid
						/// </java-name>
						[Dot42.DexImport("pid", "I", AccessFlags = 1)]
						public int Pid;
						/// <summary>
						///  <para>The UID that owns this service. </para>        
						/// </summary>
						/// <java-name>
						/// uid
						/// </java-name>
						[Dot42.DexImport("uid", "I", AccessFlags = 1)]
						public int Uid;
						/// <summary>
						///  <para>The name of the process this service runs in. </para>        
						/// </summary>
						/// <java-name>
						/// process
						/// </java-name>
						[Dot42.DexImport("process", "Ljava/lang/String;", AccessFlags = 1)]
						public string Process;
						/// <summary>
						///  <para>Set to true if the service has asked to run as a foreground process. </para>        
						/// </summary>
						/// <java-name>
						/// foreground
						/// </java-name>
						[Dot42.DexImport("foreground", "Z", AccessFlags = 1)]
						public bool Foreground;
						/// <summary>
						///  <para>The time when the service was first made active, either by someone starting or binding to it. This is in units of android.os.SystemClock#elapsedRealtime(). </para>        
						/// </summary>
						/// <java-name>
						/// activeSince
						/// </java-name>
						[Dot42.DexImport("activeSince", "J", AccessFlags = 1)]
						public long ActiveSince;
						/// <summary>
						///  <para>Set to true if this service has been explicitly started. </para>        
						/// </summary>
						/// <java-name>
						/// started
						/// </java-name>
						[Dot42.DexImport("started", "Z", AccessFlags = 1)]
						public bool Started;
						/// <summary>
						///  <para>Number of clients connected to the service. </para>        
						/// </summary>
						/// <java-name>
						/// clientCount
						/// </java-name>
						[Dot42.DexImport("clientCount", "I", AccessFlags = 1)]
						public int ClientCount;
						/// <summary>
						///  <para>Number of times the service's process has crashed while the service is running. </para>        
						/// </summary>
						/// <java-name>
						/// crashCount
						/// </java-name>
						[Dot42.DexImport("crashCount", "I", AccessFlags = 1)]
						public int CrashCount;
						/// <summary>
						///  <para>The time when there was last activity in the service (either explicit requests to start it or clients binding to it). This is in units of android.os.SystemClock#uptimeMillis(). </para>        
						/// </summary>
						/// <java-name>
						/// lastActivityTime
						/// </java-name>
						[Dot42.DexImport("lastActivityTime", "J", AccessFlags = 1)]
						public long LastActivityTime;
						/// <summary>
						///  <para>If non-zero, this service is not currently running, but scheduled to restart at the given time. </para>        
						/// </summary>
						/// <java-name>
						/// restarting
						/// </java-name>
						[Dot42.DexImport("restarting", "J", AccessFlags = 1)]
						public long Restarting;
						/// <summary>
						///  <para>Bit for flags: set if this service has been explicitly started. </para>        
						/// </summary>
						/// <java-name>
						/// FLAG_STARTED
						/// </java-name>
						[Dot42.DexImport("FLAG_STARTED", "I", AccessFlags = 25)]
						public const int FLAG_STARTED = 1;
						/// <summary>
						///  <para>Bit for flags: set if the service has asked to run as a foreground process. </para>        
						/// </summary>
						/// <java-name>
						/// FLAG_FOREGROUND
						/// </java-name>
						[Dot42.DexImport("FLAG_FOREGROUND", "I", AccessFlags = 25)]
						public const int FLAG_FOREGROUND = 2;
						/// <summary>
						///  <para>Bit for set if the service is running in a core system process. </para>        
						/// </summary>
						/// <java-name>
						/// FLAG_SYSTEM_PROCESS
						/// </java-name>
						[Dot42.DexImport("FLAG_SYSTEM_PROCESS", "I", AccessFlags = 25)]
						public const int FLAG_SYSTEM_PROCESS = 4;
						/// <summary>
						///  <para>Bit for set if the service is running in a persistent process. </para>        
						/// </summary>
						/// <java-name>
						/// FLAG_PERSISTENT_PROCESS
						/// </java-name>
						[Dot42.DexImport("FLAG_PERSISTENT_PROCESS", "I", AccessFlags = 25)]
						public const int FLAG_PERSISTENT_PROCESS = 8;
						/// <summary>
						///  <para>Running flags. </para>        
						/// </summary>
						/// <java-name>
						/// flags
						/// </java-name>
						[Dot42.DexImport("flags", "I", AccessFlags = 1)]
						public int Flags;
						/// <summary>
						///  <para>For special services that are bound to by system code, this is the package that holds the binding. </para>        
						/// </summary>
						/// <java-name>
						/// clientPackage
						/// </java-name>
						[Dot42.DexImport("clientPackage", "Ljava/lang/String;", AccessFlags = 1)]
						public string ClientPackage;
						/// <summary>
						///  <para>For special services that are bound to by system code, this is a string resource providing a user-visible label for who the client is. </para>        
						/// </summary>
						/// <java-name>
						/// clientLabel
						/// </java-name>
						[Dot42.DexImport("clientLabel", "I", AccessFlags = 1)]
						public int ClientLabel;
						/// <java-name>
						/// CREATOR
						/// </java-name>
						[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
						public static readonly global::Android.OS.IParcelable_ICreator<RunningServiceInfo> CREATOR;
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public RunningServiceInfo() /* MethodBuilder.Create */ 
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

						/// <java-name>
						/// readFromParcel
						/// </java-name>
						[Dot42.DexImport("readFromParcel", "(Landroid/os/Parcel;)V", AccessFlags = 1)]
						public virtual void ReadFromParcel(global::Android.OS.Parcel source) /* MethodBuilder.Create */ 
						{
						}

				}

				/// <summary>
				///  <para>Information you can retrieve about a particular task that is currently "running" in the system. Note that a running task does not mean the given task actually has a process it is actively running in; it simply means that the user has gone to it and never closed it, but currently the system may have killed its process and is only holding on to its last state in order to restart it when the user returns. </para>    
				/// </summary>
				/// <java-name>
				/// android/app/ActivityManager$RunningTaskInfo
				/// </java-name>
				[Dot42.DexImport("android/app/ActivityManager$RunningTaskInfo", AccessFlags = 9)]
				public partial class RunningTaskInfo : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>A unique identifier for this task. </para>        
						/// </summary>
						/// <java-name>
						/// id
						/// </java-name>
						[Dot42.DexImport("id", "I", AccessFlags = 1)]
						public int Id;
						/// <summary>
						///  <para>The component launched as the first activity in the task. This can be considered the "application" of this task. </para>        
						/// </summary>
						/// <java-name>
						/// baseActivity
						/// </java-name>
						[Dot42.DexImport("baseActivity", "Landroid/content/ComponentName;", AccessFlags = 1)]
						public global::Android.Content.ComponentName BaseActivity;
						/// <summary>
						///  <para>The activity component at the top of the history stack of the task. This is what the user is currently doing. </para>        
						/// </summary>
						/// <java-name>
						/// topActivity
						/// </java-name>
						[Dot42.DexImport("topActivity", "Landroid/content/ComponentName;", AccessFlags = 1)]
						public global::Android.Content.ComponentName TopActivity;
						/// <summary>
						///  <para>Thumbnail representation of the task's current state. Currently always null. </para>        
						/// </summary>
						/// <java-name>
						/// thumbnail
						/// </java-name>
						[Dot42.DexImport("thumbnail", "Landroid/graphics/Bitmap;", AccessFlags = 1)]
						public global::Android.Graphics.Bitmap Thumbnail;
						/// <summary>
						///  <para>Description of the task's current state. </para>        
						/// </summary>
						/// <java-name>
						/// description
						/// </java-name>
						[Dot42.DexImport("description", "Ljava/lang/CharSequence;", AccessFlags = 1)]
						public global::Java.Lang.ICharSequence Description;
						/// <summary>
						///  <para>Number of activities in this task. </para>        
						/// </summary>
						/// <java-name>
						/// numActivities
						/// </java-name>
						[Dot42.DexImport("numActivities", "I", AccessFlags = 1)]
						public int NumActivities;
						/// <summary>
						///  <para>Number of activities that are currently running (not stopped and persisted) in this task. </para>        
						/// </summary>
						/// <java-name>
						/// numRunning
						/// </java-name>
						[Dot42.DexImport("numRunning", "I", AccessFlags = 1)]
						public int NumRunning;
						/// <java-name>
						/// CREATOR
						/// </java-name>
						[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
						public static readonly global::Android.OS.IParcelable_ICreator<RunningTaskInfo> CREATOR;
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public RunningTaskInfo() /* MethodBuilder.Create */ 
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

						/// <java-name>
						/// readFromParcel
						/// </java-name>
						[Dot42.DexImport("readFromParcel", "(Landroid/os/Parcel;)V", AccessFlags = 1)]
						public virtual void ReadFromParcel(global::Android.OS.Parcel source) /* MethodBuilder.Create */ 
						{
						}

				}

				/// <summary>
				///  <para>Information you can retrieve about tasks that the user has most recently started or visited. </para>    
				/// </summary>
				/// <java-name>
				/// android/app/ActivityManager$RecentTaskInfo
				/// </java-name>
				[Dot42.DexImport("android/app/ActivityManager$RecentTaskInfo", AccessFlags = 9)]
				public partial class RecentTaskInfo : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>If this task is currently running, this is the identifier for it. If it is not running, this will be -1. </para>        
						/// </summary>
						/// <java-name>
						/// id
						/// </java-name>
						[Dot42.DexImport("id", "I", AccessFlags = 1)]
						public int Id;
						/// <summary>
						///  <para>The true identifier of this task, valid even if it is not running. </para>        
						/// </summary>
						/// <java-name>
						/// persistentId
						/// </java-name>
						[Dot42.DexImport("persistentId", "I", AccessFlags = 1)]
						public int PersistentId;
						/// <summary>
						///  <para>The original Intent used to launch the task. You can use this Intent to re-launch the task (if it is no longer running) or bring the current task to the front. </para>        
						/// </summary>
						/// <java-name>
						/// baseIntent
						/// </java-name>
						[Dot42.DexImport("baseIntent", "Landroid/content/Intent;", AccessFlags = 1)]
						public global::Android.Content.Intent BaseIntent;
						/// <summary>
						///  <para>If this task was started from an alias, this is the actual activity component that was initially started; the component of the baseIntent in this case is the name of the actual activity implementation that the alias referred to. Otherwise, this is null. </para>        
						/// </summary>
						/// <java-name>
						/// origActivity
						/// </java-name>
						[Dot42.DexImport("origActivity", "Landroid/content/ComponentName;", AccessFlags = 1)]
						public global::Android.Content.ComponentName OrigActivity;
						/// <summary>
						///  <para>Description of the task's last state. </para>        
						/// </summary>
						/// <java-name>
						/// description
						/// </java-name>
						[Dot42.DexImport("description", "Ljava/lang/CharSequence;", AccessFlags = 1)]
						public global::Java.Lang.ICharSequence Description;
						/// <java-name>
						/// CREATOR
						/// </java-name>
						[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
						public static readonly global::Android.OS.IParcelable_ICreator<RecentTaskInfo> CREATOR;
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public RecentTaskInfo() /* MethodBuilder.Create */ 
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

						/// <java-name>
						/// readFromParcel
						/// </java-name>
						[Dot42.DexImport("readFromParcel", "(Landroid/os/Parcel;)V", AccessFlags = 1)]
						public virtual void ReadFromParcel(global::Android.OS.Parcel source) /* MethodBuilder.Create */ 
						{
						}

				}

		}

		/// <summary>
		///  <para>Helper class for building an options Bundle that can be used with Context.startActivity(Intent, Bundle) and related methods. </para>    
		/// </summary>
		/// <java-name>
		/// android/app/ActivityOptions
		/// </java-name>
		[Dot42.DexImport("android/app/ActivityOptions", AccessFlags = 33)]
		public partial class ActivityOptions
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal ActivityOptions() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Create an ActivityOptions specifying a custom animation to run when the activity is displayed.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns a new ActivityOptions object that you can use to supply these options as the options Bundle when starting an activity. </para>
				/// </returns>
				/// <java-name>
				/// makeCustomAnimation
				/// </java-name>
				[Dot42.DexImport("makeCustomAnimation", "(Landroid/content/Context;II)Landroid/app/ActivityOptions;", AccessFlags = 9)]
				public static global::Android.App.ActivityOptions MakeCustomAnimation(global::Android.Content.Context context, int enterResId, int exitResId) /* MethodBuilder.Create */ 
				{
						return default(global::Android.App.ActivityOptions);
				}

				/// <summary>
				///  <para>Create an ActivityOptions specifying an animation where the new activity is scaled from a small originating area of the screen to its final full representation.</para> <para>If the Intent this is being used with has not set its Intent.setSourceBounds, those bounds will be filled in for you based on the initial bounds passed in here.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns a new ActivityOptions object that you can use to supply these options as the options Bundle when starting an activity. </para>
				/// </returns>
				/// <java-name>
				/// makeScaleUpAnimation
				/// </java-name>
				[Dot42.DexImport("makeScaleUpAnimation", "(Landroid/view/View;IIII)Landroid/app/ActivityOptions;", AccessFlags = 9)]
				public static global::Android.App.ActivityOptions MakeScaleUpAnimation(global::Android.Views.View source, int startX, int startY, int startWidth, int startHeight) /* MethodBuilder.Create */ 
				{
						return default(global::Android.App.ActivityOptions);
				}

				/// <summary>
				///  <para>Create an ActivityOptions specifying an animation where a thumbnail is scaled from a given position to the new activity window that is being started.</para> <para>If the Intent this is being used with has not set its Intent.setSourceBounds, those bounds will be filled in for you based on the initial thumbnail location and size provided here.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns a new ActivityOptions object that you can use to supply these options as the options Bundle when starting an activity. </para>
				/// </returns>
				/// <java-name>
				/// makeThumbnailScaleUpAnimation
				/// </java-name>
				[Dot42.DexImport("makeThumbnailScaleUpAnimation", "(Landroid/view/View;Landroid/graphics/Bitmap;II)Landroid/app/ActivityOptions;", AccessFlags = 9)]
				public static global::Android.App.ActivityOptions MakeThumbnailScaleUpAnimation(global::Android.Views.View source, global::Android.Graphics.Bitmap thumbnail, int startX, int startY) /* MethodBuilder.Create */ 
				{
						return default(global::Android.App.ActivityOptions);
				}

				/// <summary>
				///  <para>Update the current values in this ActivityOptions from those supplied in  <b>otherOptions</b>. Any values defined in  <b>otherOptions</b> replace those in the base options. </para>        
				/// </summary>
				/// <java-name>
				/// update
				/// </java-name>
				[Dot42.DexImport("update", "(Landroid/app/ActivityOptions;)V", AccessFlags = 1)]
				public virtual void Update(global::Android.App.ActivityOptions otherOptions) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns the created options as a Bundle, which can be passed to Context.startActivity(Intent, Bundle) and related methods. Note that the returned Bundle is still owned by the ActivityOptions object; you must not modify it, but can supply it to the startActivity methods that take an options Bundle. </para>        
				/// </summary>
				/// <java-name>
				/// toBundle
				/// </java-name>
				[Dot42.DexImport("toBundle", "()Landroid/os/Bundle;", AccessFlags = 1)]
				public virtual global::Android.OS.Bundle ToBundle() /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.Bundle);
				}

		}

		/// <summary>
		///  <para>This class provides access to the system alarm services. These allow you to schedule your application to be run at some point in the future. When an alarm goes off, the Intent that had been registered for it is broadcast by the system, automatically starting the target application if it is not already running. Registered alarms are retained while the device is asleep (and can optionally wake the device up if they go off during that time), but will be cleared if it is turned off and rebooted.</para> <para>The Alarm Manager holds a CPU wake lock as long as the alarm receiver's onReceive() method is executing. This guarantees that the phone will not sleep until you have finished handling the broadcast. Once onReceive() returns, the Alarm Manager releases this wake lock. This means that the phone will in some cases sleep as soon as your onReceive() method completes. If your alarm receiver called Context.startService(), it is possible that the phone will sleep before the requested service is launched. To prevent this, your BroadcastReceiver and Service will need to implement a separate wake lock policy to ensure that the phone continues running until the service becomes available.</para> <para> <b>Note: The Alarm Manager is intended for cases where you want to have your application code run at a specific time, even if your application is not currently running. For normal timing operations (ticks, timeouts, etc) it is easier and much more efficient to use android.os.Handler.</b></para> <para> <b>Note:</b> Beginning with API 19 (android.os.Build.VERSION_CODES#KITKAT) alarm delivery is inexact: the OS will shift alarms in order to minimize wakeups and battery use. There are new APIs to support applications which need strict delivery guarantees; see setWindow(int, long, long, PendingIntent) and setExact(int, long, PendingIntent). Applications whose <c>targetSdkVersion </c> is earlier than API 19 will continue to see the previous behavior in which all alarms are delivered exactly when requested.</para> <para>You do not instantiate this class directly; instead, retrieve it through Context.getSystemService(Context.ALARM_SERVICE). </para>    
		/// </summary>
		/// <java-name>
		/// android/app/AlarmManager
		/// </java-name>
		[Dot42.DexImport("android/app/AlarmManager", AccessFlags = 33)]
		public partial class AlarmManager
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Alarm time in System.currentTimeMillis() (wall clock time in UTC), which will wake up the device when it goes off. </para>        
				/// </summary>
				/// <java-name>
				/// RTC_WAKEUP
				/// </java-name>
				[Dot42.DexImport("RTC_WAKEUP", "I", AccessFlags = 25)]
				public const int RTC_WAKEUP = 0;
				/// <summary>
				///  <para>Alarm time in System.currentTimeMillis() (wall clock time in UTC). This alarm does not wake the device up; if it goes off while the device is asleep, it will not be delivered until the next time the device wakes up. </para>        
				/// </summary>
				/// <java-name>
				/// RTC
				/// </java-name>
				[Dot42.DexImport("RTC", "I", AccessFlags = 25)]
				public const int RTC = 1;
				/// <summary>
				///  <para>Alarm time in SystemClock.elapsedRealtime() (time since boot, including sleep), which will wake up the device when it goes off. </para>        
				/// </summary>
				/// <java-name>
				/// ELAPSED_REALTIME_WAKEUP
				/// </java-name>
				[Dot42.DexImport("ELAPSED_REALTIME_WAKEUP", "I", AccessFlags = 25)]
				public const int ELAPSED_REALTIME_WAKEUP = 2;
				/// <summary>
				///  <para>Alarm time in SystemClock.elapsedRealtime() (time since boot, including sleep). This alarm does not wake the device up; if it goes off while the device is asleep, it will not be delivered until the next time the device wakes up. </para>        
				/// </summary>
				/// <java-name>
				/// ELAPSED_REALTIME
				/// </java-name>
				[Dot42.DexImport("ELAPSED_REALTIME", "I", AccessFlags = 25)]
				public const int ELAPSED_REALTIME = 3;
				/// <summary>
				///  <para>Available inexact recurrence interval recognized by setInexactRepeating(int, long, long, PendingIntent) when running on Android prior to API 19. </para>        
				/// </summary>
				/// <java-name>
				/// INTERVAL_FIFTEEN_MINUTES
				/// </java-name>
				[Dot42.DexImport("INTERVAL_FIFTEEN_MINUTES", "J", AccessFlags = 25)]
				public const long INTERVAL_FIFTEEN_MINUTES = 900000;
				/// <summary>
				///  <para>Available inexact recurrence interval recognized by setInexactRepeating(int, long, long, PendingIntent) when running on Android prior to API 19. </para>        
				/// </summary>
				/// <java-name>
				/// INTERVAL_HALF_HOUR
				/// </java-name>
				[Dot42.DexImport("INTERVAL_HALF_HOUR", "J", AccessFlags = 25)]
				public const long INTERVAL_HALF_HOUR = 1800000;
				/// <summary>
				///  <para>Available inexact recurrence interval recognized by setInexactRepeating(int, long, long, PendingIntent) when running on Android prior to API 19. </para>        
				/// </summary>
				/// <java-name>
				/// INTERVAL_HOUR
				/// </java-name>
				[Dot42.DexImport("INTERVAL_HOUR", "J", AccessFlags = 25)]
				public const long INTERVAL_HOUR = 3600000;
				/// <summary>
				///  <para>Available inexact recurrence interval recognized by setInexactRepeating(int, long, long, PendingIntent) when running on Android prior to API 19. </para>        
				/// </summary>
				/// <java-name>
				/// INTERVAL_HALF_DAY
				/// </java-name>
				[Dot42.DexImport("INTERVAL_HALF_DAY", "J", AccessFlags = 25)]
				public const long INTERVAL_HALF_DAY = 43200000;
				/// <summary>
				///  <para>Available inexact recurrence interval recognized by setInexactRepeating(int, long, long, PendingIntent) when running on Android prior to API 19. </para>        
				/// </summary>
				/// <java-name>
				/// INTERVAL_DAY
				/// </java-name>
				[Dot42.DexImport("INTERVAL_DAY", "J", AccessFlags = 25)]
				public const long INTERVAL_DAY = 86400000;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal AlarmManager() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Schedule an alarm.  <b>Note: for timing operations (ticks, timeouts, etc) it is easier and much more efficient to use android.os.Handler.</b> If there is already an alarm scheduled for the same IntentSender, that previous alarm will first be canceled.</para> <para>If the stated trigger time is in the past, the alarm will be triggered immediately. If there is already an alarm for this Intent scheduled (with the equality of two intents being defined by Intent#filterEquals), then it will be removed and replaced by this one.</para> <para>The alarm is an Intent broadcast that goes to a broadcast receiver that you registered with android.content.Context#registerReceiver or through the &lt;receiver&gt; tag in an AndroidManifest.xml file.</para> <para>Alarm intents are delivered with a data extra of type int called Intent.EXTRA_ALARM_COUNT that indicates how many past alarm events have been accumulated into this intent broadcast. Recurring alarms that have gone undelivered because the phone was asleep may have a count greater than one when delivered.</para> <para> </para> <para>  <b>Note:</b> Beginning in API 19, the trigger time passed to this method is treated as inexact: the alarm will not be delivered before this time, but may be deferred and delivered some time later. The OS will use this policy in order to "batch" alarms together across the entire system, minimizing the number of times the device needs to "wake up" and minimizing battery use. In general, alarms scheduled in the near future will not be deferred as long as alarms scheduled far in the future.</para> <para></para> <para> With the new batching policy, delivery ordering guarantees are not as strong as they were previously. If the application sets multiple alarms, it is possible that these alarms'  <b>actual</b> delivery ordering may not match the order of their  <b>requested</b> delivery times. If your application has strong ordering requirements there are other APIs that you can use to get the necessary behavior; see setWindow(int, long, long, PendingIntent) and setExact(int, long, PendingIntent).</para> <para></para> <para> Applications whose <c>targetSdkVersion </c> is before API 19 will continue to get the previous alarm behavior: all of their scheduled alarms will be treated as exact. </para> <para> <para>android.os.Handler </para> <para>setExact </para> <para>setRepeating </para> <para>setWindow </para> <para>cancel </para> <para>android.content.Context::sendBroadcast </para> <para>android.content.Context::registerReceiver </para> <para>android.content.Intent::filterEquals </para> <para>ELAPSED_REALTIME </para> <para>ELAPSED_REALTIME_WAKEUP </para> <para>RTC </para> <para>RTC_WAKEUP </para></para>        
				/// </summary>
				/// <java-name>
				/// set
				/// </java-name>
				[Dot42.DexImport("set", "(IJLandroid/app/PendingIntent;)V", AccessFlags = 1)]
				public virtual void Set(int type, long triggerAtMillis, global::Android.App.PendingIntent operation) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Schedule a repeating alarm.  <b>Note: for timing operations (ticks, timeouts, etc) it is easier and much more efficient to use android.os.Handler.</b> If there is already an alarm scheduled for the same IntentSender, it will first be canceled.</para> <para>Like set, except you can also supply a period at which the alarm will automatically repeat. This alarm continues repeating until explicitly removed with cancel. If the stated trigger time is in the past, the alarm will be triggered immediately, with an alarm count depending on how far in the past the trigger time is relative to the repeat interval.</para> <para>If an alarm is delayed (by system sleep, for example, for non _WAKEUP alarm types), a skipped repeat will be delivered as soon as possible. After that, future alarms will be delivered according to the original schedule; they do not drift over time. For example, if you have set a recurring alarm for the top of every hour but the phone was asleep from 7:45 until 8:45, an alarm will be sent as soon as the phone awakens, then the next alarm will be sent at 9:00.</para> <para>If your application wants to allow the delivery times to drift in order to guarantee that at least a certain time interval always elapses between alarms, then the approach to take is to use one-time alarms, scheduling the next one yourself when handling each alarm delivery.</para> <para> <b>Note:</b> as of API 19, all repeating alarms are inexact. If your application needs precise delivery times then it must use one-time exact alarms, rescheduling each time as described above. Legacy applications whose <c>targetSdkVersion </c> is earlier than API 19 will continue to have all of their alarms, including repeating alarms, treated as exact.</para> <para> <para>android.os.Handler </para> <para>set </para> <para>setExact </para> <para>setWindow </para> <para>cancel </para> <para>android.content.Context::sendBroadcast </para> <para>android.content.Context::registerReceiver </para> <para>android.content.Intent::filterEquals </para> <para>ELAPSED_REALTIME </para> <para>ELAPSED_REALTIME_WAKEUP </para> <para>RTC </para> <para>RTC_WAKEUP </para></para>        
				/// </summary>
				/// <java-name>
				/// setRepeating
				/// </java-name>
				[Dot42.DexImport("setRepeating", "(IJJLandroid/app/PendingIntent;)V", AccessFlags = 1)]
				public virtual void SetRepeating(int type, long triggerAtMillis, long intervalMillis, global::Android.App.PendingIntent operation) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Schedule a repeating alarm that has inexact trigger time requirements; for example, an alarm that repeats every hour, but not necessarily at the top of every hour. These alarms are more power-efficient than the strict recurrences traditionally supplied by setRepeating, since the system can adjust alarms' delivery times to cause them to fire simultaneously, avoiding waking the device from sleep more than necessary.</para> <para>Your alarm's first trigger will not be before the requested time, but it might not occur for almost a full interval after that time. In addition, while the overall period of the repeating alarm will be as requested, the time between any two successive firings of the alarm may vary. If your application demands very low jitter, use one-shot alarms with an appropriate window instead; see setWindow(int, long, long, PendingIntent) and setExact(int, long, PendingIntent).</para> <para>As of API 19, all repeating alarms are inexact. Because this method has been available since API 3, your application can safely call it and be assured that it will get similar behavior on both current and older versions of Android.</para> <para> <para>android.os.Handler </para> <para>set </para> <para>cancel </para> <para>android.content.Context::sendBroadcast </para> <para>android.content.Context::registerReceiver </para> <para>android.content.Intent::filterEquals </para> <para>ELAPSED_REALTIME </para> <para>ELAPSED_REALTIME_WAKEUP </para> <para>RTC </para> <para>RTC_WAKEUP </para> <para>INTERVAL_FIFTEEN_MINUTES </para> <para>INTERVAL_HALF_HOUR </para> <para>INTERVAL_HOUR </para> <para>INTERVAL_HALF_DAY </para> <para>INTERVAL_DAY </para></para>        
				/// </summary>
				/// <java-name>
				/// setInexactRepeating
				/// </java-name>
				[Dot42.DexImport("setInexactRepeating", "(IJJLandroid/app/PendingIntent;)V", AccessFlags = 1)]
				public virtual void SetInexactRepeating(int type, long triggerAtMillis, long intervalMillis, global::Android.App.PendingIntent operation) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Remove any alarms with a matching Intent. Any alarm, of any type, whose Intent matches this one (as defined by Intent#filterEquals), will be canceled.</para> <para> <para>set </para></para>        
				/// </summary>
				/// <java-name>
				/// cancel
				/// </java-name>
				[Dot42.DexImport("cancel", "(Landroid/app/PendingIntent;)V", AccessFlags = 1)]
				public virtual void Cancel(global::Android.App.PendingIntent operation) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Set the system wall clock time. Requires the permission android.permission.SET_TIME.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setTime
				/// </java-name>
				[Dot42.DexImport("setTime", "(J)V", AccessFlags = 1)]
				public virtual void SetTime(long millis) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Set the system default time zone. Requires the permission android.permission.SET_TIME_ZONE.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setTimeZone
				/// </java-name>
				[Dot42.DexImport("setTimeZone", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetTimeZone(string timeZone) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>A subclass of Dialog that can display one, two or three buttons. If you only want to display a String in this dialog box, use the setMessage() method. If you want to display a more complex view, look up the FrameLayout called "custom" and add your view to it:</para> <para> <pre>
		/// FrameLayout fl = (FrameLayout) findViewById(android.R.id.custom);
		/// fl.addView(myView, new LayoutParams(MATCH_PARENT, WRAP_CONTENT));
		/// </pre></para> <para>The AlertDialog class takes care of automatically setting WindowManager.LayoutParams.FLAG_ALT_FOCUSABLE_IM for you based on whether any views in the dialog return true from View.onCheckIsTextEditor(). Generally you want this set for a Dialog without text editors, so that it will be placed on top of the current input method UI. You can modify this behavior by forcing the flag to your desired mode after calling onCreate.</para> <para>  <h3>Developer Guides</h3></para> <para> </para> <para>For more information about creating dialogs, read the  developer guide.</para> <para>  </para>    
		/// </summary>
		/// <java-name>
		/// android/app/AlertDialog
		/// </java-name>
		[Dot42.DexImport("android/app/AlertDialog", AccessFlags = 33)]
		public partial class AlertDialog : global::Android.App.Dialog, global::Android.Content.IDialogInterface
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Special theme constant for AlertDialog(Context, int): use the traditional (pre-Holo) alert dialog theme. </para>        
				/// </summary>
				/// <java-name>
				/// THEME_TRADITIONAL
				/// </java-name>
				[Dot42.DexImport("THEME_TRADITIONAL", "I", AccessFlags = 25)]
				public const int THEME_TRADITIONAL = 1;
				/// <summary>
				///  <para>Special theme constant for AlertDialog(Context, int): use the holographic alert theme with a dark background. </para>        
				/// </summary>
				/// <java-name>
				/// THEME_HOLO_DARK
				/// </java-name>
				[Dot42.DexImport("THEME_HOLO_DARK", "I", AccessFlags = 25)]
				public const int THEME_HOLO_DARK = 2;
				/// <summary>
				///  <para>Special theme constant for AlertDialog(Context, int): use the holographic alert theme with a light background. </para>        
				/// </summary>
				/// <java-name>
				/// THEME_HOLO_LIGHT
				/// </java-name>
				[Dot42.DexImport("THEME_HOLO_LIGHT", "I", AccessFlags = 25)]
				public const int THEME_HOLO_LIGHT = 3;
				/// <summary>
				///  <para>Special theme constant for AlertDialog(Context, int): use the device's default alert theme with a dark background. </para>        
				/// </summary>
				/// <java-name>
				/// THEME_DEVICE_DEFAULT_DARK
				/// </java-name>
				[Dot42.DexImport("THEME_DEVICE_DEFAULT_DARK", "I", AccessFlags = 25)]
				public const int THEME_DEVICE_DEFAULT_DARK = 4;
				/// <summary>
				///  <para>Special theme constant for AlertDialog(Context, int): use the device's default alert theme with a light background. </para>        
				/// </summary>
				/// <java-name>
				/// THEME_DEVICE_DEFAULT_LIGHT
				/// </java-name>
				[Dot42.DexImport("THEME_DEVICE_DEFAULT_LIGHT", "I", AccessFlags = 25)]
				public const int THEME_DEVICE_DEFAULT_LIGHT = 5;
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 4)]
				protected internal AlertDialog(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Construct an AlertDialog that uses an explicit theme. The actual style that an AlertDialog uses is a private implementation, however you can here supply either the name of an attribute in the theme from which to get the dialog's style (such as android.R.attr#alertDialogTheme or one of the constants THEME_TRADITIONAL, THEME_HOLO_DARK, or THEME_HOLO_LIGHT. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;I)V", AccessFlags = 4)]
				protected internal AlertDialog(global::Android.Content.Context context, int theme) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;ZLandroid/content/DialogInterface$OnCancelListener;)V", AccessFlags = 4)]
				protected internal AlertDialog(global::Android.Content.Context context, bool boolean, global::Android.Content.IDialogInterface_IOnCancelListener dialogInterface_IOnCancelListener) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Gets one of the buttons used in the dialog. </para> <para>If a button does not exist in the dialog, null will be returned.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The button from the dialog, or null if a button does not exist. </para>
				/// </returns>
				/// <java-name>
				/// getButton
				/// </java-name>
				[Dot42.DexImport("getButton", "(I)Landroid/widget/Button;", AccessFlags = 1)]
				public virtual global::Android.Widget.Button GetButton(int whichButton) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Widget.Button);
				}

				/// <java-name>
				/// setTitle
				/// </java-name>
				[Dot42.DexImport("setTitle", "(Ljava/lang/CharSequence;)V", AccessFlags = 1)]
				public override void SetTitle(global::Java.Lang.ICharSequence title) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para> <para>Builder::setCustomTitle(View) </para></para>        
				/// </summary>
				/// <java-name>
				/// setCustomTitle
				/// </java-name>
				[Dot42.DexImport("setCustomTitle", "(Landroid/view/View;)V", AccessFlags = 1)]
				public virtual void SetCustomTitle(global::Android.Views.View customTitleView) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setMessage
				/// </java-name>
				[Dot42.DexImport("setMessage", "(Ljava/lang/CharSequence;)V", AccessFlags = 1)]
				public virtual void SetMessage(global::Java.Lang.ICharSequence message) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Set the view to display in that dialog. </para>        
				/// </summary>
				/// <java-name>
				/// setView
				/// </java-name>
				[Dot42.DexImport("setView", "(Landroid/view/View;)V", AccessFlags = 1)]
				public virtual void SetView(global::Android.Views.View view) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Set the view to display in that dialog, specifying the spacing to appear around that view.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setView
				/// </java-name>
				[Dot42.DexImport("setView", "(Landroid/view/View;IIII)V", AccessFlags = 1)]
				public virtual void SetView(global::Android.Views.View view, int viewSpacingLeft, int viewSpacingTop, int viewSpacingRight, int viewSpacingBottom) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setButton
				/// </java-name>
				[Dot42.DexImport("setButton", "(ILjava/lang/CharSequence;Landroid/os/Message;)V", AccessFlags = 1)]
				public virtual void SetButton(int int32, global::Java.Lang.ICharSequence charSequence, global::Android.OS.Message message) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setButton
				/// </java-name>
				[Dot42.DexImport("setButton", "(ILjava/lang/CharSequence;Landroid/content/DialogInterface$OnClickListener;)V", AccessFlags = 1)]
				public virtual void SetButton(int int32, global::Java.Lang.ICharSequence charSequence, global::Android.Content.IDialogInterface_IOnClickListener dialogInterface_IOnClickListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setButton
				/// </java-name>
				[Dot42.DexImport("setButton", "(Ljava/lang/CharSequence;Landroid/os/Message;)V", AccessFlags = 1)]
				public virtual void SetButton(global::Java.Lang.ICharSequence charSequence, global::Android.OS.Message message) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setButton2
				/// </java-name>
				[Dot42.DexImport("setButton2", "(Ljava/lang/CharSequence;Landroid/os/Message;)V", AccessFlags = 1)]
				public virtual void SetButton2(global::Java.Lang.ICharSequence charSequence, global::Android.OS.Message message) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setButton3
				/// </java-name>
				[Dot42.DexImport("setButton3", "(Ljava/lang/CharSequence;Landroid/os/Message;)V", AccessFlags = 1)]
				public virtual void SetButton3(global::Java.Lang.ICharSequence charSequence, global::Android.OS.Message message) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setButton
				/// </java-name>
				[Dot42.DexImport("setButton", "(Ljava/lang/CharSequence;Landroid/content/DialogInterface$OnClickListener;)V", AccessFlags = 1)]
				public virtual void SetButton(global::Java.Lang.ICharSequence charSequence, global::Android.Content.IDialogInterface_IOnClickListener dialogInterface_IOnClickListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setButton2
				/// </java-name>
				[Dot42.DexImport("setButton2", "(Ljava/lang/CharSequence;Landroid/content/DialogInterface$OnClickListener;)V", AccessFlags = 1)]
				public virtual void SetButton2(global::Java.Lang.ICharSequence charSequence, global::Android.Content.IDialogInterface_IOnClickListener dialogInterface_IOnClickListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setButton3
				/// </java-name>
				[Dot42.DexImport("setButton3", "(Ljava/lang/CharSequence;Landroid/content/DialogInterface$OnClickListener;)V", AccessFlags = 1)]
				public virtual void SetButton3(global::Java.Lang.ICharSequence charSequence, global::Android.Content.IDialogInterface_IOnClickListener dialogInterface_IOnClickListener) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Set resId to 0 if you don't want an icon. </para>        
				/// </summary>
				/// <java-name>
				/// setIcon
				/// </java-name>
				[Dot42.DexImport("setIcon", "(I)V", AccessFlags = 1)]
				public virtual void SetIcon(int resId) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Set resId to 0 if you don't want an icon. </para>        
				/// </summary>
				/// <java-name>
				/// setIcon
				/// </java-name>
				[Dot42.DexImport("setIcon", "(Landroid/graphics/drawable/Drawable;)V", AccessFlags = 1)]
				public virtual void SetIcon(global::Android.Graphics.Drawables.Drawable resId) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Set an icon as supplied by a theme attribute. e.g. android.R.attr.alertDialogIcon</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setIconAttribute
				/// </java-name>
				[Dot42.DexImport("setIconAttribute", "(I)V", AccessFlags = 1)]
				public virtual void SetIconAttribute(int attrId) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setInverseBackgroundForced
				/// </java-name>
				[Dot42.DexImport("setInverseBackgroundForced", "(Z)V", AccessFlags = 1)]
				public virtual void SetInverseBackgroundForced(bool forceInverseBackground) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onCreate
				/// </java-name>
				[Dot42.DexImport("onCreate", "(Landroid/os/Bundle;)V", AccessFlags = 4)]
				protected internal override void OnCreate(global::Android.OS.Bundle savedInstanceState) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Called when a key down event has occurred. If you return true, you can first call KeyEvent.startTracking() to have the framework track the event through its onKeyUp(int, KeyEvent) and also call your onKeyLongPress(int, KeyEvent) if it occurs.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>If you handled the event, return true. If you want to allow the event to be handled by the next receiver, return false. </para>
				/// </returns>
				/// <java-name>
				/// onKeyDown
				/// </java-name>
				[Dot42.DexImport("onKeyDown", "(ILandroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public override bool OnKeyDown(int keyCode, global::Android.Views.KeyEvent @event) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Called when a key up event has occurred.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>If you handled the event, return true. If you want to allow the event to be handled by the next receiver, return false. </para>
				/// </returns>
				/// <java-name>
				/// onKeyUp
				/// </java-name>
				[Dot42.DexImport("onKeyUp", "(ILandroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public override bool OnKeyUp(int keyCode, global::Android.Views.KeyEvent @event) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal AlertDialog() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				[Dot42.DexImport("android/content/DialogInterface", "cancel", "()V", AccessFlags = 1025)]
				public override void Cancel() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("android/content/DialogInterface", "dismiss", "()V", AccessFlags = 1025)]
				public override void Dismiss() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				/// <summary>
				///  <para>Gets the list view used in the dialog.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The ListView from the dialog. </para>
				/// </returns>
				/// <java-name>
				/// getListView
				/// </java-name>
				public virtual global::Android.Widget.ListView ListView
				{
						[Dot42.DexImport("getListView", "()Landroid/widget/ListView;", AccessFlags = 1)]
						get{ return default(global::Android.Widget.ListView); }
				}

				/// <java-name>
				/// android/app/AlertDialog$Builder
				/// </java-name>
				[Dot42.DexImport("android/app/AlertDialog$Builder", AccessFlags = 9)]
				public partial class Builder
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
						public Builder(global::Android.Content.Context context) /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "(Landroid/content/Context;I)V", AccessFlags = 1)]
						public Builder(global::Android.Content.Context context, int int32) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Set the title using the given resource id.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>This Builder object to allow for chaining of calls to set methods </para>
						/// </returns>
						/// <java-name>
						/// setTitle
						/// </java-name>
						[Dot42.DexImport("setTitle", "(I)Landroid/app/AlertDialog$Builder;", AccessFlags = 1)]
						public virtual Builder SetTitle(int titleId) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <summary>
						///  <para>Set the title using the given resource id.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>This Builder object to allow for chaining of calls to set methods </para>
						/// </returns>
						/// <java-name>
						/// setTitle
						/// </java-name>
						[Dot42.DexImport("setTitle", "(Ljava/lang/CharSequence;)Landroid/app/AlertDialog$Builder;", AccessFlags = 1)]
						public virtual Builder SetTitle(global::Java.Lang.ICharSequence titleId) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <summary>
						///  <para>Set the title using the custom view <c>customTitleView </c> . The methods setTitle(int) and setIcon(int) should be sufficient for most titles, but this is provided if the title needs more customization. Using this will replace the title and icon set via the other methods.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>This Builder object to allow for chaining of calls to set methods </para>
						/// </returns>
						/// <java-name>
						/// setCustomTitle
						/// </java-name>
						[Dot42.DexImport("setCustomTitle", "(Landroid/view/View;)Landroid/app/AlertDialog$Builder;", AccessFlags = 1)]
						public virtual Builder SetCustomTitle(global::Android.Views.View customTitleView) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <summary>
						///  <para>Set the message to display using the given resource id.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>This Builder object to allow for chaining of calls to set methods </para>
						/// </returns>
						/// <java-name>
						/// setMessage
						/// </java-name>
						[Dot42.DexImport("setMessage", "(I)Landroid/app/AlertDialog$Builder;", AccessFlags = 1)]
						public virtual Builder SetMessage(int messageId) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <summary>
						///  <para>Set the message to display using the given resource id.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>This Builder object to allow for chaining of calls to set methods </para>
						/// </returns>
						/// <java-name>
						/// setMessage
						/// </java-name>
						[Dot42.DexImport("setMessage", "(Ljava/lang/CharSequence;)Landroid/app/AlertDialog$Builder;", AccessFlags = 1)]
						public virtual Builder SetMessage(global::Java.Lang.ICharSequence messageId) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <summary>
						///  <para>Set the resource id of the Drawable to be used in the title.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>This Builder object to allow for chaining of calls to set methods </para>
						/// </returns>
						/// <java-name>
						/// setIcon
						/// </java-name>
						[Dot42.DexImport("setIcon", "(I)Landroid/app/AlertDialog$Builder;", AccessFlags = 1)]
						public virtual Builder SetIcon(int iconId) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <summary>
						///  <para>Set the resource id of the Drawable to be used in the title.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>This Builder object to allow for chaining of calls to set methods </para>
						/// </returns>
						/// <java-name>
						/// setIcon
						/// </java-name>
						[Dot42.DexImport("setIcon", "(Landroid/graphics/drawable/Drawable;)Landroid/app/AlertDialog$Builder;", AccessFlags = 1)]
						public virtual Builder SetIcon(global::Android.Graphics.Drawables.Drawable iconId) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <summary>
						///  <para>Set an icon as supplied by a theme attribute. e.g. android.R.attr.alertDialogIcon</para> <para></para>        
						/// </summary>
						/// <java-name>
						/// setIconAttribute
						/// </java-name>
						[Dot42.DexImport("setIconAttribute", "(I)Landroid/app/AlertDialog$Builder;", AccessFlags = 1)]
						public virtual Builder SetIconAttribute(int attrId) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <summary>
						///  <para>Set a listener to be invoked when the positive button of the dialog is pressed. </para>        
						/// </summary>
						/// <returns>
						///  <para>This Builder object to allow for chaining of calls to set methods </para>
						/// </returns>
						/// <java-name>
						/// setPositiveButton
						/// </java-name>
						[Dot42.DexImport("setPositiveButton", "(ILandroid/content/DialogInterface$OnClickListener;)Landroid/app/AlertDialog$Buil" +
    "der;", AccessFlags = 1)]
						public virtual Builder SetPositiveButton(int textId, global::Android.Content.IDialogInterface_IOnClickListener listener) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <summary>
						///  <para>Set a listener to be invoked when the positive button of the dialog is pressed. </para>        
						/// </summary>
						/// <returns>
						///  <para>This Builder object to allow for chaining of calls to set methods </para>
						/// </returns>
						/// <java-name>
						/// setPositiveButton
						/// </java-name>
						[Dot42.DexImport("setPositiveButton", "(Ljava/lang/CharSequence;Landroid/content/DialogInterface$OnClickListener;)Landro" +
    "id/app/AlertDialog$Builder;", AccessFlags = 1)]
						public virtual Builder SetPositiveButton(global::Java.Lang.ICharSequence textId, global::Android.Content.IDialogInterface_IOnClickListener listener) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <summary>
						///  <para>Set a listener to be invoked when the negative button of the dialog is pressed. </para>        
						/// </summary>
						/// <returns>
						///  <para>This Builder object to allow for chaining of calls to set methods </para>
						/// </returns>
						/// <java-name>
						/// setNegativeButton
						/// </java-name>
						[Dot42.DexImport("setNegativeButton", "(ILandroid/content/DialogInterface$OnClickListener;)Landroid/app/AlertDialog$Buil" +
    "der;", AccessFlags = 1)]
						public virtual Builder SetNegativeButton(int textId, global::Android.Content.IDialogInterface_IOnClickListener listener) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <summary>
						///  <para>Set a listener to be invoked when the negative button of the dialog is pressed. </para>        
						/// </summary>
						/// <returns>
						///  <para>This Builder object to allow for chaining of calls to set methods </para>
						/// </returns>
						/// <java-name>
						/// setNegativeButton
						/// </java-name>
						[Dot42.DexImport("setNegativeButton", "(Ljava/lang/CharSequence;Landroid/content/DialogInterface$OnClickListener;)Landro" +
    "id/app/AlertDialog$Builder;", AccessFlags = 1)]
						public virtual Builder SetNegativeButton(global::Java.Lang.ICharSequence textId, global::Android.Content.IDialogInterface_IOnClickListener listener) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <summary>
						///  <para>Set a listener to be invoked when the neutral button of the dialog is pressed. </para>        
						/// </summary>
						/// <returns>
						///  <para>This Builder object to allow for chaining of calls to set methods </para>
						/// </returns>
						/// <java-name>
						/// setNeutralButton
						/// </java-name>
						[Dot42.DexImport("setNeutralButton", "(ILandroid/content/DialogInterface$OnClickListener;)Landroid/app/AlertDialog$Buil" +
    "der;", AccessFlags = 1)]
						public virtual Builder SetNeutralButton(int textId, global::Android.Content.IDialogInterface_IOnClickListener listener) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <summary>
						///  <para>Set a listener to be invoked when the neutral button of the dialog is pressed. </para>        
						/// </summary>
						/// <returns>
						///  <para>This Builder object to allow for chaining of calls to set methods </para>
						/// </returns>
						/// <java-name>
						/// setNeutralButton
						/// </java-name>
						[Dot42.DexImport("setNeutralButton", "(Ljava/lang/CharSequence;Landroid/content/DialogInterface$OnClickListener;)Landro" +
    "id/app/AlertDialog$Builder;", AccessFlags = 1)]
						public virtual Builder SetNeutralButton(global::Java.Lang.ICharSequence textId, global::Android.Content.IDialogInterface_IOnClickListener listener) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <summary>
						///  <para>Sets whether the dialog is cancelable or not. Default is true.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>This Builder object to allow for chaining of calls to set methods </para>
						/// </returns>
						/// <java-name>
						/// setCancelable
						/// </java-name>
						[Dot42.DexImport("setCancelable", "(Z)Landroid/app/AlertDialog$Builder;", AccessFlags = 1)]
						public virtual Builder SetCancelable(bool cancelable) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <summary>
						///  <para>Sets the callback that will be called if the dialog is canceled.</para> <para>Even in a cancelable dialog, the dialog may be dismissed for reasons other than being canceled or one of the supplied choices being selected. If you are interested in listening for all cases where the dialog is dismissed and not just when it is canceled, see setOnDismissListener.</para> <para> <para>setCancelable(boolean) </para> <para>setOnDismissListener(android.content.DialogInterface.OnDismissListener)</para></para>        
						/// </summary>
						/// <returns>
						///  <para>This Builder object to allow for chaining of calls to set methods </para>
						/// </returns>
						/// <java-name>
						/// setOnCancelListener
						/// </java-name>
						[Dot42.DexImport("setOnCancelListener", "(Landroid/content/DialogInterface$OnCancelListener;)Landroid/app/AlertDialog$Buil" +
    "der;", AccessFlags = 1)]
						public virtual Builder SetOnCancelListener(global::Android.Content.IDialogInterface_IOnCancelListener onCancelListener) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <summary>
						///  <para>Sets the callback that will be called when the dialog is dismissed for any reason.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>This Builder object to allow for chaining of calls to set methods </para>
						/// </returns>
						/// <java-name>
						/// setOnDismissListener
						/// </java-name>
						[Dot42.DexImport("setOnDismissListener", "(Landroid/content/DialogInterface$OnDismissListener;)Landroid/app/AlertDialog$Bui" +
    "lder;", AccessFlags = 1)]
						public virtual Builder SetOnDismissListener(global::Android.Content.IDialogInterface_IOnDismissListener onDismissListener) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <summary>
						///  <para>Sets the callback that will be called if a key is dispatched to the dialog.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>This Builder object to allow for chaining of calls to set methods </para>
						/// </returns>
						/// <java-name>
						/// setOnKeyListener
						/// </java-name>
						[Dot42.DexImport("setOnKeyListener", "(Landroid/content/DialogInterface$OnKeyListener;)Landroid/app/AlertDialog$Builder" +
    ";", AccessFlags = 1)]
						public virtual Builder SetOnKeyListener(global::Android.Content.IDialogInterface_IOnKeyListener onKeyListener) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <summary>
						///  <para>Set a list of items to be displayed in the dialog as the content, you will be notified of the selected item via the supplied listener. This should be an array type i.e. R.array.foo</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>This Builder object to allow for chaining of calls to set methods </para>
						/// </returns>
						/// <java-name>
						/// setItems
						/// </java-name>
						[Dot42.DexImport("setItems", "(ILandroid/content/DialogInterface$OnClickListener;)Landroid/app/AlertDialog$Buil" +
    "der;", AccessFlags = 1)]
						public virtual Builder SetItems(int itemsId, global::Android.Content.IDialogInterface_IOnClickListener listener) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <summary>
						///  <para>Set a list of items to be displayed in the dialog as the content, you will be notified of the selected item via the supplied listener. This should be an array type i.e. R.array.foo</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>This Builder object to allow for chaining of calls to set methods </para>
						/// </returns>
						/// <java-name>
						/// setItems
						/// </java-name>
						[Dot42.DexImport("setItems", "([Ljava/lang/CharSequence;Landroid/content/DialogInterface$OnClickListener;)Landr" +
    "oid/app/AlertDialog$Builder;", AccessFlags = 1)]
						public virtual Builder SetItems(global::Java.Lang.ICharSequence[] itemsId, global::Android.Content.IDialogInterface_IOnClickListener listener) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <summary>
						///  <para>Set a list of items, which are supplied by the given ListAdapter, to be displayed in the dialog as the content, you will be notified of the selected item via the supplied listener.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>This Builder object to allow for chaining of calls to set methods </para>
						/// </returns>
						/// <java-name>
						/// setAdapter
						/// </java-name>
						[Dot42.DexImport("setAdapter", "(Landroid/widget/ListAdapter;Landroid/content/DialogInterface$OnClickListener;)La" +
    "ndroid/app/AlertDialog$Builder;", AccessFlags = 1)]
						public virtual Builder SetAdapter(global::Android.Widget.IListAdapter adapter, global::Android.Content.IDialogInterface_IOnClickListener listener) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <summary>
						///  <para>Set a list of items, which are supplied by the given Cursor, to be displayed in the dialog as the content, you will be notified of the selected item via the supplied listener.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>This Builder object to allow for chaining of calls to set methods </para>
						/// </returns>
						/// <java-name>
						/// setCursor
						/// </java-name>
						[Dot42.DexImport("setCursor", "(Landroid/database/Cursor;Landroid/content/DialogInterface$OnClickListener;Ljava/" +
    "lang/String;)Landroid/app/AlertDialog$Builder;", AccessFlags = 1)]
						public virtual Builder SetCursor(global::Android.Database.ICursor cursor, global::Android.Content.IDialogInterface_IOnClickListener listener, string labelColumn) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// setMultiChoiceItems
						/// </java-name>
						[Dot42.DexImport("setMultiChoiceItems", "(I[ZLandroid/content/DialogInterface$OnMultiChoiceClickListener;)Landroid/app/Ale" +
    "rtDialog$Builder;", AccessFlags = 1)]
						public virtual Builder SetMultiChoiceItems(int int32, bool[] boolean, global::Android.Content.IDialogInterface_IOnMultiChoiceClickListener dialogInterface_IOnMultiChoiceClickListener) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// setMultiChoiceItems
						/// </java-name>
						[Dot42.DexImport("setMultiChoiceItems", "([Ljava/lang/CharSequence;[ZLandroid/content/DialogInterface$OnMultiChoiceClickLi" +
    "stener;)Landroid/app/AlertDialog$Builder;", AccessFlags = 1)]
						public virtual Builder SetMultiChoiceItems(global::Java.Lang.ICharSequence[] charSequence, bool[] boolean, global::Android.Content.IDialogInterface_IOnMultiChoiceClickListener dialogInterface_IOnMultiChoiceClickListener) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <summary>
						///  <para>Set a list of items to be displayed in the dialog as the content, you will be notified of the selected item via the supplied listener. The list will have a check mark displayed to the right of the text for each checked item. Clicking on an item in the list will not dismiss the dialog. Clicking on a button will dismiss the dialog.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>This Builder object to allow for chaining of calls to set methods </para>
						/// </returns>
						/// <java-name>
						/// setMultiChoiceItems
						/// </java-name>
						[Dot42.DexImport("setMultiChoiceItems", "(Landroid/database/Cursor;Ljava/lang/String;Ljava/lang/String;Landroid/content/Di" +
    "alogInterface$OnMultiChoiceClickListener;)Landroid/app/AlertDialog$Builder;", AccessFlags = 1)]
						public virtual Builder SetMultiChoiceItems(global::Android.Database.ICursor cursor, string isCheckedColumn, string labelColumn, global::Android.Content.IDialogInterface_IOnMultiChoiceClickListener listener) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <summary>
						///  <para>Set a list of items to be displayed in the dialog as the content, you will be notified of the selected item via the supplied listener. This should be an array type i.e. R.array.foo The list will have a check mark displayed to the right of the text for the checked item. Clicking on an item in the list will not dismiss the dialog. Clicking on a button will dismiss the dialog.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>This Builder object to allow for chaining of calls to set methods </para>
						/// </returns>
						/// <java-name>
						/// setSingleChoiceItems
						/// </java-name>
						[Dot42.DexImport("setSingleChoiceItems", "(IILandroid/content/DialogInterface$OnClickListener;)Landroid/app/AlertDialog$Bui" +
    "lder;", AccessFlags = 1)]
						public virtual Builder SetSingleChoiceItems(int itemsId, int checkedItem, global::Android.Content.IDialogInterface_IOnClickListener listener) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <summary>
						///  <para>Set a list of items to be displayed in the dialog as the content, you will be notified of the selected item via the supplied listener. The list will have a check mark displayed to the right of the text for the checked item. Clicking on an item in the list will not dismiss the dialog. Clicking on a button will dismiss the dialog.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>This Builder object to allow for chaining of calls to set methods </para>
						/// </returns>
						/// <java-name>
						/// setSingleChoiceItems
						/// </java-name>
						[Dot42.DexImport("setSingleChoiceItems", "(Landroid/database/Cursor;ILjava/lang/String;Landroid/content/DialogInterface$OnC" +
    "lickListener;)Landroid/app/AlertDialog$Builder;", AccessFlags = 1)]
						public virtual Builder SetSingleChoiceItems(global::Android.Database.ICursor cursor, int checkedItem, string labelColumn, global::Android.Content.IDialogInterface_IOnClickListener listener) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <summary>
						///  <para>Set a list of items to be displayed in the dialog as the content, you will be notified of the selected item via the supplied listener. This should be an array type i.e. R.array.foo The list will have a check mark displayed to the right of the text for the checked item. Clicking on an item in the list will not dismiss the dialog. Clicking on a button will dismiss the dialog.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>This Builder object to allow for chaining of calls to set methods </para>
						/// </returns>
						/// <java-name>
						/// setSingleChoiceItems
						/// </java-name>
						[Dot42.DexImport("setSingleChoiceItems", "([Ljava/lang/CharSequence;ILandroid/content/DialogInterface$OnClickListener;)Land" +
    "roid/app/AlertDialog$Builder;", AccessFlags = 1)]
						public virtual Builder SetSingleChoiceItems(global::Java.Lang.ICharSequence[] itemsId, int checkedItem, global::Android.Content.IDialogInterface_IOnClickListener listener) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <summary>
						///  <para>Set a list of items to be displayed in the dialog as the content, you will be notified of the selected item via the supplied listener. This should be an array type i.e. R.array.foo The list will have a check mark displayed to the right of the text for the checked item. Clicking on an item in the list will not dismiss the dialog. Clicking on a button will dismiss the dialog.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>This Builder object to allow for chaining of calls to set methods </para>
						/// </returns>
						/// <java-name>
						/// setSingleChoiceItems
						/// </java-name>
						[Dot42.DexImport("setSingleChoiceItems", "(Landroid/widget/ListAdapter;ILandroid/content/DialogInterface$OnClickListener;)L" +
    "android/app/AlertDialog$Builder;", AccessFlags = 1)]
						public virtual Builder SetSingleChoiceItems(global::Android.Widget.IListAdapter itemsId, int checkedItem, global::Android.Content.IDialogInterface_IOnClickListener listener) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <summary>
						///  <para>Sets a listener to be invoked when an item in the list is selected.</para> <para> <para>AdapterView::setOnItemSelectedListener(android.widget.AdapterView.OnItemSelectedListener)</para></para>        
						/// </summary>
						/// <returns>
						///  <para>This Builder object to allow for chaining of calls to set methods </para>
						/// </returns>
						/// <java-name>
						/// setOnItemSelectedListener
						/// </java-name>
						[Dot42.DexImport("setOnItemSelectedListener", "(Landroid/widget/AdapterView$OnItemSelectedListener;)Landroid/app/AlertDialog$Bui" +
    "lder;", AccessFlags = 1)]
						public virtual Builder SetOnItemSelectedListener(global::Android.Widget.AdapterView<object>.IOnItemSelectedListener listener) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <summary>
						///  <para>Set a custom view to be the contents of the Dialog. If the supplied view is an instance of a ListView the light background will be used.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>This Builder object to allow for chaining of calls to set methods </para>
						/// </returns>
						/// <java-name>
						/// setView
						/// </java-name>
						[Dot42.DexImport("setView", "(Landroid/view/View;)Landroid/app/AlertDialog$Builder;", AccessFlags = 1)]
						public virtual Builder SetView(global::Android.Views.View view) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <summary>
						///  <para>Sets the Dialog to use the inverse background, regardless of what the contents is.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>This Builder object to allow for chaining of calls to set methods </para>
						/// </returns>
						/// <java-name>
						/// setInverseBackgroundForced
						/// </java-name>
						[Dot42.DexImport("setInverseBackgroundForced", "(Z)Landroid/app/AlertDialog$Builder;", AccessFlags = 1)]
						public virtual Builder SetInverseBackgroundForced(bool useInverseBackground) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <summary>
						///  <para>Creates a AlertDialog with the arguments supplied to this builder. It does not Dialog#show() the dialog. This allows the user to do any extra processing before displaying the dialog. Use show() if you don't have any other processing to do and want this to be created and displayed. </para>        
						/// </summary>
						/// <java-name>
						/// create
						/// </java-name>
						[Dot42.DexImport("create", "()Landroid/app/AlertDialog;", AccessFlags = 1)]
						public virtual global::Android.App.AlertDialog Create() /* MethodBuilder.Create */ 
						{
								return default(global::Android.App.AlertDialog);
						}

						/// <summary>
						///  <para>Creates a AlertDialog with the arguments supplied to this builder and Dialog#show()'s the dialog. </para>        
						/// </summary>
						/// <java-name>
						/// show
						/// </java-name>
						[Dot42.DexImport("show", "()Landroid/app/AlertDialog;", AccessFlags = 1)]
						public virtual global::Android.App.AlertDialog Show() /* MethodBuilder.Create */ 
						{
								return default(global::Android.App.AlertDialog);
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal Builder() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

						/// <summary>
						///  <para>Returns a Context with the appropriate theme for dialogs created by this Builder. Applications should use this Context for obtaining LayoutInflaters for inflating views that will be used in the resulting dialogs, as it will cause views to be inflated with the correct theme.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>A Context for built Dialogs. </para>
						/// </returns>
						/// <java-name>
						/// getContext
						/// </java-name>
						public virtual global::Android.Content.Context Context
						{
								[Dot42.DexImport("getContext", "()Landroid/content/Context;", AccessFlags = 1)]
								get{ return default(global::Android.Content.Context); }
						}

				}

		}

		/// <summary>
		///  <para>Stub activity that launches another activity (and then finishes itself) based on information in its component's manifest meta-data. This is a simple way to implement an alias-like mechanism.</para> <para>To use this activity, you should include in the manifest for the associated component an entry named "android.app.alias". It is a reference to an XML resource describing an intent that launches the real application. </para>    
		/// </summary>
		/// <java-name>
		/// android/app/AliasActivity
		/// </java-name>
		[Dot42.DexImport("android/app/AliasActivity", AccessFlags = 33)]
		public partial class AliasActivity : global::Android.App.Activity
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public AliasActivity() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onCreate
				/// </java-name>
				[Dot42.DexImport("onCreate", "(Landroid/os/Bundle;)V", AccessFlags = 4)]
				protected internal override void OnCreate(global::Android.OS.Bundle savedInstanceState) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>Base class for those who need to maintain global application state. You can provide your own implementation by specifying its name in your AndroidManifest.xml's &lt;application&gt; tag, which will cause that class to be instantiated for you when the process for your application/package is created.</para> <para>There is normally no need to subclass Application. In most situation, static singletons can provide the same functionality in a more modular way. If your singleton needs a global context (for example to register broadcast receivers), the function to retrieve it can be given a android.content.Context which internally uses Context.getApplicationContext() when first constructing the singleton.</para>    
		/// </summary>
		/// <java-name>
		/// android/app/Application
		/// </java-name>
		[Dot42.DexImport("android/app/Application", AccessFlags = 33)]
		public partial class Application : global::Android.Content.ContextWrapper, global::Android.Content.IComponentCallbacks2
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Application() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Called when the application is starting, before any activity, service, or receiver objects (excluding content providers) have been created. Implementations should be as quick as possible (for example using lazy initialization of state) since the time spent in this function directly impacts the performance of starting the first activity, service, or receiver in a process. If you override this method, be sure to call super.onCreate(). </para>        
				/// </summary>
				/// <java-name>
				/// onCreate
				/// </java-name>
				[Dot42.DexImport("onCreate", "()V", AccessFlags = 1)]
				public virtual void OnCreate() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>This method is for use in emulated process environments. It will never be called on a production Android device, where processes are removed by simply killing them; no user code (including this callback) is executed when doing so. </para>        
				/// </summary>
				/// <java-name>
				/// onTerminate
				/// </java-name>
				[Dot42.DexImport("onTerminate", "()V", AccessFlags = 1)]
				public virtual void OnTerminate() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Called by the system when the device configuration changes while your component is running. Note that, unlike activities, other components are never restarted when a configuration changes: they must always deal with the results of the change, such as by re-retrieving resources.</para> <para>At the time that this function has been called, your Resources object will have been updated to return resource values matching the new configuration.</para> <para>For more information, read .</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// onConfigurationChanged
				/// </java-name>
				[Dot42.DexImport("onConfigurationChanged", "(Landroid/content/res/Configuration;)V", AccessFlags = 1)]
				public virtual void OnConfigurationChanged(global::Android.Content.Res.Configuration newConfig) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>This is called when the overall system is running low on memory, and actively running processes should trim their memory usage. While the exact point at which this will be called is not defined, generally it will happen when all background process have been killed. That is, before reaching the point of killing processes hosting service and foreground UI that we would like to avoid killing.</para> <para>You should implement this method to release any caches or other unnecessary resources you may be holding on to. The system will perform a garbage collection for you after returning from this method. </para> <para>Preferably, you should implement ComponentCallbacks2#onTrimMemory from ComponentCallbacks2 to incrementally unload your resources based on various levels of memory demands. That API is available for API level 14 and higher, so you should only use this onLowMemory method as a fallback for older versions, which can be treated the same as ComponentCallbacks2#onTrimMemory with the ComponentCallbacks2#TRIM_MEMORY_COMPLETE level.</para>        
				/// </summary>
				/// <java-name>
				/// onLowMemory
				/// </java-name>
				[Dot42.DexImport("onLowMemory", "()V", AccessFlags = 1)]
				public virtual void OnLowMemory() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Called when the operating system has determined that it is a good time for a process to trim unneeded memory from its process. This will happen for example when it goes in the background and there is not enough memory to keep as many background processes running as desired. You should never compare to exact values of the level, since new intermediate values may be added  you will typically want to compare if the value is greater or equal to a level you are interested in.</para> <para>To retrieve the processes current trim level at any point, you can use ActivityManager.getMyMemoryState(RunningAppProcessInfo).</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// onTrimMemory
				/// </java-name>
				[Dot42.DexImport("onTrimMemory", "(I)V", AccessFlags = 1)]
				public virtual void OnTrimMemory(int level) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// registerComponentCallbacks
				/// </java-name>
				[Dot42.DexImport("registerComponentCallbacks", "(Landroid/content/ComponentCallbacks;)V", AccessFlags = 1)]
				public override void RegisterComponentCallbacks(global::Android.Content.IComponentCallbacks callback) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// unregisterComponentCallbacks
				/// </java-name>
				[Dot42.DexImport("unregisterComponentCallbacks", "(Landroid/content/ComponentCallbacks;)V", AccessFlags = 1)]
				public override void UnregisterComponentCallbacks(global::Android.Content.IComponentCallbacks callback) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// registerActivityLifecycleCallbacks
				/// </java-name>
				[Dot42.DexImport("registerActivityLifecycleCallbacks", "(Landroid/app/Application$ActivityLifecycleCallbacks;)V", AccessFlags = 1)]
				public virtual void RegisterActivityLifecycleCallbacks(global::Android.App.Application.IActivityLifecycleCallbacks callback) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// unregisterActivityLifecycleCallbacks
				/// </java-name>
				[Dot42.DexImport("unregisterActivityLifecycleCallbacks", "(Landroid/app/Application$ActivityLifecycleCallbacks;)V", AccessFlags = 1)]
				public virtual void UnregisterActivityLifecycleCallbacks(global::Android.App.Application.IActivityLifecycleCallbacks callback) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// registerOnProvideAssistDataListener
				/// </java-name>
				[Dot42.DexImport("registerOnProvideAssistDataListener", "(Landroid/app/Application$OnProvideAssistDataListener;)V", AccessFlags = 1)]
				public virtual void RegisterOnProvideAssistDataListener(global::Android.App.Application.IOnProvideAssistDataListener callback) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// unregisterOnProvideAssistDataListener
				/// </java-name>
				[Dot42.DexImport("unregisterOnProvideAssistDataListener", "(Landroid/app/Application$OnProvideAssistDataListener;)V", AccessFlags = 1)]
				public virtual void UnregisterOnProvideAssistDataListener(global::Android.App.Application.IOnProvideAssistDataListener callback) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Callback interface for use with Application#registerOnProvideAssistDataListener and Application#unregisterOnProvideAssistDataListener. </para>    
				/// </summary>
				/// <java-name>
				/// android/app/Application$OnProvideAssistDataListener
				/// </java-name>
				[Dot42.DexImport("android/app/Application$OnProvideAssistDataListener", AccessFlags = 1545)]
				public partial interface IOnProvideAssistDataListener
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>This is called when the user is requesting an assist, to build a full Intent#ACTION_ASSIST Intent with all of the context of the current application. You can override this method to place into the bundle anything you would like to appear in the Intent#EXTRA_ASSIST_CONTEXT part of the assist Intent. </para>        
						/// </summary>
						/// <java-name>
						/// onProvideAssistData
						/// </java-name>
						[Dot42.DexImport("onProvideAssistData", "(Landroid/app/Activity;Landroid/os/Bundle;)V", AccessFlags = 1025)]
						void OnProvideAssistData(global::Android.App.Activity activity, global::Android.OS.Bundle data) /* MethodBuilder.Create */ ;

				}

				/// <java-name>
				/// android/app/Application$ActivityLifecycleCallbacks
				/// </java-name>
				[Dot42.DexImport("android/app/Application$ActivityLifecycleCallbacks", AccessFlags = 1545)]
				public partial interface IActivityLifecycleCallbacks
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onActivityCreated
						/// </java-name>
						[Dot42.DexImport("onActivityCreated", "(Landroid/app/Activity;Landroid/os/Bundle;)V", AccessFlags = 1025)]
						void OnActivityCreated(global::Android.App.Activity activity, global::Android.OS.Bundle savedInstanceState) /* MethodBuilder.Create */ ;

						/// <java-name>
						/// onActivityStarted
						/// </java-name>
						[Dot42.DexImport("onActivityStarted", "(Landroid/app/Activity;)V", AccessFlags = 1025)]
						void OnActivityStarted(global::Android.App.Activity activity) /* MethodBuilder.Create */ ;

						/// <java-name>
						/// onActivityResumed
						/// </java-name>
						[Dot42.DexImport("onActivityResumed", "(Landroid/app/Activity;)V", AccessFlags = 1025)]
						void OnActivityResumed(global::Android.App.Activity activity) /* MethodBuilder.Create */ ;

						/// <java-name>
						/// onActivityPaused
						/// </java-name>
						[Dot42.DexImport("onActivityPaused", "(Landroid/app/Activity;)V", AccessFlags = 1025)]
						void OnActivityPaused(global::Android.App.Activity activity) /* MethodBuilder.Create */ ;

						/// <java-name>
						/// onActivityStopped
						/// </java-name>
						[Dot42.DexImport("onActivityStopped", "(Landroid/app/Activity;)V", AccessFlags = 1025)]
						void OnActivityStopped(global::Android.App.Activity activity) /* MethodBuilder.Create */ ;

						/// <java-name>
						/// onActivitySaveInstanceState
						/// </java-name>
						[Dot42.DexImport("onActivitySaveInstanceState", "(Landroid/app/Activity;Landroid/os/Bundle;)V", AccessFlags = 1025)]
						void OnActivitySaveInstanceState(global::Android.App.Activity activity, global::Android.OS.Bundle outState) /* MethodBuilder.Create */ ;

						/// <java-name>
						/// onActivityDestroyed
						/// </java-name>
						[Dot42.DexImport("onActivityDestroyed", "(Landroid/app/Activity;)V", AccessFlags = 1025)]
						void OnActivityDestroyed(global::Android.App.Activity activity) /* MethodBuilder.Create */ ;

				}

		}

		/// <summary>
		///  <para>Describes an application error.</para> <para>A report has a type, which is one of  <ul> <li> <para>TYPE_NONE uninitialized instance of ApplicationErrorReport. </para></li> <li> <para>TYPE_CRASH application crash. Information about the crash is stored in crashInfo. </para></li> <li> <para>TYPE_ANR application not responding. Information about the ANR is stored in anrInfo. </para></li> <li> <para>TYPE_BATTERY user reported application is using too much battery. Information about the battery use is stored in batteryInfo. </para></li> <li> <para>TYPE_RUNNING_SERVICE user reported application is leaving an unneeded serive running. Information about the battery use is stored in runningServiceInfo. </para></li></ul></para>    
		/// </summary>
		/// <java-name>
		/// android/app/ApplicationErrorReport
		/// </java-name>
		[Dot42.DexImport("android/app/ApplicationErrorReport", AccessFlags = 33)]
		public partial class ApplicationErrorReport : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Uninitialized error report. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_NONE
				/// </java-name>
				[Dot42.DexImport("TYPE_NONE", "I", AccessFlags = 25)]
				public const int TYPE_NONE = 0;
				/// <summary>
				///  <para>An error report about an application crash. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_CRASH
				/// </java-name>
				[Dot42.DexImport("TYPE_CRASH", "I", AccessFlags = 25)]
				public const int TYPE_CRASH = 1;
				/// <summary>
				///  <para>An error report about an application that's not responding. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_ANR
				/// </java-name>
				[Dot42.DexImport("TYPE_ANR", "I", AccessFlags = 25)]
				public const int TYPE_ANR = 2;
				/// <summary>
				///  <para>An error report about an application that's consuming too much battery. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_BATTERY
				/// </java-name>
				[Dot42.DexImport("TYPE_BATTERY", "I", AccessFlags = 25)]
				public const int TYPE_BATTERY = 3;
				/// <summary>
				///  <para>A report from a user to a developer about a running service that the user doesn't think should be running. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_RUNNING_SERVICE
				/// </java-name>
				[Dot42.DexImport("TYPE_RUNNING_SERVICE", "I", AccessFlags = 25)]
				public const int TYPE_RUNNING_SERVICE = 5;
				/// <summary>
				///  <para>Type of this report. Can be one of TYPE_NONE, TYPE_CRASH, TYPE_ANR, TYPE_BATTERY, or TYPE_RUNNING_SERVICE. </para>        
				/// </summary>
				/// <java-name>
				/// type
				/// </java-name>
				[Dot42.DexImport("type", "I", AccessFlags = 1)]
				public int Type;
				/// <summary>
				///  <para>Package name of the application. </para>        
				/// </summary>
				/// <java-name>
				/// packageName
				/// </java-name>
				[Dot42.DexImport("packageName", "Ljava/lang/String;", AccessFlags = 1)]
				public string PackageName;
				/// <summary>
				///  <para>Package name of the application which installed the application this report pertains to. This identifies which market the application came from. </para>        
				/// </summary>
				/// <java-name>
				/// installerPackageName
				/// </java-name>
				[Dot42.DexImport("installerPackageName", "Ljava/lang/String;", AccessFlags = 1)]
				public string InstallerPackageName;
				/// <summary>
				///  <para>Process name of the application. </para>        
				/// </summary>
				/// <java-name>
				/// processName
				/// </java-name>
				[Dot42.DexImport("processName", "Ljava/lang/String;", AccessFlags = 1)]
				public string ProcessName;
				/// <summary>
				///  <para>Time at which the error occurred. </para>        
				/// </summary>
				/// <java-name>
				/// time
				/// </java-name>
				[Dot42.DexImport("time", "J", AccessFlags = 1)]
				public long Time;
				/// <summary>
				///  <para>Set if the app is on the system image. </para>        
				/// </summary>
				/// <java-name>
				/// systemApp
				/// </java-name>
				[Dot42.DexImport("systemApp", "Z", AccessFlags = 1)]
				public bool SystemApp;
				/// <summary>
				///  <para>If this report is of type TYPE_CRASH, contains an instance of CrashInfo describing the crash; otherwise null. </para>        
				/// </summary>
				/// <java-name>
				/// crashInfo
				/// </java-name>
				[Dot42.DexImport("crashInfo", "Landroid/app/ApplicationErrorReport$CrashInfo;", AccessFlags = 1)]
				public global::Android.App.ApplicationErrorReport.CrashInfo CrashInfo0;
				/// <summary>
				///  <para>If this report is of type TYPE_ANR, contains an instance of AnrInfo describing the ANR; otherwise null. </para>        
				/// </summary>
				/// <java-name>
				/// anrInfo
				/// </java-name>
				[Dot42.DexImport("anrInfo", "Landroid/app/ApplicationErrorReport$AnrInfo;", AccessFlags = 1)]
				public global::Android.App.ApplicationErrorReport.AnrInfo AnrInfo0;
				/// <summary>
				///  <para>If this report is of type TYPE_BATTERY, contains an instance of BatteryInfo; otherwise null. </para>        
				/// </summary>
				/// <java-name>
				/// batteryInfo
				/// </java-name>
				[Dot42.DexImport("batteryInfo", "Landroid/app/ApplicationErrorReport$BatteryInfo;", AccessFlags = 1)]
				public global::Android.App.ApplicationErrorReport.BatteryInfo BatteryInfo0;
				/// <summary>
				///  <para>If this report is of type TYPE_RUNNING_SERVICE, contains an instance of RunningServiceInfo; otherwise null. </para>        
				/// </summary>
				/// <java-name>
				/// runningServiceInfo
				/// </java-name>
				[Dot42.DexImport("runningServiceInfo", "Landroid/app/ApplicationErrorReport$RunningServiceInfo;", AccessFlags = 1)]
				public global::Android.App.ApplicationErrorReport.RunningServiceInfo RunningServiceInfo0;
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.App.ApplicationErrorReport> CREATOR;
				/// <summary>
				///  <para>Create an uninitialized instance of ApplicationErrorReport. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ApplicationErrorReport() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getErrorReportReceiver
				/// </java-name>
				[Dot42.DexImport("getErrorReportReceiver", "(Landroid/content/Context;Ljava/lang/String;I)Landroid/content/ComponentName;", AccessFlags = 9)]
				public static global::Android.Content.ComponentName GetErrorReportReceiver(global::Android.Content.Context context, string @string, int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.ComponentName);
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
				/// readFromParcel
				/// </java-name>
				[Dot42.DexImport("readFromParcel", "(Landroid/os/Parcel;)V", AccessFlags = 1)]
				public virtual void ReadFromParcel(global::Android.OS.Parcel @in) /* MethodBuilder.Create */ 
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
				///  <para>Dump the report to a Printer. </para>        
				/// </summary>
				/// <java-name>
				/// dump
				/// </java-name>
				[Dot42.DexImport("dump", "(Landroid/util/Printer;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void Dump(global::Android.Util.IPrinter pw, string prefix) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Describes a running service report. </para>    
				/// </summary>
				/// <java-name>
				/// android/app/ApplicationErrorReport$RunningServiceInfo
				/// </java-name>
				[Dot42.DexImport("android/app/ApplicationErrorReport$RunningServiceInfo", AccessFlags = 9)]
				public partial class RunningServiceInfo
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>Duration in milliseconds that the service has been running. </para>        
						/// </summary>
						/// <java-name>
						/// durationMillis
						/// </java-name>
						[Dot42.DexImport("durationMillis", "J", AccessFlags = 1)]
						public long DurationMillis;
						/// <summary>
						///  <para>Dump of debug information about the service. </para>        
						/// </summary>
						/// <java-name>
						/// serviceDetails
						/// </java-name>
						[Dot42.DexImport("serviceDetails", "Ljava/lang/String;", AccessFlags = 1)]
						public string ServiceDetails;
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public RunningServiceInfo() /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "(Landroid/os/Parcel;)V", AccessFlags = 1)]
						public RunningServiceInfo(global::Android.OS.Parcel parcel) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Save a RunningServiceInfo instance to a parcel. </para>        
						/// </summary>
						/// <java-name>
						/// writeToParcel
						/// </java-name>
						[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
						public virtual void WriteToParcel(global::Android.OS.Parcel dest, int flags) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Dump a BatteryInfo instance to a Printer. </para>        
						/// </summary>
						/// <java-name>
						/// dump
						/// </java-name>
						[Dot42.DexImport("dump", "(Landroid/util/Printer;Ljava/lang/String;)V", AccessFlags = 1)]
						public virtual void Dump(global::Android.Util.IPrinter pw, string prefix) /* MethodBuilder.Create */ 
						{
						}

				}

				/// <summary>
				///  <para>Describes a battery usage report. </para>    
				/// </summary>
				/// <java-name>
				/// android/app/ApplicationErrorReport$BatteryInfo
				/// </java-name>
				[Dot42.DexImport("android/app/ApplicationErrorReport$BatteryInfo", AccessFlags = 9)]
				public partial class BatteryInfo
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>Percentage of the battery that was used up by the process. </para>        
						/// </summary>
						/// <java-name>
						/// usagePercent
						/// </java-name>
						[Dot42.DexImport("usagePercent", "I", AccessFlags = 1)]
						public int UsagePercent;
						/// <summary>
						///  <para>Duration in microseconds over which the process used the above percentage of battery. </para>        
						/// </summary>
						/// <java-name>
						/// durationMicros
						/// </java-name>
						[Dot42.DexImport("durationMicros", "J", AccessFlags = 1)]
						public long DurationMicros;
						/// <summary>
						///  <para>Dump of various info impacting battery use. </para>        
						/// </summary>
						/// <java-name>
						/// usageDetails
						/// </java-name>
						[Dot42.DexImport("usageDetails", "Ljava/lang/String;", AccessFlags = 1)]
						public string UsageDetails;
						/// <summary>
						///  <para>Checkin details. </para>        
						/// </summary>
						/// <java-name>
						/// checkinDetails
						/// </java-name>
						[Dot42.DexImport("checkinDetails", "Ljava/lang/String;", AccessFlags = 1)]
						public string CheckinDetails;
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public BatteryInfo() /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "(Landroid/os/Parcel;)V", AccessFlags = 1)]
						public BatteryInfo(global::Android.OS.Parcel parcel) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Save a BatteryInfo instance to a parcel. </para>        
						/// </summary>
						/// <java-name>
						/// writeToParcel
						/// </java-name>
						[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
						public virtual void WriteToParcel(global::Android.OS.Parcel dest, int flags) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Dump a BatteryInfo instance to a Printer. </para>        
						/// </summary>
						/// <java-name>
						/// dump
						/// </java-name>
						[Dot42.DexImport("dump", "(Landroid/util/Printer;Ljava/lang/String;)V", AccessFlags = 1)]
						public virtual void Dump(global::Android.Util.IPrinter pw, string prefix) /* MethodBuilder.Create */ 
						{
						}

				}

				/// <summary>
				///  <para>Describes an application not responding error. </para>    
				/// </summary>
				/// <java-name>
				/// android/app/ApplicationErrorReport$AnrInfo
				/// </java-name>
				[Dot42.DexImport("android/app/ApplicationErrorReport$AnrInfo", AccessFlags = 9)]
				public partial class AnrInfo
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>Activity name. </para>        
						/// </summary>
						/// <java-name>
						/// activity
						/// </java-name>
						[Dot42.DexImport("activity", "Ljava/lang/String;", AccessFlags = 1)]
						public string Activity;
						/// <summary>
						///  <para>Description of the operation that timed out. </para>        
						/// </summary>
						/// <java-name>
						/// cause
						/// </java-name>
						[Dot42.DexImport("cause", "Ljava/lang/String;", AccessFlags = 1)]
						public string Cause;
						/// <summary>
						///  <para>Additional info, including CPU stats. </para>        
						/// </summary>
						/// <java-name>
						/// info
						/// </java-name>
						[Dot42.DexImport("info", "Ljava/lang/String;", AccessFlags = 1)]
						public string Info;
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public AnrInfo() /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "(Landroid/os/Parcel;)V", AccessFlags = 1)]
						public AnrInfo(global::Android.OS.Parcel parcel) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Save an AnrInfo instance to a parcel. </para>        
						/// </summary>
						/// <java-name>
						/// writeToParcel
						/// </java-name>
						[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
						public virtual void WriteToParcel(global::Android.OS.Parcel dest, int flags) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Dump an AnrInfo instance to a Printer. </para>        
						/// </summary>
						/// <java-name>
						/// dump
						/// </java-name>
						[Dot42.DexImport("dump", "(Landroid/util/Printer;Ljava/lang/String;)V", AccessFlags = 1)]
						public virtual void Dump(global::Android.Util.IPrinter pw, string prefix) /* MethodBuilder.Create */ 
						{
						}

				}

				/// <summary>
				///  <para>Describes an application crash. </para>    
				/// </summary>
				/// <java-name>
				/// android/app/ApplicationErrorReport$CrashInfo
				/// </java-name>
				[Dot42.DexImport("android/app/ApplicationErrorReport$CrashInfo", AccessFlags = 9)]
				public partial class CrashInfo
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>Class name of the exception that caused the crash. </para>        
						/// </summary>
						/// <java-name>
						/// exceptionClassName
						/// </java-name>
						[Dot42.DexImport("exceptionClassName", "Ljava/lang/String;", AccessFlags = 1)]
						public string ExceptionClassName;
						/// <summary>
						///  <para>Message stored in the exception. </para>        
						/// </summary>
						/// <java-name>
						/// exceptionMessage
						/// </java-name>
						[Dot42.DexImport("exceptionMessage", "Ljava/lang/String;", AccessFlags = 1)]
						public string ExceptionMessage;
						/// <summary>
						///  <para>File which the exception was thrown from. </para>        
						/// </summary>
						/// <java-name>
						/// throwFileName
						/// </java-name>
						[Dot42.DexImport("throwFileName", "Ljava/lang/String;", AccessFlags = 1)]
						public string ThrowFileName;
						/// <summary>
						///  <para>Class which the exception was thrown from. </para>        
						/// </summary>
						/// <java-name>
						/// throwClassName
						/// </java-name>
						[Dot42.DexImport("throwClassName", "Ljava/lang/String;", AccessFlags = 1)]
						public string ThrowClassName;
						/// <summary>
						///  <para>Method which the exception was thrown from. </para>        
						/// </summary>
						/// <java-name>
						/// throwMethodName
						/// </java-name>
						[Dot42.DexImport("throwMethodName", "Ljava/lang/String;", AccessFlags = 1)]
						public string ThrowMethodName;
						/// <summary>
						///  <para>Line number the exception was thrown from. </para>        
						/// </summary>
						/// <java-name>
						/// throwLineNumber
						/// </java-name>
						[Dot42.DexImport("throwLineNumber", "I", AccessFlags = 1)]
						public int ThrowLineNumber;
						/// <summary>
						///  <para>Stack trace. </para>        
						/// </summary>
						/// <java-name>
						/// stackTrace
						/// </java-name>
						[Dot42.DexImport("stackTrace", "Ljava/lang/String;", AccessFlags = 1)]
						public string StackTrace;
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public CrashInfo() /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "(Ljava/lang/Throwable;)V", AccessFlags = 1)]
						public CrashInfo(global::System.Exception exception) /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "(Landroid/os/Parcel;)V", AccessFlags = 1)]
						public CrashInfo(global::Android.OS.Parcel parcel) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Save a CrashInfo instance to a parcel. </para>        
						/// </summary>
						/// <java-name>
						/// writeToParcel
						/// </java-name>
						[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
						public virtual void WriteToParcel(global::Android.OS.Parcel dest, int flags) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Dump a CrashInfo instance to a Printer. </para>        
						/// </summary>
						/// <java-name>
						/// dump
						/// </java-name>
						[Dot42.DexImport("dump", "(Landroid/util/Printer;Ljava/lang/String;)V", AccessFlags = 1)]
						public virtual void Dump(global::Android.Util.IPrinter pw, string prefix) /* MethodBuilder.Create */ 
						{
						}

				}

		}

		/// <summary>
		///  <para>A simple dialog containing an android.widget.DatePicker.</para> <para>See the  guide.</para>    
		/// </summary>
		/// <java-name>
		/// android/app/DatePickerDialog
		/// </java-name>
		[Dot42.DexImport("android/app/DatePickerDialog", AccessFlags = 33)]
		public partial class DatePickerDialog : global::Android.App.AlertDialog, global::Android.Content.IDialogInterface_IOnClickListener, global::Android.Widget.DatePicker.IOnDateChangedListener
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/app/DatePickerDialog$OnDateSetListener;III)V", AccessFlags = 1)]
				public DatePickerDialog(global::Android.Content.Context context, global::Android.App.DatePickerDialog.IOnDateSetListener callBack, int year, int monthOfYear, int dayOfMonth) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;ILandroid/app/DatePickerDialog$OnDateSetListener;III)V", AccessFlags = 1)]
				public DatePickerDialog(global::Android.Content.Context context, int theme, global::Android.App.DatePickerDialog.IOnDateSetListener callBack, int year, int monthOfYear, int dayOfMonth) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>This method will be invoked when a button in the dialog is clicked.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// onClick
				/// </java-name>
				[Dot42.DexImport("onClick", "(Landroid/content/DialogInterface;I)V", AccessFlags = 1)]
				public virtual void OnClick(global::Android.Content.IDialogInterface dialog, int which) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Called upon a date change.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// onDateChanged
				/// </java-name>
				[Dot42.DexImport("onDateChanged", "(Landroid/widget/DatePicker;III)V", AccessFlags = 1)]
				public virtual void OnDateChanged(global::Android.Widget.DatePicker view, int year, int monthOfYear, int dayOfMonth) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the current date.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// updateDate
				/// </java-name>
				[Dot42.DexImport("updateDate", "(III)V", AccessFlags = 1)]
				public virtual void UpdateDate(int year, int monthOfYear, int dayOfMonth) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onStop
				/// </java-name>
				[Dot42.DexImport("onStop", "()V", AccessFlags = 4)]
				protected internal override void OnStop() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onSaveInstanceState
				/// </java-name>
				[Dot42.DexImport("onSaveInstanceState", "()Landroid/os/Bundle;", AccessFlags = 1)]
				public override global::Android.OS.Bundle OnSaveInstanceState() /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.Bundle);
				}

				/// <java-name>
				/// onRestoreInstanceState
				/// </java-name>
				[Dot42.DexImport("onRestoreInstanceState", "(Landroid/os/Bundle;)V", AccessFlags = 1)]
				public override void OnRestoreInstanceState(global::Android.OS.Bundle savedInstanceState) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal DatePickerDialog() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Gets the DatePicker contained in this dialog.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The calendar view. </para>
				/// </returns>
				/// <java-name>
				/// getDatePicker
				/// </java-name>
				public virtual global::Android.Widget.DatePicker DatePicker
				{
						[Dot42.DexImport("getDatePicker", "()Landroid/widget/DatePicker;", AccessFlags = 1)]
						get{ return default(global::Android.Widget.DatePicker); }
				}

				/// <summary>
				///  <para>The callback used to indicate the user is done filling in the date. </para>    
				/// </summary>
				/// <java-name>
				/// android/app/DatePickerDialog$OnDateSetListener
				/// </java-name>
				[Dot42.DexImport("android/app/DatePickerDialog$OnDateSetListener", AccessFlags = 1545)]
				public partial interface IOnDateSetListener
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para></para>        
						/// </summary>
						/// <java-name>
						/// onDateSet
						/// </java-name>
						[Dot42.DexImport("onDateSet", "(Landroid/widget/DatePicker;III)V", AccessFlags = 1025)]
						void OnDateSet(global::Android.Widget.DatePicker view, int year, int monthOfYear, int dayOfMonth) /* MethodBuilder.Create */ ;

				}

		}

		/// <summary>
		///  <para>Base class for Dialogs.</para> <para>Note: Activities provide a facility to manage the creation, saving and restoring of dialogs. See Activity#onCreateDialog(int), Activity#onPrepareDialog(int, Dialog), Activity#showDialog(int), and Activity#dismissDialog(int). If these methods are used, getOwnerActivity() will return the Activity that managed this dialog.</para> <para>Often you will want to have a Dialog display on top of the current input method, because there is no reason for it to accept text. You can do this by setting the WindowManager.LayoutParams.FLAG_ALT_FOCUSABLE_IM window flag (assuming your Dialog takes input focus, as it the default) with the following code:</para> <para> <pre>
		/// getWindow().setFlags(WindowManager.LayoutParams.FLAG_ALT_FOCUSABLE_IM,
		///         WindowManager.LayoutParams.FLAG_ALT_FOCUSABLE_IM);</pre></para> <para>  <h3>Developer Guides</h3></para> <para> </para> <para>For more information about creating dialogs, read the  developer guide.</para> <para>  </para>    
		/// </summary>
		/// <java-name>
		/// android/app/Dialog
		/// </java-name>
		[Dot42.DexImport("android/app/Dialog", AccessFlags = 33)]
		public partial class Dialog : global::Android.Content.IDialogInterface, global::Android.Views.Window.ICallback, global::Android.Views.KeyEvent.ICallback, global::Android.Views.View.IOnCreateContextMenuListener
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Create a Dialog window that uses the default dialog frame style.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public Dialog(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Create a Dialog window that uses a custom dialog style.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;I)V", AccessFlags = 1)]
				public Dialog(global::Android.Content.Context context, int theme) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;ZLandroid/content/DialogInterface$OnCancelListener;)V", AccessFlags = 4)]
				protected internal Dialog(global::Android.Content.Context context, bool boolean, global::Android.Content.IDialogInterface_IOnCancelListener dialogInterface_IOnCancelListener) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Start the dialog and display it on screen. The window is placed in the application layer and opaque. Note that you should not override this method to do initialization when the dialog is shown, instead implement that in onStart. </para>        
				/// </summary>
				/// <java-name>
				/// show
				/// </java-name>
				[Dot42.DexImport("show", "()V", AccessFlags = 1)]
				public virtual void Show() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Hide the dialog, but do not dismiss it. </para>        
				/// </summary>
				/// <java-name>
				/// hide
				/// </java-name>
				[Dot42.DexImport("hide", "()V", AccessFlags = 1)]
				public virtual void Hide() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Dismiss this dialog, removing it from the screen. This method can be invoked safely from any thread. Note that you should not override this method to do cleanup when the dialog is dismissed, instead implement that in onStop. </para>        
				/// </summary>
				/// <java-name>
				/// dismiss
				/// </java-name>
				[Dot42.DexImport("dismiss", "()V", AccessFlags = 1)]
				public virtual void Dismiss() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Similar to Activity#onCreate, you should initialize your dialog in this method, including calling setContentView. </para>        
				/// </summary>
				/// <java-name>
				/// onCreate
				/// </java-name>
				[Dot42.DexImport("onCreate", "(Landroid/os/Bundle;)V", AccessFlags = 4)]
				protected internal virtual void OnCreate(global::Android.OS.Bundle savedInstanceState) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Called when the dialog is starting. </para>        
				/// </summary>
				/// <java-name>
				/// onStart
				/// </java-name>
				[Dot42.DexImport("onStart", "()V", AccessFlags = 4)]
				protected internal virtual void OnStart() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Called to tell you that you're stopping. </para>        
				/// </summary>
				/// <java-name>
				/// onStop
				/// </java-name>
				[Dot42.DexImport("onStop", "()V", AccessFlags = 4)]
				protected internal virtual void OnStop() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Saves the state of the dialog into a bundle.</para> <para>The default implementation saves the state of its view hierarchy, so you'll likely want to call through to super if you override this to save additional state. </para>        
				/// </summary>
				/// <returns>
				///  <para>A bundle with the state of the dialog. </para>
				/// </returns>
				/// <java-name>
				/// onSaveInstanceState
				/// </java-name>
				[Dot42.DexImport("onSaveInstanceState", "()Landroid/os/Bundle;", AccessFlags = 1)]
				public virtual global::Android.OS.Bundle OnSaveInstanceState() /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.Bundle);
				}

				/// <summary>
				///  <para>Restore the state of the dialog from a previously saved bundle.</para> <para>The default implementation restores the state of the dialog's view hierarchy that was saved in the default implementation of onSaveInstanceState(), so be sure to call through to super when overriding unless you want to do all restoring of state yourself. </para>        
				/// </summary>
				/// <java-name>
				/// onRestoreInstanceState
				/// </java-name>
				[Dot42.DexImport("onRestoreInstanceState", "(Landroid/os/Bundle;)V", AccessFlags = 1)]
				public virtual void OnRestoreInstanceState(global::Android.OS.Bundle savedInstanceState) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Finds a view that was identified by the id attribute from the XML that was processed in onStart.</para> <para></para>        
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
				///  <para>Set the screen content from a layout resource. The resource will be inflated, adding all top-level views to the screen.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setContentView
				/// </java-name>
				[Dot42.DexImport("setContentView", "(I)V", AccessFlags = 1)]
				public virtual void SetContentView(int layoutResID) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Set the screen content from a layout resource. The resource will be inflated, adding all top-level views to the screen.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setContentView
				/// </java-name>
				[Dot42.DexImport("setContentView", "(Landroid/view/View;)V", AccessFlags = 1)]
				public virtual void SetContentView(global::Android.Views.View layoutResID) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Set the screen content to an explicit view. This view is placed directly into the screen's view hierarchy. It can itself be a complex view hierarhcy.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setContentView
				/// </java-name>
				[Dot42.DexImport("setContentView", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V", AccessFlags = 1)]
				public virtual void SetContentView(global::Android.Views.View view, global::Android.Views.ViewGroup.LayoutParams @params) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Add an additional content view to the screen. Added after any existing ones in the screen  existing views are NOT removed.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// addContentView
				/// </java-name>
				[Dot42.DexImport("addContentView", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V", AccessFlags = 1)]
				public virtual void AddContentView(global::Android.Views.View view, global::Android.Views.ViewGroup.LayoutParams @params) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Set the title text for this dialog's window. The text is retrieved from the resources with the supplied identifier.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setTitle
				/// </java-name>
				[Dot42.DexImport("setTitle", "(Ljava/lang/CharSequence;)V", AccessFlags = 1)]
				public virtual void SetTitle(global::Java.Lang.ICharSequence titleId) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Set the title text for this dialog's window. The text is retrieved from the resources with the supplied identifier.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setTitle
				/// </java-name>
				[Dot42.DexImport("setTitle", "(I)V", AccessFlags = 1)]
				public virtual void SetTitle(int titleId) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>A key was pressed down.</para> <para>If the focused view didn't want this event, this method is called.</para> <para>The default implementation consumed the KEYCODE_BACK to later handle it in onKeyUp.</para> <para> <para>onKeyUp </para> <para>android.view.KeyEvent </para></para>        
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
				///  <para>Default implementation of KeyEvent.Callback.onKeyLongPress(): always returns false (doesn't handle the event). </para>        
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
				///  <para>A key was released.</para> <para>The default implementation handles KEYCODE_BACK to close the dialog.</para> <para> <para>onKeyDown </para> <para>KeyEvent </para></para>        
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
				///  <para>Default implementation of KeyEvent.Callback.onKeyMultiple(): always returns false (doesn't handle the event). </para>        
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
				///  <para>Called when the dialog has detected the user's press of the back key. The default implementation simply cancels the dialog (only if it is cancelable), but you can override this to do whatever you want. </para>        
				/// </summary>
				/// <java-name>
				/// onBackPressed
				/// </java-name>
				[Dot42.DexImport("onBackPressed", "()V", AccessFlags = 1)]
				public virtual void OnBackPressed() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Called when a key shortcut event is not handled by any of the views in the Dialog. Override this method to implement global key shortcuts for the Dialog. Key shortcuts can also be implemented by setting the shortcut property of menu items.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>True if the key shortcut was handled. </para>
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
				///  <para>Called when a touch screen event was not handled by any of the views under it. This is most useful to process touch events that happen outside of your window bounds, where there is no view to receive it.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Return true if you have consumed the event, false if you haven't. The default implementation will cancel the dialog when a touch happens outside of the window bounds. </para>
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
				///  <para>Called when the trackball was moved and not handled by any of the views inside of the activity. So, for example, if the trackball moves while focus is on a button, you will receive a call here because buttons do not normally do anything with trackball events. The call here happens  <b>before</b> trackball movements are converted to DPAD key events, which then get sent back to the view hierarchy, and will be processed at the point for things like focus navigation.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Return true if you have consumed the event, false if you haven't. The default implementation always returns false. </para>
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
				///  <para>Called when a generic motion event was not handled by any of the views inside of the dialog. </para> <para>Generic motion events describe joystick movements, mouse hovers, track pad touches, scroll wheel movements and other input events. The source of the motion event specifies the class of input that was received. Implementations of this method must examine the bits in the source before processing the event. The following code example shows how this is done. </para> <para>Generic motion events with source class android.view.InputDevice#SOURCE_CLASS_POINTER are delivered to the view under the pointer. All other generic motion events are delivered to the focused view. </para> <para>See View#onGenericMotionEvent(MotionEvent) for an example of how to handle this event. </para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Return true if you have consumed the event, false if you haven't. The default implementation always returns false. </para>
				/// </returns>
				/// <java-name>
				/// onGenericMotionEvent
				/// </java-name>
				[Dot42.DexImport("onGenericMotionEvent", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1)]
				public virtual bool OnGenericMotionEvent(global::Android.Views.MotionEvent @event) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onWindowAttributesChanged
				/// </java-name>
				[Dot42.DexImport("onWindowAttributesChanged", "(Landroid/view/WindowManager$LayoutParams;)V", AccessFlags = 1)]
				public virtual void OnWindowAttributesChanged(global::Android.Views.IWindowManager_LayoutParams @params) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>This hook is called whenever the content view of the screen changes (due to a call to Window.setContentView or Window.addContentView). </para>        
				/// </summary>
				/// <java-name>
				/// onContentChanged
				/// </java-name>
				[Dot42.DexImport("onContentChanged", "()V", AccessFlags = 1)]
				public virtual void OnContentChanged() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>This hook is called whenever the window focus changes. See View.onWindowFocusChanged(boolean) for more information.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// onWindowFocusChanged
				/// </java-name>
				[Dot42.DexImport("onWindowFocusChanged", "(Z)V", AccessFlags = 1)]
				public virtual void OnWindowFocusChanged(bool hasFocus) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Called when the window has been attached to the window manager. See View.onAttachedToWindow() for more information. </para>        
				/// </summary>
				/// <java-name>
				/// onAttachedToWindow
				/// </java-name>
				[Dot42.DexImport("onAttachedToWindow", "()V", AccessFlags = 1)]
				public virtual void OnAttachedToWindow() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Called when the window has been attached to the window manager. See View.onDetachedFromWindow() for more information. </para>        
				/// </summary>
				/// <java-name>
				/// onDetachedFromWindow
				/// </java-name>
				[Dot42.DexImport("onDetachedFromWindow", "()V", AccessFlags = 1)]
				public virtual void OnDetachedFromWindow() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Called to process key events. You can override this to intercept all key events before they are dispatched to the window. Be sure to call this implementation for key events that should be handled normally.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>boolean Return true if this event was consumed. </para>
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
				///  <para>Called to process a key shortcut event. You can override this to intercept all key shortcut events before they are dispatched to the window. Be sure to call this implementation for key shortcut events that should be handled normally.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>True if this event was consumed. </para>
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
				///  <para>Called to process touch screen events. You can override this to intercept all touch screen events before they are dispatched to the window. Be sure to call this implementation for touch screen events that should be handled normally.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>boolean Return true if this event was consumed. </para>
				/// </returns>
				/// <java-name>
				/// dispatchTouchEvent
				/// </java-name>
				[Dot42.DexImport("dispatchTouchEvent", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1)]
				public virtual bool DispatchTouchEvent(global::Android.Views.MotionEvent ev) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Called to process trackball events. You can override this to intercept all trackball events before they are dispatched to the window. Be sure to call this implementation for trackball events that should be handled normally.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>boolean Return true if this event was consumed. </para>
				/// </returns>
				/// <java-name>
				/// dispatchTrackballEvent
				/// </java-name>
				[Dot42.DexImport("dispatchTrackballEvent", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1)]
				public virtual bool DispatchTrackballEvent(global::Android.Views.MotionEvent ev) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Called to process generic motion events. You can override this to intercept all generic motion events before they are dispatched to the window. Be sure to call this implementation for generic motion events that should be handled normally.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>boolean Return true if this event was consumed. </para>
				/// </returns>
				/// <java-name>
				/// dispatchGenericMotionEvent
				/// </java-name>
				[Dot42.DexImport("dispatchGenericMotionEvent", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1)]
				public virtual bool DispatchGenericMotionEvent(global::Android.Views.MotionEvent ev) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Called to process population of AccessibilityEvents.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>boolean Return true if event population was completed. </para>
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
				///  <para> <para>Activity::onCreatePanelView(int) </para></para>        
				/// </summary>
				/// <java-name>
				/// onCreatePanelView
				/// </java-name>
				[Dot42.DexImport("onCreatePanelView", "(I)Landroid/view/View;", AccessFlags = 1)]
				public virtual global::Android.Views.View OnCreatePanelView(int featureId) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.View);
				}

				/// <summary>
				///  <para> <para>Activity::onCreatePanelMenu(int, Menu) </para></para>        
				/// </summary>
				/// <java-name>
				/// onCreatePanelMenu
				/// </java-name>
				[Dot42.DexImport("onCreatePanelMenu", "(ILandroid/view/Menu;)Z", AccessFlags = 1)]
				public virtual bool OnCreatePanelMenu(int featureId, global::Android.Views.IMenu menu) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para> <para>Activity::onPreparePanel(int, View, Menu) </para></para>        
				/// </summary>
				/// <java-name>
				/// onPreparePanel
				/// </java-name>
				[Dot42.DexImport("onPreparePanel", "(ILandroid/view/View;Landroid/view/Menu;)Z", AccessFlags = 1)]
				public virtual bool OnPreparePanel(int featureId, global::Android.Views.View view, global::Android.Views.IMenu menu) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para> <para>Activity::onMenuOpened(int, Menu) </para></para>        
				/// </summary>
				/// <java-name>
				/// onMenuOpened
				/// </java-name>
				[Dot42.DexImport("onMenuOpened", "(ILandroid/view/Menu;)Z", AccessFlags = 1)]
				public virtual bool OnMenuOpened(int featureId, global::Android.Views.IMenu menu) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para> <para>Activity::onMenuItemSelected(int, MenuItem) </para></para>        
				/// </summary>
				/// <java-name>
				/// onMenuItemSelected
				/// </java-name>
				[Dot42.DexImport("onMenuItemSelected", "(ILandroid/view/MenuItem;)Z", AccessFlags = 1)]
				public virtual bool OnMenuItemSelected(int featureId, global::Android.Views.IMenuItem item) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para> <para>Activity::onPanelClosed(int, Menu) </para></para>        
				/// </summary>
				/// <java-name>
				/// onPanelClosed
				/// </java-name>
				[Dot42.DexImport("onPanelClosed", "(ILandroid/view/Menu;)V", AccessFlags = 1)]
				public virtual void OnPanelClosed(int featureId, global::Android.Views.IMenu menu) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>It is usually safe to proxy this call to the owner activity's Activity#onCreateOptionsMenu(Menu) if the client desires the same menu for this Dialog.</para> <para> <para>Activity::onCreateOptionsMenu(Menu) </para> <para>getOwnerActivity() </para></para>        
				/// </summary>
				/// <java-name>
				/// onCreateOptionsMenu
				/// </java-name>
				[Dot42.DexImport("onCreateOptionsMenu", "(Landroid/view/Menu;)Z", AccessFlags = 1)]
				public virtual bool OnCreateOptionsMenu(global::Android.Views.IMenu menu) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>It is usually safe to proxy this call to the owner activity's Activity#onPrepareOptionsMenu(Menu) if the client desires the same menu for this Dialog.</para> <para> <para>Activity::onPrepareOptionsMenu(Menu) </para> <para>getOwnerActivity() </para></para>        
				/// </summary>
				/// <java-name>
				/// onPrepareOptionsMenu
				/// </java-name>
				[Dot42.DexImport("onPrepareOptionsMenu", "(Landroid/view/Menu;)Z", AccessFlags = 1)]
				public virtual bool OnPrepareOptionsMenu(global::Android.Views.IMenu menu) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para> <para>Activity::onOptionsItemSelected(MenuItem) </para></para>        
				/// </summary>
				/// <java-name>
				/// onOptionsItemSelected
				/// </java-name>
				[Dot42.DexImport("onOptionsItemSelected", "(Landroid/view/MenuItem;)Z", AccessFlags = 1)]
				public virtual bool OnOptionsItemSelected(global::Android.Views.IMenuItem item) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para> <para>Activity::onOptionsMenuClosed(Menu) </para></para>        
				/// </summary>
				/// <java-name>
				/// onOptionsMenuClosed
				/// </java-name>
				[Dot42.DexImport("onOptionsMenuClosed", "(Landroid/view/Menu;)V", AccessFlags = 1)]
				public virtual void OnOptionsMenuClosed(global::Android.Views.IMenu menu) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para> <para>Activity::openOptionsMenu() </para></para>        
				/// </summary>
				/// <java-name>
				/// openOptionsMenu
				/// </java-name>
				[Dot42.DexImport("openOptionsMenu", "()V", AccessFlags = 1)]
				public virtual void OpenOptionsMenu() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para> <para>Activity::closeOptionsMenu() </para></para>        
				/// </summary>
				/// <java-name>
				/// closeOptionsMenu
				/// </java-name>
				[Dot42.DexImport("closeOptionsMenu", "()V", AccessFlags = 1)]
				public virtual void CloseOptionsMenu() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para> <para>Activity::invalidateOptionsMenu() </para></para>        
				/// </summary>
				/// <java-name>
				/// invalidateOptionsMenu
				/// </java-name>
				[Dot42.DexImport("invalidateOptionsMenu", "()V", AccessFlags = 1)]
				public virtual void InvalidateOptionsMenu() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para> <para>Activity::onCreateContextMenu(ContextMenu, View, ContextMenuInfo) </para></para>        
				/// </summary>
				/// <java-name>
				/// onCreateContextMenu
				/// </java-name>
				[Dot42.DexImport("onCreateContextMenu", "(Landroid/view/ContextMenu;Landroid/view/View;Landroid/view/ContextMenu$ContextMe" +
    "nuInfo;)V", AccessFlags = 1)]
				public virtual void OnCreateContextMenu(global::Android.Views.IContextMenu menu, global::Android.Views.View v, global::Android.Views.IContextMenu_IContextMenuInfo menuInfo) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para> <para>Activity::registerForContextMenu(View) </para></para>        
				/// </summary>
				/// <java-name>
				/// registerForContextMenu
				/// </java-name>
				[Dot42.DexImport("registerForContextMenu", "(Landroid/view/View;)V", AccessFlags = 1)]
				public virtual void RegisterForContextMenu(global::Android.Views.View view) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para> <para>Activity::unregisterForContextMenu(View) </para></para>        
				/// </summary>
				/// <java-name>
				/// unregisterForContextMenu
				/// </java-name>
				[Dot42.DexImport("unregisterForContextMenu", "(Landroid/view/View;)V", AccessFlags = 1)]
				public virtual void UnregisterForContextMenu(global::Android.Views.View view) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para> <para>Activity::openContextMenu(View) </para></para>        
				/// </summary>
				/// <java-name>
				/// openContextMenu
				/// </java-name>
				[Dot42.DexImport("openContextMenu", "(Landroid/view/View;)V", AccessFlags = 1)]
				public virtual void OpenContextMenu(global::Android.Views.View view) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para> <para>Activity::onContextItemSelected(MenuItem) </para></para>        
				/// </summary>
				/// <java-name>
				/// onContextItemSelected
				/// </java-name>
				[Dot42.DexImport("onContextItemSelected", "(Landroid/view/MenuItem;)Z", AccessFlags = 1)]
				public virtual bool OnContextItemSelected(global::Android.Views.IMenuItem item) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para> <para>Activity::onContextMenuClosed(Menu) </para></para>        
				/// </summary>
				/// <java-name>
				/// onContextMenuClosed
				/// </java-name>
				[Dot42.DexImport("onContextMenuClosed", "(Landroid/view/Menu;)V", AccessFlags = 1)]
				public virtual void OnContextMenuClosed(global::Android.Views.IMenu menu) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>This hook is called when the user signals the desire to start a search. </para>        
				/// </summary>
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
				public virtual global::Android.Views.ActionMode OnWindowStartingActionMode(global::Android.Views.ActionMode.ICallback callback) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.ActionMode);
				}

				/// <summary>
				///  <para> <para>Called when an action mode has been started. The appropriate mode callback method will have already been invoked.</para> <para></para></para> <para>Note that if you override this method you should always call through to the superclass implementation by calling super.onActionModeStarted(mode). </para>        
				/// </summary>
				/// <java-name>
				/// onActionModeStarted
				/// </java-name>
				[Dot42.DexImport("onActionModeStarted", "(Landroid/view/ActionMode;)V", AccessFlags = 1)]
				public virtual void OnActionModeStarted(global::Android.Views.ActionMode mode) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para> <para>Called when an action mode has been finished. The appropriate mode callback method will have already been invoked.</para> <para></para></para> <para>Note that if you override this method you should always call through to the superclass implementation by calling super.onActionModeFinished(mode). </para>        
				/// </summary>
				/// <java-name>
				/// onActionModeFinished
				/// </java-name>
				[Dot42.DexImport("onActionModeFinished", "(Landroid/view/ActionMode;)V", AccessFlags = 1)]
				public virtual void OnActionModeFinished(global::Android.Views.ActionMode mode) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Request that key events come to this dialog. Use this if your dialog has no views with focus, but the dialog still wants a chance to process key events.</para> <para> <para>android.view.Window::takeKeyEvents </para></para>        
				/// </summary>
				/// <java-name>
				/// takeKeyEvents
				/// </java-name>
				[Dot42.DexImport("takeKeyEvents", "(Z)V", AccessFlags = 1)]
				public virtual void TakeKeyEvents(bool get) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Enable extended window features. This is a convenience for calling getWindow().requestFeature().</para> <para> <para>android.view.Window::requestFeature </para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns true if the requested feature is supported and now enabled.</para>
				/// </returns>
				/// <java-name>
				/// requestWindowFeature
				/// </java-name>
				[Dot42.DexImport("requestWindowFeature", "(I)Z", AccessFlags = 17)]
				public bool RequestWindowFeature(int featureId) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Convenience for calling android.view.Window#setFeatureDrawableResource. </para>        
				/// </summary>
				/// <java-name>
				/// setFeatureDrawableResource
				/// </java-name>
				[Dot42.DexImport("setFeatureDrawableResource", "(II)V", AccessFlags = 17)]
				public void SetFeatureDrawableResource(int featureId, int resId) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Convenience for calling android.view.Window#setFeatureDrawableUri. </para>        
				/// </summary>
				/// <java-name>
				/// setFeatureDrawableUri
				/// </java-name>
				[Dot42.DexImport("setFeatureDrawableUri", "(ILandroid/net/Uri;)V", AccessFlags = 17)]
				public void SetFeatureDrawableUri(int featureId, global::Android.Net.Uri uri) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Convenience for calling android.view.Window#setFeatureDrawable(int, Drawable). </para>        
				/// </summary>
				/// <java-name>
				/// setFeatureDrawable
				/// </java-name>
				[Dot42.DexImport("setFeatureDrawable", "(ILandroid/graphics/drawable/Drawable;)V", AccessFlags = 17)]
				public void SetFeatureDrawable(int featureId, global::Android.Graphics.Drawables.Drawable drawable) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Convenience for calling android.view.Window#setFeatureDrawableAlpha. </para>        
				/// </summary>
				/// <java-name>
				/// setFeatureDrawableAlpha
				/// </java-name>
				[Dot42.DexImport("setFeatureDrawableAlpha", "(II)V", AccessFlags = 17)]
				public void SetFeatureDrawableAlpha(int featureId, int alpha) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets whether this dialog is cancelable with the BACK key. </para>        
				/// </summary>
				/// <java-name>
				/// setCancelable
				/// </java-name>
				[Dot42.DexImport("setCancelable", "(Z)V", AccessFlags = 1)]
				public virtual void SetCancelable(bool flag) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets whether this dialog is canceled when touched outside the window's bounds. If setting to true, the dialog is set to be cancelable if not already set.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setCanceledOnTouchOutside
				/// </java-name>
				[Dot42.DexImport("setCanceledOnTouchOutside", "(Z)V", AccessFlags = 1)]
				public virtual void SetCanceledOnTouchOutside(bool cancel) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Cancel the dialog. This is essentially the same as calling dismiss(), but it will also call your DialogInterface.OnCancelListener (if registered). </para>        
				/// </summary>
				/// <java-name>
				/// cancel
				/// </java-name>
				[Dot42.DexImport("cancel", "()V", AccessFlags = 1)]
				public virtual void Cancel() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Set a listener to be invoked when the dialog is canceled.</para> <para>This will only be invoked when the dialog is canceled. Cancel events alone will not capture all ways that the dialog might be dismissed. If the creator needs to know when a dialog is dismissed in general, use setOnDismissListener.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setOnCancelListener
				/// </java-name>
				[Dot42.DexImport("setOnCancelListener", "(Landroid/content/DialogInterface$OnCancelListener;)V", AccessFlags = 1)]
				public virtual void SetOnCancelListener(global::Android.Content.IDialogInterface_IOnCancelListener listener) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Set a message to be sent when the dialog is canceled.  <para>setOnCancelListener(android.content.DialogInterface.OnCancelListener) </para></para>        
				/// </summary>
				/// <java-name>
				/// setCancelMessage
				/// </java-name>
				[Dot42.DexImport("setCancelMessage", "(Landroid/os/Message;)V", AccessFlags = 1)]
				public virtual void SetCancelMessage(global::Android.OS.Message msg) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Set a listener to be invoked when the dialog is dismissed. </para>        
				/// </summary>
				/// <java-name>
				/// setOnDismissListener
				/// </java-name>
				[Dot42.DexImport("setOnDismissListener", "(Landroid/content/DialogInterface$OnDismissListener;)V", AccessFlags = 1)]
				public virtual void SetOnDismissListener(global::Android.Content.IDialogInterface_IOnDismissListener listener) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets a listener to be invoked when the dialog is shown. </para>        
				/// </summary>
				/// <java-name>
				/// setOnShowListener
				/// </java-name>
				[Dot42.DexImport("setOnShowListener", "(Landroid/content/DialogInterface$OnShowListener;)V", AccessFlags = 1)]
				public virtual void SetOnShowListener(global::Android.Content.IDialogInterface_IOnShowListener listener) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Set a message to be sent when the dialog is dismissed. </para>        
				/// </summary>
				/// <java-name>
				/// setDismissMessage
				/// </java-name>
				[Dot42.DexImport("setDismissMessage", "(Landroid/os/Message;)V", AccessFlags = 1)]
				public virtual void SetDismissMessage(global::Android.OS.Message msg) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the callback that will be called if a key is dispatched to the dialog. </para>        
				/// </summary>
				/// <java-name>
				/// setOnKeyListener
				/// </java-name>
				[Dot42.DexImport("setOnKeyListener", "(Landroid/content/DialogInterface$OnKeyListener;)V", AccessFlags = 1)]
				public virtual void SetOnKeyListener(global::Android.Content.IDialogInterface_IOnKeyListener onKeyListener) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal Dialog() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Retrieve the Context this Dialog is running in.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Context The Context used by the Dialog. </para>
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
				///  <para>Retrieve the ActionBar attached to this dialog, if present.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The ActionBar attached to the dialog or null if no ActionBar is present. </para>
				/// </returns>
				/// <java-name>
				/// getActionBar
				/// </java-name>
				public virtual global::Android.App.ActionBar ActionBar
				{
						[Dot42.DexImport("getActionBar", "()Landroid/app/ActionBar;", AccessFlags = 1)]
						get{ return default(global::Android.App.ActionBar); }
				}

				/// <summary>
				///  <para>Returns the Activity that owns this Dialog. For example, if Activity#showDialog(int) is used to show this Dialog, that Activity will be the owner (by default). Depending on how this dialog was created, this may return null.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The Activity that owns this Dialog. </para>
				/// </returns>
				/// <java-name>
				/// getOwnerActivity
				/// </java-name>
				public global::Android.App.Activity OwnerActivity
				{
						[Dot42.DexImport("getOwnerActivity", "()Landroid/app/Activity;", AccessFlags = 17)]
						get{ return default(global::Android.App.Activity); }
						[Dot42.DexImport("setOwnerActivity", "(Landroid/app/Activity;)V", AccessFlags = 17)]
						set{ }
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Whether the dialog is currently showing. </para>
				/// </returns>
				/// <java-name>
				/// isShowing
				/// </java-name>
				public virtual bool IsShowing
				{
						[Dot42.DexImport("isShowing", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Retrieve the current Window for the activity. This can be used to directly access parts of the Window API that are not available through Activity/Screen.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Window The current window, or null if the activity is not visual. </para>
				/// </returns>
				/// <java-name>
				/// getWindow
				/// </java-name>
				public virtual global::Android.Views.Window Window
				{
						[Dot42.DexImport("getWindow", "()Landroid/view/Window;", AccessFlags = 1)]
						get{ return default(global::Android.Views.Window); }
				}

				/// <summary>
				///  <para>Call android.view.Window#getCurrentFocus on the Window if this Activity to return the currently focused view.</para> <para> <para>getWindow </para> <para>android.view.Window::getCurrentFocus </para></para>        
				/// </summary>
				/// <returns>
				///  <para>View The current View with focus or null.</para>
				/// </returns>
				/// <java-name>
				/// getCurrentFocus
				/// </java-name>
				public virtual global::Android.Views.View CurrentFocus
				{
						[Dot42.DexImport("getCurrentFocus", "()Landroid/view/View;", AccessFlags = 1)]
						get{ return default(global::Android.Views.View); }
				}

				/// <java-name>
				/// getLayoutInflater
				/// </java-name>
				public virtual global::Android.Views.LayoutInflater LayoutInflater
				{
						[Dot42.DexImport("getLayoutInflater", "()Landroid/view/LayoutInflater;", AccessFlags = 1)]
						get{ return default(global::Android.Views.LayoutInflater); }
				}

				/// <summary>
				///  <para> <para>Activity::getVolumeControlStream() </para></para>        
				/// </summary>
				/// <java-name>
				/// getVolumeControlStream
				/// </java-name>
				public int VolumeControlStream
				{
						[Dot42.DexImport("getVolumeControlStream", "()I", AccessFlags = 17)]
						get{ return default(int); }
						[Dot42.DexImport("setVolumeControlStream", "(I)V", AccessFlags = 17)]
						set{ }
				}

		}

		/// <summary>
		///  <para>A fragment that displays a dialog window, floating on top of its activity's window. This fragment contains a Dialog object, which it displays as appropriate based on the fragment's state. Control of the dialog (deciding when to show, hide, dismiss it) should be done through the API here, not with direct calls on the dialog.</para> <para>Implementations should override this class and implement onCreateView(LayoutInflater, ViewGroup, Bundle) to supply the content of the dialog. Alternatively, they can override onCreateDialog(Bundle) to create an entirely custom dialog, such as an AlertDialog, with its own content.</para> <para>Topics covered here:  <ol> <li> <para> </para></li> <li> <para> </para></li> <li> <para> </para></li> <li> <para> </para></li></ol></para> <para>  <h3>Lifecycle</h3></para> <para>DialogFragment does various things to keep the fragment's lifecycle driving it, instead of the Dialog. Note that dialogs are generally autonomous entities  they are their own window, receiving their own input events, and often deciding on their own when to disappear (by receiving a back key event or the user clicking on a button).</para> <para>DialogFragment needs to ensure that what is happening with the Fragment and Dialog states remains consistent. To do this, it watches for dismiss events from the dialog and takes care of removing its own state when they happen. This means you should use show(FragmentManager, String) or show(FragmentTransaction, String) to add an instance of DialogFragment to your UI, as these keep track of how DialogFragment should remove itself when the dialog is dismissed.</para> <para>  <h3>Basic Dialog</h3></para> <para>The simplest use of DialogFragment is as a floating container for the fragment's view hierarchy. A simple implementation may look like this:</para> <para>{ development/samples/ApiDemos/src/com/example/android/apis/app/FragmentDialog.java dialog}</para> <para>An example showDialog() method on the Activity could be:</para> <para>{ development/samples/ApiDemos/src/com/example/android/apis/app/FragmentDialog.java add_dialog}</para> <para>This removes any currently shown dialog, creates a new DialogFragment with an argument, and shows it as a new state on the back stack. When the transaction is popped, the current DialogFragment and its Dialog will be destroyed, and the previous one (if any) re-shown. Note that in this case DialogFragment will take care of popping the transaction of the Dialog is dismissed separately from it.</para> <para>  <h3>Alert Dialog</h3></para> <para>Instead of (or in addition to) implementing onCreateView to generate the view hierarchy inside of a dialog, you may implement onCreateDialog(Bundle) to create your own custom Dialog object.</para> <para>This is most useful for creating an AlertDialog, allowing you to display standard alerts to the user that are managed by a fragment. A simple example implementation of this is:</para> <para>{ development/samples/ApiDemos/src/com/example/android/apis/app/FragmentAlertDialog.java dialog}</para> <para>The activity creating this fragment may have the following methods to show the dialog and receive results from it:</para> <para>{ development/samples/ApiDemos/src/com/example/android/apis/app/FragmentAlertDialog.java activity}</para> <para>Note that in this case the fragment is not placed on the back stack, it is just added as an indefinitely running fragment. Because dialogs normally are modal, this will still operate as a back stack, since the dialog will capture user input until it is dismissed. When it is dismissed, DialogFragment will take care of removing itself from its fragment manager.</para> <para>  <h3>Selecting Between Dialog or Embedding</h3></para> <para>A DialogFragment can still optionally be used as a normal fragment, if desired. This is useful if you have a fragment that in some cases should be shown as a dialog and others embedded in a larger UI. This behavior will normally be automatically selected for you based on how you are using the fragment, but can be customized with setShowsDialog(boolean).</para> <para>For example, here is a simple dialog fragment:</para> <para>{ development/samples/ApiDemos/src/com/example/android/apis/app/FragmentDialogOrActivity.java dialog}</para> <para>An instance of this fragment can be created and shown as a dialog:</para> <para>{ development/samples/ApiDemos/src/com/example/android/apis/app/FragmentDialogOrActivity.java show_dialog}</para> <para>It can also be added as content in a view hierarchy:</para> <para>{ development/samples/ApiDemos/src/com/example/android/apis/app/FragmentDialogOrActivity.java embed} </para>    
		/// </summary>
		/// <java-name>
		/// android/app/DialogFragment
		/// </java-name>
		[Dot42.DexImport("android/app/DialogFragment", AccessFlags = 33)]
		public partial class DialogFragment : global::Android.App.Fragment, global::Android.Content.IDialogInterface_IOnCancelListener, global::Android.Content.IDialogInterface_IOnDismissListener
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Style for setStyle(int, int): a basic, normal dialog. </para>        
				/// </summary>
				/// <java-name>
				/// STYLE_NORMAL
				/// </java-name>
				[Dot42.DexImport("STYLE_NORMAL", "I", AccessFlags = 25)]
				public const int STYLE_NORMAL = 0;
				/// <summary>
				///  <para>Style for setStyle(int, int): don't include a title area. </para>        
				/// </summary>
				/// <java-name>
				/// STYLE_NO_TITLE
				/// </java-name>
				[Dot42.DexImport("STYLE_NO_TITLE", "I", AccessFlags = 25)]
				public const int STYLE_NO_TITLE = 1;
				/// <summary>
				///  <para>Style for setStyle(int, int): don't draw any frame at all; the view hierarchy returned by onCreateView is entirely responsible for drawing the dialog. </para>        
				/// </summary>
				/// <java-name>
				/// STYLE_NO_FRAME
				/// </java-name>
				[Dot42.DexImport("STYLE_NO_FRAME", "I", AccessFlags = 25)]
				public const int STYLE_NO_FRAME = 2;
				/// <summary>
				///  <para>Style for setStyle(int, int): like STYLE_NO_FRAME, but also disables all input to the dialog. The user can not touch it, and its window will not receive input focus. </para>        
				/// </summary>
				/// <java-name>
				/// STYLE_NO_INPUT
				/// </java-name>
				[Dot42.DexImport("STYLE_NO_INPUT", "I", AccessFlags = 25)]
				public const int STYLE_NO_INPUT = 3;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public DialogFragment() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Call to customize the basic appearance and behavior of the fragment's dialog. This can be used for some common dialog behaviors, taking care of selecting flags, theme, and other options for you. The same effect can be achieve by manually setting Dialog and Window attributes yourself. Calling this after the fragment's Dialog is created will have no effect.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setStyle
				/// </java-name>
				[Dot42.DexImport("setStyle", "(II)V", AccessFlags = 1)]
				public virtual void SetStyle(int style, int theme) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// show
				/// </java-name>
				[Dot42.DexImport("show", "(Landroid/app/FragmentManager;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void Show(global::Android.App.FragmentManager fragmentManager, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// show
				/// </java-name>
				[Dot42.DexImport("show", "(Landroid/app/FragmentTransaction;Ljava/lang/String;)I", AccessFlags = 1)]
				public virtual int Show(global::Android.App.FragmentTransaction fragmentTransaction, string @string) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Dismiss the fragment and its dialog. If the fragment was added to the back stack, all back stack state up to and including this entry will be popped. Otherwise, a new transaction will be committed to remove the fragment. </para>        
				/// </summary>
				/// <java-name>
				/// dismiss
				/// </java-name>
				[Dot42.DexImport("dismiss", "()V", AccessFlags = 1)]
				public virtual void Dismiss() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Version of dismiss() that uses FragmentTransaction.commitAllowingStateLoss(). See linked documentation for further details. </para>        
				/// </summary>
				/// <java-name>
				/// dismissAllowingStateLoss
				/// </java-name>
				[Dot42.DexImport("dismissAllowingStateLoss", "()V", AccessFlags = 1)]
				public virtual void DismissAllowingStateLoss() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onAttach
				/// </java-name>
				[Dot42.DexImport("onAttach", "(Landroid/app/Activity;)V", AccessFlags = 1)]
				public override void OnAttach(global::Android.App.Activity activity) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onDetach
				/// </java-name>
				[Dot42.DexImport("onDetach", "()V", AccessFlags = 1)]
				public override void OnDetach() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onCreate
				/// </java-name>
				[Dot42.DexImport("onCreate", "(Landroid/os/Bundle;)V", AccessFlags = 1)]
				public override void OnCreate(global::Android.OS.Bundle savedInstanceState) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Override to build your own custom Dialog container. This is typically used to show an AlertDialog instead of a generic Dialog; when doing so, onCreateView(LayoutInflater, ViewGroup, Bundle) does not need to be implemented since the AlertDialog takes care of its own content.</para> <para>This method will be called after onCreate(Bundle) and before onCreateView(LayoutInflater, ViewGroup, Bundle). The default implementation simply instantiates and returns a Dialog class.</para> <para> <b>Note: DialogFragment own the Dialog.setOnCancelListener and Dialog.setOnDismissListener callbacks. You must not set them yourself.</b> To find out about these events, override onCancel(DialogInterface) and onDismiss(DialogInterface).</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Return a new Dialog instance to be displayed by the Fragment. </para>
				/// </returns>
				/// <java-name>
				/// onCreateDialog
				/// </java-name>
				[Dot42.DexImport("onCreateDialog", "(Landroid/os/Bundle;)Landroid/app/Dialog;", AccessFlags = 1)]
				public virtual global::Android.App.Dialog OnCreateDialog(global::Android.OS.Bundle savedInstanceState) /* MethodBuilder.Create */ 
				{
						return default(global::Android.App.Dialog);
				}

				/// <summary>
				///  <para>This method will be invoked when the dialog is canceled.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// onCancel
				/// </java-name>
				[Dot42.DexImport("onCancel", "(Landroid/content/DialogInterface;)V", AccessFlags = 1)]
				public virtual void OnCancel(global::Android.Content.IDialogInterface dialog) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>This method will be invoked when the dialog is dismissed.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// onDismiss
				/// </java-name>
				[Dot42.DexImport("onDismiss", "(Landroid/content/DialogInterface;)V", AccessFlags = 1)]
				public virtual void OnDismiss(global::Android.Content.IDialogInterface dialog) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onActivityCreated
				/// </java-name>
				[Dot42.DexImport("onActivityCreated", "(Landroid/os/Bundle;)V", AccessFlags = 1)]
				public override void OnActivityCreated(global::Android.OS.Bundle savedInstanceState) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onStart
				/// </java-name>
				[Dot42.DexImport("onStart", "()V", AccessFlags = 1)]
				public override void OnStart() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onSaveInstanceState
				/// </java-name>
				[Dot42.DexImport("onSaveInstanceState", "(Landroid/os/Bundle;)V", AccessFlags = 1)]
				public override void OnSaveInstanceState(global::Android.OS.Bundle outState) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onStop
				/// </java-name>
				[Dot42.DexImport("onStop", "()V", AccessFlags = 1)]
				public override void OnStop() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Remove dialog. </para>        
				/// </summary>
				/// <java-name>
				/// onDestroyView
				/// </java-name>
				[Dot42.DexImport("onDestroyView", "()V", AccessFlags = 1)]
				public override void OnDestroyView() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// dump
				/// </java-name>
				[Dot42.DexImport("dump", "(Ljava/lang/String;Ljava/io/FileDescriptor;Ljava/io/PrintWriter;[Ljava/lang/Strin" +
    "g;)V", AccessFlags = 1)]
				public override void Dump(string prefix, global::Java.IO.FileDescriptor fd, global::Java.IO.PrintWriter writer, string[] args) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getDialog
				/// </java-name>
				public virtual global::Android.App.Dialog Dialog
				{
						[Dot42.DexImport("getDialog", "()Landroid/app/Dialog;", AccessFlags = 1)]
						get{ return default(global::Android.App.Dialog); }
				}

				/// <java-name>
				/// getTheme
				/// </java-name>
				public virtual int Theme
				{
						[Dot42.DexImport("getTheme", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Return the current value of setCancelable(boolean). </para>        
				/// </summary>
				/// <java-name>
				/// isCancelable
				/// </java-name>
				public virtual bool IsCancelable
				{
						[Dot42.DexImport("isCancelable", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setCancelable", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Return the current value of setShowsDialog(boolean). </para>        
				/// </summary>
				/// <java-name>
				/// getShowsDialog
				/// </java-name>
				public virtual bool ShowsDialog
				{
						[Dot42.DexImport("getShowsDialog", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setShowsDialog", "(Z)V", AccessFlags = 1)]
						set{ }
				}

		}

		/// <summary>
		///  <para>The download manager is a system service that handles long-running HTTP downloads. Clients may request that a URI be downloaded to a particular destination file. The download manager will conduct the download in the background, taking care of HTTP interactions and retrying downloads after failures or across connectivity changes and system reboots.</para> <para>Instances of this class should be obtained through android.content.Context#getSystemService(String) by passing android.content.Context#DOWNLOAD_SERVICE.</para> <para>Apps that request downloads through this API should register a broadcast receiver for ACTION_NOTIFICATION_CLICKED to appropriately handle when the user clicks on a running download in a notification or from the downloads UI.</para> <para>Note that the application must have the android.Manifest.permission#INTERNET permission to use this class. </para>    
		/// </summary>
		/// <java-name>
		/// android/app/DownloadManager
		/// </java-name>
		[Dot42.DexImport("android/app/DownloadManager", AccessFlags = 33)]
		public partial class DownloadManager
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>An identifier for a particular download, unique across the system. Clients use this ID to make subsequent calls related to the download. </para>        
				/// </summary>
				/// <java-name>
				/// COLUMN_ID
				/// </java-name>
				[Dot42.DexImport("COLUMN_ID", "Ljava/lang/String;", AccessFlags = 25)]
				public const string COLUMN_ID = "_id";
				/// <summary>
				///  <para>The client-supplied title for this download. This will be displayed in system notifications. Defaults to the empty string. </para>        
				/// </summary>
				/// <java-name>
				/// COLUMN_TITLE
				/// </java-name>
				[Dot42.DexImport("COLUMN_TITLE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string COLUMN_TITLE = "title";
				/// <summary>
				///  <para>The client-supplied description of this download. This will be displayed in system notifications. Defaults to the empty string. </para>        
				/// </summary>
				/// <java-name>
				/// COLUMN_DESCRIPTION
				/// </java-name>
				[Dot42.DexImport("COLUMN_DESCRIPTION", "Ljava/lang/String;", AccessFlags = 25)]
				public const string COLUMN_DESCRIPTION = "description";
				/// <summary>
				///  <para>URI to be downloaded. </para>        
				/// </summary>
				/// <java-name>
				/// COLUMN_URI
				/// </java-name>
				[Dot42.DexImport("COLUMN_URI", "Ljava/lang/String;", AccessFlags = 25)]
				public const string COLUMN_URI = "uri";
				/// <summary>
				///  <para>Internet Media Type of the downloaded file. If no value is provided upon creation, this will initially be null and will be filled in based on the server's response once the download has started.</para> <para> <para> </para></para>        
				/// </summary>
				/// <java-name>
				/// COLUMN_MEDIA_TYPE
				/// </java-name>
				[Dot42.DexImport("COLUMN_MEDIA_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string COLUMN_MEDIA_TYPE = "media_type";
				/// <summary>
				///  <para>Total size of the download in bytes. This will initially be -1 and will be filled in once the download starts. </para>        
				/// </summary>
				/// <java-name>
				/// COLUMN_TOTAL_SIZE_BYTES
				/// </java-name>
				[Dot42.DexImport("COLUMN_TOTAL_SIZE_BYTES", "Ljava/lang/String;", AccessFlags = 25)]
				public const string COLUMN_TOTAL_SIZE_BYTES = "total_size";
				/// <summary>
				///  <para>Uri where downloaded file will be stored. If a destination is supplied by client, that URI will be used here. Otherwise, the value will initially be null and will be filled in with a generated URI once the download has started. </para>        
				/// </summary>
				/// <java-name>
				/// COLUMN_LOCAL_URI
				/// </java-name>
				[Dot42.DexImport("COLUMN_LOCAL_URI", "Ljava/lang/String;", AccessFlags = 25)]
				public const string COLUMN_LOCAL_URI = "local_uri";
				/// <summary>
				///  <para>The pathname of the file where the download is stored. </para>        
				/// </summary>
				/// <java-name>
				/// COLUMN_LOCAL_FILENAME
				/// </java-name>
				[Dot42.DexImport("COLUMN_LOCAL_FILENAME", "Ljava/lang/String;", AccessFlags = 25)]
				public const string COLUMN_LOCAL_FILENAME = "local_filename";
				/// <summary>
				///  <para>Current status of the download, as one of the STATUS_* constants. </para>        
				/// </summary>
				/// <java-name>
				/// COLUMN_STATUS
				/// </java-name>
				[Dot42.DexImport("COLUMN_STATUS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string COLUMN_STATUS = "status";
				/// <summary>
				///  <para>Provides more detail on the status of the download. Its meaning depends on the value of COLUMN_STATUS.</para> <para>When COLUMN_STATUS is STATUS_FAILED, this indicates the type of error that occurred. If an HTTP error occurred, this will hold the HTTP status code as defined in RFC 2616. Otherwise, it will hold one of the ERROR_* constants.</para> <para>When COLUMN_STATUS is STATUS_PAUSED, this indicates why the download is paused. It will hold one of the PAUSED_* constants.</para> <para>If COLUMN_STATUS is neither STATUS_FAILED nor STATUS_PAUSED, this column's value is undefined.</para> <para> <para> </para></para>        
				/// </summary>
				/// <java-name>
				/// COLUMN_REASON
				/// </java-name>
				[Dot42.DexImport("COLUMN_REASON", "Ljava/lang/String;", AccessFlags = 25)]
				public const string COLUMN_REASON = "reason";
				/// <summary>
				///  <para>Number of bytes download so far. </para>        
				/// </summary>
				/// <java-name>
				/// COLUMN_BYTES_DOWNLOADED_SO_FAR
				/// </java-name>
				[Dot42.DexImport("COLUMN_BYTES_DOWNLOADED_SO_FAR", "Ljava/lang/String;", AccessFlags = 25)]
				public const string COLUMN_BYTES_DOWNLOADED_SO_FAR = "bytes_so_far";
				/// <summary>
				///  <para>Timestamp when the download was last modified, in System.currentTimeMillis() (wall clock time in UTC). </para>        
				/// </summary>
				/// <java-name>
				/// COLUMN_LAST_MODIFIED_TIMESTAMP
				/// </java-name>
				[Dot42.DexImport("COLUMN_LAST_MODIFIED_TIMESTAMP", "Ljava/lang/String;", AccessFlags = 25)]
				public const string COLUMN_LAST_MODIFIED_TIMESTAMP = "last_modified_timestamp";
				/// <summary>
				///  <para>The URI to the corresponding entry in MediaProvider for this downloaded entry. It is used to delete the entries from MediaProvider database when it is deleted from the downloaded list. </para>        
				/// </summary>
				/// <java-name>
				/// COLUMN_MEDIAPROVIDER_URI
				/// </java-name>
				[Dot42.DexImport("COLUMN_MEDIAPROVIDER_URI", "Ljava/lang/String;", AccessFlags = 25)]
				public const string COLUMN_MEDIAPROVIDER_URI = "mediaprovider_uri";
				/// <summary>
				///  <para>Value of COLUMN_STATUS when the download is waiting to start. </para>        
				/// </summary>
				/// <java-name>
				/// STATUS_PENDING
				/// </java-name>
				[Dot42.DexImport("STATUS_PENDING", "I", AccessFlags = 25)]
				public const int STATUS_PENDING = 1;
				/// <summary>
				///  <para>Value of COLUMN_STATUS when the download is currently running. </para>        
				/// </summary>
				/// <java-name>
				/// STATUS_RUNNING
				/// </java-name>
				[Dot42.DexImport("STATUS_RUNNING", "I", AccessFlags = 25)]
				public const int STATUS_RUNNING = 2;
				/// <summary>
				///  <para>Value of COLUMN_STATUS when the download is waiting to retry or resume. </para>        
				/// </summary>
				/// <java-name>
				/// STATUS_PAUSED
				/// </java-name>
				[Dot42.DexImport("STATUS_PAUSED", "I", AccessFlags = 25)]
				public const int STATUS_PAUSED = 4;
				/// <summary>
				///  <para>Value of COLUMN_STATUS when the download has successfully completed. </para>        
				/// </summary>
				/// <java-name>
				/// STATUS_SUCCESSFUL
				/// </java-name>
				[Dot42.DexImport("STATUS_SUCCESSFUL", "I", AccessFlags = 25)]
				public const int STATUS_SUCCESSFUL = 8;
				/// <summary>
				///  <para>Value of COLUMN_STATUS when the download has failed (and will not be retried). </para>        
				/// </summary>
				/// <java-name>
				/// STATUS_FAILED
				/// </java-name>
				[Dot42.DexImport("STATUS_FAILED", "I", AccessFlags = 25)]
				public const int STATUS_FAILED = 16;
				/// <summary>
				///  <para>Value of COLUMN_ERROR_CODE when the download has completed with an error that doesn't fit under any other error code. </para>        
				/// </summary>
				/// <java-name>
				/// ERROR_UNKNOWN
				/// </java-name>
				[Dot42.DexImport("ERROR_UNKNOWN", "I", AccessFlags = 25)]
				public const int ERROR_UNKNOWN = 1000;
				/// <summary>
				///  <para>Value of COLUMN_REASON when a storage issue arises which doesn't fit under any other error code. Use the more specific ERROR_INSUFFICIENT_SPACE and ERROR_DEVICE_NOT_FOUND when appropriate. </para>        
				/// </summary>
				/// <java-name>
				/// ERROR_FILE_ERROR
				/// </java-name>
				[Dot42.DexImport("ERROR_FILE_ERROR", "I", AccessFlags = 25)]
				public const int ERROR_FILE_ERROR = 1001;
				/// <summary>
				///  <para>Value of COLUMN_REASON when an HTTP code was received that download manager can't handle. </para>        
				/// </summary>
				/// <java-name>
				/// ERROR_UNHANDLED_HTTP_CODE
				/// </java-name>
				[Dot42.DexImport("ERROR_UNHANDLED_HTTP_CODE", "I", AccessFlags = 25)]
				public const int ERROR_UNHANDLED_HTTP_CODE = 1002;
				/// <summary>
				///  <para>Value of COLUMN_REASON when an error receiving or processing data occurred at the HTTP level. </para>        
				/// </summary>
				/// <java-name>
				/// ERROR_HTTP_DATA_ERROR
				/// </java-name>
				[Dot42.DexImport("ERROR_HTTP_DATA_ERROR", "I", AccessFlags = 25)]
				public const int ERROR_HTTP_DATA_ERROR = 1004;
				/// <summary>
				///  <para>Value of COLUMN_REASON when there were too many redirects. </para>        
				/// </summary>
				/// <java-name>
				/// ERROR_TOO_MANY_REDIRECTS
				/// </java-name>
				[Dot42.DexImport("ERROR_TOO_MANY_REDIRECTS", "I", AccessFlags = 25)]
				public const int ERROR_TOO_MANY_REDIRECTS = 1005;
				/// <summary>
				///  <para>Value of COLUMN_REASON when there was insufficient storage space. Typically, this is because the SD card is full. </para>        
				/// </summary>
				/// <java-name>
				/// ERROR_INSUFFICIENT_SPACE
				/// </java-name>
				[Dot42.DexImport("ERROR_INSUFFICIENT_SPACE", "I", AccessFlags = 25)]
				public const int ERROR_INSUFFICIENT_SPACE = 1006;
				/// <summary>
				///  <para>Value of COLUMN_REASON when no external storage device was found. Typically, this is because the SD card is not mounted. </para>        
				/// </summary>
				/// <java-name>
				/// ERROR_DEVICE_NOT_FOUND
				/// </java-name>
				[Dot42.DexImport("ERROR_DEVICE_NOT_FOUND", "I", AccessFlags = 25)]
				public const int ERROR_DEVICE_NOT_FOUND = 1007;
				/// <summary>
				///  <para>Value of COLUMN_REASON when some possibly transient error occurred but we can't resume the download. </para>        
				/// </summary>
				/// <java-name>
				/// ERROR_CANNOT_RESUME
				/// </java-name>
				[Dot42.DexImport("ERROR_CANNOT_RESUME", "I", AccessFlags = 25)]
				public const int ERROR_CANNOT_RESUME = 1008;
				/// <summary>
				///  <para>Value of COLUMN_REASON when the requested destination file already exists (the download manager will not overwrite an existing file). </para>        
				/// </summary>
				/// <java-name>
				/// ERROR_FILE_ALREADY_EXISTS
				/// </java-name>
				[Dot42.DexImport("ERROR_FILE_ALREADY_EXISTS", "I", AccessFlags = 25)]
				public const int ERROR_FILE_ALREADY_EXISTS = 1009;
				/// <summary>
				///  <para>Value of COLUMN_REASON when the download is paused because some network error occurred and the download manager is waiting before retrying the request. </para>        
				/// </summary>
				/// <java-name>
				/// PAUSED_WAITING_TO_RETRY
				/// </java-name>
				[Dot42.DexImport("PAUSED_WAITING_TO_RETRY", "I", AccessFlags = 25)]
				public const int PAUSED_WAITING_TO_RETRY = 1;
				/// <summary>
				///  <para>Value of COLUMN_REASON when the download is waiting for network connectivity to proceed. </para>        
				/// </summary>
				/// <java-name>
				/// PAUSED_WAITING_FOR_NETWORK
				/// </java-name>
				[Dot42.DexImport("PAUSED_WAITING_FOR_NETWORK", "I", AccessFlags = 25)]
				public const int PAUSED_WAITING_FOR_NETWORK = 2;
				/// <summary>
				///  <para>Value of COLUMN_REASON when the download exceeds a size limit for downloads over the mobile network and the download manager is waiting for a Wi-Fi connection to proceed. </para>        
				/// </summary>
				/// <java-name>
				/// PAUSED_QUEUED_FOR_WIFI
				/// </java-name>
				[Dot42.DexImport("PAUSED_QUEUED_FOR_WIFI", "I", AccessFlags = 25)]
				public const int PAUSED_QUEUED_FOR_WIFI = 3;
				/// <summary>
				///  <para>Value of COLUMN_REASON when the download is paused for some other reason. </para>        
				/// </summary>
				/// <java-name>
				/// PAUSED_UNKNOWN
				/// </java-name>
				[Dot42.DexImport("PAUSED_UNKNOWN", "I", AccessFlags = 25)]
				public const int PAUSED_UNKNOWN = 4;
				/// <summary>
				///  <para>Broadcast intent action sent by the download manager when a download completes. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_DOWNLOAD_COMPLETE
				/// </java-name>
				[Dot42.DexImport("ACTION_DOWNLOAD_COMPLETE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_DOWNLOAD_COMPLETE = "android.intent.action.DOWNLOAD_COMPLETE";
				/// <summary>
				///  <para>Broadcast intent action sent by the download manager when the user clicks on a running download, either from a system notification or from the downloads UI. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_NOTIFICATION_CLICKED
				/// </java-name>
				[Dot42.DexImport("ACTION_NOTIFICATION_CLICKED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_NOTIFICATION_CLICKED = "android.intent.action.DOWNLOAD_NOTIFICATION_CLICKED";
				/// <summary>
				///  <para>Intent action to launch an activity to display all downloads. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_VIEW_DOWNLOADS
				/// </java-name>
				[Dot42.DexImport("ACTION_VIEW_DOWNLOADS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_VIEW_DOWNLOADS = "android.intent.action.VIEW_DOWNLOADS";
				/// <summary>
				///  <para>Intent extra included with ACTION_VIEW_DOWNLOADS to start DownloadApp in sort-by-size mode. </para>        
				/// </summary>
				/// <java-name>
				/// INTENT_EXTRAS_SORT_BY_SIZE
				/// </java-name>
				[Dot42.DexImport("INTENT_EXTRAS_SORT_BY_SIZE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string INTENT_EXTRAS_SORT_BY_SIZE = "android.app.DownloadManager.extra_sortBySize";
				/// <summary>
				///  <para>Intent extra included with ACTION_DOWNLOAD_COMPLETE intents, indicating the ID (as a long) of the download that just completed. </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_DOWNLOAD_ID
				/// </java-name>
				[Dot42.DexImport("EXTRA_DOWNLOAD_ID", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_DOWNLOAD_ID = "extra_download_id";
				/// <summary>
				///  <para>When clicks on multiple notifications are received, the following provides an array of download ids corresponding to the download notification that was clicked. It can be retrieved by the receiver of this Intent using android.content.Intent#getLongArrayExtra(String). </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_NOTIFICATION_CLICK_DOWNLOAD_IDS
				/// </java-name>
				[Dot42.DexImport("EXTRA_NOTIFICATION_CLICK_DOWNLOAD_IDS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_NOTIFICATION_CLICK_DOWNLOAD_IDS = "extra_click_download_ids";
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal DownloadManager() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Enqueue a new download. The download will start automatically once the download manager is ready to execute it and connectivity is available.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>an ID for the download, unique across the system. This ID is used to make future calls related to this download. </para>
				/// </returns>
				/// <java-name>
				/// enqueue
				/// </java-name>
				[Dot42.DexImport("enqueue", "(Landroid/app/DownloadManager$Request;)J", AccessFlags = 1)]
				public virtual long Enqueue(global::Android.App.DownloadManager.Request request) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				///  <para>Cancel downloads and remove them from the download manager. Each download will be stopped if it was running, and it will no longer be accessible through the download manager. If there is a downloaded file, partial or complete, it is deleted.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the number of downloads actually removed </para>
				/// </returns>
				/// <java-name>
				/// remove
				/// </java-name>
				[Dot42.DexImport("remove", "([J)I", AccessFlags = 129)]
				public virtual int Remove(params long[] ids) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Query the download manager about downloads that have been requested. </para>        
				/// </summary>
				/// <returns>
				///  <para>a Cursor over the result set of downloads, with columns consisting of all the COLUMN_* constants. </para>
				/// </returns>
				/// <java-name>
				/// query
				/// </java-name>
				[Dot42.DexImport("query", "(Landroid/app/DownloadManager$Query;)Landroid/database/Cursor;", AccessFlags = 1)]
				public virtual global::Android.Database.ICursor Query(global::Android.App.DownloadManager.JavaQuery query) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Database.ICursor);
				}

				/// <summary>
				///  <para>Open a downloaded file for reading. The download must have completed. </para>        
				/// </summary>
				/// <returns>
				///  <para>a read-only ParcelFileDescriptor </para>
				/// </returns>
				/// <java-name>
				/// openDownloadedFile
				/// </java-name>
				[Dot42.DexImport("openDownloadedFile", "(J)Landroid/os/ParcelFileDescriptor;", AccessFlags = 1)]
				public virtual global::Android.OS.ParcelFileDescriptor OpenDownloadedFile(long id) /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.ParcelFileDescriptor);
				}

				/// <summary>
				///  <para>Returns Uri for the given downloaded file id, if the file is downloaded successfully. otherwise, null is returned. </para> <para>If the specified downloaded file is in external storage (for example, /sdcard dir), then it is assumed to be safe for anyone to read and the returned Uri corresponds to the filepath on sdcard.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the Uri for the given downloaded file id, if download was successful. null otherwise. </para>
				/// </returns>
				/// <java-name>
				/// getUriForDownloadedFile
				/// </java-name>
				[Dot42.DexImport("getUriForDownloadedFile", "(J)Landroid/net/Uri;", AccessFlags = 1)]
				public virtual global::Android.Net.Uri GetUriForDownloadedFile(long id) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Net.Uri);
				}

				/// <summary>
				///  <para>Returns Uri for the given downloaded file id, if the file is downloaded successfully. otherwise, null is returned. </para> <para>If the specified downloaded file is in external storage (for example, /sdcard dir), then it is assumed to be safe for anyone to read and the returned Uri corresponds to the filepath on sdcard.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the Uri for the given downloaded file id, if download was successful. null otherwise. </para>
				/// </returns>
				/// <java-name>
				/// getMimeTypeForDownloadedFile
				/// </java-name>
				[Dot42.DexImport("getMimeTypeForDownloadedFile", "(J)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetMimeTypeForDownloadedFile(long id) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Returns maximum size, in bytes, of downloads that may go over a mobile connection; or null if there's no limit</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>maximum size, in bytes, of downloads that may go over a mobile connection; or null if there's no limit </para>
				/// </returns>
				/// <java-name>
				/// getMaxBytesOverMobile
				/// </java-name>
				[Dot42.DexImport("getMaxBytesOverMobile", "(Landroid/content/Context;)Ljava/lang/Long;", AccessFlags = 9)]
				public static long? GetMaxBytesOverMobile(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
						return default(long?);
				}

				/// <summary>
				///  <para>Returns recommended maximum size, in bytes, of downloads that may go over a mobile connection; or null if there's no recommended limit. The user will have the option to bypass this limit.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>recommended maximum size, in bytes, of downloads that may go over a mobile connection; or null if there's no recommended limit. </para>
				/// </returns>
				/// <java-name>
				/// getRecommendedMaxBytesOverMobile
				/// </java-name>
				[Dot42.DexImport("getRecommendedMaxBytesOverMobile", "(Landroid/content/Context;)Ljava/lang/Long;", AccessFlags = 9)]
				public static long? GetRecommendedMaxBytesOverMobile(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
						return default(long?);
				}

				/// <summary>
				///  <para>Adds a file to the downloads database system, so it could appear in Downloads App (and thus become eligible for management by the Downloads App). </para> <para>It is helpful to make the file scannable by MediaScanner by setting the param isMediaScannerScannable to true. It makes the file visible in media managing applications such as Gallery App, which could be a useful purpose of using this API.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>an ID for the download entry added to the downloads app, unique across the system This ID is used to make future calls related to this download. </para>
				/// </returns>
				/// <java-name>
				/// addCompletedDownload
				/// </java-name>
				[Dot42.DexImport("addCompletedDownload", "(Ljava/lang/String;Ljava/lang/String;ZLjava/lang/String;Ljava/lang/String;JZ)J", AccessFlags = 1)]
				public virtual long AddCompletedDownload(string title, string description, bool isMediaScannerScannable, string mimeType, string path, long length, bool showNotification) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				///  <para>This class may be used to filter download manager queries. </para>    
				/// </summary>
				/// <java-name>
				/// android/app/DownloadManager$Query
				/// </java-name>
				[Dot42.DexImport("android/app/DownloadManager$Query", AccessFlags = 9)]
				public partial class JavaQuery
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public JavaQuery() /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Include only the downloads with the given IDs. </para>        
						/// </summary>
						/// <returns>
						///  <para>this object </para>
						/// </returns>
						/// <java-name>
						/// setFilterById
						/// </java-name>
						[Dot42.DexImport("setFilterById", "([J)Landroid/app/DownloadManager$Query;", AccessFlags = 129)]
						public virtual JavaQuery SetFilterById(params long[] ids) /* MethodBuilder.Create */ 
						{
								return default(JavaQuery);
						}

						/// <summary>
						///  <para>Include only downloads with status matching any the given status flags. </para>        
						/// </summary>
						/// <returns>
						///  <para>this object </para>
						/// </returns>
						/// <java-name>
						/// setFilterByStatus
						/// </java-name>
						[Dot42.DexImport("setFilterByStatus", "(I)Landroid/app/DownloadManager$Query;", AccessFlags = 1)]
						public virtual JavaQuery SetFilterByStatus(int flags) /* MethodBuilder.Create */ 
						{
								return default(JavaQuery);
						}

				}

				/// <summary>
				///  <para>This class contains all the information necessary to request a new download. The URI is the only required parameter.</para> <para>Note that the default download destination is a shared volume where the system might delete your file if it needs to reclaim space for system use. If this is a problem, use a location on external storage (see setDestinationUri(Uri). </para>    
				/// </summary>
				/// <java-name>
				/// android/app/DownloadManager$Request
				/// </java-name>
				[Dot42.DexImport("android/app/DownloadManager$Request", AccessFlags = 9)]
				public partial class Request
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>Bit flag for setAllowedNetworkTypes corresponding to ConnectivityManager#TYPE_MOBILE. </para>        
						/// </summary>
						/// <java-name>
						/// NETWORK_MOBILE
						/// </java-name>
						[Dot42.DexImport("NETWORK_MOBILE", "I", AccessFlags = 25)]
						public const int NETWORK_MOBILE = 1;
						/// <summary>
						///  <para>Bit flag for setAllowedNetworkTypes corresponding to ConnectivityManager#TYPE_WIFI. </para>        
						/// </summary>
						/// <java-name>
						/// NETWORK_WIFI
						/// </java-name>
						[Dot42.DexImport("NETWORK_WIFI", "I", AccessFlags = 25)]
						public const int NETWORK_WIFI = 2;
						/// <summary>
						///  <para>This download is visible but only shows in the notifications while it's in progress. </para>        
						/// </summary>
						/// <java-name>
						/// VISIBILITY_VISIBLE
						/// </java-name>
						[Dot42.DexImport("VISIBILITY_VISIBLE", "I", AccessFlags = 25)]
						public const int VISIBILITY_VISIBLE = 0;
						/// <summary>
						///  <para>This download is visible and shows in the notifications while in progress and after completion. </para>        
						/// </summary>
						/// <java-name>
						/// VISIBILITY_VISIBLE_NOTIFY_COMPLETED
						/// </java-name>
						[Dot42.DexImport("VISIBILITY_VISIBLE_NOTIFY_COMPLETED", "I", AccessFlags = 25)]
						public const int VISIBILITY_VISIBLE_NOTIFY_COMPLETED = 1;
						/// <summary>
						///  <para>This download doesn't show in the UI or in the notifications. </para>        
						/// </summary>
						/// <java-name>
						/// VISIBILITY_HIDDEN
						/// </java-name>
						[Dot42.DexImport("VISIBILITY_HIDDEN", "I", AccessFlags = 25)]
						public const int VISIBILITY_HIDDEN = 2;
						/// <summary>
						///  <para>This download shows in the notifications after completion ONLY. It is usuable only with String, boolean, String, String, long, boolean). </para>        
						/// </summary>
						/// <java-name>
						/// VISIBILITY_VISIBLE_NOTIFY_ONLY_COMPLETION
						/// </java-name>
						[Dot42.DexImport("VISIBILITY_VISIBLE_NOTIFY_ONLY_COMPLETION", "I", AccessFlags = 25)]
						public const int VISIBILITY_VISIBLE_NOTIFY_ONLY_COMPLETION = 3;
						[Dot42.DexImport("<init>", "(Landroid/net/Uri;)V", AccessFlags = 1)]
						public Request(global::Android.Net.Uri uri) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Set the local destination for the downloaded file. Must be a file URI to a path on external storage, and the calling application must have the WRITE_EXTERNAL_STORAGE permission. </para> <para>The downloaded file is not scanned by MediaScanner. But it can be made scannable by calling allowScanningByMediaScanner(). </para> <para>By default, downloads are saved to a generated filename in the shared download cache and may be deleted by the system at any time to reclaim space.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>this object </para>
						/// </returns>
						/// <java-name>
						/// setDestinationUri
						/// </java-name>
						[Dot42.DexImport("setDestinationUri", "(Landroid/net/Uri;)Landroid/app/DownloadManager$Request;", AccessFlags = 1)]
						public virtual Request SetDestinationUri(global::Android.Net.Uri uri) /* MethodBuilder.Create */ 
						{
								return default(Request);
						}

						/// <summary>
						///  <para>Set the local destination for the downloaded file to a path within the application's external files directory (as returned by Context#getExternalFilesDir(String). </para> <para>The downloaded file is not scanned by MediaScanner. But it can be made scannable by calling allowScanningByMediaScanner().</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>this object </para>
						/// </returns>
						/// <java-name>
						/// setDestinationInExternalFilesDir
						/// </java-name>
						[Dot42.DexImport("setDestinationInExternalFilesDir", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)Landroid/app/Downl" +
    "oadManager$Request;", AccessFlags = 1)]
						public virtual Request SetDestinationInExternalFilesDir(global::Android.Content.Context context, string dirType, string subPath) /* MethodBuilder.Create */ 
						{
								return default(Request);
						}

						/// <summary>
						///  <para>Set the local destination for the downloaded file to a path within the public external storage directory (as returned by Environment#getExternalStoragePublicDirectory(String)). </para> <para>The downloaded file is not scanned by MediaScanner. But it can be made scannable by calling allowScanningByMediaScanner().</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>this object </para>
						/// </returns>
						/// <java-name>
						/// setDestinationInExternalPublicDir
						/// </java-name>
						[Dot42.DexImport("setDestinationInExternalPublicDir", "(Ljava/lang/String;Ljava/lang/String;)Landroid/app/DownloadManager$Request;", AccessFlags = 1)]
						public virtual Request SetDestinationInExternalPublicDir(string dirType, string subPath) /* MethodBuilder.Create */ 
						{
								return default(Request);
						}

						/// <summary>
						///  <para>If the file to be downloaded is to be scanned by MediaScanner, this method should be called before DownloadManager#enqueue(Request) is called. </para>        
						/// </summary>
						/// <java-name>
						/// allowScanningByMediaScanner
						/// </java-name>
						[Dot42.DexImport("allowScanningByMediaScanner", "()V", AccessFlags = 1)]
						public virtual void AllowScanningByMediaScanner() /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Add an HTTP header to be included with the download request. The header will be added to the end of the list.  <para> </para></para>        
						/// </summary>
						/// <returns>
						///  <para>this object </para>
						/// </returns>
						/// <java-name>
						/// addRequestHeader
						/// </java-name>
						[Dot42.DexImport("addRequestHeader", "(Ljava/lang/String;Ljava/lang/String;)Landroid/app/DownloadManager$Request;", AccessFlags = 1)]
						public virtual Request AddRequestHeader(string header, string value) /* MethodBuilder.Create */ 
						{
								return default(Request);
						}

						/// <summary>
						///  <para>Set the title of this download, to be displayed in notifications (if enabled). If no title is given, a default one will be assigned based on the download filename, once the download starts. </para>        
						/// </summary>
						/// <returns>
						///  <para>this object </para>
						/// </returns>
						/// <java-name>
						/// setTitle
						/// </java-name>
						[Dot42.DexImport("setTitle", "(Ljava/lang/CharSequence;)Landroid/app/DownloadManager$Request;", AccessFlags = 1)]
						public virtual Request SetTitle(global::Java.Lang.ICharSequence title) /* MethodBuilder.Create */ 
						{
								return default(Request);
						}

						/// <summary>
						///  <para>Set a description of this download, to be displayed in notifications (if enabled) </para>        
						/// </summary>
						/// <returns>
						///  <para>this object </para>
						/// </returns>
						/// <java-name>
						/// setDescription
						/// </java-name>
						[Dot42.DexImport("setDescription", "(Ljava/lang/CharSequence;)Landroid/app/DownloadManager$Request;", AccessFlags = 1)]
						public virtual Request SetDescription(global::Java.Lang.ICharSequence description) /* MethodBuilder.Create */ 
						{
								return default(Request);
						}

						/// <summary>
						///  <para>Set the MIME content type of this download. This will override the content type declared in the server's response.  <para> </para></para>        
						/// </summary>
						/// <returns>
						///  <para>this object </para>
						/// </returns>
						/// <java-name>
						/// setMimeType
						/// </java-name>
						[Dot42.DexImport("setMimeType", "(Ljava/lang/String;)Landroid/app/DownloadManager$Request;", AccessFlags = 1)]
						public virtual Request SetMimeType(string mimeType) /* MethodBuilder.Create */ 
						{
								return default(Request);
						}

						/// <summary>
						///  <para>Control whether a system notification is posted by the download manager while this download is running. If enabled, the download manager posts notifications about downloads through the system android.app.NotificationManager. By default, a notification is shown.</para> <para>If set to false, this requires the permission android.permission.DOWNLOAD_WITHOUT_NOTIFICATION.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>use setNotificationVisibility(int) </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <returns>
						///  <para>this object </para>
						/// </returns>
						/// <java-name>
						/// setShowRunningNotification
						/// </java-name>
						[Dot42.DexImport("setShowRunningNotification", "(Z)Landroid/app/DownloadManager$Request;", AccessFlags = 1)]
						public virtual Request SetShowRunningNotification(bool show) /* MethodBuilder.Create */ 
						{
								return default(Request);
						}

						/// <summary>
						///  <para>Control whether a system notification is posted by the download manager while this download is running or when it is completed. If enabled, the download manager posts notifications about downloads through the system android.app.NotificationManager. By default, a notification is shown only when the download is in progress. </para> <para>It can take the following values: VISIBILITY_HIDDEN, VISIBILITY_VISIBLE, VISIBILITY_VISIBLE_NOTIFY_COMPLETED. </para> <para>If set to VISIBILITY_HIDDEN, this requires the permission android.permission.DOWNLOAD_WITHOUT_NOTIFICATION.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>this object </para>
						/// </returns>
						/// <java-name>
						/// setNotificationVisibility
						/// </java-name>
						[Dot42.DexImport("setNotificationVisibility", "(I)Landroid/app/DownloadManager$Request;", AccessFlags = 1)]
						public virtual Request SetNotificationVisibility(int visibility) /* MethodBuilder.Create */ 
						{
								return default(Request);
						}

						/// <summary>
						///  <para>Restrict the types of networks over which this download may proceed. By default, all network types are allowed. Consider using setAllowedOverMetered(boolean) instead, since it's more flexible.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>this object </para>
						/// </returns>
						/// <java-name>
						/// setAllowedNetworkTypes
						/// </java-name>
						[Dot42.DexImport("setAllowedNetworkTypes", "(I)Landroid/app/DownloadManager$Request;", AccessFlags = 1)]
						public virtual Request SetAllowedNetworkTypes(int flags) /* MethodBuilder.Create */ 
						{
								return default(Request);
						}

						/// <summary>
						///  <para>Set whether this download may proceed over a roaming connection. By default, roaming is allowed. </para>        
						/// </summary>
						/// <returns>
						///  <para>this object </para>
						/// </returns>
						/// <java-name>
						/// setAllowedOverRoaming
						/// </java-name>
						[Dot42.DexImport("setAllowedOverRoaming", "(Z)Landroid/app/DownloadManager$Request;", AccessFlags = 1)]
						public virtual Request SetAllowedOverRoaming(bool allowed) /* MethodBuilder.Create */ 
						{
								return default(Request);
						}

						/// <summary>
						///  <para>Set whether this download may proceed over a metered network connection. By default, metered networks are allowed.</para> <para> <para>ConnectivityManager::isActiveNetworkMetered() </para></para>        
						/// </summary>
						/// <java-name>
						/// setAllowedOverMetered
						/// </java-name>
						[Dot42.DexImport("setAllowedOverMetered", "(Z)Landroid/app/DownloadManager$Request;", AccessFlags = 1)]
						public virtual Request SetAllowedOverMetered(bool allow) /* MethodBuilder.Create */ 
						{
								return default(Request);
						}

						/// <summary>
						///  <para>Set whether this download should be displayed in the system's Downloads UI. True by default. </para>        
						/// </summary>
						/// <returns>
						///  <para>this object </para>
						/// </returns>
						/// <java-name>
						/// setVisibleInDownloadsUi
						/// </java-name>
						[Dot42.DexImport("setVisibleInDownloadsUi", "(Z)Landroid/app/DownloadManager$Request;", AccessFlags = 1)]
						public virtual Request SetVisibleInDownloadsUi(bool isVisible) /* MethodBuilder.Create */ 
						{
								return default(Request);
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal Request() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

				}

		}

		/// <summary>
		///  <para>An activity that displays an expandable list of items by binding to a data source implementing the ExpandableListAdapter, and exposes event handlers when the user selects an item. </para> <para>ExpandableListActivity hosts a ExpandableListView object that can be bound to different data sources that provide a two-levels of data (the top-level is group, and below each group are children). Binding, screen layout, and row layout are discussed in the following sections. </para> <para> <b>Screen Layout</b> </para> <para>ExpandableListActivity has a default layout that consists of a single, full-screen, centered expandable list. However, if you desire, you can customize the screen layout by setting your own view layout with setContentView() in onCreate(). To do this, your own view MUST contain an ExpandableListView object with the id "@android:id/list" (or android.R.id#list if it's in code) </para> <para>Optionally, your custom view can contain another view object of any type to display when the list view is empty. This "empty list" notifier must have an id "android:empty". Note that when an empty view is present, the expandable list view will be hidden when there is no data to display. </para> <para>The following code demonstrates an (ugly) custom screen layout. It has a list with a green background, and an alternate red "no data" message. </para> <para> <pre>
		/// &lt;?xml version="1.0" encoding="UTF-8"?&gt;
		/// &lt;LinearLayout xmlns:android="http://schemas.android.com/apk/res/android"
		///         android:orientation="vertical"
		///         android:layout_width="match_parent" 
		///         android:layout_height="match_parent"
		///         android:paddingLeft="8dp"
		///         android:paddingRight="8dp"&gt;</pre></para> <para> <pre>    &lt;ExpandableListView android:id="/android:list"
		///               android:layout_width="match_parent" 
		///               android:layout_height="match_parent"
		///               android:background="#00FF00"
		///               android:layout_weight="1"
		///               android:drawSelectorOnTop="false"/&gt;</pre></para> <para> <pre>    &lt;TextView android:id="/android:empty"
		///               android:layout_width="match_parent" 
		///               android:layout_height="match_parent"
		///               android:background="#FF0000"
		///               android:text="No data"/&gt;
		/// &lt;/LinearLayout&gt;
		/// </pre></para> <para> <b>Row Layout</b> </para> <para>The ExpandableListAdapter set in the ExpandableListActivity via setListAdapter(ExpandableListAdapter) provides the Views for each row. This adapter has separate methods for providing the group Views and child Views. There are a couple provided ExpandableListAdapters that simplify use of adapters: SimpleCursorTreeAdapter and SimpleExpandableListAdapter. </para> <para>With these, you can specify the layout of individual rows for groups and children in the list. These constructor takes a few parameters that specify layout resources for groups and children. It also has additional parameters that let you specify which data field to associate with which object in the row layout resource. The SimpleCursorTreeAdapter fetches data from Cursors and the SimpleExpandableListAdapter fetches data from Lists of Maps. </para> <para>Android provides some standard row layout resources. These are in the android.R.layout class, and have names such as simple_list_item_1, simple_list_item_2, and two_line_list_item. The following layout XML is the source for the resource two_line_list_item, which displays two data fields,one above the other, for each list row. </para> <para> <pre>
		/// &lt;?xml version="1.0" encoding="utf-8"?&gt;
		/// &lt;LinearLayout xmlns:android="http://schemas.android.com/apk/res/android"
		///     android:layout_width="match_parent"
		///     android:layout_height="wrap_content"
		///     android:orientation="vertical"&gt;</pre></para> <para> <pre>    &lt;TextView android:id="@+id/text1"
		///         android:textSize="16sp"
		///         android:textStyle="bold"
		///         android:layout_width="match_parent"
		///         android:layout_height="wrap_content"/&gt;</pre></para> <para> <pre>    &lt;TextView android:id="@+id/text2"
		///         android:textSize="16sp"
		///         android:layout_width="match_parent"
		///         android:layout_height="wrap_content"/&gt;
		/// &lt;/LinearLayout&gt;
		/// </pre></para> <para>You must identify the data bound to each TextView object in this layout. The syntax for this is discussed in the next section. </para> <para> <b>Binding to Data</b> </para> <para>You bind the ExpandableListActivity's ExpandableListView object to data using a class that implements the ExpandableListAdapter interface. Android provides two standard list adapters: SimpleExpandableListAdapter for static data (Maps), and SimpleCursorTreeAdapter for Cursor query results. </para> <para> <para>setListAdapter </para> <para>android.widget.ExpandableListView </para></para>    
		/// </summary>
		/// <java-name>
		/// android/app/ExpandableListActivity
		/// </java-name>
		[Dot42.DexImport("android/app/ExpandableListActivity", AccessFlags = 33)]
		public partial class ExpandableListActivity : global::Android.App.Activity, global::Android.Views.View.IOnCreateContextMenuListener, global::Android.Widget.ExpandableListView.IOnChildClickListener, global::Android.Widget.ExpandableListView.IOnGroupCollapseListener, global::Android.Widget.ExpandableListView.IOnGroupExpandListener
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ExpandableListActivity() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Override this to populate the context menu when an item is long pressed. menuInfo will contain an android.widget.ExpandableListView.ExpandableListContextMenuInfo whose packedPosition is a packed position that should be used with ExpandableListView#getPackedPositionType(long) and the other similar methods. </para> <para> <para>Called when the context menu for this view is being built. It is not safe to hold onto the menu after this method returns.</para> <para></para> </para>        
				/// </summary>
				/// <java-name>
				/// onCreateContextMenu
				/// </java-name>
				[Dot42.DexImport("onCreateContextMenu", "(Landroid/view/ContextMenu;Landroid/view/View;Landroid/view/ContextMenu$ContextMe" +
    "nuInfo;)V", AccessFlags = 1)]
				public override void OnCreateContextMenu(global::Android.Views.IContextMenu menu, global::Android.Views.View v, global::Android.Views.IContextMenu_IContextMenuInfo menuInfo) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Override this for receiving callbacks when a child has been clicked. </para> <para> <para>Callback method to be invoked when a child in this expandable list has been clicked.</para> <para></para> </para>        
				/// </summary>
				/// <returns>
				///  <para>True if the click was handled</para>
				/// </returns>
				/// <java-name>
				/// onChildClick
				/// </java-name>
				[Dot42.DexImport("onChildClick", "(Landroid/widget/ExpandableListView;Landroid/view/View;IIJ)Z", AccessFlags = 1)]
				public virtual bool OnChildClick(global::Android.Widget.ExpandableListView parent, global::Android.Views.View v, int groupPosition, int childPosition, long id) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Override this for receiving callbacks when a group has been collapsed. </para>        
				/// </summary>
				/// <java-name>
				/// onGroupCollapse
				/// </java-name>
				[Dot42.DexImport("onGroupCollapse", "(I)V", AccessFlags = 1)]
				public virtual void OnGroupCollapse(int groupPosition) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Override this for receiving callbacks when a group has been expanded. </para>        
				/// </summary>
				/// <java-name>
				/// onGroupExpand
				/// </java-name>
				[Dot42.DexImport("onGroupExpand", "(I)V", AccessFlags = 1)]
				public virtual void OnGroupExpand(int groupPosition) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Ensures the expandable list view has been created before Activity restores all of the view states.</para> <para> <para>Activity::onRestoreInstanceState(Bundle) </para></para>        
				/// </summary>
				/// <java-name>
				/// onRestoreInstanceState
				/// </java-name>
				[Dot42.DexImport("onRestoreInstanceState", "(Landroid/os/Bundle;)V", AccessFlags = 4)]
				protected internal override void OnRestoreInstanceState(global::Android.OS.Bundle state) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Updates the screen state (current list and other views) when the content changes.</para> <para> <para>Activity::onContentChanged() </para></para>        
				/// </summary>
				/// <java-name>
				/// onContentChanged
				/// </java-name>
				[Dot42.DexImport("onContentChanged", "()V", AccessFlags = 1)]
				public override void OnContentChanged() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Provide the adapter for the expandable list. </para>        
				/// </summary>
				/// <java-name>
				/// setListAdapter
				/// </java-name>
				[Dot42.DexImport("setListAdapter", "(Landroid/widget/ExpandableListAdapter;)V", AccessFlags = 1)]
				public virtual void SetListAdapter(global::Android.Widget.IExpandableListAdapter adapter) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the selection to the specified child. If the child is in a collapsed group, the group will only be expanded and child subsequently selected if shouldExpandGroup is set to true, otherwise the method will return false.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Whether the selection was successfully set on the child. </para>
				/// </returns>
				/// <java-name>
				/// setSelectedChild
				/// </java-name>
				[Dot42.DexImport("setSelectedChild", "(IIZ)Z", AccessFlags = 1)]
				public virtual bool SetSelectedChild(int groupPosition, int childPosition, bool shouldExpandGroup) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Sets the selection to the specified group. </para>        
				/// </summary>
				/// <java-name>
				/// setSelectedGroup
				/// </java-name>
				[Dot42.DexImport("setSelectedGroup", "(I)V", AccessFlags = 1)]
				public virtual void SetSelectedGroup(int groupPosition) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Get the activity's expandable list view widget. This can be used to get the selection, set the selection, and many other useful functions.</para> <para> <para>ExpandableListView </para></para>        
				/// </summary>
				/// <java-name>
				/// getExpandableListView
				/// </java-name>
				public virtual global::Android.Widget.ExpandableListView ExpandableListView
				{
						[Dot42.DexImport("getExpandableListView", "()Landroid/widget/ExpandableListView;", AccessFlags = 1)]
						get{ return default(global::Android.Widget.ExpandableListView); }
				}

				/// <summary>
				///  <para>Get the ExpandableListAdapter associated with this activity's ExpandableListView. </para>        
				/// </summary>
				/// <java-name>
				/// getExpandableListAdapter
				/// </java-name>
				public virtual global::Android.Widget.IExpandableListAdapter ExpandableListAdapter
				{
						[Dot42.DexImport("getExpandableListAdapter", "()Landroid/widget/ExpandableListAdapter;", AccessFlags = 1)]
						get{ return default(global::Android.Widget.IExpandableListAdapter); }
				}

				/// <summary>
				///  <para>Gets the ID of the currently selected group or child.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The ID of the currently selected group or child. </para>
				/// </returns>
				/// <java-name>
				/// getSelectedId
				/// </java-name>
				public virtual long SelectedId
				{
						[Dot42.DexImport("getSelectedId", "()J", AccessFlags = 1)]
						get{ return default(long); }
				}

				/// <summary>
				///  <para>Gets the position (in packed position representation) of the currently selected group or child. Use ExpandableListView#getPackedPositionType, ExpandableListView#getPackedPositionGroup, and ExpandableListView#getPackedPositionChild to unpack the returned packed position.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>A packed position representation containing the currently selected group or child's position and type. </para>
				/// </returns>
				/// <java-name>
				/// getSelectedPosition
				/// </java-name>
				public virtual long SelectedPosition
				{
						[Dot42.DexImport("getSelectedPosition", "()J", AccessFlags = 1)]
						get{ return default(long); }
				}

		}

		/// <summary>
		///  <para>A Fragment is a piece of an application's user interface or behavior that can be placed in an Activity. Interaction with fragments is done through FragmentManager, which can be obtained via Activity.getFragmentManager() and Fragment.getFragmentManager().</para> <para>The Fragment class can be used many ways to achieve a wide variety of results. In its core, it represents a particular operation or interface that is running within a larger Activity. A Fragment is closely tied to the Activity it is in, and can not be used apart from one. Though Fragment defines its own lifecycle, that lifecycle is dependent on its activity: if the activity is stopped, no fragments inside of it can be started; when the activity is destroyed, all fragments will be destroyed.</para> <para>All subclasses of Fragment must include a public empty constructor. The framework will often re-instantiate a fragment class when needed, in particular during state restore, and needs to be able to find this constructor to instantiate it. If the empty constructor is not available, a runtime exception will occur in some cases during state restore.</para> <para>Topics covered here:  <ol> <li> <para> </para></li> <li> <para> </para></li> <li> <para> </para></li> <li> <para> </para></li></ol></para> <para>  <h3>Developer Guides</h3></para> <para> </para> <para>For more information about using fragments, read the  developer guide.</para> <para> </para> <para>  <h3>Older Platforms</h3></para> <para>While the Fragment API was introduced in android.os.Build.VERSION_CODES#HONEYCOMB, a version of the API at is also available for use on older platforms through android.support.v4.app.FragmentActivity. See the blog post  for more details.</para> <para>  <h3>Lifecycle</h3></para> <para>Though a Fragment's lifecycle is tied to its owning activity, it has its own wrinkle on the standard activity lifecycle. It includes basic activity lifecycle methods such as onResume, but also important are methods related to interactions with the activity and UI generation.</para> <para>The core series of lifecycle methods that are called to bring a fragment up to resumed state (interacting with the user) are:</para> <para> <ol> <li> <para>onAttach called once the fragment is associated with its activity. </para></li> <li> <para>onCreate called to do initial creation of the fragment. </para></li> <li> <para>onCreateView creates and returns the view hierarchy associated with the fragment. </para></li> <li> <para>onActivityCreated tells the fragment that its activity has completed its own Activity.onCreate(). </para></li> <li> <para>onViewStateRestored tells the fragment that all of the saved state of its view hierarchy has been restored. </para></li> <li> <para>onStart makes the fragment visible to the user (based on its containing activity being started). </para></li> <li> <para>onResume makes the fragment interacting with the user (based on its containing activity being resumed). </para></li></ol></para> <para>As a fragment is no longer being used, it goes through a reverse series of callbacks:</para> <para> <ol> <li> <para>onPause fragment is no longer interacting with the user either because its activity is being paused or a fragment operation is modifying it in the activity. </para></li> <li> <para>onStop fragment is no longer visible to the user either because its activity is being stopped or a fragment operation is modifying it in the activity. </para></li> <li> <para>onDestroyView allows the fragment to clean up resources associated with its View. </para></li> <li> <para>onDestroy called to do final cleanup of the fragment's state. </para></li> <li> <para>onDetach called immediately prior to the fragment no longer being associated with its activity. </para></li></ol></para> <para>  <h3>Layout</h3></para> <para>Fragments can be used as part of your application's layout, allowing you to better modularize your code and more easily adjust your user interface to the screen it is running on. As an example, we can look at a simple program consisting of a list of items, and display of the details of each item.</para> <para>An activity's layout XML can include  <code>&lt;fragment&gt;</code> tags to embed fragment instances inside of the layout. For example, here is a simple layout that embeds one fragment:</para> <para>{ development/samples/ApiDemos/res/layout/fragment_layout.xml layout}</para> <para>The layout is installed in the activity in the normal way:</para> <para>{ development/samples/ApiDemos/src/com/example/android/apis/app/FragmentLayout.java main}</para> <para>The titles fragment, showing a list of titles, is fairly simple, relying on ListFragment for most of its work. Note the implementation of clicking an item: depending on the current activity's layout, it can either create and display a new fragment to show the details in-place (more about this later), or start a new activity to show the details.</para> <para>{ development/samples/ApiDemos/src/com/example/android/apis/app/FragmentLayout.java titles}</para> <para>The details fragment showing the contents of a selected item just displays a string of text based on an index of a string array built in to the app:</para> <para>{ development/samples/ApiDemos/src/com/example/android/apis/app/FragmentLayout.java details}</para> <para>In this case when the user clicks on a title, there is no details container in the current activity, so the titles fragment's click code will launch a new activity to display the details fragment:</para> <para>{ development/samples/ApiDemos/src/com/example/android/apis/app/FragmentLayout.java details_activity}</para> <para>However the screen may be large enough to show both the list of titles and details about the currently selected title. To use such a layout on a landscape screen, this alternative layout can be placed under layout-land:</para> <para>{ development/samples/ApiDemos/res/layout-land/fragment_layout.xml layout}</para> <para>Note how the prior code will adjust to this alternative UI flow: the titles fragment will now embed the details fragment inside of this activity, and the details activity will finish itself if it is running in a configuration where the details can be shown in-place.</para> <para>When a configuration change causes the activity hosting these fragments to restart, its new instance may use a different layout that doesn't include the same fragments as the previous layout. In this case all of the previous fragments will still be instantiated and running in the new instance. However, any that are no longer associated with a &lt;fragment&gt; tag in the view hierarchy will not have their content view created and will return false from isInLayout. (The code here also shows how you can determine if a fragment placed in a container is no longer running in a layout with that container and avoid creating its view hierarchy in that case.)</para> <para>The attributes of the &lt;fragment&gt; tag are used to control the LayoutParams provided when attaching the fragment's view to the parent container. They can also be parsed by the fragment in onInflate as parameters.</para> <para>The fragment being instantiated must have some kind of unique identifier so that it can be re-associated with a previous instance if the parent activity needs to be destroyed and recreated. This can be provided these ways:</para> <para> <ul> <li> <para>If nothing is explicitly supplied, the view ID of the container will be used. </para></li> <li> <para> <code>android:tag</code> can be used in &lt;fragment&gt; to provide a specific tag name for the fragment. </para></li> <li> <para> <code>android:id</code> can be used in &lt;fragment&gt; to provide a specific identifier for the fragment. </para></li></ul></para> <para>  <h3>Back Stack</h3></para> <para>The transaction in which fragments are modified can be placed on an internal back-stack of the owning activity. When the user presses back in the activity, any transactions on the back stack are popped off before the activity itself is finished.</para> <para>For example, consider this simple fragment that is instantiated with an integer argument and displays that in a TextView in its UI:</para> <para>{ development/samples/ApiDemos/src/com/example/android/apis/app/FragmentStack.java fragment}</para> <para>A function that creates a new instance of the fragment, replacing whatever current fragment instance is being shown and pushing that change on to the back stack could be written as:</para> <para>{ development/samples/ApiDemos/src/com/example/android/apis/app/FragmentStack.java add_stack}</para> <para>After each call to this function, a new entry is on the stack, and pressing back will pop it to return the user to whatever previous state the activity UI was in. </para>    
		/// </summary>
		/// <java-name>
		/// android/app/Fragment
		/// </java-name>
		[Dot42.DexImport("android/app/Fragment", AccessFlags = 33)]
		public partial class Fragment : global::Android.Content.IComponentCallbacks2, global::Android.Views.View.IOnCreateContextMenuListener
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Default constructor.  <b>Every</b> fragment must have an empty constructor, so it can be instantiated when restoring its activity's state. It is strongly recommended that subclasses do not have other constructors with parameters, since these constructors will not be called when the fragment is re-instantiated; instead, arguments can be supplied by the caller with setArguments and later retrieved by the Fragment with getArguments.</para> <para>Applications should generally not implement a constructor. The first place application code an run where the fragment is ready to be used is in onAttach(Activity), the point where the fragment is actually associated with its activity. Some applications may also want to implement onInflate to retrieve attributes from a layout resource, though should take care here because this happens for the fragment is attached to its activity. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Fragment() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Like instantiate(Context, String, Bundle) but with a null argument Bundle. </para>        
				/// </summary>
				/// <java-name>
				/// instantiate
				/// </java-name>
				[Dot42.DexImport("instantiate", "(Landroid/content/Context;Ljava/lang/String;)Landroid/app/Fragment;", AccessFlags = 9)]
				public static global::Android.App.Fragment Instantiate(global::Android.Content.Context context, string fname) /* MethodBuilder.Create */ 
				{
						return default(global::Android.App.Fragment);
				}

				/// <summary>
				///  <para>Create a new instance of a Fragment with the given class name. This is the same as calling its empty constructor.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns a new fragment instance. </para>
				/// </returns>
				/// <java-name>
				/// instantiate
				/// </java-name>
				[Dot42.DexImport("instantiate", "(Landroid/content/Context;Ljava/lang/String;Landroid/os/Bundle;)Landroid/app/Frag" +
    "ment;", AccessFlags = 9)]
				public static global::Android.App.Fragment Instantiate(global::Android.Content.Context context, string fname, global::Android.OS.Bundle args) /* MethodBuilder.Create */ 
				{
						return default(global::Android.App.Fragment);
				}

				/// <summary>
				///  <para>Subclasses can not override equals(). </para>        
				/// </summary>
				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 17)]
				public override bool Equals(object o) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Subclasses can not override hashCode(). </para>        
				/// </summary>
				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 17)]
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
				///  <para>Set the initial saved state that this Fragment should restore itself from when first being constructed, as returned by FragmentManager.saveFragmentInstanceState.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setInitialSavedState
				/// </java-name>
				[Dot42.DexImport("setInitialSavedState", "(Landroid/app/Fragment$SavedState;)V", AccessFlags = 1)]
				public virtual void SetInitialSavedState(global::Android.App.Fragment.SavedState state) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Optional target for this fragment. This may be used, for example, if this fragment is being started by another, and when done wants to give a result back to the first. The target set here is retained across instances via FragmentManager.putFragment().</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setTargetFragment
				/// </java-name>
				[Dot42.DexImport("setTargetFragment", "(Landroid/app/Fragment;I)V", AccessFlags = 1)]
				public virtual void SetTargetFragment(global::Android.App.Fragment fragment, int requestCode) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Return a localized, styled CharSequence from the application's package's default string table.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// getText
				/// </java-name>
				[Dot42.DexImport("getText", "(I)Ljava/lang/CharSequence;", AccessFlags = 17)]
				public global::Java.Lang.ICharSequence GetText(int resId) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <summary>
				///  <para>Return a localized string from the application's package's default string table.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// getString
				/// </java-name>
				[Dot42.DexImport("getString", "(I)Ljava/lang/String;", AccessFlags = 17)]
				public string GetString(int resId) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Return a localized formatted string from the application's package's default string table, substituting the format arguments as defined in java.util.Formatter and java.lang.String#format.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// getString
				/// </java-name>
				[Dot42.DexImport("getString", "(I[Ljava/lang/Object;)Ljava/lang/String;", AccessFlags = 145)]
				public string GetString(int resId, params object[] formatArgs) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Called when the hidden state (as returned by isHidden() of the fragment has changed. Fragments start out not hidden; this will be called whenever the fragment changes state from that. </para>        
				/// </summary>
				/// <java-name>
				/// onHiddenChanged
				/// </java-name>
				[Dot42.DexImport("onHiddenChanged", "(Z)V", AccessFlags = 1)]
				public virtual void OnHiddenChanged(bool hidden) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Report that this fragment would like to participate in populating the options menu by receiving a call to onCreateOptionsMenu and related methods.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setHasOptionsMenu
				/// </java-name>
				[Dot42.DexImport("setHasOptionsMenu", "(Z)V", AccessFlags = 1)]
				public virtual void SetHasOptionsMenu(bool hasMenu) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Set a hint for whether this fragment's menu should be visible. This is useful if you know that a fragment has been placed in your view hierarchy so that the user can not currently seen it, so any menu items it has should also not be shown.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setMenuVisibility
				/// </java-name>
				[Dot42.DexImport("setMenuVisibility", "(Z)V", AccessFlags = 1)]
				public virtual void SetMenuVisibility(bool menuVisible) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Call Activity#startActivity(Intent) from the fragment's containing Activity.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// startActivity
				/// </java-name>
				[Dot42.DexImport("startActivity", "(Landroid/content/Intent;)V", AccessFlags = 1)]
				public virtual void StartActivity(global::Android.Content.Intent intent) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Call Activity#startActivity(Intent, Bundle) from the fragment's containing Activity.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// startActivity
				/// </java-name>
				[Dot42.DexImport("startActivity", "(Landroid/content/Intent;Landroid/os/Bundle;)V", AccessFlags = 1)]
				public virtual void StartActivity(global::Android.Content.Intent intent, global::Android.OS.Bundle options) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Call Activity#startActivityForResult(Intent, int) from the fragment's containing Activity. </para>        
				/// </summary>
				/// <java-name>
				/// startActivityForResult
				/// </java-name>
				[Dot42.DexImport("startActivityForResult", "(Landroid/content/Intent;I)V", AccessFlags = 1)]
				public virtual void StartActivityForResult(global::Android.Content.Intent intent, int requestCode) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Call Activity#startActivityForResult(Intent, int, Bundle) from the fragment's containing Activity. </para>        
				/// </summary>
				/// <java-name>
				/// startActivityForResult
				/// </java-name>
				[Dot42.DexImport("startActivityForResult", "(Landroid/content/Intent;ILandroid/os/Bundle;)V", AccessFlags = 1)]
				public virtual void StartActivityForResult(global::Android.Content.Intent intent, int requestCode, global::Android.OS.Bundle options) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Receive the result from a previous call to startActivityForResult(Intent, int). This follows the related Activity API as described there in Activity#onActivityResult(int, int, Intent).</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// onActivityResult
				/// </java-name>
				[Dot42.DexImport("onActivityResult", "(IILandroid/content/Intent;)V", AccessFlags = 1)]
				public virtual void OnActivityResult(int requestCode, int resultCode, global::Android.Content.Intent data) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use onInflate(Activity, AttributeSet, Bundle) instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// onInflate
				/// </java-name>
				[Dot42.DexImport("onInflate", "(Landroid/util/AttributeSet;Landroid/os/Bundle;)V", AccessFlags = 1)]
				public virtual void OnInflate(global::Android.Util.IAttributeSet attrs, global::Android.OS.Bundle savedInstanceState) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Called when a fragment is being created as part of a view layout inflation, typically from setting the content view of an activity. This may be called immediately after the fragment is created from a &lt;fragment&gt; tag in a layout file. Note this is  <b>before</b> the fragment's onAttach(Activity) has been called; all you should do here is parse the attributes and save them away.</para> <para>This is called every time the fragment is inflated, even if it is being inflated into a new instance with saved state. It typically makes sense to re-parse the parameters each time, to allow them to change with different configurations.</para> <para>Here is a typical implementation of a fragment that can take parameters both through attributes supplied here as well from getArguments():</para> <para>{ development/samples/ApiDemos/src/com/example/android/apis/app/FragmentArguments.java fragment}</para> <para>Note that parsing the XML attributes uses a "styleable" resource. The declaration for the styleable used here is:</para> <para>{ development/samples/ApiDemos/res/values/attrs.xml fragment_arguments}</para> <para>The fragment can then be declared within its activity's content layout through a tag like this:</para> <para>{ development/samples/ApiDemos/res/layout/fragment_arguments.xml from_attributes}</para> <para>This fragment can also be created dynamically from arguments given at runtime in the arguments Bundle; here is an example of doing so at creation of the containing activity:</para> <para>{ development/samples/ApiDemos/src/com/example/android/apis/app/FragmentArguments.java create}</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// onInflate
				/// </java-name>
				[Dot42.DexImport("onInflate", "(Landroid/app/Activity;Landroid/util/AttributeSet;Landroid/os/Bundle;)V", AccessFlags = 1)]
				public virtual void OnInflate(global::Android.App.Activity activity, global::Android.Util.IAttributeSet attrs, global::Android.OS.Bundle savedInstanceState) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Called when a fragment is first attached to its activity. onCreate(Bundle) will be called after this. </para>        
				/// </summary>
				/// <java-name>
				/// onAttach
				/// </java-name>
				[Dot42.DexImport("onAttach", "(Landroid/app/Activity;)V", AccessFlags = 1)]
				public virtual void OnAttach(global::Android.App.Activity activity) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Called when a fragment loads an animation. </para>        
				/// </summary>
				/// <java-name>
				/// onCreateAnimator
				/// </java-name>
				[Dot42.DexImport("onCreateAnimator", "(IZI)Landroid/animation/Animator;", AccessFlags = 1)]
				public virtual global::Android.Animation.Animator OnCreateAnimator(int transit, bool enter, int nextAnim) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Animation.Animator);
				}

				/// <summary>
				///  <para>Called to do initial creation of a fragment. This is called after onAttach(Activity) and before onCreateView(LayoutInflater, ViewGroup, Bundle).</para> <para>Note that this can be called while the fragment's activity is still in the process of being created. As such, you can not rely on things like the activity's content view hierarchy being initialized at this point. If you want to do work once the activity itself is created, see onActivityCreated(Bundle).</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// onCreate
				/// </java-name>
				[Dot42.DexImport("onCreate", "(Landroid/os/Bundle;)V", AccessFlags = 1)]
				public virtual void OnCreate(global::Android.OS.Bundle savedInstanceState) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Called to have the fragment instantiate its user interface view. This is optional, and non-graphical fragments can return null (which is the default implementation). This will be called between onCreate(Bundle) and onActivityCreated(Bundle).</para> <para>If you return a View from here, you will later be called in onDestroyView when the view is being released.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Return the View for the fragment's UI, or null. </para>
				/// </returns>
				/// <java-name>
				/// onCreateView
				/// </java-name>
				[Dot42.DexImport("onCreateView", "(Landroid/view/LayoutInflater;Landroid/view/ViewGroup;Landroid/os/Bundle;)Landroi" +
    "d/view/View;", AccessFlags = 1)]
				public virtual global::Android.Views.View OnCreateView(global::Android.Views.LayoutInflater inflater, global::Android.Views.ViewGroup container, global::Android.OS.Bundle savedInstanceState) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.View);
				}

				/// <summary>
				///  <para>Called immediately after onCreateView(LayoutInflater, ViewGroup, Bundle) has returned, but before any saved state has been restored in to the view. This gives subclasses a chance to initialize themselves once they know their view hierarchy has been completely created. The fragment's view hierarchy is not however attached to its parent at this point. </para>        
				/// </summary>
				/// <java-name>
				/// onViewCreated
				/// </java-name>
				[Dot42.DexImport("onViewCreated", "(Landroid/view/View;Landroid/os/Bundle;)V", AccessFlags = 1)]
				public virtual void OnViewCreated(global::Android.Views.View view, global::Android.OS.Bundle savedInstanceState) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Called when the fragment's activity has been created and this fragment's view hierarchy instantiated. It can be used to do final initialization once these pieces are in place, such as retrieving views or restoring state. It is also useful for fragments that use setRetainInstance(boolean) to retain their instance, as this callback tells the fragment when it is fully associated with the new activity instance. This is called after onCreateView and before onViewStateRestored(Bundle).</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// onActivityCreated
				/// </java-name>
				[Dot42.DexImport("onActivityCreated", "(Landroid/os/Bundle;)V", AccessFlags = 1)]
				public virtual void OnActivityCreated(global::Android.OS.Bundle savedInstanceState) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Called when all saved state has been restored into the view hierarchy of the fragment. This can be used to do initialization based on saved state that you are letting the view hierarchy track itself, such as whether check box widgets are currently checked. This is called after onActivityCreated(Bundle) and before onStart().</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// onViewStateRestored
				/// </java-name>
				[Dot42.DexImport("onViewStateRestored", "(Landroid/os/Bundle;)V", AccessFlags = 1)]
				public virtual void OnViewStateRestored(global::Android.OS.Bundle savedInstanceState) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Called when the Fragment is visible to the user. This is generally tied to Activity.onStart of the containing Activity's lifecycle. </para>        
				/// </summary>
				/// <java-name>
				/// onStart
				/// </java-name>
				[Dot42.DexImport("onStart", "()V", AccessFlags = 1)]
				public virtual void OnStart() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Called when the fragment is visible to the user and actively running. This is generally tied to Activity.onResume of the containing Activity's lifecycle. </para>        
				/// </summary>
				/// <java-name>
				/// onResume
				/// </java-name>
				[Dot42.DexImport("onResume", "()V", AccessFlags = 1)]
				public virtual void OnResume() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Called to ask the fragment to save its current dynamic state, so it can later be reconstructed in a new instance of its process is restarted. If a new instance of the fragment later needs to be created, the data you place in the Bundle here will be available in the Bundle given to onCreate(Bundle), onCreateView(LayoutInflater, ViewGroup, Bundle), and onActivityCreated(Bundle).</para> <para>This corresponds to Activity.onSaveInstanceState(Bundle) and most of the discussion there applies here as well. Note however:  <b>this method may be called at any time before onDestroy()</b>. There are many situations where a fragment may be mostly torn down (such as when placed on the back stack with no UI showing), but its state will not be saved until its owning activity actually needs to save its state.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// onSaveInstanceState
				/// </java-name>
				[Dot42.DexImport("onSaveInstanceState", "(Landroid/os/Bundle;)V", AccessFlags = 1)]
				public virtual void OnSaveInstanceState(global::Android.OS.Bundle outState) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Called by the system when the device configuration changes while your component is running. Note that, unlike activities, other components are never restarted when a configuration changes: they must always deal with the results of the change, such as by re-retrieving resources.</para> <para>At the time that this function has been called, your Resources object will have been updated to return resource values matching the new configuration.</para> <para>For more information, read .</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// onConfigurationChanged
				/// </java-name>
				[Dot42.DexImport("onConfigurationChanged", "(Landroid/content/res/Configuration;)V", AccessFlags = 1)]
				public virtual void OnConfigurationChanged(global::Android.Content.Res.Configuration newConfig) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Called when the Fragment is no longer resumed. This is generally tied to Activity.onPause of the containing Activity's lifecycle. </para>        
				/// </summary>
				/// <java-name>
				/// onPause
				/// </java-name>
				[Dot42.DexImport("onPause", "()V", AccessFlags = 1)]
				public virtual void OnPause() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Called when the Fragment is no longer started. This is generally tied to Activity.onStop of the containing Activity's lifecycle. </para>        
				/// </summary>
				/// <java-name>
				/// onStop
				/// </java-name>
				[Dot42.DexImport("onStop", "()V", AccessFlags = 1)]
				public virtual void OnStop() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>This is called when the overall system is running low on memory, and actively running processes should trim their memory usage. While the exact point at which this will be called is not defined, generally it will happen when all background process have been killed. That is, before reaching the point of killing processes hosting service and foreground UI that we would like to avoid killing.</para> <para>You should implement this method to release any caches or other unnecessary resources you may be holding on to. The system will perform a garbage collection for you after returning from this method. </para> <para>Preferably, you should implement ComponentCallbacks2#onTrimMemory from ComponentCallbacks2 to incrementally unload your resources based on various levels of memory demands. That API is available for API level 14 and higher, so you should only use this onLowMemory method as a fallback for older versions, which can be treated the same as ComponentCallbacks2#onTrimMemory with the ComponentCallbacks2#TRIM_MEMORY_COMPLETE level.</para>        
				/// </summary>
				/// <java-name>
				/// onLowMemory
				/// </java-name>
				[Dot42.DexImport("onLowMemory", "()V", AccessFlags = 1)]
				public virtual void OnLowMemory() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Called when the operating system has determined that it is a good time for a process to trim unneeded memory from its process. This will happen for example when it goes in the background and there is not enough memory to keep as many background processes running as desired. You should never compare to exact values of the level, since new intermediate values may be added  you will typically want to compare if the value is greater or equal to a level you are interested in.</para> <para>To retrieve the processes current trim level at any point, you can use ActivityManager.getMyMemoryState(RunningAppProcessInfo).</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// onTrimMemory
				/// </java-name>
				[Dot42.DexImport("onTrimMemory", "(I)V", AccessFlags = 1)]
				public virtual void OnTrimMemory(int level) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Called when the view previously created by onCreateView has been detached from the fragment. The next time the fragment needs to be displayed, a new view will be created. This is called after onStop() and before onDestroy(). It is called  <b>regardless</b> of whether onCreateView returned a non-null view. Internally it is called after the view's state has been saved but before it has been removed from its parent. </para>        
				/// </summary>
				/// <java-name>
				/// onDestroyView
				/// </java-name>
				[Dot42.DexImport("onDestroyView", "()V", AccessFlags = 1)]
				public virtual void OnDestroyView() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Called when the fragment is no longer in use. This is called after onStop() and before onDetach(). </para>        
				/// </summary>
				/// <java-name>
				/// onDestroy
				/// </java-name>
				[Dot42.DexImport("onDestroy", "()V", AccessFlags = 1)]
				public virtual void OnDestroy() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Called when the fragment is no longer attached to its activity. This is called after onDestroy(). </para>        
				/// </summary>
				/// <java-name>
				/// onDetach
				/// </java-name>
				[Dot42.DexImport("onDetach", "()V", AccessFlags = 1)]
				public virtual void OnDetach() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Initialize the contents of the Activity's standard options menu. You should place your menu items in to  <b>menu</b>. For this method to be called, you must have first called setHasOptionsMenu. See Activity.onCreateOptionsMenu for more information.</para> <para> <para>setHasOptionsMenu </para> <para>onPrepareOptionsMenu </para> <para>onOptionsItemSelected </para></para>        
				/// </summary>
				/// <java-name>
				/// onCreateOptionsMenu
				/// </java-name>
				[Dot42.DexImport("onCreateOptionsMenu", "(Landroid/view/Menu;Landroid/view/MenuInflater;)V", AccessFlags = 1)]
				public virtual void OnCreateOptionsMenu(global::Android.Views.IMenu menu, global::Android.Views.MenuInflater inflater) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Prepare the Screen's standard options menu to be displayed. This is called right before the menu is shown, every time it is shown. You can use this method to efficiently enable/disable items or otherwise dynamically modify the contents. See Activity.onPrepareOptionsMenu for more information.</para> <para> <para>setHasOptionsMenu </para> <para>onCreateOptionsMenu </para></para>        
				/// </summary>
				/// <java-name>
				/// onPrepareOptionsMenu
				/// </java-name>
				[Dot42.DexImport("onPrepareOptionsMenu", "(Landroid/view/Menu;)V", AccessFlags = 1)]
				public virtual void OnPrepareOptionsMenu(global::Android.Views.IMenu menu) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Called when this fragment's option menu items are no longer being included in the overall options menu. Receiving this call means that the menu needed to be rebuilt, but this fragment's items were not included in the newly built menu (its onCreateOptionsMenu(Menu, MenuInflater) was not called). </para>        
				/// </summary>
				/// <java-name>
				/// onDestroyOptionsMenu
				/// </java-name>
				[Dot42.DexImport("onDestroyOptionsMenu", "()V", AccessFlags = 1)]
				public virtual void OnDestroyOptionsMenu() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>This hook is called whenever an item in your options menu is selected. The default implementation simply returns false to have the normal processing happen (calling the item's Runnable or sending a message to its Handler as appropriate). You can use this method for any items for which you would like to do processing without those other facilities.</para> <para>Derived classes should call through to the base class for it to perform the default menu handling.</para> <para> <para>onCreateOptionsMenu </para></para>        
				/// </summary>
				/// <returns>
				///  <para>boolean Return false to allow normal menu processing to proceed, true to consume it here.</para>
				/// </returns>
				/// <java-name>
				/// onOptionsItemSelected
				/// </java-name>
				[Dot42.DexImport("onOptionsItemSelected", "(Landroid/view/MenuItem;)Z", AccessFlags = 1)]
				public virtual bool OnOptionsItemSelected(global::Android.Views.IMenuItem item) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>This hook is called whenever the options menu is being closed (either by the user canceling the menu with the back/menu button, or when an item is selected).</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// onOptionsMenuClosed
				/// </java-name>
				[Dot42.DexImport("onOptionsMenuClosed", "(Landroid/view/Menu;)V", AccessFlags = 1)]
				public virtual void OnOptionsMenuClosed(global::Android.Views.IMenu menu) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Called when a context menu for the <c>view </c> is about to be shown. Unlike onCreateOptionsMenu, this will be called every time the context menu is about to be shown and should be populated for the view (or item inside the view for AdapterView subclasses, this can be found in the <c>menuInfo </c> )). </para> <para>Use onContextItemSelected(android.view.MenuItem) to know when an item has been selected. </para> <para>The default implementation calls up to Activity.onCreateContextMenu, though you can not call this implementation if you don't want that behavior. </para> <para>It is not safe to hold onto the context menu after this method returns.  <para>Called when the context menu for this view is being built. It is not safe to hold onto the menu after this method returns.</para> <para></para> </para>        
				/// </summary>
				/// <java-name>
				/// onCreateContextMenu
				/// </java-name>
				[Dot42.DexImport("onCreateContextMenu", "(Landroid/view/ContextMenu;Landroid/view/View;Landroid/view/ContextMenu$ContextMe" +
    "nuInfo;)V", AccessFlags = 1)]
				public virtual void OnCreateContextMenu(global::Android.Views.IContextMenu menu, global::Android.Views.View v, global::Android.Views.IContextMenu_IContextMenuInfo menuInfo) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Registers a context menu to be shown for the given view (multiple views can show the context menu). This method will set the OnCreateContextMenuListener on the view to this fragment, so onCreateContextMenu(ContextMenu, View, ContextMenuInfo) will be called when it is time to show the context menu.</para> <para> <para>unregisterForContextMenu(View) </para></para>        
				/// </summary>
				/// <java-name>
				/// registerForContextMenu
				/// </java-name>
				[Dot42.DexImport("registerForContextMenu", "(Landroid/view/View;)V", AccessFlags = 1)]
				public virtual void RegisterForContextMenu(global::Android.Views.View view) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Prevents a context menu to be shown for the given view. This method will remove the OnCreateContextMenuListener on the view.</para> <para> <para>registerForContextMenu(View) </para></para>        
				/// </summary>
				/// <java-name>
				/// unregisterForContextMenu
				/// </java-name>
				[Dot42.DexImport("unregisterForContextMenu", "(Landroid/view/View;)V", AccessFlags = 1)]
				public virtual void UnregisterForContextMenu(global::Android.Views.View view) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>This hook is called whenever an item in a context menu is selected. The default implementation simply returns false to have the normal processing happen (calling the item's Runnable or sending a message to its Handler as appropriate). You can use this method for any items for which you would like to do processing without those other facilities. </para> <para>Use MenuItem#getMenuInfo() to get extra information set by the View that added this menu item. </para> <para>Derived classes should call through to the base class for it to perform the default menu handling.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>boolean Return false to allow normal context menu processing to proceed, true to consume it here. </para>
				/// </returns>
				/// <java-name>
				/// onContextItemSelected
				/// </java-name>
				[Dot42.DexImport("onContextItemSelected", "(Landroid/view/MenuItem;)Z", AccessFlags = 1)]
				public virtual bool OnContextItemSelected(global::Android.Views.IMenuItem item) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Print the Fragments's state into the given stream.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// dump
				/// </java-name>
				[Dot42.DexImport("dump", "(Ljava/lang/String;Ljava/io/FileDescriptor;Ljava/io/PrintWriter;[Ljava/lang/Strin" +
    "g;)V", AccessFlags = 1)]
				public virtual void Dump(string prefix, global::Java.IO.FileDescriptor fd, global::Java.IO.PrintWriter writer, string[] args) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Return the identifier this fragment is known by. This is either the android:id value supplied in a layout or the container view ID supplied when adding the fragment. </para>        
				/// </summary>
				/// <java-name>
				/// getId
				/// </java-name>
				public int Id
				{
						[Dot42.DexImport("getId", "()I", AccessFlags = 17)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Get the tag name of the fragment, if specified. </para>        
				/// </summary>
				/// <java-name>
				/// getTag
				/// </java-name>
				public string Tag
				{
						[Dot42.DexImport("getTag", "()Ljava/lang/String;", AccessFlags = 17)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>Return the arguments supplied when the fragment was instantiated, if any. </para>        
				/// </summary>
				/// <java-name>
				/// getArguments
				/// </java-name>
				public virtual global::Android.OS.Bundle Arguments
				{
						[Dot42.DexImport("getArguments", "()Landroid/os/Bundle;", AccessFlags = 17)]
						get{ return default(global::Android.OS.Bundle); }
						[Dot42.DexImport("setArguments", "(Landroid/os/Bundle;)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Return the target fragment set by setTargetFragment. </para>        
				/// </summary>
				/// <java-name>
				/// getTargetFragment
				/// </java-name>
				public global::Android.App.Fragment TargetFragment
				{
						[Dot42.DexImport("getTargetFragment", "()Landroid/app/Fragment;", AccessFlags = 17)]
						get{ return default(global::Android.App.Fragment); }
				}

				/// <summary>
				///  <para>Return the target request code set by setTargetFragment. </para>        
				/// </summary>
				/// <java-name>
				/// getTargetRequestCode
				/// </java-name>
				public int TargetRequestCode
				{
						[Dot42.DexImport("getTargetRequestCode", "()I", AccessFlags = 17)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Return the Activity this fragment is currently associated with. </para>        
				/// </summary>
				/// <java-name>
				/// getActivity
				/// </java-name>
				public global::Android.App.Activity Activity
				{
						[Dot42.DexImport("getActivity", "()Landroid/app/Activity;", AccessFlags = 17)]
						get{ return default(global::Android.App.Activity); }
				}

				/// <summary>
				///  <para>Return  <code>getActivity().getResources()</code>. </para>        
				/// </summary>
				/// <java-name>
				/// getResources
				/// </java-name>
				public global::Android.Content.Res.Resources Resources
				{
						[Dot42.DexImport("getResources", "()Landroid/content/res/Resources;", AccessFlags = 17)]
						get{ return default(global::Android.Content.Res.Resources); }
				}

				/// <summary>
				///  <para>Return the FragmentManager for interacting with fragments associated with this fragment's activity. Note that this will be non-null slightly before getActivity(), during the time from when the fragment is placed in a FragmentTransaction until it is committed and attached to its activity.</para> <para>If this Fragment is a child of another Fragment, the FragmentManager returned here will be the parent's getChildFragmentManager(). </para>        
				/// </summary>
				/// <java-name>
				/// getFragmentManager
				/// </java-name>
				public global::Android.App.FragmentManager FragmentManager
				{
						[Dot42.DexImport("getFragmentManager", "()Landroid/app/FragmentManager;", AccessFlags = 17)]
						get{ return default(global::Android.App.FragmentManager); }
				}

				/// <summary>
				///  <para>Return a private FragmentManager for placing and managing Fragments inside of this Fragment. </para>        
				/// </summary>
				/// <java-name>
				/// getChildFragmentManager
				/// </java-name>
				public global::Android.App.FragmentManager ChildFragmentManager
				{
						[Dot42.DexImport("getChildFragmentManager", "()Landroid/app/FragmentManager;", AccessFlags = 17)]
						get{ return default(global::Android.App.FragmentManager); }
				}

				/// <summary>
				///  <para>Returns the parent Fragment containing this Fragment. If this Fragment is attached directly to an Activity, returns null. </para>        
				/// </summary>
				/// <java-name>
				/// getParentFragment
				/// </java-name>
				public global::Android.App.Fragment ParentFragment
				{
						[Dot42.DexImport("getParentFragment", "()Landroid/app/Fragment;", AccessFlags = 17)]
						get{ return default(global::Android.App.Fragment); }
				}

				/// <summary>
				///  <para>Return true if the fragment is currently added to its activity. </para>        
				/// </summary>
				/// <java-name>
				/// isAdded
				/// </java-name>
				public bool IsAdded
				{
						[Dot42.DexImport("isAdded", "()Z", AccessFlags = 17)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Return true if the fragment has been explicitly detached from the UI. That is, FragmentTransaction.detach(Fragment) has been used on it. </para>        
				/// </summary>
				/// <java-name>
				/// isDetached
				/// </java-name>
				public bool IsDetached
				{
						[Dot42.DexImport("isDetached", "()Z", AccessFlags = 17)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Return true if this fragment is currently being removed from its activity. This is  <b>not</b> whether its activity is finishing, but rather whether it is in the process of being removed from its activity. </para>        
				/// </summary>
				/// <java-name>
				/// isRemoving
				/// </java-name>
				public bool IsRemoving
				{
						[Dot42.DexImport("isRemoving", "()Z", AccessFlags = 17)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Return true if the layout is included as part of an activity view hierarchy via the &lt;fragment&gt; tag. This will always be true when fragments are created through the &lt;fragment&gt; tag,  <b>except</b> in the case where an old fragment is restored from a previous state and it does not appear in the layout of the current state. </para>        
				/// </summary>
				/// <java-name>
				/// isInLayout
				/// </java-name>
				public bool IsInLayout
				{
						[Dot42.DexImport("isInLayout", "()Z", AccessFlags = 17)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Return true if the fragment is in the resumed state. This is true for the duration of onResume() and onPause() as well. </para>        
				/// </summary>
				/// <java-name>
				/// isResumed
				/// </java-name>
				public bool IsResumed
				{
						[Dot42.DexImport("isResumed", "()Z", AccessFlags = 17)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Return true if the fragment is currently visible to the user. This means it: (1) has been added, (2) has its view attached to the window, and (3) is not hidden. </para>        
				/// </summary>
				/// <java-name>
				/// isVisible
				/// </java-name>
				public bool IsVisible
				{
						[Dot42.DexImport("isVisible", "()Z", AccessFlags = 17)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Return true if the fragment has been hidden. By default fragments are shown. You can find out about changes to this state with onHiddenChanged. Note that the hidden state is orthogonal to other states  that is, to be visible to the user, a fragment must be both started and not hidden. </para>        
				/// </summary>
				/// <java-name>
				/// isHidden
				/// </java-name>
				public bool IsHidden
				{
						[Dot42.DexImport("isHidden", "()Z", AccessFlags = 17)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// getRetainInstance
				/// </java-name>
				public virtual bool RetainInstance
				{
						[Dot42.DexImport("getRetainInstance", "()Z", AccessFlags = 17)]
						get{ return default(bool); }
						[Dot42.DexImport("setRetainInstance", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para> <para>setUserVisibleHint(boolean) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>The current value of the user-visible hint on this fragment. </para>
				/// </returns>
				/// <java-name>
				/// getUserVisibleHint
				/// </java-name>
				public virtual bool UserVisibleHint
				{
						[Dot42.DexImport("getUserVisibleHint", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setUserVisibleHint", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Return the LoaderManager for this fragment, creating it if needed. </para>        
				/// </summary>
				/// <java-name>
				/// getLoaderManager
				/// </java-name>
				public virtual global::Android.App.LoaderManager LoaderManager
				{
						[Dot42.DexImport("getLoaderManager", "()Landroid/app/LoaderManager;", AccessFlags = 1)]
						get{ return default(global::Android.App.LoaderManager); }
				}

				/// <summary>
				///  <para>Get the root view for the fragment's layout (the one returned by onCreateView), if provided.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The fragment's root view, or null if it has no layout. </para>
				/// </returns>
				/// <java-name>
				/// getView
				/// </java-name>
				public virtual global::Android.Views.View View
				{
						[Dot42.DexImport("getView", "()Landroid/view/View;", AccessFlags = 1)]
						get{ return default(global::Android.Views.View); }
				}

				/// <summary>
				///  <para>Thrown by Fragment#instantiate(Context, String, Bundle) when there is an instantiation failure. </para>    
				/// </summary>
				/// <java-name>
				/// android/app/Fragment$InstantiationException
				/// </java-name>
				[Dot42.DexImport("android/app/Fragment$InstantiationException", AccessFlags = 9)]
				public partial class InstantiationException : global::Android.Util.AndroidRuntimeException
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Exception;)V", AccessFlags = 1)]
						public InstantiationException(string @string, global::System.Exception exception) /* MethodBuilder.Create */ 
						{
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal InstantiationException() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

				}

				/// <summary>
				///  <para>State information that has been retrieved from a fragment instance through FragmentManager.saveFragmentInstanceState. </para>    
				/// </summary>
				/// <java-name>
				/// android/app/Fragment$SavedState
				/// </java-name>
				[Dot42.DexImport("android/app/Fragment$SavedState", AccessFlags = 9)]
				public partial class SavedState : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// CREATOR
						/// </java-name>
						[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$ClassLoaderCreator;", AccessFlags = 25)]
						public static readonly global::Android.OS.IParcelable_IClassLoaderCreator<SavedState> CREATOR;
						[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
						internal SavedState() /* MethodBuilder.Create */ 
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

				}

		}

		/// <summary>
		///  <para>Helper class for showing "bread crumbs" representing the fragment stack in an activity. This is intended to be used with ActionBar.setCustomView(View) to place the bread crumbs in the action bar.</para> <para>The default style for this view is android.R.style#Widget_FragmentBreadCrumbs. </para>    
		/// </summary>
		/// <java-name>
		/// android/app/FragmentBreadCrumbs
		/// </java-name>
		[Dot42.DexImport("android/app/FragmentBreadCrumbs", AccessFlags = 33)]
		public partial class FragmentBreadCrumbs : global::Android.Views.ViewGroup, global::Android.App.FragmentManager.IOnBackStackChangedListener
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public FragmentBreadCrumbs(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public FragmentBreadCrumbs(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", AccessFlags = 1)]
				public FragmentBreadCrumbs(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs, int defStyle) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Attach the bread crumbs to their activity. This must be called once when creating the bread crumbs. </para>        
				/// </summary>
				/// <java-name>
				/// setActivity
				/// </java-name>
				[Dot42.DexImport("setActivity", "(Landroid/app/Activity;)V", AccessFlags = 1)]
				public virtual void SetActivity(global::Android.App.Activity a) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>The maximum number of breadcrumbs to show. Older fragment headers will be hidden from view. </para>        
				/// </summary>
				/// <java-name>
				/// setMaxVisible
				/// </java-name>
				[Dot42.DexImport("setMaxVisible", "(I)V", AccessFlags = 1)]
				public virtual void SetMaxVisible(int visibleCrumbs) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Inserts an optional parent entry at the first position in the breadcrumbs. Selecting this entry will result in a call to the specified listener's android.view.View.OnClickListener#onClick(View) method.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setParentTitle
				/// </java-name>
				[Dot42.DexImport("setParentTitle", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;Landroid/view/View$OnClickListen" +
    "er;)V", AccessFlags = 1)]
				public virtual void SetParentTitle(global::Java.Lang.ICharSequence title, global::Java.Lang.ICharSequence shortTitle, global::Android.Views.View.IOnClickListener listener) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets a listener for clicks on the bread crumbs. This will be called before the default click action is performed.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setOnBreadCrumbClickListener
				/// </java-name>
				[Dot42.DexImport("setOnBreadCrumbClickListener", "(Landroid/app/FragmentBreadCrumbs$OnBreadCrumbClickListener;)V", AccessFlags = 1)]
				public virtual void SetOnBreadCrumbClickListener(global::Android.App.FragmentBreadCrumbs.IOnBreadCrumbClickListener listener) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Set a custom title for the bread crumbs. This will be the first entry shown at the left, representing the root of the bread crumbs. If the title is null, it will not be shown. </para>        
				/// </summary>
				/// <java-name>
				/// setTitle
				/// </java-name>
				[Dot42.DexImport("setTitle", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)V", AccessFlags = 1)]
				public virtual void SetTitle(global::Java.Lang.ICharSequence title, global::Java.Lang.ICharSequence shortTitle) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onLayout
				/// </java-name>
				[Dot42.DexImport("onLayout", "(ZIIII)V", AccessFlags = 4)]
				protected internal override void OnLayout(bool changed, int l, int t, int r, int b) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onMeasure
				/// </java-name>
				[Dot42.DexImport("onMeasure", "(II)V", AccessFlags = 4)]
				protected internal override void OnMeasure(int widthMeasureSpec, int heightMeasureSpec) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Called whenever the contents of the back stack change. </para>        
				/// </summary>
				/// <java-name>
				/// onBackStackChanged
				/// </java-name>
				[Dot42.DexImport("onBackStackChanged", "()V", AccessFlags = 1)]
				public virtual void OnBackStackChanged() /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal FragmentBreadCrumbs() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Interface to intercept clicks on the bread crumbs. </para>    
				/// </summary>
				/// <java-name>
				/// android/app/FragmentBreadCrumbs$OnBreadCrumbClickListener
				/// </java-name>
				[Dot42.DexImport("android/app/FragmentBreadCrumbs$OnBreadCrumbClickListener", AccessFlags = 1545)]
				public partial interface IOnBreadCrumbClickListener
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>Called when a bread crumb is clicked.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>Return true to consume this click. Return to false to allow the default action (popping back stack to this entry) to occur. </para>
						/// </returns>
						/// <java-name>
						/// onBreadCrumbClick
						/// </java-name>
						[Dot42.DexImport("onBreadCrumbClick", "(Landroid/app/FragmentManager$BackStackEntry;I)Z", AccessFlags = 1025)]
						bool OnBreadCrumbClick(global::Android.App.FragmentManager.IBackStackEntry backStack, int flags) /* MethodBuilder.Create */ ;

				}

		}

		/// <summary>
		///  <para>Interface for interacting with Fragment objects inside of an Activity</para> <para>  <h3>Developer Guides</h3></para> <para> </para> <para>For more information about using fragments, read the  developer guide.</para> <para> </para> <para>While the FragmentManager API was introduced in android.os.Build.VERSION_CODES#HONEYCOMB, a version of the API at is also available for use on older platforms through android.support.v4.app.FragmentActivity. See the blog post  for more details. </para>    
		/// </summary>
		/// <java-name>
		/// android/app/FragmentManager
		/// </java-name>
		[Dot42.DexImport("android/app/FragmentManager", AccessFlags = 1057)]
		public abstract partial class FragmentManager
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Flag for popBackStack(String, int) and popBackStack(int, int): If set, and the name or ID of a back stack entry has been supplied, then all matching entries will be consumed until one that doesn't match is found or the bottom of the stack is reached. Otherwise, all entries up to but not including that entry will be removed. </para>        
				/// </summary>
				/// <java-name>
				/// POP_BACK_STACK_INCLUSIVE
				/// </java-name>
				[Dot42.DexImport("POP_BACK_STACK_INCLUSIVE", "I", AccessFlags = 25)]
				public const int POP_BACK_STACK_INCLUSIVE = 1;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public FragmentManager() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Start a series of edit operations on the Fragments associated with this FragmentManager.</para> <para>Note: A fragment transaction can only be created/committed prior to an activity saving its state. If you try to commit a transaction after Activity.onSaveInstanceState() (and prior to a following Activity.onStart or Activity.onResume(), you will get an error. This is because the framework takes care of saving your current fragments in the state, and if changes are made after the state is saved then they will be lost.</para>        
				/// </summary>
				/// <java-name>
				/// beginTransaction
				/// </java-name>
				[Dot42.DexImport("beginTransaction", "()Landroid/app/FragmentTransaction;", AccessFlags = 1025)]
				public abstract global::Android.App.FragmentTransaction BeginTransaction() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>After a FragmentTransaction is committed with FragmentTransaction.commit(), it is scheduled to be executed asynchronously on the process's main thread. If you want to immediately executing any such pending operations, you can call this function (only from the main thread) to do so. Note that all callbacks and other related behavior will be done from within this call, so be careful about where this is called from.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns true if there were any pending transactions to be executed. </para>
				/// </returns>
				/// <java-name>
				/// executePendingTransactions
				/// </java-name>
				[Dot42.DexImport("executePendingTransactions", "()Z", AccessFlags = 1025)]
				public abstract bool ExecutePendingTransactions() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Finds a fragment that was identified by the given id either when inflated from XML or as the container ID when added in a transaction. This first searches through fragments that are currently added to the manager's activity; if no such fragment is found, then all fragments currently on the back stack associated with this ID are searched. </para>        
				/// </summary>
				/// <returns>
				///  <para>The fragment if found or null otherwise. </para>
				/// </returns>
				/// <java-name>
				/// findFragmentById
				/// </java-name>
				[Dot42.DexImport("findFragmentById", "(I)Landroid/app/Fragment;", AccessFlags = 1025)]
				public abstract global::Android.App.Fragment FindFragmentById(int id) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Finds a fragment that was identified by the given tag either when inflated from XML or as supplied when added in a transaction. This first searches through fragments that are currently added to the manager's activity; if no such fragment is found, then all fragments currently on the back stack are searched. </para>        
				/// </summary>
				/// <returns>
				///  <para>The fragment if found or null otherwise. </para>
				/// </returns>
				/// <java-name>
				/// findFragmentByTag
				/// </java-name>
				[Dot42.DexImport("findFragmentByTag", "(Ljava/lang/String;)Landroid/app/Fragment;", AccessFlags = 1025)]
				public abstract global::Android.App.Fragment FindFragmentByTag(string tag) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Pop the top state off the back stack. This function is asynchronous  it enqueues the request to pop, but the action will not be performed until the application returns to its event loop. </para>        
				/// </summary>
				/// <java-name>
				/// popBackStack
				/// </java-name>
				[Dot42.DexImport("popBackStack", "()V", AccessFlags = 1025)]
				public abstract void PopBackStack() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Like popBackStack(), but performs the operation immediately inside of the call. This is like calling executePendingTransactions() afterwards. </para>        
				/// </summary>
				/// <returns>
				///  <para>Returns true if there was something popped, else false. </para>
				/// </returns>
				/// <java-name>
				/// popBackStackImmediate
				/// </java-name>
				[Dot42.DexImport("popBackStackImmediate", "()Z", AccessFlags = 1025)]
				public abstract bool PopBackStackImmediate() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Pop all back stack states up to the one with the given identifier. This function is asynchronous  it enqueues the request to pop, but the action will not be performed until the application returns to its event loop.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// popBackStack
				/// </java-name>
				[Dot42.DexImport("popBackStack", "(Ljava/lang/String;I)V", AccessFlags = 1025)]
				public abstract void PopBackStack(string id, int flags) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Like popBackStack(int, int), but performs the operation immediately inside of the call. This is like calling executePendingTransactions() afterwards. </para>        
				/// </summary>
				/// <returns>
				///  <para>Returns true if there was something popped, else false. </para>
				/// </returns>
				/// <java-name>
				/// popBackStackImmediate
				/// </java-name>
				[Dot42.DexImport("popBackStackImmediate", "(Ljava/lang/String;I)Z", AccessFlags = 1025)]
				public abstract bool PopBackStackImmediate(string id, int flags) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Pop all back stack states up to the one with the given identifier. This function is asynchronous  it enqueues the request to pop, but the action will not be performed until the application returns to its event loop.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// popBackStack
				/// </java-name>
				[Dot42.DexImport("popBackStack", "(II)V", AccessFlags = 1025)]
				public abstract void PopBackStack(int id, int flags) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Like popBackStack(int, int), but performs the operation immediately inside of the call. This is like calling executePendingTransactions() afterwards. </para>        
				/// </summary>
				/// <returns>
				///  <para>Returns true if there was something popped, else false. </para>
				/// </returns>
				/// <java-name>
				/// popBackStackImmediate
				/// </java-name>
				[Dot42.DexImport("popBackStackImmediate", "(II)Z", AccessFlags = 1025)]
				public abstract bool PopBackStackImmediate(int id, int flags) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Return the BackStackEntry at index  <b>index</b> in the back stack; entries start index 0 being the bottom of the stack. </para>        
				/// </summary>
				/// <java-name>
				/// getBackStackEntryAt
				/// </java-name>
				[Dot42.DexImport("getBackStackEntryAt", "(I)Landroid/app/FragmentManager$BackStackEntry;", AccessFlags = 1025)]
				public abstract global::Android.App.FragmentManager.IBackStackEntry GetBackStackEntryAt(int index) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Add a new listener for changes to the fragment back stack. </para>        
				/// </summary>
				/// <java-name>
				/// addOnBackStackChangedListener
				/// </java-name>
				[Dot42.DexImport("addOnBackStackChangedListener", "(Landroid/app/FragmentManager$OnBackStackChangedListener;)V", AccessFlags = 1025)]
				public abstract void AddOnBackStackChangedListener(global::Android.App.FragmentManager.IOnBackStackChangedListener listener) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Remove a listener that was previously added with addOnBackStackChangedListener(OnBackStackChangedListener). </para>        
				/// </summary>
				/// <java-name>
				/// removeOnBackStackChangedListener
				/// </java-name>
				[Dot42.DexImport("removeOnBackStackChangedListener", "(Landroid/app/FragmentManager$OnBackStackChangedListener;)V", AccessFlags = 1025)]
				public abstract void RemoveOnBackStackChangedListener(global::Android.App.FragmentManager.IOnBackStackChangedListener listener) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Put a reference to a fragment in a Bundle. This Bundle can be persisted as saved state, and when later restoring getFragment(Bundle, String) will return the current instance of the same fragment.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// putFragment
				/// </java-name>
				[Dot42.DexImport("putFragment", "(Landroid/os/Bundle;Ljava/lang/String;Landroid/app/Fragment;)V", AccessFlags = 1025)]
				public abstract void PutFragment(global::Android.OS.Bundle bundle, string key, global::Android.App.Fragment fragment) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Retrieve the current Fragment instance for a reference previously placed with putFragment(Bundle, String, Fragment).</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns the current Fragment instance that is associated with the given reference. </para>
				/// </returns>
				/// <java-name>
				/// getFragment
				/// </java-name>
				[Dot42.DexImport("getFragment", "(Landroid/os/Bundle;Ljava/lang/String;)Landroid/app/Fragment;", AccessFlags = 1025)]
				public abstract global::Android.App.Fragment GetFragment(global::Android.OS.Bundle bundle, string key) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Save the current instance state of the given Fragment. This can be used later when creating a new instance of the Fragment and adding it to the fragment manager, to have it create itself to match the current state returned here. Note that there are limits on how this can be used:</para> <para> <ul> <li> <para>The Fragment must currently be attached to the FragmentManager. </para></li> <li> <para>A new Fragment created using this saved state must be the same class type as the Fragment it was created from. </para></li> <li> <para>The saved state can not contain dependencies on other fragments  that is it can't use putFragment(Bundle, String, Fragment) to store a fragment reference because that reference may not be valid when this saved state is later used. Likewise the Fragment's target and result code are not included in this state. </para></li></ul></para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The generated state. This will be null if there was no interesting state created by the fragment. </para>
				/// </returns>
				/// <java-name>
				/// saveFragmentInstanceState
				/// </java-name>
				[Dot42.DexImport("saveFragmentInstanceState", "(Landroid/app/Fragment;)Landroid/app/Fragment$SavedState;", AccessFlags = 1025)]
				public abstract global::Android.App.Fragment.SavedState SaveFragmentInstanceState(global::Android.App.Fragment f) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Print the FragmentManager's state into the given stream.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// dump
				/// </java-name>
				[Dot42.DexImport("dump", "(Ljava/lang/String;Ljava/io/FileDescriptor;Ljava/io/PrintWriter;[Ljava/lang/Strin" +
    "g;)V", AccessFlags = 1025)]
				public abstract void Dump(string prefix, global::Java.IO.FileDescriptor fd, global::Java.IO.PrintWriter writer, string[] args) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Control whether the framework's internal fragment manager debugging logs are turned on. If enabled, you will see output in logcat as the framework performs fragment operations. </para>        
				/// </summary>
				/// <java-name>
				/// enableDebugLogging
				/// </java-name>
				[Dot42.DexImport("enableDebugLogging", "(Z)V", AccessFlags = 9)]
				public static void EnableDebugLogging(bool enabled) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Invalidate the attached activity's options menu as necessary. This may end up being deferred until we move to the resumed state. </para>        
				/// </summary>
				/// <java-name>
				/// invalidateOptionsMenu
				/// </java-name>
				[Dot42.DexImport("invalidateOptionsMenu", "()V", AccessFlags = 1)]
				public virtual void InvalidateOptionsMenu() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Return the number of entries currently in the back stack. </para>        
				/// </summary>
				/// <java-name>
				/// getBackStackEntryCount
				/// </java-name>
				public abstract int BackStackEntryCount
				{
						[Dot42.DexImport("getBackStackEntryCount", "()I", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Returns true if the final Activity.onDestroy() call has been made on the FragmentManager's Activity, so this instance is now dead. </para>        
				/// </summary>
				/// <java-name>
				/// isDestroyed
				/// </java-name>
				public abstract bool IsDestroyed
				{
						[Dot42.DexImport("isDestroyed", "()Z", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Interface to watch for changes to the back stack. </para>    
				/// </summary>
				/// <java-name>
				/// android/app/FragmentManager$OnBackStackChangedListener
				/// </java-name>
				[Dot42.DexImport("android/app/FragmentManager$OnBackStackChangedListener", AccessFlags = 1545)]
				public partial interface IOnBackStackChangedListener
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>Called whenever the contents of the back stack change. </para>        
						/// </summary>
						/// <java-name>
						/// onBackStackChanged
						/// </java-name>
						[Dot42.DexImport("onBackStackChanged", "()V", AccessFlags = 1025)]
						void OnBackStackChanged() /* MethodBuilder.Create */ ;

				}

				/// <summary>
				///  <para>Representation of an entry on the fragment back stack, as created with FragmentTransaction.addToBackStack(). Entries can later be retrieved with FragmentManager.getBackStackEntry().</para> <para>Note that you should never hold on to a BackStackEntry object; the identifier as returned by getId is the only thing that will be persisted across activity instances. </para>    
				/// </summary>
				/// <java-name>
				/// android/app/FragmentManager$BackStackEntry
				/// </java-name>
				[Dot42.DexImport("android/app/FragmentManager$BackStackEntry", AccessFlags = 1545)]
				public partial interface IBackStackEntry
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>Return the unique identifier for the entry. This is the only representation of the entry that will persist across activity instances. </para>        
						/// </summary>
						/// <java-name>
						/// getId
						/// </java-name>
						int Id
						{
								[Dot42.DexImport("getId", "()I", AccessFlags = 1025)]
								get;
						}

						/// <summary>
						///  <para>Get the name that was supplied to FragmentTransaction.addToBackStack(String) when creating this entry. </para>        
						/// </summary>
						/// <java-name>
						/// getName
						/// </java-name>
						string Name
						{
								[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1025)]
								get;
						}

						/// <summary>
						///  <para>Return the full bread crumb title resource identifier for the entry, or 0 if it does not have one. </para>        
						/// </summary>
						/// <java-name>
						/// getBreadCrumbTitleRes
						/// </java-name>
						int BreadCrumbTitleRes
						{
								[Dot42.DexImport("getBreadCrumbTitleRes", "()I", AccessFlags = 1025)]
								get;
						}

						/// <summary>
						///  <para>Return the short bread crumb title resource identifier for the entry, or 0 if it does not have one. </para>        
						/// </summary>
						/// <java-name>
						/// getBreadCrumbShortTitleRes
						/// </java-name>
						int BreadCrumbShortTitleRes
						{
								[Dot42.DexImport("getBreadCrumbShortTitleRes", "()I", AccessFlags = 1025)]
								get;
						}

						/// <summary>
						///  <para>Return the full bread crumb title for the entry, or null if it does not have one. </para>        
						/// </summary>
						/// <java-name>
						/// getBreadCrumbTitle
						/// </java-name>
						global::Java.Lang.ICharSequence BreadCrumbTitle
						{
								[Dot42.DexImport("getBreadCrumbTitle", "()Ljava/lang/CharSequence;", AccessFlags = 1025)]
								get;
						}

						/// <summary>
						///  <para>Return the short bread crumb title for the entry, or null if it does not have one. </para>        
						/// </summary>
						/// <java-name>
						/// getBreadCrumbShortTitle
						/// </java-name>
						global::Java.Lang.ICharSequence BreadCrumbShortTitle
						{
								[Dot42.DexImport("getBreadCrumbShortTitle", "()Ljava/lang/CharSequence;", AccessFlags = 1025)]
								get;
						}

				}

		}

		/// <summary>
		///  <para>API for performing a set of Fragment operations.</para> <para>  <h3>Developer Guides</h3></para> <para> </para> <para>For more information about using fragments, read the  developer guide.</para> <para>  </para>    
		/// </summary>
		/// <java-name>
		/// android/app/FragmentTransaction
		/// </java-name>
		[Dot42.DexImport("android/app/FragmentTransaction", AccessFlags = 1057)]
		public abstract partial class FragmentTransaction
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Bit mask that is set for all enter transitions. </para>        
				/// </summary>
				/// <java-name>
				/// TRANSIT_ENTER_MASK
				/// </java-name>
				[Dot42.DexImport("TRANSIT_ENTER_MASK", "I", AccessFlags = 25)]
				public const int TRANSIT_ENTER_MASK = 4096;
				/// <summary>
				///  <para>Bit mask that is set for all exit transitions. </para>        
				/// </summary>
				/// <java-name>
				/// TRANSIT_EXIT_MASK
				/// </java-name>
				[Dot42.DexImport("TRANSIT_EXIT_MASK", "I", AccessFlags = 25)]
				public const int TRANSIT_EXIT_MASK = 8192;
				/// <summary>
				///  <para>Not set up for a transition. </para>        
				/// </summary>
				/// <java-name>
				/// TRANSIT_UNSET
				/// </java-name>
				[Dot42.DexImport("TRANSIT_UNSET", "I", AccessFlags = 25)]
				public const int TRANSIT_UNSET = -1;
				/// <summary>
				///  <para>No animation for transition. </para>        
				/// </summary>
				/// <java-name>
				/// TRANSIT_NONE
				/// </java-name>
				[Dot42.DexImport("TRANSIT_NONE", "I", AccessFlags = 25)]
				public const int TRANSIT_NONE = 0;
				/// <summary>
				///  <para>Fragment is being added onto the stack </para>        
				/// </summary>
				/// <java-name>
				/// TRANSIT_FRAGMENT_OPEN
				/// </java-name>
				[Dot42.DexImport("TRANSIT_FRAGMENT_OPEN", "I", AccessFlags = 25)]
				public const int TRANSIT_FRAGMENT_OPEN = 4097;
				/// <summary>
				///  <para>Fragment is being removed from the stack </para>        
				/// </summary>
				/// <java-name>
				/// TRANSIT_FRAGMENT_CLOSE
				/// </java-name>
				[Dot42.DexImport("TRANSIT_FRAGMENT_CLOSE", "I", AccessFlags = 25)]
				public const int TRANSIT_FRAGMENT_CLOSE = 8194;
				/// <summary>
				///  <para>Fragment should simply fade in or out; that is, no strong navigation associated with it except that it is appearing or disappearing for some reason. </para>        
				/// </summary>
				/// <java-name>
				/// TRANSIT_FRAGMENT_FADE
				/// </java-name>
				[Dot42.DexImport("TRANSIT_FRAGMENT_FADE", "I", AccessFlags = 25)]
				public const int TRANSIT_FRAGMENT_FADE = 4099;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public FragmentTransaction() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Calls add(int, Fragment, String) with a null tag. </para>        
				/// </summary>
				/// <java-name>
				/// add
				/// </java-name>
				[Dot42.DexImport("add", "(Landroid/app/Fragment;Ljava/lang/String;)Landroid/app/FragmentTransaction;", AccessFlags = 1025)]
				public abstract global::Android.App.FragmentTransaction Add(global::Android.App.Fragment containerViewId, string fragment) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Calls add(int, Fragment, String) with a null tag. </para>        
				/// </summary>
				/// <java-name>
				/// add
				/// </java-name>
				[Dot42.DexImport("add", "(ILandroid/app/Fragment;)Landroid/app/FragmentTransaction;", AccessFlags = 1025)]
				public abstract global::Android.App.FragmentTransaction Add(int containerViewId, global::Android.App.Fragment fragment) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Add a fragment to the activity state. This fragment may optionally also have its view (if Fragment.onCreateView returns non-null) into a container view of the activity.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns the same FragmentTransaction instance. </para>
				/// </returns>
				/// <java-name>
				/// add
				/// </java-name>
				[Dot42.DexImport("add", "(ILandroid/app/Fragment;Ljava/lang/String;)Landroid/app/FragmentTransaction;", AccessFlags = 1025)]
				public abstract global::Android.App.FragmentTransaction Add(int containerViewId, global::Android.App.Fragment fragment, string tag) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Calls replace(int, Fragment, String) with a null tag. </para>        
				/// </summary>
				/// <java-name>
				/// replace
				/// </java-name>
				[Dot42.DexImport("replace", "(ILandroid/app/Fragment;)Landroid/app/FragmentTransaction;", AccessFlags = 1025)]
				public abstract global::Android.App.FragmentTransaction Replace(int containerViewId, global::Android.App.Fragment fragment) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Replace an existing fragment that was added to a container. This is essentially the same as calling remove(Fragment) for all currently added fragments that were added with the same containerViewId and then add(int, Fragment, String) with the same arguments given here.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns the same FragmentTransaction instance. </para>
				/// </returns>
				/// <java-name>
				/// replace
				/// </java-name>
				[Dot42.DexImport("replace", "(ILandroid/app/Fragment;Ljava/lang/String;)Landroid/app/FragmentTransaction;", AccessFlags = 1025)]
				public abstract global::Android.App.FragmentTransaction Replace(int containerViewId, global::Android.App.Fragment fragment, string tag) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Remove an existing fragment. If it was added to a container, its view is also removed from that container.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns the same FragmentTransaction instance. </para>
				/// </returns>
				/// <java-name>
				/// remove
				/// </java-name>
				[Dot42.DexImport("remove", "(Landroid/app/Fragment;)Landroid/app/FragmentTransaction;", AccessFlags = 1025)]
				public abstract global::Android.App.FragmentTransaction Remove(global::Android.App.Fragment fragment) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Hides an existing fragment. This is only relevant for fragments whose views have been added to a container, as this will cause the view to be hidden.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns the same FragmentTransaction instance. </para>
				/// </returns>
				/// <java-name>
				/// hide
				/// </java-name>
				[Dot42.DexImport("hide", "(Landroid/app/Fragment;)Landroid/app/FragmentTransaction;", AccessFlags = 1025)]
				public abstract global::Android.App.FragmentTransaction Hide(global::Android.App.Fragment fragment) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Shows a previously hidden fragment. This is only relevant for fragments whose views have been added to a container, as this will cause the view to be shown.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns the same FragmentTransaction instance. </para>
				/// </returns>
				/// <java-name>
				/// show
				/// </java-name>
				[Dot42.DexImport("show", "(Landroid/app/Fragment;)Landroid/app/FragmentTransaction;", AccessFlags = 1025)]
				public abstract global::Android.App.FragmentTransaction Show(global::Android.App.Fragment fragment) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Detach the given fragment from the UI. This is the same state as when it is put on the back stack: the fragment is removed from the UI, however its state is still being actively managed by the fragment manager. When going into this state its view hierarchy is destroyed.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns the same FragmentTransaction instance. </para>
				/// </returns>
				/// <java-name>
				/// detach
				/// </java-name>
				[Dot42.DexImport("detach", "(Landroid/app/Fragment;)Landroid/app/FragmentTransaction;", AccessFlags = 1025)]
				public abstract global::Android.App.FragmentTransaction Detach(global::Android.App.Fragment fragment) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Re-attach a fragment after it had previously been deatched from the UI with detach(Fragment). This causes its view hierarchy to be re-created, attached to the UI, and displayed.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns the same FragmentTransaction instance. </para>
				/// </returns>
				/// <java-name>
				/// attach
				/// </java-name>
				[Dot42.DexImport("attach", "(Landroid/app/Fragment;)Landroid/app/FragmentTransaction;", AccessFlags = 1025)]
				public abstract global::Android.App.FragmentTransaction Attach(global::Android.App.Fragment fragment) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Set specific animation resources to run for the fragments that are entering and exiting in this transaction. These animations will not be played when popping the back stack. </para>        
				/// </summary>
				/// <java-name>
				/// setCustomAnimations
				/// </java-name>
				[Dot42.DexImport("setCustomAnimations", "(II)Landroid/app/FragmentTransaction;", AccessFlags = 1025)]
				public abstract global::Android.App.FragmentTransaction SetCustomAnimations(int enter, int exit) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Set specific animation resources to run for the fragments that are entering and exiting in this transaction. The  <code>popEnter</code> and  <code>popExit</code> animations will be played for enter/exit operations specifically when popping the back stack. </para>        
				/// </summary>
				/// <java-name>
				/// setCustomAnimations
				/// </java-name>
				[Dot42.DexImport("setCustomAnimations", "(IIII)Landroid/app/FragmentTransaction;", AccessFlags = 1025)]
				public abstract global::Android.App.FragmentTransaction SetCustomAnimations(int enter, int exit, int popEnter, int popExit) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Select a standard transition animation for this transaction. May be one of TRANSIT_NONE, TRANSIT_FRAGMENT_OPEN, or TRANSIT_FRAGMENT_CLOSE </para>        
				/// </summary>
				/// <java-name>
				/// setTransition
				/// </java-name>
				[Dot42.DexImport("setTransition", "(I)Landroid/app/FragmentTransaction;", AccessFlags = 1025)]
				public abstract global::Android.App.FragmentTransaction SetTransition(int transit) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Set a custom style resource that will be used for resolving transit animations. </para>        
				/// </summary>
				/// <java-name>
				/// setTransitionStyle
				/// </java-name>
				[Dot42.DexImport("setTransitionStyle", "(I)Landroid/app/FragmentTransaction;", AccessFlags = 1025)]
				public abstract global::Android.App.FragmentTransaction SetTransitionStyle(int styleRes) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Add this transaction to the back stack. This means that the transaction will be remembered after it is committed, and will reverse its operation when later popped off the stack.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// addToBackStack
				/// </java-name>
				[Dot42.DexImport("addToBackStack", "(Ljava/lang/String;)Landroid/app/FragmentTransaction;", AccessFlags = 1025)]
				public abstract global::Android.App.FragmentTransaction AddToBackStack(string name) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Disallow calls to addToBackStack(String). Any future calls to addToBackStack will throw IllegalStateException. If addToBackStack has already been called, this method will throw IllegalStateException. </para>        
				/// </summary>
				/// <java-name>
				/// disallowAddToBackStack
				/// </java-name>
				[Dot42.DexImport("disallowAddToBackStack", "()Landroid/app/FragmentTransaction;", AccessFlags = 1025)]
				public abstract global::Android.App.FragmentTransaction DisallowAddToBackStack() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Set the full title to show as a bread crumb when this transaction is on the back stack, as used by FragmentBreadCrumbs.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setBreadCrumbTitle
				/// </java-name>
				[Dot42.DexImport("setBreadCrumbTitle", "(I)Landroid/app/FragmentTransaction;", AccessFlags = 1025)]
				public abstract global::Android.App.FragmentTransaction SetBreadCrumbTitle(int res) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Set the full title to show as a bread crumb when this transaction is on the back stack, as used by FragmentBreadCrumbs.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setBreadCrumbTitle
				/// </java-name>
				[Dot42.DexImport("setBreadCrumbTitle", "(Ljava/lang/CharSequence;)Landroid/app/FragmentTransaction;", AccessFlags = 1025)]
				public abstract global::Android.App.FragmentTransaction SetBreadCrumbTitle(global::Java.Lang.ICharSequence res) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Set the short title to show as a bread crumb when this transaction is on the back stack, as used by FragmentBreadCrumbs.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setBreadCrumbShortTitle
				/// </java-name>
				[Dot42.DexImport("setBreadCrumbShortTitle", "(I)Landroid/app/FragmentTransaction;", AccessFlags = 1025)]
				public abstract global::Android.App.FragmentTransaction SetBreadCrumbShortTitle(int res) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Set the short title to show as a bread crumb when this transaction is on the back stack, as used by FragmentBreadCrumbs.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setBreadCrumbShortTitle
				/// </java-name>
				[Dot42.DexImport("setBreadCrumbShortTitle", "(Ljava/lang/CharSequence;)Landroid/app/FragmentTransaction;", AccessFlags = 1025)]
				public abstract global::Android.App.FragmentTransaction SetBreadCrumbShortTitle(global::Java.Lang.ICharSequence res) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Schedules a commit of this transaction. The commit does not happen immediately; it will be scheduled as work on the main thread to be done the next time that thread is ready.</para> <para>A transaction can only be committed with this method prior to its containing activity saving its state. If the commit is attempted after that point, an exception will be thrown. This is because the state after the commit can be lost if the activity needs to be restored from its state. See commitAllowingStateLoss() for situations where it may be okay to lose the commit.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns the identifier of this transaction's back stack entry, if addToBackStack(String) had been called. Otherwise, returns a negative number. </para>
				/// </returns>
				/// <java-name>
				/// commit
				/// </java-name>
				[Dot42.DexImport("commit", "()I", AccessFlags = 1025)]
				public abstract int Commit() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Like commit but allows the commit to be executed after an activity's state is saved. This is dangerous because the commit can be lost if the activity needs to later be restored from its state, so this should only be used for cases where it is okay for the UI state to change unexpectedly on the user. </para>        
				/// </summary>
				/// <java-name>
				/// commitAllowingStateLoss
				/// </java-name>
				[Dot42.DexImport("commitAllowingStateLoss", "()I", AccessFlags = 1025)]
				public abstract int CommitAllowingStateLoss() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <code>true</code> if this transaction contains no operations,  <code>false</code> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isEmpty
				/// </java-name>
				public abstract bool IsEmpty
				{
						[Dot42.DexImport("isEmpty", "()Z", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Returns true if this FragmentTransaction is allowed to be added to the back stack. If this method would return false, addToBackStack(String) will throw IllegalStateException.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>True if addToBackStack(String) is permitted on this transaction. </para>
				/// </returns>
				/// <java-name>
				/// isAddToBackStackAllowed
				/// </java-name>
				public abstract bool IsAddToBackStackAllowed
				{
						[Dot42.DexImport("isAddToBackStackAllowed", "()Z", AccessFlags = 1025)]
						get;
				}

		}

		/// <summary>
		///  <para>Base class for implementing application instrumentation code. When running with instrumentation turned on, this class will be instantiated for you before any of the application code, allowing you to monitor all of the interaction the system has with the application. An Instrumentation implementation is described to the system through an AndroidManifest.xml's &lt;instrumentation&gt; tag. </para>    
		/// </summary>
		/// <java-name>
		/// android/app/Instrumentation
		/// </java-name>
		[Dot42.DexImport("android/app/Instrumentation", AccessFlags = 33)]
		public partial class Instrumentation
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>If included in the status or final bundle sent to an IInstrumentationWatcher, this key identifies the class that is writing the report. This can be used to provide more structured logging or reporting capabilities in the IInstrumentationWatcher. </para>        
				/// </summary>
				/// <java-name>
				/// REPORT_KEY_IDENTIFIER
				/// </java-name>
				[Dot42.DexImport("REPORT_KEY_IDENTIFIER", "Ljava/lang/String;", AccessFlags = 25)]
				public const string REPORT_KEY_IDENTIFIER = "id";
				/// <summary>
				///  <para>If included in the status or final bundle sent to an IInstrumentationWatcher, this key identifies a string which can simply be printed to the output stream. Using these streams provides a "pretty printer" version of the status &amp; final packets. Any bundles including this key should also include the complete set of raw key/value pairs, so that the instrumentation can also be launched, and results collected, by an automated system. </para>        
				/// </summary>
				/// <java-name>
				/// REPORT_KEY_STREAMRESULT
				/// </java-name>
				[Dot42.DexImport("REPORT_KEY_STREAMRESULT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string REPORT_KEY_STREAMRESULT = "stream";
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Instrumentation() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Called when the instrumentation is starting, before any application code has been loaded. Usually this will be implemented to simply call start to begin the instrumentation thread, which will then continue execution in onStart.</para> <para>If you do not need your own thread  that is you are writing your instrumentation to be completely asynchronous (returning to the event loop so that the application can run), you can simply begin your instrumentation here, for example call Context#startActivity to begin the appropriate first activity of the application.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// onCreate
				/// </java-name>
				[Dot42.DexImport("onCreate", "(Landroid/os/Bundle;)V", AccessFlags = 1)]
				public virtual void OnCreate(global::Android.OS.Bundle arguments) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Create and start a new thread in which to run instrumentation. This new thread will call to onStart where you can implement the instrumentation. </para>        
				/// </summary>
				/// <java-name>
				/// start
				/// </java-name>
				[Dot42.DexImport("start", "()V", AccessFlags = 1)]
				public virtual void Start() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Method where the instrumentation thread enters execution. This allows you to run your instrumentation code in a separate thread than the application, so that it can perform blocking operation such as sendKeySync or startActivitySync.</para> <para>You will typically want to call finish() when this function is done, to end your instrumentation. </para>        
				/// </summary>
				/// <java-name>
				/// onStart
				/// </java-name>
				[Dot42.DexImport("onStart", "()V", AccessFlags = 1)]
				public virtual void OnStart() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>This is called whenever the system captures an unhandled exception that was thrown by the application. The default implementation simply returns false, allowing normal system handling of the exception to take place.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>To allow normal system exception process to occur, return false. If true is returned, the system will proceed as if the exception didn't happen. </para>
				/// </returns>
				/// <java-name>
				/// onException
				/// </java-name>
				[Dot42.DexImport("onException", "(Ljava/lang/Object;Ljava/lang/Throwable;)Z", AccessFlags = 1)]
				public virtual bool OnException(object obj, global::System.Exception e) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Provide a status report about the application.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// sendStatus
				/// </java-name>
				[Dot42.DexImport("sendStatus", "(ILandroid/os/Bundle;)V", AccessFlags = 1)]
				public virtual void SendStatus(int resultCode, global::Android.OS.Bundle results) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Terminate instrumentation of the application. This will cause the application process to exit, removing this instrumentation from the next time the application is started.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// finish
				/// </java-name>
				[Dot42.DexImport("finish", "(ILandroid/os/Bundle;)V", AccessFlags = 1)]
				public virtual void Finish(int resultCode, global::Android.OS.Bundle results) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setAutomaticPerformanceSnapshots
				/// </java-name>
				[Dot42.DexImport("setAutomaticPerformanceSnapshots", "()V", AccessFlags = 1)]
				public virtual void SetAutomaticPerformanceSnapshots() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// startPerformanceSnapshot
				/// </java-name>
				[Dot42.DexImport("startPerformanceSnapshot", "()V", AccessFlags = 1)]
				public virtual void StartPerformanceSnapshot() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// endPerformanceSnapshot
				/// </java-name>
				[Dot42.DexImport("endPerformanceSnapshot", "()V", AccessFlags = 1)]
				public virtual void EndPerformanceSnapshot() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Called when the instrumented application is stopping, after all of the normal application cleanup has occurred. </para>        
				/// </summary>
				/// <java-name>
				/// onDestroy
				/// </java-name>
				[Dot42.DexImport("onDestroy", "()V", AccessFlags = 1)]
				public virtual void OnDestroy() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>This method will start profiling if isProfiling() returns true. You should only call this method if you set the handleProfiling attribute in the manifest file for this Instrumentation to true. </para>        
				/// </summary>
				/// <java-name>
				/// startProfiling
				/// </java-name>
				[Dot42.DexImport("startProfiling", "()V", AccessFlags = 1)]
				public virtual void StartProfiling() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Stops profiling if isProfiling() returns true. </para>        
				/// </summary>
				/// <java-name>
				/// stopProfiling
				/// </java-name>
				[Dot42.DexImport("stopProfiling", "()V", AccessFlags = 1)]
				public virtual void StopProfiling() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Force the global system in or out of touch mode. This can be used if your instrumentation relies on the UI being in one more or the other when it starts.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setInTouchMode
				/// </java-name>
				[Dot42.DexImport("setInTouchMode", "(Z)V", AccessFlags = 1)]
				public virtual void SetInTouchMode(bool inTouch) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Schedule a callback for when the application's main thread goes idle (has no more events to process).</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// waitForIdle
				/// </java-name>
				[Dot42.DexImport("waitForIdle", "(Ljava/lang/Runnable;)V", AccessFlags = 1)]
				public virtual void WaitForIdle(global::Java.Lang.IRunnable recipient) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Synchronously wait for the application to be idle. Can not be called from the main application thread  use start to execute instrumentation in its own thread. </para>        
				/// </summary>
				/// <java-name>
				/// waitForIdleSync
				/// </java-name>
				[Dot42.DexImport("waitForIdleSync", "()V", AccessFlags = 1)]
				public virtual void WaitForIdleSync() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Execute a call on the application's main thread, blocking until it is complete. Useful for doing things that are not thread-safe, such as looking at or modifying the view hierarchy.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// runOnMainSync
				/// </java-name>
				[Dot42.DexImport("runOnMainSync", "(Ljava/lang/Runnable;)V", AccessFlags = 1)]
				public virtual void RunOnMainSync(global::Java.Lang.IRunnable runner) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Start a new activity and wait for it to begin running before returning. In addition to being synchronous, this method as some semantic differences from the standard Context#startActivity call: the activity component is resolved before talking with the activity manager (its class name is specified in the Intent that this method ultimately starts), and it does not allow you to start activities that run in a different process. In addition, if the given Intent resolves to multiple activities, instead of displaying a dialog for the user to select an activity, an exception will be thrown.</para> <para>The function returns as soon as the activity goes idle following the call to its Activity#onCreate. Generally this means it has gone through the full initialization including Activity#onResume and drawn and displayed its initial window.</para> <para> <para>Context::startActivity </para></para>        
				/// </summary>
				/// <java-name>
				/// startActivitySync
				/// </java-name>
				[Dot42.DexImport("startActivitySync", "(Landroid/content/Intent;)Landroid/app/Activity;", AccessFlags = 1)]
				public virtual global::Android.App.Activity StartActivitySync(global::Android.Content.Intent intent) /* MethodBuilder.Create */ 
				{
						return default(global::Android.App.Activity);
				}

				/// <summary>
				///  <para>Add a new ActivityMonitor that will be checked whenever an activity is started. The monitor is added after any existing ones; the monitor will be hit only if none of the existing monitors can themselves handle the Intent.</para> <para> <para>addMonitor(IntentFilter, ActivityResult, boolean) </para> <para>checkMonitorHit </para></para>        
				/// </summary>
				/// <java-name>
				/// addMonitor
				/// </java-name>
				[Dot42.DexImport("addMonitor", "(Landroid/app/Instrumentation$ActivityMonitor;)V", AccessFlags = 1)]
				public virtual void AddMonitor(global::Android.App.Instrumentation.ActivityMonitor monitor) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addMonitor
				/// </java-name>
				[Dot42.DexImport("addMonitor", "(Landroid/content/IntentFilter;Landroid/app/Instrumentation$ActivityResult;Z)Land" +
    "roid/app/Instrumentation$ActivityMonitor;", AccessFlags = 1)]
				public virtual global::Android.App.Instrumentation.ActivityMonitor AddMonitor(global::Android.Content.IntentFilter intentFilter, global::Android.App.Instrumentation.ActivityResult activityResult, bool boolean) /* MethodBuilder.Create */ 
				{
						return default(global::Android.App.Instrumentation.ActivityMonitor);
				}

				/// <java-name>
				/// addMonitor
				/// </java-name>
				[Dot42.DexImport("addMonitor", "(Ljava/lang/String;Landroid/app/Instrumentation$ActivityResult;Z)Landroid/app/Ins" +
    "trumentation$ActivityMonitor;", AccessFlags = 1)]
				public virtual global::Android.App.Instrumentation.ActivityMonitor AddMonitor(string @string, global::Android.App.Instrumentation.ActivityResult activityResult, bool boolean) /* MethodBuilder.Create */ 
				{
						return default(global::Android.App.Instrumentation.ActivityMonitor);
				}

				/// <summary>
				///  <para>Test whether an existing ActivityMonitor has been hit. If the monitor has been hit at least  <b>minHits</b> times, then it will be removed from the activity monitor list and true returned. Otherwise it is left as-is and false is returned.</para> <para> <para>addMonitor </para></para>        
				/// </summary>
				/// <returns>
				///  <para>True if the hit count has been reached, else false.</para>
				/// </returns>
				/// <java-name>
				/// checkMonitorHit
				/// </java-name>
				[Dot42.DexImport("checkMonitorHit", "(Landroid/app/Instrumentation$ActivityMonitor;I)Z", AccessFlags = 1)]
				public virtual bool CheckMonitorHit(global::Android.App.Instrumentation.ActivityMonitor monitor, int minHits) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Wait for an existing ActivityMonitor to be hit. Once the monitor has been hit, it is removed from the activity monitor list and the first created Activity object that matched it is returned.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The Activity object that matched the monitor. </para>
				/// </returns>
				/// <java-name>
				/// waitForMonitor
				/// </java-name>
				[Dot42.DexImport("waitForMonitor", "(Landroid/app/Instrumentation$ActivityMonitor;)Landroid/app/Activity;", AccessFlags = 1)]
				public virtual global::Android.App.Activity WaitForMonitor(global::Android.App.Instrumentation.ActivityMonitor monitor) /* MethodBuilder.Create */ 
				{
						return default(global::Android.App.Activity);
				}

				/// <summary>
				///  <para>Wait for an existing ActivityMonitor to be hit till the timeout expires. Once the monitor has been hit, it is removed from the activity monitor list and the first created Activity object that matched it is returned. If the timeout expires, a null object is returned.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The Activity object that matched the monitor. </para>
				/// </returns>
				/// <java-name>
				/// waitForMonitorWithTimeout
				/// </java-name>
				[Dot42.DexImport("waitForMonitorWithTimeout", "(Landroid/app/Instrumentation$ActivityMonitor;J)Landroid/app/Activity;", AccessFlags = 1)]
				public virtual global::Android.App.Activity WaitForMonitorWithTimeout(global::Android.App.Instrumentation.ActivityMonitor monitor, long timeOut) /* MethodBuilder.Create */ 
				{
						return default(global::Android.App.Activity);
				}

				/// <summary>
				///  <para>Remove an ActivityMonitor that was previously added with addMonitor.</para> <para> <para>addMonitor </para></para>        
				/// </summary>
				/// <java-name>
				/// removeMonitor
				/// </java-name>
				[Dot42.DexImport("removeMonitor", "(Landroid/app/Instrumentation$ActivityMonitor;)V", AccessFlags = 1)]
				public virtual void RemoveMonitor(global::Android.App.Instrumentation.ActivityMonitor monitor) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Execute a particular menu item.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Whether the invocation was successful (for example, it could be false if item is disabled). </para>
				/// </returns>
				/// <java-name>
				/// invokeMenuActionSync
				/// </java-name>
				[Dot42.DexImport("invokeMenuActionSync", "(Landroid/app/Activity;II)Z", AccessFlags = 1)]
				public virtual bool InvokeMenuActionSync(global::Android.App.Activity targetActivity, int id, int flag) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Show the context menu for the currently focused view and executes a particular context menu item.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Whether the invocation was successful (for example, it could be false if item is disabled). </para>
				/// </returns>
				/// <java-name>
				/// invokeContextMenuAction
				/// </java-name>
				[Dot42.DexImport("invokeContextMenuAction", "(Landroid/app/Activity;II)Z", AccessFlags = 1)]
				public virtual bool InvokeContextMenuAction(global::Android.App.Activity targetActivity, int id, int flag) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Sends the key events corresponding to the text to the app being instrumented.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// sendStringSync
				/// </java-name>
				[Dot42.DexImport("sendStringSync", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SendStringSync(string text) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Send a key event to the currently focused window/view and wait for it to be processed. Finished at some point after the recipient has returned from its event processing, though it may  <b>not</b> have completely finished reacting from the event  for example, if it needs to update its display as a result, it may still be in the process of doing that.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// sendKeySync
				/// </java-name>
				[Dot42.DexImport("sendKeySync", "(Landroid/view/KeyEvent;)V", AccessFlags = 1)]
				public virtual void SendKeySync(global::Android.Views.KeyEvent @event) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sends an up and down key event sync to the currently focused window.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// sendKeyDownUpSync
				/// </java-name>
				[Dot42.DexImport("sendKeyDownUpSync", "(I)V", AccessFlags = 1)]
				public virtual void SendKeyDownUpSync(int key) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Higher-level method for sending both the down and up key events for a particular character key code. Equivalent to creating both KeyEvent objects by hand and calling sendKeySync. The event appears as if it came from keyboard 0, the built in one.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// sendCharacterSync
				/// </java-name>
				[Dot42.DexImport("sendCharacterSync", "(I)V", AccessFlags = 1)]
				public virtual void SendCharacterSync(int keyCode) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Dispatch a pointer event. Finished at some point after the recipient has returned from its event processing, though it may  <b>not</b> have completely finished reacting from the event  for example, if it needs to update its display as a result, it may still be in the process of doing that.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// sendPointerSync
				/// </java-name>
				[Dot42.DexImport("sendPointerSync", "(Landroid/view/MotionEvent;)V", AccessFlags = 1)]
				public virtual void SendPointerSync(global::Android.Views.MotionEvent @event) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Dispatch a trackball event. Finished at some point after the recipient has returned from its event processing, though it may  <b>not</b> have completely finished reacting from the event  for example, if it needs to update its display as a result, it may still be in the process of doing that.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// sendTrackballEventSync
				/// </java-name>
				[Dot42.DexImport("sendTrackballEventSync", "(Landroid/view/MotionEvent;)V", AccessFlags = 1)]
				public virtual void SendTrackballEventSync(global::Android.Views.MotionEvent @event) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Perform instantiation of the process's Application object. The default implementation provides the normal system behavior.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The newly instantiated Application object. </para>
				/// </returns>
				/// <java-name>
				/// newApplication
				/// </java-name>
				[Dot42.DexImport("newApplication", "(Ljava/lang/ClassLoader;Ljava/lang/String;Landroid/content/Context;)Landroid/app/" +
    "Application;", AccessFlags = 1)]
				public virtual global::Android.App.Application NewApplication(global::Java.Lang.ClassLoader cl, string className, global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
						return default(global::Android.App.Application);
				}

				/// <summary>
				///  <para>Perform instantiation of the process's Application object. The default implementation provides the normal system behavior.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The newly instantiated Application object. </para>
				/// </returns>
				/// <java-name>
				/// newApplication
				/// </java-name>
				[Dot42.DexImport("newApplication", "(Ljava/lang/Class;Landroid/content/Context;)Landroid/app/Application;", AccessFlags = 9, Signature = "(Ljava/lang/Class<*>;Landroid/content/Context;)Landroid/app/Application;")]
				public static global::Android.App.Application NewApplication(global::System.Type clazz, global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
						return default(global::Android.App.Application);
				}

				/// <summary>
				///  <para>Perform calling of the application's Application#onCreate method. The default implementation simply calls through to that method.</para> <para>Note: This method will be called immediately after onCreate(Bundle). Often instrumentation tests start their test thread in onCreate(); you need to be careful of races between these. (Well between it and everything else, but let's start here.)</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// callApplicationOnCreate
				/// </java-name>
				[Dot42.DexImport("callApplicationOnCreate", "(Landroid/app/Application;)V", AccessFlags = 1)]
				public virtual void CallApplicationOnCreate(global::Android.App.Application app) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Perform instantiation of an Activity object. This method is intended for use with unit tests, such as android.test.ActivityUnitTestCase. The activity will be useable locally but will be missing some of the linkages necessary for use within the sytem.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns the instantiated activity </para>
				/// </returns>
				/// <java-name>
				/// newActivity
				/// </java-name>
				[Dot42.DexImport("newActivity", "(Ljava/lang/Class;Landroid/content/Context;Landroid/os/IBinder;Landroid/app/Appli" +
    "cation;Landroid/content/Intent;Landroid/content/pm/ActivityInfo;Ljava/lang/CharS" +
    "equence;Landroid/app/Activity;Ljava/lang/String;Ljava/lang/Object;)Landroid/app/" +
    "Activity;", AccessFlags = 1, Signature = "(Ljava/lang/Class<*>;Landroid/content/Context;Landroid/os/IBinder;Landroid/app/Ap" +
    "plication;Landroid/content/Intent;Landroid/content/pm/ActivityInfo;Ljava/lang/Ch" +
    "arSequence;Landroid/app/Activity;Ljava/lang/String;Ljava/lang/Object;)Landroid/a" +
    "pp/Activity;")]
				public virtual global::Android.App.Activity NewActivity(global::System.Type clazz, global::Android.Content.Context context, global::Android.OS.IBinder token, global::Android.App.Application application, global::Android.Content.Intent intent, global::Android.Content.PM.ActivityInfo info, global::Java.Lang.ICharSequence title, global::Android.App.Activity parent, string id, object lastNonConfigurationInstance) /* MethodBuilder.Create */ 
				{
						return default(global::Android.App.Activity);
				}

				/// <summary>
				///  <para>Perform instantiation of the process's Activity object. The default implementation provides the normal system behavior.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The newly instantiated Activity object. </para>
				/// </returns>
				/// <java-name>
				/// newActivity
				/// </java-name>
				[Dot42.DexImport("newActivity", "(Ljava/lang/ClassLoader;Ljava/lang/String;Landroid/content/Intent;)Landroid/app/A" +
    "ctivity;", AccessFlags = 1)]
				public virtual global::Android.App.Activity NewActivity(global::Java.Lang.ClassLoader cl, string className, global::Android.Content.Intent intent) /* MethodBuilder.Create */ 
				{
						return default(global::Android.App.Activity);
				}

				/// <summary>
				///  <para>Perform calling of an activity's Activity#onCreate method. The default implementation simply calls through to that method.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// callActivityOnCreate
				/// </java-name>
				[Dot42.DexImport("callActivityOnCreate", "(Landroid/app/Activity;Landroid/os/Bundle;)V", AccessFlags = 1)]
				public virtual void CallActivityOnCreate(global::Android.App.Activity activity, global::Android.OS.Bundle icicle) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// callActivityOnDestroy
				/// </java-name>
				[Dot42.DexImport("callActivityOnDestroy", "(Landroid/app/Activity;)V", AccessFlags = 1)]
				public virtual void CallActivityOnDestroy(global::Android.App.Activity activity) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Perform calling of an activity's Activity#onRestoreInstanceState method. The default implementation simply calls through to that method.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// callActivityOnRestoreInstanceState
				/// </java-name>
				[Dot42.DexImport("callActivityOnRestoreInstanceState", "(Landroid/app/Activity;Landroid/os/Bundle;)V", AccessFlags = 1)]
				public virtual void CallActivityOnRestoreInstanceState(global::Android.App.Activity activity, global::Android.OS.Bundle savedInstanceState) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Perform calling of an activity's Activity#onPostCreate method. The default implementation simply calls through to that method.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// callActivityOnPostCreate
				/// </java-name>
				[Dot42.DexImport("callActivityOnPostCreate", "(Landroid/app/Activity;Landroid/os/Bundle;)V", AccessFlags = 1)]
				public virtual void CallActivityOnPostCreate(global::Android.App.Activity activity, global::Android.OS.Bundle icicle) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Perform calling of an activity's Activity#onNewIntent method. The default implementation simply calls through to that method.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// callActivityOnNewIntent
				/// </java-name>
				[Dot42.DexImport("callActivityOnNewIntent", "(Landroid/app/Activity;Landroid/content/Intent;)V", AccessFlags = 1)]
				public virtual void CallActivityOnNewIntent(global::Android.App.Activity activity, global::Android.Content.Intent intent) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Perform calling of an activity's Activity#onStart method. The default implementation simply calls through to that method.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// callActivityOnStart
				/// </java-name>
				[Dot42.DexImport("callActivityOnStart", "(Landroid/app/Activity;)V", AccessFlags = 1)]
				public virtual void CallActivityOnStart(global::Android.App.Activity activity) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Perform calling of an activity's Activity#onRestart method. The default implementation simply calls through to that method.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// callActivityOnRestart
				/// </java-name>
				[Dot42.DexImport("callActivityOnRestart", "(Landroid/app/Activity;)V", AccessFlags = 1)]
				public virtual void CallActivityOnRestart(global::Android.App.Activity activity) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Perform calling of an activity's Activity#onResume method. The default implementation simply calls through to that method.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// callActivityOnResume
				/// </java-name>
				[Dot42.DexImport("callActivityOnResume", "(Landroid/app/Activity;)V", AccessFlags = 1)]
				public virtual void CallActivityOnResume(global::Android.App.Activity activity) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Perform calling of an activity's Activity#onStop method. The default implementation simply calls through to that method.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// callActivityOnStop
				/// </java-name>
				[Dot42.DexImport("callActivityOnStop", "(Landroid/app/Activity;)V", AccessFlags = 1)]
				public virtual void CallActivityOnStop(global::Android.App.Activity activity) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Perform calling of an activity's Activity#onPause method. The default implementation simply calls through to that method.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// callActivityOnSaveInstanceState
				/// </java-name>
				[Dot42.DexImport("callActivityOnSaveInstanceState", "(Landroid/app/Activity;Landroid/os/Bundle;)V", AccessFlags = 1)]
				public virtual void CallActivityOnSaveInstanceState(global::Android.App.Activity activity, global::Android.OS.Bundle outState) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Perform calling of an activity's Activity#onPause method. The default implementation simply calls through to that method.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// callActivityOnPause
				/// </java-name>
				[Dot42.DexImport("callActivityOnPause", "(Landroid/app/Activity;)V", AccessFlags = 1)]
				public virtual void CallActivityOnPause(global::Android.App.Activity activity) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Perform calling of an activity's Activity#onUserLeaveHint method. The default implementation simply calls through to that method.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// callActivityOnUserLeaving
				/// </java-name>
				[Dot42.DexImport("callActivityOnUserLeaving", "(Landroid/app/Activity;)V", AccessFlags = 1)]
				public virtual void CallActivityOnUserLeaving(global::Android.App.Activity activity) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// startAllocCounting
				/// </java-name>
				[Dot42.DexImport("startAllocCounting", "()V", AccessFlags = 1)]
				public virtual void StartAllocCounting() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// stopAllocCounting
				/// </java-name>
				[Dot42.DexImport("stopAllocCounting", "()V", AccessFlags = 1)]
				public virtual void StopAllocCounting() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Return the Context of this instrumentation's package. Note that this is often different than the Context of the application being instrumentated, since the instrumentation code often lives is a different package than that of the application it is running against. See getTargetContext to retrieve a Context for the target application.</para> <para> <para>getTargetContext </para></para>        
				/// </summary>
				/// <returns>
				///  <para>The instrumentation's package context.</para>
				/// </returns>
				/// <java-name>
				/// getContext
				/// </java-name>
				public virtual global::Android.Content.Context Context
				{
						[Dot42.DexImport("getContext", "()Landroid/content/Context;", AccessFlags = 1)]
						get{ return default(global::Android.Content.Context); }
				}

				/// <summary>
				///  <para>Returns complete component name of this instrumentation.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns the complete component name for this instrumentation. </para>
				/// </returns>
				/// <java-name>
				/// getComponentName
				/// </java-name>
				public virtual global::Android.Content.ComponentName ComponentName
				{
						[Dot42.DexImport("getComponentName", "()Landroid/content/ComponentName;", AccessFlags = 1)]
						get{ return default(global::Android.Content.ComponentName); }
				}

				/// <summary>
				///  <para>Return a Context for the target application being instrumented. Note that this is often different than the Context of the instrumentation code, since the instrumentation code often lives is a different package than that of the application it is running against. See getContext to retrieve a Context for the instrumentation code.</para> <para> <para>getContext </para></para>        
				/// </summary>
				/// <returns>
				///  <para>A Context in the target application.</para>
				/// </returns>
				/// <java-name>
				/// getTargetContext
				/// </java-name>
				public virtual global::Android.Content.Context TargetContext
				{
						[Dot42.DexImport("getTargetContext", "()Landroid/content/Context;", AccessFlags = 1)]
						get{ return default(global::Android.Content.Context); }
				}

				/// <summary>
				///  <para>Check whether this instrumentation was started with profiling enabled.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns true if profiling was enabled when starting, else false. </para>
				/// </returns>
				/// <java-name>
				/// isProfiling
				/// </java-name>
				public virtual bool IsProfiling
				{
						[Dot42.DexImport("isProfiling", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Returns a bundle with the current results from the allocation counting. </para>        
				/// </summary>
				/// <java-name>
				/// getAllocCounts
				/// </java-name>
				public virtual global::Android.OS.Bundle AllocCounts
				{
						[Dot42.DexImport("getAllocCounts", "()Landroid/os/Bundle;", AccessFlags = 1)]
						get{ return default(global::Android.OS.Bundle); }
				}

				/// <summary>
				///  <para>Returns a bundle with the counts for various binder counts for this process. Currently the only two that are reported are the number of send and the number of received transactions. </para>        
				/// </summary>
				/// <java-name>
				/// getBinderCounts
				/// </java-name>
				public virtual global::Android.OS.Bundle BinderCounts
				{
						[Dot42.DexImport("getBinderCounts", "()Landroid/os/Bundle;", AccessFlags = 1)]
						get{ return default(global::Android.OS.Bundle); }
				}

				/// <summary>
				///  <para>Gets the UiAutomation instance. </para> <para> <b>Note:</b> The APIs exposed via the returned UiAutomation work across application boundaries while the APIs exposed by the instrumentation do not. For example, Instrumentation#sendPointerSync(MotionEvent) will not allow you to inject the event in an app different from the instrumentation target, while UiAutomation#injectInputEvent(android.view.InputEvent, boolean) will work regardless of the current application. </para> <para>A typical test case should be using either the UiAutomation or Instrumentation APIs. Using both APIs at the same time is not a mistake by itself but a client has to be aware of the APIs limitations. </para> <para> <para>UiAutomation </para></para>        
				/// </summary>
				/// <returns>
				///  <para>The UI automation instance.</para>
				/// </returns>
				/// <java-name>
				/// getUiAutomation
				/// </java-name>
				public virtual global::Android.App.UiAutomation UiAutomation
				{
						[Dot42.DexImport("getUiAutomation", "()Landroid/app/UiAutomation;", AccessFlags = 1)]
						get{ return default(global::Android.App.UiAutomation); }
				}

				/// <summary>
				///  <para>Description of a Activity execution result to return to the original activity. </para>    
				/// </summary>
				/// <java-name>
				/// android/app/Instrumentation$ActivityResult
				/// </java-name>
				[Dot42.DexImport("android/app/Instrumentation$ActivityResult", AccessFlags = 25)]
				public sealed partial class ActivityResult
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "(ILandroid/content/Intent;)V", AccessFlags = 1)]
						public ActivityResult(int int32, global::Android.Content.Intent intent) /* MethodBuilder.Create */ 
						{
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal ActivityResult() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

						/// <summary>
						///  <para>Retrieve the result code contained in this result. </para>        
						/// </summary>
						/// <java-name>
						/// getResultCode
						/// </java-name>
						public int ResultCode
						{
								[Dot42.DexImport("getResultCode", "()I", AccessFlags = 1)]
								get{ return default(int); }
						}

						/// <summary>
						///  <para>Retrieve the data contained in this result. </para>        
						/// </summary>
						/// <java-name>
						/// getResultData
						/// </java-name>
						public global::Android.Content.Intent ResultData
						{
								[Dot42.DexImport("getResultData", "()Landroid/content/Intent;", AccessFlags = 1)]
								get{ return default(global::Android.Content.Intent); }
						}

				}

				/// <summary>
				///  <para>Information about a particular kind of Intent that is being monitored. An instance of this class is added to the current instrumentation through addMonitor; after being added, when a new activity is being started the monitor will be checked and, if matching, its hit count updated and (optionally) the call stopped and a canned result returned.</para> <para>An ActivityMonitor can also be used to look for the creation of an activity, through the waitForActivity method. This will return after a matching activity has been created with that activity object. </para>    
				/// </summary>
				/// <java-name>
				/// android/app/Instrumentation$ActivityMonitor
				/// </java-name>
				[Dot42.DexImport("android/app/Instrumentation$ActivityMonitor", AccessFlags = 9)]
				public partial class ActivityMonitor
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "(Landroid/content/IntentFilter;Landroid/app/Instrumentation$ActivityResult;Z)V", AccessFlags = 1)]
						public ActivityMonitor(global::Android.Content.IntentFilter intentFilter, global::Android.App.Instrumentation.ActivityResult activityResult, bool boolean) /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "(Ljava/lang/String;Landroid/app/Instrumentation$ActivityResult;Z)V", AccessFlags = 1)]
						public ActivityMonitor(string @string, global::Android.App.Instrumentation.ActivityResult activityResult, bool boolean) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Block until an Activity is created that matches this monitor, returning the resulting activity.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>Activity </para>
						/// </returns>
						/// <java-name>
						/// waitForActivity
						/// </java-name>
						[Dot42.DexImport("waitForActivity", "()Landroid/app/Activity;", AccessFlags = 17)]
						public global::Android.App.Activity WaitForActivity() /* MethodBuilder.Create */ 
						{
								return default(global::Android.App.Activity);
						}

						/// <summary>
						///  <para>Block until an Activity is created that matches this monitor, returning the resulting activity or till the timeOut period expires. If the timeOut expires before the activity is started, return null.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>Activity </para>
						/// </returns>
						/// <java-name>
						/// waitForActivityWithTimeout
						/// </java-name>
						[Dot42.DexImport("waitForActivityWithTimeout", "(J)Landroid/app/Activity;", AccessFlags = 17)]
						public global::Android.App.Activity WaitForActivityWithTimeout(long timeOut) /* MethodBuilder.Create */ 
						{
								return default(global::Android.App.Activity);
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal ActivityMonitor() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

						/// <summary>
						///  <para>Retrieve the filter associated with this ActivityMonitor. </para>        
						/// </summary>
						/// <java-name>
						/// getFilter
						/// </java-name>
						public global::Android.Content.IntentFilter Filter
						{
								[Dot42.DexImport("getFilter", "()Landroid/content/IntentFilter;", AccessFlags = 17)]
								get{ return default(global::Android.Content.IntentFilter); }
						}

						/// <summary>
						///  <para>Retrieve the result associated with this ActivityMonitor, or null if none. </para>        
						/// </summary>
						/// <java-name>
						/// getResult
						/// </java-name>
						public global::Android.App.Instrumentation.ActivityResult Result
						{
								[Dot42.DexImport("getResult", "()Landroid/app/Instrumentation$ActivityResult;", AccessFlags = 17)]
								get{ return default(global::Android.App.Instrumentation.ActivityResult); }
						}

						/// <summary>
						///  <para>Check whether this monitor blocks activity starts (not allowing the actual activity to run) or allows them to execute normally. </para>        
						/// </summary>
						/// <java-name>
						/// isBlocking
						/// </java-name>
						public bool IsBlocking
						{
								[Dot42.DexImport("isBlocking", "()Z", AccessFlags = 17)]
								get{ return default(bool); }
						}

						/// <summary>
						///  <para>Retrieve the number of times the monitor has been hit so far. </para>        
						/// </summary>
						/// <java-name>
						/// getHits
						/// </java-name>
						public int Hits
						{
								[Dot42.DexImport("getHits", "()I", AccessFlags = 17)]
								get{ return default(int); }
						}

						/// <summary>
						///  <para>Retrieve the most recent activity class that was seen by this monitor. </para>        
						/// </summary>
						/// <java-name>
						/// getLastActivity
						/// </java-name>
						public global::Android.App.Activity LastActivity
						{
								[Dot42.DexImport("getLastActivity", "()Landroid/app/Activity;", AccessFlags = 17)]
								get{ return default(global::Android.App.Activity); }
						}

				}

		}

		/// <summary>
		///  <para>IntentService is a base class for Services that handle asynchronous requests (expressed as Intents) on demand. Clients send requests through android.content.Context#startService(Intent) calls; the service is started as needed, handles each Intent in turn using a worker thread, and stops itself when it runs out of work.</para> <para>This "work queue processor" pattern is commonly used to offload tasks from an application's main thread. The IntentService class exists to simplify this pattern and take care of the mechanics. To use it, extend IntentService and implement onHandleIntent(Intent). IntentService will receive the Intents, launch a worker thread, and stop the service as appropriate.</para> <para>All requests are handled on a single worker thread  they may take as long as necessary (and will not block the application's main loop), but only one request will be processed at a time.</para> <para>  <h3>Developer Guides</h3></para> <para> </para> <para>For a detailed discussion about how to create services, read the  developer guide.</para> <para> </para> <para> <para>android.os.AsyncTask </para></para>    
		/// </summary>
		/// <java-name>
		/// android/app/IntentService
		/// </java-name>
		[Dot42.DexImport("android/app/IntentService", AccessFlags = 1057)]
		public abstract partial class IntentService : global::Android.App.Service
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Creates an IntentService. Invoked by your subclass's constructor.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public IntentService(string name) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets intent redelivery preferences. Usually called from the constructor with your preferred semantics.</para> <para>If enabled is true, onStartCommand(Intent, int, int) will return Service#START_REDELIVER_INTENT, so if this process dies before onHandleIntent(Intent) returns, the process will be restarted and the intent redelivered. If multiple Intents have been sent, only the most recent one is guaranteed to be redelivered.</para> <para>If enabled is false (the default), onStartCommand(Intent, int, int) will return Service#START_NOT_STICKY, and if the process dies, the Intent dies along with it. </para>        
				/// </summary>
				/// <java-name>
				/// setIntentRedelivery
				/// </java-name>
				[Dot42.DexImport("setIntentRedelivery", "(Z)V", AccessFlags = 1)]
				public virtual void SetIntentRedelivery(bool enabled) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onCreate
				/// </java-name>
				[Dot42.DexImport("onCreate", "()V", AccessFlags = 1)]
				public override void OnCreate() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onStart
				/// </java-name>
				[Dot42.DexImport("onStart", "(Landroid/content/Intent;I)V", AccessFlags = 1)]
				public override void OnStart(global::Android.Content.Intent intent, int startId) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>You should not override this method for your IntentService. Instead, override onHandleIntent, which the system calls when the IntentService receives a start request.  <para>android.app.Service::onStartCommand </para></para>        
				/// </summary>
				/// <java-name>
				/// onStartCommand
				/// </java-name>
				[Dot42.DexImport("onStartCommand", "(Landroid/content/Intent;II)I", AccessFlags = 1)]
				public override int OnStartCommand(global::Android.Content.Intent intent, int flags, int startId) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// onDestroy
				/// </java-name>
				[Dot42.DexImport("onDestroy", "()V", AccessFlags = 1)]
				public override void OnDestroy() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Unless you provide binding for your service, you don't need to implement this method, because the default implementation returns null.  <para>android.app.Service::onBind </para></para>        
				/// </summary>
				/// <java-name>
				/// onBind
				/// </java-name>
				[Dot42.DexImport("onBind", "(Landroid/content/Intent;)Landroid/os/IBinder;", AccessFlags = 1)]
				public override global::Android.OS.IBinder OnBind(global::Android.Content.Intent intent) /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.IBinder);
				}

				/// <summary>
				///  <para>This method is invoked on the worker thread with a request to process. Only one Intent is processed at a time, but the processing happens on a worker thread that runs independently from other application logic. So, if this code takes a long time, it will hold up other requests to the same IntentService, but it will not hold up anything else. When all requests have been handled, the IntentService stops itself, so you should not call stopSelf.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// onHandleIntent
				/// </java-name>
				[Dot42.DexImport("onHandleIntent", "(Landroid/content/Intent;)V", AccessFlags = 1028)]
				protected internal abstract void OnHandleIntent(global::Android.Content.Intent intent) /* MethodBuilder.Create */ ;

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal IntentService() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		///  <para>Class that can be used to lock and unlock the keyboard. Get an instance of this class by calling android.content.Context#getSystemService(java.lang.String) with argument android.content.Context#KEYGUARD_SERVICE. The actual class to control the keyboard locking is android.app.KeyguardManager.KeyguardLock. </para>    
		/// </summary>
		/// <java-name>
		/// android/app/KeyguardManager
		/// </java-name>
		[Dot42.DexImport("android/app/KeyguardManager", AccessFlags = 33)]
		public partial class KeyguardManager
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal KeyguardManager() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use android.view.WindowManager.LayoutParams#FLAG_DISMISS_KEYGUARD and/or android.view.WindowManager.LayoutParams#FLAG_SHOW_WHEN_LOCKED instead; this allows you to seamlessly hide the keyguard as your application moves in and out of the foreground and does not require that any special permissions be requested.</para></xrefdescription></xrefsect></para> <para>Enables you to lock or unlock the keyboard. Get an instance of this class by calling Context.getSystemService(). This class is wrapped by KeyguardManager. </para>        
				/// </summary>
				/// <returns>
				///  <para>A KeyguardLock handle to use to disable and reenable the keyguard. </para>
				/// </returns>
				/// <java-name>
				/// newKeyguardLock
				/// </java-name>
				[Dot42.DexImport("newKeyguardLock", "(Ljava/lang/String;)Landroid/app/KeyguardManager$KeyguardLock;", AccessFlags = 1)]
				public virtual global::Android.App.KeyguardManager.KeyguardLock NewKeyguardLock(string tag) /* MethodBuilder.Create */ 
				{
						return default(global::Android.App.KeyguardManager.KeyguardLock);
				}

				/// <summary>
				///  <para>If keyguard screen is showing or in restricted key input mode (i.e. in keyguard password emergency screen). When in such mode, certain keys, such as the Home key and the right soft keys, don't work.</para> <para> <para>android.view.WindowManagerPolicy::inKeyguardRestrictedKeyInputMode </para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if in keyguard restricted input mode.</para>
				/// </returns>
				/// <java-name>
				/// inKeyguardRestrictedInputMode
				/// </java-name>
				[Dot42.DexImport("inKeyguardRestrictedInputMode", "()Z", AccessFlags = 1)]
				public virtual bool InKeyguardRestrictedInputMode() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use android.view.WindowManager.LayoutParams#FLAG_DISMISS_KEYGUARD and/or android.view.WindowManager.LayoutParams#FLAG_SHOW_WHEN_LOCKED instead; this allows you to seamlessly hide the keyguard as your application moves in and out of the foreground and does not require that any special permissions be requested.</para></xrefdescription></xrefsect></para> <para>Exit the keyguard securely. The use case for this api is that, after disabling the keyguard, your app, which was granted permission to disable the keyguard and show a limited amount of information deemed safe without the user getting past the keyguard, needs to navigate to something that is not safe to view without getting past the keyguard.</para> <para>This will, if the keyguard is secure, bring up the unlock screen of the keyguard.</para> <para>This method requires the caller to hold the permission android.Manifest.permission#DISABLE_KEYGUARD.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// exitKeyguardSecurely
				/// </java-name>
				[Dot42.DexImport("exitKeyguardSecurely", "(Landroid/app/KeyguardManager$OnKeyguardExitResult;)V", AccessFlags = 1)]
				public virtual void ExitKeyguardSecurely(global::Android.App.KeyguardManager.IOnKeyguardExitResult callback) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Return whether the keyguard is currently locked.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if keyguard is locked. </para>
				/// </returns>
				/// <java-name>
				/// isKeyguardLocked
				/// </java-name>
				public virtual bool IsKeyguardLocked
				{
						[Dot42.DexImport("isKeyguardLocked", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Return whether the keyguard requires a password to unlock.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if keyguard is secure. </para>
				/// </returns>
				/// <java-name>
				/// isKeyguardSecure
				/// </java-name>
				public virtual bool IsKeyguardSecure
				{
						[Dot42.DexImport("isKeyguardSecure", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Callback passed to KeyguardManager#exitKeyguardSecurely to notify caller of result. </para>    
				/// </summary>
				/// <java-name>
				/// android/app/KeyguardManager$OnKeyguardExitResult
				/// </java-name>
				[Dot42.DexImport("android/app/KeyguardManager$OnKeyguardExitResult", AccessFlags = 1545)]
				public partial interface IOnKeyguardExitResult
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para></para>        
						/// </summary>
						/// <java-name>
						/// onKeyguardExitResult
						/// </java-name>
						[Dot42.DexImport("onKeyguardExitResult", "(Z)V", AccessFlags = 1025)]
						void OnKeyguardExitResult(bool success) /* MethodBuilder.Create */ ;

				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use android.view.WindowManager.LayoutParams#FLAG_DISMISS_KEYGUARD and/or android.view.WindowManager.LayoutParams#FLAG_SHOW_WHEN_LOCKED instead; this allows you to seamlessly hide the keyguard as your application moves in and out of the foreground and does not require that any special permissions be requested.</para></xrefdescription></xrefsect></para> <para>Handle returned by KeyguardManager#newKeyguardLock that allows you to disable / reenable the keyguard. </para>    
				/// </summary>
				/// <java-name>
				/// android/app/KeyguardManager$KeyguardLock
				/// </java-name>
				[Dot42.DexImport("android/app/KeyguardManager$KeyguardLock", AccessFlags = 1)]
				public partial class KeyguardLock
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// this$0
						/// </java-name>
						[Dot42.DexImport("this$0", "Landroid/app/KeyguardManager;", AccessFlags = 4112)]
						internal readonly global::Android.App.KeyguardManager This_0;
						[Dot42.DexImport("<init>", "(Landroid/app/KeyguardManager;)V", AccessFlags = 0)]
						internal KeyguardLock(global::Android.App.KeyguardManager keyguardManager) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Disable the keyguard from showing. If the keyguard is currently showing, hide it. The keyguard will be prevented from showing again until reenableKeyguard() is called.</para> <para>A good place to call this is from android.app.Activity#onResume()</para> <para>Note: This call has no effect while any android.app.admin.DevicePolicyManager is enabled that requires a password.</para> <para>This method requires the caller to hold the permission android.Manifest.permission#DISABLE_KEYGUARD.</para> <para> <para>reenableKeyguard() </para></para>        
						/// </summary>
						/// <java-name>
						/// disableKeyguard
						/// </java-name>
						[Dot42.DexImport("disableKeyguard", "()V", AccessFlags = 1)]
						public virtual void DisableKeyguard() /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Reenable the keyguard. The keyguard will reappear if the previous call to disableKeyguard() caused it to be hidden.</para> <para>A good place to call this is from android.app.Activity#onPause()</para> <para>Note: This call has no effect while any android.app.admin.DevicePolicyManager is enabled that requires a password.</para> <para>This method requires the caller to hold the permission android.Manifest.permission#DISABLE_KEYGUARD.</para> <para> <para>disableKeyguard() </para></para>        
						/// </summary>
						/// <java-name>
						/// reenableKeyguard
						/// </java-name>
						[Dot42.DexImport("reenableKeyguard", "()V", AccessFlags = 1)]
						public virtual void ReenableKeyguard() /* MethodBuilder.Create */ 
						{
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal KeyguardLock() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

				}

		}

		/// <summary>
		///  <para>Displays a list of all activities which can be performed for a given intent. Launches when clicked. </para>    
		/// </summary>
		/// <java-name>
		/// android/app/LauncherActivity
		/// </java-name>
		[Dot42.DexImport("android/app/LauncherActivity", AccessFlags = 1057)]
		public abstract partial class LauncherActivity : global::Android.App.ListActivity
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public LauncherActivity() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onCreate
				/// </java-name>
				[Dot42.DexImport("onCreate", "(Landroid/os/Bundle;)V", AccessFlags = 4)]
				protected internal override void OnCreate(global::Android.OS.Bundle icicle) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setTitle
				/// </java-name>
				[Dot42.DexImport("setTitle", "(Ljava/lang/CharSequence;)V", AccessFlags = 1)]
				public override void SetTitle(global::Java.Lang.ICharSequence titleId) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setTitle
				/// </java-name>
				[Dot42.DexImport("setTitle", "(I)V", AccessFlags = 1)]
				public override void SetTitle(int titleId) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Override to call setContentView() with your own content view to customize the list layout. </para>        
				/// </summary>
				/// <java-name>
				/// onSetContentView
				/// </java-name>
				[Dot42.DexImport("onSetContentView", "()V", AccessFlags = 4)]
				protected internal virtual void OnSetContentView() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onListItemClick
				/// </java-name>
				[Dot42.DexImport("onListItemClick", "(Landroid/widget/ListView;Landroid/view/View;IJ)V", AccessFlags = 4)]
				protected internal override void OnListItemClick(global::Android.Widget.ListView l, global::Android.Views.View v, int position, long id) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Return the actual Intent for a specific position in our android.widget.ListView. </para>        
				/// </summary>
				/// <java-name>
				/// intentForPosition
				/// </java-name>
				[Dot42.DexImport("intentForPosition", "(I)Landroid/content/Intent;", AccessFlags = 4)]
				protected internal virtual global::Android.Content.Intent IntentForPosition(int position) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Intent);
				}

				/// <summary>
				///  <para>Return the ListItem for a specific position in our android.widget.ListView. </para>        
				/// </summary>
				/// <java-name>
				/// itemForPosition
				/// </java-name>
				[Dot42.DexImport("itemForPosition", "(I)Landroid/app/LauncherActivity$ListItem;", AccessFlags = 4)]
				protected internal virtual global::Android.App.LauncherActivity.ListItem ItemForPosition(int position) /* MethodBuilder.Create */ 
				{
						return default(global::Android.App.LauncherActivity.ListItem);
				}

				/// <summary>
				///  <para>Perform query on package manager for list items. The default implementation queries for activities. </para>        
				/// </summary>
				/// <java-name>
				/// onQueryPackageManager
				/// </java-name>
				[Dot42.DexImport("onQueryPackageManager", "(Landroid/content/Intent;)Ljava/util/List;", AccessFlags = 4, Signature = "(Landroid/content/Intent;)Ljava/util/List<Landroid/content/pm/ResolveInfo;>;")]
				protected internal virtual global::Java.Util.IList<global::Android.Content.PM.ResolveInfo> OnQueryPackageManager(global::Android.Content.Intent queryIntent) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<global::Android.Content.PM.ResolveInfo>);
				}

				/// <summary>
				///  <para>Perform the query to determine which results to show and return a list of them. </para>        
				/// </summary>
				/// <java-name>
				/// makeListItems
				/// </java-name>
				[Dot42.DexImport("makeListItems", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Landroid/app/LauncherActivity$ListItem;>;")]
				public virtual global::Java.Util.IList<global::Android.App.LauncherActivity.ListItem> MakeListItems() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<global::Android.App.LauncherActivity.ListItem>);
				}

				/// <summary>
				///  <para>Get the base intent to use when running PackageManager#queryIntentActivities(Intent, int). </para>        
				/// </summary>
				/// <java-name>
				/// getTargetIntent
				/// </java-name>
				protected internal virtual global::Android.Content.Intent TargetIntent
				{
						[Dot42.DexImport("getTargetIntent", "()Landroid/content/Intent;", AccessFlags = 4)]
						get{ return default(global::Android.Content.Intent); }
				}

				/// <summary>
				///  <para>Utility class to resize icons to match default icon size. </para>    
				/// </summary>
				/// <java-name>
				/// android/app/LauncherActivity$IconResizer
				/// </java-name>
				[Dot42.DexImport("android/app/LauncherActivity$IconResizer", AccessFlags = 1)]
				public partial class IconResizer
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// this$0
						/// </java-name>
						[Dot42.DexImport("this$0", "Landroid/app/LauncherActivity;", AccessFlags = 4112)]
						internal readonly global::Android.App.LauncherActivity This_0;
						[Dot42.DexImport("<init>", "(Landroid/app/LauncherActivity;)V", AccessFlags = 1)]
						public IconResizer(global::Android.App.LauncherActivity launcherActivity) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Returns a Drawable representing the thumbnail of the specified Drawable. The size of the thumbnail is defined by the dimension android.R.dimen.launcher_application_icon_size.</para> <para>This method is not thread-safe and should be invoked on the UI thread only.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>A thumbnail for the specified icon or the icon itself if the thumbnail could not be created. </para>
						/// </returns>
						/// <java-name>
						/// createIconThumbnail
						/// </java-name>
						[Dot42.DexImport("createIconThumbnail", "(Landroid/graphics/drawable/Drawable;)Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
						public virtual global::Android.Graphics.Drawables.Drawable CreateIconThumbnail(global::Android.Graphics.Drawables.Drawable icon) /* MethodBuilder.Create */ 
						{
								return default(global::Android.Graphics.Drawables.Drawable);
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal IconResizer() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

				}

				/// <summary>
				///  <para>An item in the list </para>    
				/// </summary>
				/// <java-name>
				/// android/app/LauncherActivity$ListItem
				/// </java-name>
				[Dot42.DexImport("android/app/LauncherActivity$ListItem", AccessFlags = 9)]
				public partial class ListItem
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// resolveInfo
						/// </java-name>
						[Dot42.DexImport("resolveInfo", "Landroid/content/pm/ResolveInfo;", AccessFlags = 1)]
						public global::Android.Content.PM.ResolveInfo ResolveInfo;
						/// <java-name>
						/// label
						/// </java-name>
						[Dot42.DexImport("label", "Ljava/lang/CharSequence;", AccessFlags = 1)]
						public global::Java.Lang.ICharSequence Label;
						/// <java-name>
						/// icon
						/// </java-name>
						[Dot42.DexImport("icon", "Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
						public global::Android.Graphics.Drawables.Drawable Icon;
						/// <java-name>
						/// packageName
						/// </java-name>
						[Dot42.DexImport("packageName", "Ljava/lang/String;", AccessFlags = 1)]
						public string PackageName;
						/// <java-name>
						/// className
						/// </java-name>
						[Dot42.DexImport("className", "Ljava/lang/String;", AccessFlags = 1)]
						public string ClassName;
						/// <java-name>
						/// extras
						/// </java-name>
						[Dot42.DexImport("extras", "Landroid/os/Bundle;", AccessFlags = 1)]
						public global::Android.OS.Bundle Extras;
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public ListItem() /* MethodBuilder.Create */ 
						{
						}

				}

		}

		/// <summary>
		///  <para>An activity that displays a list of items by binding to a data source such as an array or Cursor, and exposes event handlers when the user selects an item. </para> <para>ListActivity hosts a ListView object that can be bound to different data sources, typically either an array or a Cursor holding query results. Binding, screen layout, and row layout are discussed in the following sections. </para> <para> <b>Screen Layout</b> </para> <para>ListActivity has a default layout that consists of a single, full-screen list in the center of the screen. However, if you desire, you can customize the screen layout by setting your own view layout with setContentView() in onCreate(). To do this, your own view MUST contain a ListView object with the id "@android:id/list" (or android.R.id#list if it's in code) </para> <para>Optionally, your custom view can contain another view object of any type to display when the list view is empty. This "empty list" notifier must have an id "android:id/empty". Note that when an empty view is present, the list view will be hidden when there is no data to display. </para> <para>The following code demonstrates an (ugly) custom screen layout. It has a list with a green background, and an alternate red "no data" message. </para> <para> <pre>
		/// &lt;?xml version="1.0" encoding="utf-8"?&gt;
		/// &lt;LinearLayout xmlns:android="http://schemas.android.com/apk/res/android"
		///         android:orientation="vertical"
		///         android:layout_width="match_parent"
		///         android:layout_height="match_parent"
		///         android:paddingLeft="8dp"
		///         android:paddingRight="8dp"&gt;</pre></para> <para> <pre>    &lt;ListView android:id=":id/list"
		///               android:layout_width="match_parent"
		///               android:layout_height="match_parent"
		///               android:background="#00FF00"
		///               android:layout_weight="1"
		///               android:drawSelectorOnTop="false"/&gt;</pre></para> <para> <pre>    &lt;TextView android:id=":id/empty"
		///               android:layout_width="match_parent"
		///               android:layout_height="match_parent"
		///               android:background="#FF0000"
		///               android:text="No data"/&gt;
		/// &lt;/LinearLayout&gt;
		/// </pre></para> <para> <b>Row Layout</b> </para> <para>You can specify the layout of individual rows in the list. You do this by specifying a layout resource in the ListAdapter object hosted by the activity (the ListAdapter binds the ListView to the data; more on this later). </para> <para>A ListAdapter constructor takes a parameter that specifies a layout resource for each row. It also has two additional parameters that let you specify which data field to associate with which object in the row layout resource. These two parameters are typically parallel arrays. </para> <para>Android provides some standard row layout resources. These are in the android.R.layout class, and have names such as simple_list_item_1, simple_list_item_2, and two_line_list_item. The following layout XML is the source for the resource two_line_list_item, which displays two data fields,one above the other, for each list row. </para> <para> <pre>
		/// &lt;?xml version="1.0" encoding="utf-8"?&gt;
		/// &lt;LinearLayout xmlns:android="http://schemas.android.com/apk/res/android"
		///     android:layout_width="match_parent"
		///     android:layout_height="wrap_content"
		///     android:orientation="vertical"&gt;</pre></para> <para> <pre>    &lt;TextView android:id="@+id/text1"
		///         android:textSize="16sp"
		///         android:textStyle="bold"
		///         android:layout_width="match_parent"
		///         android:layout_height="wrap_content"/&gt;</pre></para> <para> <pre>    &lt;TextView android:id="@+id/text2"
		///         android:textSize="16sp"
		///         android:layout_width="match_parent"
		///         android:layout_height="wrap_content"/&gt;
		/// &lt;/LinearLayout&gt;
		/// </pre></para> <para>You must identify the data bound to each TextView object in this layout. The syntax for this is discussed in the next section. </para> <para> <b>Binding to Data</b> </para> <para>You bind the ListActivity's ListView object to data using a class that implements the ListAdapter interface. Android provides two standard list adapters: SimpleAdapter for static data (Maps), and SimpleCursorAdapter for Cursor query results. </para> <para>The following code from a custom ListActivity demonstrates querying the Contacts provider for all contacts, then binding the Name and Company fields to a two line row layout in the activity's ListView. </para> <para> <pre>
		/// public class MyListAdapter extends ListActivity {</pre></para> <para> <pre>    &amp;#064;Override
		///     protected void onCreate(Bundle savedInstanceState){
		///         super.onCreate(savedInstanceState);</pre></para> <para> <pre>        // We'll define a custom screen layout here (the one shown above), but
		///         // typically, you could just use the standard ListActivity layout.
		///         setContentView(R.layout.custom_list_activity_view);</pre></para> <para> <pre>        // Query for all people contacts using the android.provider.Contacts.People convenience class.
		///         // Put a managed wrapper around the retrieved cursor so we don't have to worry about
		///         // requerying or closing it as the activity changes state.
		///         mCursor = this.getContentResolver().query(People.CONTENT_URI, null, null, null, null);
		///         startManagingCursor(mCursor);</pre></para> <para> <pre>        // Now create a new list adapter bound to the cursor.
		///         // SimpleListAdapter is designed for binding to a Cursor.
		///         ListAdapter adapter = new SimpleCursorAdapter(
		///                 this, // Context.
		///                 android.R.layout.two_line_list_item,  // Specify the row template to use (here, two columns bound to the two retrieved cursor
		/// rows).
		///                 mCursor,                                              // Pass in the cursor to bind to.
		///                 new String[] {People.NAME, People.COMPANY},           // Array of cursor columns to bind to.
		///                 new int[] {android.R.id.text1, android.R.id.text2});  // Parallel array of which template objects to bind to those columns.</pre></para> <para> <pre>        // Bind to our new adapter.
		///         setListAdapter(adapter);
		///     }
		/// }
		/// </pre></para> <para> <para>setListAdapter </para> <para>android.widget.ListView </para></para>    
		/// </summary>
		/// <java-name>
		/// android/app/ListActivity
		/// </java-name>
		[Dot42.DexImport("android/app/ListActivity", AccessFlags = 33)]
		public partial class ListActivity : global::Android.App.Activity
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ListActivity() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>This method will be called when an item in the list is selected. Subclasses should override. Subclasses can call getListView().getItemAtPosition(position) if they need to access the data associated with the selected item.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// onListItemClick
				/// </java-name>
				[Dot42.DexImport("onListItemClick", "(Landroid/widget/ListView;Landroid/view/View;IJ)V", AccessFlags = 4)]
				protected internal virtual void OnListItemClick(global::Android.Widget.ListView l, global::Android.Views.View v, int position, long id) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Ensures the list view has been created before Activity restores all of the view states.</para> <para> <para>Activity::onRestoreInstanceState(Bundle) </para></para>        
				/// </summary>
				/// <java-name>
				/// onRestoreInstanceState
				/// </java-name>
				[Dot42.DexImport("onRestoreInstanceState", "(Landroid/os/Bundle;)V", AccessFlags = 4)]
				protected internal override void OnRestoreInstanceState(global::Android.OS.Bundle state) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para> <para>Activity::onDestroy() </para></para>        
				/// </summary>
				/// <java-name>
				/// onDestroy
				/// </java-name>
				[Dot42.DexImport("onDestroy", "()V", AccessFlags = 4)]
				protected internal override void OnDestroy() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Updates the screen state (current list and other views) when the content changes.</para> <para> <para>Activity::onContentChanged() </para></para>        
				/// </summary>
				/// <java-name>
				/// onContentChanged
				/// </java-name>
				[Dot42.DexImport("onContentChanged", "()V", AccessFlags = 1)]
				public override void OnContentChanged() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Set the currently selected list item to the specified position with the adapter's data</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setSelection
				/// </java-name>
				[Dot42.DexImport("setSelection", "(I)V", AccessFlags = 1)]
				public virtual void SetSelection(int position) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Get the position of the currently selected list item. </para>        
				/// </summary>
				/// <java-name>
				/// getSelectedItemPosition
				/// </java-name>
				public virtual int SelectedItemPosition
				{
						[Dot42.DexImport("getSelectedItemPosition", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Get the cursor row ID of the currently selected list item. </para>        
				/// </summary>
				/// <java-name>
				/// getSelectedItemId
				/// </java-name>
				public virtual long SelectedItemId
				{
						[Dot42.DexImport("getSelectedItemId", "()J", AccessFlags = 1)]
						get{ return default(long); }
				}

				/// <summary>
				///  <para>Get the activity's list view widget. </para>        
				/// </summary>
				/// <java-name>
				/// getListView
				/// </java-name>
				public virtual global::Android.Widget.ListView ListView
				{
						[Dot42.DexImport("getListView", "()Landroid/widget/ListView;", AccessFlags = 1)]
						get{ return default(global::Android.Widget.ListView); }
				}

				/// <summary>
				///  <para>Get the ListAdapter associated with this activity's ListView. </para>        
				/// </summary>
				/// <java-name>
				/// getListAdapter
				/// </java-name>
				public virtual global::Android.Widget.IListAdapter ListAdapter
				{
						[Dot42.DexImport("getListAdapter", "()Landroid/widget/ListAdapter;", AccessFlags = 1)]
						get{ return default(global::Android.Widget.IListAdapter); }
						[Dot42.DexImport("setListAdapter", "(Landroid/widget/ListAdapter;)V", AccessFlags = 1)]
						set{ }
				}

		}

		/// <summary>
		///  <para>A fragment that displays a list of items by binding to a data source such as an array or Cursor, and exposes event handlers when the user selects an item. </para> <para>ListFragment hosts a ListView object that can be bound to different data sources, typically either an array or a Cursor holding query results. Binding, screen layout, and row layout are discussed in the following sections. </para> <para> <b>Screen Layout</b> </para> <para>ListFragment has a default layout that consists of a single list view. However, if you desire, you can customize the fragment layout by returning your own view hierarchy from onCreateView. To do this, your view hierarchy  <b>must</b> contain a ListView object with the id "@android:id/list" (or android.R.id#list if it's in code) </para> <para>Optionally, your view hierarchy can contain another view object of any type to display when the list view is empty. This "empty list" notifier must have an id "android:empty". Note that when an empty view is present, the list view will be hidden when there is no data to display. </para> <para>The following code demonstrates an (ugly) custom list layout. It has a list with a green background, and an alternate red "no data" message. </para> <para> <pre>
		/// &lt;?xml version="1.0" encoding="utf-8"?&gt;
		/// &lt;LinearLayout xmlns:android="http://schemas.android.com/apk/res/android"
		///         android:orientation="vertical"
		///         android:layout_width="match_parent"
		///         android:layout_height="match_parent"
		///         android:paddingLeft="8dp"
		///         android:paddingRight="8dp"&gt;</pre></para> <para> <pre>    &lt;ListView android:id="/android:list"
		///               android:layout_width="match_parent"
		///               android:layout_height="match_parent"
		///               android:background="#00FF00"
		///               android:layout_weight="1"
		///               android:drawSelectorOnTop="false"/&gt;</pre></para> <para> <pre>    &lt;TextView android:id="/android:empty"
		///               android:layout_width="match_parent"
		///               android:layout_height="match_parent"
		///               android:background="#FF0000"
		///               android:text="No data"/&gt;
		/// &lt;/LinearLayout&gt;
		/// </pre></para> <para> <b>Row Layout</b> </para> <para>You can specify the layout of individual rows in the list. You do this by specifying a layout resource in the ListAdapter object hosted by the fragment (the ListAdapter binds the ListView to the data; more on this later). </para> <para>A ListAdapter constructor takes a parameter that specifies a layout resource for each row. It also has two additional parameters that let you specify which data field to associate with which object in the row layout resource. These two parameters are typically parallel arrays. </para> <para>Android provides some standard row layout resources. These are in the android.R.layout class, and have names such as simple_list_item_1, simple_list_item_2, and two_line_list_item. The following layout XML is the source for the resource two_line_list_item, which displays two data fields,one above the other, for each list row. </para> <para> <pre>
		/// &lt;?xml version="1.0" encoding="utf-8"?&gt;
		/// &lt;LinearLayout xmlns:android="http://schemas.android.com/apk/res/android"
		///     android:layout_width="match_parent"
		///     android:layout_height="wrap_content"
		///     android:orientation="vertical"&gt;</pre></para> <para> <pre>    &lt;TextView android:id="@+id/text1"
		///         android:textSize="16sp"
		///         android:textStyle="bold"
		///         android:layout_width="match_parent"
		///         android:layout_height="wrap_content"/&gt;</pre></para> <para> <pre>    &lt;TextView android:id="@+id/text2"
		///         android:textSize="16sp"
		///         android:layout_width="match_parent"
		///         android:layout_height="wrap_content"/&gt;
		/// &lt;/LinearLayout&gt;
		/// </pre></para> <para>You must identify the data bound to each TextView object in this layout. The syntax for this is discussed in the next section. </para> <para> <b>Binding to Data</b> </para> <para>You bind the ListFragment's ListView object to data using a class that implements the ListAdapter interface. Android provides two standard list adapters: SimpleAdapter for static data (Maps), and SimpleCursorAdapter for Cursor query results. </para> <para>You  <b>must</b> use ListFragment.setListAdapter() to associate the list with an adapter. Do not directly call ListView.setAdapter() or else important initialization will be skipped. </para> <para> <para>setListAdapter </para> <para>android.widget.ListView </para></para>    
		/// </summary>
		/// <java-name>
		/// android/app/ListFragment
		/// </java-name>
		[Dot42.DexImport("android/app/ListFragment", AccessFlags = 33)]
		public partial class ListFragment : global::Android.App.Fragment
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ListFragment() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Provide default implementation to return a simple list view. Subclasses can override to replace with their own layout. If doing so, the returned view hierarchy  <b>must</b> have a ListView whose id is android.R.id.list and can optionally have a sibling view id android.R.id.empty that is to be shown when the list is empty.</para> <para>If you are overriding this method with your own custom content, consider including the standard layout android.R.layout#list_content in your layout file, so that you continue to retain all of the standard behavior of ListFragment. In particular, this is currently the only way to have the built-in indeterminant progress state be shown. </para>        
				/// </summary>
				/// <java-name>
				/// onCreateView
				/// </java-name>
				[Dot42.DexImport("onCreateView", "(Landroid/view/LayoutInflater;Landroid/view/ViewGroup;Landroid/os/Bundle;)Landroi" +
    "d/view/View;", AccessFlags = 1)]
				public override global::Android.Views.View OnCreateView(global::Android.Views.LayoutInflater inflater, global::Android.Views.ViewGroup container, global::Android.OS.Bundle savedInstanceState) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.View);
				}

				/// <summary>
				///  <para>Attach to list view once the view hierarchy has been created. </para>        
				/// </summary>
				/// <java-name>
				/// onViewCreated
				/// </java-name>
				[Dot42.DexImport("onViewCreated", "(Landroid/view/View;Landroid/os/Bundle;)V", AccessFlags = 1)]
				public override void OnViewCreated(global::Android.Views.View view, global::Android.OS.Bundle savedInstanceState) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Detach from list view. </para>        
				/// </summary>
				/// <java-name>
				/// onDestroyView
				/// </java-name>
				[Dot42.DexImport("onDestroyView", "()V", AccessFlags = 1)]
				public override void OnDestroyView() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>This method will be called when an item in the list is selected. Subclasses should override. Subclasses can call getListView().getItemAtPosition(position) if they need to access the data associated with the selected item.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// onListItemClick
				/// </java-name>
				[Dot42.DexImport("onListItemClick", "(Landroid/widget/ListView;Landroid/view/View;IJ)V", AccessFlags = 1)]
				public virtual void OnListItemClick(global::Android.Widget.ListView l, global::Android.Views.View v, int position, long id) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Set the currently selected list item to the specified position with the adapter's data</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setSelection
				/// </java-name>
				[Dot42.DexImport("setSelection", "(I)V", AccessFlags = 1)]
				public virtual void SetSelection(int position) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>The default content for a ListFragment has a TextView that can be shown when the list is empty. If you would like to have it shown, call this method to supply the text it should use. </para>        
				/// </summary>
				/// <java-name>
				/// setEmptyText
				/// </java-name>
				[Dot42.DexImport("setEmptyText", "(Ljava/lang/CharSequence;)V", AccessFlags = 1)]
				public virtual void SetEmptyText(global::Java.Lang.ICharSequence text) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Control whether the list is being displayed. You can make it not displayed if you are waiting for the initial data to show in it. During this time an indeterminant progress indicator will be shown instead.</para> <para>Applications do not normally need to use this themselves. The default behavior of ListFragment is to start with the list not being shown, only showing it once an adapter is given with setListAdapter(ListAdapter). If the list at that point had not been shown, when it does get shown it will be do without the user ever seeing the hidden state.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setListShown
				/// </java-name>
				[Dot42.DexImport("setListShown", "(Z)V", AccessFlags = 1)]
				public virtual void SetListShown(bool shown) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Like setListShown(boolean), but no animation is used when transitioning from the previous state. </para>        
				/// </summary>
				/// <java-name>
				/// setListShownNoAnimation
				/// </java-name>
				[Dot42.DexImport("setListShownNoAnimation", "(Z)V", AccessFlags = 1)]
				public virtual void SetListShownNoAnimation(bool shown) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Get the position of the currently selected list item. </para>        
				/// </summary>
				/// <java-name>
				/// getSelectedItemPosition
				/// </java-name>
				public virtual int SelectedItemPosition
				{
						[Dot42.DexImport("getSelectedItemPosition", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Get the cursor row ID of the currently selected list item. </para>        
				/// </summary>
				/// <java-name>
				/// getSelectedItemId
				/// </java-name>
				public virtual long SelectedItemId
				{
						[Dot42.DexImport("getSelectedItemId", "()J", AccessFlags = 1)]
						get{ return default(long); }
				}

				/// <summary>
				///  <para>Get the activity's list view widget. </para>        
				/// </summary>
				/// <java-name>
				/// getListView
				/// </java-name>
				public virtual global::Android.Widget.ListView ListView
				{
						[Dot42.DexImport("getListView", "()Landroid/widget/ListView;", AccessFlags = 1)]
						get{ return default(global::Android.Widget.ListView); }
				}

				/// <summary>
				///  <para>Get the ListAdapter associated with this activity's ListView. </para>        
				/// </summary>
				/// <java-name>
				/// getListAdapter
				/// </java-name>
				public virtual global::Android.Widget.IListAdapter ListAdapter
				{
						[Dot42.DexImport("getListAdapter", "()Landroid/widget/ListAdapter;", AccessFlags = 1)]
						get{ return default(global::Android.Widget.IListAdapter); }
						[Dot42.DexImport("setListAdapter", "(Landroid/widget/ListAdapter;)V", AccessFlags = 1)]
						set{ }
				}

		}

		/// <summary>
		///  <para>Interface associated with an Activity or Fragment for managing one or more android.content.Loader instances associated with it. This helps an application manage longer-running operations in conjunction with the Activity or Fragment lifecycle; the most common use of this is with a android.content.CursorLoader, however applications are free to write their own loaders for loading other types of data.</para> <para>While the LoaderManager API was introduced in android.os.Build.VERSION_CODES#HONEYCOMB, a version of the API at is also available for use on older platforms through android.support.v4.app.FragmentActivity. See the blog post  for more details.</para> <para>As an example, here is the full implementation of a Fragment that displays a android.widget.ListView containing the results of a query against the contacts content provider. It uses a android.content.CursorLoader to manage the query on the provider.</para> <para>{ development/samples/ApiDemos/src/com/example/android/apis/app/LoaderCursor.java fragment_cursor}</para> <para>  <h3>Developer Guides</h3></para> <para> </para> <para>For more information about using loaders, read the  developer guide.</para> <para>  </para>    
		/// </summary>
		/// <java-name>
		/// android/app/LoaderManager
		/// </java-name>
		[Dot42.DexImport("android/app/LoaderManager", AccessFlags = 1057)]
		public abstract partial class LoaderManager
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public LoaderManager() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Ensures a loader is initialized and active. If the loader doesn't already exist, one is created and (if the activity/fragment is currently started) starts the loader. Otherwise the last created loader is re-used.</para> <para>In either case, the given callback is associated with the loader, and will be called as the loader state changes. If at the point of call the caller is in its started state, and the requested loader already exists and has generated its data, then callback LoaderCallbacks#onLoadFinished will be called immediately (inside of this function), so you must be prepared for this to happen.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// initLoader
				/// </java-name>
				[Dot42.DexImport("initLoader", "(ILandroid/os/Bundle;Landroid/app/LoaderManager$LoaderCallbacks;)Landroid/content" +
    "/Loader;", AccessFlags = 1025, Signature = "<D:Ljava/lang/Object;>(ILandroid/os/Bundle;Landroid/app/LoaderManager$LoaderCallb" +
    "acks<TD;>;)Landroid/content/Loader<TD;>;")]
				public abstract global::Android.Content.Loader<D> InitLoader<D>(int id, global::Android.OS.Bundle args, global::Android.App.LoaderManager.ILoaderCallbacks<D> callback) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Starts a new or restarts an existing android.content.Loader in this manager, registers the callbacks to it, and (if the activity/fragment is currently started) starts loading it. If a loader with the same id has previously been started it will automatically be destroyed when the new loader completes its work. The callback will be delivered before the old loader is destroyed.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// restartLoader
				/// </java-name>
				[Dot42.DexImport("restartLoader", "(ILandroid/os/Bundle;Landroid/app/LoaderManager$LoaderCallbacks;)Landroid/content" +
    "/Loader;", AccessFlags = 1025, Signature = "<D:Ljava/lang/Object;>(ILandroid/os/Bundle;Landroid/app/LoaderManager$LoaderCallb" +
    "acks<TD;>;)Landroid/content/Loader<TD;>;")]
				public abstract global::Android.Content.Loader<D> RestartLoader<D>(int id, global::Android.OS.Bundle args, global::Android.App.LoaderManager.ILoaderCallbacks<D> callback) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Stops and removes the loader with the given ID. If this loader had previously reported data to the client through LoaderCallbacks#onLoadFinished(Loader, Object), a call will be made to LoaderCallbacks#onLoaderReset(Loader). </para>        
				/// </summary>
				/// <java-name>
				/// destroyLoader
				/// </java-name>
				[Dot42.DexImport("destroyLoader", "(I)V", AccessFlags = 1025)]
				public abstract void DestroyLoader(int id) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Return the Loader with the given id or null if no matching Loader is found. </para>        
				/// </summary>
				/// <java-name>
				/// getLoader
				/// </java-name>
				[Dot42.DexImport("getLoader", "(I)Landroid/content/Loader;", AccessFlags = 1025, Signature = "<D:Ljava/lang/Object;>(I)Landroid/content/Loader<TD;>;")]
				public abstract global::Android.Content.Loader<D> GetLoader<D>(int id) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Print the LoaderManager's state into the given stream.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// dump
				/// </java-name>
				[Dot42.DexImport("dump", "(Ljava/lang/String;Ljava/io/FileDescriptor;Ljava/io/PrintWriter;[Ljava/lang/Strin" +
    "g;)V", AccessFlags = 1025)]
				public abstract void Dump(string prefix, global::Java.IO.FileDescriptor fd, global::Java.IO.PrintWriter writer, string[] args) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Control whether the framework's internal loader manager debugging logs are turned on. If enabled, you will see output in logcat as the framework performs loader operations. </para>        
				/// </summary>
				/// <java-name>
				/// enableDebugLogging
				/// </java-name>
				[Dot42.DexImport("enableDebugLogging", "(Z)V", AccessFlags = 9)]
				public static void EnableDebugLogging(bool enabled) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Callback interface for a client to interact with the manager. </para>    
				/// </summary>
				/// <java-name>
				/// android/app/LoaderManager$LoaderCallbacks
				/// </java-name>
				[Dot42.DexImport("android/app/LoaderManager$LoaderCallbacks", AccessFlags = 1545, Signature = "<D:Ljava/lang/Object;>Ljava/lang/Object;")]
				public partial interface ILoaderCallbacks<D>
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>Instantiate and return a new Loader for the given ID.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>Return a new Loader instance that is ready to start loading. </para>
						/// </returns>
						/// <java-name>
						/// onCreateLoader
						/// </java-name>
						[Dot42.DexImport("onCreateLoader", "(ILandroid/os/Bundle;)Landroid/content/Loader;", AccessFlags = 1025, Signature = "(ILandroid/os/Bundle;)Landroid/content/Loader<TD;>;")]
						global::Android.Content.Loader<D> OnCreateLoader(int id, global::Android.OS.Bundle args) /* MethodBuilder.Create */ ;

						/// <summary>
						///  <para>Called when a previously created loader has finished its load. Note that normally an application is  <b>not</b> allowed to commit fragment transactions while in this call, since it can happen after an activity's state is saved. See FragmentManager.openTransaction() for further discussion on this.</para> <para>This function is guaranteed to be called prior to the release of the last data that was supplied for this Loader. At this point you should remove all use of the old data (since it will be released soon), but should not do your own release of the data since its Loader owns it and will take care of that. The Loader will take care of management of its data so you don't have to. In particular:</para> <para> <ul> <li> <para></para> <para>The Loader will monitor for changes to the data, and report them to you through new calls here. You should not monitor the data yourself. For example, if the data is a android.database.Cursor and you place it in a android.widget.CursorAdapter, use the android.database.Cursor, int) constructor  <b>without</b> passing in either android.widget.CursorAdapter#FLAG_AUTO_REQUERY or android.widget.CursorAdapter#FLAG_REGISTER_CONTENT_OBSERVER (that is, use 0 for the flags argument). This prevents the CursorAdapter from doing its own observing of the Cursor, which is not needed since when a change happens you will get a new Cursor throw another call here. </para></li> <li> <para>The Loader will release the data once it knows the application is no longer using it. For example, if the data is a android.database.Cursor from a android.content.CursorLoader, you should not call close() on it yourself. If the Cursor is being placed in a android.widget.CursorAdapter, you should use the android.widget.CursorAdapter#swapCursor(android.database.Cursor) method so that the old Cursor is not closed. </para></li></ul></para> <para></para>        
						/// </summary>
						/// <java-name>
						/// onLoadFinished
						/// </java-name>
						[Dot42.DexImport("onLoadFinished", "(Landroid/content/Loader;Ljava/lang/Object;)V", AccessFlags = 1025, Signature = "(Landroid/content/Loader<TD;>;TD;)V")]
						void OnLoadFinished(global::Android.Content.Loader<D> loader, D data) /* MethodBuilder.Create */ ;

						/// <summary>
						///  <para>Called when a previously created loader is being reset, and thus making its data unavailable. The application should at this point remove any references it has to the Loader's data.</para> <para></para>        
						/// </summary>
						/// <java-name>
						/// onLoaderReset
						/// </java-name>
						[Dot42.DexImport("onLoaderReset", "(Landroid/content/Loader;)V", AccessFlags = 1025, Signature = "(Landroid/content/Loader<TD;>;)V")]
						void OnLoaderReset(global::Android.Content.Loader<D> loader) /* MethodBuilder.Create */ ;

				}

		}

		/// <summary>
		///  <para>Helper class for managing multiple running embedded activities in the same process. This class is not normally used directly, but rather created for you as part of the android.app.ActivityGroup implementation.</para> <para> <para>ActivityGroup</para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use the new Fragment and FragmentManager APIs instead; these are also available on older platforms through the Android compatibility package. </para></xrefdescription></xrefsect></para>    
		/// </summary>
		/// <java-name>
		/// android/app/LocalActivityManager
		/// </java-name>
		[Dot42.DexImport("android/app/LocalActivityManager", AccessFlags = 33)]
		public partial class LocalActivityManager
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>String ids of running activities starting with least recently used. Create a new LocalActivityManager for holding activities running within the given  <b>parent</b>.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/app/Activity;Z)V", AccessFlags = 1)]
				public LocalActivityManager(global::Android.App.Activity parent, bool singleMode) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Start a new activity running in the group. Every activity you start must have a unique string ID associated with it  this is used to keep track of the activity, so that if you later call startActivity() again on it the same activity object will be retained.</para> <para>When there had previously been an activity started under this id, it may either be destroyed and a new one started, or the current one re-used, based on these conditions, in order:</para> <para> <ul> <li> <para>If the Intent maps to a different activity component than is currently running, the current activity is finished and a new one started. </para></li> <li> <para>If the current activity uses a non-multiple launch mode (such as singleTop), or the Intent has the Intent#FLAG_ACTIVITY_SINGLE_TOP flag set, then the current activity will remain running and its Activity.onNewIntent() method called. </para></li> <li> <para>If the new Intent is the same (excluding extras) as the previous one, and the new Intent does not have the Intent#FLAG_ACTIVITY_CLEAR_TOP set, then the current activity will remain running as-is. </para></li> <li> <para>Otherwise, the current activity will be finished and a new one started. </para></li></ul></para> <para>If the given Intent can not be resolved to an available Activity, this method throws android.content.ActivityNotFoundException.</para> <para>Warning: There is an issue where, if the Intent does not include an explicit component, we can restore the state for a different activity class than was previously running when the state was saved (if the set of available activities changes between those points).</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns the window of the activity. The caller needs to take care of adding this window to a view hierarchy, and likewise dealing with removing the old window if the activity has changed.</para>
				/// </returns>
				/// <java-name>
				/// startActivity
				/// </java-name>
				[Dot42.DexImport("startActivity", "(Ljava/lang/String;Landroid/content/Intent;)Landroid/view/Window;", AccessFlags = 1)]
				public virtual global::Android.Views.Window StartActivity(string id, global::Android.Content.Intent intent) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.Window);
				}

				/// <summary>
				///  <para>Destroy the activity associated with a particular id. This activity will go through the normal lifecycle events and fine onDestroy(), and then the id removed from the group.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns the window that was used to display the activity, or null if there was none. </para>
				/// </returns>
				/// <java-name>
				/// destroyActivity
				/// </java-name>
				[Dot42.DexImport("destroyActivity", "(Ljava/lang/String;Z)Landroid/view/Window;", AccessFlags = 1)]
				public virtual global::Android.Views.Window DestroyActivity(string id, bool finish) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.Window);
				}

				/// <summary>
				///  <para>Return the Activity object associated with a string ID.</para> <para> <para>startActivity</para></para>        
				/// </summary>
				/// <returns>
				///  <para>the associated Activity object, or null if the id is unknown or its activity is not currently instantiated </para>
				/// </returns>
				/// <java-name>
				/// getActivity
				/// </java-name>
				[Dot42.DexImport("getActivity", "(Ljava/lang/String;)Landroid/app/Activity;", AccessFlags = 1)]
				public virtual global::Android.App.Activity GetActivity(string id) /* MethodBuilder.Create */ 
				{
						return default(global::Android.App.Activity);
				}

				/// <summary>
				///  <para>Restore a state that was previously returned by saveInstanceState. This adds to the activity group information about all activity IDs that had previously been saved, even if they have not been started yet, so if the user later navigates to them the correct state will be restored.</para> <para>Note: This does  <b>not</b> change the current running activity, or start whatever activity was previously running when the state was saved. That is up to the client to do, in whatever way it thinks is best.</para> <para> <para>saveInstanceState </para></para>        
				/// </summary>
				/// <java-name>
				/// dispatchCreate
				/// </java-name>
				[Dot42.DexImport("dispatchCreate", "(Landroid/os/Bundle;)V", AccessFlags = 1)]
				public virtual void DispatchCreate(global::Android.OS.Bundle state) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Retrieve the state of all activities known by the group. For activities that have previously run and are now stopped or finished, the last saved state is used. For the current running activity, its Activity#onSaveInstanceState is called to retrieve its current state.</para> <para> <para>dispatchCreate </para></para>        
				/// </summary>
				/// <returns>
				///  <para>a Bundle holding the newly created state of all known activities</para>
				/// </returns>
				/// <java-name>
				/// saveInstanceState
				/// </java-name>
				[Dot42.DexImport("saveInstanceState", "()Landroid/os/Bundle;", AccessFlags = 1)]
				public virtual global::Android.OS.Bundle SaveInstanceState() /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.Bundle);
				}

				/// <summary>
				///  <para>Called by the container activity in its Activity#onResume so that LocalActivityManager can perform the corresponding action on the activities it holds.</para> <para> <para>Activity::onResume </para></para>        
				/// </summary>
				/// <java-name>
				/// dispatchResume
				/// </java-name>
				[Dot42.DexImport("dispatchResume", "()V", AccessFlags = 1)]
				public virtual void DispatchResume() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Called by the container activity in its Activity#onPause so that LocalActivityManager can perform the corresponding action on the activities it holds.</para> <para> <para>Activity::onPause </para> <para>Activity::isFinishing </para></para>        
				/// </summary>
				/// <java-name>
				/// dispatchPause
				/// </java-name>
				[Dot42.DexImport("dispatchPause", "(Z)V", AccessFlags = 1)]
				public virtual void DispatchPause(bool finishing) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Called by the container activity in its Activity#onStop so that LocalActivityManager can perform the corresponding action on the activities it holds.</para> <para> <para>Activity::onStop </para></para>        
				/// </summary>
				/// <java-name>
				/// dispatchStop
				/// </java-name>
				[Dot42.DexImport("dispatchStop", "()V", AccessFlags = 1)]
				public virtual void DispatchStop() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Remove all activities from this LocalActivityManager, performing an Activity#onDestroy on any that are currently instantiated. </para>        
				/// </summary>
				/// <java-name>
				/// removeAllActivities
				/// </java-name>
				[Dot42.DexImport("removeAllActivities", "()V", AccessFlags = 1)]
				public virtual void RemoveAllActivities() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Called by the container activity in its Activity#onDestroy so that LocalActivityManager can perform the corresponding action on the activities it holds.</para> <para> <para>Activity::onDestroy </para></para>        
				/// </summary>
				/// <java-name>
				/// dispatchDestroy
				/// </java-name>
				[Dot42.DexImport("dispatchDestroy", "(Z)V", AccessFlags = 1)]
				public virtual void DispatchDestroy(bool finishing) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal LocalActivityManager() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Retrieve the Activity that is currently running.</para> <para> <para>startActivity </para> <para>getCurrentId </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the currently running (resumed) Activity, or null if there is not one</para>
				/// </returns>
				/// <java-name>
				/// getCurrentActivity
				/// </java-name>
				public virtual global::Android.App.Activity CurrentActivity
				{
						[Dot42.DexImport("getCurrentActivity", "()Landroid/app/Activity;", AccessFlags = 1)]
						get{ return default(global::Android.App.Activity); }
				}

				/// <summary>
				///  <para>Retrieve the ID of the activity that is currently running.</para> <para> <para>startActivity </para> <para>getCurrentActivity </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the ID of the currently running (resumed) Activity, or null if there is not one</para>
				/// </returns>
				/// <java-name>
				/// getCurrentId
				/// </java-name>
				public virtual string CurrentId
				{
						[Dot42.DexImport("getCurrentId", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

		}

		/// <summary>
		///  <para>The media route action provider displays a media route button in the application's ActionBar to allow the user to select routes and to control the currently selected route. </para> <para>The application must specify the kinds of routes that the user should be allowed to select by specifying the route types with the setRouteTypes method. </para> <para>Refer to MediaRouteButton for a description of the button that will appear in the action bar menu. Note that instead of disabling the button when no routes are available, the action provider will instead make the menu item invisible. In this way, the button will only be visible when it is possible for the user to discover and select a matching route. </para>    
		/// </summary>
		/// <java-name>
		/// android/app/MediaRouteActionProvider
		/// </java-name>
		[Dot42.DexImport("android/app/MediaRouteActionProvider", AccessFlags = 33)]
		public partial class MediaRouteActionProvider : global::Android.Views.ActionProvider
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public MediaRouteActionProvider(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the types of routes that will be shown in the media route chooser dialog launched by this button.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setRouteTypes
				/// </java-name>
				[Dot42.DexImport("setRouteTypes", "(I)V", AccessFlags = 1)]
				public virtual void SetRouteTypes(int types) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onCreateActionView
				/// </java-name>
				[Dot42.DexImport("onCreateActionView", "()Landroid/view/View;", AccessFlags = 1)]
				public override global::Android.Views.View OnCreateActionView() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.View);
				}

				/// <java-name>
				/// onCreateActionView
				/// </java-name>
				[Dot42.DexImport("onCreateActionView", "(Landroid/view/MenuItem;)Landroid/view/View;", AccessFlags = 1)]
				public override global::Android.Views.View OnCreateActionView(global::Android.Views.IMenuItem item) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.View);
				}

				/// <java-name>
				/// onPerformDefaultAction
				/// </java-name>
				[Dot42.DexImport("onPerformDefaultAction", "()Z", AccessFlags = 1)]
				public override bool OnPerformDefaultAction() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setExtendedSettingsClickListener
				/// </java-name>
				[Dot42.DexImport("setExtendedSettingsClickListener", "(Landroid/view/View$OnClickListener;)V", AccessFlags = 1)]
				public virtual void SetExtendedSettingsClickListener(global::Android.Views.View.IOnClickListener listener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// overridesItemVisibility
				/// </java-name>
				[Dot42.DexImport("overridesItemVisibility", "()Z", AccessFlags = 1)]
				public override bool OverridesItemVisibility() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal MediaRouteActionProvider() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// isVisible
				/// </java-name>
				public override bool IsVisible
				{
						[Dot42.DexImport("isVisible", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

		}

		/// <java-name>
		/// android/app/MediaRouteButton
		/// </java-name>
		[Dot42.DexImport("android/app/MediaRouteButton", AccessFlags = 33)]
		public partial class MediaRouteButton : global::Android.Views.View
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public MediaRouteButton(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public MediaRouteButton(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", AccessFlags = 1)]
				public MediaRouteButton(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs, int defStyleAttr) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// performClick
				/// </java-name>
				[Dot42.DexImport("performClick", "()Z", AccessFlags = 1)]
				public override bool PerformClick() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// performLongClick
				/// </java-name>
				[Dot42.DexImport("performLongClick", "()Z", AccessFlags = 1)]
				public override bool PerformLongClick() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onCreateDrawableState
				/// </java-name>
				[Dot42.DexImport("onCreateDrawableState", "(I)[I", AccessFlags = 4)]
				protected internal override int[] OnCreateDrawableState(int extraSpace) /* MethodBuilder.Create */ 
				{
						return default(int[]);
				}

				/// <java-name>
				/// drawableStateChanged
				/// </java-name>
				[Dot42.DexImport("drawableStateChanged", "()V", AccessFlags = 4)]
				protected internal override void DrawableStateChanged() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// verifyDrawable
				/// </java-name>
				[Dot42.DexImport("verifyDrawable", "(Landroid/graphics/drawable/Drawable;)Z", AccessFlags = 4)]
				protected internal override bool VerifyDrawable(global::Android.Graphics.Drawables.Drawable who) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// jumpDrawablesToCurrentState
				/// </java-name>
				[Dot42.DexImport("jumpDrawablesToCurrentState", "()V", AccessFlags = 1)]
				public override void JumpDrawablesToCurrentState() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onAttachedToWindow
				/// </java-name>
				[Dot42.DexImport("onAttachedToWindow", "()V", AccessFlags = 1)]
				public new virtual void OnAttachedToWindow() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onDetachedFromWindow
				/// </java-name>
				[Dot42.DexImport("onDetachedFromWindow", "()V", AccessFlags = 1)]
				public new virtual void OnDetachedFromWindow() /* MethodBuilder.Create */ 
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
				/// onDraw
				/// </java-name>
				[Dot42.DexImport("onDraw", "(Landroid/graphics/Canvas;)V", AccessFlags = 4)]
				protected internal override void OnDraw(global::Android.Graphics.Canvas canvas) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setExtendedSettingsClickListener
				/// </java-name>
				[Dot42.DexImport("setExtendedSettingsClickListener", "(Landroid/view/View$OnClickListener;)V", AccessFlags = 1)]
				public virtual void SetExtendedSettingsClickListener(global::Android.Views.View.IOnClickListener listener) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Show the route chooser or controller dialog. </para> <para>If the default route is selected or if the currently selected route does not match the route types, then shows the route chooser dialog. Otherwise, shows the route controller dialog to offer the user a choice to disconnect from the route or perform other control actions such as setting the route's volume. </para> <para>This will attach a DialogFragment to the containing Activity. </para>        
				/// </summary>
				/// <java-name>
				/// showDialog
				/// </java-name>
				[Dot42.DexImport("showDialog", "()V", AccessFlags = 1)]
				public virtual void ShowDialog() /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal MediaRouteButton() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Gets the media route types for filtering the routes that the user can select using the media route chooser dialog.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The route types. </para>
				/// </returns>
				/// <java-name>
				/// getRouteTypes
				/// </java-name>
				public virtual int RouteTypes
				{
						[Dot42.DexImport("getRouteTypes", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setRouteTypes", "(I)V", AccessFlags = 1)]
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

		}

		/// <summary>
		///  <para>Convenience for implementing an activity that will be implemented purely in native code. That is, a game (or game-like thing). There is no need to derive from this class; you can simply declare it in your manifest, and use the NDK APIs from there.</para> <para>A typical manifest would look like:</para> <para>{ development/ndk/platforms/android-9/samples/native-activity/AndroidManifest.xml manifest}</para> <para>A very simple example of native code that is run by NativeActivity follows. This reads input events from the user and uses OpenGLES to draw into the native activity's window.</para> <para>{ development/ndk/platforms/android-9/samples/native-activity/jni/main.c all} </para>    
		/// </summary>
		/// <java-name>
		/// android/app/NativeActivity
		/// </java-name>
		[Dot42.DexImport("android/app/NativeActivity", AccessFlags = 33)]
		public partial class NativeActivity : global::Android.App.Activity, global::Android.Views.ISurfaceHolder_ICallback2, global::Android.Views.InputQueue.ICallback, global::Android.Views.ViewTreeObserver.IOnGlobalLayoutListener
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Optional meta-that can be in the manifest for this component, specifying the name of the native shared library to load. If not specified, "main" is used. </para>        
				/// </summary>
				/// <java-name>
				/// META_DATA_LIB_NAME
				/// </java-name>
				[Dot42.DexImport("META_DATA_LIB_NAME", "Ljava/lang/String;", AccessFlags = 25)]
				public const string META_DATA_LIB_NAME = "android.app.lib_name";
				/// <summary>
				///  <para>Optional meta-that can be in the manifest for this component, specifying the name of the main entry point for this native activity in the META_DATA_LIB_NAME native code. If not specified, "ANativeActivity_onCreate" is used. </para>        
				/// </summary>
				/// <java-name>
				/// META_DATA_FUNC_NAME
				/// </java-name>
				[Dot42.DexImport("META_DATA_FUNC_NAME", "Ljava/lang/String;", AccessFlags = 25)]
				public const string META_DATA_FUNC_NAME = "android.app.func_name";
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public NativeActivity() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onCreate
				/// </java-name>
				[Dot42.DexImport("onCreate", "(Landroid/os/Bundle;)V", AccessFlags = 4)]
				protected internal override void OnCreate(global::Android.OS.Bundle savedInstanceState) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onDestroy
				/// </java-name>
				[Dot42.DexImport("onDestroy", "()V", AccessFlags = 4)]
				protected internal override void OnDestroy() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onPause
				/// </java-name>
				[Dot42.DexImport("onPause", "()V", AccessFlags = 4)]
				protected internal override void OnPause() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onResume
				/// </java-name>
				[Dot42.DexImport("onResume", "()V", AccessFlags = 4)]
				protected internal override void OnResume() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onSaveInstanceState
				/// </java-name>
				[Dot42.DexImport("onSaveInstanceState", "(Landroid/os/Bundle;)V", AccessFlags = 4)]
				protected internal override void OnSaveInstanceState(global::Android.OS.Bundle outState) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onStart
				/// </java-name>
				[Dot42.DexImport("onStart", "()V", AccessFlags = 4)]
				protected internal override void OnStart() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onStop
				/// </java-name>
				[Dot42.DexImport("onStop", "()V", AccessFlags = 4)]
				protected internal override void OnStop() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Called by the system when the device configuration changes while your component is running. Note that, unlike activities, other components are never restarted when a configuration changes: they must always deal with the results of the change, such as by re-retrieving resources.</para> <para>At the time that this function has been called, your Resources object will have been updated to return resource values matching the new configuration.</para> <para>For more information, read .</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// onConfigurationChanged
				/// </java-name>
				[Dot42.DexImport("onConfigurationChanged", "(Landroid/content/res/Configuration;)V", AccessFlags = 1)]
				public override void OnConfigurationChanged(global::Android.Content.Res.Configuration newConfig) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>This is called when the overall system is running low on memory, and actively running processes should trim their memory usage. While the exact point at which this will be called is not defined, generally it will happen when all background process have been killed. That is, before reaching the point of killing processes hosting service and foreground UI that we would like to avoid killing.</para> <para>You should implement this method to release any caches or other unnecessary resources you may be holding on to. The system will perform a garbage collection for you after returning from this method. </para> <para>Preferably, you should implement ComponentCallbacks2#onTrimMemory from ComponentCallbacks2 to incrementally unload your resources based on various levels of memory demands. That API is available for API level 14 and higher, so you should only use this onLowMemory method as a fallback for older versions, which can be treated the same as ComponentCallbacks2#onTrimMemory with the ComponentCallbacks2#TRIM_MEMORY_COMPLETE level.</para>        
				/// </summary>
				/// <java-name>
				/// onLowMemory
				/// </java-name>
				[Dot42.DexImport("onLowMemory", "()V", AccessFlags = 1)]
				public override void OnLowMemory() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>This hook is called whenever the window focus changes. See View.onWindowFocusChanged(boolean) for more information.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// onWindowFocusChanged
				/// </java-name>
				[Dot42.DexImport("onWindowFocusChanged", "(Z)V", AccessFlags = 1)]
				public override void OnWindowFocusChanged(bool hasFocus) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>This is called immediately after the surface is first created. Implementations of this should start up whatever rendering code they desire. Note that only one thread can ever draw into a Surface, so you should not draw into the Surface here if your normal rendering will be in another thread.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// surfaceCreated
				/// </java-name>
				[Dot42.DexImport("surfaceCreated", "(Landroid/view/SurfaceHolder;)V", AccessFlags = 1)]
				public virtual void SurfaceCreated(global::Android.Views.ISurfaceHolder holder) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>This is called immediately after any structural changes (format or size) have been made to the surface. You should at this point update the imagery in the surface. This method is always called at least once, after surfaceCreated.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// surfaceChanged
				/// </java-name>
				[Dot42.DexImport("surfaceChanged", "(Landroid/view/SurfaceHolder;III)V", AccessFlags = 1)]
				public virtual void SurfaceChanged(global::Android.Views.ISurfaceHolder holder, int format, int width, int height) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Called when the application needs to redraw the content of its surface, after it is resized or for some other reason. By not returning from here until the redraw is complete, you can ensure that the user will not see your surface in a bad state (at its new size before it has been correctly drawn that way). This will typically be preceeded by a call to surfaceChanged.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// surfaceRedrawNeeded
				/// </java-name>
				[Dot42.DexImport("surfaceRedrawNeeded", "(Landroid/view/SurfaceHolder;)V", AccessFlags = 1)]
				public virtual void SurfaceRedrawNeeded(global::Android.Views.ISurfaceHolder holder) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>This is called immediately before a surface is being destroyed. After returning from this call, you should no longer try to access this surface. If you have a rendering thread that directly accesses the surface, you must ensure that thread is no longer touching the Surface before returning from this function.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// surfaceDestroyed
				/// </java-name>
				[Dot42.DexImport("surfaceDestroyed", "(Landroid/view/SurfaceHolder;)V", AccessFlags = 1)]
				public virtual void SurfaceDestroyed(global::Android.Views.ISurfaceHolder holder) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Called when the given InputQueue is now associated with the thread making this call, so it can start receiving events from it. </para>        
				/// </summary>
				/// <java-name>
				/// onInputQueueCreated
				/// </java-name>
				[Dot42.DexImport("onInputQueueCreated", "(Landroid/view/InputQueue;)V", AccessFlags = 1)]
				public virtual void OnInputQueueCreated(global::Android.Views.InputQueue queue) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Called when the given InputQueue is no longer associated with the thread and thus not dispatching events. </para>        
				/// </summary>
				/// <java-name>
				/// onInputQueueDestroyed
				/// </java-name>
				[Dot42.DexImport("onInputQueueDestroyed", "(Landroid/view/InputQueue;)V", AccessFlags = 1)]
				public virtual void OnInputQueueDestroyed(global::Android.Views.InputQueue queue) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Callback method to be invoked when the global layout state or the visibility of views within the view tree changes </para>        
				/// </summary>
				/// <java-name>
				/// onGlobalLayout
				/// </java-name>
				[Dot42.DexImport("onGlobalLayout", "()V", AccessFlags = 1)]
				public virtual void OnGlobalLayout() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>A class that represents how a persistent notification is to be presented to the user using the android.app.NotificationManager.</para> <para>The Notification.Builder has been added to make it easier to construct Notifications.</para> <para>  <h3>Developer Guides</h3></para> <para> </para> <para>For a guide to creating notifications, read the  developer guide.</para> <para>  </para>    
		/// </summary>
		/// <java-name>
		/// android/app/Notification
		/// </java-name>
		[Dot42.DexImport("android/app/Notification", AccessFlags = 33)]
		public partial class Notification : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Use all default values (where applicable). </para>        
				/// </summary>
				/// <java-name>
				/// DEFAULT_ALL
				/// </java-name>
				[Dot42.DexImport("DEFAULT_ALL", "I", AccessFlags = 25)]
				public const int DEFAULT_ALL = -1;
				/// <summary>
				///  <para>Use the default notification sound. This will ignore any given sound.</para> <para> <para>defaults </para></para>        
				/// </summary>
				/// <java-name>
				/// DEFAULT_SOUND
				/// </java-name>
				[Dot42.DexImport("DEFAULT_SOUND", "I", AccessFlags = 25)]
				public const int DEFAULT_SOUND = 1;
				/// <summary>
				///  <para>Use the default notification vibrate. This will ignore any given vibrate. Using phone vibration requires the VIBRATE permission.</para> <para> <para>defaults </para></para>        
				/// </summary>
				/// <java-name>
				/// DEFAULT_VIBRATE
				/// </java-name>
				[Dot42.DexImport("DEFAULT_VIBRATE", "I", AccessFlags = 25)]
				public const int DEFAULT_VIBRATE = 2;
				/// <summary>
				///  <para>Use the default notification lights. This will ignore the FLAG_SHOW_LIGHTS bit, and ledARGB, ledOffMS, or ledOnMS.</para> <para> <para>defaults </para></para>        
				/// </summary>
				/// <java-name>
				/// DEFAULT_LIGHTS
				/// </java-name>
				[Dot42.DexImport("DEFAULT_LIGHTS", "I", AccessFlags = 25)]
				public const int DEFAULT_LIGHTS = 4;
				/// <summary>
				///  <para>A timestamp related to this notification, in milliseconds since the epoch.</para> <para>Default value: Now.</para> <para>Choose a timestamp that will be most relevant to the user. For most finite events, this corresponds to the time the event happened (or will happen, in the case of events that have yet to occur but about which the user is being informed). Indefinite events should be timestamped according to when the activity began.</para> <para>Some examples:</para> <para> <ul> <li> <para>Notification of a new chat message should be stamped when the message was received. </para></li> <li> <para>Notification of an ongoing file download (with a progress bar, for example) should be stamped when the download started. </para></li> <li> <para>Notification of a completed file download should be stamped when the download finished. </para></li> <li> <para>Notification of an upcoming meeting should be stamped with the time the meeting will begin (that is, in the future). </para></li> <li> <para>Notification of an ongoing stopwatch (increasing timer) should be stamped with the watch's start time. </para></li> <li> <para>Notification of an ongoing countdown timer should be stamped with the timer's end time. </para></li></ul></para>        
				/// </summary>
				/// <java-name>
				/// when
				/// </java-name>
				[Dot42.DexImport("when", "J", AccessFlags = 1)]
				public long When;
				/// <summary>
				///  <para>The resource id of a drawable to use as the icon in the status bar. This is required; notifications with an invalid icon resource will not be shown. </para>        
				/// </summary>
				/// <java-name>
				/// icon
				/// </java-name>
				[Dot42.DexImport("icon", "I", AccessFlags = 1)]
				public int Icon;
				/// <summary>
				///  <para>If the icon in the status bar is to have more than one level, you can set this. Otherwise, leave it at its default value of 0.</para> <para> <para>android.widget.ImageView::setImageLevel </para> <para>android.graphics.drawable::setLevel </para></para>        
				/// </summary>
				/// <java-name>
				/// iconLevel
				/// </java-name>
				[Dot42.DexImport("iconLevel", "I", AccessFlags = 1)]
				public int IconLevel;
				/// <summary>
				///  <para>The number of events that this notification represents. For example, in a new mail notification, this could be the number of unread messages.</para> <para>The system may or may not use this field to modify the appearance of the notification. For example, before android.os.Build.VERSION_CODES#HONEYCOMB, this number was superimposed over the icon in the status bar. Starting with android.os.Build.VERSION_CODES#HONEYCOMB, the template used by Notification.Builder has displayed the number in the expanded notification view.</para> <para>If the number is 0 or negative, it is never shown. </para>        
				/// </summary>
				/// <java-name>
				/// number
				/// </java-name>
				[Dot42.DexImport("number", "I", AccessFlags = 1)]
				public int Number;
				/// <summary>
				///  <para>The intent to execute when the expanded status entry is clicked. If this is an activity, it must include the android.content.Intent#FLAG_ACTIVITY_NEW_TASK flag, which requires that you take care of task management as described in the  document. In particular, make sure to read the notification section  for the correct ways to launch an application from a notification. </para>        
				/// </summary>
				/// <java-name>
				/// contentIntent
				/// </java-name>
				[Dot42.DexImport("contentIntent", "Landroid/app/PendingIntent;", AccessFlags = 1)]
				public global::Android.App.PendingIntent ContentIntent;
				/// <summary>
				///  <para>The intent to execute when the notification is explicitly dismissed by the user, either with the "Clear All" button or by swiping it away individually.</para> <para>This probably shouldn't be launching an activity since several of those will be sent at the same time. </para>        
				/// </summary>
				/// <java-name>
				/// deleteIntent
				/// </java-name>
				[Dot42.DexImport("deleteIntent", "Landroid/app/PendingIntent;", AccessFlags = 1)]
				public global::Android.App.PendingIntent DeleteIntent;
				/// <summary>
				///  <para>An intent to launch instead of posting the notification to the status bar.</para> <para> <para>Notification.Builder::setFullScreenIntent </para></para>        
				/// </summary>
				/// <java-name>
				/// fullScreenIntent
				/// </java-name>
				[Dot42.DexImport("fullScreenIntent", "Landroid/app/PendingIntent;", AccessFlags = 1)]
				public global::Android.App.PendingIntent FullScreenIntent;
				/// <summary>
				///  <para>Text to scroll across the screen when this item is added to the status bar on large and smaller devices.</para> <para> <para>tickerView </para></para>        
				/// </summary>
				/// <java-name>
				/// tickerText
				/// </java-name>
				[Dot42.DexImport("tickerText", "Ljava/lang/CharSequence;", AccessFlags = 1)]
				public global::Java.Lang.ICharSequence TickerText;
				/// <summary>
				///  <para>The view to show as the ticker in the status bar when the notification is posted. </para>        
				/// </summary>
				/// <java-name>
				/// tickerView
				/// </java-name>
				[Dot42.DexImport("tickerView", "Landroid/widget/RemoteViews;", AccessFlags = 1)]
				public global::Android.Widget.RemoteViews TickerView;
				/// <summary>
				///  <para>The view that will represent this notification in the expanded status bar. </para>        
				/// </summary>
				/// <java-name>
				/// contentView
				/// </java-name>
				[Dot42.DexImport("contentView", "Landroid/widget/RemoteViews;", AccessFlags = 1)]
				public global::Android.Widget.RemoteViews ContentView;
				/// <summary>
				///  <para>A large-format version of contentView, giving the Notification an opportunity to show more detail. The system UI may choose to show this instead of the normal content view at its discretion. </para>        
				/// </summary>
				/// <java-name>
				/// bigContentView
				/// </java-name>
				[Dot42.DexImport("bigContentView", "Landroid/widget/RemoteViews;", AccessFlags = 1)]
				public global::Android.Widget.RemoteViews BigContentView;
				/// <summary>
				///  <para>The bitmap that may escape the bounds of the panel and bar. </para>        
				/// </summary>
				/// <java-name>
				/// largeIcon
				/// </java-name>
				[Dot42.DexImport("largeIcon", "Landroid/graphics/Bitmap;", AccessFlags = 1)]
				public global::Android.Graphics.Bitmap LargeIcon;
				/// <summary>
				///  <para>The sound to play.</para> <para>To play the default notification sound, see defaults. </para>        
				/// </summary>
				/// <java-name>
				/// sound
				/// </java-name>
				[Dot42.DexImport("sound", "Landroid/net/Uri;", AccessFlags = 1)]
				public global::Android.Net.Uri Sound;
				/// <summary>
				///  <para>Use this constant as the value for audioStreamType to request that the default stream type for notifications be used. Currently the default stream type is AudioManager#STREAM_NOTIFICATION. </para>        
				/// </summary>
				/// <java-name>
				/// STREAM_DEFAULT
				/// </java-name>
				[Dot42.DexImport("STREAM_DEFAULT", "I", AccessFlags = 25)]
				public const int STREAM_DEFAULT = -1;
				/// <summary>
				///  <para>The audio stream type to use when playing the sound. Should be one of the STREAM_ constants from android.media.AudioManager. </para>        
				/// </summary>
				/// <java-name>
				/// audioStreamType
				/// </java-name>
				[Dot42.DexImport("audioStreamType", "I", AccessFlags = 1)]
				public int AudioStreamType;
				/// <summary>
				///  <para>The pattern with which to vibrate.</para> <para>To vibrate the default pattern, see defaults. </para> <para> <para>android.os.Vibrator::vibrate(long[],int) </para></para>        
				/// </summary>
				/// <java-name>
				/// vibrate
				/// </java-name>
				[Dot42.DexImport("vibrate", "[J", AccessFlags = 1)]
				public long[] Vibrate;
				/// <summary>
				///  <para>The color of the led. The hardware will do its best approximation.</para> <para> <para>FLAG_SHOW_LIGHTS </para> <para>flags </para></para>        
				/// </summary>
				/// <java-name>
				/// ledARGB
				/// </java-name>
				[Dot42.DexImport("ledARGB", "I", AccessFlags = 1)]
				public int LedARGB;
				/// <summary>
				///  <para>The number of milliseconds for the LED to be on while it's flashing. The hardware will do its best approximation.</para> <para> <para>FLAG_SHOW_LIGHTS </para> <para>flags </para></para>        
				/// </summary>
				/// <java-name>
				/// ledOnMS
				/// </java-name>
				[Dot42.DexImport("ledOnMS", "I", AccessFlags = 1)]
				public int LedOnMS;
				/// <summary>
				///  <para>The number of milliseconds for the LED to be off while it's flashing. The hardware will do its best approximation.</para> <para> <para>FLAG_SHOW_LIGHTS </para> <para>flags </para></para>        
				/// </summary>
				/// <java-name>
				/// ledOffMS
				/// </java-name>
				[Dot42.DexImport("ledOffMS", "I", AccessFlags = 1)]
				public int LedOffMS;
				/// <summary>
				///  <para>Specifies which values should be taken from the defaults. </para> <para>To set, OR the desired from DEFAULT_SOUND, DEFAULT_VIBRATE, DEFAULT_LIGHTS. For all default values, use DEFAULT_ALL. </para>        
				/// </summary>
				/// <java-name>
				/// defaults
				/// </java-name>
				[Dot42.DexImport("defaults", "I", AccessFlags = 1)]
				public int Defaults;
				/// <summary>
				///  <para>Bit to be bitwise-ored into the flags field that should be set if you want the LED on for this notification.  <ul> <li> <para>To turn the LED off, pass 0 in the alpha channel for colorARGB or 0 for both ledOnMS and ledOffMS. </para></li> <li> <para>To turn the LED on, pass 1 for ledOnMS and 0 for ledOffMS. </para></li> <li> <para>To flash the LED, pass the number of milliseconds that it should be on and off to ledOnMS and ledOffMS. </para></li></ul></para> <para>Since hardware varies, you are not guaranteed that any of the values you pass are honored exactly. Use the system defaults (TODO) if possible because they will be set to values that work on any given hardware. </para> <para>The alpha channel must be set for forward compatibility. </para>        
				/// </summary>
				/// <java-name>
				/// FLAG_SHOW_LIGHTS
				/// </java-name>
				[Dot42.DexImport("FLAG_SHOW_LIGHTS", "I", AccessFlags = 25)]
				public const int FLAG_SHOW_LIGHTS = 1;
				/// <summary>
				///  <para>Bit to be bitwise-ored into the flags field that should be set if this notification is in reference to something that is ongoing, like a phone call. It should not be set if this notification is in reference to something that happened at a particular point in time, like a missed phone call. </para>        
				/// </summary>
				/// <java-name>
				/// FLAG_ONGOING_EVENT
				/// </java-name>
				[Dot42.DexImport("FLAG_ONGOING_EVENT", "I", AccessFlags = 25)]
				public const int FLAG_ONGOING_EVENT = 2;
				/// <summary>
				///  <para>Bit to be bitwise-ored into the flags field that if set, the audio will be repeated until the notification is cancelled or the notification window is opened. </para>        
				/// </summary>
				/// <java-name>
				/// FLAG_INSISTENT
				/// </java-name>
				[Dot42.DexImport("FLAG_INSISTENT", "I", AccessFlags = 25)]
				public const int FLAG_INSISTENT = 4;
				/// <summary>
				///  <para>Bit to be bitwise-ored into the flags field that should be set if you want the sound and/or vibration play each time the notification is sent, even if it has not been canceled before that. </para>        
				/// </summary>
				/// <java-name>
				/// FLAG_ONLY_ALERT_ONCE
				/// </java-name>
				[Dot42.DexImport("FLAG_ONLY_ALERT_ONCE", "I", AccessFlags = 25)]
				public const int FLAG_ONLY_ALERT_ONCE = 8;
				/// <summary>
				///  <para>Bit to be bitwise-ored into the flags field that should be set if the notification should be canceled when it is clicked by the user. </para>        
				/// </summary>
				/// <java-name>
				/// FLAG_AUTO_CANCEL
				/// </java-name>
				[Dot42.DexImport("FLAG_AUTO_CANCEL", "I", AccessFlags = 25)]
				public const int FLAG_AUTO_CANCEL = 16;
				/// <summary>
				///  <para>Bit to be bitwise-ored into the flags field that should be set if the notification should not be canceled when the user clicks the Clear all button. </para>        
				/// </summary>
				/// <java-name>
				/// FLAG_NO_CLEAR
				/// </java-name>
				[Dot42.DexImport("FLAG_NO_CLEAR", "I", AccessFlags = 25)]
				public const int FLAG_NO_CLEAR = 32;
				/// <summary>
				///  <para>Bit to be bitwise-ored into the flags field that should be set if this notification represents a currently running service. This will normally be set for you by Service#startForeground. </para>        
				/// </summary>
				/// <java-name>
				/// FLAG_FOREGROUND_SERVICE
				/// </java-name>
				[Dot42.DexImport("FLAG_FOREGROUND_SERVICE", "I", AccessFlags = 25)]
				public const int FLAG_FOREGROUND_SERVICE = 64;
				/// <summary>
				///  <para>Obsolete flag indicating high-priority notifications; use the priority field instead.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use priority with a positive value. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// FLAG_HIGH_PRIORITY
				/// </java-name>
				[Dot42.DexImport("FLAG_HIGH_PRIORITY", "I", AccessFlags = 25)]
				public const int FLAG_HIGH_PRIORITY = 128;
				/// <java-name>
				/// flags
				/// </java-name>
				[Dot42.DexImport("flags", "I", AccessFlags = 1)]
				public int Flags;
				/// <summary>
				///  <para>Default notification priority. If your application does not prioritize its own notifications, use this value for all notifications. </para>        
				/// </summary>
				/// <java-name>
				/// PRIORITY_DEFAULT
				/// </java-name>
				[Dot42.DexImport("PRIORITY_DEFAULT", "I", AccessFlags = 25)]
				public const int PRIORITY_DEFAULT = 0;
				/// <summary>
				///  <para>Lower priority, for items that are less important. The UI may choose to show these items smaller, or at a different position in the list, compared with your app's PRIORITY_DEFAULT items. </para>        
				/// </summary>
				/// <java-name>
				/// PRIORITY_LOW
				/// </java-name>
				[Dot42.DexImport("PRIORITY_LOW", "I", AccessFlags = 25)]
				public const int PRIORITY_LOW = -1;
				/// <summary>
				///  <para>Lowest priority; these items might not be shown to the user except under special circumstances, such as detailed notification logs. </para>        
				/// </summary>
				/// <java-name>
				/// PRIORITY_MIN
				/// </java-name>
				[Dot42.DexImport("PRIORITY_MIN", "I", AccessFlags = 25)]
				public const int PRIORITY_MIN = -2;
				/// <summary>
				///  <para>Higher priority, for more important notifications or alerts. The UI may choose to show these items larger, or at a different position in notification lists, compared with your app's PRIORITY_DEFAULT items. </para>        
				/// </summary>
				/// <java-name>
				/// PRIORITY_HIGH
				/// </java-name>
				[Dot42.DexImport("PRIORITY_HIGH", "I", AccessFlags = 25)]
				public const int PRIORITY_HIGH = 1;
				/// <summary>
				///  <para>Highest priority, for your application's most important items that require the user's prompt attention or input. </para>        
				/// </summary>
				/// <java-name>
				/// PRIORITY_MAX
				/// </java-name>
				[Dot42.DexImport("PRIORITY_MAX", "I", AccessFlags = 25)]
				public const int PRIORITY_MAX = 2;
				/// <summary>
				///  <para>Relative priority for this notification.</para> <para>Priority is an indication of how much of the user's valuable attention should be consumed by this notification. Low-priority notifications may be hidden from the user in certain situations, while the user might be interrupted for a higher-priority notification. The system will make a determination about how to interpret this priority when presenting the notification. </para>        
				/// </summary>
				/// <java-name>
				/// priority
				/// </java-name>
				[Dot42.DexImport("priority", "I", AccessFlags = 1)]
				public int Priority;
				/// <summary>
				///  <para>Parcelable.Creator that instantiates Notification objects </para>        
				/// </summary>
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.App.Notification> CREATOR;
				/// <summary>
				///  <para>Constructs a Notification object with default values. You might want to consider using Builder instead. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Notification() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a Notification object with the information needed to have a status bar icon without the standard expanded view.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use Builder instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(ILjava/lang/CharSequence;J)V", AccessFlags = 1)]
				public Notification(int icon, global::Java.Lang.ICharSequence tickerText, long when) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Unflatten the notification from a parcel. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/os/Parcel;)V", AccessFlags = 1)]
				public Notification(global::Android.OS.Parcel parcel) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Landroid/app/Notification;", AccessFlags = 1)]
				public virtual global::Android.App.Notification Clone() /* MethodBuilder.Create */ 
				{
						return default(global::Android.App.Notification);
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
				///  <para>Flatten this notification from a parcel. </para>        
				/// </summary>
				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public virtual void WriteToParcel(global::Android.OS.Parcel parcel, int flags) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the contentView field to be a view with the standard "Latest Event" layout.</para> <para>Uses the icon and when fields to set the icon and time fields in the view.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use Builder instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// setLatestEventInfo
				/// </java-name>
				[Dot42.DexImport("setLatestEventInfo", "(Landroid/content/Context;Ljava/lang/CharSequence;Ljava/lang/CharSequence;Landroi" +
    "d/app/PendingIntent;)V", AccessFlags = 1)]
				public virtual void SetLatestEventInfo(global::Android.Content.Context context, global::Java.Lang.ICharSequence contentTitle, global::Java.Lang.ICharSequence contentText, global::Android.App.PendingIntent contentIntent) /* MethodBuilder.Create */ 
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
				///  <para>Helper class for generating large-format notifications that include a list of (up to 5) strings.</para> <para>This class is a "rebuilder": It consumes a Builder object and modifies its behavior, like so:  <pre>
				/// Notification noti = new Notification.InboxStyle(
				///      new Notification.Builder()
				///         .setContentTitle("5 New mails from " + sender.toString())
				///         .setContentText(subject)
				///         .setSmallIcon(R.drawable.new_mail)
				///         .setLargeIcon(aBitmap))
				///      .addLine(str1)
				///      .addLine(str2)
				///      .setContentTitle("")
				///      .setSummaryText("+3 more")
				///      .build();
				/// </pre></para> <para> <para>Notification::bigContentView </para></para>    
				/// </summary>
				/// <java-name>
				/// android/app/Notification$InboxStyle
				/// </java-name>
				[Dot42.DexImport("android/app/Notification$InboxStyle", AccessFlags = 9)]
				public partial class InboxStyle : global::Android.App.Notification.Style
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public InboxStyle() /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "(Landroid/app/Notification$Builder;)V", AccessFlags = 1)]
						public InboxStyle(global::Android.App.Notification.Builder builder) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Overrides ContentTitle in the big form of the template. This defaults to the value passed to setContentTitle(). </para>        
						/// </summary>
						/// <java-name>
						/// setBigContentTitle
						/// </java-name>
						[Dot42.DexImport("setBigContentTitle", "(Ljava/lang/CharSequence;)Landroid/app/Notification$InboxStyle;", AccessFlags = 1)]
						public virtual InboxStyle SetBigContentTitle(global::Java.Lang.ICharSequence title) /* MethodBuilder.Create */ 
						{
								return default(InboxStyle);
						}

						/// <summary>
						///  <para>Set the first line of text after the detail section in the big form of the template. </para>        
						/// </summary>
						/// <java-name>
						/// setSummaryText
						/// </java-name>
						[Dot42.DexImport("setSummaryText", "(Ljava/lang/CharSequence;)Landroid/app/Notification$InboxStyle;", AccessFlags = 1)]
						public virtual InboxStyle SetSummaryText(global::Java.Lang.ICharSequence cs) /* MethodBuilder.Create */ 
						{
								return default(InboxStyle);
						}

						/// <summary>
						///  <para>Append a line to the digest section of the Inbox notification. </para>        
						/// </summary>
						/// <java-name>
						/// addLine
						/// </java-name>
						[Dot42.DexImport("addLine", "(Ljava/lang/CharSequence;)Landroid/app/Notification$InboxStyle;", AccessFlags = 1)]
						public virtual InboxStyle AddLine(global::Java.Lang.ICharSequence cs) /* MethodBuilder.Create */ 
						{
								return default(InboxStyle);
						}

						/// <java-name>
						/// build
						/// </java-name>
						[Dot42.DexImport("build", "()Landroid/app/Notification;", AccessFlags = 1)]
						public override global::Android.App.Notification Build() /* MethodBuilder.Create */ 
						{
								return default(global::Android.App.Notification);
						}

				}

				/// <summary>
				///  <para>Helper class for generating large-format notifications that include a lot of text.</para> <para>This class is a "rebuilder": It consumes a Builder object and modifies its behavior, like so:  <pre>
				/// Notification noti = new Notification.BigTextStyle(
				///      new Notification.Builder()
				///         .setContentTitle("New mail from " + sender.toString())
				///         .setContentText(subject)
				///         .setSmallIcon(R.drawable.new_mail)
				///         .setLargeIcon(aBitmap))
				///      .bigText(aVeryLongString)
				///      .build();
				/// </pre></para> <para> <para>Notification::bigContentView </para></para>    
				/// </summary>
				/// <java-name>
				/// android/app/Notification$BigTextStyle
				/// </java-name>
				[Dot42.DexImport("android/app/Notification$BigTextStyle", AccessFlags = 9)]
				public partial class BigTextStyle : global::Android.App.Notification.Style
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public BigTextStyle() /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "(Landroid/app/Notification$Builder;)V", AccessFlags = 1)]
						public BigTextStyle(global::Android.App.Notification.Builder builder) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Overrides ContentTitle in the big form of the template. This defaults to the value passed to setContentTitle(). </para>        
						/// </summary>
						/// <java-name>
						/// setBigContentTitle
						/// </java-name>
						[Dot42.DexImport("setBigContentTitle", "(Ljava/lang/CharSequence;)Landroid/app/Notification$BigTextStyle;", AccessFlags = 1)]
						public virtual BigTextStyle SetBigContentTitle(global::Java.Lang.ICharSequence title) /* MethodBuilder.Create */ 
						{
								return default(BigTextStyle);
						}

						/// <summary>
						///  <para>Set the first line of text after the detail section in the big form of the template. </para>        
						/// </summary>
						/// <java-name>
						/// setSummaryText
						/// </java-name>
						[Dot42.DexImport("setSummaryText", "(Ljava/lang/CharSequence;)Landroid/app/Notification$BigTextStyle;", AccessFlags = 1)]
						public virtual BigTextStyle SetSummaryText(global::Java.Lang.ICharSequence cs) /* MethodBuilder.Create */ 
						{
								return default(BigTextStyle);
						}

						/// <summary>
						///  <para>Provide the longer text to be displayed in the big form of the template in place of the content text. </para>        
						/// </summary>
						/// <java-name>
						/// bigText
						/// </java-name>
						[Dot42.DexImport("bigText", "(Ljava/lang/CharSequence;)Landroid/app/Notification$BigTextStyle;", AccessFlags = 1)]
						public virtual BigTextStyle BigText(global::Java.Lang.ICharSequence cs) /* MethodBuilder.Create */ 
						{
								return default(BigTextStyle);
						}

						/// <java-name>
						/// build
						/// </java-name>
						[Dot42.DexImport("build", "()Landroid/app/Notification;", AccessFlags = 1)]
						public override global::Android.App.Notification Build() /* MethodBuilder.Create */ 
						{
								return default(global::Android.App.Notification);
						}

				}

				/// <summary>
				///  <para>Helper class for generating large-format notifications that include a large image attachment.</para> <para>This class is a "rebuilder": It consumes a Builder object and modifies its behavior, like so:  <pre>
				/// Notification noti = new Notification.BigPictureStyle(
				///      new Notification.Builder()
				///         .setContentTitle("New photo from " + sender.toString())
				///         .setContentText(subject)
				///         .setSmallIcon(R.drawable.new_post)
				///         .setLargeIcon(aBitmap))
				///      .bigPicture(aBigBitmap)
				///      .build();
				/// </pre></para> <para> <para>Notification::bigContentView </para></para>    
				/// </summary>
				/// <java-name>
				/// android/app/Notification$BigPictureStyle
				/// </java-name>
				[Dot42.DexImport("android/app/Notification$BigPictureStyle", AccessFlags = 9)]
				public partial class BigPictureStyle : global::Android.App.Notification.Style
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public BigPictureStyle() /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "(Landroid/app/Notification$Builder;)V", AccessFlags = 1)]
						public BigPictureStyle(global::Android.App.Notification.Builder builder) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Overrides ContentTitle in the big form of the template. This defaults to the value passed to setContentTitle(). </para>        
						/// </summary>
						/// <java-name>
						/// setBigContentTitle
						/// </java-name>
						[Dot42.DexImport("setBigContentTitle", "(Ljava/lang/CharSequence;)Landroid/app/Notification$BigPictureStyle;", AccessFlags = 1)]
						public virtual BigPictureStyle SetBigContentTitle(global::Java.Lang.ICharSequence title) /* MethodBuilder.Create */ 
						{
								return default(BigPictureStyle);
						}

						/// <summary>
						///  <para>Set the first line of text after the detail section in the big form of the template. </para>        
						/// </summary>
						/// <java-name>
						/// setSummaryText
						/// </java-name>
						[Dot42.DexImport("setSummaryText", "(Ljava/lang/CharSequence;)Landroid/app/Notification$BigPictureStyle;", AccessFlags = 1)]
						public virtual BigPictureStyle SetSummaryText(global::Java.Lang.ICharSequence cs) /* MethodBuilder.Create */ 
						{
								return default(BigPictureStyle);
						}

						/// <summary>
						///  <para>Provide the bitmap to be used as the payload for the BigPicture notification. </para>        
						/// </summary>
						/// <java-name>
						/// bigPicture
						/// </java-name>
						[Dot42.DexImport("bigPicture", "(Landroid/graphics/Bitmap;)Landroid/app/Notification$BigPictureStyle;", AccessFlags = 1)]
						public virtual BigPictureStyle BigPicture(global::Android.Graphics.Bitmap b) /* MethodBuilder.Create */ 
						{
								return default(BigPictureStyle);
						}

						/// <summary>
						///  <para>Override the large icon when the big notification is shown. </para>        
						/// </summary>
						/// <java-name>
						/// bigLargeIcon
						/// </java-name>
						[Dot42.DexImport("bigLargeIcon", "(Landroid/graphics/Bitmap;)Landroid/app/Notification$BigPictureStyle;", AccessFlags = 1)]
						public virtual BigPictureStyle BigLargeIcon(global::Android.Graphics.Bitmap b) /* MethodBuilder.Create */ 
						{
								return default(BigPictureStyle);
						}

						/// <java-name>
						/// build
						/// </java-name>
						[Dot42.DexImport("build", "()Landroid/app/Notification;", AccessFlags = 1)]
						public override global::Android.App.Notification Build() /* MethodBuilder.Create */ 
						{
								return default(global::Android.App.Notification);
						}

				}

				/// <summary>
				///  <para>An object that can apply a rich notification style to a Notification.Builder object. </para>    
				/// </summary>
				/// <java-name>
				/// android/app/Notification$Style
				/// </java-name>
				[Dot42.DexImport("android/app/Notification$Style", AccessFlags = 1033)]
				public abstract partial class Style
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// mBuilder
						/// </java-name>
						[Dot42.DexImport("mBuilder", "Landroid/app/Notification$Builder;", AccessFlags = 4)]
						protected internal global::Android.App.Notification.Builder MBuilder;
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public Style() /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Overrides ContentTitle in the big form of the template. This defaults to the value passed to setContentTitle(). </para>        
						/// </summary>
						/// <java-name>
						/// internalSetBigContentTitle
						/// </java-name>
						[Dot42.DexImport("internalSetBigContentTitle", "(Ljava/lang/CharSequence;)V", AccessFlags = 4)]
						protected internal virtual void InternalSetBigContentTitle(global::Java.Lang.ICharSequence title) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Set the first line of text after the detail section in the big form of the template. </para>        
						/// </summary>
						/// <java-name>
						/// internalSetSummaryText
						/// </java-name>
						[Dot42.DexImport("internalSetSummaryText", "(Ljava/lang/CharSequence;)V", AccessFlags = 4)]
						protected internal virtual void InternalSetSummaryText(global::Java.Lang.ICharSequence cs) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// setBuilder
						/// </java-name>
						[Dot42.DexImport("setBuilder", "(Landroid/app/Notification$Builder;)V", AccessFlags = 1)]
						public virtual void SetBuilder(global::Android.App.Notification.Builder builder) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// checkBuilder
						/// </java-name>
						[Dot42.DexImport("checkBuilder", "()V", AccessFlags = 4)]
						protected internal virtual void CheckBuilder() /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// getStandardView
						/// </java-name>
						[Dot42.DexImport("getStandardView", "(I)Landroid/widget/RemoteViews;", AccessFlags = 4)]
						protected internal virtual global::Android.Widget.RemoteViews GetStandardView(int layoutId) /* MethodBuilder.Create */ 
						{
								return default(global::Android.Widget.RemoteViews);
						}

						/// <summary>
						///  <para>Calls android.app.Notification.Builder#build() on the Builder this Style is attached to.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>the fully constructed Notification. </para>
						/// </returns>
						/// <java-name>
						/// build
						/// </java-name>
						[Dot42.DexImport("build", "()Landroid/app/Notification;", AccessFlags = 1025)]
						public abstract global::Android.App.Notification Build() /* MethodBuilder.Create */ ;

				}

				/// <summary>
				///  <para>Builder class for Notification objects.</para> <para>Provides a convenient way to set the various fields of a Notification and generate content views using the platform's notification layout template. If your app supports versions of Android as old as API level 4, you can instead use NotificationCompat.Builder, available in the .</para> <para>Example:</para> <para> <pre>
				/// Notification noti = new Notification.Builder(mContext)
				///         .setContentTitle("New mail from " + sender.toString())
				///         .setContentText(subject)
				///         .setSmallIcon(R.drawable.new_mail)
				///         .setLargeIcon(aBitmap)
				///         .build();
				/// </pre> </para>    
				/// </summary>
				/// <java-name>
				/// android/app/Notification$Builder
				/// </java-name>
				[Dot42.DexImport("android/app/Notification$Builder", AccessFlags = 9)]
				public partial class Builder
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
						public Builder(global::Android.Content.Context context) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Add a timestamp pertaining to the notification (usually the time the event occurred). It will be shown in the notification content view by default; use setShowWhen to control this.</para> <para> <para>Notification::when </para></para>        
						/// </summary>
						/// <java-name>
						/// setWhen
						/// </java-name>
						[Dot42.DexImport("setWhen", "(J)Landroid/app/Notification$Builder;", AccessFlags = 1)]
						public virtual Builder SetWhen(long when) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <summary>
						///  <para>Control whether the timestamp set with setWhen is shown in the content view. </para>        
						/// </summary>
						/// <java-name>
						/// setShowWhen
						/// </java-name>
						[Dot42.DexImport("setShowWhen", "(Z)Landroid/app/Notification$Builder;", AccessFlags = 1)]
						public virtual Builder SetShowWhen(bool show) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <summary>
						///  <para>Show the Notification#when field as a stopwatch.</para> <para>Instead of presenting  <code>when</code> as a timestamp, the notification will show an automatically updating display of the minutes and seconds since  <code>when</code>.</para> <para>Useful when showing an elapsed time (like an ongoing phone call).</para> <para> <para>android.widget.Chronometer </para> <para>Notification::when </para></para>        
						/// </summary>
						/// <java-name>
						/// setUsesChronometer
						/// </java-name>
						[Dot42.DexImport("setUsesChronometer", "(Z)Landroid/app/Notification$Builder;", AccessFlags = 1)]
						public virtual Builder SetUsesChronometer(bool b) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <summary>
						///  <para>Set the small icon resource, which will be used to represent the notification in the status bar.</para> <para>The platform template for the expanded view will draw this icon in the left, unless a large icon has also been specified, in which case the small icon will be moved to the right-hand side.</para> <para> <para>Notification::icon </para></para>        
						/// </summary>
						/// <java-name>
						/// setSmallIcon
						/// </java-name>
						[Dot42.DexImport("setSmallIcon", "(I)Landroid/app/Notification$Builder;", AccessFlags = 1)]
						public virtual Builder SetSmallIcon(int icon) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <summary>
						///  <para>A variant of setSmallIcon(int) that takes an additional level parameter for when the icon is a LevelListDrawable.</para> <para> <para>Notification::icon </para> <para>Notification::iconLevel </para></para>        
						/// </summary>
						/// <java-name>
						/// setSmallIcon
						/// </java-name>
						[Dot42.DexImport("setSmallIcon", "(II)Landroid/app/Notification$Builder;", AccessFlags = 1)]
						public virtual Builder SetSmallIcon(int icon, int level) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <summary>
						///  <para>Set the first line of text in the platform notification template. </para>        
						/// </summary>
						/// <java-name>
						/// setContentTitle
						/// </java-name>
						[Dot42.DexImport("setContentTitle", "(Ljava/lang/CharSequence;)Landroid/app/Notification$Builder;", AccessFlags = 1)]
						public virtual Builder SetContentTitle(global::Java.Lang.ICharSequence title) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <summary>
						///  <para>Set the second line of text in the platform notification template. </para>        
						/// </summary>
						/// <java-name>
						/// setContentText
						/// </java-name>
						[Dot42.DexImport("setContentText", "(Ljava/lang/CharSequence;)Landroid/app/Notification$Builder;", AccessFlags = 1)]
						public virtual Builder SetContentText(global::Java.Lang.ICharSequence text) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <summary>
						///  <para>Set the third line of text in the platform notification template. Don't use if you're also using setProgress(int, int, boolean); they occupy the same location in the standard template. </para>        
						/// </summary>
						/// <java-name>
						/// setSubText
						/// </java-name>
						[Dot42.DexImport("setSubText", "(Ljava/lang/CharSequence;)Landroid/app/Notification$Builder;", AccessFlags = 1)]
						public virtual Builder SetSubText(global::Java.Lang.ICharSequence text) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <summary>
						///  <para>Set the large number at the right-hand side of the notification. This is equivalent to setContentInfo, although it might show the number in a different font size for readability. </para>        
						/// </summary>
						/// <java-name>
						/// setNumber
						/// </java-name>
						[Dot42.DexImport("setNumber", "(I)Landroid/app/Notification$Builder;", AccessFlags = 1)]
						public virtual Builder SetNumber(int number) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <summary>
						///  <para>A small piece of additional information pertaining to this notification.</para> <para>The platform template will draw this on the last line of the notification, at the far right (to the right of a smallIcon if it has been placed there). </para>        
						/// </summary>
						/// <java-name>
						/// setContentInfo
						/// </java-name>
						[Dot42.DexImport("setContentInfo", "(Ljava/lang/CharSequence;)Landroid/app/Notification$Builder;", AccessFlags = 1)]
						public virtual Builder SetContentInfo(global::Java.Lang.ICharSequence info) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <summary>
						///  <para>Set the progress this notification represents.</para> <para>The platform template will represent this using a ProgressBar. </para>        
						/// </summary>
						/// <java-name>
						/// setProgress
						/// </java-name>
						[Dot42.DexImport("setProgress", "(IIZ)Landroid/app/Notification$Builder;", AccessFlags = 1)]
						public virtual Builder SetProgress(int max, int progress, bool indeterminate) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <summary>
						///  <para>Supply a custom RemoteViews to use instead of the platform template.</para> <para> <para>Notification::contentView </para></para>        
						/// </summary>
						/// <java-name>
						/// setContent
						/// </java-name>
						[Dot42.DexImport("setContent", "(Landroid/widget/RemoteViews;)Landroid/app/Notification$Builder;", AccessFlags = 1)]
						public virtual Builder SetContent(global::Android.Widget.RemoteViews views) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <summary>
						///  <para>Supply a PendingIntent to be sent when the notification is clicked.</para> <para>As of android.os.Build.VERSION_CODES#HONEYCOMB, if this field is unset and you have specified a custom RemoteViews with setContent(RemoteViews), you can use RemoteViews.setOnClickPendingIntent(int,PendingIntent) to assign PendingIntents to individual views in that custom layout (i.e., to create clickable buttons inside the notification view).</para> <para> <para>Notification::contentIntent Notification.contentIntent </para></para>        
						/// </summary>
						/// <java-name>
						/// setContentIntent
						/// </java-name>
						[Dot42.DexImport("setContentIntent", "(Landroid/app/PendingIntent;)Landroid/app/Notification$Builder;", AccessFlags = 1)]
						public virtual Builder SetContentIntent(global::Android.App.PendingIntent intent) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <summary>
						///  <para>Supply a PendingIntent to send when the notification is cleared explicitly by the user.</para> <para> <para>Notification::deleteIntent </para></para>        
						/// </summary>
						/// <java-name>
						/// setDeleteIntent
						/// </java-name>
						[Dot42.DexImport("setDeleteIntent", "(Landroid/app/PendingIntent;)Landroid/app/Notification$Builder;", AccessFlags = 1)]
						public virtual Builder SetDeleteIntent(global::Android.App.PendingIntent intent) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <summary>
						///  <para>An intent to launch instead of posting the notification to the status bar. Only for use with extremely high-priority notifications demanding the user's  <b>immediate</b> attention, such as an incoming phone call or alarm clock that the user has explicitly set to a particular time. If this facility is used for something else, please give the user an option to turn it off and use a normal notification, as this can be extremely disruptive.</para> <para> <para>Notification::fullScreenIntent </para></para>        
						/// </summary>
						/// <java-name>
						/// setFullScreenIntent
						/// </java-name>
						[Dot42.DexImport("setFullScreenIntent", "(Landroid/app/PendingIntent;Z)Landroid/app/Notification$Builder;", AccessFlags = 1)]
						public virtual Builder SetFullScreenIntent(global::Android.App.PendingIntent intent, bool highPriority) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <summary>
						///  <para>Set the "ticker" text which is displayed in the status bar when the notification first arrives.</para> <para> <para>Notification::tickerText </para></para>        
						/// </summary>
						/// <java-name>
						/// setTicker
						/// </java-name>
						[Dot42.DexImport("setTicker", "(Ljava/lang/CharSequence;)Landroid/app/Notification$Builder;", AccessFlags = 1)]
						public virtual Builder SetTicker(global::Java.Lang.ICharSequence tickerText) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <summary>
						///  <para>Set the text that is displayed in the status bar when the notification first arrives, and also a RemoteViews object that may be displayed instead on some devices.</para> <para> <para>Notification::tickerText </para> <para>Notification::tickerView </para></para>        
						/// </summary>
						/// <java-name>
						/// setTicker
						/// </java-name>
						[Dot42.DexImport("setTicker", "(Ljava/lang/CharSequence;Landroid/widget/RemoteViews;)Landroid/app/Notification$B" +
    "uilder;", AccessFlags = 1)]
						public virtual Builder SetTicker(global::Java.Lang.ICharSequence tickerText, global::Android.Widget.RemoteViews views) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <summary>
						///  <para>Add a large icon to the notification (and the ticker on some devices).</para> <para>In the platform template, this image will be shown on the left of the notification view in place of the small icon (which will move to the right side).</para> <para> <para>Notification::largeIcon </para></para>        
						/// </summary>
						/// <java-name>
						/// setLargeIcon
						/// </java-name>
						[Dot42.DexImport("setLargeIcon", "(Landroid/graphics/Bitmap;)Landroid/app/Notification$Builder;", AccessFlags = 1)]
						public virtual Builder SetLargeIcon(global::Android.Graphics.Bitmap icon) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <summary>
						///  <para>Set the sound to play.</para> <para>It will be played on the default stream for notifications.</para> <para> <para>Notification::sound </para></para>        
						/// </summary>
						/// <java-name>
						/// setSound
						/// </java-name>
						[Dot42.DexImport("setSound", "(Landroid/net/Uri;)Landroid/app/Notification$Builder;", AccessFlags = 1)]
						public virtual Builder SetSound(global::Android.Net.Uri sound) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <summary>
						///  <para>Set the sound to play, along with a specific stream on which to play it.</para> <para>See android.media.AudioManager for the  <code>STREAM_</code> constants.</para> <para> <para>Notification::sound </para></para>        
						/// </summary>
						/// <java-name>
						/// setSound
						/// </java-name>
						[Dot42.DexImport("setSound", "(Landroid/net/Uri;I)Landroid/app/Notification$Builder;", AccessFlags = 1)]
						public virtual Builder SetSound(global::Android.Net.Uri sound, int streamType) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <summary>
						///  <para>Set the vibration pattern to use.</para> <para>See android.os.Vibrator#vibrate(long[], int) for a discussion of the  <code>pattern</code> parameter.</para> <para> <para>Notification::vibrate </para></para>        
						/// </summary>
						/// <java-name>
						/// setVibrate
						/// </java-name>
						[Dot42.DexImport("setVibrate", "([J)Landroid/app/Notification$Builder;", AccessFlags = 1)]
						public virtual Builder SetVibrate(long[] pattern) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <summary>
						///  <para>Set the desired color for the indicator LED on the device, as well as the blink duty cycle (specified in milliseconds).</para> <para>Not all devices will honor all (or even any) of these values.</para> <para> <para>Notification::ledARGB </para> <para>Notification::ledOnMS </para> <para>Notification::ledOffMS </para></para>        
						/// </summary>
						/// <java-name>
						/// setLights
						/// </java-name>
						[Dot42.DexImport("setLights", "(III)Landroid/app/Notification$Builder;", AccessFlags = 1)]
						public virtual Builder SetLights(int argb, int onMs, int offMs) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <summary>
						///  <para>Set whether this is an "ongoing" notification.</para> <para>Ongoing notifications cannot be dismissed by the user, so your application or service must take care of canceling them.</para> <para>They are typically used to indicate a background task that the user is actively engaged with (e.g., playing music) or is pending in some way and therefore occupying the device (e.g., a file download, sync operation, active network connection).</para> <para> <para>Notification::FLAG_ONGOING_EVENT </para> <para>Service::setForeground(boolean) </para></para>        
						/// </summary>
						/// <java-name>
						/// setOngoing
						/// </java-name>
						[Dot42.DexImport("setOngoing", "(Z)Landroid/app/Notification$Builder;", AccessFlags = 1)]
						public virtual Builder SetOngoing(bool ongoing) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <summary>
						///  <para>Set this flag if you would only like the sound, vibrate and ticker to be played if the notification is not already showing.</para> <para> <para>Notification::FLAG_ONLY_ALERT_ONCE </para></para>        
						/// </summary>
						/// <java-name>
						/// setOnlyAlertOnce
						/// </java-name>
						[Dot42.DexImport("setOnlyAlertOnce", "(Z)Landroid/app/Notification$Builder;", AccessFlags = 1)]
						public virtual Builder SetOnlyAlertOnce(bool onlyAlertOnce) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <summary>
						///  <para>Make this notification automatically dismissed when the user touches it. The PendingIntent set with setDeleteIntent will be sent when this happens.</para> <para> <para>Notification::FLAG_AUTO_CANCEL </para></para>        
						/// </summary>
						/// <java-name>
						/// setAutoCancel
						/// </java-name>
						[Dot42.DexImport("setAutoCancel", "(Z)Landroid/app/Notification$Builder;", AccessFlags = 1)]
						public virtual Builder SetAutoCancel(bool autoCancel) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <summary>
						///  <para>Set which notification properties will be inherited from system defaults. </para> <para>The value should be one or more of the following fields combined with bitwise-or: DEFAULT_SOUND, DEFAULT_VIBRATE, DEFAULT_LIGHTS. </para> <para>For all default values, use DEFAULT_ALL. </para>        
						/// </summary>
						/// <java-name>
						/// setDefaults
						/// </java-name>
						[Dot42.DexImport("setDefaults", "(I)Landroid/app/Notification$Builder;", AccessFlags = 1)]
						public virtual Builder SetDefaults(int defaults) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <summary>
						///  <para>Set the priority of this notification.</para> <para> <para>Notification::priority </para></para>        
						/// </summary>
						/// <java-name>
						/// setPriority
						/// </java-name>
						[Dot42.DexImport("setPriority", "(I)Landroid/app/Notification$Builder;", AccessFlags = 1)]
						public virtual Builder SetPriority(int pri) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <summary>
						///  <para>Add an action to this notification. Actions are typically displayed by the system as a button adjacent to the notification content. </para> <para>Every action must have an icon (32dp square and matching the  visual style), a textual label, and a PendingIntent. </para> <para>A notification in its expanded form can display up to 3 actions, from left to right in the order they were added. Actions will not be displayed when the notification is collapsed, however, so be sure that any essential functions may be accessed by the user in some other way (for example, in the Activity pointed to by contentIntent).</para> <para></para>        
						/// </summary>
						/// <java-name>
						/// addAction
						/// </java-name>
						[Dot42.DexImport("addAction", "(ILjava/lang/CharSequence;Landroid/app/PendingIntent;)Landroid/app/Notification$B" +
    "uilder;", AccessFlags = 1)]
						public virtual Builder AddAction(int icon, global::Java.Lang.ICharSequence title, global::Android.App.PendingIntent intent) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <summary>
						///  <para>Add a rich notification style to be applied at build time.</para> <para></para>        
						/// </summary>
						/// <java-name>
						/// setStyle
						/// </java-name>
						[Dot42.DexImport("setStyle", "(Landroid/app/Notification$Style;)Landroid/app/Notification$Builder;", AccessFlags = 1)]
						public virtual Builder SetStyle(global::Android.App.Notification.Style style) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <summary>
						///  <para>Combine all of the options that have been set and return a new Notification object. </para>        
						/// </summary>
						/// <java-name>
						/// build
						/// </java-name>
						[Dot42.DexImport("build", "()Landroid/app/Notification;", AccessFlags = 1)]
						public virtual global::Android.App.Notification Build() /* MethodBuilder.Create */ 
						{
								return default(global::Android.App.Notification);
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal Builder() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use build() instead. </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// getNotification
						/// </java-name>
						public virtual global::Android.App.Notification Notification
						{
								[Dot42.DexImport("getNotification", "()Landroid/app/Notification;", AccessFlags = 1)]
								get{ return default(global::Android.App.Notification); }
						}

				}

		}

		/// <summary>
		///  <para>Class to notify the user of events that happen. This is how you tell the user that something has happened in the background. {}</para> <para>Notifications can take different forms:  <ul> <li> <para>A persistent icon that goes in the status bar and is accessible through the launcher, (when the user selects it, a designated Intent can be launched), </para></li> <li> <para>Turning on or flashing LEDs on the device, or </para></li> <li> <para>Alerting the user by flashing the backlight, playing a sound, or vibrating. </para></li></ul></para> <para>Each of the notify methods takes an int id parameter and optionally a String tag parameter, which may be <c>null </c> . These parameters are used to form a pair (tag, id), or ( <c>null </c> , id) if tag is unspecified. This pair identifies this notification from your app to the system, so that pair should be unique within your app. If you call one of the notify methods with a (tag, id) pair that is currently active and a new set of notification parameters, it will be updated. For example, if you pass a new status bar icon, the old icon in the status bar will be replaced with the new one. This is also the same tag and id you pass to the cancel(int) or cancel(String, int) method to clear this notification.</para> <para>You do not instantiate this class directly; instead, retrieve it through android.content.Context#getSystemService.</para> <para>  <h3>Developer Guides</h3></para> <para> </para> <para>For a guide to creating notifications, read the  developer guide.</para> <para> </para> <para> <para>android.app.Notification </para> <para>android.content.Context::getSystemService </para></para>    
		/// </summary>
		/// <java-name>
		/// android/app/NotificationManager
		/// </java-name>
		[Dot42.DexImport("android/app/NotificationManager", AccessFlags = 33)]
		public partial class NotificationManager
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal NotificationManager() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Post a notification to be shown in the status bar. If a notification with the same id has already been posted by your application and has not yet been canceled, it will be replaced by the updated information.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// notify
				/// </java-name>
				[Dot42.DexImport("notify", "(ILandroid/app/Notification;)V", AccessFlags = 1)]
				public virtual void Notify(int id, global::Android.App.Notification notification) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Post a notification to be shown in the status bar. If a notification with the same tag and id has already been posted by your application and has not yet been canceled, it will be replaced by the updated information.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// notify
				/// </java-name>
				[Dot42.DexImport("notify", "(Ljava/lang/String;ILandroid/app/Notification;)V", AccessFlags = 1)]
				public virtual void Notify(string tag, int id, global::Android.App.Notification notification) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Cancel a previously shown notification. If it's transient, the view will be hidden. If it's persistent, it will be removed from the status bar. </para>        
				/// </summary>
				/// <java-name>
				/// cancel
				/// </java-name>
				[Dot42.DexImport("cancel", "(I)V", AccessFlags = 1)]
				public virtual void Cancel(int id) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Cancel a previously shown notification. If it's transient, the view will be hidden. If it's persistent, it will be removed from the status bar. </para>        
				/// </summary>
				/// <java-name>
				/// cancel
				/// </java-name>
				[Dot42.DexImport("cancel", "(Ljava/lang/String;I)V", AccessFlags = 1)]
				public virtual void Cancel(string tag, int id) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Cancel all previously shown notifications. See cancel for the detailed behavior. </para>        
				/// </summary>
				/// <java-name>
				/// cancelAll
				/// </java-name>
				[Dot42.DexImport("cancelAll", "()V", AccessFlags = 1)]
				public virtual void CancelAll() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>A description of an Intent and target action to perform with it. Instances of this class are created with getActivity, getActivities, getBroadcast, and getService; the returned object can be handed to other applications so that they can perform the action you described on your behalf at a later time.</para> <para>By giving a PendingIntent to another application, you are granting it the right to perform the operation you have specified as if the other application was yourself (with the same permissions and identity). As such, you should be careful about how you build the PendingIntent: almost always, for example, the base Intent you supply should have the component name explicitly set to one of your own components, to ensure it is ultimately sent there and nowhere else.</para> <para>A PendingIntent itself is simply a reference to a token maintained by the system describing the original data used to retrieve it. This means that, even if its owning application's process is killed, the PendingIntent itself will remain usable from other processes that have been given it. If the creating application later re-retrieves the same kind of PendingIntent (same operation, same Intent action, data, categories, and components, and same flags), it will receive a PendingIntent representing the same token if that is still valid, and can thus call cancel to remove it.</para> <para>Because of this behavior, it is important to know when two Intents are considered to be the same for purposes of retrieving a PendingIntent. A common mistake people make is to create multiple PendingIntent objects with Intents that only vary in their "extra" contents, expecting to get a different PendingIntent each time. This does  <b>not</b> happen. The parts of the Intent that are used for matching are the same ones defined by Intent.filterEquals. If you use two Intent objects that are equivalent as per Intent.filterEquals, then you will get the same PendingIntent for both of them.</para> <para>There are two typical ways to deal with this.</para> <para>If you truly need multiple distinct PendingIntent objects active at the same time (such as to use as two notifications that are both shown at the same time), then you will need to ensure there is something that is different about them to associate them with different PendingIntents. This may be any of the Intent attributes considered by Intent.filterEquals, or different request code integers supplied to getActivity, getActivities, getBroadcast, or getService.</para> <para>If you only need one PendingIntent active at a time for any of the Intents you will use, then you can alternatively use the flags FLAG_CANCEL_CURRENT or FLAG_UPDATE_CURRENT to either cancel or modify whatever current PendingIntent is associated with the Intent you are supplying. </para>    
		/// </summary>
		/// <java-name>
		/// android/app/PendingIntent
		/// </java-name>
		[Dot42.DexImport("android/app/PendingIntent", AccessFlags = 49)]
		public sealed partial class PendingIntent : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Flag for use with getActivity, getBroadcast, and getService: this PendingIntent can only be used once. If set, after send() is called on it, it will be automatically canceled for you and any future attempt to send through it will fail. </para>        
				/// </summary>
				/// <java-name>
				/// FLAG_ONE_SHOT
				/// </java-name>
				[Dot42.DexImport("FLAG_ONE_SHOT", "I", AccessFlags = 25)]
				public const int FLAG_ONE_SHOT = 1073741824;
				/// <summary>
				///  <para>Flag for use with getActivity, getBroadcast, and getService: if the described PendingIntent does not already exist, then simply return null instead of creating it. </para>        
				/// </summary>
				/// <java-name>
				/// FLAG_NO_CREATE
				/// </java-name>
				[Dot42.DexImport("FLAG_NO_CREATE", "I", AccessFlags = 25)]
				public const int FLAG_NO_CREATE = 536870912;
				/// <summary>
				///  <para>Flag for use with getActivity, getBroadcast, and getService: if the described PendingIntent already exists, the current one is canceled before generating a new one. You can use this to retrieve a new PendingIntent when you are only changing the extra data in the Intent; by canceling the previous pending intent, this ensures that only entities given the new data will be able to launch it. If this assurance is not an issue, consider FLAG_UPDATE_CURRENT. </para>        
				/// </summary>
				/// <java-name>
				/// FLAG_CANCEL_CURRENT
				/// </java-name>
				[Dot42.DexImport("FLAG_CANCEL_CURRENT", "I", AccessFlags = 25)]
				public const int FLAG_CANCEL_CURRENT = 268435456;
				/// <summary>
				///  <para>Flag for use with getActivity, getBroadcast, and getService: if the described PendingIntent already exists, then keep it but its replace its extra data with what is in this new Intent. This can be used if you are creating intents where only the extras change, and don't care that any entities that received your previous PendingIntent will be able to launch it with your new extras even if they are not explicitly given to it. </para>        
				/// </summary>
				/// <java-name>
				/// FLAG_UPDATE_CURRENT
				/// </java-name>
				[Dot42.DexImport("FLAG_UPDATE_CURRENT", "I", AccessFlags = 25)]
				public const int FLAG_UPDATE_CURRENT = 134217728;
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.App.PendingIntent> CREATOR;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal PendingIntent() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Retrieve a PendingIntent that will start a new activity, like calling Context.startActivity(Intent). Note that the activity will be started outside of the context of an existing activity, so you must use the Intent.FLAG_ACTIVITY_NEW_TASK launch flag in the Intent.</para> <para>For security reasons, the android.content.Intent you supply here should almost always be an  <b>explicit intent</b>, that is specify an explicit component to be delivered to through Intent#setClass(android.content.Context, Class) Intent.setClass</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns an existing or new PendingIntent matching the given parameters. May return null only if FLAG_NO_CREATE has been supplied. </para>
				/// </returns>
				/// <java-name>
				/// getActivity
				/// </java-name>
				[Dot42.DexImport("getActivity", "(Landroid/content/Context;ILandroid/content/Intent;I)Landroid/app/PendingIntent;", AccessFlags = 9)]
				public static global::Android.App.PendingIntent GetActivity(global::Android.Content.Context context, int requestCode, global::Android.Content.Intent intent, int flags) /* MethodBuilder.Create */ 
				{
						return default(global::Android.App.PendingIntent);
				}

				/// <summary>
				///  <para>Retrieve a PendingIntent that will start a new activity, like calling Context.startActivity(Intent). Note that the activity will be started outside of the context of an existing activity, so you must use the Intent.FLAG_ACTIVITY_NEW_TASK launch flag in the Intent.</para> <para>For security reasons, the android.content.Intent you supply here should almost always be an  <b>explicit intent</b>, that is specify an explicit component to be delivered to through Intent#setClass(android.content.Context, Class) Intent.setClass</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns an existing or new PendingIntent matching the given parameters. May return null only if FLAG_NO_CREATE has been supplied. </para>
				/// </returns>
				/// <java-name>
				/// getActivity
				/// </java-name>
				[Dot42.DexImport("getActivity", "(Landroid/content/Context;ILandroid/content/Intent;ILandroid/os/Bundle;)Landroid/" +
    "app/PendingIntent;", AccessFlags = 9)]
				public static global::Android.App.PendingIntent GetActivity(global::Android.Content.Context context, int requestCode, global::Android.Content.Intent intent, int flags, global::Android.OS.Bundle options) /* MethodBuilder.Create */ 
				{
						return default(global::Android.App.PendingIntent);
				}

				/// <summary>
				///  <para>Like getActivity(Context, int, Intent, int), but allows an array of Intents to be supplied. The last Intent in the array is taken as the primary key for the PendingIntent, like the single Intent given to getActivity(Context, int, Intent, int). Upon sending the resulting PendingIntent, all of the Intents are started in the same way as they would be by passing them to Context#startActivities(Intent[]).</para> <para>The  <b>first</b> intent in the array will be started outside of the context of an existing activity, so you must use the Intent.FLAG_ACTIVITY_NEW_TASK launch flag in the Intent. (Activities after the first in the array are started in the context of the previous activity in the array, so FLAG_ACTIVITY_NEW_TASK is not needed nor desired for them.) </para> <para>The  <b>last</b> intent in the array represents the key for the PendingIntent. In other words, it is the significant element for matching (as done with the single intent given to getActivity(Context, int, Intent, int), its content will be the subject of replacement by send(Context, int, Intent) and FLAG_UPDATE_CURRENT, etc. This is because it is the most specific of the supplied intents, and the UI the user actually sees when the intents are started. </para> <para>For security reasons, the android.content.Intent objects you supply here should almost always be  <b>explicit intents</b>, that is specify an explicit component to be delivered to through Intent#setClass(android.content.Context, Class) Intent.setClass</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns an existing or new PendingIntent matching the given parameters. May return null only if FLAG_NO_CREATE has been supplied. </para>
				/// </returns>
				/// <java-name>
				/// getActivities
				/// </java-name>
				[Dot42.DexImport("getActivities", "(Landroid/content/Context;I[Landroid/content/Intent;I)Landroid/app/PendingIntent;" +
    "", AccessFlags = 9)]
				public static global::Android.App.PendingIntent GetActivities(global::Android.Content.Context context, int requestCode, global::Android.Content.Intent[] intents, int flags) /* MethodBuilder.Create */ 
				{
						return default(global::Android.App.PendingIntent);
				}

				/// <summary>
				///  <para>Like getActivity(Context, int, Intent, int), but allows an array of Intents to be supplied. The last Intent in the array is taken as the primary key for the PendingIntent, like the single Intent given to getActivity(Context, int, Intent, int). Upon sending the resulting PendingIntent, all of the Intents are started in the same way as they would be by passing them to Context#startActivities(Intent[]).</para> <para>The  <b>first</b> intent in the array will be started outside of the context of an existing activity, so you must use the Intent.FLAG_ACTIVITY_NEW_TASK launch flag in the Intent. (Activities after the first in the array are started in the context of the previous activity in the array, so FLAG_ACTIVITY_NEW_TASK is not needed nor desired for them.) </para> <para>The  <b>last</b> intent in the array represents the key for the PendingIntent. In other words, it is the significant element for matching (as done with the single intent given to getActivity(Context, int, Intent, int), its content will be the subject of replacement by send(Context, int, Intent) and FLAG_UPDATE_CURRENT, etc. This is because it is the most specific of the supplied intents, and the UI the user actually sees when the intents are started. </para> <para>For security reasons, the android.content.Intent objects you supply here should almost always be  <b>explicit intents</b>, that is specify an explicit component to be delivered to through Intent#setClass(android.content.Context, Class) Intent.setClass</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns an existing or new PendingIntent matching the given parameters. May return null only if FLAG_NO_CREATE has been supplied. </para>
				/// </returns>
				/// <java-name>
				/// getActivities
				/// </java-name>
				[Dot42.DexImport("getActivities", "(Landroid/content/Context;I[Landroid/content/Intent;ILandroid/os/Bundle;)Landroid" +
    "/app/PendingIntent;", AccessFlags = 9)]
				public static global::Android.App.PendingIntent GetActivities(global::Android.Content.Context context, int requestCode, global::Android.Content.Intent[] intents, int flags, global::Android.OS.Bundle options) /* MethodBuilder.Create */ 
				{
						return default(global::Android.App.PendingIntent);
				}

				/// <summary>
				///  <para>Retrieve a PendingIntent that will perform a broadcast, like calling Context.sendBroadcast().</para> <para>For security reasons, the android.content.Intent you supply here should almost always be an  <b>explicit intent</b>, that is specify an explicit component to be delivered to through Intent#setClass(android.content.Context, Class) Intent.setClass</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns an existing or new PendingIntent matching the given parameters. May return null only if FLAG_NO_CREATE has been supplied. </para>
				/// </returns>
				/// <java-name>
				/// getBroadcast
				/// </java-name>
				[Dot42.DexImport("getBroadcast", "(Landroid/content/Context;ILandroid/content/Intent;I)Landroid/app/PendingIntent;", AccessFlags = 9)]
				public static global::Android.App.PendingIntent GetBroadcast(global::Android.Content.Context context, int requestCode, global::Android.Content.Intent intent, int flags) /* MethodBuilder.Create */ 
				{
						return default(global::Android.App.PendingIntent);
				}

				/// <summary>
				///  <para>Retrieve a PendingIntent that will start a service, like calling Context.startService(). The start arguments given to the service will come from the extras of the Intent.</para> <para>For security reasons, the android.content.Intent you supply here should almost always be an  <b>explicit intent</b>, that is specify an explicit component to be delivered to through Intent#setClass(android.content.Context, Class) Intent.setClass</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns an existing or new PendingIntent matching the given parameters. May return null only if FLAG_NO_CREATE has been supplied. </para>
				/// </returns>
				/// <java-name>
				/// getService
				/// </java-name>
				[Dot42.DexImport("getService", "(Landroid/content/Context;ILandroid/content/Intent;I)Landroid/app/PendingIntent;", AccessFlags = 9)]
				public static global::Android.App.PendingIntent GetService(global::Android.Content.Context context, int requestCode, global::Android.Content.Intent intent, int flags) /* MethodBuilder.Create */ 
				{
						return default(global::Android.App.PendingIntent);
				}

				/// <summary>
				///  <para>Cancel a currently active PendingIntent. Only the original application owning a PendingIntent can cancel it. </para>        
				/// </summary>
				/// <java-name>
				/// cancel
				/// </java-name>
				[Dot42.DexImport("cancel", "()V", AccessFlags = 1)]
				public void Cancel() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Perform the operation associated with this PendingIntent.</para> <para> <para>send(Context, int, Intent, android.app.PendingIntent.OnFinished, Handler)</para></para>        
				/// </summary>
				/// <java-name>
				/// send
				/// </java-name>
				[Dot42.DexImport("send", "()V", AccessFlags = 1)]
				public void Send() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Perform the operation associated with this PendingIntent.</para> <para> <para>send(Context, int, Intent, android.app.PendingIntent.OnFinished, Handler)</para></para>        
				/// </summary>
				/// <java-name>
				/// send
				/// </java-name>
				[Dot42.DexImport("send", "(I)V", AccessFlags = 1)]
				public void Send(int code) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Perform the operation associated with this PendingIntent, allowing the caller to specify information about the Intent to use.</para> <para> <para>send(Context, int, Intent, android.app.PendingIntent.OnFinished, Handler)</para></para>        
				/// </summary>
				/// <java-name>
				/// send
				/// </java-name>
				[Dot42.DexImport("send", "(Landroid/content/Context;ILandroid/content/Intent;)V", AccessFlags = 1)]
				public void Send(global::Android.Content.Context context, int code, global::Android.Content.Intent intent) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Perform the operation associated with this PendingIntent, allowing the caller to specify information about the Intent to use.</para> <para> <para>send(Context, int, Intent, android.app.PendingIntent.OnFinished, Handler)</para></para>        
				/// </summary>
				/// <java-name>
				/// send
				/// </java-name>
				[Dot42.DexImport("send", "(ILandroid/app/PendingIntent$OnFinished;Landroid/os/Handler;)V", AccessFlags = 1)]
				public void Send(int context, global::Android.App.PendingIntent.IOnFinished code, global::Android.OS.Handler intent) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Perform the operation associated with this PendingIntent, allowing the caller to specify information about the Intent to use and be notified when the send has completed.</para> <para>For the intent parameter, a PendingIntent often has restrictions on which fields can be supplied here, based on how the PendingIntent was retrieved in getActivity, getBroadcast, or getService.</para> <para> <para>send() </para> <para>send(int) </para> <para>send(Context, int, Intent) </para> <para>send(int, android.app.PendingIntent.OnFinished, Handler) </para> <para>send(Context, int, Intent, OnFinished, Handler, String)</para></para>        
				/// </summary>
				/// <java-name>
				/// send
				/// </java-name>
				[Dot42.DexImport("send", "(Landroid/content/Context;ILandroid/content/Intent;Landroid/app/PendingIntent$OnF" +
    "inished;Landroid/os/Handler;)V", AccessFlags = 1)]
				public void Send(global::Android.Content.Context context, int code, global::Android.Content.Intent intent, global::Android.App.PendingIntent.IOnFinished onFinished, global::Android.OS.Handler handler) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Perform the operation associated with this PendingIntent, allowing the caller to specify information about the Intent to use and be notified when the send has completed.</para> <para>For the intent parameter, a PendingIntent often has restrictions on which fields can be supplied here, based on how the PendingIntent was retrieved in getActivity, getBroadcast, or getService.</para> <para> <para>send() </para> <para>send(int) </para> <para>send(Context, int, Intent) </para> <para>send(int, android.app.PendingIntent.OnFinished, Handler) </para> <para>send(Context, int, Intent, OnFinished, Handler)</para></para>        
				/// </summary>
				/// <java-name>
				/// send
				/// </java-name>
				[Dot42.DexImport("send", "(Landroid/content/Context;ILandroid/content/Intent;Landroid/app/PendingIntent$OnF" +
    "inished;Landroid/os/Handler;Ljava/lang/String;)V", AccessFlags = 1)]
				public void Send(global::Android.Content.Context context, int code, global::Android.Content.Intent intent, global::Android.App.PendingIntent.IOnFinished onFinished, global::Android.OS.Handler handler, string requiredPermission) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Comparison operator on two PendingIntent objects, such that true is returned then they both represent the same operation from the same package. This allows you to use getActivity, getBroadcast, or getService multiple times (even across a process being killed), resulting in different PendingIntent objects but whose equals() method identifies them as being the same operation. </para>        
				/// </summary>
				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object otherObj) /* MethodBuilder.Create */ 
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
				///  <para>Convenience function for writing either a PendingIntent or null pointer to a Parcel. You must use this with readPendingIntentOrNullFromParcel for later reading it.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// writePendingIntentOrNullToParcel
				/// </java-name>
				[Dot42.DexImport("writePendingIntentOrNullToParcel", "(Landroid/app/PendingIntent;Landroid/os/Parcel;)V", AccessFlags = 9)]
				public static void WritePendingIntentOrNullToParcel(global::Android.App.PendingIntent sender, global::Android.OS.Parcel @out) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Convenience function for reading either a Messenger or null pointer from a Parcel. You must have previously written the Messenger with writePendingIntentOrNullToParcel.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns the Messenger read from the Parcel, or null if null had been written. </para>
				/// </returns>
				/// <java-name>
				/// readPendingIntentOrNullFromParcel
				/// </java-name>
				[Dot42.DexImport("readPendingIntentOrNullFromParcel", "(Landroid/os/Parcel;)Landroid/app/PendingIntent;", AccessFlags = 9)]
				public static global::Android.App.PendingIntent ReadPendingIntentOrNullFromParcel(global::Android.OS.Parcel @in) /* MethodBuilder.Create */ 
				{
						return default(global::Android.App.PendingIntent);
				}

				/// <summary>
				///  <para>Retrieve a IntentSender object that wraps the existing sender of the PendingIntent</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns a IntentSender object that wraps the sender of PendingIntent </para>
				/// </returns>
				/// <java-name>
				/// getIntentSender
				/// </java-name>
				public global::Android.Content.IntentSender IntentSender
				{
						[Dot42.DexImport("getIntentSender", "()Landroid/content/IntentSender;", AccessFlags = 1)]
						get{ return default(global::Android.Content.IntentSender); }
				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Renamed to getCreatorPackage(). </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// getTargetPackage
				/// </java-name>
				public string TargetPackage
				{
						[Dot42.DexImport("getTargetPackage", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>Return the package name of the application that created this PendingIntent, that is the identity under which you will actually be sending the Intent. The returned string is supplied by the system, so that an application can not spoof its package.</para> <para>Be careful about how you use this. All this tells you is who created the PendingIntent. It does  <b>not</b> tell you who handed the PendingIntent to you: that is, PendingIntent objects are intended to be passed between applications, so the PendingIntent you receive from an application could actually be one it received from another application, meaning the result you get here will identify the original application. Because of this, you should only use this information to identify who you expect to be interacting with through a send call, not who gave you the PendingIntent.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The package name of the PendingIntent, or null if there is none associated with it. </para>
				/// </returns>
				/// <java-name>
				/// getCreatorPackage
				/// </java-name>
				public string CreatorPackage
				{
						[Dot42.DexImport("getCreatorPackage", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>Return the uid of the application that created this PendingIntent, that is the identity under which you will actually be sending the Intent. The returned integer is supplied by the system, so that an application can not spoof its uid.</para> <para>Be careful about how you use this. All this tells you is who created the PendingIntent. It does  <b>not</b> tell you who handed the PendingIntent to you: that is, PendingIntent objects are intended to be passed between applications, so the PendingIntent you receive from an application could actually be one it received from another application, meaning the result you get here will identify the original application. Because of this, you should only use this information to identify who you expect to be interacting with through a send call, not who gave you the PendingIntent.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The uid of the PendingIntent, or -1 if there is none associated with it. </para>
				/// </returns>
				/// <java-name>
				/// getCreatorUid
				/// </java-name>
				public int CreatorUid
				{
						[Dot42.DexImport("getCreatorUid", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Return the user handle of the application that created this PendingIntent, that is the user under which you will actually be sending the Intent. The returned UserHandle is supplied by the system, so that an application can not spoof its user. See Process.myUserHandle() for more explanation of user handles.</para> <para>Be careful about how you use this. All this tells you is who created the PendingIntent. It does  <b>not</b> tell you who handed the PendingIntent to you: that is, PendingIntent objects are intended to be passed between applications, so the PendingIntent you receive from an application could actually be one it received from another application, meaning the result you get here will identify the original application. Because of this, you should only use this information to identify who you expect to be interacting with through a send call, not who gave you the PendingIntent.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The user handle of the PendingIntent, or null if there is none associated with it. </para>
				/// </returns>
				/// <java-name>
				/// getCreatorUserHandle
				/// </java-name>
				public global::Android.OS.UserHandle CreatorUserHandle
				{
						[Dot42.DexImport("getCreatorUserHandle", "()Landroid/os/UserHandle;", AccessFlags = 1)]
						get{ return default(global::Android.OS.UserHandle); }
				}

				/// <summary>
				///  <para>Callback interface for discovering when a send operation has completed. Primarily for use with a PendingIntent that is performing a broadcast, this provides the same information as calling String, android.content.BroadcastReceiver, Handler, int, String, Bundle) Context.sendBroadcast() with a final BroadcastReceiver. </para>    
				/// </summary>
				/// <java-name>
				/// android/app/PendingIntent$OnFinished
				/// </java-name>
				[Dot42.DexImport("android/app/PendingIntent$OnFinished", AccessFlags = 1545)]
				public partial interface IOnFinished
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>Called when a send operation as completed.</para> <para></para>        
						/// </summary>
						/// <java-name>
						/// onSendFinished
						/// </java-name>
						[Dot42.DexImport("onSendFinished", "(Landroid/app/PendingIntent;Landroid/content/Intent;ILjava/lang/String;Landroid/o" +
    "s/Bundle;)V", AccessFlags = 1025)]
						void OnSendFinished(global::Android.App.PendingIntent pendingIntent, global::Android.Content.Intent intent, int resultCode, string resultData, global::Android.OS.Bundle resultExtras) /* MethodBuilder.Create */ ;

				}

				/// <summary>
				///  <para>Exception thrown when trying to send through a PendingIntent that has been canceled or is otherwise no longer able to execute the request. </para>    
				/// </summary>
				/// <java-name>
				/// android/app/PendingIntent$CanceledException
				/// </java-name>
				[Dot42.DexImport("android/app/PendingIntent$CanceledException", AccessFlags = 9)]
				public partial class CanceledException : global::Android.Util.AndroidException
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public CanceledException() /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
						public CanceledException(string @string) /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "(Ljava/lang/Exception;)V", AccessFlags = 1)]
						public CanceledException(global::System.Exception exception) /* MethodBuilder.Create */ 
						{
						}

				}

		}

		/// <summary>
		///  <para>Base class for presentations. </para> <para>A presentation is a special kind of dialog whose purpose is to present content on a secondary display. A Presentation is associated with the target Display at creation time and configures its context and resource configuration according to the display's metrics. </para> <para>Notably, the Context of a presentation is different from the context of its containing Activity. It is important to inflate the layout of a presentation and load other resources using the presentation's own context to ensure that assets of the correct size and density for the target display are loaded. </para> <para>A presentation is automatically canceled (see Dialog#cancel()) when the display to which it is attached is removed. An activity should take care of pausing and resuming whatever content is playing within the presentation whenever the activity itself is paused or resumed. </para> <para> <h3>Choosing a presentation display</h3></para> <para>Before showing a Presentation it's important to choose the Display on which it will appear. Choosing a presentation display is sometimes difficult because there may be multiple displays attached. Rather than trying to guess which display is best, an application should let the system choose a suitable presentation display. </para> <para>There are two main ways to choose a Display. </para> <para> <h4>Using the media router to choose a presentation display</h4></para> <para>The easiest way to choose a presentation display is to use the MediaRouter API. The media router service keeps track of which audio and video routes are available on the system. The media router sends notifications whenever routes are selected or unselected or when the preferred presentation display of a route changes. So an application can simply watch for these notifications and show or dismiss a presentation on the preferred presentation display automatically. </para> <para>The preferred presentation display is the display that the media router recommends that the application should use if it wants to show content on the secondary display. Sometimes there may not be a preferred presentation display in which case the application should show its content locally without using a presentation. </para> <para>Here's how to use the media router to create and show a presentation on the preferred presentation display using android.media.MediaRouter.RouteInfo#getPresentationDisplay(). </para> <para> <pre>
		/// MediaRouter mediaRouter = (MediaRouter) context.getSystemService(Context.MEDIA_ROUTER_SERVICE);
		/// MediaRouter.RouteInfo route = mediaRouter.getSelectedRoute();
		/// if (route != null) {
		///     Display presentationDisplay = route.getPresentationDisplay();
		///     if (presentationDisplay != null) {
		///         Presentation presentation = new MyPresentation(context, presentationDisplay);
		///         presentation.show();
		///     }
		/// }</pre> </para> <para>The following sample code from  <code>ApiDemos</code> demonstrates how to use the media router to automatically switch between showing content in the main activity and showing the content in a presentation when a presentation display is available. </para> <para>{ development/samples/ApiDemos/src/com/example/android/apis/app/PresentationWithMediaRouterActivity.java activity}</para> <para> <h4>Using the display manager to choose a presentation display</h4></para> <para>Another way to choose a presentation display is to use the DisplayManager API directly. The display manager service provides functions to enumerate and describe all displays that are attached to the system including displays that may be used for presentations. </para> <para>The display manager keeps track of all displays in the system. However, not all displays are appropriate for showing presentations. For example, if an activity attempted to show a presentation on the main display it might obscure its own content (it's like opening a dialog on top of your activity). </para> <para>Here's how to identify suitable displays for showing presentations using DisplayManager#getDisplays(String) and the DisplayManager#DISPLAY_CATEGORY_PRESENTATION category. </para> <para> <pre>
		/// DisplayManager displayManager = (DisplayManager) context.getSystemService(Context.DISPLAY_SERVICE);
		/// Display[] presentationDisplays = displayManager.getDisplays(DisplayManager.DISPLAY_CATEGORY_PRESENTATION);
		/// if (presentationDisplays.length &gt; 0) {
		///     // If there is more than one suitable presentation display, then we could consider
		///     // giving the user a choice.  For this example, we simply choose the first display
		///     // which is the one the system recommends as the preferred presentation display.
		///     Display display = presentationDisplays[0];
		///     Presentation presentation = new MyPresentation(context, presentationDisplay);
		///     presentation.show();
		/// }</pre> </para> <para>The following sample code from  <code>ApiDemos</code> demonstrates how to use the display manager to enumerate displays and show content on multiple presentation displays simultaneously. </para> <para>{ development/samples/ApiDemos/src/com/example/android/apis/app/PresentationActivity.java activity}</para> <para> <para>android.media.MediaRouter::ROUTE_TYPE_LIVE_VIDEO for information on about live video routes and how to obtain the preferred presentation display for the current media route. </para> <para>DisplayManager for information on how to enumerate displays and receive notifications when displays are added or removed. </para></para>    
		/// </summary>
		/// <java-name>
		/// android/app/Presentation
		/// </java-name>
		[Dot42.DexImport("android/app/Presentation", AccessFlags = 33)]
		public partial class Presentation : global::Android.App.Dialog
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Creates a new presentation that is attached to the specified display using the default theme.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/view/Display;)V", AccessFlags = 1)]
				public Presentation(global::Android.Content.Context outerContext, global::Android.Views.Display display) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Creates a new presentation that is attached to the specified display using the optionally specified theme.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/view/Display;I)V", AccessFlags = 1)]
				public Presentation(global::Android.Content.Context outerContext, global::Android.Views.Display display, int theme) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onStart
				/// </java-name>
				[Dot42.DexImport("onStart", "()V", AccessFlags = 4)]
				protected internal override void OnStart() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onStop
				/// </java-name>
				[Dot42.DexImport("onStop", "()V", AccessFlags = 4)]
				protected internal override void OnStop() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Inherited from Dialog#show. Will throw android.view.WindowManager.InvalidDisplayException if the specified secondary Display can't be found. </para>        
				/// </summary>
				/// <java-name>
				/// show
				/// </java-name>
				[Dot42.DexImport("show", "()V", AccessFlags = 1)]
				public override void Show() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Called by the system when the Display to which the presentation is attached has been removed.</para> <para>The system automatically calls cancel to dismiss the presentation after sending this event.</para> <para> <para>getDisplay </para></para>        
				/// </summary>
				/// <java-name>
				/// onDisplayRemoved
				/// </java-name>
				[Dot42.DexImport("onDisplayRemoved", "()V", AccessFlags = 1)]
				public virtual void OnDisplayRemoved() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Called by the system when the properties of the Display to which the presentation is attached have changed.</para> <para>If the display metrics have changed (for example, if the display has been resized or rotated), then the system automatically calls cancel to dismiss the presentation.</para> <para> <para>getDisplay </para></para>        
				/// </summary>
				/// <java-name>
				/// onDisplayChanged
				/// </java-name>
				[Dot42.DexImport("onDisplayChanged", "()V", AccessFlags = 1)]
				public virtual void OnDisplayChanged() /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal Presentation() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Gets the Display that this presentation appears on.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The display. </para>
				/// </returns>
				/// <java-name>
				/// getDisplay
				/// </java-name>
				public virtual global::Android.Views.Display Display
				{
						[Dot42.DexImport("getDisplay", "()Landroid/view/Display;", AccessFlags = 1)]
						get{ return default(global::Android.Views.Display); }
				}

				/// <summary>
				///  <para>Gets the Resources that should be used to inflate the layout of this presentation. This resources object has been configured according to the metrics of the display that the presentation appears on.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The presentation resources object. </para>
				/// </returns>
				/// <java-name>
				/// getResources
				/// </java-name>
				public virtual global::Android.Content.Res.Resources Resources
				{
						[Dot42.DexImport("getResources", "()Landroid/content/res/Resources;", AccessFlags = 1)]
						get{ return default(global::Android.Content.Res.Resources); }
				}

		}

		/// <summary>
		///  <para>A dialog showing a progress indicator and an optional text message or view. Only a text message or a view can be used at the same time.</para> <para>The dialog can be made cancelable on back key press.</para> <para>The progress range is 0..10000.</para>    
		/// </summary>
		/// <java-name>
		/// android/app/ProgressDialog
		/// </java-name>
		[Dot42.DexImport("android/app/ProgressDialog", AccessFlags = 33)]
		public partial class ProgressDialog : global::Android.App.AlertDialog
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Creates a ProgressDialog with a circular, spinning progress bar. This is the default. </para>        
				/// </summary>
				/// <java-name>
				/// STYLE_SPINNER
				/// </java-name>
				[Dot42.DexImport("STYLE_SPINNER", "I", AccessFlags = 25)]
				public const int STYLE_SPINNER = 0;
				/// <summary>
				///  <para>Creates a ProgressDialog with a horizontal progress bar. </para>        
				/// </summary>
				/// <java-name>
				/// STYLE_HORIZONTAL
				/// </java-name>
				[Dot42.DexImport("STYLE_HORIZONTAL", "I", AccessFlags = 25)]
				public const int STYLE_HORIZONTAL = 1;
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public ProgressDialog(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;I)V", AccessFlags = 1)]
				public ProgressDialog(global::Android.Content.Context context, int theme) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// show
				/// </java-name>
				[Dot42.DexImport("show", "(Landroid/content/Context;Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Landro" +
    "id/app/ProgressDialog;", AccessFlags = 9)]
				public static global::Android.App.ProgressDialog Show(global::Android.Content.Context context, global::Java.Lang.ICharSequence title, global::Java.Lang.ICharSequence message) /* MethodBuilder.Create */ 
				{
						return default(global::Android.App.ProgressDialog);
				}

				/// <java-name>
				/// show
				/// </java-name>
				[Dot42.DexImport("show", "(Landroid/content/Context;Ljava/lang/CharSequence;Ljava/lang/CharSequence;Z)Landr" +
    "oid/app/ProgressDialog;", AccessFlags = 9)]
				public static global::Android.App.ProgressDialog Show(global::Android.Content.Context context, global::Java.Lang.ICharSequence title, global::Java.Lang.ICharSequence message, bool indeterminate) /* MethodBuilder.Create */ 
				{
						return default(global::Android.App.ProgressDialog);
				}

				/// <java-name>
				/// show
				/// </java-name>
				[Dot42.DexImport("show", "(Landroid/content/Context;Ljava/lang/CharSequence;Ljava/lang/CharSequence;ZZ)Land" +
    "roid/app/ProgressDialog;", AccessFlags = 9)]
				public static global::Android.App.ProgressDialog Show(global::Android.Content.Context context, global::Java.Lang.ICharSequence title, global::Java.Lang.ICharSequence message, bool indeterminate, bool cancelable) /* MethodBuilder.Create */ 
				{
						return default(global::Android.App.ProgressDialog);
				}

				/// <java-name>
				/// show
				/// </java-name>
				[Dot42.DexImport("show", "(Landroid/content/Context;Ljava/lang/CharSequence;Ljava/lang/CharSequence;ZZLandr" +
    "oid/content/DialogInterface$OnCancelListener;)Landroid/app/ProgressDialog;", AccessFlags = 9)]
				public static global::Android.App.ProgressDialog Show(global::Android.Content.Context context, global::Java.Lang.ICharSequence title, global::Java.Lang.ICharSequence message, bool indeterminate, bool cancelable, global::Android.Content.IDialogInterface_IOnCancelListener cancelListener) /* MethodBuilder.Create */ 
				{
						return default(global::Android.App.ProgressDialog);
				}

				/// <java-name>
				/// onCreate
				/// </java-name>
				[Dot42.DexImport("onCreate", "(Landroid/os/Bundle;)V", AccessFlags = 4)]
				protected internal override void OnCreate(global::Android.OS.Bundle savedInstanceState) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onStart
				/// </java-name>
				[Dot42.DexImport("onStart", "()V", AccessFlags = 1)]
				public new virtual void OnStart() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onStop
				/// </java-name>
				[Dot42.DexImport("onStop", "()V", AccessFlags = 4)]
				protected internal override void OnStop() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// incrementProgressBy
				/// </java-name>
				[Dot42.DexImport("incrementProgressBy", "(I)V", AccessFlags = 1)]
				public virtual void IncrementProgressBy(int diff) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// incrementSecondaryProgressBy
				/// </java-name>
				[Dot42.DexImport("incrementSecondaryProgressBy", "(I)V", AccessFlags = 1)]
				public virtual void IncrementSecondaryProgressBy(int diff) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setProgressDrawable
				/// </java-name>
				[Dot42.DexImport("setProgressDrawable", "(Landroid/graphics/drawable/Drawable;)V", AccessFlags = 1)]
				public virtual void SetProgressDrawable(global::Android.Graphics.Drawables.Drawable d) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setIndeterminateDrawable
				/// </java-name>
				[Dot42.DexImport("setIndeterminateDrawable", "(Landroid/graphics/drawable/Drawable;)V", AccessFlags = 1)]
				public virtual void SetIndeterminateDrawable(global::Android.Graphics.Drawables.Drawable d) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setMessage
				/// </java-name>
				[Dot42.DexImport("setMessage", "(Ljava/lang/CharSequence;)V", AccessFlags = 1)]
				public override void SetMessage(global::Java.Lang.ICharSequence message) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setProgressStyle
				/// </java-name>
				[Dot42.DexImport("setProgressStyle", "(I)V", AccessFlags = 1)]
				public virtual void SetProgressStyle(int style) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Change the format of the small text showing current and maximum units of progress. The default is "%1d/%2d". Should not be called during the number is progressing. </para>        
				/// </summary>
				/// <java-name>
				/// setProgressNumberFormat
				/// </java-name>
				[Dot42.DexImport("setProgressNumberFormat", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetProgressNumberFormat(string format) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Change the format of the small text showing the percentage of progress. The default is NumberFormat.getPercentageInstnace(). Should not be called during the number is progressing. </para>        
				/// </summary>
				/// <java-name>
				/// setProgressPercentFormat
				/// </java-name>
				[Dot42.DexImport("setProgressPercentFormat", "(Ljava/text/NumberFormat;)V", AccessFlags = 1)]
				public virtual void SetProgressPercentFormat(global::Java.Text.NumberFormat format) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ProgressDialog() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getProgress
				/// </java-name>
				public virtual int Progress
				{
						[Dot42.DexImport("getProgress", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setProgress", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getSecondaryProgress
				/// </java-name>
				public virtual int SecondaryProgress
				{
						[Dot42.DexImport("getSecondaryProgress", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setSecondaryProgress", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getMax
				/// </java-name>
				public virtual int Max
				{
						[Dot42.DexImport("getMax", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setMax", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// isIndeterminate
				/// </java-name>
				public virtual bool IsIndeterminate
				{
						[Dot42.DexImport("isIndeterminate", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setIndeterminate", "(Z)V", AccessFlags = 1)]
						set{ }
				}

		}

		/// <summary>
		///  <para>Searchability meta-data for an activity. Only applications that search other applications should need to use this class. See  for more information about declaring searchability meta-data for your application.</para> <para> <para>SearchManager::getSearchableInfo(ComponentName) </para> <para>SearchManager::getSearchablesInGlobalSearch() </para></para>    
		/// </summary>
		/// <java-name>
		/// android/app/SearchableInfo
		/// </java-name>
		[Dot42.DexImport("android/app/SearchableInfo", AccessFlags = 49)]
		public sealed partial class SearchableInfo : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Support for parcelable and aidl operations. </para>        
				/// </summary>
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.App.SearchableInfo> CREATOR;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal SearchableInfo() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Checks whether the text in the query field should come from the suggestion intent data.</para> <para> <para>android.R.styleable::Searchable_searchMode </para></para>        
				/// </summary>
				/// <java-name>
				/// shouldRewriteQueryFromData
				/// </java-name>
				[Dot42.DexImport("shouldRewriteQueryFromData", "()Z", AccessFlags = 1)]
				public bool ShouldRewriteQueryFromData() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Checks whether the text in the query field should come from the suggestion title.</para> <para> <para>android.R.styleable::Searchable_searchMode </para></para>        
				/// </summary>
				/// <java-name>
				/// shouldRewriteQueryFromText
				/// </java-name>
				[Dot42.DexImport("shouldRewriteQueryFromText", "()Z", AccessFlags = 1)]
				public bool ShouldRewriteQueryFromText() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Checks whether the searchable should be included in global search.</para> <para> <para>android.R.styleable::Searchable_includeInGlobalSearch </para></para>        
				/// </summary>
				/// <returns>
				///  <para>The value of the android.R.styleable#Searchable_includeInGlobalSearch attribute, or <c>false </c> if the attribute is not set. </para>
				/// </returns>
				/// <java-name>
				/// shouldIncludeInGlobalSearch
				/// </java-name>
				[Dot42.DexImport("shouldIncludeInGlobalSearch", "()Z", AccessFlags = 1)]
				public bool ShouldIncludeInGlobalSearch() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Checks whether this searchable activity should be queried for suggestions if a prefix of the query has returned no results.</para> <para> <para>android.R.styleable::Searchable_queryAfterZeroResults </para></para>        
				/// </summary>
				/// <java-name>
				/// queryAfterZeroResults
				/// </java-name>
				[Dot42.DexImport("queryAfterZeroResults", "()Z", AccessFlags = 1)]
				public bool QueryAfterZeroResults() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Checks whether this searchable activity has auto URL detection turned on.</para> <para> <para>android.R.styleable::Searchable_autoUrlDetect </para></para>        
				/// </summary>
				/// <java-name>
				/// autoUrlDetect
				/// </java-name>
				[Dot42.DexImport("autoUrlDetect", "()Z", AccessFlags = 1)]
				public bool AutoUrlDetect() /* MethodBuilder.Create */ 
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
				public int DescribeContents() /* MethodBuilder.Create */ 
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
				public void WriteToParcel(global::Android.OS.Parcel dest, int flags) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Gets the search suggestion content provider authority.</para> <para> <para>android.R.styleable::Searchable_searchSuggestAuthority </para></para>        
				/// </summary>
				/// <returns>
				///  <para>The search suggestions authority, or <c>null </c> if not set. </para>
				/// </returns>
				/// <java-name>
				/// getSuggestAuthority
				/// </java-name>
				public string SuggestAuthority
				{
						[Dot42.DexImport("getSuggestAuthority", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>Gets the name of the package where the suggestion provider lives, or <c>null </c> . </para>        
				/// </summary>
				/// <java-name>
				/// getSuggestPackage
				/// </java-name>
				public string SuggestPackage
				{
						[Dot42.DexImport("getSuggestPackage", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>Gets the component name of the searchable activity.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>A component name, never <c>null </c> . </para>
				/// </returns>
				/// <java-name>
				/// getSearchActivity
				/// </java-name>
				public global::Android.Content.ComponentName SearchActivity
				{
						[Dot42.DexImport("getSearchActivity", "()Landroid/content/ComponentName;", AccessFlags = 1)]
						get{ return default(global::Android.Content.ComponentName); }
				}

				/// <summary>
				///  <para>Gets the resource id of the description string to use for this source in system search settings, or <c>0 </c> if none has been specified.</para> <para> <para>android.R.styleable::Searchable_searchSettingsDescription </para></para>        
				/// </summary>
				/// <java-name>
				/// getSettingsDescriptionId
				/// </java-name>
				public int SettingsDescriptionId
				{
						[Dot42.DexImport("getSettingsDescriptionId", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Gets the content provider path for obtaining search suggestions.</para> <para> <para>android.R.styleable::Searchable_searchSuggestPath </para></para>        
				/// </summary>
				/// <returns>
				///  <para>The suggestion path, or <c>null </c> if not set. </para>
				/// </returns>
				/// <java-name>
				/// getSuggestPath
				/// </java-name>
				public string SuggestPath
				{
						[Dot42.DexImport("getSuggestPath", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>Gets the selection for obtaining search suggestions.</para> <para> <para>android.R.styleable::Searchable_searchSuggestSelection </para></para>        
				/// </summary>
				/// <java-name>
				/// getSuggestSelection
				/// </java-name>
				public string SuggestSelection
				{
						[Dot42.DexImport("getSuggestSelection", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>Gets the optional intent action for use with these suggestions. This is useful if all intents will have the same action (e.g. android.content.Intent#ACTION_VIEW)</para> <para>This can be overriden in any given suggestion using the column SearchManager#SUGGEST_COLUMN_INTENT_ACTION.</para> <para> <para>android.R.styleable::Searchable_searchSuggestIntentAction </para></para>        
				/// </summary>
				/// <returns>
				///  <para>The default intent action, or <c>null </c> if not set. </para>
				/// </returns>
				/// <java-name>
				/// getSuggestIntentAction
				/// </java-name>
				public string SuggestIntentAction
				{
						[Dot42.DexImport("getSuggestIntentAction", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>Gets the optional intent data for use with these suggestions. This is useful if all intents will have similar data URIs, but you'll likely need to provide a specific ID as well via the column SearchManager#SUGGEST_COLUMN_INTENT_DATA_ID, which will be appended to the intent data URI.</para> <para>This can be overriden in any given suggestion using the column SearchManager#SUGGEST_COLUMN_INTENT_DATA.</para> <para> <para>android.R.styleable::Searchable_searchSuggestIntentData </para></para>        
				/// </summary>
				/// <returns>
				///  <para>The default intent data, or <c>null </c> if not set. </para>
				/// </returns>
				/// <java-name>
				/// getSuggestIntentData
				/// </java-name>
				public string SuggestIntentData
				{
						[Dot42.DexImport("getSuggestIntentData", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>Gets the suggestion threshold.</para> <para> <para>android.R.styleable::Searchable_searchSuggestThreshold </para></para>        
				/// </summary>
				/// <returns>
				///  <para>The suggestion threshold, or <c>0 </c> if not set. </para>
				/// </returns>
				/// <java-name>
				/// getSuggestThreshold
				/// </java-name>
				public int SuggestThreshold
				{
						[Dot42.DexImport("getSuggestThreshold", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Gets the resource id of the hint text. This must be read using the searchable Activity's resources.</para> <para> <para>android.R.styleable::Searchable_hint </para></para>        
				/// </summary>
				/// <returns>
				///  <para>A resource id, or <c>0 </c> if no hint was specified. </para>
				/// </returns>
				/// <java-name>
				/// getHintId
				/// </java-name>
				public int HintId
				{
						[Dot42.DexImport("getHintId", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Checks if the searchable activity wants the voice search button to be shown.</para> <para> <para>android.R.styleable::Searchable_voiceSearchMode </para></para>        
				/// </summary>
				/// <java-name>
				/// getVoiceSearchEnabled
				/// </java-name>
				public bool VoiceSearchEnabled
				{
						[Dot42.DexImport("getVoiceSearchEnabled", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Checks if voice search should start web search.</para> <para> <para>android.R.styleable::Searchable_voiceSearchMode </para></para>        
				/// </summary>
				/// <java-name>
				/// getVoiceSearchLaunchWebSearch
				/// </java-name>
				public bool VoiceSearchLaunchWebSearch
				{
						[Dot42.DexImport("getVoiceSearchLaunchWebSearch", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Checks if voice search should start in-app search.</para> <para> <para>android.R.styleable::Searchable_voiceSearchMode </para></para>        
				/// </summary>
				/// <java-name>
				/// getVoiceSearchLaunchRecognizer
				/// </java-name>
				public bool VoiceSearchLaunchRecognizer
				{
						[Dot42.DexImport("getVoiceSearchLaunchRecognizer", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Gets the resource id of the voice search language model string.</para> <para> <para>android.R.styleable::Searchable_voiceLanguageModel </para></para>        
				/// </summary>
				/// <returns>
				///  <para>A resource id, or <c>0 </c> if no language model was specified. </para>
				/// </returns>
				/// <java-name>
				/// getVoiceLanguageModeId
				/// </java-name>
				public int VoiceLanguageModeId
				{
						[Dot42.DexImport("getVoiceLanguageModeId", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Gets the resource id of the voice prompt text string.</para> <para> <para>android.R.styleable::Searchable_voicePromptText </para></para>        
				/// </summary>
				/// <returns>
				///  <para>A resource id, or <c>0 </c> if no voice prompt text was specified. </para>
				/// </returns>
				/// <java-name>
				/// getVoicePromptTextId
				/// </java-name>
				public int VoicePromptTextId
				{
						[Dot42.DexImport("getVoicePromptTextId", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Gets the resource id of the spoken language to recognize in voice search.</para> <para> <para>android.R.styleable::Searchable_voiceLanguage </para></para>        
				/// </summary>
				/// <returns>
				///  <para>A resource id, or <c>0 </c> if no language was specified. </para>
				/// </returns>
				/// <java-name>
				/// getVoiceLanguageId
				/// </java-name>
				public int VoiceLanguageId
				{
						[Dot42.DexImport("getVoiceLanguageId", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>The maximum number of voice recognition results to return.</para> <para> <para>android.R.styleable::Searchable_voiceMaxResults </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the max results count, if specified in the searchable activity's metadata, or <c>0 </c> if not specified. </para>
				/// </returns>
				/// <java-name>
				/// getVoiceMaxResults
				/// </java-name>
				public int VoiceMaxResults
				{
						[Dot42.DexImport("getVoiceMaxResults", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Gets the input type as specified in the searchable attributes. This will default to InputType#TYPE_CLASS_TEXT if not specified (which is appropriate for free text input).</para> <para> <para>android.R.styleable::Searchable_inputType </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the input type </para>
				/// </returns>
				/// <java-name>
				/// getInputType
				/// </java-name>
				public int InputType
				{
						[Dot42.DexImport("getInputType", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Gets the input method options specified in the searchable attributes. This will default to EditorInfo#IME_ACTION_GO if not specified (which is appropriate for a search box).</para> <para> <para>android.R.styleable::Searchable_imeOptions </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the input type </para>
				/// </returns>
				/// <java-name>
				/// getImeOptions
				/// </java-name>
				public int ImeOptions
				{
						[Dot42.DexImport("getImeOptions", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

		}

		/// <summary>
		///  <para>This class provides access to the system search services.</para> <para>In practice, you won't interact with this class directly, as search services are provided through methods in Activity and the ACTION_SEARCH Intent. If you do require direct access to the SearchManager, do not instantiate this class directly. Instead, retrieve it through context.getSystemService(Context.SEARCH_SERVICE).</para> <para>  <h3>Developer Guides</h3></para> <para> </para> <para>For more information about using the search dialog and adding search suggestions in your application, read the  developer guide.</para> <para>  </para>    
		/// </summary>
		/// <java-name>
		/// android/app/SearchManager
		/// </java-name>
		[Dot42.DexImport("android/app/SearchManager", AccessFlags = 33)]
		public partial class SearchManager : global::Android.Content.IDialogInterface_IOnDismissListener, global::Android.Content.IDialogInterface_IOnCancelListener
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>This is a shortcut definition for the default menu key to use for invoking search.</para> <para>See Menu.Item.setAlphabeticShortcut() for more information. </para>        
				/// </summary>
				/// <java-name>
				/// MENU_KEY
				/// </java-name>
				[Dot42.DexImport("MENU_KEY", "C", AccessFlags = 25)]
				public const char MENU_KEY = 's';
				/// <summary>
				///  <para>This is a shortcut definition for the default menu key to use for invoking search.</para> <para>See Menu.Item.setAlphabeticShortcut() for more information. </para>        
				/// </summary>
				/// <java-name>
				/// MENU_KEYCODE
				/// </java-name>
				[Dot42.DexImport("MENU_KEYCODE", "I", AccessFlags = 25)]
				public const int MENU_KEYCODE = 47;
				/// <summary>
				///  <para>Intent extra data key: Use this key with content.Intent.getStringExtra() to obtain the query string from Intent.ACTION_SEARCH. </para>        
				/// </summary>
				/// <java-name>
				/// QUERY
				/// </java-name>
				[Dot42.DexImport("QUERY", "Ljava/lang/String;", AccessFlags = 25)]
				public const string QUERY = "query";
				/// <summary>
				///  <para>Intent extra data key: Use this key with content.Intent.getStringExtra() to obtain the query string typed in by the user. This may be different from the value of QUERY if the intent is the result of selecting a suggestion. In that case, QUERY will contain the value of SUGGEST_COLUMN_QUERY for the suggestion, and USER_QUERY will contain the string typed by the user. </para>        
				/// </summary>
				/// <java-name>
				/// USER_QUERY
				/// </java-name>
				[Dot42.DexImport("USER_QUERY", "Ljava/lang/String;", AccessFlags = 25)]
				public const string USER_QUERY = "user_query";
				/// <summary>
				///  <para>Intent extra data key: Use this key with Intent.ACTION_SEARCH and content.Intent.getBundleExtra() to obtain any additional app-specific data that was inserted by the activity that launched the search. </para>        
				/// </summary>
				/// <java-name>
				/// APP_DATA
				/// </java-name>
				[Dot42.DexImport("APP_DATA", "Ljava/lang/String;", AccessFlags = 25)]
				public const string APP_DATA = "app_data";
				/// <summary>
				///  <para>Intent extra data key: Use this key with Intent.ACTION_SEARCH and content.Intent.getIntExtra() to obtain the keycode that the user used to trigger this query. It will be zero if the user simply pressed the "GO" button on the search UI. This is primarily used in conjunction with the keycode attribute in the actionkey element of your searchable.xml configuration file. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_KEY
				/// </java-name>
				[Dot42.DexImport("ACTION_KEY", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_KEY = "action_key";
				/// <summary>
				///  <para>Intent extra data key: This key will be used for the extra populated by the SUGGEST_COLUMN_INTENT_EXTRA_DATA column. </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_DATA_KEY
				/// </java-name>
				[Dot42.DexImport("EXTRA_DATA_KEY", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_DATA_KEY = "intent_extra_data_key";
				/// <summary>
				///  <para>Boolean extra data key for INTENT_ACTION_GLOBAL_SEARCH intents. If <c>true </c> , the initial query should be selected when the global search activity is started, so that the user can easily replace it with another query. </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_SELECT_QUERY
				/// </java-name>
				[Dot42.DexImport("EXTRA_SELECT_QUERY", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_SELECT_QUERY = "select_query";
				/// <summary>
				///  <para>Boolean extra data key for Intent#ACTION_WEB_SEARCH intents. If <c>true </c> , this search should open a new browser window, rather than using an existing one. </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_NEW_SEARCH
				/// </java-name>
				[Dot42.DexImport("EXTRA_NEW_SEARCH", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_NEW_SEARCH = "new_search";
				/// <summary>
				///  <para>Extra data key for Intent#ACTION_WEB_SEARCH. If set, the value must be a PendingIntent. The search activity handling the Intent#ACTION_WEB_SEARCH intent will fill in and launch the pending intent. The data URI will be filled in with an http or https URI, and android.provider.Browser#EXTRA_HEADERS may be filled in. </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_WEB_SEARCH_PENDINGINTENT
				/// </java-name>
				[Dot42.DexImport("EXTRA_WEB_SEARCH_PENDINGINTENT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_WEB_SEARCH_PENDINGINTENT = "web_search_pendingintent";
				/// <summary>
				///  <para>Boolean extra data key for a suggestion provider to return in Cursor#getExtras to indicate that the search is not complete yet. This can be used by the search UI to indicate that a search is in progress. The suggestion provider can return partial results this way and send a change notification on the cursor when more results are available. </para>        
				/// </summary>
				/// <java-name>
				/// CURSOR_EXTRA_KEY_IN_PROGRESS
				/// </java-name>
				[Dot42.DexImport("CURSOR_EXTRA_KEY_IN_PROGRESS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string CURSOR_EXTRA_KEY_IN_PROGRESS = "in_progress";
				/// <summary>
				///  <para>Intent extra data key: Use this key with Intent.ACTION_SEARCH and content.Intent.getStringExtra() to obtain the action message that was defined for a particular search action key and/or suggestion. It will be null if the search was launched by typing "enter", touched the the "GO" button, or other means not involving any action key. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_MSG
				/// </java-name>
				[Dot42.DexImport("ACTION_MSG", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_MSG = "action_msg";
				/// <summary>
				///  <para>Flag to specify that the entry can be used for query refinement, i.e., the query text in the search field can be replaced with the text in this entry, when a query refinement icon is clicked. The suggestion list should show such a clickable icon beside the entry. </para> <para>Use this flag as a bit-field for SUGGEST_COLUMN_FLAGS. </para>        
				/// </summary>
				/// <java-name>
				/// FLAG_QUERY_REFINEMENT
				/// </java-name>
				[Dot42.DexImport("FLAG_QUERY_REFINEMENT", "I", AccessFlags = 25)]
				public const int FLAG_QUERY_REFINEMENT = 1;
				/// <summary>
				///  <para>Uri path for queried suggestions data. This is the path that the search manager will use when querying your content provider for suggestions data based on user input (e.g. looking for partial matches). Typically you'll use this with a URI matcher. </para>        
				/// </summary>
				/// <java-name>
				/// SUGGEST_URI_PATH_QUERY
				/// </java-name>
				[Dot42.DexImport("SUGGEST_URI_PATH_QUERY", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SUGGEST_URI_PATH_QUERY = "search_suggest_query";
				/// <summary>
				///  <para>MIME type for suggestions data. You'll use this in your suggestions content provider in the getType() function. </para>        
				/// </summary>
				/// <java-name>
				/// SUGGEST_MIME_TYPE
				/// </java-name>
				[Dot42.DexImport("SUGGEST_MIME_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SUGGEST_MIME_TYPE = "vnd.android.cursor.dir/vnd.android.search.suggest";
				/// <summary>
				///  <para>Uri path for shortcut validation. This is the path that the search manager will use when querying your content provider to refresh a shortcutted suggestion result and to check if it is still valid. When asked, a source may return an up to date result, or no result. No result indicates the shortcut refers to a no longer valid sugggestion.</para> <para> <para>SUGGEST_COLUMN_SHORTCUT_ID </para></para>        
				/// </summary>
				/// <java-name>
				/// SUGGEST_URI_PATH_SHORTCUT
				/// </java-name>
				[Dot42.DexImport("SUGGEST_URI_PATH_SHORTCUT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SUGGEST_URI_PATH_SHORTCUT = "search_suggest_shortcut";
				/// <summary>
				///  <para>MIME type for shortcut validation. You'll use this in your suggestions content provider in the getType() function. </para>        
				/// </summary>
				/// <java-name>
				/// SHORTCUT_MIME_TYPE
				/// </java-name>
				[Dot42.DexImport("SHORTCUT_MIME_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SHORTCUT_MIME_TYPE = "vnd.android.cursor.item/vnd.android.search.suggest";
				/// <summary>
				///  <para>Column name for suggestions cursor.  <b>Unused - can be null or column can be omitted.</b> </para>        
				/// </summary>
				/// <java-name>
				/// SUGGEST_COLUMN_FORMAT
				/// </java-name>
				[Dot42.DexImport("SUGGEST_COLUMN_FORMAT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SUGGEST_COLUMN_FORMAT = "suggest_format";
				/// <summary>
				///  <para>Column name for suggestions cursor.  <b>Required.</b> This is the primary line of text that will be presented to the user as the suggestion. </para>        
				/// </summary>
				/// <java-name>
				/// SUGGEST_COLUMN_TEXT_1
				/// </java-name>
				[Dot42.DexImport("SUGGEST_COLUMN_TEXT_1", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SUGGEST_COLUMN_TEXT_1 = "suggest_text_1";
				/// <summary>
				///  <para>Column name for suggestions cursor.  <b>Optional.</b> If your cursor includes this column, then all suggestions will be provided in a two-line format. The second line of text is in a much smaller appearance. </para>        
				/// </summary>
				/// <java-name>
				/// SUGGEST_COLUMN_TEXT_2
				/// </java-name>
				[Dot42.DexImport("SUGGEST_COLUMN_TEXT_2", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SUGGEST_COLUMN_TEXT_2 = "suggest_text_2";
				/// <summary>
				///  <para>Column name for suggestions cursor.  <b>Optional.</b> This is a URL that will be shown as the second line of text instead of SUGGEST_COLUMN_TEXT_2. This is a separate column so that the search UI knows to display the text as a URL, e.g. by using a different color. If this column is absent, or has the value <c>null </c> , SUGGEST_COLUMN_TEXT_2 will be used instead. </para>        
				/// </summary>
				/// <java-name>
				/// SUGGEST_COLUMN_TEXT_2_URL
				/// </java-name>
				[Dot42.DexImport("SUGGEST_COLUMN_TEXT_2_URL", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SUGGEST_COLUMN_TEXT_2_URL = "suggest_text_2_url";
				/// <summary>
				///  <para>Column name for suggestions cursor.  <b>Optional.</b> If your cursor includes this column, then all suggestions will be provided in a format that includes space for two small icons, one at the left and one at the right of each suggestion. The data in the column must be a resource ID of a drawable, or a URI in one of the following formats:</para> <para> <ul> <li> <para>content (android.content.ContentResolver#SCHEME_CONTENT) </para></li> <li> <para>android.resource (android.content.ContentResolver#SCHEME_ANDROID_RESOURCE) </para></li> <li> <para>file (android.content.ContentResolver#SCHEME_FILE) </para></li></ul></para> <para>See android.content.ContentResolver#openAssetFileDescriptor(Uri, String) for more information on these schemes. </para>        
				/// </summary>
				/// <java-name>
				/// SUGGEST_COLUMN_ICON_1
				/// </java-name>
				[Dot42.DexImport("SUGGEST_COLUMN_ICON_1", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SUGGEST_COLUMN_ICON_1 = "suggest_icon_1";
				/// <summary>
				///  <para>Column name for suggestions cursor.  <b>Optional.</b> If your cursor includes this column, then all suggestions will be provided in a format that includes space for two small icons, one at the left and one at the right of each suggestion. The data in the column must be a resource ID of a drawable, or a URI in one of the following formats:</para> <para> <ul> <li> <para>content (android.content.ContentResolver#SCHEME_CONTENT) </para></li> <li> <para>android.resource (android.content.ContentResolver#SCHEME_ANDROID_RESOURCE) </para></li> <li> <para>file (android.content.ContentResolver#SCHEME_FILE) </para></li></ul></para> <para>See android.content.ContentResolver#openAssetFileDescriptor(Uri, String) for more information on these schemes. </para>        
				/// </summary>
				/// <java-name>
				/// SUGGEST_COLUMN_ICON_2
				/// </java-name>
				[Dot42.DexImport("SUGGEST_COLUMN_ICON_2", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SUGGEST_COLUMN_ICON_2 = "suggest_icon_2";
				/// <summary>
				///  <para>Column name for suggestions cursor.  <b>Optional.</b> If this column exists  <b>and</b> this element exists at the given row, this is the action that will be used when forming the suggestion's intent. If the element is not provided, the action will be taken from the android:searchSuggestIntentAction field in your XML metadata.  <b>At least one of these must be present for the suggestion to generate an intent.</b> Note: If your action is the same for all suggestions, it is more efficient to specify it using XML metadata and omit it from the cursor. </para>        
				/// </summary>
				/// <java-name>
				/// SUGGEST_COLUMN_INTENT_ACTION
				/// </java-name>
				[Dot42.DexImport("SUGGEST_COLUMN_INTENT_ACTION", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SUGGEST_COLUMN_INTENT_ACTION = "suggest_intent_action";
				/// <summary>
				///  <para>Column name for suggestions cursor.  <b>Optional.</b> If this column exists  <b>and</b> this element exists at the given row, this is the data that will be used when forming the suggestion's intent. If the element is not provided, the data will be taken from the android:searchSuggestIntentData field in your XML metadata. If neither source is provided, the Intent's data field will be null. Note: If your data is the same for all suggestions, or can be described using a constant part and a specific ID, it is more efficient to specify it using XML metadata and omit it from the cursor. </para>        
				/// </summary>
				/// <java-name>
				/// SUGGEST_COLUMN_INTENT_DATA
				/// </java-name>
				[Dot42.DexImport("SUGGEST_COLUMN_INTENT_DATA", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SUGGEST_COLUMN_INTENT_DATA = "suggest_intent_data";
				/// <summary>
				///  <para>Column name for suggestions cursor.  <b>Optional.</b> If this column exists  <b>and</b> this element exists at the given row, this is the data that will be used when forming the suggestion's intent. If not provided, the Intent's extra data field will be null. This column allows suggestions to provide additional arbitrary data which will be included as an extra under the key EXTRA_DATA_KEY. </para>        
				/// </summary>
				/// <java-name>
				/// SUGGEST_COLUMN_INTENT_EXTRA_DATA
				/// </java-name>
				[Dot42.DexImport("SUGGEST_COLUMN_INTENT_EXTRA_DATA", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SUGGEST_COLUMN_INTENT_EXTRA_DATA = "suggest_intent_extra_data";
				/// <summary>
				///  <para>Column name for suggestions cursor.  <b>Optional.</b> If this column exists  <b>and</b> this element exists at the given row, then "/" and this value will be appended to the data field in the Intent. This should only be used if the data field has already been set to an appropriate base string. </para>        
				/// </summary>
				/// <java-name>
				/// SUGGEST_COLUMN_INTENT_DATA_ID
				/// </java-name>
				[Dot42.DexImport("SUGGEST_COLUMN_INTENT_DATA_ID", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SUGGEST_COLUMN_INTENT_DATA_ID = "suggest_intent_data_id";
				/// <summary>
				///  <para>Column name for suggestions cursor.  <b>Required if action is ACTION_SEARCH, optional otherwise.</b> If this column exists  <b>and</b> this element exists at the given row, this is the data that will be used when forming the suggestion's query. </para>        
				/// </summary>
				/// <java-name>
				/// SUGGEST_COLUMN_QUERY
				/// </java-name>
				[Dot42.DexImport("SUGGEST_COLUMN_QUERY", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SUGGEST_COLUMN_QUERY = "suggest_intent_query";
				/// <summary>
				///  <para>Column name for suggestions cursor.  <b>Optional.</b> This column is used to indicate whether a search suggestion should be stored as a shortcut, and whether it should be refreshed. If missing, the result will be stored as a shortcut and never validated. If set to SUGGEST_NEVER_MAKE_SHORTCUT, the result will not be stored as a shortcut. Otherwise, the shortcut id will be used to check back for an up to date suggestion using SUGGEST_URI_PATH_SHORTCUT. </para>        
				/// </summary>
				/// <java-name>
				/// SUGGEST_COLUMN_SHORTCUT_ID
				/// </java-name>
				[Dot42.DexImport("SUGGEST_COLUMN_SHORTCUT_ID", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SUGGEST_COLUMN_SHORTCUT_ID = "suggest_shortcut_id";
				/// <summary>
				///  <para>Column name for suggestions cursor.  <b>Optional.</b> This column is used to specify that a spinner should be shown in lieu of an icon2 while the shortcut of this suggestion is being refreshed. </para>        
				/// </summary>
				/// <java-name>
				/// SUGGEST_COLUMN_SPINNER_WHILE_REFRESHING
				/// </java-name>
				[Dot42.DexImport("SUGGEST_COLUMN_SPINNER_WHILE_REFRESHING", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SUGGEST_COLUMN_SPINNER_WHILE_REFRESHING = "suggest_spinner_while_refreshing";
				/// <summary>
				///  <para>Column name for suggestions cursor.  <b>Optional.</b> This column is used to specify additional flags per item. Multiple flags can be specified. </para> <para>Must be one of FLAG_QUERY_REFINEMENT or 0 to indicate no flags. </para>        
				/// </summary>
				/// <java-name>
				/// SUGGEST_COLUMN_FLAGS
				/// </java-name>
				[Dot42.DexImport("SUGGEST_COLUMN_FLAGS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SUGGEST_COLUMN_FLAGS = "suggest_flags";
				/// <summary>
				///  <para>Column name for suggestions cursor.  <b>Optional.</b> This column may be used to specify the time in System.currentTImeMillis() (wall time in UTC) when an item was last accessed within the results-providing application. If set, this may be used to show more-recently-used items first. </para>        
				/// </summary>
				/// <java-name>
				/// SUGGEST_COLUMN_LAST_ACCESS_HINT
				/// </java-name>
				[Dot42.DexImport("SUGGEST_COLUMN_LAST_ACCESS_HINT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SUGGEST_COLUMN_LAST_ACCESS_HINT = "suggest_last_access_hint";
				/// <summary>
				///  <para>Column value for suggestion column SUGGEST_COLUMN_SHORTCUT_ID when a suggestion should not be stored as a shortcut in global search. </para>        
				/// </summary>
				/// <java-name>
				/// SUGGEST_NEVER_MAKE_SHORTCUT
				/// </java-name>
				[Dot42.DexImport("SUGGEST_NEVER_MAKE_SHORTCUT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SUGGEST_NEVER_MAKE_SHORTCUT = "_-1";
				/// <summary>
				///  <para>Query parameter added to suggestion queries to limit the number of suggestions returned. This limit is only advisory and suggestion providers may chose to ignore it. </para>        
				/// </summary>
				/// <java-name>
				/// SUGGEST_PARAMETER_LIMIT
				/// </java-name>
				[Dot42.DexImport("SUGGEST_PARAMETER_LIMIT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SUGGEST_PARAMETER_LIMIT = "limit";
				/// <summary>
				///  <para>Intent action for starting the global search activity. The global search provider should handle this intent.</para> <para>Supported extra data keys: QUERY, EXTRA_SELECT_QUERY, APP_DATA. </para>        
				/// </summary>
				/// <java-name>
				/// INTENT_ACTION_GLOBAL_SEARCH
				/// </java-name>
				[Dot42.DexImport("INTENT_ACTION_GLOBAL_SEARCH", "Ljava/lang/String;", AccessFlags = 25)]
				public const string INTENT_ACTION_GLOBAL_SEARCH = "android.search.action.GLOBAL_SEARCH";
				/// <summary>
				///  <para>Intent action for starting the global search settings activity. The global search provider should handle this intent. </para>        
				/// </summary>
				/// <java-name>
				/// INTENT_ACTION_SEARCH_SETTINGS
				/// </java-name>
				[Dot42.DexImport("INTENT_ACTION_SEARCH_SETTINGS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string INTENT_ACTION_SEARCH_SETTINGS = "android.search.action.SEARCH_SETTINGS";
				/// <summary>
				///  <para>Intent action for starting a web search provider's settings activity. Web search providers should handle this intent if they have provider-specific settings to implement. </para>        
				/// </summary>
				/// <java-name>
				/// INTENT_ACTION_WEB_SEARCH_SETTINGS
				/// </java-name>
				[Dot42.DexImport("INTENT_ACTION_WEB_SEARCH_SETTINGS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string INTENT_ACTION_WEB_SEARCH_SETTINGS = "android.search.action.WEB_SEARCH_SETTINGS";
				/// <summary>
				///  <para>Intent action broadcasted to inform that the searchables list or default have changed. Components should handle this intent if they cache any searchable data and wish to stay up to date on changes. </para>        
				/// </summary>
				/// <java-name>
				/// INTENT_ACTION_SEARCHABLES_CHANGED
				/// </java-name>
				[Dot42.DexImport("INTENT_ACTION_SEARCHABLES_CHANGED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string INTENT_ACTION_SEARCHABLES_CHANGED = "android.search.action.SEARCHABLES_CHANGED";
				/// <summary>
				///  <para>Intent action to be broadcast to inform that the global search provider has changed. </para>        
				/// </summary>
				/// <java-name>
				/// INTENT_GLOBAL_SEARCH_ACTIVITY_CHANGED
				/// </java-name>
				[Dot42.DexImport("INTENT_GLOBAL_SEARCH_ACTIVITY_CHANGED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string INTENT_GLOBAL_SEARCH_ACTIVITY_CHANGED = "android.search.action.GLOBAL_SEARCH_ACTIVITY_CHANGED";
				/// <summary>
				///  <para>Intent action broadcasted to inform that the search settings have changed in some way. Either searchables have been enabled or disabled, or a different web search provider has been chosen. </para>        
				/// </summary>
				/// <java-name>
				/// INTENT_ACTION_SEARCH_SETTINGS_CHANGED
				/// </java-name>
				[Dot42.DexImport("INTENT_ACTION_SEARCH_SETTINGS_CHANGED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string INTENT_ACTION_SEARCH_SETTINGS_CHANGED = "android.search.action.SETTINGS_CHANGED";
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal SearchManager() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Launch search UI.</para> <para>The search manager will open a search widget in an overlapping window, and the underlying activity may be obscured. The search entry state will remain in effect until one of the following events:  <ul> <li> <para>The user completes the search. In most cases this will launch a search intent. </para></li> <li> <para>The user uses the back, home, or other keys to exit the search. </para></li> <li> <para>The application calls the stopSearch method, which will hide the search window and return focus to the activity from which it was launched.</para> <para></para> <para>Most applications will  <b>not</b> use this interface to invoke search. The primary method for invoking search is to call Activity.onSearchRequested() or Activity.startSearch().</para> <para> <para>android.app.Activity::onSearchRequested </para> <para>stopSearch </para></para></li></ul></para>        
				/// </summary>
				/// <java-name>
				/// startSearch
				/// </java-name>
				[Dot42.DexImport("startSearch", "(Ljava/lang/String;ZLandroid/content/ComponentName;Landroid/os/Bundle;Z)V", AccessFlags = 1)]
				public virtual void StartSearch(string initialQuery, bool selectInitialQuery, global::Android.Content.ComponentName launchActivity, global::Android.OS.Bundle appSearchData, bool globalSearch) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Similar to startSearch but actually fires off the search query after invoking the search dialog. Made available for testing purposes.</para> <para> <para>startSearch </para></para>        
				/// </summary>
				/// <java-name>
				/// triggerSearch
				/// </java-name>
				[Dot42.DexImport("triggerSearch", "(Ljava/lang/String;Landroid/content/ComponentName;Landroid/os/Bundle;)V", AccessFlags = 1)]
				public virtual void TriggerSearch(string query, global::Android.Content.ComponentName launchActivity, global::Android.OS.Bundle appSearchData) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Terminate search UI.</para> <para>Typically the user will terminate the search UI by launching a search or by canceling. This function allows the underlying application or activity to cancel the search prematurely (for any reason).</para> <para>This function can be safely called at any time (even if no search is active.)</para> <para> <para>startSearch </para></para>        
				/// </summary>
				/// <java-name>
				/// stopSearch
				/// </java-name>
				[Dot42.DexImport("stopSearch", "()V", AccessFlags = 1)]
				public virtual void StopSearch() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Set or clear the callback that will be invoked whenever the search UI is dismissed.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setOnDismissListener
				/// </java-name>
				[Dot42.DexImport("setOnDismissListener", "(Landroid/app/SearchManager$OnDismissListener;)V", AccessFlags = 1)]
				public virtual void SetOnDismissListener(global::Android.App.SearchManager.IOnDismissListener listener) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Set or clear the callback that will be invoked whenever the search UI is canceled.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setOnCancelListener
				/// </java-name>
				[Dot42.DexImport("setOnCancelListener", "(Landroid/app/SearchManager$OnCancelListener;)V", AccessFlags = 1)]
				public virtual void SetOnCancelListener(global::Android.App.SearchManager.IOnCancelListener listener) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>This method is an obsolete internal implementation detail. Do not use. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// onCancel
				/// </java-name>
				[Dot42.DexImport("onCancel", "(Landroid/content/DialogInterface;)V", AccessFlags = 1)]
				public virtual void OnCancel(global::Android.Content.IDialogInterface dialog) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>This method is an obsolete internal implementation detail. Do not use. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// onDismiss
				/// </java-name>
				[Dot42.DexImport("onDismiss", "(Landroid/content/DialogInterface;)V", AccessFlags = 1)]
				public virtual void OnDismiss(global::Android.Content.IDialogInterface dialog) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Gets information about a searchable activity.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Searchable information, or  <code>null</code> if the activity does not exist, or is not searchable. </para>
				/// </returns>
				/// <java-name>
				/// getSearchableInfo
				/// </java-name>
				[Dot42.DexImport("getSearchableInfo", "(Landroid/content/ComponentName;)Landroid/app/SearchableInfo;", AccessFlags = 1)]
				public virtual global::Android.App.SearchableInfo GetSearchableInfo(global::Android.Content.ComponentName componentName) /* MethodBuilder.Create */ 
				{
						return default(global::Android.App.SearchableInfo);
				}

				/// <summary>
				///  <para>Gets the name of the global search activity. </para>        
				/// </summary>
				/// <java-name>
				/// getGlobalSearchActivity
				/// </java-name>
				public virtual global::Android.Content.ComponentName GlobalSearchActivity
				{
						[Dot42.DexImport("getGlobalSearchActivity", "()Landroid/content/ComponentName;", AccessFlags = 1)]
						get{ return default(global::Android.Content.ComponentName); }
				}

				/// <summary>
				///  <para>Returns a list of the searchable activities that can be included in global search.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a list containing searchable information for all searchable activities that have the  <code>android:includeInGlobalSearch</code> attribute set in their searchable meta-data. </para>
				/// </returns>
				/// <java-name>
				/// getSearchablesInGlobalSearch
				/// </java-name>
				public virtual global::Java.Util.IList<global::Android.App.SearchableInfo> SearchablesInGlobalSearch
				{
						[Dot42.DexImport("getSearchablesInGlobalSearch", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Landroid/app/SearchableInfo;>;")]
						get{ return default(global::Java.Util.IList<global::Android.App.SearchableInfo>); }
				}

				/// <summary>
				///  <para>See SearchManager#setOnCancelListener for configuring your activity to monitor search UI state. </para>    
				/// </summary>
				/// <java-name>
				/// android/app/SearchManager$OnCancelListener
				/// </java-name>
				[Dot42.DexImport("android/app/SearchManager$OnCancelListener", AccessFlags = 1545)]
				public partial interface IOnCancelListener
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>This method will be called when the search UI is canceled. To make use if it, you must implement this method in your activity, and call SearchManager#setOnCancelListener to register it. </para>        
						/// </summary>
						/// <java-name>
						/// onCancel
						/// </java-name>
						[Dot42.DexImport("onCancel", "()V", AccessFlags = 1025)]
						void OnCancel() /* MethodBuilder.Create */ ;

				}

				/// <summary>
				///  <para>See SearchManager#setOnDismissListener for configuring your activity to monitor search UI state. </para>    
				/// </summary>
				/// <java-name>
				/// android/app/SearchManager$OnDismissListener
				/// </java-name>
				[Dot42.DexImport("android/app/SearchManager$OnDismissListener", AccessFlags = 1545)]
				public partial interface IOnDismissListener
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>This method will be called when the search UI is dismissed. To make use of it, you must implement this method in your activity, and call SearchManager#setOnDismissListener to register it. </para>        
						/// </summary>
						/// <java-name>
						/// onDismiss
						/// </java-name>
						[Dot42.DexImport("onDismiss", "()V", AccessFlags = 1025)]
						void OnDismiss() /* MethodBuilder.Create */ ;

				}

		}

		/// <summary>
		///  <para>A Service is an application component representing either an application's desire to perform a longer-running operation while not interacting with the user or to supply functionality for other applications to use. Each service class must have a corresponding &lt;service&gt; declaration in its package's  <code>AndroidManifest.xml</code>. Services can be started with Context.startService() and Context.bindService().</para> <para>Note that services, like other application objects, run in the main thread of their hosting process. This means that, if your service is going to do any CPU intensive (such as MP3 playback) or blocking (such as networking) operations, it should spawn its own thread in which to do that work. More information on this can be found in . The IntentService class is available as a standard implementation of Service that has its own thread where it schedules its work to be done.</para> <para>Topics covered here:  <ol> <li> <para> </para></li> <li> <para> </para></li> <li> <para> </para></li> <li> <para> </para></li> <li> <para> </para></li> <li> <para> </para></li></ol></para> <para>  <h3>Developer Guides</h3></para> <para> </para> <para>For a detailed discussion about how to create services, read the  developer guide.</para> <para> </para> <para>  <h3>What is a Service?</h3></para> <para>Most confusion about the Service class actually revolves around what it is  <b>not</b>:</para> <para> <ul> <li> <para>A Service is  <b>not</b> a separate process. The Service object itself does not imply it is running in its own process; unless otherwise specified, it runs in the same process as the application it is part of. </para></li> <li> <para>A Service is  <b>not</b> a thread. It is not a means itself to do work off of the main thread (to avoid Application Not Responding errors). </para></li></ul></para> <para>Thus a Service itself is actually very simple, providing two main features:</para> <para> <ul> <li> <para>A facility for the application to tell the system  <b>about</b> something it wants to be doing in the background (even when the user is not directly interacting with the application). This corresponds to calls to Context.startService(), which ask the system to schedule work for the service, to be run until the service or someone else explicitly stop it. </para></li> <li> <para>A facility for an application to expose some of its functionality to other applications. This corresponds to calls to Context.bindService(), which allows a long-standing connection to be made to the service in order to interact with it. </para></li></ul></para> <para>When a Service component is actually created, for either of these reasons, all that the system actually does is instantiate the component and call its onCreate and any other appropriate callbacks on the main thread. It is up to the Service to implement these with the appropriate behavior, such as creating a secondary thread in which it does its work.</para> <para>Note that because Service itself is so simple, you can make your interaction with it as simple or complicated as you want: from treating it as a local Java object that you make direct method calls on (as illustrated by ), to providing a full remoteable interface using AIDL.</para> <para>  <h3>Service Lifecycle</h3></para> <para>There are two reasons that a service can be run by the system. If someone calls Context.startService() then the system will retrieve the service (creating it and calling its onCreate method if needed) and then call its onStartCommand method with the arguments supplied by the client. The service will at this point continue running until Context.stopService() or stopSelf() is called. Note that multiple calls to Context.startService() do not nest (though they do result in multiple corresponding calls to onStartCommand()), so no matter how many times it is started a service will be stopped once Context.stopService() or stopSelf() is called; however, services can use their stopSelf(int) method to ensure the service is not stopped until started intents have been processed.</para> <para>For started services, there are two additional major modes of operation they can decide to run in, depending on the value they return from onStartCommand(): START_STICKY is used for services that are explicitly started and stopped as needed, while START_NOT_STICKY or START_REDELIVER_INTENT are used for services that should only remain running while processing any commands sent to them. See the linked documentation for more detail on the semantics.</para> <para>Clients can also use Context.bindService() to obtain a persistent connection to a service. This likewise creates the service if it is not already running (calling onCreate while doing so), but does not call onStartCommand(). The client will receive the android.os.IBinder object that the service returns from its onBind method, allowing the client to then make calls back to the service. The service will remain running as long as the connection is established (whether or not the client retains a reference on the service's IBinder). Usually the IBinder returned is for a complex interface that has been .</para> <para>A service can be both started and have connections bound to it. In such a case, the system will keep the service running as long as either it is started  <b>or</b> there are one or more connections to it with the Context.BIND_AUTO_CREATE flag. Once neither of these situations hold, the service's onDestroy method is called and the service is effectively terminated. All cleanup (stopping threads, unregistering receivers) should be complete upon returning from onDestroy().</para> <para>  <h3>Permissions</h3></para> <para>Global access to a service can be enforced when it is declared in its manifest's &lt;service&gt; tag. By doing so, other applications will need to declare a corresponding &lt;uses-permission&gt; element in their own manifest to be able to start, stop, or bind to the service.</para> <para>As of android.os.Build.VERSION_CODES#GINGERBREAD, when using Context.startService(Intent), you can also set Intent.FLAG_GRANT_READ_URI_PERMISSION and/or Intent.FLAG_GRANT_WRITE_URI_PERMISSION on the Intent. This will grant the Service temporary access to the specific URIs in the Intent. Access will remain until the Service has called stopSelf(int) for that start command or a later one, or until the Service has been completely stopped. This works for granting access to the other apps that have not requested the permission protecting the Service, or even when the Service is not exported at all.</para> <para>In addition, a service can protect individual IPC calls into it with permissions, by calling the checkCallingPermission method before executing the implementation of that call.</para> <para>See the  document for more information on permissions and security in general.</para> <para>  <h3>Process Lifecycle</h3></para> <para>The Android system will attempt to keep the process hosting a service around as long as the service has been started or has clients bound to it. When running low on memory and needing to kill existing processes, the priority of a process hosting the service will be the higher of the following possibilities:</para> <para> <ul> <li> <para></para> <para>If the service is currently executing code in its onCreate(), onStartCommand(), or onDestroy() methods, then the hosting process will be a foreground process to ensure this code can execute without being killed. </para></li> <li> <para></para> <para>If the service has been started, then its hosting process is considered to be less important than any processes that are currently visible to the user on-screen, but more important than any process not visible. Because only a few processes are generally visible to the user, this means that the service should not be killed except in extreme low memory conditions. </para></li> <li> <para></para> <para>If there are clients bound to the service, then the service's hosting process is never less important than the most important client. That is, if one of its clients is visible to the user, then the service itself is considered to be visible. </para></li> <li> <para></para> <para>A started service can use the startForeground(int, Notification) API to put the service in a foreground state, where the system considers it to be something the user is actively aware of and thus not a candidate for killing when low on memory. (It is still theoretically possible for the service to be killed under extreme memory pressure from the current foreground application, but in practice this should not be a concern.) </para></li></ul></para> <para>Note this means that most of the time your service is running, it may be killed by the system if it is under heavy memory pressure. If this happens, the system will later try to restart the service. An important consequence of this is that if you implement onStartCommand() to schedule work to be done asynchronously or in another thread, then you may want to use START_FLAG_REDELIVERY to have the system re-deliver an Intent for you so that it does not get lost if your service is killed while processing it.</para> <para>Other application components running in the same process as the service (such as an android.app.Activity) can, of course, increase the importance of the overall process beyond just the importance of the service itself.</para> <para>  <h3>Local Service Sample</h3></para> <para>One of the most common uses of a Service is as a secondary component running alongside other parts of an application, in the same process as the rest of the components. All components of an .apk run in the same process unless explicitly stated otherwise, so this is a typical situation.</para> <para>When used in this way, by assuming the components are in the same process, you can greatly simplify the interaction between them: clients of the service can simply cast the IBinder they receive from it to a concrete class published by the service.</para> <para>An example of this use of a Service is shown here. First is the Service itself, publishing a custom class when bound:</para> <para>{ development/samples/ApiDemos/src/com/example/android/apis/app/LocalService.java service}</para> <para>With that done, one can now write client code that directly accesses the running service, such as:</para> <para>{ development/samples/ApiDemos/src/com/example/android/apis/app/LocalServiceActivities.java bind}</para> <para>  <h3>Remote Messenger Service Sample</h3></para> <para>If you need to be able to write a Service that can perform complicated communication with clients in remote processes (beyond simply the use of Context.startService to send commands to it), then you can use the android.os.Messenger class instead of writing full AIDL files.</para> <para>An example of a Service that uses Messenger as its client interface is shown here. First is the Service itself, publishing a Messenger to an internal Handler when bound:</para> <para>{ development/samples/ApiDemos/src/com/example/android/apis/app/MessengerService.java service}</para> <para>If we want to make this service run in a remote process (instead of the standard one for its .apk), we can use  <code>android:process</code> in its manifest tag to specify one:</para> <para>{ development/samples/ApiDemos/AndroidManifest.xml remote_service_declaration}</para> <para>Note that the name "remote" chosen here is arbitrary, and you can use other names if you want additional processes. The ':' prefix appends the name to your package's standard process name.</para> <para>With that done, clients can now bind to the service and send messages to it. Note that this allows clients to register with it to receive messages back as well:</para> <para>{ development/samples/ApiDemos/src/com/example/android/apis/app/MessengerServiceActivities.java bind} </para>    
		/// </summary>
		/// <java-name>
		/// android/app/Service
		/// </java-name>
		[Dot42.DexImport("android/app/Service", AccessFlags = 1057)]
		public abstract partial class Service : global::Android.Content.ContextWrapper, global::Android.Content.IComponentCallbacks2
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Bits returned by onStartCommand describing how to continue the service if it is killed. May be START_STICKY, START_NOT_STICKY, START_REDELIVER_INTENT, or START_STICKY_COMPATIBILITY. </para>        
				/// </summary>
				/// <java-name>
				/// START_CONTINUATION_MASK
				/// </java-name>
				[Dot42.DexImport("START_CONTINUATION_MASK", "I", AccessFlags = 25)]
				public const int START_CONTINUATION_MASK = 15;
				/// <summary>
				///  <para>Constant to return from onStartCommand: compatibility version of START_STICKY that does not guarantee that onStartCommand will be called again after being killed. </para>        
				/// </summary>
				/// <java-name>
				/// START_STICKY_COMPATIBILITY
				/// </java-name>
				[Dot42.DexImport("START_STICKY_COMPATIBILITY", "I", AccessFlags = 25)]
				public const int START_STICKY_COMPATIBILITY = 0;
				/// <summary>
				///  <para>Constant to return from onStartCommand: if this service's process is killed while it is started (after returning from onStartCommand), then leave it in the started state but don't retain this delivered intent. Later the system will try to re-create the service. Because it is in the started state, it will guarantee to call onStartCommand after creating the new service instance; if there are not any pending start commands to be delivered to the service, it will be called with a null intent object, so you must take care to check for this.</para> <para>This mode makes sense for things that will be explicitly started and stopped to run for arbitrary periods of time, such as a service performing background music playback. </para>        
				/// </summary>
				/// <java-name>
				/// START_STICKY
				/// </java-name>
				[Dot42.DexImport("START_STICKY", "I", AccessFlags = 25)]
				public const int START_STICKY = 1;
				/// <summary>
				///  <para>Constant to return from onStartCommand: if this service's process is killed while it is started (after returning from onStartCommand), and there are no new start intents to deliver to it, then take the service out of the started state and don't recreate until a future explicit call to Context.startService(Intent). The service will not receive a onStartCommand(Intent, int, int) call with a null Intent because it will not be re-started if there are no pending Intents to deliver.</para> <para>This mode makes sense for things that want to do some work as a result of being started, but can be stopped when under memory pressure and will explicit start themselves again later to do more work. An example of such a service would be one that polls for data from a server: it could schedule an alarm to poll every N minutes by having the alarm start its service. When its onStartCommand is called from the alarm, it schedules a new alarm for N minutes later, and spawns a thread to do its networking. If its process is killed while doing that check, the service will not be restarted until the alarm goes off. </para>        
				/// </summary>
				/// <java-name>
				/// START_NOT_STICKY
				/// </java-name>
				[Dot42.DexImport("START_NOT_STICKY", "I", AccessFlags = 25)]
				public const int START_NOT_STICKY = 2;
				/// <summary>
				///  <para>Constant to return from onStartCommand: if this service's process is killed while it is started (after returning from onStartCommand), then it will be scheduled for a restart and the last delivered Intent re-delivered to it again via onStartCommand. This Intent will remain scheduled for redelivery until the service calls stopSelf(int) with the start ID provided to onStartCommand. The service will not receive a onStartCommand(Intent, int, int) call with a null Intent because it will will only be re-started if it is not finished processing all Intents sent to it (and any such pending events will be delivered at the point of restart). </para>        
				/// </summary>
				/// <java-name>
				/// START_REDELIVER_INTENT
				/// </java-name>
				[Dot42.DexImport("START_REDELIVER_INTENT", "I", AccessFlags = 25)]
				public const int START_REDELIVER_INTENT = 3;
				/// <summary>
				///  <para>This flag is set in onStartCommand if the Intent is a re-delivery of a previously delivered intent, because the service had previously returned START_REDELIVER_INTENT but had been killed before calling stopSelf(int) for that Intent. </para>        
				/// </summary>
				/// <java-name>
				/// START_FLAG_REDELIVERY
				/// </java-name>
				[Dot42.DexImport("START_FLAG_REDELIVERY", "I", AccessFlags = 25)]
				public const int START_FLAG_REDELIVERY = 1;
				/// <summary>
				///  <para>This flag is set in onStartCommand if the Intent is a a retry because the original attempt never got to or returned from onStartCommand(Intent, int, int). </para>        
				/// </summary>
				/// <java-name>
				/// START_FLAG_RETRY
				/// </java-name>
				[Dot42.DexImport("START_FLAG_RETRY", "I", AccessFlags = 25)]
				public const int START_FLAG_RETRY = 2;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Service() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Called by the system when the service is first created. Do not call this method directly. </para>        
				/// </summary>
				/// <java-name>
				/// onCreate
				/// </java-name>
				[Dot42.DexImport("onCreate", "()V", AccessFlags = 1)]
				public virtual void OnCreate() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Implement onStartCommand(Intent, int, int) instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// onStart
				/// </java-name>
				[Dot42.DexImport("onStart", "(Landroid/content/Intent;I)V", AccessFlags = 1)]
				public virtual void OnStart(global::Android.Content.Intent intent, int startId) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Called by the system every time a client explicitly starts the service by calling android.content.Context#startService, providing the arguments it supplied and a unique integer token representing the start request. Do not call this method directly.</para> <para>For backwards compatibility, the default implementation calls onStart and returns either START_STICKY or START_STICKY_COMPATIBILITY.</para> <para>If you need your application to run on platform versions prior to API level 5, you can use the following model to handle the older onStart callback in that case. The  <code>handleCommand</code> method is implemented by you as appropriate:</para> <para>{ development/samples/ApiDemos/src/com/example/android/apis/app/ForegroundService.java start_compatibility}</para> <para>Note that the system calls this on your service's main thread. A service's main thread is the same thread where UI operations take place for Activities running in the same process. You should always avoid stalling the main thread's event loop. When doing long-running operations, network calls, or heavy disk I/O, you should kick off a new thread, or use android.os.AsyncTask.</para> <para> <para>stopSelfResult(int) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>The return value indicates what semantics the system should use for the service's current started state. It may be one of the constants associated with the START_CONTINUATION_MASK bits.</para>
				/// </returns>
				/// <java-name>
				/// onStartCommand
				/// </java-name>
				[Dot42.DexImport("onStartCommand", "(Landroid/content/Intent;II)I", AccessFlags = 1)]
				public virtual int OnStartCommand(global::Android.Content.Intent intent, int flags, int startId) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Called by the system to notify a Service that it is no longer used and is being removed. The service should clean up any resources it holds (threads, registered receivers, etc) at this point. Upon return, there will be no more calls in to this Service object and it is effectively dead. Do not call this method directly. </para>        
				/// </summary>
				/// <java-name>
				/// onDestroy
				/// </java-name>
				[Dot42.DexImport("onDestroy", "()V", AccessFlags = 1)]
				public virtual void OnDestroy() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Called by the system when the device configuration changes while your component is running. Note that, unlike activities, other components are never restarted when a configuration changes: they must always deal with the results of the change, such as by re-retrieving resources.</para> <para>At the time that this function has been called, your Resources object will have been updated to return resource values matching the new configuration.</para> <para>For more information, read .</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// onConfigurationChanged
				/// </java-name>
				[Dot42.DexImport("onConfigurationChanged", "(Landroid/content/res/Configuration;)V", AccessFlags = 1)]
				public virtual void OnConfigurationChanged(global::Android.Content.Res.Configuration newConfig) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>This is called when the overall system is running low on memory, and actively running processes should trim their memory usage. While the exact point at which this will be called is not defined, generally it will happen when all background process have been killed. That is, before reaching the point of killing processes hosting service and foreground UI that we would like to avoid killing.</para> <para>You should implement this method to release any caches or other unnecessary resources you may be holding on to. The system will perform a garbage collection for you after returning from this method. </para> <para>Preferably, you should implement ComponentCallbacks2#onTrimMemory from ComponentCallbacks2 to incrementally unload your resources based on various levels of memory demands. That API is available for API level 14 and higher, so you should only use this onLowMemory method as a fallback for older versions, which can be treated the same as ComponentCallbacks2#onTrimMemory with the ComponentCallbacks2#TRIM_MEMORY_COMPLETE level.</para>        
				/// </summary>
				/// <java-name>
				/// onLowMemory
				/// </java-name>
				[Dot42.DexImport("onLowMemory", "()V", AccessFlags = 1)]
				public virtual void OnLowMemory() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Called when the operating system has determined that it is a good time for a process to trim unneeded memory from its process. This will happen for example when it goes in the background and there is not enough memory to keep as many background processes running as desired. You should never compare to exact values of the level, since new intermediate values may be added  you will typically want to compare if the value is greater or equal to a level you are interested in.</para> <para>To retrieve the processes current trim level at any point, you can use ActivityManager.getMyMemoryState(RunningAppProcessInfo).</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// onTrimMemory
				/// </java-name>
				[Dot42.DexImport("onTrimMemory", "(I)V", AccessFlags = 1)]
				public virtual void OnTrimMemory(int level) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Return the communication channel to the service. May return null if clients can not bind to the service. The returned android.os.IBinder is usually for a complex interface that has been .</para> <para> <b>Note that unlike other application components, calls on to the IBinder interface returned here may not happen on the main thread of the process</b>. More information about the main thread can be found in .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Return an IBinder through which clients can call on to the service. </para>
				/// </returns>
				/// <java-name>
				/// onBind
				/// </java-name>
				[Dot42.DexImport("onBind", "(Landroid/content/Intent;)Landroid/os/IBinder;", AccessFlags = 1025)]
				public abstract global::Android.OS.IBinder OnBind(global::Android.Content.Intent intent) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Called when all clients have disconnected from a particular interface published by the service. The default implementation does nothing and returns false.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Return true if you would like to have the service's onRebind method later called when new clients bind to it. </para>
				/// </returns>
				/// <java-name>
				/// onUnbind
				/// </java-name>
				[Dot42.DexImport("onUnbind", "(Landroid/content/Intent;)Z", AccessFlags = 1)]
				public virtual bool OnUnbind(global::Android.Content.Intent intent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Called when new clients have connected to the service, after it had previously been notified that all had disconnected in its onUnbind. This will only be called if the implementation of onUnbind was overridden to return true.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// onRebind
				/// </java-name>
				[Dot42.DexImport("onRebind", "(Landroid/content/Intent;)V", AccessFlags = 1)]
				public virtual void OnRebind(global::Android.Content.Intent intent) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>This is called if the service is currently running and the user has removed a task that comes from the service's application. If you have set ServiceInfo.FLAG_STOP_WITH_TASK then you will not receive this callback; instead, the service will simply be stopped.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// onTaskRemoved
				/// </java-name>
				[Dot42.DexImport("onTaskRemoved", "(Landroid/content/Intent;)V", AccessFlags = 1)]
				public virtual void OnTaskRemoved(global::Android.Content.Intent rootIntent) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Stop the service, if it was previously started. This is the same as calling android.content.Context#stopService for this particular service.</para> <para> <para>stopSelfResult(int) </para></para>        
				/// </summary>
				/// <java-name>
				/// stopSelf
				/// </java-name>
				[Dot42.DexImport("stopSelf", "()V", AccessFlags = 17)]
				public void StopSelf() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Old version of stopSelfResult that doesn't return a result.</para> <para> <para>stopSelfResult </para></para>        
				/// </summary>
				/// <java-name>
				/// stopSelf
				/// </java-name>
				[Dot42.DexImport("stopSelf", "(I)V", AccessFlags = 17)]
				public void StopSelf(int startId) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Stop the service if the most recent time it was started was  <b>startId</b>. This is the same as calling android.content.Context#stopService for this particular service but allows you to safely avoid stopping if there is a start request from a client that you haven't yet seen in onStart.</para> <para> <b>Be careful about ordering of your calls to this function.</b>. If you call this function with the most-recently received ID before you have called it for previously received IDs, the service will be immediately stopped anyway. If you may end up processing IDs out of order (such as by dispatching them on separate threads), then you are responsible for stopping them in the same order you received them.</para> <para> <para>stopSelf() </para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns true if the startId matches the last start request and the service will be stopped, else false.</para>
				/// </returns>
				/// <java-name>
				/// stopSelfResult
				/// </java-name>
				[Dot42.DexImport("stopSelfResult", "(I)Z", AccessFlags = 17)]
				public bool StopSelfResult(int startId) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Make this service run in the foreground, supplying the ongoing notification to be shown to the user while in this state. By default services are background, meaning that if the system needs to kill them to reclaim more memory (such as to display a large page in a web browser), they can be killed without too much harm. You can set this flag if killing your service would be disruptive to the user, such as if your service is performing background music playback, so the user would notice if their music stopped playing.</para> <para>If you need your application to run on platform versions prior to API level 5, you can use the following model to call the the older setForeground() or this modern method as appropriate:</para> <para>{ development/samples/ApiDemos/src/com/example/android/apis/app/ForegroundService.java foreground_compatibility}</para> <para> <para>stopForeground(boolean) </para></para>        
				/// </summary>
				/// <java-name>
				/// startForeground
				/// </java-name>
				[Dot42.DexImport("startForeground", "(ILandroid/app/Notification;)V", AccessFlags = 17)]
				public void StartForeground(int id, global::Android.App.Notification notification) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Remove this service from foreground state, allowing it to be killed if more memory is needed.  <para>startForeground(int, Notification) </para></para>        
				/// </summary>
				/// <java-name>
				/// stopForeground
				/// </java-name>
				[Dot42.DexImport("stopForeground", "(Z)V", AccessFlags = 17)]
				public void StopForeground(bool removeNotification) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Print the Service's state into the given stream. This gets invoked if you run "adb shell dumpsys activity service &amp;lt;yourservicename&amp;gt;" (note that for this command to work, the service must be running, and you must specify a fully-qualified service name). This is distinct from "dumpsys &amp;lt;servicename&amp;gt;", which only works for named system services and which invokes the IBinder#dump method on the IBinder interface registered with ServiceManager.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// dump
				/// </java-name>
				[Dot42.DexImport("dump", "(Ljava/io/FileDescriptor;Ljava/io/PrintWriter;[Ljava/lang/String;)V", AccessFlags = 4)]
				protected internal virtual void Dump(global::Java.IO.FileDescriptor fd, global::Java.IO.PrintWriter writer, string[] args) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Return the application that owns this service. </para>        
				/// </summary>
				/// <java-name>
				/// getApplication
				/// </java-name>
				public global::Android.App.Application Application
				{
						[Dot42.DexImport("getApplication", "()Landroid/app/Application;", AccessFlags = 17)]
						get{ return default(global::Android.App.Application); }
				}

		}

		/// <summary>
		///  <para>For apps developing against android.os.Build.VERSION_CODES#HONEYCOMB or later, tabs are typically presented in the UI using the new ActionBar.newTab() and related APIs for placing tabs within their action bar area.</para> <para>A replacement for TabActivity can also be implemented by directly using TabHost. You will need to define a layout that correctly uses a TabHost with a TabWidget as well as an area in which to display your tab content. A typical example would be:</para> <para>{ development/samples/Support4Demos/res/layout/fragment_tabs.xml complete}</para> <para>The implementation needs to take over responsibility for switching the shown content when the user switches between tabs.</para> <para>{ development/samples/Support4Demos/src/com/example/android/supportv4/app/FragmentTabs.java complete}</para> <para>Also see the  sample for an example of using the support library's ViewPager to allow the user to swipe the content to switch between tabs.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>New applications should use Fragments instead of this class; to continue to run on older devices, you can use the v4 support library which provides a version of the Fragment API that is compatible down to android.os.Build.VERSION_CODES#DONUT. </para></xrefdescription></xrefsect></para>    
		/// </summary>
		/// <java-name>
		/// android/app/TabActivity
		/// </java-name>
		[Dot42.DexImport("android/app/TabActivity", AccessFlags = 33)]
		public partial class TabActivity : global::Android.App.ActivityGroup
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public TabActivity() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the default tab that is the first tab highlighted.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setDefaultTab
				/// </java-name>
				[Dot42.DexImport("setDefaultTab", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetDefaultTab(string index) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the default tab that is the first tab highlighted.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setDefaultTab
				/// </java-name>
				[Dot42.DexImport("setDefaultTab", "(I)V", AccessFlags = 1)]
				public virtual void SetDefaultTab(int index) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onRestoreInstanceState
				/// </java-name>
				[Dot42.DexImport("onRestoreInstanceState", "(Landroid/os/Bundle;)V", AccessFlags = 4)]
				protected internal override void OnRestoreInstanceState(global::Android.OS.Bundle state) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onPostCreate
				/// </java-name>
				[Dot42.DexImport("onPostCreate", "(Landroid/os/Bundle;)V", AccessFlags = 4)]
				protected internal override void OnPostCreate(global::Android.OS.Bundle icicle) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onSaveInstanceState
				/// </java-name>
				[Dot42.DexImport("onSaveInstanceState", "(Landroid/os/Bundle;)V", AccessFlags = 4)]
				protected internal override void OnSaveInstanceState(global::Android.OS.Bundle outState) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Updates the screen state (current list and other views) when the content changes.</para> <para> <para>Activity::onContentChanged() </para></para>        
				/// </summary>
				/// <java-name>
				/// onContentChanged
				/// </java-name>
				[Dot42.DexImport("onContentChanged", "()V", AccessFlags = 1)]
				public override void OnContentChanged() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onChildTitleChanged
				/// </java-name>
				[Dot42.DexImport("onChildTitleChanged", "(Landroid/app/Activity;Ljava/lang/CharSequence;)V", AccessFlags = 4)]
				protected internal override void OnChildTitleChanged(global::Android.App.Activity childActivity, global::Java.Lang.ICharSequence title) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns the TabHost the activity is using to host its tabs.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the TabHost the activity is using to host its tabs. </para>
				/// </returns>
				/// <java-name>
				/// getTabHost
				/// </java-name>
				public virtual global::Android.Widget.TabHost TabHost
				{
						[Dot42.DexImport("getTabHost", "()Landroid/widget/TabHost;", AccessFlags = 1)]
						get{ return default(global::Android.Widget.TabHost); }
				}

				/// <summary>
				///  <para>Returns the TabWidget the activity is using to draw the actual tabs.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the TabWidget the activity is using to draw the actual tabs. </para>
				/// </returns>
				/// <java-name>
				/// getTabWidget
				/// </java-name>
				public virtual global::Android.Widget.TabWidget TabWidget
				{
						[Dot42.DexImport("getTabWidget", "()Landroid/widget/TabWidget;", AccessFlags = 1)]
						get{ return default(global::Android.Widget.TabWidget); }
				}

		}

		/// <summary>
		///  <para>Utility class for constructing synthetic back stacks for cross-task navigation on Android 3.0 and newer.</para> <para>In API level 11 (Android 3.0/Honeycomb) the recommended conventions for app navigation using the back key changed. The back key's behavior is local to the current task and does not capture navigation across different tasks. Navigating across tasks and easily reaching the previous task is accomplished through the "recents" UI, accessible through the software-provided Recents key on the navigation or system bar. On devices with the older hardware button configuration the recents UI can be accessed with a long press on the Home key.</para> <para>When crossing from one task stack to another post-Android 3.0, the application should synthesize a back stack/history for the new task so that the user may navigate out of the new task and back to the Launcher by repeated presses of the back key. Back key presses should not navigate across task stacks.</para> <para>TaskStackBuilder provides a way to obey the correct conventions around cross-task navigation.</para> <para>  <h3>About Navigation</h3></para> <para> For more detailed information about tasks, the back stack, and navigation design guidelines, please read  from the developer guide and  from the design guide.  </para>    
		/// </summary>
		/// <java-name>
		/// android/app/TaskStackBuilder
		/// </java-name>
		[Dot42.DexImport("android/app/TaskStackBuilder", AccessFlags = 33)]
		public partial class TaskStackBuilder
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal TaskStackBuilder() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Return a new TaskStackBuilder for launching a fresh task stack consisting of a series of activities.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>A new TaskStackBuilder </para>
				/// </returns>
				/// <java-name>
				/// create
				/// </java-name>
				[Dot42.DexImport("create", "(Landroid/content/Context;)Landroid/app/TaskStackBuilder;", AccessFlags = 9)]
				public static global::Android.App.TaskStackBuilder Create(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
						return default(global::Android.App.TaskStackBuilder);
				}

				/// <summary>
				///  <para>Add a new Intent to the task stack. The most recently added Intent will invoke the Activity at the top of the final task stack.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>This TaskStackBuilder for method chaining </para>
				/// </returns>
				/// <java-name>
				/// addNextIntent
				/// </java-name>
				[Dot42.DexImport("addNextIntent", "(Landroid/content/Intent;)Landroid/app/TaskStackBuilder;", AccessFlags = 1)]
				public virtual global::Android.App.TaskStackBuilder AddNextIntent(global::Android.Content.Intent nextIntent) /* MethodBuilder.Create */ 
				{
						return default(global::Android.App.TaskStackBuilder);
				}

				/// <summary>
				///  <para>Add a new Intent with the resolved chain of parents for the target activity to the task stack.</para> <para>This is equivalent to calling addParentStack with the resolved ComponentName of nextIntent (if it can be resolved), followed by addNextIntent with nextIntent.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>This TaskStackBuilder for method chaining. </para>
				/// </returns>
				/// <java-name>
				/// addNextIntentWithParentStack
				/// </java-name>
				[Dot42.DexImport("addNextIntentWithParentStack", "(Landroid/content/Intent;)Landroid/app/TaskStackBuilder;", AccessFlags = 1)]
				public virtual global::Android.App.TaskStackBuilder AddNextIntentWithParentStack(global::Android.Content.Intent nextIntent) /* MethodBuilder.Create */ 
				{
						return default(global::Android.App.TaskStackBuilder);
				}

				/// <summary>
				///  <para>Add the activity parent chain as specified by the getParentActivityIntent() method of the activity specified and the parentActivityName attributes of each successive activity (or activity-alias) element in the application's manifest to the task stack builder.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>This TaskStackBuilder for method chaining </para>
				/// </returns>
				/// <java-name>
				/// addParentStack
				/// </java-name>
				[Dot42.DexImport("addParentStack", "(Landroid/app/Activity;)Landroid/app/TaskStackBuilder;", AccessFlags = 1)]
				public virtual global::Android.App.TaskStackBuilder AddParentStack(global::Android.App.Activity sourceActivity) /* MethodBuilder.Create */ 
				{
						return default(global::Android.App.TaskStackBuilder);
				}

				/// <summary>
				///  <para>Add the activity parent chain as specified by the getParentActivityIntent() method of the activity specified and the parentActivityName attributes of each successive activity (or activity-alias) element in the application's manifest to the task stack builder.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>This TaskStackBuilder for method chaining </para>
				/// </returns>
				/// <java-name>
				/// addParentStack
				/// </java-name>
				[Dot42.DexImport("addParentStack", "(Ljava/lang/Class;)Landroid/app/TaskStackBuilder;", AccessFlags = 1, Signature = "(Ljava/lang/Class<*>;)Landroid/app/TaskStackBuilder;")]
				public virtual global::Android.App.TaskStackBuilder AddParentStack(global::System.Type sourceActivity) /* MethodBuilder.Create */ 
				{
						return default(global::Android.App.TaskStackBuilder);
				}

				/// <summary>
				///  <para>Add the activity parent chain as specified by the getParentActivityIntent() method of the activity specified and the parentActivityName attributes of each successive activity (or activity-alias) element in the application's manifest to the task stack builder.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>This TaskStackBuilder for method chaining </para>
				/// </returns>
				/// <java-name>
				/// addParentStack
				/// </java-name>
				[Dot42.DexImport("addParentStack", "(Landroid/content/ComponentName;)Landroid/app/TaskStackBuilder;", AccessFlags = 1)]
				public virtual global::Android.App.TaskStackBuilder AddParentStack(global::Android.Content.ComponentName sourceActivity) /* MethodBuilder.Create */ 
				{
						return default(global::Android.App.TaskStackBuilder);
				}

				/// <summary>
				///  <para>Return the intent at the specified index for modification. Useful if you need to modify the flags or extras of an intent that was previously added, for example with addParentStack(Activity).</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the intent at position index </para>
				/// </returns>
				/// <java-name>
				/// editIntentAt
				/// </java-name>
				[Dot42.DexImport("editIntentAt", "(I)Landroid/content/Intent;", AccessFlags = 1)]
				public virtual global::Android.Content.Intent EditIntentAt(int index) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Intent);
				}

				/// <summary>
				///  <para>Start the task stack constructed by this builder. </para>        
				/// </summary>
				/// <java-name>
				/// startActivities
				/// </java-name>
				[Dot42.DexImport("startActivities", "()V", AccessFlags = 1)]
				public virtual void StartActivities() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Start the task stack constructed by this builder.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// startActivities
				/// </java-name>
				[Dot42.DexImport("startActivities", "(Landroid/os/Bundle;)V", AccessFlags = 1)]
				public virtual void StartActivities(global::Android.OS.Bundle options) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Obtain a PendingIntent for launching the task constructed by this builder so far.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The obtained PendingIntent </para>
				/// </returns>
				/// <java-name>
				/// getPendingIntent
				/// </java-name>
				[Dot42.DexImport("getPendingIntent", "(II)Landroid/app/PendingIntent;", AccessFlags = 1)]
				public virtual global::Android.App.PendingIntent GetPendingIntent(int requestCode, int flags) /* MethodBuilder.Create */ 
				{
						return default(global::Android.App.PendingIntent);
				}

				/// <summary>
				///  <para>Obtain a PendingIntent for launching the task constructed by this builder so far.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The obtained PendingIntent </para>
				/// </returns>
				/// <java-name>
				/// getPendingIntent
				/// </java-name>
				[Dot42.DexImport("getPendingIntent", "(IILandroid/os/Bundle;)Landroid/app/PendingIntent;", AccessFlags = 1)]
				public virtual global::Android.App.PendingIntent GetPendingIntent(int requestCode, int flags, global::Android.OS.Bundle options) /* MethodBuilder.Create */ 
				{
						return default(global::Android.App.PendingIntent);
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the number of intents added so far. </para>
				/// </returns>
				/// <java-name>
				/// getIntentCount
				/// </java-name>
				public virtual int IntentCount
				{
						[Dot42.DexImport("getIntentCount", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Return an array containing the intents added to this builder. The intent at the root of the task stack will appear as the first item in the array and the intent at the top of the stack will appear as the last item.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>An array containing the intents added to this builder. </para>
				/// </returns>
				/// <java-name>
				/// getIntents
				/// </java-name>
				public virtual global::Android.Content.Intent[] Intents
				{
						[Dot42.DexImport("getIntents", "()[Landroid/content/Intent;", AccessFlags = 1)]
						get{ return default(global::Android.Content.Intent[]); }
				}

		}

		/// <summary>
		///  <para>A dialog that prompts the user for the time of day using a TimePicker.</para> <para>See the  guide.</para>    
		/// </summary>
		/// <java-name>
		/// android/app/TimePickerDialog
		/// </java-name>
		[Dot42.DexImport("android/app/TimePickerDialog", AccessFlags = 33)]
		public partial class TimePickerDialog : global::Android.App.AlertDialog, global::Android.Content.IDialogInterface_IOnClickListener, global::Android.Widget.TimePicker.IOnTimeChangedListener
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/app/TimePickerDialog$OnTimeSetListener;IIZ)V", AccessFlags = 1)]
				public TimePickerDialog(global::Android.Content.Context context, global::Android.App.TimePickerDialog.IOnTimeSetListener callBack, int hourOfDay, int minute, bool is24HourView) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;ILandroid/app/TimePickerDialog$OnTimeSetListener;IIZ)V", AccessFlags = 1)]
				public TimePickerDialog(global::Android.Content.Context context, int theme, global::Android.App.TimePickerDialog.IOnTimeSetListener callBack, int hourOfDay, int minute, bool is24HourView) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>This method will be invoked when a button in the dialog is clicked.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// onClick
				/// </java-name>
				[Dot42.DexImport("onClick", "(Landroid/content/DialogInterface;I)V", AccessFlags = 1)]
				public virtual void OnClick(global::Android.Content.IDialogInterface dialog, int which) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// updateTime
				/// </java-name>
				[Dot42.DexImport("updateTime", "(II)V", AccessFlags = 1)]
				public virtual void UpdateTime(int hourOfDay, int minutOfHour) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <java-name>
				/// onTimeChanged
				/// </java-name>
				[Dot42.DexImport("onTimeChanged", "(Landroid/widget/TimePicker;II)V", AccessFlags = 1)]
				public virtual void OnTimeChanged(global::Android.Widget.TimePicker view, int hourOfDay, int minute) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onStop
				/// </java-name>
				[Dot42.DexImport("onStop", "()V", AccessFlags = 4)]
				protected internal override void OnStop() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onSaveInstanceState
				/// </java-name>
				[Dot42.DexImport("onSaveInstanceState", "()Landroid/os/Bundle;", AccessFlags = 1)]
				public override global::Android.OS.Bundle OnSaveInstanceState() /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.Bundle);
				}

				/// <java-name>
				/// onRestoreInstanceState
				/// </java-name>
				[Dot42.DexImport("onRestoreInstanceState", "(Landroid/os/Bundle;)V", AccessFlags = 1)]
				public override void OnRestoreInstanceState(global::Android.OS.Bundle savedInstanceState) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal TimePickerDialog() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>The callback interface used to indicate the user is done filling in the time (they clicked on the 'Set' button). </para>    
				/// </summary>
				/// <java-name>
				/// android/app/TimePickerDialog$OnTimeSetListener
				/// </java-name>
				[Dot42.DexImport("android/app/TimePickerDialog$OnTimeSetListener", AccessFlags = 1545)]
				public partial interface IOnTimeSetListener
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para></para>        
						/// </summary>
						/// <java-name>
						/// onTimeSet
						/// </java-name>
						[Dot42.DexImport("onTimeSet", "(Landroid/widget/TimePicker;II)V", AccessFlags = 1025)]
						void OnTimeSet(global::Android.Widget.TimePicker view, int hourOfDay, int minute) /* MethodBuilder.Create */ ;

				}

		}

		/// <summary>
		///  <para>Class for interacting with the device's UI by simulation user actions and introspection of the screen content. It relies on the platform accessibility APIs to introspect the screen and to perform some actions on the remote view tree. It also allows injecting of arbitrary raw input events simulating user interaction with keyboards and touch devices. One can think of a UiAutomation as a special type of android.accessibilityservice.AccessibilityService which does not provide hooks for the service life cycle and exposes other APIs that are useful for UI test automation. </para> <para>The APIs exposed by this class are low-level to maximize flexibility when developing UI test automation tools and libraries. Generally, a UiAutomation client should be using a higher-level library or implement high-level functions. For example, performing a tap on the screen requires construction and injecting of a touch down and up events which have to be delivered to the system by a call to injectInputEvent(InputEvent, boolean). </para> <para>The APIs exposed by this class operate across applications enabling a client to write tests that cover use cases spanning over multiple applications. For example, going to the settings application to change a setting and then interacting with another application whose behavior depends on that setting. </para>    
		/// </summary>
		/// <java-name>
		/// android/app/UiAutomation
		/// </java-name>
		[Dot42.DexImport("android/app/UiAutomation", AccessFlags = 49)]
		public sealed partial class UiAutomation
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Rotation constant: Unfreeze rotation (rotating the device changes its rotation state). </para>        
				/// </summary>
				/// <java-name>
				/// ROTATION_UNFREEZE
				/// </java-name>
				[Dot42.DexImport("ROTATION_UNFREEZE", "I", AccessFlags = 25)]
				public const int ROTATION_UNFREEZE = -2;
				/// <summary>
				///  <para>Rotation constant: Freeze rotation to its current state. </para>        
				/// </summary>
				/// <java-name>
				/// ROTATION_FREEZE_CURRENT
				/// </java-name>
				[Dot42.DexImport("ROTATION_FREEZE_CURRENT", "I", AccessFlags = 25)]
				public const int ROTATION_FREEZE_CURRENT = -1;
				/// <summary>
				///  <para>Rotation constant: Freeze rotation to 0 degrees (natural orientation) </para>        
				/// </summary>
				/// <java-name>
				/// ROTATION_FREEZE_0
				/// </java-name>
				[Dot42.DexImport("ROTATION_FREEZE_0", "I", AccessFlags = 25)]
				public const int ROTATION_FREEZE_0 = 0;
				/// <summary>
				///  <para>Rotation constant: Freeze rotation to 90 degrees . </para>        
				/// </summary>
				/// <java-name>
				/// ROTATION_FREEZE_90
				/// </java-name>
				[Dot42.DexImport("ROTATION_FREEZE_90", "I", AccessFlags = 25)]
				public const int ROTATION_FREEZE_90 = 1;
				/// <summary>
				///  <para>Rotation constant: Freeze rotation to 180 degrees . </para>        
				/// </summary>
				/// <java-name>
				/// ROTATION_FREEZE_180
				/// </java-name>
				[Dot42.DexImport("ROTATION_FREEZE_180", "I", AccessFlags = 25)]
				public const int ROTATION_FREEZE_180 = 2;
				/// <summary>
				///  <para>Rotation constant: Freeze rotation to 270 degrees . </para>        
				/// </summary>
				/// <java-name>
				/// ROTATION_FREEZE_270
				/// </java-name>
				[Dot42.DexImport("ROTATION_FREEZE_270", "I", AccessFlags = 25)]
				public const int ROTATION_FREEZE_270 = 3;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal UiAutomation() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets a callback for observing the stream of AccessibilityEvents.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setOnAccessibilityEventListener
				/// </java-name>
				[Dot42.DexImport("setOnAccessibilityEventListener", "(Landroid/app/UiAutomation$OnAccessibilityEventListener;)V", AccessFlags = 1)]
				public void SetOnAccessibilityEventListener(global::Android.App.UiAutomation.IOnAccessibilityEventListener listener) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Performs a global action. Such an action can be performed at any moment regardless of the current application or user location in that application. For example going back, going home, opening recents, etc.</para> <para> <para>AccessibilityService::GLOBAL_ACTION_BACK </para> <para>AccessibilityService::GLOBAL_ACTION_HOME </para> <para>AccessibilityService::GLOBAL_ACTION_NOTIFICATIONS </para> <para>AccessibilityService::GLOBAL_ACTION_RECENTS </para></para>        
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
				///  <para>A method for injecting an arbitrary input event. </para> <para> <b>Note:</b> It is caller's responsibility to recycle the event. </para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Whether event injection succeeded. </para>
				/// </returns>
				/// <java-name>
				/// injectInputEvent
				/// </java-name>
				[Dot42.DexImport("injectInputEvent", "(Landroid/view/InputEvent;Z)Z", AccessFlags = 1)]
				public bool InjectInputEvent(global::Android.Views.InputEvent @event, bool sync) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Sets the device rotation. A client can freeze the rotation in desired state or freeze the rotation to its current state or unfreeze the rotation (rotating the device changes its rotation state).</para> <para> <para>ROTATION_FREEZE_0 </para> <para>ROTATION_FREEZE_90 </para> <para>ROTATION_FREEZE_180 </para> <para>ROTATION_FREEZE_270 </para> <para>ROTATION_FREEZE_CURRENT </para> <para>ROTATION_UNFREEZE </para></para>        
				/// </summary>
				/// <returns>
				///  <para>Whether the rotation was set successfully.</para>
				/// </returns>
				/// <java-name>
				/// setRotation
				/// </java-name>
				[Dot42.DexImport("setRotation", "(I)Z", AccessFlags = 1)]
				public bool SetRotation(int rotation) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Executes a command and waits for a specific accessibility event up to a given wait timeout. To detect a sequence of events one can implement a filter that keeps track of seen events of the expected sequence and returns true after the last event of that sequence is received. </para> <para> <b>Note:</b> It is caller's responsibility to recycle the returned event. </para> <para></para>        
				/// </summary>
				/// <java-name>
				/// executeAndWaitForEvent
				/// </java-name>
				[Dot42.DexImport("executeAndWaitForEvent", "(Ljava/lang/Runnable;Landroid/app/UiAutomation$AccessibilityEventFilter;J)Landroi" +
    "d/view/accessibility/AccessibilityEvent;", AccessFlags = 1)]
				public global::Android.Views.Accessibility.AccessibilityEvent ExecuteAndWaitForEvent(global::Java.Lang.IRunnable command, global::Android.App.UiAutomation.IAccessibilityEventFilter filter, long timeoutMillis) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.Accessibility.AccessibilityEvent);
				}

				/// <summary>
				///  <para>Waits for the accessibility event stream to become idle, which is not to have received an accessibility event within  <code>idleTimeoutMillis</code>. The total time spent to wait for an idle accessibility event stream is bounded by the  <code>globalTimeoutMillis</code>.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// waitForIdle
				/// </java-name>
				[Dot42.DexImport("waitForIdle", "(JJ)V", AccessFlags = 1)]
				public void WaitForIdle(long idleTimeoutMillis, long globalTimeoutMillis) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Takes a screenshot.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The screenshot bitmap on success, null otherwise. </para>
				/// </returns>
				/// <java-name>
				/// takeScreenshot
				/// </java-name>
				[Dot42.DexImport("takeScreenshot", "()Landroid/graphics/Bitmap;", AccessFlags = 1)]
				public global::Android.Graphics.Bitmap TakeScreenshot() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Bitmap);
				}

				/// <summary>
				///  <para>Sets whether this UiAutomation to run in a "monkey" mode. Applications can query whether they are executed in a "monkey" mode, i.e. run by a test framework, and avoid doing potentially undesirable actions such as calling 911 or posting on public forums etc.</para> <para> <para>ActivityManager#isUserAMonkey() </para></para>        
				/// </summary>
				/// <java-name>
				/// setRunAsMonkey
				/// </java-name>
				[Dot42.DexImport("setRunAsMonkey", "(Z)V", AccessFlags = 1)]
				public void SetRunAsMonkey(bool enable) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Gets the an AccessibilityServiceInfo describing this UiAutomation. This method is useful if one wants to change some of the dynamically configurable properties at runtime.</para> <para> <para>AccessibilityServiceInfo </para></para>        
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

				/// <summary>
				///  <para>Gets the root AccessibilityNodeInfo in the active window.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The root info. </para>
				/// </returns>
				/// <java-name>
				/// getRootInActiveWindow
				/// </java-name>
				public global::Android.Views.Accessibility.AccessibilityNodeInfo RootInActiveWindow
				{
						[Dot42.DexImport("getRootInActiveWindow", "()Landroid/view/accessibility/AccessibilityNodeInfo;", AccessFlags = 1)]
						get{ return default(global::Android.Views.Accessibility.AccessibilityNodeInfo); }
				}

				/// <summary>
				///  <para>Listener for filtering accessibility events. </para>    
				/// </summary>
				/// <java-name>
				/// android/app/UiAutomation$AccessibilityEventFilter
				/// </java-name>
				[Dot42.DexImport("android/app/UiAutomation$AccessibilityEventFilter", AccessFlags = 1545)]
				public partial interface IAccessibilityEventFilter
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>Callback for determining whether an event is accepted or it is filtered out.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>True if the event is accepted, false to filter it out. </para>
						/// </returns>
						/// <java-name>
						/// accept
						/// </java-name>
						[Dot42.DexImport("accept", "(Landroid/view/accessibility/AccessibilityEvent;)Z", AccessFlags = 1025)]
						bool Accept(global::Android.Views.Accessibility.AccessibilityEvent @event) /* MethodBuilder.Create */ ;

				}

				/// <summary>
				///  <para>Listener for observing the AccessibilityEvent stream. </para>    
				/// </summary>
				/// <java-name>
				/// android/app/UiAutomation$OnAccessibilityEventListener
				/// </java-name>
				[Dot42.DexImport("android/app/UiAutomation$OnAccessibilityEventListener", AccessFlags = 1545)]
				public partial interface IOnAccessibilityEventListener
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>Callback for receiving an AccessibilityEvent. </para> <para> <b>Note:</b> This method is  <b>NOT</b> executed on the main test thread. The client is responsible for proper synchronization. </para> <para> <b>Note:</b> It is responsibility of the client to recycle the received events to minimize object creation. </para> <para></para>        
						/// </summary>
						/// <java-name>
						/// onAccessibilityEvent
						/// </java-name>
						[Dot42.DexImport("onAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)V", AccessFlags = 1025)]
						void OnAccessibilityEvent(global::Android.Views.Accessibility.AccessibilityEvent @event) /* MethodBuilder.Create */ ;

				}

		}

		/// <summary>
		///  <para>This class provides access to the system uimode services. These services allow applications to control UI modes of the device. It provides functionality to disable the car mode and it gives access to the night mode settings.</para> <para>These facilities are built on top of the underlying android.content.Intent#ACTION_DOCK_EVENT broadcasts that are sent when the user physical places the device into and out of a dock. When that happens, the UiModeManager switches the system android.content.res.Configuration to the appropriate UI mode, sends broadcasts about the mode switch, and starts the corresponding mode activity if appropriate. See the broadcasts ACTION_ENTER_CAR_MODE and ACTION_ENTER_DESK_MODE for more information.</para> <para>In addition, the user may manually switch the system to car mode without physically being in a dock. While in car mode  whether by manual action from the user or being physically placed in a dock  a notification is displayed allowing the user to exit dock mode. Thus the dock mode represented here may be different than the current state of the underlying dock event broadcast.</para> <para>You do not instantiate this class directly; instead, retrieve it through Context.getSystemService(Context.UI_MODE_SERVICE). </para>    
		/// </summary>
		/// <java-name>
		/// android/app/UiModeManager
		/// </java-name>
		[Dot42.DexImport("android/app/UiModeManager", AccessFlags = 33)]
		public partial class UiModeManager
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Broadcast sent when the device's UI has switched to car mode, either by being placed in a car dock or explicit action of the user. After sending the broadcast, the system will start the intent android.content.Intent#ACTION_MAIN with category android.content.Intent#CATEGORY_CAR_DOCK to display the car UI, which typically what an application would implement to provide their own interface. However, applications can also monitor this Intent in order to be informed of mode changes or prevent the normal car UI from being displayed by setting the result of the broadcast to Activity#RESULT_CANCELED. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_ENTER_CAR_MODE
				/// </java-name>
				[Dot42.DexImport("ACTION_ENTER_CAR_MODE", "Ljava/lang/String;", AccessFlags = 9)]
				public static string ACTION_ENTER_CAR_MODE;
				/// <summary>
				///  <para>Broadcast sent when the device's UI has switch away from car mode back to normal mode. Typically used by a car mode app, to dismiss itself when the user exits car mode. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_EXIT_CAR_MODE
				/// </java-name>
				[Dot42.DexImport("ACTION_EXIT_CAR_MODE", "Ljava/lang/String;", AccessFlags = 9)]
				public static string ACTION_EXIT_CAR_MODE;
				/// <summary>
				///  <para>Broadcast sent when the device's UI has switched to desk mode, by being placed in a desk dock. After sending the broadcast, the system will start the intent android.content.Intent#ACTION_MAIN with category android.content.Intent#CATEGORY_DESK_DOCK to display the desk UI, which typically what an application would implement to provide their own interface. However, applications can also monitor this Intent in order to be informed of mode changes or prevent the normal desk UI from being displayed by setting the result of the broadcast to Activity#RESULT_CANCELED. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_ENTER_DESK_MODE
				/// </java-name>
				[Dot42.DexImport("ACTION_ENTER_DESK_MODE", "Ljava/lang/String;", AccessFlags = 9)]
				public static string ACTION_ENTER_DESK_MODE;
				/// <summary>
				///  <para>Broadcast sent when the device's UI has switched away from desk mode back to normal mode. Typically used by a desk mode app, to dismiss itself when the user exits desk mode. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_EXIT_DESK_MODE
				/// </java-name>
				[Dot42.DexImport("ACTION_EXIT_DESK_MODE", "Ljava/lang/String;", AccessFlags = 9)]
				public static string ACTION_EXIT_DESK_MODE;
				/// <summary>
				///  <para>Constant for setNightMode(int) and getNightMode(): automatically switch night mode on and off based on the time. </para>        
				/// </summary>
				/// <java-name>
				/// MODE_NIGHT_AUTO
				/// </java-name>
				[Dot42.DexImport("MODE_NIGHT_AUTO", "I", AccessFlags = 25)]
				public const int MODE_NIGHT_AUTO = 0;
				/// <summary>
				///  <para>Constant for setNightMode(int) and getNightMode(): never run in night mode. </para>        
				/// </summary>
				/// <java-name>
				/// MODE_NIGHT_NO
				/// </java-name>
				[Dot42.DexImport("MODE_NIGHT_NO", "I", AccessFlags = 25)]
				public const int MODE_NIGHT_NO = 1;
				/// <summary>
				///  <para>Constant for setNightMode(int) and getNightMode(): always run in night mode. </para>        
				/// </summary>
				/// <java-name>
				/// MODE_NIGHT_YES
				/// </java-name>
				[Dot42.DexImport("MODE_NIGHT_YES", "I", AccessFlags = 25)]
				public const int MODE_NIGHT_YES = 2;
				/// <summary>
				///  <para>Flag for use with enableCarMode(int): go to the car home activity as part of the enable. Enabling this way ensures a clean transition between the current activity (in non-car-mode) and the car home activity that will serve as home while in car mode. This will switch to the car home activity even if we are already in car mode. </para>        
				/// </summary>
				/// <java-name>
				/// ENABLE_CAR_MODE_GO_CAR_HOME
				/// </java-name>
				[Dot42.DexImport("ENABLE_CAR_MODE_GO_CAR_HOME", "I", AccessFlags = 25)]
				public const int ENABLE_CAR_MODE_GO_CAR_HOME = 1;
				/// <summary>
				///  <para>Flag for use with disableCarMode(int): go to the normal home activity as part of the disable. Disabling this way ensures a clean transition between the current activity (in car mode) and the original home activity (which was typically last running without being in car mode). </para>        
				/// </summary>
				/// <java-name>
				/// DISABLE_CAR_MODE_GO_HOME
				/// </java-name>
				[Dot42.DexImport("DISABLE_CAR_MODE_GO_HOME", "I", AccessFlags = 25)]
				public const int DISABLE_CAR_MODE_GO_HOME = 1;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal UiModeManager() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Force device into car mode, like it had been placed in the car dock. This will cause the device to switch to the car home UI as part of the mode switch. </para>        
				/// </summary>
				/// <java-name>
				/// enableCarMode
				/// </java-name>
				[Dot42.DexImport("enableCarMode", "(I)V", AccessFlags = 1)]
				public virtual void EnableCarMode(int flags) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Turn off special mode if currently in car mode. </para>        
				/// </summary>
				/// <java-name>
				/// disableCarMode
				/// </java-name>
				[Dot42.DexImport("disableCarMode", "(I)V", AccessFlags = 1)]
				public virtual void DisableCarMode(int flags) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Return the current running mode type. May be one of Configuration.UI_MODE_TYPE_NORMAL, Configuration.UI_MODE_TYPE_DESK, or Configuration.UI_MODE_TYPE_CAR, or Configuration.UI_MODE_TYPE_APPLIANCE. </para>        
				/// </summary>
				/// <java-name>
				/// getCurrentModeType
				/// </java-name>
				public virtual int CurrentModeType
				{
						[Dot42.DexImport("getCurrentModeType", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns the currently configured night mode.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>MODE_NIGHT_NO, MODE_NIGHT_YES, or MODE_NIGHT_AUTO. When an error occurred -1 is returned. </para>
				/// </returns>
				/// <java-name>
				/// getNightMode
				/// </java-name>
				public virtual int NightMode
				{
						[Dot42.DexImport("getNightMode", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setNightMode", "(I)V", AccessFlags = 1)]
						set{ }
				}

		}

		/// <summary>
		///  <para>This class is used to specify meta information of a wallpaper service. </para>    
		/// </summary>
		/// <java-name>
		/// android/app/WallpaperInfo
		/// </java-name>
		[Dot42.DexImport("android/app/WallpaperInfo", AccessFlags = 49)]
		public sealed partial class WallpaperInfo : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Used to make this class parcelable. </para>        
				/// </summary>
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.App.WallpaperInfo> CREATOR;
				/// <summary>
				///  <para>Constructor.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/content/pm/ResolveInfo;)V", AccessFlags = 1)]
				public WallpaperInfo(global::Android.Content.Context context, global::Android.Content.PM.ResolveInfo service) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Load the user-displayed label for this wallpaper.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// loadLabel
				/// </java-name>
				[Dot42.DexImport("loadLabel", "(Landroid/content/pm/PackageManager;)Ljava/lang/CharSequence;", AccessFlags = 1)]
				public global::Java.Lang.ICharSequence LoadLabel(global::Android.Content.PM.PackageManager pm) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <summary>
				///  <para>Load the user-displayed icon for this wallpaper.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// loadIcon
				/// </java-name>
				[Dot42.DexImport("loadIcon", "(Landroid/content/pm/PackageManager;)Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
				public global::Android.Graphics.Drawables.Drawable LoadIcon(global::Android.Content.PM.PackageManager pm) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawables.Drawable);
				}

				/// <summary>
				///  <para>Load the thumbnail image for this wallpaper.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// loadThumbnail
				/// </java-name>
				[Dot42.DexImport("loadThumbnail", "(Landroid/content/pm/PackageManager;)Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
				public global::Android.Graphics.Drawables.Drawable LoadThumbnail(global::Android.Content.PM.PackageManager pm) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawables.Drawable);
				}

				/// <summary>
				///  <para>Return a string indicating the author(s) of this wallpaper. </para>        
				/// </summary>
				/// <java-name>
				/// loadAuthor
				/// </java-name>
				[Dot42.DexImport("loadAuthor", "(Landroid/content/pm/PackageManager;)Ljava/lang/CharSequence;", AccessFlags = 1)]
				public global::Java.Lang.ICharSequence LoadAuthor(global::Android.Content.PM.PackageManager pm) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <summary>
				///  <para>Return a brief summary of this wallpaper's behavior. </para>        
				/// </summary>
				/// <java-name>
				/// loadDescription
				/// </java-name>
				[Dot42.DexImport("loadDescription", "(Landroid/content/pm/PackageManager;)Ljava/lang/CharSequence;", AccessFlags = 1)]
				public global::Java.Lang.ICharSequence LoadDescription(global::Android.Content.PM.PackageManager pm) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <java-name>
				/// dump
				/// </java-name>
				[Dot42.DexImport("dump", "(Landroid/util/Printer;Ljava/lang/String;)V", AccessFlags = 1)]
				public void Dump(global::Android.Util.IPrinter pw, string prefix) /* MethodBuilder.Create */ 
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
				///  <para>Used to package this object into a Parcel.</para> <para></para>        
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

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal WallpaperInfo() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Return the .apk package that implements this wallpaper. </para>        
				/// </summary>
				/// <java-name>
				/// getPackageName
				/// </java-name>
				public string PackageName
				{
						[Dot42.DexImport("getPackageName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>Return the class name of the service component that implements this wallpaper. </para>        
				/// </summary>
				/// <java-name>
				/// getServiceName
				/// </java-name>
				public string ServiceName
				{
						[Dot42.DexImport("getServiceName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>Return the raw information about the Service implementing this wallpaper. Do not modify the returned object. </para>        
				/// </summary>
				/// <java-name>
				/// getServiceInfo
				/// </java-name>
				public global::Android.Content.PM.ServiceInfo ServiceInfo
				{
						[Dot42.DexImport("getServiceInfo", "()Landroid/content/pm/ServiceInfo;", AccessFlags = 1)]
						get{ return default(global::Android.Content.PM.ServiceInfo); }
				}

				/// <summary>
				///  <para>Return the component of the service that implements this wallpaper. </para>        
				/// </summary>
				/// <java-name>
				/// getComponent
				/// </java-name>
				public global::Android.Content.ComponentName Component
				{
						[Dot42.DexImport("getComponent", "()Landroid/content/ComponentName;", AccessFlags = 1)]
						get{ return default(global::Android.Content.ComponentName); }
				}

				/// <summary>
				///  <para>Return the class name of an activity that provides a settings UI for the wallpaper. You can launch this activity be starting it with an android.content.Intent whose action is MAIN and with an explicit android.content.ComponentName composed of getPackageName and the class name returned here.</para> <para>A null will be returned if there is no settings activity associated with the wallpaper. </para>        
				/// </summary>
				/// <java-name>
				/// getSettingsActivity
				/// </java-name>
				public string SettingsActivity
				{
						[Dot42.DexImport("getSettingsActivity", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

		}

		/// <summary>
		///  <para>Provides access to the system wallpaper. With WallpaperManager, you can get the current wallpaper, get the desired dimensions for the wallpaper, set the wallpaper, and more. Get an instance of WallpaperManager with getInstance(). </para>    
		/// </summary>
		/// <java-name>
		/// android/app/WallpaperManager
		/// </java-name>
		[Dot42.DexImport("android/app/WallpaperManager", AccessFlags = 33)]
		public partial class WallpaperManager
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Launch an activity for the user to pick the current global live wallpaper. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_LIVE_WALLPAPER_CHOOSER
				/// </java-name>
				[Dot42.DexImport("ACTION_LIVE_WALLPAPER_CHOOSER", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_LIVE_WALLPAPER_CHOOSER = "android.service.wallpaper.LIVE_WALLPAPER_CHOOSER";
				/// <summary>
				///  <para>Directly launch live wallpaper preview, allowing the user to immediately confirm to switch to a specific live wallpaper. You must specify EXTRA_LIVE_WALLPAPER_COMPONENT with the ComponentName of a live wallpaper component that is to be shown. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_CHANGE_LIVE_WALLPAPER
				/// </java-name>
				[Dot42.DexImport("ACTION_CHANGE_LIVE_WALLPAPER", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_CHANGE_LIVE_WALLPAPER = "android.service.wallpaper.CHANGE_LIVE_WALLPAPER";
				/// <summary>
				///  <para>Extra in ACTION_CHANGE_LIVE_WALLPAPER that specifies the ComponentName of a live wallpaper that should be shown as a preview, for the user to confirm. </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_LIVE_WALLPAPER_COMPONENT
				/// </java-name>
				[Dot42.DexImport("EXTRA_LIVE_WALLPAPER_COMPONENT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_LIVE_WALLPAPER_COMPONENT = "android.service.wallpaper.extra.LIVE_WALLPAPER_COMPONENT";
				/// <summary>
				///  <para>Manifest entry for activities that respond to Intent#ACTION_SET_WALLPAPER which allows them to provide a custom large icon associated with this action. </para>        
				/// </summary>
				/// <java-name>
				/// WALLPAPER_PREVIEW_META_DATA
				/// </java-name>
				[Dot42.DexImport("WALLPAPER_PREVIEW_META_DATA", "Ljava/lang/String;", AccessFlags = 25)]
				public const string WALLPAPER_PREVIEW_META_DATA = "android.wallpaper.preview";
				/// <summary>
				///  <para>Command for sendWallpaperCommand: reported by the wallpaper host when the user taps on an empty area (not performing an action in the host). The x and y arguments are the location of the tap in screen coordinates. </para>        
				/// </summary>
				/// <java-name>
				/// COMMAND_TAP
				/// </java-name>
				[Dot42.DexImport("COMMAND_TAP", "Ljava/lang/String;", AccessFlags = 25)]
				public const string COMMAND_TAP = "android.wallpaper.tap";
				/// <summary>
				///  <para>Command for sendWallpaperCommand: reported by the wallpaper host when the user releases a secondary pointer on an empty area (not performing an action in the host). The x and y arguments are the location of the secondary tap in screen coordinates. </para>        
				/// </summary>
				/// <java-name>
				/// COMMAND_SECONDARY_TAP
				/// </java-name>
				[Dot42.DexImport("COMMAND_SECONDARY_TAP", "Ljava/lang/String;", AccessFlags = 25)]
				public const string COMMAND_SECONDARY_TAP = "android.wallpaper.secondaryTap";
				/// <summary>
				///  <para>Command for sendWallpaperCommand: reported by the wallpaper host when the user drops an object into an area of the host. The x and y arguments are the location of the drop. </para>        
				/// </summary>
				/// <java-name>
				/// COMMAND_DROP
				/// </java-name>
				[Dot42.DexImport("COMMAND_DROP", "Ljava/lang/String;", AccessFlags = 25)]
				public const string COMMAND_DROP = "android.home.drop";
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal WallpaperManager() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Retrieve a WallpaperManager associated with the given Context. </para>        
				/// </summary>
				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(Landroid/content/Context;)Landroid/app/WallpaperManager;", AccessFlags = 9)]
				public static global::Android.App.WallpaperManager GetInstance(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
						return default(global::Android.App.WallpaperManager);
				}

				/// <summary>
				///  <para>Retrieve the current system wallpaper; if there is no wallpaper set, a null pointer is returned. This is returned as an abstract Drawable that you can install in a View to display whatever wallpaper the user has currently set.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns a Drawable object that will draw the wallpaper or a null pointer if these is none. </para>
				/// </returns>
				/// <java-name>
				/// peekDrawable
				/// </java-name>
				[Dot42.DexImport("peekDrawable", "()Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
				public virtual global::Android.Graphics.Drawables.Drawable PeekDrawable() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawables.Drawable);
				}

				/// <summary>
				///  <para>Like getFastDrawable(), but if there is no wallpaper set, a null pointer is returned.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns an optimized Drawable object that will draw the wallpaper or a null pointer if these is none. </para>
				/// </returns>
				/// <java-name>
				/// peekFastDrawable
				/// </java-name>
				[Dot42.DexImport("peekFastDrawable", "()Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
				public virtual global::Android.Graphics.Drawables.Drawable PeekFastDrawable() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawables.Drawable);
				}

				/// <summary>
				///  <para>Remove all internal references to the last loaded wallpaper. Useful for apps that want to reduce memory usage when they only temporarily need to have the wallpaper. After calling, the next request for the wallpaper will require reloading it again from disk. </para>        
				/// </summary>
				/// <java-name>
				/// forgetLoadedWallpaper
				/// </java-name>
				[Dot42.DexImport("forgetLoadedWallpaper", "()V", AccessFlags = 1)]
				public virtual void ForgetLoadedWallpaper() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Change the current system wallpaper to the bitmap in the given resource. The resource is opened as a raw data stream and copied into the wallpaper; it must be a valid PNG or JPEG image. On success, the intent Intent#ACTION_WALLPAPER_CHANGED is broadcast.</para> <para>This method requires the caller to hold the permission android.Manifest.permission#SET_WALLPAPER.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setResource
				/// </java-name>
				[Dot42.DexImport("setResource", "(I)V", AccessFlags = 1)]
				public virtual void SetResource(int resid) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Change the current system wallpaper to a bitmap. The given bitmap is converted to a PNG and stored as the wallpaper. On success, the intent Intent#ACTION_WALLPAPER_CHANGED is broadcast.</para> <para>This method requires the caller to hold the permission android.Manifest.permission#SET_WALLPAPER.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setBitmap
				/// </java-name>
				[Dot42.DexImport("setBitmap", "(Landroid/graphics/Bitmap;)V", AccessFlags = 1)]
				public virtual void SetBitmap(global::Android.Graphics.Bitmap bitmap) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Change the current system wallpaper to a specific byte stream. The give InputStream is copied into persistent storage and will now be used as the wallpaper. Currently it must be either a JPEG or PNG image. On success, the intent Intent#ACTION_WALLPAPER_CHANGED is broadcast.</para> <para>This method requires the caller to hold the permission android.Manifest.permission#SET_WALLPAPER.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setStream
				/// </java-name>
				[Dot42.DexImport("setStream", "(Ljava/io/InputStream;)V", AccessFlags = 1)]
				public virtual void SetStream(global::Java.IO.InputStream data) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Return whether any users are currently set to use the wallpaper with the given resource ID. That is, their wallpaper has been set through setResource(int) with the same resource id. </para>        
				/// </summary>
				/// <java-name>
				/// hasResourceWallpaper
				/// </java-name>
				[Dot42.DexImport("hasResourceWallpaper", "(I)Z", AccessFlags = 1)]
				public virtual bool HasResourceWallpaper(int resid) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>For use only by the current home application, to specify the size of wallpaper it would like to use. This allows such applications to have a virtual wallpaper that is larger than the physical screen, matching the size of their workspace.</para> <para>Note developers, who don't seem to be reading this. This is for  <b>home screens</b> to tell what size wallpaper they would like. Nobody else should be calling this! Certainly not other non-home-screen apps that change the wallpaper. Those apps are supposed to  <b>retrieve</b> the suggested size so they can construct a wallpaper that matches it.</para> <para>This method requires the caller to hold the permission android.Manifest.permission#SET_WALLPAPER_HINTS.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// suggestDesiredDimensions
				/// </java-name>
				[Dot42.DexImport("suggestDesiredDimensions", "(II)V", AccessFlags = 1)]
				public virtual void SuggestDesiredDimensions(int minimumWidth, int minimumHeight) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Set the position of the current wallpaper within any larger space, when that wallpaper is visible behind the given window. The X and Y offsets are floating point numbers ranging from 0 to 1, representing where the wallpaper should be positioned within the screen space. These only make sense when the wallpaper is larger than the screen.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setWallpaperOffsets
				/// </java-name>
				[Dot42.DexImport("setWallpaperOffsets", "(Landroid/os/IBinder;FF)V", AccessFlags = 1)]
				public virtual void SetWallpaperOffsets(global::Android.OS.IBinder windowToken, float xOffset, float yOffset) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>For applications that use multiple virtual screens showing a wallpaper, specify the step size between virtual screens. For example, if the launcher has 3 virtual screens, it would specify an xStep of 0.5, since the X offset for those screens are 0.0, 0.5 and 1.0 </para>        
				/// </summary>
				/// <java-name>
				/// setWallpaperOffsetSteps
				/// </java-name>
				[Dot42.DexImport("setWallpaperOffsetSteps", "(FF)V", AccessFlags = 1)]
				public virtual void SetWallpaperOffsetSteps(float xStep, float yStep) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Send an arbitrary command to the current active wallpaper.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// sendWallpaperCommand
				/// </java-name>
				[Dot42.DexImport("sendWallpaperCommand", "(Landroid/os/IBinder;Ljava/lang/String;IIILandroid/os/Bundle;)V", AccessFlags = 1)]
				public virtual void SendWallpaperCommand(global::Android.OS.IBinder windowToken, string action, int x, int y, int z, global::Android.OS.Bundle extras) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Clear the offsets previously associated with this window through setWallpaperOffsets(IBinder, float, float). This reverts the window to its default state, where it does not cause the wallpaper to scroll from whatever its last offsets were.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// clearWallpaperOffsets
				/// </java-name>
				[Dot42.DexImport("clearWallpaperOffsets", "(Landroid/os/IBinder;)V", AccessFlags = 1)]
				public virtual void ClearWallpaperOffsets(global::Android.OS.IBinder windowToken) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Remove any currently set wallpaper, reverting to the system's built-in wallpaper. On success, the intent Intent#ACTION_WALLPAPER_CHANGED is broadcast.</para> <para>This method requires the caller to hold the permission android.Manifest.permission#SET_WALLPAPER.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// clear
				/// </java-name>
				[Dot42.DexImport("clear", "()V", AccessFlags = 1)]
				public virtual void Clear() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Retrieve the current system wallpaper; if no wallpaper is set, the system built-in static wallpaper is returned. This is returned as an abstract Drawable that you can install in a View to display whatever wallpaper the user has currently set.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns a Drawable object that will draw the wallpaper. </para>
				/// </returns>
				/// <java-name>
				/// getDrawable
				/// </java-name>
				public virtual global::Android.Graphics.Drawables.Drawable Drawable
				{
						[Dot42.DexImport("getDrawable", "()Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
						get{ return default(global::Android.Graphics.Drawables.Drawable); }
				}

				/// <summary>
				///  <para>Like getDrawable(), but the returned Drawable has a number of limitations to reduce its overhead as much as possible. It will never scale the wallpaper (only centering it if the requested bounds do match the bitmap bounds, which should not be typical), doesn't allow setting an alpha, color filter, or other attributes, etc. The bounds of the returned drawable will be initialized to the same bounds as the wallpaper, so normally you will not need to touch it. The drawable also assumes that it will be used in a context running in the same density as the screen (not in density compatibility mode).</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns a Drawable object that will draw the wallpaper. </para>
				/// </returns>
				/// <java-name>
				/// getFastDrawable
				/// </java-name>
				public virtual global::Android.Graphics.Drawables.Drawable FastDrawable
				{
						[Dot42.DexImport("getFastDrawable", "()Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
						get{ return default(global::Android.Graphics.Drawables.Drawable); }
				}

				/// <summary>
				///  <para>If the current wallpaper is a live wallpaper component, return the information about that wallpaper. Otherwise, if it is a static image, simply return null. </para>        
				/// </summary>
				/// <java-name>
				/// getWallpaperInfo
				/// </java-name>
				public virtual global::Android.App.WallpaperInfo WallpaperInfo
				{
						[Dot42.DexImport("getWallpaperInfo", "()Landroid/app/WallpaperInfo;", AccessFlags = 1)]
						get{ return default(global::Android.App.WallpaperInfo); }
				}

				/// <summary>
				///  <para>Returns the desired minimum width for the wallpaper. Callers of setBitmap(android.graphics.Bitmap) or setStream(java.io.InputStream) should check this value beforehand to make sure the supplied wallpaper respects the desired minimum width.</para> <para>If the returned value is &lt;= 0, the caller should use the width of the default display instead.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The desired minimum width for the wallpaper. This value should be honored by applications that set the wallpaper but it is not mandatory. </para>
				/// </returns>
				/// <java-name>
				/// getDesiredMinimumWidth
				/// </java-name>
				public virtual int DesiredMinimumWidth
				{
						[Dot42.DexImport("getDesiredMinimumWidth", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns the desired minimum height for the wallpaper. Callers of setBitmap(android.graphics.Bitmap) or setStream(java.io.InputStream) should check this value beforehand to make sure the supplied wallpaper respects the desired minimum height.</para> <para>If the returned value is &lt;= 0, the caller should use the height of the default display instead.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The desired minimum height for the wallpaper. This value should be honored by applications that set the wallpaper but it is not mandatory. </para>
				/// </returns>
				/// <java-name>
				/// getDesiredMinimumHeight
				/// </java-name>
				public virtual int DesiredMinimumHeight
				{
						[Dot42.DexImport("getDesiredMinimumHeight", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

		}

}

