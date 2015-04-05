#pragma warning disable 1717
namespace Android.App.Admin
{
		/// <java-name>
		/// android/app/admin/DeviceAdminInfo
		/// </java-name>
		[Dot42.DexImport("android/app/admin/DeviceAdminInfo", AccessFlags = 49)]
		public sealed partial class DeviceAdminInfo : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// USES_POLICY_LIMIT_PASSWORD
				/// </java-name>
				[Dot42.DexImport("USES_POLICY_LIMIT_PASSWORD", "I", AccessFlags = 25)]
				public const int USES_POLICY_LIMIT_PASSWORD = 0;
				/// <java-name>
				/// USES_POLICY_WATCH_LOGIN
				/// </java-name>
				[Dot42.DexImport("USES_POLICY_WATCH_LOGIN", "I", AccessFlags = 25)]
				public const int USES_POLICY_WATCH_LOGIN = 1;
				/// <java-name>
				/// USES_POLICY_RESET_PASSWORD
				/// </java-name>
				[Dot42.DexImport("USES_POLICY_RESET_PASSWORD", "I", AccessFlags = 25)]
				public const int USES_POLICY_RESET_PASSWORD = 2;
				/// <java-name>
				/// USES_POLICY_FORCE_LOCK
				/// </java-name>
				[Dot42.DexImport("USES_POLICY_FORCE_LOCK", "I", AccessFlags = 25)]
				public const int USES_POLICY_FORCE_LOCK = 3;
				/// <java-name>
				/// USES_POLICY_WIPE_DATA
				/// </java-name>
				[Dot42.DexImport("USES_POLICY_WIPE_DATA", "I", AccessFlags = 25)]
				public const int USES_POLICY_WIPE_DATA = 4;
				/// <java-name>
				/// USES_POLICY_EXPIRE_PASSWORD
				/// </java-name>
				[Dot42.DexImport("USES_POLICY_EXPIRE_PASSWORD", "I", AccessFlags = 25)]
				public const int USES_POLICY_EXPIRE_PASSWORD = 6;
				/// <java-name>
				/// USES_ENCRYPTED_STORAGE
				/// </java-name>
				[Dot42.DexImport("USES_ENCRYPTED_STORAGE", "I", AccessFlags = 25)]
				public const int USES_ENCRYPTED_STORAGE = 7;
				/// <java-name>
				/// USES_POLICY_DISABLE_CAMERA
				/// </java-name>
				[Dot42.DexImport("USES_POLICY_DISABLE_CAMERA", "I", AccessFlags = 25)]
				public const int USES_POLICY_DISABLE_CAMERA = 8;
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.App.Admin.DeviceAdminInfo> CREATOR;
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/content/pm/ResolveInfo;)V", AccessFlags = 1)]
				public DeviceAdminInfo(global::Android.Content.Context context, global::Android.Content.Pm.ResolveInfo resolveInfo) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// loadLabel
				/// </java-name>
				[Dot42.DexImport("loadLabel", "(Landroid/content/pm/PackageManager;)Ljava/lang/CharSequence;", AccessFlags = 1)]
				public global::Java.Lang.ICharSequence LoadLabel(global::Android.Content.Pm.PackageManager packageManager) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <java-name>
				/// loadDescription
				/// </java-name>
				[Dot42.DexImport("loadDescription", "(Landroid/content/pm/PackageManager;)Ljava/lang/CharSequence;", AccessFlags = 1)]
				public global::Java.Lang.ICharSequence LoadDescription(global::Android.Content.Pm.PackageManager packageManager) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <java-name>
				/// loadIcon
				/// </java-name>
				[Dot42.DexImport("loadIcon", "(Landroid/content/pm/PackageManager;)Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
				public global::Android.Graphics.Drawables.Drawable LoadIcon(global::Android.Content.Pm.PackageManager packageManager) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawables.Drawable);
				}

				/// <java-name>
				/// usesPolicy
				/// </java-name>
				[Dot42.DexImport("usesPolicy", "(I)Z", AccessFlags = 1)]
				public bool UsesPolicy(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getTagForPolicy
				/// </java-name>
				[Dot42.DexImport("getTagForPolicy", "(I)Ljava/lang/String;", AccessFlags = 1)]
				public string GetTagForPolicy(int int32) /* MethodBuilder.Create */ 
				{
						return default(string);
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
				internal DeviceAdminInfo() /* TypeBuilder.AddDefaultConstructor */ 
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
				/// getReceiverName
				/// </java-name>
				public string ReceiverName
				{
						[Dot42.DexImport("getReceiverName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getActivityInfo
				/// </java-name>
				public global::Android.Content.Pm.ActivityInfo ActivityInfo
				{
						[Dot42.DexImport("getActivityInfo", "()Landroid/content/pm/ActivityInfo;", AccessFlags = 1)]
						get{ return default(global::Android.Content.Pm.ActivityInfo); }
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
				/// isVisible
				/// </java-name>
				public bool IsVisible
				{
						[Dot42.DexImport("isVisible", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

		}

		/// <java-name>
		/// android/app/admin/DeviceAdminReceiver
		/// </java-name>
		[Dot42.DexImport("android/app/admin/DeviceAdminReceiver", AccessFlags = 33)]
		public partial class DeviceAdminReceiver : global::Android.Content.BroadcastReceiver
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// ACTION_DEVICE_ADMIN_ENABLED
				/// </java-name>
				[Dot42.DexImport("ACTION_DEVICE_ADMIN_ENABLED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_DEVICE_ADMIN_ENABLED = "android.app.action.DEVICE_ADMIN_ENABLED";
				/// <java-name>
				/// ACTION_DEVICE_ADMIN_DISABLE_REQUESTED
				/// </java-name>
				[Dot42.DexImport("ACTION_DEVICE_ADMIN_DISABLE_REQUESTED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_DEVICE_ADMIN_DISABLE_REQUESTED = "android.app.action.DEVICE_ADMIN_DISABLE_REQUESTED";
				/// <java-name>
				/// EXTRA_DISABLE_WARNING
				/// </java-name>
				[Dot42.DexImport("EXTRA_DISABLE_WARNING", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_DISABLE_WARNING = "android.app.extra.DISABLE_WARNING";
				/// <java-name>
				/// ACTION_DEVICE_ADMIN_DISABLED
				/// </java-name>
				[Dot42.DexImport("ACTION_DEVICE_ADMIN_DISABLED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_DEVICE_ADMIN_DISABLED = "android.app.action.DEVICE_ADMIN_DISABLED";
				/// <java-name>
				/// ACTION_PASSWORD_CHANGED
				/// </java-name>
				[Dot42.DexImport("ACTION_PASSWORD_CHANGED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_PASSWORD_CHANGED = "android.app.action.ACTION_PASSWORD_CHANGED";
				/// <java-name>
				/// ACTION_PASSWORD_FAILED
				/// </java-name>
				[Dot42.DexImport("ACTION_PASSWORD_FAILED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_PASSWORD_FAILED = "android.app.action.ACTION_PASSWORD_FAILED";
				/// <java-name>
				/// ACTION_PASSWORD_SUCCEEDED
				/// </java-name>
				[Dot42.DexImport("ACTION_PASSWORD_SUCCEEDED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_PASSWORD_SUCCEEDED = "android.app.action.ACTION_PASSWORD_SUCCEEDED";
				/// <java-name>
				/// ACTION_PASSWORD_EXPIRING
				/// </java-name>
				[Dot42.DexImport("ACTION_PASSWORD_EXPIRING", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_PASSWORD_EXPIRING = "android.app.action.ACTION_PASSWORD_EXPIRING";
				/// <java-name>
				/// DEVICE_ADMIN_META_DATA
				/// </java-name>
				[Dot42.DexImport("DEVICE_ADMIN_META_DATA", "Ljava/lang/String;", AccessFlags = 25)]
				public const string DEVICE_ADMIN_META_DATA = "android.app.device_admin";
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public DeviceAdminReceiver() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getManager
				/// </java-name>
				[Dot42.DexImport("getManager", "(Landroid/content/Context;)Landroid/app/admin/DevicePolicyManager;", AccessFlags = 1)]
				public virtual global::Android.App.Admin.DevicePolicyManager GetManager(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
						return default(global::Android.App.Admin.DevicePolicyManager);
				}

				/// <java-name>
				/// getWho
				/// </java-name>
				[Dot42.DexImport("getWho", "(Landroid/content/Context;)Landroid/content/ComponentName;", AccessFlags = 1)]
				public virtual global::Android.Content.ComponentName GetWho(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.ComponentName);
				}

				/// <java-name>
				/// onEnabled
				/// </java-name>
				[Dot42.DexImport("onEnabled", "(Landroid/content/Context;Landroid/content/Intent;)V", AccessFlags = 1)]
				public virtual void OnEnabled(global::Android.Content.Context context, global::Android.Content.Intent intent) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onDisableRequested
				/// </java-name>
				[Dot42.DexImport("onDisableRequested", "(Landroid/content/Context;Landroid/content/Intent;)Ljava/lang/CharSequence;", AccessFlags = 1)]
				public virtual global::Java.Lang.ICharSequence OnDisableRequested(global::Android.Content.Context context, global::Android.Content.Intent intent) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <java-name>
				/// onDisabled
				/// </java-name>
				[Dot42.DexImport("onDisabled", "(Landroid/content/Context;Landroid/content/Intent;)V", AccessFlags = 1)]
				public virtual void OnDisabled(global::Android.Content.Context context, global::Android.Content.Intent intent) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onPasswordChanged
				/// </java-name>
				[Dot42.DexImport("onPasswordChanged", "(Landroid/content/Context;Landroid/content/Intent;)V", AccessFlags = 1)]
				public virtual void OnPasswordChanged(global::Android.Content.Context context, global::Android.Content.Intent intent) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onPasswordFailed
				/// </java-name>
				[Dot42.DexImport("onPasswordFailed", "(Landroid/content/Context;Landroid/content/Intent;)V", AccessFlags = 1)]
				public virtual void OnPasswordFailed(global::Android.Content.Context context, global::Android.Content.Intent intent) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onPasswordSucceeded
				/// </java-name>
				[Dot42.DexImport("onPasswordSucceeded", "(Landroid/content/Context;Landroid/content/Intent;)V", AccessFlags = 1)]
				public virtual void OnPasswordSucceeded(global::Android.Content.Context context, global::Android.Content.Intent intent) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onPasswordExpiring
				/// </java-name>
				[Dot42.DexImport("onPasswordExpiring", "(Landroid/content/Context;Landroid/content/Intent;)V", AccessFlags = 1)]
				public virtual void OnPasswordExpiring(global::Android.Content.Context context, global::Android.Content.Intent intent) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onReceive
				/// </java-name>
				[Dot42.DexImport("onReceive", "(Landroid/content/Context;Landroid/content/Intent;)V", AccessFlags = 1)]
				public override void OnReceive(global::Android.Content.Context context, global::Android.Content.Intent intent) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// android/app/admin/DevicePolicyManager
		/// </java-name>
		[Dot42.DexImport("android/app/admin/DevicePolicyManager", AccessFlags = 33)]
		public partial class DevicePolicyManager
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// ACTION_ADD_DEVICE_ADMIN
				/// </java-name>
				[Dot42.DexImport("ACTION_ADD_DEVICE_ADMIN", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_ADD_DEVICE_ADMIN = "android.app.action.ADD_DEVICE_ADMIN";
				/// <java-name>
				/// EXTRA_DEVICE_ADMIN
				/// </java-name>
				[Dot42.DexImport("EXTRA_DEVICE_ADMIN", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_DEVICE_ADMIN = "android.app.extra.DEVICE_ADMIN";
				/// <java-name>
				/// EXTRA_ADD_EXPLANATION
				/// </java-name>
				[Dot42.DexImport("EXTRA_ADD_EXPLANATION", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_ADD_EXPLANATION = "android.app.extra.ADD_EXPLANATION";
				/// <java-name>
				/// ACTION_SET_NEW_PASSWORD
				/// </java-name>
				[Dot42.DexImport("ACTION_SET_NEW_PASSWORD", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_SET_NEW_PASSWORD = "android.app.action.SET_NEW_PASSWORD";
				/// <java-name>
				/// PASSWORD_QUALITY_UNSPECIFIED
				/// </java-name>
				[Dot42.DexImport("PASSWORD_QUALITY_UNSPECIFIED", "I", AccessFlags = 25)]
				public const int PASSWORD_QUALITY_UNSPECIFIED = 0;
				/// <java-name>
				/// PASSWORD_QUALITY_BIOMETRIC_WEAK
				/// </java-name>
				[Dot42.DexImport("PASSWORD_QUALITY_BIOMETRIC_WEAK", "I", AccessFlags = 25)]
				public const int PASSWORD_QUALITY_BIOMETRIC_WEAK = 32768;
				/// <java-name>
				/// PASSWORD_QUALITY_SOMETHING
				/// </java-name>
				[Dot42.DexImport("PASSWORD_QUALITY_SOMETHING", "I", AccessFlags = 25)]
				public const int PASSWORD_QUALITY_SOMETHING = 65536;
				/// <java-name>
				/// PASSWORD_QUALITY_NUMERIC
				/// </java-name>
				[Dot42.DexImport("PASSWORD_QUALITY_NUMERIC", "I", AccessFlags = 25)]
				public const int PASSWORD_QUALITY_NUMERIC = 131072;
				/// <java-name>
				/// PASSWORD_QUALITY_ALPHABETIC
				/// </java-name>
				[Dot42.DexImport("PASSWORD_QUALITY_ALPHABETIC", "I", AccessFlags = 25)]
				public const int PASSWORD_QUALITY_ALPHABETIC = 262144;
				/// <java-name>
				/// PASSWORD_QUALITY_ALPHANUMERIC
				/// </java-name>
				[Dot42.DexImport("PASSWORD_QUALITY_ALPHANUMERIC", "I", AccessFlags = 25)]
				public const int PASSWORD_QUALITY_ALPHANUMERIC = 327680;
				/// <java-name>
				/// PASSWORD_QUALITY_COMPLEX
				/// </java-name>
				[Dot42.DexImport("PASSWORD_QUALITY_COMPLEX", "I", AccessFlags = 25)]
				public const int PASSWORD_QUALITY_COMPLEX = 393216;
				/// <java-name>
				/// RESET_PASSWORD_REQUIRE_ENTRY
				/// </java-name>
				[Dot42.DexImport("RESET_PASSWORD_REQUIRE_ENTRY", "I", AccessFlags = 25)]
				public const int RESET_PASSWORD_REQUIRE_ENTRY = 1;
				/// <java-name>
				/// WIPE_EXTERNAL_STORAGE
				/// </java-name>
				[Dot42.DexImport("WIPE_EXTERNAL_STORAGE", "I", AccessFlags = 25)]
				public const int WIPE_EXTERNAL_STORAGE = 1;
				/// <java-name>
				/// ENCRYPTION_STATUS_UNSUPPORTED
				/// </java-name>
				[Dot42.DexImport("ENCRYPTION_STATUS_UNSUPPORTED", "I", AccessFlags = 25)]
				public const int ENCRYPTION_STATUS_UNSUPPORTED = 0;
				/// <java-name>
				/// ENCRYPTION_STATUS_INACTIVE
				/// </java-name>
				[Dot42.DexImport("ENCRYPTION_STATUS_INACTIVE", "I", AccessFlags = 25)]
				public const int ENCRYPTION_STATUS_INACTIVE = 1;
				/// <java-name>
				/// ENCRYPTION_STATUS_ACTIVATING
				/// </java-name>
				[Dot42.DexImport("ENCRYPTION_STATUS_ACTIVATING", "I", AccessFlags = 25)]
				public const int ENCRYPTION_STATUS_ACTIVATING = 2;
				/// <java-name>
				/// ENCRYPTION_STATUS_ACTIVE
				/// </java-name>
				[Dot42.DexImport("ENCRYPTION_STATUS_ACTIVE", "I", AccessFlags = 25)]
				public const int ENCRYPTION_STATUS_ACTIVE = 3;
				/// <java-name>
				/// ACTION_START_ENCRYPTION
				/// </java-name>
				[Dot42.DexImport("ACTION_START_ENCRYPTION", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_START_ENCRYPTION = "android.app.action.START_ENCRYPTION";
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal DevicePolicyManager() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isAdminActive
				/// </java-name>
				[Dot42.DexImport("isAdminActive", "(Landroid/content/ComponentName;)Z", AccessFlags = 1)]
				public virtual bool IsAdminActive(global::Android.Content.ComponentName componentName) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// removeActiveAdmin
				/// </java-name>
				[Dot42.DexImport("removeActiveAdmin", "(Landroid/content/ComponentName;)V", AccessFlags = 1)]
				public virtual void RemoveActiveAdmin(global::Android.Content.ComponentName componentName) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// hasGrantedPolicy
				/// </java-name>
				[Dot42.DexImport("hasGrantedPolicy", "(Landroid/content/ComponentName;I)Z", AccessFlags = 1)]
				public virtual bool HasGrantedPolicy(global::Android.Content.ComponentName componentName, int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setPasswordQuality
				/// </java-name>
				[Dot42.DexImport("setPasswordQuality", "(Landroid/content/ComponentName;I)V", AccessFlags = 1)]
				public virtual void SetPasswordQuality(global::Android.Content.ComponentName componentName, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getPasswordQuality
				/// </java-name>
				[Dot42.DexImport("getPasswordQuality", "(Landroid/content/ComponentName;)I", AccessFlags = 1)]
				public virtual int GetPasswordQuality(global::Android.Content.ComponentName componentName) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// setPasswordMinimumLength
				/// </java-name>
				[Dot42.DexImport("setPasswordMinimumLength", "(Landroid/content/ComponentName;I)V", AccessFlags = 1)]
				public virtual void SetPasswordMinimumLength(global::Android.Content.ComponentName componentName, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getPasswordMinimumLength
				/// </java-name>
				[Dot42.DexImport("getPasswordMinimumLength", "(Landroid/content/ComponentName;)I", AccessFlags = 1)]
				public virtual int GetPasswordMinimumLength(global::Android.Content.ComponentName componentName) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// setPasswordMinimumUpperCase
				/// </java-name>
				[Dot42.DexImport("setPasswordMinimumUpperCase", "(Landroid/content/ComponentName;I)V", AccessFlags = 1)]
				public virtual void SetPasswordMinimumUpperCase(global::Android.Content.ComponentName componentName, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getPasswordMinimumUpperCase
				/// </java-name>
				[Dot42.DexImport("getPasswordMinimumUpperCase", "(Landroid/content/ComponentName;)I", AccessFlags = 1)]
				public virtual int GetPasswordMinimumUpperCase(global::Android.Content.ComponentName componentName) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// setPasswordMinimumLowerCase
				/// </java-name>
				[Dot42.DexImport("setPasswordMinimumLowerCase", "(Landroid/content/ComponentName;I)V", AccessFlags = 1)]
				public virtual void SetPasswordMinimumLowerCase(global::Android.Content.ComponentName componentName, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getPasswordMinimumLowerCase
				/// </java-name>
				[Dot42.DexImport("getPasswordMinimumLowerCase", "(Landroid/content/ComponentName;)I", AccessFlags = 1)]
				public virtual int GetPasswordMinimumLowerCase(global::Android.Content.ComponentName componentName) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// setPasswordMinimumLetters
				/// </java-name>
				[Dot42.DexImport("setPasswordMinimumLetters", "(Landroid/content/ComponentName;I)V", AccessFlags = 1)]
				public virtual void SetPasswordMinimumLetters(global::Android.Content.ComponentName componentName, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getPasswordMinimumLetters
				/// </java-name>
				[Dot42.DexImport("getPasswordMinimumLetters", "(Landroid/content/ComponentName;)I", AccessFlags = 1)]
				public virtual int GetPasswordMinimumLetters(global::Android.Content.ComponentName componentName) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// setPasswordMinimumNumeric
				/// </java-name>
				[Dot42.DexImport("setPasswordMinimumNumeric", "(Landroid/content/ComponentName;I)V", AccessFlags = 1)]
				public virtual void SetPasswordMinimumNumeric(global::Android.Content.ComponentName componentName, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getPasswordMinimumNumeric
				/// </java-name>
				[Dot42.DexImport("getPasswordMinimumNumeric", "(Landroid/content/ComponentName;)I", AccessFlags = 1)]
				public virtual int GetPasswordMinimumNumeric(global::Android.Content.ComponentName componentName) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// setPasswordMinimumSymbols
				/// </java-name>
				[Dot42.DexImport("setPasswordMinimumSymbols", "(Landroid/content/ComponentName;I)V", AccessFlags = 1)]
				public virtual void SetPasswordMinimumSymbols(global::Android.Content.ComponentName componentName, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getPasswordMinimumSymbols
				/// </java-name>
				[Dot42.DexImport("getPasswordMinimumSymbols", "(Landroid/content/ComponentName;)I", AccessFlags = 1)]
				public virtual int GetPasswordMinimumSymbols(global::Android.Content.ComponentName componentName) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// setPasswordMinimumNonLetter
				/// </java-name>
				[Dot42.DexImport("setPasswordMinimumNonLetter", "(Landroid/content/ComponentName;I)V", AccessFlags = 1)]
				public virtual void SetPasswordMinimumNonLetter(global::Android.Content.ComponentName componentName, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getPasswordMinimumNonLetter
				/// </java-name>
				[Dot42.DexImport("getPasswordMinimumNonLetter", "(Landroid/content/ComponentName;)I", AccessFlags = 1)]
				public virtual int GetPasswordMinimumNonLetter(global::Android.Content.ComponentName componentName) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// setPasswordHistoryLength
				/// </java-name>
				[Dot42.DexImport("setPasswordHistoryLength", "(Landroid/content/ComponentName;I)V", AccessFlags = 1)]
				public virtual void SetPasswordHistoryLength(global::Android.Content.ComponentName componentName, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setPasswordExpirationTimeout
				/// </java-name>
				[Dot42.DexImport("setPasswordExpirationTimeout", "(Landroid/content/ComponentName;J)V", AccessFlags = 1)]
				public virtual void SetPasswordExpirationTimeout(global::Android.Content.ComponentName componentName, long int64) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getPasswordExpirationTimeout
				/// </java-name>
				[Dot42.DexImport("getPasswordExpirationTimeout", "(Landroid/content/ComponentName;)J", AccessFlags = 1)]
				public virtual long GetPasswordExpirationTimeout(global::Android.Content.ComponentName componentName) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// getPasswordExpiration
				/// </java-name>
				[Dot42.DexImport("getPasswordExpiration", "(Landroid/content/ComponentName;)J", AccessFlags = 1)]
				public virtual long GetPasswordExpiration(global::Android.Content.ComponentName componentName) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// getPasswordHistoryLength
				/// </java-name>
				[Dot42.DexImport("getPasswordHistoryLength", "(Landroid/content/ComponentName;)I", AccessFlags = 1)]
				public virtual int GetPasswordHistoryLength(global::Android.Content.ComponentName componentName) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getPasswordMaximumLength
				/// </java-name>
				[Dot42.DexImport("getPasswordMaximumLength", "(I)I", AccessFlags = 1)]
				public virtual int GetPasswordMaximumLength(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// setMaximumFailedPasswordsForWipe
				/// </java-name>
				[Dot42.DexImport("setMaximumFailedPasswordsForWipe", "(Landroid/content/ComponentName;I)V", AccessFlags = 1)]
				public virtual void SetMaximumFailedPasswordsForWipe(global::Android.Content.ComponentName componentName, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getMaximumFailedPasswordsForWipe
				/// </java-name>
				[Dot42.DexImport("getMaximumFailedPasswordsForWipe", "(Landroid/content/ComponentName;)I", AccessFlags = 1)]
				public virtual int GetMaximumFailedPasswordsForWipe(global::Android.Content.ComponentName componentName) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// resetPassword
				/// </java-name>
				[Dot42.DexImport("resetPassword", "(Ljava/lang/String;I)Z", AccessFlags = 1)]
				public virtual bool ResetPassword(string @string, int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setMaximumTimeToLock
				/// </java-name>
				[Dot42.DexImport("setMaximumTimeToLock", "(Landroid/content/ComponentName;J)V", AccessFlags = 1)]
				public virtual void SetMaximumTimeToLock(global::Android.Content.ComponentName componentName, long int64) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getMaximumTimeToLock
				/// </java-name>
				[Dot42.DexImport("getMaximumTimeToLock", "(Landroid/content/ComponentName;)J", AccessFlags = 1)]
				public virtual long GetMaximumTimeToLock(global::Android.Content.ComponentName componentName) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// lockNow
				/// </java-name>
				[Dot42.DexImport("lockNow", "()V", AccessFlags = 1)]
				public virtual void LockNow() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// wipeData
				/// </java-name>
				[Dot42.DexImport("wipeData", "(I)V", AccessFlags = 1)]
				public virtual void WipeData(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setStorageEncryption
				/// </java-name>
				[Dot42.DexImport("setStorageEncryption", "(Landroid/content/ComponentName;Z)I", AccessFlags = 1)]
				public virtual int SetStorageEncryption(global::Android.Content.ComponentName componentName, bool boolean) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getStorageEncryption
				/// </java-name>
				[Dot42.DexImport("getStorageEncryption", "(Landroid/content/ComponentName;)Z", AccessFlags = 1)]
				public virtual bool GetStorageEncryption(global::Android.Content.ComponentName componentName) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setCameraDisabled
				/// </java-name>
				[Dot42.DexImport("setCameraDisabled", "(Landroid/content/ComponentName;Z)V", AccessFlags = 1)]
				public virtual void SetCameraDisabled(global::Android.Content.ComponentName componentName, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getCameraDisabled
				/// </java-name>
				[Dot42.DexImport("getCameraDisabled", "(Landroid/content/ComponentName;)Z", AccessFlags = 1)]
				public virtual bool GetCameraDisabled(global::Android.Content.ComponentName componentName) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getActiveAdmins
				/// </java-name>
				public virtual global::Java.Util.IList<global::Android.Content.ComponentName> ActiveAdmins
				{
						[Dot42.DexImport("getActiveAdmins", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Landroid/content/ComponentName;>;")]
						get{ return default(global::Java.Util.IList<global::Android.Content.ComponentName>); }
				}

				/// <java-name>
				/// isActivePasswordSufficient
				/// </java-name>
				public virtual bool IsActivePasswordSufficient
				{
						[Dot42.DexImport("isActivePasswordSufficient", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// getCurrentFailedPasswordAttempts
				/// </java-name>
				public virtual int CurrentFailedPasswordAttempts
				{
						[Dot42.DexImport("getCurrentFailedPasswordAttempts", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getStorageEncryptionStatus
				/// </java-name>
				public virtual int StorageEncryptionStatus
				{
						[Dot42.DexImport("getStorageEncryptionStatus", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

		}

}

