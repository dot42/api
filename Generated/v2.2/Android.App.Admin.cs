#pragma warning disable 1717
namespace Android.App.Admin
{
		/// <summary>
		///  <para>This class is used to specify meta information of a device administrator component. </para>    
		/// </summary>
		/// <java-name>
		/// android/app/admin/DeviceAdminInfo
		/// </java-name>
		[Dot42.DexImport("android/app/admin/DeviceAdminInfo", AccessFlags = 49)]
		public sealed partial class DeviceAdminInfo : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>A type of policy that this device admin can use: limit the passwords that the user can select, via DevicePolicyManager#setPasswordQuality and DevicePolicyManager#setPasswordMinimumLength.</para> <para>To control this policy, the device admin must have a "limit-password" tag in the "uses-policies" section of its meta-data. </para>        
				/// </summary>
				/// <java-name>
				/// USES_POLICY_LIMIT_PASSWORD
				/// </java-name>
				[Dot42.DexImport("USES_POLICY_LIMIT_PASSWORD", "I", AccessFlags = 25)]
				public const int USES_POLICY_LIMIT_PASSWORD = 0;
				/// <summary>
				///  <para>A type of policy that this device admin can use: able to watch login attempts from the user, via DeviceAdminReceiver#ACTION_PASSWORD_FAILED, DeviceAdminReceiver#ACTION_PASSWORD_SUCCEEDED, and DevicePolicyManager#getCurrentFailedPasswordAttempts.</para> <para>To control this policy, the device admin must have a "watch-login" tag in the "uses-policies" section of its meta-data. </para>        
				/// </summary>
				/// <java-name>
				/// USES_POLICY_WATCH_LOGIN
				/// </java-name>
				[Dot42.DexImport("USES_POLICY_WATCH_LOGIN", "I", AccessFlags = 25)]
				public const int USES_POLICY_WATCH_LOGIN = 1;
				/// <summary>
				///  <para>A type of policy that this device admin can use: able to reset the user's password via DevicePolicyManager#resetPassword.</para> <para>To control this policy, the device admin must have a "reset-password" tag in the "uses-policies" section of its meta-data. </para>        
				/// </summary>
				/// <java-name>
				/// USES_POLICY_RESET_PASSWORD
				/// </java-name>
				[Dot42.DexImport("USES_POLICY_RESET_PASSWORD", "I", AccessFlags = 25)]
				public const int USES_POLICY_RESET_PASSWORD = 2;
				/// <summary>
				///  <para>A type of policy that this device admin can use: able to force the device to lock viaDevicePolicyManager#lockNow or limit the maximum lock timeout for the device via DevicePolicyManager#setMaximumTimeToLock.</para> <para>To control this policy, the device admin must have a "force-lock" tag in the "uses-policies" section of its meta-data. </para>        
				/// </summary>
				/// <java-name>
				/// USES_POLICY_FORCE_LOCK
				/// </java-name>
				[Dot42.DexImport("USES_POLICY_FORCE_LOCK", "I", AccessFlags = 25)]
				public const int USES_POLICY_FORCE_LOCK = 3;
				/// <summary>
				///  <para>A type of policy that this device admin can use: able to factory reset the device, erasing all of the user's data, via DevicePolicyManager#wipeData.</para> <para>To control this policy, the device admin must have a "wipe-data" tag in the "uses-policies" section of its meta-data. </para>        
				/// </summary>
				/// <java-name>
				/// USES_POLICY_WIPE_DATA
				/// </java-name>
				[Dot42.DexImport("USES_POLICY_WIPE_DATA", "I", AccessFlags = 25)]
				public const int USES_POLICY_WIPE_DATA = 4;
				/// <summary>
				///  <para>Used to make this class parcelable. </para>        
				/// </summary>
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.App.Admin.DeviceAdminInfo> CREATOR;
				/// <summary>
				///  <para>Constructor.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/content/pm/ResolveInfo;)V", AccessFlags = 1)]
				public DeviceAdminInfo(global::Android.Content.Context context, global::Android.Content.PM.ResolveInfo receiver) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Load the user-displayed label for this device admin.</para> <para></para>        
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
				///  <para>Load user-visible description associated with this device admin.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// loadDescription
				/// </java-name>
				[Dot42.DexImport("loadDescription", "(Landroid/content/pm/PackageManager;)Ljava/lang/CharSequence;", AccessFlags = 1)]
				public global::Java.Lang.ICharSequence LoadDescription(global::Android.Content.PM.PackageManager pm) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <summary>
				///  <para>Load the user-displayed icon for this device admin.</para> <para></para>        
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
				///  <para>Return true if the device admin has requested that it be able to use the given policy control. The possible policy identifier inputs are: USES_POLICY_LIMIT_PASSWORD, USES_POLICY_WATCH_LOGIN, USES_POLICY_RESET_PASSWORD, USES_POLICY_FORCE_LOCK, USES_POLICY_WIPE_DATA, USES_POLICY_EXPIRE_PASSWORD, USES_ENCRYPTED_STORAGE, USES_POLICY_DISABLE_CAMERA. </para>        
				/// </summary>
				/// <java-name>
				/// usesPolicy
				/// </java-name>
				[Dot42.DexImport("usesPolicy", "(I)Z", AccessFlags = 1)]
				public bool UsesPolicy(int policyIdent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Return the XML tag name for the given policy identifier. Valid identifiers are as per usesPolicy(int). If the given identifier is not known, null is returned. </para>        
				/// </summary>
				/// <java-name>
				/// getTagForPolicy
				/// </java-name>
				[Dot42.DexImport("getTagForPolicy", "(I)Ljava/lang/String;", AccessFlags = 1)]
				public string GetTagForPolicy(int policyIdent) /* MethodBuilder.Create */ 
				{
						return default(string);
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
				internal DeviceAdminInfo() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Return the .apk package that implements this device admin. </para>        
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
				///  <para>Return the class name of the receiver component that implements this device admin. </para>        
				/// </summary>
				/// <java-name>
				/// getReceiverName
				/// </java-name>
				public string ReceiverName
				{
						[Dot42.DexImport("getReceiverName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>Return the raw information about the receiver implementing this device admin. Do not modify the returned object. </para>        
				/// </summary>
				/// <java-name>
				/// getActivityInfo
				/// </java-name>
				public global::Android.Content.PM.ActivityInfo ActivityInfo
				{
						[Dot42.DexImport("getActivityInfo", "()Landroid/content/pm/ActivityInfo;", AccessFlags = 1)]
						get{ return default(global::Android.Content.PM.ActivityInfo); }
				}

				/// <summary>
				///  <para>Return the component of the receiver that implements this device admin. </para>        
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
				///  <para>Returns whether this device admin would like to be visible to the user, even when it is not enabled. </para>        
				/// </summary>
				/// <java-name>
				/// isVisible
				/// </java-name>
				public bool IsVisible
				{
						[Dot42.DexImport("isVisible", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

		}

		/// <summary>
		///  <para>Base class for implementing a device administration component. This class provides a convenience for interpreting the raw intent actions that are sent by the system.</para> <para>The callback methods, like the base BroadcastReceiver.onReceive() method, happen on the main thread of the process. Thus long running operations must be done on another thread. Note that because a receiver is done once returning from its receive function, such long-running operations should probably be done in a Service.</para> <para>When publishing your DeviceAdmin subclass as a receiver, it must handle ACTION_DEVICE_ADMIN_ENABLED and require the android.Manifest.permission#BIND_DEVICE_ADMIN permission. A typical manifest entry would look like:</para> <para>{ development/samples/ApiDemos/AndroidManifest.xml device_admin_declaration}</para> <para>The meta-data referenced here provides addition information specific to the device administrator, as parsed by the DeviceAdminInfo class. A typical file would be:</para> <para>{ development/samples/ApiDemos/res/xml/device_admin_sample.xml meta_data}</para> <para>  <h3>Developer Guides</h3></para> <para> </para> <para>For more information about device administration, read the  developer guide.</para> <para>  </para>    
		/// </summary>
		/// <java-name>
		/// android/app/admin/DeviceAdminReceiver
		/// </java-name>
		[Dot42.DexImport("android/app/admin/DeviceAdminReceiver", AccessFlags = 33)]
		public partial class DeviceAdminReceiver : global::Android.Content.BroadcastReceiver
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>This is the primary action that a device administrator must implement to be allowed to manage a device. This will be set to the receiver when the user enables it for administration. You will generally handle this in DeviceAdminReceiver#onEnabled(Context, Intent). To be supported, the receiver must also require the android.Manifest.permission#BIND_DEVICE_ADMIN permission so that other applications can not abuse it. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_DEVICE_ADMIN_ENABLED
				/// </java-name>
				[Dot42.DexImport("ACTION_DEVICE_ADMIN_ENABLED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_DEVICE_ADMIN_ENABLED = "android.app.action.DEVICE_ADMIN_ENABLED";
				/// <summary>
				///  <para>Action sent to a device administrator when the user has requested to disable it, but before this has actually been done. This gives you a chance to supply a message to the user about the impact of disabling your admin, by setting the extra field EXTRA_DISABLE_WARNING in the result Intent. If not set, no warning will be displayed. If set, the given text will be shown to the user before they disable your admin. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_DEVICE_ADMIN_DISABLE_REQUESTED
				/// </java-name>
				[Dot42.DexImport("ACTION_DEVICE_ADMIN_DISABLE_REQUESTED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_DEVICE_ADMIN_DISABLE_REQUESTED = "android.app.action.DEVICE_ADMIN_DISABLE_REQUESTED";
				/// <summary>
				///  <para>A CharSequence that can be shown to the user informing them of the impact of disabling your admin.</para> <para> <para>ACTION_DEVICE_ADMIN_DISABLE_REQUESTED </para></para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_DISABLE_WARNING
				/// </java-name>
				[Dot42.DexImport("EXTRA_DISABLE_WARNING", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_DISABLE_WARNING = "android.app.extra.DISABLE_WARNING";
				/// <summary>
				///  <para>Action sent to a device administrator when the user has disabled it. Upon return, the application no longer has access to the protected device policy manager APIs. You will generally handle this in DeviceAdminReceiver#onDisabled(Context, Intent). Note that this action will be sent the receiver regardless of whether it is explicitly listed in its intent filter. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_DEVICE_ADMIN_DISABLED
				/// </java-name>
				[Dot42.DexImport("ACTION_DEVICE_ADMIN_DISABLED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_DEVICE_ADMIN_DISABLED = "android.app.action.DEVICE_ADMIN_DISABLED";
				/// <summary>
				///  <para>Action sent to a device administrator when the user has changed the password of their device. You can at this point check the characteristics of the new password with DevicePolicyManager.isActivePasswordSufficient(). You will generally handle this in DeviceAdminReceiver#onPasswordChanged.</para> <para>The calling device admin must have requested DeviceAdminInfo#USES_POLICY_LIMIT_PASSWORD to receive this broadcast. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_PASSWORD_CHANGED
				/// </java-name>
				[Dot42.DexImport("ACTION_PASSWORD_CHANGED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_PASSWORD_CHANGED = "android.app.action.ACTION_PASSWORD_CHANGED";
				/// <summary>
				///  <para>Action sent to a device administrator when the user has failed at attempted to enter the password. You can at this point check the number of failed password attempts there have been with DevicePolicyManager.getCurrentFailedPasswordAttempts(). You will generally handle this in DeviceAdminReceiver#onPasswordFailed.</para> <para>The calling device admin must have requested DeviceAdminInfo#USES_POLICY_WATCH_LOGIN to receive this broadcast. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_PASSWORD_FAILED
				/// </java-name>
				[Dot42.DexImport("ACTION_PASSWORD_FAILED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_PASSWORD_FAILED = "android.app.action.ACTION_PASSWORD_FAILED";
				/// <summary>
				///  <para>Action sent to a device administrator when the user has successfully entered their password, after failing one or more times.</para> <para>The calling device admin must have requested DeviceAdminInfo#USES_POLICY_WATCH_LOGIN to receive this broadcast. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_PASSWORD_SUCCEEDED
				/// </java-name>
				[Dot42.DexImport("ACTION_PASSWORD_SUCCEEDED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_PASSWORD_SUCCEEDED = "android.app.action.ACTION_PASSWORD_SUCCEEDED";
				/// <summary>
				///  <para>Name under which a DevicePolicy component publishes information about itself. This meta-data must reference an XML resource containing a device-admin tag. XXX TO DO: describe syntax. </para>        
				/// </summary>
				/// <java-name>
				/// DEVICE_ADMIN_META_DATA
				/// </java-name>
				[Dot42.DexImport("DEVICE_ADMIN_META_DATA", "Ljava/lang/String;", AccessFlags = 25)]
				public const string DEVICE_ADMIN_META_DATA = "android.app.device_admin";
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public DeviceAdminReceiver() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Retrieve the DevicePolicyManager interface for this administrator to work with the system. </para>        
				/// </summary>
				/// <java-name>
				/// getManager
				/// </java-name>
				[Dot42.DexImport("getManager", "(Landroid/content/Context;)Landroid/app/admin/DevicePolicyManager;", AccessFlags = 1)]
				public virtual global::Android.App.Admin.DevicePolicyManager GetManager(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
						return default(global::Android.App.Admin.DevicePolicyManager);
				}

				/// <summary>
				///  <para>Retrieve the ComponentName describing who this device administrator is, for use in DevicePolicyManager APIs that require the administrator to identify itself. </para>        
				/// </summary>
				/// <java-name>
				/// getWho
				/// </java-name>
				[Dot42.DexImport("getWho", "(Landroid/content/Context;)Landroid/content/ComponentName;", AccessFlags = 1)]
				public virtual global::Android.Content.ComponentName GetWho(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.ComponentName);
				}

				/// <summary>
				///  <para>Called after the administrator is first enabled, as a result of receiving ACTION_DEVICE_ADMIN_ENABLED. At this point you can use DevicePolicyManager to set your desired policies. </para>        
				/// </summary>
				/// <java-name>
				/// onEnabled
				/// </java-name>
				[Dot42.DexImport("onEnabled", "(Landroid/content/Context;Landroid/content/Intent;)V", AccessFlags = 1)]
				public virtual void OnEnabled(global::Android.Content.Context context, global::Android.Content.Intent intent) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Called when the user has asked to disable the administrator, as a result of receiving ACTION_DEVICE_ADMIN_DISABLE_REQUESTED, giving you a chance to present a warning message to them. The message is returned as the result; if null is returned (the default implementation), no message will be displayed. </para>        
				/// </summary>
				/// <returns>
				///  <para>Return the warning message to display to the user before being disabled; if null is returned, no message is displayed. </para>
				/// </returns>
				/// <java-name>
				/// onDisableRequested
				/// </java-name>
				[Dot42.DexImport("onDisableRequested", "(Landroid/content/Context;Landroid/content/Intent;)Ljava/lang/CharSequence;", AccessFlags = 1)]
				public virtual global::Java.Lang.ICharSequence OnDisableRequested(global::Android.Content.Context context, global::Android.Content.Intent intent) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <summary>
				///  <para>Called prior to the administrator being disabled, as a result of receiving ACTION_DEVICE_ADMIN_DISABLED. Upon return, you can no longer use the protected parts of the DevicePolicyManager API. </para>        
				/// </summary>
				/// <java-name>
				/// onDisabled
				/// </java-name>
				[Dot42.DexImport("onDisabled", "(Landroid/content/Context;Landroid/content/Intent;)V", AccessFlags = 1)]
				public virtual void OnDisabled(global::Android.Content.Context context, global::Android.Content.Intent intent) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Called after the user has changed their password, as a result of receiving ACTION_PASSWORD_CHANGED. At this point you can use DevicePolicyManager.getCurrentFailedPasswordAttempts() to retrieve the active password characteristics. </para>        
				/// </summary>
				/// <java-name>
				/// onPasswordChanged
				/// </java-name>
				[Dot42.DexImport("onPasswordChanged", "(Landroid/content/Context;Landroid/content/Intent;)V", AccessFlags = 1)]
				public virtual void OnPasswordChanged(global::Android.Content.Context context, global::Android.Content.Intent intent) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Called after the user has failed at entering their current password, as a result of receiving ACTION_PASSWORD_FAILED. At this point you can use DevicePolicyManager to retrieve the number of failed password attempts. </para>        
				/// </summary>
				/// <java-name>
				/// onPasswordFailed
				/// </java-name>
				[Dot42.DexImport("onPasswordFailed", "(Landroid/content/Context;Landroid/content/Intent;)V", AccessFlags = 1)]
				public virtual void OnPasswordFailed(global::Android.Content.Context context, global::Android.Content.Intent intent) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Called after the user has succeeded at entering their current password, as a result of receiving ACTION_PASSWORD_SUCCEEDED. This will only be received the first time they succeed after having previously failed. </para>        
				/// </summary>
				/// <java-name>
				/// onPasswordSucceeded
				/// </java-name>
				[Dot42.DexImport("onPasswordSucceeded", "(Landroid/content/Context;Landroid/content/Intent;)V", AccessFlags = 1)]
				public virtual void OnPasswordSucceeded(global::Android.Content.Context context, global::Android.Content.Intent intent) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Intercept standard device administrator broadcasts. Implementations should not override this method; it is better to implement the convenience callbacks for each action. </para>        
				/// </summary>
				/// <java-name>
				/// onReceive
				/// </java-name>
				[Dot42.DexImport("onReceive", "(Landroid/content/Context;Landroid/content/Intent;)V", AccessFlags = 1)]
				public override void OnReceive(global::Android.Content.Context context, global::Android.Content.Intent intent) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>Public interface for managing policies enforced on a device. Most clients of this class must have published a DeviceAdminReceiver that the user has currently enabled.</para> <para>  <h3>Developer Guides</h3></para> <para> </para> <para>For more information about managing policies for device adminstration, read the  developer guide.</para> <para>  </para>    
		/// </summary>
		/// <java-name>
		/// android/app/admin/DevicePolicyManager
		/// </java-name>
		[Dot42.DexImport("android/app/admin/DevicePolicyManager", AccessFlags = 33)]
		public partial class DevicePolicyManager
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Activity action: ask the user to add a new device administrator to the system. The desired policy is the ComponentName of the policy in the EXTRA_DEVICE_ADMIN extra field. This will invoke a UI to bring the user through adding the device administrator to the system (or allowing them to reject it).</para> <para>You can optionally include the EXTRA_ADD_EXPLANATION field to provide the user with additional explanation (in addition to your component's description) about what is being added.</para> <para>If your administrator is already active, this will ordinarily return immediately (without user intervention). However, if your administrator has been updated and is requesting additional uses-policy flags, the user will be presented with the new list. New policies will not be available to the updated administrator until the user has accepted the new list. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_ADD_DEVICE_ADMIN
				/// </java-name>
				[Dot42.DexImport("ACTION_ADD_DEVICE_ADMIN", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_ADD_DEVICE_ADMIN = "android.app.action.ADD_DEVICE_ADMIN";
				/// <summary>
				///  <para>The ComponentName of the administrator component.</para> <para> <para>ACTION_ADD_DEVICE_ADMIN </para></para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_DEVICE_ADMIN
				/// </java-name>
				[Dot42.DexImport("EXTRA_DEVICE_ADMIN", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_DEVICE_ADMIN = "android.app.extra.DEVICE_ADMIN";
				/// <summary>
				///  <para>An optional CharSequence providing additional explanation for why the admin is being added.</para> <para> <para>ACTION_ADD_DEVICE_ADMIN </para></para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_ADD_EXPLANATION
				/// </java-name>
				[Dot42.DexImport("EXTRA_ADD_EXPLANATION", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_ADD_EXPLANATION = "android.app.extra.ADD_EXPLANATION";
				/// <summary>
				///  <para>Activity action: have the user enter a new password. This activity should be launched after using setPasswordQuality(ComponentName, int), or setPasswordMinimumLength(ComponentName, int) to have the user enter a new password that meets the current requirements. You can use isActivePasswordSufficient() to determine whether you need to have the user select a new password in order to meet the current constraints. Upon being resumed from this activity, you can check the new password characteristics to see if they are sufficient. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_SET_NEW_PASSWORD
				/// </java-name>
				[Dot42.DexImport("ACTION_SET_NEW_PASSWORD", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_SET_NEW_PASSWORD = "android.app.action.SET_NEW_PASSWORD";
				/// <summary>
				///  <para>Constant for setPasswordQuality: the policy has no requirements for the password. Note that quality constants are ordered so that higher values are more restrictive. </para>        
				/// </summary>
				/// <java-name>
				/// PASSWORD_QUALITY_UNSPECIFIED
				/// </java-name>
				[Dot42.DexImport("PASSWORD_QUALITY_UNSPECIFIED", "I", AccessFlags = 25)]
				public const int PASSWORD_QUALITY_UNSPECIFIED = 0;
				/// <summary>
				///  <para>Constant for setPasswordQuality: the policy requires some kind of password, but doesn't care what it is. Note that quality constants are ordered so that higher values are more restrictive. </para>        
				/// </summary>
				/// <java-name>
				/// PASSWORD_QUALITY_SOMETHING
				/// </java-name>
				[Dot42.DexImport("PASSWORD_QUALITY_SOMETHING", "I", AccessFlags = 25)]
				public const int PASSWORD_QUALITY_SOMETHING = 65536;
				/// <summary>
				///  <para>Constant for setPasswordQuality: the user must have entered a password containing at least numeric characters. Note that quality constants are ordered so that higher values are more restrictive. </para>        
				/// </summary>
				/// <java-name>
				/// PASSWORD_QUALITY_NUMERIC
				/// </java-name>
				[Dot42.DexImport("PASSWORD_QUALITY_NUMERIC", "I", AccessFlags = 25)]
				public const int PASSWORD_QUALITY_NUMERIC = 131072;
				/// <summary>
				///  <para>Constant for setPasswordQuality: the user must have entered a password containing at least alphabetic (or other symbol) characters. Note that quality constants are ordered so that higher values are more restrictive. </para>        
				/// </summary>
				/// <java-name>
				/// PASSWORD_QUALITY_ALPHABETIC
				/// </java-name>
				[Dot42.DexImport("PASSWORD_QUALITY_ALPHABETIC", "I", AccessFlags = 25)]
				public const int PASSWORD_QUALITY_ALPHABETIC = 262144;
				/// <summary>
				///  <para>Constant for setPasswordQuality: the user must have entered a password containing at least  <b>both&gt;</b> numeric  <b>and</b> alphabetic (or other symbol) characters. Note that quality constants are ordered so that higher values are more restrictive. </para>        
				/// </summary>
				/// <java-name>
				/// PASSWORD_QUALITY_ALPHANUMERIC
				/// </java-name>
				[Dot42.DexImport("PASSWORD_QUALITY_ALPHANUMERIC", "I", AccessFlags = 25)]
				public const int PASSWORD_QUALITY_ALPHANUMERIC = 327680;
				/// <summary>
				///  <para>Flag for resetPassword: don't allow other admins to change the password again until the user has entered it. </para>        
				/// </summary>
				/// <java-name>
				/// RESET_PASSWORD_REQUIRE_ENTRY
				/// </java-name>
				[Dot42.DexImport("RESET_PASSWORD_REQUIRE_ENTRY", "I", AccessFlags = 25)]
				public const int RESET_PASSWORD_REQUIRE_ENTRY = 1;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal DevicePolicyManager() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Return true if the given administrator component is currently active (enabled) in the system. </para>        
				/// </summary>
				/// <java-name>
				/// isAdminActive
				/// </java-name>
				[Dot42.DexImport("isAdminActive", "(Landroid/content/ComponentName;)Z", AccessFlags = 1)]
				public virtual bool IsAdminActive(global::Android.Content.ComponentName who) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Remove a current administration component. This can only be called by the application that owns the administration component; if you try to remove someone else's component, a security exception will be thrown. </para>        
				/// </summary>
				/// <java-name>
				/// removeActiveAdmin
				/// </java-name>
				[Dot42.DexImport("removeActiveAdmin", "(Landroid/content/ComponentName;)V", AccessFlags = 1)]
				public virtual void RemoveActiveAdmin(global::Android.Content.ComponentName who) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Called by an application that is administering the device to set the password restrictions it is imposing. After setting this, the user will not be able to enter a new password that is not at least as restrictive as what has been set. Note that the current password will remain until the user has set a new one, so the change does not take place immediately. To prompt the user for a new password, use ACTION_SET_NEW_PASSWORD after setting this value.</para> <para>Quality constants are ordered so that higher values are more restrictive; thus the highest requested quality constant (between the policy set here, the user's preference, and any other considerations) is the one that is in effect.</para> <para>The calling device admin must have requested DeviceAdminInfo#USES_POLICY_LIMIT_PASSWORD to be able to call this method; if it has not, a security exception will be thrown.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setPasswordQuality
				/// </java-name>
				[Dot42.DexImport("setPasswordQuality", "(Landroid/content/ComponentName;I)V", AccessFlags = 1)]
				public virtual void SetPasswordQuality(global::Android.Content.ComponentName admin, int quality) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Retrieve the current minimum password quality for all admins or a particular one. </para>        
				/// </summary>
				/// <java-name>
				/// getPasswordQuality
				/// </java-name>
				[Dot42.DexImport("getPasswordQuality", "(Landroid/content/ComponentName;)I", AccessFlags = 1)]
				public virtual int GetPasswordQuality(global::Android.Content.ComponentName admin) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Called by an application that is administering the device to set the minimum allowed password length. After setting this, the user will not be able to enter a new password that is not at least as restrictive as what has been set. Note that the current password will remain until the user has set a new one, so the change does not take place immediately. To prompt the user for a new password, use ACTION_SET_NEW_PASSWORD after setting this value. This constraint is only imposed if the administrator has also requested either PASSWORD_QUALITY_NUMERIC, PASSWORD_QUALITY_ALPHABETIC PASSWORD_QUALITY_ALPHANUMERIC, or PASSWORD_QUALITY_COMPLEX with setPasswordQuality.</para> <para>The calling device admin must have requested DeviceAdminInfo#USES_POLICY_LIMIT_PASSWORD to be able to call this method; if it has not, a security exception will be thrown.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setPasswordMinimumLength
				/// </java-name>
				[Dot42.DexImport("setPasswordMinimumLength", "(Landroid/content/ComponentName;I)V", AccessFlags = 1)]
				public virtual void SetPasswordMinimumLength(global::Android.Content.ComponentName admin, int length) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Retrieve the current minimum password length for all admins or a particular one. </para>        
				/// </summary>
				/// <java-name>
				/// getPasswordMinimumLength
				/// </java-name>
				[Dot42.DexImport("getPasswordMinimumLength", "(Landroid/content/ComponentName;)I", AccessFlags = 1)]
				public virtual int GetPasswordMinimumLength(global::Android.Content.ComponentName admin) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Return the maximum password length that the device supports for a particular password quality. </para>        
				/// </summary>
				/// <returns>
				///  <para>Returns the maximum length that the user can enter. </para>
				/// </returns>
				/// <java-name>
				/// getPasswordMaximumLength
				/// </java-name>
				[Dot42.DexImport("getPasswordMaximumLength", "(I)I", AccessFlags = 1)]
				public virtual int GetPasswordMaximumLength(int quality) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Setting this to a value greater than zero enables a built-in policy that will perform a device wipe after too many incorrect device-unlock passwords have been entered. This built-in policy combines watching for failed passwords and wiping the device, and requires that you request both DeviceAdminInfo#USES_POLICY_WATCH_LOGIN and DeviceAdminInfo#USES_POLICY_WIPE_DATA}.</para> <para>To implement any other policy (e.g. wiping data for a particular application only, erasing or revoking credentials, or reporting the failure to a server), you should implement DeviceAdminReceiver#onPasswordFailed(Context, android.content.Intent) instead. Do not use this API, because if the maximum count is reached, the device will be wiped immediately, and your callback will not be invoked.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setMaximumFailedPasswordsForWipe
				/// </java-name>
				[Dot42.DexImport("setMaximumFailedPasswordsForWipe", "(Landroid/content/ComponentName;I)V", AccessFlags = 1)]
				public virtual void SetMaximumFailedPasswordsForWipe(global::Android.Content.ComponentName admin, int num) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Retrieve the current maximum number of login attempts that are allowed before the device wipes itself, for all admins or a particular one. </para>        
				/// </summary>
				/// <java-name>
				/// getMaximumFailedPasswordsForWipe
				/// </java-name>
				[Dot42.DexImport("getMaximumFailedPasswordsForWipe", "(Landroid/content/ComponentName;)I", AccessFlags = 1)]
				public virtual int GetMaximumFailedPasswordsForWipe(global::Android.Content.ComponentName admin) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Force a new device unlock password (the password needed to access the entire device, not for individual accounts) on the user. This takes effect immediately. The given password must be sufficient for the current password quality and length constraints as returned by getPasswordQuality(ComponentName) and getPasswordMinimumLength(ComponentName); if it does not meet these constraints, then it will be rejected and false returned. Note that the password may be a stronger quality (containing alphanumeric characters when the requested quality is only numeric), in which case the currently active quality will be increased to match.</para> <para>The calling device admin must have requested DeviceAdminInfo#USES_POLICY_RESET_PASSWORD to be able to call this method; if it has not, a security exception will be thrown.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns true if the password was applied, or false if it is not acceptable for the current constraints. </para>
				/// </returns>
				/// <java-name>
				/// resetPassword
				/// </java-name>
				[Dot42.DexImport("resetPassword", "(Ljava/lang/String;I)Z", AccessFlags = 1)]
				public virtual bool ResetPassword(string password, int flags) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Called by an application that is administering the device to set the maximum time for user activity until the device will lock. This limits the length that the user can set. It takes effect immediately.</para> <para>The calling device admin must have requested DeviceAdminInfo#USES_POLICY_FORCE_LOCK to be able to call this method; if it has not, a security exception will be thrown.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setMaximumTimeToLock
				/// </java-name>
				[Dot42.DexImport("setMaximumTimeToLock", "(Landroid/content/ComponentName;J)V", AccessFlags = 1)]
				public virtual void SetMaximumTimeToLock(global::Android.Content.ComponentName admin, long timeMs) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Retrieve the current maximum time to unlock for all admins or a particular one. </para>        
				/// </summary>
				/// <java-name>
				/// getMaximumTimeToLock
				/// </java-name>
				[Dot42.DexImport("getMaximumTimeToLock", "(Landroid/content/ComponentName;)J", AccessFlags = 1)]
				public virtual long GetMaximumTimeToLock(global::Android.Content.ComponentName admin) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				///  <para>Make the device lock immediately, as if the lock screen timeout has expired at the point of this call.</para> <para>The calling device admin must have requested DeviceAdminInfo#USES_POLICY_FORCE_LOCK to be able to call this method; if it has not, a security exception will be thrown. </para>        
				/// </summary>
				/// <java-name>
				/// lockNow
				/// </java-name>
				[Dot42.DexImport("lockNow", "()V", AccessFlags = 1)]
				public virtual void LockNow() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Ask the user date be wiped. This will cause the device to reboot, erasing all user data while next booting up. External storage such as SD cards will be also erased if the flag WIPE_EXTERNAL_STORAGE is set.</para> <para>The calling device admin must have requested DeviceAdminInfo#USES_POLICY_WIPE_DATA to be able to call this method; if it has not, a security exception will be thrown.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// wipeData
				/// </java-name>
				[Dot42.DexImport("wipeData", "(I)V", AccessFlags = 1)]
				public virtual void WipeData(int flags) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Return a list of all currently active device administrator's component names. Note that if there are no administrators than null may be returned. </para>        
				/// </summary>
				/// <java-name>
				/// getActiveAdmins
				/// </java-name>
				public virtual global::Java.Util.IList<global::Android.Content.ComponentName> ActiveAdmins
				{
						[Dot42.DexImport("getActiveAdmins", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Landroid/content/ComponentName;>;")]
						get{ return default(global::Java.Util.IList<global::Android.Content.ComponentName>); }
				}

				/// <summary>
				///  <para>Determine whether the current password the user has set is sufficient to meet the policy requirements (quality, minimum length) that have been requested.</para> <para>The calling device admin must have requested DeviceAdminInfo#USES_POLICY_LIMIT_PASSWORD to be able to call this method; if it has not, a security exception will be thrown.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns true if the password meets the current requirements, else false. </para>
				/// </returns>
				/// <java-name>
				/// isActivePasswordSufficient
				/// </java-name>
				public virtual bool IsActivePasswordSufficient
				{
						[Dot42.DexImport("isActivePasswordSufficient", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Retrieve the number of times the user has failed at entering a password since that last successful password entry.</para> <para>The calling device admin must have requested DeviceAdminInfo#USES_POLICY_WATCH_LOGIN to be able to call this method; if it has not, a security exception will be thrown. </para>        
				/// </summary>
				/// <java-name>
				/// getCurrentFailedPasswordAttempts
				/// </java-name>
				public virtual int CurrentFailedPasswordAttempts
				{
						[Dot42.DexImport("getCurrentFailedPasswordAttempts", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

		}

}

