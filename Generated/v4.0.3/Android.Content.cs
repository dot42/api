#pragma warning disable 1717
namespace Android.Content
{
		/// <java-name>
		/// android/content/Loader
		/// </java-name>
		[Dot42.DexImport("android/content/Loader", AccessFlags = 33, Signature = "<D:Ljava/lang/Object;>Ljava/lang/Object;")]
		public partial class Loader<D>
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public Loader(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// deliverResult
				/// </java-name>
				[Dot42.DexImport("deliverResult", "(Ljava/lang/Object;)V", AccessFlags = 1, Signature = "(TD;)V")]
				public virtual void DeliverResult(D d) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getContext
				/// </java-name>
				[Dot42.DexImport("getContext", "()Landroid/content/Context;", AccessFlags = 1)]
				public virtual global::Android.Content.Context GetContext() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Context);
				}

				/// <java-name>
				/// getId
				/// </java-name>
				[Dot42.DexImport("getId", "()I", AccessFlags = 1)]
				public virtual int GetId() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// registerListener
				/// </java-name>
				[Dot42.DexImport("registerListener", "(ILandroid/content/Loader$OnLoadCompleteListener;)V", AccessFlags = 1, Signature = "(ILandroid/content/Loader$OnLoadCompleteListener<TD;>;)V")]
				public virtual void RegisterListener(int int32, global::Android.Content.Loader<D>.IOnLoadCompleteListener<D> onLoadCompleteListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// unregisterListener
				/// </java-name>
				[Dot42.DexImport("unregisterListener", "(Landroid/content/Loader$OnLoadCompleteListener;)V", AccessFlags = 1, Signature = "(Landroid/content/Loader$OnLoadCompleteListener<TD;>;)V")]
				public virtual void UnregisterListener(global::Android.Content.Loader<D>.IOnLoadCompleteListener<D> onLoadCompleteListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isStarted
				/// </java-name>
				[Dot42.DexImport("isStarted", "()Z", AccessFlags = 1)]
				public virtual bool IsStarted() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isAbandoned
				/// </java-name>
				[Dot42.DexImport("isAbandoned", "()Z", AccessFlags = 1)]
				public virtual bool IsAbandoned() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isReset
				/// </java-name>
				[Dot42.DexImport("isReset", "()Z", AccessFlags = 1)]
				public virtual bool IsReset() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// startLoading
				/// </java-name>
				[Dot42.DexImport("startLoading", "()V", AccessFlags = 17)]
				public void StartLoading() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onStartLoading
				/// </java-name>
				[Dot42.DexImport("onStartLoading", "()V", AccessFlags = 4)]
				protected internal virtual void OnStartLoading() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// forceLoad
				/// </java-name>
				[Dot42.DexImport("forceLoad", "()V", AccessFlags = 1)]
				public virtual void ForceLoad() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onForceLoad
				/// </java-name>
				[Dot42.DexImport("onForceLoad", "()V", AccessFlags = 4)]
				protected internal virtual void OnForceLoad() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// stopLoading
				/// </java-name>
				[Dot42.DexImport("stopLoading", "()V", AccessFlags = 1)]
				public virtual void StopLoading() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onStopLoading
				/// </java-name>
				[Dot42.DexImport("onStopLoading", "()V", AccessFlags = 4)]
				protected internal virtual void OnStopLoading() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// abandon
				/// </java-name>
				[Dot42.DexImport("abandon", "()V", AccessFlags = 1)]
				public virtual void Abandon() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onAbandon
				/// </java-name>
				[Dot42.DexImport("onAbandon", "()V", AccessFlags = 4)]
				protected internal virtual void OnAbandon() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// reset
				/// </java-name>
				[Dot42.DexImport("reset", "()V", AccessFlags = 1)]
				public virtual void Reset() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onReset
				/// </java-name>
				[Dot42.DexImport("onReset", "()V", AccessFlags = 4)]
				protected internal virtual void OnReset() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// takeContentChanged
				/// </java-name>
				[Dot42.DexImport("takeContentChanged", "()Z", AccessFlags = 1)]
				public virtual bool TakeContentChanged() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onContentChanged
				/// </java-name>
				[Dot42.DexImport("onContentChanged", "()V", AccessFlags = 1)]
				public virtual void OnContentChanged() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// dataToString
				/// </java-name>
				[Dot42.DexImport("dataToString", "(Ljava/lang/Object;)Ljava/lang/String;", AccessFlags = 1, Signature = "(TD;)Ljava/lang/String;")]
				public virtual string DataToString(D d) /* MethodBuilder.Create */ 
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
				/// dump
				/// </java-name>
				[Dot42.DexImport("dump", "(Ljava/lang/String;Ljava/io/FileDescriptor;Ljava/io/PrintWriter;[Ljava/lang/Strin" +
    "g;)V", AccessFlags = 1)]
				public virtual void Dump(string @string, global::Java.Io.FileDescriptor fileDescriptor, global::Java.Io.PrintWriter printWriter, string[] string1) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal Loader() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getContext
				/// </java-name>
				public global::Android.Content.Context Context
				{
				[Dot42.DexImport("getContext", "()Landroid/content/Context;", AccessFlags = 1)]
						get{ return GetContext(); }
				}

				/// <java-name>
				/// getId
				/// </java-name>
				public int Id
				{
				[Dot42.DexImport("getId", "()I", AccessFlags = 1)]
						get{ return GetId(); }
				}

				/// <java-name>
				/// android/content/Loader$OnLoadCompleteListener
				/// </java-name>
				[Dot42.DexImport("android/content/Loader$OnLoadCompleteListener", AccessFlags = 1545, Signature = "<D:Ljava/lang/Object;>Ljava/lang/Object;")]
				public partial interface IOnLoadCompleteListener<D>
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onLoadComplete
						/// </java-name>
						[Dot42.DexImport("onLoadComplete", "(Landroid/content/Loader;Ljava/lang/Object;)V", AccessFlags = 1025, Signature = "(Landroid/content/Loader<TD;>;TD;)V")]
						void OnLoadComplete(global::Android.Content.Loader<D> loader, D d) /* MethodBuilder.Create */ ;

				}

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
						public override void OnChange(bool boolean) /* MethodBuilder.Create */ 
						{
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal ForceLoadContentObserver() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

				}

		}

		/// <java-name>
		/// android/content/ComponentCallbacks2
		/// </java-name>
		[Dot42.DexImport("android/content/ComponentCallbacks2", AccessFlags = 1537, IgnoreFromJava = true, Priority = 1)]
		public static partial class IComponentCallbacks2Constants
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// TRIM_MEMORY_COMPLETE
				/// </java-name>
				[Dot42.DexImport("TRIM_MEMORY_COMPLETE", "I", AccessFlags = 25)]
				public const int TRIM_MEMORY_COMPLETE = 80;
				/// <java-name>
				/// TRIM_MEMORY_MODERATE
				/// </java-name>
				[Dot42.DexImport("TRIM_MEMORY_MODERATE", "I", AccessFlags = 25)]
				public const int TRIM_MEMORY_MODERATE = 60;
				/// <java-name>
				/// TRIM_MEMORY_BACKGROUND
				/// </java-name>
				[Dot42.DexImport("TRIM_MEMORY_BACKGROUND", "I", AccessFlags = 25)]
				public const int TRIM_MEMORY_BACKGROUND = 40;
				/// <java-name>
				/// TRIM_MEMORY_UI_HIDDEN
				/// </java-name>
				[Dot42.DexImport("TRIM_MEMORY_UI_HIDDEN", "I", AccessFlags = 25)]
				public const int TRIM_MEMORY_UI_HIDDEN = 20;
		}

		/// <java-name>
		/// android/content/ComponentCallbacks2
		/// </java-name>
		[Dot42.DexImport("android/content/ComponentCallbacks2", AccessFlags = 1537)]
		public partial interface IComponentCallbacks2 : global::Android.Content.IComponentCallbacks
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// onTrimMemory
				/// </java-name>
				[Dot42.DexImport("onTrimMemory", "(I)V", AccessFlags = 1025)]
				void OnTrimMemory(int int32) /* MethodBuilder.Create */ ;

		}

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

				/// <java-name>
				/// setUpdateThrottle
				/// </java-name>
				[Dot42.DexImport("setUpdateThrottle", "(J)V", AccessFlags = 1)]
				public virtual void SetUpdateThrottle(long int64) /* MethodBuilder.Create */ 
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

				/// <java-name>
				/// onCanceled
				/// </java-name>
				[Dot42.DexImport("onCanceled", "(Ljava/lang/Object;)V", AccessFlags = 1, Signature = "(TD;)V")]
				public virtual void OnCanceled(D d) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// loadInBackground
				/// </java-name>
				[Dot42.DexImport("loadInBackground", "()Ljava/lang/Object;", AccessFlags = 1025, Signature = "()TD;")]
				public abstract D LoadInBackground() /* MethodBuilder.Create */ ;

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
				public override void Dump(string @string, global::Java.Io.FileDescriptor fileDescriptor, global::Java.Io.PrintWriter printWriter, string[] string1) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal AsyncTaskLoader() /* TypeBuilder.AddDefaultConstructor */ 
				{
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
				public virtual void OnFinished(global::Android.Content.SyncResult syncResult) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getSyncContextBinder
				/// </java-name>
				[Dot42.DexImport("getSyncContextBinder", "()Landroid/os/IBinder;", AccessFlags = 1)]
				public virtual global::Android.Os.IBinder GetSyncContextBinder() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Os.IBinder);
				}

				/// <java-name>
				/// getSyncContextBinder
				/// </java-name>
				public global::Android.Os.IBinder SyncContextBinder
				{
				[Dot42.DexImport("getSyncContextBinder", "()Landroid/os/IBinder;", AccessFlags = 1)]
						get{ return GetSyncContextBinder(); }
				}

		}

		/// <java-name>
		/// android/content/ContentProviderOperation
		/// </java-name>
		[Dot42.DexImport("android/content/ContentProviderOperation", AccessFlags = 33)]
		public partial class ContentProviderOperation : global::Android.Os.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.Os.IParcelable_ICreator<global::Android.Content.ContentProviderOperation> CREATOR;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal ContentProviderOperation() /* MethodBuilder.Create */ 
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
				/// newInsert
				/// </java-name>
				[Dot42.DexImport("newInsert", "(Landroid/net/Uri;)Landroid/content/ContentProviderOperation$Builder;", AccessFlags = 9)]
				public static global::Android.Content.ContentProviderOperation.Builder NewInsert(global::Android.Net.Uri uri) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.ContentProviderOperation.Builder);
				}

				/// <java-name>
				/// newUpdate
				/// </java-name>
				[Dot42.DexImport("newUpdate", "(Landroid/net/Uri;)Landroid/content/ContentProviderOperation$Builder;", AccessFlags = 9)]
				public static global::Android.Content.ContentProviderOperation.Builder NewUpdate(global::Android.Net.Uri uri) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.ContentProviderOperation.Builder);
				}

				/// <java-name>
				/// newDelete
				/// </java-name>
				[Dot42.DexImport("newDelete", "(Landroid/net/Uri;)Landroid/content/ContentProviderOperation$Builder;", AccessFlags = 9)]
				public static global::Android.Content.ContentProviderOperation.Builder NewDelete(global::Android.Net.Uri uri) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.ContentProviderOperation.Builder);
				}

				/// <java-name>
				/// newAssertQuery
				/// </java-name>
				[Dot42.DexImport("newAssertQuery", "(Landroid/net/Uri;)Landroid/content/ContentProviderOperation$Builder;", AccessFlags = 9)]
				public static global::Android.Content.ContentProviderOperation.Builder NewAssertQuery(global::Android.Net.Uri uri) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.ContentProviderOperation.Builder);
				}

				/// <java-name>
				/// getUri
				/// </java-name>
				[Dot42.DexImport("getUri", "()Landroid/net/Uri;", AccessFlags = 1)]
				public virtual global::Android.Net.Uri GetUri() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Net.Uri);
				}

				/// <java-name>
				/// isYieldAllowed
				/// </java-name>
				[Dot42.DexImport("isYieldAllowed", "()Z", AccessFlags = 1)]
				public virtual bool IsYieldAllowed() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isWriteOperation
				/// </java-name>
				[Dot42.DexImport("isWriteOperation", "()Z", AccessFlags = 1)]
				public virtual bool IsWriteOperation() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isReadOperation
				/// </java-name>
				[Dot42.DexImport("isReadOperation", "()Z", AccessFlags = 1)]
				public virtual bool IsReadOperation() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// apply
				/// </java-name>
				[Dot42.DexImport("apply", "(Landroid/content/ContentProvider;[Landroid/content/ContentProviderResult;I)Landr" +
    "oid/content/ContentProviderResult;", AccessFlags = 1)]
				public virtual global::Android.Content.ContentProviderResult Apply(global::Android.Content.ContentProvider contentProvider, global::Android.Content.ContentProviderResult[] contentProviderResult, int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.ContentProviderResult);
				}

				/// <java-name>
				/// resolveValueBackReferences
				/// </java-name>
				[Dot42.DexImport("resolveValueBackReferences", "([Landroid/content/ContentProviderResult;I)Landroid/content/ContentValues;", AccessFlags = 1)]
				public virtual global::Android.Content.ContentValues ResolveValueBackReferences(global::Android.Content.ContentProviderResult[] contentProviderResult, int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.ContentValues);
				}

				/// <java-name>
				/// resolveSelectionArgsBackReferences
				/// </java-name>
				[Dot42.DexImport("resolveSelectionArgsBackReferences", "([Landroid/content/ContentProviderResult;I)[Ljava/lang/String;", AccessFlags = 1)]
				public virtual string[] ResolveSelectionArgsBackReferences(global::Android.Content.ContentProviderResult[] contentProviderResult, int int32) /* MethodBuilder.Create */ 
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
				public global::Android.Net.Uri Uri
				{
				[Dot42.DexImport("getUri", "()Landroid/net/Uri;", AccessFlags = 1)]
						get{ return GetUri(); }
				}

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

						/// <java-name>
						/// build
						/// </java-name>
						[Dot42.DexImport("build", "()Landroid/content/ContentProviderOperation;", AccessFlags = 1)]
						public virtual global::Android.Content.ContentProviderOperation Build() /* MethodBuilder.Create */ 
						{
								return default(global::Android.Content.ContentProviderOperation);
						}

						/// <java-name>
						/// withValueBackReferences
						/// </java-name>
						[Dot42.DexImport("withValueBackReferences", "(Landroid/content/ContentValues;)Landroid/content/ContentProviderOperation$Builde" +
    "r;", AccessFlags = 1)]
						public virtual Builder WithValueBackReferences(global::Android.Content.ContentValues contentValues) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// withValueBackReference
						/// </java-name>
						[Dot42.DexImport("withValueBackReference", "(Ljava/lang/String;I)Landroid/content/ContentProviderOperation$Builder;", AccessFlags = 1)]
						public virtual Builder WithValueBackReference(string @string, int int32) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// withSelectionBackReference
						/// </java-name>
						[Dot42.DexImport("withSelectionBackReference", "(II)Landroid/content/ContentProviderOperation$Builder;", AccessFlags = 1)]
						public virtual Builder WithSelectionBackReference(int int32, int int321) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// withValues
						/// </java-name>
						[Dot42.DexImport("withValues", "(Landroid/content/ContentValues;)Landroid/content/ContentProviderOperation$Builde" +
    "r;", AccessFlags = 1)]
						public virtual Builder WithValues(global::Android.Content.ContentValues contentValues) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// withValue
						/// </java-name>
						[Dot42.DexImport("withValue", "(Ljava/lang/String;Ljava/lang/Object;)Landroid/content/ContentProviderOperation$B" +
    "uilder;", AccessFlags = 1)]
						public virtual Builder WithValue(string @string, object @object) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// withSelection
						/// </java-name>
						[Dot42.DexImport("withSelection", "(Ljava/lang/String;[Ljava/lang/String;)Landroid/content/ContentProviderOperation$" +
    "Builder;", AccessFlags = 1)]
						public virtual Builder WithSelection(string @string, string[] string1) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// withExpectedCount
						/// </java-name>
						[Dot42.DexImport("withExpectedCount", "(I)Landroid/content/ContentProviderOperation$Builder;", AccessFlags = 1)]
						public virtual Builder WithExpectedCount(int int32) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// withYieldAllowed
						/// </java-name>
						[Dot42.DexImport("withYieldAllowed", "(Z)Landroid/content/ContentProviderOperation$Builder;", AccessFlags = 1)]
						public virtual Builder WithYieldAllowed(bool boolean) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

				}

		}

		/// <java-name>
		/// android/content/SyncResult
		/// </java-name>
		[Dot42.DexImport("android/content/SyncResult", AccessFlags = 49)]
		public sealed partial class SyncResult : global::Android.Os.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// syncAlreadyInProgress
				/// </java-name>
				[Dot42.DexImport("syncAlreadyInProgress", "Z", AccessFlags = 17)]
				public readonly bool SyncAlreadyInProgress;
				/// <java-name>
				/// tooManyDeletions
				/// </java-name>
				[Dot42.DexImport("tooManyDeletions", "Z", AccessFlags = 1)]
				public bool TooManyDeletions;
				/// <java-name>
				/// tooManyRetries
				/// </java-name>
				[Dot42.DexImport("tooManyRetries", "Z", AccessFlags = 1)]
				public bool TooManyRetries;
				/// <java-name>
				/// databaseError
				/// </java-name>
				[Dot42.DexImport("databaseError", "Z", AccessFlags = 1)]
				public bool DatabaseError;
				/// <java-name>
				/// fullSyncRequested
				/// </java-name>
				[Dot42.DexImport("fullSyncRequested", "Z", AccessFlags = 1)]
				public bool FullSyncRequested;
				/// <java-name>
				/// partialSyncUnavailable
				/// </java-name>
				[Dot42.DexImport("partialSyncUnavailable", "Z", AccessFlags = 1)]
				public bool PartialSyncUnavailable;
				/// <java-name>
				/// moreRecordsToGet
				/// </java-name>
				[Dot42.DexImport("moreRecordsToGet", "Z", AccessFlags = 1)]
				public bool MoreRecordsToGet;
				/// <java-name>
				/// delayUntil
				/// </java-name>
				[Dot42.DexImport("delayUntil", "J", AccessFlags = 1)]
				public long DelayUntil;
				/// <java-name>
				/// stats
				/// </java-name>
				[Dot42.DexImport("stats", "Landroid/content/SyncStats;", AccessFlags = 17)]
				public readonly global::Android.Content.SyncStats Stats;
				/// <java-name>
				/// ALREADY_IN_PROGRESS
				/// </java-name>
				[Dot42.DexImport("ALREADY_IN_PROGRESS", "Landroid/content/SyncResult;", AccessFlags = 25)]
				public static readonly global::Android.Content.SyncResult ALREADY_IN_PROGRESS;
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.Os.IParcelable_ICreator<global::Android.Content.SyncResult> CREATOR;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public SyncResult() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// hasHardError
				/// </java-name>
				[Dot42.DexImport("hasHardError", "()Z", AccessFlags = 1)]
				public bool HasHardError() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// hasSoftError
				/// </java-name>
				[Dot42.DexImport("hasSoftError", "()Z", AccessFlags = 1)]
				public bool HasSoftError() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// hasError
				/// </java-name>
				[Dot42.DexImport("hasError", "()Z", AccessFlags = 1)]
				public bool HasError() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// madeSomeProgress
				/// </java-name>
				[Dot42.DexImport("madeSomeProgress", "()Z", AccessFlags = 1)]
				public bool MadeSomeProgress() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// clear
				/// </java-name>
				[Dot42.DexImport("clear", "()V", AccessFlags = 1)]
				public void Clear() /* MethodBuilder.Create */ 
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
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public void WriteToParcel(global::Android.Os.Parcel parcel, int int32) /* MethodBuilder.Create */ 
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
				/// toDebugString
				/// </java-name>
				[Dot42.DexImport("toDebugString", "()Ljava/lang/String;", AccessFlags = 1)]
				public string ToDebugString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

		}

		/// <java-name>
		/// android/content/Intent
		/// </java-name>
		[Dot42.DexImport("android/content/Intent", AccessFlags = 33)]
		public partial class Intent : global::Android.Os.IParcelable, global::Java.Lang.ICloneable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// ACTION_MAIN
				/// </java-name>
				[Dot42.DexImport("ACTION_MAIN", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_MAIN = "android.intent.action.MAIN";
				/// <java-name>
				/// ACTION_VIEW
				/// </java-name>
				[Dot42.DexImport("ACTION_VIEW", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_VIEW = "android.intent.action.VIEW";
				/// <java-name>
				/// ACTION_DEFAULT
				/// </java-name>
				[Dot42.DexImport("ACTION_DEFAULT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_DEFAULT = "android.intent.action.VIEW";
				/// <java-name>
				/// ACTION_ATTACH_DATA
				/// </java-name>
				[Dot42.DexImport("ACTION_ATTACH_DATA", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_ATTACH_DATA = "android.intent.action.ATTACH_DATA";
				/// <java-name>
				/// ACTION_EDIT
				/// </java-name>
				[Dot42.DexImport("ACTION_EDIT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_EDIT = "android.intent.action.EDIT";
				/// <java-name>
				/// ACTION_INSERT_OR_EDIT
				/// </java-name>
				[Dot42.DexImport("ACTION_INSERT_OR_EDIT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_INSERT_OR_EDIT = "android.intent.action.INSERT_OR_EDIT";
				/// <java-name>
				/// ACTION_PICK
				/// </java-name>
				[Dot42.DexImport("ACTION_PICK", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_PICK = "android.intent.action.PICK";
				/// <java-name>
				/// ACTION_CREATE_SHORTCUT
				/// </java-name>
				[Dot42.DexImport("ACTION_CREATE_SHORTCUT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_CREATE_SHORTCUT = "android.intent.action.CREATE_SHORTCUT";
				/// <java-name>
				/// EXTRA_SHORTCUT_INTENT
				/// </java-name>
				[Dot42.DexImport("EXTRA_SHORTCUT_INTENT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_SHORTCUT_INTENT = "android.intent.extra.shortcut.INTENT";
				/// <java-name>
				/// EXTRA_SHORTCUT_NAME
				/// </java-name>
				[Dot42.DexImport("EXTRA_SHORTCUT_NAME", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_SHORTCUT_NAME = "android.intent.extra.shortcut.NAME";
				/// <java-name>
				/// EXTRA_SHORTCUT_ICON
				/// </java-name>
				[Dot42.DexImport("EXTRA_SHORTCUT_ICON", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_SHORTCUT_ICON = "android.intent.extra.shortcut.ICON";
				/// <java-name>
				/// EXTRA_SHORTCUT_ICON_RESOURCE
				/// </java-name>
				[Dot42.DexImport("EXTRA_SHORTCUT_ICON_RESOURCE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_SHORTCUT_ICON_RESOURCE = "android.intent.extra.shortcut.ICON_RESOURCE";
				/// <java-name>
				/// ACTION_CHOOSER
				/// </java-name>
				[Dot42.DexImport("ACTION_CHOOSER", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_CHOOSER = "android.intent.action.CHOOSER";
				/// <java-name>
				/// ACTION_GET_CONTENT
				/// </java-name>
				[Dot42.DexImport("ACTION_GET_CONTENT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_GET_CONTENT = "android.intent.action.GET_CONTENT";
				/// <java-name>
				/// ACTION_DIAL
				/// </java-name>
				[Dot42.DexImport("ACTION_DIAL", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_DIAL = "android.intent.action.DIAL";
				/// <java-name>
				/// ACTION_CALL
				/// </java-name>
				[Dot42.DexImport("ACTION_CALL", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_CALL = "android.intent.action.CALL";
				/// <java-name>
				/// ACTION_SENDTO
				/// </java-name>
				[Dot42.DexImport("ACTION_SENDTO", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_SENDTO = "android.intent.action.SENDTO";
				/// <java-name>
				/// ACTION_SEND
				/// </java-name>
				[Dot42.DexImport("ACTION_SEND", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_SEND = "android.intent.action.SEND";
				/// <java-name>
				/// ACTION_SEND_MULTIPLE
				/// </java-name>
				[Dot42.DexImport("ACTION_SEND_MULTIPLE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_SEND_MULTIPLE = "android.intent.action.SEND_MULTIPLE";
				/// <java-name>
				/// ACTION_ANSWER
				/// </java-name>
				[Dot42.DexImport("ACTION_ANSWER", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_ANSWER = "android.intent.action.ANSWER";
				/// <java-name>
				/// ACTION_INSERT
				/// </java-name>
				[Dot42.DexImport("ACTION_INSERT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_INSERT = "android.intent.action.INSERT";
				/// <java-name>
				/// ACTION_PASTE
				/// </java-name>
				[Dot42.DexImport("ACTION_PASTE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_PASTE = "android.intent.action.PASTE";
				/// <java-name>
				/// ACTION_DELETE
				/// </java-name>
				[Dot42.DexImport("ACTION_DELETE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_DELETE = "android.intent.action.DELETE";
				/// <java-name>
				/// ACTION_RUN
				/// </java-name>
				[Dot42.DexImport("ACTION_RUN", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_RUN = "android.intent.action.RUN";
				/// <java-name>
				/// ACTION_SYNC
				/// </java-name>
				[Dot42.DexImport("ACTION_SYNC", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_SYNC = "android.intent.action.SYNC";
				/// <java-name>
				/// ACTION_PICK_ACTIVITY
				/// </java-name>
				[Dot42.DexImport("ACTION_PICK_ACTIVITY", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_PICK_ACTIVITY = "android.intent.action.PICK_ACTIVITY";
				/// <java-name>
				/// ACTION_SEARCH
				/// </java-name>
				[Dot42.DexImport("ACTION_SEARCH", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_SEARCH = "android.intent.action.SEARCH";
				/// <java-name>
				/// ACTION_SYSTEM_TUTORIAL
				/// </java-name>
				[Dot42.DexImport("ACTION_SYSTEM_TUTORIAL", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_SYSTEM_TUTORIAL = "android.intent.action.SYSTEM_TUTORIAL";
				/// <java-name>
				/// ACTION_WEB_SEARCH
				/// </java-name>
				[Dot42.DexImport("ACTION_WEB_SEARCH", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_WEB_SEARCH = "android.intent.action.WEB_SEARCH";
				/// <java-name>
				/// ACTION_ALL_APPS
				/// </java-name>
				[Dot42.DexImport("ACTION_ALL_APPS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_ALL_APPS = "android.intent.action.ALL_APPS";
				/// <java-name>
				/// ACTION_SET_WALLPAPER
				/// </java-name>
				[Dot42.DexImport("ACTION_SET_WALLPAPER", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_SET_WALLPAPER = "android.intent.action.SET_WALLPAPER";
				/// <java-name>
				/// ACTION_BUG_REPORT
				/// </java-name>
				[Dot42.DexImport("ACTION_BUG_REPORT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_BUG_REPORT = "android.intent.action.BUG_REPORT";
				/// <java-name>
				/// ACTION_FACTORY_TEST
				/// </java-name>
				[Dot42.DexImport("ACTION_FACTORY_TEST", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_FACTORY_TEST = "android.intent.action.FACTORY_TEST";
				/// <java-name>
				/// ACTION_CALL_BUTTON
				/// </java-name>
				[Dot42.DexImport("ACTION_CALL_BUTTON", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_CALL_BUTTON = "android.intent.action.CALL_BUTTON";
				/// <java-name>
				/// ACTION_VOICE_COMMAND
				/// </java-name>
				[Dot42.DexImport("ACTION_VOICE_COMMAND", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_VOICE_COMMAND = "android.intent.action.VOICE_COMMAND";
				/// <java-name>
				/// ACTION_SEARCH_LONG_PRESS
				/// </java-name>
				[Dot42.DexImport("ACTION_SEARCH_LONG_PRESS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_SEARCH_LONG_PRESS = "android.intent.action.SEARCH_LONG_PRESS";
				/// <java-name>
				/// ACTION_APP_ERROR
				/// </java-name>
				[Dot42.DexImport("ACTION_APP_ERROR", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_APP_ERROR = "android.intent.action.APP_ERROR";
				/// <java-name>
				/// ACTION_POWER_USAGE_SUMMARY
				/// </java-name>
				[Dot42.DexImport("ACTION_POWER_USAGE_SUMMARY", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_POWER_USAGE_SUMMARY = "android.intent.action.POWER_USAGE_SUMMARY";
				/// <java-name>
				/// ACTION_MANAGE_NETWORK_USAGE
				/// </java-name>
				[Dot42.DexImport("ACTION_MANAGE_NETWORK_USAGE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_MANAGE_NETWORK_USAGE = "android.intent.action.MANAGE_NETWORK_USAGE";
				/// <java-name>
				/// ACTION_INSTALL_PACKAGE
				/// </java-name>
				[Dot42.DexImport("ACTION_INSTALL_PACKAGE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_INSTALL_PACKAGE = "android.intent.action.INSTALL_PACKAGE";
				/// <java-name>
				/// EXTRA_INSTALLER_PACKAGE_NAME
				/// </java-name>
				[Dot42.DexImport("EXTRA_INSTALLER_PACKAGE_NAME", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_INSTALLER_PACKAGE_NAME = "android.intent.extra.INSTALLER_PACKAGE_NAME";
				/// <java-name>
				/// EXTRA_NOT_UNKNOWN_SOURCE
				/// </java-name>
				[Dot42.DexImport("EXTRA_NOT_UNKNOWN_SOURCE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_NOT_UNKNOWN_SOURCE = "android.intent.extra.NOT_UNKNOWN_SOURCE";
				/// <java-name>
				/// EXTRA_ALLOW_REPLACE
				/// </java-name>
				[Dot42.DexImport("EXTRA_ALLOW_REPLACE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_ALLOW_REPLACE = "android.intent.extra.ALLOW_REPLACE";
				/// <java-name>
				/// EXTRA_RETURN_RESULT
				/// </java-name>
				[Dot42.DexImport("EXTRA_RETURN_RESULT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_RETURN_RESULT = "android.intent.extra.RETURN_RESULT";
				/// <java-name>
				/// ACTION_UNINSTALL_PACKAGE
				/// </java-name>
				[Dot42.DexImport("ACTION_UNINSTALL_PACKAGE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_UNINSTALL_PACKAGE = "android.intent.action.UNINSTALL_PACKAGE";
				/// <java-name>
				/// ACTION_SCREEN_OFF
				/// </java-name>
				[Dot42.DexImport("ACTION_SCREEN_OFF", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_SCREEN_OFF = "android.intent.action.SCREEN_OFF";
				/// <java-name>
				/// ACTION_SCREEN_ON
				/// </java-name>
				[Dot42.DexImport("ACTION_SCREEN_ON", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_SCREEN_ON = "android.intent.action.SCREEN_ON";
				/// <java-name>
				/// ACTION_USER_PRESENT
				/// </java-name>
				[Dot42.DexImport("ACTION_USER_PRESENT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_USER_PRESENT = "android.intent.action.USER_PRESENT";
				/// <java-name>
				/// ACTION_TIME_TICK
				/// </java-name>
				[Dot42.DexImport("ACTION_TIME_TICK", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_TIME_TICK = "android.intent.action.TIME_TICK";
				/// <java-name>
				/// ACTION_TIME_CHANGED
				/// </java-name>
				[Dot42.DexImport("ACTION_TIME_CHANGED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_TIME_CHANGED = "android.intent.action.TIME_SET";
				/// <java-name>
				/// ACTION_DATE_CHANGED
				/// </java-name>
				[Dot42.DexImport("ACTION_DATE_CHANGED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_DATE_CHANGED = "android.intent.action.DATE_CHANGED";
				/// <java-name>
				/// ACTION_TIMEZONE_CHANGED
				/// </java-name>
				[Dot42.DexImport("ACTION_TIMEZONE_CHANGED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_TIMEZONE_CHANGED = "android.intent.action.TIMEZONE_CHANGED";
				/// <java-name>
				/// ACTION_BOOT_COMPLETED
				/// </java-name>
				[Dot42.DexImport("ACTION_BOOT_COMPLETED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_BOOT_COMPLETED = "android.intent.action.BOOT_COMPLETED";
				/// <java-name>
				/// ACTION_CLOSE_SYSTEM_DIALOGS
				/// </java-name>
				[Dot42.DexImport("ACTION_CLOSE_SYSTEM_DIALOGS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_CLOSE_SYSTEM_DIALOGS = "android.intent.action.CLOSE_SYSTEM_DIALOGS";
				/// <java-name>
				/// ACTION_PACKAGE_INSTALL
				/// </java-name>
				[Dot42.DexImport("ACTION_PACKAGE_INSTALL", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_PACKAGE_INSTALL = "android.intent.action.PACKAGE_INSTALL";
				/// <java-name>
				/// ACTION_PACKAGE_ADDED
				/// </java-name>
				[Dot42.DexImport("ACTION_PACKAGE_ADDED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_PACKAGE_ADDED = "android.intent.action.PACKAGE_ADDED";
				/// <java-name>
				/// ACTION_PACKAGE_REPLACED
				/// </java-name>
				[Dot42.DexImport("ACTION_PACKAGE_REPLACED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_PACKAGE_REPLACED = "android.intent.action.PACKAGE_REPLACED";
				/// <java-name>
				/// ACTION_MY_PACKAGE_REPLACED
				/// </java-name>
				[Dot42.DexImport("ACTION_MY_PACKAGE_REPLACED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_MY_PACKAGE_REPLACED = "android.intent.action.MY_PACKAGE_REPLACED";
				/// <java-name>
				/// ACTION_PACKAGE_REMOVED
				/// </java-name>
				[Dot42.DexImport("ACTION_PACKAGE_REMOVED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_PACKAGE_REMOVED = "android.intent.action.PACKAGE_REMOVED";
				/// <java-name>
				/// ACTION_PACKAGE_FULLY_REMOVED
				/// </java-name>
				[Dot42.DexImport("ACTION_PACKAGE_FULLY_REMOVED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_PACKAGE_FULLY_REMOVED = "android.intent.action.PACKAGE_FULLY_REMOVED";
				/// <java-name>
				/// ACTION_PACKAGE_CHANGED
				/// </java-name>
				[Dot42.DexImport("ACTION_PACKAGE_CHANGED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_PACKAGE_CHANGED = "android.intent.action.PACKAGE_CHANGED";
				/// <java-name>
				/// ACTION_PACKAGE_RESTARTED
				/// </java-name>
				[Dot42.DexImport("ACTION_PACKAGE_RESTARTED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_PACKAGE_RESTARTED = "android.intent.action.PACKAGE_RESTARTED";
				/// <java-name>
				/// ACTION_PACKAGE_DATA_CLEARED
				/// </java-name>
				[Dot42.DexImport("ACTION_PACKAGE_DATA_CLEARED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_PACKAGE_DATA_CLEARED = "android.intent.action.PACKAGE_DATA_CLEARED";
				/// <java-name>
				/// ACTION_UID_REMOVED
				/// </java-name>
				[Dot42.DexImport("ACTION_UID_REMOVED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_UID_REMOVED = "android.intent.action.UID_REMOVED";
				/// <java-name>
				/// ACTION_PACKAGE_FIRST_LAUNCH
				/// </java-name>
				[Dot42.DexImport("ACTION_PACKAGE_FIRST_LAUNCH", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_PACKAGE_FIRST_LAUNCH = "android.intent.action.PACKAGE_FIRST_LAUNCH";
				/// <java-name>
				/// ACTION_PACKAGE_NEEDS_VERIFICATION
				/// </java-name>
				[Dot42.DexImport("ACTION_PACKAGE_NEEDS_VERIFICATION", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_PACKAGE_NEEDS_VERIFICATION = "android.intent.action.PACKAGE_NEEDS_VERIFICATION";
				/// <java-name>
				/// ACTION_EXTERNAL_APPLICATIONS_AVAILABLE
				/// </java-name>
				[Dot42.DexImport("ACTION_EXTERNAL_APPLICATIONS_AVAILABLE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_EXTERNAL_APPLICATIONS_AVAILABLE = "android.intent.action.EXTERNAL_APPLICATIONS_AVAILABLE";
				/// <java-name>
				/// ACTION_EXTERNAL_APPLICATIONS_UNAVAILABLE
				/// </java-name>
				[Dot42.DexImport("ACTION_EXTERNAL_APPLICATIONS_UNAVAILABLE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_EXTERNAL_APPLICATIONS_UNAVAILABLE = "android.intent.action.EXTERNAL_APPLICATIONS_UNAVAILABLE";
				/// <java-name>
				/// ACTION_WALLPAPER_CHANGED
				/// </java-name>
				[Dot42.DexImport("ACTION_WALLPAPER_CHANGED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_WALLPAPER_CHANGED = "android.intent.action.WALLPAPER_CHANGED";
				/// <java-name>
				/// ACTION_CONFIGURATION_CHANGED
				/// </java-name>
				[Dot42.DexImport("ACTION_CONFIGURATION_CHANGED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_CONFIGURATION_CHANGED = "android.intent.action.CONFIGURATION_CHANGED";
				/// <java-name>
				/// ACTION_LOCALE_CHANGED
				/// </java-name>
				[Dot42.DexImport("ACTION_LOCALE_CHANGED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_LOCALE_CHANGED = "android.intent.action.LOCALE_CHANGED";
				/// <java-name>
				/// ACTION_BATTERY_CHANGED
				/// </java-name>
				[Dot42.DexImport("ACTION_BATTERY_CHANGED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_BATTERY_CHANGED = "android.intent.action.BATTERY_CHANGED";
				/// <java-name>
				/// ACTION_BATTERY_LOW
				/// </java-name>
				[Dot42.DexImport("ACTION_BATTERY_LOW", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_BATTERY_LOW = "android.intent.action.BATTERY_LOW";
				/// <java-name>
				/// ACTION_BATTERY_OKAY
				/// </java-name>
				[Dot42.DexImport("ACTION_BATTERY_OKAY", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_BATTERY_OKAY = "android.intent.action.BATTERY_OKAY";
				/// <java-name>
				/// ACTION_POWER_CONNECTED
				/// </java-name>
				[Dot42.DexImport("ACTION_POWER_CONNECTED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_POWER_CONNECTED = "android.intent.action.ACTION_POWER_CONNECTED";
				/// <java-name>
				/// ACTION_POWER_DISCONNECTED
				/// </java-name>
				[Dot42.DexImport("ACTION_POWER_DISCONNECTED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_POWER_DISCONNECTED = "android.intent.action.ACTION_POWER_DISCONNECTED";
				/// <java-name>
				/// ACTION_SHUTDOWN
				/// </java-name>
				[Dot42.DexImport("ACTION_SHUTDOWN", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_SHUTDOWN = "android.intent.action.ACTION_SHUTDOWN";
				/// <java-name>
				/// ACTION_DEVICE_STORAGE_LOW
				/// </java-name>
				[Dot42.DexImport("ACTION_DEVICE_STORAGE_LOW", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_DEVICE_STORAGE_LOW = "android.intent.action.DEVICE_STORAGE_LOW";
				/// <java-name>
				/// ACTION_DEVICE_STORAGE_OK
				/// </java-name>
				[Dot42.DexImport("ACTION_DEVICE_STORAGE_OK", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_DEVICE_STORAGE_OK = "android.intent.action.DEVICE_STORAGE_OK";
				/// <java-name>
				/// ACTION_MANAGE_PACKAGE_STORAGE
				/// </java-name>
				[Dot42.DexImport("ACTION_MANAGE_PACKAGE_STORAGE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_MANAGE_PACKAGE_STORAGE = "android.intent.action.MANAGE_PACKAGE_STORAGE";
				/// <java-name>
				/// ACTION_UMS_CONNECTED
				/// </java-name>
				[Dot42.DexImport("ACTION_UMS_CONNECTED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_UMS_CONNECTED = "android.intent.action.UMS_CONNECTED";
				/// <java-name>
				/// ACTION_UMS_DISCONNECTED
				/// </java-name>
				[Dot42.DexImport("ACTION_UMS_DISCONNECTED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_UMS_DISCONNECTED = "android.intent.action.UMS_DISCONNECTED";
				/// <java-name>
				/// ACTION_MEDIA_REMOVED
				/// </java-name>
				[Dot42.DexImport("ACTION_MEDIA_REMOVED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_MEDIA_REMOVED = "android.intent.action.MEDIA_REMOVED";
				/// <java-name>
				/// ACTION_MEDIA_UNMOUNTED
				/// </java-name>
				[Dot42.DexImport("ACTION_MEDIA_UNMOUNTED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_MEDIA_UNMOUNTED = "android.intent.action.MEDIA_UNMOUNTED";
				/// <java-name>
				/// ACTION_MEDIA_CHECKING
				/// </java-name>
				[Dot42.DexImport("ACTION_MEDIA_CHECKING", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_MEDIA_CHECKING = "android.intent.action.MEDIA_CHECKING";
				/// <java-name>
				/// ACTION_MEDIA_NOFS
				/// </java-name>
				[Dot42.DexImport("ACTION_MEDIA_NOFS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_MEDIA_NOFS = "android.intent.action.MEDIA_NOFS";
				/// <java-name>
				/// ACTION_MEDIA_MOUNTED
				/// </java-name>
				[Dot42.DexImport("ACTION_MEDIA_MOUNTED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_MEDIA_MOUNTED = "android.intent.action.MEDIA_MOUNTED";
				/// <java-name>
				/// ACTION_MEDIA_SHARED
				/// </java-name>
				[Dot42.DexImport("ACTION_MEDIA_SHARED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_MEDIA_SHARED = "android.intent.action.MEDIA_SHARED";
				/// <java-name>
				/// ACTION_MEDIA_BAD_REMOVAL
				/// </java-name>
				[Dot42.DexImport("ACTION_MEDIA_BAD_REMOVAL", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_MEDIA_BAD_REMOVAL = "android.intent.action.MEDIA_BAD_REMOVAL";
				/// <java-name>
				/// ACTION_MEDIA_UNMOUNTABLE
				/// </java-name>
				[Dot42.DexImport("ACTION_MEDIA_UNMOUNTABLE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_MEDIA_UNMOUNTABLE = "android.intent.action.MEDIA_UNMOUNTABLE";
				/// <java-name>
				/// ACTION_MEDIA_EJECT
				/// </java-name>
				[Dot42.DexImport("ACTION_MEDIA_EJECT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_MEDIA_EJECT = "android.intent.action.MEDIA_EJECT";
				/// <java-name>
				/// ACTION_MEDIA_SCANNER_STARTED
				/// </java-name>
				[Dot42.DexImport("ACTION_MEDIA_SCANNER_STARTED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_MEDIA_SCANNER_STARTED = "android.intent.action.MEDIA_SCANNER_STARTED";
				/// <java-name>
				/// ACTION_MEDIA_SCANNER_FINISHED
				/// </java-name>
				[Dot42.DexImport("ACTION_MEDIA_SCANNER_FINISHED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_MEDIA_SCANNER_FINISHED = "android.intent.action.MEDIA_SCANNER_FINISHED";
				/// <java-name>
				/// ACTION_MEDIA_SCANNER_SCAN_FILE
				/// </java-name>
				[Dot42.DexImport("ACTION_MEDIA_SCANNER_SCAN_FILE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_MEDIA_SCANNER_SCAN_FILE = "android.intent.action.MEDIA_SCANNER_SCAN_FILE";
				/// <java-name>
				/// ACTION_MEDIA_BUTTON
				/// </java-name>
				[Dot42.DexImport("ACTION_MEDIA_BUTTON", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_MEDIA_BUTTON = "android.intent.action.MEDIA_BUTTON";
				/// <java-name>
				/// ACTION_CAMERA_BUTTON
				/// </java-name>
				[Dot42.DexImport("ACTION_CAMERA_BUTTON", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_CAMERA_BUTTON = "android.intent.action.CAMERA_BUTTON";
				/// <java-name>
				/// ACTION_GTALK_SERVICE_CONNECTED
				/// </java-name>
				[Dot42.DexImport("ACTION_GTALK_SERVICE_CONNECTED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_GTALK_SERVICE_CONNECTED = "android.intent.action.GTALK_CONNECTED";
				/// <java-name>
				/// ACTION_GTALK_SERVICE_DISCONNECTED
				/// </java-name>
				[Dot42.DexImport("ACTION_GTALK_SERVICE_DISCONNECTED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_GTALK_SERVICE_DISCONNECTED = "android.intent.action.GTALK_DISCONNECTED";
				/// <java-name>
				/// ACTION_INPUT_METHOD_CHANGED
				/// </java-name>
				[Dot42.DexImport("ACTION_INPUT_METHOD_CHANGED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_INPUT_METHOD_CHANGED = "android.intent.action.INPUT_METHOD_CHANGED";
				/// <java-name>
				/// ACTION_AIRPLANE_MODE_CHANGED
				/// </java-name>
				[Dot42.DexImport("ACTION_AIRPLANE_MODE_CHANGED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_AIRPLANE_MODE_CHANGED = "android.intent.action.AIRPLANE_MODE";
				/// <java-name>
				/// ACTION_PROVIDER_CHANGED
				/// </java-name>
				[Dot42.DexImport("ACTION_PROVIDER_CHANGED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_PROVIDER_CHANGED = "android.intent.action.PROVIDER_CHANGED";
				/// <java-name>
				/// ACTION_HEADSET_PLUG
				/// </java-name>
				[Dot42.DexImport("ACTION_HEADSET_PLUG", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_HEADSET_PLUG = "android.intent.action.HEADSET_PLUG";
				/// <java-name>
				/// ACTION_NEW_OUTGOING_CALL
				/// </java-name>
				[Dot42.DexImport("ACTION_NEW_OUTGOING_CALL", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_NEW_OUTGOING_CALL = "android.intent.action.NEW_OUTGOING_CALL";
				/// <java-name>
				/// ACTION_REBOOT
				/// </java-name>
				[Dot42.DexImport("ACTION_REBOOT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_REBOOT = "android.intent.action.REBOOT";
				/// <java-name>
				/// ACTION_DOCK_EVENT
				/// </java-name>
				[Dot42.DexImport("ACTION_DOCK_EVENT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_DOCK_EVENT = "android.intent.action.DOCK_EVENT";
				/// <java-name>
				/// CATEGORY_DEFAULT
				/// </java-name>
				[Dot42.DexImport("CATEGORY_DEFAULT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string CATEGORY_DEFAULT = "android.intent.category.DEFAULT";
				/// <java-name>
				/// CATEGORY_BROWSABLE
				/// </java-name>
				[Dot42.DexImport("CATEGORY_BROWSABLE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string CATEGORY_BROWSABLE = "android.intent.category.BROWSABLE";
				/// <java-name>
				/// CATEGORY_ALTERNATIVE
				/// </java-name>
				[Dot42.DexImport("CATEGORY_ALTERNATIVE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string CATEGORY_ALTERNATIVE = "android.intent.category.ALTERNATIVE";
				/// <java-name>
				/// CATEGORY_SELECTED_ALTERNATIVE
				/// </java-name>
				[Dot42.DexImport("CATEGORY_SELECTED_ALTERNATIVE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string CATEGORY_SELECTED_ALTERNATIVE = "android.intent.category.SELECTED_ALTERNATIVE";
				/// <java-name>
				/// CATEGORY_TAB
				/// </java-name>
				[Dot42.DexImport("CATEGORY_TAB", "Ljava/lang/String;", AccessFlags = 25)]
				public const string CATEGORY_TAB = "android.intent.category.TAB";
				/// <java-name>
				/// CATEGORY_LAUNCHER
				/// </java-name>
				[Dot42.DexImport("CATEGORY_LAUNCHER", "Ljava/lang/String;", AccessFlags = 25)]
				public const string CATEGORY_LAUNCHER = "android.intent.category.LAUNCHER";
				/// <java-name>
				/// CATEGORY_INFO
				/// </java-name>
				[Dot42.DexImport("CATEGORY_INFO", "Ljava/lang/String;", AccessFlags = 25)]
				public const string CATEGORY_INFO = "android.intent.category.INFO";
				/// <java-name>
				/// CATEGORY_HOME
				/// </java-name>
				[Dot42.DexImport("CATEGORY_HOME", "Ljava/lang/String;", AccessFlags = 25)]
				public const string CATEGORY_HOME = "android.intent.category.HOME";
				/// <java-name>
				/// CATEGORY_PREFERENCE
				/// </java-name>
				[Dot42.DexImport("CATEGORY_PREFERENCE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string CATEGORY_PREFERENCE = "android.intent.category.PREFERENCE";
				/// <java-name>
				/// CATEGORY_DEVELOPMENT_PREFERENCE
				/// </java-name>
				[Dot42.DexImport("CATEGORY_DEVELOPMENT_PREFERENCE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string CATEGORY_DEVELOPMENT_PREFERENCE = "android.intent.category.DEVELOPMENT_PREFERENCE";
				/// <java-name>
				/// CATEGORY_EMBED
				/// </java-name>
				[Dot42.DexImport("CATEGORY_EMBED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string CATEGORY_EMBED = "android.intent.category.EMBED";
				/// <java-name>
				/// CATEGORY_APP_MARKET
				/// </java-name>
				[Dot42.DexImport("CATEGORY_APP_MARKET", "Ljava/lang/String;", AccessFlags = 25)]
				public const string CATEGORY_APP_MARKET = "android.intent.category.APP_MARKET";
				/// <java-name>
				/// CATEGORY_MONKEY
				/// </java-name>
				[Dot42.DexImport("CATEGORY_MONKEY", "Ljava/lang/String;", AccessFlags = 25)]
				public const string CATEGORY_MONKEY = "android.intent.category.MONKEY";
				/// <java-name>
				/// CATEGORY_TEST
				/// </java-name>
				[Dot42.DexImport("CATEGORY_TEST", "Ljava/lang/String;", AccessFlags = 25)]
				public const string CATEGORY_TEST = "android.intent.category.TEST";
				/// <java-name>
				/// CATEGORY_UNIT_TEST
				/// </java-name>
				[Dot42.DexImport("CATEGORY_UNIT_TEST", "Ljava/lang/String;", AccessFlags = 25)]
				public const string CATEGORY_UNIT_TEST = "android.intent.category.UNIT_TEST";
				/// <java-name>
				/// CATEGORY_SAMPLE_CODE
				/// </java-name>
				[Dot42.DexImport("CATEGORY_SAMPLE_CODE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string CATEGORY_SAMPLE_CODE = "android.intent.category.SAMPLE_CODE";
				/// <java-name>
				/// CATEGORY_OPENABLE
				/// </java-name>
				[Dot42.DexImport("CATEGORY_OPENABLE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string CATEGORY_OPENABLE = "android.intent.category.OPENABLE";
				/// <java-name>
				/// CATEGORY_FRAMEWORK_INSTRUMENTATION_TEST
				/// </java-name>
				[Dot42.DexImport("CATEGORY_FRAMEWORK_INSTRUMENTATION_TEST", "Ljava/lang/String;", AccessFlags = 25)]
				public const string CATEGORY_FRAMEWORK_INSTRUMENTATION_TEST = "android.intent.category.FRAMEWORK_INSTRUMENTATION_TEST";
				/// <java-name>
				/// CATEGORY_CAR_DOCK
				/// </java-name>
				[Dot42.DexImport("CATEGORY_CAR_DOCK", "Ljava/lang/String;", AccessFlags = 25)]
				public const string CATEGORY_CAR_DOCK = "android.intent.category.CAR_DOCK";
				/// <java-name>
				/// CATEGORY_DESK_DOCK
				/// </java-name>
				[Dot42.DexImport("CATEGORY_DESK_DOCK", "Ljava/lang/String;", AccessFlags = 25)]
				public const string CATEGORY_DESK_DOCK = "android.intent.category.DESK_DOCK";
				/// <java-name>
				/// CATEGORY_LE_DESK_DOCK
				/// </java-name>
				[Dot42.DexImport("CATEGORY_LE_DESK_DOCK", "Ljava/lang/String;", AccessFlags = 25)]
				public const string CATEGORY_LE_DESK_DOCK = "android.intent.category.LE_DESK_DOCK";
				/// <java-name>
				/// CATEGORY_HE_DESK_DOCK
				/// </java-name>
				[Dot42.DexImport("CATEGORY_HE_DESK_DOCK", "Ljava/lang/String;", AccessFlags = 25)]
				public const string CATEGORY_HE_DESK_DOCK = "android.intent.category.HE_DESK_DOCK";
				/// <java-name>
				/// CATEGORY_CAR_MODE
				/// </java-name>
				[Dot42.DexImport("CATEGORY_CAR_MODE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string CATEGORY_CAR_MODE = "android.intent.category.CAR_MODE";
				/// <java-name>
				/// CATEGORY_APP_BROWSER
				/// </java-name>
				[Dot42.DexImport("CATEGORY_APP_BROWSER", "Ljava/lang/String;", AccessFlags = 25)]
				public const string CATEGORY_APP_BROWSER = "android.intent.category.APP_BROWSER";
				/// <java-name>
				/// CATEGORY_APP_CALCULATOR
				/// </java-name>
				[Dot42.DexImport("CATEGORY_APP_CALCULATOR", "Ljava/lang/String;", AccessFlags = 25)]
				public const string CATEGORY_APP_CALCULATOR = "android.intent.category.APP_CALCULATOR";
				/// <java-name>
				/// CATEGORY_APP_CALENDAR
				/// </java-name>
				[Dot42.DexImport("CATEGORY_APP_CALENDAR", "Ljava/lang/String;", AccessFlags = 25)]
				public const string CATEGORY_APP_CALENDAR = "android.intent.category.APP_CALENDAR";
				/// <java-name>
				/// CATEGORY_APP_CONTACTS
				/// </java-name>
				[Dot42.DexImport("CATEGORY_APP_CONTACTS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string CATEGORY_APP_CONTACTS = "android.intent.category.APP_CONTACTS";
				/// <java-name>
				/// CATEGORY_APP_EMAIL
				/// </java-name>
				[Dot42.DexImport("CATEGORY_APP_EMAIL", "Ljava/lang/String;", AccessFlags = 25)]
				public const string CATEGORY_APP_EMAIL = "android.intent.category.APP_EMAIL";
				/// <java-name>
				/// CATEGORY_APP_GALLERY
				/// </java-name>
				[Dot42.DexImport("CATEGORY_APP_GALLERY", "Ljava/lang/String;", AccessFlags = 25)]
				public const string CATEGORY_APP_GALLERY = "android.intent.category.APP_GALLERY";
				/// <java-name>
				/// CATEGORY_APP_MAPS
				/// </java-name>
				[Dot42.DexImport("CATEGORY_APP_MAPS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string CATEGORY_APP_MAPS = "android.intent.category.APP_MAPS";
				/// <java-name>
				/// CATEGORY_APP_MESSAGING
				/// </java-name>
				[Dot42.DexImport("CATEGORY_APP_MESSAGING", "Ljava/lang/String;", AccessFlags = 25)]
				public const string CATEGORY_APP_MESSAGING = "android.intent.category.APP_MESSAGING";
				/// <java-name>
				/// CATEGORY_APP_MUSIC
				/// </java-name>
				[Dot42.DexImport("CATEGORY_APP_MUSIC", "Ljava/lang/String;", AccessFlags = 25)]
				public const string CATEGORY_APP_MUSIC = "android.intent.category.APP_MUSIC";
				/// <java-name>
				/// EXTRA_TEMPLATE
				/// </java-name>
				[Dot42.DexImport("EXTRA_TEMPLATE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_TEMPLATE = "android.intent.extra.TEMPLATE";
				/// <java-name>
				/// EXTRA_TEXT
				/// </java-name>
				[Dot42.DexImport("EXTRA_TEXT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_TEXT = "android.intent.extra.TEXT";
				/// <java-name>
				/// EXTRA_STREAM
				/// </java-name>
				[Dot42.DexImport("EXTRA_STREAM", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_STREAM = "android.intent.extra.STREAM";
				/// <java-name>
				/// EXTRA_EMAIL
				/// </java-name>
				[Dot42.DexImport("EXTRA_EMAIL", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_EMAIL = "android.intent.extra.EMAIL";
				/// <java-name>
				/// EXTRA_CC
				/// </java-name>
				[Dot42.DexImport("EXTRA_CC", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_CC = "android.intent.extra.CC";
				/// <java-name>
				/// EXTRA_BCC
				/// </java-name>
				[Dot42.DexImport("EXTRA_BCC", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_BCC = "android.intent.extra.BCC";
				/// <java-name>
				/// EXTRA_SUBJECT
				/// </java-name>
				[Dot42.DexImport("EXTRA_SUBJECT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_SUBJECT = "android.intent.extra.SUBJECT";
				/// <java-name>
				/// EXTRA_INTENT
				/// </java-name>
				[Dot42.DexImport("EXTRA_INTENT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_INTENT = "android.intent.extra.INTENT";
				/// <java-name>
				/// EXTRA_TITLE
				/// </java-name>
				[Dot42.DexImport("EXTRA_TITLE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_TITLE = "android.intent.extra.TITLE";
				/// <java-name>
				/// EXTRA_INITIAL_INTENTS
				/// </java-name>
				[Dot42.DexImport("EXTRA_INITIAL_INTENTS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_INITIAL_INTENTS = "android.intent.extra.INITIAL_INTENTS";
				/// <java-name>
				/// EXTRA_KEY_EVENT
				/// </java-name>
				[Dot42.DexImport("EXTRA_KEY_EVENT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_KEY_EVENT = "android.intent.extra.KEY_EVENT";
				/// <java-name>
				/// EXTRA_DONT_KILL_APP
				/// </java-name>
				[Dot42.DexImport("EXTRA_DONT_KILL_APP", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_DONT_KILL_APP = "android.intent.extra.DONT_KILL_APP";
				/// <java-name>
				/// EXTRA_PHONE_NUMBER
				/// </java-name>
				[Dot42.DexImport("EXTRA_PHONE_NUMBER", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_PHONE_NUMBER = "android.intent.extra.PHONE_NUMBER";
				/// <java-name>
				/// EXTRA_UID
				/// </java-name>
				[Dot42.DexImport("EXTRA_UID", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_UID = "android.intent.extra.UID";
				/// <java-name>
				/// EXTRA_DATA_REMOVED
				/// </java-name>
				[Dot42.DexImport("EXTRA_DATA_REMOVED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_DATA_REMOVED = "android.intent.extra.DATA_REMOVED";
				/// <java-name>
				/// EXTRA_REPLACING
				/// </java-name>
				[Dot42.DexImport("EXTRA_REPLACING", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_REPLACING = "android.intent.extra.REPLACING";
				/// <java-name>
				/// EXTRA_ALARM_COUNT
				/// </java-name>
				[Dot42.DexImport("EXTRA_ALARM_COUNT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_ALARM_COUNT = "android.intent.extra.ALARM_COUNT";
				/// <java-name>
				/// EXTRA_DOCK_STATE
				/// </java-name>
				[Dot42.DexImport("EXTRA_DOCK_STATE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_DOCK_STATE = "android.intent.extra.DOCK_STATE";
				/// <java-name>
				/// EXTRA_DOCK_STATE_UNDOCKED
				/// </java-name>
				[Dot42.DexImport("EXTRA_DOCK_STATE_UNDOCKED", "I", AccessFlags = 25)]
				public const int EXTRA_DOCK_STATE_UNDOCKED = 0;
				/// <java-name>
				/// EXTRA_DOCK_STATE_DESK
				/// </java-name>
				[Dot42.DexImport("EXTRA_DOCK_STATE_DESK", "I", AccessFlags = 25)]
				public const int EXTRA_DOCK_STATE_DESK = 1;
				/// <java-name>
				/// EXTRA_DOCK_STATE_CAR
				/// </java-name>
				[Dot42.DexImport("EXTRA_DOCK_STATE_CAR", "I", AccessFlags = 25)]
				public const int EXTRA_DOCK_STATE_CAR = 2;
				/// <java-name>
				/// EXTRA_DOCK_STATE_LE_DESK
				/// </java-name>
				[Dot42.DexImport("EXTRA_DOCK_STATE_LE_DESK", "I", AccessFlags = 25)]
				public const int EXTRA_DOCK_STATE_LE_DESK = 3;
				/// <java-name>
				/// EXTRA_DOCK_STATE_HE_DESK
				/// </java-name>
				[Dot42.DexImport("EXTRA_DOCK_STATE_HE_DESK", "I", AccessFlags = 25)]
				public const int EXTRA_DOCK_STATE_HE_DESK = 4;
				/// <java-name>
				/// METADATA_DOCK_HOME
				/// </java-name>
				[Dot42.DexImport("METADATA_DOCK_HOME", "Ljava/lang/String;", AccessFlags = 25)]
				public const string METADATA_DOCK_HOME = "android.dock_home";
				/// <java-name>
				/// EXTRA_BUG_REPORT
				/// </java-name>
				[Dot42.DexImport("EXTRA_BUG_REPORT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_BUG_REPORT = "android.intent.extra.BUG_REPORT";
				/// <java-name>
				/// EXTRA_REMOTE_INTENT_TOKEN
				/// </java-name>
				[Dot42.DexImport("EXTRA_REMOTE_INTENT_TOKEN", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_REMOTE_INTENT_TOKEN = "android.intent.extra.remote_intent_token";
				/// <java-name>
				/// EXTRA_CHANGED_COMPONENT_NAME
				/// </java-name>
				[Dot42.DexImport("EXTRA_CHANGED_COMPONENT_NAME", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_CHANGED_COMPONENT_NAME = "android.intent.extra.changed_component_name";
				/// <java-name>
				/// EXTRA_CHANGED_COMPONENT_NAME_LIST
				/// </java-name>
				[Dot42.DexImport("EXTRA_CHANGED_COMPONENT_NAME_LIST", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_CHANGED_COMPONENT_NAME_LIST = "android.intent.extra.changed_component_name_list";
				/// <java-name>
				/// EXTRA_CHANGED_PACKAGE_LIST
				/// </java-name>
				[Dot42.DexImport("EXTRA_CHANGED_PACKAGE_LIST", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_CHANGED_PACKAGE_LIST = "android.intent.extra.changed_package_list";
				/// <java-name>
				/// EXTRA_CHANGED_UID_LIST
				/// </java-name>
				[Dot42.DexImport("EXTRA_CHANGED_UID_LIST", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_CHANGED_UID_LIST = "android.intent.extra.changed_uid_list";
				/// <java-name>
				/// EXTRA_LOCAL_ONLY
				/// </java-name>
				[Dot42.DexImport("EXTRA_LOCAL_ONLY", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_LOCAL_ONLY = "android.intent.extra.LOCAL_ONLY";
				/// <java-name>
				/// FLAG_GRANT_READ_URI_PERMISSION
				/// </java-name>
				[Dot42.DexImport("FLAG_GRANT_READ_URI_PERMISSION", "I", AccessFlags = 25)]
				public const int FLAG_GRANT_READ_URI_PERMISSION = 1;
				/// <java-name>
				/// FLAG_GRANT_WRITE_URI_PERMISSION
				/// </java-name>
				[Dot42.DexImport("FLAG_GRANT_WRITE_URI_PERMISSION", "I", AccessFlags = 25)]
				public const int FLAG_GRANT_WRITE_URI_PERMISSION = 2;
				/// <java-name>
				/// FLAG_FROM_BACKGROUND
				/// </java-name>
				[Dot42.DexImport("FLAG_FROM_BACKGROUND", "I", AccessFlags = 25)]
				public const int FLAG_FROM_BACKGROUND = 4;
				/// <java-name>
				/// FLAG_DEBUG_LOG_RESOLUTION
				/// </java-name>
				[Dot42.DexImport("FLAG_DEBUG_LOG_RESOLUTION", "I", AccessFlags = 25)]
				public const int FLAG_DEBUG_LOG_RESOLUTION = 8;
				/// <java-name>
				/// FLAG_EXCLUDE_STOPPED_PACKAGES
				/// </java-name>
				[Dot42.DexImport("FLAG_EXCLUDE_STOPPED_PACKAGES", "I", AccessFlags = 25)]
				public const int FLAG_EXCLUDE_STOPPED_PACKAGES = 16;
				/// <java-name>
				/// FLAG_INCLUDE_STOPPED_PACKAGES
				/// </java-name>
				[Dot42.DexImport("FLAG_INCLUDE_STOPPED_PACKAGES", "I", AccessFlags = 25)]
				public const int FLAG_INCLUDE_STOPPED_PACKAGES = 32;
				/// <java-name>
				/// FLAG_ACTIVITY_NO_HISTORY
				/// </java-name>
				[Dot42.DexImport("FLAG_ACTIVITY_NO_HISTORY", "I", AccessFlags = 25)]
				public const int FLAG_ACTIVITY_NO_HISTORY = 1073741824;
				/// <java-name>
				/// FLAG_ACTIVITY_SINGLE_TOP
				/// </java-name>
				[Dot42.DexImport("FLAG_ACTIVITY_SINGLE_TOP", "I", AccessFlags = 25)]
				public const int FLAG_ACTIVITY_SINGLE_TOP = 536870912;
				/// <java-name>
				/// FLAG_ACTIVITY_NEW_TASK
				/// </java-name>
				[Dot42.DexImport("FLAG_ACTIVITY_NEW_TASK", "I", AccessFlags = 25)]
				public const int FLAG_ACTIVITY_NEW_TASK = 268435456;
				/// <java-name>
				/// FLAG_ACTIVITY_MULTIPLE_TASK
				/// </java-name>
				[Dot42.DexImport("FLAG_ACTIVITY_MULTIPLE_TASK", "I", AccessFlags = 25)]
				public const int FLAG_ACTIVITY_MULTIPLE_TASK = 134217728;
				/// <java-name>
				/// FLAG_ACTIVITY_CLEAR_TOP
				/// </java-name>
				[Dot42.DexImport("FLAG_ACTIVITY_CLEAR_TOP", "I", AccessFlags = 25)]
				public const int FLAG_ACTIVITY_CLEAR_TOP = 67108864;
				/// <java-name>
				/// FLAG_ACTIVITY_FORWARD_RESULT
				/// </java-name>
				[Dot42.DexImport("FLAG_ACTIVITY_FORWARD_RESULT", "I", AccessFlags = 25)]
				public const int FLAG_ACTIVITY_FORWARD_RESULT = 33554432;
				/// <java-name>
				/// FLAG_ACTIVITY_PREVIOUS_IS_TOP
				/// </java-name>
				[Dot42.DexImport("FLAG_ACTIVITY_PREVIOUS_IS_TOP", "I", AccessFlags = 25)]
				public const int FLAG_ACTIVITY_PREVIOUS_IS_TOP = 16777216;
				/// <java-name>
				/// FLAG_ACTIVITY_EXCLUDE_FROM_RECENTS
				/// </java-name>
				[Dot42.DexImport("FLAG_ACTIVITY_EXCLUDE_FROM_RECENTS", "I", AccessFlags = 25)]
				public const int FLAG_ACTIVITY_EXCLUDE_FROM_RECENTS = 8388608;
				/// <java-name>
				/// FLAG_ACTIVITY_BROUGHT_TO_FRONT
				/// </java-name>
				[Dot42.DexImport("FLAG_ACTIVITY_BROUGHT_TO_FRONT", "I", AccessFlags = 25)]
				public const int FLAG_ACTIVITY_BROUGHT_TO_FRONT = 4194304;
				/// <java-name>
				/// FLAG_ACTIVITY_RESET_TASK_IF_NEEDED
				/// </java-name>
				[Dot42.DexImport("FLAG_ACTIVITY_RESET_TASK_IF_NEEDED", "I", AccessFlags = 25)]
				public const int FLAG_ACTIVITY_RESET_TASK_IF_NEEDED = 2097152;
				/// <java-name>
				/// FLAG_ACTIVITY_LAUNCHED_FROM_HISTORY
				/// </java-name>
				[Dot42.DexImport("FLAG_ACTIVITY_LAUNCHED_FROM_HISTORY", "I", AccessFlags = 25)]
				public const int FLAG_ACTIVITY_LAUNCHED_FROM_HISTORY = 1048576;
				/// <java-name>
				/// FLAG_ACTIVITY_CLEAR_WHEN_TASK_RESET
				/// </java-name>
				[Dot42.DexImport("FLAG_ACTIVITY_CLEAR_WHEN_TASK_RESET", "I", AccessFlags = 25)]
				public const int FLAG_ACTIVITY_CLEAR_WHEN_TASK_RESET = 524288;
				/// <java-name>
				/// FLAG_ACTIVITY_NO_USER_ACTION
				/// </java-name>
				[Dot42.DexImport("FLAG_ACTIVITY_NO_USER_ACTION", "I", AccessFlags = 25)]
				public const int FLAG_ACTIVITY_NO_USER_ACTION = 262144;
				/// <java-name>
				/// FLAG_ACTIVITY_REORDER_TO_FRONT
				/// </java-name>
				[Dot42.DexImport("FLAG_ACTIVITY_REORDER_TO_FRONT", "I", AccessFlags = 25)]
				public const int FLAG_ACTIVITY_REORDER_TO_FRONT = 131072;
				/// <java-name>
				/// FLAG_ACTIVITY_NO_ANIMATION
				/// </java-name>
				[Dot42.DexImport("FLAG_ACTIVITY_NO_ANIMATION", "I", AccessFlags = 25)]
				public const int FLAG_ACTIVITY_NO_ANIMATION = 65536;
				/// <java-name>
				/// FLAG_ACTIVITY_CLEAR_TASK
				/// </java-name>
				[Dot42.DexImport("FLAG_ACTIVITY_CLEAR_TASK", "I", AccessFlags = 25)]
				public const int FLAG_ACTIVITY_CLEAR_TASK = 32768;
				/// <java-name>
				/// FLAG_ACTIVITY_TASK_ON_HOME
				/// </java-name>
				[Dot42.DexImport("FLAG_ACTIVITY_TASK_ON_HOME", "I", AccessFlags = 25)]
				public const int FLAG_ACTIVITY_TASK_ON_HOME = 16384;
				/// <java-name>
				/// FLAG_RECEIVER_REGISTERED_ONLY
				/// </java-name>
				[Dot42.DexImport("FLAG_RECEIVER_REGISTERED_ONLY", "I", AccessFlags = 25)]
				public const int FLAG_RECEIVER_REGISTERED_ONLY = 1073741824;
				/// <java-name>
				/// FLAG_RECEIVER_REPLACE_PENDING
				/// </java-name>
				[Dot42.DexImport("FLAG_RECEIVER_REPLACE_PENDING", "I", AccessFlags = 25)]
				public const int FLAG_RECEIVER_REPLACE_PENDING = 536870912;
				/// <java-name>
				/// URI_INTENT_SCHEME
				/// </java-name>
				[Dot42.DexImport("URI_INTENT_SCHEME", "I", AccessFlags = 25)]
				public const int URI_INTENT_SCHEME = 1;
				/// <java-name>
				/// FILL_IN_ACTION
				/// </java-name>
				[Dot42.DexImport("FILL_IN_ACTION", "I", AccessFlags = 25)]
				public const int FILL_IN_ACTION = 1;
				/// <java-name>
				/// FILL_IN_DATA
				/// </java-name>
				[Dot42.DexImport("FILL_IN_DATA", "I", AccessFlags = 25)]
				public const int FILL_IN_DATA = 2;
				/// <java-name>
				/// FILL_IN_CATEGORIES
				/// </java-name>
				[Dot42.DexImport("FILL_IN_CATEGORIES", "I", AccessFlags = 25)]
				public const int FILL_IN_CATEGORIES = 4;
				/// <java-name>
				/// FILL_IN_COMPONENT
				/// </java-name>
				[Dot42.DexImport("FILL_IN_COMPONENT", "I", AccessFlags = 25)]
				public const int FILL_IN_COMPONENT = 8;
				/// <java-name>
				/// FILL_IN_PACKAGE
				/// </java-name>
				[Dot42.DexImport("FILL_IN_PACKAGE", "I", AccessFlags = 25)]
				public const int FILL_IN_PACKAGE = 16;
				/// <java-name>
				/// FILL_IN_SOURCE_BOUNDS
				/// </java-name>
				[Dot42.DexImport("FILL_IN_SOURCE_BOUNDS", "I", AccessFlags = 25)]
				public const int FILL_IN_SOURCE_BOUNDS = 32;
				/// <java-name>
				/// FILL_IN_SELECTOR
				/// </java-name>
				[Dot42.DexImport("FILL_IN_SELECTOR", "I", AccessFlags = 25)]
				public const int FILL_IN_SELECTOR = 64;
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.Os.IParcelable_ICreator<global::Android.Content.Intent> CREATOR;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Intent() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Intent;)V", AccessFlags = 1)]
				public Intent(global::Android.Content.Intent intent) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public Intent(string @string) /* MethodBuilder.Create */ 
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

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Landroid/net/Uri;Landroid/content/Context;Ljava/lang/Class;)V", AccessFlags = 1, Signature = "(Ljava/lang/String;Landroid/net/Uri;Landroid/content/Context;Ljava/lang/Class<*>;" +
    ")V")]
				public Intent(string @string, global::Android.Net.Uri uri, global::Android.Content.Context context, global::System.Type type) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// createChooser
				/// </java-name>
				[Dot42.DexImport("createChooser", "(Landroid/content/Intent;Ljava/lang/CharSequence;)Landroid/content/Intent;", AccessFlags = 9)]
				public static global::Android.Content.Intent CreateChooser(global::Android.Content.Intent intent, global::Java.Lang.ICharSequence charSequence) /* MethodBuilder.Create */ 
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

				/// <java-name>
				/// cloneFilter
				/// </java-name>
				[Dot42.DexImport("cloneFilter", "()Landroid/content/Intent;", AccessFlags = 1)]
				public virtual global::Android.Content.Intent CloneFilter() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Intent);
				}

				/// <java-name>
				/// makeMainActivity
				/// </java-name>
				[Dot42.DexImport("makeMainActivity", "(Landroid/content/ComponentName;)Landroid/content/Intent;", AccessFlags = 9)]
				public static global::Android.Content.Intent MakeMainActivity(global::Android.Content.ComponentName componentName) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Intent);
				}

				/// <java-name>
				/// makeMainSelectorActivity
				/// </java-name>
				[Dot42.DexImport("makeMainSelectorActivity", "(Ljava/lang/String;Ljava/lang/String;)Landroid/content/Intent;", AccessFlags = 9)]
				public static global::Android.Content.Intent MakeMainSelectorActivity(string @string, string string1) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Intent);
				}

				/// <java-name>
				/// makeRestartActivityTask
				/// </java-name>
				[Dot42.DexImport("makeRestartActivityTask", "(Landroid/content/ComponentName;)Landroid/content/Intent;", AccessFlags = 9)]
				public static global::Android.Content.Intent MakeRestartActivityTask(global::Android.Content.ComponentName componentName) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Intent);
				}

				/// <java-name>
				/// getIntent
				/// </java-name>
				[Dot42.DexImport("getIntent", "(Ljava/lang/String;)Landroid/content/Intent;", AccessFlags = 9)]
				public static global::Android.Content.Intent GetIntent(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Intent);
				}

				/// <java-name>
				/// parseUri
				/// </java-name>
				[Dot42.DexImport("parseUri", "(Ljava/lang/String;I)Landroid/content/Intent;", AccessFlags = 9)]
				public static global::Android.Content.Intent ParseUri(string @string, int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Intent);
				}

				/// <java-name>
				/// getIntentOld
				/// </java-name>
				[Dot42.DexImport("getIntentOld", "(Ljava/lang/String;)Landroid/content/Intent;", AccessFlags = 9)]
				public static global::Android.Content.Intent GetIntentOld(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Intent);
				}

				/// <java-name>
				/// getAction
				/// </java-name>
				[Dot42.DexImport("getAction", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetAction() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getData
				/// </java-name>
				[Dot42.DexImport("getData", "()Landroid/net/Uri;", AccessFlags = 1)]
				public virtual global::Android.Net.Uri GetData() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Net.Uri);
				}

				/// <java-name>
				/// getDataString
				/// </java-name>
				[Dot42.DexImport("getDataString", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetDataString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getScheme
				/// </java-name>
				[Dot42.DexImport("getScheme", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetScheme() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getType
				/// </java-name>
				[Dot42.DexImport("getType", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetType() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// resolveType
				/// </java-name>
				[Dot42.DexImport("resolveType", "(Landroid/content/Context;)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string ResolveType(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// resolveType
				/// </java-name>
				[Dot42.DexImport("resolveType", "(Landroid/content/ContentResolver;)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string ResolveType(global::Android.Content.ContentResolver contentResolver) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// resolveTypeIfNeeded
				/// </java-name>
				[Dot42.DexImport("resolveTypeIfNeeded", "(Landroid/content/ContentResolver;)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string ResolveTypeIfNeeded(global::Android.Content.ContentResolver contentResolver) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// hasCategory
				/// </java-name>
				[Dot42.DexImport("hasCategory", "(Ljava/lang/String;)Z", AccessFlags = 1)]
				public virtual bool HasCategory(string @string) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getCategories
				/// </java-name>
				[Dot42.DexImport("getCategories", "()Ljava/util/Set;", AccessFlags = 1, Signature = "()Ljava/util/Set<Ljava/lang/String;>;")]
				public virtual global::Java.Util.ISet<string> GetCategories() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ISet<string>);
				}

				/// <java-name>
				/// getSelector
				/// </java-name>
				[Dot42.DexImport("getSelector", "()Landroid/content/Intent;", AccessFlags = 1)]
				public virtual global::Android.Content.Intent GetSelector() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Intent);
				}

				/// <java-name>
				/// setExtrasClassLoader
				/// </java-name>
				[Dot42.DexImport("setExtrasClassLoader", "(Ljava/lang/ClassLoader;)V", AccessFlags = 1)]
				public virtual void SetExtrasClassLoader(global::Java.Lang.ClassLoader classLoader) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// hasExtra
				/// </java-name>
				[Dot42.DexImport("hasExtra", "(Ljava/lang/String;)Z", AccessFlags = 1)]
				public virtual bool HasExtra(string @string) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// hasFileDescriptors
				/// </java-name>
				[Dot42.DexImport("hasFileDescriptors", "()Z", AccessFlags = 1)]
				public virtual bool HasFileDescriptors() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getBooleanExtra
				/// </java-name>
				[Dot42.DexImport("getBooleanExtra", "(Ljava/lang/String;Z)Z", AccessFlags = 1)]
				public virtual bool GetBooleanExtra(string @string, bool boolean) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getByteExtra
				/// </java-name>
				[Dot42.DexImport("getByteExtra", "(Ljava/lang/String;B)B", AccessFlags = 1)]
				public virtual sbyte GetByteExtra(string @string, sbyte sByte) /* MethodBuilder.Create */ 
				{
						return default(sbyte);
				}

				/// <java-name>
				/// getByteExtra
				/// </java-name>
				[Dot42.DexImport("getByteExtra", "(Ljava/lang/String;B)B", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual byte GetByteExtra(string @string, byte @byte) /* MethodBuilder.Create */ 
				{
						return default(byte);
				}

				/// <java-name>
				/// getShortExtra
				/// </java-name>
				[Dot42.DexImport("getShortExtra", "(Ljava/lang/String;S)S", AccessFlags = 1)]
				public virtual short GetShortExtra(string @string, short int16) /* MethodBuilder.Create */ 
				{
						return default(short);
				}

				/// <java-name>
				/// getCharExtra
				/// </java-name>
				[Dot42.DexImport("getCharExtra", "(Ljava/lang/String;C)C", AccessFlags = 1)]
				public virtual char GetCharExtra(string @string, char @char) /* MethodBuilder.Create */ 
				{
						return default(char);
				}

				/// <java-name>
				/// getIntExtra
				/// </java-name>
				[Dot42.DexImport("getIntExtra", "(Ljava/lang/String;I)I", AccessFlags = 1)]
				public virtual int GetIntExtra(string @string, int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getLongExtra
				/// </java-name>
				[Dot42.DexImport("getLongExtra", "(Ljava/lang/String;J)J", AccessFlags = 1)]
				public virtual long GetLongExtra(string @string, long int64) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// getFloatExtra
				/// </java-name>
				[Dot42.DexImport("getFloatExtra", "(Ljava/lang/String;F)F", AccessFlags = 1)]
				public virtual float GetFloatExtra(string @string, float single) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// getDoubleExtra
				/// </java-name>
				[Dot42.DexImport("getDoubleExtra", "(Ljava/lang/String;D)D", AccessFlags = 1)]
				public virtual double GetDoubleExtra(string @string, double @double) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <java-name>
				/// getStringExtra
				/// </java-name>
				[Dot42.DexImport("getStringExtra", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetStringExtra(string @string) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getCharSequenceExtra
				/// </java-name>
				[Dot42.DexImport("getCharSequenceExtra", "(Ljava/lang/String;)Ljava/lang/CharSequence;", AccessFlags = 1)]
				public virtual global::Java.Lang.ICharSequence GetCharSequenceExtra(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <java-name>
				/// getParcelableExtra
				/// </java-name>
				[Dot42.DexImport("getParcelableExtra", "(Ljava/lang/String;)Landroid/os/Parcelable;", AccessFlags = 1, Signature = "<T::Landroid/os/Parcelable;>(Ljava/lang/String;)TT;")]
				public virtual T GetParcelableExtra<T>(string @string) /* MethodBuilder.Create */ 
				{
						return default(T);
				}

				/// <java-name>
				/// getParcelableArrayExtra
				/// </java-name>
				[Dot42.DexImport("getParcelableArrayExtra", "(Ljava/lang/String;)[Landroid/os/Parcelable;", AccessFlags = 1)]
				public virtual global::Android.Os.IParcelable[] GetParcelableArrayExtra(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Os.IParcelable[]);
				}

				/// <java-name>
				/// getParcelableArrayListExtra
				/// </java-name>
				[Dot42.DexImport("getParcelableArrayListExtra", "(Ljava/lang/String;)Ljava/util/ArrayList;", AccessFlags = 1, Signature = "<T::Landroid/os/Parcelable;>(Ljava/lang/String;)Ljava/util/ArrayList<TT;>;")]
				public virtual global::Java.Util.ArrayList<T> GetParcelableArrayListExtra<T>(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ArrayList<T>);
				}

				/// <java-name>
				/// getSerializableExtra
				/// </java-name>
				[Dot42.DexImport("getSerializableExtra", "(Ljava/lang/String;)Ljava/io/Serializable;", AccessFlags = 1)]
				public virtual global::Java.Io.ISerializable GetSerializableExtra(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.ISerializable);
				}

				/// <java-name>
				/// getIntegerArrayListExtra
				/// </java-name>
				[Dot42.DexImport("getIntegerArrayListExtra", "(Ljava/lang/String;)Ljava/util/ArrayList;", AccessFlags = 1, Signature = "(Ljava/lang/String;)Ljava/util/ArrayList<Ljava/lang/Integer;>;")]
				public virtual global::Java.Util.ArrayList<int?> GetIntegerArrayListExtra(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ArrayList<int?>);
				}

				/// <java-name>
				/// getStringArrayListExtra
				/// </java-name>
				[Dot42.DexImport("getStringArrayListExtra", "(Ljava/lang/String;)Ljava/util/ArrayList;", AccessFlags = 1, Signature = "(Ljava/lang/String;)Ljava/util/ArrayList<Ljava/lang/String;>;")]
				public virtual global::Java.Util.ArrayList<string> GetStringArrayListExtra(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ArrayList<string>);
				}

				/// <java-name>
				/// getCharSequenceArrayListExtra
				/// </java-name>
				[Dot42.DexImport("getCharSequenceArrayListExtra", "(Ljava/lang/String;)Ljava/util/ArrayList;", AccessFlags = 1, Signature = "(Ljava/lang/String;)Ljava/util/ArrayList<Ljava/lang/CharSequence;>;")]
				public virtual global::Java.Util.ArrayList<global::Java.Lang.ICharSequence> GetCharSequenceArrayListExtra(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ArrayList<global::Java.Lang.ICharSequence>);
				}

				/// <java-name>
				/// getBooleanArrayExtra
				/// </java-name>
				[Dot42.DexImport("getBooleanArrayExtra", "(Ljava/lang/String;)[Z", AccessFlags = 1)]
				public virtual bool[] GetBooleanArrayExtra(string @string) /* MethodBuilder.Create */ 
				{
						return default(bool[]);
				}

				/// <java-name>
				/// getByteArrayExtra
				/// </java-name>
				[Dot42.DexImport("getByteArrayExtra", "(Ljava/lang/String;)[B", AccessFlags = 1)]
				public virtual sbyte[] JavaGetByteArrayExtra(string @string) /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <java-name>
				/// getByteArrayExtra
				/// </java-name>
				[Dot42.DexImport("getByteArrayExtra", "(Ljava/lang/String;)[B", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual byte[] GetByteArrayExtra(string @string) /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				/// <java-name>
				/// getShortArrayExtra
				/// </java-name>
				[Dot42.DexImport("getShortArrayExtra", "(Ljava/lang/String;)[S", AccessFlags = 1)]
				public virtual short[] GetShortArrayExtra(string @string) /* MethodBuilder.Create */ 
				{
						return default(short[]);
				}

				/// <java-name>
				/// getCharArrayExtra
				/// </java-name>
				[Dot42.DexImport("getCharArrayExtra", "(Ljava/lang/String;)[C", AccessFlags = 1)]
				public virtual char[] GetCharArrayExtra(string @string) /* MethodBuilder.Create */ 
				{
						return default(char[]);
				}

				/// <java-name>
				/// getIntArrayExtra
				/// </java-name>
				[Dot42.DexImport("getIntArrayExtra", "(Ljava/lang/String;)[I", AccessFlags = 1)]
				public virtual int[] GetIntArrayExtra(string @string) /* MethodBuilder.Create */ 
				{
						return default(int[]);
				}

				/// <java-name>
				/// getLongArrayExtra
				/// </java-name>
				[Dot42.DexImport("getLongArrayExtra", "(Ljava/lang/String;)[J", AccessFlags = 1)]
				public virtual long[] GetLongArrayExtra(string @string) /* MethodBuilder.Create */ 
				{
						return default(long[]);
				}

				/// <java-name>
				/// getFloatArrayExtra
				/// </java-name>
				[Dot42.DexImport("getFloatArrayExtra", "(Ljava/lang/String;)[F", AccessFlags = 1)]
				public virtual float[] GetFloatArrayExtra(string @string) /* MethodBuilder.Create */ 
				{
						return default(float[]);
				}

				/// <java-name>
				/// getDoubleArrayExtra
				/// </java-name>
				[Dot42.DexImport("getDoubleArrayExtra", "(Ljava/lang/String;)[D", AccessFlags = 1)]
				public virtual double[] GetDoubleArrayExtra(string @string) /* MethodBuilder.Create */ 
				{
						return default(double[]);
				}

				/// <java-name>
				/// getStringArrayExtra
				/// </java-name>
				[Dot42.DexImport("getStringArrayExtra", "(Ljava/lang/String;)[Ljava/lang/String;", AccessFlags = 1)]
				public virtual string[] GetStringArrayExtra(string @string) /* MethodBuilder.Create */ 
				{
						return default(string[]);
				}

				/// <java-name>
				/// getCharSequenceArrayExtra
				/// </java-name>
				[Dot42.DexImport("getCharSequenceArrayExtra", "(Ljava/lang/String;)[Ljava/lang/CharSequence;", AccessFlags = 1)]
				public virtual global::Java.Lang.ICharSequence[] GetCharSequenceArrayExtra(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence[]);
				}

				/// <java-name>
				/// getBundleExtra
				/// </java-name>
				[Dot42.DexImport("getBundleExtra", "(Ljava/lang/String;)Landroid/os/Bundle;", AccessFlags = 1)]
				public virtual global::Android.Os.Bundle GetBundleExtra(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Os.Bundle);
				}

				/// <java-name>
				/// getExtras
				/// </java-name>
				[Dot42.DexImport("getExtras", "()Landroid/os/Bundle;", AccessFlags = 1)]
				public virtual global::Android.Os.Bundle GetExtras() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Os.Bundle);
				}

				/// <java-name>
				/// getFlags
				/// </java-name>
				[Dot42.DexImport("getFlags", "()I", AccessFlags = 1)]
				public virtual int GetFlags() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getPackage
				/// </java-name>
				[Dot42.DexImport("getPackage", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetPackage() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getComponent
				/// </java-name>
				[Dot42.DexImport("getComponent", "()Landroid/content/ComponentName;", AccessFlags = 1)]
				public virtual global::Android.Content.ComponentName GetComponent() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.ComponentName);
				}

				/// <java-name>
				/// getSourceBounds
				/// </java-name>
				[Dot42.DexImport("getSourceBounds", "()Landroid/graphics/Rect;", AccessFlags = 1)]
				public virtual global::Android.Graphics.Rect GetSourceBounds() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Rect);
				}

				/// <java-name>
				/// resolveActivity
				/// </java-name>
				[Dot42.DexImport("resolveActivity", "(Landroid/content/pm/PackageManager;)Landroid/content/ComponentName;", AccessFlags = 1)]
				public virtual global::Android.Content.ComponentName ResolveActivity(global::Android.Content.Pm.PackageManager packageManager) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.ComponentName);
				}

				/// <java-name>
				/// resolveActivityInfo
				/// </java-name>
				[Dot42.DexImport("resolveActivityInfo", "(Landroid/content/pm/PackageManager;I)Landroid/content/pm/ActivityInfo;", AccessFlags = 1)]
				public virtual global::Android.Content.Pm.ActivityInfo ResolveActivityInfo(global::Android.Content.Pm.PackageManager packageManager, int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Pm.ActivityInfo);
				}

				/// <java-name>
				/// setAction
				/// </java-name>
				[Dot42.DexImport("setAction", "(Ljava/lang/String;)Landroid/content/Intent;", AccessFlags = 1)]
				public virtual global::Android.Content.Intent SetAction(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Intent);
				}

				/// <java-name>
				/// setData
				/// </java-name>
				[Dot42.DexImport("setData", "(Landroid/net/Uri;)Landroid/content/Intent;", AccessFlags = 1)]
				public virtual global::Android.Content.Intent SetData(global::Android.Net.Uri uri) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Intent);
				}

				/// <java-name>
				/// setType
				/// </java-name>
				[Dot42.DexImport("setType", "(Ljava/lang/String;)Landroid/content/Intent;", AccessFlags = 1)]
				public virtual global::Android.Content.Intent SetType(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Intent);
				}

				/// <java-name>
				/// setDataAndType
				/// </java-name>
				[Dot42.DexImport("setDataAndType", "(Landroid/net/Uri;Ljava/lang/String;)Landroid/content/Intent;", AccessFlags = 1)]
				public virtual global::Android.Content.Intent SetDataAndType(global::Android.Net.Uri uri, string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Intent);
				}

				/// <java-name>
				/// addCategory
				/// </java-name>
				[Dot42.DexImport("addCategory", "(Ljava/lang/String;)Landroid/content/Intent;", AccessFlags = 1)]
				public virtual global::Android.Content.Intent AddCategory(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Intent);
				}

				/// <java-name>
				/// removeCategory
				/// </java-name>
				[Dot42.DexImport("removeCategory", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void RemoveCategory(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setSelector
				/// </java-name>
				[Dot42.DexImport("setSelector", "(Landroid/content/Intent;)V", AccessFlags = 1)]
				public virtual void SetSelector(global::Android.Content.Intent intent) /* MethodBuilder.Create */ 
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
				[Dot42.DexImport("putExtra", "(Ljava/lang/String;B)Landroid/content/Intent;", AccessFlags = 1)]
				public virtual global::Android.Content.Intent PutExtra(string @string, sbyte sByte) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Intent);
				}

				/// <java-name>
				/// putExtra
				/// </java-name>
				[Dot42.DexImport("putExtra", "(Ljava/lang/String;B)Landroid/content/Intent;", AccessFlags = 1, IgnoreFromJava = true)]
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
				public virtual global::Android.Content.Intent PutExtra(string @string, global::Android.Os.IParcelable parcelable) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Intent);
				}

				/// <java-name>
				/// putExtra
				/// </java-name>
				[Dot42.DexImport("putExtra", "(Ljava/lang/String;[Landroid/os/Parcelable;)Landroid/content/Intent;", AccessFlags = 1)]
				public virtual global::Android.Content.Intent PutExtra(string @string, global::Android.Os.IParcelable[] parcelable) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Intent);
				}

				/// <java-name>
				/// putParcelableArrayListExtra
				/// </java-name>
				[Dot42.DexImport("putParcelableArrayListExtra", "(Ljava/lang/String;Ljava/util/ArrayList;)Landroid/content/Intent;", AccessFlags = 1, Signature = "(Ljava/lang/String;Ljava/util/ArrayList<+Landroid/os/Parcelable;>;)Landroid/conte" +
    "nt/Intent;")]
				public virtual global::Android.Content.Intent PutParcelableArrayListExtra(string @string, global::Java.Util.ArrayList<global::Android.Os.IParcelable> arrayList) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Intent);
				}

				/// <java-name>
				/// putIntegerArrayListExtra
				/// </java-name>
				[Dot42.DexImport("putIntegerArrayListExtra", "(Ljava/lang/String;Ljava/util/ArrayList;)Landroid/content/Intent;", AccessFlags = 1, Signature = "(Ljava/lang/String;Ljava/util/ArrayList<Ljava/lang/Integer;>;)Landroid/content/In" +
    "tent;")]
				public virtual global::Android.Content.Intent PutIntegerArrayListExtra(string @string, global::Java.Util.ArrayList<int?> arrayList) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Intent);
				}

				/// <java-name>
				/// putStringArrayListExtra
				/// </java-name>
				[Dot42.DexImport("putStringArrayListExtra", "(Ljava/lang/String;Ljava/util/ArrayList;)Landroid/content/Intent;", AccessFlags = 1, Signature = "(Ljava/lang/String;Ljava/util/ArrayList<Ljava/lang/String;>;)Landroid/content/Int" +
    "ent;")]
				public virtual global::Android.Content.Intent PutStringArrayListExtra(string @string, global::Java.Util.ArrayList<string> arrayList) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Intent);
				}

				/// <java-name>
				/// putCharSequenceArrayListExtra
				/// </java-name>
				[Dot42.DexImport("putCharSequenceArrayListExtra", "(Ljava/lang/String;Ljava/util/ArrayList;)Landroid/content/Intent;", AccessFlags = 1, Signature = "(Ljava/lang/String;Ljava/util/ArrayList<Ljava/lang/CharSequence;>;)Landroid/conte" +
    "nt/Intent;")]
				public virtual global::Android.Content.Intent PutCharSequenceArrayListExtra(string @string, global::Java.Util.ArrayList<global::Java.Lang.ICharSequence> arrayList) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Intent);
				}

				/// <java-name>
				/// putExtra
				/// </java-name>
				[Dot42.DexImport("putExtra", "(Ljava/lang/String;Ljava/io/Serializable;)Landroid/content/Intent;", AccessFlags = 1)]
				public virtual global::Android.Content.Intent PutExtra(string @string, global::Java.Io.ISerializable serializable) /* MethodBuilder.Create */ 
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
				[Dot42.DexImport("putExtra", "(Ljava/lang/String;[B)Landroid/content/Intent;", AccessFlags = 1)]
				public virtual global::Android.Content.Intent PutExtra(string @string, sbyte[] sByte) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Intent);
				}

				/// <java-name>
				/// putExtra
				/// </java-name>
				[Dot42.DexImport("putExtra", "(Ljava/lang/String;[B)Landroid/content/Intent;", AccessFlags = 1, IgnoreFromJava = true)]
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
				public virtual global::Android.Content.Intent PutExtra(string @string, global::Android.Os.Bundle bundle) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Intent);
				}

				/// <java-name>
				/// putExtras
				/// </java-name>
				[Dot42.DexImport("putExtras", "(Landroid/content/Intent;)Landroid/content/Intent;", AccessFlags = 1)]
				public virtual global::Android.Content.Intent PutExtras(global::Android.Content.Intent intent) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Intent);
				}

				/// <java-name>
				/// putExtras
				/// </java-name>
				[Dot42.DexImport("putExtras", "(Landroid/os/Bundle;)Landroid/content/Intent;", AccessFlags = 1)]
				public virtual global::Android.Content.Intent PutExtras(global::Android.Os.Bundle bundle) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Intent);
				}

				/// <java-name>
				/// replaceExtras
				/// </java-name>
				[Dot42.DexImport("replaceExtras", "(Landroid/content/Intent;)Landroid/content/Intent;", AccessFlags = 1)]
				public virtual global::Android.Content.Intent ReplaceExtras(global::Android.Content.Intent intent) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Intent);
				}

				/// <java-name>
				/// replaceExtras
				/// </java-name>
				[Dot42.DexImport("replaceExtras", "(Landroid/os/Bundle;)Landroid/content/Intent;", AccessFlags = 1)]
				public virtual global::Android.Content.Intent ReplaceExtras(global::Android.Os.Bundle bundle) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Intent);
				}

				/// <java-name>
				/// removeExtra
				/// </java-name>
				[Dot42.DexImport("removeExtra", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void RemoveExtra(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setFlags
				/// </java-name>
				[Dot42.DexImport("setFlags", "(I)Landroid/content/Intent;", AccessFlags = 1)]
				public virtual global::Android.Content.Intent SetFlags(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Intent);
				}

				/// <java-name>
				/// addFlags
				/// </java-name>
				[Dot42.DexImport("addFlags", "(I)Landroid/content/Intent;", AccessFlags = 1)]
				public virtual global::Android.Content.Intent AddFlags(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Intent);
				}

				/// <java-name>
				/// setPackage
				/// </java-name>
				[Dot42.DexImport("setPackage", "(Ljava/lang/String;)Landroid/content/Intent;", AccessFlags = 1)]
				public virtual global::Android.Content.Intent SetPackage(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Intent);
				}

				/// <java-name>
				/// setComponent
				/// </java-name>
				[Dot42.DexImport("setComponent", "(Landroid/content/ComponentName;)Landroid/content/Intent;", AccessFlags = 1)]
				public virtual global::Android.Content.Intent SetComponent(global::Android.Content.ComponentName componentName) /* MethodBuilder.Create */ 
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

				/// <java-name>
				/// setClass
				/// </java-name>
				[Dot42.DexImport("setClass", "(Landroid/content/Context;Ljava/lang/Class;)Landroid/content/Intent;", AccessFlags = 1, Signature = "(Landroid/content/Context;Ljava/lang/Class<*>;)Landroid/content/Intent;")]
				public virtual global::Android.Content.Intent SetClass(global::Android.Content.Context context, global::System.Type type) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Intent);
				}

				/// <java-name>
				/// setSourceBounds
				/// </java-name>
				[Dot42.DexImport("setSourceBounds", "(Landroid/graphics/Rect;)V", AccessFlags = 1)]
				public virtual void SetSourceBounds(global::Android.Graphics.Rect rect) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// fillIn
				/// </java-name>
				[Dot42.DexImport("fillIn", "(Landroid/content/Intent;I)I", AccessFlags = 1)]
				public virtual int FillIn(global::Android.Content.Intent intent, int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// filterEquals
				/// </java-name>
				[Dot42.DexImport("filterEquals", "(Landroid/content/Intent;)Z", AccessFlags = 1)]
				public virtual bool FilterEquals(global::Android.Content.Intent intent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

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

				/// <java-name>
				/// toURI
				/// </java-name>
				[Dot42.DexImport("toURI", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string ToURI() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// toUri
				/// </java-name>
				[Dot42.DexImport("toUri", "(I)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string ToUri(int int32) /* MethodBuilder.Create */ 
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
				public virtual void WriteToParcel(global::Android.Os.Parcel parcel, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// readFromParcel
				/// </java-name>
				[Dot42.DexImport("readFromParcel", "(Landroid/os/Parcel;)V", AccessFlags = 1)]
				public virtual void ReadFromParcel(global::Android.Os.Parcel parcel) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// parseIntent
				/// </java-name>
				[Dot42.DexImport("parseIntent", "(Landroid/content/res/Resources;Lorg/xmlpull/v1/XmlPullParser;Landroid/util/Attri" +
    "buteSet;)Landroid/content/Intent;", AccessFlags = 9)]
				public static global::Android.Content.Intent ParseIntent(global::Android.Content.Res.Resources resources, global::Org.Xmlpull.V1.IXmlPullParser xmlPullParser, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Intent);
				}

				/// <java-name>
				/// getAction
				/// </java-name>
				public string Action
				{
				[Dot42.DexImport("getAction", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetAction(); }
				}

				/// <java-name>
				/// getData
				/// </java-name>
				public global::Android.Net.Uri Data
				{
				[Dot42.DexImport("getData", "()Landroid/net/Uri;", AccessFlags = 1)]
						get{ return GetData(); }
				}

				/// <java-name>
				/// getDataString
				/// </java-name>
				public string DataString
				{
				[Dot42.DexImport("getDataString", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetDataString(); }
				}

				/// <java-name>
				/// getScheme
				/// </java-name>
				public string Scheme
				{
				[Dot42.DexImport("getScheme", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetScheme(); }
				}

				/// <java-name>
				/// getType
				/// </java-name>
				public string Type
				{
				[Dot42.DexImport("getType", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetType(); }
				}

				/// <java-name>
				/// getCategories
				/// </java-name>
				public global::Java.Util.ISet<string> Categories
				{
				[Dot42.DexImport("getCategories", "()Ljava/util/Set;", AccessFlags = 1, Signature = "()Ljava/util/Set<Ljava/lang/String;>;")]
						get{ return GetCategories(); }
				}

				/// <java-name>
				/// getSelector
				/// </java-name>
				public global::Android.Content.Intent Selector
				{
				[Dot42.DexImport("getSelector", "()Landroid/content/Intent;", AccessFlags = 1)]
						get{ return GetSelector(); }
				[Dot42.DexImport("setSelector", "(Landroid/content/Intent;)V", AccessFlags = 1)]
						set{ SetSelector(value); }
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
				/// getFlags
				/// </java-name>
				public int Flags
				{
				[Dot42.DexImport("getFlags", "()I", AccessFlags = 1)]
						get{ return GetFlags(); }
				}

				/// <java-name>
				/// getPackage
				/// </java-name>
				public string Package
				{
				[Dot42.DexImport("getPackage", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetPackage(); }
				}

				/// <java-name>
				/// getComponent
				/// </java-name>
				public global::Android.Content.ComponentName Component
				{
				[Dot42.DexImport("getComponent", "()Landroid/content/ComponentName;", AccessFlags = 1)]
						get{ return GetComponent(); }
				}

				/// <java-name>
				/// getSourceBounds
				/// </java-name>
				public global::Android.Graphics.Rect SourceBounds
				{
				[Dot42.DexImport("getSourceBounds", "()Landroid/graphics/Rect;", AccessFlags = 1)]
						get{ return GetSourceBounds(); }
				[Dot42.DexImport("setSourceBounds", "(Landroid/graphics/Rect;)V", AccessFlags = 1)]
						set{ SetSourceBounds(value); }
				}

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
						/// getIntent
						/// </java-name>
						[Dot42.DexImport("getIntent", "()Landroid/content/Intent;", AccessFlags = 1)]
						public global::Android.Content.Intent GetIntent() /* MethodBuilder.Create */ 
						{
								return default(global::Android.Content.Intent);
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

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal FilterComparison() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

						/// <java-name>
						/// getIntent
						/// </java-name>
						public global::Android.Content.Intent Intent
						{
						[Dot42.DexImport("getIntent", "()Landroid/content/Intent;", AccessFlags = 1)]
								get{ return GetIntent(); }
						}

				}

				/// <java-name>
				/// android/content/Intent$ShortcutIconResource
				/// </java-name>
				[Dot42.DexImport("android/content/Intent$ShortcutIconResource", AccessFlags = 9)]
				public partial class ShortcutIconResource : global::Android.Os.IParcelable
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// packageName
						/// </java-name>
						[Dot42.DexImport("packageName", "Ljava/lang/String;", AccessFlags = 1)]
						public string PackageName;
						/// <java-name>
						/// resourceName
						/// </java-name>
						[Dot42.DexImport("resourceName", "Ljava/lang/String;", AccessFlags = 1)]
						public string ResourceName;
						/// <java-name>
						/// CREATOR
						/// </java-name>
						[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
						public static readonly global::Android.Os.IParcelable_ICreator<ShortcutIconResource> CREATOR;
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public ShortcutIconResource() /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// fromContext
						/// </java-name>
						[Dot42.DexImport("fromContext", "(Landroid/content/Context;I)Landroid/content/Intent$ShortcutIconResource;", AccessFlags = 9)]
						public static ShortcutIconResource FromContext(global::Android.Content.Context context, int int32) /* MethodBuilder.Create */ 
						{
								return default(ShortcutIconResource);
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
						public virtual void WriteToParcel(global::Android.Os.Parcel parcel, int int32) /* MethodBuilder.Create */ 
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

		/// <java-name>
		/// android/content/CursorLoader
		/// </java-name>
		[Dot42.DexImport("android/content/CursorLoader", AccessFlags = 33, Signature = "Landroid/content/AsyncTaskLoader<Landroid/database/Cursor;>;")]
		public partial class CursorLoader : global::Android.Content.AsyncTaskLoader<global::Android.Database.ICursor>
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public CursorLoader(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/net/Uri;[Ljava/lang/String;Ljava/lang/String;[" +
    "Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public CursorLoader(global::Android.Content.Context context, global::Android.Net.Uri uri, string[] @string, string string1, string[] string2, string string3) /* MethodBuilder.Create */ 
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

				/// <java-name>
				/// onStartLoading
				/// </java-name>
				[Dot42.DexImport("onStartLoading", "()V", AccessFlags = 4)]
				protected internal override void OnStartLoading() /* MethodBuilder.Create */ 
				{
				}

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
				/// getUri
				/// </java-name>
				[Dot42.DexImport("getUri", "()Landroid/net/Uri;", AccessFlags = 1)]
				public virtual global::Android.Net.Uri GetUri() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Net.Uri);
				}

				/// <java-name>
				/// setUri
				/// </java-name>
				[Dot42.DexImport("setUri", "(Landroid/net/Uri;)V", AccessFlags = 1)]
				public virtual void SetUri(global::Android.Net.Uri uri) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getProjection
				/// </java-name>
				[Dot42.DexImport("getProjection", "()[Ljava/lang/String;", AccessFlags = 1)]
				public virtual string[] GetProjection() /* MethodBuilder.Create */ 
				{
						return default(string[]);
				}

				/// <java-name>
				/// setProjection
				/// </java-name>
				[Dot42.DexImport("setProjection", "([Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetProjection(string[] @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getSelection
				/// </java-name>
				[Dot42.DexImport("getSelection", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetSelection() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// setSelection
				/// </java-name>
				[Dot42.DexImport("setSelection", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetSelection(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getSelectionArgs
				/// </java-name>
				[Dot42.DexImport("getSelectionArgs", "()[Ljava/lang/String;", AccessFlags = 1)]
				public virtual string[] GetSelectionArgs() /* MethodBuilder.Create */ 
				{
						return default(string[]);
				}

				/// <java-name>
				/// setSelectionArgs
				/// </java-name>
				[Dot42.DexImport("setSelectionArgs", "([Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetSelectionArgs(string[] @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getSortOrder
				/// </java-name>
				[Dot42.DexImport("getSortOrder", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetSortOrder() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// setSortOrder
				/// </java-name>
				[Dot42.DexImport("setSortOrder", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetSortOrder(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// dump
				/// </java-name>
				[Dot42.DexImport("dump", "(Ljava/lang/String;Ljava/io/FileDescriptor;Ljava/io/PrintWriter;[Ljava/lang/Strin" +
    "g;)V", AccessFlags = 1)]
				public override void Dump(string @string, global::Java.Io.FileDescriptor fileDescriptor, global::Java.Io.PrintWriter printWriter, string[] string1) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal CursorLoader() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getUri
				/// </java-name>
				public global::Android.Net.Uri Uri
				{
				[Dot42.DexImport("getUri", "()Landroid/net/Uri;", AccessFlags = 1)]
						get{ return GetUri(); }
				[Dot42.DexImport("setUri", "(Landroid/net/Uri;)V", AccessFlags = 1)]
						set{ SetUri(value); }
				}

				/// <java-name>
				/// getProjection
				/// </java-name>
				public string[] Projection
				{
				[Dot42.DexImport("getProjection", "()[Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetProjection(); }
				[Dot42.DexImport("setProjection", "([Ljava/lang/String;)V", AccessFlags = 1)]
						set{ SetProjection(value); }
				}

				/// <java-name>
				/// getSelection
				/// </java-name>
				public string Selection
				{
				[Dot42.DexImport("getSelection", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetSelection(); }
				[Dot42.DexImport("setSelection", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ SetSelection(value); }
				}

				/// <java-name>
				/// getSelectionArgs
				/// </java-name>
				public string[] SelectionArgs
				{
				[Dot42.DexImport("getSelectionArgs", "()[Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetSelectionArgs(); }
				[Dot42.DexImport("setSelectionArgs", "([Ljava/lang/String;)V", AccessFlags = 1)]
						set{ SetSelectionArgs(value); }
				}

				/// <java-name>
				/// getSortOrder
				/// </java-name>
				public string SortOrder
				{
				[Dot42.DexImport("getSortOrder", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetSortOrder(); }
				[Dot42.DexImport("setSortOrder", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ SetSortOrder(value); }
				}

		}

		/// <java-name>
		/// android/content/IntentSender
		/// </java-name>
		[Dot42.DexImport("android/content/IntentSender", AccessFlags = 33)]
		public partial class IntentSender : global::Android.Os.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.Os.IParcelable_ICreator<global::Android.Content.IntentSender> CREATOR;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal IntentSender() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// sendIntent
				/// </java-name>
				[Dot42.DexImport("sendIntent", "(Landroid/content/Context;ILandroid/content/Intent;Landroid/content/IntentSender$" +
    "OnFinished;Landroid/os/Handler;)V", AccessFlags = 1)]
				public virtual void SendIntent(global::Android.Content.Context context, int int32, global::Android.Content.Intent intent, global::Android.Content.IntentSender.IOnFinished onFinished, global::Android.Os.Handler handler) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// sendIntent
				/// </java-name>
				[Dot42.DexImport("sendIntent", "(Landroid/content/Context;ILandroid/content/Intent;Landroid/content/IntentSender$" +
    "OnFinished;Landroid/os/Handler;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SendIntent(global::Android.Content.Context context, int int32, global::Android.Content.Intent intent, global::Android.Content.IntentSender.IOnFinished onFinished, global::Android.Os.Handler handler, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getTargetPackage
				/// </java-name>
				[Dot42.DexImport("getTargetPackage", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetTargetPackage() /* MethodBuilder.Create */ 
				{
						return default(string);
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
				public virtual int DescribeContents() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public virtual void WriteToParcel(global::Android.Os.Parcel parcel, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writeIntentSenderOrNullToParcel
				/// </java-name>
				[Dot42.DexImport("writeIntentSenderOrNullToParcel", "(Landroid/content/IntentSender;Landroid/os/Parcel;)V", AccessFlags = 9)]
				public static void WriteIntentSenderOrNullToParcel(global::Android.Content.IntentSender intentSender, global::Android.Os.Parcel parcel) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// readIntentSenderOrNullFromParcel
				/// </java-name>
				[Dot42.DexImport("readIntentSenderOrNullFromParcel", "(Landroid/os/Parcel;)Landroid/content/IntentSender;", AccessFlags = 9)]
				public static global::Android.Content.IntentSender ReadIntentSenderOrNullFromParcel(global::Android.Os.Parcel parcel) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.IntentSender);
				}

				/// <java-name>
				/// getTargetPackage
				/// </java-name>
				public string TargetPackage
				{
				[Dot42.DexImport("getTargetPackage", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetTargetPackage(); }
				}

				/// <java-name>
				/// android/content/IntentSender$OnFinished
				/// </java-name>
				[Dot42.DexImport("android/content/IntentSender$OnFinished", AccessFlags = 1545)]
				public partial interface IOnFinished
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onSendFinished
						/// </java-name>
						[Dot42.DexImport("onSendFinished", "(Landroid/content/IntentSender;Landroid/content/Intent;ILjava/lang/String;Landroi" +
    "d/os/Bundle;)V", AccessFlags = 1025)]
						void OnSendFinished(global::Android.Content.IntentSender intentSender, global::Android.Content.Intent intent, int int32, string @string, global::Android.Os.Bundle bundle) /* MethodBuilder.Create */ ;

				}

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

				/// <java-name>
				/// query
				/// </java-name>
				[Dot42.DexImport("query", "(Landroid/net/Uri;[Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/l" +
    "ang/String;)Landroid/database/Cursor;", AccessFlags = 1)]
				public virtual global::Android.Database.ICursor Query(global::Android.Net.Uri uri, string[] @string, string string1, string[] string2, string string3) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Database.ICursor);
				}

				/// <java-name>
				/// getType
				/// </java-name>
				[Dot42.DexImport("getType", "(Landroid/net/Uri;)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetType(global::Android.Net.Uri uri) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getStreamTypes
				/// </java-name>
				[Dot42.DexImport("getStreamTypes", "(Landroid/net/Uri;Ljava/lang/String;)[Ljava/lang/String;", AccessFlags = 1)]
				public virtual string[] GetStreamTypes(global::Android.Net.Uri uri, string @string) /* MethodBuilder.Create */ 
				{
						return default(string[]);
				}

				/// <java-name>
				/// insert
				/// </java-name>
				[Dot42.DexImport("insert", "(Landroid/net/Uri;Landroid/content/ContentValues;)Landroid/net/Uri;", AccessFlags = 1)]
				public virtual global::Android.Net.Uri Insert(global::Android.Net.Uri uri, global::Android.Content.ContentValues contentValues) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Net.Uri);
				}

				/// <java-name>
				/// bulkInsert
				/// </java-name>
				[Dot42.DexImport("bulkInsert", "(Landroid/net/Uri;[Landroid/content/ContentValues;)I", AccessFlags = 1)]
				public virtual int BulkInsert(global::Android.Net.Uri uri, global::Android.Content.ContentValues[] contentValues) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// delete
				/// </java-name>
				[Dot42.DexImport("delete", "(Landroid/net/Uri;Ljava/lang/String;[Ljava/lang/String;)I", AccessFlags = 1)]
				public virtual int Delete(global::Android.Net.Uri uri, string @string, string[] string1) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// update
				/// </java-name>
				[Dot42.DexImport("update", "(Landroid/net/Uri;Landroid/content/ContentValues;Ljava/lang/String;[Ljava/lang/St" +
    "ring;)I", AccessFlags = 1)]
				public virtual int Update(global::Android.Net.Uri uri, global::Android.Content.ContentValues contentValues, string @string, string[] string1) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// openFile
				/// </java-name>
				[Dot42.DexImport("openFile", "(Landroid/net/Uri;Ljava/lang/String;)Landroid/os/ParcelFileDescriptor;", AccessFlags = 1)]
				public virtual global::Android.Os.ParcelFileDescriptor OpenFile(global::Android.Net.Uri uri, string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Os.ParcelFileDescriptor);
				}

				/// <java-name>
				/// openAssetFile
				/// </java-name>
				[Dot42.DexImport("openAssetFile", "(Landroid/net/Uri;Ljava/lang/String;)Landroid/content/res/AssetFileDescriptor;", AccessFlags = 1)]
				public virtual global::Android.Content.Res.AssetFileDescriptor OpenAssetFile(global::Android.Net.Uri uri, string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Res.AssetFileDescriptor);
				}

				/// <java-name>
				/// openTypedAssetFileDescriptor
				/// </java-name>
				[Dot42.DexImport("openTypedAssetFileDescriptor", "(Landroid/net/Uri;Ljava/lang/String;Landroid/os/Bundle;)Landroid/content/res/Asse" +
    "tFileDescriptor;", AccessFlags = 17)]
				public global::Android.Content.Res.AssetFileDescriptor OpenTypedAssetFileDescriptor(global::Android.Net.Uri uri, string @string, global::Android.Os.Bundle bundle) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Res.AssetFileDescriptor);
				}

				/// <java-name>
				/// applyBatch
				/// </java-name>
				[Dot42.DexImport("applyBatch", "(Ljava/util/ArrayList;)[Landroid/content/ContentProviderResult;", AccessFlags = 1, Signature = "(Ljava/util/ArrayList<Landroid/content/ContentProviderOperation;>;)[Landroid/cont" +
    "ent/ContentProviderResult;")]
				public virtual global::Android.Content.ContentProviderResult[] ApplyBatch(global::Java.Util.ArrayList<global::Android.Content.ContentProviderOperation> arrayList) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.ContentProviderResult[]);
				}

				/// <java-name>
				/// release
				/// </java-name>
				[Dot42.DexImport("release", "()Z", AccessFlags = 1)]
				public virtual bool Release() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getLocalContentProvider
				/// </java-name>
				[Dot42.DexImport("getLocalContentProvider", "()Landroid/content/ContentProvider;", AccessFlags = 1)]
				public virtual global::Android.Content.ContentProvider GetLocalContentProvider() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.ContentProvider);
				}

				/// <java-name>
				/// getLocalContentProvider
				/// </java-name>
				public global::Android.Content.ContentProvider LocalContentProvider
				{
				[Dot42.DexImport("getLocalContentProvider", "()Landroid/content/ContentProvider;", AccessFlags = 1)]
						get{ return GetLocalContentProvider(); }
				}

		}

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
				/// setPrimaryClip
				/// </java-name>
				[Dot42.DexImport("setPrimaryClip", "(Landroid/content/ClipData;)V", AccessFlags = 1)]
				public virtual void SetPrimaryClip(global::Android.Content.ClipData clipData) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getPrimaryClip
				/// </java-name>
				[Dot42.DexImport("getPrimaryClip", "()Landroid/content/ClipData;", AccessFlags = 1)]
				public virtual global::Android.Content.ClipData GetPrimaryClip() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.ClipData);
				}

				/// <java-name>
				/// getPrimaryClipDescription
				/// </java-name>
				[Dot42.DexImport("getPrimaryClipDescription", "()Landroid/content/ClipDescription;", AccessFlags = 1)]
				public virtual global::Android.Content.ClipDescription GetPrimaryClipDescription() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.ClipDescription);
				}

				/// <java-name>
				/// hasPrimaryClip
				/// </java-name>
				[Dot42.DexImport("hasPrimaryClip", "()Z", AccessFlags = 1)]
				public virtual bool HasPrimaryClip() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// addPrimaryClipChangedListener
				/// </java-name>
				[Dot42.DexImport("addPrimaryClipChangedListener", "(Landroid/content/ClipboardManager$OnPrimaryClipChangedListener;)V", AccessFlags = 1)]
				public virtual void AddPrimaryClipChangedListener(global::Android.Content.ClipboardManager.IOnPrimaryClipChangedListener onPrimaryClipChangedListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// removePrimaryClipChangedListener
				/// </java-name>
				[Dot42.DexImport("removePrimaryClipChangedListener", "(Landroid/content/ClipboardManager$OnPrimaryClipChangedListener;)V", AccessFlags = 1)]
				public virtual void RemovePrimaryClipChangedListener(global::Android.Content.ClipboardManager.IOnPrimaryClipChangedListener onPrimaryClipChangedListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getText
				/// </java-name>
				[Dot42.DexImport("getText", "()Ljava/lang/CharSequence;", AccessFlags = 1)]
				public override global::Java.Lang.ICharSequence GetText() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <java-name>
				/// setText
				/// </java-name>
				[Dot42.DexImport("setText", "(Ljava/lang/CharSequence;)V", AccessFlags = 1)]
				public override void SetText(global::Java.Lang.ICharSequence charSequence) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// hasText
				/// </java-name>
				[Dot42.DexImport("hasText", "()Z", AccessFlags = 1)]
				public override bool HasText() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getPrimaryClip
				/// </java-name>
				public global::Android.Content.ClipData PrimaryClip
				{
				[Dot42.DexImport("getPrimaryClip", "()Landroid/content/ClipData;", AccessFlags = 1)]
						get{ return GetPrimaryClip(); }
				[Dot42.DexImport("setPrimaryClip", "(Landroid/content/ClipData;)V", AccessFlags = 1)]
						set{ SetPrimaryClip(value); }
				}

				/// <java-name>
				/// getPrimaryClipDescription
				/// </java-name>
				public global::Android.Content.ClipDescription PrimaryClipDescription
				{
				[Dot42.DexImport("getPrimaryClipDescription", "()Landroid/content/ClipDescription;", AccessFlags = 1)]
						get{ return GetPrimaryClipDescription(); }
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
				/// android/content/ClipboardManager$OnPrimaryClipChangedListener
				/// </java-name>
				[Dot42.DexImport("android/content/ClipboardManager$OnPrimaryClipChangedListener", AccessFlags = 1545)]
				public partial interface IOnPrimaryClipChangedListener
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onPrimaryClipChanged
						/// </java-name>
						[Dot42.DexImport("onPrimaryClipChanged", "()V", AccessFlags = 1025)]
						void OnPrimaryClipChanged() /* MethodBuilder.Create */ ;

				}

		}

		/// <java-name>
		/// android/content/MutableContextWrapper
		/// </java-name>
		[Dot42.DexImport("android/content/MutableContextWrapper", AccessFlags = 33)]
		public partial class MutableContextWrapper : global::Android.Content.ContextWrapper
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public MutableContextWrapper(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setBaseContext
				/// </java-name>
				[Dot42.DexImport("setBaseContext", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public virtual void SetBaseContext(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal MutableContextWrapper() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// android/content/ClipData
		/// </java-name>
		[Dot42.DexImport("android/content/ClipData", AccessFlags = 33)]
		public partial class ClipData : global::Android.Os.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.Os.IParcelable_ICreator<global::Android.Content.ClipData> CREATOR;
				[Dot42.DexImport("<init>", "(Ljava/lang/CharSequence;[Ljava/lang/String;Landroid/content/ClipData$Item;)V", AccessFlags = 1)]
				public ClipData(global::Java.Lang.ICharSequence charSequence, string[] @string, global::Android.Content.ClipData.Item item) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/ClipDescription;Landroid/content/ClipData$Item;)V", AccessFlags = 1)]
				public ClipData(global::Android.Content.ClipDescription clipDescription, global::Android.Content.ClipData.Item item) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// newPlainText
				/// </java-name>
				[Dot42.DexImport("newPlainText", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Landroid/content/ClipData;", AccessFlags = 9)]
				public static global::Android.Content.ClipData NewPlainText(global::Java.Lang.ICharSequence charSequence, global::Java.Lang.ICharSequence charSequence1) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.ClipData);
				}

				/// <java-name>
				/// newIntent
				/// </java-name>
				[Dot42.DexImport("newIntent", "(Ljava/lang/CharSequence;Landroid/content/Intent;)Landroid/content/ClipData;", AccessFlags = 9)]
				public static global::Android.Content.ClipData NewIntent(global::Java.Lang.ICharSequence charSequence, global::Android.Content.Intent intent) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.ClipData);
				}

				/// <java-name>
				/// newUri
				/// </java-name>
				[Dot42.DexImport("newUri", "(Landroid/content/ContentResolver;Ljava/lang/CharSequence;Landroid/net/Uri;)Landr" +
    "oid/content/ClipData;", AccessFlags = 9)]
				public static global::Android.Content.ClipData NewUri(global::Android.Content.ContentResolver contentResolver, global::Java.Lang.ICharSequence charSequence, global::Android.Net.Uri uri) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.ClipData);
				}

				/// <java-name>
				/// newRawUri
				/// </java-name>
				[Dot42.DexImport("newRawUri", "(Ljava/lang/CharSequence;Landroid/net/Uri;)Landroid/content/ClipData;", AccessFlags = 9)]
				public static global::Android.Content.ClipData NewRawUri(global::Java.Lang.ICharSequence charSequence, global::Android.Net.Uri uri) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.ClipData);
				}

				/// <java-name>
				/// getDescription
				/// </java-name>
				[Dot42.DexImport("getDescription", "()Landroid/content/ClipDescription;", AccessFlags = 1)]
				public virtual global::Android.Content.ClipDescription GetDescription() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.ClipDescription);
				}

				/// <java-name>
				/// addItem
				/// </java-name>
				[Dot42.DexImport("addItem", "(Landroid/content/ClipData$Item;)V", AccessFlags = 1)]
				public virtual void AddItem(global::Android.Content.ClipData.Item item) /* MethodBuilder.Create */ 
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
				/// getItemAt
				/// </java-name>
				[Dot42.DexImport("getItemAt", "(I)Landroid/content/ClipData$Item;", AccessFlags = 1)]
				public virtual global::Android.Content.ClipData.Item GetItemAt(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.ClipData.Item);
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
				public virtual void WriteToParcel(global::Android.Os.Parcel parcel, int int32) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ClipData() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getDescription
				/// </java-name>
				public global::Android.Content.ClipDescription Description
				{
				[Dot42.DexImport("getDescription", "()Landroid/content/ClipDescription;", AccessFlags = 1)]
						get{ return GetDescription(); }
				}

				/// <java-name>
				/// getItemCount
				/// </java-name>
				public int ItemCount
				{
				[Dot42.DexImport("getItemCount", "()I", AccessFlags = 1)]
						get{ return GetItemCount(); }
				}

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

						/// <java-name>
						/// getText
						/// </java-name>
						[Dot42.DexImport("getText", "()Ljava/lang/CharSequence;", AccessFlags = 1)]
						public virtual global::Java.Lang.ICharSequence GetText() /* MethodBuilder.Create */ 
						{
								return default(global::Java.Lang.ICharSequence);
						}

						/// <java-name>
						/// getIntent
						/// </java-name>
						[Dot42.DexImport("getIntent", "()Landroid/content/Intent;", AccessFlags = 1)]
						public virtual global::Android.Content.Intent GetIntent() /* MethodBuilder.Create */ 
						{
								return default(global::Android.Content.Intent);
						}

						/// <java-name>
						/// getUri
						/// </java-name>
						[Dot42.DexImport("getUri", "()Landroid/net/Uri;", AccessFlags = 1)]
						public virtual global::Android.Net.Uri GetUri() /* MethodBuilder.Create */ 
						{
								return default(global::Android.Net.Uri);
						}

						/// <java-name>
						/// coerceToText
						/// </java-name>
						[Dot42.DexImport("coerceToText", "(Landroid/content/Context;)Ljava/lang/CharSequence;", AccessFlags = 1)]
						public virtual global::Java.Lang.ICharSequence CoerceToText(global::Android.Content.Context context) /* MethodBuilder.Create */ 
						{
								return default(global::Java.Lang.ICharSequence);
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal Item() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

						/// <java-name>
						/// getText
						/// </java-name>
						public global::Java.Lang.ICharSequence Text
						{
						[Dot42.DexImport("getText", "()Ljava/lang/CharSequence;", AccessFlags = 1)]
								get{ return GetText(); }
						}

						/// <java-name>
						/// getIntent
						/// </java-name>
						public global::Android.Content.Intent Intent
						{
						[Dot42.DexImport("getIntent", "()Landroid/content/Intent;", AccessFlags = 1)]
								get{ return GetIntent(); }
						}

						/// <java-name>
						/// getUri
						/// </java-name>
						public global::Android.Net.Uri Uri
						{
						[Dot42.DexImport("getUri", "()Landroid/net/Uri;", AccessFlags = 1)]
								get{ return GetUri(); }
						}

				}

		}

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

				/// <java-name>
				/// parseId
				/// </java-name>
				[Dot42.DexImport("parseId", "(Landroid/net/Uri;)J", AccessFlags = 9)]
				public static long ParseId(global::Android.Net.Uri uri) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// appendId
				/// </java-name>
				[Dot42.DexImport("appendId", "(Landroid/net/Uri$Builder;J)Landroid/net/Uri$Builder;", AccessFlags = 9)]
				public static global::Android.Net.Uri.Builder AppendId(global::Android.Net.Uri.Builder builder, long int64) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Net.Uri.Builder);
				}

				/// <java-name>
				/// withAppendedId
				/// </java-name>
				[Dot42.DexImport("withAppendedId", "(Landroid/net/Uri;J)Landroid/net/Uri;", AccessFlags = 9)]
				public static global::Android.Net.Uri WithAppendedId(global::Android.Net.Uri uri, long int64) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Net.Uri);
				}

		}

		/// <java-name>
		/// android/content/DialogInterface
		/// </java-name>
		[Dot42.DexImport("android/content/DialogInterface", AccessFlags = 1537, IgnoreFromJava = true, Priority = 1)]
		public static partial class IDialogInterfaceConstants
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// BUTTON_POSITIVE
				/// </java-name>
				[Dot42.DexImport("BUTTON_POSITIVE", "I", AccessFlags = 25)]
				public const int BUTTON_POSITIVE = -1;
				/// <java-name>
				/// BUTTON_NEGATIVE
				/// </java-name>
				[Dot42.DexImport("BUTTON_NEGATIVE", "I", AccessFlags = 25)]
				public const int BUTTON_NEGATIVE = -2;
				/// <java-name>
				/// BUTTON_NEUTRAL
				/// </java-name>
				[Dot42.DexImport("BUTTON_NEUTRAL", "I", AccessFlags = 25)]
				public const int BUTTON_NEUTRAL = -3;
				/// <java-name>
				/// BUTTON1
				/// </java-name>
				[Dot42.DexImport("BUTTON1", "I", AccessFlags = 25)]
				public const int BUTTON1 = -1;
				/// <java-name>
				/// BUTTON2
				/// </java-name>
				[Dot42.DexImport("BUTTON2", "I", AccessFlags = 25)]
				public const int BUTTON2 = -2;
				/// <java-name>
				/// BUTTON3
				/// </java-name>
				[Dot42.DexImport("BUTTON3", "I", AccessFlags = 25)]
				public const int BUTTON3 = -3;
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

		/// <java-name>
		/// android/content/DialogInterface$OnKeyListener
		/// </java-name>
		[Dot42.DexImport("android/content/DialogInterface$OnKeyListener", AccessFlags = 1545)]
		public partial interface IDialogInterface_IOnKeyListener
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// onKey
				/// </java-name>
				[Dot42.DexImport("onKey", "(Landroid/content/DialogInterface;ILandroid/view/KeyEvent;)Z", AccessFlags = 1025)]
				bool OnKey(global::Android.Content.IDialogInterface dialogInterface, int int32, global::Android.View.KeyEvent keyEvent) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// android/content/DialogInterface$OnMultiChoiceClickListener
		/// </java-name>
		[Dot42.DexImport("android/content/DialogInterface$OnMultiChoiceClickListener", AccessFlags = 1545)]
		public partial interface IDialogInterface_IOnMultiChoiceClickListener
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// onClick
				/// </java-name>
				[Dot42.DexImport("onClick", "(Landroid/content/DialogInterface;IZ)V", AccessFlags = 1025)]
				void OnClick(global::Android.Content.IDialogInterface dialogInterface, int int32, bool boolean) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// android/content/DialogInterface$OnClickListener
		/// </java-name>
		[Dot42.DexImport("android/content/DialogInterface$OnClickListener", AccessFlags = 1545)]
		public partial interface IDialogInterface_IOnClickListener
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// onClick
				/// </java-name>
				[Dot42.DexImport("onClick", "(Landroid/content/DialogInterface;I)V", AccessFlags = 1025)]
				void OnClick(global::Android.Content.IDialogInterface dialogInterface, int int32) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// android/content/DialogInterface$OnShowListener
		/// </java-name>
		[Dot42.DexImport("android/content/DialogInterface$OnShowListener", AccessFlags = 1545)]
		public partial interface IDialogInterface_IOnShowListener
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// onShow
				/// </java-name>
				[Dot42.DexImport("onShow", "(Landroid/content/DialogInterface;)V", AccessFlags = 1025)]
				void OnShow(global::Android.Content.IDialogInterface dialogInterface) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// android/content/DialogInterface$OnDismissListener
		/// </java-name>
		[Dot42.DexImport("android/content/DialogInterface$OnDismissListener", AccessFlags = 1545)]
		public partial interface IDialogInterface_IOnDismissListener
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// onDismiss
				/// </java-name>
				[Dot42.DexImport("onDismiss", "(Landroid/content/DialogInterface;)V", AccessFlags = 1025)]
				void OnDismiss(global::Android.Content.IDialogInterface dialogInterface) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// android/content/DialogInterface$OnCancelListener
		/// </java-name>
		[Dot42.DexImport("android/content/DialogInterface$OnCancelListener", AccessFlags = 1545)]
		public partial interface IDialogInterface_IOnCancelListener
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// onCancel
				/// </java-name>
				[Dot42.DexImport("onCancel", "(Landroid/content/DialogInterface;)V", AccessFlags = 1025)]
				void OnCancel(global::Android.Content.IDialogInterface dialogInterface) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// android/content/ServiceConnection
		/// </java-name>
		[Dot42.DexImport("android/content/ServiceConnection", AccessFlags = 1537)]
		public partial interface IServiceConnection
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// onServiceConnected
				/// </java-name>
				[Dot42.DexImport("onServiceConnected", "(Landroid/content/ComponentName;Landroid/os/IBinder;)V", AccessFlags = 1025)]
				void OnServiceConnected(global::Android.Content.ComponentName componentName, global::Android.Os.IBinder binder) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// onServiceDisconnected
				/// </java-name>
				[Dot42.DexImport("onServiceDisconnected", "(Landroid/content/ComponentName;)V", AccessFlags = 1025)]
				void OnServiceDisconnected(global::Android.Content.ComponentName componentName) /* MethodBuilder.Create */ ;

		}

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
				public ActivityNotFoundException(string @string) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// android/content/PeriodicSync
		/// </java-name>
		[Dot42.DexImport("android/content/PeriodicSync", AccessFlags = 33)]
		public partial class PeriodicSync : global::Android.Os.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// account
				/// </java-name>
				[Dot42.DexImport("account", "Landroid/accounts/Account;", AccessFlags = 17)]
				public readonly global::Android.Accounts.Account Account;
				/// <java-name>
				/// authority
				/// </java-name>
				[Dot42.DexImport("authority", "Ljava/lang/String;", AccessFlags = 17)]
				public readonly string Authority;
				/// <java-name>
				/// extras
				/// </java-name>
				[Dot42.DexImport("extras", "Landroid/os/Bundle;", AccessFlags = 17)]
				public readonly global::Android.Os.Bundle Extras;
				/// <java-name>
				/// period
				/// </java-name>
				[Dot42.DexImport("period", "J", AccessFlags = 17)]
				public readonly long Period;
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.Os.IParcelable_ICreator<global::Android.Content.PeriodicSync> CREATOR;
				[Dot42.DexImport("<init>", "(Landroid/accounts/Account;Ljava/lang/String;Landroid/os/Bundle;J)V", AccessFlags = 1)]
				public PeriodicSync(global::Android.Accounts.Account account, string @string, global::Android.Os.Bundle bundle, long int64) /* MethodBuilder.Create */ 
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

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal PeriodicSync() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// android/content/SyncInfo
		/// </java-name>
		[Dot42.DexImport("android/content/SyncInfo", AccessFlags = 33)]
		public partial class SyncInfo : global::Android.Os.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// account
				/// </java-name>
				[Dot42.DexImport("account", "Landroid/accounts/Account;", AccessFlags = 17)]
				public readonly global::Android.Accounts.Account Account;
				/// <java-name>
				/// authority
				/// </java-name>
				[Dot42.DexImport("authority", "Ljava/lang/String;", AccessFlags = 17)]
				public readonly string Authority;
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
				public virtual void WriteToParcel(global::Android.Os.Parcel parcel, int int32) /* MethodBuilder.Create */ 
				{
				}

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
				void OnStatusChanged(int int32) /* MethodBuilder.Create */ ;

		}

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
				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public UriMatcher(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addURI
				/// </java-name>
				[Dot42.DexImport("addURI", "(Ljava/lang/String;Ljava/lang/String;I)V", AccessFlags = 1)]
				public virtual void AddURI(string @string, string string1, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// match
				/// </java-name>
				[Dot42.DexImport("match", "(Landroid/net/Uri;)I", AccessFlags = 1)]
				public virtual int Match(global::Android.Net.Uri uri) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal UriMatcher() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// android/content/SearchRecentSuggestionsProvider
		/// </java-name>
		[Dot42.DexImport("android/content/SearchRecentSuggestionsProvider", AccessFlags = 33)]
		public partial class SearchRecentSuggestionsProvider : global::Android.Content.ContentProvider
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// DATABASE_MODE_QUERIES
				/// </java-name>
				[Dot42.DexImport("DATABASE_MODE_QUERIES", "I", AccessFlags = 25)]
				public const int DATABASE_MODE_QUERIES = 1;
				/// <java-name>
				/// DATABASE_MODE_2LINES
				/// </java-name>
				[Dot42.DexImport("DATABASE_MODE_2LINES", "I", AccessFlags = 25)]
				public const int DATABASE_MODE_2LINES = 2;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public SearchRecentSuggestionsProvider() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setupSuggestions
				/// </java-name>
				[Dot42.DexImport("setupSuggestions", "(Ljava/lang/String;I)V", AccessFlags = 4)]
				protected internal virtual void SetupSuggestions(string @string, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// delete
				/// </java-name>
				[Dot42.DexImport("delete", "(Landroid/net/Uri;Ljava/lang/String;[Ljava/lang/String;)I", AccessFlags = 1)]
				public override int Delete(global::Android.Net.Uri uri, string @string, string[] string1) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getType
				/// </java-name>
				[Dot42.DexImport("getType", "(Landroid/net/Uri;)Ljava/lang/String;", AccessFlags = 1)]
				public override string GetType(global::Android.Net.Uri uri) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// insert
				/// </java-name>
				[Dot42.DexImport("insert", "(Landroid/net/Uri;Landroid/content/ContentValues;)Landroid/net/Uri;", AccessFlags = 1)]
				public override global::Android.Net.Uri Insert(global::Android.Net.Uri uri, global::Android.Content.ContentValues contentValues) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Net.Uri);
				}

				/// <java-name>
				/// onCreate
				/// </java-name>
				[Dot42.DexImport("onCreate", "()Z", AccessFlags = 1)]
				public override bool OnCreate() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// query
				/// </java-name>
				[Dot42.DexImport("query", "(Landroid/net/Uri;[Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/l" +
    "ang/String;)Landroid/database/Cursor;", AccessFlags = 1)]
				public override global::Android.Database.ICursor Query(global::Android.Net.Uri uri, string[] @string, string string1, string[] string2, string string3) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Database.ICursor);
				}

				/// <java-name>
				/// update
				/// </java-name>
				[Dot42.DexImport("update", "(Landroid/net/Uri;Landroid/content/ContentValues;Ljava/lang/String;[Ljava/lang/St" +
    "ring;)I", AccessFlags = 1)]
				public override int Update(global::Android.Net.Uri uri, global::Android.Content.ContentValues contentValues, string @string, string[] string1) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

		}

		/// <java-name>
		/// android/content/ContentProvider
		/// </java-name>
		[Dot42.DexImport("android/content/ContentProvider", AccessFlags = 1057)]
		public abstract partial class ContentProvider : global::Android.Content.IComponentCallbacks2
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ContentProvider() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getContext
				/// </java-name>
				[Dot42.DexImport("getContext", "()Landroid/content/Context;", AccessFlags = 17)]
				public global::Android.Content.Context GetContext() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Context);
				}

				/// <java-name>
				/// setReadPermission
				/// </java-name>
				[Dot42.DexImport("setReadPermission", "(Ljava/lang/String;)V", AccessFlags = 20)]
				protected internal void SetReadPermission(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getReadPermission
				/// </java-name>
				[Dot42.DexImport("getReadPermission", "()Ljava/lang/String;", AccessFlags = 17)]
				public string GetReadPermission() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// setWritePermission
				/// </java-name>
				[Dot42.DexImport("setWritePermission", "(Ljava/lang/String;)V", AccessFlags = 20)]
				protected internal void SetWritePermission(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getWritePermission
				/// </java-name>
				[Dot42.DexImport("getWritePermission", "()Ljava/lang/String;", AccessFlags = 17)]
				public string GetWritePermission() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// setPathPermissions
				/// </java-name>
				[Dot42.DexImport("setPathPermissions", "([Landroid/content/pm/PathPermission;)V", AccessFlags = 20)]
				protected internal void SetPathPermissions(global::Android.Content.Pm.PathPermission[] pathPermission) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getPathPermissions
				/// </java-name>
				[Dot42.DexImport("getPathPermissions", "()[Landroid/content/pm/PathPermission;", AccessFlags = 17)]
				public global::Android.Content.Pm.PathPermission[] GetPathPermissions() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Pm.PathPermission[]);
				}

				/// <java-name>
				/// onCreate
				/// </java-name>
				[Dot42.DexImport("onCreate", "()Z", AccessFlags = 1025)]
				public abstract bool OnCreate() /* MethodBuilder.Create */ ;

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
				/// query
				/// </java-name>
				[Dot42.DexImport("query", "(Landroid/net/Uri;[Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/l" +
    "ang/String;)Landroid/database/Cursor;", AccessFlags = 1025)]
				public abstract global::Android.Database.ICursor Query(global::Android.Net.Uri uri, string[] @string, string string1, string[] string2, string string3) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getType
				/// </java-name>
				[Dot42.DexImport("getType", "(Landroid/net/Uri;)Ljava/lang/String;", AccessFlags = 1025)]
				public abstract string GetType(global::Android.Net.Uri uri) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// insert
				/// </java-name>
				[Dot42.DexImport("insert", "(Landroid/net/Uri;Landroid/content/ContentValues;)Landroid/net/Uri;", AccessFlags = 1025)]
				public abstract global::Android.Net.Uri Insert(global::Android.Net.Uri uri, global::Android.Content.ContentValues contentValues) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// bulkInsert
				/// </java-name>
				[Dot42.DexImport("bulkInsert", "(Landroid/net/Uri;[Landroid/content/ContentValues;)I", AccessFlags = 1)]
				public virtual int BulkInsert(global::Android.Net.Uri uri, global::Android.Content.ContentValues[] contentValues) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// delete
				/// </java-name>
				[Dot42.DexImport("delete", "(Landroid/net/Uri;Ljava/lang/String;[Ljava/lang/String;)I", AccessFlags = 1025)]
				public abstract int Delete(global::Android.Net.Uri uri, string @string, string[] string1) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// update
				/// </java-name>
				[Dot42.DexImport("update", "(Landroid/net/Uri;Landroid/content/ContentValues;Ljava/lang/String;[Ljava/lang/St" +
    "ring;)I", AccessFlags = 1025)]
				public abstract int Update(global::Android.Net.Uri uri, global::Android.Content.ContentValues contentValues, string @string, string[] string1) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// openFile
				/// </java-name>
				[Dot42.DexImport("openFile", "(Landroid/net/Uri;Ljava/lang/String;)Landroid/os/ParcelFileDescriptor;", AccessFlags = 1)]
				public virtual global::Android.Os.ParcelFileDescriptor OpenFile(global::Android.Net.Uri uri, string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Os.ParcelFileDescriptor);
				}

				/// <java-name>
				/// openAssetFile
				/// </java-name>
				[Dot42.DexImport("openAssetFile", "(Landroid/net/Uri;Ljava/lang/String;)Landroid/content/res/AssetFileDescriptor;", AccessFlags = 1)]
				public virtual global::Android.Content.Res.AssetFileDescriptor OpenAssetFile(global::Android.Net.Uri uri, string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Res.AssetFileDescriptor);
				}

				/// <java-name>
				/// openFileHelper
				/// </java-name>
				[Dot42.DexImport("openFileHelper", "(Landroid/net/Uri;Ljava/lang/String;)Landroid/os/ParcelFileDescriptor;", AccessFlags = 20)]
				protected internal global::Android.Os.ParcelFileDescriptor OpenFileHelper(global::Android.Net.Uri uri, string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Os.ParcelFileDescriptor);
				}

				/// <java-name>
				/// getStreamTypes
				/// </java-name>
				[Dot42.DexImport("getStreamTypes", "(Landroid/net/Uri;Ljava/lang/String;)[Ljava/lang/String;", AccessFlags = 1)]
				public virtual string[] GetStreamTypes(global::Android.Net.Uri uri, string @string) /* MethodBuilder.Create */ 
				{
						return default(string[]);
				}

				/// <java-name>
				/// openTypedAssetFile
				/// </java-name>
				[Dot42.DexImport("openTypedAssetFile", "(Landroid/net/Uri;Ljava/lang/String;Landroid/os/Bundle;)Landroid/content/res/Asse" +
    "tFileDescriptor;", AccessFlags = 1)]
				public virtual global::Android.Content.Res.AssetFileDescriptor OpenTypedAssetFile(global::Android.Net.Uri uri, string @string, global::Android.Os.Bundle bundle) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Res.AssetFileDescriptor);
				}

				/// <java-name>
				/// openPipeHelper
				/// </java-name>
				[Dot42.DexImport("openPipeHelper", "(Landroid/net/Uri;Ljava/lang/String;Landroid/os/Bundle;Ljava/lang/Object;Landroid" +
    "/content/ContentProvider$PipeDataWriter;)Landroid/os/ParcelFileDescriptor;", AccessFlags = 1, Signature = "<T:Ljava/lang/Object;>(Landroid/net/Uri;Ljava/lang/String;Landroid/os/Bundle;TT;L" +
    "android/content/ContentProvider$PipeDataWriter<TT;>;)Landroid/os/ParcelFileDescr" +
    "iptor;")]
				public virtual global::Android.Os.ParcelFileDescriptor OpenPipeHelper<T>(global::Android.Net.Uri uri, string @string, global::Android.Os.Bundle bundle, T t, global::Android.Content.ContentProvider.IPipeDataWriter<T> pipeDataWriter) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Os.ParcelFileDescriptor);
				}

				/// <java-name>
				/// isTemporary
				/// </java-name>
				[Dot42.DexImport("isTemporary", "()Z", AccessFlags = 4)]
				protected internal virtual bool IsTemporary() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// attachInfo
				/// </java-name>
				[Dot42.DexImport("attachInfo", "(Landroid/content/Context;Landroid/content/pm/ProviderInfo;)V", AccessFlags = 1)]
				public virtual void AttachInfo(global::Android.Content.Context context, global::Android.Content.Pm.ProviderInfo providerInfo) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// applyBatch
				/// </java-name>
				[Dot42.DexImport("applyBatch", "(Ljava/util/ArrayList;)[Landroid/content/ContentProviderResult;", AccessFlags = 1, Signature = "(Ljava/util/ArrayList<Landroid/content/ContentProviderOperation;>;)[Landroid/cont" +
    "ent/ContentProviderResult;")]
				public virtual global::Android.Content.ContentProviderResult[] ApplyBatch(global::Java.Util.ArrayList<global::Android.Content.ContentProviderOperation> arrayList) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.ContentProviderResult[]);
				}

				/// <java-name>
				/// call
				/// </java-name>
				[Dot42.DexImport("call", "(Ljava/lang/String;Ljava/lang/String;Landroid/os/Bundle;)Landroid/os/Bundle;", AccessFlags = 1)]
				public virtual global::Android.Os.Bundle Call(string @string, string string1, global::Android.Os.Bundle bundle) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Os.Bundle);
				}

				/// <java-name>
				/// shutdown
				/// </java-name>
				[Dot42.DexImport("shutdown", "()V", AccessFlags = 1)]
				public virtual void Shutdown() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getContext
				/// </java-name>
				public global::Android.Content.Context Context
				{
				[Dot42.DexImport("getContext", "()Landroid/content/Context;", AccessFlags = 17)]
						get{ return GetContext(); }
				}

				/// <java-name>
				/// getReadPermission
				/// </java-name>
				public string ReadPermission
				{
				[Dot42.DexImport("getReadPermission", "()Ljava/lang/String;", AccessFlags = 17)]
						get{ return GetReadPermission(); }
				[Dot42.DexImport("setReadPermission", "(Ljava/lang/String;)V", AccessFlags = 20)]
						set{ SetReadPermission(value); }
				}

				/// <java-name>
				/// getWritePermission
				/// </java-name>
				public string WritePermission
				{
				[Dot42.DexImport("getWritePermission", "()Ljava/lang/String;", AccessFlags = 17)]
						get{ return GetWritePermission(); }
				[Dot42.DexImport("setWritePermission", "(Ljava/lang/String;)V", AccessFlags = 20)]
						set{ SetWritePermission(value); }
				}

				/// <java-name>
				/// getPathPermissions
				/// </java-name>
				public global::Android.Content.Pm.PathPermission[] PathPermissions
				{
				[Dot42.DexImport("getPathPermissions", "()[Landroid/content/pm/PathPermission;", AccessFlags = 17)]
						get{ return GetPathPermissions(); }
				[Dot42.DexImport("setPathPermissions", "([Landroid/content/pm/PathPermission;)V", AccessFlags = 20)]
						set{ SetPathPermissions(value); }
				}

				/// <java-name>
				/// android/content/ContentProvider$PipeDataWriter
				/// </java-name>
				[Dot42.DexImport("android/content/ContentProvider$PipeDataWriter", AccessFlags = 1545, Signature = "<T:Ljava/lang/Object;>Ljava/lang/Object;")]
				public partial interface IPipeDataWriter<T>
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// writeDataToPipe
						/// </java-name>
						[Dot42.DexImport("writeDataToPipe", "(Landroid/os/ParcelFileDescriptor;Landroid/net/Uri;Ljava/lang/String;Landroid/os/" +
    "Bundle;Ljava/lang/Object;)V", AccessFlags = 1025, Signature = "(Landroid/os/ParcelFileDescriptor;Landroid/net/Uri;Ljava/lang/String;Landroid/os/" +
    "Bundle;TT;)V")]
						void WriteDataToPipe(global::Android.Os.ParcelFileDescriptor parcelFileDescriptor, global::Android.Net.Uri uri, string @string, global::Android.Os.Bundle bundle, T t) /* MethodBuilder.Create */ ;

				}

		}

		/// <java-name>
		/// android/content/ReceiverCallNotAllowedException
		/// </java-name>
		[Dot42.DexImport("android/content/ReceiverCallNotAllowedException", AccessFlags = 33)]
		public partial class ReceiverCallNotAllowedException : global::Android.Util.AndroidRuntimeException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public ReceiverCallNotAllowedException(string @string) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ReceiverCallNotAllowedException() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// android/content/ComponentCallbacks
		/// </java-name>
		[Dot42.DexImport("android/content/ComponentCallbacks", AccessFlags = 1537)]
		public partial interface IComponentCallbacks
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// onConfigurationChanged
				/// </java-name>
				[Dot42.DexImport("onConfigurationChanged", "(Landroid/content/res/Configuration;)V", AccessFlags = 1025)]
				void OnConfigurationChanged(global::Android.Content.Res.Configuration configuration) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// onLowMemory
				/// </java-name>
				[Dot42.DexImport("onLowMemory", "()V", AccessFlags = 1025)]
				void OnLowMemory() /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// android/content/ComponentName
		/// </java-name>
		[Dot42.DexImport("android/content/ComponentName", AccessFlags = 49, Signature = "Ljava/lang/Object;Landroid/os/Parcelable;Ljava/lang/Cloneable;Ljava/lang/Comparab" +
    "le<Landroid/content/ComponentName;>;")]
		public sealed partial class ComponentName : global::Android.Os.IParcelable, global::Java.Lang.ICloneable, global::System.IComparable<global::Android.Content.ComponentName>
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.Os.IParcelable_ICreator<global::Android.Content.ComponentName> CREATOR;
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

				[Dot42.DexImport("<init>", "(Landroid/os/Parcel;)V", AccessFlags = 1)]
				public ComponentName(global::Android.Os.Parcel parcel) /* MethodBuilder.Create */ 
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

				/// <java-name>
				/// getPackageName
				/// </java-name>
				[Dot42.DexImport("getPackageName", "()Ljava/lang/String;", AccessFlags = 1)]
				public string GetPackageName() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getClassName
				/// </java-name>
				[Dot42.DexImport("getClassName", "()Ljava/lang/String;", AccessFlags = 1)]
				public string GetClassName() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getShortClassName
				/// </java-name>
				[Dot42.DexImport("getShortClassName", "()Ljava/lang/String;", AccessFlags = 1)]
				public string GetShortClassName() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// flattenToString
				/// </java-name>
				[Dot42.DexImport("flattenToString", "()Ljava/lang/String;", AccessFlags = 1)]
				public string FlattenToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// flattenToShortString
				/// </java-name>
				[Dot42.DexImport("flattenToShortString", "()Ljava/lang/String;", AccessFlags = 1)]
				public string FlattenToShortString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// unflattenFromString
				/// </java-name>
				[Dot42.DexImport("unflattenFromString", "(Ljava/lang/String;)Landroid/content/ComponentName;", AccessFlags = 9)]
				public static global::Android.Content.ComponentName UnflattenFromString(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.ComponentName);
				}

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
				/// compareTo
				/// </java-name>
				[Dot42.DexImport("compareTo", "(Landroid/content/ComponentName;)I", AccessFlags = 1)]
				public int CompareTo(global::Android.Content.ComponentName componentName) /* MethodBuilder.Create */ 
				{
						return default(int);
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
				public void WriteToParcel(global::Android.Os.Parcel parcel, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/content/ComponentName;Landroid/os/Parcel;)V", AccessFlags = 9)]
				public static void WriteToParcel(global::Android.Content.ComponentName componentName, global::Android.Os.Parcel parcel) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// readFromParcel
				/// </java-name>
				[Dot42.DexImport("readFromParcel", "(Landroid/os/Parcel;)Landroid/content/ComponentName;", AccessFlags = 9)]
				public static global::Android.Content.ComponentName ReadFromParcel(global::Android.Os.Parcel parcel) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.ComponentName);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ComponentName() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getPackageName
				/// </java-name>
				public string PackageName
				{
				[Dot42.DexImport("getPackageName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetPackageName(); }
				}

				/// <java-name>
				/// getClassName
				/// </java-name>
				public string ClassName
				{
				[Dot42.DexImport("getClassName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetClassName(); }
				}

				/// <java-name>
				/// getShortClassName
				/// </java-name>
				public string ShortClassName
				{
				[Dot42.DexImport("getShortClassName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetShortClassName(); }
				}

		}

		/// <java-name>
		/// android/content/ContentValues
		/// </java-name>
		[Dot42.DexImport("android/content/ContentValues", AccessFlags = 49)]
		public sealed partial class ContentValues : global::Android.Os.IParcelable
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
				public static readonly global::Android.Os.IParcelable_ICreator<global::Android.Content.ContentValues> CREATOR;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ContentValues() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public ContentValues(int int32) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/ContentValues;)V", AccessFlags = 1)]
				public ContentValues(global::Android.Content.ContentValues contentValues) /* MethodBuilder.Create */ 
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

				/// <java-name>
				/// putAll
				/// </java-name>
				[Dot42.DexImport("putAll", "(Landroid/content/ContentValues;)V", AccessFlags = 1)]
				public void PutAll(global::Android.Content.ContentValues contentValues) /* MethodBuilder.Create */ 
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
				[Dot42.DexImport("put", "(Ljava/lang/String;[B)V", AccessFlags = 1)]
				public void Put(string @string, sbyte[] sByte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "(Ljava/lang/String;[B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public void Put(string @string, byte[] @byte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// putNull
				/// </java-name>
				[Dot42.DexImport("putNull", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public void PutNull(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// size
				/// </java-name>
				[Dot42.DexImport("size", "()I", AccessFlags = 1)]
				public int Size() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// remove
				/// </java-name>
				[Dot42.DexImport("remove", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public void Remove(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// clear
				/// </java-name>
				[Dot42.DexImport("clear", "()V", AccessFlags = 1)]
				public void Clear() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// containsKey
				/// </java-name>
				[Dot42.DexImport("containsKey", "(Ljava/lang/String;)Z", AccessFlags = 1)]
				public bool ContainsKey(string @string) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(Ljava/lang/String;)Ljava/lang/Object;", AccessFlags = 1)]
				public object Get(string @string) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <java-name>
				/// getAsString
				/// </java-name>
				[Dot42.DexImport("getAsString", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1)]
				public string GetAsString(string @string) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getAsLong
				/// </java-name>
				[Dot42.DexImport("getAsLong", "(Ljava/lang/String;)Ljava/lang/Long;", AccessFlags = 1)]
				public long? GetAsLong(string @string) /* MethodBuilder.Create */ 
				{
						return default(long?);
				}

				/// <java-name>
				/// getAsInteger
				/// </java-name>
				[Dot42.DexImport("getAsInteger", "(Ljava/lang/String;)Ljava/lang/Integer;", AccessFlags = 1)]
				public int? GetAsInteger(string @string) /* MethodBuilder.Create */ 
				{
						return default(int?);
				}

				/// <java-name>
				/// getAsShort
				/// </java-name>
				[Dot42.DexImport("getAsShort", "(Ljava/lang/String;)Ljava/lang/Short;", AccessFlags = 1)]
				public short? GetAsShort(string @string) /* MethodBuilder.Create */ 
				{
						return default(short?);
				}

				/// <java-name>
				/// getAsByte
				/// </java-name>
				[Dot42.DexImport("getAsByte", "(Ljava/lang/String;)Ljava/lang/Byte;", AccessFlags = 1)]
				public sbyte? GetAsByte(string @string) /* MethodBuilder.Create */ 
				{
						return default(sbyte?);
				}

				/// <java-name>
				/// getAsDouble
				/// </java-name>
				[Dot42.DexImport("getAsDouble", "(Ljava/lang/String;)Ljava/lang/Double;", AccessFlags = 1)]
				public double? GetAsDouble(string @string) /* MethodBuilder.Create */ 
				{
						return default(double?);
				}

				/// <java-name>
				/// getAsFloat
				/// </java-name>
				[Dot42.DexImport("getAsFloat", "(Ljava/lang/String;)Ljava/lang/Float;", AccessFlags = 1)]
				public float? GetAsFloat(string @string) /* MethodBuilder.Create */ 
				{
						return default(float?);
				}

				/// <java-name>
				/// getAsBoolean
				/// </java-name>
				[Dot42.DexImport("getAsBoolean", "(Ljava/lang/String;)Ljava/lang/Boolean;", AccessFlags = 1)]
				public bool? GetAsBoolean(string @string) /* MethodBuilder.Create */ 
				{
						return default(bool?);
				}

				/// <java-name>
				/// getAsByteArray
				/// </java-name>
				[Dot42.DexImport("getAsByteArray", "(Ljava/lang/String;)[B", AccessFlags = 1)]
				public sbyte[] JavaGetAsByteArray(string @string) /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <java-name>
				/// getAsByteArray
				/// </java-name>
				[Dot42.DexImport("getAsByteArray", "(Ljava/lang/String;)[B", AccessFlags = 1, IgnoreFromJava = true)]
				public byte[] GetAsByteArray(string @string) /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				/// <java-name>
				/// valueSet
				/// </java-name>
				[Dot42.DexImport("valueSet", "()Ljava/util/Set;", AccessFlags = 1, Signature = "()Ljava/util/Set<Ljava/util/Map$Entry<Ljava/lang/String;Ljava/lang/Object;>;>;")]
				public global::Java.Util.ISet<global::Java.Util.IMap_IEntry<string, object>> ValueSet() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ISet<global::Java.Util.IMap_IEntry<string, object>>);
				}

				/// <java-name>
				/// keySet
				/// </java-name>
				[Dot42.DexImport("keySet", "()Ljava/util/Set;", AccessFlags = 1, Signature = "()Ljava/util/Set<Ljava/lang/String;>;")]
				public global::Java.Util.ISet<string> KeySet() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ISet<string>);
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
				public void WriteToParcel(global::Android.Os.Parcel parcel, int int32) /* MethodBuilder.Create */ 
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
				public OperationApplicationException(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public OperationApplicationException(string @string, global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public OperationApplicationException(global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public OperationApplicationException(int int32) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;I)V", AccessFlags = 1)]
				public OperationApplicationException(string @string, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getNumSuccessfulYieldPoints
				/// </java-name>
				[Dot42.DexImport("getNumSuccessfulYieldPoints", "()I", AccessFlags = 1)]
				public virtual int GetNumSuccessfulYieldPoints() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getNumSuccessfulYieldPoints
				/// </java-name>
				public int NumSuccessfulYieldPoints
				{
				[Dot42.DexImport("getNumSuccessfulYieldPoints", "()I", AccessFlags = 1)]
						get{ return GetNumSuccessfulYieldPoints(); }
				}

		}

		/// <java-name>
		/// android/content/ContentProviderResult
		/// </java-name>
		[Dot42.DexImport("android/content/ContentProviderResult", AccessFlags = 33)]
		public partial class ContentProviderResult : global::Android.Os.IParcelable
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
				public static readonly global::Android.Os.IParcelable_ICreator<global::Android.Content.ContentProviderResult> CREATOR;
				[Dot42.DexImport("<init>", "(Landroid/net/Uri;)V", AccessFlags = 1)]
				public ContentProviderResult(global::Android.Net.Uri uri) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public ContentProviderResult(int int32) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/os/Parcel;)V", AccessFlags = 1)]
				public ContentProviderResult(global::Android.Os.Parcel parcel) /* MethodBuilder.Create */ 
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
				internal ContentProviderResult() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// android/content/EntityIterator
		/// </java-name>
		[Dot42.DexImport("android/content/EntityIterator", AccessFlags = 1537, Signature = "Ljava/lang/Object;Ljava/util/Iterator<Landroid/content/Entity;>;")]
		public partial interface IEntityIterator : global::Java.Util.IIterator<global::Android.Content.Entity>
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// reset
				/// </java-name>
				[Dot42.DexImport("reset", "()V", AccessFlags = 1025)]
				void Reset() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1025)]
				void Close() /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// android/content/ContentResolver
		/// </java-name>
		[Dot42.DexImport("android/content/ContentResolver", AccessFlags = 1057)]
		public abstract partial class ContentResolver
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// SYNC_EXTRAS_ACCOUNT
				/// </java-name>
				[Dot42.DexImport("SYNC_EXTRAS_ACCOUNT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SYNC_EXTRAS_ACCOUNT = "account";
				/// <java-name>
				/// SYNC_EXTRAS_EXPEDITED
				/// </java-name>
				[Dot42.DexImport("SYNC_EXTRAS_EXPEDITED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SYNC_EXTRAS_EXPEDITED = "expedited";
				/// <java-name>
				/// SYNC_EXTRAS_FORCE
				/// </java-name>
				[Dot42.DexImport("SYNC_EXTRAS_FORCE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SYNC_EXTRAS_FORCE = "force";
				/// <java-name>
				/// SYNC_EXTRAS_IGNORE_SETTINGS
				/// </java-name>
				[Dot42.DexImport("SYNC_EXTRAS_IGNORE_SETTINGS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SYNC_EXTRAS_IGNORE_SETTINGS = "ignore_settings";
				/// <java-name>
				/// SYNC_EXTRAS_IGNORE_BACKOFF
				/// </java-name>
				[Dot42.DexImport("SYNC_EXTRAS_IGNORE_BACKOFF", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SYNC_EXTRAS_IGNORE_BACKOFF = "ignore_backoff";
				/// <java-name>
				/// SYNC_EXTRAS_DO_NOT_RETRY
				/// </java-name>
				[Dot42.DexImport("SYNC_EXTRAS_DO_NOT_RETRY", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SYNC_EXTRAS_DO_NOT_RETRY = "do_not_retry";
				/// <java-name>
				/// SYNC_EXTRAS_MANUAL
				/// </java-name>
				[Dot42.DexImport("SYNC_EXTRAS_MANUAL", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SYNC_EXTRAS_MANUAL = "force";
				/// <java-name>
				/// SYNC_EXTRAS_UPLOAD
				/// </java-name>
				[Dot42.DexImport("SYNC_EXTRAS_UPLOAD", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SYNC_EXTRAS_UPLOAD = "upload";
				/// <java-name>
				/// SYNC_EXTRAS_OVERRIDE_TOO_MANY_DELETIONS
				/// </java-name>
				[Dot42.DexImport("SYNC_EXTRAS_OVERRIDE_TOO_MANY_DELETIONS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SYNC_EXTRAS_OVERRIDE_TOO_MANY_DELETIONS = "deletions_override";
				/// <java-name>
				/// SYNC_EXTRAS_DISCARD_LOCAL_DELETIONS
				/// </java-name>
				[Dot42.DexImport("SYNC_EXTRAS_DISCARD_LOCAL_DELETIONS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SYNC_EXTRAS_DISCARD_LOCAL_DELETIONS = "discard_deletions";
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
				/// <java-name>
				/// CURSOR_ITEM_BASE_TYPE
				/// </java-name>
				[Dot42.DexImport("CURSOR_ITEM_BASE_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string CURSOR_ITEM_BASE_TYPE = "vnd.android.cursor.item";
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

				/// <java-name>
				/// getType
				/// </java-name>
				[Dot42.DexImport("getType", "(Landroid/net/Uri;)Ljava/lang/String;", AccessFlags = 17)]
				public string GetType(global::Android.Net.Uri uri) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getStreamTypes
				/// </java-name>
				[Dot42.DexImport("getStreamTypes", "(Landroid/net/Uri;Ljava/lang/String;)[Ljava/lang/String;", AccessFlags = 1)]
				public virtual string[] GetStreamTypes(global::Android.Net.Uri uri, string @string) /* MethodBuilder.Create */ 
				{
						return default(string[]);
				}

				/// <java-name>
				/// query
				/// </java-name>
				[Dot42.DexImport("query", "(Landroid/net/Uri;[Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/l" +
    "ang/String;)Landroid/database/Cursor;", AccessFlags = 17)]
				public global::Android.Database.ICursor Query(global::Android.Net.Uri uri, string[] @string, string string1, string[] string2, string string3) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Database.ICursor);
				}

				/// <java-name>
				/// openInputStream
				/// </java-name>
				[Dot42.DexImport("openInputStream", "(Landroid/net/Uri;)Ljava/io/InputStream;", AccessFlags = 17)]
				public global::Java.Io.InputStream OpenInputStream(global::Android.Net.Uri uri) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.InputStream);
				}

				/// <java-name>
				/// openOutputStream
				/// </java-name>
				[Dot42.DexImport("openOutputStream", "(Landroid/net/Uri;)Ljava/io/OutputStream;", AccessFlags = 17)]
				public global::Java.Io.OutputStream OpenOutputStream(global::Android.Net.Uri uri) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.OutputStream);
				}

				/// <java-name>
				/// openOutputStream
				/// </java-name>
				[Dot42.DexImport("openOutputStream", "(Landroid/net/Uri;Ljava/lang/String;)Ljava/io/OutputStream;", AccessFlags = 17)]
				public global::Java.Io.OutputStream OpenOutputStream(global::Android.Net.Uri uri, string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.OutputStream);
				}

				/// <java-name>
				/// openFileDescriptor
				/// </java-name>
				[Dot42.DexImport("openFileDescriptor", "(Landroid/net/Uri;Ljava/lang/String;)Landroid/os/ParcelFileDescriptor;", AccessFlags = 17)]
				public global::Android.Os.ParcelFileDescriptor OpenFileDescriptor(global::Android.Net.Uri uri, string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Os.ParcelFileDescriptor);
				}

				/// <java-name>
				/// openAssetFileDescriptor
				/// </java-name>
				[Dot42.DexImport("openAssetFileDescriptor", "(Landroid/net/Uri;Ljava/lang/String;)Landroid/content/res/AssetFileDescriptor;", AccessFlags = 17)]
				public global::Android.Content.Res.AssetFileDescriptor OpenAssetFileDescriptor(global::Android.Net.Uri uri, string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Res.AssetFileDescriptor);
				}

				/// <java-name>
				/// openTypedAssetFileDescriptor
				/// </java-name>
				[Dot42.DexImport("openTypedAssetFileDescriptor", "(Landroid/net/Uri;Ljava/lang/String;Landroid/os/Bundle;)Landroid/content/res/Asse" +
    "tFileDescriptor;", AccessFlags = 17)]
				public global::Android.Content.Res.AssetFileDescriptor OpenTypedAssetFileDescriptor(global::Android.Net.Uri uri, string @string, global::Android.Os.Bundle bundle) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Res.AssetFileDescriptor);
				}

				/// <java-name>
				/// insert
				/// </java-name>
				[Dot42.DexImport("insert", "(Landroid/net/Uri;Landroid/content/ContentValues;)Landroid/net/Uri;", AccessFlags = 17)]
				public global::Android.Net.Uri Insert(global::Android.Net.Uri uri, global::Android.Content.ContentValues contentValues) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Net.Uri);
				}

				/// <java-name>
				/// applyBatch
				/// </java-name>
				[Dot42.DexImport("applyBatch", "(Ljava/lang/String;Ljava/util/ArrayList;)[Landroid/content/ContentProviderResult;" +
    "", AccessFlags = 1, Signature = "(Ljava/lang/String;Ljava/util/ArrayList<Landroid/content/ContentProviderOperation" +
    ";>;)[Landroid/content/ContentProviderResult;")]
				public virtual global::Android.Content.ContentProviderResult[] ApplyBatch(string @string, global::Java.Util.ArrayList<global::Android.Content.ContentProviderOperation> arrayList) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.ContentProviderResult[]);
				}

				/// <java-name>
				/// bulkInsert
				/// </java-name>
				[Dot42.DexImport("bulkInsert", "(Landroid/net/Uri;[Landroid/content/ContentValues;)I", AccessFlags = 17)]
				public int BulkInsert(global::Android.Net.Uri uri, global::Android.Content.ContentValues[] contentValues) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// delete
				/// </java-name>
				[Dot42.DexImport("delete", "(Landroid/net/Uri;Ljava/lang/String;[Ljava/lang/String;)I", AccessFlags = 17)]
				public int Delete(global::Android.Net.Uri uri, string @string, string[] string1) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// update
				/// </java-name>
				[Dot42.DexImport("update", "(Landroid/net/Uri;Landroid/content/ContentValues;Ljava/lang/String;[Ljava/lang/St" +
    "ring;)I", AccessFlags = 17)]
				public int Update(global::Android.Net.Uri uri, global::Android.Content.ContentValues contentValues, string @string, string[] string1) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// call
				/// </java-name>
				[Dot42.DexImport("call", "(Landroid/net/Uri;Ljava/lang/String;Ljava/lang/String;Landroid/os/Bundle;)Landroi" +
    "d/os/Bundle;", AccessFlags = 17)]
				public global::Android.Os.Bundle Call(global::Android.Net.Uri uri, string @string, string string1, global::Android.Os.Bundle bundle) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Os.Bundle);
				}

				/// <java-name>
				/// acquireContentProviderClient
				/// </java-name>
				[Dot42.DexImport("acquireContentProviderClient", "(Landroid/net/Uri;)Landroid/content/ContentProviderClient;", AccessFlags = 17)]
				public global::Android.Content.ContentProviderClient AcquireContentProviderClient(global::Android.Net.Uri uri) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.ContentProviderClient);
				}

				/// <java-name>
				/// acquireContentProviderClient
				/// </java-name>
				[Dot42.DexImport("acquireContentProviderClient", "(Ljava/lang/String;)Landroid/content/ContentProviderClient;", AccessFlags = 17)]
				public global::Android.Content.ContentProviderClient AcquireContentProviderClient(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.ContentProviderClient);
				}

				/// <java-name>
				/// registerContentObserver
				/// </java-name>
				[Dot42.DexImport("registerContentObserver", "(Landroid/net/Uri;ZLandroid/database/ContentObserver;)V", AccessFlags = 17)]
				public void RegisterContentObserver(global::Android.Net.Uri uri, bool boolean, global::Android.Database.ContentObserver contentObserver) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// unregisterContentObserver
				/// </java-name>
				[Dot42.DexImport("unregisterContentObserver", "(Landroid/database/ContentObserver;)V", AccessFlags = 17)]
				public void UnregisterContentObserver(global::Android.Database.ContentObserver contentObserver) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// notifyChange
				/// </java-name>
				[Dot42.DexImport("notifyChange", "(Landroid/net/Uri;Landroid/database/ContentObserver;)V", AccessFlags = 1)]
				public virtual void NotifyChange(global::Android.Net.Uri uri, global::Android.Database.ContentObserver contentObserver) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// notifyChange
				/// </java-name>
				[Dot42.DexImport("notifyChange", "(Landroid/net/Uri;Landroid/database/ContentObserver;Z)V", AccessFlags = 1)]
				public virtual void NotifyChange(global::Android.Net.Uri uri, global::Android.Database.ContentObserver contentObserver, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// startSync
				/// </java-name>
				[Dot42.DexImport("startSync", "(Landroid/net/Uri;Landroid/os/Bundle;)V", AccessFlags = 1)]
				public virtual void StartSync(global::Android.Net.Uri uri, global::Android.Os.Bundle bundle) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// requestSync
				/// </java-name>
				[Dot42.DexImport("requestSync", "(Landroid/accounts/Account;Ljava/lang/String;Landroid/os/Bundle;)V", AccessFlags = 9)]
				public static void RequestSync(global::Android.Accounts.Account account, string @string, global::Android.Os.Bundle bundle) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// validateSyncExtrasBundle
				/// </java-name>
				[Dot42.DexImport("validateSyncExtrasBundle", "(Landroid/os/Bundle;)V", AccessFlags = 9)]
				public static void ValidateSyncExtrasBundle(global::Android.Os.Bundle bundle) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// cancelSync
				/// </java-name>
				[Dot42.DexImport("cancelSync", "(Landroid/net/Uri;)V", AccessFlags = 1)]
				public virtual void CancelSync(global::Android.Net.Uri uri) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// cancelSync
				/// </java-name>
				[Dot42.DexImport("cancelSync", "(Landroid/accounts/Account;Ljava/lang/String;)V", AccessFlags = 9)]
				public static void CancelSync(global::Android.Accounts.Account account, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getSyncAdapterTypes
				/// </java-name>
				[Dot42.DexImport("getSyncAdapterTypes", "()[Landroid/content/SyncAdapterType;", AccessFlags = 9)]
				public static global::Android.Content.SyncAdapterType[] GetSyncAdapterTypes() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.SyncAdapterType[]);
				}

				/// <java-name>
				/// getSyncAutomatically
				/// </java-name>
				[Dot42.DexImport("getSyncAutomatically", "(Landroid/accounts/Account;Ljava/lang/String;)Z", AccessFlags = 9)]
				public static bool GetSyncAutomatically(global::Android.Accounts.Account account, string @string) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setSyncAutomatically
				/// </java-name>
				[Dot42.DexImport("setSyncAutomatically", "(Landroid/accounts/Account;Ljava/lang/String;Z)V", AccessFlags = 9)]
				public static void SetSyncAutomatically(global::Android.Accounts.Account account, string @string, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addPeriodicSync
				/// </java-name>
				[Dot42.DexImport("addPeriodicSync", "(Landroid/accounts/Account;Ljava/lang/String;Landroid/os/Bundle;J)V", AccessFlags = 9)]
				public static void AddPeriodicSync(global::Android.Accounts.Account account, string @string, global::Android.Os.Bundle bundle, long int64) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// removePeriodicSync
				/// </java-name>
				[Dot42.DexImport("removePeriodicSync", "(Landroid/accounts/Account;Ljava/lang/String;Landroid/os/Bundle;)V", AccessFlags = 9)]
				public static void RemovePeriodicSync(global::Android.Accounts.Account account, string @string, global::Android.Os.Bundle bundle) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getPeriodicSyncs
				/// </java-name>
				[Dot42.DexImport("getPeriodicSyncs", "(Landroid/accounts/Account;Ljava/lang/String;)Ljava/util/List;", AccessFlags = 9, Signature = "(Landroid/accounts/Account;Ljava/lang/String;)Ljava/util/List<Landroid/content/Pe" +
    "riodicSync;>;")]
				public static global::Java.Util.IList<global::Android.Content.PeriodicSync> GetPeriodicSyncs(global::Android.Accounts.Account account, string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<global::Android.Content.PeriodicSync>);
				}

				/// <java-name>
				/// getIsSyncable
				/// </java-name>
				[Dot42.DexImport("getIsSyncable", "(Landroid/accounts/Account;Ljava/lang/String;)I", AccessFlags = 9)]
				public static int GetIsSyncable(global::Android.Accounts.Account account, string @string) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// setIsSyncable
				/// </java-name>
				[Dot42.DexImport("setIsSyncable", "(Landroid/accounts/Account;Ljava/lang/String;I)V", AccessFlags = 9)]
				public static void SetIsSyncable(global::Android.Accounts.Account account, string @string, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getMasterSyncAutomatically
				/// </java-name>
				[Dot42.DexImport("getMasterSyncAutomatically", "()Z", AccessFlags = 9)]
				public static bool GetMasterSyncAutomatically() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setMasterSyncAutomatically
				/// </java-name>
				[Dot42.DexImport("setMasterSyncAutomatically", "(Z)V", AccessFlags = 9)]
				public static void SetMasterSyncAutomatically(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isSyncActive
				/// </java-name>
				[Dot42.DexImport("isSyncActive", "(Landroid/accounts/Account;Ljava/lang/String;)Z", AccessFlags = 9)]
				public static bool IsSyncActive(global::Android.Accounts.Account account, string @string) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getCurrentSync
				/// </java-name>
				[Dot42.DexImport("getCurrentSync", "()Landroid/content/SyncInfo;", AccessFlags = 9)]
				public static global::Android.Content.SyncInfo GetCurrentSync() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.SyncInfo);
				}

				/// <java-name>
				/// getCurrentSyncs
				/// </java-name>
				[Dot42.DexImport("getCurrentSyncs", "()Ljava/util/List;", AccessFlags = 9, Signature = "()Ljava/util/List<Landroid/content/SyncInfo;>;")]
				public static global::Java.Util.IList<global::Android.Content.SyncInfo> GetCurrentSyncs() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<global::Android.Content.SyncInfo>);
				}

				/// <java-name>
				/// isSyncPending
				/// </java-name>
				[Dot42.DexImport("isSyncPending", "(Landroid/accounts/Account;Ljava/lang/String;)Z", AccessFlags = 9)]
				public static bool IsSyncPending(global::Android.Accounts.Account account, string @string) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// addStatusChangeListener
				/// </java-name>
				[Dot42.DexImport("addStatusChangeListener", "(ILandroid/content/SyncStatusObserver;)Ljava/lang/Object;", AccessFlags = 9)]
				public static object AddStatusChangeListener(int int32, global::Android.Content.ISyncStatusObserver syncStatusObserver) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <java-name>
				/// removeStatusChangeListener
				/// </java-name>
				[Dot42.DexImport("removeStatusChangeListener", "(Ljava/lang/Object;)V", AccessFlags = 9)]
				public static void RemoveStatusChangeListener(object @object) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ContentResolver() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getSyncAdapterTypes
				/// </java-name>
				public static global::Android.Content.SyncAdapterType[] SyncAdapterTypes
				{
				[Dot42.DexImport("getSyncAdapterTypes", "()[Landroid/content/SyncAdapterType;", AccessFlags = 9)]
						get{ return GetSyncAdapterTypes(); }
				}

				/// <java-name>
				/// getMasterSyncAutomatically
				/// </java-name>
				public static bool IsMasterSyncAutomatically
				{
				[Dot42.DexImport("getMasterSyncAutomatically", "()Z", AccessFlags = 9)]
						get{ return GetMasterSyncAutomatically(); }
				[Dot42.DexImport("setMasterSyncAutomatically", "(Z)V", AccessFlags = 9)]
						set{ SetMasterSyncAutomatically(value); }
				}

				/// <java-name>
				/// getCurrentSync
				/// </java-name>
				public static global::Android.Content.SyncInfo CurrentSync
				{
				[Dot42.DexImport("getCurrentSync", "()Landroid/content/SyncInfo;", AccessFlags = 9)]
						get{ return GetCurrentSync(); }
				}

				/// <java-name>
				/// getCurrentSyncs
				/// </java-name>
				public static global::Java.Util.IList<global::Android.Content.SyncInfo> CurrentSyncs
				{
				[Dot42.DexImport("getCurrentSyncs", "()Ljava/util/List;", AccessFlags = 9, Signature = "()Ljava/util/List<Landroid/content/SyncInfo;>;")]
						get{ return GetCurrentSyncs(); }
				}

		}

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

				/// <java-name>
				/// onReceive
				/// </java-name>
				[Dot42.DexImport("onReceive", "(Landroid/content/Context;Landroid/content/Intent;)V", AccessFlags = 1025)]
				public abstract void OnReceive(global::Android.Content.Context context, global::Android.Content.Intent intent) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// goAsync
				/// </java-name>
				[Dot42.DexImport("goAsync", "()Landroid/content/BroadcastReceiver$PendingResult;", AccessFlags = 17)]
				public global::Android.Content.BroadcastReceiver.PendingResult GoAsync() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.BroadcastReceiver.PendingResult);
				}

				/// <java-name>
				/// peekService
				/// </java-name>
				[Dot42.DexImport("peekService", "(Landroid/content/Context;Landroid/content/Intent;)Landroid/os/IBinder;", AccessFlags = 1)]
				public virtual global::Android.Os.IBinder PeekService(global::Android.Content.Context context, global::Android.Content.Intent intent) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Os.IBinder);
				}

				/// <java-name>
				/// setResultCode
				/// </java-name>
				[Dot42.DexImport("setResultCode", "(I)V", AccessFlags = 17)]
				public void SetResultCode(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getResultCode
				/// </java-name>
				[Dot42.DexImport("getResultCode", "()I", AccessFlags = 17)]
				public int GetResultCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// setResultData
				/// </java-name>
				[Dot42.DexImport("setResultData", "(Ljava/lang/String;)V", AccessFlags = 17)]
				public void SetResultData(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getResultData
				/// </java-name>
				[Dot42.DexImport("getResultData", "()Ljava/lang/String;", AccessFlags = 17)]
				public string GetResultData() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// setResultExtras
				/// </java-name>
				[Dot42.DexImport("setResultExtras", "(Landroid/os/Bundle;)V", AccessFlags = 17)]
				public void SetResultExtras(global::Android.Os.Bundle bundle) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getResultExtras
				/// </java-name>
				[Dot42.DexImport("getResultExtras", "(Z)Landroid/os/Bundle;", AccessFlags = 17)]
				public global::Android.Os.Bundle GetResultExtras(bool boolean) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Os.Bundle);
				}

				/// <java-name>
				/// setResult
				/// </java-name>
				[Dot42.DexImport("setResult", "(ILjava/lang/String;Landroid/os/Bundle;)V", AccessFlags = 17)]
				public void SetResult(int int32, string @string, global::Android.Os.Bundle bundle) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getAbortBroadcast
				/// </java-name>
				[Dot42.DexImport("getAbortBroadcast", "()Z", AccessFlags = 17)]
				public bool GetAbortBroadcast() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// abortBroadcast
				/// </java-name>
				[Dot42.DexImport("abortBroadcast", "()V", AccessFlags = 17)]
				public void AbortBroadcast() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// clearAbortBroadcast
				/// </java-name>
				[Dot42.DexImport("clearAbortBroadcast", "()V", AccessFlags = 17)]
				public void ClearAbortBroadcast() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isOrderedBroadcast
				/// </java-name>
				[Dot42.DexImport("isOrderedBroadcast", "()Z", AccessFlags = 17)]
				public bool IsOrderedBroadcast() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isInitialStickyBroadcast
				/// </java-name>
				[Dot42.DexImport("isInitialStickyBroadcast", "()Z", AccessFlags = 17)]
				public bool IsInitialStickyBroadcast() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setOrderedHint
				/// </java-name>
				[Dot42.DexImport("setOrderedHint", "(Z)V", AccessFlags = 17)]
				public void SetOrderedHint(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setDebugUnregister
				/// </java-name>
				[Dot42.DexImport("setDebugUnregister", "(Z)V", AccessFlags = 17)]
				public void SetDebugUnregister(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getDebugUnregister
				/// </java-name>
				[Dot42.DexImport("getDebugUnregister", "()Z", AccessFlags = 17)]
				public bool GetDebugUnregister() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getResultCode
				/// </java-name>
				public int ResultCode
				{
				[Dot42.DexImport("getResultCode", "()I", AccessFlags = 17)]
						get{ return GetResultCode(); }
				[Dot42.DexImport("setResultCode", "(I)V", AccessFlags = 17)]
						set{ SetResultCode(value); }
				}

				/// <java-name>
				/// getResultData
				/// </java-name>
				public string ResultData
				{
				[Dot42.DexImport("getResultData", "()Ljava/lang/String;", AccessFlags = 17)]
						get{ return GetResultData(); }
				[Dot42.DexImport("setResultData", "(Ljava/lang/String;)V", AccessFlags = 17)]
						set{ SetResultData(value); }
				}

				/// <java-name>
				/// getAbortBroadcast
				/// </java-name>
				public bool IsAbortBroadcast
				{
				[Dot42.DexImport("getAbortBroadcast", "()Z", AccessFlags = 17)]
						get{ return GetAbortBroadcast(); }
				}

				/// <java-name>
				/// getDebugUnregister
				/// </java-name>
				public bool IsDebugUnregister
				{
				[Dot42.DexImport("getDebugUnregister", "()Z", AccessFlags = 17)]
						get{ return GetDebugUnregister(); }
				[Dot42.DexImport("setDebugUnregister", "(Z)V", AccessFlags = 17)]
						set{ SetDebugUnregister(value); }
				}

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

						/// <java-name>
						/// setResultCode
						/// </java-name>
						[Dot42.DexImport("setResultCode", "(I)V", AccessFlags = 17)]
						public void SetResultCode(int int32) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// getResultCode
						/// </java-name>
						[Dot42.DexImport("getResultCode", "()I", AccessFlags = 17)]
						public int GetResultCode() /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <java-name>
						/// setResultData
						/// </java-name>
						[Dot42.DexImport("setResultData", "(Ljava/lang/String;)V", AccessFlags = 17)]
						public void SetResultData(string @string) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// getResultData
						/// </java-name>
						[Dot42.DexImport("getResultData", "()Ljava/lang/String;", AccessFlags = 17)]
						public string GetResultData() /* MethodBuilder.Create */ 
						{
								return default(string);
						}

						/// <java-name>
						/// setResultExtras
						/// </java-name>
						[Dot42.DexImport("setResultExtras", "(Landroid/os/Bundle;)V", AccessFlags = 17)]
						public void SetResultExtras(global::Android.Os.Bundle bundle) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// getResultExtras
						/// </java-name>
						[Dot42.DexImport("getResultExtras", "(Z)Landroid/os/Bundle;", AccessFlags = 17)]
						public global::Android.Os.Bundle GetResultExtras(bool boolean) /* MethodBuilder.Create */ 
						{
								return default(global::Android.Os.Bundle);
						}

						/// <java-name>
						/// setResult
						/// </java-name>
						[Dot42.DexImport("setResult", "(ILjava/lang/String;Landroid/os/Bundle;)V", AccessFlags = 17)]
						public void SetResult(int int32, string @string, global::Android.Os.Bundle bundle) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// getAbortBroadcast
						/// </java-name>
						[Dot42.DexImport("getAbortBroadcast", "()Z", AccessFlags = 17)]
						public bool GetAbortBroadcast() /* MethodBuilder.Create */ 
						{
								return default(bool);
						}

						/// <java-name>
						/// abortBroadcast
						/// </java-name>
						[Dot42.DexImport("abortBroadcast", "()V", AccessFlags = 17)]
						public void AbortBroadcast() /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// clearAbortBroadcast
						/// </java-name>
						[Dot42.DexImport("clearAbortBroadcast", "()V", AccessFlags = 17)]
						public void ClearAbortBroadcast() /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// finish
						/// </java-name>
						[Dot42.DexImport("finish", "()V", AccessFlags = 17)]
						public void Finish() /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// getResultCode
						/// </java-name>
						public int ResultCode
						{
						[Dot42.DexImport("getResultCode", "()I", AccessFlags = 17)]
								get{ return GetResultCode(); }
						[Dot42.DexImport("setResultCode", "(I)V", AccessFlags = 17)]
								set{ SetResultCode(value); }
						}

						/// <java-name>
						/// getResultData
						/// </java-name>
						public string ResultData
						{
						[Dot42.DexImport("getResultData", "()Ljava/lang/String;", AccessFlags = 17)]
								get{ return GetResultData(); }
						[Dot42.DexImport("setResultData", "(Ljava/lang/String;)V", AccessFlags = 17)]
								set{ SetResultData(value); }
						}

						/// <java-name>
						/// getAbortBroadcast
						/// </java-name>
						public bool IsAbortBroadcast
						{
						[Dot42.DexImport("getAbortBroadcast", "()Z", AccessFlags = 17)]
								get{ return GetAbortBroadcast(); }
						}

				}

		}

		/// <java-name>
		/// android/content/AsyncQueryHandler
		/// </java-name>
		[Dot42.DexImport("android/content/AsyncQueryHandler", AccessFlags = 1057)]
		public abstract partial class AsyncQueryHandler : global::Android.Os.Handler
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/ContentResolver;)V", AccessFlags = 1)]
				public AsyncQueryHandler(global::Android.Content.ContentResolver contentResolver) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// createHandler
				/// </java-name>
				[Dot42.DexImport("createHandler", "(Landroid/os/Looper;)Landroid/os/Handler;", AccessFlags = 4)]
				protected internal virtual global::Android.Os.Handler CreateHandler(global::Android.Os.Looper looper) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Os.Handler);
				}

				/// <java-name>
				/// startQuery
				/// </java-name>
				[Dot42.DexImport("startQuery", "(ILjava/lang/Object;Landroid/net/Uri;[Ljava/lang/String;Ljava/lang/String;[Ljava/" +
    "lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void StartQuery(int int32, object @object, global::Android.Net.Uri uri, string[] @string, string string1, string[] string2, string string3) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// cancelOperation
				/// </java-name>
				[Dot42.DexImport("cancelOperation", "(I)V", AccessFlags = 17)]
				public void CancelOperation(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// startInsert
				/// </java-name>
				[Dot42.DexImport("startInsert", "(ILjava/lang/Object;Landroid/net/Uri;Landroid/content/ContentValues;)V", AccessFlags = 17)]
				public void StartInsert(int int32, object @object, global::Android.Net.Uri uri, global::Android.Content.ContentValues contentValues) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// startUpdate
				/// </java-name>
				[Dot42.DexImport("startUpdate", "(ILjava/lang/Object;Landroid/net/Uri;Landroid/content/ContentValues;Ljava/lang/St" +
    "ring;[Ljava/lang/String;)V", AccessFlags = 17)]
				public void StartUpdate(int int32, object @object, global::Android.Net.Uri uri, global::Android.Content.ContentValues contentValues, string @string, string[] string1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// startDelete
				/// </java-name>
				[Dot42.DexImport("startDelete", "(ILjava/lang/Object;Landroid/net/Uri;Ljava/lang/String;[Ljava/lang/String;)V", AccessFlags = 17)]
				public void StartDelete(int int32, object @object, global::Android.Net.Uri uri, string @string, string[] string1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onQueryComplete
				/// </java-name>
				[Dot42.DexImport("onQueryComplete", "(ILjava/lang/Object;Landroid/database/Cursor;)V", AccessFlags = 4)]
				protected internal virtual void OnQueryComplete(int int32, object @object, global::Android.Database.ICursor cursor) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onInsertComplete
				/// </java-name>
				[Dot42.DexImport("onInsertComplete", "(ILjava/lang/Object;Landroid/net/Uri;)V", AccessFlags = 4)]
				protected internal virtual void OnInsertComplete(int int32, object @object, global::Android.Net.Uri uri) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onUpdateComplete
				/// </java-name>
				[Dot42.DexImport("onUpdateComplete", "(ILjava/lang/Object;I)V", AccessFlags = 4)]
				protected internal virtual void OnUpdateComplete(int int32, object @object, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onDeleteComplete
				/// </java-name>
				[Dot42.DexImport("onDeleteComplete", "(ILjava/lang/Object;I)V", AccessFlags = 4)]
				protected internal virtual void OnDeleteComplete(int int32, object @object, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// handleMessage
				/// </java-name>
				[Dot42.DexImport("handleMessage", "(Landroid/os/Message;)V", AccessFlags = 1)]
				public override void HandleMessage(global::Android.Os.Message message) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal AsyncQueryHandler() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// android/content/AsyncQueryHandler$WorkerHandler
				/// </java-name>
				[Dot42.DexImport("android/content/AsyncQueryHandler$WorkerHandler", AccessFlags = 4)]
				protected internal partial class WorkerHandler : global::Android.Os.Handler
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// this$0
						/// </java-name>
						[Dot42.DexImport("this$0", "Landroid/content/AsyncQueryHandler;", AccessFlags = 4112)]
						internal readonly global::Android.Content.AsyncQueryHandler This_0;
						[Dot42.DexImport("<init>", "(Landroid/content/AsyncQueryHandler;Landroid/os/Looper;)V", AccessFlags = 1)]
						public WorkerHandler(global::Android.Content.AsyncQueryHandler asyncQueryHandler, global::Android.Os.Looper looper) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// handleMessage
						/// </java-name>
						[Dot42.DexImport("handleMessage", "(Landroid/os/Message;)V", AccessFlags = 1)]
						public override void HandleMessage(global::Android.Os.Message message) /* MethodBuilder.Create */ 
						{
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal WorkerHandler() /* TypeBuilder.AddDefaultConstructor */ 
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
						public global::Android.Os.Handler Handler;
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

		/// <java-name>
		/// android/content/SyncAdapterType
		/// </java-name>
		[Dot42.DexImport("android/content/SyncAdapterType", AccessFlags = 33)]
		public partial class SyncAdapterType : global::Android.Os.IParcelable
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
				public static readonly global::Android.Os.IParcelable_ICreator<global::Android.Content.SyncAdapterType> CREATOR;
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;ZZ)V", AccessFlags = 1)]
				public SyncAdapterType(string @string, string string1, bool boolean, bool boolean1) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/os/Parcel;)V", AccessFlags = 1)]
				public SyncAdapterType(global::Android.Os.Parcel parcel) /* MethodBuilder.Create */ 
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

				/// <java-name>
				/// isUserVisible
				/// </java-name>
				[Dot42.DexImport("isUserVisible", "()Z", AccessFlags = 1)]
				public virtual bool IsUserVisible() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// allowParallelSyncs
				/// </java-name>
				[Dot42.DexImport("allowParallelSyncs", "()Z", AccessFlags = 1)]
				public virtual bool AllowParallelSyncs() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isAlwaysSyncable
				/// </java-name>
				[Dot42.DexImport("isAlwaysSyncable", "()Z", AccessFlags = 1)]
				public virtual bool IsAlwaysSyncable() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getSettingsActivity
				/// </java-name>
				[Dot42.DexImport("getSettingsActivity", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetSettingsActivity() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// newKey
				/// </java-name>
				[Dot42.DexImport("newKey", "(Ljava/lang/String;Ljava/lang/String;)Landroid/content/SyncAdapterType;", AccessFlags = 9)]
				public static global::Android.Content.SyncAdapterType NewKey(string @string, string string1) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.SyncAdapterType);
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
				public virtual int DescribeContents() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public virtual void WriteToParcel(global::Android.Os.Parcel parcel, int int32) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal SyncAdapterType() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getSettingsActivity
				/// </java-name>
				public string SettingsActivity
				{
				[Dot42.DexImport("getSettingsActivity", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetSettingsActivity(); }
				}

		}

		/// <java-name>
		/// android/content/ContextWrapper
		/// </java-name>
		[Dot42.DexImport("android/content/ContextWrapper", AccessFlags = 33)]
		public partial class ContextWrapper : global::Android.Content.Context
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public ContextWrapper(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// attachBaseContext
				/// </java-name>
				[Dot42.DexImport("attachBaseContext", "(Landroid/content/Context;)V", AccessFlags = 4)]
				protected internal virtual void AttachBaseContext(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getBaseContext
				/// </java-name>
				[Dot42.DexImport("getBaseContext", "()Landroid/content/Context;", AccessFlags = 1)]
				public virtual global::Android.Content.Context GetBaseContext() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Context);
				}

				/// <java-name>
				/// getAssets
				/// </java-name>
				[Dot42.DexImport("getAssets", "()Landroid/content/res/AssetManager;", AccessFlags = 1)]
				public override global::Android.Content.Res.AssetManager GetAssets() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Res.AssetManager);
				}

				/// <java-name>
				/// getResources
				/// </java-name>
				[Dot42.DexImport("getResources", "()Landroid/content/res/Resources;", AccessFlags = 1)]
				public override global::Android.Content.Res.Resources GetResources() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Res.Resources);
				}

				/// <java-name>
				/// getPackageManager
				/// </java-name>
				[Dot42.DexImport("getPackageManager", "()Landroid/content/pm/PackageManager;", AccessFlags = 1)]
				public override global::Android.Content.Pm.PackageManager GetPackageManager() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Pm.PackageManager);
				}

				/// <java-name>
				/// getContentResolver
				/// </java-name>
				[Dot42.DexImport("getContentResolver", "()Landroid/content/ContentResolver;", AccessFlags = 1)]
				public override global::Android.Content.ContentResolver GetContentResolver() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.ContentResolver);
				}

				/// <java-name>
				/// getMainLooper
				/// </java-name>
				[Dot42.DexImport("getMainLooper", "()Landroid/os/Looper;", AccessFlags = 1)]
				public override global::Android.Os.Looper GetMainLooper() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Os.Looper);
				}

				/// <java-name>
				/// getApplicationContext
				/// </java-name>
				[Dot42.DexImport("getApplicationContext", "()Landroid/content/Context;", AccessFlags = 1)]
				public override global::Android.Content.Context GetApplicationContext() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Context);
				}

				/// <java-name>
				/// setTheme
				/// </java-name>
				[Dot42.DexImport("setTheme", "(I)V", AccessFlags = 1)]
				public override void SetTheme(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getTheme
				/// </java-name>
				[Dot42.DexImport("getTheme", "()Landroid/content/res/Resources$Theme;", AccessFlags = 1)]
				public override global::Android.Content.Res.Resources.Theme GetTheme() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Res.Resources.Theme);
				}

				/// <java-name>
				/// getClassLoader
				/// </java-name>
				[Dot42.DexImport("getClassLoader", "()Ljava/lang/ClassLoader;", AccessFlags = 1)]
				public override global::Java.Lang.ClassLoader GetClassLoader() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ClassLoader);
				}

				/// <java-name>
				/// getPackageName
				/// </java-name>
				[Dot42.DexImport("getPackageName", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string GetPackageName() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getApplicationInfo
				/// </java-name>
				[Dot42.DexImport("getApplicationInfo", "()Landroid/content/pm/ApplicationInfo;", AccessFlags = 1)]
				public override global::Android.Content.Pm.ApplicationInfo GetApplicationInfo() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Pm.ApplicationInfo);
				}

				/// <java-name>
				/// getPackageResourcePath
				/// </java-name>
				[Dot42.DexImport("getPackageResourcePath", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string GetPackageResourcePath() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getPackageCodePath
				/// </java-name>
				[Dot42.DexImport("getPackageCodePath", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string GetPackageCodePath() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getSharedPreferences
				/// </java-name>
				[Dot42.DexImport("getSharedPreferences", "(Ljava/lang/String;I)Landroid/content/SharedPreferences;", AccessFlags = 1)]
				public override global::Android.Content.ISharedPreferences GetSharedPreferences(string @string, int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.ISharedPreferences);
				}

				/// <java-name>
				/// openFileInput
				/// </java-name>
				[Dot42.DexImport("openFileInput", "(Ljava/lang/String;)Ljava/io/FileInputStream;", AccessFlags = 1)]
				public override global::Java.Io.FileInputStream OpenFileInput(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.FileInputStream);
				}

				/// <java-name>
				/// openFileOutput
				/// </java-name>
				[Dot42.DexImport("openFileOutput", "(Ljava/lang/String;I)Ljava/io/FileOutputStream;", AccessFlags = 1)]
				public override global::Java.Io.FileOutputStream OpenFileOutput(string @string, int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.FileOutputStream);
				}

				/// <java-name>
				/// deleteFile
				/// </java-name>
				[Dot42.DexImport("deleteFile", "(Ljava/lang/String;)Z", AccessFlags = 1)]
				public override bool DeleteFile(string @string) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getFileStreamPath
				/// </java-name>
				[Dot42.DexImport("getFileStreamPath", "(Ljava/lang/String;)Ljava/io/File;", AccessFlags = 1)]
				public override global::Java.Io.File GetFileStreamPath(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.File);
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
				/// getFilesDir
				/// </java-name>
				[Dot42.DexImport("getFilesDir", "()Ljava/io/File;", AccessFlags = 1)]
				public override global::Java.Io.File GetFilesDir() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.File);
				}

				/// <java-name>
				/// getExternalFilesDir
				/// </java-name>
				[Dot42.DexImport("getExternalFilesDir", "(Ljava/lang/String;)Ljava/io/File;", AccessFlags = 1)]
				public override global::Java.Io.File GetExternalFilesDir(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.File);
				}

				/// <java-name>
				/// getObbDir
				/// </java-name>
				[Dot42.DexImport("getObbDir", "()Ljava/io/File;", AccessFlags = 1)]
				public override global::Java.Io.File GetObbDir() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.File);
				}

				/// <java-name>
				/// getCacheDir
				/// </java-name>
				[Dot42.DexImport("getCacheDir", "()Ljava/io/File;", AccessFlags = 1)]
				public override global::Java.Io.File GetCacheDir() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.File);
				}

				/// <java-name>
				/// getExternalCacheDir
				/// </java-name>
				[Dot42.DexImport("getExternalCacheDir", "()Ljava/io/File;", AccessFlags = 1)]
				public override global::Java.Io.File GetExternalCacheDir() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.File);
				}

				/// <java-name>
				/// getDir
				/// </java-name>
				[Dot42.DexImport("getDir", "(Ljava/lang/String;I)Ljava/io/File;", AccessFlags = 1)]
				public override global::Java.Io.File GetDir(string @string, int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.File);
				}

				/// <java-name>
				/// openOrCreateDatabase
				/// </java-name>
				[Dot42.DexImport("openOrCreateDatabase", "(Ljava/lang/String;ILandroid/database/sqlite/SQLiteDatabase$CursorFactory;)Landro" +
    "id/database/sqlite/SQLiteDatabase;", AccessFlags = 1)]
				public override global::Android.Database.Sqlite.SQLiteDatabase OpenOrCreateDatabase(string @string, int int32, global::Android.Database.Sqlite.SQLiteDatabase.ICursorFactory cursorFactory) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Database.Sqlite.SQLiteDatabase);
				}

				/// <java-name>
				/// openOrCreateDatabase
				/// </java-name>
				[Dot42.DexImport("openOrCreateDatabase", "(Ljava/lang/String;ILandroid/database/sqlite/SQLiteDatabase$CursorFactory;Landroi" +
    "d/database/DatabaseErrorHandler;)Landroid/database/sqlite/SQLiteDatabase;", AccessFlags = 1)]
				public override global::Android.Database.Sqlite.SQLiteDatabase OpenOrCreateDatabase(string @string, int int32, global::Android.Database.Sqlite.SQLiteDatabase.ICursorFactory cursorFactory, global::Android.Database.IDatabaseErrorHandler databaseErrorHandler) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Database.Sqlite.SQLiteDatabase);
				}

				/// <java-name>
				/// deleteDatabase
				/// </java-name>
				[Dot42.DexImport("deleteDatabase", "(Ljava/lang/String;)Z", AccessFlags = 1)]
				public override bool DeleteDatabase(string @string) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getDatabasePath
				/// </java-name>
				[Dot42.DexImport("getDatabasePath", "(Ljava/lang/String;)Ljava/io/File;", AccessFlags = 1)]
				public override global::Java.Io.File GetDatabasePath(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.File);
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
				/// getWallpaper
				/// </java-name>
				[Dot42.DexImport("getWallpaper", "()Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
				public override global::Android.Graphics.Drawable.Drawable GetWallpaper() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawable.Drawable);
				}

				/// <java-name>
				/// peekWallpaper
				/// </java-name>
				[Dot42.DexImport("peekWallpaper", "()Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
				public override global::Android.Graphics.Drawable.Drawable PeekWallpaper() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawable.Drawable);
				}

				/// <java-name>
				/// getWallpaperDesiredMinimumWidth
				/// </java-name>
				[Dot42.DexImport("getWallpaperDesiredMinimumWidth", "()I", AccessFlags = 1)]
				public override int GetWallpaperDesiredMinimumWidth() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getWallpaperDesiredMinimumHeight
				/// </java-name>
				[Dot42.DexImport("getWallpaperDesiredMinimumHeight", "()I", AccessFlags = 1)]
				public override int GetWallpaperDesiredMinimumHeight() /* MethodBuilder.Create */ 
				{
						return default(int);
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
				public override void SetWallpaper(global::Java.Io.InputStream inputStream) /* MethodBuilder.Create */ 
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
				public override void SendBroadcast(global::Android.Content.Intent intent, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// sendOrderedBroadcast
				/// </java-name>
				[Dot42.DexImport("sendOrderedBroadcast", "(Landroid/content/Intent;Ljava/lang/String;)V", AccessFlags = 1)]
				public override void SendOrderedBroadcast(global::Android.Content.Intent intent, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// sendOrderedBroadcast
				/// </java-name>
				[Dot42.DexImport("sendOrderedBroadcast", "(Landroid/content/Intent;Ljava/lang/String;Landroid/content/BroadcastReceiver;Lan" +
    "droid/os/Handler;ILjava/lang/String;Landroid/os/Bundle;)V", AccessFlags = 1)]
				public override void SendOrderedBroadcast(global::Android.Content.Intent intent, string @string, global::Android.Content.BroadcastReceiver broadcastReceiver, global::Android.Os.Handler handler, int int32, string string1, global::Android.Os.Bundle bundle) /* MethodBuilder.Create */ 
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
				public override void SendStickyOrderedBroadcast(global::Android.Content.Intent intent, global::Android.Content.BroadcastReceiver broadcastReceiver, global::Android.Os.Handler handler, int int32, string @string, global::Android.Os.Bundle bundle) /* MethodBuilder.Create */ 
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
				public override global::Android.Content.Intent RegisterReceiver(global::Android.Content.BroadcastReceiver broadcastReceiver, global::Android.Content.IntentFilter intentFilter) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Intent);
				}

				/// <java-name>
				/// registerReceiver
				/// </java-name>
				[Dot42.DexImport("registerReceiver", "(Landroid/content/BroadcastReceiver;Landroid/content/IntentFilter;Ljava/lang/Stri" +
    "ng;Landroid/os/Handler;)Landroid/content/Intent;", AccessFlags = 1)]
				public override global::Android.Content.Intent RegisterReceiver(global::Android.Content.BroadcastReceiver broadcastReceiver, global::Android.Content.IntentFilter intentFilter, string @string, global::Android.Os.Handler handler) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Intent);
				}

				/// <java-name>
				/// unregisterReceiver
				/// </java-name>
				[Dot42.DexImport("unregisterReceiver", "(Landroid/content/BroadcastReceiver;)V", AccessFlags = 1)]
				public override void UnregisterReceiver(global::Android.Content.BroadcastReceiver broadcastReceiver) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// startService
				/// </java-name>
				[Dot42.DexImport("startService", "(Landroid/content/Intent;)Landroid/content/ComponentName;", AccessFlags = 1)]
				public override global::Android.Content.ComponentName StartService(global::Android.Content.Intent intent) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.ComponentName);
				}

				/// <java-name>
				/// stopService
				/// </java-name>
				[Dot42.DexImport("stopService", "(Landroid/content/Intent;)Z", AccessFlags = 1)]
				public override bool StopService(global::Android.Content.Intent intent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// bindService
				/// </java-name>
				[Dot42.DexImport("bindService", "(Landroid/content/Intent;Landroid/content/ServiceConnection;I)Z", AccessFlags = 1)]
				public override bool BindService(global::Android.Content.Intent intent, global::Android.Content.IServiceConnection serviceConnection, int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// unbindService
				/// </java-name>
				[Dot42.DexImport("unbindService", "(Landroid/content/ServiceConnection;)V", AccessFlags = 1)]
				public override void UnbindService(global::Android.Content.IServiceConnection serviceConnection) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// startInstrumentation
				/// </java-name>
				[Dot42.DexImport("startInstrumentation", "(Landroid/content/ComponentName;Ljava/lang/String;Landroid/os/Bundle;)Z", AccessFlags = 1)]
				public override bool StartInstrumentation(global::Android.Content.ComponentName componentName, string @string, global::Android.Os.Bundle bundle) /* MethodBuilder.Create */ 
				{
						return default(bool);
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
				/// checkPermission
				/// </java-name>
				[Dot42.DexImport("checkPermission", "(Ljava/lang/String;II)I", AccessFlags = 1)]
				public override int CheckPermission(string @string, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// checkCallingPermission
				/// </java-name>
				[Dot42.DexImport("checkCallingPermission", "(Ljava/lang/String;)I", AccessFlags = 1)]
				public override int CheckCallingPermission(string @string) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// checkCallingOrSelfPermission
				/// </java-name>
				[Dot42.DexImport("checkCallingOrSelfPermission", "(Ljava/lang/String;)I", AccessFlags = 1)]
				public override int CheckCallingOrSelfPermission(string @string) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// enforcePermission
				/// </java-name>
				[Dot42.DexImport("enforcePermission", "(Ljava/lang/String;IILjava/lang/String;)V", AccessFlags = 1)]
				public override void EnforcePermission(string @string, int int32, int int321, string string1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// enforceCallingPermission
				/// </java-name>
				[Dot42.DexImport("enforceCallingPermission", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public override void EnforceCallingPermission(string @string, string string1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// enforceCallingOrSelfPermission
				/// </java-name>
				[Dot42.DexImport("enforceCallingOrSelfPermission", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public override void EnforceCallingOrSelfPermission(string @string, string string1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// grantUriPermission
				/// </java-name>
				[Dot42.DexImport("grantUriPermission", "(Ljava/lang/String;Landroid/net/Uri;I)V", AccessFlags = 1)]
				public override void GrantUriPermission(string @string, global::Android.Net.Uri uri, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// revokeUriPermission
				/// </java-name>
				[Dot42.DexImport("revokeUriPermission", "(Landroid/net/Uri;I)V", AccessFlags = 1)]
				public override void RevokeUriPermission(global::Android.Net.Uri uri, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// checkUriPermission
				/// </java-name>
				[Dot42.DexImport("checkUriPermission", "(Landroid/net/Uri;III)I", AccessFlags = 1)]
				public override int CheckUriPermission(global::Android.Net.Uri uri, int int32, int int321, int int322) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// checkCallingUriPermission
				/// </java-name>
				[Dot42.DexImport("checkCallingUriPermission", "(Landroid/net/Uri;I)I", AccessFlags = 1)]
				public override int CheckCallingUriPermission(global::Android.Net.Uri uri, int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// checkCallingOrSelfUriPermission
				/// </java-name>
				[Dot42.DexImport("checkCallingOrSelfUriPermission", "(Landroid/net/Uri;I)I", AccessFlags = 1)]
				public override int CheckCallingOrSelfUriPermission(global::Android.Net.Uri uri, int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// checkUriPermission
				/// </java-name>
				[Dot42.DexImport("checkUriPermission", "(Landroid/net/Uri;Ljava/lang/String;Ljava/lang/String;III)I", AccessFlags = 1)]
				public override int CheckUriPermission(global::Android.Net.Uri uri, string @string, string string1, int int32, int int321, int int322) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// enforceUriPermission
				/// </java-name>
				[Dot42.DexImport("enforceUriPermission", "(Landroid/net/Uri;IIILjava/lang/String;)V", AccessFlags = 1)]
				public override void EnforceUriPermission(global::Android.Net.Uri uri, int int32, int int321, int int322, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// enforceCallingUriPermission
				/// </java-name>
				[Dot42.DexImport("enforceCallingUriPermission", "(Landroid/net/Uri;ILjava/lang/String;)V", AccessFlags = 1)]
				public override void EnforceCallingUriPermission(global::Android.Net.Uri uri, int int32, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// enforceCallingOrSelfUriPermission
				/// </java-name>
				[Dot42.DexImport("enforceCallingOrSelfUriPermission", "(Landroid/net/Uri;ILjava/lang/String;)V", AccessFlags = 1)]
				public override void EnforceCallingOrSelfUriPermission(global::Android.Net.Uri uri, int int32, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// enforceUriPermission
				/// </java-name>
				[Dot42.DexImport("enforceUriPermission", "(Landroid/net/Uri;Ljava/lang/String;Ljava/lang/String;IIILjava/lang/String;)V", AccessFlags = 1)]
				public override void EnforceUriPermission(global::Android.Net.Uri uri, string @string, string string1, int int32, int int321, int int322, string string2) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// createPackageContext
				/// </java-name>
				[Dot42.DexImport("createPackageContext", "(Ljava/lang/String;I)Landroid/content/Context;", AccessFlags = 1)]
				public override global::Android.Content.Context CreatePackageContext(string @string, int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Context);
				}

				/// <java-name>
				/// isRestricted
				/// </java-name>
				[Dot42.DexImport("isRestricted", "()Z", AccessFlags = 1)]
				public override bool IsRestricted() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ContextWrapper() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getBaseContext
				/// </java-name>
				public global::Android.Content.Context BaseContext
				{
				[Dot42.DexImport("getBaseContext", "()Landroid/content/Context;", AccessFlags = 1)]
						get{ return GetBaseContext(); }
				}

				/// <java-name>
				/// getAssets
				/// </java-name>
				public global::Android.Content.Res.AssetManager Assets
				{
				[Dot42.DexImport("getAssets", "()Landroid/content/res/AssetManager;", AccessFlags = 1)]
						get{ return GetAssets(); }
				}

				/// <java-name>
				/// getResources
				/// </java-name>
				public global::Android.Content.Res.Resources Resources
				{
				[Dot42.DexImport("getResources", "()Landroid/content/res/Resources;", AccessFlags = 1)]
						get{ return GetResources(); }
				}

				/// <java-name>
				/// getPackageManager
				/// </java-name>
				public global::Android.Content.Pm.PackageManager PackageManager
				{
				[Dot42.DexImport("getPackageManager", "()Landroid/content/pm/PackageManager;", AccessFlags = 1)]
						get{ return GetPackageManager(); }
				}

				/// <java-name>
				/// getContentResolver
				/// </java-name>
				public global::Android.Content.ContentResolver ContentResolver
				{
				[Dot42.DexImport("getContentResolver", "()Landroid/content/ContentResolver;", AccessFlags = 1)]
						get{ return GetContentResolver(); }
				}

				/// <java-name>
				/// getMainLooper
				/// </java-name>
				public global::Android.Os.Looper MainLooper
				{
				[Dot42.DexImport("getMainLooper", "()Landroid/os/Looper;", AccessFlags = 1)]
						get{ return GetMainLooper(); }
				}

				/// <java-name>
				/// getApplicationContext
				/// </java-name>
				public global::Android.Content.Context ApplicationContext
				{
				[Dot42.DexImport("getApplicationContext", "()Landroid/content/Context;", AccessFlags = 1)]
						get{ return GetApplicationContext(); }
				}

				/// <java-name>
				/// getTheme
				/// </java-name>
				public global::Android.Content.Res.Resources.Theme Theme
				{
				[Dot42.DexImport("getTheme", "()Landroid/content/res/Resources$Theme;", AccessFlags = 1)]
						get{ return GetTheme(); }
				}

				/// <java-name>
				/// getClassLoader
				/// </java-name>
				public global::Java.Lang.ClassLoader ClassLoader
				{
				[Dot42.DexImport("getClassLoader", "()Ljava/lang/ClassLoader;", AccessFlags = 1)]
						get{ return GetClassLoader(); }
				}

				/// <java-name>
				/// getPackageName
				/// </java-name>
				public string PackageName
				{
				[Dot42.DexImport("getPackageName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetPackageName(); }
				}

				/// <java-name>
				/// getApplicationInfo
				/// </java-name>
				public global::Android.Content.Pm.ApplicationInfo ApplicationInfo
				{
				[Dot42.DexImport("getApplicationInfo", "()Landroid/content/pm/ApplicationInfo;", AccessFlags = 1)]
						get{ return GetApplicationInfo(); }
				}

				/// <java-name>
				/// getPackageResourcePath
				/// </java-name>
				public string PackageResourcePath
				{
				[Dot42.DexImport("getPackageResourcePath", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetPackageResourcePath(); }
				}

				/// <java-name>
				/// getPackageCodePath
				/// </java-name>
				public string PackageCodePath
				{
				[Dot42.DexImport("getPackageCodePath", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetPackageCodePath(); }
				}

				/// <java-name>
				/// getFilesDir
				/// </java-name>
				public global::Java.Io.File FilesDir
				{
				[Dot42.DexImport("getFilesDir", "()Ljava/io/File;", AccessFlags = 1)]
						get{ return GetFilesDir(); }
				}

				/// <java-name>
				/// getObbDir
				/// </java-name>
				public global::Java.Io.File ObbDir
				{
				[Dot42.DexImport("getObbDir", "()Ljava/io/File;", AccessFlags = 1)]
						get{ return GetObbDir(); }
				}

				/// <java-name>
				/// getCacheDir
				/// </java-name>
				public global::Java.Io.File CacheDir
				{
				[Dot42.DexImport("getCacheDir", "()Ljava/io/File;", AccessFlags = 1)]
						get{ return GetCacheDir(); }
				}

				/// <java-name>
				/// getExternalCacheDir
				/// </java-name>
				public global::Java.Io.File ExternalCacheDir
				{
				[Dot42.DexImport("getExternalCacheDir", "()Ljava/io/File;", AccessFlags = 1)]
						get{ return GetExternalCacheDir(); }
				}

				/// <java-name>
				/// getWallpaper
				/// </java-name>
				public global::Android.Graphics.Drawable.Drawable Wallpaper
				{
				[Dot42.DexImport("getWallpaper", "()Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
						get{ return GetWallpaper(); }
				}

				/// <java-name>
				/// getWallpaperDesiredMinimumWidth
				/// </java-name>
				public int WallpaperDesiredMinimumWidth
				{
				[Dot42.DexImport("getWallpaperDesiredMinimumWidth", "()I", AccessFlags = 1)]
						get{ return GetWallpaperDesiredMinimumWidth(); }
				}

				/// <java-name>
				/// getWallpaperDesiredMinimumHeight
				/// </java-name>
				public int WallpaperDesiredMinimumHeight
				{
				[Dot42.DexImport("getWallpaperDesiredMinimumHeight", "()I", AccessFlags = 1)]
						get{ return GetWallpaperDesiredMinimumHeight(); }
				}

		}

		/// <java-name>
		/// android/content/ClipDescription
		/// </java-name>
		[Dot42.DexImport("android/content/ClipDescription", AccessFlags = 33)]
		public partial class ClipDescription : global::Android.Os.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// MIMETYPE_TEXT_PLAIN
				/// </java-name>
				[Dot42.DexImport("MIMETYPE_TEXT_PLAIN", "Ljava/lang/String;", AccessFlags = 25)]
				public const string MIMETYPE_TEXT_PLAIN = "text/plain";
				/// <java-name>
				/// MIMETYPE_TEXT_URILIST
				/// </java-name>
				[Dot42.DexImport("MIMETYPE_TEXT_URILIST", "Ljava/lang/String;", AccessFlags = 25)]
				public const string MIMETYPE_TEXT_URILIST = "text/uri-list";
				/// <java-name>
				/// MIMETYPE_TEXT_INTENT
				/// </java-name>
				[Dot42.DexImport("MIMETYPE_TEXT_INTENT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string MIMETYPE_TEXT_INTENT = "text/vnd.android.intent";
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.Os.IParcelable_ICreator<global::Android.Content.ClipDescription> CREATOR;
				[Dot42.DexImport("<init>", "(Ljava/lang/CharSequence;[Ljava/lang/String;)V", AccessFlags = 1)]
				public ClipDescription(global::Java.Lang.ICharSequence charSequence, string[] @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/ClipDescription;)V", AccessFlags = 1)]
				public ClipDescription(global::Android.Content.ClipDescription clipDescription) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// compareMimeTypes
				/// </java-name>
				[Dot42.DexImport("compareMimeTypes", "(Ljava/lang/String;Ljava/lang/String;)Z", AccessFlags = 9)]
				public static bool CompareMimeTypes(string @string, string string1) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getLabel
				/// </java-name>
				[Dot42.DexImport("getLabel", "()Ljava/lang/CharSequence;", AccessFlags = 1)]
				public virtual global::Java.Lang.ICharSequence GetLabel() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <java-name>
				/// hasMimeType
				/// </java-name>
				[Dot42.DexImport("hasMimeType", "(Ljava/lang/String;)Z", AccessFlags = 1)]
				public virtual bool HasMimeType(string @string) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// filterMimeTypes
				/// </java-name>
				[Dot42.DexImport("filterMimeTypes", "(Ljava/lang/String;)[Ljava/lang/String;", AccessFlags = 1)]
				public virtual string[] FilterMimeTypes(string @string) /* MethodBuilder.Create */ 
				{
						return default(string[]);
				}

				/// <java-name>
				/// getMimeTypeCount
				/// </java-name>
				[Dot42.DexImport("getMimeTypeCount", "()I", AccessFlags = 1)]
				public virtual int GetMimeTypeCount() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getMimeType
				/// </java-name>
				[Dot42.DexImport("getMimeType", "(I)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetMimeType(int int32) /* MethodBuilder.Create */ 
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
				public virtual void WriteToParcel(global::Android.Os.Parcel parcel, int int32) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ClipDescription() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getLabel
				/// </java-name>
				public global::Java.Lang.ICharSequence Label
				{
				[Dot42.DexImport("getLabel", "()Ljava/lang/CharSequence;", AccessFlags = 1)]
						get{ return GetLabel(); }
				}

				/// <java-name>
				/// getMimeTypeCount
				/// </java-name>
				public int MimeTypeCount
				{
				[Dot42.DexImport("getMimeTypeCount", "()I", AccessFlags = 1)]
						get{ return GetMimeTypeCount(); }
				}

		}

		/// <java-name>
		/// android/content/IntentFilter
		/// </java-name>
		[Dot42.DexImport("android/content/IntentFilter", AccessFlags = 33)]
		public partial class IntentFilter : global::Android.Os.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// SYSTEM_HIGH_PRIORITY
				/// </java-name>
				[Dot42.DexImport("SYSTEM_HIGH_PRIORITY", "I", AccessFlags = 25)]
				public const int SYSTEM_HIGH_PRIORITY = 1000;
				/// <java-name>
				/// SYSTEM_LOW_PRIORITY
				/// </java-name>
				[Dot42.DexImport("SYSTEM_LOW_PRIORITY", "I", AccessFlags = 25)]
				public const int SYSTEM_LOW_PRIORITY = -1000;
				/// <java-name>
				/// MATCH_CATEGORY_MASK
				/// </java-name>
				[Dot42.DexImport("MATCH_CATEGORY_MASK", "I", AccessFlags = 25)]
				public const int MATCH_CATEGORY_MASK = 268369920;
				/// <java-name>
				/// MATCH_ADJUSTMENT_MASK
				/// </java-name>
				[Dot42.DexImport("MATCH_ADJUSTMENT_MASK", "I", AccessFlags = 25)]
				public const int MATCH_ADJUSTMENT_MASK = 65535;
				/// <java-name>
				/// MATCH_ADJUSTMENT_NORMAL
				/// </java-name>
				[Dot42.DexImport("MATCH_ADJUSTMENT_NORMAL", "I", AccessFlags = 25)]
				public const int MATCH_ADJUSTMENT_NORMAL = 32768;
				/// <java-name>
				/// MATCH_CATEGORY_EMPTY
				/// </java-name>
				[Dot42.DexImport("MATCH_CATEGORY_EMPTY", "I", AccessFlags = 25)]
				public const int MATCH_CATEGORY_EMPTY = 1048576;
				/// <java-name>
				/// MATCH_CATEGORY_SCHEME
				/// </java-name>
				[Dot42.DexImport("MATCH_CATEGORY_SCHEME", "I", AccessFlags = 25)]
				public const int MATCH_CATEGORY_SCHEME = 2097152;
				/// <java-name>
				/// MATCH_CATEGORY_HOST
				/// </java-name>
				[Dot42.DexImport("MATCH_CATEGORY_HOST", "I", AccessFlags = 25)]
				public const int MATCH_CATEGORY_HOST = 3145728;
				/// <java-name>
				/// MATCH_CATEGORY_PORT
				/// </java-name>
				[Dot42.DexImport("MATCH_CATEGORY_PORT", "I", AccessFlags = 25)]
				public const int MATCH_CATEGORY_PORT = 4194304;
				/// <java-name>
				/// MATCH_CATEGORY_PATH
				/// </java-name>
				[Dot42.DexImport("MATCH_CATEGORY_PATH", "I", AccessFlags = 25)]
				public const int MATCH_CATEGORY_PATH = 5242880;
				/// <java-name>
				/// MATCH_CATEGORY_TYPE
				/// </java-name>
				[Dot42.DexImport("MATCH_CATEGORY_TYPE", "I", AccessFlags = 25)]
				public const int MATCH_CATEGORY_TYPE = 6291456;
				/// <java-name>
				/// NO_MATCH_TYPE
				/// </java-name>
				[Dot42.DexImport("NO_MATCH_TYPE", "I", AccessFlags = 25)]
				public const int NO_MATCH_TYPE = -1;
				/// <java-name>
				/// NO_MATCH_DATA
				/// </java-name>
				[Dot42.DexImport("NO_MATCH_DATA", "I", AccessFlags = 25)]
				public const int NO_MATCH_DATA = -2;
				/// <java-name>
				/// NO_MATCH_ACTION
				/// </java-name>
				[Dot42.DexImport("NO_MATCH_ACTION", "I", AccessFlags = 25)]
				public const int NO_MATCH_ACTION = -3;
				/// <java-name>
				/// NO_MATCH_CATEGORY
				/// </java-name>
				[Dot42.DexImport("NO_MATCH_CATEGORY", "I", AccessFlags = 25)]
				public const int NO_MATCH_CATEGORY = -4;
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.Os.IParcelable_ICreator<global::Android.Content.IntentFilter> CREATOR;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public IntentFilter() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public IntentFilter(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public IntentFilter(string @string, string string1) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/IntentFilter;)V", AccessFlags = 1)]
				public IntentFilter(global::Android.Content.IntentFilter intentFilter) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// create
				/// </java-name>
				[Dot42.DexImport("create", "(Ljava/lang/String;Ljava/lang/String;)Landroid/content/IntentFilter;", AccessFlags = 9)]
				public static global::Android.Content.IntentFilter Create(string @string, string string1) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.IntentFilter);
				}

				/// <java-name>
				/// setPriority
				/// </java-name>
				[Dot42.DexImport("setPriority", "(I)V", AccessFlags = 17)]
				public void SetPriority(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getPriority
				/// </java-name>
				[Dot42.DexImport("getPriority", "()I", AccessFlags = 17)]
				public int GetPriority() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// addAction
				/// </java-name>
				[Dot42.DexImport("addAction", "(Ljava/lang/String;)V", AccessFlags = 17)]
				public void AddAction(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// countActions
				/// </java-name>
				[Dot42.DexImport("countActions", "()I", AccessFlags = 17)]
				public int CountActions() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getAction
				/// </java-name>
				[Dot42.DexImport("getAction", "(I)Ljava/lang/String;", AccessFlags = 17)]
				public string GetAction(int int32) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// hasAction
				/// </java-name>
				[Dot42.DexImport("hasAction", "(Ljava/lang/String;)Z", AccessFlags = 17)]
				public bool HasAction(string @string) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// matchAction
				/// </java-name>
				[Dot42.DexImport("matchAction", "(Ljava/lang/String;)Z", AccessFlags = 17)]
				public bool MatchAction(string @string) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// actionsIterator
				/// </java-name>
				[Dot42.DexImport("actionsIterator", "()Ljava/util/Iterator;", AccessFlags = 17, Signature = "()Ljava/util/Iterator<Ljava/lang/String;>;")]
				public global::Java.Util.IIterator<string> ActionsIterator() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IIterator<string>);
				}

				/// <java-name>
				/// addDataType
				/// </java-name>
				[Dot42.DexImport("addDataType", "(Ljava/lang/String;)V", AccessFlags = 17)]
				public void AddDataType(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// hasDataType
				/// </java-name>
				[Dot42.DexImport("hasDataType", "(Ljava/lang/String;)Z", AccessFlags = 17)]
				public bool HasDataType(string @string) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// countDataTypes
				/// </java-name>
				[Dot42.DexImport("countDataTypes", "()I", AccessFlags = 17)]
				public int CountDataTypes() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getDataType
				/// </java-name>
				[Dot42.DexImport("getDataType", "(I)Ljava/lang/String;", AccessFlags = 17)]
				public string GetDataType(int int32) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// typesIterator
				/// </java-name>
				[Dot42.DexImport("typesIterator", "()Ljava/util/Iterator;", AccessFlags = 17, Signature = "()Ljava/util/Iterator<Ljava/lang/String;>;")]
				public global::Java.Util.IIterator<string> TypesIterator() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IIterator<string>);
				}

				/// <java-name>
				/// addDataScheme
				/// </java-name>
				[Dot42.DexImport("addDataScheme", "(Ljava/lang/String;)V", AccessFlags = 17)]
				public void AddDataScheme(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// countDataSchemes
				/// </java-name>
				[Dot42.DexImport("countDataSchemes", "()I", AccessFlags = 17)]
				public int CountDataSchemes() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getDataScheme
				/// </java-name>
				[Dot42.DexImport("getDataScheme", "(I)Ljava/lang/String;", AccessFlags = 17)]
				public string GetDataScheme(int int32) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// hasDataScheme
				/// </java-name>
				[Dot42.DexImport("hasDataScheme", "(Ljava/lang/String;)Z", AccessFlags = 17)]
				public bool HasDataScheme(string @string) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// schemesIterator
				/// </java-name>
				[Dot42.DexImport("schemesIterator", "()Ljava/util/Iterator;", AccessFlags = 17, Signature = "()Ljava/util/Iterator<Ljava/lang/String;>;")]
				public global::Java.Util.IIterator<string> SchemesIterator() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IIterator<string>);
				}

				/// <java-name>
				/// addDataAuthority
				/// </java-name>
				[Dot42.DexImport("addDataAuthority", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 17)]
				public void AddDataAuthority(string @string, string string1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// countDataAuthorities
				/// </java-name>
				[Dot42.DexImport("countDataAuthorities", "()I", AccessFlags = 17)]
				public int CountDataAuthorities() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getDataAuthority
				/// </java-name>
				[Dot42.DexImport("getDataAuthority", "(I)Landroid/content/IntentFilter$AuthorityEntry;", AccessFlags = 17)]
				public global::Android.Content.IntentFilter.AuthorityEntry GetDataAuthority(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.IntentFilter.AuthorityEntry);
				}

				/// <java-name>
				/// hasDataAuthority
				/// </java-name>
				[Dot42.DexImport("hasDataAuthority", "(Landroid/net/Uri;)Z", AccessFlags = 17)]
				public bool HasDataAuthority(global::Android.Net.Uri uri) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// authoritiesIterator
				/// </java-name>
				[Dot42.DexImport("authoritiesIterator", "()Ljava/util/Iterator;", AccessFlags = 17, Signature = "()Ljava/util/Iterator<Landroid/content/IntentFilter$AuthorityEntry;>;")]
				public global::Java.Util.IIterator<global::Android.Content.IntentFilter.AuthorityEntry> AuthoritiesIterator() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IIterator<global::Android.Content.IntentFilter.AuthorityEntry>);
				}

				/// <java-name>
				/// addDataPath
				/// </java-name>
				[Dot42.DexImport("addDataPath", "(Ljava/lang/String;I)V", AccessFlags = 17)]
				public void AddDataPath(string @string, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// countDataPaths
				/// </java-name>
				[Dot42.DexImport("countDataPaths", "()I", AccessFlags = 17)]
				public int CountDataPaths() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getDataPath
				/// </java-name>
				[Dot42.DexImport("getDataPath", "(I)Landroid/os/PatternMatcher;", AccessFlags = 17)]
				public global::Android.Os.PatternMatcher GetDataPath(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Os.PatternMatcher);
				}

				/// <java-name>
				/// hasDataPath
				/// </java-name>
				[Dot42.DexImport("hasDataPath", "(Ljava/lang/String;)Z", AccessFlags = 17)]
				public bool HasDataPath(string @string) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// pathsIterator
				/// </java-name>
				[Dot42.DexImport("pathsIterator", "()Ljava/util/Iterator;", AccessFlags = 17, Signature = "()Ljava/util/Iterator<Landroid/os/PatternMatcher;>;")]
				public global::Java.Util.IIterator<global::Android.Os.PatternMatcher> PathsIterator() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IIterator<global::Android.Os.PatternMatcher>);
				}

				/// <java-name>
				/// matchDataAuthority
				/// </java-name>
				[Dot42.DexImport("matchDataAuthority", "(Landroid/net/Uri;)I", AccessFlags = 17)]
				public int MatchDataAuthority(global::Android.Net.Uri uri) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// matchData
				/// </java-name>
				[Dot42.DexImport("matchData", "(Ljava/lang/String;Ljava/lang/String;Landroid/net/Uri;)I", AccessFlags = 17)]
				public int MatchData(string @string, string string1, global::Android.Net.Uri uri) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// addCategory
				/// </java-name>
				[Dot42.DexImport("addCategory", "(Ljava/lang/String;)V", AccessFlags = 17)]
				public void AddCategory(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// countCategories
				/// </java-name>
				[Dot42.DexImport("countCategories", "()I", AccessFlags = 17)]
				public int CountCategories() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getCategory
				/// </java-name>
				[Dot42.DexImport("getCategory", "(I)Ljava/lang/String;", AccessFlags = 17)]
				public string GetCategory(int int32) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// hasCategory
				/// </java-name>
				[Dot42.DexImport("hasCategory", "(Ljava/lang/String;)Z", AccessFlags = 17)]
				public bool HasCategory(string @string) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// categoriesIterator
				/// </java-name>
				[Dot42.DexImport("categoriesIterator", "()Ljava/util/Iterator;", AccessFlags = 17, Signature = "()Ljava/util/Iterator<Ljava/lang/String;>;")]
				public global::Java.Util.IIterator<string> CategoriesIterator() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IIterator<string>);
				}

				/// <java-name>
				/// matchCategories
				/// </java-name>
				[Dot42.DexImport("matchCategories", "(Ljava/util/Set;)Ljava/lang/String;", AccessFlags = 17, Signature = "(Ljava/util/Set<Ljava/lang/String;>;)Ljava/lang/String;")]
				public string MatchCategories(global::Java.Util.ISet<string> set) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// match
				/// </java-name>
				[Dot42.DexImport("match", "(Landroid/content/ContentResolver;Landroid/content/Intent;ZLjava/lang/String;)I", AccessFlags = 17)]
				public int Match(global::Android.Content.ContentResolver contentResolver, global::Android.Content.Intent intent, bool boolean, string @string) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// match
				/// </java-name>
				[Dot42.DexImport("match", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Landroid/net/Uri;Ljava/uti" +
    "l/Set;Ljava/lang/String;)I", AccessFlags = 17, Signature = "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Landroid/net/Uri;Ljava/uti" +
    "l/Set<Ljava/lang/String;>;Ljava/lang/String;)I")]
				public int Match(string @string, string string1, string string2, global::Android.Net.Uri uri, global::Java.Util.ISet<string> set, string string3) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// writeToXml
				/// </java-name>
				[Dot42.DexImport("writeToXml", "(Lorg/xmlpull/v1/XmlSerializer;)V", AccessFlags = 1)]
				public virtual void WriteToXml(global::Org.Xmlpull.V1.IXmlSerializer xmlSerializer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// readFromXml
				/// </java-name>
				[Dot42.DexImport("readFromXml", "(Lorg/xmlpull/v1/XmlPullParser;)V", AccessFlags = 1)]
				public virtual void ReadFromXml(global::Org.Xmlpull.V1.IXmlPullParser xmlPullParser) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// dump
				/// </java-name>
				[Dot42.DexImport("dump", "(Landroid/util/Printer;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void Dump(global::Android.Util.IPrinter printer, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// describeContents
				/// </java-name>
				[Dot42.DexImport("describeContents", "()I", AccessFlags = 17)]
				public int DescribeContents() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 17)]
				public void WriteToParcel(global::Android.Os.Parcel parcel, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getPriority
				/// </java-name>
				public int Priority
				{
				[Dot42.DexImport("getPriority", "()I", AccessFlags = 17)]
						get{ return GetPriority(); }
				[Dot42.DexImport("setPriority", "(I)V", AccessFlags = 17)]
						set{ SetPriority(value); }
				}

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

						/// <java-name>
						/// getHost
						/// </java-name>
						[Dot42.DexImport("getHost", "()Ljava/lang/String;", AccessFlags = 1)]
						public string GetHost() /* MethodBuilder.Create */ 
						{
								return default(string);
						}

						/// <java-name>
						/// getPort
						/// </java-name>
						[Dot42.DexImport("getPort", "()I", AccessFlags = 1)]
						public int GetPort() /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <java-name>
						/// match
						/// </java-name>
						[Dot42.DexImport("match", "(Landroid/net/Uri;)I", AccessFlags = 1)]
						public int Match(global::Android.Net.Uri uri) /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal AuthorityEntry() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

						/// <java-name>
						/// getHost
						/// </java-name>
						public string Host
						{
						[Dot42.DexImport("getHost", "()Ljava/lang/String;", AccessFlags = 1)]
								get{ return GetHost(); }
						}

						/// <java-name>
						/// getPort
						/// </java-name>
						public int Port
						{
						[Dot42.DexImport("getPort", "()I", AccessFlags = 1)]
								get{ return GetPort(); }
						}

				}

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

		/// <java-name>
		/// android/content/SharedPreferences
		/// </java-name>
		[Dot42.DexImport("android/content/SharedPreferences", AccessFlags = 1537)]
		public partial interface ISharedPreferences
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// getAll
				/// </java-name>
				[Dot42.DexImport("getAll", "()Ljava/util/Map;", AccessFlags = 1025, Signature = "()Ljava/util/Map<Ljava/lang/String;*>;")]
				global::Java.Util.IMap<string, object> GetAll() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getString
				/// </java-name>
				[Dot42.DexImport("getString", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1025)]
				string GetString(string @string, string string1) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getStringSet
				/// </java-name>
				[Dot42.DexImport("getStringSet", "(Ljava/lang/String;Ljava/util/Set;)Ljava/util/Set;", AccessFlags = 1025, Signature = "(Ljava/lang/String;Ljava/util/Set<Ljava/lang/String;>;)Ljava/util/Set<Ljava/lang/" +
    "String;>;")]
				global::Java.Util.ISet<string> GetStringSet(string @string, global::Java.Util.ISet<string> set) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getInt
				/// </java-name>
				[Dot42.DexImport("getInt", "(Ljava/lang/String;I)I", AccessFlags = 1025)]
				int GetInt(string @string, int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getLong
				/// </java-name>
				[Dot42.DexImport("getLong", "(Ljava/lang/String;J)J", AccessFlags = 1025)]
				long GetLong(string @string, long int64) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getFloat
				/// </java-name>
				[Dot42.DexImport("getFloat", "(Ljava/lang/String;F)F", AccessFlags = 1025)]
				float GetFloat(string @string, float single) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getBoolean
				/// </java-name>
				[Dot42.DexImport("getBoolean", "(Ljava/lang/String;Z)Z", AccessFlags = 1025)]
				bool GetBoolean(string @string, bool boolean) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// contains
				/// </java-name>
				[Dot42.DexImport("contains", "(Ljava/lang/String;)Z", AccessFlags = 1025)]
				bool Contains(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// edit
				/// </java-name>
				[Dot42.DexImport("edit", "()Landroid/content/SharedPreferences$Editor;", AccessFlags = 1025)]
				global::Android.Content.ISharedPreferences_IEditor Edit() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// registerOnSharedPreferenceChangeListener
				/// </java-name>
				[Dot42.DexImport("registerOnSharedPreferenceChangeListener", "(Landroid/content/SharedPreferences$OnSharedPreferenceChangeListener;)V", AccessFlags = 1025)]
				void RegisterOnSharedPreferenceChangeListener(global::Android.Content.ISharedPreferences_IOnSharedPreferenceChangeListener sharedPreferences_IOnSharedPreferenceChangeListener) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// unregisterOnSharedPreferenceChangeListener
				/// </java-name>
				[Dot42.DexImport("unregisterOnSharedPreferenceChangeListener", "(Landroid/content/SharedPreferences$OnSharedPreferenceChangeListener;)V", AccessFlags = 1025)]
				void UnregisterOnSharedPreferenceChangeListener(global::Android.Content.ISharedPreferences_IOnSharedPreferenceChangeListener sharedPreferences_IOnSharedPreferenceChangeListener) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// android/content/SharedPreferences$Editor
		/// </java-name>
		[Dot42.DexImport("android/content/SharedPreferences$Editor", AccessFlags = 1545)]
		public partial interface ISharedPreferences_IEditor
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// putString
				/// </java-name>
				[Dot42.DexImport("putString", "(Ljava/lang/String;Ljava/lang/String;)Landroid/content/SharedPreferences$Editor;", AccessFlags = 1025)]
				global::Android.Content.ISharedPreferences_IEditor PutString(string @string, string string1) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// putStringSet
				/// </java-name>
				[Dot42.DexImport("putStringSet", "(Ljava/lang/String;Ljava/util/Set;)Landroid/content/SharedPreferences$Editor;", AccessFlags = 1025, Signature = "(Ljava/lang/String;Ljava/util/Set<Ljava/lang/String;>;)Landroid/content/SharedPre" +
    "ferences$Editor;")]
				global::Android.Content.ISharedPreferences_IEditor PutStringSet(string @string, global::Java.Util.ISet<string> set) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// putInt
				/// </java-name>
				[Dot42.DexImport("putInt", "(Ljava/lang/String;I)Landroid/content/SharedPreferences$Editor;", AccessFlags = 1025)]
				global::Android.Content.ISharedPreferences_IEditor PutInt(string @string, int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// putLong
				/// </java-name>
				[Dot42.DexImport("putLong", "(Ljava/lang/String;J)Landroid/content/SharedPreferences$Editor;", AccessFlags = 1025)]
				global::Android.Content.ISharedPreferences_IEditor PutLong(string @string, long int64) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// putFloat
				/// </java-name>
				[Dot42.DexImport("putFloat", "(Ljava/lang/String;F)Landroid/content/SharedPreferences$Editor;", AccessFlags = 1025)]
				global::Android.Content.ISharedPreferences_IEditor PutFloat(string @string, float single) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// putBoolean
				/// </java-name>
				[Dot42.DexImport("putBoolean", "(Ljava/lang/String;Z)Landroid/content/SharedPreferences$Editor;", AccessFlags = 1025)]
				global::Android.Content.ISharedPreferences_IEditor PutBoolean(string @string, bool boolean) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// remove
				/// </java-name>
				[Dot42.DexImport("remove", "(Ljava/lang/String;)Landroid/content/SharedPreferences$Editor;", AccessFlags = 1025)]
				global::Android.Content.ISharedPreferences_IEditor Remove(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// clear
				/// </java-name>
				[Dot42.DexImport("clear", "()Landroid/content/SharedPreferences$Editor;", AccessFlags = 1025)]
				global::Android.Content.ISharedPreferences_IEditor Clear() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// commit
				/// </java-name>
				[Dot42.DexImport("commit", "()Z", AccessFlags = 1025)]
				bool Commit() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// apply
				/// </java-name>
				[Dot42.DexImport("apply", "()V", AccessFlags = 1025)]
				void Apply() /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// android/content/SharedPreferences$OnSharedPreferenceChangeListener
		/// </java-name>
		[Dot42.DexImport("android/content/SharedPreferences$OnSharedPreferenceChangeListener", AccessFlags = 1545)]
		public partial interface ISharedPreferences_IOnSharedPreferenceChangeListener
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// onSharedPreferenceChanged
				/// </java-name>
				[Dot42.DexImport("onSharedPreferenceChanged", "(Landroid/content/SharedPreferences;Ljava/lang/String;)V", AccessFlags = 1025)]
				void OnSharedPreferenceChanged(global::Android.Content.ISharedPreferences sharedPreferences, string @string) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// android/content/Entity
		/// </java-name>
		[Dot42.DexImport("android/content/Entity", AccessFlags = 49)]
		public sealed partial class Entity
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/ContentValues;)V", AccessFlags = 1)]
				public Entity(global::Android.Content.ContentValues contentValues) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getEntityValues
				/// </java-name>
				[Dot42.DexImport("getEntityValues", "()Landroid/content/ContentValues;", AccessFlags = 1)]
				public global::Android.Content.ContentValues GetEntityValues() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.ContentValues);
				}

				/// <java-name>
				/// getSubValues
				/// </java-name>
				[Dot42.DexImport("getSubValues", "()Ljava/util/ArrayList;", AccessFlags = 1, Signature = "()Ljava/util/ArrayList<Landroid/content/Entity$NamedContentValues;>;")]
				public global::Java.Util.ArrayList<global::Android.Content.Entity.NamedContentValues> GetSubValues() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ArrayList<global::Android.Content.Entity.NamedContentValues>);
				}

				/// <java-name>
				/// addSubValue
				/// </java-name>
				[Dot42.DexImport("addSubValue", "(Landroid/net/Uri;Landroid/content/ContentValues;)V", AccessFlags = 1)]
				public void AddSubValue(global::Android.Net.Uri uri, global::Android.Content.ContentValues contentValues) /* MethodBuilder.Create */ 
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
				internal Entity() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getEntityValues
				/// </java-name>
				public global::Android.Content.ContentValues EntityValues
				{
				[Dot42.DexImport("getEntityValues", "()Landroid/content/ContentValues;", AccessFlags = 1)]
						get{ return GetEntityValues(); }
				}

				/// <java-name>
				/// getSubValues
				/// </java-name>
				public global::Java.Util.ArrayList<global::Android.Content.Entity.NamedContentValues> SubValues
				{
				[Dot42.DexImport("getSubValues", "()Ljava/util/ArrayList;", AccessFlags = 1, Signature = "()Ljava/util/ArrayList<Landroid/content/Entity$NamedContentValues;>;")]
						get{ return GetSubValues(); }
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
						internal NamedContentValues() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

				}

		}

		/// <java-name>
		/// android/content/ContentQueryMap
		/// </java-name>
		[Dot42.DexImport("android/content/ContentQueryMap", AccessFlags = 33)]
		public partial class ContentQueryMap : global::Java.Util.Observable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/database/Cursor;Ljava/lang/String;ZLandroid/os/Handler;)V", AccessFlags = 1)]
				public ContentQueryMap(global::Android.Database.ICursor cursor, string @string, bool boolean, global::Android.Os.Handler handler) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setKeepUpdated
				/// </java-name>
				[Dot42.DexImport("setKeepUpdated", "(Z)V", AccessFlags = 1)]
				public virtual void SetKeepUpdated(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getValues
				/// </java-name>
				[Dot42.DexImport("getValues", "(Ljava/lang/String;)Landroid/content/ContentValues;", AccessFlags = 33)]
				public virtual global::Android.Content.ContentValues GetValues(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.ContentValues);
				}

				/// <java-name>
				/// requery
				/// </java-name>
				[Dot42.DexImport("requery", "()V", AccessFlags = 1)]
				public virtual void Requery() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getRows
				/// </java-name>
				[Dot42.DexImport("getRows", "()Ljava/util/Map;", AccessFlags = 33, Signature = "()Ljava/util/Map<Ljava/lang/String;Landroid/content/ContentValues;>;")]
				public virtual global::Java.Util.IMap<string, global::Android.Content.ContentValues> GetRows() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IMap<string, global::Android.Content.ContentValues>);
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
				internal ContentQueryMap() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getRows
				/// </java-name>
				public global::Java.Util.IMap<string, global::Android.Content.ContentValues> Rows
				{
				[Dot42.DexImport("getRows", "()Ljava/util/Map;", AccessFlags = 33, Signature = "()Ljava/util/Map<Ljava/lang/String;Landroid/content/ContentValues;>;")]
						get{ return GetRows(); }
				}

		}

		/// <java-name>
		/// android/content/AbstractThreadedSyncAdapter
		/// </java-name>
		[Dot42.DexImport("android/content/AbstractThreadedSyncAdapter", AccessFlags = 1057)]
		public abstract partial class AbstractThreadedSyncAdapter
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// LOG_SYNC_DETAILS
				/// </java-name>
				[Dot42.DexImport("LOG_SYNC_DETAILS", "I", AccessFlags = 25)]
				public const int LOG_SYNC_DETAILS = 2743;
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Z)V", AccessFlags = 1)]
				public AbstractThreadedSyncAdapter(global::Android.Content.Context context, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;ZZ)V", AccessFlags = 1)]
				public AbstractThreadedSyncAdapter(global::Android.Content.Context context, bool boolean, bool boolean1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getContext
				/// </java-name>
				[Dot42.DexImport("getContext", "()Landroid/content/Context;", AccessFlags = 1)]
				public virtual global::Android.Content.Context GetContext() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Context);
				}

				/// <java-name>
				/// getSyncAdapterBinder
				/// </java-name>
				[Dot42.DexImport("getSyncAdapterBinder", "()Landroid/os/IBinder;", AccessFlags = 17)]
				public global::Android.Os.IBinder GetSyncAdapterBinder() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Os.IBinder);
				}

				/// <java-name>
				/// onPerformSync
				/// </java-name>
				[Dot42.DexImport("onPerformSync", "(Landroid/accounts/Account;Landroid/os/Bundle;Ljava/lang/String;Landroid/content/" +
    "ContentProviderClient;Landroid/content/SyncResult;)V", AccessFlags = 1025)]
				public abstract void OnPerformSync(global::Android.Accounts.Account account, global::Android.Os.Bundle bundle, string @string, global::Android.Content.ContentProviderClient contentProviderClient, global::Android.Content.SyncResult syncResult) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// onSyncCanceled
				/// </java-name>
				[Dot42.DexImport("onSyncCanceled", "()V", AccessFlags = 1)]
				public virtual void OnSyncCanceled() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onSyncCanceled
				/// </java-name>
				[Dot42.DexImport("onSyncCanceled", "(Ljava/lang/Thread;)V", AccessFlags = 1)]
				public virtual void OnSyncCanceled(global::System.Threading.Thread thread) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal AbstractThreadedSyncAdapter() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getContext
				/// </java-name>
				public global::Android.Content.Context Context
				{
				[Dot42.DexImport("getContext", "()Landroid/content/Context;", AccessFlags = 1)]
						get{ return GetContext(); }
				}

				/// <java-name>
				/// getSyncAdapterBinder
				/// </java-name>
				public global::Android.Os.IBinder SyncAdapterBinder
				{
				[Dot42.DexImport("getSyncAdapterBinder", "()Landroid/os/IBinder;", AccessFlags = 17)]
						get{ return GetSyncAdapterBinder(); }
				}

		}

		/// <java-name>
		/// android/content/Context
		/// </java-name>
		[Dot42.DexImport("android/content/Context", AccessFlags = 1057)]
		public abstract partial class Context
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// MODE_PRIVATE
				/// </java-name>
				[Dot42.DexImport("MODE_PRIVATE", "I", AccessFlags = 25)]
				public const int MODE_PRIVATE = 0;
				/// <java-name>
				/// MODE_WORLD_READABLE
				/// </java-name>
				[Dot42.DexImport("MODE_WORLD_READABLE", "I", AccessFlags = 25)]
				public const int MODE_WORLD_READABLE = 1;
				/// <java-name>
				/// MODE_WORLD_WRITEABLE
				/// </java-name>
				[Dot42.DexImport("MODE_WORLD_WRITEABLE", "I", AccessFlags = 25)]
				public const int MODE_WORLD_WRITEABLE = 2;
				/// <java-name>
				/// MODE_APPEND
				/// </java-name>
				[Dot42.DexImport("MODE_APPEND", "I", AccessFlags = 25)]
				public const int MODE_APPEND = 32768;
				/// <java-name>
				/// MODE_MULTI_PROCESS
				/// </java-name>
				[Dot42.DexImport("MODE_MULTI_PROCESS", "I", AccessFlags = 25)]
				public const int MODE_MULTI_PROCESS = 4;
				/// <java-name>
				/// BIND_AUTO_CREATE
				/// </java-name>
				[Dot42.DexImport("BIND_AUTO_CREATE", "I", AccessFlags = 25)]
				public const int BIND_AUTO_CREATE = 1;
				/// <java-name>
				/// BIND_DEBUG_UNBIND
				/// </java-name>
				[Dot42.DexImport("BIND_DEBUG_UNBIND", "I", AccessFlags = 25)]
				public const int BIND_DEBUG_UNBIND = 2;
				/// <java-name>
				/// BIND_NOT_FOREGROUND
				/// </java-name>
				[Dot42.DexImport("BIND_NOT_FOREGROUND", "I", AccessFlags = 25)]
				public const int BIND_NOT_FOREGROUND = 4;
				/// <java-name>
				/// BIND_ABOVE_CLIENT
				/// </java-name>
				[Dot42.DexImport("BIND_ABOVE_CLIENT", "I", AccessFlags = 25)]
				public const int BIND_ABOVE_CLIENT = 8;
				/// <java-name>
				/// BIND_ALLOW_OOM_MANAGEMENT
				/// </java-name>
				[Dot42.DexImport("BIND_ALLOW_OOM_MANAGEMENT", "I", AccessFlags = 25)]
				public const int BIND_ALLOW_OOM_MANAGEMENT = 16;
				/// <java-name>
				/// BIND_WAIVE_PRIORITY
				/// </java-name>
				[Dot42.DexImport("BIND_WAIVE_PRIORITY", "I", AccessFlags = 25)]
				public const int BIND_WAIVE_PRIORITY = 32;
				/// <java-name>
				/// BIND_IMPORTANT
				/// </java-name>
				[Dot42.DexImport("BIND_IMPORTANT", "I", AccessFlags = 25)]
				public const int BIND_IMPORTANT = 64;
				/// <java-name>
				/// BIND_ADJUST_WITH_ACTIVITY
				/// </java-name>
				[Dot42.DexImport("BIND_ADJUST_WITH_ACTIVITY", "I", AccessFlags = 25)]
				public const int BIND_ADJUST_WITH_ACTIVITY = 128;
				/// <java-name>
				/// POWER_SERVICE
				/// </java-name>
				[Dot42.DexImport("POWER_SERVICE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string POWER_SERVICE = "power";
				/// <java-name>
				/// WINDOW_SERVICE
				/// </java-name>
				[Dot42.DexImport("WINDOW_SERVICE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string WINDOW_SERVICE = "window";
				/// <java-name>
				/// LAYOUT_INFLATER_SERVICE
				/// </java-name>
				[Dot42.DexImport("LAYOUT_INFLATER_SERVICE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string LAYOUT_INFLATER_SERVICE = "layout_inflater";
				/// <java-name>
				/// ACCOUNT_SERVICE
				/// </java-name>
				[Dot42.DexImport("ACCOUNT_SERVICE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACCOUNT_SERVICE = "account";
				/// <java-name>
				/// ACTIVITY_SERVICE
				/// </java-name>
				[Dot42.DexImport("ACTIVITY_SERVICE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTIVITY_SERVICE = "activity";
				/// <java-name>
				/// ALARM_SERVICE
				/// </java-name>
				[Dot42.DexImport("ALARM_SERVICE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ALARM_SERVICE = "alarm";
				/// <java-name>
				/// NOTIFICATION_SERVICE
				/// </java-name>
				[Dot42.DexImport("NOTIFICATION_SERVICE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string NOTIFICATION_SERVICE = "notification";
				/// <java-name>
				/// ACCESSIBILITY_SERVICE
				/// </java-name>
				[Dot42.DexImport("ACCESSIBILITY_SERVICE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACCESSIBILITY_SERVICE = "accessibility";
				/// <java-name>
				/// KEYGUARD_SERVICE
				/// </java-name>
				[Dot42.DexImport("KEYGUARD_SERVICE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string KEYGUARD_SERVICE = "keyguard";
				/// <java-name>
				/// LOCATION_SERVICE
				/// </java-name>
				[Dot42.DexImport("LOCATION_SERVICE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string LOCATION_SERVICE = "location";
				/// <java-name>
				/// SEARCH_SERVICE
				/// </java-name>
				[Dot42.DexImport("SEARCH_SERVICE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SEARCH_SERVICE = "search";
				/// <java-name>
				/// SENSOR_SERVICE
				/// </java-name>
				[Dot42.DexImport("SENSOR_SERVICE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SENSOR_SERVICE = "sensor";
				/// <java-name>
				/// STORAGE_SERVICE
				/// </java-name>
				[Dot42.DexImport("STORAGE_SERVICE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string STORAGE_SERVICE = "storage";
				/// <java-name>
				/// WALLPAPER_SERVICE
				/// </java-name>
				[Dot42.DexImport("WALLPAPER_SERVICE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string WALLPAPER_SERVICE = "wallpaper";
				/// <java-name>
				/// VIBRATOR_SERVICE
				/// </java-name>
				[Dot42.DexImport("VIBRATOR_SERVICE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string VIBRATOR_SERVICE = "vibrator";
				/// <java-name>
				/// CONNECTIVITY_SERVICE
				/// </java-name>
				[Dot42.DexImport("CONNECTIVITY_SERVICE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string CONNECTIVITY_SERVICE = "connectivity";
				/// <java-name>
				/// WIFI_SERVICE
				/// </java-name>
				[Dot42.DexImport("WIFI_SERVICE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string WIFI_SERVICE = "wifi";
				/// <java-name>
				/// WIFI_P2P_SERVICE
				/// </java-name>
				[Dot42.DexImport("WIFI_P2P_SERVICE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string WIFI_P2P_SERVICE = "wifip2p";
				/// <java-name>
				/// AUDIO_SERVICE
				/// </java-name>
				[Dot42.DexImport("AUDIO_SERVICE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string AUDIO_SERVICE = "audio";
				/// <java-name>
				/// TELEPHONY_SERVICE
				/// </java-name>
				[Dot42.DexImport("TELEPHONY_SERVICE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string TELEPHONY_SERVICE = "phone";
				/// <java-name>
				/// CLIPBOARD_SERVICE
				/// </java-name>
				[Dot42.DexImport("CLIPBOARD_SERVICE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string CLIPBOARD_SERVICE = "clipboard";
				/// <java-name>
				/// INPUT_METHOD_SERVICE
				/// </java-name>
				[Dot42.DexImport("INPUT_METHOD_SERVICE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string INPUT_METHOD_SERVICE = "input_method";
				/// <java-name>
				/// TEXT_SERVICES_MANAGER_SERVICE
				/// </java-name>
				[Dot42.DexImport("TEXT_SERVICES_MANAGER_SERVICE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string TEXT_SERVICES_MANAGER_SERVICE = "textservices";
				/// <java-name>
				/// DROPBOX_SERVICE
				/// </java-name>
				[Dot42.DexImport("DROPBOX_SERVICE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string DROPBOX_SERVICE = "dropbox";
				/// <java-name>
				/// DEVICE_POLICY_SERVICE
				/// </java-name>
				[Dot42.DexImport("DEVICE_POLICY_SERVICE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string DEVICE_POLICY_SERVICE = "device_policy";
				/// <java-name>
				/// UI_MODE_SERVICE
				/// </java-name>
				[Dot42.DexImport("UI_MODE_SERVICE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string UI_MODE_SERVICE = "uimode";
				/// <java-name>
				/// DOWNLOAD_SERVICE
				/// </java-name>
				[Dot42.DexImport("DOWNLOAD_SERVICE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string DOWNLOAD_SERVICE = "download";
				/// <java-name>
				/// NFC_SERVICE
				/// </java-name>
				[Dot42.DexImport("NFC_SERVICE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string NFC_SERVICE = "nfc";
				/// <java-name>
				/// USB_SERVICE
				/// </java-name>
				[Dot42.DexImport("USB_SERVICE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string USB_SERVICE = "usb";
				/// <java-name>
				/// CONTEXT_INCLUDE_CODE
				/// </java-name>
				[Dot42.DexImport("CONTEXT_INCLUDE_CODE", "I", AccessFlags = 25)]
				public const int CONTEXT_INCLUDE_CODE = 1;
				/// <java-name>
				/// CONTEXT_IGNORE_SECURITY
				/// </java-name>
				[Dot42.DexImport("CONTEXT_IGNORE_SECURITY", "I", AccessFlags = 25)]
				public const int CONTEXT_IGNORE_SECURITY = 2;
				/// <java-name>
				/// CONTEXT_RESTRICTED
				/// </java-name>
				[Dot42.DexImport("CONTEXT_RESTRICTED", "I", AccessFlags = 25)]
				public const int CONTEXT_RESTRICTED = 4;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Context() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getAssets
				/// </java-name>
				[Dot42.DexImport("getAssets", "()Landroid/content/res/AssetManager;", AccessFlags = 1025)]
				public abstract global::Android.Content.Res.AssetManager GetAssets() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getResources
				/// </java-name>
				[Dot42.DexImport("getResources", "()Landroid/content/res/Resources;", AccessFlags = 1025)]
				public abstract global::Android.Content.Res.Resources GetResources() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getPackageManager
				/// </java-name>
				[Dot42.DexImport("getPackageManager", "()Landroid/content/pm/PackageManager;", AccessFlags = 1025)]
				public abstract global::Android.Content.Pm.PackageManager GetPackageManager() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getContentResolver
				/// </java-name>
				[Dot42.DexImport("getContentResolver", "()Landroid/content/ContentResolver;", AccessFlags = 1025)]
				public abstract global::Android.Content.ContentResolver GetContentResolver() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getMainLooper
				/// </java-name>
				[Dot42.DexImport("getMainLooper", "()Landroid/os/Looper;", AccessFlags = 1025)]
				public abstract global::Android.Os.Looper GetMainLooper() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getApplicationContext
				/// </java-name>
				[Dot42.DexImport("getApplicationContext", "()Landroid/content/Context;", AccessFlags = 1025)]
				public abstract global::Android.Content.Context GetApplicationContext() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// registerComponentCallbacks
				/// </java-name>
				[Dot42.DexImport("registerComponentCallbacks", "(Landroid/content/ComponentCallbacks;)V", AccessFlags = 1)]
				public virtual void RegisterComponentCallbacks(global::Android.Content.IComponentCallbacks componentCallbacks) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// unregisterComponentCallbacks
				/// </java-name>
				[Dot42.DexImport("unregisterComponentCallbacks", "(Landroid/content/ComponentCallbacks;)V", AccessFlags = 1)]
				public virtual void UnregisterComponentCallbacks(global::Android.Content.IComponentCallbacks componentCallbacks) /* MethodBuilder.Create */ 
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
				/// setTheme
				/// </java-name>
				[Dot42.DexImport("setTheme", "(I)V", AccessFlags = 1025)]
				public abstract void SetTheme(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getTheme
				/// </java-name>
				[Dot42.DexImport("getTheme", "()Landroid/content/res/Resources$Theme;", AccessFlags = 1025)]
				public abstract global::Android.Content.Res.Resources.Theme GetTheme() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// obtainStyledAttributes
				/// </java-name>
				[Dot42.DexImport("obtainStyledAttributes", "([I)Landroid/content/res/TypedArray;", AccessFlags = 17)]
				public global::Android.Content.Res.TypedArray ObtainStyledAttributes(int[] int32) /* MethodBuilder.Create */ 
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

				/// <java-name>
				/// obtainStyledAttributes
				/// </java-name>
				[Dot42.DexImport("obtainStyledAttributes", "(Landroid/util/AttributeSet;[III)Landroid/content/res/TypedArray;", AccessFlags = 17)]
				public global::Android.Content.Res.TypedArray ObtainStyledAttributes(global::Android.Util.IAttributeSet attributeSet, int[] int32, int int321, int int322) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Res.TypedArray);
				}

				/// <java-name>
				/// getClassLoader
				/// </java-name>
				[Dot42.DexImport("getClassLoader", "()Ljava/lang/ClassLoader;", AccessFlags = 1025)]
				public abstract global::Java.Lang.ClassLoader GetClassLoader() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getPackageName
				/// </java-name>
				[Dot42.DexImport("getPackageName", "()Ljava/lang/String;", AccessFlags = 1025)]
				public abstract string GetPackageName() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getApplicationInfo
				/// </java-name>
				[Dot42.DexImport("getApplicationInfo", "()Landroid/content/pm/ApplicationInfo;", AccessFlags = 1025)]
				public abstract global::Android.Content.Pm.ApplicationInfo GetApplicationInfo() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getPackageResourcePath
				/// </java-name>
				[Dot42.DexImport("getPackageResourcePath", "()Ljava/lang/String;", AccessFlags = 1025)]
				public abstract string GetPackageResourcePath() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getPackageCodePath
				/// </java-name>
				[Dot42.DexImport("getPackageCodePath", "()Ljava/lang/String;", AccessFlags = 1025)]
				public abstract string GetPackageCodePath() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getSharedPreferences
				/// </java-name>
				[Dot42.DexImport("getSharedPreferences", "(Ljava/lang/String;I)Landroid/content/SharedPreferences;", AccessFlags = 1025)]
				public abstract global::Android.Content.ISharedPreferences GetSharedPreferences(string @string, int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// openFileInput
				/// </java-name>
				[Dot42.DexImport("openFileInput", "(Ljava/lang/String;)Ljava/io/FileInputStream;", AccessFlags = 1025)]
				public abstract global::Java.Io.FileInputStream OpenFileInput(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// openFileOutput
				/// </java-name>
				[Dot42.DexImport("openFileOutput", "(Ljava/lang/String;I)Ljava/io/FileOutputStream;", AccessFlags = 1025)]
				public abstract global::Java.Io.FileOutputStream OpenFileOutput(string @string, int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// deleteFile
				/// </java-name>
				[Dot42.DexImport("deleteFile", "(Ljava/lang/String;)Z", AccessFlags = 1025)]
				public abstract bool DeleteFile(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getFileStreamPath
				/// </java-name>
				[Dot42.DexImport("getFileStreamPath", "(Ljava/lang/String;)Ljava/io/File;", AccessFlags = 1025)]
				public abstract global::Java.Io.File GetFileStreamPath(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getFilesDir
				/// </java-name>
				[Dot42.DexImport("getFilesDir", "()Ljava/io/File;", AccessFlags = 1025)]
				public abstract global::Java.Io.File GetFilesDir() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getExternalFilesDir
				/// </java-name>
				[Dot42.DexImport("getExternalFilesDir", "(Ljava/lang/String;)Ljava/io/File;", AccessFlags = 1025)]
				public abstract global::Java.Io.File GetExternalFilesDir(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getObbDir
				/// </java-name>
				[Dot42.DexImport("getObbDir", "()Ljava/io/File;", AccessFlags = 1025)]
				public abstract global::Java.Io.File GetObbDir() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getCacheDir
				/// </java-name>
				[Dot42.DexImport("getCacheDir", "()Ljava/io/File;", AccessFlags = 1025)]
				public abstract global::Java.Io.File GetCacheDir() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getExternalCacheDir
				/// </java-name>
				[Dot42.DexImport("getExternalCacheDir", "()Ljava/io/File;", AccessFlags = 1025)]
				public abstract global::Java.Io.File GetExternalCacheDir() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// fileList
				/// </java-name>
				[Dot42.DexImport("fileList", "()[Ljava/lang/String;", AccessFlags = 1025)]
				public abstract string[] FileList() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getDir
				/// </java-name>
				[Dot42.DexImport("getDir", "(Ljava/lang/String;I)Ljava/io/File;", AccessFlags = 1025)]
				public abstract global::Java.Io.File GetDir(string @string, int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// openOrCreateDatabase
				/// </java-name>
				[Dot42.DexImport("openOrCreateDatabase", "(Ljava/lang/String;ILandroid/database/sqlite/SQLiteDatabase$CursorFactory;)Landro" +
    "id/database/sqlite/SQLiteDatabase;", AccessFlags = 1025)]
				public abstract global::Android.Database.Sqlite.SQLiteDatabase OpenOrCreateDatabase(string @string, int int32, global::Android.Database.Sqlite.SQLiteDatabase.ICursorFactory cursorFactory) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// openOrCreateDatabase
				/// </java-name>
				[Dot42.DexImport("openOrCreateDatabase", "(Ljava/lang/String;ILandroid/database/sqlite/SQLiteDatabase$CursorFactory;Landroi" +
    "d/database/DatabaseErrorHandler;)Landroid/database/sqlite/SQLiteDatabase;", AccessFlags = 1025)]
				public abstract global::Android.Database.Sqlite.SQLiteDatabase OpenOrCreateDatabase(string @string, int int32, global::Android.Database.Sqlite.SQLiteDatabase.ICursorFactory cursorFactory, global::Android.Database.IDatabaseErrorHandler databaseErrorHandler) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// deleteDatabase
				/// </java-name>
				[Dot42.DexImport("deleteDatabase", "(Ljava/lang/String;)Z", AccessFlags = 1025)]
				public abstract bool DeleteDatabase(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getDatabasePath
				/// </java-name>
				[Dot42.DexImport("getDatabasePath", "(Ljava/lang/String;)Ljava/io/File;", AccessFlags = 1025)]
				public abstract global::Java.Io.File GetDatabasePath(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// databaseList
				/// </java-name>
				[Dot42.DexImport("databaseList", "()[Ljava/lang/String;", AccessFlags = 1025)]
				public abstract string[] DatabaseList() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getWallpaper
				/// </java-name>
				[Dot42.DexImport("getWallpaper", "()Landroid/graphics/drawable/Drawable;", AccessFlags = 1025)]
				public abstract global::Android.Graphics.Drawable.Drawable GetWallpaper() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// peekWallpaper
				/// </java-name>
				[Dot42.DexImport("peekWallpaper", "()Landroid/graphics/drawable/Drawable;", AccessFlags = 1025)]
				public abstract global::Android.Graphics.Drawable.Drawable PeekWallpaper() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getWallpaperDesiredMinimumWidth
				/// </java-name>
				[Dot42.DexImport("getWallpaperDesiredMinimumWidth", "()I", AccessFlags = 1025)]
				public abstract int GetWallpaperDesiredMinimumWidth() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getWallpaperDesiredMinimumHeight
				/// </java-name>
				[Dot42.DexImport("getWallpaperDesiredMinimumHeight", "()I", AccessFlags = 1025)]
				public abstract int GetWallpaperDesiredMinimumHeight() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setWallpaper
				/// </java-name>
				[Dot42.DexImport("setWallpaper", "(Landroid/graphics/Bitmap;)V", AccessFlags = 1025)]
				public abstract void SetWallpaper(global::Android.Graphics.Bitmap bitmap) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setWallpaper
				/// </java-name>
				[Dot42.DexImport("setWallpaper", "(Ljava/io/InputStream;)V", AccessFlags = 1025)]
				public abstract void SetWallpaper(global::Java.Io.InputStream inputStream) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// clearWallpaper
				/// </java-name>
				[Dot42.DexImport("clearWallpaper", "()V", AccessFlags = 1025)]
				public abstract void ClearWallpaper() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// startActivity
				/// </java-name>
				[Dot42.DexImport("startActivity", "(Landroid/content/Intent;)V", AccessFlags = 1025)]
				public abstract void StartActivity(global::Android.Content.Intent intent) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// startActivities
				/// </java-name>
				[Dot42.DexImport("startActivities", "([Landroid/content/Intent;)V", AccessFlags = 1025)]
				public abstract void StartActivities(global::Android.Content.Intent[] intent) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// startIntentSender
				/// </java-name>
				[Dot42.DexImport("startIntentSender", "(Landroid/content/IntentSender;Landroid/content/Intent;III)V", AccessFlags = 1025)]
				public abstract void StartIntentSender(global::Android.Content.IntentSender intentSender, global::Android.Content.Intent intent, int int32, int int321, int int322) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// sendBroadcast
				/// </java-name>
				[Dot42.DexImport("sendBroadcast", "(Landroid/content/Intent;)V", AccessFlags = 1025)]
				public abstract void SendBroadcast(global::Android.Content.Intent intent) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// sendBroadcast
				/// </java-name>
				[Dot42.DexImport("sendBroadcast", "(Landroid/content/Intent;Ljava/lang/String;)V", AccessFlags = 1025)]
				public abstract void SendBroadcast(global::Android.Content.Intent intent, string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// sendOrderedBroadcast
				/// </java-name>
				[Dot42.DexImport("sendOrderedBroadcast", "(Landroid/content/Intent;Ljava/lang/String;)V", AccessFlags = 1025)]
				public abstract void SendOrderedBroadcast(global::Android.Content.Intent intent, string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// sendOrderedBroadcast
				/// </java-name>
				[Dot42.DexImport("sendOrderedBroadcast", "(Landroid/content/Intent;Ljava/lang/String;Landroid/content/BroadcastReceiver;Lan" +
    "droid/os/Handler;ILjava/lang/String;Landroid/os/Bundle;)V", AccessFlags = 1025)]
				public abstract void SendOrderedBroadcast(global::Android.Content.Intent intent, string @string, global::Android.Content.BroadcastReceiver broadcastReceiver, global::Android.Os.Handler handler, int int32, string string1, global::Android.Os.Bundle bundle) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// sendStickyBroadcast
				/// </java-name>
				[Dot42.DexImport("sendStickyBroadcast", "(Landroid/content/Intent;)V", AccessFlags = 1025)]
				public abstract void SendStickyBroadcast(global::Android.Content.Intent intent) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// sendStickyOrderedBroadcast
				/// </java-name>
				[Dot42.DexImport("sendStickyOrderedBroadcast", "(Landroid/content/Intent;Landroid/content/BroadcastReceiver;Landroid/os/Handler;I" +
    "Ljava/lang/String;Landroid/os/Bundle;)V", AccessFlags = 1025)]
				public abstract void SendStickyOrderedBroadcast(global::Android.Content.Intent intent, global::Android.Content.BroadcastReceiver broadcastReceiver, global::Android.Os.Handler handler, int int32, string @string, global::Android.Os.Bundle bundle) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// removeStickyBroadcast
				/// </java-name>
				[Dot42.DexImport("removeStickyBroadcast", "(Landroid/content/Intent;)V", AccessFlags = 1025)]
				public abstract void RemoveStickyBroadcast(global::Android.Content.Intent intent) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// registerReceiver
				/// </java-name>
				[Dot42.DexImport("registerReceiver", "(Landroid/content/BroadcastReceiver;Landroid/content/IntentFilter;)Landroid/conte" +
    "nt/Intent;", AccessFlags = 1025)]
				public abstract global::Android.Content.Intent RegisterReceiver(global::Android.Content.BroadcastReceiver broadcastReceiver, global::Android.Content.IntentFilter intentFilter) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// registerReceiver
				/// </java-name>
				[Dot42.DexImport("registerReceiver", "(Landroid/content/BroadcastReceiver;Landroid/content/IntentFilter;Ljava/lang/Stri" +
    "ng;Landroid/os/Handler;)Landroid/content/Intent;", AccessFlags = 1025)]
				public abstract global::Android.Content.Intent RegisterReceiver(global::Android.Content.BroadcastReceiver broadcastReceiver, global::Android.Content.IntentFilter intentFilter, string @string, global::Android.Os.Handler handler) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// unregisterReceiver
				/// </java-name>
				[Dot42.DexImport("unregisterReceiver", "(Landroid/content/BroadcastReceiver;)V", AccessFlags = 1025)]
				public abstract void UnregisterReceiver(global::Android.Content.BroadcastReceiver broadcastReceiver) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// startService
				/// </java-name>
				[Dot42.DexImport("startService", "(Landroid/content/Intent;)Landroid/content/ComponentName;", AccessFlags = 1025)]
				public abstract global::Android.Content.ComponentName StartService(global::Android.Content.Intent intent) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// stopService
				/// </java-name>
				[Dot42.DexImport("stopService", "(Landroid/content/Intent;)Z", AccessFlags = 1025)]
				public abstract bool StopService(global::Android.Content.Intent intent) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// bindService
				/// </java-name>
				[Dot42.DexImport("bindService", "(Landroid/content/Intent;Landroid/content/ServiceConnection;I)Z", AccessFlags = 1025)]
				public abstract bool BindService(global::Android.Content.Intent intent, global::Android.Content.IServiceConnection serviceConnection, int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// unbindService
				/// </java-name>
				[Dot42.DexImport("unbindService", "(Landroid/content/ServiceConnection;)V", AccessFlags = 1025)]
				public abstract void UnbindService(global::Android.Content.IServiceConnection serviceConnection) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// startInstrumentation
				/// </java-name>
				[Dot42.DexImport("startInstrumentation", "(Landroid/content/ComponentName;Ljava/lang/String;Landroid/os/Bundle;)Z", AccessFlags = 1025)]
				public abstract bool StartInstrumentation(global::Android.Content.ComponentName componentName, string @string, global::Android.Os.Bundle bundle) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getSystemService
				/// </java-name>
				[Dot42.DexImport("getSystemService", "(Ljava/lang/String;)Ljava/lang/Object;", AccessFlags = 1025)]
				public abstract object GetSystemService(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// checkPermission
				/// </java-name>
				[Dot42.DexImport("checkPermission", "(Ljava/lang/String;II)I", AccessFlags = 1025)]
				public abstract int CheckPermission(string @string, int int32, int int321) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// checkCallingPermission
				/// </java-name>
				[Dot42.DexImport("checkCallingPermission", "(Ljava/lang/String;)I", AccessFlags = 1025)]
				public abstract int CheckCallingPermission(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// checkCallingOrSelfPermission
				/// </java-name>
				[Dot42.DexImport("checkCallingOrSelfPermission", "(Ljava/lang/String;)I", AccessFlags = 1025)]
				public abstract int CheckCallingOrSelfPermission(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// enforcePermission
				/// </java-name>
				[Dot42.DexImport("enforcePermission", "(Ljava/lang/String;IILjava/lang/String;)V", AccessFlags = 1025)]
				public abstract void EnforcePermission(string @string, int int32, int int321, string string1) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// enforceCallingPermission
				/// </java-name>
				[Dot42.DexImport("enforceCallingPermission", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1025)]
				public abstract void EnforceCallingPermission(string @string, string string1) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// enforceCallingOrSelfPermission
				/// </java-name>
				[Dot42.DexImport("enforceCallingOrSelfPermission", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1025)]
				public abstract void EnforceCallingOrSelfPermission(string @string, string string1) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// grantUriPermission
				/// </java-name>
				[Dot42.DexImport("grantUriPermission", "(Ljava/lang/String;Landroid/net/Uri;I)V", AccessFlags = 1025)]
				public abstract void GrantUriPermission(string @string, global::Android.Net.Uri uri, int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// revokeUriPermission
				/// </java-name>
				[Dot42.DexImport("revokeUriPermission", "(Landroid/net/Uri;I)V", AccessFlags = 1025)]
				public abstract void RevokeUriPermission(global::Android.Net.Uri uri, int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// checkUriPermission
				/// </java-name>
				[Dot42.DexImport("checkUriPermission", "(Landroid/net/Uri;III)I", AccessFlags = 1025)]
				public abstract int CheckUriPermission(global::Android.Net.Uri uri, int int32, int int321, int int322) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// checkCallingUriPermission
				/// </java-name>
				[Dot42.DexImport("checkCallingUriPermission", "(Landroid/net/Uri;I)I", AccessFlags = 1025)]
				public abstract int CheckCallingUriPermission(global::Android.Net.Uri uri, int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// checkCallingOrSelfUriPermission
				/// </java-name>
				[Dot42.DexImport("checkCallingOrSelfUriPermission", "(Landroid/net/Uri;I)I", AccessFlags = 1025)]
				public abstract int CheckCallingOrSelfUriPermission(global::Android.Net.Uri uri, int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// checkUriPermission
				/// </java-name>
				[Dot42.DexImport("checkUriPermission", "(Landroid/net/Uri;Ljava/lang/String;Ljava/lang/String;III)I", AccessFlags = 1025)]
				public abstract int CheckUriPermission(global::Android.Net.Uri uri, string @string, string string1, int int32, int int321, int int322) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// enforceUriPermission
				/// </java-name>
				[Dot42.DexImport("enforceUriPermission", "(Landroid/net/Uri;IIILjava/lang/String;)V", AccessFlags = 1025)]
				public abstract void EnforceUriPermission(global::Android.Net.Uri uri, int int32, int int321, int int322, string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// enforceCallingUriPermission
				/// </java-name>
				[Dot42.DexImport("enforceCallingUriPermission", "(Landroid/net/Uri;ILjava/lang/String;)V", AccessFlags = 1025)]
				public abstract void EnforceCallingUriPermission(global::Android.Net.Uri uri, int int32, string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// enforceCallingOrSelfUriPermission
				/// </java-name>
				[Dot42.DexImport("enforceCallingOrSelfUriPermission", "(Landroid/net/Uri;ILjava/lang/String;)V", AccessFlags = 1025)]
				public abstract void EnforceCallingOrSelfUriPermission(global::Android.Net.Uri uri, int int32, string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// enforceUriPermission
				/// </java-name>
				[Dot42.DexImport("enforceUriPermission", "(Landroid/net/Uri;Ljava/lang/String;Ljava/lang/String;IIILjava/lang/String;)V", AccessFlags = 1025)]
				public abstract void EnforceUriPermission(global::Android.Net.Uri uri, string @string, string string1, int int32, int int321, int int322, string string2) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// createPackageContext
				/// </java-name>
				[Dot42.DexImport("createPackageContext", "(Ljava/lang/String;I)Landroid/content/Context;", AccessFlags = 1025)]
				public abstract global::Android.Content.Context CreatePackageContext(string @string, int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// isRestricted
				/// </java-name>
				[Dot42.DexImport("isRestricted", "()Z", AccessFlags = 1)]
				public virtual bool IsRestricted() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getAssets
				/// </java-name>
				public global::Android.Content.Res.AssetManager Assets
				{
				[Dot42.DexImport("getAssets", "()Landroid/content/res/AssetManager;", AccessFlags = 1025)]
						get{ return GetAssets(); }
				}

				/// <java-name>
				/// getResources
				/// </java-name>
				public global::Android.Content.Res.Resources Resources
				{
				[Dot42.DexImport("getResources", "()Landroid/content/res/Resources;", AccessFlags = 1025)]
						get{ return GetResources(); }
				}

				/// <java-name>
				/// getPackageManager
				/// </java-name>
				public global::Android.Content.Pm.PackageManager PackageManager
				{
				[Dot42.DexImport("getPackageManager", "()Landroid/content/pm/PackageManager;", AccessFlags = 1025)]
						get{ return GetPackageManager(); }
				}

				/// <java-name>
				/// getContentResolver
				/// </java-name>
				public global::Android.Content.ContentResolver ContentResolver
				{
				[Dot42.DexImport("getContentResolver", "()Landroid/content/ContentResolver;", AccessFlags = 1025)]
						get{ return GetContentResolver(); }
				}

				/// <java-name>
				/// getMainLooper
				/// </java-name>
				public global::Android.Os.Looper MainLooper
				{
				[Dot42.DexImport("getMainLooper", "()Landroid/os/Looper;", AccessFlags = 1025)]
						get{ return GetMainLooper(); }
				}

				/// <java-name>
				/// getApplicationContext
				/// </java-name>
				public global::Android.Content.Context ApplicationContext
				{
				[Dot42.DexImport("getApplicationContext", "()Landroid/content/Context;", AccessFlags = 1025)]
						get{ return GetApplicationContext(); }
				}

				/// <java-name>
				/// getTheme
				/// </java-name>
				public global::Android.Content.Res.Resources.Theme Theme
				{
				[Dot42.DexImport("getTheme", "()Landroid/content/res/Resources$Theme;", AccessFlags = 1025)]
						get{ return GetTheme(); }
				}

				/// <java-name>
				/// getClassLoader
				/// </java-name>
				public global::Java.Lang.ClassLoader ClassLoader
				{
				[Dot42.DexImport("getClassLoader", "()Ljava/lang/ClassLoader;", AccessFlags = 1025)]
						get{ return GetClassLoader(); }
				}

				/// <java-name>
				/// getPackageName
				/// </java-name>
				public string PackageName
				{
				[Dot42.DexImport("getPackageName", "()Ljava/lang/String;", AccessFlags = 1025)]
						get{ return GetPackageName(); }
				}

				/// <java-name>
				/// getApplicationInfo
				/// </java-name>
				public global::Android.Content.Pm.ApplicationInfo ApplicationInfo
				{
				[Dot42.DexImport("getApplicationInfo", "()Landroid/content/pm/ApplicationInfo;", AccessFlags = 1025)]
						get{ return GetApplicationInfo(); }
				}

				/// <java-name>
				/// getPackageResourcePath
				/// </java-name>
				public string PackageResourcePath
				{
				[Dot42.DexImport("getPackageResourcePath", "()Ljava/lang/String;", AccessFlags = 1025)]
						get{ return GetPackageResourcePath(); }
				}

				/// <java-name>
				/// getPackageCodePath
				/// </java-name>
				public string PackageCodePath
				{
				[Dot42.DexImport("getPackageCodePath", "()Ljava/lang/String;", AccessFlags = 1025)]
						get{ return GetPackageCodePath(); }
				}

				/// <java-name>
				/// getFilesDir
				/// </java-name>
				public global::Java.Io.File FilesDir
				{
				[Dot42.DexImport("getFilesDir", "()Ljava/io/File;", AccessFlags = 1025)]
						get{ return GetFilesDir(); }
				}

				/// <java-name>
				/// getObbDir
				/// </java-name>
				public global::Java.Io.File ObbDir
				{
				[Dot42.DexImport("getObbDir", "()Ljava/io/File;", AccessFlags = 1025)]
						get{ return GetObbDir(); }
				}

				/// <java-name>
				/// getCacheDir
				/// </java-name>
				public global::Java.Io.File CacheDir
				{
				[Dot42.DexImport("getCacheDir", "()Ljava/io/File;", AccessFlags = 1025)]
						get{ return GetCacheDir(); }
				}

				/// <java-name>
				/// getExternalCacheDir
				/// </java-name>
				public global::Java.Io.File ExternalCacheDir
				{
				[Dot42.DexImport("getExternalCacheDir", "()Ljava/io/File;", AccessFlags = 1025)]
						get{ return GetExternalCacheDir(); }
				}

				/// <java-name>
				/// getWallpaper
				/// </java-name>
				public global::Android.Graphics.Drawable.Drawable Wallpaper
				{
				[Dot42.DexImport("getWallpaper", "()Landroid/graphics/drawable/Drawable;", AccessFlags = 1025)]
						get{ return GetWallpaper(); }
				}

				/// <java-name>
				/// getWallpaperDesiredMinimumWidth
				/// </java-name>
				public int WallpaperDesiredMinimumWidth
				{
				[Dot42.DexImport("getWallpaperDesiredMinimumWidth", "()I", AccessFlags = 1025)]
						get{ return GetWallpaperDesiredMinimumWidth(); }
				}

				/// <java-name>
				/// getWallpaperDesiredMinimumHeight
				/// </java-name>
				public int WallpaperDesiredMinimumHeight
				{
				[Dot42.DexImport("getWallpaperDesiredMinimumHeight", "()I", AccessFlags = 1025)]
						get{ return GetWallpaperDesiredMinimumHeight(); }
				}

		}

		/// <java-name>
		/// android/content/SyncStats
		/// </java-name>
		[Dot42.DexImport("android/content/SyncStats", AccessFlags = 33)]
		public partial class SyncStats : global::Android.Os.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// numAuthExceptions
				/// </java-name>
				[Dot42.DexImport("numAuthExceptions", "J", AccessFlags = 1)]
				public long NumAuthExceptions;
				/// <java-name>
				/// numIoExceptions
				/// </java-name>
				[Dot42.DexImport("numIoExceptions", "J", AccessFlags = 1)]
				public long NumIoExceptions;
				/// <java-name>
				/// numParseExceptions
				/// </java-name>
				[Dot42.DexImport("numParseExceptions", "J", AccessFlags = 1)]
				public long NumParseExceptions;
				/// <java-name>
				/// numConflictDetectedExceptions
				/// </java-name>
				[Dot42.DexImport("numConflictDetectedExceptions", "J", AccessFlags = 1)]
				public long NumConflictDetectedExceptions;
				/// <java-name>
				/// numInserts
				/// </java-name>
				[Dot42.DexImport("numInserts", "J", AccessFlags = 1)]
				public long NumInserts;
				/// <java-name>
				/// numUpdates
				/// </java-name>
				[Dot42.DexImport("numUpdates", "J", AccessFlags = 1)]
				public long NumUpdates;
				/// <java-name>
				/// numDeletes
				/// </java-name>
				[Dot42.DexImport("numDeletes", "J", AccessFlags = 1)]
				public long NumDeletes;
				/// <java-name>
				/// numEntries
				/// </java-name>
				[Dot42.DexImport("numEntries", "J", AccessFlags = 1)]
				public long NumEntries;
				/// <java-name>
				/// numSkippedEntries
				/// </java-name>
				[Dot42.DexImport("numSkippedEntries", "J", AccessFlags = 1)]
				public long NumSkippedEntries;
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.Os.IParcelable_ICreator<global::Android.Content.SyncStats> CREATOR;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public SyncStats() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/os/Parcel;)V", AccessFlags = 1)]
				public SyncStats(global::Android.Os.Parcel parcel) /* MethodBuilder.Create */ 
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
				/// clear
				/// </java-name>
				[Dot42.DexImport("clear", "()V", AccessFlags = 1)]
				public virtual void Clear() /* MethodBuilder.Create */ 
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
				public virtual void WriteToParcel(global::Android.Os.Parcel parcel, int int32) /* MethodBuilder.Create */ 
				{
				}

		}

}

