#pragma warning disable 1717
namespace Android.Media.Audiofx
{
		/// <java-name>
		/// android/media/audiofx/AudioEffect
		/// </java-name>
		[Dot42.DexImport("android/media/audiofx/AudioEffect", AccessFlags = 33)]
		public partial class AudioEffect
 /* scope: __dot42__ */ 
		{
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
				/// ALREADY_EXISTS
				/// </java-name>
				[Dot42.DexImport("ALREADY_EXISTS", "I", AccessFlags = 25)]
				public const int ALREADY_EXISTS = -2;
				/// <java-name>
				/// ERROR_NO_INIT
				/// </java-name>
				[Dot42.DexImport("ERROR_NO_INIT", "I", AccessFlags = 25)]
				public const int ERROR_NO_INIT = -3;
				/// <java-name>
				/// ERROR_BAD_VALUE
				/// </java-name>
				[Dot42.DexImport("ERROR_BAD_VALUE", "I", AccessFlags = 25)]
				public const int ERROR_BAD_VALUE = -4;
				/// <java-name>
				/// ERROR_INVALID_OPERATION
				/// </java-name>
				[Dot42.DexImport("ERROR_INVALID_OPERATION", "I", AccessFlags = 25)]
				public const int ERROR_INVALID_OPERATION = -5;
				/// <java-name>
				/// ERROR_NO_MEMORY
				/// </java-name>
				[Dot42.DexImport("ERROR_NO_MEMORY", "I", AccessFlags = 25)]
				public const int ERROR_NO_MEMORY = -6;
				/// <java-name>
				/// ERROR_DEAD_OBJECT
				/// </java-name>
				[Dot42.DexImport("ERROR_DEAD_OBJECT", "I", AccessFlags = 25)]
				public const int ERROR_DEAD_OBJECT = -7;
				/// <java-name>
				/// EFFECT_INSERT
				/// </java-name>
				[Dot42.DexImport("EFFECT_INSERT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EFFECT_INSERT = "Insert";
				/// <java-name>
				/// EFFECT_AUXILIARY
				/// </java-name>
				[Dot42.DexImport("EFFECT_AUXILIARY", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EFFECT_AUXILIARY = "Auxiliary";
				/// <java-name>
				/// ACTION_DISPLAY_AUDIO_EFFECT_CONTROL_PANEL
				/// </java-name>
				[Dot42.DexImport("ACTION_DISPLAY_AUDIO_EFFECT_CONTROL_PANEL", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_DISPLAY_AUDIO_EFFECT_CONTROL_PANEL = "android.media.action.DISPLAY_AUDIO_EFFECT_CONTROL_PANEL";
				/// <java-name>
				/// ACTION_OPEN_AUDIO_EFFECT_CONTROL_SESSION
				/// </java-name>
				[Dot42.DexImport("ACTION_OPEN_AUDIO_EFFECT_CONTROL_SESSION", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_OPEN_AUDIO_EFFECT_CONTROL_SESSION = "android.media.action.OPEN_AUDIO_EFFECT_CONTROL_SESSION";
				/// <java-name>
				/// ACTION_CLOSE_AUDIO_EFFECT_CONTROL_SESSION
				/// </java-name>
				[Dot42.DexImport("ACTION_CLOSE_AUDIO_EFFECT_CONTROL_SESSION", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_CLOSE_AUDIO_EFFECT_CONTROL_SESSION = "android.media.action.CLOSE_AUDIO_EFFECT_CONTROL_SESSION";
				/// <java-name>
				/// EXTRA_AUDIO_SESSION
				/// </java-name>
				[Dot42.DexImport("EXTRA_AUDIO_SESSION", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_AUDIO_SESSION = "android.media.extra.AUDIO_SESSION";
				/// <java-name>
				/// EXTRA_PACKAGE_NAME
				/// </java-name>
				[Dot42.DexImport("EXTRA_PACKAGE_NAME", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_PACKAGE_NAME = "android.media.extra.PACKAGE_NAME";
				/// <java-name>
				/// EXTRA_CONTENT_TYPE
				/// </java-name>
				[Dot42.DexImport("EXTRA_CONTENT_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_CONTENT_TYPE = "android.media.extra.CONTENT_TYPE";
				/// <java-name>
				/// CONTENT_TYPE_MUSIC
				/// </java-name>
				[Dot42.DexImport("CONTENT_TYPE_MUSIC", "I", AccessFlags = 25)]
				public const int CONTENT_TYPE_MUSIC = 0;
				/// <java-name>
				/// CONTENT_TYPE_MOVIE
				/// </java-name>
				[Dot42.DexImport("CONTENT_TYPE_MOVIE", "I", AccessFlags = 25)]
				public const int CONTENT_TYPE_MOVIE = 1;
				/// <java-name>
				/// CONTENT_TYPE_GAME
				/// </java-name>
				[Dot42.DexImport("CONTENT_TYPE_GAME", "I", AccessFlags = 25)]
				public const int CONTENT_TYPE_GAME = 2;
				/// <java-name>
				/// CONTENT_TYPE_VOICE
				/// </java-name>
				[Dot42.DexImport("CONTENT_TYPE_VOICE", "I", AccessFlags = 25)]
				public const int CONTENT_TYPE_VOICE = 3;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal AudioEffect() /* MethodBuilder.Create */ 
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
				extern ~AudioEffect() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getDescriptor
				/// </java-name>
				[Dot42.DexImport("getDescriptor", "()Landroid/media/audiofx/AudioEffect$Descriptor;", AccessFlags = 1)]
				public virtual global::Android.Media.Audiofx.AudioEffect.Descriptor GetDescriptor() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Media.Audiofx.AudioEffect.Descriptor);
				}

				/// <java-name>
				/// queryEffects
				/// </java-name>
				[Dot42.DexImport("queryEffects", "()[Landroid/media/audiofx/AudioEffect$Descriptor;", AccessFlags = 9)]
				public static global::Android.Media.Audiofx.AudioEffect.Descriptor[] QueryEffects() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Media.Audiofx.AudioEffect.Descriptor[]);
				}

				/// <java-name>
				/// setEnabled
				/// </java-name>
				[Dot42.DexImport("setEnabled", "(Z)I", AccessFlags = 1)]
				public virtual int SetEnabled(bool boolean) /* MethodBuilder.Create */ 
				{
						return default(int);
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
				/// getEnabled
				/// </java-name>
				[Dot42.DexImport("getEnabled", "()Z", AccessFlags = 1)]
				public virtual bool GetEnabled() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// hasControl
				/// </java-name>
				[Dot42.DexImport("hasControl", "()Z", AccessFlags = 1)]
				public virtual bool HasControl() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setEnableStatusListener
				/// </java-name>
				[Dot42.DexImport("setEnableStatusListener", "(Landroid/media/audiofx/AudioEffect$OnEnableStatusChangeListener;)V", AccessFlags = 1)]
				public virtual void SetEnableStatusListener(global::Android.Media.Audiofx.AudioEffect.IOnEnableStatusChangeListener onEnableStatusChangeListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setControlStatusListener
				/// </java-name>
				[Dot42.DexImport("setControlStatusListener", "(Landroid/media/audiofx/AudioEffect$OnControlStatusChangeListener;)V", AccessFlags = 1)]
				public virtual void SetControlStatusListener(global::Android.Media.Audiofx.AudioEffect.IOnControlStatusChangeListener onControlStatusChangeListener) /* MethodBuilder.Create */ 
				{
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
				/// getEnabled
				/// </java-name>
				public bool IsEnabled
				{
				[Dot42.DexImport("getEnabled", "()Z", AccessFlags = 1)]
						get{ return GetEnabled(); }
				}

				/// <java-name>
				/// android/media/audiofx/AudioEffect$OnControlStatusChangeListener
				/// </java-name>
				[Dot42.DexImport("android/media/audiofx/AudioEffect$OnControlStatusChangeListener", AccessFlags = 1545)]
				public partial interface IOnControlStatusChangeListener
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onControlStatusChange
						/// </java-name>
						[Dot42.DexImport("onControlStatusChange", "(Landroid/media/audiofx/AudioEffect;Z)V", AccessFlags = 1025)]
						void OnControlStatusChange(global::Android.Media.Audiofx.AudioEffect audioEffect, bool boolean) /* MethodBuilder.Create */ ;

				}

				/// <java-name>
				/// android/media/audiofx/AudioEffect$OnEnableStatusChangeListener
				/// </java-name>
				[Dot42.DexImport("android/media/audiofx/AudioEffect$OnEnableStatusChangeListener", AccessFlags = 1545)]
				public partial interface IOnEnableStatusChangeListener
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onEnableStatusChange
						/// </java-name>
						[Dot42.DexImport("onEnableStatusChange", "(Landroid/media/audiofx/AudioEffect;Z)V", AccessFlags = 1025)]
						void OnEnableStatusChange(global::Android.Media.Audiofx.AudioEffect audioEffect, bool boolean) /* MethodBuilder.Create */ ;

				}

				/// <java-name>
				/// android/media/audiofx/AudioEffect$Descriptor
				/// </java-name>
				[Dot42.DexImport("android/media/audiofx/AudioEffect$Descriptor", AccessFlags = 9)]
				public partial class Descriptor
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// type
						/// </java-name>
						[Dot42.DexImport("type", "Ljava/util/UUID;", AccessFlags = 1)]
						public global::Java.Util.UUID Type;
						/// <java-name>
						/// uuid
						/// </java-name>
						[Dot42.DexImport("uuid", "Ljava/util/UUID;", AccessFlags = 1)]
						public global::Java.Util.UUID Uuid;
						/// <java-name>
						/// connectMode
						/// </java-name>
						[Dot42.DexImport("connectMode", "Ljava/lang/String;", AccessFlags = 1)]
						public string ConnectMode;
						/// <java-name>
						/// name
						/// </java-name>
						[Dot42.DexImport("name", "Ljava/lang/String;", AccessFlags = 1)]
						public string Name;
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

		/// <java-name>
		/// android/media/audiofx/BassBoost
		/// </java-name>
		[Dot42.DexImport("android/media/audiofx/BassBoost", AccessFlags = 33)]
		public partial class BassBoost : global::Android.Media.Audiofx.AudioEffect
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// PARAM_STRENGTH_SUPPORTED
				/// </java-name>
				[Dot42.DexImport("PARAM_STRENGTH_SUPPORTED", "I", AccessFlags = 25)]
				public const int PARAM_STRENGTH_SUPPORTED = 0;
				/// <java-name>
				/// PARAM_STRENGTH
				/// </java-name>
				[Dot42.DexImport("PARAM_STRENGTH", "I", AccessFlags = 25)]
				public const int PARAM_STRENGTH = 1;
				[Dot42.DexImport("<init>", "(II)V", AccessFlags = 1)]
				public BassBoost(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getStrengthSupported
				/// </java-name>
				[Dot42.DexImport("getStrengthSupported", "()Z", AccessFlags = 1)]
				public virtual bool GetStrengthSupported() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setStrength
				/// </java-name>
				[Dot42.DexImport("setStrength", "(S)V", AccessFlags = 1)]
				public virtual void SetStrength(short int16) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getRoundedStrength
				/// </java-name>
				[Dot42.DexImport("getRoundedStrength", "()S", AccessFlags = 1)]
				public virtual short GetRoundedStrength() /* MethodBuilder.Create */ 
				{
						return default(short);
				}

				/// <java-name>
				/// setParameterListener
				/// </java-name>
				[Dot42.DexImport("setParameterListener", "(Landroid/media/audiofx/BassBoost$OnParameterChangeListener;)V", AccessFlags = 1)]
				public virtual void SetParameterListener(global::Android.Media.Audiofx.BassBoost.IOnParameterChangeListener onParameterChangeListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getProperties
				/// </java-name>
				[Dot42.DexImport("getProperties", "()Landroid/media/audiofx/BassBoost$Settings;", AccessFlags = 1)]
				public virtual global::Android.Media.Audiofx.BassBoost.Settings GetProperties() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Media.Audiofx.BassBoost.Settings);
				}

				/// <java-name>
				/// setProperties
				/// </java-name>
				[Dot42.DexImport("setProperties", "(Landroid/media/audiofx/BassBoost$Settings;)V", AccessFlags = 1)]
				public virtual void SetProperties(global::Android.Media.Audiofx.BassBoost.Settings settings) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal BassBoost() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getStrengthSupported
				/// </java-name>
				public bool IsStrengthSupported
				{
				[Dot42.DexImport("getStrengthSupported", "()Z", AccessFlags = 1)]
						get{ return GetStrengthSupported(); }
				}

				/// <java-name>
				/// getRoundedStrength
				/// </java-name>
				public short RoundedStrength
				{
				[Dot42.DexImport("getRoundedStrength", "()S", AccessFlags = 1)]
						get{ return GetRoundedStrength(); }
				}

				/// <java-name>
				/// getProperties
				/// </java-name>
				public global::Android.Media.Audiofx.BassBoost.Settings Properties
				{
				[Dot42.DexImport("getProperties", "()Landroid/media/audiofx/BassBoost$Settings;", AccessFlags = 1)]
						get{ return GetProperties(); }
				[Dot42.DexImport("setProperties", "(Landroid/media/audiofx/BassBoost$Settings;)V", AccessFlags = 1)]
						set{ SetProperties(value); }
				}

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

				/// <java-name>
				/// android/media/audiofx/BassBoost$OnParameterChangeListener
				/// </java-name>
				[Dot42.DexImport("android/media/audiofx/BassBoost$OnParameterChangeListener", AccessFlags = 1545)]
				public partial interface IOnParameterChangeListener
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onParameterChange
						/// </java-name>
						[Dot42.DexImport("onParameterChange", "(Landroid/media/audiofx/BassBoost;IIS)V", AccessFlags = 1025)]
						void OnParameterChange(global::Android.Media.Audiofx.BassBoost bassBoost, int int32, int int321, short int16) /* MethodBuilder.Create */ ;

				}

		}

		/// <java-name>
		/// android/media/audiofx/EnvironmentalReverb
		/// </java-name>
		[Dot42.DexImport("android/media/audiofx/EnvironmentalReverb", AccessFlags = 33)]
		public partial class EnvironmentalReverb : global::Android.Media.Audiofx.AudioEffect
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// PARAM_ROOM_LEVEL
				/// </java-name>
				[Dot42.DexImport("PARAM_ROOM_LEVEL", "I", AccessFlags = 25)]
				public const int PARAM_ROOM_LEVEL = 0;
				/// <java-name>
				/// PARAM_ROOM_HF_LEVEL
				/// </java-name>
				[Dot42.DexImport("PARAM_ROOM_HF_LEVEL", "I", AccessFlags = 25)]
				public const int PARAM_ROOM_HF_LEVEL = 1;
				/// <java-name>
				/// PARAM_DECAY_TIME
				/// </java-name>
				[Dot42.DexImport("PARAM_DECAY_TIME", "I", AccessFlags = 25)]
				public const int PARAM_DECAY_TIME = 2;
				/// <java-name>
				/// PARAM_DECAY_HF_RATIO
				/// </java-name>
				[Dot42.DexImport("PARAM_DECAY_HF_RATIO", "I", AccessFlags = 25)]
				public const int PARAM_DECAY_HF_RATIO = 3;
				/// <java-name>
				/// PARAM_REFLECTIONS_LEVEL
				/// </java-name>
				[Dot42.DexImport("PARAM_REFLECTIONS_LEVEL", "I", AccessFlags = 25)]
				public const int PARAM_REFLECTIONS_LEVEL = 4;
				/// <java-name>
				/// PARAM_REFLECTIONS_DELAY
				/// </java-name>
				[Dot42.DexImport("PARAM_REFLECTIONS_DELAY", "I", AccessFlags = 25)]
				public const int PARAM_REFLECTIONS_DELAY = 5;
				/// <java-name>
				/// PARAM_REVERB_LEVEL
				/// </java-name>
				[Dot42.DexImport("PARAM_REVERB_LEVEL", "I", AccessFlags = 25)]
				public const int PARAM_REVERB_LEVEL = 6;
				/// <java-name>
				/// PARAM_REVERB_DELAY
				/// </java-name>
				[Dot42.DexImport("PARAM_REVERB_DELAY", "I", AccessFlags = 25)]
				public const int PARAM_REVERB_DELAY = 7;
				/// <java-name>
				/// PARAM_DIFFUSION
				/// </java-name>
				[Dot42.DexImport("PARAM_DIFFUSION", "I", AccessFlags = 25)]
				public const int PARAM_DIFFUSION = 8;
				/// <java-name>
				/// PARAM_DENSITY
				/// </java-name>
				[Dot42.DexImport("PARAM_DENSITY", "I", AccessFlags = 25)]
				public const int PARAM_DENSITY = 9;
				[Dot42.DexImport("<init>", "(II)V", AccessFlags = 1)]
				public EnvironmentalReverb(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setRoomLevel
				/// </java-name>
				[Dot42.DexImport("setRoomLevel", "(S)V", AccessFlags = 1)]
				public virtual void SetRoomLevel(short int16) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getRoomLevel
				/// </java-name>
				[Dot42.DexImport("getRoomLevel", "()S", AccessFlags = 1)]
				public virtual short GetRoomLevel() /* MethodBuilder.Create */ 
				{
						return default(short);
				}

				/// <java-name>
				/// setRoomHFLevel
				/// </java-name>
				[Dot42.DexImport("setRoomHFLevel", "(S)V", AccessFlags = 1)]
				public virtual void SetRoomHFLevel(short int16) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getRoomHFLevel
				/// </java-name>
				[Dot42.DexImport("getRoomHFLevel", "()S", AccessFlags = 1)]
				public virtual short GetRoomHFLevel() /* MethodBuilder.Create */ 
				{
						return default(short);
				}

				/// <java-name>
				/// setDecayTime
				/// </java-name>
				[Dot42.DexImport("setDecayTime", "(I)V", AccessFlags = 1)]
				public virtual void SetDecayTime(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getDecayTime
				/// </java-name>
				[Dot42.DexImport("getDecayTime", "()I", AccessFlags = 1)]
				public virtual int GetDecayTime() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// setDecayHFRatio
				/// </java-name>
				[Dot42.DexImport("setDecayHFRatio", "(S)V", AccessFlags = 1)]
				public virtual void SetDecayHFRatio(short int16) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getDecayHFRatio
				/// </java-name>
				[Dot42.DexImport("getDecayHFRatio", "()S", AccessFlags = 1)]
				public virtual short GetDecayHFRatio() /* MethodBuilder.Create */ 
				{
						return default(short);
				}

				/// <java-name>
				/// setReflectionsLevel
				/// </java-name>
				[Dot42.DexImport("setReflectionsLevel", "(S)V", AccessFlags = 1)]
				public virtual void SetReflectionsLevel(short int16) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getReflectionsLevel
				/// </java-name>
				[Dot42.DexImport("getReflectionsLevel", "()S", AccessFlags = 1)]
				public virtual short GetReflectionsLevel() /* MethodBuilder.Create */ 
				{
						return default(short);
				}

				/// <java-name>
				/// setReflectionsDelay
				/// </java-name>
				[Dot42.DexImport("setReflectionsDelay", "(I)V", AccessFlags = 1)]
				public virtual void SetReflectionsDelay(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getReflectionsDelay
				/// </java-name>
				[Dot42.DexImport("getReflectionsDelay", "()I", AccessFlags = 1)]
				public virtual int GetReflectionsDelay() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// setReverbLevel
				/// </java-name>
				[Dot42.DexImport("setReverbLevel", "(S)V", AccessFlags = 1)]
				public virtual void SetReverbLevel(short int16) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getReverbLevel
				/// </java-name>
				[Dot42.DexImport("getReverbLevel", "()S", AccessFlags = 1)]
				public virtual short GetReverbLevel() /* MethodBuilder.Create */ 
				{
						return default(short);
				}

				/// <java-name>
				/// setReverbDelay
				/// </java-name>
				[Dot42.DexImport("setReverbDelay", "(I)V", AccessFlags = 1)]
				public virtual void SetReverbDelay(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getReverbDelay
				/// </java-name>
				[Dot42.DexImport("getReverbDelay", "()I", AccessFlags = 1)]
				public virtual int GetReverbDelay() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// setDiffusion
				/// </java-name>
				[Dot42.DexImport("setDiffusion", "(S)V", AccessFlags = 1)]
				public virtual void SetDiffusion(short int16) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getDiffusion
				/// </java-name>
				[Dot42.DexImport("getDiffusion", "()S", AccessFlags = 1)]
				public virtual short GetDiffusion() /* MethodBuilder.Create */ 
				{
						return default(short);
				}

				/// <java-name>
				/// setDensity
				/// </java-name>
				[Dot42.DexImport("setDensity", "(S)V", AccessFlags = 1)]
				public virtual void SetDensity(short int16) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getDensity
				/// </java-name>
				[Dot42.DexImport("getDensity", "()S", AccessFlags = 1)]
				public virtual short GetDensity() /* MethodBuilder.Create */ 
				{
						return default(short);
				}

				/// <java-name>
				/// setParameterListener
				/// </java-name>
				[Dot42.DexImport("setParameterListener", "(Landroid/media/audiofx/EnvironmentalReverb$OnParameterChangeListener;)V", AccessFlags = 1)]
				public virtual void SetParameterListener(global::Android.Media.Audiofx.EnvironmentalReverb.IOnParameterChangeListener onParameterChangeListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getProperties
				/// </java-name>
				[Dot42.DexImport("getProperties", "()Landroid/media/audiofx/EnvironmentalReverb$Settings;", AccessFlags = 1)]
				public virtual global::Android.Media.Audiofx.EnvironmentalReverb.Settings GetProperties() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Media.Audiofx.EnvironmentalReverb.Settings);
				}

				/// <java-name>
				/// setProperties
				/// </java-name>
				[Dot42.DexImport("setProperties", "(Landroid/media/audiofx/EnvironmentalReverb$Settings;)V", AccessFlags = 1)]
				public virtual void SetProperties(global::Android.Media.Audiofx.EnvironmentalReverb.Settings settings) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal EnvironmentalReverb() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getRoomLevel
				/// </java-name>
				public short RoomLevel
				{
				[Dot42.DexImport("getRoomLevel", "()S", AccessFlags = 1)]
						get{ return GetRoomLevel(); }
				[Dot42.DexImport("setRoomLevel", "(S)V", AccessFlags = 1)]
						set{ SetRoomLevel(value); }
				}

				/// <java-name>
				/// getRoomHFLevel
				/// </java-name>
				public short RoomHFLevel
				{
				[Dot42.DexImport("getRoomHFLevel", "()S", AccessFlags = 1)]
						get{ return GetRoomHFLevel(); }
				[Dot42.DexImport("setRoomHFLevel", "(S)V", AccessFlags = 1)]
						set{ SetRoomHFLevel(value); }
				}

				/// <java-name>
				/// getDecayTime
				/// </java-name>
				public int DecayTime
				{
				[Dot42.DexImport("getDecayTime", "()I", AccessFlags = 1)]
						get{ return GetDecayTime(); }
				[Dot42.DexImport("setDecayTime", "(I)V", AccessFlags = 1)]
						set{ SetDecayTime(value); }
				}

				/// <java-name>
				/// getDecayHFRatio
				/// </java-name>
				public short DecayHFRatio
				{
				[Dot42.DexImport("getDecayHFRatio", "()S", AccessFlags = 1)]
						get{ return GetDecayHFRatio(); }
				[Dot42.DexImport("setDecayHFRatio", "(S)V", AccessFlags = 1)]
						set{ SetDecayHFRatio(value); }
				}

				/// <java-name>
				/// getReflectionsLevel
				/// </java-name>
				public short ReflectionsLevel
				{
				[Dot42.DexImport("getReflectionsLevel", "()S", AccessFlags = 1)]
						get{ return GetReflectionsLevel(); }
				[Dot42.DexImport("setReflectionsLevel", "(S)V", AccessFlags = 1)]
						set{ SetReflectionsLevel(value); }
				}

				/// <java-name>
				/// getReflectionsDelay
				/// </java-name>
				public int ReflectionsDelay
				{
				[Dot42.DexImport("getReflectionsDelay", "()I", AccessFlags = 1)]
						get{ return GetReflectionsDelay(); }
				[Dot42.DexImport("setReflectionsDelay", "(I)V", AccessFlags = 1)]
						set{ SetReflectionsDelay(value); }
				}

				/// <java-name>
				/// getReverbLevel
				/// </java-name>
				public short ReverbLevel
				{
				[Dot42.DexImport("getReverbLevel", "()S", AccessFlags = 1)]
						get{ return GetReverbLevel(); }
				[Dot42.DexImport("setReverbLevel", "(S)V", AccessFlags = 1)]
						set{ SetReverbLevel(value); }
				}

				/// <java-name>
				/// getReverbDelay
				/// </java-name>
				public int ReverbDelay
				{
				[Dot42.DexImport("getReverbDelay", "()I", AccessFlags = 1)]
						get{ return GetReverbDelay(); }
				[Dot42.DexImport("setReverbDelay", "(I)V", AccessFlags = 1)]
						set{ SetReverbDelay(value); }
				}

				/// <java-name>
				/// getDiffusion
				/// </java-name>
				public short Diffusion
				{
				[Dot42.DexImport("getDiffusion", "()S", AccessFlags = 1)]
						get{ return GetDiffusion(); }
				[Dot42.DexImport("setDiffusion", "(S)V", AccessFlags = 1)]
						set{ SetDiffusion(value); }
				}

				/// <java-name>
				/// getDensity
				/// </java-name>
				public short Density
				{
				[Dot42.DexImport("getDensity", "()S", AccessFlags = 1)]
						get{ return GetDensity(); }
				[Dot42.DexImport("setDensity", "(S)V", AccessFlags = 1)]
						set{ SetDensity(value); }
				}

				/// <java-name>
				/// getProperties
				/// </java-name>
				public global::Android.Media.Audiofx.EnvironmentalReverb.Settings Properties
				{
				[Dot42.DexImport("getProperties", "()Landroid/media/audiofx/EnvironmentalReverb$Settings;", AccessFlags = 1)]
						get{ return GetProperties(); }
				[Dot42.DexImport("setProperties", "(Landroid/media/audiofx/EnvironmentalReverb$Settings;)V", AccessFlags = 1)]
						set{ SetProperties(value); }
				}

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

				/// <java-name>
				/// android/media/audiofx/EnvironmentalReverb$OnParameterChangeListener
				/// </java-name>
				[Dot42.DexImport("android/media/audiofx/EnvironmentalReverb$OnParameterChangeListener", AccessFlags = 1545)]
				public partial interface IOnParameterChangeListener
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onParameterChange
						/// </java-name>
						[Dot42.DexImport("onParameterChange", "(Landroid/media/audiofx/EnvironmentalReverb;III)V", AccessFlags = 1025)]
						void OnParameterChange(global::Android.Media.Audiofx.EnvironmentalReverb environmentalReverb, int int32, int int321, int int322) /* MethodBuilder.Create */ ;

				}

		}

		/// <java-name>
		/// android/media/audiofx/Equalizer
		/// </java-name>
		[Dot42.DexImport("android/media/audiofx/Equalizer", AccessFlags = 33)]
		public partial class Equalizer : global::Android.Media.Audiofx.AudioEffect
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// PARAM_NUM_BANDS
				/// </java-name>
				[Dot42.DexImport("PARAM_NUM_BANDS", "I", AccessFlags = 25)]
				public const int PARAM_NUM_BANDS = 0;
				/// <java-name>
				/// PARAM_LEVEL_RANGE
				/// </java-name>
				[Dot42.DexImport("PARAM_LEVEL_RANGE", "I", AccessFlags = 25)]
				public const int PARAM_LEVEL_RANGE = 1;
				/// <java-name>
				/// PARAM_BAND_LEVEL
				/// </java-name>
				[Dot42.DexImport("PARAM_BAND_LEVEL", "I", AccessFlags = 25)]
				public const int PARAM_BAND_LEVEL = 2;
				/// <java-name>
				/// PARAM_CENTER_FREQ
				/// </java-name>
				[Dot42.DexImport("PARAM_CENTER_FREQ", "I", AccessFlags = 25)]
				public const int PARAM_CENTER_FREQ = 3;
				/// <java-name>
				/// PARAM_BAND_FREQ_RANGE
				/// </java-name>
				[Dot42.DexImport("PARAM_BAND_FREQ_RANGE", "I", AccessFlags = 25)]
				public const int PARAM_BAND_FREQ_RANGE = 4;
				/// <java-name>
				/// PARAM_GET_BAND
				/// </java-name>
				[Dot42.DexImport("PARAM_GET_BAND", "I", AccessFlags = 25)]
				public const int PARAM_GET_BAND = 5;
				/// <java-name>
				/// PARAM_CURRENT_PRESET
				/// </java-name>
				[Dot42.DexImport("PARAM_CURRENT_PRESET", "I", AccessFlags = 25)]
				public const int PARAM_CURRENT_PRESET = 6;
				/// <java-name>
				/// PARAM_GET_NUM_OF_PRESETS
				/// </java-name>
				[Dot42.DexImport("PARAM_GET_NUM_OF_PRESETS", "I", AccessFlags = 25)]
				public const int PARAM_GET_NUM_OF_PRESETS = 7;
				/// <java-name>
				/// PARAM_GET_PRESET_NAME
				/// </java-name>
				[Dot42.DexImport("PARAM_GET_PRESET_NAME", "I", AccessFlags = 25)]
				public const int PARAM_GET_PRESET_NAME = 8;
				/// <java-name>
				/// PARAM_STRING_SIZE_MAX
				/// </java-name>
				[Dot42.DexImport("PARAM_STRING_SIZE_MAX", "I", AccessFlags = 25)]
				public const int PARAM_STRING_SIZE_MAX = 32;
				[Dot42.DexImport("<init>", "(II)V", AccessFlags = 1)]
				public Equalizer(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getNumberOfBands
				/// </java-name>
				[Dot42.DexImport("getNumberOfBands", "()S", AccessFlags = 1)]
				public virtual short GetNumberOfBands() /* MethodBuilder.Create */ 
				{
						return default(short);
				}

				/// <java-name>
				/// getBandLevelRange
				/// </java-name>
				[Dot42.DexImport("getBandLevelRange", "()[S", AccessFlags = 1)]
				public virtual short[] GetBandLevelRange() /* MethodBuilder.Create */ 
				{
						return default(short[]);
				}

				/// <java-name>
				/// setBandLevel
				/// </java-name>
				[Dot42.DexImport("setBandLevel", "(SS)V", AccessFlags = 1)]
				public virtual void SetBandLevel(short int16, short int161) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getBandLevel
				/// </java-name>
				[Dot42.DexImport("getBandLevel", "(S)S", AccessFlags = 1)]
				public virtual short GetBandLevel(short int16) /* MethodBuilder.Create */ 
				{
						return default(short);
				}

				/// <java-name>
				/// getCenterFreq
				/// </java-name>
				[Dot42.DexImport("getCenterFreq", "(S)I", AccessFlags = 1)]
				public virtual int GetCenterFreq(short int16) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getBandFreqRange
				/// </java-name>
				[Dot42.DexImport("getBandFreqRange", "(S)[I", AccessFlags = 1)]
				public virtual int[] GetBandFreqRange(short int16) /* MethodBuilder.Create */ 
				{
						return default(int[]);
				}

				/// <java-name>
				/// getBand
				/// </java-name>
				[Dot42.DexImport("getBand", "(I)S", AccessFlags = 1)]
				public virtual short GetBand(int int32) /* MethodBuilder.Create */ 
				{
						return default(short);
				}

				/// <java-name>
				/// getCurrentPreset
				/// </java-name>
				[Dot42.DexImport("getCurrentPreset", "()S", AccessFlags = 1)]
				public virtual short GetCurrentPreset() /* MethodBuilder.Create */ 
				{
						return default(short);
				}

				/// <java-name>
				/// usePreset
				/// </java-name>
				[Dot42.DexImport("usePreset", "(S)V", AccessFlags = 1)]
				public virtual void UsePreset(short int16) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getNumberOfPresets
				/// </java-name>
				[Dot42.DexImport("getNumberOfPresets", "()S", AccessFlags = 1)]
				public virtual short GetNumberOfPresets() /* MethodBuilder.Create */ 
				{
						return default(short);
				}

				/// <java-name>
				/// getPresetName
				/// </java-name>
				[Dot42.DexImport("getPresetName", "(S)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetPresetName(short int16) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// setParameterListener
				/// </java-name>
				[Dot42.DexImport("setParameterListener", "(Landroid/media/audiofx/Equalizer$OnParameterChangeListener;)V", AccessFlags = 1)]
				public virtual void SetParameterListener(global::Android.Media.Audiofx.Equalizer.IOnParameterChangeListener onParameterChangeListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getProperties
				/// </java-name>
				[Dot42.DexImport("getProperties", "()Landroid/media/audiofx/Equalizer$Settings;", AccessFlags = 1)]
				public virtual global::Android.Media.Audiofx.Equalizer.Settings GetProperties() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Media.Audiofx.Equalizer.Settings);
				}

				/// <java-name>
				/// setProperties
				/// </java-name>
				[Dot42.DexImport("setProperties", "(Landroid/media/audiofx/Equalizer$Settings;)V", AccessFlags = 1)]
				public virtual void SetProperties(global::Android.Media.Audiofx.Equalizer.Settings settings) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal Equalizer() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getNumberOfBands
				/// </java-name>
				public short NumberOfBands
				{
				[Dot42.DexImport("getNumberOfBands", "()S", AccessFlags = 1)]
						get{ return GetNumberOfBands(); }
				}

				/// <java-name>
				/// getBandLevelRange
				/// </java-name>
				public short[] BandLevelRange
				{
				[Dot42.DexImport("getBandLevelRange", "()[S", AccessFlags = 1)]
						get{ return GetBandLevelRange(); }
				}

				/// <java-name>
				/// getCurrentPreset
				/// </java-name>
				public short CurrentPreset
				{
				[Dot42.DexImport("getCurrentPreset", "()S", AccessFlags = 1)]
						get{ return GetCurrentPreset(); }
				}

				/// <java-name>
				/// getNumberOfPresets
				/// </java-name>
				public short NumberOfPresets
				{
				[Dot42.DexImport("getNumberOfPresets", "()S", AccessFlags = 1)]
						get{ return GetNumberOfPresets(); }
				}

				/// <java-name>
				/// getProperties
				/// </java-name>
				public global::Android.Media.Audiofx.Equalizer.Settings Properties
				{
				[Dot42.DexImport("getProperties", "()Landroid/media/audiofx/Equalizer$Settings;", AccessFlags = 1)]
						get{ return GetProperties(); }
				[Dot42.DexImport("setProperties", "(Landroid/media/audiofx/Equalizer$Settings;)V", AccessFlags = 1)]
						set{ SetProperties(value); }
				}

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

				/// <java-name>
				/// android/media/audiofx/Equalizer$OnParameterChangeListener
				/// </java-name>
				[Dot42.DexImport("android/media/audiofx/Equalizer$OnParameterChangeListener", AccessFlags = 1545)]
				public partial interface IOnParameterChangeListener
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onParameterChange
						/// </java-name>
						[Dot42.DexImport("onParameterChange", "(Landroid/media/audiofx/Equalizer;IIII)V", AccessFlags = 1025)]
						void OnParameterChange(global::Android.Media.Audiofx.Equalizer equalizer, int int32, int int321, int int322, int int323) /* MethodBuilder.Create */ ;

				}

		}

		/// <java-name>
		/// android/media/audiofx/PresetReverb
		/// </java-name>
		[Dot42.DexImport("android/media/audiofx/PresetReverb", AccessFlags = 33)]
		public partial class PresetReverb : global::Android.Media.Audiofx.AudioEffect
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// PARAM_PRESET
				/// </java-name>
				[Dot42.DexImport("PARAM_PRESET", "I", AccessFlags = 25)]
				public const int PARAM_PRESET = 0;
				/// <java-name>
				/// PRESET_NONE
				/// </java-name>
				[Dot42.DexImport("PRESET_NONE", "S", AccessFlags = 25)]
				public const short PRESET_NONE = 0;
				/// <java-name>
				/// PRESET_SMALLROOM
				/// </java-name>
				[Dot42.DexImport("PRESET_SMALLROOM", "S", AccessFlags = 25)]
				public const short PRESET_SMALLROOM = 1;
				/// <java-name>
				/// PRESET_MEDIUMROOM
				/// </java-name>
				[Dot42.DexImport("PRESET_MEDIUMROOM", "S", AccessFlags = 25)]
				public const short PRESET_MEDIUMROOM = 2;
				/// <java-name>
				/// PRESET_LARGEROOM
				/// </java-name>
				[Dot42.DexImport("PRESET_LARGEROOM", "S", AccessFlags = 25)]
				public const short PRESET_LARGEROOM = 3;
				/// <java-name>
				/// PRESET_MEDIUMHALL
				/// </java-name>
				[Dot42.DexImport("PRESET_MEDIUMHALL", "S", AccessFlags = 25)]
				public const short PRESET_MEDIUMHALL = 4;
				/// <java-name>
				/// PRESET_LARGEHALL
				/// </java-name>
				[Dot42.DexImport("PRESET_LARGEHALL", "S", AccessFlags = 25)]
				public const short PRESET_LARGEHALL = 5;
				/// <java-name>
				/// PRESET_PLATE
				/// </java-name>
				[Dot42.DexImport("PRESET_PLATE", "S", AccessFlags = 25)]
				public const short PRESET_PLATE = 6;
				[Dot42.DexImport("<init>", "(II)V", AccessFlags = 1)]
				public PresetReverb(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setPreset
				/// </java-name>
				[Dot42.DexImport("setPreset", "(S)V", AccessFlags = 1)]
				public virtual void SetPreset(short int16) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getPreset
				/// </java-name>
				[Dot42.DexImport("getPreset", "()S", AccessFlags = 1)]
				public virtual short GetPreset() /* MethodBuilder.Create */ 
				{
						return default(short);
				}

				/// <java-name>
				/// setParameterListener
				/// </java-name>
				[Dot42.DexImport("setParameterListener", "(Landroid/media/audiofx/PresetReverb$OnParameterChangeListener;)V", AccessFlags = 1)]
				public virtual void SetParameterListener(global::Android.Media.Audiofx.PresetReverb.IOnParameterChangeListener onParameterChangeListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getProperties
				/// </java-name>
				[Dot42.DexImport("getProperties", "()Landroid/media/audiofx/PresetReverb$Settings;", AccessFlags = 1)]
				public virtual global::Android.Media.Audiofx.PresetReverb.Settings GetProperties() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Media.Audiofx.PresetReverb.Settings);
				}

				/// <java-name>
				/// setProperties
				/// </java-name>
				[Dot42.DexImport("setProperties", "(Landroid/media/audiofx/PresetReverb$Settings;)V", AccessFlags = 1)]
				public virtual void SetProperties(global::Android.Media.Audiofx.PresetReverb.Settings settings) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal PresetReverb() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getPreset
				/// </java-name>
				public short Preset
				{
				[Dot42.DexImport("getPreset", "()S", AccessFlags = 1)]
						get{ return GetPreset(); }
				[Dot42.DexImport("setPreset", "(S)V", AccessFlags = 1)]
						set{ SetPreset(value); }
				}

				/// <java-name>
				/// getProperties
				/// </java-name>
				public global::Android.Media.Audiofx.PresetReverb.Settings Properties
				{
				[Dot42.DexImport("getProperties", "()Landroid/media/audiofx/PresetReverb$Settings;", AccessFlags = 1)]
						get{ return GetProperties(); }
				[Dot42.DexImport("setProperties", "(Landroid/media/audiofx/PresetReverb$Settings;)V", AccessFlags = 1)]
						set{ SetProperties(value); }
				}

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

				/// <java-name>
				/// android/media/audiofx/PresetReverb$OnParameterChangeListener
				/// </java-name>
				[Dot42.DexImport("android/media/audiofx/PresetReverb$OnParameterChangeListener", AccessFlags = 1545)]
				public partial interface IOnParameterChangeListener
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onParameterChange
						/// </java-name>
						[Dot42.DexImport("onParameterChange", "(Landroid/media/audiofx/PresetReverb;IIS)V", AccessFlags = 1025)]
						void OnParameterChange(global::Android.Media.Audiofx.PresetReverb presetReverb, int int32, int int321, short int16) /* MethodBuilder.Create */ ;

				}

		}

		/// <java-name>
		/// android/media/audiofx/Virtualizer
		/// </java-name>
		[Dot42.DexImport("android/media/audiofx/Virtualizer", AccessFlags = 33)]
		public partial class Virtualizer : global::Android.Media.Audiofx.AudioEffect
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// PARAM_STRENGTH_SUPPORTED
				/// </java-name>
				[Dot42.DexImport("PARAM_STRENGTH_SUPPORTED", "I", AccessFlags = 25)]
				public const int PARAM_STRENGTH_SUPPORTED = 0;
				/// <java-name>
				/// PARAM_STRENGTH
				/// </java-name>
				[Dot42.DexImport("PARAM_STRENGTH", "I", AccessFlags = 25)]
				public const int PARAM_STRENGTH = 1;
				[Dot42.DexImport("<init>", "(II)V", AccessFlags = 1)]
				public Virtualizer(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getStrengthSupported
				/// </java-name>
				[Dot42.DexImport("getStrengthSupported", "()Z", AccessFlags = 1)]
				public virtual bool GetStrengthSupported() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setStrength
				/// </java-name>
				[Dot42.DexImport("setStrength", "(S)V", AccessFlags = 1)]
				public virtual void SetStrength(short int16) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getRoundedStrength
				/// </java-name>
				[Dot42.DexImport("getRoundedStrength", "()S", AccessFlags = 1)]
				public virtual short GetRoundedStrength() /* MethodBuilder.Create */ 
				{
						return default(short);
				}

				/// <java-name>
				/// setParameterListener
				/// </java-name>
				[Dot42.DexImport("setParameterListener", "(Landroid/media/audiofx/Virtualizer$OnParameterChangeListener;)V", AccessFlags = 1)]
				public virtual void SetParameterListener(global::Android.Media.Audiofx.Virtualizer.IOnParameterChangeListener onParameterChangeListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getProperties
				/// </java-name>
				[Dot42.DexImport("getProperties", "()Landroid/media/audiofx/Virtualizer$Settings;", AccessFlags = 1)]
				public virtual global::Android.Media.Audiofx.Virtualizer.Settings GetProperties() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Media.Audiofx.Virtualizer.Settings);
				}

				/// <java-name>
				/// setProperties
				/// </java-name>
				[Dot42.DexImport("setProperties", "(Landroid/media/audiofx/Virtualizer$Settings;)V", AccessFlags = 1)]
				public virtual void SetProperties(global::Android.Media.Audiofx.Virtualizer.Settings settings) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal Virtualizer() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getStrengthSupported
				/// </java-name>
				public bool IsStrengthSupported
				{
				[Dot42.DexImport("getStrengthSupported", "()Z", AccessFlags = 1)]
						get{ return GetStrengthSupported(); }
				}

				/// <java-name>
				/// getRoundedStrength
				/// </java-name>
				public short RoundedStrength
				{
				[Dot42.DexImport("getRoundedStrength", "()S", AccessFlags = 1)]
						get{ return GetRoundedStrength(); }
				}

				/// <java-name>
				/// getProperties
				/// </java-name>
				public global::Android.Media.Audiofx.Virtualizer.Settings Properties
				{
				[Dot42.DexImport("getProperties", "()Landroid/media/audiofx/Virtualizer$Settings;", AccessFlags = 1)]
						get{ return GetProperties(); }
				[Dot42.DexImport("setProperties", "(Landroid/media/audiofx/Virtualizer$Settings;)V", AccessFlags = 1)]
						set{ SetProperties(value); }
				}

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

				/// <java-name>
				/// android/media/audiofx/Virtualizer$OnParameterChangeListener
				/// </java-name>
				[Dot42.DexImport("android/media/audiofx/Virtualizer$OnParameterChangeListener", AccessFlags = 1545)]
				public partial interface IOnParameterChangeListener
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onParameterChange
						/// </java-name>
						[Dot42.DexImport("onParameterChange", "(Landroid/media/audiofx/Virtualizer;IIS)V", AccessFlags = 1025)]
						void OnParameterChange(global::Android.Media.Audiofx.Virtualizer virtualizer, int int32, int int321, short int16) /* MethodBuilder.Create */ ;

				}

		}

		/// <java-name>
		/// android/media/audiofx/Visualizer
		/// </java-name>
		[Dot42.DexImport("android/media/audiofx/Visualizer", AccessFlags = 33)]
		public partial class Visualizer
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
				/// STATE_ENABLED
				/// </java-name>
				[Dot42.DexImport("STATE_ENABLED", "I", AccessFlags = 25)]
				public const int STATE_ENABLED = 2;
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
				/// ALREADY_EXISTS
				/// </java-name>
				[Dot42.DexImport("ALREADY_EXISTS", "I", AccessFlags = 25)]
				public const int ALREADY_EXISTS = -2;
				/// <java-name>
				/// ERROR_NO_INIT
				/// </java-name>
				[Dot42.DexImport("ERROR_NO_INIT", "I", AccessFlags = 25)]
				public const int ERROR_NO_INIT = -3;
				/// <java-name>
				/// ERROR_BAD_VALUE
				/// </java-name>
				[Dot42.DexImport("ERROR_BAD_VALUE", "I", AccessFlags = 25)]
				public const int ERROR_BAD_VALUE = -4;
				/// <java-name>
				/// ERROR_INVALID_OPERATION
				/// </java-name>
				[Dot42.DexImport("ERROR_INVALID_OPERATION", "I", AccessFlags = 25)]
				public const int ERROR_INVALID_OPERATION = -5;
				/// <java-name>
				/// ERROR_NO_MEMORY
				/// </java-name>
				[Dot42.DexImport("ERROR_NO_MEMORY", "I", AccessFlags = 25)]
				public const int ERROR_NO_MEMORY = -6;
				/// <java-name>
				/// ERROR_DEAD_OBJECT
				/// </java-name>
				[Dot42.DexImport("ERROR_DEAD_OBJECT", "I", AccessFlags = 25)]
				public const int ERROR_DEAD_OBJECT = -7;
				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public Visualizer(int int32) /* MethodBuilder.Create */ 
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
				extern ~Visualizer() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setEnabled
				/// </java-name>
				[Dot42.DexImport("setEnabled", "(Z)I", AccessFlags = 1)]
				public virtual int SetEnabled(bool boolean) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getEnabled
				/// </java-name>
				[Dot42.DexImport("getEnabled", "()Z", AccessFlags = 1)]
				public virtual bool GetEnabled() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getCaptureSizeRange
				/// </java-name>
				[Dot42.DexImport("getCaptureSizeRange", "()[I", AccessFlags = 265)]
				public static int[] GetCaptureSizeRange() /* MethodBuilder.Create */ 
				{
						return default(int[]);
				}

				/// <java-name>
				/// getMaxCaptureRate
				/// </java-name>
				[Dot42.DexImport("getMaxCaptureRate", "()I", AccessFlags = 265)]
				public static int GetMaxCaptureRate() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// setCaptureSize
				/// </java-name>
				[Dot42.DexImport("setCaptureSize", "(I)I", AccessFlags = 1)]
				public virtual int SetCaptureSize(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getCaptureSize
				/// </java-name>
				[Dot42.DexImport("getCaptureSize", "()I", AccessFlags = 1)]
				public virtual int GetCaptureSize() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getSamplingRate
				/// </java-name>
				[Dot42.DexImport("getSamplingRate", "()I", AccessFlags = 1)]
				public virtual int GetSamplingRate() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getWaveForm
				/// </java-name>
				[Dot42.DexImport("getWaveForm", "([B)I", AccessFlags = 1)]
				public virtual int GetWaveForm(sbyte[] sByte) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getWaveForm
				/// </java-name>
				[Dot42.DexImport("getWaveForm", "([B)I", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual int GetWaveForm(byte[] @byte) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getFft
				/// </java-name>
				[Dot42.DexImport("getFft", "([B)I", AccessFlags = 1)]
				public virtual int GetFft(sbyte[] sByte) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getFft
				/// </java-name>
				[Dot42.DexImport("getFft", "([B)I", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual int GetFft(byte[] @byte) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// setDataCaptureListener
				/// </java-name>
				[Dot42.DexImport("setDataCaptureListener", "(Landroid/media/audiofx/Visualizer$OnDataCaptureListener;IZZ)I", AccessFlags = 1)]
				public virtual int SetDataCaptureListener(global::Android.Media.Audiofx.Visualizer.IOnDataCaptureListener onDataCaptureListener, int int32, bool boolean, bool boolean1) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal Visualizer() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getEnabled
				/// </java-name>
				public bool IsEnabled
				{
				[Dot42.DexImport("getEnabled", "()Z", AccessFlags = 1)]
						get{ return GetEnabled(); }
				}

				/// <java-name>
				/// getCaptureSizeRange
				/// </java-name>
				public static int[] CaptureSizeRange
				{
				[Dot42.DexImport("getCaptureSizeRange", "()[I", AccessFlags = 265)]
						get{ return GetCaptureSizeRange(); }
				}

				/// <java-name>
				/// getMaxCaptureRate
				/// </java-name>
				public static int MaxCaptureRate
				{
				[Dot42.DexImport("getMaxCaptureRate", "()I", AccessFlags = 265)]
						get{ return GetMaxCaptureRate(); }
				}

				/// <java-name>
				/// getCaptureSize
				/// </java-name>
				public int CaptureSize
				{
				[Dot42.DexImport("getCaptureSize", "()I", AccessFlags = 1)]
						get{ return GetCaptureSize(); }
				}

				/// <java-name>
				/// getSamplingRate
				/// </java-name>
				public int SamplingRate
				{
				[Dot42.DexImport("getSamplingRate", "()I", AccessFlags = 1)]
						get{ return GetSamplingRate(); }
				}

				/// <java-name>
				/// android/media/audiofx/Visualizer$OnDataCaptureListener
				/// </java-name>
				[Dot42.DexImport("android/media/audiofx/Visualizer$OnDataCaptureListener", AccessFlags = 1545)]
				public partial interface IOnDataCaptureListener
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onWaveFormDataCapture
						/// </java-name>
						[Dot42.DexImport("onWaveFormDataCapture", "(Landroid/media/audiofx/Visualizer;[BI)V", AccessFlags = 1025)]
						void OnWaveFormDataCapture(global::Android.Media.Audiofx.Visualizer visualizer, sbyte[] sByte, int int32) /* MethodBuilder.Create */ ;

						/// <java-name>
						/// onFftDataCapture
						/// </java-name>
						[Dot42.DexImport("onFftDataCapture", "(Landroid/media/audiofx/Visualizer;[BI)V", AccessFlags = 1025)]
						void OnFftDataCapture(global::Android.Media.Audiofx.Visualizer visualizer, sbyte[] sByte, int int32) /* MethodBuilder.Create */ ;

				}

		}

}

