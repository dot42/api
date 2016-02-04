#pragma warning disable 1717
namespace Android.Hardware.Location
{
		/// <summary>
		///  <para>This class handles geofences managed by various hardware subsystems. It contains the public APIs that is needed to accomplish the task.</para> <para>The APIs should not be called directly by the app developers. A higher level api which abstracts the hardware should be used instead. All the checks are done by the higher level public API. Any needed locking should be handled by the higher level API.</para> <para>There are 3 states associated with a Geofence: Inside, Outside, Unknown. There are 3 transitions: GEOFENCE_ENTERED, GEOFENCE_EXITED, GEOFENCE_UNCERTAIN. The APIs only expose the transitions.</para> <para>Inside state: The hardware subsystem is reasonably confident that the user is inside the geofence. Outside state: The hardware subsystem is reasonably confident that the user is outside the geofence Unknown state: Unknown state can be interpreted as a state in which the monitoring subsystem isn't confident enough that the user is either inside or outside the Geofence. If the accuracy does not improve for a sufficient period of time, the GEOFENCE_UNCERTAIN transition would be triggered. If the accuracy improves later, an appropriate transition would be triggered. The "reasonably confident" parameter depends on the hardware system and the positioning algorithms used. For instance, MONITORING_TYPE_GPS_HARDWARE uses 95% as a confidence level. </para>    
		/// </summary>
		/// <java-name>
		/// android/hardware/location/GeofenceHardware
		/// </java-name>
		[Dot42.DexImport("android/hardware/location/GeofenceHardware", AccessFlags = 49)]
		public sealed partial class GeofenceHardware
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constant for geofence monitoring done by the GPS hardware. </para>        
				/// </summary>
				/// <java-name>
				/// MONITORING_TYPE_GPS_HARDWARE
				/// </java-name>
				[Dot42.DexImport("MONITORING_TYPE_GPS_HARDWARE", "I", AccessFlags = 25)]
				public const int MONITORING_TYPE_GPS_HARDWARE = 0;
				/// <summary>
				///  <para>Constant to indiciate that the monitoring system is currently available for monitoring geofences. </para>        
				/// </summary>
				/// <java-name>
				/// MONITOR_CURRENTLY_AVAILABLE
				/// </java-name>
				[Dot42.DexImport("MONITOR_CURRENTLY_AVAILABLE", "I", AccessFlags = 25)]
				public const int MONITOR_CURRENTLY_AVAILABLE = 0;
				/// <summary>
				///  <para>Constant to indiciate that the monitoring system is currently unavailable for monitoring geofences. </para>        
				/// </summary>
				/// <java-name>
				/// MONITOR_CURRENTLY_UNAVAILABLE
				/// </java-name>
				[Dot42.DexImport("MONITOR_CURRENTLY_UNAVAILABLE", "I", AccessFlags = 25)]
				public const int MONITOR_CURRENTLY_UNAVAILABLE = 1;
				/// <summary>
				///  <para>Constant to indiciate that the monitoring system is unsupported for hardware geofence monitoring. </para>        
				/// </summary>
				/// <java-name>
				/// MONITOR_UNSUPPORTED
				/// </java-name>
				[Dot42.DexImport("MONITOR_UNSUPPORTED", "I", AccessFlags = 25)]
				public const int MONITOR_UNSUPPORTED = 2;
				/// <summary>
				///  <para>The constant to indicate that the user has entered the geofence. </para>        
				/// </summary>
				/// <java-name>
				/// GEOFENCE_ENTERED
				/// </java-name>
				[Dot42.DexImport("GEOFENCE_ENTERED", "I", AccessFlags = 25)]
				public const int GEOFENCE_ENTERED = 1;
				/// <summary>
				///  <para>The constant to indicate that the user has exited the geofence. </para>        
				/// </summary>
				/// <java-name>
				/// GEOFENCE_EXITED
				/// </java-name>
				[Dot42.DexImport("GEOFENCE_EXITED", "I", AccessFlags = 25)]
				public const int GEOFENCE_EXITED = 2;
				/// <summary>
				///  <para>The constant to indicate that the user is uncertain with respect to a geofence. nn </para>        
				/// </summary>
				/// <java-name>
				/// GEOFENCE_UNCERTAIN
				/// </java-name>
				[Dot42.DexImport("GEOFENCE_UNCERTAIN", "I", AccessFlags = 25)]
				public const int GEOFENCE_UNCERTAIN = 4;
				/// <summary>
				///  <para>The constant used to indicate success of the particular geofence call </para>        
				/// </summary>
				/// <java-name>
				/// GEOFENCE_SUCCESS
				/// </java-name>
				[Dot42.DexImport("GEOFENCE_SUCCESS", "I", AccessFlags = 25)]
				public const int GEOFENCE_SUCCESS = 0;
				/// <summary>
				///  <para>The constant used to indicate that too many geofences have been registered. </para>        
				/// </summary>
				/// <java-name>
				/// GEOFENCE_ERROR_TOO_MANY_GEOFENCES
				/// </java-name>
				[Dot42.DexImport("GEOFENCE_ERROR_TOO_MANY_GEOFENCES", "I", AccessFlags = 25)]
				public const int GEOFENCE_ERROR_TOO_MANY_GEOFENCES = 1;
				/// <summary>
				///  <para>The constant used to indicate that the geofence id already exists. </para>        
				/// </summary>
				/// <java-name>
				/// GEOFENCE_ERROR_ID_EXISTS
				/// </java-name>
				[Dot42.DexImport("GEOFENCE_ERROR_ID_EXISTS", "I", AccessFlags = 25)]
				public const int GEOFENCE_ERROR_ID_EXISTS = 2;
				/// <summary>
				///  <para>The constant used to indicate that the geofence id is unknown. </para>        
				/// </summary>
				/// <java-name>
				/// GEOFENCE_ERROR_ID_UNKNOWN
				/// </java-name>
				[Dot42.DexImport("GEOFENCE_ERROR_ID_UNKNOWN", "I", AccessFlags = 25)]
				public const int GEOFENCE_ERROR_ID_UNKNOWN = 3;
				/// <summary>
				///  <para>The constant used to indicate that the transition requested for the geofence is invalid. </para>        
				/// </summary>
				/// <java-name>
				/// GEOFENCE_ERROR_INVALID_TRANSITION
				/// </java-name>
				[Dot42.DexImport("GEOFENCE_ERROR_INVALID_TRANSITION", "I", AccessFlags = 25)]
				public const int GEOFENCE_ERROR_INVALID_TRANSITION = 4;
				/// <summary>
				///  <para>The constant used to indicate that the geofence operation has failed. </para>        
				/// </summary>
				/// <java-name>
				/// GEOFENCE_FAILURE
				/// </java-name>
				[Dot42.DexImport("GEOFENCE_FAILURE", "I", AccessFlags = 25)]
				public const int GEOFENCE_FAILURE = 5;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal GeofenceHardware() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns current status of a hardware geofence monitoring system.</para> <para>Status can be one of MONITOR_CURRENTLY_AVAILABLE, MONITOR_CURRENTLY_UNAVAILABLE or MONITOR_UNSUPPORTED</para> <para>Some supported hardware monitoring systems might not be available for monitoring geofences in certain scenarios. For example, when a user enters a building, the GPS hardware subsystem might not be able monitor geofences and will change from MONITOR_CURRENTLY_AVAILABLE to MONITOR_CURRENTLY_UNAVAILABLE.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Current status of the monitoring type. </para>
				/// </returns>
				/// <java-name>
				/// getStatusOfMonitoringType
				/// </java-name>
				[Dot42.DexImport("getStatusOfMonitoringType", "(I)I", AccessFlags = 1)]
				public int GetStatusOfMonitoringType(int monitoringType) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Creates a circular geofence which is monitored by subsystems in the hardware.</para> <para>When the device detects that is has entered, exited or is uncertain about the area specified by the geofence, the given callback will be called.</para> <para>If this call returns true, it means that the geofence has been sent to the hardware. GeofenceHardwareCallback#onGeofenceAdd will be called with the result of the add call from the hardware. The GeofenceHardwareCallback#onGeofenceAdd will be called with the following parameters when a transition event occurs.  <ul> <li> <para>The geofence Id </para></li> <li> <para>The location object indicating the last known location. </para></li> <li> <para>The transition associated with the geofence. One of GEOFENCE_ENTERED, GEOFENCE_EXITED, GEOFENCE_UNCERTAIN </para></li> <li> <para>The timestamp when the geofence transition occured. </para></li> <li> <para>The monitoring type (MONITORING_TYPE_GPS_HARDWARE is one such example) that was used. </para></li></ul></para> <para>The geofence will be monitored by the subsystem specified by monitoring_type parameter. The application does not need to hold a wakelock when the monitoring is being done by the underlying hardware subsystem. If the same geofence Id is being monitored by two different monitoring systems, the same id can be used for both calls, as long as the same callback object is used.</para> <para>Requires android.Manifest.permission#ACCESS_FINE_LOCATION permission when MONITORING_TYPE_GPS_HARDWARE is used.</para> <para>Requires android.Manifest.permission#LOCATION_HARDWARE permission to access geofencing in hardware.</para> <para>This API should not be called directly by the app developers. A higher level api which abstracts the hardware should be used instead. All the checks are done by the higher level public API. Any needed locking should be handled by the higher level API.</para> <para>Create a geofence request object using the methods in GeofenceHardwareRequest to set all the characteristics of the geofence. Use the created GeofenceHardwareRequest object in this call.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true when the geofence is successfully sent to the hardware for addition. </para>
				/// </returns>
				/// <java-name>
				/// addGeofence
				/// </java-name>
				[Dot42.DexImport("addGeofence", "(IILandroid/hardware/location/GeofenceHardwareRequest;Landroid/hardware/location/" +
    "GeofenceHardwareCallback;)Z", AccessFlags = 1)]
				public bool AddGeofence(int geofenceId, int monitoringType, global::Android.Hardware.Location.GeofenceHardwareRequest geofenceRequest, global::Android.Hardware.Location.GeofenceHardwareCallback callback) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Removes a geofence added by addGeofence call.</para> <para>If this call returns true, it means that the geofence has been sent to the hardware. GeofenceHardwareCallback#onGeofenceRemove will be called with the result of the remove call from the hardware.</para> <para>Requires android.Manifest.permission#ACCESS_FINE_LOCATION permission when MONITORING_TYPE_GPS_HARDWARE is used.</para> <para>Requires android.Manifest.permission#LOCATION_HARDWARE permission to access geofencing in hardware.</para> <para>This API should not be called directly by the app developers. A higher level api which abstracts the hardware should be used instead. All the checks are done by the higher level public API. Any needed locking should be handled by the higher level API.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true when the geofence is successfully sent to the hardware for removal. . </para>
				/// </returns>
				/// <java-name>
				/// removeGeofence
				/// </java-name>
				[Dot42.DexImport("removeGeofence", "(II)Z", AccessFlags = 1)]
				public bool RemoveGeofence(int geofenceId, int monitoringType) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Pauses the monitoring of a geofence added by addGeofence call.</para> <para>If this call returns true, it means that the geofence has been sent to the hardware. GeofenceHardwareCallback#onGeofencePause will be called with the result of the pause call from the hardware.</para> <para>Requires android.Manifest.permission#ACCESS_FINE_LOCATION permission when MONITORING_TYPE_GPS_HARDWARE is used.</para> <para>Requires android.Manifest.permission#LOCATION_HARDWARE permission to access geofencing in hardware.</para> <para>This API should not be called directly by the app developers. A higher level api which abstracts the hardware should be used instead. All the checks are done by the higher level public API. Any needed locking should be handled by the higher level API.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true when the geofence is successfully sent to the hardware for pausing. </para>
				/// </returns>
				/// <java-name>
				/// pauseGeofence
				/// </java-name>
				[Dot42.DexImport("pauseGeofence", "(II)Z", AccessFlags = 1)]
				public bool PauseGeofence(int geofenceId, int monitoringType) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Resumes the monitoring of a geofence added by pauseGeofence call.</para> <para>If this call returns true, it means that the geofence has been sent to the hardware. GeofenceHardwareCallback#onGeofenceResume will be called with the result of the resume call from the hardware.</para> <para>Requires android.Manifest.permission#ACCESS_FINE_LOCATION permission when MONITORING_TYPE_GPS_HARDWARE is used.</para> <para>Requires android.Manifest.permission#LOCATION_HARDWARE permission to access geofencing in hardware.</para> <para>This API should not be called directly by the app developers. A higher level api which abstracts the hardware should be used instead. All the checks are done by the higher level public API. Any needed locking should be handled by the higher level API.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true when the geofence is successfully sent to the hardware for resumption. </para>
				/// </returns>
				/// <java-name>
				/// resumeGeofence
				/// </java-name>
				[Dot42.DexImport("resumeGeofence", "(III)Z", AccessFlags = 1)]
				public bool ResumeGeofence(int geofenceId, int monitoringType, int monitorTransition) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Register the callback to be notified when the state of a hardware geofence monitoring system changes. For instance, it can change from MONITOR_CURRENTLY_AVAILABLE to MONITOR_CURRENTLY_UNAVAILABLE</para> <para>Requires android.Manifest.permission#ACCESS_FINE_LOCATION permission when MONITORING_TYPE_GPS_HARDWARE is used.</para> <para>Requires android.Manifest.permission#LOCATION_HARDWARE permission to access geofencing in hardware.</para> <para>This API should not be called directly by the app developers. A higher level api which abstracts the hardware should be used instead. All the checks are done by the higher level public API. Any needed locking should be handled by the higher level API.</para> <para>The same callback object can be used to be informed of geofence transitions and state changes of the underlying hardware subsystem.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true on success </para>
				/// </returns>
				/// <java-name>
				/// registerForMonitorStateChangeCallback
				/// </java-name>
				[Dot42.DexImport("registerForMonitorStateChangeCallback", "(ILandroid/hardware/location/GeofenceHardwareMonitorCallback;)Z", AccessFlags = 1)]
				public bool RegisterForMonitorStateChangeCallback(int monitoringType, global::Android.Hardware.Location.GeofenceHardwareMonitorCallback callback) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Unregister the callback that was used with registerForMonitorStateChangeCallback to notify when the state of the hardware geofence monitoring system changes.</para> <para>Requires android.Manifest.permission#ACCESS_FINE_LOCATION permission when MONITORING_TYPE_GPS_HARDWARE is used.</para> <para>Requires android.Manifest.permission#LOCATION_HARDWARE permission to access geofencing in hardware.</para> <para>This API should not be called directly by the app developers. A higher level api which abstracts the hardware should be used instead. All the checks are done by the higher level public API. Any needed locking should be handled by the higher level API.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true on success </para>
				/// </returns>
				/// <java-name>
				/// unregisterForMonitorStateChangeCallback
				/// </java-name>
				[Dot42.DexImport("unregisterForMonitorStateChangeCallback", "(ILandroid/hardware/location/GeofenceHardwareMonitorCallback;)Z", AccessFlags = 1)]
				public bool UnregisterForMonitorStateChangeCallback(int monitoringType, global::Android.Hardware.Location.GeofenceHardwareMonitorCallback callback) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Returns all the hardware geofence monitoring systems which are supported</para> <para>Call getStatusOfMonitoringType(int) to know the current state of a monitoring system.</para> <para>Requires android.Manifest.permission#LOCATION_HARDWARE permission to access geofencing in hardware.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>An array of all the monitoring types. An array of length 0 is returned in case of errors. </para>
				/// </returns>
				/// <java-name>
				/// getMonitoringTypes
				/// </java-name>
				public int[] MonitoringTypes
				{
						[Dot42.DexImport("getMonitoringTypes", "()[I", AccessFlags = 1)]
						get{ return default(int[]); }
				}

		}

		/// <summary>
		///  <para>The callback class associated with the APIs in GeofenceHardware </para>    
		/// </summary>
		/// <java-name>
		/// android/hardware/location/GeofenceHardwareCallback
		/// </java-name>
		[Dot42.DexImport("android/hardware/location/GeofenceHardwareCallback", AccessFlags = 1057)]
		public abstract partial class GeofenceHardwareCallback
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public GeofenceHardwareCallback() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>The callback called when there is a transition to report for the specific geofence.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// onGeofenceTransition
				/// </java-name>
				[Dot42.DexImport("onGeofenceTransition", "(IILandroid/location/Location;JI)V", AccessFlags = 1)]
				public virtual void OnGeofenceTransition(int geofenceId, int transition, global::Android.Locations.Location location, long timestamp, int monitoringType) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>The callback called to notify the success or failure of the add call.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// onGeofenceAdd
				/// </java-name>
				[Dot42.DexImport("onGeofenceAdd", "(II)V", AccessFlags = 1)]
				public virtual void OnGeofenceAdd(int geofenceId, int status) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>The callback called to notify the success or failure of the remove call.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// onGeofenceRemove
				/// </java-name>
				[Dot42.DexImport("onGeofenceRemove", "(II)V", AccessFlags = 1)]
				public virtual void OnGeofenceRemove(int geofenceId, int status) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>The callback called to notify the success or failure of the pause call.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// onGeofencePause
				/// </java-name>
				[Dot42.DexImport("onGeofencePause", "(II)V", AccessFlags = 1)]
				public virtual void OnGeofencePause(int geofenceId, int status) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>The callback called to notify the success or failure of the resume call.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// onGeofenceResume
				/// </java-name>
				[Dot42.DexImport("onGeofenceResume", "(II)V", AccessFlags = 1)]
				public virtual void OnGeofenceResume(int geofenceId, int status) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>The callback class associated with the status change of hardware montiors in GeofenceHardware </para>    
		/// </summary>
		/// <java-name>
		/// android/hardware/location/GeofenceHardwareMonitorCallback
		/// </java-name>
		[Dot42.DexImport("android/hardware/location/GeofenceHardwareMonitorCallback", AccessFlags = 1057)]
		public abstract partial class GeofenceHardwareMonitorCallback
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public GeofenceHardwareMonitorCallback() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>The callback called when the state of a monitoring system changes. GeofenceHardware#MONITORING_TYPE_GPS_HARDWARE is an example of a monitoring system</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// onMonitoringSystemChange
				/// </java-name>
				[Dot42.DexImport("onMonitoringSystemChange", "(IZLandroid/location/Location;)V", AccessFlags = 1)]
				public virtual void OnMonitoringSystemChange(int monitoringType, bool available, global::Android.Locations.Location location) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>This class represents the characteristics of the geofence.</para> <para>Use this in conjunction with GeofenceHardware APIs. </para>    
		/// </summary>
		/// <java-name>
		/// android/hardware/location/GeofenceHardwareRequest
		/// </java-name>
		[Dot42.DexImport("android/hardware/location/GeofenceHardwareRequest", AccessFlags = 49)]
		public sealed partial class GeofenceHardwareRequest
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public GeofenceHardwareRequest() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Create a circular geofence.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// createCircularGeofence
				/// </java-name>
				[Dot42.DexImport("createCircularGeofence", "(DDD)Landroid/hardware/location/GeofenceHardwareRequest;", AccessFlags = 9)]
				public static global::Android.Hardware.Location.GeofenceHardwareRequest CreateCircularGeofence(double latitude, double longitude, double radius) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Hardware.Location.GeofenceHardwareRequest);
				}

				/// <summary>
				///  <para>Returns the latitude of this geofence. </para>        
				/// </summary>
				/// <java-name>
				/// getLatitude
				/// </java-name>
				public double Latitude
				{
						[Dot42.DexImport("getLatitude", "()D", AccessFlags = 1)]
						get{ return default(double); }
				}

				/// <summary>
				///  <para>Returns the longitude of this geofence. </para>        
				/// </summary>
				/// <java-name>
				/// getLongitude
				/// </java-name>
				public double Longitude
				{
						[Dot42.DexImport("getLongitude", "()D", AccessFlags = 1)]
						get{ return default(double); }
				}

				/// <summary>
				///  <para>Returns the radius of this geofence. </para>        
				/// </summary>
				/// <java-name>
				/// getRadius
				/// </java-name>
				public double Radius
				{
						[Dot42.DexImport("getRadius", "()D", AccessFlags = 1)]
						get{ return default(double); }
				}

				/// <summary>
				///  <para>Returns transitions monitored for this geofence. </para>        
				/// </summary>
				/// <java-name>
				/// getMonitorTransitions
				/// </java-name>
				public int MonitorTransitions
				{
						[Dot42.DexImport("getMonitorTransitions", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setMonitorTransitions", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Returns the unknownTimer of this geofence. </para>        
				/// </summary>
				/// <java-name>
				/// getUnknownTimer
				/// </java-name>
				public int UnknownTimer
				{
						[Dot42.DexImport("getUnknownTimer", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setUnknownTimer", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Returns the notification responsiveness of this geofence. </para>        
				/// </summary>
				/// <java-name>
				/// getNotificationResponsiveness
				/// </java-name>
				public int NotificationResponsiveness
				{
						[Dot42.DexImport("getNotificationResponsiveness", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setNotificationResponsiveness", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Returns the last transition of this geofence. </para>        
				/// </summary>
				/// <java-name>
				/// getLastTransition
				/// </java-name>
				public int LastTransition
				{
						[Dot42.DexImport("getLastTransition", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setLastTransition", "(I)V", AccessFlags = 1)]
						set{ }
				}

		}

}

