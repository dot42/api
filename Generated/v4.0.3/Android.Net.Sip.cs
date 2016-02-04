#pragma warning disable 1717
namespace Android.Net.Sip
{
		/// <summary>
		///  <para>Listener for SIP registration events. </para>    
		/// </summary>
		/// <java-name>
		/// android/net/sip/SipRegistrationListener
		/// </java-name>
		[Dot42.DexImport("android/net/sip/SipRegistrationListener", AccessFlags = 1537)]
		public partial interface ISipRegistrationListener
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Called when a registration request is sent.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// onRegistering
				/// </java-name>
				[Dot42.DexImport("onRegistering", "(Ljava/lang/String;)V", AccessFlags = 1025)]
				void OnRegistering(string localProfileUri) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Called when the registration succeeded.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// onRegistrationDone
				/// </java-name>
				[Dot42.DexImport("onRegistrationDone", "(Ljava/lang/String;J)V", AccessFlags = 1025)]
				void OnRegistrationDone(string localProfileUri, long expiryTime) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Called when the registration failed.</para> <para> <para>SipErrorCode </para></para>        
				/// </summary>
				/// <java-name>
				/// onRegistrationFailed
				/// </java-name>
				[Dot42.DexImport("onRegistrationFailed", "(Ljava/lang/String;ILjava/lang/String;)V", AccessFlags = 1025)]
				void OnRegistrationFailed(string localProfileUri, int errorCode, string errorMessage) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		///  <para>Handles an Internet audio call over SIP. You can instantiate this class with SipManager, using makeAudioCall() and takeAudioCall().</para> <para> <b>Note:</b> Using this class require the android.Manifest.permission#INTERNET and android.Manifest.permission#USE_SIP permissions. In addition, startAudio requires the android.Manifest.permission#RECORD_AUDIO, android.Manifest.permission#ACCESS_WIFI_STATE, and android.Manifest.permission#WAKE_LOCK permissions; and setSpeakerMode() requires the android.Manifest.permission#MODIFY_AUDIO_SETTINGS permission.</para> <para>  <h3>Developer Guides</h3></para> <para> </para> <para>For more information about using SIP, read the  developer guide.</para> <para>  </para>    
		/// </summary>
		/// <java-name>
		/// android/net/sip/SipAudioCall
		/// </java-name>
		[Dot42.DexImport("android/net/sip/SipAudioCall", AccessFlags = 33)]
		public partial class SipAudioCall
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Creates a call object with the local SIP profile. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/net/sip/SipProfile;)V", AccessFlags = 1)]
				public SipAudioCall(global::Android.Content.Context context, global::Android.Net.Sip.SipProfile localProfile) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the listener to listen to the audio call events. The method calls setListener(listener, false).</para> <para> <para>#setListener(Listener, boolean) </para></para>        
				/// </summary>
				/// <java-name>
				/// setListener
				/// </java-name>
				[Dot42.DexImport("setListener", "(Landroid/net/sip/SipAudioCall$Listener;)V", AccessFlags = 1)]
				public virtual void SetListener(global::Android.Net.Sip.SipAudioCall.Listener listener) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the listener to listen to the audio call events. A SipAudioCall can only hold one listener at a time. Subsequent calls to this method override the previous listener.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setListener
				/// </java-name>
				[Dot42.DexImport("setListener", "(Landroid/net/sip/SipAudioCall$Listener;Z)V", AccessFlags = 1)]
				public virtual void SetListener(global::Android.Net.Sip.SipAudioCall.Listener listener, bool callbackImmediately) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Closes this object. This object is not usable after being closed. </para>        
				/// </summary>
				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1)]
				public virtual void Close() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Attaches an incoming call to this call object.</para> <para> <para>SipManager::isVoipSupported </para></para>        
				/// </summary>
				/// <java-name>
				/// attachCall
				/// </java-name>
				[Dot42.DexImport("attachCall", "(Landroid/net/sip/SipSession;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void AttachCall(global::Android.Net.Sip.SipSession session, string sessionDescription) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Initiates an audio call to the specified profile. The attempt will be timed out if the call is not established within <c>timeout </c> seconds and onError(SipAudioCall, SipErrorCode.TIME_OUT, String) will be called.</para> <para> <para>Listener::onError </para> <para>SipManager::isVoipSupported </para></para>        
				/// </summary>
				/// <java-name>
				/// makeCall
				/// </java-name>
				[Dot42.DexImport("makeCall", "(Landroid/net/sip/SipProfile;Landroid/net/sip/SipSession;I)V", AccessFlags = 1)]
				public virtual void MakeCall(global::Android.Net.Sip.SipProfile peerProfile, global::Android.Net.Sip.SipSession sipSession, int timeout) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Ends a call. </para>        
				/// </summary>
				/// <java-name>
				/// endCall
				/// </java-name>
				[Dot42.DexImport("endCall", "()V", AccessFlags = 1)]
				public virtual void EndCall() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Puts a call on hold. When succeeds, Listener#onCallHeld is called. The attempt will be timed out if the call is not established within <c>timeout </c> seconds and onError(SipAudioCall, SipErrorCode.TIME_OUT, String) will be called.</para> <para> <para>Listener::onError </para></para>        
				/// </summary>
				/// <java-name>
				/// holdCall
				/// </java-name>
				[Dot42.DexImport("holdCall", "(I)V", AccessFlags = 1)]
				public virtual void HoldCall(int timeout) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Answers a call. The attempt will be timed out if the call is not established within <c>timeout </c> seconds and onError(SipAudioCall, SipErrorCode.TIME_OUT, String) will be called.</para> <para> <para>Listener::onError </para></para>        
				/// </summary>
				/// <java-name>
				/// answerCall
				/// </java-name>
				[Dot42.DexImport("answerCall", "(I)V", AccessFlags = 1)]
				public virtual void AnswerCall(int timeout) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Continues a call that's on hold. When succeeds, Listener#onCallEstablished is called. The attempt will be timed out if the call is not established within <c>timeout </c> seconds and onError(SipAudioCall, SipErrorCode.TIME_OUT, String) will be called.</para> <para> <para>Listener::onError </para></para>        
				/// </summary>
				/// <java-name>
				/// continueCall
				/// </java-name>
				[Dot42.DexImport("continueCall", "(I)V", AccessFlags = 1)]
				public virtual void ContinueCall(int timeout) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Toggles mute. </para>        
				/// </summary>
				/// <java-name>
				/// toggleMute
				/// </java-name>
				[Dot42.DexImport("toggleMute", "()V", AccessFlags = 1)]
				public virtual void ToggleMute() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Puts the device to speaker mode. </para> <para> <b>Note:</b> Requires the android.Manifest.permission#MODIFY_AUDIO_SETTINGS permission.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setSpeakerMode
				/// </java-name>
				[Dot42.DexImport("setSpeakerMode", "(Z)V", AccessFlags = 1)]
				public virtual void SetSpeakerMode(bool speakerMode) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sends a DTMF code. According to , event 09 maps to decimal value 09, '*' to 10, '#' to 11, event 'A''D' to 1215, and event flash to 16. Currently, event flash is not supported.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// sendDtmf
				/// </java-name>
				[Dot42.DexImport("sendDtmf", "(I)V", AccessFlags = 1)]
				public virtual void SendDtmf(int code) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sends a DTMF code. According to , event 09 maps to decimal value 09, '*' to 10, '#' to 11, event 'A''D' to 1215, and event flash to 16. Currently, event flash is not supported.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// sendDtmf
				/// </java-name>
				[Dot42.DexImport("sendDtmf", "(ILandroid/os/Message;)V", AccessFlags = 1)]
				public virtual void SendDtmf(int code, global::Android.OS.Message result) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Starts the audio for the established call. This method should be called after Listener#onCallEstablished is called. </para> <para> <b>Note:</b> Requires the android.Manifest.permission#RECORD_AUDIO, android.Manifest.permission#ACCESS_WIFI_STATE and android.Manifest.permission#WAKE_LOCK permissions.</para>        
				/// </summary>
				/// <java-name>
				/// startAudio
				/// </java-name>
				[Dot42.DexImport("startAudio", "()V", AccessFlags = 1)]
				public virtual void StartAudio() /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal SipAudioCall() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Checks if the call is established.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if the call is established </para>
				/// </returns>
				/// <java-name>
				/// isInCall
				/// </java-name>
				public virtual bool IsInCall
				{
						[Dot42.DexImport("isInCall", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Checks if the call is on hold.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if the call is on hold </para>
				/// </returns>
				/// <java-name>
				/// isOnHold
				/// </java-name>
				public virtual bool IsOnHold
				{
						[Dot42.DexImport("isOnHold", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Gets the local SIP profile.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the local SIP profile </para>
				/// </returns>
				/// <java-name>
				/// getLocalProfile
				/// </java-name>
				public virtual global::Android.Net.Sip.SipProfile LocalProfile
				{
						[Dot42.DexImport("getLocalProfile", "()Landroid/net/sip/SipProfile;", AccessFlags = 1)]
						get{ return default(global::Android.Net.Sip.SipProfile); }
				}

				/// <summary>
				///  <para>Gets the peer's SIP profile.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the peer's SIP profile </para>
				/// </returns>
				/// <java-name>
				/// getPeerProfile
				/// </java-name>
				public virtual global::Android.Net.Sip.SipProfile PeerProfile
				{
						[Dot42.DexImport("getPeerProfile", "()Landroid/net/sip/SipProfile;", AccessFlags = 1)]
						get{ return default(global::Android.Net.Sip.SipProfile); }
				}

				/// <summary>
				///  <para>Gets the state of the SipSession that carries this call. The value returned must be one of the states in SipSession.State.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the session state </para>
				/// </returns>
				/// <java-name>
				/// getState
				/// </java-name>
				public virtual int State
				{
						[Dot42.DexImport("getState", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Checks if the call is muted.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if the call is muted </para>
				/// </returns>
				/// <java-name>
				/// isMuted
				/// </java-name>
				public virtual bool IsMuted
				{
						[Dot42.DexImport("isMuted", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Listener for events relating to a SIP call, such as when a call is being recieved ("on ringing") or a call is outgoing ("on calling"). </para> <para>Many of these events are also received by SipSession.Listener.</para>    
				/// </summary>
				/// <java-name>
				/// android/net/sip/SipAudioCall$Listener
				/// </java-name>
				[Dot42.DexImport("android/net/sip/SipAudioCall$Listener", AccessFlags = 9)]
				public partial class Listener
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public Listener() /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Called when the call object is ready to make another call. The default implementation calls onChanged.</para> <para></para>        
						/// </summary>
						/// <java-name>
						/// onReadyToCall
						/// </java-name>
						[Dot42.DexImport("onReadyToCall", "(Landroid/net/sip/SipAudioCall;)V", AccessFlags = 1)]
						public virtual void OnReadyToCall(global::Android.Net.Sip.SipAudioCall call) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Called when a request is sent out to initiate a new call. The default implementation calls onChanged.</para> <para></para>        
						/// </summary>
						/// <java-name>
						/// onCalling
						/// </java-name>
						[Dot42.DexImport("onCalling", "(Landroid/net/sip/SipAudioCall;)V", AccessFlags = 1)]
						public virtual void OnCalling(global::Android.Net.Sip.SipAudioCall call) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Called when a new call comes in. The default implementation calls onChanged.</para> <para></para>        
						/// </summary>
						/// <java-name>
						/// onRinging
						/// </java-name>
						[Dot42.DexImport("onRinging", "(Landroid/net/sip/SipAudioCall;Landroid/net/sip/SipProfile;)V", AccessFlags = 1)]
						public virtual void OnRinging(global::Android.Net.Sip.SipAudioCall call, global::Android.Net.Sip.SipProfile caller) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Called when a RINGING response is received for the INVITE request sent. The default implementation calls onChanged.</para> <para></para>        
						/// </summary>
						/// <java-name>
						/// onRingingBack
						/// </java-name>
						[Dot42.DexImport("onRingingBack", "(Landroid/net/sip/SipAudioCall;)V", AccessFlags = 1)]
						public virtual void OnRingingBack(global::Android.Net.Sip.SipAudioCall call) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Called when the session is established. The default implementation calls onChanged.</para> <para></para>        
						/// </summary>
						/// <java-name>
						/// onCallEstablished
						/// </java-name>
						[Dot42.DexImport("onCallEstablished", "(Landroid/net/sip/SipAudioCall;)V", AccessFlags = 1)]
						public virtual void OnCallEstablished(global::Android.Net.Sip.SipAudioCall call) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Called when the session is terminated. The default implementation calls onChanged.</para> <para></para>        
						/// </summary>
						/// <java-name>
						/// onCallEnded
						/// </java-name>
						[Dot42.DexImport("onCallEnded", "(Landroid/net/sip/SipAudioCall;)V", AccessFlags = 1)]
						public virtual void OnCallEnded(global::Android.Net.Sip.SipAudioCall call) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Called when the peer is busy during session initialization. The default implementation calls onChanged.</para> <para></para>        
						/// </summary>
						/// <java-name>
						/// onCallBusy
						/// </java-name>
						[Dot42.DexImport("onCallBusy", "(Landroid/net/sip/SipAudioCall;)V", AccessFlags = 1)]
						public virtual void OnCallBusy(global::Android.Net.Sip.SipAudioCall call) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Called when the call is on hold. The default implementation calls onChanged.</para> <para></para>        
						/// </summary>
						/// <java-name>
						/// onCallHeld
						/// </java-name>
						[Dot42.DexImport("onCallHeld", "(Landroid/net/sip/SipAudioCall;)V", AccessFlags = 1)]
						public virtual void OnCallHeld(global::Android.Net.Sip.SipAudioCall call) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Called when an error occurs. The default implementation is no op.</para> <para> <para>SipErrorCode </para></para>        
						/// </summary>
						/// <java-name>
						/// onError
						/// </java-name>
						[Dot42.DexImport("onError", "(Landroid/net/sip/SipAudioCall;ILjava/lang/String;)V", AccessFlags = 1)]
						public virtual void OnError(global::Android.Net.Sip.SipAudioCall call, int errorCode, string errorMessage) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Called when an event occurs and the corresponding callback is not overridden. The default implementation is no op. Error events are not re-directed to this callback and are handled in onError. </para>        
						/// </summary>
						/// <java-name>
						/// onChanged
						/// </java-name>
						[Dot42.DexImport("onChanged", "(Landroid/net/sip/SipAudioCall;)V", AccessFlags = 1)]
						public virtual void OnChanged(global::Android.Net.Sip.SipAudioCall call) /* MethodBuilder.Create */ 
						{
						}

				}

		}

		/// <summary>
		///  <para>Defines error codes returned during SIP actions. For example, during onRegistrationFailed(), onError(), onCallChangeFailed() and onRegistrationFailed(). </para>    
		/// </summary>
		/// <java-name>
		/// android/net/sip/SipErrorCode
		/// </java-name>
		[Dot42.DexImport("android/net/sip/SipErrorCode", AccessFlags = 33)]
		public partial class SipErrorCode
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Not an error. </para>        
				/// </summary>
				/// <java-name>
				/// NO_ERROR
				/// </java-name>
				[Dot42.DexImport("NO_ERROR", "I", AccessFlags = 25)]
				public const int NO_ERROR = 0;
				/// <summary>
				///  <para>When some socket error occurs. </para>        
				/// </summary>
				/// <java-name>
				/// SOCKET_ERROR
				/// </java-name>
				[Dot42.DexImport("SOCKET_ERROR", "I", AccessFlags = 25)]
				public const int SOCKET_ERROR = -1;
				/// <summary>
				///  <para>When server responds with an error. </para>        
				/// </summary>
				/// <java-name>
				/// SERVER_ERROR
				/// </java-name>
				[Dot42.DexImport("SERVER_ERROR", "I", AccessFlags = 25)]
				public const int SERVER_ERROR = -2;
				/// <summary>
				///  <para>When transaction is terminated unexpectedly. </para>        
				/// </summary>
				/// <java-name>
				/// TRANSACTION_TERMINTED
				/// </java-name>
				[Dot42.DexImport("TRANSACTION_TERMINTED", "I", AccessFlags = 25)]
				public const int TRANSACTION_TERMINTED = -3;
				/// <summary>
				///  <para>When some error occurs on the device, possibly due to a bug. </para>        
				/// </summary>
				/// <java-name>
				/// CLIENT_ERROR
				/// </java-name>
				[Dot42.DexImport("CLIENT_ERROR", "I", AccessFlags = 25)]
				public const int CLIENT_ERROR = -4;
				/// <summary>
				///  <para>When the transaction gets timed out. </para>        
				/// </summary>
				/// <java-name>
				/// TIME_OUT
				/// </java-name>
				[Dot42.DexImport("TIME_OUT", "I", AccessFlags = 25)]
				public const int TIME_OUT = -5;
				/// <summary>
				///  <para>When the remote URI is not valid. </para>        
				/// </summary>
				/// <java-name>
				/// INVALID_REMOTE_URI
				/// </java-name>
				[Dot42.DexImport("INVALID_REMOTE_URI", "I", AccessFlags = 25)]
				public const int INVALID_REMOTE_URI = -6;
				/// <summary>
				///  <para>When the peer is not reachable. </para>        
				/// </summary>
				/// <java-name>
				/// PEER_NOT_REACHABLE
				/// </java-name>
				[Dot42.DexImport("PEER_NOT_REACHABLE", "I", AccessFlags = 25)]
				public const int PEER_NOT_REACHABLE = -7;
				/// <summary>
				///  <para>When invalid credentials are provided. </para>        
				/// </summary>
				/// <java-name>
				/// INVALID_CREDENTIALS
				/// </java-name>
				[Dot42.DexImport("INVALID_CREDENTIALS", "I", AccessFlags = 25)]
				public const int INVALID_CREDENTIALS = -8;
				/// <summary>
				///  <para>The client is in a transaction and cannot initiate a new one. </para>        
				/// </summary>
				/// <java-name>
				/// IN_PROGRESS
				/// </java-name>
				[Dot42.DexImport("IN_PROGRESS", "I", AccessFlags = 25)]
				public const int IN_PROGRESS = -9;
				/// <summary>
				///  <para>When data connection is lost. </para>        
				/// </summary>
				/// <java-name>
				/// DATA_CONNECTION_LOST
				/// </java-name>
				[Dot42.DexImport("DATA_CONNECTION_LOST", "I", AccessFlags = 25)]
				public const int DATA_CONNECTION_LOST = -10;
				/// <summary>
				///  <para>Cross-domain authentication required. </para>        
				/// </summary>
				/// <java-name>
				/// CROSS_DOMAIN_AUTHENTICATION
				/// </java-name>
				[Dot42.DexImport("CROSS_DOMAIN_AUTHENTICATION", "I", AccessFlags = 25)]
				public const int CROSS_DOMAIN_AUTHENTICATION = -11;
				/// <summary>
				///  <para>When the server is not reachable. </para>        
				/// </summary>
				/// <java-name>
				/// SERVER_UNREACHABLE
				/// </java-name>
				[Dot42.DexImport("SERVER_UNREACHABLE", "I", AccessFlags = 25)]
				public const int SERVER_UNREACHABLE = -12;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal SipErrorCode() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "(I)Ljava/lang/String;", AccessFlags = 9)]
				public static string ToString(int errorCode) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

		}

		/// <summary>
		///  <para>Indicates a general SIP-related exception. </para>    
		/// </summary>
		/// <java-name>
		/// android/net/sip/SipException
		/// </java-name>
		[Dot42.DexImport("android/net/sip/SipException", AccessFlags = 33)]
		public partial class SipException : global::System.Exception
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public SipException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public SipException(string message) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public SipException(string message, global::System.Exception cause) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>Provides APIs for SIP tasks, such as initiating SIP connections, and provides access to related SIP services. This class is the starting point for any SIP actions. You can acquire an instance of it with newInstance().</para> <para>The APIs in this class allows you to:</para> <para> <ul> <li> <para>Create a SipSession to get ready for making calls or listen for incoming calls. See createSipSession() and getSessionFor(). </para></li> <li> <para>Initiate and receive generic SIP calls or audio-only SIP calls. Generic SIP calls may be video, audio, or other, and are initiated with open(). Audio-only SIP calls should be handled with a SipAudioCall, which you can acquire with makeAudioCall() and takeAudioCall(). </para></li> <li> <para>Register and unregister with a SIP service provider, with register() and unregister(). </para></li> <li> <para>Verify session connectivity, with isOpened() and isRegistered(). </para></li></ul></para> <para> <b>Note:</b> Not all Android-powered devices support VOIP calls using SIP. You should always call isVoipSupported() to verify that the device supports VOIP calling and isApiSupported() to verify that the device supports the SIP APIs. Your application must also request the android.Manifest.permission#INTERNET and android.Manifest.permission#USE_SIP permissions.</para> <para>  <h3>Developer Guides</h3></para> <para> </para> <para>For more information about using SIP, read the  developer guide.</para> <para>  </para>    
		/// </summary>
		/// <java-name>
		/// android/net/sip/SipManager
		/// </java-name>
		[Dot42.DexImport("android/net/sip/SipManager", AccessFlags = 33)]
		public partial class SipManager
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>The result code to be sent back with the incoming call PendingIntent.  <para>open(SipProfile, PendingIntent, SipRegistrationListener) </para></para>        
				/// </summary>
				/// <java-name>
				/// INCOMING_CALL_RESULT_CODE
				/// </java-name>
				[Dot42.DexImport("INCOMING_CALL_RESULT_CODE", "I", AccessFlags = 25)]
				public const int INCOMING_CALL_RESULT_CODE = 101;
				/// <summary>
				///  <para>Key to retrieve the call ID from an incoming call intent.  <para>open(SipProfile, PendingIntent, SipRegistrationListener) </para></para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_CALL_ID
				/// </java-name>
				[Dot42.DexImport("EXTRA_CALL_ID", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_CALL_ID = "android:sipCallID";
				/// <summary>
				///  <para>Key to retrieve the offered session description from an incoming call intent.  <para>open(SipProfile, PendingIntent, SipRegistrationListener) </para></para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_OFFER_SD
				/// </java-name>
				[Dot42.DexImport("EXTRA_OFFER_SD", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_OFFER_SD = "android:sipOfferSD";
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal SipManager() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Creates a manager instance. Returns null if SIP API is not supported.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the manager instance or null if SIP API is not supported </para>
				/// </returns>
				/// <java-name>
				/// newInstance
				/// </java-name>
				[Dot42.DexImport("newInstance", "(Landroid/content/Context;)Landroid/net/sip/SipManager;", AccessFlags = 9)]
				public static global::Android.Net.Sip.SipManager NewInstance(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Net.Sip.SipManager);
				}

				/// <summary>
				///  <para>Returns true if the SIP API is supported by the system. </para>        
				/// </summary>
				/// <java-name>
				/// isApiSupported
				/// </java-name>
				[Dot42.DexImport("isApiSupported", "(Landroid/content/Context;)Z", AccessFlags = 9)]
				public static bool IsApiSupported(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Returns true if the system supports SIP-based VOIP API. </para>        
				/// </summary>
				/// <java-name>
				/// isVoipSupported
				/// </java-name>
				[Dot42.DexImport("isVoipSupported", "(Landroid/content/Context;)Z", AccessFlags = 9)]
				public static bool IsVoipSupported(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Returns true if SIP is only available on WIFI. </para>        
				/// </summary>
				/// <java-name>
				/// isSipWifiOnly
				/// </java-name>
				[Dot42.DexImport("isSipWifiOnly", "(Landroid/content/Context;)Z", AccessFlags = 9)]
				public static bool IsSipWifiOnly(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Opens the profile for making generic SIP calls. The caller may make subsequent calls through makeAudioCall. If one also wants to receive calls on the profile, use open(SipProfile, PendingIntent, SipRegistrationListener) instead.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// open
				/// </java-name>
				[Dot42.DexImport("open", "(Landroid/net/sip/SipProfile;)V", AccessFlags = 1)]
				public virtual void Open(global::Android.Net.Sip.SipProfile localProfile) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Opens the profile for making calls and/or receiving generic SIP calls. The caller may make subsequent calls through makeAudioCall. If the auto-registration option is enabled in the profile, the SIP service will register the profile to the corresponding SIP provider periodically in order to receive calls from the provider. When the SIP service receives a new call, it will send out an intent with the provided action string. The intent contains a call ID extra and an offer session description string extra. Use getCallId and getOfferSessionDescription to retrieve those extras.</para> <para> <para>getCallId </para> <para>getOfferSessionDescription </para> <para>takeAudioCall </para> <para>isIncomingCallIntent </para> <para>getCallId </para> <para>getOfferSessionDescription </para></para>        
				/// </summary>
				/// <java-name>
				/// open
				/// </java-name>
				[Dot42.DexImport("open", "(Landroid/net/sip/SipProfile;Landroid/app/PendingIntent;Landroid/net/sip/SipRegis" +
    "trationListener;)V", AccessFlags = 1)]
				public virtual void Open(global::Android.Net.Sip.SipProfile localProfile, global::Android.App.PendingIntent incomingCallPendingIntent, global::Android.Net.Sip.ISipRegistrationListener listener) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the listener to listen to registration events. No effect if the profile has not been opened to receive calls (see open(SipProfile, PendingIntent, SipRegistrationListener)).</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setRegistrationListener
				/// </java-name>
				[Dot42.DexImport("setRegistrationListener", "(Ljava/lang/String;Landroid/net/sip/SipRegistrationListener;)V", AccessFlags = 1)]
				public virtual void SetRegistrationListener(string localProfileUri, global::Android.Net.Sip.ISipRegistrationListener listener) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Closes the specified profile to not make/receive calls. All the resources that were allocated to the profile are also released.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void Close(string localProfileUri) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Checks if the specified profile is opened in the SIP service for making and/or receiving calls.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if the profile is enabled to receive calls </para>
				/// </returns>
				/// <java-name>
				/// isOpened
				/// </java-name>
				[Dot42.DexImport("isOpened", "(Ljava/lang/String;)Z", AccessFlags = 1)]
				public virtual bool IsOpened(string localProfileUri) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Checks if the SIP service has successfully registered the profile to the SIP provider (specified in the profile) for receiving calls. Returning true from this method also implies the profile is opened (isOpened).</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if the profile is registered to the SIP provider; false if the profile has not been opened in the SIP service or the SIP service has not yet successfully registered the profile to the SIP provider </para>
				/// </returns>
				/// <java-name>
				/// isRegistered
				/// </java-name>
				[Dot42.DexImport("isRegistered", "(Ljava/lang/String;)Z", AccessFlags = 1)]
				public virtual bool IsRegistered(string localProfileUri) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// makeAudioCall
				/// </java-name>
				[Dot42.DexImport("makeAudioCall", "(Landroid/net/sip/SipProfile;Landroid/net/sip/SipProfile;Landroid/net/sip/SipAudi" +
    "oCall$Listener;I)Landroid/net/sip/SipAudioCall;", AccessFlags = 1)]
				public virtual global::Android.Net.Sip.SipAudioCall MakeAudioCall(global::Android.Net.Sip.SipProfile sipProfile, global::Android.Net.Sip.SipProfile sipProfile1, global::Android.Net.Sip.SipAudioCall.Listener listener, int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Net.Sip.SipAudioCall);
				}

				/// <java-name>
				/// makeAudioCall
				/// </java-name>
				[Dot42.DexImport("makeAudioCall", "(Ljava/lang/String;Ljava/lang/String;Landroid/net/sip/SipAudioCall$Listener;I)Lan" +
    "droid/net/sip/SipAudioCall;", AccessFlags = 1)]
				public virtual global::Android.Net.Sip.SipAudioCall MakeAudioCall(string @string, string string1, global::Android.Net.Sip.SipAudioCall.Listener listener, int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Net.Sip.SipAudioCall);
				}

				/// <summary>
				///  <para>Creates a SipAudioCall to take an incoming call. Before the call is returned, the listener will receive a SipAudioCall.Listener#onRinging callback.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a SipAudioCall object </para>
				/// </returns>
				/// <java-name>
				/// takeAudioCall
				/// </java-name>
				[Dot42.DexImport("takeAudioCall", "(Landroid/content/Intent;Landroid/net/sip/SipAudioCall$Listener;)Landroid/net/sip" +
    "/SipAudioCall;", AccessFlags = 1)]
				public virtual global::Android.Net.Sip.SipAudioCall TakeAudioCall(global::Android.Content.Intent incomingCallIntent, global::Android.Net.Sip.SipAudioCall.Listener listener) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Net.Sip.SipAudioCall);
				}

				/// <summary>
				///  <para>Checks if the intent is an incoming call broadcast intent.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if the intent is an incoming call broadcast intent </para>
				/// </returns>
				/// <java-name>
				/// isIncomingCallIntent
				/// </java-name>
				[Dot42.DexImport("isIncomingCallIntent", "(Landroid/content/Intent;)Z", AccessFlags = 9)]
				public static bool IsIncomingCallIntent(global::Android.Content.Intent intent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Gets the call ID from the specified incoming call broadcast intent.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the call ID or null if the intent does not contain it </para>
				/// </returns>
				/// <java-name>
				/// getCallId
				/// </java-name>
				[Dot42.DexImport("getCallId", "(Landroid/content/Intent;)Ljava/lang/String;", AccessFlags = 9)]
				public static string GetCallId(global::Android.Content.Intent incomingCallIntent) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Gets the offer session description from the specified incoming call broadcast intent.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the offer session description or null if the intent does not have it </para>
				/// </returns>
				/// <java-name>
				/// getOfferSessionDescription
				/// </java-name>
				[Dot42.DexImport("getOfferSessionDescription", "(Landroid/content/Intent;)Ljava/lang/String;", AccessFlags = 9)]
				public static string GetOfferSessionDescription(global::Android.Content.Intent incomingCallIntent) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Manually registers the profile to the corresponding SIP provider for receiving calls. open(SipProfile, PendingIntent, SipRegistrationListener) is still needed to be called at least once in order for the SIP service to notify the caller with the android.app.PendingIntent when an incoming call is received.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// register
				/// </java-name>
				[Dot42.DexImport("register", "(Landroid/net/sip/SipProfile;ILandroid/net/sip/SipRegistrationListener;)V", AccessFlags = 1)]
				public virtual void Register(global::Android.Net.Sip.SipProfile localProfile, int expiryTime, global::Android.Net.Sip.ISipRegistrationListener listener) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Manually unregisters the profile from the corresponding SIP provider for stop receiving further calls. This may interference with the auto registration process in the SIP service if the auto-registration option in the profile is enabled.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// unregister
				/// </java-name>
				[Dot42.DexImport("unregister", "(Landroid/net/sip/SipProfile;Landroid/net/sip/SipRegistrationListener;)V", AccessFlags = 1)]
				public virtual void Unregister(global::Android.Net.Sip.SipProfile localProfile, global::Android.Net.Sip.ISipRegistrationListener listener) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Gets the SipSession that handles the incoming call. For audio calls, consider to use SipAudioCall to handle the incoming call. See takeAudioCall. Note that the method may be called only once for the same intent. For subsequent calls on the same intent, the method returns null.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the session object that handles the incoming call </para>
				/// </returns>
				/// <java-name>
				/// getSessionFor
				/// </java-name>
				[Dot42.DexImport("getSessionFor", "(Landroid/content/Intent;)Landroid/net/sip/SipSession;", AccessFlags = 1)]
				public virtual global::Android.Net.Sip.SipSession GetSessionFor(global::Android.Content.Intent incomingCallIntent) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Net.Sip.SipSession);
				}

				/// <summary>
				///  <para>Creates a SipSession with the specified profile. Use other methods, if applicable, instead of interacting with SipSession directly.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// createSipSession
				/// </java-name>
				[Dot42.DexImport("createSipSession", "(Landroid/net/sip/SipProfile;Landroid/net/sip/SipSession$Listener;)Landroid/net/s" +
    "ip/SipSession;", AccessFlags = 1)]
				public virtual global::Android.Net.Sip.SipSession CreateSipSession(global::Android.Net.Sip.SipProfile localProfile, global::Android.Net.Sip.SipSession.Listener listener) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Net.Sip.SipSession);
				}

		}

		/// <summary>
		///  <para>Defines a SIP profile, including a SIP account, domain and server information. </para> <para>You can create a SipProfile using SipProfile.Builder. You can also retrieve one from a SipSession, using SipSession#getLocalProfile and SipSession#getPeerProfile.</para> <para>  <h3>Developer Guides</h3></para> <para> </para> <para>For more information about using SIP, read the  developer guide.</para> <para>  </para>    
		/// </summary>
		/// <java-name>
		/// android/net/sip/SipProfile
		/// </java-name>
		[Dot42.DexImport("android/net/sip/SipProfile", AccessFlags = 33)]
		public partial class SipProfile : global::Android.OS.IParcelable, global::Java.IO.ISerializable, global::Java.Lang.ICloneable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.Net.Sip.SipProfile> CREATOR;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal SipProfile() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Flatten this object in to a Parcel.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public virtual void WriteToParcel(global::Android.OS.Parcel dest, int flags) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Describe the kinds of special objects contained in this Parcelable's marshalled representation.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a bitmask indicating the set of special object types marshalled by the Parcelable. </para>
				/// </returns>
				/// <java-name>
				/// describeContents
				/// </java-name>
				[Dot42.DexImport("describeContents", "()I", AccessFlags = 1)]
				public virtual int DescribeContents() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Gets the SIP URI string of this profile.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the SIP URI string of this profile </para>
				/// </returns>
				/// <java-name>
				/// getUriString
				/// </java-name>
				public virtual string UriString
				{
						[Dot42.DexImport("getUriString", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>Gets the display name of the user.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the display name of the user </para>
				/// </returns>
				/// <java-name>
				/// getDisplayName
				/// </java-name>
				public virtual string DisplayName
				{
						[Dot42.DexImport("getDisplayName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>Gets the username.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the username </para>
				/// </returns>
				/// <java-name>
				/// getUserName
				/// </java-name>
				public virtual string UserName
				{
						[Dot42.DexImport("getUserName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>Gets the username for authentication. If it is null, then the username is used in authentication instead.</para> <para> <para>getUserName </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the authentication username </para>
				/// </returns>
				/// <java-name>
				/// getAuthUserName
				/// </java-name>
				public virtual string AuthUserName
				{
						[Dot42.DexImport("getAuthUserName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>Gets the password.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the password </para>
				/// </returns>
				/// <java-name>
				/// getPassword
				/// </java-name>
				public virtual string Password
				{
						[Dot42.DexImport("getPassword", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>Gets the SIP domain.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the SIP domain </para>
				/// </returns>
				/// <java-name>
				/// getSipDomain
				/// </java-name>
				public virtual string SipDomain
				{
						[Dot42.DexImport("getSipDomain", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>Gets the port number of the SIP server.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the port number of the SIP server </para>
				/// </returns>
				/// <java-name>
				/// getPort
				/// </java-name>
				public virtual int Port
				{
						[Dot42.DexImport("getPort", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Gets the protocol used to connect to the server.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the protocol </para>
				/// </returns>
				/// <java-name>
				/// getProtocol
				/// </java-name>
				public virtual string Protocol
				{
						[Dot42.DexImport("getProtocol", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>Gets the network address of the server outbound proxy.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the network address of the server outbound proxy </para>
				/// </returns>
				/// <java-name>
				/// getProxyAddress
				/// </java-name>
				public virtual string ProxyAddress
				{
						[Dot42.DexImport("getProxyAddress", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>Gets the (user-defined) name of the profile.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>name of the profile </para>
				/// </returns>
				/// <java-name>
				/// getProfileName
				/// </java-name>
				public virtual string ProfileName
				{
						[Dot42.DexImport("getProfileName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>Gets the flag of 'Sending keep-alive'.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the flag of sending SIP keep-alive messages. </para>
				/// </returns>
				/// <java-name>
				/// getSendKeepAlive
				/// </java-name>
				public virtual bool SendKeepAlive
				{
						[Dot42.DexImport("getSendKeepAlive", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Gets the flag of 'Auto Registration'.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the flag of registering the profile automatically. </para>
				/// </returns>
				/// <java-name>
				/// getAutoRegistration
				/// </java-name>
				public virtual bool AutoRegistration
				{
						[Dot42.DexImport("getAutoRegistration", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Helper class for creating a SipProfile. </para>    
				/// </summary>
				/// <java-name>
				/// android/net/sip/SipProfile$Builder
				/// </java-name>
				[Dot42.DexImport("android/net/sip/SipProfile$Builder", AccessFlags = 9)]
				public partial class Builder
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "(Landroid/net/sip/SipProfile;)V", AccessFlags = 1)]
						public Builder(global::Android.Net.Sip.SipProfile sipProfile) /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
						public Builder(string @string) /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
						public Builder(string @string, string string1) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Sets the username used for authentication.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>this builder object </para>
						/// </returns>
						/// <java-name>
						/// setAuthUserName
						/// </java-name>
						[Dot42.DexImport("setAuthUserName", "(Ljava/lang/String;)Landroid/net/sip/SipProfile$Builder;", AccessFlags = 1)]
						public virtual Builder SetAuthUserName(string name) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <summary>
						///  <para>Sets the name of the profile. This name is given by user.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>this builder object </para>
						/// </returns>
						/// <java-name>
						/// setProfileName
						/// </java-name>
						[Dot42.DexImport("setProfileName", "(Ljava/lang/String;)Landroid/net/sip/SipProfile$Builder;", AccessFlags = 1)]
						public virtual Builder SetProfileName(string name) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <summary>
						///  <para>Sets the password of the SIP account</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>this builder object </para>
						/// </returns>
						/// <java-name>
						/// setPassword
						/// </java-name>
						[Dot42.DexImport("setPassword", "(Ljava/lang/String;)Landroid/net/sip/SipProfile$Builder;", AccessFlags = 1)]
						public virtual Builder SetPassword(string password) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <summary>
						///  <para>Sets the port number of the server. By default, it is 5060.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>this builder object </para>
						/// </returns>
						/// <java-name>
						/// setPort
						/// </java-name>
						[Dot42.DexImport("setPort", "(I)Landroid/net/sip/SipProfile$Builder;", AccessFlags = 1)]
						public virtual Builder SetPort(int port) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <summary>
						///  <para>Sets the protocol used to connect to the SIP server. Currently, only "UDP" and "TCP" are supported.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>this builder object </para>
						/// </returns>
						/// <java-name>
						/// setProtocol
						/// </java-name>
						[Dot42.DexImport("setProtocol", "(Ljava/lang/String;)Landroid/net/sip/SipProfile$Builder;", AccessFlags = 1)]
						public virtual Builder SetProtocol(string protocol) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <summary>
						///  <para>Sets the outbound proxy of the SIP server.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>this builder object </para>
						/// </returns>
						/// <java-name>
						/// setOutboundProxy
						/// </java-name>
						[Dot42.DexImport("setOutboundProxy", "(Ljava/lang/String;)Landroid/net/sip/SipProfile$Builder;", AccessFlags = 1)]
						public virtual Builder SetOutboundProxy(string outboundProxy) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <summary>
						///  <para>Sets the display name of the user.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>this builder object </para>
						/// </returns>
						/// <java-name>
						/// setDisplayName
						/// </java-name>
						[Dot42.DexImport("setDisplayName", "(Ljava/lang/String;)Landroid/net/sip/SipProfile$Builder;", AccessFlags = 1)]
						public virtual Builder SetDisplayName(string displayName) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <summary>
						///  <para>Sets the send keep-alive flag.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>this builder object </para>
						/// </returns>
						/// <java-name>
						/// setSendKeepAlive
						/// </java-name>
						[Dot42.DexImport("setSendKeepAlive", "(Z)Landroid/net/sip/SipProfile$Builder;", AccessFlags = 1)]
						public virtual Builder SetSendKeepAlive(bool flag) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <summary>
						///  <para>Sets the auto. registration flag.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>this builder object </para>
						/// </returns>
						/// <java-name>
						/// setAutoRegistration
						/// </java-name>
						[Dot42.DexImport("setAutoRegistration", "(Z)Landroid/net/sip/SipProfile$Builder;", AccessFlags = 1)]
						public virtual Builder SetAutoRegistration(bool flag) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <summary>
						///  <para>Builds and returns the SIP profile object.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>the profile object created </para>
						/// </returns>
						/// <java-name>
						/// build
						/// </java-name>
						[Dot42.DexImport("build", "()Landroid/net/sip/SipProfile;", AccessFlags = 1)]
						public virtual global::Android.Net.Sip.SipProfile Build() /* MethodBuilder.Create */ 
						{
								return default(global::Android.Net.Sip.SipProfile);
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						protected internal Builder() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

				}

		}

		/// <summary>
		///  <para>Represents a SIP session that is associated with a SIP dialog or a standalone transaction not within a dialog. </para> <para>You can get a SipSession from SipManager with createSipSession() (when initiating calls) or getSessionFor() (when receiving calls).</para>    
		/// </summary>
		/// <java-name>
		/// android/net/sip/SipSession
		/// </java-name>
		[Dot42.DexImport("android/net/sip/SipSession", AccessFlags = 49)]
		public sealed partial class SipSession
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal SipSession() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Gets the session state. The value returned must be one of the states in State.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the session state </para>
				/// </returns>
				/// <java-name>
				/// getState
				/// </java-name>
				[Dot42.DexImport("getState", "()I", AccessFlags = 1)]
				public int GetState() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Sets the listener to listen to the session events. A <c>SipSession </c> can only hold one listener at a time. Subsequent calls to this method override the previous listener.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setListener
				/// </java-name>
				[Dot42.DexImport("setListener", "(Landroid/net/sip/SipSession$Listener;)V", AccessFlags = 1)]
				public void SetListener(global::Android.Net.Sip.SipSession.Listener listener) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Performs registration to the server specified by the associated local profile. The session listener is called back upon success or failure of registration. The method is only valid to call when the session state is in State#READY_TO_CALL.</para> <para> <para>Listener </para></para>        
				/// </summary>
				/// <java-name>
				/// register
				/// </java-name>
				[Dot42.DexImport("register", "(I)V", AccessFlags = 1)]
				public void Register(int duration) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Performs unregistration to the server specified by the associated local profile. Unregistration is technically the same as registration with zero expiration duration. The session listener is called back upon success or failure of unregistration. The method is only valid to call when the session state is in State#READY_TO_CALL.</para> <para> <para>Listener </para></para>        
				/// </summary>
				/// <java-name>
				/// unregister
				/// </java-name>
				[Dot42.DexImport("unregister", "()V", AccessFlags = 1)]
				public void Unregister() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Initiates a call to the specified profile. The session listener is called back upon defined session events. The method is only valid to call when the session state is in State#READY_TO_CALL.</para> <para> <para>Listener </para></para>        
				/// </summary>
				/// <java-name>
				/// makeCall
				/// </java-name>
				[Dot42.DexImport("makeCall", "(Landroid/net/sip/SipProfile;Ljava/lang/String;I)V", AccessFlags = 1)]
				public void MakeCall(global::Android.Net.Sip.SipProfile callee, string sessionDescription, int timeout) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Answers an incoming call with the specified session description. The method is only valid to call when the session state is in State#INCOMING_CALL.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// answerCall
				/// </java-name>
				[Dot42.DexImport("answerCall", "(Ljava/lang/String;I)V", AccessFlags = 1)]
				public void AnswerCall(string sessionDescription, int timeout) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Ends an established call, terminates an outgoing call or rejects an incoming call. The method is only valid to call when the session state is in State#IN_CALL, State#INCOMING_CALL, State#OUTGOING_CALL or State#OUTGOING_CALL_RING_BACK. </para>        
				/// </summary>
				/// <java-name>
				/// endCall
				/// </java-name>
				[Dot42.DexImport("endCall", "()V", AccessFlags = 1)]
				public void EndCall() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Changes the session description during a call. The method is only valid to call when the session state is in State#IN_CALL.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// changeCall
				/// </java-name>
				[Dot42.DexImport("changeCall", "(Ljava/lang/String;I)V", AccessFlags = 1)]
				public void ChangeCall(string sessionDescription, int timeout) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Gets the IP address of the local host on which this SIP session runs.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the IP address of the local host </para>
				/// </returns>
				/// <java-name>
				/// getLocalIp
				/// </java-name>
				public string LocalIp
				{
						[Dot42.DexImport("getLocalIp", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>Gets the SIP profile that this session is associated with.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the SIP profile that this session is associated with </para>
				/// </returns>
				/// <java-name>
				/// getLocalProfile
				/// </java-name>
				public global::Android.Net.Sip.SipProfile LocalProfile
				{
						[Dot42.DexImport("getLocalProfile", "()Landroid/net/sip/SipProfile;", AccessFlags = 1)]
						get{ return default(global::Android.Net.Sip.SipProfile); }
				}

				/// <summary>
				///  <para>Gets the SIP profile that this session is connected to. Only available when the session is associated with a SIP dialog.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the SIP profile that this session is connected to </para>
				/// </returns>
				/// <java-name>
				/// getPeerProfile
				/// </java-name>
				public global::Android.Net.Sip.SipProfile PeerProfile
				{
						[Dot42.DexImport("getPeerProfile", "()Landroid/net/sip/SipProfile;", AccessFlags = 1)]
						get{ return default(global::Android.Net.Sip.SipProfile); }
				}

				/// <summary>
				///  <para>Checks if the session is in a call.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if the session is in a call </para>
				/// </returns>
				/// <java-name>
				/// isInCall
				/// </java-name>
				public bool IsInCall
				{
						[Dot42.DexImport("isInCall", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Gets the call ID of the session.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the call ID </para>
				/// </returns>
				/// <java-name>
				/// getCallId
				/// </java-name>
				public string CallId
				{
						[Dot42.DexImport("getCallId", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>Listener for events relating to a SIP session, such as when a session is being registered ("on registering") or a call is outgoing ("on calling"). </para> <para>Many of these events are also received by SipAudioCall.Listener.</para>    
				/// </summary>
				/// <java-name>
				/// android/net/sip/SipSession$Listener
				/// </java-name>
				[Dot42.DexImport("android/net/sip/SipSession$Listener", AccessFlags = 9)]
				public partial class Listener
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public Listener() /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Called when an INVITE request is sent to initiate a new call.</para> <para></para>        
						/// </summary>
						/// <java-name>
						/// onCalling
						/// </java-name>
						[Dot42.DexImport("onCalling", "(Landroid/net/sip/SipSession;)V", AccessFlags = 1)]
						public virtual void OnCalling(global::Android.Net.Sip.SipSession session) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Called when an INVITE request is received.</para> <para></para>        
						/// </summary>
						/// <java-name>
						/// onRinging
						/// </java-name>
						[Dot42.DexImport("onRinging", "(Landroid/net/sip/SipSession;Landroid/net/sip/SipProfile;Ljava/lang/String;)V", AccessFlags = 1)]
						public virtual void OnRinging(global::Android.Net.Sip.SipSession session, global::Android.Net.Sip.SipProfile caller, string sessionDescription) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Called when a RINGING response is received for the INVITE request sent</para> <para></para>        
						/// </summary>
						/// <java-name>
						/// onRingingBack
						/// </java-name>
						[Dot42.DexImport("onRingingBack", "(Landroid/net/sip/SipSession;)V", AccessFlags = 1)]
						public virtual void OnRingingBack(global::Android.Net.Sip.SipSession session) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Called when the session is established.</para> <para></para>        
						/// </summary>
						/// <java-name>
						/// onCallEstablished
						/// </java-name>
						[Dot42.DexImport("onCallEstablished", "(Landroid/net/sip/SipSession;Ljava/lang/String;)V", AccessFlags = 1)]
						public virtual void OnCallEstablished(global::Android.Net.Sip.SipSession session, string sessionDescription) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Called when the session is terminated.</para> <para></para>        
						/// </summary>
						/// <java-name>
						/// onCallEnded
						/// </java-name>
						[Dot42.DexImport("onCallEnded", "(Landroid/net/sip/SipSession;)V", AccessFlags = 1)]
						public virtual void OnCallEnded(global::Android.Net.Sip.SipSession session) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Called when the peer is busy during session initialization.</para> <para></para>        
						/// </summary>
						/// <java-name>
						/// onCallBusy
						/// </java-name>
						[Dot42.DexImport("onCallBusy", "(Landroid/net/sip/SipSession;)V", AccessFlags = 1)]
						public virtual void OnCallBusy(global::Android.Net.Sip.SipSession session) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Called when an error occurs during session initialization and termination.</para> <para></para>        
						/// </summary>
						/// <java-name>
						/// onError
						/// </java-name>
						[Dot42.DexImport("onError", "(Landroid/net/sip/SipSession;ILjava/lang/String;)V", AccessFlags = 1)]
						public virtual void OnError(global::Android.Net.Sip.SipSession session, int errorCode, string errorMessage) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Called when an error occurs during session modification negotiation.</para> <para></para>        
						/// </summary>
						/// <java-name>
						/// onCallChangeFailed
						/// </java-name>
						[Dot42.DexImport("onCallChangeFailed", "(Landroid/net/sip/SipSession;ILjava/lang/String;)V", AccessFlags = 1)]
						public virtual void OnCallChangeFailed(global::Android.Net.Sip.SipSession session, int errorCode, string errorMessage) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Called when a registration request is sent.</para> <para></para>        
						/// </summary>
						/// <java-name>
						/// onRegistering
						/// </java-name>
						[Dot42.DexImport("onRegistering", "(Landroid/net/sip/SipSession;)V", AccessFlags = 1)]
						public virtual void OnRegistering(global::Android.Net.Sip.SipSession session) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Called when registration is successfully done.</para> <para></para>        
						/// </summary>
						/// <java-name>
						/// onRegistrationDone
						/// </java-name>
						[Dot42.DexImport("onRegistrationDone", "(Landroid/net/sip/SipSession;I)V", AccessFlags = 1)]
						public virtual void OnRegistrationDone(global::Android.Net.Sip.SipSession session, int duration) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Called when the registration fails.</para> <para></para>        
						/// </summary>
						/// <java-name>
						/// onRegistrationFailed
						/// </java-name>
						[Dot42.DexImport("onRegistrationFailed", "(Landroid/net/sip/SipSession;ILjava/lang/String;)V", AccessFlags = 1)]
						public virtual void OnRegistrationFailed(global::Android.Net.Sip.SipSession session, int errorCode, string errorMessage) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Called when the registration gets timed out.</para> <para></para>        
						/// </summary>
						/// <java-name>
						/// onRegistrationTimeout
						/// </java-name>
						[Dot42.DexImport("onRegistrationTimeout", "(Landroid/net/sip/SipSession;)V", AccessFlags = 1)]
						public virtual void OnRegistrationTimeout(global::Android.Net.Sip.SipSession session) /* MethodBuilder.Create */ 
						{
						}

				}

				/// <summary>
				///  <para>Defines SIP session states, such as "registering", "outgoing call", and "in call". </para>    
				/// </summary>
				/// <java-name>
				/// android/net/sip/SipSession$State
				/// </java-name>
				[Dot42.DexImport("android/net/sip/SipSession$State", AccessFlags = 9)]
				public partial class State
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>When session is ready to initiate a call or transaction. </para>        
						/// </summary>
						/// <java-name>
						/// READY_TO_CALL
						/// </java-name>
						[Dot42.DexImport("READY_TO_CALL", "I", AccessFlags = 25)]
						public const int READY_TO_CALL = 0;
						/// <summary>
						///  <para>When the registration request is sent out. </para>        
						/// </summary>
						/// <java-name>
						/// REGISTERING
						/// </java-name>
						[Dot42.DexImport("REGISTERING", "I", AccessFlags = 25)]
						public const int REGISTERING = 1;
						/// <summary>
						///  <para>When the unregistration request is sent out. </para>        
						/// </summary>
						/// <java-name>
						/// DEREGISTERING
						/// </java-name>
						[Dot42.DexImport("DEREGISTERING", "I", AccessFlags = 25)]
						public const int DEREGISTERING = 2;
						/// <summary>
						///  <para>When an INVITE request is received. </para>        
						/// </summary>
						/// <java-name>
						/// INCOMING_CALL
						/// </java-name>
						[Dot42.DexImport("INCOMING_CALL", "I", AccessFlags = 25)]
						public const int INCOMING_CALL = 3;
						/// <summary>
						///  <para>When an OK response is sent for the INVITE request received. </para>        
						/// </summary>
						/// <java-name>
						/// INCOMING_CALL_ANSWERING
						/// </java-name>
						[Dot42.DexImport("INCOMING_CALL_ANSWERING", "I", AccessFlags = 25)]
						public const int INCOMING_CALL_ANSWERING = 4;
						/// <summary>
						///  <para>When an INVITE request is sent. </para>        
						/// </summary>
						/// <java-name>
						/// OUTGOING_CALL
						/// </java-name>
						[Dot42.DexImport("OUTGOING_CALL", "I", AccessFlags = 25)]
						public const int OUTGOING_CALL = 5;
						/// <summary>
						///  <para>When a RINGING response is received for the INVITE request sent. </para>        
						/// </summary>
						/// <java-name>
						/// OUTGOING_CALL_RING_BACK
						/// </java-name>
						[Dot42.DexImport("OUTGOING_CALL_RING_BACK", "I", AccessFlags = 25)]
						public const int OUTGOING_CALL_RING_BACK = 6;
						/// <summary>
						///  <para>When a CANCEL request is sent for the INVITE request sent. </para>        
						/// </summary>
						/// <java-name>
						/// OUTGOING_CALL_CANCELING
						/// </java-name>
						[Dot42.DexImport("OUTGOING_CALL_CANCELING", "I", AccessFlags = 25)]
						public const int OUTGOING_CALL_CANCELING = 7;
						/// <summary>
						///  <para>When a call is established. </para>        
						/// </summary>
						/// <java-name>
						/// IN_CALL
						/// </java-name>
						[Dot42.DexImport("IN_CALL", "I", AccessFlags = 25)]
						public const int IN_CALL = 8;
						/// <summary>
						///  <para>When an OPTIONS request is sent. </para>        
						/// </summary>
						/// <java-name>
						/// PINGING
						/// </java-name>
						[Dot42.DexImport("PINGING", "I", AccessFlags = 25)]
						public const int PINGING = 9;
						/// <summary>
						///  <para>Not defined. </para>        
						/// </summary>
						/// <java-name>
						/// NOT_DEFINED
						/// </java-name>
						[Dot42.DexImport("NOT_DEFINED", "I", AccessFlags = 25)]
						public const int NOT_DEFINED = 101;
						[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
						internal State() /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Converts the state to string. </para>        
						/// </summary>
						/// <java-name>
						/// toString
						/// </java-name>
						[Dot42.DexImport("toString", "(I)Ljava/lang/String;", AccessFlags = 9)]
						public static string ToString(int state) /* MethodBuilder.Create */ 
						{
								return default(string);
						}

				}

		}

}

