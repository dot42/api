#pragma warning disable 1717
namespace Android.Speech.Tts
{
		/// <java-name>
		/// android/speech/tts/SynthesisCallback
		/// </java-name>
		[Dot42.DexImport("android/speech/tts/SynthesisCallback", AccessFlags = 1537)]
		public partial interface ISynthesisCallback
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// start
				/// </java-name>
				[Dot42.DexImport("start", "(III)I", AccessFlags = 1025)]
				int Start(int int32, int int321, int int322) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// audioAvailable
				/// </java-name>
				[Dot42.DexImport("audioAvailable", "([BII)I", AccessFlags = 1025)]
				int AudioAvailable(sbyte[] sByte, int int32, int int321) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// done
				/// </java-name>
				[Dot42.DexImport("done", "()I", AccessFlags = 1025)]
				int Done() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// error
				/// </java-name>
				[Dot42.DexImport("error", "()V", AccessFlags = 1025)]
				void Error() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getMaxBufferSize
				/// </java-name>
				int MaxBufferSize
				{
						[Dot42.DexImport("getMaxBufferSize", "()I", AccessFlags = 1025)]
						get;
				}

		}

		/// <java-name>
		/// android/speech/tts/SynthesisRequest
		/// </java-name>
		[Dot42.DexImport("android/speech/tts/SynthesisRequest", AccessFlags = 49)]
		public sealed partial class SynthesisRequest
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Landroid/os/Bundle;)V", AccessFlags = 1)]
				public SynthesisRequest(string @string, global::Android.OS.Bundle bundle) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal SynthesisRequest() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getText
				/// </java-name>
				public string Text
				{
						[Dot42.DexImport("getText", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getLanguage
				/// </java-name>
				public string Language
				{
						[Dot42.DexImport("getLanguage", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getCountry
				/// </java-name>
				public string Country
				{
						[Dot42.DexImport("getCountry", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getVariant
				/// </java-name>
				public string Variant
				{
						[Dot42.DexImport("getVariant", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getSpeechRate
				/// </java-name>
				public int SpeechRate
				{
						[Dot42.DexImport("getSpeechRate", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getPitch
				/// </java-name>
				public int Pitch
				{
						[Dot42.DexImport("getPitch", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getParams
				/// </java-name>
				public global::Android.OS.Bundle Params
				{
						[Dot42.DexImport("getParams", "()Landroid/os/Bundle;", AccessFlags = 1)]
						get{ return default(global::Android.OS.Bundle); }
				}

		}

		/// <java-name>
		/// android/speech/tts/TextToSpeech
		/// </java-name>
		[Dot42.DexImport("android/speech/tts/TextToSpeech", AccessFlags = 33)]
		public partial class TextToSpeech
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
				/// QUEUE_FLUSH
				/// </java-name>
				[Dot42.DexImport("QUEUE_FLUSH", "I", AccessFlags = 25)]
				public const int QUEUE_FLUSH = 0;
				/// <java-name>
				/// QUEUE_ADD
				/// </java-name>
				[Dot42.DexImport("QUEUE_ADD", "I", AccessFlags = 25)]
				public const int QUEUE_ADD = 1;
				/// <java-name>
				/// LANG_COUNTRY_VAR_AVAILABLE
				/// </java-name>
				[Dot42.DexImport("LANG_COUNTRY_VAR_AVAILABLE", "I", AccessFlags = 25)]
				public const int LANG_COUNTRY_VAR_AVAILABLE = 2;
				/// <java-name>
				/// LANG_COUNTRY_AVAILABLE
				/// </java-name>
				[Dot42.DexImport("LANG_COUNTRY_AVAILABLE", "I", AccessFlags = 25)]
				public const int LANG_COUNTRY_AVAILABLE = 1;
				/// <java-name>
				/// LANG_AVAILABLE
				/// </java-name>
				[Dot42.DexImport("LANG_AVAILABLE", "I", AccessFlags = 25)]
				public const int LANG_AVAILABLE = 0;
				/// <java-name>
				/// LANG_MISSING_DATA
				/// </java-name>
				[Dot42.DexImport("LANG_MISSING_DATA", "I", AccessFlags = 25)]
				public const int LANG_MISSING_DATA = -1;
				/// <java-name>
				/// LANG_NOT_SUPPORTED
				/// </java-name>
				[Dot42.DexImport("LANG_NOT_SUPPORTED", "I", AccessFlags = 25)]
				public const int LANG_NOT_SUPPORTED = -2;
				/// <java-name>
				/// ACTION_TTS_QUEUE_PROCESSING_COMPLETED
				/// </java-name>
				[Dot42.DexImport("ACTION_TTS_QUEUE_PROCESSING_COMPLETED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_TTS_QUEUE_PROCESSING_COMPLETED = "android.speech.tts.TTS_QUEUE_PROCESSING_COMPLETED";
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/speech/tts/TextToSpeech$OnInitListener;)V", AccessFlags = 1)]
				public TextToSpeech(global::Android.Content.Context context, global::Android.Speech.Tts.TextToSpeech.IOnInitListener onInitListener) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/speech/tts/TextToSpeech$OnInitListener;Ljava/l" +
    "ang/String;)V", AccessFlags = 1)]
				public TextToSpeech(global::Android.Content.Context context, global::Android.Speech.Tts.TextToSpeech.IOnInitListener onInitListener, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// shutdown
				/// </java-name>
				[Dot42.DexImport("shutdown", "()V", AccessFlags = 1)]
				public virtual void Shutdown() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addSpeech
				/// </java-name>
				[Dot42.DexImport("addSpeech", "(Ljava/lang/String;Ljava/lang/String;I)I", AccessFlags = 1)]
				public virtual int AddSpeech(string @string, string string1, int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// addSpeech
				/// </java-name>
				[Dot42.DexImport("addSpeech", "(Ljava/lang/String;Ljava/lang/String;)I", AccessFlags = 1)]
				public virtual int AddSpeech(string @string, string string1) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// addEarcon
				/// </java-name>
				[Dot42.DexImport("addEarcon", "(Ljava/lang/String;Ljava/lang/String;I)I", AccessFlags = 1)]
				public virtual int AddEarcon(string @string, string string1, int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// addEarcon
				/// </java-name>
				[Dot42.DexImport("addEarcon", "(Ljava/lang/String;Ljava/lang/String;)I", AccessFlags = 1)]
				public virtual int AddEarcon(string @string, string string1) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// speak
				/// </java-name>
				[Dot42.DexImport("speak", "(Ljava/lang/String;ILjava/util/HashMap;)I", AccessFlags = 1, Signature = "(Ljava/lang/String;ILjava/util/HashMap<Ljava/lang/String;Ljava/lang/String;>;)I")]
				public virtual int Speak(string @string, int int32, global::Java.Util.HashMap<string, string> hashMap) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// playEarcon
				/// </java-name>
				[Dot42.DexImport("playEarcon", "(Ljava/lang/String;ILjava/util/HashMap;)I", AccessFlags = 1, Signature = "(Ljava/lang/String;ILjava/util/HashMap<Ljava/lang/String;Ljava/lang/String;>;)I")]
				public virtual int PlayEarcon(string @string, int int32, global::Java.Util.HashMap<string, string> hashMap) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// playSilence
				/// </java-name>
				[Dot42.DexImport("playSilence", "(JILjava/util/HashMap;)I", AccessFlags = 1, Signature = "(JILjava/util/HashMap<Ljava/lang/String;Ljava/lang/String;>;)I")]
				public virtual int PlaySilence(long int64, int int32, global::Java.Util.HashMap<string, string> hashMap) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getFeatures
				/// </java-name>
				[Dot42.DexImport("getFeatures", "(Ljava/util/Locale;)Ljava/util/Set;", AccessFlags = 1, Signature = "(Ljava/util/Locale;)Ljava/util/Set<Ljava/lang/String;>;")]
				public virtual global::Java.Util.ISet<string> GetFeatures(global::Java.Util.Locale locale) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ISet<string>);
				}

				/// <java-name>
				/// stop
				/// </java-name>
				[Dot42.DexImport("stop", "()I", AccessFlags = 1)]
				public virtual int Stop() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// setSpeechRate
				/// </java-name>
				[Dot42.DexImport("setSpeechRate", "(F)I", AccessFlags = 1)]
				public virtual int SetSpeechRate(float single) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// setPitch
				/// </java-name>
				[Dot42.DexImport("setPitch", "(F)I", AccessFlags = 1)]
				public virtual int SetPitch(float single) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// setLanguage
				/// </java-name>
				[Dot42.DexImport("setLanguage", "(Ljava/util/Locale;)I", AccessFlags = 1)]
				public virtual int SetLanguage(global::Java.Util.Locale locale) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// isLanguageAvailable
				/// </java-name>
				[Dot42.DexImport("isLanguageAvailable", "(Ljava/util/Locale;)I", AccessFlags = 1)]
				public virtual int IsLanguageAvailable(global::Java.Util.Locale locale) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// synthesizeToFile
				/// </java-name>
				[Dot42.DexImport("synthesizeToFile", "(Ljava/lang/String;Ljava/util/HashMap;Ljava/lang/String;)I", AccessFlags = 1, Signature = "(Ljava/lang/String;Ljava/util/HashMap<Ljava/lang/String;Ljava/lang/String;>;Ljava" +
    "/lang/String;)I")]
				public virtual int SynthesizeToFile(string @string, global::Java.Util.HashMap<string, string> hashMap, string string1) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// setOnUtteranceCompletedListener
				/// </java-name>
				[Dot42.DexImport("setOnUtteranceCompletedListener", "(Landroid/speech/tts/TextToSpeech$OnUtteranceCompletedListener;)I", AccessFlags = 1)]
				public virtual int SetOnUtteranceCompletedListener(global::Android.Speech.Tts.TextToSpeech.IOnUtteranceCompletedListener onUtteranceCompletedListener) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// setOnUtteranceProgressListener
				/// </java-name>
				[Dot42.DexImport("setOnUtteranceProgressListener", "(Landroid/speech/tts/UtteranceProgressListener;)I", AccessFlags = 1)]
				public virtual int SetOnUtteranceProgressListener(global::Android.Speech.Tts.UtteranceProgressListener utteranceProgressListener) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// setEngineByPackageName
				/// </java-name>
				[Dot42.DexImport("setEngineByPackageName", "(Ljava/lang/String;)I", AccessFlags = 1)]
				public virtual int SetEngineByPackageName(string @string) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// areDefaultsEnforced
				/// </java-name>
				[Dot42.DexImport("areDefaultsEnforced", "()Z", AccessFlags = 1)]
				public virtual bool AreDefaultsEnforced() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal TextToSpeech() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// isSpeaking
				/// </java-name>
				public virtual bool IsSpeaking
				{
						[Dot42.DexImport("isSpeaking", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// getLanguage
				/// </java-name>
				public virtual global::Java.Util.Locale Language
				{
						[Dot42.DexImport("getLanguage", "()Ljava/util/Locale;", AccessFlags = 1)]
						get{ return default(global::Java.Util.Locale); }
				}

				/// <java-name>
				/// getDefaultEngine
				/// </java-name>
				public virtual string DefaultEngine
				{
						[Dot42.DexImport("getDefaultEngine", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getEngines
				/// </java-name>
				public virtual global::Java.Util.IList<global::Android.Speech.Tts.TextToSpeech.EngineInfo> Engines
				{
						[Dot42.DexImport("getEngines", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Landroid/speech/tts/TextToSpeech$EngineInfo;>;")]
						get{ return default(global::Java.Util.IList<global::Android.Speech.Tts.TextToSpeech.EngineInfo>); }
				}

				/// <java-name>
				/// android/speech/tts/TextToSpeech$EngineInfo
				/// </java-name>
				[Dot42.DexImport("android/speech/tts/TextToSpeech$EngineInfo", AccessFlags = 9)]
				public partial class EngineInfo
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// name
						/// </java-name>
						[Dot42.DexImport("name", "Ljava/lang/String;", AccessFlags = 1)]
						public string Name;
						/// <java-name>
						/// label
						/// </java-name>
						[Dot42.DexImport("label", "Ljava/lang/String;", AccessFlags = 1)]
						public string Label;
						/// <java-name>
						/// icon
						/// </java-name>
						[Dot42.DexImport("icon", "I", AccessFlags = 1)]
						public int Icon;
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public EngineInfo() /* MethodBuilder.Create */ 
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
				/// android/speech/tts/TextToSpeech$Engine
				/// </java-name>
				[Dot42.DexImport("android/speech/tts/TextToSpeech$Engine", AccessFlags = 1)]
				public partial class Engine
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// DEFAULT_STREAM
						/// </java-name>
						[Dot42.DexImport("DEFAULT_STREAM", "I", AccessFlags = 25)]
						public const int DEFAULT_STREAM = 3;
						/// <java-name>
						/// CHECK_VOICE_DATA_PASS
						/// </java-name>
						[Dot42.DexImport("CHECK_VOICE_DATA_PASS", "I", AccessFlags = 25)]
						public const int CHECK_VOICE_DATA_PASS = 1;
						/// <java-name>
						/// CHECK_VOICE_DATA_FAIL
						/// </java-name>
						[Dot42.DexImport("CHECK_VOICE_DATA_FAIL", "I", AccessFlags = 25)]
						public const int CHECK_VOICE_DATA_FAIL = 0;
						/// <java-name>
						/// CHECK_VOICE_DATA_BAD_DATA
						/// </java-name>
						[Dot42.DexImport("CHECK_VOICE_DATA_BAD_DATA", "I", AccessFlags = 25)]
						public const int CHECK_VOICE_DATA_BAD_DATA = -1;
						/// <java-name>
						/// CHECK_VOICE_DATA_MISSING_DATA
						/// </java-name>
						[Dot42.DexImport("CHECK_VOICE_DATA_MISSING_DATA", "I", AccessFlags = 25)]
						public const int CHECK_VOICE_DATA_MISSING_DATA = -2;
						/// <java-name>
						/// CHECK_VOICE_DATA_MISSING_VOLUME
						/// </java-name>
						[Dot42.DexImport("CHECK_VOICE_DATA_MISSING_VOLUME", "I", AccessFlags = 25)]
						public const int CHECK_VOICE_DATA_MISSING_VOLUME = -3;
						/// <java-name>
						/// INTENT_ACTION_TTS_SERVICE
						/// </java-name>
						[Dot42.DexImport("INTENT_ACTION_TTS_SERVICE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string INTENT_ACTION_TTS_SERVICE = "android.intent.action.TTS_SERVICE";
						/// <java-name>
						/// SERVICE_META_DATA
						/// </java-name>
						[Dot42.DexImport("SERVICE_META_DATA", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SERVICE_META_DATA = "android.speech.tts";
						/// <java-name>
						/// ACTION_INSTALL_TTS_DATA
						/// </java-name>
						[Dot42.DexImport("ACTION_INSTALL_TTS_DATA", "Ljava/lang/String;", AccessFlags = 25)]
						public const string ACTION_INSTALL_TTS_DATA = "android.speech.tts.engine.INSTALL_TTS_DATA";
						/// <java-name>
						/// ACTION_TTS_DATA_INSTALLED
						/// </java-name>
						[Dot42.DexImport("ACTION_TTS_DATA_INSTALLED", "Ljava/lang/String;", AccessFlags = 25)]
						public const string ACTION_TTS_DATA_INSTALLED = "android.speech.tts.engine.TTS_DATA_INSTALLED";
						/// <java-name>
						/// ACTION_CHECK_TTS_DATA
						/// </java-name>
						[Dot42.DexImport("ACTION_CHECK_TTS_DATA", "Ljava/lang/String;", AccessFlags = 25)]
						public const string ACTION_CHECK_TTS_DATA = "android.speech.tts.engine.CHECK_TTS_DATA";
						/// <java-name>
						/// EXTRA_VOICE_DATA_ROOT_DIRECTORY
						/// </java-name>
						[Dot42.DexImport("EXTRA_VOICE_DATA_ROOT_DIRECTORY", "Ljava/lang/String;", AccessFlags = 25)]
						public const string EXTRA_VOICE_DATA_ROOT_DIRECTORY = "dataRoot";
						/// <java-name>
						/// EXTRA_VOICE_DATA_FILES
						/// </java-name>
						[Dot42.DexImport("EXTRA_VOICE_DATA_FILES", "Ljava/lang/String;", AccessFlags = 25)]
						public const string EXTRA_VOICE_DATA_FILES = "dataFiles";
						/// <java-name>
						/// EXTRA_VOICE_DATA_FILES_INFO
						/// </java-name>
						[Dot42.DexImport("EXTRA_VOICE_DATA_FILES_INFO", "Ljava/lang/String;", AccessFlags = 25)]
						public const string EXTRA_VOICE_DATA_FILES_INFO = "dataFilesInfo";
						/// <java-name>
						/// EXTRA_AVAILABLE_VOICES
						/// </java-name>
						[Dot42.DexImport("EXTRA_AVAILABLE_VOICES", "Ljava/lang/String;", AccessFlags = 25)]
						public const string EXTRA_AVAILABLE_VOICES = "availableVoices";
						/// <java-name>
						/// EXTRA_UNAVAILABLE_VOICES
						/// </java-name>
						[Dot42.DexImport("EXTRA_UNAVAILABLE_VOICES", "Ljava/lang/String;", AccessFlags = 25)]
						public const string EXTRA_UNAVAILABLE_VOICES = "unavailableVoices";
						/// <java-name>
						/// EXTRA_CHECK_VOICE_DATA_FOR
						/// </java-name>
						[Dot42.DexImport("EXTRA_CHECK_VOICE_DATA_FOR", "Ljava/lang/String;", AccessFlags = 25)]
						public const string EXTRA_CHECK_VOICE_DATA_FOR = "checkVoiceDataFor";
						/// <java-name>
						/// EXTRA_TTS_DATA_INSTALLED
						/// </java-name>
						[Dot42.DexImport("EXTRA_TTS_DATA_INSTALLED", "Ljava/lang/String;", AccessFlags = 25)]
						public const string EXTRA_TTS_DATA_INSTALLED = "dataInstalled";
						/// <java-name>
						/// KEY_PARAM_STREAM
						/// </java-name>
						[Dot42.DexImport("KEY_PARAM_STREAM", "Ljava/lang/String;", AccessFlags = 25)]
						public const string KEY_PARAM_STREAM = "streamType";
						/// <java-name>
						/// KEY_PARAM_UTTERANCE_ID
						/// </java-name>
						[Dot42.DexImport("KEY_PARAM_UTTERANCE_ID", "Ljava/lang/String;", AccessFlags = 25)]
						public const string KEY_PARAM_UTTERANCE_ID = "utteranceId";
						/// <java-name>
						/// KEY_PARAM_VOLUME
						/// </java-name>
						[Dot42.DexImport("KEY_PARAM_VOLUME", "Ljava/lang/String;", AccessFlags = 25)]
						public const string KEY_PARAM_VOLUME = "volume";
						/// <java-name>
						/// KEY_PARAM_PAN
						/// </java-name>
						[Dot42.DexImport("KEY_PARAM_PAN", "Ljava/lang/String;", AccessFlags = 25)]
						public const string KEY_PARAM_PAN = "pan";
						/// <java-name>
						/// KEY_FEATURE_NETWORK_SYNTHESIS
						/// </java-name>
						[Dot42.DexImport("KEY_FEATURE_NETWORK_SYNTHESIS", "Ljava/lang/String;", AccessFlags = 25)]
						public const string KEY_FEATURE_NETWORK_SYNTHESIS = "networkTts";
						/// <java-name>
						/// KEY_FEATURE_EMBEDDED_SYNTHESIS
						/// </java-name>
						[Dot42.DexImport("KEY_FEATURE_EMBEDDED_SYNTHESIS", "Ljava/lang/String;", AccessFlags = 25)]
						public const string KEY_FEATURE_EMBEDDED_SYNTHESIS = "embeddedTts";
						/// <java-name>
						/// this$0
						/// </java-name>
						[Dot42.DexImport("this$0", "Landroid/speech/tts/TextToSpeech;", AccessFlags = 4112)]
						internal readonly global::Android.Speech.Tts.TextToSpeech This_0;
						[Dot42.DexImport("<init>", "(Landroid/speech/tts/TextToSpeech;)V", AccessFlags = 1)]
						public Engine(global::Android.Speech.Tts.TextToSpeech textToSpeech) /* MethodBuilder.Create */ 
						{
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal Engine() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

				}

				/// <java-name>
				/// android/speech/tts/TextToSpeech$OnUtteranceCompletedListener
				/// </java-name>
				[Dot42.DexImport("android/speech/tts/TextToSpeech$OnUtteranceCompletedListener", AccessFlags = 1545)]
				public partial interface IOnUtteranceCompletedListener
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onUtteranceCompleted
						/// </java-name>
						[Dot42.DexImport("onUtteranceCompleted", "(Ljava/lang/String;)V", AccessFlags = 1025)]
						void OnUtteranceCompleted(string @string) /* MethodBuilder.Create */ ;

				}

				/// <java-name>
				/// android/speech/tts/TextToSpeech$OnInitListener
				/// </java-name>
				[Dot42.DexImport("android/speech/tts/TextToSpeech$OnInitListener", AccessFlags = 1545)]
				public partial interface IOnInitListener
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onInit
						/// </java-name>
						[Dot42.DexImport("onInit", "(I)V", AccessFlags = 1025)]
						void OnInit(int int32) /* MethodBuilder.Create */ ;

				}

		}

		/// <java-name>
		/// android/speech/tts/TextToSpeechService
		/// </java-name>
		[Dot42.DexImport("android/speech/tts/TextToSpeechService", AccessFlags = 1057)]
		public abstract partial class TextToSpeechService : global::Android.App.Service
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public TextToSpeechService() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onCreate
				/// </java-name>
				[Dot42.DexImport("onCreate", "()V", AccessFlags = 1)]
				public override void OnCreate() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onDestroy
				/// </java-name>
				[Dot42.DexImport("onDestroy", "()V", AccessFlags = 1)]
				public override void OnDestroy() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onIsLanguageAvailable
				/// </java-name>
				[Dot42.DexImport("onIsLanguageAvailable", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)I", AccessFlags = 1028)]
				protected internal abstract int OnIsLanguageAvailable(string @string, string string1, string string2) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// onGetLanguage
				/// </java-name>
				[Dot42.DexImport("onGetLanguage", "()[Ljava/lang/String;", AccessFlags = 1028)]
				protected internal abstract string[] OnGetLanguage() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// onLoadLanguage
				/// </java-name>
				[Dot42.DexImport("onLoadLanguage", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)I", AccessFlags = 1028)]
				protected internal abstract int OnLoadLanguage(string @string, string string1, string string2) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// onStop
				/// </java-name>
				[Dot42.DexImport("onStop", "()V", AccessFlags = 1028)]
				protected internal abstract void OnStop() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// onSynthesizeText
				/// </java-name>
				[Dot42.DexImport("onSynthesizeText", "(Landroid/speech/tts/SynthesisRequest;Landroid/speech/tts/SynthesisCallback;)V", AccessFlags = 1028)]
				protected internal abstract void OnSynthesizeText(global::Android.Speech.Tts.SynthesisRequest synthesisRequest, global::Android.Speech.Tts.ISynthesisCallback synthesisCallback) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// onGetFeaturesForLanguage
				/// </java-name>
				[Dot42.DexImport("onGetFeaturesForLanguage", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/util/Set;", AccessFlags = 4, Signature = "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/util/Set<Ljava/lang" +
    "/String;>;")]
				protected internal virtual global::Java.Util.ISet<string> OnGetFeaturesForLanguage(string @string, string string1, string string2) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ISet<string>);
				}

				/// <java-name>
				/// onBind
				/// </java-name>
				[Dot42.DexImport("onBind", "(Landroid/content/Intent;)Landroid/os/IBinder;", AccessFlags = 1)]
				public override global::Android.OS.IBinder OnBind(global::Android.Content.Intent intent) /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.IBinder);
				}

		}

		/// <java-name>
		/// android/speech/tts/UtteranceProgressListener
		/// </java-name>
		[Dot42.DexImport("android/speech/tts/UtteranceProgressListener", AccessFlags = 1057)]
		public abstract partial class UtteranceProgressListener
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public UtteranceProgressListener() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onStart
				/// </java-name>
				[Dot42.DexImport("onStart", "(Ljava/lang/String;)V", AccessFlags = 1025)]
				public abstract void OnStart(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// onDone
				/// </java-name>
				[Dot42.DexImport("onDone", "(Ljava/lang/String;)V", AccessFlags = 1025)]
				public abstract void OnDone(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// onError
				/// </java-name>
				[Dot42.DexImport("onError", "(Ljava/lang/String;)V", AccessFlags = 1025)]
				public abstract void OnError(string @string) /* MethodBuilder.Create */ ;

		}

}

