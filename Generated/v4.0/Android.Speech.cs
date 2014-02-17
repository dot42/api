// Copyright (C) 2014 dot42
//
// Original filename: Android.Speech.cs
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
namespace Android.Speech
{
		/// <summary>
		/// <para>This class provides access to the speech recognition service. This service allows access to the speech recognizer. Do not instantiate this class directly, instead, call SpeechRecognizer#createSpeechRecognizer(Context). This class's methods must be invoked only from the main application thread. Please note that the application must have android.Manifest.permission#RECORD_AUDIO permission to use this class. </para>    
		/// </summary>
		/// <java-name>
		/// android/speech/SpeechRecognizer
		/// </java-name>
		[Dot42.DexImport("android/speech/SpeechRecognizer", AccessFlags = 33)]
		public partial class SpeechRecognizer
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Key used to retrieve an <c> ArrayList&lt;String&gt; </c> from the Bundle passed to the RecognitionListener#onResults(Bundle) and RecognitionListener#onPartialResults(Bundle) methods. These strings are the possible recognition results, where the first element is the most likely candidate. </para>        
				/// </summary>
				/// <java-name>
				/// RESULTS_RECOGNITION
				/// </java-name>
				[Dot42.DexImport("RESULTS_RECOGNITION", "Ljava/lang/String;", AccessFlags = 25)]
				public const string RESULTS_RECOGNITION = "results_recognition";
				/// <summary>
				/// <para>Key used to retrieve a float array from the Bundle passed to the RecognitionListener#onResults(Bundle) and RecognitionListener#onPartialResults(Bundle) methods. The array should be the same size as the ArrayList provided in RESULTS_RECOGNITION, and should contain values ranging from 0.0 to 1.0, or -1 to represent an unavailable confidence score. </para><para>Confidence values close to 1.0 indicate high confidence (the speech recognizer is confident that the recognition result is correct), while values close to 0.0 indicate low confidence. </para><para>This value is optional and might not be provided. </para>        
				/// </summary>
				/// <java-name>
				/// CONFIDENCE_SCORES
				/// </java-name>
				[Dot42.DexImport("CONFIDENCE_SCORES", "Ljava/lang/String;", AccessFlags = 25)]
				public const string CONFIDENCE_SCORES = "confidence_scores";
				/// <summary>
				/// <para>Network operation timed out. </para>        
				/// </summary>
				/// <java-name>
				/// ERROR_NETWORK_TIMEOUT
				/// </java-name>
				[Dot42.DexImport("ERROR_NETWORK_TIMEOUT", "I", AccessFlags = 25)]
				public const int ERROR_NETWORK_TIMEOUT = 1;
				/// <summary>
				/// <para>Other network related errors. </para>        
				/// </summary>
				/// <java-name>
				/// ERROR_NETWORK
				/// </java-name>
				[Dot42.DexImport("ERROR_NETWORK", "I", AccessFlags = 25)]
				public const int ERROR_NETWORK = 2;
				/// <summary>
				/// <para>Audio recording error. </para>        
				/// </summary>
				/// <java-name>
				/// ERROR_AUDIO
				/// </java-name>
				[Dot42.DexImport("ERROR_AUDIO", "I", AccessFlags = 25)]
				public const int ERROR_AUDIO = 3;
				/// <summary>
				/// <para>Server sends error status. </para>        
				/// </summary>
				/// <java-name>
				/// ERROR_SERVER
				/// </java-name>
				[Dot42.DexImport("ERROR_SERVER", "I", AccessFlags = 25)]
				public const int ERROR_SERVER = 4;
				/// <summary>
				/// <para>Other client side errors. </para>        
				/// </summary>
				/// <java-name>
				/// ERROR_CLIENT
				/// </java-name>
				[Dot42.DexImport("ERROR_CLIENT", "I", AccessFlags = 25)]
				public const int ERROR_CLIENT = 5;
				/// <summary>
				/// <para>No speech input </para>        
				/// </summary>
				/// <java-name>
				/// ERROR_SPEECH_TIMEOUT
				/// </java-name>
				[Dot42.DexImport("ERROR_SPEECH_TIMEOUT", "I", AccessFlags = 25)]
				public const int ERROR_SPEECH_TIMEOUT = 6;
				/// <summary>
				/// <para>No recognition result matched. </para>        
				/// </summary>
				/// <java-name>
				/// ERROR_NO_MATCH
				/// </java-name>
				[Dot42.DexImport("ERROR_NO_MATCH", "I", AccessFlags = 25)]
				public const int ERROR_NO_MATCH = 7;
				/// <summary>
				/// <para>RecognitionService busy. </para>        
				/// </summary>
				/// <java-name>
				/// ERROR_RECOGNIZER_BUSY
				/// </java-name>
				[Dot42.DexImport("ERROR_RECOGNIZER_BUSY", "I", AccessFlags = 25)]
				public const int ERROR_RECOGNIZER_BUSY = 8;
				/// <summary>
				/// <para>Insufficient permissions </para>        
				/// </summary>
				/// <java-name>
				/// ERROR_INSUFFICIENT_PERMISSIONS
				/// </java-name>
				[Dot42.DexImport("ERROR_INSUFFICIENT_PERMISSIONS", "I", AccessFlags = 25)]
				public const int ERROR_INSUFFICIENT_PERMISSIONS = 9;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal SpeechRecognizer() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Checks whether a speech recognition service is available on the system. If this method returns <c> false </c> , SpeechRecognizer#createSpeechRecognizer(Context) will fail.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if recognition is available, <c> false </c> otherwise </para>
				/// </returns>
				/// <java-name>
				/// isRecognitionAvailable
				/// </java-name>
				[Dot42.DexImport("isRecognitionAvailable", "(Landroid/content/Context;)Z", AccessFlags = 9)]
				public static bool IsRecognitionAvailable(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Factory method to create a new <c> SpeechRecognizer </c> . Please note that setRecognitionListener(RecognitionListener) should be called before dispatching any command to the created <c> SpeechRecognizer </c> , otherwise no notifications will be received.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a new <c> SpeechRecognizer </c> </para>
				/// </returns>
				/// <java-name>
				/// createSpeechRecognizer
				/// </java-name>
				[Dot42.DexImport("createSpeechRecognizer", "(Landroid/content/Context;)Landroid/speech/SpeechRecognizer;", AccessFlags = 9)]
				public static global::Android.Speech.SpeechRecognizer CreateSpeechRecognizer(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Speech.SpeechRecognizer);
				}

