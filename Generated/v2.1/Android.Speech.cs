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
				/// <para>Optional limit on the maximum number of results to return. If omitted the recognizer will choose how many results to return. Must be an integer. </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_MAX_RESULTS
				/// </java-name>
				[Dot42.DexImport("EXTRA_MAX_RESULTS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_MAX_RESULTS = "android.speech.extra.MAX_RESULTS";
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
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal RecognizerIntent() /* MethodBuilder.Create */ 
				{
				}

		}

}


