#pragma warning disable 1717
namespace Android.Media
{
		/// <summary>
		///  <para>Plays a series of audio URIs, but does all the hard work on another thread so that any slowness with preparing or loading doesn't block the calling thread. </para>    
		/// </summary>
		/// <java-name>
		/// android/media/AsyncPlayer
		/// </java-name>
		[Dot42.DexImport("android/media/AsyncPlayer", AccessFlags = 33)]
		public partial class AsyncPlayer
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Construct an AsyncPlayer object.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public AsyncPlayer(string tag) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Start playing the sound. It will actually start playing at some point in the future. There are no guarantees about latency here. Calling this before another audio file is done playing will stop that one and start the new one.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// play
				/// </java-name>
				[Dot42.DexImport("play", "(Landroid/content/Context;Landroid/net/Uri;ZI)V", AccessFlags = 1)]
				public virtual void Play(global::Android.Content.Context context, global::Android.Net.Uri uri, bool looping, int stream) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Stop a previously played sound. It can't be played again or unpaused at this point. Calling this multiple times has no ill effects. </para>        
				/// </summary>
				/// <java-name>
				/// stop
				/// </java-name>
				[Dot42.DexImport("stop", "()V", AccessFlags = 1)]
				public virtual void Stop() /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal AsyncPlayer() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		///  <para>The AudioFormat class is used to access a number of audio format and channel configuration constants. They are for instance used in AudioTrack and AudioRecord. </para>    
		/// </summary>
		/// <java-name>
		/// android/media/AudioFormat
		/// </java-name>
		[Dot42.DexImport("android/media/AudioFormat", AccessFlags = 33)]
		public partial class AudioFormat
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Invalid audio data format </para>        
				/// </summary>
				/// <java-name>
				/// ENCODING_INVALID
				/// </java-name>
				[Dot42.DexImport("ENCODING_INVALID", "I", AccessFlags = 25)]
				public const int ENCODING_INVALID = 0;
				/// <summary>
				///  <para>Default audio data format </para>        
				/// </summary>
				/// <java-name>
				/// ENCODING_DEFAULT
				/// </java-name>
				[Dot42.DexImport("ENCODING_DEFAULT", "I", AccessFlags = 25)]
				public const int ENCODING_DEFAULT = 1;
				/// <summary>
				///  <para>Audio data format: PCM 16 bit per sample. Guaranteed to be supported by devices. </para>        
				/// </summary>
				/// <java-name>
				/// ENCODING_PCM_16BIT
				/// </java-name>
				[Dot42.DexImport("ENCODING_PCM_16BIT", "I", AccessFlags = 25)]
				public const int ENCODING_PCM_16BIT = 2;
				/// <summary>
				///  <para>Audio data format: PCM 8 bit per sample. Not guaranteed to be supported by devices. </para>        
				/// </summary>
				/// <java-name>
				/// ENCODING_PCM_8BIT
				/// </java-name>
				[Dot42.DexImport("ENCODING_PCM_8BIT", "I", AccessFlags = 25)]
				public const int ENCODING_PCM_8BIT = 3;
				/// <summary>
				///  <para>Invalid audio channel configuration  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>use CHANNEL_INVALID instead </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// CHANNEL_CONFIGURATION_INVALID
				/// </java-name>
				[Dot42.DexImport("CHANNEL_CONFIGURATION_INVALID", "I", AccessFlags = 25)]
				public const int CHANNEL_CONFIGURATION_INVALID = 0;
				/// <summary>
				///  <para>Default audio channel configuration  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>use CHANNEL_OUT_DEFAULT or CHANNEL_IN_DEFAULT instead </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// CHANNEL_CONFIGURATION_DEFAULT
				/// </java-name>
				[Dot42.DexImport("CHANNEL_CONFIGURATION_DEFAULT", "I", AccessFlags = 25)]
				public const int CHANNEL_CONFIGURATION_DEFAULT = 1;
				/// <summary>
				///  <para>Mono audio configuration  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>use CHANNEL_OUT_MONO or CHANNEL_IN_MONO instead </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// CHANNEL_CONFIGURATION_MONO
				/// </java-name>
				[Dot42.DexImport("CHANNEL_CONFIGURATION_MONO", "I", AccessFlags = 25)]
				public const int CHANNEL_CONFIGURATION_MONO = 2;
				/// <summary>
				///  <para>Stereo (2 channel) audio configuration  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>use CHANNEL_OUT_STEREO or CHANNEL_IN_STEREO instead </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// CHANNEL_CONFIGURATION_STEREO
				/// </java-name>
				[Dot42.DexImport("CHANNEL_CONFIGURATION_STEREO", "I", AccessFlags = 25)]
				public const int CHANNEL_CONFIGURATION_STEREO = 3;
				/// <summary>
				///  <para>Invalid audio channel mask </para>        
				/// </summary>
				/// <java-name>
				/// CHANNEL_INVALID
				/// </java-name>
				[Dot42.DexImport("CHANNEL_INVALID", "I", AccessFlags = 25)]
				public const int CHANNEL_INVALID = 0;
				/// <summary>
				///  <para>Default audio channel mask </para>        
				/// </summary>
				/// <java-name>
				/// CHANNEL_OUT_DEFAULT
				/// </java-name>
				[Dot42.DexImport("CHANNEL_OUT_DEFAULT", "I", AccessFlags = 25)]
				public const int CHANNEL_OUT_DEFAULT = 1;
				/// <java-name>
				/// CHANNEL_OUT_FRONT_LEFT
				/// </java-name>
				[Dot42.DexImport("CHANNEL_OUT_FRONT_LEFT", "I", AccessFlags = 25)]
				public const int CHANNEL_OUT_FRONT_LEFT = 4;
				/// <java-name>
				/// CHANNEL_OUT_FRONT_RIGHT
				/// </java-name>
				[Dot42.DexImport("CHANNEL_OUT_FRONT_RIGHT", "I", AccessFlags = 25)]
				public const int CHANNEL_OUT_FRONT_RIGHT = 8;
				/// <java-name>
				/// CHANNEL_OUT_FRONT_CENTER
				/// </java-name>
				[Dot42.DexImport("CHANNEL_OUT_FRONT_CENTER", "I", AccessFlags = 25)]
				public const int CHANNEL_OUT_FRONT_CENTER = 16;
				/// <java-name>
				/// CHANNEL_OUT_LOW_FREQUENCY
				/// </java-name>
				[Dot42.DexImport("CHANNEL_OUT_LOW_FREQUENCY", "I", AccessFlags = 25)]
				public const int CHANNEL_OUT_LOW_FREQUENCY = 32;
				/// <java-name>
				/// CHANNEL_OUT_BACK_LEFT
				/// </java-name>
				[Dot42.DexImport("CHANNEL_OUT_BACK_LEFT", "I", AccessFlags = 25)]
				public const int CHANNEL_OUT_BACK_LEFT = 64;
				/// <java-name>
				/// CHANNEL_OUT_BACK_RIGHT
				/// </java-name>
				[Dot42.DexImport("CHANNEL_OUT_BACK_RIGHT", "I", AccessFlags = 25)]
				public const int CHANNEL_OUT_BACK_RIGHT = 128;
				/// <java-name>
				/// CHANNEL_OUT_FRONT_LEFT_OF_CENTER
				/// </java-name>
				[Dot42.DexImport("CHANNEL_OUT_FRONT_LEFT_OF_CENTER", "I", AccessFlags = 25)]
				public const int CHANNEL_OUT_FRONT_LEFT_OF_CENTER = 256;
				/// <java-name>
				/// CHANNEL_OUT_FRONT_RIGHT_OF_CENTER
				/// </java-name>
				[Dot42.DexImport("CHANNEL_OUT_FRONT_RIGHT_OF_CENTER", "I", AccessFlags = 25)]
				public const int CHANNEL_OUT_FRONT_RIGHT_OF_CENTER = 512;
				/// <java-name>
				/// CHANNEL_OUT_BACK_CENTER
				/// </java-name>
				[Dot42.DexImport("CHANNEL_OUT_BACK_CENTER", "I", AccessFlags = 25)]
				public const int CHANNEL_OUT_BACK_CENTER = 1024;
				/// <java-name>
				/// CHANNEL_OUT_MONO
				/// </java-name>
				[Dot42.DexImport("CHANNEL_OUT_MONO", "I", AccessFlags = 25)]
				public const int CHANNEL_OUT_MONO = 4;
				/// <java-name>
				/// CHANNEL_OUT_STEREO
				/// </java-name>
				[Dot42.DexImport("CHANNEL_OUT_STEREO", "I", AccessFlags = 25)]
				public const int CHANNEL_OUT_STEREO = 12;
				/// <java-name>
				/// CHANNEL_OUT_QUAD
				/// </java-name>
				[Dot42.DexImport("CHANNEL_OUT_QUAD", "I", AccessFlags = 25)]
				public const int CHANNEL_OUT_QUAD = 204;
				/// <java-name>
				/// CHANNEL_OUT_SURROUND
				/// </java-name>
				[Dot42.DexImport("CHANNEL_OUT_SURROUND", "I", AccessFlags = 25)]
				public const int CHANNEL_OUT_SURROUND = 1052;
				/// <java-name>
				/// CHANNEL_OUT_5POINT1
				/// </java-name>
				[Dot42.DexImport("CHANNEL_OUT_5POINT1", "I", AccessFlags = 25)]
				public const int CHANNEL_OUT_5POINT1 = 252;
				/// <java-name>
				/// CHANNEL_OUT_7POINT1
				/// </java-name>
				[Dot42.DexImport("CHANNEL_OUT_7POINT1", "I", AccessFlags = 25)]
				public const int CHANNEL_OUT_7POINT1 = 1020;
				/// <java-name>
				/// CHANNEL_IN_DEFAULT
				/// </java-name>
				[Dot42.DexImport("CHANNEL_IN_DEFAULT", "I", AccessFlags = 25)]
				public const int CHANNEL_IN_DEFAULT = 1;
				/// <java-name>
				/// CHANNEL_IN_LEFT
				/// </java-name>
				[Dot42.DexImport("CHANNEL_IN_LEFT", "I", AccessFlags = 25)]
				public const int CHANNEL_IN_LEFT = 4;
				/// <java-name>
				/// CHANNEL_IN_RIGHT
				/// </java-name>
				[Dot42.DexImport("CHANNEL_IN_RIGHT", "I", AccessFlags = 25)]
				public const int CHANNEL_IN_RIGHT = 8;
				/// <java-name>
				/// CHANNEL_IN_FRONT
				/// </java-name>
				[Dot42.DexImport("CHANNEL_IN_FRONT", "I", AccessFlags = 25)]
				public const int CHANNEL_IN_FRONT = 16;
				/// <java-name>
				/// CHANNEL_IN_BACK
				/// </java-name>
				[Dot42.DexImport("CHANNEL_IN_BACK", "I", AccessFlags = 25)]
				public const int CHANNEL_IN_BACK = 32;
				/// <java-name>
				/// CHANNEL_IN_LEFT_PROCESSED
				/// </java-name>
				[Dot42.DexImport("CHANNEL_IN_LEFT_PROCESSED", "I", AccessFlags = 25)]
				public const int CHANNEL_IN_LEFT_PROCESSED = 64;
				/// <java-name>
				/// CHANNEL_IN_RIGHT_PROCESSED
				/// </java-name>
				[Dot42.DexImport("CHANNEL_IN_RIGHT_PROCESSED", "I", AccessFlags = 25)]
				public const int CHANNEL_IN_RIGHT_PROCESSED = 128;
				/// <java-name>
				/// CHANNEL_IN_FRONT_PROCESSED
				/// </java-name>
				[Dot42.DexImport("CHANNEL_IN_FRONT_PROCESSED", "I", AccessFlags = 25)]
				public const int CHANNEL_IN_FRONT_PROCESSED = 256;
				/// <java-name>
				/// CHANNEL_IN_BACK_PROCESSED
				/// </java-name>
				[Dot42.DexImport("CHANNEL_IN_BACK_PROCESSED", "I", AccessFlags = 25)]
				public const int CHANNEL_IN_BACK_PROCESSED = 512;
				/// <java-name>
				/// CHANNEL_IN_PRESSURE
				/// </java-name>
				[Dot42.DexImport("CHANNEL_IN_PRESSURE", "I", AccessFlags = 25)]
				public const int CHANNEL_IN_PRESSURE = 1024;
				/// <java-name>
				/// CHANNEL_IN_X_AXIS
				/// </java-name>
				[Dot42.DexImport("CHANNEL_IN_X_AXIS", "I", AccessFlags = 25)]
				public const int CHANNEL_IN_X_AXIS = 2048;
				/// <java-name>
				/// CHANNEL_IN_Y_AXIS
				/// </java-name>
				[Dot42.DexImport("CHANNEL_IN_Y_AXIS", "I", AccessFlags = 25)]
				public const int CHANNEL_IN_Y_AXIS = 4096;
				/// <java-name>
				/// CHANNEL_IN_Z_AXIS
				/// </java-name>
				[Dot42.DexImport("CHANNEL_IN_Z_AXIS", "I", AccessFlags = 25)]
				public const int CHANNEL_IN_Z_AXIS = 8192;
				/// <java-name>
				/// CHANNEL_IN_VOICE_UPLINK
				/// </java-name>
				[Dot42.DexImport("CHANNEL_IN_VOICE_UPLINK", "I", AccessFlags = 25)]
				public const int CHANNEL_IN_VOICE_UPLINK = 16384;
				/// <java-name>
				/// CHANNEL_IN_VOICE_DNLINK
				/// </java-name>
				[Dot42.DexImport("CHANNEL_IN_VOICE_DNLINK", "I", AccessFlags = 25)]
				public const int CHANNEL_IN_VOICE_DNLINK = 32768;
				/// <java-name>
				/// CHANNEL_IN_MONO
				/// </java-name>
				[Dot42.DexImport("CHANNEL_IN_MONO", "I", AccessFlags = 25)]
				public const int CHANNEL_IN_MONO = 16;
				/// <java-name>
				/// CHANNEL_IN_STEREO
				/// </java-name>
				[Dot42.DexImport("CHANNEL_IN_STEREO", "I", AccessFlags = 25)]
				public const int CHANNEL_IN_STEREO = 12;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public AudioFormat() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>AudioManager provides access to volume and ringer mode control. </para> <para>Use  <code>Context.getSystemService(Context.AUDIO_SERVICE)</code> to get an instance of this class. </para>    
		/// </summary>
		/// <java-name>
		/// android/media/AudioManager
		/// </java-name>
		[Dot42.DexImport("android/media/AudioManager", AccessFlags = 33)]
		public partial class AudioManager
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Broadcast intent, a hint for applications that audio is about to become 'noisy' due to a change in audio outputs. For example, this intent may be sent when a wired headset is unplugged, or when an A2DP audio sink is disconnected, and the audio system is about to automatically switch audio route to the speaker. Applications that are controlling audio streams may consider pausing, reducing volume or some other action on receipt of this intent so as not to surprise the user with audio from the speaker. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_AUDIO_BECOMING_NOISY
				/// </java-name>
				[Dot42.DexImport("ACTION_AUDIO_BECOMING_NOISY", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_AUDIO_BECOMING_NOISY = "android.media.AUDIO_BECOMING_NOISY";
				/// <summary>
				///  <para>Sticky broadcast intent action indicating that the ringer mode has changed. Includes the new ringer mode.</para> <para> <para>EXTRA_RINGER_MODE </para></para>        
				/// </summary>
				/// <java-name>
				/// RINGER_MODE_CHANGED_ACTION
				/// </java-name>
				[Dot42.DexImport("RINGER_MODE_CHANGED_ACTION", "Ljava/lang/String;", AccessFlags = 25)]
				public const string RINGER_MODE_CHANGED_ACTION = "android.media.RINGER_MODE_CHANGED";
				/// <summary>
				///  <para>The new ringer mode.</para> <para> <para>RINGER_MODE_CHANGED_ACTION </para> <para>RINGER_MODE_NORMAL </para> <para>RINGER_MODE_SILENT </para> <para>RINGER_MODE_VIBRATE </para></para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_RINGER_MODE
				/// </java-name>
				[Dot42.DexImport("EXTRA_RINGER_MODE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_RINGER_MODE = "android.media.EXTRA_RINGER_MODE";
				/// <summary>
				///  <para>Broadcast intent action indicating that the vibrate setting has changed. Includes the vibrate type and its new setting.</para> <para> <para>EXTRA_VIBRATE_TYPE </para> <para>EXTRA_VIBRATE_SETTING </para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Applications should maintain their own vibrate policy based on current ringer mode and listen to RINGER_MODE_CHANGED_ACTION instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// VIBRATE_SETTING_CHANGED_ACTION
				/// </java-name>
				[Dot42.DexImport("VIBRATE_SETTING_CHANGED_ACTION", "Ljava/lang/String;", AccessFlags = 25)]
				public const string VIBRATE_SETTING_CHANGED_ACTION = "android.media.VIBRATE_SETTING_CHANGED";
				/// <summary>
				///  <para>The new vibrate setting for a particular type.</para> <para> <para>VIBRATE_SETTING_CHANGED_ACTION </para> <para>EXTRA_VIBRATE_TYPE </para> <para>VIBRATE_SETTING_ON </para> <para>VIBRATE_SETTING_OFF </para> <para>VIBRATE_SETTING_ONLY_SILENT </para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Applications should maintain their own vibrate policy based on current ringer mode and listen to RINGER_MODE_CHANGED_ACTION instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_VIBRATE_SETTING
				/// </java-name>
				[Dot42.DexImport("EXTRA_VIBRATE_SETTING", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_VIBRATE_SETTING = "android.media.EXTRA_VIBRATE_SETTING";
				/// <summary>
				///  <para>The vibrate type whose setting has changed.</para> <para> <para>VIBRATE_SETTING_CHANGED_ACTION </para> <para>VIBRATE_TYPE_NOTIFICATION </para> <para>VIBRATE_TYPE_RINGER </para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Applications should maintain their own vibrate policy based on current ringer mode and listen to RINGER_MODE_CHANGED_ACTION instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_VIBRATE_TYPE
				/// </java-name>
				[Dot42.DexImport("EXTRA_VIBRATE_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_VIBRATE_TYPE = "android.media.EXTRA_VIBRATE_TYPE";
				/// <summary>
				///  <para>The audio stream for phone calls </para>        
				/// </summary>
				/// <java-name>
				/// STREAM_VOICE_CALL
				/// </java-name>
				[Dot42.DexImport("STREAM_VOICE_CALL", "I", AccessFlags = 25)]
				public const int STREAM_VOICE_CALL = 0;
				/// <summary>
				///  <para>The audio stream for system sounds </para>        
				/// </summary>
				/// <java-name>
				/// STREAM_SYSTEM
				/// </java-name>
				[Dot42.DexImport("STREAM_SYSTEM", "I", AccessFlags = 25)]
				public const int STREAM_SYSTEM = 1;
				/// <summary>
				///  <para>The audio stream for the phone ring </para>        
				/// </summary>
				/// <java-name>
				/// STREAM_RING
				/// </java-name>
				[Dot42.DexImport("STREAM_RING", "I", AccessFlags = 25)]
				public const int STREAM_RING = 2;
				/// <summary>
				///  <para>The audio stream for music playback </para>        
				/// </summary>
				/// <java-name>
				/// STREAM_MUSIC
				/// </java-name>
				[Dot42.DexImport("STREAM_MUSIC", "I", AccessFlags = 25)]
				public const int STREAM_MUSIC = 3;
				/// <summary>
				///  <para>The audio stream for alarms </para>        
				/// </summary>
				/// <java-name>
				/// STREAM_ALARM
				/// </java-name>
				[Dot42.DexImport("STREAM_ALARM", "I", AccessFlags = 25)]
				public const int STREAM_ALARM = 4;
				/// <summary>
				///  <para>The audio stream for notifications </para>        
				/// </summary>
				/// <java-name>
				/// STREAM_NOTIFICATION
				/// </java-name>
				[Dot42.DexImport("STREAM_NOTIFICATION", "I", AccessFlags = 25)]
				public const int STREAM_NOTIFICATION = 5;
				/// <summary>
				///  <para>The audio stream for DTMF Tones </para>        
				/// </summary>
				/// <java-name>
				/// STREAM_DTMF
				/// </java-name>
				[Dot42.DexImport("STREAM_DTMF", "I", AccessFlags = 25)]
				public const int STREAM_DTMF = 8;
				/// <summary>
				///  <para>Number of audio streams  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use AudioSystem.getNumStreamTypes() instead </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// NUM_STREAMS
				/// </java-name>
				[Dot42.DexImport("NUM_STREAMS", "I", AccessFlags = 25)]
				public const int NUM_STREAMS = 5;
				/// <summary>
				///  <para>Increase the ringer volume.</para> <para> <para>adjustVolume(int, int) </para> <para>adjustStreamVolume(int, int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// ADJUST_RAISE
				/// </java-name>
				[Dot42.DexImport("ADJUST_RAISE", "I", AccessFlags = 25)]
				public const int ADJUST_RAISE = 1;
				/// <summary>
				///  <para>Decrease the ringer volume.</para> <para> <para>adjustVolume(int, int) </para> <para>adjustStreamVolume(int, int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// ADJUST_LOWER
				/// </java-name>
				[Dot42.DexImport("ADJUST_LOWER", "I", AccessFlags = 25)]
				public const int ADJUST_LOWER = -1;
				/// <summary>
				///  <para>Maintain the previous ringer volume. This may be useful when needing to show the volume toast without actually modifying the volume.</para> <para> <para>adjustVolume(int, int) </para> <para>adjustStreamVolume(int, int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// ADJUST_SAME
				/// </java-name>
				[Dot42.DexImport("ADJUST_SAME", "I", AccessFlags = 25)]
				public const int ADJUST_SAME = 0;
				/// <summary>
				///  <para>Show a toast containing the current volume.</para> <para> <para>adjustStreamVolume(int, int, int) </para> <para>adjustVolume(int, int) </para> <para>setStreamVolume(int, int, int) </para> <para>setRingerMode(int) </para></para>        
				/// </summary>
				/// <java-name>
				/// FLAG_SHOW_UI
				/// </java-name>
				[Dot42.DexImport("FLAG_SHOW_UI", "I", AccessFlags = 25)]
				public const int FLAG_SHOW_UI = 1;
				/// <summary>
				///  <para>Whether to include ringer modes as possible options when changing volume. For example, if true and volume level is 0 and the volume is adjusted with ADJUST_LOWER, then the ringer mode may switch the silent or vibrate mode. </para> <para>By default this is on for the ring stream. If this flag is included, this behavior will be present regardless of the stream type being affected by the ringer mode.</para> <para> <para>adjustVolume(int, int) </para> <para>adjustStreamVolume(int, int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// FLAG_ALLOW_RINGER_MODES
				/// </java-name>
				[Dot42.DexImport("FLAG_ALLOW_RINGER_MODES", "I", AccessFlags = 25)]
				public const int FLAG_ALLOW_RINGER_MODES = 2;
				/// <summary>
				///  <para>Whether to play a sound when changing the volume. </para> <para>If this is given to adjustVolume(int, int) or adjustSuggestedStreamVolume(int, int, int), it may be ignored in some cases (for example, the decided stream type is not AudioManager#STREAM_RING, or the volume is being adjusted downward).</para> <para> <para>adjustStreamVolume(int, int, int) </para> <para>adjustVolume(int, int) </para> <para>setStreamVolume(int, int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// FLAG_PLAY_SOUND
				/// </java-name>
				[Dot42.DexImport("FLAG_PLAY_SOUND", "I", AccessFlags = 25)]
				public const int FLAG_PLAY_SOUND = 4;
				/// <summary>
				///  <para>Removes any sounds/vibrate that may be in the queue, or are playing (related to changing volume). </para>        
				/// </summary>
				/// <java-name>
				/// FLAG_REMOVE_SOUND_AND_VIBRATE
				/// </java-name>
				[Dot42.DexImport("FLAG_REMOVE_SOUND_AND_VIBRATE", "I", AccessFlags = 25)]
				public const int FLAG_REMOVE_SOUND_AND_VIBRATE = 8;
				/// <summary>
				///  <para>Whether to vibrate if going into the vibrate ringer mode. </para>        
				/// </summary>
				/// <java-name>
				/// FLAG_VIBRATE
				/// </java-name>
				[Dot42.DexImport("FLAG_VIBRATE", "I", AccessFlags = 25)]
				public const int FLAG_VIBRATE = 16;
				/// <summary>
				///  <para>Ringer mode that will be silent and will not vibrate. (This overrides the vibrate setting.)</para> <para> <para>setRingerMode(int) </para> <para>getRingerMode() </para></para>        
				/// </summary>
				/// <java-name>
				/// RINGER_MODE_SILENT
				/// </java-name>
				[Dot42.DexImport("RINGER_MODE_SILENT", "I", AccessFlags = 25)]
				public const int RINGER_MODE_SILENT = 0;
				/// <summary>
				///  <para>Ringer mode that will be silent and will vibrate. (This will cause the phone ringer to always vibrate, but the notification vibrate to only vibrate if set.)</para> <para> <para>setRingerMode(int) </para> <para>getRingerMode() </para></para>        
				/// </summary>
				/// <java-name>
				/// RINGER_MODE_VIBRATE
				/// </java-name>
				[Dot42.DexImport("RINGER_MODE_VIBRATE", "I", AccessFlags = 25)]
				public const int RINGER_MODE_VIBRATE = 1;
				/// <summary>
				///  <para>Ringer mode that may be audible and may vibrate. It will be audible if the volume before changing out of this mode was audible. It will vibrate if the vibrate setting is on.</para> <para> <para>setRingerMode(int) </para> <para>getRingerMode() </para></para>        
				/// </summary>
				/// <java-name>
				/// RINGER_MODE_NORMAL
				/// </java-name>
				[Dot42.DexImport("RINGER_MODE_NORMAL", "I", AccessFlags = 25)]
				public const int RINGER_MODE_NORMAL = 2;
				/// <summary>
				///  <para>Vibrate type that corresponds to the ringer.</para> <para> <para>setVibrateSetting(int, int) </para> <para>getVibrateSetting(int) </para> <para>shouldVibrate(int) </para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Applications should maintain their own vibrate policy based on current ringer mode that can be queried via getRingerMode(). </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// VIBRATE_TYPE_RINGER
				/// </java-name>
				[Dot42.DexImport("VIBRATE_TYPE_RINGER", "I", AccessFlags = 25)]
				public const int VIBRATE_TYPE_RINGER = 0;
				/// <summary>
				///  <para>Vibrate type that corresponds to notifications.</para> <para> <para>setVibrateSetting(int, int) </para> <para>getVibrateSetting(int) </para> <para>shouldVibrate(int) </para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Applications should maintain their own vibrate policy based on current ringer mode that can be queried via getRingerMode(). </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// VIBRATE_TYPE_NOTIFICATION
				/// </java-name>
				[Dot42.DexImport("VIBRATE_TYPE_NOTIFICATION", "I", AccessFlags = 25)]
				public const int VIBRATE_TYPE_NOTIFICATION = 1;
				/// <summary>
				///  <para>Vibrate setting that suggests to never vibrate.</para> <para> <para>setVibrateSetting(int, int) </para> <para>getVibrateSetting(int) </para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Applications should maintain their own vibrate policy based on current ringer mode that can be queried via getRingerMode(). </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// VIBRATE_SETTING_OFF
				/// </java-name>
				[Dot42.DexImport("VIBRATE_SETTING_OFF", "I", AccessFlags = 25)]
				public const int VIBRATE_SETTING_OFF = 0;
				/// <summary>
				///  <para>Vibrate setting that suggests to vibrate when possible.</para> <para> <para>setVibrateSetting(int, int) </para> <para>getVibrateSetting(int) </para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Applications should maintain their own vibrate policy based on current ringer mode that can be queried via getRingerMode(). </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// VIBRATE_SETTING_ON
				/// </java-name>
				[Dot42.DexImport("VIBRATE_SETTING_ON", "I", AccessFlags = 25)]
				public const int VIBRATE_SETTING_ON = 1;
				/// <summary>
				///  <para>Vibrate setting that suggests to only vibrate when in the vibrate ringer mode.</para> <para> <para>setVibrateSetting(int, int) </para> <para>getVibrateSetting(int) </para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Applications should maintain their own vibrate policy based on current ringer mode that can be queried via getRingerMode(). </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// VIBRATE_SETTING_ONLY_SILENT
				/// </java-name>
				[Dot42.DexImport("VIBRATE_SETTING_ONLY_SILENT", "I", AccessFlags = 25)]
				public const int VIBRATE_SETTING_ONLY_SILENT = 2;
				/// <summary>
				///  <para>Suggests using the default stream type. This may not be used in all places a stream type is needed. </para>        
				/// </summary>
				/// <java-name>
				/// USE_DEFAULT_STREAM_TYPE
				/// </java-name>
				[Dot42.DexImport("USE_DEFAULT_STREAM_TYPE", "I", AccessFlags = 25)]
				public const int USE_DEFAULT_STREAM_TYPE = -2147483648;
				/// <summary>
				///  <para>Sticky broadcast intent action indicating that the bluetoooth SCO audio connection state has changed. The intent contains on extra EXTRA_SCO_AUDIO_STATE indicating the new state which is either SCO_AUDIO_STATE_DISCONNECTED or SCO_AUDIO_STATE_CONNECTED</para> <para> <para>startBluetoothSco() </para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use ACTION_SCO_AUDIO_STATE_UPDATED instead </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// ACTION_SCO_AUDIO_STATE_CHANGED
				/// </java-name>
				[Dot42.DexImport("ACTION_SCO_AUDIO_STATE_CHANGED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_SCO_AUDIO_STATE_CHANGED = "android.media.SCO_AUDIO_STATE_CHANGED";
				/// <summary>
				///  <para>Extra for intent ACTION_SCO_AUDIO_STATE_CHANGED or ACTION_SCO_AUDIO_STATE_UPDATED containing the new bluetooth SCO connection state. </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_SCO_AUDIO_STATE
				/// </java-name>
				[Dot42.DexImport("EXTRA_SCO_AUDIO_STATE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_SCO_AUDIO_STATE = "android.media.extra.SCO_AUDIO_STATE";
				/// <summary>
				///  <para>Value for extra EXTRA_SCO_AUDIO_STATE or EXTRA_SCO_AUDIO_PREVIOUS_STATE indicating that the SCO audio channel is not established </para>        
				/// </summary>
				/// <java-name>
				/// SCO_AUDIO_STATE_DISCONNECTED
				/// </java-name>
				[Dot42.DexImport("SCO_AUDIO_STATE_DISCONNECTED", "I", AccessFlags = 25)]
				public const int SCO_AUDIO_STATE_DISCONNECTED = 0;
				/// <summary>
				///  <para>Value for extra EXTRA_SCO_AUDIO_STATE or EXTRA_SCO_AUDIO_PREVIOUS_STATE indicating that the SCO audio channel is established </para>        
				/// </summary>
				/// <java-name>
				/// SCO_AUDIO_STATE_CONNECTED
				/// </java-name>
				[Dot42.DexImport("SCO_AUDIO_STATE_CONNECTED", "I", AccessFlags = 25)]
				public const int SCO_AUDIO_STATE_CONNECTED = 1;
				/// <summary>
				///  <para>Value for extra EXTRA_SCO_AUDIO_STATE indicating that there was an error trying to obtain the state </para>        
				/// </summary>
				/// <java-name>
				/// SCO_AUDIO_STATE_ERROR
				/// </java-name>
				[Dot42.DexImport("SCO_AUDIO_STATE_ERROR", "I", AccessFlags = 25)]
				public const int SCO_AUDIO_STATE_ERROR = -1;
				/// <summary>
				///  <para>Audio harware modes. Invalid audio mode. </para>        
				/// </summary>
				/// <java-name>
				/// MODE_INVALID
				/// </java-name>
				[Dot42.DexImport("MODE_INVALID", "I", AccessFlags = 25)]
				public const int MODE_INVALID = -2;
				/// <summary>
				///  <para>Current audio mode. Used to apply audio routing to current mode. </para>        
				/// </summary>
				/// <java-name>
				/// MODE_CURRENT
				/// </java-name>
				[Dot42.DexImport("MODE_CURRENT", "I", AccessFlags = 25)]
				public const int MODE_CURRENT = -1;
				/// <summary>
				///  <para>Normal audio mode: not ringing and no call established. </para>        
				/// </summary>
				/// <java-name>
				/// MODE_NORMAL
				/// </java-name>
				[Dot42.DexImport("MODE_NORMAL", "I", AccessFlags = 25)]
				public const int MODE_NORMAL = 0;
				/// <summary>
				///  <para>Ringing audio mode. An incoming is being signaled. </para>        
				/// </summary>
				/// <java-name>
				/// MODE_RINGTONE
				/// </java-name>
				[Dot42.DexImport("MODE_RINGTONE", "I", AccessFlags = 25)]
				public const int MODE_RINGTONE = 1;
				/// <summary>
				///  <para>In call audio mode. A telephony call is established. </para>        
				/// </summary>
				/// <java-name>
				/// MODE_IN_CALL
				/// </java-name>
				[Dot42.DexImport("MODE_IN_CALL", "I", AccessFlags = 25)]
				public const int MODE_IN_CALL = 2;
				/// <summary>
				///  <para>Routing audio output to earpiece  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Do not set audio routing directly, use setSpeakerphoneOn(), setBluetoothScoOn() methods instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// ROUTE_EARPIECE
				/// </java-name>
				[Dot42.DexImport("ROUTE_EARPIECE", "I", AccessFlags = 25)]
				public const int ROUTE_EARPIECE = 1;
				/// <summary>
				///  <para>Routing audio output to speaker  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Do not set audio routing directly, use setSpeakerphoneOn(), setBluetoothScoOn() methods instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// ROUTE_SPEAKER
				/// </java-name>
				[Dot42.DexImport("ROUTE_SPEAKER", "I", AccessFlags = 25)]
				public const int ROUTE_SPEAKER = 2;
				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>use ROUTE_BLUETOOTH_SCO </para> <para>Do not set audio routing directly, use setSpeakerphoneOn(), setBluetoothScoOn() methods instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// ROUTE_BLUETOOTH
				/// </java-name>
				[Dot42.DexImport("ROUTE_BLUETOOTH", "I", AccessFlags = 25)]
				public const int ROUTE_BLUETOOTH = 4;
				/// <summary>
				///  <para>Routing audio output to bluetooth SCO  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Do not set audio routing directly, use setSpeakerphoneOn(), setBluetoothScoOn() methods instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// ROUTE_BLUETOOTH_SCO
				/// </java-name>
				[Dot42.DexImport("ROUTE_BLUETOOTH_SCO", "I", AccessFlags = 25)]
				public const int ROUTE_BLUETOOTH_SCO = 4;
				/// <summary>
				///  <para>Routing audio output to headset  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Do not set audio routing directly, use setSpeakerphoneOn(), setBluetoothScoOn() methods instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// ROUTE_HEADSET
				/// </java-name>
				[Dot42.DexImport("ROUTE_HEADSET", "I", AccessFlags = 25)]
				public const int ROUTE_HEADSET = 8;
				/// <summary>
				///  <para>Routing audio output to bluetooth A2DP  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Do not set audio routing directly, use setSpeakerphoneOn(), setBluetoothScoOn() methods instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// ROUTE_BLUETOOTH_A2DP
				/// </java-name>
				[Dot42.DexImport("ROUTE_BLUETOOTH_A2DP", "I", AccessFlags = 25)]
				public const int ROUTE_BLUETOOTH_A2DP = 16;
				/// <summary>
				///  <para>Used for mask parameter of setRouting(int,int,int).  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Do not set audio routing directly, use setSpeakerphoneOn(), setBluetoothScoOn() methods instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// ROUTE_ALL
				/// </java-name>
				[Dot42.DexImport("ROUTE_ALL", "I", AccessFlags = 25)]
				public const int ROUTE_ALL = -1;
				/// <summary>
				///  <para>Keyboard and direction pad click sound  <para>playSoundEffect(int) </para></para>        
				/// </summary>
				/// <java-name>
				/// FX_KEY_CLICK
				/// </java-name>
				[Dot42.DexImport("FX_KEY_CLICK", "I", AccessFlags = 25)]
				public const int FX_KEY_CLICK = 0;
				/// <summary>
				///  <para>Focus has moved up  <para>playSoundEffect(int) </para></para>        
				/// </summary>
				/// <java-name>
				/// FX_FOCUS_NAVIGATION_UP
				/// </java-name>
				[Dot42.DexImport("FX_FOCUS_NAVIGATION_UP", "I", AccessFlags = 25)]
				public const int FX_FOCUS_NAVIGATION_UP = 1;
				/// <summary>
				///  <para>Focus has moved down  <para>playSoundEffect(int) </para></para>        
				/// </summary>
				/// <java-name>
				/// FX_FOCUS_NAVIGATION_DOWN
				/// </java-name>
				[Dot42.DexImport("FX_FOCUS_NAVIGATION_DOWN", "I", AccessFlags = 25)]
				public const int FX_FOCUS_NAVIGATION_DOWN = 2;
				/// <summary>
				///  <para>Focus has moved left  <para>playSoundEffect(int) </para></para>        
				/// </summary>
				/// <java-name>
				/// FX_FOCUS_NAVIGATION_LEFT
				/// </java-name>
				[Dot42.DexImport("FX_FOCUS_NAVIGATION_LEFT", "I", AccessFlags = 25)]
				public const int FX_FOCUS_NAVIGATION_LEFT = 3;
				/// <summary>
				///  <para>Focus has moved right  <para>playSoundEffect(int) </para></para>        
				/// </summary>
				/// <java-name>
				/// FX_FOCUS_NAVIGATION_RIGHT
				/// </java-name>
				[Dot42.DexImport("FX_FOCUS_NAVIGATION_RIGHT", "I", AccessFlags = 25)]
				public const int FX_FOCUS_NAVIGATION_RIGHT = 4;
				/// <summary>
				///  <para>IME standard keypress sound  <para>playSoundEffect(int) </para></para>        
				/// </summary>
				/// <java-name>
				/// FX_KEYPRESS_STANDARD
				/// </java-name>
				[Dot42.DexImport("FX_KEYPRESS_STANDARD", "I", AccessFlags = 25)]
				public const int FX_KEYPRESS_STANDARD = 5;
				/// <summary>
				///  <para>IME spacebar keypress sound  <para>playSoundEffect(int) </para></para>        
				/// </summary>
				/// <java-name>
				/// FX_KEYPRESS_SPACEBAR
				/// </java-name>
				[Dot42.DexImport("FX_KEYPRESS_SPACEBAR", "I", AccessFlags = 25)]
				public const int FX_KEYPRESS_SPACEBAR = 6;
				/// <summary>
				///  <para>IME delete keypress sound  <para>playSoundEffect(int) </para></para>        
				/// </summary>
				/// <java-name>
				/// FX_KEYPRESS_DELETE
				/// </java-name>
				[Dot42.DexImport("FX_KEYPRESS_DELETE", "I", AccessFlags = 25)]
				public const int FX_KEYPRESS_DELETE = 7;
				/// <summary>
				///  <para>IME return_keypress sound  <para>playSoundEffect(int) </para></para>        
				/// </summary>
				/// <java-name>
				/// FX_KEYPRESS_RETURN
				/// </java-name>
				[Dot42.DexImport("FX_KEYPRESS_RETURN", "I", AccessFlags = 25)]
				public const int FX_KEYPRESS_RETURN = 8;
				/// <summary>
				///  <para>Used to indicate a gain of audio focus, or a request of audio focus, of unknown duration.  <para>OnAudioFocusChangeListener::onAudioFocusChange(int) </para> <para>requestAudioFocus(OnAudioFocusChangeListener, int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// AUDIOFOCUS_GAIN
				/// </java-name>
				[Dot42.DexImport("AUDIOFOCUS_GAIN", "I", AccessFlags = 25)]
				public const int AUDIOFOCUS_GAIN = 1;
				/// <summary>
				///  <para>Used to indicate a temporary gain or request of audio focus, anticipated to last a short amount of time. Examples of temporary changes are the playback of driving directions, or an event notification.  <para>OnAudioFocusChangeListener::onAudioFocusChange(int) </para> <para>requestAudioFocus(OnAudioFocusChangeListener, int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// AUDIOFOCUS_GAIN_TRANSIENT
				/// </java-name>
				[Dot42.DexImport("AUDIOFOCUS_GAIN_TRANSIENT", "I", AccessFlags = 25)]
				public const int AUDIOFOCUS_GAIN_TRANSIENT = 2;
				/// <summary>
				///  <para>Used to indicate a temporary request of audio focus, anticipated to last a short amount of time, and where it is acceptable for other audio applications to keep playing after having lowered their output level (also referred to as "ducking"). Examples of temporary changes are the playback of driving directions where playback of music in the background is acceptable.  <para>OnAudioFocusChangeListener::onAudioFocusChange(int) </para> <para>requestAudioFocus(OnAudioFocusChangeListener, int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// AUDIOFOCUS_GAIN_TRANSIENT_MAY_DUCK
				/// </java-name>
				[Dot42.DexImport("AUDIOFOCUS_GAIN_TRANSIENT_MAY_DUCK", "I", AccessFlags = 25)]
				public const int AUDIOFOCUS_GAIN_TRANSIENT_MAY_DUCK = 3;
				/// <summary>
				///  <para>Used to indicate a loss of audio focus of unknown duration.  <para>OnAudioFocusChangeListener::onAudioFocusChange(int) </para></para>        
				/// </summary>
				/// <java-name>
				/// AUDIOFOCUS_LOSS
				/// </java-name>
				[Dot42.DexImport("AUDIOFOCUS_LOSS", "I", AccessFlags = 25)]
				public const int AUDIOFOCUS_LOSS = -1;
				/// <summary>
				///  <para>Used to indicate a transient loss of audio focus.  <para>OnAudioFocusChangeListener::onAudioFocusChange(int) </para></para>        
				/// </summary>
				/// <java-name>
				/// AUDIOFOCUS_LOSS_TRANSIENT
				/// </java-name>
				[Dot42.DexImport("AUDIOFOCUS_LOSS_TRANSIENT", "I", AccessFlags = 25)]
				public const int AUDIOFOCUS_LOSS_TRANSIENT = -2;
				/// <summary>
				///  <para>Used to indicate a transient loss of audio focus where the loser of the audio focus can lower its output volume if it wants to continue playing (also referred to as "ducking"), as the new focus owner doesn't require others to be silent.  <para>OnAudioFocusChangeListener::onAudioFocusChange(int) </para></para>        
				/// </summary>
				/// <java-name>
				/// AUDIOFOCUS_LOSS_TRANSIENT_CAN_DUCK
				/// </java-name>
				[Dot42.DexImport("AUDIOFOCUS_LOSS_TRANSIENT_CAN_DUCK", "I", AccessFlags = 25)]
				public const int AUDIOFOCUS_LOSS_TRANSIENT_CAN_DUCK = -3;
				/// <summary>
				///  <para>A failed focus change request. </para>        
				/// </summary>
				/// <java-name>
				/// AUDIOFOCUS_REQUEST_FAILED
				/// </java-name>
				[Dot42.DexImport("AUDIOFOCUS_REQUEST_FAILED", "I", AccessFlags = 25)]
				public const int AUDIOFOCUS_REQUEST_FAILED = 0;
				/// <summary>
				///  <para>A successful focus change request. </para>        
				/// </summary>
				/// <java-name>
				/// AUDIOFOCUS_REQUEST_GRANTED
				/// </java-name>
				[Dot42.DexImport("AUDIOFOCUS_REQUEST_GRANTED", "I", AccessFlags = 25)]
				public const int AUDIOFOCUS_REQUEST_GRANTED = 1;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal AudioManager() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Adjusts the volume of a particular stream by one step in a direction. </para> <para>This method should only be used by applications that replace the platform-wide management of audio settings or the main telephony application.</para> <para> <para>adjustVolume(int, int) </para> <para>setStreamVolume(int, int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// adjustStreamVolume
				/// </java-name>
				[Dot42.DexImport("adjustStreamVolume", "(III)V", AccessFlags = 1)]
				public virtual void AdjustStreamVolume(int streamType, int direction, int flags) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Adjusts the volume of the most relevant stream. For example, if a call is active, it will have the highest priority regardless of if the in-call screen is showing. Another example, if music is playing in the background and a call is not active, the music stream will be adjusted. </para> <para>This method should only be used by applications that replace the platform-wide management of audio settings or the main telephony application.</para> <para> <para>adjustSuggestedStreamVolume(int, int, int) </para> <para>adjustStreamVolume(int, int, int) </para> <para>setStreamVolume(int, int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// adjustVolume
				/// </java-name>
				[Dot42.DexImport("adjustVolume", "(II)V", AccessFlags = 1)]
				public virtual void AdjustVolume(int direction, int flags) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Adjusts the volume of the most relevant stream, or the given fallback stream. </para> <para>This method should only be used by applications that replace the platform-wide management of audio settings or the main telephony application.</para> <para> <para>adjustVolume(int, int) </para> <para>adjustStreamVolume(int, int, int) </para> <para>setStreamVolume(int, int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// adjustSuggestedStreamVolume
				/// </java-name>
				[Dot42.DexImport("adjustSuggestedStreamVolume", "(III)V", AccessFlags = 1)]
				public virtual void AdjustSuggestedStreamVolume(int direction, int suggestedStreamType, int flags) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns the maximum volume index for a particular stream.</para> <para> <para>getStreamVolume(int) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>The maximum valid volume index for the stream. </para>
				/// </returns>
				/// <java-name>
				/// getStreamMaxVolume
				/// </java-name>
				[Dot42.DexImport("getStreamMaxVolume", "(I)I", AccessFlags = 1)]
				public virtual int GetStreamMaxVolume(int streamType) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Returns the current volume index for a particular stream.</para> <para> <para>getStreamMaxVolume(int) </para> <para>setStreamVolume(int, int, int) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>The current volume index for the stream. </para>
				/// </returns>
				/// <java-name>
				/// getStreamVolume
				/// </java-name>
				[Dot42.DexImport("getStreamVolume", "(I)I", AccessFlags = 1)]
				public virtual int GetStreamVolume(int streamType) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Sets the volume index for a particular stream.</para> <para> <para>getStreamMaxVolume(int) </para> <para>getStreamVolume(int) </para></para>        
				/// </summary>
				/// <java-name>
				/// setStreamVolume
				/// </java-name>
				[Dot42.DexImport("setStreamVolume", "(III)V", AccessFlags = 1)]
				public virtual void SetStreamVolume(int streamType, int index, int flags) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Solo or unsolo a particular stream. All other streams are muted. </para> <para>The solo command is protected against client process death: if a process with an active solo request on a stream dies, all streams that were muted because of this request will be unmuted automatically. </para> <para>The solo requests for a given stream are cumulative: the AudioManager can receive several solo requests from one or more clients and the stream will be unsoloed only when the same number of unsolo requests are received. </para> <para>For a better user experience, applications MUST unsolo a soloed stream in onPause() and solo is again in onResume() if appropriate.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setStreamSolo
				/// </java-name>
				[Dot42.DexImport("setStreamSolo", "(IZ)V", AccessFlags = 1)]
				public virtual void SetStreamSolo(int streamType, bool state) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Mute or unmute an audio stream. </para> <para>The mute command is protected against client process death: if a process with an active mute request on a stream dies, this stream will be unmuted automatically. </para> <para>The mute requests for a given stream are cumulative: the AudioManager can receive several mute requests from one or more clients and the stream will be unmuted only when the same number of unmute requests are received. </para> <para>For a better user experience, applications MUST unmute a muted stream in onPause() and mute is again in onResume() if appropriate. </para> <para>This method should only be used by applications that replace the platform-wide management of audio settings or the main telephony application.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setStreamMute
				/// </java-name>
				[Dot42.DexImport("setStreamMute", "(IZ)V", AccessFlags = 1)]
				public virtual void SetStreamMute(int streamType, bool state) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns whether a particular type should vibrate according to user settings and the current ringer mode. </para> <para>This shouldn't be needed by most clients that use notifications to vibrate. The notification manager will not vibrate if the policy doesn't allow it, so the client should always set a vibrate pattern and let the notification manager control whether or not to actually vibrate.</para> <para> <para>setVibrateSetting(int, int) </para> <para>getVibrateSetting(int) </para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Applications should maintain their own vibrate policy based on current ringer mode that can be queried via getRingerMode(). </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				///  <para>Whether the type should vibrate at the instant this method is called. </para>
				/// </returns>
				/// <java-name>
				/// shouldVibrate
				/// </java-name>
				[Dot42.DexImport("shouldVibrate", "(I)Z", AccessFlags = 1)]
				public virtual bool ShouldVibrate(int vibrateType) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Returns whether the user's vibrate setting for a vibrate type. </para> <para>This shouldn't be needed by most clients that want to vibrate, instead see shouldVibrate(int).</para> <para> <para>setVibrateSetting(int, int) </para> <para>shouldVibrate(int) </para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Applications should maintain their own vibrate policy based on current ringer mode that can be queried via getRingerMode(). </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				///  <para>The vibrate setting, one of VIBRATE_SETTING_ON, VIBRATE_SETTING_OFF, or VIBRATE_SETTING_ONLY_SILENT. </para>
				/// </returns>
				/// <java-name>
				/// getVibrateSetting
				/// </java-name>
				[Dot42.DexImport("getVibrateSetting", "(I)I", AccessFlags = 1)]
				public virtual int GetVibrateSetting(int vibrateType) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Sets the setting for when the vibrate type should vibrate. </para> <para>This method should only be used by applications that replace the platform-wide management of audio settings or the main telephony application.</para> <para> <para>getVibrateSetting(int) </para> <para>shouldVibrate(int) </para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Applications should maintain their own vibrate policy based on current ringer mode that can be queried via getRingerMode(). </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// setVibrateSetting
				/// </java-name>
				[Dot42.DexImport("setVibrateSetting", "(II)V", AccessFlags = 1)]
				public virtual void SetVibrateSetting(int vibrateType, int vibrateSetting) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Start bluetooth SCO audio connection. </para> <para>Requires Permission: android.Manifest.permission#MODIFY_AUDIO_SETTINGS. </para> <para>This method can be used by applications wanting to send and received audio to/from a bluetooth SCO headset while the phone is not in call. </para> <para>As the SCO connection establishment can take several seconds, applications should not rely on the connection to be available when the method returns but instead register to receive the intent ACTION_SCO_AUDIO_STATE_UPDATED and wait for the state to be SCO_AUDIO_STATE_CONNECTED. </para> <para>As the ACTION_SCO_AUDIO_STATE_UPDATED intent is sticky, the application can check the SCO audio state before calling startBluetoothSco() by reading the intent returned by the receiver registration. If the state is already CONNECTED, no state change will be received via the intent after calling startBluetoothSco(). It is however useful to call startBluetoothSco() so that the connection stays active in case the current initiator stops the connection. </para> <para>Unless the connection is already active as described above, the state will always transition from DISCONNECTED to CONNECTING and then either to CONNECTED if the connection succeeds or back to DISCONNECTED if the connection fails (e.g no headset is connected). </para> <para>When finished with the SCO connection or if the establishment fails, the application must call stopBluetoothSco() to clear the request and turn down the bluetooth connection. </para> <para>Even if a SCO connection is established, the following restrictions apply on audio output streams so that they can be routed to SCO headset: </para> <para>NOTE: up to and including API version android.os.Build.VERSION_CODES#JELLY_BEAN_MR1, this method initiates a virtual voice call to the bluetooth headset. After API version android.os.Build.VERSION_CODES#JELLY_BEAN_MR2 only a raw SCO audio connection is established.  <ul> <li> <para>the stream type must be STREAM_VOICE_CALL  </para></li> <li> <para>the format must be mono  </para></li> <li> <para>the sampling must be 16kHz or 8kHz  </para></li></ul></para> <para>The following restrictions apply on input streams:  <ul> <li> <para>the format must be mono  </para></li> <li> <para>the sampling must be 8kHz  </para></li></ul></para> <para>Note that the phone application always has the priority on the usage of the SCO connection for telephony. If this method is called while the phone is in call it will be ignored. Similarly, if a call is received or sent while an application is using the SCO connection, the connection will be lost for the application and NOT returned automatically when the call ends.  <para>stopBluetoothSco() </para> <para>ACTION_SCO_AUDIO_STATE_UPDATED </para></para>        
				/// </summary>
				/// <java-name>
				/// startBluetoothSco
				/// </java-name>
				[Dot42.DexImport("startBluetoothSco", "()V", AccessFlags = 1)]
				public virtual void StartBluetoothSco() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Stop bluetooth SCO audio connection. </para> <para>Requires Permission: android.Manifest.permission#MODIFY_AUDIO_SETTINGS. </para> <para>This method must be called by applications having requested the use of bluetooth SCO audio with startBluetoothSco() when finished with the SCO connection or if connection fails.  <para>startBluetoothSco() </para></para>        
				/// </summary>
				/// <java-name>
				/// stopBluetoothSco
				/// </java-name>
				[Dot42.DexImport("stopBluetoothSco", "()V", AccessFlags = 1)]
				public virtual void StopBluetoothSco() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the audio routing for a specified mode</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Do not set audio routing directly, use setSpeakerphoneOn(), setBluetoothScoOn() methods instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// setRouting
				/// </java-name>
				[Dot42.DexImport("setRouting", "(III)V", AccessFlags = 1)]
				public virtual void SetRouting(int mode, int routes, int mask) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns the current audio routing bit vector for a specified mode.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Do not query audio routing directly, use isSpeakerphoneOn(), isBluetoothScoOn(), isBluetoothA2dpOn() and isWiredHeadsetOn() methods instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				///  <para>an audio route bit vector that can be compared with ROUTE_xxx bits </para>
				/// </returns>
				/// <java-name>
				/// getRouting
				/// </java-name>
				[Dot42.DexImport("getRouting", "(I)I", AccessFlags = 1)]
				public virtual int GetRouting(int mode) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Sets a variable number of parameter values to audio hardware.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setParameters
				/// </java-name>
				[Dot42.DexImport("setParameters", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetParameters(string keyValuePairs) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Gets a variable number of parameter values from audio hardware.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>list of parameters key value pairs in the form: key1=value1;key2=value2;... </para>
				/// </returns>
				/// <java-name>
				/// getParameters
				/// </java-name>
				[Dot42.DexImport("getParameters", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetParameters(string keys) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Plays a sound effect (Key clicks, lid open/close...) </para>        
				/// </summary>
				/// <java-name>
				/// playSoundEffect
				/// </java-name>
				[Dot42.DexImport("playSoundEffect", "(I)V", AccessFlags = 1)]
				public virtual void PlaySoundEffect(int effectType) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Plays a sound effect (Key clicks, lid open/close...) </para>        
				/// </summary>
				/// <java-name>
				/// playSoundEffect
				/// </java-name>
				[Dot42.DexImport("playSoundEffect", "(IF)V", AccessFlags = 1)]
				public virtual void PlaySoundEffect(int effectType, float volume) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Load Sound effects. This method must be called when sound effects are enabled. </para>        
				/// </summary>
				/// <java-name>
				/// loadSoundEffects
				/// </java-name>
				[Dot42.DexImport("loadSoundEffects", "()V", AccessFlags = 1)]
				public virtual void LoadSoundEffects() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Unload Sound effects. This method can be called to free some memory when sound effects are disabled. </para>        
				/// </summary>
				/// <java-name>
				/// unloadSoundEffects
				/// </java-name>
				[Dot42.DexImport("unloadSoundEffects", "()V", AccessFlags = 1)]
				public virtual void UnloadSoundEffects() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Request audio focus. Send a request to obtain the audio focus </para>        
				/// </summary>
				/// <returns>
				///  <para>AUDIOFOCUS_REQUEST_FAILED or AUDIOFOCUS_REQUEST_GRANTED </para>
				/// </returns>
				/// <java-name>
				/// requestAudioFocus
				/// </java-name>
				[Dot42.DexImport("requestAudioFocus", "(Landroid/media/AudioManager$OnAudioFocusChangeListener;II)I", AccessFlags = 1)]
				public virtual int RequestAudioFocus(global::Android.Media.AudioManager.IOnAudioFocusChangeListener l, int streamType, int durationHint) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Abandon audio focus. Causes the previous focus owner, if any, to receive focus. </para>        
				/// </summary>
				/// <returns>
				///  <para>AUDIOFOCUS_REQUEST_FAILED or AUDIOFOCUS_REQUEST_GRANTED </para>
				/// </returns>
				/// <java-name>
				/// abandonAudioFocus
				/// </java-name>
				[Dot42.DexImport("abandonAudioFocus", "(Landroid/media/AudioManager$OnAudioFocusChangeListener;)I", AccessFlags = 1)]
				public virtual int AbandonAudioFocus(global::Android.Media.AudioManager.IOnAudioFocusChangeListener l) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Register a component to be the sole receiver of MEDIA_BUTTON intents. </para>        
				/// </summary>
				/// <java-name>
				/// registerMediaButtonEventReceiver
				/// </java-name>
				[Dot42.DexImport("registerMediaButtonEventReceiver", "(Landroid/content/ComponentName;)V", AccessFlags = 1)]
				public virtual void RegisterMediaButtonEventReceiver(global::Android.Content.ComponentName eventReceiver) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Unregister the receiver of MEDIA_BUTTON intents. </para>        
				/// </summary>
				/// <java-name>
				/// unregisterMediaButtonEventReceiver
				/// </java-name>
				[Dot42.DexImport("unregisterMediaButtonEventReceiver", "(Landroid/content/ComponentName;)V", AccessFlags = 1)]
				public virtual void UnregisterMediaButtonEventReceiver(global::Android.Content.ComponentName eventReceiver) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns the current ringtone mode.</para> <para> <para>setRingerMode(int) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>The current ringtone mode, one of RINGER_MODE_NORMAL, RINGER_MODE_SILENT, or RINGER_MODE_VIBRATE. </para>
				/// </returns>
				/// <java-name>
				/// getRingerMode
				/// </java-name>
				public virtual int RingerMode
				{
						[Dot42.DexImport("getRingerMode", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setRingerMode", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Checks whether the speakerphone is on or off.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if speakerphone is on, false if it's off </para>
				/// </returns>
				/// <java-name>
				/// isSpeakerphoneOn
				/// </java-name>
				public virtual bool IsSpeakerphoneOn
				{
						[Dot42.DexImport("isSpeakerphoneOn", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setSpeakerphoneOn", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Indicates if current platform supports use of SCO for off call use cases. Application wanted to use bluetooth SCO audio when the phone is not in call must first call this method to make sure that the platform supports this feature.  <para>startBluetoothSco() </para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if bluetooth SCO can be used for audio when not in call false otherwise </para>
				/// </returns>
				/// <java-name>
				/// isBluetoothScoAvailableOffCall
				/// </java-name>
				public virtual bool IsBluetoothScoAvailableOffCall
				{
						[Dot42.DexImport("isBluetoothScoAvailableOffCall", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Checks whether communications use Bluetooth SCO.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if SCO is used for communications; false if otherwise </para>
				/// </returns>
				/// <java-name>
				/// isBluetoothScoOn
				/// </java-name>
				public virtual bool IsBluetoothScoOn
				{
						[Dot42.DexImport("isBluetoothScoOn", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setBluetoothScoOn", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Checks whether A2DP audio routing to the Bluetooth headset is on or off.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if A2DP audio is being routed to/from Bluetooth headset; false if otherwise </para>
				/// </returns>
				/// <java-name>
				/// isBluetoothA2dpOn
				/// </java-name>
				public virtual bool IsBluetoothA2dpOn
				{
						[Dot42.DexImport("isBluetoothA2dpOn", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setBluetoothA2dpOn", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Checks whether a wired headset is connected or not. </para> <para>This is not a valid indication that audio playback is actually over the wired headset as audio routing depends on other conditions.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use only to check is a headset is connected or not. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				///  <para>true if a wired headset is connected. false if otherwise </para>
				/// </returns>
				/// <java-name>
				/// isWiredHeadsetOn
				/// </java-name>
				public virtual bool IsWiredHeadsetOn
				{
						[Dot42.DexImport("isWiredHeadsetOn", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setWiredHeadsetOn", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Checks whether the microphone mute is on or off.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if microphone is muted, false if it's not </para>
				/// </returns>
				/// <java-name>
				/// isMicrophoneMute
				/// </java-name>
				public virtual bool IsMicrophoneMute
				{
						[Dot42.DexImport("isMicrophoneMute", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setMicrophoneMute", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Returns the current audio mode.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the current audio mode (MODE_NORMAL, MODE_RINGTONE, MODE_IN_CALL or MODE_IN_COMMUNICATION). Returns the current current audio state from the HAL. </para>
				/// </returns>
				/// <java-name>
				/// getMode
				/// </java-name>
				public virtual int Mode
				{
						[Dot42.DexImport("getMode", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setMode", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Checks whether any music is active.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if any music tracks are active. </para>
				/// </returns>
				/// <java-name>
				/// isMusicActive
				/// </java-name>
				public virtual bool IsMusicActive
				{
						[Dot42.DexImport("isMusicActive", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Interface definition for a callback to be invoked when the audio focus of the system is updated. </para>    
				/// </summary>
				/// <java-name>
				/// android/media/AudioManager$OnAudioFocusChangeListener
				/// </java-name>
				[Dot42.DexImport("android/media/AudioManager$OnAudioFocusChangeListener", AccessFlags = 1545)]
				public partial interface IOnAudioFocusChangeListener
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>Called on the listener to notify it the audio focus for this listener has been changed. The focusChange value indicates whether the focus was gained, whether the focus was lost, and whether that loss is transient, or whether the new focus holder will hold it for an unknown amount of time. When losing focus, listeners can use the focus change information to decide what behavior to adopt when losing focus. A music player could for instance elect to lower the volume of its music stream (duck) for transient focus losses, and pause otherwise. </para>        
						/// </summary>
						/// <java-name>
						/// onAudioFocusChange
						/// </java-name>
						[Dot42.DexImport("onAudioFocusChange", "(I)V", AccessFlags = 1025)]
						void OnAudioFocusChange(int focusChange) /* MethodBuilder.Create */ ;

				}

		}

		/// <summary>
		///  <para>The AudioRecord class manages the audio resources for Java applications to record audio from the audio input hardware of the platform. This is achieved by "pulling" (reading) the data from the AudioRecord object. The application is responsible for polling the AudioRecord object in time using one of the following three methods: read(byte[],int, int), read(short[], int, int) or read(ByteBuffer, int). The choice of which method to use will be based on the audio data storage format that is the most convenient for the user of AudioRecord. </para> <para>Upon creation, an AudioRecord object initializes its associated audio buffer that it will fill with the new audio data. The size of this buffer, specified during the construction, determines how long an AudioRecord can record before "over-running" data that has not been read yet. Data should be read from the audio hardware in chunks of sizes inferior to the total recording buffer size. </para>    
		/// </summary>
		/// <java-name>
		/// android/media/AudioRecord
		/// </java-name>
		[Dot42.DexImport("android/media/AudioRecord", AccessFlags = 33)]
		public partial class AudioRecord
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>indicates AudioRecord state is not successfully initialized. </para>        
				/// </summary>
				/// <java-name>
				/// STATE_UNINITIALIZED
				/// </java-name>
				[Dot42.DexImport("STATE_UNINITIALIZED", "I", AccessFlags = 25)]
				public const int STATE_UNINITIALIZED = 0;
				/// <summary>
				///  <para>indicates AudioRecord state is ready to be used </para>        
				/// </summary>
				/// <java-name>
				/// STATE_INITIALIZED
				/// </java-name>
				[Dot42.DexImport("STATE_INITIALIZED", "I", AccessFlags = 25)]
				public const int STATE_INITIALIZED = 1;
				/// <summary>
				///  <para>indicates AudioRecord recording state is not recording </para>        
				/// </summary>
				/// <java-name>
				/// RECORDSTATE_STOPPED
				/// </java-name>
				[Dot42.DexImport("RECORDSTATE_STOPPED", "I", AccessFlags = 25)]
				public const int RECORDSTATE_STOPPED = 1;
				/// <summary>
				///  <para>indicates AudioRecord recording state is recording </para>        
				/// </summary>
				/// <java-name>
				/// RECORDSTATE_RECORDING
				/// </java-name>
				[Dot42.DexImport("RECORDSTATE_RECORDING", "I", AccessFlags = 25)]
				public const int RECORDSTATE_RECORDING = 3;
				/// <summary>
				///  <para>Denotes a successful operation. </para>        
				/// </summary>
				/// <java-name>
				/// SUCCESS
				/// </java-name>
				[Dot42.DexImport("SUCCESS", "I", AccessFlags = 25)]
				public const int SUCCESS = 0;
				/// <summary>
				///  <para>Denotes a generic operation failure. </para>        
				/// </summary>
				/// <java-name>
				/// ERROR
				/// </java-name>
				[Dot42.DexImport("ERROR", "I", AccessFlags = 25)]
				public const int ERROR = -1;
				/// <summary>
				///  <para>Denotes a failure due to the use of an invalid value. </para>        
				/// </summary>
				/// <java-name>
				/// ERROR_BAD_VALUE
				/// </java-name>
				[Dot42.DexImport("ERROR_BAD_VALUE", "I", AccessFlags = 25)]
				public const int ERROR_BAD_VALUE = -2;
				/// <summary>
				///  <para>Denotes a failure due to the improper use of a method. </para>        
				/// </summary>
				/// <java-name>
				/// ERROR_INVALID_OPERATION
				/// </java-name>
				[Dot42.DexImport("ERROR_INVALID_OPERATION", "I", AccessFlags = 25)]
				public const int ERROR_INVALID_OPERATION = -3;
				/// <summary>
				///  <para>Class constructor. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(IIIII)V", AccessFlags = 1)]
				public AudioRecord(int audioSource, int sampleRateInHz, int channelConfig, int audioFormat, int bufferSizeInBytes) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Releases the native AudioRecord resources. The object can no longer be used and the reference should be set to null after a call to release() </para>        
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
				extern ~AudioRecord() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns the minimum buffer size required for the successful creation of an AudioRecord object, in byte units. Note that this size doesn't guarantee a smooth recording under load, and higher values should be chosen according to the expected frequency at which the AudioRecord instance will be polled for new data. See AudioRecord(int, int, int, int, int) for more information on valid configuration values.  <para>AudioRecord(int, int, int, int, int) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>ERROR_BAD_VALUE if the recording parameters are not supported by the hardware, or an invalid parameter was passed, or ERROR if the implementation was unable to query the hardware for its input properties, or the minimum buffer size expressed in bytes. </para>
				/// </returns>
				/// <java-name>
				/// getMinBufferSize
				/// </java-name>
				[Dot42.DexImport("getMinBufferSize", "(III)I", AccessFlags = 9)]
				public static int GetMinBufferSize(int sampleRateInHz, int channelConfig, int audioFormat) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Starts recording from the AudioRecord instance. </para>        
				/// </summary>
				/// <java-name>
				/// startRecording
				/// </java-name>
				[Dot42.DexImport("startRecording", "()V", AccessFlags = 1)]
				public virtual void StartRecording() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Stops recording. </para>        
				/// </summary>
				/// <java-name>
				/// stop
				/// </java-name>
				[Dot42.DexImport("stop", "()V", AccessFlags = 1)]
				public virtual void Stop() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([BII)I", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual int Read(sbyte[] sByte, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([BII)I", AccessFlags = 1)]
				public virtual int Read(byte[] @byte, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([SII)I", AccessFlags = 1)]
				public virtual int Read(short[] int16, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Reads audio data from the audio hardware for recording into a direct buffer. If this buffer is not a direct buffer, this method will always return 0. Note that the value returned by java.nio.Buffer#position() on this buffer is unchanged after a call to this method. </para>        
				/// </summary>
				/// <returns>
				///  <para>the number of bytes that were read or or ERROR_INVALID_OPERATION if the object wasn't properly initialized, or ERROR_BAD_VALUE if the parameters don't resolve to valid data and indexes. The number of bytes will not exceed sizeInBytes. </para>
				/// </returns>
				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "(Ljava/nio/ByteBuffer;I)I", AccessFlags = 1)]
				public virtual int Read(global::Java.Nio.ByteBuffer audioBuffer, int sizeInBytes) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Sets the listener the AudioRecord notifies when a previously set marker is reached or for each periodic record head position update. </para>        
				/// </summary>
				/// <java-name>
				/// setRecordPositionUpdateListener
				/// </java-name>
				[Dot42.DexImport("setRecordPositionUpdateListener", "(Landroid/media/AudioRecord$OnRecordPositionUpdateListener;)V", AccessFlags = 1)]
				public virtual void SetRecordPositionUpdateListener(global::Android.Media.AudioRecord.IOnRecordPositionUpdateListener listener) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the listener the AudioRecord notifies when a previously set marker is reached or for each periodic record head position update. Use this method to receive AudioRecord events in the Handler associated with another thread than the one in which you created the AudioTrack instance. </para>        
				/// </summary>
				/// <java-name>
				/// setRecordPositionUpdateListener
				/// </java-name>
				[Dot42.DexImport("setRecordPositionUpdateListener", "(Landroid/media/AudioRecord$OnRecordPositionUpdateListener;Landroid/os/Handler;)V" +
    "", AccessFlags = 1)]
				public virtual void SetRecordPositionUpdateListener(global::Android.Media.AudioRecord.IOnRecordPositionUpdateListener listener, global::Android.OS.Handler handler) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the marker position at which the listener is called, if set with setRecordPositionUpdateListener(OnRecordPositionUpdateListener) or setRecordPositionUpdateListener(OnRecordPositionUpdateListener, Handler). </para>        
				/// </summary>
				/// <returns>
				///  <para>error code or success, see SUCCESS, ERROR_BAD_VALUE, ERROR_INVALID_OPERATION </para>
				/// </returns>
				/// <java-name>
				/// setNotificationMarkerPosition
				/// </java-name>
				[Dot42.DexImport("setNotificationMarkerPosition", "(I)I", AccessFlags = 1)]
				public virtual int SetNotificationMarkerPosition(int markerInFrames) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Sets the period at which the listener is called, if set with setRecordPositionUpdateListener(OnRecordPositionUpdateListener) or setRecordPositionUpdateListener(OnRecordPositionUpdateListener, Handler). It is possible for notifications to be lost if the period is too small. </para>        
				/// </summary>
				/// <returns>
				///  <para>error code or success, see SUCCESS, ERROR_INVALID_OPERATION </para>
				/// </returns>
				/// <java-name>
				/// setPositionNotificationPeriod
				/// </java-name>
				[Dot42.DexImport("setPositionNotificationPeriod", "(I)I", AccessFlags = 1)]
				public virtual int SetPositionNotificationPeriod(int periodInFrames) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal AudioRecord() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Returns the configured audio data sample rate in Hz </para>        
				/// </summary>
				/// <java-name>
				/// getSampleRate
				/// </java-name>
				public virtual int SampleRate
				{
						[Dot42.DexImport("getSampleRate", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns the audio recording source.  <para>MediaRecorder.AudioSource </para></para>        
				/// </summary>
				/// <java-name>
				/// getAudioSource
				/// </java-name>
				public virtual int AudioSource
				{
						[Dot42.DexImport("getAudioSource", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns the configured audio data format. See AudioFormat#ENCODING_PCM_16BIT and AudioFormat#ENCODING_PCM_8BIT. </para>        
				/// </summary>
				/// <java-name>
				/// getAudioFormat
				/// </java-name>
				public virtual int AudioFormat
				{
						[Dot42.DexImport("getAudioFormat", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns the configured channel configuration. See AudioFormat#CHANNEL_IN_MONO and AudioFormat#CHANNEL_IN_STEREO. </para>        
				/// </summary>
				/// <java-name>
				/// getChannelConfiguration
				/// </java-name>
				public virtual int ChannelConfiguration
				{
						[Dot42.DexImport("getChannelConfiguration", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns the configured number of channels. </para>        
				/// </summary>
				/// <java-name>
				/// getChannelCount
				/// </java-name>
				public virtual int ChannelCount
				{
						[Dot42.DexImport("getChannelCount", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns the state of the AudioRecord instance. This is useful after the AudioRecord instance has been created to check if it was initialized properly. This ensures that the appropriate hardware resources have been acquired.  <para>AudioRecord::STATE_INITIALIZED </para> <para>AudioRecord::STATE_UNINITIALIZED </para></para>        
				/// </summary>
				/// <java-name>
				/// getState
				/// </java-name>
				public virtual int State
				{
						[Dot42.DexImport("getState", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns the recording state of the AudioRecord instance.  <para>AudioRecord::RECORDSTATE_STOPPED </para> <para>AudioRecord::RECORDSTATE_RECORDING </para></para>        
				/// </summary>
				/// <java-name>
				/// getRecordingState
				/// </java-name>
				public virtual int RecordingState
				{
						[Dot42.DexImport("getRecordingState", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns the notification marker position expressed in frames. </para>        
				/// </summary>
				/// <java-name>
				/// getNotificationMarkerPosition
				/// </java-name>
				public virtual int NotificationMarkerPosition
				{
						[Dot42.DexImport("getNotificationMarkerPosition", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns the notification update period expressed in frames. </para>        
				/// </summary>
				/// <java-name>
				/// getPositionNotificationPeriod
				/// </java-name>
				public virtual int PositionNotificationPeriod
				{
						[Dot42.DexImport("getPositionNotificationPeriod", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Interface definition for a callback to be invoked when an AudioRecord has reached a notification marker set by AudioRecord#setNotificationMarkerPosition(int) or for periodic updates on the progress of the record head, as set by AudioRecord#setPositionNotificationPeriod(int). </para>    
				/// </summary>
				/// <java-name>
				/// android/media/AudioRecord$OnRecordPositionUpdateListener
				/// </java-name>
				[Dot42.DexImport("android/media/AudioRecord$OnRecordPositionUpdateListener", AccessFlags = 1545)]
				public partial interface IOnRecordPositionUpdateListener
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>Called on the listener to notify it that the previously set marker has been reached by the recording head. </para>        
						/// </summary>
						/// <java-name>
						/// onMarkerReached
						/// </java-name>
						[Dot42.DexImport("onMarkerReached", "(Landroid/media/AudioRecord;)V", AccessFlags = 1025)]
						void OnMarkerReached(global::Android.Media.AudioRecord recorder) /* MethodBuilder.Create */ ;

						/// <summary>
						///  <para>Called on the listener to periodically notify it that the record head has reached a multiple of the notification period. </para>        
						/// </summary>
						/// <java-name>
						/// onPeriodicNotification
						/// </java-name>
						[Dot42.DexImport("onPeriodicNotification", "(Landroid/media/AudioRecord;)V", AccessFlags = 1025)]
						void OnPeriodicNotification(global::Android.Media.AudioRecord recorder) /* MethodBuilder.Create */ ;

				}

		}

		/// <summary>
		///  <para>The AudioTrack class manages and plays a single audio resource for Java applications. It allows streaming of PCM audio buffers to the audio sink for playback. This is achieved by "pushing" the data to the AudioTrack object using one of the write(byte[], int, int) and write(short[], int, int) methods.</para> <para>An AudioTrack instance can operate under two modes: static or streaming. <br></br> In Streaming mode, the application writes a continuous stream of data to the AudioTrack, using one of the <c>write() </c> methods. These are blocking and return when the data has been transferred from the Java layer to the native layer and queued for playback. The streaming mode is most useful when playing blocks of audio data that for instance are:</para> <para> <ul> <li> <para>too big to fit in memory because of the duration of the sound to play, </para></li> <li> <para>too big to fit in memory because of the characteristics of the audio data (high sampling rate, bits per sample ...) </para></li> <li> <para>received or generated while previously queued audio is playing. </para></li></ul></para> <para>The static mode should be chosen when dealing with short sounds that fit in memory and that need to be played with the smallest latency possible. The static mode will therefore be preferred for UI and game sounds that are played often, and with the smallest overhead possible.</para> <para>Upon creation, an AudioTrack object initializes its associated audio buffer. The size of this buffer, specified during the construction, determines how long an AudioTrack can play before running out of data. <br></br> For an AudioTrack using the static mode, this size is the maximum size of the sound that can be played from it. <br></br> For the streaming mode, data will be written to the audio sink in chunks of sizes less than or equal to the total buffer size.</para> <para>AudioTrack is not final and thus permits subclasses, but such use is not recommended. </para>    
		/// </summary>
		/// <java-name>
		/// android/media/AudioTrack
		/// </java-name>
		[Dot42.DexImport("android/media/AudioTrack", AccessFlags = 33)]
		public partial class AudioTrack
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>indicates AudioTrack state is stopped </para>        
				/// </summary>
				/// <java-name>
				/// PLAYSTATE_STOPPED
				/// </java-name>
				[Dot42.DexImport("PLAYSTATE_STOPPED", "I", AccessFlags = 25)]
				public const int PLAYSTATE_STOPPED = 1;
				/// <summary>
				///  <para>indicates AudioTrack state is paused </para>        
				/// </summary>
				/// <java-name>
				/// PLAYSTATE_PAUSED
				/// </java-name>
				[Dot42.DexImport("PLAYSTATE_PAUSED", "I", AccessFlags = 25)]
				public const int PLAYSTATE_PAUSED = 2;
				/// <summary>
				///  <para>indicates AudioTrack state is playing </para>        
				/// </summary>
				/// <java-name>
				/// PLAYSTATE_PLAYING
				/// </java-name>
				[Dot42.DexImport("PLAYSTATE_PLAYING", "I", AccessFlags = 25)]
				public const int PLAYSTATE_PLAYING = 3;
				/// <summary>
				///  <para>Creation mode where audio data is transferred from Java to the native layer only once before the audio starts playing. </para>        
				/// </summary>
				/// <java-name>
				/// MODE_STATIC
				/// </java-name>
				[Dot42.DexImport("MODE_STATIC", "I", AccessFlags = 25)]
				public const int MODE_STATIC = 0;
				/// <summary>
				///  <para>Creation mode where audio data is streamed from Java to the native layer as the audio is playing. </para>        
				/// </summary>
				/// <java-name>
				/// MODE_STREAM
				/// </java-name>
				[Dot42.DexImport("MODE_STREAM", "I", AccessFlags = 25)]
				public const int MODE_STREAM = 1;
				/// <summary>
				///  <para>State of an AudioTrack that was not successfully initialized upon creation. </para>        
				/// </summary>
				/// <java-name>
				/// STATE_UNINITIALIZED
				/// </java-name>
				[Dot42.DexImport("STATE_UNINITIALIZED", "I", AccessFlags = 25)]
				public const int STATE_UNINITIALIZED = 0;
				/// <summary>
				///  <para>State of an AudioTrack that is ready to be used. </para>        
				/// </summary>
				/// <java-name>
				/// STATE_INITIALIZED
				/// </java-name>
				[Dot42.DexImport("STATE_INITIALIZED", "I", AccessFlags = 25)]
				public const int STATE_INITIALIZED = 1;
				/// <summary>
				///  <para>State of a successfully initialized AudioTrack that uses static data, but that hasn't received that data yet. </para>        
				/// </summary>
				/// <java-name>
				/// STATE_NO_STATIC_DATA
				/// </java-name>
				[Dot42.DexImport("STATE_NO_STATIC_DATA", "I", AccessFlags = 25)]
				public const int STATE_NO_STATIC_DATA = 2;
				/// <summary>
				///  <para>Denotes a successful operation. </para>        
				/// </summary>
				/// <java-name>
				/// SUCCESS
				/// </java-name>
				[Dot42.DexImport("SUCCESS", "I", AccessFlags = 25)]
				public const int SUCCESS = 0;
				/// <summary>
				///  <para>Denotes a generic operation failure. </para>        
				/// </summary>
				/// <java-name>
				/// ERROR
				/// </java-name>
				[Dot42.DexImport("ERROR", "I", AccessFlags = 25)]
				public const int ERROR = -1;
				/// <summary>
				///  <para>Denotes a failure due to the use of an invalid value. </para>        
				/// </summary>
				/// <java-name>
				/// ERROR_BAD_VALUE
				/// </java-name>
				[Dot42.DexImport("ERROR_BAD_VALUE", "I", AccessFlags = 25)]
				public const int ERROR_BAD_VALUE = -2;
				/// <summary>
				///  <para>Denotes a failure due to the improper use of a method. </para>        
				/// </summary>
				/// <java-name>
				/// ERROR_INVALID_OPERATION
				/// </java-name>
				[Dot42.DexImport("ERROR_INVALID_OPERATION", "I", AccessFlags = 25)]
				public const int ERROR_INVALID_OPERATION = -3;
				/// <summary>
				///  <para>Class constructor. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(IIIIII)V", AccessFlags = 1)]
				public AudioTrack(int streamType, int sampleRateInHz, int channelConfig, int audioFormat, int bufferSizeInBytes, int mode) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Class constructor with audio session. Use this constructor when the AudioTrack must be attached to a particular audio session. The primary use of the audio session ID is to associate audio effects to a particular instance of AudioTrack: if an audio session ID is provided when creating an AudioEffect, this effect will be applied only to audio tracks and media players in the same session and not to the output mix. When an AudioTrack is created without specifying a session, it will create its own session which can be retrieved by calling the getAudioSessionId() method. If a non-zero session ID is provided, this AudioTrack will share effects attached to this session with all other media players or audio tracks in the same session, otherwise a new session will be created for this track if none is supplied. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(IIIIIII)V", AccessFlags = 1)]
				public AudioTrack(int streamType, int sampleRateInHz, int channelConfig, int audioFormat, int bufferSizeInBytes, int mode, int sessionId) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Releases the native AudioTrack resources. </para>        
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
				extern ~AudioTrack() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns the output sample rate in Hz for the specified stream type. </para>        
				/// </summary>
				/// <java-name>
				/// getNativeOutputSampleRate
				/// </java-name>
				[Dot42.DexImport("getNativeOutputSampleRate", "(I)I", AccessFlags = 9)]
				public static int GetNativeOutputSampleRate(int streamType) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Returns the minimum buffer size required for the successful creation of an AudioTrack object to be created in the MODE_STREAM mode. Note that this size doesn't guarantee a smooth playback under load, and higher values should be chosen according to the expected frequency at which the buffer will be refilled with additional data to play. For example, if you intend to dynamically set the source sample rate of an AudioTrack to a higher value than the initial source sample rate, be sure to configure the buffer size based on the highest planned sample rate. </para>        
				/// </summary>
				/// <returns>
				///  <para>ERROR_BAD_VALUE if an invalid parameter was passed, or ERROR if unable to query for output properties, or the minimum buffer size expressed in bytes. </para>
				/// </returns>
				/// <java-name>
				/// getMinBufferSize
				/// </java-name>
				[Dot42.DexImport("getMinBufferSize", "(III)I", AccessFlags = 9)]
				public static int GetMinBufferSize(int sampleRateInHz, int channelConfig, int audioFormat) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Sets the listener the AudioTrack notifies when a previously set marker is reached or for each periodic playback head position update. Notifications will be received in the same thread as the one in which the AudioTrack instance was created. </para>        
				/// </summary>
				/// <java-name>
				/// setPlaybackPositionUpdateListener
				/// </java-name>
				[Dot42.DexImport("setPlaybackPositionUpdateListener", "(Landroid/media/AudioTrack$OnPlaybackPositionUpdateListener;)V", AccessFlags = 1)]
				public virtual void SetPlaybackPositionUpdateListener(global::Android.Media.AudioTrack.IOnPlaybackPositionUpdateListener listener) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the listener the AudioTrack notifies when a previously set marker is reached or for each periodic playback head position update. Use this method to receive AudioTrack events in the Handler associated with another thread than the one in which you created the AudioTrack instance. </para>        
				/// </summary>
				/// <java-name>
				/// setPlaybackPositionUpdateListener
				/// </java-name>
				[Dot42.DexImport("setPlaybackPositionUpdateListener", "(Landroid/media/AudioTrack$OnPlaybackPositionUpdateListener;Landroid/os/Handler;)" +
    "V", AccessFlags = 1)]
				public virtual void SetPlaybackPositionUpdateListener(global::Android.Media.AudioTrack.IOnPlaybackPositionUpdateListener listener, global::Android.OS.Handler handler) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the specified left/right output volume values on the AudioTrack. Values are clamped to the (getMinVolume(), getMaxVolume()) interval if outside this range. </para>        
				/// </summary>
				/// <returns>
				///  <para>error code or success, see SUCCESS, ERROR_INVALID_OPERATION </para>
				/// </returns>
				/// <java-name>
				/// setStereoVolume
				/// </java-name>
				[Dot42.DexImport("setStereoVolume", "(FF)I", AccessFlags = 1)]
				public virtual int SetStereoVolume(float leftVolume, float rightVolume) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Sets the playback sample rate for this track. This sets the sampling rate at which the audio data will be consumed and played back (as set by the sampleRateInHz parameter in the AudioTrack(int, int, int, int, int, int) constructor), not the original sampling rate of the content. For example, setting it to half the sample rate of the content will cause the playback to last twice as long, but will also result in a pitch shift down by one octave. The valid sample rate range is from 1 Hz to twice the value returned by getNativeOutputSampleRate(int). </para>        
				/// </summary>
				/// <returns>
				///  <para>error code or success, see SUCCESS, ERROR_BAD_VALUE, ERROR_INVALID_OPERATION </para>
				/// </returns>
				/// <java-name>
				/// setPlaybackRate
				/// </java-name>
				[Dot42.DexImport("setPlaybackRate", "(I)I", AccessFlags = 1)]
				public virtual int SetPlaybackRate(int sampleRateInHz) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Sets the position of the notification marker. At most one marker can be active. </para>        
				/// </summary>
				/// <returns>
				///  <para>error code or success, see SUCCESS, ERROR_BAD_VALUE, ERROR_INVALID_OPERATION </para>
				/// </returns>
				/// <java-name>
				/// setNotificationMarkerPosition
				/// </java-name>
				[Dot42.DexImport("setNotificationMarkerPosition", "(I)I", AccessFlags = 1)]
				public virtual int SetNotificationMarkerPosition(int markerInFrames) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Sets the period for the periodic notification event. </para>        
				/// </summary>
				/// <returns>
				///  <para>error code or success, see SUCCESS, ERROR_INVALID_OPERATION </para>
				/// </returns>
				/// <java-name>
				/// setPositionNotificationPeriod
				/// </java-name>
				[Dot42.DexImport("setPositionNotificationPeriod", "(I)I", AccessFlags = 1)]
				public virtual int SetPositionNotificationPeriod(int periodInFrames) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Sets the playback head position. The track must be stopped or paused for the position to be changed, and must use the MODE_STATIC mode. </para>        
				/// </summary>
				/// <returns>
				///  <para>error code or success, see SUCCESS, ERROR_BAD_VALUE, ERROR_INVALID_OPERATION </para>
				/// </returns>
				/// <java-name>
				/// setPlaybackHeadPosition
				/// </java-name>
				[Dot42.DexImport("setPlaybackHeadPosition", "(I)I", AccessFlags = 1)]
				public virtual int SetPlaybackHeadPosition(int positionInFrames) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Sets the loop points and the loop count. The loop can be infinite. Similarly to setPlaybackHeadPosition, the track must be stopped or paused for the loop points to be changed, and must use the MODE_STATIC mode. </para>        
				/// </summary>
				/// <returns>
				///  <para>error code or success, see SUCCESS, ERROR_BAD_VALUE, ERROR_INVALID_OPERATION </para>
				/// </returns>
				/// <java-name>
				/// setLoopPoints
				/// </java-name>
				[Dot42.DexImport("setLoopPoints", "(III)I", AccessFlags = 1)]
				public virtual int SetLoopPoints(int startInFrames, int endInFrames, int loopCount) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Sets the initialization state of the instance. This method was originally intended to be used in an AudioTrack subclass constructor to set a subclass-specific post-initialization state. However, subclasses of AudioTrack are no longer recommended, so this method is obsolete.  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Only accessible by subclasses, which are not recommended for AudioTrack. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// setState
				/// </java-name>
				[Dot42.DexImport("setState", "(I)V", AccessFlags = 4)]
				protected internal virtual void SetState(int state) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Starts playing an AudioTrack. If track's creation mode is MODE_STATIC, you must have called write() prior.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// play
				/// </java-name>
				[Dot42.DexImport("play", "()V", AccessFlags = 1)]
				public virtual void Play() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Stops playing the audio data. When used on an instance created in MODE_STREAM mode, audio will stop playing after the last buffer that was written has been played. For an immediate stop, use pause(), followed by flush() to discard audio data that hasn't been played back yet. </para>        
				/// </summary>
				/// <java-name>
				/// stop
				/// </java-name>
				[Dot42.DexImport("stop", "()V", AccessFlags = 1)]
				public virtual void Stop() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Pauses the playback of the audio data. Data that has not been played back will not be discarded. Subsequent calls to play will play this data back. See flush() to discard this data.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// pause
				/// </java-name>
				[Dot42.DexImport("pause", "()V", AccessFlags = 1)]
				public virtual void Pause() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Flushes the audio data currently queued for playback. Any data that has not been played back will be discarded. No-op if not stopped or paused, or if the track's creation mode is not MODE_STREAM. </para>        
				/// </summary>
				/// <java-name>
				/// flush
				/// </java-name>
				[Dot42.DexImport("flush", "()V", AccessFlags = 1)]
				public virtual void Flush() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([BII)I", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual int Write(sbyte[] sByte, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([BII)I", AccessFlags = 1)]
				public virtual int Write(byte[] @byte, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([SII)I", AccessFlags = 1)]
				public virtual int Write(short[] int16, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Notifies the native resource to reuse the audio data already loaded in the native layer, that is to rewind to start of buffer. The track's creation mode must be MODE_STATIC. </para>        
				/// </summary>
				/// <returns>
				///  <para>error code or success, see SUCCESS, ERROR_BAD_VALUE, ERROR_INVALID_OPERATION </para>
				/// </returns>
				/// <java-name>
				/// reloadStaticData
				/// </java-name>
				[Dot42.DexImport("reloadStaticData", "()I", AccessFlags = 1)]
				public virtual int ReloadStaticData() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Attaches an auxiliary effect to the audio track. A typical auxiliary effect is a reverberation effect which can be applied on any sound source that directs a certain amount of its energy to this effect. This amount is defined by setAuxEffectSendLevel(). { <para>setAuxEffectSendLevel(float)}. </para>After creating an auxiliary effect (e.g. android.media.audiofx.EnvironmentalReverb), retrieve its ID with android.media.audiofx.AudioEffect#getId() and use it when calling this method to attach the audio track to the effect. </para> <para>To detach the effect from the audio track, call this method with a null effect id.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>error code or success, see SUCCESS, ERROR_INVALID_OPERATION, ERROR_BAD_VALUE </para>
				/// </returns>
				/// <java-name>
				/// attachAuxEffect
				/// </java-name>
				[Dot42.DexImport("attachAuxEffect", "(I)I", AccessFlags = 1)]
				public virtual int AttachAuxEffect(int effectId) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Sets the send level of the audio track to the attached auxiliary effect attachAuxEffect(int). The level value range is 0.0f to 1.0f. Values are clamped to the (0.0f, 1.0f) interval if outside this range. </para> <para>By default the send level is 0.0f, so even if an effect is attached to the player this method must be called for the effect to be applied. </para> <para>Note that the passed level value is a raw scalar. UI controls should be scaled logarithmically: the gain applied by audio framework ranges from -72dB to 0dB, so an appropriate conversion from linear UI input x to level is: x == 0 -&gt; level = 0 0 &lt; x &lt;= R -&gt; level = 10^(72*(x-R)/20/R)</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>error code or success, see SUCCESS, ERROR_INVALID_OPERATION </para>
				/// </returns>
				/// <java-name>
				/// setAuxEffectSendLevel
				/// </java-name>
				[Dot42.DexImport("setAuxEffectSendLevel", "(F)I", AccessFlags = 1)]
				public virtual int SetAuxEffectSendLevel(float level) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal AudioTrack() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Returns the minimum valid volume value. Volume values set under this one will be clamped at this value. </para>        
				/// </summary>
				/// <returns>
				///  <para>the minimum volume expressed as a linear attenuation. </para>
				/// </returns>
				/// <java-name>
				/// getMinVolume
				/// </java-name>
				public static float MinVolume
				{
						[Dot42.DexImport("getMinVolume", "()F", AccessFlags = 9)]
						get{ return default(float); }
				}

				/// <summary>
				///  <para>Returns the maximum valid volume value. Volume values set above this one will be clamped at this value. </para>        
				/// </summary>
				/// <returns>
				///  <para>the maximum volume expressed as a linear attenuation. </para>
				/// </returns>
				/// <java-name>
				/// getMaxVolume
				/// </java-name>
				public static float MaxVolume
				{
						[Dot42.DexImport("getMaxVolume", "()F", AccessFlags = 9)]
						get{ return default(float); }
				}

				/// <summary>
				///  <para>Returns the configured audio data sample rate in Hz </para>        
				/// </summary>
				/// <java-name>
				/// getSampleRate
				/// </java-name>
				public virtual int SampleRate
				{
						[Dot42.DexImport("getSampleRate", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns the current playback rate in Hz. </para>        
				/// </summary>
				/// <java-name>
				/// getPlaybackRate
				/// </java-name>
				public virtual int PlaybackRate
				{
						[Dot42.DexImport("getPlaybackRate", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns the configured audio data format. See AudioFormat#ENCODING_PCM_16BIT and AudioFormat#ENCODING_PCM_8BIT. </para>        
				/// </summary>
				/// <java-name>
				/// getAudioFormat
				/// </java-name>
				public virtual int AudioFormat
				{
						[Dot42.DexImport("getAudioFormat", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns the type of audio stream this AudioTrack is configured for. Compare the result against AudioManager#STREAM_VOICE_CALL, AudioManager#STREAM_SYSTEM, AudioManager#STREAM_RING, AudioManager#STREAM_MUSIC, AudioManager#STREAM_ALARM, AudioManager#STREAM_NOTIFICATION, or AudioManager#STREAM_DTMF. </para>        
				/// </summary>
				/// <java-name>
				/// getStreamType
				/// </java-name>
				public virtual int StreamType
				{
						[Dot42.DexImport("getStreamType", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns the configured channel configuration. See AudioFormat#CHANNEL_OUT_MONO and AudioFormat#CHANNEL_OUT_STEREO. </para>        
				/// </summary>
				/// <java-name>
				/// getChannelConfiguration
				/// </java-name>
				public virtual int ChannelConfiguration
				{
						[Dot42.DexImport("getChannelConfiguration", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns the configured number of channels. </para>        
				/// </summary>
				/// <java-name>
				/// getChannelCount
				/// </java-name>
				public virtual int ChannelCount
				{
						[Dot42.DexImport("getChannelCount", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns the state of the AudioTrack instance. This is useful after the AudioTrack instance has been created to check if it was initialized properly. This ensures that the appropriate resources have been acquired.  <para>STATE_INITIALIZED </para> <para>STATE_NO_STATIC_DATA </para> <para>STATE_UNINITIALIZED </para></para>        
				/// </summary>
				/// <java-name>
				/// getState
				/// </java-name>
				public virtual int State
				{
						[Dot42.DexImport("getState", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns the playback state of the AudioTrack instance.  <para>PLAYSTATE_STOPPED </para> <para>PLAYSTATE_PAUSED </para> <para>PLAYSTATE_PLAYING </para></para>        
				/// </summary>
				/// <java-name>
				/// getPlayState
				/// </java-name>
				public virtual int PlayState
				{
						[Dot42.DexImport("getPlayState", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns the "native frame count", derived from the bufferSizeInBytes specified at creation time and converted to frame units. If track's creation mode is MODE_STATIC, it is equal to the specified bufferSizeInBytes converted to frame units. If track's creation mode is MODE_STREAM, it is typically greater than or equal to the specified bufferSizeInBytes converted to frame units; it may be rounded up to a larger value if needed by the target device implementation.  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Only accessible by subclasses, which are not recommended for AudioTrack. See AudioManager#getProperty(String) for key AudioManager#PROPERTY_OUTPUT_FRAMES_PER_BUFFER. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// getNativeFrameCount
				/// </java-name>
				protected internal virtual int NativeFrameCount
				{
						[Dot42.DexImport("getNativeFrameCount", "()I", AccessFlags = 4)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns marker position expressed in frames. </para>        
				/// </summary>
				/// <returns>
				///  <para>marker position in wrapping frame units similar to getPlaybackHeadPosition, or zero if marker is disabled. </para>
				/// </returns>
				/// <java-name>
				/// getNotificationMarkerPosition
				/// </java-name>
				public virtual int NotificationMarkerPosition
				{
						[Dot42.DexImport("getNotificationMarkerPosition", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns the notification update period expressed in frames. Zero means that no position update notifications are being delivered. </para>        
				/// </summary>
				/// <java-name>
				/// getPositionNotificationPeriod
				/// </java-name>
				public virtual int PositionNotificationPeriod
				{
						[Dot42.DexImport("getPositionNotificationPeriod", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns the playback head position expressed in frames. Though the "int" type is signed 32-bits, the value should be reinterpreted as if it is unsigned 32-bits. That is, the next position after 0x7FFFFFFF is (int) 0x80000000. This is a continuously advancing counter. It will wrap (overflow) periodically, for example approximately once every 27:03:11 hours:minutes:seconds at 44.1 kHz. It is reset to zero by flush(), reload(), and stop(). </para>        
				/// </summary>
				/// <java-name>
				/// getPlaybackHeadPosition
				/// </java-name>
				public virtual int PlaybackHeadPosition
				{
						[Dot42.DexImport("getPlaybackHeadPosition", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns the audio session ID.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the ID of the audio session this AudioTrack belongs to. </para>
				/// </returns>
				/// <java-name>
				/// getAudioSessionId
				/// </java-name>
				public virtual int AudioSessionId
				{
						[Dot42.DexImport("getAudioSessionId", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Interface definition for a callback to be invoked when the playback head position of an AudioTrack has reached a notification marker or has increased by a certain period. </para>    
				/// </summary>
				/// <java-name>
				/// android/media/AudioTrack$OnPlaybackPositionUpdateListener
				/// </java-name>
				[Dot42.DexImport("android/media/AudioTrack$OnPlaybackPositionUpdateListener", AccessFlags = 1545)]
				public partial interface IOnPlaybackPositionUpdateListener
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>Called on the listener to notify it that the previously set marker has been reached by the playback head. </para>        
						/// </summary>
						/// <java-name>
						/// onMarkerReached
						/// </java-name>
						[Dot42.DexImport("onMarkerReached", "(Landroid/media/AudioTrack;)V", AccessFlags = 1025)]
						void OnMarkerReached(global::Android.Media.AudioTrack track) /* MethodBuilder.Create */ ;

						/// <summary>
						///  <para>Called on the listener to periodically notify it that the playback head has reached a multiple of the notification period. </para>        
						/// </summary>
						/// <java-name>
						/// onPeriodicNotification
						/// </java-name>
						[Dot42.DexImport("onPeriodicNotification", "(Landroid/media/AudioTrack;)V", AccessFlags = 1025)]
						void OnPeriodicNotification(global::Android.Media.AudioTrack track) /* MethodBuilder.Create */ ;

				}

		}

		/// <summary>
		///  <para>Retrieves the predefined camcorder profile settings for camcorder applications. These settings are read-only.</para> <para>The compressed output from a recording session with a given CamcorderProfile contains two tracks: one for audio and one for video.</para> <para>Each profile specifies the following set of parameters:  <ul> <li> <para>The file output format </para></li> <li> <para>Video codec format </para></li> <li> <para>Video bit rate in bits per second </para></li> <li> <para>Video frame rate in frames per second </para></li> <li> <para>Video frame width and height, </para></li> <li> <para>Audio codec format </para></li> <li> <para>Audio bit rate in bits per second, </para></li> <li> <para>Audio sample rate </para></li> <li> <para>Number of audio channels for recording. </para></li></ul></para>    
		/// </summary>
		/// <java-name>
		/// android/media/CamcorderProfile
		/// </java-name>
		[Dot42.DexImport("android/media/CamcorderProfile", AccessFlags = 33)]
		public partial class CamcorderProfile
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Quality level corresponding to the lowest available resolution. </para>        
				/// </summary>
				/// <java-name>
				/// QUALITY_LOW
				/// </java-name>
				[Dot42.DexImport("QUALITY_LOW", "I", AccessFlags = 25)]
				public const int QUALITY_LOW = 0;
				/// <summary>
				///  <para>Quality level corresponding to the highest available resolution. </para>        
				/// </summary>
				/// <java-name>
				/// QUALITY_HIGH
				/// </java-name>
				[Dot42.DexImport("QUALITY_HIGH", "I", AccessFlags = 25)]
				public const int QUALITY_HIGH = 1;
				/// <summary>
				///  <para>Default recording duration in seconds before the session is terminated. This is useful for applications like MMS has limited file size requirement. </para>        
				/// </summary>
				/// <java-name>
				/// duration
				/// </java-name>
				[Dot42.DexImport("duration", "I", AccessFlags = 1)]
				public int Duration;
				/// <summary>
				///  <para>The quality level of the camcorder profile </para>        
				/// </summary>
				/// <java-name>
				/// quality
				/// </java-name>
				[Dot42.DexImport("quality", "I", AccessFlags = 1)]
				public int Quality;
				/// <summary>
				///  <para>The file output format of the camcorder profile  <para>android.media.MediaRecorder.OutputFormat </para></para>        
				/// </summary>
				/// <java-name>
				/// fileFormat
				/// </java-name>
				[Dot42.DexImport("fileFormat", "I", AccessFlags = 1)]
				public int FileFormat;
				/// <summary>
				///  <para>The video encoder being used for the video track  <para>android.media.MediaRecorder.VideoEncoder </para></para>        
				/// </summary>
				/// <java-name>
				/// videoCodec
				/// </java-name>
				[Dot42.DexImport("videoCodec", "I", AccessFlags = 1)]
				public int VideoCodec;
				/// <summary>
				///  <para>The target video output bit rate in bits per second </para>        
				/// </summary>
				/// <java-name>
				/// videoBitRate
				/// </java-name>
				[Dot42.DexImport("videoBitRate", "I", AccessFlags = 1)]
				public int VideoBitRate;
				/// <summary>
				///  <para>The target video frame rate in frames per second </para>        
				/// </summary>
				/// <java-name>
				/// videoFrameRate
				/// </java-name>
				[Dot42.DexImport("videoFrameRate", "I", AccessFlags = 1)]
				public int VideoFrameRate;
				/// <summary>
				///  <para>The target video frame width in pixels </para>        
				/// </summary>
				/// <java-name>
				/// videoFrameWidth
				/// </java-name>
				[Dot42.DexImport("videoFrameWidth", "I", AccessFlags = 1)]
				public int VideoFrameWidth;
				/// <summary>
				///  <para>The target video frame height in pixels </para>        
				/// </summary>
				/// <java-name>
				/// videoFrameHeight
				/// </java-name>
				[Dot42.DexImport("videoFrameHeight", "I", AccessFlags = 1)]
				public int VideoFrameHeight;
				/// <summary>
				///  <para>The audio encoder being used for the audio track.  <para>android.media.MediaRecorder.AudioEncoder </para></para>        
				/// </summary>
				/// <java-name>
				/// audioCodec
				/// </java-name>
				[Dot42.DexImport("audioCodec", "I", AccessFlags = 1)]
				public int AudioCodec;
				/// <summary>
				///  <para>The target audio output bit rate in bits per second </para>        
				/// </summary>
				/// <java-name>
				/// audioBitRate
				/// </java-name>
				[Dot42.DexImport("audioBitRate", "I", AccessFlags = 1)]
				public int AudioBitRate;
				/// <summary>
				///  <para>The audio sampling rate used for the audio track </para>        
				/// </summary>
				/// <java-name>
				/// audioSampleRate
				/// </java-name>
				[Dot42.DexImport("audioSampleRate", "I", AccessFlags = 1)]
				public int AudioSampleRate;
				/// <summary>
				///  <para>The number of audio channels used for the audio track </para>        
				/// </summary>
				/// <java-name>
				/// audioChannels
				/// </java-name>
				[Dot42.DexImport("audioChannels", "I", AccessFlags = 1)]
				public int AudioChannels;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal CamcorderProfile() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns the camcorder profile for the first back-facing camera on the device at the given quality level. If the device has no back-facing camera, this returns null.  <para>get(int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(I)Landroid/media/CamcorderProfile;", AccessFlags = 9)]
				public static global::Android.Media.CamcorderProfile Get(int quality) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Media.CamcorderProfile);
				}

				/// <summary>
				///  <para>Returns the camcorder profile for the given camera at the given quality level.</para> <para>Quality levels QUALITY_LOW, QUALITY_HIGH are guaranteed to be supported, while other levels may or may not be supported. The supported levels can be checked using hasProfile(int, int). QUALITY_LOW refers to the lowest quality available, while QUALITY_HIGH refers to the highest quality available. QUALITY_LOW/QUALITY_HIGH have to match one of qcif, cif, 480p, 720p, or 1080p. E.g. if the device supports 480p, 720p, and 1080p, then low is 480p and high is 1080p.</para> <para>The same is true for time lapse quality levels, i.e. QUALITY_TIME_LAPSE_LOW, QUALITY_TIME_LAPSE_HIGH are guaranteed to be supported and have to match one of qcif, cif, 480p, 720p, or 1080p.</para> <para>A camcorder recording session with higher quality level usually has higher output bit rate, better video and/or audio recording quality, larger video frame resolution and higher audio sampling rate, etc, than those with lower quality level.</para> <para> <para>QUALITY_LOW </para> <para>QUALITY_HIGH </para> <para>QUALITY_QCIF </para> <para>QUALITY_CIF </para> <para>QUALITY_480P </para> <para>QUALITY_720P </para> <para>QUALITY_1080P </para> <para>QUALITY_TIME_LAPSE_LOW </para> <para>QUALITY_TIME_LAPSE_HIGH </para> <para>QUALITY_TIME_LAPSE_QCIF </para> <para>QUALITY_TIME_LAPSE_CIF </para> <para>QUALITY_TIME_LAPSE_480P </para> <para>QUALITY_TIME_LAPSE_720P </para> <para>QUALITY_TIME_LAPSE_1080P </para></para>        
				/// </summary>
				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(II)Landroid/media/CamcorderProfile;", AccessFlags = 9)]
				public static global::Android.Media.CamcorderProfile Get(int cameraId, int quality) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Media.CamcorderProfile);
				}

		}

		/// <summary>
		///  <para>The CameraProfile class is used to retrieve the pre-defined still image capture (jpeg) quality levels (0-100) used for low, medium, and high quality settings in the Camera application. </para>    
		/// </summary>
		/// <java-name>
		/// android/media/CameraProfile
		/// </java-name>
		[Dot42.DexImport("android/media/CameraProfile", AccessFlags = 33)]
		public partial class CameraProfile
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Define three quality levels for JPEG image encoding. </para>        
				/// </summary>
				/// <java-name>
				/// QUALITY_LOW
				/// </java-name>
				[Dot42.DexImport("QUALITY_LOW", "I", AccessFlags = 25)]
				public const int QUALITY_LOW = 0;
				/// <java-name>
				/// QUALITY_MEDIUM
				/// </java-name>
				[Dot42.DexImport("QUALITY_MEDIUM", "I", AccessFlags = 25)]
				public const int QUALITY_MEDIUM = 1;
				/// <java-name>
				/// QUALITY_HIGH
				/// </java-name>
				[Dot42.DexImport("QUALITY_HIGH", "I", AccessFlags = 25)]
				public const int QUALITY_HIGH = 2;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public CameraProfile() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns a pre-defined still image capture (jpeg) quality level used for the given quality level in the Camera application for the first back-facing camera on the device. If the device has no back-facing camera, this returns 0.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// getJpegEncodingQualityParameter
				/// </java-name>
				[Dot42.DexImport("getJpegEncodingQualityParameter", "(I)I", AccessFlags = 9)]
				public static int GetJpegEncodingQualityParameter(int quality) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Returns a pre-defined still image capture (jpeg) quality level used for the given quality level in the Camera application for the specified camera.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// getJpegEncodingQualityParameter
				/// </java-name>
				[Dot42.DexImport("getJpegEncodingQualityParameter", "(II)I", AccessFlags = 9)]
				public static int GetJpegEncodingQualityParameter(int cameraId, int quality) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

		}

		/// <summary>
		///  <para>This is a class for reading and writing Exif tags in a JPEG file. </para>    
		/// </summary>
		/// <java-name>
		/// android/media/ExifInterface
		/// </java-name>
		[Dot42.DexImport("android/media/ExifInterface", AccessFlags = 33)]
		public partial class ExifInterface
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Type is int. </para>        
				/// </summary>
				/// <java-name>
				/// TAG_ORIENTATION
				/// </java-name>
				[Dot42.DexImport("TAG_ORIENTATION", "Ljava/lang/String;", AccessFlags = 25)]
				public const string TAG_ORIENTATION = "Orientation";
				/// <summary>
				///  <para>Type is String. </para>        
				/// </summary>
				/// <java-name>
				/// TAG_DATETIME
				/// </java-name>
				[Dot42.DexImport("TAG_DATETIME", "Ljava/lang/String;", AccessFlags = 25)]
				public const string TAG_DATETIME = "DateTime";
				/// <summary>
				///  <para>Type is String. </para>        
				/// </summary>
				/// <java-name>
				/// TAG_MAKE
				/// </java-name>
				[Dot42.DexImport("TAG_MAKE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string TAG_MAKE = "Make";
				/// <summary>
				///  <para>Type is String. </para>        
				/// </summary>
				/// <java-name>
				/// TAG_MODEL
				/// </java-name>
				[Dot42.DexImport("TAG_MODEL", "Ljava/lang/String;", AccessFlags = 25)]
				public const string TAG_MODEL = "Model";
				/// <summary>
				///  <para>Type is int. </para>        
				/// </summary>
				/// <java-name>
				/// TAG_FLASH
				/// </java-name>
				[Dot42.DexImport("TAG_FLASH", "Ljava/lang/String;", AccessFlags = 25)]
				public const string TAG_FLASH = "Flash";
				/// <summary>
				///  <para>Type is int. </para>        
				/// </summary>
				/// <java-name>
				/// TAG_IMAGE_WIDTH
				/// </java-name>
				[Dot42.DexImport("TAG_IMAGE_WIDTH", "Ljava/lang/String;", AccessFlags = 25)]
				public const string TAG_IMAGE_WIDTH = "ImageWidth";
				/// <summary>
				///  <para>Type is int. </para>        
				/// </summary>
				/// <java-name>
				/// TAG_IMAGE_LENGTH
				/// </java-name>
				[Dot42.DexImport("TAG_IMAGE_LENGTH", "Ljava/lang/String;", AccessFlags = 25)]
				public const string TAG_IMAGE_LENGTH = "ImageLength";
				/// <summary>
				///  <para>String. Format is "num1/denom1,num2/denom2,num3/denom3". </para>        
				/// </summary>
				/// <java-name>
				/// TAG_GPS_LATITUDE
				/// </java-name>
				[Dot42.DexImport("TAG_GPS_LATITUDE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string TAG_GPS_LATITUDE = "GPSLatitude";
				/// <summary>
				///  <para>String. Format is "num1/denom1,num2/denom2,num3/denom3". </para>        
				/// </summary>
				/// <java-name>
				/// TAG_GPS_LONGITUDE
				/// </java-name>
				[Dot42.DexImport("TAG_GPS_LONGITUDE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string TAG_GPS_LONGITUDE = "GPSLongitude";
				/// <summary>
				///  <para>Type is String. </para>        
				/// </summary>
				/// <java-name>
				/// TAG_GPS_LATITUDE_REF
				/// </java-name>
				[Dot42.DexImport("TAG_GPS_LATITUDE_REF", "Ljava/lang/String;", AccessFlags = 25)]
				public const string TAG_GPS_LATITUDE_REF = "GPSLatitudeRef";
				/// <summary>
				///  <para>Type is String. </para>        
				/// </summary>
				/// <java-name>
				/// TAG_GPS_LONGITUDE_REF
				/// </java-name>
				[Dot42.DexImport("TAG_GPS_LONGITUDE_REF", "Ljava/lang/String;", AccessFlags = 25)]
				public const string TAG_GPS_LONGITUDE_REF = "GPSLongitudeRef";
				/// <summary>
				///  <para>The altitude (in meters) based on the reference in TAG_GPS_ALTITUDE_REF. Type is rational. </para>        
				/// </summary>
				/// <java-name>
				/// TAG_GPS_ALTITUDE
				/// </java-name>
				[Dot42.DexImport("TAG_GPS_ALTITUDE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string TAG_GPS_ALTITUDE = "GPSAltitude";
				/// <summary>
				///  <para>0 if the altitude is above sea level. 1 if the altitude is below sea level. Type is int. </para>        
				/// </summary>
				/// <java-name>
				/// TAG_GPS_ALTITUDE_REF
				/// </java-name>
				[Dot42.DexImport("TAG_GPS_ALTITUDE_REF", "Ljava/lang/String;", AccessFlags = 25)]
				public const string TAG_GPS_ALTITUDE_REF = "GPSAltitudeRef";
				/// <summary>
				///  <para>Type is String. </para>        
				/// </summary>
				/// <java-name>
				/// TAG_GPS_TIMESTAMP
				/// </java-name>
				[Dot42.DexImport("TAG_GPS_TIMESTAMP", "Ljava/lang/String;", AccessFlags = 25)]
				public const string TAG_GPS_TIMESTAMP = "GPSTimeStamp";
				/// <summary>
				///  <para>Type is String. </para>        
				/// </summary>
				/// <java-name>
				/// TAG_GPS_DATESTAMP
				/// </java-name>
				[Dot42.DexImport("TAG_GPS_DATESTAMP", "Ljava/lang/String;", AccessFlags = 25)]
				public const string TAG_GPS_DATESTAMP = "GPSDateStamp";
				/// <summary>
				///  <para>Type is int. </para>        
				/// </summary>
				/// <java-name>
				/// TAG_WHITE_BALANCE
				/// </java-name>
				[Dot42.DexImport("TAG_WHITE_BALANCE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string TAG_WHITE_BALANCE = "WhiteBalance";
				/// <summary>
				///  <para>Type is rational. </para>        
				/// </summary>
				/// <java-name>
				/// TAG_FOCAL_LENGTH
				/// </java-name>
				[Dot42.DexImport("TAG_FOCAL_LENGTH", "Ljava/lang/String;", AccessFlags = 25)]
				public const string TAG_FOCAL_LENGTH = "FocalLength";
				/// <summary>
				///  <para>Type is String. Name of GPS processing method used for location finding. </para>        
				/// </summary>
				/// <java-name>
				/// TAG_GPS_PROCESSING_METHOD
				/// </java-name>
				[Dot42.DexImport("TAG_GPS_PROCESSING_METHOD", "Ljava/lang/String;", AccessFlags = 25)]
				public const string TAG_GPS_PROCESSING_METHOD = "GPSProcessingMethod";
				/// <java-name>
				/// ORIENTATION_UNDEFINED
				/// </java-name>
				[Dot42.DexImport("ORIENTATION_UNDEFINED", "I", AccessFlags = 25)]
				public const int ORIENTATION_UNDEFINED = 0;
				/// <java-name>
				/// ORIENTATION_NORMAL
				/// </java-name>
				[Dot42.DexImport("ORIENTATION_NORMAL", "I", AccessFlags = 25)]
				public const int ORIENTATION_NORMAL = 1;
				/// <java-name>
				/// ORIENTATION_FLIP_HORIZONTAL
				/// </java-name>
				[Dot42.DexImport("ORIENTATION_FLIP_HORIZONTAL", "I", AccessFlags = 25)]
				public const int ORIENTATION_FLIP_HORIZONTAL = 2;
				/// <java-name>
				/// ORIENTATION_ROTATE_180
				/// </java-name>
				[Dot42.DexImport("ORIENTATION_ROTATE_180", "I", AccessFlags = 25)]
				public const int ORIENTATION_ROTATE_180 = 3;
				/// <java-name>
				/// ORIENTATION_FLIP_VERTICAL
				/// </java-name>
				[Dot42.DexImport("ORIENTATION_FLIP_VERTICAL", "I", AccessFlags = 25)]
				public const int ORIENTATION_FLIP_VERTICAL = 4;
				/// <java-name>
				/// ORIENTATION_TRANSPOSE
				/// </java-name>
				[Dot42.DexImport("ORIENTATION_TRANSPOSE", "I", AccessFlags = 25)]
				public const int ORIENTATION_TRANSPOSE = 5;
				/// <java-name>
				/// ORIENTATION_ROTATE_90
				/// </java-name>
				[Dot42.DexImport("ORIENTATION_ROTATE_90", "I", AccessFlags = 25)]
				public const int ORIENTATION_ROTATE_90 = 6;
				/// <java-name>
				/// ORIENTATION_TRANSVERSE
				/// </java-name>
				[Dot42.DexImport("ORIENTATION_TRANSVERSE", "I", AccessFlags = 25)]
				public const int ORIENTATION_TRANSVERSE = 7;
				/// <java-name>
				/// ORIENTATION_ROTATE_270
				/// </java-name>
				[Dot42.DexImport("ORIENTATION_ROTATE_270", "I", AccessFlags = 25)]
				public const int ORIENTATION_ROTATE_270 = 8;
				/// <java-name>
				/// WHITEBALANCE_AUTO
				/// </java-name>
				[Dot42.DexImport("WHITEBALANCE_AUTO", "I", AccessFlags = 25)]
				public const int WHITEBALANCE_AUTO = 0;
				/// <java-name>
				/// WHITEBALANCE_MANUAL
				/// </java-name>
				[Dot42.DexImport("WHITEBALANCE_MANUAL", "I", AccessFlags = 25)]
				public const int WHITEBALANCE_MANUAL = 1;
				/// <summary>
				///  <para>Reads Exif tags from the specified JPEG file. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public ExifInterface(string filename) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns the value of the specified tag or <c>null </c> if there is no such tag in the JPEG file.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// getAttribute
				/// </java-name>
				[Dot42.DexImport("getAttribute", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetAttribute(string tag) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Returns the integer value of the specified tag. If there is no such tag in the JPEG file or the value cannot be parsed as integer, return  <b>defaultValue</b>.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// getAttributeInt
				/// </java-name>
				[Dot42.DexImport("getAttributeInt", "(Ljava/lang/String;I)I", AccessFlags = 1)]
				public virtual int GetAttributeInt(string tag, int defaultValue) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Returns the double value of the specified rational tag. If there is no such tag in the JPEG file or the value cannot be parsed as double, return  <b>defaultValue</b>.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// getAttributeDouble
				/// </java-name>
				[Dot42.DexImport("getAttributeDouble", "(Ljava/lang/String;D)D", AccessFlags = 1)]
				public virtual double GetAttributeDouble(string tag, double defaultValue) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <summary>
				///  <para>Set the value of the specified tag.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setAttribute
				/// </java-name>
				[Dot42.DexImport("setAttribute", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetAttribute(string tag, string value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Save the tag data into the JPEG file. This is expensive because it involves copying all the JPG data from one file to another and deleting the old file and renaming the other. It's best to use setAttribute(String,String) to set all attributes to write and make a single call rather than multiple calls for each attribute. </para>        
				/// </summary>
				/// <java-name>
				/// saveAttributes
				/// </java-name>
				[Dot42.DexImport("saveAttributes", "()V", AccessFlags = 1)]
				public virtual void SaveAttributes() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns the thumbnail inside the JPEG file, or <c>null </c> if there is no thumbnail. The returned data is in JPEG format and can be decoded using android.graphics.BitmapFactory#decodeByteArray(byte[],int,int) </para>        
				/// </summary>
				/// <java-name>
				/// getThumbnail
				/// </java-name>
				[Dot42.DexImport("getThumbnail", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual sbyte[] JavaGetThumbnail() /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <summary>
				///  <para>Stores the latitude and longitude value in a float array. The first element is the latitude, and the second element is the longitude. Returns false if the Exif tags are not available. </para>        
				/// </summary>
				/// <java-name>
				/// getLatLong
				/// </java-name>
				[Dot42.DexImport("getLatLong", "([F)Z", AccessFlags = 1)]
				public virtual bool GetLatLong(float[] output) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Return the altitude in meters. If the exif tag does not exist, return  <b>defaultValue</b>.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// getAltitude
				/// </java-name>
				[Dot42.DexImport("getAltitude", "(D)D", AccessFlags = 1)]
				public virtual double GetAltitude(double defaultValue) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal ExifInterface() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Returns true if the JPEG file has a thumbnail. </para>        
				/// </summary>
				/// <java-name>
				/// hasThumbnail
				/// </java-name>
				public virtual bool HasThumbnail
				{
						[Dot42.DexImport("hasThumbnail", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Returns the thumbnail inside the JPEG file, or <c>null </c> if there is no thumbnail. The returned data is in JPEG format and can be decoded using android.graphics.BitmapFactory#decodeByteArray(byte[],int,int) </para>        
				/// </summary>
				/// <java-name>
				/// getThumbnail
				/// </java-name>
				public virtual byte[] Thumbnail
				{
						[Dot42.DexImport("getThumbnail", "()[B", AccessFlags = 1)]
						get{ return default(byte[]); }
				}

		}

		/// <summary>
		///  <para>Identifies the faces of people in a android.graphics.Bitmap graphic object. </para>    
		/// </summary>
		/// <java-name>
		/// android/media/FaceDetector
		/// </java-name>
		[Dot42.DexImport("android/media/FaceDetector", AccessFlags = 33)]
		public partial class FaceDetector
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Creates a FaceDetector, configured with the size of the images to be analysed and the maximum number of faces that can be detected. These parameters cannot be changed once the object is constructed. Note that the width of the image must be even.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(III)V", AccessFlags = 1)]
				public FaceDetector(int width, int height, int maxFaces) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Finds all the faces found in a given android.graphics.Bitmap. The supplied array is populated with FaceDetector.Faces for each face found. The bitmap must be in 565 format (for now).</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the number of faces found </para>
				/// </returns>
				/// <java-name>
				/// findFaces
				/// </java-name>
				[Dot42.DexImport("findFaces", "(Landroid/graphics/Bitmap;[Landroid/media/FaceDetector$Face;)I", AccessFlags = 1)]
				public virtual int FindFaces(global::Android.Graphics.Bitmap bitmap, global::Android.Media.FaceDetector.Face[] faces) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// finalize
				/// </java-name>
				[Dot42.DexImport("finalize", "()V", AccessFlags = 4)]
				extern ~FaceDetector() /* MethodBuilder.Create */ ;

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal FaceDetector() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>A Face contains all the information identifying the location of a face in a bitmap. </para>    
				/// </summary>
				/// <java-name>
				/// android/media/FaceDetector$Face
				/// </java-name>
				[Dot42.DexImport("android/media/FaceDetector$Face", AccessFlags = 1)]
				public partial class Face
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>The minimum confidence factor of good face recognition </para>        
						/// </summary>
						/// <java-name>
						/// CONFIDENCE_THRESHOLD
						/// </java-name>
						[Dot42.DexImport("CONFIDENCE_THRESHOLD", "F", AccessFlags = 25)]
						public const float CONFIDENCE_THRESHOLD = 0.4F;
						/// <summary>
						///  <para>The x-axis Euler angle of a face. </para>        
						/// </summary>
						/// <java-name>
						/// EULER_X
						/// </java-name>
						[Dot42.DexImport("EULER_X", "I", AccessFlags = 25)]
						public const int EULER_X = 0;
						/// <summary>
						///  <para>The y-axis Euler angle of a face. </para>        
						/// </summary>
						/// <java-name>
						/// EULER_Y
						/// </java-name>
						[Dot42.DexImport("EULER_Y", "I", AccessFlags = 25)]
						public const int EULER_Y = 1;
						/// <summary>
						///  <para>The z-axis Euler angle of a face. </para>        
						/// </summary>
						/// <java-name>
						/// EULER_Z
						/// </java-name>
						[Dot42.DexImport("EULER_Z", "I", AccessFlags = 25)]
						public const int EULER_Z = 2;
						/// <java-name>
						/// this$0
						/// </java-name>
						[Dot42.DexImport("this$0", "Landroid/media/FaceDetector;", AccessFlags = 4112)]
						internal readonly global::Android.Media.FaceDetector This_0;
						[Dot42.DexImport("<init>", "(Landroid/media/FaceDetector;)V", AccessFlags = 0)]
						internal Face(global::Android.Media.FaceDetector faceDetector) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Returns a confidence factor between 0 and 1. This indicates how certain what has been found is actually a face. A confidence factor above 0.3 is usually good enough. </para>        
						/// </summary>
						/// <java-name>
						/// confidence
						/// </java-name>
						[Dot42.DexImport("confidence", "()F", AccessFlags = 1)]
						public virtual float Confidence() /* MethodBuilder.Create */ 
						{
								return default(float);
						}

						/// <summary>
						///  <para>Sets the position of the mid-point between the eyes. </para>        
						/// </summary>
						/// <java-name>
						/// getMidPoint
						/// </java-name>
						[Dot42.DexImport("getMidPoint", "(Landroid/graphics/PointF;)V", AccessFlags = 1)]
						public virtual void GetMidPoint(global::Android.Graphics.PointF point) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Returns the distance between the eyes. </para>        
						/// </summary>
						/// <java-name>
						/// eyesDistance
						/// </java-name>
						[Dot42.DexImport("eyesDistance", "()F", AccessFlags = 1)]
						public virtual float EyesDistance() /* MethodBuilder.Create */ 
						{
								return default(float);
						}

						/// <summary>
						///  <para>Returns the face's pose. That is, the rotations around either the X, Y or Z axis (the positions in 3-dimensional Euclidean space).</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>the Euler angle of the of the face, for the given axis </para>
						/// </returns>
						/// <java-name>
						/// pose
						/// </java-name>
						[Dot42.DexImport("pose", "(I)F", AccessFlags = 1)]
						public virtual float Pose(int euler) /* MethodBuilder.Create */ 
						{
								return default(float);
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						protected internal Face() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

				}

		}

		/// <summary>
		///  <para>JetPlayer provides access to JET content playback and control.</para> <para>Please refer to the JET Creator User Manual for a presentation of the JET interactive music concept and how to use the JetCreator tool to create content to be player by JetPlayer.</para> <para>Use of the JetPlayer class is based around the playback of a number of JET segments sequentially added to a playback FIFO queue. The rendering of the MIDI content stored in each segment can be dynamically affected by two mechanisms:  <ul> <li> <para>tracks in a segment can be muted or unmuted at any moment, individually or through a mask (to change the mute state of multiple tracks at once) </para></li> <li> <para>parts of tracks in a segment can be played at predefined points in the segment, in order to maintain synchronization with the other tracks in the segment. This is achieved through the notion of "clips", which can be triggered at any time, but that will play only at the right time, as authored in the corresponding JET file. </para></li></ul>As a result of the rendering and playback of the JET segments, the user of the JetPlayer instance can receive notifications from the JET engine relative to:  <ul> <li> <para>the playback state, </para></li> <li> <para>the number of segments left to play in the queue, </para></li> <li> <para>application controller events (CC80-83) to mark points in the MIDI segments. </para></li></ul>Use getJetPlayer() to construct a JetPlayer instance. JetPlayer is a singleton class. </para> <para>  <h3>Developer Guides</h3></para> <para> </para> <para>For more information about how to use JetPlayer, read the  developer guide.</para> <para> </para>    
		/// </summary>
		/// <java-name>
		/// android/media/JetPlayer
		/// </java-name>
		[Dot42.DexImport("android/media/JetPlayer", AccessFlags = 33)]
		public partial class JetPlayer
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal JetPlayer() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Factory method for the JetPlayer class. </para>        
				/// </summary>
				/// <returns>
				///  <para>the singleton JetPlayer instance </para>
				/// </returns>
				/// <java-name>
				/// getJetPlayer
				/// </java-name>
				[Dot42.DexImport("getJetPlayer", "()Landroid/media/JetPlayer;", AccessFlags = 9)]
				public static global::Android.Media.JetPlayer GetJetPlayer() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Media.JetPlayer);
				}

				/// <summary>
				///  <para>Cloning a JetPlayer instance is not supported. Calling clone() will generate an exception. </para>        
				/// </summary>
				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/lang/Object;", AccessFlags = 1)]
				public virtual object Clone() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <java-name>
				/// finalize
				/// </java-name>
				[Dot42.DexImport("finalize", "()V", AccessFlags = 4)]
				extern ~JetPlayer() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Stops the current JET playback, and releases all associated native resources. The object can no longer be used and the reference should be set to null after a call to release(). </para>        
				/// </summary>
				/// <java-name>
				/// release
				/// </java-name>
				[Dot42.DexImport("release", "()V", AccessFlags = 1)]
				public virtual void Release() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Loads a .jet file from an asset file descriptor. </para>        
				/// </summary>
				/// <returns>
				///  <para>true if loading the .jet file was successful, false if loading failed. </para>
				/// </returns>
				/// <java-name>
				/// loadJetFile
				/// </java-name>
				[Dot42.DexImport("loadJetFile", "(Ljava/lang/String;)Z", AccessFlags = 1)]
				public virtual bool LoadJetFile(string afd) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Loads a .jet file from an asset file descriptor. </para>        
				/// </summary>
				/// <returns>
				///  <para>true if loading the .jet file was successful, false if loading failed. </para>
				/// </returns>
				/// <java-name>
				/// loadJetFile
				/// </java-name>
				[Dot42.DexImport("loadJetFile", "(Landroid/content/res/AssetFileDescriptor;)Z", AccessFlags = 1)]
				public virtual bool LoadJetFile(global::Android.Content.Res.AssetFileDescriptor afd) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Closes the resource containing the JET content. </para>        
				/// </summary>
				/// <returns>
				///  <para>true if successfully closed, false otherwise. </para>
				/// </returns>
				/// <java-name>
				/// closeJetFile
				/// </java-name>
				[Dot42.DexImport("closeJetFile", "()Z", AccessFlags = 1)]
				public virtual bool CloseJetFile() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Starts playing the JET segment queue. </para>        
				/// </summary>
				/// <returns>
				///  <para>true if rendering and playback is successfully started, false otherwise. </para>
				/// </returns>
				/// <java-name>
				/// play
				/// </java-name>
				[Dot42.DexImport("play", "()Z", AccessFlags = 1)]
				public virtual bool Play() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Pauses the playback of the JET segment queue. </para>        
				/// </summary>
				/// <returns>
				///  <para>true if rendering and playback is successfully paused, false otherwise. </para>
				/// </returns>
				/// <java-name>
				/// pause
				/// </java-name>
				[Dot42.DexImport("pause", "()Z", AccessFlags = 1)]
				public virtual bool Pause() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Queues the specified segment in the JET queue. </para>        
				/// </summary>
				/// <returns>
				///  <para>true if the segment was successfully queued, false if the queue is full or if the parameters are invalid. </para>
				/// </returns>
				/// <java-name>
				/// queueJetSegment
				/// </java-name>
				[Dot42.DexImport("queueJetSegment", "(IIIIIB)Z", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual bool QueueJetSegment(int segmentNum, int libNum, int repeatCount, int transpose, int muteFlags, sbyte userID) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Queues the specified segment in the JET queue. </para>        
				/// </summary>
				/// <returns>
				///  <para>true if the segment was successfully queued, false if the queue is full or if the parameters are invalid. </para>
				/// </returns>
				/// <java-name>
				/// queueJetSegment
				/// </java-name>
				[Dot42.DexImport("queueJetSegment", "(IIIIIB)Z", AccessFlags = 1)]
				public virtual bool QueueJetSegment(int segmentNum, int libNum, int repeatCount, int transpose, int muteFlags, byte userID) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Queues the specified segment in the JET queue. </para>        
				/// </summary>
				/// <returns>
				///  <para>true if the segment was successfully queued, false if the queue is full or if the parameters are invalid. </para>
				/// </returns>
				/// <java-name>
				/// queueJetSegmentMuteArray
				/// </java-name>
				[Dot42.DexImport("queueJetSegmentMuteArray", "(IIII[ZB)Z", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual bool QueueJetSegmentMuteArray(int segmentNum, int libNum, int repeatCount, int transpose, bool[] muteArray, sbyte userID) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Queues the specified segment in the JET queue. </para>        
				/// </summary>
				/// <returns>
				///  <para>true if the segment was successfully queued, false if the queue is full or if the parameters are invalid. </para>
				/// </returns>
				/// <java-name>
				/// queueJetSegmentMuteArray
				/// </java-name>
				[Dot42.DexImport("queueJetSegmentMuteArray", "(IIII[ZB)Z", AccessFlags = 1)]
				public virtual bool QueueJetSegmentMuteArray(int segmentNum, int libNum, int repeatCount, int transpose, bool[] muteArray, byte userID) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Modifies the mute flags. </para>        
				/// </summary>
				/// <returns>
				///  <para>true if the mute flags were successfully updated, false otherwise. </para>
				/// </returns>
				/// <java-name>
				/// setMuteFlags
				/// </java-name>
				[Dot42.DexImport("setMuteFlags", "(IZ)Z", AccessFlags = 1)]
				public virtual bool SetMuteFlags(int muteFlags, bool sync) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Modifies the mute flags for the current active segment. </para>        
				/// </summary>
				/// <returns>
				///  <para>true if the mute flags were successfully updated, false otherwise. </para>
				/// </returns>
				/// <java-name>
				/// setMuteArray
				/// </java-name>
				[Dot42.DexImport("setMuteArray", "([ZZ)Z", AccessFlags = 1)]
				public virtual bool SetMuteArray(bool[] muteArray, bool sync) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Mutes or unmutes a single track. </para>        
				/// </summary>
				/// <returns>
				///  <para>true if the mute flag was successfully updated, false otherwise. </para>
				/// </returns>
				/// <java-name>
				/// setMuteFlag
				/// </java-name>
				[Dot42.DexImport("setMuteFlag", "(IZZ)Z", AccessFlags = 1)]
				public virtual bool SetMuteFlag(int trackId, bool muteFlag, bool sync) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Schedules the playback of a clip. This will automatically update the mute flags in sync with the JET Clip Marker (controller 103). The parameter clipID must be in the range of 0-63. After the call to triggerClip, when JET next encounters a controller event 103 with bits 0-5 of the value equal to clipID and bit 6 set to 1, it will automatically unmute the track containing the controller event. When JET encounters the complementary controller event 103 with bits 0-5 of the value equal to clipID and bit 6 set to 0, it will mute the track again. </para>        
				/// </summary>
				/// <returns>
				///  <para>true if the clip was successfully triggered, false otherwise. </para>
				/// </returns>
				/// <java-name>
				/// triggerClip
				/// </java-name>
				[Dot42.DexImport("triggerClip", "(I)Z", AccessFlags = 1)]
				public virtual bool TriggerClip(int clipId) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Empties the segment queue, and clears all clips that are scheduled for playback. </para>        
				/// </summary>
				/// <returns>
				///  <para>true if the queue was successfully cleared, false otherwise. </para>
				/// </returns>
				/// <java-name>
				/// clearQueue
				/// </java-name>
				[Dot42.DexImport("clearQueue", "()Z", AccessFlags = 1)]
				public virtual bool ClearQueue() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Sets the listener JetPlayer notifies when a JET event is generated by the rendering and playback engine. Notifications will be received in the same thread as the one in which the JetPlayer instance was created. </para>        
				/// </summary>
				/// <java-name>
				/// setEventListener
				/// </java-name>
				[Dot42.DexImport("setEventListener", "(Landroid/media/JetPlayer$OnJetEventListener;)V", AccessFlags = 1)]
				public virtual void SetEventListener(global::Android.Media.JetPlayer.IOnJetEventListener listener) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the listener JetPlayer notifies when a JET event is generated by the rendering and playback engine. Use this method to receive JET events in the Handler associated with another thread than the one in which you created the JetPlayer instance. </para>        
				/// </summary>
				/// <java-name>
				/// setEventListener
				/// </java-name>
				[Dot42.DexImport("setEventListener", "(Landroid/media/JetPlayer$OnJetEventListener;Landroid/os/Handler;)V", AccessFlags = 1)]
				public virtual void SetEventListener(global::Android.Media.JetPlayer.IOnJetEventListener listener, global::Android.OS.Handler handler) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns the maximum number of simultaneous MIDI tracks supported by JetPlayer </para>        
				/// </summary>
				/// <java-name>
				/// getMaxTracks
				/// </java-name>
				public static int MaxTracks
				{
						[Dot42.DexImport("getMaxTracks", "()I", AccessFlags = 9)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Handles the notification when the JET engine generates an event. </para>    
				/// </summary>
				/// <java-name>
				/// android/media/JetPlayer$OnJetEventListener
				/// </java-name>
				[Dot42.DexImport("android/media/JetPlayer$OnJetEventListener", AccessFlags = 1545)]
				public partial interface IOnJetEventListener
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>Callback for when the JET engine generates a new event.</para> <para></para>        
						/// </summary>
						/// <java-name>
						/// onJetEvent
						/// </java-name>
						[Dot42.DexImport("onJetEvent", "(Landroid/media/JetPlayer;SBBBB)V", AccessFlags = 1025)]
						void OnJetEvent(global::Android.Media.JetPlayer player, short segment, byte track, byte channel, byte controller, byte value) /* MethodBuilder.Create */ ;

						/// <summary>
						///  <para>Callback for when JET's currently playing segment's userID is updated.</para> <para></para>        
						/// </summary>
						/// <java-name>
						/// onJetUserIdUpdate
						/// </java-name>
						[Dot42.DexImport("onJetUserIdUpdate", "(Landroid/media/JetPlayer;II)V", AccessFlags = 1025)]
						void OnJetUserIdUpdate(global::Android.Media.JetPlayer player, int userId, int repeatCount) /* MethodBuilder.Create */ ;

						/// <summary>
						///  <para>Callback for when JET's number of queued segments is updated.</para> <para></para>        
						/// </summary>
						/// <java-name>
						/// onJetNumQueuedSegmentUpdate
						/// </java-name>
						[Dot42.DexImport("onJetNumQueuedSegmentUpdate", "(Landroid/media/JetPlayer;I)V", AccessFlags = 1025)]
						void OnJetNumQueuedSegmentUpdate(global::Android.Media.JetPlayer player, int nbSegments) /* MethodBuilder.Create */ ;

						/// <summary>
						///  <para>Callback for when JET pause state is updated.</para> <para></para>        
						/// </summary>
						/// <java-name>
						/// onJetPauseUpdate
						/// </java-name>
						[Dot42.DexImport("onJetPauseUpdate", "(Landroid/media/JetPlayer;I)V", AccessFlags = 1025)]
						void OnJetPauseUpdate(global::Android.Media.JetPlayer player, int paused) /* MethodBuilder.Create */ ;

				}

		}

		/// <summary>
		///  <para>MediaMetadataRetriever class provides a unified interface for retrieving frame and meta data from an input media file. </para>    
		/// </summary>
		/// <java-name>
		/// android/media/MediaMetadataRetriever
		/// </java-name>
		[Dot42.DexImport("android/media/MediaMetadataRetriever", AccessFlags = 33)]
		public partial class MediaMetadataRetriever
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Option used in method getFrameAtTime(long, int) to get a frame at a specified location.</para> <para> <para>getFrameAtTime(long, int) This option is used with getFrameAtTime(long, int) to retrieve a sync (or key) frame associated with a data source that is located right before or at the given time.</para> <para>getFrameAtTime(long, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// OPTION_PREVIOUS_SYNC
				/// </java-name>
				[Dot42.DexImport("OPTION_PREVIOUS_SYNC", "I", AccessFlags = 25)]
				public const int OPTION_PREVIOUS_SYNC = 0;
				/// <summary>
				///  <para>This option is used with getFrameAtTime(long, int) to retrieve a sync (or key) frame associated with a data source that is located right after or at the given time.</para> <para> <para>getFrameAtTime(long, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// OPTION_NEXT_SYNC
				/// </java-name>
				[Dot42.DexImport("OPTION_NEXT_SYNC", "I", AccessFlags = 25)]
				public const int OPTION_NEXT_SYNC = 1;
				/// <summary>
				///  <para>This option is used with getFrameAtTime(long, int) to retrieve a sync (or key) frame associated with a data source that is located closest to (in time) or at the given time.</para> <para> <para>getFrameAtTime(long, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// OPTION_CLOSEST_SYNC
				/// </java-name>
				[Dot42.DexImport("OPTION_CLOSEST_SYNC", "I", AccessFlags = 25)]
				public const int OPTION_CLOSEST_SYNC = 2;
				/// <summary>
				///  <para>This option is used with getFrameAtTime(long, int) to retrieve a frame (not necessarily a key frame) associated with a data source that is located closest to or at the given time.</para> <para> <para>getFrameAtTime(long, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// OPTION_CLOSEST
				/// </java-name>
				[Dot42.DexImport("OPTION_CLOSEST", "I", AccessFlags = 25)]
				public const int OPTION_CLOSEST = 3;
				/// <summary>
				///  <para>The metadata key to retrieve the numeric string describing the order of the audio data source on its original recording. </para>        
				/// </summary>
				/// <java-name>
				/// METADATA_KEY_CD_TRACK_NUMBER
				/// </java-name>
				[Dot42.DexImport("METADATA_KEY_CD_TRACK_NUMBER", "I", AccessFlags = 25)]
				public const int METADATA_KEY_CD_TRACK_NUMBER = 0;
				/// <summary>
				///  <para>The metadata key to retrieve the information about the album title of the data source. </para>        
				/// </summary>
				/// <java-name>
				/// METADATA_KEY_ALBUM
				/// </java-name>
				[Dot42.DexImport("METADATA_KEY_ALBUM", "I", AccessFlags = 25)]
				public const int METADATA_KEY_ALBUM = 1;
				/// <summary>
				///  <para>The metadata key to retrieve the information about the artist of the data source. </para>        
				/// </summary>
				/// <java-name>
				/// METADATA_KEY_ARTIST
				/// </java-name>
				[Dot42.DexImport("METADATA_KEY_ARTIST", "I", AccessFlags = 25)]
				public const int METADATA_KEY_ARTIST = 2;
				/// <summary>
				///  <para>The metadata key to retrieve the information about the author of the data source. </para>        
				/// </summary>
				/// <java-name>
				/// METADATA_KEY_AUTHOR
				/// </java-name>
				[Dot42.DexImport("METADATA_KEY_AUTHOR", "I", AccessFlags = 25)]
				public const int METADATA_KEY_AUTHOR = 3;
				/// <summary>
				///  <para>The metadata key to retrieve the information about the composer of the data source. </para>        
				/// </summary>
				/// <java-name>
				/// METADATA_KEY_COMPOSER
				/// </java-name>
				[Dot42.DexImport("METADATA_KEY_COMPOSER", "I", AccessFlags = 25)]
				public const int METADATA_KEY_COMPOSER = 4;
				/// <summary>
				///  <para>The metadata key to retrieve the date when the data source was created or modified. </para>        
				/// </summary>
				/// <java-name>
				/// METADATA_KEY_DATE
				/// </java-name>
				[Dot42.DexImport("METADATA_KEY_DATE", "I", AccessFlags = 25)]
				public const int METADATA_KEY_DATE = 5;
				/// <summary>
				///  <para>The metadata key to retrieve the content type or genre of the data source. </para>        
				/// </summary>
				/// <java-name>
				/// METADATA_KEY_GENRE
				/// </java-name>
				[Dot42.DexImport("METADATA_KEY_GENRE", "I", AccessFlags = 25)]
				public const int METADATA_KEY_GENRE = 6;
				/// <summary>
				///  <para>The metadata key to retrieve the data source title. </para>        
				/// </summary>
				/// <java-name>
				/// METADATA_KEY_TITLE
				/// </java-name>
				[Dot42.DexImport("METADATA_KEY_TITLE", "I", AccessFlags = 25)]
				public const int METADATA_KEY_TITLE = 7;
				/// <summary>
				///  <para>The metadata key to retrieve the year when the data source was created or modified. </para>        
				/// </summary>
				/// <java-name>
				/// METADATA_KEY_YEAR
				/// </java-name>
				[Dot42.DexImport("METADATA_KEY_YEAR", "I", AccessFlags = 25)]
				public const int METADATA_KEY_YEAR = 8;
				/// <summary>
				///  <para>The metadata key to retrieve the playback duration of the data source. </para>        
				/// </summary>
				/// <java-name>
				/// METADATA_KEY_DURATION
				/// </java-name>
				[Dot42.DexImport("METADATA_KEY_DURATION", "I", AccessFlags = 25)]
				public const int METADATA_KEY_DURATION = 9;
				/// <summary>
				///  <para>The metadata key to retrieve the number of tracks, such as audio, video, text, in the data source, such as a mp4 or 3gpp file. </para>        
				/// </summary>
				/// <java-name>
				/// METADATA_KEY_NUM_TRACKS
				/// </java-name>
				[Dot42.DexImport("METADATA_KEY_NUM_TRACKS", "I", AccessFlags = 25)]
				public const int METADATA_KEY_NUM_TRACKS = 10;
				/// <summary>
				///  <para>The metadata key to retrieve the information of the writer (such as lyricist) of the data source. </para>        
				/// </summary>
				/// <java-name>
				/// METADATA_KEY_WRITER
				/// </java-name>
				[Dot42.DexImport("METADATA_KEY_WRITER", "I", AccessFlags = 25)]
				public const int METADATA_KEY_WRITER = 11;
				/// <summary>
				///  <para>The metadata key to retrieve the mime type of the data source. Some example mime types include: "video/mp4", "audio/mp4", "audio/amr-wb", etc. </para>        
				/// </summary>
				/// <java-name>
				/// METADATA_KEY_MIMETYPE
				/// </java-name>
				[Dot42.DexImport("METADATA_KEY_MIMETYPE", "I", AccessFlags = 25)]
				public const int METADATA_KEY_MIMETYPE = 12;
				/// <summary>
				///  <para>The metadata key to retrieve the information about the performers or artist associated with the data source. </para>        
				/// </summary>
				/// <java-name>
				/// METADATA_KEY_ALBUMARTIST
				/// </java-name>
				[Dot42.DexImport("METADATA_KEY_ALBUMARTIST", "I", AccessFlags = 25)]
				public const int METADATA_KEY_ALBUMARTIST = 13;
				/// <summary>
				///  <para>The metadata key to retrieve the numberic string that describes which part of a set the audio data source comes from. </para>        
				/// </summary>
				/// <java-name>
				/// METADATA_KEY_DISC_NUMBER
				/// </java-name>
				[Dot42.DexImport("METADATA_KEY_DISC_NUMBER", "I", AccessFlags = 25)]
				public const int METADATA_KEY_DISC_NUMBER = 14;
				/// <summary>
				///  <para>The metadata key to retrieve the music album compilation status. </para>        
				/// </summary>
				/// <java-name>
				/// METADATA_KEY_COMPILATION
				/// </java-name>
				[Dot42.DexImport("METADATA_KEY_COMPILATION", "I", AccessFlags = 25)]
				public const int METADATA_KEY_COMPILATION = 15;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public MediaMetadataRetriever() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the data source (FileDescriptor) to use. It is the caller's responsibility to close the file descriptor. It is safe to do so as soon as this call returns. Call this method before the rest of the methods in this class. This method may be time-consuming.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setDataSource
				/// </java-name>
				[Dot42.DexImport("setDataSource", "(Ljava/lang/String;)V", AccessFlags = 257)]
				public virtual void SetDataSource(string fd) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the data source (FileDescriptor) to use. It is the caller's responsibility to close the file descriptor. It is safe to do so as soon as this call returns. Call this method before the rest of the methods in this class. This method may be time-consuming.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setDataSource
				/// </java-name>
				[Dot42.DexImport("setDataSource", "(Ljava/io/FileDescriptor;JJ)V", AccessFlags = 257)]
				public virtual void SetDataSource(global::Java.IO.FileDescriptor fd, long offset, long length) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the data source (FileDescriptor) to use. It is the caller's responsibility to close the file descriptor. It is safe to do so as soon as this call returns. Call this method before the rest of the methods in this class. This method may be time-consuming.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setDataSource
				/// </java-name>
				[Dot42.DexImport("setDataSource", "(Ljava/io/FileDescriptor;)V", AccessFlags = 1)]
				public virtual void SetDataSource(global::Java.IO.FileDescriptor fd) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the data source as a content Uri. Call this method before the rest of the methods in this class. This method may be time-consuming.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setDataSource
				/// </java-name>
				[Dot42.DexImport("setDataSource", "(Landroid/content/Context;Landroid/net/Uri;)V", AccessFlags = 1)]
				public virtual void SetDataSource(global::Android.Content.Context context, global::Android.Net.Uri uri) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Call this method after setDataSource(). This method retrieves the meta data value associated with the keyCode.</para> <para>The keyCode currently supported is listed below as METADATA_XXX constants. With any other value, it returns a null pointer.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The meta data value associate with the given keyCode on success; null on failure. </para>
				/// </returns>
				/// <java-name>
				/// extractMetadata
				/// </java-name>
				[Dot42.DexImport("extractMetadata", "(I)Ljava/lang/String;", AccessFlags = 257)]
				public virtual string ExtractMetadata(int keyCode) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Call this method after setDataSource(). This method finds a representative frame close to the given time position by considering the given option if possible, and returns it as a bitmap. This is useful for generating a thumbnail for an input data source or just obtain and display a frame at the given time position.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>A Bitmap containing a representative video frame, which can be null, if such a frame cannot be retrieved. </para>
				/// </returns>
				/// <java-name>
				/// getFrameAtTime
				/// </java-name>
				[Dot42.DexImport("getFrameAtTime", "(JI)Landroid/graphics/Bitmap;", AccessFlags = 1)]
				public virtual global::Android.Graphics.Bitmap GetFrameAtTime(long timeUs, int option) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Bitmap);
				}

				/// <summary>
				///  <para>Call this method after setDataSource(). This method finds a representative frame close to the given time position if possible, and returns it as a bitmap. This is useful for generating a thumbnail for an input data source. Call this method if one does not care how the frame is found as long as it is close to the given time; otherwise, please call getFrameAtTime(long, int).</para> <para> <para>getFrameAtTime(long, int) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>A Bitmap containing a representative video frame, which can be null, if such a frame cannot be retrieved.</para>
				/// </returns>
				/// <java-name>
				/// getFrameAtTime
				/// </java-name>
				[Dot42.DexImport("getFrameAtTime", "(J)Landroid/graphics/Bitmap;", AccessFlags = 1)]
				public virtual global::Android.Graphics.Bitmap GetFrameAtTime(long timeUs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Bitmap);
				}

				/// <summary>
				///  <para>Call this method after setDataSource(). This method finds the optional graphic or album/cover art associated associated with the data source. If there are more than one pictures, (any) one of them is returned.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>null if no such graphic is found. </para>
				/// </returns>
				/// <java-name>
				/// getEmbeddedPicture
				/// </java-name>
				[Dot42.DexImport("getEmbeddedPicture", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual sbyte[] JavaGetEmbeddedPicture() /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <summary>
				///  <para>Call it when one is done with the object. This method releases the memory allocated internally. </para>        
				/// </summary>
				/// <java-name>
				/// release
				/// </java-name>
				[Dot42.DexImport("release", "()V", AccessFlags = 257)]
				public virtual void Release() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// finalize
				/// </java-name>
				[Dot42.DexImport("finalize", "()V", AccessFlags = 4)]
				extern ~MediaMetadataRetriever() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Call this method after setDataSource(). This method finds a representative frame at any time position if possible, and returns it as a bitmap. This is useful for generating a thumbnail for an input data source. Call this method if one does not care about where the frame is located; otherwise, please call getFrameAtTime(long) or getFrameAtTime(long, int)</para> <para> <para>getFrameAtTime(long) </para> <para>getFrameAtTime(long, int) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>A Bitmap containing a representative video frame, which can be null, if such a frame cannot be retrieved.</para>
				/// </returns>
				/// <java-name>
				/// getFrameAtTime
				/// </java-name>
				public virtual global::Android.Graphics.Bitmap FrameAtTime
				{
						[Dot42.DexImport("getFrameAtTime", "()Landroid/graphics/Bitmap;", AccessFlags = 1)]
						get{ return default(global::Android.Graphics.Bitmap); }
				}

				/// <summary>
				///  <para>Call this method after setDataSource(). This method finds the optional graphic or album/cover art associated associated with the data source. If there are more than one pictures, (any) one of them is returned.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>null if no such graphic is found. </para>
				/// </returns>
				/// <java-name>
				/// getEmbeddedPicture
				/// </java-name>
				public virtual byte[] EmbeddedPicture
				{
						[Dot42.DexImport("getEmbeddedPicture", "()[B", AccessFlags = 1)]
						get{ return default(byte[]); }
				}

		}

		/// <summary>
		///  <para>MediaPlayer class can be used to control playback of audio/video files and streams. An example on how to use the methods in this class can be found in android.widget.VideoView.</para> <para>Topics covered here are:  <ol> <li> <para> </para></li> <li> <para> </para></li> <li> <para> </para></li> <li> <para> </para></li></ol></para> <para>  <h3>Developer Guides</h3></para> <para> </para> <para>For more information about how to use MediaPlayer, read the  developer guide.</para> <para> </para> <para>  <h3>State Diagram</h3></para> <para>Playback control of audio/video files and streams is managed as a state machine. The following diagram shows the life cycle and the states of a MediaPlayer object driven by the supported playback control operations. The ovals represent the states a MediaPlayer object may reside in. The arcs represent the playback control operations that drive the object state transition. There are two types of arcs. The arcs with a single arrow head represent synchronous method calls, while those with a double arrow head represent asynchronous method calls.</para> <para> <image></image></para> <para>From this state diagram, one can see that a MediaPlayer object has the following states:</para> <para> <ul> <li> <para>When a MediaPlayer object is just created using  <code>new</code> or after reset() is called, it is in the  <b>Idle</b> state; and after release() is called, it is in the  <b>End</b> state. Between these two states is the life cycle of the MediaPlayer object.  <ul> <li> <para>There is a subtle but important difference between a newly constructed MediaPlayer object and the MediaPlayer object after reset() is called. It is a programming error to invoke methods such as getCurrentPosition(), getDuration(), getVideoHeight(), getVideoWidth(), setAudioStreamType(int), setLooping(boolean), setVolume(float, float), pause(), start(), stop(), seekTo(int), prepare() or prepareAsync() in the  <b>Idle</b> state for both cases. If any of these methods is called right after a MediaPlayer object is constructed, the user supplied callback method OnErrorListener.onError() won't be called by the internal player engine and the object state remains unchanged; but if these methods are called right after reset(), the user supplied callback method OnErrorListener.onError() will be invoked by the internal player engine and the object will be transfered to the  <b>Error</b> state.  </para></li> <li> <para>It is also recommended that once a MediaPlayer object is no longer being used, call release() immediately so that resources used by the internal player engine associated with the MediaPlayer object can be released immediately. Resource may include singleton resources such as hardware acceleration components and failure to call release() may cause subsequent instances of MediaPlayer objects to fallback to software implementations or fail altogether. Once the MediaPlayer object is in the  <b>End</b> state, it can no longer be used and there is no way to bring it back to any other state.  </para></li> <li> <para>Furthermore, the MediaPlayer objects created using  <code>new</code> is in the  <b>Idle</b> state, while those created with one of the overloaded convenient  <code>create</code> methods are  <b>NOT</b> in the  <b>Idle</b> state. In fact, the objects are in the  <b>Prepared</b> state if the creation using  <code>create</code> method is successful.  </para></li></ul></para></li> <li> <para>In general, some playback control operation may fail due to various reasons, such as unsupported audio/video format, poorly interleaved audio/video, resolution too high, streaming timeout, and the like. Thus, error reporting and recovery is an important concern under these circumstances. Sometimes, due to programming errors, invoking a playback control operation in an invalid state may also occur. Under all these error conditions, the internal player engine invokes a user supplied OnErrorListener.onError() method if an OnErrorListener has been registered beforehand via setOnErrorListener(android.media.MediaPlayer.OnErrorListener).  <ul> <li> <para>It is important to note that once an error occurs, the MediaPlayer object enters the  <b>Error</b> state (except as noted above), even if an error listener has not been registered by the application. </para></li> <li> <para>In order to reuse a MediaPlayer object that is in the  <b> Error</b> state and recover from the error, reset() can be called to restore the object to its  <b>Idle</b> state. </para></li> <li> <para>It is good programming practice to have your application register a OnErrorListener to look out for error notifications from the internal player engine. </para></li> <li> <para>IllegalStateException is thrown to prevent programming errors such as calling prepare(), prepareAsync(), or one of the overloaded  <code>setDataSource </code> methods in an invalid state.  </para></li></ul></para></li> <li> <para>Calling setDataSource(FileDescriptor), or setDataSource(String), or setDataSource(Context, Uri), or setDataSource(FileDescriptor, long, long) transfers a MediaPlayer object in the  <b>Idle</b> state to the  <b>Initialized</b> state.  <ul> <li> <para>An IllegalStateException is thrown if setDataSource() is called in any other state. </para></li> <li> <para>It is good programming practice to always look out for  <code>IllegalArgumentException</code> and  <code>IOException</code> that may be thrown from the overloaded  <code>setDataSource</code> methods. </para></li></ul></para></li> <li> <para>A MediaPlayer object must first enter the  <b>Prepared</b> state before playback can be started.  <ul> <li> <para>There are two ways (synchronous vs. asynchronous) that the  <b>Prepared</b> state can be reached: either a call to prepare() (synchronous) which transfers the object to the  <b>Prepared</b> state once the method call returns, or a call to prepareAsync() (asynchronous) which first transfers the object to the  <b>Preparing</b> state after the call returns (which occurs almost right way) while the internal player engine continues working on the rest of preparation work until the preparation work completes. When the preparation completes or when prepare() call returns, the internal player engine then calls a user supplied callback method, onPrepared() of the OnPreparedListener interface, if an OnPreparedListener is registered beforehand via setOnPreparedListener(android.media.MediaPlayer.OnPreparedListener). </para></li> <li> <para>It is important to note that the  <b>Preparing</b> state is a transient state, and the behavior of calling any method with side effect while a MediaPlayer object is in the  <b>Preparing</b> state is undefined. </para></li> <li> <para>An IllegalStateException is thrown if prepare() or prepareAsync() is called in any other state. </para></li> <li> <para>While in the  <b>Prepared</b> state, properties such as audio/sound volume, screenOnWhilePlaying, looping can be adjusted by invoking the corresponding set methods. </para></li></ul></para></li> <li> <para>To start the playback, start() must be called. After start() returns successfully, the MediaPlayer object is in the  <b>Started</b> state. isPlaying() can be called to test whether the MediaPlayer object is in the  <b>Started</b> state.  <ul> <li> <para>While in the  <b>Started</b> state, the internal player engine calls a user supplied OnBufferingUpdateListener.onBufferingUpdate() callback method if a OnBufferingUpdateListener has been registered beforehand via setOnBufferingUpdateListener(OnBufferingUpdateListener). This callback allows applications to keep track of the buffering status while streaming audio/video. </para></li> <li> <para>Calling start() has not effect on a MediaPlayer object that is already in the  <b>Started</b> state. </para></li></ul></para></li> <li> <para>Playback can be paused and stopped, and the current playback position can be adjusted. Playback can be paused via pause(). When the call to pause() returns, the MediaPlayer object enters the  <b>Paused</b> state. Note that the transition from the  <b>Started</b> state to the  <b>Paused</b> state and vice versa happens asynchronously in the player engine. It may take some time before the state is updated in calls to isPlaying(), and it can be a number of seconds in the case of streamed content.  <ul> <li> <para>Calling start() to resume playback for a paused MediaPlayer object, and the resumed playback position is the same as where it was paused. When the call to start() returns, the paused MediaPlayer object goes back to the  <b>Started</b> state. </para></li> <li> <para>Calling pause() has no effect on a MediaPlayer object that is already in the  <b>Paused</b> state. </para></li></ul></para></li> <li> <para>Calling stop() stops playback and causes a MediaPlayer in the  <b>Started</b>,  <b>Paused</b>,  <b>Prepared </b> or  <b>PlaybackCompleted</b> state to enter the  <b>Stopped</b> state.  <ul> <li> <para>Once in the  <b>Stopped</b> state, playback cannot be started until prepare() or prepareAsync() are called to set the MediaPlayer object to the  <b>Prepared</b> state again. </para></li> <li> <para>Calling stop() has no effect on a MediaPlayer object that is already in the  <b>Stopped</b> state. </para></li></ul></para></li> <li> <para>The playback position can be adjusted with a call to seekTo(int).  <ul> <li> <para>Although the asynchronuous seekTo(int) call returns right way, the actual seek operation may take a while to finish, especially for audio/video being streamed. When the actual seek operation completes, the internal player engine calls a user supplied OnSeekComplete.onSeekComplete() if an OnSeekCompleteListener has been registered beforehand via setOnSeekCompleteListener(OnSeekCompleteListener). </para></li> <li> <para>Please note that seekTo(int) can also be called in the other states, such as  <b>Prepared</b>,  <b>Paused</b> and  <b>PlaybackCompleted </b> state. </para></li> <li> <para>Furthermore, the actual current playback position can be retrieved with a call to getCurrentPosition(), which is helpful for applications such as a Music player that need to keep track of the playback progress. </para></li></ul></para></li> <li> <para>When the playback reaches the end of stream, the playback completes.  <ul> <li> <para>If the looping mode was being set to  <b>true</b>with setLooping(boolean), the MediaPlayer object shall remain in the  <b>Started</b> state. </para></li> <li> <para>If the looping mode was set to  <b>false </b>, the player engine calls a user supplied callback method, OnCompletion.onCompletion(), if a OnCompletionListener is registered beforehand via setOnCompletionListener(OnCompletionListener). The invoke of the callback signals that the object is now in the  <b> PlaybackCompleted</b> state. </para></li> <li> <para>While in the  <b>PlaybackCompleted</b> state, calling start() can restart the playback from the beginning of the audio/video source. </para></li></ul></para> <para>  <h3>Valid and invalid states</h3></para> <para></para> <para> <table> <row> <entry> <para>Method Name </para> <para></para></entry> <entry> <para>Valid Sates </para> <para></para></entry> <entry> <para>Invalid States </para> <para></para></entry> <entry> <para>Comments </para> <para></para></entry></row> <row> <entry> <para>attachAuxEffect </para> <para></para></entry> <entry> <para>{Initialized, Prepared, Started, Paused, Stopped, PlaybackCompleted} </para> <para></para></entry> <entry> <para>{Idle, Error} </para> <para></para></entry> <entry> <para>This method must be called after setDataSource. Calling it does not change the object state. </para> <para></para></entry></row> <row> <entry> <para>getAudioSessionId </para> <para></para></entry> <entry> <para>any </para> <para></para></entry> <entry> <para>{} </para> <para></para></entry> <entry> <para>This method can be called in any state and calling it does not change the object state. </para> <para></para></entry></row> <row> <entry> <para>getCurrentPosition </para> <para></para></entry> <entry> <para>{Idle, Initialized, Prepared, Started, Paused, Stopped, PlaybackCompleted} </para> <para></para></entry> <entry> <para>{Error}</para> <para></para></entry> <entry> <para>Successful invoke of this method in a valid state does not change the state. Calling this method in an invalid state transfers the object to the  <b>Error</b> state. </para> <para></para></entry></row> <row> <entry> <para>getDuration </para> <para></para></entry> <entry> <para>{Prepared, Started, Paused, Stopped, PlaybackCompleted} </para> <para></para></entry> <entry> <para>{Idle, Initialized, Error} </para> <para></para></entry> <entry> <para>Successful invoke of this method in a valid state does not change the state. Calling this method in an invalid state transfers the object to the  <b>Error</b> state. </para> <para></para></entry></row> <row> <entry> <para>getVideoHeight </para> <para></para></entry> <entry> <para>{Idle, Initialized, Prepared, Started, Paused, Stopped, PlaybackCompleted}</para> <para></para></entry> <entry> <para>{Error}</para> <para></para></entry> <entry> <para>Successful invoke of this method in a valid state does not change the state. Calling this method in an invalid state transfers the object to the  <b>Error</b> state. </para> <para></para></entry></row> <row> <entry> <para>getVideoWidth </para> <para></para></entry> <entry> <para>{Idle, Initialized, Prepared, Started, Paused, Stopped, PlaybackCompleted}</para> <para></para></entry> <entry> <para>{Error}</para> <para></para></entry> <entry> <para>Successful invoke of this method in a valid state does not change the state. Calling this method in an invalid state transfers the object to the  <b>Error</b> state. </para> <para></para></entry></row> <row> <entry> <para>isPlaying </para> <para></para></entry> <entry> <para>{Idle, Initialized, Prepared, Started, Paused, Stopped, PlaybackCompleted}</para> <para></para></entry> <entry> <para>{Error}</para> <para></para></entry> <entry> <para>Successful invoke of this method in a valid state does not change the state. Calling this method in an invalid state transfers the object to the  <b>Error</b> state. </para> <para></para></entry></row> <row> <entry> <para>pause </para> <para></para></entry> <entry> <para>{Started, Paused, PlaybackCompleted}</para> <para></para></entry> <entry> <para>{Idle, Initialized, Prepared, Stopped, Error}</para> <para></para></entry> <entry> <para>Successful invoke of this method in a valid state transfers the object to the  <b>Paused</b> state. Calling this method in an invalid state transfers the object to the  <b>Error</b> state.</para> <para></para></entry></row> <row> <entry> <para>prepare </para> <para></para></entry> <entry> <para>{Initialized, Stopped} </para> <para></para></entry> <entry> <para>{Idle, Prepared, Started, Paused, PlaybackCompleted, Error} </para> <para></para></entry> <entry> <para>Successful invoke of this method in a valid state transfers the object to the  <b>Prepared</b> state. Calling this method in an invalid state throws an IllegalStateException.</para> <para></para></entry></row> <row> <entry> <para>prepareAsync </para> <para></para></entry> <entry> <para>{Initialized, Stopped} </para> <para></para></entry> <entry> <para>{Idle, Prepared, Started, Paused, PlaybackCompleted, Error} </para> <para></para></entry> <entry> <para>Successful invoke of this method in a valid state transfers the object to the  <b>Preparing</b> state. Calling this method in an invalid state throws an IllegalStateException.</para> <para></para></entry></row> <row> <entry> <para>release </para> <para></para></entry> <entry> <para>any </para> <para></para></entry> <entry> <para>{} </para> <para></para></entry> <entry> <para>After release(), the object is no longer available. </para> <para></para></entry></row> <row> <entry> <para>reset </para> <para></para></entry> <entry> <para>{Idle, Initialized, Prepared, Started, Paused, Stopped, PlaybackCompleted, Error}</para> <para></para></entry> <entry> <para>{}</para> <para></para></entry> <entry> <para>After reset(), the object is like being just created.</para> <para></para></entry></row> <row> <entry> <para>seekTo </para> <para></para></entry> <entry> <para>{Prepared, Started, Paused, PlaybackCompleted} </para> <para></para></entry> <entry> <para>{Idle, Initialized, Stopped, Error}</para> <para></para></entry> <entry> <para>Successful invoke of this method in a valid state does not change the state. Calling this method in an invalid state transfers the object to the  <b>Error</b> state. </para> <para></para></entry></row> <row> <entry> <para>setAudioSessionId </para> <para></para></entry> <entry> <para>{Idle} </para> <para></para></entry> <entry> <para>{Initialized, Prepared, Started, Paused, Stopped, PlaybackCompleted, Error} </para> <para></para></entry> <entry> <para>This method must be called in idle state as the audio session ID must be known before calling setDataSource. Calling it does not change the object state. </para> <para></para></entry></row> <row> <entry> <para>setAudioStreamType </para> <para></para></entry> <entry> <para>{Idle, Initialized, Stopped, Prepared, Started, Paused, PlaybackCompleted}</para> <para></para></entry> <entry> <para>{Error}</para> <para></para></entry> <entry> <para>Successful invoke of this method does not change the state. In order for the target audio stream type to become effective, this method must be called before prepare() or prepareAsync().</para> <para></para></entry></row> <row> <entry> <para>setAuxEffectSendLevel </para> <para></para></entry> <entry> <para>any</para> <para></para></entry> <entry> <para>{} </para> <para></para></entry> <entry> <para>Calling this method does not change the object state. </para> <para></para></entry></row> <row> <entry> <para>setDataSource </para> <para></para></entry> <entry> <para>{Idle} </para> <para></para></entry> <entry> <para>{Initialized, Prepared, Started, Paused, Stopped, PlaybackCompleted, Error} </para> <para></para></entry> <entry> <para>Successful invoke of this method in a valid state transfers the object to the  <b>Initialized</b> state. Calling this method in an invalid state throws an IllegalStateException.</para> <para></para></entry></row> <row> <entry> <para>setDisplay </para> <para></para></entry> <entry> <para>any </para> <para></para></entry> <entry> <para>{} </para> <para></para></entry> <entry> <para>This method can be called in any state and calling it does not change the object state. </para> <para></para></entry></row> <row> <entry> <para>setSurface </para> <para></para></entry> <entry> <para>any </para> <para></para></entry> <entry> <para>{} </para> <para></para></entry> <entry> <para>This method can be called in any state and calling it does not change the object state. </para> <para></para></entry></row> <row> <entry> <para>setVideoScalingMode </para> <para></para></entry> <entry> <para>{Initialized, Prepared, Started, Paused, Stopped, PlaybackCompleted} </para> <para></para></entry> <entry> <para>{Idle, Error}</para> <para></para></entry> <entry> <para>Successful invoke of this method does not change the state.</para> <para></para></entry></row> <row> <entry> <para>setLooping </para> <para></para></entry> <entry> <para>{Idle, Initialized, Stopped, Prepared, Started, Paused, PlaybackCompleted}</para> <para></para></entry> <entry> <para>{Error}</para> <para></para></entry> <entry> <para>Successful invoke of this method in a valid state does not change the state. Calling this method in an invalid state transfers the object to the  <b>Error</b> state.</para> <para></para></entry></row> <row> <entry> <para>isLooping </para> <para></para></entry> <entry> <para>any </para> <para></para></entry> <entry> <para>{} </para> <para></para></entry> <entry> <para>This method can be called in any state and calling it does not change the object state. </para> <para></para></entry></row> <row> <entry> <para>setOnBufferingUpdateListener </para> <para></para></entry> <entry> <para>any </para> <para></para></entry> <entry> <para>{} </para> <para></para></entry> <entry> <para>This method can be called in any state and calling it does not change the object state. </para> <para></para></entry></row> <row> <entry> <para>setOnCompletionListener </para> <para></para></entry> <entry> <para>any </para> <para></para></entry> <entry> <para>{} </para> <para></para></entry> <entry> <para>This method can be called in any state and calling it does not change the object state. </para> <para></para></entry></row> <row> <entry> <para>setOnErrorListener </para> <para></para></entry> <entry> <para>any </para> <para></para></entry> <entry> <para>{} </para> <para></para></entry> <entry> <para>This method can be called in any state and calling it does not change the object state. </para> <para></para></entry></row> <row> <entry> <para>setOnPreparedListener </para> <para></para></entry> <entry> <para>any </para> <para></para></entry> <entry> <para>{} </para> <para></para></entry> <entry> <para>This method can be called in any state and calling it does not change the object state. </para> <para></para></entry></row> <row> <entry> <para>setOnSeekCompleteListener </para> <para></para></entry> <entry> <para>any </para> <para></para></entry> <entry> <para>{} </para> <para></para></entry> <entry> <para>This method can be called in any state and calling it does not change the object state. </para> <para></para></entry></row> <row> <entry> <para>setScreenOnWhilePlaying&lt;/&gt; </para></entry> <entry> <para>any </para> <para></para></entry> <entry> <para>{} </para> <para></para></entry> <entry> <para>This method can be called in any state and calling it does not change the object state. </para> <para></para></entry></row> <row> <entry> <para>setVolume </para> <para></para></entry> <entry> <para>{Idle, Initialized, Stopped, Prepared, Started, Paused, PlaybackCompleted}</para> <para></para></entry> <entry> <para>{Error}</para> <para></para></entry> <entry> <para>Successful invoke of this method does not change the state. </para></entry></row> <row> <entry> <para>setWakeMode </para> <para></para></entry> <entry> <para>any </para> <para></para></entry> <entry> <para>{} </para> <para></para></entry> <entry> <para>This method can be called in any state and calling it does not change the object state.</para> <para></para></entry></row> <row> <entry> <para>start </para> <para></para></entry> <entry> <para>{Prepared, Started, Paused, PlaybackCompleted}</para> <para></para></entry> <entry> <para>{Idle, Initialized, Stopped, Error}</para> <para></para></entry> <entry> <para>Successful invoke of this method in a valid state transfers the object to the  <b>Started</b> state. Calling this method in an invalid state transfers the object to the  <b>Error</b> state.</para> <para></para></entry></row> <row> <entry> <para>stop </para> <para></para></entry> <entry> <para>{Prepared, Started, Stopped, Paused, PlaybackCompleted}</para> <para></para></entry> <entry> <para>{Idle, Initialized, Error}</para> <para></para></entry> <entry> <para>Successful invoke of this method in a valid state transfers the object to the  <b>Stopped</b> state. Calling this method in an invalid state transfers the object to the  <b>Error</b> state.</para> <para></para></entry></row> <row> <entry> <para>getTrackInfo </para> <para></para></entry> <entry> <para>{Prepared, Started, Stopped, Paused, PlaybackCompleted}</para> <para></para></entry> <entry> <para>{Idle, Initialized, Error}</para> <para></para></entry> <entry> <para>Successful invoke of this method does not change the state.</para> <para></para></entry></row> <row> <entry> <para>addTimedTextSource </para> <para></para></entry> <entry> <para>{Prepared, Started, Stopped, Paused, PlaybackCompleted}</para> <para></para></entry> <entry> <para>{Idle, Initialized, Error}</para> <para></para></entry> <entry> <para>Successful invoke of this method does not change the state.</para> <para></para></entry></row> <row> <entry> <para>selectTrack </para> <para></para></entry> <entry> <para>{Prepared, Started, Stopped, Paused, PlaybackCompleted}</para> <para></para></entry> <entry> <para>{Idle, Initialized, Error}</para> <para></para></entry> <entry> <para>Successful invoke of this method does not change the state.</para> <para></para></entry></row> <row> <entry> <para>deselectTrack </para> <para></para></entry> <entry> <para>{Prepared, Started, Stopped, Paused, PlaybackCompleted}</para> <para></para></entry> <entry> <para>{Idle, Initialized, Error}</para> <para></para></entry> <entry> <para>Successful invoke of this method does not change the state.</para> <para></para> <para></para></entry></row></table></para> <para>  <h3>Permissions</h3></para> <para></para> <para>One may need to declare a corresponding WAKE_LOCK permission &lt;uses-permission&gt; element.</para> <para></para> <para>This class requires the android.Manifest.permission#INTERNET permission when used with network-based content.</para> <para>  <h3>Callbacks</h3></para> <para></para> <para>Applications may want to register for informational and error events in order to be informed of some internal state update and possible runtime errors during playback or streaming. Registration for these events is done by properly setting the appropriate listeners (via calls to setOnPreparedListener(OnPreparedListener)setOnPreparedListener, setOnVideoSizeChangedListener(OnVideoSizeChangedListener)setOnVideoSizeChangedListener, setOnSeekCompleteListener(OnSeekCompleteListener)setOnSeekCompleteListener, setOnCompletionListener(OnCompletionListener)setOnCompletionListener, setOnBufferingUpdateListener(OnBufferingUpdateListener)setOnBufferingUpdateListener, setOnInfoListener(OnInfoListener)setOnInfoListener, setOnErrorListener(OnErrorListener)setOnErrorListener, etc). In order to receive the respective callback associated with these listeners, applications are required to create MediaPlayer objects on a thread with its own Looper running (main UI thread by default has a Looper running). </para></li></ul></para>    
		/// </summary>
		/// <java-name>
		/// android/media/MediaPlayer
		/// </java-name>
		[Dot42.DexImport("android/media/MediaPlayer", AccessFlags = 33)]
		public partial class MediaPlayer
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Unspecified media player error.  <para>android.media.MediaPlayer.OnErrorListener </para></para>        
				/// </summary>
				/// <java-name>
				/// MEDIA_ERROR_UNKNOWN
				/// </java-name>
				[Dot42.DexImport("MEDIA_ERROR_UNKNOWN", "I", AccessFlags = 25)]
				public const int MEDIA_ERROR_UNKNOWN = 1;
				/// <summary>
				///  <para>Media server died. In this case, the application must release the MediaPlayer object and instantiate a new one.  <para>android.media.MediaPlayer.OnErrorListener </para></para>        
				/// </summary>
				/// <java-name>
				/// MEDIA_ERROR_SERVER_DIED
				/// </java-name>
				[Dot42.DexImport("MEDIA_ERROR_SERVER_DIED", "I", AccessFlags = 25)]
				public const int MEDIA_ERROR_SERVER_DIED = 100;
				/// <summary>
				///  <para>The video is streamed and its container is not valid for progressive playback i.e the video's index (e.g moov atom) is not at the start of the file.  <para>android.media.MediaPlayer.OnErrorListener </para></para>        
				/// </summary>
				/// <java-name>
				/// MEDIA_ERROR_NOT_VALID_FOR_PROGRESSIVE_PLAYBACK
				/// </java-name>
				[Dot42.DexImport("MEDIA_ERROR_NOT_VALID_FOR_PROGRESSIVE_PLAYBACK", "I", AccessFlags = 25)]
				public const int MEDIA_ERROR_NOT_VALID_FOR_PROGRESSIVE_PLAYBACK = 200;
				/// <summary>
				///  <para>Unspecified media player info.  <para>android.media.MediaPlayer.OnInfoListener </para></para>        
				/// </summary>
				/// <java-name>
				/// MEDIA_INFO_UNKNOWN
				/// </java-name>
				[Dot42.DexImport("MEDIA_INFO_UNKNOWN", "I", AccessFlags = 25)]
				public const int MEDIA_INFO_UNKNOWN = 1;
				/// <summary>
				///  <para>The video is too complex for the decoder: it can't decode frames fast enough. Possibly only the audio plays fine at this stage.  <para>android.media.MediaPlayer.OnInfoListener </para></para>        
				/// </summary>
				/// <java-name>
				/// MEDIA_INFO_VIDEO_TRACK_LAGGING
				/// </java-name>
				[Dot42.DexImport("MEDIA_INFO_VIDEO_TRACK_LAGGING", "I", AccessFlags = 25)]
				public const int MEDIA_INFO_VIDEO_TRACK_LAGGING = 700;
				/// <summary>
				///  <para>MediaPlayer is temporarily pausing playback internally in order to buffer more data.  <para>android.media.MediaPlayer.OnInfoListener </para></para>        
				/// </summary>
				/// <java-name>
				/// MEDIA_INFO_BUFFERING_START
				/// </java-name>
				[Dot42.DexImport("MEDIA_INFO_BUFFERING_START", "I", AccessFlags = 25)]
				public const int MEDIA_INFO_BUFFERING_START = 701;
				/// <summary>
				///  <para>MediaPlayer is resuming playback after filling buffers.  <para>android.media.MediaPlayer.OnInfoListener </para></para>        
				/// </summary>
				/// <java-name>
				/// MEDIA_INFO_BUFFERING_END
				/// </java-name>
				[Dot42.DexImport("MEDIA_INFO_BUFFERING_END", "I", AccessFlags = 25)]
				public const int MEDIA_INFO_BUFFERING_END = 702;
				/// <summary>
				///  <para>Bad interleaving means that a media has been improperly interleaved or not interleaved at all, e.g has all the video samples first then all the audio ones. Video is playing but a lot of disk seeks may be happening.  <para>android.media.MediaPlayer.OnInfoListener </para></para>        
				/// </summary>
				/// <java-name>
				/// MEDIA_INFO_BAD_INTERLEAVING
				/// </java-name>
				[Dot42.DexImport("MEDIA_INFO_BAD_INTERLEAVING", "I", AccessFlags = 25)]
				public const int MEDIA_INFO_BAD_INTERLEAVING = 800;
				/// <summary>
				///  <para>The media cannot be seeked (e.g live stream)  <para>android.media.MediaPlayer.OnInfoListener </para></para>        
				/// </summary>
				/// <java-name>
				/// MEDIA_INFO_NOT_SEEKABLE
				/// </java-name>
				[Dot42.DexImport("MEDIA_INFO_NOT_SEEKABLE", "I", AccessFlags = 25)]
				public const int MEDIA_INFO_NOT_SEEKABLE = 801;
				/// <summary>
				///  <para>A new set of metadata is available.  <para>android.media.MediaPlayer.OnInfoListener </para></para>        
				/// </summary>
				/// <java-name>
				/// MEDIA_INFO_METADATA_UPDATE
				/// </java-name>
				[Dot42.DexImport("MEDIA_INFO_METADATA_UPDATE", "I", AccessFlags = 25)]
				public const int MEDIA_INFO_METADATA_UPDATE = 802;
				/// <summary>
				///  <para>Default constructor. Consider using one of the create() methods for synchronously instantiating a MediaPlayer from a Uri or resource. </para> <para>When done with the MediaPlayer, you should call release(), to free the resources. If not released, too many MediaPlayer instances may result in an exception.</para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public MediaPlayer() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the SurfaceHolder to use for displaying the video portion of the media.</para> <para>Either a surface holder or surface must be set if a display or video sink is needed. Not calling this method or setSurface(Surface) when playing back a video will result in only the audio track being played. A null surface holder or surface will result in only the audio track being played.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setDisplay
				/// </java-name>
				[Dot42.DexImport("setDisplay", "(Landroid/view/SurfaceHolder;)V", AccessFlags = 1)]
				public virtual void SetDisplay(global::Android.Views.ISurfaceHolder sh) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Convenience method to create a MediaPlayer for a given Uri. On success, prepare() will already have been called and must not be called again. </para> <para>When done with the MediaPlayer, you should call release(), to free the resources. If not released, too many MediaPlayer instances will result in an exception.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a MediaPlayer object, or null if creation failed </para>
				/// </returns>
				/// <java-name>
				/// create
				/// </java-name>
				[Dot42.DexImport("create", "(Landroid/content/Context;Landroid/net/Uri;)Landroid/media/MediaPlayer;", AccessFlags = 9)]
				public static global::Android.Media.MediaPlayer Create(global::Android.Content.Context context, global::Android.Net.Uri uri) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Media.MediaPlayer);
				}

				/// <summary>
				///  <para>Convenience method to create a MediaPlayer for a given Uri. On success, prepare() will already have been called and must not be called again. </para> <para>When done with the MediaPlayer, you should call release(), to free the resources. If not released, too many MediaPlayer instances will result in an exception.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a MediaPlayer object, or null if creation failed </para>
				/// </returns>
				/// <java-name>
				/// create
				/// </java-name>
				[Dot42.DexImport("create", "(Landroid/content/Context;Landroid/net/Uri;Landroid/view/SurfaceHolder;)Landroid/" +
    "media/MediaPlayer;", AccessFlags = 9)]
				public static global::Android.Media.MediaPlayer Create(global::Android.Content.Context context, global::Android.Net.Uri uri, global::Android.Views.ISurfaceHolder holder) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Media.MediaPlayer);
				}

				/// <summary>
				///  <para>Convenience method to create a MediaPlayer for a given Uri. On success, prepare() will already have been called and must not be called again. </para> <para>When done with the MediaPlayer, you should call release(), to free the resources. If not released, too many MediaPlayer instances will result in an exception.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a MediaPlayer object, or null if creation failed </para>
				/// </returns>
				/// <java-name>
				/// create
				/// </java-name>
				[Dot42.DexImport("create", "(Landroid/content/Context;I)Landroid/media/MediaPlayer;", AccessFlags = 9)]
				public static global::Android.Media.MediaPlayer Create(global::Android.Content.Context context, int uri) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Media.MediaPlayer);
				}

				/// <summary>
				///  <para>Sets the data source as a content Uri.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setDataSource
				/// </java-name>
				[Dot42.DexImport("setDataSource", "(Landroid/content/Context;Landroid/net/Uri;)V", AccessFlags = 1)]
				public virtual void SetDataSource(global::Android.Content.Context context, global::Android.Net.Uri uri) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the data source (FileDescriptor) to use. It is the caller's responsibility to close the file descriptor. It is safe to do so as soon as this call returns.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setDataSource
				/// </java-name>
				[Dot42.DexImport("setDataSource", "(Ljava/lang/String;)V", AccessFlags = 257)]
				public virtual void SetDataSource(string fd) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the data source (FileDescriptor) to use. It is the caller's responsibility to close the file descriptor. It is safe to do so as soon as this call returns.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setDataSource
				/// </java-name>
				[Dot42.DexImport("setDataSource", "(Ljava/io/FileDescriptor;)V", AccessFlags = 1)]
				public virtual void SetDataSource(global::Java.IO.FileDescriptor fd) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the data source as a content Uri.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setDataSource
				/// </java-name>
				[Dot42.DexImport("setDataSource", "(Ljava/io/FileDescriptor;JJ)V", AccessFlags = 257)]
				public virtual void SetDataSource(global::Java.IO.FileDescriptor context, long uri, long headers) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Prepares the player for playback, synchronously.</para> <para>After setting the datasource and the display surface, you need to either call prepare() or prepareAsync(). For files, it is OK to call prepare(), which blocks until MediaPlayer is ready for playback.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// prepare
				/// </java-name>
				[Dot42.DexImport("prepare", "()V", AccessFlags = 257)]
				public virtual void Prepare() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Prepares the player for playback, asynchronously.</para> <para>After setting the datasource and the display surface, you need to either call prepare() or prepareAsync(). For streams, you should call prepareAsync(), which returns immediately, rather than blocking until enough data has been buffered.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// prepareAsync
				/// </java-name>
				[Dot42.DexImport("prepareAsync", "()V", AccessFlags = 257)]
				public virtual void PrepareAsync() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Starts or resumes playback. If playback had previously been paused, playback will continue from where it was paused. If playback had been stopped, or never started before, playback will start at the beginning.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// start
				/// </java-name>
				[Dot42.DexImport("start", "()V", AccessFlags = 1)]
				public virtual void Start() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Stops playback after playback has been stopped or paused.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// stop
				/// </java-name>
				[Dot42.DexImport("stop", "()V", AccessFlags = 1)]
				public virtual void Stop() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Pauses playback. Call start() to resume.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// pause
				/// </java-name>
				[Dot42.DexImport("pause", "()V", AccessFlags = 1)]
				public virtual void Pause() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Set the low-level power management behavior for this MediaPlayer. This can be used when the MediaPlayer is not playing through a SurfaceHolder set with setDisplay(SurfaceHolder) and thus can use the high-level setScreenOnWhilePlaying(boolean) feature.</para> <para>This function has the MediaPlayer access the low-level power manager service to control the device's power usage while playing is occurring. The parameter is a combination of android.os.PowerManager wake flags. Use of this method requires android.Manifest.permission#WAKE_LOCK permission. By default, no attempt is made to keep the device awake during playback.</para> <para> <para>android.os.PowerManager </para></para>        
				/// </summary>
				/// <java-name>
				/// setWakeMode
				/// </java-name>
				[Dot42.DexImport("setWakeMode", "(Landroid/content/Context;I)V", AccessFlags = 1)]
				public virtual void SetWakeMode(global::Android.Content.Context context, int mode) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Control whether we should use the attached SurfaceHolder to keep the screen on while video playback is occurring. This is the preferred method over setWakeMode where possible, since it doesn't require that the application have permission for low-level wake lock access.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setScreenOnWhilePlaying
				/// </java-name>
				[Dot42.DexImport("setScreenOnWhilePlaying", "(Z)V", AccessFlags = 1)]
				public virtual void SetScreenOnWhilePlaying(bool screenOn) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Seeks to specified time position.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// seekTo
				/// </java-name>
				[Dot42.DexImport("seekTo", "(I)V", AccessFlags = 257)]
				public virtual void SeekTo(int msec) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Releases resources associated with this MediaPlayer object. It is considered good practice to call this method when you're done using the MediaPlayer. In particular, whenever an Activity of an application is paused (its onPause() method is called), or stopped (its onStop() method is called), this method should be invoked to release the MediaPlayer object, unless the application has a special need to keep the object around. In addition to unnecessary resources (such as memory and instances of codecs) being held, failure to call this method immediately if a MediaPlayer object is no longer needed may also lead to continuous battery consumption for mobile devices, and playback failure for other applications if no multiple instances of the same codec are supported on a device. Even if multiple instances of the same codec are supported, some performance degradation may be expected when unnecessary multiple instances are used at the same time. </para>        
				/// </summary>
				/// <java-name>
				/// release
				/// </java-name>
				[Dot42.DexImport("release", "()V", AccessFlags = 1)]
				public virtual void Release() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Resets the MediaPlayer to its uninitialized state. After calling this method, you will have to initialize it again by setting the data source and calling prepare(). </para>        
				/// </summary>
				/// <java-name>
				/// reset
				/// </java-name>
				[Dot42.DexImport("reset", "()V", AccessFlags = 1)]
				public virtual void Reset() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the audio stream type for this MediaPlayer. See AudioManager for a list of stream types. Must call this method before prepare() or prepareAsync() in order for the target stream type to become effective thereafter.</para> <para> <para>android.media.AudioManager </para></para>        
				/// </summary>
				/// <java-name>
				/// setAudioStreamType
				/// </java-name>
				[Dot42.DexImport("setAudioStreamType", "(I)V", AccessFlags = 257)]
				public virtual void SetAudioStreamType(int streamtype) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the volume on this player. This API is recommended for balancing the output of audio streams within an application. Unless you are writing an application to control user settings, this API should be used in preference to AudioManager#setStreamVolume(int, int, int) which sets the volume of ALL streams of a particular type. Note that the passed volume values are raw scalars in range 0.0 to 1.0. UI controls should be scaled logarithmically.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setVolume
				/// </java-name>
				[Dot42.DexImport("setVolume", "(FF)V", AccessFlags = 257)]
				public virtual void SetVolume(float leftVolume, float rightVolume) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Attaches an auxiliary effect to the player. A typical auxiliary effect is a reverberation effect which can be applied on any sound source that directs a certain amount of its energy to this effect. This amount is defined by setAuxEffectSendLevel(). { <para>setAuxEffectSendLevel(float)}. </para>After creating an auxiliary effect (e.g. android.media.audiofx.EnvironmentalReverb), retrieve its ID with android.media.audiofx.AudioEffect#getId() and use it when calling this method to attach the player to the effect. </para> <para>To detach the effect from the player, call this method with a null effect id. </para> <para>This method must be called after one of the overloaded  <code> setDataSource </code> methods. </para>        
				/// </summary>
				/// <java-name>
				/// attachAuxEffect
				/// </java-name>
				[Dot42.DexImport("attachAuxEffect", "(I)V", AccessFlags = 257)]
				public virtual void AttachAuxEffect(int effectId) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the send level of the player to the attached auxiliary effect { <para>attachAuxEffect(int)}. The level value range is 0 to 1.0. </para>By default the send level is 0, so even if an effect is attached to the player this method must be called for the effect to be applied. </para> <para>Note that the passed level value is a raw scalar. UI controls should be scaled logarithmically: the gain applied by audio framework ranges from -72dB to 0dB, so an appropriate conversion from linear UI input x to level is: x == 0 -&gt; level = 0 0 &lt; x &lt;= R -&gt; level = 10^(72*(x-R)/20/R) </para>        
				/// </summary>
				/// <java-name>
				/// setAuxEffectSendLevel
				/// </java-name>
				[Dot42.DexImport("setAuxEffectSendLevel", "(F)V", AccessFlags = 257)]
				public virtual void SetAuxEffectSendLevel(float level) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// finalize
				/// </java-name>
				[Dot42.DexImport("finalize", "()V", AccessFlags = 4)]
				extern ~MediaPlayer() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Register a callback to be invoked when the media source is ready for playback.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setOnPreparedListener
				/// </java-name>
				[Dot42.DexImport("setOnPreparedListener", "(Landroid/media/MediaPlayer$OnPreparedListener;)V", AccessFlags = 1)]
				public virtual void SetOnPreparedListener(global::Android.Media.MediaPlayer.IOnPreparedListener listener) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Register a callback to be invoked when the end of a media source has been reached during playback.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setOnCompletionListener
				/// </java-name>
				[Dot42.DexImport("setOnCompletionListener", "(Landroid/media/MediaPlayer$OnCompletionListener;)V", AccessFlags = 1)]
				public virtual void SetOnCompletionListener(global::Android.Media.MediaPlayer.IOnCompletionListener listener) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Register a callback to be invoked when the status of a network stream's buffer has changed.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setOnBufferingUpdateListener
				/// </java-name>
				[Dot42.DexImport("setOnBufferingUpdateListener", "(Landroid/media/MediaPlayer$OnBufferingUpdateListener;)V", AccessFlags = 1)]
				public virtual void SetOnBufferingUpdateListener(global::Android.Media.MediaPlayer.IOnBufferingUpdateListener listener) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Register a callback to be invoked when a seek operation has been completed.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setOnSeekCompleteListener
				/// </java-name>
				[Dot42.DexImport("setOnSeekCompleteListener", "(Landroid/media/MediaPlayer$OnSeekCompleteListener;)V", AccessFlags = 1)]
				public virtual void SetOnSeekCompleteListener(global::Android.Media.MediaPlayer.IOnSeekCompleteListener listener) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Register a callback to be invoked when the video size is known or updated.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setOnVideoSizeChangedListener
				/// </java-name>
				[Dot42.DexImport("setOnVideoSizeChangedListener", "(Landroid/media/MediaPlayer$OnVideoSizeChangedListener;)V", AccessFlags = 1)]
				public virtual void SetOnVideoSizeChangedListener(global::Android.Media.MediaPlayer.IOnVideoSizeChangedListener listener) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Register a callback to be invoked when an error has happened during an asynchronous operation.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setOnErrorListener
				/// </java-name>
				[Dot42.DexImport("setOnErrorListener", "(Landroid/media/MediaPlayer$OnErrorListener;)V", AccessFlags = 1)]
				public virtual void SetOnErrorListener(global::Android.Media.MediaPlayer.IOnErrorListener listener) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Register a callback to be invoked when an info/warning is available.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setOnInfoListener
				/// </java-name>
				[Dot42.DexImport("setOnInfoListener", "(Landroid/media/MediaPlayer$OnInfoListener;)V", AccessFlags = 1)]
				public virtual void SetOnInfoListener(global::Android.Media.MediaPlayer.IOnInfoListener listener) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns the width of the video.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the width of the video, or 0 if there is no video, no display surface was set, or the width has not been determined yet. The OnVideoSizeChangedListener can be registered via setOnVideoSizeChangedListener(OnVideoSizeChangedListener) to provide a notification when the width is available. </para>
				/// </returns>
				/// <java-name>
				/// getVideoWidth
				/// </java-name>
				public virtual int VideoWidth
				{
						[Dot42.DexImport("getVideoWidth", "()I", AccessFlags = 257)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns the height of the video.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the height of the video, or 0 if there is no video, no display surface was set, or the height has not been determined yet. The OnVideoSizeChangedListener can be registered via setOnVideoSizeChangedListener(OnVideoSizeChangedListener) to provide a notification when the height is available. </para>
				/// </returns>
				/// <java-name>
				/// getVideoHeight
				/// </java-name>
				public virtual int VideoHeight
				{
						[Dot42.DexImport("getVideoHeight", "()I", AccessFlags = 257)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Checks whether the MediaPlayer is playing.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if currently playing, false otherwise </para>
				/// </returns>
				/// <java-name>
				/// isPlaying
				/// </java-name>
				public virtual bool IsPlaying
				{
						[Dot42.DexImport("isPlaying", "()Z", AccessFlags = 257)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Gets the current playback position.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the current position in milliseconds </para>
				/// </returns>
				/// <java-name>
				/// getCurrentPosition
				/// </java-name>
				public virtual int CurrentPosition
				{
						[Dot42.DexImport("getCurrentPosition", "()I", AccessFlags = 257)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Gets the duration of the file.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the duration in milliseconds, if no duration is available (for example, if streaming live content), -1 is returned. </para>
				/// </returns>
				/// <java-name>
				/// getDuration
				/// </java-name>
				public virtual int Duration
				{
						[Dot42.DexImport("getDuration", "()I", AccessFlags = 257)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Checks whether the MediaPlayer is looping or non-looping.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if the MediaPlayer is currently looping, false otherwise </para>
				/// </returns>
				/// <java-name>
				/// isLooping
				/// </java-name>
				public virtual bool IsLooping
				{
						[Dot42.DexImport("isLooping", "()Z", AccessFlags = 257)]
						get{ return default(bool); }
						[Dot42.DexImport("setLooping", "(Z)V", AccessFlags = 257)]
						set{ }
				}

				/// <summary>
				///  <para>Returns the audio session ID.</para> <para> <para>setAudioSessionId(int)} Note that the audio session ID is 0 only if a problem occured when the MediaPlayer was contructed. </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the audio session ID. {</para>
				/// </returns>
				/// <java-name>
				/// getAudioSessionId
				/// </java-name>
				public virtual int AudioSessionId
				{
						[Dot42.DexImport("getAudioSessionId", "()I", AccessFlags = 257)]
						get{ return default(int); }
						[Dot42.DexImport("setAudioSessionId", "(I)V", AccessFlags = 257)]
						set{ }
				}

				/// <summary>
				///  <para>Interface definition of a callback to be invoked to communicate some info and/or warning about the media or its playback. </para>    
				/// </summary>
				/// <java-name>
				/// android/media/MediaPlayer$OnInfoListener
				/// </java-name>
				[Dot42.DexImport("android/media/MediaPlayer$OnInfoListener", AccessFlags = 1545)]
				public partial interface IOnInfoListener
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>Called to indicate an info or a warning.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>True if the method handled the info, false if it didn't. Returning false, or not having an OnErrorListener at all, will cause the info to be discarded. </para>
						/// </returns>
						/// <java-name>
						/// onInfo
						/// </java-name>
						[Dot42.DexImport("onInfo", "(Landroid/media/MediaPlayer;II)Z", AccessFlags = 1025)]
						bool OnInfo(global::Android.Media.MediaPlayer mp, int what, int extra) /* MethodBuilder.Create */ ;

				}

				/// <summary>
				///  <para>Interface definition of a callback to be invoked when there has been an error during an asynchronous operation (other errors will throw exceptions at method call time). </para>    
				/// </summary>
				/// <java-name>
				/// android/media/MediaPlayer$OnErrorListener
				/// </java-name>
				[Dot42.DexImport("android/media/MediaPlayer$OnErrorListener", AccessFlags = 1545)]
				public partial interface IOnErrorListener
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>Called to indicate an error.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>True if the method handled the error, false if it didn't. Returning false, or not having an OnErrorListener at all, will cause the OnCompletionListener to be called. </para>
						/// </returns>
						/// <java-name>
						/// onError
						/// </java-name>
						[Dot42.DexImport("onError", "(Landroid/media/MediaPlayer;II)Z", AccessFlags = 1025)]
						bool OnError(global::Android.Media.MediaPlayer mp, int what, int extra) /* MethodBuilder.Create */ ;

				}

				/// <summary>
				///  <para>Interface definition of a callback to be invoked when the video size is first known or updated </para>    
				/// </summary>
				/// <java-name>
				/// android/media/MediaPlayer$OnVideoSizeChangedListener
				/// </java-name>
				[Dot42.DexImport("android/media/MediaPlayer$OnVideoSizeChangedListener", AccessFlags = 1545)]
				public partial interface IOnVideoSizeChangedListener
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>Called to indicate the video size</para> <para>The video size (width and height) could be 0 if there was no video, no display surface was set, or the value was not determined yet.</para> <para></para>        
						/// </summary>
						/// <java-name>
						/// onVideoSizeChanged
						/// </java-name>
						[Dot42.DexImport("onVideoSizeChanged", "(Landroid/media/MediaPlayer;II)V", AccessFlags = 1025)]
						void OnVideoSizeChanged(global::Android.Media.MediaPlayer mp, int width, int height) /* MethodBuilder.Create */ ;

				}

				/// <summary>
				///  <para>Interface definition of a callback to be invoked indicating the completion of a seek operation. </para>    
				/// </summary>
				/// <java-name>
				/// android/media/MediaPlayer$OnSeekCompleteListener
				/// </java-name>
				[Dot42.DexImport("android/media/MediaPlayer$OnSeekCompleteListener", AccessFlags = 1545)]
				public partial interface IOnSeekCompleteListener
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>Called to indicate the completion of a seek operation.</para> <para></para>        
						/// </summary>
						/// <java-name>
						/// onSeekComplete
						/// </java-name>
						[Dot42.DexImport("onSeekComplete", "(Landroid/media/MediaPlayer;)V", AccessFlags = 1025)]
						void OnSeekComplete(global::Android.Media.MediaPlayer mp) /* MethodBuilder.Create */ ;

				}

				/// <summary>
				///  <para>Interface definition of a callback to be invoked indicating buffering status of a media resource being streamed over the network. </para>    
				/// </summary>
				/// <java-name>
				/// android/media/MediaPlayer$OnBufferingUpdateListener
				/// </java-name>
				[Dot42.DexImport("android/media/MediaPlayer$OnBufferingUpdateListener", AccessFlags = 1545)]
				public partial interface IOnBufferingUpdateListener
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>Called to update status in buffering a media stream received through progressive HTTP download. The received buffering percentage indicates how much of the content has been buffered or played. For example a buffering update of 80 percent when half the content has already been played indicates that the next 30 percent of the content to play has been buffered.</para> <para></para>        
						/// </summary>
						/// <java-name>
						/// onBufferingUpdate
						/// </java-name>
						[Dot42.DexImport("onBufferingUpdate", "(Landroid/media/MediaPlayer;I)V", AccessFlags = 1025)]
						void OnBufferingUpdate(global::Android.Media.MediaPlayer mp, int percent) /* MethodBuilder.Create */ ;

				}

				/// <summary>
				///  <para>Interface definition for a callback to be invoked when playback of a media source has completed. </para>    
				/// </summary>
				/// <java-name>
				/// android/media/MediaPlayer$OnCompletionListener
				/// </java-name>
				[Dot42.DexImport("android/media/MediaPlayer$OnCompletionListener", AccessFlags = 1545)]
				public partial interface IOnCompletionListener
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>Called when the end of a media source is reached during playback.</para> <para></para>        
						/// </summary>
						/// <java-name>
						/// onCompletion
						/// </java-name>
						[Dot42.DexImport("onCompletion", "(Landroid/media/MediaPlayer;)V", AccessFlags = 1025)]
						void OnCompletion(global::Android.Media.MediaPlayer mp) /* MethodBuilder.Create */ ;

				}

				/// <summary>
				///  <para>Interface definition for a callback to be invoked when the media source is ready for playback. </para>    
				/// </summary>
				/// <java-name>
				/// android/media/MediaPlayer$OnPreparedListener
				/// </java-name>
				[Dot42.DexImport("android/media/MediaPlayer$OnPreparedListener", AccessFlags = 1545)]
				public partial interface IOnPreparedListener
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>Called when the media file is ready for playback.</para> <para></para>        
						/// </summary>
						/// <java-name>
						/// onPrepared
						/// </java-name>
						[Dot42.DexImport("onPrepared", "(Landroid/media/MediaPlayer;)V", AccessFlags = 1025)]
						void OnPrepared(global::Android.Media.MediaPlayer mp) /* MethodBuilder.Create */ ;

				}

		}

		/// <summary>
		///  <para>Used to record audio and video. The recording control is based on a simple state machine (see below).</para> <para> <image></image> </para> <para>A common case of using MediaRecorder to record audio works as follows:</para> <para> <pre>MediaRecorder recorder = new MediaRecorder();
		/// recorder.setAudioSource(MediaRecorder.AudioSource.MIC);
		/// recorder.setOutputFormat(MediaRecorder.OutputFormat.THREE_GPP);
		/// recorder.setAudioEncoder(MediaRecorder.AudioEncoder.AMR_NB);
		/// recorder.setOutputFile(PATH_NAME);
		/// recorder.prepare();
		/// recorder.start();   // Recording is now started
		/// ...
		/// recorder.stop();
		/// recorder.reset();   // You can reuse the object by going back to setAudioSource() step
		/// recorder.release(); // Now the object cannot be reused
		/// </pre></para> <para>Applications may want to register for informational and error events in order to be informed of some internal update and possible runtime errors during recording. Registration for such events is done by setting the appropriate listeners (via calls (to setOnInfoListener(OnInfoListener)setOnInfoListener and/or setOnErrorListener(OnErrorListener)setOnErrorListener). In order to receive the respective callback associated with these listeners, applications are required to create MediaRecorder objects on threads with a Looper running (the main UI thread by default already has a Looper running).</para> <para> <b>Note:</b> Currently, MediaRecorder does not work on the emulator.</para> <para>  <h3>Developer Guides</h3></para> <para> </para> <para>For more information about how to use MediaRecorder for recording video, read the  developer guide. For more information about how to use MediaRecorder for recording sound, read the  developer guide.</para> <para>  </para>    
		/// </summary>
		/// <java-name>
		/// android/media/MediaRecorder
		/// </java-name>
		[Dot42.DexImport("android/media/MediaRecorder", AccessFlags = 33)]
		public partial class MediaRecorder
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Unspecified media recorder error.  <para>android.media.MediaRecorder.OnErrorListener </para></para>        
				/// </summary>
				/// <java-name>
				/// MEDIA_RECORDER_ERROR_UNKNOWN
				/// </java-name>
				[Dot42.DexImport("MEDIA_RECORDER_ERROR_UNKNOWN", "I", AccessFlags = 25)]
				public const int MEDIA_RECORDER_ERROR_UNKNOWN = 1;
				/// <summary>
				///  <para>Unspecified media recorder error.  <para>android.media.MediaRecorder.OnInfoListener </para></para>        
				/// </summary>
				/// <java-name>
				/// MEDIA_RECORDER_INFO_UNKNOWN
				/// </java-name>
				[Dot42.DexImport("MEDIA_RECORDER_INFO_UNKNOWN", "I", AccessFlags = 25)]
				public const int MEDIA_RECORDER_INFO_UNKNOWN = 1;
				/// <summary>
				///  <para>A maximum duration had been setup and has now been reached.  <para>android.media.MediaRecorder.OnInfoListener </para></para>        
				/// </summary>
				/// <java-name>
				/// MEDIA_RECORDER_INFO_MAX_DURATION_REACHED
				/// </java-name>
				[Dot42.DexImport("MEDIA_RECORDER_INFO_MAX_DURATION_REACHED", "I", AccessFlags = 25)]
				public const int MEDIA_RECORDER_INFO_MAX_DURATION_REACHED = 800;
				/// <summary>
				///  <para>A maximum filesize had been setup and has now been reached.  <para>android.media.MediaRecorder.OnInfoListener </para></para>        
				/// </summary>
				/// <java-name>
				/// MEDIA_RECORDER_INFO_MAX_FILESIZE_REACHED
				/// </java-name>
				[Dot42.DexImport("MEDIA_RECORDER_INFO_MAX_FILESIZE_REACHED", "I", AccessFlags = 25)]
				public const int MEDIA_RECORDER_INFO_MAX_FILESIZE_REACHED = 801;
				/// <summary>
				///  <para>Default constructor. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public MediaRecorder() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets a Camera to use for recording. Use this function to switch quickly between preview and capture mode without a teardown of the camera object. android.hardware.Camera#unlock() should be called before this. Must call before prepare().</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setCamera
				/// </java-name>
				[Dot42.DexImport("setCamera", "(Landroid/hardware/Camera;)V", AccessFlags = 257)]
				public virtual void SetCamera(global::Android.Hardware.Camera c) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets a Surface to show a preview of recorded media (video). Calls this before prepare() to make sure that the desirable preview display is set. If setCamera(Camera) is used and the surface has been already set to the camera, application do not need to call this. If this is called with non-null surface, the preview surface of the camera will be replaced by the new surface. If this method is called with null surface or not called at all, media recorder will not change the preview surface of the camera.</para> <para> <para>android.hardware.Camera::setPreviewDisplay(android.view.SurfaceHolder) </para></para>        
				/// </summary>
				/// <java-name>
				/// setPreviewDisplay
				/// </java-name>
				[Dot42.DexImport("setPreviewDisplay", "(Landroid/view/Surface;)V", AccessFlags = 1)]
				public virtual void SetPreviewDisplay(global::Android.Views.Surface sv) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the audio source to be used for recording. If this method is not called, the output file will not contain an audio track. The source needs to be specified before setting recording-parameters or encoders. Call this only before setOutputFormat().</para> <para> <para>android.media.MediaRecorder.AudioSource </para></para>        
				/// </summary>
				/// <java-name>
				/// setAudioSource
				/// </java-name>
				[Dot42.DexImport("setAudioSource", "(I)V", AccessFlags = 257)]
				public virtual void SetAudioSource(int audio_source) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the video source to be used for recording. If this method is not called, the output file will not contain an video track. The source needs to be specified before setting recording-parameters or encoders. Call this only before setOutputFormat().</para> <para> <para>android.media.MediaRecorder.VideoSource </para></para>        
				/// </summary>
				/// <java-name>
				/// setVideoSource
				/// </java-name>
				[Dot42.DexImport("setVideoSource", "(I)V", AccessFlags = 257)]
				public virtual void SetVideoSource(int video_source) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Uses the settings from a CamcorderProfile object for recording. This method should be called after the video AND audio sources are set, and before setOutputFile(). If a time lapse CamcorderProfile is used, audio related source or recording parameters are ignored.</para> <para> <para>android.media.CamcorderProfile </para></para>        
				/// </summary>
				/// <java-name>
				/// setProfile
				/// </java-name>
				[Dot42.DexImport("setProfile", "(Landroid/media/CamcorderProfile;)V", AccessFlags = 1)]
				public virtual void SetProfile(global::Android.Media.CamcorderProfile profile) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the orientation hint for output video playback. This method should be called before prepare(). This method will not trigger the source video frame to rotate during video recording, but to add a composition matrix containing the rotation angle in the output video if the output format is OutputFormat.THREE_GPP or OutputFormat.MPEG_4 so that a video player can choose the proper orientation for playback. Note that some video players may choose to ignore the compostion matrix in a video during playback.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setOrientationHint
				/// </java-name>
				[Dot42.DexImport("setOrientationHint", "(I)V", AccessFlags = 1)]
				public virtual void SetOrientationHint(int degrees) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the format of the output file produced during recording. Call this after setAudioSource()/setVideoSource() but before prepare().</para> <para>It is recommended to always use 3GP format when using the H.263 video encoder and AMR audio encoder. Using an MPEG-4 container format may confuse some desktop players.</para> <para> <para>android.media.MediaRecorder.OutputFormat </para></para>        
				/// </summary>
				/// <java-name>
				/// setOutputFormat
				/// </java-name>
				[Dot42.DexImport("setOutputFormat", "(I)V", AccessFlags = 257)]
				public virtual void SetOutputFormat(int output_format) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the width and height of the video to be captured. Must be called after setVideoSource(). Call this after setOutFormat() but before prepare().</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setVideoSize
				/// </java-name>
				[Dot42.DexImport("setVideoSize", "(II)V", AccessFlags = 257)]
				public virtual void SetVideoSize(int width, int height) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the frame rate of the video to be captured. Must be called after setVideoSource(). Call this after setOutFormat() but before prepare().</para> <para>NOTE: On some devices that have auto-frame rate, this sets the maximum frame rate, not a constant frame rate. Actual frame rate will vary according to lighting conditions. </para>        
				/// </summary>
				/// <java-name>
				/// setVideoFrameRate
				/// </java-name>
				[Dot42.DexImport("setVideoFrameRate", "(I)V", AccessFlags = 257)]
				public virtual void SetVideoFrameRate(int rate) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the maximum duration (in ms) of the recording session. Call this after setOutFormat() but before prepare(). After recording reaches the specified duration, a notification will be sent to the android.media.MediaRecorder.OnInfoListener with a "what" code of MEDIA_RECORDER_INFO_MAX_DURATION_REACHED and recording will be stopped. Stopping happens asynchronously, there is no guarantee that the recorder will have stopped by the time the listener is notified.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setMaxDuration
				/// </java-name>
				[Dot42.DexImport("setMaxDuration", "(I)V", AccessFlags = 257)]
				public virtual void SetMaxDuration(int max_duration_ms) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the maximum filesize (in bytes) of the recording session. Call this after setOutFormat() but before prepare(). After recording reaches the specified filesize, a notification will be sent to the android.media.MediaRecorder.OnInfoListener with a "what" code of MEDIA_RECORDER_INFO_MAX_FILESIZE_REACHED and recording will be stopped. Stopping happens asynchronously, there is no guarantee that the recorder will have stopped by the time the listener is notified.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setMaxFileSize
				/// </java-name>
				[Dot42.DexImport("setMaxFileSize", "(J)V", AccessFlags = 257)]
				public virtual void SetMaxFileSize(long max_filesize_bytes) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the audio encoder to be used for recording. If this method is not called, the output file will not contain an audio track. Call this after setOutputFormat() but before prepare().</para> <para> <para>android.media.MediaRecorder.AudioEncoder </para></para>        
				/// </summary>
				/// <java-name>
				/// setAudioEncoder
				/// </java-name>
				[Dot42.DexImport("setAudioEncoder", "(I)V", AccessFlags = 257)]
				public virtual void SetAudioEncoder(int audio_encoder) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the video encoder to be used for recording. If this method is not called, the output file will not contain an video track. Call this after setOutputFormat() and before prepare().</para> <para> <para>android.media.MediaRecorder.VideoEncoder </para></para>        
				/// </summary>
				/// <java-name>
				/// setVideoEncoder
				/// </java-name>
				[Dot42.DexImport("setVideoEncoder", "(I)V", AccessFlags = 257)]
				public virtual void SetVideoEncoder(int video_encoder) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the audio sampling rate for recording. Call this method before prepare(). Prepare() may perform additional checks on the parameter to make sure whether the specified audio sampling rate is applicable. The sampling rate really depends on the format for the audio recording, as well as the capabilities of the platform. For instance, the sampling rate supported by AAC audio coding standard ranges from 8 to 96 kHz, the sampling rate supported by AMRNB is 8kHz, and the sampling rate supported by AMRWB is 16kHz. Please consult with the related audio coding standard for the supported audio sampling rate.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setAudioSamplingRate
				/// </java-name>
				[Dot42.DexImport("setAudioSamplingRate", "(I)V", AccessFlags = 1)]
				public virtual void SetAudioSamplingRate(int samplingRate) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the number of audio channels for recording. Call this method before prepare(). Prepare() may perform additional checks on the parameter to make sure whether the specified number of audio channels are applicable.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setAudioChannels
				/// </java-name>
				[Dot42.DexImport("setAudioChannels", "(I)V", AccessFlags = 1)]
				public virtual void SetAudioChannels(int numChannels) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the audio encoding bit rate for recording. Call this method before prepare(). Prepare() may perform additional checks on the parameter to make sure whether the specified bit rate is applicable, and sometimes the passed bitRate will be clipped internally to ensure the audio recording can proceed smoothly based on the capabilities of the platform.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setAudioEncodingBitRate
				/// </java-name>
				[Dot42.DexImport("setAudioEncodingBitRate", "(I)V", AccessFlags = 1)]
				public virtual void SetAudioEncodingBitRate(int bitRate) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the video encoding bit rate for recording. Call this method before prepare(). Prepare() may perform additional checks on the parameter to make sure whether the specified bit rate is applicable, and sometimes the passed bitRate will be clipped internally to ensure the video recording can proceed smoothly based on the capabilities of the platform.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setVideoEncodingBitRate
				/// </java-name>
				[Dot42.DexImport("setVideoEncodingBitRate", "(I)V", AccessFlags = 1)]
				public virtual void SetVideoEncodingBitRate(int bitRate) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Pass in the file descriptor of the file to be written. Call this after setOutputFormat() but before prepare().</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setOutputFile
				/// </java-name>
				[Dot42.DexImport("setOutputFile", "(Ljava/io/FileDescriptor;)V", AccessFlags = 1)]
				public virtual void SetOutputFile(global::Java.IO.FileDescriptor fd) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Pass in the file descriptor of the file to be written. Call this after setOutputFormat() but before prepare().</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setOutputFile
				/// </java-name>
				[Dot42.DexImport("setOutputFile", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetOutputFile(string fd) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Prepares the recorder to begin capturing and encoding data. This method must be called after setting up the desired audio and video sources, encoders, file format, etc., but before start().</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// prepare
				/// </java-name>
				[Dot42.DexImport("prepare", "()V", AccessFlags = 1)]
				public virtual void Prepare() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Begins capturing and encoding data to the file specified with setOutputFile(). Call this after prepare().</para> <para>Since API level 13, if applications set a camera via setCamera(Camera), the apps can use the camera after this method call. The apps do not need to lock the camera again. However, if this method fails, the apps should still lock the camera back. The apps should not start another recording session during recording.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// start
				/// </java-name>
				[Dot42.DexImport("start", "()V", AccessFlags = 257)]
				public virtual void Start() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Stops recording. Call this after start(). Once recording is stopped, you will have to configure it again as if it has just been constructed. Note that a RuntimeException is intentionally thrown to the application, if no valid audio/video data has been received when stop() is called. This happens if stop() is called immediately after start(). The failure lets the application take action accordingly to clean up the output file (delete the output file, for instance), since the output file is not properly constructed when this happens.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// stop
				/// </java-name>
				[Dot42.DexImport("stop", "()V", AccessFlags = 257)]
				public virtual void Stop() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Restarts the MediaRecorder to its idle state. After calling this method, you will have to configure it again as if it had just been constructed. </para>        
				/// </summary>
				/// <java-name>
				/// reset
				/// </java-name>
				[Dot42.DexImport("reset", "()V", AccessFlags = 1)]
				public virtual void Reset() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Register a callback to be invoked when an error occurs while recording.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setOnErrorListener
				/// </java-name>
				[Dot42.DexImport("setOnErrorListener", "(Landroid/media/MediaRecorder$OnErrorListener;)V", AccessFlags = 1)]
				public virtual void SetOnErrorListener(global::Android.Media.MediaRecorder.IOnErrorListener l) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Register a callback to be invoked when an informational event occurs while recording.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setOnInfoListener
				/// </java-name>
				[Dot42.DexImport("setOnInfoListener", "(Landroid/media/MediaRecorder$OnInfoListener;)V", AccessFlags = 1)]
				public virtual void SetOnInfoListener(global::Android.Media.MediaRecorder.IOnInfoListener listener) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Releases resources associated with this MediaRecorder object. It is good practice to call this method when you're done using the MediaRecorder. In particular, whenever an Activity of an application is paused (its onPause() method is called), or stopped (its onStop() method is called), this method should be invoked to release the MediaRecorder object, unless the application has a special need to keep the object around. In addition to unnecessary resources (such as memory and instances of codecs) being held, failure to call this method immediately if a MediaRecorder object is no longer needed may also lead to continuous battery consumption for mobile devices, and recording failure for other applications if no multiple instances of the same codec are supported on a device. Even if multiple instances of the same codec are supported, some performance degradation may be expected when unnecessary multiple instances are used at the same time. </para>        
				/// </summary>
				/// <java-name>
				/// release
				/// </java-name>
				[Dot42.DexImport("release", "()V", AccessFlags = 257)]
				public virtual void Release() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// finalize
				/// </java-name>
				[Dot42.DexImport("finalize", "()V", AccessFlags = 4)]
				extern ~MediaRecorder() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Gets the maximum value for audio sources.  <para>android.media.MediaRecorder.AudioSource </para></para>        
				/// </summary>
				/// <java-name>
				/// getAudioSourceMax
				/// </java-name>
				public static int AudioSourceMax
				{
						[Dot42.DexImport("getAudioSourceMax", "()I", AccessFlags = 25)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns the maximum absolute amplitude that was sampled since the last call to this method. Call this only after the setAudioSource().</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the maximum absolute amplitude measured since the last call, or 0 when called for the first time </para>
				/// </returns>
				/// <java-name>
				/// getMaxAmplitude
				/// </java-name>
				public virtual int MaxAmplitude
				{
						[Dot42.DexImport("getMaxAmplitude", "()I", AccessFlags = 257)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Interface definition for a callback to be invoked when an error occurs while recording. </para>    
				/// </summary>
				/// <java-name>
				/// android/media/MediaRecorder$OnInfoListener
				/// </java-name>
				[Dot42.DexImport("android/media/MediaRecorder$OnInfoListener", AccessFlags = 1545)]
				public partial interface IOnInfoListener
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>Called when an error occurs while recording.</para> <para></para>        
						/// </summary>
						/// <java-name>
						/// onInfo
						/// </java-name>
						[Dot42.DexImport("onInfo", "(Landroid/media/MediaRecorder;II)V", AccessFlags = 1025)]
						void OnInfo(global::Android.Media.MediaRecorder mr, int what, int extra) /* MethodBuilder.Create */ ;

				}

				/// <summary>
				///  <para>Interface definition for a callback to be invoked when an error occurs while recording. </para>    
				/// </summary>
				/// <java-name>
				/// android/media/MediaRecorder$OnErrorListener
				/// </java-name>
				[Dot42.DexImport("android/media/MediaRecorder$OnErrorListener", AccessFlags = 1545)]
				public partial interface IOnErrorListener
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>Called when an error occurs while recording.</para> <para></para>        
						/// </summary>
						/// <java-name>
						/// onError
						/// </java-name>
						[Dot42.DexImport("onError", "(Landroid/media/MediaRecorder;II)V", AccessFlags = 1025)]
						void OnError(global::Android.Media.MediaRecorder mr, int what, int extra) /* MethodBuilder.Create */ ;

				}

				/// <summary>
				///  <para>Defines the video encoding. These constants are used with MediaRecorder#setVideoEncoder(int). </para>    
				/// </summary>
				/// <java-name>
				/// android/media/MediaRecorder$VideoEncoder
				/// </java-name>
				[Dot42.DexImport("android/media/MediaRecorder$VideoEncoder", AccessFlags = 17)]
				public sealed partial class VideoEncoder
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// DEFAULT
						/// </java-name>
						[Dot42.DexImport("DEFAULT", "I", AccessFlags = 25)]
						public const int DEFAULT = 0;
						/// <java-name>
						/// H263
						/// </java-name>
						[Dot42.DexImport("H263", "I", AccessFlags = 25)]
						public const int H263 = 1;
						/// <java-name>
						/// H264
						/// </java-name>
						[Dot42.DexImport("H264", "I", AccessFlags = 25)]
						public const int H264 = 2;
						/// <java-name>
						/// MPEG_4_SP
						/// </java-name>
						[Dot42.DexImport("MPEG_4_SP", "I", AccessFlags = 25)]
						public const int MPEG_4_SP = 3;
						/// <java-name>
						/// this$0
						/// </java-name>
						[Dot42.DexImport("this$0", "Landroid/media/MediaRecorder;", AccessFlags = 4112)]
						internal readonly global::Android.Media.MediaRecorder This_0;
						[Dot42.DexImport("<init>", "(Landroid/media/MediaRecorder;)V", AccessFlags = 0)]
						internal VideoEncoder(global::Android.Media.MediaRecorder mediaRecorder) /* MethodBuilder.Create */ 
						{
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						protected internal VideoEncoder() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

				}

				/// <summary>
				///  <para>Defines the audio encoding. These constants are used with MediaRecorder#setAudioEncoder(int). </para>    
				/// </summary>
				/// <java-name>
				/// android/media/MediaRecorder$AudioEncoder
				/// </java-name>
				[Dot42.DexImport("android/media/MediaRecorder$AudioEncoder", AccessFlags = 17)]
				public sealed partial class AudioEncoder
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// DEFAULT
						/// </java-name>
						[Dot42.DexImport("DEFAULT", "I", AccessFlags = 25)]
						public const int DEFAULT = 0;
						/// <summary>
						///  <para>AMR (Narrowband) audio codec </para>        
						/// </summary>
						/// <java-name>
						/// AMR_NB
						/// </java-name>
						[Dot42.DexImport("AMR_NB", "I", AccessFlags = 25)]
						public const int AMR_NB = 1;
						/// <summary>
						///  <para>AMR (Wideband) audio codec </para>        
						/// </summary>
						/// <java-name>
						/// AMR_WB
						/// </java-name>
						[Dot42.DexImport("AMR_WB", "I", AccessFlags = 25)]
						public const int AMR_WB = 2;
						/// <summary>
						///  <para>AAC Low Complexity (AAC-LC) audio codec </para>        
						/// </summary>
						/// <java-name>
						/// AAC
						/// </java-name>
						[Dot42.DexImport("AAC", "I", AccessFlags = 25)]
						public const int AAC = 3;
						/// <java-name>
						/// this$0
						/// </java-name>
						[Dot42.DexImport("this$0", "Landroid/media/MediaRecorder;", AccessFlags = 4112)]
						internal readonly global::Android.Media.MediaRecorder This_0;
						[Dot42.DexImport("<init>", "(Landroid/media/MediaRecorder;)V", AccessFlags = 0)]
						internal AudioEncoder(global::Android.Media.MediaRecorder mediaRecorder) /* MethodBuilder.Create */ 
						{
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						protected internal AudioEncoder() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

				}

				/// <summary>
				///  <para>Defines the output format. These constants are used with MediaRecorder#setOutputFormat(int). </para>    
				/// </summary>
				/// <java-name>
				/// android/media/MediaRecorder$OutputFormat
				/// </java-name>
				[Dot42.DexImport("android/media/MediaRecorder$OutputFormat", AccessFlags = 17)]
				public sealed partial class OutputFormat
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// DEFAULT
						/// </java-name>
						[Dot42.DexImport("DEFAULT", "I", AccessFlags = 25)]
						public const int DEFAULT = 0;
						/// <summary>
						///  <para>3GPP media file format </para>        
						/// </summary>
						/// <java-name>
						/// THREE_GPP
						/// </java-name>
						[Dot42.DexImport("THREE_GPP", "I", AccessFlags = 25)]
						public const int THREE_GPP = 1;
						/// <summary>
						///  <para>MPEG4 media file format </para>        
						/// </summary>
						/// <java-name>
						/// MPEG_4
						/// </java-name>
						[Dot42.DexImport("MPEG_4", "I", AccessFlags = 25)]
						public const int MPEG_4 = 2;
						/// <summary>
						///  <para>The following formats are audio only .aac or .amr formats AMR NB file format  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Deprecated in favor of MediaRecorder.OutputFormat.AMR_NB </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// RAW_AMR
						/// </java-name>
						[Dot42.DexImport("RAW_AMR", "I", AccessFlags = 25)]
						public const int RAW_AMR = 3;
						/// <summary>
						///  <para>AMR NB file format </para>        
						/// </summary>
						/// <java-name>
						/// AMR_NB
						/// </java-name>
						[Dot42.DexImport("AMR_NB", "I", AccessFlags = 25)]
						public const int AMR_NB = 3;
						/// <summary>
						///  <para>AMR WB file format </para>        
						/// </summary>
						/// <java-name>
						/// AMR_WB
						/// </java-name>
						[Dot42.DexImport("AMR_WB", "I", AccessFlags = 25)]
						public const int AMR_WB = 4;
						/// <java-name>
						/// this$0
						/// </java-name>
						[Dot42.DexImport("this$0", "Landroid/media/MediaRecorder;", AccessFlags = 4112)]
						internal readonly global::Android.Media.MediaRecorder This_0;
						[Dot42.DexImport("<init>", "(Landroid/media/MediaRecorder;)V", AccessFlags = 0)]
						internal OutputFormat(global::Android.Media.MediaRecorder mediaRecorder) /* MethodBuilder.Create */ 
						{
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						protected internal OutputFormat() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

				}

				/// <summary>
				///  <para>Defines the video source. These constants are used with MediaRecorder#setVideoSource(int). </para>    
				/// </summary>
				/// <java-name>
				/// android/media/MediaRecorder$VideoSource
				/// </java-name>
				[Dot42.DexImport("android/media/MediaRecorder$VideoSource", AccessFlags = 17)]
				public sealed partial class VideoSource
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// DEFAULT
						/// </java-name>
						[Dot42.DexImport("DEFAULT", "I", AccessFlags = 25)]
						public const int DEFAULT = 0;
						/// <summary>
						///  <para>Camera video source </para>        
						/// </summary>
						/// <java-name>
						/// CAMERA
						/// </java-name>
						[Dot42.DexImport("CAMERA", "I", AccessFlags = 25)]
						public const int CAMERA = 1;
						/// <java-name>
						/// this$0
						/// </java-name>
						[Dot42.DexImport("this$0", "Landroid/media/MediaRecorder;", AccessFlags = 4112)]
						internal readonly global::Android.Media.MediaRecorder This_0;
						[Dot42.DexImport("<init>", "(Landroid/media/MediaRecorder;)V", AccessFlags = 0)]
						internal VideoSource(global::Android.Media.MediaRecorder mediaRecorder) /* MethodBuilder.Create */ 
						{
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						protected internal VideoSource() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

				}

				/// <summary>
				///  <para>Defines the audio source. These constants are used with MediaRecorder#setAudioSource(int). </para>    
				/// </summary>
				/// <java-name>
				/// android/media/MediaRecorder$AudioSource
				/// </java-name>
				[Dot42.DexImport("android/media/MediaRecorder$AudioSource", AccessFlags = 17)]
				public sealed partial class AudioSource
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>Default audio source </para>        
						/// </summary>
						/// <java-name>
						/// DEFAULT
						/// </java-name>
						[Dot42.DexImport("DEFAULT", "I", AccessFlags = 25)]
						public const int DEFAULT = 0;
						/// <summary>
						///  <para>Microphone audio source </para>        
						/// </summary>
						/// <java-name>
						/// MIC
						/// </java-name>
						[Dot42.DexImport("MIC", "I", AccessFlags = 25)]
						public const int MIC = 1;
						/// <summary>
						///  <para>Voice call uplink (Tx) audio source </para>        
						/// </summary>
						/// <java-name>
						/// VOICE_UPLINK
						/// </java-name>
						[Dot42.DexImport("VOICE_UPLINK", "I", AccessFlags = 25)]
						public const int VOICE_UPLINK = 2;
						/// <summary>
						///  <para>Voice call downlink (Rx) audio source </para>        
						/// </summary>
						/// <java-name>
						/// VOICE_DOWNLINK
						/// </java-name>
						[Dot42.DexImport("VOICE_DOWNLINK", "I", AccessFlags = 25)]
						public const int VOICE_DOWNLINK = 3;
						/// <summary>
						///  <para>Voice call uplink + downlink audio source </para>        
						/// </summary>
						/// <java-name>
						/// VOICE_CALL
						/// </java-name>
						[Dot42.DexImport("VOICE_CALL", "I", AccessFlags = 25)]
						public const int VOICE_CALL = 4;
						/// <summary>
						///  <para>Microphone audio source with same orientation as camera if available, the main device microphone otherwise </para>        
						/// </summary>
						/// <java-name>
						/// CAMCORDER
						/// </java-name>
						[Dot42.DexImport("CAMCORDER", "I", AccessFlags = 25)]
						public const int CAMCORDER = 5;
						/// <summary>
						///  <para>Microphone audio source tuned for voice recognition if available, behaves like DEFAULT otherwise. </para>        
						/// </summary>
						/// <java-name>
						/// VOICE_RECOGNITION
						/// </java-name>
						[Dot42.DexImport("VOICE_RECOGNITION", "I", AccessFlags = 25)]
						public const int VOICE_RECOGNITION = 6;
						/// <java-name>
						/// this$0
						/// </java-name>
						[Dot42.DexImport("this$0", "Landroid/media/MediaRecorder;", AccessFlags = 4112)]
						internal readonly global::Android.Media.MediaRecorder This_0;
						[Dot42.DexImport("<init>", "(Landroid/media/MediaRecorder;)V", AccessFlags = 0)]
						internal AudioSource(global::Android.Media.MediaRecorder mediaRecorder) /* MethodBuilder.Create */ 
						{
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						protected internal AudioSource() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

				}

		}

		/// <summary>
		///  <para>MediaScannerConnection provides a way for applications to pass a newly created or downloaded media file to the media scanner service. The media scanner service will read metadata from the file and add the file to the media content provider. The MediaScannerConnectionClient provides an interface for the media scanner service to return the Uri for a newly scanned file to the client of the MediaScannerConnection class. </para>    
		/// </summary>
		/// <java-name>
		/// android/media/MediaScannerConnection
		/// </java-name>
		[Dot42.DexImport("android/media/MediaScannerConnection", AccessFlags = 33)]
		public partial class MediaScannerConnection : global::Android.Content.IServiceConnection
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructs a new MediaScannerConnection object. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/media/MediaScannerConnection$MediaScannerConne" +
    "ctionClient;)V", AccessFlags = 1)]
				public MediaScannerConnection(global::Android.Content.Context context, global::Android.Media.MediaScannerConnection.IMediaScannerConnectionClient client) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Initiates a connection to the media scanner service. MediaScannerConnectionClient#onMediaScannerConnected() will be called when the connection is established. </para>        
				/// </summary>
				/// <java-name>
				/// connect
				/// </java-name>
				[Dot42.DexImport("connect", "()V", AccessFlags = 1)]
				public virtual void Connect() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Releases the connection to the media scanner service. </para>        
				/// </summary>
				/// <java-name>
				/// disconnect
				/// </java-name>
				[Dot42.DexImport("disconnect", "()V", AccessFlags = 1)]
				public virtual void Disconnect() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Requests the media scanner to scan a file. Success or failure of the scanning operation cannot be determined until MediaScannerConnectionClient#onScanCompleted(String, Uri) is called.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// scanFile
				/// </java-name>
				[Dot42.DexImport("scanFile", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void ScanFile(string path, string mimeType) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Convenience for constructing a MediaScannerConnection, calling connect on it, and calling scanFile with the given  <b>path</b> and  <b>mimeType</b> when the connection is established.  <para>scanFile(String, String) </para></para>        
				/// </summary>
				/// <java-name>
				/// scanFile
				/// </java-name>
				[Dot42.DexImport("scanFile", "(Landroid/content/Context;[Ljava/lang/String;[Ljava/lang/String;Landroid/media/Me" +
    "diaScannerConnection$OnScanCompletedListener;)V", AccessFlags = 9)]
				public static void ScanFile(global::Android.Content.Context context, string[] paths, string[] mimeTypes, global::Android.Media.MediaScannerConnection.IOnScanCompletedListener callback) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Part of the ServiceConnection interface. Do not call. </para>        
				/// </summary>
				/// <java-name>
				/// onServiceConnected
				/// </java-name>
				[Dot42.DexImport("onServiceConnected", "(Landroid/content/ComponentName;Landroid/os/IBinder;)V", AccessFlags = 1)]
				public virtual void OnServiceConnected(global::Android.Content.ComponentName className, global::Android.OS.IBinder service) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Part of the ServiceConnection interface. Do not call. </para>        
				/// </summary>
				/// <java-name>
				/// onServiceDisconnected
				/// </java-name>
				[Dot42.DexImport("onServiceDisconnected", "(Landroid/content/ComponentName;)V", AccessFlags = 1)]
				public virtual void OnServiceDisconnected(global::Android.Content.ComponentName className) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal MediaScannerConnection() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Returns whether we are connected to the media scanner service </para>        
				/// </summary>
				/// <returns>
				///  <para>true if we are connected, false otherwise </para>
				/// </returns>
				/// <java-name>
				/// isConnected
				/// </java-name>
				public virtual bool IsConnected
				{
						[Dot42.DexImport("isConnected", "()Z", AccessFlags = 33)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>An interface for notifying clients of MediaScannerConnection when a connection to the MediaScanner service has been established and when the scanning of a file has completed. </para>    
				/// </summary>
				/// <java-name>
				/// android/media/MediaScannerConnection$MediaScannerConnectionClient
				/// </java-name>
				[Dot42.DexImport("android/media/MediaScannerConnection$MediaScannerConnectionClient", AccessFlags = 1545)]
				public partial interface IMediaScannerConnectionClient : global::Android.Media.MediaScannerConnection.IOnScanCompletedListener
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>Called to notify the client when a connection to the MediaScanner service has been established. </para>        
						/// </summary>
						/// <java-name>
						/// onMediaScannerConnected
						/// </java-name>
						[Dot42.DexImport("onMediaScannerConnected", "()V", AccessFlags = 1025)]
						void OnMediaScannerConnected() /* MethodBuilder.Create */ ;

						/// <summary>
						///  <para>Called to notify the client when the media scanner has finished scanning a file. </para>        
						/// </summary>
						/// <java-name>
						/// onScanCompleted
						/// </java-name>
						[Dot42.DexImport("onScanCompleted", "(Ljava/lang/String;Landroid/net/Uri;)V", AccessFlags = 1025)]
						void OnScanCompleted(string path, global::Android.Net.Uri uri) /* MethodBuilder.Create */ ;

				}

				/// <summary>
				///  <para>Interface for notifying clients of the result of scanning a requested media file. </para>    
				/// </summary>
				/// <java-name>
				/// android/media/MediaScannerConnection$OnScanCompletedListener
				/// </java-name>
				[Dot42.DexImport("android/media/MediaScannerConnection$OnScanCompletedListener", AccessFlags = 1545)]
				public partial interface IOnScanCompletedListener
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>Called to notify the client when the media scanner has finished scanning a file. </para>        
						/// </summary>
						/// <java-name>
						/// onScanCompleted
						/// </java-name>
						[Dot42.DexImport("onScanCompleted", "(Ljava/lang/String;Landroid/net/Uri;)V", AccessFlags = 1025)]
						void OnScanCompleted(string path, global::Android.Net.Uri uri) /* MethodBuilder.Create */ ;

				}

		}

		/// <summary>
		///  <para>Ringtone provides a quick method for playing a ringtone, notification, or other similar types of sounds. </para> <para>For ways of retrieving Ringtone objects or to show a ringtone picker, see RingtoneManager.</para> <para> <para>RingtoneManager </para></para>    
		/// </summary>
		/// <java-name>
		/// android/media/Ringtone
		/// </java-name>
		[Dot42.DexImport("android/media/Ringtone", AccessFlags = 33)]
		public partial class Ringtone
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal Ringtone() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns a human-presentable title for ringtone. Looks in media content provider. If not in either, uses the filename</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// getTitle
				/// </java-name>
				[Dot42.DexImport("getTitle", "(Landroid/content/Context;)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetTitle(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Plays the ringtone. </para>        
				/// </summary>
				/// <java-name>
				/// play
				/// </java-name>
				[Dot42.DexImport("play", "()V", AccessFlags = 1)]
				public virtual void Play() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Stops a playing ringtone. </para>        
				/// </summary>
				/// <java-name>
				/// stop
				/// </java-name>
				[Dot42.DexImport("stop", "()V", AccessFlags = 1)]
				public virtual void Stop() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Gets the stream type where this ringtone will be played.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The stream type, see AudioManager. </para>
				/// </returns>
				/// <java-name>
				/// getStreamType
				/// </java-name>
				public virtual int StreamType
				{
						[Dot42.DexImport("getStreamType", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setStreamType", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Whether this ringtone is currently playing.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>True if playing, false otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isPlaying
				/// </java-name>
				public virtual bool IsPlaying
				{
						[Dot42.DexImport("isPlaying", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

		}

		/// <summary>
		///  <para>RingtoneManager provides access to ringtones, notification, and other types of sounds. It manages querying the different media providers and combines the results into a single cursor. It also provides a Ringtone for each ringtone. We generically call these sounds ringtones, however the TYPE_RINGTONE refers to the type of sounds that are suitable for the phone ringer. </para> <para>To show a ringtone picker to the user, use the ACTION_RINGTONE_PICKER intent to launch the picker as a subactivity.</para> <para> <para>Ringtone </para></para>    
		/// </summary>
		/// <java-name>
		/// android/media/RingtoneManager
		/// </java-name>
		[Dot42.DexImport("android/media/RingtoneManager", AccessFlags = 33)]
		public partial class RingtoneManager
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Type that refers to sounds that are used for the phone ringer. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_RINGTONE
				/// </java-name>
				[Dot42.DexImport("TYPE_RINGTONE", "I", AccessFlags = 25)]
				public const int TYPE_RINGTONE = 1;
				/// <summary>
				///  <para>Type that refers to sounds that are used for notifications. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_NOTIFICATION
				/// </java-name>
				[Dot42.DexImport("TYPE_NOTIFICATION", "I", AccessFlags = 25)]
				public const int TYPE_NOTIFICATION = 2;
				/// <summary>
				///  <para>Type that refers to sounds that are used for the alarm. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_ALARM
				/// </java-name>
				[Dot42.DexImport("TYPE_ALARM", "I", AccessFlags = 25)]
				public const int TYPE_ALARM = 4;
				/// <summary>
				///  <para>All types of sounds. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_ALL
				/// </java-name>
				[Dot42.DexImport("TYPE_ALL", "I", AccessFlags = 25)]
				public const int TYPE_ALL = 7;
				/// <summary>
				///  <para>Activity Action: Shows a ringtone picker. </para> <para>Input: EXTRA_RINGTONE_EXISTING_URI, EXTRA_RINGTONE_SHOW_DEFAULT, EXTRA_RINGTONE_SHOW_SILENT, EXTRA_RINGTONE_TYPE, EXTRA_RINGTONE_DEFAULT_URI, EXTRA_RINGTONE_TITLE, </para> <para>Output: EXTRA_RINGTONE_PICKED_URI. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_RINGTONE_PICKER
				/// </java-name>
				[Dot42.DexImport("ACTION_RINGTONE_PICKER", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_RINGTONE_PICKER = "android.intent.action.RINGTONE_PICKER";
				/// <summary>
				///  <para>Given to the ringtone picker as a boolean. Whether to show an item for "Default".</para> <para> <para>ACTION_RINGTONE_PICKER </para></para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_RINGTONE_SHOW_DEFAULT
				/// </java-name>
				[Dot42.DexImport("EXTRA_RINGTONE_SHOW_DEFAULT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_RINGTONE_SHOW_DEFAULT = "android.intent.extra.ringtone.SHOW_DEFAULT";
				/// <summary>
				///  <para>Given to the ringtone picker as a boolean. Whether to show an item for "Silent". If the "Silent" item is picked, EXTRA_RINGTONE_PICKED_URI will be null.</para> <para> <para>ACTION_RINGTONE_PICKER </para></para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_RINGTONE_SHOW_SILENT
				/// </java-name>
				[Dot42.DexImport("EXTRA_RINGTONE_SHOW_SILENT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_RINGTONE_SHOW_SILENT = "android.intent.extra.ringtone.SHOW_SILENT";
				/// <summary>
				///  <para>Given to the ringtone picker as a boolean. Whether to include DRM ringtones.  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>DRM ringtones are no longer supported </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_RINGTONE_INCLUDE_DRM
				/// </java-name>
				[Dot42.DexImport("EXTRA_RINGTONE_INCLUDE_DRM", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_RINGTONE_INCLUDE_DRM = "android.intent.extra.ringtone.INCLUDE_DRM";
				/// <summary>
				///  <para>Given to the ringtone picker as a Uri. The Uri of the current ringtone, which will be used to show a checkmark next to the item for this Uri. If showing an item for "Default" ( <para>EXTRA_RINGTONE_SHOW_DEFAULT), this can also be one of System#DEFAULT_RINGTONE_URI, System#DEFAULT_NOTIFICATION_URI, or System#DEFAULT_ALARM_ALERT_URI to have the "Default" item checked.</para> <para>ACTION_RINGTONE_PICKER </para></para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_RINGTONE_EXISTING_URI
				/// </java-name>
				[Dot42.DexImport("EXTRA_RINGTONE_EXISTING_URI", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_RINGTONE_EXISTING_URI = "android.intent.extra.ringtone.EXISTING_URI";
				/// <summary>
				///  <para>Given to the ringtone picker as a Uri. The Uri of the ringtone to play when the user attempts to preview the "Default" ringtone. This can be one of System#DEFAULT_RINGTONE_URI, System#DEFAULT_NOTIFICATION_URI, or System#DEFAULT_ALARM_ALERT_URI to have the "Default" point to the current sound for the given default sound type. If you are showing a ringtone picker for some other type of sound, you are free to provide any Uri here. </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_RINGTONE_DEFAULT_URI
				/// </java-name>
				[Dot42.DexImport("EXTRA_RINGTONE_DEFAULT_URI", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_RINGTONE_DEFAULT_URI = "android.intent.extra.ringtone.DEFAULT_URI";
				/// <summary>
				///  <para>Given to the ringtone picker as an int. Specifies which ringtone type(s) should be shown in the picker. One or more of TYPE_RINGTONE, TYPE_NOTIFICATION, TYPE_ALARM, or TYPE_ALL (bitwise-ored together). </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_RINGTONE_TYPE
				/// </java-name>
				[Dot42.DexImport("EXTRA_RINGTONE_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_RINGTONE_TYPE = "android.intent.extra.ringtone.TYPE";
				/// <summary>
				///  <para>Given to the ringtone picker as a CharSequence. The title to show for the ringtone picker. This has a default value that is suitable in most cases. </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_RINGTONE_TITLE
				/// </java-name>
				[Dot42.DexImport("EXTRA_RINGTONE_TITLE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_RINGTONE_TITLE = "android.intent.extra.ringtone.TITLE";
				/// <summary>
				///  <para>Returned from the ringtone picker as a Uri. </para> <para>It will be one of:  the picked ringtone,  a Uri that equals System#DEFAULT_RINGTONE_URI, System#DEFAULT_NOTIFICATION_URI, or System#DEFAULT_ALARM_ALERT_URI if the default was chosen,  null if the "Silent" item was picked.</para> <para> <para>ACTION_RINGTONE_PICKER </para></para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_RINGTONE_PICKED_URI
				/// </java-name>
				[Dot42.DexImport("EXTRA_RINGTONE_PICKED_URI", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_RINGTONE_PICKED_URI = "android.intent.extra.ringtone.PICKED_URI";
				/// <summary>
				///  <para>The column index (in the cursor returned by getCursor() for the row ID. </para>        
				/// </summary>
				/// <java-name>
				/// ID_COLUMN_INDEX
				/// </java-name>
				[Dot42.DexImport("ID_COLUMN_INDEX", "I", AccessFlags = 25)]
				public const int ID_COLUMN_INDEX = 0;
				/// <summary>
				///  <para>The column index (in the cursor returned by getCursor() for the title. </para>        
				/// </summary>
				/// <java-name>
				/// TITLE_COLUMN_INDEX
				/// </java-name>
				[Dot42.DexImport("TITLE_COLUMN_INDEX", "I", AccessFlags = 25)]
				public const int TITLE_COLUMN_INDEX = 1;
				/// <summary>
				///  <para>The column index (in the cursor returned by getCursor() for the media provider's URI. </para>        
				/// </summary>
				/// <java-name>
				/// URI_COLUMN_INDEX
				/// </java-name>
				[Dot42.DexImport("URI_COLUMN_INDEX", "I", AccessFlags = 25)]
				public const int URI_COLUMN_INDEX = 2;
				/// <summary>
				///  <para>Constructs a RingtoneManager. This constructor is recommended as its constructed instance manages cursor(s).</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/app/Activity;)V", AccessFlags = 1)]
				public RingtoneManager(global::Android.App.Activity activity) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a RingtoneManager. This constructor is recommended as its constructed instance manages cursor(s).</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public RingtoneManager(global::Android.Content.Context activity) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets which type(s) of ringtones will be listed by this.</para> <para> <para>EXTRA_RINGTONE_TYPE </para></para>        
				/// </summary>
				/// <java-name>
				/// setType
				/// </java-name>
				[Dot42.DexImport("setType", "(I)V", AccessFlags = 1)]
				public virtual void SetType(int type) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Infers the playback stream type based on what type of ringtones this manager is returning.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The stream type. </para>
				/// </returns>
				/// <java-name>
				/// inferStreamType
				/// </java-name>
				[Dot42.DexImport("inferStreamType", "()I", AccessFlags = 1)]
				public virtual int InferStreamType() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Whether retrieving another Ringtone will stop playing the previously retrieved Ringtone. </para> <para>If this is false, make sure to Ringtone#stop() any previous ringtones to free resources.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setStopPreviousRingtone
				/// </java-name>
				[Dot42.DexImport("setStopPreviousRingtone", "(Z)V", AccessFlags = 1)]
				public virtual void SetStopPreviousRingtone(bool stopPreviousRingtone) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para> <para>setStopPreviousRingtone(boolean) </para></para>        
				/// </summary>
				/// <java-name>
				/// getStopPreviousRingtone
				/// </java-name>
				[Dot42.DexImport("getStopPreviousRingtone", "()Z", AccessFlags = 1)]
				public virtual bool GetStopPreviousRingtone() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Stops playing the last Ringtone retrieved from this. </para>        
				/// </summary>
				/// <java-name>
				/// stopPreviousRingtone
				/// </java-name>
				[Dot42.DexImport("stopPreviousRingtone", "()V", AccessFlags = 1)]
				public virtual void StopPreviousRingtone() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Gets a Ringtone for the ringtone at the given position in the Cursor.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>A Ringtone pointing to the ringtone. </para>
				/// </returns>
				/// <java-name>
				/// getRingtone
				/// </java-name>
				[Dot42.DexImport("getRingtone", "(I)Landroid/media/Ringtone;", AccessFlags = 1)]
				public virtual global::Android.Media.Ringtone GetRingtone(int position) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Media.Ringtone);
				}

				/// <summary>
				///  <para>Gets a Uri for the ringtone at the given position in the Cursor.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>A Uri pointing to the ringtone. </para>
				/// </returns>
				/// <java-name>
				/// getRingtoneUri
				/// </java-name>
				[Dot42.DexImport("getRingtoneUri", "(I)Landroid/net/Uri;", AccessFlags = 1)]
				public virtual global::Android.Net.Uri GetRingtoneUri(int position) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Net.Uri);
				}

				/// <summary>
				///  <para>Gets the position of a Uri within this RingtoneManager.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The position of the Uri, or -1 if it cannot be found. </para>
				/// </returns>
				/// <java-name>
				/// getRingtonePosition
				/// </java-name>
				[Dot42.DexImport("getRingtonePosition", "(Landroid/net/Uri;)I", AccessFlags = 1)]
				public virtual int GetRingtonePosition(global::Android.Net.Uri ringtoneUri) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Returns a valid ringtone URI. No guarantees on which it returns. If it cannot find one, returns null.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>A ringtone URI, or null if one cannot be found. </para>
				/// </returns>
				/// <java-name>
				/// getValidRingtoneUri
				/// </java-name>
				[Dot42.DexImport("getValidRingtoneUri", "(Landroid/content/Context;)Landroid/net/Uri;", AccessFlags = 9)]
				public static global::Android.Net.Uri GetValidRingtoneUri(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Net.Uri);
				}

				/// <summary>
				///  <para>Returns a Ringtone for a given sound URI. </para> <para>If the given URI cannot be opened for any reason, this method will attempt to fallback on another sound. If it cannot find any, it will return null.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>A Ringtone for the given URI, or null. </para>
				/// </returns>
				/// <java-name>
				/// getRingtone
				/// </java-name>
				[Dot42.DexImport("getRingtone", "(Landroid/content/Context;Landroid/net/Uri;)Landroid/media/Ringtone;", AccessFlags = 9)]
				public static global::Android.Media.Ringtone GetRingtone(global::Android.Content.Context context, global::Android.Net.Uri ringtoneUri) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Media.Ringtone);
				}

				/// <summary>
				///  <para>Gets the current default sound's Uri. This will give the actual sound Uri, instead of using this, most clients can use System#DEFAULT_RINGTONE_URI.</para> <para> <para>setActualDefaultRingtoneUri(Context, int, Uri) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>A Uri pointing to the default sound for the sound type. </para>
				/// </returns>
				/// <java-name>
				/// getActualDefaultRingtoneUri
				/// </java-name>
				[Dot42.DexImport("getActualDefaultRingtoneUri", "(Landroid/content/Context;I)Landroid/net/Uri;", AccessFlags = 9)]
				public static global::Android.Net.Uri GetActualDefaultRingtoneUri(global::Android.Content.Context context, int type) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Net.Uri);
				}

				/// <summary>
				///  <para>Sets the Uri of the default sound for a given sound type.</para> <para> <para>getActualDefaultRingtoneUri(Context, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// setActualDefaultRingtoneUri
				/// </java-name>
				[Dot42.DexImport("setActualDefaultRingtoneUri", "(Landroid/content/Context;ILandroid/net/Uri;)V", AccessFlags = 9)]
				public static void SetActualDefaultRingtoneUri(global::Android.Content.Context context, int type, global::Android.Net.Uri ringtoneUri) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns whether the given Uri is one of the default ringtones.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Whether the Uri is a default. </para>
				/// </returns>
				/// <java-name>
				/// isDefault
				/// </java-name>
				[Dot42.DexImport("isDefault", "(Landroid/net/Uri;)Z", AccessFlags = 9)]
				public static bool IsDefault(global::Android.Net.Uri ringtoneUri) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Returns the type of a default Uri.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The type of the defaultRingtoneUri, or -1. </para>
				/// </returns>
				/// <java-name>
				/// getDefaultType
				/// </java-name>
				[Dot42.DexImport("getDefaultType", "(Landroid/net/Uri;)I", AccessFlags = 9)]
				public static int GetDefaultType(global::Android.Net.Uri defaultRingtoneUri) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Returns the Uri for the default ringtone of a particular type. Rather than returning the actual ringtone's sound Uri, this will return the symbolic Uri which will resolved to the actual sound when played.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The Uri of the default ringtone for the given type. </para>
				/// </returns>
				/// <java-name>
				/// getDefaultUri
				/// </java-name>
				[Dot42.DexImport("getDefaultUri", "(I)Landroid/net/Uri;", AccessFlags = 9)]
				public static global::Android.Net.Uri GetDefaultUri(int type) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Net.Uri);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal RingtoneManager() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Returns whether DRM ringtones will be included.</para> <para> <para>setIncludeDrm(boolean) Obsolete - always returns false </para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>DRM ringtones are no longer supported </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				///  <para>Whether DRM ringtones will be included. </para>
				/// </returns>
				/// <java-name>
				/// getIncludeDrm
				/// </java-name>
				public virtual bool IncludeDrm
				{
						[Dot42.DexImport("getIncludeDrm", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setIncludeDrm", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Returns a Cursor of all the ringtones available. The returned cursor will be the same cursor returned each time this method is called, so do not Cursor#close() the cursor. The cursor can be Cursor#deactivate() safely. </para> <para>If RingtoneManager#RingtoneManager(Activity) was not used, the caller should manage the returned cursor through its activity's life cycle to prevent leaking the cursor.</para> <para> <para>ID_COLUMN_INDEX </para> <para>TITLE_COLUMN_INDEX </para> <para>URI_COLUMN_INDEX </para></para>        
				/// </summary>
				/// <returns>
				///  <para>A Cursor of all the ringtones available. </para>
				/// </returns>
				/// <java-name>
				/// getCursor
				/// </java-name>
				public virtual global::Android.Database.ICursor Cursor
				{
						[Dot42.DexImport("getCursor", "()Landroid/database/Cursor;", AccessFlags = 1)]
						get{ return default(global::Android.Database.ICursor); }
				}

		}

		/// <summary>
		///  <para>The SoundPool class manages and plays audio resources for applications.</para> <para>A SoundPool is a collection of samples that can be loaded into memory from a resource inside the APK or from a file in the file system. The SoundPool library uses the MediaPlayer service to decode the audio into a raw 16-bit PCM mono or stereo stream. This allows applications to ship with compressed streams without having to suffer the CPU load and latency of decompressing during playback.</para> <para>In addition to low-latency playback, SoundPool can also manage the number of audio streams being rendered at once. When the SoundPool object is constructed, the maxStreams parameter sets the maximum number of streams that can be played at a time from this single SoundPool. SoundPool tracks the number of active streams. If the maximum number of streams is exceeded, SoundPool will automatically stop a previously playing stream based first on priority and then by age within that priority. Limiting the maximum number of streams helps to cap CPU loading and reducing the likelihood that audio mixing will impact visuals or UI performance.</para> <para>Sounds can be looped by setting a non-zero loop value. A value of -1 causes the sound to loop forever. In this case, the application must explicitly call the stop() function to stop the sound. Any other non-zero value will cause the sound to repeat the specified number of times, e.g. a value of 3 causes the sound to play a total of 4 times.</para> <para>The playback rate can also be changed. A playback rate of 1.0 causes the sound to play at its original frequency (resampled, if necessary, to the hardware output frequency). A playback rate of 2.0 causes the sound to play at twice its original frequency, and a playback rate of 0.5 causes it to play at half its original frequency. The playback rate range is 0.5 to 2.0.</para> <para>Priority runs low to high, i.e. higher numbers are higher priority. Priority is used when a call to play() would cause the number of active streams to exceed the value established by the maxStreams parameter when the SoundPool was created. In this case, the stream allocator will stop the lowest priority stream. If there are multiple streams with the same low priority, it will choose the oldest stream to stop. In the case where the priority of the new stream is lower than all the active streams, the new sound will not play and the play() function will return a streamID of zero.</para> <para>Let's examine a typical use case: A game consists of several levels of play. For each level, there is a set of unique sounds that are used only by that level. In this case, the game logic should create a new SoundPool object when the first level is loaded. The level data itself might contain the list of sounds to be used by this level. The loading logic iterates through the list of sounds calling the appropriate SoundPool.load() function. This should typically be done early in the process to allow time for decompressing the audio to raw PCM format before they are needed for playback.</para> <para>Once the sounds are loaded and play has started, the application can trigger sounds by calling SoundPool.play(). Playing streams can be paused or resumed, and the application can also alter the pitch by adjusting the playback rate in real-time for doppler or synthesis effects.</para> <para>Note that since streams can be stopped due to resource constraints, the streamID is a reference to a particular instance of a stream. If the stream is stopped to allow a higher priority stream to play, the stream is no longer be valid. However, the application is allowed to call methods on the streamID without error. This may help simplify program logic since the application need not concern itself with the stream lifecycle.</para> <para>In our example, when the player has completed the level, the game logic should call SoundPool.release() to release all the native resources in use and then set the SoundPool reference to null. If the player starts another level, a new SoundPool is created, sounds are loaded, and play resumes.</para>    
		/// </summary>
		/// <java-name>
		/// android/media/SoundPool
		/// </java-name>
		[Dot42.DexImport("android/media/SoundPool", AccessFlags = 33)]
		public partial class SoundPool
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructor. Constructs a SoundPool object with the following characteristics:</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a SoundPool object, or null if creation failed </para>
				/// </returns>
				[Dot42.DexImport("<init>", "(III)V", AccessFlags = 1)]
				public SoundPool(int maxStreams, int streamType, int srcQuality) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Load the sound from an asset file descriptor.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a sound ID. This value can be used to play or unload the sound. </para>
				/// </returns>
				/// <java-name>
				/// load
				/// </java-name>
				[Dot42.DexImport("load", "(Ljava/lang/String;I)I", AccessFlags = 1)]
				public virtual int Load(string afd, int priority) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Load the sound from the specified APK resource.</para> <para>Note that the extension is dropped. For example, if you want to load a sound from the raw resource file "explosion.mp3", you would specify "R.raw.explosion" as the resource ID. Note that this means you cannot have both an "explosion.wav" and an "explosion.mp3" in the res/raw directory.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a sound ID. This value can be used to play or unload the sound. </para>
				/// </returns>
				/// <java-name>
				/// load
				/// </java-name>
				[Dot42.DexImport("load", "(Landroid/content/Context;II)I", AccessFlags = 1)]
				public virtual int Load(global::Android.Content.Context context, int resId, int priority) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Load the sound from an asset file descriptor.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a sound ID. This value can be used to play or unload the sound. </para>
				/// </returns>
				/// <java-name>
				/// load
				/// </java-name>
				[Dot42.DexImport("load", "(Landroid/content/res/AssetFileDescriptor;I)I", AccessFlags = 1)]
				public virtual int Load(global::Android.Content.Res.AssetFileDescriptor afd, int priority) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Load the sound from a FileDescriptor.</para> <para>This version is useful if you store multiple sounds in a single binary. The offset specifies the offset from the start of the file and the length specifies the length of the sound within the file.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a sound ID. This value can be used to play or unload the sound. </para>
				/// </returns>
				/// <java-name>
				/// load
				/// </java-name>
				[Dot42.DexImport("load", "(Ljava/io/FileDescriptor;JJI)I", AccessFlags = 1)]
				public virtual int Load(global::Java.IO.FileDescriptor fd, long offset, long length, int priority) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Unload a sound from a sound ID.</para> <para>Unloads the sound specified by the soundID. This is the value returned by the load() function. Returns true if the sound is successfully unloaded, false if the sound was already unloaded.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if just unloaded, false if previously unloaded </para>
				/// </returns>
				/// <java-name>
				/// unload
				/// </java-name>
				[Dot42.DexImport("unload", "(I)Z", AccessFlags = 273)]
				public bool Unload(int soundID) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Play a sound from a sound ID.</para> <para>Play the sound specified by the soundID. This is the value returned by the load() function. Returns a non-zero streamID if successful, zero if it fails. The streamID can be used to further control playback. Note that calling play() may cause another sound to stop playing if the maximum number of active streams is exceeded. A loop value of -1 means loop forever, a value of 0 means don't loop, other values indicate the number of repeats, e.g. a value of 1 plays the audio twice. The playback rate allows the application to vary the playback rate (pitch) of the sound. A value of 1.0 means play back at the original frequency. A value of 2.0 means play back twice as fast, and a value of 0.5 means playback at half speed.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>non-zero streamID if successful, zero if failed </para>
				/// </returns>
				/// <java-name>
				/// play
				/// </java-name>
				[Dot42.DexImport("play", "(IFFIIF)I", AccessFlags = 273)]
				public int Play(int soundID, float leftVolume, float rightVolume, int priority, int loop, float rate) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Pause a playback stream.</para> <para>Pause the stream specified by the streamID. This is the value returned by the play() function. If the stream is playing, it will be paused. If the stream is not playing (e.g. is stopped or was previously paused), calling this function will have no effect.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// pause
				/// </java-name>
				[Dot42.DexImport("pause", "(I)V", AccessFlags = 273)]
				public void Pause(int streamID) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Resume a playback stream.</para> <para>Resume the stream specified by the streamID. This is the value returned by the play() function. If the stream is paused, this will resume playback. If the stream was not previously paused, calling this function will have no effect.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// resume
				/// </java-name>
				[Dot42.DexImport("resume", "(I)V", AccessFlags = 273)]
				public void Resume(int streamID) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Pause all active streams.</para> <para>Pause all streams that are currently playing. This function iterates through all the active streams and pauses any that are playing. It also sets a flag so that any streams that are playing can be resumed by calling autoResume(). </para>        
				/// </summary>
				/// <java-name>
				/// autoPause
				/// </java-name>
				[Dot42.DexImport("autoPause", "()V", AccessFlags = 273)]
				public void AutoPause() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Resume all previously active streams.</para> <para>Automatically resumes all streams that were paused in previous calls to autoPause(). </para>        
				/// </summary>
				/// <java-name>
				/// autoResume
				/// </java-name>
				[Dot42.DexImport("autoResume", "()V", AccessFlags = 273)]
				public void AutoResume() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Stop a playback stream.</para> <para>Stop the stream specified by the streamID. This is the value returned by the play() function. If the stream is playing, it will be stopped. It also releases any native resources associated with this stream. If the stream is not playing, it will have no effect.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// stop
				/// </java-name>
				[Dot42.DexImport("stop", "(I)V", AccessFlags = 273)]
				public void Stop(int streamID) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Set stream volume.</para> <para>Sets the volume on the stream specified by the streamID. This is the value returned by the play() function. The value must be in the range of 0.0 to 1.0. If the stream does not exist, it will have no effect.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setVolume
				/// </java-name>
				[Dot42.DexImport("setVolume", "(IFF)V", AccessFlags = 273)]
				public void SetVolume(int streamID, float leftVolume, float rightVolume) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Change stream priority.</para> <para>Change the priority of the stream specified by the streamID. This is the value returned by the play() function. Affects the order in which streams are re-used to play new sounds. If the stream does not exist, it will have no effect.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setPriority
				/// </java-name>
				[Dot42.DexImport("setPriority", "(II)V", AccessFlags = 273)]
				public void SetPriority(int streamID, int priority) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Set loop mode.</para> <para>Change the loop mode. A loop value of -1 means loop forever, a value of 0 means don't loop, other values indicate the number of repeats, e.g. a value of 1 plays the audio twice. If the stream does not exist, it will have no effect.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setLoop
				/// </java-name>
				[Dot42.DexImport("setLoop", "(II)V", AccessFlags = 273)]
				public void SetLoop(int streamID, int loop) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Change playback rate.</para> <para>The playback rate allows the application to vary the playback rate (pitch) of the sound. A value of 1.0 means playback at the original frequency. A value of 2.0 means playback twice as fast, and a value of 0.5 means playback at half speed. If the stream does not exist, it will have no effect.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setRate
				/// </java-name>
				[Dot42.DexImport("setRate", "(IF)V", AccessFlags = 273)]
				public void SetRate(int streamID, float rate) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the callback hook for the OnLoadCompleteListener. </para>        
				/// </summary>
				/// <java-name>
				/// setOnLoadCompleteListener
				/// </java-name>
				[Dot42.DexImport("setOnLoadCompleteListener", "(Landroid/media/SoundPool$OnLoadCompleteListener;)V", AccessFlags = 1)]
				public virtual void SetOnLoadCompleteListener(global::Android.Media.SoundPool.IOnLoadCompleteListener listener) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Release the SoundPool resources.</para> <para>Release all memory and native resources used by the SoundPool object. The SoundPool can no longer be used and the reference should be set to null. </para>        
				/// </summary>
				/// <java-name>
				/// release
				/// </java-name>
				[Dot42.DexImport("release", "()V", AccessFlags = 273)]
				public void Release() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// finalize
				/// </java-name>
				[Dot42.DexImport("finalize", "()V", AccessFlags = 4)]
				extern ~SoundPool() /* MethodBuilder.Create */ ;

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal SoundPool() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// android/media/SoundPool$OnLoadCompleteListener
				/// </java-name>
				[Dot42.DexImport("android/media/SoundPool$OnLoadCompleteListener", AccessFlags = 1545)]
				public partial interface IOnLoadCompleteListener
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>Called when a sound has completed loading.</para> <para></para>        
						/// </summary>
						/// <java-name>
						/// onLoadComplete
						/// </java-name>
						[Dot42.DexImport("onLoadComplete", "(Landroid/media/SoundPool;II)V", AccessFlags = 1025)]
						void OnLoadComplete(global::Android.Media.SoundPool soundPool, int sampleId, int status) /* MethodBuilder.Create */ ;

				}

		}

		/// <summary>
		///  <para>Thumbnail generation routines for media provider. </para>    
		/// </summary>
		/// <java-name>
		/// android/media/ThumbnailUtils
		/// </java-name>
		[Dot42.DexImport("android/media/ThumbnailUtils", AccessFlags = 33)]
		public partial class ThumbnailUtils
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constant used to indicate we should recycle the input in extractThumbnail(Bitmap, int, int, int) unless the output is the input. </para>        
				/// </summary>
				/// <java-name>
				/// OPTIONS_RECYCLE_INPUT
				/// </java-name>
				[Dot42.DexImport("OPTIONS_RECYCLE_INPUT", "I", AccessFlags = 25)]
				public const int OPTIONS_RECYCLE_INPUT = 2;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ThumbnailUtils() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Create a video thumbnail for a video. May return null if the video is corrupt or the format is not supported.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// createVideoThumbnail
				/// </java-name>
				[Dot42.DexImport("createVideoThumbnail", "(Ljava/lang/String;I)Landroid/graphics/Bitmap;", AccessFlags = 9)]
				public static global::Android.Graphics.Bitmap CreateVideoThumbnail(string filePath, int kind) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Bitmap);
				}

				/// <summary>
				///  <para>Creates a centered bitmap of the desired size.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// extractThumbnail
				/// </java-name>
				[Dot42.DexImport("extractThumbnail", "(Landroid/graphics/Bitmap;II)Landroid/graphics/Bitmap;", AccessFlags = 9)]
				public static global::Android.Graphics.Bitmap ExtractThumbnail(global::Android.Graphics.Bitmap source, int width, int height) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Bitmap);
				}

				/// <summary>
				///  <para>Creates a centered bitmap of the desired size.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// extractThumbnail
				/// </java-name>
				[Dot42.DexImport("extractThumbnail", "(Landroid/graphics/Bitmap;III)Landroid/graphics/Bitmap;", AccessFlags = 9)]
				public static global::Android.Graphics.Bitmap ExtractThumbnail(global::Android.Graphics.Bitmap source, int width, int height, int options) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Bitmap);
				}

		}

		/// <summary>
		///  <para>This class provides methods to play DTMF tones (ITU-T Recommendation Q.23), call supervisory tones (3GPP TS 22.001, CEPT) and proprietary tones (3GPP TS 31.111). Depending on call state and routing options, tones are mixed to the downlink audio or output to the speaker phone or headset. This API is not for generating tones over the uplink audio path. </para>    
		/// </summary>
		/// <java-name>
		/// android/media/ToneGenerator
		/// </java-name>
		[Dot42.DexImport("android/media/ToneGenerator", AccessFlags = 33)]
		public partial class ToneGenerator
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>DTMF tone for key 0: 1336Hz, 941Hz, continuous</para> <para> <para>ToneGenerator(int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// TONE_DTMF_0
				/// </java-name>
				[Dot42.DexImport("TONE_DTMF_0", "I", AccessFlags = 25)]
				public const int TONE_DTMF_0 = 0;
				/// <summary>
				///  <para>DTMF tone for key 1: 1209Hz, 697Hz, continuous</para> <para> <para>ToneGenerator(int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// TONE_DTMF_1
				/// </java-name>
				[Dot42.DexImport("TONE_DTMF_1", "I", AccessFlags = 25)]
				public const int TONE_DTMF_1 = 1;
				/// <summary>
				///  <para>DTMF tone for key 2: 1336Hz, 697Hz, continuous</para> <para> <para>ToneGenerator(int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// TONE_DTMF_2
				/// </java-name>
				[Dot42.DexImport("TONE_DTMF_2", "I", AccessFlags = 25)]
				public const int TONE_DTMF_2 = 2;
				/// <summary>
				///  <para>DTMF tone for key 3: 1477Hz, 697Hz, continuous</para> <para> <para>ToneGenerator(int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// TONE_DTMF_3
				/// </java-name>
				[Dot42.DexImport("TONE_DTMF_3", "I", AccessFlags = 25)]
				public const int TONE_DTMF_3 = 3;
				/// <summary>
				///  <para>DTMF tone for key 4: 1209Hz, 770Hz, continuous</para> <para> <para>ToneGenerator(int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// TONE_DTMF_4
				/// </java-name>
				[Dot42.DexImport("TONE_DTMF_4", "I", AccessFlags = 25)]
				public const int TONE_DTMF_4 = 4;
				/// <summary>
				///  <para>DTMF tone for key 5: 1336Hz, 770Hz, continuous</para> <para> <para>ToneGenerator(int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// TONE_DTMF_5
				/// </java-name>
				[Dot42.DexImport("TONE_DTMF_5", "I", AccessFlags = 25)]
				public const int TONE_DTMF_5 = 5;
				/// <summary>
				///  <para>DTMF tone for key 6: 1477Hz, 770Hz, continuous</para> <para> <para>ToneGenerator(int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// TONE_DTMF_6
				/// </java-name>
				[Dot42.DexImport("TONE_DTMF_6", "I", AccessFlags = 25)]
				public const int TONE_DTMF_6 = 6;
				/// <summary>
				///  <para>DTMF tone for key 7: 1209Hz, 852Hz, continuous</para> <para> <para>ToneGenerator(int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// TONE_DTMF_7
				/// </java-name>
				[Dot42.DexImport("TONE_DTMF_7", "I", AccessFlags = 25)]
				public const int TONE_DTMF_7 = 7;
				/// <summary>
				///  <para>DTMF tone for key 8: 1336Hz, 852Hz, continuous</para> <para> <para>ToneGenerator(int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// TONE_DTMF_8
				/// </java-name>
				[Dot42.DexImport("TONE_DTMF_8", "I", AccessFlags = 25)]
				public const int TONE_DTMF_8 = 8;
				/// <summary>
				///  <para>DTMF tone for key 9: 1477Hz, 852Hz, continuous</para> <para> <para>ToneGenerator(int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// TONE_DTMF_9
				/// </java-name>
				[Dot42.DexImport("TONE_DTMF_9", "I", AccessFlags = 25)]
				public const int TONE_DTMF_9 = 9;
				/// <summary>
				///  <para>DTMF tone for key *: 1209Hz, 941Hz, continuous</para> <para> <para>ToneGenerator(int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// TONE_DTMF_S
				/// </java-name>
				[Dot42.DexImport("TONE_DTMF_S", "I", AccessFlags = 25)]
				public const int TONE_DTMF_S = 10;
				/// <summary>
				///  <para>DTMF tone for key #: 1477Hz, 941Hz, continuous</para> <para> <para>ToneGenerator(int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// TONE_DTMF_P
				/// </java-name>
				[Dot42.DexImport("TONE_DTMF_P", "I", AccessFlags = 25)]
				public const int TONE_DTMF_P = 11;
				/// <summary>
				///  <para>DTMF tone for key A: 1633Hz, 697Hz, continuous</para> <para> <para>ToneGenerator(int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// TONE_DTMF_A
				/// </java-name>
				[Dot42.DexImport("TONE_DTMF_A", "I", AccessFlags = 25)]
				public const int TONE_DTMF_A = 12;
				/// <summary>
				///  <para>DTMF tone for key B: 1633Hz, 770Hz, continuous</para> <para> <para>ToneGenerator(int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// TONE_DTMF_B
				/// </java-name>
				[Dot42.DexImport("TONE_DTMF_B", "I", AccessFlags = 25)]
				public const int TONE_DTMF_B = 13;
				/// <summary>
				///  <para>DTMF tone for key C: 1633Hz, 852Hz, continuous</para> <para> <para>ToneGenerator(int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// TONE_DTMF_C
				/// </java-name>
				[Dot42.DexImport("TONE_DTMF_C", "I", AccessFlags = 25)]
				public const int TONE_DTMF_C = 14;
				/// <summary>
				///  <para>DTMF tone for key D: 1633Hz, 941Hz, continuous</para> <para> <para>ToneGenerator(int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// TONE_DTMF_D
				/// </java-name>
				[Dot42.DexImport("TONE_DTMF_D", "I", AccessFlags = 25)]
				public const int TONE_DTMF_D = 15;
				/// <summary>
				///  <para>Call supervisory tone, Dial tone: CEPT: 425Hz, continuous ANSI (IS-95): 350Hz+440Hz, continuous JAPAN: 400Hz, continuous</para> <para> <para>ToneGenerator(int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// TONE_SUP_DIAL
				/// </java-name>
				[Dot42.DexImport("TONE_SUP_DIAL", "I", AccessFlags = 25)]
				public const int TONE_SUP_DIAL = 16;
				/// <summary>
				///  <para>Call supervisory tone, Busy: CEPT: 425Hz, 500ms ON, 500ms OFF... ANSI (IS-95): 480Hz+620Hz, 500ms ON, 500ms OFF... JAPAN: 400Hz, 500ms ON, 500ms OFF...</para> <para> <para>ToneGenerator(int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// TONE_SUP_BUSY
				/// </java-name>
				[Dot42.DexImport("TONE_SUP_BUSY", "I", AccessFlags = 25)]
				public const int TONE_SUP_BUSY = 17;
				/// <summary>
				///  <para>Call supervisory tone, Congestion: CEPT, JAPAN: 425Hz, 200ms ON, 200ms OFF... ANSI (IS-95): 480Hz+620Hz, 250ms ON, 250ms OFF...</para> <para> <para>ToneGenerator(int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// TONE_SUP_CONGESTION
				/// </java-name>
				[Dot42.DexImport("TONE_SUP_CONGESTION", "I", AccessFlags = 25)]
				public const int TONE_SUP_CONGESTION = 18;
				/// <summary>
				///  <para>Call supervisory tone, Radio path acknowlegment : CEPT, ANSI: 425Hz, 200ms ON JAPAN: 400Hz, 1s ON, 2s OFF...</para> <para> <para>ToneGenerator(int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// TONE_SUP_RADIO_ACK
				/// </java-name>
				[Dot42.DexImport("TONE_SUP_RADIO_ACK", "I", AccessFlags = 25)]
				public const int TONE_SUP_RADIO_ACK = 19;
				/// <summary>
				///  <para>Call supervisory tone, Radio path not available: 425Hz, 200ms ON, 200 OFF 3 bursts</para> <para> <para>ToneGenerator(int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// TONE_SUP_RADIO_NOTAVAIL
				/// </java-name>
				[Dot42.DexImport("TONE_SUP_RADIO_NOTAVAIL", "I", AccessFlags = 25)]
				public const int TONE_SUP_RADIO_NOTAVAIL = 20;
				/// <summary>
				///  <para>Call supervisory tone, Error/Special info: 950Hz+1400Hz+1800Hz, 330ms ON, 1s OFF...</para> <para> <para>ToneGenerator(int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// TONE_SUP_ERROR
				/// </java-name>
				[Dot42.DexImport("TONE_SUP_ERROR", "I", AccessFlags = 25)]
				public const int TONE_SUP_ERROR = 21;
				/// <summary>
				///  <para>Call supervisory tone, Call Waiting: CEPT, JAPAN: 425Hz, 200ms ON, 600ms OFF, 200ms ON, 3s OFF... ANSI (IS-95): 440 Hz, 300 ms ON, 9.7 s OFF, (100 ms ON, 100 ms OFF, 100 ms ON, 9.7s OFF ...)</para> <para> <para>ToneGenerator(int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// TONE_SUP_CALL_WAITING
				/// </java-name>
				[Dot42.DexImport("TONE_SUP_CALL_WAITING", "I", AccessFlags = 25)]
				public const int TONE_SUP_CALL_WAITING = 22;
				/// <summary>
				///  <para>Call supervisory tone, Ring Tone: CEPT, JAPAN: 425Hz, 1s ON, 4s OFF... ANSI (IS-95): 440Hz + 480Hz, 2s ON, 4s OFF...</para> <para> <para>ToneGenerator(int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// TONE_SUP_RINGTONE
				/// </java-name>
				[Dot42.DexImport("TONE_SUP_RINGTONE", "I", AccessFlags = 25)]
				public const int TONE_SUP_RINGTONE = 23;
				/// <summary>
				///  <para>Proprietary tone, general beep: 400Hz+1200Hz, 35ms ON</para> <para> <para>ToneGenerator(int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// TONE_PROP_BEEP
				/// </java-name>
				[Dot42.DexImport("TONE_PROP_BEEP", "I", AccessFlags = 25)]
				public const int TONE_PROP_BEEP = 24;
				/// <summary>
				///  <para>Proprietary tone, positive acknowlegement: 1200Hz, 100ms ON, 100ms OFF 2 bursts</para> <para> <para>ToneGenerator(int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// TONE_PROP_ACK
				/// </java-name>
				[Dot42.DexImport("TONE_PROP_ACK", "I", AccessFlags = 25)]
				public const int TONE_PROP_ACK = 25;
				/// <summary>
				///  <para>Proprietary tone, negative acknowlegement: 300Hz+400Hz+500Hz, 400ms ON</para> <para> <para>ToneGenerator(int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// TONE_PROP_NACK
				/// </java-name>
				[Dot42.DexImport("TONE_PROP_NACK", "I", AccessFlags = 25)]
				public const int TONE_PROP_NACK = 26;
				/// <summary>
				///  <para>Proprietary tone, prompt tone: 400Hz+1200Hz, 200ms ON</para> <para> <para>ToneGenerator(int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// TONE_PROP_PROMPT
				/// </java-name>
				[Dot42.DexImport("TONE_PROP_PROMPT", "I", AccessFlags = 25)]
				public const int TONE_PROP_PROMPT = 27;
				/// <summary>
				///  <para>Proprietary tone, general double beep: twice 400Hz+1200Hz, 35ms ON, 200ms OFF, 35ms ON</para> <para> <para>ToneGenerator(int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// TONE_PROP_BEEP2
				/// </java-name>
				[Dot42.DexImport("TONE_PROP_BEEP2", "I", AccessFlags = 25)]
				public const int TONE_PROP_BEEP2 = 28;
				/// <summary>
				///  <para>Call supervisory tone (IS-95), intercept tone: alternating 440 Hz and 620 Hz tones, each on for 250 ms</para> <para> <para>ToneGenerator(int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// TONE_SUP_INTERCEPT
				/// </java-name>
				[Dot42.DexImport("TONE_SUP_INTERCEPT", "I", AccessFlags = 25)]
				public const int TONE_SUP_INTERCEPT = 29;
				/// <summary>
				///  <para>Call supervisory tone (IS-95), abbreviated intercept: intercept tone limited to 4 seconds</para> <para> <para>ToneGenerator(int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// TONE_SUP_INTERCEPT_ABBREV
				/// </java-name>
				[Dot42.DexImport("TONE_SUP_INTERCEPT_ABBREV", "I", AccessFlags = 25)]
				public const int TONE_SUP_INTERCEPT_ABBREV = 30;
				/// <summary>
				///  <para>Call supervisory tone (IS-95), abbreviated congestion: congestion tone limited to 4 seconds</para> <para> <para>ToneGenerator(int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// TONE_SUP_CONGESTION_ABBREV
				/// </java-name>
				[Dot42.DexImport("TONE_SUP_CONGESTION_ABBREV", "I", AccessFlags = 25)]
				public const int TONE_SUP_CONGESTION_ABBREV = 31;
				/// <summary>
				///  <para>Call supervisory tone (IS-95), confirm tone: a 350 Hz tone added to a 440 Hz tone repeated 3 times in a 100 ms on, 100 ms off cycle</para> <para> <para>ToneGenerator(int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// TONE_SUP_CONFIRM
				/// </java-name>
				[Dot42.DexImport("TONE_SUP_CONFIRM", "I", AccessFlags = 25)]
				public const int TONE_SUP_CONFIRM = 32;
				/// <summary>
				///  <para>Call supervisory tone (IS-95), pip tone: four bursts of 480 Hz tone (0.1 s on, 0.1 s off).</para> <para> <para>ToneGenerator(int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// TONE_SUP_PIP
				/// </java-name>
				[Dot42.DexImport("TONE_SUP_PIP", "I", AccessFlags = 25)]
				public const int TONE_SUP_PIP = 33;
				/// <summary>
				///  <para>CDMA Dial tone : 425Hz continuous</para> <para> <para>ToneGenerator(int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// TONE_CDMA_DIAL_TONE_LITE
				/// </java-name>
				[Dot42.DexImport("TONE_CDMA_DIAL_TONE_LITE", "I", AccessFlags = 25)]
				public const int TONE_CDMA_DIAL_TONE_LITE = 34;
				/// <summary>
				///  <para>CDMA USA Ringback: 440Hz+480Hz 2s ON, 4000 OFF ...</para> <para> <para>ToneGenerator(int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// TONE_CDMA_NETWORK_USA_RINGBACK
				/// </java-name>
				[Dot42.DexImport("TONE_CDMA_NETWORK_USA_RINGBACK", "I", AccessFlags = 25)]
				public const int TONE_CDMA_NETWORK_USA_RINGBACK = 35;
				/// <summary>
				///  <para>CDMA Intercept tone: 440Hz 250ms ON, 620Hz 250ms ON ...</para> <para> <para>ToneGenerator(int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// TONE_CDMA_INTERCEPT
				/// </java-name>
				[Dot42.DexImport("TONE_CDMA_INTERCEPT", "I", AccessFlags = 25)]
				public const int TONE_CDMA_INTERCEPT = 36;
				/// <summary>
				///  <para>CDMA Abbr Intercept tone: 440Hz 250ms ON, 620Hz 250ms ON</para> <para> <para>ToneGenerator(int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// TONE_CDMA_ABBR_INTERCEPT
				/// </java-name>
				[Dot42.DexImport("TONE_CDMA_ABBR_INTERCEPT", "I", AccessFlags = 25)]
				public const int TONE_CDMA_ABBR_INTERCEPT = 37;
				/// <summary>
				///  <para>CDMA Reorder tone: 480Hz+620Hz 250ms ON, 250ms OFF...</para> <para> <para>ToneGenerator(int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// TONE_CDMA_REORDER
				/// </java-name>
				[Dot42.DexImport("TONE_CDMA_REORDER", "I", AccessFlags = 25)]
				public const int TONE_CDMA_REORDER = 38;
				/// <summary>
				///  <para>CDMA Abbr Reorder tone: 480Hz+620Hz 250ms ON, 250ms OFF repeated for 8 times  <para>ToneGenerator(int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// TONE_CDMA_ABBR_REORDER
				/// </java-name>
				[Dot42.DexImport("TONE_CDMA_ABBR_REORDER", "I", AccessFlags = 25)]
				public const int TONE_CDMA_ABBR_REORDER = 39;
				/// <summary>
				///  <para>CDMA Network Busy tone: 480Hz+620Hz 500ms ON, 500ms OFF continuous</para> <para> <para>ToneGenerator(int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// TONE_CDMA_NETWORK_BUSY
				/// </java-name>
				[Dot42.DexImport("TONE_CDMA_NETWORK_BUSY", "I", AccessFlags = 25)]
				public const int TONE_CDMA_NETWORK_BUSY = 40;
				/// <summary>
				///  <para>CDMA Confirm tone: 350Hz+440Hz 100ms ON, 100ms OFF repeated for 3 times</para> <para> <para>ToneGenerator(int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// TONE_CDMA_CONFIRM
				/// </java-name>
				[Dot42.DexImport("TONE_CDMA_CONFIRM", "I", AccessFlags = 25)]
				public const int TONE_CDMA_CONFIRM = 41;
				/// <summary>
				///  <para>CDMA answer tone: silent tone - defintion Frequency 0, 0ms ON, 0ms OFF  <para>ToneGenerator(int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// TONE_CDMA_ANSWER
				/// </java-name>
				[Dot42.DexImport("TONE_CDMA_ANSWER", "I", AccessFlags = 25)]
				public const int TONE_CDMA_ANSWER = 42;
				/// <summary>
				///  <para>CDMA Network Callwaiting tone: 440Hz 300ms ON  <para>ToneGenerator(int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// TONE_CDMA_NETWORK_CALLWAITING
				/// </java-name>
				[Dot42.DexImport("TONE_CDMA_NETWORK_CALLWAITING", "I", AccessFlags = 25)]
				public const int TONE_CDMA_NETWORK_CALLWAITING = 43;
				/// <summary>
				///  <para>CDMA PIP tone: 480Hz 100ms ON, 100ms OFF repeated for 4 times</para> <para> <para>ToneGenerator(int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// TONE_CDMA_PIP
				/// </java-name>
				[Dot42.DexImport("TONE_CDMA_PIP", "I", AccessFlags = 25)]
				public const int TONE_CDMA_PIP = 44;
				/// <summary>
				///  <para>ISDN Call Signal Normal tone: {2091Hz 32ms ON, 2556 64ms ON} 20 times, 2091 32ms ON, 2556 48ms ON, 4s OFF</para> <para> <para>ToneGenerator(int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// TONE_CDMA_CALL_SIGNAL_ISDN_NORMAL
				/// </java-name>
				[Dot42.DexImport("TONE_CDMA_CALL_SIGNAL_ISDN_NORMAL", "I", AccessFlags = 25)]
				public const int TONE_CDMA_CALL_SIGNAL_ISDN_NORMAL = 45;
				/// <summary>
				///  <para>ISDN Call Signal Intergroup tone: {2091Hz 32ms ON, 2556 64ms ON} 8 times, 2091Hz 32ms ON, 400ms OFF, {2091Hz 32ms ON, 2556Hz 64ms ON} times, 2091Hz 32ms ON, 4s OFF.</para> <para> <para>ToneGenerator(int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// TONE_CDMA_CALL_SIGNAL_ISDN_INTERGROUP
				/// </java-name>
				[Dot42.DexImport("TONE_CDMA_CALL_SIGNAL_ISDN_INTERGROUP", "I", AccessFlags = 25)]
				public const int TONE_CDMA_CALL_SIGNAL_ISDN_INTERGROUP = 46;
				/// <summary>
				///  <para>ISDN Call Signal SP PRI tone:{2091Hz 32ms ON, 2556 64ms ON} 4 times 2091Hz 16ms ON, 200ms OFF, {2091Hz 32ms ON, 2556Hz 64ms ON} 4 times, 2091Hz 16ms ON, 200ms OFF</para> <para> <para>ToneGenerator(int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// TONE_CDMA_CALL_SIGNAL_ISDN_SP_PRI
				/// </java-name>
				[Dot42.DexImport("TONE_CDMA_CALL_SIGNAL_ISDN_SP_PRI", "I", AccessFlags = 25)]
				public const int TONE_CDMA_CALL_SIGNAL_ISDN_SP_PRI = 47;
				/// <summary>
				///  <para>ISDN Call sign PAT3 tone: silent tone</para> <para> <para>ToneGenerator(int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// TONE_CDMA_CALL_SIGNAL_ISDN_PAT3
				/// </java-name>
				[Dot42.DexImport("TONE_CDMA_CALL_SIGNAL_ISDN_PAT3", "I", AccessFlags = 25)]
				public const int TONE_CDMA_CALL_SIGNAL_ISDN_PAT3 = 48;
				/// <summary>
				///  <para>ISDN Ping Ring tone: {2091Hz 32ms ON, 2556Hz 64ms ON} 5 times 2091Hz 20ms ON</para> <para> <para>ToneGenerator(int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// TONE_CDMA_CALL_SIGNAL_ISDN_PING_RING
				/// </java-name>
				[Dot42.DexImport("TONE_CDMA_CALL_SIGNAL_ISDN_PING_RING", "I", AccessFlags = 25)]
				public const int TONE_CDMA_CALL_SIGNAL_ISDN_PING_RING = 49;
				/// <summary>
				///  <para>ISDN Pat5 tone: silent tone  <para>ToneGenerator(int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// TONE_CDMA_CALL_SIGNAL_ISDN_PAT5
				/// </java-name>
				[Dot42.DexImport("TONE_CDMA_CALL_SIGNAL_ISDN_PAT5", "I", AccessFlags = 25)]
				public const int TONE_CDMA_CALL_SIGNAL_ISDN_PAT5 = 50;
				/// <summary>
				///  <para>ISDN Pat6 tone: silent tone  <para>ToneGenerator(int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// TONE_CDMA_CALL_SIGNAL_ISDN_PAT6
				/// </java-name>
				[Dot42.DexImport("TONE_CDMA_CALL_SIGNAL_ISDN_PAT6", "I", AccessFlags = 25)]
				public const int TONE_CDMA_CALL_SIGNAL_ISDN_PAT6 = 51;
				/// <summary>
				///  <para>ISDN Pat7 tone: silent tone</para> <para> <para>ToneGenerator(int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// TONE_CDMA_CALL_SIGNAL_ISDN_PAT7
				/// </java-name>
				[Dot42.DexImport("TONE_CDMA_CALL_SIGNAL_ISDN_PAT7", "I", AccessFlags = 25)]
				public const int TONE_CDMA_CALL_SIGNAL_ISDN_PAT7 = 52;
				/// <summary>
				///  <para>TONE_CDMA_HIGH_L tone: {3700Hz 25ms, 4000Hz 25ms} 40 times 4000ms OFF, Repeat ....</para> <para> <para>ToneGenerator(int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// TONE_CDMA_HIGH_L
				/// </java-name>
				[Dot42.DexImport("TONE_CDMA_HIGH_L", "I", AccessFlags = 25)]
				public const int TONE_CDMA_HIGH_L = 53;
				/// <summary>
				///  <para>TONE_CDMA_MED_L tone: {2600Hz 25ms, 2900Hz 25ms} 40 times 4000ms OFF, Repeat ....</para> <para> <para>ToneGenerator(int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// TONE_CDMA_MED_L
				/// </java-name>
				[Dot42.DexImport("TONE_CDMA_MED_L", "I", AccessFlags = 25)]
				public const int TONE_CDMA_MED_L = 54;
				/// <summary>
				///  <para>TONE_CDMA_LOW_L tone: {1300Hz 25ms, 1450Hz 25ms} 40 times, 4000ms OFF, Repeat ....</para> <para> <para>ToneGenerator(int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// TONE_CDMA_LOW_L
				/// </java-name>
				[Dot42.DexImport("TONE_CDMA_LOW_L", "I", AccessFlags = 25)]
				public const int TONE_CDMA_LOW_L = 55;
				/// <summary>
				///  <para>CDMA HIGH SS tone: {3700Hz 25ms, 4000Hz 25ms} repeat 16 times, 400ms OFF, repeat ....</para> <para> <para>ToneGenerator(int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// TONE_CDMA_HIGH_SS
				/// </java-name>
				[Dot42.DexImport("TONE_CDMA_HIGH_SS", "I", AccessFlags = 25)]
				public const int TONE_CDMA_HIGH_SS = 56;
				/// <summary>
				///  <para>CDMA MED SS tone: {2600Hz 25ms, 2900Hz 25ms} repeat 16 times, 400ms OFF, repeat ....</para> <para> <para>ToneGenerator(int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// TONE_CDMA_MED_SS
				/// </java-name>
				[Dot42.DexImport("TONE_CDMA_MED_SS", "I", AccessFlags = 25)]
				public const int TONE_CDMA_MED_SS = 57;
				/// <summary>
				///  <para>CDMA LOW SS tone: {1300z 25ms, 1450Hz 25ms} repeat 16 times, 400ms OFF, repeat ....</para> <para> <para>ToneGenerator(int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// TONE_CDMA_LOW_SS
				/// </java-name>
				[Dot42.DexImport("TONE_CDMA_LOW_SS", "I", AccessFlags = 25)]
				public const int TONE_CDMA_LOW_SS = 58;
				/// <summary>
				///  <para>CDMA HIGH SSL tone: {3700Hz 25ms, 4000Hz 25ms} 8 times, 200ms OFF, {3700Hz 25ms, 4000Hz 25ms} repeat 8 times, 200ms OFF, {3700Hz 25ms, 4000Hz 25ms} repeat 16 times, 4000ms OFF, repeat ...</para> <para> <para>ToneGenerator(int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// TONE_CDMA_HIGH_SSL
				/// </java-name>
				[Dot42.DexImport("TONE_CDMA_HIGH_SSL", "I", AccessFlags = 25)]
				public const int TONE_CDMA_HIGH_SSL = 59;
				/// <summary>
				///  <para>CDMA MED SSL tone: {2600Hz 25ms, 2900Hz 25ms} 8 times, 200ms OFF, {2600Hz 25ms, 2900Hz 25ms} repeat 8 times, 200ms OFF, {2600Hz 25ms, 2900Hz 25ms} repeat 16 times, 4000ms OFF, repeat ...</para> <para> <para>ToneGenerator(int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// TONE_CDMA_MED_SSL
				/// </java-name>
				[Dot42.DexImport("TONE_CDMA_MED_SSL", "I", AccessFlags = 25)]
				public const int TONE_CDMA_MED_SSL = 60;
				/// <summary>
				///  <para>CDMA LOW SSL tone: {1300Hz 25ms, 1450Hz 25ms} 8 times, 200ms OFF, {1300Hz 25ms, 1450Hz 25ms} repeat 8 times, 200ms OFF, {1300Hz 25ms, 1450Hz 25ms} repeat 16 times, 4000ms OFF, repeat ...</para> <para> <para>ToneGenerator(int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// TONE_CDMA_LOW_SSL
				/// </java-name>
				[Dot42.DexImport("TONE_CDMA_LOW_SSL", "I", AccessFlags = 25)]
				public const int TONE_CDMA_LOW_SSL = 61;
				/// <summary>
				///  <para>CDMA HIGH SS2 tone: {3700Hz 25ms, 4000Hz 25ms} 20 times, 1000ms OFF, {3700Hz 25ms, 4000Hz 25ms} 20 times, 3000ms OFF, repeat ....</para> <para> <para>ToneGenerator(int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// TONE_CDMA_HIGH_SS_2
				/// </java-name>
				[Dot42.DexImport("TONE_CDMA_HIGH_SS_2", "I", AccessFlags = 25)]
				public const int TONE_CDMA_HIGH_SS_2 = 62;
				/// <summary>
				///  <para>CDMA MED SS2 tone: {2600Hz 25ms, 2900Hz 25ms} 20 times, 1000ms OFF, {2600Hz 25ms, 2900Hz 25ms} 20 times, 3000ms OFF, repeat ....</para> <para> <para>ToneGenerator(int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// TONE_CDMA_MED_SS_2
				/// </java-name>
				[Dot42.DexImport("TONE_CDMA_MED_SS_2", "I", AccessFlags = 25)]
				public const int TONE_CDMA_MED_SS_2 = 63;
				/// <summary>
				///  <para>CDMA LOW SS2 tone: {1300Hz 25ms, 1450Hz 25ms} 20 times, 1000ms OFF, {1300Hz 25ms, 1450Hz 25ms} 20 times, 3000ms OFF, repeat ....</para> <para> <para>ToneGenerator(int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// TONE_CDMA_LOW_SS_2
				/// </java-name>
				[Dot42.DexImport("TONE_CDMA_LOW_SS_2", "I", AccessFlags = 25)]
				public const int TONE_CDMA_LOW_SS_2 = 64;
				/// <summary>
				///  <para>CDMA HIGH SLS tone: {3700Hz 25ms, 4000Hz 25ms} 10 times, 500ms OFF, {3700Hz 25ms, 4000Hz 25ms} 20 times, 500ms OFF, {3700Hz 25ms, 4000Hz 25ms} 10 times, 3000ms OFF, REPEAT</para> <para> <para>ToneGenerator(int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// TONE_CDMA_HIGH_SLS
				/// </java-name>
				[Dot42.DexImport("TONE_CDMA_HIGH_SLS", "I", AccessFlags = 25)]
				public const int TONE_CDMA_HIGH_SLS = 65;
				/// <summary>
				///  <para>CDMA MED SLS tone: {2600Hz 25ms, 2900Hz 25ms} 10 times, 500ms OFF, {2600Hz 25ms, 2900Hz 25ms} 20 times, 500ms OFF, {2600Hz 25ms, 2900Hz 25ms} 10 times, 3000ms OFF, REPEAT</para> <para> <para>ToneGenerator(int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// TONE_CDMA_MED_SLS
				/// </java-name>
				[Dot42.DexImport("TONE_CDMA_MED_SLS", "I", AccessFlags = 25)]
				public const int TONE_CDMA_MED_SLS = 66;
				/// <summary>
				///  <para>CDMA LOW SLS tone: {1300Hz 25ms, 1450Hz 25ms} 10 times, 500ms OFF, {1300Hz 25ms, 1450Hz 25ms} 20 times, 500ms OFF, {1300Hz 25ms, 1450Hz 25ms} 10 times, 3000ms OFF, REPEAT</para> <para> <para>ToneGenerator(int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// TONE_CDMA_LOW_SLS
				/// </java-name>
				[Dot42.DexImport("TONE_CDMA_LOW_SLS", "I", AccessFlags = 25)]
				public const int TONE_CDMA_LOW_SLS = 67;
				/// <summary>
				///  <para>CDMA HIGH S X4 tone: {3700Hz 25ms, 4000Hz 25ms} 10 times, 500ms OFF, {3700Hz 25ms, 4000Hz 25ms} 10 times, 500ms OFF, {3700Hz 25ms, 4000Hz 25ms} 10 times, 500ms OFF, {3700Hz 25ms, 4000Hz 25ms} 10 times, 2500ms OFF, REPEAT....</para> <para> <para>ToneGenerator(int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// TONE_CDMA_HIGH_S_X4
				/// </java-name>
				[Dot42.DexImport("TONE_CDMA_HIGH_S_X4", "I", AccessFlags = 25)]
				public const int TONE_CDMA_HIGH_S_X4 = 68;
				/// <summary>
				///  <para>CDMA MED S X4 tone: {2600Hz 25ms, 2900Hz 25ms} 10 times, 500ms OFF, {2600Hz 25ms, 2900Hz 25ms} 10 times, 500ms OFF, {2600Hz 25ms, 2900Hz 25ms} 10 times, 500ms OFF, {2600Hz 25ms, 2900Hz 25ms} 10 times, 2500ms OFF, REPEAT....</para> <para> <para>ToneGenerator(int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// TONE_CDMA_MED_S_X4
				/// </java-name>
				[Dot42.DexImport("TONE_CDMA_MED_S_X4", "I", AccessFlags = 25)]
				public const int TONE_CDMA_MED_S_X4 = 69;
				/// <summary>
				///  <para>CDMA LOW S X4 tone: {2600Hz 25ms, 2900Hz 25ms} 10 times, 500ms OFF, {2600Hz 25ms, 2900Hz 25ms} 10 times, 500ms OFF, {2600Hz 25ms, 2900Hz 25ms} 10 times, 500ms OFF, {2600Hz 25ms, 2900Hz 25ms} 10 times, 2500ms OFF, REPEAT....</para> <para> <para>ToneGenerator(int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// TONE_CDMA_LOW_S_X4
				/// </java-name>
				[Dot42.DexImport("TONE_CDMA_LOW_S_X4", "I", AccessFlags = 25)]
				public const int TONE_CDMA_LOW_S_X4 = 70;
				/// <summary>
				///  <para>CDMA HIGH PBX L: {3700Hz 25ms, 4000Hz 25ms}20 times, 2000ms OFF, REPEAT....</para> <para> <para>ToneGenerator(int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// TONE_CDMA_HIGH_PBX_L
				/// </java-name>
				[Dot42.DexImport("TONE_CDMA_HIGH_PBX_L", "I", AccessFlags = 25)]
				public const int TONE_CDMA_HIGH_PBX_L = 71;
				/// <summary>
				///  <para>CDMA MED PBX L: {2600Hz 25ms, 2900Hz 25ms}20 times, 2000ms OFF, REPEAT....</para> <para> <para>ToneGenerator(int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// TONE_CDMA_MED_PBX_L
				/// </java-name>
				[Dot42.DexImport("TONE_CDMA_MED_PBX_L", "I", AccessFlags = 25)]
				public const int TONE_CDMA_MED_PBX_L = 72;
				/// <summary>
				///  <para>CDMA LOW PBX L: {1300Hz 25ms,1450Hz 25ms}20 times, 2000ms OFF, REPEAT....</para> <para> <para>ToneGenerator(int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// TONE_CDMA_LOW_PBX_L
				/// </java-name>
				[Dot42.DexImport("TONE_CDMA_LOW_PBX_L", "I", AccessFlags = 25)]
				public const int TONE_CDMA_LOW_PBX_L = 73;
				/// <summary>
				///  <para>CDMA HIGH PBX SS tone: {3700Hz 25ms, 4000Hz 25ms} 8 times 200 ms OFF, {3700Hz 25ms 4000Hz 25ms}8 times, 2000ms OFF, REPEAT....</para> <para> <para>ToneGenerator(int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// TONE_CDMA_HIGH_PBX_SS
				/// </java-name>
				[Dot42.DexImport("TONE_CDMA_HIGH_PBX_SS", "I", AccessFlags = 25)]
				public const int TONE_CDMA_HIGH_PBX_SS = 74;
				/// <summary>
				///  <para>CDMA MED PBX SS tone: {2600Hz 25ms, 2900Hz 25ms} 8 times 200 ms OFF, {2600Hz 25ms 2900Hz 25ms}8 times, 2000ms OFF, REPEAT....</para> <para> <para>ToneGenerator(int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// TONE_CDMA_MED_PBX_SS
				/// </java-name>
				[Dot42.DexImport("TONE_CDMA_MED_PBX_SS", "I", AccessFlags = 25)]
				public const int TONE_CDMA_MED_PBX_SS = 75;
				/// <summary>
				///  <para>CDMA LOW PBX SS tone: {1300Hz 25ms, 1450Hz 25ms} 8 times 200 ms OFF, {1300Hz 25ms 1450Hz 25ms}8 times, 2000ms OFF, REPEAT....</para> <para> <para>ToneGenerator(int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// TONE_CDMA_LOW_PBX_SS
				/// </java-name>
				[Dot42.DexImport("TONE_CDMA_LOW_PBX_SS", "I", AccessFlags = 25)]
				public const int TONE_CDMA_LOW_PBX_SS = 76;
				/// <summary>
				///  <para>CDMA HIGH PBX SSL tone:{3700Hz 25ms, 4000Hz 25ms} 8 times 200ms OFF, {3700Hz 25ms, 4000Hz 25ms} 8 times, 200ms OFF, {3700Hz 25ms, 4000Hz 25ms} 16 times, 1000ms OFF, REPEAT....</para> <para> <para>ToneGenerator(int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// TONE_CDMA_HIGH_PBX_SSL
				/// </java-name>
				[Dot42.DexImport("TONE_CDMA_HIGH_PBX_SSL", "I", AccessFlags = 25)]
				public const int TONE_CDMA_HIGH_PBX_SSL = 77;
				/// <summary>
				///  <para>CDMA MED PBX SSL tone:{2600Hz 25ms, 2900Hz 25ms} 8 times 200ms OFF, {2600Hz 25ms, 2900Hz 25ms} 8 times, 200ms OFF, {2600Hz 25ms, 2900Hz 25ms} 16 times, 1000ms OFF, REPEAT....</para> <para> <para>ToneGenerator(int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// TONE_CDMA_MED_PBX_SSL
				/// </java-name>
				[Dot42.DexImport("TONE_CDMA_MED_PBX_SSL", "I", AccessFlags = 25)]
				public const int TONE_CDMA_MED_PBX_SSL = 78;
				/// <summary>
				///  <para>CDMA LOW PBX SSL tone:{1300Hz 25ms, 1450Hz 25ms} 8 times 200ms OFF, {1300Hz 25ms, 1450Hz 25ms} 8 times, 200ms OFF, {1300Hz 25ms, 1450Hz 25ms} 16 times, 1000ms OFF, REPEAT....</para> <para> <para>ToneGenerator(int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// TONE_CDMA_LOW_PBX_SSL
				/// </java-name>
				[Dot42.DexImport("TONE_CDMA_LOW_PBX_SSL", "I", AccessFlags = 25)]
				public const int TONE_CDMA_LOW_PBX_SSL = 79;
				/// <summary>
				///  <para>CDMA HIGH PBX SSL tone:{3700Hz 25ms, 4000Hz 25ms} 8 times 200ms OFF, {3700Hz 25ms, 4000Hz 25ms} 16 times, 200ms OFF, {3700Hz 25ms, 4000Hz 25ms} 8 times, 1000ms OFF, REPEAT....</para> <para> <para>ToneGenerator(int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// TONE_CDMA_HIGH_PBX_SLS
				/// </java-name>
				[Dot42.DexImport("TONE_CDMA_HIGH_PBX_SLS", "I", AccessFlags = 25)]
				public const int TONE_CDMA_HIGH_PBX_SLS = 80;
				/// <summary>
				///  <para>CDMA HIGH PBX SLS tone:{2600Hz 25ms, 2900Hz 25ms} 8 times 200ms OFF, {2600Hz 25ms, 2900Hz 25ms} 16 times, 200ms OFF, {2600Hz 25ms, 2900Hz 25ms} 8 times, 1000ms OFF, REPEAT....</para> <para> <para>ToneGenerator(int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// TONE_CDMA_MED_PBX_SLS
				/// </java-name>
				[Dot42.DexImport("TONE_CDMA_MED_PBX_SLS", "I", AccessFlags = 25)]
				public const int TONE_CDMA_MED_PBX_SLS = 81;
				/// <summary>
				///  <para>CDMA HIGH PBX SLS tone:{1300Hz 25ms, 1450Hz 25ms} 8 times 200ms OFF, {1300Hz 25ms, 1450Hz 25ms} 16 times, 200ms OFF, {1300Hz 25ms, 1450Hz 25ms} 8 times, 1000ms OFF, REPEAT....</para> <para> <para>ToneGenerator(int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// TONE_CDMA_LOW_PBX_SLS
				/// </java-name>
				[Dot42.DexImport("TONE_CDMA_LOW_PBX_SLS", "I", AccessFlags = 25)]
				public const int TONE_CDMA_LOW_PBX_SLS = 82;
				/// <summary>
				///  <para>CDMA HIGH PBX X S4 tone: {3700Hz 25ms 4000Hz 25ms} 8 times, 200ms OFF, {3700Hz 25ms 4000Hz 25ms} 8 times, 200ms OFF, {3700Hz 25ms 4000Hz 25ms} 8 times, 200ms OFF, {3700Hz 25ms 4000Hz 25ms} 8 times, 800ms OFF, REPEAT...</para> <para> <para>ToneGenerator(int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// TONE_CDMA_HIGH_PBX_S_X4
				/// </java-name>
				[Dot42.DexImport("TONE_CDMA_HIGH_PBX_S_X4", "I", AccessFlags = 25)]
				public const int TONE_CDMA_HIGH_PBX_S_X4 = 83;
				/// <summary>
				///  <para>CDMA MED PBX X S4 tone: {2600Hz 25ms 2900Hz 25ms} 8 times, 200ms OFF, {2600Hz 25ms 2900Hz 25ms} 8 times, 200ms OFF, {2600Hz 25ms 2900Hz 25ms} 8 times, 200ms OFF, {2600Hz 25ms 2900Hz 25ms} 8 times, 800ms OFF, REPEAT...</para> <para> <para>ToneGenerator(int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// TONE_CDMA_MED_PBX_S_X4
				/// </java-name>
				[Dot42.DexImport("TONE_CDMA_MED_PBX_S_X4", "I", AccessFlags = 25)]
				public const int TONE_CDMA_MED_PBX_S_X4 = 84;
				/// <summary>
				///  <para>CDMA LOW PBX X S4 tone: {1300Hz 25ms 1450Hz 25ms} 8 times, 200ms OFF, {1300Hz 25ms 1450Hz 25ms} 8 times, 200ms OFF, {1300Hz 25ms 1450Hz 25ms} 8 times, 200ms OFF, {1300Hz 25ms 1450Hz 25ms} 8 times, 800ms OFF, REPEAT...</para> <para> <para>ToneGenerator(int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// TONE_CDMA_LOW_PBX_S_X4
				/// </java-name>
				[Dot42.DexImport("TONE_CDMA_LOW_PBX_S_X4", "I", AccessFlags = 25)]
				public const int TONE_CDMA_LOW_PBX_S_X4 = 85;
				/// <summary>
				///  <para>CDMA Alert Network Lite tone: 1109Hz 62ms ON, 784Hz 62ms ON, 740Hz 62ms ON 622Hz 62ms ON, 1109Hz 62ms ON</para> <para> <para>ToneGenerator(int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// TONE_CDMA_ALERT_NETWORK_LITE
				/// </java-name>
				[Dot42.DexImport("TONE_CDMA_ALERT_NETWORK_LITE", "I", AccessFlags = 25)]
				public const int TONE_CDMA_ALERT_NETWORK_LITE = 86;
				/// <summary>
				///  <para>CDMA Alert Auto Redial tone: {1245Hz 62ms ON, 659Hz 62ms ON} 3 times, 1245 62ms ON</para> <para> <para>ToneGenerator(int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// TONE_CDMA_ALERT_AUTOREDIAL_LITE
				/// </java-name>
				[Dot42.DexImport("TONE_CDMA_ALERT_AUTOREDIAL_LITE", "I", AccessFlags = 25)]
				public const int TONE_CDMA_ALERT_AUTOREDIAL_LITE = 87;
				/// <summary>
				///  <para>CDMA One Min Beep tone: 1150Hz+770Hz 400ms ON</para> <para> <para>ToneGenerator(int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// TONE_CDMA_ONE_MIN_BEEP
				/// </java-name>
				[Dot42.DexImport("TONE_CDMA_ONE_MIN_BEEP", "I", AccessFlags = 25)]
				public const int TONE_CDMA_ONE_MIN_BEEP = 88;
				/// <summary>
				///  <para>CDMA KEYPAD Volume key lite tone: 941Hz+1477Hz 120ms ON  <para>ToneGenerator(int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// TONE_CDMA_KEYPAD_VOLUME_KEY_LITE
				/// </java-name>
				[Dot42.DexImport("TONE_CDMA_KEYPAD_VOLUME_KEY_LITE", "I", AccessFlags = 25)]
				public const int TONE_CDMA_KEYPAD_VOLUME_KEY_LITE = 89;
				/// <summary>
				///  <para>CDMA PRESSHOLDKEY LITE tone: 587Hz 375ms ON, 1175Hz 125ms ON</para> <para> <para>ToneGenerator(int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// TONE_CDMA_PRESSHOLDKEY_LITE
				/// </java-name>
				[Dot42.DexImport("TONE_CDMA_PRESSHOLDKEY_LITE", "I", AccessFlags = 25)]
				public const int TONE_CDMA_PRESSHOLDKEY_LITE = 90;
				/// <summary>
				///  <para>CDMA ALERT INCALL LITE tone: 587Hz 62ms, 784 62ms, 831Hz 62ms, 784Hz 62ms, 1109 62ms, 784Hz 62ms, 831Hz 62ms, 784Hz 62ms</para> <para> <para>ToneGenerator(int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// TONE_CDMA_ALERT_INCALL_LITE
				/// </java-name>
				[Dot42.DexImport("TONE_CDMA_ALERT_INCALL_LITE", "I", AccessFlags = 25)]
				public const int TONE_CDMA_ALERT_INCALL_LITE = 91;
				/// <summary>
				///  <para>CDMA EMERGENCY RINGBACK tone: {941Hz 125ms ON, 10ms OFF} 3times 4990ms OFF, REPEAT...</para> <para> <para>ToneGenerator(int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// TONE_CDMA_EMERGENCY_RINGBACK
				/// </java-name>
				[Dot42.DexImport("TONE_CDMA_EMERGENCY_RINGBACK", "I", AccessFlags = 25)]
				public const int TONE_CDMA_EMERGENCY_RINGBACK = 92;
				/// <summary>
				///  <para>CDMA ALERT CALL GUARD tone: {1319Hz 125ms ON, 125ms OFF} 3 times</para> <para> <para>ToneGenerator(int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// TONE_CDMA_ALERT_CALL_GUARD
				/// </java-name>
				[Dot42.DexImport("TONE_CDMA_ALERT_CALL_GUARD", "I", AccessFlags = 25)]
				public const int TONE_CDMA_ALERT_CALL_GUARD = 93;
				/// <summary>
				///  <para>CDMA SOFT ERROR LITE tone: 1047Hz 125ms ON, 370Hz 125ms</para> <para> <para>ToneGenerator(int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// TONE_CDMA_SOFT_ERROR_LITE
				/// </java-name>
				[Dot42.DexImport("TONE_CDMA_SOFT_ERROR_LITE", "I", AccessFlags = 25)]
				public const int TONE_CDMA_SOFT_ERROR_LITE = 94;
				/// <summary>
				///  <para>CDMA CALLDROP LITE tone: 1480Hz 125ms, 1397Hz 125ms, 784Hz 125ms</para> <para> <para>ToneGenerator(int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// TONE_CDMA_CALLDROP_LITE
				/// </java-name>
				[Dot42.DexImport("TONE_CDMA_CALLDROP_LITE", "I", AccessFlags = 25)]
				public const int TONE_CDMA_CALLDROP_LITE = 95;
				/// <summary>
				///  <para>CDMA_NETWORK_BUSY_ONE_SHOT tone: 425Hz 500ms ON, 500ms OFF.</para> <para> <para>ToneGenerator(int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// TONE_CDMA_NETWORK_BUSY_ONE_SHOT
				/// </java-name>
				[Dot42.DexImport("TONE_CDMA_NETWORK_BUSY_ONE_SHOT", "I", AccessFlags = 25)]
				public const int TONE_CDMA_NETWORK_BUSY_ONE_SHOT = 96;
				/// <summary>
				///  <para>CDMA_ABBR_ALERT tone: 1150Hz+770Hz 400ms ON  <para>ToneGenerator(int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// TONE_CDMA_ABBR_ALERT
				/// </java-name>
				[Dot42.DexImport("TONE_CDMA_ABBR_ALERT", "I", AccessFlags = 25)]
				public const int TONE_CDMA_ABBR_ALERT = 97;
				/// <summary>
				///  <para>CDMA_SIGNAL_OFF - silent tone</para> <para> <para>ToneGenerator(int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// TONE_CDMA_SIGNAL_OFF
				/// </java-name>
				[Dot42.DexImport("TONE_CDMA_SIGNAL_OFF", "I", AccessFlags = 25)]
				public const int TONE_CDMA_SIGNAL_OFF = 98;
				/// <summary>
				///  <para>Maximum volume, for use with ToneGenerator(int,int) </para>        
				/// </summary>
				/// <java-name>
				/// MAX_VOLUME
				/// </java-name>
				[Dot42.DexImport("MAX_VOLUME", "I", AccessFlags = 25)]
				public const int MAX_VOLUME = 100;
				/// <summary>
				///  <para>Minimum volume setting, for use with ToneGenerator(int,int) </para>        
				/// </summary>
				/// <java-name>
				/// MIN_VOLUME
				/// </java-name>
				[Dot42.DexImport("MIN_VOLUME", "I", AccessFlags = 25)]
				public const int MIN_VOLUME = 0;
				/// <summary>
				///  <para>ToneGenerator class contructor specifying output stream type and volume.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(II)V", AccessFlags = 1)]
				public ToneGenerator(int streamType, int volume) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>This method starts the playback of a tone of the specified type. only one tone can play at a time: if a tone is playing while this method is called, this tone is stopped and replaced by the one requested.  <para>ToneGenerator(int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// startTone
				/// </java-name>
				[Dot42.DexImport("startTone", "(I)Z", AccessFlags = 1)]
				public virtual bool StartTone(int toneType) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>This method starts the playback of a tone of the specified type for the specified duration.  <para>startTone(int). </para></para>        
				/// </summary>
				/// <java-name>
				/// startTone
				/// </java-name>
				[Dot42.DexImport("startTone", "(II)Z", AccessFlags = 257)]
				public virtual bool StartTone(int toneType, int durationMs) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>This method stops the tone currently playing playback.  <para>ToneGenerator(int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// stopTone
				/// </java-name>
				[Dot42.DexImport("stopTone", "()V", AccessFlags = 257)]
				public virtual void StopTone() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Releases resources associated with this ToneGenerator object. It is good practice to call this method when you're done using the ToneGenerator. </para>        
				/// </summary>
				/// <java-name>
				/// release
				/// </java-name>
				[Dot42.DexImport("release", "()V", AccessFlags = 257)]
				public virtual void Release() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// finalize
				/// </java-name>
				[Dot42.DexImport("finalize", "()V", AccessFlags = 4)]
				extern ~ToneGenerator() /* MethodBuilder.Create */ ;

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal ToneGenerator() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

}

