#pragma warning disable 1717
namespace Android.Content
{
		/// <summary>
		///  <para>An abstract implementation of a SyncAdapter that spawns a thread to invoke a sync operation. If a sync operation is already in progress when a startSync() request is received then an error will be returned to the new request and the existing request will be allowed to continue. When a startSync() is received and there is no sync operation in progress then a thread will be started to run the operation and onPerformSync will be invoked on that thread. If a cancelSync() is received that matches an existing sync operation then the thread that is running that sync operation will be interrupted, which will indicate to the thread that the sync has been canceled. </para> <para>In order to be a sync adapter one must extend this class, provide implementations for the abstract methods and write a service that returns the result of getSyncAdapterBinder() in the service's android.app.Service#onBind(android.content.Intent) when invoked with an intent with action  <code>android.content.SyncAdapter</code>. This service must specify the following intent filter and metadata tags in its AndroidManifest.xml file  <pre>
		///   &lt;intent-filter&gt;
		///     &lt;action android:name="android.content.SyncAdapter" /&gt;
		///   &lt;/intent-filter&gt;
		///   &lt;meta-data android:name="android.content.SyncAdapter"
		///             android:resource="@xml/syncadapter" /&gt;
		/// </pre> The  <code>android:resource</code> attribute must point to a resource that looks like:  <pre>
		/// &lt;sync-adapter xmlns:android="http://schemas.android.com/apk/res/android"
		///    android:contentAuthority="authority"
		///    android:accountType="accountType"
		///    android:userVisible="true|false"
		///    android:supportsUploading="true|false"
		///    android:allowParallelSyncs="true|false"
		///    android:isAlwaysSyncable="true|false"
		///    android:syncAdapterSettingsAction="ACTION_OF_SETTINGS_ACTIVITY"
		/// /&gt;
		/// </pre>  <ul> <li> <para>The  <code>android:contentAuthority</code> and  <code>android:accountType</code> attributes indicate which content authority and for which account types this sync adapter serves. </para></li> <li> <para> <code>android:userVisible</code> defaults to true and controls whether or not this sync adapter shows up in the Sync Settings screen. </para></li> <li> <para> <code>android:supportsUploading</code> defaults to true and if true an upload-only sync will be requested for all syncadapters associated with an authority whenever that authority's content provider does a ContentResolver#notifyChange(android.net.Uri, android.database.ContentObserver, boolean) with syncToNetwork set to true. </para></li> <li> <para> <code>android:allowParallelSyncs</code> defaults to false and if true indicates that the sync adapter can handle syncs for multiple accounts at the same time. Otherwise the SyncManager will wait until the sync adapter is not in use before requesting that it sync an account's data. </para></li> <li> <para> <code>android:isAlwaysSyncable</code> defaults to false and if true tells the SyncManager to intialize the isSyncable state to 1 for that sync adapter for each account that is added. </para></li> <li> <para> <code>android:syncAdapterSettingsAction</code> defaults to null and if supplied it specifies an Intent action of an activity that can be used to adjust the sync adapter's sync settings. The activity must live in the same package as the sync adapter. </para></li></ul></para>    
		/// </summary>
		/// <java-name>
		/// android/content/AbstractThreadedSyncAdapter
		/// </java-name>
		[Dot42.DexImport("android/content/AbstractThreadedSyncAdapter", AccessFlags = 1057)]
		public abstract partial class AbstractThreadedSyncAdapter
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Kernel event log tag. Also listed in data/etc/event-log-tags.  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Private constant. May go away in the next release. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// LOG_SYNC_DETAILS
				/// </java-name>
				[Dot42.DexImport("LOG_SYNC_DETAILS", "I", AccessFlags = 25)]
				public const int LOG_SYNC_DETAILS = 2743;
				/// <summary>
				///  <para>Creates an AbstractThreadedSyncAdapter. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Z)V", AccessFlags = 1)]
				public AbstractThreadedSyncAdapter(global::Android.Content.Context context, bool autoInitialize) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Creates an AbstractThreadedSyncAdapter. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;ZZ)V", AccessFlags = 1)]
				public AbstractThreadedSyncAdapter(global::Android.Content.Context context, bool autoInitialize, bool allowParallelSyncs) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Perform a sync for this account. SyncAdapter-specific parameters may be specified in extras, which is guaranteed to not be null. Invocations of this method are guaranteed to be serialized.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// onPerformSync
				/// </java-name>
				[Dot42.DexImport("onPerformSync", "(Landroid/accounts/Account;Landroid/os/Bundle;Ljava/lang/String;Landroid/content/" +
    "ContentProviderClient;Landroid/content/SyncResult;)V", AccessFlags = 1025)]
				public abstract void OnPerformSync(global::Android.Accounts.Account account, global::Android.OS.Bundle extras, string authority, global::Android.Content.ContentProviderClient provider, global::Android.Content.SyncResult syncResult) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Indicates that a sync operation has been canceled. This will be invoked on a separate thread than the sync thread and so you must consider the multi-threaded implications of the work that you do in this method. </para> <para>This will only be invoked when the SyncAdapter indicates that it doesn't support parallel syncs. </para>        
				/// </summary>
				/// <java-name>
				/// onSyncCanceled
				/// </java-name>
				[Dot42.DexImport("onSyncCanceled", "()V", AccessFlags = 1)]
				public virtual void OnSyncCanceled() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Indicates that a sync operation has been canceled. This will be invoked on a separate thread than the sync thread and so you must consider the multi-threaded implications of the work that you do in this method. </para> <para>This will only be invoked when the SyncAdapter indicates that it does support parallel syncs. </para>        
				/// </summary>
				/// <java-name>
				/// onSyncCanceled
				/// </java-name>
				[Dot42.DexImport("onSyncCanceled", "(Ljava/lang/Thread;)V", AccessFlags = 1)]
				public virtual void OnSyncCanceled(global::System.Threading.Thread thread) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal AbstractThreadedSyncAdapter() /* TypeBuilder.AddDefaultConstructor */ 
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

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a reference to the IBinder of the SyncAdapter service. </para>
				/// </returns>
				/// <java-name>
				/// getSyncAdapterBinder
				/// </java-name>
				public global::Android.OS.IBinder SyncAdapterBinder
				{
						[Dot42.DexImport("getSyncAdapterBinder", "()Landroid/os/IBinder;", AccessFlags = 17)]
						get{ return default(global::Android.OS.IBinder); }
				}

		}

		/// <summary>
		///  <para>This exception is thrown when a call to Context#startActivity or one of its variants fails because an Activity can not be found to execute the given Intent. </para>    
		/// </summary>
		/// <java-name>
		/// android/content/ActivityNotFoundException
		/// </java-name>
		[Dot42.DexImport("android/content/ActivityNotFoundException", AccessFlags = 33)]
		public partial class ActivityNotFoundException : global::System.SystemException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ActivityNotFoundException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public ActivityNotFoundException(string name) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>A helper class to help make handling asynchronous ContentResolver queries easier. </para>    
		/// </summary>
		/// <java-name>
		/// android/content/AsyncQueryHandler
		/// </java-name>
		[Dot42.DexImport("android/content/AsyncQueryHandler", AccessFlags = 1057)]
		public abstract partial class AsyncQueryHandler : global::Android.OS.Handler
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/ContentResolver;)V", AccessFlags = 1)]
				public AsyncQueryHandler(global::Android.Content.ContentResolver cr) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// createHandler
				/// </java-name>
				[Dot42.DexImport("createHandler", "(Landroid/os/Looper;)Landroid/os/Handler;", AccessFlags = 4)]
				protected internal virtual global::Android.OS.Handler CreateHandler(global::Android.OS.Looper looper) /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.Handler);
				}

				/// <summary>
				///  <para>This method begins an asynchronous query. When the query is done onQueryComplete is called.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// startQuery
				/// </java-name>
				[Dot42.DexImport("startQuery", "(ILjava/lang/Object;Landroid/net/Uri;[Ljava/lang/String;Ljava/lang/String;[Ljava/" +
    "lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void StartQuery(int token, object cookie, global::Android.Net.Uri uri, string[] projection, string selection, string[] selectionArgs, string orderBy) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Attempts to cancel operation that has not already started. Note that there is no guarantee that the operation will be canceled. They still may result in a call to on[Query/Insert/Update/Delete]Complete after this call has completed.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// cancelOperation
				/// </java-name>
				[Dot42.DexImport("cancelOperation", "(I)V", AccessFlags = 17)]
				public void CancelOperation(int token) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>This method begins an asynchronous insert. When the insert operation is done onInsertComplete is called.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// startInsert
				/// </java-name>
				[Dot42.DexImport("startInsert", "(ILjava/lang/Object;Landroid/net/Uri;Landroid/content/ContentValues;)V", AccessFlags = 17)]
				public void StartInsert(int token, object cookie, global::Android.Net.Uri uri, global::Android.Content.ContentValues initialValues) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>This method begins an asynchronous update. When the update operation is done onUpdateComplete is called.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// startUpdate
				/// </java-name>
				[Dot42.DexImport("startUpdate", "(ILjava/lang/Object;Landroid/net/Uri;Landroid/content/ContentValues;Ljava/lang/St" +
    "ring;[Ljava/lang/String;)V", AccessFlags = 17)]
				public void StartUpdate(int token, object cookie, global::Android.Net.Uri uri, global::Android.Content.ContentValues values, string selection, string[] selectionArgs) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>This method begins an asynchronous delete. When the delete operation is done onDeleteComplete is called.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// startDelete
				/// </java-name>
				[Dot42.DexImport("startDelete", "(ILjava/lang/Object;Landroid/net/Uri;Ljava/lang/String;[Ljava/lang/String;)V", AccessFlags = 17)]
				public void StartDelete(int token, object cookie, global::Android.Net.Uri uri, string selection, string[] selectionArgs) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Called when an asynchronous query is completed.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// onQueryComplete
				/// </java-name>
				[Dot42.DexImport("onQueryComplete", "(ILjava/lang/Object;Landroid/database/Cursor;)V", AccessFlags = 4)]
				protected internal virtual void OnQueryComplete(int token, object cookie, global::Android.Database.ICursor cursor) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Called when an asynchronous insert is completed.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// onInsertComplete
				/// </java-name>
				[Dot42.DexImport("onInsertComplete", "(ILjava/lang/Object;Landroid/net/Uri;)V", AccessFlags = 4)]
				protected internal virtual void OnInsertComplete(int token, object cookie, global::Android.Net.Uri uri) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Called when an asynchronous update is completed.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// onUpdateComplete
				/// </java-name>
				[Dot42.DexImport("onUpdateComplete", "(ILjava/lang/Object;I)V", AccessFlags = 4)]
				protected internal virtual void OnUpdateComplete(int token, object cookie, int result) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Called when an asynchronous delete is completed.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// onDeleteComplete
				/// </java-name>
				[Dot42.DexImport("onDeleteComplete", "(ILjava/lang/Object;I)V", AccessFlags = 4)]
				protected internal virtual void OnDeleteComplete(int token, object cookie, int result) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// handleMessage
				/// </java-name>
				[Dot42.DexImport("handleMessage", "(Landroid/os/Message;)V", AccessFlags = 1)]
				public override void HandleMessage(global::Android.OS.Message msg) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal AsyncQueryHandler() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// android/content/AsyncQueryHandler$WorkerHandler
				/// </java-name>
				[Dot42.DexImport("android/content/AsyncQueryHandler$WorkerHandler", AccessFlags = 4)]
				protected internal partial class WorkerHandler : global::Android.OS.Handler
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// this$0
						/// </java-name>
						[Dot42.DexImport("this$0", "Landroid/content/AsyncQueryHandler;", AccessFlags = 4112)]
						internal readonly global::Android.Content.AsyncQueryHandler This_0;
						[Dot42.DexImport("<init>", "(Landroid/content/AsyncQueryHandler;Landroid/os/Looper;)V", AccessFlags = 1)]
						public WorkerHandler(global::Android.Content.AsyncQueryHandler asyncQueryHandler, global::Android.OS.Looper looper) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// handleMessage
						/// </java-name>
						[Dot42.DexImport("handleMessage", "(Landroid/os/Message;)V", AccessFlags = 1)]
						public override void HandleMessage(global::Android.OS.Message msg) /* MethodBuilder.Create */ 
						{
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						protected internal WorkerHandler() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

				}

				/// <java-name>
				/// android/content/AsyncQueryHandler$WorkerArgs
				/// </java-name>
				[Dot42.DexImport("android/content/AsyncQueryHandler$WorkerArgs", AccessFlags = 28)]
				protected internal sealed partial class WorkerArgs
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// uri
						/// </java-name>
						[Dot42.DexImport("uri", "Landroid/net/Uri;", AccessFlags = 1)]
						public global::Android.Net.Uri Uri;
						/// <java-name>
						/// handler
						/// </java-name>
						[Dot42.DexImport("handler", "Landroid/os/Handler;", AccessFlags = 1)]
						public global::Android.OS.Handler Handler;
						/// <java-name>
						/// projection
						/// </java-name>
						[Dot42.DexImport("projection", "[Ljava/lang/String;", AccessFlags = 1)]
						public string[] Projection;
						/// <java-name>
						/// selection
						/// </java-name>
						[Dot42.DexImport("selection", "Ljava/lang/String;", AccessFlags = 1)]
						public string Selection;
						/// <java-name>
						/// selectionArgs
						/// </java-name>
						[Dot42.DexImport("selectionArgs", "[Ljava/lang/String;", AccessFlags = 1)]
						public string[] SelectionArgs;
						/// <java-name>
						/// orderBy
						/// </java-name>
						[Dot42.DexImport("orderBy", "Ljava/lang/String;", AccessFlags = 1)]
						public string OrderBy;
						/// <java-name>
						/// result
						/// </java-name>
						[Dot42.DexImport("result", "Ljava/lang/Object;", AccessFlags = 1)]
						public object Result;
						/// <java-name>
						/// cookie
						/// </java-name>
						[Dot42.DexImport("cookie", "Ljava/lang/Object;", AccessFlags = 1)]
						public object Cookie;
						/// <java-name>
						/// values
						/// </java-name>
						[Dot42.DexImport("values", "Landroid/content/ContentValues;", AccessFlags = 1)]
						public global::Android.Content.ContentValues Values;
						[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
						internal WorkerArgs() /* MethodBuilder.Create */ 
						{
						}

				}

		}

		/// <summary>
		///  <para>Abstract Loader that provides an AsyncTask to do the work. See Loader and android.app.LoaderManager for more details.</para> <para>Here is an example implementation of an AsyncTaskLoader subclass that loads the currently installed applications from the package manager. This implementation takes care of retrieving the application labels and sorting its result set from them, monitoring for changes to the installed applications, and rebuilding the list when a change in configuration requires this (such as a locale change).</para> <para>{ development/samples/ApiDemos/src/com/example/android/apis/app/LoaderCustom.java loader}</para> <para>An example implementation of a fragment that uses the above loader to show the currently installed applications in a list is below.</para> <para>{ development/samples/ApiDemos/src/com/example/android/apis/app/LoaderCustom.java fragment}</para> <para></para>    
		/// </summary>
		/// <java-name>
		/// android/content/AsyncTaskLoader
		/// </java-name>
		[Dot42.DexImport("android/content/AsyncTaskLoader", AccessFlags = 1057, Signature = "<D:Ljava/lang/Object;>Landroid/content/Loader<TD;>;")]
		public abstract partial class AsyncTaskLoader<D> : global::Android.Content.Loader<D>
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public AsyncTaskLoader(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Set amount to throttle updates by. This is the minimum time from when the last loadInBackground() call has completed until a new load is scheduled.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setUpdateThrottle
				/// </java-name>
				[Dot42.DexImport("setUpdateThrottle", "(J)V", AccessFlags = 1)]
				public virtual void SetUpdateThrottle(long delayMS) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onForceLoad
				/// </java-name>
				[Dot42.DexImport("onForceLoad", "()V", AccessFlags = 4)]
				protected internal override void OnForceLoad() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// cancelLoad
				/// </java-name>
				[Dot42.DexImport("cancelLoad", "()Z", AccessFlags = 1)]
				public virtual bool CancelLoad() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Called if the task was canceled before it was completed. Gives the class a chance to clean up post-cancellation and to properly dispose of the result.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// onCanceled
				/// </java-name>
				[Dot42.DexImport("onCanceled", "(Ljava/lang/Object;)V", AccessFlags = 1, Signature = "(TD;)V")]
				public virtual void OnCanceled(D data) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Called on a worker thread to perform the actual load and to return the result of the load operation.</para> <para>Implementations should not deliver the result directly, but should return them from this method, which will eventually end up calling deliverResult on the UI thread. If implementations need to process the results on the UI thread they may override deliverResult and do so there.</para> <para>To support cancellation, this method should periodically check the value of isLoadInBackgroundCanceled and terminate when it returns true. Subclasses may also override cancelLoadInBackground to interrupt the load directly instead of polling isLoadInBackgroundCanceled.</para> <para>When the load is canceled, this method may either return normally or throw OperationCanceledException. In either case, the Loader will call onCanceled to perform post-cancellation cleanup and to dispose of the result object, if any.</para> <para> <para>isLoadInBackgroundCanceled </para> <para>cancelLoadInBackground </para> <para>onCanceled </para></para>        
				/// </summary>
				/// <returns>
				///  <para>The result of the load operation.</para>
				/// </returns>
				/// <java-name>
				/// loadInBackground
				/// </java-name>
				[Dot42.DexImport("loadInBackground", "()Ljava/lang/Object;", AccessFlags = 1025, Signature = "()TD;")]
				public abstract D LoadInBackground() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Calls loadInBackground().</para> <para>This method is reserved for use by the loader framework. Subclasses should override loadInBackground instead of this method.</para> <para> <para>loadInBackground </para></para>        
				/// </summary>
				/// <returns>
				///  <para>The result of the load operation.</para>
				/// </returns>
				/// <java-name>
				/// onLoadInBackground
				/// </java-name>
				[Dot42.DexImport("onLoadInBackground", "()Ljava/lang/Object;", AccessFlags = 4, Signature = "()TD;")]
				protected internal virtual D OnLoadInBackground() /* MethodBuilder.Create */ 
				{
						return default(D);
				}

				/// <java-name>
				/// dump
				/// </java-name>
				[Dot42.DexImport("dump", "(Ljava/lang/String;Ljava/io/FileDescriptor;Ljava/io/PrintWriter;[Ljava/lang/Strin" +
    "g;)V", AccessFlags = 1)]
				public override void Dump(string prefix, global::Java.IO.FileDescriptor fd, global::Java.IO.PrintWriter writer, string[] args) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal AsyncTaskLoader() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		///  <para>Base class for code that will receive intents sent by sendBroadcast().</para> <para>If you don't need to send broadcasts across applications, consider using this class with android.support.v4.content.LocalBroadcastManager instead of the more general facilities described below. This will give you a much more efficient implementation (no cross-process communication needed) and allow you to avoid thinking about any security issues related to other applications being able to receive or send your broadcasts.</para> <para>You can either dynamically register an instance of this class with Context.registerReceiver() or statically publish an implementation through the &lt;receiver&gt; tag in your  <code>AndroidManifest.xml</code>.</para> <para> <b> <b>Note:</b></b>    If registering a receiver in your Activity.onResume() implementation, you should unregister it in Activity.onPause(). (You won't receive intents when paused, and this will cut down on unnecessary system overhead). Do not unregister in Activity.onSaveInstanceState(), because this won't be called if the user moves back in the history stack.</para> <para>There are two major classes of broadcasts that can be received:</para> <para> <ul> <li> <para> <b>Normal broadcasts</b> (sent with Context.sendBroadcast) are completely asynchronous. All receivers of the broadcast are run in an undefined order, often at the same time. This is more efficient, but means that receivers cannot use the result or abort APIs included here. </para></li> <li> <para> <b>Ordered broadcasts</b> (sent with Context.sendOrderedBroadcast) are delivered to one receiver at a time. As each receiver executes in turn, it can propagate a result to the next receiver, or it can completely abort the broadcast so that it won't be passed to other receivers. The order receivers run in can be controlled with the android:priority attribute of the matching intent-filter; receivers with the same priority will be run in an arbitrary order. </para></li></ul></para> <para>Even in the case of normal broadcasts, the system may in some situations revert to delivering the broadcast one receiver at a time. In particular, for receivers that may require the creation of a process, only one will be run at a time to avoid overloading the system with new processes. In this situation, however, the non-ordered semantics hold: these receivers still cannot return results or abort their broadcast.</para> <para>Note that, although the Intent class is used for sending and receiving these broadcasts, the Intent broadcast mechanism here is completely separate from Intents that are used to start Activities with Context.startActivity(). There is no way for a BroadcastReceiver to see or capture Intents used with startActivity(); likewise, when you broadcast an Intent, you will never find or start an Activity. These two operations are semantically very different: starting an Activity with an Intent is a foreground operation that modifies what the user is currently interacting with; broadcasting an Intent is a background operation that the user is not normally aware of.</para> <para>The BroadcastReceiver class (when launched as a component through a manifest's &lt;receiver&gt; tag) is an important part of an .</para> <para>Topics covered here:  <ol> <li> <para> </para></li> <li> <para> </para></li> <li> <para> </para></li></ol></para> <para>  <h3>Developer Guides</h3></para> <para> </para> <para>For information about how to use this class to receive and resolve intents, read the  developer guide.</para> <para> </para> <para>  <h3>Security</h3></para> <para>Receivers used with the Context APIs are by their nature a cross-application facility, so you must consider how other applications may be able to abuse your use of them. Some things to consider are:</para> <para> <ul> <li> <para></para> <para>The Intent namespace is global. Make sure that Intent action names and other strings are written in a namespace you own, or else you may inadvertently conflict with other applications. </para></li> <li> <para></para> <para>When you use Context#registerReceiver(BroadcastReceiver, IntentFilter),  <b>any</b> application may send broadcasts to that registered receiver. You can control who can send broadcasts to it through permissions described below. </para></li> <li> <para></para> <para>When you publish a receiver in your application's manifest and specify intent-filters for it, any other application can send broadcasts to it regardless of the filters you specify. To prevent others from sending to it, make it unavailable to them with  <code>android:exported="false"</code>. </para></li> <li> <para></para> <para>When you use Context#sendBroadcast(Intent) or related methods, normally any other application can receive these broadcasts. You can control who can receive such broadcasts through permissions described below. Alternatively, starting with android.os.Build.VERSION_CODES#ICE_CREAM_SANDWICH, you can also safely restrict the broadcast to a single application with Intent.setPackage </para></li></ul></para> <para>None of these issues exist when using android.support.v4.content.LocalBroadcastManager, since intents broadcast it never go outside of the current process.</para> <para>Access permissions can be enforced by either the sender or receiver of a broadcast.</para> <para>To enforce a permission when sending, you supply a non-null  <b>permission</b> argument to Context#sendBroadcast(Intent, String) or Context#sendOrderedBroadcast(Intent, String, BroadcastReceiver, android.os.Handler, int, String, Bundle). Only receivers who have been granted this permission (by requesting it with the &lt;uses-permission&gt; tag in their  <code>AndroidManifest.xml</code>) will be able to receive the broadcast.</para> <para>To enforce a permission when receiving, you supply a non-null  <b>permission</b> when registering your receiver  either when calling Context#registerReceiver(BroadcastReceiver, IntentFilter, String, android.os.Handler) or in the static &lt;receiver&gt; tag in your  <code>AndroidManifest.xml</code>. Only broadcasters who have been granted this permission (by requesting it with the &lt;uses-permission&gt; tag in their  <code>AndroidManifest.xml</code>) will be able to send an Intent to the receiver.</para> <para>See the  document for more information on permissions and security in general.</para> <para>  <h3>Receiver Lifecycle</h3></para> <para>A BroadcastReceiver object is only valid for the duration of the call to onReceive. Once your code returns from this function, the system considers the object to be finished and no longer active.</para> <para>This has important repercussions to what you can do in an onReceive implementation: anything that requires asynchronous operation is not available, because you will need to return from the function to handle the asynchronous operation, but at that point the BroadcastReceiver is no longer active and thus the system is free to kill its process before the asynchronous operation completes.</para> <para>In particular, you may  <b>not</b> show a dialog or bind to a service from within a BroadcastReceiver. For the former, you should instead use the android.app.NotificationManager API. For the latter, you can use Context.startService() to send a command to the service.</para> <para>  <h3>Process Lifecycle</h3></para> <para>A process that is currently executing a BroadcastReceiver (that is, currently running the code in its onReceive method) is considered to be a foreground process and will be kept running by the system except under cases of extreme memory pressure.</para> <para>Once you return from onReceive(), the BroadcastReceiver is no longer active, and its hosting process is only as important as any other application components that are running in it. This is especially important because if that process was only hosting the BroadcastReceiver (a common case for applications that the user has never or not recently interacted with), then upon returning from onReceive() the system will consider its process to be empty and aggressively kill it so that resources are available for other more important processes.</para> <para>This means that for longer-running operations you will often use a android.app.Service in conjunction with a BroadcastReceiver to keep the containing process active for the entire time of your operation. </para>    
		/// </summary>
		/// <java-name>
		/// android/content/BroadcastReceiver
		/// </java-name>
		[Dot42.DexImport("android/content/BroadcastReceiver", AccessFlags = 1057)]
		public abstract partial class BroadcastReceiver
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public BroadcastReceiver() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>This method is called when the BroadcastReceiver is receiving an Intent broadcast. During this time you can use the other methods on BroadcastReceiver to view/modify the current result values. This method is always called within the main thread of its process, unless you explicitly asked for it to be scheduled on a different thread using IntentFilter, String, android.os.Handler). When it runs on the main thread you should never perform long-running operations in it (there is a timeout of 10 seconds that the system allows before considering the receiver to be blocked and a candidate to be killed). You cannot launch a popup dialog in your implementation of onReceive().</para> <para> <b>If this BroadcastReceiver was launched through a &lt;receiver&gt; tag, then the object is no longer alive after returning from this function.</b> This means you should not perform any operations that return a result to you asynchronously  in particular, for interacting with services, you should use Context#startService(Intent) instead of Context#bindService(Intent, ServiceConnection, int). If you wish to interact with a service that is already running, you can use peekService.</para> <para>The Intent filters used in android.content.Context#registerReceiver and in application manifests are  <b>not</b> guaranteed to be exclusive. They are hints to the operating system about how to find suitable recipients. It is possible for senders to force delivery to specific recipients, bypassing filter resolution. For this reason, onReceive() implementations should respond only to known actions, ignoring any unexpected Intents that they may receive.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// onReceive
				/// </java-name>
				[Dot42.DexImport("onReceive", "(Landroid/content/Context;Landroid/content/Intent;)V", AccessFlags = 1025)]
				public abstract void OnReceive(global::Android.Content.Context context, global::Android.Content.Intent intent) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>This can be called by an application in onReceive to allow it to keep the broadcast active after returning from that function. This does  <b>not</b> change the expectation of being relatively responsive to the broadcast (finishing it within 10s), but does allow the implementation to move work related to it over to another thread to avoid glitching the main UI thread due to disk IO.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns a PendingResult representing the result of the active broadcast. The BroadcastRecord itself is no longer active; all data and other interaction must go through PendingResult APIs. The PendingResult.finish() method must be called once processing of the broadcast is done. </para>
				/// </returns>
				/// <java-name>
				/// goAsync
				/// </java-name>
				[Dot42.DexImport("goAsync", "()Landroid/content/BroadcastReceiver$PendingResult;", AccessFlags = 17)]
				public global::Android.Content.BroadcastReceiver.PendingResult GoAsync() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.BroadcastReceiver.PendingResult);
				}

				/// <summary>
				///  <para>Provide a binder to an already-running service. This method is synchronous and will not start the target service if it is not present, so it is safe to call from onReceive.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// peekService
				/// </java-name>
				[Dot42.DexImport("peekService", "(Landroid/content/Context;Landroid/content/Intent;)Landroid/os/IBinder;", AccessFlags = 1)]
				public virtual global::Android.OS.IBinder PeekService(global::Android.Content.Context myContext, global::Android.Content.Intent service) /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.IBinder);
				}

				/// <summary>
				///  <para>Change the current result extras of this broadcast; only works with broadcasts sent through Context.sendOrderedBroadcast. This is a Bundle holding arbitrary data, whose interpretation is up to the broadcaster. Can be set to null. Calling this method completely replaces the current map (if any).</para> <para> <b>This method does not work with non-ordered broadcasts such as those sent with Context.sendBroadcast</b></para> <para> <para>setResult(int, String, Bundle) </para></para>        
				/// </summary>
				/// <java-name>
				/// setResultExtras
				/// </java-name>
				[Dot42.DexImport("setResultExtras", "(Landroid/os/Bundle;)V", AccessFlags = 17)]
				public void SetResultExtras(global::Android.OS.Bundle extras) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Retrieve the current result extra data, as set by the previous receiver. Any changes you make to the returned Map will be propagated to the next receiver.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Map The current extras map. </para>
				/// </returns>
				/// <java-name>
				/// getResultExtras
				/// </java-name>
				[Dot42.DexImport("getResultExtras", "(Z)Landroid/os/Bundle;", AccessFlags = 17)]
				public global::Android.OS.Bundle GetResultExtras(bool makeMap) /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.Bundle);
				}

				/// <summary>
				///  <para>Change all of the result data returned from this broadcasts; only works with broadcasts sent through Context.sendOrderedBroadcast. All current result data is replaced by the value given to this method.</para> <para> <b>This method does not work with non-ordered broadcasts such as those sent with Context.sendBroadcast</b></para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setResult
				/// </java-name>
				[Dot42.DexImport("setResult", "(ILjava/lang/String;Landroid/os/Bundle;)V", AccessFlags = 17)]
				public void SetResult(int code, string data, global::Android.OS.Bundle extras) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns the flag indicating whether or not this receiver should abort the current broadcast.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>True if the broadcast should be aborted. </para>
				/// </returns>
				/// <java-name>
				/// getAbortBroadcast
				/// </java-name>
				[Dot42.DexImport("getAbortBroadcast", "()Z", AccessFlags = 17)]
				public bool GetAbortBroadcast() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Sets the flag indicating that this receiver should abort the current broadcast; only works with broadcasts sent through Context.sendOrderedBroadcast. This will prevent any other broadcast receivers from receiving the broadcast. It will still call onReceive of the BroadcastReceiver that the caller of Context.sendOrderedBroadcast passed in.</para> <para> <b>This method does not work with non-ordered broadcasts such as those sent with Context.sendBroadcast</b></para>        
				/// </summary>
				/// <java-name>
				/// abortBroadcast
				/// </java-name>
				[Dot42.DexImport("abortBroadcast", "()V", AccessFlags = 17)]
				public void AbortBroadcast() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Clears the flag indicating that this receiver should abort the current broadcast. </para>        
				/// </summary>
				/// <java-name>
				/// clearAbortBroadcast
				/// </java-name>
				[Dot42.DexImport("clearAbortBroadcast", "()V", AccessFlags = 17)]
				public void ClearAbortBroadcast() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>For internal use, sets the hint about whether this BroadcastReceiver is running in ordered mode. </para>        
				/// </summary>
				/// <java-name>
				/// setOrderedHint
				/// </java-name>
				[Dot42.DexImport("setOrderedHint", "(Z)V", AccessFlags = 17)]
				public void SetOrderedHint(bool isOrdered) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Retrieve the current result code, as set by the previous receiver.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>int The current result code. </para>
				/// </returns>
				/// <java-name>
				/// getResultCode
				/// </java-name>
				public int ResultCode
				{
						[Dot42.DexImport("getResultCode", "()I", AccessFlags = 17)]
						get{ return default(int); }
						[Dot42.DexImport("setResultCode", "(I)V", AccessFlags = 17)]
						set{ }
				}

				/// <summary>
				///  <para>Retrieve the current result data, as set by the previous receiver. Often this is null.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>String The current result data; may be null. </para>
				/// </returns>
				/// <java-name>
				/// getResultData
				/// </java-name>
				public string ResultData
				{
						[Dot42.DexImport("getResultData", "()Ljava/lang/String;", AccessFlags = 17)]
						get{ return default(string); }
						[Dot42.DexImport("setResultData", "(Ljava/lang/String;)V", AccessFlags = 17)]
						set{ }
				}

				/// <summary>
				///  <para>Returns true if the receiver is currently processing an ordered broadcast. </para>        
				/// </summary>
				/// <java-name>
				/// isOrderedBroadcast
				/// </java-name>
				public bool IsOrderedBroadcast
				{
						[Dot42.DexImport("isOrderedBroadcast", "()Z", AccessFlags = 17)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Returns true if the receiver is currently processing the initial value of a sticky broadcast  that is, the value that was last broadcast and is currently held in the sticky cache, so this is not directly the result of a broadcast right now. </para>        
				/// </summary>
				/// <java-name>
				/// isInitialStickyBroadcast
				/// </java-name>
				public bool IsInitialStickyBroadcast
				{
						[Dot42.DexImport("isInitialStickyBroadcast", "()Z", AccessFlags = 17)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Return the last value given to setDebugUnregister. </para>        
				/// </summary>
				/// <java-name>
				/// getDebugUnregister
				/// </java-name>
				public bool DebugUnregister
				{
						[Dot42.DexImport("getDebugUnregister", "()Z", AccessFlags = 17)]
						get{ return default(bool); }
						[Dot42.DexImport("setDebugUnregister", "(Z)V", AccessFlags = 17)]
						set{ }
				}

				/// <summary>
				///  <para>State for a result that is pending for a broadcast receiver. Returned by goAsync() while in BroadcastReceiver.onReceive(). This allows you to return from onReceive() without having the broadcast terminate; you must call finish() once you are done with the broadcast. This allows you to process the broadcast off of the main thread of your app.</para> <para>Note on threading: the state inside of this class is not itself thread-safe, however you can use it from any thread if you properly sure that you do not have races. Typically this means you will hand the entire object to another thread, which will be solely responsible for setting any results and finally calling finish(). </para>    
				/// </summary>
				/// <java-name>
				/// android/content/BroadcastReceiver$PendingResult
				/// </java-name>
				[Dot42.DexImport("android/content/BroadcastReceiver$PendingResult", AccessFlags = 9)]
				public partial class PendingResult
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
						internal PendingResult() /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Version of BroadcastReceiver.setResultExtras(Bundle) for asynchronous broadcast handling. </para>        
						/// </summary>
						/// <java-name>
						/// setResultExtras
						/// </java-name>
						[Dot42.DexImport("setResultExtras", "(Landroid/os/Bundle;)V", AccessFlags = 17)]
						public void SetResultExtras(global::Android.OS.Bundle extras) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Version of BroadcastReceiver.getResultExtras(boolean) for asynchronous broadcast handling. </para>        
						/// </summary>
						/// <java-name>
						/// getResultExtras
						/// </java-name>
						[Dot42.DexImport("getResultExtras", "(Z)Landroid/os/Bundle;", AccessFlags = 17)]
						public global::Android.OS.Bundle GetResultExtras(bool makeMap) /* MethodBuilder.Create */ 
						{
								return default(global::Android.OS.Bundle);
						}

						/// <summary>
						///  <para>Version of BroadcastReceiver.setResult(int, String, Bundle) for asynchronous broadcast handling. </para>        
						/// </summary>
						/// <java-name>
						/// setResult
						/// </java-name>
						[Dot42.DexImport("setResult", "(ILjava/lang/String;Landroid/os/Bundle;)V", AccessFlags = 17)]
						public void SetResult(int code, string data, global::Android.OS.Bundle extras) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Version of BroadcastReceiver.getAbortBroadcast() for asynchronous broadcast handling. </para>        
						/// </summary>
						/// <java-name>
						/// getAbortBroadcast
						/// </java-name>
						[Dot42.DexImport("getAbortBroadcast", "()Z", AccessFlags = 17)]
						public bool GetAbortBroadcast() /* MethodBuilder.Create */ 
						{
								return default(bool);
						}

						/// <summary>
						///  <para>Version of BroadcastReceiver.abortBroadcast() for asynchronous broadcast handling. </para>        
						/// </summary>
						/// <java-name>
						/// abortBroadcast
						/// </java-name>
						[Dot42.DexImport("abortBroadcast", "()V", AccessFlags = 17)]
						public void AbortBroadcast() /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Version of BroadcastReceiver.clearAbortBroadcast() for asynchronous broadcast handling. </para>        
						/// </summary>
						/// <java-name>
						/// clearAbortBroadcast
						/// </java-name>
						[Dot42.DexImport("clearAbortBroadcast", "()V", AccessFlags = 17)]
						public void ClearAbortBroadcast() /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Finish the broadcast. The current result will be sent and the next broadcast will proceed. </para>        
						/// </summary>
						/// <java-name>
						/// finish
						/// </java-name>
						[Dot42.DexImport("finish", "()V", AccessFlags = 17)]
						public void Finish() /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Version of BroadcastReceiver.getResultCode() for asynchronous broadcast handling. </para>        
						/// </summary>
						/// <java-name>
						/// getResultCode
						/// </java-name>
						public int ResultCode
						{
								[Dot42.DexImport("getResultCode", "()I", AccessFlags = 17)]
								get{ return default(int); }
								[Dot42.DexImport("setResultCode", "(I)V", AccessFlags = 17)]
								set{ }
						}

						/// <summary>
						///  <para>Version of BroadcastReceiver.getResultData() for asynchronous broadcast handling. </para>        
						/// </summary>
						/// <java-name>
						/// getResultData
						/// </java-name>
						public string ResultData
						{
								[Dot42.DexImport("getResultData", "()Ljava/lang/String;", AccessFlags = 17)]
								get{ return default(string); }
								[Dot42.DexImport("setResultData", "(Ljava/lang/String;)V", AccessFlags = 17)]
								set{ }
						}

				}

		}

		/// <summary>
		///  <para>Interface to the clipboard service, for placing and retrieving text in the global clipboard.</para> <para>You do not instantiate this class directly; instead, retrieve it through android.content.Context#getSystemService.</para> <para>The ClipboardManager API itself is very simple: it consists of methods to atomically get and set the current primary clipboard data. That data is expressed as a ClipData object, which defines the protocol for data exchange between applications.</para> <para>  <h3>Developer Guides</h3></para> <para> </para> <para>For more information about using the clipboard framework, read the  developer guide.</para> <para> </para> <para> <para>android.content.Context::getSystemService </para></para>    
		/// </summary>
		/// <java-name>
		/// android/content/ClipboardManager
		/// </java-name>
		[Dot42.DexImport("android/content/ClipboardManager", AccessFlags = 33)]
		public partial class ClipboardManager : global::Android.Text.ClipboardManager
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal ClipboardManager() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addPrimaryClipChangedListener
				/// </java-name>
				[Dot42.DexImport("addPrimaryClipChangedListener", "(Landroid/content/ClipboardManager$OnPrimaryClipChangedListener;)V", AccessFlags = 1)]
				public virtual void AddPrimaryClipChangedListener(global::Android.Content.ClipboardManager.IOnPrimaryClipChangedListener what) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// removePrimaryClipChangedListener
				/// </java-name>
				[Dot42.DexImport("removePrimaryClipChangedListener", "(Landroid/content/ClipboardManager$OnPrimaryClipChangedListener;)V", AccessFlags = 1)]
				public virtual void RemovePrimaryClipChangedListener(global::Android.Content.ClipboardManager.IOnPrimaryClipChangedListener what) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns the current primary clip on the clipboard. </para>        
				/// </summary>
				/// <java-name>
				/// getPrimaryClip
				/// </java-name>
				public virtual global::Android.Content.ClipData PrimaryClip
				{
						[Dot42.DexImport("getPrimaryClip", "()Landroid/content/ClipData;", AccessFlags = 1)]
						get{ return default(global::Android.Content.ClipData); }
						[Dot42.DexImport("setPrimaryClip", "(Landroid/content/ClipData;)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Returns a description of the current primary clip on the clipboard but not a copy of its data. </para>        
				/// </summary>
				/// <java-name>
				/// getPrimaryClipDescription
				/// </java-name>
				public virtual global::Android.Content.ClipDescription PrimaryClipDescription
				{
						[Dot42.DexImport("getPrimaryClipDescription", "()Landroid/content/ClipDescription;", AccessFlags = 1)]
						get{ return default(global::Android.Content.ClipDescription); }
				}

				/// <summary>
				///  <para>Returns true if there is currently a primary clip on the clipboard. </para>        
				/// </summary>
				/// <java-name>
				/// hasPrimaryClip
				/// </java-name>
				public virtual bool HasPrimaryClip
				{
						[Dot42.DexImport("hasPrimaryClip", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use getPrimaryClip() instead. This retrieves the primary clip and tries to coerce it to a string. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// getText
				/// </java-name>
				public override global::Java.Lang.ICharSequence Text
				{
						[Dot42.DexImport("getText", "()Ljava/lang/CharSequence;", AccessFlags = 1)]
						get{ return default(global::Java.Lang.ICharSequence); }
						[Dot42.DexImport("setText", "(Ljava/lang/CharSequence;)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use hasPrimaryClip() instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// hasText
				/// </java-name>
				public override bool HasText
				{
						[Dot42.DexImport("hasText", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Defines a listener callback that is invoked when the primary clip on the clipboard changes. Objects that want to register a listener call addPrimaryClipChangedListener() with an object that implements OnPrimaryClipChangedListener. </para>    
				/// </summary>
				/// <java-name>
				/// android/content/ClipboardManager$OnPrimaryClipChangedListener
				/// </java-name>
				[Dot42.DexImport("android/content/ClipboardManager$OnPrimaryClipChangedListener", AccessFlags = 1545)]
				public partial interface IOnPrimaryClipChangedListener
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>Callback that is invoked by android.content.ClipboardManager when the primary clip changes. </para>        
						/// </summary>
						/// <java-name>
						/// onPrimaryClipChanged
						/// </java-name>
						[Dot42.DexImport("onPrimaryClipChanged", "()V", AccessFlags = 1025)]
						void OnPrimaryClipChanged() /* MethodBuilder.Create */ ;

				}

		}

		/// <summary>
		///  <para>Representation of a clipped data on the clipboard.</para> <para>ClippedData is a complex type containing one or Item instances, each of which can hold one or more representations of an item of data. For display to the user, it also has a label and iconic representation.</para> <para>A ClipData contains a ClipDescription, which describes important meta-data about the clip. In particular, its getDescription().getMimeType(int) must return correct MIME type(s) describing the data in the clip. For help in correctly constructing a clip with the correct MIME type, use newPlainText(CharSequence, CharSequence), newUri(ContentResolver, CharSequence, Uri), and newIntent(CharSequence, Intent).</para> <para>Each Item instance can be one of three main classes of data: a simple CharSequence of text, a single Intent object, or a Uri. See Item for more details.</para> <para>  <h3>Developer Guides</h3></para> <para> </para> <para>For more information about using the clipboard framework, read the  developer guide.</para> <para> </para> <para>  <h3>Implementing Paste or Drop</h3></para> <para>To implement a paste or drop of a ClippedData object into an application, the application must correctly interpret the data for its use. If the Item it contains is simple text or an Intent, there is little to be done: text can only be interpreted as text, and an Intent will typically be used for creating shortcuts (such as placing icons on the home screen) or other actions.</para> <para>If all you want is the textual representation of the clipped data, you can use the convenience method Item.coerceToText. In this case there is generally no need to worry about the MIME types reported by getDescription().getMimeType(int), since any clip item an always be converted to a string.</para> <para>More complicated exchanges will be done through URIs, in particular "content:" URIs. A content URI allows the recipient of a ClippedData item to interact closely with the ContentProvider holding the data in order to negotiate the transfer of that data. The clip must also be filled in with the available MIME types; newUri(ContentResolver, CharSequence, Uri) will take care of correctly doing this.</para> <para>For example, here is the paste function of a simple NotePad application. When retrieving the data from the clipboard, it can do either two things: if the clipboard contains a URI reference to an existing note, it copies the entire structure of the note into a new note; otherwise, it simply coerces the clip into text and uses that as the new note's contents.</para> <para>{ development/samples/NotePad/src/com/example/android/notepad/NoteEditor.java paste}</para> <para>In many cases an application can paste various types of streams of data. For example, an e-mail application may want to allow the user to paste an image or other binary data as an attachment. This is accomplished through the ContentResolver ContentResolver#getStreamTypes(Uri, String) and ContentResolver#openTypedAssetFileDescriptor(Uri, String, android.os.Bundle) methods. These allow a client to discover the type(s) of data that a particular content URI can make available as a stream and retrieve the stream of data.</para> <para>For example, the implementation of Item.coerceToText itself uses this to try to retrieve a URI clip as a stream of text:</para> <para>{ frameworks/base/core/java/android/content/ClipData.java coerceToText}</para> <para>  <h3>Implementing Copy or Drag</h3></para> <para>To be the source of a clip, the application must construct a ClippedData object that any recipient can interpret best for their context. If the clip is to contain a simple text, Intent, or URI, this is easy: an Item containing the appropriate data type can be constructed and used.</para> <para>More complicated data types require the implementation of support in a ContentProvider for describing and generating the data for the recipient. A common scenario is one where an application places on the clipboard the content: URI of an object that the user has copied, with the data at that URI consisting of a complicated structure that only other applications with direct knowledge of the structure can use.</para> <para>For applications that do not have intrinsic knowledge of the data structure, the content provider holding it can make the data available as an arbitrary number of types of data streams. This is done by implementing the ContentProvider ContentProvider#getStreamTypes(Uri, String) and ContentProvider#openTypedAssetFile(Uri, String, android.os.Bundle) methods.</para> <para>Going back to our simple NotePad application, this is the implementation it may have to convert a single note URI (consisting of a title and the note text) into a stream of plain text data.</para> <para>{ development/samples/NotePad/src/com/example/android/notepad/NotePadProvider.java stream}</para> <para>The copy operation in our NotePad application is now just a simple matter of making a clip containing the URI of the note being copied:</para> <para>{ development/samples/NotePad/src/com/example/android/notepad/NotesList.java copy}</para> <para>Note if a paste operation needs this clip as text (for example to paste into an editor), then Item#coerceToText(Context) will ask the content provider for the clip URI as text and successfully paste the entire note. </para>    
		/// </summary>
		/// <java-name>
		/// android/content/ClipData
		/// </java-name>
		[Dot42.DexImport("android/content/ClipData", AccessFlags = 33)]
		public partial class ClipData : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.Content.ClipData> CREATOR;
				/// <summary>
				///  <para>Create a new clip.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/CharSequence;[Ljava/lang/String;Landroid/content/ClipData$Item;)V", AccessFlags = 1)]
				public ClipData(global::Java.Lang.ICharSequence label, string[] mimeTypes, global::Android.Content.ClipData.Item item) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Create a new clip.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/ClipDescription;Landroid/content/ClipData$Item;)V", AccessFlags = 1)]
				public ClipData(global::Android.Content.ClipDescription description, global::Android.Content.ClipData.Item item) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Create a new ClipData holding data of the type ClipDescription#MIMETYPE_TEXT_PLAIN.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns a new ClipData containing the specified data. </para>
				/// </returns>
				/// <java-name>
				/// newPlainText
				/// </java-name>
				[Dot42.DexImport("newPlainText", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Landroid/content/ClipData;", AccessFlags = 9)]
				public static global::Android.Content.ClipData NewPlainText(global::Java.Lang.ICharSequence label, global::Java.Lang.ICharSequence text) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.ClipData);
				}

				/// <summary>
				///  <para>Create a new ClipData holding an Intent with MIME type ClipDescription#MIMETYPE_TEXT_INTENT.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns a new ClipData containing the specified data. </para>
				/// </returns>
				/// <java-name>
				/// newIntent
				/// </java-name>
				[Dot42.DexImport("newIntent", "(Ljava/lang/CharSequence;Landroid/content/Intent;)Landroid/content/ClipData;", AccessFlags = 9)]
				public static global::Android.Content.ClipData NewIntent(global::Java.Lang.ICharSequence label, global::Android.Content.Intent intent) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.ClipData);
				}

				/// <summary>
				///  <para>Create a new ClipData holding a URI. If the URI is a content: URI, this will query the content provider for the MIME type of its data and use that as the MIME type. Otherwise, it will use the MIME type ClipDescription#MIMETYPE_TEXT_URILIST.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns a new ClipData containing the specified data. </para>
				/// </returns>
				/// <java-name>
				/// newUri
				/// </java-name>
				[Dot42.DexImport("newUri", "(Landroid/content/ContentResolver;Ljava/lang/CharSequence;Landroid/net/Uri;)Landr" +
    "oid/content/ClipData;", AccessFlags = 9)]
				public static global::Android.Content.ClipData NewUri(global::Android.Content.ContentResolver resolver, global::Java.Lang.ICharSequence label, global::Android.Net.Uri uri) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.ClipData);
				}

				/// <summary>
				///  <para>Create a new ClipData holding an URI with MIME type ClipDescription#MIMETYPE_TEXT_URILIST. Unlike newUri(ContentResolver, CharSequence, Uri), nothing is inferred about the URI  if it is a content: URI holding a bitmap, the reported type will still be uri-list. Use this with care!</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns a new ClipData containing the specified data. </para>
				/// </returns>
				/// <java-name>
				/// newRawUri
				/// </java-name>
				[Dot42.DexImport("newRawUri", "(Ljava/lang/CharSequence;Landroid/net/Uri;)Landroid/content/ClipData;", AccessFlags = 9)]
				public static global::Android.Content.ClipData NewRawUri(global::Java.Lang.ICharSequence label, global::Android.Net.Uri uri) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.ClipData);
				}

				/// <summary>
				///  <para>Add a new Item to the overall ClipData container. </para>        
				/// </summary>
				/// <java-name>
				/// addItem
				/// </java-name>
				[Dot42.DexImport("addItem", "(Landroid/content/ClipData$Item;)V", AccessFlags = 1)]
				public virtual void AddItem(global::Android.Content.ClipData.Item item) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Return a single item inside of the clip data. The index can range from 0 to getItemCount()-1. </para>        
				/// </summary>
				/// <java-name>
				/// getItemAt
				/// </java-name>
				[Dot42.DexImport("getItemAt", "(I)Landroid/content/ClipData$Item;", AccessFlags = 1)]
				public virtual global::Android.Content.ClipData.Item GetItemAt(int index) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.ClipData.Item);
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

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal ClipData() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Return the ClipDescription associated with this data, describing what it contains. </para>        
				/// </summary>
				/// <java-name>
				/// getDescription
				/// </java-name>
				public virtual global::Android.Content.ClipDescription Description
				{
						[Dot42.DexImport("getDescription", "()Landroid/content/ClipDescription;", AccessFlags = 1)]
						get{ return default(global::Android.Content.ClipDescription); }
				}

				/// <summary>
				///  <para>Return the number of items in the clip data. </para>        
				/// </summary>
				/// <java-name>
				/// getItemCount
				/// </java-name>
				public virtual int ItemCount
				{
						[Dot42.DexImport("getItemCount", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Description of a single item in a ClippedData.</para> <para>The types than an individual item can currently contain are:</para> <para> <ul> <li> <para>Text: a basic string of text. This is actually a CharSequence, so it can be formatted text supported by corresponding Android built-in style spans. (Custom application spans are not supported and will be stripped when transporting through the clipboard.) </para></li> <li> <para>Intent: an arbitrary Intent object. A typical use is the shortcut to create when pasting a clipped item on to the home screen. </para></li> <li> <para>Uri: a URI reference. This may be any URI (such as an http: URI representing a bookmark), however it is often a content: URI. Using content provider references as clips like this allows an application to share complex or large clips through the standard content provider facilities. </para></li></ul></para>    
				/// </summary>
				/// <java-name>
				/// android/content/ClipData$Item
				/// </java-name>
				[Dot42.DexImport("android/content/ClipData$Item", AccessFlags = 9)]
				public partial class Item
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "(Ljava/lang/CharSequence;)V", AccessFlags = 1)]
						public Item(global::Java.Lang.ICharSequence charSequence) /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "(Landroid/content/Intent;)V", AccessFlags = 1)]
						public Item(global::Android.Content.Intent intent) /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "(Landroid/net/Uri;)V", AccessFlags = 1)]
						public Item(global::Android.Net.Uri uri) /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "(Ljava/lang/CharSequence;Landroid/content/Intent;Landroid/net/Uri;)V", AccessFlags = 1)]
						public Item(global::Java.Lang.ICharSequence charSequence, global::Android.Content.Intent intent, global::Android.Net.Uri uri) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Turn this item into text, regardless of the type of data it actually contains.</para> <para>The algorithm for deciding what text to return is:  <ul> <li> <para>If getText is non-null, return that. </para></li> <li> <para>If getUri is non-null, try to retrieve its data as a text stream from its content provider. If this succeeds, copy the text into a String and return it. If it is not a content: URI or the content provider does not supply a text representation, return the raw URI as a string. </para></li> <li> <para>If getIntent is non-null, convert that to an intent: URI and return it. </para></li> <li> <para>Otherwise, return an empty string. </para></li></ul></para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>Returns the item's textual representation. </para>
						/// </returns>
						/// <java-name>
						/// coerceToText
						/// </java-name>
						[Dot42.DexImport("coerceToText", "(Landroid/content/Context;)Ljava/lang/CharSequence;", AccessFlags = 1)]
						public virtual global::Java.Lang.ICharSequence CoerceToText(global::Android.Content.Context context) /* MethodBuilder.Create */ 
						{
								return default(global::Java.Lang.ICharSequence);
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						protected internal Item() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

						/// <summary>
						///  <para>Retrieve the raw text contained in this Item. </para>        
						/// </summary>
						/// <java-name>
						/// getText
						/// </java-name>
						public virtual global::Java.Lang.ICharSequence Text
						{
								[Dot42.DexImport("getText", "()Ljava/lang/CharSequence;", AccessFlags = 1)]
								get{ return default(global::Java.Lang.ICharSequence); }
						}

						/// <summary>
						///  <para>Retrieve the raw Intent contained in this Item. </para>        
						/// </summary>
						/// <java-name>
						/// getIntent
						/// </java-name>
						public virtual global::Android.Content.Intent Intent
						{
								[Dot42.DexImport("getIntent", "()Landroid/content/Intent;", AccessFlags = 1)]
								get{ return default(global::Android.Content.Intent); }
						}

						/// <summary>
						///  <para>Retrieve the raw URI contained in this Item. </para>        
						/// </summary>
						/// <java-name>
						/// getUri
						/// </java-name>
						public virtual global::Android.Net.Uri Uri
						{
								[Dot42.DexImport("getUri", "()Landroid/net/Uri;", AccessFlags = 1)]
								get{ return default(global::Android.Net.Uri); }
						}

				}

		}

		/// <summary>
		///  <para>Meta-data describing the contents of a ClipData. Provides enough information to know if you can handle the ClipData, but not the data itself.</para> <para>  <h3>Developer Guides</h3></para> <para> </para> <para>For more information about using the clipboard framework, read the  developer guide.</para> <para>  </para>    
		/// </summary>
		/// <java-name>
		/// android/content/ClipDescription
		/// </java-name>
		[Dot42.DexImport("android/content/ClipDescription", AccessFlags = 33)]
		public partial class ClipDescription : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>The MIME type for a clip holding plain text. </para>        
				/// </summary>
				/// <java-name>
				/// MIMETYPE_TEXT_PLAIN
				/// </java-name>
				[Dot42.DexImport("MIMETYPE_TEXT_PLAIN", "Ljava/lang/String;", AccessFlags = 25)]
				public const string MIMETYPE_TEXT_PLAIN = "text/plain";
				/// <summary>
				///  <para>The MIME type for a clip holding one or more URIs. This should be used for URIs that are meaningful to a user (such as an http: URI). It should  <b>not</b> be used for a content: URI that references some other piece of data; in that case the MIME type should be the type of the referenced data. </para>        
				/// </summary>
				/// <java-name>
				/// MIMETYPE_TEXT_URILIST
				/// </java-name>
				[Dot42.DexImport("MIMETYPE_TEXT_URILIST", "Ljava/lang/String;", AccessFlags = 25)]
				public const string MIMETYPE_TEXT_URILIST = "text/uri-list";
				/// <summary>
				///  <para>The MIME type for a clip holding an Intent. </para>        
				/// </summary>
				/// <java-name>
				/// MIMETYPE_TEXT_INTENT
				/// </java-name>
				[Dot42.DexImport("MIMETYPE_TEXT_INTENT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string MIMETYPE_TEXT_INTENT = "text/vnd.android.intent";
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.Content.ClipDescription> CREATOR;
				/// <summary>
				///  <para>Create a new clip.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/CharSequence;[Ljava/lang/String;)V", AccessFlags = 1)]
				public ClipDescription(global::Java.Lang.ICharSequence label, string[] mimeTypes) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Create a copy of a ClipDescription. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/ClipDescription;)V", AccessFlags = 1)]
				public ClipDescription(global::Android.Content.ClipDescription o) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Helper to compare two MIME types, where one may be a pattern. </para>        
				/// </summary>
				/// <returns>
				///  <para>Returns true if the two MIME types match. </para>
				/// </returns>
				/// <java-name>
				/// compareMimeTypes
				/// </java-name>
				[Dot42.DexImport("compareMimeTypes", "(Ljava/lang/String;Ljava/lang/String;)Z", AccessFlags = 9)]
				public static bool CompareMimeTypes(string concreteType, string desiredType) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Check whether the clip description contains the given MIME type.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns true if one of the MIME types in the clip description matches the desired MIME type, else false. </para>
				/// </returns>
				/// <java-name>
				/// hasMimeType
				/// </java-name>
				[Dot42.DexImport("hasMimeType", "(Ljava/lang/String;)Z", AccessFlags = 1)]
				public virtual bool HasMimeType(string mimeType) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Filter the clip description MIME types by the given MIME type. Returns all MIME types in the clip that match the given MIME type.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns an array of all matching MIME types. If there are no matching MIME types, null is returned. </para>
				/// </returns>
				/// <java-name>
				/// filterMimeTypes
				/// </java-name>
				[Dot42.DexImport("filterMimeTypes", "(Ljava/lang/String;)[Ljava/lang/String;", AccessFlags = 1)]
				public virtual string[] FilterMimeTypes(string mimeType) /* MethodBuilder.Create */ 
				{
						return default(string[]);
				}

				/// <summary>
				///  <para>Return one of the possible clip MIME types. </para>        
				/// </summary>
				/// <java-name>
				/// getMimeType
				/// </java-name>
				[Dot42.DexImport("getMimeType", "(I)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetMimeType(int index) /* MethodBuilder.Create */ 
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

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal ClipDescription() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Return the label for this clip. </para>        
				/// </summary>
				/// <java-name>
				/// getLabel
				/// </java-name>
				public virtual global::Java.Lang.ICharSequence Label
				{
						[Dot42.DexImport("getLabel", "()Ljava/lang/CharSequence;", AccessFlags = 1)]
						get{ return default(global::Java.Lang.ICharSequence); }
				}

				/// <summary>
				///  <para>Return the number of MIME types the clip is available in. </para>        
				/// </summary>
				/// <java-name>
				/// getMimeTypeCount
				/// </java-name>
				public virtual int MimeTypeCount
				{
						[Dot42.DexImport("getMimeTypeCount", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

		}

		/// <summary>
		///  <para>Identifier for a specific application component (android.app.Activity, android.app.Service, android.content.BroadcastReceiver, or android.content.ContentProvider) that is available. Two pieces of information, encapsulated here, are required to identify a component: the package (a String) it exists in, and the class (a String) name inside of that package. </para>    
		/// </summary>
		/// <java-name>
		/// android/content/ComponentName
		/// </java-name>
		[Dot42.DexImport("android/content/ComponentName", AccessFlags = 49, Signature = "Ljava/lang/Object;Landroid/os/Parcelable;Ljava/lang/Cloneable;Ljava/lang/Comparab" +
    "le<Landroid/content/ComponentName;>;")]
		public sealed partial class ComponentName : global::Android.OS.IParcelable, global::Java.Lang.ICloneable, global::System.IComparable<global::Android.Content.ComponentName>
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.Content.ComponentName> CREATOR;
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public ComponentName(string @string, string string1) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Ljava/lang/String;)V", AccessFlags = 1)]
				public ComponentName(global::Android.Content.Context context, string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Ljava/lang/Class;)V", AccessFlags = 1, Signature = "(Landroid/content/Context;Ljava/lang/Class<*>;)V")]
				public ComponentName(global::Android.Content.Context context, global::System.Type type) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Instantiate a new ComponentName from the data in a Parcel that was previously written with writeToParcel(Parcel, int). Note that you must not use this with data written by writeToParcel(ComponentName, Parcel) since it is not possible to handle a null ComponentObject here.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/os/Parcel;)V", AccessFlags = 1)]
				public ComponentName(global::Android.OS.Parcel @in) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Landroid/content/ComponentName;", AccessFlags = 1)]
				public global::Android.Content.ComponentName Clone() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.ComponentName);
				}

				/// <summary>
				///  <para>Return a String that unambiguously describes both the package and class names contained in the ComponentName. You can later recover the ComponentName from this string through unflattenFromString(String).</para> <para> <para>unflattenFromString(String) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns a new String holding the package and class names. This is represented as the package name, concatenated with a '/' and then the class name.</para>
				/// </returns>
				/// <java-name>
				/// flattenToString
				/// </java-name>
				[Dot42.DexImport("flattenToString", "()Ljava/lang/String;", AccessFlags = 1)]
				public string FlattenToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>The same as flattenToString(), but abbreviates the class name if it is a suffix of the package. The result can still be used with unflattenFromString(String).</para> <para> <para>unflattenFromString(String) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns a new String holding the package and class names. This is represented as the package name, concatenated with a '/' and then the class name.</para>
				/// </returns>
				/// <java-name>
				/// flattenToShortString
				/// </java-name>
				[Dot42.DexImport("flattenToShortString", "()Ljava/lang/String;", AccessFlags = 1)]
				public string FlattenToShortString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Recover a ComponentName from a String that was previously created with flattenToString(). It splits the string at the first '/', taking the part before as the package name and the part after as the class name. As a special convenience (to use, for example, when parsing component names on the command line), if the '/' is immediately followed by a '.' then the final class name will be the concatenation of the package name with the string following the '/'. Thus "com.foo/.Blah" becomes package="com.foo" class="com.foo.Blah".</para> <para> <para>flattenToString() </para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns a new ComponentName containing the package and class names that were encoded in  <b>str</b></para>
				/// </returns>
				/// <java-name>
				/// unflattenFromString
				/// </java-name>
				[Dot42.DexImport("unflattenFromString", "(Ljava/lang/String;)Landroid/content/ComponentName;", AccessFlags = 9)]
				public static global::Android.Content.ComponentName UnflattenFromString(string str) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.ComponentName);
				}

				/// <summary>
				///  <para>Return string representation of this class without the class's name as a prefix. </para>        
				/// </summary>
				/// <java-name>
				/// toShortString
				/// </java-name>
				[Dot42.DexImport("toShortString", "()Ljava/lang/String;", AccessFlags = 1)]
				public string ToShortString() /* MethodBuilder.Create */ 
				{
						return default(string);
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
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object obj) /* MethodBuilder.Create */ 
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
				/// compareTo
				/// </java-name>
				[Dot42.DexImport("compareTo", "(Landroid/content/ComponentName;)I", AccessFlags = 1)]
				public int CompareTo(global::Android.Content.ComponentName that) /* MethodBuilder.Create */ 
				{
						return default(int);
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
				///  <para>Flatten this object in to a Parcel.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/content/ComponentName;Landroid/os/Parcel;)V", AccessFlags = 9)]
				public static void WriteToParcel(global::Android.Content.ComponentName dest, global::Android.OS.Parcel flags) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Read a ComponentName from a Parcel that was previously written with writeToParcel(ComponentName, Parcel), returning either a null or new object as appropriate.</para> <para> <para>writeToParcel(ComponentName, Parcel) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns a new ComponentName matching the previously written object, or null if a null had been written.</para>
				/// </returns>
				/// <java-name>
				/// readFromParcel
				/// </java-name>
				[Dot42.DexImport("readFromParcel", "(Landroid/os/Parcel;)Landroid/content/ComponentName;", AccessFlags = 9)]
				public static global::Android.Content.ComponentName ReadFromParcel(global::Android.OS.Parcel @in) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.ComponentName);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal ComponentName() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Return the package name of this component. </para>        
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
				///  <para>Return the class name of this component. </para>        
				/// </summary>
				/// <java-name>
				/// getClassName
				/// </java-name>
				public string ClassName
				{
						[Dot42.DexImport("getClassName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>Return the class name, either fully qualified or in a shortened form (with a leading '.') if it is a suffix of the package. </para>        
				/// </summary>
				/// <java-name>
				/// getShortClassName
				/// </java-name>
				public string ShortClassName
				{
						[Dot42.DexImport("getShortClassName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

		}

		/// <summary>
		///  <para>Content providers are one of the primary building blocks of Android applications, providing content to applications. They encapsulate data and provide it to applications through the single ContentResolver interface. A content provider is only required if you need to share data between multiple applications. For example, the contacts data is used by multiple applications and must be stored in a content provider. If you don't need to share data amongst multiple applications you can use a database directly via android.database.sqlite.SQLiteDatabase.</para> <para>When a request is made via a ContentResolver the system inspects the authority of the given URI and passes the request to the content provider registered with the authority. The content provider can interpret the rest of the URI however it wants. The UriMatcher class is helpful for parsing URIs.</para> <para>The primary methods that need to be implemented are:  <ul> <li> <para>onCreate which is called to initialize the provider </para></li> <li> <para>query which returns data to the caller </para></li> <li> <para>insert which inserts new data into the content provider </para></li> <li> <para>update which updates existing data in the content provider </para></li> <li> <para>delete which deletes data from the content provider </para></li> <li> <para>getType which returns the MIME type of data in the content provider </para></li></ul></para> <para>Data access methods (such as insert and update) may be called from many threads at once, and must be thread-safe. Other methods (such as onCreate) are only called from the application main thread, and must avoid performing lengthy operations. See the method descriptions for their expected thread behavior.</para> <para>Requests to ContentResolver are automatically forwarded to the appropriate ContentProvider instance, so subclasses don't have to worry about the details of cross-process calls.</para> <para>  <h3>Developer Guides</h3></para> <para> </para> <para>For more information about using content providers, read the  developer guide.</para> <para> </para>    
		/// </summary>
		/// <java-name>
		/// android/content/ContentProvider
		/// </java-name>
		[Dot42.DexImport("android/content/ContentProvider", AccessFlags = 1057)]
		public abstract partial class ContentProvider : global::Android.Content.IComponentCallbacks
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Construct a ContentProvider instance. Content providers must be , accessed with ContentResolver, and created automatically by the system, so applications usually do not create ContentProvider instances directly.</para> <para>At construction time, the object is uninitialized, and most fields and methods are unavailable. Subclasses should initialize themselves in onCreate, not the constructor.</para> <para>Content providers are created on the application main thread at application launch time. The constructor must not perform lengthy operations, or application startup will be delayed. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ContentProvider() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Change the permission required to read data from the content provider. This is normally set for you from its manifest information when the provider is first created.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setReadPermission
				/// </java-name>
				[Dot42.DexImport("setReadPermission", "(Ljava/lang/String;)V", AccessFlags = 20)]
				protected internal void SetReadPermission(string permission) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Change the permission required to read and write data in the content provider. This is normally set for you from its manifest information when the provider is first created.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setWritePermission
				/// </java-name>
				[Dot42.DexImport("setWritePermission", "(Ljava/lang/String;)V", AccessFlags = 20)]
				protected internal void SetWritePermission(string permission) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Change the path-based permission required to read and/or write data in the content provider. This is normally set for you from its manifest information when the provider is first created.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setPathPermissions
				/// </java-name>
				[Dot42.DexImport("setPathPermissions", "([Landroid/content/pm/PathPermission;)V", AccessFlags = 20)]
				protected internal void SetPathPermissions(global::Android.Content.PM.PathPermission[] permissions) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Implement this to initialize your content provider on startup. This method is called for all registered content providers on the application main thread at application launch time. It must not perform lengthy operations, or application startup will be delayed.</para> <para>You should defer nontrivial initialization (such as opening, upgrading, and scanning databases) until the content provider is used (via query, insert, etc). Deferred initialization keeps application startup fast, avoids unnecessary work if the provider turns out not to be needed, and stops database errors (such as a full disk) from halting application launch.</para> <para>If you use SQLite, android.database.sqlite.SQLiteOpenHelper is a helpful utility class that makes it easy to manage databases, and will automatically defer opening until first use. If you do use SQLiteOpenHelper, make sure to avoid calling android.database.sqlite.SQLiteOpenHelper#getReadableDatabase or android.database.sqlite.SQLiteOpenHelper#getWritableDatabase from this method. (Instead, override android.database.sqlite.SQLiteOpenHelper#onOpen to initialize the database when it is first opened.)</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if the provider was successfully loaded, false otherwise </para>
				/// </returns>
				/// <java-name>
				/// onCreate
				/// </java-name>
				[Dot42.DexImport("onCreate", "()Z", AccessFlags = 1025)]
				public abstract bool OnCreate() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para> <para>Called by the system when the device configuration changes while your component is running. Note that, unlike activities, other components are never restarted when a configuration changes: they must always deal with the results of the change, such as by re-retrieving resources.</para> <para>At the time that this function has been called, your Resources object will have been updated to return resource values matching the new configuration.</para> <para>For more information, read .</para> <para></para> This method is always called on the application main thread, and must not perform lengthy operations.</para> <para>The default content provider implementation does nothing. Override this method to take appropriate action. (Content providers do not usually care about things like screen orientation, but may want to know about locale changes.) </para>        
				/// </summary>
				/// <java-name>
				/// onConfigurationChanged
				/// </java-name>
				[Dot42.DexImport("onConfigurationChanged", "(Landroid/content/res/Configuration;)V", AccessFlags = 1)]
				public virtual void OnConfigurationChanged(global::Android.Content.Res.Configuration newConfig) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para> <para>This is called when the overall system is running low on memory, and actively running processes should trim their memory usage. While the exact point at which this will be called is not defined, generally it will happen when all background process have been killed. That is, before reaching the point of killing processes hosting service and foreground UI that we would like to avoid killing.</para> <para>You should implement this method to release any caches or other unnecessary resources you may be holding on to. The system will perform a garbage collection for you after returning from this method. </para> <para>Preferably, you should implement ComponentCallbacks2#onTrimMemory from ComponentCallbacks2 to incrementally unload your resources based on various levels of memory demands. That API is available for API level 14 and higher, so you should only use this onLowMemory method as a fallback for older versions, which can be treated the same as ComponentCallbacks2#onTrimMemory with the ComponentCallbacks2#TRIM_MEMORY_COMPLETE level.</para> This method is always called on the application main thread, and must not perform lengthy operations.</para> <para>The default content provider implementation does nothing. Subclasses may override this method to take appropriate action. </para>        
				/// </summary>
				/// <java-name>
				/// onLowMemory
				/// </java-name>
				[Dot42.DexImport("onLowMemory", "()V", AccessFlags = 1)]
				public virtual void OnLowMemory() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Implement this to handle query requests from clients. This method can be called from multiple threads, as described in . </para> <para>Example client call:</para> <para> <pre>// Request a specific record.
				/// Cursor managedCursor = managedQuery(
				///          ContentUris.withAppendedId(Contacts.People.CONTENT_URI, 2),
				///          projection,    // Which columns to return.
				///          null,          // WHERE clause.
				///          null,          // WHERE clause value substitution
				///          People.NAME + " ASC");   // Sort order.</pre> Example implementation:</para> <para> <pre>// SQLiteQueryBuilder is a helper class that creates the
				///  // proper SQL syntax for us.
				///  SQLiteQueryBuilder qBuilder = new SQLiteQueryBuilder();</pre></para> <para> <pre> // Set the table we're querying.
				///  qBuilder.setTables(DATABASE_TABLE_NAME);</pre></para> <para> <pre> // If the query ends in a specific record number, we're
				///  // being asked for a specific record, so set the
				///  // WHERE clause in our query.
				///  if((URI_MATCHER.match(uri)) == SPECIFIC_MESSAGE){
				///      qBuilder.appendWhere("_id=" + uri.getPathLeafId());
				///  }</pre></para> <para> <pre> // Make the query.
				///  Cursor c = qBuilder.query(mDb,
				///          projection,
				///          selection,
				///          selectionArgs,
				///          groupBy,
				///          having,
				///          sortOrder);
				///  c.setNotificationUri(getContext().getContentResolver(), uri);
				///  return c;</pre></para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a Cursor or <c>null </c> . </para>
				/// </returns>
				/// <java-name>
				/// query
				/// </java-name>
				[Dot42.DexImport("query", "(Landroid/net/Uri;[Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/l" +
    "ang/String;)Landroid/database/Cursor;", AccessFlags = 1025)]
				public abstract global::Android.Database.ICursor Query(global::Android.Net.Uri uri, string[] projection, string selection, string[] selectionArgs, string sortOrder) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Implement this to handle requests for the MIME type of the data at the given URI. The returned MIME type should start with  <code>vnd.android.cursor.item</code> for a single record, or  <code>vnd.android.cursor.dir/</code> for multiple items. This method can be called from multiple threads, as described in .</para> <para>Note that there are no permissions needed for an application to access this information; if your content provider requires read and/or write permissions, or is not exported, all applications can still call this method regardless of their access permissions. This allows them to retrieve the MIME type for a URI when dispatching intents.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a MIME type string, or <c>null </c> if there is no type. </para>
				/// </returns>
				/// <java-name>
				/// getType
				/// </java-name>
				[Dot42.DexImport("getType", "(Landroid/net/Uri;)Ljava/lang/String;", AccessFlags = 1025)]
				public abstract string GetType(global::Android.Net.Uri uri) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Implement this to handle requests to insert a new row. As a courtesy, call notifyChange() after inserting. This method can be called from multiple threads, as described in . </para>        
				/// </summary>
				/// <returns>
				///  <para>The URI for the newly inserted item. </para>
				/// </returns>
				/// <java-name>
				/// insert
				/// </java-name>
				[Dot42.DexImport("insert", "(Landroid/net/Uri;Landroid/content/ContentValues;)Landroid/net/Uri;", AccessFlags = 1025)]
				public abstract global::Android.Net.Uri Insert(global::Android.Net.Uri uri, global::Android.Content.ContentValues values) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Override this to handle requests to insert a set of new rows, or the default implementation will iterate over the values and call insert on each of them. As a courtesy, call notifyChange() after inserting. This method can be called from multiple threads, as described in .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The number of values that were inserted. </para>
				/// </returns>
				/// <java-name>
				/// bulkInsert
				/// </java-name>
				[Dot42.DexImport("bulkInsert", "(Landroid/net/Uri;[Landroid/content/ContentValues;)I", AccessFlags = 1)]
				public virtual int BulkInsert(global::Android.Net.Uri uri, global::Android.Content.ContentValues[] values) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Implement this to handle requests to delete one or more rows. The implementation should apply the selection clause when performing deletion, allowing the operation to affect multiple rows in a directory. As a courtesy, call notifyDelete() after deleting. This method can be called from multiple threads, as described in .</para> <para>The implementation is responsible for parsing out a row ID at the end of the URI, if a specific row is being deleted. That is, the client would pass in  <code>content://contacts/people/22</code> and the implementation is responsible for parsing the record number (22) when creating a SQL statement.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The number of rows affected. </para>
				/// </returns>
				/// <java-name>
				/// delete
				/// </java-name>
				[Dot42.DexImport("delete", "(Landroid/net/Uri;Ljava/lang/String;[Ljava/lang/String;)I", AccessFlags = 1025)]
				public abstract int Delete(global::Android.Net.Uri uri, string selection, string[] selectionArgs) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Implement this to handle requests to update one or more rows. The implementation should update all rows matching the selection to set the columns according to the provided values map. As a courtesy, call notifyChange() after updating. This method can be called from multiple threads, as described in .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the number of rows affected. </para>
				/// </returns>
				/// <java-name>
				/// update
				/// </java-name>
				[Dot42.DexImport("update", "(Landroid/net/Uri;Landroid/content/ContentValues;Ljava/lang/String;[Ljava/lang/St" +
    "ring;)I", AccessFlags = 1025)]
				public abstract int Update(global::Android.Net.Uri uri, global::Android.Content.ContentValues values, string selection, string[] selectionArgs) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Override this to handle requests to open a file blob. The default implementation always throws FileNotFoundException. This method can be called from multiple threads, as described in .</para> <para>This method returns a ParcelFileDescriptor, which is returned directly to the caller. This way large data (such as images and documents) can be returned without copying the content.</para> <para>The returned ParcelFileDescriptor is owned by the caller, so it is their responsibility to close it when done. That is, the implementation of this method should create a new ParcelFileDescriptor for each call. </para> <para>If opened with the exclusive "r" or "w" modes, the returned ParcelFileDescriptor can be a pipe or socket pair to enable streaming of data. Opening with the "rw" or "rwt" modes implies a file on disk that supports seeking. </para> <para>If you need to detect when the returned ParcelFileDescriptor has been closed, or if the remote process has crashed or encountered some other error, you can use int, android.os.Handler, android.os.ParcelFileDescriptor.OnCloseListener), ParcelFileDescriptor#createReliablePipe(), or ParcelFileDescriptor#createReliableSocketPair().</para> <para>For use in Intents, you will want to implement getType to return the appropriate MIME type for the data returned here with the same URI. This will allow intent resolution to automatically determine the data MIME type and select the appropriate matching targets as part of its operation.</para> <para>For better interoperability with other applications, it is recommended that for any URIs that can be opened, you also support queries on them containing at least the columns specified by android.provider.OpenableColumns. You may also want to support other common columns if you have additional meta-data to supply, such as android.provider.MediaStore.MediaColumns#DATE_ADDED in android.provider.MediaStore.MediaColumns.</para> <para> <para>openAssetFile(Uri, String) </para> <para>openFileHelper(Uri, String) </para> <para>getType(android.net.Uri) </para> <para>ParcelFileDescriptor::parseMode(String) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns a new ParcelFileDescriptor which you can use to access the file.</para>
				/// </returns>
				/// <java-name>
				/// openFile
				/// </java-name>
				[Dot42.DexImport("openFile", "(Landroid/net/Uri;Ljava/lang/String;)Landroid/os/ParcelFileDescriptor;", AccessFlags = 1)]
				public virtual global::Android.OS.ParcelFileDescriptor OpenFile(global::Android.Net.Uri uri, string mode) /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.ParcelFileDescriptor);
				}

				/// <summary>
				///  <para>This is like openFile, but can be implemented by providers that need to be able to return sub-sections of files, often assets inside of their .apk. This method can be called from multiple threads, as described in .</para> <para>If you implement this, your clients must be able to deal with such file slices, either directly with ContentResolver#openAssetFileDescriptor, or by using the higher-level ContentResolver.openInputStream or ContentResolver.openOutputStream methods. </para> <para>The returned AssetFileDescriptor can be a pipe or socket pair to enable streaming of data.</para> <para>If you are implementing this to return a full file, you should create the AssetFileDescriptor with AssetFileDescriptor#UNKNOWN_LENGTH to be compatible with applications that cannot handle sub-sections of files.</para> <para>For use in Intents, you will want to implement getType to return the appropriate MIME type for the data returned here with the same URI. This will allow intent resolution to automatically determine the data MIME type and select the appropriate matching targets as part of its operation.</para> <para>For better interoperability with other applications, it is recommended that for any URIs that can be opened, you also support queries on them containing at least the columns specified by android.provider.OpenableColumns.</para> <para> <para>openFile(Uri, String) </para> <para>openFileHelper(Uri, String) </para> <para>getType(android.net.Uri) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns a new AssetFileDescriptor which you can use to access the file.</para>
				/// </returns>
				/// <java-name>
				/// openAssetFile
				/// </java-name>
				[Dot42.DexImport("openAssetFile", "(Landroid/net/Uri;Ljava/lang/String;)Landroid/content/res/AssetFileDescriptor;", AccessFlags = 1)]
				public virtual global::Android.Content.Res.AssetFileDescriptor OpenAssetFile(global::Android.Net.Uri uri, string mode) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Res.AssetFileDescriptor);
				}

				/// <summary>
				///  <para>Convenience for subclasses that wish to implement openFile by looking up a column named "_data" at the given URI.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns a new ParcelFileDescriptor that can be used by the client to access the file. </para>
				/// </returns>
				/// <java-name>
				/// openFileHelper
				/// </java-name>
				[Dot42.DexImport("openFileHelper", "(Landroid/net/Uri;Ljava/lang/String;)Landroid/os/ParcelFileDescriptor;", AccessFlags = 20)]
				protected internal global::Android.OS.ParcelFileDescriptor OpenFileHelper(global::Android.Net.Uri uri, string mode) /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.ParcelFileDescriptor);
				}

				/// <summary>
				///  <para>Called by a client to determine the types of data streams that this content provider supports for the given URI. The default implementation returns <c>null </c> , meaning no types. If your content provider stores data of a particular type, return that MIME type if it matches the given mimeTypeFilter. If it can perform type conversions, return an array of all supported MIME types that match mimeTypeFilter.</para> <para> <para>getType(Uri) </para> <para>openTypedAssetFile(Uri, String, Bundle) </para> <para>ClipDescription::compareMimeTypes(String, String) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns <c>null </c> if there are no possible data streams for the given mimeTypeFilter. Otherwise returns an array of all available concrete MIME types.</para>
				/// </returns>
				/// <java-name>
				/// getStreamTypes
				/// </java-name>
				[Dot42.DexImport("getStreamTypes", "(Landroid/net/Uri;Ljava/lang/String;)[Ljava/lang/String;", AccessFlags = 1)]
				public virtual string[] GetStreamTypes(global::Android.Net.Uri uri, string mimeTypeFilter) /* MethodBuilder.Create */ 
				{
						return default(string[]);
				}

				/// <summary>
				///  <para>Called by a client to open a read-only stream containing data of a particular MIME type. This is like openAssetFile(Uri, String), except the file can only be read-only and the content provider may perform data conversions to generate data of the desired type.</para> <para>The default implementation compares the given mimeType against the result of getType(Uri) and, if they match, simply calls openAssetFile(Uri, String).</para> <para>See ClipData for examples of the use and implementation of this method. </para> <para>The returned AssetFileDescriptor can be a pipe or socket pair to enable streaming of data.</para> <para>For better interoperability with other applications, it is recommended that for any URIs that can be opened, you also support queries on them containing at least the columns specified by android.provider.OpenableColumns. You may also want to support other common columns if you have additional meta-data to supply, such as android.provider.MediaStore.MediaColumns#DATE_ADDED in android.provider.MediaStore.MediaColumns.</para> <para> <para>getStreamTypes(Uri, String) </para> <para>openAssetFile(Uri, String) </para> <para>ClipDescription::compareMimeTypes(String, String) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns a new AssetFileDescriptor from which the client can read data of the desired type.</para>
				/// </returns>
				/// <java-name>
				/// openTypedAssetFile
				/// </java-name>
				[Dot42.DexImport("openTypedAssetFile", "(Landroid/net/Uri;Ljava/lang/String;Landroid/os/Bundle;)Landroid/content/res/Asse" +
    "tFileDescriptor;", AccessFlags = 1)]
				public virtual global::Android.Content.Res.AssetFileDescriptor OpenTypedAssetFile(global::Android.Net.Uri uri, string mimeTypeFilter, global::Android.OS.Bundle opts) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Res.AssetFileDescriptor);
				}

				/// <summary>
				///  <para>A helper function for implementing openTypedAssetFile, for creating a data pipe and background thread allowing you to stream generated data back to the client. This function returns a new ParcelFileDescriptor that should be returned to the caller (the caller is responsible for closing it).</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns a new ParcelFileDescriptor holding the read side of the pipe. This should be returned to the caller for reading; the caller is responsible for closing it when done. </para>
				/// </returns>
				/// <java-name>
				/// openPipeHelper
				/// </java-name>
				[Dot42.DexImport("openPipeHelper", "(Landroid/net/Uri;Ljava/lang/String;Landroid/os/Bundle;Ljava/lang/Object;Landroid" +
    "/content/ContentProvider$PipeDataWriter;)Landroid/os/ParcelFileDescriptor;", AccessFlags = 1, Signature = "<T:Ljava/lang/Object;>(Landroid/net/Uri;Ljava/lang/String;Landroid/os/Bundle;TT;L" +
    "android/content/ContentProvider$PipeDataWriter<TT;>;)Landroid/os/ParcelFileDescr" +
    "iptor;")]
				public virtual global::Android.OS.ParcelFileDescriptor OpenPipeHelper<T>(global::Android.Net.Uri uri, string mimeType, global::Android.OS.Bundle opts, T args, global::Android.Content.ContentProvider.IPipeDataWriter<T> func) /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.ParcelFileDescriptor);
				}

				/// <summary>
				///  <para>After being instantiated, this is called to tell the content provider about itself.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// attachInfo
				/// </java-name>
				[Dot42.DexImport("attachInfo", "(Landroid/content/Context;Landroid/content/pm/ProviderInfo;)V", AccessFlags = 1)]
				public virtual void AttachInfo(global::Android.Content.Context context, global::Android.Content.PM.ProviderInfo info) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Override this to handle requests to perform a batch of operations, or the default implementation will iterate over the operations and call ContentProviderOperation#apply on each of them. If all calls to ContentProviderOperation#apply succeed then a ContentProviderResult array with as many elements as there were operations will be returned. If any of the calls fail, it is up to the implementation how many of the others take effect. This method can be called from multiple threads, as described in .</para> <para> <para>ContentProviderOperation::apply </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the results of the applications </para>
				/// </returns>
				/// <java-name>
				/// applyBatch
				/// </java-name>
				[Dot42.DexImport("applyBatch", "(Ljava/util/ArrayList;)[Landroid/content/ContentProviderResult;", AccessFlags = 1, Signature = "(Ljava/util/ArrayList<Landroid/content/ContentProviderOperation;>;)[Landroid/cont" +
    "ent/ContentProviderResult;")]
				public virtual global::Android.Content.ContentProviderResult[] ApplyBatch(global::Java.Util.ArrayList<global::Android.Content.ContentProviderOperation> operations) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.ContentProviderResult[]);
				}

				/// <summary>
				///  <para>Call a provider-defined method. This can be used to implement interfaces that are cheaper and/or unnatural for a table-like model.</para> <para> <b>WARNING:</b> The framework does no permission checking on this entry into the content provider besides the basic ability for the application to get access to the provider at all. For example, it has no idea whether the call being executed may read or write data in the provider, so can't enforce those individual permissions. Any implementation of this method  <b>must</b> do its own permission checks on incoming calls to make sure they are allowed.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>provider-defined return value. May be <c>null </c> , which is also the default for providers which don't implement any call methods. </para>
				/// </returns>
				/// <java-name>
				/// call
				/// </java-name>
				[Dot42.DexImport("call", "(Ljava/lang/String;Ljava/lang/String;Landroid/os/Bundle;)Landroid/os/Bundle;", AccessFlags = 1)]
				public virtual global::Android.OS.Bundle Call(string method, string arg, global::Android.OS.Bundle extras) /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.Bundle);
				}

				/// <summary>
				///  <para>Implement this to shut down the ContentProvider instance. You can then invoke this method in unit tests.</para> <para>Android normally handles ContentProvider startup and shutdown automatically. You do not need to start up or shut down a ContentProvider. When you invoke a test method on a ContentProvider, however, a ContentProvider instance is started and keeps running after the test finishes, even if a succeeding test instantiates another ContentProvider. A conflict develops because the two instances are usually running against the same underlying data source (for example, an sqlite database). </para> <para>Implementing shutDown() avoids this conflict by providing a way to terminate the ContentProvider. This method can also prevent memory leaks from multiple instantiations of the ContentProvider, and it can ensure unit test isolation by allowing you to completely clean up the test fixture before moving on to the next test. </para>        
				/// </summary>
				/// <java-name>
				/// shutdown
				/// </java-name>
				[Dot42.DexImport("shutdown", "()V", AccessFlags = 1)]
				public virtual void Shutdown() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Retrieves the Context this provider is running in. Only available once onCreate has been called  this will return <c>null </c> in the constructor. </para>        
				/// </summary>
				/// <java-name>
				/// getContext
				/// </java-name>
				public global::Android.Content.Context Context
				{
						[Dot42.DexImport("getContext", "()Landroid/content/Context;", AccessFlags = 17)]
						get{ return default(global::Android.Content.Context); }
				}

				/// <summary>
				///  <para>Return the name of the permission required for read-only access to this content provider. This method can be called from multiple threads, as described in . </para>        
				/// </summary>
				/// <java-name>
				/// getReadPermission
				/// </java-name>
				public string ReadPermission
				{
						[Dot42.DexImport("getReadPermission", "()Ljava/lang/String;", AccessFlags = 17)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>Return the name of the permission required for read/write access to this content provider. This method can be called from multiple threads, as described in . </para>        
				/// </summary>
				/// <java-name>
				/// getWritePermission
				/// </java-name>
				public string WritePermission
				{
						[Dot42.DexImport("getWritePermission", "()Ljava/lang/String;", AccessFlags = 17)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>Return the path-based permissions required for read and/or write access to this content provider. This method can be called from multiple threads, as described in . </para>        
				/// </summary>
				/// <java-name>
				/// getPathPermissions
				/// </java-name>
				public global::Android.Content.PM.PathPermission[] PathPermissions
				{
						[Dot42.DexImport("getPathPermissions", "()[Landroid/content/pm/PathPermission;", AccessFlags = 17)]
						get{ return default(global::Android.Content.PM.PathPermission[]); }
				}

				/// <summary>
				///  <para>Returns true if this instance is a temporary content provider. </para>        
				/// </summary>
				/// <returns>
				///  <para>true if this instance is a temporary content provider </para>
				/// </returns>
				/// <java-name>
				/// isTemporary
				/// </java-name>
				protected internal virtual bool IsTemporary
				{
						[Dot42.DexImport("isTemporary", "()Z", AccessFlags = 4)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Interface to write a stream of data to a pipe. Use with ContentProvider#openPipeHelper. </para>    
				/// </summary>
				/// <java-name>
				/// android/content/ContentProvider$PipeDataWriter
				/// </java-name>
				[Dot42.DexImport("android/content/ContentProvider$PipeDataWriter", AccessFlags = 1545, Signature = "<T:Ljava/lang/Object;>Ljava/lang/Object;")]
				public partial interface IPipeDataWriter<T>
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>Called from a background thread to stream data out to a pipe. Note that the pipe is blocking, so this thread can block on writes for an arbitrary amount of time if the client is slow at reading.</para> <para></para>        
						/// </summary>
						/// <java-name>
						/// writeDataToPipe
						/// </java-name>
						[Dot42.DexImport("writeDataToPipe", "(Landroid/os/ParcelFileDescriptor;Landroid/net/Uri;Ljava/lang/String;Landroid/os/" +
    "Bundle;Ljava/lang/Object;)V", AccessFlags = 1025, Signature = "(Landroid/os/ParcelFileDescriptor;Landroid/net/Uri;Ljava/lang/String;Landroid/os/" +
    "Bundle;TT;)V")]
						void WriteDataToPipe(global::Android.OS.ParcelFileDescriptor output, global::Android.Net.Uri uri, string mimeType, global::Android.OS.Bundle opts, T args) /* MethodBuilder.Create */ ;

				}

		}

		/// <summary>
		///  <para>The public interface object used to interact with a ContentProvider. This is obtained by calling ContentResolver#acquireContentProviderClient. This object must be released using release in order to indicate to the system that the ContentProvider is no longer needed and can be killed to free up resources.</para> <para>Note that you should generally create a new ContentProviderClient instance for each thread that will be performing operations. Unlike ContentResolver, the methods here such as query and openFile are not thread safe  you must not call release() on the ContentProviderClient those calls are made from until you are finished with the data they have returned. </para>    
		/// </summary>
		/// <java-name>
		/// android/content/ContentProviderClient
		/// </java-name>
		[Dot42.DexImport("android/content/ContentProviderClient", AccessFlags = 33)]
		public partial class ContentProviderClient
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal ContentProviderClient() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>See ContentProvider.query </para>        
				/// </summary>
				/// <java-name>
				/// query
				/// </java-name>
				[Dot42.DexImport("query", "(Landroid/net/Uri;[Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/l" +
    "ang/String;)Landroid/database/Cursor;", AccessFlags = 1)]
				public virtual global::Android.Database.ICursor Query(global::Android.Net.Uri url, string[] projection, string selection, string[] selectionArgs, string sortOrder) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Database.ICursor);
				}

				/// <summary>
				///  <para>See ContentProvider.getType </para>        
				/// </summary>
				/// <java-name>
				/// getType
				/// </java-name>
				[Dot42.DexImport("getType", "(Landroid/net/Uri;)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetType(global::Android.Net.Uri url) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>See ContentProvider.getStreamTypes </para>        
				/// </summary>
				/// <java-name>
				/// getStreamTypes
				/// </java-name>
				[Dot42.DexImport("getStreamTypes", "(Landroid/net/Uri;Ljava/lang/String;)[Ljava/lang/String;", AccessFlags = 1)]
				public virtual string[] GetStreamTypes(global::Android.Net.Uri url, string mimeTypeFilter) /* MethodBuilder.Create */ 
				{
						return default(string[]);
				}

				/// <summary>
				///  <para>See ContentProvider.insert </para>        
				/// </summary>
				/// <java-name>
				/// insert
				/// </java-name>
				[Dot42.DexImport("insert", "(Landroid/net/Uri;Landroid/content/ContentValues;)Landroid/net/Uri;", AccessFlags = 1)]
				public virtual global::Android.Net.Uri Insert(global::Android.Net.Uri url, global::Android.Content.ContentValues initialValues) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Net.Uri);
				}

				/// <summary>
				///  <para>See ContentProvider.bulkInsert </para>        
				/// </summary>
				/// <java-name>
				/// bulkInsert
				/// </java-name>
				[Dot42.DexImport("bulkInsert", "(Landroid/net/Uri;[Landroid/content/ContentValues;)I", AccessFlags = 1)]
				public virtual int BulkInsert(global::Android.Net.Uri url, global::Android.Content.ContentValues[] initialValues) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>See ContentProvider.delete </para>        
				/// </summary>
				/// <java-name>
				/// delete
				/// </java-name>
				[Dot42.DexImport("delete", "(Landroid/net/Uri;Ljava/lang/String;[Ljava/lang/String;)I", AccessFlags = 1)]
				public virtual int Delete(global::Android.Net.Uri url, string selection, string[] selectionArgs) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>See ContentProvider.update </para>        
				/// </summary>
				/// <java-name>
				/// update
				/// </java-name>
				[Dot42.DexImport("update", "(Landroid/net/Uri;Landroid/content/ContentValues;Ljava/lang/String;[Ljava/lang/St" +
    "ring;)I", AccessFlags = 1)]
				public virtual int Update(global::Android.Net.Uri url, global::Android.Content.ContentValues values, string selection, string[] selectionArgs) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>See ContentProvider.openFile. Note that this  <b>does not</b> take care of non-content: URIs such as  It is strongly recommended you use the ContentResolver.openFileDescriptor API instead. </para>        
				/// </summary>
				/// <java-name>
				/// openFile
				/// </java-name>
				[Dot42.DexImport("openFile", "(Landroid/net/Uri;Ljava/lang/String;)Landroid/os/ParcelFileDescriptor;", AccessFlags = 1)]
				public virtual global::Android.OS.ParcelFileDescriptor OpenFile(global::Android.Net.Uri url, string mode) /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.ParcelFileDescriptor);
				}

				/// <summary>
				///  <para>See ContentProvider.openAssetFile. Note that this  <b>does not</b> take care of non-content: URIs such as  It is strongly recommended you use the ContentResolver.openAssetFileDescriptor API instead. </para>        
				/// </summary>
				/// <java-name>
				/// openAssetFile
				/// </java-name>
				[Dot42.DexImport("openAssetFile", "(Landroid/net/Uri;Ljava/lang/String;)Landroid/content/res/AssetFileDescriptor;", AccessFlags = 1)]
				public virtual global::Android.Content.Res.AssetFileDescriptor OpenAssetFile(global::Android.Net.Uri url, string mode) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Res.AssetFileDescriptor);
				}

				/// <summary>
				///  <para>See ContentProvider.openTypedAssetFile </para>        
				/// </summary>
				/// <java-name>
				/// openTypedAssetFileDescriptor
				/// </java-name>
				[Dot42.DexImport("openTypedAssetFileDescriptor", "(Landroid/net/Uri;Ljava/lang/String;Landroid/os/Bundle;)Landroid/content/res/Asse" +
    "tFileDescriptor;", AccessFlags = 17)]
				public global::Android.Content.Res.AssetFileDescriptor OpenTypedAssetFileDescriptor(global::Android.Net.Uri uri, string mimeType, global::Android.OS.Bundle opts) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Res.AssetFileDescriptor);
				}

				/// <summary>
				///  <para>See ContentProvider.applyBatch </para>        
				/// </summary>
				/// <java-name>
				/// applyBatch
				/// </java-name>
				[Dot42.DexImport("applyBatch", "(Ljava/util/ArrayList;)[Landroid/content/ContentProviderResult;", AccessFlags = 1, Signature = "(Ljava/util/ArrayList<Landroid/content/ContentProviderOperation;>;)[Landroid/cont" +
    "ent/ContentProviderResult;")]
				public virtual global::Android.Content.ContentProviderResult[] ApplyBatch(global::Java.Util.ArrayList<global::Android.Content.ContentProviderOperation> operations) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.ContentProviderResult[]);
				}

				/// <summary>
				///  <para>Call this to indicate to the system that the associated ContentProvider is no longer needed by this ContentProviderClient. </para>        
				/// </summary>
				/// <returns>
				///  <para>true if this was release, false if it was already released </para>
				/// </returns>
				/// <java-name>
				/// release
				/// </java-name>
				[Dot42.DexImport("release", "()Z", AccessFlags = 1)]
				public virtual bool Release() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Get a reference to the ContentProvider that is associated with this client. If the ContentProvider is running in a different process then null will be returned. This can be used if you know you are running in the same process as a provider, and want to get direct access to its implementation details.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>If the associated ContentProvider is local, returns it. Otherwise returns null. </para>
				/// </returns>
				/// <java-name>
				/// getLocalContentProvider
				/// </java-name>
				public virtual global::Android.Content.ContentProvider LocalContentProvider
				{
						[Dot42.DexImport("getLocalContentProvider", "()Landroid/content/ContentProvider;", AccessFlags = 1)]
						get{ return default(global::Android.Content.ContentProvider); }
				}

		}

		/// <java-name>
		/// android/content/ContentProviderOperation
		/// </java-name>
		[Dot42.DexImport("android/content/ContentProviderOperation", AccessFlags = 33)]
		public partial class ContentProviderOperation : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.Content.ContentProviderOperation> CREATOR;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal ContentProviderOperation() /* MethodBuilder.Create */ 
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
				///  <para>Create a Builder suitable for building an insert ContentProviderOperation. </para>        
				/// </summary>
				/// <returns>
				///  <para>a Builder </para>
				/// </returns>
				/// <java-name>
				/// newInsert
				/// </java-name>
				[Dot42.DexImport("newInsert", "(Landroid/net/Uri;)Landroid/content/ContentProviderOperation$Builder;", AccessFlags = 9)]
				public static global::Android.Content.ContentProviderOperation.Builder NewInsert(global::Android.Net.Uri uri) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.ContentProviderOperation.Builder);
				}

				/// <summary>
				///  <para>Create a Builder suitable for building an update ContentProviderOperation. </para>        
				/// </summary>
				/// <returns>
				///  <para>a Builder </para>
				/// </returns>
				/// <java-name>
				/// newUpdate
				/// </java-name>
				[Dot42.DexImport("newUpdate", "(Landroid/net/Uri;)Landroid/content/ContentProviderOperation$Builder;", AccessFlags = 9)]
				public static global::Android.Content.ContentProviderOperation.Builder NewUpdate(global::Android.Net.Uri uri) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.ContentProviderOperation.Builder);
				}

				/// <summary>
				///  <para>Create a Builder suitable for building a delete ContentProviderOperation. </para>        
				/// </summary>
				/// <returns>
				///  <para>a Builder </para>
				/// </returns>
				/// <java-name>
				/// newDelete
				/// </java-name>
				[Dot42.DexImport("newDelete", "(Landroid/net/Uri;)Landroid/content/ContentProviderOperation$Builder;", AccessFlags = 9)]
				public static global::Android.Content.ContentProviderOperation.Builder NewDelete(global::Android.Net.Uri uri) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.ContentProviderOperation.Builder);
				}

				/// <summary>
				///  <para>Create a Builder suitable for building a ContentProviderOperation to assert a set of values as provided through Builder#withValues(ContentValues). </para>        
				/// </summary>
				/// <java-name>
				/// newAssertQuery
				/// </java-name>
				[Dot42.DexImport("newAssertQuery", "(Landroid/net/Uri;)Landroid/content/ContentProviderOperation$Builder;", AccessFlags = 9)]
				public static global::Android.Content.ContentProviderOperation.Builder NewAssertQuery(global::Android.Net.Uri uri) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.ContentProviderOperation.Builder);
				}

				/// <summary>
				///  <para>Applies this operation using the given provider. The backRefs array is used to resolve any back references that were requested using Builder#withValueBackReferences(ContentValues) and Builder#withSelectionBackReference. </para>        
				/// </summary>
				/// <returns>
				///  <para>a ContentProviderResult that contains either the Uri of the inserted row if this was an insert otherwise the number of rows affected. </para>
				/// </returns>
				/// <java-name>
				/// apply
				/// </java-name>
				[Dot42.DexImport("apply", "(Landroid/content/ContentProvider;[Landroid/content/ContentProviderResult;I)Landr" +
    "oid/content/ContentProviderResult;", AccessFlags = 1)]
				public virtual global::Android.Content.ContentProviderResult Apply(global::Android.Content.ContentProvider provider, global::Android.Content.ContentProviderResult[] backRefs, int numBackRefs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.ContentProviderResult);
				}

				/// <summary>
				///  <para>The ContentValues back references are represented as a ContentValues object where the key refers to a column and the value is an index of the back reference whose valued should be associated with the column. </para> <para>This is intended to be a private method but it is exposed for unit testing purposes </para>        
				/// </summary>
				/// <returns>
				///  <para>the ContentValues that should be used in this operation application after expansion of back references. This can be called if either mValues or mValuesBackReferences is null </para>
				/// </returns>
				/// <java-name>
				/// resolveValueBackReferences
				/// </java-name>
				[Dot42.DexImport("resolveValueBackReferences", "([Landroid/content/ContentProviderResult;I)Landroid/content/ContentValues;", AccessFlags = 1)]
				public virtual global::Android.Content.ContentValues ResolveValueBackReferences(global::Android.Content.ContentProviderResult[] backRefs, int numBackRefs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.ContentValues);
				}

				/// <summary>
				///  <para>The Selection Arguments back references are represented as a Map of Integer-&gt;Integer where the key is an index into the selection argument array (see Builder#withSelection) and the value is the index of the previous result that should be used for that selection argument array slot. </para> <para>This is intended to be a private method but it is exposed for unit testing purposes </para>        
				/// </summary>
				/// <returns>
				///  <para>the ContentValues that should be used in this operation application after expansion of back references. This can be called if either mValues or mValuesBackReferences is null </para>
				/// </returns>
				/// <java-name>
				/// resolveSelectionArgsBackReferences
				/// </java-name>
				[Dot42.DexImport("resolveSelectionArgsBackReferences", "([Landroid/content/ContentProviderResult;I)[Ljava/lang/String;", AccessFlags = 1)]
				public virtual string[] ResolveSelectionArgsBackReferences(global::Android.Content.ContentProviderResult[] backRefs, int numBackRefs) /* MethodBuilder.Create */ 
				{
						return default(string[]);
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
				public virtual int DescribeContents() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getUri
				/// </java-name>
				public virtual global::Android.Net.Uri Uri
				{
						[Dot42.DexImport("getUri", "()Landroid/net/Uri;", AccessFlags = 1)]
						get{ return default(global::Android.Net.Uri); }
				}

				/// <java-name>
				/// isYieldAllowed
				/// </java-name>
				public virtual bool IsYieldAllowed
				{
						[Dot42.DexImport("isYieldAllowed", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// isWriteOperation
				/// </java-name>
				public virtual bool IsWriteOperation
				{
						[Dot42.DexImport("isWriteOperation", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// isReadOperation
				/// </java-name>
				public virtual bool IsReadOperation
				{
						[Dot42.DexImport("isReadOperation", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Used to add parameters to a ContentProviderOperation. The Builder is first created by calling ContentProviderOperation#newInsert(android.net.Uri), ContentProviderOperation#newUpdate(android.net.Uri), ContentProviderOperation#newDelete(android.net.Uri) or ContentProviderOperation#newAssertQuery(Uri). The withXXX methods can then be used to add parameters to the builder. See the specific methods to find for which Builder type each is allowed. Call build to create the ContentProviderOperation once all the parameters have been supplied. </para>    
				/// </summary>
				/// <java-name>
				/// android/content/ContentProviderOperation$Builder
				/// </java-name>
				[Dot42.DexImport("android/content/ContentProviderOperation$Builder", AccessFlags = 9)]
				public partial class Builder
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
						internal Builder() /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Create a ContentProviderOperation from this Builder. </para>        
						/// </summary>
						/// <java-name>
						/// build
						/// </java-name>
						[Dot42.DexImport("build", "()Landroid/content/ContentProviderOperation;", AccessFlags = 1)]
						public virtual global::Android.Content.ContentProviderOperation Build() /* MethodBuilder.Create */ 
						{
								return default(global::Android.Content.ContentProviderOperation);
						}

						/// <summary>
						///  <para>Add a ContentValues of back references. The key is the name of the column and the value is an integer that is the index of the previous result whose value should be used for the column. The value is added as a String. A column value from the back references takes precedence over a value specified in withValues. This can only be used with builders of type insert, update, or assert. </para>        
						/// </summary>
						/// <returns>
						///  <para>this builder, to allow for chaining. </para>
						/// </returns>
						/// <java-name>
						/// withValueBackReferences
						/// </java-name>
						[Dot42.DexImport("withValueBackReferences", "(Landroid/content/ContentValues;)Landroid/content/ContentProviderOperation$Builde" +
    "r;", AccessFlags = 1)]
						public virtual Builder WithValueBackReferences(global::Android.Content.ContentValues backReferences) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <summary>
						///  <para>Add a ContentValues back reference. A column value from the back references takes precedence over a value specified in withValues. This can only be used with builders of type insert, update, or assert. </para>        
						/// </summary>
						/// <returns>
						///  <para>this builder, to allow for chaining. </para>
						/// </returns>
						/// <java-name>
						/// withValueBackReference
						/// </java-name>
						[Dot42.DexImport("withValueBackReference", "(Ljava/lang/String;I)Landroid/content/ContentProviderOperation$Builder;", AccessFlags = 1)]
						public virtual Builder WithValueBackReference(string key, int previousResult) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <summary>
						///  <para>Add a back references as a selection arg. Any value at that index of the selection arg that was specified by withSelection will be overwritten. This can only be used with builders of type update, delete, or assert. </para>        
						/// </summary>
						/// <returns>
						///  <para>this builder, to allow for chaining. </para>
						/// </returns>
						/// <java-name>
						/// withSelectionBackReference
						/// </java-name>
						[Dot42.DexImport("withSelectionBackReference", "(II)Landroid/content/ContentProviderOperation$Builder;", AccessFlags = 1)]
						public virtual Builder WithSelectionBackReference(int selectionArgIndex, int previousResult) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <summary>
						///  <para>The ContentValues to use. This may be null. These values may be overwritten by the corresponding value specified by withValueBackReference or by future calls to withValues or withValue. This can only be used with builders of type insert, update, or assert. </para>        
						/// </summary>
						/// <returns>
						///  <para>this builder, to allow for chaining. </para>
						/// </returns>
						/// <java-name>
						/// withValues
						/// </java-name>
						[Dot42.DexImport("withValues", "(Landroid/content/ContentValues;)Landroid/content/ContentProviderOperation$Builde" +
    "r;", AccessFlags = 1)]
						public virtual Builder WithValues(global::Android.Content.ContentValues values) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <summary>
						///  <para>A value to insert or update. This value may be overwritten by the corresponding value specified by withValueBackReference. This can only be used with builders of type insert, update, or assert. </para>        
						/// </summary>
						/// <returns>
						///  <para>this builder, to allow for chaining. </para>
						/// </returns>
						/// <java-name>
						/// withValue
						/// </java-name>
						[Dot42.DexImport("withValue", "(Ljava/lang/String;Ljava/lang/Object;)Landroid/content/ContentProviderOperation$B" +
    "uilder;", AccessFlags = 1)]
						public virtual Builder WithValue(string key, object value) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <summary>
						///  <para>The selection and arguments to use. An occurrence of '?' in the selection will be replaced with the corresponding occurence of the selection argument. Any of the selection arguments may be overwritten by a selection argument back reference as specified by withSelectionBackReference. This can only be used with builders of type update, delete, or assert. </para>        
						/// </summary>
						/// <returns>
						///  <para>this builder, to allow for chaining. </para>
						/// </returns>
						/// <java-name>
						/// withSelection
						/// </java-name>
						[Dot42.DexImport("withSelection", "(Ljava/lang/String;[Ljava/lang/String;)Landroid/content/ContentProviderOperation$" +
    "Builder;", AccessFlags = 1)]
						public virtual Builder WithSelection(string selection, string[] selectionArgs) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <summary>
						///  <para>If set then if the number of rows affected by this operation do not match this count OperationApplicationException will be throw. This can only be used with builders of type update, delete, or assert. </para>        
						/// </summary>
						/// <returns>
						///  <para>this builder, to allow for chaining. </para>
						/// </returns>
						/// <java-name>
						/// withExpectedCount
						/// </java-name>
						[Dot42.DexImport("withExpectedCount", "(I)Landroid/content/ContentProviderOperation$Builder;", AccessFlags = 1)]
						public virtual Builder WithExpectedCount(int count) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// withYieldAllowed
						/// </java-name>
						[Dot42.DexImport("withYieldAllowed", "(Z)Landroid/content/ContentProviderOperation$Builder;", AccessFlags = 1)]
						public virtual Builder WithYieldAllowed(bool yieldAllowed) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

				}

		}

		/// <summary>
		///  <para>Contains the result of the application of a ContentProviderOperation. It is guaranteed to have exactly one of uri or count set. </para>    
		/// </summary>
		/// <java-name>
		/// android/content/ContentProviderResult
		/// </java-name>
		[Dot42.DexImport("android/content/ContentProviderResult", AccessFlags = 33)]
		public partial class ContentProviderResult : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// uri
				/// </java-name>
				[Dot42.DexImport("uri", "Landroid/net/Uri;", AccessFlags = 17)]
				public readonly global::Android.Net.Uri Uri;
				/// <java-name>
				/// count
				/// </java-name>
				[Dot42.DexImport("count", "Ljava/lang/Integer;", AccessFlags = 17)]
				public readonly int? Count;
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.Content.ContentProviderResult> CREATOR;
				[Dot42.DexImport("<init>", "(Landroid/net/Uri;)V", AccessFlags = 1)]
				public ContentProviderResult(global::Android.Net.Uri uri) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public ContentProviderResult(int uri) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/os/Parcel;)V", AccessFlags = 1)]
				public ContentProviderResult(global::Android.OS.Parcel uri) /* MethodBuilder.Create */ 
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
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal ContentProviderResult() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		///  <para>Caches the contents of a cursor into a Map of String-&gt;ContentValues and optionally keeps the cache fresh by registering for updates on the content backing the cursor. The column of the database that is to be used as the key of the map is user-configurable, and the ContentValues contains all columns other than the one that is designated the key. </para> <para>The cursor data is accessed by row key and column name via getValue(). </para>    
		/// </summary>
		/// <java-name>
		/// android/content/ContentQueryMap
		/// </java-name>
		[Dot42.DexImport("android/content/ContentQueryMap", AccessFlags = 33)]
		public partial class ContentQueryMap : global::Java.Util.Observable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Creates a ContentQueryMap that caches the content backing the cursor</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/database/Cursor;Ljava/lang/String;ZLandroid/os/Handler;)V", AccessFlags = 1)]
				public ContentQueryMap(global::Android.Database.ICursor cursor, string columnNameOfKey, bool keepUpdated, global::Android.OS.Handler handlerForUpdateNotifications) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Change whether or not the ContentQueryMap will register with the cursor's ContentProvider for change notifications. If you use a ContentQueryMap in an activity you should call this with false in onPause(), which means you need to call it with true in onResume() if want it to be kept updated. </para>        
				/// </summary>
				/// <java-name>
				/// setKeepUpdated
				/// </java-name>
				[Dot42.DexImport("setKeepUpdated", "(Z)V", AccessFlags = 1)]
				public virtual void SetKeepUpdated(bool keepUpdated) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Access the ContentValues for the row specified by rowName </para>        
				/// </summary>
				/// <returns>
				///  <para>the ContentValues for the row, or null if the row wasn't present in the cursor </para>
				/// </returns>
				/// <java-name>
				/// getValues
				/// </java-name>
				[Dot42.DexImport("getValues", "(Ljava/lang/String;)Landroid/content/ContentValues;", AccessFlags = 33)]
				public virtual global::Android.Content.ContentValues GetValues(string rowName) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.ContentValues);
				}

				/// <summary>
				///  <para>Requeries the cursor and reads the contents into the cache </para>        
				/// </summary>
				/// <java-name>
				/// requery
				/// </java-name>
				[Dot42.DexImport("requery", "()V", AccessFlags = 1)]
				public virtual void Requery() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 33)]
				public virtual void Close() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// finalize
				/// </java-name>
				[Dot42.DexImport("finalize", "()V", AccessFlags = 4)]
				extern ~ContentQueryMap() /* MethodBuilder.Create */ ;

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal ContentQueryMap() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getRows
				/// </java-name>
				public virtual global::Java.Util.IMap<string, global::Android.Content.ContentValues> Rows
				{
						[Dot42.DexImport("getRows", "()Ljava/util/Map;", AccessFlags = 33, Signature = "()Ljava/util/Map<Ljava/lang/String;Landroid/content/ContentValues;>;")]
						get{ return default(global::Java.Util.IMap<string, global::Android.Content.ContentValues>); }
				}

		}

		/// <summary>
		///  <para>This class provides applications access to the content model.</para> <para>  <h3>Developer Guides</h3></para> <para> </para> <para>For more information about using a ContentResolver with content providers, read the  developer guide.</para> <para> </para>    
		/// </summary>
		/// <java-name>
		/// android/content/ContentResolver
		/// </java-name>
		[Dot42.DexImport("android/content/ContentResolver", AccessFlags = 1057)]
		public abstract partial class ContentResolver
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>instead use requestSync(android.accounts.Account, String, android.os.Bundle) </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// SYNC_EXTRAS_ACCOUNT
				/// </java-name>
				[Dot42.DexImport("SYNC_EXTRAS_ACCOUNT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SYNC_EXTRAS_ACCOUNT = "account";
				/// <summary>
				///  <para>If this extra is set to true, the sync request will be scheduled at the front of the sync request queue and without any delay </para>        
				/// </summary>
				/// <java-name>
				/// SYNC_EXTRAS_EXPEDITED
				/// </java-name>
				[Dot42.DexImport("SYNC_EXTRAS_EXPEDITED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SYNC_EXTRAS_EXPEDITED = "expedited";
				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>instead use SYNC_EXTRAS_MANUAL </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// SYNC_EXTRAS_FORCE
				/// </java-name>
				[Dot42.DexImport("SYNC_EXTRAS_FORCE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SYNC_EXTRAS_FORCE = "force";
				/// <summary>
				///  <para>If this extra is set to true then the sync settings (like getSyncAutomatically()) are ignored by the sync scheduler. </para>        
				/// </summary>
				/// <java-name>
				/// SYNC_EXTRAS_IGNORE_SETTINGS
				/// </java-name>
				[Dot42.DexImport("SYNC_EXTRAS_IGNORE_SETTINGS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SYNC_EXTRAS_IGNORE_SETTINGS = "ignore_settings";
				/// <summary>
				///  <para>If this extra is set to true then any backoffs for the initial attempt (e.g. due to retries) are ignored by the sync scheduler. If this request fails and gets rescheduled then the retries will still honor the backoff. </para>        
				/// </summary>
				/// <java-name>
				/// SYNC_EXTRAS_IGNORE_BACKOFF
				/// </java-name>
				[Dot42.DexImport("SYNC_EXTRAS_IGNORE_BACKOFF", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SYNC_EXTRAS_IGNORE_BACKOFF = "ignore_backoff";
				/// <summary>
				///  <para>If this extra is set to true then the request will not be retried if it fails. </para>        
				/// </summary>
				/// <java-name>
				/// SYNC_EXTRAS_DO_NOT_RETRY
				/// </java-name>
				[Dot42.DexImport("SYNC_EXTRAS_DO_NOT_RETRY", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SYNC_EXTRAS_DO_NOT_RETRY = "do_not_retry";
				/// <summary>
				///  <para>Setting this extra is the equivalent of setting both SYNC_EXTRAS_IGNORE_SETTINGS and SYNC_EXTRAS_IGNORE_BACKOFF </para>        
				/// </summary>
				/// <java-name>
				/// SYNC_EXTRAS_MANUAL
				/// </java-name>
				[Dot42.DexImport("SYNC_EXTRAS_MANUAL", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SYNC_EXTRAS_MANUAL = "force";
				/// <summary>
				///  <para>Indicates that this sync is intended to only upload local changes to the server. For example, this will be set to true if the sync is initiated by a call to ContentResolver#notifyChange(android.net.Uri, android.database.ContentObserver, boolean) </para>        
				/// </summary>
				/// <java-name>
				/// SYNC_EXTRAS_UPLOAD
				/// </java-name>
				[Dot42.DexImport("SYNC_EXTRAS_UPLOAD", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SYNC_EXTRAS_UPLOAD = "upload";
				/// <summary>
				///  <para>Indicates that the sync adapter should proceed with the delete operations, even if it determines that there are too many. See SyncResult#tooManyDeletions </para>        
				/// </summary>
				/// <java-name>
				/// SYNC_EXTRAS_OVERRIDE_TOO_MANY_DELETIONS
				/// </java-name>
				[Dot42.DexImport("SYNC_EXTRAS_OVERRIDE_TOO_MANY_DELETIONS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SYNC_EXTRAS_OVERRIDE_TOO_MANY_DELETIONS = "deletions_override";
				/// <summary>
				///  <para>Indicates that the sync adapter should not proceed with the delete operations, if it determines that there are too many. See SyncResult#tooManyDeletions </para>        
				/// </summary>
				/// <java-name>
				/// SYNC_EXTRAS_DISCARD_LOCAL_DELETIONS
				/// </java-name>
				[Dot42.DexImport("SYNC_EXTRAS_DISCARD_LOCAL_DELETIONS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SYNC_EXTRAS_DISCARD_LOCAL_DELETIONS = "discard_deletions";
				/// <summary>
				///  <para>Set by the SyncManager to request that the SyncAdapter initialize itself for the given account/authority pair. One required initialization step is to ensure that setIsSyncable(android.accounts.Account, String, int) has been called with a &gt;= 0 value. When this flag is set the SyncAdapter does not need to do a full sync, though it is allowed to do so. </para>        
				/// </summary>
				/// <java-name>
				/// SYNC_EXTRAS_INITIALIZE
				/// </java-name>
				[Dot42.DexImport("SYNC_EXTRAS_INITIALIZE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SYNC_EXTRAS_INITIALIZE = "initialize";
				/// <java-name>
				/// SCHEME_CONTENT
				/// </java-name>
				[Dot42.DexImport("SCHEME_CONTENT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SCHEME_CONTENT = "content";
				/// <java-name>
				/// SCHEME_ANDROID_RESOURCE
				/// </java-name>
				[Dot42.DexImport("SCHEME_ANDROID_RESOURCE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SCHEME_ANDROID_RESOURCE = "android.resource";
				/// <java-name>
				/// SCHEME_FILE
				/// </java-name>
				[Dot42.DexImport("SCHEME_FILE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SCHEME_FILE = "file";
				/// <summary>
				///  <para>This is the Android platform's base MIME type for a content: URI containing a Cursor of a single item. Applications should use this as the base type along with their own sub-type of their content: URIs that represent a particular item. For example, hypothetical IMAP email client may have a URI  <code>content://com.company.provider.imap/inbox/1</code> for a particular message in the inbox, whose MIME type would be reported as  <code>CURSOR_ITEM_BASE_TYPE + "/vnd.company.imap-msg"</code></para> <para>Compare with CURSOR_DIR_BASE_TYPE. </para>        
				/// </summary>
				/// <java-name>
				/// CURSOR_ITEM_BASE_TYPE
				/// </java-name>
				[Dot42.DexImport("CURSOR_ITEM_BASE_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string CURSOR_ITEM_BASE_TYPE = "vnd.android.cursor.item";
				/// <summary>
				///  <para>This is the Android platform's base MIME type for a content: URI containing a Cursor of zero or more items. Applications should use this as the base type along with their own sub-type of their content: URIs that represent a directory of items. For example, hypothetical IMAP email client may have a URI  <code>content://com.company.provider.imap/inbox</code> for all of the messages in its inbox, whose MIME type would be reported as  <code>CURSOR_DIR_BASE_TYPE + "/vnd.company.imap-msg"</code></para> <para>Note how the base MIME type varies between this and CURSOR_ITEM_BASE_TYPE depending on whether there is one single item or multiple items in the data set, while the sub-type remains the same because in either case the data structure contained in the cursor is the same. </para>        
				/// </summary>
				/// <java-name>
				/// CURSOR_DIR_BASE_TYPE
				/// </java-name>
				[Dot42.DexImport("CURSOR_DIR_BASE_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string CURSOR_DIR_BASE_TYPE = "vnd.android.cursor.dir";
				/// <java-name>
				/// SYNC_OBSERVER_TYPE_SETTINGS
				/// </java-name>
				[Dot42.DexImport("SYNC_OBSERVER_TYPE_SETTINGS", "I", AccessFlags = 25)]
				public const int SYNC_OBSERVER_TYPE_SETTINGS = 1;
				/// <java-name>
				/// SYNC_OBSERVER_TYPE_PENDING
				/// </java-name>
				[Dot42.DexImport("SYNC_OBSERVER_TYPE_PENDING", "I", AccessFlags = 25)]
				public const int SYNC_OBSERVER_TYPE_PENDING = 2;
				/// <java-name>
				/// SYNC_OBSERVER_TYPE_ACTIVE
				/// </java-name>
				[Dot42.DexImport("SYNC_OBSERVER_TYPE_ACTIVE", "I", AccessFlags = 25)]
				public const int SYNC_OBSERVER_TYPE_ACTIVE = 4;
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public ContentResolver(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Return the MIME type of the given content URL.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>A MIME type for the content, or null if the URL is invalid or the type is unknown </para>
				/// </returns>
				/// <java-name>
				/// getType
				/// </java-name>
				[Dot42.DexImport("getType", "(Landroid/net/Uri;)Ljava/lang/String;", AccessFlags = 17)]
				public string GetType(global::Android.Net.Uri url) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Query for the possible MIME types for the representations the given content URL can be returned when opened as as stream with openTypedAssetFileDescriptor. Note that the types here are not necessarily a superset of the type returned by getType  many content providers cannot return a raw stream for the structured data that they contain.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns an array of MIME type strings for all available data streams that match the given mimeTypeFilter. If there are none, null is returned. </para>
				/// </returns>
				/// <java-name>
				/// getStreamTypes
				/// </java-name>
				[Dot42.DexImport("getStreamTypes", "(Landroid/net/Uri;Ljava/lang/String;)[Ljava/lang/String;", AccessFlags = 1)]
				public virtual string[] GetStreamTypes(global::Android.Net.Uri url, string mimeTypeFilter) /* MethodBuilder.Create */ 
				{
						return default(string[]);
				}

				/// <summary>
				///  <para>Query the given URI, returning a Cursor over the result set. </para> <para>For best performance, the caller should follow these guidelines:  <ul> <li> <para>Provide an explicit projection, to prevent reading data from storage that aren't going to be used. </para></li> <li> <para>Use question mark parameter markers such as 'phone=?' instead of explicit values in the <c>selection </c> parameter, so that queries that differ only by those values will be recognized as the same for caching purposes. </para></li></ul></para> <para> <para>Cursor </para></para>        
				/// </summary>
				/// <returns>
				///  <para>A Cursor object, which is positioned before the first entry, or null </para>
				/// </returns>
				/// <java-name>
				/// query
				/// </java-name>
				[Dot42.DexImport("query", "(Landroid/net/Uri;[Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/l" +
    "ang/String;)Landroid/database/Cursor;", AccessFlags = 17)]
				public global::Android.Database.ICursor Query(global::Android.Net.Uri uri, string[] projection, string selection, string[] selectionArgs, string sortOrder) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Database.ICursor);
				}

				/// <summary>
				///  <para>Open a stream on to the content associated with a content URI. If there is no data associated with the URI, FileNotFoundException is thrown.</para> <para> <h5>Accepts the following URI schemes:</h5></para> <para> <ul> <li> <para>content (SCHEME_CONTENT) </para></li> <li> <para>android.resource (SCHEME_ANDROID_RESOURCE) </para></li> <li> <para>file (SCHEME_FILE) </para></li></ul></para> <para>See openAssetFileDescriptor(Uri, String) for more information on these schemes.</para> <para> <para>openAssetFileDescriptor(Uri, String) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>InputStream </para>
				/// </returns>
				/// <java-name>
				/// openInputStream
				/// </java-name>
				[Dot42.DexImport("openInputStream", "(Landroid/net/Uri;)Ljava/io/InputStream;", AccessFlags = 17)]
				public global::Java.IO.InputStream OpenInputStream(global::Android.Net.Uri uri) /* MethodBuilder.Create */ 
				{
						return default(global::Java.IO.InputStream);
				}

				/// <summary>
				///  <para>Synonym for openOutputStream(uri, "w"). </para>        
				/// </summary>
				/// <java-name>
				/// openOutputStream
				/// </java-name>
				[Dot42.DexImport("openOutputStream", "(Landroid/net/Uri;)Ljava/io/OutputStream;", AccessFlags = 17)]
				public global::Java.IO.OutputStream OpenOutputStream(global::Android.Net.Uri uri) /* MethodBuilder.Create */ 
				{
						return default(global::Java.IO.OutputStream);
				}

				/// <summary>
				///  <para>Open a stream on to the content associated with a content URI. If there is no data associated with the URI, FileNotFoundException is thrown.</para> <para> <h5>Accepts the following URI schemes:</h5></para> <para> <ul> <li> <para>content (SCHEME_CONTENT) </para></li> <li> <para>file (SCHEME_FILE) </para></li></ul></para> <para>See openAssetFileDescriptor(Uri, String) for more information on these schemes.</para> <para> <para>openAssetFileDescriptor(Uri, String) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>OutputStream </para>
				/// </returns>
				/// <java-name>
				/// openOutputStream
				/// </java-name>
				[Dot42.DexImport("openOutputStream", "(Landroid/net/Uri;Ljava/lang/String;)Ljava/io/OutputStream;", AccessFlags = 17)]
				public global::Java.IO.OutputStream OpenOutputStream(global::Android.Net.Uri uri, string mode) /* MethodBuilder.Create */ 
				{
						return default(global::Java.IO.OutputStream);
				}

				/// <summary>
				///  <para>Open a raw file descriptor to access data under a URI. This is like openAssetFileDescriptor(Uri, String), but uses the underlying ContentProvider#openFile ContentProvider.openFile()} method, so will  <b>not</b> work with providers that return sub-sections of files. If at all possible, you should use openAssetFileDescriptor(Uri, String). You will receive a FileNotFoundException exception if the provider returns a sub-section of a file.</para> <para> <h5>Accepts the following URI schemes:</h5></para> <para> <ul> <li> <para>content (SCHEME_CONTENT) </para></li> <li> <para>file (SCHEME_FILE) </para></li></ul></para> <para>See openAssetFileDescriptor(Uri, String) for more information on these schemes. </para> <para>If opening with the exclusive "r" or "w" modes, the returned ParcelFileDescriptor could be a pipe or socket pair to enable streaming of data. Opening with the "rw" mode implies a file on disk that supports seeking. If possible, always use an exclusive mode to give the underlying ContentProvider the most flexibility. </para> <para>If you are writing a file, and need to communicate an error to the provider, use ParcelFileDescriptor#closeWithError(String).</para> <para> <para>openAssetFileDescriptor(Uri, String) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns a new ParcelFileDescriptor pointing to the file. You own this descriptor and are responsible for closing it when done. </para>
				/// </returns>
				/// <java-name>
				/// openFileDescriptor
				/// </java-name>
				[Dot42.DexImport("openFileDescriptor", "(Landroid/net/Uri;Ljava/lang/String;)Landroid/os/ParcelFileDescriptor;", AccessFlags = 17)]
				public global::Android.OS.ParcelFileDescriptor OpenFileDescriptor(global::Android.Net.Uri uri, string mode) /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.ParcelFileDescriptor);
				}

				/// <summary>
				///  <para>Open a raw file descriptor to access data under a URI. This interacts with the underlying ContentProvider#openAssetFile method of the provider associated with the given URI, to retrieve any file stored there.</para> <para> <h5>Accepts the following URI schemes:</h5></para> <para> <ul> <li> <para>content (SCHEME_CONTENT) </para></li> <li> <para>android.resource (SCHEME_ANDROID_RESOURCE) </para></li> <li> <para>file (SCHEME_FILE) </para></li></ul> <h5>The android.resource ( SCHEME_ANDROID_RESOURCE}) Scheme</h5></para> <para>A Uri object can be used to reference a resource in an APK file. The Uri should be one of the following formats:  <ul> <li> <para> <code>android.resource://package_name/id_number</code> <br></br>  <code>package_name</code> is your package name as listed in your AndroidManifest.xml. For example  <code>com.example.myapp</code> <br></br>  <code>id_number</code> is the int form of the ID. <br></br> The easiest way to construct this form is  <pre>Uri uri = Uri.parse("android.resource://com.example.myapp/" + R.raw.my_resource");</pre>  </para></li> <li> <para> <code>android.resource://package_name/type/name</code> <br></br>  <code>package_name</code> is your package name as listed in your AndroidManifest.xml. For example  <code>com.example.myapp</code> <br></br>  <code>type</code> is the string form of the resource type. For example,  <code>raw</code> or  <code>drawable</code>.  <code>name</code> is the string form of the resource name. That is, whatever the file name was in your res directory, without the type extension. The easiest way to construct this form is  <pre>Uri uri = Uri.parse("android.resource://com.example.myapp/raw/my_resource");</pre>  </para></li></ul></para> <para>Note that if this function is called for read-only input (mode is "r") on a content: URI, it will instead call openTypedAssetFileDescriptor for you with a MIME type of "*\/*". This allows such callers to benefit from any built-in data conversion that a provider implements.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns a new ParcelFileDescriptor pointing to the file. You own this descriptor and are responsible for closing it when done. </para>
				/// </returns>
				/// <java-name>
				/// openAssetFileDescriptor
				/// </java-name>
				[Dot42.DexImport("openAssetFileDescriptor", "(Landroid/net/Uri;Ljava/lang/String;)Landroid/content/res/AssetFileDescriptor;", AccessFlags = 17)]
				public global::Android.Content.Res.AssetFileDescriptor OpenAssetFileDescriptor(global::Android.Net.Uri uri, string mode) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Res.AssetFileDescriptor);
				}

				/// <summary>
				///  <para>Open a raw file descriptor to access (potentially type transformed) data from a "content:" URI. This interacts with the underlying ContentProvider#openTypedAssetFile method of the provider associated with the given URI, to retrieve retrieve any appropriate data stream for the data stored there.</para> <para>Unlike openAssetFileDescriptor, this function only works with "content:" URIs, because content providers are the only facility with an associated MIME type to ensure that the returned data stream is of the desired type.</para> <para>All text/* streams are encoded in UTF-8.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns a new ParcelFileDescriptor from which you can read the data stream from the provider. Note that this may be a pipe, meaning you can't seek in it. The only seek you should do is if the AssetFileDescriptor contains an offset, to move to that offset before reading. You own this descriptor and are responsible for closing it when done. </para>
				/// </returns>
				/// <java-name>
				/// openTypedAssetFileDescriptor
				/// </java-name>
				[Dot42.DexImport("openTypedAssetFileDescriptor", "(Landroid/net/Uri;Ljava/lang/String;Landroid/os/Bundle;)Landroid/content/res/Asse" +
    "tFileDescriptor;", AccessFlags = 17)]
				public global::Android.Content.Res.AssetFileDescriptor OpenTypedAssetFileDescriptor(global::Android.Net.Uri uri, string mimeType, global::Android.OS.Bundle opts) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Res.AssetFileDescriptor);
				}

				/// <summary>
				///  <para>Inserts a row into a table at the given URL.</para> <para>If the content provider supports transactions the insertion will be atomic.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the URL of the newly created row. </para>
				/// </returns>
				/// <java-name>
				/// insert
				/// </java-name>
				[Dot42.DexImport("insert", "(Landroid/net/Uri;Landroid/content/ContentValues;)Landroid/net/Uri;", AccessFlags = 17)]
				public global::Android.Net.Uri Insert(global::Android.Net.Uri url, global::Android.Content.ContentValues values) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Net.Uri);
				}

				/// <summary>
				///  <para>Applies each of the ContentProviderOperation objects and returns an array of their results. Passes through OperationApplicationException, which may be thrown by the call to ContentProviderOperation#apply. If all the applications succeed then a ContentProviderResult array with the same number of elements as the operations will be returned. It is implementation-specific how many, if any, operations will have been successfully applied if a call to apply results in a OperationApplicationException. </para>        
				/// </summary>
				/// <returns>
				///  <para>the results of the applications </para>
				/// </returns>
				/// <java-name>
				/// applyBatch
				/// </java-name>
				[Dot42.DexImport("applyBatch", "(Ljava/lang/String;Ljava/util/ArrayList;)[Landroid/content/ContentProviderResult;" +
    "", AccessFlags = 1, Signature = "(Ljava/lang/String;Ljava/util/ArrayList<Landroid/content/ContentProviderOperation" +
    ";>;)[Landroid/content/ContentProviderResult;")]
				public virtual global::Android.Content.ContentProviderResult[] ApplyBatch(string authority, global::Java.Util.ArrayList<global::Android.Content.ContentProviderOperation> operations) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.ContentProviderResult[]);
				}

				/// <summary>
				///  <para>Inserts multiple rows into a table at the given URL.</para> <para>This function make no guarantees about the atomicity of the insertions.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the number of newly created rows. </para>
				/// </returns>
				/// <java-name>
				/// bulkInsert
				/// </java-name>
				[Dot42.DexImport("bulkInsert", "(Landroid/net/Uri;[Landroid/content/ContentValues;)I", AccessFlags = 17)]
				public int BulkInsert(global::Android.Net.Uri url, global::Android.Content.ContentValues[] values) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Deletes row(s) specified by a content URI.</para> <para>If the content provider supports transactions, the deletion will be atomic.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The number of rows deleted. </para>
				/// </returns>
				/// <java-name>
				/// delete
				/// </java-name>
				[Dot42.DexImport("delete", "(Landroid/net/Uri;Ljava/lang/String;[Ljava/lang/String;)I", AccessFlags = 17)]
				public int Delete(global::Android.Net.Uri url, string where, string[] selectionArgs) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Update row(s) in a content URI.</para> <para>If the content provider supports transactions the update will be atomic.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the number of rows updated. </para>
				/// </returns>
				/// <java-name>
				/// update
				/// </java-name>
				[Dot42.DexImport("update", "(Landroid/net/Uri;Landroid/content/ContentValues;Ljava/lang/String;[Ljava/lang/St" +
    "ring;)I", AccessFlags = 17)]
				public int Update(global::Android.Net.Uri uri, global::Android.Content.ContentValues values, string where, string[] selectionArgs) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Call a provider-defined method. This can be used to implement read or write interfaces which are cheaper than using a Cursor and/or do not fit into the traditional table model.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a result Bundle, possibly null. Will be null if the ContentProvider does not implement call. </para>
				/// </returns>
				/// <java-name>
				/// call
				/// </java-name>
				[Dot42.DexImport("call", "(Landroid/net/Uri;Ljava/lang/String;Ljava/lang/String;Landroid/os/Bundle;)Landroi" +
    "d/os/Bundle;", AccessFlags = 17)]
				public global::Android.OS.Bundle Call(global::Android.Net.Uri uri, string method, string arg, global::Android.OS.Bundle extras) /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.Bundle);
				}

				/// <summary>
				///  <para>Returns a ContentProviderClient that is associated with the ContentProvider that services the content at uri, starting the provider if necessary. Returns null if there is no provider associated wih the uri. The caller must indicate that they are done with the provider by calling ContentProviderClient#release which will allow the system to release the provider it it determines that there is no other reason for keeping it active. </para>        
				/// </summary>
				/// <returns>
				///  <para>a ContentProviderClient that is associated with the ContentProvider that services the content at uri or null if there isn't one. </para>
				/// </returns>
				/// <java-name>
				/// acquireContentProviderClient
				/// </java-name>
				[Dot42.DexImport("acquireContentProviderClient", "(Landroid/net/Uri;)Landroid/content/ContentProviderClient;", AccessFlags = 17)]
				public global::Android.Content.ContentProviderClient AcquireContentProviderClient(global::Android.Net.Uri uri) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.ContentProviderClient);
				}

				/// <summary>
				///  <para>Returns a ContentProviderClient that is associated with the ContentProvider that services the content at uri, starting the provider if necessary. Returns null if there is no provider associated wih the uri. The caller must indicate that they are done with the provider by calling ContentProviderClient#release which will allow the system to release the provider it it determines that there is no other reason for keeping it active. </para>        
				/// </summary>
				/// <returns>
				///  <para>a ContentProviderClient that is associated with the ContentProvider that services the content at uri or null if there isn't one. </para>
				/// </returns>
				/// <java-name>
				/// acquireContentProviderClient
				/// </java-name>
				[Dot42.DexImport("acquireContentProviderClient", "(Ljava/lang/String;)Landroid/content/ContentProviderClient;", AccessFlags = 17)]
				public global::Android.Content.ContentProviderClient AcquireContentProviderClient(string uri) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.ContentProviderClient);
				}

				/// <summary>
				///  <para>Register an observer class that gets callbacks when data identified by a given content URI changes.</para> <para> <para>unregisterContentObserver </para></para>        
				/// </summary>
				/// <java-name>
				/// registerContentObserver
				/// </java-name>
				[Dot42.DexImport("registerContentObserver", "(Landroid/net/Uri;ZLandroid/database/ContentObserver;)V", AccessFlags = 17)]
				public void RegisterContentObserver(global::Android.Net.Uri uri, bool notifyForDescendents, global::Android.Database.ContentObserver observer) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Unregisters a change observer.</para> <para> <para>registerContentObserver </para></para>        
				/// </summary>
				/// <java-name>
				/// unregisterContentObserver
				/// </java-name>
				[Dot42.DexImport("unregisterContentObserver", "(Landroid/database/ContentObserver;)V", AccessFlags = 17)]
				public void UnregisterContentObserver(global::Android.Database.ContentObserver observer) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Notify registered observers that a row was updated and attempt to sync changes to the network. To register, call registerContentObserver(). By default, CursorAdapter objects will get this notification.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// notifyChange
				/// </java-name>
				[Dot42.DexImport("notifyChange", "(Landroid/net/Uri;Landroid/database/ContentObserver;)V", AccessFlags = 1)]
				public virtual void NotifyChange(global::Android.Net.Uri uri, global::Android.Database.ContentObserver observer) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Notify registered observers that a row was updated. To register, call registerContentObserver(). By default, CursorAdapter objects will get this notification. If syncToNetwork is true, this will attempt to schedule a local sync using the sync adapter that's registered for the authority of the provided uri. No account will be passed to the sync adapter, so all matching accounts will be synchronized.</para> <para> <para> <code> requestSync(android.accounts.Account, String, android.os.Bundle) </code></para></para>        
				/// </summary>
				/// <java-name>
				/// notifyChange
				/// </java-name>
				[Dot42.DexImport("notifyChange", "(Landroid/net/Uri;Landroid/database/ContentObserver;Z)V", AccessFlags = 1)]
				public virtual void NotifyChange(global::Android.Net.Uri uri, global::Android.Database.ContentObserver observer, bool syncToNetwork) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Start an asynchronous sync operation. If you want to monitor the progress of the sync you may register a SyncObserver. Only values of the following types may be used in the extras bundle:  <ul> <li> <para>Integer </para></li> <li> <para>Long </para></li> <li> <para>Boolean </para></li> <li> <para>Float </para></li> <li> <para>Double </para></li> <li> <para>String </para></li> <li> <para>Account </para></li> <li> <para>null </para></li></ul></para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>instead use requestSync(android.accounts.Account, String, android.os.Bundle) </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// startSync
				/// </java-name>
				[Dot42.DexImport("startSync", "(Landroid/net/Uri;Landroid/os/Bundle;)V", AccessFlags = 1)]
				public virtual void StartSync(global::Android.Net.Uri uri, global::Android.OS.Bundle extras) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Start an asynchronous sync operation. If you want to monitor the progress of the sync you may register a SyncObserver. Only values of the following types may be used in the extras bundle:  <ul> <li> <para>Integer </para></li> <li> <para>Long </para></li> <li> <para>Boolean </para></li> <li> <para>Float </para></li> <li> <para>Double </para></li> <li> <para>String </para></li> <li> <para>Account </para></li> <li> <para>null </para></li></ul></para> <para></para>        
				/// </summary>
				/// <java-name>
				/// requestSync
				/// </java-name>
				[Dot42.DexImport("requestSync", "(Landroid/accounts/Account;Ljava/lang/String;Landroid/os/Bundle;)V", AccessFlags = 9)]
				public static void RequestSync(global::Android.Accounts.Account account, string authority, global::Android.OS.Bundle extras) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Check that only values of the following types are in the Bundle:  <ul> <li> <para>Integer </para></li> <li> <para>Long </para></li> <li> <para>Boolean </para></li> <li> <para>Float </para></li> <li> <para>Double </para></li> <li> <para>String </para></li> <li> <para>Account </para></li> <li> <para>null </para></li></ul></para>        
				/// </summary>
				/// <java-name>
				/// validateSyncExtrasBundle
				/// </java-name>
				[Dot42.DexImport("validateSyncExtrasBundle", "(Landroid/os/Bundle;)V", AccessFlags = 9)]
				public static void ValidateSyncExtrasBundle(global::Android.OS.Bundle extras) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Cancel any active or pending syncs that match the Uri. If the uri is null then all syncs will be canceled.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>instead use cancelSync(android.accounts.Account, String) </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// cancelSync
				/// </java-name>
				[Dot42.DexImport("cancelSync", "(Landroid/net/Uri;)V", AccessFlags = 1)]
				public virtual void CancelSync(global::Android.Net.Uri uri) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Cancel any active or pending syncs that match account and authority. The account and authority can each independently be set to null, which means that syncs with any account or authority, respectively, will match.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// cancelSync
				/// </java-name>
				[Dot42.DexImport("cancelSync", "(Landroid/accounts/Account;Ljava/lang/String;)V", AccessFlags = 9)]
				public static void CancelSync(global::Android.Accounts.Account account, string authority) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Check if the provider should be synced when a network tickle is received </para> <para>This method requires the caller to hold the permission android.Manifest.permission#READ_SYNC_SETTINGS.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if the provider should be synced when a network tickle is received </para>
				/// </returns>
				/// <java-name>
				/// getSyncAutomatically
				/// </java-name>
				[Dot42.DexImport("getSyncAutomatically", "(Landroid/accounts/Account;Ljava/lang/String;)Z", AccessFlags = 9)]
				public static bool GetSyncAutomatically(global::Android.Accounts.Account account, string authority) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Set whether or not the provider is synced when it receives a network tickle. </para> <para>This method requires the caller to hold the permission android.Manifest.permission#WRITE_SYNC_SETTINGS.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setSyncAutomatically
				/// </java-name>
				[Dot42.DexImport("setSyncAutomatically", "(Landroid/accounts/Account;Ljava/lang/String;Z)V", AccessFlags = 9)]
				public static void SetSyncAutomatically(global::Android.Accounts.Account account, string authority, bool sync) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Specifies that a sync should be requested with the specified the account, authority, and extras at the given frequency. If there is already another periodic sync scheduled with the account, authority and extras then a new periodic sync won't be added, instead the frequency of the previous one will be updated. </para> <para>These periodic syncs honor the "syncAutomatically" and "masterSyncAutomatically" settings. Although these sync are scheduled at the specified frequency, it may take longer for it to actually be started if other syncs are ahead of it in the sync operation queue. This means that the actual start time may drift. </para> <para>Periodic syncs are not allowed to have any of SYNC_EXTRAS_DO_NOT_RETRY, SYNC_EXTRAS_IGNORE_BACKOFF, SYNC_EXTRAS_IGNORE_SETTINGS, SYNC_EXTRAS_INITIALIZE, SYNC_EXTRAS_FORCE, SYNC_EXTRAS_EXPEDITED, SYNC_EXTRAS_MANUAL set to true. If any are supplied then an IllegalArgumentException will be thrown. </para> <para>As of API level 19 this function introduces a default flexibility of ~4% (up to a maximum of one hour in the day) into the requested period. Use SyncRequest.Builder#syncPeriodic(long, long) to set this flexibility manually.</para> <para>This method requires the caller to hold the permission android.Manifest.permission#WRITE_SYNC_SETTINGS.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// addPeriodicSync
				/// </java-name>
				[Dot42.DexImport("addPeriodicSync", "(Landroid/accounts/Account;Ljava/lang/String;Landroid/os/Bundle;J)V", AccessFlags = 9)]
				public static void AddPeriodicSync(global::Android.Accounts.Account account, string authority, global::Android.OS.Bundle extras, long pollFrequency) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Remove a periodic sync. Has no affect if account, authority and extras don't match an existing periodic sync. </para> <para>This method requires the caller to hold the permission android.Manifest.permission#WRITE_SYNC_SETTINGS.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// removePeriodicSync
				/// </java-name>
				[Dot42.DexImport("removePeriodicSync", "(Landroid/accounts/Account;Ljava/lang/String;Landroid/os/Bundle;)V", AccessFlags = 9)]
				public static void RemovePeriodicSync(global::Android.Accounts.Account account, string authority, global::Android.OS.Bundle extras) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Get the list of information about the periodic syncs for the given account and authority. </para> <para>This method requires the caller to hold the permission android.Manifest.permission#READ_SYNC_SETTINGS.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a list of PeriodicSync objects. This list may be empty but will never be null. </para>
				/// </returns>
				/// <java-name>
				/// getPeriodicSyncs
				/// </java-name>
				[Dot42.DexImport("getPeriodicSyncs", "(Landroid/accounts/Account;Ljava/lang/String;)Ljava/util/List;", AccessFlags = 9, Signature = "(Landroid/accounts/Account;Ljava/lang/String;)Ljava/util/List<Landroid/content/Pe" +
    "riodicSync;>;")]
				public static global::Java.Util.IList<global::Android.Content.PeriodicSync> GetPeriodicSyncs(global::Android.Accounts.Account account, string authority) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<global::Android.Content.PeriodicSync>);
				}

				/// <summary>
				///  <para>Check if this account/provider is syncable. </para> <para>This method requires the caller to hold the permission android.Manifest.permission#READ_SYNC_SETTINGS. </para>        
				/// </summary>
				/// <returns>
				///  <para>&gt;0 if it is syncable, 0 if not, and &lt;0 if the state isn't known yet. </para>
				/// </returns>
				/// <java-name>
				/// getIsSyncable
				/// </java-name>
				[Dot42.DexImport("getIsSyncable", "(Landroid/accounts/Account;Ljava/lang/String;)I", AccessFlags = 9)]
				public static int GetIsSyncable(global::Android.Accounts.Account account, string authority) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Set whether this account/provider is syncable. </para> <para>This method requires the caller to hold the permission android.Manifest.permission#WRITE_SYNC_SETTINGS. </para>        
				/// </summary>
				/// <java-name>
				/// setIsSyncable
				/// </java-name>
				[Dot42.DexImport("setIsSyncable", "(Landroid/accounts/Account;Ljava/lang/String;I)V", AccessFlags = 9)]
				public static void SetIsSyncable(global::Android.Accounts.Account account, string authority, int syncable) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns true if there is currently a sync operation for the given account or authority in the pending list, or actively being processed. </para> <para>This method requires the caller to hold the permission android.Manifest.permission#READ_SYNC_STATS. </para>        
				/// </summary>
				/// <returns>
				///  <para>true if a sync is active for the given account or authority. </para>
				/// </returns>
				/// <java-name>
				/// isSyncActive
				/// </java-name>
				[Dot42.DexImport("isSyncActive", "(Landroid/accounts/Account;Ljava/lang/String;)Z", AccessFlags = 9)]
				public static bool IsSyncActive(global::Android.Accounts.Account account, string authority) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Return true if the pending status is true of any matching authorities. </para> <para>This method requires the caller to hold the permission android.Manifest.permission#READ_SYNC_STATS. </para>        
				/// </summary>
				/// <returns>
				///  <para>true if there is a pending sync with the matching account and authority </para>
				/// </returns>
				/// <java-name>
				/// isSyncPending
				/// </java-name>
				[Dot42.DexImport("isSyncPending", "(Landroid/accounts/Account;Ljava/lang/String;)Z", AccessFlags = 9)]
				public static bool IsSyncPending(global::Android.Accounts.Account account, string authority) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Request notifications when the different aspects of the SyncManager change. The different items that can be requested are:  <ul> <li> <para>SYNC_OBSERVER_TYPE_PENDING </para></li> <li> <para>SYNC_OBSERVER_TYPE_ACTIVE </para></li> <li> <para>SYNC_OBSERVER_TYPE_SETTINGS </para></li></ul>The caller can set one or more of the status types in the mask for any given listener registration. </para>        
				/// </summary>
				/// <returns>
				///  <para>a handle that can be used to remove the listener at a later time </para>
				/// </returns>
				/// <java-name>
				/// addStatusChangeListener
				/// </java-name>
				[Dot42.DexImport("addStatusChangeListener", "(ILandroid/content/SyncStatusObserver;)Ljava/lang/Object;", AccessFlags = 9)]
				public static object AddStatusChangeListener(int mask, global::Android.Content.ISyncStatusObserver callback) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <summary>
				///  <para>Remove a previously registered status change listener. </para>        
				/// </summary>
				/// <java-name>
				/// removeStatusChangeListener
				/// </java-name>
				[Dot42.DexImport("removeStatusChangeListener", "(Ljava/lang/Object;)V", AccessFlags = 9)]
				public static void RemoveStatusChangeListener(object handle) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal ContentResolver() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Get information about the SyncAdapters that are known to the system. </para>        
				/// </summary>
				/// <returns>
				///  <para>an array of SyncAdapters that have registered with the system </para>
				/// </returns>
				/// <java-name>
				/// getSyncAdapterTypes
				/// </java-name>
				public static global::Android.Content.SyncAdapterType[] SyncAdapterTypes
				{
						[Dot42.DexImport("getSyncAdapterTypes", "()[Landroid/content/SyncAdapterType;", AccessFlags = 9)]
						get{ return default(global::Android.Content.SyncAdapterType[]); }
				}

				/// <summary>
				///  <para>Gets the master auto-sync setting that applies to all the providers and accounts. If this is false then the per-provider auto-sync setting is ignored. </para> <para>This method requires the caller to hold the permission android.Manifest.permission#READ_SYNC_SETTINGS.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the master auto-sync setting that applies to all the providers and accounts </para>
				/// </returns>
				/// <java-name>
				/// getMasterSyncAutomatically
				/// </java-name>
				public static bool MasterSyncAutomatically
				{
						[Dot42.DexImport("getMasterSyncAutomatically", "()Z", AccessFlags = 9)]
						get{ return default(bool); }
						[Dot42.DexImport("setMasterSyncAutomatically", "(Z)V", AccessFlags = 9)]
						set{ }
				}

				/// <summary>
				///  <para>If a sync is active returns the information about it, otherwise returns null. </para> <para>This method requires the caller to hold the permission android.Manifest.permission#READ_SYNC_STATS. </para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Since multiple concurrent syncs are now supported you should use getCurrentSyncs() to get the accurate list of current syncs. This method returns the first item from the list of current syncs or null if there are none. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				///  <para>the SyncInfo for the currently active sync or null if one is not active. </para>
				/// </returns>
				/// <java-name>
				/// getCurrentSync
				/// </java-name>
				public static global::Android.Content.SyncInfo CurrentSync
				{
						[Dot42.DexImport("getCurrentSync", "()Landroid/content/SyncInfo;", AccessFlags = 9)]
						get{ return default(global::Android.Content.SyncInfo); }
				}

				/// <summary>
				///  <para>Returns a list with information about all the active syncs. This list will be empty if there are no active syncs. </para> <para>This method requires the caller to hold the permission android.Manifest.permission#READ_SYNC_STATS. </para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a List of SyncInfo objects for the currently active syncs. </para>
				/// </returns>
				/// <java-name>
				/// getCurrentSyncs
				/// </java-name>
				public static global::Java.Util.IList<global::Android.Content.SyncInfo> CurrentSyncs
				{
						[Dot42.DexImport("getCurrentSyncs", "()Ljava/util/List;", AccessFlags = 9, Signature = "()Ljava/util/List<Landroid/content/SyncInfo;>;")]
						get{ return default(global::Java.Util.IList<global::Android.Content.SyncInfo>); }
				}

		}

		/// <summary>
		///  <para>Utility methods useful for working with android.net.Uri objects that use the "content" (content://) scheme.</para> <para>Content URIs have the syntax </para> <para> <code>content:// <b>authority</b>/ <b>path</b>/ <b>id</b></code> </para> <para></para>    
		/// </summary>
		/// <java-name>
		/// android/content/ContentUris
		/// </java-name>
		[Dot42.DexImport("android/content/ContentUris", AccessFlags = 33)]
		public partial class ContentUris
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ContentUris() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Converts the last path segment to a long.</para> <para>This supports a common convention for content URIs where an ID is stored in the last segment.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the long conversion of the last segment or -1 if the path is empty </para>
				/// </returns>
				/// <java-name>
				/// parseId
				/// </java-name>
				[Dot42.DexImport("parseId", "(Landroid/net/Uri;)J", AccessFlags = 9)]
				public static long ParseId(global::Android.Net.Uri contentUri) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				///  <para>Appends the given ID to the end of the path.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the given builder </para>
				/// </returns>
				/// <java-name>
				/// appendId
				/// </java-name>
				[Dot42.DexImport("appendId", "(Landroid/net/Uri$Builder;J)Landroid/net/Uri$Builder;", AccessFlags = 9)]
				public static global::Android.Net.Uri.Builder AppendId(global::Android.Net.Uri.Builder builder, long id) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Net.Uri.Builder);
				}

				/// <summary>
				///  <para>Appends the given ID to the end of the path.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a new URI with the given ID appended to the end of the path </para>
				/// </returns>
				/// <java-name>
				/// withAppendedId
				/// </java-name>
				[Dot42.DexImport("withAppendedId", "(Landroid/net/Uri;J)Landroid/net/Uri;", AccessFlags = 9)]
				public static global::Android.Net.Uri WithAppendedId(global::Android.Net.Uri contentUri, long id) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Net.Uri);
				}

		}

		/// <summary>
		///  <para>This class is used to store a set of values that the ContentResolver can process. </para>    
		/// </summary>
		/// <java-name>
		/// android/content/ContentValues
		/// </java-name>
		[Dot42.DexImport("android/content/ContentValues", AccessFlags = 49)]
		public sealed partial class ContentValues : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// TAG
				/// </java-name>
				[Dot42.DexImport("TAG", "Ljava/lang/String;", AccessFlags = 25)]
				public const string TAG = "ContentValues";
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.Content.ContentValues> CREATOR;
				/// <summary>
				///  <para>Creates an empty set of values using the default initial size </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ContentValues() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Creates an empty set of values using the given initial size</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public ContentValues(int size) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Creates an empty set of values using the given initial size</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/ContentValues;)V", AccessFlags = 1)]
				public ContentValues(global::Android.Content.ContentValues size) /* MethodBuilder.Create */ 
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
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public void Put(string @string, string string1) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Adds all values from the passed in ContentValues.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// putAll
				/// </java-name>
				[Dot42.DexImport("putAll", "(Landroid/content/ContentValues;)V", AccessFlags = 1)]
				public void PutAll(global::Android.Content.ContentValues other) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "(Ljava/lang/String;Ljava/lang/Byte;)V", AccessFlags = 1)]
				public void Put(string @string, sbyte? sByte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "(Ljava/lang/String;Ljava/lang/Short;)V", AccessFlags = 1)]
				public void Put(string @string, short? int16) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "(Ljava/lang/String;Ljava/lang/Integer;)V", AccessFlags = 1)]
				public void Put(string @string, int? int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "(Ljava/lang/String;Ljava/lang/Long;)V", AccessFlags = 1)]
				public void Put(string @string, long? int64) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "(Ljava/lang/String;Ljava/lang/Float;)V", AccessFlags = 1)]
				public void Put(string @string, float? single) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "(Ljava/lang/String;Ljava/lang/Double;)V", AccessFlags = 1)]
				public void Put(string @string, double? @double) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "(Ljava/lang/String;Ljava/lang/Boolean;)V", AccessFlags = 1)]
				public void Put(string @string, bool? boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "(Ljava/lang/String;[B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public void Put(string @string, sbyte[] sByte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "(Ljava/lang/String;[B)V", AccessFlags = 1)]
				public void Put(string @string, byte[] @byte) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Adds a null value to the set.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// putNull
				/// </java-name>
				[Dot42.DexImport("putNull", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public void PutNull(string key) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns the number of values.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the number of values </para>
				/// </returns>
				/// <java-name>
				/// size
				/// </java-name>
				[Dot42.DexImport("size", "()I", AccessFlags = 1)]
				public int Size() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Remove a single value.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// remove
				/// </java-name>
				[Dot42.DexImport("remove", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public void Remove(string key) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Removes all values. </para>        
				/// </summary>
				/// <java-name>
				/// clear
				/// </java-name>
				[Dot42.DexImport("clear", "()V", AccessFlags = 1)]
				public void Clear() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns true if this object has the named value.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if the value is present, <c>false </c> otherwise </para>
				/// </returns>
				/// <java-name>
				/// containsKey
				/// </java-name>
				[Dot42.DexImport("containsKey", "(Ljava/lang/String;)Z", AccessFlags = 1)]
				public bool ContainsKey(string key) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Gets a value. Valid value types are String, Boolean, and Number implementations.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the data for the value </para>
				/// </returns>
				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(Ljava/lang/String;)Ljava/lang/Object;", AccessFlags = 1)]
				public object Get(string key) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <summary>
				///  <para>Gets a value and converts it to a String.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the String for the value </para>
				/// </returns>
				/// <java-name>
				/// getAsString
				/// </java-name>
				[Dot42.DexImport("getAsString", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1)]
				public string GetAsString(string key) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Gets a value and converts it to a Long.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the Long value, or null if the value is missing or cannot be converted </para>
				/// </returns>
				/// <java-name>
				/// getAsLong
				/// </java-name>
				[Dot42.DexImport("getAsLong", "(Ljava/lang/String;)Ljava/lang/Long;", AccessFlags = 1)]
				public long? GetAsLong(string key) /* MethodBuilder.Create */ 
				{
						return default(long?);
				}

				/// <summary>
				///  <para>Gets a value and converts it to an Integer.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the Integer value, or null if the value is missing or cannot be converted </para>
				/// </returns>
				/// <java-name>
				/// getAsInteger
				/// </java-name>
				[Dot42.DexImport("getAsInteger", "(Ljava/lang/String;)Ljava/lang/Integer;", AccessFlags = 1)]
				public int? GetAsInteger(string key) /* MethodBuilder.Create */ 
				{
						return default(int?);
				}

				/// <summary>
				///  <para>Gets a value and converts it to a Short.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the Short value, or null if the value is missing or cannot be converted </para>
				/// </returns>
				/// <java-name>
				/// getAsShort
				/// </java-name>
				[Dot42.DexImport("getAsShort", "(Ljava/lang/String;)Ljava/lang/Short;", AccessFlags = 1)]
				public short? GetAsShort(string key) /* MethodBuilder.Create */ 
				{
						return default(short?);
				}

				/// <summary>
				///  <para>Gets a value and converts it to a Byte.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the Byte value, or null if the value is missing or cannot be converted </para>
				/// </returns>
				/// <java-name>
				/// getAsByte
				/// </java-name>
				[Dot42.DexImport("getAsByte", "(Ljava/lang/String;)Ljava/lang/Byte;", AccessFlags = 1)]
				public sbyte? GetAsByte(string key) /* MethodBuilder.Create */ 
				{
						return default(sbyte?);
				}

				/// <summary>
				///  <para>Gets a value and converts it to a Double.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the Double value, or null if the value is missing or cannot be converted </para>
				/// </returns>
				/// <java-name>
				/// getAsDouble
				/// </java-name>
				[Dot42.DexImport("getAsDouble", "(Ljava/lang/String;)Ljava/lang/Double;", AccessFlags = 1)]
				public double? GetAsDouble(string key) /* MethodBuilder.Create */ 
				{
						return default(double?);
				}

				/// <summary>
				///  <para>Gets a value and converts it to a Float.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the Float value, or null if the value is missing or cannot be converted </para>
				/// </returns>
				/// <java-name>
				/// getAsFloat
				/// </java-name>
				[Dot42.DexImport("getAsFloat", "(Ljava/lang/String;)Ljava/lang/Float;", AccessFlags = 1)]
				public float? GetAsFloat(string key) /* MethodBuilder.Create */ 
				{
						return default(float?);
				}

				/// <summary>
				///  <para>Gets a value and converts it to a Boolean.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the Boolean value, or null if the value is missing or cannot be converted </para>
				/// </returns>
				/// <java-name>
				/// getAsBoolean
				/// </java-name>
				[Dot42.DexImport("getAsBoolean", "(Ljava/lang/String;)Ljava/lang/Boolean;", AccessFlags = 1)]
				public bool? GetAsBoolean(string key) /* MethodBuilder.Create */ 
				{
						return default(bool?);
				}

				/// <summary>
				///  <para>Gets a value that is a byte array. Note that this method will not convert any other types to byte arrays.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the byte[] value, or null is the value is missing or not a byte[] </para>
				/// </returns>
				/// <java-name>
				/// getAsByteArray
				/// </java-name>
				[Dot42.DexImport("getAsByteArray", "(Ljava/lang/String;)[B", AccessFlags = 1, IgnoreFromJava = true)]
				public sbyte[] JavaGetAsByteArray(string key) /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <summary>
				///  <para>Gets a value that is a byte array. Note that this method will not convert any other types to byte arrays.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the byte[] value, or null is the value is missing or not a byte[] </para>
				/// </returns>
				/// <java-name>
				/// getAsByteArray
				/// </java-name>
				[Dot42.DexImport("getAsByteArray", "(Ljava/lang/String;)[B", AccessFlags = 1)]
				public byte[] GetAsByteArray(string key) /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				/// <summary>
				///  <para>Returns a set of all of the keys and values</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a set of all of the keys and values </para>
				/// </returns>
				/// <java-name>
				/// valueSet
				/// </java-name>
				[Dot42.DexImport("valueSet", "()Ljava/util/Set;", AccessFlags = 1, Signature = "()Ljava/util/Set<Ljava/util/Map$Entry<Ljava/lang/String;Ljava/lang/Object;>;>;")]
				public global::Java.Util.ISet<global::Java.Util.IMap_IEntry<string, object>> ValueSet() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ISet<global::Java.Util.IMap_IEntry<string, object>>);
				}

				/// <summary>
				///  <para>Returns a set of all of the keys</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a set of all of the keys </para>
				/// </returns>
				/// <java-name>
				/// keySet
				/// </java-name>
				[Dot42.DexImport("keySet", "()Ljava/util/Set;", AccessFlags = 1, Signature = "()Ljava/util/Set<Ljava/lang/String;>;")]
				public global::Java.Util.ISet<string> KeySet() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ISet<string>);
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
				///  <para>Returns a string containing a concise, human-readable description of this object. </para>        
				/// </summary>
				/// <returns>
				///  <para>a printable representation of this object. </para>
				/// </returns>
				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

		}

		/// <summary>
		///  <para>Interface to global information about an application environment. This is an abstract class whose implementation is provided by the Android system. It allows access to application-specific resources and classes, as well as up-calls for application-level operations such as launching activities, broadcasting and receiving intents, etc. </para>    
		/// </summary>
		/// <java-name>
		/// android/content/Context
		/// </java-name>
		[Dot42.DexImport("android/content/Context", AccessFlags = 1057)]
		public abstract partial class Context
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>File creation mode: the default mode, where the created file can only be accessed by the calling application (or all applications sharing the same user ID).  <para>MODE_WORLD_READABLE </para> <para>MODE_WORLD_WRITEABLE </para></para>        
				/// </summary>
				/// <java-name>
				/// MODE_PRIVATE
				/// </java-name>
				[Dot42.DexImport("MODE_PRIVATE", "I", AccessFlags = 25)]
				public const int MODE_PRIVATE = 0;
				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Creating world-readable files is very dangerous, and likely to cause security holes in applications. It is strongly discouraged; instead, applications should use more formal mechanism for interactions such as ContentProvider, BroadcastReceiver, and android.app.Service. There are no guarantees that this access mode will remain on a file, such as when it goes through a backup and restore. File creation mode: allow all other applications to have read access to the created file.  <para>MODE_PRIVATE </para> <para>MODE_WORLD_WRITEABLE </para></para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// MODE_WORLD_READABLE
				/// </java-name>
				[Dot42.DexImport("MODE_WORLD_READABLE", "I", AccessFlags = 25)]
				public const int MODE_WORLD_READABLE = 1;
				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Creating world-writable files is very dangerous, and likely to cause security holes in applications. It is strongly discouraged; instead, applications should use more formal mechanism for interactions such as ContentProvider, BroadcastReceiver, and android.app.Service. There are no guarantees that this access mode will remain on a file, such as when it goes through a backup and restore. File creation mode: allow all other applications to have write access to the created file.  <para>MODE_PRIVATE </para> <para>MODE_WORLD_READABLE </para></para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// MODE_WORLD_WRITEABLE
				/// </java-name>
				[Dot42.DexImport("MODE_WORLD_WRITEABLE", "I", AccessFlags = 25)]
				public const int MODE_WORLD_WRITEABLE = 2;
				/// <summary>
				///  <para>File creation mode: for use with openFileOutput, if the file already exists then write data to the end of the existing file instead of erasing it.  <para>openFileOutput </para></para>        
				/// </summary>
				/// <java-name>
				/// MODE_APPEND
				/// </java-name>
				[Dot42.DexImport("MODE_APPEND", "I", AccessFlags = 25)]
				public const int MODE_APPEND = 32768;
				/// <summary>
				///  <para>SharedPreference loading flag: when set, the file on disk will be checked for modification even if the shared preferences instance is already loaded in this process. This behavior is sometimes desired in cases where the application has multiple processes, all writing to the same SharedPreferences file. Generally there are better forms of communication between processes, though.</para> <para>This was the legacy (but undocumented) behavior in and before Gingerbread (Android 2.3) and this flag is implied when targetting such releases. For applications targetting SDK versions  <b>greater than</b> Android 2.3, this flag must be explicitly set if desired.</para> <para> <para>getSharedPreferences </para></para>        
				/// </summary>
				/// <java-name>
				/// MODE_MULTI_PROCESS
				/// </java-name>
				[Dot42.DexImport("MODE_MULTI_PROCESS", "I", AccessFlags = 25)]
				public const int MODE_MULTI_PROCESS = 4;
				/// <summary>
				///  <para>Flag for bindService: automatically create the service as long as the binding exists. Note that while this will create the service, its android.app.Service#onStartCommand method will still only be called due to an explicit call to startService. Even without that, though, this still provides you with access to the service object while the service is created.</para> <para>Note that prior to android.os.Build.VERSION_CODES#ICE_CREAM_SANDWICH, not supplying this flag would also impact how important the system consider's the target service's process to be. When set, the only way for it to be raised was by binding from a service in which case it will only be important when that activity is in the foreground. Now to achieve this behavior you must explicitly supply the new flag BIND_ADJUST_WITH_ACTIVITY. For compatibility, old applications that don't specify BIND_AUTO_CREATE will automatically have the flags BIND_WAIVE_PRIORITY and BIND_ADJUST_WITH_ACTIVITY set for them in order to achieve the same result. </para>        
				/// </summary>
				/// <java-name>
				/// BIND_AUTO_CREATE
				/// </java-name>
				[Dot42.DexImport("BIND_AUTO_CREATE", "I", AccessFlags = 25)]
				public const int BIND_AUTO_CREATE = 1;
				/// <summary>
				///  <para>Flag for bindService: include debugging help for mismatched calls to unbind. When this flag is set, the callstack of the following unbindService call is retained, to be printed if a later incorrect unbind call is made. Note that doing this requires retaining information about the binding that was made for the lifetime of the app, resulting in a leak  this should only be used for debugging. </para>        
				/// </summary>
				/// <java-name>
				/// BIND_DEBUG_UNBIND
				/// </java-name>
				[Dot42.DexImport("BIND_DEBUG_UNBIND", "I", AccessFlags = 25)]
				public const int BIND_DEBUG_UNBIND = 2;
				/// <summary>
				///  <para>Flag for bindService: don't allow this binding to raise the target service's process to the foreground scheduling priority. It will still be raised to at least the same memory priority as the client (so that its process will not be killable in any situation where the client is not killable), but for CPU scheduling purposes it may be left in the background. This only has an impact in the situation where the binding client is a foreground process and the target service is in a background process. </para>        
				/// </summary>
				/// <java-name>
				/// BIND_NOT_FOREGROUND
				/// </java-name>
				[Dot42.DexImport("BIND_NOT_FOREGROUND", "I", AccessFlags = 25)]
				public const int BIND_NOT_FOREGROUND = 4;
				/// <summary>
				///  <para>Use with getSystemService to retrieve a android.os.PowerManager for controlling power management, including "wake locks," which let you keep the device on while you're running long tasks. </para>        
				/// </summary>
				/// <java-name>
				/// POWER_SERVICE
				/// </java-name>
				[Dot42.DexImport("POWER_SERVICE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string POWER_SERVICE = "power";
				/// <summary>
				///  <para>Use with getSystemService to retrieve a android.view.WindowManager for accessing the system's window manager.</para> <para> <para>getSystemService </para> <para>android.view.WindowManager </para></para>        
				/// </summary>
				/// <java-name>
				/// WINDOW_SERVICE
				/// </java-name>
				[Dot42.DexImport("WINDOW_SERVICE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string WINDOW_SERVICE = "window";
				/// <summary>
				///  <para>Use with getSystemService to retrieve a android.view.LayoutInflater for inflating layout resources in this context.</para> <para> <para>getSystemService </para> <para>android.view.LayoutInflater </para></para>        
				/// </summary>
				/// <java-name>
				/// LAYOUT_INFLATER_SERVICE
				/// </java-name>
				[Dot42.DexImport("LAYOUT_INFLATER_SERVICE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string LAYOUT_INFLATER_SERVICE = "layout_inflater";
				/// <summary>
				///  <para>Use with getSystemService to retrieve a android.accounts.AccountManager for receiving intents at a time of your choosing.</para> <para> <para>getSystemService </para> <para>android.accounts.AccountManager </para></para>        
				/// </summary>
				/// <java-name>
				/// ACCOUNT_SERVICE
				/// </java-name>
				[Dot42.DexImport("ACCOUNT_SERVICE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACCOUNT_SERVICE = "account";
				/// <summary>
				///  <para>Use with getSystemService to retrieve a android.app.ActivityManager for interacting with the global system state.</para> <para> <para>getSystemService </para> <para>android.app.ActivityManager </para></para>        
				/// </summary>
				/// <java-name>
				/// ACTIVITY_SERVICE
				/// </java-name>
				[Dot42.DexImport("ACTIVITY_SERVICE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTIVITY_SERVICE = "activity";
				/// <summary>
				///  <para>Use with getSystemService to retrieve a android.app.AlarmManager for receiving intents at a time of your choosing.</para> <para> <para>getSystemService </para> <para>android.app.AlarmManager </para></para>        
				/// </summary>
				/// <java-name>
				/// ALARM_SERVICE
				/// </java-name>
				[Dot42.DexImport("ALARM_SERVICE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ALARM_SERVICE = "alarm";
				/// <summary>
				///  <para>Use with getSystemService to retrieve a android.app.NotificationManager for informing the user of background events.</para> <para> <para>getSystemService </para> <para>android.app.NotificationManager </para></para>        
				/// </summary>
				/// <java-name>
				/// NOTIFICATION_SERVICE
				/// </java-name>
				[Dot42.DexImport("NOTIFICATION_SERVICE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string NOTIFICATION_SERVICE = "notification";
				/// <summary>
				///  <para>Use with getSystemService to retrieve a android.view.accessibility.AccessibilityManager for giving the user feedback for UI events through the registered event listeners.</para> <para> <para>getSystemService </para> <para>android.view.accessibility.AccessibilityManager </para></para>        
				/// </summary>
				/// <java-name>
				/// ACCESSIBILITY_SERVICE
				/// </java-name>
				[Dot42.DexImport("ACCESSIBILITY_SERVICE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACCESSIBILITY_SERVICE = "accessibility";
				/// <summary>
				///  <para>Use with getSystemService to retrieve a android.app.NotificationManager for controlling keyguard.</para> <para> <para>getSystemService </para> <para>android.app.KeyguardManager </para></para>        
				/// </summary>
				/// <java-name>
				/// KEYGUARD_SERVICE
				/// </java-name>
				[Dot42.DexImport("KEYGUARD_SERVICE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string KEYGUARD_SERVICE = "keyguard";
				/// <summary>
				///  <para>Use with getSystemService to retrieve a android.location.LocationManager for controlling location updates.</para> <para> <para>getSystemService </para> <para>android.location.LocationManager </para></para>        
				/// </summary>
				/// <java-name>
				/// LOCATION_SERVICE
				/// </java-name>
				[Dot42.DexImport("LOCATION_SERVICE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string LOCATION_SERVICE = "location";
				/// <summary>
				///  <para>Use with getSystemService to retrieve a android.app.SearchManager for handling searches.</para> <para> <para>getSystemService </para> <para>android.app.SearchManager </para></para>        
				/// </summary>
				/// <java-name>
				/// SEARCH_SERVICE
				/// </java-name>
				[Dot42.DexImport("SEARCH_SERVICE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SEARCH_SERVICE = "search";
				/// <summary>
				///  <para>Use with getSystemService to retrieve a android.hardware.SensorManager for accessing sensors.</para> <para> <para>getSystemService </para> <para>android.hardware.SensorManager </para></para>        
				/// </summary>
				/// <java-name>
				/// SENSOR_SERVICE
				/// </java-name>
				[Dot42.DexImport("SENSOR_SERVICE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SENSOR_SERVICE = "sensor";
				/// <summary>
				///  <para>Use with getSystemService to retrieve a android.os.storage.StorageManager for accessing system storage functions.</para> <para> <para>getSystemService </para> <para>android.os.storage.StorageManager </para></para>        
				/// </summary>
				/// <java-name>
				/// STORAGE_SERVICE
				/// </java-name>
				[Dot42.DexImport("STORAGE_SERVICE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string STORAGE_SERVICE = "storage";
				/// <summary>
				///  <para>Use with getSystemService to retrieve a com.android.server.WallpaperService for accessing wallpapers.</para> <para> <para>getSystemService </para></para>        
				/// </summary>
				/// <java-name>
				/// WALLPAPER_SERVICE
				/// </java-name>
				[Dot42.DexImport("WALLPAPER_SERVICE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string WALLPAPER_SERVICE = "wallpaper";
				/// <summary>
				///  <para>Use with getSystemService to retrieve a android.os.Vibrator for interacting with the vibration hardware.</para> <para> <para>getSystemService </para> <para>android.os.Vibrator </para></para>        
				/// </summary>
				/// <java-name>
				/// VIBRATOR_SERVICE
				/// </java-name>
				[Dot42.DexImport("VIBRATOR_SERVICE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string VIBRATOR_SERVICE = "vibrator";
				/// <summary>
				///  <para>Use with getSystemService to retrieve a android.net.ConnectivityManager for handling management of network connections.</para> <para> <para>getSystemService </para> <para>android.net.ConnectivityManager </para></para>        
				/// </summary>
				/// <java-name>
				/// CONNECTIVITY_SERVICE
				/// </java-name>
				[Dot42.DexImport("CONNECTIVITY_SERVICE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string CONNECTIVITY_SERVICE = "connectivity";
				/// <summary>
				///  <para>Use with getSystemService to retrieve a android.net.wifi.WifiManager for handling management of Wi-Fi access.</para> <para> <para>getSystemService </para> <para>android.net.wifi.WifiManager </para></para>        
				/// </summary>
				/// <java-name>
				/// WIFI_SERVICE
				/// </java-name>
				[Dot42.DexImport("WIFI_SERVICE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string WIFI_SERVICE = "wifi";
				/// <summary>
				///  <para>Use with getSystemService to retrieve a android.media.AudioManager for handling management of volume, ringer modes and audio routing.</para> <para> <para>getSystemService </para> <para>android.media.AudioManager </para></para>        
				/// </summary>
				/// <java-name>
				/// AUDIO_SERVICE
				/// </java-name>
				[Dot42.DexImport("AUDIO_SERVICE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string AUDIO_SERVICE = "audio";
				/// <summary>
				///  <para>Use with getSystemService to retrieve a android.telephony.TelephonyManager for handling management the telephony features of the device.</para> <para> <para>getSystemService </para> <para>android.telephony.TelephonyManager </para></para>        
				/// </summary>
				/// <java-name>
				/// TELEPHONY_SERVICE
				/// </java-name>
				[Dot42.DexImport("TELEPHONY_SERVICE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string TELEPHONY_SERVICE = "phone";
				/// <summary>
				///  <para>Use with getSystemService to retrieve a android.text.ClipboardManager for accessing and modifying the contents of the global clipboard.</para> <para> <para>getSystemService </para> <para>android.text.ClipboardManager </para></para>        
				/// </summary>
				/// <java-name>
				/// CLIPBOARD_SERVICE
				/// </java-name>
				[Dot42.DexImport("CLIPBOARD_SERVICE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string CLIPBOARD_SERVICE = "clipboard";
				/// <summary>
				///  <para>Use with getSystemService to retrieve a android.view.inputmethod.InputMethodManager for accessing input methods.</para> <para> <para>getSystemService </para></para>        
				/// </summary>
				/// <java-name>
				/// INPUT_METHOD_SERVICE
				/// </java-name>
				[Dot42.DexImport("INPUT_METHOD_SERVICE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string INPUT_METHOD_SERVICE = "input_method";
				/// <summary>
				///  <para>Use with getSystemService to retrieve a android.os.DropBoxManager instance for recording diagnostic logs.  <para>getSystemService </para></para>        
				/// </summary>
				/// <java-name>
				/// DROPBOX_SERVICE
				/// </java-name>
				[Dot42.DexImport("DROPBOX_SERVICE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string DROPBOX_SERVICE = "dropbox";
				/// <summary>
				///  <para>Use with getSystemService to retrieve a android.app.admin.DevicePolicyManager for working with global device policy management.</para> <para> <para>getSystemService </para></para>        
				/// </summary>
				/// <java-name>
				/// DEVICE_POLICY_SERVICE
				/// </java-name>
				[Dot42.DexImport("DEVICE_POLICY_SERVICE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string DEVICE_POLICY_SERVICE = "device_policy";
				/// <summary>
				///  <para>Use with getSystemService to retrieve a android.app.UiModeManager for controlling UI modes.</para> <para> <para>getSystemService </para></para>        
				/// </summary>
				/// <java-name>
				/// UI_MODE_SERVICE
				/// </java-name>
				[Dot42.DexImport("UI_MODE_SERVICE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string UI_MODE_SERVICE = "uimode";
				/// <summary>
				///  <para>Use with getSystemService to retrieve a android.app.DownloadManager for requesting HTTP downloads.</para> <para> <para>getSystemService </para></para>        
				/// </summary>
				/// <java-name>
				/// DOWNLOAD_SERVICE
				/// </java-name>
				[Dot42.DexImport("DOWNLOAD_SERVICE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string DOWNLOAD_SERVICE = "download";
				/// <summary>
				///  <para>Use with getSystemService to retrieve a android.nfc.NfcManager for using NFC.</para> <para> <para>getSystemService </para></para>        
				/// </summary>
				/// <java-name>
				/// NFC_SERVICE
				/// </java-name>
				[Dot42.DexImport("NFC_SERVICE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string NFC_SERVICE = "nfc";
				/// <summary>
				///  <para>Use with getSystemService to retrieve a android.hardware.usb.UsbManager for access to USB devices (as a USB host) and for controlling this device's behavior as a USB device.</para> <para> <para>getSystemService </para> <para>android.hardware.usb.UsbManager </para></para>        
				/// </summary>
				/// <java-name>
				/// USB_SERVICE
				/// </java-name>
				[Dot42.DexImport("USB_SERVICE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string USB_SERVICE = "usb";
				/// <summary>
				///  <para>Flag for use with createPackageContext: include the application code with the context. This means loading code into the caller's process, so that getClassLoader() can be used to instantiate the application's classes. Setting this flags imposes security restrictions on what application context you can access; if the requested application can not be safely loaded into your process, java.lang.SecurityException will be thrown. If this flag is not set, there will be no restrictions on the packages that can be loaded, but getClassLoader will always return the default system class loader. </para>        
				/// </summary>
				/// <java-name>
				/// CONTEXT_INCLUDE_CODE
				/// </java-name>
				[Dot42.DexImport("CONTEXT_INCLUDE_CODE", "I", AccessFlags = 25)]
				public const int CONTEXT_INCLUDE_CODE = 1;
				/// <summary>
				///  <para>Flag for use with createPackageContext: ignore any security restrictions on the Context being requested, allowing it to always be loaded. For use with CONTEXT_INCLUDE_CODE to allow code to be loaded into a process even when it isn't safe to do so. Use with extreme care! </para>        
				/// </summary>
				/// <java-name>
				/// CONTEXT_IGNORE_SECURITY
				/// </java-name>
				[Dot42.DexImport("CONTEXT_IGNORE_SECURITY", "I", AccessFlags = 25)]
				public const int CONTEXT_IGNORE_SECURITY = 2;
				/// <summary>
				///  <para>Flag for use with createPackageContext: a restricted context may disable specific features. For instance, a View associated with a restricted context would ignore particular XML attributes. </para>        
				/// </summary>
				/// <java-name>
				/// CONTEXT_RESTRICTED
				/// </java-name>
				[Dot42.DexImport("CONTEXT_RESTRICTED", "I", AccessFlags = 25)]
				public const int CONTEXT_RESTRICTED = 4;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Context() /* MethodBuilder.Create */ 
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
				///  <para>Set the base theme for this context. Note that this should be called before any views are instantiated in the Context (for example before calling android.app.Activity#setContentView or android.view.LayoutInflater#inflate).</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setTheme
				/// </java-name>
				[Dot42.DexImport("setTheme", "(I)V", AccessFlags = 1025)]
				public abstract void SetTheme(int resid) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Retrieve styled attribute information in this Context's theme. See Resources.Theme#obtainStyledAttributes(int[]) for more information.</para> <para> <para>Resources.Theme::obtainStyledAttributes(int[]) </para></para>        
				/// </summary>
				/// <java-name>
				/// obtainStyledAttributes
				/// </java-name>
				[Dot42.DexImport("obtainStyledAttributes", "([I)Landroid/content/res/TypedArray;", AccessFlags = 17)]
				public global::Android.Content.Res.TypedArray ObtainStyledAttributes(int[] attrs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Res.TypedArray);
				}

				/// <java-name>
				/// obtainStyledAttributes
				/// </java-name>
				[Dot42.DexImport("obtainStyledAttributes", "(I[I)Landroid/content/res/TypedArray;", AccessFlags = 17)]
				public global::Android.Content.Res.TypedArray ObtainStyledAttributes(int int32, int[] int321) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Res.TypedArray);
				}

				/// <java-name>
				/// obtainStyledAttributes
				/// </java-name>
				[Dot42.DexImport("obtainStyledAttributes", "(Landroid/util/AttributeSet;[I)Landroid/content/res/TypedArray;", AccessFlags = 17)]
				public global::Android.Content.Res.TypedArray ObtainStyledAttributes(global::Android.Util.IAttributeSet attributeSet, int[] int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Res.TypedArray);
				}

				/// <summary>
				///  <para>Retrieve styled attribute information in this Context's theme. See Resources.Theme#obtainStyledAttributes(AttributeSet, int[], int, int) for more information.</para> <para> <para>Resources.Theme::obtainStyledAttributes(AttributeSet, int[], int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// obtainStyledAttributes
				/// </java-name>
				[Dot42.DexImport("obtainStyledAttributes", "(Landroid/util/AttributeSet;[III)Landroid/content/res/TypedArray;", AccessFlags = 17)]
				public global::Android.Content.Res.TypedArray ObtainStyledAttributes(global::Android.Util.IAttributeSet set, int[] attrs, int defStyleAttr, int defStyleRes) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Res.TypedArray);
				}

				/// <summary>
				///  <para>Retrieve and hold the contents of the preferences file 'name', returning a SharedPreferences through which you can retrieve and modify its values. Only one instance of the SharedPreferences object is returned to any callers for the same name, meaning they will see each other's edits as soon as they are made.</para> <para> <para>MODE_PRIVATE </para> <para>MODE_WORLD_READABLE </para> <para>MODE_WORLD_WRITEABLE </para> <para>MODE_MULTI_PROCESS </para></para>        
				/// </summary>
				/// <returns>
				///  <para>The single SharedPreferences instance that can be used to retrieve and modify the preference values.</para>
				/// </returns>
				/// <java-name>
				/// getSharedPreferences
				/// </java-name>
				[Dot42.DexImport("getSharedPreferences", "(Ljava/lang/String;I)Landroid/content/SharedPreferences;", AccessFlags = 1025)]
				public abstract global::Android.Content.ISharedPreferences GetSharedPreferences(string name, int mode) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Open a private file associated with this Context's application package for reading.</para> <para> <para>openFileOutput </para> <para>fileList </para> <para>deleteFile </para> <para>java.io.FileInputStream::FileInputStream(String) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>The resulting FileInputStream.</para>
				/// </returns>
				/// <java-name>
				/// openFileInput
				/// </java-name>
				[Dot42.DexImport("openFileInput", "(Ljava/lang/String;)Ljava/io/FileInputStream;", AccessFlags = 1025)]
				public abstract global::Java.IO.FileInputStream OpenFileInput(string name) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Open a private file associated with this Context's application package for writing. Creates the file if it doesn't already exist.</para> <para> <para>MODE_APPEND </para> <para>MODE_PRIVATE </para> <para>MODE_WORLD_READABLE </para> <para>MODE_WORLD_WRITEABLE </para> <para>openFileInput </para> <para>fileList </para> <para>deleteFile </para> <para>java.io.FileOutputStream::FileOutputStream(String) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>The resulting FileOutputStream.</para>
				/// </returns>
				/// <java-name>
				/// openFileOutput
				/// </java-name>
				[Dot42.DexImport("openFileOutput", "(Ljava/lang/String;I)Ljava/io/FileOutputStream;", AccessFlags = 1025)]
				public abstract global::Java.IO.FileOutputStream OpenFileOutput(string name, int mode) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Delete the given private file associated with this Context's application package.</para> <para> <para>openFileInput </para> <para>openFileOutput </para> <para>fileList </para> <para>java.io.File::delete() </para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if the file was successfully deleted; else  <c>false </c> .</para>
				/// </returns>
				/// <java-name>
				/// deleteFile
				/// </java-name>
				[Dot42.DexImport("deleteFile", "(Ljava/lang/String;)Z", AccessFlags = 1025)]
				public abstract bool DeleteFile(string name) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns the absolute path on the filesystem where a file created with openFileOutput is stored.</para> <para> <para>openFileOutput </para> <para>getFilesDir </para> <para>getDir </para></para>        
				/// </summary>
				/// <returns>
				///  <para>An absolute path to the given file.</para>
				/// </returns>
				/// <java-name>
				/// getFileStreamPath
				/// </java-name>
				[Dot42.DexImport("getFileStreamPath", "(Ljava/lang/String;)Ljava/io/File;", AccessFlags = 1025)]
				public abstract global::Java.IO.File GetFileStreamPath(string name) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns the absolute path to the directory on the primary external filesystem (that is somewhere on Environment.getExternalStorageDirectory()) where the application can place persistent files it owns. These files are internal to the applications, and not typically visible to the user as media.</para> <para>This is like getFilesDir() in that these files will be deleted when the application is uninstalled, however there are some important differences:</para> <para> <ul> <li> <para>External files are not always available: they will disappear if the user mounts the external storage on a computer or removes it. See the APIs on android.os.Environment for information in the storage state. </para></li> <li> <para>There is no security enforced with these files. For example, any application holding android.Manifest.permission#WRITE_EXTERNAL_STORAGE can write to these files. </para></li></ul></para> <para>Starting in android.os.Build.VERSION_CODES#KITKAT, no permissions are required to read or write to the returned path; it's always accessible to the calling app. This only applies to paths generated for package name of the calling application. To access paths belonging to other packages, android.Manifest.permission#WRITE_EXTERNAL_STORAGE and/or android.Manifest.permission#READ_EXTERNAL_STORAGE are required.</para> <para>On devices with multiple users (as described by UserManager), each user has their own isolated external storage. Applications only have access to the external storage for the user they're running as.</para> <para>Here is an example of typical code to manipulate a file in an application's private storage:</para> <para>{ development/samples/ApiDemos/src/com/example/android/apis/content/ExternalStorage.java private_file}</para> <para>If you supply a non-null  <b>type</b> to this function, the returned file will be a path to a sub-directory of the given type. Though these files are not automatically scanned by the media scanner, you can explicitly add them to the media database with String[], String[], OnScanCompletedListener) MediaScannerConnection.scanFile. Note that this is not the same as Environment.getExternalStoragePublicDirectory(), which provides directories of media shared by all applications. The directories returned here are owned by the application, and their contents will be removed when the application is uninstalled. Unlike Environment.getExternalStoragePublicDirectory(), the directory returned here will be automatically created for you.</para> <para>Here is an example of typical code to manipulate a picture in an application's private storage and add it to the media database:</para> <para>{ development/samples/ApiDemos/src/com/example/android/apis/content/ExternalStorage.java private_picture}</para> <para> <para>getFilesDir </para> <para>android.os.Environment::getExternalStoragePublicDirectory </para></para>        
				/// </summary>
				/// <returns>
				///  <para>The path of the directory holding application files on external storage. Returns null if external storage is not currently mounted so it could not ensure the path exists; you will need to call this method again when it is available.</para>
				/// </returns>
				/// <java-name>
				/// getExternalFilesDir
				/// </java-name>
				[Dot42.DexImport("getExternalFilesDir", "(Ljava/lang/String;)Ljava/io/File;", AccessFlags = 1025)]
				public abstract global::Java.IO.File GetExternalFilesDir(string type) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns an array of strings naming the private files associated with this Context's application package.</para> <para> <para>openFileInput </para> <para>openFileOutput </para> <para>deleteFile </para></para>        
				/// </summary>
				/// <returns>
				///  <para>Array of strings naming the private files.</para>
				/// </returns>
				/// <java-name>
				/// fileList
				/// </java-name>
				[Dot42.DexImport("fileList", "()[Ljava/lang/String;", AccessFlags = 1025)]
				public abstract string[] FileList() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Retrieve, creating if needed, a new directory in which the application can place its own custom data files. You can use the returned File object to create and access files in this directory. Note that files created through a File object will only be accessible by your own application; you can only set the mode of the entire directory, not of individual files.</para> <para> <para>openFileOutput(String, int) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>A File object for the requested directory. The directory will have been created if it does not already exist.</para>
				/// </returns>
				/// <java-name>
				/// getDir
				/// </java-name>
				[Dot42.DexImport("getDir", "(Ljava/lang/String;I)Ljava/io/File;", AccessFlags = 1025)]
				public abstract global::Java.IO.File GetDir(string name, int mode) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Open a new private SQLiteDatabase associated with this Context's application package. Create the database file if it doesn't exist.</para> <para> <para>MODE_PRIVATE </para> <para>MODE_WORLD_READABLE </para> <para>MODE_WORLD_WRITEABLE </para> <para>MODE_ENABLE_WRITE_AHEAD_LOGGING </para> <para>deleteDatabase </para></para>        
				/// </summary>
				/// <returns>
				///  <para>The contents of a newly created database with the given name. </para>
				/// </returns>
				/// <java-name>
				/// openOrCreateDatabase
				/// </java-name>
				[Dot42.DexImport("openOrCreateDatabase", "(Ljava/lang/String;ILandroid/database/sqlite/SQLiteDatabase$CursorFactory;)Landro" +
    "id/database/sqlite/SQLiteDatabase;", AccessFlags = 1025)]
				public abstract global::Android.Database.Sqlite.SQLiteDatabase OpenOrCreateDatabase(string name, int mode, global::Android.Database.Sqlite.SQLiteDatabase.ICursorFactory factory) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Open a new private SQLiteDatabase associated with this Context's application package. Creates the database file if it doesn't exist.</para> <para>Accepts input param: a concrete instance of DatabaseErrorHandler to be used to handle corruption when sqlite reports database corruption.</para> <para> <para>MODE_PRIVATE </para> <para>MODE_WORLD_READABLE </para> <para>MODE_WORLD_WRITEABLE </para> <para>MODE_ENABLE_WRITE_AHEAD_LOGGING </para> <para>deleteDatabase </para></para>        
				/// </summary>
				/// <returns>
				///  <para>The contents of a newly created database with the given name. </para>
				/// </returns>
				/// <java-name>
				/// openOrCreateDatabase
				/// </java-name>
				[Dot42.DexImport("openOrCreateDatabase", "(Ljava/lang/String;ILandroid/database/sqlite/SQLiteDatabase$CursorFactory;Landroi" +
    "d/database/DatabaseErrorHandler;)Landroid/database/sqlite/SQLiteDatabase;", AccessFlags = 1025)]
				public abstract global::Android.Database.Sqlite.SQLiteDatabase OpenOrCreateDatabase(string name, int mode, global::Android.Database.Sqlite.SQLiteDatabase.ICursorFactory factory, global::Android.Database.IDatabaseErrorHandler errorHandler) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Delete an existing private SQLiteDatabase associated with this Context's application package.</para> <para> <para>openOrCreateDatabase </para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if the database was successfully deleted; else <c>false </c> .</para>
				/// </returns>
				/// <java-name>
				/// deleteDatabase
				/// </java-name>
				[Dot42.DexImport("deleteDatabase", "(Ljava/lang/String;)Z", AccessFlags = 1025)]
				public abstract bool DeleteDatabase(string name) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns the absolute path on the filesystem where a database created with openOrCreateDatabase is stored.</para> <para> <para>openOrCreateDatabase </para></para>        
				/// </summary>
				/// <returns>
				///  <para>An absolute path to the given database.</para>
				/// </returns>
				/// <java-name>
				/// getDatabasePath
				/// </java-name>
				[Dot42.DexImport("getDatabasePath", "(Ljava/lang/String;)Ljava/io/File;", AccessFlags = 1025)]
				public abstract global::Java.IO.File GetDatabasePath(string name) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns an array of strings naming the private databases associated with this Context's application package.</para> <para> <para>openOrCreateDatabase </para> <para>deleteDatabase </para></para>        
				/// </summary>
				/// <returns>
				///  <para>Array of strings naming the private databases.</para>
				/// </returns>
				/// <java-name>
				/// databaseList
				/// </java-name>
				[Dot42.DexImport("databaseList", "()[Ljava/lang/String;", AccessFlags = 1025)]
				public abstract string[] DatabaseList() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use WallpaperManager.peek() instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// peekWallpaper
				/// </java-name>
				[Dot42.DexImport("peekWallpaper", "()Landroid/graphics/drawable/Drawable;", AccessFlags = 1025)]
				public abstract global::Android.Graphics.Drawables.Drawable PeekWallpaper() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use WallpaperManager.set() instead. </para></xrefdescription></xrefsect></para> <para>This method requires the caller to hold the permission android.Manifest.permission#SET_WALLPAPER. </para>        
				/// </summary>
				/// <java-name>
				/// setWallpaper
				/// </java-name>
				[Dot42.DexImport("setWallpaper", "(Landroid/graphics/Bitmap;)V", AccessFlags = 1025)]
				public abstract void SetWallpaper(global::Android.Graphics.Bitmap bitmap) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use WallpaperManager.set() instead. </para></xrefdescription></xrefsect></para> <para>This method requires the caller to hold the permission android.Manifest.permission#SET_WALLPAPER. </para>        
				/// </summary>
				/// <java-name>
				/// setWallpaper
				/// </java-name>
				[Dot42.DexImport("setWallpaper", "(Ljava/io/InputStream;)V", AccessFlags = 1025)]
				public abstract void SetWallpaper(global::Java.IO.InputStream bitmap) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use WallpaperManager.clear() instead. </para></xrefdescription></xrefsect></para> <para>This method requires the caller to hold the permission android.Manifest.permission#SET_WALLPAPER. </para>        
				/// </summary>
				/// <java-name>
				/// clearWallpaper
				/// </java-name>
				[Dot42.DexImport("clearWallpaper", "()V", AccessFlags = 1025)]
				public abstract void ClearWallpaper() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Same as startActivity(Intent, Bundle) with no options specified.</para> <para> <para>startActivity(Intent, Bundle) </para> <para>PackageManager::resolveActivity </para></para>        
				/// </summary>
				/// <java-name>
				/// startActivity
				/// </java-name>
				[Dot42.DexImport("startActivity", "(Landroid/content/Intent;)V", AccessFlags = 1025)]
				public abstract void StartActivity(global::Android.Content.Intent intent) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Same as startActivities(Intent[], Bundle) with no options specified.</para> <para> <para>startActivities(Intent[], Bundle) </para> <para>PackageManager::resolveActivity </para></para>        
				/// </summary>
				/// <java-name>
				/// startActivities
				/// </java-name>
				[Dot42.DexImport("startActivities", "([Landroid/content/Intent;)V", AccessFlags = 1025)]
				public abstract void StartActivities(global::Android.Content.Intent[] intents) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Same as startIntentSender(IntentSender, Intent, int, int, int, Bundle) with no options specified.</para> <para> <para>startActivity(Intent) </para> <para>startIntentSender(IntentSender, Intent, int, int, int, Bundle) </para></para>        
				/// </summary>
				/// <java-name>
				/// startIntentSender
				/// </java-name>
				[Dot42.DexImport("startIntentSender", "(Landroid/content/IntentSender;Landroid/content/Intent;III)V", AccessFlags = 1025)]
				public abstract void StartIntentSender(global::Android.Content.IntentSender intent, global::Android.Content.Intent fillInIntent, int flagsMask, int flagsValues, int extraFlags) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Broadcast the given intent to all interested BroadcastReceivers. This call is asynchronous; it returns immediately, and you will continue executing while the receivers are run. No results are propagated from receivers and receivers can not abort the broadcast. If you want to allow receivers to propagate results or abort the broadcast, you must send an ordered broadcast using sendOrderedBroadcast(Intent, String).</para> <para>See BroadcastReceiver for more information on Intent broadcasts.</para> <para> <para>android.content.BroadcastReceiver </para> <para>registerReceiver </para> <para>sendBroadcast(Intent, String) </para> <para>sendOrderedBroadcast(Intent, String) </para> <para>sendOrderedBroadcast(Intent, String, BroadcastReceiver, Handler, int, String, Bundle) </para></para>        
				/// </summary>
				/// <java-name>
				/// sendBroadcast
				/// </java-name>
				[Dot42.DexImport("sendBroadcast", "(Landroid/content/Intent;)V", AccessFlags = 1025)]
				public abstract void SendBroadcast(global::Android.Content.Intent intent) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Broadcast the given intent to all interested BroadcastReceivers, allowing an optional required permission to be enforced. This call is asynchronous; it returns immediately, and you will continue executing while the receivers are run. No results are propagated from receivers and receivers can not abort the broadcast. If you want to allow receivers to propagate results or abort the broadcast, you must send an ordered broadcast using sendOrderedBroadcast(Intent, String).</para> <para>See BroadcastReceiver for more information on Intent broadcasts.</para> <para> <para>android.content.BroadcastReceiver </para> <para>registerReceiver </para> <para>sendBroadcast(Intent) </para> <para>sendOrderedBroadcast(Intent, String) </para> <para>sendOrderedBroadcast(Intent, String, BroadcastReceiver, Handler, int, String, Bundle) </para></para>        
				/// </summary>
				/// <java-name>
				/// sendBroadcast
				/// </java-name>
				[Dot42.DexImport("sendBroadcast", "(Landroid/content/Intent;Ljava/lang/String;)V", AccessFlags = 1025)]
				public abstract void SendBroadcast(global::Android.Content.Intent intent, string receiverPermission) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Broadcast the given intent to all interested BroadcastReceivers, delivering them one at a time to allow more preferred receivers to consume the broadcast before it is delivered to less preferred receivers. This call is asynchronous; it returns immediately, and you will continue executing while the receivers are run.</para> <para>See BroadcastReceiver for more information on Intent broadcasts.</para> <para> <para>android.content.BroadcastReceiver </para> <para>registerReceiver </para> <para>sendBroadcast(Intent) </para> <para>sendOrderedBroadcast(Intent, String, BroadcastReceiver, Handler, int, String, Bundle) </para></para>        
				/// </summary>
				/// <java-name>
				/// sendOrderedBroadcast
				/// </java-name>
				[Dot42.DexImport("sendOrderedBroadcast", "(Landroid/content/Intent;Ljava/lang/String;)V", AccessFlags = 1025)]
				public abstract void SendOrderedBroadcast(global::Android.Content.Intent intent, string receiverPermission) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Version of sendBroadcast(Intent) that allows you to receive data back from the broadcast. This is accomplished by supplying your own BroadcastReceiver when calling, which will be treated as a final receiver at the end of the broadcast  its BroadcastReceiver#onReceive method will be called with the result values collected from the other receivers. The broadcast will be serialized in the same way as calling sendOrderedBroadcast(Intent, String).</para> <para>Like sendBroadcast(Intent), this method is asynchronous; it will return before resultReceiver.onReceive() is called.</para> <para>See BroadcastReceiver for more information on Intent broadcasts.</para> <para> <para>sendBroadcast(Intent) </para> <para>sendBroadcast(Intent, String) </para> <para>sendOrderedBroadcast(Intent, String) </para> <para>sendStickyBroadcast(Intent) </para> <para>sendStickyOrderedBroadcast(Intent, BroadcastReceiver, Handler, int, String, Bundle) </para> <para>android.content.BroadcastReceiver </para> <para>registerReceiver </para> <para>android.app.Activity::RESULT_OK </para></para>        
				/// </summary>
				/// <java-name>
				/// sendOrderedBroadcast
				/// </java-name>
				[Dot42.DexImport("sendOrderedBroadcast", "(Landroid/content/Intent;Ljava/lang/String;Landroid/content/BroadcastReceiver;Lan" +
    "droid/os/Handler;ILjava/lang/String;Landroid/os/Bundle;)V", AccessFlags = 1025)]
				public abstract void SendOrderedBroadcast(global::Android.Content.Intent intent, string receiverPermission, global::Android.Content.BroadcastReceiver resultReceiver, global::Android.OS.Handler scheduler, int initialCode, string initialData, global::Android.OS.Bundle initialExtras) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Perform a sendBroadcast(Intent) that is "sticky," meaning the Intent you are sending stays around after the broadcast is complete, so that others can quickly retrieve that data through the return value of registerReceiver(BroadcastReceiver, IntentFilter). In all other ways, this behaves the same as sendBroadcast(Intent).</para> <para>You must hold the android.Manifest.permission#BROADCAST_STICKY permission in order to use this API. If you do not hold that permission, SecurityException will be thrown.</para> <para> <para>sendBroadcast(Intent) </para> <para>sendStickyOrderedBroadcast(Intent, BroadcastReceiver, Handler, int, String, Bundle) </para></para>        
				/// </summary>
				/// <java-name>
				/// sendStickyBroadcast
				/// </java-name>
				[Dot42.DexImport("sendStickyBroadcast", "(Landroid/content/Intent;)V", AccessFlags = 1025)]
				public abstract void SendStickyBroadcast(global::Android.Content.Intent intent) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Version of sendStickyBroadcast that allows you to receive data back from the broadcast. This is accomplished by supplying your own BroadcastReceiver when calling, which will be treated as a final receiver at the end of the broadcast  its BroadcastReceiver#onReceive method will be called with the result values collected from the other receivers. The broadcast will be serialized in the same way as calling sendOrderedBroadcast(Intent, String).</para> <para>Like sendBroadcast(Intent), this method is asynchronous; it will return before resultReceiver.onReceive() is called. Note that the sticky data stored is only the data you initially supply to the broadcast, not the result of any changes made by the receivers.</para> <para>See BroadcastReceiver for more information on Intent broadcasts.</para> <para> <para>sendBroadcast(Intent) </para> <para>sendBroadcast(Intent, String) </para> <para>sendOrderedBroadcast(Intent, String) </para> <para>sendStickyBroadcast(Intent) </para> <para>android.content.BroadcastReceiver </para> <para>registerReceiver </para> <para>android.app.Activity::RESULT_OK </para></para>        
				/// </summary>
				/// <java-name>
				/// sendStickyOrderedBroadcast
				/// </java-name>
				[Dot42.DexImport("sendStickyOrderedBroadcast", "(Landroid/content/Intent;Landroid/content/BroadcastReceiver;Landroid/os/Handler;I" +
    "Ljava/lang/String;Landroid/os/Bundle;)V", AccessFlags = 1025)]
				public abstract void SendStickyOrderedBroadcast(global::Android.Content.Intent intent, global::Android.Content.BroadcastReceiver resultReceiver, global::Android.OS.Handler scheduler, int initialCode, string initialData, global::Android.OS.Bundle initialExtras) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Remove the data previously sent with sendStickyBroadcast, so that it is as if the sticky broadcast had never happened.</para> <para>You must hold the android.Manifest.permission#BROADCAST_STICKY permission in order to use this API. If you do not hold that permission, SecurityException will be thrown.</para> <para> <para>sendStickyBroadcast </para></para>        
				/// </summary>
				/// <java-name>
				/// removeStickyBroadcast
				/// </java-name>
				[Dot42.DexImport("removeStickyBroadcast", "(Landroid/content/Intent;)V", AccessFlags = 1025)]
				public abstract void RemoveStickyBroadcast(global::Android.Content.Intent intent) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Register a BroadcastReceiver to be run in the main activity thread. The  <b>receiver</b> will be called with any broadcast Intent that matches  <b>filter</b>, in the main application thread.</para> <para>The system may broadcast Intents that are "sticky"  these stay around after the broadcast as finished, to be sent to any later registrations. If your IntentFilter matches one of these sticky Intents, that Intent will be returned by this function  <b>and</b> sent to your  <b>receiver</b> as if it had just been broadcast.</para> <para>There may be multiple sticky Intents that match  <b>filter</b>, in which case each of these will be sent to  <b>receiver</b>. In this case, only one of these can be returned directly by the function; which of these that is returned is arbitrarily decided by the system.</para> <para>If you know the Intent your are registering for is sticky, you can supply null for your  <b>receiver</b>. In this case, no receiver is registered  the function simply returns the sticky Intent that matches  <b>filter</b>. In the case of multiple matches, the same rules as described above apply.</para> <para>See BroadcastReceiver for more information on Intent broadcasts.</para> <para>As of android.os.Build.VERSION_CODES#ICE_CREAM_SANDWICH, receivers registered with this method will correctly respect the Intent#setPackage(String) specified for an Intent being broadcast. Prior to that, it would be ignored and delivered to all matching registered receivers. Be careful if using this for security.</para> <para>Note: this method  <b>cannot be called from a BroadcastReceiver component;</b> that is, from a BroadcastReceiver that is declared in an application's manifest. It is okay, however, to call this method from another BroadcastReceiver that has itself been registered at run time with registerReceiver, since the lifetime of such a registered BroadcastReceiver is tied to the object that registered it.</para> <para> <para>registerReceiver(BroadcastReceiver, IntentFilter, String, Handler) </para> <para>sendBroadcast </para> <para>unregisterReceiver </para></para>        
				/// </summary>
				/// <returns>
				///  <para>The first sticky intent found that matches  <b>filter</b>, or null if there are none.</para>
				/// </returns>
				/// <java-name>
				/// registerReceiver
				/// </java-name>
				[Dot42.DexImport("registerReceiver", "(Landroid/content/BroadcastReceiver;Landroid/content/IntentFilter;)Landroid/conte" +
    "nt/Intent;", AccessFlags = 1025)]
				public abstract global::Android.Content.Intent RegisterReceiver(global::Android.Content.BroadcastReceiver receiver, global::Android.Content.IntentFilter filter) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Register to receive intent broadcasts, to run in the context of  <b>scheduler</b>. See registerReceiver(BroadcastReceiver, IntentFilter) for more information. This allows you to enforce permissions on who can broadcast intents to your receiver, or have the receiver run in a different thread than the main application thread.</para> <para>See BroadcastReceiver for more information on Intent broadcasts.</para> <para>As of android.os.Build.VERSION_CODES#ICE_CREAM_SANDWICH, receivers registered with this method will correctly respect the Intent#setPackage(String) specified for an Intent being broadcast. Prior to that, it would be ignored and delivered to all matching registered receivers. Be careful if using this for security.</para> <para> <para>registerReceiver(BroadcastReceiver, IntentFilter) </para> <para>sendBroadcast </para> <para>unregisterReceiver </para></para>        
				/// </summary>
				/// <returns>
				///  <para>The first sticky intent found that matches  <b>filter</b>, or null if there are none.</para>
				/// </returns>
				/// <java-name>
				/// registerReceiver
				/// </java-name>
				[Dot42.DexImport("registerReceiver", "(Landroid/content/BroadcastReceiver;Landroid/content/IntentFilter;Ljava/lang/Stri" +
    "ng;Landroid/os/Handler;)Landroid/content/Intent;", AccessFlags = 1025)]
				public abstract global::Android.Content.Intent RegisterReceiver(global::Android.Content.BroadcastReceiver receiver, global::Android.Content.IntentFilter filter, string broadcastPermission, global::Android.OS.Handler scheduler) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Unregister a previously registered BroadcastReceiver.  <b>All</b> filters that have been registered for this BroadcastReceiver will be removed.</para> <para> <para>registerReceiver </para></para>        
				/// </summary>
				/// <java-name>
				/// unregisterReceiver
				/// </java-name>
				[Dot42.DexImport("unregisterReceiver", "(Landroid/content/BroadcastReceiver;)V", AccessFlags = 1025)]
				public abstract void UnregisterReceiver(global::Android.Content.BroadcastReceiver receiver) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Request that a given application service be started. The Intent should contain either contain the complete class name of a specific service implementation to start or a specific package name to target. If the Intent is less specified, it log a warning about this and which of the multiple matching services it finds and uses will be undefined. If this service is not already running, it will be instantiated and started (creating a process for it if needed); if it is running then it remains running.</para> <para>Every call to this method will result in a corresponding call to the target service's android.app.Service#onStartCommand method, with the  <b>intent</b> given here. This provides a convenient way to submit jobs to a service without having to bind and call on to its interface.</para> <para>Using startService() overrides the default service lifetime that is managed by bindService: it requires the service to remain running until stopService is called, regardless of whether any clients are connected to it. Note that calls to startService() are not nesting: no matter how many times you call startService(), a single call to stopService will stop it.</para> <para>The system attempts to keep running services around as much as possible. The only time they should be stopped is if the current foreground application is using so many resources that the service needs to be killed. If any errors happen in the service's process, it will automatically be restarted.</para> <para>This function will throw SecurityException if you do not have permission to start the given service.</para> <para> <para>stopService </para> <para>bindService </para></para>        
				/// </summary>
				/// <returns>
				///  <para>If the service is being started or is already running, the ComponentName of the actual service that was started is returned; else if the service does not exist null is returned.</para>
				/// </returns>
				/// <java-name>
				/// startService
				/// </java-name>
				[Dot42.DexImport("startService", "(Landroid/content/Intent;)Landroid/content/ComponentName;", AccessFlags = 1025)]
				public abstract global::Android.Content.ComponentName StartService(global::Android.Content.Intent service) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Request that a given application service be stopped. If the service is not running, nothing happens. Otherwise it is stopped. Note that calls to startService() are not counted  this stops the service no matter how many times it was started.</para> <para>Note that if a stopped service still has ServiceConnection objects bound to it with the BIND_AUTO_CREATE set, it will not be destroyed until all of these bindings are removed. See the android.app.Service documentation for more details on a service's lifecycle.</para> <para>This function will throw SecurityException if you do not have permission to stop the given service.</para> <para> <para>startService </para></para>        
				/// </summary>
				/// <returns>
				///  <para>If there is a service matching the given Intent that is already running, then it is stopped and <c>true </c> is returned; else <c>false </c> is returned.</para>
				/// </returns>
				/// <java-name>
				/// stopService
				/// </java-name>
				[Dot42.DexImport("stopService", "(Landroid/content/Intent;)Z", AccessFlags = 1025)]
				public abstract bool StopService(global::Android.Content.Intent service) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Connect to an application service, creating it if needed. This defines a dependency between your application and the service. The given  <b>conn</b> will receive the service object when it is created and be told if it dies and restarts. The service will be considered required by the system only for as long as the calling context exists. For example, if this Context is an Activity that is stopped, the service will not be required to continue running until the Activity is resumed.</para> <para>This function will throw SecurityException if you do not have permission to bind to the given service.</para> <para>Note: this method  <b>can not be called from a BroadcastReceiver component</b>. A pattern you can use to communicate from a BroadcastReceiver to a Service is to call startService with the arguments containing the command to be sent, with the service calling its android.app.Service#stopSelf(int) method when done executing that command. See the API demo App/Service/Service Start Arguments Controller for an illustration of this. It is okay, however, to use this method from a BroadcastReceiver that has been registered with registerReceiver, since the lifetime of this BroadcastReceiver is tied to another object (the one that registered it).</para> <para> <para>unbindService </para> <para>startService </para> <para>BIND_AUTO_CREATE </para> <para>BIND_DEBUG_UNBIND </para> <para>BIND_NOT_FOREGROUND </para></para>        
				/// </summary>
				/// <returns>
				///  <para>If you have successfully bound to the service, <c>true </c> is returned;  <c>false </c> is returned if the connection is not made so you will not receive the service object.</para>
				/// </returns>
				/// <java-name>
				/// bindService
				/// </java-name>
				[Dot42.DexImport("bindService", "(Landroid/content/Intent;Landroid/content/ServiceConnection;I)Z", AccessFlags = 1025)]
				public abstract bool BindService(global::Android.Content.Intent service, global::Android.Content.IServiceConnection conn, int flags) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Disconnect from an application service. You will no longer receive calls as the service is restarted, and the service is now allowed to stop at any time.</para> <para> <para>bindService </para></para>        
				/// </summary>
				/// <java-name>
				/// unbindService
				/// </java-name>
				[Dot42.DexImport("unbindService", "(Landroid/content/ServiceConnection;)V", AccessFlags = 1025)]
				public abstract void UnbindService(global::Android.Content.IServiceConnection conn) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Start executing an android.app.Instrumentation class. The given Instrumentation component will be run by killing its target application (if currently running), starting the target process, instantiating the instrumentation component, and then letting it drive the application.</para> <para>This function is not synchronous  it returns as soon as the instrumentation has started and while it is running.</para> <para>Instrumentation is normally only allowed to run against a package that is either unsigned or signed with a signature that the the instrumentation package is also signed with (ensuring the target trusts the instrumentation).</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if the instrumentation was successfully started, else <c>false </c> if it could not be found. </para>
				/// </returns>
				/// <java-name>
				/// startInstrumentation
				/// </java-name>
				[Dot42.DexImport("startInstrumentation", "(Landroid/content/ComponentName;Ljava/lang/String;Landroid/os/Bundle;)Z", AccessFlags = 1025)]
				public abstract bool StartInstrumentation(global::Android.Content.ComponentName className, string profileFile, global::Android.OS.Bundle arguments) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Return the handle to a system-level service by name. The class of the returned object varies by the requested name. Currently available names are:</para> <para></para> <para>Note: System services obtained via this API may be closely associated with the Context in which they are obtained from. In general, do not share the service objects between various different contexts (Activities, Applications, Services, Providers, etc.)</para> <para> <para>WINDOW_SERVICE </para> <para>android.view.WindowManager </para> <para>LAYOUT_INFLATER_SERVICE </para> <para>android.view.LayoutInflater </para> <para>ACTIVITY_SERVICE </para> <para>android.app.ActivityManager </para> <para>POWER_SERVICE </para> <para>android.os.PowerManager </para> <para>ALARM_SERVICE </para> <para>android.app.AlarmManager </para> <para>NOTIFICATION_SERVICE </para> <para>android.app.NotificationManager </para> <para>KEYGUARD_SERVICE </para> <para>android.app.KeyguardManager </para> <para>LOCATION_SERVICE </para> <para>android.location.LocationManager </para> <para>SEARCH_SERVICE </para> <para>android.app.SearchManager </para> <para>SENSOR_SERVICE </para> <para>android.hardware.SensorManager </para> <para>STORAGE_SERVICE </para> <para>android.os.storage.StorageManager </para> <para>VIBRATOR_SERVICE </para> <para>android.os.Vibrator </para> <para>CONNECTIVITY_SERVICE </para> <para>android.net.ConnectivityManager </para> <para>WIFI_SERVICE </para> <para>android.net.wifi.WifiManager </para> <para>AUDIO_SERVICE </para> <para>android.media.AudioManager </para> <para>MEDIA_ROUTER_SERVICE </para> <para>android.media.MediaRouter </para> <para>TELEPHONY_SERVICE </para> <para>android.telephony.TelephonyManager </para> <para>INPUT_METHOD_SERVICE </para> <para>android.view.inputmethod.InputMethodManager </para> <para>UI_MODE_SERVICE </para> <para>android.app.UiModeManager </para> <para>DOWNLOAD_SERVICE </para> <para>android.app.DownloadManager </para></para>        
				/// </summary>
				/// <returns>
				///  <para>The service or null if the name does not exist.</para>
				/// </returns>
				/// <java-name>
				/// getSystemService
				/// </java-name>
				[Dot42.DexImport("getSystemService", "(Ljava/lang/String;)Ljava/lang/Object;", AccessFlags = 1025)]
				public abstract object GetSystemService(string name) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Determine whether the given permission is allowed for a particular process and user ID running in the system.</para> <para> <para>PackageManager::checkPermission(String, String) </para> <para>checkCallingPermission </para></para>        
				/// </summary>
				/// <returns>
				///  <para>PackageManager#PERMISSION_GRANTED if the given pid/uid is allowed that permission, or PackageManager#PERMISSION_DENIED if it is not.</para>
				/// </returns>
				/// <java-name>
				/// checkPermission
				/// </java-name>
				[Dot42.DexImport("checkPermission", "(Ljava/lang/String;II)I", AccessFlags = 1025)]
				public abstract int CheckPermission(string permission, int pid, int uid) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Determine whether the calling process of an IPC you are handling has been granted a particular permission. This is basically the same as calling checkPermission(String, int, int) with the pid and uid returned by android.os.Binder#getCallingPid and android.os.Binder#getCallingUid. One important difference is that if you are not currently processing an IPC, this function will always fail. This is done to protect against accidentally leaking permissions; you can use checkCallingOrSelfPermission to avoid this protection.</para> <para> <para>PackageManager::checkPermission(String, String) </para> <para>checkPermission </para> <para>checkCallingOrSelfPermission </para></para>        
				/// </summary>
				/// <returns>
				///  <para>PackageManager#PERMISSION_GRANTED if the calling pid/uid is allowed that permission, or PackageManager#PERMISSION_DENIED if it is not.</para>
				/// </returns>
				/// <java-name>
				/// checkCallingPermission
				/// </java-name>
				[Dot42.DexImport("checkCallingPermission", "(Ljava/lang/String;)I", AccessFlags = 1025)]
				public abstract int CheckCallingPermission(string permission) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Determine whether the calling process of an IPC  <b>or you</b> have been granted a particular permission. This is the same as checkCallingPermission, except it grants your own permissions if you are not currently processing an IPC. Use with care!</para> <para> <para>PackageManager::checkPermission(String, String) </para> <para>checkPermission </para> <para>checkCallingPermission </para></para>        
				/// </summary>
				/// <returns>
				///  <para>PackageManager#PERMISSION_GRANTED if the calling pid/uid is allowed that permission, or PackageManager#PERMISSION_DENIED if it is not.</para>
				/// </returns>
				/// <java-name>
				/// checkCallingOrSelfPermission
				/// </java-name>
				[Dot42.DexImport("checkCallingOrSelfPermission", "(Ljava/lang/String;)I", AccessFlags = 1025)]
				public abstract int CheckCallingOrSelfPermission(string permission) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>If the given permission is not allowed for a particular process and user ID running in the system, throw a SecurityException.</para> <para> <para>checkPermission(String, int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// enforcePermission
				/// </java-name>
				[Dot42.DexImport("enforcePermission", "(Ljava/lang/String;IILjava/lang/String;)V", AccessFlags = 1025)]
				public abstract void EnforcePermission(string permission, int pid, int uid, string message) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>If the calling process of an IPC you are handling has not been granted a particular permission, throw a SecurityException. This is basically the same as calling enforcePermission(String, int, int, String) with the pid and uid returned by android.os.Binder#getCallingPid and android.os.Binder#getCallingUid. One important difference is that if you are not currently processing an IPC, this function will always throw the SecurityException. This is done to protect against accidentally leaking permissions; you can use enforceCallingOrSelfPermission to avoid this protection.</para> <para> <para>checkCallingPermission(String) </para></para>        
				/// </summary>
				/// <java-name>
				/// enforceCallingPermission
				/// </java-name>
				[Dot42.DexImport("enforceCallingPermission", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1025)]
				public abstract void EnforceCallingPermission(string permission, string message) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>If neither you nor the calling process of an IPC you are handling has been granted a particular permission, throw a SecurityException. This is the same as enforceCallingPermission, except it grants your own permissions if you are not currently processing an IPC. Use with care!</para> <para> <para>checkCallingOrSelfPermission(String) </para></para>        
				/// </summary>
				/// <java-name>
				/// enforceCallingOrSelfPermission
				/// </java-name>
				[Dot42.DexImport("enforceCallingOrSelfPermission", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1025)]
				public abstract void EnforceCallingOrSelfPermission(string permission, string message) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Grant permission to access a specific Uri to another package, regardless of whether that package has general permission to access the Uri's content provider. This can be used to grant specific, temporary permissions, typically in response to user interaction (such as the user opening an attachment that you would like someone else to display).</para> <para>Normally you should use Intent.FLAG_GRANT_READ_URI_PERMISSION or Intent.FLAG_GRANT_WRITE_URI_PERMISSION with the Intent being used to start an activity instead of this function directly. If you use this function directly, you should be sure to call revokeUriPermission when the target should no longer be allowed to access it.</para> <para>To succeed, the content provider owning the Uri must have set the grantUriPermissions attribute in its manifest or included the &lt;grant-uri-permissions&gt; tag.</para> <para> <para>revokeUriPermission </para></para>        
				/// </summary>
				/// <java-name>
				/// grantUriPermission
				/// </java-name>
				[Dot42.DexImport("grantUriPermission", "(Ljava/lang/String;Landroid/net/Uri;I)V", AccessFlags = 1025)]
				public abstract void GrantUriPermission(string toPackage, global::Android.Net.Uri uri, int modeFlags) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Remove all permissions to access a particular content provider Uri that were previously added with grantUriPermission. The given Uri will match all previously granted Uris that are the same or a sub-path of the given Uri. That is, revoking "content://foo/target" will revoke both "content://foo/target" and "content://foo/target/sub", but not "content://foo".</para> <para> <para>grantUriPermission </para></para>        
				/// </summary>
				/// <java-name>
				/// revokeUriPermission
				/// </java-name>
				[Dot42.DexImport("revokeUriPermission", "(Landroid/net/Uri;I)V", AccessFlags = 1025)]
				public abstract void RevokeUriPermission(global::Android.Net.Uri uri, int modeFlags) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Determine whether a particular process and user ID has been granted permission to access a specific URI. This only checks for permissions that have been explicitly granted  if the given process/uid has more general access to the URI's content provider then this check will always fail.</para> <para> <para>checkCallingUriPermission </para></para>        
				/// </summary>
				/// <returns>
				///  <para>PackageManager#PERMISSION_GRANTED if the given pid/uid is allowed to access that uri, or PackageManager#PERMISSION_DENIED if it is not.</para>
				/// </returns>
				/// <java-name>
				/// checkUriPermission
				/// </java-name>
				[Dot42.DexImport("checkUriPermission", "(Landroid/net/Uri;III)I", AccessFlags = 1025)]
				public abstract int CheckUriPermission(global::Android.Net.Uri uri, int pid, int uid, int modeFlags) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Determine whether the calling process and user ID has been granted permission to access a specific URI. This is basically the same as calling int, int, int) with the pid and uid returned by android.os.Binder#getCallingPid and android.os.Binder#getCallingUid. One important difference is that if you are not currently processing an IPC, this function will always fail.</para> <para> <para>checkUriPermission(Uri, int, int, int) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>PackageManager#PERMISSION_GRANTED if the caller is allowed to access that uri, or PackageManager#PERMISSION_DENIED if it is not.</para>
				/// </returns>
				/// <java-name>
				/// checkCallingUriPermission
				/// </java-name>
				[Dot42.DexImport("checkCallingUriPermission", "(Landroid/net/Uri;I)I", AccessFlags = 1025)]
				public abstract int CheckCallingUriPermission(global::Android.Net.Uri uri, int modeFlags) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Determine whether the calling process of an IPC  <b>or you</b> has been granted permission to access a specific URI. This is the same as checkCallingUriPermission, except it grants your own permissions if you are not currently processing an IPC. Use with care!</para> <para> <para>checkCallingUriPermission </para></para>        
				/// </summary>
				/// <returns>
				///  <para>PackageManager#PERMISSION_GRANTED if the caller is allowed to access that uri, or PackageManager#PERMISSION_DENIED if it is not.</para>
				/// </returns>
				/// <java-name>
				/// checkCallingOrSelfUriPermission
				/// </java-name>
				[Dot42.DexImport("checkCallingOrSelfUriPermission", "(Landroid/net/Uri;I)I", AccessFlags = 1025)]
				public abstract int CheckCallingOrSelfUriPermission(global::Android.Net.Uri uri, int modeFlags) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Check both a Uri and normal permission. This allows you to perform both checkPermission and checkUriPermission in one call.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>PackageManager#PERMISSION_GRANTED if the caller is allowed to access that uri or holds one of the given permissions, or PackageManager#PERMISSION_DENIED if it is not. </para>
				/// </returns>
				/// <java-name>
				/// checkUriPermission
				/// </java-name>
				[Dot42.DexImport("checkUriPermission", "(Landroid/net/Uri;Ljava/lang/String;Ljava/lang/String;III)I", AccessFlags = 1025)]
				public abstract int CheckUriPermission(global::Android.Net.Uri uri, string readPermission, string writePermission, int pid, int uid, int modeFlags) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>If a particular process and user ID has not been granted permission to access a specific URI, throw SecurityException. This only checks for permissions that have been explicitly granted  if the given process/uid has more general access to the URI's content provider then this check will always fail.</para> <para> <para>checkUriPermission(Uri, int, int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// enforceUriPermission
				/// </java-name>
				[Dot42.DexImport("enforceUriPermission", "(Landroid/net/Uri;IIILjava/lang/String;)V", AccessFlags = 1025)]
				public abstract void EnforceUriPermission(global::Android.Net.Uri uri, int pid, int uid, int modeFlags, string message) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>If the calling process and user ID has not been granted permission to access a specific URI, throw SecurityException. This is basically the same as calling enforceUriPermission(Uri, int, int, int, String) with the pid and uid returned by android.os.Binder#getCallingPid and android.os.Binder#getCallingUid. One important difference is that if you are not currently processing an IPC, this function will always throw a SecurityException.</para> <para> <para>checkCallingUriPermission(Uri, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// enforceCallingUriPermission
				/// </java-name>
				[Dot42.DexImport("enforceCallingUriPermission", "(Landroid/net/Uri;ILjava/lang/String;)V", AccessFlags = 1025)]
				public abstract void EnforceCallingUriPermission(global::Android.Net.Uri uri, int modeFlags, string message) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>If the calling process of an IPC  <b>or you</b> has not been granted permission to access a specific URI, throw SecurityException. This is the same as enforceCallingUriPermission, except it grants your own permissions if you are not currently processing an IPC. Use with care!</para> <para> <para>checkCallingOrSelfUriPermission(Uri, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// enforceCallingOrSelfUriPermission
				/// </java-name>
				[Dot42.DexImport("enforceCallingOrSelfUriPermission", "(Landroid/net/Uri;ILjava/lang/String;)V", AccessFlags = 1025)]
				public abstract void EnforceCallingOrSelfUriPermission(global::Android.Net.Uri uri, int modeFlags, string message) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Enforce both a Uri and normal permission. This allows you to perform both enforcePermission and enforceUriPermission in one call.</para> <para> <para>checkUriPermission(Uri, String, String, int, int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// enforceUriPermission
				/// </java-name>
				[Dot42.DexImport("enforceUriPermission", "(Landroid/net/Uri;Ljava/lang/String;Ljava/lang/String;IIILjava/lang/String;)V", AccessFlags = 1025)]
				public abstract void EnforceUriPermission(global::Android.Net.Uri uri, string readPermission, string writePermission, int pid, int uid, int modeFlags, string message) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Return a new Context object for the given application name. This Context is the same as what the named application gets when it is launched, containing the same resources and class loader. Each call to this method returns a new instance of a Context object; Context objects are not shared, however they share common state (Resources, ClassLoader, etc) so the Context instance itself is fairly lightweight.</para> <para>Throws PackageManager.NameNotFoundException if there is no application with the given package name.</para> <para>Throws java.lang.SecurityException if the Context requested can not be loaded into the caller's process for security reasons (see CONTEXT_INCLUDE_CODE for more information}.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>A Context for the application.</para>
				/// </returns>
				/// <java-name>
				/// createPackageContext
				/// </java-name>
				[Dot42.DexImport("createPackageContext", "(Ljava/lang/String;I)Landroid/content/Context;", AccessFlags = 1025)]
				public abstract global::Android.Content.Context CreatePackageContext(string packageName, int flags) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Return an AssetManager instance for your application's package. </para>        
				/// </summary>
				/// <java-name>
				/// getAssets
				/// </java-name>
				public abstract global::Android.Content.Res.AssetManager Assets
				{
						[Dot42.DexImport("getAssets", "()Landroid/content/res/AssetManager;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Return a Resources instance for your application's package. </para>        
				/// </summary>
				/// <java-name>
				/// getResources
				/// </java-name>
				public abstract global::Android.Content.Res.Resources Resources
				{
						[Dot42.DexImport("getResources", "()Landroid/content/res/Resources;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Return PackageManager instance to find global package information. </para>        
				/// </summary>
				/// <java-name>
				/// getPackageManager
				/// </java-name>
				public abstract global::Android.Content.PM.PackageManager PackageManager
				{
						[Dot42.DexImport("getPackageManager", "()Landroid/content/pm/PackageManager;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Return a ContentResolver instance for your application's package. </para>        
				/// </summary>
				/// <java-name>
				/// getContentResolver
				/// </java-name>
				public abstract global::Android.Content.ContentResolver ContentResolver
				{
						[Dot42.DexImport("getContentResolver", "()Landroid/content/ContentResolver;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Return the Looper for the main thread of the current process. This is the thread used to dispatch calls to application components (activities, services, etc). </para> <para>By definition, this method returns the same result as would be obtained by calling Looper.getMainLooper(). </para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The main looper. </para>
				/// </returns>
				/// <java-name>
				/// getMainLooper
				/// </java-name>
				public abstract global::Android.OS.Looper MainLooper
				{
						[Dot42.DexImport("getMainLooper", "()Landroid/os/Looper;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Return the context of the single, global Application object of the current process. This generally should only be used if you need a Context whose lifecycle is separate from the current context, that is tied to the lifetime of the process rather than the current component.</para> <para>Consider for example how this interacts with registerReceiver(BroadcastReceiver, IntentFilter):  <ul> <li> <para></para> <para>If used from an Activity context, the receiver is being registered within that activity. This means that you are expected to unregister before the activity is done being destroyed; in fact if you do not do so, the framework will clean up your leaked registration as it removes the activity and log an error. Thus, if you use the Activity context to register a receiver that is static (global to the process, not associated with an Activity instance) then that registration will be removed on you at whatever point the activity you used is destroyed. </para></li> <li> <para></para> <para>If used from the Context returned here, the receiver is being registered with the global state associated with your application. Thus it will never be unregistered for you. This is necessary if the receiver is associated with static data, not a particular component. However using the ApplicationContext elsewhere can easily lead to serious leaks if you forget to unregister, unbind, etc. </para></li></ul></para>        
				/// </summary>
				/// <java-name>
				/// getApplicationContext
				/// </java-name>
				public abstract global::Android.Content.Context ApplicationContext
				{
						[Dot42.DexImport("getApplicationContext", "()Landroid/content/Context;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Return the Theme object associated with this Context. </para>        
				/// </summary>
				/// <java-name>
				/// getTheme
				/// </java-name>
				public abstract global::Android.Content.Res.Resources.Theme Theme
				{
						[Dot42.DexImport("getTheme", "()Landroid/content/res/Resources$Theme;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Return a class loader you can use to retrieve classes in this package. </para>        
				/// </summary>
				/// <java-name>
				/// getClassLoader
				/// </java-name>
				public abstract global::Java.Lang.ClassLoader ClassLoader
				{
						[Dot42.DexImport("getClassLoader", "()Ljava/lang/ClassLoader;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Return the name of this application's package. </para>        
				/// </summary>
				/// <java-name>
				/// getPackageName
				/// </java-name>
				public abstract string PackageName
				{
						[Dot42.DexImport("getPackageName", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Return the full application info for this context's package. </para>        
				/// </summary>
				/// <java-name>
				/// getApplicationInfo
				/// </java-name>
				public abstract global::Android.Content.PM.ApplicationInfo ApplicationInfo
				{
						[Dot42.DexImport("getApplicationInfo", "()Landroid/content/pm/ApplicationInfo;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Return the full path to this context's primary Android package. The Android package is a ZIP file which contains the application's primary resources.</para> <para>Note: this is not generally useful for applications, since they should not be directly accessing the file system.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>String Path to the resources. </para>
				/// </returns>
				/// <java-name>
				/// getPackageResourcePath
				/// </java-name>
				public abstract string PackageResourcePath
				{
						[Dot42.DexImport("getPackageResourcePath", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Return the full path to this context's primary Android package. The Android package is a ZIP file which contains application's primary code and assets.</para> <para>Note: this is not generally useful for applications, since they should not be directly accessing the file system.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>String Path to the code and assets. </para>
				/// </returns>
				/// <java-name>
				/// getPackageCodePath
				/// </java-name>
				public abstract string PackageCodePath
				{
						[Dot42.DexImport("getPackageCodePath", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Returns the absolute path to the directory on the filesystem where files created with openFileOutput are stored.</para> <para> <para>openFileOutput </para> <para>getFileStreamPath </para> <para>getDir </para></para>        
				/// </summary>
				/// <returns>
				///  <para>The path of the directory holding application files.</para>
				/// </returns>
				/// <java-name>
				/// getFilesDir
				/// </java-name>
				public abstract global::Java.IO.File FilesDir
				{
						[Dot42.DexImport("getFilesDir", "()Ljava/io/File;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Return the primary external storage directory where this application's OBB files (if there are any) can be found. Note if the application does not have any OBB files, this directory may not exist. </para> <para>This is like getFilesDir() in that these files will be deleted when the application is uninstalled, however there are some important differences:  <ul> <li> <para>External files are not always available: they will disappear if the user mounts the external storage on a computer or removes it. </para></li> <li> <para>There is no security enforced with these files. For example, any application holding android.Manifest.permission#WRITE_EXTERNAL_STORAGE can write to these files. </para></li></ul></para> <para>Starting in android.os.Build.VERSION_CODES#KITKAT, no permissions are required to read or write to the returned path; it's always accessible to the calling app. This only applies to paths generated for package name of the calling application. To access paths belonging to other packages, android.Manifest.permission#WRITE_EXTERNAL_STORAGE and/or android.Manifest.permission#READ_EXTERNAL_STORAGE are required. </para> <para>On devices with multiple users (as described by UserManager), multiple users may share the same OBB storage location. Applications should ensure that multiple instances running under different users don't interfere with each other. </para>        
				/// </summary>
				/// <java-name>
				/// getObbDir
				/// </java-name>
				public abstract global::Java.IO.File ObbDir
				{
						[Dot42.DexImport("getObbDir", "()Ljava/io/File;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Returns the absolute path to the application specific cache directory on the filesystem. These files will be ones that get deleted first when the device runs low on storage. There is no guarantee when these files will be deleted.</para> <para> <b>Note: you should not  <b>rely</b> on the system deleting these files for you; you should always have a reasonable maximum, such as 1 MB, for the amount of space you consume with cache files, and prune those files when exceeding that space.</b></para> <para> <para>openFileOutput </para> <para>getFileStreamPath </para> <para>getDir </para></para>        
				/// </summary>
				/// <returns>
				///  <para>The path of the directory holding application cache files.</para>
				/// </returns>
				/// <java-name>
				/// getCacheDir
				/// </java-name>
				public abstract global::Java.IO.File CacheDir
				{
						[Dot42.DexImport("getCacheDir", "()Ljava/io/File;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Returns the absolute path to the directory on the primary external filesystem (that is somewhere on Environment.getExternalStorageDirectory() where the application can place cache files it owns. These files are internal to the application, and not typically visible to the user as media.</para> <para>This is like getCacheDir() in that these files will be deleted when the application is uninstalled, however there are some important differences:</para> <para> <ul> <li> <para>The platform does not always monitor the space available in external storage, and thus may not automatically delete these files. Currently the only time files here will be deleted by the platform is when running on android.os.Build.VERSION_CODES#JELLY_BEAN_MR1 or later and Environment.isExternalStorageEmulated() returns true. Note that you should be managing the maximum space you will use for these anyway, just like with getCacheDir(). </para></li> <li> <para>External files are not always available: they will disappear if the user mounts the external storage on a computer or removes it. See the APIs on android.os.Environment for information in the storage state. </para></li> <li> <para>There is no security enforced with these files. For example, any application holding android.Manifest.permission#WRITE_EXTERNAL_STORAGE can write to these files. </para></li></ul></para> <para>Starting in android.os.Build.VERSION_CODES#KITKAT, no permissions are required to read or write to the returned path; it's always accessible to the calling app. This only applies to paths generated for package name of the calling application. To access paths belonging to other packages, android.Manifest.permission#WRITE_EXTERNAL_STORAGE and/or android.Manifest.permission#READ_EXTERNAL_STORAGE are required.</para> <para>On devices with multiple users (as described by UserManager), each user has their own isolated external storage. Applications only have access to the external storage for the user they're running as.</para> <para> <para>getCacheDir </para></para>        
				/// </summary>
				/// <returns>
				///  <para>The path of the directory holding application cache files on external storage. Returns null if external storage is not currently mounted so it could not ensure the path exists; you will need to call this method again when it is available.</para>
				/// </returns>
				/// <java-name>
				/// getExternalCacheDir
				/// </java-name>
				public abstract global::Java.IO.File ExternalCacheDir
				{
						[Dot42.DexImport("getExternalCacheDir", "()Ljava/io/File;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use WallpaperManager.get() instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// getWallpaper
				/// </java-name>
				public abstract global::Android.Graphics.Drawables.Drawable Wallpaper
				{
						[Dot42.DexImport("getWallpaper", "()Landroid/graphics/drawable/Drawable;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use WallpaperManager.getDesiredMinimumWidth() instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// getWallpaperDesiredMinimumWidth
				/// </java-name>
				public abstract int WallpaperDesiredMinimumWidth
				{
						[Dot42.DexImport("getWallpaperDesiredMinimumWidth", "()I", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use WallpaperManager.getDesiredMinimumHeight() instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// getWallpaperDesiredMinimumHeight
				/// </java-name>
				public abstract int WallpaperDesiredMinimumHeight
				{
						[Dot42.DexImport("getWallpaperDesiredMinimumHeight", "()I", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Indicates whether this Context is restricted.</para> <para> <para>CONTEXT_RESTRICTED </para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if this Context is restricted, <c>false </c> otherwise.</para>
				/// </returns>
				/// <java-name>
				/// isRestricted
				/// </java-name>
				public virtual bool IsRestricted
				{
						[Dot42.DexImport("isRestricted", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

		}

		/// <summary>
		///  <para>Proxying implementation of Context that simply delegates all of its calls to another Context. Can be subclassed to modify behavior without changing the original Context. </para>    
		/// </summary>
		/// <java-name>
		/// android/content/ContextWrapper
		/// </java-name>
		[Dot42.DexImport("android/content/ContextWrapper", AccessFlags = 33)]
		public partial class ContextWrapper : global::Android.Content.Context
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public ContextWrapper(global::Android.Content.Context @base) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Set the base context for this ContextWrapper. All calls will then be delegated to the base context. Throws IllegalStateException if a base context has already been set.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// attachBaseContext
				/// </java-name>
				[Dot42.DexImport("attachBaseContext", "(Landroid/content/Context;)V", AccessFlags = 4)]
				protected internal virtual void AttachBaseContext(global::Android.Content.Context @base) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setTheme
				/// </java-name>
				[Dot42.DexImport("setTheme", "(I)V", AccessFlags = 1)]
				public override void SetTheme(int resid) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getSharedPreferences
				/// </java-name>
				[Dot42.DexImport("getSharedPreferences", "(Ljava/lang/String;I)Landroid/content/SharedPreferences;", AccessFlags = 1)]
				public override global::Android.Content.ISharedPreferences GetSharedPreferences(string name, int mode) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.ISharedPreferences);
				}

				/// <java-name>
				/// openFileInput
				/// </java-name>
				[Dot42.DexImport("openFileInput", "(Ljava/lang/String;)Ljava/io/FileInputStream;", AccessFlags = 1)]
				public override global::Java.IO.FileInputStream OpenFileInput(string name) /* MethodBuilder.Create */ 
				{
						return default(global::Java.IO.FileInputStream);
				}

				/// <java-name>
				/// openFileOutput
				/// </java-name>
				[Dot42.DexImport("openFileOutput", "(Ljava/lang/String;I)Ljava/io/FileOutputStream;", AccessFlags = 1)]
				public override global::Java.IO.FileOutputStream OpenFileOutput(string name, int mode) /* MethodBuilder.Create */ 
				{
						return default(global::Java.IO.FileOutputStream);
				}

				/// <java-name>
				/// deleteFile
				/// </java-name>
				[Dot42.DexImport("deleteFile", "(Ljava/lang/String;)Z", AccessFlags = 1)]
				public override bool DeleteFile(string name) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getFileStreamPath
				/// </java-name>
				[Dot42.DexImport("getFileStreamPath", "(Ljava/lang/String;)Ljava/io/File;", AccessFlags = 1)]
				public override global::Java.IO.File GetFileStreamPath(string name) /* MethodBuilder.Create */ 
				{
						return default(global::Java.IO.File);
				}

				/// <java-name>
				/// fileList
				/// </java-name>
				[Dot42.DexImport("fileList", "()[Ljava/lang/String;", AccessFlags = 1)]
				public override string[] FileList() /* MethodBuilder.Create */ 
				{
						return default(string[]);
				}

				/// <java-name>
				/// getExternalFilesDir
				/// </java-name>
				[Dot42.DexImport("getExternalFilesDir", "(Ljava/lang/String;)Ljava/io/File;", AccessFlags = 1)]
				public override global::Java.IO.File GetExternalFilesDir(string type) /* MethodBuilder.Create */ 
				{
						return default(global::Java.IO.File);
				}

				/// <java-name>
				/// getDir
				/// </java-name>
				[Dot42.DexImport("getDir", "(Ljava/lang/String;I)Ljava/io/File;", AccessFlags = 1)]
				public override global::Java.IO.File GetDir(string name, int mode) /* MethodBuilder.Create */ 
				{
						return default(global::Java.IO.File);
				}

				/// <java-name>
				/// openOrCreateDatabase
				/// </java-name>
				[Dot42.DexImport("openOrCreateDatabase", "(Ljava/lang/String;ILandroid/database/sqlite/SQLiteDatabase$CursorFactory;)Landro" +
    "id/database/sqlite/SQLiteDatabase;", AccessFlags = 1)]
				public override global::Android.Database.Sqlite.SQLiteDatabase OpenOrCreateDatabase(string name, int mode, global::Android.Database.Sqlite.SQLiteDatabase.ICursorFactory factory) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Database.Sqlite.SQLiteDatabase);
				}

				/// <java-name>
				/// openOrCreateDatabase
				/// </java-name>
				[Dot42.DexImport("openOrCreateDatabase", "(Ljava/lang/String;ILandroid/database/sqlite/SQLiteDatabase$CursorFactory;Landroi" +
    "d/database/DatabaseErrorHandler;)Landroid/database/sqlite/SQLiteDatabase;", AccessFlags = 1)]
				public override global::Android.Database.Sqlite.SQLiteDatabase OpenOrCreateDatabase(string name, int mode, global::Android.Database.Sqlite.SQLiteDatabase.ICursorFactory factory, global::Android.Database.IDatabaseErrorHandler errorHandler) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Database.Sqlite.SQLiteDatabase);
				}

				/// <java-name>
				/// deleteDatabase
				/// </java-name>
				[Dot42.DexImport("deleteDatabase", "(Ljava/lang/String;)Z", AccessFlags = 1)]
				public override bool DeleteDatabase(string name) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getDatabasePath
				/// </java-name>
				[Dot42.DexImport("getDatabasePath", "(Ljava/lang/String;)Ljava/io/File;", AccessFlags = 1)]
				public override global::Java.IO.File GetDatabasePath(string name) /* MethodBuilder.Create */ 
				{
						return default(global::Java.IO.File);
				}

				/// <java-name>
				/// databaseList
				/// </java-name>
				[Dot42.DexImport("databaseList", "()[Ljava/lang/String;", AccessFlags = 1)]
				public override string[] DatabaseList() /* MethodBuilder.Create */ 
				{
						return default(string[]);
				}

				/// <java-name>
				/// peekWallpaper
				/// </java-name>
				[Dot42.DexImport("peekWallpaper", "()Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
				public override global::Android.Graphics.Drawables.Drawable PeekWallpaper() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawables.Drawable);
				}

				/// <java-name>
				/// setWallpaper
				/// </java-name>
				[Dot42.DexImport("setWallpaper", "(Landroid/graphics/Bitmap;)V", AccessFlags = 1)]
				public override void SetWallpaper(global::Android.Graphics.Bitmap bitmap) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setWallpaper
				/// </java-name>
				[Dot42.DexImport("setWallpaper", "(Ljava/io/InputStream;)V", AccessFlags = 1)]
				public override void SetWallpaper(global::Java.IO.InputStream bitmap) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// clearWallpaper
				/// </java-name>
				[Dot42.DexImport("clearWallpaper", "()V", AccessFlags = 1)]
				public override void ClearWallpaper() /* MethodBuilder.Create */ 
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
				public override void StartActivities(global::Android.Content.Intent[] intents) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// startIntentSender
				/// </java-name>
				[Dot42.DexImport("startIntentSender", "(Landroid/content/IntentSender;Landroid/content/Intent;III)V", AccessFlags = 1)]
				public override void StartIntentSender(global::Android.Content.IntentSender intent, global::Android.Content.Intent fillInIntent, int flagsMask, int flagsValues, int extraFlags) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// sendBroadcast
				/// </java-name>
				[Dot42.DexImport("sendBroadcast", "(Landroid/content/Intent;)V", AccessFlags = 1)]
				public override void SendBroadcast(global::Android.Content.Intent intent) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// sendBroadcast
				/// </java-name>
				[Dot42.DexImport("sendBroadcast", "(Landroid/content/Intent;Ljava/lang/String;)V", AccessFlags = 1)]
				public override void SendBroadcast(global::Android.Content.Intent intent, string receiverPermission) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// sendOrderedBroadcast
				/// </java-name>
				[Dot42.DexImport("sendOrderedBroadcast", "(Landroid/content/Intent;Ljava/lang/String;)V", AccessFlags = 1)]
				public override void SendOrderedBroadcast(global::Android.Content.Intent intent, string receiverPermission) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// sendOrderedBroadcast
				/// </java-name>
				[Dot42.DexImport("sendOrderedBroadcast", "(Landroid/content/Intent;Ljava/lang/String;Landroid/content/BroadcastReceiver;Lan" +
    "droid/os/Handler;ILjava/lang/String;Landroid/os/Bundle;)V", AccessFlags = 1)]
				public override void SendOrderedBroadcast(global::Android.Content.Intent intent, string receiverPermission, global::Android.Content.BroadcastReceiver resultReceiver, global::Android.OS.Handler scheduler, int initialCode, string initialData, global::Android.OS.Bundle initialExtras) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// sendStickyBroadcast
				/// </java-name>
				[Dot42.DexImport("sendStickyBroadcast", "(Landroid/content/Intent;)V", AccessFlags = 1)]
				public override void SendStickyBroadcast(global::Android.Content.Intent intent) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// sendStickyOrderedBroadcast
				/// </java-name>
				[Dot42.DexImport("sendStickyOrderedBroadcast", "(Landroid/content/Intent;Landroid/content/BroadcastReceiver;Landroid/os/Handler;I" +
    "Ljava/lang/String;Landroid/os/Bundle;)V", AccessFlags = 1)]
				public override void SendStickyOrderedBroadcast(global::Android.Content.Intent intent, global::Android.Content.BroadcastReceiver resultReceiver, global::Android.OS.Handler scheduler, int initialCode, string initialData, global::Android.OS.Bundle initialExtras) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// removeStickyBroadcast
				/// </java-name>
				[Dot42.DexImport("removeStickyBroadcast", "(Landroid/content/Intent;)V", AccessFlags = 1)]
				public override void RemoveStickyBroadcast(global::Android.Content.Intent intent) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// registerReceiver
				/// </java-name>
				[Dot42.DexImport("registerReceiver", "(Landroid/content/BroadcastReceiver;Landroid/content/IntentFilter;)Landroid/conte" +
    "nt/Intent;", AccessFlags = 1)]
				public override global::Android.Content.Intent RegisterReceiver(global::Android.Content.BroadcastReceiver receiver, global::Android.Content.IntentFilter filter) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Intent);
				}

				/// <java-name>
				/// registerReceiver
				/// </java-name>
				[Dot42.DexImport("registerReceiver", "(Landroid/content/BroadcastReceiver;Landroid/content/IntentFilter;Ljava/lang/Stri" +
    "ng;Landroid/os/Handler;)Landroid/content/Intent;", AccessFlags = 1)]
				public override global::Android.Content.Intent RegisterReceiver(global::Android.Content.BroadcastReceiver receiver, global::Android.Content.IntentFilter filter, string broadcastPermission, global::Android.OS.Handler scheduler) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Intent);
				}

				/// <java-name>
				/// unregisterReceiver
				/// </java-name>
				[Dot42.DexImport("unregisterReceiver", "(Landroid/content/BroadcastReceiver;)V", AccessFlags = 1)]
				public override void UnregisterReceiver(global::Android.Content.BroadcastReceiver receiver) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// startService
				/// </java-name>
				[Dot42.DexImport("startService", "(Landroid/content/Intent;)Landroid/content/ComponentName;", AccessFlags = 1)]
				public override global::Android.Content.ComponentName StartService(global::Android.Content.Intent service) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.ComponentName);
				}

				/// <java-name>
				/// stopService
				/// </java-name>
				[Dot42.DexImport("stopService", "(Landroid/content/Intent;)Z", AccessFlags = 1)]
				public override bool StopService(global::Android.Content.Intent name) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// bindService
				/// </java-name>
				[Dot42.DexImport("bindService", "(Landroid/content/Intent;Landroid/content/ServiceConnection;I)Z", AccessFlags = 1)]
				public override bool BindService(global::Android.Content.Intent service, global::Android.Content.IServiceConnection conn, int flags) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// unbindService
				/// </java-name>
				[Dot42.DexImport("unbindService", "(Landroid/content/ServiceConnection;)V", AccessFlags = 1)]
				public override void UnbindService(global::Android.Content.IServiceConnection conn) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// startInstrumentation
				/// </java-name>
				[Dot42.DexImport("startInstrumentation", "(Landroid/content/ComponentName;Ljava/lang/String;Landroid/os/Bundle;)Z", AccessFlags = 1)]
				public override bool StartInstrumentation(global::Android.Content.ComponentName className, string profileFile, global::Android.OS.Bundle arguments) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getSystemService
				/// </java-name>
				[Dot42.DexImport("getSystemService", "(Ljava/lang/String;)Ljava/lang/Object;", AccessFlags = 1)]
				public override object GetSystemService(string name) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <java-name>
				/// checkPermission
				/// </java-name>
				[Dot42.DexImport("checkPermission", "(Ljava/lang/String;II)I", AccessFlags = 1)]
				public override int CheckPermission(string permission, int pid, int uid) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// checkCallingPermission
				/// </java-name>
				[Dot42.DexImport("checkCallingPermission", "(Ljava/lang/String;)I", AccessFlags = 1)]
				public override int CheckCallingPermission(string permission) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// checkCallingOrSelfPermission
				/// </java-name>
				[Dot42.DexImport("checkCallingOrSelfPermission", "(Ljava/lang/String;)I", AccessFlags = 1)]
				public override int CheckCallingOrSelfPermission(string permission) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// enforcePermission
				/// </java-name>
				[Dot42.DexImport("enforcePermission", "(Ljava/lang/String;IILjava/lang/String;)V", AccessFlags = 1)]
				public override void EnforcePermission(string permission, int pid, int uid, string message) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// enforceCallingPermission
				/// </java-name>
				[Dot42.DexImport("enforceCallingPermission", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public override void EnforceCallingPermission(string permission, string message) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// enforceCallingOrSelfPermission
				/// </java-name>
				[Dot42.DexImport("enforceCallingOrSelfPermission", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public override void EnforceCallingOrSelfPermission(string permission, string message) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// grantUriPermission
				/// </java-name>
				[Dot42.DexImport("grantUriPermission", "(Ljava/lang/String;Landroid/net/Uri;I)V", AccessFlags = 1)]
				public override void GrantUriPermission(string toPackage, global::Android.Net.Uri uri, int modeFlags) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// revokeUriPermission
				/// </java-name>
				[Dot42.DexImport("revokeUriPermission", "(Landroid/net/Uri;I)V", AccessFlags = 1)]
				public override void RevokeUriPermission(global::Android.Net.Uri uri, int modeFlags) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// checkUriPermission
				/// </java-name>
				[Dot42.DexImport("checkUriPermission", "(Landroid/net/Uri;III)I", AccessFlags = 1)]
				public override int CheckUriPermission(global::Android.Net.Uri uri, int pid, int uid, int modeFlags) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// checkCallingUriPermission
				/// </java-name>
				[Dot42.DexImport("checkCallingUriPermission", "(Landroid/net/Uri;I)I", AccessFlags = 1)]
				public override int CheckCallingUriPermission(global::Android.Net.Uri uri, int modeFlags) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// checkCallingOrSelfUriPermission
				/// </java-name>
				[Dot42.DexImport("checkCallingOrSelfUriPermission", "(Landroid/net/Uri;I)I", AccessFlags = 1)]
				public override int CheckCallingOrSelfUriPermission(global::Android.Net.Uri uri, int modeFlags) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// checkUriPermission
				/// </java-name>
				[Dot42.DexImport("checkUriPermission", "(Landroid/net/Uri;Ljava/lang/String;Ljava/lang/String;III)I", AccessFlags = 1)]
				public override int CheckUriPermission(global::Android.Net.Uri uri, string readPermission, string writePermission, int pid, int uid, int modeFlags) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// enforceUriPermission
				/// </java-name>
				[Dot42.DexImport("enforceUriPermission", "(Landroid/net/Uri;IIILjava/lang/String;)V", AccessFlags = 1)]
				public override void EnforceUriPermission(global::Android.Net.Uri uri, int pid, int uid, int modeFlags, string message) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// enforceCallingUriPermission
				/// </java-name>
				[Dot42.DexImport("enforceCallingUriPermission", "(Landroid/net/Uri;ILjava/lang/String;)V", AccessFlags = 1)]
				public override void EnforceCallingUriPermission(global::Android.Net.Uri uri, int modeFlags, string message) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// enforceCallingOrSelfUriPermission
				/// </java-name>
				[Dot42.DexImport("enforceCallingOrSelfUriPermission", "(Landroid/net/Uri;ILjava/lang/String;)V", AccessFlags = 1)]
				public override void EnforceCallingOrSelfUriPermission(global::Android.Net.Uri uri, int modeFlags, string message) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// enforceUriPermission
				/// </java-name>
				[Dot42.DexImport("enforceUriPermission", "(Landroid/net/Uri;Ljava/lang/String;Ljava/lang/String;IIILjava/lang/String;)V", AccessFlags = 1)]
				public override void EnforceUriPermission(global::Android.Net.Uri uri, string readPermission, string writePermission, int pid, int uid, int modeFlags, string message) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// createPackageContext
				/// </java-name>
				[Dot42.DexImport("createPackageContext", "(Ljava/lang/String;I)Landroid/content/Context;", AccessFlags = 1)]
				public override global::Android.Content.Context CreatePackageContext(string packageName, int flags) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Context);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal ContextWrapper() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the base context as set by the constructor or setBaseContext </para>
				/// </returns>
				/// <java-name>
				/// getBaseContext
				/// </java-name>
				public virtual global::Android.Content.Context BaseContext
				{
						[Dot42.DexImport("getBaseContext", "()Landroid/content/Context;", AccessFlags = 1)]
						get{ return default(global::Android.Content.Context); }
				}

				/// <java-name>
				/// getAssets
				/// </java-name>
				public override global::Android.Content.Res.AssetManager Assets
				{
						[Dot42.DexImport("getAssets", "()Landroid/content/res/AssetManager;", AccessFlags = 1)]
						get{ return default(global::Android.Content.Res.AssetManager); }
				}

				/// <java-name>
				/// getResources
				/// </java-name>
				public override global::Android.Content.Res.Resources Resources
				{
						[Dot42.DexImport("getResources", "()Landroid/content/res/Resources;", AccessFlags = 1)]
						get{ return default(global::Android.Content.Res.Resources); }
				}

				/// <java-name>
				/// getPackageManager
				/// </java-name>
				public override global::Android.Content.PM.PackageManager PackageManager
				{
						[Dot42.DexImport("getPackageManager", "()Landroid/content/pm/PackageManager;", AccessFlags = 1)]
						get{ return default(global::Android.Content.PM.PackageManager); }
				}

				/// <java-name>
				/// getContentResolver
				/// </java-name>
				public override global::Android.Content.ContentResolver ContentResolver
				{
						[Dot42.DexImport("getContentResolver", "()Landroid/content/ContentResolver;", AccessFlags = 1)]
						get{ return default(global::Android.Content.ContentResolver); }
				}

				/// <java-name>
				/// getMainLooper
				/// </java-name>
				public override global::Android.OS.Looper MainLooper
				{
						[Dot42.DexImport("getMainLooper", "()Landroid/os/Looper;", AccessFlags = 1)]
						get{ return default(global::Android.OS.Looper); }
				}

				/// <java-name>
				/// getApplicationContext
				/// </java-name>
				public override global::Android.Content.Context ApplicationContext
				{
						[Dot42.DexImport("getApplicationContext", "()Landroid/content/Context;", AccessFlags = 1)]
						get{ return default(global::Android.Content.Context); }
				}

				/// <java-name>
				/// getTheme
				/// </java-name>
				public override global::Android.Content.Res.Resources.Theme Theme
				{
						[Dot42.DexImport("getTheme", "()Landroid/content/res/Resources$Theme;", AccessFlags = 1)]
						get{ return default(global::Android.Content.Res.Resources.Theme); }
				}

				/// <java-name>
				/// getClassLoader
				/// </java-name>
				public override global::Java.Lang.ClassLoader ClassLoader
				{
						[Dot42.DexImport("getClassLoader", "()Ljava/lang/ClassLoader;", AccessFlags = 1)]
						get{ return default(global::Java.Lang.ClassLoader); }
				}

				/// <java-name>
				/// getPackageName
				/// </java-name>
				public override string PackageName
				{
						[Dot42.DexImport("getPackageName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getApplicationInfo
				/// </java-name>
				public override global::Android.Content.PM.ApplicationInfo ApplicationInfo
				{
						[Dot42.DexImport("getApplicationInfo", "()Landroid/content/pm/ApplicationInfo;", AccessFlags = 1)]
						get{ return default(global::Android.Content.PM.ApplicationInfo); }
				}

				/// <java-name>
				/// getPackageResourcePath
				/// </java-name>
				public override string PackageResourcePath
				{
						[Dot42.DexImport("getPackageResourcePath", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getPackageCodePath
				/// </java-name>
				public override string PackageCodePath
				{
						[Dot42.DexImport("getPackageCodePath", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getFilesDir
				/// </java-name>
				public override global::Java.IO.File FilesDir
				{
						[Dot42.DexImport("getFilesDir", "()Ljava/io/File;", AccessFlags = 1)]
						get{ return default(global::Java.IO.File); }
				}

				/// <java-name>
				/// getObbDir
				/// </java-name>
				public override global::Java.IO.File ObbDir
				{
						[Dot42.DexImport("getObbDir", "()Ljava/io/File;", AccessFlags = 1)]
						get{ return default(global::Java.IO.File); }
				}

				/// <java-name>
				/// getCacheDir
				/// </java-name>
				public override global::Java.IO.File CacheDir
				{
						[Dot42.DexImport("getCacheDir", "()Ljava/io/File;", AccessFlags = 1)]
						get{ return default(global::Java.IO.File); }
				}

				/// <java-name>
				/// getExternalCacheDir
				/// </java-name>
				public override global::Java.IO.File ExternalCacheDir
				{
						[Dot42.DexImport("getExternalCacheDir", "()Ljava/io/File;", AccessFlags = 1)]
						get{ return default(global::Java.IO.File); }
				}

				/// <java-name>
				/// getWallpaper
				/// </java-name>
				public override global::Android.Graphics.Drawables.Drawable Wallpaper
				{
						[Dot42.DexImport("getWallpaper", "()Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
						get{ return default(global::Android.Graphics.Drawables.Drawable); }
				}

				/// <java-name>
				/// getWallpaperDesiredMinimumWidth
				/// </java-name>
				public override int WallpaperDesiredMinimumWidth
				{
						[Dot42.DexImport("getWallpaperDesiredMinimumWidth", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getWallpaperDesiredMinimumHeight
				/// </java-name>
				public override int WallpaperDesiredMinimumHeight
				{
						[Dot42.DexImport("getWallpaperDesiredMinimumHeight", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// isRestricted
				/// </java-name>
				public override bool IsRestricted
				{
						[Dot42.DexImport("isRestricted", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

		}

		/// <summary>
		///  <para>A loader that queries the ContentResolver and returns a Cursor. This class implements the Loader protocol in a standard way for querying cursors, building on AsyncTaskLoader to perform the cursor query on a background thread so that it does not block the application's UI.</para> <para>A CursorLoader must be built with the full information for the query to perform, either through the CursorLoader(Context, Uri, String[], String, String[], String) or creating an empty instance with CursorLoader(Context) and filling in the desired paramters with setUri(Uri), setSelection(String), setSelectionArgs(String[]), setSortOrder(String), and setProjection(String[]). </para>    
		/// </summary>
		/// <java-name>
		/// android/content/CursorLoader
		/// </java-name>
		[Dot42.DexImport("android/content/CursorLoader", AccessFlags = 33, Signature = "Landroid/content/AsyncTaskLoader<Landroid/database/Cursor;>;")]
		public partial class CursorLoader : global::Android.Content.AsyncTaskLoader<global::Android.Database.ICursor>
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Creates an empty unspecified CursorLoader. You must follow this with calls to setUri(Uri), setSelection(String), etc to specify the query to perform. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public CursorLoader(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Creates a fully-specified CursorLoader. See ContentResolver.query() for documentation on the meaning of the parameters. These will be passed as-is to that call. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/net/Uri;[Ljava/lang/String;Ljava/lang/String;[" +
    "Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public CursorLoader(global::Android.Content.Context context, global::Android.Net.Uri uri, string[] projection, string selection, string[] selectionArgs, string sortOrder) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// loadInBackground
				/// </java-name>
				[Dot42.DexImport("loadInBackground", "()Landroid/database/Cursor;", AccessFlags = 1)]
				public override global::Android.Database.ICursor LoadInBackground() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Database.ICursor);
				}

				/// <java-name>
				/// deliverResult
				/// </java-name>
				[Dot42.DexImport("deliverResult", "(Landroid/database/Cursor;)V", AccessFlags = 1)]
				public override void DeliverResult(global::Android.Database.ICursor cursor) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Starts an asynchronous load of the contacts list data. When the result is ready the callbacks will be called on the UI thread. If a previous load has been completed and is still valid the result may be passed to the callbacks immediately.</para> <para>Must be called from the UI thread </para>        
				/// </summary>
				/// <java-name>
				/// onStartLoading
				/// </java-name>
				[Dot42.DexImport("onStartLoading", "()V", AccessFlags = 4)]
				protected internal override void OnStartLoading() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Must be called from the UI thread </para>        
				/// </summary>
				/// <java-name>
				/// onStopLoading
				/// </java-name>
				[Dot42.DexImport("onStopLoading", "()V", AccessFlags = 4)]
				protected internal override void OnStopLoading() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onCanceled
				/// </java-name>
				[Dot42.DexImport("onCanceled", "(Landroid/database/Cursor;)V", AccessFlags = 1)]
				public override void OnCanceled(global::Android.Database.ICursor cursor) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onReset
				/// </java-name>
				[Dot42.DexImport("onReset", "()V", AccessFlags = 4)]
				protected internal override void OnReset() /* MethodBuilder.Create */ 
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

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal CursorLoader() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getUri
				/// </java-name>
				public virtual global::Android.Net.Uri Uri
				{
						[Dot42.DexImport("getUri", "()Landroid/net/Uri;", AccessFlags = 1)]
						get{ return default(global::Android.Net.Uri); }
						[Dot42.DexImport("setUri", "(Landroid/net/Uri;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getProjection
				/// </java-name>
				public virtual string[] Projection
				{
						[Dot42.DexImport("getProjection", "()[Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string[]); }
						[Dot42.DexImport("setProjection", "([Ljava/lang/String;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getSelection
				/// </java-name>
				public virtual string Selection
				{
						[Dot42.DexImport("getSelection", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
						[Dot42.DexImport("setSelection", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getSelectionArgs
				/// </java-name>
				public virtual string[] SelectionArgs
				{
						[Dot42.DexImport("getSelectionArgs", "()[Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string[]); }
						[Dot42.DexImport("setSelectionArgs", "([Ljava/lang/String;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getSortOrder
				/// </java-name>
				public virtual string SortOrder
				{
						[Dot42.DexImport("getSortOrder", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
						[Dot42.DexImport("setSortOrder", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ }
				}

		}

		/// <summary>
		///  <para>A representation of a item using ContentValues. It contains one top level ContentValue plus a collection of Uri, ContentValues tuples as subvalues. One example of its use is in Contacts, where the top level ContentValue contains the columns from the RawContacts table and the subvalues contain a ContentValues object for each row from the Data table that corresponds to that RawContact. The uri refers to the Data table uri for each row. </para>    
		/// </summary>
		/// <java-name>
		/// android/content/Entity
		/// </java-name>
		[Dot42.DexImport("android/content/Entity", AccessFlags = 49)]
		public sealed partial class Entity
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/ContentValues;)V", AccessFlags = 1)]
				public Entity(global::Android.Content.ContentValues values) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addSubValue
				/// </java-name>
				[Dot42.DexImport("addSubValue", "(Landroid/net/Uri;Landroid/content/ContentValues;)V", AccessFlags = 1)]
				public void AddSubValue(global::Android.Net.Uri uri, global::Android.Content.ContentValues values) /* MethodBuilder.Create */ 
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

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal Entity() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getEntityValues
				/// </java-name>
				public global::Android.Content.ContentValues EntityValues
				{
						[Dot42.DexImport("getEntityValues", "()Landroid/content/ContentValues;", AccessFlags = 1)]
						get{ return default(global::Android.Content.ContentValues); }
				}

				/// <java-name>
				/// getSubValues
				/// </java-name>
				public global::Java.Util.ArrayList<global::Android.Content.Entity.NamedContentValues> SubValues
				{
						[Dot42.DexImport("getSubValues", "()Ljava/util/ArrayList;", AccessFlags = 1, Signature = "()Ljava/util/ArrayList<Landroid/content/Entity$NamedContentValues;>;")]
						get{ return default(global::Java.Util.ArrayList<global::Android.Content.Entity.NamedContentValues>); }
				}

				/// <java-name>
				/// android/content/Entity$NamedContentValues
				/// </java-name>
				[Dot42.DexImport("android/content/Entity$NamedContentValues", AccessFlags = 9)]
				public partial class NamedContentValues
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// uri
						/// </java-name>
						[Dot42.DexImport("uri", "Landroid/net/Uri;", AccessFlags = 17)]
						public readonly global::Android.Net.Uri Uri;
						/// <java-name>
						/// values
						/// </java-name>
						[Dot42.DexImport("values", "Landroid/content/ContentValues;", AccessFlags = 17)]
						public readonly global::Android.Content.ContentValues Values;
						[Dot42.DexImport("<init>", "(Landroid/net/Uri;Landroid/content/ContentValues;)V", AccessFlags = 1)]
						public NamedContentValues(global::Android.Net.Uri uri, global::Android.Content.ContentValues contentValues) /* MethodBuilder.Create */ 
						{
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						protected internal NamedContentValues() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

				}

		}

		/// <summary>
		///  <para>The set of callback APIs that are common to all application components (android.app.Activity, android.app.Service, ContentProvider, and android.app.Application).</para> <para> <b>Note:</b> You should also implement the ComponentCallbacks2 interface, which provides the ComponentCallbacks2#onTrimMemory callback to help your app manage its memory usage more effectively.</para>    
		/// </summary>
		/// <java-name>
		/// android/content/ComponentCallbacks
		/// </java-name>
		[Dot42.DexImport("android/content/ComponentCallbacks", AccessFlags = 1537)]
		public partial interface IComponentCallbacks
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Called by the system when the device configuration changes while your component is running. Note that, unlike activities, other components are never restarted when a configuration changes: they must always deal with the results of the change, such as by re-retrieving resources.</para> <para>At the time that this function has been called, your Resources object will have been updated to return resource values matching the new configuration.</para> <para>For more information, read .</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// onConfigurationChanged
				/// </java-name>
				[Dot42.DexImport("onConfigurationChanged", "(Landroid/content/res/Configuration;)V", AccessFlags = 1025)]
				void OnConfigurationChanged(global::Android.Content.Res.Configuration newConfig) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>This is called when the overall system is running low on memory, and actively running processes should trim their memory usage. While the exact point at which this will be called is not defined, generally it will happen when all background process have been killed. That is, before reaching the point of killing processes hosting service and foreground UI that we would like to avoid killing.</para> <para>You should implement this method to release any caches or other unnecessary resources you may be holding on to. The system will perform a garbage collection for you after returning from this method. </para> <para>Preferably, you should implement ComponentCallbacks2#onTrimMemory from ComponentCallbacks2 to incrementally unload your resources based on various levels of memory demands. That API is available for API level 14 and higher, so you should only use this onLowMemory method as a fallback for older versions, which can be treated the same as ComponentCallbacks2#onTrimMemory with the ComponentCallbacks2#TRIM_MEMORY_COMPLETE level.</para>        
				/// </summary>
				/// <java-name>
				/// onLowMemory
				/// </java-name>
				[Dot42.DexImport("onLowMemory", "()V", AccessFlags = 1025)]
				void OnLowMemory() /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// android/content/DialogInterface
		/// </java-name>
		[Dot42.DexImport("android/content/DialogInterface", AccessFlags = 1537)]
		public partial interface IDialogInterface
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// cancel
				/// </java-name>
				[Dot42.DexImport("cancel", "()V", AccessFlags = 1025)]
				void Cancel() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// dismiss
				/// </java-name>
				[Dot42.DexImport("dismiss", "()V", AccessFlags = 1025)]
				void Dismiss() /* MethodBuilder.Create */ ;

		}

		/// <summary>
		///  <para>Interface used to allow the creator of a dialog to run some code when the dialog is canceled. </para> <para>This will only be called when the dialog is canceled, if the creator needs to know when it is dismissed in general, use DialogInterface.OnDismissListener. </para>    
		/// </summary>
		/// <java-name>
		/// android/content/DialogInterface$OnCancelListener
		/// </java-name>
		[Dot42.DexImport("android/content/DialogInterface$OnCancelListener", AccessFlags = 1545)]
		public partial interface IDialogInterface_IOnCancelListener
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>This method will be invoked when the dialog is canceled.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// onCancel
				/// </java-name>
				[Dot42.DexImport("onCancel", "(Landroid/content/DialogInterface;)V", AccessFlags = 1025)]
				void OnCancel(global::Android.Content.IDialogInterface dialog) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		///  <para>Interface used to allow the creator of a dialog to run some code when an item on the dialog is clicked.. </para>    
		/// </summary>
		/// <java-name>
		/// android/content/DialogInterface$OnClickListener
		/// </java-name>
		[Dot42.DexImport("android/content/DialogInterface$OnClickListener", AccessFlags = 1545)]
		public partial interface IDialogInterface_IOnClickListener
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>This method will be invoked when a button in the dialog is clicked.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// onClick
				/// </java-name>
				[Dot42.DexImport("onClick", "(Landroid/content/DialogInterface;I)V", AccessFlags = 1025)]
				void OnClick(global::Android.Content.IDialogInterface dialog, int which) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		///  <para>Interface used to allow the creator of a dialog to run some code when the dialog is dismissed. </para>    
		/// </summary>
		/// <java-name>
		/// android/content/DialogInterface$OnDismissListener
		/// </java-name>
		[Dot42.DexImport("android/content/DialogInterface$OnDismissListener", AccessFlags = 1545)]
		public partial interface IDialogInterface_IOnDismissListener
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>This method will be invoked when the dialog is dismissed.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// onDismiss
				/// </java-name>
				[Dot42.DexImport("onDismiss", "(Landroid/content/DialogInterface;)V", AccessFlags = 1025)]
				void OnDismiss(global::Android.Content.IDialogInterface dialog) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		///  <para>Interface definition for a callback to be invoked when a key event is dispatched to this dialog. The callback will be invoked before the key event is given to the dialog. </para>    
		/// </summary>
		/// <java-name>
		/// android/content/DialogInterface$OnKeyListener
		/// </java-name>
		[Dot42.DexImport("android/content/DialogInterface$OnKeyListener", AccessFlags = 1545)]
		public partial interface IDialogInterface_IOnKeyListener
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Called when a key is dispatched to a dialog. This allows listeners to get a chance to respond before the dialog.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>True if the listener has consumed the event, false otherwise. </para>
				/// </returns>
				/// <java-name>
				/// onKey
				/// </java-name>
				[Dot42.DexImport("onKey", "(Landroid/content/DialogInterface;ILandroid/view/KeyEvent;)Z", AccessFlags = 1025)]
				bool OnKey(global::Android.Content.IDialogInterface dialog, int keyCode, global::Android.Views.KeyEvent @event) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		///  <para>Interface used to allow the creator of a dialog to run some code when an item in a multi-choice dialog is clicked. </para>    
		/// </summary>
		/// <java-name>
		/// android/content/DialogInterface$OnMultiChoiceClickListener
		/// </java-name>
		[Dot42.DexImport("android/content/DialogInterface$OnMultiChoiceClickListener", AccessFlags = 1545)]
		public partial interface IDialogInterface_IOnMultiChoiceClickListener
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>This method will be invoked when an item in the dialog is clicked.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// onClick
				/// </java-name>
				[Dot42.DexImport("onClick", "(Landroid/content/DialogInterface;IZ)V", AccessFlags = 1025)]
				void OnClick(global::Android.Content.IDialogInterface dialog, int which, bool isChecked) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		///  <para>Interface used to allow the creator of a dialog to run some code when the dialog is shown. </para>    
		/// </summary>
		/// <java-name>
		/// android/content/DialogInterface$OnShowListener
		/// </java-name>
		[Dot42.DexImport("android/content/DialogInterface$OnShowListener", AccessFlags = 1545)]
		public partial interface IDialogInterface_IOnShowListener
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>This method will be invoked when the dialog is shown.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// onShow
				/// </java-name>
				[Dot42.DexImport("onShow", "(Landroid/content/DialogInterface;)V", AccessFlags = 1025)]
				void OnShow(global::Android.Content.IDialogInterface dialog) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// android/content/DialogInterface
		/// </java-name>
		[Dot42.DexImport("android/content/DialogInterface", AccessFlags = 1537, IgnoreFromJava = true, Priority = 1)]
		public static partial class IDialogInterfaceConstants
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>The identifier for the positive button. </para>        
				/// </summary>
				/// <java-name>
				/// BUTTON_POSITIVE
				/// </java-name>
				[Dot42.DexImport("BUTTON_POSITIVE", "I", AccessFlags = 25)]
				public const int BUTTON_POSITIVE = -1;
				/// <summary>
				///  <para>The identifier for the negative button. </para>        
				/// </summary>
				/// <java-name>
				/// BUTTON_NEGATIVE
				/// </java-name>
				[Dot42.DexImport("BUTTON_NEGATIVE", "I", AccessFlags = 25)]
				public const int BUTTON_NEGATIVE = -2;
				/// <summary>
				///  <para>The identifier for the neutral button. </para>        
				/// </summary>
				/// <java-name>
				/// BUTTON_NEUTRAL
				/// </java-name>
				[Dot42.DexImport("BUTTON_NEUTRAL", "I", AccessFlags = 25)]
				public const int BUTTON_NEUTRAL = -3;
				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use BUTTON_POSITIVE </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// BUTTON1
				/// </java-name>
				[Dot42.DexImport("BUTTON1", "I", AccessFlags = 25)]
				public const int BUTTON1 = -1;
				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use BUTTON_NEGATIVE </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// BUTTON2
				/// </java-name>
				[Dot42.DexImport("BUTTON2", "I", AccessFlags = 25)]
				public const int BUTTON2 = -2;
				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use BUTTON_NEUTRAL </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// BUTTON3
				/// </java-name>
				[Dot42.DexImport("BUTTON3", "I", AccessFlags = 25)]
				public const int BUTTON3 = -3;
		}

		/// <summary>
		///  <para>A specialization of Iterator that allows iterating over a collection of Entity objects. In addition to the iteration functionality it also allows resetting the iterator back to the beginning and provides for an explicit close() method to indicate that the iterator is no longer needed and that its resources can be released. </para>    
		/// </summary>
		/// <java-name>
		/// android/content/EntityIterator
		/// </java-name>
		[Dot42.DexImport("android/content/EntityIterator", AccessFlags = 1537, Signature = "Ljava/lang/Object;Ljava/util/Iterator<Landroid/content/Entity;>;")]
		public partial interface IEntityIterator : global::Java.Util.IIterator<global::Android.Content.Entity>
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Reset the iterator back to the beginning. </para>        
				/// </summary>
				/// <java-name>
				/// reset
				/// </java-name>
				[Dot42.DexImport("reset", "()V", AccessFlags = 1025)]
				void Reset() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Indicates that this iterator is no longer needed and that any associated resources may be released (such as a SQLite cursor). </para>        
				/// </summary>
				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1025)]
				void Close() /* MethodBuilder.Create */ ;

		}

		/// <summary>
		///  <para>An intent is an abstract description of an operation to be performed. It can be used with startActivity to launch an android.app.Activity, broadcastIntent to send it to any interested BroadcastReceiver components, and android.content.Context#startService or android.content.Context#bindService to communicate with a background android.app.Service.</para> <para>An Intent provides a facility for performing late runtime binding between the code in different applications. Its most significant use is in the launching of activities, where it can be thought of as the glue between activities. It is basically a passive data structure holding an abstract description of an action to be performed.</para> <para>  <h3>Developer Guides</h3></para> <para> </para> <para>For information about how to create and resolve intents, read the  developer guide.</para> <para> </para> <para>  <h3>Intent Structure</h3></para> <para>The primary pieces of information in an intent are:</para> <para> <ul> <li> <para></para> <para> <b>action</b>  The general action to be performed, such as ACTION_VIEW, ACTION_EDIT, ACTION_MAIN, etc.</para> <para></para></li> <li> <para></para> <para> <b>data</b>  The data to operate on, such as a person record in the contacts database, expressed as a android.net.Uri.</para> <para></para></li></ul></para> <para>Some examples of action/data pairs are:</para> <para> <ul> <li> <para></para> <para> <b>ACTION_VIEW  <b>content://contacts/people/1</b></b>  Display information about the person whose identifier is "1".</para> <para></para></li> <li> <para></para> <para> <b>ACTION_DIAL  <b>content://contacts/people/1</b></b>  Display the phone dialer with the person filled in.</para> <para></para></li> <li> <para></para> <para> <b>ACTION_VIEW  <b>tel:123</b></b>  Display the phone dialer with the given number filled in. Note how the VIEW action does what what is considered the most reasonable thing for a particular URI.</para> <para></para></li> <li> <para></para> <para> <b>ACTION_DIAL  <b>tel:123</b></b>  Display the phone dialer with the given number filled in.</para> <para></para></li> <li> <para></para> <para> <b>ACTION_EDIT  <b>content://contacts/people/1</b></b>  Edit information about the person whose identifier is "1".</para> <para></para></li> <li> <para></para> <para> <b>ACTION_VIEW  <b>content://contacts/people/</b></b>  Display a list of people, which the user can browse through. This example is a typical top-level entry into the Contacts application, showing you the list of people. Selecting a particular person to view would result in a new intent {  <b>ACTION_VIEW  <b>content://contacts/N</b></b> } being used to start an activity to display that person.</para> <para></para></li></ul></para> <para>In addition to these primary attributes, there are a number of secondary attributes that you can also include with an intent:</para> <para> <ul> <li> <para></para> <para> <b>category</b>  Gives additional information about the action to execute. For example, CATEGORY_LAUNCHER means it should appear in the Launcher as a top-level application, while CATEGORY_ALTERNATIVE means it should be included in a list of alternative actions the user can perform on a piece of data.</para> <para></para></li> <li> <para></para> <para> <b>type</b>  Specifies an explicit type (a MIME type) of the intent data. Normally the type is inferred from the data itself. By setting this attribute, you disable that evaluation and force an explicit type.</para> <para></para></li> <li> <para></para> <para> <b>component</b>  Specifies an explicit name of a component class to use for the intent. Normally this is determined by looking at the other information in the intent (the action, data/type, and categories) and matching that with a component that can handle it. If this attribute is set then none of the evaluation is performed, and this component is used exactly as is. By specifying this attribute, all of the other Intent attributes become optional.</para> <para></para></li> <li> <para></para> <para> <b>extras</b>  This is a Bundle of any additional information. This can be used to provide extended information to the component. For example, if we have a action to send an e-mail message, we could also include extra pieces of data here to supply a subject, body, etc.</para> <para></para></li></ul></para> <para>Here are some examples of other operations you can specify as intents using these additional parameters:</para> <para> <ul> <li> <para></para> <para> <b>ACTION_MAIN with category CATEGORY_HOME</b>  Launch the home screen.</para> <para></para></li> <li> <para></para> <para> <b>ACTION_GET_CONTENT with MIME type  <b>vnd.android.cursor.item/phone</b></b>  Display the list of people's phone numbers, allowing the user to browse through them and pick one and return it to the parent activity.</para> <para></para></li> <li> <para></para> <para> <b>ACTION_GET_CONTENT with MIME type  <b>*{ /}*</b> and category CATEGORY_OPENABLE</b>  Display all pickers for data that can be opened with ContentResolver.openInputStream(), allowing the user to pick one of them and then some data inside of it and returning the resulting URI to the caller. This can be used, for example, in an e-mail application to allow the user to pick some data to include as an attachment.</para> <para></para></li></ul></para> <para>There are a variety of standard Intent action and category constants defined in the Intent class, but applications can also define their own. These strings use java style scoping, to ensure they are unique  for example, the standard ACTION_VIEW is called "android.intent.action.VIEW".</para> <para>Put together, the set of actions, data types, categories, and extra data defines a language for the system allowing for the expression of phrases such as "call john smith's cell". As applications are added to the system, they can extend this language by adding new actions, types, and categories, or they can modify the behavior of existing phrases by supplying their own activities that handle them.</para> <para>  <h3>Intent Resolution</h3></para> <para>There are two primary forms of intents you will use.</para> <para> <ul> <li> <para></para> <para> <b>Explicit Intents</b> have specified a component (via setComponent or setClass), which provides the exact class to be run. Often these will not include any other information, simply being a way for an application to launch various internal activities it has as the user interacts with the application.</para> <para></para></li> <li> <para></para> <para> <b>Implicit Intents</b> have not specified a component; instead, they must include enough information for the system to determine which of the available components is best to run for that intent. </para></li></ul></para> <para>When using implicit intents, given such an arbitrary intent we need to know what to do with it. This is handled by the process of  <b>Intent resolution</b>, which maps an Intent to an android.app.Activity, BroadcastReceiver, or android.app.Service (or sometimes two or more activities/receivers) that can handle it.</para> <para>The intent resolution mechanism basically revolves around matching an Intent against all of the &lt;intent-filter&gt; descriptions in the installed application packages. (Plus, in the case of broadcasts, any BroadcastReceiver objects explicitly registered with Context#registerReceiver.) More details on this can be found in the documentation on the IntentFilter class.</para> <para>There are three pieces of information in the Intent that are used for resolution: the action, type, and category. Using this information, a query is done on the PackageManager for a component that can handle the intent. The appropriate component is determined based on the intent information supplied in the  <code>AndroidManifest.xml</code> file as follows:</para> <para> <ul> <li> <para></para> <para>The  <b>action</b>, if given, must be listed by the component as one it handles.</para> <para></para></li> <li> <para></para> <para>The  <b>type</b> is retrieved from the Intent's data, if not already supplied in the Intent. Like the action, if a type is included in the intent (either explicitly or implicitly in its data), then this must be listed by the component as one it handles.</para> <para></para></li> <li> <para>For data that is not a  <code>content:</code> URI and where no explicit type is included in the Intent, instead the  <b>scheme</b> of the intent data (such as  <code>http:</code> or  <code>mailto:</code>) is considered. Again like the action, if we are matching a scheme it must be listed by the component as one it can handle. </para></li> <li> <para></para> <para>The  <b>categories</b>, if supplied, must  <b>all</b> be listed by the activity as categories it handles. That is, if you include the categories CATEGORY_LAUNCHER and CATEGORY_ALTERNATIVE, then you will only resolve to components with an intent that lists  <b>both</b> of those categories. Activities will very often need to support the CATEGORY_DEFAULT so that they can be found by Context.startActivity().</para> <para></para></li></ul></para> <para>For example, consider the Note Pad sample application that allows user to browse through a list of notes data and view details about individual items. Text in italics indicate places were you would replace a name with one specific to your own package.</para> <para> <pre> &lt;manifest xmlns:android="http://schemas.android.com/apk/res/android"
		///       package="&lt;i&gt;com.android.notepad&lt;/i&gt;"&gt;
		///     &lt;application android:icon="@drawable/app_notes"
		///             android:label="@string/app_name"&gt;</pre></para> <para> <pre>        &lt;provider class=".NotePadProvider"
		///                 android:authorities="&lt;i&gt;com.google.provider.NotePad&lt;/i&gt;" /&gt;</pre></para> <para> <pre>        &lt;activity class=".NotesList" android:label="@string/title_notes_list"&gt;
		///             &lt;intent-filter&gt;
		///                 &lt;action android:name="android.intent.action.MAIN" /&gt;
		///                 &lt;category android:name="android.intent.category.LAUNCHER" /&gt;
		///             &lt;/intent-filter&gt;
		///             &lt;intent-filter&gt;
		///                 &lt;action android:name="android.intent.action.VIEW" /&gt;
		///                 &lt;action android:name="android.intent.action.EDIT" /&gt;
		///                 &lt;action android:name="android.intent.action.PICK" /&gt;
		///                 &lt;category android:name="android.intent.category.DEFAULT" /&gt;
		///                 &lt;data android:mimeType="vnd.android.cursor.dir/&lt;i&gt;vnd.google.note&lt;/i&gt;" /&gt;
		///             &lt;/intent-filter&gt;
		///             &lt;intent-filter&gt;
		///                 &lt;action android:name="android.intent.action.GET_CONTENT" /&gt;
		///                 &lt;category android:name="android.intent.category.DEFAULT" /&gt;
		///                 &lt;data android:mimeType="vnd.android.cursor.item/&lt;i&gt;vnd.google.note&lt;/i&gt;" /&gt;
		///             &lt;/intent-filter&gt;
		///         &lt;/activity&gt;</pre></para> <para> <pre>        &lt;activity class=".NoteEditor" android:label="@string/title_note"&gt;
		///             &lt;intent-filter android:label="@string/resolve_edit"&gt;
		///                 &lt;action android:name="android.intent.action.VIEW" /&gt;
		///                 &lt;action android:name="android.intent.action.EDIT" /&gt;
		///                 &lt;category android:name="android.intent.category.DEFAULT" /&gt;
		///                 &lt;data android:mimeType="vnd.android.cursor.item/&lt;i&gt;vnd.google.note&lt;/i&gt;" /&gt;
		///             &lt;/intent-filter&gt;</pre></para> <para> <pre>            &lt;intent-filter&gt;
		///                 &lt;action android:name="android.intent.action.INSERT" /&gt;
		///                 &lt;category android:name="android.intent.category.DEFAULT" /&gt;
		///                 &lt;data android:mimeType="vnd.android.cursor.dir/&lt;i&gt;vnd.google.note&lt;/i&gt;" /&gt;
		///             &lt;/intent-filter&gt;</pre></para> <para> <pre>        &lt;/activity&gt;</pre></para> <para> <pre>        &lt;activity class=".TitleEditor" android:label="@string/title_edit_title"
		///                 android:theme="@android:style/Theme.Dialog"&gt;
		///             &lt;intent-filter android:label="@string/resolve_title"&gt;
		///                 &lt;action android:name="&lt;i&gt;com.android.notepad.action.EDIT_TITLE&lt;/i&gt;" /&gt;
		///                 &lt;category android:name="android.intent.category.DEFAULT" /&gt;
		///                 &lt;category android:name="android.intent.category.ALTERNATIVE" /&gt;
		///                 &lt;category android:name="android.intent.category.SELECTED_ALTERNATIVE" /&gt;
		///                 &lt;data android:mimeType="vnd.android.cursor.item/&lt;i&gt;vnd.google.note&lt;/i&gt;" /&gt;
		///             &lt;/intent-filter&gt;
		///         &lt;/activity&gt;</pre></para> <para> <pre>    &lt;/application&gt;
		/// &lt;/manifest&gt;</pre></para> <para>The first activity,  <code>com.android.notepad.NotesList</code>, serves as our main entry into the app. It can do three things as described by its three intent templates:  <ol> <li> <para> <pre>
		/// &lt;intent-filter&gt;
		///     &lt;action android:name="{@link #ACTION_MAIN android.intent.action.MAIN}" /&gt;
		///     &lt;category android:name="{@link #CATEGORY_LAUNCHER android.intent.category.LAUNCHER}" /&gt;
		/// &lt;/intent-filter&gt;</pre> </para> <para>This provides a top-level entry into the NotePad application: the standard MAIN action is a main entry point (not requiring any other information in the Intent), and the LAUNCHER category says that this entry point should be listed in the application launcher.</para> <para></para></li> <li> <para> <pre>
		/// &lt;intent-filter&gt;
		///     &lt;action android:name="{@link #ACTION_VIEW android.intent.action.VIEW}" /&gt;
		///     &lt;action android:name="{@link #ACTION_EDIT android.intent.action.EDIT}" /&gt;
		///     &lt;action android:name="{@link #ACTION_PICK android.intent.action.PICK}" /&gt;
		///     &lt;category android:name="{@link #CATEGORY_DEFAULT android.intent.category.DEFAULT}" /&gt;
		///     &lt;data mimeType:name="vnd.android.cursor.dir/&lt;i&gt;vnd.google.note&lt;/i&gt;" /&gt;
		/// &lt;/intent-filter&gt;</pre> </para> <para>This declares the things that the activity can do on a directory of notes. The type being supported is given with the &lt;type&gt; tag, where  <code>vnd.android.cursor.dir/vnd.google.note</code> is a URI from which a Cursor of zero or more items ( <code>vnd.android.cursor.dir</code>) can be retrieved which holds our note pad data ( <code>vnd.google.note</code>). The activity allows the user to view or edit the directory of data (via the VIEW and EDIT actions), or to pick a particular note and return it to the caller (via the PICK action). Note also the DEFAULT category supplied here: this is  <b>required</b> for the Context.startActivity method to resolve your activity when its component name is not explicitly specified.</para> <para></para></li> <li> <para> <pre>
		/// &lt;intent-filter&gt;
		///     &lt;action android:name="{@link #ACTION_GET_CONTENT android.intent.action.GET_CONTENT}" /&gt;
		///     &lt;category android:name="{@link #CATEGORY_DEFAULT android.intent.category.DEFAULT}" /&gt;
		///     &lt;data android:mimeType="vnd.android.cursor.item/&lt;i&gt;vnd.google.note&lt;/i&gt;" /&gt;
		/// &lt;/intent-filter&gt;</pre> </para> <para>This filter describes the ability return to the caller a note selected by the user without needing to know where it came from. The data type  <code>vnd.android.cursor.item/vnd.google.note</code> is a URI from which a Cursor of exactly one ( <code>vnd.android.cursor.item</code>) item can be retrieved which contains our note pad data ( <code>vnd.google.note</code>). The GET_CONTENT action is similar to the PICK action, where the activity will return to its caller a piece of data selected by the user. Here, however, the caller specifies the type of data they desire instead of the type of data the user will be picking from.</para> <para></para></li></ol></para> <para>Given these capabilities, the following intents will resolve to the NotesList activity:</para> <para> <ul> <li> <para></para> <para> <b>{ action=android.app.action.MAIN }</b> matches all of the activities that can be used as top-level entry points into an application.</para> <para></para></li> <li> <para></para> <para> <b>{ action=android.app.action.MAIN, category=android.app.category.LAUNCHER }</b> is the actual intent used by the Launcher to populate its top-level list.</para> <para></para></li> <li> <para></para> <para> <b>{ action=android.intent.action.VIEW data=content://com.google.provider.NotePad/notes }</b> displays a list of all the notes under "content://com.google.provider.NotePad/notes", which the user can browse through and see the details on.</para> <para></para></li> <li> <para></para> <para> <b>{ action=android.app.action.PICK data=content://com.google.provider.NotePad/notes }</b> provides a list of the notes under "content://com.google.provider.NotePad/notes", from which the user can pick a note whose data URL is returned back to the caller.</para> <para></para></li> <li> <para></para> <para> <b>{ action=android.app.action.GET_CONTENT type=vnd.android.cursor.item/vnd.google.note }</b> is similar to the pick action, but allows the caller to specify the kind of data they want back so that the system can find the appropriate activity to pick something of that data type.</para> <para></para></li></ul></para> <para>The second activity,  <code>com.android.notepad.NoteEditor</code>, shows the user a single note entry and allows them to edit it. It can do two things as described by its two intent templates:  <ol> <li> <para> <pre>
		/// &lt;intent-filter android:label="@string/resolve_edit"&gt;
		///     &lt;action android:name="{@link #ACTION_VIEW android.intent.action.VIEW}" /&gt;
		///     &lt;action android:name="{@link #ACTION_EDIT android.intent.action.EDIT}" /&gt;
		///     &lt;category android:name="{@link #CATEGORY_DEFAULT android.intent.category.DEFAULT}" /&gt;
		///     &lt;data android:mimeType="vnd.android.cursor.item/&lt;i&gt;vnd.google.note&lt;/i&gt;" /&gt;
		/// &lt;/intent-filter&gt;</pre> </para> <para>The first, primary, purpose of this activity is to let the user interact with a single note, as decribed by the MIME type  <code>vnd.android.cursor.item/vnd.google.note</code>. The activity can either VIEW a note or allow the user to EDIT it. Again we support the DEFAULT category to allow the activity to be launched without explicitly specifying its component.</para> <para></para></li> <li> <para> <pre>
		/// &lt;intent-filter&gt;
		///     &lt;action android:name="{@link #ACTION_INSERT android.intent.action.INSERT}" /&gt;
		///     &lt;category android:name="{@link #CATEGORY_DEFAULT android.intent.category.DEFAULT}" /&gt;
		///     &lt;data android:mimeType="vnd.android.cursor.dir/&lt;i&gt;vnd.google.note&lt;/i&gt;" /&gt;
		/// &lt;/intent-filter&gt;</pre> </para> <para>The secondary use of this activity is to insert a new note entry into an existing directory of notes. This is used when the user creates a new note: the INSERT action is executed on the directory of notes, causing this activity to run and have the user create the new note data which it then adds to the content provider.</para> <para></para></li></ol></para> <para>Given these capabilities, the following intents will resolve to the NoteEditor activity:</para> <para> <ul> <li> <para></para> <para> <b>{ action=android.intent.action.VIEW data=content://com.google.provider.NotePad/notes/ <b>{ID}</b> }</b> shows the user the content of note  <b>{ID}</b>.</para> <para></para></li> <li> <para></para> <para> <b>{ action=android.app.action.EDIT data=content://com.google.provider.NotePad/notes/ <b>{ID}</b> }</b> allows the user to edit the content of note  <b>{ID}</b>.</para> <para></para></li> <li> <para></para> <para> <b>{ action=android.app.action.INSERT data=content://com.google.provider.NotePad/notes }</b> creates a new, empty note in the notes list at "content://com.google.provider.NotePad/notes" and allows the user to edit it. If they keep their changes, the URI of the newly created note is returned to the caller.</para> <para></para></li></ul></para> <para>The last activity,  <code>com.android.notepad.TitleEditor</code>, allows the user to edit the title of a note. This could be implemented as a class that the application directly invokes (by explicitly setting its component in the Intent), but here we show a way you can publish alternative operations on existing data:</para> <para> <pre>
		/// &lt;intent-filter android:label="@string/resolve_title"&gt;
		///     &lt;action android:name="&lt;i&gt;com.android.notepad.action.EDIT_TITLE&lt;/i&gt;" /&gt;
		///     &lt;category android:name="{@link #CATEGORY_DEFAULT android.intent.category.DEFAULT}" /&gt;
		///     &lt;category android:name="{@link #CATEGORY_ALTERNATIVE android.intent.category.ALTERNATIVE}" /&gt;
		///     &lt;category android:name="{@link #CATEGORY_SELECTED_ALTERNATIVE android.intent.category.SELECTED_ALTERNATIVE}" /&gt;
		///     &lt;data android:mimeType="vnd.android.cursor.item/&lt;i&gt;vnd.google.note&lt;/i&gt;" /&gt;
		/// &lt;/intent-filter&gt;</pre></para> <para>In the single intent template here, we have created our own private action called  <code>com.android.notepad.action.EDIT_TITLE</code> which means to edit the title of a note. It must be invoked on a specific note (data type  <code>vnd.android.cursor.item/vnd.google.note</code>) like the previous view and edit actions, but here displays and edits the title contained in the note data.</para> <para>In addition to supporting the default category as usual, our title editor also supports two other standard categories: ALTERNATIVE and SELECTED_ALTERNATIVE. Implementing these categories allows others to find the special action it provides without directly knowing about it, through the android.content.pm.PackageManager#queryIntentActivityOptions method, or more often to build dynamic menu items with android.view.Menu#addIntentOptions. Note that in the intent template here was also supply an explicit name for the template (via  <code>android:label="@string/resolve_title"</code>) to better control what the user sees when presented with this activity as an alternative action to the data they are viewing.</para> <para>Given these capabilities, the following intent will resolve to the TitleEditor activity:</para> <para> <ul> <li> <para></para> <para> <b>{ action=com.android.notepad.action.EDIT_TITLE data=content://com.google.provider.NotePad/notes/ <b>{ID}</b> }</b> displays and allows the user to edit the title associated with note  <b>{ID}</b>.</para> <para></para></li></ul></para> <para> <h3>Standard Activity Actions</h3></para> <para>These are the current standard actions that Intent defines for launching activities (usually through Context#startActivity. The most important, and by far most frequently used, are ACTION_MAIN and ACTION_EDIT.</para> <para> <ul> <li> <para>ACTION_MAIN </para></li> <li> <para>ACTION_VIEW </para></li> <li> <para>ACTION_ATTACH_DATA </para></li> <li> <para>ACTION_EDIT </para></li> <li> <para>ACTION_PICK </para></li> <li> <para>ACTION_CHOOSER </para></li> <li> <para>ACTION_GET_CONTENT </para></li> <li> <para>ACTION_DIAL </para></li> <li> <para>ACTION_CALL </para></li> <li> <para>ACTION_SEND </para></li> <li> <para>ACTION_SENDTO </para></li> <li> <para>ACTION_ANSWER </para></li> <li> <para>ACTION_INSERT </para></li> <li> <para>ACTION_DELETE </para></li> <li> <para>ACTION_RUN </para></li> <li> <para>ACTION_SYNC </para></li> <li> <para>ACTION_PICK_ACTIVITY </para></li> <li> <para>ACTION_SEARCH </para></li> <li> <para>ACTION_WEB_SEARCH </para></li> <li> <para>ACTION_FACTORY_TEST </para></li></ul></para> <para> <h3>Standard Broadcast Actions</h3></para> <para>These are the current standard actions that Intent defines for receiving broadcasts (usually through Context#registerReceiver or a &lt;receiver&gt; tag in a manifest).</para> <para> <ul> <li> <para>ACTION_TIME_TICK </para></li> <li> <para>ACTION_TIME_CHANGED </para></li> <li> <para>ACTION_TIMEZONE_CHANGED </para></li> <li> <para>ACTION_BOOT_COMPLETED </para></li> <li> <para>ACTION_PACKAGE_ADDED </para></li> <li> <para>ACTION_PACKAGE_CHANGED </para></li> <li> <para>ACTION_PACKAGE_REMOVED </para></li> <li> <para>ACTION_PACKAGE_RESTARTED </para></li> <li> <para>ACTION_PACKAGE_DATA_CLEARED </para></li> <li> <para>ACTION_UID_REMOVED </para></li> <li> <para>ACTION_BATTERY_CHANGED </para></li> <li> <para>ACTION_POWER_CONNECTED </para></li> <li> <para>ACTION_POWER_DISCONNECTED </para></li> <li> <para>ACTION_SHUTDOWN </para></li></ul></para> <para> <h3>Standard Categories</h3></para> <para>These are the current standard categories that can be used to further clarify an Intent via addCategory.</para> <para> <ul> <li> <para>CATEGORY_DEFAULT </para></li> <li> <para>CATEGORY_BROWSABLE </para></li> <li> <para>CATEGORY_TAB </para></li> <li> <para>CATEGORY_ALTERNATIVE </para></li> <li> <para>CATEGORY_SELECTED_ALTERNATIVE </para></li> <li> <para>CATEGORY_LAUNCHER </para></li> <li> <para>CATEGORY_INFO </para></li> <li> <para>CATEGORY_HOME </para></li> <li> <para>CATEGORY_PREFERENCE </para></li> <li> <para>CATEGORY_TEST </para></li> <li> <para>CATEGORY_CAR_DOCK </para></li> <li> <para>CATEGORY_DESK_DOCK </para></li> <li> <para>CATEGORY_LE_DESK_DOCK </para></li> <li> <para>CATEGORY_HE_DESK_DOCK </para></li> <li> <para>CATEGORY_CAR_MODE </para></li> <li> <para>CATEGORY_APP_MARKET </para></li></ul></para> <para> <h3>Standard Extra Data</h3></para> <para>These are the current standard fields that can be used as extra data via putExtra.</para> <para> <ul> <li> <para>EXTRA_ALARM_COUNT </para></li> <li> <para>EXTRA_BCC </para></li> <li> <para>EXTRA_CC </para></li> <li> <para>EXTRA_CHANGED_COMPONENT_NAME </para></li> <li> <para>EXTRA_DATA_REMOVED </para></li> <li> <para>EXTRA_DOCK_STATE </para></li> <li> <para>EXTRA_DOCK_STATE_HE_DESK </para></li> <li> <para>EXTRA_DOCK_STATE_LE_DESK </para></li> <li> <para>EXTRA_DOCK_STATE_CAR </para></li> <li> <para>EXTRA_DOCK_STATE_DESK </para></li> <li> <para>EXTRA_DOCK_STATE_UNDOCKED </para></li> <li> <para>EXTRA_DONT_KILL_APP </para></li> <li> <para>EXTRA_EMAIL </para></li> <li> <para>EXTRA_INITIAL_INTENTS </para></li> <li> <para>EXTRA_INTENT </para></li> <li> <para>EXTRA_KEY_EVENT </para></li> <li> <para>EXTRA_ORIGINATING_URI </para></li> <li> <para>EXTRA_PHONE_NUMBER </para></li> <li> <para>EXTRA_REFERRER </para></li> <li> <para>EXTRA_REMOTE_INTENT_TOKEN </para></li> <li> <para>EXTRA_REPLACING </para></li> <li> <para>EXTRA_SHORTCUT_ICON </para></li> <li> <para>EXTRA_SHORTCUT_ICON_RESOURCE </para></li> <li> <para>EXTRA_SHORTCUT_INTENT </para></li> <li> <para>EXTRA_STREAM </para></li> <li> <para>EXTRA_SHORTCUT_NAME </para></li> <li> <para>EXTRA_SUBJECT </para></li> <li> <para>EXTRA_TEMPLATE </para></li> <li> <para>EXTRA_TEXT </para></li> <li> <para>EXTRA_TITLE </para></li> <li> <para>EXTRA_UID </para></li></ul></para> <para> <h3>Flags</h3></para> <para>These are the possible flags that can be used in the Intent via setFlags and addFlags. See setFlags for a list of all possible flags. </para>    
		/// </summary>
		/// <java-name>
		/// android/content/Intent
		/// </java-name>
		[Dot42.DexImport("android/content/Intent", AccessFlags = 33)]
		public partial class Intent : global::Android.OS.IParcelable, global::Java.Lang.ICloneable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Activity Action: Start as a main entry point, does not expect to receive data. </para> <para>Input: nothing </para> <para>Output: nothing </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_MAIN
				/// </java-name>
				[Dot42.DexImport("ACTION_MAIN", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_MAIN = "android.intent.action.MAIN";
				/// <summary>
				///  <para>Activity Action: Display the data to the user. This is the most common action performed on data  it is the generic action you can use on a piece of data to get the most reasonable thing to occur. For example, when used on a contacts entry it will view the entry; when used on a mailto: URI it will bring up a compose window filled with the information supplied by the URI; when used with a tel: URI it will invoke the dialer. </para> <para>Input: getData is URI from which to retrieve data. </para> <para>Output: nothing. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_VIEW
				/// </java-name>
				[Dot42.DexImport("ACTION_VIEW", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_VIEW = "android.intent.action.VIEW";
				/// <summary>
				///  <para>A synonym for ACTION_VIEW, the "standard" action that is performed on a piece of data. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_DEFAULT
				/// </java-name>
				[Dot42.DexImport("ACTION_DEFAULT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_DEFAULT = "android.intent.action.VIEW";
				/// <summary>
				///  <para>Used to indicate that some piece of data should be attached to some other place. For example, image data could be attached to a contact. It is up to the recipient to decide where the data should be attached; the intent does not specify the ultimate destination. </para> <para>Input: getData is URI of data to be attached. </para> <para>Output: nothing. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_ATTACH_DATA
				/// </java-name>
				[Dot42.DexImport("ACTION_ATTACH_DATA", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_ATTACH_DATA = "android.intent.action.ATTACH_DATA";
				/// <summary>
				///  <para>Activity Action: Provide explicit editable access to the given data. </para> <para>Input: getData is URI of data to be edited. </para> <para>Output: nothing. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_EDIT
				/// </java-name>
				[Dot42.DexImport("ACTION_EDIT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_EDIT = "android.intent.action.EDIT";
				/// <summary>
				///  <para>Activity Action: Pick an existing item, or insert a new item, and then edit it. </para> <para>Input: getType is the desired MIME type of the item to create or edit. The extras can contain type specific data to pass through to the editing/creating activity. </para> <para>Output: The URI of the item that was picked. This must be a content: URI so that any receiver can access it. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_INSERT_OR_EDIT
				/// </java-name>
				[Dot42.DexImport("ACTION_INSERT_OR_EDIT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_INSERT_OR_EDIT = "android.intent.action.INSERT_OR_EDIT";
				/// <summary>
				///  <para>Activity Action: Pick an item from the data, returning what was selected. </para> <para>Input: getData is URI containing a directory of data (vnd.android.cursor.dir/*) from which to pick an item. </para> <para>Output: The URI of the item that was picked. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_PICK
				/// </java-name>
				[Dot42.DexImport("ACTION_PICK", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_PICK = "android.intent.action.PICK";
				/// <summary>
				///  <para>Activity Action: Creates a shortcut. </para> <para>Input: Nothing.</para> <para>Output: An Intent representing the shortcut. The intent must contain three extras: SHORTCUT_INTENT (value: Intent), SHORTCUT_NAME (value: String), and SHORTCUT_ICON (value: Bitmap) or SHORTCUT_ICON_RESOURCE (value: ShortcutIconResource).</para> <para> <para>EXTRA_SHORTCUT_INTENT </para> <para>EXTRA_SHORTCUT_NAME </para> <para>EXTRA_SHORTCUT_ICON </para> <para>EXTRA_SHORTCUT_ICON_RESOURCE </para> <para>android.content.Intent.ShortcutIconResource </para></para>        
				/// </summary>
				/// <java-name>
				/// ACTION_CREATE_SHORTCUT
				/// </java-name>
				[Dot42.DexImport("ACTION_CREATE_SHORTCUT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_CREATE_SHORTCUT = "android.intent.action.CREATE_SHORTCUT";
				/// <summary>
				///  <para>The name of the extra used to define the Intent of a shortcut.</para> <para> <para>ACTION_CREATE_SHORTCUT </para></para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_SHORTCUT_INTENT
				/// </java-name>
				[Dot42.DexImport("EXTRA_SHORTCUT_INTENT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_SHORTCUT_INTENT = "android.intent.extra.shortcut.INTENT";
				/// <summary>
				///  <para>The name of the extra used to define the name of a shortcut.</para> <para> <para>ACTION_CREATE_SHORTCUT </para></para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_SHORTCUT_NAME
				/// </java-name>
				[Dot42.DexImport("EXTRA_SHORTCUT_NAME", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_SHORTCUT_NAME = "android.intent.extra.shortcut.NAME";
				/// <summary>
				///  <para>The name of the extra used to define the icon, as a Bitmap, of a shortcut.</para> <para> <para>ACTION_CREATE_SHORTCUT </para></para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_SHORTCUT_ICON
				/// </java-name>
				[Dot42.DexImport("EXTRA_SHORTCUT_ICON", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_SHORTCUT_ICON = "android.intent.extra.shortcut.ICON";
				/// <summary>
				///  <para>The name of the extra used to define the icon, as a ShortcutIconResource, of a shortcut.</para> <para> <para>ACTION_CREATE_SHORTCUT </para> <para>android.content.Intent.ShortcutIconResource </para></para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_SHORTCUT_ICON_RESOURCE
				/// </java-name>
				[Dot42.DexImport("EXTRA_SHORTCUT_ICON_RESOURCE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_SHORTCUT_ICON_RESOURCE = "android.intent.extra.shortcut.ICON_RESOURCE";
				/// <summary>
				///  <para>Activity Action: Display an activity chooser, allowing the user to pick what they want to before proceeding. This can be used as an alternative to the standard activity picker that is displayed by the system when you try to start an activity with multiple possible matches, with these differences in behavior:  <ul> <li> <para>You can specify the title that will appear in the activity chooser. </para></li> <li> <para>The user does not have the option to make one of the matching activities a preferred activity, and all possible activities will always be shown even if one of them is currently marked as the preferred activity. </para></li></ul></para> <para>This action should be used when the user will naturally expect to select an activity in order to proceed. An example if when not to use it is when the user clicks on a "mailto:" link. They would naturally expect to go directly to their mail app, so startActivity() should be called directly: it will either launch the current preferred app, or put up a dialog allowing the user to pick an app to use and optionally marking that as preferred. </para> <para>In contrast, if the user is selecting a menu item to send a picture they are viewing to someone else, there are many different things they may want to do at this point: send it through e-mail, upload it to a web service, etc. In this case the CHOOSER action should be used, to always present to the user a list of the things they can do, with a nice title given by the caller such as "Send this photo with:". </para> <para>If you need to grant URI permissions through a chooser, you must specify the permissions to be granted on the ACTION_CHOOSER Intent  <b>in addition</b> to the EXTRA_INTENT inside. This means using setClipData to specify the URIs to be granted as well as FLAG_GRANT_READ_URI_PERMISSION and/or FLAG_GRANT_WRITE_URI_PERMISSION as appropriate. </para> <para>As a convenience, an Intent of this form can be created with the createChooser function. </para> <para>Input: No data should be specified. get*Extra must have a EXTRA_INTENT field containing the Intent being executed, and can optionally have a EXTRA_TITLE field containing the title text to display in the chooser. </para> <para>Output: Depends on the protocol of EXTRA_INTENT. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_CHOOSER
				/// </java-name>
				[Dot42.DexImport("ACTION_CHOOSER", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_CHOOSER = "android.intent.action.CHOOSER";
				/// <summary>
				///  <para>Activity Action: Allow the user to select a particular kind of data and return it. This is different than ACTION_PICK in that here we just say what kind of data is desired, not a URI of existing data from which the user can pick. An ACTION_GET_CONTENT could allow the user to create the data as it runs (for example taking a picture or recording a sound), let them browse over the web and download the desired data, etc. </para> <para>There are two main ways to use this action: if you want a specific kind of data, such as a person contact, you set the MIME type to the kind of data you want and launch it with Context#startActivity(Intent). The system will then launch the best application to select that kind of data for you. </para> <para>You may also be interested in any of a set of types of content the user can pick. For example, an e-mail application that wants to allow the user to add an attachment to an e-mail message can use this action to bring up a list of all of the types of content the user can attach. </para> <para>In this case, you should wrap the GET_CONTENT intent with a chooser (through createChooser), which will give the proper interface for the user to pick how to send your data and allow you to specify a prompt indicating what they are doing. You will usually specify a broad MIME type (such as image/* or { *}/*), resulting in a broad range of content types the user can select from. </para> <para>When using such a broad GET_CONTENT action, it is often desirable to only pick from data that can be represented as a stream. This is accomplished by requiring the CATEGORY_OPENABLE in the Intent. </para> <para>Callers can optionally specify EXTRA_LOCAL_ONLY to request that the launched content chooser only returns results representing data that is locally available on the device. For example, if this extra is set to true then an image picker should not show any pictures that are available from a remote server but not already on the local device (thus requiring they be downloaded when opened). </para> <para>If the caller can handle multiple returned items (the user performing multiple selection), then it can specify EXTRA_ALLOW_MULTIPLE to indicate this. </para> <para>Input: getType is the desired MIME type to retrieve. Note that no URI is supplied in the intent, as there are no constraints on where the returned data originally comes from. You may also include the CATEGORY_OPENABLE if you can only accept data that can be opened as a stream. You may use EXTRA_LOCAL_ONLY to limit content selection to local data. You may use EXTRA_ALLOW_MULTIPLE to allow the user to select multiple items. </para> <para>Output: The URI of the item that was picked. This must be a content: URI so that any receiver can access it. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_GET_CONTENT
				/// </java-name>
				[Dot42.DexImport("ACTION_GET_CONTENT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_GET_CONTENT = "android.intent.action.GET_CONTENT";
				/// <summary>
				///  <para>Activity Action: Dial a number as specified by the data. This shows a UI with the number being dialed, allowing the user to explicitly initiate the call. </para> <para>Input: If nothing, an empty dialer is started; else getData is URI of a phone number to be dialed or a tel: URI of an explicit phone number. </para> <para>Output: nothing. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_DIAL
				/// </java-name>
				[Dot42.DexImport("ACTION_DIAL", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_DIAL = "android.intent.action.DIAL";
				/// <summary>
				///  <para>Activity Action: Perform a call to someone specified by the data. </para> <para>Input: If nothing, an empty dialer is started; else getData is URI of a phone number to be dialed or a tel: URI of an explicit phone number. </para> <para>Output: nothing.</para> <para>Note: there will be restrictions on which applications can initiate a call; most applications should use the ACTION_DIAL. </para> <para>Note: this Intent  <b>cannot</b> be used to call emergency numbers. Applications can  <b>dial</b> emergency numbers using ACTION_DIAL, however. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_CALL
				/// </java-name>
				[Dot42.DexImport("ACTION_CALL", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_CALL = "android.intent.action.CALL";
				/// <summary>
				///  <para>Activity Action: Send a message to someone specified by the data. </para> <para>Input: getData is URI describing the target. </para> <para>Output: nothing. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_SENDTO
				/// </java-name>
				[Dot42.DexImport("ACTION_SENDTO", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_SENDTO = "android.intent.action.SENDTO";
				/// <summary>
				///  <para>Activity Action: Deliver some data to someone else. Who the data is being delivered to is not specified; it is up to the receiver of this action to ask the user where the data should be sent. </para> <para>When launching a SEND intent, you should usually wrap it in a chooser (through createChooser), which will give the proper interface for the user to pick how to send your data and allow you to specify a prompt indicating what they are doing. </para> <para>Input: getType is the MIME type of the data being sent. get*Extra can have either a EXTRA_TEXT or EXTRA_STREAM field, containing the data to be sent. If using EXTRA_TEXT, the MIME type should be "text/plain"; otherwise it should be the MIME type of the data in EXTRA_STREAM. Use { *}/* if the MIME type is unknown (this will only allow senders that can handle generic data streams). If using EXTRA_TEXT, you can also optionally supply EXTRA_HTML_TEXT for clients to retrieve your text with HTML formatting. </para> <para>As of android.os.Build.VERSION_CODES#JELLY_BEAN, the data being sent can be supplied through setClipData(ClipData). This allows you to use FLAG_GRANT_READ_URI_PERMISSION when sharing content: URIs and other advanced features of ClipData. If using this approach, you still must supply the same data through the EXTRA_TEXT or EXTRA_STREAM fields described below for compatibility with old applications. If you don't set a ClipData, it will be copied there for you when calling Context#startActivity(Intent). </para> <para>Optional standard extras, which may be interpreted by some recipients as appropriate, are: EXTRA_EMAIL, EXTRA_CC, EXTRA_BCC, EXTRA_SUBJECT. </para> <para>Output: nothing. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_SEND
				/// </java-name>
				[Dot42.DexImport("ACTION_SEND", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_SEND = "android.intent.action.SEND";
				/// <summary>
				///  <para>Activity Action: Deliver multiple data to someone else. </para> <para>Like ACTION_SEND, except the data is multiple. </para> <para>Input: getType is the MIME type of the data being sent. get*ArrayListExtra can have either a EXTRA_TEXT or EXTRA_STREAM field, containing the data to be sent. If using EXTRA_TEXT, you can also optionally supply EXTRA_HTML_TEXT for clients to retrieve your text with HTML formatting. </para> <para>Multiple types are supported, and receivers should handle mixed types whenever possible. The right way for the receiver to check them is to use the content resolver on each URI. The intent sender should try to put the most concrete mime type in the intent type, but it can fall back to { &lt;type&gt;/*} or { *}/* as needed. </para> <para>e.g. if you are sending image/jpg and image/jpg, the intent's type can be image/jpg, but if you are sending image/jpg and image/png, then the intent's type should be image/*. </para> <para>As of android.os.Build.VERSION_CODES#JELLY_BEAN, the data being sent can be supplied through setClipData(ClipData). This allows you to use FLAG_GRANT_READ_URI_PERMISSION when sharing content: URIs and other advanced features of ClipData. If using this approach, you still must supply the same data through the EXTRA_TEXT or EXTRA_STREAM fields described below for compatibility with old applications. If you don't set a ClipData, it will be copied there for you when calling Context#startActivity(Intent). </para> <para>Optional standard extras, which may be interpreted by some recipients as appropriate, are: EXTRA_EMAIL, EXTRA_CC, EXTRA_BCC, EXTRA_SUBJECT. </para> <para>Output: nothing. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_SEND_MULTIPLE
				/// </java-name>
				[Dot42.DexImport("ACTION_SEND_MULTIPLE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_SEND_MULTIPLE = "android.intent.action.SEND_MULTIPLE";
				/// <summary>
				///  <para>Activity Action: Handle an incoming phone call. </para> <para>Input: nothing. </para> <para>Output: nothing. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_ANSWER
				/// </java-name>
				[Dot42.DexImport("ACTION_ANSWER", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_ANSWER = "android.intent.action.ANSWER";
				/// <summary>
				///  <para>Activity Action: Insert an empty item into the given container. </para> <para>Input: getData is URI of the directory (vnd.android.cursor.dir/*) in which to place the data. </para> <para>Output: URI of the new data that was created. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_INSERT
				/// </java-name>
				[Dot42.DexImport("ACTION_INSERT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_INSERT = "android.intent.action.INSERT";
				/// <summary>
				///  <para>Activity Action: Create a new item in the given container, initializing it from the current contents of the clipboard. </para> <para>Input: getData is URI of the directory (vnd.android.cursor.dir/*) in which to place the data. </para> <para>Output: URI of the new data that was created. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_PASTE
				/// </java-name>
				[Dot42.DexImport("ACTION_PASTE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_PASTE = "android.intent.action.PASTE";
				/// <summary>
				///  <para>Activity Action: Delete the given data from its container. </para> <para>Input: getData is URI of data to be deleted. </para> <para>Output: nothing. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_DELETE
				/// </java-name>
				[Dot42.DexImport("ACTION_DELETE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_DELETE = "android.intent.action.DELETE";
				/// <summary>
				///  <para>Activity Action: Run the data, whatever that means. </para> <para>Input: ? (Note: this is currently specific to the test harness.) </para> <para>Output: nothing. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_RUN
				/// </java-name>
				[Dot42.DexImport("ACTION_RUN", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_RUN = "android.intent.action.RUN";
				/// <summary>
				///  <para>Activity Action: Perform a data synchronization. </para> <para>Input: ? </para> <para>Output: ? </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_SYNC
				/// </java-name>
				[Dot42.DexImport("ACTION_SYNC", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_SYNC = "android.intent.action.SYNC";
				/// <summary>
				///  <para>Activity Action: Pick an activity given an intent, returning the class selected. </para> <para>Input: get*Extra field EXTRA_INTENT is an Intent used with PackageManager#queryIntentActivities to determine the set of activities from which to pick. </para> <para>Output: Class name of the activity that was selected. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_PICK_ACTIVITY
				/// </java-name>
				[Dot42.DexImport("ACTION_PICK_ACTIVITY", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_PICK_ACTIVITY = "android.intent.action.PICK_ACTIVITY";
				/// <summary>
				///  <para>Activity Action: Perform a search. </para> <para>Input: getStringExtra(SearchManager.QUERY) is the text to search for. If empty, simply enter your search results Activity with the search UI activated. </para> <para>Output: nothing. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_SEARCH
				/// </java-name>
				[Dot42.DexImport("ACTION_SEARCH", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_SEARCH = "android.intent.action.SEARCH";
				/// <summary>
				///  <para>Activity Action: Start the platform-defined tutorial </para> <para>Input: getStringExtra(SearchManager.QUERY) is the text to search for. If empty, simply enter your search results Activity with the search UI activated. </para> <para>Output: nothing. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_SYSTEM_TUTORIAL
				/// </java-name>
				[Dot42.DexImport("ACTION_SYSTEM_TUTORIAL", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_SYSTEM_TUTORIAL = "android.intent.action.SYSTEM_TUTORIAL";
				/// <summary>
				///  <para>Activity Action: Perform a web search. </para> <para>Input: getStringExtra(SearchManager.QUERY) is the text to search for. If it is a url starts with http or https, the site will be opened. If it is plain text, Google search will be applied. </para> <para>Output: nothing. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_WEB_SEARCH
				/// </java-name>
				[Dot42.DexImport("ACTION_WEB_SEARCH", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_WEB_SEARCH = "android.intent.action.WEB_SEARCH";
				/// <summary>
				///  <para>Activity Action: List all available applications </para> <para>Input: Nothing. </para> <para>Output: nothing. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_ALL_APPS
				/// </java-name>
				[Dot42.DexImport("ACTION_ALL_APPS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_ALL_APPS = "android.intent.action.ALL_APPS";
				/// <summary>
				///  <para>Activity Action: Show settings for choosing wallpaper </para> <para>Input: Nothing. </para> <para>Output: Nothing. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_SET_WALLPAPER
				/// </java-name>
				[Dot42.DexImport("ACTION_SET_WALLPAPER", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_SET_WALLPAPER = "android.intent.action.SET_WALLPAPER";
				/// <summary>
				///  <para>Activity Action: Show activity for reporting a bug. </para> <para>Input: Nothing. </para> <para>Output: Nothing. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_BUG_REPORT
				/// </java-name>
				[Dot42.DexImport("ACTION_BUG_REPORT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_BUG_REPORT = "android.intent.action.BUG_REPORT";
				/// <summary>
				///  <para>Activity Action: Main entry point for factory tests. Only used when the device is booting in factory test node. The implementing package must be installed in the system image. </para> <para>Input: nothing </para> <para>Output: nothing </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_FACTORY_TEST
				/// </java-name>
				[Dot42.DexImport("ACTION_FACTORY_TEST", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_FACTORY_TEST = "android.intent.action.FACTORY_TEST";
				/// <summary>
				///  <para>Activity Action: The user pressed the "call" button to go to the dialer or other appropriate UI for placing a call. </para> <para>Input: Nothing. </para> <para>Output: Nothing. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_CALL_BUTTON
				/// </java-name>
				[Dot42.DexImport("ACTION_CALL_BUTTON", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_CALL_BUTTON = "android.intent.action.CALL_BUTTON";
				/// <summary>
				///  <para>Activity Action: Start Voice Command. </para> <para>Input: Nothing. </para> <para>Output: Nothing. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_VOICE_COMMAND
				/// </java-name>
				[Dot42.DexImport("ACTION_VOICE_COMMAND", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_VOICE_COMMAND = "android.intent.action.VOICE_COMMAND";
				/// <summary>
				///  <para>Activity Action: Start action associated with long pressing on the search key. </para> <para>Input: Nothing. </para> <para>Output: Nothing. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_SEARCH_LONG_PRESS
				/// </java-name>
				[Dot42.DexImport("ACTION_SEARCH_LONG_PRESS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_SEARCH_LONG_PRESS = "android.intent.action.SEARCH_LONG_PRESS";
				/// <summary>
				///  <para>Activity Action: Show power usage information to the user. </para> <para>Input: Nothing. </para> <para>Output: Nothing. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_POWER_USAGE_SUMMARY
				/// </java-name>
				[Dot42.DexImport("ACTION_POWER_USAGE_SUMMARY", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_POWER_USAGE_SUMMARY = "android.intent.action.POWER_USAGE_SUMMARY";
				/// <summary>
				///  <para>Broadcast Action: Sent after the screen turns off.</para> <para>This is a protected intent that can only be sent by the system. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_SCREEN_OFF
				/// </java-name>
				[Dot42.DexImport("ACTION_SCREEN_OFF", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_SCREEN_OFF = "android.intent.action.SCREEN_OFF";
				/// <summary>
				///  <para>Broadcast Action: Sent after the screen turns on.</para> <para>This is a protected intent that can only be sent by the system. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_SCREEN_ON
				/// </java-name>
				[Dot42.DexImport("ACTION_SCREEN_ON", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_SCREEN_ON = "android.intent.action.SCREEN_ON";
				/// <summary>
				///  <para>Broadcast Action: Sent when the user is present after device wakes up (e.g when the keyguard is gone).</para> <para>This is a protected intent that can only be sent by the system. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_USER_PRESENT
				/// </java-name>
				[Dot42.DexImport("ACTION_USER_PRESENT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_USER_PRESENT = "android.intent.action.USER_PRESENT";
				/// <summary>
				///  <para>Broadcast Action: The current time has changed. Sent every minute. You can  <b>not</b> receive this through components declared in manifests, only by explicitly registering for it with Context.registerReceiver().</para> <para>This is a protected intent that can only be sent by the system. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_TIME_TICK
				/// </java-name>
				[Dot42.DexImport("ACTION_TIME_TICK", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_TIME_TICK = "android.intent.action.TIME_TICK";
				/// <summary>
				///  <para>Broadcast Action: The time was set. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_TIME_CHANGED
				/// </java-name>
				[Dot42.DexImport("ACTION_TIME_CHANGED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_TIME_CHANGED = "android.intent.action.TIME_SET";
				/// <summary>
				///  <para>Broadcast Action: The date has changed. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_DATE_CHANGED
				/// </java-name>
				[Dot42.DexImport("ACTION_DATE_CHANGED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_DATE_CHANGED = "android.intent.action.DATE_CHANGED";
				/// <summary>
				///  <para>Broadcast Action: The timezone has changed. The intent will have the following extra values:</para> <para> <ul> <li> <para> <b>time-zone</b> - The java.util.TimeZone.getID() value identifying the new time zone. </para></li></ul></para> <para>This is a protected intent that can only be sent by the system. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_TIMEZONE_CHANGED
				/// </java-name>
				[Dot42.DexImport("ACTION_TIMEZONE_CHANGED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_TIMEZONE_CHANGED = "android.intent.action.TIMEZONE_CHANGED";
				/// <summary>
				///  <para>Broadcast Action: This is broadcast once, after the system has finished booting. It can be used to perform application-specific initialization, such as installing alarms. You must hold the android.Manifest.permission#RECEIVE_BOOT_COMPLETED permission in order to receive this broadcast.</para> <para>This is a protected intent that can only be sent by the system. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_BOOT_COMPLETED
				/// </java-name>
				[Dot42.DexImport("ACTION_BOOT_COMPLETED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_BOOT_COMPLETED = "android.intent.action.BOOT_COMPLETED";
				/// <summary>
				///  <para>Broadcast Action: This is broadcast when a user action should request a temporary system dialog to dismiss. Some examples of temporary system dialogs are the notification window-shade and the recent tasks dialog. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_CLOSE_SYSTEM_DIALOGS
				/// </java-name>
				[Dot42.DexImport("ACTION_CLOSE_SYSTEM_DIALOGS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_CLOSE_SYSTEM_DIALOGS = "android.intent.action.CLOSE_SYSTEM_DIALOGS";
				/// <summary>
				///  <para>Broadcast Action: Trigger the download and eventual installation of a package. </para> <para>Input: getData is the URI of the package file to download.</para> <para>This is a protected intent that can only be sent by the system.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>This constant has never been used. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// ACTION_PACKAGE_INSTALL
				/// </java-name>
				[Dot42.DexImport("ACTION_PACKAGE_INSTALL", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_PACKAGE_INSTALL = "android.intent.action.PACKAGE_INSTALL";
				/// <summary>
				///  <para>Broadcast Action: A new application package has been installed on the device. The data contains the name of the package. Note that the newly installed package does  <b>not</b> receive this broadcast. </para> <para>May include the following extras:  <ul> <li> <para>EXTRA_UID containing the integer uid assigned to the new package. </para></li> <li> <para>EXTRA_REPLACING is set to true if this is following an ACTION_PACKAGE_REMOVED broadcast for the same package. </para></li></ul></para> <para>This is a protected intent that can only be sent by the system. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_PACKAGE_ADDED
				/// </java-name>
				[Dot42.DexImport("ACTION_PACKAGE_ADDED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_PACKAGE_ADDED = "android.intent.action.PACKAGE_ADDED";
				/// <summary>
				///  <para>Broadcast Action: A new version of an application package has been installed, replacing an existing version that was previously installed. The data contains the name of the package. </para> <para>May include the following extras:  <ul> <li> <para>EXTRA_UID containing the integer uid assigned to the new package. </para></li></ul></para> <para>This is a protected intent that can only be sent by the system. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_PACKAGE_REPLACED
				/// </java-name>
				[Dot42.DexImport("ACTION_PACKAGE_REPLACED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_PACKAGE_REPLACED = "android.intent.action.PACKAGE_REPLACED";
				/// <summary>
				///  <para>Broadcast Action: A new version of your application has been installed over an existing one. This is only sent to the application that was replaced. It does not contain any additional data; to receive it, just use an intent filter for this action.</para> <para>This is a protected intent that can only be sent by the system. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_MY_PACKAGE_REPLACED
				/// </java-name>
				[Dot42.DexImport("ACTION_MY_PACKAGE_REPLACED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_MY_PACKAGE_REPLACED = "android.intent.action.MY_PACKAGE_REPLACED";
				/// <summary>
				///  <para>Broadcast Action: An existing application package has been removed from the device. The data contains the name of the package. The package that is being installed does  <b>not</b> receive this Intent.  <ul> <li> <para>EXTRA_UID containing the integer uid previously assigned to the package. </para></li> <li> <para>EXTRA_DATA_REMOVED is set to true if the entire application  data and code  is being removed. </para></li> <li> <para>EXTRA_REPLACING is set to true if this will be followed by an ACTION_PACKAGE_ADDED broadcast for the same package. </para></li></ul></para> <para>This is a protected intent that can only be sent by the system. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_PACKAGE_REMOVED
				/// </java-name>
				[Dot42.DexImport("ACTION_PACKAGE_REMOVED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_PACKAGE_REMOVED = "android.intent.action.PACKAGE_REMOVED";
				/// <summary>
				///  <para>Broadcast Action: An existing application package has been changed (e.g. a component has been enabled or disabled). The data contains the name of the package.  <ul> <li> <para>EXTRA_UID containing the integer uid assigned to the package. </para></li> <li> <para>EXTRA_CHANGED_COMPONENT_NAME_LIST containing the class name of the changed components (or the package name itself). </para></li> <li> <para>EXTRA_DONT_KILL_APP containing boolean field to override the default action of restarting the application. </para></li></ul></para> <para>This is a protected intent that can only be sent by the system. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_PACKAGE_CHANGED
				/// </java-name>
				[Dot42.DexImport("ACTION_PACKAGE_CHANGED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_PACKAGE_CHANGED = "android.intent.action.PACKAGE_CHANGED";
				/// <summary>
				///  <para>Broadcast Action: The user has restarted a package, and all of its processes have been killed. All runtime state associated with it (processes, alarms, notifications, etc) should be removed. Note that the restarted package does  <b>not</b> receive this broadcast. The data contains the name of the package.  <ul> <li> <para>EXTRA_UID containing the integer uid assigned to the package. </para></li></ul></para> <para>This is a protected intent that can only be sent by the system. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_PACKAGE_RESTARTED
				/// </java-name>
				[Dot42.DexImport("ACTION_PACKAGE_RESTARTED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_PACKAGE_RESTARTED = "android.intent.action.PACKAGE_RESTARTED";
				/// <summary>
				///  <para>Broadcast Action: The user has cleared the data of a package. This should be preceded by ACTION_PACKAGE_RESTARTED, after which all of its persistent data is erased and this broadcast sent. Note that the cleared package does  <b>not</b> receive this broadcast. The data contains the name of the package.  <ul> <li> <para>EXTRA_UID containing the integer uid assigned to the package. </para></li></ul></para> <para>This is a protected intent that can only be sent by the system. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_PACKAGE_DATA_CLEARED
				/// </java-name>
				[Dot42.DexImport("ACTION_PACKAGE_DATA_CLEARED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_PACKAGE_DATA_CLEARED = "android.intent.action.PACKAGE_DATA_CLEARED";
				/// <summary>
				///  <para>Broadcast Action: A user ID has been removed from the system. The user ID number is stored in the extra data under EXTRA_UID.</para> <para>This is a protected intent that can only be sent by the system. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_UID_REMOVED
				/// </java-name>
				[Dot42.DexImport("ACTION_UID_REMOVED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_UID_REMOVED = "android.intent.action.UID_REMOVED";
				/// <summary>
				///  <para>Broadcast Action: Sent to the installer package of an application when that application is first launched (that is the first time it is moved out of the stopped state). The data contains the name of the package.</para> <para>This is a protected intent that can only be sent by the system. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_PACKAGE_FIRST_LAUNCH
				/// </java-name>
				[Dot42.DexImport("ACTION_PACKAGE_FIRST_LAUNCH", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_PACKAGE_FIRST_LAUNCH = "android.intent.action.PACKAGE_FIRST_LAUNCH";
				/// <summary>
				///  <para>Broadcast Action: Resources for a set of packages (which were previously unavailable) are currently available since the media on which they exist is available. The extra data EXTRA_CHANGED_PACKAGE_LIST contains a list of packages whose availability changed. The extra data EXTRA_CHANGED_UID_LIST contains a list of uids of packages whose availability changed. Note that the packages in this list do  <b>not</b> receive this broadcast. The specified set of packages are now available on the system. </para> <para>Includes the following extras:  <ul> <li> <para>EXTRA_CHANGED_PACKAGE_LIST is the set of packages whose resources(were previously unavailable) are currently available. EXTRA_CHANGED_UID_LIST is the set of uids of the packages whose resources(were previously unavailable) are currently available. </para></li></ul></para> <para>This is a protected intent that can only be sent by the system. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_EXTERNAL_APPLICATIONS_AVAILABLE
				/// </java-name>
				[Dot42.DexImport("ACTION_EXTERNAL_APPLICATIONS_AVAILABLE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_EXTERNAL_APPLICATIONS_AVAILABLE = "android.intent.action.EXTERNAL_APPLICATIONS_AVAILABLE";
				/// <summary>
				///  <para>Broadcast Action: Resources for a set of packages are currently unavailable since the media on which they exist is unavailable. The extra data EXTRA_CHANGED_PACKAGE_LIST contains a list of packages whose availability changed. The extra data EXTRA_CHANGED_UID_LIST contains a list of uids of packages whose availability changed. The specified set of packages can no longer be launched and are practically unavailable on the system. </para> <para>Inclues the following extras:  <ul> <li> <para>EXTRA_CHANGED_PACKAGE_LIST is the set of packages whose resources are no longer available. EXTRA_CHANGED_UID_LIST is the set of packages whose resources are no longer available. </para></li></ul></para> <para>This is a protected intent that can only be sent by the system. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_EXTERNAL_APPLICATIONS_UNAVAILABLE
				/// </java-name>
				[Dot42.DexImport("ACTION_EXTERNAL_APPLICATIONS_UNAVAILABLE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_EXTERNAL_APPLICATIONS_UNAVAILABLE = "android.intent.action.EXTERNAL_APPLICATIONS_UNAVAILABLE";
				/// <summary>
				///  <para>Broadcast Action: The current system wallpaper has changed. See android.app.WallpaperManager for retrieving the new wallpaper. This should  <b>only</b> be used to determine when the wallpaper has changed to show the new wallpaper to the user. You should certainly never, in response to this, change the wallpaper or other attributes of it such as the suggested size. That would be crazy, right? You'd cause all kinds of loops, especially if other apps are doing similar things, right? Of course. So please don't do this.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Modern applications should use WindowManager.LayoutParams.FLAG_SHOW_WALLPAPER to have the wallpaper shown behind their UI, rather than watching for this broadcast and rendering the wallpaper on their own. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// ACTION_WALLPAPER_CHANGED
				/// </java-name>
				[Dot42.DexImport("ACTION_WALLPAPER_CHANGED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_WALLPAPER_CHANGED = "android.intent.action.WALLPAPER_CHANGED";
				/// <summary>
				///  <para>Broadcast Action: The current device android.content.res.Configuration (orientation, locale, etc) has changed. When such a change happens, the UIs (view hierarchy) will need to be rebuilt based on this new information; for the most part, applications don't need to worry about this, because the system will take care of stopping and restarting the application to make sure it sees the new changes. Some system code that can not be restarted will need to watch for this action and handle it appropriately.</para> <para>You can  <b>not</b> receive this through components declared in manifests, only by explicitly registering for it with Context.registerReceiver().</para> <para>This is a protected intent that can only be sent by the system.</para> <para> <para>android.content.res.Configuration </para></para>        
				/// </summary>
				/// <java-name>
				/// ACTION_CONFIGURATION_CHANGED
				/// </java-name>
				[Dot42.DexImport("ACTION_CONFIGURATION_CHANGED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_CONFIGURATION_CHANGED = "android.intent.action.CONFIGURATION_CHANGED";
				/// <summary>
				///  <para>Broadcast Action: The current device's locale has changed.</para> <para>This is a protected intent that can only be sent by the system. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_LOCALE_CHANGED
				/// </java-name>
				[Dot42.DexImport("ACTION_LOCALE_CHANGED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_LOCALE_CHANGED = "android.intent.action.LOCALE_CHANGED";
				/// <summary>
				///  <para>Broadcast Action: This is a  <b>sticky broadcast</b> containing the charging state, level, and other information about the battery. See android.os.BatteryManager for documentation on the contents of the Intent.</para> <para>You can  <b>not</b> receive this through components declared in manifests, only by explicitly registering for it with Context.registerReceiver(). See ACTION_BATTERY_LOW, ACTION_BATTERY_OKAY, ACTION_POWER_CONNECTED, and ACTION_POWER_DISCONNECTED for distinct battery-related broadcasts that are sent and can be received through manifest receivers.</para> <para>This is a protected intent that can only be sent by the system. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_BATTERY_CHANGED
				/// </java-name>
				[Dot42.DexImport("ACTION_BATTERY_CHANGED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_BATTERY_CHANGED = "android.intent.action.BATTERY_CHANGED";
				/// <summary>
				///  <para>Broadcast Action: Indicates low battery condition on the device. This broadcast corresponds to the "Low battery warning" system dialog.</para> <para>This is a protected intent that can only be sent by the system. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_BATTERY_LOW
				/// </java-name>
				[Dot42.DexImport("ACTION_BATTERY_LOW", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_BATTERY_LOW = "android.intent.action.BATTERY_LOW";
				/// <summary>
				///  <para>Broadcast Action: Indicates the battery is now okay after being low. This will be sent after ACTION_BATTERY_LOW once the battery has gone back up to an okay state.</para> <para>This is a protected intent that can only be sent by the system. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_BATTERY_OKAY
				/// </java-name>
				[Dot42.DexImport("ACTION_BATTERY_OKAY", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_BATTERY_OKAY = "android.intent.action.BATTERY_OKAY";
				/// <summary>
				///  <para>Broadcast Action: External power has been connected to the device. This is intended for applications that wish to register specifically to this notification. Unlike ACTION_BATTERY_CHANGED, applications will be woken for this and so do not have to stay active to receive this notification. This action can be used to implement actions that wait until power is available to trigger.</para> <para>This is a protected intent that can only be sent by the system. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_POWER_CONNECTED
				/// </java-name>
				[Dot42.DexImport("ACTION_POWER_CONNECTED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_POWER_CONNECTED = "android.intent.action.ACTION_POWER_CONNECTED";
				/// <summary>
				///  <para>Broadcast Action: External power has been removed from the device. This is intended for applications that wish to register specifically to this notification. Unlike ACTION_BATTERY_CHANGED, applications will be woken for this and so do not have to stay active to receive this notification. This action can be used to implement actions that wait until power is available to trigger.</para> <para>This is a protected intent that can only be sent by the system. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_POWER_DISCONNECTED
				/// </java-name>
				[Dot42.DexImport("ACTION_POWER_DISCONNECTED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_POWER_DISCONNECTED = "android.intent.action.ACTION_POWER_DISCONNECTED";
				/// <summary>
				///  <para>Broadcast Action: Device is shutting down. This is broadcast when the device is being shut down (completely turned off, not sleeping). Once the broadcast is complete, the final shutdown will proceed and all unsaved data lost. Apps will not normally need to handle this, since the foreground activity will be paused as well.</para> <para>This is a protected intent that can only be sent by the system. </para> <para>May include the following extras:  <ul> <li> <para>EXTRA_SHUTDOWN_USERSPACE_ONLY a boolean that is set to true if this shutdown is only for userspace processes. If not set, assumed to be false. </para></li></ul></para>        
				/// </summary>
				/// <java-name>
				/// ACTION_SHUTDOWN
				/// </java-name>
				[Dot42.DexImport("ACTION_SHUTDOWN", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_SHUTDOWN = "android.intent.action.ACTION_SHUTDOWN";
				/// <summary>
				///  <para>Broadcast Action: A sticky broadcast that indicates low memory condition on the device</para> <para>This is a protected intent that can only be sent by the system. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_DEVICE_STORAGE_LOW
				/// </java-name>
				[Dot42.DexImport("ACTION_DEVICE_STORAGE_LOW", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_DEVICE_STORAGE_LOW = "android.intent.action.DEVICE_STORAGE_LOW";
				/// <summary>
				///  <para>Broadcast Action: Indicates low memory condition on the device no longer exists</para> <para>This is a protected intent that can only be sent by the system. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_DEVICE_STORAGE_OK
				/// </java-name>
				[Dot42.DexImport("ACTION_DEVICE_STORAGE_OK", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_DEVICE_STORAGE_OK = "android.intent.action.DEVICE_STORAGE_OK";
				/// <summary>
				///  <para>Broadcast Action: Indicates low memory condition notification acknowledged by user and package management should be started. This is triggered by the user from the ACTION_DEVICE_STORAGE_LOW notification. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_MANAGE_PACKAGE_STORAGE
				/// </java-name>
				[Dot42.DexImport("ACTION_MANAGE_PACKAGE_STORAGE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_MANAGE_PACKAGE_STORAGE = "android.intent.action.MANAGE_PACKAGE_STORAGE";
				/// <summary>
				///  <para>Broadcast Action: The device has entered USB Mass Storage mode. This is used mainly for the USB Settings panel. Apps should listen for ACTION_MEDIA_MOUNTED and ACTION_MEDIA_UNMOUNTED broadcasts to be notified when the SD card file system is mounted or unmounted  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>replaced by android.os.storage.StorageEventListener </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// ACTION_UMS_CONNECTED
				/// </java-name>
				[Dot42.DexImport("ACTION_UMS_CONNECTED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_UMS_CONNECTED = "android.intent.action.UMS_CONNECTED";
				/// <summary>
				///  <para>Broadcast Action: The device has exited USB Mass Storage mode. This is used mainly for the USB Settings panel. Apps should listen for ACTION_MEDIA_MOUNTED and ACTION_MEDIA_UNMOUNTED broadcasts to be notified when the SD card file system is mounted or unmounted  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>replaced by android.os.storage.StorageEventListener </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// ACTION_UMS_DISCONNECTED
				/// </java-name>
				[Dot42.DexImport("ACTION_UMS_DISCONNECTED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_UMS_DISCONNECTED = "android.intent.action.UMS_DISCONNECTED";
				/// <summary>
				///  <para>Broadcast Action: External media has been removed. The path to the mount point for the removed media is contained in the Intent.mData field. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_MEDIA_REMOVED
				/// </java-name>
				[Dot42.DexImport("ACTION_MEDIA_REMOVED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_MEDIA_REMOVED = "android.intent.action.MEDIA_REMOVED";
				/// <summary>
				///  <para>Broadcast Action: External media is present, but not mounted at its mount point. The path to the mount point for the unmounted media is contained in the Intent.mData field. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_MEDIA_UNMOUNTED
				/// </java-name>
				[Dot42.DexImport("ACTION_MEDIA_UNMOUNTED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_MEDIA_UNMOUNTED = "android.intent.action.MEDIA_UNMOUNTED";
				/// <summary>
				///  <para>Broadcast Action: External media is present, and being disk-checked The path to the mount point for the checking media is contained in the Intent.mData field. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_MEDIA_CHECKING
				/// </java-name>
				[Dot42.DexImport("ACTION_MEDIA_CHECKING", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_MEDIA_CHECKING = "android.intent.action.MEDIA_CHECKING";
				/// <summary>
				///  <para>Broadcast Action: External media is present, but is using an incompatible fs (or is blank) The path to the mount point for the checking media is contained in the Intent.mData field. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_MEDIA_NOFS
				/// </java-name>
				[Dot42.DexImport("ACTION_MEDIA_NOFS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_MEDIA_NOFS = "android.intent.action.MEDIA_NOFS";
				/// <summary>
				///  <para>Broadcast Action: External media is present and mounted at its mount point. The path to the mount point for the mounted media is contained in the Intent.mData field. The Intent contains an extra with name "read-only" and Boolean value to indicate if the media was mounted read only. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_MEDIA_MOUNTED
				/// </java-name>
				[Dot42.DexImport("ACTION_MEDIA_MOUNTED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_MEDIA_MOUNTED = "android.intent.action.MEDIA_MOUNTED";
				/// <summary>
				///  <para>Broadcast Action: External media is unmounted because it is being shared via USB mass storage. The path to the mount point for the shared media is contained in the Intent.mData field. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_MEDIA_SHARED
				/// </java-name>
				[Dot42.DexImport("ACTION_MEDIA_SHARED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_MEDIA_SHARED = "android.intent.action.MEDIA_SHARED";
				/// <summary>
				///  <para>Broadcast Action: External media was removed from SD card slot, but mount point was not unmounted. The path to the mount point for the removed media is contained in the Intent.mData field. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_MEDIA_BAD_REMOVAL
				/// </java-name>
				[Dot42.DexImport("ACTION_MEDIA_BAD_REMOVAL", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_MEDIA_BAD_REMOVAL = "android.intent.action.MEDIA_BAD_REMOVAL";
				/// <summary>
				///  <para>Broadcast Action: External media is present but cannot be mounted. The path to the mount point for the unmountable media is contained in the Intent.mData field. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_MEDIA_UNMOUNTABLE
				/// </java-name>
				[Dot42.DexImport("ACTION_MEDIA_UNMOUNTABLE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_MEDIA_UNMOUNTABLE = "android.intent.action.MEDIA_UNMOUNTABLE";
				/// <summary>
				///  <para>Broadcast Action: User has expressed the desire to remove the external storage media. Applications should close all files they have open within the mount point when they receive this intent. The path to the mount point for the media to be ejected is contained in the Intent.mData field. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_MEDIA_EJECT
				/// </java-name>
				[Dot42.DexImport("ACTION_MEDIA_EJECT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_MEDIA_EJECT = "android.intent.action.MEDIA_EJECT";
				/// <summary>
				///  <para>Broadcast Action: The media scanner has started scanning a directory. The path to the directory being scanned is contained in the Intent.mData field. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_MEDIA_SCANNER_STARTED
				/// </java-name>
				[Dot42.DexImport("ACTION_MEDIA_SCANNER_STARTED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_MEDIA_SCANNER_STARTED = "android.intent.action.MEDIA_SCANNER_STARTED";
				/// <summary>
				///  <para>Broadcast Action: The media scanner has finished scanning a directory. The path to the scanned directory is contained in the Intent.mData field. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_MEDIA_SCANNER_FINISHED
				/// </java-name>
				[Dot42.DexImport("ACTION_MEDIA_SCANNER_FINISHED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_MEDIA_SCANNER_FINISHED = "android.intent.action.MEDIA_SCANNER_FINISHED";
				/// <summary>
				///  <para>Broadcast Action: Request the media scanner to scan a file and add it to the media database. The path to the file is contained in the Intent.mData field. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_MEDIA_SCANNER_SCAN_FILE
				/// </java-name>
				[Dot42.DexImport("ACTION_MEDIA_SCANNER_SCAN_FILE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_MEDIA_SCANNER_SCAN_FILE = "android.intent.action.MEDIA_SCANNER_SCAN_FILE";
				/// <summary>
				///  <para>Broadcast Action: The "Media Button" was pressed. Includes a single extra field, EXTRA_KEY_EVENT, containing the key event that caused the broadcast. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_MEDIA_BUTTON
				/// </java-name>
				[Dot42.DexImport("ACTION_MEDIA_BUTTON", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_MEDIA_BUTTON = "android.intent.action.MEDIA_BUTTON";
				/// <summary>
				///  <para>Broadcast Action: The "Camera Button" was pressed. Includes a single extra field, EXTRA_KEY_EVENT, containing the key event that caused the broadcast. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_CAMERA_BUTTON
				/// </java-name>
				[Dot42.DexImport("ACTION_CAMERA_BUTTON", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_CAMERA_BUTTON = "android.intent.action.CAMERA_BUTTON";
				/// <summary>
				///  <para>Broadcast Action: A GTalk connection has been established. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_GTALK_SERVICE_CONNECTED
				/// </java-name>
				[Dot42.DexImport("ACTION_GTALK_SERVICE_CONNECTED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_GTALK_SERVICE_CONNECTED = "android.intent.action.GTALK_CONNECTED";
				/// <summary>
				///  <para>Broadcast Action: A GTalk connection has been disconnected. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_GTALK_SERVICE_DISCONNECTED
				/// </java-name>
				[Dot42.DexImport("ACTION_GTALK_SERVICE_DISCONNECTED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_GTALK_SERVICE_DISCONNECTED = "android.intent.action.GTALK_DISCONNECTED";
				/// <summary>
				///  <para>Broadcast Action: An input method has been changed. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_INPUT_METHOD_CHANGED
				/// </java-name>
				[Dot42.DexImport("ACTION_INPUT_METHOD_CHANGED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_INPUT_METHOD_CHANGED = "android.intent.action.INPUT_METHOD_CHANGED";
				/// <summary>
				///  <para>Broadcast Action: The user has switched the phone into or out of Airplane Mode. One or more radios have been turned off or on. The intent will have the following extra value:</para> <para> <ul> <li> <para> <b>state</b> - A boolean value indicating whether Airplane Mode is on. If true, then cell radio and possibly other radios such as bluetooth or WiFi may have also been turned off </para></li></ul></para> <para>This is a protected intent that can only be sent by the system. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_AIRPLANE_MODE_CHANGED
				/// </java-name>
				[Dot42.DexImport("ACTION_AIRPLANE_MODE_CHANGED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_AIRPLANE_MODE_CHANGED = "android.intent.action.AIRPLANE_MODE";
				/// <summary>
				///  <para>Broadcast Action: Some content providers have parts of their namespace where they publish new events or items that the user may be especially interested in. For these things, they may broadcast this action when the set of interesting items change.</para> <para>For example, GmailProvider sends this notification when the set of unread mail in the inbox changes.</para> <para>The data of the intent identifies which part of which provider changed. When queried through the content resolver, the data URI will return the data set in question.</para> <para>The intent will have the following extra values:  <ul> <li> <para> <b>count</b> - The number of items in the data set. This is the same as the number of items in the cursor returned by querying the data URI.  </para></li></ul></para> <para>This intent will be sent at boot (if the count is non-zero) and when the data set changes. It is possible for the data set to change without the count changing (for example, if a new unread message arrives in the same sync operation in which a message is archived). The phone should still ring/vibrate/etc as normal in this case. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_PROVIDER_CHANGED
				/// </java-name>
				[Dot42.DexImport("ACTION_PROVIDER_CHANGED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_PROVIDER_CHANGED = "android.intent.action.PROVIDER_CHANGED";
				/// <summary>
				///  <para>Broadcast Action: Wired Headset plugged in or unplugged.</para> <para>The intent will have the following extra values:  <ul> <li> <para> <b>state</b> - 0 for unplugged, 1 for plugged.  </para></li> <li> <para> <b>name</b> - Headset type, human readable string  </para></li> <li> <para> <b>microphone</b> - 1 if headset has a microphone, 0 otherwise  </para></li></ul></para>        
				/// </summary>
				/// <java-name>
				/// ACTION_HEADSET_PLUG
				/// </java-name>
				[Dot42.DexImport("ACTION_HEADSET_PLUG", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_HEADSET_PLUG = "android.intent.action.HEADSET_PLUG";
				/// <summary>
				///  <para>Broadcast Action: An outgoing call is about to be placed.</para> <para>The Intent will have the following extra value:</para> <para> <ul> <li> <para> <b>android.content.Intent#EXTRA_PHONE_NUMBER</b> - the phone number originally intended to be dialed. </para></li></ul></para> <para>Once the broadcast is finished, the resultData is used as the actual number to call. If  <code>null</code>, no call will be placed.</para> <para>It is perfectly acceptable for multiple receivers to process the outgoing call in turn: for example, a parental control application might verify that the user is authorized to place the call at that time, then a number-rewriting application might add an area code if one was not specified.</para> <para>For consistency, any receiver whose purpose is to prohibit phone calls should have a priority of 0, to ensure it will see the final phone number to be dialed. Any receiver whose purpose is to rewrite phone numbers to be called should have a positive priority. Negative priorities are reserved for the system for this broadcast; using them may cause problems.</para> <para>Any BroadcastReceiver receiving this Intent  <b>must not</b> abort the broadcast.</para> <para>Emergency calls cannot be intercepted using this mechanism, and other calls cannot be modified to call emergency numbers using this mechanism. </para> <para>Some apps (such as VoIP apps) may want to redirect the outgoing call to use their own service instead. Those apps should first prevent the call from being placed by setting resultData to  <code>null</code> and then start their own app to make the call. </para> <para>You must hold the android.Manifest.permission#PROCESS_OUTGOING_CALLS permission to receive this Intent.</para> <para>This is a protected intent that can only be sent by the system. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_NEW_OUTGOING_CALL
				/// </java-name>
				[Dot42.DexImport("ACTION_NEW_OUTGOING_CALL", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_NEW_OUTGOING_CALL = "android.intent.action.NEW_OUTGOING_CALL";
				/// <summary>
				///  <para>Broadcast Action: Have the device reboot. This is only for use by system code.</para> <para>This is a protected intent that can only be sent by the system. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_REBOOT
				/// </java-name>
				[Dot42.DexImport("ACTION_REBOOT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_REBOOT = "android.intent.action.REBOOT";
				/// <summary>
				///  <para>Broadcast Action: A sticky broadcast for changes in the physical docking state of the device.</para> <para>The intent will have the following extra values:  <ul> <li> <para> <b>EXTRA_DOCK_STATE</b> - the current dock state, indicating which dock the device is physically in. </para></li></ul></para> <para>This is intended for monitoring the current physical dock state. See android.app.UiModeManager for the normal API dealing with dock mode changes. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_DOCK_EVENT
				/// </java-name>
				[Dot42.DexImport("ACTION_DOCK_EVENT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_DOCK_EVENT = "android.intent.action.DOCK_EVENT";
				/// <summary>
				///  <para>Set if the activity should be an option for the default action (center press) to perform on a piece of data. Setting this will hide from the user any activities without it set when performing an action on some data. Note that this is normally -not- set in the Intent when initiating an action  it is for use in intent filters specified in packages. </para>        
				/// </summary>
				/// <java-name>
				/// CATEGORY_DEFAULT
				/// </java-name>
				[Dot42.DexImport("CATEGORY_DEFAULT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string CATEGORY_DEFAULT = "android.intent.category.DEFAULT";
				/// <summary>
				///  <para>Activities that can be safely invoked from a browser must support this category. For example, if the user is viewing a web page or an e-mail and clicks on a link in the text, the Intent generated execute that link will require the BROWSABLE category, so that only activities supporting this category will be considered as possible actions. By supporting this category, you are promising that there is nothing damaging (without user intervention) that can happen by invoking any matching Intent. </para>        
				/// </summary>
				/// <java-name>
				/// CATEGORY_BROWSABLE
				/// </java-name>
				[Dot42.DexImport("CATEGORY_BROWSABLE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string CATEGORY_BROWSABLE = "android.intent.category.BROWSABLE";
				/// <summary>
				///  <para>Set if the activity should be considered as an alternative action to the data the user is currently viewing. See also CATEGORY_SELECTED_ALTERNATIVE for an alternative action that applies to the selection in a list of items.</para> <para>Supporting this category means that you would like your activity to be displayed in the set of alternative things the user can do, usually as part of the current activity's options menu. You will usually want to include a specific label in the &lt;intent-filter&gt; of this action describing to the user what it does.</para> <para>The action of IntentFilter with this category is important in that it describes the specific action the target will perform. This generally should not be a generic action (such as ACTION_VIEW, but rather a specific name such as "com.android.camera.action.CROP. Only one alternative of any particular action will be shown to the user, so using a specific action like this makes sure that your alternative will be displayed while also allowing other applications to provide their own overrides of that particular action. </para>        
				/// </summary>
				/// <java-name>
				/// CATEGORY_ALTERNATIVE
				/// </java-name>
				[Dot42.DexImport("CATEGORY_ALTERNATIVE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string CATEGORY_ALTERNATIVE = "android.intent.category.ALTERNATIVE";
				/// <summary>
				///  <para>Set if the activity should be considered as an alternative selection action to the data the user has currently selected. This is like CATEGORY_ALTERNATIVE, but is used in activities showing a list of items from which the user can select, giving them alternatives to the default action that will be performed on it. </para>        
				/// </summary>
				/// <java-name>
				/// CATEGORY_SELECTED_ALTERNATIVE
				/// </java-name>
				[Dot42.DexImport("CATEGORY_SELECTED_ALTERNATIVE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string CATEGORY_SELECTED_ALTERNATIVE = "android.intent.category.SELECTED_ALTERNATIVE";
				/// <summary>
				///  <para>Intended to be used as a tab inside of a containing TabActivity. </para>        
				/// </summary>
				/// <java-name>
				/// CATEGORY_TAB
				/// </java-name>
				[Dot42.DexImport("CATEGORY_TAB", "Ljava/lang/String;", AccessFlags = 25)]
				public const string CATEGORY_TAB = "android.intent.category.TAB";
				/// <summary>
				///  <para>Should be displayed in the top-level launcher. </para>        
				/// </summary>
				/// <java-name>
				/// CATEGORY_LAUNCHER
				/// </java-name>
				[Dot42.DexImport("CATEGORY_LAUNCHER", "Ljava/lang/String;", AccessFlags = 25)]
				public const string CATEGORY_LAUNCHER = "android.intent.category.LAUNCHER";
				/// <summary>
				///  <para>Provides information about the package it is in; typically used if a package does not contain a CATEGORY_LAUNCHER to provide a front-door to the user without having to be shown in the all apps list. </para>        
				/// </summary>
				/// <java-name>
				/// CATEGORY_INFO
				/// </java-name>
				[Dot42.DexImport("CATEGORY_INFO", "Ljava/lang/String;", AccessFlags = 25)]
				public const string CATEGORY_INFO = "android.intent.category.INFO";
				/// <summary>
				///  <para>This is the home activity, that is the first activity that is displayed when the device boots. </para>        
				/// </summary>
				/// <java-name>
				/// CATEGORY_HOME
				/// </java-name>
				[Dot42.DexImport("CATEGORY_HOME", "Ljava/lang/String;", AccessFlags = 25)]
				public const string CATEGORY_HOME = "android.intent.category.HOME";
				/// <summary>
				///  <para>This activity is a preference panel. </para>        
				/// </summary>
				/// <java-name>
				/// CATEGORY_PREFERENCE
				/// </java-name>
				[Dot42.DexImport("CATEGORY_PREFERENCE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string CATEGORY_PREFERENCE = "android.intent.category.PREFERENCE";
				/// <summary>
				///  <para>This activity is a development preference panel. </para>        
				/// </summary>
				/// <java-name>
				/// CATEGORY_DEVELOPMENT_PREFERENCE
				/// </java-name>
				[Dot42.DexImport("CATEGORY_DEVELOPMENT_PREFERENCE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string CATEGORY_DEVELOPMENT_PREFERENCE = "android.intent.category.DEVELOPMENT_PREFERENCE";
				/// <summary>
				///  <para>Capable of running inside a parent activity container. </para>        
				/// </summary>
				/// <java-name>
				/// CATEGORY_EMBED
				/// </java-name>
				[Dot42.DexImport("CATEGORY_EMBED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string CATEGORY_EMBED = "android.intent.category.EMBED";
				/// <summary>
				///  <para>This activity allows the user to browse and download new applications. </para>        
				/// </summary>
				/// <java-name>
				/// CATEGORY_APP_MARKET
				/// </java-name>
				[Dot42.DexImport("CATEGORY_APP_MARKET", "Ljava/lang/String;", AccessFlags = 25)]
				public const string CATEGORY_APP_MARKET = "android.intent.category.APP_MARKET";
				/// <summary>
				///  <para>This activity may be exercised by the monkey or other automated test tools. </para>        
				/// </summary>
				/// <java-name>
				/// CATEGORY_MONKEY
				/// </java-name>
				[Dot42.DexImport("CATEGORY_MONKEY", "Ljava/lang/String;", AccessFlags = 25)]
				public const string CATEGORY_MONKEY = "android.intent.category.MONKEY";
				/// <summary>
				///  <para>To be used as a test (not part of the normal user experience). </para>        
				/// </summary>
				/// <java-name>
				/// CATEGORY_TEST
				/// </java-name>
				[Dot42.DexImport("CATEGORY_TEST", "Ljava/lang/String;", AccessFlags = 25)]
				public const string CATEGORY_TEST = "android.intent.category.TEST";
				/// <summary>
				///  <para>To be used as a unit test (run through the Test Harness). </para>        
				/// </summary>
				/// <java-name>
				/// CATEGORY_UNIT_TEST
				/// </java-name>
				[Dot42.DexImport("CATEGORY_UNIT_TEST", "Ljava/lang/String;", AccessFlags = 25)]
				public const string CATEGORY_UNIT_TEST = "android.intent.category.UNIT_TEST";
				/// <summary>
				///  <para>To be used as a sample code example (not part of the normal user experience). </para>        
				/// </summary>
				/// <java-name>
				/// CATEGORY_SAMPLE_CODE
				/// </java-name>
				[Dot42.DexImport("CATEGORY_SAMPLE_CODE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string CATEGORY_SAMPLE_CODE = "android.intent.category.SAMPLE_CODE";
				/// <summary>
				///  <para>Used to indicate that an intent only wants URIs that can be opened with ContentResolver#openFileDescriptor(Uri, String). Openable URIs must support at least the columns defined in OpenableColumns when queried.</para> <para> <para>ACTION_GET_CONTENT </para> <para>ACTION_OPEN_DOCUMENT </para> <para>ACTION_CREATE_DOCUMENT </para></para>        
				/// </summary>
				/// <java-name>
				/// CATEGORY_OPENABLE
				/// </java-name>
				[Dot42.DexImport("CATEGORY_OPENABLE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string CATEGORY_OPENABLE = "android.intent.category.OPENABLE";
				/// <summary>
				///  <para>To be used as code under test for framework instrumentation tests. </para>        
				/// </summary>
				/// <java-name>
				/// CATEGORY_FRAMEWORK_INSTRUMENTATION_TEST
				/// </java-name>
				[Dot42.DexImport("CATEGORY_FRAMEWORK_INSTRUMENTATION_TEST", "Ljava/lang/String;", AccessFlags = 25)]
				public const string CATEGORY_FRAMEWORK_INSTRUMENTATION_TEST = "android.intent.category.FRAMEWORK_INSTRUMENTATION_TEST";
				/// <summary>
				///  <para>An activity to run when device is inserted into a car dock. Used with ACTION_MAIN to launch an activity. For more information, see android.app.UiModeManager. </para>        
				/// </summary>
				/// <java-name>
				/// CATEGORY_CAR_DOCK
				/// </java-name>
				[Dot42.DexImport("CATEGORY_CAR_DOCK", "Ljava/lang/String;", AccessFlags = 25)]
				public const string CATEGORY_CAR_DOCK = "android.intent.category.CAR_DOCK";
				/// <summary>
				///  <para>An activity to run when device is inserted into a car dock. Used with ACTION_MAIN to launch an activity. For more information, see android.app.UiModeManager. </para>        
				/// </summary>
				/// <java-name>
				/// CATEGORY_DESK_DOCK
				/// </java-name>
				[Dot42.DexImport("CATEGORY_DESK_DOCK", "Ljava/lang/String;", AccessFlags = 25)]
				public const string CATEGORY_DESK_DOCK = "android.intent.category.DESK_DOCK";
				/// <summary>
				///  <para>An activity to run when device is inserted into a analog (low end) dock. Used with ACTION_MAIN to launch an activity. For more information, see android.app.UiModeManager. </para>        
				/// </summary>
				/// <java-name>
				/// CATEGORY_LE_DESK_DOCK
				/// </java-name>
				[Dot42.DexImport("CATEGORY_LE_DESK_DOCK", "Ljava/lang/String;", AccessFlags = 25)]
				public const string CATEGORY_LE_DESK_DOCK = "android.intent.category.LE_DESK_DOCK";
				/// <summary>
				///  <para>An activity to run when device is inserted into a digital (high end) dock. Used with ACTION_MAIN to launch an activity. For more information, see android.app.UiModeManager. </para>        
				/// </summary>
				/// <java-name>
				/// CATEGORY_HE_DESK_DOCK
				/// </java-name>
				[Dot42.DexImport("CATEGORY_HE_DESK_DOCK", "Ljava/lang/String;", AccessFlags = 25)]
				public const string CATEGORY_HE_DESK_DOCK = "android.intent.category.HE_DESK_DOCK";
				/// <summary>
				///  <para>Used to indicate that the activity can be used in a car environment. </para>        
				/// </summary>
				/// <java-name>
				/// CATEGORY_CAR_MODE
				/// </java-name>
				[Dot42.DexImport("CATEGORY_CAR_MODE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string CATEGORY_CAR_MODE = "android.intent.category.CAR_MODE";
				/// <summary>
				///  <para>The initial data to place in a newly created record. Use with ACTION_INSERT. The data here is a Map containing the same fields as would be given to the underlying ContentProvider.insert() call. </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_TEMPLATE
				/// </java-name>
				[Dot42.DexImport("EXTRA_TEMPLATE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_TEMPLATE = "android.intent.extra.TEMPLATE";
				/// <summary>
				///  <para>A constant CharSequence that is associated with the Intent, used with ACTION_SEND to supply the literal data to be sent. Note that this may be a styled CharSequence, so you must use Bundle.getCharSequence() to retrieve it. </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_TEXT
				/// </java-name>
				[Dot42.DexImport("EXTRA_TEXT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_TEXT = "android.intent.extra.TEXT";
				/// <summary>
				///  <para>A content: URI holding a stream of data associated with the Intent, used with ACTION_SEND to supply the data being sent. </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_STREAM
				/// </java-name>
				[Dot42.DexImport("EXTRA_STREAM", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_STREAM = "android.intent.extra.STREAM";
				/// <summary>
				///  <para>A String[] holding e-mail addresses that should be delivered to. </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_EMAIL
				/// </java-name>
				[Dot42.DexImport("EXTRA_EMAIL", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_EMAIL = "android.intent.extra.EMAIL";
				/// <summary>
				///  <para>A String[] holding e-mail addresses that should be carbon copied. </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_CC
				/// </java-name>
				[Dot42.DexImport("EXTRA_CC", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_CC = "android.intent.extra.CC";
				/// <summary>
				///  <para>A String[] holding e-mail addresses that should be blind carbon copied. </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_BCC
				/// </java-name>
				[Dot42.DexImport("EXTRA_BCC", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_BCC = "android.intent.extra.BCC";
				/// <summary>
				///  <para>A constant string holding the desired subject line of a message. </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_SUBJECT
				/// </java-name>
				[Dot42.DexImport("EXTRA_SUBJECT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_SUBJECT = "android.intent.extra.SUBJECT";
				/// <summary>
				///  <para>An Intent describing the choices you would like shown with ACTION_PICK_ACTIVITY. </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_INTENT
				/// </java-name>
				[Dot42.DexImport("EXTRA_INTENT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_INTENT = "android.intent.extra.INTENT";
				/// <summary>
				///  <para>A CharSequence dialog title to provide to the user when used with a ACTION_CHOOSER. </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_TITLE
				/// </java-name>
				[Dot42.DexImport("EXTRA_TITLE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_TITLE = "android.intent.extra.TITLE";
				/// <summary>
				///  <para>A Parcelable[] of Intent or android.content.pm.LabeledIntent objects as set with putExtra(String, Parcelable[]) of additional activities to place a the front of the list of choices, when shown to the user with a ACTION_CHOOSER. </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_INITIAL_INTENTS
				/// </java-name>
				[Dot42.DexImport("EXTRA_INITIAL_INTENTS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_INITIAL_INTENTS = "android.intent.extra.INITIAL_INTENTS";
				/// <summary>
				///  <para>A android.view.KeyEvent object containing the event that triggered the creation of the Intent it is in. </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_KEY_EVENT
				/// </java-name>
				[Dot42.DexImport("EXTRA_KEY_EVENT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_KEY_EVENT = "android.intent.extra.KEY_EVENT";
				/// <summary>
				///  <para>Used as a boolean extra field in android.content.Intent#ACTION_PACKAGE_REMOVED or android.content.Intent#ACTION_PACKAGE_CHANGED intents to override the default action of restarting the application. </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_DONT_KILL_APP
				/// </java-name>
				[Dot42.DexImport("EXTRA_DONT_KILL_APP", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_DONT_KILL_APP = "android.intent.extra.DONT_KILL_APP";
				/// <summary>
				///  <para>A String holding the phone number originally entered in android.content.Intent#ACTION_NEW_OUTGOING_CALL, or the actual number to call in a android.content.Intent#ACTION_CALL. </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_PHONE_NUMBER
				/// </java-name>
				[Dot42.DexImport("EXTRA_PHONE_NUMBER", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_PHONE_NUMBER = "android.intent.extra.PHONE_NUMBER";
				/// <summary>
				///  <para>Used as an int extra field in android.content.Intent#ACTION_UID_REMOVED intents to supply the uid the package had been assigned. Also an optional extra in android.content.Intent#ACTION_PACKAGE_REMOVED or android.content.Intent#ACTION_PACKAGE_CHANGED for the same purpose. </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_UID
				/// </java-name>
				[Dot42.DexImport("EXTRA_UID", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_UID = "android.intent.extra.UID";
				/// <summary>
				///  <para>Used as a boolean extra field in android.content.Intent#ACTION_PACKAGE_REMOVED intents to indicate whether this represents a full uninstall (removing both the code and its data) or a partial uninstall (leaving its data, implying that this is an update). </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_DATA_REMOVED
				/// </java-name>
				[Dot42.DexImport("EXTRA_DATA_REMOVED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_DATA_REMOVED = "android.intent.extra.DATA_REMOVED";
				/// <summary>
				///  <para>Used as a boolean extra field in android.content.Intent#ACTION_PACKAGE_REMOVED intents to indicate that this is a replacement of the package, so this broadcast will immediately be followed by an add broadcast for a different version of the same package. </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_REPLACING
				/// </java-name>
				[Dot42.DexImport("EXTRA_REPLACING", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_REPLACING = "android.intent.extra.REPLACING";
				/// <summary>
				///  <para>Used as an int extra field in android.app.AlarmManager intents to tell the application being invoked how many pending alarms are being delievered with the intent. For one-shot alarms this will always be 1. For recurring alarms, this might be greater than 1 if the device was asleep or powered off at the time an earlier alarm would have been delivered. </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_ALARM_COUNT
				/// </java-name>
				[Dot42.DexImport("EXTRA_ALARM_COUNT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_ALARM_COUNT = "android.intent.extra.ALARM_COUNT";
				/// <summary>
				///  <para>Used as an int extra field in android.content.Intent#ACTION_DOCK_EVENT intents to request the dock state. Possible values are android.content.Intent#EXTRA_DOCK_STATE_UNDOCKED, android.content.Intent#EXTRA_DOCK_STATE_DESK, or android.content.Intent#EXTRA_DOCK_STATE_CAR, or android.content.Intent#EXTRA_DOCK_STATE_LE_DESK, or android.content.Intent#EXTRA_DOCK_STATE_HE_DESK. </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_DOCK_STATE
				/// </java-name>
				[Dot42.DexImport("EXTRA_DOCK_STATE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_DOCK_STATE = "android.intent.extra.DOCK_STATE";
				/// <summary>
				///  <para>Used as an int value for android.content.Intent#EXTRA_DOCK_STATE to represent that the phone is not in any dock. </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_DOCK_STATE_UNDOCKED
				/// </java-name>
				[Dot42.DexImport("EXTRA_DOCK_STATE_UNDOCKED", "I", AccessFlags = 25)]
				public const int EXTRA_DOCK_STATE_UNDOCKED = 0;
				/// <summary>
				///  <para>Used as an int value for android.content.Intent#EXTRA_DOCK_STATE to represent that the phone is in a desk dock. </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_DOCK_STATE_DESK
				/// </java-name>
				[Dot42.DexImport("EXTRA_DOCK_STATE_DESK", "I", AccessFlags = 25)]
				public const int EXTRA_DOCK_STATE_DESK = 1;
				/// <summary>
				///  <para>Used as an int value for android.content.Intent#EXTRA_DOCK_STATE to represent that the phone is in a car dock. </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_DOCK_STATE_CAR
				/// </java-name>
				[Dot42.DexImport("EXTRA_DOCK_STATE_CAR", "I", AccessFlags = 25)]
				public const int EXTRA_DOCK_STATE_CAR = 2;
				/// <summary>
				///  <para>Used as an int value for android.content.Intent#EXTRA_DOCK_STATE to represent that the phone is in a analog (low end) dock. </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_DOCK_STATE_LE_DESK
				/// </java-name>
				[Dot42.DexImport("EXTRA_DOCK_STATE_LE_DESK", "I", AccessFlags = 25)]
				public const int EXTRA_DOCK_STATE_LE_DESK = 3;
				/// <summary>
				///  <para>Used as an int value for android.content.Intent#EXTRA_DOCK_STATE to represent that the phone is in a digital (high end) dock. </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_DOCK_STATE_HE_DESK
				/// </java-name>
				[Dot42.DexImport("EXTRA_DOCK_STATE_HE_DESK", "I", AccessFlags = 25)]
				public const int EXTRA_DOCK_STATE_HE_DESK = 4;
				/// <summary>
				///  <para>Boolean that can be supplied as meta-data with a dock activity, to indicate that the dock should take over the home key when it is active. </para>        
				/// </summary>
				/// <java-name>
				/// METADATA_DOCK_HOME
				/// </java-name>
				[Dot42.DexImport("METADATA_DOCK_HOME", "Ljava/lang/String;", AccessFlags = 25)]
				public const string METADATA_DOCK_HOME = "android.dock_home";
				/// <summary>
				///  <para>Used in the extra field in the remote intent. It's astring token passed with the remote intent. </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_REMOTE_INTENT_TOKEN
				/// </java-name>
				[Dot42.DexImport("EXTRA_REMOTE_INTENT_TOKEN", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_REMOTE_INTENT_TOKEN = "android.intent.extra.remote_intent_token";
				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>See EXTRA_CHANGED_COMPONENT_NAME_LIST; this field will contain only the first name in the list. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_CHANGED_COMPONENT_NAME
				/// </java-name>
				[Dot42.DexImport("EXTRA_CHANGED_COMPONENT_NAME", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_CHANGED_COMPONENT_NAME = "android.intent.extra.changed_component_name";
				/// <summary>
				///  <para>This field is part of android.content.Intent#ACTION_PACKAGE_CHANGED, and contains a string array of all of the components that have changed. If the state of the overall package has changed, then it will contain an entry with the package name itself. </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_CHANGED_COMPONENT_NAME_LIST
				/// </java-name>
				[Dot42.DexImport("EXTRA_CHANGED_COMPONENT_NAME_LIST", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_CHANGED_COMPONENT_NAME_LIST = "android.intent.extra.changed_component_name_list";
				/// <summary>
				///  <para>This field is part of android.content.Intent#ACTION_EXTERNAL_APPLICATIONS_AVAILABLE, android.content.Intent#ACTION_EXTERNAL_APPLICATIONS_UNAVAILABLE and contains a string array of all of the components that have changed. </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_CHANGED_PACKAGE_LIST
				/// </java-name>
				[Dot42.DexImport("EXTRA_CHANGED_PACKAGE_LIST", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_CHANGED_PACKAGE_LIST = "android.intent.extra.changed_package_list";
				/// <summary>
				///  <para>This field is part of android.content.Intent#ACTION_EXTERNAL_APPLICATIONS_AVAILABLE, android.content.Intent#ACTION_EXTERNAL_APPLICATIONS_UNAVAILABLE and contains an integer array of uids of all of the components that have changed. </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_CHANGED_UID_LIST
				/// </java-name>
				[Dot42.DexImport("EXTRA_CHANGED_UID_LIST", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_CHANGED_UID_LIST = "android.intent.extra.changed_uid_list";
				/// <summary>
				///  <para>Extra used to indicate that an intent should only return data that is on the local device. This is a boolean extra; the default is false. If true, an implementation should only allow the user to select data that is already on the device, not requiring it be downloaded from a remote service when opened.</para> <para> <para>ACTION_GET_CONTENT </para> <para>ACTION_OPEN_DOCUMENT </para> <para>ACTION_CREATE_DOCUMENT </para></para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_LOCAL_ONLY
				/// </java-name>
				[Dot42.DexImport("EXTRA_LOCAL_ONLY", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_LOCAL_ONLY = "android.intent.extra.LOCAL_ONLY";
				/// <summary>
				///  <para>If set, the recipient of this Intent will be granted permission to perform read operations on the URI in the Intent's data and any URIs specified in its ClipData. When applying to an Intent's ClipData, all URIs as well as recursive traversals through data or other ClipData in Intent items will be granted; only the grant flags of the top-level Intent are used. </para>        
				/// </summary>
				/// <java-name>
				/// FLAG_GRANT_READ_URI_PERMISSION
				/// </java-name>
				[Dot42.DexImport("FLAG_GRANT_READ_URI_PERMISSION", "I", AccessFlags = 25)]
				public const int FLAG_GRANT_READ_URI_PERMISSION = 1;
				/// <summary>
				///  <para>If set, the recipient of this Intent will be granted permission to perform write operations on the URI in the Intent's data and any URIs specified in its ClipData. When applying to an Intent's ClipData, all URIs as well as recursive traversals through data or other ClipData in Intent items will be granted; only the grant flags of the top-level Intent are used. </para>        
				/// </summary>
				/// <java-name>
				/// FLAG_GRANT_WRITE_URI_PERMISSION
				/// </java-name>
				[Dot42.DexImport("FLAG_GRANT_WRITE_URI_PERMISSION", "I", AccessFlags = 25)]
				public const int FLAG_GRANT_WRITE_URI_PERMISSION = 2;
				/// <summary>
				///  <para>Can be set by the caller to indicate that this Intent is coming from a background operation, not from direct user interaction. </para>        
				/// </summary>
				/// <java-name>
				/// FLAG_FROM_BACKGROUND
				/// </java-name>
				[Dot42.DexImport("FLAG_FROM_BACKGROUND", "I", AccessFlags = 25)]
				public const int FLAG_FROM_BACKGROUND = 4;
				/// <summary>
				///  <para>A flag you can enable for debugging: when set, log messages will be printed during the resolution of this intent to show you what has been found to create the final resolved list. </para>        
				/// </summary>
				/// <java-name>
				/// FLAG_DEBUG_LOG_RESOLUTION
				/// </java-name>
				[Dot42.DexImport("FLAG_DEBUG_LOG_RESOLUTION", "I", AccessFlags = 25)]
				public const int FLAG_DEBUG_LOG_RESOLUTION = 8;
				/// <summary>
				///  <para>If set, this intent will not match any components in packages that are currently stopped. If this is not set, then the default behavior is to include such applications in the result. </para>        
				/// </summary>
				/// <java-name>
				/// FLAG_EXCLUDE_STOPPED_PACKAGES
				/// </java-name>
				[Dot42.DexImport("FLAG_EXCLUDE_STOPPED_PACKAGES", "I", AccessFlags = 25)]
				public const int FLAG_EXCLUDE_STOPPED_PACKAGES = 16;
				/// <summary>
				///  <para>If set, this intent will always match any components in packages that are currently stopped. This is the default behavior when FLAG_EXCLUDE_STOPPED_PACKAGES is not set. If both of these flags are set, this one wins (it allows overriding of exclude for places where the framework may automatically set the exclude flag). </para>        
				/// </summary>
				/// <java-name>
				/// FLAG_INCLUDE_STOPPED_PACKAGES
				/// </java-name>
				[Dot42.DexImport("FLAG_INCLUDE_STOPPED_PACKAGES", "I", AccessFlags = 25)]
				public const int FLAG_INCLUDE_STOPPED_PACKAGES = 32;
				/// <summary>
				///  <para>If set, the new activity is not kept in the history stack. As soon as the user navigates away from it, the activity is finished. This may also be set with the noHistory attribute. </para>        
				/// </summary>
				/// <java-name>
				/// FLAG_ACTIVITY_NO_HISTORY
				/// </java-name>
				[Dot42.DexImport("FLAG_ACTIVITY_NO_HISTORY", "I", AccessFlags = 25)]
				public const int FLAG_ACTIVITY_NO_HISTORY = 1073741824;
				/// <summary>
				///  <para>If set, the activity will not be launched if it is already running at the top of the history stack. </para>        
				/// </summary>
				/// <java-name>
				/// FLAG_ACTIVITY_SINGLE_TOP
				/// </java-name>
				[Dot42.DexImport("FLAG_ACTIVITY_SINGLE_TOP", "I", AccessFlags = 25)]
				public const int FLAG_ACTIVITY_SINGLE_TOP = 536870912;
				/// <summary>
				///  <para>If set, this activity will become the start of a new task on this history stack. A task (from the activity that started it to the next task activity) defines an atomic group of activities that the user can move to. Tasks can be moved to the foreground and background; all of the activities inside of a particular task always remain in the same order. See  for more information about tasks.</para> <para>This flag is generally used by activities that want to present a "launcher" style behavior: they give the user a list of separate things that can be done, which otherwise run completely independently of the activity launching them.</para> <para>When using this flag, if a task is already running for the activity you are now starting, then a new activity will not be started; instead, the current task will simply be brought to the front of the screen with the state it was last in. See FLAG_ACTIVITY_MULTIPLE_TASK for a flag to disable this behavior.</para> <para>This flag can not be used when the caller is requesting a result from the activity being launched. </para>        
				/// </summary>
				/// <java-name>
				/// FLAG_ACTIVITY_NEW_TASK
				/// </java-name>
				[Dot42.DexImport("FLAG_ACTIVITY_NEW_TASK", "I", AccessFlags = 25)]
				public const int FLAG_ACTIVITY_NEW_TASK = 268435456;
				/// <summary>
				///  <para> <b>Do not use this flag unless you are implementing your own top-level application launcher.</b> Used in conjunction with FLAG_ACTIVITY_NEW_TASK to disable the behavior of bringing an existing task to the foreground. When set, a new task is  <b>always</b> started to host the Activity for the Intent, regardless of whether there is already an existing task running the same thing.</para> <para> <b>Because the default system does not include graphical task management, you should not use this flag unless you provide some way for a user to return back to the tasks you have launched.</b></para> <para>This flag is ignored if FLAG_ACTIVITY_NEW_TASK is not set.</para> <para>See  for more information about tasks. </para>        
				/// </summary>
				/// <java-name>
				/// FLAG_ACTIVITY_MULTIPLE_TASK
				/// </java-name>
				[Dot42.DexImport("FLAG_ACTIVITY_MULTIPLE_TASK", "I", AccessFlags = 25)]
				public const int FLAG_ACTIVITY_MULTIPLE_TASK = 134217728;
				/// <summary>
				///  <para>If set, and the activity being launched is already running in the current task, then instead of launching a new instance of that activity, all of the other activities on top of it will be closed and this Intent will be delivered to the (now on top) old activity as a new Intent.</para> <para>For example, consider a task consisting of the activities: A, B, C, D. If D calls startActivity() with an Intent that resolves to the component of activity B, then C and D will be finished and B receive the given Intent, resulting in the stack now being: A, B.</para> <para>The currently running instance of activity B in the above example will either receive the new intent you are starting here in its onNewIntent() method, or be itself finished and restarted with the new intent. If it has declared its launch mode to be "multiple" (the default) and you have not set FLAG_ACTIVITY_SINGLE_TOP in the same intent, then it will be finished and re-created; for all other launch modes or if FLAG_ACTIVITY_SINGLE_TOP is set then this Intent will be delivered to the current instance's onNewIntent().</para> <para>This launch mode can also be used to good effect in conjunction with FLAG_ACTIVITY_NEW_TASK: if used to start the root activity of a task, it will bring any currently running instance of that task to the foreground, and then clear it to its root state. This is especially useful, for example, when launching an activity from the notification manager.</para> <para>See  for more information about tasks. </para>        
				/// </summary>
				/// <java-name>
				/// FLAG_ACTIVITY_CLEAR_TOP
				/// </java-name>
				[Dot42.DexImport("FLAG_ACTIVITY_CLEAR_TOP", "I", AccessFlags = 25)]
				public const int FLAG_ACTIVITY_CLEAR_TOP = 67108864;
				/// <summary>
				///  <para>If set and this intent is being used to launch a new activity from an existing one, then the reply target of the existing activity will be transfered to the new activity. This way the new activity can call android.app.Activity#setResult and have that result sent back to the reply target of the original activity. </para>        
				/// </summary>
				/// <java-name>
				/// FLAG_ACTIVITY_FORWARD_RESULT
				/// </java-name>
				[Dot42.DexImport("FLAG_ACTIVITY_FORWARD_RESULT", "I", AccessFlags = 25)]
				public const int FLAG_ACTIVITY_FORWARD_RESULT = 33554432;
				/// <summary>
				///  <para>If set and this intent is being used to launch a new activity from an existing one, the current activity will not be counted as the top activity for deciding whether the new intent should be delivered to the top instead of starting a new one. The previous activity will be used as the top, with the assumption being that the current activity will finish itself immediately. </para>        
				/// </summary>
				/// <java-name>
				/// FLAG_ACTIVITY_PREVIOUS_IS_TOP
				/// </java-name>
				[Dot42.DexImport("FLAG_ACTIVITY_PREVIOUS_IS_TOP", "I", AccessFlags = 25)]
				public const int FLAG_ACTIVITY_PREVIOUS_IS_TOP = 16777216;
				/// <summary>
				///  <para>If set, the new activity is not kept in the list of recently launched activities. </para>        
				/// </summary>
				/// <java-name>
				/// FLAG_ACTIVITY_EXCLUDE_FROM_RECENTS
				/// </java-name>
				[Dot42.DexImport("FLAG_ACTIVITY_EXCLUDE_FROM_RECENTS", "I", AccessFlags = 25)]
				public const int FLAG_ACTIVITY_EXCLUDE_FROM_RECENTS = 8388608;
				/// <summary>
				///  <para>This flag is not normally set by application code, but set for you by the system as described in the launchMode documentation for the singleTask mode. </para>        
				/// </summary>
				/// <java-name>
				/// FLAG_ACTIVITY_BROUGHT_TO_FRONT
				/// </java-name>
				[Dot42.DexImport("FLAG_ACTIVITY_BROUGHT_TO_FRONT", "I", AccessFlags = 25)]
				public const int FLAG_ACTIVITY_BROUGHT_TO_FRONT = 4194304;
				/// <summary>
				///  <para>If set, and this activity is either being started in a new task or bringing to the top an existing task, then it will be launched as the front door of the task. This will result in the application of any affinities needed to have that task in the proper state (either moving activities to or from it), or simply resetting that task to its initial state if needed. </para>        
				/// </summary>
				/// <java-name>
				/// FLAG_ACTIVITY_RESET_TASK_IF_NEEDED
				/// </java-name>
				[Dot42.DexImport("FLAG_ACTIVITY_RESET_TASK_IF_NEEDED", "I", AccessFlags = 25)]
				public const int FLAG_ACTIVITY_RESET_TASK_IF_NEEDED = 2097152;
				/// <summary>
				///  <para>This flag is not normally set by application code, but set for you by the system if this activity is being launched from history (longpress home key). </para>        
				/// </summary>
				/// <java-name>
				/// FLAG_ACTIVITY_LAUNCHED_FROM_HISTORY
				/// </java-name>
				[Dot42.DexImport("FLAG_ACTIVITY_LAUNCHED_FROM_HISTORY", "I", AccessFlags = 25)]
				public const int FLAG_ACTIVITY_LAUNCHED_FROM_HISTORY = 1048576;
				/// <summary>
				///  <para>If set, this marks a point in the task's activity stack that should be cleared when the task is reset. That is, the next time the task is brought to the foreground with FLAG_ACTIVITY_RESET_TASK_IF_NEEDED (typically as a result of the user re-launching it from home), this activity and all on top of it will be finished so that the user does not return to them, but instead returns to whatever activity preceeded it.</para> <para>This is useful for cases where you have a logical break in your application. For example, an e-mail application may have a command to view an attachment, which launches an image view activity to display it. This activity should be part of the e-mail application's task, since it is a part of the task the user is involved in. However, if the user leaves that task, and later selects the e-mail app from home, we may like them to return to the conversation they were viewing, not the picture attachment, since that is confusing. By setting this flag when launching the image viewer, that viewer and any activities it starts will be removed the next time the user returns to mail. </para>        
				/// </summary>
				/// <java-name>
				/// FLAG_ACTIVITY_CLEAR_WHEN_TASK_RESET
				/// </java-name>
				[Dot42.DexImport("FLAG_ACTIVITY_CLEAR_WHEN_TASK_RESET", "I", AccessFlags = 25)]
				public const int FLAG_ACTIVITY_CLEAR_WHEN_TASK_RESET = 524288;
				/// <summary>
				///  <para>If set, this flag will prevent the normal android.app.Activity#onUserLeaveHint callback from occurring on the current frontmost activity before it is paused as the newly-started activity is brought to the front.</para> <para>Typically, an activity can rely on that callback to indicate that an explicit user action has caused their activity to be moved out of the foreground. The callback marks an appropriate point in the activity's lifecycle for it to dismiss any notifications that it intends to display "until the user has seen them," such as a blinking LED.</para> <para>If an activity is ever started via any non-user-driven events such as phone-call receipt or an alarm handler, this flag should be passed to Context.startActivity, ensuring that the pausing activity does not think the user has acknowledged its notification. </para>        
				/// </summary>
				/// <java-name>
				/// FLAG_ACTIVITY_NO_USER_ACTION
				/// </java-name>
				[Dot42.DexImport("FLAG_ACTIVITY_NO_USER_ACTION", "I", AccessFlags = 25)]
				public const int FLAG_ACTIVITY_NO_USER_ACTION = 262144;
				/// <summary>
				///  <para>If set in an Intent passed to Context.startActivity(), this flag will cause the launched activity to be brought to the front of its task's history stack if it is already running.</para> <para>For example, consider a task consisting of four activities: A, B, C, D. If D calls startActivity() with an Intent that resolves to the component of activity B, then B will be brought to the front of the history stack, with this resulting order: A, C, D, B.</para> <para>This flag will be ignored if FLAG_ACTIVITY_CLEAR_TOP is also specified. </para>        
				/// </summary>
				/// <java-name>
				/// FLAG_ACTIVITY_REORDER_TO_FRONT
				/// </java-name>
				[Dot42.DexImport("FLAG_ACTIVITY_REORDER_TO_FRONT", "I", AccessFlags = 25)]
				public const int FLAG_ACTIVITY_REORDER_TO_FRONT = 131072;
				/// <summary>
				///  <para>If set in an Intent passed to Context.startActivity(), this flag will prevent the system from applying an activity transition animation to go to the next activity state. This doesn't mean an animation will never run  if another activity change happens that doesn't specify this flag before the activity started here is displayed, then that transition will be used. This flag can be put to good use when you are going to do a series of activity operations but the animation seen by the user shouldn't be driven by the first activity change but rather a later one. </para>        
				/// </summary>
				/// <java-name>
				/// FLAG_ACTIVITY_NO_ANIMATION
				/// </java-name>
				[Dot42.DexImport("FLAG_ACTIVITY_NO_ANIMATION", "I", AccessFlags = 25)]
				public const int FLAG_ACTIVITY_NO_ANIMATION = 65536;
				/// <summary>
				///  <para>If set in an Intent passed to Context.startActivity(), this flag will cause any existing task that would be associated with the activity to be cleared before the activity is started. That is, the activity becomes the new root of an otherwise empty task, and any old activities are finished. This can only be used in conjunction with FLAG_ACTIVITY_NEW_TASK. </para>        
				/// </summary>
				/// <java-name>
				/// FLAG_ACTIVITY_CLEAR_TASK
				/// </java-name>
				[Dot42.DexImport("FLAG_ACTIVITY_CLEAR_TASK", "I", AccessFlags = 25)]
				public const int FLAG_ACTIVITY_CLEAR_TASK = 32768;
				/// <summary>
				///  <para>If set in an Intent passed to Context.startActivity(), this flag will cause a newly launching task to be placed on top of the current home activity task (if there is one). That is, pressing back from the task will always return the user to home even if that was not the last activity they saw. This can only be used in conjunction with FLAG_ACTIVITY_NEW_TASK. </para>        
				/// </summary>
				/// <java-name>
				/// FLAG_ACTIVITY_TASK_ON_HOME
				/// </java-name>
				[Dot42.DexImport("FLAG_ACTIVITY_TASK_ON_HOME", "I", AccessFlags = 25)]
				public const int FLAG_ACTIVITY_TASK_ON_HOME = 16384;
				/// <summary>
				///  <para>If set, when sending a broadcast only registered receivers will be called  no BroadcastReceiver components will be launched. </para>        
				/// </summary>
				/// <java-name>
				/// FLAG_RECEIVER_REGISTERED_ONLY
				/// </java-name>
				[Dot42.DexImport("FLAG_RECEIVER_REGISTERED_ONLY", "I", AccessFlags = 25)]
				public const int FLAG_RECEIVER_REGISTERED_ONLY = 1073741824;
				/// <summary>
				///  <para>If set, when sending a broadcast the new broadcast will replace any existing pending broadcast that matches it. Matching is defined by Intent.filterEquals returning true for the intents of the two broadcasts. When a match is found, the new broadcast (and receivers associated with it) will replace the existing one in the pending broadcast list, remaining at the same position in the list.</para> <para>This flag is most typically used with sticky broadcasts, which only care about delivering the most recent values of the broadcast to their receivers. </para>        
				/// </summary>
				/// <java-name>
				/// FLAG_RECEIVER_REPLACE_PENDING
				/// </java-name>
				[Dot42.DexImport("FLAG_RECEIVER_REPLACE_PENDING", "I", AccessFlags = 25)]
				public const int FLAG_RECEIVER_REPLACE_PENDING = 536870912;
				/// <summary>
				///  <para>Flag for use with toUri and parseUri: the URI string always has the "intent:" scheme. This syntax can be used when you want to later disambiguate between URIs that are intended to describe an Intent vs. all others that should be treated as raw URIs. When used with parseUri, any other scheme will result in a generic VIEW action for that raw URI. </para>        
				/// </summary>
				/// <java-name>
				/// URI_INTENT_SCHEME
				/// </java-name>
				[Dot42.DexImport("URI_INTENT_SCHEME", "I", AccessFlags = 25)]
				public const int URI_INTENT_SCHEME = 1;
				/// <summary>
				///  <para>Use with fillIn to allow the current action value to be overwritten, even if it is already set. </para>        
				/// </summary>
				/// <java-name>
				/// FILL_IN_ACTION
				/// </java-name>
				[Dot42.DexImport("FILL_IN_ACTION", "I", AccessFlags = 25)]
				public const int FILL_IN_ACTION = 1;
				/// <summary>
				///  <para>Use with fillIn to allow the current data or type value overwritten, even if it is already set. </para>        
				/// </summary>
				/// <java-name>
				/// FILL_IN_DATA
				/// </java-name>
				[Dot42.DexImport("FILL_IN_DATA", "I", AccessFlags = 25)]
				public const int FILL_IN_DATA = 2;
				/// <summary>
				///  <para>Use with fillIn to allow the current categories to be overwritten, even if they are already set. </para>        
				/// </summary>
				/// <java-name>
				/// FILL_IN_CATEGORIES
				/// </java-name>
				[Dot42.DexImport("FILL_IN_CATEGORIES", "I", AccessFlags = 25)]
				public const int FILL_IN_CATEGORIES = 4;
				/// <summary>
				///  <para>Use with fillIn to allow the current component value to be overwritten, even if it is already set. </para>        
				/// </summary>
				/// <java-name>
				/// FILL_IN_COMPONENT
				/// </java-name>
				[Dot42.DexImport("FILL_IN_COMPONENT", "I", AccessFlags = 25)]
				public const int FILL_IN_COMPONENT = 8;
				/// <summary>
				///  <para>Use with fillIn to allow the current package value to be overwritten, even if it is already set. </para>        
				/// </summary>
				/// <java-name>
				/// FILL_IN_PACKAGE
				/// </java-name>
				[Dot42.DexImport("FILL_IN_PACKAGE", "I", AccessFlags = 25)]
				public const int FILL_IN_PACKAGE = 16;
				/// <summary>
				///  <para>Use with fillIn to allow the current bounds rectangle to be overwritten, even if it is already set. </para>        
				/// </summary>
				/// <java-name>
				/// FILL_IN_SOURCE_BOUNDS
				/// </java-name>
				[Dot42.DexImport("FILL_IN_SOURCE_BOUNDS", "I", AccessFlags = 25)]
				public const int FILL_IN_SOURCE_BOUNDS = 32;
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.Content.Intent> CREATOR;
				/// <summary>
				///  <para>Create an empty intent. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Intent() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Copy constructor. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Intent;)V", AccessFlags = 1)]
				public Intent(global::Android.Content.Intent o) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Copy constructor. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public Intent(string o) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Landroid/net/Uri;)V", AccessFlags = 1)]
				public Intent(string @string, global::Android.Net.Uri uri) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Ljava/lang/Class;)V", AccessFlags = 1, Signature = "(Landroid/content/Context;Ljava/lang/Class<*>;)V")]
				public Intent(global::Android.Content.Context context, global::System.Type type) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Create an intent for a specific component with a specified action and data. This is equivalent using Intent(String, android.net.Uri) to construct the Intent and then calling setClass to set its class.</para> <para> <b>Note: scheme and host name matching in the Android framework is case-sensitive, unlike the formal RFC. As a result, you should always ensure that you write your Uri with these elements using lower case letters, and normalize any Uris you receive from outside of Android to ensure the scheme and host is lower case.</b></para> <para> <para>Intent(String, android.net.Uri) </para> <para>#Intent(Context, Class) </para> <para>setClass </para> <para>setComponent </para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Landroid/net/Uri;Landroid/content/Context;Ljava/lang/Class;)V", AccessFlags = 1, Signature = "(Ljava/lang/String;Landroid/net/Uri;Landroid/content/Context;Ljava/lang/Class<*>;" +
    ")V")]
				public Intent(string action, global::Android.Net.Uri uri, global::Android.Content.Context packageContext, global::System.Type cls) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Convenience function for creating a ACTION_CHOOSER Intent.</para> <para>Builds a new ACTION_CHOOSER Intent that wraps the given target intent, also optionally supplying a title. If the target intent has specified FLAG_GRANT_READ_URI_PERMISSION or FLAG_GRANT_WRITE_URI_PERMISSION, then these flags will also be set in the returned chooser intent, with its ClipData set appropriately: either a direct reflection of getClipData() if that is non-null, or a new ClipData build from getData().</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Return a new Intent object that you can hand to Context.startActivity() and related methods. </para>
				/// </returns>
				/// <java-name>
				/// createChooser
				/// </java-name>
				[Dot42.DexImport("createChooser", "(Landroid/content/Intent;Ljava/lang/CharSequence;)Landroid/content/Intent;", AccessFlags = 9)]
				public static global::Android.Content.Intent CreateChooser(global::Android.Content.Intent target, global::Java.Lang.ICharSequence title) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Intent);
				}

				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/lang/Object;", AccessFlags = 1)]
				public virtual object Clone() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <summary>
				///  <para>Make a clone of only the parts of the Intent that are relevant for filter matching: the action, data, type, component, and categories. </para>        
				/// </summary>
				/// <java-name>
				/// cloneFilter
				/// </java-name>
				[Dot42.DexImport("cloneFilter", "()Landroid/content/Intent;", AccessFlags = 1)]
				public virtual global::Android.Content.Intent CloneFilter() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Intent);
				}

				/// <summary>
				///  <para>Create an intent to launch the main (root) activity of a task. This is the Intent that is started when the application's is launched from Home. For anything else that wants to launch an application in the same way, it is important that they use an Intent structured the same way, and can use this function to ensure this is the case.</para> <para>The returned Intent has the given Activity component as its explicit component, ACTION_MAIN as its action, and includes the category CATEGORY_LAUNCHER. This does  <b>not</b> have FLAG_ACTIVITY_NEW_TASK set, though typically you will want to do that through addFlags(int) on the returned Intent.</para> <para> <para>setClass </para> <para>setComponent </para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns a newly created Intent that can be used to launch the activity as a main application entry.</para>
				/// </returns>
				/// <java-name>
				/// makeMainActivity
				/// </java-name>
				[Dot42.DexImport("makeMainActivity", "(Landroid/content/ComponentName;)Landroid/content/Intent;", AccessFlags = 9)]
				public static global::Android.Content.Intent MakeMainActivity(global::Android.Content.ComponentName mainActivity) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Intent);
				}

				/// <summary>
				///  <para>Make an Intent that can be used to re-launch an application's task in its base state. This is like makeMainActivity(ComponentName), but also sets the flags FLAG_ACTIVITY_NEW_TASK and FLAG_ACTIVITY_CLEAR_TASK.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns a newly created Intent that can be used to relaunch the activity's task in its root state. </para>
				/// </returns>
				/// <java-name>
				/// makeRestartActivityTask
				/// </java-name>
				[Dot42.DexImport("makeRestartActivityTask", "(Landroid/content/ComponentName;)Landroid/content/Intent;", AccessFlags = 9)]
				public static global::Android.Content.Intent MakeRestartActivityTask(global::Android.Content.ComponentName mainActivity) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Intent);
				}

				/// <summary>
				///  <para>Call parseUri with 0 flags.  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use parseUri instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// getIntent
				/// </java-name>
				[Dot42.DexImport("getIntent", "(Ljava/lang/String;)Landroid/content/Intent;", AccessFlags = 9)]
				public static global::Android.Content.Intent GetIntent(string uri) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Intent);
				}

				/// <summary>
				///  <para>Create an intent from a URI. This URI may encode the action, category, and other intent fields, if it was returned by toUri. If the Intent was not generate by toUri(), its data will be the entire URI and its action will be ACTION_VIEW.</para> <para>The URI given here must not be relative  that is, it must include the scheme and full path.</para> <para> <para>toUri </para></para>        
				/// </summary>
				/// <returns>
				///  <para>Intent The newly created Intent object.</para>
				/// </returns>
				/// <java-name>
				/// parseUri
				/// </java-name>
				[Dot42.DexImport("parseUri", "(Ljava/lang/String;I)Landroid/content/Intent;", AccessFlags = 9)]
				public static global::Android.Content.Intent ParseUri(string uri, int flags) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Intent);
				}

				/// <java-name>
				/// getIntentOld
				/// </java-name>
				[Dot42.DexImport("getIntentOld", "(Ljava/lang/String;)Landroid/content/Intent;", AccessFlags = 9)]
				public static global::Android.Content.Intent GetIntentOld(string uri) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Intent);
				}

				/// <summary>
				///  <para>Return the MIME data type of this intent. If the type field is explicitly set, that is simply returned. Otherwise, if the data is set, the type of that data is returned. If neither fields are set, a null is returned.</para> <para> <para>getType </para> <para>resolveType(ContentResolver) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>The MIME type of this intent.</para>
				/// </returns>
				/// <java-name>
				/// resolveType
				/// </java-name>
				[Dot42.DexImport("resolveType", "(Landroid/content/Context;)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string ResolveType(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Return the MIME data type of this intent. If the type field is explicitly set, that is simply returned. Otherwise, if the data is set, the type of that data is returned. If neither fields are set, a null is returned.</para> <para> <para>getType </para> <para>resolveType(ContentResolver) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>The MIME type of this intent.</para>
				/// </returns>
				/// <java-name>
				/// resolveType
				/// </java-name>
				[Dot42.DexImport("resolveType", "(Landroid/content/ContentResolver;)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string ResolveType(global::Android.Content.ContentResolver context) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Return the MIME data type of this intent, only if it will be needed for intent resolution. This is not generally useful for application code; it is used by the frameworks for communicating with back-end system services.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The MIME type of this intent, or null if it is unknown or not needed. </para>
				/// </returns>
				/// <java-name>
				/// resolveTypeIfNeeded
				/// </java-name>
				[Dot42.DexImport("resolveTypeIfNeeded", "(Landroid/content/ContentResolver;)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string ResolveTypeIfNeeded(global::Android.Content.ContentResolver resolver) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Check if a category exists in the intent.</para> <para> <para>getCategories </para> <para>addCategory </para></para>        
				/// </summary>
				/// <returns>
				///  <para>boolean True if the intent contains the category, else false.</para>
				/// </returns>
				/// <java-name>
				/// hasCategory
				/// </java-name>
				[Dot42.DexImport("hasCategory", "(Ljava/lang/String;)Z", AccessFlags = 1)]
				public virtual bool HasCategory(string category) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Sets the ClassLoader that will be used when unmarshalling any Parcelable values from the extras of this Intent.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setExtrasClassLoader
				/// </java-name>
				[Dot42.DexImport("setExtrasClassLoader", "(Ljava/lang/ClassLoader;)V", AccessFlags = 1)]
				public virtual void SetExtrasClassLoader(global::Java.Lang.ClassLoader loader) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns true if an extra value is associated with the given name. </para>        
				/// </summary>
				/// <returns>
				///  <para>true if the given extra is present. </para>
				/// </returns>
				/// <java-name>
				/// hasExtra
				/// </java-name>
				[Dot42.DexImport("hasExtra", "(Ljava/lang/String;)Z", AccessFlags = 1)]
				public virtual bool HasExtra(string name) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Retrieve extended data from the intent.</para> <para> <para>putExtra(String, boolean) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the value of an item that previously added with putExtra() or the default value if none was found.</para>
				/// </returns>
				/// <java-name>
				/// getBooleanExtra
				/// </java-name>
				[Dot42.DexImport("getBooleanExtra", "(Ljava/lang/String;Z)Z", AccessFlags = 1)]
				public virtual bool GetBooleanExtra(string name, bool defaultValue) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Retrieve extended data from the intent.</para> <para> <para>putExtra(String, byte) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the value of an item that previously added with putExtra() or the default value if none was found.</para>
				/// </returns>
				/// <java-name>
				/// getByteExtra
				/// </java-name>
				[Dot42.DexImport("getByteExtra", "(Ljava/lang/String;B)B", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual sbyte GetByteExtra(string name, sbyte defaultValue) /* MethodBuilder.Create */ 
				{
						return default(sbyte);
				}

				/// <summary>
				///  <para>Retrieve extended data from the intent.</para> <para> <para>putExtra(String, byte) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the value of an item that previously added with putExtra() or the default value if none was found.</para>
				/// </returns>
				/// <java-name>
				/// getByteExtra
				/// </java-name>
				[Dot42.DexImport("getByteExtra", "(Ljava/lang/String;B)B", AccessFlags = 1)]
				public virtual byte GetByteExtra(string name, byte defaultValue) /* MethodBuilder.Create */ 
				{
						return default(byte);
				}

				/// <summary>
				///  <para>Retrieve extended data from the intent.</para> <para> <para>putExtra(String, short) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the value of an item that previously added with putExtra() or the default value if none was found.</para>
				/// </returns>
				/// <java-name>
				/// getShortExtra
				/// </java-name>
				[Dot42.DexImport("getShortExtra", "(Ljava/lang/String;S)S", AccessFlags = 1)]
				public virtual short GetShortExtra(string name, short defaultValue) /* MethodBuilder.Create */ 
				{
						return default(short);
				}

				/// <summary>
				///  <para>Retrieve extended data from the intent.</para> <para> <para>putExtra(String, char) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the value of an item that previously added with putExtra() or the default value if none was found.</para>
				/// </returns>
				/// <java-name>
				/// getCharExtra
				/// </java-name>
				[Dot42.DexImport("getCharExtra", "(Ljava/lang/String;C)C", AccessFlags = 1)]
				public virtual char GetCharExtra(string name, char defaultValue) /* MethodBuilder.Create */ 
				{
						return default(char);
				}

				/// <summary>
				///  <para>Retrieve extended data from the intent.</para> <para> <para>putExtra(String, int) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the value of an item that previously added with putExtra() or the default value if none was found.</para>
				/// </returns>
				/// <java-name>
				/// getIntExtra
				/// </java-name>
				[Dot42.DexImport("getIntExtra", "(Ljava/lang/String;I)I", AccessFlags = 1)]
				public virtual int GetIntExtra(string name, int defaultValue) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Retrieve extended data from the intent.</para> <para> <para>putExtra(String, long) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the value of an item that previously added with putExtra() or the default value if none was found.</para>
				/// </returns>
				/// <java-name>
				/// getLongExtra
				/// </java-name>
				[Dot42.DexImport("getLongExtra", "(Ljava/lang/String;J)J", AccessFlags = 1)]
				public virtual long GetLongExtra(string name, long defaultValue) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				///  <para>Retrieve extended data from the intent.</para> <para> <para>putExtra(String, float) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the value of an item that previously added with putExtra(), or the default value if no such item is present</para>
				/// </returns>
				/// <java-name>
				/// getFloatExtra
				/// </java-name>
				[Dot42.DexImport("getFloatExtra", "(Ljava/lang/String;F)F", AccessFlags = 1)]
				public virtual float GetFloatExtra(string name, float defaultValue) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				///  <para>Retrieve extended data from the intent.</para> <para> <para>putExtra(String, double) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the value of an item that previously added with putExtra() or the default value if none was found.</para>
				/// </returns>
				/// <java-name>
				/// getDoubleExtra
				/// </java-name>
				[Dot42.DexImport("getDoubleExtra", "(Ljava/lang/String;D)D", AccessFlags = 1)]
				public virtual double GetDoubleExtra(string name, double defaultValue) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <summary>
				///  <para>Retrieve extended data from the intent.</para> <para> <para>putExtra(String, String) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the value of an item that previously added with putExtra() or null if no String value was found.</para>
				/// </returns>
				/// <java-name>
				/// getStringExtra
				/// </java-name>
				[Dot42.DexImport("getStringExtra", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetStringExtra(string name) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Retrieve extended data from the intent.</para> <para> <para>putExtra(String, CharSequence) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the value of an item that previously added with putExtra() or null if no CharSequence value was found.</para>
				/// </returns>
				/// <java-name>
				/// getCharSequenceExtra
				/// </java-name>
				[Dot42.DexImport("getCharSequenceExtra", "(Ljava/lang/String;)Ljava/lang/CharSequence;", AccessFlags = 1)]
				public virtual global::Java.Lang.ICharSequence GetCharSequenceExtra(string name) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <summary>
				///  <para>Retrieve extended data from the intent.</para> <para> <para>putExtra(String, Parcelable) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the value of an item that previously added with putExtra() or null if no Parcelable value was found.</para>
				/// </returns>
				/// <java-name>
				/// getParcelableExtra
				/// </java-name>
				[Dot42.DexImport("getParcelableExtra", "(Ljava/lang/String;)Landroid/os/Parcelable;", AccessFlags = 1, Signature = "<T::Landroid/os/Parcelable;>(Ljava/lang/String;)TT;")]
				public virtual T GetParcelableExtra<T>(string name) /* MethodBuilder.Create */ 
				{
						return default(T);
				}

				/// <summary>
				///  <para>Retrieve extended data from the intent.</para> <para> <para>putExtra(String, Parcelable[]) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the value of an item that previously added with putExtra() or null if no Parcelable[] value was found.</para>
				/// </returns>
				/// <java-name>
				/// getParcelableArrayExtra
				/// </java-name>
				[Dot42.DexImport("getParcelableArrayExtra", "(Ljava/lang/String;)[Landroid/os/Parcelable;", AccessFlags = 1)]
				public virtual global::Android.OS.IParcelable[] GetParcelableArrayExtra(string name) /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.IParcelable[]);
				}

				/// <summary>
				///  <para>Retrieve extended data from the intent.</para> <para> <para>#putParcelableArrayListExtra(String, ArrayList) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the value of an item that previously added with putExtra() or null if no ArrayList&lt;Parcelable&gt; value was found.</para>
				/// </returns>
				/// <java-name>
				/// getParcelableArrayListExtra
				/// </java-name>
				[Dot42.DexImport("getParcelableArrayListExtra", "(Ljava/lang/String;)Ljava/util/ArrayList;", AccessFlags = 1, Signature = "<T::Landroid/os/Parcelable;>(Ljava/lang/String;)Ljava/util/ArrayList<TT;>;")]
				public virtual global::Java.Util.ArrayList<T> GetParcelableArrayListExtra<T>(string name) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ArrayList<T>);
				}

				/// <summary>
				///  <para>Retrieve extended data from the intent.</para> <para> <para>putExtra(String, Serializable) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the value of an item that previously added with putExtra() or null if no Serializable value was found.</para>
				/// </returns>
				/// <java-name>
				/// getSerializableExtra
				/// </java-name>
				[Dot42.DexImport("getSerializableExtra", "(Ljava/lang/String;)Ljava/io/Serializable;", AccessFlags = 1)]
				public virtual global::Java.IO.ISerializable GetSerializableExtra(string name) /* MethodBuilder.Create */ 
				{
						return default(global::Java.IO.ISerializable);
				}

				/// <summary>
				///  <para>Retrieve extended data from the intent.</para> <para> <para>#putIntegerArrayListExtra(String, ArrayList) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the value of an item that previously added with putExtra() or null if no ArrayList&lt;Integer&gt; value was found.</para>
				/// </returns>
				/// <java-name>
				/// getIntegerArrayListExtra
				/// </java-name>
				[Dot42.DexImport("getIntegerArrayListExtra", "(Ljava/lang/String;)Ljava/util/ArrayList;", AccessFlags = 1, Signature = "(Ljava/lang/String;)Ljava/util/ArrayList<Ljava/lang/Integer;>;")]
				public virtual global::Java.Util.ArrayList<int?> GetIntegerArrayListExtra(string name) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ArrayList<int?>);
				}

				/// <summary>
				///  <para>Retrieve extended data from the intent.</para> <para> <para>#putStringArrayListExtra(String, ArrayList) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the value of an item that previously added with putExtra() or null if no ArrayList&lt;String&gt; value was found.</para>
				/// </returns>
				/// <java-name>
				/// getStringArrayListExtra
				/// </java-name>
				[Dot42.DexImport("getStringArrayListExtra", "(Ljava/lang/String;)Ljava/util/ArrayList;", AccessFlags = 1, Signature = "(Ljava/lang/String;)Ljava/util/ArrayList<Ljava/lang/String;>;")]
				public virtual global::Java.Util.ArrayList<string> GetStringArrayListExtra(string name) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ArrayList<string>);
				}

				/// <summary>
				///  <para>Retrieve extended data from the intent.</para> <para> <para>#putCharSequenceArrayListExtra(String, ArrayList) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the value of an item that previously added with putExtra() or null if no ArrayList&lt;CharSequence&gt; value was found.</para>
				/// </returns>
				/// <java-name>
				/// getCharSequenceArrayListExtra
				/// </java-name>
				[Dot42.DexImport("getCharSequenceArrayListExtra", "(Ljava/lang/String;)Ljava/util/ArrayList;", AccessFlags = 1, Signature = "(Ljava/lang/String;)Ljava/util/ArrayList<Ljava/lang/CharSequence;>;")]
				public virtual global::Java.Util.ArrayList<global::Java.Lang.ICharSequence> GetCharSequenceArrayListExtra(string name) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ArrayList<global::Java.Lang.ICharSequence>);
				}

				/// <summary>
				///  <para>Retrieve extended data from the intent.</para> <para> <para>putExtra(String, boolean[]) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the value of an item that previously added with putExtra() or null if no boolean array value was found.</para>
				/// </returns>
				/// <java-name>
				/// getBooleanArrayExtra
				/// </java-name>
				[Dot42.DexImport("getBooleanArrayExtra", "(Ljava/lang/String;)[Z", AccessFlags = 1)]
				public virtual bool[] GetBooleanArrayExtra(string name) /* MethodBuilder.Create */ 
				{
						return default(bool[]);
				}

				/// <summary>
				///  <para>Retrieve extended data from the intent.</para> <para> <para>putExtra(String, byte[]) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the value of an item that previously added with putExtra() or null if no byte array value was found.</para>
				/// </returns>
				/// <java-name>
				/// getByteArrayExtra
				/// </java-name>
				[Dot42.DexImport("getByteArrayExtra", "(Ljava/lang/String;)[B", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual sbyte[] JavaGetByteArrayExtra(string name) /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <summary>
				///  <para>Retrieve extended data from the intent.</para> <para> <para>putExtra(String, byte[]) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the value of an item that previously added with putExtra() or null if no byte array value was found.</para>
				/// </returns>
				/// <java-name>
				/// getByteArrayExtra
				/// </java-name>
				[Dot42.DexImport("getByteArrayExtra", "(Ljava/lang/String;)[B", AccessFlags = 1)]
				public virtual byte[] GetByteArrayExtra(string name) /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				/// <summary>
				///  <para>Retrieve extended data from the intent.</para> <para> <para>putExtra(String, short[]) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the value of an item that previously added with putExtra() or null if no short array value was found.</para>
				/// </returns>
				/// <java-name>
				/// getShortArrayExtra
				/// </java-name>
				[Dot42.DexImport("getShortArrayExtra", "(Ljava/lang/String;)[S", AccessFlags = 1)]
				public virtual short[] GetShortArrayExtra(string name) /* MethodBuilder.Create */ 
				{
						return default(short[]);
				}

				/// <summary>
				///  <para>Retrieve extended data from the intent.</para> <para> <para>putExtra(String, char[]) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the value of an item that previously added with putExtra() or null if no char array value was found.</para>
				/// </returns>
				/// <java-name>
				/// getCharArrayExtra
				/// </java-name>
				[Dot42.DexImport("getCharArrayExtra", "(Ljava/lang/String;)[C", AccessFlags = 1)]
				public virtual char[] GetCharArrayExtra(string name) /* MethodBuilder.Create */ 
				{
						return default(char[]);
				}

				/// <summary>
				///  <para>Retrieve extended data from the intent.</para> <para> <para>putExtra(String, int[]) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the value of an item that previously added with putExtra() or null if no int array value was found.</para>
				/// </returns>
				/// <java-name>
				/// getIntArrayExtra
				/// </java-name>
				[Dot42.DexImport("getIntArrayExtra", "(Ljava/lang/String;)[I", AccessFlags = 1)]
				public virtual int[] GetIntArrayExtra(string name) /* MethodBuilder.Create */ 
				{
						return default(int[]);
				}

				/// <summary>
				///  <para>Retrieve extended data from the intent.</para> <para> <para>putExtra(String, long[]) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the value of an item that previously added with putExtra() or null if no long array value was found.</para>
				/// </returns>
				/// <java-name>
				/// getLongArrayExtra
				/// </java-name>
				[Dot42.DexImport("getLongArrayExtra", "(Ljava/lang/String;)[J", AccessFlags = 1)]
				public virtual long[] GetLongArrayExtra(string name) /* MethodBuilder.Create */ 
				{
						return default(long[]);
				}

				/// <summary>
				///  <para>Retrieve extended data from the intent.</para> <para> <para>putExtra(String, float[]) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the value of an item that previously added with putExtra() or null if no float array value was found.</para>
				/// </returns>
				/// <java-name>
				/// getFloatArrayExtra
				/// </java-name>
				[Dot42.DexImport("getFloatArrayExtra", "(Ljava/lang/String;)[F", AccessFlags = 1)]
				public virtual float[] GetFloatArrayExtra(string name) /* MethodBuilder.Create */ 
				{
						return default(float[]);
				}

				/// <summary>
				///  <para>Retrieve extended data from the intent.</para> <para> <para>putExtra(String, double[]) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the value of an item that previously added with putExtra() or null if no double array value was found.</para>
				/// </returns>
				/// <java-name>
				/// getDoubleArrayExtra
				/// </java-name>
				[Dot42.DexImport("getDoubleArrayExtra", "(Ljava/lang/String;)[D", AccessFlags = 1)]
				public virtual double[] GetDoubleArrayExtra(string name) /* MethodBuilder.Create */ 
				{
						return default(double[]);
				}

				/// <summary>
				///  <para>Retrieve extended data from the intent.</para> <para> <para>putExtra(String, String[]) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the value of an item that previously added with putExtra() or null if no String array value was found.</para>
				/// </returns>
				/// <java-name>
				/// getStringArrayExtra
				/// </java-name>
				[Dot42.DexImport("getStringArrayExtra", "(Ljava/lang/String;)[Ljava/lang/String;", AccessFlags = 1)]
				public virtual string[] GetStringArrayExtra(string name) /* MethodBuilder.Create */ 
				{
						return default(string[]);
				}

				/// <summary>
				///  <para>Retrieve extended data from the intent.</para> <para> <para>putExtra(String, CharSequence[]) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the value of an item that previously added with putExtra() or null if no CharSequence array value was found.</para>
				/// </returns>
				/// <java-name>
				/// getCharSequenceArrayExtra
				/// </java-name>
				[Dot42.DexImport("getCharSequenceArrayExtra", "(Ljava/lang/String;)[Ljava/lang/CharSequence;", AccessFlags = 1)]
				public virtual global::Java.Lang.ICharSequence[] GetCharSequenceArrayExtra(string name) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence[]);
				}

				/// <summary>
				///  <para>Retrieve extended data from the intent.</para> <para> <para>putExtra(String, Bundle) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the value of an item that previously added with putExtra() or null if no Bundle value was found.</para>
				/// </returns>
				/// <java-name>
				/// getBundleExtra
				/// </java-name>
				[Dot42.DexImport("getBundleExtra", "(Ljava/lang/String;)Landroid/os/Bundle;", AccessFlags = 1)]
				public virtual global::Android.OS.Bundle GetBundleExtra(string name) /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.Bundle);
				}

				/// <summary>
				///  <para>Return the Activity component that should be used to handle this intent. The appropriate component is determined based on the information in the intent, evaluated as follows:</para> <para>If getComponent returns an explicit class, that is returned without any further consideration.</para> <para>The activity must handle the Intent#CATEGORY_DEFAULT Intent category to be considered.</para> <para>If getAction is non-NULL, the activity must handle this action.</para> <para>If resolveType returns non-NULL, the activity must handle this type.</para> <para>If addCategory has added any categories, the activity must handle ALL of the categories specified.</para> <para>If getPackage is non-NULL, only activity components in that application package will be considered.</para> <para>If there are no activities that satisfy all of these conditions, a null string is returned.</para> <para>If multiple activities are found to satisfy the intent, the one with the highest priority will be used. If there are multiple activities with the same priority, the system will either pick the best activity based on user preference, or resolve to a system class that will allow the user to pick an activity and forward from there.</para> <para>This method is implemented simply by calling PackageManager#resolveActivity with the "defaultOnly" parameter true.</para> <para>This API is called for you as part of starting an activity from an intent. You do not normally need to call it yourself.</para> <para> <para>setComponent </para> <para>getComponent </para> <para>resolveActivityInfo </para></para>        
				/// </summary>
				/// <returns>
				///  <para>Name of the component implementing an activity that can display the intent.</para>
				/// </returns>
				/// <java-name>
				/// resolveActivity
				/// </java-name>
				[Dot42.DexImport("resolveActivity", "(Landroid/content/pm/PackageManager;)Landroid/content/ComponentName;", AccessFlags = 1)]
				public virtual global::Android.Content.ComponentName ResolveActivity(global::Android.Content.PM.PackageManager pm) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.ComponentName);
				}

				/// <summary>
				///  <para>Resolve the Intent into an ActivityInfo describing the activity that should execute the intent. Resolution follows the same rules as described for resolveActivity, but you get back the completely information about the resolved activity instead of just its class name.</para> <para> <para>resolveActivity </para></para>        
				/// </summary>
				/// <returns>
				///  <para>PackageManager.ActivityInfo</para>
				/// </returns>
				/// <java-name>
				/// resolveActivityInfo
				/// </java-name>
				[Dot42.DexImport("resolveActivityInfo", "(Landroid/content/pm/PackageManager;I)Landroid/content/pm/ActivityInfo;", AccessFlags = 1)]
				public virtual global::Android.Content.PM.ActivityInfo ResolveActivityInfo(global::Android.Content.PM.PackageManager pm, int flags) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.PM.ActivityInfo);
				}

				/// <summary>
				///  <para>Set the general action to be performed.</para> <para> <para>getAction </para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns the same Intent object, for chaining multiple calls into a single statement.</para>
				/// </returns>
				/// <java-name>
				/// setAction
				/// </java-name>
				[Dot42.DexImport("setAction", "(Ljava/lang/String;)Landroid/content/Intent;", AccessFlags = 1)]
				public virtual global::Android.Content.Intent SetAction(string action) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Intent);
				}

				/// <summary>
				///  <para>Set the data this intent is operating on. This method automatically clears any type that was previously set by setType or setTypeAndNormalize.</para> <para> <b>Note: scheme matching in the Android framework is case-sensitive, unlike the formal RFC. As a result, you should always write your Uri with a lower case scheme, or use Uri#normalizeScheme or setDataAndNormalize to ensure that the scheme is converted to lower case.</b></para> <para> <para>getData </para> <para>setDataAndNormalize </para> <para>android.net.Uri::normalizeScheme() </para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns the same Intent object, for chaining multiple calls into a single statement.</para>
				/// </returns>
				/// <java-name>
				/// setData
				/// </java-name>
				[Dot42.DexImport("setData", "(Landroid/net/Uri;)Landroid/content/Intent;", AccessFlags = 1)]
				public virtual global::Android.Content.Intent SetData(global::Android.Net.Uri data) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Intent);
				}

				/// <summary>
				///  <para>Set an explicit MIME data type.</para> <para>This is used to create intents that only specify a type and not data, for example to indicate the type of data to return.</para> <para>This method automatically clears any data that was previously set (for example by setData).</para> <para> <b>Note: MIME type matching in the Android framework is case-sensitive, unlike formal RFC MIME types. As a result, you should always write your MIME types with lower case letters, or use normalizeMimeType or setTypeAndNormalize to ensure that it is converted to lower case.</b></para> <para> <para>getType </para> <para>setTypeAndNormalize </para> <para>setDataAndType </para> <para>normalizeMimeType </para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns the same Intent object, for chaining multiple calls into a single statement.</para>
				/// </returns>
				/// <java-name>
				/// setType
				/// </java-name>
				[Dot42.DexImport("setType", "(Ljava/lang/String;)Landroid/content/Intent;", AccessFlags = 1)]
				public virtual global::Android.Content.Intent SetType(string type) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Intent);
				}

				/// <summary>
				///  <para>(Usually optional) Set the data for the intent along with an explicit MIME data type. This method should very rarely be used  it allows you to override the MIME type that would ordinarily be inferred from the data with your own type given here.</para> <para> <b>Note: MIME type and Uri scheme matching in the Android framework is case-sensitive, unlike the formal RFC definitions. As a result, you should always write these elements with lower case letters, or use normalizeMimeType or android.net.Uri#normalizeScheme or setDataAndTypeAndNormalize to ensure that they are converted to lower case.</b></para> <para> <para>setType </para> <para>setData </para> <para>normalizeMimeType </para> <para>android.net.Uri::normalizeScheme </para> <para>setDataAndTypeAndNormalize </para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns the same Intent object, for chaining multiple calls into a single statement.</para>
				/// </returns>
				/// <java-name>
				/// setDataAndType
				/// </java-name>
				[Dot42.DexImport("setDataAndType", "(Landroid/net/Uri;Ljava/lang/String;)Landroid/content/Intent;", AccessFlags = 1)]
				public virtual global::Android.Content.Intent SetDataAndType(global::Android.Net.Uri data, string type) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Intent);
				}

				/// <summary>
				///  <para>Add a new category to the intent. Categories provide additional detail about the action the intent performs. When resolving an intent, only activities that provide  <b>all</b> of the requested categories will be used.</para> <para> <para>hasCategory </para> <para>removeCategory </para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns the same Intent object, for chaining multiple calls into a single statement.</para>
				/// </returns>
				/// <java-name>
				/// addCategory
				/// </java-name>
				[Dot42.DexImport("addCategory", "(Ljava/lang/String;)Landroid/content/Intent;", AccessFlags = 1)]
				public virtual global::Android.Content.Intent AddCategory(string category) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Intent);
				}

				/// <summary>
				///  <para>Remove a category from an intent.</para> <para> <para>addCategory </para></para>        
				/// </summary>
				/// <java-name>
				/// removeCategory
				/// </java-name>
				[Dot42.DexImport("removeCategory", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void RemoveCategory(string category) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// putExtra
				/// </java-name>
				[Dot42.DexImport("putExtra", "(Ljava/lang/String;Z)Landroid/content/Intent;", AccessFlags = 1)]
				public virtual global::Android.Content.Intent PutExtra(string @string, bool boolean) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Intent);
				}

				/// <java-name>
				/// putExtra
				/// </java-name>
				[Dot42.DexImport("putExtra", "(Ljava/lang/String;B)Landroid/content/Intent;", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual global::Android.Content.Intent PutExtra(string @string, sbyte sByte) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Intent);
				}

				/// <java-name>
				/// putExtra
				/// </java-name>
				[Dot42.DexImport("putExtra", "(Ljava/lang/String;B)Landroid/content/Intent;", AccessFlags = 1)]
				public virtual global::Android.Content.Intent PutExtra(string @string, byte @byte) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Intent);
				}

				/// <java-name>
				/// putExtra
				/// </java-name>
				[Dot42.DexImport("putExtra", "(Ljava/lang/String;C)Landroid/content/Intent;", AccessFlags = 1)]
				public virtual global::Android.Content.Intent PutExtra(string @string, char @char) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Intent);
				}

				/// <java-name>
				/// putExtra
				/// </java-name>
				[Dot42.DexImport("putExtra", "(Ljava/lang/String;S)Landroid/content/Intent;", AccessFlags = 1)]
				public virtual global::Android.Content.Intent PutExtra(string @string, short int16) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Intent);
				}

				/// <java-name>
				/// putExtra
				/// </java-name>
				[Dot42.DexImport("putExtra", "(Ljava/lang/String;I)Landroid/content/Intent;", AccessFlags = 1)]
				public virtual global::Android.Content.Intent PutExtra(string @string, int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Intent);
				}

				/// <java-name>
				/// putExtra
				/// </java-name>
				[Dot42.DexImport("putExtra", "(Ljava/lang/String;J)Landroid/content/Intent;", AccessFlags = 1)]
				public virtual global::Android.Content.Intent PutExtra(string @string, long int64) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Intent);
				}

				/// <java-name>
				/// putExtra
				/// </java-name>
				[Dot42.DexImport("putExtra", "(Ljava/lang/String;F)Landroid/content/Intent;", AccessFlags = 1)]
				public virtual global::Android.Content.Intent PutExtra(string @string, float single) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Intent);
				}

				/// <java-name>
				/// putExtra
				/// </java-name>
				[Dot42.DexImport("putExtra", "(Ljava/lang/String;D)Landroid/content/Intent;", AccessFlags = 1)]
				public virtual global::Android.Content.Intent PutExtra(string @string, double @double) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Intent);
				}

				/// <java-name>
				/// putExtra
				/// </java-name>
				[Dot42.DexImport("putExtra", "(Ljava/lang/String;Ljava/lang/String;)Landroid/content/Intent;", AccessFlags = 1)]
				public virtual global::Android.Content.Intent PutExtra(string @string, string string1) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Intent);
				}

				/// <java-name>
				/// putExtra
				/// </java-name>
				[Dot42.DexImport("putExtra", "(Ljava/lang/String;Ljava/lang/CharSequence;)Landroid/content/Intent;", AccessFlags = 1)]
				public virtual global::Android.Content.Intent PutExtra(string @string, global::Java.Lang.ICharSequence charSequence) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Intent);
				}

				/// <java-name>
				/// putExtra
				/// </java-name>
				[Dot42.DexImport("putExtra", "(Ljava/lang/String;Landroid/os/Parcelable;)Landroid/content/Intent;", AccessFlags = 1)]
				public virtual global::Android.Content.Intent PutExtra(string @string, global::Android.OS.IParcelable parcelable) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Intent);
				}

				/// <java-name>
				/// putExtra
				/// </java-name>
				[Dot42.DexImport("putExtra", "(Ljava/lang/String;[Landroid/os/Parcelable;)Landroid/content/Intent;", AccessFlags = 1)]
				public virtual global::Android.Content.Intent PutExtra(string @string, global::Android.OS.IParcelable[] parcelable) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Intent);
				}

				/// <summary>
				///  <para>Add extended data to the intent. The name must include a package prefix, for example the app com.android.contacts would use names like "com.android.contacts.ShowAll".</para> <para> <para>putExtras </para> <para>removeExtra </para> <para>#getParcelableArrayListExtra(String) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns the same Intent object, for chaining multiple calls into a single statement.</para>
				/// </returns>
				/// <java-name>
				/// putParcelableArrayListExtra
				/// </java-name>
				[Dot42.DexImport("putParcelableArrayListExtra", "(Ljava/lang/String;Ljava/util/ArrayList;)Landroid/content/Intent;", AccessFlags = 1, Signature = "(Ljava/lang/String;Ljava/util/ArrayList<+Landroid/os/Parcelable;>;)Landroid/conte" +
    "nt/Intent;")]
				public virtual global::Android.Content.Intent PutParcelableArrayListExtra(string name, global::Java.Util.ArrayList<global::Android.OS.IParcelable> value) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Intent);
				}

				/// <summary>
				///  <para>Add extended data to the intent. The name must include a package prefix, for example the app com.android.contacts would use names like "com.android.contacts.ShowAll".</para> <para> <para>putExtras </para> <para>removeExtra </para> <para>getIntegerArrayListExtra(String) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns the same Intent object, for chaining multiple calls into a single statement.</para>
				/// </returns>
				/// <java-name>
				/// putIntegerArrayListExtra
				/// </java-name>
				[Dot42.DexImport("putIntegerArrayListExtra", "(Ljava/lang/String;Ljava/util/ArrayList;)Landroid/content/Intent;", AccessFlags = 1, Signature = "(Ljava/lang/String;Ljava/util/ArrayList<Ljava/lang/Integer;>;)Landroid/content/In" +
    "tent;")]
				public virtual global::Android.Content.Intent PutIntegerArrayListExtra(string name, global::Java.Util.ArrayList<int?> value) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Intent);
				}

				/// <summary>
				///  <para>Add extended data to the intent. The name must include a package prefix, for example the app com.android.contacts would use names like "com.android.contacts.ShowAll".</para> <para> <para>putExtras </para> <para>removeExtra </para> <para>getStringArrayListExtra(String) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns the same Intent object, for chaining multiple calls into a single statement.</para>
				/// </returns>
				/// <java-name>
				/// putStringArrayListExtra
				/// </java-name>
				[Dot42.DexImport("putStringArrayListExtra", "(Ljava/lang/String;Ljava/util/ArrayList;)Landroid/content/Intent;", AccessFlags = 1, Signature = "(Ljava/lang/String;Ljava/util/ArrayList<Ljava/lang/String;>;)Landroid/content/Int" +
    "ent;")]
				public virtual global::Android.Content.Intent PutStringArrayListExtra(string name, global::Java.Util.ArrayList<string> value) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Intent);
				}

				/// <summary>
				///  <para>Add extended data to the intent. The name must include a package prefix, for example the app com.android.contacts would use names like "com.android.contacts.ShowAll".</para> <para> <para>putExtras </para> <para>removeExtra </para> <para>getCharSequenceArrayListExtra(String) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns the same Intent object, for chaining multiple calls into a single statement.</para>
				/// </returns>
				/// <java-name>
				/// putCharSequenceArrayListExtra
				/// </java-name>
				[Dot42.DexImport("putCharSequenceArrayListExtra", "(Ljava/lang/String;Ljava/util/ArrayList;)Landroid/content/Intent;", AccessFlags = 1, Signature = "(Ljava/lang/String;Ljava/util/ArrayList<Ljava/lang/CharSequence;>;)Landroid/conte" +
    "nt/Intent;")]
				public virtual global::Android.Content.Intent PutCharSequenceArrayListExtra(string name, global::Java.Util.ArrayList<global::Java.Lang.ICharSequence> value) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Intent);
				}

				/// <java-name>
				/// putExtra
				/// </java-name>
				[Dot42.DexImport("putExtra", "(Ljava/lang/String;Ljava/io/Serializable;)Landroid/content/Intent;", AccessFlags = 1)]
				public virtual global::Android.Content.Intent PutExtra(string @string, global::Java.IO.ISerializable serializable) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Intent);
				}

				/// <java-name>
				/// putExtra
				/// </java-name>
				[Dot42.DexImport("putExtra", "(Ljava/lang/String;[Z)Landroid/content/Intent;", AccessFlags = 1)]
				public virtual global::Android.Content.Intent PutExtra(string @string, bool[] boolean) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Intent);
				}

				/// <java-name>
				/// putExtra
				/// </java-name>
				[Dot42.DexImport("putExtra", "(Ljava/lang/String;[B)Landroid/content/Intent;", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual global::Android.Content.Intent PutExtra(string @string, sbyte[] sByte) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Intent);
				}

				/// <java-name>
				/// putExtra
				/// </java-name>
				[Dot42.DexImport("putExtra", "(Ljava/lang/String;[B)Landroid/content/Intent;", AccessFlags = 1)]
				public virtual global::Android.Content.Intent PutExtra(string @string, byte[] @byte) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Intent);
				}

				/// <java-name>
				/// putExtra
				/// </java-name>
				[Dot42.DexImport("putExtra", "(Ljava/lang/String;[S)Landroid/content/Intent;", AccessFlags = 1)]
				public virtual global::Android.Content.Intent PutExtra(string @string, short[] int16) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Intent);
				}

				/// <java-name>
				/// putExtra
				/// </java-name>
				[Dot42.DexImport("putExtra", "(Ljava/lang/String;[C)Landroid/content/Intent;", AccessFlags = 1)]
				public virtual global::Android.Content.Intent PutExtra(string @string, char[] @char) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Intent);
				}

				/// <java-name>
				/// putExtra
				/// </java-name>
				[Dot42.DexImport("putExtra", "(Ljava/lang/String;[I)Landroid/content/Intent;", AccessFlags = 1)]
				public virtual global::Android.Content.Intent PutExtra(string @string, int[] int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Intent);
				}

				/// <java-name>
				/// putExtra
				/// </java-name>
				[Dot42.DexImport("putExtra", "(Ljava/lang/String;[J)Landroid/content/Intent;", AccessFlags = 1)]
				public virtual global::Android.Content.Intent PutExtra(string @string, long[] int64) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Intent);
				}

				/// <java-name>
				/// putExtra
				/// </java-name>
				[Dot42.DexImport("putExtra", "(Ljava/lang/String;[F)Landroid/content/Intent;", AccessFlags = 1)]
				public virtual global::Android.Content.Intent PutExtra(string @string, float[] single) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Intent);
				}

				/// <java-name>
				/// putExtra
				/// </java-name>
				[Dot42.DexImport("putExtra", "(Ljava/lang/String;[D)Landroid/content/Intent;", AccessFlags = 1)]
				public virtual global::Android.Content.Intent PutExtra(string @string, double[] @double) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Intent);
				}

				/// <java-name>
				/// putExtra
				/// </java-name>
				[Dot42.DexImport("putExtra", "(Ljava/lang/String;[Ljava/lang/String;)Landroid/content/Intent;", AccessFlags = 1)]
				public virtual global::Android.Content.Intent PutExtra(string @string, string[] string1) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Intent);
				}

				/// <java-name>
				/// putExtra
				/// </java-name>
				[Dot42.DexImport("putExtra", "(Ljava/lang/String;[Ljava/lang/CharSequence;)Landroid/content/Intent;", AccessFlags = 1)]
				public virtual global::Android.Content.Intent PutExtra(string @string, global::Java.Lang.ICharSequence[] charSequence) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Intent);
				}

				/// <java-name>
				/// putExtra
				/// </java-name>
				[Dot42.DexImport("putExtra", "(Ljava/lang/String;Landroid/os/Bundle;)Landroid/content/Intent;", AccessFlags = 1)]
				public virtual global::Android.Content.Intent PutExtra(string @string, global::Android.OS.Bundle bundle) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Intent);
				}

				/// <summary>
				///  <para>Copy all extras in 'src' in to this intent.</para> <para> <para>putExtra </para></para>        
				/// </summary>
				/// <java-name>
				/// putExtras
				/// </java-name>
				[Dot42.DexImport("putExtras", "(Landroid/content/Intent;)Landroid/content/Intent;", AccessFlags = 1)]
				public virtual global::Android.Content.Intent PutExtras(global::Android.Content.Intent src) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Intent);
				}

				/// <summary>
				///  <para>Copy all extras in 'src' in to this intent.</para> <para> <para>putExtra </para></para>        
				/// </summary>
				/// <java-name>
				/// putExtras
				/// </java-name>
				[Dot42.DexImport("putExtras", "(Landroid/os/Bundle;)Landroid/content/Intent;", AccessFlags = 1)]
				public virtual global::Android.Content.Intent PutExtras(global::Android.OS.Bundle src) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Intent);
				}

				/// <summary>
				///  <para>Completely replace the extras in the Intent with the extras in the given Intent.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// replaceExtras
				/// </java-name>
				[Dot42.DexImport("replaceExtras", "(Landroid/content/Intent;)Landroid/content/Intent;", AccessFlags = 1)]
				public virtual global::Android.Content.Intent ReplaceExtras(global::Android.Content.Intent src) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Intent);
				}

				/// <summary>
				///  <para>Completely replace the extras in the Intent with the extras in the given Intent.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// replaceExtras
				/// </java-name>
				[Dot42.DexImport("replaceExtras", "(Landroid/os/Bundle;)Landroid/content/Intent;", AccessFlags = 1)]
				public virtual global::Android.Content.Intent ReplaceExtras(global::Android.OS.Bundle src) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Intent);
				}

				/// <summary>
				///  <para>Remove extended data from the intent.</para> <para> <para>putExtra </para></para>        
				/// </summary>
				/// <java-name>
				/// removeExtra
				/// </java-name>
				[Dot42.DexImport("removeExtra", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void RemoveExtra(string name) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Set special flags controlling how this intent is handled. Most values here depend on the type of component being executed by the Intent, specifically the FLAG_ACTIVITY_* flags are all for use with Context.startActivity() and the FLAG_RECEIVER_* flags are all for use with Context.sendBroadcast().</para> <para>See the  documentation for important information on how some of these options impact the behavior of your application.</para> <para> <para>getFlags </para> <para>addFlags</para> <para>FLAG_GRANT_READ_URI_PERMISSION </para> <para>FLAG_GRANT_WRITE_URI_PERMISSION </para> <para>FLAG_DEBUG_LOG_RESOLUTION </para> <para>FLAG_FROM_BACKGROUND </para> <para>FLAG_ACTIVITY_BROUGHT_TO_FRONT </para> <para>FLAG_ACTIVITY_CLEAR_TASK </para> <para>FLAG_ACTIVITY_CLEAR_TOP </para> <para>FLAG_ACTIVITY_CLEAR_WHEN_TASK_RESET </para> <para>FLAG_ACTIVITY_EXCLUDE_FROM_RECENTS </para> <para>FLAG_ACTIVITY_FORWARD_RESULT </para> <para>FLAG_ACTIVITY_LAUNCHED_FROM_HISTORY </para> <para>FLAG_ACTIVITY_MULTIPLE_TASK </para> <para>FLAG_ACTIVITY_NEW_TASK </para> <para>FLAG_ACTIVITY_NO_ANIMATION </para> <para>FLAG_ACTIVITY_NO_HISTORY </para> <para>FLAG_ACTIVITY_NO_USER_ACTION </para> <para>FLAG_ACTIVITY_PREVIOUS_IS_TOP </para> <para>FLAG_ACTIVITY_RESET_TASK_IF_NEEDED </para> <para>FLAG_ACTIVITY_REORDER_TO_FRONT </para> <para>FLAG_ACTIVITY_SINGLE_TOP </para> <para>FLAG_ACTIVITY_TASK_ON_HOME </para> <para>FLAG_RECEIVER_REGISTERED_ONLY </para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns the same Intent object, for chaining multiple calls into a single statement.</para>
				/// </returns>
				/// <java-name>
				/// setFlags
				/// </java-name>
				[Dot42.DexImport("setFlags", "(I)Landroid/content/Intent;", AccessFlags = 1)]
				public virtual global::Android.Content.Intent SetFlags(int flags) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Intent);
				}

				/// <summary>
				///  <para>Add additional flags to the intent (or with existing flags value).</para> <para> <para>setFlags </para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns the same Intent object, for chaining multiple calls into a single statement.</para>
				/// </returns>
				/// <java-name>
				/// addFlags
				/// </java-name>
				[Dot42.DexImport("addFlags", "(I)Landroid/content/Intent;", AccessFlags = 1)]
				public virtual global::Android.Content.Intent AddFlags(int flags) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Intent);
				}

				/// <summary>
				///  <para>(Usually optional) Set an explicit application package name that limits the components this Intent will resolve to. If left to the default value of null, all components in all applications will considered. If non-null, the Intent can only match the components in the given application package.</para> <para> <para>getPackage </para> <para>resolveActivity </para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns the same Intent object, for chaining multiple calls into a single statement.</para>
				/// </returns>
				/// <java-name>
				/// setPackage
				/// </java-name>
				[Dot42.DexImport("setPackage", "(Ljava/lang/String;)Landroid/content/Intent;", AccessFlags = 1)]
				public virtual global::Android.Content.Intent SetPackage(string packageName) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Intent);
				}

				/// <summary>
				///  <para>(Usually optional) Explicitly set the component to handle the intent. If left with the default value of null, the system will determine the appropriate class to use based on the other fields (action, data, type, categories) in the Intent. If this class is defined, the specified class will always be used regardless of the other fields. You should only set this value when you know you absolutely want a specific class to be used; otherwise it is better to let the system find the appropriate class so that you will respect the installed applications and user preferences.</para> <para> <para>setClass </para> <para>setClassName(Context, String) </para> <para>setClassName(String, String) </para> <para>getComponent </para> <para>resolveActivity </para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns the same Intent object, for chaining multiple calls into a single statement.</para>
				/// </returns>
				/// <java-name>
				/// setComponent
				/// </java-name>
				[Dot42.DexImport("setComponent", "(Landroid/content/ComponentName;)Landroid/content/Intent;", AccessFlags = 1)]
				public virtual global::Android.Content.Intent SetComponent(global::Android.Content.ComponentName component) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Intent);
				}

				/// <java-name>
				/// setClassName
				/// </java-name>
				[Dot42.DexImport("setClassName", "(Landroid/content/Context;Ljava/lang/String;)Landroid/content/Intent;", AccessFlags = 1)]
				public virtual global::Android.Content.Intent SetClassName(global::Android.Content.Context context, string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Intent);
				}

				/// <java-name>
				/// setClassName
				/// </java-name>
				[Dot42.DexImport("setClassName", "(Ljava/lang/String;Ljava/lang/String;)Landroid/content/Intent;", AccessFlags = 1)]
				public virtual global::Android.Content.Intent SetClassName(string @string, string string1) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Intent);
				}

				/// <summary>
				///  <para>Convenience for calling setComponent(ComponentName) with the name returned by a Class object.</para> <para> <para>setComponent </para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns the same Intent object, for chaining multiple calls into a single statement.</para>
				/// </returns>
				/// <java-name>
				/// setClass
				/// </java-name>
				[Dot42.DexImport("setClass", "(Landroid/content/Context;Ljava/lang/Class;)Landroid/content/Intent;", AccessFlags = 1, Signature = "(Landroid/content/Context;Ljava/lang/Class<*>;)Landroid/content/Intent;")]
				public virtual global::Android.Content.Intent SetClass(global::Android.Content.Context packageContext, global::System.Type cls) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Intent);
				}

				/// <summary>
				///  <para>Copy the contents of  <b>other</b> in to this object, but only where fields are not defined by this object. For purposes of a field being defined, the following pieces of data in the Intent are considered to be separate fields:</para> <para> <ul> <li> <para>action, as set by setAction. </para></li> <li> <para>data Uri and MIME type, as set by setData(Uri), setType(String), or setDataAndType(Uri, String). </para></li> <li> <para>categories, as set by addCategory. </para></li> <li> <para>package, as set by setPackage. </para></li> <li> <para>component, as set by setComponent(ComponentName) or related methods. </para></li> <li> <para>source bounds, as set by setSourceBounds. </para></li> <li> <para>selector, as set by setSelector(Intent). </para></li> <li> <para>clip data, as set by setClipData(ClipData). </para></li> <li> <para>each top-level name in the associated extras. </para></li></ul></para> <para>In addition, you can use the FILL_IN_ACTION, FILL_IN_DATA, FILL_IN_CATEGORIES, FILL_IN_PACKAGE, FILL_IN_COMPONENT, FILL_IN_SOURCE_BOUNDS, FILL_IN_SELECTOR, and FILL_IN_CLIP_DATA to override the restriction where the corresponding field will not be replaced if it is already set.</para> <para>Note: The component field will only be copied if FILL_IN_COMPONENT is explicitly specified. The selector will only be copied if FILL_IN_SELECTOR is explicitly specified.</para> <para>For example, consider Intent A with {data="foo", categories="bar"} and Intent B with {action="gotit", data-type="some/thing", categories="one","two"}.</para> <para>Calling A.fillIn(B, Intent.FILL_IN_DATA) will result in A now containing: {action="gotit", data-type="some/thing", categories="bar"}.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns a bit mask of FILL_IN_ACTION, FILL_IN_DATA, FILL_IN_CATEGORIES, FILL_IN_PACKAGE, FILL_IN_COMPONENT, FILL_IN_SOURCE_BOUNDS, and FILL_IN_SELECTOR indicating which fields were changed. </para>
				/// </returns>
				/// <java-name>
				/// fillIn
				/// </java-name>
				[Dot42.DexImport("fillIn", "(Landroid/content/Intent;I)I", AccessFlags = 1)]
				public virtual int FillIn(global::Android.Content.Intent other, int flags) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Determine if two intents are the same for the purposes of intent resolution (filtering). That is, if their action, data, type, class, and categories are the same. This does  <b>not</b> compare any extra data included in the intents.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns true if action, data, type, class, and categories are the same. </para>
				/// </returns>
				/// <java-name>
				/// filterEquals
				/// </java-name>
				[Dot42.DexImport("filterEquals", "(Landroid/content/Intent;)Z", AccessFlags = 1)]
				public virtual bool FilterEquals(global::Android.Content.Intent other) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Generate hash code that matches semantics of filterEquals().</para> <para> <para>filterEquals </para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns the hash value of the action, data, type, class, and categories.</para>
				/// </returns>
				/// <java-name>
				/// filterHashCode
				/// </java-name>
				[Dot42.DexImport("filterHashCode", "()I", AccessFlags = 1)]
				public virtual int FilterHashCode() /* MethodBuilder.Create */ 
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
				///  <para>Call toUri with 0 flags.  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use toUri instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// toURI
				/// </java-name>
				[Dot42.DexImport("toURI", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string ToURI() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Convert this Intent into a String holding a URI representation of it. The returned URI string has been properly URI encoded, so it can be used with Uri.parse(String). The URI contains the Intent's data as the base URI, with an additional fragment describing the action, categories, type, flags, package, component, and extras.</para> <para>You can convert the returned string back to an Intent with getIntent.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns a URI encoding URI string describing the entire contents of the Intent. </para>
				/// </returns>
				/// <java-name>
				/// toUri
				/// </java-name>
				[Dot42.DexImport("toUri", "(I)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string ToUri(int flags) /* MethodBuilder.Create */ 
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
				public virtual void ReadFromParcel(global::Android.OS.Parcel @in) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Parses the "intent" element (and its children) from XML and instantiates an Intent object. The given XML parser should be located at the tag where parsing should start (often named "intent"), from which the basic action, data, type, and package and class name will be retrieved. The function will then parse in to any child elements, looking for &lt;category android:name="xxx"&gt; tags to add categories and &lt;extra android:name="xxx" android:value="yyy"&gt; to attach extra data to the intent.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>An Intent object matching the XML data. </para>
				/// </returns>
				/// <java-name>
				/// parseIntent
				/// </java-name>
				[Dot42.DexImport("parseIntent", "(Landroid/content/res/Resources;Lorg/xmlpull/v1/XmlPullParser;Landroid/util/Attri" +
    "buteSet;)Landroid/content/Intent;", AccessFlags = 9)]
				public static global::Android.Content.Intent ParseIntent(global::Android.Content.Res.Resources resources, global::Org.Xmlpull.V1.IXmlPullParser parser, global::Android.Util.IAttributeSet attrs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Intent);
				}

				/// <summary>
				///  <para>Retrieve the general action to be performed, such as ACTION_VIEW. The action describes the general way the rest of the information in the intent should be interpreted  most importantly, what to do with the data returned by getData.</para> <para> <para>setAction </para></para>        
				/// </summary>
				/// <returns>
				///  <para>The action of this intent or null if none is specified.</para>
				/// </returns>
				/// <java-name>
				/// getAction
				/// </java-name>
				public virtual string Action
				{
						[Dot42.DexImport("getAction", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>Retrieve data this intent is operating on. This URI specifies the name of the data; often it uses the content: scheme, specifying data in a content provider. Other schemes may be handled by specific activities, such as http: by the web browser.</para> <para> <para>getScheme </para> <para>setData </para></para>        
				/// </summary>
				/// <returns>
				///  <para>The URI of the data this intent is targeting or null.</para>
				/// </returns>
				/// <java-name>
				/// getData
				/// </java-name>
				public virtual global::Android.Net.Uri Data
				{
						[Dot42.DexImport("getData", "()Landroid/net/Uri;", AccessFlags = 1)]
						get{ return default(global::Android.Net.Uri); }
				}

				/// <summary>
				///  <para>The same as getData(), but returns the URI as an encoded String. </para>        
				/// </summary>
				/// <java-name>
				/// getDataString
				/// </java-name>
				public virtual string DataString
				{
						[Dot42.DexImport("getDataString", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>Return the scheme portion of the intent's data. If the data is null or does not include a scheme, null is returned. Otherwise, the scheme prefix without the final ':' is returned, i.e. "http".</para> <para>This is the same as calling getData().getScheme() (and checking for null data).</para> <para> <para>getData </para></para>        
				/// </summary>
				/// <returns>
				///  <para>The scheme of this intent.</para>
				/// </returns>
				/// <java-name>
				/// getScheme
				/// </java-name>
				public virtual string Scheme
				{
						[Dot42.DexImport("getScheme", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>Retrieve any explicit MIME type included in the intent. This is usually null, as the type is determined by the intent data.</para> <para> <para>resolveType(ContentResolver) </para> <para>setType </para></para>        
				/// </summary>
				/// <returns>
				///  <para>If a type was manually set, it is returned; else null is returned.</para>
				/// </returns>
				/// <java-name>
				/// getType
				/// </java-name>
				public virtual string Type
				{
						[Dot42.DexImport("getType", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>Return the set of all categories in the intent. If there are no categories, returns NULL.</para> <para> <para>hasCategory </para> <para>addCategory </para></para>        
				/// </summary>
				/// <returns>
				///  <para>The set of categories you can examine. Do not modify!</para>
				/// </returns>
				/// <java-name>
				/// getCategories
				/// </java-name>
				public virtual global::Java.Util.ISet<string> Categories
				{
						[Dot42.DexImport("getCategories", "()Ljava/util/Set;", AccessFlags = 1, Signature = "()Ljava/util/Set<Ljava/lang/String;>;")]
						get{ return default(global::Java.Util.ISet<string>); }
				}

				/// <summary>
				///  <para>Returns true if the Intent's extras contain a parcelled file descriptor. </para>        
				/// </summary>
				/// <returns>
				///  <para>true if the Intent contains a parcelled file descriptor. </para>
				/// </returns>
				/// <java-name>
				/// hasFileDescriptors
				/// </java-name>
				public virtual bool HasFileDescriptors
				{
						[Dot42.DexImport("hasFileDescriptors", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Retrieves a map of extended data from the intent.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the map of all extras previously added with putExtra(), or null if none have been added. </para>
				/// </returns>
				/// <java-name>
				/// getExtras
				/// </java-name>
				public virtual global::Android.OS.Bundle Extras
				{
						[Dot42.DexImport("getExtras", "()Landroid/os/Bundle;", AccessFlags = 1)]
						get{ return default(global::Android.OS.Bundle); }
				}

				/// <summary>
				///  <para>Retrieve any special flags associated with this intent. You will normally just set them with setFlags and let the system take the appropriate action with them.</para> <para> <para>setFlags </para></para>        
				/// </summary>
				/// <returns>
				///  <para>int The currently set flags.</para>
				/// </returns>
				/// <java-name>
				/// getFlags
				/// </java-name>
				public virtual int Flags
				{
						[Dot42.DexImport("getFlags", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Retrieve the application package name this Intent is limited to. When resolving an Intent, if non-null this limits the resolution to only components in the given application package.</para> <para> <para>resolveActivity </para> <para>setPackage </para></para>        
				/// </summary>
				/// <returns>
				///  <para>The name of the application package for the Intent.</para>
				/// </returns>
				/// <java-name>
				/// getPackage
				/// </java-name>
				public virtual string Package
				{
						[Dot42.DexImport("getPackage", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>Retrieve the concrete component associated with the intent. When receiving an intent, this is the component that was found to best handle it (that is, yourself) and will always be non-null; in all other cases it will be null unless explicitly set.</para> <para> <para>resolveActivity </para> <para>setComponent </para></para>        
				/// </summary>
				/// <returns>
				///  <para>The name of the application component to handle the intent.</para>
				/// </returns>
				/// <java-name>
				/// getComponent
				/// </java-name>
				public virtual global::Android.Content.ComponentName Component
				{
						[Dot42.DexImport("getComponent", "()Landroid/content/ComponentName;", AccessFlags = 1)]
						get{ return default(global::Android.Content.ComponentName); }
				}

				/// <summary>
				///  <para>Get the bounds of the sender of this intent, in screen coordinates. This can be used as a hint to the receiver for animations and the like. Null means that there is no source bounds. </para>        
				/// </summary>
				/// <java-name>
				/// getSourceBounds
				/// </java-name>
				public virtual global::Android.Graphics.Rect SourceBounds
				{
						[Dot42.DexImport("getSourceBounds", "()Landroid/graphics/Rect;", AccessFlags = 1)]
						get{ return default(global::Android.Graphics.Rect); }
						[Dot42.DexImport("setSourceBounds", "(Landroid/graphics/Rect;)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Wrapper class holding an Intent and implementing comparisons on it for the purpose of filtering. The class implements its equals() and hashCode() methods as simple calls to Intent#filterEquals(Intent) filterEquals()} and android.content.Intent#filterHashCode() filterHashCode()} on the wrapped Intent. </para>    
				/// </summary>
				/// <java-name>
				/// android/content/Intent$FilterComparison
				/// </java-name>
				[Dot42.DexImport("android/content/Intent$FilterComparison", AccessFlags = 25)]
				public sealed partial class FilterComparison
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "(Landroid/content/Intent;)V", AccessFlags = 1)]
						public FilterComparison(global::Android.Content.Intent intent) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// equals
						/// </java-name>
						[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
						public override bool Equals(object obj) /* MethodBuilder.Create */ 
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

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						protected internal FilterComparison() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

						/// <summary>
						///  <para>Return the Intent that this FilterComparison represents. </para>        
						/// </summary>
						/// <returns>
						///  <para>Returns the Intent held by the FilterComparison. Do not modify! </para>
						/// </returns>
						/// <java-name>
						/// getIntent
						/// </java-name>
						public global::Android.Content.Intent Intent
						{
								[Dot42.DexImport("getIntent", "()Landroid/content/Intent;", AccessFlags = 1)]
								get{ return default(global::Android.Content.Intent); }
						}

				}

				/// <summary>
				///  <para>Represents a shortcut/live folder icon resource.</para> <para> <para>Intent::ACTION_CREATE_SHORTCUT </para> <para>Intent::EXTRA_SHORTCUT_ICON_RESOURCE </para> <para>android.provider.LiveFolders::ACTION_CREATE_LIVE_FOLDER </para> <para>android.provider.LiveFolders::EXTRA_LIVE_FOLDER_ICON </para></para>    
				/// </summary>
				/// <java-name>
				/// android/content/Intent$ShortcutIconResource
				/// </java-name>
				[Dot42.DexImport("android/content/Intent$ShortcutIconResource", AccessFlags = 9)]
				public partial class ShortcutIconResource : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>The package name of the application containing the icon. </para>        
						/// </summary>
						/// <java-name>
						/// packageName
						/// </java-name>
						[Dot42.DexImport("packageName", "Ljava/lang/String;", AccessFlags = 1)]
						public string PackageName;
						/// <summary>
						///  <para>The resource name of the icon, including package, name and type. </para>        
						/// </summary>
						/// <java-name>
						/// resourceName
						/// </java-name>
						[Dot42.DexImport("resourceName", "Ljava/lang/String;", AccessFlags = 1)]
						public string ResourceName;
						/// <summary>
						///  <para>Used to read a ShortcutIconResource from a Parcel. </para>        
						/// </summary>
						/// <java-name>
						/// CREATOR
						/// </java-name>
						[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
						public static readonly global::Android.OS.IParcelable_ICreator<ShortcutIconResource> CREATOR;
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public ShortcutIconResource() /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Creates a new ShortcutIconResource for the specified context and resource identifier.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>A new ShortcutIconResource with the specified's context package name and icon resource idenfitier. </para>
						/// </returns>
						/// <java-name>
						/// fromContext
						/// </java-name>
						[Dot42.DexImport("fromContext", "(Landroid/content/Context;I)Landroid/content/Intent$ShortcutIconResource;", AccessFlags = 9)]
						public static ShortcutIconResource FromContext(global::Android.Content.Context context, int resourceId) /* MethodBuilder.Create */ 
						{
								return default(ShortcutIconResource);
						}

						/// <summary>
						///  <para>No special parcel contents. </para>        
						/// </summary>
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
						/// toString
						/// </java-name>
						[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
						public override string ToString() /* MethodBuilder.Create */ 
						{
								return default(string);
						}

				}

		}

		/// <summary>
		///  <para>Structured description of Intent values to be matched. An IntentFilter can match against actions, categories, and data (either via its type, scheme, and/or path) in an Intent. It also includes a "priority" value which is used to order multiple matching filters.</para> <para>IntentFilter objects are often created in XML as part of a package's AndroidManifest.xml file, using intent-filter tags.</para> <para>There are three Intent characteristics you can filter on: the  <b>action</b>,  <b>data</b>, and  <b>categories</b>. For each of these characteristics you can provide multiple possible matching values (via addAction, addDataType, addDataScheme, addDataSchemeSpecificPart, addDataAuthority, addDataPath, and addCategory, respectively). For actions, the field will not be tested if no values have been given (treating it as a wildcard); if no data characteristics are specified, however, then the filter will only match intents that contain no data.</para> <para>The data characteristic is itself divided into three attributes: type, scheme, authority, and path. Any that are specified must match the contents of the Intent. If you specify a scheme but no type, only Intent that does not have a type (such as mailto:) will match; a content: URI will never match because they always have a MIME type that is supplied by their content provider. Specifying a type with no scheme has somewhat special meaning: it will match either an Intent with no URI field, or an Intent with a content: or file: URI. If you specify neither, then only an Intent with no data or type will match. To specify an authority, you must also specify one or more schemes that it is associated with. To specify a path, you also must specify both one or more authorities and one or more schemes it is associated with.</para> <para>  <h3>Developer Guides</h3></para> <para> </para> <para>For information about how to create and resolve intents, read the  developer guide.</para> <para> </para> <para> <h3>Filter Rules</h3></para> <para>A match is based on the following rules. Note that for an IntentFilter to match an Intent, three conditions must hold: the  <b>action</b> and  <b>category</b> must match, and the data (both the  <b>data type</b> and  <b>data scheme+authority+path</b> if specified) must match (see match(ContentResolver, Intent, boolean, String) for more details on how the data fields match).</para> <para> <b>Action</b> matches if any of the given values match the Intent action; if the filter specifies no actions, then it will only match Intents that do not contain an action.</para> <para> <b>Data Type</b> matches if any of the given values match the Intent type. The Intent type is determined by calling Intent#resolveType. A wildcard can be used for the MIME sub-type, in both the Intent and IntentFilter, so that the type "audio/*" will match "audio/mpeg", "audio/aiff", "audio/*", etc.  <b>Note that MIME type matching here is  <b>case sensitive</b>, unlike formal RFC MIME types!</b> You should thus always use lower case letters for your MIME types.</para> <para> <b>Data Scheme</b> matches if any of the given values match the Intent data's scheme. The Intent scheme is determined by calling Intent#getData and android.net.Uri#getScheme on that URI.  <b>Note that scheme matching here is  <b>case sensitive</b>, unlike formal RFC schemes!</b> You should thus always use lower case letters for your schemes.</para> <para> <b>Data Scheme Specific Part</b> matches if any of the given values match the Intent's data scheme specific part  <b>and</b> one of the data schemes in the filter has matched the Intent,  <b>or</b> no scheme specific parts were supplied in the filter. The Intent scheme specific part is determined by calling Intent#getData and android.net.Uri#getSchemeSpecificPart on that URI.  <b>Note that scheme specific part matching is  <b>case sensitive</b>.</b></para> <para> <b>Data Authority</b> matches if any of the given values match the Intent's data authority  <b>and</b> one of the data schemes in the filter has matched the Intent,  <b>or</b> no authories were supplied in the filter. The Intent authority is determined by calling Intent#getData and android.net.Uri#getAuthority on that URI.  <b>Note that authority matching here is  <b>case sensitive</b>, unlike formal RFC host names!</b> You should thus always use lower case letters for your authority.</para> <para> <b>Data Path</b> matches if any of the given values match the Intent's data path  <b>and</b> both a scheme and authority in the filter has matched against the Intent,  <b>or</b> no paths were supplied in the filter. The Intent authority is determined by calling Intent#getData and android.net.Uri#getPath on that URI.</para> <para> <b>Categories</b> match if  <b>all</b> of the categories in the Intent match categories given in the filter. Extra categories in the filter that are not in the Intent will not cause the match to fail. Note that unlike the action, an IntentFilter with no categories will only match an Intent that does not have any categories. </para>    
		/// </summary>
		/// <java-name>
		/// android/content/IntentFilter
		/// </java-name>
		[Dot42.DexImport("android/content/IntentFilter", AccessFlags = 33)]
		public partial class IntentFilter : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>The filter setPriority value at which system high-priority receivers are placed; that is, receivers that should execute before application code. Applications should never use filters with this or higher priorities.</para> <para> <para>setPriority </para></para>        
				/// </summary>
				/// <java-name>
				/// SYSTEM_HIGH_PRIORITY
				/// </java-name>
				[Dot42.DexImport("SYSTEM_HIGH_PRIORITY", "I", AccessFlags = 25)]
				public const int SYSTEM_HIGH_PRIORITY = 1000;
				/// <summary>
				///  <para>The filter setPriority value at which system low-priority receivers are placed; that is, receivers that should execute after application code. Applications should never use filters with this or lower priorities.</para> <para> <para>setPriority </para></para>        
				/// </summary>
				/// <java-name>
				/// SYSTEM_LOW_PRIORITY
				/// </java-name>
				[Dot42.DexImport("SYSTEM_LOW_PRIORITY", "I", AccessFlags = 25)]
				public const int SYSTEM_LOW_PRIORITY = -1000;
				/// <summary>
				///  <para>The part of a match constant that describes the category of match that occurred. May be either MATCH_CATEGORY_EMPTY, MATCH_CATEGORY_SCHEME, MATCH_CATEGORY_SCHEME_SPECIFIC_PART, MATCH_CATEGORY_HOST, MATCH_CATEGORY_PORT, MATCH_CATEGORY_PATH, or MATCH_CATEGORY_TYPE. Higher values indicate a better match. </para>        
				/// </summary>
				/// <java-name>
				/// MATCH_CATEGORY_MASK
				/// </java-name>
				[Dot42.DexImport("MATCH_CATEGORY_MASK", "I", AccessFlags = 25)]
				public const int MATCH_CATEGORY_MASK = 268369920;
				/// <summary>
				///  <para>The part of a match constant that applies a quality adjustment to the basic category of match. The value MATCH_ADJUSTMENT_NORMAL is no adjustment; higher numbers than that improve the quality, while lower numbers reduce it. </para>        
				/// </summary>
				/// <java-name>
				/// MATCH_ADJUSTMENT_MASK
				/// </java-name>
				[Dot42.DexImport("MATCH_ADJUSTMENT_MASK", "I", AccessFlags = 25)]
				public const int MATCH_ADJUSTMENT_MASK = 65535;
				/// <summary>
				///  <para>Quality adjustment applied to the category of match that signifies the default, base value; higher numbers improve the quality while lower numbers reduce it. </para>        
				/// </summary>
				/// <java-name>
				/// MATCH_ADJUSTMENT_NORMAL
				/// </java-name>
				[Dot42.DexImport("MATCH_ADJUSTMENT_NORMAL", "I", AccessFlags = 25)]
				public const int MATCH_ADJUSTMENT_NORMAL = 32768;
				/// <summary>
				///  <para>The filter matched an intent that had no data specified. </para>        
				/// </summary>
				/// <java-name>
				/// MATCH_CATEGORY_EMPTY
				/// </java-name>
				[Dot42.DexImport("MATCH_CATEGORY_EMPTY", "I", AccessFlags = 25)]
				public const int MATCH_CATEGORY_EMPTY = 1048576;
				/// <summary>
				///  <para>The filter matched an intent with the same data URI scheme. </para>        
				/// </summary>
				/// <java-name>
				/// MATCH_CATEGORY_SCHEME
				/// </java-name>
				[Dot42.DexImport("MATCH_CATEGORY_SCHEME", "I", AccessFlags = 25)]
				public const int MATCH_CATEGORY_SCHEME = 2097152;
				/// <summary>
				///  <para>The filter matched an intent with the same data URI scheme and authority host. </para>        
				/// </summary>
				/// <java-name>
				/// MATCH_CATEGORY_HOST
				/// </java-name>
				[Dot42.DexImport("MATCH_CATEGORY_HOST", "I", AccessFlags = 25)]
				public const int MATCH_CATEGORY_HOST = 3145728;
				/// <summary>
				///  <para>The filter matched an intent with the same data URI scheme and authority host and port. </para>        
				/// </summary>
				/// <java-name>
				/// MATCH_CATEGORY_PORT
				/// </java-name>
				[Dot42.DexImport("MATCH_CATEGORY_PORT", "I", AccessFlags = 25)]
				public const int MATCH_CATEGORY_PORT = 4194304;
				/// <summary>
				///  <para>The filter matched an intent with the same data URI scheme, authority, and path. </para>        
				/// </summary>
				/// <java-name>
				/// MATCH_CATEGORY_PATH
				/// </java-name>
				[Dot42.DexImport("MATCH_CATEGORY_PATH", "I", AccessFlags = 25)]
				public const int MATCH_CATEGORY_PATH = 5242880;
				/// <summary>
				///  <para>The filter matched an intent with the same data MIME type. </para>        
				/// </summary>
				/// <java-name>
				/// MATCH_CATEGORY_TYPE
				/// </java-name>
				[Dot42.DexImport("MATCH_CATEGORY_TYPE", "I", AccessFlags = 25)]
				public const int MATCH_CATEGORY_TYPE = 6291456;
				/// <summary>
				///  <para>The filter didn't match due to different MIME types. </para>        
				/// </summary>
				/// <java-name>
				/// NO_MATCH_TYPE
				/// </java-name>
				[Dot42.DexImport("NO_MATCH_TYPE", "I", AccessFlags = 25)]
				public const int NO_MATCH_TYPE = -1;
				/// <summary>
				///  <para>The filter didn't match due to different data URIs. </para>        
				/// </summary>
				/// <java-name>
				/// NO_MATCH_DATA
				/// </java-name>
				[Dot42.DexImport("NO_MATCH_DATA", "I", AccessFlags = 25)]
				public const int NO_MATCH_DATA = -2;
				/// <summary>
				///  <para>The filter didn't match due to different actions. </para>        
				/// </summary>
				/// <java-name>
				/// NO_MATCH_ACTION
				/// </java-name>
				[Dot42.DexImport("NO_MATCH_ACTION", "I", AccessFlags = 25)]
				public const int NO_MATCH_ACTION = -3;
				/// <summary>
				///  <para>The filter didn't match because it required one or more categories that were not in the Intent. </para>        
				/// </summary>
				/// <java-name>
				/// NO_MATCH_CATEGORY
				/// </java-name>
				[Dot42.DexImport("NO_MATCH_CATEGORY", "I", AccessFlags = 25)]
				public const int NO_MATCH_CATEGORY = -4;
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.Content.IntentFilter> CREATOR;
				/// <summary>
				///  <para>New empty IntentFilter. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public IntentFilter() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>New IntentFilter containing a copy of an existing filter.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public IntentFilter(string o) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>New IntentFilter that matches a single action and data type.</para> <para> <b>Note: MIME type matching in the Android framework is case-sensitive, unlike formal RFC MIME types. As a result, you should always write your MIME types with lower case letters, and any MIME types you receive from outside of Android should be converted to lower case before supplying them here.</b></para> <para>Throws MalformedMimeTypeException if the given MIME type is not syntactically correct.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public IntentFilter(string action, string dataType) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>New IntentFilter containing a copy of an existing filter.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/IntentFilter;)V", AccessFlags = 1)]
				public IntentFilter(global::Android.Content.IntentFilter o) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Create a new IntentFilter instance with a specified action and MIME type, where you know the MIME type is correctly formatted. This catches the MalformedMimeTypeException exception that the constructor can call and turns it into a runtime exception.</para> <para> <para>IntentFilter(String, String) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>A new IntentFilter for the given action and type.</para>
				/// </returns>
				/// <java-name>
				/// create
				/// </java-name>
				[Dot42.DexImport("create", "(Ljava/lang/String;Ljava/lang/String;)Landroid/content/IntentFilter;", AccessFlags = 9)]
				public static global::Android.Content.IntentFilter Create(string action, string dataType) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.IntentFilter);
				}

				/// <summary>
				///  <para>Add a new Intent action to match against. If any actions are included in the filter, then an Intent's action must be one of those values for it to match. If no actions are included, the Intent action is ignored.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// addAction
				/// </java-name>
				[Dot42.DexImport("addAction", "(Ljava/lang/String;)V", AccessFlags = 17)]
				public void AddAction(string action) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Return the number of actions in the filter. </para>        
				/// </summary>
				/// <java-name>
				/// countActions
				/// </java-name>
				[Dot42.DexImport("countActions", "()I", AccessFlags = 17)]
				public int CountActions() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Return an action in the filter. </para>        
				/// </summary>
				/// <java-name>
				/// getAction
				/// </java-name>
				[Dot42.DexImport("getAction", "(I)Ljava/lang/String;", AccessFlags = 17)]
				public string GetAction(int index) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Is the given action included in the filter? Note that if the filter does not include any actions, false will  <b>always</b> be returned.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>True if the action is explicitly mentioned in the filter. </para>
				/// </returns>
				/// <java-name>
				/// hasAction
				/// </java-name>
				[Dot42.DexImport("hasAction", "(Ljava/lang/String;)Z", AccessFlags = 17)]
				public bool HasAction(string action) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Match this filter against an Intent's action. If the filter does not specify any actions, the match will always fail.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>True if the action is listed in the filter. </para>
				/// </returns>
				/// <java-name>
				/// matchAction
				/// </java-name>
				[Dot42.DexImport("matchAction", "(Ljava/lang/String;)Z", AccessFlags = 17)]
				public bool MatchAction(string action) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Return an iterator over the filter's actions. If there are no actions, returns null. </para>        
				/// </summary>
				/// <java-name>
				/// actionsIterator
				/// </java-name>
				[Dot42.DexImport("actionsIterator", "()Ljava/util/Iterator;", AccessFlags = 17, Signature = "()Ljava/util/Iterator<Ljava/lang/String;>;")]
				public global::Java.Util.IIterator<string> ActionsIterator() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IIterator<string>);
				}

				/// <summary>
				///  <para>Add a new Intent data type to match against. If any types are included in the filter, then an Intent's data must be  <b>either</b> one of these types  <b>or</b> a matching scheme. If no data types are included, then an Intent will only match if it specifies no data.</para> <para> <b>Note: MIME type matching in the Android framework is case-sensitive, unlike formal RFC MIME types. As a result, you should always write your MIME types with lower case letters, and any MIME types you receive from outside of Android should be converted to lower case before supplying them here.</b></para> <para>Throws MalformedMimeTypeException if the given MIME type is not syntactically correct.</para> <para> <para>matchData </para></para>        
				/// </summary>
				/// <java-name>
				/// addDataType
				/// </java-name>
				[Dot42.DexImport("addDataType", "(Ljava/lang/String;)V", AccessFlags = 17)]
				public void AddDataType(string type) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Is the given data type included in the filter? Note that if the filter does not include any type, false will  <b>always</b> be returned.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>True if the type is explicitly mentioned in the filter. </para>
				/// </returns>
				/// <java-name>
				/// hasDataType
				/// </java-name>
				[Dot42.DexImport("hasDataType", "(Ljava/lang/String;)Z", AccessFlags = 17)]
				public bool HasDataType(string type) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Return the number of data types in the filter. </para>        
				/// </summary>
				/// <java-name>
				/// countDataTypes
				/// </java-name>
				[Dot42.DexImport("countDataTypes", "()I", AccessFlags = 17)]
				public int CountDataTypes() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Return a data type in the filter. </para>        
				/// </summary>
				/// <java-name>
				/// getDataType
				/// </java-name>
				[Dot42.DexImport("getDataType", "(I)Ljava/lang/String;", AccessFlags = 17)]
				public string GetDataType(int index) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Return an iterator over the filter's data types. </para>        
				/// </summary>
				/// <java-name>
				/// typesIterator
				/// </java-name>
				[Dot42.DexImport("typesIterator", "()Ljava/util/Iterator;", AccessFlags = 17, Signature = "()Ljava/util/Iterator<Ljava/lang/String;>;")]
				public global::Java.Util.IIterator<string> TypesIterator() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IIterator<string>);
				}

				/// <summary>
				///  <para>Add a new Intent data scheme to match against. If any schemes are included in the filter, then an Intent's data must be  <b>either</b> one of these schemes  <b>or</b> a matching data type. If no schemes are included, then an Intent will match only if it includes no data.</para> <para> <b>Note: scheme matching in the Android framework is case-sensitive, unlike formal RFC schemes. As a result, you should always write your schemes with lower case letters, and any schemes you receive from outside of Android should be converted to lower case before supplying them here.</b></para> <para> <para>matchData </para></para>        
				/// </summary>
				/// <java-name>
				/// addDataScheme
				/// </java-name>
				[Dot42.DexImport("addDataScheme", "(Ljava/lang/String;)V", AccessFlags = 17)]
				public void AddDataScheme(string scheme) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Return the number of data schemes in the filter. </para>        
				/// </summary>
				/// <java-name>
				/// countDataSchemes
				/// </java-name>
				[Dot42.DexImport("countDataSchemes", "()I", AccessFlags = 17)]
				public int CountDataSchemes() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Return a data scheme in the filter. </para>        
				/// </summary>
				/// <java-name>
				/// getDataScheme
				/// </java-name>
				[Dot42.DexImport("getDataScheme", "(I)Ljava/lang/String;", AccessFlags = 17)]
				public string GetDataScheme(int index) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Is the given data scheme included in the filter? Note that if the filter does not include any scheme, false will  <b>always</b> be returned.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>True if the scheme is explicitly mentioned in the filter. </para>
				/// </returns>
				/// <java-name>
				/// hasDataScheme
				/// </java-name>
				[Dot42.DexImport("hasDataScheme", "(Ljava/lang/String;)Z", AccessFlags = 17)]
				public bool HasDataScheme(string scheme) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Return an iterator over the filter's data schemes. </para>        
				/// </summary>
				/// <java-name>
				/// schemesIterator
				/// </java-name>
				[Dot42.DexImport("schemesIterator", "()Ljava/util/Iterator;", AccessFlags = 17, Signature = "()Ljava/util/Iterator<Ljava/lang/String;>;")]
				public global::Java.Util.IIterator<string> SchemesIterator() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IIterator<string>);
				}

				/// <summary>
				///  <para>Add a new Intent data authority to match against. The filter must include one or more schemes (via addDataScheme) for the authority to be considered. If any authorities are included in the filter, then an Intent's data must match one of them. If no authorities are included, then only the scheme must match.</para> <para> <b>Note: host name in the Android framework is case-sensitive, unlike formal RFC host names. As a result, you should always write your host names with lower case letters, and any host names you receive from outside of Android should be converted to lower case before supplying them here.</b></para> <para> <para>matchData </para> <para>addDataScheme </para></para>        
				/// </summary>
				/// <java-name>
				/// addDataAuthority
				/// </java-name>
				[Dot42.DexImport("addDataAuthority", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 17)]
				public void AddDataAuthority(string host, string port) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Return the number of data authorities in the filter. </para>        
				/// </summary>
				/// <java-name>
				/// countDataAuthorities
				/// </java-name>
				[Dot42.DexImport("countDataAuthorities", "()I", AccessFlags = 17)]
				public int CountDataAuthorities() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Return a data authority in the filter. </para>        
				/// </summary>
				/// <java-name>
				/// getDataAuthority
				/// </java-name>
				[Dot42.DexImport("getDataAuthority", "(I)Landroid/content/IntentFilter$AuthorityEntry;", AccessFlags = 17)]
				public global::Android.Content.IntentFilter.AuthorityEntry GetDataAuthority(int index) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.IntentFilter.AuthorityEntry);
				}

				/// <summary>
				///  <para>Is the given data authority included in the filter? Note that if the filter does not include any authorities, false will  <b>always</b> be returned.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns true if the data string matches an authority listed in the filter. </para>
				/// </returns>
				/// <java-name>
				/// hasDataAuthority
				/// </java-name>
				[Dot42.DexImport("hasDataAuthority", "(Landroid/net/Uri;)Z", AccessFlags = 17)]
				public bool HasDataAuthority(global::Android.Net.Uri data) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Return an iterator over the filter's data authorities. </para>        
				/// </summary>
				/// <java-name>
				/// authoritiesIterator
				/// </java-name>
				[Dot42.DexImport("authoritiesIterator", "()Ljava/util/Iterator;", AccessFlags = 17, Signature = "()Ljava/util/Iterator<Landroid/content/IntentFilter$AuthorityEntry;>;")]
				public global::Java.Util.IIterator<global::Android.Content.IntentFilter.AuthorityEntry> AuthoritiesIterator() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IIterator<global::Android.Content.IntentFilter.AuthorityEntry>);
				}

				/// <summary>
				///  <para>Add a new Intent data path to match against. The filter must include one or more schemes (via addDataScheme)  <b>and</b> one or more authorities (via addDataAuthority) for the path to be considered. If any paths are included in the filter, then an Intent's data must match one of them. If no paths are included, then only the scheme/authority must match.</para> <para>The path given here can either be a literal that must directly match or match against a prefix, or it can be a simple globbing pattern. If the latter, you can use '*' anywhere in the pattern to match zero or more instances of the previous character, '.' as a wildcard to match any character, and '\' to escape the next character.</para> <para> <para>matchData </para> <para>addDataScheme </para> <para>addDataAuthority </para></para>        
				/// </summary>
				/// <java-name>
				/// addDataPath
				/// </java-name>
				[Dot42.DexImport("addDataPath", "(Ljava/lang/String;I)V", AccessFlags = 17)]
				public void AddDataPath(string path, int type) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Return the number of data paths in the filter. </para>        
				/// </summary>
				/// <java-name>
				/// countDataPaths
				/// </java-name>
				[Dot42.DexImport("countDataPaths", "()I", AccessFlags = 17)]
				public int CountDataPaths() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Return a data path in the filter. </para>        
				/// </summary>
				/// <java-name>
				/// getDataPath
				/// </java-name>
				[Dot42.DexImport("getDataPath", "(I)Landroid/os/PatternMatcher;", AccessFlags = 17)]
				public global::Android.OS.PatternMatcher GetDataPath(int index) /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.PatternMatcher);
				}

				/// <summary>
				///  <para>Is the given data path included in the filter? Note that if the filter does not include any paths, false will  <b>always</b> be returned.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>True if the data string matches a path listed in the filter. </para>
				/// </returns>
				/// <java-name>
				/// hasDataPath
				/// </java-name>
				[Dot42.DexImport("hasDataPath", "(Ljava/lang/String;)Z", AccessFlags = 17)]
				public bool HasDataPath(string data) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Return an iterator over the filter's data paths. </para>        
				/// </summary>
				/// <java-name>
				/// pathsIterator
				/// </java-name>
				[Dot42.DexImport("pathsIterator", "()Ljava/util/Iterator;", AccessFlags = 17, Signature = "()Ljava/util/Iterator<Landroid/os/PatternMatcher;>;")]
				public global::Java.Util.IIterator<global::Android.OS.PatternMatcher> PathsIterator() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IIterator<global::Android.OS.PatternMatcher>);
				}

				/// <summary>
				///  <para>Match this intent filter against the given Intent data. This ignores the data scheme  unlike matchData, the authority will match regardless of whether there is a matching scheme.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns either MATCH_CATEGORY_HOST, MATCH_CATEGORY_PORT, NO_MATCH_DATA. </para>
				/// </returns>
				/// <java-name>
				/// matchDataAuthority
				/// </java-name>
				[Dot42.DexImport("matchDataAuthority", "(Landroid/net/Uri;)I", AccessFlags = 17)]
				public int MatchDataAuthority(global::Android.Net.Uri data) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Match this filter against an Intent's data (type, scheme and path). If the filter does not specify any types and does not specify any schemes/paths, the match will only succeed if the intent does not also specify a type or data. If the filter does not specify any schemes, it will implicitly match intents with no scheme, or the schemes "content:" or "file:" (basically performing a MIME-type only match). If the filter does not specify any MIME types, the Intent also must not specify a MIME type.</para> <para>Be aware that to match against an authority, you must also specify a base scheme the authority is in. To match against a data path, both a scheme and authority must be specified. If the filter does not specify any types or schemes that it matches against, it is considered to be empty (any authority or data path given is ignored, as if it were empty as well).</para> <para> <b>Note: MIME type, Uri scheme, and host name matching in the Android framework is case-sensitive, unlike the formal RFC definitions. As a result, you should always write these elements with lower case letters, and normalize any MIME types or Uris you receive from outside of Android to ensure these elements are lower case before supplying them here.</b></para> <para> <para>match </para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns either a valid match constant (a combination of MATCH_CATEGORY_MASK and MATCH_ADJUSTMENT_MASK), or one of the error codes NO_MATCH_TYPE if the type didn't match or NO_MATCH_DATA if the scheme/path didn't match.</para>
				/// </returns>
				/// <java-name>
				/// matchData
				/// </java-name>
				[Dot42.DexImport("matchData", "(Ljava/lang/String;Ljava/lang/String;Landroid/net/Uri;)I", AccessFlags = 17)]
				public int MatchData(string type, string scheme, global::Android.Net.Uri data) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Add a new Intent category to match against. The semantics of categories is the opposite of actions  an Intent includes the categories that it requires, all of which must be included in the filter in order to match. In other words, adding a category to the filter has no impact on matching unless that category is specified in the intent.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// addCategory
				/// </java-name>
				[Dot42.DexImport("addCategory", "(Ljava/lang/String;)V", AccessFlags = 17)]
				public void AddCategory(string category) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Return the number of categories in the filter. </para>        
				/// </summary>
				/// <java-name>
				/// countCategories
				/// </java-name>
				[Dot42.DexImport("countCategories", "()I", AccessFlags = 17)]
				public int CountCategories() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Return a category in the filter. </para>        
				/// </summary>
				/// <java-name>
				/// getCategory
				/// </java-name>
				[Dot42.DexImport("getCategory", "(I)Ljava/lang/String;", AccessFlags = 17)]
				public string GetCategory(int index) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Is the given category included in the filter?</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>True if the category is explicitly mentioned in the filter. </para>
				/// </returns>
				/// <java-name>
				/// hasCategory
				/// </java-name>
				[Dot42.DexImport("hasCategory", "(Ljava/lang/String;)Z", AccessFlags = 17)]
				public bool HasCategory(string category) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Return an iterator over the filter's categories.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Iterator if this filter has categories or <c>null </c> if none. </para>
				/// </returns>
				/// <java-name>
				/// categoriesIterator
				/// </java-name>
				[Dot42.DexImport("categoriesIterator", "()Ljava/util/Iterator;", AccessFlags = 17, Signature = "()Ljava/util/Iterator<Ljava/lang/String;>;")]
				public global::Java.Util.IIterator<string> CategoriesIterator() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IIterator<string>);
				}

				/// <summary>
				///  <para>Match this filter against an Intent's categories. Each category in the Intent must be specified by the filter; if any are not in the filter, the match fails.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>If all categories match (success), null; else the name of the first category that didn't match. </para>
				/// </returns>
				/// <java-name>
				/// matchCategories
				/// </java-name>
				[Dot42.DexImport("matchCategories", "(Ljava/util/Set;)Ljava/lang/String;", AccessFlags = 17, Signature = "(Ljava/util/Set<Ljava/lang/String;>;)Ljava/lang/String;")]
				public string MatchCategories(global::Java.Util.ISet<string> categories) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Test whether this filter matches the given  <b>intent</b>.</para> <para> <para>match(String, String, String, android.net.Uri , Set, String) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns either a valid match constant (a combination of MATCH_CATEGORY_MASK and MATCH_ADJUSTMENT_MASK), or one of the error codes NO_MATCH_TYPE if the type didn't match, NO_MATCH_DATA if the scheme/path didn't match, if the action didn't match, or  #NO_MATCH_CATEGORY if one or more categories didn't match.</para> <para>How well the filter matches. Negative if it doesn't match, zero or positive positive value if it does with a higher value representing a better match.</para>
				/// </returns>
				/// <java-name>
				/// match
				/// </java-name>
				[Dot42.DexImport("match", "(Landroid/content/ContentResolver;Landroid/content/Intent;ZLjava/lang/String;)I", AccessFlags = 17)]
				public int Match(global::Android.Content.ContentResolver resolver, global::Android.Content.Intent intent, bool resolve, string logTag) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Test whether this filter matches the given intent data. A match is only successful if the actions and categories in the Intent match against the filter, as described in IntentFilter; in that case, the match result returned will be as per matchData.</para> <para> <para>matchData </para> <para>Intent::getAction </para> <para>Intent::resolveType </para> <para>Intent::getScheme </para> <para>Intent::getData </para> <para>Intent::getCategories </para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns either a valid match constant (a combination of MATCH_CATEGORY_MASK and MATCH_ADJUSTMENT_MASK), or one of the error codes NO_MATCH_TYPE if the type didn't match, NO_MATCH_DATA if the scheme/path didn't match, if the action didn't match, or  #NO_MATCH_CATEGORY if one or more categories didn't match.</para>
				/// </returns>
				/// <java-name>
				/// match
				/// </java-name>
				[Dot42.DexImport("match", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Landroid/net/Uri;Ljava/uti" +
    "l/Set;Ljava/lang/String;)I", AccessFlags = 17, Signature = "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Landroid/net/Uri;Ljava/uti" +
    "l/Set<Ljava/lang/String;>;Ljava/lang/String;)I")]
				public int Match(string action, string type, string scheme, global::Android.Net.Uri data, global::Java.Util.ISet<string> categories, string logTag) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Write the contents of the IntentFilter as an XML stream. </para>        
				/// </summary>
				/// <java-name>
				/// writeToXml
				/// </java-name>
				[Dot42.DexImport("writeToXml", "(Lorg/xmlpull/v1/XmlSerializer;)V", AccessFlags = 1)]
				public virtual void WriteToXml(global::Org.Xmlpull.V1.IXmlSerializer serializer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// readFromXml
				/// </java-name>
				[Dot42.DexImport("readFromXml", "(Lorg/xmlpull/v1/XmlPullParser;)V", AccessFlags = 1)]
				public virtual void ReadFromXml(global::Org.Xmlpull.V1.IXmlPullParser parser) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// dump
				/// </java-name>
				[Dot42.DexImport("dump", "(Landroid/util/Printer;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void Dump(global::Android.Util.IPrinter du, string prefix) /* MethodBuilder.Create */ 
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
				[Dot42.DexImport("describeContents", "()I", AccessFlags = 17)]
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
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 17)]
				public void WriteToParcel(global::Android.OS.Parcel dest, int flags) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Return the priority of this filter.</para> <para> <para>setPriority </para></para>        
				/// </summary>
				/// <returns>
				///  <para>The priority of the filter.</para>
				/// </returns>
				/// <java-name>
				/// getPriority
				/// </java-name>
				public int Priority
				{
						[Dot42.DexImport("getPriority", "()I", AccessFlags = 17)]
						get{ return default(int); }
						[Dot42.DexImport("setPriority", "(I)V", AccessFlags = 17)]
						set{ }
				}

				/// <summary>
				///  <para>This is an entry for a single authority in the Iterator returned by authoritiesIterator(). </para>    
				/// </summary>
				/// <java-name>
				/// android/content/IntentFilter$AuthorityEntry
				/// </java-name>
				[Dot42.DexImport("android/content/IntentFilter$AuthorityEntry", AccessFlags = 25)]
				public sealed partial class AuthorityEntry
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
						public AuthorityEntry(string @string, string string1) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Determine whether this AuthorityEntry matches the given data Uri.  <b>Note that this comparison is case-sensitive, unlike formal RFC host names. You thus should always normalize to lower-case.</b></para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>Returns either IntentFilter#NO_MATCH_DATA, IntentFilter#MATCH_CATEGORY_PORT, or IntentFilter#MATCH_CATEGORY_HOST. </para>
						/// </returns>
						/// <java-name>
						/// match
						/// </java-name>
						[Dot42.DexImport("match", "(Landroid/net/Uri;)I", AccessFlags = 1)]
						public int Match(global::Android.Net.Uri data) /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						protected internal AuthorityEntry() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

						/// <java-name>
						/// getHost
						/// </java-name>
						public string Host
						{
								[Dot42.DexImport("getHost", "()Ljava/lang/String;", AccessFlags = 1)]
								get{ return default(string); }
						}

						/// <java-name>
						/// getPort
						/// </java-name>
						public int Port
						{
								[Dot42.DexImport("getPort", "()I", AccessFlags = 1)]
								get{ return default(int); }
						}

				}

				/// <summary>
				///  <para>This exception is thrown when a given MIME type does not have a valid syntax. </para>    
				/// </summary>
				/// <java-name>
				/// android/content/IntentFilter$MalformedMimeTypeException
				/// </java-name>
				[Dot42.DexImport("android/content/IntentFilter$MalformedMimeTypeException", AccessFlags = 9)]
				public partial class MalformedMimeTypeException : global::Android.Util.AndroidException
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public MalformedMimeTypeException() /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
						public MalformedMimeTypeException(string @string) /* MethodBuilder.Create */ 
						{
						}

				}

		}

		/// <summary>
		///  <para>A description of an Intent and target action to perform with it. The returned object can be handed to other applications so that they can perform the action you described on your behalf at a later time.</para> <para>By giving a IntentSender to another application, you are granting it the right to perform the operation you have specified as if the other application was yourself (with the same permissions and identity). As such, you should be careful about how you build the IntentSender: often, for example, the base Intent you supply will have the component name explicitly set to one of your own components, to ensure it is ultimately sent there and nowhere else.</para> <para>A IntentSender itself is simply a reference to a token maintained by the system describing the original data used to retrieve it. This means that, even if its owning application's process is killed, the IntentSender itself will remain usable from other processes that have been given it. If the creating application later re-retrieves the same kind of IntentSender (same operation, same Intent action, data, categories, and components, and same flags), it will receive a IntentSender representing the same token if that is still valid.</para> <para>Instances of this class can not be made directly, but rather must be created from an existing android.app.PendingIntent with PendingIntent.getIntentSender(). </para>    
		/// </summary>
		/// <java-name>
		/// android/content/IntentSender
		/// </java-name>
		[Dot42.DexImport("android/content/IntentSender", AccessFlags = 33)]
		public partial class IntentSender : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.Content.IntentSender> CREATOR;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal IntentSender() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Perform the operation associated with this IntentSender, allowing the caller to specify information about the Intent to use and be notified when the send has completed.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// sendIntent
				/// </java-name>
				[Dot42.DexImport("sendIntent", "(Landroid/content/Context;ILandroid/content/Intent;Landroid/content/IntentSender$" +
    "OnFinished;Landroid/os/Handler;)V", AccessFlags = 1)]
				public virtual void SendIntent(global::Android.Content.Context context, int code, global::Android.Content.Intent intent, global::Android.Content.IntentSender.IOnFinished onFinished, global::Android.OS.Handler handler) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Comparison operator on two IntentSender objects, such that true is returned then they both represent the same operation from the same package. </para>        
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

				/// <summary>
				///  <para>Convenience function for writing either a IntentSender or null pointer to a Parcel. You must use this with readIntentSenderOrNullFromParcel for later reading it.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// writeIntentSenderOrNullToParcel
				/// </java-name>
				[Dot42.DexImport("writeIntentSenderOrNullToParcel", "(Landroid/content/IntentSender;Landroid/os/Parcel;)V", AccessFlags = 9)]
				public static void WriteIntentSenderOrNullToParcel(global::Android.Content.IntentSender sender, global::Android.OS.Parcel @out) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Convenience function for reading either a Messenger or null pointer from a Parcel. You must have previously written the Messenger with writeIntentSenderOrNullToParcel.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns the Messenger read from the Parcel, or null if null had been written. </para>
				/// </returns>
				/// <java-name>
				/// readIntentSenderOrNullFromParcel
				/// </java-name>
				[Dot42.DexImport("readIntentSenderOrNullFromParcel", "(Landroid/os/Parcel;)Landroid/content/IntentSender;", AccessFlags = 9)]
				public static global::Android.Content.IntentSender ReadIntentSenderOrNullFromParcel(global::Android.OS.Parcel @in) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.IntentSender);
				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Renamed to getCreatorPackage(). </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// getTargetPackage
				/// </java-name>
				public virtual string TargetPackage
				{
						[Dot42.DexImport("getTargetPackage", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>Callback interface for discovering when a send operation has completed. Primarily for use with a IntentSender that is performing a broadcast, this provides the same information as calling String, android.content.BroadcastReceiver, Handler, int, String, Bundle) Context.sendBroadcast() with a final BroadcastReceiver. </para>    
				/// </summary>
				/// <java-name>
				/// android/content/IntentSender$OnFinished
				/// </java-name>
				[Dot42.DexImport("android/content/IntentSender$OnFinished", AccessFlags = 1545)]
				public partial interface IOnFinished
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>Called when a send operation as completed.</para> <para></para>        
						/// </summary>
						/// <java-name>
						/// onSendFinished
						/// </java-name>
						[Dot42.DexImport("onSendFinished", "(Landroid/content/IntentSender;Landroid/content/Intent;ILjava/lang/String;Landroi" +
    "d/os/Bundle;)V", AccessFlags = 1025)]
						void OnSendFinished(global::Android.Content.IntentSender IntentSender, global::Android.Content.Intent intent, int resultCode, string resultData, global::Android.OS.Bundle resultExtras) /* MethodBuilder.Create */ ;

				}

				/// <summary>
				///  <para>Exception thrown when trying to send through a PendingIntent that has been canceled or is otherwise no longer able to execute the request. </para>    
				/// </summary>
				/// <java-name>
				/// android/content/IntentSender$SendIntentException
				/// </java-name>
				[Dot42.DexImport("android/content/IntentSender$SendIntentException", AccessFlags = 9)]
				public partial class SendIntentException : global::Android.Util.AndroidException
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public SendIntentException() /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
						public SendIntentException(string @string) /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "(Ljava/lang/Exception;)V", AccessFlags = 1)]
						public SendIntentException(global::System.Exception exception) /* MethodBuilder.Create */ 
						{
						}

				}

		}

		/// <summary>
		///  <para>Interface for monitoring the state of an application service. See android.app.Service and Context.bindService() for more information. </para> <para>Like many callbacks from the system, the methods on this class are called from the main thread of your process. </para>    
		/// </summary>
		/// <java-name>
		/// android/content/ServiceConnection
		/// </java-name>
		[Dot42.DexImport("android/content/ServiceConnection", AccessFlags = 1537)]
		public partial interface IServiceConnection
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Called when a connection to the Service has been established, with the android.os.IBinder of the communication channel to the Service.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// onServiceConnected
				/// </java-name>
				[Dot42.DexImport("onServiceConnected", "(Landroid/content/ComponentName;Landroid/os/IBinder;)V", AccessFlags = 1025)]
				void OnServiceConnected(global::Android.Content.ComponentName name, global::Android.OS.IBinder service) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Called when a connection to the Service has been lost. This typically happens when the process hosting the service has crashed or been killed. This does  <b>not</b> remove the ServiceConnection itself  this binding to the service will remain active, and you will receive a call to onServiceConnected when the Service is next running.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// onServiceDisconnected
				/// </java-name>
				[Dot42.DexImport("onServiceDisconnected", "(Landroid/content/ComponentName;)V", AccessFlags = 1025)]
				void OnServiceDisconnected(global::Android.Content.ComponentName name) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		///  <para>Interface for accessing and modifying preference data returned by Context#getSharedPreferences. For any particular set of preferences, there is a single instance of this class that all clients share. Modifications to the preferences must go through an Editor object to ensure the preference values remain in a consistent state and control when they are committed to storage. Objects that are returned from the various  <code>get</code> methods must be treated as immutable by the application.</para> <para> <b>Note: currently this class does not support use across multiple processes. This will be added later.</b></para> <para>  <h3>Developer Guides</h3></para> <para> </para> <para>For more information about using SharedPreferences, read the  developer guide.</para> <para></para> <para> <para>Context::getSharedPreferences </para></para>    
		/// </summary>
		/// <java-name>
		/// android/content/SharedPreferences
		/// </java-name>
		[Dot42.DexImport("android/content/SharedPreferences", AccessFlags = 1537)]
		public partial interface ISharedPreferences
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Retrieve a String value from the preferences.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns the preference value if it exists, or defValue. Throws ClassCastException if there is a preference with this name that is not a String.</para>
				/// </returns>
				/// <java-name>
				/// getString
				/// </java-name>
				[Dot42.DexImport("getString", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1025)]
				string GetString(string key, string defValue) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Retrieve a set of String values from the preferences.</para> <para>Note that you  <b>must not</b> modify the set instance returned by this call. The consistency of the stored data is not guaranteed if you do, nor is your ability to modify the instance at all.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns the preference values if they exist, or defValues. Throws ClassCastException if there is a preference with this name that is not a Set.</para>
				/// </returns>
				/// <java-name>
				/// getStringSet
				/// </java-name>
				[Dot42.DexImport("getStringSet", "(Ljava/lang/String;Ljava/util/Set;)Ljava/util/Set;", AccessFlags = 1025, Signature = "(Ljava/lang/String;Ljava/util/Set<Ljava/lang/String;>;)Ljava/util/Set<Ljava/lang/" +
    "String;>;")]
				global::Java.Util.ISet<string> GetStringSet(string key, global::Java.Util.ISet<string> defValues) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Retrieve an int value from the preferences.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns the preference value if it exists, or defValue. Throws ClassCastException if there is a preference with this name that is not an int.</para>
				/// </returns>
				/// <java-name>
				/// getInt
				/// </java-name>
				[Dot42.DexImport("getInt", "(Ljava/lang/String;I)I", AccessFlags = 1025)]
				int GetInt(string key, int defValue) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Retrieve a long value from the preferences.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns the preference value if it exists, or defValue. Throws ClassCastException if there is a preference with this name that is not a long.</para>
				/// </returns>
				/// <java-name>
				/// getLong
				/// </java-name>
				[Dot42.DexImport("getLong", "(Ljava/lang/String;J)J", AccessFlags = 1025)]
				long GetLong(string key, long defValue) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Retrieve a float value from the preferences.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns the preference value if it exists, or defValue. Throws ClassCastException if there is a preference with this name that is not a float.</para>
				/// </returns>
				/// <java-name>
				/// getFloat
				/// </java-name>
				[Dot42.DexImport("getFloat", "(Ljava/lang/String;F)F", AccessFlags = 1025)]
				float GetFloat(string key, float defValue) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Retrieve a boolean value from the preferences.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns the preference value if it exists, or defValue. Throws ClassCastException if there is a preference with this name that is not a boolean.</para>
				/// </returns>
				/// <java-name>
				/// getBoolean
				/// </java-name>
				[Dot42.DexImport("getBoolean", "(Ljava/lang/String;Z)Z", AccessFlags = 1025)]
				bool GetBoolean(string key, bool defValue) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Checks whether the preferences contains a preference.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns true if the preference exists in the preferences, otherwise false. </para>
				/// </returns>
				/// <java-name>
				/// contains
				/// </java-name>
				[Dot42.DexImport("contains", "(Ljava/lang/String;)Z", AccessFlags = 1025)]
				bool Contains(string key) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Create a new Editor for these preferences, through which you can make modifications to the data in the preferences and atomically commit those changes back to the SharedPreferences object.</para> <para>Note that you  <b>must</b> call Editor#commit to have any changes you perform in the Editor actually show up in the SharedPreferences.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns a new instance of the Editor interface, allowing you to modify the values in this SharedPreferences object. </para>
				/// </returns>
				/// <java-name>
				/// edit
				/// </java-name>
				[Dot42.DexImport("edit", "()Landroid/content/SharedPreferences$Editor;", AccessFlags = 1025)]
				global::Android.Content.ISharedPreferences_IEditor Edit() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Registers a callback to be invoked when a change happens to a preference.</para> <para> <para>unregisterOnSharedPreferenceChangeListener </para></para>        
				/// </summary>
				/// <java-name>
				/// registerOnSharedPreferenceChangeListener
				/// </java-name>
				[Dot42.DexImport("registerOnSharedPreferenceChangeListener", "(Landroid/content/SharedPreferences$OnSharedPreferenceChangeListener;)V", AccessFlags = 1025)]
				void RegisterOnSharedPreferenceChangeListener(global::Android.Content.ISharedPreferences_IOnSharedPreferenceChangeListener listener) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Unregisters a previous callback.</para> <para> <para>registerOnSharedPreferenceChangeListener </para></para>        
				/// </summary>
				/// <java-name>
				/// unregisterOnSharedPreferenceChangeListener
				/// </java-name>
				[Dot42.DexImport("unregisterOnSharedPreferenceChangeListener", "(Landroid/content/SharedPreferences$OnSharedPreferenceChangeListener;)V", AccessFlags = 1025)]
				void UnregisterOnSharedPreferenceChangeListener(global::Android.Content.ISharedPreferences_IOnSharedPreferenceChangeListener listener) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Retrieve all values from the preferences.</para> <para>Note that you  <b>must not</b> modify the collection returned by this method, or alter any of its contents. The consistency of your stored data is not guaranteed if you do.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns a map containing a list of pairs key/value representing the preferences.</para>
				/// </returns>
				/// <java-name>
				/// getAll
				/// </java-name>
				global::Java.Util.IMap<string, object> All
				{
						[Dot42.DexImport("getAll", "()Ljava/util/Map;", AccessFlags = 1025, Signature = "()Ljava/util/Map<Ljava/lang/String;*>;")]
						get;
				}

		}

		/// <summary>
		///  <para>Interface used for modifying values in a SharedPreferences object. All changes you make in an editor are batched, and not copied back to the original SharedPreferences until you call commit or apply </para>    
		/// </summary>
		/// <java-name>
		/// android/content/SharedPreferences$Editor
		/// </java-name>
		[Dot42.DexImport("android/content/SharedPreferences$Editor", AccessFlags = 1545)]
		public partial interface ISharedPreferences_IEditor
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Set a String value in the preferences editor, to be written back once commit or apply are called.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns a reference to the same Editor object, so you can chain put calls together. </para>
				/// </returns>
				/// <java-name>
				/// putString
				/// </java-name>
				[Dot42.DexImport("putString", "(Ljava/lang/String;Ljava/lang/String;)Landroid/content/SharedPreferences$Editor;", AccessFlags = 1025)]
				global::Android.Content.ISharedPreferences_IEditor PutString(string key, string value) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Set a set of String values in the preferences editor, to be written back once commit is called.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns a reference to the same Editor object, so you can chain put calls together. </para>
				/// </returns>
				/// <java-name>
				/// putStringSet
				/// </java-name>
				[Dot42.DexImport("putStringSet", "(Ljava/lang/String;Ljava/util/Set;)Landroid/content/SharedPreferences$Editor;", AccessFlags = 1025, Signature = "(Ljava/lang/String;Ljava/util/Set<Ljava/lang/String;>;)Landroid/content/SharedPre" +
    "ferences$Editor;")]
				global::Android.Content.ISharedPreferences_IEditor PutStringSet(string key, global::Java.Util.ISet<string> values) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Set an int value in the preferences editor, to be written back once commit or apply are called.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns a reference to the same Editor object, so you can chain put calls together. </para>
				/// </returns>
				/// <java-name>
				/// putInt
				/// </java-name>
				[Dot42.DexImport("putInt", "(Ljava/lang/String;I)Landroid/content/SharedPreferences$Editor;", AccessFlags = 1025)]
				global::Android.Content.ISharedPreferences_IEditor PutInt(string key, int value) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Set a long value in the preferences editor, to be written back once commit or apply are called.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns a reference to the same Editor object, so you can chain put calls together. </para>
				/// </returns>
				/// <java-name>
				/// putLong
				/// </java-name>
				[Dot42.DexImport("putLong", "(Ljava/lang/String;J)Landroid/content/SharedPreferences$Editor;", AccessFlags = 1025)]
				global::Android.Content.ISharedPreferences_IEditor PutLong(string key, long value) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Set a float value in the preferences editor, to be written back once commit or apply are called.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns a reference to the same Editor object, so you can chain put calls together. </para>
				/// </returns>
				/// <java-name>
				/// putFloat
				/// </java-name>
				[Dot42.DexImport("putFloat", "(Ljava/lang/String;F)Landroid/content/SharedPreferences$Editor;", AccessFlags = 1025)]
				global::Android.Content.ISharedPreferences_IEditor PutFloat(string key, float value) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Set a boolean value in the preferences editor, to be written back once commit or apply are called.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns a reference to the same Editor object, so you can chain put calls together. </para>
				/// </returns>
				/// <java-name>
				/// putBoolean
				/// </java-name>
				[Dot42.DexImport("putBoolean", "(Ljava/lang/String;Z)Landroid/content/SharedPreferences$Editor;", AccessFlags = 1025)]
				global::Android.Content.ISharedPreferences_IEditor PutBoolean(string key, bool value) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Mark in the editor that a preference value should be removed, which will be done in the actual preferences once commit is called.</para> <para>Note that when committing back to the preferences, all removals are done first, regardless of whether you called remove before or after put methods on this editor.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns a reference to the same Editor object, so you can chain put calls together. </para>
				/// </returns>
				/// <java-name>
				/// remove
				/// </java-name>
				[Dot42.DexImport("remove", "(Ljava/lang/String;)Landroid/content/SharedPreferences$Editor;", AccessFlags = 1025)]
				global::Android.Content.ISharedPreferences_IEditor Remove(string key) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Mark in the editor to remove  <b>all</b> values from the preferences. Once commit is called, the only remaining preferences will be any that you have defined in this editor.</para> <para>Note that when committing back to the preferences, the clear is done first, regardless of whether you called clear before or after put methods on this editor.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns a reference to the same Editor object, so you can chain put calls together. </para>
				/// </returns>
				/// <java-name>
				/// clear
				/// </java-name>
				[Dot42.DexImport("clear", "()Landroid/content/SharedPreferences$Editor;", AccessFlags = 1025)]
				global::Android.Content.ISharedPreferences_IEditor Clear() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Commit your preferences changes back from this Editor to the SharedPreferences object it is editing. This atomically performs the requested modifications, replacing whatever is currently in the SharedPreferences.</para> <para>Note that when two editors are modifying preferences at the same time, the last one to call commit wins.</para> <para>If you don't care about the return value and you're using this from your application's main thread, consider using apply instead.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns true if the new values were successfully written to persistent storage. </para>
				/// </returns>
				/// <java-name>
				/// commit
				/// </java-name>
				[Dot42.DexImport("commit", "()Z", AccessFlags = 1025)]
				bool Commit() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Commit your preferences changes back from this Editor to the SharedPreferences object it is editing. This atomically performs the requested modifications, replacing whatever is currently in the SharedPreferences.</para> <para>Note that when two editors are modifying preferences at the same time, the last one to call apply wins.</para> <para>Unlike commit, which writes its preferences out to persistent storage synchronously, apply commits its changes to the in-memory SharedPreferences immediately but starts an asynchronous commit to disk and you won't be notified of any failures. If another editor on this SharedPreferences does a regular commit while a apply is still outstanding, the commit will block until all async commits are completed as well as the commit itself.</para> <para>As SharedPreferences instances are singletons within a process, it's safe to replace any instance of commit with apply if you were already ignoring the return value.</para> <para>You don't need to worry about Android component lifecycles and their interaction with  <code>apply()</code> writing to disk. The framework makes sure in-flight disk writes from  <code>apply()</code> complete before switching states.</para> <para>The SharedPreferences.Editor interface isn't expected to be implemented directly. However, if you previously did implement it and are now getting errors about missing  <code>apply()</code>, you can simply call commit from  <code>apply()</code>. </para>        
				/// </summary>
				/// <java-name>
				/// apply
				/// </java-name>
				[Dot42.DexImport("apply", "()V", AccessFlags = 1025)]
				void Apply() /* MethodBuilder.Create */ ;

		}

		/// <summary>
		///  <para>Interface definition for a callback to be invoked when a shared preference is changed. </para>    
		/// </summary>
		/// <java-name>
		/// android/content/SharedPreferences$OnSharedPreferenceChangeListener
		/// </java-name>
		[Dot42.DexImport("android/content/SharedPreferences$OnSharedPreferenceChangeListener", AccessFlags = 1545)]
		public partial interface ISharedPreferences_IOnSharedPreferenceChangeListener
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Called when a shared preference is changed, added, or removed. This may be called even if a preference is set to its existing value.</para> <para>This callback will be run on your main thread.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// onSharedPreferenceChanged
				/// </java-name>
				[Dot42.DexImport("onSharedPreferenceChanged", "(Landroid/content/SharedPreferences;Ljava/lang/String;)V", AccessFlags = 1025)]
				void OnSharedPreferenceChanged(global::Android.Content.ISharedPreferences sharedPreferences, string key) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// android/content/SyncStatusObserver
		/// </java-name>
		[Dot42.DexImport("android/content/SyncStatusObserver", AccessFlags = 1537)]
		public partial interface ISyncStatusObserver
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// onStatusChanged
				/// </java-name>
				[Dot42.DexImport("onStatusChanged", "(I)V", AccessFlags = 1025)]
				void OnStatusChanged(int which) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		///  <para>An abstract class that performs asynchronous loading of data. While Loaders are active they should monitor the source of their data and deliver new results when the contents change. See android.app.LoaderManager for more detail.</para> <para> <b>Note on threading:</b> Clients of loaders should as a rule perform any calls on to a Loader from the main thread of their process (that is, the thread the Activity callbacks and other things occur on). Subclasses of Loader (such as AsyncTaskLoader) will often perform their work in a separate thread, but when delivering their results this too should be done on the main thread.</para> <para>Subclasses generally must implement at least onStartLoading(), onStopLoading(), onForceLoad(), and onReset().</para> <para>Most implementations should not derive directly from this class, but instead inherit from AsyncTaskLoader.</para> <para>  <h3>Developer Guides</h3></para> <para> </para> <para>For more information about using loaders, read the  developer guide.</para> <para> </para> <para></para>    
		/// </summary>
		/// <java-name>
		/// android/content/Loader
		/// </java-name>
		[Dot42.DexImport("android/content/Loader", AccessFlags = 33, Signature = "<D:Ljava/lang/Object;>Ljava/lang/Object;")]
		public partial class Loader<D>
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Stores away the application context associated with context. Since Loaders can be used across multiple activities it's dangerous to store the context directly; always use getContext() to retrieve the Loader's Context, don't use the constructor argument directly. The Context returned by getContext is safe to use across Activity instances.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public Loader(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sends the result of the load to the registered listener. Should only be called by subclasses.</para> <para>Must be called from the process's main thread.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// deliverResult
				/// </java-name>
				[Dot42.DexImport("deliverResult", "(Ljava/lang/Object;)V", AccessFlags = 1, Signature = "(TD;)V")]
				public virtual void DeliverResult(D data) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Registers a class that will receive callbacks when a load is complete. The callback will be called on the process's main thread so it's safe to pass the results to widgets.</para> <para>Must be called from the process's main thread. </para>        
				/// </summary>
				/// <java-name>
				/// registerListener
				/// </java-name>
				[Dot42.DexImport("registerListener", "(ILandroid/content/Loader$OnLoadCompleteListener;)V", AccessFlags = 1, Signature = "(ILandroid/content/Loader$OnLoadCompleteListener<TD;>;)V")]
				public virtual void RegisterListener(int id, global::Android.Content.Loader<D>.IOnLoadCompleteListener<D> listener) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Remove a listener that was previously added with registerListener.</para> <para>Must be called from the process's main thread. </para>        
				/// </summary>
				/// <java-name>
				/// unregisterListener
				/// </java-name>
				[Dot42.DexImport("unregisterListener", "(Landroid/content/Loader$OnLoadCompleteListener;)V", AccessFlags = 1, Signature = "(Landroid/content/Loader$OnLoadCompleteListener<TD;>;)V")]
				public virtual void UnregisterListener(global::Android.Content.Loader<D>.IOnLoadCompleteListener<D> listener) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>This function will normally be called for you automatically by android.app.LoaderManager when the associated fragment/activity is being started. When using a Loader with android.app.LoaderManager, you  <b>must not</b> call this method yourself, or you will conflict with its management of the Loader.</para> <para>Starts an asynchronous load of the Loader's data. When the result is ready the callbacks will be called on the process's main thread. If a previous load has been completed and is still valid the result may be passed to the callbacks immediately. The loader will monitor the source of the data set and may deliver future callbacks if the source changes. Calling stopLoading will stop the delivery of callbacks.</para> <para>This updates the Loader's internal state so that isStarted() and isReset() will return the correct values, and then calls the implementation's onStartLoading().</para> <para>Must be called from the process's main thread. </para>        
				/// </summary>
				/// <java-name>
				/// startLoading
				/// </java-name>
				[Dot42.DexImport("startLoading", "()V", AccessFlags = 17)]
				public void StartLoading() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Subclasses must implement this to take care of loading their data, as per startLoading(). This is not called by clients directly, but as a result of a call to startLoading(). </para>        
				/// </summary>
				/// <java-name>
				/// onStartLoading
				/// </java-name>
				[Dot42.DexImport("onStartLoading", "()V", AccessFlags = 4)]
				protected internal virtual void OnStartLoading() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Force an asynchronous load. Unlike startLoading() this will ignore a previously loaded data set and load a new one. This simply calls through to the implementation's onForceLoad(). You generally should only call this when the loader is started  that is, isStarted() returns true.</para> <para>Must be called from the process's main thread. </para>        
				/// </summary>
				/// <java-name>
				/// forceLoad
				/// </java-name>
				[Dot42.DexImport("forceLoad", "()V", AccessFlags = 1)]
				public virtual void ForceLoad() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Subclasses must implement this to take care of requests to forceLoad(). This will always be called from the process's main thread. </para>        
				/// </summary>
				/// <java-name>
				/// onForceLoad
				/// </java-name>
				[Dot42.DexImport("onForceLoad", "()V", AccessFlags = 4)]
				protected internal virtual void OnForceLoad() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>This function will normally be called for you automatically by android.app.LoaderManager when the associated fragment/activity is being stopped. When using a Loader with android.app.LoaderManager, you  <b>must not</b> call this method yourself, or you will conflict with its management of the Loader.</para> <para>Stops delivery of updates until the next time startLoading() is called. Implementations should  <b>not</b> invalidate their data at this point  clients are still free to use the last data the loader reported. They will, however, typically stop reporting new data if the data changes; they can still monitor for changes, but must not report them to the client until and if startLoading() is later called.</para> <para>This updates the Loader's internal state so that isStarted() will return the correct value, and then calls the implementation's onStopLoading().</para> <para>Must be called from the process's main thread. </para>        
				/// </summary>
				/// <java-name>
				/// stopLoading
				/// </java-name>
				[Dot42.DexImport("stopLoading", "()V", AccessFlags = 1)]
				public virtual void StopLoading() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Subclasses must implement this to take care of stopping their loader, as per stopLoading(). This is not called by clients directly, but as a result of a call to stopLoading(). This will always be called from the process's main thread. </para>        
				/// </summary>
				/// <java-name>
				/// onStopLoading
				/// </java-name>
				[Dot42.DexImport("onStopLoading", "()V", AccessFlags = 4)]
				protected internal virtual void OnStopLoading() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>This function will normally be called for you automatically by android.app.LoaderManager when restarting a Loader. When using a Loader with android.app.LoaderManager, you  <b>must not</b> call this method yourself, or you will conflict with its management of the Loader.</para> <para>Tell the Loader that it is being abandoned. This is called prior to reset to have it retain its current data but not report any new data. </para>        
				/// </summary>
				/// <java-name>
				/// abandon
				/// </java-name>
				[Dot42.DexImport("abandon", "()V", AccessFlags = 1)]
				public virtual void Abandon() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Subclasses implement this to take care of being abandoned. This is an optional intermediate state prior to onReset()  it means that the client is no longer interested in any new data from the loader, so the loader must not report any further updates. However, the loader  <b>must</b> keep its last reported data valid until the final onReset() happens. You can retrieve the current abandoned state with isAbandoned. </para>        
				/// </summary>
				/// <java-name>
				/// onAbandon
				/// </java-name>
				[Dot42.DexImport("onAbandon", "()V", AccessFlags = 4)]
				protected internal virtual void OnAbandon() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>This function will normally be called for you automatically by android.app.LoaderManager when destroying a Loader. When using a Loader with android.app.LoaderManager, you  <b>must not</b> call this method yourself, or you will conflict with its management of the Loader.</para> <para>Resets the state of the Loader. The Loader should at this point free all of its resources, since it may never be called again; however, its startLoading() may later be called at which point it must be able to start running again.</para> <para>This updates the Loader's internal state so that isStarted() and isReset() will return the correct values, and then calls the implementation's onReset().</para> <para>Must be called from the process's main thread. </para>        
				/// </summary>
				/// <java-name>
				/// reset
				/// </java-name>
				[Dot42.DexImport("reset", "()V", AccessFlags = 1)]
				public virtual void Reset() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Subclasses must implement this to take care of resetting their loader, as per reset(). This is not called by clients directly, but as a result of a call to reset(). This will always be called from the process's main thread. </para>        
				/// </summary>
				/// <java-name>
				/// onReset
				/// </java-name>
				[Dot42.DexImport("onReset", "()V", AccessFlags = 4)]
				protected internal virtual void OnReset() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Take the current flag indicating whether the loader's content had changed while it was stopped. If it had, true is returned and the flag is cleared. </para>        
				/// </summary>
				/// <java-name>
				/// takeContentChanged
				/// </java-name>
				[Dot42.DexImport("takeContentChanged", "()Z", AccessFlags = 1)]
				public virtual bool TakeContentChanged() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Called when ForceLoadContentObserver detects a change. The default implementation checks to see if the loader is currently started; if so, it simply calls forceLoad(); otherwise, it sets a flag so that takeContentChanged() returns true.</para> <para>Must be called from the process's main thread. </para>        
				/// </summary>
				/// <java-name>
				/// onContentChanged
				/// </java-name>
				[Dot42.DexImport("onContentChanged", "()V", AccessFlags = 1)]
				public virtual void OnContentChanged() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>For debugging, converts an instance of the Loader's data class to a string that can be printed. Must handle a null data. </para>        
				/// </summary>
				/// <java-name>
				/// dataToString
				/// </java-name>
				[Dot42.DexImport("dataToString", "(Ljava/lang/Object;)Ljava/lang/String;", AccessFlags = 1, Signature = "(TD;)Ljava/lang/String;")]
				public virtual string DataToString(D data) /* MethodBuilder.Create */ 
				{
						return default(string);
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
				///  <para>Print the Loader's state into the given stream.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// dump
				/// </java-name>
				[Dot42.DexImport("dump", "(Ljava/lang/String;Ljava/io/FileDescriptor;Ljava/io/PrintWriter;[Ljava/lang/Strin" +
    "g;)V", AccessFlags = 1)]
				public virtual void Dump(string prefix, global::Java.IO.FileDescriptor fd, global::Java.IO.PrintWriter writer, string[] args) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal Loader() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>an application context retrieved from the Context passed to the constructor. </para>
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
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the ID of this loader </para>
				/// </returns>
				/// <java-name>
				/// getId
				/// </java-name>
				public virtual int Id
				{
						[Dot42.DexImport("getId", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Return whether this load has been started. That is, its startLoading() has been called and no calls to stopLoading() or reset() have yet been made. </para>        
				/// </summary>
				/// <java-name>
				/// isStarted
				/// </java-name>
				public virtual bool IsStarted
				{
						[Dot42.DexImport("isStarted", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Return whether this loader has been abandoned. In this state, the loader  <b>must not</b> report any new data, and  <b>must</b> keep its last reported data valid until it is finally reset. </para>        
				/// </summary>
				/// <java-name>
				/// isAbandoned
				/// </java-name>
				public virtual bool IsAbandoned
				{
						[Dot42.DexImport("isAbandoned", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Return whether this load has been reset. That is, either the loader has not yet been started for the first time, or its reset() has been called. </para>        
				/// </summary>
				/// <java-name>
				/// isReset
				/// </java-name>
				public virtual bool IsReset
				{
						[Dot42.DexImport("isReset", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Interface that is implemented to discover when a Loader has finished loading its data. You do not normally need to implement this yourself; it is used in the implementation of android.app.LoaderManager to find out when a Loader it is managing has completed so that this can be reported to its client. This interface should only be used if a Loader is not being used in conjunction with LoaderManager. </para>    
				/// </summary>
				/// <java-name>
				/// android/content/Loader$OnLoadCompleteListener
				/// </java-name>
				[Dot42.DexImport("android/content/Loader$OnLoadCompleteListener", AccessFlags = 1545, Signature = "<D:Ljava/lang/Object;>Ljava/lang/Object;")]
				public partial interface IOnLoadCompleteListener<D>
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>Called on the thread that created the Loader when the load is complete.</para> <para></para>        
						/// </summary>
						/// <java-name>
						/// onLoadComplete
						/// </java-name>
						[Dot42.DexImport("onLoadComplete", "(Landroid/content/Loader;Ljava/lang/Object;)V", AccessFlags = 1025, Signature = "(Landroid/content/Loader<TD;>;TD;)V")]
						void OnLoadComplete(global::Android.Content.Loader<D> loader, D data) /* MethodBuilder.Create */ ;

				}

				/// <summary>
				///  <para>An implementation of a ContentObserver that takes care of connecting it to the Loader to have the loader re-load its data when the observer is told it has changed. You do not normally need to use this yourself; it is used for you by CursorLoader to take care of executing an update when the cursor's backing data changes. </para>    
				/// </summary>
				/// <java-name>
				/// android/content/Loader$ForceLoadContentObserver
				/// </java-name>
				[Dot42.DexImport("android/content/Loader$ForceLoadContentObserver", AccessFlags = 17)]
				public sealed partial class ForceLoadContentObserver : global::Android.Database.ContentObserver
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// this$0
						/// </java-name>
						[Dot42.DexImport("this$0", "Landroid/content/Loader;", AccessFlags = 4112)]
						internal readonly global::Android.Content.Loader<object> This_0;
						[Dot42.DexImport("<init>", "(Landroid/content/Loader;)V", AccessFlags = 1)]
						public ForceLoadContentObserver(global::Android.Content.Loader<object> loader) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// deliverSelfNotifications
						/// </java-name>
						[Dot42.DexImport("deliverSelfNotifications", "()Z", AccessFlags = 1)]
						public override bool DeliverSelfNotifications() /* MethodBuilder.Create */ 
						{
								return default(bool);
						}

						/// <java-name>
						/// onChange
						/// </java-name>
						[Dot42.DexImport("onChange", "(Z)V", AccessFlags = 1)]
						public override void OnChange(bool selfChange) /* MethodBuilder.Create */ 
						{
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						protected internal ForceLoadContentObserver() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

				}

		}

		/// <summary>
		///  <para>Special version of ContextWrapper that allows the base context to be modified after it is initially set. </para>    
		/// </summary>
		/// <java-name>
		/// android/content/MutableContextWrapper
		/// </java-name>
		[Dot42.DexImport("android/content/MutableContextWrapper", AccessFlags = 33)]
		public partial class MutableContextWrapper : global::Android.Content.ContextWrapper
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public MutableContextWrapper(global::Android.Content.Context @base) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Change the base context for this ContextWrapper. All calls will then be delegated to the base context. Unlike ContextWrapper, the base context can be changed even after one is already set.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setBaseContext
				/// </java-name>
				[Dot42.DexImport("setBaseContext", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public virtual void SetBaseContext(global::Android.Content.Context @base) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal MutableContextWrapper() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		///  <para>Thrown when an application of a ContentProviderOperation fails due the specified constraints. </para>    
		/// </summary>
		/// <java-name>
		/// android/content/OperationApplicationException
		/// </java-name>
		[Dot42.DexImport("android/content/OperationApplicationException", AccessFlags = 33)]
		public partial class OperationApplicationException : global::System.Exception
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public OperationApplicationException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public OperationApplicationException(string numSuccessfulYieldPoints) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public OperationApplicationException(string @string, global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public OperationApplicationException(global::System.Exception numSuccessfulYieldPoints) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public OperationApplicationException(int numSuccessfulYieldPoints) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;I)V", AccessFlags = 1)]
				public OperationApplicationException(string @string, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getNumSuccessfulYieldPoints
				/// </java-name>
				public virtual int NumSuccessfulYieldPoints
				{
						[Dot42.DexImport("getNumSuccessfulYieldPoints", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

		}

		/// <summary>
		///  <para>Value type that contains information about a periodic sync. </para>    
		/// </summary>
		/// <java-name>
		/// android/content/PeriodicSync
		/// </java-name>
		[Dot42.DexImport("android/content/PeriodicSync", AccessFlags = 33)]
		public partial class PeriodicSync : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>The account to be synced. Can be null. </para>        
				/// </summary>
				/// <java-name>
				/// account
				/// </java-name>
				[Dot42.DexImport("account", "Landroid/accounts/Account;", AccessFlags = 17)]
				public readonly global::Android.Accounts.Account Account;
				/// <summary>
				///  <para>The authority of the sync. Can be null. </para>        
				/// </summary>
				/// <java-name>
				/// authority
				/// </java-name>
				[Dot42.DexImport("authority", "Ljava/lang/String;", AccessFlags = 17)]
				public readonly string Authority;
				/// <summary>
				///  <para>Any extras that parameters that are to be passed to the sync adapter. </para>        
				/// </summary>
				/// <java-name>
				/// extras
				/// </java-name>
				[Dot42.DexImport("extras", "Landroid/os/Bundle;", AccessFlags = 17)]
				public readonly global::Android.OS.Bundle Extras;
				/// <summary>
				///  <para>How frequently the sync should be scheduled, in seconds. Kept around for API purposes. </para>        
				/// </summary>
				/// <java-name>
				/// period
				/// </java-name>
				[Dot42.DexImport("period", "J", AccessFlags = 17)]
				public readonly long Period;
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.Content.PeriodicSync> CREATOR;
				/// <summary>
				///  <para>Creates a new PeriodicSync, copying the Bundle. SM no longer uses this ctor - kept around becuse it is part of the API. Note - even calls to the old API will not use this ctor, as they are given a default flex time. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/accounts/Account;Ljava/lang/String;Landroid/os/Bundle;J)V", AccessFlags = 1)]
				public PeriodicSync(global::Android.Accounts.Account account, string authority, global::Android.OS.Bundle extras, long periodInSeconds) /* MethodBuilder.Create */ 
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
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object o) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal PeriodicSync() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		///  <para>This exception is thrown from Context#registerReceiver and Context#bindService when these methods are being used from an BroadcastReceiver component. In this case, the component will no longer be active upon returning from receiving the Intent, so it is not valid to use asynchronous APIs. </para>    
		/// </summary>
		/// <java-name>
		/// android/content/ReceiverCallNotAllowedException
		/// </java-name>
		[Dot42.DexImport("android/content/ReceiverCallNotAllowedException", AccessFlags = 33)]
		public partial class ReceiverCallNotAllowedException : global::Android.Util.AndroidRuntimeException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public ReceiverCallNotAllowedException(string msg) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal ReceiverCallNotAllowedException() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		///  <para>This superclass can be used to create a simple search suggestions provider for your application. It creates suggestions (as the user types) based on recent queries and/or recent views.</para> <para>In order to use this class, you must do the following.</para> <para> <ul> <li> <para>Implement and test query search, as described in android.app.SearchManager. (This provider will send any suggested queries via the standard ACTION_SEARCH Intent, which you'll already support once you have implemented and tested basic searchability.) </para></li> <li> <para>Create a Content Provider within your application by extending android.content.SearchRecentSuggestionsProvider. The class you create will be very simple - typically, it will have only a constructor. But the constructor has a very important responsibility: When it calls setupSuggestions(String, int), it  <b>configures</b> the provider to match the requirements of your searchable activity. </para></li> <li> <para>Create a manifest entry describing your provider. Typically this would be as simple as adding the following lines:  <pre>
		///     &lt;!-- Content provider for search suggestions --&gt;
		///     &lt;provider android:name="YourSuggestionProviderClass"
		///               android:authorities="your.suggestion.authority" /&gt;</pre>  </para></li> <li> <para>Please note that you  <b>do not</b> instantiate this content provider directly from within your code. This is done automatically by the system Content Resolver, when the search dialog looks for suggestions. </para></li> <li> <para>In order for the Content Resolver to do this, you must update your searchable activity's XML configuration file with information about your content provider. The following additions are usually sufficient:  <pre>
		///     android:searchSuggestAuthority="your.suggestion.authority"
		///     android:searchSuggestSelection=" ? "</pre>  </para></li> <li> <para>In your searchable activities, capture any user-generated queries and record them for future searches by calling SearchRecentSuggestions.saveRecentQuery(). </para></li></ul></para> <para>  <h3>Developer Guides</h3></para> <para> </para> <para>For information about using search suggestions in your application, read the  developer guide.</para> <para> </para> <para> <para>android.provider.SearchRecentSuggestions </para></para>    
		/// </summary>
		/// <java-name>
		/// android/content/SearchRecentSuggestionsProvider
		/// </java-name>
		[Dot42.DexImport("android/content/SearchRecentSuggestionsProvider", AccessFlags = 33)]
		public partial class SearchRecentSuggestionsProvider : global::Android.Content.ContentProvider
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>This mode bit configures the database to record recent queries.  <b>required</b></para> <para> <para>setupSuggestions(String, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// DATABASE_MODE_QUERIES
				/// </java-name>
				[Dot42.DexImport("DATABASE_MODE_QUERIES", "I", AccessFlags = 25)]
				public const int DATABASE_MODE_QUERIES = 1;
				/// <summary>
				///  <para>This mode bit configures the database to include a 2nd annotation line with each entry.  <b>optional</b></para> <para> <para>setupSuggestions(String, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// DATABASE_MODE_2LINES
				/// </java-name>
				[Dot42.DexImport("DATABASE_MODE_2LINES", "I", AccessFlags = 25)]
				public const int DATABASE_MODE_2LINES = 2;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public SearchRecentSuggestionsProvider() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>In order to use this class, you must extend it, and call this setup function from your constructor. In your application or activities, you must provide the same values when you create the android.provider.SearchRecentSuggestions helper.</para> <para> <para>DATABASE_MODE_QUERIES </para> <para>DATABASE_MODE_2LINES </para></para>        
				/// </summary>
				/// <java-name>
				/// setupSuggestions
				/// </java-name>
				[Dot42.DexImport("setupSuggestions", "(Ljava/lang/String;I)V", AccessFlags = 4)]
				protected internal virtual void SetupSuggestions(string authority, int mode) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>This method is provided for use by the ContentResolver. Do not override, or directly call from your own code. </para>        
				/// </summary>
				/// <java-name>
				/// delete
				/// </java-name>
				[Dot42.DexImport("delete", "(Landroid/net/Uri;Ljava/lang/String;[Ljava/lang/String;)I", AccessFlags = 1)]
				public override int Delete(global::Android.Net.Uri uri, string selection, string[] selectionArgs) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>This method is provided for use by the ContentResolver. Do not override, or directly call from your own code. </para>        
				/// </summary>
				/// <java-name>
				/// getType
				/// </java-name>
				[Dot42.DexImport("getType", "(Landroid/net/Uri;)Ljava/lang/String;", AccessFlags = 1)]
				public override string GetType(global::Android.Net.Uri uri) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>This method is provided for use by the ContentResolver. Do not override, or directly call from your own code. </para>        
				/// </summary>
				/// <java-name>
				/// insert
				/// </java-name>
				[Dot42.DexImport("insert", "(Landroid/net/Uri;Landroid/content/ContentValues;)Landroid/net/Uri;", AccessFlags = 1)]
				public override global::Android.Net.Uri Insert(global::Android.Net.Uri uri, global::Android.Content.ContentValues values) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Net.Uri);
				}

				/// <summary>
				///  <para>This method is provided for use by the ContentResolver. Do not override, or directly call from your own code. </para>        
				/// </summary>
				/// <java-name>
				/// onCreate
				/// </java-name>
				[Dot42.DexImport("onCreate", "()Z", AccessFlags = 1)]
				public override bool OnCreate() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>This method is provided for use by the ContentResolver. Do not override, or directly call from your own code. </para>        
				/// </summary>
				/// <java-name>
				/// query
				/// </java-name>
				[Dot42.DexImport("query", "(Landroid/net/Uri;[Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/l" +
    "ang/String;)Landroid/database/Cursor;", AccessFlags = 1)]
				public override global::Android.Database.ICursor Query(global::Android.Net.Uri uri, string[] projection, string selection, string[] selectionArgs, string sortOrder) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Database.ICursor);
				}

				/// <summary>
				///  <para>This method is provided for use by the ContentResolver. Do not override, or directly call from your own code. </para>        
				/// </summary>
				/// <java-name>
				/// update
				/// </java-name>
				[Dot42.DexImport("update", "(Landroid/net/Uri;Landroid/content/ContentValues;Ljava/lang/String;[Ljava/lang/St" +
    "ring;)I", AccessFlags = 1)]
				public override int Update(global::Android.Net.Uri uri, global::Android.Content.ContentValues values, string selection, string[] selectionArgs) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

		}

		/// <summary>
		///  <para>Value type that represents a SyncAdapterType. This object overrides equals and hashCode, making it suitable for use as the key of a java.util.Map </para>    
		/// </summary>
		/// <java-name>
		/// android/content/SyncAdapterType
		/// </java-name>
		[Dot42.DexImport("android/content/SyncAdapterType", AccessFlags = 33)]
		public partial class SyncAdapterType : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// authority
				/// </java-name>
				[Dot42.DexImport("authority", "Ljava/lang/String;", AccessFlags = 17)]
				public readonly string Authority;
				/// <java-name>
				/// accountType
				/// </java-name>
				[Dot42.DexImport("accountType", "Ljava/lang/String;", AccessFlags = 17)]
				public readonly string AccountType;
				/// <java-name>
				/// isKey
				/// </java-name>
				[Dot42.DexImport("isKey", "Z", AccessFlags = 17)]
				public readonly bool IsKey;
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.Content.SyncAdapterType> CREATOR;
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;ZZ)V", AccessFlags = 1)]
				public SyncAdapterType(string authority, string accountType, bool userVisible, bool supportsUploading) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/os/Parcel;)V", AccessFlags = 1)]
				public SyncAdapterType(global::Android.OS.Parcel source) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// supportsUploading
				/// </java-name>
				[Dot42.DexImport("supportsUploading", "()Z", AccessFlags = 1)]
				public virtual bool SupportsUploading() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>True if this SyncAdapter supports syncing multiple accounts simultaneously. If false then the SyncManager will take care to only start one sync at a time using this SyncAdapter. </para>
				/// </returns>
				/// <java-name>
				/// allowParallelSyncs
				/// </java-name>
				[Dot42.DexImport("allowParallelSyncs", "()Z", AccessFlags = 1)]
				public virtual bool AllowParallelSyncs() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// newKey
				/// </java-name>
				[Dot42.DexImport("newKey", "(Ljava/lang/String;Ljava/lang/String;)Landroid/content/SyncAdapterType;", AccessFlags = 9)]
				public static global::Android.Content.SyncAdapterType NewKey(string authority, string accountType) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.SyncAdapterType);
				}

				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object o) /* MethodBuilder.Create */ 
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

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal SyncAdapterType() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// isUserVisible
				/// </java-name>
				public virtual bool IsUserVisible
				{
						[Dot42.DexImport("isUserVisible", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>If true then the SyncManager will never issue an initialization sync to the SyncAdapter and will instead automatically call ContentResolver#setIsSyncable(android.accounts.Account, String, int) with a value of 1 for each account and provider that this sync adapter supports. </para>        
				/// </summary>
				/// <returns>
				///  <para>true if the SyncAdapter does not require initialization and if it is ok for the SyncAdapter to treat it as syncable automatically. </para>
				/// </returns>
				/// <java-name>
				/// isAlwaysSyncable
				/// </java-name>
				public virtual bool IsAlwaysSyncable
				{
						[Dot42.DexImport("isAlwaysSyncable", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

		}

		/// <java-name>
		/// android/content/SyncContext
		/// </java-name>
		[Dot42.DexImport("android/content/SyncContext", AccessFlags = 33)]
		public partial class SyncContext
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal SyncContext() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onFinished
				/// </java-name>
				[Dot42.DexImport("onFinished", "(Landroid/content/SyncResult;)V", AccessFlags = 1)]
				public virtual void OnFinished(global::Android.Content.SyncResult result) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getSyncContextBinder
				/// </java-name>
				public virtual global::Android.OS.IBinder SyncContextBinder
				{
						[Dot42.DexImport("getSyncContextBinder", "()Landroid/os/IBinder;", AccessFlags = 1)]
						get{ return default(global::Android.OS.IBinder); }
				}

		}

		/// <summary>
		///  <para>Information about the sync operation that is currently underway. </para>    
		/// </summary>
		/// <java-name>
		/// android/content/SyncInfo
		/// </java-name>
		[Dot42.DexImport("android/content/SyncInfo", AccessFlags = 33)]
		public partial class SyncInfo : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>The Account that is currently being synced. </para>        
				/// </summary>
				/// <java-name>
				/// account
				/// </java-name>
				[Dot42.DexImport("account", "Landroid/accounts/Account;", AccessFlags = 17)]
				public readonly global::Android.Accounts.Account Account;
				/// <summary>
				///  <para>The authority of the provider that is currently being synced. </para>        
				/// </summary>
				/// <java-name>
				/// authority
				/// </java-name>
				[Dot42.DexImport("authority", "Ljava/lang/String;", AccessFlags = 17)]
				public readonly string Authority;
				/// <summary>
				///  <para>The start time of the current sync operation in milliseconds since boot. This is represented in elapsed real time. See android.os.SystemClock#elapsedRealtime(). </para>        
				/// </summary>
				/// <java-name>
				/// startTime
				/// </java-name>
				[Dot42.DexImport("startTime", "J", AccessFlags = 17)]
				public readonly long StartTime;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal SyncInfo() /* MethodBuilder.Create */ 
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
				public virtual void WriteToParcel(global::Android.OS.Parcel parcel, int flags) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>This class is used to communicate the results of a sync operation to the SyncManager. Based on the values here the SyncManager will determine the disposition of the sync and whether or not a new sync operation needs to be scheduled in the future. </para>    
		/// </summary>
		/// <java-name>
		/// android/content/SyncResult
		/// </java-name>
		[Dot42.DexImport("android/content/SyncResult", AccessFlags = 49)]
		public sealed partial class SyncResult : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Used to indicate that the SyncAdapter is already performing a sync operation, though not necessarily for the requested account and authority and that it wasn't able to process this request. The SyncManager will reschedule the request to run later. </para>        
				/// </summary>
				/// <java-name>
				/// syncAlreadyInProgress
				/// </java-name>
				[Dot42.DexImport("syncAlreadyInProgress", "Z", AccessFlags = 17)]
				public readonly bool SyncAlreadyInProgress;
				/// <summary>
				///  <para>Used to indicate that the SyncAdapter determined that it would need to issue too many delete operations to the server in order to satisfy the request (as defined by the SyncAdapter). The SyncManager will record that the sync request failed and will cause a System Notification to be created asking the user what they want to do about this. It will give the user a chance to choose between (1) go ahead even with those deletes, (2) revert the deletes, or (3) take no action. If the user decides (1) or (2) the SyncManager will issue another sync request with either ContentResolver#SYNC_EXTRAS_OVERRIDE_TOO_MANY_DELETIONS or ContentResolver#SYNC_EXTRAS_DISCARD_LOCAL_DELETIONS set in the extras. It is then up to the SyncAdapter to decide how to honor that request. </para>        
				/// </summary>
				/// <java-name>
				/// tooManyDeletions
				/// </java-name>
				[Dot42.DexImport("tooManyDeletions", "Z", AccessFlags = 1)]
				public bool TooManyDeletions;
				/// <summary>
				///  <para>Used to indicate that the SyncAdapter experienced a hard error due to trying the same operation too many times (as defined by the SyncAdapter). The SyncManager will record that the sync request failed and it will not reschedule the request. </para>        
				/// </summary>
				/// <java-name>
				/// tooManyRetries
				/// </java-name>
				[Dot42.DexImport("tooManyRetries", "Z", AccessFlags = 1)]
				public bool TooManyRetries;
				/// <summary>
				///  <para>Used to indicate that the SyncAdapter experienced a hard error due to an error it received from interacting with the storage layer. The SyncManager will record that the sync request failed and it will not reschedule the request. </para>        
				/// </summary>
				/// <java-name>
				/// databaseError
				/// </java-name>
				[Dot42.DexImport("databaseError", "Z", AccessFlags = 1)]
				public bool DatabaseError;
				/// <summary>
				///  <para>If set the SyncManager will request an immediate sync with the same Account and authority (but empty extras Bundle) as was used in the sync request. </para>        
				/// </summary>
				/// <java-name>
				/// fullSyncRequested
				/// </java-name>
				[Dot42.DexImport("fullSyncRequested", "Z", AccessFlags = 1)]
				public bool FullSyncRequested;
				/// <summary>
				///  <para>This field is ignored by the SyncManager. </para>        
				/// </summary>
				/// <java-name>
				/// partialSyncUnavailable
				/// </java-name>
				[Dot42.DexImport("partialSyncUnavailable", "Z", AccessFlags = 1)]
				public bool PartialSyncUnavailable;
				/// <summary>
				///  <para>This field is ignored by the SyncManager. </para>        
				/// </summary>
				/// <java-name>
				/// moreRecordsToGet
				/// </java-name>
				[Dot42.DexImport("moreRecordsToGet", "Z", AccessFlags = 1)]
				public bool MoreRecordsToGet;
				/// <summary>
				///  <para>Used to indicate to the SyncManager that future sync requests that match the request's Account and authority should be delayed at least this many seconds. </para>        
				/// </summary>
				/// <java-name>
				/// delayUntil
				/// </java-name>
				[Dot42.DexImport("delayUntil", "J", AccessFlags = 1)]
				public long DelayUntil;
				/// <summary>
				///  <para>Used to hold extras statistics about the sync operation. Some of these indicate that the sync request resulted in a hard or soft error, others are for purely informational purposes. </para>        
				/// </summary>
				/// <java-name>
				/// stats
				/// </java-name>
				[Dot42.DexImport("stats", "Landroid/content/SyncStats;", AccessFlags = 17)]
				public readonly global::Android.Content.SyncStats Stats;
				/// <summary>
				///  <para>This instance of a SyncResult is returned by the SyncAdapter in response to a sync request when a sync is already underway. The SyncManager will reschedule the sync request to try again later. </para>        
				/// </summary>
				/// <java-name>
				/// ALREADY_IN_PROGRESS
				/// </java-name>
				[Dot42.DexImport("ALREADY_IN_PROGRESS", "Landroid/content/SyncResult;", AccessFlags = 25)]
				public static readonly global::Android.Content.SyncResult ALREADY_IN_PROGRESS;
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.Content.SyncResult> CREATOR;
				/// <summary>
				///  <para>Create a "clean" SyncResult. If this is returned without any changes then the SyncManager will consider the sync to have completed successfully. The various fields can be set by the SyncAdapter in order to give the SyncManager more information as to the disposition of the sync. </para> <para>The errors are classified into two broad categories: hard errors and soft errors. Soft errors are retried with exponential backoff. Hard errors are not retried (except when the hard error is for a ContentResolver#SYNC_EXTRAS_UPLOAD request, in which the request is retryed without the ContentResolver#SYNC_EXTRAS_UPLOAD extra set). The SyncManager checks the type of error by calling SyncResult#hasHardError() and SyncResult#hasSoftError(). If both are true then the SyncManager treats it as a hard error, not a soft error. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public SyncResult() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Convenience method for determining if the Sync should be rescheduled after failing for some reason. </para>        
				/// </summary>
				/// <returns>
				///  <para>true if the SyncManager should reschedule this sync. </para>
				/// </returns>
				/// <java-name>
				/// madeSomeProgress
				/// </java-name>
				[Dot42.DexImport("madeSomeProgress", "()Z", AccessFlags = 1)]
				public bool MadeSomeProgress() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Clears the SyncResult to a clean state. Throws an UnsupportedOperationException if this is called when syncAlreadyInProgress is set. </para>        
				/// </summary>
				/// <java-name>
				/// clear
				/// </java-name>
				[Dot42.DexImport("clear", "()V", AccessFlags = 1)]
				public void Clear() /* MethodBuilder.Create */ 
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

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Generates a debugging string indicating the status. The string consist of a sequence of code letter followed by the count. Code letters are f - fullSyncRequested, r - partialSyncUnavailable, X - hardError, e - numParseExceptions, c - numConflictDetectedExceptions, a - numAuthExceptions, D - tooManyDeletions, R - tooManyRetries, b - databaseError, x - softError, l - syncAlreadyInProgress, I - numIoExceptions </para>        
				/// </summary>
				/// <returns>
				///  <para>debugging string. </para>
				/// </returns>
				/// <java-name>
				/// toDebugString
				/// </java-name>
				[Dot42.DexImport("toDebugString", "()Ljava/lang/String;", AccessFlags = 1)]
				public string ToDebugString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Convenience method for determining if the SyncResult indicates that a hard error occurred. See SyncResult() for an explanation of what the SyncManager does when it sees a hard error. </para> <para>A hard error is indicated when any of the following is true:  <ul> <li> <para>SyncStats#numParseExceptions &gt; 0 </para></li> <li> <para>SyncStats#numConflictDetectedExceptions &gt; 0 </para></li> <li> <para>SyncStats#numAuthExceptions &gt; 0 </para></li> <li> <para>tooManyDeletions </para></li> <li> <para>tooManyRetries </para></li> <li> <para>databaseError </para></li></ul></para>        
				/// </summary>
				/// <returns>
				///  <para>true if a hard error is indicated </para>
				/// </returns>
				/// <java-name>
				/// hasHardError
				/// </java-name>
				public bool HasHardError
				{
						[Dot42.DexImport("hasHardError", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Convenience method for determining if the SyncResult indicates that a soft error occurred. See SyncResult() for an explanation of what the SyncManager does when it sees a soft error. </para> <para>A soft error is indicated when any of the following is true:  <ul> <li> <para>SyncStats#numIoExceptions &gt; 0 </para></li> <li> <para>syncAlreadyInProgress </para></li></ul></para>        
				/// </summary>
				/// <returns>
				///  <para>true if a soft error is indicated </para>
				/// </returns>
				/// <java-name>
				/// hasSoftError
				/// </java-name>
				public bool HasSoftError
				{
						[Dot42.DexImport("hasSoftError", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>A convenience method for determining of the SyncResult indicates that an error occurred. </para>        
				/// </summary>
				/// <returns>
				///  <para>true if either a soft or hard error occurred </para>
				/// </returns>
				/// <java-name>
				/// hasError
				/// </java-name>
				public bool HasError
				{
						[Dot42.DexImport("hasError", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

		}

		/// <summary>
		///  <para>Used to record various statistics about the result of a sync operation. The SyncManager gets access to these via a SyncResult and uses some of them to determine the disposition of the sync. See SyncResult for further dicussion on how the SyncManager uses these values. </para>    
		/// </summary>
		/// <java-name>
		/// android/content/SyncStats
		/// </java-name>
		[Dot42.DexImport("android/content/SyncStats", AccessFlags = 33)]
		public partial class SyncStats : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>The SyncAdapter was unable to authenticate the android.accounts.Account that was specified in the request. The user needs to take some action to resolve before a future request can expect to succeed. This is considered a hard error. </para>        
				/// </summary>
				/// <java-name>
				/// numAuthExceptions
				/// </java-name>
				[Dot42.DexImport("numAuthExceptions", "J", AccessFlags = 1)]
				public long NumAuthExceptions;
				/// <summary>
				///  <para>The SyncAdapter had a problem, most likely with the network connectivity or a timeout while waiting for a network response. The request may succeed if it is tried again later. This is considered a soft error. </para>        
				/// </summary>
				/// <java-name>
				/// numIoExceptions
				/// </java-name>
				[Dot42.DexImport("numIoExceptions", "J", AccessFlags = 1)]
				public long NumIoExceptions;
				/// <summary>
				///  <para>The SyncAdapter had a problem with the data it received from the server or the storage later. This problem will likely repeat if the request is tried again. The problem will need to be cleared up by either the server or the storage layer (likely with help from the user). If the SyncAdapter cleans up the data itself then it typically won't increment this value although it may still do so in order to record that it had to perform some cleanup. E.g., if the SyncAdapter received a bad entry from the server when processing a feed of entries, it may choose to drop the entry and thus make progress and still increment this value just so the SyncAdapter can record that an error occurred. This is considered a hard error. </para>        
				/// </summary>
				/// <java-name>
				/// numParseExceptions
				/// </java-name>
				[Dot42.DexImport("numParseExceptions", "J", AccessFlags = 1)]
				public long NumParseExceptions;
				/// <summary>
				///  <para>The SyncAdapter detected that there was an unrecoverable version conflict when it attempted to update or delete a version of a resource on the server. This is expected to clear itself automatically once the new state is retrieved from the server, though it may remain until the user intervenes manually, perhaps by clearing the local storage and starting over frmo scratch. This is considered a hard error. </para>        
				/// </summary>
				/// <java-name>
				/// numConflictDetectedExceptions
				/// </java-name>
				[Dot42.DexImport("numConflictDetectedExceptions", "J", AccessFlags = 1)]
				public long NumConflictDetectedExceptions;
				/// <summary>
				///  <para>Counter for tracking how many inserts were performed by the sync operation, as defined by the SyncAdapter. </para>        
				/// </summary>
				/// <java-name>
				/// numInserts
				/// </java-name>
				[Dot42.DexImport("numInserts", "J", AccessFlags = 1)]
				public long NumInserts;
				/// <summary>
				///  <para>Counter for tracking how many updates were performed by the sync operation, as defined by the SyncAdapter. </para>        
				/// </summary>
				/// <java-name>
				/// numUpdates
				/// </java-name>
				[Dot42.DexImport("numUpdates", "J", AccessFlags = 1)]
				public long NumUpdates;
				/// <summary>
				///  <para>Counter for tracking how many deletes were performed by the sync operation, as defined by the SyncAdapter. </para>        
				/// </summary>
				/// <java-name>
				/// numDeletes
				/// </java-name>
				[Dot42.DexImport("numDeletes", "J", AccessFlags = 1)]
				public long NumDeletes;
				/// <summary>
				///  <para>Counter for tracking how many entries were affected by the sync operation, as defined by the SyncAdapter. </para>        
				/// </summary>
				/// <java-name>
				/// numEntries
				/// </java-name>
				[Dot42.DexImport("numEntries", "J", AccessFlags = 1)]
				public long NumEntries;
				/// <summary>
				///  <para>Counter for tracking how many entries, either from the server or the local store, were ignored during the sync operation. This could happen if the SyncAdapter detected some unparsable data but decided to skip it and move on rather than failing immediately. </para>        
				/// </summary>
				/// <java-name>
				/// numSkippedEntries
				/// </java-name>
				[Dot42.DexImport("numSkippedEntries", "J", AccessFlags = 1)]
				public long NumSkippedEntries;
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.Content.SyncStats> CREATOR;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public SyncStats() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/os/Parcel;)V", AccessFlags = 1)]
				public SyncStats(global::Android.OS.Parcel @in) /* MethodBuilder.Create */ 
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
				///  <para>Reset all the counters to 0. </para>        
				/// </summary>
				/// <java-name>
				/// clear
				/// </java-name>
				[Dot42.DexImport("clear", "()V", AccessFlags = 1)]
				public virtual void Clear() /* MethodBuilder.Create */ 
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

		/// <summary>
		///  <para>Utility class to aid in matching URIs in content providers.</para> <para>To use this class, build up a tree of  <code>UriMatcher</code> objects. For example:  <pre>
		///     private static final int PEOPLE = 1;
		///     private static final int PEOPLE_ID = 2;
		///     private static final int PEOPLE_PHONES = 3;
		///     private static final int PEOPLE_PHONES_ID = 4;
		///     private static final int PEOPLE_CONTACTMETHODS = 7;
		///     private static final int PEOPLE_CONTACTMETHODS_ID = 8;</pre></para> <para> <pre>    private static final int DELETED_PEOPLE = 20;</pre></para> <para> <pre>    private static final int PHONES = 9;
		///     private static final int PHONES_ID = 10;
		///     private static final int PHONES_FILTER = 14;</pre></para> <para> <pre>    private static final int CONTACTMETHODS = 18;
		///     private static final int CONTACTMETHODS_ID = 19;</pre></para> <para> <pre>    private static final int CALLS = 11;
		///     private static final int CALLS_ID = 12;
		///     private static final int CALLS_FILTER = 15;</pre></para> <para> <pre>    private static final UriMatcher sURIMatcher = new UriMatcher(UriMatcher.NO_MATCH);</pre></para> <para> <pre>    static
		///     {
		///         sURIMatcher.addURI("contacts", "people", PEOPLE);
		///         sURIMatcher.addURI("contacts", "people/#", PEOPLE_ID);
		///         sURIMatcher.addURI("contacts", "people/#/phones", PEOPLE_PHONES);
		///         sURIMatcher.addURI("contacts", "people/#/phones/#", PEOPLE_PHONES_ID);
		///         sURIMatcher.addURI("contacts", "people/#/contact_methods", PEOPLE_CONTACTMETHODS);
		///         sURIMatcher.addURI("contacts", "people/#/contact_methods/#", PEOPLE_CONTACTMETHODS_ID);
		///         sURIMatcher.addURI("contacts", "deleted_people", DELETED_PEOPLE);
		///         sURIMatcher.addURI("contacts", "phones", PHONES);
		///         sURIMatcher.addURI("contacts", "phones/filter/*", PHONES_FILTER);
		///         sURIMatcher.addURI("contacts", "phones/#", PHONES_ID);
		///         sURIMatcher.addURI("contacts", "contact_methods", CONTACTMETHODS);
		///         sURIMatcher.addURI("contacts", "contact_methods/#", CONTACTMETHODS_ID);
		///         sURIMatcher.addURI("call_log", "calls", CALLS);
		///         sURIMatcher.addURI("call_log", "calls/filter/*", CALLS_FILTER);
		///         sURIMatcher.addURI("call_log", "calls/#", CALLS_ID);
		///     }
		/// </pre> </para> <para>Starting from API level android.os.Build.VERSION_CODES#JELLY_BEAN_MR2, paths can start with a leading slash. For example:  <pre>
		///         sURIMatcher.addURI("contacts", "/people", PEOPLE);
		/// </pre> </para> <para>Then when you need to match against a URI, call match, providing the URL that you have been given. You can use the result to build a query, return a type, insert or delete a row, or whatever you need, without duplicating all of the if-else logic that you would otherwise need. For example:  <pre>
		///     public String getType(Uri url)
		///     {
		///         int match = sURIMatcher.match(url);
		///         switch (match)
		///         {
		///             case PEOPLE:
		///                 return "vnd.android.cursor.dir/person";
		///             case PEOPLE_ID:
		///                 return "vnd.android.cursor.item/person";
		/// ... snip ...
		///                 return "vnd.android.cursor.dir/snail-mail";
		///             case PEOPLE_ADDRESS_ID:
		///                 return "vnd.android.cursor.item/snail-mail";
		///             default:
		///                 return null;
		///         }
		///     }
		/// </pre> instead of:  <pre>
		///     public String getType(Uri url)
		///     {
		///         List&lt;String&gt; pathSegments = url.getPathSegments();
		///         if (pathSegments.size() &gt;= 2) {
		///             if ("people".equals(pathSegments.get(1))) {
		///                 if (pathSegments.size() == 2) {
		///                     return "vnd.android.cursor.dir/person";
		///                 } else if (pathSegments.size() == 3) {
		///                     return "vnd.android.cursor.item/person";
		/// ... snip ...
		///                     return "vnd.android.cursor.dir/snail-mail";
		///                 } else if (pathSegments.size() == 3) {
		///                     return "vnd.android.cursor.item/snail-mail";
		///                 }
		///             }
		///         }
		///         return null;
		///     }
		/// </pre> </para>    
		/// </summary>
		/// <java-name>
		/// android/content/UriMatcher
		/// </java-name>
		[Dot42.DexImport("android/content/UriMatcher", AccessFlags = 33)]
		public partial class UriMatcher
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// NO_MATCH
				/// </java-name>
				[Dot42.DexImport("NO_MATCH", "I", AccessFlags = 25)]
				public const int NO_MATCH = -1;
				/// <summary>
				///  <para>Creates the root node of the URI tree.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public UriMatcher(int code) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Add a URI to match, and the code to return when this URI is matched. URI nodes may be exact match string, the token "*" that matches any text, or the token "#" that matches only numbers. </para> <para>Starting from API level android.os.Build.VERSION_CODES#JELLY_BEAN_MR2, this method will accept leading slash in the path.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// addURI
				/// </java-name>
				[Dot42.DexImport("addURI", "(Ljava/lang/String;Ljava/lang/String;I)V", AccessFlags = 1)]
				public virtual void AddURI(string authority, string path, int code) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Try to match against the path in a url.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The code for the matched node (added using addURI), or -1 if there is no matched node. </para>
				/// </returns>
				/// <java-name>
				/// match
				/// </java-name>
				[Dot42.DexImport("match", "(Landroid/net/Uri;)I", AccessFlags = 1)]
				public virtual int Match(global::Android.Net.Uri uri) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal UriMatcher() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

}

