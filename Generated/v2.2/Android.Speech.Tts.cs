#pragma warning disable 1717
namespace Android.Speech.Tts
{
		/// <summary>
		///  <para>Synthesizes speech from text for immediate playback or to create a sound file. </para> <para>A TextToSpeech instance can only be used to synthesize text once it has completed its initialization. Implement the TextToSpeech.OnInitListener to be notified of the completion of the initialization. <br></br> When you are done using the TextToSpeech instance, call the shutdown() method to release the native resources used by the TextToSpeech engine. </para>    
		/// </summary>
		/// <java-name>
		/// android/speech/tts/TextToSpeech
		/// </java-name>
		[Dot42.DexImport("android/speech/tts/TextToSpeech", AccessFlags = 33)]
		public partial class TextToSpeech
 /* scope: __dot42__ */ 
		{
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
				///  <para>Queue mode where all entries in the playback queue (media to be played and text to be synthesized) are dropped and replaced by the new entry. Queues are flushed with respect to a given calling app. Entries in the queue from other callees are not discarded. </para>        
				/// </summary>
				/// <java-name>
				/// QUEUE_FLUSH
				/// </java-name>
				[Dot42.DexImport("QUEUE_FLUSH", "I", AccessFlags = 25)]
				public const int QUEUE_FLUSH = 0;
				/// <summary>
				///  <para>Queue mode where the new entry is added at the end of the playback queue. </para>        
				/// </summary>
				/// <java-name>
				/// QUEUE_ADD
				/// </java-name>
				[Dot42.DexImport("QUEUE_ADD", "I", AccessFlags = 25)]
				public const int QUEUE_ADD = 1;
				/// <summary>
				///  <para>Denotes the language is available exactly as specified by the locale. </para>        
				/// </summary>
				/// <java-name>
				/// LANG_COUNTRY_VAR_AVAILABLE
				/// </java-name>
				[Dot42.DexImport("LANG_COUNTRY_VAR_AVAILABLE", "I", AccessFlags = 25)]
				public const int LANG_COUNTRY_VAR_AVAILABLE = 2;
				/// <summary>
				///  <para>Denotes the language is available for the language and country specified by the locale, but not the variant. </para>        
				/// </summary>
				/// <java-name>
				/// LANG_COUNTRY_AVAILABLE
				/// </java-name>
				[Dot42.DexImport("LANG_COUNTRY_AVAILABLE", "I", AccessFlags = 25)]
				public const int LANG_COUNTRY_AVAILABLE = 1;
				/// <summary>
				///  <para>Denotes the language is available for the language by the locale, but not the country and variant. </para>        
				/// </summary>
				/// <java-name>
				/// LANG_AVAILABLE
				/// </java-name>
				[Dot42.DexImport("LANG_AVAILABLE", "I", AccessFlags = 25)]
				public const int LANG_AVAILABLE = 0;
				/// <summary>
				///  <para>Denotes the language data is missing. </para>        
				/// </summary>
				/// <java-name>
				/// LANG_MISSING_DATA
				/// </java-name>
				[Dot42.DexImport("LANG_MISSING_DATA", "I", AccessFlags = 25)]
				public const int LANG_MISSING_DATA = -1;
				/// <summary>
				///  <para>Denotes the language is not supported. </para>        
				/// </summary>
				/// <java-name>
				/// LANG_NOT_SUPPORTED
				/// </java-name>
				[Dot42.DexImport("LANG_NOT_SUPPORTED", "I", AccessFlags = 25)]
				public const int LANG_NOT_SUPPORTED = -2;
				/// <summary>
				///  <para>Broadcast Action: The TextToSpeech synthesizer has completed processing of all the text in the speech queue.</para> <para>Note that this notifies callers when the  <b>engine</b> has finished has processing text data. Audio playback might not have completed (or even started) at this point. If you wish to be notified when this happens, see OnUtteranceCompletedListener. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_TTS_QUEUE_PROCESSING_COMPLETED
				/// </java-name>
				[Dot42.DexImport("ACTION_TTS_QUEUE_PROCESSING_COMPLETED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_TTS_QUEUE_PROCESSING_COMPLETED = "android.speech.tts.TTS_QUEUE_PROCESSING_COMPLETED";
				/// <summary>
				///  <para>The constructor for the TextToSpeech class, using the default TTS engine. This will also initialize the associated TextToSpeech engine if it isn't already running.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/speech/tts/TextToSpeech$OnInitListener;)V", AccessFlags = 1)]
				public TextToSpeech(global::Android.Content.Context context, global::Android.Speech.Tts.TextToSpeech.IOnInitListener listener) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Releases the resources used by the TextToSpeech engine. It is good practice for instance to call this method in the onDestroy() method of an Activity so the TextToSpeech engine can be cleanly stopped. </para>        
				/// </summary>
				/// <java-name>
				/// shutdown
				/// </java-name>
				[Dot42.DexImport("shutdown", "()V", AccessFlags = 1)]
				public virtual void Shutdown() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Adds a mapping between a string of text and a sound resource in a package. After a call to this method, subsequent calls to speak(String, int, HashMap) will play the specified sound resource if it is available, or synthesize the text it is missing.</para> <para> <code>&lt;manifest xmlns:android="..." package=" <b>com.google.marvin.compass</b>"&gt;</code> </para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Code indicating success or failure. See ERROR and SUCCESS. </para>
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
				///  <para>Adds a mapping between a string of text and a sound file. Using this, it is possible to add custom pronounciations for a string of text. After a call to this method, subsequent calls to speak(String, int, HashMap) will play the specified sound resource if it is available, or synthesize the text it is missing.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Code indicating success or failure. See ERROR and SUCCESS. </para>
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
				///  <para>Adds a mapping between a string of text and a sound resource in a package. Use this to add custom earcons.</para> <para> <para>#playEarcon(String, int, HashMap)</para> <code>&lt;manifest xmlns:android="..." package=" <b>com.google.marvin.compass</b>"&gt;</code> </para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Code indicating success or failure. See ERROR and SUCCESS. </para>
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
				///  <para>Adds a mapping between a string of text and a sound file. Use this to add custom earcons.</para> <para> <para>#playEarcon(String, int, HashMap)</para></para>        
				/// </summary>
				/// <returns>
				///  <para>Code indicating success or failure. See ERROR and SUCCESS. </para>
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
				///  <para>Speaks the string using the specified queuing strategy and speech parameters. This method is asynchronous, i.e. the method just adds the request to the queue of TTS requests and then returns. The synthesis might not have finished (or even started!) at the time when this method returns. In order to reliably detect errors during synthesis, we recommend setting an utterance progress listener (see setOnUtteranceProgressListener) and using the Engine#KEY_PARAM_UTTERANCE_ID parameter.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>ERROR or SUCCESS of  <b>queuing</b> the speak operation. </para>
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
				///  <para>Plays the earcon using the specified queueing mode and parameters. The earcon must already have been added with addEarcon(String, String) or addEarcon(String, String, int). This method is asynchronous, i.e. the method just adds the request to the queue of TTS requests and then returns. The synthesis might not have finished (or even started!) at the time when this method returns. In order to reliably detect errors during synthesis, we recommend setting an utterance progress listener (see setOnUtteranceProgressListener) and using the Engine#KEY_PARAM_UTTERANCE_ID parameter.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>ERROR or SUCCESS of  <b>queuing</b> the playEarcon operation. </para>
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
				///  <para>Plays silence for the specified amount of time using the specified queue mode. This method is asynchronous, i.e. the method just adds the request to the queue of TTS requests and then returns. The synthesis might not have finished (or even started!) at the time when this method returns. In order to reliably detect errors during synthesis, we recommend setting an utterance progress listener (see setOnUtteranceProgressListener) and using the Engine#KEY_PARAM_UTTERANCE_ID parameter.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>ERROR or SUCCESS of  <b>queuing</b> the playSilence operation. </para>
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
				///  <para>Interrupts the current utterance (whether played or rendered to file) and discards other utterances in the queue.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>ERROR or SUCCESS. </para>
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
				///  <para>Sets the speech rate.</para> <para>This has no effect on any pre-recorded speech.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>ERROR or SUCCESS. </para>
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
				///  <para>Sets the speech pitch for the TextToSpeech engine.</para> <para>This has no effect on any pre-recorded speech.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>ERROR or SUCCESS. </para>
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
				///  <para>Sets the text-to-speech language. The TTS engine will try to use the closest match to the specified language as represented by the Locale, but there is no guarantee that the exact same Locale will be used. Use isLanguageAvailable(Locale) to check the level of support before choosing the language to use for the next utterances.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Code indicating the support status for the locale. See LANG_AVAILABLE, LANG_COUNTRY_AVAILABLE, LANG_COUNTRY_VAR_AVAILABLE, LANG_MISSING_DATA and LANG_NOT_SUPPORTED. </para>
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
				///  <para>Checks if the specified language as represented by the Locale is available and supported.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Code indicating the support status for the locale. See LANG_AVAILABLE, LANG_COUNTRY_AVAILABLE, LANG_COUNTRY_VAR_AVAILABLE, LANG_MISSING_DATA and LANG_NOT_SUPPORTED. </para>
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
				///  <para>Synthesizes the given text to a file using the specified parameters. This method is asynchronous, i.e. the method just adds the request to the queue of TTS requests and then returns. The synthesis might not have finished (or even started!) at the time when this method returns. In order to reliably detect errors during synthesis, we recommend setting an utterance progress listener (see setOnUtteranceProgressListener) and using the Engine#KEY_PARAM_UTTERANCE_ID parameter.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>ERROR or SUCCESS of  <b>queuing</b> the synthesizeToFile operation. </para>
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
				///  <para>Sets the listener that will be notified when synthesis of an utterance completes.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use setOnUtteranceProgressListener(UtteranceProgressListener) instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				///  <para>ERROR or SUCCESS.</para>
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
				///  <para>Sets the TTS engine to use.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>This doesn't inform callers when the TTS engine has been initialized. TextToSpeech(Context, OnInitListener, String) can be used with the appropriate engine name. Also, there is no guarantee that the engine specified will be loaded. If it isn't installed or disabled, the user / system wide defaults will apply.</para></xrefdescription></xrefsect></para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>ERROR or SUCCESS. </para>
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
				///  <para>Checks whether the user's settings should override settings requested by the calling application. As of the Ice cream sandwich release, user settings never forcibly override the app's settings. </para>        
				/// </summary>
				/// <java-name>
				/// areDefaultsEnforced
				/// </java-name>
				[Dot42.DexImport("areDefaultsEnforced", "()Z", AccessFlags = 1)]
				public virtual bool AreDefaultsEnforced() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal TextToSpeech() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Checks whether the TTS engine is busy speaking. Note that a speech item is considered complete once it's audio data has been sent to the audio mixer, or written to a file. There might be a finite lag between this point, and when the audio hardware completes playback.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if the TTS engine is speaking. </para>
				/// </returns>
				/// <java-name>
				/// isSpeaking
				/// </java-name>
				public virtual bool IsSpeaking
				{
						[Dot42.DexImport("isSpeaking", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Returns a Locale instance describing the language currently being used for synthesis requests sent to the TextToSpeech engine.</para> <para>In Android 4.2 and before (API &lt;= 17) this function returns the language that is currently being used by the TTS engine. That is the last language set by this or any other client by a TextToSpeech#setLanguage call to the same engine.</para> <para>In Android versions after 4.2 this function returns the language that is currently being used for the synthesis requests sent from this client. That is the last language set by a TextToSpeech#setLanguage call on this instance.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>language, country (if any) and variant (if any) used by the client stored in a Locale instance, or <c>null </c> on error. </para>
				/// </returns>
				/// <java-name>
				/// getLanguage
				/// </java-name>
				public virtual global::Java.Util.Locale Language
				{
						[Dot42.DexImport("getLanguage", "()Ljava/util/Locale;", AccessFlags = 1)]
						get{ return default(global::Java.Util.Locale); }
				}

				/// <summary>
				///  <para>Gets the package name of the default speech synthesis engine.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Package name of the TTS engine that the user has chosen as their default. </para>
				/// </returns>
				/// <java-name>
				/// getDefaultEngine
				/// </java-name>
				public virtual string DefaultEngine
				{
						[Dot42.DexImport("getDefaultEngine", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>Constants and parameter names for controlling text-to-speech. These include:</para> <para> <ul> <li> <para>Intents to ask engine to install data or check its data and extras for a TTS engine's check data activity.  </para></li> <li> <para>Keys for the parameters passed with speak commands, e.g. Engine#KEY_PARAM_UTTERANCE_ID, Engine#KEY_PARAM_STREAM.  </para></li> <li> <para>A list of feature strings that engines might support, e.g Engine#KEY_FEATURE_NETWORK_SYNTHESIS). These values may be passed in to TextToSpeech#speak and TextToSpeech#synthesizeToFile to modify engine behaviour. The engine can be queried for the set of features it supports through TextToSpeech#getFeatures(java.util.Locale).  </para></li></ul></para>    
				/// </summary>
				/// <java-name>
				/// android/speech/tts/TextToSpeech$Engine
				/// </java-name>
				[Dot42.DexImport("android/speech/tts/TextToSpeech$Engine", AccessFlags = 1)]
				public partial class Engine
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>Default audio stream used when playing synthesized speech. </para>        
						/// </summary>
						/// <java-name>
						/// DEFAULT_STREAM
						/// </java-name>
						[Dot42.DexImport("DEFAULT_STREAM", "I", AccessFlags = 25)]
						public const int DEFAULT_STREAM = 3;
						/// <summary>
						///  <para>Indicates success when checking the installation status of the resources used by the TextToSpeech engine with the ACTION_CHECK_TTS_DATA intent. </para>        
						/// </summary>
						/// <java-name>
						/// CHECK_VOICE_DATA_PASS
						/// </java-name>
						[Dot42.DexImport("CHECK_VOICE_DATA_PASS", "I", AccessFlags = 25)]
						public const int CHECK_VOICE_DATA_PASS = 1;
						/// <summary>
						///  <para>Indicates failure when checking the installation status of the resources used by the TextToSpeech engine with the ACTION_CHECK_TTS_DATA intent. </para>        
						/// </summary>
						/// <java-name>
						/// CHECK_VOICE_DATA_FAIL
						/// </java-name>
						[Dot42.DexImport("CHECK_VOICE_DATA_FAIL", "I", AccessFlags = 25)]
						public const int CHECK_VOICE_DATA_FAIL = 0;
						/// <summary>
						///  <para>Indicates erroneous data when checking the installation status of the resources used by the TextToSpeech engine with the ACTION_CHECK_TTS_DATA intent.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use CHECK_VOICE_DATA_FAIL instead. </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// CHECK_VOICE_DATA_BAD_DATA
						/// </java-name>
						[Dot42.DexImport("CHECK_VOICE_DATA_BAD_DATA", "I", AccessFlags = 25)]
						public const int CHECK_VOICE_DATA_BAD_DATA = -1;
						/// <summary>
						///  <para>Indicates missing resources when checking the installation status of the resources used by the TextToSpeech engine with the ACTION_CHECK_TTS_DATA intent.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use CHECK_VOICE_DATA_FAIL instead. </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// CHECK_VOICE_DATA_MISSING_DATA
						/// </java-name>
						[Dot42.DexImport("CHECK_VOICE_DATA_MISSING_DATA", "I", AccessFlags = 25)]
						public const int CHECK_VOICE_DATA_MISSING_DATA = -2;
						/// <summary>
						///  <para>Indicates missing storage volume when checking the installation status of the resources used by the TextToSpeech engine with the ACTION_CHECK_TTS_DATA intent.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use CHECK_VOICE_DATA_FAIL instead. </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// CHECK_VOICE_DATA_MISSING_VOLUME
						/// </java-name>
						[Dot42.DexImport("CHECK_VOICE_DATA_MISSING_VOLUME", "I", AccessFlags = 25)]
						public const int CHECK_VOICE_DATA_MISSING_VOLUME = -3;
						/// <summary>
						///  <para>Activity Action: Triggers the platform TextToSpeech engine to start the activity that installs the resource files on the device that are required for TTS to be operational. Since the installation of the data can be interrupted or declined by the user, the application shouldn't expect successful installation upon return from that intent, and if need be, should check installation status with ACTION_CHECK_TTS_DATA. </para>        
						/// </summary>
						/// <java-name>
						/// ACTION_INSTALL_TTS_DATA
						/// </java-name>
						[Dot42.DexImport("ACTION_INSTALL_TTS_DATA", "Ljava/lang/String;", AccessFlags = 25)]
						public const string ACTION_INSTALL_TTS_DATA = "android.speech.tts.engine.INSTALL_TTS_DATA";
						/// <summary>
						///  <para>Broadcast Action: broadcast to signal the change in the list of available languages or/and their features. </para>        
						/// </summary>
						/// <java-name>
						/// ACTION_TTS_DATA_INSTALLED
						/// </java-name>
						[Dot42.DexImport("ACTION_TTS_DATA_INSTALLED", "Ljava/lang/String;", AccessFlags = 25)]
						public const string ACTION_TTS_DATA_INSTALLED = "android.speech.tts.engine.TTS_DATA_INSTALLED";
						/// <summary>
						///  <para>Activity Action: Starts the activity from the platform TextToSpeech engine to verify the proper installation and availability of the resource files on the system. Upon completion, the activity will return one of the following codes: CHECK_VOICE_DATA_PASS, CHECK_VOICE_DATA_FAIL, </para> <para>Moreover, the data received in the activity result will contain the following fields:  <ul> <li> <para>EXTRA_AVAILABLE_VOICES which contains an ArrayList&lt;String&gt; of all the available voices. The format of each voice is: lang-COUNTRY-variant where COUNTRY and variant are optional (ie, "eng" or "eng-USA" or "eng-USA-FEMALE"). </para></li> <li> <para>EXTRA_UNAVAILABLE_VOICES which contains an ArrayList&lt;String&gt; of all the unavailable voices (ones that user can install). The format of each voice is: lang-COUNTRY-variant where COUNTRY and variant are optional (ie, "eng" or "eng-USA" or "eng-USA-FEMALE"). </para></li></ul></para>        
						/// </summary>
						/// <java-name>
						/// ACTION_CHECK_TTS_DATA
						/// </java-name>
						[Dot42.DexImport("ACTION_CHECK_TTS_DATA", "Ljava/lang/String;", AccessFlags = 25)]
						public const string ACTION_CHECK_TTS_DATA = "android.speech.tts.engine.CHECK_TTS_DATA";
						/// <summary>
						///  <para>Extra information received with the ACTION_CHECK_TTS_DATA intent result where the TextToSpeech engine specifies the path to its resources.</para> <para>It may be used by language packages to find out where to put their data.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>TTS engine implementation detail, this information has no use for text-to-speech API client. </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// EXTRA_VOICE_DATA_ROOT_DIRECTORY
						/// </java-name>
						[Dot42.DexImport("EXTRA_VOICE_DATA_ROOT_DIRECTORY", "Ljava/lang/String;", AccessFlags = 25)]
						public const string EXTRA_VOICE_DATA_ROOT_DIRECTORY = "dataRoot";
						/// <summary>
						///  <para>Extra information received with the ACTION_CHECK_TTS_DATA intent result where the TextToSpeech engine specifies the file names of its resources under the resource path.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>TTS engine implementation detail, this information has no use for text-to-speech API client. </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// EXTRA_VOICE_DATA_FILES
						/// </java-name>
						[Dot42.DexImport("EXTRA_VOICE_DATA_FILES", "Ljava/lang/String;", AccessFlags = 25)]
						public const string EXTRA_VOICE_DATA_FILES = "dataFiles";
						/// <summary>
						///  <para>Extra information received with the ACTION_CHECK_TTS_DATA intent result where the TextToSpeech engine specifies the locale associated with each resource file.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>TTS engine implementation detail, this information has no use for text-to-speech API client. </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// EXTRA_VOICE_DATA_FILES_INFO
						/// </java-name>
						[Dot42.DexImport("EXTRA_VOICE_DATA_FILES_INFO", "Ljava/lang/String;", AccessFlags = 25)]
						public const string EXTRA_VOICE_DATA_FILES_INFO = "dataFilesInfo";
						/// <summary>
						///  <para>Extra information received with the ACTION_CHECK_TTS_DATA intent result where the TextToSpeech engine returns an ArrayList&lt;String&gt; of all the available voices. The format of each voice is: lang-COUNTRY-variant where COUNTRY and variant are optional (ie, "eng" or "eng-USA" or "eng-USA-FEMALE"). </para>        
						/// </summary>
						/// <java-name>
						/// EXTRA_AVAILABLE_VOICES
						/// </java-name>
						[Dot42.DexImport("EXTRA_AVAILABLE_VOICES", "Ljava/lang/String;", AccessFlags = 25)]
						public const string EXTRA_AVAILABLE_VOICES = "availableVoices";
						/// <summary>
						///  <para>Extra information received with the ACTION_CHECK_TTS_DATA intent result where the TextToSpeech engine returns an ArrayList&lt;String&gt; of all the unavailable voices. The format of each voice is: lang-COUNTRY-variant where COUNTRY and variant are optional (ie, "eng" or "eng-USA" or "eng-USA-FEMALE"). </para>        
						/// </summary>
						/// <java-name>
						/// EXTRA_UNAVAILABLE_VOICES
						/// </java-name>
						[Dot42.DexImport("EXTRA_UNAVAILABLE_VOICES", "Ljava/lang/String;", AccessFlags = 25)]
						public const string EXTRA_UNAVAILABLE_VOICES = "unavailableVoices";
						/// <summary>
						///  <para>Extra information sent with the ACTION_CHECK_TTS_DATA intent where the caller indicates to the TextToSpeech engine which specific sets of voice data to check for by sending an ArrayList&lt;String&gt; of the voices that are of interest. The format of each voice is: lang-COUNTRY-variant where COUNTRY and variant are optional (ie, "eng" or "eng-USA" or "eng-USA-FEMALE").</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Redundant functionality, checking for existence of specific sets of voice data can be done on client side. </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// EXTRA_CHECK_VOICE_DATA_FOR
						/// </java-name>
						[Dot42.DexImport("EXTRA_CHECK_VOICE_DATA_FOR", "Ljava/lang/String;", AccessFlags = 25)]
						public const string EXTRA_CHECK_VOICE_DATA_FOR = "checkVoiceDataFor";
						/// <summary>
						///  <para>Extra information received with the ACTION_TTS_DATA_INSTALLED intent result. It indicates whether the data files for the synthesis engine were successfully installed. The installation was initiated with the ACTION_INSTALL_TTS_DATA intent. The possible values for this extra are TextToSpeech#SUCCESS and TextToSpeech#ERROR.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>No longer in use. If client ise interested in information about what changed, is should send ACTION_CHECK_TTS_DATA intent to discover available voices. </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// EXTRA_TTS_DATA_INSTALLED
						/// </java-name>
						[Dot42.DexImport("EXTRA_TTS_DATA_INSTALLED", "Ljava/lang/String;", AccessFlags = 25)]
						public const string EXTRA_TTS_DATA_INSTALLED = "dataInstalled";
						/// <summary>
						///  <para>Parameter key to specify the audio stream type to be used when speaking text or playing back a file. The value should be one of the STREAM_ constants defined in AudioManager.</para> <para> <para>TextToSpeech::speak(String, int, HashMap) </para> <para>TextToSpeech::playEarcon(String, int, HashMap) </para></para>        
						/// </summary>
						/// <java-name>
						/// KEY_PARAM_STREAM
						/// </java-name>
						[Dot42.DexImport("KEY_PARAM_STREAM", "Ljava/lang/String;", AccessFlags = 25)]
						public const string KEY_PARAM_STREAM = "streamType";
						/// <summary>
						///  <para>Parameter key to identify an utterance in the TextToSpeech.OnUtteranceCompletedListener after text has been spoken, a file has been played back or a silence duration has elapsed.</para> <para> <para>TextToSpeech::speak(String, int, HashMap) </para> <para>TextToSpeech::playEarcon(String, int, HashMap) </para> <para>TextToSpeech::synthesizeToFile(String, HashMap, String) </para></para>        
						/// </summary>
						/// <java-name>
						/// KEY_PARAM_UTTERANCE_ID
						/// </java-name>
						[Dot42.DexImport("KEY_PARAM_UTTERANCE_ID", "Ljava/lang/String;", AccessFlags = 25)]
						public const string KEY_PARAM_UTTERANCE_ID = "utteranceId";
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
						protected internal Engine() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

				}

				/// <summary>
				///  <para>Listener that will be called when the TTS service has completed synthesizing an utterance. This is only called if the utterance has an utterance ID (see TextToSpeech.Engine#KEY_PARAM_UTTERANCE_ID).</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use UtteranceProgressListener instead. </para></xrefdescription></xrefsect></para>    
				/// </summary>
				/// <java-name>
				/// android/speech/tts/TextToSpeech$OnUtteranceCompletedListener
				/// </java-name>
				[Dot42.DexImport("android/speech/tts/TextToSpeech$OnUtteranceCompletedListener", AccessFlags = 1545)]
				public partial interface IOnUtteranceCompletedListener
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>Called when an utterance has been synthesized.</para> <para></para>        
						/// </summary>
						/// <java-name>
						/// onUtteranceCompleted
						/// </java-name>
						[Dot42.DexImport("onUtteranceCompleted", "(Ljava/lang/String;)V", AccessFlags = 1025)]
						void OnUtteranceCompleted(string utteranceId) /* MethodBuilder.Create */ ;

				}

				/// <summary>
				///  <para>Interface definition of a callback to be invoked indicating the completion of the TextToSpeech engine initialization. </para>    
				/// </summary>
				/// <java-name>
				/// android/speech/tts/TextToSpeech$OnInitListener
				/// </java-name>
				[Dot42.DexImport("android/speech/tts/TextToSpeech$OnInitListener", AccessFlags = 1545)]
				public partial interface IOnInitListener
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>Called to signal the completion of the TextToSpeech engine initialization.</para> <para></para>        
						/// </summary>
						/// <java-name>
						/// onInit
						/// </java-name>
						[Dot42.DexImport("onInit", "(I)V", AccessFlags = 1025)]
						void OnInit(int status) /* MethodBuilder.Create */ ;

				}

		}

}

