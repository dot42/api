#pragma warning disable 1717
namespace Android.View.Accessibility
{
		/// <java-name>
		/// android/view/accessibility/AccessibilityNodeInfo
		/// </java-name>
		[Dot42.DexImport("android/view/accessibility/AccessibilityNodeInfo", AccessFlags = 33)]
		public partial class AccessibilityNodeInfo : global::Android.Os.IParcelable
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
				public static readonly global::Android.Os.IParcelable_ICreator<global::Android.View.Accessibility.AccessibilityNodeInfo> CREATOR;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal AccessibilityNodeInfo() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setSource
				/// </java-name>
				[Dot42.DexImport("setSource", "(Landroid/view/View;)V", AccessFlags = 1)]
				public virtual void SetSource(global::Android.View.View view) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getWindowId
				/// </java-name>
				[Dot42.DexImport("getWindowId", "()I", AccessFlags = 1)]
				public virtual int GetWindowId() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getChildCount
				/// </java-name>
				[Dot42.DexImport("getChildCount", "()I", AccessFlags = 1)]
				public virtual int GetChildCount() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getChild
				/// </java-name>
				[Dot42.DexImport("getChild", "(I)Landroid/view/accessibility/AccessibilityNodeInfo;", AccessFlags = 1)]
				public virtual global::Android.View.Accessibility.AccessibilityNodeInfo GetChild(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.View.Accessibility.AccessibilityNodeInfo);
				}

				/// <java-name>
				/// addChild
				/// </java-name>
				[Dot42.DexImport("addChild", "(Landroid/view/View;)V", AccessFlags = 1)]
				public virtual void AddChild(global::Android.View.View view) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getActions
				/// </java-name>
				[Dot42.DexImport("getActions", "()I", AccessFlags = 1)]
				public virtual int GetActions() /* MethodBuilder.Create */ 
				{
						return default(int);
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
				public virtual global::Java.Util.IList<global::Android.View.Accessibility.AccessibilityNodeInfo> FindAccessibilityNodeInfosByText(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<global::Android.View.Accessibility.AccessibilityNodeInfo>);
				}

				/// <java-name>
				/// getParent
				/// </java-name>
				[Dot42.DexImport("getParent", "()Landroid/view/accessibility/AccessibilityNodeInfo;", AccessFlags = 1)]
				public virtual global::Android.View.Accessibility.AccessibilityNodeInfo GetParent() /* MethodBuilder.Create */ 
				{
						return default(global::Android.View.Accessibility.AccessibilityNodeInfo);
				}

				/// <java-name>
				/// setParent
				/// </java-name>
				[Dot42.DexImport("setParent", "(Landroid/view/View;)V", AccessFlags = 1)]
				public virtual void SetParent(global::Android.View.View view) /* MethodBuilder.Create */ 
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
				/// isCheckable
				/// </java-name>
				[Dot42.DexImport("isCheckable", "()Z", AccessFlags = 1)]
				public virtual bool IsCheckable() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setCheckable
				/// </java-name>
				[Dot42.DexImport("setCheckable", "(Z)V", AccessFlags = 1)]
				public virtual void SetCheckable(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isChecked
				/// </java-name>
				[Dot42.DexImport("isChecked", "()Z", AccessFlags = 1)]
				public virtual bool IsChecked() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setChecked
				/// </java-name>
				[Dot42.DexImport("setChecked", "(Z)V", AccessFlags = 1)]
				public virtual void SetChecked(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isFocusable
				/// </java-name>
				[Dot42.DexImport("isFocusable", "()Z", AccessFlags = 1)]
				public virtual bool IsFocusable() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setFocusable
				/// </java-name>
				[Dot42.DexImport("setFocusable", "(Z)V", AccessFlags = 1)]
				public virtual void SetFocusable(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isFocused
				/// </java-name>
				[Dot42.DexImport("isFocused", "()Z", AccessFlags = 1)]
				public virtual bool IsFocused() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setFocused
				/// </java-name>
				[Dot42.DexImport("setFocused", "(Z)V", AccessFlags = 1)]
				public virtual void SetFocused(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isSelected
				/// </java-name>
				[Dot42.DexImport("isSelected", "()Z", AccessFlags = 1)]
				public virtual bool IsSelected() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setSelected
				/// </java-name>
				[Dot42.DexImport("setSelected", "(Z)V", AccessFlags = 1)]
				public virtual void SetSelected(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isClickable
				/// </java-name>
				[Dot42.DexImport("isClickable", "()Z", AccessFlags = 1)]
				public virtual bool IsClickable() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setClickable
				/// </java-name>
				[Dot42.DexImport("setClickable", "(Z)V", AccessFlags = 1)]
				public virtual void SetClickable(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isLongClickable
				/// </java-name>
				[Dot42.DexImport("isLongClickable", "()Z", AccessFlags = 1)]
				public virtual bool IsLongClickable() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setLongClickable
				/// </java-name>
				[Dot42.DexImport("setLongClickable", "(Z)V", AccessFlags = 1)]
				public virtual void SetLongClickable(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isEnabled
				/// </java-name>
				[Dot42.DexImport("isEnabled", "()Z", AccessFlags = 1)]
				public virtual bool IsEnabled() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setEnabled
				/// </java-name>
				[Dot42.DexImport("setEnabled", "(Z)V", AccessFlags = 1)]
				public virtual void SetEnabled(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isPassword
				/// </java-name>
				[Dot42.DexImport("isPassword", "()Z", AccessFlags = 1)]
				public virtual bool IsPassword() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setPassword
				/// </java-name>
				[Dot42.DexImport("setPassword", "(Z)V", AccessFlags = 1)]
				public virtual void SetPassword(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isScrollable
				/// </java-name>
				[Dot42.DexImport("isScrollable", "()Z", AccessFlags = 1)]
				public virtual bool IsScrollable() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setScrollable
				/// </java-name>
				[Dot42.DexImport("setScrollable", "(Z)V", AccessFlags = 1)]
				public virtual void SetScrollable(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getPackageName
				/// </java-name>
				[Dot42.DexImport("getPackageName", "()Ljava/lang/CharSequence;", AccessFlags = 1)]
				public virtual global::Java.Lang.ICharSequence GetPackageName() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <java-name>
				/// setPackageName
				/// </java-name>
				[Dot42.DexImport("setPackageName", "(Ljava/lang/CharSequence;)V", AccessFlags = 1)]
				public virtual void SetPackageName(global::Java.Lang.ICharSequence charSequence) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getClassName
				/// </java-name>
				[Dot42.DexImport("getClassName", "()Ljava/lang/CharSequence;", AccessFlags = 1)]
				public virtual global::Java.Lang.ICharSequence GetClassName() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <java-name>
				/// setClassName
				/// </java-name>
				[Dot42.DexImport("setClassName", "(Ljava/lang/CharSequence;)V", AccessFlags = 1)]
				public virtual void SetClassName(global::Java.Lang.ICharSequence charSequence) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getText
				/// </java-name>
				[Dot42.DexImport("getText", "()Ljava/lang/CharSequence;", AccessFlags = 1)]
				public virtual global::Java.Lang.ICharSequence GetText() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <java-name>
				/// setText
				/// </java-name>
				[Dot42.DexImport("setText", "(Ljava/lang/CharSequence;)V", AccessFlags = 1)]
				public virtual void SetText(global::Java.Lang.ICharSequence charSequence) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getContentDescription
				/// </java-name>
				[Dot42.DexImport("getContentDescription", "()Ljava/lang/CharSequence;", AccessFlags = 1)]
				public virtual global::Java.Lang.ICharSequence GetContentDescription() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <java-name>
				/// setContentDescription
				/// </java-name>
				[Dot42.DexImport("setContentDescription", "(Ljava/lang/CharSequence;)V", AccessFlags = 1)]
				public virtual void SetContentDescription(global::Java.Lang.ICharSequence charSequence) /* MethodBuilder.Create */ 
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
				public static global::Android.View.Accessibility.AccessibilityNodeInfo Obtain(global::Android.View.View view) /* MethodBuilder.Create */ 
				{
						return default(global::Android.View.Accessibility.AccessibilityNodeInfo);
				}

				/// <java-name>
				/// obtain
				/// </java-name>
				[Dot42.DexImport("obtain", "()Landroid/view/accessibility/AccessibilityNodeInfo;", AccessFlags = 9)]
				public static global::Android.View.Accessibility.AccessibilityNodeInfo Obtain() /* MethodBuilder.Create */ 
				{
						return default(global::Android.View.Accessibility.AccessibilityNodeInfo);
				}

				/// <java-name>
				/// obtain
				/// </java-name>
				[Dot42.DexImport("obtain", "(Landroid/view/accessibility/AccessibilityNodeInfo;)Landroid/view/accessibility/A" +
    "ccessibilityNodeInfo;", AccessFlags = 9)]
				public static global::Android.View.Accessibility.AccessibilityNodeInfo Obtain(global::Android.View.Accessibility.AccessibilityNodeInfo accessibilityNodeInfo) /* MethodBuilder.Create */ 
				{
						return default(global::Android.View.Accessibility.AccessibilityNodeInfo);
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
				public virtual void WriteToParcel(global::Android.Os.Parcel parcel, int int32) /* MethodBuilder.Create */ 
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
				public int WindowId
				{
				[Dot42.DexImport("getWindowId", "()I", AccessFlags = 1)]
						get{ return GetWindowId(); }
				}

				/// <java-name>
				/// getChildCount
				/// </java-name>
				public int ChildCount
				{
				[Dot42.DexImport("getChildCount", "()I", AccessFlags = 1)]
						get{ return GetChildCount(); }
				}

				/// <java-name>
				/// getActions
				/// </java-name>
				public int Actions
				{
				[Dot42.DexImport("getActions", "()I", AccessFlags = 1)]
						get{ return GetActions(); }
				}

				/// <java-name>
				/// getParent
				/// </java-name>
				public global::Android.View.Accessibility.AccessibilityNodeInfo Parent
				{
				[Dot42.DexImport("getParent", "()Landroid/view/accessibility/AccessibilityNodeInfo;", AccessFlags = 1)]
						get{ return GetParent(); }
				}

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
				public virtual void SetSource(global::Android.View.View view) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getSource
				/// </java-name>
				[Dot42.DexImport("getSource", "()Landroid/view/accessibility/AccessibilityNodeInfo;", AccessFlags = 1)]
				public virtual global::Android.View.Accessibility.AccessibilityNodeInfo GetSource() /* MethodBuilder.Create */ 
				{
						return default(global::Android.View.Accessibility.AccessibilityNodeInfo);
				}

				/// <java-name>
				/// getWindowId
				/// </java-name>
				[Dot42.DexImport("getWindowId", "()I", AccessFlags = 1)]
				public virtual int GetWindowId() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// isChecked
				/// </java-name>
				[Dot42.DexImport("isChecked", "()Z", AccessFlags = 1)]
				public virtual bool IsChecked() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setChecked
				/// </java-name>
				[Dot42.DexImport("setChecked", "(Z)V", AccessFlags = 1)]
				public virtual void SetChecked(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isEnabled
				/// </java-name>
				[Dot42.DexImport("isEnabled", "()Z", AccessFlags = 1)]
				public virtual bool IsEnabled() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setEnabled
				/// </java-name>
				[Dot42.DexImport("setEnabled", "(Z)V", AccessFlags = 1)]
				public virtual void SetEnabled(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isPassword
				/// </java-name>
				[Dot42.DexImport("isPassword", "()Z", AccessFlags = 1)]
				public virtual bool IsPassword() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setPassword
				/// </java-name>
				[Dot42.DexImport("setPassword", "(Z)V", AccessFlags = 1)]
				public virtual void SetPassword(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isFullScreen
				/// </java-name>
				[Dot42.DexImport("isFullScreen", "()Z", AccessFlags = 1)]
				public virtual bool IsFullScreen() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setFullScreen
				/// </java-name>
				[Dot42.DexImport("setFullScreen", "(Z)V", AccessFlags = 1)]
				public virtual void SetFullScreen(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isScrollable
				/// </java-name>
				[Dot42.DexImport("isScrollable", "()Z", AccessFlags = 1)]
				public virtual bool IsScrollable() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setScrollable
				/// </java-name>
				[Dot42.DexImport("setScrollable", "(Z)V", AccessFlags = 1)]
				public virtual void SetScrollable(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getItemCount
				/// </java-name>
				[Dot42.DexImport("getItemCount", "()I", AccessFlags = 1)]
				public virtual int GetItemCount() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// setItemCount
				/// </java-name>
				[Dot42.DexImport("setItemCount", "(I)V", AccessFlags = 1)]
				public virtual void SetItemCount(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getCurrentItemIndex
				/// </java-name>
				[Dot42.DexImport("getCurrentItemIndex", "()I", AccessFlags = 1)]
				public virtual int GetCurrentItemIndex() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// setCurrentItemIndex
				/// </java-name>
				[Dot42.DexImport("setCurrentItemIndex", "(I)V", AccessFlags = 1)]
				public virtual void SetCurrentItemIndex(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getFromIndex
				/// </java-name>
				[Dot42.DexImport("getFromIndex", "()I", AccessFlags = 1)]
				public virtual int GetFromIndex() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// setFromIndex
				/// </java-name>
				[Dot42.DexImport("setFromIndex", "(I)V", AccessFlags = 1)]
				public virtual void SetFromIndex(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getToIndex
				/// </java-name>
				[Dot42.DexImport("getToIndex", "()I", AccessFlags = 1)]
				public virtual int GetToIndex() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// setToIndex
				/// </java-name>
				[Dot42.DexImport("setToIndex", "(I)V", AccessFlags = 1)]
				public virtual void SetToIndex(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getScrollX
				/// </java-name>
				[Dot42.DexImport("getScrollX", "()I", AccessFlags = 1)]
				public virtual int GetScrollX() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// setScrollX
				/// </java-name>
				[Dot42.DexImport("setScrollX", "(I)V", AccessFlags = 1)]
				public virtual void SetScrollX(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getScrollY
				/// </java-name>
				[Dot42.DexImport("getScrollY", "()I", AccessFlags = 1)]
				public virtual int GetScrollY() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// setScrollY
				/// </java-name>
				[Dot42.DexImport("setScrollY", "(I)V", AccessFlags = 1)]
				public virtual void SetScrollY(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getMaxScrollX
				/// </java-name>
				[Dot42.DexImport("getMaxScrollX", "()I", AccessFlags = 1)]
				public virtual int GetMaxScrollX() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// setMaxScrollX
				/// </java-name>
				[Dot42.DexImport("setMaxScrollX", "(I)V", AccessFlags = 1)]
				public virtual void SetMaxScrollX(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getMaxScrollY
				/// </java-name>
				[Dot42.DexImport("getMaxScrollY", "()I", AccessFlags = 1)]
				public virtual int GetMaxScrollY() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// setMaxScrollY
				/// </java-name>
				[Dot42.DexImport("setMaxScrollY", "(I)V", AccessFlags = 1)]
				public virtual void SetMaxScrollY(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getAddedCount
				/// </java-name>
				[Dot42.DexImport("getAddedCount", "()I", AccessFlags = 1)]
				public virtual int GetAddedCount() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// setAddedCount
				/// </java-name>
				[Dot42.DexImport("setAddedCount", "(I)V", AccessFlags = 1)]
				public virtual void SetAddedCount(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getRemovedCount
				/// </java-name>
				[Dot42.DexImport("getRemovedCount", "()I", AccessFlags = 1)]
				public virtual int GetRemovedCount() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// setRemovedCount
				/// </java-name>
				[Dot42.DexImport("setRemovedCount", "(I)V", AccessFlags = 1)]
				public virtual void SetRemovedCount(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getClassName
				/// </java-name>
				[Dot42.DexImport("getClassName", "()Ljava/lang/CharSequence;", AccessFlags = 1)]
				public virtual global::Java.Lang.ICharSequence GetClassName() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <java-name>
				/// setClassName
				/// </java-name>
				[Dot42.DexImport("setClassName", "(Ljava/lang/CharSequence;)V", AccessFlags = 1)]
				public virtual void SetClassName(global::Java.Lang.ICharSequence charSequence) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getText
				/// </java-name>
				[Dot42.DexImport("getText", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Ljava/lang/CharSequence;>;")]
				public virtual global::Java.Util.IList<global::Java.Lang.ICharSequence> GetText() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<global::Java.Lang.ICharSequence>);
				}

				/// <java-name>
				/// getBeforeText
				/// </java-name>
				[Dot42.DexImport("getBeforeText", "()Ljava/lang/CharSequence;", AccessFlags = 1)]
				public virtual global::Java.Lang.ICharSequence GetBeforeText() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <java-name>
				/// setBeforeText
				/// </java-name>
				[Dot42.DexImport("setBeforeText", "(Ljava/lang/CharSequence;)V", AccessFlags = 1)]
				public virtual void SetBeforeText(global::Java.Lang.ICharSequence charSequence) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getContentDescription
				/// </java-name>
				[Dot42.DexImport("getContentDescription", "()Ljava/lang/CharSequence;", AccessFlags = 1)]
				public virtual global::Java.Lang.ICharSequence GetContentDescription() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <java-name>
				/// setContentDescription
				/// </java-name>
				[Dot42.DexImport("setContentDescription", "(Ljava/lang/CharSequence;)V", AccessFlags = 1)]
				public virtual void SetContentDescription(global::Java.Lang.ICharSequence charSequence) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getParcelableData
				/// </java-name>
				[Dot42.DexImport("getParcelableData", "()Landroid/os/Parcelable;", AccessFlags = 1)]
				public virtual global::Android.Os.IParcelable GetParcelableData() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Os.IParcelable);
				}

				/// <java-name>
				/// setParcelableData
				/// </java-name>
				[Dot42.DexImport("setParcelableData", "(Landroid/os/Parcelable;)V", AccessFlags = 1)]
				public virtual void SetParcelableData(global::Android.Os.IParcelable parcelable) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// obtain
				/// </java-name>
				[Dot42.DexImport("obtain", "(Landroid/view/accessibility/AccessibilityRecord;)Landroid/view/accessibility/Acc" +
    "essibilityRecord;", AccessFlags = 9)]
				public static global::Android.View.Accessibility.AccessibilityRecord Obtain(global::Android.View.Accessibility.AccessibilityRecord accessibilityRecord) /* MethodBuilder.Create */ 
				{
						return default(global::Android.View.Accessibility.AccessibilityRecord);
				}

				/// <java-name>
				/// obtain
				/// </java-name>
				[Dot42.DexImport("obtain", "()Landroid/view/accessibility/AccessibilityRecord;", AccessFlags = 9)]
				public static global::Android.View.Accessibility.AccessibilityRecord Obtain() /* MethodBuilder.Create */ 
				{
						return default(global::Android.View.Accessibility.AccessibilityRecord);
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
				public global::Android.View.Accessibility.AccessibilityNodeInfo Source
				{
				[Dot42.DexImport("getSource", "()Landroid/view/accessibility/AccessibilityNodeInfo;", AccessFlags = 1)]
						get{ return GetSource(); }
				}

				/// <java-name>
				/// getWindowId
				/// </java-name>
				public int WindowId
				{
				[Dot42.DexImport("getWindowId", "()I", AccessFlags = 1)]
						get{ return GetWindowId(); }
				}

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

				/// <java-name>
				/// getText
				/// </java-name>
				public global::Java.Util.IList<global::Java.Lang.ICharSequence> Text
				{
				[Dot42.DexImport("getText", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Ljava/lang/CharSequence;>;")]
						get{ return GetText(); }
				}

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

		/// <java-name>
		/// android/view/accessibility/AccessibilityEvent
		/// </java-name>
		[Dot42.DexImport("android/view/accessibility/AccessibilityEvent", AccessFlags = 49)]
		public sealed partial class AccessibilityEvent : global::Android.View.Accessibility.AccessibilityRecord, global::Android.Os.IParcelable
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
				public static readonly global::Android.Os.IParcelable_ICreator<global::Android.View.Accessibility.AccessibilityEvent> CREATOR;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal AccessibilityEvent() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getRecordCount
				/// </java-name>
				[Dot42.DexImport("getRecordCount", "()I", AccessFlags = 1)]
				public int GetRecordCount() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// appendRecord
				/// </java-name>
				[Dot42.DexImport("appendRecord", "(Landroid/view/accessibility/AccessibilityRecord;)V", AccessFlags = 1)]
				public void AppendRecord(global::Android.View.Accessibility.AccessibilityRecord accessibilityRecord) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getRecord
				/// </java-name>
				[Dot42.DexImport("getRecord", "(I)Landroid/view/accessibility/AccessibilityRecord;", AccessFlags = 1)]
				public global::Android.View.Accessibility.AccessibilityRecord GetRecord(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.View.Accessibility.AccessibilityRecord);
				}

				/// <java-name>
				/// getEventType
				/// </java-name>
				[Dot42.DexImport("getEventType", "()I", AccessFlags = 1)]
				public int GetEventType() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// setEventType
				/// </java-name>
				[Dot42.DexImport("setEventType", "(I)V", AccessFlags = 1)]
				public void SetEventType(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getEventTime
				/// </java-name>
				[Dot42.DexImport("getEventTime", "()J", AccessFlags = 1)]
				public long GetEventTime() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// setEventTime
				/// </java-name>
				[Dot42.DexImport("setEventTime", "(J)V", AccessFlags = 1)]
				public void SetEventTime(long int64) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getPackageName
				/// </java-name>
				[Dot42.DexImport("getPackageName", "()Ljava/lang/CharSequence;", AccessFlags = 1)]
				public global::Java.Lang.ICharSequence GetPackageName() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <java-name>
				/// setPackageName
				/// </java-name>
				[Dot42.DexImport("setPackageName", "(Ljava/lang/CharSequence;)V", AccessFlags = 1)]
				public void SetPackageName(global::Java.Lang.ICharSequence charSequence) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// obtain
				/// </java-name>
				[Dot42.DexImport("obtain", "(I)Landroid/view/accessibility/AccessibilityEvent;", AccessFlags = 9)]
				public static global::Android.View.Accessibility.AccessibilityEvent Obtain(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.View.Accessibility.AccessibilityEvent);
				}

				/// <java-name>
				/// obtain
				/// </java-name>
				[Dot42.DexImport("obtain", "(Landroid/view/accessibility/AccessibilityEvent;)Landroid/view/accessibility/Acce" +
    "ssibilityEvent;", AccessFlags = 9)]
				public static global::Android.View.Accessibility.AccessibilityEvent Obtain(global::Android.View.Accessibility.AccessibilityEvent accessibilityEvent) /* MethodBuilder.Create */ 
				{
						return default(global::Android.View.Accessibility.AccessibilityEvent);
				}

				/// <java-name>
				/// obtain
				/// </java-name>
				[Dot42.DexImport("obtain", "()Landroid/view/accessibility/AccessibilityEvent;", AccessFlags = 9)]
				public static global::Android.View.Accessibility.AccessibilityEvent Obtain() /* MethodBuilder.Create */ 
				{
						return default(global::Android.View.Accessibility.AccessibilityEvent);
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
				public void InitFromParcel(global::Android.Os.Parcel parcel) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public void WriteToParcel(global::Android.Os.Parcel parcel, int int32) /* MethodBuilder.Create */ 
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
						get{ return GetRecordCount(); }
				}

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
				/// getEventTime
				/// </java-name>
				public long EventTime
				{
				[Dot42.DexImport("getEventTime", "()J", AccessFlags = 1)]
						get{ return GetEventTime(); }
				[Dot42.DexImport("setEventTime", "(J)V", AccessFlags = 1)]
						set{ SetEventTime(value); }
				}

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
				/// isEnabled
				/// </java-name>
				[Dot42.DexImport("isEnabled", "()Z", AccessFlags = 1)]
				public bool IsEnabled() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isTouchExplorationEnabled
				/// </java-name>
				[Dot42.DexImport("isTouchExplorationEnabled", "()Z", AccessFlags = 1)]
				public bool IsTouchExplorationEnabled() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// sendAccessibilityEvent
				/// </java-name>
				[Dot42.DexImport("sendAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)V", AccessFlags = 1)]
				public void SendAccessibilityEvent(global::Android.View.Accessibility.AccessibilityEvent accessibilityEvent) /* MethodBuilder.Create */ 
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
				/// getAccessibilityServiceList
				/// </java-name>
				[Dot42.DexImport("getAccessibilityServiceList", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Landroid/content/pm/ServiceInfo;>;")]
				public global::Java.Util.IList<global::Android.Content.Pm.ServiceInfo> GetAccessibilityServiceList() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<global::Android.Content.Pm.ServiceInfo>);
				}

				/// <java-name>
				/// getInstalledAccessibilityServiceList
				/// </java-name>
				[Dot42.DexImport("getInstalledAccessibilityServiceList", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Landroid/accessibilityservice/AccessibilityServiceInfo;>;")]
				public global::Java.Util.IList<global::Android.Accessibilityservice.AccessibilityServiceInfo> GetInstalledAccessibilityServiceList() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<global::Android.Accessibilityservice.AccessibilityServiceInfo>);
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
				public bool AddAccessibilityStateChangeListener(global::Android.View.Accessibility.AccessibilityManager.IAccessibilityStateChangeListener accessibilityStateChangeListener) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// removeAccessibilityStateChangeListener
				/// </java-name>
				[Dot42.DexImport("removeAccessibilityStateChangeListener", "(Landroid/view/accessibility/AccessibilityManager$AccessibilityStateChangeListene" +
    "r;)Z", AccessFlags = 1)]
				public bool RemoveAccessibilityStateChangeListener(global::Android.View.Accessibility.AccessibilityManager.IAccessibilityStateChangeListener accessibilityStateChangeListener) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getAccessibilityServiceList
				/// </java-name>
				public global::Java.Util.IList<global::Android.Content.Pm.ServiceInfo> AccessibilityServiceList
				{
				[Dot42.DexImport("getAccessibilityServiceList", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Landroid/content/pm/ServiceInfo;>;")]
						get{ return GetAccessibilityServiceList(); }
				}

				/// <java-name>
				/// getInstalledAccessibilityServiceList
				/// </java-name>
				public global::Java.Util.IList<global::Android.Accessibilityservice.AccessibilityServiceInfo> InstalledAccessibilityServiceList
				{
				[Dot42.DexImport("getInstalledAccessibilityServiceList", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Landroid/accessibilityservice/AccessibilityServiceInfo;>;")]
						get{ return GetInstalledAccessibilityServiceList(); }
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
				void SendAccessibilityEventUnchecked(global::Android.View.Accessibility.AccessibilityEvent accessibilityEvent) /* MethodBuilder.Create */ ;

		}

}

