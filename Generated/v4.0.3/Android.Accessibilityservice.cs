#pragma warning disable 1717
namespace Android.Accessibilityservice
{
		/// <java-name>
		/// android/accessibilityservice/AccessibilityService
		/// </java-name>
		[Dot42.DexImport("android/accessibilityservice/AccessibilityService", AccessFlags = 1057)]
		public abstract partial class AccessibilityService : global::Android.App.Service
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// SERVICE_INTERFACE
				/// </java-name>
				[Dot42.DexImport("SERVICE_INTERFACE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SERVICE_INTERFACE = "android.accessibilityservice.AccessibilityService";
				/// <java-name>
				/// SERVICE_META_DATA
				/// </java-name>
				[Dot42.DexImport("SERVICE_META_DATA", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SERVICE_META_DATA = "android.accessibilityservice";
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public AccessibilityService() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onAccessibilityEvent
				/// </java-name>
				[Dot42.DexImport("onAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)V", AccessFlags = 1025)]
				public abstract void OnAccessibilityEvent(global::Android.View.Accessibility.AccessibilityEvent accessibilityEvent) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// onInterrupt
				/// </java-name>
				[Dot42.DexImport("onInterrupt", "()V", AccessFlags = 1025)]
				public abstract void OnInterrupt() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// onServiceConnected
				/// </java-name>
				[Dot42.DexImport("onServiceConnected", "()V", AccessFlags = 4)]
				protected internal virtual void OnServiceConnected() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setServiceInfo
				/// </java-name>
				[Dot42.DexImport("setServiceInfo", "(Landroid/accessibilityservice/AccessibilityServiceInfo;)V", AccessFlags = 17)]
				public void SetServiceInfo(global::Android.Accessibilityservice.AccessibilityServiceInfo accessibilityServiceInfo) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onBind
				/// </java-name>
				[Dot42.DexImport("onBind", "(Landroid/content/Intent;)Landroid/os/IBinder;", AccessFlags = 17)]
				public override global::Android.OS.IBinder OnBind(global::Android.Content.Intent intent) /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.IBinder);
				}

		}

		/// <java-name>
		/// android/accessibilityservice/AccessibilityServiceInfo
		/// </java-name>
		[Dot42.DexImport("android/accessibilityservice/AccessibilityServiceInfo", AccessFlags = 33)]
		public partial class AccessibilityServiceInfo : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// FEEDBACK_SPOKEN
				/// </java-name>
				[Dot42.DexImport("FEEDBACK_SPOKEN", "I", AccessFlags = 25)]
				public const int FEEDBACK_SPOKEN = 1;
				/// <java-name>
				/// FEEDBACK_HAPTIC
				/// </java-name>
				[Dot42.DexImport("FEEDBACK_HAPTIC", "I", AccessFlags = 25)]
				public const int FEEDBACK_HAPTIC = 2;
				/// <java-name>
				/// FEEDBACK_AUDIBLE
				/// </java-name>
				[Dot42.DexImport("FEEDBACK_AUDIBLE", "I", AccessFlags = 25)]
				public const int FEEDBACK_AUDIBLE = 4;
				/// <java-name>
				/// FEEDBACK_VISUAL
				/// </java-name>
				[Dot42.DexImport("FEEDBACK_VISUAL", "I", AccessFlags = 25)]
				public const int FEEDBACK_VISUAL = 8;
				/// <java-name>
				/// FEEDBACK_GENERIC
				/// </java-name>
				[Dot42.DexImport("FEEDBACK_GENERIC", "I", AccessFlags = 25)]
				public const int FEEDBACK_GENERIC = 16;
				/// <java-name>
				/// FEEDBACK_ALL_MASK
				/// </java-name>
				[Dot42.DexImport("FEEDBACK_ALL_MASK", "I", AccessFlags = 25)]
				public const int FEEDBACK_ALL_MASK = -1;
				/// <java-name>
				/// DEFAULT
				/// </java-name>
				[Dot42.DexImport("DEFAULT", "I", AccessFlags = 25)]
				public const int DEFAULT = 1;
				/// <java-name>
				/// eventTypes
				/// </java-name>
				[Dot42.DexImport("eventTypes", "I", AccessFlags = 1)]
				public int EventTypes;
				/// <java-name>
				/// packageNames
				/// </java-name>
				[Dot42.DexImport("packageNames", "[Ljava/lang/String;", AccessFlags = 1)]
				public string[] PackageNames;
				/// <java-name>
				/// feedbackType
				/// </java-name>
				[Dot42.DexImport("feedbackType", "I", AccessFlags = 1)]
				public int FeedbackType;
				/// <java-name>
				/// notificationTimeout
				/// </java-name>
				[Dot42.DexImport("notificationTimeout", "J", AccessFlags = 1)]
				public long NotificationTimeout;
				/// <java-name>
				/// flags
				/// </java-name>
				[Dot42.DexImport("flags", "I", AccessFlags = 1)]
				public int Flags;
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.Accessibilityservice.AccessibilityServiceInfo> CREATOR;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public AccessibilityServiceInfo() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getId
				/// </java-name>
				[Dot42.DexImport("getId", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetId() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getResolveInfo
				/// </java-name>
				[Dot42.DexImport("getResolveInfo", "()Landroid/content/pm/ResolveInfo;", AccessFlags = 1)]
				public virtual global::Android.Content.Pm.ResolveInfo GetResolveInfo() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Pm.ResolveInfo);
				}

				/// <java-name>
				/// getSettingsActivityName
				/// </java-name>
				[Dot42.DexImport("getSettingsActivityName", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetSettingsActivityName() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getCanRetrieveWindowContent
				/// </java-name>
				[Dot42.DexImport("getCanRetrieveWindowContent", "()Z", AccessFlags = 1)]
				public virtual bool GetCanRetrieveWindowContent() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getDescription
				/// </java-name>
				[Dot42.DexImport("getDescription", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetDescription() /* MethodBuilder.Create */ 
				{
						return default(string);
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
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// feedbackTypeToString
				/// </java-name>
				[Dot42.DexImport("feedbackTypeToString", "(I)Ljava/lang/String;", AccessFlags = 9)]
				public static string FeedbackTypeToString(int int32) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// flagToString
				/// </java-name>
				[Dot42.DexImport("flagToString", "(I)Ljava/lang/String;", AccessFlags = 9)]
				public static string FlagToString(int int32) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getId
				/// </java-name>
				public string Id
				{
				[Dot42.DexImport("getId", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetId(); }
				}

				/// <java-name>
				/// getResolveInfo
				/// </java-name>
				public global::Android.Content.Pm.ResolveInfo ResolveInfo
				{
				[Dot42.DexImport("getResolveInfo", "()Landroid/content/pm/ResolveInfo;", AccessFlags = 1)]
						get{ return GetResolveInfo(); }
				}

				/// <java-name>
				/// getSettingsActivityName
				/// </java-name>
				public string SettingsActivityName
				{
				[Dot42.DexImport("getSettingsActivityName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetSettingsActivityName(); }
				}

				/// <java-name>
				/// getCanRetrieveWindowContent
				/// </java-name>
				public bool IsCanRetrieveWindowContent
				{
				[Dot42.DexImport("getCanRetrieveWindowContent", "()Z", AccessFlags = 1)]
						get{ return GetCanRetrieveWindowContent(); }
				}

				/// <java-name>
				/// getDescription
				/// </java-name>
				public string Description
				{
				[Dot42.DexImport("getDescription", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetDescription(); }
				}

		}

}

