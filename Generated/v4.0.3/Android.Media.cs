#pragma warning disable 1717
namespace Android.Media
{
		/// <java-name>
		/// android/media/AsyncPlayer
		/// </java-name>
		[Dot42.DexImport("android/media/AsyncPlayer", AccessFlags = 33)]
		public partial class AsyncPlayer
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public AsyncPlayer(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// play
				/// </java-name>
				[Dot42.DexImport("play", "(Landroid/content/Context;Landroid/net/Uri;ZI)V", AccessFlags = 1)]
				public virtual void Play(global::Android.Content.Context context, global::Android.Net.Uri uri, bool boolean, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// stop
				/// </java-name>
				[Dot42.DexImport("stop", "()V", AccessFlags = 1)]
				public virtual void Stop() /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal AsyncPlayer() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// android/media/AudioFormat
		/// </java-name>
		[Dot42.DexImport("android/media/AudioFormat", AccessFlags = 33)]
		public partial class AudioFormat
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// ENCODING_INVALID
				/// </java-name>
				[Dot42.DexImport("ENCODING_INVALID", "I", AccessFlags = 25)]
				public const int ENCODING_INVALID = 0;
				/// <java-name>
				/// ENCODING_DEFAULT
				/// </java-name>
				[Dot42.DexImport("ENCODING_DEFAULT", "I", AccessFlags = 25)]
				public const int ENCODING_DEFAULT = 1;
				/// <java-name>
				/// ENCODING_PCM_16BIT
				/// </java-name>
				[Dot42.DexImport("ENCODING_PCM_16BIT", "I", AccessFlags = 25)]
				public const int ENCODING_PCM_16BIT = 2;
				/// <java-name>
				/// ENCODING_PCM_8BIT
				/// </java-name>
				[Dot42.DexImport("ENCODING_PCM_8BIT", "I", AccessFlags = 25)]
				public const int ENCODING_PCM_8BIT = 3;
				/// <java-name>
				/// CHANNEL_CONFIGURATION_INVALID
				/// </java-name>
				[Dot42.DexImport("CHANNEL_CONFIGURATION_INVALID", "I", AccessFlags = 25)]
				public const int CHANNEL_CONFIGURATION_INVALID = 0;
				/// <java-name>
				/// CHANNEL_CONFIGURATION_DEFAULT
				/// </java-name>
				[Dot42.DexImport("CHANNEL_CONFIGURATION_DEFAULT", "I", AccessFlags = 25)]
				public const int CHANNEL_CONFIGURATION_DEFAULT = 1;
				/// <java-name>
				/// CHANNEL_CONFIGURATION_MONO
				/// </java-name>
				[Dot42.DexImport("CHANNEL_CONFIGURATION_MONO", "I", AccessFlags = 25)]
				public const int CHANNEL_CONFIGURATION_MONO = 2;
				/// <java-name>
				/// CHANNEL_CONFIGURATION_STEREO
				/// </java-name>
				[Dot42.DexImport("CHANNEL_CONFIGURATION_STEREO", "I", AccessFlags = 25)]
				public const int CHANNEL_CONFIGURATION_STEREO = 3;
				/// <java-name>
				/// CHANNEL_INVALID
				/// </java-name>
				[Dot42.DexImport("CHANNEL_INVALID", "I", AccessFlags = 25)]
				public const int CHANNEL_INVALID = 0;
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

		/// <java-name>
		/// android/media/AudioManager
		/// </java-name>
		[Dot42.DexImport("android/media/AudioManager", AccessFlags = 33)]
		public partial class AudioManager
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// ACTION_AUDIO_BECOMING_NOISY
				/// </java-name>
				[Dot42.DexImport("ACTION_AUDIO_BECOMING_NOISY", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_AUDIO_BECOMING_NOISY = "android.media.AUDIO_BECOMING_NOISY";
				/// <java-name>
				/// RINGER_MODE_CHANGED_ACTION
				/// </java-name>
				[Dot42.DexImport("RINGER_MODE_CHANGED_ACTION", "Ljava/lang/String;", AccessFlags = 25)]
				public const string RINGER_MODE_CHANGED_ACTION = "android.media.RINGER_MODE_CHANGED";
				/// <java-name>
				/// EXTRA_RINGER_MODE
				/// </java-name>
				[Dot42.DexImport("EXTRA_RINGER_MODE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_RINGER_MODE = "android.media.EXTRA_RINGER_MODE";
				/// <java-name>
				/// VIBRATE_SETTING_CHANGED_ACTION
				/// </java-name>
				[Dot42.DexImport("VIBRATE_SETTING_CHANGED_ACTION", "Ljava/lang/String;", AccessFlags = 25)]
				public const string VIBRATE_SETTING_CHANGED_ACTION = "android.media.VIBRATE_SETTING_CHANGED";
				/// <java-name>
				/// EXTRA_VIBRATE_SETTING
				/// </java-name>
				[Dot42.DexImport("EXTRA_VIBRATE_SETTING", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_VIBRATE_SETTING = "android.media.EXTRA_VIBRATE_SETTING";
				/// <java-name>
				/// EXTRA_VIBRATE_TYPE
				/// </java-name>
				[Dot42.DexImport("EXTRA_VIBRATE_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_VIBRATE_TYPE = "android.media.EXTRA_VIBRATE_TYPE";
				/// <java-name>
				/// STREAM_VOICE_CALL
				/// </java-name>
				[Dot42.DexImport("STREAM_VOICE_CALL", "I", AccessFlags = 25)]
				public const int STREAM_VOICE_CALL = 0;
				/// <java-name>
				/// STREAM_SYSTEM
				/// </java-name>
				[Dot42.DexImport("STREAM_SYSTEM", "I", AccessFlags = 25)]
				public const int STREAM_SYSTEM = 1;
				/// <java-name>
				/// STREAM_RING
				/// </java-name>
				[Dot42.DexImport("STREAM_RING", "I", AccessFlags = 25)]
				public const int STREAM_RING = 2;
				/// <java-name>
				/// STREAM_MUSIC
				/// </java-name>
				[Dot42.DexImport("STREAM_MUSIC", "I", AccessFlags = 25)]
				public const int STREAM_MUSIC = 3;
				/// <java-name>
				/// STREAM_ALARM
				/// </java-name>
				[Dot42.DexImport("STREAM_ALARM", "I", AccessFlags = 25)]
				public const int STREAM_ALARM = 4;
				/// <java-name>
				/// STREAM_NOTIFICATION
				/// </java-name>
				[Dot42.DexImport("STREAM_NOTIFICATION", "I", AccessFlags = 25)]
				public const int STREAM_NOTIFICATION = 5;
				/// <java-name>
				/// STREAM_DTMF
				/// </java-name>
				[Dot42.DexImport("STREAM_DTMF", "I", AccessFlags = 25)]
				public const int STREAM_DTMF = 8;
				/// <java-name>
				/// NUM_STREAMS
				/// </java-name>
				[Dot42.DexImport("NUM_STREAMS", "I", AccessFlags = 25)]
				public const int NUM_STREAMS = 5;
				/// <java-name>
				/// ADJUST_RAISE
				/// </java-name>
				[Dot42.DexImport("ADJUST_RAISE", "I", AccessFlags = 25)]
				public const int ADJUST_RAISE = 1;
				/// <java-name>
				/// ADJUST_LOWER
				/// </java-name>
				[Dot42.DexImport("ADJUST_LOWER", "I", AccessFlags = 25)]
				public const int ADJUST_LOWER = -1;
				/// <java-name>
				/// ADJUST_SAME
				/// </java-name>
				[Dot42.DexImport("ADJUST_SAME", "I", AccessFlags = 25)]
				public const int ADJUST_SAME = 0;
				/// <java-name>
				/// FLAG_SHOW_UI
				/// </java-name>
				[Dot42.DexImport("FLAG_SHOW_UI", "I", AccessFlags = 25)]
				public const int FLAG_SHOW_UI = 1;
				/// <java-name>
				/// FLAG_ALLOW_RINGER_MODES
				/// </java-name>
				[Dot42.DexImport("FLAG_ALLOW_RINGER_MODES", "I", AccessFlags = 25)]
				public const int FLAG_ALLOW_RINGER_MODES = 2;
				/// <java-name>
				/// FLAG_PLAY_SOUND
				/// </java-name>
				[Dot42.DexImport("FLAG_PLAY_SOUND", "I", AccessFlags = 25)]
				public const int FLAG_PLAY_SOUND = 4;
				/// <java-name>
				/// FLAG_REMOVE_SOUND_AND_VIBRATE
				/// </java-name>
				[Dot42.DexImport("FLAG_REMOVE_SOUND_AND_VIBRATE", "I", AccessFlags = 25)]
				public const int FLAG_REMOVE_SOUND_AND_VIBRATE = 8;
				/// <java-name>
				/// FLAG_VIBRATE
				/// </java-name>
				[Dot42.DexImport("FLAG_VIBRATE", "I", AccessFlags = 25)]
				public const int FLAG_VIBRATE = 16;
				/// <java-name>
				/// RINGER_MODE_SILENT
				/// </java-name>
				[Dot42.DexImport("RINGER_MODE_SILENT", "I", AccessFlags = 25)]
				public const int RINGER_MODE_SILENT = 0;
				/// <java-name>
				/// RINGER_MODE_VIBRATE
				/// </java-name>
				[Dot42.DexImport("RINGER_MODE_VIBRATE", "I", AccessFlags = 25)]
				public const int RINGER_MODE_VIBRATE = 1;
				/// <java-name>
				/// RINGER_MODE_NORMAL
				/// </java-name>
				[Dot42.DexImport("RINGER_MODE_NORMAL", "I", AccessFlags = 25)]
				public const int RINGER_MODE_NORMAL = 2;
				/// <java-name>
				/// VIBRATE_TYPE_RINGER
				/// </java-name>
				[Dot42.DexImport("VIBRATE_TYPE_RINGER", "I", AccessFlags = 25)]
				public const int VIBRATE_TYPE_RINGER = 0;
				/// <java-name>
				/// VIBRATE_TYPE_NOTIFICATION
				/// </java-name>
				[Dot42.DexImport("VIBRATE_TYPE_NOTIFICATION", "I", AccessFlags = 25)]
				public const int VIBRATE_TYPE_NOTIFICATION = 1;
				/// <java-name>
				/// VIBRATE_SETTING_OFF
				/// </java-name>
				[Dot42.DexImport("VIBRATE_SETTING_OFF", "I", AccessFlags = 25)]
				public const int VIBRATE_SETTING_OFF = 0;
				/// <java-name>
				/// VIBRATE_SETTING_ON
				/// </java-name>
				[Dot42.DexImport("VIBRATE_SETTING_ON", "I", AccessFlags = 25)]
				public const int VIBRATE_SETTING_ON = 1;
				/// <java-name>
				/// VIBRATE_SETTING_ONLY_SILENT
				/// </java-name>
				[Dot42.DexImport("VIBRATE_SETTING_ONLY_SILENT", "I", AccessFlags = 25)]
				public const int VIBRATE_SETTING_ONLY_SILENT = 2;
				/// <java-name>
				/// USE_DEFAULT_STREAM_TYPE
				/// </java-name>
				[Dot42.DexImport("USE_DEFAULT_STREAM_TYPE", "I", AccessFlags = 25)]
				public const int USE_DEFAULT_STREAM_TYPE = -2147483648;
				/// <java-name>
				/// ACTION_SCO_AUDIO_STATE_CHANGED
				/// </java-name>
				[Dot42.DexImport("ACTION_SCO_AUDIO_STATE_CHANGED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_SCO_AUDIO_STATE_CHANGED = "android.media.SCO_AUDIO_STATE_CHANGED";
				/// <java-name>
				/// ACTION_SCO_AUDIO_STATE_UPDATED
				/// </java-name>
				[Dot42.DexImport("ACTION_SCO_AUDIO_STATE_UPDATED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_SCO_AUDIO_STATE_UPDATED = "android.media.ACTION_SCO_AUDIO_STATE_UPDATED";
				/// <java-name>
				/// EXTRA_SCO_AUDIO_STATE
				/// </java-name>
				[Dot42.DexImport("EXTRA_SCO_AUDIO_STATE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_SCO_AUDIO_STATE = "android.media.extra.SCO_AUDIO_STATE";
				/// <java-name>
				/// EXTRA_SCO_AUDIO_PREVIOUS_STATE
				/// </java-name>
				[Dot42.DexImport("EXTRA_SCO_AUDIO_PREVIOUS_STATE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_SCO_AUDIO_PREVIOUS_STATE = "android.media.extra.SCO_AUDIO_PREVIOUS_STATE";
				/// <java-name>
				/// SCO_AUDIO_STATE_DISCONNECTED
				/// </java-name>
				[Dot42.DexImport("SCO_AUDIO_STATE_DISCONNECTED", "I", AccessFlags = 25)]
				public const int SCO_AUDIO_STATE_DISCONNECTED = 0;
				/// <java-name>
				/// SCO_AUDIO_STATE_CONNECTED
				/// </java-name>
				[Dot42.DexImport("SCO_AUDIO_STATE_CONNECTED", "I", AccessFlags = 25)]
				public const int SCO_AUDIO_STATE_CONNECTED = 1;
				/// <java-name>
				/// SCO_AUDIO_STATE_CONNECTING
				/// </java-name>
				[Dot42.DexImport("SCO_AUDIO_STATE_CONNECTING", "I", AccessFlags = 25)]
				public const int SCO_AUDIO_STATE_CONNECTING = 2;
				/// <java-name>
				/// SCO_AUDIO_STATE_ERROR
				/// </java-name>
				[Dot42.DexImport("SCO_AUDIO_STATE_ERROR", "I", AccessFlags = 25)]
				public const int SCO_AUDIO_STATE_ERROR = -1;
				/// <java-name>
				/// MODE_INVALID
				/// </java-name>
				[Dot42.DexImport("MODE_INVALID", "I", AccessFlags = 25)]
				public const int MODE_INVALID = -2;
				/// <java-name>
				/// MODE_CURRENT
				/// </java-name>
				[Dot42.DexImport("MODE_CURRENT", "I", AccessFlags = 25)]
				public const int MODE_CURRENT = -1;
				/// <java-name>
				/// MODE_NORMAL
				/// </java-name>
				[Dot42.DexImport("MODE_NORMAL", "I", AccessFlags = 25)]
				public const int MODE_NORMAL = 0;
				/// <java-name>
				/// MODE_RINGTONE
				/// </java-name>
				[Dot42.DexImport("MODE_RINGTONE", "I", AccessFlags = 25)]
				public const int MODE_RINGTONE = 1;
				/// <java-name>
				/// MODE_IN_CALL
				/// </java-name>
				[Dot42.DexImport("MODE_IN_CALL", "I", AccessFlags = 25)]
				public const int MODE_IN_CALL = 2;
				/// <java-name>
				/// MODE_IN_COMMUNICATION
				/// </java-name>
				[Dot42.DexImport("MODE_IN_COMMUNICATION", "I", AccessFlags = 25)]
				public const int MODE_IN_COMMUNICATION = 3;
				/// <java-name>
				/// ROUTE_EARPIECE
				/// </java-name>
				[Dot42.DexImport("ROUTE_EARPIECE", "I", AccessFlags = 25)]
				public const int ROUTE_EARPIECE = 1;
				/// <java-name>
				/// ROUTE_SPEAKER
				/// </java-name>
				[Dot42.DexImport("ROUTE_SPEAKER", "I", AccessFlags = 25)]
				public const int ROUTE_SPEAKER = 2;
				/// <java-name>
				/// ROUTE_BLUETOOTH
				/// </java-name>
				[Dot42.DexImport("ROUTE_BLUETOOTH", "I", AccessFlags = 25)]
				public const int ROUTE_BLUETOOTH = 4;
				/// <java-name>
				/// ROUTE_BLUETOOTH_SCO
				/// </java-name>
				[Dot42.DexImport("ROUTE_BLUETOOTH_SCO", "I", AccessFlags = 25)]
				public const int ROUTE_BLUETOOTH_SCO = 4;
				/// <java-name>
				/// ROUTE_HEADSET
				/// </java-name>
				[Dot42.DexImport("ROUTE_HEADSET", "I", AccessFlags = 25)]
				public const int ROUTE_HEADSET = 8;
				/// <java-name>
				/// ROUTE_BLUETOOTH_A2DP
				/// </java-name>
				[Dot42.DexImport("ROUTE_BLUETOOTH_A2DP", "I", AccessFlags = 25)]
				public const int ROUTE_BLUETOOTH_A2DP = 16;
				/// <java-name>
				/// ROUTE_ALL
				/// </java-name>
				[Dot42.DexImport("ROUTE_ALL", "I", AccessFlags = 25)]
				public const int ROUTE_ALL = -1;
				/// <java-name>
				/// FX_KEY_CLICK
				/// </java-name>
				[Dot42.DexImport("FX_KEY_CLICK", "I", AccessFlags = 25)]
				public const int FX_KEY_CLICK = 0;
				/// <java-name>
				/// FX_FOCUS_NAVIGATION_UP
				/// </java-name>
				[Dot42.DexImport("FX_FOCUS_NAVIGATION_UP", "I", AccessFlags = 25)]
				public const int FX_FOCUS_NAVIGATION_UP = 1;
				/// <java-name>
				/// FX_FOCUS_NAVIGATION_DOWN
				/// </java-name>
				[Dot42.DexImport("FX_FOCUS_NAVIGATION_DOWN", "I", AccessFlags = 25)]
				public const int FX_FOCUS_NAVIGATION_DOWN = 2;
				/// <java-name>
				/// FX_FOCUS_NAVIGATION_LEFT
				/// </java-name>
				[Dot42.DexImport("FX_FOCUS_NAVIGATION_LEFT", "I", AccessFlags = 25)]
				public const int FX_FOCUS_NAVIGATION_LEFT = 3;
				/// <java-name>
				/// FX_FOCUS_NAVIGATION_RIGHT
				/// </java-name>
				[Dot42.DexImport("FX_FOCUS_NAVIGATION_RIGHT", "I", AccessFlags = 25)]
				public const int FX_FOCUS_NAVIGATION_RIGHT = 4;
				/// <java-name>
				/// FX_KEYPRESS_STANDARD
				/// </java-name>
				[Dot42.DexImport("FX_KEYPRESS_STANDARD", "I", AccessFlags = 25)]
				public const int FX_KEYPRESS_STANDARD = 5;
				/// <java-name>
				/// FX_KEYPRESS_SPACEBAR
				/// </java-name>
				[Dot42.DexImport("FX_KEYPRESS_SPACEBAR", "I", AccessFlags = 25)]
				public const int FX_KEYPRESS_SPACEBAR = 6;
				/// <java-name>
				/// FX_KEYPRESS_DELETE
				/// </java-name>
				[Dot42.DexImport("FX_KEYPRESS_DELETE", "I", AccessFlags = 25)]
				public const int FX_KEYPRESS_DELETE = 7;
				/// <java-name>
				/// FX_KEYPRESS_RETURN
				/// </java-name>
				[Dot42.DexImport("FX_KEYPRESS_RETURN", "I", AccessFlags = 25)]
				public const int FX_KEYPRESS_RETURN = 8;
				/// <java-name>
				/// AUDIOFOCUS_GAIN
				/// </java-name>
				[Dot42.DexImport("AUDIOFOCUS_GAIN", "I", AccessFlags = 25)]
				public const int AUDIOFOCUS_GAIN = 1;
				/// <java-name>
				/// AUDIOFOCUS_GAIN_TRANSIENT
				/// </java-name>
				[Dot42.DexImport("AUDIOFOCUS_GAIN_TRANSIENT", "I", AccessFlags = 25)]
				public const int AUDIOFOCUS_GAIN_TRANSIENT = 2;
				/// <java-name>
				/// AUDIOFOCUS_GAIN_TRANSIENT_MAY_DUCK
				/// </java-name>
				[Dot42.DexImport("AUDIOFOCUS_GAIN_TRANSIENT_MAY_DUCK", "I", AccessFlags = 25)]
				public const int AUDIOFOCUS_GAIN_TRANSIENT_MAY_DUCK = 3;
				/// <java-name>
				/// AUDIOFOCUS_LOSS
				/// </java-name>
				[Dot42.DexImport("AUDIOFOCUS_LOSS", "I", AccessFlags = 25)]
				public const int AUDIOFOCUS_LOSS = -1;
				/// <java-name>
				/// AUDIOFOCUS_LOSS_TRANSIENT
				/// </java-name>
				[Dot42.DexImport("AUDIOFOCUS_LOSS_TRANSIENT", "I", AccessFlags = 25)]
				public const int AUDIOFOCUS_LOSS_TRANSIENT = -2;
				/// <java-name>
				/// AUDIOFOCUS_LOSS_TRANSIENT_CAN_DUCK
				/// </java-name>
				[Dot42.DexImport("AUDIOFOCUS_LOSS_TRANSIENT_CAN_DUCK", "I", AccessFlags = 25)]
				public const int AUDIOFOCUS_LOSS_TRANSIENT_CAN_DUCK = -3;
				/// <java-name>
				/// AUDIOFOCUS_REQUEST_FAILED
				/// </java-name>
				[Dot42.DexImport("AUDIOFOCUS_REQUEST_FAILED", "I", AccessFlags = 25)]
				public const int AUDIOFOCUS_REQUEST_FAILED = 0;
				/// <java-name>
				/// AUDIOFOCUS_REQUEST_GRANTED
				/// </java-name>
				[Dot42.DexImport("AUDIOFOCUS_REQUEST_GRANTED", "I", AccessFlags = 25)]
				public const int AUDIOFOCUS_REQUEST_GRANTED = 1;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal AudioManager() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// adjustStreamVolume
				/// </java-name>
				[Dot42.DexImport("adjustStreamVolume", "(III)V", AccessFlags = 1)]
				public virtual void AdjustStreamVolume(int int32, int int321, int int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// adjustVolume
				/// </java-name>
				[Dot42.DexImport("adjustVolume", "(II)V", AccessFlags = 1)]
				public virtual void AdjustVolume(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// adjustSuggestedStreamVolume
				/// </java-name>
				[Dot42.DexImport("adjustSuggestedStreamVolume", "(III)V", AccessFlags = 1)]
				public virtual void AdjustSuggestedStreamVolume(int int32, int int321, int int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getRingerMode
				/// </java-name>
				[Dot42.DexImport("getRingerMode", "()I", AccessFlags = 1)]
				public virtual int GetRingerMode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getStreamMaxVolume
				/// </java-name>
				[Dot42.DexImport("getStreamMaxVolume", "(I)I", AccessFlags = 1)]
				public virtual int GetStreamMaxVolume(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getStreamVolume
				/// </java-name>
				[Dot42.DexImport("getStreamVolume", "(I)I", AccessFlags = 1)]
				public virtual int GetStreamVolume(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// setRingerMode
				/// </java-name>
				[Dot42.DexImport("setRingerMode", "(I)V", AccessFlags = 1)]
				public virtual void SetRingerMode(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setStreamVolume
				/// </java-name>
				[Dot42.DexImport("setStreamVolume", "(III)V", AccessFlags = 1)]
				public virtual void SetStreamVolume(int int32, int int321, int int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setStreamSolo
				/// </java-name>
				[Dot42.DexImport("setStreamSolo", "(IZ)V", AccessFlags = 1)]
				public virtual void SetStreamSolo(int int32, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setStreamMute
				/// </java-name>
				[Dot42.DexImport("setStreamMute", "(IZ)V", AccessFlags = 1)]
				public virtual void SetStreamMute(int int32, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// shouldVibrate
				/// </java-name>
				[Dot42.DexImport("shouldVibrate", "(I)Z", AccessFlags = 1)]
				public virtual bool ShouldVibrate(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getVibrateSetting
				/// </java-name>
				[Dot42.DexImport("getVibrateSetting", "(I)I", AccessFlags = 1)]
				public virtual int GetVibrateSetting(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// setVibrateSetting
				/// </java-name>
				[Dot42.DexImport("setVibrateSetting", "(II)V", AccessFlags = 1)]
				public virtual void SetVibrateSetting(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setSpeakerphoneOn
				/// </java-name>
				[Dot42.DexImport("setSpeakerphoneOn", "(Z)V", AccessFlags = 1)]
				public virtual void SetSpeakerphoneOn(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isSpeakerphoneOn
				/// </java-name>
				[Dot42.DexImport("isSpeakerphoneOn", "()Z", AccessFlags = 1)]
				public virtual bool IsSpeakerphoneOn() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isBluetoothScoAvailableOffCall
				/// </java-name>
				[Dot42.DexImport("isBluetoothScoAvailableOffCall", "()Z", AccessFlags = 1)]
				public virtual bool IsBluetoothScoAvailableOffCall() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// startBluetoothSco
				/// </java-name>
				[Dot42.DexImport("startBluetoothSco", "()V", AccessFlags = 1)]
				public virtual void StartBluetoothSco() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// stopBluetoothSco
				/// </java-name>
				[Dot42.DexImport("stopBluetoothSco", "()V", AccessFlags = 1)]
				public virtual void StopBluetoothSco() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setBluetoothScoOn
				/// </java-name>
				[Dot42.DexImport("setBluetoothScoOn", "(Z)V", AccessFlags = 1)]
				public virtual void SetBluetoothScoOn(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isBluetoothScoOn
				/// </java-name>
				[Dot42.DexImport("isBluetoothScoOn", "()Z", AccessFlags = 1)]
				public virtual bool IsBluetoothScoOn() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setBluetoothA2dpOn
				/// </java-name>
				[Dot42.DexImport("setBluetoothA2dpOn", "(Z)V", AccessFlags = 1)]
				public virtual void SetBluetoothA2dpOn(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isBluetoothA2dpOn
				/// </java-name>
				[Dot42.DexImport("isBluetoothA2dpOn", "()Z", AccessFlags = 1)]
				public virtual bool IsBluetoothA2dpOn() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setWiredHeadsetOn
				/// </java-name>
				[Dot42.DexImport("setWiredHeadsetOn", "(Z)V", AccessFlags = 1)]
				public virtual void SetWiredHeadsetOn(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isWiredHeadsetOn
				/// </java-name>
				[Dot42.DexImport("isWiredHeadsetOn", "()Z", AccessFlags = 1)]
				public virtual bool IsWiredHeadsetOn() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setMicrophoneMute
				/// </java-name>
				[Dot42.DexImport("setMicrophoneMute", "(Z)V", AccessFlags = 1)]
				public virtual void SetMicrophoneMute(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isMicrophoneMute
				/// </java-name>
				[Dot42.DexImport("isMicrophoneMute", "()Z", AccessFlags = 1)]
				public virtual bool IsMicrophoneMute() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setMode
				/// </java-name>
				[Dot42.DexImport("setMode", "(I)V", AccessFlags = 1)]
				public virtual void SetMode(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getMode
				/// </java-name>
				[Dot42.DexImport("getMode", "()I", AccessFlags = 1)]
				public virtual int GetMode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// setRouting
				/// </java-name>
				[Dot42.DexImport("setRouting", "(III)V", AccessFlags = 1)]
				public virtual void SetRouting(int int32, int int321, int int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getRouting
				/// </java-name>
				[Dot42.DexImport("getRouting", "(I)I", AccessFlags = 1)]
				public virtual int GetRouting(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// isMusicActive
				/// </java-name>
				[Dot42.DexImport("isMusicActive", "()Z", AccessFlags = 1)]
				public virtual bool IsMusicActive() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setParameters
				/// </java-name>
				[Dot42.DexImport("setParameters", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetParameters(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getParameters
				/// </java-name>
				[Dot42.DexImport("getParameters", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetParameters(string @string) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// playSoundEffect
				/// </java-name>
				[Dot42.DexImport("playSoundEffect", "(I)V", AccessFlags = 1)]
				public virtual void PlaySoundEffect(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// playSoundEffect
				/// </java-name>
				[Dot42.DexImport("playSoundEffect", "(IF)V", AccessFlags = 1)]
				public virtual void PlaySoundEffect(int int32, float single) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// loadSoundEffects
				/// </java-name>
				[Dot42.DexImport("loadSoundEffects", "()V", AccessFlags = 1)]
				public virtual void LoadSoundEffects() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// unloadSoundEffects
				/// </java-name>
				[Dot42.DexImport("unloadSoundEffects", "()V", AccessFlags = 1)]
				public virtual void UnloadSoundEffects() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// requestAudioFocus
				/// </java-name>
				[Dot42.DexImport("requestAudioFocus", "(Landroid/media/AudioManager$OnAudioFocusChangeListener;II)I", AccessFlags = 1)]
				public virtual int RequestAudioFocus(global::Android.Media.AudioManager.IOnAudioFocusChangeListener onAudioFocusChangeListener, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// abandonAudioFocus
				/// </java-name>
				[Dot42.DexImport("abandonAudioFocus", "(Landroid/media/AudioManager$OnAudioFocusChangeListener;)I", AccessFlags = 1)]
				public virtual int AbandonAudioFocus(global::Android.Media.AudioManager.IOnAudioFocusChangeListener onAudioFocusChangeListener) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// registerMediaButtonEventReceiver
				/// </java-name>
				[Dot42.DexImport("registerMediaButtonEventReceiver", "(Landroid/content/ComponentName;)V", AccessFlags = 1)]
				public virtual void RegisterMediaButtonEventReceiver(global::Android.Content.ComponentName componentName) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// unregisterMediaButtonEventReceiver
				/// </java-name>
				[Dot42.DexImport("unregisterMediaButtonEventReceiver", "(Landroid/content/ComponentName;)V", AccessFlags = 1)]
				public virtual void UnregisterMediaButtonEventReceiver(global::Android.Content.ComponentName componentName) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// registerRemoteControlClient
				/// </java-name>
				[Dot42.DexImport("registerRemoteControlClient", "(Landroid/media/RemoteControlClient;)V", AccessFlags = 1)]
				public virtual void RegisterRemoteControlClient(global::Android.Media.RemoteControlClient remoteControlClient) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// unregisterRemoteControlClient
				/// </java-name>
				[Dot42.DexImport("unregisterRemoteControlClient", "(Landroid/media/RemoteControlClient;)V", AccessFlags = 1)]
				public virtual void UnregisterRemoteControlClient(global::Android.Media.RemoteControlClient remoteControlClient) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getRingerMode
				/// </java-name>
				public int RingerMode
				{
				[Dot42.DexImport("getRingerMode", "()I", AccessFlags = 1)]
						get{ return GetRingerMode(); }
				[Dot42.DexImport("setRingerMode", "(I)V", AccessFlags = 1)]
						set{ SetRingerMode(value); }
				}

				/// <java-name>
				/// getMode
				/// </java-name>
				public int Mode
				{
				[Dot42.DexImport("getMode", "()I", AccessFlags = 1)]
						get{ return GetMode(); }
				[Dot42.DexImport("setMode", "(I)V", AccessFlags = 1)]
						set{ SetMode(value); }
				}

				/// <java-name>
				/// android/media/AudioManager$OnAudioFocusChangeListener
				/// </java-name>
				[Dot42.DexImport("android/media/AudioManager$OnAudioFocusChangeListener", AccessFlags = 1545)]
				public partial interface IOnAudioFocusChangeListener
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onAudioFocusChange
						/// </java-name>
						[Dot42.DexImport("onAudioFocusChange", "(I)V", AccessFlags = 1025)]
						void OnAudioFocusChange(int int32) /* MethodBuilder.Create */ ;

				}

		}

		/// <java-name>
		/// android/media/AudioRecord
		/// </java-name>
		[Dot42.DexImport("android/media/AudioRecord", AccessFlags = 33)]
		public partial class AudioRecord
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// STATE_UNINITIALIZED
				/// </java-name>
				[Dot42.DexImport("STATE_UNINITIALIZED", "I", AccessFlags = 25)]
				public const int STATE_UNINITIALIZED = 0;
				/// <java-name>
				/// STATE_INITIALIZED
				/// </java-name>
				[Dot42.DexImport("STATE_INITIALIZED", "I", AccessFlags = 25)]
				public const int STATE_INITIALIZED = 1;
				/// <java-name>
				/// RECORDSTATE_STOPPED
				/// </java-name>
				[Dot42.DexImport("RECORDSTATE_STOPPED", "I", AccessFlags = 25)]
				public const int RECORDSTATE_STOPPED = 1;
				/// <java-name>
				/// RECORDSTATE_RECORDING
				/// </java-name>
				[Dot42.DexImport("RECORDSTATE_RECORDING", "I", AccessFlags = 25)]
				public const int RECORDSTATE_RECORDING = 3;
				/// <java-name>
				/// SUCCESS
				/// </java-name>
				[Dot42.DexImport("SUCCESS", "I", AccessFlags = 25)]
				public const int SUCCESS = 0;
				/// <java-name>
				/// ERROR
				/// </java-name>
				[Dot42.DexImport("ERROR", "I", AccessFlags = 25)]
				public const int ERROR = -1;
				/// <java-name>
				/// ERROR_BAD_VALUE
				/// </java-name>
				[Dot42.DexImport("ERROR_BAD_VALUE", "I", AccessFlags = 25)]
				public const int ERROR_BAD_VALUE = -2;
				/// <java-name>
				/// ERROR_INVALID_OPERATION
				/// </java-name>
				[Dot42.DexImport("ERROR_INVALID_OPERATION", "I", AccessFlags = 25)]
				public const int ERROR_INVALID_OPERATION = -3;
				[Dot42.DexImport("<init>", "(IIIII)V", AccessFlags = 1)]
				public AudioRecord(int int32, int int321, int int322, int int323, int int324) /* MethodBuilder.Create */ 
				{
				}

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

				/// <java-name>
				/// getSampleRate
				/// </java-name>
				[Dot42.DexImport("getSampleRate", "()I", AccessFlags = 1)]
				public virtual int GetSampleRate() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getAudioSource
				/// </java-name>
				[Dot42.DexImport("getAudioSource", "()I", AccessFlags = 1)]
				public virtual int GetAudioSource() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getAudioFormat
				/// </java-name>
				[Dot42.DexImport("getAudioFormat", "()I", AccessFlags = 1)]
				public virtual int GetAudioFormat() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getChannelConfiguration
				/// </java-name>
				[Dot42.DexImport("getChannelConfiguration", "()I", AccessFlags = 1)]
				public virtual int GetChannelConfiguration() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getChannelCount
				/// </java-name>
				[Dot42.DexImport("getChannelCount", "()I", AccessFlags = 1)]
				public virtual int GetChannelCount() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getState
				/// </java-name>
				[Dot42.DexImport("getState", "()I", AccessFlags = 1)]
				public virtual int GetState() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getRecordingState
				/// </java-name>
				[Dot42.DexImport("getRecordingState", "()I", AccessFlags = 1)]
				public virtual int GetRecordingState() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getNotificationMarkerPosition
				/// </java-name>
				[Dot42.DexImport("getNotificationMarkerPosition", "()I", AccessFlags = 1)]
				public virtual int GetNotificationMarkerPosition() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getPositionNotificationPeriod
				/// </java-name>
				[Dot42.DexImport("getPositionNotificationPeriod", "()I", AccessFlags = 1)]
				public virtual int GetPositionNotificationPeriod() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getMinBufferSize
				/// </java-name>
				[Dot42.DexImport("getMinBufferSize", "(III)I", AccessFlags = 9)]
				public static int GetMinBufferSize(int int32, int int321, int int322) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// startRecording
				/// </java-name>
				[Dot42.DexImport("startRecording", "()V", AccessFlags = 1)]
				public virtual void StartRecording() /* MethodBuilder.Create */ 
				{
				}

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
				[Dot42.DexImport("read", "([BII)I", AccessFlags = 1)]
				public virtual int Read(sbyte[] sByte, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([BII)I", AccessFlags = 1, IgnoreFromJava = true)]
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

				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "(Ljava/nio/ByteBuffer;I)I", AccessFlags = 1)]
				public virtual int Read(global::Java.Nio.ByteBuffer byteBuffer, int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// setRecordPositionUpdateListener
				/// </java-name>
				[Dot42.DexImport("setRecordPositionUpdateListener", "(Landroid/media/AudioRecord$OnRecordPositionUpdateListener;)V", AccessFlags = 1)]
				public virtual void SetRecordPositionUpdateListener(global::Android.Media.AudioRecord.IOnRecordPositionUpdateListener onRecordPositionUpdateListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setRecordPositionUpdateListener
				/// </java-name>
				[Dot42.DexImport("setRecordPositionUpdateListener", "(Landroid/media/AudioRecord$OnRecordPositionUpdateListener;Landroid/os/Handler;)V" +
    "", AccessFlags = 1)]
				public virtual void SetRecordPositionUpdateListener(global::Android.Media.AudioRecord.IOnRecordPositionUpdateListener onRecordPositionUpdateListener, global::Android.OS.Handler handler) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setNotificationMarkerPosition
				/// </java-name>
				[Dot42.DexImport("setNotificationMarkerPosition", "(I)I", AccessFlags = 1)]
				public virtual int SetNotificationMarkerPosition(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// setPositionNotificationPeriod
				/// </java-name>
				[Dot42.DexImport("setPositionNotificationPeriod", "(I)I", AccessFlags = 1)]
				public virtual int SetPositionNotificationPeriod(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal AudioRecord() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getSampleRate
				/// </java-name>
				public int SampleRate
				{
				[Dot42.DexImport("getSampleRate", "()I", AccessFlags = 1)]
						get{ return GetSampleRate(); }
				}

				/// <java-name>
				/// getAudioSource
				/// </java-name>
				public int AudioSource
				{
				[Dot42.DexImport("getAudioSource", "()I", AccessFlags = 1)]
						get{ return GetAudioSource(); }
				}

				/// <java-name>
				/// getAudioFormat
				/// </java-name>
				public int AudioFormat
				{
				[Dot42.DexImport("getAudioFormat", "()I", AccessFlags = 1)]
						get{ return GetAudioFormat(); }
				}

				/// <java-name>
				/// getChannelConfiguration
				/// </java-name>
				public int ChannelConfiguration
				{
				[Dot42.DexImport("getChannelConfiguration", "()I", AccessFlags = 1)]
						get{ return GetChannelConfiguration(); }
				}

				/// <java-name>
				/// getChannelCount
				/// </java-name>
				public int ChannelCount
				{
				[Dot42.DexImport("getChannelCount", "()I", AccessFlags = 1)]
						get{ return GetChannelCount(); }
				}

				/// <java-name>
				/// getState
				/// </java-name>
				public int State
				{
				[Dot42.DexImport("getState", "()I", AccessFlags = 1)]
						get{ return GetState(); }
				}

				/// <java-name>
				/// getRecordingState
				/// </java-name>
				public int RecordingState
				{
				[Dot42.DexImport("getRecordingState", "()I", AccessFlags = 1)]
						get{ return GetRecordingState(); }
				}

				/// <java-name>
				/// getNotificationMarkerPosition
				/// </java-name>
				public int NotificationMarkerPosition
				{
				[Dot42.DexImport("getNotificationMarkerPosition", "()I", AccessFlags = 1)]
						get{ return GetNotificationMarkerPosition(); }
				}

				/// <java-name>
				/// getPositionNotificationPeriod
				/// </java-name>
				public int PositionNotificationPeriod
				{
				[Dot42.DexImport("getPositionNotificationPeriod", "()I", AccessFlags = 1)]
						get{ return GetPositionNotificationPeriod(); }
				}

				/// <java-name>
				/// android/media/AudioRecord$OnRecordPositionUpdateListener
				/// </java-name>
				[Dot42.DexImport("android/media/AudioRecord$OnRecordPositionUpdateListener", AccessFlags = 1545)]
				public partial interface IOnRecordPositionUpdateListener
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onMarkerReached
						/// </java-name>
						[Dot42.DexImport("onMarkerReached", "(Landroid/media/AudioRecord;)V", AccessFlags = 1025)]
						void OnMarkerReached(global::Android.Media.AudioRecord audioRecord) /* MethodBuilder.Create */ ;

						/// <java-name>
						/// onPeriodicNotification
						/// </java-name>
						[Dot42.DexImport("onPeriodicNotification", "(Landroid/media/AudioRecord;)V", AccessFlags = 1025)]
						void OnPeriodicNotification(global::Android.Media.AudioRecord audioRecord) /* MethodBuilder.Create */ ;

				}

		}

		/// <java-name>
		/// android/media/AudioTrack
		/// </java-name>
		[Dot42.DexImport("android/media/AudioTrack", AccessFlags = 33)]
		public partial class AudioTrack
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// PLAYSTATE_STOPPED
				/// </java-name>
				[Dot42.DexImport("PLAYSTATE_STOPPED", "I", AccessFlags = 25)]
				public const int PLAYSTATE_STOPPED = 1;
				/// <java-name>
				/// PLAYSTATE_PAUSED
				/// </java-name>
				[Dot42.DexImport("PLAYSTATE_PAUSED", "I", AccessFlags = 25)]
				public const int PLAYSTATE_PAUSED = 2;
				/// <java-name>
				/// PLAYSTATE_PLAYING
				/// </java-name>
				[Dot42.DexImport("PLAYSTATE_PLAYING", "I", AccessFlags = 25)]
				public const int PLAYSTATE_PLAYING = 3;
				/// <java-name>
				/// MODE_STATIC
				/// </java-name>
				[Dot42.DexImport("MODE_STATIC", "I", AccessFlags = 25)]
				public const int MODE_STATIC = 0;
				/// <java-name>
				/// MODE_STREAM
				/// </java-name>
				[Dot42.DexImport("MODE_STREAM", "I", AccessFlags = 25)]
				public const int MODE_STREAM = 1;
				/// <java-name>
				/// STATE_UNINITIALIZED
				/// </java-name>
				[Dot42.DexImport("STATE_UNINITIALIZED", "I", AccessFlags = 25)]
				public const int STATE_UNINITIALIZED = 0;
				/// <java-name>
				/// STATE_INITIALIZED
				/// </java-name>
				[Dot42.DexImport("STATE_INITIALIZED", "I", AccessFlags = 25)]
				public const int STATE_INITIALIZED = 1;
				/// <java-name>
				/// STATE_NO_STATIC_DATA
				/// </java-name>
				[Dot42.DexImport("STATE_NO_STATIC_DATA", "I", AccessFlags = 25)]
				public const int STATE_NO_STATIC_DATA = 2;
				/// <java-name>
				/// SUCCESS
				/// </java-name>
				[Dot42.DexImport("SUCCESS", "I", AccessFlags = 25)]
				public const int SUCCESS = 0;
				/// <java-name>
				/// ERROR
				/// </java-name>
				[Dot42.DexImport("ERROR", "I", AccessFlags = 25)]
				public const int ERROR = -1;
				/// <java-name>
				/// ERROR_BAD_VALUE
				/// </java-name>
				[Dot42.DexImport("ERROR_BAD_VALUE", "I", AccessFlags = 25)]
				public const int ERROR_BAD_VALUE = -2;
				/// <java-name>
				/// ERROR_INVALID_OPERATION
				/// </java-name>
				[Dot42.DexImport("ERROR_INVALID_OPERATION", "I", AccessFlags = 25)]
				public const int ERROR_INVALID_OPERATION = -3;
				[Dot42.DexImport("<init>", "(IIIIII)V", AccessFlags = 1)]
				public AudioTrack(int int32, int int321, int int322, int int323, int int324, int int325) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(IIIIIII)V", AccessFlags = 1)]
				public AudioTrack(int int32, int int321, int int322, int int323, int int324, int int325, int int326) /* MethodBuilder.Create */ 
				{
				}

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

				/// <java-name>
				/// getMinVolume
				/// </java-name>
				[Dot42.DexImport("getMinVolume", "()F", AccessFlags = 9)]
				public static float GetMinVolume() /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// getMaxVolume
				/// </java-name>
				[Dot42.DexImport("getMaxVolume", "()F", AccessFlags = 9)]
				public static float GetMaxVolume() /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// getSampleRate
				/// </java-name>
				[Dot42.DexImport("getSampleRate", "()I", AccessFlags = 1)]
				public virtual int GetSampleRate() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getPlaybackRate
				/// </java-name>
				[Dot42.DexImport("getPlaybackRate", "()I", AccessFlags = 1)]
				public virtual int GetPlaybackRate() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getAudioFormat
				/// </java-name>
				[Dot42.DexImport("getAudioFormat", "()I", AccessFlags = 1)]
				public virtual int GetAudioFormat() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getStreamType
				/// </java-name>
				[Dot42.DexImport("getStreamType", "()I", AccessFlags = 1)]
				public virtual int GetStreamType() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getChannelConfiguration
				/// </java-name>
				[Dot42.DexImport("getChannelConfiguration", "()I", AccessFlags = 1)]
				public virtual int GetChannelConfiguration() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getChannelCount
				/// </java-name>
				[Dot42.DexImport("getChannelCount", "()I", AccessFlags = 1)]
				public virtual int GetChannelCount() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getState
				/// </java-name>
				[Dot42.DexImport("getState", "()I", AccessFlags = 1)]
				public virtual int GetState() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getPlayState
				/// </java-name>
				[Dot42.DexImport("getPlayState", "()I", AccessFlags = 1)]
				public virtual int GetPlayState() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getNativeFrameCount
				/// </java-name>
				[Dot42.DexImport("getNativeFrameCount", "()I", AccessFlags = 4)]
				protected internal virtual int GetNativeFrameCount() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getNotificationMarkerPosition
				/// </java-name>
				[Dot42.DexImport("getNotificationMarkerPosition", "()I", AccessFlags = 1)]
				public virtual int GetNotificationMarkerPosition() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getPositionNotificationPeriod
				/// </java-name>
				[Dot42.DexImport("getPositionNotificationPeriod", "()I", AccessFlags = 1)]
				public virtual int GetPositionNotificationPeriod() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getPlaybackHeadPosition
				/// </java-name>
				[Dot42.DexImport("getPlaybackHeadPosition", "()I", AccessFlags = 1)]
				public virtual int GetPlaybackHeadPosition() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getNativeOutputSampleRate
				/// </java-name>
				[Dot42.DexImport("getNativeOutputSampleRate", "(I)I", AccessFlags = 9)]
				public static int GetNativeOutputSampleRate(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getMinBufferSize
				/// </java-name>
				[Dot42.DexImport("getMinBufferSize", "(III)I", AccessFlags = 9)]
				public static int GetMinBufferSize(int int32, int int321, int int322) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getAudioSessionId
				/// </java-name>
				[Dot42.DexImport("getAudioSessionId", "()I", AccessFlags = 1)]
				public virtual int GetAudioSessionId() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// setPlaybackPositionUpdateListener
				/// </java-name>
				[Dot42.DexImport("setPlaybackPositionUpdateListener", "(Landroid/media/AudioTrack$OnPlaybackPositionUpdateListener;)V", AccessFlags = 1)]
				public virtual void SetPlaybackPositionUpdateListener(global::Android.Media.AudioTrack.IOnPlaybackPositionUpdateListener onPlaybackPositionUpdateListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setPlaybackPositionUpdateListener
				/// </java-name>
				[Dot42.DexImport("setPlaybackPositionUpdateListener", "(Landroid/media/AudioTrack$OnPlaybackPositionUpdateListener;Landroid/os/Handler;)" +
    "V", AccessFlags = 1)]
				public virtual void SetPlaybackPositionUpdateListener(global::Android.Media.AudioTrack.IOnPlaybackPositionUpdateListener onPlaybackPositionUpdateListener, global::Android.OS.Handler handler) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setStereoVolume
				/// </java-name>
				[Dot42.DexImport("setStereoVolume", "(FF)I", AccessFlags = 1)]
				public virtual int SetStereoVolume(float single, float single1) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// setPlaybackRate
				/// </java-name>
				[Dot42.DexImport("setPlaybackRate", "(I)I", AccessFlags = 1)]
				public virtual int SetPlaybackRate(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// setNotificationMarkerPosition
				/// </java-name>
				[Dot42.DexImport("setNotificationMarkerPosition", "(I)I", AccessFlags = 1)]
				public virtual int SetNotificationMarkerPosition(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// setPositionNotificationPeriod
				/// </java-name>
				[Dot42.DexImport("setPositionNotificationPeriod", "(I)I", AccessFlags = 1)]
				public virtual int SetPositionNotificationPeriod(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// setPlaybackHeadPosition
				/// </java-name>
				[Dot42.DexImport("setPlaybackHeadPosition", "(I)I", AccessFlags = 1)]
				public virtual int SetPlaybackHeadPosition(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// setLoopPoints
				/// </java-name>
				[Dot42.DexImport("setLoopPoints", "(III)I", AccessFlags = 1)]
				public virtual int SetLoopPoints(int int32, int int321, int int322) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// setState
				/// </java-name>
				[Dot42.DexImport("setState", "(I)V", AccessFlags = 4)]
				protected internal virtual void SetState(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// play
				/// </java-name>
				[Dot42.DexImport("play", "()V", AccessFlags = 1)]
				public virtual void Play() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// stop
				/// </java-name>
				[Dot42.DexImport("stop", "()V", AccessFlags = 1)]
				public virtual void Stop() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// pause
				/// </java-name>
				[Dot42.DexImport("pause", "()V", AccessFlags = 1)]
				public virtual void Pause() /* MethodBuilder.Create */ 
				{
				}

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
				[Dot42.DexImport("write", "([BII)I", AccessFlags = 1)]
				public virtual int Write(sbyte[] sByte, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([BII)I", AccessFlags = 1, IgnoreFromJava = true)]
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

				/// <java-name>
				/// reloadStaticData
				/// </java-name>
				[Dot42.DexImport("reloadStaticData", "()I", AccessFlags = 1)]
				public virtual int ReloadStaticData() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// attachAuxEffect
				/// </java-name>
				[Dot42.DexImport("attachAuxEffect", "(I)I", AccessFlags = 1)]
				public virtual int AttachAuxEffect(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// setAuxEffectSendLevel
				/// </java-name>
				[Dot42.DexImport("setAuxEffectSendLevel", "(F)I", AccessFlags = 1)]
				public virtual int SetAuxEffectSendLevel(float single) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal AudioTrack() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getMinVolume
				/// </java-name>
				public static float MinVolume
				{
				[Dot42.DexImport("getMinVolume", "()F", AccessFlags = 9)]
						get{ return GetMinVolume(); }
				}

				/// <java-name>
				/// getMaxVolume
				/// </java-name>
				public static float MaxVolume
				{
				[Dot42.DexImport("getMaxVolume", "()F", AccessFlags = 9)]
						get{ return GetMaxVolume(); }
				}

				/// <java-name>
				/// getSampleRate
				/// </java-name>
				public int SampleRate
				{
				[Dot42.DexImport("getSampleRate", "()I", AccessFlags = 1)]
						get{ return GetSampleRate(); }
				}

				/// <java-name>
				/// getPlaybackRate
				/// </java-name>
				public int PlaybackRate
				{
				[Dot42.DexImport("getPlaybackRate", "()I", AccessFlags = 1)]
						get{ return GetPlaybackRate(); }
				}

				/// <java-name>
				/// getAudioFormat
				/// </java-name>
				public int AudioFormat
				{
				[Dot42.DexImport("getAudioFormat", "()I", AccessFlags = 1)]
						get{ return GetAudioFormat(); }
				}

				/// <java-name>
				/// getStreamType
				/// </java-name>
				public int StreamType
				{
				[Dot42.DexImport("getStreamType", "()I", AccessFlags = 1)]
						get{ return GetStreamType(); }
				}

				/// <java-name>
				/// getChannelConfiguration
				/// </java-name>
				public int ChannelConfiguration
				{
				[Dot42.DexImport("getChannelConfiguration", "()I", AccessFlags = 1)]
						get{ return GetChannelConfiguration(); }
				}

				/// <java-name>
				/// getChannelCount
				/// </java-name>
				public int ChannelCount
				{
				[Dot42.DexImport("getChannelCount", "()I", AccessFlags = 1)]
						get{ return GetChannelCount(); }
				}

				/// <java-name>
				/// getState
				/// </java-name>
				public int State
				{
				[Dot42.DexImport("getState", "()I", AccessFlags = 1)]
						get{ return GetState(); }
				[Dot42.DexImport("setState", "(I)V", AccessFlags = 4)]
						set{ SetState(value); }
				}

				/// <java-name>
				/// getPlayState
				/// </java-name>
				public int PlayState
				{
				[Dot42.DexImport("getPlayState", "()I", AccessFlags = 1)]
						get{ return GetPlayState(); }
				}

				/// <java-name>
				/// getNativeFrameCount
				/// </java-name>
				protected internal int NativeFrameCount
				{
				[Dot42.DexImport("getNativeFrameCount", "()I", AccessFlags = 4)]
						get{ return GetNativeFrameCount(); }
				}

				/// <java-name>
				/// getNotificationMarkerPosition
				/// </java-name>
				public int NotificationMarkerPosition
				{
				[Dot42.DexImport("getNotificationMarkerPosition", "()I", AccessFlags = 1)]
						get{ return GetNotificationMarkerPosition(); }
				}

				/// <java-name>
				/// getPositionNotificationPeriod
				/// </java-name>
				public int PositionNotificationPeriod
				{
				[Dot42.DexImport("getPositionNotificationPeriod", "()I", AccessFlags = 1)]
						get{ return GetPositionNotificationPeriod(); }
				}

				/// <java-name>
				/// getPlaybackHeadPosition
				/// </java-name>
				public int PlaybackHeadPosition
				{
				[Dot42.DexImport("getPlaybackHeadPosition", "()I", AccessFlags = 1)]
						get{ return GetPlaybackHeadPosition(); }
				}

				/// <java-name>
				/// getAudioSessionId
				/// </java-name>
				public int AudioSessionId
				{
				[Dot42.DexImport("getAudioSessionId", "()I", AccessFlags = 1)]
						get{ return GetAudioSessionId(); }
				}

				/// <java-name>
				/// android/media/AudioTrack$OnPlaybackPositionUpdateListener
				/// </java-name>
				[Dot42.DexImport("android/media/AudioTrack$OnPlaybackPositionUpdateListener", AccessFlags = 1545)]
				public partial interface IOnPlaybackPositionUpdateListener
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onMarkerReached
						/// </java-name>
						[Dot42.DexImport("onMarkerReached", "(Landroid/media/AudioTrack;)V", AccessFlags = 1025)]
						void OnMarkerReached(global::Android.Media.AudioTrack audioTrack) /* MethodBuilder.Create */ ;

						/// <java-name>
						/// onPeriodicNotification
						/// </java-name>
						[Dot42.DexImport("onPeriodicNotification", "(Landroid/media/AudioTrack;)V", AccessFlags = 1025)]
						void OnPeriodicNotification(global::Android.Media.AudioTrack audioTrack) /* MethodBuilder.Create */ ;

				}

		}

		/// <java-name>
		/// android/media/CamcorderProfile
		/// </java-name>
		[Dot42.DexImport("android/media/CamcorderProfile", AccessFlags = 33)]
		public partial class CamcorderProfile
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// QUALITY_LOW
				/// </java-name>
				[Dot42.DexImport("QUALITY_LOW", "I", AccessFlags = 25)]
				public const int QUALITY_LOW = 0;
				/// <java-name>
				/// QUALITY_HIGH
				/// </java-name>
				[Dot42.DexImport("QUALITY_HIGH", "I", AccessFlags = 25)]
				public const int QUALITY_HIGH = 1;
				/// <java-name>
				/// QUALITY_QCIF
				/// </java-name>
				[Dot42.DexImport("QUALITY_QCIF", "I", AccessFlags = 25)]
				public const int QUALITY_QCIF = 2;
				/// <java-name>
				/// QUALITY_CIF
				/// </java-name>
				[Dot42.DexImport("QUALITY_CIF", "I", AccessFlags = 25)]
				public const int QUALITY_CIF = 3;
				/// <java-name>
				/// QUALITY_480P
				/// </java-name>
				[Dot42.DexImport("QUALITY_480P", "I", AccessFlags = 25)]
				public const int QUALITY_480P = 4;
				/// <java-name>
				/// QUALITY_720P
				/// </java-name>
				[Dot42.DexImport("QUALITY_720P", "I", AccessFlags = 25)]
				public const int QUALITY_720P = 5;
				/// <java-name>
				/// QUALITY_1080P
				/// </java-name>
				[Dot42.DexImport("QUALITY_1080P", "I", AccessFlags = 25)]
				public const int QUALITY_1080P = 6;
				/// <java-name>
				/// QUALITY_QVGA
				/// </java-name>
				[Dot42.DexImport("QUALITY_QVGA", "I", AccessFlags = 25)]
				public const int QUALITY_QVGA = 7;
				/// <java-name>
				/// QUALITY_TIME_LAPSE_LOW
				/// </java-name>
				[Dot42.DexImport("QUALITY_TIME_LAPSE_LOW", "I", AccessFlags = 25)]
				public const int QUALITY_TIME_LAPSE_LOW = 1000;
				/// <java-name>
				/// QUALITY_TIME_LAPSE_HIGH
				/// </java-name>
				[Dot42.DexImport("QUALITY_TIME_LAPSE_HIGH", "I", AccessFlags = 25)]
				public const int QUALITY_TIME_LAPSE_HIGH = 1001;
				/// <java-name>
				/// QUALITY_TIME_LAPSE_QCIF
				/// </java-name>
				[Dot42.DexImport("QUALITY_TIME_LAPSE_QCIF", "I", AccessFlags = 25)]
				public const int QUALITY_TIME_LAPSE_QCIF = 1002;
				/// <java-name>
				/// QUALITY_TIME_LAPSE_CIF
				/// </java-name>
				[Dot42.DexImport("QUALITY_TIME_LAPSE_CIF", "I", AccessFlags = 25)]
				public const int QUALITY_TIME_LAPSE_CIF = 1003;
				/// <java-name>
				/// QUALITY_TIME_LAPSE_480P
				/// </java-name>
				[Dot42.DexImport("QUALITY_TIME_LAPSE_480P", "I", AccessFlags = 25)]
				public const int QUALITY_TIME_LAPSE_480P = 1004;
				/// <java-name>
				/// QUALITY_TIME_LAPSE_720P
				/// </java-name>
				[Dot42.DexImport("QUALITY_TIME_LAPSE_720P", "I", AccessFlags = 25)]
				public const int QUALITY_TIME_LAPSE_720P = 1005;
				/// <java-name>
				/// QUALITY_TIME_LAPSE_1080P
				/// </java-name>
				[Dot42.DexImport("QUALITY_TIME_LAPSE_1080P", "I", AccessFlags = 25)]
				public const int QUALITY_TIME_LAPSE_1080P = 1006;
				/// <java-name>
				/// QUALITY_TIME_LAPSE_QVGA
				/// </java-name>
				[Dot42.DexImport("QUALITY_TIME_LAPSE_QVGA", "I", AccessFlags = 25)]
				public const int QUALITY_TIME_LAPSE_QVGA = 1007;
				/// <java-name>
				/// duration
				/// </java-name>
				[Dot42.DexImport("duration", "I", AccessFlags = 1)]
				public int Duration;
				/// <java-name>
				/// quality
				/// </java-name>
				[Dot42.DexImport("quality", "I", AccessFlags = 1)]
				public int Quality;
				/// <java-name>
				/// fileFormat
				/// </java-name>
				[Dot42.DexImport("fileFormat", "I", AccessFlags = 1)]
				public int FileFormat;
				/// <java-name>
				/// videoCodec
				/// </java-name>
				[Dot42.DexImport("videoCodec", "I", AccessFlags = 1)]
				public int VideoCodec;
				/// <java-name>
				/// videoBitRate
				/// </java-name>
				[Dot42.DexImport("videoBitRate", "I", AccessFlags = 1)]
				public int VideoBitRate;
				/// <java-name>
				/// videoFrameRate
				/// </java-name>
				[Dot42.DexImport("videoFrameRate", "I", AccessFlags = 1)]
				public int VideoFrameRate;
				/// <java-name>
				/// videoFrameWidth
				/// </java-name>
				[Dot42.DexImport("videoFrameWidth", "I", AccessFlags = 1)]
				public int VideoFrameWidth;
				/// <java-name>
				/// videoFrameHeight
				/// </java-name>
				[Dot42.DexImport("videoFrameHeight", "I", AccessFlags = 1)]
				public int VideoFrameHeight;
				/// <java-name>
				/// audioCodec
				/// </java-name>
				[Dot42.DexImport("audioCodec", "I", AccessFlags = 1)]
				public int AudioCodec;
				/// <java-name>
				/// audioBitRate
				/// </java-name>
				[Dot42.DexImport("audioBitRate", "I", AccessFlags = 1)]
				public int AudioBitRate;
				/// <java-name>
				/// audioSampleRate
				/// </java-name>
				[Dot42.DexImport("audioSampleRate", "I", AccessFlags = 1)]
				public int AudioSampleRate;
				/// <java-name>
				/// audioChannels
				/// </java-name>
				[Dot42.DexImport("audioChannels", "I", AccessFlags = 1)]
				public int AudioChannels;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal CamcorderProfile() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(I)Landroid/media/CamcorderProfile;", AccessFlags = 9)]
				public static global::Android.Media.CamcorderProfile Get(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Media.CamcorderProfile);
				}

				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(II)Landroid/media/CamcorderProfile;", AccessFlags = 9)]
				public static global::Android.Media.CamcorderProfile Get(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Media.CamcorderProfile);
				}

				/// <java-name>
				/// hasProfile
				/// </java-name>
				[Dot42.DexImport("hasProfile", "(I)Z", AccessFlags = 9)]
				public static bool HasProfile(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// hasProfile
				/// </java-name>
				[Dot42.DexImport("hasProfile", "(II)Z", AccessFlags = 9)]
				public static bool HasProfile(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

		}

		/// <java-name>
		/// android/media/CameraProfile
		/// </java-name>
		[Dot42.DexImport("android/media/CameraProfile", AccessFlags = 33)]
		public partial class CameraProfile
 /* scope: __dot42__ */ 
		{
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

				/// <java-name>
				/// getJpegEncodingQualityParameter
				/// </java-name>
				[Dot42.DexImport("getJpegEncodingQualityParameter", "(I)I", AccessFlags = 9)]
				public static int GetJpegEncodingQualityParameter(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getJpegEncodingQualityParameter
				/// </java-name>
				[Dot42.DexImport("getJpegEncodingQualityParameter", "(II)I", AccessFlags = 9)]
				public static int GetJpegEncodingQualityParameter(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

		}

		/// <java-name>
		/// android/media/ExifInterface
		/// </java-name>
		[Dot42.DexImport("android/media/ExifInterface", AccessFlags = 33)]
		public partial class ExifInterface
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// TAG_ORIENTATION
				/// </java-name>
				[Dot42.DexImport("TAG_ORIENTATION", "Ljava/lang/String;", AccessFlags = 25)]
				public const string TAG_ORIENTATION = "Orientation";
				/// <java-name>
				/// TAG_DATETIME
				/// </java-name>
				[Dot42.DexImport("TAG_DATETIME", "Ljava/lang/String;", AccessFlags = 25)]
				public const string TAG_DATETIME = "DateTime";
				/// <java-name>
				/// TAG_MAKE
				/// </java-name>
				[Dot42.DexImport("TAG_MAKE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string TAG_MAKE = "Make";
				/// <java-name>
				/// TAG_MODEL
				/// </java-name>
				[Dot42.DexImport("TAG_MODEL", "Ljava/lang/String;", AccessFlags = 25)]
				public const string TAG_MODEL = "Model";
				/// <java-name>
				/// TAG_FLASH
				/// </java-name>
				[Dot42.DexImport("TAG_FLASH", "Ljava/lang/String;", AccessFlags = 25)]
				public const string TAG_FLASH = "Flash";
				/// <java-name>
				/// TAG_IMAGE_WIDTH
				/// </java-name>
				[Dot42.DexImport("TAG_IMAGE_WIDTH", "Ljava/lang/String;", AccessFlags = 25)]
				public const string TAG_IMAGE_WIDTH = "ImageWidth";
				/// <java-name>
				/// TAG_IMAGE_LENGTH
				/// </java-name>
				[Dot42.DexImport("TAG_IMAGE_LENGTH", "Ljava/lang/String;", AccessFlags = 25)]
				public const string TAG_IMAGE_LENGTH = "ImageLength";
				/// <java-name>
				/// TAG_GPS_LATITUDE
				/// </java-name>
				[Dot42.DexImport("TAG_GPS_LATITUDE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string TAG_GPS_LATITUDE = "GPSLatitude";
				/// <java-name>
				/// TAG_GPS_LONGITUDE
				/// </java-name>
				[Dot42.DexImport("TAG_GPS_LONGITUDE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string TAG_GPS_LONGITUDE = "GPSLongitude";
				/// <java-name>
				/// TAG_GPS_LATITUDE_REF
				/// </java-name>
				[Dot42.DexImport("TAG_GPS_LATITUDE_REF", "Ljava/lang/String;", AccessFlags = 25)]
				public const string TAG_GPS_LATITUDE_REF = "GPSLatitudeRef";
				/// <java-name>
				/// TAG_GPS_LONGITUDE_REF
				/// </java-name>
				[Dot42.DexImport("TAG_GPS_LONGITUDE_REF", "Ljava/lang/String;", AccessFlags = 25)]
				public const string TAG_GPS_LONGITUDE_REF = "GPSLongitudeRef";
				/// <java-name>
				/// TAG_EXPOSURE_TIME
				/// </java-name>
				[Dot42.DexImport("TAG_EXPOSURE_TIME", "Ljava/lang/String;", AccessFlags = 25)]
				public const string TAG_EXPOSURE_TIME = "ExposureTime";
				/// <java-name>
				/// TAG_APERTURE
				/// </java-name>
				[Dot42.DexImport("TAG_APERTURE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string TAG_APERTURE = "FNumber";
				/// <java-name>
				/// TAG_ISO
				/// </java-name>
				[Dot42.DexImport("TAG_ISO", "Ljava/lang/String;", AccessFlags = 25)]
				public const string TAG_ISO = "ISOSpeedRatings";
				/// <java-name>
				/// TAG_GPS_ALTITUDE
				/// </java-name>
				[Dot42.DexImport("TAG_GPS_ALTITUDE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string TAG_GPS_ALTITUDE = "GPSAltitude";
				/// <java-name>
				/// TAG_GPS_ALTITUDE_REF
				/// </java-name>
				[Dot42.DexImport("TAG_GPS_ALTITUDE_REF", "Ljava/lang/String;", AccessFlags = 25)]
				public const string TAG_GPS_ALTITUDE_REF = "GPSAltitudeRef";
				/// <java-name>
				/// TAG_GPS_TIMESTAMP
				/// </java-name>
				[Dot42.DexImport("TAG_GPS_TIMESTAMP", "Ljava/lang/String;", AccessFlags = 25)]
				public const string TAG_GPS_TIMESTAMP = "GPSTimeStamp";
				/// <java-name>
				/// TAG_GPS_DATESTAMP
				/// </java-name>
				[Dot42.DexImport("TAG_GPS_DATESTAMP", "Ljava/lang/String;", AccessFlags = 25)]
				public const string TAG_GPS_DATESTAMP = "GPSDateStamp";
				/// <java-name>
				/// TAG_WHITE_BALANCE
				/// </java-name>
				[Dot42.DexImport("TAG_WHITE_BALANCE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string TAG_WHITE_BALANCE = "WhiteBalance";
				/// <java-name>
				/// TAG_FOCAL_LENGTH
				/// </java-name>
				[Dot42.DexImport("TAG_FOCAL_LENGTH", "Ljava/lang/String;", AccessFlags = 25)]
				public const string TAG_FOCAL_LENGTH = "FocalLength";
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
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public ExifInterface(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getAttribute
				/// </java-name>
				[Dot42.DexImport("getAttribute", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetAttribute(string @string) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getAttributeInt
				/// </java-name>
				[Dot42.DexImport("getAttributeInt", "(Ljava/lang/String;I)I", AccessFlags = 1)]
				public virtual int GetAttributeInt(string @string, int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getAttributeDouble
				/// </java-name>
				[Dot42.DexImport("getAttributeDouble", "(Ljava/lang/String;D)D", AccessFlags = 1)]
				public virtual double GetAttributeDouble(string @string, double @double) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <java-name>
				/// setAttribute
				/// </java-name>
				[Dot42.DexImport("setAttribute", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetAttribute(string @string, string string1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// saveAttributes
				/// </java-name>
				[Dot42.DexImport("saveAttributes", "()V", AccessFlags = 1)]
				public virtual void SaveAttributes() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// hasThumbnail
				/// </java-name>
				[Dot42.DexImport("hasThumbnail", "()Z", AccessFlags = 1)]
				public virtual bool HasThumbnail() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getThumbnail
				/// </java-name>
				[Dot42.DexImport("getThumbnail", "()[B", AccessFlags = 1)]
				public virtual sbyte[] JavaGetThumbnail() /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <java-name>
				/// getThumbnail
				/// </java-name>
				[Dot42.DexImport("getThumbnail", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual byte[] GetThumbnail() /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				/// <java-name>
				/// getLatLong
				/// </java-name>
				[Dot42.DexImport("getLatLong", "([F)Z", AccessFlags = 1)]
				public virtual bool GetLatLong(float[] single) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getAltitude
				/// </java-name>
				[Dot42.DexImport("getAltitude", "(D)D", AccessFlags = 1)]
				public virtual double GetAltitude(double @double) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ExifInterface() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getThumbnail
				/// </java-name>
				public byte[] Thumbnail
				{
				[Dot42.DexImport("getThumbnail", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
						get{ return GetThumbnail(); }
				}

		}

		/// <java-name>
		/// android/media/FaceDetector
		/// </java-name>
		[Dot42.DexImport("android/media/FaceDetector", AccessFlags = 33)]
		public partial class FaceDetector
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(III)V", AccessFlags = 1)]
				public FaceDetector(int int32, int int321, int int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// findFaces
				/// </java-name>
				[Dot42.DexImport("findFaces", "(Landroid/graphics/Bitmap;[Landroid/media/FaceDetector$Face;)I", AccessFlags = 1)]
				public virtual int FindFaces(global::Android.Graphics.Bitmap bitmap, global::Android.Media.FaceDetector.Face[] face) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// finalize
				/// </java-name>
				[Dot42.DexImport("finalize", "()V", AccessFlags = 4)]
				extern ~FaceDetector() /* MethodBuilder.Create */ ;

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal FaceDetector() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// android/media/FaceDetector$Face
				/// </java-name>
				[Dot42.DexImport("android/media/FaceDetector$Face", AccessFlags = 1)]
				public partial class Face
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// CONFIDENCE_THRESHOLD
						/// </java-name>
						[Dot42.DexImport("CONFIDENCE_THRESHOLD", "F", AccessFlags = 25)]
						public const float CONFIDENCE_THRESHOLD = 0.4F;
						/// <java-name>
						/// EULER_X
						/// </java-name>
						[Dot42.DexImport("EULER_X", "I", AccessFlags = 25)]
						public const int EULER_X = 0;
						/// <java-name>
						/// EULER_Y
						/// </java-name>
						[Dot42.DexImport("EULER_Y", "I", AccessFlags = 25)]
						public const int EULER_Y = 1;
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

						/// <java-name>
						/// confidence
						/// </java-name>
						[Dot42.DexImport("confidence", "()F", AccessFlags = 1)]
						public virtual float Confidence() /* MethodBuilder.Create */ 
						{
								return default(float);
						}

						/// <java-name>
						/// getMidPoint
						/// </java-name>
						[Dot42.DexImport("getMidPoint", "(Landroid/graphics/PointF;)V", AccessFlags = 1)]
						public virtual void GetMidPoint(global::Android.Graphics.PointF pointF) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// eyesDistance
						/// </java-name>
						[Dot42.DexImport("eyesDistance", "()F", AccessFlags = 1)]
						public virtual float EyesDistance() /* MethodBuilder.Create */ 
						{
								return default(float);
						}

						/// <java-name>
						/// pose
						/// </java-name>
						[Dot42.DexImport("pose", "(I)F", AccessFlags = 1)]
						public virtual float Pose(int int32) /* MethodBuilder.Create */ 
						{
								return default(float);
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal Face() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

				}

		}

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

				/// <java-name>
				/// getJetPlayer
				/// </java-name>
				[Dot42.DexImport("getJetPlayer", "()Landroid/media/JetPlayer;", AccessFlags = 9)]
				public static global::Android.Media.JetPlayer GetJetPlayer() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Media.JetPlayer);
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
				/// finalize
				/// </java-name>
				[Dot42.DexImport("finalize", "()V", AccessFlags = 4)]
				extern ~JetPlayer() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// release
				/// </java-name>
				[Dot42.DexImport("release", "()V", AccessFlags = 1)]
				public virtual void Release() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getMaxTracks
				/// </java-name>
				[Dot42.DexImport("getMaxTracks", "()I", AccessFlags = 9)]
				public static int GetMaxTracks() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// loadJetFile
				/// </java-name>
				[Dot42.DexImport("loadJetFile", "(Ljava/lang/String;)Z", AccessFlags = 1)]
				public virtual bool LoadJetFile(string @string) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// loadJetFile
				/// </java-name>
				[Dot42.DexImport("loadJetFile", "(Landroid/content/res/AssetFileDescriptor;)Z", AccessFlags = 1)]
				public virtual bool LoadJetFile(global::Android.Content.Res.AssetFileDescriptor assetFileDescriptor) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// closeJetFile
				/// </java-name>
				[Dot42.DexImport("closeJetFile", "()Z", AccessFlags = 1)]
				public virtual bool CloseJetFile() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// play
				/// </java-name>
				[Dot42.DexImport("play", "()Z", AccessFlags = 1)]
				public virtual bool Play() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// pause
				/// </java-name>
				[Dot42.DexImport("pause", "()Z", AccessFlags = 1)]
				public virtual bool Pause() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// queueJetSegment
				/// </java-name>
				[Dot42.DexImport("queueJetSegment", "(IIIIIB)Z", AccessFlags = 1)]
				public virtual bool QueueJetSegment(int int32, int int321, int int322, int int323, int int324, sbyte sByte) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// queueJetSegment
				/// </java-name>
				[Dot42.DexImport("queueJetSegment", "(IIIIIB)Z", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual bool QueueJetSegment(int int32, int int321, int int322, int int323, int int324, byte @byte) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// queueJetSegmentMuteArray
				/// </java-name>
				[Dot42.DexImport("queueJetSegmentMuteArray", "(IIII[ZB)Z", AccessFlags = 1)]
				public virtual bool QueueJetSegmentMuteArray(int int32, int int321, int int322, int int323, bool[] boolean, sbyte sByte) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// queueJetSegmentMuteArray
				/// </java-name>
				[Dot42.DexImport("queueJetSegmentMuteArray", "(IIII[ZB)Z", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual bool QueueJetSegmentMuteArray(int int32, int int321, int int322, int int323, bool[] boolean, byte @byte) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setMuteFlags
				/// </java-name>
				[Dot42.DexImport("setMuteFlags", "(IZ)Z", AccessFlags = 1)]
				public virtual bool SetMuteFlags(int int32, bool boolean) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setMuteArray
				/// </java-name>
				[Dot42.DexImport("setMuteArray", "([ZZ)Z", AccessFlags = 1)]
				public virtual bool SetMuteArray(bool[] boolean, bool boolean1) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setMuteFlag
				/// </java-name>
				[Dot42.DexImport("setMuteFlag", "(IZZ)Z", AccessFlags = 1)]
				public virtual bool SetMuteFlag(int int32, bool boolean, bool boolean1) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// triggerClip
				/// </java-name>
				[Dot42.DexImport("triggerClip", "(I)Z", AccessFlags = 1)]
				public virtual bool TriggerClip(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// clearQueue
				/// </java-name>
				[Dot42.DexImport("clearQueue", "()Z", AccessFlags = 1)]
				public virtual bool ClearQueue() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setEventListener
				/// </java-name>
				[Dot42.DexImport("setEventListener", "(Landroid/media/JetPlayer$OnJetEventListener;)V", AccessFlags = 1)]
				public virtual void SetEventListener(global::Android.Media.JetPlayer.IOnJetEventListener onJetEventListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setEventListener
				/// </java-name>
				[Dot42.DexImport("setEventListener", "(Landroid/media/JetPlayer$OnJetEventListener;Landroid/os/Handler;)V", AccessFlags = 1)]
				public virtual void SetEventListener(global::Android.Media.JetPlayer.IOnJetEventListener onJetEventListener, global::Android.OS.Handler handler) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getMaxTracks
				/// </java-name>
				public static int MaxTracks
				{
				[Dot42.DexImport("getMaxTracks", "()I", AccessFlags = 9)]
						get{ return GetMaxTracks(); }
				}

				/// <java-name>
				/// android/media/JetPlayer$OnJetEventListener
				/// </java-name>
				[Dot42.DexImport("android/media/JetPlayer$OnJetEventListener", AccessFlags = 1545)]
				public partial interface IOnJetEventListener
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onJetEvent
						/// </java-name>
						[Dot42.DexImport("onJetEvent", "(Landroid/media/JetPlayer;SBBBB)V", AccessFlags = 1025)]
						void OnJetEvent(global::Android.Media.JetPlayer jetPlayer, short int16, sbyte sByte, sbyte sByte1, sbyte sByte2, sbyte sByte3) /* MethodBuilder.Create */ ;

						/// <java-name>
						/// onJetUserIdUpdate
						/// </java-name>
						[Dot42.DexImport("onJetUserIdUpdate", "(Landroid/media/JetPlayer;II)V", AccessFlags = 1025)]
						void OnJetUserIdUpdate(global::Android.Media.JetPlayer jetPlayer, int int32, int int321) /* MethodBuilder.Create */ ;

						/// <java-name>
						/// onJetNumQueuedSegmentUpdate
						/// </java-name>
						[Dot42.DexImport("onJetNumQueuedSegmentUpdate", "(Landroid/media/JetPlayer;I)V", AccessFlags = 1025)]
						void OnJetNumQueuedSegmentUpdate(global::Android.Media.JetPlayer jetPlayer, int int32) /* MethodBuilder.Create */ ;

						/// <java-name>
						/// onJetPauseUpdate
						/// </java-name>
						[Dot42.DexImport("onJetPauseUpdate", "(Landroid/media/JetPlayer;I)V", AccessFlags = 1025)]
						void OnJetPauseUpdate(global::Android.Media.JetPlayer jetPlayer, int int32) /* MethodBuilder.Create */ ;

				}

		}

		/// <java-name>
		/// android/media/MediaMetadataRetriever
		/// </java-name>
		[Dot42.DexImport("android/media/MediaMetadataRetriever", AccessFlags = 33)]
		public partial class MediaMetadataRetriever
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// OPTION_PREVIOUS_SYNC
				/// </java-name>
				[Dot42.DexImport("OPTION_PREVIOUS_SYNC", "I", AccessFlags = 25)]
				public const int OPTION_PREVIOUS_SYNC = 0;
				/// <java-name>
				/// OPTION_NEXT_SYNC
				/// </java-name>
				[Dot42.DexImport("OPTION_NEXT_SYNC", "I", AccessFlags = 25)]
				public const int OPTION_NEXT_SYNC = 1;
				/// <java-name>
				/// OPTION_CLOSEST_SYNC
				/// </java-name>
				[Dot42.DexImport("OPTION_CLOSEST_SYNC", "I", AccessFlags = 25)]
				public const int OPTION_CLOSEST_SYNC = 2;
				/// <java-name>
				/// OPTION_CLOSEST
				/// </java-name>
				[Dot42.DexImport("OPTION_CLOSEST", "I", AccessFlags = 25)]
				public const int OPTION_CLOSEST = 3;
				/// <java-name>
				/// METADATA_KEY_CD_TRACK_NUMBER
				/// </java-name>
				[Dot42.DexImport("METADATA_KEY_CD_TRACK_NUMBER", "I", AccessFlags = 25)]
				public const int METADATA_KEY_CD_TRACK_NUMBER = 0;
				/// <java-name>
				/// METADATA_KEY_ALBUM
				/// </java-name>
				[Dot42.DexImport("METADATA_KEY_ALBUM", "I", AccessFlags = 25)]
				public const int METADATA_KEY_ALBUM = 1;
				/// <java-name>
				/// METADATA_KEY_ARTIST
				/// </java-name>
				[Dot42.DexImport("METADATA_KEY_ARTIST", "I", AccessFlags = 25)]
				public const int METADATA_KEY_ARTIST = 2;
				/// <java-name>
				/// METADATA_KEY_AUTHOR
				/// </java-name>
				[Dot42.DexImport("METADATA_KEY_AUTHOR", "I", AccessFlags = 25)]
				public const int METADATA_KEY_AUTHOR = 3;
				/// <java-name>
				/// METADATA_KEY_COMPOSER
				/// </java-name>
				[Dot42.DexImport("METADATA_KEY_COMPOSER", "I", AccessFlags = 25)]
				public const int METADATA_KEY_COMPOSER = 4;
				/// <java-name>
				/// METADATA_KEY_DATE
				/// </java-name>
				[Dot42.DexImport("METADATA_KEY_DATE", "I", AccessFlags = 25)]
				public const int METADATA_KEY_DATE = 5;
				/// <java-name>
				/// METADATA_KEY_GENRE
				/// </java-name>
				[Dot42.DexImport("METADATA_KEY_GENRE", "I", AccessFlags = 25)]
				public const int METADATA_KEY_GENRE = 6;
				/// <java-name>
				/// METADATA_KEY_TITLE
				/// </java-name>
				[Dot42.DexImport("METADATA_KEY_TITLE", "I", AccessFlags = 25)]
				public const int METADATA_KEY_TITLE = 7;
				/// <java-name>
				/// METADATA_KEY_YEAR
				/// </java-name>
				[Dot42.DexImport("METADATA_KEY_YEAR", "I", AccessFlags = 25)]
				public const int METADATA_KEY_YEAR = 8;
				/// <java-name>
				/// METADATA_KEY_DURATION
				/// </java-name>
				[Dot42.DexImport("METADATA_KEY_DURATION", "I", AccessFlags = 25)]
				public const int METADATA_KEY_DURATION = 9;
				/// <java-name>
				/// METADATA_KEY_NUM_TRACKS
				/// </java-name>
				[Dot42.DexImport("METADATA_KEY_NUM_TRACKS", "I", AccessFlags = 25)]
				public const int METADATA_KEY_NUM_TRACKS = 10;
				/// <java-name>
				/// METADATA_KEY_WRITER
				/// </java-name>
				[Dot42.DexImport("METADATA_KEY_WRITER", "I", AccessFlags = 25)]
				public const int METADATA_KEY_WRITER = 11;
				/// <java-name>
				/// METADATA_KEY_MIMETYPE
				/// </java-name>
				[Dot42.DexImport("METADATA_KEY_MIMETYPE", "I", AccessFlags = 25)]
				public const int METADATA_KEY_MIMETYPE = 12;
				/// <java-name>
				/// METADATA_KEY_ALBUMARTIST
				/// </java-name>
				[Dot42.DexImport("METADATA_KEY_ALBUMARTIST", "I", AccessFlags = 25)]
				public const int METADATA_KEY_ALBUMARTIST = 13;
				/// <java-name>
				/// METADATA_KEY_DISC_NUMBER
				/// </java-name>
				[Dot42.DexImport("METADATA_KEY_DISC_NUMBER", "I", AccessFlags = 25)]
				public const int METADATA_KEY_DISC_NUMBER = 14;
				/// <java-name>
				/// METADATA_KEY_COMPILATION
				/// </java-name>
				[Dot42.DexImport("METADATA_KEY_COMPILATION", "I", AccessFlags = 25)]
				public const int METADATA_KEY_COMPILATION = 15;
				/// <java-name>
				/// METADATA_KEY_HAS_AUDIO
				/// </java-name>
				[Dot42.DexImport("METADATA_KEY_HAS_AUDIO", "I", AccessFlags = 25)]
				public const int METADATA_KEY_HAS_AUDIO = 16;
				/// <java-name>
				/// METADATA_KEY_HAS_VIDEO
				/// </java-name>
				[Dot42.DexImport("METADATA_KEY_HAS_VIDEO", "I", AccessFlags = 25)]
				public const int METADATA_KEY_HAS_VIDEO = 17;
				/// <java-name>
				/// METADATA_KEY_VIDEO_WIDTH
				/// </java-name>
				[Dot42.DexImport("METADATA_KEY_VIDEO_WIDTH", "I", AccessFlags = 25)]
				public const int METADATA_KEY_VIDEO_WIDTH = 18;
				/// <java-name>
				/// METADATA_KEY_VIDEO_HEIGHT
				/// </java-name>
				[Dot42.DexImport("METADATA_KEY_VIDEO_HEIGHT", "I", AccessFlags = 25)]
				public const int METADATA_KEY_VIDEO_HEIGHT = 19;
				/// <java-name>
				/// METADATA_KEY_BITRATE
				/// </java-name>
				[Dot42.DexImport("METADATA_KEY_BITRATE", "I", AccessFlags = 25)]
				public const int METADATA_KEY_BITRATE = 20;
				/// <java-name>
				/// METADATA_KEY_LOCATION
				/// </java-name>
				[Dot42.DexImport("METADATA_KEY_LOCATION", "I", AccessFlags = 25)]
				public const int METADATA_KEY_LOCATION = 23;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public MediaMetadataRetriever() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setDataSource
				/// </java-name>
				[Dot42.DexImport("setDataSource", "(Ljava/lang/String;)V", AccessFlags = 257)]
				public virtual void SetDataSource(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setDataSource
				/// </java-name>
				[Dot42.DexImport("setDataSource", "(Ljava/lang/String;Ljava/util/Map;)V", AccessFlags = 1, Signature = "(Ljava/lang/String;Ljava/util/Map<Ljava/lang/String;Ljava/lang/String;>;)V")]
				public virtual void SetDataSource(string @string, global::Java.Util.IMap<string, string> map) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setDataSource
				/// </java-name>
				[Dot42.DexImport("setDataSource", "(Ljava/io/FileDescriptor;JJ)V", AccessFlags = 257)]
				public virtual void SetDataSource(global::Java.Io.FileDescriptor fileDescriptor, long int64, long int641) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setDataSource
				/// </java-name>
				[Dot42.DexImport("setDataSource", "(Ljava/io/FileDescriptor;)V", AccessFlags = 1)]
				public virtual void SetDataSource(global::Java.Io.FileDescriptor fileDescriptor) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setDataSource
				/// </java-name>
				[Dot42.DexImport("setDataSource", "(Landroid/content/Context;Landroid/net/Uri;)V", AccessFlags = 1)]
				public virtual void SetDataSource(global::Android.Content.Context context, global::Android.Net.Uri uri) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// extractMetadata
				/// </java-name>
				[Dot42.DexImport("extractMetadata", "(I)Ljava/lang/String;", AccessFlags = 257)]
				public virtual string ExtractMetadata(int int32) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getFrameAtTime
				/// </java-name>
				[Dot42.DexImport("getFrameAtTime", "(JI)Landroid/graphics/Bitmap;", AccessFlags = 1)]
				public virtual global::Android.Graphics.Bitmap GetFrameAtTime(long int64, int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Bitmap);
				}

				/// <java-name>
				/// getFrameAtTime
				/// </java-name>
				[Dot42.DexImport("getFrameAtTime", "(J)Landroid/graphics/Bitmap;", AccessFlags = 1)]
				public virtual global::Android.Graphics.Bitmap GetFrameAtTime(long int64) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Bitmap);
				}

				/// <java-name>
				/// getFrameAtTime
				/// </java-name>
				[Dot42.DexImport("getFrameAtTime", "()Landroid/graphics/Bitmap;", AccessFlags = 1)]
				public virtual global::Android.Graphics.Bitmap GetFrameAtTime() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Bitmap);
				}

				/// <java-name>
				/// getEmbeddedPicture
				/// </java-name>
				[Dot42.DexImport("getEmbeddedPicture", "()[B", AccessFlags = 1)]
				public virtual sbyte[] JavaGetEmbeddedPicture() /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <java-name>
				/// getEmbeddedPicture
				/// </java-name>
				[Dot42.DexImport("getEmbeddedPicture", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual byte[] GetEmbeddedPicture() /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

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

				/// <java-name>
				/// getFrameAtTime
				/// </java-name>
				public global::Android.Graphics.Bitmap FrameAtTime
				{
				[Dot42.DexImport("getFrameAtTime", "()Landroid/graphics/Bitmap;", AccessFlags = 1)]
						get{ return GetFrameAtTime(); }
				}

				/// <java-name>
				/// getEmbeddedPicture
				/// </java-name>
				public byte[] EmbeddedPicture
				{
				[Dot42.DexImport("getEmbeddedPicture", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
						get{ return GetEmbeddedPicture(); }
				}

		}

		/// <java-name>
		/// android/media/MediaPlayer
		/// </java-name>
		[Dot42.DexImport("android/media/MediaPlayer", AccessFlags = 33)]
		public partial class MediaPlayer
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// MEDIA_ERROR_UNKNOWN
				/// </java-name>
				[Dot42.DexImport("MEDIA_ERROR_UNKNOWN", "I", AccessFlags = 25)]
				public const int MEDIA_ERROR_UNKNOWN = 1;
				/// <java-name>
				/// MEDIA_ERROR_SERVER_DIED
				/// </java-name>
				[Dot42.DexImport("MEDIA_ERROR_SERVER_DIED", "I", AccessFlags = 25)]
				public const int MEDIA_ERROR_SERVER_DIED = 100;
				/// <java-name>
				/// MEDIA_ERROR_NOT_VALID_FOR_PROGRESSIVE_PLAYBACK
				/// </java-name>
				[Dot42.DexImport("MEDIA_ERROR_NOT_VALID_FOR_PROGRESSIVE_PLAYBACK", "I", AccessFlags = 25)]
				public const int MEDIA_ERROR_NOT_VALID_FOR_PROGRESSIVE_PLAYBACK = 200;
				/// <java-name>
				/// MEDIA_INFO_UNKNOWN
				/// </java-name>
				[Dot42.DexImport("MEDIA_INFO_UNKNOWN", "I", AccessFlags = 25)]
				public const int MEDIA_INFO_UNKNOWN = 1;
				/// <java-name>
				/// MEDIA_INFO_VIDEO_TRACK_LAGGING
				/// </java-name>
				[Dot42.DexImport("MEDIA_INFO_VIDEO_TRACK_LAGGING", "I", AccessFlags = 25)]
				public const int MEDIA_INFO_VIDEO_TRACK_LAGGING = 700;
				/// <java-name>
				/// MEDIA_INFO_BUFFERING_START
				/// </java-name>
				[Dot42.DexImport("MEDIA_INFO_BUFFERING_START", "I", AccessFlags = 25)]
				public const int MEDIA_INFO_BUFFERING_START = 701;
				/// <java-name>
				/// MEDIA_INFO_BUFFERING_END
				/// </java-name>
				[Dot42.DexImport("MEDIA_INFO_BUFFERING_END", "I", AccessFlags = 25)]
				public const int MEDIA_INFO_BUFFERING_END = 702;
				/// <java-name>
				/// MEDIA_INFO_BAD_INTERLEAVING
				/// </java-name>
				[Dot42.DexImport("MEDIA_INFO_BAD_INTERLEAVING", "I", AccessFlags = 25)]
				public const int MEDIA_INFO_BAD_INTERLEAVING = 800;
				/// <java-name>
				/// MEDIA_INFO_NOT_SEEKABLE
				/// </java-name>
				[Dot42.DexImport("MEDIA_INFO_NOT_SEEKABLE", "I", AccessFlags = 25)]
				public const int MEDIA_INFO_NOT_SEEKABLE = 801;
				/// <java-name>
				/// MEDIA_INFO_METADATA_UPDATE
				/// </java-name>
				[Dot42.DexImport("MEDIA_INFO_METADATA_UPDATE", "I", AccessFlags = 25)]
				public const int MEDIA_INFO_METADATA_UPDATE = 802;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public MediaPlayer() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setDisplay
				/// </java-name>
				[Dot42.DexImport("setDisplay", "(Landroid/view/SurfaceHolder;)V", AccessFlags = 1)]
				public virtual void SetDisplay(global::Android.View.ISurfaceHolder surfaceHolder) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setSurface
				/// </java-name>
				[Dot42.DexImport("setSurface", "(Landroid/view/Surface;)V", AccessFlags = 1)]
				public virtual void SetSurface(global::Android.View.Surface surface) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// create
				/// </java-name>
				[Dot42.DexImport("create", "(Landroid/content/Context;Landroid/net/Uri;)Landroid/media/MediaPlayer;", AccessFlags = 9)]
				public static global::Android.Media.MediaPlayer Create(global::Android.Content.Context context, global::Android.Net.Uri uri) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Media.MediaPlayer);
				}

				/// <java-name>
				/// create
				/// </java-name>
				[Dot42.DexImport("create", "(Landroid/content/Context;Landroid/net/Uri;Landroid/view/SurfaceHolder;)Landroid/" +
    "media/MediaPlayer;", AccessFlags = 9)]
				public static global::Android.Media.MediaPlayer Create(global::Android.Content.Context context, global::Android.Net.Uri uri, global::Android.View.ISurfaceHolder surfaceHolder) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Media.MediaPlayer);
				}

				/// <java-name>
				/// create
				/// </java-name>
				[Dot42.DexImport("create", "(Landroid/content/Context;I)Landroid/media/MediaPlayer;", AccessFlags = 9)]
				public static global::Android.Media.MediaPlayer Create(global::Android.Content.Context context, int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Media.MediaPlayer);
				}

				/// <java-name>
				/// setDataSource
				/// </java-name>
				[Dot42.DexImport("setDataSource", "(Landroid/content/Context;Landroid/net/Uri;)V", AccessFlags = 1)]
				public virtual void SetDataSource(global::Android.Content.Context context, global::Android.Net.Uri uri) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setDataSource
				/// </java-name>
				[Dot42.DexImport("setDataSource", "(Landroid/content/Context;Landroid/net/Uri;Ljava/util/Map;)V", AccessFlags = 1, Signature = "(Landroid/content/Context;Landroid/net/Uri;Ljava/util/Map<Ljava/lang/String;Ljava" +
    "/lang/String;>;)V")]
				public virtual void SetDataSource(global::Android.Content.Context context, global::Android.Net.Uri uri, global::Java.Util.IMap<string, string> map) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setDataSource
				/// </java-name>
				[Dot42.DexImport("setDataSource", "(Ljava/lang/String;)V", AccessFlags = 257)]
				public virtual void SetDataSource(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setDataSource
				/// </java-name>
				[Dot42.DexImport("setDataSource", "(Ljava/io/FileDescriptor;)V", AccessFlags = 1)]
				public virtual void SetDataSource(global::Java.Io.FileDescriptor fileDescriptor) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setDataSource
				/// </java-name>
				[Dot42.DexImport("setDataSource", "(Ljava/io/FileDescriptor;JJ)V", AccessFlags = 257)]
				public virtual void SetDataSource(global::Java.Io.FileDescriptor fileDescriptor, long int64, long int641) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// prepare
				/// </java-name>
				[Dot42.DexImport("prepare", "()V", AccessFlags = 257)]
				public virtual void Prepare() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// prepareAsync
				/// </java-name>
				[Dot42.DexImport("prepareAsync", "()V", AccessFlags = 257)]
				public virtual void PrepareAsync() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// start
				/// </java-name>
				[Dot42.DexImport("start", "()V", AccessFlags = 1)]
				public virtual void Start() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// stop
				/// </java-name>
				[Dot42.DexImport("stop", "()V", AccessFlags = 1)]
				public virtual void Stop() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// pause
				/// </java-name>
				[Dot42.DexImport("pause", "()V", AccessFlags = 1)]
				public virtual void Pause() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setWakeMode
				/// </java-name>
				[Dot42.DexImport("setWakeMode", "(Landroid/content/Context;I)V", AccessFlags = 1)]
				public virtual void SetWakeMode(global::Android.Content.Context context, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setScreenOnWhilePlaying
				/// </java-name>
				[Dot42.DexImport("setScreenOnWhilePlaying", "(Z)V", AccessFlags = 1)]
				public virtual void SetScreenOnWhilePlaying(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getVideoWidth
				/// </java-name>
				[Dot42.DexImport("getVideoWidth", "()I", AccessFlags = 257)]
				public virtual int GetVideoWidth() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getVideoHeight
				/// </java-name>
				[Dot42.DexImport("getVideoHeight", "()I", AccessFlags = 257)]
				public virtual int GetVideoHeight() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// isPlaying
				/// </java-name>
				[Dot42.DexImport("isPlaying", "()Z", AccessFlags = 257)]
				public virtual bool IsPlaying() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// seekTo
				/// </java-name>
				[Dot42.DexImport("seekTo", "(I)V", AccessFlags = 257)]
				public virtual void SeekTo(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getCurrentPosition
				/// </java-name>
				[Dot42.DexImport("getCurrentPosition", "()I", AccessFlags = 257)]
				public virtual int GetCurrentPosition() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getDuration
				/// </java-name>
				[Dot42.DexImport("getDuration", "()I", AccessFlags = 257)]
				public virtual int GetDuration() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// release
				/// </java-name>
				[Dot42.DexImport("release", "()V", AccessFlags = 1)]
				public virtual void Release() /* MethodBuilder.Create */ 
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
				/// setAudioStreamType
				/// </java-name>
				[Dot42.DexImport("setAudioStreamType", "(I)V", AccessFlags = 257)]
				public virtual void SetAudioStreamType(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setLooping
				/// </java-name>
				[Dot42.DexImport("setLooping", "(Z)V", AccessFlags = 257)]
				public virtual void SetLooping(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isLooping
				/// </java-name>
				[Dot42.DexImport("isLooping", "()Z", AccessFlags = 257)]
				public virtual bool IsLooping() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setVolume
				/// </java-name>
				[Dot42.DexImport("setVolume", "(FF)V", AccessFlags = 257)]
				public virtual void SetVolume(float single, float single1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setAudioSessionId
				/// </java-name>
				[Dot42.DexImport("setAudioSessionId", "(I)V", AccessFlags = 257)]
				public virtual void SetAudioSessionId(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getAudioSessionId
				/// </java-name>
				[Dot42.DexImport("getAudioSessionId", "()I", AccessFlags = 257)]
				public virtual int GetAudioSessionId() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// attachAuxEffect
				/// </java-name>
				[Dot42.DexImport("attachAuxEffect", "(I)V", AccessFlags = 257)]
				public virtual void AttachAuxEffect(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setAuxEffectSendLevel
				/// </java-name>
				[Dot42.DexImport("setAuxEffectSendLevel", "(F)V", AccessFlags = 257)]
				public virtual void SetAuxEffectSendLevel(float single) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// finalize
				/// </java-name>
				[Dot42.DexImport("finalize", "()V", AccessFlags = 4)]
				extern ~MediaPlayer() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setOnPreparedListener
				/// </java-name>
				[Dot42.DexImport("setOnPreparedListener", "(Landroid/media/MediaPlayer$OnPreparedListener;)V", AccessFlags = 1)]
				public virtual void SetOnPreparedListener(global::Android.Media.MediaPlayer.IOnPreparedListener onPreparedListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setOnCompletionListener
				/// </java-name>
				[Dot42.DexImport("setOnCompletionListener", "(Landroid/media/MediaPlayer$OnCompletionListener;)V", AccessFlags = 1)]
				public virtual void SetOnCompletionListener(global::Android.Media.MediaPlayer.IOnCompletionListener onCompletionListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setOnBufferingUpdateListener
				/// </java-name>
				[Dot42.DexImport("setOnBufferingUpdateListener", "(Landroid/media/MediaPlayer$OnBufferingUpdateListener;)V", AccessFlags = 1)]
				public virtual void SetOnBufferingUpdateListener(global::Android.Media.MediaPlayer.IOnBufferingUpdateListener onBufferingUpdateListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setOnSeekCompleteListener
				/// </java-name>
				[Dot42.DexImport("setOnSeekCompleteListener", "(Landroid/media/MediaPlayer$OnSeekCompleteListener;)V", AccessFlags = 1)]
				public virtual void SetOnSeekCompleteListener(global::Android.Media.MediaPlayer.IOnSeekCompleteListener onSeekCompleteListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setOnVideoSizeChangedListener
				/// </java-name>
				[Dot42.DexImport("setOnVideoSizeChangedListener", "(Landroid/media/MediaPlayer$OnVideoSizeChangedListener;)V", AccessFlags = 1)]
				public virtual void SetOnVideoSizeChangedListener(global::Android.Media.MediaPlayer.IOnVideoSizeChangedListener onVideoSizeChangedListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setOnErrorListener
				/// </java-name>
				[Dot42.DexImport("setOnErrorListener", "(Landroid/media/MediaPlayer$OnErrorListener;)V", AccessFlags = 1)]
				public virtual void SetOnErrorListener(global::Android.Media.MediaPlayer.IOnErrorListener onErrorListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setOnInfoListener
				/// </java-name>
				[Dot42.DexImport("setOnInfoListener", "(Landroid/media/MediaPlayer$OnInfoListener;)V", AccessFlags = 1)]
				public virtual void SetOnInfoListener(global::Android.Media.MediaPlayer.IOnInfoListener onInfoListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getVideoWidth
				/// </java-name>
				public int VideoWidth
				{
				[Dot42.DexImport("getVideoWidth", "()I", AccessFlags = 257)]
						get{ return GetVideoWidth(); }
				}

				/// <java-name>
				/// getVideoHeight
				/// </java-name>
				public int VideoHeight
				{
				[Dot42.DexImport("getVideoHeight", "()I", AccessFlags = 257)]
						get{ return GetVideoHeight(); }
				}

				/// <java-name>
				/// getCurrentPosition
				/// </java-name>
				public int CurrentPosition
				{
				[Dot42.DexImport("getCurrentPosition", "()I", AccessFlags = 257)]
						get{ return GetCurrentPosition(); }
				}

				/// <java-name>
				/// getDuration
				/// </java-name>
				public int Duration
				{
				[Dot42.DexImport("getDuration", "()I", AccessFlags = 257)]
						get{ return GetDuration(); }
				}

				/// <java-name>
				/// getAudioSessionId
				/// </java-name>
				public int AudioSessionId
				{
				[Dot42.DexImport("getAudioSessionId", "()I", AccessFlags = 257)]
						get{ return GetAudioSessionId(); }
				[Dot42.DexImport("setAudioSessionId", "(I)V", AccessFlags = 257)]
						set{ SetAudioSessionId(value); }
				}

				/// <java-name>
				/// android/media/MediaPlayer$OnInfoListener
				/// </java-name>
				[Dot42.DexImport("android/media/MediaPlayer$OnInfoListener", AccessFlags = 1545)]
				public partial interface IOnInfoListener
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onInfo
						/// </java-name>
						[Dot42.DexImport("onInfo", "(Landroid/media/MediaPlayer;II)Z", AccessFlags = 1025)]
						bool OnInfo(global::Android.Media.MediaPlayer mediaPlayer, int int32, int int321) /* MethodBuilder.Create */ ;

				}

				/// <java-name>
				/// android/media/MediaPlayer$OnErrorListener
				/// </java-name>
				[Dot42.DexImport("android/media/MediaPlayer$OnErrorListener", AccessFlags = 1545)]
				public partial interface IOnErrorListener
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onError
						/// </java-name>
						[Dot42.DexImport("onError", "(Landroid/media/MediaPlayer;II)Z", AccessFlags = 1025)]
						bool OnError(global::Android.Media.MediaPlayer mediaPlayer, int int32, int int321) /* MethodBuilder.Create */ ;

				}

				/// <java-name>
				/// android/media/MediaPlayer$OnVideoSizeChangedListener
				/// </java-name>
				[Dot42.DexImport("android/media/MediaPlayer$OnVideoSizeChangedListener", AccessFlags = 1545)]
				public partial interface IOnVideoSizeChangedListener
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onVideoSizeChanged
						/// </java-name>
						[Dot42.DexImport("onVideoSizeChanged", "(Landroid/media/MediaPlayer;II)V", AccessFlags = 1025)]
						void OnVideoSizeChanged(global::Android.Media.MediaPlayer mediaPlayer, int int32, int int321) /* MethodBuilder.Create */ ;

				}

				/// <java-name>
				/// android/media/MediaPlayer$OnSeekCompleteListener
				/// </java-name>
				[Dot42.DexImport("android/media/MediaPlayer$OnSeekCompleteListener", AccessFlags = 1545)]
				public partial interface IOnSeekCompleteListener
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onSeekComplete
						/// </java-name>
						[Dot42.DexImport("onSeekComplete", "(Landroid/media/MediaPlayer;)V", AccessFlags = 1025)]
						void OnSeekComplete(global::Android.Media.MediaPlayer mediaPlayer) /* MethodBuilder.Create */ ;

				}

				/// <java-name>
				/// android/media/MediaPlayer$OnBufferingUpdateListener
				/// </java-name>
				[Dot42.DexImport("android/media/MediaPlayer$OnBufferingUpdateListener", AccessFlags = 1545)]
				public partial interface IOnBufferingUpdateListener
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onBufferingUpdate
						/// </java-name>
						[Dot42.DexImport("onBufferingUpdate", "(Landroid/media/MediaPlayer;I)V", AccessFlags = 1025)]
						void OnBufferingUpdate(global::Android.Media.MediaPlayer mediaPlayer, int int32) /* MethodBuilder.Create */ ;

				}

				/// <java-name>
				/// android/media/MediaPlayer$OnCompletionListener
				/// </java-name>
				[Dot42.DexImport("android/media/MediaPlayer$OnCompletionListener", AccessFlags = 1545)]
				public partial interface IOnCompletionListener
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onCompletion
						/// </java-name>
						[Dot42.DexImport("onCompletion", "(Landroid/media/MediaPlayer;)V", AccessFlags = 1025)]
						void OnCompletion(global::Android.Media.MediaPlayer mediaPlayer) /* MethodBuilder.Create */ ;

				}

				/// <java-name>
				/// android/media/MediaPlayer$OnPreparedListener
				/// </java-name>
				[Dot42.DexImport("android/media/MediaPlayer$OnPreparedListener", AccessFlags = 1545)]
				public partial interface IOnPreparedListener
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onPrepared
						/// </java-name>
						[Dot42.DexImport("onPrepared", "(Landroid/media/MediaPlayer;)V", AccessFlags = 1025)]
						void OnPrepared(global::Android.Media.MediaPlayer mediaPlayer) /* MethodBuilder.Create */ ;

				}

		}

		/// <java-name>
		/// android/media/MediaRecorder
		/// </java-name>
		[Dot42.DexImport("android/media/MediaRecorder", AccessFlags = 33)]
		public partial class MediaRecorder
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// MEDIA_RECORDER_ERROR_UNKNOWN
				/// </java-name>
				[Dot42.DexImport("MEDIA_RECORDER_ERROR_UNKNOWN", "I", AccessFlags = 25)]
				public const int MEDIA_RECORDER_ERROR_UNKNOWN = 1;
				/// <java-name>
				/// MEDIA_RECORDER_INFO_UNKNOWN
				/// </java-name>
				[Dot42.DexImport("MEDIA_RECORDER_INFO_UNKNOWN", "I", AccessFlags = 25)]
				public const int MEDIA_RECORDER_INFO_UNKNOWN = 1;
				/// <java-name>
				/// MEDIA_RECORDER_INFO_MAX_DURATION_REACHED
				/// </java-name>
				[Dot42.DexImport("MEDIA_RECORDER_INFO_MAX_DURATION_REACHED", "I", AccessFlags = 25)]
				public const int MEDIA_RECORDER_INFO_MAX_DURATION_REACHED = 800;
				/// <java-name>
				/// MEDIA_RECORDER_INFO_MAX_FILESIZE_REACHED
				/// </java-name>
				[Dot42.DexImport("MEDIA_RECORDER_INFO_MAX_FILESIZE_REACHED", "I", AccessFlags = 25)]
				public const int MEDIA_RECORDER_INFO_MAX_FILESIZE_REACHED = 801;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public MediaRecorder() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setCamera
				/// </java-name>
				[Dot42.DexImport("setCamera", "(Landroid/hardware/Camera;)V", AccessFlags = 257)]
				public virtual void SetCamera(global::Android.Hardware.Camera camera) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setPreviewDisplay
				/// </java-name>
				[Dot42.DexImport("setPreviewDisplay", "(Landroid/view/Surface;)V", AccessFlags = 1)]
				public virtual void SetPreviewDisplay(global::Android.View.Surface surface) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setAudioSource
				/// </java-name>
				[Dot42.DexImport("setAudioSource", "(I)V", AccessFlags = 257)]
				public virtual void SetAudioSource(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getAudioSourceMax
				/// </java-name>
				[Dot42.DexImport("getAudioSourceMax", "()I", AccessFlags = 25)]
				public static int GetAudioSourceMax() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// setVideoSource
				/// </java-name>
				[Dot42.DexImport("setVideoSource", "(I)V", AccessFlags = 257)]
				public virtual void SetVideoSource(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setProfile
				/// </java-name>
				[Dot42.DexImport("setProfile", "(Landroid/media/CamcorderProfile;)V", AccessFlags = 1)]
				public virtual void SetProfile(global::Android.Media.CamcorderProfile camcorderProfile) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setCaptureRate
				/// </java-name>
				[Dot42.DexImport("setCaptureRate", "(D)V", AccessFlags = 1)]
				public virtual void SetCaptureRate(double @double) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setOrientationHint
				/// </java-name>
				[Dot42.DexImport("setOrientationHint", "(I)V", AccessFlags = 1)]
				public virtual void SetOrientationHint(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setLocation
				/// </java-name>
				[Dot42.DexImport("setLocation", "(FF)V", AccessFlags = 1)]
				public virtual void SetLocation(float single, float single1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setOutputFormat
				/// </java-name>
				[Dot42.DexImport("setOutputFormat", "(I)V", AccessFlags = 257)]
				public virtual void SetOutputFormat(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setVideoSize
				/// </java-name>
				[Dot42.DexImport("setVideoSize", "(II)V", AccessFlags = 257)]
				public virtual void SetVideoSize(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setVideoFrameRate
				/// </java-name>
				[Dot42.DexImport("setVideoFrameRate", "(I)V", AccessFlags = 257)]
				public virtual void SetVideoFrameRate(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setMaxDuration
				/// </java-name>
				[Dot42.DexImport("setMaxDuration", "(I)V", AccessFlags = 257)]
				public virtual void SetMaxDuration(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setMaxFileSize
				/// </java-name>
				[Dot42.DexImport("setMaxFileSize", "(J)V", AccessFlags = 257)]
				public virtual void SetMaxFileSize(long int64) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setAudioEncoder
				/// </java-name>
				[Dot42.DexImport("setAudioEncoder", "(I)V", AccessFlags = 257)]
				public virtual void SetAudioEncoder(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setVideoEncoder
				/// </java-name>
				[Dot42.DexImport("setVideoEncoder", "(I)V", AccessFlags = 257)]
				public virtual void SetVideoEncoder(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setAudioSamplingRate
				/// </java-name>
				[Dot42.DexImport("setAudioSamplingRate", "(I)V", AccessFlags = 1)]
				public virtual void SetAudioSamplingRate(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setAudioChannels
				/// </java-name>
				[Dot42.DexImport("setAudioChannels", "(I)V", AccessFlags = 1)]
				public virtual void SetAudioChannels(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setAudioEncodingBitRate
				/// </java-name>
				[Dot42.DexImport("setAudioEncodingBitRate", "(I)V", AccessFlags = 1)]
				public virtual void SetAudioEncodingBitRate(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setVideoEncodingBitRate
				/// </java-name>
				[Dot42.DexImport("setVideoEncodingBitRate", "(I)V", AccessFlags = 1)]
				public virtual void SetVideoEncodingBitRate(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setAuxiliaryOutputFile
				/// </java-name>
				[Dot42.DexImport("setAuxiliaryOutputFile", "(Ljava/io/FileDescriptor;)V", AccessFlags = 1)]
				public virtual void SetAuxiliaryOutputFile(global::Java.Io.FileDescriptor fileDescriptor) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setAuxiliaryOutputFile
				/// </java-name>
				[Dot42.DexImport("setAuxiliaryOutputFile", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetAuxiliaryOutputFile(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setOutputFile
				/// </java-name>
				[Dot42.DexImport("setOutputFile", "(Ljava/io/FileDescriptor;)V", AccessFlags = 1)]
				public virtual void SetOutputFile(global::Java.Io.FileDescriptor fileDescriptor) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setOutputFile
				/// </java-name>
				[Dot42.DexImport("setOutputFile", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetOutputFile(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// prepare
				/// </java-name>
				[Dot42.DexImport("prepare", "()V", AccessFlags = 1)]
				public virtual void Prepare() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// start
				/// </java-name>
				[Dot42.DexImport("start", "()V", AccessFlags = 257)]
				public virtual void Start() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// stop
				/// </java-name>
				[Dot42.DexImport("stop", "()V", AccessFlags = 257)]
				public virtual void Stop() /* MethodBuilder.Create */ 
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
				/// getMaxAmplitude
				/// </java-name>
				[Dot42.DexImport("getMaxAmplitude", "()I", AccessFlags = 257)]
				public virtual int GetMaxAmplitude() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// setOnErrorListener
				/// </java-name>
				[Dot42.DexImport("setOnErrorListener", "(Landroid/media/MediaRecorder$OnErrorListener;)V", AccessFlags = 1)]
				public virtual void SetOnErrorListener(global::Android.Media.MediaRecorder.IOnErrorListener onErrorListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setOnInfoListener
				/// </java-name>
				[Dot42.DexImport("setOnInfoListener", "(Landroid/media/MediaRecorder$OnInfoListener;)V", AccessFlags = 1)]
				public virtual void SetOnInfoListener(global::Android.Media.MediaRecorder.IOnInfoListener onInfoListener) /* MethodBuilder.Create */ 
				{
				}

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

				/// <java-name>
				/// getAudioSourceMax
				/// </java-name>
				public static int AudioSourceMax
				{
				[Dot42.DexImport("getAudioSourceMax", "()I", AccessFlags = 25)]
						get{ return GetAudioSourceMax(); }
				}

				/// <java-name>
				/// getMaxAmplitude
				/// </java-name>
				public int MaxAmplitude
				{
				[Dot42.DexImport("getMaxAmplitude", "()I", AccessFlags = 257)]
						get{ return GetMaxAmplitude(); }
				}

				/// <java-name>
				/// android/media/MediaRecorder$OnInfoListener
				/// </java-name>
				[Dot42.DexImport("android/media/MediaRecorder$OnInfoListener", AccessFlags = 1545)]
				public partial interface IOnInfoListener
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onInfo
						/// </java-name>
						[Dot42.DexImport("onInfo", "(Landroid/media/MediaRecorder;II)V", AccessFlags = 1025)]
						void OnInfo(global::Android.Media.MediaRecorder mediaRecorder, int int32, int int321) /* MethodBuilder.Create */ ;

				}

				/// <java-name>
				/// android/media/MediaRecorder$OnErrorListener
				/// </java-name>
				[Dot42.DexImport("android/media/MediaRecorder$OnErrorListener", AccessFlags = 1545)]
				public partial interface IOnErrorListener
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onError
						/// </java-name>
						[Dot42.DexImport("onError", "(Landroid/media/MediaRecorder;II)V", AccessFlags = 1025)]
						void OnError(global::Android.Media.MediaRecorder mediaRecorder, int int32, int int321) /* MethodBuilder.Create */ ;

				}

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
						internal VideoEncoder() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

				}

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
						/// <java-name>
						/// AMR_NB
						/// </java-name>
						[Dot42.DexImport("AMR_NB", "I", AccessFlags = 25)]
						public const int AMR_NB = 1;
						/// <java-name>
						/// AMR_WB
						/// </java-name>
						[Dot42.DexImport("AMR_WB", "I", AccessFlags = 25)]
						public const int AMR_WB = 2;
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
						internal AudioEncoder() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

				}

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
						/// <java-name>
						/// THREE_GPP
						/// </java-name>
						[Dot42.DexImport("THREE_GPP", "I", AccessFlags = 25)]
						public const int THREE_GPP = 1;
						/// <java-name>
						/// MPEG_4
						/// </java-name>
						[Dot42.DexImport("MPEG_4", "I", AccessFlags = 25)]
						public const int MPEG_4 = 2;
						/// <java-name>
						/// RAW_AMR
						/// </java-name>
						[Dot42.DexImport("RAW_AMR", "I", AccessFlags = 25)]
						public const int RAW_AMR = 3;
						/// <java-name>
						/// AMR_NB
						/// </java-name>
						[Dot42.DexImport("AMR_NB", "I", AccessFlags = 25)]
						public const int AMR_NB = 3;
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
						internal OutputFormat() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

				}

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
						internal VideoSource() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

				}

				/// <java-name>
				/// android/media/MediaRecorder$AudioSource
				/// </java-name>
				[Dot42.DexImport("android/media/MediaRecorder$AudioSource", AccessFlags = 17)]
				public sealed partial class AudioSource
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// DEFAULT
						/// </java-name>
						[Dot42.DexImport("DEFAULT", "I", AccessFlags = 25)]
						public const int DEFAULT = 0;
						/// <java-name>
						/// MIC
						/// </java-name>
						[Dot42.DexImport("MIC", "I", AccessFlags = 25)]
						public const int MIC = 1;
						/// <java-name>
						/// VOICE_UPLINK
						/// </java-name>
						[Dot42.DexImport("VOICE_UPLINK", "I", AccessFlags = 25)]
						public const int VOICE_UPLINK = 2;
						/// <java-name>
						/// VOICE_DOWNLINK
						/// </java-name>
						[Dot42.DexImport("VOICE_DOWNLINK", "I", AccessFlags = 25)]
						public const int VOICE_DOWNLINK = 3;
						/// <java-name>
						/// VOICE_CALL
						/// </java-name>
						[Dot42.DexImport("VOICE_CALL", "I", AccessFlags = 25)]
						public const int VOICE_CALL = 4;
						/// <java-name>
						/// CAMCORDER
						/// </java-name>
						[Dot42.DexImport("CAMCORDER", "I", AccessFlags = 25)]
						public const int CAMCORDER = 5;
						/// <java-name>
						/// VOICE_RECOGNITION
						/// </java-name>
						[Dot42.DexImport("VOICE_RECOGNITION", "I", AccessFlags = 25)]
						public const int VOICE_RECOGNITION = 6;
						/// <java-name>
						/// VOICE_COMMUNICATION
						/// </java-name>
						[Dot42.DexImport("VOICE_COMMUNICATION", "I", AccessFlags = 25)]
						public const int VOICE_COMMUNICATION = 7;
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
						internal AudioSource() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

				}

		}

		/// <java-name>
		/// android/media/MediaScannerConnection
		/// </java-name>
		[Dot42.DexImport("android/media/MediaScannerConnection", AccessFlags = 33)]
		public partial class MediaScannerConnection : global::Android.Content.IServiceConnection
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/media/MediaScannerConnection$MediaScannerConne" +
    "ctionClient;)V", AccessFlags = 1)]
				public MediaScannerConnection(global::Android.Content.Context context, global::Android.Media.MediaScannerConnection.IMediaScannerConnectionClient mediaScannerConnectionClient) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// connect
				/// </java-name>
				[Dot42.DexImport("connect", "()V", AccessFlags = 1)]
				public virtual void Connect() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// disconnect
				/// </java-name>
				[Dot42.DexImport("disconnect", "()V", AccessFlags = 1)]
				public virtual void Disconnect() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isConnected
				/// </java-name>
				[Dot42.DexImport("isConnected", "()Z", AccessFlags = 33)]
				public virtual bool IsConnected() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// scanFile
				/// </java-name>
				[Dot42.DexImport("scanFile", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void ScanFile(string @string, string string1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// scanFile
				/// </java-name>
				[Dot42.DexImport("scanFile", "(Landroid/content/Context;[Ljava/lang/String;[Ljava/lang/String;Landroid/media/Me" +
    "diaScannerConnection$OnScanCompletedListener;)V", AccessFlags = 9)]
				public static void ScanFile(global::Android.Content.Context context, string[] @string, string[] string1, global::Android.Media.MediaScannerConnection.IOnScanCompletedListener onScanCompletedListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onServiceConnected
				/// </java-name>
				[Dot42.DexImport("onServiceConnected", "(Landroid/content/ComponentName;Landroid/os/IBinder;)V", AccessFlags = 1)]
				public virtual void OnServiceConnected(global::Android.Content.ComponentName componentName, global::Android.OS.IBinder binder) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onServiceDisconnected
				/// </java-name>
				[Dot42.DexImport("onServiceDisconnected", "(Landroid/content/ComponentName;)V", AccessFlags = 1)]
				public virtual void OnServiceDisconnected(global::Android.Content.ComponentName componentName) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal MediaScannerConnection() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// android/media/MediaScannerConnection$MediaScannerConnectionClient
				/// </java-name>
				[Dot42.DexImport("android/media/MediaScannerConnection$MediaScannerConnectionClient", AccessFlags = 1545)]
				public partial interface IMediaScannerConnectionClient : global::Android.Media.MediaScannerConnection.IOnScanCompletedListener
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onMediaScannerConnected
						/// </java-name>
						[Dot42.DexImport("onMediaScannerConnected", "()V", AccessFlags = 1025)]
						void OnMediaScannerConnected() /* MethodBuilder.Create */ ;

						/// <java-name>
						/// onScanCompleted
						/// </java-name>
						[Dot42.DexImport("onScanCompleted", "(Ljava/lang/String;Landroid/net/Uri;)V", AccessFlags = 1025)]
						void OnScanCompleted(string @string, global::Android.Net.Uri uri) /* MethodBuilder.Create */ ;

				}

				/// <java-name>
				/// android/media/MediaScannerConnection$OnScanCompletedListener
				/// </java-name>
				[Dot42.DexImport("android/media/MediaScannerConnection$OnScanCompletedListener", AccessFlags = 1545)]
				public partial interface IOnScanCompletedListener
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onScanCompleted
						/// </java-name>
						[Dot42.DexImport("onScanCompleted", "(Ljava/lang/String;Landroid/net/Uri;)V", AccessFlags = 1025)]
						void OnScanCompleted(string @string, global::Android.Net.Uri uri) /* MethodBuilder.Create */ ;

				}

		}

		/// <java-name>
		/// android/media/RemoteControlClient
		/// </java-name>
		[Dot42.DexImport("android/media/RemoteControlClient", AccessFlags = 33)]
		public partial class RemoteControlClient
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// PLAYSTATE_STOPPED
				/// </java-name>
				[Dot42.DexImport("PLAYSTATE_STOPPED", "I", AccessFlags = 25)]
				public const int PLAYSTATE_STOPPED = 1;
				/// <java-name>
				/// PLAYSTATE_PAUSED
				/// </java-name>
				[Dot42.DexImport("PLAYSTATE_PAUSED", "I", AccessFlags = 25)]
				public const int PLAYSTATE_PAUSED = 2;
				/// <java-name>
				/// PLAYSTATE_PLAYING
				/// </java-name>
				[Dot42.DexImport("PLAYSTATE_PLAYING", "I", AccessFlags = 25)]
				public const int PLAYSTATE_PLAYING = 3;
				/// <java-name>
				/// PLAYSTATE_FAST_FORWARDING
				/// </java-name>
				[Dot42.DexImport("PLAYSTATE_FAST_FORWARDING", "I", AccessFlags = 25)]
				public const int PLAYSTATE_FAST_FORWARDING = 4;
				/// <java-name>
				/// PLAYSTATE_REWINDING
				/// </java-name>
				[Dot42.DexImport("PLAYSTATE_REWINDING", "I", AccessFlags = 25)]
				public const int PLAYSTATE_REWINDING = 5;
				/// <java-name>
				/// PLAYSTATE_SKIPPING_FORWARDS
				/// </java-name>
				[Dot42.DexImport("PLAYSTATE_SKIPPING_FORWARDS", "I", AccessFlags = 25)]
				public const int PLAYSTATE_SKIPPING_FORWARDS = 6;
				/// <java-name>
				/// PLAYSTATE_SKIPPING_BACKWARDS
				/// </java-name>
				[Dot42.DexImport("PLAYSTATE_SKIPPING_BACKWARDS", "I", AccessFlags = 25)]
				public const int PLAYSTATE_SKIPPING_BACKWARDS = 7;
				/// <java-name>
				/// PLAYSTATE_BUFFERING
				/// </java-name>
				[Dot42.DexImport("PLAYSTATE_BUFFERING", "I", AccessFlags = 25)]
				public const int PLAYSTATE_BUFFERING = 8;
				/// <java-name>
				/// PLAYSTATE_ERROR
				/// </java-name>
				[Dot42.DexImport("PLAYSTATE_ERROR", "I", AccessFlags = 25)]
				public const int PLAYSTATE_ERROR = 9;
				/// <java-name>
				/// FLAG_KEY_MEDIA_PREVIOUS
				/// </java-name>
				[Dot42.DexImport("FLAG_KEY_MEDIA_PREVIOUS", "I", AccessFlags = 25)]
				public const int FLAG_KEY_MEDIA_PREVIOUS = 1;
				/// <java-name>
				/// FLAG_KEY_MEDIA_REWIND
				/// </java-name>
				[Dot42.DexImport("FLAG_KEY_MEDIA_REWIND", "I", AccessFlags = 25)]
				public const int FLAG_KEY_MEDIA_REWIND = 2;
				/// <java-name>
				/// FLAG_KEY_MEDIA_PLAY
				/// </java-name>
				[Dot42.DexImport("FLAG_KEY_MEDIA_PLAY", "I", AccessFlags = 25)]
				public const int FLAG_KEY_MEDIA_PLAY = 4;
				/// <java-name>
				/// FLAG_KEY_MEDIA_PLAY_PAUSE
				/// </java-name>
				[Dot42.DexImport("FLAG_KEY_MEDIA_PLAY_PAUSE", "I", AccessFlags = 25)]
				public const int FLAG_KEY_MEDIA_PLAY_PAUSE = 8;
				/// <java-name>
				/// FLAG_KEY_MEDIA_PAUSE
				/// </java-name>
				[Dot42.DexImport("FLAG_KEY_MEDIA_PAUSE", "I", AccessFlags = 25)]
				public const int FLAG_KEY_MEDIA_PAUSE = 16;
				/// <java-name>
				/// FLAG_KEY_MEDIA_STOP
				/// </java-name>
				[Dot42.DexImport("FLAG_KEY_MEDIA_STOP", "I", AccessFlags = 25)]
				public const int FLAG_KEY_MEDIA_STOP = 32;
				/// <java-name>
				/// FLAG_KEY_MEDIA_FAST_FORWARD
				/// </java-name>
				[Dot42.DexImport("FLAG_KEY_MEDIA_FAST_FORWARD", "I", AccessFlags = 25)]
				public const int FLAG_KEY_MEDIA_FAST_FORWARD = 64;
				/// <java-name>
				/// FLAG_KEY_MEDIA_NEXT
				/// </java-name>
				[Dot42.DexImport("FLAG_KEY_MEDIA_NEXT", "I", AccessFlags = 25)]
				public const int FLAG_KEY_MEDIA_NEXT = 128;
				[Dot42.DexImport("<init>", "(Landroid/app/PendingIntent;)V", AccessFlags = 1)]
				public RemoteControlClient(global::Android.App.PendingIntent pendingIntent) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/app/PendingIntent;Landroid/os/Looper;)V", AccessFlags = 1)]
				public RemoteControlClient(global::Android.App.PendingIntent pendingIntent, global::Android.OS.Looper looper) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// editMetadata
				/// </java-name>
				[Dot42.DexImport("editMetadata", "(Z)Landroid/media/RemoteControlClient$MetadataEditor;", AccessFlags = 1)]
				public virtual global::Android.Media.RemoteControlClient.MetadataEditor EditMetadata(bool boolean) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Media.RemoteControlClient.MetadataEditor);
				}

				/// <java-name>
				/// setPlaybackState
				/// </java-name>
				[Dot42.DexImport("setPlaybackState", "(I)V", AccessFlags = 1)]
				public virtual void SetPlaybackState(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setTransportControlFlags
				/// </java-name>
				[Dot42.DexImport("setTransportControlFlags", "(I)V", AccessFlags = 1)]
				public virtual void SetTransportControlFlags(int int32) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal RemoteControlClient() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// android/media/RemoteControlClient$MetadataEditor
				/// </java-name>
				[Dot42.DexImport("android/media/RemoteControlClient$MetadataEditor", AccessFlags = 1)]
				public partial class MetadataEditor
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// BITMAP_KEY_ARTWORK
						/// </java-name>
						[Dot42.DexImport("BITMAP_KEY_ARTWORK", "I", AccessFlags = 25)]
						public const int BITMAP_KEY_ARTWORK = 100;
						/// <java-name>
						/// this$0
						/// </java-name>
						[Dot42.DexImport("this$0", "Landroid/media/RemoteControlClient;", AccessFlags = 4112)]
						internal readonly global::Android.Media.RemoteControlClient This_0;
						[Dot42.DexImport("<init>", "(Landroid/media/RemoteControlClient;)V", AccessFlags = 0)]
						internal MetadataEditor(global::Android.Media.RemoteControlClient remoteControlClient) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// putString
						/// </java-name>
						[Dot42.DexImport("putString", "(ILjava/lang/String;)Landroid/media/RemoteControlClient$MetadataEditor;", AccessFlags = 33)]
						public virtual MetadataEditor PutString(int int32, string @string) /* MethodBuilder.Create */ 
						{
								return default(MetadataEditor);
						}

						/// <java-name>
						/// putLong
						/// </java-name>
						[Dot42.DexImport("putLong", "(IJ)Landroid/media/RemoteControlClient$MetadataEditor;", AccessFlags = 33)]
						public virtual MetadataEditor PutLong(int int32, long int64) /* MethodBuilder.Create */ 
						{
								return default(MetadataEditor);
						}

						/// <java-name>
						/// putBitmap
						/// </java-name>
						[Dot42.DexImport("putBitmap", "(ILandroid/graphics/Bitmap;)Landroid/media/RemoteControlClient$MetadataEditor;", AccessFlags = 33)]
						public virtual MetadataEditor PutBitmap(int int32, global::Android.Graphics.Bitmap bitmap) /* MethodBuilder.Create */ 
						{
								return default(MetadataEditor);
						}

						/// <java-name>
						/// clear
						/// </java-name>
						[Dot42.DexImport("clear", "()V", AccessFlags = 33)]
						public virtual void Clear() /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// apply
						/// </java-name>
						[Dot42.DexImport("apply", "()V", AccessFlags = 33)]
						public virtual void Apply() /* MethodBuilder.Create */ 
						{
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal MetadataEditor() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

				}

		}

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

				/// <java-name>
				/// setStreamType
				/// </java-name>
				[Dot42.DexImport("setStreamType", "(I)V", AccessFlags = 1)]
				public virtual void SetStreamType(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getStreamType
				/// </java-name>
				[Dot42.DexImport("getStreamType", "()I", AccessFlags = 1)]
				public virtual int GetStreamType() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getTitle
				/// </java-name>
				[Dot42.DexImport("getTitle", "(Landroid/content/Context;)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetTitle(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// play
				/// </java-name>
				[Dot42.DexImport("play", "()V", AccessFlags = 1)]
				public virtual void Play() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// stop
				/// </java-name>
				[Dot42.DexImport("stop", "()V", AccessFlags = 1)]
				public virtual void Stop() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isPlaying
				/// </java-name>
				[Dot42.DexImport("isPlaying", "()Z", AccessFlags = 1)]
				public virtual bool IsPlaying() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getStreamType
				/// </java-name>
				public int StreamType
				{
				[Dot42.DexImport("getStreamType", "()I", AccessFlags = 1)]
						get{ return GetStreamType(); }
				[Dot42.DexImport("setStreamType", "(I)V", AccessFlags = 1)]
						set{ SetStreamType(value); }
				}

		}

		/// <java-name>
		/// android/media/RingtoneManager
		/// </java-name>
		[Dot42.DexImport("android/media/RingtoneManager", AccessFlags = 33)]
		public partial class RingtoneManager
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// TYPE_RINGTONE
				/// </java-name>
				[Dot42.DexImport("TYPE_RINGTONE", "I", AccessFlags = 25)]
				public const int TYPE_RINGTONE = 1;
				/// <java-name>
				/// TYPE_NOTIFICATION
				/// </java-name>
				[Dot42.DexImport("TYPE_NOTIFICATION", "I", AccessFlags = 25)]
				public const int TYPE_NOTIFICATION = 2;
				/// <java-name>
				/// TYPE_ALARM
				/// </java-name>
				[Dot42.DexImport("TYPE_ALARM", "I", AccessFlags = 25)]
				public const int TYPE_ALARM = 4;
				/// <java-name>
				/// TYPE_ALL
				/// </java-name>
				[Dot42.DexImport("TYPE_ALL", "I", AccessFlags = 25)]
				public const int TYPE_ALL = 7;
				/// <java-name>
				/// ACTION_RINGTONE_PICKER
				/// </java-name>
				[Dot42.DexImport("ACTION_RINGTONE_PICKER", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_RINGTONE_PICKER = "android.intent.action.RINGTONE_PICKER";
				/// <java-name>
				/// EXTRA_RINGTONE_SHOW_DEFAULT
				/// </java-name>
				[Dot42.DexImport("EXTRA_RINGTONE_SHOW_DEFAULT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_RINGTONE_SHOW_DEFAULT = "android.intent.extra.ringtone.SHOW_DEFAULT";
				/// <java-name>
				/// EXTRA_RINGTONE_SHOW_SILENT
				/// </java-name>
				[Dot42.DexImport("EXTRA_RINGTONE_SHOW_SILENT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_RINGTONE_SHOW_SILENT = "android.intent.extra.ringtone.SHOW_SILENT";
				/// <java-name>
				/// EXTRA_RINGTONE_INCLUDE_DRM
				/// </java-name>
				[Dot42.DexImport("EXTRA_RINGTONE_INCLUDE_DRM", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_RINGTONE_INCLUDE_DRM = "android.intent.extra.ringtone.INCLUDE_DRM";
				/// <java-name>
				/// EXTRA_RINGTONE_EXISTING_URI
				/// </java-name>
				[Dot42.DexImport("EXTRA_RINGTONE_EXISTING_URI", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_RINGTONE_EXISTING_URI = "android.intent.extra.ringtone.EXISTING_URI";
				/// <java-name>
				/// EXTRA_RINGTONE_DEFAULT_URI
				/// </java-name>
				[Dot42.DexImport("EXTRA_RINGTONE_DEFAULT_URI", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_RINGTONE_DEFAULT_URI = "android.intent.extra.ringtone.DEFAULT_URI";
				/// <java-name>
				/// EXTRA_RINGTONE_TYPE
				/// </java-name>
				[Dot42.DexImport("EXTRA_RINGTONE_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_RINGTONE_TYPE = "android.intent.extra.ringtone.TYPE";
				/// <java-name>
				/// EXTRA_RINGTONE_TITLE
				/// </java-name>
				[Dot42.DexImport("EXTRA_RINGTONE_TITLE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_RINGTONE_TITLE = "android.intent.extra.ringtone.TITLE";
				/// <java-name>
				/// EXTRA_RINGTONE_PICKED_URI
				/// </java-name>
				[Dot42.DexImport("EXTRA_RINGTONE_PICKED_URI", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_RINGTONE_PICKED_URI = "android.intent.extra.ringtone.PICKED_URI";
				/// <java-name>
				/// ID_COLUMN_INDEX
				/// </java-name>
				[Dot42.DexImport("ID_COLUMN_INDEX", "I", AccessFlags = 25)]
				public const int ID_COLUMN_INDEX = 0;
				/// <java-name>
				/// TITLE_COLUMN_INDEX
				/// </java-name>
				[Dot42.DexImport("TITLE_COLUMN_INDEX", "I", AccessFlags = 25)]
				public const int TITLE_COLUMN_INDEX = 1;
				/// <java-name>
				/// URI_COLUMN_INDEX
				/// </java-name>
				[Dot42.DexImport("URI_COLUMN_INDEX", "I", AccessFlags = 25)]
				public const int URI_COLUMN_INDEX = 2;
				[Dot42.DexImport("<init>", "(Landroid/app/Activity;)V", AccessFlags = 1)]
				public RingtoneManager(global::Android.App.Activity activity) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public RingtoneManager(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setType
				/// </java-name>
				[Dot42.DexImport("setType", "(I)V", AccessFlags = 1)]
				public virtual void SetType(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// inferStreamType
				/// </java-name>
				[Dot42.DexImport("inferStreamType", "()I", AccessFlags = 1)]
				public virtual int InferStreamType() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// setStopPreviousRingtone
				/// </java-name>
				[Dot42.DexImport("setStopPreviousRingtone", "(Z)V", AccessFlags = 1)]
				public virtual void SetStopPreviousRingtone(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getStopPreviousRingtone
				/// </java-name>
				[Dot42.DexImport("getStopPreviousRingtone", "()Z", AccessFlags = 1)]
				public virtual bool GetStopPreviousRingtone() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// stopPreviousRingtone
				/// </java-name>
				[Dot42.DexImport("stopPreviousRingtone", "()V", AccessFlags = 1)]
				public virtual void StopPreviousRingtone() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getIncludeDrm
				/// </java-name>
				[Dot42.DexImport("getIncludeDrm", "()Z", AccessFlags = 1)]
				public virtual bool GetIncludeDrm() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setIncludeDrm
				/// </java-name>
				[Dot42.DexImport("setIncludeDrm", "(Z)V", AccessFlags = 1)]
				public virtual void SetIncludeDrm(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getCursor
				/// </java-name>
				[Dot42.DexImport("getCursor", "()Landroid/database/Cursor;", AccessFlags = 1)]
				public virtual global::Android.Database.ICursor GetCursor() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Database.ICursor);
				}

				/// <java-name>
				/// getRingtone
				/// </java-name>
				[Dot42.DexImport("getRingtone", "(I)Landroid/media/Ringtone;", AccessFlags = 1)]
				public virtual global::Android.Media.Ringtone GetRingtone(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Media.Ringtone);
				}

				/// <java-name>
				/// getRingtoneUri
				/// </java-name>
				[Dot42.DexImport("getRingtoneUri", "(I)Landroid/net/Uri;", AccessFlags = 1)]
				public virtual global::Android.Net.Uri GetRingtoneUri(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Net.Uri);
				}

				/// <java-name>
				/// getRingtonePosition
				/// </java-name>
				[Dot42.DexImport("getRingtonePosition", "(Landroid/net/Uri;)I", AccessFlags = 1)]
				public virtual int GetRingtonePosition(global::Android.Net.Uri uri) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getValidRingtoneUri
				/// </java-name>
				[Dot42.DexImport("getValidRingtoneUri", "(Landroid/content/Context;)Landroid/net/Uri;", AccessFlags = 9)]
				public static global::Android.Net.Uri GetValidRingtoneUri(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Net.Uri);
				}

				/// <java-name>
				/// getRingtone
				/// </java-name>
				[Dot42.DexImport("getRingtone", "(Landroid/content/Context;Landroid/net/Uri;)Landroid/media/Ringtone;", AccessFlags = 9)]
				public static global::Android.Media.Ringtone GetRingtone(global::Android.Content.Context context, global::Android.Net.Uri uri) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Media.Ringtone);
				}

				/// <java-name>
				/// getActualDefaultRingtoneUri
				/// </java-name>
				[Dot42.DexImport("getActualDefaultRingtoneUri", "(Landroid/content/Context;I)Landroid/net/Uri;", AccessFlags = 9)]
				public static global::Android.Net.Uri GetActualDefaultRingtoneUri(global::Android.Content.Context context, int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Net.Uri);
				}

				/// <java-name>
				/// setActualDefaultRingtoneUri
				/// </java-name>
				[Dot42.DexImport("setActualDefaultRingtoneUri", "(Landroid/content/Context;ILandroid/net/Uri;)V", AccessFlags = 9)]
				public static void SetActualDefaultRingtoneUri(global::Android.Content.Context context, int int32, global::Android.Net.Uri uri) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isDefault
				/// </java-name>
				[Dot42.DexImport("isDefault", "(Landroid/net/Uri;)Z", AccessFlags = 9)]
				public static bool IsDefault(global::Android.Net.Uri uri) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getDefaultType
				/// </java-name>
				[Dot42.DexImport("getDefaultType", "(Landroid/net/Uri;)I", AccessFlags = 9)]
				public static int GetDefaultType(global::Android.Net.Uri uri) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getDefaultUri
				/// </java-name>
				[Dot42.DexImport("getDefaultUri", "(I)Landroid/net/Uri;", AccessFlags = 9)]
				public static global::Android.Net.Uri GetDefaultUri(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Net.Uri);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal RingtoneManager() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getStopPreviousRingtone
				/// </java-name>
				public bool IsStopPreviousRingtone
				{
				[Dot42.DexImport("getStopPreviousRingtone", "()Z", AccessFlags = 1)]
						get{ return GetStopPreviousRingtone(); }
				[Dot42.DexImport("setStopPreviousRingtone", "(Z)V", AccessFlags = 1)]
						set{ SetStopPreviousRingtone(value); }
				}

				/// <java-name>
				/// getIncludeDrm
				/// </java-name>
				public bool IsIncludeDrm
				{
				[Dot42.DexImport("getIncludeDrm", "()Z", AccessFlags = 1)]
						get{ return GetIncludeDrm(); }
				[Dot42.DexImport("setIncludeDrm", "(Z)V", AccessFlags = 1)]
						set{ SetIncludeDrm(value); }
				}

				/// <java-name>
				/// getCursor
				/// </java-name>
				public global::Android.Database.ICursor Cursor
				{
				[Dot42.DexImport("getCursor", "()Landroid/database/Cursor;", AccessFlags = 1)]
						get{ return GetCursor(); }
				}

		}

		/// <java-name>
		/// android/media/SoundPool
		/// </java-name>
		[Dot42.DexImport("android/media/SoundPool", AccessFlags = 33)]
		public partial class SoundPool
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(III)V", AccessFlags = 1)]
				public SoundPool(int int32, int int321, int int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// load
				/// </java-name>
				[Dot42.DexImport("load", "(Ljava/lang/String;I)I", AccessFlags = 1)]
				public virtual int Load(string @string, int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// load
				/// </java-name>
				[Dot42.DexImport("load", "(Landroid/content/Context;II)I", AccessFlags = 1)]
				public virtual int Load(global::Android.Content.Context context, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// load
				/// </java-name>
				[Dot42.DexImport("load", "(Landroid/content/res/AssetFileDescriptor;I)I", AccessFlags = 1)]
				public virtual int Load(global::Android.Content.Res.AssetFileDescriptor assetFileDescriptor, int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// load
				/// </java-name>
				[Dot42.DexImport("load", "(Ljava/io/FileDescriptor;JJI)I", AccessFlags = 1)]
				public virtual int Load(global::Java.Io.FileDescriptor fileDescriptor, long int64, long int641, int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// unload
				/// </java-name>
				[Dot42.DexImport("unload", "(I)Z", AccessFlags = 273)]
				public bool Unload(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// play
				/// </java-name>
				[Dot42.DexImport("play", "(IFFIIF)I", AccessFlags = 273)]
				public int Play(int int32, float single, float single1, int int321, int int322, float single2) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// pause
				/// </java-name>
				[Dot42.DexImport("pause", "(I)V", AccessFlags = 273)]
				public void Pause(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// resume
				/// </java-name>
				[Dot42.DexImport("resume", "(I)V", AccessFlags = 273)]
				public void Resume(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// autoPause
				/// </java-name>
				[Dot42.DexImport("autoPause", "()V", AccessFlags = 273)]
				public void AutoPause() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// autoResume
				/// </java-name>
				[Dot42.DexImport("autoResume", "()V", AccessFlags = 273)]
				public void AutoResume() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// stop
				/// </java-name>
				[Dot42.DexImport("stop", "(I)V", AccessFlags = 273)]
				public void Stop(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setVolume
				/// </java-name>
				[Dot42.DexImport("setVolume", "(IFF)V", AccessFlags = 273)]
				public void SetVolume(int int32, float single, float single1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setPriority
				/// </java-name>
				[Dot42.DexImport("setPriority", "(II)V", AccessFlags = 273)]
				public void SetPriority(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setLoop
				/// </java-name>
				[Dot42.DexImport("setLoop", "(II)V", AccessFlags = 273)]
				public void SetLoop(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setRate
				/// </java-name>
				[Dot42.DexImport("setRate", "(IF)V", AccessFlags = 273)]
				public void SetRate(int int32, float single) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setOnLoadCompleteListener
				/// </java-name>
				[Dot42.DexImport("setOnLoadCompleteListener", "(Landroid/media/SoundPool$OnLoadCompleteListener;)V", AccessFlags = 1)]
				public virtual void SetOnLoadCompleteListener(global::Android.Media.SoundPool.IOnLoadCompleteListener onLoadCompleteListener) /* MethodBuilder.Create */ 
				{
				}

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
				internal SoundPool() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// android/media/SoundPool$OnLoadCompleteListener
				/// </java-name>
				[Dot42.DexImport("android/media/SoundPool$OnLoadCompleteListener", AccessFlags = 1545)]
				public partial interface IOnLoadCompleteListener
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onLoadComplete
						/// </java-name>
						[Dot42.DexImport("onLoadComplete", "(Landroid/media/SoundPool;II)V", AccessFlags = 1025)]
						void OnLoadComplete(global::Android.Media.SoundPool soundPool, int int32, int int321) /* MethodBuilder.Create */ ;

				}

		}

		/// <java-name>
		/// android/media/ThumbnailUtils
		/// </java-name>
		[Dot42.DexImport("android/media/ThumbnailUtils", AccessFlags = 33)]
		public partial class ThumbnailUtils
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// OPTIONS_RECYCLE_INPUT
				/// </java-name>
				[Dot42.DexImport("OPTIONS_RECYCLE_INPUT", "I", AccessFlags = 25)]
				public const int OPTIONS_RECYCLE_INPUT = 2;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ThumbnailUtils() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// createVideoThumbnail
				/// </java-name>
				[Dot42.DexImport("createVideoThumbnail", "(Ljava/lang/String;I)Landroid/graphics/Bitmap;", AccessFlags = 9)]
				public static global::Android.Graphics.Bitmap CreateVideoThumbnail(string @string, int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Bitmap);
				}

				/// <java-name>
				/// extractThumbnail
				/// </java-name>
				[Dot42.DexImport("extractThumbnail", "(Landroid/graphics/Bitmap;II)Landroid/graphics/Bitmap;", AccessFlags = 9)]
				public static global::Android.Graphics.Bitmap ExtractThumbnail(global::Android.Graphics.Bitmap bitmap, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Bitmap);
				}

				/// <java-name>
				/// extractThumbnail
				/// </java-name>
				[Dot42.DexImport("extractThumbnail", "(Landroid/graphics/Bitmap;III)Landroid/graphics/Bitmap;", AccessFlags = 9)]
				public static global::Android.Graphics.Bitmap ExtractThumbnail(global::Android.Graphics.Bitmap bitmap, int int32, int int321, int int322) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Bitmap);
				}

		}

		/// <java-name>
		/// android/media/ToneGenerator
		/// </java-name>
		[Dot42.DexImport("android/media/ToneGenerator", AccessFlags = 33)]
		public partial class ToneGenerator
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// TONE_DTMF_0
				/// </java-name>
				[Dot42.DexImport("TONE_DTMF_0", "I", AccessFlags = 25)]
				public const int TONE_DTMF_0 = 0;
				/// <java-name>
				/// TONE_DTMF_1
				/// </java-name>
				[Dot42.DexImport("TONE_DTMF_1", "I", AccessFlags = 25)]
				public const int TONE_DTMF_1 = 1;
				/// <java-name>
				/// TONE_DTMF_2
				/// </java-name>
				[Dot42.DexImport("TONE_DTMF_2", "I", AccessFlags = 25)]
				public const int TONE_DTMF_2 = 2;
				/// <java-name>
				/// TONE_DTMF_3
				/// </java-name>
				[Dot42.DexImport("TONE_DTMF_3", "I", AccessFlags = 25)]
				public const int TONE_DTMF_3 = 3;
				/// <java-name>
				/// TONE_DTMF_4
				/// </java-name>
				[Dot42.DexImport("TONE_DTMF_4", "I", AccessFlags = 25)]
				public const int TONE_DTMF_4 = 4;
				/// <java-name>
				/// TONE_DTMF_5
				/// </java-name>
				[Dot42.DexImport("TONE_DTMF_5", "I", AccessFlags = 25)]
				public const int TONE_DTMF_5 = 5;
				/// <java-name>
				/// TONE_DTMF_6
				/// </java-name>
				[Dot42.DexImport("TONE_DTMF_6", "I", AccessFlags = 25)]
				public const int TONE_DTMF_6 = 6;
				/// <java-name>
				/// TONE_DTMF_7
				/// </java-name>
				[Dot42.DexImport("TONE_DTMF_7", "I", AccessFlags = 25)]
				public const int TONE_DTMF_7 = 7;
				/// <java-name>
				/// TONE_DTMF_8
				/// </java-name>
				[Dot42.DexImport("TONE_DTMF_8", "I", AccessFlags = 25)]
				public const int TONE_DTMF_8 = 8;
				/// <java-name>
				/// TONE_DTMF_9
				/// </java-name>
				[Dot42.DexImport("TONE_DTMF_9", "I", AccessFlags = 25)]
				public const int TONE_DTMF_9 = 9;
				/// <java-name>
				/// TONE_DTMF_S
				/// </java-name>
				[Dot42.DexImport("TONE_DTMF_S", "I", AccessFlags = 25)]
				public const int TONE_DTMF_S = 10;
				/// <java-name>
				/// TONE_DTMF_P
				/// </java-name>
				[Dot42.DexImport("TONE_DTMF_P", "I", AccessFlags = 25)]
				public const int TONE_DTMF_P = 11;
				/// <java-name>
				/// TONE_DTMF_A
				/// </java-name>
				[Dot42.DexImport("TONE_DTMF_A", "I", AccessFlags = 25)]
				public const int TONE_DTMF_A = 12;
				/// <java-name>
				/// TONE_DTMF_B
				/// </java-name>
				[Dot42.DexImport("TONE_DTMF_B", "I", AccessFlags = 25)]
				public const int TONE_DTMF_B = 13;
				/// <java-name>
				/// TONE_DTMF_C
				/// </java-name>
				[Dot42.DexImport("TONE_DTMF_C", "I", AccessFlags = 25)]
				public const int TONE_DTMF_C = 14;
				/// <java-name>
				/// TONE_DTMF_D
				/// </java-name>
				[Dot42.DexImport("TONE_DTMF_D", "I", AccessFlags = 25)]
				public const int TONE_DTMF_D = 15;
				/// <java-name>
				/// TONE_SUP_DIAL
				/// </java-name>
				[Dot42.DexImport("TONE_SUP_DIAL", "I", AccessFlags = 25)]
				public const int TONE_SUP_DIAL = 16;
				/// <java-name>
				/// TONE_SUP_BUSY
				/// </java-name>
				[Dot42.DexImport("TONE_SUP_BUSY", "I", AccessFlags = 25)]
				public const int TONE_SUP_BUSY = 17;
				/// <java-name>
				/// TONE_SUP_CONGESTION
				/// </java-name>
				[Dot42.DexImport("TONE_SUP_CONGESTION", "I", AccessFlags = 25)]
				public const int TONE_SUP_CONGESTION = 18;
				/// <java-name>
				/// TONE_SUP_RADIO_ACK
				/// </java-name>
				[Dot42.DexImport("TONE_SUP_RADIO_ACK", "I", AccessFlags = 25)]
				public const int TONE_SUP_RADIO_ACK = 19;
				/// <java-name>
				/// TONE_SUP_RADIO_NOTAVAIL
				/// </java-name>
				[Dot42.DexImport("TONE_SUP_RADIO_NOTAVAIL", "I", AccessFlags = 25)]
				public const int TONE_SUP_RADIO_NOTAVAIL = 20;
				/// <java-name>
				/// TONE_SUP_ERROR
				/// </java-name>
				[Dot42.DexImport("TONE_SUP_ERROR", "I", AccessFlags = 25)]
				public const int TONE_SUP_ERROR = 21;
				/// <java-name>
				/// TONE_SUP_CALL_WAITING
				/// </java-name>
				[Dot42.DexImport("TONE_SUP_CALL_WAITING", "I", AccessFlags = 25)]
				public const int TONE_SUP_CALL_WAITING = 22;
				/// <java-name>
				/// TONE_SUP_RINGTONE
				/// </java-name>
				[Dot42.DexImport("TONE_SUP_RINGTONE", "I", AccessFlags = 25)]
				public const int TONE_SUP_RINGTONE = 23;
				/// <java-name>
				/// TONE_PROP_BEEP
				/// </java-name>
				[Dot42.DexImport("TONE_PROP_BEEP", "I", AccessFlags = 25)]
				public const int TONE_PROP_BEEP = 24;
				/// <java-name>
				/// TONE_PROP_ACK
				/// </java-name>
				[Dot42.DexImport("TONE_PROP_ACK", "I", AccessFlags = 25)]
				public const int TONE_PROP_ACK = 25;
				/// <java-name>
				/// TONE_PROP_NACK
				/// </java-name>
				[Dot42.DexImport("TONE_PROP_NACK", "I", AccessFlags = 25)]
				public const int TONE_PROP_NACK = 26;
				/// <java-name>
				/// TONE_PROP_PROMPT
				/// </java-name>
				[Dot42.DexImport("TONE_PROP_PROMPT", "I", AccessFlags = 25)]
				public const int TONE_PROP_PROMPT = 27;
				/// <java-name>
				/// TONE_PROP_BEEP2
				/// </java-name>
				[Dot42.DexImport("TONE_PROP_BEEP2", "I", AccessFlags = 25)]
				public const int TONE_PROP_BEEP2 = 28;
				/// <java-name>
				/// TONE_SUP_INTERCEPT
				/// </java-name>
				[Dot42.DexImport("TONE_SUP_INTERCEPT", "I", AccessFlags = 25)]
				public const int TONE_SUP_INTERCEPT = 29;
				/// <java-name>
				/// TONE_SUP_INTERCEPT_ABBREV
				/// </java-name>
				[Dot42.DexImport("TONE_SUP_INTERCEPT_ABBREV", "I", AccessFlags = 25)]
				public const int TONE_SUP_INTERCEPT_ABBREV = 30;
				/// <java-name>
				/// TONE_SUP_CONGESTION_ABBREV
				/// </java-name>
				[Dot42.DexImport("TONE_SUP_CONGESTION_ABBREV", "I", AccessFlags = 25)]
				public const int TONE_SUP_CONGESTION_ABBREV = 31;
				/// <java-name>
				/// TONE_SUP_CONFIRM
				/// </java-name>
				[Dot42.DexImport("TONE_SUP_CONFIRM", "I", AccessFlags = 25)]
				public const int TONE_SUP_CONFIRM = 32;
				/// <java-name>
				/// TONE_SUP_PIP
				/// </java-name>
				[Dot42.DexImport("TONE_SUP_PIP", "I", AccessFlags = 25)]
				public const int TONE_SUP_PIP = 33;
				/// <java-name>
				/// TONE_CDMA_DIAL_TONE_LITE
				/// </java-name>
				[Dot42.DexImport("TONE_CDMA_DIAL_TONE_LITE", "I", AccessFlags = 25)]
				public const int TONE_CDMA_DIAL_TONE_LITE = 34;
				/// <java-name>
				/// TONE_CDMA_NETWORK_USA_RINGBACK
				/// </java-name>
				[Dot42.DexImport("TONE_CDMA_NETWORK_USA_RINGBACK", "I", AccessFlags = 25)]
				public const int TONE_CDMA_NETWORK_USA_RINGBACK = 35;
				/// <java-name>
				/// TONE_CDMA_INTERCEPT
				/// </java-name>
				[Dot42.DexImport("TONE_CDMA_INTERCEPT", "I", AccessFlags = 25)]
				public const int TONE_CDMA_INTERCEPT = 36;
				/// <java-name>
				/// TONE_CDMA_ABBR_INTERCEPT
				/// </java-name>
				[Dot42.DexImport("TONE_CDMA_ABBR_INTERCEPT", "I", AccessFlags = 25)]
				public const int TONE_CDMA_ABBR_INTERCEPT = 37;
				/// <java-name>
				/// TONE_CDMA_REORDER
				/// </java-name>
				[Dot42.DexImport("TONE_CDMA_REORDER", "I", AccessFlags = 25)]
				public const int TONE_CDMA_REORDER = 38;
				/// <java-name>
				/// TONE_CDMA_ABBR_REORDER
				/// </java-name>
				[Dot42.DexImport("TONE_CDMA_ABBR_REORDER", "I", AccessFlags = 25)]
				public const int TONE_CDMA_ABBR_REORDER = 39;
				/// <java-name>
				/// TONE_CDMA_NETWORK_BUSY
				/// </java-name>
				[Dot42.DexImport("TONE_CDMA_NETWORK_BUSY", "I", AccessFlags = 25)]
				public const int TONE_CDMA_NETWORK_BUSY = 40;
				/// <java-name>
				/// TONE_CDMA_CONFIRM
				/// </java-name>
				[Dot42.DexImport("TONE_CDMA_CONFIRM", "I", AccessFlags = 25)]
				public const int TONE_CDMA_CONFIRM = 41;
				/// <java-name>
				/// TONE_CDMA_ANSWER
				/// </java-name>
				[Dot42.DexImport("TONE_CDMA_ANSWER", "I", AccessFlags = 25)]
				public const int TONE_CDMA_ANSWER = 42;
				/// <java-name>
				/// TONE_CDMA_NETWORK_CALLWAITING
				/// </java-name>
				[Dot42.DexImport("TONE_CDMA_NETWORK_CALLWAITING", "I", AccessFlags = 25)]
				public const int TONE_CDMA_NETWORK_CALLWAITING = 43;
				/// <java-name>
				/// TONE_CDMA_PIP
				/// </java-name>
				[Dot42.DexImport("TONE_CDMA_PIP", "I", AccessFlags = 25)]
				public const int TONE_CDMA_PIP = 44;
				/// <java-name>
				/// TONE_CDMA_CALL_SIGNAL_ISDN_NORMAL
				/// </java-name>
				[Dot42.DexImport("TONE_CDMA_CALL_SIGNAL_ISDN_NORMAL", "I", AccessFlags = 25)]
				public const int TONE_CDMA_CALL_SIGNAL_ISDN_NORMAL = 45;
				/// <java-name>
				/// TONE_CDMA_CALL_SIGNAL_ISDN_INTERGROUP
				/// </java-name>
				[Dot42.DexImport("TONE_CDMA_CALL_SIGNAL_ISDN_INTERGROUP", "I", AccessFlags = 25)]
				public const int TONE_CDMA_CALL_SIGNAL_ISDN_INTERGROUP = 46;
				/// <java-name>
				/// TONE_CDMA_CALL_SIGNAL_ISDN_SP_PRI
				/// </java-name>
				[Dot42.DexImport("TONE_CDMA_CALL_SIGNAL_ISDN_SP_PRI", "I", AccessFlags = 25)]
				public const int TONE_CDMA_CALL_SIGNAL_ISDN_SP_PRI = 47;
				/// <java-name>
				/// TONE_CDMA_CALL_SIGNAL_ISDN_PAT3
				/// </java-name>
				[Dot42.DexImport("TONE_CDMA_CALL_SIGNAL_ISDN_PAT3", "I", AccessFlags = 25)]
				public const int TONE_CDMA_CALL_SIGNAL_ISDN_PAT3 = 48;
				/// <java-name>
				/// TONE_CDMA_CALL_SIGNAL_ISDN_PING_RING
				/// </java-name>
				[Dot42.DexImport("TONE_CDMA_CALL_SIGNAL_ISDN_PING_RING", "I", AccessFlags = 25)]
				public const int TONE_CDMA_CALL_SIGNAL_ISDN_PING_RING = 49;
				/// <java-name>
				/// TONE_CDMA_CALL_SIGNAL_ISDN_PAT5
				/// </java-name>
				[Dot42.DexImport("TONE_CDMA_CALL_SIGNAL_ISDN_PAT5", "I", AccessFlags = 25)]
				public const int TONE_CDMA_CALL_SIGNAL_ISDN_PAT5 = 50;
				/// <java-name>
				/// TONE_CDMA_CALL_SIGNAL_ISDN_PAT6
				/// </java-name>
				[Dot42.DexImport("TONE_CDMA_CALL_SIGNAL_ISDN_PAT6", "I", AccessFlags = 25)]
				public const int TONE_CDMA_CALL_SIGNAL_ISDN_PAT6 = 51;
				/// <java-name>
				/// TONE_CDMA_CALL_SIGNAL_ISDN_PAT7
				/// </java-name>
				[Dot42.DexImport("TONE_CDMA_CALL_SIGNAL_ISDN_PAT7", "I", AccessFlags = 25)]
				public const int TONE_CDMA_CALL_SIGNAL_ISDN_PAT7 = 52;
				/// <java-name>
				/// TONE_CDMA_HIGH_L
				/// </java-name>
				[Dot42.DexImport("TONE_CDMA_HIGH_L", "I", AccessFlags = 25)]
				public const int TONE_CDMA_HIGH_L = 53;
				/// <java-name>
				/// TONE_CDMA_MED_L
				/// </java-name>
				[Dot42.DexImport("TONE_CDMA_MED_L", "I", AccessFlags = 25)]
				public const int TONE_CDMA_MED_L = 54;
				/// <java-name>
				/// TONE_CDMA_LOW_L
				/// </java-name>
				[Dot42.DexImport("TONE_CDMA_LOW_L", "I", AccessFlags = 25)]
				public const int TONE_CDMA_LOW_L = 55;
				/// <java-name>
				/// TONE_CDMA_HIGH_SS
				/// </java-name>
				[Dot42.DexImport("TONE_CDMA_HIGH_SS", "I", AccessFlags = 25)]
				public const int TONE_CDMA_HIGH_SS = 56;
				/// <java-name>
				/// TONE_CDMA_MED_SS
				/// </java-name>
				[Dot42.DexImport("TONE_CDMA_MED_SS", "I", AccessFlags = 25)]
				public const int TONE_CDMA_MED_SS = 57;
				/// <java-name>
				/// TONE_CDMA_LOW_SS
				/// </java-name>
				[Dot42.DexImport("TONE_CDMA_LOW_SS", "I", AccessFlags = 25)]
				public const int TONE_CDMA_LOW_SS = 58;
				/// <java-name>
				/// TONE_CDMA_HIGH_SSL
				/// </java-name>
				[Dot42.DexImport("TONE_CDMA_HIGH_SSL", "I", AccessFlags = 25)]
				public const int TONE_CDMA_HIGH_SSL = 59;
				/// <java-name>
				/// TONE_CDMA_MED_SSL
				/// </java-name>
				[Dot42.DexImport("TONE_CDMA_MED_SSL", "I", AccessFlags = 25)]
				public const int TONE_CDMA_MED_SSL = 60;
				/// <java-name>
				/// TONE_CDMA_LOW_SSL
				/// </java-name>
				[Dot42.DexImport("TONE_CDMA_LOW_SSL", "I", AccessFlags = 25)]
				public const int TONE_CDMA_LOW_SSL = 61;
				/// <java-name>
				/// TONE_CDMA_HIGH_SS_2
				/// </java-name>
				[Dot42.DexImport("TONE_CDMA_HIGH_SS_2", "I", AccessFlags = 25)]
				public const int TONE_CDMA_HIGH_SS_2 = 62;
				/// <java-name>
				/// TONE_CDMA_MED_SS_2
				/// </java-name>
				[Dot42.DexImport("TONE_CDMA_MED_SS_2", "I", AccessFlags = 25)]
				public const int TONE_CDMA_MED_SS_2 = 63;
				/// <java-name>
				/// TONE_CDMA_LOW_SS_2
				/// </java-name>
				[Dot42.DexImport("TONE_CDMA_LOW_SS_2", "I", AccessFlags = 25)]
				public const int TONE_CDMA_LOW_SS_2 = 64;
				/// <java-name>
				/// TONE_CDMA_HIGH_SLS
				/// </java-name>
				[Dot42.DexImport("TONE_CDMA_HIGH_SLS", "I", AccessFlags = 25)]
				public const int TONE_CDMA_HIGH_SLS = 65;
				/// <java-name>
				/// TONE_CDMA_MED_SLS
				/// </java-name>
				[Dot42.DexImport("TONE_CDMA_MED_SLS", "I", AccessFlags = 25)]
				public const int TONE_CDMA_MED_SLS = 66;
				/// <java-name>
				/// TONE_CDMA_LOW_SLS
				/// </java-name>
				[Dot42.DexImport("TONE_CDMA_LOW_SLS", "I", AccessFlags = 25)]
				public const int TONE_CDMA_LOW_SLS = 67;
				/// <java-name>
				/// TONE_CDMA_HIGH_S_X4
				/// </java-name>
				[Dot42.DexImport("TONE_CDMA_HIGH_S_X4", "I", AccessFlags = 25)]
				public const int TONE_CDMA_HIGH_S_X4 = 68;
				/// <java-name>
				/// TONE_CDMA_MED_S_X4
				/// </java-name>
				[Dot42.DexImport("TONE_CDMA_MED_S_X4", "I", AccessFlags = 25)]
				public const int TONE_CDMA_MED_S_X4 = 69;
				/// <java-name>
				/// TONE_CDMA_LOW_S_X4
				/// </java-name>
				[Dot42.DexImport("TONE_CDMA_LOW_S_X4", "I", AccessFlags = 25)]
				public const int TONE_CDMA_LOW_S_X4 = 70;
				/// <java-name>
				/// TONE_CDMA_HIGH_PBX_L
				/// </java-name>
				[Dot42.DexImport("TONE_CDMA_HIGH_PBX_L", "I", AccessFlags = 25)]
				public const int TONE_CDMA_HIGH_PBX_L = 71;
				/// <java-name>
				/// TONE_CDMA_MED_PBX_L
				/// </java-name>
				[Dot42.DexImport("TONE_CDMA_MED_PBX_L", "I", AccessFlags = 25)]
				public const int TONE_CDMA_MED_PBX_L = 72;
				/// <java-name>
				/// TONE_CDMA_LOW_PBX_L
				/// </java-name>
				[Dot42.DexImport("TONE_CDMA_LOW_PBX_L", "I", AccessFlags = 25)]
				public const int TONE_CDMA_LOW_PBX_L = 73;
				/// <java-name>
				/// TONE_CDMA_HIGH_PBX_SS
				/// </java-name>
				[Dot42.DexImport("TONE_CDMA_HIGH_PBX_SS", "I", AccessFlags = 25)]
				public const int TONE_CDMA_HIGH_PBX_SS = 74;
				/// <java-name>
				/// TONE_CDMA_MED_PBX_SS
				/// </java-name>
				[Dot42.DexImport("TONE_CDMA_MED_PBX_SS", "I", AccessFlags = 25)]
				public const int TONE_CDMA_MED_PBX_SS = 75;
				/// <java-name>
				/// TONE_CDMA_LOW_PBX_SS
				/// </java-name>
				[Dot42.DexImport("TONE_CDMA_LOW_PBX_SS", "I", AccessFlags = 25)]
				public const int TONE_CDMA_LOW_PBX_SS = 76;
				/// <java-name>
				/// TONE_CDMA_HIGH_PBX_SSL
				/// </java-name>
				[Dot42.DexImport("TONE_CDMA_HIGH_PBX_SSL", "I", AccessFlags = 25)]
				public const int TONE_CDMA_HIGH_PBX_SSL = 77;
				/// <java-name>
				/// TONE_CDMA_MED_PBX_SSL
				/// </java-name>
				[Dot42.DexImport("TONE_CDMA_MED_PBX_SSL", "I", AccessFlags = 25)]
				public const int TONE_CDMA_MED_PBX_SSL = 78;
				/// <java-name>
				/// TONE_CDMA_LOW_PBX_SSL
				/// </java-name>
				[Dot42.DexImport("TONE_CDMA_LOW_PBX_SSL", "I", AccessFlags = 25)]
				public const int TONE_CDMA_LOW_PBX_SSL = 79;
				/// <java-name>
				/// TONE_CDMA_HIGH_PBX_SLS
				/// </java-name>
				[Dot42.DexImport("TONE_CDMA_HIGH_PBX_SLS", "I", AccessFlags = 25)]
				public const int TONE_CDMA_HIGH_PBX_SLS = 80;
				/// <java-name>
				/// TONE_CDMA_MED_PBX_SLS
				/// </java-name>
				[Dot42.DexImport("TONE_CDMA_MED_PBX_SLS", "I", AccessFlags = 25)]
				public const int TONE_CDMA_MED_PBX_SLS = 81;
				/// <java-name>
				/// TONE_CDMA_LOW_PBX_SLS
				/// </java-name>
				[Dot42.DexImport("TONE_CDMA_LOW_PBX_SLS", "I", AccessFlags = 25)]
				public const int TONE_CDMA_LOW_PBX_SLS = 82;
				/// <java-name>
				/// TONE_CDMA_HIGH_PBX_S_X4
				/// </java-name>
				[Dot42.DexImport("TONE_CDMA_HIGH_PBX_S_X4", "I", AccessFlags = 25)]
				public const int TONE_CDMA_HIGH_PBX_S_X4 = 83;
				/// <java-name>
				/// TONE_CDMA_MED_PBX_S_X4
				/// </java-name>
				[Dot42.DexImport("TONE_CDMA_MED_PBX_S_X4", "I", AccessFlags = 25)]
				public const int TONE_CDMA_MED_PBX_S_X4 = 84;
				/// <java-name>
				/// TONE_CDMA_LOW_PBX_S_X4
				/// </java-name>
				[Dot42.DexImport("TONE_CDMA_LOW_PBX_S_X4", "I", AccessFlags = 25)]
				public const int TONE_CDMA_LOW_PBX_S_X4 = 85;
				/// <java-name>
				/// TONE_CDMA_ALERT_NETWORK_LITE
				/// </java-name>
				[Dot42.DexImport("TONE_CDMA_ALERT_NETWORK_LITE", "I", AccessFlags = 25)]
				public const int TONE_CDMA_ALERT_NETWORK_LITE = 86;
				/// <java-name>
				/// TONE_CDMA_ALERT_AUTOREDIAL_LITE
				/// </java-name>
				[Dot42.DexImport("TONE_CDMA_ALERT_AUTOREDIAL_LITE", "I", AccessFlags = 25)]
				public const int TONE_CDMA_ALERT_AUTOREDIAL_LITE = 87;
				/// <java-name>
				/// TONE_CDMA_ONE_MIN_BEEP
				/// </java-name>
				[Dot42.DexImport("TONE_CDMA_ONE_MIN_BEEP", "I", AccessFlags = 25)]
				public const int TONE_CDMA_ONE_MIN_BEEP = 88;
				/// <java-name>
				/// TONE_CDMA_KEYPAD_VOLUME_KEY_LITE
				/// </java-name>
				[Dot42.DexImport("TONE_CDMA_KEYPAD_VOLUME_KEY_LITE", "I", AccessFlags = 25)]
				public const int TONE_CDMA_KEYPAD_VOLUME_KEY_LITE = 89;
				/// <java-name>
				/// TONE_CDMA_PRESSHOLDKEY_LITE
				/// </java-name>
				[Dot42.DexImport("TONE_CDMA_PRESSHOLDKEY_LITE", "I", AccessFlags = 25)]
				public const int TONE_CDMA_PRESSHOLDKEY_LITE = 90;
				/// <java-name>
				/// TONE_CDMA_ALERT_INCALL_LITE
				/// </java-name>
				[Dot42.DexImport("TONE_CDMA_ALERT_INCALL_LITE", "I", AccessFlags = 25)]
				public const int TONE_CDMA_ALERT_INCALL_LITE = 91;
				/// <java-name>
				/// TONE_CDMA_EMERGENCY_RINGBACK
				/// </java-name>
				[Dot42.DexImport("TONE_CDMA_EMERGENCY_RINGBACK", "I", AccessFlags = 25)]
				public const int TONE_CDMA_EMERGENCY_RINGBACK = 92;
				/// <java-name>
				/// TONE_CDMA_ALERT_CALL_GUARD
				/// </java-name>
				[Dot42.DexImport("TONE_CDMA_ALERT_CALL_GUARD", "I", AccessFlags = 25)]
				public const int TONE_CDMA_ALERT_CALL_GUARD = 93;
				/// <java-name>
				/// TONE_CDMA_SOFT_ERROR_LITE
				/// </java-name>
				[Dot42.DexImport("TONE_CDMA_SOFT_ERROR_LITE", "I", AccessFlags = 25)]
				public const int TONE_CDMA_SOFT_ERROR_LITE = 94;
				/// <java-name>
				/// TONE_CDMA_CALLDROP_LITE
				/// </java-name>
				[Dot42.DexImport("TONE_CDMA_CALLDROP_LITE", "I", AccessFlags = 25)]
				public const int TONE_CDMA_CALLDROP_LITE = 95;
				/// <java-name>
				/// TONE_CDMA_NETWORK_BUSY_ONE_SHOT
				/// </java-name>
				[Dot42.DexImport("TONE_CDMA_NETWORK_BUSY_ONE_SHOT", "I", AccessFlags = 25)]
				public const int TONE_CDMA_NETWORK_BUSY_ONE_SHOT = 96;
				/// <java-name>
				/// TONE_CDMA_ABBR_ALERT
				/// </java-name>
				[Dot42.DexImport("TONE_CDMA_ABBR_ALERT", "I", AccessFlags = 25)]
				public const int TONE_CDMA_ABBR_ALERT = 97;
				/// <java-name>
				/// TONE_CDMA_SIGNAL_OFF
				/// </java-name>
				[Dot42.DexImport("TONE_CDMA_SIGNAL_OFF", "I", AccessFlags = 25)]
				public const int TONE_CDMA_SIGNAL_OFF = 98;
				/// <java-name>
				/// MAX_VOLUME
				/// </java-name>
				[Dot42.DexImport("MAX_VOLUME", "I", AccessFlags = 25)]
				public const int MAX_VOLUME = 100;
				/// <java-name>
				/// MIN_VOLUME
				/// </java-name>
				[Dot42.DexImport("MIN_VOLUME", "I", AccessFlags = 25)]
				public const int MIN_VOLUME = 0;
				[Dot42.DexImport("<init>", "(II)V", AccessFlags = 1)]
				public ToneGenerator(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// startTone
				/// </java-name>
				[Dot42.DexImport("startTone", "(I)Z", AccessFlags = 1)]
				public virtual bool StartTone(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// startTone
				/// </java-name>
				[Dot42.DexImport("startTone", "(II)Z", AccessFlags = 257)]
				public virtual bool StartTone(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// stopTone
				/// </java-name>
				[Dot42.DexImport("stopTone", "()V", AccessFlags = 257)]
				public virtual void StopTone() /* MethodBuilder.Create */ 
				{
				}

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
				internal ToneGenerator() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

}

