#pragma warning disable 1717
namespace Android.Hardware
{
		/// <java-name>
		/// android/hardware/Camera
		/// </java-name>
		[Dot42.DexImport("android/hardware/Camera", AccessFlags = 33)]
		public partial class Camera
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// ACTION_NEW_PICTURE
				/// </java-name>
				[Dot42.DexImport("ACTION_NEW_PICTURE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_NEW_PICTURE = "android.hardware.action.NEW_PICTURE";
				/// <java-name>
				/// ACTION_NEW_VIDEO
				/// </java-name>
				[Dot42.DexImport("ACTION_NEW_VIDEO", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_NEW_VIDEO = "android.hardware.action.NEW_VIDEO";
				/// <java-name>
				/// CAMERA_ERROR_UNKNOWN
				/// </java-name>
				[Dot42.DexImport("CAMERA_ERROR_UNKNOWN", "I", AccessFlags = 25)]
				public const int CAMERA_ERROR_UNKNOWN = 1;
				/// <java-name>
				/// CAMERA_ERROR_SERVER_DIED
				/// </java-name>
				[Dot42.DexImport("CAMERA_ERROR_SERVER_DIED", "I", AccessFlags = 25)]
				public const int CAMERA_ERROR_SERVER_DIED = 100;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal Camera() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getCameraInfo
				/// </java-name>
				[Dot42.DexImport("getCameraInfo", "(ILandroid/hardware/Camera$CameraInfo;)V", AccessFlags = 265)]
				public static void GetCameraInfo(int int32, global::Android.Hardware.Camera.CameraInfo cameraInfo) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// open
				/// </java-name>
				[Dot42.DexImport("open", "(I)Landroid/hardware/Camera;", AccessFlags = 9)]
				public static global::Android.Hardware.Camera Open(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Hardware.Camera);
				}

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

				/// <java-name>
				/// release
				/// </java-name>
				[Dot42.DexImport("release", "()V", AccessFlags = 17)]
				public void Release() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// unlock
				/// </java-name>
				[Dot42.DexImport("unlock", "()V", AccessFlags = 273)]
				public void Unlock() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// lock
				/// </java-name>
				[Dot42.DexImport("lock", "()V", AccessFlags = 273)]
				public void Lock() /* MethodBuilder.Create */ 
				{
				}

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
				public void SetPreviewDisplay(global::Android.Views.ISurfaceHolder surfaceHolder) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setPreviewTexture
				/// </java-name>
				[Dot42.DexImport("setPreviewTexture", "(Landroid/graphics/SurfaceTexture;)V", AccessFlags = 273)]
				public void SetPreviewTexture(global::Android.Graphics.SurfaceTexture surfaceTexture) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// startPreview
				/// </java-name>
				[Dot42.DexImport("startPreview", "()V", AccessFlags = 273)]
				public void StartPreview() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// stopPreview
				/// </java-name>
				[Dot42.DexImport("stopPreview", "()V", AccessFlags = 17)]
				public void StopPreview() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setPreviewCallback
				/// </java-name>
				[Dot42.DexImport("setPreviewCallback", "(Landroid/hardware/Camera$PreviewCallback;)V", AccessFlags = 17)]
				public void SetPreviewCallback(global::Android.Hardware.Camera.IPreviewCallback previewCallback) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setOneShotPreviewCallback
				/// </java-name>
				[Dot42.DexImport("setOneShotPreviewCallback", "(Landroid/hardware/Camera$PreviewCallback;)V", AccessFlags = 17)]
				public void SetOneShotPreviewCallback(global::Android.Hardware.Camera.IPreviewCallback previewCallback) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setPreviewCallbackWithBuffer
				/// </java-name>
				[Dot42.DexImport("setPreviewCallbackWithBuffer", "(Landroid/hardware/Camera$PreviewCallback;)V", AccessFlags = 17)]
				public void SetPreviewCallbackWithBuffer(global::Android.Hardware.Camera.IPreviewCallback previewCallback) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addCallbackBuffer
				/// </java-name>
				[Dot42.DexImport("addCallbackBuffer", "([B)V", AccessFlags = 17)]
				public void AddCallbackBuffer(sbyte[] sByte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addCallbackBuffer
				/// </java-name>
				[Dot42.DexImport("addCallbackBuffer", "([B)V", AccessFlags = 17, IgnoreFromJava = true)]
				public void AddCallbackBuffer(byte[] @byte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// autoFocus
				/// </java-name>
				[Dot42.DexImport("autoFocus", "(Landroid/hardware/Camera$AutoFocusCallback;)V", AccessFlags = 17)]
				public void AutoFocus(global::Android.Hardware.Camera.IAutoFocusCallback autoFocusCallback) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// cancelAutoFocus
				/// </java-name>
				[Dot42.DexImport("cancelAutoFocus", "()V", AccessFlags = 17)]
				public void CancelAutoFocus() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// takePicture
				/// </java-name>
				[Dot42.DexImport("takePicture", "(Landroid/hardware/Camera$ShutterCallback;Landroid/hardware/Camera$PictureCallbac" +
    "k;Landroid/hardware/Camera$PictureCallback;)V", AccessFlags = 17)]
				public void TakePicture(global::Android.Hardware.Camera.IShutterCallback shutterCallback, global::Android.Hardware.Camera.IPictureCallback pictureCallback, global::Android.Hardware.Camera.IPictureCallback pictureCallback1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// takePicture
				/// </java-name>
				[Dot42.DexImport("takePicture", "(Landroid/hardware/Camera$ShutterCallback;Landroid/hardware/Camera$PictureCallbac" +
    "k;Landroid/hardware/Camera$PictureCallback;Landroid/hardware/Camera$PictureCallb" +
    "ack;)V", AccessFlags = 17)]
				public void TakePicture(global::Android.Hardware.Camera.IShutterCallback shutterCallback, global::Android.Hardware.Camera.IPictureCallback pictureCallback, global::Android.Hardware.Camera.IPictureCallback pictureCallback1, global::Android.Hardware.Camera.IPictureCallback pictureCallback2) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// startSmoothZoom
				/// </java-name>
				[Dot42.DexImport("startSmoothZoom", "(I)V", AccessFlags = 273)]
				public void StartSmoothZoom(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// stopSmoothZoom
				/// </java-name>
				[Dot42.DexImport("stopSmoothZoom", "()V", AccessFlags = 273)]
				public void StopSmoothZoom() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setDisplayOrientation
				/// </java-name>
				[Dot42.DexImport("setDisplayOrientation", "(I)V", AccessFlags = 273)]
				public void SetDisplayOrientation(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setZoomChangeListener
				/// </java-name>
				[Dot42.DexImport("setZoomChangeListener", "(Landroid/hardware/Camera$OnZoomChangeListener;)V", AccessFlags = 17)]
				public void SetZoomChangeListener(global::Android.Hardware.Camera.IOnZoomChangeListener onZoomChangeListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setFaceDetectionListener
				/// </java-name>
				[Dot42.DexImport("setFaceDetectionListener", "(Landroid/hardware/Camera$FaceDetectionListener;)V", AccessFlags = 17)]
				public void SetFaceDetectionListener(global::Android.Hardware.Camera.IFaceDetectionListener faceDetectionListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// startFaceDetection
				/// </java-name>
				[Dot42.DexImport("startFaceDetection", "()V", AccessFlags = 17)]
				public void StartFaceDetection() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// stopFaceDetection
				/// </java-name>
				[Dot42.DexImport("stopFaceDetection", "()V", AccessFlags = 17)]
				public void StopFaceDetection() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setErrorCallback
				/// </java-name>
				[Dot42.DexImport("setErrorCallback", "(Landroid/hardware/Camera$ErrorCallback;)V", AccessFlags = 17)]
				public void SetErrorCallback(global::Android.Hardware.Camera.IErrorCallback errorCallback) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setParameters
				/// </java-name>
				[Dot42.DexImport("setParameters", "(Landroid/hardware/Camera$Parameters;)V", AccessFlags = 1)]
				public virtual void SetParameters(global::Android.Hardware.Camera.Parameters parameters) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getParameters
				/// </java-name>
				[Dot42.DexImport("getParameters", "()Landroid/hardware/Camera$Parameters;", AccessFlags = 1)]
				public virtual global::Android.Hardware.Camera.Parameters GetParameters() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Hardware.Camera.Parameters);
				}

				/// <java-name>
				/// getNumberOfCameras
				/// </java-name>
				public static int NumberOfCameras
				{
						[Dot42.DexImport("getNumberOfCameras", "()I", AccessFlags = 265)]
						get{ return default(int); }
				}

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
						/// <java-name>
						/// FLASH_MODE_OFF
						/// </java-name>
						[Dot42.DexImport("FLASH_MODE_OFF", "Ljava/lang/String;", AccessFlags = 25)]
						public const string FLASH_MODE_OFF = "off";
						/// <java-name>
						/// FLASH_MODE_AUTO
						/// </java-name>
						[Dot42.DexImport("FLASH_MODE_AUTO", "Ljava/lang/String;", AccessFlags = 25)]
						public const string FLASH_MODE_AUTO = "auto";
						/// <java-name>
						/// FLASH_MODE_ON
						/// </java-name>
						[Dot42.DexImport("FLASH_MODE_ON", "Ljava/lang/String;", AccessFlags = 25)]
						public const string FLASH_MODE_ON = "on";
						/// <java-name>
						/// FLASH_MODE_RED_EYE
						/// </java-name>
						[Dot42.DexImport("FLASH_MODE_RED_EYE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string FLASH_MODE_RED_EYE = "red-eye";
						/// <java-name>
						/// FLASH_MODE_TORCH
						/// </java-name>
						[Dot42.DexImport("FLASH_MODE_TORCH", "Ljava/lang/String;", AccessFlags = 25)]
						public const string FLASH_MODE_TORCH = "torch";
						/// <java-name>
						/// SCENE_MODE_AUTO
						/// </java-name>
						[Dot42.DexImport("SCENE_MODE_AUTO", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SCENE_MODE_AUTO = "auto";
						/// <java-name>
						/// SCENE_MODE_ACTION
						/// </java-name>
						[Dot42.DexImport("SCENE_MODE_ACTION", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SCENE_MODE_ACTION = "action";
						/// <java-name>
						/// SCENE_MODE_PORTRAIT
						/// </java-name>
						[Dot42.DexImport("SCENE_MODE_PORTRAIT", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SCENE_MODE_PORTRAIT = "portrait";
						/// <java-name>
						/// SCENE_MODE_LANDSCAPE
						/// </java-name>
						[Dot42.DexImport("SCENE_MODE_LANDSCAPE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SCENE_MODE_LANDSCAPE = "landscape";
						/// <java-name>
						/// SCENE_MODE_NIGHT
						/// </java-name>
						[Dot42.DexImport("SCENE_MODE_NIGHT", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SCENE_MODE_NIGHT = "night";
						/// <java-name>
						/// SCENE_MODE_NIGHT_PORTRAIT
						/// </java-name>
						[Dot42.DexImport("SCENE_MODE_NIGHT_PORTRAIT", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SCENE_MODE_NIGHT_PORTRAIT = "night-portrait";
						/// <java-name>
						/// SCENE_MODE_THEATRE
						/// </java-name>
						[Dot42.DexImport("SCENE_MODE_THEATRE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SCENE_MODE_THEATRE = "theatre";
						/// <java-name>
						/// SCENE_MODE_BEACH
						/// </java-name>
						[Dot42.DexImport("SCENE_MODE_BEACH", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SCENE_MODE_BEACH = "beach";
						/// <java-name>
						/// SCENE_MODE_SNOW
						/// </java-name>
						[Dot42.DexImport("SCENE_MODE_SNOW", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SCENE_MODE_SNOW = "snow";
						/// <java-name>
						/// SCENE_MODE_SUNSET
						/// </java-name>
						[Dot42.DexImport("SCENE_MODE_SUNSET", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SCENE_MODE_SUNSET = "sunset";
						/// <java-name>
						/// SCENE_MODE_STEADYPHOTO
						/// </java-name>
						[Dot42.DexImport("SCENE_MODE_STEADYPHOTO", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SCENE_MODE_STEADYPHOTO = "steadyphoto";
						/// <java-name>
						/// SCENE_MODE_FIREWORKS
						/// </java-name>
						[Dot42.DexImport("SCENE_MODE_FIREWORKS", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SCENE_MODE_FIREWORKS = "fireworks";
						/// <java-name>
						/// SCENE_MODE_SPORTS
						/// </java-name>
						[Dot42.DexImport("SCENE_MODE_SPORTS", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SCENE_MODE_SPORTS = "sports";
						/// <java-name>
						/// SCENE_MODE_PARTY
						/// </java-name>
						[Dot42.DexImport("SCENE_MODE_PARTY", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SCENE_MODE_PARTY = "party";
						/// <java-name>
						/// SCENE_MODE_CANDLELIGHT
						/// </java-name>
						[Dot42.DexImport("SCENE_MODE_CANDLELIGHT", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SCENE_MODE_CANDLELIGHT = "candlelight";
						/// <java-name>
						/// SCENE_MODE_BARCODE
						/// </java-name>
						[Dot42.DexImport("SCENE_MODE_BARCODE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SCENE_MODE_BARCODE = "barcode";
						/// <java-name>
						/// FOCUS_MODE_AUTO
						/// </java-name>
						[Dot42.DexImport("FOCUS_MODE_AUTO", "Ljava/lang/String;", AccessFlags = 25)]
						public const string FOCUS_MODE_AUTO = "auto";
						/// <java-name>
						/// FOCUS_MODE_INFINITY
						/// </java-name>
						[Dot42.DexImport("FOCUS_MODE_INFINITY", "Ljava/lang/String;", AccessFlags = 25)]
						public const string FOCUS_MODE_INFINITY = "infinity";
						/// <java-name>
						/// FOCUS_MODE_MACRO
						/// </java-name>
						[Dot42.DexImport("FOCUS_MODE_MACRO", "Ljava/lang/String;", AccessFlags = 25)]
						public const string FOCUS_MODE_MACRO = "macro";
						/// <java-name>
						/// FOCUS_MODE_FIXED
						/// </java-name>
						[Dot42.DexImport("FOCUS_MODE_FIXED", "Ljava/lang/String;", AccessFlags = 25)]
						public const string FOCUS_MODE_FIXED = "fixed";
						/// <java-name>
						/// FOCUS_MODE_EDOF
						/// </java-name>
						[Dot42.DexImport("FOCUS_MODE_EDOF", "Ljava/lang/String;", AccessFlags = 25)]
						public const string FOCUS_MODE_EDOF = "edof";
						/// <java-name>
						/// FOCUS_MODE_CONTINUOUS_VIDEO
						/// </java-name>
						[Dot42.DexImport("FOCUS_MODE_CONTINUOUS_VIDEO", "Ljava/lang/String;", AccessFlags = 25)]
						public const string FOCUS_MODE_CONTINUOUS_VIDEO = "continuous-video";
						/// <java-name>
						/// FOCUS_MODE_CONTINUOUS_PICTURE
						/// </java-name>
						[Dot42.DexImport("FOCUS_MODE_CONTINUOUS_PICTURE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string FOCUS_MODE_CONTINUOUS_PICTURE = "continuous-picture";
						/// <java-name>
						/// FOCUS_DISTANCE_NEAR_INDEX
						/// </java-name>
						[Dot42.DexImport("FOCUS_DISTANCE_NEAR_INDEX", "I", AccessFlags = 25)]
						public const int FOCUS_DISTANCE_NEAR_INDEX = 0;
						/// <java-name>
						/// FOCUS_DISTANCE_OPTIMAL_INDEX
						/// </java-name>
						[Dot42.DexImport("FOCUS_DISTANCE_OPTIMAL_INDEX", "I", AccessFlags = 25)]
						public const int FOCUS_DISTANCE_OPTIMAL_INDEX = 1;
						/// <java-name>
						/// FOCUS_DISTANCE_FAR_INDEX
						/// </java-name>
						[Dot42.DexImport("FOCUS_DISTANCE_FAR_INDEX", "I", AccessFlags = 25)]
						public const int FOCUS_DISTANCE_FAR_INDEX = 2;
						/// <java-name>
						/// PREVIEW_FPS_MIN_INDEX
						/// </java-name>
						[Dot42.DexImport("PREVIEW_FPS_MIN_INDEX", "I", AccessFlags = 25)]
						public const int PREVIEW_FPS_MIN_INDEX = 0;
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

						/// <java-name>
						/// flatten
						/// </java-name>
						[Dot42.DexImport("flatten", "()Ljava/lang/String;", AccessFlags = 1)]
						public virtual string Flatten() /* MethodBuilder.Create */ 
						{
								return default(string);
						}

						/// <java-name>
						/// unflatten
						/// </java-name>
						[Dot42.DexImport("unflatten", "(Ljava/lang/String;)V", AccessFlags = 1)]
						public virtual void Unflatten(string @string) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// remove
						/// </java-name>
						[Dot42.DexImport("remove", "(Ljava/lang/String;)V", AccessFlags = 1)]
						public virtual void Remove(string @string) /* MethodBuilder.Create */ 
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

						/// <java-name>
						/// get
						/// </java-name>
						[Dot42.DexImport("get", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1)]
						public virtual string Get(string @string) /* MethodBuilder.Create */ 
						{
								return default(string);
						}

						/// <java-name>
						/// getInt
						/// </java-name>
						[Dot42.DexImport("getInt", "(Ljava/lang/String;)I", AccessFlags = 1)]
						public virtual int GetInt(string @string) /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <java-name>
						/// setPreviewSize
						/// </java-name>
						[Dot42.DexImport("setPreviewSize", "(II)V", AccessFlags = 1)]
						public virtual void SetPreviewSize(int int32, int int321) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// setJpegThumbnailSize
						/// </java-name>
						[Dot42.DexImport("setJpegThumbnailSize", "(II)V", AccessFlags = 1)]
						public virtual void SetJpegThumbnailSize(int int32, int int321) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// setPreviewFpsRange
						/// </java-name>
						[Dot42.DexImport("setPreviewFpsRange", "(II)V", AccessFlags = 1)]
						public virtual void SetPreviewFpsRange(int int32, int int321) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// getPreviewFpsRange
						/// </java-name>
						[Dot42.DexImport("getPreviewFpsRange", "([I)V", AccessFlags = 1)]
						public virtual void GetPreviewFpsRange(int[] int32) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// setPictureSize
						/// </java-name>
						[Dot42.DexImport("setPictureSize", "(II)V", AccessFlags = 1)]
						public virtual void SetPictureSize(int int32, int int321) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// setRotation
						/// </java-name>
						[Dot42.DexImport("setRotation", "(I)V", AccessFlags = 1)]
						public virtual void SetRotation(int int32) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// setGpsLatitude
						/// </java-name>
						[Dot42.DexImport("setGpsLatitude", "(D)V", AccessFlags = 1)]
						public virtual void SetGpsLatitude(double @double) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// setGpsLongitude
						/// </java-name>
						[Dot42.DexImport("setGpsLongitude", "(D)V", AccessFlags = 1)]
						public virtual void SetGpsLongitude(double @double) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// setGpsAltitude
						/// </java-name>
						[Dot42.DexImport("setGpsAltitude", "(D)V", AccessFlags = 1)]
						public virtual void SetGpsAltitude(double @double) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// setGpsTimestamp
						/// </java-name>
						[Dot42.DexImport("setGpsTimestamp", "(J)V", AccessFlags = 1)]
						public virtual void SetGpsTimestamp(long int64) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// setGpsProcessingMethod
						/// </java-name>
						[Dot42.DexImport("setGpsProcessingMethod", "(Ljava/lang/String;)V", AccessFlags = 1)]
						public virtual void SetGpsProcessingMethod(string @string) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// removeGpsData
						/// </java-name>
						[Dot42.DexImport("removeGpsData", "()V", AccessFlags = 1)]
						public virtual void RemoveGpsData() /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// getFocusDistances
						/// </java-name>
						[Dot42.DexImport("getFocusDistances", "([F)V", AccessFlags = 1)]
						public virtual void GetFocusDistances(float[] single) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// setRecordingHint
						/// </java-name>
						[Dot42.DexImport("setRecordingHint", "(Z)V", AccessFlags = 1)]
						public virtual void SetRecordingHint(bool boolean) /* MethodBuilder.Create */ 
						{
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal Parameters() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

						/// <java-name>
						/// getPreviewSize
						/// </java-name>
						public virtual global::Android.Hardware.Camera.Size PreviewSize
						{
								[Dot42.DexImport("getPreviewSize", "()Landroid/hardware/Camera$Size;", AccessFlags = 1)]
								get{ return default(global::Android.Hardware.Camera.Size); }
						}

						/// <java-name>
						/// getSupportedPreviewSizes
						/// </java-name>
						public virtual global::Java.Util.IList<global::Android.Hardware.Camera.Size> SupportedPreviewSizes
						{
								[Dot42.DexImport("getSupportedPreviewSizes", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Landroid/hardware/Camera$Size;>;")]
								get{ return default(global::Java.Util.IList<global::Android.Hardware.Camera.Size>); }
						}

						/// <java-name>
						/// getSupportedVideoSizes
						/// </java-name>
						public virtual global::Java.Util.IList<global::Android.Hardware.Camera.Size> SupportedVideoSizes
						{
								[Dot42.DexImport("getSupportedVideoSizes", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Landroid/hardware/Camera$Size;>;")]
								get{ return default(global::Java.Util.IList<global::Android.Hardware.Camera.Size>); }
						}

						/// <java-name>
						/// getPreferredPreviewSizeForVideo
						/// </java-name>
						public virtual global::Android.Hardware.Camera.Size PreferredPreviewSizeForVideo
						{
								[Dot42.DexImport("getPreferredPreviewSizeForVideo", "()Landroid/hardware/Camera$Size;", AccessFlags = 1)]
								get{ return default(global::Android.Hardware.Camera.Size); }
						}

						/// <java-name>
						/// getJpegThumbnailSize
						/// </java-name>
						public virtual global::Android.Hardware.Camera.Size JpegThumbnailSize
						{
								[Dot42.DexImport("getJpegThumbnailSize", "()Landroid/hardware/Camera$Size;", AccessFlags = 1)]
								get{ return default(global::Android.Hardware.Camera.Size); }
						}

						/// <java-name>
						/// getSupportedJpegThumbnailSizes
						/// </java-name>
						public virtual global::Java.Util.IList<global::Android.Hardware.Camera.Size> SupportedJpegThumbnailSizes
						{
								[Dot42.DexImport("getSupportedJpegThumbnailSizes", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Landroid/hardware/Camera$Size;>;")]
								get{ return default(global::Java.Util.IList<global::Android.Hardware.Camera.Size>); }
						}

						/// <java-name>
						/// getJpegThumbnailQuality
						/// </java-name>
						public virtual int JpegThumbnailQuality
						{
								[Dot42.DexImport("getJpegThumbnailQuality", "()I", AccessFlags = 1)]
								get{ return default(int); }
								[Dot42.DexImport("setJpegThumbnailQuality", "(I)V", AccessFlags = 1)]
								set{ }
						}

						/// <java-name>
						/// getJpegQuality
						/// </java-name>
						public virtual int JpegQuality
						{
								[Dot42.DexImport("getJpegQuality", "()I", AccessFlags = 1)]
								get{ return default(int); }
								[Dot42.DexImport("setJpegQuality", "(I)V", AccessFlags = 1)]
								set{ }
						}

						/// <java-name>
						/// getPreviewFrameRate
						/// </java-name>
						public virtual int PreviewFrameRate
						{
								[Dot42.DexImport("getPreviewFrameRate", "()I", AccessFlags = 1)]
								get{ return default(int); }
								[Dot42.DexImport("setPreviewFrameRate", "(I)V", AccessFlags = 1)]
								set{ }
						}

						/// <java-name>
						/// getSupportedPreviewFrameRates
						/// </java-name>
						public virtual global::Java.Util.IList<int?> SupportedPreviewFrameRates
						{
								[Dot42.DexImport("getSupportedPreviewFrameRates", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Ljava/lang/Integer;>;")]
								get{ return default(global::Java.Util.IList<int?>); }
						}

						/// <java-name>
						/// getSupportedPreviewFpsRange
						/// </java-name>
						public virtual global::Java.Util.IList<int[]> SupportedPreviewFpsRange
						{
								[Dot42.DexImport("getSupportedPreviewFpsRange", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<[I>;")]
								get{ return default(global::Java.Util.IList<int[]>); }
						}

						/// <java-name>
						/// getPreviewFormat
						/// </java-name>
						public virtual int PreviewFormat
						{
								[Dot42.DexImport("getPreviewFormat", "()I", AccessFlags = 1)]
								get{ return default(int); }
								[Dot42.DexImport("setPreviewFormat", "(I)V", AccessFlags = 1)]
								set{ }
						}

						/// <java-name>
						/// getSupportedPreviewFormats
						/// </java-name>
						public virtual global::Java.Util.IList<int?> SupportedPreviewFormats
						{
								[Dot42.DexImport("getSupportedPreviewFormats", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Ljava/lang/Integer;>;")]
								get{ return default(global::Java.Util.IList<int?>); }
						}

						/// <java-name>
						/// getPictureSize
						/// </java-name>
						public virtual global::Android.Hardware.Camera.Size PictureSize
						{
								[Dot42.DexImport("getPictureSize", "()Landroid/hardware/Camera$Size;", AccessFlags = 1)]
								get{ return default(global::Android.Hardware.Camera.Size); }
						}

						/// <java-name>
						/// getSupportedPictureSizes
						/// </java-name>
						public virtual global::Java.Util.IList<global::Android.Hardware.Camera.Size> SupportedPictureSizes
						{
								[Dot42.DexImport("getSupportedPictureSizes", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Landroid/hardware/Camera$Size;>;")]
								get{ return default(global::Java.Util.IList<global::Android.Hardware.Camera.Size>); }
						}

						/// <java-name>
						/// getPictureFormat
						/// </java-name>
						public virtual int PictureFormat
						{
								[Dot42.DexImport("getPictureFormat", "()I", AccessFlags = 1)]
								get{ return default(int); }
								[Dot42.DexImport("setPictureFormat", "(I)V", AccessFlags = 1)]
								set{ }
						}

						/// <java-name>
						/// getSupportedPictureFormats
						/// </java-name>
						public virtual global::Java.Util.IList<int?> SupportedPictureFormats
						{
								[Dot42.DexImport("getSupportedPictureFormats", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Ljava/lang/Integer;>;")]
								get{ return default(global::Java.Util.IList<int?>); }
						}

						/// <java-name>
						/// getWhiteBalance
						/// </java-name>
						public virtual string WhiteBalance
						{
								[Dot42.DexImport("getWhiteBalance", "()Ljava/lang/String;", AccessFlags = 1)]
								get{ return default(string); }
								[Dot42.DexImport("setWhiteBalance", "(Ljava/lang/String;)V", AccessFlags = 1)]
								set{ }
						}

						/// <java-name>
						/// getSupportedWhiteBalance
						/// </java-name>
						public virtual global::Java.Util.IList<string> SupportedWhiteBalance
						{
								[Dot42.DexImport("getSupportedWhiteBalance", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Ljava/lang/String;>;")]
								get{ return default(global::Java.Util.IList<string>); }
						}

						/// <java-name>
						/// getColorEffect
						/// </java-name>
						public virtual string ColorEffect
						{
								[Dot42.DexImport("getColorEffect", "()Ljava/lang/String;", AccessFlags = 1)]
								get{ return default(string); }
								[Dot42.DexImport("setColorEffect", "(Ljava/lang/String;)V", AccessFlags = 1)]
								set{ }
						}

						/// <java-name>
						/// getSupportedColorEffects
						/// </java-name>
						public virtual global::Java.Util.IList<string> SupportedColorEffects
						{
								[Dot42.DexImport("getSupportedColorEffects", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Ljava/lang/String;>;")]
								get{ return default(global::Java.Util.IList<string>); }
						}

						/// <java-name>
						/// getAntibanding
						/// </java-name>
						public virtual string Antibanding
						{
								[Dot42.DexImport("getAntibanding", "()Ljava/lang/String;", AccessFlags = 1)]
								get{ return default(string); }
								[Dot42.DexImport("setAntibanding", "(Ljava/lang/String;)V", AccessFlags = 1)]
								set{ }
						}

						/// <java-name>
						/// getSupportedAntibanding
						/// </java-name>
						public virtual global::Java.Util.IList<string> SupportedAntibanding
						{
								[Dot42.DexImport("getSupportedAntibanding", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Ljava/lang/String;>;")]
								get{ return default(global::Java.Util.IList<string>); }
						}

						/// <java-name>
						/// getSceneMode
						/// </java-name>
						public virtual string SceneMode
						{
								[Dot42.DexImport("getSceneMode", "()Ljava/lang/String;", AccessFlags = 1)]
								get{ return default(string); }
								[Dot42.DexImport("setSceneMode", "(Ljava/lang/String;)V", AccessFlags = 1)]
								set{ }
						}

						/// <java-name>
						/// getSupportedSceneModes
						/// </java-name>
						public virtual global::Java.Util.IList<string> SupportedSceneModes
						{
								[Dot42.DexImport("getSupportedSceneModes", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Ljava/lang/String;>;")]
								get{ return default(global::Java.Util.IList<string>); }
						}

						/// <java-name>
						/// getFlashMode
						/// </java-name>
						public virtual string FlashMode
						{
								[Dot42.DexImport("getFlashMode", "()Ljava/lang/String;", AccessFlags = 1)]
								get{ return default(string); }
								[Dot42.DexImport("setFlashMode", "(Ljava/lang/String;)V", AccessFlags = 1)]
								set{ }
						}

						/// <java-name>
						/// getSupportedFlashModes
						/// </java-name>
						public virtual global::Java.Util.IList<string> SupportedFlashModes
						{
								[Dot42.DexImport("getSupportedFlashModes", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Ljava/lang/String;>;")]
								get{ return default(global::Java.Util.IList<string>); }
						}

						/// <java-name>
						/// getFocusMode
						/// </java-name>
						public virtual string FocusMode
						{
								[Dot42.DexImport("getFocusMode", "()Ljava/lang/String;", AccessFlags = 1)]
								get{ return default(string); }
								[Dot42.DexImport("setFocusMode", "(Ljava/lang/String;)V", AccessFlags = 1)]
								set{ }
						}

						/// <java-name>
						/// getSupportedFocusModes
						/// </java-name>
						public virtual global::Java.Util.IList<string> SupportedFocusModes
						{
								[Dot42.DexImport("getSupportedFocusModes", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Ljava/lang/String;>;")]
								get{ return default(global::Java.Util.IList<string>); }
						}

						/// <java-name>
						/// getFocalLength
						/// </java-name>
						public virtual float FocalLength
						{
								[Dot42.DexImport("getFocalLength", "()F", AccessFlags = 1)]
								get{ return default(float); }
						}

						/// <java-name>
						/// getHorizontalViewAngle
						/// </java-name>
						public virtual float HorizontalViewAngle
						{
								[Dot42.DexImport("getHorizontalViewAngle", "()F", AccessFlags = 1)]
								get{ return default(float); }
						}

						/// <java-name>
						/// getVerticalViewAngle
						/// </java-name>
						public virtual float VerticalViewAngle
						{
								[Dot42.DexImport("getVerticalViewAngle", "()F", AccessFlags = 1)]
								get{ return default(float); }
						}

						/// <java-name>
						/// getExposureCompensation
						/// </java-name>
						public virtual int ExposureCompensation
						{
								[Dot42.DexImport("getExposureCompensation", "()I", AccessFlags = 1)]
								get{ return default(int); }
								[Dot42.DexImport("setExposureCompensation", "(I)V", AccessFlags = 1)]
								set{ }
						}

						/// <java-name>
						/// getMaxExposureCompensation
						/// </java-name>
						public virtual int MaxExposureCompensation
						{
								[Dot42.DexImport("getMaxExposureCompensation", "()I", AccessFlags = 1)]
								get{ return default(int); }
						}

						/// <java-name>
						/// getMinExposureCompensation
						/// </java-name>
						public virtual int MinExposureCompensation
						{
								[Dot42.DexImport("getMinExposureCompensation", "()I", AccessFlags = 1)]
								get{ return default(int); }
						}

						/// <java-name>
						/// getExposureCompensationStep
						/// </java-name>
						public virtual float ExposureCompensationStep
						{
								[Dot42.DexImport("getExposureCompensationStep", "()F", AccessFlags = 1)]
								get{ return default(float); }
						}

						/// <java-name>
						/// getAutoExposureLock
						/// </java-name>
						public virtual bool IsAutoExposureLock
						{
								[Dot42.DexImport("getAutoExposureLock", "()Z", AccessFlags = 1)]
								get{ return default(bool); }
								[Dot42.DexImport("setAutoExposureLock", "(Z)V", AccessFlags = 1)]
								set{ }
						}

						/// <java-name>
						/// isAutoExposureLockSupported
						/// </java-name>
						public virtual bool IsAutoExposureLockSupported
						{
								[Dot42.DexImport("isAutoExposureLockSupported", "()Z", AccessFlags = 1)]
								get{ return default(bool); }
						}

						/// <java-name>
						/// getAutoWhiteBalanceLock
						/// </java-name>
						public virtual bool IsAutoWhiteBalanceLock
						{
								[Dot42.DexImport("getAutoWhiteBalanceLock", "()Z", AccessFlags = 1)]
								get{ return default(bool); }
								[Dot42.DexImport("setAutoWhiteBalanceLock", "(Z)V", AccessFlags = 1)]
								set{ }
						}

						/// <java-name>
						/// isAutoWhiteBalanceLockSupported
						/// </java-name>
						public virtual bool IsAutoWhiteBalanceLockSupported
						{
								[Dot42.DexImport("isAutoWhiteBalanceLockSupported", "()Z", AccessFlags = 1)]
								get{ return default(bool); }
						}

						/// <java-name>
						/// getZoom
						/// </java-name>
						public virtual int Zoom
						{
								[Dot42.DexImport("getZoom", "()I", AccessFlags = 1)]
								get{ return default(int); }
								[Dot42.DexImport("setZoom", "(I)V", AccessFlags = 1)]
								set{ }
						}

						/// <java-name>
						/// isZoomSupported
						/// </java-name>
						public virtual bool IsZoomSupported
						{
								[Dot42.DexImport("isZoomSupported", "()Z", AccessFlags = 1)]
								get{ return default(bool); }
						}

						/// <java-name>
						/// getMaxZoom
						/// </java-name>
						public virtual int MaxZoom
						{
								[Dot42.DexImport("getMaxZoom", "()I", AccessFlags = 1)]
								get{ return default(int); }
						}

						/// <java-name>
						/// getZoomRatios
						/// </java-name>
						public virtual global::Java.Util.IList<int?> ZoomRatios
						{
								[Dot42.DexImport("getZoomRatios", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Ljava/lang/Integer;>;")]
								get{ return default(global::Java.Util.IList<int?>); }
						}

						/// <java-name>
						/// isSmoothZoomSupported
						/// </java-name>
						public virtual bool IsSmoothZoomSupported
						{
								[Dot42.DexImport("isSmoothZoomSupported", "()Z", AccessFlags = 1)]
								get{ return default(bool); }
						}

						/// <java-name>
						/// getMaxNumFocusAreas
						/// </java-name>
						public virtual int MaxNumFocusAreas
						{
								[Dot42.DexImport("getMaxNumFocusAreas", "()I", AccessFlags = 1)]
								get{ return default(int); }
						}

						/// <java-name>
						/// getFocusAreas
						/// </java-name>
						public virtual global::Java.Util.IList<global::Android.Hardware.Camera.Area> FocusAreas
						{
								[Dot42.DexImport("getFocusAreas", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Landroid/hardware/Camera$Area;>;")]
								get{ return default(global::Java.Util.IList<global::Android.Hardware.Camera.Area>); }
								[Dot42.DexImport("setFocusAreas", "(Ljava/util/List;)V", AccessFlags = 1, Signature = "(Ljava/util/List<Landroid/hardware/Camera$Area;>;)V")]
								set{ }
						}

						/// <java-name>
						/// getMaxNumMeteringAreas
						/// </java-name>
						public virtual int MaxNumMeteringAreas
						{
								[Dot42.DexImport("getMaxNumMeteringAreas", "()I", AccessFlags = 1)]
								get{ return default(int); }
						}

						/// <java-name>
						/// getMeteringAreas
						/// </java-name>
						public virtual global::Java.Util.IList<global::Android.Hardware.Camera.Area> MeteringAreas
						{
								[Dot42.DexImport("getMeteringAreas", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Landroid/hardware/Camera$Area;>;")]
								get{ return default(global::Java.Util.IList<global::Android.Hardware.Camera.Area>); }
								[Dot42.DexImport("setMeteringAreas", "(Ljava/util/List;)V", AccessFlags = 1, Signature = "(Ljava/util/List<Landroid/hardware/Camera$Area;>;)V")]
								set{ }
						}

						/// <java-name>
						/// getMaxNumDetectedFaces
						/// </java-name>
						public virtual int MaxNumDetectedFaces
						{
								[Dot42.DexImport("getMaxNumDetectedFaces", "()I", AccessFlags = 1)]
								get{ return default(int); }
						}

						/// <java-name>
						/// isVideoSnapshotSupported
						/// </java-name>
						public virtual bool IsVideoSnapshotSupported
						{
								[Dot42.DexImport("isVideoSnapshotSupported", "()Z", AccessFlags = 1)]
								get{ return default(bool); }
						}

						/// <java-name>
						/// getVideoStabilization
						/// </java-name>
						public virtual bool IsVideoStabilization
						{
								[Dot42.DexImport("getVideoStabilization", "()Z", AccessFlags = 1)]
								get{ return default(bool); }
								[Dot42.DexImport("setVideoStabilization", "(Z)V", AccessFlags = 1)]
								set{ }
						}

						/// <java-name>
						/// isVideoStabilizationSupported
						/// </java-name>
						public virtual bool IsVideoStabilizationSupported
						{
								[Dot42.DexImport("isVideoStabilizationSupported", "()Z", AccessFlags = 1)]
								get{ return default(bool); }
						}

				}

				/// <java-name>
				/// android/hardware/Camera$Area
				/// </java-name>
				[Dot42.DexImport("android/hardware/Camera$Area", AccessFlags = 9)]
				public partial class Area
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// rect
						/// </java-name>
						[Dot42.DexImport("rect", "Landroid/graphics/Rect;", AccessFlags = 1)]
						public global::Android.Graphics.Rect Rect;
						/// <java-name>
						/// weight
						/// </java-name>
						[Dot42.DexImport("weight", "I", AccessFlags = 1)]
						public int Weight;
						[Dot42.DexImport("<init>", "(Landroid/graphics/Rect;I)V", AccessFlags = 1)]
						public Area(global::Android.Graphics.Rect rect, int int32) /* MethodBuilder.Create */ 
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
						internal Area() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

				}

				/// <java-name>
				/// android/hardware/Camera$Size
				/// </java-name>
				[Dot42.DexImport("android/hardware/Camera$Size", AccessFlags = 1)]
				public partial class Size
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// width
						/// </java-name>
						[Dot42.DexImport("width", "I", AccessFlags = 1)]
						public int Width;
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
						internal Size() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

				}

				/// <java-name>
				/// android/hardware/Camera$ErrorCallback
				/// </java-name>
				[Dot42.DexImport("android/hardware/Camera$ErrorCallback", AccessFlags = 1545)]
				public partial interface IErrorCallback
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onError
						/// </java-name>
						[Dot42.DexImport("onError", "(ILandroid/hardware/Camera;)V", AccessFlags = 1025)]
						void OnError(int int32, global::Android.Hardware.Camera camera) /* MethodBuilder.Create */ ;

				}

				/// <java-name>
				/// android/hardware/Camera$Face
				/// </java-name>
				[Dot42.DexImport("android/hardware/Camera$Face", AccessFlags = 9)]
				public partial class Face
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// rect
						/// </java-name>
						[Dot42.DexImport("rect", "Landroid/graphics/Rect;", AccessFlags = 1)]
						public global::Android.Graphics.Rect Rect;
						/// <java-name>
						/// score
						/// </java-name>
						[Dot42.DexImport("score", "I", AccessFlags = 1)]
						public int Score;
						/// <java-name>
						/// id
						/// </java-name>
						[Dot42.DexImport("id", "I", AccessFlags = 1)]
						public int Id;
						/// <java-name>
						/// leftEye
						/// </java-name>
						[Dot42.DexImport("leftEye", "Landroid/graphics/Point;", AccessFlags = 1)]
						public global::Android.Graphics.Point LeftEye;
						/// <java-name>
						/// rightEye
						/// </java-name>
						[Dot42.DexImport("rightEye", "Landroid/graphics/Point;", AccessFlags = 1)]
						public global::Android.Graphics.Point RightEye;
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

				/// <java-name>
				/// android/hardware/Camera$FaceDetectionListener
				/// </java-name>
				[Dot42.DexImport("android/hardware/Camera$FaceDetectionListener", AccessFlags = 1545)]
				public partial interface IFaceDetectionListener
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onFaceDetection
						/// </java-name>
						[Dot42.DexImport("onFaceDetection", "([Landroid/hardware/Camera$Face;Landroid/hardware/Camera;)V", AccessFlags = 1025)]
						void OnFaceDetection(global::Android.Hardware.Camera.Face[] face, global::Android.Hardware.Camera camera) /* MethodBuilder.Create */ ;

				}

				/// <java-name>
				/// android/hardware/Camera$OnZoomChangeListener
				/// </java-name>
				[Dot42.DexImport("android/hardware/Camera$OnZoomChangeListener", AccessFlags = 1545)]
				public partial interface IOnZoomChangeListener
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onZoomChange
						/// </java-name>
						[Dot42.DexImport("onZoomChange", "(IZLandroid/hardware/Camera;)V", AccessFlags = 1025)]
						void OnZoomChange(int int32, bool boolean, global::Android.Hardware.Camera camera) /* MethodBuilder.Create */ ;

				}

				/// <java-name>
				/// android/hardware/Camera$PictureCallback
				/// </java-name>
				[Dot42.DexImport("android/hardware/Camera$PictureCallback", AccessFlags = 1545)]
				public partial interface IPictureCallback
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onPictureTaken
						/// </java-name>
						[Dot42.DexImport("onPictureTaken", "([BLandroid/hardware/Camera;)V", AccessFlags = 1025)]
						void OnPictureTaken(sbyte[] sByte, global::Android.Hardware.Camera camera) /* MethodBuilder.Create */ ;

				}

				/// <java-name>
				/// android/hardware/Camera$ShutterCallback
				/// </java-name>
				[Dot42.DexImport("android/hardware/Camera$ShutterCallback", AccessFlags = 1545)]
				public partial interface IShutterCallback
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onShutter
						/// </java-name>
						[Dot42.DexImport("onShutter", "()V", AccessFlags = 1025)]
						void OnShutter() /* MethodBuilder.Create */ ;

				}

				/// <java-name>
				/// android/hardware/Camera$AutoFocusCallback
				/// </java-name>
				[Dot42.DexImport("android/hardware/Camera$AutoFocusCallback", AccessFlags = 1545)]
				public partial interface IAutoFocusCallback
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onAutoFocus
						/// </java-name>
						[Dot42.DexImport("onAutoFocus", "(ZLandroid/hardware/Camera;)V", AccessFlags = 1025)]
						void OnAutoFocus(bool boolean, global::Android.Hardware.Camera camera) /* MethodBuilder.Create */ ;

				}

				/// <java-name>
				/// android/hardware/Camera$PreviewCallback
				/// </java-name>
				[Dot42.DexImport("android/hardware/Camera$PreviewCallback", AccessFlags = 1545)]
				public partial interface IPreviewCallback
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onPreviewFrame
						/// </java-name>
						[Dot42.DexImport("onPreviewFrame", "([BLandroid/hardware/Camera;)V", AccessFlags = 1025)]
						void OnPreviewFrame(sbyte[] sByte, global::Android.Hardware.Camera camera) /* MethodBuilder.Create */ ;

				}

				/// <java-name>
				/// android/hardware/Camera$CameraInfo
				/// </java-name>
				[Dot42.DexImport("android/hardware/Camera$CameraInfo", AccessFlags = 9)]
				public partial class CameraInfo
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// CAMERA_FACING_BACK
						/// </java-name>
						[Dot42.DexImport("CAMERA_FACING_BACK", "I", AccessFlags = 25)]
						public const int CAMERA_FACING_BACK = 0;
						/// <java-name>
						/// CAMERA_FACING_FRONT
						/// </java-name>
						[Dot42.DexImport("CAMERA_FACING_FRONT", "I", AccessFlags = 25)]
						public const int CAMERA_FACING_FRONT = 1;
						/// <java-name>
						/// facing
						/// </java-name>
						[Dot42.DexImport("facing", "I", AccessFlags = 1)]
						public int Facing;
						/// <java-name>
						/// orientation
						/// </java-name>
						[Dot42.DexImport("orientation", "I", AccessFlags = 1)]
						public int Orientation;
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public CameraInfo() /* MethodBuilder.Create */ 
						{
						}

				}

		}

		/// <java-name>
		/// android/hardware/GeomagneticField
		/// </java-name>
		[Dot42.DexImport("android/hardware/GeomagneticField", AccessFlags = 33)]
		public partial class GeomagneticField
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(FFFJ)V", AccessFlags = 1)]
				public GeomagneticField(float single, float single1, float single2, long int64) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal GeomagneticField() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getX
				/// </java-name>
				public virtual float X
				{
						[Dot42.DexImport("getX", "()F", AccessFlags = 1)]
						get{ return default(float); }
				}

				/// <java-name>
				/// getY
				/// </java-name>
				public virtual float Y
				{
						[Dot42.DexImport("getY", "()F", AccessFlags = 1)]
						get{ return default(float); }
				}

				/// <java-name>
				/// getZ
				/// </java-name>
				public virtual float Z
				{
						[Dot42.DexImport("getZ", "()F", AccessFlags = 1)]
						get{ return default(float); }
				}

				/// <java-name>
				/// getDeclination
				/// </java-name>
				public virtual float Declination
				{
						[Dot42.DexImport("getDeclination", "()F", AccessFlags = 1)]
						get{ return default(float); }
				}

				/// <java-name>
				/// getInclination
				/// </java-name>
				public virtual float Inclination
				{
						[Dot42.DexImport("getInclination", "()F", AccessFlags = 1)]
						get{ return default(float); }
				}

				/// <java-name>
				/// getHorizontalStrength
				/// </java-name>
				public virtual float HorizontalStrength
				{
						[Dot42.DexImport("getHorizontalStrength", "()F", AccessFlags = 1)]
						get{ return default(float); }
				}

				/// <java-name>
				/// getFieldStrength
				/// </java-name>
				public virtual float FieldStrength
				{
						[Dot42.DexImport("getFieldStrength", "()F", AccessFlags = 1)]
						get{ return default(float); }
				}

		}

		/// <java-name>
		/// android/hardware/SensorEventListener
		/// </java-name>
		[Dot42.DexImport("android/hardware/SensorEventListener", AccessFlags = 1537)]
		public partial interface ISensorEventListener
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// onSensorChanged
				/// </java-name>
				[Dot42.DexImport("onSensorChanged", "(Landroid/hardware/SensorEvent;)V", AccessFlags = 1025)]
				void OnSensorChanged(global::Android.Hardware.SensorEvent sensorEvent) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// onAccuracyChanged
				/// </java-name>
				[Dot42.DexImport("onAccuracyChanged", "(Landroid/hardware/Sensor;I)V", AccessFlags = 1025)]
				void OnAccuracyChanged(global::Android.Hardware.Sensor sensor, int int32) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// android/hardware/SensorListener
		/// </java-name>
		[Dot42.DexImport("android/hardware/SensorListener", AccessFlags = 1537)]
		public partial interface ISensorListener
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// onSensorChanged
				/// </java-name>
				[Dot42.DexImport("onSensorChanged", "(I[F)V", AccessFlags = 1025)]
				void OnSensorChanged(int int32, float[] single) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// onAccuracyChanged
				/// </java-name>
				[Dot42.DexImport("onAccuracyChanged", "(II)V", AccessFlags = 1025)]
				void OnAccuracyChanged(int int32, int int321) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// android/hardware/Sensor
		/// </java-name>
		[Dot42.DexImport("android/hardware/Sensor", AccessFlags = 33)]
		public partial class Sensor
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// TYPE_ACCELEROMETER
				/// </java-name>
				[Dot42.DexImport("TYPE_ACCELEROMETER", "I", AccessFlags = 25)]
				public const int TYPE_ACCELEROMETER = 1;
				/// <java-name>
				/// TYPE_MAGNETIC_FIELD
				/// </java-name>
				[Dot42.DexImport("TYPE_MAGNETIC_FIELD", "I", AccessFlags = 25)]
				public const int TYPE_MAGNETIC_FIELD = 2;
				/// <java-name>
				/// TYPE_ORIENTATION
				/// </java-name>
				[Dot42.DexImport("TYPE_ORIENTATION", "I", AccessFlags = 25)]
				public const int TYPE_ORIENTATION = 3;
				/// <java-name>
				/// TYPE_GYROSCOPE
				/// </java-name>
				[Dot42.DexImport("TYPE_GYROSCOPE", "I", AccessFlags = 25)]
				public const int TYPE_GYROSCOPE = 4;
				/// <java-name>
				/// TYPE_LIGHT
				/// </java-name>
				[Dot42.DexImport("TYPE_LIGHT", "I", AccessFlags = 25)]
				public const int TYPE_LIGHT = 5;
				/// <java-name>
				/// TYPE_PRESSURE
				/// </java-name>
				[Dot42.DexImport("TYPE_PRESSURE", "I", AccessFlags = 25)]
				public const int TYPE_PRESSURE = 6;
				/// <java-name>
				/// TYPE_TEMPERATURE
				/// </java-name>
				[Dot42.DexImport("TYPE_TEMPERATURE", "I", AccessFlags = 25)]
				public const int TYPE_TEMPERATURE = 7;
				/// <java-name>
				/// TYPE_PROXIMITY
				/// </java-name>
				[Dot42.DexImport("TYPE_PROXIMITY", "I", AccessFlags = 25)]
				public const int TYPE_PROXIMITY = 8;
				/// <java-name>
				/// TYPE_GRAVITY
				/// </java-name>
				[Dot42.DexImport("TYPE_GRAVITY", "I", AccessFlags = 25)]
				public const int TYPE_GRAVITY = 9;
				/// <java-name>
				/// TYPE_LINEAR_ACCELERATION
				/// </java-name>
				[Dot42.DexImport("TYPE_LINEAR_ACCELERATION", "I", AccessFlags = 25)]
				public const int TYPE_LINEAR_ACCELERATION = 10;
				/// <java-name>
				/// TYPE_ROTATION_VECTOR
				/// </java-name>
				[Dot42.DexImport("TYPE_ROTATION_VECTOR", "I", AccessFlags = 25)]
				public const int TYPE_ROTATION_VECTOR = 11;
				/// <java-name>
				/// TYPE_RELATIVE_HUMIDITY
				/// </java-name>
				[Dot42.DexImport("TYPE_RELATIVE_HUMIDITY", "I", AccessFlags = 25)]
				public const int TYPE_RELATIVE_HUMIDITY = 12;
				/// <java-name>
				/// TYPE_AMBIENT_TEMPERATURE
				/// </java-name>
				[Dot42.DexImport("TYPE_AMBIENT_TEMPERATURE", "I", AccessFlags = 25)]
				public const int TYPE_AMBIENT_TEMPERATURE = 13;
				/// <java-name>
				/// TYPE_ALL
				/// </java-name>
				[Dot42.DexImport("TYPE_ALL", "I", AccessFlags = 25)]
				public const int TYPE_ALL = -1;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal Sensor() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getName
				/// </java-name>
				public virtual string Name
				{
						[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getVendor
				/// </java-name>
				public virtual string Vendor
				{
						[Dot42.DexImport("getVendor", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
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
				/// getVersion
				/// </java-name>
				public virtual int Version
				{
						[Dot42.DexImport("getVersion", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getMaximumRange
				/// </java-name>
				public virtual float MaximumRange
				{
						[Dot42.DexImport("getMaximumRange", "()F", AccessFlags = 1)]
						get{ return default(float); }
				}

				/// <java-name>
				/// getResolution
				/// </java-name>
				public virtual float Resolution
				{
						[Dot42.DexImport("getResolution", "()F", AccessFlags = 1)]
						get{ return default(float); }
				}

				/// <java-name>
				/// getPower
				/// </java-name>
				public virtual float Power
				{
						[Dot42.DexImport("getPower", "()F", AccessFlags = 1)]
						get{ return default(float); }
				}

				/// <java-name>
				/// getMinDelay
				/// </java-name>
				public virtual int MinDelay
				{
						[Dot42.DexImport("getMinDelay", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

		}

		/// <java-name>
		/// android/hardware/SensorEvent
		/// </java-name>
		[Dot42.DexImport("android/hardware/SensorEvent", AccessFlags = 33)]
		public partial class SensorEvent
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// values
				/// </java-name>
				[Dot42.DexImport("values", "[F", AccessFlags = 17)]
				public readonly float[] Values;
				/// <java-name>
				/// sensor
				/// </java-name>
				[Dot42.DexImport("sensor", "Landroid/hardware/Sensor;", AccessFlags = 1)]
				public global::Android.Hardware.Sensor Sensor;
				/// <java-name>
				/// accuracy
				/// </java-name>
				[Dot42.DexImport("accuracy", "I", AccessFlags = 1)]
				public int Accuracy;
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

		/// <java-name>
		/// android/hardware/SensorManager
		/// </java-name>
		[Dot42.DexImport("android/hardware/SensorManager", AccessFlags = 33)]
		public partial class SensorManager
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// SENSOR_ORIENTATION
				/// </java-name>
				[Dot42.DexImport("SENSOR_ORIENTATION", "I", AccessFlags = 25)]
				public const int SENSOR_ORIENTATION = 1;
				/// <java-name>
				/// SENSOR_ACCELEROMETER
				/// </java-name>
				[Dot42.DexImport("SENSOR_ACCELEROMETER", "I", AccessFlags = 25)]
				public const int SENSOR_ACCELEROMETER = 2;
				/// <java-name>
				/// SENSOR_TEMPERATURE
				/// </java-name>
				[Dot42.DexImport("SENSOR_TEMPERATURE", "I", AccessFlags = 25)]
				public const int SENSOR_TEMPERATURE = 4;
				/// <java-name>
				/// SENSOR_MAGNETIC_FIELD
				/// </java-name>
				[Dot42.DexImport("SENSOR_MAGNETIC_FIELD", "I", AccessFlags = 25)]
				public const int SENSOR_MAGNETIC_FIELD = 8;
				/// <java-name>
				/// SENSOR_LIGHT
				/// </java-name>
				[Dot42.DexImport("SENSOR_LIGHT", "I", AccessFlags = 25)]
				public const int SENSOR_LIGHT = 16;
				/// <java-name>
				/// SENSOR_PROXIMITY
				/// </java-name>
				[Dot42.DexImport("SENSOR_PROXIMITY", "I", AccessFlags = 25)]
				public const int SENSOR_PROXIMITY = 32;
				/// <java-name>
				/// SENSOR_TRICORDER
				/// </java-name>
				[Dot42.DexImport("SENSOR_TRICORDER", "I", AccessFlags = 25)]
				public const int SENSOR_TRICORDER = 64;
				/// <java-name>
				/// SENSOR_ORIENTATION_RAW
				/// </java-name>
				[Dot42.DexImport("SENSOR_ORIENTATION_RAW", "I", AccessFlags = 25)]
				public const int SENSOR_ORIENTATION_RAW = 128;
				/// <java-name>
				/// SENSOR_ALL
				/// </java-name>
				[Dot42.DexImport("SENSOR_ALL", "I", AccessFlags = 25)]
				public const int SENSOR_ALL = 127;
				/// <java-name>
				/// SENSOR_MIN
				/// </java-name>
				[Dot42.DexImport("SENSOR_MIN", "I", AccessFlags = 25)]
				public const int SENSOR_MIN = 1;
				/// <java-name>
				/// SENSOR_MAX
				/// </java-name>
				[Dot42.DexImport("SENSOR_MAX", "I", AccessFlags = 25)]
				public const int SENSOR_MAX = 64;
				/// <java-name>
				/// DATA_X
				/// </java-name>
				[Dot42.DexImport("DATA_X", "I", AccessFlags = 25)]
				public const int DATA_X = 0;
				/// <java-name>
				/// DATA_Y
				/// </java-name>
				[Dot42.DexImport("DATA_Y", "I", AccessFlags = 25)]
				public const int DATA_Y = 1;
				/// <java-name>
				/// DATA_Z
				/// </java-name>
				[Dot42.DexImport("DATA_Z", "I", AccessFlags = 25)]
				public const int DATA_Z = 2;
				/// <java-name>
				/// RAW_DATA_INDEX
				/// </java-name>
				[Dot42.DexImport("RAW_DATA_INDEX", "I", AccessFlags = 25)]
				public const int RAW_DATA_INDEX = 3;
				/// <java-name>
				/// RAW_DATA_X
				/// </java-name>
				[Dot42.DexImport("RAW_DATA_X", "I", AccessFlags = 25)]
				public const int RAW_DATA_X = 3;
				/// <java-name>
				/// RAW_DATA_Y
				/// </java-name>
				[Dot42.DexImport("RAW_DATA_Y", "I", AccessFlags = 25)]
				public const int RAW_DATA_Y = 4;
				/// <java-name>
				/// RAW_DATA_Z
				/// </java-name>
				[Dot42.DexImport("RAW_DATA_Z", "I", AccessFlags = 25)]
				public const int RAW_DATA_Z = 5;
				/// <java-name>
				/// STANDARD_GRAVITY
				/// </java-name>
				[Dot42.DexImport("STANDARD_GRAVITY", "F", AccessFlags = 25)]
				public const float STANDARD_GRAVITY = 9.80665F;
				/// <java-name>
				/// GRAVITY_SUN
				/// </java-name>
				[Dot42.DexImport("GRAVITY_SUN", "F", AccessFlags = 25)]
				public const float GRAVITY_SUN = 275F;
				/// <java-name>
				/// GRAVITY_MERCURY
				/// </java-name>
				[Dot42.DexImport("GRAVITY_MERCURY", "F", AccessFlags = 25)]
				public const float GRAVITY_MERCURY = 3.7F;
				/// <java-name>
				/// GRAVITY_VENUS
				/// </java-name>
				[Dot42.DexImport("GRAVITY_VENUS", "F", AccessFlags = 25)]
				public const float GRAVITY_VENUS = 8.87F;
				/// <java-name>
				/// GRAVITY_EARTH
				/// </java-name>
				[Dot42.DexImport("GRAVITY_EARTH", "F", AccessFlags = 25)]
				public const float GRAVITY_EARTH = 9.80665F;
				/// <java-name>
				/// GRAVITY_MOON
				/// </java-name>
				[Dot42.DexImport("GRAVITY_MOON", "F", AccessFlags = 25)]
				public const float GRAVITY_MOON = 1.6F;
				/// <java-name>
				/// GRAVITY_MARS
				/// </java-name>
				[Dot42.DexImport("GRAVITY_MARS", "F", AccessFlags = 25)]
				public const float GRAVITY_MARS = 3.71F;
				/// <java-name>
				/// GRAVITY_JUPITER
				/// </java-name>
				[Dot42.DexImport("GRAVITY_JUPITER", "F", AccessFlags = 25)]
				public const float GRAVITY_JUPITER = 23.12F;
				/// <java-name>
				/// GRAVITY_SATURN
				/// </java-name>
				[Dot42.DexImport("GRAVITY_SATURN", "F", AccessFlags = 25)]
				public const float GRAVITY_SATURN = 8.96F;
				/// <java-name>
				/// GRAVITY_URANUS
				/// </java-name>
				[Dot42.DexImport("GRAVITY_URANUS", "F", AccessFlags = 25)]
				public const float GRAVITY_URANUS = 8.69F;
				/// <java-name>
				/// GRAVITY_NEPTUNE
				/// </java-name>
				[Dot42.DexImport("GRAVITY_NEPTUNE", "F", AccessFlags = 25)]
				public const float GRAVITY_NEPTUNE = 11F;
				/// <java-name>
				/// GRAVITY_PLUTO
				/// </java-name>
				[Dot42.DexImport("GRAVITY_PLUTO", "F", AccessFlags = 25)]
				public const float GRAVITY_PLUTO = 0.6F;
				/// <java-name>
				/// GRAVITY_DEATH_STAR_I
				/// </java-name>
				[Dot42.DexImport("GRAVITY_DEATH_STAR_I", "F", AccessFlags = 25)]
				public const float GRAVITY_DEATH_STAR_I = 3.530361E-07F;
				/// <java-name>
				/// GRAVITY_THE_ISLAND
				/// </java-name>
				[Dot42.DexImport("GRAVITY_THE_ISLAND", "F", AccessFlags = 25)]
				public const float GRAVITY_THE_ISLAND = 4.815162F;
				/// <java-name>
				/// MAGNETIC_FIELD_EARTH_MAX
				/// </java-name>
				[Dot42.DexImport("MAGNETIC_FIELD_EARTH_MAX", "F", AccessFlags = 25)]
				public const float MAGNETIC_FIELD_EARTH_MAX = 60F;
				/// <java-name>
				/// MAGNETIC_FIELD_EARTH_MIN
				/// </java-name>
				[Dot42.DexImport("MAGNETIC_FIELD_EARTH_MIN", "F", AccessFlags = 25)]
				public const float MAGNETIC_FIELD_EARTH_MIN = 30F;
				/// <java-name>
				/// PRESSURE_STANDARD_ATMOSPHERE
				/// </java-name>
				[Dot42.DexImport("PRESSURE_STANDARD_ATMOSPHERE", "F", AccessFlags = 25)]
				public const float PRESSURE_STANDARD_ATMOSPHERE = 1013.25F;
				/// <java-name>
				/// LIGHT_SUNLIGHT_MAX
				/// </java-name>
				[Dot42.DexImport("LIGHT_SUNLIGHT_MAX", "F", AccessFlags = 25)]
				public const float LIGHT_SUNLIGHT_MAX = 120000F;
				/// <java-name>
				/// LIGHT_SUNLIGHT
				/// </java-name>
				[Dot42.DexImport("LIGHT_SUNLIGHT", "F", AccessFlags = 25)]
				public const float LIGHT_SUNLIGHT = 110000F;
				/// <java-name>
				/// LIGHT_SHADE
				/// </java-name>
				[Dot42.DexImport("LIGHT_SHADE", "F", AccessFlags = 25)]
				public const float LIGHT_SHADE = 20000F;
				/// <java-name>
				/// LIGHT_OVERCAST
				/// </java-name>
				[Dot42.DexImport("LIGHT_OVERCAST", "F", AccessFlags = 25)]
				public const float LIGHT_OVERCAST = 10000F;
				/// <java-name>
				/// LIGHT_SUNRISE
				/// </java-name>
				[Dot42.DexImport("LIGHT_SUNRISE", "F", AccessFlags = 25)]
				public const float LIGHT_SUNRISE = 400F;
				/// <java-name>
				/// LIGHT_CLOUDY
				/// </java-name>
				[Dot42.DexImport("LIGHT_CLOUDY", "F", AccessFlags = 25)]
				public const float LIGHT_CLOUDY = 100F;
				/// <java-name>
				/// LIGHT_FULLMOON
				/// </java-name>
				[Dot42.DexImport("LIGHT_FULLMOON", "F", AccessFlags = 25)]
				public const float LIGHT_FULLMOON = 0.25F;
				/// <java-name>
				/// LIGHT_NO_MOON
				/// </java-name>
				[Dot42.DexImport("LIGHT_NO_MOON", "F", AccessFlags = 25)]
				public const float LIGHT_NO_MOON = 0.001F;
				/// <java-name>
				/// SENSOR_DELAY_FASTEST
				/// </java-name>
				[Dot42.DexImport("SENSOR_DELAY_FASTEST", "I", AccessFlags = 25)]
				public const int SENSOR_DELAY_FASTEST = 0;
				/// <java-name>
				/// SENSOR_DELAY_GAME
				/// </java-name>
				[Dot42.DexImport("SENSOR_DELAY_GAME", "I", AccessFlags = 25)]
				public const int SENSOR_DELAY_GAME = 1;
				/// <java-name>
				/// SENSOR_DELAY_UI
				/// </java-name>
				[Dot42.DexImport("SENSOR_DELAY_UI", "I", AccessFlags = 25)]
				public const int SENSOR_DELAY_UI = 2;
				/// <java-name>
				/// SENSOR_DELAY_NORMAL
				/// </java-name>
				[Dot42.DexImport("SENSOR_DELAY_NORMAL", "I", AccessFlags = 25)]
				public const int SENSOR_DELAY_NORMAL = 3;
				/// <java-name>
				/// SENSOR_STATUS_UNRELIABLE
				/// </java-name>
				[Dot42.DexImport("SENSOR_STATUS_UNRELIABLE", "I", AccessFlags = 25)]
				public const int SENSOR_STATUS_UNRELIABLE = 0;
				/// <java-name>
				/// SENSOR_STATUS_ACCURACY_LOW
				/// </java-name>
				[Dot42.DexImport("SENSOR_STATUS_ACCURACY_LOW", "I", AccessFlags = 25)]
				public const int SENSOR_STATUS_ACCURACY_LOW = 1;
				/// <java-name>
				/// SENSOR_STATUS_ACCURACY_MEDIUM
				/// </java-name>
				[Dot42.DexImport("SENSOR_STATUS_ACCURACY_MEDIUM", "I", AccessFlags = 25)]
				public const int SENSOR_STATUS_ACCURACY_MEDIUM = 2;
				/// <java-name>
				/// SENSOR_STATUS_ACCURACY_HIGH
				/// </java-name>
				[Dot42.DexImport("SENSOR_STATUS_ACCURACY_HIGH", "I", AccessFlags = 25)]
				public const int SENSOR_STATUS_ACCURACY_HIGH = 3;
				/// <java-name>
				/// AXIS_X
				/// </java-name>
				[Dot42.DexImport("AXIS_X", "I", AccessFlags = 25)]
				public const int AXIS_X = 1;
				/// <java-name>
				/// AXIS_Y
				/// </java-name>
				[Dot42.DexImport("AXIS_Y", "I", AccessFlags = 25)]
				public const int AXIS_Y = 2;
				/// <java-name>
				/// AXIS_Z
				/// </java-name>
				[Dot42.DexImport("AXIS_Z", "I", AccessFlags = 25)]
				public const int AXIS_Z = 3;
				/// <java-name>
				/// AXIS_MINUS_X
				/// </java-name>
				[Dot42.DexImport("AXIS_MINUS_X", "I", AccessFlags = 25)]
				public const int AXIS_MINUS_X = 129;
				/// <java-name>
				/// AXIS_MINUS_Y
				/// </java-name>
				[Dot42.DexImport("AXIS_MINUS_Y", "I", AccessFlags = 25)]
				public const int AXIS_MINUS_Y = 130;
				/// <java-name>
				/// AXIS_MINUS_Z
				/// </java-name>
				[Dot42.DexImport("AXIS_MINUS_Z", "I", AccessFlags = 25)]
				public const int AXIS_MINUS_Z = 131;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal SensorManager() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getSensorList
				/// </java-name>
				[Dot42.DexImport("getSensorList", "(I)Ljava/util/List;", AccessFlags = 1, Signature = "(I)Ljava/util/List<Landroid/hardware/Sensor;>;")]
				public virtual global::Java.Util.IList<global::Android.Hardware.Sensor> GetSensorList(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<global::Android.Hardware.Sensor>);
				}

				/// <java-name>
				/// getDefaultSensor
				/// </java-name>
				[Dot42.DexImport("getDefaultSensor", "(I)Landroid/hardware/Sensor;", AccessFlags = 1)]
				public virtual global::Android.Hardware.Sensor GetDefaultSensor(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Hardware.Sensor);
				}

				/// <java-name>
				/// registerListener
				/// </java-name>
				[Dot42.DexImport("registerListener", "(Landroid/hardware/SensorListener;I)Z", AccessFlags = 1)]
				public virtual bool RegisterListener(global::Android.Hardware.ISensorListener sensorListener, int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// registerListener
				/// </java-name>
				[Dot42.DexImport("registerListener", "(Landroid/hardware/SensorListener;II)Z", AccessFlags = 1)]
				public virtual bool RegisterListener(global::Android.Hardware.ISensorListener sensorListener, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// unregisterListener
				/// </java-name>
				[Dot42.DexImport("unregisterListener", "(Landroid/hardware/SensorListener;I)V", AccessFlags = 1)]
				public virtual void UnregisterListener(global::Android.Hardware.ISensorListener sensorListener, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// unregisterListener
				/// </java-name>
				[Dot42.DexImport("unregisterListener", "(Landroid/hardware/SensorListener;)V", AccessFlags = 1)]
				public virtual void UnregisterListener(global::Android.Hardware.ISensorListener sensorListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// unregisterListener
				/// </java-name>
				[Dot42.DexImport("unregisterListener", "(Landroid/hardware/SensorEventListener;Landroid/hardware/Sensor;)V", AccessFlags = 1)]
				public virtual void UnregisterListener(global::Android.Hardware.ISensorEventListener sensorEventListener, global::Android.Hardware.Sensor sensor) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// unregisterListener
				/// </java-name>
				[Dot42.DexImport("unregisterListener", "(Landroid/hardware/SensorEventListener;)V", AccessFlags = 1)]
				public virtual void UnregisterListener(global::Android.Hardware.ISensorEventListener sensorEventListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// registerListener
				/// </java-name>
				[Dot42.DexImport("registerListener", "(Landroid/hardware/SensorEventListener;Landroid/hardware/Sensor;I)Z", AccessFlags = 1)]
				public virtual bool RegisterListener(global::Android.Hardware.ISensorEventListener sensorEventListener, global::Android.Hardware.Sensor sensor, int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// registerListener
				/// </java-name>
				[Dot42.DexImport("registerListener", "(Landroid/hardware/SensorEventListener;Landroid/hardware/Sensor;ILandroid/os/Hand" +
    "ler;)Z", AccessFlags = 1)]
				public virtual bool RegisterListener(global::Android.Hardware.ISensorEventListener sensorEventListener, global::Android.Hardware.Sensor sensor, int int32, global::Android.OS.Handler handler) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getRotationMatrix
				/// </java-name>
				[Dot42.DexImport("getRotationMatrix", "([F[F[F[F)Z", AccessFlags = 9)]
				public static bool GetRotationMatrix(float[] single, float[] single1, float[] single2, float[] single3) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getInclination
				/// </java-name>
				[Dot42.DexImport("getInclination", "([F)F", AccessFlags = 9)]
				public static float GetInclination(float[] single) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// remapCoordinateSystem
				/// </java-name>
				[Dot42.DexImport("remapCoordinateSystem", "([FII[F)Z", AccessFlags = 9)]
				public static bool RemapCoordinateSystem(float[] single, int int32, int int321, float[] single1) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getOrientation
				/// </java-name>
				[Dot42.DexImport("getOrientation", "([F[F)[F", AccessFlags = 9)]
				public static float[] GetOrientation(float[] single, float[] single1) /* MethodBuilder.Create */ 
				{
						return default(float[]);
				}

				/// <java-name>
				/// getAltitude
				/// </java-name>
				[Dot42.DexImport("getAltitude", "(FF)F", AccessFlags = 9)]
				public static float GetAltitude(float single, float single1) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// getAngleChange
				/// </java-name>
				[Dot42.DexImport("getAngleChange", "([F[F[F)V", AccessFlags = 9)]
				public static void GetAngleChange(float[] single, float[] single1, float[] single2) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getRotationMatrixFromVector
				/// </java-name>
				[Dot42.DexImport("getRotationMatrixFromVector", "([F[F)V", AccessFlags = 9)]
				public static void GetRotationMatrixFromVector(float[] single, float[] single1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getQuaternionFromVector
				/// </java-name>
				[Dot42.DexImport("getQuaternionFromVector", "([F[F)V", AccessFlags = 9)]
				public static void GetQuaternionFromVector(float[] single, float[] single1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getSensors
				/// </java-name>
				public virtual int Sensors
				{
						[Dot42.DexImport("getSensors", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

		}

}

