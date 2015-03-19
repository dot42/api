#pragma warning disable 1717
namespace Android.Net.Sip
{
		/// <java-name>
		/// android/net/sip/SipManager
		/// </java-name>
		[Dot42.DexImport("android/net/sip/SipManager", AccessFlags = 33)]
		public partial class SipManager
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// INCOMING_CALL_RESULT_CODE
				/// </java-name>
				[Dot42.DexImport("INCOMING_CALL_RESULT_CODE", "I", AccessFlags = 25)]
				public const int INCOMING_CALL_RESULT_CODE = 101;
				/// <java-name>
				/// EXTRA_CALL_ID
				/// </java-name>
				[Dot42.DexImport("EXTRA_CALL_ID", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_CALL_ID = "android:sipCallID";
				/// <java-name>
				/// EXTRA_OFFER_SD
				/// </java-name>
				[Dot42.DexImport("EXTRA_OFFER_SD", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_OFFER_SD = "android:sipOfferSD";
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal SipManager() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// newInstance
				/// </java-name>
				[Dot42.DexImport("newInstance", "(Landroid/content/Context;)Landroid/net/sip/SipManager;", AccessFlags = 9)]
				public static global::Android.Net.Sip.SipManager NewInstance(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Net.Sip.SipManager);
				}

				/// <java-name>
				/// isApiSupported
				/// </java-name>
				[Dot42.DexImport("isApiSupported", "(Landroid/content/Context;)Z", AccessFlags = 9)]
				public static bool IsApiSupported(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isVoipSupported
				/// </java-name>
				[Dot42.DexImport("isVoipSupported", "(Landroid/content/Context;)Z", AccessFlags = 9)]
				public static bool IsVoipSupported(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isSipWifiOnly
				/// </java-name>
				[Dot42.DexImport("isSipWifiOnly", "(Landroid/content/Context;)Z", AccessFlags = 9)]
				public static bool IsSipWifiOnly(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// open
				/// </java-name>
				[Dot42.DexImport("open", "(Landroid/net/sip/SipProfile;)V", AccessFlags = 1)]
				public virtual void Open(global::Android.Net.Sip.SipProfile sipProfile) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// open
				/// </java-name>
				[Dot42.DexImport("open", "(Landroid/net/sip/SipProfile;Landroid/app/PendingIntent;Landroid/net/sip/SipRegis" +
    "trationListener;)V", AccessFlags = 1)]
				public virtual void Open(global::Android.Net.Sip.SipProfile sipProfile, global::Android.App.PendingIntent pendingIntent, global::Android.Net.Sip.ISipRegistrationListener sipRegistrationListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setRegistrationListener
				/// </java-name>
				[Dot42.DexImport("setRegistrationListener", "(Ljava/lang/String;Landroid/net/sip/SipRegistrationListener;)V", AccessFlags = 1)]
				public virtual void SetRegistrationListener(string @string, global::Android.Net.Sip.ISipRegistrationListener sipRegistrationListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void Close(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isOpened
				/// </java-name>
				[Dot42.DexImport("isOpened", "(Ljava/lang/String;)Z", AccessFlags = 1)]
				public virtual bool IsOpened(string @string) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isRegistered
				/// </java-name>
				[Dot42.DexImport("isRegistered", "(Ljava/lang/String;)Z", AccessFlags = 1)]
				public virtual bool IsRegistered(string @string) /* MethodBuilder.Create */ 
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

				/// <java-name>
				/// takeAudioCall
				/// </java-name>
				[Dot42.DexImport("takeAudioCall", "(Landroid/content/Intent;Landroid/net/sip/SipAudioCall$Listener;)Landroid/net/sip" +
    "/SipAudioCall;", AccessFlags = 1)]
				public virtual global::Android.Net.Sip.SipAudioCall TakeAudioCall(global::Android.Content.Intent intent, global::Android.Net.Sip.SipAudioCall.Listener listener) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Net.Sip.SipAudioCall);
				}

				/// <java-name>
				/// isIncomingCallIntent
				/// </java-name>
				[Dot42.DexImport("isIncomingCallIntent", "(Landroid/content/Intent;)Z", AccessFlags = 9)]
				public static bool IsIncomingCallIntent(global::Android.Content.Intent intent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getCallId
				/// </java-name>
				[Dot42.DexImport("getCallId", "(Landroid/content/Intent;)Ljava/lang/String;", AccessFlags = 9)]
				public static string GetCallId(global::Android.Content.Intent intent) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getOfferSessionDescription
				/// </java-name>
				[Dot42.DexImport("getOfferSessionDescription", "(Landroid/content/Intent;)Ljava/lang/String;", AccessFlags = 9)]
				public static string GetOfferSessionDescription(global::Android.Content.Intent intent) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// register
				/// </java-name>
				[Dot42.DexImport("register", "(Landroid/net/sip/SipProfile;ILandroid/net/sip/SipRegistrationListener;)V", AccessFlags = 1)]
				public virtual void Register(global::Android.Net.Sip.SipProfile sipProfile, int int32, global::Android.Net.Sip.ISipRegistrationListener sipRegistrationListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// unregister
				/// </java-name>
				[Dot42.DexImport("unregister", "(Landroid/net/sip/SipProfile;Landroid/net/sip/SipRegistrationListener;)V", AccessFlags = 1)]
				public virtual void Unregister(global::Android.Net.Sip.SipProfile sipProfile, global::Android.Net.Sip.ISipRegistrationListener sipRegistrationListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getSessionFor
				/// </java-name>
				[Dot42.DexImport("getSessionFor", "(Landroid/content/Intent;)Landroid/net/sip/SipSession;", AccessFlags = 1)]
				public virtual global::Android.Net.Sip.SipSession GetSessionFor(global::Android.Content.Intent intent) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Net.Sip.SipSession);
				}

				/// <java-name>
				/// createSipSession
				/// </java-name>
				[Dot42.DexImport("createSipSession", "(Landroid/net/sip/SipProfile;Landroid/net/sip/SipSession$Listener;)Landroid/net/s" +
    "ip/SipSession;", AccessFlags = 1)]
				public virtual global::Android.Net.Sip.SipSession CreateSipSession(global::Android.Net.Sip.SipProfile sipProfile, global::Android.Net.Sip.SipSession.Listener listener) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Net.Sip.SipSession);
				}

		}

		/// <java-name>
		/// android/net/sip/SipProfile
		/// </java-name>
		[Dot42.DexImport("android/net/sip/SipProfile", AccessFlags = 33)]
		public partial class SipProfile : global::Android.Os.IParcelable, global::Java.Io.ISerializable, global::Java.Lang.ICloneable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.Os.IParcelable_ICreator<global::Android.Net.Sip.SipProfile> CREATOR;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal SipProfile() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public virtual void WriteToParcel(global::Android.Os.Parcel parcel, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// describeContents
				/// </java-name>
				[Dot42.DexImport("describeContents", "()I", AccessFlags = 1)]
				public virtual int DescribeContents() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getUriString
				/// </java-name>
				[Dot42.DexImport("getUriString", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetUriString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getDisplayName
				/// </java-name>
				[Dot42.DexImport("getDisplayName", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetDisplayName() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getUserName
				/// </java-name>
				[Dot42.DexImport("getUserName", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetUserName() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getAuthUserName
				/// </java-name>
				[Dot42.DexImport("getAuthUserName", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetAuthUserName() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getPassword
				/// </java-name>
				[Dot42.DexImport("getPassword", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetPassword() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getSipDomain
				/// </java-name>
				[Dot42.DexImport("getSipDomain", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetSipDomain() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getPort
				/// </java-name>
				[Dot42.DexImport("getPort", "()I", AccessFlags = 1)]
				public virtual int GetPort() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getProtocol
				/// </java-name>
				[Dot42.DexImport("getProtocol", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetProtocol() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getProxyAddress
				/// </java-name>
				[Dot42.DexImport("getProxyAddress", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetProxyAddress() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getProfileName
				/// </java-name>
				[Dot42.DexImport("getProfileName", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetProfileName() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getSendKeepAlive
				/// </java-name>
				[Dot42.DexImport("getSendKeepAlive", "()Z", AccessFlags = 1)]
				public virtual bool GetSendKeepAlive() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getAutoRegistration
				/// </java-name>
				[Dot42.DexImport("getAutoRegistration", "()Z", AccessFlags = 1)]
				public virtual bool GetAutoRegistration() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getUriString
				/// </java-name>
				public string UriString
				{
				[Dot42.DexImport("getUriString", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetUriString(); }
				}

				/// <java-name>
				/// getDisplayName
				/// </java-name>
				public string DisplayName
				{
				[Dot42.DexImport("getDisplayName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetDisplayName(); }
				}

				/// <java-name>
				/// getUserName
				/// </java-name>
				public string UserName
				{
				[Dot42.DexImport("getUserName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetUserName(); }
				}

				/// <java-name>
				/// getAuthUserName
				/// </java-name>
				public string AuthUserName
				{
				[Dot42.DexImport("getAuthUserName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetAuthUserName(); }
				}

				/// <java-name>
				/// getPassword
				/// </java-name>
				public string Password
				{
				[Dot42.DexImport("getPassword", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetPassword(); }
				}

				/// <java-name>
				/// getSipDomain
				/// </java-name>
				public string SipDomain
				{
				[Dot42.DexImport("getSipDomain", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetSipDomain(); }
				}

				/// <java-name>
				/// getPort
				/// </java-name>
				public int Port
				{
				[Dot42.DexImport("getPort", "()I", AccessFlags = 1)]
						get{ return GetPort(); }
				}

				/// <java-name>
				/// getProtocol
				/// </java-name>
				public string Protocol
				{
				[Dot42.DexImport("getProtocol", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetProtocol(); }
				}

				/// <java-name>
				/// getProxyAddress
				/// </java-name>
				public string ProxyAddress
				{
				[Dot42.DexImport("getProxyAddress", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetProxyAddress(); }
				}

				/// <java-name>
				/// getProfileName
				/// </java-name>
				public string ProfileName
				{
				[Dot42.DexImport("getProfileName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetProfileName(); }
				}

				/// <java-name>
				/// getSendKeepAlive
				/// </java-name>
				public bool IsSendKeepAlive
				{
				[Dot42.DexImport("getSendKeepAlive", "()Z", AccessFlags = 1)]
						get{ return GetSendKeepAlive(); }
				}

				/// <java-name>
				/// getAutoRegistration
				/// </java-name>
				public bool IsAutoRegistration
				{
				[Dot42.DexImport("getAutoRegistration", "()Z", AccessFlags = 1)]
						get{ return GetAutoRegistration(); }
				}

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

						/// <java-name>
						/// setAuthUserName
						/// </java-name>
						[Dot42.DexImport("setAuthUserName", "(Ljava/lang/String;)Landroid/net/sip/SipProfile$Builder;", AccessFlags = 1)]
						public virtual Builder SetAuthUserName(string @string) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// setProfileName
						/// </java-name>
						[Dot42.DexImport("setProfileName", "(Ljava/lang/String;)Landroid/net/sip/SipProfile$Builder;", AccessFlags = 1)]
						public virtual Builder SetProfileName(string @string) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// setPassword
						/// </java-name>
						[Dot42.DexImport("setPassword", "(Ljava/lang/String;)Landroid/net/sip/SipProfile$Builder;", AccessFlags = 1)]
						public virtual Builder SetPassword(string @string) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// setPort
						/// </java-name>
						[Dot42.DexImport("setPort", "(I)Landroid/net/sip/SipProfile$Builder;", AccessFlags = 1)]
						public virtual Builder SetPort(int int32) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// setProtocol
						/// </java-name>
						[Dot42.DexImport("setProtocol", "(Ljava/lang/String;)Landroid/net/sip/SipProfile$Builder;", AccessFlags = 1)]
						public virtual Builder SetProtocol(string @string) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// setOutboundProxy
						/// </java-name>
						[Dot42.DexImport("setOutboundProxy", "(Ljava/lang/String;)Landroid/net/sip/SipProfile$Builder;", AccessFlags = 1)]
						public virtual Builder SetOutboundProxy(string @string) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// setDisplayName
						/// </java-name>
						[Dot42.DexImport("setDisplayName", "(Ljava/lang/String;)Landroid/net/sip/SipProfile$Builder;", AccessFlags = 1)]
						public virtual Builder SetDisplayName(string @string) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// setSendKeepAlive
						/// </java-name>
						[Dot42.DexImport("setSendKeepAlive", "(Z)Landroid/net/sip/SipProfile$Builder;", AccessFlags = 1)]
						public virtual Builder SetSendKeepAlive(bool boolean) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// setAutoRegistration
						/// </java-name>
						[Dot42.DexImport("setAutoRegistration", "(Z)Landroid/net/sip/SipProfile$Builder;", AccessFlags = 1)]
						public virtual Builder SetAutoRegistration(bool boolean) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// build
						/// </java-name>
						[Dot42.DexImport("build", "()Landroid/net/sip/SipProfile;", AccessFlags = 1)]
						public virtual global::Android.Net.Sip.SipProfile Build() /* MethodBuilder.Create */ 
						{
								return default(global::Android.Net.Sip.SipProfile);
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal Builder() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

				}

		}

		/// <java-name>
		/// android/net/sip/SipAudioCall
		/// </java-name>
		[Dot42.DexImport("android/net/sip/SipAudioCall", AccessFlags = 33)]
		public partial class SipAudioCall
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/net/sip/SipProfile;)V", AccessFlags = 1)]
				public SipAudioCall(global::Android.Content.Context context, global::Android.Net.Sip.SipProfile sipProfile) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setListener
				/// </java-name>
				[Dot42.DexImport("setListener", "(Landroid/net/sip/SipAudioCall$Listener;)V", AccessFlags = 1)]
				public virtual void SetListener(global::Android.Net.Sip.SipAudioCall.Listener listener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setListener
				/// </java-name>
				[Dot42.DexImport("setListener", "(Landroid/net/sip/SipAudioCall$Listener;Z)V", AccessFlags = 1)]
				public virtual void SetListener(global::Android.Net.Sip.SipAudioCall.Listener listener, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isInCall
				/// </java-name>
				[Dot42.DexImport("isInCall", "()Z", AccessFlags = 1)]
				public virtual bool IsInCall() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isOnHold
				/// </java-name>
				[Dot42.DexImport("isOnHold", "()Z", AccessFlags = 1)]
				public virtual bool IsOnHold() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1)]
				public virtual void Close() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getLocalProfile
				/// </java-name>
				[Dot42.DexImport("getLocalProfile", "()Landroid/net/sip/SipProfile;", AccessFlags = 1)]
				public virtual global::Android.Net.Sip.SipProfile GetLocalProfile() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Net.Sip.SipProfile);
				}

				/// <java-name>
				/// getPeerProfile
				/// </java-name>
				[Dot42.DexImport("getPeerProfile", "()Landroid/net/sip/SipProfile;", AccessFlags = 1)]
				public virtual global::Android.Net.Sip.SipProfile GetPeerProfile() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Net.Sip.SipProfile);
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
				/// attachCall
				/// </java-name>
				[Dot42.DexImport("attachCall", "(Landroid/net/sip/SipSession;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void AttachCall(global::Android.Net.Sip.SipSession sipSession, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// makeCall
				/// </java-name>
				[Dot42.DexImport("makeCall", "(Landroid/net/sip/SipProfile;Landroid/net/sip/SipSession;I)V", AccessFlags = 1)]
				public virtual void MakeCall(global::Android.Net.Sip.SipProfile sipProfile, global::Android.Net.Sip.SipSession sipSession, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// endCall
				/// </java-name>
				[Dot42.DexImport("endCall", "()V", AccessFlags = 1)]
				public virtual void EndCall() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// holdCall
				/// </java-name>
				[Dot42.DexImport("holdCall", "(I)V", AccessFlags = 1)]
				public virtual void HoldCall(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// answerCall
				/// </java-name>
				[Dot42.DexImport("answerCall", "(I)V", AccessFlags = 1)]
				public virtual void AnswerCall(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// continueCall
				/// </java-name>
				[Dot42.DexImport("continueCall", "(I)V", AccessFlags = 1)]
				public virtual void ContinueCall(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// toggleMute
				/// </java-name>
				[Dot42.DexImport("toggleMute", "()V", AccessFlags = 1)]
				public virtual void ToggleMute() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isMuted
				/// </java-name>
				[Dot42.DexImport("isMuted", "()Z", AccessFlags = 1)]
				public virtual bool IsMuted() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setSpeakerMode
				/// </java-name>
				[Dot42.DexImport("setSpeakerMode", "(Z)V", AccessFlags = 1)]
				public virtual void SetSpeakerMode(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// sendDtmf
				/// </java-name>
				[Dot42.DexImport("sendDtmf", "(I)V", AccessFlags = 1)]
				public virtual void SendDtmf(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// sendDtmf
				/// </java-name>
				[Dot42.DexImport("sendDtmf", "(ILandroid/os/Message;)V", AccessFlags = 1)]
				public virtual void SendDtmf(int int32, global::Android.Os.Message message) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// startAudio
				/// </java-name>
				[Dot42.DexImport("startAudio", "()V", AccessFlags = 1)]
				public virtual void StartAudio() /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal SipAudioCall() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getLocalProfile
				/// </java-name>
				public global::Android.Net.Sip.SipProfile LocalProfile
				{
				[Dot42.DexImport("getLocalProfile", "()Landroid/net/sip/SipProfile;", AccessFlags = 1)]
						get{ return GetLocalProfile(); }
				}

				/// <java-name>
				/// getPeerProfile
				/// </java-name>
				public global::Android.Net.Sip.SipProfile PeerProfile
				{
				[Dot42.DexImport("getPeerProfile", "()Landroid/net/sip/SipProfile;", AccessFlags = 1)]
						get{ return GetPeerProfile(); }
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

						/// <java-name>
						/// onReadyToCall
						/// </java-name>
						[Dot42.DexImport("onReadyToCall", "(Landroid/net/sip/SipAudioCall;)V", AccessFlags = 1)]
						public virtual void OnReadyToCall(global::Android.Net.Sip.SipAudioCall sipAudioCall) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// onCalling
						/// </java-name>
						[Dot42.DexImport("onCalling", "(Landroid/net/sip/SipAudioCall;)V", AccessFlags = 1)]
						public virtual void OnCalling(global::Android.Net.Sip.SipAudioCall sipAudioCall) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// onRinging
						/// </java-name>
						[Dot42.DexImport("onRinging", "(Landroid/net/sip/SipAudioCall;Landroid/net/sip/SipProfile;)V", AccessFlags = 1)]
						public virtual void OnRinging(global::Android.Net.Sip.SipAudioCall sipAudioCall, global::Android.Net.Sip.SipProfile sipProfile) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// onRingingBack
						/// </java-name>
						[Dot42.DexImport("onRingingBack", "(Landroid/net/sip/SipAudioCall;)V", AccessFlags = 1)]
						public virtual void OnRingingBack(global::Android.Net.Sip.SipAudioCall sipAudioCall) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// onCallEstablished
						/// </java-name>
						[Dot42.DexImport("onCallEstablished", "(Landroid/net/sip/SipAudioCall;)V", AccessFlags = 1)]
						public virtual void OnCallEstablished(global::Android.Net.Sip.SipAudioCall sipAudioCall) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// onCallEnded
						/// </java-name>
						[Dot42.DexImport("onCallEnded", "(Landroid/net/sip/SipAudioCall;)V", AccessFlags = 1)]
						public virtual void OnCallEnded(global::Android.Net.Sip.SipAudioCall sipAudioCall) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// onCallBusy
						/// </java-name>
						[Dot42.DexImport("onCallBusy", "(Landroid/net/sip/SipAudioCall;)V", AccessFlags = 1)]
						public virtual void OnCallBusy(global::Android.Net.Sip.SipAudioCall sipAudioCall) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// onCallHeld
						/// </java-name>
						[Dot42.DexImport("onCallHeld", "(Landroid/net/sip/SipAudioCall;)V", AccessFlags = 1)]
						public virtual void OnCallHeld(global::Android.Net.Sip.SipAudioCall sipAudioCall) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// onError
						/// </java-name>
						[Dot42.DexImport("onError", "(Landroid/net/sip/SipAudioCall;ILjava/lang/String;)V", AccessFlags = 1)]
						public virtual void OnError(global::Android.Net.Sip.SipAudioCall sipAudioCall, int int32, string @string) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// onChanged
						/// </java-name>
						[Dot42.DexImport("onChanged", "(Landroid/net/sip/SipAudioCall;)V", AccessFlags = 1)]
						public virtual void OnChanged(global::Android.Net.Sip.SipAudioCall sipAudioCall) /* MethodBuilder.Create */ 
						{
						}

				}

		}

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
				public SipException(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public SipException(string @string, global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// android/net/sip/SipRegistrationListener
		/// </java-name>
		[Dot42.DexImport("android/net/sip/SipRegistrationListener", AccessFlags = 1537)]
		public partial interface ISipRegistrationListener
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// onRegistering
				/// </java-name>
				[Dot42.DexImport("onRegistering", "(Ljava/lang/String;)V", AccessFlags = 1025)]
				void OnRegistering(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// onRegistrationDone
				/// </java-name>
				[Dot42.DexImport("onRegistrationDone", "(Ljava/lang/String;J)V", AccessFlags = 1025)]
				void OnRegistrationDone(string @string, long int64) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// onRegistrationFailed
				/// </java-name>
				[Dot42.DexImport("onRegistrationFailed", "(Ljava/lang/String;ILjava/lang/String;)V", AccessFlags = 1025)]
				void OnRegistrationFailed(string @string, int int32, string string1) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// android/net/sip/SipErrorCode
		/// </java-name>
		[Dot42.DexImport("android/net/sip/SipErrorCode", AccessFlags = 33)]
		public partial class SipErrorCode
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// NO_ERROR
				/// </java-name>
				[Dot42.DexImport("NO_ERROR", "I", AccessFlags = 25)]
				public const int NO_ERROR = 0;
				/// <java-name>
				/// SOCKET_ERROR
				/// </java-name>
				[Dot42.DexImport("SOCKET_ERROR", "I", AccessFlags = 25)]
				public const int SOCKET_ERROR = -1;
				/// <java-name>
				/// SERVER_ERROR
				/// </java-name>
				[Dot42.DexImport("SERVER_ERROR", "I", AccessFlags = 25)]
				public const int SERVER_ERROR = -2;
				/// <java-name>
				/// TRANSACTION_TERMINTED
				/// </java-name>
				[Dot42.DexImport("TRANSACTION_TERMINTED", "I", AccessFlags = 25)]
				public const int TRANSACTION_TERMINTED = -3;
				/// <java-name>
				/// CLIENT_ERROR
				/// </java-name>
				[Dot42.DexImport("CLIENT_ERROR", "I", AccessFlags = 25)]
				public const int CLIENT_ERROR = -4;
				/// <java-name>
				/// TIME_OUT
				/// </java-name>
				[Dot42.DexImport("TIME_OUT", "I", AccessFlags = 25)]
				public const int TIME_OUT = -5;
				/// <java-name>
				/// INVALID_REMOTE_URI
				/// </java-name>
				[Dot42.DexImport("INVALID_REMOTE_URI", "I", AccessFlags = 25)]
				public const int INVALID_REMOTE_URI = -6;
				/// <java-name>
				/// PEER_NOT_REACHABLE
				/// </java-name>
				[Dot42.DexImport("PEER_NOT_REACHABLE", "I", AccessFlags = 25)]
				public const int PEER_NOT_REACHABLE = -7;
				/// <java-name>
				/// INVALID_CREDENTIALS
				/// </java-name>
				[Dot42.DexImport("INVALID_CREDENTIALS", "I", AccessFlags = 25)]
				public const int INVALID_CREDENTIALS = -8;
				/// <java-name>
				/// IN_PROGRESS
				/// </java-name>
				[Dot42.DexImport("IN_PROGRESS", "I", AccessFlags = 25)]
				public const int IN_PROGRESS = -9;
				/// <java-name>
				/// DATA_CONNECTION_LOST
				/// </java-name>
				[Dot42.DexImport("DATA_CONNECTION_LOST", "I", AccessFlags = 25)]
				public const int DATA_CONNECTION_LOST = -10;
				/// <java-name>
				/// CROSS_DOMAIN_AUTHENTICATION
				/// </java-name>
				[Dot42.DexImport("CROSS_DOMAIN_AUTHENTICATION", "I", AccessFlags = 25)]
				public const int CROSS_DOMAIN_AUTHENTICATION = -11;
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
				public static string ToString(int int32) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

		}

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

				/// <java-name>
				/// getLocalIp
				/// </java-name>
				[Dot42.DexImport("getLocalIp", "()Ljava/lang/String;", AccessFlags = 1)]
				public string GetLocalIp() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getLocalProfile
				/// </java-name>
				[Dot42.DexImport("getLocalProfile", "()Landroid/net/sip/SipProfile;", AccessFlags = 1)]
				public global::Android.Net.Sip.SipProfile GetLocalProfile() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Net.Sip.SipProfile);
				}

				/// <java-name>
				/// getPeerProfile
				/// </java-name>
				[Dot42.DexImport("getPeerProfile", "()Landroid/net/sip/SipProfile;", AccessFlags = 1)]
				public global::Android.Net.Sip.SipProfile GetPeerProfile() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Net.Sip.SipProfile);
				}

				/// <java-name>
				/// getState
				/// </java-name>
				[Dot42.DexImport("getState", "()I", AccessFlags = 1)]
				public int GetState() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// isInCall
				/// </java-name>
				[Dot42.DexImport("isInCall", "()Z", AccessFlags = 1)]
				public bool IsInCall() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getCallId
				/// </java-name>
				[Dot42.DexImport("getCallId", "()Ljava/lang/String;", AccessFlags = 1)]
				public string GetCallId() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// setListener
				/// </java-name>
				[Dot42.DexImport("setListener", "(Landroid/net/sip/SipSession$Listener;)V", AccessFlags = 1)]
				public void SetListener(global::Android.Net.Sip.SipSession.Listener listener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// register
				/// </java-name>
				[Dot42.DexImport("register", "(I)V", AccessFlags = 1)]
				public void Register(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// unregister
				/// </java-name>
				[Dot42.DexImport("unregister", "()V", AccessFlags = 1)]
				public void Unregister() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// makeCall
				/// </java-name>
				[Dot42.DexImport("makeCall", "(Landroid/net/sip/SipProfile;Ljava/lang/String;I)V", AccessFlags = 1)]
				public void MakeCall(global::Android.Net.Sip.SipProfile sipProfile, string @string, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// answerCall
				/// </java-name>
				[Dot42.DexImport("answerCall", "(Ljava/lang/String;I)V", AccessFlags = 1)]
				public void AnswerCall(string @string, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// endCall
				/// </java-name>
				[Dot42.DexImport("endCall", "()V", AccessFlags = 1)]
				public void EndCall() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// changeCall
				/// </java-name>
				[Dot42.DexImport("changeCall", "(Ljava/lang/String;I)V", AccessFlags = 1)]
				public void ChangeCall(string @string, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getLocalIp
				/// </java-name>
				public string LocalIp
				{
				[Dot42.DexImport("getLocalIp", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetLocalIp(); }
				}

				/// <java-name>
				/// getLocalProfile
				/// </java-name>
				public global::Android.Net.Sip.SipProfile LocalProfile
				{
				[Dot42.DexImport("getLocalProfile", "()Landroid/net/sip/SipProfile;", AccessFlags = 1)]
						get{ return GetLocalProfile(); }
				}

				/// <java-name>
				/// getPeerProfile
				/// </java-name>
				public global::Android.Net.Sip.SipProfile PeerProfile
				{
				[Dot42.DexImport("getPeerProfile", "()Landroid/net/sip/SipProfile;", AccessFlags = 1)]
						get{ return GetPeerProfile(); }
				}

				/// <java-name>
				/// getCallId
				/// </java-name>
				public string CallId
				{
				[Dot42.DexImport("getCallId", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetCallId(); }
				}

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

						/// <java-name>
						/// onCalling
						/// </java-name>
						[Dot42.DexImport("onCalling", "(Landroid/net/sip/SipSession;)V", AccessFlags = 1)]
						public virtual void OnCalling(global::Android.Net.Sip.SipSession sipSession) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// onRinging
						/// </java-name>
						[Dot42.DexImport("onRinging", "(Landroid/net/sip/SipSession;Landroid/net/sip/SipProfile;Ljava/lang/String;)V", AccessFlags = 1)]
						public virtual void OnRinging(global::Android.Net.Sip.SipSession sipSession, global::Android.Net.Sip.SipProfile sipProfile, string @string) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// onRingingBack
						/// </java-name>
						[Dot42.DexImport("onRingingBack", "(Landroid/net/sip/SipSession;)V", AccessFlags = 1)]
						public virtual void OnRingingBack(global::Android.Net.Sip.SipSession sipSession) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// onCallEstablished
						/// </java-name>
						[Dot42.DexImport("onCallEstablished", "(Landroid/net/sip/SipSession;Ljava/lang/String;)V", AccessFlags = 1)]
						public virtual void OnCallEstablished(global::Android.Net.Sip.SipSession sipSession, string @string) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// onCallEnded
						/// </java-name>
						[Dot42.DexImport("onCallEnded", "(Landroid/net/sip/SipSession;)V", AccessFlags = 1)]
						public virtual void OnCallEnded(global::Android.Net.Sip.SipSession sipSession) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// onCallBusy
						/// </java-name>
						[Dot42.DexImport("onCallBusy", "(Landroid/net/sip/SipSession;)V", AccessFlags = 1)]
						public virtual void OnCallBusy(global::Android.Net.Sip.SipSession sipSession) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// onError
						/// </java-name>
						[Dot42.DexImport("onError", "(Landroid/net/sip/SipSession;ILjava/lang/String;)V", AccessFlags = 1)]
						public virtual void OnError(global::Android.Net.Sip.SipSession sipSession, int int32, string @string) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// onCallChangeFailed
						/// </java-name>
						[Dot42.DexImport("onCallChangeFailed", "(Landroid/net/sip/SipSession;ILjava/lang/String;)V", AccessFlags = 1)]
						public virtual void OnCallChangeFailed(global::Android.Net.Sip.SipSession sipSession, int int32, string @string) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// onRegistering
						/// </java-name>
						[Dot42.DexImport("onRegistering", "(Landroid/net/sip/SipSession;)V", AccessFlags = 1)]
						public virtual void OnRegistering(global::Android.Net.Sip.SipSession sipSession) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// onRegistrationDone
						/// </java-name>
						[Dot42.DexImport("onRegistrationDone", "(Landroid/net/sip/SipSession;I)V", AccessFlags = 1)]
						public virtual void OnRegistrationDone(global::Android.Net.Sip.SipSession sipSession, int int32) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// onRegistrationFailed
						/// </java-name>
						[Dot42.DexImport("onRegistrationFailed", "(Landroid/net/sip/SipSession;ILjava/lang/String;)V", AccessFlags = 1)]
						public virtual void OnRegistrationFailed(global::Android.Net.Sip.SipSession sipSession, int int32, string @string) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// onRegistrationTimeout
						/// </java-name>
						[Dot42.DexImport("onRegistrationTimeout", "(Landroid/net/sip/SipSession;)V", AccessFlags = 1)]
						public virtual void OnRegistrationTimeout(global::Android.Net.Sip.SipSession sipSession) /* MethodBuilder.Create */ 
						{
						}

				}

				/// <java-name>
				/// android/net/sip/SipSession$State
				/// </java-name>
				[Dot42.DexImport("android/net/sip/SipSession$State", AccessFlags = 9)]
				public partial class State
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// READY_TO_CALL
						/// </java-name>
						[Dot42.DexImport("READY_TO_CALL", "I", AccessFlags = 25)]
						public const int READY_TO_CALL = 0;
						/// <java-name>
						/// REGISTERING
						/// </java-name>
						[Dot42.DexImport("REGISTERING", "I", AccessFlags = 25)]
						public const int REGISTERING = 1;
						/// <java-name>
						/// DEREGISTERING
						/// </java-name>
						[Dot42.DexImport("DEREGISTERING", "I", AccessFlags = 25)]
						public const int DEREGISTERING = 2;
						/// <java-name>
						/// INCOMING_CALL
						/// </java-name>
						[Dot42.DexImport("INCOMING_CALL", "I", AccessFlags = 25)]
						public const int INCOMING_CALL = 3;
						/// <java-name>
						/// INCOMING_CALL_ANSWERING
						/// </java-name>
						[Dot42.DexImport("INCOMING_CALL_ANSWERING", "I", AccessFlags = 25)]
						public const int INCOMING_CALL_ANSWERING = 4;
						/// <java-name>
						/// OUTGOING_CALL
						/// </java-name>
						[Dot42.DexImport("OUTGOING_CALL", "I", AccessFlags = 25)]
						public const int OUTGOING_CALL = 5;
						/// <java-name>
						/// OUTGOING_CALL_RING_BACK
						/// </java-name>
						[Dot42.DexImport("OUTGOING_CALL_RING_BACK", "I", AccessFlags = 25)]
						public const int OUTGOING_CALL_RING_BACK = 6;
						/// <java-name>
						/// OUTGOING_CALL_CANCELING
						/// </java-name>
						[Dot42.DexImport("OUTGOING_CALL_CANCELING", "I", AccessFlags = 25)]
						public const int OUTGOING_CALL_CANCELING = 7;
						/// <java-name>
						/// IN_CALL
						/// </java-name>
						[Dot42.DexImport("IN_CALL", "I", AccessFlags = 25)]
						public const int IN_CALL = 8;
						/// <java-name>
						/// PINGING
						/// </java-name>
						[Dot42.DexImport("PINGING", "I", AccessFlags = 25)]
						public const int PINGING = 9;
						/// <java-name>
						/// NOT_DEFINED
						/// </java-name>
						[Dot42.DexImport("NOT_DEFINED", "I", AccessFlags = 25)]
						public const int NOT_DEFINED = 101;
						[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
						internal State() /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// toString
						/// </java-name>
						[Dot42.DexImport("toString", "(I)Ljava/lang/String;", AccessFlags = 9)]
						public static string ToString(int int32) /* MethodBuilder.Create */ 
						{
								return default(string);
						}

				}

		}

}

