#pragma warning disable 1717
namespace Android.Drm
{
		/// <java-name>
		/// android/drm/DrmConvertedStatus
		/// </java-name>
		[Dot42.DexImport("android/drm/DrmConvertedStatus", AccessFlags = 33)]
		public partial class DrmConvertedStatus
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// STATUS_OK
				/// </java-name>
				[Dot42.DexImport("STATUS_OK", "I", AccessFlags = 25)]
				public const int STATUS_OK = 1;
				/// <java-name>
				/// STATUS_INPUTDATA_ERROR
				/// </java-name>
				[Dot42.DexImport("STATUS_INPUTDATA_ERROR", "I", AccessFlags = 25)]
				public const int STATUS_INPUTDATA_ERROR = 2;
				/// <java-name>
				/// STATUS_ERROR
				/// </java-name>
				[Dot42.DexImport("STATUS_ERROR", "I", AccessFlags = 25)]
				public const int STATUS_ERROR = 3;
				/// <java-name>
				/// statusCode
				/// </java-name>
				[Dot42.DexImport("statusCode", "I", AccessFlags = 17)]
				public readonly int StatusCode;
				/// <java-name>
				/// convertedData
				/// </java-name>
				[Dot42.DexImport("convertedData", "[B", AccessFlags = 17)]
				public readonly sbyte[] ConvertedData;
				/// <java-name>
				/// offset
				/// </java-name>
				[Dot42.DexImport("offset", "I", AccessFlags = 17)]
				public readonly int Offset;
				[Dot42.DexImport("<init>", "(I[BI)V", AccessFlags = 1)]
				public DrmConvertedStatus(int int32, sbyte[] sByte, int int321) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(I[BI)V", AccessFlags = 1, IgnoreFromJava = true)]
				public DrmConvertedStatus(int int32, byte[] @byte, int int321) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal DrmConvertedStatus() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// android/drm/DrmErrorEvent
		/// </java-name>
		[Dot42.DexImport("android/drm/DrmErrorEvent", AccessFlags = 33)]
		public partial class DrmErrorEvent : global::Android.Drm.DrmEvent
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// TYPE_RIGHTS_NOT_INSTALLED
				/// </java-name>
				[Dot42.DexImport("TYPE_RIGHTS_NOT_INSTALLED", "I", AccessFlags = 25)]
				public const int TYPE_RIGHTS_NOT_INSTALLED = 2001;
				/// <java-name>
				/// TYPE_RIGHTS_RENEWAL_NOT_ALLOWED
				/// </java-name>
				[Dot42.DexImport("TYPE_RIGHTS_RENEWAL_NOT_ALLOWED", "I", AccessFlags = 25)]
				public const int TYPE_RIGHTS_RENEWAL_NOT_ALLOWED = 2002;
				/// <java-name>
				/// TYPE_NOT_SUPPORTED
				/// </java-name>
				[Dot42.DexImport("TYPE_NOT_SUPPORTED", "I", AccessFlags = 25)]
				public const int TYPE_NOT_SUPPORTED = 2003;
				/// <java-name>
				/// TYPE_OUT_OF_MEMORY
				/// </java-name>
				[Dot42.DexImport("TYPE_OUT_OF_MEMORY", "I", AccessFlags = 25)]
				public const int TYPE_OUT_OF_MEMORY = 2004;
				/// <java-name>
				/// TYPE_NO_INTERNET_CONNECTION
				/// </java-name>
				[Dot42.DexImport("TYPE_NO_INTERNET_CONNECTION", "I", AccessFlags = 25)]
				public const int TYPE_NO_INTERNET_CONNECTION = 2005;
				/// <java-name>
				/// TYPE_PROCESS_DRM_INFO_FAILED
				/// </java-name>
				[Dot42.DexImport("TYPE_PROCESS_DRM_INFO_FAILED", "I", AccessFlags = 25)]
				public const int TYPE_PROCESS_DRM_INFO_FAILED = 2006;
				/// <java-name>
				/// TYPE_REMOVE_ALL_RIGHTS_FAILED
				/// </java-name>
				[Dot42.DexImport("TYPE_REMOVE_ALL_RIGHTS_FAILED", "I", AccessFlags = 25)]
				public const int TYPE_REMOVE_ALL_RIGHTS_FAILED = 2007;
				/// <java-name>
				/// TYPE_ACQUIRE_DRM_INFO_FAILED
				/// </java-name>
				[Dot42.DexImport("TYPE_ACQUIRE_DRM_INFO_FAILED", "I", AccessFlags = 25)]
				public const int TYPE_ACQUIRE_DRM_INFO_FAILED = 2008;
				[Dot42.DexImport("<init>", "(IILjava/lang/String;)V", AccessFlags = 1)]
				public DrmErrorEvent(int int32, int int321, string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(IILjava/lang/String;Ljava/util/HashMap;)V", AccessFlags = 1, Signature = "(IILjava/lang/String;Ljava/util/HashMap<Ljava/lang/String;Ljava/lang/Object;>;)V")]
				public DrmErrorEvent(int int32, int int321, string @string, global::Java.Util.HashMap<string, object> hashMap) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal DrmErrorEvent() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// android/drm/DrmEvent
		/// </java-name>
		[Dot42.DexImport("android/drm/DrmEvent", AccessFlags = 33)]
		public partial class DrmEvent
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// TYPE_ALL_RIGHTS_REMOVED
				/// </java-name>
				[Dot42.DexImport("TYPE_ALL_RIGHTS_REMOVED", "I", AccessFlags = 25)]
				public const int TYPE_ALL_RIGHTS_REMOVED = 1001;
				/// <java-name>
				/// TYPE_DRM_INFO_PROCESSED
				/// </java-name>
				[Dot42.DexImport("TYPE_DRM_INFO_PROCESSED", "I", AccessFlags = 25)]
				public const int TYPE_DRM_INFO_PROCESSED = 1002;
				/// <java-name>
				/// DRM_INFO_STATUS_OBJECT
				/// </java-name>
				[Dot42.DexImport("DRM_INFO_STATUS_OBJECT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string DRM_INFO_STATUS_OBJECT = "drm_info_status_object";
				/// <java-name>
				/// DRM_INFO_OBJECT
				/// </java-name>
				[Dot42.DexImport("DRM_INFO_OBJECT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string DRM_INFO_OBJECT = "drm_info_object";
				[Dot42.DexImport("<init>", "(IILjava/lang/String;Ljava/util/HashMap;)V", AccessFlags = 4, Signature = "(IILjava/lang/String;Ljava/util/HashMap<Ljava/lang/String;Ljava/lang/Object;>;)V")]
				protected internal DrmEvent(int int32, int int321, string @string, global::Java.Util.HashMap<string, object> hashMap) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(IILjava/lang/String;)V", AccessFlags = 4)]
				protected internal DrmEvent(int int32, int int321, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getAttribute
				/// </java-name>
				[Dot42.DexImport("getAttribute", "(Ljava/lang/String;)Ljava/lang/Object;", AccessFlags = 1)]
				public virtual object GetAttribute(string @string) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal DrmEvent() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getUniqueId
				/// </java-name>
				public virtual int UniqueId
				{
						[Dot42.DexImport("getUniqueId", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getType
				/// </java-name>
				public virtual int Type
				{
						[Dot42.DexImport("getType", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getMessage
				/// </java-name>
				public virtual string Message
				{
						[Dot42.DexImport("getMessage", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

		}

		/// <java-name>
		/// android/drm/DrmInfo
		/// </java-name>
		[Dot42.DexImport("android/drm/DrmInfo", AccessFlags = 33)]
		public partial class DrmInfo
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(I[BLjava/lang/String;)V", AccessFlags = 1)]
				public DrmInfo(int int32, sbyte[] sByte, string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(I[BLjava/lang/String;)V", AccessFlags = 1, IgnoreFromJava = true)]
				public DrmInfo(int int32, byte[] @byte, string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(ILjava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public DrmInfo(int int32, string @string, string string1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "(Ljava/lang/String;Ljava/lang/Object;)V", AccessFlags = 1)]
				public virtual void Put(string @string, object @object) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(Ljava/lang/String;)Ljava/lang/Object;", AccessFlags = 1)]
				public virtual object Get(string @string) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <java-name>
				/// keyIterator
				/// </java-name>
				[Dot42.DexImport("keyIterator", "()Ljava/util/Iterator;", AccessFlags = 1, Signature = "()Ljava/util/Iterator<Ljava/lang/String;>;")]
				public virtual global::Java.Util.IIterator<string> KeyIterator() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IIterator<string>);
				}

				/// <java-name>
				/// iterator
				/// </java-name>
				[Dot42.DexImport("iterator", "()Ljava/util/Iterator;", AccessFlags = 1, Signature = "()Ljava/util/Iterator<Ljava/lang/Object;>;")]
				public virtual global::Java.Util.IIterator<object> Iterator() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IIterator<object>);
				}

				/// <java-name>
				/// getData
				/// </java-name>
				[Dot42.DexImport("getData", "()[B", AccessFlags = 1)]
				public virtual sbyte[] JavaGetData() /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal DrmInfo() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getData
				/// </java-name>
				public virtual byte[] Data
				{
						[Dot42.DexImport("getData", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
						get{ return default(byte[]); }
				}

				/// <java-name>
				/// getMimeType
				/// </java-name>
				public virtual string MimeType
				{
						[Dot42.DexImport("getMimeType", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getInfoType
				/// </java-name>
				public virtual int InfoType
				{
						[Dot42.DexImport("getInfoType", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

		}

		/// <java-name>
		/// android/drm/DrmInfoEvent
		/// </java-name>
		[Dot42.DexImport("android/drm/DrmInfoEvent", AccessFlags = 33)]
		public partial class DrmInfoEvent : global::Android.Drm.DrmEvent
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// TYPE_ALREADY_REGISTERED_BY_ANOTHER_ACCOUNT
				/// </java-name>
				[Dot42.DexImport("TYPE_ALREADY_REGISTERED_BY_ANOTHER_ACCOUNT", "I", AccessFlags = 25)]
				public const int TYPE_ALREADY_REGISTERED_BY_ANOTHER_ACCOUNT = 1;
				/// <java-name>
				/// TYPE_REMOVE_RIGHTS
				/// </java-name>
				[Dot42.DexImport("TYPE_REMOVE_RIGHTS", "I", AccessFlags = 25)]
				public const int TYPE_REMOVE_RIGHTS = 2;
				/// <java-name>
				/// TYPE_RIGHTS_INSTALLED
				/// </java-name>
				[Dot42.DexImport("TYPE_RIGHTS_INSTALLED", "I", AccessFlags = 25)]
				public const int TYPE_RIGHTS_INSTALLED = 3;
				/// <java-name>
				/// TYPE_WAIT_FOR_RIGHTS
				/// </java-name>
				[Dot42.DexImport("TYPE_WAIT_FOR_RIGHTS", "I", AccessFlags = 25)]
				public const int TYPE_WAIT_FOR_RIGHTS = 4;
				/// <java-name>
				/// TYPE_ACCOUNT_ALREADY_REGISTERED
				/// </java-name>
				[Dot42.DexImport("TYPE_ACCOUNT_ALREADY_REGISTERED", "I", AccessFlags = 25)]
				public const int TYPE_ACCOUNT_ALREADY_REGISTERED = 5;
				/// <java-name>
				/// TYPE_RIGHTS_REMOVED
				/// </java-name>
				[Dot42.DexImport("TYPE_RIGHTS_REMOVED", "I", AccessFlags = 25)]
				public const int TYPE_RIGHTS_REMOVED = 6;
				[Dot42.DexImport("<init>", "(IILjava/lang/String;)V", AccessFlags = 1)]
				public DrmInfoEvent(int int32, int int321, string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(IILjava/lang/String;Ljava/util/HashMap;)V", AccessFlags = 1, Signature = "(IILjava/lang/String;Ljava/util/HashMap<Ljava/lang/String;Ljava/lang/Object;>;)V")]
				public DrmInfoEvent(int int32, int int321, string @string, global::Java.Util.HashMap<string, object> hashMap) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal DrmInfoEvent() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// android/drm/DrmInfoRequest
		/// </java-name>
		[Dot42.DexImport("android/drm/DrmInfoRequest", AccessFlags = 33)]
		public partial class DrmInfoRequest
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// TYPE_REGISTRATION_INFO
				/// </java-name>
				[Dot42.DexImport("TYPE_REGISTRATION_INFO", "I", AccessFlags = 25)]
				public const int TYPE_REGISTRATION_INFO = 1;
				/// <java-name>
				/// TYPE_UNREGISTRATION_INFO
				/// </java-name>
				[Dot42.DexImport("TYPE_UNREGISTRATION_INFO", "I", AccessFlags = 25)]
				public const int TYPE_UNREGISTRATION_INFO = 2;
				/// <java-name>
				/// TYPE_RIGHTS_ACQUISITION_INFO
				/// </java-name>
				[Dot42.DexImport("TYPE_RIGHTS_ACQUISITION_INFO", "I", AccessFlags = 25)]
				public const int TYPE_RIGHTS_ACQUISITION_INFO = 3;
				/// <java-name>
				/// TYPE_RIGHTS_ACQUISITION_PROGRESS_INFO
				/// </java-name>
				[Dot42.DexImport("TYPE_RIGHTS_ACQUISITION_PROGRESS_INFO", "I", AccessFlags = 25)]
				public const int TYPE_RIGHTS_ACQUISITION_PROGRESS_INFO = 4;
				/// <java-name>
				/// ACCOUNT_ID
				/// </java-name>
				[Dot42.DexImport("ACCOUNT_ID", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACCOUNT_ID = "account_id";
				/// <java-name>
				/// SUBSCRIPTION_ID
				/// </java-name>
				[Dot42.DexImport("SUBSCRIPTION_ID", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SUBSCRIPTION_ID = "subscription_id";
				[Dot42.DexImport("<init>", "(ILjava/lang/String;)V", AccessFlags = 1)]
				public DrmInfoRequest(int int32, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "(Ljava/lang/String;Ljava/lang/Object;)V", AccessFlags = 1)]
				public virtual void Put(string @string, object @object) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(Ljava/lang/String;)Ljava/lang/Object;", AccessFlags = 1)]
				public virtual object Get(string @string) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <java-name>
				/// keyIterator
				/// </java-name>
				[Dot42.DexImport("keyIterator", "()Ljava/util/Iterator;", AccessFlags = 1, Signature = "()Ljava/util/Iterator<Ljava/lang/String;>;")]
				public virtual global::Java.Util.IIterator<string> KeyIterator() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IIterator<string>);
				}

				/// <java-name>
				/// iterator
				/// </java-name>
				[Dot42.DexImport("iterator", "()Ljava/util/Iterator;", AccessFlags = 1, Signature = "()Ljava/util/Iterator<Ljava/lang/Object;>;")]
				public virtual global::Java.Util.IIterator<object> Iterator() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IIterator<object>);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal DrmInfoRequest() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getMimeType
				/// </java-name>
				public virtual string MimeType
				{
						[Dot42.DexImport("getMimeType", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getInfoType
				/// </java-name>
				public virtual int InfoType
				{
						[Dot42.DexImport("getInfoType", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

		}

		/// <java-name>
		/// android/drm/DrmInfoStatus
		/// </java-name>
		[Dot42.DexImport("android/drm/DrmInfoStatus", AccessFlags = 33)]
		public partial class DrmInfoStatus
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// STATUS_OK
				/// </java-name>
				[Dot42.DexImport("STATUS_OK", "I", AccessFlags = 25)]
				public const int STATUS_OK = 1;
				/// <java-name>
				/// STATUS_ERROR
				/// </java-name>
				[Dot42.DexImport("STATUS_ERROR", "I", AccessFlags = 25)]
				public const int STATUS_ERROR = 2;
				/// <java-name>
				/// statusCode
				/// </java-name>
				[Dot42.DexImport("statusCode", "I", AccessFlags = 17)]
				public readonly int StatusCode;
				/// <java-name>
				/// infoType
				/// </java-name>
				[Dot42.DexImport("infoType", "I", AccessFlags = 17)]
				public readonly int InfoType;
				/// <java-name>
				/// mimeType
				/// </java-name>
				[Dot42.DexImport("mimeType", "Ljava/lang/String;", AccessFlags = 17)]
				public readonly string MimeType;
				/// <java-name>
				/// data
				/// </java-name>
				[Dot42.DexImport("data", "Landroid/drm/ProcessedData;", AccessFlags = 17)]
				public readonly global::Android.Drm.ProcessedData Data;
				[Dot42.DexImport("<init>", "(IILandroid/drm/ProcessedData;Ljava/lang/String;)V", AccessFlags = 1)]
				public DrmInfoStatus(int int32, int int321, global::Android.Drm.ProcessedData processedData, string @string) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal DrmInfoStatus() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// android/drm/DrmManagerClient
		/// </java-name>
		[Dot42.DexImport("android/drm/DrmManagerClient", AccessFlags = 33)]
		public partial class DrmManagerClient
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// ERROR_NONE
				/// </java-name>
				[Dot42.DexImport("ERROR_NONE", "I", AccessFlags = 25)]
				public const int ERROR_NONE = 0;
				/// <java-name>
				/// ERROR_UNKNOWN
				/// </java-name>
				[Dot42.DexImport("ERROR_UNKNOWN", "I", AccessFlags = 25)]
				public const int ERROR_UNKNOWN = -2000;
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public DrmManagerClient(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// finalize
				/// </java-name>
				[Dot42.DexImport("finalize", "()V", AccessFlags = 4)]
				extern ~DrmManagerClient() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setOnInfoListener
				/// </java-name>
				[Dot42.DexImport("setOnInfoListener", "(Landroid/drm/DrmManagerClient$OnInfoListener;)V", AccessFlags = 33)]
				public virtual void SetOnInfoListener(global::Android.Drm.DrmManagerClient.IOnInfoListener onInfoListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setOnEventListener
				/// </java-name>
				[Dot42.DexImport("setOnEventListener", "(Landroid/drm/DrmManagerClient$OnEventListener;)V", AccessFlags = 33)]
				public virtual void SetOnEventListener(global::Android.Drm.DrmManagerClient.IOnEventListener onEventListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setOnErrorListener
				/// </java-name>
				[Dot42.DexImport("setOnErrorListener", "(Landroid/drm/DrmManagerClient$OnErrorListener;)V", AccessFlags = 33)]
				public virtual void SetOnErrorListener(global::Android.Drm.DrmManagerClient.IOnErrorListener onErrorListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getConstraints
				/// </java-name>
				[Dot42.DexImport("getConstraints", "(Ljava/lang/String;I)Landroid/content/ContentValues;", AccessFlags = 1)]
				public virtual global::Android.Content.ContentValues GetConstraints(string @string, int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.ContentValues);
				}

				/// <java-name>
				/// getMetadata
				/// </java-name>
				[Dot42.DexImport("getMetadata", "(Ljava/lang/String;)Landroid/content/ContentValues;", AccessFlags = 1)]
				public virtual global::Android.Content.ContentValues GetMetadata(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.ContentValues);
				}

				/// <java-name>
				/// getConstraints
				/// </java-name>
				[Dot42.DexImport("getConstraints", "(Landroid/net/Uri;I)Landroid/content/ContentValues;", AccessFlags = 1)]
				public virtual global::Android.Content.ContentValues GetConstraints(global::Android.Net.Uri uri, int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.ContentValues);
				}

				/// <java-name>
				/// getMetadata
				/// </java-name>
				[Dot42.DexImport("getMetadata", "(Landroid/net/Uri;)Landroid/content/ContentValues;", AccessFlags = 1)]
				public virtual global::Android.Content.ContentValues GetMetadata(global::Android.Net.Uri uri) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.ContentValues);
				}

				/// <java-name>
				/// saveRights
				/// </java-name>
				[Dot42.DexImport("saveRights", "(Landroid/drm/DrmRights;Ljava/lang/String;Ljava/lang/String;)I", AccessFlags = 1)]
				public virtual int SaveRights(global::Android.Drm.DrmRights drmRights, string @string, string string1) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// canHandle
				/// </java-name>
				[Dot42.DexImport("canHandle", "(Ljava/lang/String;Ljava/lang/String;)Z", AccessFlags = 1)]
				public virtual bool CanHandle(string @string, string string1) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// canHandle
				/// </java-name>
				[Dot42.DexImport("canHandle", "(Landroid/net/Uri;Ljava/lang/String;)Z", AccessFlags = 1)]
				public virtual bool CanHandle(global::Android.Net.Uri uri, string @string) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// processDrmInfo
				/// </java-name>
				[Dot42.DexImport("processDrmInfo", "(Landroid/drm/DrmInfo;)I", AccessFlags = 1)]
				public virtual int ProcessDrmInfo(global::Android.Drm.DrmInfo drmInfo) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// acquireDrmInfo
				/// </java-name>
				[Dot42.DexImport("acquireDrmInfo", "(Landroid/drm/DrmInfoRequest;)Landroid/drm/DrmInfo;", AccessFlags = 1)]
				public virtual global::Android.Drm.DrmInfo AcquireDrmInfo(global::Android.Drm.DrmInfoRequest drmInfoRequest) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Drm.DrmInfo);
				}

				/// <java-name>
				/// acquireRights
				/// </java-name>
				[Dot42.DexImport("acquireRights", "(Landroid/drm/DrmInfoRequest;)I", AccessFlags = 1)]
				public virtual int AcquireRights(global::Android.Drm.DrmInfoRequest drmInfoRequest) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getDrmObjectType
				/// </java-name>
				[Dot42.DexImport("getDrmObjectType", "(Ljava/lang/String;Ljava/lang/String;)I", AccessFlags = 1)]
				public virtual int GetDrmObjectType(string @string, string string1) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getDrmObjectType
				/// </java-name>
				[Dot42.DexImport("getDrmObjectType", "(Landroid/net/Uri;Ljava/lang/String;)I", AccessFlags = 1)]
				public virtual int GetDrmObjectType(global::Android.Net.Uri uri, string @string) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getOriginalMimeType
				/// </java-name>
				[Dot42.DexImport("getOriginalMimeType", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetOriginalMimeType(string @string) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getOriginalMimeType
				/// </java-name>
				[Dot42.DexImport("getOriginalMimeType", "(Landroid/net/Uri;)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetOriginalMimeType(global::Android.Net.Uri uri) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// checkRightsStatus
				/// </java-name>
				[Dot42.DexImport("checkRightsStatus", "(Ljava/lang/String;)I", AccessFlags = 1)]
				public virtual int CheckRightsStatus(string @string) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// checkRightsStatus
				/// </java-name>
				[Dot42.DexImport("checkRightsStatus", "(Landroid/net/Uri;)I", AccessFlags = 1)]
				public virtual int CheckRightsStatus(global::Android.Net.Uri uri) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// checkRightsStatus
				/// </java-name>
				[Dot42.DexImport("checkRightsStatus", "(Ljava/lang/String;I)I", AccessFlags = 1)]
				public virtual int CheckRightsStatus(string @string, int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// checkRightsStatus
				/// </java-name>
				[Dot42.DexImport("checkRightsStatus", "(Landroid/net/Uri;I)I", AccessFlags = 1)]
				public virtual int CheckRightsStatus(global::Android.Net.Uri uri, int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// removeRights
				/// </java-name>
				[Dot42.DexImport("removeRights", "(Ljava/lang/String;)I", AccessFlags = 1)]
				public virtual int RemoveRights(string @string) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// removeRights
				/// </java-name>
				[Dot42.DexImport("removeRights", "(Landroid/net/Uri;)I", AccessFlags = 1)]
				public virtual int RemoveRights(global::Android.Net.Uri uri) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// removeAllRights
				/// </java-name>
				[Dot42.DexImport("removeAllRights", "()I", AccessFlags = 1)]
				public virtual int RemoveAllRights() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// openConvertSession
				/// </java-name>
				[Dot42.DexImport("openConvertSession", "(Ljava/lang/String;)I", AccessFlags = 1)]
				public virtual int OpenConvertSession(string @string) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// convertData
				/// </java-name>
				[Dot42.DexImport("convertData", "(I[B)Landroid/drm/DrmConvertedStatus;", AccessFlags = 1)]
				public virtual global::Android.Drm.DrmConvertedStatus ConvertData(int int32, sbyte[] sByte) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Drm.DrmConvertedStatus);
				}

				/// <java-name>
				/// convertData
				/// </java-name>
				[Dot42.DexImport("convertData", "(I[B)Landroid/drm/DrmConvertedStatus;", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual global::Android.Drm.DrmConvertedStatus ConvertData(int int32, byte[] @byte) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Drm.DrmConvertedStatus);
				}

				/// <java-name>
				/// closeConvertSession
				/// </java-name>
				[Dot42.DexImport("closeConvertSession", "(I)Landroid/drm/DrmConvertedStatus;", AccessFlags = 1)]
				public virtual global::Android.Drm.DrmConvertedStatus CloseConvertSession(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Drm.DrmConvertedStatus);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal DrmManagerClient() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getAvailableDrmEngines
				/// </java-name>
				public virtual string[] AvailableDrmEngines
				{
						[Dot42.DexImport("getAvailableDrmEngines", "()[Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string[]); }
				}

				/// <java-name>
				/// android/drm/DrmManagerClient$OnErrorListener
				/// </java-name>
				[Dot42.DexImport("android/drm/DrmManagerClient$OnErrorListener", AccessFlags = 1545)]
				public partial interface IOnErrorListener
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onError
						/// </java-name>
						[Dot42.DexImport("onError", "(Landroid/drm/DrmManagerClient;Landroid/drm/DrmErrorEvent;)V", AccessFlags = 1025)]
						void OnError(global::Android.Drm.DrmManagerClient drmManagerClient, global::Android.Drm.DrmErrorEvent drmErrorEvent) /* MethodBuilder.Create */ ;

				}

				/// <java-name>
				/// android/drm/DrmManagerClient$OnEventListener
				/// </java-name>
				[Dot42.DexImport("android/drm/DrmManagerClient$OnEventListener", AccessFlags = 1545)]
				public partial interface IOnEventListener
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onEvent
						/// </java-name>
						[Dot42.DexImport("onEvent", "(Landroid/drm/DrmManagerClient;Landroid/drm/DrmEvent;)V", AccessFlags = 1025)]
						void OnEvent(global::Android.Drm.DrmManagerClient drmManagerClient, global::Android.Drm.DrmEvent drmEvent) /* MethodBuilder.Create */ ;

				}

				/// <java-name>
				/// android/drm/DrmManagerClient$OnInfoListener
				/// </java-name>
				[Dot42.DexImport("android/drm/DrmManagerClient$OnInfoListener", AccessFlags = 1545)]
				public partial interface IOnInfoListener
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onInfo
						/// </java-name>
						[Dot42.DexImport("onInfo", "(Landroid/drm/DrmManagerClient;Landroid/drm/DrmInfoEvent;)V", AccessFlags = 1025)]
						void OnInfo(global::Android.Drm.DrmManagerClient drmManagerClient, global::Android.Drm.DrmInfoEvent drmInfoEvent) /* MethodBuilder.Create */ ;

				}

		}

		/// <java-name>
		/// android/drm/DrmRights
		/// </java-name>
		[Dot42.DexImport("android/drm/DrmRights", AccessFlags = 33)]
		public partial class DrmRights
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public DrmRights(string @string, string string1) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public DrmRights(string @string, string string1, string string2) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public DrmRights(string @string, string string1, string string2, string string3) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/io/File;Ljava/lang/String;)V", AccessFlags = 1)]
				public DrmRights(global::Java.IO.File file, string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/drm/ProcessedData;Ljava/lang/String;)V", AccessFlags = 1)]
				public DrmRights(global::Android.Drm.ProcessedData processedData, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getData
				/// </java-name>
				[Dot42.DexImport("getData", "()[B", AccessFlags = 1)]
				public virtual sbyte[] JavaGetData() /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal DrmRights() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getData
				/// </java-name>
				public virtual byte[] Data
				{
						[Dot42.DexImport("getData", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
						get{ return default(byte[]); }
				}

				/// <java-name>
				/// getMimeType
				/// </java-name>
				public virtual string MimeType
				{
						[Dot42.DexImport("getMimeType", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getAccountId
				/// </java-name>
				public virtual string AccountId
				{
						[Dot42.DexImport("getAccountId", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getSubscriptionId
				/// </java-name>
				public virtual string SubscriptionId
				{
						[Dot42.DexImport("getSubscriptionId", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

		}

		/// <java-name>
		/// android/drm/DrmStore
		/// </java-name>
		[Dot42.DexImport("android/drm/DrmStore", AccessFlags = 33)]
		public partial class DrmStore
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public DrmStore() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// android/drm/DrmStore$RightsStatus
				/// </java-name>
				[Dot42.DexImport("android/drm/DrmStore$RightsStatus", AccessFlags = 9)]
				public partial class RightsStatus
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// RIGHTS_VALID
						/// </java-name>
						[Dot42.DexImport("RIGHTS_VALID", "I", AccessFlags = 25)]
						public const int RIGHTS_VALID = 0;
						/// <java-name>
						/// RIGHTS_INVALID
						/// </java-name>
						[Dot42.DexImport("RIGHTS_INVALID", "I", AccessFlags = 25)]
						public const int RIGHTS_INVALID = 1;
						/// <java-name>
						/// RIGHTS_EXPIRED
						/// </java-name>
						[Dot42.DexImport("RIGHTS_EXPIRED", "I", AccessFlags = 25)]
						public const int RIGHTS_EXPIRED = 2;
						/// <java-name>
						/// RIGHTS_NOT_ACQUIRED
						/// </java-name>
						[Dot42.DexImport("RIGHTS_NOT_ACQUIRED", "I", AccessFlags = 25)]
						public const int RIGHTS_NOT_ACQUIRED = 3;
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public RightsStatus() /* MethodBuilder.Create */ 
						{
						}

				}

				/// <java-name>
				/// android/drm/DrmStore$Action
				/// </java-name>
				[Dot42.DexImport("android/drm/DrmStore$Action", AccessFlags = 9)]
				public partial class Action
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// DEFAULT
						/// </java-name>
						[Dot42.DexImport("DEFAULT", "I", AccessFlags = 25)]
						public const int DEFAULT = 0;
						/// <java-name>
						/// PLAY
						/// </java-name>
						[Dot42.DexImport("PLAY", "I", AccessFlags = 25)]
						public const int PLAY = 1;
						/// <java-name>
						/// RINGTONE
						/// </java-name>
						[Dot42.DexImport("RINGTONE", "I", AccessFlags = 25)]
						public const int RINGTONE = 2;
						/// <java-name>
						/// TRANSFER
						/// </java-name>
						[Dot42.DexImport("TRANSFER", "I", AccessFlags = 25)]
						public const int TRANSFER = 3;
						/// <java-name>
						/// OUTPUT
						/// </java-name>
						[Dot42.DexImport("OUTPUT", "I", AccessFlags = 25)]
						public const int OUTPUT = 4;
						/// <java-name>
						/// PREVIEW
						/// </java-name>
						[Dot42.DexImport("PREVIEW", "I", AccessFlags = 25)]
						public const int PREVIEW = 5;
						/// <java-name>
						/// EXECUTE
						/// </java-name>
						[Dot42.DexImport("EXECUTE", "I", AccessFlags = 25)]
						public const int EXECUTE = 6;
						/// <java-name>
						/// DISPLAY
						/// </java-name>
						[Dot42.DexImport("DISPLAY", "I", AccessFlags = 25)]
						public const int DISPLAY = 7;
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public Action() /* MethodBuilder.Create */ 
						{
						}

				}

				/// <java-name>
				/// android/drm/DrmStore$Playback
				/// </java-name>
				[Dot42.DexImport("android/drm/DrmStore$Playback", AccessFlags = 9)]
				public partial class Playback
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// START
						/// </java-name>
						[Dot42.DexImport("START", "I", AccessFlags = 25)]
						public const int START = 0;
						/// <java-name>
						/// STOP
						/// </java-name>
						[Dot42.DexImport("STOP", "I", AccessFlags = 25)]
						public const int STOP = 1;
						/// <java-name>
						/// PAUSE
						/// </java-name>
						[Dot42.DexImport("PAUSE", "I", AccessFlags = 25)]
						public const int PAUSE = 2;
						/// <java-name>
						/// RESUME
						/// </java-name>
						[Dot42.DexImport("RESUME", "I", AccessFlags = 25)]
						public const int RESUME = 3;
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public Playback() /* MethodBuilder.Create */ 
						{
						}

				}

				/// <java-name>
				/// android/drm/DrmStore$DrmObjectType
				/// </java-name>
				[Dot42.DexImport("android/drm/DrmStore$DrmObjectType", AccessFlags = 9)]
				public partial class DrmObjectType
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// UNKNOWN
						/// </java-name>
						[Dot42.DexImport("UNKNOWN", "I", AccessFlags = 25)]
						public const int UNKNOWN = 0;
						/// <java-name>
						/// CONTENT
						/// </java-name>
						[Dot42.DexImport("CONTENT", "I", AccessFlags = 25)]
						public const int CONTENT = 1;
						/// <java-name>
						/// RIGHTS_OBJECT
						/// </java-name>
						[Dot42.DexImport("RIGHTS_OBJECT", "I", AccessFlags = 25)]
						public const int RIGHTS_OBJECT = 2;
						/// <java-name>
						/// TRIGGER_OBJECT
						/// </java-name>
						[Dot42.DexImport("TRIGGER_OBJECT", "I", AccessFlags = 25)]
						public const int TRIGGER_OBJECT = 3;
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public DrmObjectType() /* MethodBuilder.Create */ 
						{
						}

				}

				/// <java-name>
				/// android/drm/DrmStore$ConstraintsColumns
				/// </java-name>
				[Dot42.DexImport("android/drm/DrmStore$ConstraintsColumns", AccessFlags = 1545, IgnoreFromJava = true, Priority = 1)]
				public static partial class IConstraintsColumnsConstants
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// MAX_REPEAT_COUNT
						/// </java-name>
						[Dot42.DexImport("MAX_REPEAT_COUNT", "Ljava/lang/String;", AccessFlags = 25)]
						public const string MAX_REPEAT_COUNT = "max_repeat_count";
						/// <java-name>
						/// REMAINING_REPEAT_COUNT
						/// </java-name>
						[Dot42.DexImport("REMAINING_REPEAT_COUNT", "Ljava/lang/String;", AccessFlags = 25)]
						public const string REMAINING_REPEAT_COUNT = "remaining_repeat_count";
						/// <java-name>
						/// LICENSE_START_TIME
						/// </java-name>
						[Dot42.DexImport("LICENSE_START_TIME", "Ljava/lang/String;", AccessFlags = 25)]
						public const string LICENSE_START_TIME = "license_start_time";
						/// <java-name>
						/// LICENSE_EXPIRY_TIME
						/// </java-name>
						[Dot42.DexImport("LICENSE_EXPIRY_TIME", "Ljava/lang/String;", AccessFlags = 25)]
						public const string LICENSE_EXPIRY_TIME = "license_expiry_time";
						/// <java-name>
						/// LICENSE_AVAILABLE_TIME
						/// </java-name>
						[Dot42.DexImport("LICENSE_AVAILABLE_TIME", "Ljava/lang/String;", AccessFlags = 25)]
						public const string LICENSE_AVAILABLE_TIME = "license_available_time";
						/// <java-name>
						/// EXTENDED_METADATA
						/// </java-name>
						[Dot42.DexImport("EXTENDED_METADATA", "Ljava/lang/String;", AccessFlags = 25)]
						public const string EXTENDED_METADATA = "extended_metadata";
				}

				/// <java-name>
				/// android/drm/DrmStore$ConstraintsColumns
				/// </java-name>
				[Dot42.DexImport("android/drm/DrmStore$ConstraintsColumns", AccessFlags = 1545)]
				public partial interface IConstraintsColumns
 /* scope: __dot42__ */ 
				{
				}

		}

		/// <java-name>
		/// android/drm/DrmSupportInfo
		/// </java-name>
		[Dot42.DexImport("android/drm/DrmSupportInfo", AccessFlags = 33)]
		public partial class DrmSupportInfo
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public DrmSupportInfo() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addMimeType
				/// </java-name>
				[Dot42.DexImport("addMimeType", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void AddMimeType(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addFileSuffix
				/// </java-name>
				[Dot42.DexImport("addFileSuffix", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void AddFileSuffix(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setDescription
				/// </java-name>
				[Dot42.DexImport("setDescription", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetDescription(string @string) /* MethodBuilder.Create */ 
				{
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
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getMimeTypeIterator
				/// </java-name>
				public virtual global::Java.Util.IIterator<string> MimeTypeIterator
				{
						[Dot42.DexImport("getMimeTypeIterator", "()Ljava/util/Iterator;", AccessFlags = 1, Signature = "()Ljava/util/Iterator<Ljava/lang/String;>;")]
						get{ return default(global::Java.Util.IIterator<string>); }
				}

				/// <java-name>
				/// getFileSuffixIterator
				/// </java-name>
				public virtual global::Java.Util.IIterator<string> FileSuffixIterator
				{
						[Dot42.DexImport("getFileSuffixIterator", "()Ljava/util/Iterator;", AccessFlags = 1, Signature = "()Ljava/util/Iterator<Ljava/lang/String;>;")]
						get{ return default(global::Java.Util.IIterator<string>); }
				}

				/// <java-name>
				/// getDescriprition
				/// </java-name>
				public virtual string Descriprition
				{
						[Dot42.DexImport("getDescriprition", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

		}

		/// <java-name>
		/// android/drm/DrmUtils
		/// </java-name>
		[Dot42.DexImport("android/drm/DrmUtils", AccessFlags = 33)]
		public partial class DrmUtils
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public DrmUtils() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getExtendedMetadataParser
				/// </java-name>
				[Dot42.DexImport("getExtendedMetadataParser", "([B)Landroid/drm/DrmUtils$ExtendedMetadataParser;", AccessFlags = 9)]
				public static global::Android.Drm.DrmUtils.ExtendedMetadataParser GetExtendedMetadataParser(sbyte[] sByte) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Drm.DrmUtils.ExtendedMetadataParser);
				}

				/// <java-name>
				/// getExtendedMetadataParser
				/// </java-name>
				[Dot42.DexImport("getExtendedMetadataParser", "([B)Landroid/drm/DrmUtils$ExtendedMetadataParser;", AccessFlags = 9, IgnoreFromJava = true)]
				public static global::Android.Drm.DrmUtils.ExtendedMetadataParser GetExtendedMetadataParser(byte[] @byte) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Drm.DrmUtils.ExtendedMetadataParser);
				}

				/// <java-name>
				/// android/drm/DrmUtils$ExtendedMetadataParser
				/// </java-name>
				[Dot42.DexImport("android/drm/DrmUtils$ExtendedMetadataParser", AccessFlags = 9)]
				public partial class ExtendedMetadataParser
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
						internal ExtendedMetadataParser() /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// iterator
						/// </java-name>
						[Dot42.DexImport("iterator", "()Ljava/util/Iterator;", AccessFlags = 1, Signature = "()Ljava/util/Iterator<Ljava/lang/String;>;")]
						public virtual global::Java.Util.IIterator<string> Iterator() /* MethodBuilder.Create */ 
						{
								return default(global::Java.Util.IIterator<string>);
						}

						/// <java-name>
						/// keyIterator
						/// </java-name>
						[Dot42.DexImport("keyIterator", "()Ljava/util/Iterator;", AccessFlags = 1, Signature = "()Ljava/util/Iterator<Ljava/lang/String;>;")]
						public virtual global::Java.Util.IIterator<string> KeyIterator() /* MethodBuilder.Create */ 
						{
								return default(global::Java.Util.IIterator<string>);
						}

						/// <java-name>
						/// get
						/// </java-name>
						[Dot42.DexImport("get", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1)]
						public virtual string Get(string @string) /* MethodBuilder.Create */ 
						{
								return default(string);
						}

				}

		}

		/// <java-name>
		/// android/drm/ProcessedData
		/// </java-name>
		[Dot42.DexImport("android/drm/ProcessedData", AccessFlags = 33)]
		public partial class ProcessedData
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal ProcessedData() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getData
				/// </java-name>
				[Dot42.DexImport("getData", "()[B", AccessFlags = 1)]
				public virtual sbyte[] JavaGetData() /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <java-name>
				/// getData
				/// </java-name>
				public virtual byte[] Data
				{
						[Dot42.DexImport("getData", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
						get{ return default(byte[]); }
				}

				/// <java-name>
				/// getAccountId
				/// </java-name>
				public virtual string AccountId
				{
						[Dot42.DexImport("getAccountId", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getSubscriptionId
				/// </java-name>
				public virtual string SubscriptionId
				{
						[Dot42.DexImport("getSubscriptionId", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

		}

}

