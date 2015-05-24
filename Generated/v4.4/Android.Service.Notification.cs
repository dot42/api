#pragma warning disable 1717
namespace Android.Service.Notification
{
		/// <summary>
		///  <para>A service that receives calls from the system when new notifications are posted or removed. </para> <para>To extend this class, you must declare the service in your manifest file with the android.Manifest.permission#BIND_NOTIFICATION_LISTENER_SERVICE permission and include an intent filter with the SERVICE_INTERFACE action. For example:</para> <para> <pre>
		/// &lt;service android:name=".NotificationListener"
		///          android:label="&amp;#64;string/service_name"
		///          android:permission="android.permission.BIND_NOTIFICATION_LISTENER_SERVICE"&gt;
		///     &lt;intent-filter&gt;
		///         &lt;action android:name="android.service.notification.NotificationListenerService" /&gt;
		///     &lt;/intent-filter&gt;
		/// &lt;/service&gt;</pre> </para>    
		/// </summary>
		/// <java-name>
		/// android/service/notification/NotificationListenerService
		/// </java-name>
		[Dot42.DexImport("android/service/notification/NotificationListenerService", AccessFlags = 1057)]
		public abstract partial class NotificationListenerService : global::Android.App.Service
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>The Intent that must be declared as handled by the service. </para>        
				/// </summary>
				/// <java-name>
				/// SERVICE_INTERFACE
				/// </java-name>
				[Dot42.DexImport("SERVICE_INTERFACE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SERVICE_INTERFACE = "android.service.notification.NotificationListenerService";
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public NotificationListenerService() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Implement this method to learn about new notifications as they are posted by apps.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// onNotificationPosted
				/// </java-name>
				[Dot42.DexImport("onNotificationPosted", "(Landroid/service/notification/StatusBarNotification;)V", AccessFlags = 1025)]
				public abstract void OnNotificationPosted(global::Android.Service.Notification.StatusBarNotification sbn) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Implement this method to learn when notifications are removed. </para> <para>This might occur because the user has dismissed the notification using system UI (or another notification listener) or because the app has withdrawn the notification. </para> <para>NOTE: The StatusBarNotification object you receive will be "light"; that is, the result from StatusBarNotification#getNotification may be missing some heavyweight fields such as android.app.Notification#contentView and android.app.Notification#largeIcon. However, all other fields on StatusBarNotification, sufficient to match this call with a prior call to onNotificationPosted(StatusBarNotification), will be intact.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// onNotificationRemoved
				/// </java-name>
				[Dot42.DexImport("onNotificationRemoved", "(Landroid/service/notification/StatusBarNotification;)V", AccessFlags = 1025)]
				public abstract void OnNotificationRemoved(global::Android.Service.Notification.StatusBarNotification sbn) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Inform the notification manager about dismissal of a single notification. </para> <para>Use this if your listener has a user interface that allows the user to dismiss individual notifications, similar to the behavior of Android's status bar and notification panel. It should be called after the user dismisses a single notification using your UI; upon being informed, the notification manager will actually remove the notification and you will get an onNotificationRemoved(StatusBarNotification) callback. </para> <para> <b>Note:</b> If your listener allows the user to fire a notification's android.app.Notification#contentIntent by tapping/clicking/etc., you should call this method at that time  <b>if</b> the Notification in question has the android.app.Notification#FLAG_AUTO_CANCEL flag set.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// cancelNotification
				/// </java-name>
				[Dot42.DexImport("cancelNotification", "(Ljava/lang/String;Ljava/lang/String;I)V", AccessFlags = 17)]
				public void CancelNotification(string pkg, string tag, int id) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Inform the notification manager about dismissal of all notifications. </para> <para>Use this if your listener has a user interface that allows the user to dismiss all notifications, similar to the behavior of Android's status bar and notification panel. It should be called after the user invokes the "dismiss all" function of your UI; upon being informed, the notification manager will actually remove all active notifications and you will get multiple onNotificationRemoved(StatusBarNotification) callbacks.</para> <para>{ <para>cancelNotification(String, String, int)} </para></para>        
				/// </summary>
				/// <java-name>
				/// cancelAllNotifications
				/// </java-name>
				[Dot42.DexImport("cancelAllNotifications", "()V", AccessFlags = 17)]
				public void CancelAllNotifications() /* MethodBuilder.Create */ 
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

				/// <summary>
				///  <para>Request the list of outstanding notifications (that is, those that are visible to the current user). Useful when starting up and you don't know what's already been posted.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>An array of active notifications. </para>
				/// </returns>
				/// <java-name>
				/// getActiveNotifications
				/// </java-name>
				public virtual global::Android.Service.Notification.StatusBarNotification[] ActiveNotifications
				{
						[Dot42.DexImport("getActiveNotifications", "()[Landroid/service/notification/StatusBarNotification;", AccessFlags = 1)]
						get{ return default(global::Android.Service.Notification.StatusBarNotification[]); }
				}

		}

		/// <summary>
		///  <para>Class encapsulating a Notification. Sent by the NotificationManagerService to clients including the status bar and any android.service.notification.NotificationListenerServices. </para>    
		/// </summary>
		/// <java-name>
		/// android/service/notification/StatusBarNotification
		/// </java-name>
		[Dot42.DexImport("android/service/notification/StatusBarNotification", AccessFlags = 33)]
		public partial class StatusBarNotification : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.Service.Notification.StatusBarNotification> CREATOR;
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;IIILandroid/app/Notificat" +
    "ion;Landroid/os/UserHandle;J)V", AccessFlags = 1)]
				public StatusBarNotification(string pkg, string basePkg, int id, string tag, int uid, int initialPid, int score, global::Android.App.Notification notification, global::Android.OS.UserHandle user, long postTime) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/os/Parcel;)V", AccessFlags = 1)]
				public StatusBarNotification(global::Android.OS.Parcel @in) /* MethodBuilder.Create */ 
				{
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

				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Landroid/service/notification/StatusBarNotification;", AccessFlags = 1)]
				public virtual global::Android.Service.Notification.StatusBarNotification Clone() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Service.Notification.StatusBarNotification);
				}

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal StatusBarNotification() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Convenience method to check the notification's flags for Notification#FLAG_ONGOING_EVENT. </para>        
				/// </summary>
				/// <java-name>
				/// isOngoing
				/// </java-name>
				public virtual bool IsOngoing
				{
						[Dot42.DexImport("isOngoing", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Convenience method to check the notification's flags for either Notification#FLAG_ONGOING_EVENT or Notification#FLAG_NO_CLEAR. </para>        
				/// </summary>
				/// <java-name>
				/// isClearable
				/// </java-name>
				public virtual bool IsClearable
				{
						[Dot42.DexImport("isClearable", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Returns a userHandle for the instance of the app that posted this notification. </para>        
				/// </summary>
				/// <java-name>
				/// getUserId
				/// </java-name>
				public virtual int UserId
				{
						[Dot42.DexImport("getUserId", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>The package of the app that posted the notification. </para>        
				/// </summary>
				/// <java-name>
				/// getPackageName
				/// </java-name>
				public virtual string PackageName
				{
						[Dot42.DexImport("getPackageName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>The id supplied to android.app.NotificationManager#notify(int,Notification). </para>        
				/// </summary>
				/// <java-name>
				/// getId
				/// </java-name>
				public virtual int Id
				{
						[Dot42.DexImport("getId", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>The tag supplied to android.app.NotificationManager#notify(int,Notification), or null if no tag was specified. </para>        
				/// </summary>
				/// <java-name>
				/// getTag
				/// </java-name>
				public virtual string Tag
				{
						[Dot42.DexImport("getTag", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>The android.app.Notification supplied to android.app.NotificationManager#notify(int,Notification). </para>        
				/// </summary>
				/// <java-name>
				/// getNotification
				/// </java-name>
				public virtual global::Android.App.Notification Notification
				{
						[Dot42.DexImport("getNotification", "()Landroid/app/Notification;", AccessFlags = 1)]
						get{ return default(global::Android.App.Notification); }
				}

				/// <summary>
				///  <para>The time (in System#currentTimeMillis time) the notification was posted, which may be different than android.app.Notification#when. </para>        
				/// </summary>
				/// <java-name>
				/// getPostTime
				/// </java-name>
				public virtual long PostTime
				{
						[Dot42.DexImport("getPostTime", "()J", AccessFlags = 1)]
						get{ return default(long); }
				}

		}

}

