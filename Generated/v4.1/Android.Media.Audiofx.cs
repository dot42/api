#pragma warning disable 1717
namespace Android.Media.Audiofx
{
		/// <summary>
		///  <para>Acoustic Echo Canceler (AEC). </para> <para>Acoustic Echo Canceler (AEC) is an audio pre-processing which removes the contribution of the signal received from the remote party from the captured audio signal. </para> <para>AEC is used by voice communication applications (voice chat, video conferencing, SIP calls) where the presence of echo with significant delay in the signal received from the remote party is highly disturbing. AEC is often used in conjunction with noise suppression (NS). </para> <para>An application creates an AcousticEchoCanceler object to instantiate and control an AEC engine in the audio capture path. </para> <para>To attach the AcousticEchoCanceler to a particular android.media.AudioRecord, specify the audio session ID of this AudioRecord when creating the AcousticEchoCanceler. The audio session is retrieved by calling android.media.AudioRecord#getAudioSessionId() on the AudioRecord instance. </para> <para>On some devices, an AEC can be inserted by default in the capture path by the platform according to the android.media.MediaRecorder.AudioSource used. The application should call AcousticEchoCanceler.getEnable() after creating the AEC to check the default AEC activation state on a particular AudioRecord session. </para> <para>See android.media.audiofx.AudioEffect class for more details on controlling audio effects. </para>    
		/// </summary>
		/// <java-name>
		/// android/media/audiofx/AcousticEchoCanceler
		/// </java-name>
		[Dot42.DexImport("android/media/audiofx/AcousticEchoCanceler", AccessFlags = 33)]
		public partial class AcousticEchoCanceler : global::Android.Media.Audiofx.AudioEffect
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal AcousticEchoCanceler() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Creates an AcousticEchoCanceler and attaches it to the AudioRecord on the audio session specified. </para>        
				/// </summary>
				/// <returns>
				///  <para>AcousticEchoCanceler created or null if the device does not implement AEC. </para>
				/// </returns>
				/// <java-name>
				/// create
				/// </java-name>
				[Dot42.DexImport("create", "(I)Landroid/media/audiofx/AcousticEchoCanceler;", AccessFlags = 9)]
				public static global::Android.Media.Audiofx.AcousticEchoCanceler Create(int audioSession) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Media.Audiofx.AcousticEchoCanceler);
				}

				/// <summary>
				///  <para>Checks if the device implements acoustic echo cancellation. </para>        
				/// </summary>
				/// <returns>
				///  <para>true if the device implements acoustic echo cancellation, false otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isAvailable
				/// </java-name>
				public static bool IsAvailable
				{
						[Dot42.DexImport("isAvailable", "()Z", AccessFlags = 9)]
						get{ return default(bool); }
				}

		}

		/// <summary>
		///  <para>AudioEffect is the base class for controlling audio effects provided by the android audio framework. </para> <para>Applications should not use the AudioEffect class directly but one of its derived classes to control specific effects:  <ul> <li> <para>android.media.audiofx.Equalizer </para></li> <li> <para>android.media.audiofx.Virtualizer </para></li> <li> <para>android.media.audiofx.BassBoost </para></li> <li> <para>android.media.audiofx.PresetReverb </para></li> <li> <para>android.media.audiofx.EnvironmentalReverb </para></li></ul></para> <para>To apply the audio effect to a specific AudioTrack or MediaPlayer instance, the application must specify the audio session ID of that instance when creating the AudioEffect. (see android.media.MediaPlayer#getAudioSessionId() for details on audio sessions). </para> <para>NOTE: attaching insert effects (equalizer, bass boost, virtualizer) to the global audio output mix by use of session 0 is deprecated. </para> <para>Creating an AudioEffect object will create the corresponding effect engine in the audio framework if no instance of the same effect type exists in the specified audio session. If one exists, this instance will be used. </para> <para>The application creating the AudioEffect object (or a derived class) will either receive control of the effect engine or not depending on the priority parameter. If priority is higher than the priority used by the current effect engine owner, the control will be transfered to the new object. Otherwise control will remain with the previous object. In this case, the new application will be notified of changes in effect engine state or control ownership by the appropiate listener. </para>    
		/// </summary>
		/// <java-name>
		/// android/media/audiofx/AudioEffect
		/// </java-name>
		[Dot42.DexImport("android/media/audiofx/AudioEffect", AccessFlags = 33)]
		public partial class AudioEffect
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Successful operation. </para>        
				/// </summary>
				/// <java-name>
				/// SUCCESS
				/// </java-name>
				[Dot42.DexImport("SUCCESS", "I", AccessFlags = 25)]
				public const int SUCCESS = 0;
				/// <summary>
				///  <para>Unspecified error. </para>        
				/// </summary>
				/// <java-name>
				/// ERROR
				/// </java-name>
				[Dot42.DexImport("ERROR", "I", AccessFlags = 25)]
				public const int ERROR = -1;
				/// <summary>
				///  <para>Internal operation status. Not returned by any method. </para>        
				/// </summary>
				/// <java-name>
				/// ALREADY_EXISTS
				/// </java-name>
				[Dot42.DexImport("ALREADY_EXISTS", "I", AccessFlags = 25)]
				public const int ALREADY_EXISTS = -2;
				/// <summary>
				///  <para>Operation failed due to bad object initialization. </para>        
				/// </summary>
				/// <java-name>
				/// ERROR_NO_INIT
				/// </java-name>
				[Dot42.DexImport("ERROR_NO_INIT", "I", AccessFlags = 25)]
				public const int ERROR_NO_INIT = -3;
				/// <summary>
				///  <para>Operation failed due to bad parameter value. </para>        
				/// </summary>
				/// <java-name>
				/// ERROR_BAD_VALUE
				/// </java-name>
				[Dot42.DexImport("ERROR_BAD_VALUE", "I", AccessFlags = 25)]
				public const int ERROR_BAD_VALUE = -4;
				/// <summary>
				///  <para>Operation failed because it was requested in wrong state. </para>        
				/// </summary>
				/// <java-name>
				/// ERROR_INVALID_OPERATION
				/// </java-name>
				[Dot42.DexImport("ERROR_INVALID_OPERATION", "I", AccessFlags = 25)]
				public const int ERROR_INVALID_OPERATION = -5;
				/// <summary>
				///  <para>Operation failed due to lack of memory. </para>        
				/// </summary>
				/// <java-name>
				/// ERROR_NO_MEMORY
				/// </java-name>
				[Dot42.DexImport("ERROR_NO_MEMORY", "I", AccessFlags = 25)]
				public const int ERROR_NO_MEMORY = -6;
				/// <summary>
				///  <para>Operation failed due to dead remote object. </para>        
				/// </summary>
				/// <java-name>
				/// ERROR_DEAD_OBJECT
				/// </java-name>
				[Dot42.DexImport("ERROR_DEAD_OBJECT", "I", AccessFlags = 25)]
				public const int ERROR_DEAD_OBJECT = -7;
				/// <summary>
				///  <para>Effect connection mode is insert. Specifying an audio session ID when creating the effect will insert this effect after all players in the same audio session. </para>        
				/// </summary>
				/// <java-name>
				/// EFFECT_INSERT
				/// </java-name>
				[Dot42.DexImport("EFFECT_INSERT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EFFECT_INSERT = "Insert";
				/// <summary>
				///  <para>Effect connection mode is auxiliary. </para> <para>Auxiliary effects must be created on session 0 (global output mix). In order for a MediaPlayer or AudioTrack to be fed into this effect, they must be explicitely attached to this effect and a send level must be specified. </para> <para>Use the effect ID returned by getId() to designate this particular effect when attaching it to the MediaPlayer or AudioTrack. </para>        
				/// </summary>
				/// <java-name>
				/// EFFECT_AUXILIARY
				/// </java-name>
				[Dot42.DexImport("EFFECT_AUXILIARY", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EFFECT_AUXILIARY = "Auxiliary";
				/// <summary>
				///  <para>Intent to launch an audio effect control panel UI. </para> <para>The goal of this intent is to enable separate implementations of music/media player applications and audio effect control application or services. This will allow platform vendors to offer more advanced control options for standard effects or control for platform specific effects. </para> <para>The intent carries a number of extras used by the player application to communicate necessary pieces of information to the control panel application. </para> <para>The calling application must use the android.app.Activity#startActivityForResult(Intent, int) method to launch the control panel so that its package name is indicated and used by the control panel application to keep track of changes for this particular application. </para> <para>The EXTRA_AUDIO_SESSION extra will indicate an audio session to which the audio effects should be applied. If no audio session is specified, either one of the follownig will happen: </para> <para>- If an audio session was previously opened by the calling application with ACTION_OPEN_AUDIO_EFFECT_CONTROL_SESSION intent, the effect changes will be applied to that session. </para> <para>- If no audio session is opened, the changes will be stored in the package specific storage area and applied whenever a new audio session is opened by this application. </para> <para>The EXTRA_CONTENT_TYPE extra will help the control panel application customize both the UI layout and the default audio effect settings if none are already stored for the calling application. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_DISPLAY_AUDIO_EFFECT_CONTROL_PANEL
				/// </java-name>
				[Dot42.DexImport("ACTION_DISPLAY_AUDIO_EFFECT_CONTROL_PANEL", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_DISPLAY_AUDIO_EFFECT_CONTROL_PANEL = "android.media.action.DISPLAY_AUDIO_EFFECT_CONTROL_PANEL";
				/// <summary>
				///  <para>Intent to signal to the effect control application or service that a new audio session is opened and requires audio effects to be applied. </para> <para>This is different from ACTION_DISPLAY_AUDIO_EFFECT_CONTROL_PANEL in that no UI should be displayed in this case. Music player applications can broadcast this intent before starting playback to make sure that any audio effect settings previously selected by the user are applied. </para> <para>The effect control application receiving this intent will look for previously stored settings for the calling application, create all required audio effects and apply the effect settings to the specified audio session. </para> <para>The calling package name is indicated by the EXTRA_PACKAGE_NAME extra and the audio session ID by the EXTRA_AUDIO_SESSION extra. Both extras are mandatory. </para> <para>If no stored settings are found for the calling application, default settings for the content type indicated by EXTRA_CONTENT_TYPE will be applied. The default settings for a given content type are platform specific. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_OPEN_AUDIO_EFFECT_CONTROL_SESSION
				/// </java-name>
				[Dot42.DexImport("ACTION_OPEN_AUDIO_EFFECT_CONTROL_SESSION", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_OPEN_AUDIO_EFFECT_CONTROL_SESSION = "android.media.action.OPEN_AUDIO_EFFECT_CONTROL_SESSION";
				/// <summary>
				///  <para>Intent to signal to the effect control application or service that an audio session is closed and that effects should not be applied anymore. </para> <para>The effect control application receiving this intent will delete all effects on this session and store current settings in package specific storage. </para> <para>The calling package name is indicated by the EXTRA_PACKAGE_NAME extra and the audio session ID by the EXTRA_AUDIO_SESSION extra. Both extras are mandatory. </para> <para>It is good practice for applications to broadcast this intent when music playback stops and/or when exiting to free system resources consumed by audio effect engines. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_CLOSE_AUDIO_EFFECT_CONTROL_SESSION
				/// </java-name>
				[Dot42.DexImport("ACTION_CLOSE_AUDIO_EFFECT_CONTROL_SESSION", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_CLOSE_AUDIO_EFFECT_CONTROL_SESSION = "android.media.action.CLOSE_AUDIO_EFFECT_CONTROL_SESSION";
				/// <summary>
				///  <para>Contains the ID of the audio session the effects should be applied to. </para> <para>This extra is for use with ACTION_DISPLAY_AUDIO_EFFECT_CONTROL_PANEL, ACTION_OPEN_AUDIO_EFFECT_CONTROL_SESSION and ACTION_CLOSE_AUDIO_EFFECT_CONTROL_SESSION intents. </para> <para>The extra value is of type int and is the audio session ID.  <para>android.media.MediaPlayer::getAudioSessionId() for details on audio sessions. </para></para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_AUDIO_SESSION
				/// </java-name>
				[Dot42.DexImport("EXTRA_AUDIO_SESSION", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_AUDIO_SESSION = "android.media.extra.AUDIO_SESSION";
				/// <summary>
				///  <para>Contains the package name of the calling application. </para> <para>This extra is for use with ACTION_OPEN_AUDIO_EFFECT_CONTROL_SESSION and ACTION_CLOSE_AUDIO_EFFECT_CONTROL_SESSION intents. </para> <para>The extra value is a string containing the full package name. </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_PACKAGE_NAME
				/// </java-name>
				[Dot42.DexImport("EXTRA_PACKAGE_NAME", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_PACKAGE_NAME = "android.media.extra.PACKAGE_NAME";
				/// <summary>
				///  <para>Indicates which type of content is played by the application. </para> <para>This extra is for use with ACTION_DISPLAY_AUDIO_EFFECT_CONTROL_PANEL and ACTION_OPEN_AUDIO_EFFECT_CONTROL_SESSION intents. </para> <para>This information is used by the effect control application to customize UI and select appropriate default effect settings. The content type is one of the following:  <ul> <li> <para>CONTENT_TYPE_MUSIC </para></li> <li> <para>CONTENT_TYPE_MOVIE </para></li> <li> <para>CONTENT_TYPE_GAME </para></li> <li> <para>CONTENT_TYPE_VOICE </para></li></ul>If omitted, the content type defaults to CONTENT_TYPE_MUSIC. </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_CONTENT_TYPE
				/// </java-name>
				[Dot42.DexImport("EXTRA_CONTENT_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_CONTENT_TYPE = "android.media.extra.CONTENT_TYPE";
				/// <summary>
				///  <para>Value for EXTRA_CONTENT_TYPE when the type of content played is music </para>        
				/// </summary>
				/// <java-name>
				/// CONTENT_TYPE_MUSIC
				/// </java-name>
				[Dot42.DexImport("CONTENT_TYPE_MUSIC", "I", AccessFlags = 25)]
				public const int CONTENT_TYPE_MUSIC = 0;
				/// <summary>
				///  <para>Value for EXTRA_CONTENT_TYPE when the type of content played is video or movie </para>        
				/// </summary>
				/// <java-name>
				/// CONTENT_TYPE_MOVIE
				/// </java-name>
				[Dot42.DexImport("CONTENT_TYPE_MOVIE", "I", AccessFlags = 25)]
				public const int CONTENT_TYPE_MOVIE = 1;
				/// <summary>
				///  <para>Value for EXTRA_CONTENT_TYPE when the type of content played is game audio </para>        
				/// </summary>
				/// <java-name>
				/// CONTENT_TYPE_GAME
				/// </java-name>
				[Dot42.DexImport("CONTENT_TYPE_GAME", "I", AccessFlags = 25)]
				public const int CONTENT_TYPE_GAME = 2;
				/// <summary>
				///  <para>Value for EXTRA_CONTENT_TYPE when the type of content played is voice audio </para>        
				/// </summary>
				/// <java-name>
				/// CONTENT_TYPE_VOICE
				/// </java-name>
				[Dot42.DexImport("CONTENT_TYPE_VOICE", "I", AccessFlags = 25)]
				public const int CONTENT_TYPE_VOICE = 3;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal AudioEffect() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Releases the native AudioEffect resources. It is a good practice to release the effect engine when not in use as control can be returned to other applications or the native resources released. </para>        
				/// </summary>
				/// <java-name>
				/// release
				/// </java-name>
				[Dot42.DexImport("release", "()V", AccessFlags = 1)]
				public virtual void Release() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// finalize
				/// </java-name>
				[Dot42.DexImport("finalize", "()V", AccessFlags = 4)]
				extern ~AudioEffect() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Get the effect descriptor.</para> <para> <para>android.media.audiofx.AudioEffect.Descriptor </para></para>        
				/// </summary>
				/// <java-name>
				/// getDescriptor
				/// </java-name>
				[Dot42.DexImport("getDescriptor", "()Landroid/media/audiofx/AudioEffect$Descriptor;", AccessFlags = 1)]
				public virtual global::Android.Media.Audiofx.AudioEffect.Descriptor GetDescriptor() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Media.Audiofx.AudioEffect.Descriptor);
				}

				/// <summary>
				///  <para>Query all effects available on the platform. Returns an array of android.media.audiofx.AudioEffect.Descriptor objects</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// queryEffects
				/// </java-name>
				[Dot42.DexImport("queryEffects", "()[Landroid/media/audiofx/AudioEffect$Descriptor;", AccessFlags = 9)]
				public static global::Android.Media.Audiofx.AudioEffect.Descriptor[] QueryEffects() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Media.Audiofx.AudioEffect.Descriptor[]);
				}

				/// <summary>
				///  <para>Enable or disable the effect. Creating an audio effect does not automatically apply this effect on the audio source. It creates the resources necessary to process this effect but the audio signal is still bypassed through the effect engine. Calling this method will make that the effect is actually applied or not to the audio content being played in the corresponding audio session.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>SUCCESS in case of success, ERROR_INVALID_OPERATION or ERROR_DEAD_OBJECT in case of failure. </para>
				/// </returns>
				/// <java-name>
				/// setEnabled
				/// </java-name>
				[Dot42.DexImport("setEnabled", "(Z)I", AccessFlags = 1)]
				public virtual int SetEnabled(bool enabled) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Sets the listener AudioEffect notifies when the effect engine is enabled or disabled.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setEnableStatusListener
				/// </java-name>
				[Dot42.DexImport("setEnableStatusListener", "(Landroid/media/audiofx/AudioEffect$OnEnableStatusChangeListener;)V", AccessFlags = 1)]
				public virtual void SetEnableStatusListener(global::Android.Media.Audiofx.AudioEffect.IOnEnableStatusChangeListener listener) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the listener AudioEffect notifies when the effect engine control is taken or returned.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setControlStatusListener
				/// </java-name>
				[Dot42.DexImport("setControlStatusListener", "(Landroid/media/audiofx/AudioEffect$OnControlStatusChangeListener;)V", AccessFlags = 1)]
				public virtual void SetControlStatusListener(global::Android.Media.Audiofx.AudioEffect.IOnControlStatusChangeListener listener) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns effect unique identifier. This system wide unique identifier can be used to attach this effect to a MediaPlayer or an AudioTrack when the effect is an auxiliary effect (Reverb)</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the effect identifier. </para>
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
				///  <para>Returns effect enabled state</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if the effect is enabled, false otherwise. </para>
				/// </returns>
				/// <java-name>
				/// getEnabled
				/// </java-name>
				public virtual bool Enabled
				{
						[Dot42.DexImport("getEnabled", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Checks if this AudioEffect object is controlling the effect engine.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if this instance has control of effect engine, false otherwise. </para>
				/// </returns>
				/// <java-name>
				/// hasControl
				/// </java-name>
				public virtual bool HasControl
				{
						[Dot42.DexImport("hasControl", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>The OnControlStatusChangeListener interface defines a method called by the AudioEffect when a the control of the effect engine is gained or lost by the application </para>    
				/// </summary>
				/// <java-name>
				/// android/media/audiofx/AudioEffect$OnControlStatusChangeListener
				/// </java-name>
				[Dot42.DexImport("android/media/audiofx/AudioEffect$OnControlStatusChangeListener", AccessFlags = 1545)]
				public partial interface IOnControlStatusChangeListener
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>Called on the listener to notify it that the effect engine control has been taken or returned. </para>        
						/// </summary>
						/// <java-name>
						/// onControlStatusChange
						/// </java-name>
						[Dot42.DexImport("onControlStatusChange", "(Landroid/media/audiofx/AudioEffect;Z)V", AccessFlags = 1025)]
						void OnControlStatusChange(global::Android.Media.Audiofx.AudioEffect effect, bool controlGranted) /* MethodBuilder.Create */ ;

				}

				/// <summary>
				///  <para>The OnEnableStatusChangeListener interface defines a method called by the AudioEffect when a the enabled state of the effect engine was changed by the controlling application. </para>    
				/// </summary>
				/// <java-name>
				/// android/media/audiofx/AudioEffect$OnEnableStatusChangeListener
				/// </java-name>
				[Dot42.DexImport("android/media/audiofx/AudioEffect$OnEnableStatusChangeListener", AccessFlags = 1545)]
				public partial interface IOnEnableStatusChangeListener
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>Called on the listener to notify it that the effect engine has been enabled or disabled. </para>        
						/// </summary>
						/// <java-name>
						/// onEnableStatusChange
						/// </java-name>
						[Dot42.DexImport("onEnableStatusChange", "(Landroid/media/audiofx/AudioEffect;Z)V", AccessFlags = 1025)]
						void OnEnableStatusChange(global::Android.Media.Audiofx.AudioEffect effect, bool enabled) /* MethodBuilder.Create */ ;

				}

				/// <summary>
				///  <para>The effect descriptor contains information on a particular effect implemented in the audio framework: <br></br>  <ul> <li> <para>type: UUID identifying the effect type. May be one of: AudioEffect#EFFECT_TYPE_AEC, AudioEffect#EFFECT_TYPE_AGC, AudioEffect#EFFECT_TYPE_BASS_BOOST, AudioEffect#EFFECT_TYPE_ENV_REVERB, AudioEffect#EFFECT_TYPE_EQUALIZER, AudioEffect#EFFECT_TYPE_NS, AudioEffect#EFFECT_TYPE_PRESET_REVERB, AudioEffect#EFFECT_TYPE_VIRTUALIZER.  </para></li> <li> <para>uuid: UUID for this particular implementation </para></li> <li> <para>connectMode: EFFECT_INSERT or EFFECT_AUXILIARY </para></li> <li> <para>name: human readable effect name </para></li> <li> <para>implementor: human readable effect implementor name </para></li></ul>The method queryEffects() returns an array of Descriptors to facilitate effects enumeration. </para>    
				/// </summary>
				/// <java-name>
				/// android/media/audiofx/AudioEffect$Descriptor
				/// </java-name>
				[Dot42.DexImport("android/media/audiofx/AudioEffect$Descriptor", AccessFlags = 9)]
				public partial class Descriptor
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>Indicates the generic type of the effect (Equalizer, Bass boost ...). One of AudioEffect#EFFECT_TYPE_AEC, AudioEffect#EFFECT_TYPE_AGC, AudioEffect#EFFECT_TYPE_BASS_BOOST, AudioEffect#EFFECT_TYPE_ENV_REVERB, AudioEffect#EFFECT_TYPE_EQUALIZER, AudioEffect#EFFECT_TYPE_NS, AudioEffect#EFFECT_TYPE_PRESET_REVERB or AudioEffect#EFFECT_TYPE_VIRTUALIZER. <br></br> For reverberation, bass boost, EQ and virtualizer, the UUID corresponds to the OpenSL ES Interface ID. </para>        
						/// </summary>
						/// <java-name>
						/// type
						/// </java-name>
						[Dot42.DexImport("type", "Ljava/util/UUID;", AccessFlags = 1)]
						public global::Java.Util.UUID Type;
						/// <summary>
						///  <para>Indicates the particular implementation of the effect in that type. Several effects can have the same type but this uuid is unique to a given implementation. </para>        
						/// </summary>
						/// <java-name>
						/// uuid
						/// </java-name>
						[Dot42.DexImport("uuid", "Ljava/util/UUID;", AccessFlags = 1)]
						public global::Java.Util.UUID Uuid;
						/// <summary>
						///  <para>Indicates if the effect is of insert category EFFECT_INSERT or auxiliary category EFFECT_AUXILIARY. Insert effects (typically an Equalizer) are applied to the entire audio source and usually not shared by several sources. Auxiliary effects (typically a reverberator) are applied to part of the signal (wet) and the effect output is added to the original signal (dry). Audio pre processing are applied to audio captured on a particular android.media.AudioRecord. </para>        
						/// </summary>
						/// <java-name>
						/// connectMode
						/// </java-name>
						[Dot42.DexImport("connectMode", "Ljava/lang/String;", AccessFlags = 1)]
						public string ConnectMode;
						/// <summary>
						///  <para>Human readable effect name </para>        
						/// </summary>
						/// <java-name>
						/// name
						/// </java-name>
						[Dot42.DexImport("name", "Ljava/lang/String;", AccessFlags = 1)]
						public string Name;
						/// <summary>
						///  <para>Human readable effect implementor name </para>        
						/// </summary>
						/// <java-name>
						/// implementor
						/// </java-name>
						[Dot42.DexImport("implementor", "Ljava/lang/String;", AccessFlags = 1)]
						public string Implementor;
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public Descriptor() /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/la" +
    "ng/String;)V", AccessFlags = 1)]
						public Descriptor(string @string, string string1, string string2, string string3, string string4) /* MethodBuilder.Create */ 
						{
						}

				}

		}

		/// <summary>
		///  <para>Automatic Gain Control (AGC). </para> <para>Automatic Gain Control (AGC) is an audio pre-processing which automatically normalizes the output of the captured signal by boosting or lowering input from the microphone to match a preset level so that the output signal level is virtually constant. AGC can be used by applications where the input signal dynamic range is not important but where a constant strong capture level is desired. </para> <para>An application creates a AutomaticGainControl object to instantiate and control an AGC engine in the audio framework. </para> <para>To attach the AutomaticGainControl to a particular android.media.AudioRecord, specify the audio session ID of this AudioRecord when creating the AutomaticGainControl. The audio session is retrieved by calling android.media.AudioRecord#getAudioSessionId() on the AudioRecord instance. </para> <para>On some devices, an AGC can be inserted by default in the capture path by the platform according to the android.media.MediaRecorder.AudioSource used. The application should call AutomaticGainControl.getEnable() after creating the AGC to check the default AGC activation state on a particular AudioRecord session. </para> <para>See android.media.audiofx.AudioEffect class for more details on controlling audio effects. </para>    
		/// </summary>
		/// <java-name>
		/// android/media/audiofx/AutomaticGainControl
		/// </java-name>
		[Dot42.DexImport("android/media/audiofx/AutomaticGainControl", AccessFlags = 33)]
		public partial class AutomaticGainControl : global::Android.Media.Audiofx.AudioEffect
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal AutomaticGainControl() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Creates an AutomaticGainControl and attaches it to the AudioRecord on the audio session specified. </para>        
				/// </summary>
				/// <returns>
				///  <para>AutomaticGainControl created or null if the device does not implement AGC. </para>
				/// </returns>
				/// <java-name>
				/// create
				/// </java-name>
				[Dot42.DexImport("create", "(I)Landroid/media/audiofx/AutomaticGainControl;", AccessFlags = 9)]
				public static global::Android.Media.Audiofx.AutomaticGainControl Create(int audioSession) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Media.Audiofx.AutomaticGainControl);
				}

				/// <summary>
				///  <para>Checks if the device implements automatic gain control. </para>        
				/// </summary>
				/// <returns>
				///  <para>true if the device implements automatic gain control, false otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isAvailable
				/// </java-name>
				public static bool IsAvailable
				{
						[Dot42.DexImport("isAvailable", "()Z", AccessFlags = 9)]
						get{ return default(bool); }
				}

		}

		/// <summary>
		///  <para>Bass boost is an audio effect to boost or amplify low frequencies of the sound. It is comparable to a simple equalizer but limited to one band amplification in the low frequency range. </para> <para>An application creates a BassBoost object to instantiate and control a bass boost engine in the audio framework. </para> <para>The methods, parameter types and units exposed by the BassBoost implementation are directly mapping those defined by the OpenSL ES 1.0.1 Specification () for the SLBassBoostItf interface. Please refer to this specification for more details. </para> <para>To attach the BassBoost to a particular AudioTrack or MediaPlayer, specify the audio session ID of this AudioTrack or MediaPlayer when constructing the BassBoost. </para> <para>NOTE: attaching a BassBoost to the global audio output mix by use of session 0 is deprecated. </para> <para>See android.media.MediaPlayer#getAudioSessionId() for details on audio sessions. </para> <para>See android.media.audiofx.AudioEffect class for more details on controlling audio effects. </para>    
		/// </summary>
		/// <java-name>
		/// android/media/audiofx/BassBoost
		/// </java-name>
		[Dot42.DexImport("android/media/audiofx/BassBoost", AccessFlags = 33)]
		public partial class BassBoost : global::Android.Media.Audiofx.AudioEffect
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Is strength parameter supported by bass boost engine. Parameter ID for getParameter(). </para>        
				/// </summary>
				/// <java-name>
				/// PARAM_STRENGTH_SUPPORTED
				/// </java-name>
				[Dot42.DexImport("PARAM_STRENGTH_SUPPORTED", "I", AccessFlags = 25)]
				public const int PARAM_STRENGTH_SUPPORTED = 0;
				/// <summary>
				///  <para>Bass boost effect strength. Parameter ID for android.media.audiofx.BassBoost.OnParameterChangeListener </para>        
				/// </summary>
				/// <java-name>
				/// PARAM_STRENGTH
				/// </java-name>
				[Dot42.DexImport("PARAM_STRENGTH", "I", AccessFlags = 25)]
				public const int PARAM_STRENGTH = 1;
				/// <summary>
				///  <para>Class constructor. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(II)V", AccessFlags = 1)]
				public BassBoost(int priority, int audioSession) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the strength of the bass boost effect. If the implementation does not support per mille accuracy for setting the strength, it is allowed to round the given strength to the nearest supported value. You can use the getRoundedStrength() method to query the (possibly rounded) value that was actually set. </para>        
				/// </summary>
				/// <java-name>
				/// setStrength
				/// </java-name>
				[Dot42.DexImport("setStrength", "(S)V", AccessFlags = 1)]
				public virtual void SetStrength(short strength) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Registers an OnParameterChangeListener interface. </para>        
				/// </summary>
				/// <java-name>
				/// setParameterListener
				/// </java-name>
				[Dot42.DexImport("setParameterListener", "(Landroid/media/audiofx/BassBoost$OnParameterChangeListener;)V", AccessFlags = 1)]
				public virtual void SetParameterListener(global::Android.Media.Audiofx.BassBoost.IOnParameterChangeListener listener) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal BassBoost() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Indicates whether setting strength is supported. If this method returns false, only one strength is supported and the setStrength() method always rounds to that value. </para>        
				/// </summary>
				/// <returns>
				///  <para>true is strength parameter is supported, false otherwise </para>
				/// </returns>
				/// <java-name>
				/// getStrengthSupported
				/// </java-name>
				public virtual bool StrengthSupported
				{
						[Dot42.DexImport("getStrengthSupported", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Gets the current strength of the effect. </para>        
				/// </summary>
				/// <returns>
				///  <para>the strength of the effect. The valid range for strength is [0, 1000], where 0 per mille designates the mildest effect and 1000 per mille the strongest </para>
				/// </returns>
				/// <java-name>
				/// getRoundedStrength
				/// </java-name>
				public virtual short RoundedStrength
				{
						[Dot42.DexImport("getRoundedStrength", "()S", AccessFlags = 1)]
						get{ return default(short); }
				}

				/// <summary>
				///  <para>Gets the bass boost properties. This method is useful when a snapshot of current bass boost settings must be saved by the application. </para>        
				/// </summary>
				/// <returns>
				///  <para>a BassBoost.Settings object containing all current parameters values </para>
				/// </returns>
				/// <java-name>
				/// getProperties
				/// </java-name>
				public virtual global::Android.Media.Audiofx.BassBoost.Settings Properties
				{
						[Dot42.DexImport("getProperties", "()Landroid/media/audiofx/BassBoost$Settings;", AccessFlags = 1)]
						get{ return default(global::Android.Media.Audiofx.BassBoost.Settings); }
						[Dot42.DexImport("setProperties", "(Landroid/media/audiofx/BassBoost$Settings;)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>The Settings class regroups all bass boost parameters. It is used in conjuntion with getProperties() and setProperties() methods to backup and restore all parameters in a single call. </para>    
				/// </summary>
				/// <java-name>
				/// android/media/audiofx/BassBoost$Settings
				/// </java-name>
				[Dot42.DexImport("android/media/audiofx/BassBoost$Settings", AccessFlags = 9)]
				public partial class Settings
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// strength
						/// </java-name>
						[Dot42.DexImport("strength", "S", AccessFlags = 1)]
						public short Strength;
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public Settings() /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
						public Settings(string @string) /* MethodBuilder.Create */ 
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

				/// <summary>
				///  <para>The OnParameterChangeListener interface defines a method called by the BassBoost when a parameter value has changed. </para>    
				/// </summary>
				/// <java-name>
				/// android/media/audiofx/BassBoost$OnParameterChangeListener
				/// </java-name>
				[Dot42.DexImport("android/media/audiofx/BassBoost$OnParameterChangeListener", AccessFlags = 1545)]
				public partial interface IOnParameterChangeListener
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>Method called when a parameter value has changed. The method is called only if the parameter was changed by another application having the control of the same BassBoost engine. </para>        
						/// </summary>
						/// <java-name>
						/// onParameterChange
						/// </java-name>
						[Dot42.DexImport("onParameterChange", "(Landroid/media/audiofx/BassBoost;IIS)V", AccessFlags = 1025)]
						void OnParameterChange(global::Android.Media.Audiofx.BassBoost effect, int status, int param, short value) /* MethodBuilder.Create */ ;

				}

		}

		/// <summary>
		///  <para>A sound generated within a room travels in many directions. The listener first hears the direct sound from the source itself. Later, he or she hears discrete echoes caused by sound bouncing off nearby walls, the ceiling and the floor. As sound waves arrive after undergoing more and more reflections, individual reflections become indistinguishable and the listener hears continuous reverberation that decays over time. Reverb is vital for modeling a listener's environment. It can be used in music applications to simulate music being played back in various environments, or in games to immerse the listener within the game's environment. The EnvironmentalReverb class allows an application to control each reverb engine property in a global reverb environment and is more suitable for games. For basic control, more suitable for music applications, it is recommended to use the android.media.audiofx.PresetReverb class. </para> <para>An application creates a EnvironmentalReverb object to instantiate and control a reverb engine in the audio framework. </para> <para>The methods, parameter types and units exposed by the EnvironmentalReverb implementation are directly mapping those defined by the OpenSL ES 1.0.1 Specification () for the SLEnvironmentalReverbItf interface. Please refer to this specification for more details. </para> <para>The EnvironmentalReverb is an output mix auxiliary effect and should be created on Audio session 0. In order for a MediaPlayer or AudioTrack to be fed into this effect, they must be explicitely attached to it and a send level must be specified. Use the effect ID returned by getId() method to designate this particular effect when attaching it to the MediaPlayer or AudioTrack. </para> <para>Creating a reverb on the output mix (audio session 0) requires permission android.Manifest.permission#MODIFY_AUDIO_SETTINGS </para> <para>See android.media.audiofx.AudioEffect class for more details on controlling audio effects. </para>    
		/// </summary>
		/// <java-name>
		/// android/media/audiofx/EnvironmentalReverb
		/// </java-name>
		[Dot42.DexImport("android/media/audiofx/EnvironmentalReverb", AccessFlags = 33)]
		public partial class EnvironmentalReverb : global::Android.Media.Audiofx.AudioEffect
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Room level. Parameter ID for OnParameterChangeListener </para>        
				/// </summary>
				/// <java-name>
				/// PARAM_ROOM_LEVEL
				/// </java-name>
				[Dot42.DexImport("PARAM_ROOM_LEVEL", "I", AccessFlags = 25)]
				public const int PARAM_ROOM_LEVEL = 0;
				/// <summary>
				///  <para>Room HF level. Parameter ID for OnParameterChangeListener </para>        
				/// </summary>
				/// <java-name>
				/// PARAM_ROOM_HF_LEVEL
				/// </java-name>
				[Dot42.DexImport("PARAM_ROOM_HF_LEVEL", "I", AccessFlags = 25)]
				public const int PARAM_ROOM_HF_LEVEL = 1;
				/// <summary>
				///  <para>Decay time. Parameter ID for OnParameterChangeListener </para>        
				/// </summary>
				/// <java-name>
				/// PARAM_DECAY_TIME
				/// </java-name>
				[Dot42.DexImport("PARAM_DECAY_TIME", "I", AccessFlags = 25)]
				public const int PARAM_DECAY_TIME = 2;
				/// <summary>
				///  <para>Decay HF ratio. Parameter ID for android.media.audiofx.EnvironmentalReverb.OnParameterChangeListener </para>        
				/// </summary>
				/// <java-name>
				/// PARAM_DECAY_HF_RATIO
				/// </java-name>
				[Dot42.DexImport("PARAM_DECAY_HF_RATIO", "I", AccessFlags = 25)]
				public const int PARAM_DECAY_HF_RATIO = 3;
				/// <summary>
				///  <para>Early reflections level. Parameter ID for OnParameterChangeListener </para>        
				/// </summary>
				/// <java-name>
				/// PARAM_REFLECTIONS_LEVEL
				/// </java-name>
				[Dot42.DexImport("PARAM_REFLECTIONS_LEVEL", "I", AccessFlags = 25)]
				public const int PARAM_REFLECTIONS_LEVEL = 4;
				/// <summary>
				///  <para>Early reflections delay. Parameter ID for OnParameterChangeListener </para>        
				/// </summary>
				/// <java-name>
				/// PARAM_REFLECTIONS_DELAY
				/// </java-name>
				[Dot42.DexImport("PARAM_REFLECTIONS_DELAY", "I", AccessFlags = 25)]
				public const int PARAM_REFLECTIONS_DELAY = 5;
				/// <summary>
				///  <para>Reverb level. Parameter ID for OnParameterChangeListener </para>        
				/// </summary>
				/// <java-name>
				/// PARAM_REVERB_LEVEL
				/// </java-name>
				[Dot42.DexImport("PARAM_REVERB_LEVEL", "I", AccessFlags = 25)]
				public const int PARAM_REVERB_LEVEL = 6;
				/// <summary>
				///  <para>Reverb delay. Parameter ID for OnParameterChangeListener </para>        
				/// </summary>
				/// <java-name>
				/// PARAM_REVERB_DELAY
				/// </java-name>
				[Dot42.DexImport("PARAM_REVERB_DELAY", "I", AccessFlags = 25)]
				public const int PARAM_REVERB_DELAY = 7;
				/// <summary>
				///  <para>Diffusion. Parameter ID for OnParameterChangeListener </para>        
				/// </summary>
				/// <java-name>
				/// PARAM_DIFFUSION
				/// </java-name>
				[Dot42.DexImport("PARAM_DIFFUSION", "I", AccessFlags = 25)]
				public const int PARAM_DIFFUSION = 8;
				/// <summary>
				///  <para>Density. Parameter ID for OnParameterChangeListener </para>        
				/// </summary>
				/// <java-name>
				/// PARAM_DENSITY
				/// </java-name>
				[Dot42.DexImport("PARAM_DENSITY", "I", AccessFlags = 25)]
				public const int PARAM_DENSITY = 9;
				/// <summary>
				///  <para>Class constructor. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(II)V", AccessFlags = 1)]
				public EnvironmentalReverb(int priority, int audioSession) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Registers an OnParameterChangeListener interface. </para>        
				/// </summary>
				/// <java-name>
				/// setParameterListener
				/// </java-name>
				[Dot42.DexImport("setParameterListener", "(Landroid/media/audiofx/EnvironmentalReverb$OnParameterChangeListener;)V", AccessFlags = 1)]
				public virtual void SetParameterListener(global::Android.Media.Audiofx.EnvironmentalReverb.IOnParameterChangeListener listener) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal EnvironmentalReverb() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Gets the master volume level of the environmental reverb effect. </para>        
				/// </summary>
				/// <returns>
				///  <para>the room level in millibels. </para>
				/// </returns>
				/// <java-name>
				/// getRoomLevel
				/// </java-name>
				public virtual short RoomLevel
				{
						[Dot42.DexImport("getRoomLevel", "()S", AccessFlags = 1)]
						get{ return default(short); }
						[Dot42.DexImport("setRoomLevel", "(S)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Gets the room HF level. </para>        
				/// </summary>
				/// <returns>
				///  <para>the room HF level in millibels. </para>
				/// </returns>
				/// <java-name>
				/// getRoomHFLevel
				/// </java-name>
				public virtual short RoomHFLevel
				{
						[Dot42.DexImport("getRoomHFLevel", "()S", AccessFlags = 1)]
						get{ return default(short); }
						[Dot42.DexImport("setRoomHFLevel", "(S)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Gets the decay time. </para>        
				/// </summary>
				/// <returns>
				///  <para>the decay time in milliseconds. </para>
				/// </returns>
				/// <java-name>
				/// getDecayTime
				/// </java-name>
				public virtual int DecayTime
				{
						[Dot42.DexImport("getDecayTime", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setDecayTime", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Gets the ratio of high frequency decay time (at 5 kHz) relative to low frequencies. </para>        
				/// </summary>
				/// <returns>
				///  <para>the decay HF ration. See setDecayHFRatio(short) for units. </para>
				/// </returns>
				/// <java-name>
				/// getDecayHFRatio
				/// </java-name>
				public virtual short DecayHFRatio
				{
						[Dot42.DexImport("getDecayHFRatio", "()S", AccessFlags = 1)]
						get{ return default(short); }
						[Dot42.DexImport("setDecayHFRatio", "(S)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Gets the volume level of the early reflections. </para>        
				/// </summary>
				/// <returns>
				///  <para>the early reflections level in millibels. </para>
				/// </returns>
				/// <java-name>
				/// getReflectionsLevel
				/// </java-name>
				public virtual short ReflectionsLevel
				{
						[Dot42.DexImport("getReflectionsLevel", "()S", AccessFlags = 1)]
						get{ return default(short); }
						[Dot42.DexImport("setReflectionsLevel", "(S)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Gets the reflections delay. </para>        
				/// </summary>
				/// <returns>
				///  <para>the early reflections delay in milliseconds. </para>
				/// </returns>
				/// <java-name>
				/// getReflectionsDelay
				/// </java-name>
				public virtual int ReflectionsDelay
				{
						[Dot42.DexImport("getReflectionsDelay", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setReflectionsDelay", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Gets the reverb level. </para>        
				/// </summary>
				/// <returns>
				///  <para>the reverb level in millibels. </para>
				/// </returns>
				/// <java-name>
				/// getReverbLevel
				/// </java-name>
				public virtual short ReverbLevel
				{
						[Dot42.DexImport("getReverbLevel", "()S", AccessFlags = 1)]
						get{ return default(short); }
						[Dot42.DexImport("setReverbLevel", "(S)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Gets the reverb delay. </para>        
				/// </summary>
				/// <returns>
				///  <para>the reverb delay in milliseconds. </para>
				/// </returns>
				/// <java-name>
				/// getReverbDelay
				/// </java-name>
				public virtual int ReverbDelay
				{
						[Dot42.DexImport("getReverbDelay", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setReverbDelay", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Gets diffusion level. </para>        
				/// </summary>
				/// <returns>
				///  <para>the diffusion level. See setDiffusion(short) for units. </para>
				/// </returns>
				/// <java-name>
				/// getDiffusion
				/// </java-name>
				public virtual short Diffusion
				{
						[Dot42.DexImport("getDiffusion", "()S", AccessFlags = 1)]
						get{ return default(short); }
						[Dot42.DexImport("setDiffusion", "(S)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Gets the density level. </para>        
				/// </summary>
				/// <returns>
				///  <para>the density level. See setDiffusion(short) for units. </para>
				/// </returns>
				/// <java-name>
				/// getDensity
				/// </java-name>
				public virtual short Density
				{
						[Dot42.DexImport("getDensity", "()S", AccessFlags = 1)]
						get{ return default(short); }
						[Dot42.DexImport("setDensity", "(S)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Gets the environmental reverb properties. This method is useful when a snapshot of current reverb settings must be saved by the application. </para>        
				/// </summary>
				/// <returns>
				///  <para>an EnvironmentalReverb.Settings object containing all current parameters values </para>
				/// </returns>
				/// <java-name>
				/// getProperties
				/// </java-name>
				public virtual global::Android.Media.Audiofx.EnvironmentalReverb.Settings Properties
				{
						[Dot42.DexImport("getProperties", "()Landroid/media/audiofx/EnvironmentalReverb$Settings;", AccessFlags = 1)]
						get{ return default(global::Android.Media.Audiofx.EnvironmentalReverb.Settings); }
						[Dot42.DexImport("setProperties", "(Landroid/media/audiofx/EnvironmentalReverb$Settings;)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>The Settings class regroups all environmental reverb parameters. It is used in conjuntion with getProperties() and setProperties() methods to backup and restore all parameters in a single call. </para>    
				/// </summary>
				/// <java-name>
				/// android/media/audiofx/EnvironmentalReverb$Settings
				/// </java-name>
				[Dot42.DexImport("android/media/audiofx/EnvironmentalReverb$Settings", AccessFlags = 9)]
				public partial class Settings
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// roomLevel
						/// </java-name>
						[Dot42.DexImport("roomLevel", "S", AccessFlags = 1)]
						public short RoomLevel;
						/// <java-name>
						/// roomHFLevel
						/// </java-name>
						[Dot42.DexImport("roomHFLevel", "S", AccessFlags = 1)]
						public short RoomHFLevel;
						/// <java-name>
						/// decayTime
						/// </java-name>
						[Dot42.DexImport("decayTime", "I", AccessFlags = 1)]
						public int DecayTime;
						/// <java-name>
						/// decayHFRatio
						/// </java-name>
						[Dot42.DexImport("decayHFRatio", "S", AccessFlags = 1)]
						public short DecayHFRatio;
						/// <java-name>
						/// reflectionsLevel
						/// </java-name>
						[Dot42.DexImport("reflectionsLevel", "S", AccessFlags = 1)]
						public short ReflectionsLevel;
						/// <java-name>
						/// reflectionsDelay
						/// </java-name>
						[Dot42.DexImport("reflectionsDelay", "I", AccessFlags = 1)]
						public int ReflectionsDelay;
						/// <java-name>
						/// reverbLevel
						/// </java-name>
						[Dot42.DexImport("reverbLevel", "S", AccessFlags = 1)]
						public short ReverbLevel;
						/// <java-name>
						/// reverbDelay
						/// </java-name>
						[Dot42.DexImport("reverbDelay", "I", AccessFlags = 1)]
						public int ReverbDelay;
						/// <java-name>
						/// diffusion
						/// </java-name>
						[Dot42.DexImport("diffusion", "S", AccessFlags = 1)]
						public short Diffusion;
						/// <java-name>
						/// density
						/// </java-name>
						[Dot42.DexImport("density", "S", AccessFlags = 1)]
						public short Density;
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public Settings() /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
						public Settings(string @string) /* MethodBuilder.Create */ 
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

				/// <summary>
				///  <para>The OnParameterChangeListener interface defines a method called by the EnvironmentalReverb when a parameter value has changed. </para>    
				/// </summary>
				/// <java-name>
				/// android/media/audiofx/EnvironmentalReverb$OnParameterChangeListener
				/// </java-name>
				[Dot42.DexImport("android/media/audiofx/EnvironmentalReverb$OnParameterChangeListener", AccessFlags = 1545)]
				public partial interface IOnParameterChangeListener
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>Method called when a parameter value has changed. The method is called only if the parameter was changed by another application having the control of the same EnvironmentalReverb engine. </para>        
						/// </summary>
						/// <java-name>
						/// onParameterChange
						/// </java-name>
						[Dot42.DexImport("onParameterChange", "(Landroid/media/audiofx/EnvironmentalReverb;III)V", AccessFlags = 1025)]
						void OnParameterChange(global::Android.Media.Audiofx.EnvironmentalReverb effect, int status, int param, int value) /* MethodBuilder.Create */ ;

				}

		}

		/// <summary>
		///  <para>An Equalizer is used to alter the frequency response of a particular music source or of the main output mix. </para> <para>An application creates an Equalizer object to instantiate and control an Equalizer engine in the audio framework. The application can either simply use predefined presets or have a more precise control of the gain in each frequency band controlled by the equalizer. </para> <para>The methods, parameter types and units exposed by the Equalizer implementation are directly mapping those defined by the OpenSL ES 1.0.1 Specification () for the SLEqualizerItf interface. Please refer to this specification for more details. </para> <para>To attach the Equalizer to a particular AudioTrack or MediaPlayer, specify the audio session ID of this AudioTrack or MediaPlayer when constructing the Equalizer. </para> <para>NOTE: attaching an Equalizer to the global audio output mix by use of session 0 is deprecated. </para> <para>See android.media.MediaPlayer#getAudioSessionId() for details on audio sessions. </para> <para>See android.media.audiofx.AudioEffect class for more details on controlling audio effects. </para>    
		/// </summary>
		/// <java-name>
		/// android/media/audiofx/Equalizer
		/// </java-name>
		[Dot42.DexImport("android/media/audiofx/Equalizer", AccessFlags = 33)]
		public partial class Equalizer : global::Android.Media.Audiofx.AudioEffect
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Number of bands. Parameter ID for OnParameterChangeListener </para>        
				/// </summary>
				/// <java-name>
				/// PARAM_NUM_BANDS
				/// </java-name>
				[Dot42.DexImport("PARAM_NUM_BANDS", "I", AccessFlags = 25)]
				public const int PARAM_NUM_BANDS = 0;
				/// <summary>
				///  <para>Band level range. Parameter ID for OnParameterChangeListener </para>        
				/// </summary>
				/// <java-name>
				/// PARAM_LEVEL_RANGE
				/// </java-name>
				[Dot42.DexImport("PARAM_LEVEL_RANGE", "I", AccessFlags = 25)]
				public const int PARAM_LEVEL_RANGE = 1;
				/// <summary>
				///  <para>Band level. Parameter ID for OnParameterChangeListener </para>        
				/// </summary>
				/// <java-name>
				/// PARAM_BAND_LEVEL
				/// </java-name>
				[Dot42.DexImport("PARAM_BAND_LEVEL", "I", AccessFlags = 25)]
				public const int PARAM_BAND_LEVEL = 2;
				/// <summary>
				///  <para>Band center frequency. Parameter ID for OnParameterChangeListener </para>        
				/// </summary>
				/// <java-name>
				/// PARAM_CENTER_FREQ
				/// </java-name>
				[Dot42.DexImport("PARAM_CENTER_FREQ", "I", AccessFlags = 25)]
				public const int PARAM_CENTER_FREQ = 3;
				/// <summary>
				///  <para>Band frequency range. Parameter ID for android.media.audiofx.Equalizer.OnParameterChangeListener </para>        
				/// </summary>
				/// <java-name>
				/// PARAM_BAND_FREQ_RANGE
				/// </java-name>
				[Dot42.DexImport("PARAM_BAND_FREQ_RANGE", "I", AccessFlags = 25)]
				public const int PARAM_BAND_FREQ_RANGE = 4;
				/// <summary>
				///  <para>Band for a given frequency. Parameter ID for OnParameterChangeListener </para>        
				/// </summary>
				/// <java-name>
				/// PARAM_GET_BAND
				/// </java-name>
				[Dot42.DexImport("PARAM_GET_BAND", "I", AccessFlags = 25)]
				public const int PARAM_GET_BAND = 5;
				/// <summary>
				///  <para>Current preset. Parameter ID for OnParameterChangeListener </para>        
				/// </summary>
				/// <java-name>
				/// PARAM_CURRENT_PRESET
				/// </java-name>
				[Dot42.DexImport("PARAM_CURRENT_PRESET", "I", AccessFlags = 25)]
				public const int PARAM_CURRENT_PRESET = 6;
				/// <summary>
				///  <para>Request number of presets. Parameter ID for OnParameterChangeListener </para>        
				/// </summary>
				/// <java-name>
				/// PARAM_GET_NUM_OF_PRESETS
				/// </java-name>
				[Dot42.DexImport("PARAM_GET_NUM_OF_PRESETS", "I", AccessFlags = 25)]
				public const int PARAM_GET_NUM_OF_PRESETS = 7;
				/// <summary>
				///  <para>Request preset name. Parameter ID for OnParameterChangeListener </para>        
				/// </summary>
				/// <java-name>
				/// PARAM_GET_PRESET_NAME
				/// </java-name>
				[Dot42.DexImport("PARAM_GET_PRESET_NAME", "I", AccessFlags = 25)]
				public const int PARAM_GET_PRESET_NAME = 8;
				/// <summary>
				///  <para>Maximum size for preset name </para>        
				/// </summary>
				/// <java-name>
				/// PARAM_STRING_SIZE_MAX
				/// </java-name>
				[Dot42.DexImport("PARAM_STRING_SIZE_MAX", "I", AccessFlags = 25)]
				public const int PARAM_STRING_SIZE_MAX = 32;
				/// <summary>
				///  <para>Class constructor. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(II)V", AccessFlags = 1)]
				public Equalizer(int priority, int audioSession) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the given equalizer band to the given gain value.  <para>getNumberOfBands() </para></para>        
				/// </summary>
				/// <java-name>
				/// setBandLevel
				/// </java-name>
				[Dot42.DexImport("setBandLevel", "(SS)V", AccessFlags = 1)]
				public virtual void SetBandLevel(short band, short level) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Gets the gain set for the given equalizer band. </para>        
				/// </summary>
				/// <returns>
				///  <para>the gain in millibels of the given band. </para>
				/// </returns>
				/// <java-name>
				/// getBandLevel
				/// </java-name>
				[Dot42.DexImport("getBandLevel", "(S)S", AccessFlags = 1)]
				public virtual short GetBandLevel(short band) /* MethodBuilder.Create */ 
				{
						return default(short);
				}

				/// <summary>
				///  <para>Gets the center frequency of the given band. </para>        
				/// </summary>
				/// <returns>
				///  <para>the center frequency in milliHertz </para>
				/// </returns>
				/// <java-name>
				/// getCenterFreq
				/// </java-name>
				[Dot42.DexImport("getCenterFreq", "(S)I", AccessFlags = 1)]
				public virtual int GetCenterFreq(short band) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Gets the frequency range of the given frequency band. </para>        
				/// </summary>
				/// <returns>
				///  <para>the frequency range in millHertz in an array of integers. The first element is the lower limit of the range, the second element the upper limit. </para>
				/// </returns>
				/// <java-name>
				/// getBandFreqRange
				/// </java-name>
				[Dot42.DexImport("getBandFreqRange", "(S)[I", AccessFlags = 1)]
				public virtual int[] GetBandFreqRange(short band) /* MethodBuilder.Create */ 
				{
						return default(int[]);
				}

				/// <summary>
				///  <para>Gets the band that has the most effect on the given frequency. </para>        
				/// </summary>
				/// <returns>
				///  <para>the frequency band that has most effect on the given frequency. </para>
				/// </returns>
				/// <java-name>
				/// getBand
				/// </java-name>
				[Dot42.DexImport("getBand", "(I)S", AccessFlags = 1)]
				public virtual short GetBand(int frequency) /* MethodBuilder.Create */ 
				{
						return default(short);
				}

				/// <summary>
				///  <para>Sets the equalizer according to the given preset.  <para>getNumberOfPresets() </para></para>        
				/// </summary>
				/// <java-name>
				/// usePreset
				/// </java-name>
				[Dot42.DexImport("usePreset", "(S)V", AccessFlags = 1)]
				public virtual void UsePreset(short preset) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Gets the preset name based on the index. </para>        
				/// </summary>
				/// <returns>
				///  <para>a string containing the name of the given preset. </para>
				/// </returns>
				/// <java-name>
				/// getPresetName
				/// </java-name>
				[Dot42.DexImport("getPresetName", "(S)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetPresetName(short preset) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Registers an OnParameterChangeListener interface. </para>        
				/// </summary>
				/// <java-name>
				/// setParameterListener
				/// </java-name>
				[Dot42.DexImport("setParameterListener", "(Landroid/media/audiofx/Equalizer$OnParameterChangeListener;)V", AccessFlags = 1)]
				public virtual void SetParameterListener(global::Android.Media.Audiofx.Equalizer.IOnParameterChangeListener listener) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal Equalizer() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Gets the number of frequency bands supported by the Equalizer engine. </para>        
				/// </summary>
				/// <returns>
				///  <para>the number of bands </para>
				/// </returns>
				/// <java-name>
				/// getNumberOfBands
				/// </java-name>
				public virtual short NumberOfBands
				{
						[Dot42.DexImport("getNumberOfBands", "()S", AccessFlags = 1)]
						get{ return default(short); }
				}

				/// <summary>
				///  <para>Gets the level range for use by setBandLevel(short,short). The level is expressed in milliBel. </para>        
				/// </summary>
				/// <returns>
				///  <para>the band level range in an array of short integers. The first element is the lower limit of the range, the second element the upper limit. </para>
				/// </returns>
				/// <java-name>
				/// getBandLevelRange
				/// </java-name>
				public virtual short[] BandLevelRange
				{
						[Dot42.DexImport("getBandLevelRange", "()[S", AccessFlags = 1)]
						get{ return default(short[]); }
				}

				/// <summary>
				///  <para>Gets current preset. </para>        
				/// </summary>
				/// <returns>
				///  <para>the preset that is set at the moment. </para>
				/// </returns>
				/// <java-name>
				/// getCurrentPreset
				/// </java-name>
				public virtual short CurrentPreset
				{
						[Dot42.DexImport("getCurrentPreset", "()S", AccessFlags = 1)]
						get{ return default(short); }
				}

				/// <summary>
				///  <para>Gets the total number of presets the equalizer supports. The presets will have indices [0, number of presets-1]. </para>        
				/// </summary>
				/// <returns>
				///  <para>the number of presets the equalizer supports. </para>
				/// </returns>
				/// <java-name>
				/// getNumberOfPresets
				/// </java-name>
				public virtual short NumberOfPresets
				{
						[Dot42.DexImport("getNumberOfPresets", "()S", AccessFlags = 1)]
						get{ return default(short); }
				}

				/// <summary>
				///  <para>Gets the equalizer properties. This method is useful when a snapshot of current equalizer settings must be saved by the application. </para>        
				/// </summary>
				/// <returns>
				///  <para>an Equalizer.Settings object containing all current parameters values </para>
				/// </returns>
				/// <java-name>
				/// getProperties
				/// </java-name>
				public virtual global::Android.Media.Audiofx.Equalizer.Settings Properties
				{
						[Dot42.DexImport("getProperties", "()Landroid/media/audiofx/Equalizer$Settings;", AccessFlags = 1)]
						get{ return default(global::Android.Media.Audiofx.Equalizer.Settings); }
						[Dot42.DexImport("setProperties", "(Landroid/media/audiofx/Equalizer$Settings;)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>The Settings class regroups all equalizer parameters. It is used in conjuntion with getProperties() and setProperties() methods to backup and restore all parameters in a single call. </para>    
				/// </summary>
				/// <java-name>
				/// android/media/audiofx/Equalizer$Settings
				/// </java-name>
				[Dot42.DexImport("android/media/audiofx/Equalizer$Settings", AccessFlags = 9)]
				public partial class Settings
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// curPreset
						/// </java-name>
						[Dot42.DexImport("curPreset", "S", AccessFlags = 1)]
						public short CurPreset;
						/// <java-name>
						/// numBands
						/// </java-name>
						[Dot42.DexImport("numBands", "S", AccessFlags = 1)]
						public short NumBands;
						/// <java-name>
						/// bandLevels
						/// </java-name>
						[Dot42.DexImport("bandLevels", "[S", AccessFlags = 1)]
						public short[] BandLevels;
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public Settings() /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
						public Settings(string @string) /* MethodBuilder.Create */ 
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

				/// <summary>
				///  <para>The OnParameterChangeListener interface defines a method called by the Equalizer when a parameter value has changed. </para>    
				/// </summary>
				/// <java-name>
				/// android/media/audiofx/Equalizer$OnParameterChangeListener
				/// </java-name>
				[Dot42.DexImport("android/media/audiofx/Equalizer$OnParameterChangeListener", AccessFlags = 1545)]
				public partial interface IOnParameterChangeListener
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>Method called when a parameter value has changed. The method is called only if the parameter was changed by another application having the control of the same Equalizer engine. </para>        
						/// </summary>
						/// <java-name>
						/// onParameterChange
						/// </java-name>
						[Dot42.DexImport("onParameterChange", "(Landroid/media/audiofx/Equalizer;IIII)V", AccessFlags = 1025)]
						void OnParameterChange(global::Android.Media.Audiofx.Equalizer effect, int status, int param1, int param2, int value) /* MethodBuilder.Create */ ;

				}

		}

		/// <summary>
		///  <para>Noise Suppressor (NS). </para> <para>Noise suppression (NS) is an audio pre-processing which removes background noise from the captured signal. The component of the signal considered as noise can be either stationary (car/airplane engine, AC system) or non-stationary (other peoples conversations, car horn) for more advanced implementations. </para> <para>NS is mostly used by voice communication applications (voice chat, video conferencing, SIP calls). </para> <para>An application creates a NoiseSuppressor object to instantiate and control an NS engine in the audio framework. </para> <para>To attach the NoiseSuppressor to a particular android.media.AudioRecord, specify the audio session ID of this AudioRecord when creating the NoiseSuppressor. The audio session is retrieved by calling android.media.AudioRecord#getAudioSessionId() on the AudioRecord instance. </para> <para>On some devices, NS can be inserted by default in the capture path by the platform according to the android.media.MediaRecorder.AudioSource used. The application should call NoiseSuppressor.getEnable() after creating the NS to check the default NS activation state on a particular AudioRecord session. </para> <para>See android.media.audiofx.AudioEffect class for more details on controlling audio effects. </para>    
		/// </summary>
		/// <java-name>
		/// android/media/audiofx/NoiseSuppressor
		/// </java-name>
		[Dot42.DexImport("android/media/audiofx/NoiseSuppressor", AccessFlags = 33)]
		public partial class NoiseSuppressor : global::Android.Media.Audiofx.AudioEffect
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal NoiseSuppressor() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Creates a NoiseSuppressor and attaches it to the AudioRecord on the audio session specified. </para>        
				/// </summary>
				/// <returns>
				///  <para>NoiseSuppressor created or null if the device does not implement noise suppression. </para>
				/// </returns>
				/// <java-name>
				/// create
				/// </java-name>
				[Dot42.DexImport("create", "(I)Landroid/media/audiofx/NoiseSuppressor;", AccessFlags = 9)]
				public static global::Android.Media.Audiofx.NoiseSuppressor Create(int audioSession) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Media.Audiofx.NoiseSuppressor);
				}

				/// <summary>
				///  <para>Checks if the device implements noise suppression. </para>        
				/// </summary>
				/// <returns>
				///  <para>true if the device implements noise suppression, false otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isAvailable
				/// </java-name>
				public static bool IsAvailable
				{
						[Dot42.DexImport("isAvailable", "()Z", AccessFlags = 9)]
						get{ return default(bool); }
				}

		}

		/// <summary>
		///  <para>A sound generated within a room travels in many directions. The listener first hears the direct sound from the source itself. Later, he or she hears discrete echoes caused by sound bouncing off nearby walls, the ceiling and the floor. As sound waves arrive after undergoing more and more reflections, individual reflections become indistinguishable and the listener hears continuous reverberation that decays over time. Reverb is vital for modeling a listener's environment. It can be used in music applications to simulate music being played back in various environments, or in games to immerse the listener within the game's environment. The PresetReverb class allows an application to configure the global reverb using a reverb preset. This is primarily used for adding some reverb in a music playback context. Applications requiring control over a more advanced environmental reverb are advised to use the android.media.audiofx.EnvironmentalReverb class. </para> <para>An application creates a PresetReverb object to instantiate and control a reverb engine in the audio framework. </para> <para>The methods, parameter types and units exposed by the PresetReverb implementation are directly mapping those defined by the OpenSL ES 1.0.1 Specification () for the SLPresetReverbItf interface. Please refer to this specification for more details. </para> <para>The PresetReverb is an output mix auxiliary effect and should be created on Audio session 0. In order for a MediaPlayer or AudioTrack to be fed into this effect, they must be explicitely attached to it and a send level must be specified. Use the effect ID returned by getId() method to designate this particular effect when attaching it to the MediaPlayer or AudioTrack. </para> <para>Creating a reverb on the output mix (audio session 0) requires permission android.Manifest.permission#MODIFY_AUDIO_SETTINGS </para> <para>See android.media.audiofx.AudioEffect class for more details on controlling audio effects. </para>    
		/// </summary>
		/// <java-name>
		/// android/media/audiofx/PresetReverb
		/// </java-name>
		[Dot42.DexImport("android/media/audiofx/PresetReverb", AccessFlags = 33)]
		public partial class PresetReverb : global::Android.Media.Audiofx.AudioEffect
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Preset. Parameter ID for android.media.audiofx.PresetReverb.OnParameterChangeListener </para>        
				/// </summary>
				/// <java-name>
				/// PARAM_PRESET
				/// </java-name>
				[Dot42.DexImport("PARAM_PRESET", "I", AccessFlags = 25)]
				public const int PARAM_PRESET = 0;
				/// <summary>
				///  <para>No reverb or reflections </para>        
				/// </summary>
				/// <java-name>
				/// PRESET_NONE
				/// </java-name>
				[Dot42.DexImport("PRESET_NONE", "S", AccessFlags = 25)]
				public const short PRESET_NONE = 0;
				/// <summary>
				///  <para>Reverb preset representing a small room less than five meters in length </para>        
				/// </summary>
				/// <java-name>
				/// PRESET_SMALLROOM
				/// </java-name>
				[Dot42.DexImport("PRESET_SMALLROOM", "S", AccessFlags = 25)]
				public const short PRESET_SMALLROOM = 1;
				/// <summary>
				///  <para>Reverb preset representing a medium room with a length of ten meters or less </para>        
				/// </summary>
				/// <java-name>
				/// PRESET_MEDIUMROOM
				/// </java-name>
				[Dot42.DexImport("PRESET_MEDIUMROOM", "S", AccessFlags = 25)]
				public const short PRESET_MEDIUMROOM = 2;
				/// <summary>
				///  <para>Reverb preset representing a large-sized room suitable for live performances </para>        
				/// </summary>
				/// <java-name>
				/// PRESET_LARGEROOM
				/// </java-name>
				[Dot42.DexImport("PRESET_LARGEROOM", "S", AccessFlags = 25)]
				public const short PRESET_LARGEROOM = 3;
				/// <summary>
				///  <para>Reverb preset representing a medium-sized hall </para>        
				/// </summary>
				/// <java-name>
				/// PRESET_MEDIUMHALL
				/// </java-name>
				[Dot42.DexImport("PRESET_MEDIUMHALL", "S", AccessFlags = 25)]
				public const short PRESET_MEDIUMHALL = 4;
				/// <summary>
				///  <para>Reverb preset representing a large-sized hall suitable for a full orchestra </para>        
				/// </summary>
				/// <java-name>
				/// PRESET_LARGEHALL
				/// </java-name>
				[Dot42.DexImport("PRESET_LARGEHALL", "S", AccessFlags = 25)]
				public const short PRESET_LARGEHALL = 5;
				/// <summary>
				///  <para>Reverb preset representing a synthesis of the traditional plate reverb </para>        
				/// </summary>
				/// <java-name>
				/// PRESET_PLATE
				/// </java-name>
				[Dot42.DexImport("PRESET_PLATE", "S", AccessFlags = 25)]
				public const short PRESET_PLATE = 6;
				/// <summary>
				///  <para>Class constructor. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(II)V", AccessFlags = 1)]
				public PresetReverb(int priority, int audioSession) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Registers an OnParameterChangeListener interface. </para>        
				/// </summary>
				/// <java-name>
				/// setParameterListener
				/// </java-name>
				[Dot42.DexImport("setParameterListener", "(Landroid/media/audiofx/PresetReverb$OnParameterChangeListener;)V", AccessFlags = 1)]
				public virtual void SetParameterListener(global::Android.Media.Audiofx.PresetReverb.IOnParameterChangeListener listener) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal PresetReverb() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Gets current reverb preset. </para>        
				/// </summary>
				/// <returns>
				///  <para>the preset that is set at the moment. </para>
				/// </returns>
				/// <java-name>
				/// getPreset
				/// </java-name>
				public virtual short Preset
				{
						[Dot42.DexImport("getPreset", "()S", AccessFlags = 1)]
						get{ return default(short); }
						[Dot42.DexImport("setPreset", "(S)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Gets the preset reverb properties. This method is useful when a snapshot of current preset reverb settings must be saved by the application. </para>        
				/// </summary>
				/// <returns>
				///  <para>a PresetReverb.Settings object containing all current parameters values </para>
				/// </returns>
				/// <java-name>
				/// getProperties
				/// </java-name>
				public virtual global::Android.Media.Audiofx.PresetReverb.Settings Properties
				{
						[Dot42.DexImport("getProperties", "()Landroid/media/audiofx/PresetReverb$Settings;", AccessFlags = 1)]
						get{ return default(global::Android.Media.Audiofx.PresetReverb.Settings); }
						[Dot42.DexImport("setProperties", "(Landroid/media/audiofx/PresetReverb$Settings;)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>The Settings class regroups all preset reverb parameters. It is used in conjuntion with getProperties() and setProperties() methods to backup and restore all parameters in a single call. </para>    
				/// </summary>
				/// <java-name>
				/// android/media/audiofx/PresetReverb$Settings
				/// </java-name>
				[Dot42.DexImport("android/media/audiofx/PresetReverb$Settings", AccessFlags = 9)]
				public partial class Settings
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// preset
						/// </java-name>
						[Dot42.DexImport("preset", "S", AccessFlags = 1)]
						public short Preset;
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public Settings() /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
						public Settings(string @string) /* MethodBuilder.Create */ 
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

				/// <summary>
				///  <para>The OnParameterChangeListener interface defines a method called by the PresetReverb when a parameter value has changed. </para>    
				/// </summary>
				/// <java-name>
				/// android/media/audiofx/PresetReverb$OnParameterChangeListener
				/// </java-name>
				[Dot42.DexImport("android/media/audiofx/PresetReverb$OnParameterChangeListener", AccessFlags = 1545)]
				public partial interface IOnParameterChangeListener
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>Method called when a parameter value has changed. The method is called only if the parameter was changed by another application having the control of the same PresetReverb engine. </para>        
						/// </summary>
						/// <java-name>
						/// onParameterChange
						/// </java-name>
						[Dot42.DexImport("onParameterChange", "(Landroid/media/audiofx/PresetReverb;IIS)V", AccessFlags = 1025)]
						void OnParameterChange(global::Android.Media.Audiofx.PresetReverb effect, int status, int param, short value) /* MethodBuilder.Create */ ;

				}

		}

		/// <summary>
		///  <para>An audio virtualizer is a general name for an effect to spatialize audio channels. The exact behavior of this effect is dependent on the number of audio input channels and the types and number of audio output channels of the device. For example, in the case of a stereo input and stereo headphone output, a stereo widening effect is used when this effect is turned on. </para> <para>An application creates a Virtualizer object to instantiate and control a virtualizer engine in the audio framework. </para> <para>The methods, parameter types and units exposed by the Virtualizer implementation are directly mapping those defined by the OpenSL ES 1.0.1 Specification () for the SLVirtualizerItf interface. Please refer to this specification for more details. </para> <para>To attach the Virtualizer to a particular AudioTrack or MediaPlayer, specify the audio session ID of this AudioTrack or MediaPlayer when constructing the Virtualizer. </para> <para>NOTE: attaching a Virtualizer to the global audio output mix by use of session 0 is deprecated. </para> <para>See android.media.MediaPlayer#getAudioSessionId() for details on audio sessions. </para> <para>See android.media.audiofx.AudioEffect class for more details on controlling audio effects. </para>    
		/// </summary>
		/// <java-name>
		/// android/media/audiofx/Virtualizer
		/// </java-name>
		[Dot42.DexImport("android/media/audiofx/Virtualizer", AccessFlags = 33)]
		public partial class Virtualizer : global::Android.Media.Audiofx.AudioEffect
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Is strength parameter supported by virtualizer engine. Parameter ID for getParameter(). </para>        
				/// </summary>
				/// <java-name>
				/// PARAM_STRENGTH_SUPPORTED
				/// </java-name>
				[Dot42.DexImport("PARAM_STRENGTH_SUPPORTED", "I", AccessFlags = 25)]
				public const int PARAM_STRENGTH_SUPPORTED = 0;
				/// <summary>
				///  <para>Virtualizer effect strength. Parameter ID for android.media.audiofx.Virtualizer.OnParameterChangeListener </para>        
				/// </summary>
				/// <java-name>
				/// PARAM_STRENGTH
				/// </java-name>
				[Dot42.DexImport("PARAM_STRENGTH", "I", AccessFlags = 25)]
				public const int PARAM_STRENGTH = 1;
				/// <summary>
				///  <para>Class constructor. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(II)V", AccessFlags = 1)]
				public Virtualizer(int priority, int audioSession) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the strength of the virtualizer effect. If the implementation does not support per mille accuracy for setting the strength, it is allowed to round the given strength to the nearest supported value. You can use the getRoundedStrength() method to query the (possibly rounded) value that was actually set. </para>        
				/// </summary>
				/// <java-name>
				/// setStrength
				/// </java-name>
				[Dot42.DexImport("setStrength", "(S)V", AccessFlags = 1)]
				public virtual void SetStrength(short strength) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Registers an OnParameterChangeListener interface. </para>        
				/// </summary>
				/// <java-name>
				/// setParameterListener
				/// </java-name>
				[Dot42.DexImport("setParameterListener", "(Landroid/media/audiofx/Virtualizer$OnParameterChangeListener;)V", AccessFlags = 1)]
				public virtual void SetParameterListener(global::Android.Media.Audiofx.Virtualizer.IOnParameterChangeListener listener) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal Virtualizer() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Indicates whether setting strength is supported. If this method returns false, only one strength is supported and the setStrength() method always rounds to that value. </para>        
				/// </summary>
				/// <returns>
				///  <para>true is strength parameter is supported, false otherwise </para>
				/// </returns>
				/// <java-name>
				/// getStrengthSupported
				/// </java-name>
				public virtual bool StrengthSupported
				{
						[Dot42.DexImport("getStrengthSupported", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Gets the current strength of the effect. </para>        
				/// </summary>
				/// <returns>
				///  <para>the strength of the effect. The valid range for strength is [0, 1000], where 0 per mille designates the mildest effect and 1000 per mille the strongest </para>
				/// </returns>
				/// <java-name>
				/// getRoundedStrength
				/// </java-name>
				public virtual short RoundedStrength
				{
						[Dot42.DexImport("getRoundedStrength", "()S", AccessFlags = 1)]
						get{ return default(short); }
				}

				/// <summary>
				///  <para>Gets the virtualizer properties. This method is useful when a snapshot of current virtualizer settings must be saved by the application. </para>        
				/// </summary>
				/// <returns>
				///  <para>a Virtualizer.Settings object containing all current parameters values </para>
				/// </returns>
				/// <java-name>
				/// getProperties
				/// </java-name>
				public virtual global::Android.Media.Audiofx.Virtualizer.Settings Properties
				{
						[Dot42.DexImport("getProperties", "()Landroid/media/audiofx/Virtualizer$Settings;", AccessFlags = 1)]
						get{ return default(global::Android.Media.Audiofx.Virtualizer.Settings); }
						[Dot42.DexImport("setProperties", "(Landroid/media/audiofx/Virtualizer$Settings;)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>The Settings class regroups all virtualizer parameters. It is used in conjuntion with getProperties() and setProperties() methods to backup and restore all parameters in a single call. </para>    
				/// </summary>
				/// <java-name>
				/// android/media/audiofx/Virtualizer$Settings
				/// </java-name>
				[Dot42.DexImport("android/media/audiofx/Virtualizer$Settings", AccessFlags = 9)]
				public partial class Settings
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// strength
						/// </java-name>
						[Dot42.DexImport("strength", "S", AccessFlags = 1)]
						public short Strength;
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public Settings() /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
						public Settings(string @string) /* MethodBuilder.Create */ 
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

				/// <summary>
				///  <para>The OnParameterChangeListener interface defines a method called by the Virtualizer when a parameter value has changed. </para>    
				/// </summary>
				/// <java-name>
				/// android/media/audiofx/Virtualizer$OnParameterChangeListener
				/// </java-name>
				[Dot42.DexImport("android/media/audiofx/Virtualizer$OnParameterChangeListener", AccessFlags = 1545)]
				public partial interface IOnParameterChangeListener
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>Method called when a parameter value has changed. The method is called only if the parameter was changed by another application having the control of the same Virtualizer engine. </para>        
						/// </summary>
						/// <java-name>
						/// onParameterChange
						/// </java-name>
						[Dot42.DexImport("onParameterChange", "(Landroid/media/audiofx/Virtualizer;IIS)V", AccessFlags = 1025)]
						void OnParameterChange(global::Android.Media.Audiofx.Virtualizer effect, int status, int param, short value) /* MethodBuilder.Create */ ;

				}

		}

		/// <summary>
		///  <para>The Visualizer class enables application to retrieve part of the currently playing audio for visualization purpose. It is not an audio recording interface and only returns partial and low quality audio content. However, to protect privacy of certain audio data (e.g voice mail) the use of the visualizer requires the permission android.permission.RECORD_AUDIO. </para> <para>The audio session ID passed to the constructor indicates which audio content should be visualized: <br></br>  <ul> <li> <para>If the session is 0, the audio output mix is visualized </para></li> <li> <para>If the session is not 0, the audio from a particular android.media.MediaPlayer or android.media.AudioTrack using this audio session is visualized  </para></li></ul></para> <para>Two types of representation of audio content can be captured:  <br></br>  <ul> <li> <para>Waveform data: consecutive 8-bit (unsigned) mono samples by using the getWaveForm(byte[]) method </para></li> <li> <para>Frequency data: 8-bit magnitude FFT by using the getFft(byte[]) method </para></li></ul></para> <para>The length of the capture can be retrieved or specified by calling respectively getCaptureSize() and setCaptureSize(int) methods. The capture size must be a power of 2 in the range returned by getCaptureSizeRange(). </para> <para>In addition to the polling capture mode described above with getWaveForm(byte[]) and getFft(byte[]) methods, a callback mode is also available by installing a listener by use of the setDataCaptureListener(OnDataCaptureListener, int, boolean, boolean) method. The rate at which the listener capture method is called as well as the type of data returned is specified. </para> <para>Before capturing data, the Visualizer must be enabled by calling the setEnabled(boolean) method. When data capture is not needed any more, the Visualizer should be disabled. </para> <para>It is good practice to call the release() method when the Visualizer is not used anymore to free up native resources associated to the Visualizer instance. </para> <para>Creating a Visualizer on the output mix (audio session 0) requires permission android.Manifest.permission#MODIFY_AUDIO_SETTINGS </para> <para>The Visualizer class can also be used to perform measurements on the audio being played back. The measurements to perform are defined by setting a mask of the requested measurement modes with setMeasurementMode(int). Supported values are MEASUREMENT_MODE_NONE to cancel any measurement, and MEASUREMENT_MODE_PEAK_RMS for peak and RMS monitoring. Measurements can be retrieved through getMeasurementPeakRms(MeasurementPeakRms). </para>    
		/// </summary>
		/// <java-name>
		/// android/media/audiofx/Visualizer
		/// </java-name>
		[Dot42.DexImport("android/media/audiofx/Visualizer", AccessFlags = 33)]
		public partial class Visualizer
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>State of a Visualizer object that was not successfully initialized upon creation </para>        
				/// </summary>
				/// <java-name>
				/// STATE_UNINITIALIZED
				/// </java-name>
				[Dot42.DexImport("STATE_UNINITIALIZED", "I", AccessFlags = 25)]
				public const int STATE_UNINITIALIZED = 0;
				/// <summary>
				///  <para>State of a Visualizer object that is ready to be used. </para>        
				/// </summary>
				/// <java-name>
				/// STATE_INITIALIZED
				/// </java-name>
				[Dot42.DexImport("STATE_INITIALIZED", "I", AccessFlags = 25)]
				public const int STATE_INITIALIZED = 1;
				/// <summary>
				///  <para>State of a Visualizer object that is active. </para>        
				/// </summary>
				/// <java-name>
				/// STATE_ENABLED
				/// </java-name>
				[Dot42.DexImport("STATE_ENABLED", "I", AccessFlags = 25)]
				public const int STATE_ENABLED = 2;
				/// <summary>
				///  <para>Defines a capture mode where amplification is applied based on the content of the captured data. This is the default Visualizer mode, and is suitable for music visualization. </para>        
				/// </summary>
				/// <java-name>
				/// SCALING_MODE_NORMALIZED
				/// </java-name>
				[Dot42.DexImport("SCALING_MODE_NORMALIZED", "I", AccessFlags = 25)]
				public const int SCALING_MODE_NORMALIZED = 0;
				/// <summary>
				///  <para>Defines a capture mode where the playback volume will affect (scale) the range of the captured data. A low playback volume will lead to low sample and fft values, and vice-versa. </para>        
				/// </summary>
				/// <java-name>
				/// SCALING_MODE_AS_PLAYED
				/// </java-name>
				[Dot42.DexImport("SCALING_MODE_AS_PLAYED", "I", AccessFlags = 25)]
				public const int SCALING_MODE_AS_PLAYED = 1;
				/// <summary>
				///  <para>Successful operation. </para>        
				/// </summary>
				/// <java-name>
				/// SUCCESS
				/// </java-name>
				[Dot42.DexImport("SUCCESS", "I", AccessFlags = 25)]
				public const int SUCCESS = 0;
				/// <summary>
				///  <para>Unspecified error. </para>        
				/// </summary>
				/// <java-name>
				/// ERROR
				/// </java-name>
				[Dot42.DexImport("ERROR", "I", AccessFlags = 25)]
				public const int ERROR = -1;
				/// <summary>
				///  <para>Internal operation status. Not returned by any method. </para>        
				/// </summary>
				/// <java-name>
				/// ALREADY_EXISTS
				/// </java-name>
				[Dot42.DexImport("ALREADY_EXISTS", "I", AccessFlags = 25)]
				public const int ALREADY_EXISTS = -2;
				/// <summary>
				///  <para>Operation failed due to bad object initialization. </para>        
				/// </summary>
				/// <java-name>
				/// ERROR_NO_INIT
				/// </java-name>
				[Dot42.DexImport("ERROR_NO_INIT", "I", AccessFlags = 25)]
				public const int ERROR_NO_INIT = -3;
				/// <summary>
				///  <para>Operation failed due to bad parameter value. </para>        
				/// </summary>
				/// <java-name>
				/// ERROR_BAD_VALUE
				/// </java-name>
				[Dot42.DexImport("ERROR_BAD_VALUE", "I", AccessFlags = 25)]
				public const int ERROR_BAD_VALUE = -4;
				/// <summary>
				///  <para>Operation failed because it was requested in wrong state. </para>        
				/// </summary>
				/// <java-name>
				/// ERROR_INVALID_OPERATION
				/// </java-name>
				[Dot42.DexImport("ERROR_INVALID_OPERATION", "I", AccessFlags = 25)]
				public const int ERROR_INVALID_OPERATION = -5;
				/// <summary>
				///  <para>Operation failed due to lack of memory. </para>        
				/// </summary>
				/// <java-name>
				/// ERROR_NO_MEMORY
				/// </java-name>
				[Dot42.DexImport("ERROR_NO_MEMORY", "I", AccessFlags = 25)]
				public const int ERROR_NO_MEMORY = -6;
				/// <summary>
				///  <para>Operation failed due to dead remote object. </para>        
				/// </summary>
				/// <java-name>
				/// ERROR_DEAD_OBJECT
				/// </java-name>
				[Dot42.DexImport("ERROR_DEAD_OBJECT", "I", AccessFlags = 25)]
				public const int ERROR_DEAD_OBJECT = -7;
				/// <summary>
				///  <para>Class constructor. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public Visualizer(int audioSession) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Releases the native Visualizer resources. It is a good practice to release the visualization engine when not in use. </para>        
				/// </summary>
				/// <java-name>
				/// release
				/// </java-name>
				[Dot42.DexImport("release", "()V", AccessFlags = 1)]
				public virtual void Release() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// finalize
				/// </java-name>
				[Dot42.DexImport("finalize", "()V", AccessFlags = 4)]
				extern ~Visualizer() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Enable or disable the visualization engine. </para>        
				/// </summary>
				/// <returns>
				///  <para>SUCCESS in case of success, ERROR_INVALID_OPERATION or ERROR_DEAD_OBJECT in case of failure. </para>
				/// </returns>
				/// <java-name>
				/// setEnabled
				/// </java-name>
				[Dot42.DexImport("setEnabled", "(Z)I", AccessFlags = 1)]
				public virtual int SetEnabled(bool enabled) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Sets the capture size, i.e. the number of bytes returned by getWaveForm(byte[]) and getFft(byte[]) methods. The capture size must be a power of 2 in the range returned by getCaptureSizeRange(). This method must not be called when the Visualizer is enabled. </para>        
				/// </summary>
				/// <returns>
				///  <para>SUCCESS in case of success, ERROR_BAD_VALUE in case of failure. </para>
				/// </returns>
				/// <java-name>
				/// setCaptureSize
				/// </java-name>
				[Dot42.DexImport("setCaptureSize", "(I)I", AccessFlags = 1)]
				public virtual int SetCaptureSize(int size) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Set the type of scaling applied on the captured visualization data. </para>        
				/// </summary>
				/// <returns>
				///  <para>SUCCESS in case of success, ERROR_BAD_VALUE in case of failure. </para>
				/// </returns>
				/// <java-name>
				/// setScalingMode
				/// </java-name>
				[Dot42.DexImport("setScalingMode", "(I)I", AccessFlags = 1)]
				public virtual int SetScalingMode(int mode) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Returns a waveform capture of currently playing audio content. The capture consists in a number of consecutive 8-bit (unsigned) mono PCM samples equal to the capture size returned by getCaptureSize(). </para> <para>This method must be called when the Visualizer is enabled. </para>        
				/// </summary>
				/// <returns>
				///  <para>SUCCESS in case of success, ERROR_NO_MEMORY, ERROR_INVALID_OPERATION or ERROR_DEAD_OBJECT in case of failure. </para>
				/// </returns>
				/// <java-name>
				/// getWaveForm
				/// </java-name>
				[Dot42.DexImport("getWaveForm", "([B)I", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual int GetWaveForm(sbyte[] waveform) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Returns a waveform capture of currently playing audio content. The capture consists in a number of consecutive 8-bit (unsigned) mono PCM samples equal to the capture size returned by getCaptureSize(). </para> <para>This method must be called when the Visualizer is enabled. </para>        
				/// </summary>
				/// <returns>
				///  <para>SUCCESS in case of success, ERROR_NO_MEMORY, ERROR_INVALID_OPERATION or ERROR_DEAD_OBJECT in case of failure. </para>
				/// </returns>
				/// <java-name>
				/// getWaveForm
				/// </java-name>
				[Dot42.DexImport("getWaveForm", "([B)I", AccessFlags = 1)]
				public virtual int GetWaveForm(byte[] waveform) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Returns a frequency capture of currently playing audio content. </para> <para>This method must be called when the Visualizer is enabled. </para> <para>The capture is an 8-bit magnitude FFT, the frequency range covered being 0 (DC) to half of the sampling rate returned by getSamplingRate(). The capture returns the real and imaginary parts of a number of frequency points equal to half of the capture size plus one. </para> <para>Note: only the real part is returned for the first point (DC) and the last point (sampling frequency / 2). </para> <para>The layout in the returned byte array is as follows:  <ul> <li> <para>n is the capture size returned by getCaptureSize() </para></li> <li> <para>Rfk, Ifk are respectively the real and imaginary parts of the kth frequency component </para></li> <li> <para>If Fs is the sampling frequency retuned by getSamplingRate() the kth frequency is: (k*Fs)/(n/2)  </para></li></ul> <table> <row> <entry> <para>Index </para> <para></para></entry> <entry> <para>0 </para> <para></para></entry> <entry> <para>1 </para> <para></para></entry> <entry> <para>2 </para> <para></para></entry> <entry> <para>3 </para> <para></para></entry> <entry> <para>4 </para> <para></para></entry> <entry> <para>5 </para> <para></para></entry> <entry> <para>... </para> <para></para></entry> <entry> <para>n - 2 </para> <para></para></entry> <entry> <para>n - 1 </para> <para></para></entry></row> <row> <entry> <para>Data </para> <para></para></entry> <entry> <para>Rf0 </para> <para></para></entry> <entry> <para>Rf(n/2) </para> <para></para></entry> <entry> <para>Rf1 </para> <para></para></entry> <entry> <para>If1 </para> <para></para></entry> <entry> <para>Rf2 </para> <para></para></entry> <entry> <para>If2 </para> <para></para></entry> <entry> <para>... </para> <para></para></entry> <entry> <para>Rf(n-1)/2 </para> <para></para></entry> <entry> <para>If(n-1)/2 </para> <para></para></entry></row></table></para>        
				/// </summary>
				/// <returns>
				///  <para>SUCCESS in case of success, ERROR_NO_MEMORY, ERROR_INVALID_OPERATION or ERROR_DEAD_OBJECT in case of failure. </para>
				/// </returns>
				/// <java-name>
				/// getFft
				/// </java-name>
				[Dot42.DexImport("getFft", "([B)I", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual int GetFft(sbyte[] fft) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Returns a frequency capture of currently playing audio content. </para> <para>This method must be called when the Visualizer is enabled. </para> <para>The capture is an 8-bit magnitude FFT, the frequency range covered being 0 (DC) to half of the sampling rate returned by getSamplingRate(). The capture returns the real and imaginary parts of a number of frequency points equal to half of the capture size plus one. </para> <para>Note: only the real part is returned for the first point (DC) and the last point (sampling frequency / 2). </para> <para>The layout in the returned byte array is as follows:  <ul> <li> <para>n is the capture size returned by getCaptureSize() </para></li> <li> <para>Rfk, Ifk are respectively the real and imaginary parts of the kth frequency component </para></li> <li> <para>If Fs is the sampling frequency retuned by getSamplingRate() the kth frequency is: (k*Fs)/(n/2)  </para></li></ul> <table> <row> <entry> <para>Index </para> <para></para></entry> <entry> <para>0 </para> <para></para></entry> <entry> <para>1 </para> <para></para></entry> <entry> <para>2 </para> <para></para></entry> <entry> <para>3 </para> <para></para></entry> <entry> <para>4 </para> <para></para></entry> <entry> <para>5 </para> <para></para></entry> <entry> <para>... </para> <para></para></entry> <entry> <para>n - 2 </para> <para></para></entry> <entry> <para>n - 1 </para> <para></para></entry></row> <row> <entry> <para>Data </para> <para></para></entry> <entry> <para>Rf0 </para> <para></para></entry> <entry> <para>Rf(n/2) </para> <para></para></entry> <entry> <para>Rf1 </para> <para></para></entry> <entry> <para>If1 </para> <para></para></entry> <entry> <para>Rf2 </para> <para></para></entry> <entry> <para>If2 </para> <para></para></entry> <entry> <para>... </para> <para></para></entry> <entry> <para>Rf(n-1)/2 </para> <para></para></entry> <entry> <para>If(n-1)/2 </para> <para></para></entry></row></table></para>        
				/// </summary>
				/// <returns>
				///  <para>SUCCESS in case of success, ERROR_NO_MEMORY, ERROR_INVALID_OPERATION or ERROR_DEAD_OBJECT in case of failure. </para>
				/// </returns>
				/// <java-name>
				/// getFft
				/// </java-name>
				[Dot42.DexImport("getFft", "([B)I", AccessFlags = 1)]
				public virtual int GetFft(byte[] fft) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Registers an OnDataCaptureListener interface and specifies the rate at which the capture should be updated as well as the type of capture requested. </para> <para>Call this method with a null listener to stop receiving the capture updates. </para>        
				/// </summary>
				/// <returns>
				///  <para>SUCCESS in case of success, ERROR_NO_INIT or ERROR_BAD_VALUE in case of failure. </para>
				/// </returns>
				/// <java-name>
				/// setDataCaptureListener
				/// </java-name>
				[Dot42.DexImport("setDataCaptureListener", "(Landroid/media/audiofx/Visualizer$OnDataCaptureListener;IZZ)I", AccessFlags = 1)]
				public virtual int SetDataCaptureListener(global::Android.Media.Audiofx.Visualizer.IOnDataCaptureListener listener, int rate, bool waveform, bool fft) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal Visualizer() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Get current activation state of the visualizer. </para>        
				/// </summary>
				/// <returns>
				///  <para>true if the visualizer is active, false otherwise </para>
				/// </returns>
				/// <java-name>
				/// getEnabled
				/// </java-name>
				public virtual bool Enabled
				{
						[Dot42.DexImport("getEnabled", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Returns the capture size range. </para>        
				/// </summary>
				/// <returns>
				///  <para>the mininum capture size is returned in first array element and the maximum in second array element. </para>
				/// </returns>
				/// <java-name>
				/// getCaptureSizeRange
				/// </java-name>
				public static int[] CaptureSizeRange
				{
						[Dot42.DexImport("getCaptureSizeRange", "()[I", AccessFlags = 265)]
						get{ return default(int[]); }
				}

				/// <summary>
				///  <para>Returns the maximum capture rate for the callback capture method. This is the maximum value for the rate parameter of the setDataCaptureListener(OnDataCaptureListener, int, boolean, boolean) method. </para>        
				/// </summary>
				/// <returns>
				///  <para>the maximum capture rate expressed in milliHertz </para>
				/// </returns>
				/// <java-name>
				/// getMaxCaptureRate
				/// </java-name>
				public static int MaxCaptureRate
				{
						[Dot42.DexImport("getMaxCaptureRate", "()I", AccessFlags = 265)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns current capture size. </para>        
				/// </summary>
				/// <returns>
				///  <para>the capture size in bytes. </para>
				/// </returns>
				/// <java-name>
				/// getCaptureSize
				/// </java-name>
				public virtual int CaptureSize
				{
						[Dot42.DexImport("getCaptureSize", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns the current scaling mode on the captured visualization data. </para>        
				/// </summary>
				/// <returns>
				///  <para>the scaling mode, see SCALING_MODE_NORMALIZED and SCALING_MODE_AS_PLAYED. </para>
				/// </returns>
				/// <java-name>
				/// getScalingMode
				/// </java-name>
				public virtual int ScalingMode
				{
						[Dot42.DexImport("getScalingMode", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns the sampling rate of the captured audio. </para>        
				/// </summary>
				/// <returns>
				///  <para>the sampling rate in milliHertz. </para>
				/// </returns>
				/// <java-name>
				/// getSamplingRate
				/// </java-name>
				public virtual int SamplingRate
				{
						[Dot42.DexImport("getSamplingRate", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>The OnDataCaptureListener interface defines methods called by the Visualizer to periodically update the audio visualization capture. The client application can implement this interface and register the listener with the setDataCaptureListener(OnDataCaptureListener, int, boolean, boolean) method. </para>    
				/// </summary>
				/// <java-name>
				/// android/media/audiofx/Visualizer$OnDataCaptureListener
				/// </java-name>
				[Dot42.DexImport("android/media/audiofx/Visualizer$OnDataCaptureListener", AccessFlags = 1545)]
				public partial interface IOnDataCaptureListener
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>Method called when a new waveform capture is available. </para> <para>Data in the waveform buffer is valid only within the scope of the callback. Applications which needs access to the waveform data after returning from the callback should make a copy of the data instead of holding a reference. </para>        
						/// </summary>
						/// <java-name>
						/// onWaveFormDataCapture
						/// </java-name>
						[Dot42.DexImport("onWaveFormDataCapture", "(Landroid/media/audiofx/Visualizer;[BI)V", AccessFlags = 1025)]
						void OnWaveFormDataCapture(global::Android.Media.Audiofx.Visualizer visualizer, byte[] waveform, int samplingRate) /* MethodBuilder.Create */ ;

						/// <summary>
						///  <para>Method called when a new frequency capture is available. </para> <para>Data in the fft buffer is valid only within the scope of the callback. Applications which needs access to the fft data after returning from the callback should make a copy of the data instead of holding a reference. </para>        
						/// </summary>
						/// <java-name>
						/// onFftDataCapture
						/// </java-name>
						[Dot42.DexImport("onFftDataCapture", "(Landroid/media/audiofx/Visualizer;[BI)V", AccessFlags = 1025)]
						void OnFftDataCapture(global::Android.Media.Audiofx.Visualizer visualizer, byte[] fft, int samplingRate) /* MethodBuilder.Create */ ;

				}

		}

}

