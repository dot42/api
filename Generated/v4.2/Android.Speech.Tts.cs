// Copyright (C) 2014 dot42
//
// Original filename: Android.Speech.Tts.cs
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
namespace Android.Speech.Tts
{
		/// <summary>
		/// <para>Abstract base class for TTS engine implementations. The following methods need to be implemented.</para><para><ul><li><para>onIsLanguageAvailable </para></li><li><para>onLoadLanguage </para></li><li><para>onGetLanguage </para></li><li><para>onSynthesizeText </para></li><li><para>onStop </para></li></ul></para><para>The first three deal primarily with language management, and are used to query the engine for it's support for a given language and indicate to it that requests in a given language are imminent.</para><para>onSynthesizeText is central to the engine implementation. The implementation should synthesize text as per the request parameters and return synthesized data via the supplied callback. This class and its helpers will then consume that data, which might mean queueing it for playback or writing it to a file or similar. All calls to this method will be on a single thread, which will be different from the main thread of the service. Synthesis must be synchronous which means the engine must NOT hold on the callback or call any methods on it after the method returns</para><para>onStop tells the engine that it should stop all ongoing synthesis, if any. Any pending data from the current synthesis will be discarded. </para>    
		/// </summary>
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

				/// <summary>
				/// <para>Called by the system when the service is first created. Do not call this method directly. </para>        
				/// </summary>
				/// <java-name>
				/// onCreate
				/// </java-name>
				[Dot42.DexImport("onCreate", "()V", AccessFlags = 1)]
				public override void OnCreate() /* MethodBuilder.Create */ 
				{
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
				/// <para>Checks whether the engine supports a given language.</para><para>Can be called on multiple threads.</para><para>Its return values HAVE to be consistent with onLoadLanguage.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Code indicating the support status for the locale. One of TextToSpeech#LANG_AVAILABLE, TextToSpeech#LANG_COUNTRY_AVAILABLE, TextToSpeech#LANG_COUNTRY_VAR_AVAILABLE, TextToSpeech#LANG_MISSING_DATA TextToSpeech#LANG_NOT_SUPPORTED. </para>
				/// </returns>
				/// <java-name>
				/// onIsLanguageAvailable
				/// </java-name>
				[Dot42.DexImport("onIsLanguageAvailable", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)I", AccessFlags = 1028)]
				protected internal abstract int OnIsLanguageAvailable(string lang, string country, string variant) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the language, country and variant currently being used by the TTS engine.</para><para>Can be called on multiple threads.</para><para><para>Locale::getISO3Language() </para><simplesectsep></simplesectsep><para>Locale::getISO3Country() </para><simplesectsep></simplesectsep><para>Locale::getVariant() </para></para>        
				/// </summary>
				/// <returns>
				/// <para>A 3-element array, containing language (ISO 3-letter code), country (ISO 3-letter code) and variant used by the engine. The country and variant may be <c> "" </c> . If country is empty, then variant must be empty too. </para>
				/// </returns>
				/// <java-name>
				/// onGetLanguage
				/// </java-name>
				[Dot42.DexImport("onGetLanguage", "()[Ljava/lang/String;", AccessFlags = 1028)]
				protected internal abstract string[] OnGetLanguage() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Notifies the engine that it should load a speech synthesis language. There is no guarantee that this method is always called before the language is used for synthesis. It is merely a hint to the engine that it will probably get some synthesis requests for this language at some point in the future.</para><para>Can be called on multiple threads. In &lt;= Android 4.2 (&lt;= API 17) can be called on main and service binder threads. In &gt; Android 4.2 (&gt; API 17) can be called on main and synthesis threads.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Code indicating the support status for the locale. One of TextToSpeech#LANG_AVAILABLE, TextToSpeech#LANG_COUNTRY_AVAILABLE, TextToSpeech#LANG_COUNTRY_VAR_AVAILABLE, TextToSpeech#LANG_MISSING_DATA TextToSpeech#LANG_NOT_SUPPORTED. </para>
				/// </returns>
				/// <java-name>
				/// onLoadLanguage
				/// </java-name>
				[Dot42.DexImport("onLoadLanguage", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)I", AccessFlags = 1028)]
				protected internal abstract int OnLoadLanguage(string lang, string country, string variant) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Notifies the service that it should stop any in-progress speech synthesis. This method can be called even if no speech synthesis is currently in progress.</para><para>Can be called on multiple threads, but not on the synthesis thread. </para>        
				/// </summary>
				/// <java-name>
				/// onStop
				/// </java-name>
				[Dot42.DexImport("onStop", "()V", AccessFlags = 1028)]
				protected internal abstract void OnStop() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Tells the service to synthesize speech from the given text. This method should block until the synthesis is finished.</para><para>Called on the synthesis thread.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// onSynthesizeText
				/// </java-name>
				[Dot42.DexImport("onSynthesizeText", "(Landroid/speech/tts/SynthesisRequest;Landroid/speech/tts/SynthesisCallback;)V", AccessFlags = 1028)]
				protected internal abstract void OnSynthesizeText(global::Android.Speech.Tts.SynthesisRequest request, global::Android.Speech.Tts.ISynthesisCallback callback) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Queries the service for a set of features supported for a given language.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>A list of features supported for the given language. </para>
				/// </returns>
				/// <java-name>
				/// onGetFeaturesForLanguage
				/// </java-name>
				[Dot42.DexImport("onGetFeaturesForLanguage", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/util/Set;", AccessFlags = 4, Signature = "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/util/Set<Ljava/lang" +
    "/String;>;")]
				protected internal virtual global::Java.Util.ISet<string> OnGetFeaturesForLanguage(string lang, string country, string variant) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ISet<string>);
				}

				/// <summary>
				/// <para>Return the communication channel to the service. May return null if clients can not bind to the service. The returned android.os.IBinder is usually for a complex interface that has been .</para><para><b>Note that unlike other application components, calls on to the IBinder interface returned here may not happen on the main thread of the process</b>. More information about the main thread can be found in .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Return an IBinder through which clients can call on to the service. </para>
				/// </returns>
				/// <java-name>
				/// onBind
				/// </java-name>
				[Dot42.DexImport("onBind", "(Landroid/content/Intent;)Landroid/os/IBinder;", AccessFlags = 1)]
				public override global::Android.Os.IBinder OnBind(global::Android.Content.Intent intent) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Os.IBinder);
				}

		}

		/// <summary>
		/// <para>Synthesizes speech from text for immediate playback or to create a sound file. </para><para>A TextToSpeech instance can only be used to synthesize text once it has completed its initialization. Implement the TextToSpeech.OnInitListener to be notified of the completion of the initialization.<br></br> When you are done using the TextToSpeech instance, call the shutdown() method to release the native resources used by the TextToSpeech engine. </para>    
		/// </summary>
		/// <java-name>
		/// android/speech/tts/TextToSpeech
		/// </java-name>
		[Dot42.DexImport("android/speech/tts/TextToSpeech", AccessFlags = 33)]
		public partial class TextToSpeech
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Denotes a successful operation. </para>        
				/// </summary>
				/// <java-name>
				/// SUCCESS
				/// </java-name>
				[Dot42.DexImport("SUCCESS", "I", AccessFlags = 25)]
				public const int SUCCESS = 0;
				/// <summary>
				/// <para>Denotes a generic operation failure. </para>        
				/// </summary>
				/// <java-name>
				/// ERROR
				/// </java-name>
				[Dot42.DexImport("ERROR", "I", AccessFlags = 25)]
				public const int ERROR = -1;
				/// <summary>
				/// <para>Queue mode where all entries in the playback queue (media to be played and text to be synthesized) are dropped and replaced by the new entry. Queues are flushed with respect to a given calling app. Entries in the queue from other callees are not discarded. </para>        
				/// </summary>
				/// <java-name>
				/// QUEUE_FLUSH
				/// </java-name>
				[Dot42.DexImport("QUEUE_FLUSH", "I", AccessFlags = 25)]
				public const int QUEUE_FLUSH = 0;
				/// <summary>
				/// <para>Queue mode where the new entry is added at the end of the playback queue. </para>        
				/// </summary>
				/// <java-name>
				/// QUEUE_ADD
				/// </java-name>
				[Dot42.DexImport("QUEUE_ADD", "I", AccessFlags = 25)]
				public const int QUEUE_ADD = 1;
				/// <summary>
				/// <para>Denotes the language is available exactly as specified by the locale. </para>        
				/// </summary>
				/// <java-name>
				/// LANG_COUNTRY_VAR_AVAILABLE
				/// </java-name>
				[Dot42.DexImport("LANG_COUNTRY_VAR_AVAILABLE", "I", AccessFlags = 25)]
				public const int LANG_COUNTRY_VAR_AVAILABLE = 2;
				/// <summary>
				/// <para>Denotes the language is available for the language and country specified by the locale, but not the variant. </para>        
				/// </summary>
				/// <java-name>
				/// LANG_COUNTRY_AVAILABLE
				/// </java-name>
				[Dot42.DexImport("LANG_COUNTRY_AVAILABLE", "I", AccessFlags = 25)]
				public const int LANG_COUNTRY_AVAILABLE = 1;
				/// <summary>
				/// <para>Denotes the language is available for the language by the locale, but not the country and variant. </para>        
				/// </summary>
				/// <java-name>
				/// LANG_AVAILABLE
				/// </java-name>
				[Dot42.DexImport("LANG_AVAILABLE", "I", AccessFlags = 25)]
				public const int LANG_AVAILABLE = 0;
				/// <summary>
				/// <para>Denotes the language data is missing. </para>        
				/// </summary>
				/// <java-name>
				/// LANG_MISSING_DATA
				/// </java-name>
				[Dot42.DexImport("LANG_MISSING_DATA", "I", AccessFlags = 25)]
				public const int LANG_MISSING_DATA = -1;
				/// <summary>
				/// <para>Denotes the language is not supported. </para>        
				/// </summary>
				/// <java-name>
				/// LANG_NOT_SUPPORTED
				/// </java-name>
				[Dot42.DexImport("LANG_NOT_SUPPORTED", "I", AccessFlags = 25)]
				public const int LANG_NOT_SUPPORTED = -2;
				/// <summary>
				/// <para>Broadcast Action: The TextToSpeech synthesizer has completed processing of all the text in the speech queue.</para><para>Note that this notifies callers when the <b>engine</b> has finished has processing text data. Audio playback might not have completed (or even started) at this point. If you wish to be notified when this happens, see OnUtteranceCompletedListener. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_TTS_QUEUE_PROCESSING_COMPLETED
				/// </java-name>
				[Dot42.DexImport("ACTION_TTS_QUEUE_PROCESSING_COMPLETED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_TTS_QUEUE_PROCESSING_COMPLETED = "android.speech.tts.TTS_QUEUE_PROCESSING_COMPLETED";
				/// <summary>
				/// <para>The constructor for the TextToSpeech class, using the default TTS engine. This will also initialize the associated TextToSpeech engine if it isn't already running.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/speech/tts/TextToSpeech$OnInitListener;)V", AccessFlags = 1)]
				public TextToSpeech(global::Android.Content.Context context, global::Android.Speech.Tts.TextToSpeech.IOnInitListener listener) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>The constructor for the TextToSpeech class, using the given TTS engine. This will also initialize the associated TextToSpeech engine if it isn't already running.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/speech/tts/TextToSpeech$OnInitListener;Ljava/l" +
    "ang/String;)V", AccessFlags = 1)]
				public TextToSpeech(global::Android.Content.Context context, global::Android.Speech.Tts.TextToSpeech.IOnInitListener listener, string engine) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Releases the resources used by the TextToSpeech engine. It is good practice for instance to call this method in the onDestroy() method of an Activity so the TextToSpeech engine can be cleanly stopped. </para>        
				/// </summary>
				/// <java-name>
				/// shutdown
				/// </java-name>
				[Dot42.DexImport("shutdown", "()V", AccessFlags = 1)]
				public virtual void Shutdown() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Adds a mapping between a string of text and a sound resource in a package. After a call to this method, subsequent calls to speak(String, int, HashMap) will play the specified sound resource if it is available, or synthesize the text it is missing.</para><para><code>&lt;manifest xmlns:android="..." package="<b>com.google.marvin.compass</b>"&gt;</code> </para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Code indicating success or failure. See ERROR and SUCCESS. </para>
				/// </returns>
				/// <java-name>
				/// addSpeech
				/// </java-name>
				[Dot42.DexImport("addSpeech", "(Ljava/lang/String;Ljava/lang/String;I)I", AccessFlags = 1)]
				public virtual int AddSpeech(string text, string packagename, int resourceId) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Adds a mapping between a string of text and a sound file. Using this, it is possible to add custom pronounciations for a string of text. After a call to this method, subsequent calls to speak(String, int, HashMap) will play the specified sound resource if it is available, or synthesize the text it is missing.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Code indicating success or failure. See ERROR and SUCCESS. </para>
				/// </returns>
				/// <java-name>
				/// addSpeech
				/// </java-name>
				[Dot42.DexImport("addSpeech", "(Ljava/lang/String;Ljava/lang/String;)I", AccessFlags = 1)]
				public virtual int AddSpeech(string text, string filename) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Adds a mapping between a string of text and a sound resource in a package. Use this to add custom earcons.</para><para><para>#playEarcon(String, int, HashMap)</para><code>&lt;manifest xmlns:android="..." package="<b>com.google.marvin.compass</b>"&gt;</code> </para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Code indicating success or failure. See ERROR and SUCCESS. </para>
				/// </returns>
				/// <java-name>
				/// addEarcon
				/// </java-name>
				[Dot42.DexImport("addEarcon", "(Ljava/lang/String;Ljava/lang/String;I)I", AccessFlags = 1)]
				public virtual int AddEarcon(string earcon, string packagename, int resourceId) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Adds a mapping between a string of text and a sound file. Use this to add custom earcons.</para><para><para>#playEarcon(String, int, HashMap)</para></para>        
				/// </summary>
				/// <returns>
				/// <para>Code indicating success or failure. See ERROR and SUCCESS. </para>
				/// </returns>
				/// <java-name>
				/// addEarcon
				/// </java-name>
				[Dot42.DexImport("addEarcon", "(Ljava/lang/String;Ljava/lang/String;)I", AccessFlags = 1)]
				public virtual int AddEarcon(string earcon, string filename) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Speaks the string using the specified queuing strategy and speech parameters. This method is asynchronous, i.e. the method just adds the request to the queue of TTS requests and then returns. The synthesis might not have finished (or even started!) at the time when this method returns. In order to reliably detect errors during synthesis, we recommend setting an utterance progress listener (see setOnUtteranceProgressListener) and using the Engine#KEY_PARAM_UTTERANCE_ID parameter.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>ERROR or SUCCESS of <b>queuing</b> the speak operation. </para>
				/// </returns>
				/// <java-name>
				/// speak
				/// </java-name>
				[Dot42.DexImport("speak", "(Ljava/lang/String;ILjava/util/HashMap;)I", AccessFlags = 1, Signature = "(Ljava/lang/String;ILjava/util/HashMap<Ljava/lang/String;Ljava/lang/String;>;)I")]
				public virtual int Speak(string text, int queueMode, global::Java.Util.HashMap<string, string> @params) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Plays the earcon using the specified queueing mode and parameters. The earcon must already have been added with addEarcon(String, String) or addEarcon(String, String, int). This method is asynchronous, i.e. the method just adds the request to the queue of TTS requests and then returns. The synthesis might not have finished (or even started!) at the time when this method returns. In order to reliably detect errors during synthesis, we recommend setting an utterance progress listener (see setOnUtteranceProgressListener) and using the Engine#KEY_PARAM_UTTERANCE_ID parameter.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>ERROR or SUCCESS of <b>queuing</b> the playEarcon operation. </para>
				/// </returns>
				/// <java-name>
				/// playEarcon
				/// </java-name>
				[Dot42.DexImport("playEarcon", "(Ljava/lang/String;ILjava/util/HashMap;)I", AccessFlags = 1, Signature = "(Ljava/lang/String;ILjava/util/HashMap<Ljava/lang/String;Ljava/lang/String;>;)I")]
				public virtual int PlayEarcon(string earcon, int queueMode, global::Java.Util.HashMap<string, string> @params) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Plays silence for the specified amount of time using the specified queue mode. This method is asynchronous, i.e. the method just adds the request to the queue of TTS requests and then returns. The synthesis might not have finished (or even started!) at the time when this method returns. In order to reliably detect errors during synthesis, we recommend setting an utterance progress listener (see setOnUtteranceProgressListener) and using the Engine#KEY_PARAM_UTTERANCE_ID parameter.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>ERROR or SUCCESS of <b>queuing</b> the playSilence operation. </para>
				/// </returns>
				/// <java-name>
				/// playSilence
				/// </java-name>
				[Dot42.DexImport("playSilence", "(JILjava/util/HashMap;)I", AccessFlags = 1, Signature = "(JILjava/util/HashMap<Ljava/lang/String;Ljava/lang/String;>;)I")]
				public virtual int PlaySilence(long durationInMs, int queueMode, global::Java.Util.HashMap<string, string> @params) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Queries the engine for the set of features it supports for a given locale. Features can either be framework defined, e.g. TextToSpeech.Engine#KEY_FEATURE_NETWORK_SYNTHESIS or engine specific. Engine specific keys must be prefixed by the name of the engine they are intended for. These keys can be used as parameters to TextToSpeech#speak(String, int, java.util.HashMap) and TextToSpeech#synthesizeToFile(String, java.util.HashMap, String).</para><para>Features are boolean flags, and their values in the synthesis parameters must be behave as per Boolean#parseBoolean(String).</para><para></para>        
				/// </summary>
				/// <java-name>
				/// getFeatures
				/// </java-name>
				[Dot42.DexImport("getFeatures", "(Ljava/util/Locale;)Ljava/util/Set;", AccessFlags = 1, Signature = "(Ljava/util/Locale;)Ljava/util/Set<Ljava/lang/String;>;")]
				public virtual global::Java.Util.ISet<string> GetFeatures(global::Java.Util.Locale locale) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ISet<string>);
				}

				/// <summary>
				/// <para>Checks whether the TTS engine is busy speaking. Note that a speech item is considered complete once it's audio data has been sent to the audio mixer, or written to a file. There might be a finite lag between this point, and when the audio hardware completes playback.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the TTS engine is speaking. </para>
				/// </returns>
				/// <java-name>
				/// isSpeaking
				/// </java-name>
				[Dot42.DexImport("isSpeaking", "()Z", AccessFlags = 1)]
				public virtual bool IsSpeaking() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Interrupts the current utterance (whether played or rendered to file) and discards other utterances in the queue.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>ERROR or SUCCESS. </para>
				/// </returns>
				/// <java-name>
				/// stop
				/// </java-name>
				[Dot42.DexImport("stop", "()I", AccessFlags = 1)]
				public virtual int Stop() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Sets the speech rate.</para><para>This has no effect on any pre-recorded speech.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>ERROR or SUCCESS. </para>
				/// </returns>
				/// <java-name>
				/// setSpeechRate
				/// </java-name>
				[Dot42.DexImport("setSpeechRate", "(F)I", AccessFlags = 1)]
				public virtual int SetSpeechRate(float speechRate) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Sets the speech pitch for the TextToSpeech engine.</para><para>This has no effect on any pre-recorded speech.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>ERROR or SUCCESS. </para>
				/// </returns>
				/// <java-name>
				/// setPitch
				/// </java-name>
				[Dot42.DexImport("setPitch", "(F)I", AccessFlags = 1)]
				public virtual int SetPitch(float pitch) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Sets the text-to-speech language. The TTS engine will try to use the closest match to the specified language as represented by the Locale, but there is no guarantee that the exact same Locale will be used. Use isLanguageAvailable(Locale) to check the level of support before choosing the language to use for the next utterances.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Code indicating the support status for the locale. See LANG_AVAILABLE, LANG_COUNTRY_AVAILABLE, LANG_COUNTRY_VAR_AVAILABLE, LANG_MISSING_DATA and LANG_NOT_SUPPORTED. </para>
				/// </returns>
				/// <java-name>
				/// setLanguage
				/// </java-name>
				[Dot42.DexImport("setLanguage", "(Ljava/util/Locale;)I", AccessFlags = 1)]
				public virtual int SetLanguage(global::Java.Util.Locale loc) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns a Locale instance describing the language currently being used for synthesis requests sent to the TextToSpeech engine.</para><para>In Android 4.2 and before (API &lt;= 17) this function returns the language that is currently being used by the TTS engine. That is the last language set by this or any other client by a TextToSpeech#setLanguage call to the same engine.</para><para>In Android versions after 4.2 this function returns the language that is currently being used for the synthesis requests sent from this client. That is the last language set by a TextToSpeech#setLanguage call on this instance.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>language, country (if any) and variant (if any) used by the client stored in a Locale instance, or <c> null </c> on error. </para>
				/// </returns>
				/// <java-name>
				/// getLanguage
				/// </java-name>
				[Dot42.DexImport("getLanguage", "()Ljava/util/Locale;", AccessFlags = 1)]
				public virtual global::Java.Util.Locale GetLanguage() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Locale);
				}

				/// <summary>
				/// <para>Checks if the specified language as represented by the Locale is available and supported.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Code indicating the support status for the locale. See LANG_AVAILABLE, LANG_COUNTRY_AVAILABLE, LANG_COUNTRY_VAR_AVAILABLE, LANG_MISSING_DATA and LANG_NOT_SUPPORTED. </para>
				/// </returns>
				/// <java-name>
				/// isLanguageAvailable
				/// </java-name>
				[Dot42.DexImport("isLanguageAvailable", "(Ljava/util/Locale;)I", AccessFlags = 1)]
				public virtual int IsLanguageAvailable(global::Java.Util.Locale loc) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Synthesizes the given text to a file using the specified parameters. This method is asynchronous, i.e. the method just adds the request to the queue of TTS requests and then returns. The synthesis might not have finished (or even started!) at the time when this method returns. In order to reliably detect errors during synthesis, we recommend setting an utterance progress listener (see setOnUtteranceProgressListener) and using the Engine#KEY_PARAM_UTTERANCE_ID parameter.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>ERROR or SUCCESS of <b>queuing</b> the synthesizeToFile operation. </para>
				/// </returns>
				/// <java-name>
				/// synthesizeToFile
				/// </java-name>
				[Dot42.DexImport("synthesizeToFile", "(Ljava/lang/String;Ljava/util/HashMap;Ljava/lang/String;)I", AccessFlags = 1, Signature = "(Ljava/lang/String;Ljava/util/HashMap<Ljava/lang/String;Ljava/lang/String;>;Ljava" +
    "/lang/String;)I")]
				public virtual int SynthesizeToFile(string text, global::Java.Util.HashMap<string, string> @params, string filename) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Sets the listener that will be notified when synthesis of an utterance completes.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>Use setOnUtteranceProgressListener(UtteranceProgressListener) instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				/// <para>ERROR or SUCCESS.</para>
				/// </returns>
				/// <java-name>
				/// setOnUtteranceCompletedListener
				/// </java-name>
				[Dot42.DexImport("setOnUtteranceCompletedListener", "(Landroid/speech/tts/TextToSpeech$OnUtteranceCompletedListener;)I", AccessFlags = 1)]
				public virtual int SetOnUtteranceCompletedListener(global::Android.Speech.Tts.TextToSpeech.IOnUtteranceCompletedListener listener) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Sets the listener that will be notified of various events related to the synthesis of a given utterance.</para><para>See UtteranceProgressListener and TextToSpeech.Engine#KEY_PARAM_UTTERANCE_ID.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>ERROR or SUCCESS </para>
				/// </returns>
				/// <java-name>
				/// setOnUtteranceProgressListener
				/// </java-name>
				[Dot42.DexImport("setOnUtteranceProgressListener", "(Landroid/speech/tts/UtteranceProgressListener;)I", AccessFlags = 1)]
				public virtual int SetOnUtteranceProgressListener(global::Android.Speech.Tts.UtteranceProgressListener listener) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Sets the TTS engine to use.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>This doesn't inform callers when the TTS engine has been initialized. TextToSpeech(Context, OnInitListener, String) can be used with the appropriate engine name. Also, there is no guarantee that the engine specified will be loaded. If it isn't installed or disabled, the user / system wide defaults will apply.</para></xrefdescription></xrefsect></para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>ERROR or SUCCESS. </para>
				/// </returns>
				/// <java-name>
				/// setEngineByPackageName
				/// </java-name>
				[Dot42.DexImport("setEngineByPackageName", "(Ljava/lang/String;)I", AccessFlags = 1)]
				public virtual int SetEngineByPackageName(string enginePackageName) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Gets the package name of the default speech synthesis engine.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Package name of the TTS engine that the user has chosen as their default. </para>
				/// </returns>
				/// <java-name>
				/// getDefaultEngine
				/// </java-name>
				[Dot42.DexImport("getDefaultEngine", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetDefaultEngine() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Checks whether the user's settings should override settings requested by the calling application. As of the Ice cream sandwich release, user settings never forcibly override the app's settings. </para>        
				/// </summary>
				/// <java-name>
				/// areDefaultsEnforced
				/// </java-name>
				[Dot42.DexImport("areDefaultsEnforced", "()Z", AccessFlags = 1)]
				public virtual bool AreDefaultsEnforced() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Gets a list of all installed TTS engines.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>A list of engine info objects. The list can be empty, but never <c> null </c> . </para>
				/// </returns>
				/// <java-name>
				/// getEngines
				/// </java-name>
				[Dot42.DexImport("getEngines", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Landroid/speech/tts/TextToSpeech$EngineInfo;>;")]
				public virtual global::Java.Util.IList<global::Android.Speech.Tts.TextToSpeech.EngineInfo> GetEngines() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<global::Android.Speech.Tts.TextToSpeech.EngineInfo>);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal TextToSpeech() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Returns a Locale instance describing the language currently being used for synthesis requests sent to the TextToSpeech engine.</para><para>In Android 4.2 and before (API &lt;= 17) this function returns the language that is currently being used by the TTS engine. That is the last language set by this or any other client by a TextToSpeech#setLanguage call to the same engine.</para><para>In Android versions after 4.2 this function returns the language that is currently being used for the synthesis requests sent from this client. That is the last language set by a TextToSpeech#setLanguage call on this instance.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>language, country (if any) and variant (if any) used by the client stored in a Locale instance, or <c> null </c> on error. </para>
				/// </returns>
				/// <java-name>
				/// getLanguage
				/// </java-name>
				public global::Java.Util.Locale Language
				{
				[Dot42.DexImport("getLanguage", "()Ljava/util/Locale;", AccessFlags = 1)]
						get{ return GetLanguage(); }
				}

				/// <summary>
				/// <para>Gets the package name of the default speech synthesis engine.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Package name of the TTS engine that the user has chosen as their default. </para>
				/// </returns>
				/// <java-name>
				/// getDefaultEngine
				/// </java-name>
				public string DefaultEngine
				{
				[Dot42.DexImport("getDefaultEngine", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetDefaultEngine(); }
				}

				/// <summary>
				/// <para>Gets a list of all installed TTS engines.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>A list of engine info objects. The list can be empty, but never <c> null </c> . </para>
				/// </returns>
				/// <java-name>
				/// getEngines
				/// </java-name>
				public global::Java.Util.IList<global::Android.Speech.Tts.TextToSpeech.EngineInfo> Engines
				{
				[Dot42.DexImport("getEngines", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Landroid/speech/tts/TextToSpeech$EngineInfo;>;")]
						get{ return GetEngines(); }
				}

				/// <summary>
				/// <para>Information about an installed text-to-speech engine.</para><para><para>TextToSpeech::getEngines </para></para>    
				/// </summary>
				/// <java-name>
				/// android/speech/tts/TextToSpeech$EngineInfo
				/// </java-name>
				[Dot42.DexImport("android/speech/tts/TextToSpeech$EngineInfo", AccessFlags = 9)]
				public partial class EngineInfo
 /* scope: __dot42__ */ 
				{
						/// <summary>
						/// <para>Engine package name.. </para>        
						/// </summary>
						/// <java-name>
						/// name
						/// </java-name>
						[Dot42.DexImport("name", "Ljava/lang/String;", AccessFlags = 1)]
						public string Name;
						/// <summary>
						/// <para>Localized label for the engine. </para>        
						/// </summary>
						/// <java-name>
						/// label
						/// </java-name>
						[Dot42.DexImport("label", "Ljava/lang/String;", AccessFlags = 1)]
						public string Label;
						/// <summary>
						/// <para>Icon for the engine. </para>        
						/// </summary>
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

				/// <summary>
				/// <para>Constants and parameter names for controlling text-to-speech. These include:</para><para><ul><li><para>Intents to ask engine to install data or check its data and extras for a TTS engine's check data activity.  </para></li><li><para>Keys for the parameters passed with speak commands, e.g. Engine#KEY_PARAM_UTTERANCE_ID, Engine#KEY_PARAM_STREAM.  </para></li><li><para>A list of feature strings that engines might support, e.g Engine#KEY_FEATURE_NETWORK_SYNTHESIS). These values may be passed in to TextToSpeech#speak and TextToSpeech#synthesizeToFile to modify engine behaviour. The engine can be queried for the set of features it supports through TextToSpeech#getFeatures(java.util.Locale).  </para></li></ul></para>    
				/// </summary>
				/// <java-name>
				/// android/speech/tts/TextToSpeech$Engine
				/// </java-name>
				[Dot42.DexImport("android/speech/tts/TextToSpeech$Engine", AccessFlags = 1)]
				public partial class Engine
 /* scope: __dot42__ */ 
				{
						/// <summary>
						/// <para>Default audio stream used when playing synthesized speech. </para>        
						/// </summary>
						/// <java-name>
						/// DEFAULT_STREAM
						/// </java-name>
						[Dot42.DexImport("DEFAULT_STREAM", "I", AccessFlags = 25)]
						public const int DEFAULT_STREAM = 3;
						/// <summary>
						/// <para>Indicates success when checking the installation status of the resources used by the TextToSpeech engine with the ACTION_CHECK_TTS_DATA intent. </para>        
						/// </summary>
						/// <java-name>
						/// CHECK_VOICE_DATA_PASS
						/// </java-name>
						[Dot42.DexImport("CHECK_VOICE_DATA_PASS", "I", AccessFlags = 25)]
						public const int CHECK_VOICE_DATA_PASS = 1;
						/// <summary>
						/// <para>Indicates failure when checking the installation status of the resources used by the TextToSpeech engine with the ACTION_CHECK_TTS_DATA intent. </para>        
						/// </summary>
						/// <java-name>
						/// CHECK_VOICE_DATA_FAIL
						/// </java-name>
						[Dot42.DexImport("CHECK_VOICE_DATA_FAIL", "I", AccessFlags = 25)]
						public const int CHECK_VOICE_DATA_FAIL = 0;
						/// <summary>
						/// <para>Indicates erroneous data when checking the installation status of the resources used by the TextToSpeech engine with the ACTION_CHECK_TTS_DATA intent.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>Use CHECK_VOICE_DATA_FAIL instead. </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// CHECK_VOICE_DATA_BAD_DATA
						/// </java-name>
						[Dot42.DexImport("CHECK_VOICE_DATA_BAD_DATA", "I", AccessFlags = 25)]
						public const int CHECK_VOICE_DATA_BAD_DATA = -1;
						/// <summary>
						/// <para>Indicates missing resources when checking the installation status of the resources used by the TextToSpeech engine with the ACTION_CHECK_TTS_DATA intent.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>Use CHECK_VOICE_DATA_FAIL instead. </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// CHECK_VOICE_DATA_MISSING_DATA
						/// </java-name>
						[Dot42.DexImport("CHECK_VOICE_DATA_MISSING_DATA", "I", AccessFlags = 25)]
						public const int CHECK_VOICE_DATA_MISSING_DATA = -2;
						/// <summary>
						/// <para>Indicates missing storage volume when checking the installation status of the resources used by the TextToSpeech engine with the ACTION_CHECK_TTS_DATA intent.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>Use CHECK_VOICE_DATA_FAIL instead. </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// CHECK_VOICE_DATA_MISSING_VOLUME
						/// </java-name>
						[Dot42.DexImport("CHECK_VOICE_DATA_MISSING_VOLUME", "I", AccessFlags = 25)]
						public const int CHECK_VOICE_DATA_MISSING_VOLUME = -3;
						/// <summary>
						/// <para>Intent for starting a TTS service. Services that handle this intent must extend TextToSpeechService. Normal applications should not use this intent directly, instead they should talk to the TTS service using the the methods in this class. </para>        
						/// </summary>
						/// <java-name>
						/// INTENT_ACTION_TTS_SERVICE
						/// </java-name>
						[Dot42.DexImport("INTENT_ACTION_TTS_SERVICE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string INTENT_ACTION_TTS_SERVICE = "android.intent.action.TTS_SERVICE";
						/// <summary>
						/// <para>Name under which a text to speech engine publishes information about itself. This meta-data should reference an XML resource containing a <code>&lt;tts-engine&gt;</code> tag. </para>        
						/// </summary>
						/// <java-name>
						/// SERVICE_META_DATA
						/// </java-name>
						[Dot42.DexImport("SERVICE_META_DATA", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SERVICE_META_DATA = "android.speech.tts";
						/// <summary>
						/// <para>Activity Action: Triggers the platform TextToSpeech engine to start the activity that installs the resource files on the device that are required for TTS to be operational. Since the installation of the data can be interrupted or declined by the user, the application shouldn't expect successful installation upon return from that intent, and if need be, should check installation status with ACTION_CHECK_TTS_DATA. </para>        
						/// </summary>
						/// <java-name>
						/// ACTION_INSTALL_TTS_DATA
						/// </java-name>
						[Dot42.DexImport("ACTION_INSTALL_TTS_DATA", "Ljava/lang/String;", AccessFlags = 25)]
						public const string ACTION_INSTALL_TTS_DATA = "android.speech.tts.engine.INSTALL_TTS_DATA";
						/// <summary>
						/// <para>Broadcast Action: broadcast to signal the change in the list of available languages or/and their features. </para>        
						/// </summary>
						/// <java-name>
						/// ACTION_TTS_DATA_INSTALLED
						/// </java-name>
						[Dot42.DexImport("ACTION_TTS_DATA_INSTALLED", "Ljava/lang/String;", AccessFlags = 25)]
						public const string ACTION_TTS_DATA_INSTALLED = "android.speech.tts.engine.TTS_DATA_INSTALLED";
						/// <summary>
						/// <para>Activity Action: Starts the activity from the platform TextToSpeech engine to verify the proper installation and availability of the resource files on the system. Upon completion, the activity will return one of the following codes: CHECK_VOICE_DATA_PASS, CHECK_VOICE_DATA_FAIL, </para><para>Moreover, the data received in the activity result will contain the following fields: <ul><li><para>EXTRA_AVAILABLE_VOICES which contains an ArrayList&lt;String&gt; of all the available voices. The format of each voice is: lang-COUNTRY-variant where COUNTRY and variant are optional (ie, "eng" or "eng-USA" or "eng-USA-FEMALE"). </para></li><li><para>EXTRA_UNAVAILABLE_VOICES which contains an ArrayList&lt;String&gt; of all the unavailable voices (ones that user can install). The format of each voice is: lang-COUNTRY-variant where COUNTRY and variant are optional (ie, "eng" or "eng-USA" or "eng-USA-FEMALE"). </para></li></ul></para>        
						/// </summary>
						/// <java-name>
						/// ACTION_CHECK_TTS_DATA
						/// </java-name>
						[Dot42.DexImport("ACTION_CHECK_TTS_DATA", "Ljava/lang/String;", AccessFlags = 25)]
						public const string ACTION_CHECK_TTS_DATA = "android.speech.tts.engine.CHECK_TTS_DATA";
						/// <summary>
						/// <para>Extra information received with the ACTION_CHECK_TTS_DATA intent result where the TextToSpeech engine specifies the path to its resources.</para><para>It may be used by language packages to find out where to put their data.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>TTS engine implementation detail, this information has no use for text-to-speech API client. </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// EXTRA_VOICE_DATA_ROOT_DIRECTORY
						/// </java-name>
						[Dot42.DexImport("EXTRA_VOICE_DATA_ROOT_DIRECTORY", "Ljava/lang/String;", AccessFlags = 25)]
						public const string EXTRA_VOICE_DATA_ROOT_DIRECTORY = "dataRoot";
						/// <summary>
						/// <para>Extra information received with the ACTION_CHECK_TTS_DATA intent result where the TextToSpeech engine specifies the file names of its resources under the resource path.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>TTS engine implementation detail, this information has no use for text-to-speech API client. </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// EXTRA_VOICE_DATA_FILES
						/// </java-name>
						[Dot42.DexImport("EXTRA_VOICE_DATA_FILES", "Ljava/lang/String;", AccessFlags = 25)]
						public const string EXTRA_VOICE_DATA_FILES = "dataFiles";
						/// <summary>
						/// <para>Extra information received with the ACTION_CHECK_TTS_DATA intent result where the TextToSpeech engine specifies the locale associated with each resource file.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>TTS engine implementation detail, this information has no use for text-to-speech API client. </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// EXTRA_VOICE_DATA_FILES_INFO
						/// </java-name>
						[Dot42.DexImport("EXTRA_VOICE_DATA_FILES_INFO", "Ljava/lang/String;", AccessFlags = 25)]
						public const string EXTRA_VOICE_DATA_FILES_INFO = "dataFilesInfo";
						/// <summary>
						/// <para>Extra information received with the ACTION_CHECK_TTS_DATA intent result where the TextToSpeech engine returns an ArrayList&lt;String&gt; of all the available voices. The format of each voice is: lang-COUNTRY-variant where COUNTRY and variant are optional (ie, "eng" or "eng-USA" or "eng-USA-FEMALE"). </para>        
						/// </summary>
						/// <java-name>
						/// EXTRA_AVAILABLE_VOICES
						/// </java-name>
						[Dot42.DexImport("EXTRA_AVAILABLE_VOICES", "Ljava/lang/String;", AccessFlags = 25)]
						public const string EXTRA_AVAILABLE_VOICES = "availableVoices";
						/// <summary>
						/// <para>Extra information received with the ACTION_CHECK_TTS_DATA intent result where the TextToSpeech engine returns an ArrayList&lt;String&gt; of all the unavailable voices. The format of each voice is: lang-COUNTRY-variant where COUNTRY and variant are optional (ie, "eng" or "eng-USA" or "eng-USA-FEMALE"). </para>        
						/// </summary>
						/// <java-name>
						/// EXTRA_UNAVAILABLE_VOICES
						/// </java-name>
						[Dot42.DexImport("EXTRA_UNAVAILABLE_VOICES", "Ljava/lang/String;", AccessFlags = 25)]
						public const string EXTRA_UNAVAILABLE_VOICES = "unavailableVoices";
						/// <summary>
						/// <para>Extra information sent with the ACTION_CHECK_TTS_DATA intent where the caller indicates to the TextToSpeech engine which specific sets of voice data to check for by sending an ArrayList&lt;String&gt; of the voices that are of interest. The format of each voice is: lang-COUNTRY-variant where COUNTRY and variant are optional (ie, "eng" or "eng-USA" or "eng-USA-FEMALE").</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>Redundant functionality, checking for existence of specific sets of voice data can be done on client side. </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// EXTRA_CHECK_VOICE_DATA_FOR
						/// </java-name>
						[Dot42.DexImport("EXTRA_CHECK_VOICE_DATA_FOR", "Ljava/lang/String;", AccessFlags = 25)]
						public const string EXTRA_CHECK_VOICE_DATA_FOR = "checkVoiceDataFor";
						/// <summary>
						/// <para>Extra information received with the ACTION_TTS_DATA_INSTALLED intent result. It indicates whether the data files for the synthesis engine were successfully installed. The installation was initiated with the ACTION_INSTALL_TTS_DATA intent. The possible values for this extra are TextToSpeech#SUCCESS and TextToSpeech#ERROR.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>No longer in use. If client ise interested in information about what changed, is should send ACTION_CHECK_TTS_DATA intent to discover available voices. </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// EXTRA_TTS_DATA_INSTALLED
						/// </java-name>
						[Dot42.DexImport("EXTRA_TTS_DATA_INSTALLED", "Ljava/lang/String;", AccessFlags = 25)]
						public const string EXTRA_TTS_DATA_INSTALLED = "dataInstalled";
						/// <summary>
						/// <para>Parameter key to specify the audio stream type to be used when speaking text or playing back a file. The value should be one of the STREAM_ constants defined in AudioManager.</para><para><para>TextToSpeech::speak(String, int, HashMap) </para><simplesectsep></simplesectsep><para>TextToSpeech::playEarcon(String, int, HashMap) </para></para>        
						/// </summary>
						/// <java-name>
						/// KEY_PARAM_STREAM
						/// </java-name>
						[Dot42.DexImport("KEY_PARAM_STREAM", "Ljava/lang/String;", AccessFlags = 25)]
						public const string KEY_PARAM_STREAM = "streamType";
						/// <summary>
						/// <para>Parameter key to identify an utterance in the TextToSpeech.OnUtteranceCompletedListener after text has been spoken, a file has been played back or a silence duration has elapsed.</para><para><para>TextToSpeech::speak(String, int, HashMap) </para><simplesectsep></simplesectsep><para>TextToSpeech::playEarcon(String, int, HashMap) </para><simplesectsep></simplesectsep><para>TextToSpeech::synthesizeToFile(String, HashMap, String) </para></para>        
						/// </summary>
						/// <java-name>
						/// KEY_PARAM_UTTERANCE_ID
						/// </java-name>
						[Dot42.DexImport("KEY_PARAM_UTTERANCE_ID", "Ljava/lang/String;", AccessFlags = 25)]
						public const string KEY_PARAM_UTTERANCE_ID = "utteranceId";
						/// <summary>
						/// <para>Parameter key to specify the speech volume relative to the current stream type volume used when speaking text. Volume is specified as a float ranging from 0 to 1 where 0 is silence, and 1 is the maximum volume (the default behavior).</para><para><para>TextToSpeech::speak(String, int, HashMap) </para><simplesectsep></simplesectsep><para>TextToSpeech::playEarcon(String, int, HashMap) </para></para>        
						/// </summary>
						/// <java-name>
						/// KEY_PARAM_VOLUME
						/// </java-name>
						[Dot42.DexImport("KEY_PARAM_VOLUME", "Ljava/lang/String;", AccessFlags = 25)]
						public const string KEY_PARAM_VOLUME = "volume";
						/// <summary>
						/// <para>Parameter key to specify how the speech is panned from left to right when speaking text. Pan is specified as a float ranging from -1 to +1 where -1 maps to a hard-left pan, 0 to center (the default behavior), and +1 to hard-right.</para><para><para>TextToSpeech::speak(String, int, HashMap) </para><simplesectsep></simplesectsep><para>TextToSpeech::playEarcon(String, int, HashMap) </para></para>        
						/// </summary>
						/// <java-name>
						/// KEY_PARAM_PAN
						/// </java-name>
						[Dot42.DexImport("KEY_PARAM_PAN", "Ljava/lang/String;", AccessFlags = 25)]
						public const string KEY_PARAM_PAN = "pan";
						/// <summary>
						/// <para>Feature key for network synthesis. See TextToSpeech#getFeatures(Locale) for a description of how feature keys work. If set (and supported by the engine as per TextToSpeech#getFeatures(Locale), the engine must use network based synthesis.</para><para><para>TextToSpeech::speak(String, int, java.util.HashMap) </para><simplesectsep></simplesectsep><para>TextToSpeech::synthesizeToFile(String, java.util.HashMap, String) </para><simplesectsep></simplesectsep><para>TextToSpeech::getFeatures(java.util.Locale) </para></para>        
						/// </summary>
						/// <java-name>
						/// KEY_FEATURE_NETWORK_SYNTHESIS
						/// </java-name>
						[Dot42.DexImport("KEY_FEATURE_NETWORK_SYNTHESIS", "Ljava/lang/String;", AccessFlags = 25)]
						public const string KEY_FEATURE_NETWORK_SYNTHESIS = "networkTts";
						/// <summary>
						/// <para>Feature key for embedded synthesis. See TextToSpeech#getFeatures(Locale) for a description of how feature keys work. If set and supported by the engine as per TextToSpeech#getFeatures(Locale), the engine must synthesize text on-device (without making network requests).</para><para><para>TextToSpeech::speak(String, int, java.util.HashMap) </para><simplesectsep></simplesectsep><para>TextToSpeech::synthesizeToFile(String, java.util.HashMap, String) </para><simplesectsep></simplesectsep><para>TextToSpeech::getFeatures(java.util.Locale) </para></para>        
						/// </summary>
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

				/// <summary>
				/// <para>Listener that will be called when the TTS service has completed synthesizing an utterance. This is only called if the utterance has an utterance ID (see TextToSpeech.Engine#KEY_PARAM_UTTERANCE_ID).</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>Use UtteranceProgressListener instead. </para></xrefdescription></xrefsect></para>    
				/// </summary>
				/// <java-name>
				/// android/speech/tts/TextToSpeech$OnUtteranceCompletedListener
				/// </java-name>
				[Dot42.DexImport("android/speech/tts/TextToSpeech$OnUtteranceCompletedListener", AccessFlags = 1545)]
				public partial interface IOnUtteranceCompletedListener
 /* scope: __dot42__ */ 
				{
						/// <summary>
						/// <para>Called when an utterance has been synthesized.</para><para></para>        
						/// </summary>
						/// <java-name>
						/// onUtteranceCompleted
						/// </java-name>
						[Dot42.DexImport("onUtteranceCompleted", "(Ljava/lang/String;)V", AccessFlags = 1025)]
						void OnUtteranceCompleted(string utteranceId) /* MethodBuilder.Create */ ;

				}

				/// <summary>
				/// <para>Interface definition of a callback to be invoked indicating the completion of the TextToSpeech engine initialization. </para>    
				/// </summary>
				/// <java-name>
				/// android/speech/tts/TextToSpeech$OnInitListener
				/// </java-name>
				[Dot42.DexImport("android/speech/tts/TextToSpeech$OnInitListener", AccessFlags = 1545)]
				public partial interface IOnInitListener
 /* scope: __dot42__ */ 
				{
						/// <summary>
						/// <para>Called to signal the completion of the TextToSpeech engine initialization.</para><para></para>        
						/// </summary>
						/// <java-name>
						/// onInit
						/// </java-name>
						[Dot42.DexImport("onInit", "(I)V", AccessFlags = 1025)]
						void OnInit(int status) /* MethodBuilder.Create */ ;

				}

		}

		/// <summary>
		/// <para>A callback to return speech data synthesized by a text to speech engine.</para><para>The engine can provide streaming audio by calling start, then audioAvailable until all audio has been provided, then finally done.</para><para>error can be called at any stage in the synthesis process to indicate that an error has occurred, but if the call is made after a call to done, it might be discarded.</para><para>After start been called, done must be called regardless of errors. </para>    
		/// </summary>
		/// <java-name>
		/// android/speech/tts/SynthesisCallback
		/// </java-name>
		[Dot42.DexImport("android/speech/tts/SynthesisCallback", AccessFlags = 1537)]
		public partial interface ISynthesisCallback
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>the maximum number of bytes that the TTS engine can pass in a single call of audioAvailable. Calls to audioAvailable with data lengths larger than this value will not succeed. </para>
				/// </returns>
				/// <java-name>
				/// getMaxBufferSize
				/// </java-name>
				[Dot42.DexImport("getMaxBufferSize", "()I", AccessFlags = 1025)]
				int GetMaxBufferSize() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>The service should call this when it starts to synthesize audio for this request.</para><para>This method should only be called on the synthesis thread, while in TextToSpeechService#onSynthesizeText.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>TextToSpeech#SUCCESS or TextToSpeech#ERROR. </para>
				/// </returns>
				/// <java-name>
				/// start
				/// </java-name>
				[Dot42.DexImport("start", "(III)I", AccessFlags = 1025)]
				int Start(int sampleRateInHz, int audioFormat, int channelCount) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>The service should call this method when synthesized audio is ready for consumption.</para><para>This method should only be called on the synthesis thread, while in TextToSpeechService#onSynthesizeText.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>TextToSpeech#SUCCESS or TextToSpeech#ERROR. </para>
				/// </returns>
				/// <java-name>
				/// audioAvailable
				/// </java-name>
				[Dot42.DexImport("audioAvailable", "([BII)I", AccessFlags = 1025)]
				int AudioAvailable(sbyte[] buffer, int offset, int length) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>The service should call this method when all the synthesized audio for a request has been passed to audioAvailable.</para><para>This method should only be called on the synthesis thread, while in TextToSpeechService#onSynthesizeText.</para><para>This method has to be called if start was called.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>TextToSpeech#SUCCESS or TextToSpeech#ERROR. </para>
				/// </returns>
				/// <java-name>
				/// done
				/// </java-name>
				[Dot42.DexImport("done", "()I", AccessFlags = 1025)]
				int Done() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>The service should call this method if the speech synthesis fails.</para><para>This method should only be called on the synthesis thread, while in TextToSpeechService#onSynthesizeText. </para>        
				/// </summary>
				/// <java-name>
				/// error
				/// </java-name>
				[Dot42.DexImport("error", "()V", AccessFlags = 1025)]
				void Error() /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// android/speech/tts/SynthesisRequest
		/// </java-name>
		[Dot42.DexImport("android/speech/tts/SynthesisRequest", AccessFlags = 49)]
		public sealed partial class SynthesisRequest
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Landroid/os/Bundle;)V", AccessFlags = 1)]
				public SynthesisRequest(string @string, global::Android.Os.Bundle bundle) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getText
				/// </java-name>
				[Dot42.DexImport("getText", "()Ljava/lang/String;", AccessFlags = 1)]
				public string GetText() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getLanguage
				/// </java-name>
				[Dot42.DexImport("getLanguage", "()Ljava/lang/String;", AccessFlags = 1)]
				public string GetLanguage() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getCountry
				/// </java-name>
				[Dot42.DexImport("getCountry", "()Ljava/lang/String;", AccessFlags = 1)]
				public string GetCountry() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getVariant
				/// </java-name>
				[Dot42.DexImport("getVariant", "()Ljava/lang/String;", AccessFlags = 1)]
				public string GetVariant() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getSpeechRate
				/// </java-name>
				[Dot42.DexImport("getSpeechRate", "()I", AccessFlags = 1)]
				public int GetSpeechRate() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getPitch
				/// </java-name>
				[Dot42.DexImport("getPitch", "()I", AccessFlags = 1)]
				public int GetPitch() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getParams
				/// </java-name>
				[Dot42.DexImport("getParams", "()Landroid/os/Bundle;", AccessFlags = 1)]
				public global::Android.Os.Bundle GetParams() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Os.Bundle);
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
						get{ return GetText(); }
				}

				/// <java-name>
				/// getLanguage
				/// </java-name>
				public string Language
				{
				[Dot42.DexImport("getLanguage", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetLanguage(); }
				}

				/// <java-name>
				/// getCountry
				/// </java-name>
				public string Country
				{
				[Dot42.DexImport("getCountry", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetCountry(); }
				}

				/// <java-name>
				/// getVariant
				/// </java-name>
				public string Variant
				{
				[Dot42.DexImport("getVariant", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetVariant(); }
				}

				/// <java-name>
				/// getSpeechRate
				/// </java-name>
				public int SpeechRate
				{
				[Dot42.DexImport("getSpeechRate", "()I", AccessFlags = 1)]
						get{ return GetSpeechRate(); }
				}

				/// <java-name>
				/// getPitch
				/// </java-name>
				public int Pitch
				{
				[Dot42.DexImport("getPitch", "()I", AccessFlags = 1)]
						get{ return GetPitch(); }
				}

				/// <java-name>
				/// getParams
				/// </java-name>
				public global::Android.Os.Bundle Params
				{
				[Dot42.DexImport("getParams", "()Landroid/os/Bundle;", AccessFlags = 1)]
						get{ return GetParams(); }
				}

		}

		/// <summary>
		/// <para>Listener for events relating to the progress of an utterance through the synthesis queue. Each utterance is associated with a call to TextToSpeech#speak or TextToSpeech#synthesizeToFile with an associated utterance identifier, as per TextToSpeech.Engine#KEY_PARAM_UTTERANCE_ID.</para><para>The callbacks specified in this method can be called from multiple threads. </para>    
		/// </summary>
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

				/// <summary>
				/// <para>Called when an utterance "starts" as perceived by the caller. This will be soon before audio is played back in the case of a TextToSpeech#speak or before the first bytes of a file are written to storage in the case of TextToSpeech#synthesizeToFile.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// onStart
				/// </java-name>
				[Dot42.DexImport("onStart", "(Ljava/lang/String;)V", AccessFlags = 1025)]
				public abstract void OnStart(string utteranceId) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Called when an utterance has successfully completed processing. All audio will have been played back by this point for audible output, and all output will have been written to disk for file synthesis requests.</para><para>This request is guaranteed to be called after onStart(String).</para><para></para>        
				/// </summary>
				/// <java-name>
				/// onDone
				/// </java-name>
				[Dot42.DexImport("onDone", "(Ljava/lang/String;)V", AccessFlags = 1025)]
				public abstract void OnDone(string utteranceId) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Called when an error has occurred during processing. This can be called at any point in the synthesis process. Note that there might be calls to onStart(String) for specified utteranceId but there will never be a call to both onDone(String) and onError(String) for the same utterance.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// onError
				/// </java-name>
				[Dot42.DexImport("onError", "(Ljava/lang/String;)V", AccessFlags = 1025)]
				public abstract void OnError(string utteranceId) /* MethodBuilder.Create */ ;

		}

}