				/// <summary>
				/// <para>Factory method to create a new <c> SpeechRecognizer </c> . Please note that setRecognitionListener(RecognitionListener) should be called before dispatching any command to the created <c> SpeechRecognizer </c> , otherwise no notifications will be received.</para><para>Use this version of the method to specify a specific service to direct this SpeechRecognizer to. Normally you would not use this; use createSpeechRecognizer(Context) instead to use the system default recognition service.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a new <c> SpeechRecognizer </c> </para>
				/// </returns>
				/// <java-name>
				/// createSpeechRecognizer
				/// </java-name>
				[Dot42.DexImport("createSpeechRecognizer", "(Landroid/content/Context;Landroid/content/ComponentName;)Landroid/speech/SpeechR" +
    "ecognizer;", AccessFlags = 9)]
				public static global::Android.Speech.SpeechRecognizer CreateSpeechRecognizer(global::Android.Content.Context context, global::Android.Content.ComponentName serviceComponent) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Speech.SpeechRecognizer);
				}

				/// <summary>
				/// <para>Sets the listener that will receive all the callbacks. The previous unfinished commands will be executed with the old listener, while any following command will be executed with the new listener.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setRecognitionListener
				/// </java-name>
				[Dot42.DexImport("setRecognitionListener", "(Landroid/speech/RecognitionListener;)V", AccessFlags = 1)]
				public virtual void SetRecognitionListener(global::Android.Speech.IRecognitionListener listener) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Starts listening for speech. Please note that setRecognitionListener(RecognitionListener) should be called beforehand, otherwise no notifications will be received.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// startListening
				/// </java-name>
				[Dot42.DexImport("startListening", "(Landroid/content/Intent;)V", AccessFlags = 1)]
				public virtual void StartListening(global::Android.Content.Intent recognizerIntent) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Stops listening for speech. Speech captured so far will be recognized as if the user had stopped speaking at this point. Note that in the default case, this does not need to be called, as the speech endpointer will automatically stop the recognizer listening when it determines speech has completed. However, you can manipulate endpointer parameters directly using the intent extras defined in RecognizerIntent, in which case you may sometimes want to manually call this method to stop listening sooner. Please note that setRecognitionListener(RecognitionListener) should be called beforehand, otherwise no notifications will be received. </para>        
				/// </summary>
				/// <java-name>
				/// stopListening
				/// </java-name>
				[Dot42.DexImport("stopListening", "()V", AccessFlags = 1)]
				public virtual void StopListening() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Cancels the speech recognition. Please note that setRecognitionListener(RecognitionListener) should be called beforehand, otherwise no notifications will be received. </para>        
				/// </summary>
				/// <java-name>
				/// cancel
				/// </java-name>
				[Dot42.DexImport("cancel", "()V", AccessFlags = 1)]
				public virtual void Cancel() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Destroys the <c> SpeechRecognizer </c> object. </para>        
				/// </summary>
				/// <java-name>
				/// destroy
				/// </java-name>
				[Dot42.DexImport("destroy", "()V", AccessFlags = 1)]
				public virtual void Destroy() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>Constants for supporting speech recognition through starting an Intent </para>    
		/// </summary>
		/// <java-name>
		/// android/speech/RecognizerIntent
		/// </java-name>
		[Dot42.DexImport("android/speech/RecognizerIntent", AccessFlags = 33)]
		public partial class RecognizerIntent
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>The extra key used in an intent to the speech recognizer for voice search. Not generally to be used by developers. The system search dialog uses this, for example, to set a calling package for identification by a voice search API. If this extra is set by anyone but the system process, it should be overridden by the voice search implementation. </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_CALLING_PACKAGE
				/// </java-name>
				[Dot42.DexImport("EXTRA_CALLING_PACKAGE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_CALLING_PACKAGE = "calling_package";
				/// <summary>
				/// <para>Starts an activity that will prompt the user for speech and send it through a speech recognizer. The results will be returned via activity results (in Activity#onActivityResult, if you start the intent using Activity#startActivityForResult(Intent, int)), or forwarded via a PendingIntent if one is provided.</para><para>Starting this intent with just Activity#startActivity(Intent) is not supported. You must either use Activity#startActivityForResult(Intent, int), or provide a PendingIntent, to receive recognition results.</para><para>Required extras: <ul><li><para>EXTRA_LANGUAGE_MODEL </para></li></ul></para><para>Optional extras: <ul><li><para>EXTRA_PROMPT </para></li><li><para>EXTRA_LANGUAGE </para></li><li><para>EXTRA_MAX_RESULTS </para></li><li><para>EXTRA_RESULTS_PENDINGINTENT </para></li><li><para>EXTRA_RESULTS_PENDINGINTENT_BUNDLE </para></li></ul></para><para>Result extras (returned in the result, not to be specified in the request): <ul><li><para>EXTRA_RESULTS </para></li></ul></para><para>NOTE: There may not be any applications installed to handle this action, so you should make sure to catch ActivityNotFoundException. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_RECOGNIZE_SPEECH
				/// </java-name>
				[Dot42.DexImport("ACTION_RECOGNIZE_SPEECH", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_RECOGNIZE_SPEECH = "android.speech.action.RECOGNIZE_SPEECH";
				/// <summary>
				/// <para>Starts an activity that will prompt the user for speech, send it through a speech recognizer, and either display a web search result or trigger another type of action based on the user's speech.</para><para>If you want to avoid triggering any type of action besides web search, you can use the EXTRA_WEB_SEARCH_ONLY extra.</para><para>Required extras: <ul><li><para>EXTRA_LANGUAGE_MODEL </para></li></ul></para><para>Optional extras: <ul><li><para>EXTRA_PROMPT </para></li><li><para>EXTRA_LANGUAGE </para></li><li><para>EXTRA_MAX_RESULTS </para></li><li><para>EXTRA_PARTIAL_RESULTS </para></li><li><para>EXTRA_WEB_SEARCH_ONLY </para></li><li><para>EXTRA_ORIGIN </para></li></ul></para><para>Result extras (returned in the result, not to be specified in the request): <ul><li><para>EXTRA_RESULTS </para></li><li><para>EXTRA_CONFIDENCE_SCORES (optional) </para></li></ul></para><para>NOTE: There may not be any applications installed to handle this action, so you should make sure to catch ActivityNotFoundException. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_WEB_SEARCH
				/// </java-name>
				[Dot42.DexImport("ACTION_WEB_SEARCH", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_WEB_SEARCH = "android.speech.action.WEB_SEARCH";
				/// <summary>
				/// <para>The minimum length of an utterance. We will not stop recording before this amount of time.</para><para>Note that it is extremely rare you'd want to specify this value in an intent. If you don't have a very good reason to change these, you should leave them as they are. Note also that certain values may cause undesired or unexpected results - use judiciously! Additionally, depending on the recognizer implementation, these values may have no effect. </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_SPEECH_INPUT_MINIMUM_LENGTH_MILLIS
				/// </java-name>
				[Dot42.DexImport("EXTRA_SPEECH_INPUT_MINIMUM_LENGTH_MILLIS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_SPEECH_INPUT_MINIMUM_LENGTH_MILLIS = "android.speech.extras.SPEECH_INPUT_MINIMUM_LENGTH_MILLIS";
				/// <summary>
				/// <para>The amount of time that it should take after we stop hearing speech to consider the input complete.</para><para>Note that it is extremely rare you'd want to specify this value in an intent. If you don't have a very good reason to change these, you should leave them as they are. Note also that certain values may cause undesired or unexpected results - use judiciously! Additionally, depending on the recognizer implementation, these values may have no effect. </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_SPEECH_INPUT_COMPLETE_SILENCE_LENGTH_MILLIS
				/// </java-name>
				[Dot42.DexImport("EXTRA_SPEECH_INPUT_COMPLETE_SILENCE_LENGTH_MILLIS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_SPEECH_INPUT_COMPLETE_SILENCE_LENGTH_MILLIS = "android.speech.extras.SPEECH_INPUT_COMPLETE_SILENCE_LENGTH_MILLIS";
				/// <summary>
				/// <para>The amount of time that it should take after we stop hearing speech to consider the input possibly complete. This is used to prevent the endpointer cutting off during very short mid-speech pauses.</para><para>Note that it is extremely rare you'd want to specify this value in an intent. If you don't have a very good reason to change these, you should leave them as they are. Note also that certain values may cause undesired or unexpected results - use judiciously! Additionally, depending on the recognizer implementation, these values may have no effect. </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_SPEECH_INPUT_POSSIBLY_COMPLETE_SILENCE_LENGTH_MILLIS
				/// </java-name>
				[Dot42.DexImport("EXTRA_SPEECH_INPUT_POSSIBLY_COMPLETE_SILENCE_LENGTH_MILLIS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_SPEECH_INPUT_POSSIBLY_COMPLETE_SILENCE_LENGTH_MILLIS = "android.speech.extras.SPEECH_INPUT_POSSIBLY_COMPLETE_SILENCE_LENGTH_MILLIS";
				/// <summary>
				/// <para>Informs the recognizer which speech model to prefer when performing ACTION_RECOGNIZE_SPEECH. The recognizer uses this information to fine tune the results. This extra is required. Activities implementing ACTION_RECOGNIZE_SPEECH may interpret the values as they see fit.</para><para><para>LANGUAGE_MODEL_FREE_FORM </para><simplesectsep></simplesectsep><para>LANGUAGE_MODEL_WEB_SEARCH </para></para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_LANGUAGE_MODEL
				/// </java-name>
				[Dot42.DexImport("EXTRA_LANGUAGE_MODEL", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_LANGUAGE_MODEL = "android.speech.extra.LANGUAGE_MODEL";
				/// <summary>
				/// <para>Use a language model based on free-form speech recognition. This is a value to use for EXTRA_LANGUAGE_MODEL. <para>EXTRA_LANGUAGE_MODEL </para></para>        
				/// </summary>
				/// <java-name>
				/// LANGUAGE_MODEL_FREE_FORM
				/// </java-name>
				[Dot42.DexImport("LANGUAGE_MODEL_FREE_FORM", "Ljava/lang/String;", AccessFlags = 25)]
				public const string LANGUAGE_MODEL_FREE_FORM = "free_form";
				/// <summary>
				/// <para>Use a language model based on web search terms. This is a value to use for EXTRA_LANGUAGE_MODEL. <para>EXTRA_LANGUAGE_MODEL </para></para>        
				/// </summary>
				/// <java-name>
				/// LANGUAGE_MODEL_WEB_SEARCH
				/// </java-name>
				[Dot42.DexImport("LANGUAGE_MODEL_WEB_SEARCH", "Ljava/lang/String;", AccessFlags = 25)]
				public const string LANGUAGE_MODEL_WEB_SEARCH = "web_search";
				/// <summary>
				/// <para>Optional text prompt to show to the user when asking them to speak. </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_PROMPT
				/// </java-name>
				[Dot42.DexImport("EXTRA_PROMPT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_PROMPT = "android.speech.extra.PROMPT";
				/// <summary>
				/// <para>Optional IETF language tag (as defined by BCP 47), for example "en-US". This tag informs the recognizer to perform speech recognition in a language different than the one set in the java.util.Locale#getDefault(). </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_LANGUAGE
				/// </java-name>
				[Dot42.DexImport("EXTRA_LANGUAGE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_LANGUAGE = "android.speech.extra.LANGUAGE";
				/// <summary>
				/// <para>Optional value which can be used to indicate the referer url of a page in which speech was requested. For example, a web browser may choose to provide this for uses of speech on a given page. </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_ORIGIN
				/// </java-name>
				[Dot42.DexImport("EXTRA_ORIGIN", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_ORIGIN = "android.speech.extra.ORIGIN";
				/// <summary>
				/// <para>Optional limit on the maximum number of results to return. If omitted the recognizer will choose how many results to return. Must be an integer. </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_MAX_RESULTS
				/// </java-name>
				[Dot42.DexImport("EXTRA_MAX_RESULTS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_MAX_RESULTS = "android.speech.extra.MAX_RESULTS";
				/// <summary>
				/// <para>Optional boolean, to be used with ACTION_WEB_SEARCH, to indicate whether to only fire web searches in response to a user's speech. The default is false, meaning that other types of actions can be taken based on the user's speech. </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_WEB_SEARCH_ONLY
				/// </java-name>
				[Dot42.DexImport("EXTRA_WEB_SEARCH_ONLY", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_WEB_SEARCH_ONLY = "android.speech.extra.WEB_SEARCH_ONLY";
				/// <summary>
				/// <para>Optional boolean to indicate whether partial results should be returned by the recognizer as the user speaks (default is false). The server may ignore a request for partial results in some or all cases. </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_PARTIAL_RESULTS
				/// </java-name>
				[Dot42.DexImport("EXTRA_PARTIAL_RESULTS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_PARTIAL_RESULTS = "android.speech.extra.PARTIAL_RESULTS";
				/// <summary>
				/// <para>When the intent is ACTION_RECOGNIZE_SPEECH, the speech input activity will return results to you via the activity results mechanism. Alternatively, if you use this extra to supply a PendingIntent, the results will be added to its bundle and the PendingIntent will be sent to its target. </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_RESULTS_PENDINGINTENT
				/// </java-name>
				[Dot42.DexImport("EXTRA_RESULTS_PENDINGINTENT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_RESULTS_PENDINGINTENT = "android.speech.extra.RESULTS_PENDINGINTENT";
				/// <summary>
				/// <para>If you use EXTRA_RESULTS_PENDINGINTENT to supply a forwarding intent, you can also use this extra to supply additional extras for the final intent. The search results will be added to this bundle, and the combined bundle will be sent to the target. </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_RESULTS_PENDINGINTENT_BUNDLE
				/// </java-name>
				[Dot42.DexImport("EXTRA_RESULTS_PENDINGINTENT_BUNDLE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_RESULTS_PENDINGINTENT_BUNDLE = "android.speech.extra.RESULTS_PENDINGINTENT_BUNDLE";
				/// <summary>
				/// <para>Result code returned when no matches are found for the given speech </para>        
				/// </summary>
				/// <java-name>
				/// RESULT_NO_MATCH
				/// </java-name>
				[Dot42.DexImport("RESULT_NO_MATCH", "I", AccessFlags = 25)]
				public const int RESULT_NO_MATCH = 1;
				/// <summary>
				/// <para>Result code returned when there is a generic client error </para>        
				/// </summary>
				/// <java-name>
				/// RESULT_CLIENT_ERROR
				/// </java-name>
				[Dot42.DexImport("RESULT_CLIENT_ERROR", "I", AccessFlags = 25)]
				public const int RESULT_CLIENT_ERROR = 2;
				/// <summary>
				/// <para>Result code returned when the recognition server returns an error </para>        
				/// </summary>
				/// <java-name>
				/// RESULT_SERVER_ERROR
				/// </java-name>
				[Dot42.DexImport("RESULT_SERVER_ERROR", "I", AccessFlags = 25)]
				public const int RESULT_SERVER_ERROR = 3;
				/// <summary>
				/// <para>Result code returned when a network error was encountered </para>        
				/// </summary>
				/// <java-name>
				/// RESULT_NETWORK_ERROR
				/// </java-name>
				[Dot42.DexImport("RESULT_NETWORK_ERROR", "I", AccessFlags = 25)]
				public const int RESULT_NETWORK_ERROR = 4;
				/// <summary>
				/// <para>Result code returned when an audio error was encountered </para>        
				/// </summary>
				/// <java-name>
				/// RESULT_AUDIO_ERROR
				/// </java-name>
				[Dot42.DexImport("RESULT_AUDIO_ERROR", "I", AccessFlags = 25)]
				public const int RESULT_AUDIO_ERROR = 5;
				/// <summary>
				/// <para>An ArrayList&lt;String&gt; of the recognition results when performing ACTION_RECOGNIZE_SPEECH. Generally this list should be ordered in descending order of speech recognizer confidence. (See EXTRA_CONFIDENCE_SCORES). Returned in the results; not to be specified in the recognition request. Only present when Activity#RESULT_OK is returned in an activity result. In a PendingIntent, the lack of this extra indicates failure. </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_RESULTS
				/// </java-name>
				[Dot42.DexImport("EXTRA_RESULTS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_RESULTS = "android.speech.extra.RESULTS";
				/// <summary>
				/// <para>A float array of confidence scores of the recognition results when performing ACTION_RECOGNIZE_SPEECH. The array should be the same size as the ArrayList returned in EXTRA_RESULTS, and should contain values ranging from 0.0 to 1.0, or -1 to represent an unavailable confidence score. </para><para>Confidence values close to 1.0 indicate high confidence (the speech recognizer is confident that the recognition result is correct), while values close to 0.0 indicate low confidence. </para><para>Returned in the results; not to be specified in the recognition request. This extra is optional and might not be provided. Only present when Activity#RESULT_OK is returned in an activity result. </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_CONFIDENCE_SCORES
				/// </java-name>
				[Dot42.DexImport("EXTRA_CONFIDENCE_SCORES", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_CONFIDENCE_SCORES = "android.speech.extra.CONFIDENCE_SCORES";
				/// <summary>
				/// <para>Meta-data name under which an Activity implementing ACTION_WEB_SEARCH can use to expose the class name of a BroadcastReceiver which can respond to request for more information, from any of the broadcast intents specified in this class. </para><para>Broadcast intents can be directed to the class name specified in the meta-data by creating an Intent, setting the component with Intent#setComponent(android.content.ComponentName), and using Context#sendOrderedBroadcast(Intent, String, BroadcastReceiver, android.os.Handler, int, String, android.os.Bundle) with another BroadcastReceiver which can receive the results. </para><para>The getVoiceDetailsIntent(Context) method is provided as a convenience to create a broadcast intent based on the value of this meta-data, if available. </para><para>This is optional and not all Activitys which implement ACTION_WEB_SEARCH are required to implement this. Thus retrieving this meta-data may be null. </para>        
				/// </summary>
				/// <java-name>
				/// DETAILS_META_DATA
				/// </java-name>
				[Dot42.DexImport("DETAILS_META_DATA", "Ljava/lang/String;", AccessFlags = 25)]
				public const string DETAILS_META_DATA = "android.speech.DETAILS";
				/// <summary>
				/// <para>A broadcast intent which can be fired to the BroadcastReceiver component specified in the meta-data defined in the DETAILS_META_DATA meta-data of an Activity satisfying ACTION_WEB_SEARCH. </para><para>When fired with Context#sendOrderedBroadcast(Intent, String, BroadcastReceiver, android.os.Handler, int, String, android.os.Bundle), a Bundle of extras will be returned to the provided result receiver, and should ideally contain values for EXTRA_LANGUAGE_PREFERENCE and EXTRA_SUPPORTED_LANGUAGES. </para><para>(Whether these are actually provided is up to the particular implementation. It is recommended that Activitys implementing ACTION_WEB_SEARCH provide this information, but it is not required.) </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_GET_LANGUAGE_DETAILS
				/// </java-name>
				[Dot42.DexImport("ACTION_GET_LANGUAGE_DETAILS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_GET_LANGUAGE_DETAILS = "android.speech.action.GET_LANGUAGE_DETAILS";
				/// <summary>
				/// <para>Specify this boolean extra in a broadcast of ACTION_GET_LANGUAGE_DETAILS to indicate that only the current language preference is needed in the response. This avoids any additional computation if all you need is EXTRA_LANGUAGE_PREFERENCE in the response. </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_ONLY_RETURN_LANGUAGE_PREFERENCE
				/// </java-name>
				[Dot42.DexImport("EXTRA_ONLY_RETURN_LANGUAGE_PREFERENCE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_ONLY_RETURN_LANGUAGE_PREFERENCE = "android.speech.extra.ONLY_RETURN_LANGUAGE_PREFERENCE";
				/// <summary>
				/// <para>The key to the extra in the Bundle returned by ACTION_GET_LANGUAGE_DETAILS which is a String that represents the current language preference this user has specified - a locale string like "en-US". </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_LANGUAGE_PREFERENCE
				/// </java-name>
				[Dot42.DexImport("EXTRA_LANGUAGE_PREFERENCE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_LANGUAGE_PREFERENCE = "android.speech.extra.LANGUAGE_PREFERENCE";
				/// <summary>
				/// <para>The key to the extra in the Bundle returned by ACTION_GET_LANGUAGE_DETAILS which is an ArrayList of Strings that represents the languages supported by this implementation of voice recognition - a list of strings like "en-US", "cmn-Hans-CN", etc. </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_SUPPORTED_LANGUAGES
				/// </java-name>
				[Dot42.DexImport("EXTRA_SUPPORTED_LANGUAGES", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_SUPPORTED_LANGUAGES = "android.speech.extra.SUPPORTED_LANGUAGES";
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal RecognizerIntent() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the broadcast intent to fire with Context#sendOrderedBroadcast(Intent, String, BroadcastReceiver, android.os.Handler, int, String, Bundle) to receive details from the package that implements voice search. </para><para>This is based on the value specified by the voice search Activity in DETAILS_META_DATA, and if this is not specified, will return null. Also if there is no chosen default to resolve for ACTION_WEB_SEARCH, this will return null. </para><para>If an intent is returned and is fired, a Bundle of extras will be returned to the provided result receiver, and should ideally contain values for EXTRA_LANGUAGE_PREFERENCE and EXTRA_SUPPORTED_LANGUAGES. </para><para>(Whether these are actually provided is up to the particular implementation. It is recommended that Activitys implementing ACTION_WEB_SEARCH provide this information, but it is not required.)</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the broadcast intent to fire or null if not available </para>
				/// </returns>
				/// <java-name>
				/// getVoiceDetailsIntent
				/// </java-name>
				[Dot42.DexImport("getVoiceDetailsIntent", "(Landroid/content/Context;)Landroid/content/Intent;", AccessFlags = 25)]
				public static global::Android.Content.Intent GetVoiceDetailsIntent(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Intent);
				}

		}

		/// <summary>
		/// <para>This class provides a base class for recognition service implementations. This class should be extended only in case you wish to implement a new speech recognizer. Please note that the implementation of this service is stateless. </para>    
		/// </summary>
		/// <java-name>
		/// android/speech/RecognitionService
		/// </java-name>
		[Dot42.DexImport("android/speech/RecognitionService", AccessFlags = 1057)]
		public abstract partial class RecognitionService : global::Android.App.Service
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>The Intent that must be declared as handled by the service. </para>        
				/// </summary>
				/// <java-name>
				/// SERVICE_INTERFACE
				/// </java-name>
				[Dot42.DexImport("SERVICE_INTERFACE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SERVICE_INTERFACE = "android.speech.RecognitionService";
				/// <summary>
				/// <para>Name under which a RecognitionService component publishes information about itself. This meta-data should reference an XML resource containing a <code>&lt;recognition-service&gt;</code> tag. </para>        
				/// </summary>
				/// <java-name>
				/// SERVICE_META_DATA
				/// </java-name>
				[Dot42.DexImport("SERVICE_META_DATA", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SERVICE_META_DATA = "android.speech";
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public RecognitionService() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Notifies the service that it should start listening for speech.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// onStartListening
				/// </java-name>
				[Dot42.DexImport("onStartListening", "(Landroid/content/Intent;Landroid/speech/RecognitionService$Callback;)V", AccessFlags = 1028)]
				protected internal abstract void OnStartListening(global::Android.Content.Intent recognizerIntent, global::Android.Speech.RecognitionService.Callback listener) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Notifies the service that it should cancel the speech recognition. </para>        
				/// </summary>
				/// <java-name>
				/// onCancel
				/// </java-name>
				[Dot42.DexImport("onCancel", "(Landroid/speech/RecognitionService$Callback;)V", AccessFlags = 1028)]
				protected internal abstract void OnCancel(global::Android.Speech.RecognitionService.Callback listener) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Notifies the service that it should stop listening for speech. Speech captured so far should be recognized as if the user had stopped speaking at this point. This method is only called if the application calls it explicitly. </para>        
				/// </summary>
				/// <java-name>
				/// onStopListening
				/// </java-name>
				[Dot42.DexImport("onStopListening", "(Landroid/speech/RecognitionService$Callback;)V", AccessFlags = 1028)]
				protected internal abstract void OnStopListening(global::Android.Speech.RecognitionService.Callback listener) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// onBind
				/// </java-name>
				[Dot42.DexImport("onBind", "(Landroid/content/Intent;)Landroid/os/IBinder;", AccessFlags = 17)]
				public override global::Android.Os.IBinder OnBind(global::Android.Content.Intent intent) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Os.IBinder);
				}

				/// <summary>
				/// <para>Called by the system to notify a Service that it is no longer used and is being removed. The service should clean up any resources it holds (threads, registered receivers, etc) at this point. Upon return, there will be no more calls in to this Service object and it is effectively dead. Do not call this method directly. </para>        
				/// </summary>
				/// <java-name>
				/// onDestroy
				/// </java-name>
				[Dot42.DexImport("onDestroy", "()V", AccessFlags = 1)]
				public override void OnDestroy() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>This class receives callbacks from the speech recognition service and forwards them to the user. An instance of this class is passed to the RecognitionService#onStartListening(Intent, Callback) method. Recognizers may call these methods on any thread. </para>    
				/// </summary>
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

						/// <summary>
						/// <para>The service should call this method when the user has started to speak. </para>        
						/// </summary>
						/// <java-name>
						/// beginningOfSpeech
						/// </java-name>
						[Dot42.DexImport("beginningOfSpeech", "()V", AccessFlags = 1)]
						public virtual void BeginningOfSpeech() /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						/// <para>The service should call this method when sound has been received. The purpose of this function is to allow giving feedback to the user regarding the captured audio.</para><para></para>        
						/// </summary>
						/// <java-name>
						/// bufferReceived
						/// </java-name>
						[Dot42.DexImport("bufferReceived", "([B)V", AccessFlags = 1)]
						public virtual void BufferReceived(sbyte[] buffer) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						/// <para>The service should call this method when sound has been received. The purpose of this function is to allow giving feedback to the user regarding the captured audio.</para><para></para>        
						/// </summary>
						/// <java-name>
						/// bufferReceived
						/// </java-name>
						[Dot42.DexImport("bufferReceived", "([B)V", AccessFlags = 1, IgnoreFromJava = true)]
						public virtual void BufferReceived(byte[] buffer) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						/// <para>The service should call this method after the user stops speaking. </para>        
						/// </summary>
						/// <java-name>
						/// endOfSpeech
						/// </java-name>
						[Dot42.DexImport("endOfSpeech", "()V", AccessFlags = 1)]
						public virtual void EndOfSpeech() /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						/// <para>The service should call this method when a network or recognition error occurred.</para><para></para>        
						/// </summary>
						/// <java-name>
						/// error
						/// </java-name>
						[Dot42.DexImport("error", "(I)V", AccessFlags = 1)]
						public virtual void Error(int error) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						/// <para>The service should call this method when partial recognition results are available. This method can be called at any time between beginningOfSpeech() and results(Bundle) when partial results are ready. This method may be called zero, one or multiple times for each call to SpeechRecognizer#startListening(Intent), depending on the speech recognition service implementation.</para><para></para>        
						/// </summary>
						/// <java-name>
						/// partialResults
						/// </java-name>
						[Dot42.DexImport("partialResults", "(Landroid/os/Bundle;)V", AccessFlags = 1)]
						public virtual void PartialResults(global::Android.Os.Bundle partialResults) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						/// <para>The service should call this method when the endpointer is ready for the user to start speaking.</para><para></para>        
						/// </summary>
						/// <java-name>
						/// readyForSpeech
						/// </java-name>
						[Dot42.DexImport("readyForSpeech", "(Landroid/os/Bundle;)V", AccessFlags = 1)]
						public virtual void ReadyForSpeech(global::Android.Os.Bundle @params) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						/// <para>The service should call this method when recognition results are ready.</para><para></para>        
						/// </summary>
						/// <java-name>
						/// results
						/// </java-name>
						[Dot42.DexImport("results", "(Landroid/os/Bundle;)V", AccessFlags = 1)]
						public virtual void Results(global::Android.Os.Bundle results) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						/// <para>The service should call this method when the sound level in the audio stream has changed. There is no guarantee that this method will be called.</para><para></para>        
						/// </summary>
						/// <java-name>
						/// rmsChanged
						/// </java-name>
						[Dot42.DexImport("rmsChanged", "(F)V", AccessFlags = 1)]
						public virtual void RmsChanged(float rmsdB) /* MethodBuilder.Create */ 
						{
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal Callback() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

				}

		}

		/// <summary>
		/// <para>Constants for intents related to showing speech recognition results.</para><para>These constants should not be needed for normal utilization of speech recognition. They would only be called if you wanted to trigger a view of voice search results in your application, or implemented if you wanted to offer a different view for voice search results with your application.</para><para>The standard behavior here for someone receiving an ACTION_VOICE_SEARCH_RESULTS is to first retrieve the list of EXTRA_VOICE_SEARCH_RESULT_STRINGS, and use any provided HTML for that result in EXTRA_VOICE_SEARCH_RESULT_HTML, if available, to display the search results. If that is not available, then the corresponding url for that result in EXTRA_VOICE_SEARCH_RESULT_URLS should be used. And if even that is not available, then a search url should be constructed from the actual recognition result string. </para>    
		/// </summary>
		/// <java-name>
		/// android/speech/RecognizerResultsIntent
		/// </java-name>
		[Dot42.DexImport("android/speech/RecognizerResultsIntent", AccessFlags = 33)]
		public partial class RecognizerResultsIntent
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Intent that can be sent by implementations of voice search to display the results of a search in, for example, a web browser.</para><para>This intent should always be accompanied by at least EXTRA_VOICE_SEARCH_RESULT_STRINGS, and optionally but recommended, EXTRA_VOICE_SEARCH_RESULT_URLS, and sometimes EXTRA_VOICE_SEARCH_RESULT_HTML and EXTRA_VOICE_SEARCH_RESULT_HTML_BASE_URLS.</para><para>These are parallel arrays, where a recognition result string at index N of EXTRA_VOICE_SEARCH_RESULT_STRINGS should be accompanied by a url to use for searching based on that string at index N of EXTRA_VOICE_SEARCH_RESULT_URLS, and, possibly, the full html to display for that result at index N of EXTRA_VOICE_SEARCH_RESULT_HTML. If full html is provided, a base url (or list of base urls) should be provided with EXTRA_VOICE_SEARCH_RESULT_HTML_BASE_URLS. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_VOICE_SEARCH_RESULTS
				/// </java-name>
				[Dot42.DexImport("ACTION_VOICE_SEARCH_RESULTS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_VOICE_SEARCH_RESULTS = "android.speech.action.VOICE_SEARCH_RESULTS";
				/// <summary>
				/// <para>The key to an extra ArrayList of Strings that contains the list of recognition alternates from voice search, in order from highest to lowest confidence. </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_VOICE_SEARCH_RESULT_STRINGS
				/// </java-name>
				[Dot42.DexImport("EXTRA_VOICE_SEARCH_RESULT_STRINGS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_VOICE_SEARCH_RESULT_STRINGS = "android.speech.extras.VOICE_SEARCH_RESULT_STRINGS";
				/// <summary>
				/// <para>The key to an extra ArrayList of Strings that contains the search urls to use, if available, for the recognition alternates provided in EXTRA_VOICE_SEARCH_RESULT_STRINGS. This list should always be the same size as the one provided in EXTRA_VOICE_SEARCH_RESULT_STRINGS - if a result cannot provide a search url, that entry in this ArrayList should be <code>null</code>, and the implementor of ACTION_VOICE_SEARCH_RESULTS should execute a search of its own choosing, based on the recognition result string. </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_VOICE_SEARCH_RESULT_URLS
				/// </java-name>
				[Dot42.DexImport("EXTRA_VOICE_SEARCH_RESULT_URLS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_VOICE_SEARCH_RESULT_URLS = "android.speech.extras.VOICE_SEARCH_RESULT_URLS";
				/// <summary>
				/// <para>The key to an extra ArrayList of Strings that contains the html content to use, if available, for the recognition alternates provided in EXTRA_VOICE_SEARCH_RESULT_STRINGS. This list should always be the same size as the one provided in EXTRA_VOICE_SEARCH_RESULT_STRINGS - if a result cannot provide html, that entry in this list should be <code>null</code>, and the implementor of ACTION_VOICE_SEARCH_RESULTS should back off to the corresponding url provided in EXTRA_VOICE_SEARCH_RESULT_URLS, if available, or else should execute a search of its own choosing, based on the recognition result string.</para><para>Currently this html content should be expected in the form of a uri with scheme URI_SCHEME_INLINE for the Browser. In the future this may change to a "content://" uri or some other identifier. Anyone who reads this extra should confirm that a result is in fact an "inline:" uri and back off to the urls or strings gracefully if it is not, thus maintaining future backwards compatibility if this changes. </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_VOICE_SEARCH_RESULT_HTML
				/// </java-name>
				[Dot42.DexImport("EXTRA_VOICE_SEARCH_RESULT_HTML", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_VOICE_SEARCH_RESULT_HTML = "android.speech.extras.VOICE_SEARCH_RESULT_HTML";
				/// <summary>
				/// <para>The key to an extra ArrayList of Strings that contains the base url to assume when interpreting html provided in EXTRA_VOICE_SEARCH_RESULT_HTML.</para><para>A list of size 1 may be provided to apply the same base url to all html results. A list of the same size as EXTRA_VOICE_SEARCH_RESULT_STRINGS may be provided to apply different base urls to each different html result in the EXTRA_VOICE_SEARCH_RESULT_HTML list. </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_VOICE_SEARCH_RESULT_HTML_BASE_URLS
				/// </java-name>
				[Dot42.DexImport("EXTRA_VOICE_SEARCH_RESULT_HTML_BASE_URLS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_VOICE_SEARCH_RESULT_HTML_BASE_URLS = "android.speech.extras.VOICE_SEARCH_RESULT_HTML_BASE_URLS";
				/// <summary>
				/// <para>The key to an extra ArrayList of Bundles that contains key/value pairs. All the values and the keys are Strings. Each key/value pair represents an extra HTTP header. The keys can't be the standard HTTP headers as they are set by the WebView.</para><para>A list of size 1 may be provided to apply the same HTTP headers to all web results. A list of the same size as EXTRA_VOICE_SEARCH_RESULT_STRINGS may be provided to apply different HTTP headers to each different web result in the list. These headers will only be used in the case that the url for a particular web result (from EXTRA_VOICE_SEARCH_RESULT_URLS) is loaded. </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_VOICE_SEARCH_RESULT_HTTP_HEADERS
				/// </java-name>
				[Dot42.DexImport("EXTRA_VOICE_SEARCH_RESULT_HTTP_HEADERS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_VOICE_SEARCH_RESULT_HTTP_HEADERS = "android.speech.extras.EXTRA_VOICE_SEARCH_RESULT_HTTP_HEADERS";
				/// <summary>
				/// <para>The scheme used currently for html content in EXTRA_VOICE_SEARCH_RESULT_HTML. Note that this should only be used in tandem with this particular extra; it should NOT be used for generic URIs such as those found in the data field of an Intent. </para>        
				/// </summary>
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

		/// <summary>
		/// <para>Used for receiving notifications from the SpeechRecognizer when the recognition related events occur. All the callbacks are executed on the Application main thread. </para>    
		/// </summary>
		/// <java-name>
		/// android/speech/RecognitionListener
		/// </java-name>
		[Dot42.DexImport("android/speech/RecognitionListener", AccessFlags = 1537)]
		public partial interface IRecognitionListener
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Called when the endpointer is ready for the user to start speaking.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// onReadyForSpeech
				/// </java-name>
				[Dot42.DexImport("onReadyForSpeech", "(Landroid/os/Bundle;)V", AccessFlags = 1025)]
				void OnReadyForSpeech(global::Android.Os.Bundle @params) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>The user has started to speak. </para>        
				/// </summary>
				/// <java-name>
				/// onBeginningOfSpeech
				/// </java-name>
				[Dot42.DexImport("onBeginningOfSpeech", "()V", AccessFlags = 1025)]
				void OnBeginningOfSpeech() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>The sound level in the audio stream has changed. There is no guarantee that this method will be called.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// onRmsChanged
				/// </java-name>
				[Dot42.DexImport("onRmsChanged", "(F)V", AccessFlags = 1025)]
				void OnRmsChanged(float rmsdB) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>More sound has been received. The purpose of this function is to allow giving feedback to the user regarding the captured audio. There is no guarantee that this method will be called.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// onBufferReceived
				/// </java-name>
				[Dot42.DexImport("onBufferReceived", "([B)V", AccessFlags = 1025)]
				void OnBufferReceived(sbyte[] buffer) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Called after the user stops speaking. </para>        
				/// </summary>
				/// <java-name>
				/// onEndOfSpeech
				/// </java-name>
				[Dot42.DexImport("onEndOfSpeech", "()V", AccessFlags = 1025)]
				void OnEndOfSpeech() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>A network or recognition error occurred.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// onError
				/// </java-name>
				[Dot42.DexImport("onError", "(I)V", AccessFlags = 1025)]
				void OnError(int error) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Called when recognition results are ready.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// onResults
				/// </java-name>
				[Dot42.DexImport("onResults", "(Landroid/os/Bundle;)V", AccessFlags = 1025)]
				void OnResults(global::Android.Os.Bundle results) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Called when partial recognition results are available. The callback might be called at any time between onBeginningOfSpeech() and onResults(Bundle) when partial results are ready. This method may be called zero, one or multiple times for each call to SpeechRecognizer#startListening(Intent), depending on the speech recognition service implementation. To request partial results, use RecognizerIntent#EXTRA_PARTIAL_RESULTS</para><para></para>        
				/// </summary>
				/// <java-name>
				/// onPartialResults
				/// </java-name>
				[Dot42.DexImport("onPartialResults", "(Landroid/os/Bundle;)V", AccessFlags = 1025)]
				void OnPartialResults(global::Android.Os.Bundle partialResults) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Reserved for adding future events.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// onEvent
				/// </java-name>
				[Dot42.DexImport("onEvent", "(ILandroid/os/Bundle;)V", AccessFlags = 1025)]
				void OnEvent(int eventType, global::Android.Os.Bundle @params) /* MethodBuilder.Create */ ;

		}

}


