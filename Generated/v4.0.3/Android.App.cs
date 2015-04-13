#pragma warning disable 1717
namespace Android.App
{
		/// <java-name>
		/// android/app/ActionBar
		/// </java-name>
		[Dot42.DexImport("android/app/ActionBar", AccessFlags = 1057)]
		public abstract partial class ActionBar
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// NAVIGATION_MODE_STANDARD
				/// </java-name>
				[Dot42.DexImport("NAVIGATION_MODE_STANDARD", "I", AccessFlags = 25)]
				public const int NAVIGATION_MODE_STANDARD = 0;
				/// <java-name>
				/// NAVIGATION_MODE_LIST
				/// </java-name>
				[Dot42.DexImport("NAVIGATION_MODE_LIST", "I", AccessFlags = 25)]
				public const int NAVIGATION_MODE_LIST = 1;
				/// <java-name>
				/// NAVIGATION_MODE_TABS
				/// </java-name>
				[Dot42.DexImport("NAVIGATION_MODE_TABS", "I", AccessFlags = 25)]
				public const int NAVIGATION_MODE_TABS = 2;
				/// <java-name>
				/// DISPLAY_USE_LOGO
				/// </java-name>
				[Dot42.DexImport("DISPLAY_USE_LOGO", "I", AccessFlags = 25)]
				public const int DISPLAY_USE_LOGO = 1;
				/// <java-name>
				/// DISPLAY_SHOW_HOME
				/// </java-name>
				[Dot42.DexImport("DISPLAY_SHOW_HOME", "I", AccessFlags = 25)]
				public const int DISPLAY_SHOW_HOME = 2;
				/// <java-name>
				/// DISPLAY_HOME_AS_UP
				/// </java-name>
				[Dot42.DexImport("DISPLAY_HOME_AS_UP", "I", AccessFlags = 25)]
				public const int DISPLAY_HOME_AS_UP = 4;
				/// <java-name>
				/// DISPLAY_SHOW_TITLE
				/// </java-name>
				[Dot42.DexImport("DISPLAY_SHOW_TITLE", "I", AccessFlags = 25)]
				public const int DISPLAY_SHOW_TITLE = 8;
				/// <java-name>
				/// DISPLAY_SHOW_CUSTOM
				/// </java-name>
				[Dot42.DexImport("DISPLAY_SHOW_CUSTOM", "I", AccessFlags = 25)]
				public const int DISPLAY_SHOW_CUSTOM = 16;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ActionBar() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setCustomView
				/// </java-name>
				[Dot42.DexImport("setCustomView", "(Landroid/view/View;Landroid/app/ActionBar$LayoutParams;)V", AccessFlags = 1025)]
				public abstract void SetCustomView(global::Android.Views.View view, global::Android.App.ActionBar.LayoutParams layoutParams) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setCustomView
				/// </java-name>
				[Dot42.DexImport("setCustomView", "(I)V", AccessFlags = 1025)]
				public abstract void SetCustomView(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setIcon
				/// </java-name>
				[Dot42.DexImport("setIcon", "(I)V", AccessFlags = 1025)]
				public abstract void SetIcon(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setIcon
				/// </java-name>
				[Dot42.DexImport("setIcon", "(Landroid/graphics/drawable/Drawable;)V", AccessFlags = 1025)]
				public abstract void SetIcon(global::Android.Graphics.Drawables.Drawable drawable) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setLogo
				/// </java-name>
				[Dot42.DexImport("setLogo", "(I)V", AccessFlags = 1025)]
				public abstract void SetLogo(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setLogo
				/// </java-name>
				[Dot42.DexImport("setLogo", "(Landroid/graphics/drawable/Drawable;)V", AccessFlags = 1025)]
				public abstract void SetLogo(global::Android.Graphics.Drawables.Drawable drawable) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setListNavigationCallbacks
				/// </java-name>
				[Dot42.DexImport("setListNavigationCallbacks", "(Landroid/widget/SpinnerAdapter;Landroid/app/ActionBar$OnNavigationListener;)V", AccessFlags = 1025)]
				public abstract void SetListNavigationCallbacks(global::Android.Widget.ISpinnerAdapter spinnerAdapter, global::Android.App.ActionBar.IOnNavigationListener onNavigationListener) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setSelectedNavigationItem
				/// </java-name>
				[Dot42.DexImport("setSelectedNavigationItem", "(I)V", AccessFlags = 1025)]
				public abstract void SetSelectedNavigationItem(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setTitle
				/// </java-name>
				[Dot42.DexImport("setTitle", "(I)V", AccessFlags = 1025)]
				public abstract void SetTitle(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setSubtitle
				/// </java-name>
				[Dot42.DexImport("setSubtitle", "(I)V", AccessFlags = 1025)]
				public abstract void SetSubtitle(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setDisplayOptions
				/// </java-name>
				[Dot42.DexImport("setDisplayOptions", "(II)V", AccessFlags = 1025)]
				public abstract void SetDisplayOptions(int int32, int int321) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setDisplayUseLogoEnabled
				/// </java-name>
				[Dot42.DexImport("setDisplayUseLogoEnabled", "(Z)V", AccessFlags = 1025)]
				public abstract void SetDisplayUseLogoEnabled(bool boolean) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setDisplayShowHomeEnabled
				/// </java-name>
				[Dot42.DexImport("setDisplayShowHomeEnabled", "(Z)V", AccessFlags = 1025)]
				public abstract void SetDisplayShowHomeEnabled(bool boolean) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setDisplayHomeAsUpEnabled
				/// </java-name>
				[Dot42.DexImport("setDisplayHomeAsUpEnabled", "(Z)V", AccessFlags = 1025)]
				public abstract void SetDisplayHomeAsUpEnabled(bool boolean) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setDisplayShowTitleEnabled
				/// </java-name>
				[Dot42.DexImport("setDisplayShowTitleEnabled", "(Z)V", AccessFlags = 1025)]
				public abstract void SetDisplayShowTitleEnabled(bool boolean) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setDisplayShowCustomEnabled
				/// </java-name>
				[Dot42.DexImport("setDisplayShowCustomEnabled", "(Z)V", AccessFlags = 1025)]
				public abstract void SetDisplayShowCustomEnabled(bool boolean) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setBackgroundDrawable
				/// </java-name>
				[Dot42.DexImport("setBackgroundDrawable", "(Landroid/graphics/drawable/Drawable;)V", AccessFlags = 1025)]
				public abstract void SetBackgroundDrawable(global::Android.Graphics.Drawables.Drawable drawable) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setStackedBackgroundDrawable
				/// </java-name>
				[Dot42.DexImport("setStackedBackgroundDrawable", "(Landroid/graphics/drawable/Drawable;)V", AccessFlags = 1)]
				public virtual void SetStackedBackgroundDrawable(global::Android.Graphics.Drawables.Drawable drawable) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setSplitBackgroundDrawable
				/// </java-name>
				[Dot42.DexImport("setSplitBackgroundDrawable", "(Landroid/graphics/drawable/Drawable;)V", AccessFlags = 1)]
				public virtual void SetSplitBackgroundDrawable(global::Android.Graphics.Drawables.Drawable drawable) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// newTab
				/// </java-name>
				[Dot42.DexImport("newTab", "()Landroid/app/ActionBar$Tab;", AccessFlags = 1025)]
				public abstract global::Android.App.ActionBar.Tab NewTab() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// addTab
				/// </java-name>
				[Dot42.DexImport("addTab", "(Landroid/app/ActionBar$Tab;)V", AccessFlags = 1025)]
				public abstract void AddTab(global::Android.App.ActionBar.Tab tab) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// addTab
				/// </java-name>
				[Dot42.DexImport("addTab", "(Landroid/app/ActionBar$Tab;Z)V", AccessFlags = 1025)]
				public abstract void AddTab(global::Android.App.ActionBar.Tab tab, bool boolean) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// addTab
				/// </java-name>
				[Dot42.DexImport("addTab", "(Landroid/app/ActionBar$Tab;I)V", AccessFlags = 1025)]
				public abstract void AddTab(global::Android.App.ActionBar.Tab tab, int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// addTab
				/// </java-name>
				[Dot42.DexImport("addTab", "(Landroid/app/ActionBar$Tab;IZ)V", AccessFlags = 1025)]
				public abstract void AddTab(global::Android.App.ActionBar.Tab tab, int int32, bool boolean) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// removeTab
				/// </java-name>
				[Dot42.DexImport("removeTab", "(Landroid/app/ActionBar$Tab;)V", AccessFlags = 1025)]
				public abstract void RemoveTab(global::Android.App.ActionBar.Tab tab) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// removeTabAt
				/// </java-name>
				[Dot42.DexImport("removeTabAt", "(I)V", AccessFlags = 1025)]
				public abstract void RemoveTabAt(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// removeAllTabs
				/// </java-name>
				[Dot42.DexImport("removeAllTabs", "()V", AccessFlags = 1025)]
				public abstract void RemoveAllTabs() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// selectTab
				/// </java-name>
				[Dot42.DexImport("selectTab", "(Landroid/app/ActionBar$Tab;)V", AccessFlags = 1025)]
				public abstract void SelectTab(global::Android.App.ActionBar.Tab tab) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getTabAt
				/// </java-name>
				[Dot42.DexImport("getTabAt", "(I)Landroid/app/ActionBar$Tab;", AccessFlags = 1025)]
				public abstract global::Android.App.ActionBar.Tab GetTabAt(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// show
				/// </java-name>
				[Dot42.DexImport("show", "()V", AccessFlags = 1025)]
				public abstract void Show() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// hide
				/// </java-name>
				[Dot42.DexImport("hide", "()V", AccessFlags = 1025)]
				public abstract void Hide() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// addOnMenuVisibilityListener
				/// </java-name>
				[Dot42.DexImport("addOnMenuVisibilityListener", "(Landroid/app/ActionBar$OnMenuVisibilityListener;)V", AccessFlags = 1025)]
				public abstract void AddOnMenuVisibilityListener(global::Android.App.ActionBar.IOnMenuVisibilityListener onMenuVisibilityListener) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// removeOnMenuVisibilityListener
				/// </java-name>
				[Dot42.DexImport("removeOnMenuVisibilityListener", "(Landroid/app/ActionBar$OnMenuVisibilityListener;)V", AccessFlags = 1025)]
				public abstract void RemoveOnMenuVisibilityListener(global::Android.App.ActionBar.IOnMenuVisibilityListener onMenuVisibilityListener) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setHomeButtonEnabled
				/// </java-name>
				[Dot42.DexImport("setHomeButtonEnabled", "(Z)V", AccessFlags = 1)]
				public virtual void SetHomeButtonEnabled(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getSelectedNavigationIndex
				/// </java-name>
				public abstract int SelectedNavigationIndex
				{
						[Dot42.DexImport("getSelectedNavigationIndex", "()I", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getNavigationItemCount
				/// </java-name>
				public abstract int NavigationItemCount
				{
						[Dot42.DexImport("getNavigationItemCount", "()I", AccessFlags = 1025)]
						get;
				}

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

				/// <java-name>
				/// getSelectedTab
				/// </java-name>
				public abstract global::Android.App.ActionBar.Tab SelectedTab
				{
						[Dot42.DexImport("getSelectedTab", "()Landroid/app/ActionBar$Tab;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getTabCount
				/// </java-name>
				public abstract int TabCount
				{
						[Dot42.DexImport("getTabCount", "()I", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getHeight
				/// </java-name>
				public abstract int Height
				{
						[Dot42.DexImport("getHeight", "()I", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// isShowing
				/// </java-name>
				public abstract bool IsShowing
				{
						[Dot42.DexImport("isShowing", "()Z", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getThemedContext
				/// </java-name>
				public virtual global::Android.Content.Context ThemedContext
				{
						[Dot42.DexImport("getThemedContext", "()Landroid/content/Context;", AccessFlags = 1)]
						get{ return default(global::Android.Content.Context); }
				}

				/// <java-name>
				/// android/app/ActionBar$LayoutParams
				/// </java-name>
				[Dot42.DexImport("android/app/ActionBar$LayoutParams", AccessFlags = 9)]
				public partial class LayoutParams : global::Android.Views.ViewGroup.MarginLayoutParams
 /* scope: __dot42__ */ 
				{
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

				/// <java-name>
				/// android/app/ActionBar$TabListener
				/// </java-name>
				[Dot42.DexImport("android/app/ActionBar$TabListener", AccessFlags = 1545)]
				public partial interface ITabListener
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onTabSelected
						/// </java-name>
						[Dot42.DexImport("onTabSelected", "(Landroid/app/ActionBar$Tab;Landroid/app/FragmentTransaction;)V", AccessFlags = 1025)]
						void OnTabSelected(global::Android.App.ActionBar.Tab tab, global::Android.App.FragmentTransaction fragmentTransaction) /* MethodBuilder.Create */ ;

						/// <java-name>
						/// onTabUnselected
						/// </java-name>
						[Dot42.DexImport("onTabUnselected", "(Landroid/app/ActionBar$Tab;Landroid/app/FragmentTransaction;)V", AccessFlags = 1025)]
						void OnTabUnselected(global::Android.App.ActionBar.Tab tab, global::Android.App.FragmentTransaction fragmentTransaction) /* MethodBuilder.Create */ ;

						/// <java-name>
						/// onTabReselected
						/// </java-name>
						[Dot42.DexImport("onTabReselected", "(Landroid/app/ActionBar$Tab;Landroid/app/FragmentTransaction;)V", AccessFlags = 1025)]
						void OnTabReselected(global::Android.App.ActionBar.Tab tab, global::Android.App.FragmentTransaction fragmentTransaction) /* MethodBuilder.Create */ ;

				}

				/// <java-name>
				/// android/app/ActionBar$Tab
				/// </java-name>
				[Dot42.DexImport("android/app/ActionBar$Tab", AccessFlags = 1033)]
				public abstract partial class Tab
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// INVALID_POSITION
						/// </java-name>
						[Dot42.DexImport("INVALID_POSITION", "I", AccessFlags = 25)]
						public const int INVALID_POSITION = -1;
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public Tab() /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// setIcon
						/// </java-name>
						[Dot42.DexImport("setIcon", "(Landroid/graphics/drawable/Drawable;)Landroid/app/ActionBar$Tab;", AccessFlags = 1025)]
						public abstract Tab SetIcon(global::Android.Graphics.Drawables.Drawable drawable) /* MethodBuilder.Create */ ;

						/// <java-name>
						/// setIcon
						/// </java-name>
						[Dot42.DexImport("setIcon", "(I)Landroid/app/ActionBar$Tab;", AccessFlags = 1025)]
						public abstract Tab SetIcon(int int32) /* MethodBuilder.Create */ ;

						/// <java-name>
						/// setText
						/// </java-name>
						[Dot42.DexImport("setText", "(Ljava/lang/CharSequence;)Landroid/app/ActionBar$Tab;", AccessFlags = 1025)]
						public abstract Tab SetText(global::Java.Lang.ICharSequence charSequence) /* MethodBuilder.Create */ ;

						/// <java-name>
						/// setText
						/// </java-name>
						[Dot42.DexImport("setText", "(I)Landroid/app/ActionBar$Tab;", AccessFlags = 1025)]
						public abstract Tab SetText(int int32) /* MethodBuilder.Create */ ;

						/// <java-name>
						/// setCustomView
						/// </java-name>
						[Dot42.DexImport("setCustomView", "(Landroid/view/View;)Landroid/app/ActionBar$Tab;", AccessFlags = 1025)]
						public abstract Tab SetCustomView(global::Android.Views.View view) /* MethodBuilder.Create */ ;

						/// <java-name>
						/// setCustomView
						/// </java-name>
						[Dot42.DexImport("setCustomView", "(I)Landroid/app/ActionBar$Tab;", AccessFlags = 1025)]
						public abstract Tab SetCustomView(int int32) /* MethodBuilder.Create */ ;

						/// <java-name>
						/// setTag
						/// </java-name>
						[Dot42.DexImport("setTag", "(Ljava/lang/Object;)Landroid/app/ActionBar$Tab;", AccessFlags = 1025)]
						public abstract Tab SetTag(object @object) /* MethodBuilder.Create */ ;

						/// <java-name>
						/// setTabListener
						/// </java-name>
						[Dot42.DexImport("setTabListener", "(Landroid/app/ActionBar$TabListener;)Landroid/app/ActionBar$Tab;", AccessFlags = 1025)]
						public abstract Tab SetTabListener(global::Android.App.ActionBar.ITabListener tabListener) /* MethodBuilder.Create */ ;

						/// <java-name>
						/// select
						/// </java-name>
						[Dot42.DexImport("select", "()V", AccessFlags = 1025)]
						public abstract void Select() /* MethodBuilder.Create */ ;

						/// <java-name>
						/// setContentDescription
						/// </java-name>
						[Dot42.DexImport("setContentDescription", "(I)Landroid/app/ActionBar$Tab;", AccessFlags = 1025)]
						public abstract Tab SetContentDescription(int int32) /* MethodBuilder.Create */ ;

						/// <java-name>
						/// setContentDescription
						/// </java-name>
						[Dot42.DexImport("setContentDescription", "(Ljava/lang/CharSequence;)Landroid/app/ActionBar$Tab;", AccessFlags = 1025)]
						public abstract Tab SetContentDescription(global::Java.Lang.ICharSequence charSequence) /* MethodBuilder.Create */ ;

						/// <java-name>
						/// getPosition
						/// </java-name>
						public abstract int Position
						{
								[Dot42.DexImport("getPosition", "()I", AccessFlags = 1025)]
								get;
						}

						/// <java-name>
						/// getIcon
						/// </java-name>
						public abstract global::Android.Graphics.Drawables.Drawable Icon
						{
								[Dot42.DexImport("getIcon", "()Landroid/graphics/drawable/Drawable;", AccessFlags = 1025)]
								get;
						}

						/// <java-name>
						/// getText
						/// </java-name>
						public abstract global::Java.Lang.ICharSequence Text
						{
								[Dot42.DexImport("getText", "()Ljava/lang/CharSequence;", AccessFlags = 1025)]
								get;
						}

						/// <java-name>
						/// getCustomView
						/// </java-name>
						public abstract global::Android.Views.View CustomView
						{
								[Dot42.DexImport("getCustomView", "()Landroid/view/View;", AccessFlags = 1025)]
								get;
						}

						/// <java-name>
						/// getTag
						/// </java-name>
						public abstract object Tag
						{
								[Dot42.DexImport("getTag", "()Ljava/lang/Object;", AccessFlags = 1025)]
								get;
						}

						/// <java-name>
						/// getContentDescription
						/// </java-name>
						public abstract global::Java.Lang.ICharSequence ContentDescription
						{
								[Dot42.DexImport("getContentDescription", "()Ljava/lang/CharSequence;", AccessFlags = 1025)]
								get;
						}

				}

				/// <java-name>
				/// android/app/ActionBar$OnMenuVisibilityListener
				/// </java-name>
				[Dot42.DexImport("android/app/ActionBar$OnMenuVisibilityListener", AccessFlags = 1545)]
				public partial interface IOnMenuVisibilityListener
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onMenuVisibilityChanged
						/// </java-name>
						[Dot42.DexImport("onMenuVisibilityChanged", "(Z)V", AccessFlags = 1025)]
						void OnMenuVisibilityChanged(bool boolean) /* MethodBuilder.Create */ ;

				}

				/// <java-name>
				/// android/app/ActionBar$OnNavigationListener
				/// </java-name>
				[Dot42.DexImport("android/app/ActionBar$OnNavigationListener", AccessFlags = 1545)]
				public partial interface IOnNavigationListener
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onNavigationItemSelected
						/// </java-name>
						[Dot42.DexImport("onNavigationItemSelected", "(IJ)Z", AccessFlags = 1025)]
						bool OnNavigationItemSelected(int int32, long int64) /* MethodBuilder.Create */ ;

				}

		}

		/// <java-name>
		/// android/app/Activity
		/// </java-name>
		[Dot42.DexImport("android/app/Activity", AccessFlags = 33)]
		public partial class Activity : global::Android.Views.ContextThemeWrapper, global::Android.Views.LayoutInflater.IFactory2, global::Android.Views.Window.ICallback, global::Android.Views.KeyEvent.ICallback, global::Android.Views.View.IOnCreateContextMenuListener, global::Android.Content.IComponentCallbacks2
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// RESULT_CANCELED
				/// </java-name>
				[Dot42.DexImport("RESULT_CANCELED", "I", AccessFlags = 25)]
				public const int RESULT_CANCELED = 0;
				/// <java-name>
				/// RESULT_OK
				/// </java-name>
				[Dot42.DexImport("RESULT_OK", "I", AccessFlags = 25)]
				public const int RESULT_OK = -1;
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
				/// <java-name>
				/// DEFAULT_KEYS_DISABLE
				/// </java-name>
				[Dot42.DexImport("DEFAULT_KEYS_DISABLE", "I", AccessFlags = 25)]
				public const int DEFAULT_KEYS_DISABLE = 0;
				/// <java-name>
				/// DEFAULT_KEYS_DIALER
				/// </java-name>
				[Dot42.DexImport("DEFAULT_KEYS_DIALER", "I", AccessFlags = 25)]
				public const int DEFAULT_KEYS_DIALER = 1;
				/// <java-name>
				/// DEFAULT_KEYS_SHORTCUT
				/// </java-name>
				[Dot42.DexImport("DEFAULT_KEYS_SHORTCUT", "I", AccessFlags = 25)]
				public const int DEFAULT_KEYS_SHORTCUT = 2;
				/// <java-name>
				/// DEFAULT_KEYS_SEARCH_LOCAL
				/// </java-name>
				[Dot42.DexImport("DEFAULT_KEYS_SEARCH_LOCAL", "I", AccessFlags = 25)]
				public const int DEFAULT_KEYS_SEARCH_LOCAL = 3;
				/// <java-name>
				/// DEFAULT_KEYS_SEARCH_GLOBAL
				/// </java-name>
				[Dot42.DexImport("DEFAULT_KEYS_SEARCH_GLOBAL", "I", AccessFlags = 25)]
				public const int DEFAULT_KEYS_SEARCH_GLOBAL = 4;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Activity() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onCreate
				/// </java-name>
				[Dot42.DexImport("onCreate", "(Landroid/os/Bundle;)V", AccessFlags = 4)]
				protected internal virtual void OnCreate(global::Android.OS.Bundle bundle) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onRestoreInstanceState
				/// </java-name>
				[Dot42.DexImport("onRestoreInstanceState", "(Landroid/os/Bundle;)V", AccessFlags = 4)]
				protected internal virtual void OnRestoreInstanceState(global::Android.OS.Bundle bundle) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onPostCreate
				/// </java-name>
				[Dot42.DexImport("onPostCreate", "(Landroid/os/Bundle;)V", AccessFlags = 4)]
				protected internal virtual void OnPostCreate(global::Android.OS.Bundle bundle) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onStart
				/// </java-name>
				[Dot42.DexImport("onStart", "()V", AccessFlags = 4)]
				protected internal virtual void OnStart() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onRestart
				/// </java-name>
				[Dot42.DexImport("onRestart", "()V", AccessFlags = 4)]
				protected internal virtual void OnRestart() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onResume
				/// </java-name>
				[Dot42.DexImport("onResume", "()V", AccessFlags = 4)]
				protected internal virtual void OnResume() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onPostResume
				/// </java-name>
				[Dot42.DexImport("onPostResume", "()V", AccessFlags = 4)]
				protected internal virtual void OnPostResume() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onNewIntent
				/// </java-name>
				[Dot42.DexImport("onNewIntent", "(Landroid/content/Intent;)V", AccessFlags = 4)]
				protected internal virtual void OnNewIntent(global::Android.Content.Intent intent) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onSaveInstanceState
				/// </java-name>
				[Dot42.DexImport("onSaveInstanceState", "(Landroid/os/Bundle;)V", AccessFlags = 4)]
				protected internal virtual void OnSaveInstanceState(global::Android.OS.Bundle bundle) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onPause
				/// </java-name>
				[Dot42.DexImport("onPause", "()V", AccessFlags = 4)]
				protected internal virtual void OnPause() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onUserLeaveHint
				/// </java-name>
				[Dot42.DexImport("onUserLeaveHint", "()V", AccessFlags = 4)]
				protected internal virtual void OnUserLeaveHint() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onCreateThumbnail
				/// </java-name>
				[Dot42.DexImport("onCreateThumbnail", "(Landroid/graphics/Bitmap;Landroid/graphics/Canvas;)Z", AccessFlags = 1)]
				public virtual bool OnCreateThumbnail(global::Android.Graphics.Bitmap bitmap, global::Android.Graphics.Canvas canvas) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onCreateDescription
				/// </java-name>
				[Dot42.DexImport("onCreateDescription", "()Ljava/lang/CharSequence;", AccessFlags = 1)]
				public virtual global::Java.Lang.ICharSequence OnCreateDescription() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <java-name>
				/// onStop
				/// </java-name>
				[Dot42.DexImport("onStop", "()V", AccessFlags = 4)]
				protected internal virtual void OnStop() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onDestroy
				/// </java-name>
				[Dot42.DexImport("onDestroy", "()V", AccessFlags = 4)]
				protected internal virtual void OnDestroy() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onConfigurationChanged
				/// </java-name>
				[Dot42.DexImport("onConfigurationChanged", "(Landroid/content/res/Configuration;)V", AccessFlags = 1)]
				public virtual void OnConfigurationChanged(global::Android.Content.Res.Configuration configuration) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onRetainNonConfigurationInstance
				/// </java-name>
				[Dot42.DexImport("onRetainNonConfigurationInstance", "()Ljava/lang/Object;", AccessFlags = 1)]
				public virtual object OnRetainNonConfigurationInstance() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <java-name>
				/// onLowMemory
				/// </java-name>
				[Dot42.DexImport("onLowMemory", "()V", AccessFlags = 1)]
				public virtual void OnLowMemory() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onTrimMemory
				/// </java-name>
				[Dot42.DexImport("onTrimMemory", "(I)V", AccessFlags = 1)]
				public virtual void OnTrimMemory(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onAttachFragment
				/// </java-name>
				[Dot42.DexImport("onAttachFragment", "(Landroid/app/Fragment;)V", AccessFlags = 1)]
				public virtual void OnAttachFragment(global::Android.App.Fragment fragment) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// managedQuery
				/// </java-name>
				[Dot42.DexImport("managedQuery", "(Landroid/net/Uri;[Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/l" +
    "ang/String;)Landroid/database/Cursor;", AccessFlags = 17)]
				public global::Android.Database.ICursor ManagedQuery(global::Android.Net.Uri uri, string[] @string, string string1, string[] string2, string string3) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Database.ICursor);
				}

				/// <java-name>
				/// startManagingCursor
				/// </java-name>
				[Dot42.DexImport("startManagingCursor", "(Landroid/database/Cursor;)V", AccessFlags = 1)]
				public virtual void StartManagingCursor(global::Android.Database.ICursor cursor) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// stopManagingCursor
				/// </java-name>
				[Dot42.DexImport("stopManagingCursor", "(Landroid/database/Cursor;)V", AccessFlags = 1)]
				public virtual void StopManagingCursor(global::Android.Database.ICursor cursor) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// findViewById
				/// </java-name>
				[Dot42.DexImport("findViewById", "(I)Landroid/view/View;", AccessFlags = 1)]
				public virtual global::Android.Views.View FindViewById(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.View);
				}

				/// <java-name>
				/// setContentView
				/// </java-name>
				[Dot42.DexImport("setContentView", "(I)V", AccessFlags = 1)]
				public virtual void SetContentView(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setContentView
				/// </java-name>
				[Dot42.DexImport("setContentView", "(Landroid/view/View;)V", AccessFlags = 1)]
				public virtual void SetContentView(global::Android.Views.View view) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setContentView
				/// </java-name>
				[Dot42.DexImport("setContentView", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V", AccessFlags = 1)]
				public virtual void SetContentView(global::Android.Views.View view, global::Android.Views.ViewGroup.LayoutParams layoutParams) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addContentView
				/// </java-name>
				[Dot42.DexImport("addContentView", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V", AccessFlags = 1)]
				public virtual void AddContentView(global::Android.Views.View view, global::Android.Views.ViewGroup.LayoutParams layoutParams) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setFinishOnTouchOutside
				/// </java-name>
				[Dot42.DexImport("setFinishOnTouchOutside", "(Z)V", AccessFlags = 1)]
				public virtual void SetFinishOnTouchOutside(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setDefaultKeyMode
				/// </java-name>
				[Dot42.DexImport("setDefaultKeyMode", "(I)V", AccessFlags = 17)]
				public void SetDefaultKeyMode(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onKeyDown
				/// </java-name>
				[Dot42.DexImport("onKeyDown", "(ILandroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public virtual bool OnKeyDown(int int32, global::Android.Views.KeyEvent keyEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onKeyLongPress
				/// </java-name>
				[Dot42.DexImport("onKeyLongPress", "(ILandroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public virtual bool OnKeyLongPress(int int32, global::Android.Views.KeyEvent keyEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onKeyUp
				/// </java-name>
				[Dot42.DexImport("onKeyUp", "(ILandroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public virtual bool OnKeyUp(int int32, global::Android.Views.KeyEvent keyEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onKeyMultiple
				/// </java-name>
				[Dot42.DexImport("onKeyMultiple", "(IILandroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public virtual bool OnKeyMultiple(int int32, int int321, global::Android.Views.KeyEvent keyEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onBackPressed
				/// </java-name>
				[Dot42.DexImport("onBackPressed", "()V", AccessFlags = 1)]
				public virtual void OnBackPressed() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onKeyShortcut
				/// </java-name>
				[Dot42.DexImport("onKeyShortcut", "(ILandroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public virtual bool OnKeyShortcut(int int32, global::Android.Views.KeyEvent keyEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onTouchEvent
				/// </java-name>
				[Dot42.DexImport("onTouchEvent", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1)]
				public virtual bool OnTouchEvent(global::Android.Views.MotionEvent motionEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onTrackballEvent
				/// </java-name>
				[Dot42.DexImport("onTrackballEvent", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1)]
				public virtual bool OnTrackballEvent(global::Android.Views.MotionEvent motionEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onGenericMotionEvent
				/// </java-name>
				[Dot42.DexImport("onGenericMotionEvent", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1)]
				public virtual bool OnGenericMotionEvent(global::Android.Views.MotionEvent motionEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

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
				public virtual void OnWindowAttributesChanged(global::Android.Views.IWindowManager_LayoutParams iWindowManager_LayoutParams) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onContentChanged
				/// </java-name>
				[Dot42.DexImport("onContentChanged", "()V", AccessFlags = 1)]
				public virtual void OnContentChanged() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onWindowFocusChanged
				/// </java-name>
				[Dot42.DexImport("onWindowFocusChanged", "(Z)V", AccessFlags = 1)]
				public virtual void OnWindowFocusChanged(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onAttachedToWindow
				/// </java-name>
				[Dot42.DexImport("onAttachedToWindow", "()V", AccessFlags = 1)]
				public virtual void OnAttachedToWindow() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onDetachedFromWindow
				/// </java-name>
				[Dot42.DexImport("onDetachedFromWindow", "()V", AccessFlags = 1)]
				public virtual void OnDetachedFromWindow() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// dispatchKeyEvent
				/// </java-name>
				[Dot42.DexImport("dispatchKeyEvent", "(Landroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public virtual bool DispatchKeyEvent(global::Android.Views.KeyEvent keyEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// dispatchKeyShortcutEvent
				/// </java-name>
				[Dot42.DexImport("dispatchKeyShortcutEvent", "(Landroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public virtual bool DispatchKeyShortcutEvent(global::Android.Views.KeyEvent keyEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// dispatchTouchEvent
				/// </java-name>
				[Dot42.DexImport("dispatchTouchEvent", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1)]
				public virtual bool DispatchTouchEvent(global::Android.Views.MotionEvent motionEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// dispatchTrackballEvent
				/// </java-name>
				[Dot42.DexImport("dispatchTrackballEvent", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1)]
				public virtual bool DispatchTrackballEvent(global::Android.Views.MotionEvent motionEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// dispatchGenericMotionEvent
				/// </java-name>
				[Dot42.DexImport("dispatchGenericMotionEvent", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1)]
				public virtual bool DispatchGenericMotionEvent(global::Android.Views.MotionEvent motionEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// dispatchPopulateAccessibilityEvent
				/// </java-name>
				[Dot42.DexImport("dispatchPopulateAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)Z", AccessFlags = 1)]
				public virtual bool DispatchPopulateAccessibilityEvent(global::Android.Views.Accessibility.AccessibilityEvent accessibilityEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onCreatePanelView
				/// </java-name>
				[Dot42.DexImport("onCreatePanelView", "(I)Landroid/view/View;", AccessFlags = 1)]
				public virtual global::Android.Views.View OnCreatePanelView(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.View);
				}

				/// <java-name>
				/// onCreatePanelMenu
				/// </java-name>
				[Dot42.DexImport("onCreatePanelMenu", "(ILandroid/view/Menu;)Z", AccessFlags = 1)]
				public virtual bool OnCreatePanelMenu(int int32, global::Android.Views.IMenu menu) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onPreparePanel
				/// </java-name>
				[Dot42.DexImport("onPreparePanel", "(ILandroid/view/View;Landroid/view/Menu;)Z", AccessFlags = 1)]
				public virtual bool OnPreparePanel(int int32, global::Android.Views.View view, global::Android.Views.IMenu menu) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onMenuOpened
				/// </java-name>
				[Dot42.DexImport("onMenuOpened", "(ILandroid/view/Menu;)Z", AccessFlags = 1)]
				public virtual bool OnMenuOpened(int int32, global::Android.Views.IMenu menu) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onMenuItemSelected
				/// </java-name>
				[Dot42.DexImport("onMenuItemSelected", "(ILandroid/view/MenuItem;)Z", AccessFlags = 1)]
				public virtual bool OnMenuItemSelected(int int32, global::Android.Views.IMenuItem menuItem) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onPanelClosed
				/// </java-name>
				[Dot42.DexImport("onPanelClosed", "(ILandroid/view/Menu;)V", AccessFlags = 1)]
				public virtual void OnPanelClosed(int int32, global::Android.Views.IMenu menu) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// invalidateOptionsMenu
				/// </java-name>
				[Dot42.DexImport("invalidateOptionsMenu", "()V", AccessFlags = 1)]
				public virtual void InvalidateOptionsMenu() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onCreateOptionsMenu
				/// </java-name>
				[Dot42.DexImport("onCreateOptionsMenu", "(Landroid/view/Menu;)Z", AccessFlags = 1)]
				public virtual bool OnCreateOptionsMenu(global::Android.Views.IMenu menu) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onPrepareOptionsMenu
				/// </java-name>
				[Dot42.DexImport("onPrepareOptionsMenu", "(Landroid/view/Menu;)Z", AccessFlags = 1)]
				public virtual bool OnPrepareOptionsMenu(global::Android.Views.IMenu menu) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onOptionsItemSelected
				/// </java-name>
				[Dot42.DexImport("onOptionsItemSelected", "(Landroid/view/MenuItem;)Z", AccessFlags = 1)]
				public virtual bool OnOptionsItemSelected(global::Android.Views.IMenuItem menuItem) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onOptionsMenuClosed
				/// </java-name>
				[Dot42.DexImport("onOptionsMenuClosed", "(Landroid/view/Menu;)V", AccessFlags = 1)]
				public virtual void OnOptionsMenuClosed(global::Android.Views.IMenu menu) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// openOptionsMenu
				/// </java-name>
				[Dot42.DexImport("openOptionsMenu", "()V", AccessFlags = 1)]
				public virtual void OpenOptionsMenu() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// closeOptionsMenu
				/// </java-name>
				[Dot42.DexImport("closeOptionsMenu", "()V", AccessFlags = 1)]
				public virtual void CloseOptionsMenu() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onCreateContextMenu
				/// </java-name>
				[Dot42.DexImport("onCreateContextMenu", "(Landroid/view/ContextMenu;Landroid/view/View;Landroid/view/ContextMenu$ContextMe" +
    "nuInfo;)V", AccessFlags = 1)]
				public virtual void OnCreateContextMenu(global::Android.Views.IContextMenu contextMenu, global::Android.Views.View view, global::Android.Views.IContextMenu_IContextMenuInfo contextMenu_IContextMenuInfo) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// registerForContextMenu
				/// </java-name>
				[Dot42.DexImport("registerForContextMenu", "(Landroid/view/View;)V", AccessFlags = 1)]
				public virtual void RegisterForContextMenu(global::Android.Views.View view) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// unregisterForContextMenu
				/// </java-name>
				[Dot42.DexImport("unregisterForContextMenu", "(Landroid/view/View;)V", AccessFlags = 1)]
				public virtual void UnregisterForContextMenu(global::Android.Views.View view) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// openContextMenu
				/// </java-name>
				[Dot42.DexImport("openContextMenu", "(Landroid/view/View;)V", AccessFlags = 1)]
				public virtual void OpenContextMenu(global::Android.Views.View view) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// closeContextMenu
				/// </java-name>
				[Dot42.DexImport("closeContextMenu", "()V", AccessFlags = 1)]
				public virtual void CloseContextMenu() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onContextItemSelected
				/// </java-name>
				[Dot42.DexImport("onContextItemSelected", "(Landroid/view/MenuItem;)Z", AccessFlags = 1)]
				public virtual bool OnContextItemSelected(global::Android.Views.IMenuItem menuItem) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onContextMenuClosed
				/// </java-name>
				[Dot42.DexImport("onContextMenuClosed", "(Landroid/view/Menu;)V", AccessFlags = 1)]
				public virtual void OnContextMenuClosed(global::Android.Views.IMenu menu) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onCreateDialog
				/// </java-name>
				[Dot42.DexImport("onCreateDialog", "(I)Landroid/app/Dialog;", AccessFlags = 4)]
				protected internal virtual global::Android.App.Dialog OnCreateDialog(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.App.Dialog);
				}

				/// <java-name>
				/// onCreateDialog
				/// </java-name>
				[Dot42.DexImport("onCreateDialog", "(ILandroid/os/Bundle;)Landroid/app/Dialog;", AccessFlags = 4)]
				protected internal virtual global::Android.App.Dialog OnCreateDialog(int int32, global::Android.OS.Bundle bundle) /* MethodBuilder.Create */ 
				{
						return default(global::Android.App.Dialog);
				}

				/// <java-name>
				/// onPrepareDialog
				/// </java-name>
				[Dot42.DexImport("onPrepareDialog", "(ILandroid/app/Dialog;)V", AccessFlags = 4)]
				protected internal virtual void OnPrepareDialog(int int32, global::Android.App.Dialog dialog) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onPrepareDialog
				/// </java-name>
				[Dot42.DexImport("onPrepareDialog", "(ILandroid/app/Dialog;Landroid/os/Bundle;)V", AccessFlags = 4)]
				protected internal virtual void OnPrepareDialog(int int32, global::Android.App.Dialog dialog, global::Android.OS.Bundle bundle) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// showDialog
				/// </java-name>
				[Dot42.DexImport("showDialog", "(I)V", AccessFlags = 17)]
				public void ShowDialog(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// showDialog
				/// </java-name>
				[Dot42.DexImport("showDialog", "(ILandroid/os/Bundle;)Z", AccessFlags = 17)]
				public bool ShowDialog(int int32, global::Android.OS.Bundle bundle) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// dismissDialog
				/// </java-name>
				[Dot42.DexImport("dismissDialog", "(I)V", AccessFlags = 17)]
				public void DismissDialog(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// removeDialog
				/// </java-name>
				[Dot42.DexImport("removeDialog", "(I)V", AccessFlags = 17)]
				public void RemoveDialog(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onSearchRequested
				/// </java-name>
				[Dot42.DexImport("onSearchRequested", "()Z", AccessFlags = 1)]
				public virtual bool OnSearchRequested() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// startSearch
				/// </java-name>
				[Dot42.DexImport("startSearch", "(Ljava/lang/String;ZLandroid/os/Bundle;Z)V", AccessFlags = 1)]
				public virtual void StartSearch(string @string, bool boolean, global::Android.OS.Bundle bundle, bool boolean1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// triggerSearch
				/// </java-name>
				[Dot42.DexImport("triggerSearch", "(Ljava/lang/String;Landroid/os/Bundle;)V", AccessFlags = 1)]
				public virtual void TriggerSearch(string @string, global::Android.OS.Bundle bundle) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// takeKeyEvents
				/// </java-name>
				[Dot42.DexImport("takeKeyEvents", "(Z)V", AccessFlags = 1)]
				public virtual void TakeKeyEvents(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// requestWindowFeature
				/// </java-name>
				[Dot42.DexImport("requestWindowFeature", "(I)Z", AccessFlags = 17)]
				public bool RequestWindowFeature(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setFeatureDrawableResource
				/// </java-name>
				[Dot42.DexImport("setFeatureDrawableResource", "(II)V", AccessFlags = 17)]
				public void SetFeatureDrawableResource(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setFeatureDrawableUri
				/// </java-name>
				[Dot42.DexImport("setFeatureDrawableUri", "(ILandroid/net/Uri;)V", AccessFlags = 17)]
				public void SetFeatureDrawableUri(int int32, global::Android.Net.Uri uri) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setFeatureDrawable
				/// </java-name>
				[Dot42.DexImport("setFeatureDrawable", "(ILandroid/graphics/drawable/Drawable;)V", AccessFlags = 17)]
				public void SetFeatureDrawable(int int32, global::Android.Graphics.Drawables.Drawable drawable) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setFeatureDrawableAlpha
				/// </java-name>
				[Dot42.DexImport("setFeatureDrawableAlpha", "(II)V", AccessFlags = 17)]
				public void SetFeatureDrawableAlpha(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onApplyThemeResource
				/// </java-name>
				[Dot42.DexImport("onApplyThemeResource", "(Landroid/content/res/Resources$Theme;IZ)V", AccessFlags = 4)]
				protected internal override void OnApplyThemeResource(global::Android.Content.Res.Resources.Theme theme, int int32, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// startActivityForResult
				/// </java-name>
				[Dot42.DexImport("startActivityForResult", "(Landroid/content/Intent;I)V", AccessFlags = 1)]
				public virtual void StartActivityForResult(global::Android.Content.Intent intent, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// startIntentSenderForResult
				/// </java-name>
				[Dot42.DexImport("startIntentSenderForResult", "(Landroid/content/IntentSender;ILandroid/content/Intent;III)V", AccessFlags = 1)]
				public virtual void StartIntentSenderForResult(global::Android.Content.IntentSender intentSender, int int32, global::Android.Content.Intent intent, int int321, int int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// startActivity
				/// </java-name>
				[Dot42.DexImport("startActivity", "(Landroid/content/Intent;)V", AccessFlags = 1)]
				public override void StartActivity(global::Android.Content.Intent intent) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// startActivities
				/// </java-name>
				[Dot42.DexImport("startActivities", "([Landroid/content/Intent;)V", AccessFlags = 1)]
				public override void StartActivities(global::Android.Content.Intent[] intent) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// startIntentSender
				/// </java-name>
				[Dot42.DexImport("startIntentSender", "(Landroid/content/IntentSender;Landroid/content/Intent;III)V", AccessFlags = 1)]
				public override void StartIntentSender(global::Android.Content.IntentSender intentSender, global::Android.Content.Intent intent, int int32, int int321, int int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// startActivityIfNeeded
				/// </java-name>
				[Dot42.DexImport("startActivityIfNeeded", "(Landroid/content/Intent;I)Z", AccessFlags = 1)]
				public virtual bool StartActivityIfNeeded(global::Android.Content.Intent intent, int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// startNextMatchingActivity
				/// </java-name>
				[Dot42.DexImport("startNextMatchingActivity", "(Landroid/content/Intent;)Z", AccessFlags = 1)]
				public virtual bool StartNextMatchingActivity(global::Android.Content.Intent intent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// startActivityFromChild
				/// </java-name>
				[Dot42.DexImport("startActivityFromChild", "(Landroid/app/Activity;Landroid/content/Intent;I)V", AccessFlags = 1)]
				public virtual void StartActivityFromChild(global::Android.App.Activity activity, global::Android.Content.Intent intent, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// startActivityFromFragment
				/// </java-name>
				[Dot42.DexImport("startActivityFromFragment", "(Landroid/app/Fragment;Landroid/content/Intent;I)V", AccessFlags = 1)]
				public virtual void StartActivityFromFragment(global::Android.App.Fragment fragment, global::Android.Content.Intent intent, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// startIntentSenderFromChild
				/// </java-name>
				[Dot42.DexImport("startIntentSenderFromChild", "(Landroid/app/Activity;Landroid/content/IntentSender;ILandroid/content/Intent;III" +
    ")V", AccessFlags = 1)]
				public virtual void StartIntentSenderFromChild(global::Android.App.Activity activity, global::Android.Content.IntentSender intentSender, int int32, global::Android.Content.Intent intent, int int321, int int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// overridePendingTransition
				/// </java-name>
				[Dot42.DexImport("overridePendingTransition", "(II)V", AccessFlags = 1)]
				public virtual void OverridePendingTransition(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setResult
				/// </java-name>
				[Dot42.DexImport("setResult", "(I)V", AccessFlags = 17)]
				public void SetResult(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setResult
				/// </java-name>
				[Dot42.DexImport("setResult", "(ILandroid/content/Intent;)V", AccessFlags = 17)]
				public void SetResult(int int32, global::Android.Content.Intent intent) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setVisible
				/// </java-name>
				[Dot42.DexImport("setVisible", "(Z)V", AccessFlags = 1)]
				public virtual void SetVisible(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// recreate
				/// </java-name>
				[Dot42.DexImport("recreate", "()V", AccessFlags = 1)]
				public virtual void Recreate() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// finish
				/// </java-name>
				[Dot42.DexImport("finish", "()V", AccessFlags = 1)]
				public virtual void Finish() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// finishFromChild
				/// </java-name>
				[Dot42.DexImport("finishFromChild", "(Landroid/app/Activity;)V", AccessFlags = 1)]
				public virtual void FinishFromChild(global::Android.App.Activity activity) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// finishActivity
				/// </java-name>
				[Dot42.DexImport("finishActivity", "(I)V", AccessFlags = 1)]
				public virtual void FinishActivity(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// finishActivityFromChild
				/// </java-name>
				[Dot42.DexImport("finishActivityFromChild", "(Landroid/app/Activity;I)V", AccessFlags = 1)]
				public virtual void FinishActivityFromChild(global::Android.App.Activity activity, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onActivityResult
				/// </java-name>
				[Dot42.DexImport("onActivityResult", "(IILandroid/content/Intent;)V", AccessFlags = 4)]
				protected internal virtual void OnActivityResult(int int32, int int321, global::Android.Content.Intent intent) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// createPendingResult
				/// </java-name>
				[Dot42.DexImport("createPendingResult", "(ILandroid/content/Intent;I)Landroid/app/PendingIntent;", AccessFlags = 1)]
				public virtual global::Android.App.PendingIntent CreatePendingResult(int int32, global::Android.Content.Intent intent, int int321) /* MethodBuilder.Create */ 
				{
						return default(global::Android.App.PendingIntent);
				}

				/// <java-name>
				/// moveTaskToBack
				/// </java-name>
				[Dot42.DexImport("moveTaskToBack", "(Z)Z", AccessFlags = 1)]
				public virtual bool MoveTaskToBack(bool boolean) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getPreferences
				/// </java-name>
				[Dot42.DexImport("getPreferences", "(I)Landroid/content/SharedPreferences;", AccessFlags = 1)]
				public virtual global::Android.Content.ISharedPreferences GetPreferences(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.ISharedPreferences);
				}

				/// <java-name>
				/// getSystemService
				/// </java-name>
				[Dot42.DexImport("getSystemService", "(Ljava/lang/String;)Ljava/lang/Object;", AccessFlags = 1)]
				public override object GetSystemService(string @string) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <java-name>
				/// setTitle
				/// </java-name>
				[Dot42.DexImport("setTitle", "(Ljava/lang/CharSequence;)V", AccessFlags = 1)]
				public virtual void SetTitle(global::Java.Lang.ICharSequence charSequence) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setTitle
				/// </java-name>
				[Dot42.DexImport("setTitle", "(I)V", AccessFlags = 1)]
				public virtual void SetTitle(int int32) /* MethodBuilder.Create */ 
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
				protected internal virtual void OnTitleChanged(global::Java.Lang.ICharSequence charSequence, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onChildTitleChanged
				/// </java-name>
				[Dot42.DexImport("onChildTitleChanged", "(Landroid/app/Activity;Ljava/lang/CharSequence;)V", AccessFlags = 4)]
				protected internal virtual void OnChildTitleChanged(global::Android.App.Activity activity, global::Java.Lang.ICharSequence charSequence) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setProgressBarVisibility
				/// </java-name>
				[Dot42.DexImport("setProgressBarVisibility", "(Z)V", AccessFlags = 17)]
				public void SetProgressBarVisibility(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setProgressBarIndeterminateVisibility
				/// </java-name>
				[Dot42.DexImport("setProgressBarIndeterminateVisibility", "(Z)V", AccessFlags = 17)]
				public void SetProgressBarIndeterminateVisibility(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setProgressBarIndeterminate
				/// </java-name>
				[Dot42.DexImport("setProgressBarIndeterminate", "(Z)V", AccessFlags = 17)]
				public void SetProgressBarIndeterminate(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setProgress
				/// </java-name>
				[Dot42.DexImport("setProgress", "(I)V", AccessFlags = 17)]
				public void SetProgress(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setSecondaryProgress
				/// </java-name>
				[Dot42.DexImport("setSecondaryProgress", "(I)V", AccessFlags = 17)]
				public void SetSecondaryProgress(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// runOnUiThread
				/// </java-name>
				[Dot42.DexImport("runOnUiThread", "(Ljava/lang/Runnable;)V", AccessFlags = 17)]
				public void RunOnUiThread(global::Java.Lang.IRunnable runnable) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onCreateView
				/// </java-name>
				[Dot42.DexImport("onCreateView", "(Ljava/lang/String;Landroid/content/Context;Landroid/util/AttributeSet;)Landroid/" +
    "view/View;", AccessFlags = 1)]
				public virtual global::Android.Views.View OnCreateView(string @string, global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.View);
				}

				/// <java-name>
				/// onCreateView
				/// </java-name>
				[Dot42.DexImport("onCreateView", "(Landroid/view/View;Ljava/lang/String;Landroid/content/Context;Landroid/util/Attr" +
    "ibuteSet;)Landroid/view/View;", AccessFlags = 1)]
				public virtual global::Android.Views.View OnCreateView(global::Android.Views.View view, string @string, global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.View);
				}

				/// <java-name>
				/// dump
				/// </java-name>
				[Dot42.DexImport("dump", "(Ljava/lang/String;Ljava/io/FileDescriptor;Ljava/io/PrintWriter;[Ljava/lang/Strin" +
    "g;)V", AccessFlags = 1)]
				public virtual void Dump(string @string, global::Java.IO.FileDescriptor fileDescriptor, global::Java.IO.PrintWriter printWriter, string[] string1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// startActionMode
				/// </java-name>
				[Dot42.DexImport("startActionMode", "(Landroid/view/ActionMode$Callback;)Landroid/view/ActionMode;", AccessFlags = 1)]
				public virtual global::Android.Views.ActionMode StartActionMode(global::Android.Views.ActionMode.ICallback callback) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.ActionMode);
				}

				/// <java-name>
				/// onWindowStartingActionMode
				/// </java-name>
				[Dot42.DexImport("onWindowStartingActionMode", "(Landroid/view/ActionMode$Callback;)Landroid/view/ActionMode;", AccessFlags = 1)]
				public virtual global::Android.Views.ActionMode OnWindowStartingActionMode(global::Android.Views.ActionMode.ICallback callback) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.ActionMode);
				}

				/// <java-name>
				/// onActionModeStarted
				/// </java-name>
				[Dot42.DexImport("onActionModeStarted", "(Landroid/view/ActionMode;)V", AccessFlags = 1)]
				public virtual void OnActionModeStarted(global::Android.Views.ActionMode actionMode) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onActionModeFinished
				/// </java-name>
				[Dot42.DexImport("onActionModeFinished", "(Landroid/view/ActionMode;)V", AccessFlags = 1)]
				public virtual void OnActionModeFinished(global::Android.Views.ActionMode actionMode) /* MethodBuilder.Create */ 
				{
				}

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

				/// <java-name>
				/// getApplication
				/// </java-name>
				public global::Android.App.Application Application
				{
						[Dot42.DexImport("getApplication", "()Landroid/app/Application;", AccessFlags = 17)]
						get{ return default(global::Android.App.Application); }
				}

				/// <java-name>
				/// isChild
				/// </java-name>
				public bool IsChild
				{
						[Dot42.DexImport("isChild", "()Z", AccessFlags = 17)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// getParent
				/// </java-name>
				public global::Android.App.Activity Parent
				{
						[Dot42.DexImport("getParent", "()Landroid/app/Activity;", AccessFlags = 17)]
						get{ return default(global::Android.App.Activity); }
				}

				/// <java-name>
				/// getWindowManager
				/// </java-name>
				public virtual global::Android.Views.IWindowManager WindowManager
				{
						[Dot42.DexImport("getWindowManager", "()Landroid/view/WindowManager;", AccessFlags = 1)]
						get{ return default(global::Android.Views.IWindowManager); }
				}

				/// <java-name>
				/// getWindow
				/// </java-name>
				public virtual global::Android.Views.Window Window
				{
						[Dot42.DexImport("getWindow", "()Landroid/view/Window;", AccessFlags = 1)]
						get{ return default(global::Android.Views.Window); }
				}

				/// <java-name>
				/// getLoaderManager
				/// </java-name>
				public virtual global::Android.App.LoaderManager LoaderManager
				{
						[Dot42.DexImport("getLoaderManager", "()Landroid/app/LoaderManager;", AccessFlags = 1)]
						get{ return default(global::Android.App.LoaderManager); }
				}

				/// <java-name>
				/// getCurrentFocus
				/// </java-name>
				public virtual global::Android.Views.View CurrentFocus
				{
						[Dot42.DexImport("getCurrentFocus", "()Landroid/view/View;", AccessFlags = 1)]
						get{ return default(global::Android.Views.View); }
				}

				/// <java-name>
				/// getChangingConfigurations
				/// </java-name>
				public virtual int ChangingConfigurations
				{
						[Dot42.DexImport("getChangingConfigurations", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getLastNonConfigurationInstance
				/// </java-name>
				public virtual object LastNonConfigurationInstance
				{
						[Dot42.DexImport("getLastNonConfigurationInstance", "()Ljava/lang/Object;", AccessFlags = 1)]
						get{ return default(object); }
				}

				/// <java-name>
				/// getFragmentManager
				/// </java-name>
				public virtual global::Android.App.FragmentManager FragmentManager
				{
						[Dot42.DexImport("getFragmentManager", "()Landroid/app/FragmentManager;", AccessFlags = 1)]
						get{ return default(global::Android.App.FragmentManager); }
				}

				/// <java-name>
				/// getActionBar
				/// </java-name>
				public virtual global::Android.App.ActionBar ActionBar
				{
						[Dot42.DexImport("getActionBar", "()Landroid/app/ActionBar;", AccessFlags = 1)]
						get{ return default(global::Android.App.ActionBar); }
				}

				/// <java-name>
				/// hasWindowFocus
				/// </java-name>
				public virtual bool HasWindowFocus
				{
						[Dot42.DexImport("hasWindowFocus", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// getLayoutInflater
				/// </java-name>
				public virtual global::Android.Views.LayoutInflater LayoutInflater
				{
						[Dot42.DexImport("getLayoutInflater", "()Landroid/view/LayoutInflater;", AccessFlags = 1)]
						get{ return default(global::Android.Views.LayoutInflater); }
				}

				/// <java-name>
				/// getMenuInflater
				/// </java-name>
				public virtual global::Android.Views.MenuInflater MenuInflater
				{
						[Dot42.DexImport("getMenuInflater", "()Landroid/view/MenuInflater;", AccessFlags = 1)]
						get{ return default(global::Android.Views.MenuInflater); }
				}

				/// <java-name>
				/// getCallingPackage
				/// </java-name>
				public virtual string CallingPackage
				{
						[Dot42.DexImport("getCallingPackage", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getCallingActivity
				/// </java-name>
				public virtual global::Android.Content.ComponentName CallingActivity
				{
						[Dot42.DexImport("getCallingActivity", "()Landroid/content/ComponentName;", AccessFlags = 1)]
						get{ return default(global::Android.Content.ComponentName); }
				}

				/// <java-name>
				/// isFinishing
				/// </java-name>
				public virtual bool IsFinishing
				{
						[Dot42.DexImport("isFinishing", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// isChangingConfigurations
				/// </java-name>
				public virtual bool IsChangingConfigurations
				{
						[Dot42.DexImport("isChangingConfigurations", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

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

				/// <java-name>
				/// getTaskId
				/// </java-name>
				public virtual int TaskId
				{
						[Dot42.DexImport("getTaskId", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// isTaskRoot
				/// </java-name>
				public virtual bool IsTaskRoot
				{
						[Dot42.DexImport("isTaskRoot", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// getLocalClassName
				/// </java-name>
				public virtual string LocalClassName
				{
						[Dot42.DexImport("getLocalClassName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

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
				public ActivityGroup(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onCreate
				/// </java-name>
				[Dot42.DexImport("onCreate", "(Landroid/os/Bundle;)V", AccessFlags = 4)]
				protected internal override void OnCreate(global::Android.OS.Bundle bundle) /* MethodBuilder.Create */ 
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
				protected internal override void OnSaveInstanceState(global::Android.OS.Bundle bundle) /* MethodBuilder.Create */ 
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

		/// <java-name>
		/// android/app/ActivityManager
		/// </java-name>
		[Dot42.DexImport("android/app/ActivityManager", AccessFlags = 33)]
		public partial class ActivityManager
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// RECENT_WITH_EXCLUDED
				/// </java-name>
				[Dot42.DexImport("RECENT_WITH_EXCLUDED", "I", AccessFlags = 25)]
				public const int RECENT_WITH_EXCLUDED = 1;
				/// <java-name>
				/// RECENT_IGNORE_UNAVAILABLE
				/// </java-name>
				[Dot42.DexImport("RECENT_IGNORE_UNAVAILABLE", "I", AccessFlags = 25)]
				public const int RECENT_IGNORE_UNAVAILABLE = 2;
				/// <java-name>
				/// MOVE_TASK_WITH_HOME
				/// </java-name>
				[Dot42.DexImport("MOVE_TASK_WITH_HOME", "I", AccessFlags = 25)]
				public const int MOVE_TASK_WITH_HOME = 1;
				/// <java-name>
				/// MOVE_TASK_NO_USER_ACTION
				/// </java-name>
				[Dot42.DexImport("MOVE_TASK_NO_USER_ACTION", "I", AccessFlags = 25)]
				public const int MOVE_TASK_NO_USER_ACTION = 2;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal ActivityManager() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getRecentTasks
				/// </java-name>
				[Dot42.DexImport("getRecentTasks", "(II)Ljava/util/List;", AccessFlags = 1, Signature = "(II)Ljava/util/List<Landroid/app/ActivityManager$RecentTaskInfo;>;")]
				public virtual global::Java.Util.IList<global::Android.App.ActivityManager.RecentTaskInfo> GetRecentTasks(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<global::Android.App.ActivityManager.RecentTaskInfo>);
				}

				/// <java-name>
				/// getRunningTasks
				/// </java-name>
				[Dot42.DexImport("getRunningTasks", "(I)Ljava/util/List;", AccessFlags = 1, Signature = "(I)Ljava/util/List<Landroid/app/ActivityManager$RunningTaskInfo;>;")]
				public virtual global::Java.Util.IList<global::Android.App.ActivityManager.RunningTaskInfo> GetRunningTasks(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<global::Android.App.ActivityManager.RunningTaskInfo>);
				}

				/// <java-name>
				/// moveTaskToFront
				/// </java-name>
				[Dot42.DexImport("moveTaskToFront", "(II)V", AccessFlags = 1)]
				public virtual void MoveTaskToFront(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getRunningServices
				/// </java-name>
				[Dot42.DexImport("getRunningServices", "(I)Ljava/util/List;", AccessFlags = 1, Signature = "(I)Ljava/util/List<Landroid/app/ActivityManager$RunningServiceInfo;>;")]
				public virtual global::Java.Util.IList<global::Android.App.ActivityManager.RunningServiceInfo> GetRunningServices(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<global::Android.App.ActivityManager.RunningServiceInfo>);
				}

				/// <java-name>
				/// getRunningServiceControlPanel
				/// </java-name>
				[Dot42.DexImport("getRunningServiceControlPanel", "(Landroid/content/ComponentName;)Landroid/app/PendingIntent;", AccessFlags = 1)]
				public virtual global::Android.App.PendingIntent GetRunningServiceControlPanel(global::Android.Content.ComponentName componentName) /* MethodBuilder.Create */ 
				{
						return default(global::Android.App.PendingIntent);
				}

				/// <java-name>
				/// getMemoryInfo
				/// </java-name>
				[Dot42.DexImport("getMemoryInfo", "(Landroid/app/ActivityManager$MemoryInfo;)V", AccessFlags = 1)]
				public virtual void GetMemoryInfo(global::Android.App.ActivityManager.MemoryInfo memoryInfo) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getProcessMemoryInfo
				/// </java-name>
				[Dot42.DexImport("getProcessMemoryInfo", "([I)[Landroid/os/Debug$MemoryInfo;", AccessFlags = 1)]
				public virtual global::Android.OS.Debug.MemoryInfo[] GetProcessMemoryInfo(int[] int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.Debug.MemoryInfo[]);
				}

				/// <java-name>
				/// restartPackage
				/// </java-name>
				[Dot42.DexImport("restartPackage", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void RestartPackage(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// killBackgroundProcesses
				/// </java-name>
				[Dot42.DexImport("killBackgroundProcesses", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void KillBackgroundProcesses(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getMemoryClass
				/// </java-name>
				public virtual int MemoryClass
				{
						[Dot42.DexImport("getMemoryClass", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getLargeMemoryClass
				/// </java-name>
				public virtual int LargeMemoryClass
				{
						[Dot42.DexImport("getLargeMemoryClass", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getProcessesInErrorState
				/// </java-name>
				public virtual global::Java.Util.IList<global::Android.App.ActivityManager.ProcessErrorStateInfo> ProcessesInErrorState
				{
						[Dot42.DexImport("getProcessesInErrorState", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Landroid/app/ActivityManager$ProcessErrorStateInfo;>;")]
						get{ return default(global::Java.Util.IList<global::Android.App.ActivityManager.ProcessErrorStateInfo>); }
				}

				/// <java-name>
				/// getRunningAppProcesses
				/// </java-name>
				public virtual global::Java.Util.IList<global::Android.App.ActivityManager.RunningAppProcessInfo> RunningAppProcesses
				{
						[Dot42.DexImport("getRunningAppProcesses", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Landroid/app/ActivityManager$RunningAppProcessInfo;>;")]
						get{ return default(global::Java.Util.IList<global::Android.App.ActivityManager.RunningAppProcessInfo>); }
				}

				/// <java-name>
				/// getDeviceConfigurationInfo
				/// </java-name>
				public virtual global::Android.Content.PM.ConfigurationInfo DeviceConfigurationInfo
				{
						[Dot42.DexImport("getDeviceConfigurationInfo", "()Landroid/content/pm/ConfigurationInfo;", AccessFlags = 1)]
						get{ return default(global::Android.Content.PM.ConfigurationInfo); }
				}

				/// <java-name>
				/// getLauncherLargeIconDensity
				/// </java-name>
				public virtual int LauncherLargeIconDensity
				{
						[Dot42.DexImport("getLauncherLargeIconDensity", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getLauncherLargeIconSize
				/// </java-name>
				public virtual int LauncherLargeIconSize
				{
						[Dot42.DexImport("getLauncherLargeIconSize", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// isUserAMonkey
				/// </java-name>
				public static bool IsUserAMonkey
				{
						[Dot42.DexImport("isUserAMonkey", "()Z", AccessFlags = 9)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// isRunningInTestHarness
				/// </java-name>
				public static bool IsRunningInTestHarness
				{
						[Dot42.DexImport("isRunningInTestHarness", "()Z", AccessFlags = 9)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// android/app/ActivityManager$RunningAppProcessInfo
				/// </java-name>
				[Dot42.DexImport("android/app/ActivityManager$RunningAppProcessInfo", AccessFlags = 9)]
				public partial class RunningAppProcessInfo : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// processName
						/// </java-name>
						[Dot42.DexImport("processName", "Ljava/lang/String;", AccessFlags = 1)]
						public string ProcessName;
						/// <java-name>
						/// pid
						/// </java-name>
						[Dot42.DexImport("pid", "I", AccessFlags = 1)]
						public int Pid;
						/// <java-name>
						/// uid
						/// </java-name>
						[Dot42.DexImport("uid", "I", AccessFlags = 1)]
						public int Uid;
						/// <java-name>
						/// pkgList
						/// </java-name>
						[Dot42.DexImport("pkgList", "[Ljava/lang/String;", AccessFlags = 1)]
						public string[] PkgList;
						/// <java-name>
						/// IMPORTANCE_FOREGROUND
						/// </java-name>
						[Dot42.DexImport("IMPORTANCE_FOREGROUND", "I", AccessFlags = 25)]
						public const int IMPORTANCE_FOREGROUND = 100;
						/// <java-name>
						/// IMPORTANCE_VISIBLE
						/// </java-name>
						[Dot42.DexImport("IMPORTANCE_VISIBLE", "I", AccessFlags = 25)]
						public const int IMPORTANCE_VISIBLE = 200;
						/// <java-name>
						/// IMPORTANCE_PERCEPTIBLE
						/// </java-name>
						[Dot42.DexImport("IMPORTANCE_PERCEPTIBLE", "I", AccessFlags = 25)]
						public const int IMPORTANCE_PERCEPTIBLE = 130;
						/// <java-name>
						/// IMPORTANCE_SERVICE
						/// </java-name>
						[Dot42.DexImport("IMPORTANCE_SERVICE", "I", AccessFlags = 25)]
						public const int IMPORTANCE_SERVICE = 300;
						/// <java-name>
						/// IMPORTANCE_BACKGROUND
						/// </java-name>
						[Dot42.DexImport("IMPORTANCE_BACKGROUND", "I", AccessFlags = 25)]
						public const int IMPORTANCE_BACKGROUND = 400;
						/// <java-name>
						/// IMPORTANCE_EMPTY
						/// </java-name>
						[Dot42.DexImport("IMPORTANCE_EMPTY", "I", AccessFlags = 25)]
						public const int IMPORTANCE_EMPTY = 500;
						/// <java-name>
						/// importance
						/// </java-name>
						[Dot42.DexImport("importance", "I", AccessFlags = 1)]
						public int Importance;
						/// <java-name>
						/// lru
						/// </java-name>
						[Dot42.DexImport("lru", "I", AccessFlags = 1)]
						public int Lru;
						/// <java-name>
						/// REASON_UNKNOWN
						/// </java-name>
						[Dot42.DexImport("REASON_UNKNOWN", "I", AccessFlags = 25)]
						public const int REASON_UNKNOWN = 0;
						/// <java-name>
						/// REASON_PROVIDER_IN_USE
						/// </java-name>
						[Dot42.DexImport("REASON_PROVIDER_IN_USE", "I", AccessFlags = 25)]
						public const int REASON_PROVIDER_IN_USE = 1;
						/// <java-name>
						/// REASON_SERVICE_IN_USE
						/// </java-name>
						[Dot42.DexImport("REASON_SERVICE_IN_USE", "I", AccessFlags = 25)]
						public const int REASON_SERVICE_IN_USE = 2;
						/// <java-name>
						/// importanceReasonCode
						/// </java-name>
						[Dot42.DexImport("importanceReasonCode", "I", AccessFlags = 1)]
						public int ImportanceReasonCode;
						/// <java-name>
						/// importanceReasonPid
						/// </java-name>
						[Dot42.DexImport("importanceReasonPid", "I", AccessFlags = 1)]
						public int ImportanceReasonPid;
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

						/// <java-name>
						/// describeContents
						/// </java-name>
						[Dot42.DexImport("describeContents", "()I", AccessFlags = 1)]
						public virtual int DescribeContents() /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <java-name>
						/// writeToParcel
						/// </java-name>
						[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
						public virtual void WriteToParcel(global::Android.OS.Parcel parcel, int int32) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// readFromParcel
						/// </java-name>
						[Dot42.DexImport("readFromParcel", "(Landroid/os/Parcel;)V", AccessFlags = 1)]
						public virtual void ReadFromParcel(global::Android.OS.Parcel parcel) /* MethodBuilder.Create */ 
						{
						}

				}

				/// <java-name>
				/// android/app/ActivityManager$ProcessErrorStateInfo
				/// </java-name>
				[Dot42.DexImport("android/app/ActivityManager$ProcessErrorStateInfo", AccessFlags = 9)]
				public partial class ProcessErrorStateInfo : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
				{
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
						/// <java-name>
						/// condition
						/// </java-name>
						[Dot42.DexImport("condition", "I", AccessFlags = 1)]
						public int Condition;
						/// <java-name>
						/// processName
						/// </java-name>
						[Dot42.DexImport("processName", "Ljava/lang/String;", AccessFlags = 1)]
						public string ProcessName;
						/// <java-name>
						/// pid
						/// </java-name>
						[Dot42.DexImport("pid", "I", AccessFlags = 1)]
						public int Pid;
						/// <java-name>
						/// uid
						/// </java-name>
						[Dot42.DexImport("uid", "I", AccessFlags = 1)]
						public int Uid;
						/// <java-name>
						/// tag
						/// </java-name>
						[Dot42.DexImport("tag", "Ljava/lang/String;", AccessFlags = 1)]
						public string Tag;
						/// <java-name>
						/// shortMsg
						/// </java-name>
						[Dot42.DexImport("shortMsg", "Ljava/lang/String;", AccessFlags = 1)]
						public string ShortMsg;
						/// <java-name>
						/// longMsg
						/// </java-name>
						[Dot42.DexImport("longMsg", "Ljava/lang/String;", AccessFlags = 1)]
						public string LongMsg;
						/// <java-name>
						/// stackTrace
						/// </java-name>
						[Dot42.DexImport("stackTrace", "Ljava/lang/String;", AccessFlags = 1)]
						public string StackTrace;
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

						/// <java-name>
						/// describeContents
						/// </java-name>
						[Dot42.DexImport("describeContents", "()I", AccessFlags = 1)]
						public virtual int DescribeContents() /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <java-name>
						/// writeToParcel
						/// </java-name>
						[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
						public virtual void WriteToParcel(global::Android.OS.Parcel parcel, int int32) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// readFromParcel
						/// </java-name>
						[Dot42.DexImport("readFromParcel", "(Landroid/os/Parcel;)V", AccessFlags = 1)]
						public virtual void ReadFromParcel(global::Android.OS.Parcel parcel) /* MethodBuilder.Create */ 
						{
						}

				}

				/// <java-name>
				/// android/app/ActivityManager$MemoryInfo
				/// </java-name>
				[Dot42.DexImport("android/app/ActivityManager$MemoryInfo", AccessFlags = 9)]
				public partial class MemoryInfo : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// availMem
						/// </java-name>
						[Dot42.DexImport("availMem", "J", AccessFlags = 1)]
						public long AvailMem;
						/// <java-name>
						/// threshold
						/// </java-name>
						[Dot42.DexImport("threshold", "J", AccessFlags = 1)]
						public long Threshold;
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

						/// <java-name>
						/// describeContents
						/// </java-name>
						[Dot42.DexImport("describeContents", "()I", AccessFlags = 1)]
						public virtual int DescribeContents() /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <java-name>
						/// writeToParcel
						/// </java-name>
						[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
						public virtual void WriteToParcel(global::Android.OS.Parcel parcel, int int32) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// readFromParcel
						/// </java-name>
						[Dot42.DexImport("readFromParcel", "(Landroid/os/Parcel;)V", AccessFlags = 1)]
						public virtual void ReadFromParcel(global::Android.OS.Parcel parcel) /* MethodBuilder.Create */ 
						{
						}

				}

				/// <java-name>
				/// android/app/ActivityManager$RunningServiceInfo
				/// </java-name>
				[Dot42.DexImport("android/app/ActivityManager$RunningServiceInfo", AccessFlags = 9)]
				public partial class RunningServiceInfo : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// service
						/// </java-name>
						[Dot42.DexImport("service", "Landroid/content/ComponentName;", AccessFlags = 1)]
						public global::Android.Content.ComponentName Service;
						/// <java-name>
						/// pid
						/// </java-name>
						[Dot42.DexImport("pid", "I", AccessFlags = 1)]
						public int Pid;
						/// <java-name>
						/// uid
						/// </java-name>
						[Dot42.DexImport("uid", "I", AccessFlags = 1)]
						public int Uid;
						/// <java-name>
						/// process
						/// </java-name>
						[Dot42.DexImport("process", "Ljava/lang/String;", AccessFlags = 1)]
						public string Process;
						/// <java-name>
						/// foreground
						/// </java-name>
						[Dot42.DexImport("foreground", "Z", AccessFlags = 1)]
						public bool Foreground;
						/// <java-name>
						/// activeSince
						/// </java-name>
						[Dot42.DexImport("activeSince", "J", AccessFlags = 1)]
						public long ActiveSince;
						/// <java-name>
						/// started
						/// </java-name>
						[Dot42.DexImport("started", "Z", AccessFlags = 1)]
						public bool Started;
						/// <java-name>
						/// clientCount
						/// </java-name>
						[Dot42.DexImport("clientCount", "I", AccessFlags = 1)]
						public int ClientCount;
						/// <java-name>
						/// crashCount
						/// </java-name>
						[Dot42.DexImport("crashCount", "I", AccessFlags = 1)]
						public int CrashCount;
						/// <java-name>
						/// lastActivityTime
						/// </java-name>
						[Dot42.DexImport("lastActivityTime", "J", AccessFlags = 1)]
						public long LastActivityTime;
						/// <java-name>
						/// restarting
						/// </java-name>
						[Dot42.DexImport("restarting", "J", AccessFlags = 1)]
						public long Restarting;
						/// <java-name>
						/// FLAG_STARTED
						/// </java-name>
						[Dot42.DexImport("FLAG_STARTED", "I", AccessFlags = 25)]
						public const int FLAG_STARTED = 1;
						/// <java-name>
						/// FLAG_FOREGROUND
						/// </java-name>
						[Dot42.DexImport("FLAG_FOREGROUND", "I", AccessFlags = 25)]
						public const int FLAG_FOREGROUND = 2;
						/// <java-name>
						/// FLAG_SYSTEM_PROCESS
						/// </java-name>
						[Dot42.DexImport("FLAG_SYSTEM_PROCESS", "I", AccessFlags = 25)]
						public const int FLAG_SYSTEM_PROCESS = 4;
						/// <java-name>
						/// FLAG_PERSISTENT_PROCESS
						/// </java-name>
						[Dot42.DexImport("FLAG_PERSISTENT_PROCESS", "I", AccessFlags = 25)]
						public const int FLAG_PERSISTENT_PROCESS = 8;
						/// <java-name>
						/// flags
						/// </java-name>
						[Dot42.DexImport("flags", "I", AccessFlags = 1)]
						public int Flags;
						/// <java-name>
						/// clientPackage
						/// </java-name>
						[Dot42.DexImport("clientPackage", "Ljava/lang/String;", AccessFlags = 1)]
						public string ClientPackage;
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

						/// <java-name>
						/// describeContents
						/// </java-name>
						[Dot42.DexImport("describeContents", "()I", AccessFlags = 1)]
						public virtual int DescribeContents() /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <java-name>
						/// writeToParcel
						/// </java-name>
						[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
						public virtual void WriteToParcel(global::Android.OS.Parcel parcel, int int32) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// readFromParcel
						/// </java-name>
						[Dot42.DexImport("readFromParcel", "(Landroid/os/Parcel;)V", AccessFlags = 1)]
						public virtual void ReadFromParcel(global::Android.OS.Parcel parcel) /* MethodBuilder.Create */ 
						{
						}

				}

				/// <java-name>
				/// android/app/ActivityManager$RunningTaskInfo
				/// </java-name>
				[Dot42.DexImport("android/app/ActivityManager$RunningTaskInfo", AccessFlags = 9)]
				public partial class RunningTaskInfo : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// id
						/// </java-name>
						[Dot42.DexImport("id", "I", AccessFlags = 1)]
						public int Id;
						/// <java-name>
						/// baseActivity
						/// </java-name>
						[Dot42.DexImport("baseActivity", "Landroid/content/ComponentName;", AccessFlags = 1)]
						public global::Android.Content.ComponentName BaseActivity;
						/// <java-name>
						/// topActivity
						/// </java-name>
						[Dot42.DexImport("topActivity", "Landroid/content/ComponentName;", AccessFlags = 1)]
						public global::Android.Content.ComponentName TopActivity;
						/// <java-name>
						/// thumbnail
						/// </java-name>
						[Dot42.DexImport("thumbnail", "Landroid/graphics/Bitmap;", AccessFlags = 1)]
						public global::Android.Graphics.Bitmap Thumbnail;
						/// <java-name>
						/// description
						/// </java-name>
						[Dot42.DexImport("description", "Ljava/lang/CharSequence;", AccessFlags = 1)]
						public global::Java.Lang.ICharSequence Description;
						/// <java-name>
						/// numActivities
						/// </java-name>
						[Dot42.DexImport("numActivities", "I", AccessFlags = 1)]
						public int NumActivities;
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

						/// <java-name>
						/// describeContents
						/// </java-name>
						[Dot42.DexImport("describeContents", "()I", AccessFlags = 1)]
						public virtual int DescribeContents() /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <java-name>
						/// writeToParcel
						/// </java-name>
						[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
						public virtual void WriteToParcel(global::Android.OS.Parcel parcel, int int32) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// readFromParcel
						/// </java-name>
						[Dot42.DexImport("readFromParcel", "(Landroid/os/Parcel;)V", AccessFlags = 1)]
						public virtual void ReadFromParcel(global::Android.OS.Parcel parcel) /* MethodBuilder.Create */ 
						{
						}

				}

				/// <java-name>
				/// android/app/ActivityManager$RecentTaskInfo
				/// </java-name>
				[Dot42.DexImport("android/app/ActivityManager$RecentTaskInfo", AccessFlags = 9)]
				public partial class RecentTaskInfo : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// id
						/// </java-name>
						[Dot42.DexImport("id", "I", AccessFlags = 1)]
						public int Id;
						/// <java-name>
						/// persistentId
						/// </java-name>
						[Dot42.DexImport("persistentId", "I", AccessFlags = 1)]
						public int PersistentId;
						/// <java-name>
						/// baseIntent
						/// </java-name>
						[Dot42.DexImport("baseIntent", "Landroid/content/Intent;", AccessFlags = 1)]
						public global::Android.Content.Intent BaseIntent;
						/// <java-name>
						/// origActivity
						/// </java-name>
						[Dot42.DexImport("origActivity", "Landroid/content/ComponentName;", AccessFlags = 1)]
						public global::Android.Content.ComponentName OrigActivity;
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

						/// <java-name>
						/// describeContents
						/// </java-name>
						[Dot42.DexImport("describeContents", "()I", AccessFlags = 1)]
						public virtual int DescribeContents() /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <java-name>
						/// writeToParcel
						/// </java-name>
						[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
						public virtual void WriteToParcel(global::Android.OS.Parcel parcel, int int32) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// readFromParcel
						/// </java-name>
						[Dot42.DexImport("readFromParcel", "(Landroid/os/Parcel;)V", AccessFlags = 1)]
						public virtual void ReadFromParcel(global::Android.OS.Parcel parcel) /* MethodBuilder.Create */ 
						{
						}

				}

		}

		/// <java-name>
		/// android/app/AlarmManager
		/// </java-name>
		[Dot42.DexImport("android/app/AlarmManager", AccessFlags = 33)]
		public partial class AlarmManager
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// RTC_WAKEUP
				/// </java-name>
				[Dot42.DexImport("RTC_WAKEUP", "I", AccessFlags = 25)]
				public const int RTC_WAKEUP = 0;
				/// <java-name>
				/// RTC
				/// </java-name>
				[Dot42.DexImport("RTC", "I", AccessFlags = 25)]
				public const int RTC = 1;
				/// <java-name>
				/// ELAPSED_REALTIME_WAKEUP
				/// </java-name>
				[Dot42.DexImport("ELAPSED_REALTIME_WAKEUP", "I", AccessFlags = 25)]
				public const int ELAPSED_REALTIME_WAKEUP = 2;
				/// <java-name>
				/// ELAPSED_REALTIME
				/// </java-name>
				[Dot42.DexImport("ELAPSED_REALTIME", "I", AccessFlags = 25)]
				public const int ELAPSED_REALTIME = 3;
				/// <java-name>
				/// INTERVAL_FIFTEEN_MINUTES
				/// </java-name>
				[Dot42.DexImport("INTERVAL_FIFTEEN_MINUTES", "J", AccessFlags = 25)]
				public const long INTERVAL_FIFTEEN_MINUTES = 900000;
				/// <java-name>
				/// INTERVAL_HALF_HOUR
				/// </java-name>
				[Dot42.DexImport("INTERVAL_HALF_HOUR", "J", AccessFlags = 25)]
				public const long INTERVAL_HALF_HOUR = 1800000;
				/// <java-name>
				/// INTERVAL_HOUR
				/// </java-name>
				[Dot42.DexImport("INTERVAL_HOUR", "J", AccessFlags = 25)]
				public const long INTERVAL_HOUR = 3600000;
				/// <java-name>
				/// INTERVAL_HALF_DAY
				/// </java-name>
				[Dot42.DexImport("INTERVAL_HALF_DAY", "J", AccessFlags = 25)]
				public const long INTERVAL_HALF_DAY = 43200000;
				/// <java-name>
				/// INTERVAL_DAY
				/// </java-name>
				[Dot42.DexImport("INTERVAL_DAY", "J", AccessFlags = 25)]
				public const long INTERVAL_DAY = 86400000;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal AlarmManager() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// set
				/// </java-name>
				[Dot42.DexImport("set", "(IJLandroid/app/PendingIntent;)V", AccessFlags = 1)]
				public virtual void Set(int int32, long int64, global::Android.App.PendingIntent pendingIntent) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setRepeating
				/// </java-name>
				[Dot42.DexImport("setRepeating", "(IJJLandroid/app/PendingIntent;)V", AccessFlags = 1)]
				public virtual void SetRepeating(int int32, long int64, long int641, global::Android.App.PendingIntent pendingIntent) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setInexactRepeating
				/// </java-name>
				[Dot42.DexImport("setInexactRepeating", "(IJJLandroid/app/PendingIntent;)V", AccessFlags = 1)]
				public virtual void SetInexactRepeating(int int32, long int64, long int641, global::Android.App.PendingIntent pendingIntent) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// cancel
				/// </java-name>
				[Dot42.DexImport("cancel", "(Landroid/app/PendingIntent;)V", AccessFlags = 1)]
				public virtual void Cancel(global::Android.App.PendingIntent pendingIntent) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setTime
				/// </java-name>
				[Dot42.DexImport("setTime", "(J)V", AccessFlags = 1)]
				public virtual void SetTime(long int64) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setTimeZone
				/// </java-name>
				[Dot42.DexImport("setTimeZone", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetTimeZone(string @string) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// android/app/AlertDialog
		/// </java-name>
		[Dot42.DexImport("android/app/AlertDialog", AccessFlags = 33)]
		public partial class AlertDialog : global::Android.App.Dialog, global::Android.Content.IDialogInterface
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// THEME_TRADITIONAL
				/// </java-name>
				[Dot42.DexImport("THEME_TRADITIONAL", "I", AccessFlags = 25)]
				public const int THEME_TRADITIONAL = 1;
				/// <java-name>
				/// THEME_HOLO_DARK
				/// </java-name>
				[Dot42.DexImport("THEME_HOLO_DARK", "I", AccessFlags = 25)]
				public const int THEME_HOLO_DARK = 2;
				/// <java-name>
				/// THEME_HOLO_LIGHT
				/// </java-name>
				[Dot42.DexImport("THEME_HOLO_LIGHT", "I", AccessFlags = 25)]
				public const int THEME_HOLO_LIGHT = 3;
				/// <java-name>
				/// THEME_DEVICE_DEFAULT_DARK
				/// </java-name>
				[Dot42.DexImport("THEME_DEVICE_DEFAULT_DARK", "I", AccessFlags = 25)]
				public const int THEME_DEVICE_DEFAULT_DARK = 4;
				/// <java-name>
				/// THEME_DEVICE_DEFAULT_LIGHT
				/// </java-name>
				[Dot42.DexImport("THEME_DEVICE_DEFAULT_LIGHT", "I", AccessFlags = 25)]
				public const int THEME_DEVICE_DEFAULT_LIGHT = 5;
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 4)]
				protected internal AlertDialog(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;I)V", AccessFlags = 4)]
				protected internal AlertDialog(global::Android.Content.Context context, int int32) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;ZLandroid/content/DialogInterface$OnCancelListener;)V", AccessFlags = 4)]
				protected internal AlertDialog(global::Android.Content.Context context, bool boolean, global::Android.Content.IDialogInterface_IOnCancelListener dialogInterface_IOnCancelListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getButton
				/// </java-name>
				[Dot42.DexImport("getButton", "(I)Landroid/widget/Button;", AccessFlags = 1)]
				public virtual global::Android.Widget.Button GetButton(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Widget.Button);
				}

				/// <java-name>
				/// setTitle
				/// </java-name>
				[Dot42.DexImport("setTitle", "(Ljava/lang/CharSequence;)V", AccessFlags = 1)]
				public override void SetTitle(global::Java.Lang.ICharSequence charSequence) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setCustomTitle
				/// </java-name>
				[Dot42.DexImport("setCustomTitle", "(Landroid/view/View;)V", AccessFlags = 1)]
				public virtual void SetCustomTitle(global::Android.Views.View view) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setMessage
				/// </java-name>
				[Dot42.DexImport("setMessage", "(Ljava/lang/CharSequence;)V", AccessFlags = 1)]
				public virtual void SetMessage(global::Java.Lang.ICharSequence charSequence) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setView
				/// </java-name>
				[Dot42.DexImport("setView", "(Landroid/view/View;)V", AccessFlags = 1)]
				public virtual void SetView(global::Android.Views.View view) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setView
				/// </java-name>
				[Dot42.DexImport("setView", "(Landroid/view/View;IIII)V", AccessFlags = 1)]
				public virtual void SetView(global::Android.Views.View view, int int32, int int321, int int322, int int323) /* MethodBuilder.Create */ 
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

				/// <java-name>
				/// setIcon
				/// </java-name>
				[Dot42.DexImport("setIcon", "(I)V", AccessFlags = 1)]
				public virtual void SetIcon(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setIcon
				/// </java-name>
				[Dot42.DexImport("setIcon", "(Landroid/graphics/drawable/Drawable;)V", AccessFlags = 1)]
				public virtual void SetIcon(global::Android.Graphics.Drawables.Drawable drawable) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setIconAttribute
				/// </java-name>
				[Dot42.DexImport("setIconAttribute", "(I)V", AccessFlags = 1)]
				public virtual void SetIconAttribute(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setInverseBackgroundForced
				/// </java-name>
				[Dot42.DexImport("setInverseBackgroundForced", "(Z)V", AccessFlags = 1)]
				public virtual void SetInverseBackgroundForced(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onCreate
				/// </java-name>
				[Dot42.DexImport("onCreate", "(Landroid/os/Bundle;)V", AccessFlags = 4)]
				protected internal override void OnCreate(global::Android.OS.Bundle bundle) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onKeyDown
				/// </java-name>
				[Dot42.DexImport("onKeyDown", "(ILandroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public override bool OnKeyDown(int int32, global::Android.Views.KeyEvent keyEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onKeyUp
				/// </java-name>
				[Dot42.DexImport("onKeyUp", "(ILandroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public override bool OnKeyUp(int int32, global::Android.Views.KeyEvent keyEvent) /* MethodBuilder.Create */ 
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

						/// <java-name>
						/// setTitle
						/// </java-name>
						[Dot42.DexImport("setTitle", "(I)Landroid/app/AlertDialog$Builder;", AccessFlags = 1)]
						public virtual Builder SetTitle(int int32) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// setTitle
						/// </java-name>
						[Dot42.DexImport("setTitle", "(Ljava/lang/CharSequence;)Landroid/app/AlertDialog$Builder;", AccessFlags = 1)]
						public virtual Builder SetTitle(global::Java.Lang.ICharSequence charSequence) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// setCustomTitle
						/// </java-name>
						[Dot42.DexImport("setCustomTitle", "(Landroid/view/View;)Landroid/app/AlertDialog$Builder;", AccessFlags = 1)]
						public virtual Builder SetCustomTitle(global::Android.Views.View view) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// setMessage
						/// </java-name>
						[Dot42.DexImport("setMessage", "(I)Landroid/app/AlertDialog$Builder;", AccessFlags = 1)]
						public virtual Builder SetMessage(int int32) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// setMessage
						/// </java-name>
						[Dot42.DexImport("setMessage", "(Ljava/lang/CharSequence;)Landroid/app/AlertDialog$Builder;", AccessFlags = 1)]
						public virtual Builder SetMessage(global::Java.Lang.ICharSequence charSequence) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// setIcon
						/// </java-name>
						[Dot42.DexImport("setIcon", "(I)Landroid/app/AlertDialog$Builder;", AccessFlags = 1)]
						public virtual Builder SetIcon(int int32) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// setIcon
						/// </java-name>
						[Dot42.DexImport("setIcon", "(Landroid/graphics/drawable/Drawable;)Landroid/app/AlertDialog$Builder;", AccessFlags = 1)]
						public virtual Builder SetIcon(global::Android.Graphics.Drawables.Drawable drawable) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// setIconAttribute
						/// </java-name>
						[Dot42.DexImport("setIconAttribute", "(I)Landroid/app/AlertDialog$Builder;", AccessFlags = 1)]
						public virtual Builder SetIconAttribute(int int32) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// setPositiveButton
						/// </java-name>
						[Dot42.DexImport("setPositiveButton", "(ILandroid/content/DialogInterface$OnClickListener;)Landroid/app/AlertDialog$Buil" +
    "der;", AccessFlags = 1)]
						public virtual Builder SetPositiveButton(int int32, global::Android.Content.IDialogInterface_IOnClickListener dialogInterface_IOnClickListener) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// setPositiveButton
						/// </java-name>
						[Dot42.DexImport("setPositiveButton", "(Ljava/lang/CharSequence;Landroid/content/DialogInterface$OnClickListener;)Landro" +
    "id/app/AlertDialog$Builder;", AccessFlags = 1)]
						public virtual Builder SetPositiveButton(global::Java.Lang.ICharSequence charSequence, global::Android.Content.IDialogInterface_IOnClickListener dialogInterface_IOnClickListener) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// setNegativeButton
						/// </java-name>
						[Dot42.DexImport("setNegativeButton", "(ILandroid/content/DialogInterface$OnClickListener;)Landroid/app/AlertDialog$Buil" +
    "der;", AccessFlags = 1)]
						public virtual Builder SetNegativeButton(int int32, global::Android.Content.IDialogInterface_IOnClickListener dialogInterface_IOnClickListener) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// setNegativeButton
						/// </java-name>
						[Dot42.DexImport("setNegativeButton", "(Ljava/lang/CharSequence;Landroid/content/DialogInterface$OnClickListener;)Landro" +
    "id/app/AlertDialog$Builder;", AccessFlags = 1)]
						public virtual Builder SetNegativeButton(global::Java.Lang.ICharSequence charSequence, global::Android.Content.IDialogInterface_IOnClickListener dialogInterface_IOnClickListener) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// setNeutralButton
						/// </java-name>
						[Dot42.DexImport("setNeutralButton", "(ILandroid/content/DialogInterface$OnClickListener;)Landroid/app/AlertDialog$Buil" +
    "der;", AccessFlags = 1)]
						public virtual Builder SetNeutralButton(int int32, global::Android.Content.IDialogInterface_IOnClickListener dialogInterface_IOnClickListener) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// setNeutralButton
						/// </java-name>
						[Dot42.DexImport("setNeutralButton", "(Ljava/lang/CharSequence;Landroid/content/DialogInterface$OnClickListener;)Landro" +
    "id/app/AlertDialog$Builder;", AccessFlags = 1)]
						public virtual Builder SetNeutralButton(global::Java.Lang.ICharSequence charSequence, global::Android.Content.IDialogInterface_IOnClickListener dialogInterface_IOnClickListener) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// setCancelable
						/// </java-name>
						[Dot42.DexImport("setCancelable", "(Z)Landroid/app/AlertDialog$Builder;", AccessFlags = 1)]
						public virtual Builder SetCancelable(bool boolean) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// setOnCancelListener
						/// </java-name>
						[Dot42.DexImport("setOnCancelListener", "(Landroid/content/DialogInterface$OnCancelListener;)Landroid/app/AlertDialog$Buil" +
    "der;", AccessFlags = 1)]
						public virtual Builder SetOnCancelListener(global::Android.Content.IDialogInterface_IOnCancelListener dialogInterface_IOnCancelListener) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// setOnKeyListener
						/// </java-name>
						[Dot42.DexImport("setOnKeyListener", "(Landroid/content/DialogInterface$OnKeyListener;)Landroid/app/AlertDialog$Builder" +
    ";", AccessFlags = 1)]
						public virtual Builder SetOnKeyListener(global::Android.Content.IDialogInterface_IOnKeyListener dialogInterface_IOnKeyListener) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// setItems
						/// </java-name>
						[Dot42.DexImport("setItems", "(ILandroid/content/DialogInterface$OnClickListener;)Landroid/app/AlertDialog$Buil" +
    "der;", AccessFlags = 1)]
						public virtual Builder SetItems(int int32, global::Android.Content.IDialogInterface_IOnClickListener dialogInterface_IOnClickListener) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// setItems
						/// </java-name>
						[Dot42.DexImport("setItems", "([Ljava/lang/CharSequence;Landroid/content/DialogInterface$OnClickListener;)Landr" +
    "oid/app/AlertDialog$Builder;", AccessFlags = 1)]
						public virtual Builder SetItems(global::Java.Lang.ICharSequence[] charSequence, global::Android.Content.IDialogInterface_IOnClickListener dialogInterface_IOnClickListener) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// setAdapter
						/// </java-name>
						[Dot42.DexImport("setAdapter", "(Landroid/widget/ListAdapter;Landroid/content/DialogInterface$OnClickListener;)La" +
    "ndroid/app/AlertDialog$Builder;", AccessFlags = 1)]
						public virtual Builder SetAdapter(global::Android.Widget.IListAdapter listAdapter, global::Android.Content.IDialogInterface_IOnClickListener dialogInterface_IOnClickListener) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// setCursor
						/// </java-name>
						[Dot42.DexImport("setCursor", "(Landroid/database/Cursor;Landroid/content/DialogInterface$OnClickListener;Ljava/" +
    "lang/String;)Landroid/app/AlertDialog$Builder;", AccessFlags = 1)]
						public virtual Builder SetCursor(global::Android.Database.ICursor cursor, global::Android.Content.IDialogInterface_IOnClickListener dialogInterface_IOnClickListener, string @string) /* MethodBuilder.Create */ 
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

						/// <java-name>
						/// setMultiChoiceItems
						/// </java-name>
						[Dot42.DexImport("setMultiChoiceItems", "(Landroid/database/Cursor;Ljava/lang/String;Ljava/lang/String;Landroid/content/Di" +
    "alogInterface$OnMultiChoiceClickListener;)Landroid/app/AlertDialog$Builder;", AccessFlags = 1)]
						public virtual Builder SetMultiChoiceItems(global::Android.Database.ICursor cursor, string @string, string string1, global::Android.Content.IDialogInterface_IOnMultiChoiceClickListener dialogInterface_IOnMultiChoiceClickListener) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// setSingleChoiceItems
						/// </java-name>
						[Dot42.DexImport("setSingleChoiceItems", "(IILandroid/content/DialogInterface$OnClickListener;)Landroid/app/AlertDialog$Bui" +
    "lder;", AccessFlags = 1)]
						public virtual Builder SetSingleChoiceItems(int int32, int int321, global::Android.Content.IDialogInterface_IOnClickListener dialogInterface_IOnClickListener) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// setSingleChoiceItems
						/// </java-name>
						[Dot42.DexImport("setSingleChoiceItems", "(Landroid/database/Cursor;ILjava/lang/String;Landroid/content/DialogInterface$OnC" +
    "lickListener;)Landroid/app/AlertDialog$Builder;", AccessFlags = 1)]
						public virtual Builder SetSingleChoiceItems(global::Android.Database.ICursor cursor, int int32, string @string, global::Android.Content.IDialogInterface_IOnClickListener dialogInterface_IOnClickListener) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// setSingleChoiceItems
						/// </java-name>
						[Dot42.DexImport("setSingleChoiceItems", "([Ljava/lang/CharSequence;ILandroid/content/DialogInterface$OnClickListener;)Land" +
    "roid/app/AlertDialog$Builder;", AccessFlags = 1)]
						public virtual Builder SetSingleChoiceItems(global::Java.Lang.ICharSequence[] charSequence, int int32, global::Android.Content.IDialogInterface_IOnClickListener dialogInterface_IOnClickListener) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// setSingleChoiceItems
						/// </java-name>
						[Dot42.DexImport("setSingleChoiceItems", "(Landroid/widget/ListAdapter;ILandroid/content/DialogInterface$OnClickListener;)L" +
    "android/app/AlertDialog$Builder;", AccessFlags = 1)]
						public virtual Builder SetSingleChoiceItems(global::Android.Widget.IListAdapter listAdapter, int int32, global::Android.Content.IDialogInterface_IOnClickListener dialogInterface_IOnClickListener) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// setOnItemSelectedListener
						/// </java-name>
						[Dot42.DexImport("setOnItemSelectedListener", "(Landroid/widget/AdapterView$OnItemSelectedListener;)Landroid/app/AlertDialog$Bui" +
    "lder;", AccessFlags = 1)]
						public virtual Builder SetOnItemSelectedListener(global::Android.Widget.AdapterView<object>.IOnItemSelectedListener onItemSelectedListener) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// setView
						/// </java-name>
						[Dot42.DexImport("setView", "(Landroid/view/View;)Landroid/app/AlertDialog$Builder;", AccessFlags = 1)]
						public virtual Builder SetView(global::Android.Views.View view) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// setInverseBackgroundForced
						/// </java-name>
						[Dot42.DexImport("setInverseBackgroundForced", "(Z)Landroid/app/AlertDialog$Builder;", AccessFlags = 1)]
						public virtual Builder SetInverseBackgroundForced(bool boolean) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// create
						/// </java-name>
						[Dot42.DexImport("create", "()Landroid/app/AlertDialog;", AccessFlags = 1)]
						public virtual global::Android.App.AlertDialog Create() /* MethodBuilder.Create */ 
						{
								return default(global::Android.App.AlertDialog);
						}

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
				protected internal override void OnCreate(global::Android.OS.Bundle bundle) /* MethodBuilder.Create */ 
				{
				}

		}

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

				/// <java-name>
				/// onCreate
				/// </java-name>
				[Dot42.DexImport("onCreate", "()V", AccessFlags = 1)]
				public virtual void OnCreate() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onTerminate
				/// </java-name>
				[Dot42.DexImport("onTerminate", "()V", AccessFlags = 1)]
				public virtual void OnTerminate() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onConfigurationChanged
				/// </java-name>
				[Dot42.DexImport("onConfigurationChanged", "(Landroid/content/res/Configuration;)V", AccessFlags = 1)]
				public virtual void OnConfigurationChanged(global::Android.Content.Res.Configuration configuration) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onLowMemory
				/// </java-name>
				[Dot42.DexImport("onLowMemory", "()V", AccessFlags = 1)]
				public virtual void OnLowMemory() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onTrimMemory
				/// </java-name>
				[Dot42.DexImport("onTrimMemory", "(I)V", AccessFlags = 1)]
				public virtual void OnTrimMemory(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// registerComponentCallbacks
				/// </java-name>
				[Dot42.DexImport("registerComponentCallbacks", "(Landroid/content/ComponentCallbacks;)V", AccessFlags = 1)]
				public override void RegisterComponentCallbacks(global::Android.Content.IComponentCallbacks componentCallbacks) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// unregisterComponentCallbacks
				/// </java-name>
				[Dot42.DexImport("unregisterComponentCallbacks", "(Landroid/content/ComponentCallbacks;)V", AccessFlags = 1)]
				public override void UnregisterComponentCallbacks(global::Android.Content.IComponentCallbacks componentCallbacks) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// registerActivityLifecycleCallbacks
				/// </java-name>
				[Dot42.DexImport("registerActivityLifecycleCallbacks", "(Landroid/app/Application$ActivityLifecycleCallbacks;)V", AccessFlags = 1)]
				public virtual void RegisterActivityLifecycleCallbacks(global::Android.App.Application.IActivityLifecycleCallbacks activityLifecycleCallbacks) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// unregisterActivityLifecycleCallbacks
				/// </java-name>
				[Dot42.DexImport("unregisterActivityLifecycleCallbacks", "(Landroid/app/Application$ActivityLifecycleCallbacks;)V", AccessFlags = 1)]
				public virtual void UnregisterActivityLifecycleCallbacks(global::Android.App.Application.IActivityLifecycleCallbacks activityLifecycleCallbacks) /* MethodBuilder.Create */ 
				{
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
						void OnActivityCreated(global::Android.App.Activity activity, global::Android.OS.Bundle bundle) /* MethodBuilder.Create */ ;

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
						void OnActivitySaveInstanceState(global::Android.App.Activity activity, global::Android.OS.Bundle bundle) /* MethodBuilder.Create */ ;

						/// <java-name>
						/// onActivityDestroyed
						/// </java-name>
						[Dot42.DexImport("onActivityDestroyed", "(Landroid/app/Activity;)V", AccessFlags = 1025)]
						void OnActivityDestroyed(global::Android.App.Activity activity) /* MethodBuilder.Create */ ;

				}

		}

		/// <java-name>
		/// android/app/ApplicationErrorReport
		/// </java-name>
		[Dot42.DexImport("android/app/ApplicationErrorReport", AccessFlags = 33)]
		public partial class ApplicationErrorReport : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// TYPE_NONE
				/// </java-name>
				[Dot42.DexImport("TYPE_NONE", "I", AccessFlags = 25)]
				public const int TYPE_NONE = 0;
				/// <java-name>
				/// TYPE_CRASH
				/// </java-name>
				[Dot42.DexImport("TYPE_CRASH", "I", AccessFlags = 25)]
				public const int TYPE_CRASH = 1;
				/// <java-name>
				/// TYPE_ANR
				/// </java-name>
				[Dot42.DexImport("TYPE_ANR", "I", AccessFlags = 25)]
				public const int TYPE_ANR = 2;
				/// <java-name>
				/// TYPE_BATTERY
				/// </java-name>
				[Dot42.DexImport("TYPE_BATTERY", "I", AccessFlags = 25)]
				public const int TYPE_BATTERY = 3;
				/// <java-name>
				/// TYPE_RUNNING_SERVICE
				/// </java-name>
				[Dot42.DexImport("TYPE_RUNNING_SERVICE", "I", AccessFlags = 25)]
				public const int TYPE_RUNNING_SERVICE = 5;
				/// <java-name>
				/// type
				/// </java-name>
				[Dot42.DexImport("type", "I", AccessFlags = 1)]
				public int Type;
				/// <java-name>
				/// packageName
				/// </java-name>
				[Dot42.DexImport("packageName", "Ljava/lang/String;", AccessFlags = 1)]
				public string PackageName;
				/// <java-name>
				/// installerPackageName
				/// </java-name>
				[Dot42.DexImport("installerPackageName", "Ljava/lang/String;", AccessFlags = 1)]
				public string InstallerPackageName;
				/// <java-name>
				/// processName
				/// </java-name>
				[Dot42.DexImport("processName", "Ljava/lang/String;", AccessFlags = 1)]
				public string ProcessName;
				/// <java-name>
				/// time
				/// </java-name>
				[Dot42.DexImport("time", "J", AccessFlags = 1)]
				public long Time;
				/// <java-name>
				/// systemApp
				/// </java-name>
				[Dot42.DexImport("systemApp", "Z", AccessFlags = 1)]
				public bool SystemApp;
				/// <java-name>
				/// crashInfo
				/// </java-name>
				[Dot42.DexImport("crashInfo", "Landroid/app/ApplicationErrorReport$CrashInfo;", AccessFlags = 1)]
				public global::Android.App.ApplicationErrorReport.CrashInfo CrashInfo0;
				/// <java-name>
				/// anrInfo
				/// </java-name>
				[Dot42.DexImport("anrInfo", "Landroid/app/ApplicationErrorReport$AnrInfo;", AccessFlags = 1)]
				public global::Android.App.ApplicationErrorReport.AnrInfo AnrInfo0;
				/// <java-name>
				/// batteryInfo
				/// </java-name>
				[Dot42.DexImport("batteryInfo", "Landroid/app/ApplicationErrorReport$BatteryInfo;", AccessFlags = 1)]
				public global::Android.App.ApplicationErrorReport.BatteryInfo BatteryInfo0;
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

				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public virtual void WriteToParcel(global::Android.OS.Parcel parcel, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// readFromParcel
				/// </java-name>
				[Dot42.DexImport("readFromParcel", "(Landroid/os/Parcel;)V", AccessFlags = 1)]
				public virtual void ReadFromParcel(global::Android.OS.Parcel parcel) /* MethodBuilder.Create */ 
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
				/// dump
				/// </java-name>
				[Dot42.DexImport("dump", "(Landroid/util/Printer;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void Dump(global::Android.Util.IPrinter printer, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// android/app/ApplicationErrorReport$RunningServiceInfo
				/// </java-name>
				[Dot42.DexImport("android/app/ApplicationErrorReport$RunningServiceInfo", AccessFlags = 9)]
				public partial class RunningServiceInfo
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// durationMillis
						/// </java-name>
						[Dot42.DexImport("durationMillis", "J", AccessFlags = 1)]
						public long DurationMillis;
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

						/// <java-name>
						/// writeToParcel
						/// </java-name>
						[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
						public virtual void WriteToParcel(global::Android.OS.Parcel parcel, int int32) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// dump
						/// </java-name>
						[Dot42.DexImport("dump", "(Landroid/util/Printer;Ljava/lang/String;)V", AccessFlags = 1)]
						public virtual void Dump(global::Android.Util.IPrinter printer, string @string) /* MethodBuilder.Create */ 
						{
						}

				}

				/// <java-name>
				/// android/app/ApplicationErrorReport$BatteryInfo
				/// </java-name>
				[Dot42.DexImport("android/app/ApplicationErrorReport$BatteryInfo", AccessFlags = 9)]
				public partial class BatteryInfo
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// usagePercent
						/// </java-name>
						[Dot42.DexImport("usagePercent", "I", AccessFlags = 1)]
						public int UsagePercent;
						/// <java-name>
						/// durationMicros
						/// </java-name>
						[Dot42.DexImport("durationMicros", "J", AccessFlags = 1)]
						public long DurationMicros;
						/// <java-name>
						/// usageDetails
						/// </java-name>
						[Dot42.DexImport("usageDetails", "Ljava/lang/String;", AccessFlags = 1)]
						public string UsageDetails;
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

						/// <java-name>
						/// writeToParcel
						/// </java-name>
						[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
						public virtual void WriteToParcel(global::Android.OS.Parcel parcel, int int32) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// dump
						/// </java-name>
						[Dot42.DexImport("dump", "(Landroid/util/Printer;Ljava/lang/String;)V", AccessFlags = 1)]
						public virtual void Dump(global::Android.Util.IPrinter printer, string @string) /* MethodBuilder.Create */ 
						{
						}

				}

				/// <java-name>
				/// android/app/ApplicationErrorReport$AnrInfo
				/// </java-name>
				[Dot42.DexImport("android/app/ApplicationErrorReport$AnrInfo", AccessFlags = 9)]
				public partial class AnrInfo
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// activity
						/// </java-name>
						[Dot42.DexImport("activity", "Ljava/lang/String;", AccessFlags = 1)]
						public string Activity;
						/// <java-name>
						/// cause
						/// </java-name>
						[Dot42.DexImport("cause", "Ljava/lang/String;", AccessFlags = 1)]
						public string Cause;
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

						/// <java-name>
						/// writeToParcel
						/// </java-name>
						[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
						public virtual void WriteToParcel(global::Android.OS.Parcel parcel, int int32) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// dump
						/// </java-name>
						[Dot42.DexImport("dump", "(Landroid/util/Printer;Ljava/lang/String;)V", AccessFlags = 1)]
						public virtual void Dump(global::Android.Util.IPrinter printer, string @string) /* MethodBuilder.Create */ 
						{
						}

				}

				/// <java-name>
				/// android/app/ApplicationErrorReport$CrashInfo
				/// </java-name>
				[Dot42.DexImport("android/app/ApplicationErrorReport$CrashInfo", AccessFlags = 9)]
				public partial class CrashInfo
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// exceptionClassName
						/// </java-name>
						[Dot42.DexImport("exceptionClassName", "Ljava/lang/String;", AccessFlags = 1)]
						public string ExceptionClassName;
						/// <java-name>
						/// exceptionMessage
						/// </java-name>
						[Dot42.DexImport("exceptionMessage", "Ljava/lang/String;", AccessFlags = 1)]
						public string ExceptionMessage;
						/// <java-name>
						/// throwFileName
						/// </java-name>
						[Dot42.DexImport("throwFileName", "Ljava/lang/String;", AccessFlags = 1)]
						public string ThrowFileName;
						/// <java-name>
						/// throwClassName
						/// </java-name>
						[Dot42.DexImport("throwClassName", "Ljava/lang/String;", AccessFlags = 1)]
						public string ThrowClassName;
						/// <java-name>
						/// throwMethodName
						/// </java-name>
						[Dot42.DexImport("throwMethodName", "Ljava/lang/String;", AccessFlags = 1)]
						public string ThrowMethodName;
						/// <java-name>
						/// throwLineNumber
						/// </java-name>
						[Dot42.DexImport("throwLineNumber", "I", AccessFlags = 1)]
						public int ThrowLineNumber;
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

						/// <java-name>
						/// writeToParcel
						/// </java-name>
						[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
						public virtual void WriteToParcel(global::Android.OS.Parcel parcel, int int32) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// dump
						/// </java-name>
						[Dot42.DexImport("dump", "(Landroid/util/Printer;Ljava/lang/String;)V", AccessFlags = 1)]
						public virtual void Dump(global::Android.Util.IPrinter printer, string @string) /* MethodBuilder.Create */ 
						{
						}

				}

		}

		/// <java-name>
		/// android/app/DatePickerDialog
		/// </java-name>
		[Dot42.DexImport("android/app/DatePickerDialog", AccessFlags = 33)]
		public partial class DatePickerDialog : global::Android.App.AlertDialog, global::Android.Content.IDialogInterface_IOnClickListener, global::Android.Widget.DatePicker.IOnDateChangedListener
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/app/DatePickerDialog$OnDateSetListener;III)V", AccessFlags = 1)]
				public DatePickerDialog(global::Android.Content.Context context, global::Android.App.DatePickerDialog.IOnDateSetListener onDateSetListener, int int32, int int321, int int322) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;ILandroid/app/DatePickerDialog$OnDateSetListener;III)V", AccessFlags = 1)]
				public DatePickerDialog(global::Android.Content.Context context, int int32, global::Android.App.DatePickerDialog.IOnDateSetListener onDateSetListener, int int321, int int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onClick
				/// </java-name>
				[Dot42.DexImport("onClick", "(Landroid/content/DialogInterface;I)V", AccessFlags = 1)]
				public virtual void OnClick(global::Android.Content.IDialogInterface dialogInterface, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onDateChanged
				/// </java-name>
				[Dot42.DexImport("onDateChanged", "(Landroid/widget/DatePicker;III)V", AccessFlags = 1)]
				public virtual void OnDateChanged(global::Android.Widget.DatePicker datePicker, int int32, int int321, int int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// updateDate
				/// </java-name>
				[Dot42.DexImport("updateDate", "(III)V", AccessFlags = 1)]
				public virtual void UpdateDate(int int32, int int321, int int322) /* MethodBuilder.Create */ 
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
				public override void OnRestoreInstanceState(global::Android.OS.Bundle bundle) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal DatePickerDialog() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getDatePicker
				/// </java-name>
				public virtual global::Android.Widget.DatePicker DatePicker
				{
						[Dot42.DexImport("getDatePicker", "()Landroid/widget/DatePicker;", AccessFlags = 1)]
						get{ return default(global::Android.Widget.DatePicker); }
				}

				/// <java-name>
				/// android/app/DatePickerDialog$OnDateSetListener
				/// </java-name>
				[Dot42.DexImport("android/app/DatePickerDialog$OnDateSetListener", AccessFlags = 1545)]
				public partial interface IOnDateSetListener
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onDateSet
						/// </java-name>
						[Dot42.DexImport("onDateSet", "(Landroid/widget/DatePicker;III)V", AccessFlags = 1025)]
						void OnDateSet(global::Android.Widget.DatePicker datePicker, int int32, int int321, int int322) /* MethodBuilder.Create */ ;

				}

		}

		/// <java-name>
		/// android/app/Dialog
		/// </java-name>
		[Dot42.DexImport("android/app/Dialog", AccessFlags = 33)]
		public partial class Dialog : global::Android.Content.IDialogInterface, global::Android.Views.Window.ICallback, global::Android.Views.KeyEvent.ICallback, global::Android.Views.View.IOnCreateContextMenuListener
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public Dialog(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;I)V", AccessFlags = 1)]
				public Dialog(global::Android.Content.Context context, int int32) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;ZLandroid/content/DialogInterface$OnCancelListener;)V", AccessFlags = 4)]
				protected internal Dialog(global::Android.Content.Context context, bool boolean, global::Android.Content.IDialogInterface_IOnCancelListener dialogInterface_IOnCancelListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// show
				/// </java-name>
				[Dot42.DexImport("show", "()V", AccessFlags = 1)]
				public virtual void Show() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// hide
				/// </java-name>
				[Dot42.DexImport("hide", "()V", AccessFlags = 1)]
				public virtual void Hide() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// dismiss
				/// </java-name>
				[Dot42.DexImport("dismiss", "()V", AccessFlags = 1)]
				public virtual void Dismiss() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onCreate
				/// </java-name>
				[Dot42.DexImport("onCreate", "(Landroid/os/Bundle;)V", AccessFlags = 4)]
				protected internal virtual void OnCreate(global::Android.OS.Bundle bundle) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onStart
				/// </java-name>
				[Dot42.DexImport("onStart", "()V", AccessFlags = 4)]
				protected internal virtual void OnStart() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onStop
				/// </java-name>
				[Dot42.DexImport("onStop", "()V", AccessFlags = 4)]
				protected internal virtual void OnStop() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onSaveInstanceState
				/// </java-name>
				[Dot42.DexImport("onSaveInstanceState", "()Landroid/os/Bundle;", AccessFlags = 1)]
				public virtual global::Android.OS.Bundle OnSaveInstanceState() /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.Bundle);
				}

				/// <java-name>
				/// onRestoreInstanceState
				/// </java-name>
				[Dot42.DexImport("onRestoreInstanceState", "(Landroid/os/Bundle;)V", AccessFlags = 1)]
				public virtual void OnRestoreInstanceState(global::Android.OS.Bundle bundle) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// findViewById
				/// </java-name>
				[Dot42.DexImport("findViewById", "(I)Landroid/view/View;", AccessFlags = 1)]
				public virtual global::Android.Views.View FindViewById(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.View);
				}

				/// <java-name>
				/// setContentView
				/// </java-name>
				[Dot42.DexImport("setContentView", "(I)V", AccessFlags = 1)]
				public virtual void SetContentView(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setContentView
				/// </java-name>
				[Dot42.DexImport("setContentView", "(Landroid/view/View;)V", AccessFlags = 1)]
				public virtual void SetContentView(global::Android.Views.View view) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setContentView
				/// </java-name>
				[Dot42.DexImport("setContentView", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V", AccessFlags = 1)]
				public virtual void SetContentView(global::Android.Views.View view, global::Android.Views.ViewGroup.LayoutParams layoutParams) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addContentView
				/// </java-name>
				[Dot42.DexImport("addContentView", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V", AccessFlags = 1)]
				public virtual void AddContentView(global::Android.Views.View view, global::Android.Views.ViewGroup.LayoutParams layoutParams) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setTitle
				/// </java-name>
				[Dot42.DexImport("setTitle", "(Ljava/lang/CharSequence;)V", AccessFlags = 1)]
				public virtual void SetTitle(global::Java.Lang.ICharSequence charSequence) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setTitle
				/// </java-name>
				[Dot42.DexImport("setTitle", "(I)V", AccessFlags = 1)]
				public virtual void SetTitle(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onKeyDown
				/// </java-name>
				[Dot42.DexImport("onKeyDown", "(ILandroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public virtual bool OnKeyDown(int int32, global::Android.Views.KeyEvent keyEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onKeyLongPress
				/// </java-name>
				[Dot42.DexImport("onKeyLongPress", "(ILandroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public virtual bool OnKeyLongPress(int int32, global::Android.Views.KeyEvent keyEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onKeyUp
				/// </java-name>
				[Dot42.DexImport("onKeyUp", "(ILandroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public virtual bool OnKeyUp(int int32, global::Android.Views.KeyEvent keyEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onKeyMultiple
				/// </java-name>
				[Dot42.DexImport("onKeyMultiple", "(IILandroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public virtual bool OnKeyMultiple(int int32, int int321, global::Android.Views.KeyEvent keyEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onBackPressed
				/// </java-name>
				[Dot42.DexImport("onBackPressed", "()V", AccessFlags = 1)]
				public virtual void OnBackPressed() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onKeyShortcut
				/// </java-name>
				[Dot42.DexImport("onKeyShortcut", "(ILandroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public virtual bool OnKeyShortcut(int int32, global::Android.Views.KeyEvent keyEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onTouchEvent
				/// </java-name>
				[Dot42.DexImport("onTouchEvent", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1)]
				public virtual bool OnTouchEvent(global::Android.Views.MotionEvent motionEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onTrackballEvent
				/// </java-name>
				[Dot42.DexImport("onTrackballEvent", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1)]
				public virtual bool OnTrackballEvent(global::Android.Views.MotionEvent motionEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onGenericMotionEvent
				/// </java-name>
				[Dot42.DexImport("onGenericMotionEvent", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1)]
				public virtual bool OnGenericMotionEvent(global::Android.Views.MotionEvent motionEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onWindowAttributesChanged
				/// </java-name>
				[Dot42.DexImport("onWindowAttributesChanged", "(Landroid/view/WindowManager$LayoutParams;)V", AccessFlags = 1)]
				public virtual void OnWindowAttributesChanged(global::Android.Views.IWindowManager_LayoutParams iWindowManager_LayoutParams) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onContentChanged
				/// </java-name>
				[Dot42.DexImport("onContentChanged", "()V", AccessFlags = 1)]
				public virtual void OnContentChanged() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onWindowFocusChanged
				/// </java-name>
				[Dot42.DexImport("onWindowFocusChanged", "(Z)V", AccessFlags = 1)]
				public virtual void OnWindowFocusChanged(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onAttachedToWindow
				/// </java-name>
				[Dot42.DexImport("onAttachedToWindow", "()V", AccessFlags = 1)]
				public virtual void OnAttachedToWindow() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onDetachedFromWindow
				/// </java-name>
				[Dot42.DexImport("onDetachedFromWindow", "()V", AccessFlags = 1)]
				public virtual void OnDetachedFromWindow() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// dispatchKeyEvent
				/// </java-name>
				[Dot42.DexImport("dispatchKeyEvent", "(Landroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public virtual bool DispatchKeyEvent(global::Android.Views.KeyEvent keyEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// dispatchKeyShortcutEvent
				/// </java-name>
				[Dot42.DexImport("dispatchKeyShortcutEvent", "(Landroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public virtual bool DispatchKeyShortcutEvent(global::Android.Views.KeyEvent keyEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// dispatchTouchEvent
				/// </java-name>
				[Dot42.DexImport("dispatchTouchEvent", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1)]
				public virtual bool DispatchTouchEvent(global::Android.Views.MotionEvent motionEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// dispatchTrackballEvent
				/// </java-name>
				[Dot42.DexImport("dispatchTrackballEvent", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1)]
				public virtual bool DispatchTrackballEvent(global::Android.Views.MotionEvent motionEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// dispatchGenericMotionEvent
				/// </java-name>
				[Dot42.DexImport("dispatchGenericMotionEvent", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1)]
				public virtual bool DispatchGenericMotionEvent(global::Android.Views.MotionEvent motionEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// dispatchPopulateAccessibilityEvent
				/// </java-name>
				[Dot42.DexImport("dispatchPopulateAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)Z", AccessFlags = 1)]
				public virtual bool DispatchPopulateAccessibilityEvent(global::Android.Views.Accessibility.AccessibilityEvent accessibilityEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onCreatePanelView
				/// </java-name>
				[Dot42.DexImport("onCreatePanelView", "(I)Landroid/view/View;", AccessFlags = 1)]
				public virtual global::Android.Views.View OnCreatePanelView(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.View);
				}

				/// <java-name>
				/// onCreatePanelMenu
				/// </java-name>
				[Dot42.DexImport("onCreatePanelMenu", "(ILandroid/view/Menu;)Z", AccessFlags = 1)]
				public virtual bool OnCreatePanelMenu(int int32, global::Android.Views.IMenu menu) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onPreparePanel
				/// </java-name>
				[Dot42.DexImport("onPreparePanel", "(ILandroid/view/View;Landroid/view/Menu;)Z", AccessFlags = 1)]
				public virtual bool OnPreparePanel(int int32, global::Android.Views.View view, global::Android.Views.IMenu menu) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onMenuOpened
				/// </java-name>
				[Dot42.DexImport("onMenuOpened", "(ILandroid/view/Menu;)Z", AccessFlags = 1)]
				public virtual bool OnMenuOpened(int int32, global::Android.Views.IMenu menu) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onMenuItemSelected
				/// </java-name>
				[Dot42.DexImport("onMenuItemSelected", "(ILandroid/view/MenuItem;)Z", AccessFlags = 1)]
				public virtual bool OnMenuItemSelected(int int32, global::Android.Views.IMenuItem menuItem) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onPanelClosed
				/// </java-name>
				[Dot42.DexImport("onPanelClosed", "(ILandroid/view/Menu;)V", AccessFlags = 1)]
				public virtual void OnPanelClosed(int int32, global::Android.Views.IMenu menu) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onCreateOptionsMenu
				/// </java-name>
				[Dot42.DexImport("onCreateOptionsMenu", "(Landroid/view/Menu;)Z", AccessFlags = 1)]
				public virtual bool OnCreateOptionsMenu(global::Android.Views.IMenu menu) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onPrepareOptionsMenu
				/// </java-name>
				[Dot42.DexImport("onPrepareOptionsMenu", "(Landroid/view/Menu;)Z", AccessFlags = 1)]
				public virtual bool OnPrepareOptionsMenu(global::Android.Views.IMenu menu) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onOptionsItemSelected
				/// </java-name>
				[Dot42.DexImport("onOptionsItemSelected", "(Landroid/view/MenuItem;)Z", AccessFlags = 1)]
				public virtual bool OnOptionsItemSelected(global::Android.Views.IMenuItem menuItem) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onOptionsMenuClosed
				/// </java-name>
				[Dot42.DexImport("onOptionsMenuClosed", "(Landroid/view/Menu;)V", AccessFlags = 1)]
				public virtual void OnOptionsMenuClosed(global::Android.Views.IMenu menu) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// openOptionsMenu
				/// </java-name>
				[Dot42.DexImport("openOptionsMenu", "()V", AccessFlags = 1)]
				public virtual void OpenOptionsMenu() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// closeOptionsMenu
				/// </java-name>
				[Dot42.DexImport("closeOptionsMenu", "()V", AccessFlags = 1)]
				public virtual void CloseOptionsMenu() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// invalidateOptionsMenu
				/// </java-name>
				[Dot42.DexImport("invalidateOptionsMenu", "()V", AccessFlags = 1)]
				public virtual void InvalidateOptionsMenu() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onCreateContextMenu
				/// </java-name>
				[Dot42.DexImport("onCreateContextMenu", "(Landroid/view/ContextMenu;Landroid/view/View;Landroid/view/ContextMenu$ContextMe" +
    "nuInfo;)V", AccessFlags = 1)]
				public virtual void OnCreateContextMenu(global::Android.Views.IContextMenu contextMenu, global::Android.Views.View view, global::Android.Views.IContextMenu_IContextMenuInfo contextMenu_IContextMenuInfo) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// registerForContextMenu
				/// </java-name>
				[Dot42.DexImport("registerForContextMenu", "(Landroid/view/View;)V", AccessFlags = 1)]
				public virtual void RegisterForContextMenu(global::Android.Views.View view) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// unregisterForContextMenu
				/// </java-name>
				[Dot42.DexImport("unregisterForContextMenu", "(Landroid/view/View;)V", AccessFlags = 1)]
				public virtual void UnregisterForContextMenu(global::Android.Views.View view) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// openContextMenu
				/// </java-name>
				[Dot42.DexImport("openContextMenu", "(Landroid/view/View;)V", AccessFlags = 1)]
				public virtual void OpenContextMenu(global::Android.Views.View view) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onContextItemSelected
				/// </java-name>
				[Dot42.DexImport("onContextItemSelected", "(Landroid/view/MenuItem;)Z", AccessFlags = 1)]
				public virtual bool OnContextItemSelected(global::Android.Views.IMenuItem menuItem) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onContextMenuClosed
				/// </java-name>
				[Dot42.DexImport("onContextMenuClosed", "(Landroid/view/Menu;)V", AccessFlags = 1)]
				public virtual void OnContextMenuClosed(global::Android.Views.IMenu menu) /* MethodBuilder.Create */ 
				{
				}

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

				/// <java-name>
				/// onActionModeStarted
				/// </java-name>
				[Dot42.DexImport("onActionModeStarted", "(Landroid/view/ActionMode;)V", AccessFlags = 1)]
				public virtual void OnActionModeStarted(global::Android.Views.ActionMode actionMode) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onActionModeFinished
				/// </java-name>
				[Dot42.DexImport("onActionModeFinished", "(Landroid/view/ActionMode;)V", AccessFlags = 1)]
				public virtual void OnActionModeFinished(global::Android.Views.ActionMode actionMode) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// takeKeyEvents
				/// </java-name>
				[Dot42.DexImport("takeKeyEvents", "(Z)V", AccessFlags = 1)]
				public virtual void TakeKeyEvents(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// requestWindowFeature
				/// </java-name>
				[Dot42.DexImport("requestWindowFeature", "(I)Z", AccessFlags = 17)]
				public bool RequestWindowFeature(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setFeatureDrawableResource
				/// </java-name>
				[Dot42.DexImport("setFeatureDrawableResource", "(II)V", AccessFlags = 17)]
				public void SetFeatureDrawableResource(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setFeatureDrawableUri
				/// </java-name>
				[Dot42.DexImport("setFeatureDrawableUri", "(ILandroid/net/Uri;)V", AccessFlags = 17)]
				public void SetFeatureDrawableUri(int int32, global::Android.Net.Uri uri) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setFeatureDrawable
				/// </java-name>
				[Dot42.DexImport("setFeatureDrawable", "(ILandroid/graphics/drawable/Drawable;)V", AccessFlags = 17)]
				public void SetFeatureDrawable(int int32, global::Android.Graphics.Drawables.Drawable drawable) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setFeatureDrawableAlpha
				/// </java-name>
				[Dot42.DexImport("setFeatureDrawableAlpha", "(II)V", AccessFlags = 17)]
				public void SetFeatureDrawableAlpha(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setCancelable
				/// </java-name>
				[Dot42.DexImport("setCancelable", "(Z)V", AccessFlags = 1)]
				public virtual void SetCancelable(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setCanceledOnTouchOutside
				/// </java-name>
				[Dot42.DexImport("setCanceledOnTouchOutside", "(Z)V", AccessFlags = 1)]
				public virtual void SetCanceledOnTouchOutside(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// cancel
				/// </java-name>
				[Dot42.DexImport("cancel", "()V", AccessFlags = 1)]
				public virtual void Cancel() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setOnCancelListener
				/// </java-name>
				[Dot42.DexImport("setOnCancelListener", "(Landroid/content/DialogInterface$OnCancelListener;)V", AccessFlags = 1)]
				public virtual void SetOnCancelListener(global::Android.Content.IDialogInterface_IOnCancelListener dialogInterface_IOnCancelListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setCancelMessage
				/// </java-name>
				[Dot42.DexImport("setCancelMessage", "(Landroid/os/Message;)V", AccessFlags = 1)]
				public virtual void SetCancelMessage(global::Android.OS.Message message) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setOnDismissListener
				/// </java-name>
				[Dot42.DexImport("setOnDismissListener", "(Landroid/content/DialogInterface$OnDismissListener;)V", AccessFlags = 1)]
				public virtual void SetOnDismissListener(global::Android.Content.IDialogInterface_IOnDismissListener dialogInterface_IOnDismissListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setOnShowListener
				/// </java-name>
				[Dot42.DexImport("setOnShowListener", "(Landroid/content/DialogInterface$OnShowListener;)V", AccessFlags = 1)]
				public virtual void SetOnShowListener(global::Android.Content.IDialogInterface_IOnShowListener dialogInterface_IOnShowListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setDismissMessage
				/// </java-name>
				[Dot42.DexImport("setDismissMessage", "(Landroid/os/Message;)V", AccessFlags = 1)]
				public virtual void SetDismissMessage(global::Android.OS.Message message) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setOnKeyListener
				/// </java-name>
				[Dot42.DexImport("setOnKeyListener", "(Landroid/content/DialogInterface$OnKeyListener;)V", AccessFlags = 1)]
				public virtual void SetOnKeyListener(global::Android.Content.IDialogInterface_IOnKeyListener dialogInterface_IOnKeyListener) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal Dialog() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getContext
				/// </java-name>
				public global::Android.Content.Context Context
				{
						[Dot42.DexImport("getContext", "()Landroid/content/Context;", AccessFlags = 17)]
						get{ return default(global::Android.Content.Context); }
				}

				/// <java-name>
				/// getActionBar
				/// </java-name>
				public virtual global::Android.App.ActionBar ActionBar
				{
						[Dot42.DexImport("getActionBar", "()Landroid/app/ActionBar;", AccessFlags = 1)]
						get{ return default(global::Android.App.ActionBar); }
				}

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

				/// <java-name>
				/// isShowing
				/// </java-name>
				public virtual bool IsShowing
				{
						[Dot42.DexImport("isShowing", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// getWindow
				/// </java-name>
				public virtual global::Android.Views.Window Window
				{
						[Dot42.DexImport("getWindow", "()Landroid/view/Window;", AccessFlags = 1)]
						get{ return default(global::Android.Views.Window); }
				}

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

		/// <java-name>
		/// android/app/DialogFragment
		/// </java-name>
		[Dot42.DexImport("android/app/DialogFragment", AccessFlags = 33)]
		public partial class DialogFragment : global::Android.App.Fragment, global::Android.Content.IDialogInterface_IOnCancelListener, global::Android.Content.IDialogInterface_IOnDismissListener
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// STYLE_NORMAL
				/// </java-name>
				[Dot42.DexImport("STYLE_NORMAL", "I", AccessFlags = 25)]
				public const int STYLE_NORMAL = 0;
				/// <java-name>
				/// STYLE_NO_TITLE
				/// </java-name>
				[Dot42.DexImport("STYLE_NO_TITLE", "I", AccessFlags = 25)]
				public const int STYLE_NO_TITLE = 1;
				/// <java-name>
				/// STYLE_NO_FRAME
				/// </java-name>
				[Dot42.DexImport("STYLE_NO_FRAME", "I", AccessFlags = 25)]
				public const int STYLE_NO_FRAME = 2;
				/// <java-name>
				/// STYLE_NO_INPUT
				/// </java-name>
				[Dot42.DexImport("STYLE_NO_INPUT", "I", AccessFlags = 25)]
				public const int STYLE_NO_INPUT = 3;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public DialogFragment() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setStyle
				/// </java-name>
				[Dot42.DexImport("setStyle", "(II)V", AccessFlags = 1)]
				public virtual void SetStyle(int int32, int int321) /* MethodBuilder.Create */ 
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

				/// <java-name>
				/// dismiss
				/// </java-name>
				[Dot42.DexImport("dismiss", "()V", AccessFlags = 1)]
				public virtual void Dismiss() /* MethodBuilder.Create */ 
				{
				}

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
				public override void OnCreate(global::Android.OS.Bundle bundle) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onCreateDialog
				/// </java-name>
				[Dot42.DexImport("onCreateDialog", "(Landroid/os/Bundle;)Landroid/app/Dialog;", AccessFlags = 1)]
				public virtual global::Android.App.Dialog OnCreateDialog(global::Android.OS.Bundle bundle) /* MethodBuilder.Create */ 
				{
						return default(global::Android.App.Dialog);
				}

				/// <java-name>
				/// onCancel
				/// </java-name>
				[Dot42.DexImport("onCancel", "(Landroid/content/DialogInterface;)V", AccessFlags = 1)]
				public virtual void OnCancel(global::Android.Content.IDialogInterface dialogInterface) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onDismiss
				/// </java-name>
				[Dot42.DexImport("onDismiss", "(Landroid/content/DialogInterface;)V", AccessFlags = 1)]
				public virtual void OnDismiss(global::Android.Content.IDialogInterface dialogInterface) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onActivityCreated
				/// </java-name>
				[Dot42.DexImport("onActivityCreated", "(Landroid/os/Bundle;)V", AccessFlags = 1)]
				public override void OnActivityCreated(global::Android.OS.Bundle bundle) /* MethodBuilder.Create */ 
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
				public override void OnSaveInstanceState(global::Android.OS.Bundle bundle) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onStop
				/// </java-name>
				[Dot42.DexImport("onStop", "()V", AccessFlags = 1)]
				public override void OnStop() /* MethodBuilder.Create */ 
				{
				}

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
				public override void Dump(string @string, global::Java.IO.FileDescriptor fileDescriptor, global::Java.IO.PrintWriter printWriter, string[] string1) /* MethodBuilder.Create */ 
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

				/// <java-name>
				/// getShowsDialog
				/// </java-name>
				public virtual bool IsShowsDialog
				{
						[Dot42.DexImport("getShowsDialog", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setShowsDialog", "(Z)V", AccessFlags = 1)]
						set{ }
				}

		}

		/// <java-name>
		/// android/app/DownloadManager
		/// </java-name>
		[Dot42.DexImport("android/app/DownloadManager", AccessFlags = 33)]
		public partial class DownloadManager
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// COLUMN_ID
				/// </java-name>
				[Dot42.DexImport("COLUMN_ID", "Ljava/lang/String;", AccessFlags = 25)]
				public const string COLUMN_ID = "_id";
				/// <java-name>
				/// COLUMN_TITLE
				/// </java-name>
				[Dot42.DexImport("COLUMN_TITLE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string COLUMN_TITLE = "title";
				/// <java-name>
				/// COLUMN_DESCRIPTION
				/// </java-name>
				[Dot42.DexImport("COLUMN_DESCRIPTION", "Ljava/lang/String;", AccessFlags = 25)]
				public const string COLUMN_DESCRIPTION = "description";
				/// <java-name>
				/// COLUMN_URI
				/// </java-name>
				[Dot42.DexImport("COLUMN_URI", "Ljava/lang/String;", AccessFlags = 25)]
				public const string COLUMN_URI = "uri";
				/// <java-name>
				/// COLUMN_MEDIA_TYPE
				/// </java-name>
				[Dot42.DexImport("COLUMN_MEDIA_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string COLUMN_MEDIA_TYPE = "media_type";
				/// <java-name>
				/// COLUMN_TOTAL_SIZE_BYTES
				/// </java-name>
				[Dot42.DexImport("COLUMN_TOTAL_SIZE_BYTES", "Ljava/lang/String;", AccessFlags = 25)]
				public const string COLUMN_TOTAL_SIZE_BYTES = "total_size";
				/// <java-name>
				/// COLUMN_LOCAL_URI
				/// </java-name>
				[Dot42.DexImport("COLUMN_LOCAL_URI", "Ljava/lang/String;", AccessFlags = 25)]
				public const string COLUMN_LOCAL_URI = "local_uri";
				/// <java-name>
				/// COLUMN_LOCAL_FILENAME
				/// </java-name>
				[Dot42.DexImport("COLUMN_LOCAL_FILENAME", "Ljava/lang/String;", AccessFlags = 25)]
				public const string COLUMN_LOCAL_FILENAME = "local_filename";
				/// <java-name>
				/// COLUMN_STATUS
				/// </java-name>
				[Dot42.DexImport("COLUMN_STATUS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string COLUMN_STATUS = "status";
				/// <java-name>
				/// COLUMN_REASON
				/// </java-name>
				[Dot42.DexImport("COLUMN_REASON", "Ljava/lang/String;", AccessFlags = 25)]
				public const string COLUMN_REASON = "reason";
				/// <java-name>
				/// COLUMN_BYTES_DOWNLOADED_SO_FAR
				/// </java-name>
				[Dot42.DexImport("COLUMN_BYTES_DOWNLOADED_SO_FAR", "Ljava/lang/String;", AccessFlags = 25)]
				public const string COLUMN_BYTES_DOWNLOADED_SO_FAR = "bytes_so_far";
				/// <java-name>
				/// COLUMN_LAST_MODIFIED_TIMESTAMP
				/// </java-name>
				[Dot42.DexImport("COLUMN_LAST_MODIFIED_TIMESTAMP", "Ljava/lang/String;", AccessFlags = 25)]
				public const string COLUMN_LAST_MODIFIED_TIMESTAMP = "last_modified_timestamp";
				/// <java-name>
				/// COLUMN_MEDIAPROVIDER_URI
				/// </java-name>
				[Dot42.DexImport("COLUMN_MEDIAPROVIDER_URI", "Ljava/lang/String;", AccessFlags = 25)]
				public const string COLUMN_MEDIAPROVIDER_URI = "mediaprovider_uri";
				/// <java-name>
				/// STATUS_PENDING
				/// </java-name>
				[Dot42.DexImport("STATUS_PENDING", "I", AccessFlags = 25)]
				public const int STATUS_PENDING = 1;
				/// <java-name>
				/// STATUS_RUNNING
				/// </java-name>
				[Dot42.DexImport("STATUS_RUNNING", "I", AccessFlags = 25)]
				public const int STATUS_RUNNING = 2;
				/// <java-name>
				/// STATUS_PAUSED
				/// </java-name>
				[Dot42.DexImport("STATUS_PAUSED", "I", AccessFlags = 25)]
				public const int STATUS_PAUSED = 4;
				/// <java-name>
				/// STATUS_SUCCESSFUL
				/// </java-name>
				[Dot42.DexImport("STATUS_SUCCESSFUL", "I", AccessFlags = 25)]
				public const int STATUS_SUCCESSFUL = 8;
				/// <java-name>
				/// STATUS_FAILED
				/// </java-name>
				[Dot42.DexImport("STATUS_FAILED", "I", AccessFlags = 25)]
				public const int STATUS_FAILED = 16;
				/// <java-name>
				/// ERROR_UNKNOWN
				/// </java-name>
				[Dot42.DexImport("ERROR_UNKNOWN", "I", AccessFlags = 25)]
				public const int ERROR_UNKNOWN = 1000;
				/// <java-name>
				/// ERROR_FILE_ERROR
				/// </java-name>
				[Dot42.DexImport("ERROR_FILE_ERROR", "I", AccessFlags = 25)]
				public const int ERROR_FILE_ERROR = 1001;
				/// <java-name>
				/// ERROR_UNHANDLED_HTTP_CODE
				/// </java-name>
				[Dot42.DexImport("ERROR_UNHANDLED_HTTP_CODE", "I", AccessFlags = 25)]
				public const int ERROR_UNHANDLED_HTTP_CODE = 1002;
				/// <java-name>
				/// ERROR_HTTP_DATA_ERROR
				/// </java-name>
				[Dot42.DexImport("ERROR_HTTP_DATA_ERROR", "I", AccessFlags = 25)]
				public const int ERROR_HTTP_DATA_ERROR = 1004;
				/// <java-name>
				/// ERROR_TOO_MANY_REDIRECTS
				/// </java-name>
				[Dot42.DexImport("ERROR_TOO_MANY_REDIRECTS", "I", AccessFlags = 25)]
				public const int ERROR_TOO_MANY_REDIRECTS = 1005;
				/// <java-name>
				/// ERROR_INSUFFICIENT_SPACE
				/// </java-name>
				[Dot42.DexImport("ERROR_INSUFFICIENT_SPACE", "I", AccessFlags = 25)]
				public const int ERROR_INSUFFICIENT_SPACE = 1006;
				/// <java-name>
				/// ERROR_DEVICE_NOT_FOUND
				/// </java-name>
				[Dot42.DexImport("ERROR_DEVICE_NOT_FOUND", "I", AccessFlags = 25)]
				public const int ERROR_DEVICE_NOT_FOUND = 1007;
				/// <java-name>
				/// ERROR_CANNOT_RESUME
				/// </java-name>
				[Dot42.DexImport("ERROR_CANNOT_RESUME", "I", AccessFlags = 25)]
				public const int ERROR_CANNOT_RESUME = 1008;
				/// <java-name>
				/// ERROR_FILE_ALREADY_EXISTS
				/// </java-name>
				[Dot42.DexImport("ERROR_FILE_ALREADY_EXISTS", "I", AccessFlags = 25)]
				public const int ERROR_FILE_ALREADY_EXISTS = 1009;
				/// <java-name>
				/// PAUSED_WAITING_TO_RETRY
				/// </java-name>
				[Dot42.DexImport("PAUSED_WAITING_TO_RETRY", "I", AccessFlags = 25)]
				public const int PAUSED_WAITING_TO_RETRY = 1;
				/// <java-name>
				/// PAUSED_WAITING_FOR_NETWORK
				/// </java-name>
				[Dot42.DexImport("PAUSED_WAITING_FOR_NETWORK", "I", AccessFlags = 25)]
				public const int PAUSED_WAITING_FOR_NETWORK = 2;
				/// <java-name>
				/// PAUSED_QUEUED_FOR_WIFI
				/// </java-name>
				[Dot42.DexImport("PAUSED_QUEUED_FOR_WIFI", "I", AccessFlags = 25)]
				public const int PAUSED_QUEUED_FOR_WIFI = 3;
				/// <java-name>
				/// PAUSED_UNKNOWN
				/// </java-name>
				[Dot42.DexImport("PAUSED_UNKNOWN", "I", AccessFlags = 25)]
				public const int PAUSED_UNKNOWN = 4;
				/// <java-name>
				/// ACTION_DOWNLOAD_COMPLETE
				/// </java-name>
				[Dot42.DexImport("ACTION_DOWNLOAD_COMPLETE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_DOWNLOAD_COMPLETE = "android.intent.action.DOWNLOAD_COMPLETE";
				/// <java-name>
				/// ACTION_NOTIFICATION_CLICKED
				/// </java-name>
				[Dot42.DexImport("ACTION_NOTIFICATION_CLICKED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_NOTIFICATION_CLICKED = "android.intent.action.DOWNLOAD_NOTIFICATION_CLICKED";
				/// <java-name>
				/// ACTION_VIEW_DOWNLOADS
				/// </java-name>
				[Dot42.DexImport("ACTION_VIEW_DOWNLOADS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_VIEW_DOWNLOADS = "android.intent.action.VIEW_DOWNLOADS";
				/// <java-name>
				/// INTENT_EXTRAS_SORT_BY_SIZE
				/// </java-name>
				[Dot42.DexImport("INTENT_EXTRAS_SORT_BY_SIZE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string INTENT_EXTRAS_SORT_BY_SIZE = "android.app.DownloadManager.extra_sortBySize";
				/// <java-name>
				/// EXTRA_DOWNLOAD_ID
				/// </java-name>
				[Dot42.DexImport("EXTRA_DOWNLOAD_ID", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_DOWNLOAD_ID = "extra_download_id";
				/// <java-name>
				/// EXTRA_NOTIFICATION_CLICK_DOWNLOAD_IDS
				/// </java-name>
				[Dot42.DexImport("EXTRA_NOTIFICATION_CLICK_DOWNLOAD_IDS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_NOTIFICATION_CLICK_DOWNLOAD_IDS = "extra_click_download_ids";
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal DownloadManager() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// enqueue
				/// </java-name>
				[Dot42.DexImport("enqueue", "(Landroid/app/DownloadManager$Request;)J", AccessFlags = 1)]
				public virtual long Enqueue(global::Android.App.DownloadManager.Request request) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// remove
				/// </java-name>
				[Dot42.DexImport("remove", "([J)I", AccessFlags = 129)]
				public virtual int Remove(params long[] int64) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// query
				/// </java-name>
				[Dot42.DexImport("query", "(Landroid/app/DownloadManager$Query;)Landroid/database/Cursor;", AccessFlags = 1)]
				public virtual global::Android.Database.ICursor Query(global::Android.App.DownloadManager.JavaQuery query) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Database.ICursor);
				}

				/// <java-name>
				/// openDownloadedFile
				/// </java-name>
				[Dot42.DexImport("openDownloadedFile", "(J)Landroid/os/ParcelFileDescriptor;", AccessFlags = 1)]
				public virtual global::Android.OS.ParcelFileDescriptor OpenDownloadedFile(long int64) /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.ParcelFileDescriptor);
				}

				/// <java-name>
				/// getUriForDownloadedFile
				/// </java-name>
				[Dot42.DexImport("getUriForDownloadedFile", "(J)Landroid/net/Uri;", AccessFlags = 1)]
				public virtual global::Android.Net.Uri GetUriForDownloadedFile(long int64) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Net.Uri);
				}

				/// <java-name>
				/// getMimeTypeForDownloadedFile
				/// </java-name>
				[Dot42.DexImport("getMimeTypeForDownloadedFile", "(J)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetMimeTypeForDownloadedFile(long int64) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getMaxBytesOverMobile
				/// </java-name>
				[Dot42.DexImport("getMaxBytesOverMobile", "(Landroid/content/Context;)Ljava/lang/Long;", AccessFlags = 9)]
				public static long? GetMaxBytesOverMobile(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
						return default(long?);
				}

				/// <java-name>
				/// getRecommendedMaxBytesOverMobile
				/// </java-name>
				[Dot42.DexImport("getRecommendedMaxBytesOverMobile", "(Landroid/content/Context;)Ljava/lang/Long;", AccessFlags = 9)]
				public static long? GetRecommendedMaxBytesOverMobile(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
						return default(long?);
				}

				/// <java-name>
				/// addCompletedDownload
				/// </java-name>
				[Dot42.DexImport("addCompletedDownload", "(Ljava/lang/String;Ljava/lang/String;ZLjava/lang/String;Ljava/lang/String;JZ)J", AccessFlags = 1)]
				public virtual long AddCompletedDownload(string @string, string string1, bool boolean, string string2, string string3, long int64, bool boolean1) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

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

						/// <java-name>
						/// setFilterById
						/// </java-name>
						[Dot42.DexImport("setFilterById", "([J)Landroid/app/DownloadManager$Query;", AccessFlags = 129)]
						public virtual JavaQuery SetFilterById(params long[] int64) /* MethodBuilder.Create */ 
						{
								return default(JavaQuery);
						}

						/// <java-name>
						/// setFilterByStatus
						/// </java-name>
						[Dot42.DexImport("setFilterByStatus", "(I)Landroid/app/DownloadManager$Query;", AccessFlags = 1)]
						public virtual JavaQuery SetFilterByStatus(int int32) /* MethodBuilder.Create */ 
						{
								return default(JavaQuery);
						}

				}

				/// <java-name>
				/// android/app/DownloadManager$Request
				/// </java-name>
				[Dot42.DexImport("android/app/DownloadManager$Request", AccessFlags = 9)]
				public partial class Request
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// NETWORK_MOBILE
						/// </java-name>
						[Dot42.DexImport("NETWORK_MOBILE", "I", AccessFlags = 25)]
						public const int NETWORK_MOBILE = 1;
						/// <java-name>
						/// NETWORK_WIFI
						/// </java-name>
						[Dot42.DexImport("NETWORK_WIFI", "I", AccessFlags = 25)]
						public const int NETWORK_WIFI = 2;
						/// <java-name>
						/// VISIBILITY_VISIBLE
						/// </java-name>
						[Dot42.DexImport("VISIBILITY_VISIBLE", "I", AccessFlags = 25)]
						public const int VISIBILITY_VISIBLE = 0;
						/// <java-name>
						/// VISIBILITY_VISIBLE_NOTIFY_COMPLETED
						/// </java-name>
						[Dot42.DexImport("VISIBILITY_VISIBLE_NOTIFY_COMPLETED", "I", AccessFlags = 25)]
						public const int VISIBILITY_VISIBLE_NOTIFY_COMPLETED = 1;
						/// <java-name>
						/// VISIBILITY_HIDDEN
						/// </java-name>
						[Dot42.DexImport("VISIBILITY_HIDDEN", "I", AccessFlags = 25)]
						public const int VISIBILITY_HIDDEN = 2;
						/// <java-name>
						/// VISIBILITY_VISIBLE_NOTIFY_ONLY_COMPLETION
						/// </java-name>
						[Dot42.DexImport("VISIBILITY_VISIBLE_NOTIFY_ONLY_COMPLETION", "I", AccessFlags = 25)]
						public const int VISIBILITY_VISIBLE_NOTIFY_ONLY_COMPLETION = 3;
						[Dot42.DexImport("<init>", "(Landroid/net/Uri;)V", AccessFlags = 1)]
						public Request(global::Android.Net.Uri uri) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// setDestinationUri
						/// </java-name>
						[Dot42.DexImport("setDestinationUri", "(Landroid/net/Uri;)Landroid/app/DownloadManager$Request;", AccessFlags = 1)]
						public virtual Request SetDestinationUri(global::Android.Net.Uri uri) /* MethodBuilder.Create */ 
						{
								return default(Request);
						}

						/// <java-name>
						/// setDestinationInExternalFilesDir
						/// </java-name>
						[Dot42.DexImport("setDestinationInExternalFilesDir", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)Landroid/app/Downl" +
    "oadManager$Request;", AccessFlags = 1)]
						public virtual Request SetDestinationInExternalFilesDir(global::Android.Content.Context context, string @string, string string1) /* MethodBuilder.Create */ 
						{
								return default(Request);
						}

						/// <java-name>
						/// setDestinationInExternalPublicDir
						/// </java-name>
						[Dot42.DexImport("setDestinationInExternalPublicDir", "(Ljava/lang/String;Ljava/lang/String;)Landroid/app/DownloadManager$Request;", AccessFlags = 1)]
						public virtual Request SetDestinationInExternalPublicDir(string @string, string string1) /* MethodBuilder.Create */ 
						{
								return default(Request);
						}

						/// <java-name>
						/// allowScanningByMediaScanner
						/// </java-name>
						[Dot42.DexImport("allowScanningByMediaScanner", "()V", AccessFlags = 1)]
						public virtual void AllowScanningByMediaScanner() /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// addRequestHeader
						/// </java-name>
						[Dot42.DexImport("addRequestHeader", "(Ljava/lang/String;Ljava/lang/String;)Landroid/app/DownloadManager$Request;", AccessFlags = 1)]
						public virtual Request AddRequestHeader(string @string, string string1) /* MethodBuilder.Create */ 
						{
								return default(Request);
						}

						/// <java-name>
						/// setTitle
						/// </java-name>
						[Dot42.DexImport("setTitle", "(Ljava/lang/CharSequence;)Landroid/app/DownloadManager$Request;", AccessFlags = 1)]
						public virtual Request SetTitle(global::Java.Lang.ICharSequence charSequence) /* MethodBuilder.Create */ 
						{
								return default(Request);
						}

						/// <java-name>
						/// setDescription
						/// </java-name>
						[Dot42.DexImport("setDescription", "(Ljava/lang/CharSequence;)Landroid/app/DownloadManager$Request;", AccessFlags = 1)]
						public virtual Request SetDescription(global::Java.Lang.ICharSequence charSequence) /* MethodBuilder.Create */ 
						{
								return default(Request);
						}

						/// <java-name>
						/// setMimeType
						/// </java-name>
						[Dot42.DexImport("setMimeType", "(Ljava/lang/String;)Landroid/app/DownloadManager$Request;", AccessFlags = 1)]
						public virtual Request SetMimeType(string @string) /* MethodBuilder.Create */ 
						{
								return default(Request);
						}

						/// <java-name>
						/// setShowRunningNotification
						/// </java-name>
						[Dot42.DexImport("setShowRunningNotification", "(Z)Landroid/app/DownloadManager$Request;", AccessFlags = 1)]
						public virtual Request SetShowRunningNotification(bool boolean) /* MethodBuilder.Create */ 
						{
								return default(Request);
						}

						/// <java-name>
						/// setNotificationVisibility
						/// </java-name>
						[Dot42.DexImport("setNotificationVisibility", "(I)Landroid/app/DownloadManager$Request;", AccessFlags = 1)]
						public virtual Request SetNotificationVisibility(int int32) /* MethodBuilder.Create */ 
						{
								return default(Request);
						}

						/// <java-name>
						/// setAllowedNetworkTypes
						/// </java-name>
						[Dot42.DexImport("setAllowedNetworkTypes", "(I)Landroid/app/DownloadManager$Request;", AccessFlags = 1)]
						public virtual Request SetAllowedNetworkTypes(int int32) /* MethodBuilder.Create */ 
						{
								return default(Request);
						}

						/// <java-name>
						/// setAllowedOverRoaming
						/// </java-name>
						[Dot42.DexImport("setAllowedOverRoaming", "(Z)Landroid/app/DownloadManager$Request;", AccessFlags = 1)]
						public virtual Request SetAllowedOverRoaming(bool boolean) /* MethodBuilder.Create */ 
						{
								return default(Request);
						}

						/// <java-name>
						/// setVisibleInDownloadsUi
						/// </java-name>
						[Dot42.DexImport("setVisibleInDownloadsUi", "(Z)Landroid/app/DownloadManager$Request;", AccessFlags = 1)]
						public virtual Request SetVisibleInDownloadsUi(bool boolean) /* MethodBuilder.Create */ 
						{
								return default(Request);
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal Request() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

				}

		}

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

				/// <java-name>
				/// onCreateContextMenu
				/// </java-name>
				[Dot42.DexImport("onCreateContextMenu", "(Landroid/view/ContextMenu;Landroid/view/View;Landroid/view/ContextMenu$ContextMe" +
    "nuInfo;)V", AccessFlags = 1)]
				public override void OnCreateContextMenu(global::Android.Views.IContextMenu contextMenu, global::Android.Views.View view, global::Android.Views.IContextMenu_IContextMenuInfo contextMenu_IContextMenuInfo) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onChildClick
				/// </java-name>
				[Dot42.DexImport("onChildClick", "(Landroid/widget/ExpandableListView;Landroid/view/View;IIJ)Z", AccessFlags = 1)]
				public virtual bool OnChildClick(global::Android.Widget.ExpandableListView expandableListView, global::Android.Views.View view, int int32, int int321, long int64) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onGroupCollapse
				/// </java-name>
				[Dot42.DexImport("onGroupCollapse", "(I)V", AccessFlags = 1)]
				public virtual void OnGroupCollapse(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onGroupExpand
				/// </java-name>
				[Dot42.DexImport("onGroupExpand", "(I)V", AccessFlags = 1)]
				public virtual void OnGroupExpand(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onRestoreInstanceState
				/// </java-name>
				[Dot42.DexImport("onRestoreInstanceState", "(Landroid/os/Bundle;)V", AccessFlags = 4)]
				protected internal override void OnRestoreInstanceState(global::Android.OS.Bundle bundle) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onContentChanged
				/// </java-name>
				[Dot42.DexImport("onContentChanged", "()V", AccessFlags = 1)]
				public override void OnContentChanged() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setListAdapter
				/// </java-name>
				[Dot42.DexImport("setListAdapter", "(Landroid/widget/ExpandableListAdapter;)V", AccessFlags = 1)]
				public virtual void SetListAdapter(global::Android.Widget.IExpandableListAdapter expandableListAdapter) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setSelectedChild
				/// </java-name>
				[Dot42.DexImport("setSelectedChild", "(IIZ)Z", AccessFlags = 1)]
				public virtual bool SetSelectedChild(int int32, int int321, bool boolean) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setSelectedGroup
				/// </java-name>
				[Dot42.DexImport("setSelectedGroup", "(I)V", AccessFlags = 1)]
				public virtual void SetSelectedGroup(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getExpandableListView
				/// </java-name>
				public virtual global::Android.Widget.ExpandableListView ExpandableListView
				{
						[Dot42.DexImport("getExpandableListView", "()Landroid/widget/ExpandableListView;", AccessFlags = 1)]
						get{ return default(global::Android.Widget.ExpandableListView); }
				}

				/// <java-name>
				/// getExpandableListAdapter
				/// </java-name>
				public virtual global::Android.Widget.IExpandableListAdapter ExpandableListAdapter
				{
						[Dot42.DexImport("getExpandableListAdapter", "()Landroid/widget/ExpandableListAdapter;", AccessFlags = 1)]
						get{ return default(global::Android.Widget.IExpandableListAdapter); }
				}

				/// <java-name>
				/// getSelectedId
				/// </java-name>
				public virtual long SelectedId
				{
						[Dot42.DexImport("getSelectedId", "()J", AccessFlags = 1)]
						get{ return default(long); }
				}

				/// <java-name>
				/// getSelectedPosition
				/// </java-name>
				public virtual long SelectedPosition
				{
						[Dot42.DexImport("getSelectedPosition", "()J", AccessFlags = 1)]
						get{ return default(long); }
				}

		}

		/// <java-name>
		/// android/app/Fragment
		/// </java-name>
		[Dot42.DexImport("android/app/Fragment", AccessFlags = 33)]
		public partial class Fragment : global::Android.Content.IComponentCallbacks2, global::Android.Views.View.IOnCreateContextMenuListener
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Fragment() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// instantiate
				/// </java-name>
				[Dot42.DexImport("instantiate", "(Landroid/content/Context;Ljava/lang/String;)Landroid/app/Fragment;", AccessFlags = 9)]
				public static global::Android.App.Fragment Instantiate(global::Android.Content.Context context, string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Android.App.Fragment);
				}

				/// <java-name>
				/// instantiate
				/// </java-name>
				[Dot42.DexImport("instantiate", "(Landroid/content/Context;Ljava/lang/String;Landroid/os/Bundle;)Landroid/app/Frag" +
    "ment;", AccessFlags = 9)]
				public static global::Android.App.Fragment Instantiate(global::Android.Content.Context context, string @string, global::Android.OS.Bundle bundle) /* MethodBuilder.Create */ 
				{
						return default(global::Android.App.Fragment);
				}

				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 17)]
				public override bool Equals(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

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

				/// <java-name>
				/// setInitialSavedState
				/// </java-name>
				[Dot42.DexImport("setInitialSavedState", "(Landroid/app/Fragment$SavedState;)V", AccessFlags = 1)]
				public virtual void SetInitialSavedState(global::Android.App.Fragment.SavedState savedState) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setTargetFragment
				/// </java-name>
				[Dot42.DexImport("setTargetFragment", "(Landroid/app/Fragment;I)V", AccessFlags = 1)]
				public virtual void SetTargetFragment(global::Android.App.Fragment fragment, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getText
				/// </java-name>
				[Dot42.DexImport("getText", "(I)Ljava/lang/CharSequence;", AccessFlags = 17)]
				public global::Java.Lang.ICharSequence GetText(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <java-name>
				/// getString
				/// </java-name>
				[Dot42.DexImport("getString", "(I)Ljava/lang/String;", AccessFlags = 17)]
				public string GetString(int int32) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getString
				/// </java-name>
				[Dot42.DexImport("getString", "(I[Ljava/lang/Object;)Ljava/lang/String;", AccessFlags = 145)]
				public string GetString(int int32, params object[] @object) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// onHiddenChanged
				/// </java-name>
				[Dot42.DexImport("onHiddenChanged", "(Z)V", AccessFlags = 1)]
				public virtual void OnHiddenChanged(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setHasOptionsMenu
				/// </java-name>
				[Dot42.DexImport("setHasOptionsMenu", "(Z)V", AccessFlags = 1)]
				public virtual void SetHasOptionsMenu(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setMenuVisibility
				/// </java-name>
				[Dot42.DexImport("setMenuVisibility", "(Z)V", AccessFlags = 1)]
				public virtual void SetMenuVisibility(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// startActivity
				/// </java-name>
				[Dot42.DexImport("startActivity", "(Landroid/content/Intent;)V", AccessFlags = 1)]
				public virtual void StartActivity(global::Android.Content.Intent intent) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// startActivityForResult
				/// </java-name>
				[Dot42.DexImport("startActivityForResult", "(Landroid/content/Intent;I)V", AccessFlags = 1)]
				public virtual void StartActivityForResult(global::Android.Content.Intent intent, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onActivityResult
				/// </java-name>
				[Dot42.DexImport("onActivityResult", "(IILandroid/content/Intent;)V", AccessFlags = 1)]
				public virtual void OnActivityResult(int int32, int int321, global::Android.Content.Intent intent) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onInflate
				/// </java-name>
				[Dot42.DexImport("onInflate", "(Landroid/util/AttributeSet;Landroid/os/Bundle;)V", AccessFlags = 1)]
				public virtual void OnInflate(global::Android.Util.IAttributeSet attributeSet, global::Android.OS.Bundle bundle) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onInflate
				/// </java-name>
				[Dot42.DexImport("onInflate", "(Landroid/app/Activity;Landroid/util/AttributeSet;Landroid/os/Bundle;)V", AccessFlags = 1)]
				public virtual void OnInflate(global::Android.App.Activity activity, global::Android.Util.IAttributeSet attributeSet, global::Android.OS.Bundle bundle) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onAttach
				/// </java-name>
				[Dot42.DexImport("onAttach", "(Landroid/app/Activity;)V", AccessFlags = 1)]
				public virtual void OnAttach(global::Android.App.Activity activity) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onCreateAnimator
				/// </java-name>
				[Dot42.DexImport("onCreateAnimator", "(IZI)Landroid/animation/Animator;", AccessFlags = 1)]
				public virtual global::Android.Animation.Animator OnCreateAnimator(int int32, bool boolean, int int321) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Animation.Animator);
				}

				/// <java-name>
				/// onCreate
				/// </java-name>
				[Dot42.DexImport("onCreate", "(Landroid/os/Bundle;)V", AccessFlags = 1)]
				public virtual void OnCreate(global::Android.OS.Bundle bundle) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onViewCreated
				/// </java-name>
				[Dot42.DexImport("onViewCreated", "(Landroid/view/View;Landroid/os/Bundle;)V", AccessFlags = 1)]
				public virtual void OnViewCreated(global::Android.Views.View view, global::Android.OS.Bundle bundle) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onCreateView
				/// </java-name>
				[Dot42.DexImport("onCreateView", "(Landroid/view/LayoutInflater;Landroid/view/ViewGroup;Landroid/os/Bundle;)Landroi" +
    "d/view/View;", AccessFlags = 1)]
				public virtual global::Android.Views.View OnCreateView(global::Android.Views.LayoutInflater layoutInflater, global::Android.Views.ViewGroup viewGroup, global::Android.OS.Bundle bundle) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.View);
				}

				/// <java-name>
				/// onActivityCreated
				/// </java-name>
				[Dot42.DexImport("onActivityCreated", "(Landroid/os/Bundle;)V", AccessFlags = 1)]
				public virtual void OnActivityCreated(global::Android.OS.Bundle bundle) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onStart
				/// </java-name>
				[Dot42.DexImport("onStart", "()V", AccessFlags = 1)]
				public virtual void OnStart() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onResume
				/// </java-name>
				[Dot42.DexImport("onResume", "()V", AccessFlags = 1)]
				public virtual void OnResume() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onSaveInstanceState
				/// </java-name>
				[Dot42.DexImport("onSaveInstanceState", "(Landroid/os/Bundle;)V", AccessFlags = 1)]
				public virtual void OnSaveInstanceState(global::Android.OS.Bundle bundle) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onConfigurationChanged
				/// </java-name>
				[Dot42.DexImport("onConfigurationChanged", "(Landroid/content/res/Configuration;)V", AccessFlags = 1)]
				public virtual void OnConfigurationChanged(global::Android.Content.Res.Configuration configuration) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onPause
				/// </java-name>
				[Dot42.DexImport("onPause", "()V", AccessFlags = 1)]
				public virtual void OnPause() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onStop
				/// </java-name>
				[Dot42.DexImport("onStop", "()V", AccessFlags = 1)]
				public virtual void OnStop() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onLowMemory
				/// </java-name>
				[Dot42.DexImport("onLowMemory", "()V", AccessFlags = 1)]
				public virtual void OnLowMemory() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onTrimMemory
				/// </java-name>
				[Dot42.DexImport("onTrimMemory", "(I)V", AccessFlags = 1)]
				public virtual void OnTrimMemory(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onDestroyView
				/// </java-name>
				[Dot42.DexImport("onDestroyView", "()V", AccessFlags = 1)]
				public virtual void OnDestroyView() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onDestroy
				/// </java-name>
				[Dot42.DexImport("onDestroy", "()V", AccessFlags = 1)]
				public virtual void OnDestroy() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onDetach
				/// </java-name>
				[Dot42.DexImport("onDetach", "()V", AccessFlags = 1)]
				public virtual void OnDetach() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onCreateOptionsMenu
				/// </java-name>
				[Dot42.DexImport("onCreateOptionsMenu", "(Landroid/view/Menu;Landroid/view/MenuInflater;)V", AccessFlags = 1)]
				public virtual void OnCreateOptionsMenu(global::Android.Views.IMenu menu, global::Android.Views.MenuInflater menuInflater) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onPrepareOptionsMenu
				/// </java-name>
				[Dot42.DexImport("onPrepareOptionsMenu", "(Landroid/view/Menu;)V", AccessFlags = 1)]
				public virtual void OnPrepareOptionsMenu(global::Android.Views.IMenu menu) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onDestroyOptionsMenu
				/// </java-name>
				[Dot42.DexImport("onDestroyOptionsMenu", "()V", AccessFlags = 1)]
				public virtual void OnDestroyOptionsMenu() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onOptionsItemSelected
				/// </java-name>
				[Dot42.DexImport("onOptionsItemSelected", "(Landroid/view/MenuItem;)Z", AccessFlags = 1)]
				public virtual bool OnOptionsItemSelected(global::Android.Views.IMenuItem menuItem) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onOptionsMenuClosed
				/// </java-name>
				[Dot42.DexImport("onOptionsMenuClosed", "(Landroid/view/Menu;)V", AccessFlags = 1)]
				public virtual void OnOptionsMenuClosed(global::Android.Views.IMenu menu) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onCreateContextMenu
				/// </java-name>
				[Dot42.DexImport("onCreateContextMenu", "(Landroid/view/ContextMenu;Landroid/view/View;Landroid/view/ContextMenu$ContextMe" +
    "nuInfo;)V", AccessFlags = 1)]
				public virtual void OnCreateContextMenu(global::Android.Views.IContextMenu contextMenu, global::Android.Views.View view, global::Android.Views.IContextMenu_IContextMenuInfo contextMenu_IContextMenuInfo) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// registerForContextMenu
				/// </java-name>
				[Dot42.DexImport("registerForContextMenu", "(Landroid/view/View;)V", AccessFlags = 1)]
				public virtual void RegisterForContextMenu(global::Android.Views.View view) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// unregisterForContextMenu
				/// </java-name>
				[Dot42.DexImport("unregisterForContextMenu", "(Landroid/view/View;)V", AccessFlags = 1)]
				public virtual void UnregisterForContextMenu(global::Android.Views.View view) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onContextItemSelected
				/// </java-name>
				[Dot42.DexImport("onContextItemSelected", "(Landroid/view/MenuItem;)Z", AccessFlags = 1)]
				public virtual bool OnContextItemSelected(global::Android.Views.IMenuItem menuItem) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// dump
				/// </java-name>
				[Dot42.DexImport("dump", "(Ljava/lang/String;Ljava/io/FileDescriptor;Ljava/io/PrintWriter;[Ljava/lang/Strin" +
    "g;)V", AccessFlags = 1)]
				public virtual void Dump(string @string, global::Java.IO.FileDescriptor fileDescriptor, global::Java.IO.PrintWriter printWriter, string[] string1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getId
				/// </java-name>
				public int Id
				{
						[Dot42.DexImport("getId", "()I", AccessFlags = 17)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getTag
				/// </java-name>
				public string Tag
				{
						[Dot42.DexImport("getTag", "()Ljava/lang/String;", AccessFlags = 17)]
						get{ return default(string); }
				}

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

				/// <java-name>
				/// getTargetFragment
				/// </java-name>
				public global::Android.App.Fragment TargetFragment
				{
						[Dot42.DexImport("getTargetFragment", "()Landroid/app/Fragment;", AccessFlags = 17)]
						get{ return default(global::Android.App.Fragment); }
				}

				/// <java-name>
				/// getTargetRequestCode
				/// </java-name>
				public int TargetRequestCode
				{
						[Dot42.DexImport("getTargetRequestCode", "()I", AccessFlags = 17)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getActivity
				/// </java-name>
				public global::Android.App.Activity Activity
				{
						[Dot42.DexImport("getActivity", "()Landroid/app/Activity;", AccessFlags = 17)]
						get{ return default(global::Android.App.Activity); }
				}

				/// <java-name>
				/// getResources
				/// </java-name>
				public global::Android.Content.Res.Resources Resources
				{
						[Dot42.DexImport("getResources", "()Landroid/content/res/Resources;", AccessFlags = 17)]
						get{ return default(global::Android.Content.Res.Resources); }
				}

				/// <java-name>
				/// getFragmentManager
				/// </java-name>
				public global::Android.App.FragmentManager FragmentManager
				{
						[Dot42.DexImport("getFragmentManager", "()Landroid/app/FragmentManager;", AccessFlags = 17)]
						get{ return default(global::Android.App.FragmentManager); }
				}

				/// <java-name>
				/// isAdded
				/// </java-name>
				public bool IsAdded
				{
						[Dot42.DexImport("isAdded", "()Z", AccessFlags = 17)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// isDetached
				/// </java-name>
				public bool IsDetached
				{
						[Dot42.DexImport("isDetached", "()Z", AccessFlags = 17)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// isRemoving
				/// </java-name>
				public bool IsRemoving
				{
						[Dot42.DexImport("isRemoving", "()Z", AccessFlags = 17)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// isInLayout
				/// </java-name>
				public bool IsInLayout
				{
						[Dot42.DexImport("isInLayout", "()Z", AccessFlags = 17)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// isResumed
				/// </java-name>
				public bool IsResumed
				{
						[Dot42.DexImport("isResumed", "()Z", AccessFlags = 17)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// isVisible
				/// </java-name>
				public bool IsVisible
				{
						[Dot42.DexImport("isVisible", "()Z", AccessFlags = 17)]
						get{ return default(bool); }
				}

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
				public virtual bool IsRetainInstance
				{
						[Dot42.DexImport("getRetainInstance", "()Z", AccessFlags = 17)]
						get{ return default(bool); }
						[Dot42.DexImport("setRetainInstance", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getUserVisibleHint
				/// </java-name>
				public virtual bool IsUserVisibleHint
				{
						[Dot42.DexImport("getUserVisibleHint", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setUserVisibleHint", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getLoaderManager
				/// </java-name>
				public virtual global::Android.App.LoaderManager LoaderManager
				{
						[Dot42.DexImport("getLoaderManager", "()Landroid/app/LoaderManager;", AccessFlags = 1)]
						get{ return default(global::Android.App.LoaderManager); }
				}

				/// <java-name>
				/// getView
				/// </java-name>
				public virtual global::Android.Views.View View
				{
						[Dot42.DexImport("getView", "()Landroid/view/View;", AccessFlags = 1)]
						get{ return default(global::Android.Views.View); }
				}

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

						/// <java-name>
						/// describeContents
						/// </java-name>
						[Dot42.DexImport("describeContents", "()I", AccessFlags = 1)]
						public virtual int DescribeContents() /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <java-name>
						/// writeToParcel
						/// </java-name>
						[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
						public virtual void WriteToParcel(global::Android.OS.Parcel parcel, int int32) /* MethodBuilder.Create */ 
						{
						}

				}

		}

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
				public FragmentBreadCrumbs(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", AccessFlags = 1)]
				public FragmentBreadCrumbs(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setActivity
				/// </java-name>
				[Dot42.DexImport("setActivity", "(Landroid/app/Activity;)V", AccessFlags = 1)]
				public virtual void SetActivity(global::Android.App.Activity activity) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setMaxVisible
				/// </java-name>
				[Dot42.DexImport("setMaxVisible", "(I)V", AccessFlags = 1)]
				public virtual void SetMaxVisible(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setParentTitle
				/// </java-name>
				[Dot42.DexImport("setParentTitle", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;Landroid/view/View$OnClickListen" +
    "er;)V", AccessFlags = 1)]
				public virtual void SetParentTitle(global::Java.Lang.ICharSequence charSequence, global::Java.Lang.ICharSequence charSequence1, global::Android.Views.View.IOnClickListener onClickListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setOnBreadCrumbClickListener
				/// </java-name>
				[Dot42.DexImport("setOnBreadCrumbClickListener", "(Landroid/app/FragmentBreadCrumbs$OnBreadCrumbClickListener;)V", AccessFlags = 1)]
				public virtual void SetOnBreadCrumbClickListener(global::Android.App.FragmentBreadCrumbs.IOnBreadCrumbClickListener onBreadCrumbClickListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setTitle
				/// </java-name>
				[Dot42.DexImport("setTitle", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)V", AccessFlags = 1)]
				public virtual void SetTitle(global::Java.Lang.ICharSequence charSequence, global::Java.Lang.ICharSequence charSequence1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onLayout
				/// </java-name>
				[Dot42.DexImport("onLayout", "(ZIIII)V", AccessFlags = 4)]
				protected internal override void OnLayout(bool boolean, int int32, int int321, int int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onMeasure
				/// </java-name>
				[Dot42.DexImport("onMeasure", "(II)V", AccessFlags = 4)]
				protected internal override void OnMeasure(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

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

				/// <java-name>
				/// android/app/FragmentBreadCrumbs$OnBreadCrumbClickListener
				/// </java-name>
				[Dot42.DexImport("android/app/FragmentBreadCrumbs$OnBreadCrumbClickListener", AccessFlags = 1545)]
				public partial interface IOnBreadCrumbClickListener
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onBreadCrumbClick
						/// </java-name>
						[Dot42.DexImport("onBreadCrumbClick", "(Landroid/app/FragmentManager$BackStackEntry;I)Z", AccessFlags = 1025)]
						bool OnBreadCrumbClick(global::Android.App.FragmentManager.IBackStackEntry backStackEntry, int int32) /* MethodBuilder.Create */ ;

				}

		}

		/// <java-name>
		/// android/app/FragmentManager
		/// </java-name>
		[Dot42.DexImport("android/app/FragmentManager", AccessFlags = 1057)]
		public abstract partial class FragmentManager
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// POP_BACK_STACK_INCLUSIVE
				/// </java-name>
				[Dot42.DexImport("POP_BACK_STACK_INCLUSIVE", "I", AccessFlags = 25)]
				public const int POP_BACK_STACK_INCLUSIVE = 1;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public FragmentManager() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// beginTransaction
				/// </java-name>
				[Dot42.DexImport("beginTransaction", "()Landroid/app/FragmentTransaction;", AccessFlags = 1025)]
				public abstract global::Android.App.FragmentTransaction BeginTransaction() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// executePendingTransactions
				/// </java-name>
				[Dot42.DexImport("executePendingTransactions", "()Z", AccessFlags = 1025)]
				public abstract bool ExecutePendingTransactions() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// findFragmentById
				/// </java-name>
				[Dot42.DexImport("findFragmentById", "(I)Landroid/app/Fragment;", AccessFlags = 1025)]
				public abstract global::Android.App.Fragment FindFragmentById(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// findFragmentByTag
				/// </java-name>
				[Dot42.DexImport("findFragmentByTag", "(Ljava/lang/String;)Landroid/app/Fragment;", AccessFlags = 1025)]
				public abstract global::Android.App.Fragment FindFragmentByTag(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// popBackStack
				/// </java-name>
				[Dot42.DexImport("popBackStack", "()V", AccessFlags = 1025)]
				public abstract void PopBackStack() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// popBackStackImmediate
				/// </java-name>
				[Dot42.DexImport("popBackStackImmediate", "()Z", AccessFlags = 1025)]
				public abstract bool PopBackStackImmediate() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// popBackStack
				/// </java-name>
				[Dot42.DexImport("popBackStack", "(Ljava/lang/String;I)V", AccessFlags = 1025)]
				public abstract void PopBackStack(string @string, int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// popBackStackImmediate
				/// </java-name>
				[Dot42.DexImport("popBackStackImmediate", "(Ljava/lang/String;I)Z", AccessFlags = 1025)]
				public abstract bool PopBackStackImmediate(string @string, int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// popBackStack
				/// </java-name>
				[Dot42.DexImport("popBackStack", "(II)V", AccessFlags = 1025)]
				public abstract void PopBackStack(int int32, int int321) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// popBackStackImmediate
				/// </java-name>
				[Dot42.DexImport("popBackStackImmediate", "(II)Z", AccessFlags = 1025)]
				public abstract bool PopBackStackImmediate(int int32, int int321) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getBackStackEntryAt
				/// </java-name>
				[Dot42.DexImport("getBackStackEntryAt", "(I)Landroid/app/FragmentManager$BackStackEntry;", AccessFlags = 1025)]
				public abstract global::Android.App.FragmentManager.IBackStackEntry GetBackStackEntryAt(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// addOnBackStackChangedListener
				/// </java-name>
				[Dot42.DexImport("addOnBackStackChangedListener", "(Landroid/app/FragmentManager$OnBackStackChangedListener;)V", AccessFlags = 1025)]
				public abstract void AddOnBackStackChangedListener(global::Android.App.FragmentManager.IOnBackStackChangedListener onBackStackChangedListener) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// removeOnBackStackChangedListener
				/// </java-name>
				[Dot42.DexImport("removeOnBackStackChangedListener", "(Landroid/app/FragmentManager$OnBackStackChangedListener;)V", AccessFlags = 1025)]
				public abstract void RemoveOnBackStackChangedListener(global::Android.App.FragmentManager.IOnBackStackChangedListener onBackStackChangedListener) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// putFragment
				/// </java-name>
				[Dot42.DexImport("putFragment", "(Landroid/os/Bundle;Ljava/lang/String;Landroid/app/Fragment;)V", AccessFlags = 1025)]
				public abstract void PutFragment(global::Android.OS.Bundle bundle, string @string, global::Android.App.Fragment fragment) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getFragment
				/// </java-name>
				[Dot42.DexImport("getFragment", "(Landroid/os/Bundle;Ljava/lang/String;)Landroid/app/Fragment;", AccessFlags = 1025)]
				public abstract global::Android.App.Fragment GetFragment(global::Android.OS.Bundle bundle, string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// saveFragmentInstanceState
				/// </java-name>
				[Dot42.DexImport("saveFragmentInstanceState", "(Landroid/app/Fragment;)Landroid/app/Fragment$SavedState;", AccessFlags = 1025)]
				public abstract global::Android.App.Fragment.SavedState SaveFragmentInstanceState(global::Android.App.Fragment fragment) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// dump
				/// </java-name>
				[Dot42.DexImport("dump", "(Ljava/lang/String;Ljava/io/FileDescriptor;Ljava/io/PrintWriter;[Ljava/lang/Strin" +
    "g;)V", AccessFlags = 1025)]
				public abstract void Dump(string @string, global::Java.IO.FileDescriptor fileDescriptor, global::Java.IO.PrintWriter printWriter, string[] string1) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// enableDebugLogging
				/// </java-name>
				[Dot42.DexImport("enableDebugLogging", "(Z)V", AccessFlags = 9)]
				public static void EnableDebugLogging(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// invalidateOptionsMenu
				/// </java-name>
				[Dot42.DexImport("invalidateOptionsMenu", "()V", AccessFlags = 1)]
				public virtual void InvalidateOptionsMenu() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getBackStackEntryCount
				/// </java-name>
				public abstract int BackStackEntryCount
				{
						[Dot42.DexImport("getBackStackEntryCount", "()I", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// android/app/FragmentManager$OnBackStackChangedListener
				/// </java-name>
				[Dot42.DexImport("android/app/FragmentManager$OnBackStackChangedListener", AccessFlags = 1545)]
				public partial interface IOnBackStackChangedListener
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onBackStackChanged
						/// </java-name>
						[Dot42.DexImport("onBackStackChanged", "()V", AccessFlags = 1025)]
						void OnBackStackChanged() /* MethodBuilder.Create */ ;

				}

				/// <java-name>
				/// android/app/FragmentManager$BackStackEntry
				/// </java-name>
				[Dot42.DexImport("android/app/FragmentManager$BackStackEntry", AccessFlags = 1545)]
				public partial interface IBackStackEntry
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// getId
						/// </java-name>
						int Id
						{
								[Dot42.DexImport("getId", "()I", AccessFlags = 1025)]
								get;
						}

						/// <java-name>
						/// getName
						/// </java-name>
						string Name
						{
								[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1025)]
								get;
						}

						/// <java-name>
						/// getBreadCrumbTitleRes
						/// </java-name>
						int BreadCrumbTitleRes
						{
								[Dot42.DexImport("getBreadCrumbTitleRes", "()I", AccessFlags = 1025)]
								get;
						}

						/// <java-name>
						/// getBreadCrumbShortTitleRes
						/// </java-name>
						int BreadCrumbShortTitleRes
						{
								[Dot42.DexImport("getBreadCrumbShortTitleRes", "()I", AccessFlags = 1025)]
								get;
						}

						/// <java-name>
						/// getBreadCrumbTitle
						/// </java-name>
						global::Java.Lang.ICharSequence BreadCrumbTitle
						{
								[Dot42.DexImport("getBreadCrumbTitle", "()Ljava/lang/CharSequence;", AccessFlags = 1025)]
								get;
						}

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

		/// <java-name>
		/// android/app/FragmentTransaction
		/// </java-name>
		[Dot42.DexImport("android/app/FragmentTransaction", AccessFlags = 1057)]
		public abstract partial class FragmentTransaction
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// TRANSIT_ENTER_MASK
				/// </java-name>
				[Dot42.DexImport("TRANSIT_ENTER_MASK", "I", AccessFlags = 25)]
				public const int TRANSIT_ENTER_MASK = 4096;
				/// <java-name>
				/// TRANSIT_EXIT_MASK
				/// </java-name>
				[Dot42.DexImport("TRANSIT_EXIT_MASK", "I", AccessFlags = 25)]
				public const int TRANSIT_EXIT_MASK = 8192;
				/// <java-name>
				/// TRANSIT_UNSET
				/// </java-name>
				[Dot42.DexImport("TRANSIT_UNSET", "I", AccessFlags = 25)]
				public const int TRANSIT_UNSET = -1;
				/// <java-name>
				/// TRANSIT_NONE
				/// </java-name>
				[Dot42.DexImport("TRANSIT_NONE", "I", AccessFlags = 25)]
				public const int TRANSIT_NONE = 0;
				/// <java-name>
				/// TRANSIT_FRAGMENT_OPEN
				/// </java-name>
				[Dot42.DexImport("TRANSIT_FRAGMENT_OPEN", "I", AccessFlags = 25)]
				public const int TRANSIT_FRAGMENT_OPEN = 4097;
				/// <java-name>
				/// TRANSIT_FRAGMENT_CLOSE
				/// </java-name>
				[Dot42.DexImport("TRANSIT_FRAGMENT_CLOSE", "I", AccessFlags = 25)]
				public const int TRANSIT_FRAGMENT_CLOSE = 8194;
				/// <java-name>
				/// TRANSIT_FRAGMENT_FADE
				/// </java-name>
				[Dot42.DexImport("TRANSIT_FRAGMENT_FADE", "I", AccessFlags = 25)]
				public const int TRANSIT_FRAGMENT_FADE = 4099;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public FragmentTransaction() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// add
				/// </java-name>
				[Dot42.DexImport("add", "(Landroid/app/Fragment;Ljava/lang/String;)Landroid/app/FragmentTransaction;", AccessFlags = 1025)]
				public abstract global::Android.App.FragmentTransaction Add(global::Android.App.Fragment fragment, string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// add
				/// </java-name>
				[Dot42.DexImport("add", "(ILandroid/app/Fragment;)Landroid/app/FragmentTransaction;", AccessFlags = 1025)]
				public abstract global::Android.App.FragmentTransaction Add(int int32, global::Android.App.Fragment fragment) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// add
				/// </java-name>
				[Dot42.DexImport("add", "(ILandroid/app/Fragment;Ljava/lang/String;)Landroid/app/FragmentTransaction;", AccessFlags = 1025)]
				public abstract global::Android.App.FragmentTransaction Add(int int32, global::Android.App.Fragment fragment, string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// replace
				/// </java-name>
				[Dot42.DexImport("replace", "(ILandroid/app/Fragment;)Landroid/app/FragmentTransaction;", AccessFlags = 1025)]
				public abstract global::Android.App.FragmentTransaction Replace(int int32, global::Android.App.Fragment fragment) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// replace
				/// </java-name>
				[Dot42.DexImport("replace", "(ILandroid/app/Fragment;Ljava/lang/String;)Landroid/app/FragmentTransaction;", AccessFlags = 1025)]
				public abstract global::Android.App.FragmentTransaction Replace(int int32, global::Android.App.Fragment fragment, string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// remove
				/// </java-name>
				[Dot42.DexImport("remove", "(Landroid/app/Fragment;)Landroid/app/FragmentTransaction;", AccessFlags = 1025)]
				public abstract global::Android.App.FragmentTransaction Remove(global::Android.App.Fragment fragment) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// hide
				/// </java-name>
				[Dot42.DexImport("hide", "(Landroid/app/Fragment;)Landroid/app/FragmentTransaction;", AccessFlags = 1025)]
				public abstract global::Android.App.FragmentTransaction Hide(global::Android.App.Fragment fragment) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// show
				/// </java-name>
				[Dot42.DexImport("show", "(Landroid/app/Fragment;)Landroid/app/FragmentTransaction;", AccessFlags = 1025)]
				public abstract global::Android.App.FragmentTransaction Show(global::Android.App.Fragment fragment) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// detach
				/// </java-name>
				[Dot42.DexImport("detach", "(Landroid/app/Fragment;)Landroid/app/FragmentTransaction;", AccessFlags = 1025)]
				public abstract global::Android.App.FragmentTransaction Detach(global::Android.App.Fragment fragment) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// attach
				/// </java-name>
				[Dot42.DexImport("attach", "(Landroid/app/Fragment;)Landroid/app/FragmentTransaction;", AccessFlags = 1025)]
				public abstract global::Android.App.FragmentTransaction Attach(global::Android.App.Fragment fragment) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setCustomAnimations
				/// </java-name>
				[Dot42.DexImport("setCustomAnimations", "(II)Landroid/app/FragmentTransaction;", AccessFlags = 1025)]
				public abstract global::Android.App.FragmentTransaction SetCustomAnimations(int int32, int int321) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setCustomAnimations
				/// </java-name>
				[Dot42.DexImport("setCustomAnimations", "(IIII)Landroid/app/FragmentTransaction;", AccessFlags = 1025)]
				public abstract global::Android.App.FragmentTransaction SetCustomAnimations(int int32, int int321, int int322, int int323) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setTransition
				/// </java-name>
				[Dot42.DexImport("setTransition", "(I)Landroid/app/FragmentTransaction;", AccessFlags = 1025)]
				public abstract global::Android.App.FragmentTransaction SetTransition(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setTransitionStyle
				/// </java-name>
				[Dot42.DexImport("setTransitionStyle", "(I)Landroid/app/FragmentTransaction;", AccessFlags = 1025)]
				public abstract global::Android.App.FragmentTransaction SetTransitionStyle(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// addToBackStack
				/// </java-name>
				[Dot42.DexImport("addToBackStack", "(Ljava/lang/String;)Landroid/app/FragmentTransaction;", AccessFlags = 1025)]
				public abstract global::Android.App.FragmentTransaction AddToBackStack(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// disallowAddToBackStack
				/// </java-name>
				[Dot42.DexImport("disallowAddToBackStack", "()Landroid/app/FragmentTransaction;", AccessFlags = 1025)]
				public abstract global::Android.App.FragmentTransaction DisallowAddToBackStack() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setBreadCrumbTitle
				/// </java-name>
				[Dot42.DexImport("setBreadCrumbTitle", "(I)Landroid/app/FragmentTransaction;", AccessFlags = 1025)]
				public abstract global::Android.App.FragmentTransaction SetBreadCrumbTitle(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setBreadCrumbTitle
				/// </java-name>
				[Dot42.DexImport("setBreadCrumbTitle", "(Ljava/lang/CharSequence;)Landroid/app/FragmentTransaction;", AccessFlags = 1025)]
				public abstract global::Android.App.FragmentTransaction SetBreadCrumbTitle(global::Java.Lang.ICharSequence charSequence) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setBreadCrumbShortTitle
				/// </java-name>
				[Dot42.DexImport("setBreadCrumbShortTitle", "(I)Landroid/app/FragmentTransaction;", AccessFlags = 1025)]
				public abstract global::Android.App.FragmentTransaction SetBreadCrumbShortTitle(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setBreadCrumbShortTitle
				/// </java-name>
				[Dot42.DexImport("setBreadCrumbShortTitle", "(Ljava/lang/CharSequence;)Landroid/app/FragmentTransaction;", AccessFlags = 1025)]
				public abstract global::Android.App.FragmentTransaction SetBreadCrumbShortTitle(global::Java.Lang.ICharSequence charSequence) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// commit
				/// </java-name>
				[Dot42.DexImport("commit", "()I", AccessFlags = 1025)]
				public abstract int Commit() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// commitAllowingStateLoss
				/// </java-name>
				[Dot42.DexImport("commitAllowingStateLoss", "()I", AccessFlags = 1025)]
				public abstract int CommitAllowingStateLoss() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// isEmpty
				/// </java-name>
				public abstract bool IsEmpty
				{
						[Dot42.DexImport("isEmpty", "()Z", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// isAddToBackStackAllowed
				/// </java-name>
				public abstract bool IsAddToBackStackAllowed
				{
						[Dot42.DexImport("isAddToBackStackAllowed", "()Z", AccessFlags = 1025)]
						get;
				}

		}

		/// <java-name>
		/// android/app/Instrumentation
		/// </java-name>
		[Dot42.DexImport("android/app/Instrumentation", AccessFlags = 33)]
		public partial class Instrumentation
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// REPORT_KEY_IDENTIFIER
				/// </java-name>
				[Dot42.DexImport("REPORT_KEY_IDENTIFIER", "Ljava/lang/String;", AccessFlags = 25)]
				public const string REPORT_KEY_IDENTIFIER = "id";
				/// <java-name>
				/// REPORT_KEY_STREAMRESULT
				/// </java-name>
				[Dot42.DexImport("REPORT_KEY_STREAMRESULT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string REPORT_KEY_STREAMRESULT = "stream";
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Instrumentation() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onCreate
				/// </java-name>
				[Dot42.DexImport("onCreate", "(Landroid/os/Bundle;)V", AccessFlags = 1)]
				public virtual void OnCreate(global::Android.OS.Bundle bundle) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// start
				/// </java-name>
				[Dot42.DexImport("start", "()V", AccessFlags = 1)]
				public virtual void Start() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onStart
				/// </java-name>
				[Dot42.DexImport("onStart", "()V", AccessFlags = 1)]
				public virtual void OnStart() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onException
				/// </java-name>
				[Dot42.DexImport("onException", "(Ljava/lang/Object;Ljava/lang/Throwable;)Z", AccessFlags = 1)]
				public virtual bool OnException(object @object, global::System.Exception exception) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// sendStatus
				/// </java-name>
				[Dot42.DexImport("sendStatus", "(ILandroid/os/Bundle;)V", AccessFlags = 1)]
				public virtual void SendStatus(int int32, global::Android.OS.Bundle bundle) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// finish
				/// </java-name>
				[Dot42.DexImport("finish", "(ILandroid/os/Bundle;)V", AccessFlags = 1)]
				public virtual void Finish(int int32, global::Android.OS.Bundle bundle) /* MethodBuilder.Create */ 
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

				/// <java-name>
				/// onDestroy
				/// </java-name>
				[Dot42.DexImport("onDestroy", "()V", AccessFlags = 1)]
				public virtual void OnDestroy() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// startProfiling
				/// </java-name>
				[Dot42.DexImport("startProfiling", "()V", AccessFlags = 1)]
				public virtual void StartProfiling() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// stopProfiling
				/// </java-name>
				[Dot42.DexImport("stopProfiling", "()V", AccessFlags = 1)]
				public virtual void StopProfiling() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setInTouchMode
				/// </java-name>
				[Dot42.DexImport("setInTouchMode", "(Z)V", AccessFlags = 1)]
				public virtual void SetInTouchMode(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// waitForIdle
				/// </java-name>
				[Dot42.DexImport("waitForIdle", "(Ljava/lang/Runnable;)V", AccessFlags = 1)]
				public virtual void WaitForIdle(global::Java.Lang.IRunnable runnable) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// waitForIdleSync
				/// </java-name>
				[Dot42.DexImport("waitForIdleSync", "()V", AccessFlags = 1)]
				public virtual void WaitForIdleSync() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// runOnMainSync
				/// </java-name>
				[Dot42.DexImport("runOnMainSync", "(Ljava/lang/Runnable;)V", AccessFlags = 1)]
				public virtual void RunOnMainSync(global::Java.Lang.IRunnable runnable) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// startActivitySync
				/// </java-name>
				[Dot42.DexImport("startActivitySync", "(Landroid/content/Intent;)Landroid/app/Activity;", AccessFlags = 1)]
				public virtual global::Android.App.Activity StartActivitySync(global::Android.Content.Intent intent) /* MethodBuilder.Create */ 
				{
						return default(global::Android.App.Activity);
				}

				/// <java-name>
				/// addMonitor
				/// </java-name>
				[Dot42.DexImport("addMonitor", "(Landroid/app/Instrumentation$ActivityMonitor;)V", AccessFlags = 1)]
				public virtual void AddMonitor(global::Android.App.Instrumentation.ActivityMonitor activityMonitor) /* MethodBuilder.Create */ 
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

				/// <java-name>
				/// checkMonitorHit
				/// </java-name>
				[Dot42.DexImport("checkMonitorHit", "(Landroid/app/Instrumentation$ActivityMonitor;I)Z", AccessFlags = 1)]
				public virtual bool CheckMonitorHit(global::Android.App.Instrumentation.ActivityMonitor activityMonitor, int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// waitForMonitor
				/// </java-name>
				[Dot42.DexImport("waitForMonitor", "(Landroid/app/Instrumentation$ActivityMonitor;)Landroid/app/Activity;", AccessFlags = 1)]
				public virtual global::Android.App.Activity WaitForMonitor(global::Android.App.Instrumentation.ActivityMonitor activityMonitor) /* MethodBuilder.Create */ 
				{
						return default(global::Android.App.Activity);
				}

				/// <java-name>
				/// waitForMonitorWithTimeout
				/// </java-name>
				[Dot42.DexImport("waitForMonitorWithTimeout", "(Landroid/app/Instrumentation$ActivityMonitor;J)Landroid/app/Activity;", AccessFlags = 1)]
				public virtual global::Android.App.Activity WaitForMonitorWithTimeout(global::Android.App.Instrumentation.ActivityMonitor activityMonitor, long int64) /* MethodBuilder.Create */ 
				{
						return default(global::Android.App.Activity);
				}

				/// <java-name>
				/// removeMonitor
				/// </java-name>
				[Dot42.DexImport("removeMonitor", "(Landroid/app/Instrumentation$ActivityMonitor;)V", AccessFlags = 1)]
				public virtual void RemoveMonitor(global::Android.App.Instrumentation.ActivityMonitor activityMonitor) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// invokeMenuActionSync
				/// </java-name>
				[Dot42.DexImport("invokeMenuActionSync", "(Landroid/app/Activity;II)Z", AccessFlags = 1)]
				public virtual bool InvokeMenuActionSync(global::Android.App.Activity activity, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// invokeContextMenuAction
				/// </java-name>
				[Dot42.DexImport("invokeContextMenuAction", "(Landroid/app/Activity;II)Z", AccessFlags = 1)]
				public virtual bool InvokeContextMenuAction(global::Android.App.Activity activity, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// sendStringSync
				/// </java-name>
				[Dot42.DexImport("sendStringSync", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SendStringSync(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// sendKeySync
				/// </java-name>
				[Dot42.DexImport("sendKeySync", "(Landroid/view/KeyEvent;)V", AccessFlags = 1)]
				public virtual void SendKeySync(global::Android.Views.KeyEvent keyEvent) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// sendKeyDownUpSync
				/// </java-name>
				[Dot42.DexImport("sendKeyDownUpSync", "(I)V", AccessFlags = 1)]
				public virtual void SendKeyDownUpSync(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// sendCharacterSync
				/// </java-name>
				[Dot42.DexImport("sendCharacterSync", "(I)V", AccessFlags = 1)]
				public virtual void SendCharacterSync(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// sendPointerSync
				/// </java-name>
				[Dot42.DexImport("sendPointerSync", "(Landroid/view/MotionEvent;)V", AccessFlags = 1)]
				public virtual void SendPointerSync(global::Android.Views.MotionEvent motionEvent) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// sendTrackballEventSync
				/// </java-name>
				[Dot42.DexImport("sendTrackballEventSync", "(Landroid/view/MotionEvent;)V", AccessFlags = 1)]
				public virtual void SendTrackballEventSync(global::Android.Views.MotionEvent motionEvent) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// newApplication
				/// </java-name>
				[Dot42.DexImport("newApplication", "(Ljava/lang/ClassLoader;Ljava/lang/String;Landroid/content/Context;)Landroid/app/" +
    "Application;", AccessFlags = 1)]
				public virtual global::Android.App.Application NewApplication(global::Java.Lang.ClassLoader classLoader, string @string, global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
						return default(global::Android.App.Application);
				}

				/// <java-name>
				/// newApplication
				/// </java-name>
				[Dot42.DexImport("newApplication", "(Ljava/lang/Class;Landroid/content/Context;)Landroid/app/Application;", AccessFlags = 9, Signature = "(Ljava/lang/Class<*>;Landroid/content/Context;)Landroid/app/Application;")]
				public static global::Android.App.Application NewApplication(global::System.Type type, global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
						return default(global::Android.App.Application);
				}

				/// <java-name>
				/// callApplicationOnCreate
				/// </java-name>
				[Dot42.DexImport("callApplicationOnCreate", "(Landroid/app/Application;)V", AccessFlags = 1)]
				public virtual void CallApplicationOnCreate(global::Android.App.Application application) /* MethodBuilder.Create */ 
				{
				}

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
				public virtual global::Android.App.Activity NewActivity(global::System.Type type, global::Android.Content.Context context, global::Android.OS.IBinder binder, global::Android.App.Application application, global::Android.Content.Intent intent, global::Android.Content.PM.ActivityInfo activityInfo, global::Java.Lang.ICharSequence charSequence, global::Android.App.Activity activity, string @string, object @object) /* MethodBuilder.Create */ 
				{
						return default(global::Android.App.Activity);
				}

				/// <java-name>
				/// newActivity
				/// </java-name>
				[Dot42.DexImport("newActivity", "(Ljava/lang/ClassLoader;Ljava/lang/String;Landroid/content/Intent;)Landroid/app/A" +
    "ctivity;", AccessFlags = 1)]
				public virtual global::Android.App.Activity NewActivity(global::Java.Lang.ClassLoader classLoader, string @string, global::Android.Content.Intent intent) /* MethodBuilder.Create */ 
				{
						return default(global::Android.App.Activity);
				}

				/// <java-name>
				/// callActivityOnCreate
				/// </java-name>
				[Dot42.DexImport("callActivityOnCreate", "(Landroid/app/Activity;Landroid/os/Bundle;)V", AccessFlags = 1)]
				public virtual void CallActivityOnCreate(global::Android.App.Activity activity, global::Android.OS.Bundle bundle) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// callActivityOnDestroy
				/// </java-name>
				[Dot42.DexImport("callActivityOnDestroy", "(Landroid/app/Activity;)V", AccessFlags = 1)]
				public virtual void CallActivityOnDestroy(global::Android.App.Activity activity) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// callActivityOnRestoreInstanceState
				/// </java-name>
				[Dot42.DexImport("callActivityOnRestoreInstanceState", "(Landroid/app/Activity;Landroid/os/Bundle;)V", AccessFlags = 1)]
				public virtual void CallActivityOnRestoreInstanceState(global::Android.App.Activity activity, global::Android.OS.Bundle bundle) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// callActivityOnPostCreate
				/// </java-name>
				[Dot42.DexImport("callActivityOnPostCreate", "(Landroid/app/Activity;Landroid/os/Bundle;)V", AccessFlags = 1)]
				public virtual void CallActivityOnPostCreate(global::Android.App.Activity activity, global::Android.OS.Bundle bundle) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// callActivityOnNewIntent
				/// </java-name>
				[Dot42.DexImport("callActivityOnNewIntent", "(Landroid/app/Activity;Landroid/content/Intent;)V", AccessFlags = 1)]
				public virtual void CallActivityOnNewIntent(global::Android.App.Activity activity, global::Android.Content.Intent intent) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// callActivityOnStart
				/// </java-name>
				[Dot42.DexImport("callActivityOnStart", "(Landroid/app/Activity;)V", AccessFlags = 1)]
				public virtual void CallActivityOnStart(global::Android.App.Activity activity) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// callActivityOnRestart
				/// </java-name>
				[Dot42.DexImport("callActivityOnRestart", "(Landroid/app/Activity;)V", AccessFlags = 1)]
				public virtual void CallActivityOnRestart(global::Android.App.Activity activity) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// callActivityOnResume
				/// </java-name>
				[Dot42.DexImport("callActivityOnResume", "(Landroid/app/Activity;)V", AccessFlags = 1)]
				public virtual void CallActivityOnResume(global::Android.App.Activity activity) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// callActivityOnStop
				/// </java-name>
				[Dot42.DexImport("callActivityOnStop", "(Landroid/app/Activity;)V", AccessFlags = 1)]
				public virtual void CallActivityOnStop(global::Android.App.Activity activity) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// callActivityOnSaveInstanceState
				/// </java-name>
				[Dot42.DexImport("callActivityOnSaveInstanceState", "(Landroid/app/Activity;Landroid/os/Bundle;)V", AccessFlags = 1)]
				public virtual void CallActivityOnSaveInstanceState(global::Android.App.Activity activity, global::Android.OS.Bundle bundle) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// callActivityOnPause
				/// </java-name>
				[Dot42.DexImport("callActivityOnPause", "(Landroid/app/Activity;)V", AccessFlags = 1)]
				public virtual void CallActivityOnPause(global::Android.App.Activity activity) /* MethodBuilder.Create */ 
				{
				}

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

				/// <java-name>
				/// getContext
				/// </java-name>
				public virtual global::Android.Content.Context Context
				{
						[Dot42.DexImport("getContext", "()Landroid/content/Context;", AccessFlags = 1)]
						get{ return default(global::Android.Content.Context); }
				}

				/// <java-name>
				/// getComponentName
				/// </java-name>
				public virtual global::Android.Content.ComponentName ComponentName
				{
						[Dot42.DexImport("getComponentName", "()Landroid/content/ComponentName;", AccessFlags = 1)]
						get{ return default(global::Android.Content.ComponentName); }
				}

				/// <java-name>
				/// getTargetContext
				/// </java-name>
				public virtual global::Android.Content.Context TargetContext
				{
						[Dot42.DexImport("getTargetContext", "()Landroid/content/Context;", AccessFlags = 1)]
						get{ return default(global::Android.Content.Context); }
				}

				/// <java-name>
				/// isProfiling
				/// </java-name>
				public virtual bool IsProfiling
				{
						[Dot42.DexImport("isProfiling", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// getAllocCounts
				/// </java-name>
				public virtual global::Android.OS.Bundle AllocCounts
				{
						[Dot42.DexImport("getAllocCounts", "()Landroid/os/Bundle;", AccessFlags = 1)]
						get{ return default(global::Android.OS.Bundle); }
				}

				/// <java-name>
				/// getBinderCounts
				/// </java-name>
				public virtual global::Android.OS.Bundle BinderCounts
				{
						[Dot42.DexImport("getBinderCounts", "()Landroid/os/Bundle;", AccessFlags = 1)]
						get{ return default(global::Android.OS.Bundle); }
				}

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

						/// <java-name>
						/// getResultCode
						/// </java-name>
						public int ResultCode
						{
								[Dot42.DexImport("getResultCode", "()I", AccessFlags = 1)]
								get{ return default(int); }
						}

						/// <java-name>
						/// getResultData
						/// </java-name>
						public global::Android.Content.Intent ResultData
						{
								[Dot42.DexImport("getResultData", "()Landroid/content/Intent;", AccessFlags = 1)]
								get{ return default(global::Android.Content.Intent); }
						}

				}

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

						/// <java-name>
						/// waitForActivity
						/// </java-name>
						[Dot42.DexImport("waitForActivity", "()Landroid/app/Activity;", AccessFlags = 17)]
						public global::Android.App.Activity WaitForActivity() /* MethodBuilder.Create */ 
						{
								return default(global::Android.App.Activity);
						}

						/// <java-name>
						/// waitForActivityWithTimeout
						/// </java-name>
						[Dot42.DexImport("waitForActivityWithTimeout", "(J)Landroid/app/Activity;", AccessFlags = 17)]
						public global::Android.App.Activity WaitForActivityWithTimeout(long int64) /* MethodBuilder.Create */ 
						{
								return default(global::Android.App.Activity);
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal ActivityMonitor() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

						/// <java-name>
						/// getFilter
						/// </java-name>
						public global::Android.Content.IntentFilter Filter
						{
								[Dot42.DexImport("getFilter", "()Landroid/content/IntentFilter;", AccessFlags = 17)]
								get{ return default(global::Android.Content.IntentFilter); }
						}

						/// <java-name>
						/// getResult
						/// </java-name>
						public global::Android.App.Instrumentation.ActivityResult Result
						{
								[Dot42.DexImport("getResult", "()Landroid/app/Instrumentation$ActivityResult;", AccessFlags = 17)]
								get{ return default(global::Android.App.Instrumentation.ActivityResult); }
						}

						/// <java-name>
						/// isBlocking
						/// </java-name>
						public bool IsBlocking
						{
								[Dot42.DexImport("isBlocking", "()Z", AccessFlags = 17)]
								get{ return default(bool); }
						}

						/// <java-name>
						/// getHits
						/// </java-name>
						public int Hits
						{
								[Dot42.DexImport("getHits", "()I", AccessFlags = 17)]
								get{ return default(int); }
						}

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

		/// <java-name>
		/// android/app/IntentService
		/// </java-name>
		[Dot42.DexImport("android/app/IntentService", AccessFlags = 1057)]
		public abstract partial class IntentService : global::Android.App.Service
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public IntentService(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setIntentRedelivery
				/// </java-name>
				[Dot42.DexImport("setIntentRedelivery", "(Z)V", AccessFlags = 1)]
				public virtual void SetIntentRedelivery(bool boolean) /* MethodBuilder.Create */ 
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
				public override void OnStart(global::Android.Content.Intent intent, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onStartCommand
				/// </java-name>
				[Dot42.DexImport("onStartCommand", "(Landroid/content/Intent;II)I", AccessFlags = 1)]
				public override int OnStartCommand(global::Android.Content.Intent intent, int int32, int int321) /* MethodBuilder.Create */ 
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

				/// <java-name>
				/// onBind
				/// </java-name>
				[Dot42.DexImport("onBind", "(Landroid/content/Intent;)Landroid/os/IBinder;", AccessFlags = 1)]
				public override global::Android.OS.IBinder OnBind(global::Android.Content.Intent intent) /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.IBinder);
				}

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

				/// <java-name>
				/// newKeyguardLock
				/// </java-name>
				[Dot42.DexImport("newKeyguardLock", "(Ljava/lang/String;)Landroid/app/KeyguardManager$KeyguardLock;", AccessFlags = 1)]
				public virtual global::Android.App.KeyguardManager.KeyguardLock NewKeyguardLock(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Android.App.KeyguardManager.KeyguardLock);
				}

				/// <java-name>
				/// inKeyguardRestrictedInputMode
				/// </java-name>
				[Dot42.DexImport("inKeyguardRestrictedInputMode", "()Z", AccessFlags = 1)]
				public virtual bool InKeyguardRestrictedInputMode() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// exitKeyguardSecurely
				/// </java-name>
				[Dot42.DexImport("exitKeyguardSecurely", "(Landroid/app/KeyguardManager$OnKeyguardExitResult;)V", AccessFlags = 1)]
				public virtual void ExitKeyguardSecurely(global::Android.App.KeyguardManager.IOnKeyguardExitResult onKeyguardExitResult) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// android/app/KeyguardManager$OnKeyguardExitResult
				/// </java-name>
				[Dot42.DexImport("android/app/KeyguardManager$OnKeyguardExitResult", AccessFlags = 1545)]
				public partial interface IOnKeyguardExitResult
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onKeyguardExitResult
						/// </java-name>
						[Dot42.DexImport("onKeyguardExitResult", "(Z)V", AccessFlags = 1025)]
						void OnKeyguardExitResult(bool boolean) /* MethodBuilder.Create */ ;

				}

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

						/// <java-name>
						/// disableKeyguard
						/// </java-name>
						[Dot42.DexImport("disableKeyguard", "()V", AccessFlags = 1)]
						public virtual void DisableKeyguard() /* MethodBuilder.Create */ 
						{
						}

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
				protected internal override void OnCreate(global::Android.OS.Bundle bundle) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setTitle
				/// </java-name>
				[Dot42.DexImport("setTitle", "(Ljava/lang/CharSequence;)V", AccessFlags = 1)]
				public override void SetTitle(global::Java.Lang.ICharSequence charSequence) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setTitle
				/// </java-name>
				[Dot42.DexImport("setTitle", "(I)V", AccessFlags = 1)]
				public override void SetTitle(int int32) /* MethodBuilder.Create */ 
				{
				}

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
				protected internal override void OnListItemClick(global::Android.Widget.ListView listView, global::Android.Views.View view, int int32, long int64) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// intentForPosition
				/// </java-name>
				[Dot42.DexImport("intentForPosition", "(I)Landroid/content/Intent;", AccessFlags = 4)]
				protected internal virtual global::Android.Content.Intent IntentForPosition(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Intent);
				}

				/// <java-name>
				/// itemForPosition
				/// </java-name>
				[Dot42.DexImport("itemForPosition", "(I)Landroid/app/LauncherActivity$ListItem;", AccessFlags = 4)]
				protected internal virtual global::Android.App.LauncherActivity.ListItem ItemForPosition(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.App.LauncherActivity.ListItem);
				}

				/// <java-name>
				/// onQueryPackageManager
				/// </java-name>
				[Dot42.DexImport("onQueryPackageManager", "(Landroid/content/Intent;)Ljava/util/List;", AccessFlags = 4, Signature = "(Landroid/content/Intent;)Ljava/util/List<Landroid/content/pm/ResolveInfo;>;")]
				protected internal virtual global::Java.Util.IList<global::Android.Content.PM.ResolveInfo> OnQueryPackageManager(global::Android.Content.Intent intent) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<global::Android.Content.PM.ResolveInfo>);
				}

				/// <java-name>
				/// makeListItems
				/// </java-name>
				[Dot42.DexImport("makeListItems", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Landroid/app/LauncherActivity$ListItem;>;")]
				public virtual global::Java.Util.IList<global::Android.App.LauncherActivity.ListItem> MakeListItems() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<global::Android.App.LauncherActivity.ListItem>);
				}

				/// <java-name>
				/// getTargetIntent
				/// </java-name>
				protected internal virtual global::Android.Content.Intent TargetIntent
				{
						[Dot42.DexImport("getTargetIntent", "()Landroid/content/Intent;", AccessFlags = 4)]
						get{ return default(global::Android.Content.Intent); }
				}

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

						/// <java-name>
						/// createIconThumbnail
						/// </java-name>
						[Dot42.DexImport("createIconThumbnail", "(Landroid/graphics/drawable/Drawable;)Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
						public virtual global::Android.Graphics.Drawables.Drawable CreateIconThumbnail(global::Android.Graphics.Drawables.Drawable drawable) /* MethodBuilder.Create */ 
						{
								return default(global::Android.Graphics.Drawables.Drawable);
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal IconResizer() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

				}

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

				/// <java-name>
				/// onListItemClick
				/// </java-name>
				[Dot42.DexImport("onListItemClick", "(Landroid/widget/ListView;Landroid/view/View;IJ)V", AccessFlags = 4)]
				protected internal virtual void OnListItemClick(global::Android.Widget.ListView listView, global::Android.Views.View view, int int32, long int64) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onRestoreInstanceState
				/// </java-name>
				[Dot42.DexImport("onRestoreInstanceState", "(Landroid/os/Bundle;)V", AccessFlags = 4)]
				protected internal override void OnRestoreInstanceState(global::Android.OS.Bundle bundle) /* MethodBuilder.Create */ 
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
				/// onContentChanged
				/// </java-name>
				[Dot42.DexImport("onContentChanged", "()V", AccessFlags = 1)]
				public override void OnContentChanged() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setSelection
				/// </java-name>
				[Dot42.DexImport("setSelection", "(I)V", AccessFlags = 1)]
				public virtual void SetSelection(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getSelectedItemPosition
				/// </java-name>
				public virtual int SelectedItemPosition
				{
						[Dot42.DexImport("getSelectedItemPosition", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getSelectedItemId
				/// </java-name>
				public virtual long SelectedItemId
				{
						[Dot42.DexImport("getSelectedItemId", "()J", AccessFlags = 1)]
						get{ return default(long); }
				}

				/// <java-name>
				/// getListView
				/// </java-name>
				public virtual global::Android.Widget.ListView ListView
				{
						[Dot42.DexImport("getListView", "()Landroid/widget/ListView;", AccessFlags = 1)]
						get{ return default(global::Android.Widget.ListView); }
				}

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

				/// <java-name>
				/// onCreateView
				/// </java-name>
				[Dot42.DexImport("onCreateView", "(Landroid/view/LayoutInflater;Landroid/view/ViewGroup;Landroid/os/Bundle;)Landroi" +
    "d/view/View;", AccessFlags = 1)]
				public override global::Android.Views.View OnCreateView(global::Android.Views.LayoutInflater layoutInflater, global::Android.Views.ViewGroup viewGroup, global::Android.OS.Bundle bundle) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.View);
				}

				/// <java-name>
				/// onViewCreated
				/// </java-name>
				[Dot42.DexImport("onViewCreated", "(Landroid/view/View;Landroid/os/Bundle;)V", AccessFlags = 1)]
				public override void OnViewCreated(global::Android.Views.View view, global::Android.OS.Bundle bundle) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onDestroyView
				/// </java-name>
				[Dot42.DexImport("onDestroyView", "()V", AccessFlags = 1)]
				public override void OnDestroyView() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onListItemClick
				/// </java-name>
				[Dot42.DexImport("onListItemClick", "(Landroid/widget/ListView;Landroid/view/View;IJ)V", AccessFlags = 1)]
				public virtual void OnListItemClick(global::Android.Widget.ListView listView, global::Android.Views.View view, int int32, long int64) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setSelection
				/// </java-name>
				[Dot42.DexImport("setSelection", "(I)V", AccessFlags = 1)]
				public virtual void SetSelection(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setEmptyText
				/// </java-name>
				[Dot42.DexImport("setEmptyText", "(Ljava/lang/CharSequence;)V", AccessFlags = 1)]
				public virtual void SetEmptyText(global::Java.Lang.ICharSequence charSequence) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setListShown
				/// </java-name>
				[Dot42.DexImport("setListShown", "(Z)V", AccessFlags = 1)]
				public virtual void SetListShown(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setListShownNoAnimation
				/// </java-name>
				[Dot42.DexImport("setListShownNoAnimation", "(Z)V", AccessFlags = 1)]
				public virtual void SetListShownNoAnimation(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getSelectedItemPosition
				/// </java-name>
				public virtual int SelectedItemPosition
				{
						[Dot42.DexImport("getSelectedItemPosition", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getSelectedItemId
				/// </java-name>
				public virtual long SelectedItemId
				{
						[Dot42.DexImport("getSelectedItemId", "()J", AccessFlags = 1)]
						get{ return default(long); }
				}

				/// <java-name>
				/// getListView
				/// </java-name>
				public virtual global::Android.Widget.ListView ListView
				{
						[Dot42.DexImport("getListView", "()Landroid/widget/ListView;", AccessFlags = 1)]
						get{ return default(global::Android.Widget.ListView); }
				}

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

				/// <java-name>
				/// initLoader
				/// </java-name>
				[Dot42.DexImport("initLoader", "(ILandroid/os/Bundle;Landroid/app/LoaderManager$LoaderCallbacks;)Landroid/content" +
    "/Loader;", AccessFlags = 1025, Signature = "<D:Ljava/lang/Object;>(ILandroid/os/Bundle;Landroid/app/LoaderManager$LoaderCallb" +
    "acks<TD;>;)Landroid/content/Loader<TD;>;")]
				public abstract global::Android.Content.Loader<D> InitLoader<D>(int int32, global::Android.OS.Bundle bundle, global::Android.App.LoaderManager.ILoaderCallbacks<D> loaderCallbacks) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// restartLoader
				/// </java-name>
				[Dot42.DexImport("restartLoader", "(ILandroid/os/Bundle;Landroid/app/LoaderManager$LoaderCallbacks;)Landroid/content" +
    "/Loader;", AccessFlags = 1025, Signature = "<D:Ljava/lang/Object;>(ILandroid/os/Bundle;Landroid/app/LoaderManager$LoaderCallb" +
    "acks<TD;>;)Landroid/content/Loader<TD;>;")]
				public abstract global::Android.Content.Loader<D> RestartLoader<D>(int int32, global::Android.OS.Bundle bundle, global::Android.App.LoaderManager.ILoaderCallbacks<D> loaderCallbacks) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// destroyLoader
				/// </java-name>
				[Dot42.DexImport("destroyLoader", "(I)V", AccessFlags = 1025)]
				public abstract void DestroyLoader(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getLoader
				/// </java-name>
				[Dot42.DexImport("getLoader", "(I)Landroid/content/Loader;", AccessFlags = 1025, Signature = "<D:Ljava/lang/Object;>(I)Landroid/content/Loader<TD;>;")]
				public abstract global::Android.Content.Loader<D> GetLoader<D>(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// dump
				/// </java-name>
				[Dot42.DexImport("dump", "(Ljava/lang/String;Ljava/io/FileDescriptor;Ljava/io/PrintWriter;[Ljava/lang/Strin" +
    "g;)V", AccessFlags = 1025)]
				public abstract void Dump(string @string, global::Java.IO.FileDescriptor fileDescriptor, global::Java.IO.PrintWriter printWriter, string[] string1) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// enableDebugLogging
				/// </java-name>
				[Dot42.DexImport("enableDebugLogging", "(Z)V", AccessFlags = 9)]
				public static void EnableDebugLogging(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// android/app/LoaderManager$LoaderCallbacks
				/// </java-name>
				[Dot42.DexImport("android/app/LoaderManager$LoaderCallbacks", AccessFlags = 1545, Signature = "<D:Ljava/lang/Object;>Ljava/lang/Object;")]
				public partial interface ILoaderCallbacks<D>
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onCreateLoader
						/// </java-name>
						[Dot42.DexImport("onCreateLoader", "(ILandroid/os/Bundle;)Landroid/content/Loader;", AccessFlags = 1025, Signature = "(ILandroid/os/Bundle;)Landroid/content/Loader<TD;>;")]
						global::Android.Content.Loader<D> OnCreateLoader(int int32, global::Android.OS.Bundle bundle) /* MethodBuilder.Create */ ;

						/// <java-name>
						/// onLoadFinished
						/// </java-name>
						[Dot42.DexImport("onLoadFinished", "(Landroid/content/Loader;Ljava/lang/Object;)V", AccessFlags = 1025, Signature = "(Landroid/content/Loader<TD;>;TD;)V")]
						void OnLoadFinished(global::Android.Content.Loader<D> loader, D d) /* MethodBuilder.Create */ ;

						/// <java-name>
						/// onLoaderReset
						/// </java-name>
						[Dot42.DexImport("onLoaderReset", "(Landroid/content/Loader;)V", AccessFlags = 1025, Signature = "(Landroid/content/Loader<TD;>;)V")]
						void OnLoaderReset(global::Android.Content.Loader<D> loader) /* MethodBuilder.Create */ ;

				}

		}

		/// <java-name>
		/// android/app/LocalActivityManager
		/// </java-name>
		[Dot42.DexImport("android/app/LocalActivityManager", AccessFlags = 33)]
		public partial class LocalActivityManager
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/app/Activity;Z)V", AccessFlags = 1)]
				public LocalActivityManager(global::Android.App.Activity activity, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// startActivity
				/// </java-name>
				[Dot42.DexImport("startActivity", "(Ljava/lang/String;Landroid/content/Intent;)Landroid/view/Window;", AccessFlags = 1)]
				public virtual global::Android.Views.Window StartActivity(string @string, global::Android.Content.Intent intent) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.Window);
				}

				/// <java-name>
				/// destroyActivity
				/// </java-name>
				[Dot42.DexImport("destroyActivity", "(Ljava/lang/String;Z)Landroid/view/Window;", AccessFlags = 1)]
				public virtual global::Android.Views.Window DestroyActivity(string @string, bool boolean) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.Window);
				}

				/// <java-name>
				/// getActivity
				/// </java-name>
				[Dot42.DexImport("getActivity", "(Ljava/lang/String;)Landroid/app/Activity;", AccessFlags = 1)]
				public virtual global::Android.App.Activity GetActivity(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Android.App.Activity);
				}

				/// <java-name>
				/// dispatchCreate
				/// </java-name>
				[Dot42.DexImport("dispatchCreate", "(Landroid/os/Bundle;)V", AccessFlags = 1)]
				public virtual void DispatchCreate(global::Android.OS.Bundle bundle) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// saveInstanceState
				/// </java-name>
				[Dot42.DexImport("saveInstanceState", "()Landroid/os/Bundle;", AccessFlags = 1)]
				public virtual global::Android.OS.Bundle SaveInstanceState() /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.Bundle);
				}

				/// <java-name>
				/// dispatchResume
				/// </java-name>
				[Dot42.DexImport("dispatchResume", "()V", AccessFlags = 1)]
				public virtual void DispatchResume() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// dispatchPause
				/// </java-name>
				[Dot42.DexImport("dispatchPause", "(Z)V", AccessFlags = 1)]
				public virtual void DispatchPause(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// dispatchStop
				/// </java-name>
				[Dot42.DexImport("dispatchStop", "()V", AccessFlags = 1)]
				public virtual void DispatchStop() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// removeAllActivities
				/// </java-name>
				[Dot42.DexImport("removeAllActivities", "()V", AccessFlags = 1)]
				public virtual void RemoveAllActivities() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// dispatchDestroy
				/// </java-name>
				[Dot42.DexImport("dispatchDestroy", "(Z)V", AccessFlags = 1)]
				public virtual void DispatchDestroy(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal LocalActivityManager() /* TypeBuilder.AddDefaultConstructor */ 
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
				/// getCurrentId
				/// </java-name>
				public virtual string CurrentId
				{
						[Dot42.DexImport("getCurrentId", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

		}

		/// <java-name>
		/// android/app/NativeActivity
		/// </java-name>
		[Dot42.DexImport("android/app/NativeActivity", AccessFlags = 33)]
		public partial class NativeActivity : global::Android.App.Activity, global::Android.Views.ISurfaceHolder_ICallback2, global::Android.Views.InputQueue.ICallback, global::Android.Views.ViewTreeObserver.IOnGlobalLayoutListener
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// META_DATA_LIB_NAME
				/// </java-name>
				[Dot42.DexImport("META_DATA_LIB_NAME", "Ljava/lang/String;", AccessFlags = 25)]
				public const string META_DATA_LIB_NAME = "android.app.lib_name";
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
				protected internal override void OnCreate(global::Android.OS.Bundle bundle) /* MethodBuilder.Create */ 
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
				protected internal override void OnSaveInstanceState(global::Android.OS.Bundle bundle) /* MethodBuilder.Create */ 
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

				/// <java-name>
				/// onConfigurationChanged
				/// </java-name>
				[Dot42.DexImport("onConfigurationChanged", "(Landroid/content/res/Configuration;)V", AccessFlags = 1)]
				public override void OnConfigurationChanged(global::Android.Content.Res.Configuration configuration) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onLowMemory
				/// </java-name>
				[Dot42.DexImport("onLowMemory", "()V", AccessFlags = 1)]
				public override void OnLowMemory() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onWindowFocusChanged
				/// </java-name>
				[Dot42.DexImport("onWindowFocusChanged", "(Z)V", AccessFlags = 1)]
				public override void OnWindowFocusChanged(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// dispatchKeyEvent
				/// </java-name>
				[Dot42.DexImport("dispatchKeyEvent", "(Landroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public override bool DispatchKeyEvent(global::Android.Views.KeyEvent keyEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// surfaceCreated
				/// </java-name>
				[Dot42.DexImport("surfaceCreated", "(Landroid/view/SurfaceHolder;)V", AccessFlags = 1)]
				public virtual void SurfaceCreated(global::Android.Views.ISurfaceHolder surfaceHolder) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// surfaceChanged
				/// </java-name>
				[Dot42.DexImport("surfaceChanged", "(Landroid/view/SurfaceHolder;III)V", AccessFlags = 1)]
				public virtual void SurfaceChanged(global::Android.Views.ISurfaceHolder surfaceHolder, int int32, int int321, int int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// surfaceRedrawNeeded
				/// </java-name>
				[Dot42.DexImport("surfaceRedrawNeeded", "(Landroid/view/SurfaceHolder;)V", AccessFlags = 1)]
				public virtual void SurfaceRedrawNeeded(global::Android.Views.ISurfaceHolder surfaceHolder) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// surfaceDestroyed
				/// </java-name>
				[Dot42.DexImport("surfaceDestroyed", "(Landroid/view/SurfaceHolder;)V", AccessFlags = 1)]
				public virtual void SurfaceDestroyed(global::Android.Views.ISurfaceHolder surfaceHolder) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onInputQueueCreated
				/// </java-name>
				[Dot42.DexImport("onInputQueueCreated", "(Landroid/view/InputQueue;)V", AccessFlags = 1)]
				public virtual void OnInputQueueCreated(global::Android.Views.InputQueue inputQueue) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onInputQueueDestroyed
				/// </java-name>
				[Dot42.DexImport("onInputQueueDestroyed", "(Landroid/view/InputQueue;)V", AccessFlags = 1)]
				public virtual void OnInputQueueDestroyed(global::Android.Views.InputQueue inputQueue) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onGlobalLayout
				/// </java-name>
				[Dot42.DexImport("onGlobalLayout", "()V", AccessFlags = 1)]
				public virtual void OnGlobalLayout() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// android/app/Notification
		/// </java-name>
		[Dot42.DexImport("android/app/Notification", AccessFlags = 33)]
		public partial class Notification : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// DEFAULT_ALL
				/// </java-name>
				[Dot42.DexImport("DEFAULT_ALL", "I", AccessFlags = 25)]
				public const int DEFAULT_ALL = -1;
				/// <java-name>
				/// DEFAULT_SOUND
				/// </java-name>
				[Dot42.DexImport("DEFAULT_SOUND", "I", AccessFlags = 25)]
				public const int DEFAULT_SOUND = 1;
				/// <java-name>
				/// DEFAULT_VIBRATE
				/// </java-name>
				[Dot42.DexImport("DEFAULT_VIBRATE", "I", AccessFlags = 25)]
				public const int DEFAULT_VIBRATE = 2;
				/// <java-name>
				/// DEFAULT_LIGHTS
				/// </java-name>
				[Dot42.DexImport("DEFAULT_LIGHTS", "I", AccessFlags = 25)]
				public const int DEFAULT_LIGHTS = 4;
				/// <java-name>
				/// when
				/// </java-name>
				[Dot42.DexImport("when", "J", AccessFlags = 1)]
				public long When;
				/// <java-name>
				/// icon
				/// </java-name>
				[Dot42.DexImport("icon", "I", AccessFlags = 1)]
				public int Icon;
				/// <java-name>
				/// iconLevel
				/// </java-name>
				[Dot42.DexImport("iconLevel", "I", AccessFlags = 1)]
				public int IconLevel;
				/// <java-name>
				/// number
				/// </java-name>
				[Dot42.DexImport("number", "I", AccessFlags = 1)]
				public int Number;
				/// <java-name>
				/// contentIntent
				/// </java-name>
				[Dot42.DexImport("contentIntent", "Landroid/app/PendingIntent;", AccessFlags = 1)]
				public global::Android.App.PendingIntent ContentIntent;
				/// <java-name>
				/// deleteIntent
				/// </java-name>
				[Dot42.DexImport("deleteIntent", "Landroid/app/PendingIntent;", AccessFlags = 1)]
				public global::Android.App.PendingIntent DeleteIntent;
				/// <java-name>
				/// fullScreenIntent
				/// </java-name>
				[Dot42.DexImport("fullScreenIntent", "Landroid/app/PendingIntent;", AccessFlags = 1)]
				public global::Android.App.PendingIntent FullScreenIntent;
				/// <java-name>
				/// tickerText
				/// </java-name>
				[Dot42.DexImport("tickerText", "Ljava/lang/CharSequence;", AccessFlags = 1)]
				public global::Java.Lang.ICharSequence TickerText;
				/// <java-name>
				/// tickerView
				/// </java-name>
				[Dot42.DexImport("tickerView", "Landroid/widget/RemoteViews;", AccessFlags = 1)]
				public global::Android.Widget.RemoteViews TickerView;
				/// <java-name>
				/// contentView
				/// </java-name>
				[Dot42.DexImport("contentView", "Landroid/widget/RemoteViews;", AccessFlags = 1)]
				public global::Android.Widget.RemoteViews ContentView;
				/// <java-name>
				/// largeIcon
				/// </java-name>
				[Dot42.DexImport("largeIcon", "Landroid/graphics/Bitmap;", AccessFlags = 1)]
				public global::Android.Graphics.Bitmap LargeIcon;
				/// <java-name>
				/// sound
				/// </java-name>
				[Dot42.DexImport("sound", "Landroid/net/Uri;", AccessFlags = 1)]
				public global::Android.Net.Uri Sound;
				/// <java-name>
				/// STREAM_DEFAULT
				/// </java-name>
				[Dot42.DexImport("STREAM_DEFAULT", "I", AccessFlags = 25)]
				public const int STREAM_DEFAULT = -1;
				/// <java-name>
				/// audioStreamType
				/// </java-name>
				[Dot42.DexImport("audioStreamType", "I", AccessFlags = 1)]
				public int AudioStreamType;
				/// <java-name>
				/// vibrate
				/// </java-name>
				[Dot42.DexImport("vibrate", "[J", AccessFlags = 1)]
				public long[] Vibrate;
				/// <java-name>
				/// ledARGB
				/// </java-name>
				[Dot42.DexImport("ledARGB", "I", AccessFlags = 1)]
				public int LedARGB;
				/// <java-name>
				/// ledOnMS
				/// </java-name>
				[Dot42.DexImport("ledOnMS", "I", AccessFlags = 1)]
				public int LedOnMS;
				/// <java-name>
				/// ledOffMS
				/// </java-name>
				[Dot42.DexImport("ledOffMS", "I", AccessFlags = 1)]
				public int LedOffMS;
				/// <java-name>
				/// defaults
				/// </java-name>
				[Dot42.DexImport("defaults", "I", AccessFlags = 1)]
				public int Defaults;
				/// <java-name>
				/// FLAG_SHOW_LIGHTS
				/// </java-name>
				[Dot42.DexImport("FLAG_SHOW_LIGHTS", "I", AccessFlags = 25)]
				public const int FLAG_SHOW_LIGHTS = 1;
				/// <java-name>
				/// FLAG_ONGOING_EVENT
				/// </java-name>
				[Dot42.DexImport("FLAG_ONGOING_EVENT", "I", AccessFlags = 25)]
				public const int FLAG_ONGOING_EVENT = 2;
				/// <java-name>
				/// FLAG_INSISTENT
				/// </java-name>
				[Dot42.DexImport("FLAG_INSISTENT", "I", AccessFlags = 25)]
				public const int FLAG_INSISTENT = 4;
				/// <java-name>
				/// FLAG_ONLY_ALERT_ONCE
				/// </java-name>
				[Dot42.DexImport("FLAG_ONLY_ALERT_ONCE", "I", AccessFlags = 25)]
				public const int FLAG_ONLY_ALERT_ONCE = 8;
				/// <java-name>
				/// FLAG_AUTO_CANCEL
				/// </java-name>
				[Dot42.DexImport("FLAG_AUTO_CANCEL", "I", AccessFlags = 25)]
				public const int FLAG_AUTO_CANCEL = 16;
				/// <java-name>
				/// FLAG_NO_CLEAR
				/// </java-name>
				[Dot42.DexImport("FLAG_NO_CLEAR", "I", AccessFlags = 25)]
				public const int FLAG_NO_CLEAR = 32;
				/// <java-name>
				/// FLAG_FOREGROUND_SERVICE
				/// </java-name>
				[Dot42.DexImport("FLAG_FOREGROUND_SERVICE", "I", AccessFlags = 25)]
				public const int FLAG_FOREGROUND_SERVICE = 64;
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
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.App.Notification> CREATOR;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Notification() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(ILjava/lang/CharSequence;J)V", AccessFlags = 1)]
				public Notification(int int32, global::Java.Lang.ICharSequence charSequence, long int64) /* MethodBuilder.Create */ 
				{
				}

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

				/// <java-name>
				/// describeContents
				/// </java-name>
				[Dot42.DexImport("describeContents", "()I", AccessFlags = 1)]
				public virtual int DescribeContents() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public virtual void WriteToParcel(global::Android.OS.Parcel parcel, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setLatestEventInfo
				/// </java-name>
				[Dot42.DexImport("setLatestEventInfo", "(Landroid/content/Context;Ljava/lang/CharSequence;Ljava/lang/CharSequence;Landroi" +
    "d/app/PendingIntent;)V", AccessFlags = 1)]
				public virtual void SetLatestEventInfo(global::Android.Content.Context context, global::Java.Lang.ICharSequence charSequence, global::Java.Lang.ICharSequence charSequence1, global::Android.App.PendingIntent pendingIntent) /* MethodBuilder.Create */ 
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

						/// <java-name>
						/// setWhen
						/// </java-name>
						[Dot42.DexImport("setWhen", "(J)Landroid/app/Notification$Builder;", AccessFlags = 1)]
						public virtual Builder SetWhen(long int64) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// setSmallIcon
						/// </java-name>
						[Dot42.DexImport("setSmallIcon", "(I)Landroid/app/Notification$Builder;", AccessFlags = 1)]
						public virtual Builder SetSmallIcon(int int32) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// setSmallIcon
						/// </java-name>
						[Dot42.DexImport("setSmallIcon", "(II)Landroid/app/Notification$Builder;", AccessFlags = 1)]
						public virtual Builder SetSmallIcon(int int32, int int321) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// setContentTitle
						/// </java-name>
						[Dot42.DexImport("setContentTitle", "(Ljava/lang/CharSequence;)Landroid/app/Notification$Builder;", AccessFlags = 1)]
						public virtual Builder SetContentTitle(global::Java.Lang.ICharSequence charSequence) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// setContentText
						/// </java-name>
						[Dot42.DexImport("setContentText", "(Ljava/lang/CharSequence;)Landroid/app/Notification$Builder;", AccessFlags = 1)]
						public virtual Builder SetContentText(global::Java.Lang.ICharSequence charSequence) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// setNumber
						/// </java-name>
						[Dot42.DexImport("setNumber", "(I)Landroid/app/Notification$Builder;", AccessFlags = 1)]
						public virtual Builder SetNumber(int int32) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// setContentInfo
						/// </java-name>
						[Dot42.DexImport("setContentInfo", "(Ljava/lang/CharSequence;)Landroid/app/Notification$Builder;", AccessFlags = 1)]
						public virtual Builder SetContentInfo(global::Java.Lang.ICharSequence charSequence) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// setProgress
						/// </java-name>
						[Dot42.DexImport("setProgress", "(IIZ)Landroid/app/Notification$Builder;", AccessFlags = 1)]
						public virtual Builder SetProgress(int int32, int int321, bool boolean) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// setContent
						/// </java-name>
						[Dot42.DexImport("setContent", "(Landroid/widget/RemoteViews;)Landroid/app/Notification$Builder;", AccessFlags = 1)]
						public virtual Builder SetContent(global::Android.Widget.RemoteViews remoteViews) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// setContentIntent
						/// </java-name>
						[Dot42.DexImport("setContentIntent", "(Landroid/app/PendingIntent;)Landroid/app/Notification$Builder;", AccessFlags = 1)]
						public virtual Builder SetContentIntent(global::Android.App.PendingIntent pendingIntent) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// setDeleteIntent
						/// </java-name>
						[Dot42.DexImport("setDeleteIntent", "(Landroid/app/PendingIntent;)Landroid/app/Notification$Builder;", AccessFlags = 1)]
						public virtual Builder SetDeleteIntent(global::Android.App.PendingIntent pendingIntent) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// setFullScreenIntent
						/// </java-name>
						[Dot42.DexImport("setFullScreenIntent", "(Landroid/app/PendingIntent;Z)Landroid/app/Notification$Builder;", AccessFlags = 1)]
						public virtual Builder SetFullScreenIntent(global::Android.App.PendingIntent pendingIntent, bool boolean) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// setTicker
						/// </java-name>
						[Dot42.DexImport("setTicker", "(Ljava/lang/CharSequence;)Landroid/app/Notification$Builder;", AccessFlags = 1)]
						public virtual Builder SetTicker(global::Java.Lang.ICharSequence charSequence) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// setTicker
						/// </java-name>
						[Dot42.DexImport("setTicker", "(Ljava/lang/CharSequence;Landroid/widget/RemoteViews;)Landroid/app/Notification$B" +
    "uilder;", AccessFlags = 1)]
						public virtual Builder SetTicker(global::Java.Lang.ICharSequence charSequence, global::Android.Widget.RemoteViews remoteViews) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// setLargeIcon
						/// </java-name>
						[Dot42.DexImport("setLargeIcon", "(Landroid/graphics/Bitmap;)Landroid/app/Notification$Builder;", AccessFlags = 1)]
						public virtual Builder SetLargeIcon(global::Android.Graphics.Bitmap bitmap) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// setSound
						/// </java-name>
						[Dot42.DexImport("setSound", "(Landroid/net/Uri;)Landroid/app/Notification$Builder;", AccessFlags = 1)]
						public virtual Builder SetSound(global::Android.Net.Uri uri) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// setSound
						/// </java-name>
						[Dot42.DexImport("setSound", "(Landroid/net/Uri;I)Landroid/app/Notification$Builder;", AccessFlags = 1)]
						public virtual Builder SetSound(global::Android.Net.Uri uri, int int32) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// setVibrate
						/// </java-name>
						[Dot42.DexImport("setVibrate", "([J)Landroid/app/Notification$Builder;", AccessFlags = 1)]
						public virtual Builder SetVibrate(long[] int64) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// setLights
						/// </java-name>
						[Dot42.DexImport("setLights", "(III)Landroid/app/Notification$Builder;", AccessFlags = 1)]
						public virtual Builder SetLights(int int32, int int321, int int322) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// setOngoing
						/// </java-name>
						[Dot42.DexImport("setOngoing", "(Z)Landroid/app/Notification$Builder;", AccessFlags = 1)]
						public virtual Builder SetOngoing(bool boolean) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// setOnlyAlertOnce
						/// </java-name>
						[Dot42.DexImport("setOnlyAlertOnce", "(Z)Landroid/app/Notification$Builder;", AccessFlags = 1)]
						public virtual Builder SetOnlyAlertOnce(bool boolean) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// setAutoCancel
						/// </java-name>
						[Dot42.DexImport("setAutoCancel", "(Z)Landroid/app/Notification$Builder;", AccessFlags = 1)]
						public virtual Builder SetAutoCancel(bool boolean) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// setDefaults
						/// </java-name>
						[Dot42.DexImport("setDefaults", "(I)Landroid/app/Notification$Builder;", AccessFlags = 1)]
						public virtual Builder SetDefaults(int int32) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal Builder() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

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

				/// <java-name>
				/// notify
				/// </java-name>
				[Dot42.DexImport("notify", "(ILandroid/app/Notification;)V", AccessFlags = 1)]
				public virtual void Notify(int int32, global::Android.App.Notification notification) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// notify
				/// </java-name>
				[Dot42.DexImport("notify", "(Ljava/lang/String;ILandroid/app/Notification;)V", AccessFlags = 1)]
				public virtual void Notify(string @string, int int32, global::Android.App.Notification notification) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// cancel
				/// </java-name>
				[Dot42.DexImport("cancel", "(I)V", AccessFlags = 1)]
				public virtual void Cancel(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// cancel
				/// </java-name>
				[Dot42.DexImport("cancel", "(Ljava/lang/String;I)V", AccessFlags = 1)]
				public virtual void Cancel(string @string, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// cancelAll
				/// </java-name>
				[Dot42.DexImport("cancelAll", "()V", AccessFlags = 1)]
				public virtual void CancelAll() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// android/app/PendingIntent
		/// </java-name>
		[Dot42.DexImport("android/app/PendingIntent", AccessFlags = 49)]
		public sealed partial class PendingIntent : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// FLAG_ONE_SHOT
				/// </java-name>
				[Dot42.DexImport("FLAG_ONE_SHOT", "I", AccessFlags = 25)]
				public const int FLAG_ONE_SHOT = 1073741824;
				/// <java-name>
				/// FLAG_NO_CREATE
				/// </java-name>
				[Dot42.DexImport("FLAG_NO_CREATE", "I", AccessFlags = 25)]
				public const int FLAG_NO_CREATE = 536870912;
				/// <java-name>
				/// FLAG_CANCEL_CURRENT
				/// </java-name>
				[Dot42.DexImport("FLAG_CANCEL_CURRENT", "I", AccessFlags = 25)]
				public const int FLAG_CANCEL_CURRENT = 268435456;
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

				/// <java-name>
				/// getActivity
				/// </java-name>
				[Dot42.DexImport("getActivity", "(Landroid/content/Context;ILandroid/content/Intent;I)Landroid/app/PendingIntent;", AccessFlags = 9)]
				public static global::Android.App.PendingIntent GetActivity(global::Android.Content.Context context, int int32, global::Android.Content.Intent intent, int int321) /* MethodBuilder.Create */ 
				{
						return default(global::Android.App.PendingIntent);
				}

				/// <java-name>
				/// getActivities
				/// </java-name>
				[Dot42.DexImport("getActivities", "(Landroid/content/Context;I[Landroid/content/Intent;I)Landroid/app/PendingIntent;" +
    "", AccessFlags = 9)]
				public static global::Android.App.PendingIntent GetActivities(global::Android.Content.Context context, int int32, global::Android.Content.Intent[] intent, int int321) /* MethodBuilder.Create */ 
				{
						return default(global::Android.App.PendingIntent);
				}

				/// <java-name>
				/// getBroadcast
				/// </java-name>
				[Dot42.DexImport("getBroadcast", "(Landroid/content/Context;ILandroid/content/Intent;I)Landroid/app/PendingIntent;", AccessFlags = 9)]
				public static global::Android.App.PendingIntent GetBroadcast(global::Android.Content.Context context, int int32, global::Android.Content.Intent intent, int int321) /* MethodBuilder.Create */ 
				{
						return default(global::Android.App.PendingIntent);
				}

				/// <java-name>
				/// getService
				/// </java-name>
				[Dot42.DexImport("getService", "(Landroid/content/Context;ILandroid/content/Intent;I)Landroid/app/PendingIntent;", AccessFlags = 9)]
				public static global::Android.App.PendingIntent GetService(global::Android.Content.Context context, int int32, global::Android.Content.Intent intent, int int321) /* MethodBuilder.Create */ 
				{
						return default(global::Android.App.PendingIntent);
				}

				/// <java-name>
				/// cancel
				/// </java-name>
				[Dot42.DexImport("cancel", "()V", AccessFlags = 1)]
				public void Cancel() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// send
				/// </java-name>
				[Dot42.DexImport("send", "()V", AccessFlags = 1)]
				public void Send() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// send
				/// </java-name>
				[Dot42.DexImport("send", "(I)V", AccessFlags = 1)]
				public void Send(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// send
				/// </java-name>
				[Dot42.DexImport("send", "(Landroid/content/Context;ILandroid/content/Intent;)V", AccessFlags = 1)]
				public void Send(global::Android.Content.Context context, int int32, global::Android.Content.Intent intent) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// send
				/// </java-name>
				[Dot42.DexImport("send", "(ILandroid/app/PendingIntent$OnFinished;Landroid/os/Handler;)V", AccessFlags = 1)]
				public void Send(int int32, global::Android.App.PendingIntent.IOnFinished onFinished, global::Android.OS.Handler handler) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// send
				/// </java-name>
				[Dot42.DexImport("send", "(Landroid/content/Context;ILandroid/content/Intent;Landroid/app/PendingIntent$OnF" +
    "inished;Landroid/os/Handler;)V", AccessFlags = 1)]
				public void Send(global::Android.Content.Context context, int int32, global::Android.Content.Intent intent, global::Android.App.PendingIntent.IOnFinished onFinished, global::Android.OS.Handler handler) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// send
				/// </java-name>
				[Dot42.DexImport("send", "(Landroid/content/Context;ILandroid/content/Intent;Landroid/app/PendingIntent$OnF" +
    "inished;Landroid/os/Handler;Ljava/lang/String;)V", AccessFlags = 1)]
				public void Send(global::Android.Content.Context context, int int32, global::Android.Content.Intent intent, global::Android.App.PendingIntent.IOnFinished onFinished, global::Android.OS.Handler handler, string @string) /* MethodBuilder.Create */ 
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
				/// describeContents
				/// </java-name>
				[Dot42.DexImport("describeContents", "()I", AccessFlags = 1)]
				public int DescribeContents() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public void WriteToParcel(global::Android.OS.Parcel parcel, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writePendingIntentOrNullToParcel
				/// </java-name>
				[Dot42.DexImport("writePendingIntentOrNullToParcel", "(Landroid/app/PendingIntent;Landroid/os/Parcel;)V", AccessFlags = 9)]
				public static void WritePendingIntentOrNullToParcel(global::Android.App.PendingIntent pendingIntent, global::Android.OS.Parcel parcel) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// readPendingIntentOrNullFromParcel
				/// </java-name>
				[Dot42.DexImport("readPendingIntentOrNullFromParcel", "(Landroid/os/Parcel;)Landroid/app/PendingIntent;", AccessFlags = 9)]
				public static global::Android.App.PendingIntent ReadPendingIntentOrNullFromParcel(global::Android.OS.Parcel parcel) /* MethodBuilder.Create */ 
				{
						return default(global::Android.App.PendingIntent);
				}

				/// <java-name>
				/// getIntentSender
				/// </java-name>
				public global::Android.Content.IntentSender IntentSender
				{
						[Dot42.DexImport("getIntentSender", "()Landroid/content/IntentSender;", AccessFlags = 1)]
						get{ return default(global::Android.Content.IntentSender); }
				}

				/// <java-name>
				/// getTargetPackage
				/// </java-name>
				public string TargetPackage
				{
						[Dot42.DexImport("getTargetPackage", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// android/app/PendingIntent$OnFinished
				/// </java-name>
				[Dot42.DexImport("android/app/PendingIntent$OnFinished", AccessFlags = 1545)]
				public partial interface IOnFinished
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onSendFinished
						/// </java-name>
						[Dot42.DexImport("onSendFinished", "(Landroid/app/PendingIntent;Landroid/content/Intent;ILjava/lang/String;Landroid/o" +
    "s/Bundle;)V", AccessFlags = 1025)]
						void OnSendFinished(global::Android.App.PendingIntent pendingIntent, global::Android.Content.Intent intent, int int32, string @string, global::Android.OS.Bundle bundle) /* MethodBuilder.Create */ ;

				}

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

		/// <java-name>
		/// android/app/ProgressDialog
		/// </java-name>
		[Dot42.DexImport("android/app/ProgressDialog", AccessFlags = 33)]
		public partial class ProgressDialog : global::Android.App.AlertDialog
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// STYLE_SPINNER
				/// </java-name>
				[Dot42.DexImport("STYLE_SPINNER", "I", AccessFlags = 25)]
				public const int STYLE_SPINNER = 0;
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
				public ProgressDialog(global::Android.Content.Context context, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// show
				/// </java-name>
				[Dot42.DexImport("show", "(Landroid/content/Context;Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Landro" +
    "id/app/ProgressDialog;", AccessFlags = 9)]
				public static global::Android.App.ProgressDialog Show(global::Android.Content.Context context, global::Java.Lang.ICharSequence charSequence, global::Java.Lang.ICharSequence charSequence1) /* MethodBuilder.Create */ 
				{
						return default(global::Android.App.ProgressDialog);
				}

				/// <java-name>
				/// show
				/// </java-name>
				[Dot42.DexImport("show", "(Landroid/content/Context;Ljava/lang/CharSequence;Ljava/lang/CharSequence;Z)Landr" +
    "oid/app/ProgressDialog;", AccessFlags = 9)]
				public static global::Android.App.ProgressDialog Show(global::Android.Content.Context context, global::Java.Lang.ICharSequence charSequence, global::Java.Lang.ICharSequence charSequence1, bool boolean) /* MethodBuilder.Create */ 
				{
						return default(global::Android.App.ProgressDialog);
				}

				/// <java-name>
				/// show
				/// </java-name>
				[Dot42.DexImport("show", "(Landroid/content/Context;Ljava/lang/CharSequence;Ljava/lang/CharSequence;ZZ)Land" +
    "roid/app/ProgressDialog;", AccessFlags = 9)]
				public static global::Android.App.ProgressDialog Show(global::Android.Content.Context context, global::Java.Lang.ICharSequence charSequence, global::Java.Lang.ICharSequence charSequence1, bool boolean, bool boolean1) /* MethodBuilder.Create */ 
				{
						return default(global::Android.App.ProgressDialog);
				}

				/// <java-name>
				/// show
				/// </java-name>
				[Dot42.DexImport("show", "(Landroid/content/Context;Ljava/lang/CharSequence;Ljava/lang/CharSequence;ZZLandr" +
    "oid/content/DialogInterface$OnCancelListener;)Landroid/app/ProgressDialog;", AccessFlags = 9)]
				public static global::Android.App.ProgressDialog Show(global::Android.Content.Context context, global::Java.Lang.ICharSequence charSequence, global::Java.Lang.ICharSequence charSequence1, bool boolean, bool boolean1, global::Android.Content.IDialogInterface_IOnCancelListener dialogInterface_IOnCancelListener) /* MethodBuilder.Create */ 
				{
						return default(global::Android.App.ProgressDialog);
				}

				/// <java-name>
				/// onCreate
				/// </java-name>
				[Dot42.DexImport("onCreate", "(Landroid/os/Bundle;)V", AccessFlags = 4)]
				protected internal override void OnCreate(global::Android.OS.Bundle bundle) /* MethodBuilder.Create */ 
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
				public virtual void IncrementProgressBy(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// incrementSecondaryProgressBy
				/// </java-name>
				[Dot42.DexImport("incrementSecondaryProgressBy", "(I)V", AccessFlags = 1)]
				public virtual void IncrementSecondaryProgressBy(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setProgressDrawable
				/// </java-name>
				[Dot42.DexImport("setProgressDrawable", "(Landroid/graphics/drawable/Drawable;)V", AccessFlags = 1)]
				public virtual void SetProgressDrawable(global::Android.Graphics.Drawables.Drawable drawable) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setIndeterminateDrawable
				/// </java-name>
				[Dot42.DexImport("setIndeterminateDrawable", "(Landroid/graphics/drawable/Drawable;)V", AccessFlags = 1)]
				public virtual void SetIndeterminateDrawable(global::Android.Graphics.Drawables.Drawable drawable) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setMessage
				/// </java-name>
				[Dot42.DexImport("setMessage", "(Ljava/lang/CharSequence;)V", AccessFlags = 1)]
				public override void SetMessage(global::Java.Lang.ICharSequence charSequence) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setProgressStyle
				/// </java-name>
				[Dot42.DexImport("setProgressStyle", "(I)V", AccessFlags = 1)]
				public virtual void SetProgressStyle(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setProgressNumberFormat
				/// </java-name>
				[Dot42.DexImport("setProgressNumberFormat", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetProgressNumberFormat(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setProgressPercentFormat
				/// </java-name>
				[Dot42.DexImport("setProgressPercentFormat", "(Ljava/text/NumberFormat;)V", AccessFlags = 1)]
				public virtual void SetProgressPercentFormat(global::Java.Text.NumberFormat numberFormat) /* MethodBuilder.Create */ 
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

		/// <java-name>
		/// android/app/SearchableInfo
		/// </java-name>
		[Dot42.DexImport("android/app/SearchableInfo", AccessFlags = 49)]
		public sealed partial class SearchableInfo : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.App.SearchableInfo> CREATOR;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal SearchableInfo() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// shouldRewriteQueryFromData
				/// </java-name>
				[Dot42.DexImport("shouldRewriteQueryFromData", "()Z", AccessFlags = 1)]
				public bool ShouldRewriteQueryFromData() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// shouldRewriteQueryFromText
				/// </java-name>
				[Dot42.DexImport("shouldRewriteQueryFromText", "()Z", AccessFlags = 1)]
				public bool ShouldRewriteQueryFromText() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// shouldIncludeInGlobalSearch
				/// </java-name>
				[Dot42.DexImport("shouldIncludeInGlobalSearch", "()Z", AccessFlags = 1)]
				public bool ShouldIncludeInGlobalSearch() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// queryAfterZeroResults
				/// </java-name>
				[Dot42.DexImport("queryAfterZeroResults", "()Z", AccessFlags = 1)]
				public bool QueryAfterZeroResults() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// autoUrlDetect
				/// </java-name>
				[Dot42.DexImport("autoUrlDetect", "()Z", AccessFlags = 1)]
				public bool AutoUrlDetect() /* MethodBuilder.Create */ 
				{
						return default(bool);
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
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public void WriteToParcel(global::Android.OS.Parcel parcel, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getSuggestAuthority
				/// </java-name>
				public string SuggestAuthority
				{
						[Dot42.DexImport("getSuggestAuthority", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getSuggestPackage
				/// </java-name>
				public string SuggestPackage
				{
						[Dot42.DexImport("getSuggestPackage", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getSearchActivity
				/// </java-name>
				public global::Android.Content.ComponentName SearchActivity
				{
						[Dot42.DexImport("getSearchActivity", "()Landroid/content/ComponentName;", AccessFlags = 1)]
						get{ return default(global::Android.Content.ComponentName); }
				}

				/// <java-name>
				/// getSettingsDescriptionId
				/// </java-name>
				public int SettingsDescriptionId
				{
						[Dot42.DexImport("getSettingsDescriptionId", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getSuggestPath
				/// </java-name>
				public string SuggestPath
				{
						[Dot42.DexImport("getSuggestPath", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getSuggestSelection
				/// </java-name>
				public string SuggestSelection
				{
						[Dot42.DexImport("getSuggestSelection", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getSuggestIntentAction
				/// </java-name>
				public string SuggestIntentAction
				{
						[Dot42.DexImport("getSuggestIntentAction", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getSuggestIntentData
				/// </java-name>
				public string SuggestIntentData
				{
						[Dot42.DexImport("getSuggestIntentData", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getSuggestThreshold
				/// </java-name>
				public int SuggestThreshold
				{
						[Dot42.DexImport("getSuggestThreshold", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getHintId
				/// </java-name>
				public int HintId
				{
						[Dot42.DexImport("getHintId", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getVoiceSearchEnabled
				/// </java-name>
				public bool IsVoiceSearchEnabled
				{
						[Dot42.DexImport("getVoiceSearchEnabled", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// getVoiceSearchLaunchWebSearch
				/// </java-name>
				public bool IsVoiceSearchLaunchWebSearch
				{
						[Dot42.DexImport("getVoiceSearchLaunchWebSearch", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// getVoiceSearchLaunchRecognizer
				/// </java-name>
				public bool IsVoiceSearchLaunchRecognizer
				{
						[Dot42.DexImport("getVoiceSearchLaunchRecognizer", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// getVoiceLanguageModeId
				/// </java-name>
				public int VoiceLanguageModeId
				{
						[Dot42.DexImport("getVoiceLanguageModeId", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getVoicePromptTextId
				/// </java-name>
				public int VoicePromptTextId
				{
						[Dot42.DexImport("getVoicePromptTextId", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getVoiceLanguageId
				/// </java-name>
				public int VoiceLanguageId
				{
						[Dot42.DexImport("getVoiceLanguageId", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getVoiceMaxResults
				/// </java-name>
				public int VoiceMaxResults
				{
						[Dot42.DexImport("getVoiceMaxResults", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getInputType
				/// </java-name>
				public int InputType
				{
						[Dot42.DexImport("getInputType", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getImeOptions
				/// </java-name>
				public int ImeOptions
				{
						[Dot42.DexImport("getImeOptions", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

		}

		/// <java-name>
		/// android/app/SearchManager
		/// </java-name>
		[Dot42.DexImport("android/app/SearchManager", AccessFlags = 33)]
		public partial class SearchManager : global::Android.Content.IDialogInterface_IOnDismissListener, global::Android.Content.IDialogInterface_IOnCancelListener
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// MENU_KEY
				/// </java-name>
				[Dot42.DexImport("MENU_KEY", "C", AccessFlags = 25)]
				public const char MENU_KEY = 's';
				/// <java-name>
				/// MENU_KEYCODE
				/// </java-name>
				[Dot42.DexImport("MENU_KEYCODE", "I", AccessFlags = 25)]
				public const int MENU_KEYCODE = 47;
				/// <java-name>
				/// QUERY
				/// </java-name>
				[Dot42.DexImport("QUERY", "Ljava/lang/String;", AccessFlags = 25)]
				public const string QUERY = "query";
				/// <java-name>
				/// USER_QUERY
				/// </java-name>
				[Dot42.DexImport("USER_QUERY", "Ljava/lang/String;", AccessFlags = 25)]
				public const string USER_QUERY = "user_query";
				/// <java-name>
				/// APP_DATA
				/// </java-name>
				[Dot42.DexImport("APP_DATA", "Ljava/lang/String;", AccessFlags = 25)]
				public const string APP_DATA = "app_data";
				/// <java-name>
				/// ACTION_KEY
				/// </java-name>
				[Dot42.DexImport("ACTION_KEY", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_KEY = "action_key";
				/// <java-name>
				/// EXTRA_DATA_KEY
				/// </java-name>
				[Dot42.DexImport("EXTRA_DATA_KEY", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_DATA_KEY = "intent_extra_data_key";
				/// <java-name>
				/// EXTRA_SELECT_QUERY
				/// </java-name>
				[Dot42.DexImport("EXTRA_SELECT_QUERY", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_SELECT_QUERY = "select_query";
				/// <java-name>
				/// EXTRA_NEW_SEARCH
				/// </java-name>
				[Dot42.DexImport("EXTRA_NEW_SEARCH", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_NEW_SEARCH = "new_search";
				/// <java-name>
				/// EXTRA_WEB_SEARCH_PENDINGINTENT
				/// </java-name>
				[Dot42.DexImport("EXTRA_WEB_SEARCH_PENDINGINTENT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_WEB_SEARCH_PENDINGINTENT = "web_search_pendingintent";
				/// <java-name>
				/// CURSOR_EXTRA_KEY_IN_PROGRESS
				/// </java-name>
				[Dot42.DexImport("CURSOR_EXTRA_KEY_IN_PROGRESS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string CURSOR_EXTRA_KEY_IN_PROGRESS = "in_progress";
				/// <java-name>
				/// ACTION_MSG
				/// </java-name>
				[Dot42.DexImport("ACTION_MSG", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_MSG = "action_msg";
				/// <java-name>
				/// FLAG_QUERY_REFINEMENT
				/// </java-name>
				[Dot42.DexImport("FLAG_QUERY_REFINEMENT", "I", AccessFlags = 25)]
				public const int FLAG_QUERY_REFINEMENT = 1;
				/// <java-name>
				/// SUGGEST_URI_PATH_QUERY
				/// </java-name>
				[Dot42.DexImport("SUGGEST_URI_PATH_QUERY", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SUGGEST_URI_PATH_QUERY = "search_suggest_query";
				/// <java-name>
				/// SUGGEST_MIME_TYPE
				/// </java-name>
				[Dot42.DexImport("SUGGEST_MIME_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SUGGEST_MIME_TYPE = "vnd.android.cursor.dir/vnd.android.search.suggest";
				/// <java-name>
				/// SUGGEST_URI_PATH_SHORTCUT
				/// </java-name>
				[Dot42.DexImport("SUGGEST_URI_PATH_SHORTCUT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SUGGEST_URI_PATH_SHORTCUT = "search_suggest_shortcut";
				/// <java-name>
				/// SHORTCUT_MIME_TYPE
				/// </java-name>
				[Dot42.DexImport("SHORTCUT_MIME_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SHORTCUT_MIME_TYPE = "vnd.android.cursor.item/vnd.android.search.suggest";
				/// <java-name>
				/// SUGGEST_COLUMN_FORMAT
				/// </java-name>
				[Dot42.DexImport("SUGGEST_COLUMN_FORMAT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SUGGEST_COLUMN_FORMAT = "suggest_format";
				/// <java-name>
				/// SUGGEST_COLUMN_TEXT_1
				/// </java-name>
				[Dot42.DexImport("SUGGEST_COLUMN_TEXT_1", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SUGGEST_COLUMN_TEXT_1 = "suggest_text_1";
				/// <java-name>
				/// SUGGEST_COLUMN_TEXT_2
				/// </java-name>
				[Dot42.DexImport("SUGGEST_COLUMN_TEXT_2", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SUGGEST_COLUMN_TEXT_2 = "suggest_text_2";
				/// <java-name>
				/// SUGGEST_COLUMN_TEXT_2_URL
				/// </java-name>
				[Dot42.DexImport("SUGGEST_COLUMN_TEXT_2_URL", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SUGGEST_COLUMN_TEXT_2_URL = "suggest_text_2_url";
				/// <java-name>
				/// SUGGEST_COLUMN_ICON_1
				/// </java-name>
				[Dot42.DexImport("SUGGEST_COLUMN_ICON_1", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SUGGEST_COLUMN_ICON_1 = "suggest_icon_1";
				/// <java-name>
				/// SUGGEST_COLUMN_ICON_2
				/// </java-name>
				[Dot42.DexImport("SUGGEST_COLUMN_ICON_2", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SUGGEST_COLUMN_ICON_2 = "suggest_icon_2";
				/// <java-name>
				/// SUGGEST_COLUMN_INTENT_ACTION
				/// </java-name>
				[Dot42.DexImport("SUGGEST_COLUMN_INTENT_ACTION", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SUGGEST_COLUMN_INTENT_ACTION = "suggest_intent_action";
				/// <java-name>
				/// SUGGEST_COLUMN_INTENT_DATA
				/// </java-name>
				[Dot42.DexImport("SUGGEST_COLUMN_INTENT_DATA", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SUGGEST_COLUMN_INTENT_DATA = "suggest_intent_data";
				/// <java-name>
				/// SUGGEST_COLUMN_INTENT_EXTRA_DATA
				/// </java-name>
				[Dot42.DexImport("SUGGEST_COLUMN_INTENT_EXTRA_DATA", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SUGGEST_COLUMN_INTENT_EXTRA_DATA = "suggest_intent_extra_data";
				/// <java-name>
				/// SUGGEST_COLUMN_INTENT_DATA_ID
				/// </java-name>
				[Dot42.DexImport("SUGGEST_COLUMN_INTENT_DATA_ID", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SUGGEST_COLUMN_INTENT_DATA_ID = "suggest_intent_data_id";
				/// <java-name>
				/// SUGGEST_COLUMN_QUERY
				/// </java-name>
				[Dot42.DexImport("SUGGEST_COLUMN_QUERY", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SUGGEST_COLUMN_QUERY = "suggest_intent_query";
				/// <java-name>
				/// SUGGEST_COLUMN_SHORTCUT_ID
				/// </java-name>
				[Dot42.DexImport("SUGGEST_COLUMN_SHORTCUT_ID", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SUGGEST_COLUMN_SHORTCUT_ID = "suggest_shortcut_id";
				/// <java-name>
				/// SUGGEST_COLUMN_SPINNER_WHILE_REFRESHING
				/// </java-name>
				[Dot42.DexImport("SUGGEST_COLUMN_SPINNER_WHILE_REFRESHING", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SUGGEST_COLUMN_SPINNER_WHILE_REFRESHING = "suggest_spinner_while_refreshing";
				/// <java-name>
				/// SUGGEST_COLUMN_FLAGS
				/// </java-name>
				[Dot42.DexImport("SUGGEST_COLUMN_FLAGS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SUGGEST_COLUMN_FLAGS = "suggest_flags";
				/// <java-name>
				/// SUGGEST_COLUMN_LAST_ACCESS_HINT
				/// </java-name>
				[Dot42.DexImport("SUGGEST_COLUMN_LAST_ACCESS_HINT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SUGGEST_COLUMN_LAST_ACCESS_HINT = "suggest_last_access_hint";
				/// <java-name>
				/// SUGGEST_NEVER_MAKE_SHORTCUT
				/// </java-name>
				[Dot42.DexImport("SUGGEST_NEVER_MAKE_SHORTCUT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SUGGEST_NEVER_MAKE_SHORTCUT = "_-1";
				/// <java-name>
				/// SUGGEST_PARAMETER_LIMIT
				/// </java-name>
				[Dot42.DexImport("SUGGEST_PARAMETER_LIMIT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SUGGEST_PARAMETER_LIMIT = "limit";
				/// <java-name>
				/// INTENT_ACTION_GLOBAL_SEARCH
				/// </java-name>
				[Dot42.DexImport("INTENT_ACTION_GLOBAL_SEARCH", "Ljava/lang/String;", AccessFlags = 25)]
				public const string INTENT_ACTION_GLOBAL_SEARCH = "android.search.action.GLOBAL_SEARCH";
				/// <java-name>
				/// INTENT_ACTION_SEARCH_SETTINGS
				/// </java-name>
				[Dot42.DexImport("INTENT_ACTION_SEARCH_SETTINGS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string INTENT_ACTION_SEARCH_SETTINGS = "android.search.action.SEARCH_SETTINGS";
				/// <java-name>
				/// INTENT_ACTION_WEB_SEARCH_SETTINGS
				/// </java-name>
				[Dot42.DexImport("INTENT_ACTION_WEB_SEARCH_SETTINGS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string INTENT_ACTION_WEB_SEARCH_SETTINGS = "android.search.action.WEB_SEARCH_SETTINGS";
				/// <java-name>
				/// INTENT_ACTION_SEARCHABLES_CHANGED
				/// </java-name>
				[Dot42.DexImport("INTENT_ACTION_SEARCHABLES_CHANGED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string INTENT_ACTION_SEARCHABLES_CHANGED = "android.search.action.SEARCHABLES_CHANGED";
				/// <java-name>
				/// INTENT_ACTION_SEARCH_SETTINGS_CHANGED
				/// </java-name>
				[Dot42.DexImport("INTENT_ACTION_SEARCH_SETTINGS_CHANGED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string INTENT_ACTION_SEARCH_SETTINGS_CHANGED = "android.search.action.SETTINGS_CHANGED";
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal SearchManager() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// startSearch
				/// </java-name>
				[Dot42.DexImport("startSearch", "(Ljava/lang/String;ZLandroid/content/ComponentName;Landroid/os/Bundle;Z)V", AccessFlags = 1)]
				public virtual void StartSearch(string @string, bool boolean, global::Android.Content.ComponentName componentName, global::Android.OS.Bundle bundle, bool boolean1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// triggerSearch
				/// </java-name>
				[Dot42.DexImport("triggerSearch", "(Ljava/lang/String;Landroid/content/ComponentName;Landroid/os/Bundle;)V", AccessFlags = 1)]
				public virtual void TriggerSearch(string @string, global::Android.Content.ComponentName componentName, global::Android.OS.Bundle bundle) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// stopSearch
				/// </java-name>
				[Dot42.DexImport("stopSearch", "()V", AccessFlags = 1)]
				public virtual void StopSearch() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setOnDismissListener
				/// </java-name>
				[Dot42.DexImport("setOnDismissListener", "(Landroid/app/SearchManager$OnDismissListener;)V", AccessFlags = 1)]
				public virtual void SetOnDismissListener(global::Android.App.SearchManager.IOnDismissListener onDismissListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setOnCancelListener
				/// </java-name>
				[Dot42.DexImport("setOnCancelListener", "(Landroid/app/SearchManager$OnCancelListener;)V", AccessFlags = 1)]
				public virtual void SetOnCancelListener(global::Android.App.SearchManager.IOnCancelListener onCancelListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onCancel
				/// </java-name>
				[Dot42.DexImport("onCancel", "(Landroid/content/DialogInterface;)V", AccessFlags = 1)]
				public virtual void OnCancel(global::Android.Content.IDialogInterface dialogInterface) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onDismiss
				/// </java-name>
				[Dot42.DexImport("onDismiss", "(Landroid/content/DialogInterface;)V", AccessFlags = 1)]
				public virtual void OnDismiss(global::Android.Content.IDialogInterface dialogInterface) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getSearchableInfo
				/// </java-name>
				[Dot42.DexImport("getSearchableInfo", "(Landroid/content/ComponentName;)Landroid/app/SearchableInfo;", AccessFlags = 1)]
				public virtual global::Android.App.SearchableInfo GetSearchableInfo(global::Android.Content.ComponentName componentName) /* MethodBuilder.Create */ 
				{
						return default(global::Android.App.SearchableInfo);
				}

				/// <java-name>
				/// getSearchablesInGlobalSearch
				/// </java-name>
				public virtual global::Java.Util.IList<global::Android.App.SearchableInfo> SearchablesInGlobalSearch
				{
						[Dot42.DexImport("getSearchablesInGlobalSearch", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Landroid/app/SearchableInfo;>;")]
						get{ return default(global::Java.Util.IList<global::Android.App.SearchableInfo>); }
				}

				/// <java-name>
				/// android/app/SearchManager$OnCancelListener
				/// </java-name>
				[Dot42.DexImport("android/app/SearchManager$OnCancelListener", AccessFlags = 1545)]
				public partial interface IOnCancelListener
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onCancel
						/// </java-name>
						[Dot42.DexImport("onCancel", "()V", AccessFlags = 1025)]
						void OnCancel() /* MethodBuilder.Create */ ;

				}

				/// <java-name>
				/// android/app/SearchManager$OnDismissListener
				/// </java-name>
				[Dot42.DexImport("android/app/SearchManager$OnDismissListener", AccessFlags = 1545)]
				public partial interface IOnDismissListener
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onDismiss
						/// </java-name>
						[Dot42.DexImport("onDismiss", "()V", AccessFlags = 1025)]
						void OnDismiss() /* MethodBuilder.Create */ ;

				}

		}

		/// <java-name>
		/// android/app/Service
		/// </java-name>
		[Dot42.DexImport("android/app/Service", AccessFlags = 1057)]
		public abstract partial class Service : global::Android.Content.ContextWrapper, global::Android.Content.IComponentCallbacks2
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// START_CONTINUATION_MASK
				/// </java-name>
				[Dot42.DexImport("START_CONTINUATION_MASK", "I", AccessFlags = 25)]
				public const int START_CONTINUATION_MASK = 15;
				/// <java-name>
				/// START_STICKY_COMPATIBILITY
				/// </java-name>
				[Dot42.DexImport("START_STICKY_COMPATIBILITY", "I", AccessFlags = 25)]
				public const int START_STICKY_COMPATIBILITY = 0;
				/// <java-name>
				/// START_STICKY
				/// </java-name>
				[Dot42.DexImport("START_STICKY", "I", AccessFlags = 25)]
				public const int START_STICKY = 1;
				/// <java-name>
				/// START_NOT_STICKY
				/// </java-name>
				[Dot42.DexImport("START_NOT_STICKY", "I", AccessFlags = 25)]
				public const int START_NOT_STICKY = 2;
				/// <java-name>
				/// START_REDELIVER_INTENT
				/// </java-name>
				[Dot42.DexImport("START_REDELIVER_INTENT", "I", AccessFlags = 25)]
				public const int START_REDELIVER_INTENT = 3;
				/// <java-name>
				/// START_FLAG_REDELIVERY
				/// </java-name>
				[Dot42.DexImport("START_FLAG_REDELIVERY", "I", AccessFlags = 25)]
				public const int START_FLAG_REDELIVERY = 1;
				/// <java-name>
				/// START_FLAG_RETRY
				/// </java-name>
				[Dot42.DexImport("START_FLAG_RETRY", "I", AccessFlags = 25)]
				public const int START_FLAG_RETRY = 2;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Service() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onCreate
				/// </java-name>
				[Dot42.DexImport("onCreate", "()V", AccessFlags = 1)]
				public virtual void OnCreate() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onStart
				/// </java-name>
				[Dot42.DexImport("onStart", "(Landroid/content/Intent;I)V", AccessFlags = 1)]
				public virtual void OnStart(global::Android.Content.Intent intent, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onStartCommand
				/// </java-name>
				[Dot42.DexImport("onStartCommand", "(Landroid/content/Intent;II)I", AccessFlags = 1)]
				public virtual int OnStartCommand(global::Android.Content.Intent intent, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// onDestroy
				/// </java-name>
				[Dot42.DexImport("onDestroy", "()V", AccessFlags = 1)]
				public virtual void OnDestroy() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onConfigurationChanged
				/// </java-name>
				[Dot42.DexImport("onConfigurationChanged", "(Landroid/content/res/Configuration;)V", AccessFlags = 1)]
				public virtual void OnConfigurationChanged(global::Android.Content.Res.Configuration configuration) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onLowMemory
				/// </java-name>
				[Dot42.DexImport("onLowMemory", "()V", AccessFlags = 1)]
				public virtual void OnLowMemory() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onTrimMemory
				/// </java-name>
				[Dot42.DexImport("onTrimMemory", "(I)V", AccessFlags = 1)]
				public virtual void OnTrimMemory(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onBind
				/// </java-name>
				[Dot42.DexImport("onBind", "(Landroid/content/Intent;)Landroid/os/IBinder;", AccessFlags = 1025)]
				public abstract global::Android.OS.IBinder OnBind(global::Android.Content.Intent intent) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// onUnbind
				/// </java-name>
				[Dot42.DexImport("onUnbind", "(Landroid/content/Intent;)Z", AccessFlags = 1)]
				public virtual bool OnUnbind(global::Android.Content.Intent intent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onRebind
				/// </java-name>
				[Dot42.DexImport("onRebind", "(Landroid/content/Intent;)V", AccessFlags = 1)]
				public virtual void OnRebind(global::Android.Content.Intent intent) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onTaskRemoved
				/// </java-name>
				[Dot42.DexImport("onTaskRemoved", "(Landroid/content/Intent;)V", AccessFlags = 1)]
				public virtual void OnTaskRemoved(global::Android.Content.Intent intent) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// stopSelf
				/// </java-name>
				[Dot42.DexImport("stopSelf", "()V", AccessFlags = 17)]
				public void StopSelf() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// stopSelf
				/// </java-name>
				[Dot42.DexImport("stopSelf", "(I)V", AccessFlags = 17)]
				public void StopSelf(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// stopSelfResult
				/// </java-name>
				[Dot42.DexImport("stopSelfResult", "(I)Z", AccessFlags = 17)]
				public bool StopSelfResult(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// startForeground
				/// </java-name>
				[Dot42.DexImport("startForeground", "(ILandroid/app/Notification;)V", AccessFlags = 17)]
				public void StartForeground(int int32, global::Android.App.Notification notification) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// stopForeground
				/// </java-name>
				[Dot42.DexImport("stopForeground", "(Z)V", AccessFlags = 17)]
				public void StopForeground(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// dump
				/// </java-name>
				[Dot42.DexImport("dump", "(Ljava/io/FileDescriptor;Ljava/io/PrintWriter;[Ljava/lang/String;)V", AccessFlags = 4)]
				protected internal virtual void Dump(global::Java.IO.FileDescriptor fileDescriptor, global::Java.IO.PrintWriter printWriter, string[] @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getApplication
				/// </java-name>
				public global::Android.App.Application Application
				{
						[Dot42.DexImport("getApplication", "()Landroid/app/Application;", AccessFlags = 17)]
						get{ return default(global::Android.App.Application); }
				}

		}

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

				/// <java-name>
				/// setDefaultTab
				/// </java-name>
				[Dot42.DexImport("setDefaultTab", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetDefaultTab(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setDefaultTab
				/// </java-name>
				[Dot42.DexImport("setDefaultTab", "(I)V", AccessFlags = 1)]
				public virtual void SetDefaultTab(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onRestoreInstanceState
				/// </java-name>
				[Dot42.DexImport("onRestoreInstanceState", "(Landroid/os/Bundle;)V", AccessFlags = 4)]
				protected internal override void OnRestoreInstanceState(global::Android.OS.Bundle bundle) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onPostCreate
				/// </java-name>
				[Dot42.DexImport("onPostCreate", "(Landroid/os/Bundle;)V", AccessFlags = 4)]
				protected internal override void OnPostCreate(global::Android.OS.Bundle bundle) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onSaveInstanceState
				/// </java-name>
				[Dot42.DexImport("onSaveInstanceState", "(Landroid/os/Bundle;)V", AccessFlags = 4)]
				protected internal override void OnSaveInstanceState(global::Android.OS.Bundle bundle) /* MethodBuilder.Create */ 
				{
				}

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
				protected internal override void OnChildTitleChanged(global::Android.App.Activity activity, global::Java.Lang.ICharSequence charSequence) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getTabHost
				/// </java-name>
				public virtual global::Android.Widget.TabHost TabHost
				{
						[Dot42.DexImport("getTabHost", "()Landroid/widget/TabHost;", AccessFlags = 1)]
						get{ return default(global::Android.Widget.TabHost); }
				}

				/// <java-name>
				/// getTabWidget
				/// </java-name>
				public virtual global::Android.Widget.TabWidget TabWidget
				{
						[Dot42.DexImport("getTabWidget", "()Landroid/widget/TabWidget;", AccessFlags = 1)]
						get{ return default(global::Android.Widget.TabWidget); }
				}

		}

		/// <java-name>
		/// android/app/TimePickerDialog
		/// </java-name>
		[Dot42.DexImport("android/app/TimePickerDialog", AccessFlags = 33)]
		public partial class TimePickerDialog : global::Android.App.AlertDialog, global::Android.Content.IDialogInterface_IOnClickListener, global::Android.Widget.TimePicker.IOnTimeChangedListener
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/app/TimePickerDialog$OnTimeSetListener;IIZ)V", AccessFlags = 1)]
				public TimePickerDialog(global::Android.Content.Context context, global::Android.App.TimePickerDialog.IOnTimeSetListener onTimeSetListener, int int32, int int321, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;ILandroid/app/TimePickerDialog$OnTimeSetListener;IIZ)V", AccessFlags = 1)]
				public TimePickerDialog(global::Android.Content.Context context, int int32, global::Android.App.TimePickerDialog.IOnTimeSetListener onTimeSetListener, int int321, int int322, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onClick
				/// </java-name>
				[Dot42.DexImport("onClick", "(Landroid/content/DialogInterface;I)V", AccessFlags = 1)]
				public virtual void OnClick(global::Android.Content.IDialogInterface dialogInterface, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// updateTime
				/// </java-name>
				[Dot42.DexImport("updateTime", "(II)V", AccessFlags = 1)]
				public virtual void UpdateTime(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onTimeChanged
				/// </java-name>
				[Dot42.DexImport("onTimeChanged", "(Landroid/widget/TimePicker;II)V", AccessFlags = 1)]
				public virtual void OnTimeChanged(global::Android.Widget.TimePicker timePicker, int int32, int int321) /* MethodBuilder.Create */ 
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
				public override void OnRestoreInstanceState(global::Android.OS.Bundle bundle) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal TimePickerDialog() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// android/app/TimePickerDialog$OnTimeSetListener
				/// </java-name>
				[Dot42.DexImport("android/app/TimePickerDialog$OnTimeSetListener", AccessFlags = 1545)]
				public partial interface IOnTimeSetListener
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onTimeSet
						/// </java-name>
						[Dot42.DexImport("onTimeSet", "(Landroid/widget/TimePicker;II)V", AccessFlags = 1025)]
						void OnTimeSet(global::Android.Widget.TimePicker timePicker, int int32, int int321) /* MethodBuilder.Create */ ;

				}

		}

		/// <java-name>
		/// android/app/UiModeManager
		/// </java-name>
		[Dot42.DexImport("android/app/UiModeManager", AccessFlags = 33)]
		public partial class UiModeManager
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// ACTION_ENTER_CAR_MODE
				/// </java-name>
				[Dot42.DexImport("ACTION_ENTER_CAR_MODE", "Ljava/lang/String;", AccessFlags = 9)]
				public static string ACTION_ENTER_CAR_MODE;
				/// <java-name>
				/// ACTION_EXIT_CAR_MODE
				/// </java-name>
				[Dot42.DexImport("ACTION_EXIT_CAR_MODE", "Ljava/lang/String;", AccessFlags = 9)]
				public static string ACTION_EXIT_CAR_MODE;
				/// <java-name>
				/// ACTION_ENTER_DESK_MODE
				/// </java-name>
				[Dot42.DexImport("ACTION_ENTER_DESK_MODE", "Ljava/lang/String;", AccessFlags = 9)]
				public static string ACTION_ENTER_DESK_MODE;
				/// <java-name>
				/// ACTION_EXIT_DESK_MODE
				/// </java-name>
				[Dot42.DexImport("ACTION_EXIT_DESK_MODE", "Ljava/lang/String;", AccessFlags = 9)]
				public static string ACTION_EXIT_DESK_MODE;
				/// <java-name>
				/// MODE_NIGHT_AUTO
				/// </java-name>
				[Dot42.DexImport("MODE_NIGHT_AUTO", "I", AccessFlags = 25)]
				public const int MODE_NIGHT_AUTO = 0;
				/// <java-name>
				/// MODE_NIGHT_NO
				/// </java-name>
				[Dot42.DexImport("MODE_NIGHT_NO", "I", AccessFlags = 25)]
				public const int MODE_NIGHT_NO = 1;
				/// <java-name>
				/// MODE_NIGHT_YES
				/// </java-name>
				[Dot42.DexImport("MODE_NIGHT_YES", "I", AccessFlags = 25)]
				public const int MODE_NIGHT_YES = 2;
				/// <java-name>
				/// ENABLE_CAR_MODE_GO_CAR_HOME
				/// </java-name>
				[Dot42.DexImport("ENABLE_CAR_MODE_GO_CAR_HOME", "I", AccessFlags = 25)]
				public const int ENABLE_CAR_MODE_GO_CAR_HOME = 1;
				/// <java-name>
				/// DISABLE_CAR_MODE_GO_HOME
				/// </java-name>
				[Dot42.DexImport("DISABLE_CAR_MODE_GO_HOME", "I", AccessFlags = 25)]
				public const int DISABLE_CAR_MODE_GO_HOME = 1;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal UiModeManager() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// enableCarMode
				/// </java-name>
				[Dot42.DexImport("enableCarMode", "(I)V", AccessFlags = 1)]
				public virtual void EnableCarMode(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// disableCarMode
				/// </java-name>
				[Dot42.DexImport("disableCarMode", "(I)V", AccessFlags = 1)]
				public virtual void DisableCarMode(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getCurrentModeType
				/// </java-name>
				public virtual int CurrentModeType
				{
						[Dot42.DexImport("getCurrentModeType", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

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

		/// <java-name>
		/// android/app/WallpaperInfo
		/// </java-name>
		[Dot42.DexImport("android/app/WallpaperInfo", AccessFlags = 49)]
		public sealed partial class WallpaperInfo : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.App.WallpaperInfo> CREATOR;
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/content/pm/ResolveInfo;)V", AccessFlags = 1)]
				public WallpaperInfo(global::Android.Content.Context context, global::Android.Content.PM.ResolveInfo resolveInfo) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// loadLabel
				/// </java-name>
				[Dot42.DexImport("loadLabel", "(Landroid/content/pm/PackageManager;)Ljava/lang/CharSequence;", AccessFlags = 1)]
				public global::Java.Lang.ICharSequence LoadLabel(global::Android.Content.PM.PackageManager packageManager) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <java-name>
				/// loadIcon
				/// </java-name>
				[Dot42.DexImport("loadIcon", "(Landroid/content/pm/PackageManager;)Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
				public global::Android.Graphics.Drawables.Drawable LoadIcon(global::Android.Content.PM.PackageManager packageManager) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawables.Drawable);
				}

				/// <java-name>
				/// loadThumbnail
				/// </java-name>
				[Dot42.DexImport("loadThumbnail", "(Landroid/content/pm/PackageManager;)Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
				public global::Android.Graphics.Drawables.Drawable LoadThumbnail(global::Android.Content.PM.PackageManager packageManager) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawables.Drawable);
				}

				/// <java-name>
				/// loadAuthor
				/// </java-name>
				[Dot42.DexImport("loadAuthor", "(Landroid/content/pm/PackageManager;)Ljava/lang/CharSequence;", AccessFlags = 1)]
				public global::Java.Lang.ICharSequence LoadAuthor(global::Android.Content.PM.PackageManager packageManager) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <java-name>
				/// loadDescription
				/// </java-name>
				[Dot42.DexImport("loadDescription", "(Landroid/content/pm/PackageManager;)Ljava/lang/CharSequence;", AccessFlags = 1)]
				public global::Java.Lang.ICharSequence LoadDescription(global::Android.Content.PM.PackageManager packageManager) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <java-name>
				/// dump
				/// </java-name>
				[Dot42.DexImport("dump", "(Landroid/util/Printer;Ljava/lang/String;)V", AccessFlags = 1)]
				public void Dump(global::Android.Util.IPrinter printer, string @string) /* MethodBuilder.Create */ 
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

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal WallpaperInfo() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getPackageName
				/// </java-name>
				public string PackageName
				{
						[Dot42.DexImport("getPackageName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getServiceName
				/// </java-name>
				public string ServiceName
				{
						[Dot42.DexImport("getServiceName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getServiceInfo
				/// </java-name>
				public global::Android.Content.PM.ServiceInfo ServiceInfo
				{
						[Dot42.DexImport("getServiceInfo", "()Landroid/content/pm/ServiceInfo;", AccessFlags = 1)]
						get{ return default(global::Android.Content.PM.ServiceInfo); }
				}

				/// <java-name>
				/// getComponent
				/// </java-name>
				public global::Android.Content.ComponentName Component
				{
						[Dot42.DexImport("getComponent", "()Landroid/content/ComponentName;", AccessFlags = 1)]
						get{ return default(global::Android.Content.ComponentName); }
				}

				/// <java-name>
				/// getSettingsActivity
				/// </java-name>
				public string SettingsActivity
				{
						[Dot42.DexImport("getSettingsActivity", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

		}

		/// <java-name>
		/// android/app/WallpaperManager
		/// </java-name>
		[Dot42.DexImport("android/app/WallpaperManager", AccessFlags = 33)]
		public partial class WallpaperManager
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// ACTION_LIVE_WALLPAPER_CHOOSER
				/// </java-name>
				[Dot42.DexImport("ACTION_LIVE_WALLPAPER_CHOOSER", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_LIVE_WALLPAPER_CHOOSER = "android.service.wallpaper.LIVE_WALLPAPER_CHOOSER";
				/// <java-name>
				/// WALLPAPER_PREVIEW_META_DATA
				/// </java-name>
				[Dot42.DexImport("WALLPAPER_PREVIEW_META_DATA", "Ljava/lang/String;", AccessFlags = 25)]
				public const string WALLPAPER_PREVIEW_META_DATA = "android.wallpaper.preview";
				/// <java-name>
				/// COMMAND_TAP
				/// </java-name>
				[Dot42.DexImport("COMMAND_TAP", "Ljava/lang/String;", AccessFlags = 25)]
				public const string COMMAND_TAP = "android.wallpaper.tap";
				/// <java-name>
				/// COMMAND_SECONDARY_TAP
				/// </java-name>
				[Dot42.DexImport("COMMAND_SECONDARY_TAP", "Ljava/lang/String;", AccessFlags = 25)]
				public const string COMMAND_SECONDARY_TAP = "android.wallpaper.secondaryTap";
				/// <java-name>
				/// COMMAND_DROP
				/// </java-name>
				[Dot42.DexImport("COMMAND_DROP", "Ljava/lang/String;", AccessFlags = 25)]
				public const string COMMAND_DROP = "android.home.drop";
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal WallpaperManager() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(Landroid/content/Context;)Landroid/app/WallpaperManager;", AccessFlags = 9)]
				public static global::Android.App.WallpaperManager GetInstance(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
						return default(global::Android.App.WallpaperManager);
				}

				/// <java-name>
				/// peekDrawable
				/// </java-name>
				[Dot42.DexImport("peekDrawable", "()Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
				public virtual global::Android.Graphics.Drawables.Drawable PeekDrawable() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawables.Drawable);
				}

				/// <java-name>
				/// peekFastDrawable
				/// </java-name>
				[Dot42.DexImport("peekFastDrawable", "()Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
				public virtual global::Android.Graphics.Drawables.Drawable PeekFastDrawable() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawables.Drawable);
				}

				/// <java-name>
				/// forgetLoadedWallpaper
				/// </java-name>
				[Dot42.DexImport("forgetLoadedWallpaper", "()V", AccessFlags = 1)]
				public virtual void ForgetLoadedWallpaper() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setResource
				/// </java-name>
				[Dot42.DexImport("setResource", "(I)V", AccessFlags = 1)]
				public virtual void SetResource(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setBitmap
				/// </java-name>
				[Dot42.DexImport("setBitmap", "(Landroid/graphics/Bitmap;)V", AccessFlags = 1)]
				public virtual void SetBitmap(global::Android.Graphics.Bitmap bitmap) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setStream
				/// </java-name>
				[Dot42.DexImport("setStream", "(Ljava/io/InputStream;)V", AccessFlags = 1)]
				public virtual void SetStream(global::Java.IO.InputStream inputStream) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// suggestDesiredDimensions
				/// </java-name>
				[Dot42.DexImport("suggestDesiredDimensions", "(II)V", AccessFlags = 1)]
				public virtual void SuggestDesiredDimensions(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setWallpaperOffsets
				/// </java-name>
				[Dot42.DexImport("setWallpaperOffsets", "(Landroid/os/IBinder;FF)V", AccessFlags = 1)]
				public virtual void SetWallpaperOffsets(global::Android.OS.IBinder binder, float single, float single1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setWallpaperOffsetSteps
				/// </java-name>
				[Dot42.DexImport("setWallpaperOffsetSteps", "(FF)V", AccessFlags = 1)]
				public virtual void SetWallpaperOffsetSteps(float single, float single1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// sendWallpaperCommand
				/// </java-name>
				[Dot42.DexImport("sendWallpaperCommand", "(Landroid/os/IBinder;Ljava/lang/String;IIILandroid/os/Bundle;)V", AccessFlags = 1)]
				public virtual void SendWallpaperCommand(global::Android.OS.IBinder binder, string @string, int int32, int int321, int int322, global::Android.OS.Bundle bundle) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// clearWallpaperOffsets
				/// </java-name>
				[Dot42.DexImport("clearWallpaperOffsets", "(Landroid/os/IBinder;)V", AccessFlags = 1)]
				public virtual void ClearWallpaperOffsets(global::Android.OS.IBinder binder) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// clear
				/// </java-name>
				[Dot42.DexImport("clear", "()V", AccessFlags = 1)]
				public virtual void Clear() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getDrawable
				/// </java-name>
				public virtual global::Android.Graphics.Drawables.Drawable Drawable
				{
						[Dot42.DexImport("getDrawable", "()Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
						get{ return default(global::Android.Graphics.Drawables.Drawable); }
				}

				/// <java-name>
				/// getFastDrawable
				/// </java-name>
				public virtual global::Android.Graphics.Drawables.Drawable FastDrawable
				{
						[Dot42.DexImport("getFastDrawable", "()Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
						get{ return default(global::Android.Graphics.Drawables.Drawable); }
				}

				/// <java-name>
				/// getWallpaperInfo
				/// </java-name>
				public virtual global::Android.App.WallpaperInfo WallpaperInfo
				{
						[Dot42.DexImport("getWallpaperInfo", "()Landroid/app/WallpaperInfo;", AccessFlags = 1)]
						get{ return default(global::Android.App.WallpaperInfo); }
				}

				/// <java-name>
				/// getDesiredMinimumWidth
				/// </java-name>
				public virtual int DesiredMinimumWidth
				{
						[Dot42.DexImport("getDesiredMinimumWidth", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

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

