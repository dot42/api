// Copyright (C) 2014 dot42
//
// Original filename: Android.Hardware.cs
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
#pragma warning disable 1717
namespace Android.Hardware
{
		/// <java-name>
		/// android/hardware/SensorEventListener2
		/// </java-name>
		[Dot42.DexImport("android/hardware/SensorEventListener2", AccessFlags = 1537)]
		public partial interface ISensorEventListener2 : global::Android.Hardware.ISensorEventListener
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// onFlushCompleted
				/// </java-name>
				[Dot42.DexImport("onFlushCompleted", "(Landroid/hardware/Sensor;)V", AccessFlags = 1025)]
				void OnFlushCompleted(global::Android.Hardware.Sensor sensor) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>Used for receiving notifications from the SensorManager when sensor values have changed.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>Use SensorEventListener instead. </para></xrefdescription></xrefsect></para>    
		/// </summary>
		/// <java-name>
		/// android/hardware/SensorListener
		/// </java-name>
		[Dot42.DexImport("android/hardware/SensorListener", AccessFlags = 1537)]
		public partial interface ISensorListener
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Called when sensor values have changed. The length and contents of the values array vary depending on which sensor is being monitored. See SensorManager for details on possible sensor types.</para><para>&lt;u&gt;Definition of the coordinate system used below.&lt;/u&gt;</para><para>The X axis refers to the screen's horizontal axis (the small edge in portrait mode, the long edge in landscape mode) and points to the right. </para><para>The Y axis refers to the screen's vertical axis and points towards the top of the screen (the origin is in the lower-left corner). </para><para>The Z axis points toward the sky when the device is lying on its back on a table. </para><para><b>IMPORTANT NOTE:</b> The axis <b>&lt;u&gt;are swapped&lt;/u&gt;</b> when the device's screen orientation changes. To access the unswapped values, use indices 3, 4 and 5 in values[].</para><para>SENSOR_ORIENTATION, SENSOR_ORIENTATION_RAW:</para><para>All values are angles in degrees.</para><para>values[0]: Azimuth, rotation around the Z axis (0&lt;=azimuth&lt;360). 0 = North, 90 = East, 180 = South, 270 = West</para><para>values[1]: Pitch, rotation around X axis (-180&lt;=pitch&lt;=180), with positive values when the z-axis moves toward the y-axis.</para><para>values[2]: Roll, rotation around Y axis (-90&lt;=roll&lt;=90), with positive values when the z-axis moves toward the x-axis.</para><para>Note that this definition of yaw, pitch and roll is different from the traditional definition used in aviation where the X axis is along the long side of the plane (tail to nose).</para><para>SENSOR_ACCELEROMETER:</para><para>All values are in SI units (m/s^2) and measure contact forces.</para><para>values[0]: force applied by the device on the x-axis </para><para>values[1]: force applied by the device on the y-axis </para><para>values[2]: force applied by the device on the z-axis</para><para>&lt;u&gt;Examples&lt;/u&gt;: When the device is pushed on its left side toward the right, the x acceleration value is negative (the device applies a reaction force to the push toward the left)</para><para>When the device lies flat on a table, the acceleration value is -STANDARD_GRAVITY, which correspond to the force the device applies on the table in reaction to gravity.</para><para>SENSOR_MAGNETIC_FIELD:</para><para>All values are in micro-Tesla (uT) and measure the ambient magnetic field in the X, Y and -Z axis. </para><para><b>&lt;u&gt;Note:&lt;/u&gt;</b> the magnetic field's Z axis is inverted.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// onSensorChanged
				/// </java-name>
				[Dot42.DexImport("onSensorChanged", "(I[F)V", AccessFlags = 1025)]
				void OnSensorChanged(int sensor, float[] values) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Called when the accuracy of a sensor has changed. See SensorManager for details.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// onAccuracyChanged
				/// </java-name>
				[Dot42.DexImport("onAccuracyChanged", "(II)V", AccessFlags = 1025)]
				void OnAccuracyChanged(int sensor, int accuracy) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>The Camera class is used to set image capture settings, start/stop preview, snap pictures, and retrieve frames for encoding for video. This class is a client for the Camera service, which manages the actual camera hardware.</para><para>To access the device camera, you must declare the android.Manifest.permission#CAMERA permission in your Android Manifest. Also be sure to include the  manifest element to declare camera features used by your application. For example, if you use the camera and auto-focus feature, your Manifest should include the following:</para><para><pre> &lt;uses-permission android:name="android.permission.CAMERA" /&gt;
		///    &lt;uses-feature android:name="android.hardware.camera" /&gt;
		///    &lt;uses-feature android:name="android.hardware.camera.autofocus" /&gt;</pre></para><para>To take pictures with this class, use the following steps:</para><para><ol><li><para>Obtain an instance of Camera from open(int).</para><para></para></li><li><para>Get existing (default) settings with getParameters().</para><para></para></li><li><para>If necessary, modify the returned Camera.Parameters object and call setParameters(Camera.Parameters).</para><para></para></li><li><para>If desired, call setDisplayOrientation(int).</para><para></para></li><li><para><b>Important</b>: Pass a fully initialized SurfaceHolder to setPreviewDisplay(SurfaceHolder). Without a surface, the camera will be unable to start the preview.</para><para></para></li><li><para><b>Important</b>: Call startPreview() to start updating the preview surface. Preview must be started before you can take a picture.</para><para></para></li><li><para>When you want, call Camera.PictureCallback, Camera.PictureCallback, Camera.PictureCallback) to capture a photo. Wait for the callbacks to provide the actual image data.</para><para></para></li><li><para>After taking a picture, preview display will have stopped. To take more photos, call startPreview() again first.</para><para></para></li><li><para>Call stopPreview() to stop updating the preview surface.</para><para></para></li><li><para><b>Important:</b> Call release() to release the camera for use by other applications. Applications should release the camera immediately in android.app.Activity#onPause() (and re-open() it in android.app.Activity#onResume()). </para></li></ol></para><para>To quickly switch to video recording mode, use these steps:</para><para><ol><li><para>Obtain and initialize a Camera and start preview as described above.</para><para></para></li><li><para>Call unlock() to allow the media process to access the camera.</para><para></para></li><li><para>Pass the camera to android.media.MediaRecorder#setCamera(Camera). See android.media.MediaRecorder information about video recording.</para><para></para></li><li><para>When finished recording, call reconnect() to re-acquire and re-lock the camera.</para><para></para></li><li><para>If desired, restart preview and take more photos or videos.</para><para></para></li><li><para>Call stopPreview() and release() as described above. </para></li></ol></para><para>This class is not thread-safe, and is meant for use from one event thread. Most long-running operations (preview, focus, photo capture, etc) happen asynchronously and invoke callbacks as necessary. Callbacks will be invoked on the event thread open(int) was called from. This class's methods must never be called from multiple threads at once.</para><para><b>Caution:</b> Different Android-powered devices may have different hardware specifications, such as megapixel ratings and auto-focus capabilities. In order for your application to be compatible with more devices, you should not make assumptions about the device camera specifications.</para><para> <h3>Developer Guides</h3></para><para> </para><para>For more information about using cameras, read the  developer guide.</para><para>  </para>    
		/// </summary>
		/// <java-name>
		/// android/hardware/Camera
		/// </java-name>
		[Dot42.DexImport("android/hardware/Camera", AccessFlags = 33)]
		public partial class Camera
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Broadcast Action: A new picture is taken by the camera, and the entry of the picture has been added to the media store. android.content.Intent#getData is URI of the picture. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_NEW_PICTURE
				/// </java-name>
				[Dot42.DexImport("ACTION_NEW_PICTURE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_NEW_PICTURE = "android.hardware.action.NEW_PICTURE";
				/// <summary>
				/// <para>Broadcast Action: A new video is recorded by the camera, and the entry of the video has been added to the media store. android.content.Intent#getData is URI of the video. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_NEW_VIDEO
				/// </java-name>
				[Dot42.DexImport("ACTION_NEW_VIDEO", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_NEW_VIDEO = "android.hardware.action.NEW_VIDEO";
				/// <summary>
				/// <para>Unspecified camera error. <para>Camera.ErrorCallback </para></para>        
				/// </summary>
				/// <java-name>
				/// CAMERA_ERROR_UNKNOWN
				/// </java-name>
				[Dot42.DexImport("CAMERA_ERROR_UNKNOWN", "I", AccessFlags = 25)]
				public const int CAMERA_ERROR_UNKNOWN = 1;
				/// <summary>
				/// <para>Media server died. In this case, the application must release the Camera object and instantiate a new one. <para>Camera.ErrorCallback </para></para>        
				/// </summary>
				/// <java-name>
				/// CAMERA_ERROR_SERVER_DIED
				/// </java-name>
				[Dot42.DexImport("CAMERA_ERROR_SERVER_DIED", "I", AccessFlags = 25)]
				public const int CAMERA_ERROR_SERVER_DIED = 100;
				/// <summary>
				/// <para>An empty Camera for testing purpose. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal Camera() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the number of physical cameras available on this device. </para>        
				/// </summary>
				/// <java-name>
				/// getNumberOfCameras
				/// </java-name>
				[Dot42.DexImport("getNumberOfCameras", "()I", AccessFlags = 265)]
				public static int GetNumberOfCameras() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the information about a particular camera. If getNumberOfCameras() returns N, the valid id is 0 to N-1. </para>        
				/// </summary>
				/// <java-name>
				/// getCameraInfo
				/// </java-name>
				[Dot42.DexImport("getCameraInfo", "(ILandroid/hardware/Camera$CameraInfo;)V", AccessFlags = 9)]
				public static void GetCameraInfo(int cameraId, global::Android.Hardware.Camera.CameraInfo cameraInfo) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new Camera object to access a particular hardware camera. If the same camera is opened by other applications, this will throw a RuntimeException.</para><para>You must call release() when you are done using the camera, otherwise it will remain locked and be unavailable to other applications.</para><para>Your application should only have one Camera object active at a time for a particular hardware camera.</para><para>Callbacks from other methods are delivered to the event loop of the thread which called open(). If this thread has no event loop, then callbacks are delivered to the main application event loop. If there is no main application event loop, callbacks are not delivered.</para><para><b>Caution:</b> On some devices, this method may take a long time to complete. It is best to call this method from a worker thread (possibly using android.os.AsyncTask) to avoid blocking the main application UI thread.</para><para><para>android.app.admin.DevicePolicyManager::getCameraDisabled(android.content.ComponentName) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>a new Camera object, connected, locked and ready for use. </para>
				/// </returns>
				/// <java-name>
				/// open
				/// </java-name>
				[Dot42.DexImport("open", "(I)Landroid/hardware/Camera;", AccessFlags = 9)]
				public static global::Android.Hardware.Camera Open(int cameraId) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Hardware.Camera);
				}

				/// <summary>
				/// <para>Creates a new Camera object to access the first back-facing camera on the device. If the device does not have a back-facing camera, this returns null. <para>open(int) </para></para>        
				/// </summary>
				/// <java-name>
				/// open
				/// </java-name>
				[Dot42.DexImport("open", "()Landroid/hardware/Camera;", AccessFlags = 9)]
				public static global::Android.Hardware.Camera Open() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Hardware.Camera);
				}

