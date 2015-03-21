#pragma warning disable 1717
namespace Android.Speech
{
		/// <java-name>
		/// android/speech/RecognitionListener
		/// </java-name>
		[Dot42.DexImport("android/speech/RecognitionListener", AccessFlags = 1537)]
		public partial interface IRecognitionListener
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// onReadyForSpeech
				/// </java-name>
				[Dot42.DexImport("onReadyForSpeech", "(Landroid/os/Bundle;)V", AccessFlags = 1025)]
				void OnReadyForSpeech(global::Android.Os.Bundle bundle) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// onBeginningOfSpeech
				/// </java-name>
				[Dot42.DexImport("onBeginningOfSpeech", "()V", AccessFlags = 1025)]
				void OnBeginningOfSpeech() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// onRmsChanged
				/// </java-name>
				[Dot42.DexImport("onRmsChanged", "(F)V", AccessFlags = 1025)]
				void OnRmsChanged(float single) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// onBufferReceived
				/// </java-name>
				[Dot42.DexImport("onBufferReceived", "([B)V", AccessFlags = 1025)]
				void OnBufferReceived(sbyte[] sByte) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// onEndOfSpeech
				/// </java-name>
				[Dot42.DexImport("onEndOfSpeech", "()V", AccessFlags = 1025)]
				void OnEndOfSpeech() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// onError
				/// </java-name>
				[Dot42.DexImport("onError", "(I)V", AccessFlags = 1025)]
				void OnError(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// onResults
				/// </java-name>
				[Dot42.DexImport("onResults", "(Landroid/os/Bundle;)V", AccessFlags = 1025)]
				void OnResults(global::Android.Os.Bundle bundle) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// onPartialResults
				/// </java-name>
				[Dot42.DexImport("onPartialResults", "(Landroid/os/Bundle;)V", AccessFlags = 1025)]
				void OnPartialResults(global::Android.Os.Bundle bundle) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// onEvent
				/// </java-name>
				[Dot42.DexImport("onEvent", "(ILandroid/os/Bundle;)V", AccessFlags = 1025)]
				void OnEvent(int int32, global::Android.Os.Bundle bundle) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// android/speech/RecognitionService
		/// </java-name>
		[Dot42.DexImport("android/speech/RecognitionService", AccessFlags = 1057)]
		public abstract partial class RecognitionService : global::Android.App.Service
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// SERVICE_INTERFACE
				/// </java-name>
				[Dot42.DexImport("SERVICE_INTERFACE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SERVICE_INTERFACE = "android.speech.RecognitionService";
				/// <java-name>
				/// SERVICE_META_DATA
				/// </java-name>
				[Dot42.DexImport("SERVICE_META_DATA", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SERVICE_META_DATA = "android.speech";
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public RecognitionService() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onStartListening
				/// </java-name>
				[Dot42.DexImport("onStartListening", "(Landroid/content/Intent;Landroid/speech/RecognitionService$Callback;)V", AccessFlags = 1028)]
				protected internal abstract void OnStartListening(global::Android.Content.Intent intent, global::Android.Speech.RecognitionService.Callback callback) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// onCancel
				/// </java-name>
				[Dot42.DexImport("onCancel", "(Landroid/speech/RecognitionService$Callback;)V", AccessFlags = 1028)]
				protected internal abstract void OnCancel(global::Android.Speech.RecognitionService.Callback callback) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// onStopListening
				/// </java-name>
				[Dot42.DexImport("onStopListening", "(Landroid/speech/RecognitionService$Callback;)V", AccessFlags = 1028)]
				protected internal abstract void OnStopListening(global::Android.Speech.RecognitionService.Callback callback) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// onBind
				/// </java-name>
				[Dot42.DexImport("onBind", "(Landroid/content/Intent;)Landroid/os/IBinder;", AccessFlags = 17)]
				public override global::Android.Os.IBinder OnBind(global::Android.Content.Intent intent) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Os.IBinder);
				}

				/// <java-name>
				/// onDestroy
				/// </java-name>
				[Dot42.DexImport("onDestroy", "()V", AccessFlags = 1)]
				public override void OnDestroy() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// android/speech/RecognitionService$Callback
				/// </java-name>
				[Dot42.DexImport("android/speech/RecognitionService$Callback", AccessFlags = 1)]
				public partial class Callback
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// this$0
						/// </java-name>
						[Dot42.DexImport("this$0", "Landroid/speech/RecognitionService;", AccessFlags = 4112)]
						internal readonly global::Android.Speech.RecognitionService This_0;
						[Dot42.DexImport("<init>", "(Landroid/speech/RecognitionService;)V", AccessFlags = 0)]
						internal Callback(global::Android.Speech.RecognitionService recognitionService) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// beginningOfSpeech
						/// </java-name>
						[Dot42.DexImport("beginningOfSpeech", "()V", AccessFlags = 1)]
						public virtual void BeginningOfSpeech() /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// bufferReceived
						/// </java-name>
						[Dot42.DexImport("bufferReceived", "([B)V", AccessFlags = 1)]
						public virtual void BufferReceived(sbyte[] sByte) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// bufferReceived
						/// </java-name>
						[Dot42.DexImport("bufferReceived", "([B)V", AccessFlags = 1, IgnoreFromJava = true)]
						public virtual void BufferReceived(byte[] @byte) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// endOfSpeech
						/// </java-name>
						[Dot42.DexImport("endOfSpeech", "()V", AccessFlags = 1)]
						public virtual void EndOfSpeech() /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// error
						/// </java-name>
						[Dot42.DexImport("error", "(I)V", AccessFlags = 1)]
						public virtual void Error(int int32) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// partialResults
						/// </java-name>
						[Dot42.DexImport("partialResults", "(Landroid/os/Bundle;)V", AccessFlags = 1)]
						public virtual void PartialResults(global::Android.Os.Bundle bundle) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// readyForSpeech
						/// </java-name>
						[Dot42.DexImport("readyForSpeech", "(Landroid/os/Bundle;)V", AccessFlags = 1)]
						public virtual void ReadyForSpeech(global::Android.Os.Bundle bundle) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// results
						/// </java-name>
						[Dot42.DexImport("results", "(Landroid/os/Bundle;)V", AccessFlags = 1)]
						public virtual void Results(global::Android.Os.Bundle bundle) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// rmsChanged
						/// </java-name>
						[Dot42.DexImport("rmsChanged", "(F)V", AccessFlags = 1)]
						public virtual void RmsChanged(float single) /* MethodBuilder.Create */ 
						{
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal Callback() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

				}

		}

		/// <java-name>
		/// android/speech/RecognizerIntent
		/// </java-name>
		[Dot42.DexImport("android/speech/RecognizerIntent", AccessFlags = 33)]
		public partial class RecognizerIntent
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// EXTRA_CALLING_PACKAGE
				/// </java-name>
				[Dot42.DexImport("EXTRA_CALLING_PACKAGE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_CALLING_PACKAGE = "calling_package";
				/// <java-name>
				/// ACTION_RECOGNIZE_SPEECH
				/// </java-name>
				[Dot42.DexImport("ACTION_RECOGNIZE_SPEECH", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_RECOGNIZE_SPEECH = "android.speech.action.RECOGNIZE_SPEECH";
				/// <java-name>
				/// ACTION_WEB_SEARCH
				/// </java-name>
				[Dot42.DexImport("ACTION_WEB_SEARCH", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_WEB_SEARCH = "android.speech.action.WEB_SEARCH";
				/// <java-name>
				/// EXTRA_SPEECH_INPUT_MINIMUM_LENGTH_MILLIS
				/// </java-name>
				[Dot42.DexImport("EXTRA_SPEECH_INPUT_MINIMUM_LENGTH_MILLIS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_SPEECH_INPUT_MINIMUM_LENGTH_MILLIS = "android.speech.extras.SPEECH_INPUT_MINIMUM_LENGTH_MILLIS";
				/// <java-name>
				/// EXTRA_SPEECH_INPUT_COMPLETE_SILENCE_LENGTH_MILLIS
				/// </java-name>
				[Dot42.DexImport("EXTRA_SPEECH_INPUT_COMPLETE_SILENCE_LENGTH_MILLIS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_SPEECH_INPUT_COMPLETE_SILENCE_LENGTH_MILLIS = "android.speech.extras.SPEECH_INPUT_COMPLETE_SILENCE_LENGTH_MILLIS";
				/// <java-name>
				/// EXTRA_SPEECH_INPUT_POSSIBLY_COMPLETE_SILENCE_LENGTH_MILLIS
				/// </java-name>
				[Dot42.DexImport("EXTRA_SPEECH_INPUT_POSSIBLY_COMPLETE_SILENCE_LENGTH_MILLIS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_SPEECH_INPUT_POSSIBLY_COMPLETE_SILENCE_LENGTH_MILLIS = "android.speech.extras.SPEECH_INPUT_POSSIBLY_COMPLETE_SILENCE_LENGTH_MILLIS";
				/// <java-name>
				/// EXTRA_LANGUAGE_MODEL
				/// </java-name>
				[Dot42.DexImport("EXTRA_LANGUAGE_MODEL", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_LANGUAGE_MODEL = "android.speech.extra.LANGUAGE_MODEL";
				/// <java-name>
				/// LANGUAGE_MODEL_FREE_FORM
				/// </java-name>
				[Dot42.DexImport("LANGUAGE_MODEL_FREE_FORM", "Ljava/lang/String;", AccessFlags = 25)]
				public const string LANGUAGE_MODEL_FREE_FORM = "free_form";
				/// <java-name>
				/// LANGUAGE_MODEL_WEB_SEARCH
				/// </java-name>
				[Dot42.DexImport("LANGUAGE_MODEL_WEB_SEARCH", "Ljava/lang/String;", AccessFlags = 25)]
				public const string LANGUAGE_MODEL_WEB_SEARCH = "web_search";
				/// <java-name>
				/// EXTRA_PROMPT
				/// </java-name>
				[Dot42.DexImport("EXTRA_PROMPT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_PROMPT = "android.speech.extra.PROMPT";
				/// <java-name>
				/// EXTRA_LANGUAGE
				/// </java-name>
				[Dot42.DexImport("EXTRA_LANGUAGE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_LANGUAGE = "android.speech.extra.LANGUAGE";
				/// <java-name>
				/// EXTRA_ORIGIN
				/// </java-name>
				[Dot42.DexImport("EXTRA_ORIGIN", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_ORIGIN = "android.speech.extra.ORIGIN";
				/// <java-name>
				/// EXTRA_MAX_RESULTS
				/// </java-name>
				[Dot42.DexImport("EXTRA_MAX_RESULTS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_MAX_RESULTS = "android.speech.extra.MAX_RESULTS";
				/// <java-name>
				/// EXTRA_WEB_SEARCH_ONLY
				/// </java-name>
				[Dot42.DexImport("EXTRA_WEB_SEARCH_ONLY", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_WEB_SEARCH_ONLY = "android.speech.extra.WEB_SEARCH_ONLY";
				/// <java-name>
				/// EXTRA_PARTIAL_RESULTS
				/// </java-name>
				[Dot42.DexImport("EXTRA_PARTIAL_RESULTS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_PARTIAL_RESULTS = "android.speech.extra.PARTIAL_RESULTS";
				/// <java-name>
				/// EXTRA_RESULTS_PENDINGINTENT
				/// </java-name>
				[Dot42.DexImport("EXTRA_RESULTS_PENDINGINTENT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_RESULTS_PENDINGINTENT = "android.speech.extra.RESULTS_PENDINGINTENT";
				/// <java-name>
				/// EXTRA_RESULTS_PENDINGINTENT_BUNDLE
				/// </java-name>
				[Dot42.DexImport("EXTRA_RESULTS_PENDINGINTENT_BUNDLE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_RESULTS_PENDINGINTENT_BUNDLE = "android.speech.extra.RESULTS_PENDINGINTENT_BUNDLE";
				/// <java-name>
				/// RESULT_NO_MATCH
				/// </java-name>
				[Dot42.DexImport("RESULT_NO_MATCH", "I", AccessFlags = 25)]
				public const int RESULT_NO_MATCH = 1;
				/// <java-name>
				/// RESULT_CLIENT_ERROR
				/// </java-name>
				[Dot42.DexImport("RESULT_CLIENT_ERROR", "I", AccessFlags = 25)]
				public const int RESULT_CLIENT_ERROR = 2;
				/// <java-name>
				/// RESULT_SERVER_ERROR
				/// </java-name>
				[Dot42.DexImport("RESULT_SERVER_ERROR", "I", AccessFlags = 25)]
				public const int RESULT_SERVER_ERROR = 3;
				/// <java-name>
				/// RESULT_NETWORK_ERROR
				/// </java-name>
				[Dot42.DexImport("RESULT_NETWORK_ERROR", "I", AccessFlags = 25)]
				public const int RESULT_NETWORK_ERROR = 4;
				/// <java-name>
				/// RESULT_AUDIO_ERROR
				/// </java-name>
				[Dot42.DexImport("RESULT_AUDIO_ERROR", "I", AccessFlags = 25)]
				public const int RESULT_AUDIO_ERROR = 5;
				/// <java-name>
				/// EXTRA_RESULTS
				/// </java-name>
				[Dot42.DexImport("EXTRA_RESULTS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_RESULTS = "android.speech.extra.RESULTS";
				/// <java-name>
				/// EXTRA_CONFIDENCE_SCORES
				/// </java-name>
				[Dot42.DexImport("EXTRA_CONFIDENCE_SCORES", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_CONFIDENCE_SCORES = "android.speech.extra.CONFIDENCE_SCORES";
				/// <java-name>
				/// DETAILS_META_DATA
				/// </java-name>
				[Dot42.DexImport("DETAILS_META_DATA", "Ljava/lang/String;", AccessFlags = 25)]
				public const string DETAILS_META_DATA = "android.speech.DETAILS";
				/// <java-name>
				/// ACTION_GET_LANGUAGE_DETAILS
				/// </java-name>
				[Dot42.DexImport("ACTION_GET_LANGUAGE_DETAILS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_GET_LANGUAGE_DETAILS = "android.speech.action.GET_LANGUAGE_DETAILS";
				/// <java-name>
				/// EXTRA_ONLY_RETURN_LANGUAGE_PREFERENCE
				/// </java-name>
				[Dot42.DexImport("EXTRA_ONLY_RETURN_LANGUAGE_PREFERENCE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_ONLY_RETURN_LANGUAGE_PREFERENCE = "android.speech.extra.ONLY_RETURN_LANGUAGE_PREFERENCE";
				/// <java-name>
				/// EXTRA_LANGUAGE_PREFERENCE
				/// </java-name>
				[Dot42.DexImport("EXTRA_LANGUAGE_PREFERENCE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_LANGUAGE_PREFERENCE = "android.speech.extra.LANGUAGE_PREFERENCE";
				/// <java-name>
				/// EXTRA_SUPPORTED_LANGUAGES
				/// </java-name>
				[Dot42.DexImport("EXTRA_SUPPORTED_LANGUAGES", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_SUPPORTED_LANGUAGES = "android.speech.extra.SUPPORTED_LANGUAGES";
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal RecognizerIntent() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getVoiceDetailsIntent
				/// </java-name>
				[Dot42.DexImport("getVoiceDetailsIntent", "(Landroid/content/Context;)Landroid/content/Intent;", AccessFlags = 25)]
				public static global::Android.Content.Intent GetVoiceDetailsIntent(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Intent);
				}

		}

		/// <java-name>
		/// android/speech/RecognizerResultsIntent
		/// </java-name>
		[Dot42.DexImport("android/speech/RecognizerResultsIntent", AccessFlags = 33)]
		public partial class RecognizerResultsIntent
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// ACTION_VOICE_SEARCH_RESULTS
				/// </java-name>
				[Dot42.DexImport("ACTION_VOICE_SEARCH_RESULTS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_VOICE_SEARCH_RESULTS = "android.speech.action.VOICE_SEARCH_RESULTS";
				/// <java-name>
				/// EXTRA_VOICE_SEARCH_RESULT_STRINGS
				/// </java-name>
				[Dot42.DexImport("EXTRA_VOICE_SEARCH_RESULT_STRINGS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_VOICE_SEARCH_RESULT_STRINGS = "android.speech.extras.VOICE_SEARCH_RESULT_STRINGS";
				/// <java-name>
				/// EXTRA_VOICE_SEARCH_RESULT_URLS
				/// </java-name>
				[Dot42.DexImport("EXTRA_VOICE_SEARCH_RESULT_URLS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_VOICE_SEARCH_RESULT_URLS = "android.speech.extras.VOICE_SEARCH_RESULT_URLS";
				/// <java-name>
				/// EXTRA_VOICE_SEARCH_RESULT_HTML
				/// </java-name>
				[Dot42.DexImport("EXTRA_VOICE_SEARCH_RESULT_HTML", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_VOICE_SEARCH_RESULT_HTML = "android.speech.extras.VOICE_SEARCH_RESULT_HTML";
				/// <java-name>
				/// EXTRA_VOICE_SEARCH_RESULT_HTML_BASE_URLS
				/// </java-name>
				[Dot42.DexImport("EXTRA_VOICE_SEARCH_RESULT_HTML_BASE_URLS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_VOICE_SEARCH_RESULT_HTML_BASE_URLS = "android.speech.extras.VOICE_SEARCH_RESULT_HTML_BASE_URLS";
				/// <java-name>
				/// EXTRA_VOICE_SEARCH_RESULT_HTTP_HEADERS
				/// </java-name>
				[Dot42.DexImport("EXTRA_VOICE_SEARCH_RESULT_HTTP_HEADERS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_VOICE_SEARCH_RESULT_HTTP_HEADERS = "android.speech.extras.EXTRA_VOICE_SEARCH_RESULT_HTTP_HEADERS";
				/// <java-name>
				/// URI_SCHEME_INLINE
				/// </java-name>
				[Dot42.DexImport("URI_SCHEME_INLINE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string URI_SCHEME_INLINE = "inline";
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal RecognizerResultsIntent() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// android/speech/SpeechRecognizer
		/// </java-name>
		[Dot42.DexImport("android/speech/SpeechRecognizer", AccessFlags = 33)]
		public partial class SpeechRecognizer
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// RESULTS_RECOGNITION
				/// </java-name>
				[Dot42.DexImport("RESULTS_RECOGNITION", "Ljava/lang/String;", AccessFlags = 25)]
				public const string RESULTS_RECOGNITION = "results_recognition";
				/// <java-name>
				/// CONFIDENCE_SCORES
				/// </java-name>
				[Dot42.DexImport("CONFIDENCE_SCORES", "Ljava/lang/String;", AccessFlags = 25)]
				public const string CONFIDENCE_SCORES = "confidence_scores";
				/// <java-name>
				/// ERROR_NETWORK_TIMEOUT
				/// </java-name>
				[Dot42.DexImport("ERROR_NETWORK_TIMEOUT", "I", AccessFlags = 25)]
				public const int ERROR_NETWORK_TIMEOUT = 1;
				/// <java-name>
				/// ERROR_NETWORK
				/// </java-name>
				[Dot42.DexImport("ERROR_NETWORK", "I", AccessFlags = 25)]
				public const int ERROR_NETWORK = 2;
				/// <java-name>
				/// ERROR_AUDIO
				/// </java-name>
				[Dot42.DexImport("ERROR_AUDIO", "I", AccessFlags = 25)]
				public const int ERROR_AUDIO = 3;
				/// <java-name>
				/// ERROR_SERVER
				/// </java-name>
				[Dot42.DexImport("ERROR_SERVER", "I", AccessFlags = 25)]
				public const int ERROR_SERVER = 4;
				/// <java-name>
				/// ERROR_CLIENT
				/// </java-name>
				[Dot42.DexImport("ERROR_CLIENT", "I", AccessFlags = 25)]
				public const int ERROR_CLIENT = 5;
				/// <java-name>
				/// ERROR_SPEECH_TIMEOUT
				/// </java-name>
				[Dot42.DexImport("ERROR_SPEECH_TIMEOUT", "I", AccessFlags = 25)]
				public const int ERROR_SPEECH_TIMEOUT = 6;
				/// <java-name>
				/// ERROR_NO_MATCH
				/// </java-name>
				[Dot42.DexImport("ERROR_NO_MATCH", "I", AccessFlags = 25)]
				public const int ERROR_NO_MATCH = 7;
				/// <java-name>
				/// ERROR_RECOGNIZER_BUSY
				/// </java-name>
				[Dot42.DexImport("ERROR_RECOGNIZER_BUSY", "I", AccessFlags = 25)]
				public const int ERROR_RECOGNIZER_BUSY = 8;
				/// <java-name>
				/// ERROR_INSUFFICIENT_PERMISSIONS
				/// </java-name>
				[Dot42.DexImport("ERROR_INSUFFICIENT_PERMISSIONS", "I", AccessFlags = 25)]
				public const int ERROR_INSUFFICIENT_PERMISSIONS = 9;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal SpeechRecognizer() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isRecognitionAvailable
				/// </java-name>
				[Dot42.DexImport("isRecognitionAvailable", "(Landroid/content/Context;)Z", AccessFlags = 9)]
				public static bool IsRecognitionAvailable(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// createSpeechRecognizer
				/// </java-name>
				[Dot42.DexImport("createSpeechRecognizer", "(Landroid/content/Context;)Landroid/speech/SpeechRecognizer;", AccessFlags = 9)]
				public static global::Android.Speech.SpeechRecognizer CreateSpeechRecognizer(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Speech.SpeechRecognizer);
				}

				/// <java-name>
				/// createSpeechRecognizer
				/// </java-name>
				[Dot42.DexImport("createSpeechRecognizer", "(Landroid/content/Context;Landroid/content/ComponentName;)Landroid/speech/SpeechR" +
    "ecognizer;", AccessFlags = 9)]
				public static global::Android.Speech.SpeechRecognizer CreateSpeechRecognizer(global::Android.Content.Context context, global::Android.Content.ComponentName componentName) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Speech.SpeechRecognizer);
				}

				/// <java-name>
				/// setRecognitionListener
				/// </java-name>
				[Dot42.DexImport("setRecognitionListener", "(Landroid/speech/RecognitionListener;)V", AccessFlags = 1)]
				public virtual void SetRecognitionListener(global::Android.Speech.IRecognitionListener recognitionListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// startListening
				/// </java-name>
				[Dot42.DexImport("startListening", "(Landroid/content/Intent;)V", AccessFlags = 1)]
				public virtual void StartListening(global::Android.Content.Intent intent) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// stopListening
				/// </java-name>
				[Dot42.DexImport("stopListening", "()V", AccessFlags = 1)]
				public virtual void StopListening() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// cancel
				/// </java-name>
				[Dot42.DexImport("cancel", "()V", AccessFlags = 1)]
				public virtual void Cancel() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// destroy
				/// </java-name>
				[Dot42.DexImport("destroy", "()V", AccessFlags = 1)]
				public virtual void Destroy() /* MethodBuilder.Create */ 
				{
				}

		}

}

