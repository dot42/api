#pragma warning disable 1717
namespace Android.Drm
{
		/// <summary>
		///  <para>An entity class that wraps converted data, conversion status, and the offset for appending the header and body signature to the converted data. An instance of this class may be created two ways by the drm framework: a) a call to DrmManagerClient.convertData() and b) a call to DrmManagerClient.closeConvertSession(). An valid offset value is provided only from a success call to DrmManagerClient.closeConvertSession(). </para>    
		/// </summary>
		/// <java-name>
		/// android/drm/DrmConvertedStatus
		/// </java-name>
		[Dot42.DexImport("android/drm/DrmConvertedStatus", AccessFlags = 33)]
		public partial class DrmConvertedStatus
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Indicate the conversion status is successful. </para>        
				/// </summary>
				/// <java-name>
				/// STATUS_OK
				/// </java-name>
				[Dot42.DexImport("STATUS_OK", "I", AccessFlags = 25)]
				public const int STATUS_OK = 1;
				/// <summary>
				///  <para>Indicate a failed conversion status due to input data. </para>        
				/// </summary>
				/// <java-name>
				/// STATUS_INPUTDATA_ERROR
				/// </java-name>
				[Dot42.DexImport("STATUS_INPUTDATA_ERROR", "I", AccessFlags = 25)]
				public const int STATUS_INPUTDATA_ERROR = 2;
				/// <summary>
				///  <para>Indicate a general failed conversion status. </para>        
				/// </summary>
				/// <java-name>
				/// STATUS_ERROR
				/// </java-name>
				[Dot42.DexImport("STATUS_ERROR", "I", AccessFlags = 25)]
				public const int STATUS_ERROR = 3;
				/// <summary>
				///  <para>Status code for the conversion. Must be one of the defined status constants above. </para>        
				/// </summary>
				/// <java-name>
				/// statusCode
				/// </java-name>
				[Dot42.DexImport("statusCode", "I", AccessFlags = 17)]
				public readonly int StatusCode;
				/// <summary>
				///  <para>Converted data. It is optional and thus can be null. </para>        
				/// </summary>
				/// <java-name>
				/// convertedData
				/// </java-name>
				[Dot42.DexImport("convertedData", "[B", AccessFlags = 17)]
				public readonly sbyte[] ConvertedData;
				/// <summary>
				///  <para>Offset value for the body and header signature. </para>        
				/// </summary>
				/// <java-name>
				/// offset
				/// </java-name>
				[Dot42.DexImport("offset", "I", AccessFlags = 17)]
				public readonly int Offset;
				/// <summary>
				///  <para>Creates a  <code>DrmConvertedStatus</code> object with the specified parameters.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(I[BI)V", AccessFlags = 1, IgnoreFromJava = true)]
				public DrmConvertedStatus(int statusCode, sbyte[] convertedData, int offset) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Creates a  <code>DrmConvertedStatus</code> object with the specified parameters.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(I[BI)V", AccessFlags = 1)]
				public DrmConvertedStatus(int statusCode, byte[] convertedData, int offset) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal DrmConvertedStatus() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		///  <para>An entity class that is passed to the onError() callback. </para>    
		/// </summary>
		/// <java-name>
		/// android/drm/DrmErrorEvent
		/// </java-name>
		[Dot42.DexImport("android/drm/DrmErrorEvent", AccessFlags = 33)]
		public partial class DrmErrorEvent : global::Android.Drm.DrmEvent
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Something went wrong installing the rights. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_RIGHTS_NOT_INSTALLED
				/// </java-name>
				[Dot42.DexImport("TYPE_RIGHTS_NOT_INSTALLED", "I", AccessFlags = 25)]
				public const int TYPE_RIGHTS_NOT_INSTALLED = 2001;
				/// <summary>
				///  <para>The server rejected the renewal of rights. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_RIGHTS_RENEWAL_NOT_ALLOWED
				/// </java-name>
				[Dot42.DexImport("TYPE_RIGHTS_RENEWAL_NOT_ALLOWED", "I", AccessFlags = 25)]
				public const int TYPE_RIGHTS_RENEWAL_NOT_ALLOWED = 2002;
				/// <summary>
				///  <para>Response from the server cannot be handled by the DRM plug-in (agent). </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_NOT_SUPPORTED
				/// </java-name>
				[Dot42.DexImport("TYPE_NOT_SUPPORTED", "I", AccessFlags = 25)]
				public const int TYPE_NOT_SUPPORTED = 2003;
				/// <summary>
				///  <para>Memory allocation failed during renewal. Can in the future perhaps be used to trigger garbage collector. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_OUT_OF_MEMORY
				/// </java-name>
				[Dot42.DexImport("TYPE_OUT_OF_MEMORY", "I", AccessFlags = 25)]
				public const int TYPE_OUT_OF_MEMORY = 2004;
				/// <summary>
				///  <para>An Internet connection is not available and no attempt can be made to renew rights. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_NO_INTERNET_CONNECTION
				/// </java-name>
				[Dot42.DexImport("TYPE_NO_INTERNET_CONNECTION", "I", AccessFlags = 25)]
				public const int TYPE_NO_INTERNET_CONNECTION = 2005;
				/// <summary>
				///  <para>Failed to process DrmInfo. This error event is sent when a processDrmInfo() call fails. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_PROCESS_DRM_INFO_FAILED
				/// </java-name>
				[Dot42.DexImport("TYPE_PROCESS_DRM_INFO_FAILED", "I", AccessFlags = 25)]
				public const int TYPE_PROCESS_DRM_INFO_FAILED = 2006;
				/// <summary>
				///  <para>Failed to remove all the rights objects associated with all DRM schemes. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_REMOVE_ALL_RIGHTS_FAILED
				/// </java-name>
				[Dot42.DexImport("TYPE_REMOVE_ALL_RIGHTS_FAILED", "I", AccessFlags = 25)]
				public const int TYPE_REMOVE_ALL_RIGHTS_FAILED = 2007;
				/// <summary>
				///  <para>Creates a  <code>DrmErrorEvent</code> object with the specified parameters.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(IILjava/lang/String;)V", AccessFlags = 1)]
				public DrmErrorEvent(int uniqueId, int type, string message) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal DrmErrorEvent() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		///  <para>A base class that is used to send asynchronous event information from the DRM framework. </para>    
		/// </summary>
		/// <java-name>
		/// android/drm/DrmEvent
		/// </java-name>
		[Dot42.DexImport("android/drm/DrmEvent", AccessFlags = 33)]
		public partial class DrmEvent
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>All of the rights information associated with all DRM schemes have been successfully removed. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_ALL_RIGHTS_REMOVED
				/// </java-name>
				[Dot42.DexImport("TYPE_ALL_RIGHTS_REMOVED", "I", AccessFlags = 25)]
				public const int TYPE_ALL_RIGHTS_REMOVED = 1001;
				/// <summary>
				///  <para>The given DRM information has been successfully processed. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_DRM_INFO_PROCESSED
				/// </java-name>
				[Dot42.DexImport("TYPE_DRM_INFO_PROCESSED", "I", AccessFlags = 25)]
				public const int TYPE_DRM_INFO_PROCESSED = 1002;
				/// <summary>
				///  <para>The key that is used in the  <code>attributes</code> HashMap to pass the return status. </para>        
				/// </summary>
				/// <java-name>
				/// DRM_INFO_STATUS_OBJECT
				/// </java-name>
				[Dot42.DexImport("DRM_INFO_STATUS_OBJECT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string DRM_INFO_STATUS_OBJECT = "drm_info_status_object";
				/// <summary>
				///  <para>Creates a  <code>DrmEvent</code> object with the specified parameters.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(IILjava/lang/String;)V", AccessFlags = 4)]
				protected internal DrmEvent(int uniqueId, int type, string message) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal DrmEvent() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Retrieves the unique session identifier associated with this object.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The unique session identifier. </para>
				/// </returns>
				/// <java-name>
				/// getUniqueId
				/// </java-name>
				public virtual int UniqueId
				{
						[Dot42.DexImport("getUniqueId", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Retrieves the type of information that is associated with this object.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The type of information. </para>
				/// </returns>
				/// <java-name>
				/// getType
				/// </java-name>
				public virtual int Type
				{
						[Dot42.DexImport("getType", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Retrieves the message description associated with this object.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The message description. </para>
				/// </returns>
				/// <java-name>
				/// getMessage
				/// </java-name>
				public virtual string Message
				{
						[Dot42.DexImport("getMessage", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

		}

		/// <summary>
		///  <para>An entity class that describes the information required to send transactions between a device and an online DRM server. The DRM framework achieves server registration, license acquisition, and any other server-related transactions by passing an instance of this class to DrmManagerClient#processDrmInfo. </para> <para>The caller can retrieve the DrmInfo instance by passing a DrmInfoRequest instance to DrmManagerClient#acquireDrmInfo. </para>    
		/// </summary>
		/// <java-name>
		/// android/drm/DrmInfo
		/// </java-name>
		[Dot42.DexImport("android/drm/DrmInfo", AccessFlags = 33)]
		public partial class DrmInfo
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(I[BLjava/lang/String;)V", AccessFlags = 1, IgnoreFromJava = true)]
				public DrmInfo(int int32, sbyte[] sByte, string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(I[BLjava/lang/String;)V", AccessFlags = 1)]
				public DrmInfo(int int32, byte[] @byte, string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(ILjava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public DrmInfo(int int32, string @string, string string1) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Adds optional information as key-value pairs to this object. To add a custom object to the  <code>DrmInfo</code> object, you must override the toString implementation.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "(Ljava/lang/String;Ljava/lang/Object;)V", AccessFlags = 1)]
				public virtual void Put(string key, object value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Retrieves the value of a given key.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The value of the key being retrieved. Returns null if the key cannot be found. </para>
				/// </returns>
				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(Ljava/lang/String;)Ljava/lang/Object;", AccessFlags = 1)]
				public virtual object Get(string key) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <summary>
				///  <para>Retrieves an iterator object that you can use to iterate over the keys associated with this  <code>DrmInfo</code> object.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The iterator object. </para>
				/// </returns>
				/// <java-name>
				/// keyIterator
				/// </java-name>
				[Dot42.DexImport("keyIterator", "()Ljava/util/Iterator;", AccessFlags = 1, Signature = "()Ljava/util/Iterator<Ljava/lang/String;>;")]
				public virtual global::Java.Util.IIterator<string> KeyIterator() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IIterator<string>);
				}

				/// <summary>
				///  <para>Retrieves an iterator object that you can use to iterate over the values associated with this  <code>DrmInfo</code> object.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The iterator object. </para>
				/// </returns>
				/// <java-name>
				/// iterator
				/// </java-name>
				[Dot42.DexImport("iterator", "()Ljava/util/Iterator;", AccessFlags = 1, Signature = "()Ljava/util/Iterator<Ljava/lang/Object;>;")]
				public virtual global::Java.Util.IIterator<object> Iterator() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IIterator<object>);
				}

				/// <summary>
				///  <para>Retrieves the trigger data associated with this object.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The trigger data. </para>
				/// </returns>
				/// <java-name>
				/// getData
				/// </java-name>
				[Dot42.DexImport("getData", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual sbyte[] JavaGetData() /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal DrmInfo() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Retrieves the trigger data associated with this object.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The trigger data. </para>
				/// </returns>
				/// <java-name>
				/// getData
				/// </java-name>
				public virtual byte[] Data
				{
						[Dot42.DexImport("getData", "()[B", AccessFlags = 1)]
						get{ return default(byte[]); }
				}

				/// <summary>
				///  <para>Retrieves the MIME type associated with this object.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The MIME type. </para>
				/// </returns>
				/// <java-name>
				/// getMimeType
				/// </java-name>
				public virtual string MimeType
				{
						[Dot42.DexImport("getMimeType", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>Retrieves the information type associated with this object.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The information type. </para>
				/// </returns>
				/// <java-name>
				/// getInfoType
				/// </java-name>
				public virtual int InfoType
				{
						[Dot42.DexImport("getInfoType", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

		}

		/// <summary>
		///  <para>An entity class that is passed to the onInfo() callback. </para>    
		/// </summary>
		/// <java-name>
		/// android/drm/DrmInfoEvent
		/// </java-name>
		[Dot42.DexImport("android/drm/DrmInfoEvent", AccessFlags = 33)]
		public partial class DrmInfoEvent : global::Android.Drm.DrmEvent
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>The registration has already been done by another account ID. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_ALREADY_REGISTERED_BY_ANOTHER_ACCOUNT
				/// </java-name>
				[Dot42.DexImport("TYPE_ALREADY_REGISTERED_BY_ANOTHER_ACCOUNT", "I", AccessFlags = 25)]
				public const int TYPE_ALREADY_REGISTERED_BY_ANOTHER_ACCOUNT = 1;
				/// <summary>
				///  <para>The rights need to be removed completely. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_REMOVE_RIGHTS
				/// </java-name>
				[Dot42.DexImport("TYPE_REMOVE_RIGHTS", "I", AccessFlags = 25)]
				public const int TYPE_REMOVE_RIGHTS = 2;
				/// <summary>
				///  <para>The rights have been successfully downloaded and installed. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_RIGHTS_INSTALLED
				/// </java-name>
				[Dot42.DexImport("TYPE_RIGHTS_INSTALLED", "I", AccessFlags = 25)]
				public const int TYPE_RIGHTS_INSTALLED = 3;
				/// <summary>
				///  <para>The rights object is being delivered to the device. You must wait before calling acquireRights() again. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_WAIT_FOR_RIGHTS
				/// </java-name>
				[Dot42.DexImport("TYPE_WAIT_FOR_RIGHTS", "I", AccessFlags = 25)]
				public const int TYPE_WAIT_FOR_RIGHTS = 4;
				/// <summary>
				///  <para>The registration has already been done for the given account. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_ACCOUNT_ALREADY_REGISTERED
				/// </java-name>
				[Dot42.DexImport("TYPE_ACCOUNT_ALREADY_REGISTERED", "I", AccessFlags = 25)]
				public const int TYPE_ACCOUNT_ALREADY_REGISTERED = 5;
				/// <summary>
				///  <para>Creates a  <code>DrmInfoEvent</code> object with the specified parameters.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(IILjava/lang/String;)V", AccessFlags = 1)]
				public DrmInfoEvent(int uniqueId, int type, string message) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal DrmInfoEvent() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		///  <para>An entity class that is used to pass information to an online DRM server. An instance of this class is passed to the acquireDrmInfo() method to get an instance of a DrmInfo. </para>    
		/// </summary>
		/// <java-name>
		/// android/drm/DrmInfoRequest
		/// </java-name>
		[Dot42.DexImport("android/drm/DrmInfoRequest", AccessFlags = 33)]
		public partial class DrmInfoRequest
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Acquires DRM server registration information. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_REGISTRATION_INFO
				/// </java-name>
				[Dot42.DexImport("TYPE_REGISTRATION_INFO", "I", AccessFlags = 25)]
				public const int TYPE_REGISTRATION_INFO = 1;
				/// <summary>
				///  <para>Acquires information for unregistering the DRM server. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_UNREGISTRATION_INFO
				/// </java-name>
				[Dot42.DexImport("TYPE_UNREGISTRATION_INFO", "I", AccessFlags = 25)]
				public const int TYPE_UNREGISTRATION_INFO = 2;
				/// <summary>
				///  <para>Acquires rights information. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_RIGHTS_ACQUISITION_INFO
				/// </java-name>
				[Dot42.DexImport("TYPE_RIGHTS_ACQUISITION_INFO", "I", AccessFlags = 25)]
				public const int TYPE_RIGHTS_ACQUISITION_INFO = 3;
				/// <summary>
				///  <para>Acquires the progress of the rights acquisition. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_RIGHTS_ACQUISITION_PROGRESS_INFO
				/// </java-name>
				[Dot42.DexImport("TYPE_RIGHTS_ACQUISITION_PROGRESS_INFO", "I", AccessFlags = 25)]
				public const int TYPE_RIGHTS_ACQUISITION_PROGRESS_INFO = 4;
				/// <summary>
				///  <para>Key that is used to pass the unique session ID for the account or the user. </para>        
				/// </summary>
				/// <java-name>
				/// ACCOUNT_ID
				/// </java-name>
				[Dot42.DexImport("ACCOUNT_ID", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACCOUNT_ID = "account_id";
				/// <summary>
				///  <para>Key that is used to pass the unique session ID for the subscription. </para>        
				/// </summary>
				/// <java-name>
				/// SUBSCRIPTION_ID
				/// </java-name>
				[Dot42.DexImport("SUBSCRIPTION_ID", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SUBSCRIPTION_ID = "subscription_id";
				/// <summary>
				///  <para>Creates a  <code>DrmInfoRequest</code> object with type and MIME type.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(ILjava/lang/String;)V", AccessFlags = 1)]
				public DrmInfoRequest(int infoType, string mimeType) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Adds optional information as key-value pairs to this object.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "(Ljava/lang/String;Ljava/lang/Object;)V", AccessFlags = 1)]
				public virtual void Put(string key, object value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Retrieves the value of a given key.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The value of the key that is being retrieved. Returns null if the key cannot be found. </para>
				/// </returns>
				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(Ljava/lang/String;)Ljava/lang/Object;", AccessFlags = 1)]
				public virtual object Get(string key) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <summary>
				///  <para>Retrieves an iterator object that you can use to iterate over the keys associated with this  <code>DrmInfoRequest</code> object.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The iterator object. </para>
				/// </returns>
				/// <java-name>
				/// keyIterator
				/// </java-name>
				[Dot42.DexImport("keyIterator", "()Ljava/util/Iterator;", AccessFlags = 1, Signature = "()Ljava/util/Iterator<Ljava/lang/String;>;")]
				public virtual global::Java.Util.IIterator<string> KeyIterator() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IIterator<string>);
				}

				/// <summary>
				///  <para>Retrieves an iterator object that you can use to iterate over the values associated with this  <code>DrmInfoRequest</code> object.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The iterator object. </para>
				/// </returns>
				/// <java-name>
				/// iterator
				/// </java-name>
				[Dot42.DexImport("iterator", "()Ljava/util/Iterator;", AccessFlags = 1, Signature = "()Ljava/util/Iterator<Ljava/lang/Object;>;")]
				public virtual global::Java.Util.IIterator<object> Iterator() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IIterator<object>);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal DrmInfoRequest() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Retrieves the MIME type associated with this object.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The MIME type. </para>
				/// </returns>
				/// <java-name>
				/// getMimeType
				/// </java-name>
				public virtual string MimeType
				{
						[Dot42.DexImport("getMimeType", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>Retrieves the information type associated with this object.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The information type. </para>
				/// </returns>
				/// <java-name>
				/// getInfoType
				/// </java-name>
				public virtual int InfoType
				{
						[Dot42.DexImport("getInfoType", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

		}

		/// <summary>
		///  <para>An entity class that wraps the result of communication between a device and an online DRM server. Specifically, when the DrmManagerClient.processDrmInfo() method is called, an instance of  <code>DrmInfoStatus</code> is returned. </para> <para>This class contains the ProcessedData object, which can be used to instantiate a DrmRights object during license acquisition. </para>    
		/// </summary>
		/// <java-name>
		/// android/drm/DrmInfoStatus
		/// </java-name>
		[Dot42.DexImport("android/drm/DrmInfoStatus", AccessFlags = 33)]
		public partial class DrmInfoStatus
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Indicate successful communication. </para>        
				/// </summary>
				/// <java-name>
				/// STATUS_OK
				/// </java-name>
				[Dot42.DexImport("STATUS_OK", "I", AccessFlags = 25)]
				public const int STATUS_OK = 1;
				/// <summary>
				///  <para>Indicate failed communication. </para>        
				/// </summary>
				/// <java-name>
				/// STATUS_ERROR
				/// </java-name>
				[Dot42.DexImport("STATUS_ERROR", "I", AccessFlags = 25)]
				public const int STATUS_ERROR = 2;
				/// <summary>
				///  <para>The status of the communication. Must be one of the defined status constants above. </para>        
				/// </summary>
				/// <java-name>
				/// statusCode
				/// </java-name>
				[Dot42.DexImport("statusCode", "I", AccessFlags = 17)]
				public readonly int StatusCode;
				/// <summary>
				///  <para>The type of DRM information processed. Must be one of the valid type constants defined in DrmInfoRequest. </para>        
				/// </summary>
				/// <java-name>
				/// infoType
				/// </java-name>
				[Dot42.DexImport("infoType", "I", AccessFlags = 17)]
				public readonly int InfoType;
				/// <summary>
				///  <para>The MIME type of the content. Must not be null or an empty string. </para>        
				/// </summary>
				/// <java-name>
				/// mimeType
				/// </java-name>
				[Dot42.DexImport("mimeType", "Ljava/lang/String;", AccessFlags = 17)]
				public readonly string MimeType;
				/// <summary>
				///  <para>The processed data. It is optional and thus could be null. When it is null, it indicates that a particular call to DrmManagerClient.processDrmInfo() does not return any additional useful information except for the status code. </para>        
				/// </summary>
				/// <java-name>
				/// data
				/// </java-name>
				[Dot42.DexImport("data", "Landroid/drm/ProcessedData;", AccessFlags = 17)]
				public readonly global::Android.Drm.ProcessedData Data;
				/// <summary>
				///  <para>Creates a  <code>DrmInfoStatus</code> object with the specified parameters.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(IILandroid/drm/ProcessedData;Ljava/lang/String;)V", AccessFlags = 1)]
				public DrmInfoStatus(int statusCode, int infoType, global::Android.Drm.ProcessedData data, string mimeType) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal DrmInfoStatus() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		///  <para>The main programming interface for the DRM framework. An application must instantiate this class to access DRM agents through the DRM framework. </para>    
		/// </summary>
		/// <java-name>
		/// android/drm/DrmManagerClient
		/// </java-name>
		[Dot42.DexImport("android/drm/DrmManagerClient", AccessFlags = 33)]
		public partial class DrmManagerClient
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Indicates that a request was successful or that no error occurred. </para>        
				/// </summary>
				/// <java-name>
				/// ERROR_NONE
				/// </java-name>
				[Dot42.DexImport("ERROR_NONE", "I", AccessFlags = 25)]
				public const int ERROR_NONE = 0;
				/// <summary>
				///  <para>Indicates that an error occurred and the reason is not known. </para>        
				/// </summary>
				/// <java-name>
				/// ERROR_UNKNOWN
				/// </java-name>
				[Dot42.DexImport("ERROR_UNKNOWN", "I", AccessFlags = 25)]
				public const int ERROR_UNKNOWN = -2000;
				/// <summary>
				///  <para>Creates a  <code>DrmManagerClient</code>.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public DrmManagerClient(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// finalize
				/// </java-name>
				[Dot42.DexImport("finalize", "()V", AccessFlags = 4)]
				extern ~DrmManagerClient() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Registers an DrmManagerClient.OnInfoListener callback, which is invoked when the DRM framework sends status or warning information during registration or rights acquisition.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setOnInfoListener
				/// </java-name>
				[Dot42.DexImport("setOnInfoListener", "(Landroid/drm/DrmManagerClient$OnInfoListener;)V", AccessFlags = 33)]
				public virtual void SetOnInfoListener(global::Android.Drm.DrmManagerClient.IOnInfoListener infoListener) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Registers an DrmManagerClient.OnEventListener callback, which is invoked when the DRM framework sends information about DRM processing.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setOnEventListener
				/// </java-name>
				[Dot42.DexImport("setOnEventListener", "(Landroid/drm/DrmManagerClient$OnEventListener;)V", AccessFlags = 33)]
				public virtual void SetOnEventListener(global::Android.Drm.DrmManagerClient.IOnEventListener eventListener) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Registers an DrmManagerClient.OnErrorListener callback, which is invoked when the DRM framework sends error information.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setOnErrorListener
				/// </java-name>
				[Dot42.DexImport("setOnErrorListener", "(Landroid/drm/DrmManagerClient$OnErrorListener;)V", AccessFlags = 33)]
				public virtual void SetOnErrorListener(global::Android.Drm.DrmManagerClient.IOnErrorListener errorListener) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Retrieves constraint information for rights-protected content.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>A android.content.ContentValues instance that contains key-value pairs representing the constraints. Null in case of failure. </para>
				/// </returns>
				/// <java-name>
				/// getConstraints
				/// </java-name>
				[Dot42.DexImport("getConstraints", "(Ljava/lang/String;I)Landroid/content/ContentValues;", AccessFlags = 1)]
				public virtual global::Android.Content.ContentValues GetConstraints(string uri, int action) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.ContentValues);
				}

				/// <summary>
				///  <para>Retrieves metadata information for rights-protected content.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>A android.content.ContentValues instance that contains key-value pairs representing the constraints. Null in case of failure. </para>
				/// </returns>
				/// <java-name>
				/// getMetadata
				/// </java-name>
				[Dot42.DexImport("getMetadata", "(Ljava/lang/String;)Landroid/content/ContentValues;", AccessFlags = 1)]
				public virtual global::Android.Content.ContentValues GetMetadata(string uri) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.ContentValues);
				}

				/// <summary>
				///  <para>Retrieves constraint information for rights-protected content.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>A android.content.ContentValues instance that contains key-value pairs representing the constraints. Null in case of failure. </para>
				/// </returns>
				/// <java-name>
				/// getConstraints
				/// </java-name>
				[Dot42.DexImport("getConstraints", "(Landroid/net/Uri;I)Landroid/content/ContentValues;", AccessFlags = 1)]
				public virtual global::Android.Content.ContentValues GetConstraints(global::Android.Net.Uri uri, int action) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.ContentValues);
				}

				/// <summary>
				///  <para>Retrieves metadata information for rights-protected content.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>A android.content.ContentValues instance that contains key-value pairs representing the constraints. Null in case of failure. </para>
				/// </returns>
				/// <java-name>
				/// getMetadata
				/// </java-name>
				[Dot42.DexImport("getMetadata", "(Landroid/net/Uri;)Landroid/content/ContentValues;", AccessFlags = 1)]
				public virtual global::Android.Content.ContentValues GetMetadata(global::Android.Net.Uri uri) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.ContentValues);
				}

				/// <summary>
				///  <para>Saves rights to a specified path and associates that path with the content path.</para> <para> <b>Note:</b> For OMA or WM-DRM,  <code>rightsPath</code> and  <code>contentPath</code> can be null.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>ERROR_NONE for success; ERROR_UNKNOWN for failure.</para>
				/// </returns>
				/// <java-name>
				/// saveRights
				/// </java-name>
				[Dot42.DexImport("saveRights", "(Landroid/drm/DrmRights;Ljava/lang/String;Ljava/lang/String;)I", AccessFlags = 1)]
				public virtual int SaveRights(global::Android.Drm.DrmRights drmRights, string rightsPath, string contentPath) /* MethodBuilder.Create */ 
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

				/// <summary>
				///  <para>Processes the given DRM information based on the information type.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>ERROR_NONE for success; ERROR_UNKNOWN for failure. </para>
				/// </returns>
				/// <java-name>
				/// processDrmInfo
				/// </java-name>
				[Dot42.DexImport("processDrmInfo", "(Landroid/drm/DrmInfo;)I", AccessFlags = 1)]
				public virtual int ProcessDrmInfo(global::Android.Drm.DrmInfo drmInfo) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Retrieves information for registering, unregistering, or acquiring rights.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>A DrmInfo instance. </para>
				/// </returns>
				/// <java-name>
				/// acquireDrmInfo
				/// </java-name>
				[Dot42.DexImport("acquireDrmInfo", "(Landroid/drm/DrmInfoRequest;)Landroid/drm/DrmInfo;", AccessFlags = 1)]
				public virtual global::Android.Drm.DrmInfo AcquireDrmInfo(global::Android.Drm.DrmInfoRequest drmInfoRequest) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Drm.DrmInfo);
				}

				/// <summary>
				///  <para>Processes a given DrmInfoRequest and returns the rights information asynchronously. </para> <para>This is a utility method that consists of an acquireDrmInfo() and a processDrmInfo() method call. This utility method can be used only if the selected DRM plug-in (agent) supports this sequence of calls. Some DRM agents, such as OMA, do not support this utility method, in which case an application must invoke acquireDrmInfo() and processDrmInfo() separately.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>ERROR_NONE for success; ERROR_UNKNOWN for failure. </para>
				/// </returns>
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

				/// <summary>
				///  <para>Retrieves the MIME type embedded in the original content.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>MIME type of the original content, such as  <code>video/mpeg</code>. </para>
				/// </returns>
				/// <java-name>
				/// getOriginalMimeType
				/// </java-name>
				[Dot42.DexImport("getOriginalMimeType", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetOriginalMimeType(string uri) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Retrieves the MIME type embedded in the original content.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>MIME type of the original content, such as  <code>video/mpeg</code>. </para>
				/// </returns>
				/// <java-name>
				/// getOriginalMimeType
				/// </java-name>
				[Dot42.DexImport("getOriginalMimeType", "(Landroid/net/Uri;)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetOriginalMimeType(global::Android.Net.Uri uri) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Check whether the given content has valid rights.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>An  <code>int</code> representing the DrmStore.RightsStatus of the content. </para>
				/// </returns>
				/// <java-name>
				/// checkRightsStatus
				/// </java-name>
				[Dot42.DexImport("checkRightsStatus", "(Ljava/lang/String;)I", AccessFlags = 1)]
				public virtual int CheckRightsStatus(string uri) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Check whether the given content has valid rights.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>An  <code>int</code> representing the DrmStore.RightsStatus of the content. </para>
				/// </returns>
				/// <java-name>
				/// checkRightsStatus
				/// </java-name>
				[Dot42.DexImport("checkRightsStatus", "(Landroid/net/Uri;)I", AccessFlags = 1)]
				public virtual int CheckRightsStatus(global::Android.Net.Uri uri) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Checks whether the given rights-protected content has valid rights for the specified DrmStore.Action.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>An  <code>int</code> representing the DrmStore.RightsStatus of the content. </para>
				/// </returns>
				/// <java-name>
				/// checkRightsStatus
				/// </java-name>
				[Dot42.DexImport("checkRightsStatus", "(Ljava/lang/String;I)I", AccessFlags = 1)]
				public virtual int CheckRightsStatus(string uri, int action) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Checks whether the given rights-protected content has valid rights for the specified DrmStore.Action.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>An  <code>int</code> representing the DrmStore.RightsStatus of the content. </para>
				/// </returns>
				/// <java-name>
				/// checkRightsStatus
				/// </java-name>
				[Dot42.DexImport("checkRightsStatus", "(Landroid/net/Uri;I)I", AccessFlags = 1)]
				public virtual int CheckRightsStatus(global::Android.Net.Uri uri, int action) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Removes the rights associated with the given rights-protected content.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>ERROR_NONE for success; ERROR_UNKNOWN for failure. </para>
				/// </returns>
				/// <java-name>
				/// removeRights
				/// </java-name>
				[Dot42.DexImport("removeRights", "(Ljava/lang/String;)I", AccessFlags = 1)]
				public virtual int RemoveRights(string uri) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Removes the rights associated with the given rights-protected content.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>ERROR_NONE for success; ERROR_UNKNOWN for failure. </para>
				/// </returns>
				/// <java-name>
				/// removeRights
				/// </java-name>
				[Dot42.DexImport("removeRights", "(Landroid/net/Uri;)I", AccessFlags = 1)]
				public virtual int RemoveRights(global::Android.Net.Uri uri) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Removes all the rights information of every DRM plug-in (agent) associated with the DRM framework. Will be used during a master reset.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>ERROR_NONE for success; ERROR_UNKNOWN for failure. </para>
				/// </returns>
				/// <java-name>
				/// removeAllRights
				/// </java-name>
				[Dot42.DexImport("removeAllRights", "()I", AccessFlags = 1)]
				public virtual int RemoveAllRights() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Initiates a new conversion session. An application must initiate a conversion session with this method each time it downloads a rights-protected file that needs to be converted. </para> <para>This method applies only to forward-locking (copy protection) DRM schemes.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>A convert ID that is used used to maintain the conversion session. </para>
				/// </returns>
				/// <java-name>
				/// openConvertSession
				/// </java-name>
				[Dot42.DexImport("openConvertSession", "(Ljava/lang/String;)I", AccessFlags = 1)]
				public virtual int OpenConvertSession(string mimeType) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Converts the input data (content) that is part of a rights-protected file. The converted data and status is returned in a DrmConvertedStatus object. This method should be called each time there is a new block of data received by the application.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>A DrmConvertedStatus object that contains the status of the data conversion, the converted data, and offset for the header and body signature. An application can ignore the offset because it is only relevant to the closeConvertSession() method. </para>
				/// </returns>
				/// <java-name>
				/// convertData
				/// </java-name>
				[Dot42.DexImport("convertData", "(I[B)Landroid/drm/DrmConvertedStatus;", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual global::Android.Drm.DrmConvertedStatus ConvertData(int convertId, sbyte[] inputData) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Drm.DrmConvertedStatus);
				}

				/// <summary>
				///  <para>Converts the input data (content) that is part of a rights-protected file. The converted data and status is returned in a DrmConvertedStatus object. This method should be called each time there is a new block of data received by the application.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>A DrmConvertedStatus object that contains the status of the data conversion, the converted data, and offset for the header and body signature. An application can ignore the offset because it is only relevant to the closeConvertSession() method. </para>
				/// </returns>
				/// <java-name>
				/// convertData
				/// </java-name>
				[Dot42.DexImport("convertData", "(I[B)Landroid/drm/DrmConvertedStatus;", AccessFlags = 1)]
				public virtual global::Android.Drm.DrmConvertedStatus ConvertData(int convertId, byte[] inputData) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Drm.DrmConvertedStatus);
				}

				/// <summary>
				///  <para>Informs the DRM plug-in (agent) that there is no more data to convert or that an error has occurred. Upon successful conversion of the data, the DRM agent will provide an offset value indicating where the header and body signature should be added. Appending the signature is necessary to protect the integrity of the converted file.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>A DrmConvertedStatus object that contains the status of the data conversion, the converted data, and the offset for the header and body signature. </para>
				/// </returns>
				/// <java-name>
				/// closeConvertSession
				/// </java-name>
				[Dot42.DexImport("closeConvertSession", "(I)Landroid/drm/DrmConvertedStatus;", AccessFlags = 1)]
				public virtual global::Android.Drm.DrmConvertedStatus CloseConvertSession(int convertId) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Drm.DrmConvertedStatus);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal DrmManagerClient() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Retrieves information about all the DRM plug-ins (agents) that are registered with the DRM framework.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>A  <code>String</code> array of DRM plug-in descriptions. </para>
				/// </returns>
				/// <java-name>
				/// getAvailableDrmEngines
				/// </java-name>
				public virtual string[] AvailableDrmEngines
				{
						[Dot42.DexImport("getAvailableDrmEngines", "()[Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string[]); }
				}

				/// <summary>
				///  <para>Interface definition for a callback that receives information about DRM framework errors. </para>    
				/// </summary>
				/// <java-name>
				/// android/drm/DrmManagerClient$OnErrorListener
				/// </java-name>
				[Dot42.DexImport("android/drm/DrmManagerClient$OnErrorListener", AccessFlags = 1545)]
				public partial interface IOnErrorListener
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>Called when the DRM framework sends error information.</para> <para></para>        
						/// </summary>
						/// <java-name>
						/// onError
						/// </java-name>
						[Dot42.DexImport("onError", "(Landroid/drm/DrmManagerClient;Landroid/drm/DrmErrorEvent;)V", AccessFlags = 1025)]
						void OnError(global::Android.Drm.DrmManagerClient client, global::Android.Drm.DrmErrorEvent @event) /* MethodBuilder.Create */ ;

				}

				/// <summary>
				///  <para>Interface definition for a callback that receives information about DRM processing events. </para>    
				/// </summary>
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
						[Dot42.DexImport("onEvent", "(Landroid/drm/DrmManagerClient;Landroid/drm/DrmEvent;Ljava/util/HashMap;)V", AccessFlags = 1025, Signature = "(Landroid/drm/DrmManagerClient;Landroid/drm/DrmEvent;Ljava/util/HashMap<Ljava/lan" +
    "g/String;Ljava/lang/Object;>;)V")]
						void OnEvent(global::Android.Drm.DrmManagerClient drmManagerClient, global::Android.Drm.DrmEvent drmEvent, global::Java.Util.HashMap<string, object> hashMap) /* MethodBuilder.Create */ ;

				}

				/// <summary>
				///  <para>Interface definition for a callback that receives status messages and warnings during registration and rights acquisition. </para>    
				/// </summary>
				/// <java-name>
				/// android/drm/DrmManagerClient$OnInfoListener
				/// </java-name>
				[Dot42.DexImport("android/drm/DrmManagerClient$OnInfoListener", AccessFlags = 1545)]
				public partial interface IOnInfoListener
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>Called when the DRM framework sends status or warning information during registration and rights acquisition.</para> <para></para>        
						/// </summary>
						/// <java-name>
						/// onInfo
						/// </java-name>
						[Dot42.DexImport("onInfo", "(Landroid/drm/DrmManagerClient;Landroid/drm/DrmInfoEvent;)V", AccessFlags = 1025)]
						void OnInfo(global::Android.Drm.DrmManagerClient client, global::Android.Drm.DrmInfoEvent @event) /* MethodBuilder.Create */ ;

				}

		}

		/// <summary>
		///  <para>An entity class that wraps the license information retrieved from the online DRM server. </para> <para>A caller can instantiate a DrmRights object by first invoking the DrmManagerClient#processDrmInfo(DrmInfo) method and then using the resulting ProcessedData object to invoke the DrmRights#DrmRights(ProcessedData, String) constructor. </para> <para>A caller can also instantiate a DrmRights object by using the DrmRights#DrmRights(String, String) constructor, which takes a path to a file containing rights information instead of a  <code>ProcessedData</code>. </para> <para>Please note that the account id and subscription id is not mandatory by all DRM agents or plugins. When account id or subscription id is not required by the specific DRM agent or plugin, they can be either null, or an empty string, or any other don't-care string value. </para>    
		/// </summary>
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

				/// <summary>
				///  <para>Creates a  <code>DrmRights</code> object with the given parameters.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public DrmRights(string rightsFilePath, string mimeType, string accountId) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Creates a  <code>DrmRights</code> object with the given parameters.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public DrmRights(string rightsFilePath, string mimeType, string accountId, string subscriptionId) /* MethodBuilder.Create */ 
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

				/// <summary>
				///  <para>Retrieves the rights data associated with this  <code>DrmRights</code> object.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>A  <code>byte</code> array representing the rights data. </para>
				/// </returns>
				/// <java-name>
				/// getData
				/// </java-name>
				[Dot42.DexImport("getData", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual sbyte[] JavaGetData() /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal DrmRights() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Retrieves the rights data associated with this  <code>DrmRights</code> object.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>A  <code>byte</code> array representing the rights data. </para>
				/// </returns>
				/// <java-name>
				/// getData
				/// </java-name>
				public virtual byte[] Data
				{
						[Dot42.DexImport("getData", "()[B", AccessFlags = 1)]
						get{ return default(byte[]); }
				}

				/// <summary>
				///  <para>Retrieves the MIME type associated with this  <code>DrmRights</code> object.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The MIME type. </para>
				/// </returns>
				/// <java-name>
				/// getMimeType
				/// </java-name>
				public virtual string MimeType
				{
						[Dot42.DexImport("getMimeType", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>Retrieves the account ID associated with this  <code>DrmRights</code> object.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The account ID. </para>
				/// </returns>
				/// <java-name>
				/// getAccountId
				/// </java-name>
				public virtual string AccountId
				{
						[Dot42.DexImport("getAccountId", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>Retrieves the subscription ID associated with this  <code>DrmRights</code> object.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The subscription ID. </para>
				/// </returns>
				/// <java-name>
				/// getSubscriptionId
				/// </java-name>
				public virtual string SubscriptionId
				{
						[Dot42.DexImport("getSubscriptionId", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

		}

		/// <summary>
		///  <para>Defines constants that are used by the DRM framework. </para>    
		/// </summary>
		/// <java-name>
		/// android/drm/DrmStore
		/// </java-name>
		[Dot42.DexImport("android/drm/DrmStore", AccessFlags = 33)]
		public partial class DrmStore
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>This class should have been an interface instead. The default constuctor should have not been exposed. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public DrmStore() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Defines status notifications for digital rights. </para>    
				/// </summary>
				/// <java-name>
				/// android/drm/DrmStore$RightsStatus
				/// </java-name>
				[Dot42.DexImport("android/drm/DrmStore$RightsStatus", AccessFlags = 9)]
				public partial class RightsStatus
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>The digital rights are valid. </para>        
						/// </summary>
						/// <java-name>
						/// RIGHTS_VALID
						/// </java-name>
						[Dot42.DexImport("RIGHTS_VALID", "I", AccessFlags = 25)]
						public const int RIGHTS_VALID = 0;
						/// <summary>
						///  <para>The digital rights are invalid. </para>        
						/// </summary>
						/// <java-name>
						/// RIGHTS_INVALID
						/// </java-name>
						[Dot42.DexImport("RIGHTS_INVALID", "I", AccessFlags = 25)]
						public const int RIGHTS_INVALID = 1;
						/// <summary>
						///  <para>The digital rights have expired. </para>        
						/// </summary>
						/// <java-name>
						/// RIGHTS_EXPIRED
						/// </java-name>
						[Dot42.DexImport("RIGHTS_EXPIRED", "I", AccessFlags = 25)]
						public const int RIGHTS_EXPIRED = 2;
						/// <summary>
						///  <para>The digital rights have not been acquired for the rights-protected content. </para>        
						/// </summary>
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

				/// <summary>
				///  <para>Defines actions that can be performed on rights-protected content. </para>    
				/// </summary>
				/// <java-name>
				/// android/drm/DrmStore$Action
				/// </java-name>
				[Dot42.DexImport("android/drm/DrmStore$Action", AccessFlags = 9)]
				public partial class Action
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>The default action. </para>        
						/// </summary>
						/// <java-name>
						/// DEFAULT
						/// </java-name>
						[Dot42.DexImport("DEFAULT", "I", AccessFlags = 25)]
						public const int DEFAULT = 0;
						/// <summary>
						///  <para>The rights-protected content can be played. </para>        
						/// </summary>
						/// <java-name>
						/// PLAY
						/// </java-name>
						[Dot42.DexImport("PLAY", "I", AccessFlags = 25)]
						public const int PLAY = 1;
						/// <summary>
						///  <para>The rights-protected content can be set as a ringtone. </para>        
						/// </summary>
						/// <java-name>
						/// RINGTONE
						/// </java-name>
						[Dot42.DexImport("RINGTONE", "I", AccessFlags = 25)]
						public const int RINGTONE = 2;
						/// <summary>
						///  <para>The rights-protected content can be transferred. </para>        
						/// </summary>
						/// <java-name>
						/// TRANSFER
						/// </java-name>
						[Dot42.DexImport("TRANSFER", "I", AccessFlags = 25)]
						public const int TRANSFER = 3;
						/// <summary>
						///  <para>The rights-protected content can be set as output. </para>        
						/// </summary>
						/// <java-name>
						/// OUTPUT
						/// </java-name>
						[Dot42.DexImport("OUTPUT", "I", AccessFlags = 25)]
						public const int OUTPUT = 4;
						/// <summary>
						///  <para>The rights-protected content can be previewed. </para>        
						/// </summary>
						/// <java-name>
						/// PREVIEW
						/// </java-name>
						[Dot42.DexImport("PREVIEW", "I", AccessFlags = 25)]
						public const int PREVIEW = 5;
						/// <summary>
						///  <para>The rights-protected content can be executed. </para>        
						/// </summary>
						/// <java-name>
						/// EXECUTE
						/// </java-name>
						[Dot42.DexImport("EXECUTE", "I", AccessFlags = 25)]
						public const int EXECUTE = 6;
						/// <summary>
						///  <para>The rights-protected content can be displayed. </para>        
						/// </summary>
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

				/// <summary>
				///  <para>Defines playback states for content. </para>    
				/// </summary>
				/// <java-name>
				/// android/drm/DrmStore$Playback
				/// </java-name>
				[Dot42.DexImport("android/drm/DrmStore$Playback", AccessFlags = 9)]
				public partial class Playback
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>Playback started. </para>        
						/// </summary>
						/// <java-name>
						/// START
						/// </java-name>
						[Dot42.DexImport("START", "I", AccessFlags = 25)]
						public const int START = 0;
						/// <summary>
						///  <para>Playback stopped. </para>        
						/// </summary>
						/// <java-name>
						/// STOP
						/// </java-name>
						[Dot42.DexImport("STOP", "I", AccessFlags = 25)]
						public const int STOP = 1;
						/// <summary>
						///  <para>Playback paused. </para>        
						/// </summary>
						/// <java-name>
						/// PAUSE
						/// </java-name>
						[Dot42.DexImport("PAUSE", "I", AccessFlags = 25)]
						public const int PAUSE = 2;
						/// <summary>
						///  <para>Playback resumed. </para>        
						/// </summary>
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

				/// <summary>
				///  <para>Defines DRM object types. </para>    
				/// </summary>
				/// <java-name>
				/// android/drm/DrmStore$DrmObjectType
				/// </java-name>
				[Dot42.DexImport("android/drm/DrmStore$DrmObjectType", AccessFlags = 9)]
				public partial class DrmObjectType
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>An unknown object type. </para>        
						/// </summary>
						/// <java-name>
						/// UNKNOWN
						/// </java-name>
						[Dot42.DexImport("UNKNOWN", "I", AccessFlags = 25)]
						public const int UNKNOWN = 0;
						/// <summary>
						///  <para>A rights-protected file object type. </para>        
						/// </summary>
						/// <java-name>
						/// CONTENT
						/// </java-name>
						[Dot42.DexImport("CONTENT", "I", AccessFlags = 25)]
						public const int CONTENT = 1;
						/// <summary>
						///  <para>A rights information object type. </para>        
						/// </summary>
						/// <java-name>
						/// RIGHTS_OBJECT
						/// </java-name>
						[Dot42.DexImport("RIGHTS_OBJECT", "I", AccessFlags = 25)]
						public const int RIGHTS_OBJECT = 2;
						/// <summary>
						///  <para>A trigger information object type. </para>        
						/// </summary>
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

				/// <summary>
				///  <para>Interface definition for the columns that represent DRM constraints. DrmManagerClient.getConstraints() can be called by an application to find out the contraints on the actions that can be performed on right-protected content. The constants defined in this interface represent three most common types of constraints: count-based, date-based, and duration-based. Two or more constraints can be used at the same time to represent more sophisticated constraints. In addition, user-defined constraint, extended metadata, can be used if these three types of constraints are not sufficient. </para>    
				/// </summary>
				/// <java-name>
				/// android/drm/DrmStore$ConstraintsColumns
				/// </java-name>
				[Dot42.DexImport("android/drm/DrmStore$ConstraintsColumns", AccessFlags = 1545, IgnoreFromJava = true, Priority = 1)]
				public static partial class IConstraintsColumnsConstants
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>This is a count-based constraint. It represents the maximum repeat count that can be performed on an action. </para> <para>Type: INTEGER </para>        
						/// </summary>
						/// <java-name>
						/// MAX_REPEAT_COUNT
						/// </java-name>
						[Dot42.DexImport("MAX_REPEAT_COUNT", "Ljava/lang/String;", AccessFlags = 25)]
						public const string MAX_REPEAT_COUNT = "max_repeat_count";
						/// <summary>
						///  <para>This is a count-based constraint. It represents the remaining repeat count that can be performed on an action. </para> <para>Type: INTEGER </para>        
						/// </summary>
						/// <java-name>
						/// REMAINING_REPEAT_COUNT
						/// </java-name>
						[Dot42.DexImport("REMAINING_REPEAT_COUNT", "Ljava/lang/String;", AccessFlags = 25)]
						public const string REMAINING_REPEAT_COUNT = "remaining_repeat_count";
						/// <summary>
						///  <para>This is a date-based constraint. It represents the time before which an action can be performed on the rights-protected content. </para> <para>Type: TEXT </para>        
						/// </summary>
						/// <java-name>
						/// LICENSE_START_TIME
						/// </java-name>
						[Dot42.DexImport("LICENSE_START_TIME", "Ljava/lang/String;", AccessFlags = 25)]
						public const string LICENSE_START_TIME = "license_start_time";
						/// <summary>
						///  <para>This is a date-based constaint. It represents the time after which an action can not be performed on the rights-protected content. </para> <para>Type: TEXT </para>        
						/// </summary>
						/// <java-name>
						/// LICENSE_EXPIRY_TIME
						/// </java-name>
						[Dot42.DexImport("LICENSE_EXPIRY_TIME", "Ljava/lang/String;", AccessFlags = 25)]
						public const string LICENSE_EXPIRY_TIME = "license_expiry_time";
						/// <summary>
						///  <para>This is a duration-based constaint. It represents the available time left before the license expires. </para> <para>Type: TEXT </para>        
						/// </summary>
						/// <java-name>
						/// LICENSE_AVAILABLE_TIME
						/// </java-name>
						[Dot42.DexImport("LICENSE_AVAILABLE_TIME", "Ljava/lang/String;", AccessFlags = 25)]
						public const string LICENSE_AVAILABLE_TIME = "license_available_time";
						/// <summary>
						///  <para>This is a user-defined constraint. It represents the additional constraint using extended metadata. </para> <para>Type: TEXT </para>        
						/// </summary>
						/// <java-name>
						/// EXTENDED_METADATA
						/// </java-name>
						[Dot42.DexImport("EXTENDED_METADATA", "Ljava/lang/String;", AccessFlags = 25)]
						public const string EXTENDED_METADATA = "extended_metadata";
				}

				/// <summary>
				///  <para>Interface definition for the columns that represent DRM constraints. DrmManagerClient.getConstraints() can be called by an application to find out the contraints on the actions that can be performed on right-protected content. The constants defined in this interface represent three most common types of constraints: count-based, date-based, and duration-based. Two or more constraints can be used at the same time to represent more sophisticated constraints. In addition, user-defined constraint, extended metadata, can be used if these three types of constraints are not sufficient. </para>    
				/// </summary>
				/// <java-name>
				/// android/drm/DrmStore$ConstraintsColumns
				/// </java-name>
				[Dot42.DexImport("android/drm/DrmStore$ConstraintsColumns", AccessFlags = 1545)]
				public partial interface IConstraintsColumns
 /* scope: __dot42__ */ 
				{
				}

		}

		/// <summary>
		///  <para>An entity class that wraps the capability of each DRM plug-in (agent), such as the MIME type and file suffix the DRM plug-in can handle. </para> <para>Plug-in developers can expose the capability of their plug-in by passing an instance of this class to an application. </para>    
		/// </summary>
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

				/// <summary>
				///  <para>Adds the specified MIME type to the list of MIME types this DRM plug-in supports.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// addMimeType
				/// </java-name>
				[Dot42.DexImport("addMimeType", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void AddMimeType(string mimeType) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Adds the specified file suffix to the list of file suffixes this DRM plug-in supports.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// addFileSuffix
				/// </java-name>
				[Dot42.DexImport("addFileSuffix", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void AddFileSuffix(string fileSuffix) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets a description for the DRM plug-in (agent).</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setDescription
				/// </java-name>
				[Dot42.DexImport("setDescription", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetDescription(string description) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Overridden hash code implementation.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The hash code value. </para>
				/// </returns>
				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 1)]
				public override int GetHashCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Overridden  <code>equals</code> implementation. Two DrmSupportInfo objects are considered being equal if they support exactly the same set of mime types, file suffixes, and has exactly the same description.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>True if equal; false if not equal. </para>
				/// </returns>
				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Retrieves an iterator object that you can use to iterate over the MIME types that this DRM plug-in supports.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The iterator object </para>
				/// </returns>
				/// <java-name>
				/// getMimeTypeIterator
				/// </java-name>
				public virtual global::Java.Util.IIterator<string> MimeTypeIterator
				{
						[Dot42.DexImport("getMimeTypeIterator", "()Ljava/util/Iterator;", AccessFlags = 1, Signature = "()Ljava/util/Iterator<Ljava/lang/String;>;")]
						get{ return default(global::Java.Util.IIterator<string>); }
				}

				/// <summary>
				///  <para>Retrieves an iterator object that you can use to iterate over the file suffixes that this DRM plug-in supports.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The iterator object. </para>
				/// </returns>
				/// <java-name>
				/// getFileSuffixIterator
				/// </java-name>
				public virtual global::Java.Util.IIterator<string> FileSuffixIterator
				{
						[Dot42.DexImport("getFileSuffixIterator", "()Ljava/util/Iterator;", AccessFlags = 1, Signature = "()Ljava/util/Iterator<Ljava/lang/String;>;")]
						get{ return default(global::Java.Util.IIterator<string>); }
				}

				/// <summary>
				///  <para>Retrieves the DRM plug-in (agent) description.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>The method name is mis-spelled, and it is replaced by getDescription(). </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				///  <para>The plug-in description. </para>
				/// </returns>
				/// <java-name>
				/// getDescriprition
				/// </java-name>
				public virtual string Descriprition
				{
						[Dot42.DexImport("getDescriprition", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

		}

		/// <summary>
		///  <para>A utility class that provides operations for parsing extended metadata embedded in DRM constraint information. If a DRM scheme has specific constraints beyond the standard constraints, the constraints will show up in the DrmStore.ConstraintsColumns#EXTENDED_METADATA key. You can use DrmUtils.ExtendedMetadataParser to iterate over those values. </para>    
		/// </summary>
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

				/// <summary>
				///  <para>Gets an instance of DrmUtils.ExtendedMetadataParser, which can be used to parse extended metadata embedded in DRM constraint information.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// getExtendedMetadataParser
				/// </java-name>
				[Dot42.DexImport("getExtendedMetadataParser", "([B)Landroid/drm/DrmUtils$ExtendedMetadataParser;", AccessFlags = 9, IgnoreFromJava = true)]
				public static global::Android.Drm.DrmUtils.ExtendedMetadataParser GetExtendedMetadataParser(sbyte[] extendedMetadata) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Drm.DrmUtils.ExtendedMetadataParser);
				}

				/// <summary>
				///  <para>Gets an instance of DrmUtils.ExtendedMetadataParser, which can be used to parse extended metadata embedded in DRM constraint information.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// getExtendedMetadataParser
				/// </java-name>
				[Dot42.DexImport("getExtendedMetadataParser", "([B)Landroid/drm/DrmUtils$ExtendedMetadataParser;", AccessFlags = 9)]
				public static global::Android.Drm.DrmUtils.ExtendedMetadataParser GetExtendedMetadataParser(byte[] extendedMetadata) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Drm.DrmUtils.ExtendedMetadataParser);
				}

				/// <summary>
				///  <para>Utility that parses extended metadata embedded in DRM constraint information. </para> <para>Usage example: </para> <para>byte[] extendedMetadata <br></br>      = constraints.getAsByteArray(DrmStore.ConstraintsColumns.EXTENDED_METADATA); <br></br> ExtendedMetadataParser parser = getExtendedMetadataParser(extendedMetadata); <br></br> Iterator keyIterator = parser.keyIterator(); <br></br> while (keyIterator.hasNext()) { <br></br>     String extendedMetadataKey = keyIterator.next(); <br></br>     String extendedMetadataValue = parser.get(extendedMetadataKey); <br></br> } </para>    
				/// </summary>
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

						/// <summary>
						///  <para>This method returns an iterator object that can be used to iterate over all values of the metadata.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>The iterator object. </para>
						/// </returns>
						/// <java-name>
						/// iterator
						/// </java-name>
						[Dot42.DexImport("iterator", "()Ljava/util/Iterator;", AccessFlags = 1, Signature = "()Ljava/util/Iterator<Ljava/lang/String;>;")]
						public virtual global::Java.Util.IIterator<string> Iterator() /* MethodBuilder.Create */ 
						{
								return default(global::Java.Util.IIterator<string>);
						}

						/// <summary>
						///  <para>This method returns an iterator object that can be used to iterate over all keys of the metadata.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>The iterator object. </para>
						/// </returns>
						/// <java-name>
						/// keyIterator
						/// </java-name>
						[Dot42.DexImport("keyIterator", "()Ljava/util/Iterator;", AccessFlags = 1, Signature = "()Ljava/util/Iterator<Ljava/lang/String;>;")]
						public virtual global::Java.Util.IIterator<string> KeyIterator() /* MethodBuilder.Create */ 
						{
								return default(global::Java.Util.IIterator<string>);
						}

						/// <summary>
						///  <para>This method retrieves the metadata value associated with a given key.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>The metadata value associated with the given key. Returns null if the key is not found. </para>
						/// </returns>
						/// <java-name>
						/// get
						/// </java-name>
						[Dot42.DexImport("get", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1)]
						public virtual string Get(string key) /* MethodBuilder.Create */ 
						{
								return default(string);
						}

				}

		}

		/// <summary>
		///  <para>An entity class that wraps the result of a processDrmInfo() transaction between a device and a DRM server.</para> <para>In a license acquisition scenario this class holds the rights information in binary form. </para>    
		/// </summary>
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

				/// <summary>
				///  <para>Retrieves the processed data.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The rights data. </para>
				/// </returns>
				/// <java-name>
				/// getData
				/// </java-name>
				[Dot42.DexImport("getData", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual sbyte[] JavaGetData() /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <summary>
				///  <para>Retrieves the processed data.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The rights data. </para>
				/// </returns>
				/// <java-name>
				/// getData
				/// </java-name>
				public virtual byte[] Data
				{
						[Dot42.DexImport("getData", "()[B", AccessFlags = 1)]
						get{ return default(byte[]); }
				}

				/// <summary>
				///  <para>Retrieves the account ID associated with this object.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The account ID of the user. </para>
				/// </returns>
				/// <java-name>
				/// getAccountId
				/// </java-name>
				public virtual string AccountId
				{
						[Dot42.DexImport("getAccountId", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>Returns the subscription ID associated with this object.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The subscription ID of the user. </para>
				/// </returns>
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