				/// <java-name>
				/// finalize
				/// </java-name>
				[Dot42.DexImport("finalize", "()V", AccessFlags = 4)]
				extern ~Camera() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Disconnects and releases the Camera object resources.</para><para>You must call this as soon as you're done with the Camera object.</para>        
				/// </summary>
				/// <java-name>
				/// release
				/// </java-name>
				[Dot42.DexImport("release", "()V", AccessFlags = 17)]
				public void Release() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Unlocks the camera to allow another process to access it. Normally, the camera is locked to the process with an active Camera object until release() is called. To allow rapid handoff between processes, you can call this method to release the camera temporarily for another process to use; once the other process is done you can call reconnect() to reclaim the camera.</para><para>This must be done before calling android.media.MediaRecorder#setCamera(Camera). This cannot be called after recording starts.</para><para>If you are not recording video, you probably do not need this method.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// unlock
				/// </java-name>
				[Dot42.DexImport("unlock", "()V", AccessFlags = 273)]
				public void Unlock() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Re-locks the camera to prevent other processes from accessing it. Camera objects are locked by default unless unlock() is called. Normally reconnect() is used instead.</para><para>Since API level 14, camera is automatically locked for applications in android.media.MediaRecorder#start(). Applications can use the camera (ex: zoom) after recording starts. There is no need to call this after recording starts or stops.</para><para>If you are not recording video, you probably do not need this method.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// lock
				/// </java-name>
				[Dot42.DexImport("lock", "()V", AccessFlags = 273)]
				public void Lock() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Reconnects to the camera service after another process used it. After unlock() is called, another process may use the camera; when the process is done, you must reconnect to the camera, which will re-acquire the lock and allow you to continue using the camera.</para><para>Since API level 14, camera is automatically locked for applications in android.media.MediaRecorder#start(). Applications can use the camera (ex: zoom) after recording starts. There is no need to call this after recording starts or stops.</para><para>If you are not recording video, you probably do not need this method.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// reconnect
				/// </java-name>
				[Dot42.DexImport("reconnect", "()V", AccessFlags = 273)]
				public void Reconnect() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setPreviewDisplay
				/// </java-name>
				[Dot42.DexImport("setPreviewDisplay", "(Landroid/view/SurfaceHolder;)V", AccessFlags = 17)]
				public void SetPreviewDisplay(global::Android.View.ISurfaceHolder surface) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the SurfaceTexture to be used for live preview. Either a surface or surface texture is necessary for preview, and preview is necessary to take pictures. The same surface texture can be re-set without harm. Setting a preview surface texture will un-set any preview surface that was set via setPreviewDisplay.</para><para>This method must be called before startPreview(). The one exception is that if the preview surface texture is not set (or set to null) before startPreview() is called, then this method may be called once with a non-null parameter to set the preview surface. (This allows camera setup and surface creation to happen in parallel, saving time.) The preview surface texture may not otherwise change while preview is running.</para><para>The timestamps provided by SurfaceTexture#getTimestamp() for a SurfaceTexture set as the preview texture have an unspecified zero point, and cannot be directly compared between different cameras or different instances of the same camera, or across multiple runs of the same program.</para><para>If you are using the preview data to create video or still images, strongly consider using android.media.MediaActionSound to properly indicate image capture or recording start/stop to the user.</para><para><para>android.media.MediaActionSound </para><simplesectsep></simplesectsep><para>android.graphics.SurfaceTexture </para><simplesectsep></simplesectsep><para>android.view.TextureView </para></para>        
				/// </summary>
				/// <java-name>
				/// setPreviewTexture
				/// </java-name>
				[Dot42.DexImport("setPreviewTexture", "(Landroid/graphics/SurfaceTexture;)V", AccessFlags = 273)]
				public void SetPreviewTexture(global::Android.Graphics.SurfaceTexture surfaceTexture) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Starts capturing and drawing preview frames to the screen. Preview will not actually start until a surface is supplied with setPreviewDisplay(SurfaceHolder) or setPreviewTexture(SurfaceTexture).</para><para>If setPreviewCallback(Camera.PreviewCallback), setOneShotPreviewCallback(Camera.PreviewCallback), or setPreviewCallbackWithBuffer(Camera.PreviewCallback) were called, Camera.PreviewCallback#onPreviewFrame(byte[], Camera) will be called when preview data becomes available. </para>        
				/// </summary>
				/// <java-name>
				/// startPreview
				/// </java-name>
				[Dot42.DexImport("startPreview", "()V", AccessFlags = 273)]
				public void StartPreview() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Stops capturing and drawing preview frames to the surface, and resets the camera for a future call to startPreview(). </para>        
				/// </summary>
				/// <java-name>
				/// stopPreview
				/// </java-name>
				[Dot42.DexImport("stopPreview", "()V", AccessFlags = 17)]
				public void StopPreview() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Installs a callback to be invoked for every preview frame in addition to displaying them on the screen. The callback will be repeatedly called for as long as preview is active. This method can be called at any time, even while preview is live. Any other preview callbacks are overridden.</para><para>If you are using the preview data to create video or still images, strongly consider using android.media.MediaActionSound to properly indicate image capture or recording start/stop to the user.</para><para><para>android.media.MediaActionSound </para></para>        
				/// </summary>
				/// <java-name>
				/// setPreviewCallback
				/// </java-name>
				[Dot42.DexImport("setPreviewCallback", "(Landroid/hardware/Camera$PreviewCallback;)V", AccessFlags = 17)]
				public void SetPreviewCallback(global::Android.Hardware.Camera.IPreviewCallback cb) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Installs a callback to be invoked for the next preview frame in addition to displaying it on the screen. After one invocation, the callback is cleared. This method can be called any time, even when preview is live. Any other preview callbacks are overridden.</para><para>If you are using the preview data to create video or still images, strongly consider using android.media.MediaActionSound to properly indicate image capture or recording start/stop to the user.</para><para><para>android.media.MediaActionSound </para></para>        
				/// </summary>
				/// <java-name>
				/// setOneShotPreviewCallback
				/// </java-name>
				[Dot42.DexImport("setOneShotPreviewCallback", "(Landroid/hardware/Camera$PreviewCallback;)V", AccessFlags = 17)]
				public void SetOneShotPreviewCallback(global::Android.Hardware.Camera.IPreviewCallback cb) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Installs a callback to be invoked for every preview frame, using buffers supplied with addCallbackBuffer(byte[]), in addition to displaying them on the screen. The callback will be repeatedly called for as long as preview is active and buffers are available. Any other preview callbacks are overridden.</para><para>The purpose of this method is to improve preview efficiency and frame rate by allowing preview frame memory reuse. You must call addCallbackBuffer(byte[]) at some point  before or after calling this method  or no callbacks will received.</para><para>The buffer queue will be cleared if this method is called with a null callback, setPreviewCallback(Camera.PreviewCallback) is called, or setOneShotPreviewCallback(Camera.PreviewCallback) is called.</para><para>If you are using the preview data to create video or still images, strongly consider using android.media.MediaActionSound to properly indicate image capture or recording start/stop to the user.</para><para><para>addCallbackBuffer(byte[]) </para><simplesectsep></simplesectsep><para>android.media.MediaActionSound </para></para>        
				/// </summary>
				/// <java-name>
				/// setPreviewCallbackWithBuffer
				/// </java-name>
				[Dot42.DexImport("setPreviewCallbackWithBuffer", "(Landroid/hardware/Camera$PreviewCallback;)V", AccessFlags = 17)]
				public void SetPreviewCallbackWithBuffer(global::Android.Hardware.Camera.IPreviewCallback cb) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Adds a pre-allocated buffer to the preview callback buffer queue. Applications can add one or more buffers to the queue. When a preview frame arrives and there is still at least one available buffer, the buffer will be used and removed from the queue. Then preview callback is invoked with the buffer. If a frame arrives and there is no buffer left, the frame is discarded. Applications should add buffers back when they finish processing the data in them.</para><para>For formats besides YV12, the size of the buffer is determined by multiplying the preview image width, height, and bytes per pixel. The width and height can be read from Camera.Parameters#getPreviewSize(). Bytes per pixel can be computed from android.graphics.ImageFormat#getBitsPerPixel(int) / 8, using the image format from Camera.Parameters#getPreviewFormat().</para><para>If using the android.graphics.ImageFormat#YV12 format, the size can be calculated using the equations listed in Camera.Parameters#setPreviewFormat.</para><para>This method is only necessary when setPreviewCallbackWithBuffer(PreviewCallback) is used. When setPreviewCallback(PreviewCallback) or setOneShotPreviewCallback(PreviewCallback) are used, buffers are automatically allocated. When a supplied buffer is too small to hold the preview frame data, preview callback will return null and the buffer will be removed from the buffer queue.</para><para><para>setPreviewCallbackWithBuffer(PreviewCallback) </para></para>        
				/// </summary>
				/// <java-name>
				/// addCallbackBuffer
				/// </java-name>
				[Dot42.DexImport("addCallbackBuffer", "([B)V", AccessFlags = 17)]
				public void AddCallbackBuffer(sbyte[] callbackBuffer) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Adds a pre-allocated buffer to the preview callback buffer queue. Applications can add one or more buffers to the queue. When a preview frame arrives and there is still at least one available buffer, the buffer will be used and removed from the queue. Then preview callback is invoked with the buffer. If a frame arrives and there is no buffer left, the frame is discarded. Applications should add buffers back when they finish processing the data in them.</para><para>For formats besides YV12, the size of the buffer is determined by multiplying the preview image width, height, and bytes per pixel. The width and height can be read from Camera.Parameters#getPreviewSize(). Bytes per pixel can be computed from android.graphics.ImageFormat#getBitsPerPixel(int) / 8, using the image format from Camera.Parameters#getPreviewFormat().</para><para>If using the android.graphics.ImageFormat#YV12 format, the size can be calculated using the equations listed in Camera.Parameters#setPreviewFormat.</para><para>This method is only necessary when setPreviewCallbackWithBuffer(PreviewCallback) is used. When setPreviewCallback(PreviewCallback) or setOneShotPreviewCallback(PreviewCallback) are used, buffers are automatically allocated. When a supplied buffer is too small to hold the preview frame data, preview callback will return null and the buffer will be removed from the buffer queue.</para><para><para>setPreviewCallbackWithBuffer(PreviewCallback) </para></para>        
				/// </summary>
				/// <java-name>
				/// addCallbackBuffer
				/// </java-name>
				[Dot42.DexImport("addCallbackBuffer", "([B)V", AccessFlags = 17, IgnoreFromJava = true)]
				public void AddCallbackBuffer(byte[] callbackBuffer) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Starts camera auto-focus and registers a callback function to run when the camera is focused. This method is only valid when preview is active (between startPreview() and before stopPreview()).</para><para>Callers should check android.hardware.Camera.Parameters#getFocusMode() to determine if this method should be called. If the camera does not support auto-focus, it is a no-op and AutoFocusCallback#onAutoFocus(boolean, Camera) callback will be called immediately.</para><para>If your application should not be installed on devices without auto-focus, you must declare that your application uses auto-focus with the  manifest element.</para><para>If the current flash mode is not android.hardware.Camera.Parameters#FLASH_MODE_OFF, flash may be fired during auto-focus, depending on the driver and camera hardware.</para><para>Auto-exposure lock android.hardware.Camera.Parameters#getAutoExposureLock() and auto-white balance locks android.hardware.Camera.Parameters#getAutoWhiteBalanceLock() do not change during and after autofocus. But auto-focus routine may stop auto-exposure and auto-white balance transiently during focusing.</para><para>Stopping preview with stopPreview(), or triggering still image capture with Camera.PictureCallback, Camera.PictureCallback), will not change the the focus position. Applications must call cancelAutoFocus to reset the focus.</para><para>If autofocus is successful, consider using android.media.MediaActionSound to properly play back an autofocus success sound to the user.</para><para><para>cancelAutoFocus() </para><simplesectsep></simplesectsep><para>android.hardware.Camera.Parameters::setAutoExposureLock(boolean) </para><simplesectsep></simplesectsep><para>android.hardware.Camera.Parameters::setAutoWhiteBalanceLock(boolean) </para><simplesectsep></simplesectsep><para>android.media.MediaActionSound </para></para>        
				/// </summary>
				/// <java-name>
				/// autoFocus
				/// </java-name>
				[Dot42.DexImport("autoFocus", "(Landroid/hardware/Camera$AutoFocusCallback;)V", AccessFlags = 17)]
				public void AutoFocus(global::Android.Hardware.Camera.IAutoFocusCallback cb) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Cancels any auto-focus function in progress. Whether or not auto-focus is currently in progress, this function will return the focus position to the default. If the camera does not support auto-focus, this is a no-op.</para><para><para>autoFocus(Camera.AutoFocusCallback) </para></para>        
				/// </summary>
				/// <java-name>
				/// cancelAutoFocus
				/// </java-name>
				[Dot42.DexImport("cancelAutoFocus", "()V", AccessFlags = 17)]
				public void CancelAutoFocus() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets camera auto-focus move callback.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setAutoFocusMoveCallback
				/// </java-name>
				[Dot42.DexImport("setAutoFocusMoveCallback", "(Landroid/hardware/Camera$AutoFocusMoveCallback;)V", AccessFlags = 1)]
				public virtual void SetAutoFocusMoveCallback(global::Android.Hardware.Camera.IAutoFocusMoveCallback cb) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Equivalent to takePicture(shutter, raw, null, jpeg).</para><para><para>takePicture(ShutterCallback, PictureCallback, PictureCallback, PictureCallback) </para></para>        
				/// </summary>
				/// <java-name>
				/// takePicture
				/// </java-name>
				[Dot42.DexImport("takePicture", "(Landroid/hardware/Camera$ShutterCallback;Landroid/hardware/Camera$PictureCallbac" +
    "k;Landroid/hardware/Camera$PictureCallback;)V", AccessFlags = 17)]
				public void TakePicture(global::Android.Hardware.Camera.IShutterCallback shutter, global::Android.Hardware.Camera.IPictureCallback raw, global::Android.Hardware.Camera.IPictureCallback jpeg) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Triggers an asynchronous image capture. The camera service will initiate a series of callbacks to the application as the image capture progresses. The shutter callback occurs after the image is captured. This can be used to trigger a sound to let the user know that image has been captured. The raw callback occurs when the raw image data is available (NOTE: the data will be null if there is no raw image callback buffer available or the raw image callback buffer is not large enough to hold the raw image). The postview callback occurs when a scaled, fully processed postview image is available (NOTE: not all hardware supports this). The jpeg callback occurs when the compressed image is available. If the application does not need a particular callback, a null can be passed instead of a callback method.</para><para>This method is only valid when preview is active (after startPreview()). Preview will be stopped after the image is taken; callers must call startPreview() again if they want to re-start preview or take more pictures. This should not be called between android.media.MediaRecorder#start() and android.media.MediaRecorder#stop().</para><para>After calling this method, you must not call startPreview() or take another picture until the JPEG callback has returned.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// takePicture
				/// </java-name>
				[Dot42.DexImport("takePicture", "(Landroid/hardware/Camera$ShutterCallback;Landroid/hardware/Camera$PictureCallbac" +
    "k;Landroid/hardware/Camera$PictureCallback;Landroid/hardware/Camera$PictureCallb" +
    "ack;)V", AccessFlags = 17)]
				public void TakePicture(global::Android.Hardware.Camera.IShutterCallback shutter, global::Android.Hardware.Camera.IPictureCallback raw, global::Android.Hardware.Camera.IPictureCallback postview, global::Android.Hardware.Camera.IPictureCallback jpeg) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Zooms to the requested value smoothly. The driver will notify OnZoomChangeListener of the zoom value and whether zoom is stopped at the time. For example, suppose the current zoom is 0 and startSmoothZoom is called with value 3. The Camera.OnZoomChangeListener#onZoomChange(int, boolean, Camera) method will be called three times with zoom values 1, 2, and 3. Applications can call stopSmoothZoom to stop the zoom earlier. Applications should not call startSmoothZoom again or change the zoom value before zoom stops. If the supplied zoom value equals to the current zoom value, no zoom callback will be generated. This method is supported if android.hardware.Camera.Parameters#isSmoothZoomSupported returns true.</para><para><para>setZoomChangeListener(OnZoomChangeListener) </para></para>        
				/// </summary>
				/// <java-name>
				/// startSmoothZoom
				/// </java-name>
				[Dot42.DexImport("startSmoothZoom", "(I)V", AccessFlags = 273)]
				public void StartSmoothZoom(int value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Stops the smooth zoom. Applications should wait for the OnZoomChangeListener to know when the zoom is actually stopped. This method is supported if android.hardware.Camera.Parameters#isSmoothZoomSupported is true.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// stopSmoothZoom
				/// </java-name>
				[Dot42.DexImport("stopSmoothZoom", "()V", AccessFlags = 273)]
				public void StopSmoothZoom() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Set the clockwise rotation of preview display in degrees. This affects the preview frames and the picture displayed after snapshot. This method is useful for portrait mode applications. Note that preview display of front-facing cameras is flipped horizontally before the rotation, that is, the image is reflected along the central vertical axis of the camera sensor. So the users can see themselves as looking into a mirror.</para><para>This does not affect the order of byte array passed in PreviewCallback#onPreviewFrame, JPEG pictures, or recorded videos. This method is not allowed to be called during preview.</para><para>If you want to make the camera image show in the same orientation as the display, you can use the following code. <pre>
				///        public static void setCameraDisplayOrientation(Activity activity,
				///                int cameraId, android.hardware.Camera camera) {
				///            android.hardware.Camera.CameraInfo info =
				///                    new android.hardware.Camera.CameraInfo();
				///            android.hardware.Camera.getCameraInfo(cameraId, info);
				///            int rotation = activity.getWindowManager().getDefaultDisplay()
				///                    .getRotation();
				///            int degrees = 0;
				///            switch (rotation) {
				///                case Surface.ROTATION_0: degrees = 0; break;
				///                case Surface.ROTATION_90: degrees = 90; break;
				///                case Surface.ROTATION_180: degrees = 180; break;
				///                case Surface.ROTATION_270: degrees = 270; break;
				///            }
				/// 
				///            int result;
				///            if (info.facing == Camera.CameraInfo.CAMERA_FACING_FRONT) {
				///                result = (info.orientation + degrees) % 360;
				///                result = (360 - result) % 360;  // compensate the mirror
				///            } else {  // back-facing
				///                result = (info.orientation - degrees + 360) % 360;
				///            }
				///            camera.setDisplayOrientation(result);
				///        }
				///        </pre></para><para>Starting from API level 14, this method can be called when preview is active.</para><para><para>setPreviewDisplay(SurfaceHolder) </para></para>        
				/// </summary>
				/// <java-name>
				/// setDisplayOrientation
				/// </java-name>
				[Dot42.DexImport("setDisplayOrientation", "(I)V", AccessFlags = 273)]
				public void SetDisplayOrientation(int degrees) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Enable or disable the default shutter sound when taking a picture.</para><para>By default, the camera plays the system-defined camera shutter sound when takePicture is called. Using this method, the shutter sound can be disabled. It is strongly recommended that an alternative shutter sound is played in the ShutterCallback when the system shutter sound is disabled.</para><para>Note that devices may not always allow disabling the camera shutter sound. If the shutter sound state cannot be set to the desired value, this method will return false. CameraInfo#canDisableShutterSound can be used to determine whether the device will allow the shutter sound to be disabled.</para><para><para>takePicture </para><simplesectsep></simplesectsep><para>CameraInfo::canDisableShutterSound </para><simplesectsep></simplesectsep><para>ShutterCallback </para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the shutter sound state was successfully changed. <c> false </c> if the shutter sound state could not be changed. <c> true </c> is also returned if shutter sound playback is already set to the requested state. </para>
				/// </returns>
				/// <java-name>
				/// enableShutterSound
				/// </java-name>
				[Dot42.DexImport("enableShutterSound", "(Z)Z", AccessFlags = 17)]
				public bool EnableShutterSound(bool enabled) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Registers a listener to be notified when the zoom value is updated by the camera driver during smooth zoom.</para><para><para>startSmoothZoom(int) </para></para>        
				/// </summary>
				/// <java-name>
				/// setZoomChangeListener
				/// </java-name>
				[Dot42.DexImport("setZoomChangeListener", "(Landroid/hardware/Camera$OnZoomChangeListener;)V", AccessFlags = 17)]
				public void SetZoomChangeListener(global::Android.Hardware.Camera.IOnZoomChangeListener listener) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Registers a listener to be notified about the faces detected in the preview frame.</para><para><para>startFaceDetection() </para></para>        
				/// </summary>
				/// <java-name>
				/// setFaceDetectionListener
				/// </java-name>
				[Dot42.DexImport("setFaceDetectionListener", "(Landroid/hardware/Camera$FaceDetectionListener;)V", AccessFlags = 17)]
				public void SetFaceDetectionListener(global::Android.Hardware.Camera.IFaceDetectionListener listener) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Starts the face detection. This should be called after preview is started. The camera will notify FaceDetectionListener of the detected faces in the preview frame. The detected faces may be the same as the previous ones. Applications should call stopFaceDetection to stop the face detection. This method is supported if Parameters#getMaxNumDetectedFaces() returns a number larger than 0. If the face detection has started, apps should not call this again.</para><para>When the face detection is running, Parameters#setWhiteBalance(String), Parameters#setFocusAreas(List), and Parameters#setMeteringAreas(List) have no effect. The camera uses the detected faces to do auto-white balance, auto exposure, and autofocus.</para><para>If the apps call autoFocus(AutoFocusCallback), the camera will stop sending face callbacks. The last face callback indicates the areas used to do autofocus. After focus completes, face detection will resume sending face callbacks. If the apps call cancelAutoFocus(), the face callbacks will also resume.</para><para>After calling Camera.PictureCallback, Camera.PictureCallback) or stopPreview(), and then resuming preview with startPreview(), the apps should call this method again to resume face detection.</para><para><para>FaceDetectionListener </para><simplesectsep></simplesectsep><para>stopFaceDetection() </para><simplesectsep></simplesectsep><para>Parameters::getMaxNumDetectedFaces() </para></para>        
				/// </summary>
				/// <java-name>
				/// startFaceDetection
				/// </java-name>
				[Dot42.DexImport("startFaceDetection", "()V", AccessFlags = 17)]
				public void StartFaceDetection() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Stops the face detection.</para><para><para>startFaceDetection() </para></para>        
				/// </summary>
				/// <java-name>
				/// stopFaceDetection
				/// </java-name>
				[Dot42.DexImport("stopFaceDetection", "()V", AccessFlags = 17)]
				public void StopFaceDetection() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Registers a callback to be invoked when an error occurs. </para>        
				/// </summary>
				/// <java-name>
				/// setErrorCallback
				/// </java-name>
				[Dot42.DexImport("setErrorCallback", "(Landroid/hardware/Camera$ErrorCallback;)V", AccessFlags = 17)]
				public void SetErrorCallback(global::Android.Hardware.Camera.IErrorCallback cb) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Changes the settings for this Camera service.</para><para><para>getParameters() </para></para>        
				/// </summary>
				/// <java-name>
				/// setParameters
				/// </java-name>
				[Dot42.DexImport("setParameters", "(Landroid/hardware/Camera$Parameters;)V", AccessFlags = 1)]
				public virtual void SetParameters(global::Android.Hardware.Camera.Parameters @params) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the current settings for this Camera service. If modifications are made to the returned Parameters, they must be passed to setParameters(Camera.Parameters) to take effect.</para><para><para>setParameters(Camera.Parameters) </para></para>        
				/// </summary>
				/// <java-name>
				/// getParameters
				/// </java-name>
				[Dot42.DexImport("getParameters", "()Landroid/hardware/Camera$Parameters;", AccessFlags = 1)]
				public virtual global::Android.Hardware.Camera.Parameters GetParameters() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Hardware.Camera.Parameters);
				}

				/// <summary>
				/// <para>Returns the number of physical cameras available on this device. </para>        
				/// </summary>
				/// <java-name>
				/// getNumberOfCameras
				/// </java-name>
				public static int NumberOfCameras
				{
				[Dot42.DexImport("getNumberOfCameras", "()I", AccessFlags = 265)]
						get{ return GetNumberOfCameras(); }
				}

				/// <summary>
				/// <para>Camera service settings.</para><para>To make camera parameters take effect, applications have to call Camera#setParameters(Camera.Parameters). For example, after Camera.Parameters#setWhiteBalance is called, white balance is not actually changed until Camera#setParameters(Camera.Parameters) is called with the changed parameters object.</para><para>Different devices may have different camera capabilities, such as picture size or flash modes. The application should query the camera capabilities before setting parameters. For example, the application should call Camera.Parameters#getSupportedColorEffects() before calling Camera.Parameters#setColorEffect(String). If the camera does not support color effects, Camera.Parameters#getSupportedColorEffects() will return null. </para>    
				/// </summary>
				/// <java-name>
				/// android/hardware/Camera$Parameters
				/// </java-name>
				[Dot42.DexImport("android/hardware/Camera$Parameters", AccessFlags = 1)]
				public partial class Parameters
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// WHITE_BALANCE_AUTO
						/// </java-name>
						[Dot42.DexImport("WHITE_BALANCE_AUTO", "Ljava/lang/String;", AccessFlags = 25)]
						public const string WHITE_BALANCE_AUTO = "auto";
						/// <java-name>
						/// WHITE_BALANCE_INCANDESCENT
						/// </java-name>
						[Dot42.DexImport("WHITE_BALANCE_INCANDESCENT", "Ljava/lang/String;", AccessFlags = 25)]
						public const string WHITE_BALANCE_INCANDESCENT = "incandescent";
						/// <java-name>
						/// WHITE_BALANCE_FLUORESCENT
						/// </java-name>
						[Dot42.DexImport("WHITE_BALANCE_FLUORESCENT", "Ljava/lang/String;", AccessFlags = 25)]
						public const string WHITE_BALANCE_FLUORESCENT = "fluorescent";
						/// <java-name>
						/// WHITE_BALANCE_WARM_FLUORESCENT
						/// </java-name>
						[Dot42.DexImport("WHITE_BALANCE_WARM_FLUORESCENT", "Ljava/lang/String;", AccessFlags = 25)]
						public const string WHITE_BALANCE_WARM_FLUORESCENT = "warm-fluorescent";
						/// <java-name>
						/// WHITE_BALANCE_DAYLIGHT
						/// </java-name>
						[Dot42.DexImport("WHITE_BALANCE_DAYLIGHT", "Ljava/lang/String;", AccessFlags = 25)]
						public const string WHITE_BALANCE_DAYLIGHT = "daylight";
						/// <java-name>
						/// WHITE_BALANCE_CLOUDY_DAYLIGHT
						/// </java-name>
						[Dot42.DexImport("WHITE_BALANCE_CLOUDY_DAYLIGHT", "Ljava/lang/String;", AccessFlags = 25)]
						public const string WHITE_BALANCE_CLOUDY_DAYLIGHT = "cloudy-daylight";
						/// <java-name>
						/// WHITE_BALANCE_TWILIGHT
						/// </java-name>
						[Dot42.DexImport("WHITE_BALANCE_TWILIGHT", "Ljava/lang/String;", AccessFlags = 25)]
						public const string WHITE_BALANCE_TWILIGHT = "twilight";
						/// <java-name>
						/// WHITE_BALANCE_SHADE
						/// </java-name>
						[Dot42.DexImport("WHITE_BALANCE_SHADE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string WHITE_BALANCE_SHADE = "shade";
						/// <java-name>
						/// EFFECT_NONE
						/// </java-name>
						[Dot42.DexImport("EFFECT_NONE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string EFFECT_NONE = "none";
						/// <java-name>
						/// EFFECT_MONO
						/// </java-name>
						[Dot42.DexImport("EFFECT_MONO", "Ljava/lang/String;", AccessFlags = 25)]
						public const string EFFECT_MONO = "mono";
						/// <java-name>
						/// EFFECT_NEGATIVE
						/// </java-name>
						[Dot42.DexImport("EFFECT_NEGATIVE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string EFFECT_NEGATIVE = "negative";
						/// <java-name>
						/// EFFECT_SOLARIZE
						/// </java-name>
						[Dot42.DexImport("EFFECT_SOLARIZE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string EFFECT_SOLARIZE = "solarize";
						/// <java-name>
						/// EFFECT_SEPIA
						/// </java-name>
						[Dot42.DexImport("EFFECT_SEPIA", "Ljava/lang/String;", AccessFlags = 25)]
						public const string EFFECT_SEPIA = "sepia";
						/// <java-name>
						/// EFFECT_POSTERIZE
						/// </java-name>
						[Dot42.DexImport("EFFECT_POSTERIZE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string EFFECT_POSTERIZE = "posterize";
						/// <java-name>
						/// EFFECT_WHITEBOARD
						/// </java-name>
						[Dot42.DexImport("EFFECT_WHITEBOARD", "Ljava/lang/String;", AccessFlags = 25)]
						public const string EFFECT_WHITEBOARD = "whiteboard";
						/// <java-name>
						/// EFFECT_BLACKBOARD
						/// </java-name>
						[Dot42.DexImport("EFFECT_BLACKBOARD", "Ljava/lang/String;", AccessFlags = 25)]
						public const string EFFECT_BLACKBOARD = "blackboard";
						/// <java-name>
						/// EFFECT_AQUA
						/// </java-name>
						[Dot42.DexImport("EFFECT_AQUA", "Ljava/lang/String;", AccessFlags = 25)]
						public const string EFFECT_AQUA = "aqua";
						/// <java-name>
						/// ANTIBANDING_AUTO
						/// </java-name>
						[Dot42.DexImport("ANTIBANDING_AUTO", "Ljava/lang/String;", AccessFlags = 25)]
						public const string ANTIBANDING_AUTO = "auto";
						/// <java-name>
						/// ANTIBANDING_50HZ
						/// </java-name>
						[Dot42.DexImport("ANTIBANDING_50HZ", "Ljava/lang/String;", AccessFlags = 25)]
						public const string ANTIBANDING_50HZ = "50hz";
						/// <java-name>
						/// ANTIBANDING_60HZ
						/// </java-name>
						[Dot42.DexImport("ANTIBANDING_60HZ", "Ljava/lang/String;", AccessFlags = 25)]
						public const string ANTIBANDING_60HZ = "60hz";
						/// <java-name>
						/// ANTIBANDING_OFF
						/// </java-name>
						[Dot42.DexImport("ANTIBANDING_OFF", "Ljava/lang/String;", AccessFlags = 25)]
						public const string ANTIBANDING_OFF = "off";
						/// <summary>
						/// <para>Flash will not be fired. </para>        
						/// </summary>
						/// <java-name>
						/// FLASH_MODE_OFF
						/// </java-name>
						[Dot42.DexImport("FLASH_MODE_OFF", "Ljava/lang/String;", AccessFlags = 25)]
						public const string FLASH_MODE_OFF = "off";
						/// <summary>
						/// <para>Flash will be fired automatically when required. The flash may be fired during preview, auto-focus, or snapshot depending on the driver. </para>        
						/// </summary>
						/// <java-name>
						/// FLASH_MODE_AUTO
						/// </java-name>
						[Dot42.DexImport("FLASH_MODE_AUTO", "Ljava/lang/String;", AccessFlags = 25)]
						public const string FLASH_MODE_AUTO = "auto";
						/// <summary>
						/// <para>Flash will always be fired during snapshot. The flash may also be fired during preview or auto-focus depending on the driver. </para>        
						/// </summary>
						/// <java-name>
						/// FLASH_MODE_ON
						/// </java-name>
						[Dot42.DexImport("FLASH_MODE_ON", "Ljava/lang/String;", AccessFlags = 25)]
						public const string FLASH_MODE_ON = "on";
						/// <summary>
						/// <para>Flash will be fired in red-eye reduction mode. </para>        
						/// </summary>
						/// <java-name>
						/// FLASH_MODE_RED_EYE
						/// </java-name>
						[Dot42.DexImport("FLASH_MODE_RED_EYE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string FLASH_MODE_RED_EYE = "red-eye";
						/// <summary>
						/// <para>Constant emission of light during preview, auto-focus and snapshot. This can also be used for video recording. </para>        
						/// </summary>
						/// <java-name>
						/// FLASH_MODE_TORCH
						/// </java-name>
						[Dot42.DexImport("FLASH_MODE_TORCH", "Ljava/lang/String;", AccessFlags = 25)]
						public const string FLASH_MODE_TORCH = "torch";
						/// <summary>
						/// <para>Scene mode is off. </para>        
						/// </summary>
						/// <java-name>
						/// SCENE_MODE_AUTO
						/// </java-name>
						[Dot42.DexImport("SCENE_MODE_AUTO", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SCENE_MODE_AUTO = "auto";
						/// <summary>
						/// <para>Take photos of fast moving objects. Same as SCENE_MODE_SPORTS. </para>        
						/// </summary>
						/// <java-name>
						/// SCENE_MODE_ACTION
						/// </java-name>
						[Dot42.DexImport("SCENE_MODE_ACTION", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SCENE_MODE_ACTION = "action";
						/// <summary>
						/// <para>Take people pictures. </para>        
						/// </summary>
						/// <java-name>
						/// SCENE_MODE_PORTRAIT
						/// </java-name>
						[Dot42.DexImport("SCENE_MODE_PORTRAIT", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SCENE_MODE_PORTRAIT = "portrait";
						/// <summary>
						/// <para>Take pictures on distant objects. </para>        
						/// </summary>
						/// <java-name>
						/// SCENE_MODE_LANDSCAPE
						/// </java-name>
						[Dot42.DexImport("SCENE_MODE_LANDSCAPE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SCENE_MODE_LANDSCAPE = "landscape";
						/// <summary>
						/// <para>Take photos at night. </para>        
						/// </summary>
						/// <java-name>
						/// SCENE_MODE_NIGHT
						/// </java-name>
						[Dot42.DexImport("SCENE_MODE_NIGHT", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SCENE_MODE_NIGHT = "night";
						/// <summary>
						/// <para>Take people pictures at night. </para>        
						/// </summary>
						/// <java-name>
						/// SCENE_MODE_NIGHT_PORTRAIT
						/// </java-name>
						[Dot42.DexImport("SCENE_MODE_NIGHT_PORTRAIT", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SCENE_MODE_NIGHT_PORTRAIT = "night-portrait";
						/// <summary>
						/// <para>Take photos in a theater. Flash light is off. </para>        
						/// </summary>
						/// <java-name>
						/// SCENE_MODE_THEATRE
						/// </java-name>
						[Dot42.DexImport("SCENE_MODE_THEATRE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SCENE_MODE_THEATRE = "theatre";
						/// <summary>
						/// <para>Take pictures on the beach. </para>        
						/// </summary>
						/// <java-name>
						/// SCENE_MODE_BEACH
						/// </java-name>
						[Dot42.DexImport("SCENE_MODE_BEACH", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SCENE_MODE_BEACH = "beach";
						/// <summary>
						/// <para>Take pictures on the snow. </para>        
						/// </summary>
						/// <java-name>
						/// SCENE_MODE_SNOW
						/// </java-name>
						[Dot42.DexImport("SCENE_MODE_SNOW", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SCENE_MODE_SNOW = "snow";
						/// <summary>
						/// <para>Take sunset photos. </para>        
						/// </summary>
						/// <java-name>
						/// SCENE_MODE_SUNSET
						/// </java-name>
						[Dot42.DexImport("SCENE_MODE_SUNSET", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SCENE_MODE_SUNSET = "sunset";
						/// <summary>
						/// <para>Avoid blurry pictures (for example, due to hand shake). </para>        
						/// </summary>
						/// <java-name>
						/// SCENE_MODE_STEADYPHOTO
						/// </java-name>
						[Dot42.DexImport("SCENE_MODE_STEADYPHOTO", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SCENE_MODE_STEADYPHOTO = "steadyphoto";
						/// <summary>
						/// <para>For shooting firework displays. </para>        
						/// </summary>
						/// <java-name>
						/// SCENE_MODE_FIREWORKS
						/// </java-name>
						[Dot42.DexImport("SCENE_MODE_FIREWORKS", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SCENE_MODE_FIREWORKS = "fireworks";
						/// <summary>
						/// <para>Take photos of fast moving objects. Same as SCENE_MODE_ACTION. </para>        
						/// </summary>
						/// <java-name>
						/// SCENE_MODE_SPORTS
						/// </java-name>
						[Dot42.DexImport("SCENE_MODE_SPORTS", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SCENE_MODE_SPORTS = "sports";
						/// <summary>
						/// <para>Take indoor low-light shot. </para>        
						/// </summary>
						/// <java-name>
						/// SCENE_MODE_PARTY
						/// </java-name>
						[Dot42.DexImport("SCENE_MODE_PARTY", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SCENE_MODE_PARTY = "party";
						/// <summary>
						/// <para>Capture the naturally warm color of scenes lit by candles. </para>        
						/// </summary>
						/// <java-name>
						/// SCENE_MODE_CANDLELIGHT
						/// </java-name>
						[Dot42.DexImport("SCENE_MODE_CANDLELIGHT", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SCENE_MODE_CANDLELIGHT = "candlelight";
						/// <summary>
						/// <para>Applications are looking for a barcode. Camera driver will be optimized for barcode reading. </para>        
						/// </summary>
						/// <java-name>
						/// SCENE_MODE_BARCODE
						/// </java-name>
						[Dot42.DexImport("SCENE_MODE_BARCODE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SCENE_MODE_BARCODE = "barcode";
						/// <summary>
						/// <para>Capture a scene using high dynamic range imaging techniques. The camera will return an image that has an extended dynamic range compared to a regular capture. Capturing such an image may take longer than a regular capture. </para>        
						/// </summary>
						/// <java-name>
						/// SCENE_MODE_HDR
						/// </java-name>
						[Dot42.DexImport("SCENE_MODE_HDR", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SCENE_MODE_HDR = "hdr";
						/// <summary>
						/// <para>Auto-focus mode. Applications should call autoFocus(AutoFocusCallback) to start the focus in this mode. </para>        
						/// </summary>
						/// <java-name>
						/// FOCUS_MODE_AUTO
						/// </java-name>
						[Dot42.DexImport("FOCUS_MODE_AUTO", "Ljava/lang/String;", AccessFlags = 25)]
						public const string FOCUS_MODE_AUTO = "auto";
						/// <summary>
						/// <para>Focus is set at infinity. Applications should not call autoFocus(AutoFocusCallback) in this mode. </para>        
						/// </summary>
						/// <java-name>
						/// FOCUS_MODE_INFINITY
						/// </java-name>
						[Dot42.DexImport("FOCUS_MODE_INFINITY", "Ljava/lang/String;", AccessFlags = 25)]
						public const string FOCUS_MODE_INFINITY = "infinity";
						/// <summary>
						/// <para>Macro (close-up) focus mode. Applications should call autoFocus(AutoFocusCallback) to start the focus in this mode. </para>        
						/// </summary>
						/// <java-name>
						/// FOCUS_MODE_MACRO
						/// </java-name>
						[Dot42.DexImport("FOCUS_MODE_MACRO", "Ljava/lang/String;", AccessFlags = 25)]
						public const string FOCUS_MODE_MACRO = "macro";
						/// <summary>
						/// <para>Focus is fixed. The camera is always in this mode if the focus is not adjustable. If the camera has auto-focus, this mode can fix the focus, which is usually at hyperfocal distance. Applications should not call autoFocus(AutoFocusCallback) in this mode. </para>        
						/// </summary>
						/// <java-name>
						/// FOCUS_MODE_FIXED
						/// </java-name>
						[Dot42.DexImport("FOCUS_MODE_FIXED", "Ljava/lang/String;", AccessFlags = 25)]
						public const string FOCUS_MODE_FIXED = "fixed";
						/// <summary>
						/// <para>Extended depth of field (EDOF). Focusing is done digitally and continuously. Applications should not call autoFocus(AutoFocusCallback) in this mode. </para>        
						/// </summary>
						/// <java-name>
						/// FOCUS_MODE_EDOF
						/// </java-name>
						[Dot42.DexImport("FOCUS_MODE_EDOF", "Ljava/lang/String;", AccessFlags = 25)]
						public const string FOCUS_MODE_EDOF = "edof";
						/// <summary>
						/// <para>Continuous auto focus mode intended for video recording. The camera continuously tries to focus. This is the best choice for video recording because the focus changes smoothly . Applications still can call Camera.PictureCallback, Camera.PictureCallback) in this mode but the subject may not be in focus. Auto focus starts when the parameter is set.</para><para>Since API level 14, applications can call autoFocus(AutoFocusCallback) in this mode. The focus callback will immediately return with a boolean that indicates whether the focus is sharp or not. The focus position is locked after autoFocus call. If applications want to resume the continuous focus, cancelAutoFocus must be called. Restarting the preview will not resume the continuous autofocus. To stop continuous focus, applications should change the focus mode to other modes.</para><para><para>FOCUS_MODE_CONTINUOUS_PICTURE </para></para>        
						/// </summary>
						/// <java-name>
						/// FOCUS_MODE_CONTINUOUS_VIDEO
						/// </java-name>
						[Dot42.DexImport("FOCUS_MODE_CONTINUOUS_VIDEO", "Ljava/lang/String;", AccessFlags = 25)]
						public const string FOCUS_MODE_CONTINUOUS_VIDEO = "continuous-video";
						/// <summary>
						/// <para>Continuous auto focus mode intended for taking pictures. The camera continuously tries to focus. The speed of focus change is more aggressive than FOCUS_MODE_CONTINUOUS_VIDEO. Auto focus starts when the parameter is set.</para><para>Applications can call autoFocus(AutoFocusCallback) in this mode. If the autofocus is in the middle of scanning, the focus callback will return when it completes. If the autofocus is not scanning, the focus callback will immediately return with a boolean that indicates whether the focus is sharp or not. The apps can then decide if they want to take a picture immediately or to change the focus mode to auto, and run a full autofocus cycle. The focus position is locked after autoFocus call. If applications want to resume the continuous focus, cancelAutoFocus must be called. Restarting the preview will not resume the continuous autofocus. To stop continuous focus, applications should change the focus mode to other modes.</para><para><para>FOCUS_MODE_CONTINUOUS_VIDEO </para></para>        
						/// </summary>
						/// <java-name>
						/// FOCUS_MODE_CONTINUOUS_PICTURE
						/// </java-name>
						[Dot42.DexImport("FOCUS_MODE_CONTINUOUS_PICTURE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string FOCUS_MODE_CONTINUOUS_PICTURE = "continuous-picture";
						/// <summary>
						/// <para>The array index of near focus distance for use with getFocusDistances(float[]). </para>        
						/// </summary>
						/// <java-name>
						/// FOCUS_DISTANCE_NEAR_INDEX
						/// </java-name>
						[Dot42.DexImport("FOCUS_DISTANCE_NEAR_INDEX", "I", AccessFlags = 25)]
						public const int FOCUS_DISTANCE_NEAR_INDEX = 0;
						/// <summary>
						/// <para>The array index of optimal focus distance for use with getFocusDistances(float[]). </para>        
						/// </summary>
						/// <java-name>
						/// FOCUS_DISTANCE_OPTIMAL_INDEX
						/// </java-name>
						[Dot42.DexImport("FOCUS_DISTANCE_OPTIMAL_INDEX", "I", AccessFlags = 25)]
						public const int FOCUS_DISTANCE_OPTIMAL_INDEX = 1;
						/// <summary>
						/// <para>The array index of far focus distance for use with getFocusDistances(float[]). </para>        
						/// </summary>
						/// <java-name>
						/// FOCUS_DISTANCE_FAR_INDEX
						/// </java-name>
						[Dot42.DexImport("FOCUS_DISTANCE_FAR_INDEX", "I", AccessFlags = 25)]
						public const int FOCUS_DISTANCE_FAR_INDEX = 2;
						/// <summary>
						/// <para>The array index of minimum preview fps for use with getPreviewFpsRange(int[]) or getSupportedPreviewFpsRange(). </para>        
						/// </summary>
						/// <java-name>
						/// PREVIEW_FPS_MIN_INDEX
						/// </java-name>
						[Dot42.DexImport("PREVIEW_FPS_MIN_INDEX", "I", AccessFlags = 25)]
						public const int PREVIEW_FPS_MIN_INDEX = 0;
						/// <summary>
						/// <para>The array index of maximum preview fps for use with getPreviewFpsRange(int[]) or getSupportedPreviewFpsRange(). </para>        
						/// </summary>
						/// <java-name>
						/// PREVIEW_FPS_MAX_INDEX
						/// </java-name>
						[Dot42.DexImport("PREVIEW_FPS_MAX_INDEX", "I", AccessFlags = 25)]
						public const int PREVIEW_FPS_MAX_INDEX = 1;
						/// <java-name>
						/// this$0
						/// </java-name>
						[Dot42.DexImport("this$0", "Landroid/hardware/Camera;", AccessFlags = 4112)]
						internal readonly global::Android.Hardware.Camera This_0;
						[Dot42.DexImport("<init>", "(Landroid/hardware/Camera;)V", AccessFlags = 0)]
						internal Parameters(global::Android.Hardware.Camera camera) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						/// <para>Creates a single string with all the parameters set in this Parameters object. </para><para>The unflatten(String) method does the reverse.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>a String with all values from this Parameters object, in semi-colon delimited key-value pairs </para>
						/// </returns>
						/// <java-name>
						/// flatten
						/// </java-name>
						[Dot42.DexImport("flatten", "()Ljava/lang/String;", AccessFlags = 1)]
						public virtual string Flatten() /* MethodBuilder.Create */ 
						{
								return default(string);
						}

						/// <summary>
						/// <para>Takes a flattened string of parameters and adds each one to this Parameters object. </para><para>The flatten() method does the reverse.</para><para></para>        
						/// </summary>
						/// <java-name>
						/// unflatten
						/// </java-name>
						[Dot42.DexImport("unflatten", "(Ljava/lang/String;)V", AccessFlags = 1)]
						public virtual void Unflatten(string flattened) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// remove
						/// </java-name>
						[Dot42.DexImport("remove", "(Ljava/lang/String;)V", AccessFlags = 1)]
						public virtual void Remove(string key) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// set
						/// </java-name>
						[Dot42.DexImport("set", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
						public virtual void Set(string @string, string string1) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// set
						/// </java-name>
						[Dot42.DexImport("set", "(Ljava/lang/String;I)V", AccessFlags = 1)]
						public virtual void Set(string @string, int int32) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						/// <para>Returns the value of a String parameter.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>the String value of the parameter </para>
						/// </returns>
						/// <java-name>
						/// get
						/// </java-name>
						[Dot42.DexImport("get", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1)]
						public virtual string Get(string key) /* MethodBuilder.Create */ 
						{
								return default(string);
						}

						/// <summary>
						/// <para>Returns the value of an integer parameter.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>the int value of the parameter </para>
						/// </returns>
						/// <java-name>
						/// getInt
						/// </java-name>
						[Dot42.DexImport("getInt", "(Ljava/lang/String;)I", AccessFlags = 1)]
						public virtual int GetInt(string key) /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <summary>
						/// <para>Sets the dimensions for preview pictures. If the preview has already started, applications should stop the preview first before changing preview size.</para><para>The sides of width and height are based on camera orientation. That is, the preview size is the size before it is rotated by display orientation. So applications need to consider the display orientation while setting preview size. For example, suppose the camera supports both 480x320 and 320x480 preview sizes. The application wants a 3:2 preview ratio. If the display orientation is set to 0 or 180, preview size should be set to 480x320. If the display orientation is set to 90 or 270, preview size should be set to 320x480. The display orientation should also be considered while setting picture size and thumbnail size.</para><para><para>setDisplayOrientation(int) </para><simplesectsep></simplesectsep><para>getCameraInfo(int, CameraInfo) </para><simplesectsep></simplesectsep><para>setPictureSize(int, int) </para><simplesectsep></simplesectsep><para>setJpegThumbnailSize(int, int) </para></para>        
						/// </summary>
						/// <java-name>
						/// setPreviewSize
						/// </java-name>
						[Dot42.DexImport("setPreviewSize", "(II)V", AccessFlags = 1)]
						public virtual void SetPreviewSize(int width, int height) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						/// <para>Returns the dimensions setting for preview pictures.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>a Size object with the width and height setting for the preview picture </para>
						/// </returns>
						/// <java-name>
						/// getPreviewSize
						/// </java-name>
						[Dot42.DexImport("getPreviewSize", "()Landroid/hardware/Camera$Size;", AccessFlags = 1)]
						public virtual global::Android.Hardware.Camera.Size GetPreviewSize() /* MethodBuilder.Create */ 
						{
								return default(global::Android.Hardware.Camera.Size);
						}

						/// <summary>
						/// <para>Gets the supported preview sizes.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>a list of Size object. This method will always return a list with at least one element. </para>
						/// </returns>
						/// <java-name>
						/// getSupportedPreviewSizes
						/// </java-name>
						[Dot42.DexImport("getSupportedPreviewSizes", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Landroid/hardware/Camera$Size;>;")]
						public virtual global::Java.Util.IList<global::Android.Hardware.Camera.Size> GetSupportedPreviewSizes() /* MethodBuilder.Create */ 
						{
								return default(global::Java.Util.IList<global::Android.Hardware.Camera.Size>);
						}

						/// <summary>
						/// <para>Gets the supported video frame sizes that can be used by MediaRecorder.</para><para>If the returned list is not null, the returned list will contain at least one Size and one of the sizes in the returned list must be passed to MediaRecorder.setVideoSize() for camcorder application if camera is used as the video source. In this case, the size of the preview can be different from the resolution of the recorded video during video recording.</para><para><para>getPreferredPreviewSizeForVideo() </para></para>        
						/// </summary>
						/// <returns>
						/// <para>a list of Size object if camera has separate preview and video output; otherwise, null is returned. </para>
						/// </returns>
						/// <java-name>
						/// getSupportedVideoSizes
						/// </java-name>
						[Dot42.DexImport("getSupportedVideoSizes", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Landroid/hardware/Camera$Size;>;")]
						public virtual global::Java.Util.IList<global::Android.Hardware.Camera.Size> GetSupportedVideoSizes() /* MethodBuilder.Create */ 
						{
								return default(global::Java.Util.IList<global::Android.Hardware.Camera.Size>);
						}

						/// <summary>
						/// <para>Returns the preferred or recommended preview size (width and height) in pixels for video recording. Camcorder applications should set the preview size to a value that is not larger than the preferred preview size. In other words, the product of the width and height of the preview size should not be larger than that of the preferred preview size. In addition, we recommend to choose a preview size that has the same aspect ratio as the resolution of video to be recorded.</para><para><para>getSupportedVideoSizes() </para></para>        
						/// </summary>
						/// <returns>
						/// <para>the preferred preview size (width and height) in pixels for video recording if getSupportedVideoSizes() does not return null; otherwise, null is returned. </para>
						/// </returns>
						/// <java-name>
						/// getPreferredPreviewSizeForVideo
						/// </java-name>
						[Dot42.DexImport("getPreferredPreviewSizeForVideo", "()Landroid/hardware/Camera$Size;", AccessFlags = 1)]
						public virtual global::Android.Hardware.Camera.Size GetPreferredPreviewSizeForVideo() /* MethodBuilder.Create */ 
						{
								return default(global::Android.Hardware.Camera.Size);
						}

						/// <summary>
						/// <para>Sets the dimensions for EXIF thumbnail in Jpeg picture. If applications set both width and height to 0, EXIF will not contain thumbnail.</para><para>Applications need to consider the display orientation. See setPreviewSize(int,int) for reference.</para><para><para>setPreviewSize(int,int) </para></para>        
						/// </summary>
						/// <java-name>
						/// setJpegThumbnailSize
						/// </java-name>
						[Dot42.DexImport("setJpegThumbnailSize", "(II)V", AccessFlags = 1)]
						public virtual void SetJpegThumbnailSize(int width, int height) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						/// <para>Returns the dimensions for EXIF thumbnail in Jpeg picture.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>a Size object with the height and width setting for the EXIF thumbnails </para>
						/// </returns>
						/// <java-name>
						/// getJpegThumbnailSize
						/// </java-name>
						[Dot42.DexImport("getJpegThumbnailSize", "()Landroid/hardware/Camera$Size;", AccessFlags = 1)]
						public virtual global::Android.Hardware.Camera.Size GetJpegThumbnailSize() /* MethodBuilder.Create */ 
						{
								return default(global::Android.Hardware.Camera.Size);
						}

						/// <summary>
						/// <para>Gets the supported jpeg thumbnail sizes.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>a list of Size object. This method will always return a list with at least two elements. Size 0,0 (no thumbnail) is always supported. </para>
						/// </returns>
						/// <java-name>
						/// getSupportedJpegThumbnailSizes
						/// </java-name>
						[Dot42.DexImport("getSupportedJpegThumbnailSizes", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Landroid/hardware/Camera$Size;>;")]
						public virtual global::Java.Util.IList<global::Android.Hardware.Camera.Size> GetSupportedJpegThumbnailSizes() /* MethodBuilder.Create */ 
						{
								return default(global::Java.Util.IList<global::Android.Hardware.Camera.Size>);
						}

						/// <summary>
						/// <para>Sets the quality of the EXIF thumbnail in Jpeg picture.</para><para></para>        
						/// </summary>
						/// <java-name>
						/// setJpegThumbnailQuality
						/// </java-name>
						[Dot42.DexImport("setJpegThumbnailQuality", "(I)V", AccessFlags = 1)]
						public virtual void SetJpegThumbnailQuality(int quality) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						/// <para>Returns the quality setting for the EXIF thumbnail in Jpeg picture.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>the JPEG quality setting of the EXIF thumbnail. </para>
						/// </returns>
						/// <java-name>
						/// getJpegThumbnailQuality
						/// </java-name>
						[Dot42.DexImport("getJpegThumbnailQuality", "()I", AccessFlags = 1)]
						public virtual int GetJpegThumbnailQuality() /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <summary>
						/// <para>Sets Jpeg quality of captured picture.</para><para></para>        
						/// </summary>
						/// <java-name>
						/// setJpegQuality
						/// </java-name>
						[Dot42.DexImport("setJpegQuality", "(I)V", AccessFlags = 1)]
						public virtual void SetJpegQuality(int quality) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						/// <para>Returns the quality setting for the JPEG picture.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>the JPEG picture quality setting. </para>
						/// </returns>
						/// <java-name>
						/// getJpegQuality
						/// </java-name>
						[Dot42.DexImport("getJpegQuality", "()I", AccessFlags = 1)]
						public virtual int GetJpegQuality() /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <summary>
						/// <para>Sets the rate at which preview frames are received. This is the target frame rate. The actual frame rate depends on the driver.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>replaced by setPreviewFpsRange(int,int) </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// setPreviewFrameRate
						/// </java-name>
						[Dot42.DexImport("setPreviewFrameRate", "(I)V", AccessFlags = 1)]
						public virtual void SetPreviewFrameRate(int fps) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						/// <para>Returns the setting for the rate at which preview frames are received. This is the target frame rate. The actual frame rate depends on the driver.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>replaced by getPreviewFpsRange(int[]) </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <returns>
						/// <para>the frame rate setting (frames per second) </para>
						/// </returns>
						/// <java-name>
						/// getPreviewFrameRate
						/// </java-name>
						[Dot42.DexImport("getPreviewFrameRate", "()I", AccessFlags = 1)]
						public virtual int GetPreviewFrameRate() /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <summary>
						/// <para>Gets the supported preview frame rates.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>replaced by getSupportedPreviewFpsRange() </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <returns>
						/// <para>a list of supported preview frame rates. null if preview frame rate setting is not supported. </para>
						/// </returns>
						/// <java-name>
						/// getSupportedPreviewFrameRates
						/// </java-name>
						[Dot42.DexImport("getSupportedPreviewFrameRates", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Ljava/lang/Integer;>;")]
						public virtual global::Java.Util.IList<int?> GetSupportedPreviewFrameRates() /* MethodBuilder.Create */ 
						{
								return default(global::Java.Util.IList<int?>);
						}

						/// <summary>
						/// <para>Sets the minimum and maximum preview fps. This controls the rate of preview frames received in PreviewCallback. The minimum and maximum preview fps must be one of the elements from getSupportedPreviewFpsRange.</para><para><para>setPreviewCallbackWithBuffer(Camera.PreviewCallback) </para><simplesectsep></simplesectsep><para>getSupportedPreviewFpsRange() </para></para>        
						/// </summary>
						/// <java-name>
						/// setPreviewFpsRange
						/// </java-name>
						[Dot42.DexImport("setPreviewFpsRange", "(II)V", AccessFlags = 1)]
						public virtual void SetPreviewFpsRange(int min, int max) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						/// <para>Returns the current minimum and maximum preview fps. The values are one of the elements returned by getSupportedPreviewFpsRange.</para><para><para>PREVIEW_FPS_MIN_INDEX </para><simplesectsep></simplesectsep><para>PREVIEW_FPS_MAX_INDEX </para><simplesectsep></simplesectsep><para>getSupportedPreviewFpsRange() </para></para>        
						/// </summary>
						/// <returns>
						/// <para>range the minimum and maximum preview fps (scaled by 1000). </para>
						/// </returns>
						/// <java-name>
						/// getPreviewFpsRange
						/// </java-name>
						[Dot42.DexImport("getPreviewFpsRange", "([I)V", AccessFlags = 1)]
						public virtual void GetPreviewFpsRange(int[] range) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						/// <para>Gets the supported preview fps (frame-per-second) ranges. Each range contains a minimum fps and maximum fps. If minimum fps equals to maximum fps, the camera outputs frames in fixed frame rate. If not, the camera outputs frames in auto frame rate. The actual frame rate fluctuates between the minimum and the maximum. The values are multiplied by 1000 and represented in integers. For example, if frame rate is 26.623 frames per second, the value is 26623.</para><para><para>PREVIEW_FPS_MIN_INDEX </para><simplesectsep></simplesectsep><para>PREVIEW_FPS_MAX_INDEX </para></para>        
						/// </summary>
						/// <returns>
						/// <para>a list of supported preview fps ranges. This method returns a list with at least one element. Every element is an int array of two values - minimum fps and maximum fps. The list is sorted from small to large (first by maximum fps and then minimum fps). </para>
						/// </returns>
						/// <java-name>
						/// getSupportedPreviewFpsRange
						/// </java-name>
						[Dot42.DexImport("getSupportedPreviewFpsRange", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<[I>;")]
						public virtual global::Java.Util.IList<int[]> GetSupportedPreviewFpsRange() /* MethodBuilder.Create */ 
						{
								return default(global::Java.Util.IList<int[]>);
						}

						/// <summary>
						/// <para>Sets the image format for preview pictures. </para><para>If this is never called, the default format will be android.graphics.ImageFormat#NV21, which uses the NV21 encoding format.</para><para>Use Parameters#getSupportedPreviewFormats to get a list of the available preview formats.</para><para>It is strongly recommended that either android.graphics.ImageFormat#NV21 or android.graphics.ImageFormat#YV12 is used, since they are supported by all camera devices.</para><para>For YV12, the image buffer that is received is not necessarily tightly packed, as there may be padding at the end of each row of pixel data, as described in android.graphics.ImageFormat#YV12. For camera callback data, it can be assumed that the stride of the Y and UV data is the smallest possible that meets the alignment requirements. That is, if the preview size is <b>width x height</b>, then the following equations describe the buffer index for the beginning of row <b>y</b> for the Y plane and row <b>c</b> for the U and V planes:</para><para><c>           &lt;pre&gt;           yStride   = (int) ceil(width / 16.0) * 16;           uvStride  = (int) ceil( (yStride / 2) / 16.0) * 16;           ySize     = yStride * height;           uvSize    = uvStride * height / 2;           yRowIndex = yStride * y;           uRowIndex = ySize + uvSize + uvStride * c;           vRowIndex = ySize + uvStride * c;           size      = ySize + uvSize * 2;&lt;/pre&gt;</c></para><para><para>android.graphics.ImageFormat </para><simplesectsep></simplesectsep><para>android.hardware.Camera.Parameters::getSupportedPreviewFormats </para></para>        
						/// </summary>
						/// <java-name>
						/// setPreviewFormat
						/// </java-name>
						[Dot42.DexImport("setPreviewFormat", "(I)V", AccessFlags = 1)]
						public virtual void SetPreviewFormat(int pixel_format) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						/// <para>Returns the image format for preview frames got from PreviewCallback.</para><para><para>android.graphics.ImageFormat </para><simplesectsep></simplesectsep><para>setPreviewFormat </para></para>        
						/// </summary>
						/// <returns>
						/// <para>the preview format. </para>
						/// </returns>
						/// <java-name>
						/// getPreviewFormat
						/// </java-name>
						[Dot42.DexImport("getPreviewFormat", "()I", AccessFlags = 1)]
						public virtual int GetPreviewFormat() /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <summary>
						/// <para>Gets the supported preview formats. android.graphics.ImageFormat#NV21 is always supported. android.graphics.ImageFormat#YV12 is always supported since API level 12.</para><para><para>android.graphics.ImageFormat </para><simplesectsep></simplesectsep><para>setPreviewFormat </para></para>        
						/// </summary>
						/// <returns>
						/// <para>a list of supported preview formats. This method will always return a list with at least one element. </para>
						/// </returns>
						/// <java-name>
						/// getSupportedPreviewFormats
						/// </java-name>
						[Dot42.DexImport("getSupportedPreviewFormats", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Ljava/lang/Integer;>;")]
						public virtual global::Java.Util.IList<int?> GetSupportedPreviewFormats() /* MethodBuilder.Create */ 
						{
								return default(global::Java.Util.IList<int?>);
						}

						/// <summary>
						/// <para>Sets the dimensions for pictures.</para><para>Applications need to consider the display orientation. See setPreviewSize(int,int) for reference.</para><para><para>setPreviewSize(int,int) </para></para>        
						/// </summary>
						/// <java-name>
						/// setPictureSize
						/// </java-name>
						[Dot42.DexImport("setPictureSize", "(II)V", AccessFlags = 1)]
						public virtual void SetPictureSize(int width, int height) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						/// <para>Returns the dimension setting for pictures.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>a Size object with the height and width setting for pictures </para>
						/// </returns>
						/// <java-name>
						/// getPictureSize
						/// </java-name>
						[Dot42.DexImport("getPictureSize", "()Landroid/hardware/Camera$Size;", AccessFlags = 1)]
						public virtual global::Android.Hardware.Camera.Size GetPictureSize() /* MethodBuilder.Create */ 
						{
								return default(global::Android.Hardware.Camera.Size);
						}

						/// <summary>
						/// <para>Gets the supported picture sizes.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>a list of supported picture sizes. This method will always return a list with at least one element. </para>
						/// </returns>
						/// <java-name>
						/// getSupportedPictureSizes
						/// </java-name>
						[Dot42.DexImport("getSupportedPictureSizes", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Landroid/hardware/Camera$Size;>;")]
						public virtual global::Java.Util.IList<global::Android.Hardware.Camera.Size> GetSupportedPictureSizes() /* MethodBuilder.Create */ 
						{
								return default(global::Java.Util.IList<global::Android.Hardware.Camera.Size>);
						}

						/// <summary>
						/// <para>Sets the image format for pictures.</para><para><para>android.graphics.ImageFormat </para></para>        
						/// </summary>
						/// <java-name>
						/// setPictureFormat
						/// </java-name>
						[Dot42.DexImport("setPictureFormat", "(I)V", AccessFlags = 1)]
						public virtual void SetPictureFormat(int pixel_format) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						/// <para>Returns the image format for pictures.</para><para><para>android.graphics.ImageFormat </para></para>        
						/// </summary>
						/// <returns>
						/// <para>the picture format </para>
						/// </returns>
						/// <java-name>
						/// getPictureFormat
						/// </java-name>
						[Dot42.DexImport("getPictureFormat", "()I", AccessFlags = 1)]
						public virtual int GetPictureFormat() /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <summary>
						/// <para>Gets the supported picture formats.</para><para><para>android.graphics.ImageFormat </para></para>        
						/// </summary>
						/// <returns>
						/// <para>supported picture formats. This method will always return a list with at least one element. </para>
						/// </returns>
						/// <java-name>
						/// getSupportedPictureFormats
						/// </java-name>
						[Dot42.DexImport("getSupportedPictureFormats", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Ljava/lang/Integer;>;")]
						public virtual global::Java.Util.IList<int?> GetSupportedPictureFormats() /* MethodBuilder.Create */ 
						{
								return default(global::Java.Util.IList<int?>);
						}

						/// <summary>
						/// <para>Sets the clockwise rotation angle in degrees relative to the orientation of the camera. This affects the pictures returned from JPEG PictureCallback. The camera driver may set orientation in the EXIF header without rotating the picture. Or the driver may rotate the picture and the EXIF thumbnail. If the Jpeg picture is rotated, the orientation in the EXIF header will be missing or 1 (row #0 is top and column #0 is left side).</para><para>If applications want to rotate the picture to match the orientation of what users see, apps should use android.view.OrientationEventListener and CameraInfo. The value from OrientationEventListener is relative to the natural orientation of the device. CameraInfo.orientation is the angle between camera orientation and natural device orientation. The sum of the two is the rotation angle for back-facing camera. The difference of the two is the rotation angle for front-facing camera. Note that the JPEG pictures of front-facing cameras are not mirrored as in preview display.</para><para>For example, suppose the natural orientation of the device is portrait. The device is rotated 270 degrees clockwise, so the device orientation is 270. Suppose a back-facing camera sensor is mounted in landscape and the top side of the camera sensor is aligned with the right edge of the display in natural orientation. So the camera orientation is 90. The rotation should be set to 0 (270 + 90).</para><para>The reference code is as follows.</para><para><pre>
						///            public void onOrientationChanged(int orientation) {
						///                if (orientation == ORIENTATION_UNKNOWN) return;
						///                android.hardware.Camera.CameraInfo info =
						///                       new android.hardware.Camera.CameraInfo();
						///                android.hardware.Camera.getCameraInfo(cameraId, info);
						///                orientation = (orientation + 45) / 90 * 90;
						///                int rotation = 0;
						///                if (info.facing == CameraInfo.CAMERA_FACING_FRONT) {
						///                    rotation = (info.orientation - orientation + 360) % 360;
						///                } else {  // back-facing camera
						///                    rotation = (info.orientation + orientation) % 360;
						///                }
						///                mParameters.setRotation(rotation);
						///            }
						///            </pre></para><para><para>android.view.OrientationEventListener </para><simplesectsep></simplesectsep><para>getCameraInfo(int, CameraInfo) </para></para>        
						/// </summary>
						/// <java-name>
						/// setRotation
						/// </java-name>
						[Dot42.DexImport("setRotation", "(I)V", AccessFlags = 1)]
						public virtual void SetRotation(int rotation) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						/// <para>Sets GPS latitude coordinate. This will be stored in JPEG EXIF header.</para><para></para>        
						/// </summary>
						/// <java-name>
						/// setGpsLatitude
						/// </java-name>
						[Dot42.DexImport("setGpsLatitude", "(D)V", AccessFlags = 1)]
						public virtual void SetGpsLatitude(double latitude) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						/// <para>Sets GPS longitude coordinate. This will be stored in JPEG EXIF header.</para><para></para>        
						/// </summary>
						/// <java-name>
						/// setGpsLongitude
						/// </java-name>
						[Dot42.DexImport("setGpsLongitude", "(D)V", AccessFlags = 1)]
						public virtual void SetGpsLongitude(double longitude) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						/// <para>Sets GPS altitude. This will be stored in JPEG EXIF header.</para><para></para>        
						/// </summary>
						/// <java-name>
						/// setGpsAltitude
						/// </java-name>
						[Dot42.DexImport("setGpsAltitude", "(D)V", AccessFlags = 1)]
						public virtual void SetGpsAltitude(double altitude) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						/// <para>Sets GPS timestamp. This will be stored in JPEG EXIF header.</para><para></para>        
						/// </summary>
						/// <java-name>
						/// setGpsTimestamp
						/// </java-name>
						[Dot42.DexImport("setGpsTimestamp", "(J)V", AccessFlags = 1)]
						public virtual void SetGpsTimestamp(long timestamp) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						/// <para>Sets GPS processing method. It will store up to 32 characters in JPEG EXIF header.</para><para></para>        
						/// </summary>
						/// <java-name>
						/// setGpsProcessingMethod
						/// </java-name>
						[Dot42.DexImport("setGpsProcessingMethod", "(Ljava/lang/String;)V", AccessFlags = 1)]
						public virtual void SetGpsProcessingMethod(string processing_method) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						/// <para>Removes GPS latitude, longitude, altitude, and timestamp from the parameters. </para>        
						/// </summary>
						/// <java-name>
						/// removeGpsData
						/// </java-name>
						[Dot42.DexImport("removeGpsData", "()V", AccessFlags = 1)]
						public virtual void RemoveGpsData() /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						/// <para>Gets the current white balance setting.</para><para><para>#WHITE_BALANCE_AUTO </para><simplesectsep></simplesectsep><para>#WHITE_BALANCE_INCANDESCENT </para><simplesectsep></simplesectsep><para>#WHITE_BALANCE_FLUORESCENT </para><simplesectsep></simplesectsep><para>#WHITE_BALANCE_WARM_FLUORESCENT </para><simplesectsep></simplesectsep><para>#WHITE_BALANCE_DAYLIGHT </para><simplesectsep></simplesectsep><para>#WHITE_BALANCE_CLOUDY_DAYLIGHT </para><simplesectsep></simplesectsep><para>#WHITE_BALANCE_TWILIGHT </para><simplesectsep></simplesectsep><para>#WHITE_BALANCE_SHADE </para></para>        
						/// </summary>
						/// <returns>
						/// <para>current white balance. null if white balance setting is not supported. </para>
						/// </returns>
						/// <java-name>
						/// getWhiteBalance
						/// </java-name>
						[Dot42.DexImport("getWhiteBalance", "()Ljava/lang/String;", AccessFlags = 1)]
						public virtual string GetWhiteBalance() /* MethodBuilder.Create */ 
						{
								return default(string);
						}

						/// <summary>
						/// <para>Sets the white balance. Changing the setting will release the auto-white balance lock. It is recommended not to change white balance and AWB lock at the same time.</para><para><para>getWhiteBalance() </para><simplesectsep></simplesectsep><para>setAutoWhiteBalanceLock(boolean) </para></para>        
						/// </summary>
						/// <java-name>
						/// setWhiteBalance
						/// </java-name>
						[Dot42.DexImport("setWhiteBalance", "(Ljava/lang/String;)V", AccessFlags = 1)]
						public virtual void SetWhiteBalance(string value) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						/// <para>Gets the supported white balance.</para><para><para>getWhiteBalance() </para></para>        
						/// </summary>
						/// <returns>
						/// <para>a list of supported white balance. null if white balance setting is not supported. </para>
						/// </returns>
						/// <java-name>
						/// getSupportedWhiteBalance
						/// </java-name>
						[Dot42.DexImport("getSupportedWhiteBalance", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Ljava/lang/String;>;")]
						public virtual global::Java.Util.IList<string> GetSupportedWhiteBalance() /* MethodBuilder.Create */ 
						{
								return default(global::Java.Util.IList<string>);
						}

						/// <summary>
						/// <para>Gets the current color effect setting.</para><para><para>#EFFECT_NONE </para><simplesectsep></simplesectsep><para>#EFFECT_MONO </para><simplesectsep></simplesectsep><para>#EFFECT_NEGATIVE </para><simplesectsep></simplesectsep><para>#EFFECT_SOLARIZE </para><simplesectsep></simplesectsep><para>#EFFECT_SEPIA </para><simplesectsep></simplesectsep><para>#EFFECT_POSTERIZE </para><simplesectsep></simplesectsep><para>#EFFECT_WHITEBOARD </para><simplesectsep></simplesectsep><para>#EFFECT_BLACKBOARD </para><simplesectsep></simplesectsep><para>#EFFECT_AQUA </para></para>        
						/// </summary>
						/// <returns>
						/// <para>current color effect. null if color effect setting is not supported. </para>
						/// </returns>
						/// <java-name>
						/// getColorEffect
						/// </java-name>
						[Dot42.DexImport("getColorEffect", "()Ljava/lang/String;", AccessFlags = 1)]
						public virtual string GetColorEffect() /* MethodBuilder.Create */ 
						{
								return default(string);
						}

						/// <summary>
						/// <para>Sets the current color effect setting.</para><para><para>getColorEffect() </para></para>        
						/// </summary>
						/// <java-name>
						/// setColorEffect
						/// </java-name>
						[Dot42.DexImport("setColorEffect", "(Ljava/lang/String;)V", AccessFlags = 1)]
						public virtual void SetColorEffect(string value) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						/// <para>Gets the supported color effects.</para><para><para>getColorEffect() </para></para>        
						/// </summary>
						/// <returns>
						/// <para>a list of supported color effects. null if color effect setting is not supported. </para>
						/// </returns>
						/// <java-name>
						/// getSupportedColorEffects
						/// </java-name>
						[Dot42.DexImport("getSupportedColorEffects", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Ljava/lang/String;>;")]
						public virtual global::Java.Util.IList<string> GetSupportedColorEffects() /* MethodBuilder.Create */ 
						{
								return default(global::Java.Util.IList<string>);
						}

						/// <summary>
						/// <para>Gets the current antibanding setting.</para><para><para>#ANTIBANDING_AUTO </para><simplesectsep></simplesectsep><para>#ANTIBANDING_50HZ </para><simplesectsep></simplesectsep><para>#ANTIBANDING_60HZ </para><simplesectsep></simplesectsep><para>#ANTIBANDING_OFF </para></para>        
						/// </summary>
						/// <returns>
						/// <para>current antibanding. null if antibanding setting is not supported. </para>
						/// </returns>
						/// <java-name>
						/// getAntibanding
						/// </java-name>
						[Dot42.DexImport("getAntibanding", "()Ljava/lang/String;", AccessFlags = 1)]
						public virtual string GetAntibanding() /* MethodBuilder.Create */ 
						{
								return default(string);
						}

						/// <summary>
						/// <para>Sets the antibanding.</para><para><para>getAntibanding() </para></para>        
						/// </summary>
						/// <java-name>
						/// setAntibanding
						/// </java-name>
						[Dot42.DexImport("setAntibanding", "(Ljava/lang/String;)V", AccessFlags = 1)]
						public virtual void SetAntibanding(string antibanding) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						/// <para>Gets the supported antibanding values.</para><para><para>getAntibanding() </para></para>        
						/// </summary>
						/// <returns>
						/// <para>a list of supported antibanding values. null if antibanding setting is not supported. </para>
						/// </returns>
						/// <java-name>
						/// getSupportedAntibanding
						/// </java-name>
						[Dot42.DexImport("getSupportedAntibanding", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Ljava/lang/String;>;")]
						public virtual global::Java.Util.IList<string> GetSupportedAntibanding() /* MethodBuilder.Create */ 
						{
								return default(global::Java.Util.IList<string>);
						}

						/// <summary>
						/// <para>Gets the current scene mode setting.</para><para><para>SCENE_MODE_AUTO </para><simplesectsep></simplesectsep><para>SCENE_MODE_ACTION </para><simplesectsep></simplesectsep><para>SCENE_MODE_PORTRAIT </para><simplesectsep></simplesectsep><para>SCENE_MODE_LANDSCAPE </para><simplesectsep></simplesectsep><para>SCENE_MODE_NIGHT </para><simplesectsep></simplesectsep><para>SCENE_MODE_NIGHT_PORTRAIT </para><simplesectsep></simplesectsep><para>SCENE_MODE_THEATRE </para><simplesectsep></simplesectsep><para>SCENE_MODE_BEACH </para><simplesectsep></simplesectsep><para>SCENE_MODE_SNOW </para><simplesectsep></simplesectsep><para>SCENE_MODE_SUNSET </para><simplesectsep></simplesectsep><para>SCENE_MODE_STEADYPHOTO </para><simplesectsep></simplesectsep><para>SCENE_MODE_FIREWORKS </para><simplesectsep></simplesectsep><para>SCENE_MODE_SPORTS </para><simplesectsep></simplesectsep><para>SCENE_MODE_PARTY </para><simplesectsep></simplesectsep><para>SCENE_MODE_CANDLELIGHT </para><simplesectsep></simplesectsep><para>SCENE_MODE_BARCODE </para></para>        
						/// </summary>
						/// <returns>
						/// <para>one of SCENE_MODE_XXX string constant. null if scene mode setting is not supported. </para>
						/// </returns>
						/// <java-name>
						/// getSceneMode
						/// </java-name>
						[Dot42.DexImport("getSceneMode", "()Ljava/lang/String;", AccessFlags = 1)]
						public virtual string GetSceneMode() /* MethodBuilder.Create */ 
						{
								return default(string);
						}

						/// <summary>
						/// <para>Sets the scene mode. Changing scene mode may override other parameters (such as flash mode, focus mode, white balance). For example, suppose originally flash mode is on and supported flash modes are on/off. In night scene mode, both flash mode and supported flash mode may be changed to off. After setting scene mode, applications should call getParameters to know if some parameters are changed.</para><para><para>getSceneMode() </para></para>        
						/// </summary>
						/// <java-name>
						/// setSceneMode
						/// </java-name>
						[Dot42.DexImport("setSceneMode", "(Ljava/lang/String;)V", AccessFlags = 1)]
						public virtual void SetSceneMode(string value) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						/// <para>Gets the supported scene modes.</para><para><para>getSceneMode() </para></para>        
						/// </summary>
						/// <returns>
						/// <para>a list of supported scene modes. null if scene mode setting is not supported. </para>
						/// </returns>
						/// <java-name>
						/// getSupportedSceneModes
						/// </java-name>
						[Dot42.DexImport("getSupportedSceneModes", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Ljava/lang/String;>;")]
						public virtual global::Java.Util.IList<string> GetSupportedSceneModes() /* MethodBuilder.Create */ 
						{
								return default(global::Java.Util.IList<string>);
						}

						/// <summary>
						/// <para>Gets the current flash mode setting.</para><para><para>FLASH_MODE_OFF </para><simplesectsep></simplesectsep><para>FLASH_MODE_AUTO </para><simplesectsep></simplesectsep><para>FLASH_MODE_ON </para><simplesectsep></simplesectsep><para>FLASH_MODE_RED_EYE </para><simplesectsep></simplesectsep><para>FLASH_MODE_TORCH </para></para>        
						/// </summary>
						/// <returns>
						/// <para>current flash mode. null if flash mode setting is not supported. </para>
						/// </returns>
						/// <java-name>
						/// getFlashMode
						/// </java-name>
						[Dot42.DexImport("getFlashMode", "()Ljava/lang/String;", AccessFlags = 1)]
						public virtual string GetFlashMode() /* MethodBuilder.Create */ 
						{
								return default(string);
						}

						/// <summary>
						/// <para>Sets the flash mode.</para><para><para>getFlashMode() </para></para>        
						/// </summary>
						/// <java-name>
						/// setFlashMode
						/// </java-name>
						[Dot42.DexImport("setFlashMode", "(Ljava/lang/String;)V", AccessFlags = 1)]
						public virtual void SetFlashMode(string value) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						/// <para>Gets the supported flash modes.</para><para><para>getFlashMode() </para></para>        
						/// </summary>
						/// <returns>
						/// <para>a list of supported flash modes. null if flash mode setting is not supported. </para>
						/// </returns>
						/// <java-name>
						/// getSupportedFlashModes
						/// </java-name>
						[Dot42.DexImport("getSupportedFlashModes", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Ljava/lang/String;>;")]
						public virtual global::Java.Util.IList<string> GetSupportedFlashModes() /* MethodBuilder.Create */ 
						{
								return default(global::Java.Util.IList<string>);
						}

						/// <summary>
						/// <para>Gets the current focus mode setting.</para><para><para>FOCUS_MODE_AUTO </para><simplesectsep></simplesectsep><para>FOCUS_MODE_INFINITY </para><simplesectsep></simplesectsep><para>FOCUS_MODE_MACRO </para><simplesectsep></simplesectsep><para>FOCUS_MODE_FIXED </para><simplesectsep></simplesectsep><para>FOCUS_MODE_EDOF </para><simplesectsep></simplesectsep><para>FOCUS_MODE_CONTINUOUS_VIDEO </para></para>        
						/// </summary>
						/// <returns>
						/// <para>current focus mode. This method will always return a non-null value. Applications should call autoFocus(AutoFocusCallback) to start the focus if focus mode is FOCUS_MODE_AUTO or FOCUS_MODE_MACRO. </para>
						/// </returns>
						/// <java-name>
						/// getFocusMode
						/// </java-name>
						[Dot42.DexImport("getFocusMode", "()Ljava/lang/String;", AccessFlags = 1)]
						public virtual string GetFocusMode() /* MethodBuilder.Create */ 
						{
								return default(string);
						}

						/// <summary>
						/// <para>Sets the focus mode.</para><para><para>getFocusMode() </para></para>        
						/// </summary>
						/// <java-name>
						/// setFocusMode
						/// </java-name>
						[Dot42.DexImport("setFocusMode", "(Ljava/lang/String;)V", AccessFlags = 1)]
						public virtual void SetFocusMode(string value) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						/// <para>Gets the supported focus modes.</para><para><para>getFocusMode() </para></para>        
						/// </summary>
						/// <returns>
						/// <para>a list of supported focus modes. This method will always return a list with at least one element. </para>
						/// </returns>
						/// <java-name>
						/// getSupportedFocusModes
						/// </java-name>
						[Dot42.DexImport("getSupportedFocusModes", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Ljava/lang/String;>;")]
						public virtual global::Java.Util.IList<string> GetSupportedFocusModes() /* MethodBuilder.Create */ 
						{
								return default(global::Java.Util.IList<string>);
						}

						/// <summary>
						/// <para>Gets the focal length (in millimeter) of the camera.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>the focal length. This method will always return a valid value. </para>
						/// </returns>
						/// <java-name>
						/// getFocalLength
						/// </java-name>
						[Dot42.DexImport("getFocalLength", "()F", AccessFlags = 1)]
						public virtual float GetFocalLength() /* MethodBuilder.Create */ 
						{
								return default(float);
						}

						/// <summary>
						/// <para>Gets the horizontal angle of view in degrees.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>horizontal angle of view. This method will always return a valid value. </para>
						/// </returns>
						/// <java-name>
						/// getHorizontalViewAngle
						/// </java-name>
						[Dot42.DexImport("getHorizontalViewAngle", "()F", AccessFlags = 1)]
						public virtual float GetHorizontalViewAngle() /* MethodBuilder.Create */ 
						{
								return default(float);
						}

						/// <summary>
						/// <para>Gets the vertical angle of view in degrees.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>vertical angle of view. This method will always return a valid value. </para>
						/// </returns>
						/// <java-name>
						/// getVerticalViewAngle
						/// </java-name>
						[Dot42.DexImport("getVerticalViewAngle", "()F", AccessFlags = 1)]
						public virtual float GetVerticalViewAngle() /* MethodBuilder.Create */ 
						{
								return default(float);
						}

						/// <summary>
						/// <para>Gets the current exposure compensation index.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>current exposure compensation index. The range is getMinExposureCompensation to getMaxExposureCompensation. 0 means exposure is not adjusted. </para>
						/// </returns>
						/// <java-name>
						/// getExposureCompensation
						/// </java-name>
						[Dot42.DexImport("getExposureCompensation", "()I", AccessFlags = 1)]
						public virtual int GetExposureCompensation() /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <summary>
						/// <para>Sets the exposure compensation index.</para><para></para>        
						/// </summary>
						/// <java-name>
						/// setExposureCompensation
						/// </java-name>
						[Dot42.DexImport("setExposureCompensation", "(I)V", AccessFlags = 1)]
						public virtual void SetExposureCompensation(int value) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						/// <para>Gets the maximum exposure compensation index.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>maximum exposure compensation index (&gt;=0). If both this method and getMinExposureCompensation return 0, exposure compensation is not supported. </para>
						/// </returns>
						/// <java-name>
						/// getMaxExposureCompensation
						/// </java-name>
						[Dot42.DexImport("getMaxExposureCompensation", "()I", AccessFlags = 1)]
						public virtual int GetMaxExposureCompensation() /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <summary>
						/// <para>Gets the minimum exposure compensation index.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>minimum exposure compensation index (&lt;=0). If both this method and getMaxExposureCompensation return 0, exposure compensation is not supported. </para>
						/// </returns>
						/// <java-name>
						/// getMinExposureCompensation
						/// </java-name>
						[Dot42.DexImport("getMinExposureCompensation", "()I", AccessFlags = 1)]
						public virtual int GetMinExposureCompensation() /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <summary>
						/// <para>Gets the exposure compensation step.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>exposure compensation step. Applications can get EV by multiplying the exposure compensation index and step. Ex: if exposure compensation index is -6 and step is 0.333333333, EV is -2. </para>
						/// </returns>
						/// <java-name>
						/// getExposureCompensationStep
						/// </java-name>
						[Dot42.DexImport("getExposureCompensationStep", "()F", AccessFlags = 1)]
						public virtual float GetExposureCompensationStep() /* MethodBuilder.Create */ 
						{
								return default(float);
						}

						/// <summary>
						/// <para>Sets the auto-exposure lock state. Applications should check isAutoExposureLockSupported before using this method.</para><para>If set to true, the camera auto-exposure routine will immediately pause until the lock is set to false. Exposure compensation settings changes will still take effect while auto-exposure is locked.</para><para>If auto-exposure is already locked, setting this to true again has no effect (the driver will not recalculate exposure values).</para><para>Stopping preview with stopPreview(), or triggering still image capture with Camera.PictureCallback, Camera.PictureCallback), will not change the lock.</para><para>Exposure compensation, auto-exposure lock, and auto-white balance lock can be used to capture an exposure-bracketed burst of images, for example.</para><para>Auto-exposure state, including the lock state, will not be maintained after camera release() is called. Locking auto-exposure after open() but before the first call to startPreview() will not allow the auto-exposure routine to run at all, and may result in severely over- or under-exposed images.</para><para><para>getAutoExposureLock() </para></para>        
						/// </summary>
						/// <java-name>
						/// setAutoExposureLock
						/// </java-name>
						[Dot42.DexImport("setAutoExposureLock", "(Z)V", AccessFlags = 1)]
						public virtual void SetAutoExposureLock(bool toggle) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						/// <para>Gets the state of the auto-exposure lock. Applications should check isAutoExposureLockSupported before using this method. See setAutoExposureLock for details about the lock.</para><para><para>setAutoExposureLock(boolean) </para></para>        
						/// </summary>
						/// <returns>
						/// <para>State of the auto-exposure lock. Returns true if auto-exposure is currently locked, and false otherwise.</para>
						/// </returns>
						/// <java-name>
						/// getAutoExposureLock
						/// </java-name>
						[Dot42.DexImport("getAutoExposureLock", "()Z", AccessFlags = 1)]
						public virtual bool GetAutoExposureLock() /* MethodBuilder.Create */ 
						{
								return default(bool);
						}

						/// <summary>
						/// <para>Returns true if auto-exposure locking is supported. Applications should call this before trying to lock auto-exposure. See setAutoExposureLock for details about the lock.</para><para><para>setAutoExposureLock(boolean) </para></para>        
						/// </summary>
						/// <returns>
						/// <para>true if auto-exposure lock is supported. </para>
						/// </returns>
						/// <java-name>
						/// isAutoExposureLockSupported
						/// </java-name>
						[Dot42.DexImport("isAutoExposureLockSupported", "()Z", AccessFlags = 1)]
						public virtual bool IsAutoExposureLockSupported() /* MethodBuilder.Create */ 
						{
								return default(bool);
						}

						/// <summary>
						/// <para>Sets the auto-white balance lock state. Applications should check isAutoWhiteBalanceLockSupported before using this method.</para><para>If set to true, the camera auto-white balance routine will immediately pause until the lock is set to false.</para><para>If auto-white balance is already locked, setting this to true again has no effect (the driver will not recalculate white balance values).</para><para>Stopping preview with stopPreview(), or triggering still image capture with Camera.PictureCallback, Camera.PictureCallback), will not change the the lock.</para><para>Changing the white balance mode with setWhiteBalance will release the auto-white balance lock if it is set.</para><para>Exposure compensation, AE lock, and AWB lock can be used to capture an exposure-bracketed burst of images, for example. Auto-white balance state, including the lock state, will not be maintained after camera release() is called. Locking auto-white balance after open() but before the first call to startPreview() will not allow the auto-white balance routine to run at all, and may result in severely incorrect color in captured images.</para><para><para>getAutoWhiteBalanceLock() </para><simplesectsep></simplesectsep><para>setWhiteBalance(String) </para></para>        
						/// </summary>
						/// <java-name>
						/// setAutoWhiteBalanceLock
						/// </java-name>
						[Dot42.DexImport("setAutoWhiteBalanceLock", "(Z)V", AccessFlags = 1)]
						public virtual void SetAutoWhiteBalanceLock(bool toggle) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						/// <para>Gets the state of the auto-white balance lock. Applications should check isAutoWhiteBalanceLockSupported before using this method. See setAutoWhiteBalanceLock for details about the lock.</para><para><para>setAutoWhiteBalanceLock(boolean) </para></para>        
						/// </summary>
						/// <returns>
						/// <para>State of the auto-white balance lock. Returns true if auto-white balance is currently locked, and false otherwise.</para>
						/// </returns>
						/// <java-name>
						/// getAutoWhiteBalanceLock
						/// </java-name>
						[Dot42.DexImport("getAutoWhiteBalanceLock", "()Z", AccessFlags = 1)]
						public virtual bool GetAutoWhiteBalanceLock() /* MethodBuilder.Create */ 
						{
								return default(bool);
						}

						/// <summary>
						/// <para>Returns true if auto-white balance locking is supported. Applications should call this before trying to lock auto-white balance. See setAutoWhiteBalanceLock for details about the lock.</para><para><para>setAutoWhiteBalanceLock(boolean) </para></para>        
						/// </summary>
						/// <returns>
						/// <para>true if auto-white balance lock is supported. </para>
						/// </returns>
						/// <java-name>
						/// isAutoWhiteBalanceLockSupported
						/// </java-name>
						[Dot42.DexImport("isAutoWhiteBalanceLockSupported", "()Z", AccessFlags = 1)]
						public virtual bool IsAutoWhiteBalanceLockSupported() /* MethodBuilder.Create */ 
						{
								return default(bool);
						}

						/// <summary>
						/// <para>Gets current zoom value. This also works when smooth zoom is in progress. Applications should check isZoomSupported before using this method.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>the current zoom value. The range is 0 to getMaxZoom. 0 means the camera is not zoomed. </para>
						/// </returns>
						/// <java-name>
						/// getZoom
						/// </java-name>
						[Dot42.DexImport("getZoom", "()I", AccessFlags = 1)]
						public virtual int GetZoom() /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <summary>
						/// <para>Sets current zoom value. If the camera is zoomed (value &gt; 0), the actual picture size may be smaller than picture size setting. Applications can check the actual picture size after picture is returned from PictureCallback. The preview size remains the same in zoom. Applications should check isZoomSupported before using this method.</para><para></para>        
						/// </summary>
						/// <java-name>
						/// setZoom
						/// </java-name>
						[Dot42.DexImport("setZoom", "(I)V", AccessFlags = 1)]
						public virtual void SetZoom(int value) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						/// <para>Returns true if zoom is supported. Applications should call this before using other zoom methods.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>true if zoom is supported. </para>
						/// </returns>
						/// <java-name>
						/// isZoomSupported
						/// </java-name>
						[Dot42.DexImport("isZoomSupported", "()Z", AccessFlags = 1)]
						public virtual bool IsZoomSupported() /* MethodBuilder.Create */ 
						{
								return default(bool);
						}

						/// <summary>
						/// <para>Gets the maximum zoom value allowed for snapshot. This is the maximum value that applications can set to setZoom(int). Applications should call isZoomSupported before using this method. This value may change in different preview size. Applications should call this again after setting preview size.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>the maximum zoom value supported by the camera. </para>
						/// </returns>
						/// <java-name>
						/// getMaxZoom
						/// </java-name>
						[Dot42.DexImport("getMaxZoom", "()I", AccessFlags = 1)]
						public virtual int GetMaxZoom() /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <summary>
						/// <para>Gets the zoom ratios of all zoom values. Applications should check isZoomSupported before using this method.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>the zoom ratios in 1/100 increments. Ex: a zoom of 3.2x is returned as 320. The number of elements is getMaxZoom + 1. The list is sorted from small to large. The first element is always 100. The last element is the zoom ratio of the maximum zoom value. </para>
						/// </returns>
						/// <java-name>
						/// getZoomRatios
						/// </java-name>
						[Dot42.DexImport("getZoomRatios", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Ljava/lang/Integer;>;")]
						public virtual global::Java.Util.IList<int?> GetZoomRatios() /* MethodBuilder.Create */ 
						{
								return default(global::Java.Util.IList<int?>);
						}

						/// <summary>
						/// <para>Returns true if smooth zoom is supported. Applications should call this before using other smooth zoom methods.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>true if smooth zoom is supported. </para>
						/// </returns>
						/// <java-name>
						/// isSmoothZoomSupported
						/// </java-name>
						[Dot42.DexImport("isSmoothZoomSupported", "()Z", AccessFlags = 1)]
						public virtual bool IsSmoothZoomSupported() /* MethodBuilder.Create */ 
						{
								return default(bool);
						}

						/// <summary>
						/// <para>Gets the distances from the camera to where an object appears to be in focus. The object is sharpest at the optimal focus distance. The depth of field is the far focus distance minus near focus distance.</para><para>Focus distances may change after calling autoFocus(AutoFocusCallback), cancelAutoFocus, or startPreview(). Applications can call getParameters() and this method anytime to get the latest focus distances. If the focus mode is FOCUS_MODE_CONTINUOUS_VIDEO, focus distances may change from time to time.</para><para>This method is intended to estimate the distance between the camera and the subject. After autofocus, the subject distance may be within near and far focus distance. However, the precision depends on the camera hardware, autofocus algorithm, the focus area, and the scene. The error can be large and it should be only used as a reference.</para><para>Far focus distance &gt;= optimal focus distance &gt;= near focus distance. If the focus distance is infinity, the value will be <c> Float.POSITIVE_INFINITY </c> .</para><para><para>FOCUS_DISTANCE_NEAR_INDEX </para><simplesectsep></simplesectsep><para>FOCUS_DISTANCE_OPTIMAL_INDEX </para><simplesectsep></simplesectsep><para>FOCUS_DISTANCE_FAR_INDEX </para></para>        
						/// </summary>
						/// <java-name>
						/// getFocusDistances
						/// </java-name>
						[Dot42.DexImport("getFocusDistances", "([F)V", AccessFlags = 1)]
						public virtual void GetFocusDistances(float[] output) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						/// <para>Gets the maximum number of focus areas supported. This is the maximum length of the list in setFocusAreas(List) and getFocusAreas().</para><para><para>getFocusAreas() </para></para>        
						/// </summary>
						/// <returns>
						/// <para>the maximum number of focus areas supported by the camera. </para>
						/// </returns>
						/// <java-name>
						/// getMaxNumFocusAreas
						/// </java-name>
						[Dot42.DexImport("getMaxNumFocusAreas", "()I", AccessFlags = 1)]
						public virtual int GetMaxNumFocusAreas() /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <summary>
						/// <para>Gets the current focus areas. Camera driver uses the areas to decide focus.</para><para>Before using this API or setFocusAreas(List), apps should call getMaxNumFocusAreas() to know the maximum number of focus areas first. If the value is 0, focus area is not supported.</para><para>Each focus area is a rectangle with specified weight. The direction is relative to the sensor orientation, that is, what the sensor sees. The direction is not affected by the rotation or mirroring of setDisplayOrientation(int). Coordinates of the rectangle range from -1000 to 1000. (-1000, -1000) is the upper left point. (1000, 1000) is the lower right point. The width and height of focus areas cannot be 0 or negative.</para><para>The weight must range from 1 to 1000. The weight should be interpreted as a per-pixel weight - all pixels in the area have the specified weight. This means a small area with the same weight as a larger area will have less influence on the focusing than the larger area. Focus areas can partially overlap and the driver will add the weights in the overlap region.</para><para>A special case of a <c> null </c> focus area list means the driver is free to select focus targets as it wants. For example, the driver may use more signals to select focus areas and change them dynamically. Apps can set the focus area list to <c> null </c> if they want the driver to completely control focusing.</para><para>Focus areas are relative to the current field of view (getZoom()). No matter what the zoom level is, (-1000,-1000) represents the top of the currently visible camera frame. The focus area cannot be set to be outside the current field of view, even when using zoom.</para><para>Focus area only has effect if the current focus mode is FOCUS_MODE_AUTO, FOCUS_MODE_MACRO, FOCUS_MODE_CONTINUOUS_VIDEO, or FOCUS_MODE_CONTINUOUS_PICTURE.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>a list of current focus areas </para>
						/// </returns>
						/// <java-name>
						/// getFocusAreas
						/// </java-name>
						[Dot42.DexImport("getFocusAreas", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Landroid/hardware/Camera$Area;>;")]
						public virtual global::Java.Util.IList<global::Android.Hardware.Camera.Area> GetFocusAreas() /* MethodBuilder.Create */ 
						{
								return default(global::Java.Util.IList<global::Android.Hardware.Camera.Area>);
						}

						/// <summary>
						/// <para>Sets focus areas. See getFocusAreas() for documentation.</para><para><para>getFocusAreas() </para></para>        
						/// </summary>
						/// <java-name>
						/// setFocusAreas
						/// </java-name>
						[Dot42.DexImport("setFocusAreas", "(Ljava/util/List;)V", AccessFlags = 1, Signature = "(Ljava/util/List<Landroid/hardware/Camera$Area;>;)V")]
						public virtual void SetFocusAreas(global::Java.Util.IList<global::Android.Hardware.Camera.Area> focusAreas) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						/// <para>Gets the maximum number of metering areas supported. This is the maximum length of the list in setMeteringAreas(List) and getMeteringAreas().</para><para><para>getMeteringAreas() </para></para>        
						/// </summary>
						/// <returns>
						/// <para>the maximum number of metering areas supported by the camera. </para>
						/// </returns>
						/// <java-name>
						/// getMaxNumMeteringAreas
						/// </java-name>
						[Dot42.DexImport("getMaxNumMeteringAreas", "()I", AccessFlags = 1)]
						public virtual int GetMaxNumMeteringAreas() /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <summary>
						/// <para>Gets the current metering areas. Camera driver uses these areas to decide exposure.</para><para>Before using this API or setMeteringAreas(List), apps should call getMaxNumMeteringAreas() to know the maximum number of metering areas first. If the value is 0, metering area is not supported.</para><para>Each metering area is a rectangle with specified weight. The direction is relative to the sensor orientation, that is, what the sensor sees. The direction is not affected by the rotation or mirroring of setDisplayOrientation(int). Coordinates of the rectangle range from -1000 to 1000. (-1000, -1000) is the upper left point. (1000, 1000) is the lower right point. The width and height of metering areas cannot be 0 or negative.</para><para>The weight must range from 1 to 1000, and represents a weight for every pixel in the area. This means that a large metering area with the same weight as a smaller area will have more effect in the metering result. Metering areas can partially overlap and the driver will add the weights in the overlap region.</para><para>A special case of a <c> null </c> metering area list means the driver is free to meter as it chooses. For example, the driver may use more signals to select metering areas and change them dynamically. Apps can set the metering area list to <c> null </c> if they want the driver to completely control metering.</para><para>Metering areas are relative to the current field of view (getZoom()). No matter what the zoom level is, (-1000,-1000) represents the top of the currently visible camera frame. The metering area cannot be set to be outside the current field of view, even when using zoom.</para><para>No matter what metering areas are, the final exposure are compensated by setExposureCompensation(int).</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>a list of current metering areas </para>
						/// </returns>
						/// <java-name>
						/// getMeteringAreas
						/// </java-name>
						[Dot42.DexImport("getMeteringAreas", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Landroid/hardware/Camera$Area;>;")]
						public virtual global::Java.Util.IList<global::Android.Hardware.Camera.Area> GetMeteringAreas() /* MethodBuilder.Create */ 
						{
								return default(global::Java.Util.IList<global::Android.Hardware.Camera.Area>);
						}

						/// <summary>
						/// <para>Sets metering areas. See getMeteringAreas() for documentation.</para><para><para>getMeteringAreas() </para></para>        
						/// </summary>
						/// <java-name>
						/// setMeteringAreas
						/// </java-name>
						[Dot42.DexImport("setMeteringAreas", "(Ljava/util/List;)V", AccessFlags = 1, Signature = "(Ljava/util/List<Landroid/hardware/Camera$Area;>;)V")]
						public virtual void SetMeteringAreas(global::Java.Util.IList<global::Android.Hardware.Camera.Area> meteringAreas) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						/// <para>Gets the maximum number of detected faces supported. This is the maximum length of the list returned from FaceDetectionListener. If the return value is 0, face detection of the specified type is not supported.</para><para><para>startFaceDetection() </para></para>        
						/// </summary>
						/// <returns>
						/// <para>the maximum number of detected face supported by the camera. </para>
						/// </returns>
						/// <java-name>
						/// getMaxNumDetectedFaces
						/// </java-name>
						[Dot42.DexImport("getMaxNumDetectedFaces", "()I", AccessFlags = 1)]
						public virtual int GetMaxNumDetectedFaces() /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <summary>
						/// <para>Sets recording mode hint. This tells the camera that the intent of the application is to record videos android.media.MediaRecorder#start(), not to take still pictures Camera.PictureCallback, Camera.PictureCallback, Camera.PictureCallback). Using this hint can allow MediaRecorder.start() to start faster or with fewer glitches on output. This should be called before starting preview for the best result, but can be changed while the preview is active. The default value is false.</para><para>The app can still call takePicture() when the hint is true or call MediaRecorder.start() when the hint is false. But the performance may be worse.</para><para></para>        
						/// </summary>
						/// <java-name>
						/// setRecordingHint
						/// </java-name>
						[Dot42.DexImport("setRecordingHint", "(Z)V", AccessFlags = 1)]
						public virtual void SetRecordingHint(bool hint) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						/// <para>Returns true if video snapshot is supported. That is, applications can call Camera.PictureCallback, Camera.PictureCallback, Camera.PictureCallback) during recording. Applications do not need to call startPreview() after taking a picture. The preview will be still active. Other than that, taking a picture during recording is identical to taking a picture normally. All settings and methods related to takePicture work identically. Ex: getPictureSize(), getSupportedPictureSizes(), setJpegQuality(int), setRotation(int), and etc. The picture will have an EXIF header. FLASH_MODE_AUTO and FLASH_MODE_ON also still work, but the video will record the flash.</para><para>Applications can set shutter callback as null to avoid the shutter sound. It is also recommended to set raw picture and post view callbacks to null to avoid the interrupt of preview display.</para><para>Field-of-view of the recorded video may be different from that of the captured pictures. The maximum size of a video snapshot may be smaller than that for regular still captures. If the current picture size is set higher than can be supported by video snapshot, the picture will be captured at the maximum supported size instead.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>true if video snapshot is supported. </para>
						/// </returns>
						/// <java-name>
						/// isVideoSnapshotSupported
						/// </java-name>
						[Dot42.DexImport("isVideoSnapshotSupported", "()Z", AccessFlags = 1)]
						public virtual bool IsVideoSnapshotSupported() /* MethodBuilder.Create */ 
						{
								return default(bool);
						}

						/// <summary>
						/// <para>Enables and disables video stabilization. Use isVideoStabilizationSupported to determine if calling this method is valid.</para><para>Video stabilization reduces the shaking due to the motion of the camera in both the preview stream and in recorded videos, including data received from the preview callback. It does not reduce motion blur in images captured with takePicture.</para><para>Video stabilization can be enabled and disabled while preview or recording is active, but toggling it may cause a jump in the video stream that may be undesirable in a recorded video.</para><para><para>isVideoStabilizationSupported() </para><simplesectsep></simplesectsep><para>getVideoStabilization() </para></para>        
						/// </summary>
						/// <java-name>
						/// setVideoStabilization
						/// </java-name>
						[Dot42.DexImport("setVideoStabilization", "(Z)V", AccessFlags = 1)]
						public virtual void SetVideoStabilization(bool toggle) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						/// <para>Get the current state of video stabilization. See setVideoStabilization for details of video stabilization.</para><para><para>isVideoStabilizationSupported() </para><simplesectsep></simplesectsep><para>setVideoStabilization(boolean) </para></para>        
						/// </summary>
						/// <returns>
						/// <para>true if video stabilization is enabled </para>
						/// </returns>
						/// <java-name>
						/// getVideoStabilization
						/// </java-name>
						[Dot42.DexImport("getVideoStabilization", "()Z", AccessFlags = 1)]
						public virtual bool GetVideoStabilization() /* MethodBuilder.Create */ 
						{
								return default(bool);
						}

						/// <summary>
						/// <para>Returns true if video stabilization is supported. See setVideoStabilization for details of video stabilization.</para><para><para>setVideoStabilization(boolean) </para><simplesectsep></simplesectsep><para>getVideoStabilization() </para></para>        
						/// </summary>
						/// <returns>
						/// <para>true if video stabilization is supported </para>
						/// </returns>
						/// <java-name>
						/// isVideoStabilizationSupported
						/// </java-name>
						[Dot42.DexImport("isVideoStabilizationSupported", "()Z", AccessFlags = 1)]
						public virtual bool IsVideoStabilizationSupported() /* MethodBuilder.Create */ 
						{
								return default(bool);
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal Parameters() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

						/// <summary>
						/// <para>Returns the dimensions setting for preview pictures.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>a Size object with the width and height setting for the preview picture </para>
						/// </returns>
						/// <java-name>
						/// getPreviewSize
						/// </java-name>
						public global::Android.Hardware.Camera.Size PreviewSize
						{
						[Dot42.DexImport("getPreviewSize", "()Landroid/hardware/Camera$Size;", AccessFlags = 1)]
								get{ return GetPreviewSize(); }
						}

						/// <summary>
						/// <para>Gets the supported preview sizes.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>a list of Size object. This method will always return a list with at least one element. </para>
						/// </returns>
						/// <java-name>
						/// getSupportedPreviewSizes
						/// </java-name>
						public global::Java.Util.IList<global::Android.Hardware.Camera.Size> SupportedPreviewSizes
						{
						[Dot42.DexImport("getSupportedPreviewSizes", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Landroid/hardware/Camera$Size;>;")]
								get{ return GetSupportedPreviewSizes(); }
						}

						/// <summary>
						/// <para>Gets the supported video frame sizes that can be used by MediaRecorder.</para><para>If the returned list is not null, the returned list will contain at least one Size and one of the sizes in the returned list must be passed to MediaRecorder.setVideoSize() for camcorder application if camera is used as the video source. In this case, the size of the preview can be different from the resolution of the recorded video during video recording.</para><para><para>getPreferredPreviewSizeForVideo() </para></para>        
						/// </summary>
						/// <returns>
						/// <para>a list of Size object if camera has separate preview and video output; otherwise, null is returned. </para>
						/// </returns>
						/// <java-name>
						/// getSupportedVideoSizes
						/// </java-name>
						public global::Java.Util.IList<global::Android.Hardware.Camera.Size> SupportedVideoSizes
						{
						[Dot42.DexImport("getSupportedVideoSizes", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Landroid/hardware/Camera$Size;>;")]
								get{ return GetSupportedVideoSizes(); }
						}

						/// <summary>
						/// <para>Returns the preferred or recommended preview size (width and height) in pixels for video recording. Camcorder applications should set the preview size to a value that is not larger than the preferred preview size. In other words, the product of the width and height of the preview size should not be larger than that of the preferred preview size. In addition, we recommend to choose a preview size that has the same aspect ratio as the resolution of video to be recorded.</para><para><para>getSupportedVideoSizes() </para></para>        
						/// </summary>
						/// <returns>
						/// <para>the preferred preview size (width and height) in pixels for video recording if getSupportedVideoSizes() does not return null; otherwise, null is returned. </para>
						/// </returns>
						/// <java-name>
						/// getPreferredPreviewSizeForVideo
						/// </java-name>
						public global::Android.Hardware.Camera.Size PreferredPreviewSizeForVideo
						{
						[Dot42.DexImport("getPreferredPreviewSizeForVideo", "()Landroid/hardware/Camera$Size;", AccessFlags = 1)]
								get{ return GetPreferredPreviewSizeForVideo(); }
						}

						/// <summary>
						/// <para>Returns the dimensions for EXIF thumbnail in Jpeg picture.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>a Size object with the height and width setting for the EXIF thumbnails </para>
						/// </returns>
						/// <java-name>
						/// getJpegThumbnailSize
						/// </java-name>
						public global::Android.Hardware.Camera.Size JpegThumbnailSize
						{
						[Dot42.DexImport("getJpegThumbnailSize", "()Landroid/hardware/Camera$Size;", AccessFlags = 1)]
								get{ return GetJpegThumbnailSize(); }
						}

						/// <summary>
						/// <para>Gets the supported jpeg thumbnail sizes.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>a list of Size object. This method will always return a list with at least two elements. Size 0,0 (no thumbnail) is always supported. </para>
						/// </returns>
						/// <java-name>
						/// getSupportedJpegThumbnailSizes
						/// </java-name>
						public global::Java.Util.IList<global::Android.Hardware.Camera.Size> SupportedJpegThumbnailSizes
						{
						[Dot42.DexImport("getSupportedJpegThumbnailSizes", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Landroid/hardware/Camera$Size;>;")]
								get{ return GetSupportedJpegThumbnailSizes(); }
						}

						/// <summary>
						/// <para>Returns the quality setting for the EXIF thumbnail in Jpeg picture.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>the JPEG quality setting of the EXIF thumbnail. </para>
						/// </returns>
						/// <java-name>
						/// getJpegThumbnailQuality
						/// </java-name>
						public int JpegThumbnailQuality
						{
						[Dot42.DexImport("getJpegThumbnailQuality", "()I", AccessFlags = 1)]
								get{ return GetJpegThumbnailQuality(); }
						[Dot42.DexImport("setJpegThumbnailQuality", "(I)V", AccessFlags = 1)]
								set{ SetJpegThumbnailQuality(value); }
						}

						/// <summary>
						/// <para>Returns the quality setting for the JPEG picture.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>the JPEG picture quality setting. </para>
						/// </returns>
						/// <java-name>
						/// getJpegQuality
						/// </java-name>
						public int JpegQuality
						{
						[Dot42.DexImport("getJpegQuality", "()I", AccessFlags = 1)]
								get{ return GetJpegQuality(); }
						[Dot42.DexImport("setJpegQuality", "(I)V", AccessFlags = 1)]
								set{ SetJpegQuality(value); }
						}

						/// <summary>
						/// <para>Returns the setting for the rate at which preview frames are received. This is the target frame rate. The actual frame rate depends on the driver.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>replaced by getPreviewFpsRange(int[]) </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <returns>
						/// <para>the frame rate setting (frames per second) </para>
						/// </returns>
						/// <java-name>
						/// getPreviewFrameRate
						/// </java-name>
						public int PreviewFrameRate
						{
						[Dot42.DexImport("getPreviewFrameRate", "()I", AccessFlags = 1)]
								get{ return GetPreviewFrameRate(); }
						[Dot42.DexImport("setPreviewFrameRate", "(I)V", AccessFlags = 1)]
								set{ SetPreviewFrameRate(value); }
						}

						/// <summary>
						/// <para>Gets the supported preview frame rates.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>replaced by getSupportedPreviewFpsRange() </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <returns>
						/// <para>a list of supported preview frame rates. null if preview frame rate setting is not supported. </para>
						/// </returns>
						/// <java-name>
						/// getSupportedPreviewFrameRates
						/// </java-name>
						public global::Java.Util.IList<int?> SupportedPreviewFrameRates
						{
						[Dot42.DexImport("getSupportedPreviewFrameRates", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Ljava/lang/Integer;>;")]
								get{ return GetSupportedPreviewFrameRates(); }
						}

						/// <summary>
						/// <para>Gets the supported preview fps (frame-per-second) ranges. Each range contains a minimum fps and maximum fps. If minimum fps equals to maximum fps, the camera outputs frames in fixed frame rate. If not, the camera outputs frames in auto frame rate. The actual frame rate fluctuates between the minimum and the maximum. The values are multiplied by 1000 and represented in integers. For example, if frame rate is 26.623 frames per second, the value is 26623.</para><para><para>PREVIEW_FPS_MIN_INDEX </para><simplesectsep></simplesectsep><para>PREVIEW_FPS_MAX_INDEX </para></para>        
						/// </summary>
						/// <returns>
						/// <para>a list of supported preview fps ranges. This method returns a list with at least one element. Every element is an int array of two values - minimum fps and maximum fps. The list is sorted from small to large (first by maximum fps and then minimum fps). </para>
						/// </returns>
						/// <java-name>
						/// getSupportedPreviewFpsRange
						/// </java-name>
						public global::Java.Util.IList<int[]> SupportedPreviewFpsRange
						{
						[Dot42.DexImport("getSupportedPreviewFpsRange", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<[I>;")]
								get{ return GetSupportedPreviewFpsRange(); }
						}

						/// <summary>
						/// <para>Returns the image format for preview frames got from PreviewCallback.</para><para><para>android.graphics.ImageFormat </para><simplesectsep></simplesectsep><para>setPreviewFormat </para></para>        
						/// </summary>
						/// <returns>
						/// <para>the preview format. </para>
						/// </returns>
						/// <java-name>
						/// getPreviewFormat
						/// </java-name>
						public int PreviewFormat
						{
						[Dot42.DexImport("getPreviewFormat", "()I", AccessFlags = 1)]
								get{ return GetPreviewFormat(); }
						[Dot42.DexImport("setPreviewFormat", "(I)V", AccessFlags = 1)]
								set{ SetPreviewFormat(value); }
						}

						/// <summary>
						/// <para>Gets the supported preview formats. android.graphics.ImageFormat#NV21 is always supported. android.graphics.ImageFormat#YV12 is always supported since API level 12.</para><para><para>android.graphics.ImageFormat </para><simplesectsep></simplesectsep><para>setPreviewFormat </para></para>        
						/// </summary>
						/// <returns>
						/// <para>a list of supported preview formats. This method will always return a list with at least one element. </para>
						/// </returns>
						/// <java-name>
						/// getSupportedPreviewFormats
						/// </java-name>
						public global::Java.Util.IList<int?> SupportedPreviewFormats
						{
						[Dot42.DexImport("getSupportedPreviewFormats", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Ljava/lang/Integer;>;")]
								get{ return GetSupportedPreviewFormats(); }
						}

						/// <summary>
						/// <para>Returns the dimension setting for pictures.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>a Size object with the height and width setting for pictures </para>
						/// </returns>
						/// <java-name>
						/// getPictureSize
						/// </java-name>
						public global::Android.Hardware.Camera.Size PictureSize
						{
						[Dot42.DexImport("getPictureSize", "()Landroid/hardware/Camera$Size;", AccessFlags = 1)]
								get{ return GetPictureSize(); }
						}

						/// <summary>
						/// <para>Gets the supported picture sizes.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>a list of supported picture sizes. This method will always return a list with at least one element. </para>
						/// </returns>
						/// <java-name>
						/// getSupportedPictureSizes
						/// </java-name>
						public global::Java.Util.IList<global::Android.Hardware.Camera.Size> SupportedPictureSizes
						{
						[Dot42.DexImport("getSupportedPictureSizes", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Landroid/hardware/Camera$Size;>;")]
								get{ return GetSupportedPictureSizes(); }
						}

						/// <summary>
						/// <para>Returns the image format for pictures.</para><para><para>android.graphics.ImageFormat </para></para>        
						/// </summary>
						/// <returns>
						/// <para>the picture format </para>
						/// </returns>
						/// <java-name>
						/// getPictureFormat
						/// </java-name>
						public int PictureFormat
						{
						[Dot42.DexImport("getPictureFormat", "()I", AccessFlags = 1)]
								get{ return GetPictureFormat(); }
						[Dot42.DexImport("setPictureFormat", "(I)V", AccessFlags = 1)]
								set{ SetPictureFormat(value); }
						}

						/// <summary>
						/// <para>Gets the supported picture formats.</para><para><para>android.graphics.ImageFormat </para></para>        
						/// </summary>
						/// <returns>
						/// <para>supported picture formats. This method will always return a list with at least one element. </para>
						/// </returns>
						/// <java-name>
						/// getSupportedPictureFormats
						/// </java-name>
						public global::Java.Util.IList<int?> SupportedPictureFormats
						{
						[Dot42.DexImport("getSupportedPictureFormats", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Ljava/lang/Integer;>;")]
								get{ return GetSupportedPictureFormats(); }
						}

						/// <summary>
						/// <para>Gets the current white balance setting.</para><para><para>#WHITE_BALANCE_AUTO </para><simplesectsep></simplesectsep><para>#WHITE_BALANCE_INCANDESCENT </para><simplesectsep></simplesectsep><para>#WHITE_BALANCE_FLUORESCENT </para><simplesectsep></simplesectsep><para>#WHITE_BALANCE_WARM_FLUORESCENT </para><simplesectsep></simplesectsep><para>#WHITE_BALANCE_DAYLIGHT </para><simplesectsep></simplesectsep><para>#WHITE_BALANCE_CLOUDY_DAYLIGHT </para><simplesectsep></simplesectsep><para>#WHITE_BALANCE_TWILIGHT </para><simplesectsep></simplesectsep><para>#WHITE_BALANCE_SHADE </para></para>        
						/// </summary>
						/// <returns>
						/// <para>current white balance. null if white balance setting is not supported. </para>
						/// </returns>
						/// <java-name>
						/// getWhiteBalance
						/// </java-name>
						public string WhiteBalance
						{
						[Dot42.DexImport("getWhiteBalance", "()Ljava/lang/String;", AccessFlags = 1)]
								get{ return GetWhiteBalance(); }
						[Dot42.DexImport("setWhiteBalance", "(Ljava/lang/String;)V", AccessFlags = 1)]
								set{ SetWhiteBalance(value); }
						}

						/// <summary>
						/// <para>Gets the supported white balance.</para><para><para>getWhiteBalance() </para></para>        
						/// </summary>
						/// <returns>
						/// <para>a list of supported white balance. null if white balance setting is not supported. </para>
						/// </returns>
						/// <java-name>
						/// getSupportedWhiteBalance
						/// </java-name>
						public global::Java.Util.IList<string> SupportedWhiteBalance
						{
						[Dot42.DexImport("getSupportedWhiteBalance", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Ljava/lang/String;>;")]
								get{ return GetSupportedWhiteBalance(); }
						}

						/// <summary>
						/// <para>Gets the current color effect setting.</para><para><para>#EFFECT_NONE </para><simplesectsep></simplesectsep><para>#EFFECT_MONO </para><simplesectsep></simplesectsep><para>#EFFECT_NEGATIVE </para><simplesectsep></simplesectsep><para>#EFFECT_SOLARIZE </para><simplesectsep></simplesectsep><para>#EFFECT_SEPIA </para><simplesectsep></simplesectsep><para>#EFFECT_POSTERIZE </para><simplesectsep></simplesectsep><para>#EFFECT_WHITEBOARD </para><simplesectsep></simplesectsep><para>#EFFECT_BLACKBOARD </para><simplesectsep></simplesectsep><para>#EFFECT_AQUA </para></para>        
						/// </summary>
						/// <returns>
						/// <para>current color effect. null if color effect setting is not supported. </para>
						/// </returns>
						/// <java-name>
						/// getColorEffect
						/// </java-name>
						public string ColorEffect
						{
						[Dot42.DexImport("getColorEffect", "()Ljava/lang/String;", AccessFlags = 1)]
								get{ return GetColorEffect(); }
						[Dot42.DexImport("setColorEffect", "(Ljava/lang/String;)V", AccessFlags = 1)]
								set{ SetColorEffect(value); }
						}

						/// <summary>
						/// <para>Gets the supported color effects.</para><para><para>getColorEffect() </para></para>        
						/// </summary>
						/// <returns>
						/// <para>a list of supported color effects. null if color effect setting is not supported. </para>
						/// </returns>
						/// <java-name>
						/// getSupportedColorEffects
						/// </java-name>
						public global::Java.Util.IList<string> SupportedColorEffects
						{
						[Dot42.DexImport("getSupportedColorEffects", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Ljava/lang/String;>;")]
								get{ return GetSupportedColorEffects(); }
						}

						/// <summary>
						/// <para>Gets the current antibanding setting.</para><para><para>#ANTIBANDING_AUTO </para><simplesectsep></simplesectsep><para>#ANTIBANDING_50HZ </para><simplesectsep></simplesectsep><para>#ANTIBANDING_60HZ </para><simplesectsep></simplesectsep><para>#ANTIBANDING_OFF </para></para>        
						/// </summary>
						/// <returns>
						/// <para>current antibanding. null if antibanding setting is not supported. </para>
						/// </returns>
						/// <java-name>
						/// getAntibanding
						/// </java-name>
						public string Antibanding
						{
						[Dot42.DexImport("getAntibanding", "()Ljava/lang/String;", AccessFlags = 1)]
								get{ return GetAntibanding(); }
						[Dot42.DexImport("setAntibanding", "(Ljava/lang/String;)V", AccessFlags = 1)]
								set{ SetAntibanding(value); }
						}

						/// <summary>
						/// <para>Gets the supported antibanding values.</para><para><para>getAntibanding() </para></para>        
						/// </summary>
						/// <returns>
						/// <para>a list of supported antibanding values. null if antibanding setting is not supported. </para>
						/// </returns>
						/// <java-name>
						/// getSupportedAntibanding
						/// </java-name>
						public global::Java.Util.IList<string> SupportedAntibanding
						{
						[Dot42.DexImport("getSupportedAntibanding", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Ljava/lang/String;>;")]
								get{ return GetSupportedAntibanding(); }
						}

						/// <summary>
						/// <para>Gets the current scene mode setting.</para><para><para>SCENE_MODE_AUTO </para><simplesectsep></simplesectsep><para>SCENE_MODE_ACTION </para><simplesectsep></simplesectsep><para>SCENE_MODE_PORTRAIT </para><simplesectsep></simplesectsep><para>SCENE_MODE_LANDSCAPE </para><simplesectsep></simplesectsep><para>SCENE_MODE_NIGHT </para><simplesectsep></simplesectsep><para>SCENE_MODE_NIGHT_PORTRAIT </para><simplesectsep></simplesectsep><para>SCENE_MODE_THEATRE </para><simplesectsep></simplesectsep><para>SCENE_MODE_BEACH </para><simplesectsep></simplesectsep><para>SCENE_MODE_SNOW </para><simplesectsep></simplesectsep><para>SCENE_MODE_SUNSET </para><simplesectsep></simplesectsep><para>SCENE_MODE_STEADYPHOTO </para><simplesectsep></simplesectsep><para>SCENE_MODE_FIREWORKS </para><simplesectsep></simplesectsep><para>SCENE_MODE_SPORTS </para><simplesectsep></simplesectsep><para>SCENE_MODE_PARTY </para><simplesectsep></simplesectsep><para>SCENE_MODE_CANDLELIGHT </para><simplesectsep></simplesectsep><para>SCENE_MODE_BARCODE </para></para>        
						/// </summary>
						/// <returns>
						/// <para>one of SCENE_MODE_XXX string constant. null if scene mode setting is not supported. </para>
						/// </returns>
						/// <java-name>
						/// getSceneMode
						/// </java-name>
						public string SceneMode
						{
						[Dot42.DexImport("getSceneMode", "()Ljava/lang/String;", AccessFlags = 1)]
								get{ return GetSceneMode(); }
						[Dot42.DexImport("setSceneMode", "(Ljava/lang/String;)V", AccessFlags = 1)]
								set{ SetSceneMode(value); }
						}

						/// <summary>
						/// <para>Gets the supported scene modes.</para><para><para>getSceneMode() </para></para>        
						/// </summary>
						/// <returns>
						/// <para>a list of supported scene modes. null if scene mode setting is not supported. </para>
						/// </returns>
						/// <java-name>
						/// getSupportedSceneModes
						/// </java-name>
						public global::Java.Util.IList<string> SupportedSceneModes
						{
						[Dot42.DexImport("getSupportedSceneModes", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Ljava/lang/String;>;")]
								get{ return GetSupportedSceneModes(); }
						}

						/// <summary>
						/// <para>Gets the current flash mode setting.</para><para><para>FLASH_MODE_OFF </para><simplesectsep></simplesectsep><para>FLASH_MODE_AUTO </para><simplesectsep></simplesectsep><para>FLASH_MODE_ON </para><simplesectsep></simplesectsep><para>FLASH_MODE_RED_EYE </para><simplesectsep></simplesectsep><para>FLASH_MODE_TORCH </para></para>        
						/// </summary>
						/// <returns>
						/// <para>current flash mode. null if flash mode setting is not supported. </para>
						/// </returns>
						/// <java-name>
						/// getFlashMode
						/// </java-name>
						public string FlashMode
						{
						[Dot42.DexImport("getFlashMode", "()Ljava/lang/String;", AccessFlags = 1)]
								get{ return GetFlashMode(); }
						[Dot42.DexImport("setFlashMode", "(Ljava/lang/String;)V", AccessFlags = 1)]
								set{ SetFlashMode(value); }
						}

						/// <summary>
						/// <para>Gets the supported flash modes.</para><para><para>getFlashMode() </para></para>        
						/// </summary>
						/// <returns>
						/// <para>a list of supported flash modes. null if flash mode setting is not supported. </para>
						/// </returns>
						/// <java-name>
						/// getSupportedFlashModes
						/// </java-name>
						public global::Java.Util.IList<string> SupportedFlashModes
						{
						[Dot42.DexImport("getSupportedFlashModes", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Ljava/lang/String;>;")]
								get{ return GetSupportedFlashModes(); }
						}

						/// <summary>
						/// <para>Gets the current focus mode setting.</para><para><para>FOCUS_MODE_AUTO </para><simplesectsep></simplesectsep><para>FOCUS_MODE_INFINITY </para><simplesectsep></simplesectsep><para>FOCUS_MODE_MACRO </para><simplesectsep></simplesectsep><para>FOCUS_MODE_FIXED </para><simplesectsep></simplesectsep><para>FOCUS_MODE_EDOF </para><simplesectsep></simplesectsep><para>FOCUS_MODE_CONTINUOUS_VIDEO </para></para>        
						/// </summary>
						/// <returns>
						/// <para>current focus mode. This method will always return a non-null value. Applications should call autoFocus(AutoFocusCallback) to start the focus if focus mode is FOCUS_MODE_AUTO or FOCUS_MODE_MACRO. </para>
						/// </returns>
						/// <java-name>
						/// getFocusMode
						/// </java-name>
						public string FocusMode
						{
						[Dot42.DexImport("getFocusMode", "()Ljava/lang/String;", AccessFlags = 1)]
								get{ return GetFocusMode(); }
						[Dot42.DexImport("setFocusMode", "(Ljava/lang/String;)V", AccessFlags = 1)]
								set{ SetFocusMode(value); }
						}

						/// <summary>
						/// <para>Gets the supported focus modes.</para><para><para>getFocusMode() </para></para>        
						/// </summary>
						/// <returns>
						/// <para>a list of supported focus modes. This method will always return a list with at least one element. </para>
						/// </returns>
						/// <java-name>
						/// getSupportedFocusModes
						/// </java-name>
						public global::Java.Util.IList<string> SupportedFocusModes
						{
						[Dot42.DexImport("getSupportedFocusModes", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Ljava/lang/String;>;")]
								get{ return GetSupportedFocusModes(); }
						}

						/// <summary>
						/// <para>Gets the focal length (in millimeter) of the camera.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>the focal length. This method will always return a valid value. </para>
						/// </returns>
						/// <java-name>
						/// getFocalLength
						/// </java-name>
						public float FocalLength
						{
						[Dot42.DexImport("getFocalLength", "()F", AccessFlags = 1)]
								get{ return GetFocalLength(); }
						}

						/// <summary>
						/// <para>Gets the horizontal angle of view in degrees.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>horizontal angle of view. This method will always return a valid value. </para>
						/// </returns>
						/// <java-name>
						/// getHorizontalViewAngle
						/// </java-name>
						public float HorizontalViewAngle
						{
						[Dot42.DexImport("getHorizontalViewAngle", "()F", AccessFlags = 1)]
								get{ return GetHorizontalViewAngle(); }
						}

						/// <summary>
						/// <para>Gets the vertical angle of view in degrees.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>vertical angle of view. This method will always return a valid value. </para>
						/// </returns>
						/// <java-name>
						/// getVerticalViewAngle
						/// </java-name>
						public float VerticalViewAngle
						{
						[Dot42.DexImport("getVerticalViewAngle", "()F", AccessFlags = 1)]
								get{ return GetVerticalViewAngle(); }
						}

						/// <summary>
						/// <para>Gets the current exposure compensation index.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>current exposure compensation index. The range is getMinExposureCompensation to getMaxExposureCompensation. 0 means exposure is not adjusted. </para>
						/// </returns>
						/// <java-name>
						/// getExposureCompensation
						/// </java-name>
						public int ExposureCompensation
						{
						[Dot42.DexImport("getExposureCompensation", "()I", AccessFlags = 1)]
								get{ return GetExposureCompensation(); }
						[Dot42.DexImport("setExposureCompensation", "(I)V", AccessFlags = 1)]
								set{ SetExposureCompensation(value); }
						}

						/// <summary>
						/// <para>Gets the maximum exposure compensation index.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>maximum exposure compensation index (&gt;=0). If both this method and getMinExposureCompensation return 0, exposure compensation is not supported. </para>
						/// </returns>
						/// <java-name>
						/// getMaxExposureCompensation
						/// </java-name>
						public int MaxExposureCompensation
						{
						[Dot42.DexImport("getMaxExposureCompensation", "()I", AccessFlags = 1)]
								get{ return GetMaxExposureCompensation(); }
						}

						/// <summary>
						/// <para>Gets the minimum exposure compensation index.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>minimum exposure compensation index (&lt;=0). If both this method and getMaxExposureCompensation return 0, exposure compensation is not supported. </para>
						/// </returns>
						/// <java-name>
						/// getMinExposureCompensation
						/// </java-name>
						public int MinExposureCompensation
						{
						[Dot42.DexImport("getMinExposureCompensation", "()I", AccessFlags = 1)]
								get{ return GetMinExposureCompensation(); }
						}

						/// <summary>
						/// <para>Gets the exposure compensation step.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>exposure compensation step. Applications can get EV by multiplying the exposure compensation index and step. Ex: if exposure compensation index is -6 and step is 0.333333333, EV is -2. </para>
						/// </returns>
						/// <java-name>
						/// getExposureCompensationStep
						/// </java-name>
						public float ExposureCompensationStep
						{
						[Dot42.DexImport("getExposureCompensationStep", "()F", AccessFlags = 1)]
								get{ return GetExposureCompensationStep(); }
						}

						/// <summary>
						/// <para>Gets the state of the auto-exposure lock. Applications should check isAutoExposureLockSupported before using this method. See setAutoExposureLock for details about the lock.</para><para><para>setAutoExposureLock(boolean) </para></para>        
						/// </summary>
						/// <returns>
						/// <para>State of the auto-exposure lock. Returns true if auto-exposure is currently locked, and false otherwise.</para>
						/// </returns>
						/// <java-name>
						/// getAutoExposureLock
						/// </java-name>
						public bool IsAutoExposureLock
						{
						[Dot42.DexImport("getAutoExposureLock", "()Z", AccessFlags = 1)]
								get{ return GetAutoExposureLock(); }
						[Dot42.DexImport("setAutoExposureLock", "(Z)V", AccessFlags = 1)]
								set{ SetAutoExposureLock(value); }
						}

						/// <summary>
						/// <para>Gets the state of the auto-white balance lock. Applications should check isAutoWhiteBalanceLockSupported before using this method. See setAutoWhiteBalanceLock for details about the lock.</para><para><para>setAutoWhiteBalanceLock(boolean) </para></para>        
						/// </summary>
						/// <returns>
						/// <para>State of the auto-white balance lock. Returns true if auto-white balance is currently locked, and false otherwise.</para>
						/// </returns>
						/// <java-name>
						/// getAutoWhiteBalanceLock
						/// </java-name>
						public bool IsAutoWhiteBalanceLock
						{
						[Dot42.DexImport("getAutoWhiteBalanceLock", "()Z", AccessFlags = 1)]
								get{ return GetAutoWhiteBalanceLock(); }
						[Dot42.DexImport("setAutoWhiteBalanceLock", "(Z)V", AccessFlags = 1)]
								set{ SetAutoWhiteBalanceLock(value); }
						}

						/// <summary>
						/// <para>Gets current zoom value. This also works when smooth zoom is in progress. Applications should check isZoomSupported before using this method.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>the current zoom value. The range is 0 to getMaxZoom. 0 means the camera is not zoomed. </para>
						/// </returns>
						/// <java-name>
						/// getZoom
						/// </java-name>
						public int Zoom
						{
						[Dot42.DexImport("getZoom", "()I", AccessFlags = 1)]
								get{ return GetZoom(); }
						[Dot42.DexImport("setZoom", "(I)V", AccessFlags = 1)]
								set{ SetZoom(value); }
						}

						/// <summary>
						/// <para>Gets the maximum zoom value allowed for snapshot. This is the maximum value that applications can set to setZoom(int). Applications should call isZoomSupported before using this method. This value may change in different preview size. Applications should call this again after setting preview size.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>the maximum zoom value supported by the camera. </para>
						/// </returns>
						/// <java-name>
						/// getMaxZoom
						/// </java-name>
						public int MaxZoom
						{
						[Dot42.DexImport("getMaxZoom", "()I", AccessFlags = 1)]
								get{ return GetMaxZoom(); }
						}

						/// <summary>
						/// <para>Gets the zoom ratios of all zoom values. Applications should check isZoomSupported before using this method.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>the zoom ratios in 1/100 increments. Ex: a zoom of 3.2x is returned as 320. The number of elements is getMaxZoom + 1. The list is sorted from small to large. The first element is always 100. The last element is the zoom ratio of the maximum zoom value. </para>
						/// </returns>
						/// <java-name>
						/// getZoomRatios
						/// </java-name>
						public global::Java.Util.IList<int?> ZoomRatios
						{
						[Dot42.DexImport("getZoomRatios", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Ljava/lang/Integer;>;")]
								get{ return GetZoomRatios(); }
						}

						/// <summary>
						/// <para>Gets the maximum number of focus areas supported. This is the maximum length of the list in setFocusAreas(List) and getFocusAreas().</para><para><para>getFocusAreas() </para></para>        
						/// </summary>
						/// <returns>
						/// <para>the maximum number of focus areas supported by the camera. </para>
						/// </returns>
						/// <java-name>
						/// getMaxNumFocusAreas
						/// </java-name>
						public int MaxNumFocusAreas
						{
						[Dot42.DexImport("getMaxNumFocusAreas", "()I", AccessFlags = 1)]
								get{ return GetMaxNumFocusAreas(); }
						}

						/// <summary>
						/// <para>Gets the current focus areas. Camera driver uses the areas to decide focus.</para><para>Before using this API or setFocusAreas(List), apps should call getMaxNumFocusAreas() to know the maximum number of focus areas first. If the value is 0, focus area is not supported.</para><para>Each focus area is a rectangle with specified weight. The direction is relative to the sensor orientation, that is, what the sensor sees. The direction is not affected by the rotation or mirroring of setDisplayOrientation(int). Coordinates of the rectangle range from -1000 to 1000. (-1000, -1000) is the upper left point. (1000, 1000) is the lower right point. The width and height of focus areas cannot be 0 or negative.</para><para>The weight must range from 1 to 1000. The weight should be interpreted as a per-pixel weight - all pixels in the area have the specified weight. This means a small area with the same weight as a larger area will have less influence on the focusing than the larger area. Focus areas can partially overlap and the driver will add the weights in the overlap region.</para><para>A special case of a <c> null </c> focus area list means the driver is free to select focus targets as it wants. For example, the driver may use more signals to select focus areas and change them dynamically. Apps can set the focus area list to <c> null </c> if they want the driver to completely control focusing.</para><para>Focus areas are relative to the current field of view (getZoom()). No matter what the zoom level is, (-1000,-1000) represents the top of the currently visible camera frame. The focus area cannot be set to be outside the current field of view, even when using zoom.</para><para>Focus area only has effect if the current focus mode is FOCUS_MODE_AUTO, FOCUS_MODE_MACRO, FOCUS_MODE_CONTINUOUS_VIDEO, or FOCUS_MODE_CONTINUOUS_PICTURE.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>a list of current focus areas </para>
						/// </returns>
						/// <java-name>
						/// getFocusAreas
						/// </java-name>
						public global::Java.Util.IList<global::Android.Hardware.Camera.Area> FocusAreas
						{
						[Dot42.DexImport("getFocusAreas", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Landroid/hardware/Camera$Area;>;")]
								get{ return GetFocusAreas(); }
						[Dot42.DexImport("setFocusAreas", "(Ljava/util/List;)V", AccessFlags = 1, Signature = "(Ljava/util/List<Landroid/hardware/Camera$Area;>;)V")]
								set{ SetFocusAreas(value); }
						}

						/// <summary>
						/// <para>Gets the maximum number of metering areas supported. This is the maximum length of the list in setMeteringAreas(List) and getMeteringAreas().</para><para><para>getMeteringAreas() </para></para>        
						/// </summary>
						/// <returns>
						/// <para>the maximum number of metering areas supported by the camera. </para>
						/// </returns>
						/// <java-name>
						/// getMaxNumMeteringAreas
						/// </java-name>
						public int MaxNumMeteringAreas
						{
						[Dot42.DexImport("getMaxNumMeteringAreas", "()I", AccessFlags = 1)]
								get{ return GetMaxNumMeteringAreas(); }
						}

						/// <summary>
						/// <para>Gets the current metering areas. Camera driver uses these areas to decide exposure.</para><para>Before using this API or setMeteringAreas(List), apps should call getMaxNumMeteringAreas() to know the maximum number of metering areas first. If the value is 0, metering area is not supported.</para><para>Each metering area is a rectangle with specified weight. The direction is relative to the sensor orientation, that is, what the sensor sees. The direction is not affected by the rotation or mirroring of setDisplayOrientation(int). Coordinates of the rectangle range from -1000 to 1000. (-1000, -1000) is the upper left point. (1000, 1000) is the lower right point. The width and height of metering areas cannot be 0 or negative.</para><para>The weight must range from 1 to 1000, and represents a weight for every pixel in the area. This means that a large metering area with the same weight as a smaller area will have more effect in the metering result. Metering areas can partially overlap and the driver will add the weights in the overlap region.</para><para>A special case of a <c> null </c> metering area list means the driver is free to meter as it chooses. For example, the driver may use more signals to select metering areas and change them dynamically. Apps can set the metering area list to <c> null </c> if they want the driver to completely control metering.</para><para>Metering areas are relative to the current field of view (getZoom()). No matter what the zoom level is, (-1000,-1000) represents the top of the currently visible camera frame. The metering area cannot be set to be outside the current field of view, even when using zoom.</para><para>No matter what metering areas are, the final exposure are compensated by setExposureCompensation(int).</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>a list of current metering areas </para>
						/// </returns>
						/// <java-name>
						/// getMeteringAreas
						/// </java-name>
						public global::Java.Util.IList<global::Android.Hardware.Camera.Area> MeteringAreas
						{
						[Dot42.DexImport("getMeteringAreas", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Landroid/hardware/Camera$Area;>;")]
								get{ return GetMeteringAreas(); }
						[Dot42.DexImport("setMeteringAreas", "(Ljava/util/List;)V", AccessFlags = 1, Signature = "(Ljava/util/List<Landroid/hardware/Camera$Area;>;)V")]
								set{ SetMeteringAreas(value); }
						}

						/// <summary>
						/// <para>Gets the maximum number of detected faces supported. This is the maximum length of the list returned from FaceDetectionListener. If the return value is 0, face detection of the specified type is not supported.</para><para><para>startFaceDetection() </para></para>        
						/// </summary>
						/// <returns>
						/// <para>the maximum number of detected face supported by the camera. </para>
						/// </returns>
						/// <java-name>
						/// getMaxNumDetectedFaces
						/// </java-name>
						public int MaxNumDetectedFaces
						{
						[Dot42.DexImport("getMaxNumDetectedFaces", "()I", AccessFlags = 1)]
								get{ return GetMaxNumDetectedFaces(); }
						}

						/// <summary>
						/// <para>Get the current state of video stabilization. See setVideoStabilization for details of video stabilization.</para><para><para>isVideoStabilizationSupported() </para><simplesectsep></simplesectsep><para>setVideoStabilization(boolean) </para></para>        
						/// </summary>
						/// <returns>
						/// <para>true if video stabilization is enabled </para>
						/// </returns>
						/// <java-name>
						/// getVideoStabilization
						/// </java-name>
						public bool IsVideoStabilization
						{
						[Dot42.DexImport("getVideoStabilization", "()Z", AccessFlags = 1)]
								get{ return GetVideoStabilization(); }
						[Dot42.DexImport("setVideoStabilization", "(Z)V", AccessFlags = 1)]
								set{ SetVideoStabilization(value); }
						}

				}

				/// <summary>
				/// <para>The Area class is used for choosing specific metering and focus areas for the camera to use when calculating auto-exposure, auto-white balance, and auto-focus.</para><para>To find out how many simultaneous areas a given camera supports, use Parameters#getMaxNumMeteringAreas() and Parameters#getMaxNumFocusAreas(). If metering or focusing area selection is unsupported, these methods will return 0.</para><para>Each Area consists of a rectangle specifying its bounds, and a weight that determines its importance. The bounds are relative to the camera's current field of view. The coordinates are mapped so that (-1000, -1000) is always the top-left corner of the current field of view, and (1000, 1000) is always the bottom-right corner of the current field of view. Setting Areas with bounds outside that range is not allowed. Areas with zero or negative width or height are not allowed.</para><para>The weight must range from 1 to 1000, and represents a weight for every pixel in the area. This means that a large metering area with the same weight as a smaller area will have more effect in the metering result. Metering areas can overlap and the driver will add the weights in the overlap region.</para><para><para>Parameters::setFocusAreas(List) </para><simplesectsep></simplesectsep><para>Parameters::getFocusAreas() </para><simplesectsep></simplesectsep><para>Parameters::getMaxNumFocusAreas() </para><simplesectsep></simplesectsep><para>Parameters::setMeteringAreas(List) </para><simplesectsep></simplesectsep><para>Parameters::getMeteringAreas() </para><simplesectsep></simplesectsep><para>Parameters::getMaxNumMeteringAreas() </para></para>    
				/// </summary>
				/// <java-name>
				/// android/hardware/Camera$Area
				/// </java-name>
				[Dot42.DexImport("android/hardware/Camera$Area", AccessFlags = 9)]
				public partial class Area
 /* scope: __dot42__ */ 
				{
						/// <summary>
						/// <para>Bounds of the area. (-1000, -1000) represents the top-left of the camera field of view, and (1000, 1000) represents the bottom-right of the field of view. Setting bounds outside that range is not allowed. Bounds with zero or negative width or height are not allowed.</para><para><para>Parameters::getFocusAreas() </para><simplesectsep></simplesectsep><para>Parameters::getMeteringAreas() </para></para>        
						/// </summary>
						/// <java-name>
						/// rect
						/// </java-name>
						[Dot42.DexImport("rect", "Landroid/graphics/Rect;", AccessFlags = 1)]
						public global::Android.Graphics.Rect Rect;
						/// <summary>
						/// <para>Weight of the area. The weight must range from 1 to 1000, and represents a weight for every pixel in the area. This means that a large metering area with the same weight as a smaller area will have more effect in the metering result. Metering areas can overlap and the driver will add the weights in the overlap region.</para><para><para>Parameters::getFocusAreas() </para><simplesectsep></simplesectsep><para>Parameters::getMeteringAreas() </para></para>        
						/// </summary>
						/// <java-name>
						/// weight
						/// </java-name>
						[Dot42.DexImport("weight", "I", AccessFlags = 1)]
						public int Weight;
						[Dot42.DexImport("<init>", "(Landroid/graphics/Rect;I)V", AccessFlags = 1)]
						public Area(global::Android.Graphics.Rect rect, int int32) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						/// <para>Compares <c> obj </c> to this area.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para><c> true </c> if the rectangle and weight of <c> obj </c> is the same as those of this area. <c> false </c> otherwise. </para>
						/// </returns>
						/// <java-name>
						/// equals
						/// </java-name>
						[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
						public override bool Equals(object obj) /* MethodBuilder.Create */ 
						{
								return default(bool);
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal Area() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

				}

				/// <summary>
				/// <para>Image size (width and height dimensions). </para>    
				/// </summary>
				/// <java-name>
				/// android/hardware/Camera$Size
				/// </java-name>
				[Dot42.DexImport("android/hardware/Camera$Size", AccessFlags = 1)]
				public partial class Size
 /* scope: __dot42__ */ 
				{
						/// <summary>
						/// <para>width of the picture </para>        
						/// </summary>
						/// <java-name>
						/// width
						/// </java-name>
						[Dot42.DexImport("width", "I", AccessFlags = 1)]
						public int Width;
						/// <summary>
						/// <para>height of the picture </para>        
						/// </summary>
						/// <java-name>
						/// height
						/// </java-name>
						[Dot42.DexImport("height", "I", AccessFlags = 1)]
						public int Height;
						/// <java-name>
						/// this$0
						/// </java-name>
						[Dot42.DexImport("this$0", "Landroid/hardware/Camera;", AccessFlags = 4112)]
						internal readonly global::Android.Hardware.Camera This_0;
						[Dot42.DexImport("<init>", "(Landroid/hardware/Camera;II)V", AccessFlags = 1)]
						public Size(global::Android.Hardware.Camera camera, int int32, int int321) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						/// <para>Compares <c> obj </c> to this size.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para><c> true </c> if the width and height of <c> obj </c> is the same as those of this size. <c> false </c> otherwise. </para>
						/// </returns>
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
						internal Size() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

				}

				/// <summary>
				/// <para>Callback interface for camera error notification.</para><para><para>setErrorCallback(ErrorCallback) </para></para>    
				/// </summary>
				/// <java-name>
				/// android/hardware/Camera$ErrorCallback
				/// </java-name>
				[Dot42.DexImport("android/hardware/Camera$ErrorCallback", AccessFlags = 1545)]
				public partial interface IErrorCallback
 /* scope: __dot42__ */ 
				{
						/// <summary>
						/// <para>Callback for camera errors. </para>        
						/// </summary>
						/// <java-name>
						/// onError
						/// </java-name>
						[Dot42.DexImport("onError", "(ILandroid/hardware/Camera;)V", AccessFlags = 1025)]
						void OnError(int error, global::Android.Hardware.Camera camera) /* MethodBuilder.Create */ ;

				}

				/// <summary>
				/// <para>Information about a face identified through camera face detection.</para><para>When face detection is used with a camera, the FaceDetectionListener returns a list of face objects for use in focusing and metering.</para><para><para>FaceDetectionListener </para></para>    
				/// </summary>
				/// <java-name>
				/// android/hardware/Camera$Face
				/// </java-name>
				[Dot42.DexImport("android/hardware/Camera$Face", AccessFlags = 9)]
				public partial class Face
 /* scope: __dot42__ */ 
				{
						/// <summary>
						/// <para>Bounds of the face. (-1000, -1000) represents the top-left of the camera field of view, and (1000, 1000) represents the bottom-right of the field of view. For example, suppose the size of the viewfinder UI is 800x480. The rect passed from the driver is (-1000, -1000, 0, 0). The corresponding viewfinder rect should be (0, 0, 400, 240). It is guaranteed left &lt; right and top &lt; bottom. The coordinates can be smaller than -1000 or bigger than 1000. But at least one vertex will be within (-1000, -1000) and (1000, 1000).</para><para>The direction is relative to the sensor orientation, that is, what the sensor sees. The direction is not affected by the rotation or mirroring of setDisplayOrientation(int). The face bounding rectangle does not provide any information about face orientation.</para><para>Here is the matrix to convert driver coordinates to View coordinates in pixels.</para><para><pre>
						///            Matrix matrix = new Matrix();
						///            CameraInfo info = CameraHolder.instance().getCameraInfo()[cameraId];
						///            // Need mirror for front camera.
						///            boolean mirror = (info.facing == CameraInfo.CAMERA_FACING_FRONT);
						///            matrix.setScale(mirror ? -1 : 1, 1);
						///            // This is the value for android.hardware.Camera.setDisplayOrientation.
						///            matrix.postRotate(displayOrientation);
						///            // Camera driver coordinates range from (-1000, -1000) to (1000, 1000).
						///            // UI coordinates range from (0, 0) to (width, height).
						///            matrix.postScale(view.getWidth() / 2000f, view.getHeight() / 2000f);
						///            matrix.postTranslate(view.getWidth() / 2f, view.getHeight() / 2f);
						///            </pre></para><para><para>startFaceDetection() </para></para>        
						/// </summary>
						/// <java-name>
						/// rect
						/// </java-name>
						[Dot42.DexImport("rect", "Landroid/graphics/Rect;", AccessFlags = 1)]
						public global::Android.Graphics.Rect Rect;
						/// <summary>
						/// <para>The confidence level for the detection of the face. The range is 1 to<ol><li><para>100 is the highest confidence.</para></li></ol></para><para>Depending on the device, even very low-confidence faces may be listed, so applications should filter out faces with low confidence, depending on the use case. For a typical point-and-shoot camera application that wishes to display rectangles around detected faces, filtering out faces with confidence less than 50 is recommended.</para><para><para>startFaceDetection() </para></para>        
						/// </summary>
						/// <java-name>
						/// score
						/// </java-name>
						[Dot42.DexImport("score", "I", AccessFlags = 1)]
						public int Score;
						/// <summary>
						/// <para>An unique id per face while the face is visible to the tracker. If the face leaves the field-of-view and comes back, it will get a new id. This is an optional field, may not be supported on all devices. If not supported, id will always be set to -1. The optional fields are supported as a set. Either they are all valid, or none of them are. </para>        
						/// </summary>
						/// <java-name>
						/// id
						/// </java-name>
						[Dot42.DexImport("id", "I", AccessFlags = 1)]
						public int Id;
						/// <summary>
						/// <para>The coordinates of the center of the left eye. The coordinates are in the same space as the ones for rect. This is an optional field, may not be supported on all devices. If not supported, the value will always be set to null. The optional fields are supported as a set. Either they are all valid, or none of them are. </para>        
						/// </summary>
						/// <java-name>
						/// leftEye
						/// </java-name>
						[Dot42.DexImport("leftEye", "Landroid/graphics/Point;", AccessFlags = 1)]
						public global::Android.Graphics.Point LeftEye;
						/// <summary>
						/// <para>The coordinates of the center of the right eye. The coordinates are in the same space as the ones for rect.This is an optional field, may not be supported on all devices. If not supported, the value will always be set to null. The optional fields are supported as a set. Either they are all valid, or none of them are. </para>        
						/// </summary>
						/// <java-name>
						/// rightEye
						/// </java-name>
						[Dot42.DexImport("rightEye", "Landroid/graphics/Point;", AccessFlags = 1)]
						public global::Android.Graphics.Point RightEye;
						/// <summary>
						/// <para>The coordinates of the center of the mouth. The coordinates are in the same space as the ones for rect. This is an optional field, may not be supported on all devices. If not supported, the value will always be set to null. The optional fields are supported as a set. Either they are all valid, or none of them are. </para>        
						/// </summary>
						/// <java-name>
						/// mouth
						/// </java-name>
						[Dot42.DexImport("mouth", "Landroid/graphics/Point;", AccessFlags = 1)]
						public global::Android.Graphics.Point Mouth;
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public Face() /* MethodBuilder.Create */ 
						{
						}

				}

				/// <summary>
				/// <para>Callback interface for face detected in the preview frame. </para>    
				/// </summary>
				/// <java-name>
				/// android/hardware/Camera$FaceDetectionListener
				/// </java-name>
				[Dot42.DexImport("android/hardware/Camera$FaceDetectionListener", AccessFlags = 1545)]
				public partial interface IFaceDetectionListener
 /* scope: __dot42__ */ 
				{
						/// <summary>
						/// <para>Notify the listener of the detected faces in the preview frame.</para><para></para>        
						/// </summary>
						/// <java-name>
						/// onFaceDetection
						/// </java-name>
						[Dot42.DexImport("onFaceDetection", "([Landroid/hardware/Camera$Face;Landroid/hardware/Camera;)V", AccessFlags = 1025)]
						void OnFaceDetection(global::Android.Hardware.Camera.Face[] faces, global::Android.Hardware.Camera camera) /* MethodBuilder.Create */ ;

				}

				/// <summary>
				/// <para>Callback interface for zoom changes during a smooth zoom operation.</para><para><para>setZoomChangeListener(OnZoomChangeListener) </para><simplesectsep></simplesectsep><para>startSmoothZoom(int) </para></para>    
				/// </summary>
				/// <java-name>
				/// android/hardware/Camera$OnZoomChangeListener
				/// </java-name>
				[Dot42.DexImport("android/hardware/Camera$OnZoomChangeListener", AccessFlags = 1545)]
				public partial interface IOnZoomChangeListener
 /* scope: __dot42__ */ 
				{
						/// <summary>
						/// <para>Called when the zoom value has changed during a smooth zoom.</para><para></para>        
						/// </summary>
						/// <java-name>
						/// onZoomChange
						/// </java-name>
						[Dot42.DexImport("onZoomChange", "(IZLandroid/hardware/Camera;)V", AccessFlags = 1025)]
						void OnZoomChange(int zoomValue, bool stopped, global::Android.Hardware.Camera camera) /* MethodBuilder.Create */ ;

				}

				/// <summary>
				/// <para>Callback interface used to supply image data from a photo capture.</para><para><para>takePicture(ShutterCallback, PictureCallback, PictureCallback, PictureCallback) </para></para>    
				/// </summary>
				/// <java-name>
				/// android/hardware/Camera$PictureCallback
				/// </java-name>
				[Dot42.DexImport("android/hardware/Camera$PictureCallback", AccessFlags = 1545)]
				public partial interface IPictureCallback
 /* scope: __dot42__ */ 
				{
						/// <summary>
						/// <para>Called when image data is available after a picture is taken. The format of the data depends on the context of the callback and Camera.Parameters settings.</para><para></para>        
						/// </summary>
						/// <java-name>
						/// onPictureTaken
						/// </java-name>
						[Dot42.DexImport("onPictureTaken", "([BLandroid/hardware/Camera;)V", AccessFlags = 1025)]
						void OnPictureTaken(sbyte[] data, global::Android.Hardware.Camera camera) /* MethodBuilder.Create */ ;

				}

				/// <summary>
				/// <para>Callback interface used to signal the moment of actual image capture.</para><para><para>takePicture(ShutterCallback, PictureCallback, PictureCallback, PictureCallback) </para></para>    
				/// </summary>
				/// <java-name>
				/// android/hardware/Camera$ShutterCallback
				/// </java-name>
				[Dot42.DexImport("android/hardware/Camera$ShutterCallback", AccessFlags = 1545)]
				public partial interface IShutterCallback
 /* scope: __dot42__ */ 
				{
						/// <summary>
						/// <para>Called as near as possible to the moment when a photo is captured from the sensor. This is a good opportunity to play a shutter sound or give other feedback of camera operation. This may be some time after the photo was triggered, but some time before the actual data is available. </para>        
						/// </summary>
						/// <java-name>
						/// onShutter
						/// </java-name>
						[Dot42.DexImport("onShutter", "()V", AccessFlags = 1025)]
						void OnShutter() /* MethodBuilder.Create */ ;

				}

				/// <summary>
				/// <para>Callback interface used to notify on auto focus start and stop.</para><para>This is only supported in continuous autofocus modes  Parameters#FOCUS_MODE_CONTINUOUS_VIDEO and Parameters#FOCUS_MODE_CONTINUOUS_PICTURE. Applications can show autofocus animation based on this.</para>    
				/// </summary>
				/// <java-name>
				/// android/hardware/Camera$AutoFocusMoveCallback
				/// </java-name>
				[Dot42.DexImport("android/hardware/Camera$AutoFocusMoveCallback", AccessFlags = 1545)]
				public partial interface IAutoFocusMoveCallback
 /* scope: __dot42__ */ 
				{
						/// <summary>
						/// <para>Called when the camera auto focus starts or stops.</para><para></para>        
						/// </summary>
						/// <java-name>
						/// onAutoFocusMoving
						/// </java-name>
						[Dot42.DexImport("onAutoFocusMoving", "(ZLandroid/hardware/Camera;)V", AccessFlags = 1025)]
						void OnAutoFocusMoving(bool start, global::Android.Hardware.Camera camera) /* MethodBuilder.Create */ ;

				}

				/// <summary>
				/// <para>Callback interface used to notify on completion of camera auto focus.</para><para>Devices that do not support auto-focus will receive a "fake" callback to this interface. If your application needs auto-focus and should not be installed on devices <b>without</b> auto-focus, you must declare that your app uses the <c> android.hardware.camera.autofocus </c> feature, in the  manifest element.</para><para><para>autoFocus(AutoFocusCallback) </para></para>    
				/// </summary>
				/// <java-name>
				/// android/hardware/Camera$AutoFocusCallback
				/// </java-name>
				[Dot42.DexImport("android/hardware/Camera$AutoFocusCallback", AccessFlags = 1545)]
				public partial interface IAutoFocusCallback
 /* scope: __dot42__ */ 
				{
						/// <summary>
						/// <para>Called when the camera auto focus completes. If the camera does not support auto-focus and autoFocus is called, onAutoFocus will be called immediately with a fake value of <code>success</code> set to <code>true</code>.</para><para>The auto-focus routine does not lock auto-exposure and auto-white balance after it completes.</para><para><para>android.hardware.Camera.Parameters::setAutoExposureLock(boolean) </para><simplesectsep></simplesectsep><para>android.hardware.Camera.Parameters::setAutoWhiteBalanceLock(boolean) </para></para>        
						/// </summary>
						/// <java-name>
						/// onAutoFocus
						/// </java-name>
						[Dot42.DexImport("onAutoFocus", "(ZLandroid/hardware/Camera;)V", AccessFlags = 1025)]
						void OnAutoFocus(bool success, global::Android.Hardware.Camera camera) /* MethodBuilder.Create */ ;

				}

				/// <summary>
				/// <para>Callback interface used to deliver copies of preview frames as they are displayed.</para><para><para>setPreviewCallback(Camera.PreviewCallback) </para><simplesectsep></simplesectsep><para>setOneShotPreviewCallback(Camera.PreviewCallback) </para><simplesectsep></simplesectsep><para>setPreviewCallbackWithBuffer(Camera.PreviewCallback) </para><simplesectsep></simplesectsep><para>startPreview() </para></para>    
				/// </summary>
				/// <java-name>
				/// android/hardware/Camera$PreviewCallback
				/// </java-name>
				[Dot42.DexImport("android/hardware/Camera$PreviewCallback", AccessFlags = 1545)]
				public partial interface IPreviewCallback
 /* scope: __dot42__ */ 
				{
						/// <summary>
						/// <para>Called as preview frames are displayed. This callback is invoked on the event thread open(int) was called from.</para><para>If using the android.graphics.ImageFormat#YV12 format, refer to the equations in Camera.Parameters#setPreviewFormat for the arrangement of the pixel data in the preview callback buffers.</para><para></para>        
						/// </summary>
						/// <java-name>
						/// onPreviewFrame
						/// </java-name>
						[Dot42.DexImport("onPreviewFrame", "([BLandroid/hardware/Camera;)V", AccessFlags = 1025)]
						void OnPreviewFrame(sbyte[] data, global::Android.Hardware.Camera camera) /* MethodBuilder.Create */ ;

				}

				/// <summary>
				/// <para>Information about a camera </para>    
				/// </summary>
				/// <java-name>
				/// android/hardware/Camera$CameraInfo
				/// </java-name>
				[Dot42.DexImport("android/hardware/Camera$CameraInfo", AccessFlags = 9)]
				public partial class CameraInfo
 /* scope: __dot42__ */ 
				{
						/// <summary>
						/// <para>The facing of the camera is opposite to that of the screen. </para>        
						/// </summary>
						/// <java-name>
						/// CAMERA_FACING_BACK
						/// </java-name>
						[Dot42.DexImport("CAMERA_FACING_BACK", "I", AccessFlags = 25)]
						public const int CAMERA_FACING_BACK = 0;
						/// <summary>
						/// <para>The facing of the camera is the same as that of the screen. </para>        
						/// </summary>
						/// <java-name>
						/// CAMERA_FACING_FRONT
						/// </java-name>
						[Dot42.DexImport("CAMERA_FACING_FRONT", "I", AccessFlags = 25)]
						public const int CAMERA_FACING_FRONT = 1;
						/// <summary>
						/// <para>The direction that the camera faces. It should be CAMERA_FACING_BACK or CAMERA_FACING_FRONT. </para>        
						/// </summary>
						/// <java-name>
						/// facing
						/// </java-name>
						[Dot42.DexImport("facing", "I", AccessFlags = 1)]
						public int Facing;
						/// <summary>
						/// <para>The orientation of the camera image. The value is the angle that the camera image needs to be rotated clockwise so it shows correctly on the display in its natural orientation. It should be 0, 90, 180, or 270.</para><para>For example, suppose a device has a naturally tall screen. The back-facing camera sensor is mounted in landscape. You are looking at the screen. If the top side of the camera sensor is aligned with the right edge of the screen in natural orientation, the value should be<ol><li><para>If the top side of a front-facing camera sensor is aligned with the right of the screen, the value should be 270.</para></li></ol></para><para><para>setDisplayOrientation(int) </para><simplesectsep></simplesectsep><para>Parameters::setRotation(int) </para><simplesectsep></simplesectsep><para>Parameters::setPreviewSize(int, int) </para><simplesectsep></simplesectsep><para>Parameters::setPictureSize(int, int) </para><simplesectsep></simplesectsep><para>Parameters::setJpegThumbnailSize(int, int) </para></para>        
						/// </summary>
						/// <java-name>
						/// orientation
						/// </java-name>
						[Dot42.DexImport("orientation", "I", AccessFlags = 1)]
						public int Orientation;
						/// <summary>
						/// <para>Whether the shutter sound can be disabled.</para><para>On some devices, the camera shutter sound cannot be turned off through enableShutterSound. This field can be used to determine whether a call to disable the shutter sound will succeed.</para><para>If this field is set to true, then a call of <c> enableShutterSound(false) </c> will be successful. If set to false, then that call will fail, and the shutter sound will be played when takePicture is called.</para>        
						/// </summary>
						/// <java-name>
						/// canDisableShutterSound
						/// </java-name>
						[Dot42.DexImport("canDisableShutterSound", "Z", AccessFlags = 1)]
						public bool CanDisableShutterSound;
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public CameraInfo() /* MethodBuilder.Create */ 
						{
						}

				}

		}

		/// <summary>
		/// <para>SensorManager lets you access the device's sensors. Get an instance of this class by calling Context.getSystemService() with the argument android.content.Context#SENSOR_SERVICE. </para><para>Always make sure to disable sensors you don't need, especially when your activity is paused. Failing to do so can drain the battery in just a few hours. Note that the system will <b>not</b> disable sensors automatically when the screen turns off. </para><para>Note: Don't use this mechanism with a Trigger Sensor, have a look at TriggerEventListener. Sensor#TYPE_SIGNIFICANT_MOTION is an example of a trigger sensor. </para><para><pre>
		///    public class SensorActivity extends Activity, implements SensorEventListener {
		///        private final SensorManager mSensorManager;
		///        private final Sensor mAccelerometer;
		/// 
		///        public SensorActivity() {
		///            mSensorManager = (SensorManager)getSystemService(SENSOR_SERVICE);
		///            mAccelerometer = mSensorManager.getDefaultSensor(Sensor.TYPE_ACCELEROMETER);
		///        }
		/// 
		///        protected void onResume() {
		///            super.onResume();
		///            mSensorManager.registerListener(this, mAccelerometer, SensorManager.SENSOR_DELAY_NORMAL);
		///        }
		/// 
		///        protected void onPause() {
		///            super.onPause();
		///            mSensorManager.unregisterListener(this);
		///        }
		/// 
		///        public void onAccuracyChanged(Sensor sensor, int accuracy) {
		///        }
		/// 
		///        public void onSensorChanged(SensorEvent event) {
		///        }
		///    }
		///    </pre></para><para><para>SensorEventListener </para><simplesectsep></simplesectsep><para>SensorEvent </para><simplesectsep></simplesectsep><para>Sensor </para></para>    
		/// </summary>
		/// <java-name>
		/// android/hardware/SensorManager
		/// </java-name>
		[Dot42.DexImport("android/hardware/SensorManager", AccessFlags = 1057)]
		public abstract partial class SensorManager
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>A constant describing an orientation sensor. See SensorListener for more details.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>use Sensor instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// SENSOR_ORIENTATION
				/// </java-name>
				[Dot42.DexImport("SENSOR_ORIENTATION", "I", AccessFlags = 25)]
				public const int SENSOR_ORIENTATION = 1;
				/// <summary>
				/// <para>A constant describing an accelerometer. See SensorListener for more details.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>use Sensor instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// SENSOR_ACCELEROMETER
				/// </java-name>
				[Dot42.DexImport("SENSOR_ACCELEROMETER", "I", AccessFlags = 25)]
				public const int SENSOR_ACCELEROMETER = 2;
				/// <summary>
				/// <para>A constant describing a temperature sensor See SensorListener for more details.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>use Sensor instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// SENSOR_TEMPERATURE
				/// </java-name>
				[Dot42.DexImport("SENSOR_TEMPERATURE", "I", AccessFlags = 25)]
				public const int SENSOR_TEMPERATURE = 4;
				/// <summary>
				/// <para>A constant describing a magnetic sensor See SensorListener for more details.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>use Sensor instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// SENSOR_MAGNETIC_FIELD
				/// </java-name>
				[Dot42.DexImport("SENSOR_MAGNETIC_FIELD", "I", AccessFlags = 25)]
				public const int SENSOR_MAGNETIC_FIELD = 8;
				/// <summary>
				/// <para>A constant describing an ambient light sensor See SensorListener for more details.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>use Sensor instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// SENSOR_LIGHT
				/// </java-name>
				[Dot42.DexImport("SENSOR_LIGHT", "I", AccessFlags = 25)]
				public const int SENSOR_LIGHT = 16;
				/// <summary>
				/// <para>A constant describing a proximity sensor See SensorListener for more details.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>use Sensor instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// SENSOR_PROXIMITY
				/// </java-name>
				[Dot42.DexImport("SENSOR_PROXIMITY", "I", AccessFlags = 25)]
				public const int SENSOR_PROXIMITY = 32;
				/// <summary>
				/// <para>A constant describing a Tricorder See SensorListener for more details.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>use Sensor instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// SENSOR_TRICORDER
				/// </java-name>
				[Dot42.DexImport("SENSOR_TRICORDER", "I", AccessFlags = 25)]
				public const int SENSOR_TRICORDER = 64;
				/// <summary>
				/// <para>A constant describing an orientation sensor. See SensorListener for more details.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>use Sensor instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// SENSOR_ORIENTATION_RAW
				/// </java-name>
				[Dot42.DexImport("SENSOR_ORIENTATION_RAW", "I", AccessFlags = 25)]
				public const int SENSOR_ORIENTATION_RAW = 128;
				/// <summary>
				/// <para>A constant that includes all sensors</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>use Sensor instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// SENSOR_ALL
				/// </java-name>
				[Dot42.DexImport("SENSOR_ALL", "I", AccessFlags = 25)]
				public const int SENSOR_ALL = 127;
				/// <summary>
				/// <para>Smallest sensor ID</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>use Sensor instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// SENSOR_MIN
				/// </java-name>
				[Dot42.DexImport("SENSOR_MIN", "I", AccessFlags = 25)]
				public const int SENSOR_MIN = 1;
				/// <summary>
				/// <para>Largest sensor ID</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>use Sensor instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// SENSOR_MAX
				/// </java-name>
				[Dot42.DexImport("SENSOR_MAX", "I", AccessFlags = 25)]
				public const int SENSOR_MAX = 64;
				/// <summary>
				/// <para>Index of the X value in the array returned by android.hardware.SensorListener#onSensorChanged</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>use Sensor instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// DATA_X
				/// </java-name>
				[Dot42.DexImport("DATA_X", "I", AccessFlags = 25)]
				public const int DATA_X = 0;
				/// <summary>
				/// <para>Index of the Y value in the array returned by android.hardware.SensorListener#onSensorChanged</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>use Sensor instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// DATA_Y
				/// </java-name>
				[Dot42.DexImport("DATA_Y", "I", AccessFlags = 25)]
				public const int DATA_Y = 1;
				/// <summary>
				/// <para>Index of the Z value in the array returned by android.hardware.SensorListener#onSensorChanged</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>use Sensor instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// DATA_Z
				/// </java-name>
				[Dot42.DexImport("DATA_Z", "I", AccessFlags = 25)]
				public const int DATA_Z = 2;
				/// <summary>
				/// <para>Offset to the untransformed values in the array returned by android.hardware.SensorListener#onSensorChanged</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>use Sensor instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// RAW_DATA_INDEX
				/// </java-name>
				[Dot42.DexImport("RAW_DATA_INDEX", "I", AccessFlags = 25)]
				public const int RAW_DATA_INDEX = 3;
				/// <summary>
				/// <para>Index of the untransformed X value in the array returned by android.hardware.SensorListener#onSensorChanged</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>use Sensor instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// RAW_DATA_X
				/// </java-name>
				[Dot42.DexImport("RAW_DATA_X", "I", AccessFlags = 25)]
				public const int RAW_DATA_X = 3;
				/// <summary>
				/// <para>Index of the untransformed Y value in the array returned by android.hardware.SensorListener#onSensorChanged</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>use Sensor instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// RAW_DATA_Y
				/// </java-name>
				[Dot42.DexImport("RAW_DATA_Y", "I", AccessFlags = 25)]
				public const int RAW_DATA_Y = 4;
				/// <summary>
				/// <para>Index of the untransformed Z value in the array returned by android.hardware.SensorListener#onSensorChanged</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>use Sensor instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// RAW_DATA_Z
				/// </java-name>
				[Dot42.DexImport("RAW_DATA_Z", "I", AccessFlags = 25)]
				public const int RAW_DATA_Z = 5;
				/// <summary>
				/// <para>Standard gravity (g) on Earth. This value is equivalent to 1G </para>        
				/// </summary>
				/// <java-name>
				/// STANDARD_GRAVITY
				/// </java-name>
				[Dot42.DexImport("STANDARD_GRAVITY", "F", AccessFlags = 25)]
				public const float STANDARD_GRAVITY = 9.80665F;
				/// <summary>
				/// <para>Sun's gravity in SI units (m/s^2) </para>        
				/// </summary>
				/// <java-name>
				/// GRAVITY_SUN
				/// </java-name>
				[Dot42.DexImport("GRAVITY_SUN", "F", AccessFlags = 25)]
				public const float GRAVITY_SUN = 275F;
				/// <summary>
				/// <para>Mercury's gravity in SI units (m/s^2) </para>        
				/// </summary>
				/// <java-name>
				/// GRAVITY_MERCURY
				/// </java-name>
				[Dot42.DexImport("GRAVITY_MERCURY", "F", AccessFlags = 25)]
				public const float GRAVITY_MERCURY = 3.7F;
				/// <summary>
				/// <para>Venus' gravity in SI units (m/s^2) </para>        
				/// </summary>
				/// <java-name>
				/// GRAVITY_VENUS
				/// </java-name>
				[Dot42.DexImport("GRAVITY_VENUS", "F", AccessFlags = 25)]
				public const float GRAVITY_VENUS = 8.87F;
				/// <summary>
				/// <para>Earth's gravity in SI units (m/s^2) </para>        
				/// </summary>
				/// <java-name>
				/// GRAVITY_EARTH
				/// </java-name>
				[Dot42.DexImport("GRAVITY_EARTH", "F", AccessFlags = 25)]
				public const float GRAVITY_EARTH = 9.80665F;
				/// <summary>
				/// <para>The Moon's gravity in SI units (m/s^2) </para>        
				/// </summary>
				/// <java-name>
				/// GRAVITY_MOON
				/// </java-name>
				[Dot42.DexImport("GRAVITY_MOON", "F", AccessFlags = 25)]
				public const float GRAVITY_MOON = 1.6F;
				/// <summary>
				/// <para>Mars' gravity in SI units (m/s^2) </para>        
				/// </summary>
				/// <java-name>
				/// GRAVITY_MARS
				/// </java-name>
				[Dot42.DexImport("GRAVITY_MARS", "F", AccessFlags = 25)]
				public const float GRAVITY_MARS = 3.71F;
				/// <summary>
				/// <para>Jupiter's gravity in SI units (m/s^2) </para>        
				/// </summary>
				/// <java-name>
				/// GRAVITY_JUPITER
				/// </java-name>
				[Dot42.DexImport("GRAVITY_JUPITER", "F", AccessFlags = 25)]
				public const float GRAVITY_JUPITER = 23.12F;
				/// <summary>
				/// <para>Saturn's gravity in SI units (m/s^2) </para>        
				/// </summary>
				/// <java-name>
				/// GRAVITY_SATURN
				/// </java-name>
				[Dot42.DexImport("GRAVITY_SATURN", "F", AccessFlags = 25)]
				public const float GRAVITY_SATURN = 8.96F;
				/// <summary>
				/// <para>Uranus' gravity in SI units (m/s^2) </para>        
				/// </summary>
				/// <java-name>
				/// GRAVITY_URANUS
				/// </java-name>
				[Dot42.DexImport("GRAVITY_URANUS", "F", AccessFlags = 25)]
				public const float GRAVITY_URANUS = 8.69F;
				/// <summary>
				/// <para>Neptune's gravity in SI units (m/s^2) </para>        
				/// </summary>
				/// <java-name>
				/// GRAVITY_NEPTUNE
				/// </java-name>
				[Dot42.DexImport("GRAVITY_NEPTUNE", "F", AccessFlags = 25)]
				public const float GRAVITY_NEPTUNE = 11F;
				/// <summary>
				/// <para>Pluto's gravity in SI units (m/s^2) </para>        
				/// </summary>
				/// <java-name>
				/// GRAVITY_PLUTO
				/// </java-name>
				[Dot42.DexImport("GRAVITY_PLUTO", "F", AccessFlags = 25)]
				public const float GRAVITY_PLUTO = 0.6F;
				/// <summary>
				/// <para>Gravity (estimate) on the first Death Star in Empire units (m/s^2) </para>        
				/// </summary>
				/// <java-name>
				/// GRAVITY_DEATH_STAR_I
				/// </java-name>
				[Dot42.DexImport("GRAVITY_DEATH_STAR_I", "F", AccessFlags = 25)]
				public const float GRAVITY_DEATH_STAR_I = 3.530361E-07F;
				/// <summary>
				/// <para>Gravity on the island </para>        
				/// </summary>
				/// <java-name>
				/// GRAVITY_THE_ISLAND
				/// </java-name>
				[Dot42.DexImport("GRAVITY_THE_ISLAND", "F", AccessFlags = 25)]
				public const float GRAVITY_THE_ISLAND = 4.815162F;
				/// <summary>
				/// <para>Maximum magnetic field on Earth's surface </para>        
				/// </summary>
				/// <java-name>
				/// MAGNETIC_FIELD_EARTH_MAX
				/// </java-name>
				[Dot42.DexImport("MAGNETIC_FIELD_EARTH_MAX", "F", AccessFlags = 25)]
				public const float MAGNETIC_FIELD_EARTH_MAX = 60F;
				/// <summary>
				/// <para>Minimum magnetic field on Earth's surface </para>        
				/// </summary>
				/// <java-name>
				/// MAGNETIC_FIELD_EARTH_MIN
				/// </java-name>
				[Dot42.DexImport("MAGNETIC_FIELD_EARTH_MIN", "F", AccessFlags = 25)]
				public const float MAGNETIC_FIELD_EARTH_MIN = 30F;
				/// <summary>
				/// <para>Standard atmosphere, or average sea-level pressure in hPa (millibar) </para>        
				/// </summary>
				/// <java-name>
				/// PRESSURE_STANDARD_ATMOSPHERE
				/// </java-name>
				[Dot42.DexImport("PRESSURE_STANDARD_ATMOSPHERE", "F", AccessFlags = 25)]
				public const float PRESSURE_STANDARD_ATMOSPHERE = 1013.25F;
				/// <summary>
				/// <para>Maximum luminance of sunlight in lux </para>        
				/// </summary>
				/// <java-name>
				/// LIGHT_SUNLIGHT_MAX
				/// </java-name>
				[Dot42.DexImport("LIGHT_SUNLIGHT_MAX", "F", AccessFlags = 25)]
				public const float LIGHT_SUNLIGHT_MAX = 120000F;
				/// <summary>
				/// <para>luminance of sunlight in lux </para>        
				/// </summary>
				/// <java-name>
				/// LIGHT_SUNLIGHT
				/// </java-name>
				[Dot42.DexImport("LIGHT_SUNLIGHT", "F", AccessFlags = 25)]
				public const float LIGHT_SUNLIGHT = 110000F;
				/// <summary>
				/// <para>luminance in shade in lux </para>        
				/// </summary>
				/// <java-name>
				/// LIGHT_SHADE
				/// </java-name>
				[Dot42.DexImport("LIGHT_SHADE", "F", AccessFlags = 25)]
				public const float LIGHT_SHADE = 20000F;
				/// <summary>
				/// <para>luminance under an overcast sky in lux </para>        
				/// </summary>
				/// <java-name>
				/// LIGHT_OVERCAST
				/// </java-name>
				[Dot42.DexImport("LIGHT_OVERCAST", "F", AccessFlags = 25)]
				public const float LIGHT_OVERCAST = 10000F;
				/// <summary>
				/// <para>luminance at sunrise in lux </para>        
				/// </summary>
				/// <java-name>
				/// LIGHT_SUNRISE
				/// </java-name>
				[Dot42.DexImport("LIGHT_SUNRISE", "F", AccessFlags = 25)]
				public const float LIGHT_SUNRISE = 400F;
				/// <summary>
				/// <para>luminance under a cloudy sky in lux </para>        
				/// </summary>
				/// <java-name>
				/// LIGHT_CLOUDY
				/// </java-name>
				[Dot42.DexImport("LIGHT_CLOUDY", "F", AccessFlags = 25)]
				public const float LIGHT_CLOUDY = 100F;
				/// <summary>
				/// <para>luminance at night with full moon in lux </para>        
				/// </summary>
				/// <java-name>
				/// LIGHT_FULLMOON
				/// </java-name>
				[Dot42.DexImport("LIGHT_FULLMOON", "F", AccessFlags = 25)]
				public const float LIGHT_FULLMOON = 0.25F;
				/// <summary>
				/// <para>luminance at night with no moon in lux </para>        
				/// </summary>
				/// <java-name>
				/// LIGHT_NO_MOON
				/// </java-name>
				[Dot42.DexImport("LIGHT_NO_MOON", "F", AccessFlags = 25)]
				public const float LIGHT_NO_MOON = 0.001F;
				/// <summary>
				/// <para>get sensor data as fast as possible </para>        
				/// </summary>
				/// <java-name>
				/// SENSOR_DELAY_FASTEST
				/// </java-name>
				[Dot42.DexImport("SENSOR_DELAY_FASTEST", "I", AccessFlags = 25)]
				public const int SENSOR_DELAY_FASTEST = 0;
				/// <summary>
				/// <para>rate suitable for games </para>        
				/// </summary>
				/// <java-name>
				/// SENSOR_DELAY_GAME
				/// </java-name>
				[Dot42.DexImport("SENSOR_DELAY_GAME", "I", AccessFlags = 25)]
				public const int SENSOR_DELAY_GAME = 1;
				/// <summary>
				/// <para>rate suitable for the user interface </para>        
				/// </summary>
				/// <java-name>
				/// SENSOR_DELAY_UI
				/// </java-name>
				[Dot42.DexImport("SENSOR_DELAY_UI", "I", AccessFlags = 25)]
				public const int SENSOR_DELAY_UI = 2;
				/// <summary>
				/// <para>rate (default) suitable for screen orientation changes </para>        
				/// </summary>
				/// <java-name>
				/// SENSOR_DELAY_NORMAL
				/// </java-name>
				[Dot42.DexImport("SENSOR_DELAY_NORMAL", "I", AccessFlags = 25)]
				public const int SENSOR_DELAY_NORMAL = 3;
				/// <summary>
				/// <para>The values returned by this sensor cannot be trusted, calibration is needed or the environment doesn't allow readings </para>        
				/// </summary>
				/// <java-name>
				/// SENSOR_STATUS_UNRELIABLE
				/// </java-name>
				[Dot42.DexImport("SENSOR_STATUS_UNRELIABLE", "I", AccessFlags = 25)]
				public const int SENSOR_STATUS_UNRELIABLE = 0;
				/// <summary>
				/// <para>This sensor is reporting data with low accuracy, calibration with the environment is needed </para>        
				/// </summary>
				/// <java-name>
				/// SENSOR_STATUS_ACCURACY_LOW
				/// </java-name>
				[Dot42.DexImport("SENSOR_STATUS_ACCURACY_LOW", "I", AccessFlags = 25)]
				public const int SENSOR_STATUS_ACCURACY_LOW = 1;
				/// <summary>
				/// <para>This sensor is reporting data with an average level of accuracy, calibration with the environment may improve the readings </para>        
				/// </summary>
				/// <java-name>
				/// SENSOR_STATUS_ACCURACY_MEDIUM
				/// </java-name>
				[Dot42.DexImport("SENSOR_STATUS_ACCURACY_MEDIUM", "I", AccessFlags = 25)]
				public const int SENSOR_STATUS_ACCURACY_MEDIUM = 2;
				/// <summary>
				/// <para>This sensor is reporting data with maximum accuracy </para>        
				/// </summary>
				/// <java-name>
				/// SENSOR_STATUS_ACCURACY_HIGH
				/// </java-name>
				[Dot42.DexImport("SENSOR_STATUS_ACCURACY_HIGH", "I", AccessFlags = 25)]
				public const int SENSOR_STATUS_ACCURACY_HIGH = 3;
				/// <summary>
				/// <para>see remapCoordinateSystem </para>        
				/// </summary>
				/// <java-name>
				/// AXIS_X
				/// </java-name>
				[Dot42.DexImport("AXIS_X", "I", AccessFlags = 25)]
				public const int AXIS_X = 1;
				/// <summary>
				/// <para>see remapCoordinateSystem </para>        
				/// </summary>
				/// <java-name>
				/// AXIS_Y
				/// </java-name>
				[Dot42.DexImport("AXIS_Y", "I", AccessFlags = 25)]
				public const int AXIS_Y = 2;
				/// <summary>
				/// <para>see remapCoordinateSystem </para>        
				/// </summary>
				/// <java-name>
				/// AXIS_Z
				/// </java-name>
				[Dot42.DexImport("AXIS_Z", "I", AccessFlags = 25)]
				public const int AXIS_Z = 3;
				/// <summary>
				/// <para>see remapCoordinateSystem </para>        
				/// </summary>
				/// <java-name>
				/// AXIS_MINUS_X
				/// </java-name>
				[Dot42.DexImport("AXIS_MINUS_X", "I", AccessFlags = 25)]
				public const int AXIS_MINUS_X = 129;
				/// <summary>
				/// <para>see remapCoordinateSystem </para>        
				/// </summary>
				/// <java-name>
				/// AXIS_MINUS_Y
				/// </java-name>
				[Dot42.DexImport("AXIS_MINUS_Y", "I", AccessFlags = 25)]
				public const int AXIS_MINUS_Y = 130;
				/// <summary>
				/// <para>see remapCoordinateSystem </para>        
				/// </summary>
				/// <java-name>
				/// AXIS_MINUS_Z
				/// </java-name>
				[Dot42.DexImport("AXIS_MINUS_Z", "I", AccessFlags = 25)]
				public const int AXIS_MINUS_Z = 131;
				/// <summary>
				/// <para>{} </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal SensorManager() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>This method is deprecated, use SensorManager#getSensorList(int) instead </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				/// <para>available sensors. </para>
				/// </returns>
				/// <java-name>
				/// getSensors
				/// </java-name>
				[Dot42.DexImport("getSensors", "()I", AccessFlags = 1)]
				public virtual int GetSensors() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Use this method to get the list of available sensors of a certain type. Make multiple calls to get sensors of different types or use Sensor.TYPE_ALL to get all the sensors.</para><para><para>getDefaultSensor(int) </para><simplesectsep></simplesectsep><para>Sensor </para></para>        
				/// </summary>
				/// <returns>
				/// <para>a list of sensors matching the asked type.</para>
				/// </returns>
				/// <java-name>
				/// getSensorList
				/// </java-name>
				[Dot42.DexImport("getSensorList", "(I)Ljava/util/List;", AccessFlags = 1, Signature = "(I)Ljava/util/List<Landroid/hardware/Sensor;>;")]
				public virtual global::Java.Util.IList<global::Android.Hardware.Sensor> GetSensorList(int type) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<global::Android.Hardware.Sensor>);
				}

				/// <summary>
				/// <para>Use this method to get the default sensor for a given type. Note that the returned sensor could be a composite sensor, and its data could be averaged or filtered. If you need to access the raw sensors use getSensorList.</para><para><para>getSensorList(int) </para><simplesectsep></simplesectsep><para>Sensor </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the default sensors matching the asked type.</para>
				/// </returns>
				/// <java-name>
				/// getDefaultSensor
				/// </java-name>
				[Dot42.DexImport("getDefaultSensor", "(I)Landroid/hardware/Sensor;", AccessFlags = 1)]
				public virtual global::Android.Hardware.Sensor GetDefaultSensor(int type) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Hardware.Sensor);
				}

				/// <summary>
				/// <para>Registers a listener for given sensors.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>This method is deprecated, use SensorManager#registerListener(SensorEventListener, Sensor, int) instead.</para></xrefdescription></xrefsect></para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> if the sensor is supported and successfully enabled </para>
				/// </returns>
				/// <java-name>
				/// registerListener
				/// </java-name>
				[Dot42.DexImport("registerListener", "(Landroid/hardware/SensorListener;I)Z", AccessFlags = 1)]
				public virtual bool RegisterListener(global::Android.Hardware.ISensorListener listener, int sensors) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Registers a SensorListener for given sensors.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>This method is deprecated, use SensorManager#registerListener(SensorEventListener, Sensor, int) instead.</para></xrefdescription></xrefsect></para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> if the sensor is supported and successfully enabled </para>
				/// </returns>
				/// <java-name>
				/// registerListener
				/// </java-name>
				[Dot42.DexImport("registerListener", "(Landroid/hardware/SensorListener;II)Z", AccessFlags = 1)]
				public virtual bool RegisterListener(global::Android.Hardware.ISensorListener listener, int sensors, int rate) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Unregisters a listener for all sensors.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>This method is deprecated, use SensorManager#unregisterListener(SensorEventListener) instead.</para></xrefdescription></xrefsect></para><para></para>        
				/// </summary>
				/// <java-name>
				/// unregisterListener
				/// </java-name>
				[Dot42.DexImport("unregisterListener", "(Landroid/hardware/SensorListener;)V", AccessFlags = 1)]
				public virtual void UnregisterListener(global::Android.Hardware.ISensorListener listener) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Unregisters a listener for the sensors with which it is registered.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>This method is deprecated, use SensorManager#unregisterListener(SensorEventListener, Sensor) instead.</para></xrefdescription></xrefsect></para><para></para>        
				/// </summary>
				/// <java-name>
				/// unregisterListener
				/// </java-name>
				[Dot42.DexImport("unregisterListener", "(Landroid/hardware/SensorListener;I)V", AccessFlags = 1)]
				public virtual void UnregisterListener(global::Android.Hardware.ISensorListener listener, int sensors) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Unregisters a listener for the sensors with which it is registered.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>This method is deprecated, use SensorManager#unregisterListener(SensorEventListener, Sensor) instead.</para></xrefdescription></xrefsect></para><para></para>        
				/// </summary>
				/// <java-name>
				/// unregisterListener
				/// </java-name>
				[Dot42.DexImport("unregisterListener", "(Landroid/hardware/SensorEventListener;Landroid/hardware/Sensor;)V", AccessFlags = 1)]
				public virtual void UnregisterListener(global::Android.Hardware.ISensorEventListener listener, global::Android.Hardware.Sensor sensors) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Unregisters a listener for all sensors.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>This method is deprecated, use SensorManager#unregisterListener(SensorEventListener) instead.</para></xrefdescription></xrefsect></para><para></para>        
				/// </summary>
				/// <java-name>
				/// unregisterListener
				/// </java-name>
				[Dot42.DexImport("unregisterListener", "(Landroid/hardware/SensorEventListener;)V", AccessFlags = 1)]
				public virtual void UnregisterListener(global::Android.Hardware.ISensorEventListener listener) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Registers a SensorListener for given sensors.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>This method is deprecated, use SensorManager#registerListener(SensorEventListener, Sensor, int) instead.</para></xrefdescription></xrefsect></para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> if the sensor is supported and successfully enabled </para>
				/// </returns>
				/// <java-name>
				/// registerListener
				/// </java-name>
				[Dot42.DexImport("registerListener", "(Landroid/hardware/SensorEventListener;Landroid/hardware/Sensor;I)Z", AccessFlags = 1)]
				public virtual bool RegisterListener(global::Android.Hardware.ISensorEventListener listener, global::Android.Hardware.Sensor sensors, int rate) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Registers a SensorEventListener for the given sensor.</para><para>Note: Don't use this method with a one shot trigger sensor such as Sensor#TYPE_SIGNIFICANT_MOTION. Use requestTriggerSensor(TriggerEventListener, Sensor) instead. </para><para><para>registerListener(SensorEventListener, Sensor, int) </para><simplesectsep></simplesectsep><para>unregisterListener(SensorEventListener) </para><simplesectsep></simplesectsep><para>unregisterListener(SensorEventListener, Sensor)</para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if the sensor is supported and successfully enabled.</para>
				/// </returns>
				/// <java-name>
				/// registerListener
				/// </java-name>
				[Dot42.DexImport("registerListener", "(Landroid/hardware/SensorEventListener;Landroid/hardware/Sensor;II)Z", AccessFlags = 1)]
				public virtual bool RegisterListener(global::Android.Hardware.ISensorEventListener listener, global::Android.Hardware.Sensor sensor, int rate, int handler) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Registers a SensorEventListener for the given sensor.</para><para>Note: Don't use this method with a one shot trigger sensor such as Sensor#TYPE_SIGNIFICANT_MOTION. Use requestTriggerSensor(TriggerEventListener, Sensor) instead. </para><para><para>registerListener(SensorEventListener, Sensor, int) </para><simplesectsep></simplesectsep><para>unregisterListener(SensorEventListener) </para><simplesectsep></simplesectsep><para>unregisterListener(SensorEventListener, Sensor)</para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if the sensor is supported and successfully enabled.</para>
				/// </returns>
				/// <java-name>
				/// registerListener
				/// </java-name>
				[Dot42.DexImport("registerListener", "(Landroid/hardware/SensorEventListener;Landroid/hardware/Sensor;ILandroid/os/Hand" +
    "ler;)Z", AccessFlags = 1)]
				public virtual bool RegisterListener(global::Android.Hardware.ISensorEventListener listener, global::Android.Hardware.Sensor sensor, int rate, global::Android.Os.Handler handler) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// registerListener
				/// </java-name>
				[Dot42.DexImport("registerListener", "(Landroid/hardware/SensorEventListener;Landroid/hardware/Sensor;IILandroid/os/Han" +
    "dler;)Z", AccessFlags = 1)]
				public virtual bool RegisterListener(global::Android.Hardware.ISensorEventListener sensorEventListener, global::Android.Hardware.Sensor sensor, int int32, int int321, global::Android.Os.Handler handler) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// flush
				/// </java-name>
				[Dot42.DexImport("flush", "(Landroid/hardware/SensorEventListener;)Z", AccessFlags = 1)]
				public virtual bool Flush(global::Android.Hardware.ISensorEventListener sensorEventListener) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Computes the inclination matrix <b>I</b> as well as the rotation matrix <b>R</b> transforming a vector from the device coordinate system to the world's coordinate system which is defined as a direct orthonormal basis, where: </para><para><ul><li><para>X is defined as the vector product <b>Y.Z</b> (It is tangential to the ground at the device's current location and roughly points East). </para></li><li><para>Y is tangential to the ground at the device's current location and points towards the magnetic North Pole. </para></li><li><para>Z points towards the sky and is perpendicular to the ground. </para></li></ul></para><para><center><image></image></center> </para><para><hruler></hruler> </para><para>By definition: </para><para>[0 0 g] = <b>R</b> * <b>gravity</b> (g = magnitude of gravity) </para><para>[0 m 0] = <b>I</b> * <b>R</b> * <b>geomagnetic</b> (m = magnitude of geomagnetic field) </para><para><b>R</b> is the identity matrix when the device is aligned with the world's coordinate system, that is, when the device's X axis points toward East, the Y axis points to the North Pole and the device is facing the sky.</para><para><b>I</b> is a rotation matrix transforming the geomagnetic vector into the same coordinate space as gravity (the world's coordinate space). <b>I</b> is a simple rotation around the X axis. The inclination angle in radians can be computed with getInclination. <hruler></hruler></para><para>Each matrix is returned either as a 3x3 or 4x4 row-major matrix depending on the length of the passed array: </para><para>&lt;u&gt;If the array length is 16:&lt;/u&gt;</para><para><pre>
				///          /  M[ 0]   M[ 1]   M[ 2]   M[ 3]  \
				///          |  M[ 4]   M[ 5]   M[ 6]   M[ 7]  |
				///          |  M[ 8]   M[ 9]   M[10]   M[11]  |
				///          \  M[12]   M[13]   M[14]   M[15]  /
				///       </pre></para><para>This matrix is ready to be used by OpenGL ES's glLoadMatrixf(float[], int). </para><para>Note that because OpenGL matrices are column-major matrices you must transpose the matrix before using it. However, since the matrix is a rotation matrix, its transpose is also its inverse, conveniently, it is often the inverse of the rotation that is needed for rendering; it can therefore be used with OpenGL ES directly. </para><para>Also note that the returned matrices always have this form:</para><para><pre>
				///          /  M[ 0]   M[ 1]   M[ 2]   0  \
				///          |  M[ 4]   M[ 5]   M[ 6]   0  |
				///          |  M[ 8]   M[ 9]   M[10]   0  |
				///          \      0       0       0   1  /
				///       </pre></para><para>&lt;u&gt;If the array length is 9:&lt;/u&gt;</para><para><pre>
				///          /  M[ 0]   M[ 1]   M[ 2]  \
				///          |  M[ 3]   M[ 4]   M[ 5]  |
				///          \  M[ 6]   M[ 7]   M[ 8]  /
				///       </pre></para><para><hruler></hruler> </para><para>The inverse of each matrix can be computed easily by taking its transpose.</para><para>The matrices returned by this function are meaningful only when the device is not free-falling and it is not close to the magnetic north. If the device is accelerating, or placed into a strong magnetic field, the returned matrices may be inaccurate.</para><para></para><para></para><para></para><para><para>getInclination(float[]) </para><simplesectsep></simplesectsep><para>getOrientation(float[], float[]) </para><simplesectsep></simplesectsep><para>remapCoordinateSystem(float[], int, int, float[]) </para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> on success, <code>false</code> on failure (for instance, if the device is in free fall). On failure the output matrices are not modified.</para>
				/// </returns>
				/// <java-name>
				/// getRotationMatrix
				/// </java-name>
				[Dot42.DexImport("getRotationMatrix", "([F[F[F[F)Z", AccessFlags = 9)]
				public static bool GetRotationMatrix(float[] R, float[] I, float[] gravity, float[] geomagnetic) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Computes the geomagnetic inclination angle in radians from the inclination matrix <b>I</b> returned by getRotationMatrix.</para><para><para>getRotationMatrix(float[], float[], float[], float[]) </para><simplesectsep></simplesectsep><para>getOrientation(float[], float[]) </para><simplesectsep></simplesectsep><para>GeomagneticField </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The geomagnetic inclination angle in radians.</para>
				/// </returns>
				/// <java-name>
				/// getInclination
				/// </java-name>
				[Dot42.DexImport("getInclination", "([F)F", AccessFlags = 9)]
				public static float GetInclination(float[] I) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				/// <para>Rotates the supplied rotation matrix so it is expressed in a different coordinate system. This is typically used when an application needs to compute the three orientation angles of the device (see getOrientation) in a different coordinate system. </para><para>When the rotation matrix is used for drawing (for instance with OpenGL ES), it usually <b>doesn't need</b> to be transformed by this function, unless the screen is physically rotated, in which case you can use Display.getRotation() to retrieve the current rotation of the screen. Note that because the user is generally free to rotate their screen, you often should consider the rotation in deciding the parameters to use here. </para><para>&lt;u&gt;Examples:&lt;/u&gt; </para><para><ul><li><para>Using the camera (Y axis along the camera's axis) for an augmented reality application where the rotation angles are needed:</para><para></para><para><ul><li></li></ul><code>remapCoordinateSystem(inR, AXIS_X, AXIS_Z, outR);</code> </para></li></ul></para><para>Using the device as a mechanical compass when rotation is Surface.ROTATION_90:</para><para><ul><li></li></ul><code>remapCoordinateSystem(inR, AXIS_Y, AXIS_MINUS_X, outR);</code>  </para><para>Beware of the above example. This call is needed only to account for a rotation from its natural orientation when calculating the rotation angles (see getOrientation). If the rotation matrix is also used for rendering, it may not need to be transformed, for instance if your Activity is running in landscape mode. </para><para>Since the resulting coordinate system is orthonormal, only two axes need to be specified.</para><para><para>getRotationMatrix(float[], float[], float[], float[]) </para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> on success. <code>false</code> if the input parameters are incorrect, for instance if X and Y define the same axis. Or if inR and outR don't have the same length.</para>
				/// </returns>
				/// <java-name>
				/// remapCoordinateSystem
				/// </java-name>
				[Dot42.DexImport("remapCoordinateSystem", "([FII[F)Z", AccessFlags = 9)]
				public static bool RemapCoordinateSystem(float[] inR, int X, int Y, float[] outR) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Computes the device's orientation based on the rotation matrix. </para><para>When it returns, the array values is filled with the result: <ul><li><para>values[0]: <b>azimuth</b>, rotation around the Z axis. </para></li><li><para>values[1]: <b>pitch</b>, rotation around the X axis. </para></li><li><para>values[2]: <b>roll</b>, rotation around the Y axis. </para></li></ul></para><para>The reference coordinate-system used is different from the world coordinate-system defined for the rotation matrix:</para><para><ul><li><para>X is defined as the vector product <b>Y.Z</b> (It is tangential to the ground at the device's current location and roughly points West). </para></li><li><para>Y is tangential to the ground at the device's current location and points towards the magnetic North Pole. </para></li><li><para>Z points towards the center of the Earth and is perpendicular to the ground. </para></li></ul></para><para><center><image></image></center> </para><para>All three angles above are in <b>radians</b> and <b>positive</b> in the <b>counter-clockwise</b> direction.</para><para><para>getRotationMatrix(float[], float[], float[], float[]) </para><simplesectsep></simplesectsep><para>GeomagneticField </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The array values passed as argument.</para>
				/// </returns>
				/// <java-name>
				/// getOrientation
				/// </java-name>
				[Dot42.DexImport("getOrientation", "([F[F)[F", AccessFlags = 9)]
				public static float[] GetOrientation(float[] R, float[] values) /* MethodBuilder.Create */ 
				{
						return default(float[]);
				}

				/// <summary>
				/// <para>Computes the Altitude in meters from the atmospheric pressure and the pressure at sea level. </para><para>Typically the atmospheric pressure is read from a Sensor#TYPE_PRESSURE sensor. The pressure at sea level must be known, usually it can be retrieved from airport databases in the vicinity. If unknown, you can use PRESSURE_STANDARD_ATMOSPHERE as an approximation, but absolute altitudes won't be accurate. </para><para>To calculate altitude differences, you must calculate the difference between the altitudes at both points. If you don't know the altitude as sea level, you can use PRESSURE_STANDARD_ATMOSPHERE instead, which will give good results considering the range of pressure typically involved. </para><para><code><ul><li></li></ul>altitude_difference = getAltitude(SensorManager.PRESSURE_STANDARD_ATMOSPHERE, pressure_at_point2)<ul><li><para>getAltitude(SensorManager.PRESSURE_STANDARD_ATMOSPHERE, pressure_at_point1);  </para></li></ul></code></para><para><code></code></para><para><code> </code></para>        
				/// </summary>
				/// <returns>
				/// <para>Altitude in meters </para>
				/// </returns>
				/// <java-name>
				/// getAltitude
				/// </java-name>
				[Dot42.DexImport("getAltitude", "(FF)F", AccessFlags = 9)]
				public static float GetAltitude(float p0, float p) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				/// <para>Helper function to compute the angle change between two rotation matrices. Given a current rotation matrix (R) and a previous rotation matrix (prevR) computes the rotation around the z,x, and y axes which transforms prevR to R. outputs a 3 element vector containing the z,x, and y angle change at indexes 0, 1, and 2 respectively. </para><para>Each input matrix is either as a 3x3 or 4x4 row-major matrix depending on the length of the passed array: </para><para>If the array length is 9, then the array elements represent this matrix <pre>
				///          /  R[ 0]   R[ 1]   R[ 2]   \
				///          |  R[ 3]   R[ 4]   R[ 5]   |
				///          \  R[ 6]   R[ 7]   R[ 8]   /
				///       </pre> </para><para>If the array length is 16, then the array elements represent this matrix <pre>
				///          /  R[ 0]   R[ 1]   R[ 2]   R[ 3]  \
				///          |  R[ 4]   R[ 5]   R[ 6]   R[ 7]  |
				///          |  R[ 8]   R[ 9]   R[10]   R[11]  |
				///          \  R[12]   R[13]   R[14]   R[15]  /
				///       </pre> </para>        
				/// </summary>
				/// <java-name>
				/// getAngleChange
				/// </java-name>
				[Dot42.DexImport("getAngleChange", "([F[F[F)V", AccessFlags = 9)]
				public static void GetAngleChange(float[] angleChange, float[] R, float[] prevR) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Helper function to convert a rotation vector to a rotation matrix. Given a rotation vector (presumably from a ROTATION_VECTOR sensor), returns a 9 or 16 element rotation matrix in the array R. R must have length 9 or 16. If R.length == 9, the following matrix is returned: <pre>
				///          /  R[ 0]   R[ 1]   R[ 2]   \
				///          |  R[ 3]   R[ 4]   R[ 5]   |
				///          \  R[ 6]   R[ 7]   R[ 8]   /
				///       </pre> If R.length == 16, the following matrix is returned: <pre>
				///          /  R[ 0]   R[ 1]   R[ 2]   0  \
				///          |  R[ 4]   R[ 5]   R[ 6]   0  |
				///          |  R[ 8]   R[ 9]   R[10]   0  |
				///          \  0       0       0       1  /
				///       </pre> </para>        
				/// </summary>
				/// <java-name>
				/// getRotationMatrixFromVector
				/// </java-name>
				[Dot42.DexImport("getRotationMatrixFromVector", "([F[F)V", AccessFlags = 9)]
				public static void GetRotationMatrixFromVector(float[] R, float[] rotationVector) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Helper function to convert a rotation vector to a normalized quaternion. Given a rotation vector (presumably from a ROTATION_VECTOR sensor), returns a normalized quaternion in the array Q. The quaternion is stored as [w, x, y, z] </para>        
				/// </summary>
				/// <java-name>
				/// getQuaternionFromVector
				/// </java-name>
				[Dot42.DexImport("getQuaternionFromVector", "([F[F)V", AccessFlags = 9)]
				public static void GetQuaternionFromVector(float[] Q, float[] rv) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Requests receiving trigger events for a trigger sensor.</para><para>When the sensor detects a trigger event condition, such as significant motion in the case of the Sensor#TYPE_SIGNIFICANT_MOTION, the provided trigger listener will be invoked once and then its request to receive trigger events will be canceled. To continue receiving trigger events, the application must request to receive trigger events again. </para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if the sensor was successfully enabled.</para>
				/// </returns>
				/// <java-name>
				/// requestTriggerSensor
				/// </java-name>
				[Dot42.DexImport("requestTriggerSensor", "(Landroid/hardware/TriggerEventListener;Landroid/hardware/Sensor;)Z", AccessFlags = 1)]
				public virtual bool RequestTriggerSensor(global::Android.Hardware.TriggerEventListener listener, global::Android.Hardware.Sensor sensor) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Cancels receiving trigger events for a trigger sensor.</para><para>Note that a Trigger sensor will be auto disabled if TriggerEventListener#onTrigger(TriggerEvent) has triggered. This method is provided in case the user wants to explicitly cancel the request to receive trigger events. </para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if successfully canceled.</para>
				/// </returns>
				/// <java-name>
				/// cancelTriggerSensor
				/// </java-name>
				[Dot42.DexImport("cancelTriggerSensor", "(Landroid/hardware/TriggerEventListener;Landroid/hardware/Sensor;)Z", AccessFlags = 1)]
				public virtual bool CancelTriggerSensor(global::Android.Hardware.TriggerEventListener listener, global::Android.Hardware.Sensor sensor) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>This method is deprecated, use SensorManager#getSensorList(int) instead </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				/// <para>available sensors. </para>
				/// </returns>
				/// <java-name>
				/// getSensors
				/// </java-name>
				public int Sensors
				{
				[Dot42.DexImport("getSensors", "()I", AccessFlags = 1)]
						get{ return GetSensors(); }
				}

		}

		/// <summary>
		/// <para>This class is the listener used to handle Trigger Sensors. Trigger Sensors are sensors that trigger an event and are automatically disabled. Sensor#TYPE_SIGNIFICANT_MOTION is one such example. </para><para>SensorManager lets you access the device's sensors. Get an instance of SensorManager by calling Context.getSystemService() with the argument android.content.Context#SENSOR_SERVICE. </para><para>Here's an example setup for a TriggerEventListener:</para><para><pre>
		///    class TriggerListener extends TriggerEventListener {
		///        public void onTrigger(TriggerEvent event) {
		///             // Do Work.
		/// 
		///        // As it is a one shot sensor, it will be canceled automatically.
		///        // SensorManager.requestTriggerSensor(this, mSigMotion); needs to
		///        // be called again, if needed.
		///        }
		///    }
		///    public class SensorActivity extends Activity {
		///        private final SensorManager mSensorManager;
		///        private final Sensor mSigMotion;
		///        private final TriggerEventListener mListener = new TriggerEventListener();
		/// 
		///        public SensorActivity() {
		///            mSensorManager = (SensorManager)getSystemService(SENSOR_SERVICE);
		///            mSigMotion = mSensorManager.getDefaultSensor(Sensor.TYPE_SIGNIFICANT_MOTION);
		///        }
		/// 
		///        protected void onResume() {
		///            super.onResume();
		///            mSensorManager.requestTriggerSensor(mListener, mSigMotion);
		///        }
		/// 
		///        protected void onPause() {
		///            super.onPause();
		///            // Call disable to ensure that the trigger request has been canceled.
		///            mSensorManager.cancelTriggerSensor(mListener, mSigMotion);
		///        }
		/// 
		///    }
		///    </pre></para><para><para>TriggerEvent </para><simplesectsep></simplesectsep><para>Sensor </para></para>    
		/// </summary>
		/// <java-name>
		/// android/hardware/TriggerEventListener
		/// </java-name>
		[Dot42.DexImport("android/hardware/TriggerEventListener", AccessFlags = 1057)]
		public abstract partial class TriggerEventListener
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public TriggerEventListener() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>The method that will be called when the sensor is triggered. Override this method in your implementation of this class.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// onTrigger
				/// </java-name>
				[Dot42.DexImport("onTrigger", "(Landroid/hardware/TriggerEvent;)V", AccessFlags = 1025)]
				public abstract void OnTrigger(global::Android.Hardware.TriggerEvent @event) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// android/hardware/ConsumerIrManager
		/// </java-name>
		[Dot42.DexImport("android/hardware/ConsumerIrManager", AccessFlags = 49)]
		public sealed partial class ConsumerIrManager
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal ConsumerIrManager() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// hasIrEmitter
				/// </java-name>
				[Dot42.DexImport("hasIrEmitter", "()Z", AccessFlags = 1)]
				public bool HasIrEmitter() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// transmit
				/// </java-name>
				[Dot42.DexImport("transmit", "(I[I)V", AccessFlags = 1)]
				public void Transmit(int int32, int[] int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getCarrierFrequencies
				/// </java-name>
				[Dot42.DexImport("getCarrierFrequencies", "()[Landroid/hardware/ConsumerIrManager$CarrierFrequencyRange;", AccessFlags = 1)]
				public global::Android.Hardware.ConsumerIrManager.CarrierFrequencyRange[] GetCarrierFrequencies() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Hardware.ConsumerIrManager.CarrierFrequencyRange[]);
				}

				/// <java-name>
				/// getCarrierFrequencies
				/// </java-name>
				public global::Android.Hardware.ConsumerIrManager.CarrierFrequencyRange[] CarrierFrequencies
				{
				[Dot42.DexImport("getCarrierFrequencies", "()[Landroid/hardware/ConsumerIrManager$CarrierFrequencyRange;", AccessFlags = 1)]
						get{ return GetCarrierFrequencies(); }
				}

				/// <java-name>
				/// android/hardware/ConsumerIrManager$CarrierFrequencyRange
				/// </java-name>
				[Dot42.DexImport("android/hardware/ConsumerIrManager$CarrierFrequencyRange", AccessFlags = 17)]
				public sealed partial class CarrierFrequencyRange
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// this$0
						/// </java-name>
						[Dot42.DexImport("this$0", "Landroid/hardware/ConsumerIrManager;", AccessFlags = 4112)]
						internal readonly global::Android.Hardware.ConsumerIrManager This_0;
						[Dot42.DexImport("<init>", "(Landroid/hardware/ConsumerIrManager;II)V", AccessFlags = 1)]
						public CarrierFrequencyRange(global::Android.Hardware.ConsumerIrManager consumerIrManager, int int32, int int321) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// getMinFrequency
						/// </java-name>
						[Dot42.DexImport("getMinFrequency", "()I", AccessFlags = 1)]
						public int GetMinFrequency() /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <java-name>
						/// getMaxFrequency
						/// </java-name>
						[Dot42.DexImport("getMaxFrequency", "()I", AccessFlags = 1)]
						public int GetMaxFrequency() /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal CarrierFrequencyRange() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

						/// <java-name>
						/// getMinFrequency
						/// </java-name>
						public int MinFrequency
						{
						[Dot42.DexImport("getMinFrequency", "()I", AccessFlags = 1)]
								get{ return GetMinFrequency(); }
						}

						/// <java-name>
						/// getMaxFrequency
						/// </java-name>
						public int MaxFrequency
						{
						[Dot42.DexImport("getMaxFrequency", "()I", AccessFlags = 1)]
								get{ return GetMaxFrequency(); }
						}

				}

		}

		/// <summary>
		/// <para>This class represents a Sensor event and holds informations such as the sensor's type, the time-stamp, accuracy and of course the sensor's data.</para><para>&lt;u&gt;Definition of the coordinate system used by the SensorEvent API.&lt;/u&gt; </para><para>The coordinate-system is defined relative to the screen of the phone in its default orientation. The axes are not swapped when the device's screen orientation changes. </para><para>The X axis is horizontal and points to the right, the Y axis is vertical and points up and the Z axis points towards the outside of the front face of the screen. In this system, coordinates behind the screen have negative Z values. </para><para><center><image></image></center> </para><para><b>Note:</b> This coordinate system is different from the one used in the Android 2D APIs where the origin is in the top-left corner. </para><para><para>SensorManager </para><simplesectsep></simplesectsep><para>SensorEvent </para><simplesectsep></simplesectsep><para>Sensor </para></para>    
		/// </summary>
		/// <java-name>
		/// android/hardware/SensorEvent
		/// </java-name>
		[Dot42.DexImport("android/hardware/SensorEvent", AccessFlags = 33)]
		public partial class SensorEvent
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>The length and contents of the values array depends on which sensor type is being monitored (see also SensorEvent for a definition of the coordinate system used). </para><para><h4>android.hardware.Sensor::TYPE_ACCELEROMETER Sensor.TYPE_ACCELEROMETER}:</h4></para><para>All values are in SI units (m/s^2)</para><para><ul><li><para>values[0]: Acceleration minus Gx on the x-axis  </para></li><li><para>values[1]: Acceleration minus Gy on the y-axis  </para></li><li><para>values[2]: Acceleration minus Gz on the z-axis  </para></li></ul></para><para>A sensor of this type measures the acceleration applied to the device (<b>Ad</b>). Conceptually, it does so by measuring forces applied to the sensor itself (<b>Fs</b>) using the relation: </para><para><b><center>Ad = - &amp;#8721;Fs / mass</center></b></para><para>In particular, the force of gravity is always influencing the measured acceleration: </para><para><b><center>Ad = -g - &amp;#8721;F / mass</center></b></para><para>For this reason, when the device is sitting on a table (and obviously not accelerating), the accelerometer reads a magnitude of <b>g</b> = 9.81 m/s^2 </para><para>Similarly, when the device is in free-fall and therefore dangerously accelerating towards to ground at 9.81 m/s^2, its accelerometer reads a magnitude of 0 m/s^2. </para><para>It should be apparent that in order to measure the real acceleration of the device, the contribution of the force of gravity must be eliminated. This can be achieved by applying a <b>high-pass</b> filter. Conversely, a <b>low-pass</b> filter can be used to isolate the force of gravity. </para><para><pre>
				/// <span>public void onSensorChanged(SensorEvent event)
				/// {
				///      // alpha is calculated as t / (t + dT)
				///      // with t, the low-pass filter's time-constant
				///      // and dT, the event delivery rate
				/// 
				///      final float alpha = 0.8;
				/// 
				///      gravity[0] = alpha * gravity[0] + (1 - alpha) * event.values[0];
				///      gravity[1] = alpha * gravity[1] + (1 - alpha) * event.values[1];
				///      gravity[2] = alpha * gravity[2] + (1 - alpha) * event.values[2];
				/// 
				///      linear_acceleration[0] = event.values[0] - gravity[0];
				///      linear_acceleration[1] = event.values[1] - gravity[1];
				///      linear_acceleration[2] = event.values[2] - gravity[2];
				/// }
				/// </span>
				///        </pre></para><para>&lt;u&gt;Examples&lt;/u&gt;: <ul><li><para>When the device lies flat on a table and is pushed on its left side toward the right, the x acceleration value is positive.</para><para></para></li><li><para>When the device lies flat on a table, the acceleration value is +9.81, which correspond to the acceleration of the device (0 m/s^2) minus the force of gravity (-9.81 m/s^2).</para><para></para></li><li><para>When the device lies flat on a table and is pushed toward the sky with an acceleration of A m/s^2, the acceleration value is equal to A+9.81 which correspond to the acceleration of the device (+A m/s^2) minus the force of gravity (-9.81 m/s^2). </para></li></ul></para><para><h4>android.hardware.Sensor::TYPE_MAGNETIC_FIELD Sensor.TYPE_MAGNETIC_FIELD}:</h4></para><para>All values are in micro-Tesla (uT) and measure the ambient magnetic field in the X, Y and Z axis.</para><para><h4>android.hardware.Sensor::TYPE_GYROSCOPE Sensor.TYPE_GYROSCOPE}: </h4></para><para>All values are in radians/second and measure the rate of rotation around the device's local X, Y and Z axis. The coordinate system is the same as is used for the acceleration sensor. Rotation is positive in the counter-clockwise direction. That is, an observer looking from some positive location on the x, y or z axis at a device positioned on the origin would report positive rotation if the device appeared to be rotating counter clockwise. Note that this is the standard mathematical definition of positive rotation and does not agree with the definition of roll given earlier. <ul><li><para>values[0]: Angular speed around the x-axis  </para></li><li><para>values[1]: Angular speed around the y-axis  </para></li><li><para>values[2]: Angular speed around the z-axis  </para></li></ul></para><para>Typically the output of the gyroscope is integrated over time to calculate a rotation describing the change of angles over the timestep, for example: </para><para><pre>
				///            private static final float NS2S = 1.0f / 1000000000.0f;
				///            private final float[] deltaRotationVector = new float[4]();
				///            private float timestamp;
				/// 
				///            public void onSensorChanged(SensorEvent event) {
				///                 // This timestep's delta rotation to be multiplied by the current rotation
				///                 // after computing it from the gyro sample data.
				///                 if (timestamp != 0) {
				///                     final float dT = (event.timestamp - timestamp) * NS2S;
				///                     // Axis of the rotation sample, not normalized yet.
				///                     float axisX = event.values[0];
				///                     float axisY = event.values[1];
				///                     float axisZ = event.values[2];
				/// 
				///                     // Calculate the angular speed of the sample
				///                     float omegaMagnitude = sqrt(axisX*axisX + axisY*axisY + axisZ*axisZ);
				/// 
				///                     // Normalize the rotation vector if it's big enough to get the axis
				///                     if (omegaMagnitude &gt; EPSILON) {
				///                         axisX /= omegaMagnitude;
				///                         axisY /= omegaMagnitude;
				///                         axisZ /= omegaMagnitude;
				///                     }
				/// 
				///                     // Integrate around this axis with the angular speed by the timestep
				///                     // in order to get a delta rotation from this sample over the timestep
				///                     // We will convert this axis-angle representation of the delta rotation
				///                     // into a quaternion before turning it into the rotation matrix.
				///                     float thetaOverTwo = omegaMagnitude * dT / 2.0f;
				///                     float sinThetaOverTwo = sin(thetaOverTwo);
				///                     float cosThetaOverTwo = cos(thetaOverTwo);
				///                     deltaRotationVector[0] = sinThetaOverTwo * axisX;
				///                     deltaRotationVector[1] = sinThetaOverTwo * axisY;
				///                     deltaRotationVector[2] = sinThetaOverTwo * axisZ;
				///                     deltaRotationVector[3] = cosThetaOverTwo;
				///                 }
				///                 timestamp = event.timestamp;
				///                 float[] deltaRotationMatrix = new float[9];
				///                 SensorManager.getRotationMatrixFromVector(deltaRotationMatrix, deltaRotationVector);
				///                 // User code should concatenate the delta rotation we computed with the current rotation
				///                 // in order to get the updated rotation.
				///                 // rotationCurrent = rotationCurrent * deltaRotationMatrix;
				///            }
				///        </pre> </para><para>In practice, the gyroscope noise and offset will introduce some errors which need to be compensated for. This is usually done using the information from other sensors, but is beyond the scope of this document. </para><para><h4>android.hardware.Sensor::TYPE_LIGHT Sensor.TYPE_LIGHT}:</h4></para><para><ul><li><para>values[0]: Ambient light level in SI lux units  </para></li></ul></para><para><h4>android.hardware.Sensor::TYPE_PRESSURE Sensor.TYPE_PRESSURE}:</h4></para><para><ul><li><para>values[0]: Atmospheric pressure in hPa (millibar)  </para></li></ul></para><para><h4>android.hardware.Sensor::TYPE_PROXIMITY Sensor.TYPE_PROXIMITY}: </h4></para><para><ul><li><para>values[0]: Proximity sensor distance measured in centimeters  </para></li></ul></para><para><b>Note:</b> Some proximity sensors only support a binary <b>near</b> or <b>far</b> measurement. In this case, the sensor should report its maximum range value in the <b>far</b> state and a lesser value in the <b>near</b> state. </para><para><h4>android.hardware.Sensor::TYPE_GRAVITY Sensor.TYPE_GRAVITY}:</h4></para><para>A three dimensional vector indicating the direction and magnitude of gravity. Units are m/s^2. The coordinate system is the same as is used by the acceleration sensor.</para><para><b>Note:</b> When the device is at rest, the output of the gravity sensor should be identical to that of the accelerometer.</para><para><h4>android.hardware.Sensor::TYPE_LINEAR_ACCELERATION Sensor.TYPE_LINEAR_ACCELERATION}:</h4></para><para>A three dimensional vector indicating acceleration along each device axis, not including gravity. All values have units of m/s^2. The coordinate system is the same as is used by the acceleration sensor. </para><para>The output of the accelerometer, gravity and linear-acceleration sensors must obey the following relation:</para><para><ul><li></li></ul>= gravity + linear-acceleration</para><para><h4>android.hardware.Sensor::TYPE_ROTATION_VECTOR Sensor.TYPE_ROTATION_VECTOR}:</h4></para><para>The rotation vector represents the orientation of the device as a combination of an <b>angle</b> and an <b>axis</b>, in which the device has rotated through an angle &amp;#952 around an axis &lt;x, y, z&gt;.</para><para>The three elements of the rotation vector are &lt;x*sin(&amp;#952/2), y*sin(&amp;#952/2), z*sin(&amp;#952/2)&gt;, such that the magnitude of the rotation vector is equal to sin(&amp;#952/2), and the direction of the rotation vector is equal to the direction of the axis of rotation.</para><para>The three elements of the rotation vector are equal to the last three components of a <b>unit</b> quaternion &lt;cos(&amp;#952/2), x*sin(&amp;#952/2), y*sin(&amp;#952/2), z*sin(&amp;#952/2)&gt;.</para><para>Elements of the rotation vector are unitless. The x,y, and z axis are defined in the same way as the acceleration sensor.</para><para>The reference coordinate system is defined as a direct orthonormal basis, where: </para><para><ul><li><para>X is defined as the vector product <b>Y.Z</b> (It is tangential to the ground at the device's current location and roughly points East). </para></li><li><para>Y is tangential to the ground at the device's current location and points towards magnetic north. </para></li><li><para>Z points towards the sky and is perpendicular to the ground. </para></li></ul></para><para><center><image></image></center> </para><para><ul><li><para>values[0]: x*sin(&amp;#952/2)  </para></li><li><para>values[1]: y*sin(&amp;#952/2)  </para></li><li><para>values[2]: z*sin(&amp;#952/2)  </para></li><li><para>values[3]: cos(&amp;#952/2)  </para></li><li><para>values[4]: estimated heading Accuracy (in radians) (-1 if unavailable) </para></li></ul></para><para>values[3], originally optional, will always be present from SDK Level 18 onwards. values[4] is a new value that has been added in SDK Level 18. </para><para><h4>android.hardware.Sensor::TYPE_ORIENTATION Sensor.TYPE_ORIENTATION}:</h4></para><para>All values are angles in degrees.</para><para><ul><li><para>values[0]: Azimuth, angle between the magnetic north direction and the y-axis, around the z-axis (0 to 359). 0=North, 90=East, 180=South, 270=West </para><para></para><para></para><para>values[1]: Pitch, rotation around x-axis (-180 to 180), with positive values when the z-axis moves <b>toward</b> the y-axis. </para><para></para><para></para><para>values[2]: Roll, rotation around the x-axis (-90 to 90) increasing as the device moves clockwise. </para><para></para></li></ul></para><para><b>Note:</b> This definition is different from <b>yaw, pitch and roll</b> used in aviation where the X axis is along the long side of the plane (tail to nose). </para><para><b>Note:</b> This sensor type exists for legacy reasons, please use getRotationMatrix() in conjunction with remapCoordinateSystem() and getOrientation() to compute these values instead. </para><para><b>Important note:</b> For historical reasons the roll angle is positive in the clockwise direction (mathematically speaking, it should be positive in the counter-clockwise direction). </para><para><h4>android.hardware.Sensor::TYPE_RELATIVE_HUMIDITY Sensor.TYPE_RELATIVE_HUMIDITY}:</h4></para><para><ul><li><para>values[0]: Relative ambient air humidity in percent  </para></li></ul></para><para>When relative ambient air humidity and ambient temperature are measured, the dew point and absolute humidity can be calculated. </para><para>&lt;u&gt;Dew Point&lt;/u&gt; </para><para>The dew point is the temperature to which a given parcel of air must be cooled, at constant barometric pressure, for water vapor to condense into water. </para><para><center><pre>
				///                           ln(RH/100%) + m&amp;#183;t/(T<subscript>n</subscript>+t)
				///        t<subscript>d</subscript>(t,RH) = T<subscript>n</subscript> &amp;#183; 
				///                        m - [ln(RH/100%) + m&amp;#183;t/(T<subscript>n</subscript>+t)]
				///        </pre></center> </para><para>for example:</para><para><pre>
				///        h = Math.log(rh / 100.0) + (17.62 * t) / (243.12 + t);
				///        td = 243.12 * h / (17.62 - h);
				///        </pre> &lt;u&gt;Absolute Humidity&lt;/u&gt; </para><para>The absolute humidity is the mass of water vapor in a particular volume of dry air. The unit is g/m<span>3</span>. </para><para><center><pre>
				///                           RH/100%&amp;#183;A&amp;#183;exp(m&amp;#183;t/(T<subscript>n</subscript>+t))
				///        d<subscript>v</subscript>(t,RH) = 216.7 &amp;#183; -
				///                                  273.15 + t
				///        </pre></center> </para><para>for example:</para><para><pre>
				///        dv = 216.7 *
				///        (rh / 100.0 * 6.112 * Math.exp(17.62 * t / (243.12 + t)) / (273.15 + t));
				///        </pre></para><para><h4>android.hardware.Sensor::TYPE_AMBIENT_TEMPERATURE Sensor.TYPE_AMBIENT_TEMPERATURE}: </h4></para><para><ul><li><para>values[0]: ambient (room) temperature in degree Celsius. </para></li></ul></para><para><h4>android.hardware.Sensor::TYPE_MAGNETIC_FIELD_UNCALIBRATED Sensor.TYPE_MAGNETIC_FIELD_UNCALIBRATED}:</h4></para><para>Similar to android.hardware.Sensor#TYPE_MAGNETIC_FIELD, but the hard iron calibration is reported separately instead of being included in the measurement. Factory calibration and temperature compensation will still be applied to the "uncalibrated" measurement. Assumptions that the magnetic field is due to the Earth's poles is avoided. </para><para>The values array is shown below: <ul><li><para>values[0] = x_uncalib  </para></li><li><para>values[1] = y_uncalib  </para></li><li><para>values[2] = z_uncalib  </para></li><li><para>values[3] = x_bias  </para></li><li><para>values[4] = y_bias  </para></li><li><para>values[5] = z_bias  </para></li></ul></para><para>x_uncalib, y_uncalib, z_uncalib are the measured magnetic field in X, Y, Z axes. Soft iron and temperature calibrations are applied. But the hard iron calibration is not applied. The values are in micro-Tesla (uT). </para><para>x_bias, y_bias, z_bias give the iron bias estimated in X, Y, Z axes. Each field is a component of the estimated hard iron calibration. The values are in micro-Tesla (uT). </para><para>Hard iron - These distortions arise due to the magnetized iron, steel or permanenet magnets on the device. Soft iron - These distortions arise due to the interaction with the earth's magentic field. </para><para><h4>android.hardware.Sensor::TYPE_GAME_ROTATION_VECTOR}:</h4></para><para>Identical to android.hardware.Sensor#TYPE_ROTATION_VECTOR except that it doesn't use the geomagnetic field. Therefore the Y axis doesn't point north, but instead to some other reference, that reference is allowed to drift by the same order of magnitude as the gyroscope drift around the Z axis. </para><para>In the ideal case, a phone rotated and returning to the same real-world orientation will report the same game rotation vector (without using the earth's geomagnetic field). However, the orientation may drift somewhat over time. See android.hardware.Sensor#TYPE_ROTATION_VECTOR for a detailed description of the values. This sensor will not have the estimated heading accuracy value. </para><para><h4>android.hardware.Sensor::TYPE_GYROSCOPE_UNCALIBRATED Sensor.TYPE_GYROSCOPE_UNCALIBRATED}:</h4></para><para>All values are in radians/second and measure the rate of rotation around the X, Y and Z axis. An estimation of the drift on each axis is reported as well. </para><para>No gyro-drift compensation is performed. Factory calibration and temperature compensation is still applied to the rate of rotation (angular speeds). </para><para>The coordinate system is the same as is used for the android.hardware.Sensor#TYPE_ACCELEROMETER Rotation is positive in the counter-clockwise direction (right-hand rule). That is, an observer looking from some positive location on the x, y or z axis at a device positioned on the origin would report positive rotation if the device appeared to be rotating counter clockwise. The range would at least be 17.45 rad/s (ie: ~1000 deg/s). <ul><li><para>values[0] : angular speed (w/o drift compensation) around the X axis in rad/s  </para></li><li><para>values[1] : angular speed (w/o drift compensation) around the Y axis in rad/s  </para></li><li><para>values[2] : angular speed (w/o drift compensation) around the Z axis in rad/s  </para></li><li><para>values[3] : estimated drift around X axis in rad/s  </para></li><li><para>values[4] : estimated drift around Y axis in rad/s  </para></li><li><para>values[5] : estimated drift around Z axis in rad/s  </para></li></ul></para><para><b>Pro Tip:</b> Always use the length of the values array while performing operations on it. In earlier versions, this used to be always 3 which has changed now. </para><para><para>GeomagneticField </para></para>        
				/// </summary>
				/// <java-name>
				/// values
				/// </java-name>
				[Dot42.DexImport("values", "[F", AccessFlags = 17)]
				public readonly float[] Values;
				/// <summary>
				/// <para>The sensor that generated this event. See SensorManager for details. </para>        
				/// </summary>
				/// <java-name>
				/// sensor
				/// </java-name>
				[Dot42.DexImport("sensor", "Landroid/hardware/Sensor;", AccessFlags = 1)]
				public global::Android.Hardware.Sensor Sensor;
				/// <summary>
				/// <para>The accuracy of this event. See SensorManager for details. </para>        
				/// </summary>
				/// <java-name>
				/// accuracy
				/// </java-name>
				[Dot42.DexImport("accuracy", "I", AccessFlags = 1)]
				public int Accuracy;
				/// <summary>
				/// <para>The time in nanosecond at which the event happened </para>        
				/// </summary>
				/// <java-name>
				/// timestamp
				/// </java-name>
				[Dot42.DexImport("timestamp", "J", AccessFlags = 1)]
				public long Timestamp;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal SensorEvent() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>Used for receiving notifications from the SensorManager when sensor values have changed. </para>    
		/// </summary>
		/// <java-name>
		/// android/hardware/SensorEventListener
		/// </java-name>
		[Dot42.DexImport("android/hardware/SensorEventListener", AccessFlags = 1537)]
		public partial interface ISensorEventListener
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Called when sensor values have changed. </para><para>See SensorManager for details on possible sensor types. </para><para>See also SensorEvent.</para><para><b>NOTE:</b> The application doesn't own the event object passed as a parameter and therefore cannot hold on to it. The object may be part of an internal pool and may be reused by the framework.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// onSensorChanged
				/// </java-name>
				[Dot42.DexImport("onSensorChanged", "(Landroid/hardware/SensorEvent;)V", AccessFlags = 1025)]
				void OnSensorChanged(global::Android.Hardware.SensorEvent @event) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Called when the accuracy of a sensor has changed. </para><para>See SensorManager for details.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// onAccuracyChanged
				/// </java-name>
				[Dot42.DexImport("onAccuracyChanged", "(Landroid/hardware/Sensor;I)V", AccessFlags = 1025)]
				void OnAccuracyChanged(global::Android.Hardware.Sensor sensor, int accuracy) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>This class represents a Trigger Event - the event associated with a Trigger Sensor. When the sensor detects a trigger event condition, such as significant motion in the case of the Sensor#TYPE_SIGNIFICANT_MOTION, the TriggerEventListener is called with the TriggerEvent. The sensor is automatically canceled after the trigger. </para><para>This class holds information such as the value of the sensor when the trigger happened, the timestamp along with detailed information regarding the Sensor itself. </para><para><para>android.hardware.SensorManager </para><simplesectsep></simplesectsep><para>android.hardware.TriggerEvent </para><simplesectsep></simplesectsep><para>android.hardware.Sensor </para></para>    
		/// </summary>
		/// <java-name>
		/// android/hardware/TriggerEvent
		/// </java-name>
		[Dot42.DexImport("android/hardware/TriggerEvent", AccessFlags = 49)]
		public sealed partial class TriggerEvent
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>The length and contents of the values array depends on which sensor type is being monitored (see also SensorEvent for a definition of the coordinate system used). </para><para><h4>Sensor::TYPE_SIGNIFICANT_MOTION} </h4></para><para>The value field is of length 1. value[0] = 1.0 when the sensor triggers. 1.0 is the only allowed value. </para>        
				/// </summary>
				/// <java-name>
				/// values
				/// </java-name>
				[Dot42.DexImport("values", "[F", AccessFlags = 17)]
				public readonly float[] Values;
				/// <summary>
				/// <para>The sensor that generated this event. See SensorManager for details. </para>        
				/// </summary>
				/// <java-name>
				/// sensor
				/// </java-name>
				[Dot42.DexImport("sensor", "Landroid/hardware/Sensor;", AccessFlags = 1)]
				public global::Android.Hardware.Sensor Sensor;
				/// <summary>
				/// <para>The time in nanosecond at which the event happened </para>        
				/// </summary>
				/// <java-name>
				/// timestamp
				/// </java-name>
				[Dot42.DexImport("timestamp", "J", AccessFlags = 1)]
				public long Timestamp;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal TriggerEvent() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>Class representing a sensor. Use SensorManager#getSensorList to get the list of available Sensors.</para><para><para>SensorManager </para><simplesectsep></simplesectsep><para>SensorEventListener </para><simplesectsep></simplesectsep><para>SensorEvent </para></para>    
		/// </summary>
		/// <java-name>
		/// android/hardware/Sensor
		/// </java-name>
		[Dot42.DexImport("android/hardware/Sensor", AccessFlags = 49)]
		public sealed partial class Sensor
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>A constant describing an accelerometer sensor type. </para><para>See SensorEvent.values for more details. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_ACCELEROMETER
				/// </java-name>
				[Dot42.DexImport("TYPE_ACCELEROMETER", "I", AccessFlags = 25)]
				public const int TYPE_ACCELEROMETER = 1;
				/// <summary>
				/// <para>A constant describing a magnetic field sensor type. </para><para>See SensorEvent.values for more details. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_MAGNETIC_FIELD
				/// </java-name>
				[Dot42.DexImport("TYPE_MAGNETIC_FIELD", "I", AccessFlags = 25)]
				public const int TYPE_MAGNETIC_FIELD = 2;
				/// <summary>
				/// <para>A constant describing an orientation sensor type. </para><para>See SensorEvent.values for more details.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>use SensorManager.getOrientation() instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// TYPE_ORIENTATION
				/// </java-name>
				[Dot42.DexImport("TYPE_ORIENTATION", "I", AccessFlags = 25)]
				public const int TYPE_ORIENTATION = 3;
				/// <summary>
				/// <para>A constant describing a gyroscope sensor type. </para><para>See SensorEvent.values for more details. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_GYROSCOPE
				/// </java-name>
				[Dot42.DexImport("TYPE_GYROSCOPE", "I", AccessFlags = 25)]
				public const int TYPE_GYROSCOPE = 4;
				/// <summary>
				/// <para>A constant describing a light sensor type. </para><para>See SensorEvent.values for more details. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_LIGHT
				/// </java-name>
				[Dot42.DexImport("TYPE_LIGHT", "I", AccessFlags = 25)]
				public const int TYPE_LIGHT = 5;
				/// <summary>
				/// <para>A constant describing a pressure sensor type. </para><para>See SensorEvent.values for more details. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_PRESSURE
				/// </java-name>
				[Dot42.DexImport("TYPE_PRESSURE", "I", AccessFlags = 25)]
				public const int TYPE_PRESSURE = 6;
				/// <summary>
				/// <para>A constant describing a temperature sensor type</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>use Sensor.TYPE_AMBIENT_TEMPERATURE instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// TYPE_TEMPERATURE
				/// </java-name>
				[Dot42.DexImport("TYPE_TEMPERATURE", "I", AccessFlags = 25)]
				public const int TYPE_TEMPERATURE = 7;
				/// <summary>
				/// <para>A constant describing a proximity sensor type. </para><para>See SensorEvent.values for more details. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_PROXIMITY
				/// </java-name>
				[Dot42.DexImport("TYPE_PROXIMITY", "I", AccessFlags = 25)]
				public const int TYPE_PROXIMITY = 8;
				/// <summary>
				/// <para>A constant describing a gravity sensor type. </para><para>See SensorEvent.values for more details. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_GRAVITY
				/// </java-name>
				[Dot42.DexImport("TYPE_GRAVITY", "I", AccessFlags = 25)]
				public const int TYPE_GRAVITY = 9;
				/// <summary>
				/// <para>A constant describing a linear acceleration sensor type. </para><para>See SensorEvent.values for more details. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_LINEAR_ACCELERATION
				/// </java-name>
				[Dot42.DexImport("TYPE_LINEAR_ACCELERATION", "I", AccessFlags = 25)]
				public const int TYPE_LINEAR_ACCELERATION = 10;
				/// <summary>
				/// <para>A constant describing a rotation vector sensor type. </para><para>See SensorEvent.values for more details. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_ROTATION_VECTOR
				/// </java-name>
				[Dot42.DexImport("TYPE_ROTATION_VECTOR", "I", AccessFlags = 25)]
				public const int TYPE_ROTATION_VECTOR = 11;
				/// <summary>
				/// <para>A constant describing a relative humidity sensor type. </para><para>See SensorEvent.values for more details. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_RELATIVE_HUMIDITY
				/// </java-name>
				[Dot42.DexImport("TYPE_RELATIVE_HUMIDITY", "I", AccessFlags = 25)]
				public const int TYPE_RELATIVE_HUMIDITY = 12;
				/// <summary>
				/// <para>A constant describing an ambient temperature sensor type. </para><para>See SensorEvent.values for more details. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_AMBIENT_TEMPERATURE
				/// </java-name>
				[Dot42.DexImport("TYPE_AMBIENT_TEMPERATURE", "I", AccessFlags = 25)]
				public const int TYPE_AMBIENT_TEMPERATURE = 13;
				/// <summary>
				/// <para>A constant describing an uncalibrated magnetic field sensor type. </para><para>Similar to TYPE_MAGNETIC_FIELD but the hard iron calibration (device calibration due to distortions that arise from magnetized iron, steel or permanent magnets on the device) is not considered in the given sensor values. However, such hard iron bias values are returned to you separately in the result android.hardware.SensorEvent#values so you may use them for custom calibrations. </para><para>Also, no periodic calibration is performed (i.e. there are no discontinuities in the data stream while using this sensor) and assumptions that the magnetic field is due to the Earth's poles is avoided, but factory calibration and temperature compensation have been performed. </para><para>See SensorEvent.values for more details. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_MAGNETIC_FIELD_UNCALIBRATED
				/// </java-name>
				[Dot42.DexImport("TYPE_MAGNETIC_FIELD_UNCALIBRATED", "I", AccessFlags = 25)]
				public const int TYPE_MAGNETIC_FIELD_UNCALIBRATED = 14;
				/// <summary>
				/// <para>A constant describing an uncalibrated rotation vector sensor type. </para><para>Identical to TYPE_ROTATION_VECTOR except that it doesn't use the geomagnetic field. Therefore the Y axis doesn't point north, but instead to some other reference, that reference is allowed to drift by the same order of magnitude as the gyroscope drift around the Z axis. </para><para>In the ideal case, a phone rotated and returning to the same real-world orientation should report the same game rotation vector (without using the earth's geomagnetic field). However, the orientation may drift somewhat over time. </para><para>See SensorEvent.values for more details. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_GAME_ROTATION_VECTOR
				/// </java-name>
				[Dot42.DexImport("TYPE_GAME_ROTATION_VECTOR", "I", AccessFlags = 25)]
				public const int TYPE_GAME_ROTATION_VECTOR = 15;
				/// <summary>
				/// <para>A constant describing an uncalibrated gyroscope sensor type. </para><para>Similar to TYPE_GYROSCOPE but no gyro-drift compensation has been performed to adjust the given sensor values. However, such gyro-drift bias values are returned to you separately in the result android.hardware.SensorEvent#values so you may use them for custom calibrations. </para><para>Factory calibration and temperature compensation is still applied to the rate of rotation (angular speeds). </para><para>See SensorEvent.values for more details. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_GYROSCOPE_UNCALIBRATED
				/// </java-name>
				[Dot42.DexImport("TYPE_GYROSCOPE_UNCALIBRATED", "I", AccessFlags = 25)]
				public const int TYPE_GYROSCOPE_UNCALIBRATED = 16;
				/// <summary>
				/// <para>A constant describing the significant motion trigger sensor. </para><para>It triggers when an event occurs and then automatically disables itself. The sensor continues to operate while the device is asleep and will automatically wake the device to notify when significant motion is detected. The application does not need to hold any wake locks for this sensor to trigger. </para><para>See TriggerEvent for more details. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_SIGNIFICANT_MOTION
				/// </java-name>
				[Dot42.DexImport("TYPE_SIGNIFICANT_MOTION", "I", AccessFlags = 25)]
				public const int TYPE_SIGNIFICANT_MOTION = 17;
				/// <java-name>
				/// TYPE_STEP_DETECTOR
				/// </java-name>
				[Dot42.DexImport("TYPE_STEP_DETECTOR", "I", AccessFlags = 25)]
				public const int TYPE_STEP_DETECTOR = 18;
				/// <java-name>
				/// TYPE_STEP_COUNTER
				/// </java-name>
				[Dot42.DexImport("TYPE_STEP_COUNTER", "I", AccessFlags = 25)]
				public const int TYPE_STEP_COUNTER = 19;
				/// <java-name>
				/// TYPE_GEOMAGNETIC_ROTATION_VECTOR
				/// </java-name>
				[Dot42.DexImport("TYPE_GEOMAGNETIC_ROTATION_VECTOR", "I", AccessFlags = 25)]
				public const int TYPE_GEOMAGNETIC_ROTATION_VECTOR = 20;
				/// <summary>
				/// <para>A constant describing all sensor types. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_ALL
				/// </java-name>
				[Dot42.DexImport("TYPE_ALL", "I", AccessFlags = 25)]
				public const int TYPE_ALL = -1;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal Sensor() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>name string of the sensor. </para>
				/// </returns>
				/// <java-name>
				/// getName
				/// </java-name>
				[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1)]
				public string GetName() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>vendor string of this sensor. </para>
				/// </returns>
				/// <java-name>
				/// getVendor
				/// </java-name>
				[Dot42.DexImport("getVendor", "()Ljava/lang/String;", AccessFlags = 1)]
				public string GetVendor() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>generic type of this sensor. </para>
				/// </returns>
				/// <java-name>
				/// getType
				/// </java-name>
				[Dot42.DexImport("getType", "()I", AccessFlags = 1)]
				public new int GetType() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>version of the sensor's module. </para>
				/// </returns>
				/// <java-name>
				/// getVersion
				/// </java-name>
				[Dot42.DexImport("getVersion", "()I", AccessFlags = 1)]
				public int GetVersion() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>maximum range of the sensor in the sensor's unit. </para>
				/// </returns>
				/// <java-name>
				/// getMaximumRange
				/// </java-name>
				[Dot42.DexImport("getMaximumRange", "()F", AccessFlags = 1)]
				public float GetMaximumRange() /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>resolution of the sensor in the sensor's unit. </para>
				/// </returns>
				/// <java-name>
				/// getResolution
				/// </java-name>
				[Dot42.DexImport("getResolution", "()F", AccessFlags = 1)]
				public float GetResolution() /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>the power in mA used by this sensor while in use </para>
				/// </returns>
				/// <java-name>
				/// getPower
				/// </java-name>
				[Dot42.DexImport("getPower", "()F", AccessFlags = 1)]
				public float GetPower() /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>the minimum delay allowed between two events in microsecond or zero if this sensor only returns a value when the data it's measuring changes. </para>
				/// </returns>
				/// <java-name>
				/// getMinDelay
				/// </java-name>
				[Dot42.DexImport("getMinDelay", "()I", AccessFlags = 1)]
				public int GetMinDelay() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getFifoReservedEventCount
				/// </java-name>
				[Dot42.DexImport("getFifoReservedEventCount", "()I", AccessFlags = 1)]
				public int GetFifoReservedEventCount() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getFifoMaxEventCount
				/// </java-name>
				[Dot42.DexImport("getFifoMaxEventCount", "()I", AccessFlags = 1)]
				public int GetFifoMaxEventCount() /* MethodBuilder.Create */ 
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
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>name string of the sensor. </para>
				/// </returns>
				/// <java-name>
				/// getName
				/// </java-name>
				public string Name
				{
				[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetName(); }
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>vendor string of this sensor. </para>
				/// </returns>
				/// <java-name>
				/// getVendor
				/// </java-name>
				public string Vendor
				{
				[Dot42.DexImport("getVendor", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetVendor(); }
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>generic type of this sensor. </para>
				/// </returns>
				/// <java-name>
				/// getType
				/// </java-name>
				public int Type
				{
				[Dot42.DexImport("getType", "()I", AccessFlags = 1)]
						get{ return GetType(); }
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>version of the sensor's module. </para>
				/// </returns>
				/// <java-name>
				/// getVersion
				/// </java-name>
				public int Version
				{
				[Dot42.DexImport("getVersion", "()I", AccessFlags = 1)]
						get{ return GetVersion(); }
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>maximum range of the sensor in the sensor's unit. </para>
				/// </returns>
				/// <java-name>
				/// getMaximumRange
				/// </java-name>
				public float MaximumRange
				{
				[Dot42.DexImport("getMaximumRange", "()F", AccessFlags = 1)]
						get{ return GetMaximumRange(); }
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>resolution of the sensor in the sensor's unit. </para>
				/// </returns>
				/// <java-name>
				/// getResolution
				/// </java-name>
				public float Resolution
				{
				[Dot42.DexImport("getResolution", "()F", AccessFlags = 1)]
						get{ return GetResolution(); }
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>the power in mA used by this sensor while in use </para>
				/// </returns>
				/// <java-name>
				/// getPower
				/// </java-name>
				public float Power
				{
				[Dot42.DexImport("getPower", "()F", AccessFlags = 1)]
						get{ return GetPower(); }
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>the minimum delay allowed between two events in microsecond or zero if this sensor only returns a value when the data it's measuring changes. </para>
				/// </returns>
				/// <java-name>
				/// getMinDelay
				/// </java-name>
				public int MinDelay
				{
				[Dot42.DexImport("getMinDelay", "()I", AccessFlags = 1)]
						get{ return GetMinDelay(); }
				}

				/// <java-name>
				/// getFifoReservedEventCount
				/// </java-name>
				public int FifoReservedEventCount
				{
				[Dot42.DexImport("getFifoReservedEventCount", "()I", AccessFlags = 1)]
						get{ return GetFifoReservedEventCount(); }
				}

				/// <java-name>
				/// getFifoMaxEventCount
				/// </java-name>
				public int FifoMaxEventCount
				{
				[Dot42.DexImport("getFifoMaxEventCount", "()I", AccessFlags = 1)]
						get{ return GetFifoMaxEventCount(); }
				}

		}

		/// <summary>
		/// <para>Estimates magnetic field at a given point on Earth, and in particular, to compute the magnetic declination from true north.</para><para>This uses the World Magnetic Model produced by the United States National Geospatial-Intelligence Agency. More details about the model can be found at . This class currently uses WMM-2010 which is valid until 2015, but should produce acceptable results for several years after that. Future versions of Android may use a newer version of the model. </para>    
		/// </summary>
		/// <java-name>
		/// android/hardware/GeomagneticField
		/// </java-name>
		[Dot42.DexImport("android/hardware/GeomagneticField", AccessFlags = 33)]
		public partial class GeomagneticField
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Estimate the magnetic field at a given point and time.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(FFFJ)V", AccessFlags = 1)]
				public GeomagneticField(float gdLatitudeDeg, float gdLongitudeDeg, float altitudeMeters, long timeMillis) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>The X (northward) component of the magnetic field in nanoteslas. </para>
				/// </returns>
				/// <java-name>
				/// getX
				/// </java-name>
				[Dot42.DexImport("getX", "()F", AccessFlags = 1)]
				public virtual float GetX() /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>The Y (eastward) component of the magnetic field in nanoteslas. </para>
				/// </returns>
				/// <java-name>
				/// getY
				/// </java-name>
				[Dot42.DexImport("getY", "()F", AccessFlags = 1)]
				public virtual float GetY() /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>The Z (downward) component of the magnetic field in nanoteslas. </para>
				/// </returns>
				/// <java-name>
				/// getZ
				/// </java-name>
				[Dot42.DexImport("getZ", "()F", AccessFlags = 1)]
				public virtual float GetZ() /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>The declination of the horizontal component of the magnetic field from true north, in degrees (i.e. positive means the magnetic field is rotated east that much from true north). </para>
				/// </returns>
				/// <java-name>
				/// getDeclination
				/// </java-name>
				[Dot42.DexImport("getDeclination", "()F", AccessFlags = 1)]
				public virtual float GetDeclination() /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>The inclination of the magnetic field in degrees  positive means the magnetic field is rotated downwards. </para>
				/// </returns>
				/// <java-name>
				/// getInclination
				/// </java-name>
				[Dot42.DexImport("getInclination", "()F", AccessFlags = 1)]
				public virtual float GetInclination() /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>Horizontal component of the field strength in nonoteslas. </para>
				/// </returns>
				/// <java-name>
				/// getHorizontalStrength
				/// </java-name>
				[Dot42.DexImport("getHorizontalStrength", "()F", AccessFlags = 1)]
				public virtual float GetHorizontalStrength() /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>Total field strength in nanoteslas. </para>
				/// </returns>
				/// <java-name>
				/// getFieldStrength
				/// </java-name>
				[Dot42.DexImport("getFieldStrength", "()F", AccessFlags = 1)]
				public virtual float GetFieldStrength() /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal GeomagneticField() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>The X (northward) component of the magnetic field in nanoteslas. </para>
				/// </returns>
				/// <java-name>
				/// getX
				/// </java-name>
				public float X
				{
				[Dot42.DexImport("getX", "()F", AccessFlags = 1)]
						get{ return GetX(); }
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>The Y (eastward) component of the magnetic field in nanoteslas. </para>
				/// </returns>
				/// <java-name>
				/// getY
				/// </java-name>
				public float Y
				{
				[Dot42.DexImport("getY", "()F", AccessFlags = 1)]
						get{ return GetY(); }
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>The Z (downward) component of the magnetic field in nanoteslas. </para>
				/// </returns>
				/// <java-name>
				/// getZ
				/// </java-name>
				public float Z
				{
				[Dot42.DexImport("getZ", "()F", AccessFlags = 1)]
						get{ return GetZ(); }
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>The declination of the horizontal component of the magnetic field from true north, in degrees (i.e. positive means the magnetic field is rotated east that much from true north). </para>
				/// </returns>
				/// <java-name>
				/// getDeclination
				/// </java-name>
				public float Declination
				{
				[Dot42.DexImport("getDeclination", "()F", AccessFlags = 1)]
						get{ return GetDeclination(); }
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>The inclination of the magnetic field in degrees  positive means the magnetic field is rotated downwards. </para>
				/// </returns>
				/// <java-name>
				/// getInclination
				/// </java-name>
				public float Inclination
				{
				[Dot42.DexImport("getInclination", "()F", AccessFlags = 1)]
						get{ return GetInclination(); }
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>Horizontal component of the field strength in nonoteslas. </para>
				/// </returns>
				/// <java-name>
				/// getHorizontalStrength
				/// </java-name>
				public float HorizontalStrength
				{
				[Dot42.DexImport("getHorizontalStrength", "()F", AccessFlags = 1)]
						get{ return GetHorizontalStrength(); }
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>Total field strength in nanoteslas. </para>
				/// </returns>
				/// <java-name>
				/// getFieldStrength
				/// </java-name>
				public float FieldStrength
				{
				[Dot42.DexImport("getFieldStrength", "()F", AccessFlags = 1)]
						get{ return GetFieldStrength(); }
				}

		}

}


