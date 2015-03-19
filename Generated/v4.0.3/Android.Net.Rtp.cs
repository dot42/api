#pragma warning disable 1717
namespace Android.Net.Rtp
{
		/// <java-name>
		/// android/net/rtp/AudioCodec
		/// </java-name>
		[Dot42.DexImport("android/net/rtp/AudioCodec", AccessFlags = 33)]
		public partial class AudioCodec
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// type
				/// </java-name>
				[Dot42.DexImport("type", "I", AccessFlags = 17)]
				public readonly int Type;
				/// <java-name>
				/// rtpmap
				/// </java-name>
				[Dot42.DexImport("rtpmap", "Ljava/lang/String;", AccessFlags = 17)]
				public readonly string Rtpmap;
				/// <java-name>
				/// fmtp
				/// </java-name>
				[Dot42.DexImport("fmtp", "Ljava/lang/String;", AccessFlags = 17)]
				public readonly string Fmtp;
				/// <java-name>
				/// PCMU
				/// </java-name>
				[Dot42.DexImport("PCMU", "Landroid/net/rtp/AudioCodec;", AccessFlags = 25)]
				public static readonly global::Android.Net.Rtp.AudioCodec PCMU;
				/// <java-name>
				/// PCMA
				/// </java-name>
				[Dot42.DexImport("PCMA", "Landroid/net/rtp/AudioCodec;", AccessFlags = 25)]
				public static readonly global::Android.Net.Rtp.AudioCodec PCMA;
				/// <java-name>
				/// GSM
				/// </java-name>
				[Dot42.DexImport("GSM", "Landroid/net/rtp/AudioCodec;", AccessFlags = 25)]
				public static readonly global::Android.Net.Rtp.AudioCodec GSM;
				/// <java-name>
				/// GSM_EFR
				/// </java-name>
				[Dot42.DexImport("GSM_EFR", "Landroid/net/rtp/AudioCodec;", AccessFlags = 25)]
				public static readonly global::Android.Net.Rtp.AudioCodec GSM_EFR;
				/// <java-name>
				/// AMR
				/// </java-name>
				[Dot42.DexImport("AMR", "Landroid/net/rtp/AudioCodec;", AccessFlags = 25)]
				public static readonly global::Android.Net.Rtp.AudioCodec AMR;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal AudioCodec() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getCodecs
				/// </java-name>
				[Dot42.DexImport("getCodecs", "()[Landroid/net/rtp/AudioCodec;", AccessFlags = 9)]
				public static global::Android.Net.Rtp.AudioCodec[] GetCodecs() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Net.Rtp.AudioCodec[]);
				}

				/// <java-name>
				/// getCodec
				/// </java-name>
				[Dot42.DexImport("getCodec", "(ILjava/lang/String;Ljava/lang/String;)Landroid/net/rtp/AudioCodec;", AccessFlags = 9)]
				public static global::Android.Net.Rtp.AudioCodec GetCodec(int int32, string @string, string string1) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Net.Rtp.AudioCodec);
				}

				/// <java-name>
				/// getCodecs
				/// </java-name>
				public static global::Android.Net.Rtp.AudioCodec[] Codecs
				{
				[Dot42.DexImport("getCodecs", "()[Landroid/net/rtp/AudioCodec;", AccessFlags = 9)]
						get{ return GetCodecs(); }
				}

		}

		/// <java-name>
		/// android/net/rtp/AudioStream
		/// </java-name>
		[Dot42.DexImport("android/net/rtp/AudioStream", AccessFlags = 33)]
		public partial class AudioStream : global::Android.Net.Rtp.RtpStream
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/net/InetAddress;)V", AccessFlags = 1)]
				public AudioStream(global::Java.Net.InetAddress inetAddress) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isBusy
				/// </java-name>
				[Dot42.DexImport("isBusy", "()Z", AccessFlags = 17)]
				public override bool IsBusy() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getGroup
				/// </java-name>
				[Dot42.DexImport("getGroup", "()Landroid/net/rtp/AudioGroup;", AccessFlags = 1)]
				public virtual global::Android.Net.Rtp.AudioGroup GetGroup() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Net.Rtp.AudioGroup);
				}

				/// <java-name>
				/// join
				/// </java-name>
				[Dot42.DexImport("join", "(Landroid/net/rtp/AudioGroup;)V", AccessFlags = 1)]
				public virtual void Join(global::Android.Net.Rtp.AudioGroup audioGroup) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getCodec
				/// </java-name>
				[Dot42.DexImport("getCodec", "()Landroid/net/rtp/AudioCodec;", AccessFlags = 1)]
				public virtual global::Android.Net.Rtp.AudioCodec GetCodec() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Net.Rtp.AudioCodec);
				}

				/// <java-name>
				/// setCodec
				/// </java-name>
				[Dot42.DexImport("setCodec", "(Landroid/net/rtp/AudioCodec;)V", AccessFlags = 1)]
				public virtual void SetCodec(global::Android.Net.Rtp.AudioCodec audioCodec) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getDtmfType
				/// </java-name>
				[Dot42.DexImport("getDtmfType", "()I", AccessFlags = 1)]
				public virtual int GetDtmfType() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// setDtmfType
				/// </java-name>
				[Dot42.DexImport("setDtmfType", "(I)V", AccessFlags = 1)]
				public virtual void SetDtmfType(int int32) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal AudioStream() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getGroup
				/// </java-name>
				public global::Android.Net.Rtp.AudioGroup Group
				{
				[Dot42.DexImport("getGroup", "()Landroid/net/rtp/AudioGroup;", AccessFlags = 1)]
						get{ return GetGroup(); }
				}

				/// <java-name>
				/// getCodec
				/// </java-name>
				public global::Android.Net.Rtp.AudioCodec Codec
				{
				[Dot42.DexImport("getCodec", "()Landroid/net/rtp/AudioCodec;", AccessFlags = 1)]
						get{ return GetCodec(); }
				[Dot42.DexImport("setCodec", "(Landroid/net/rtp/AudioCodec;)V", AccessFlags = 1)]
						set{ SetCodec(value); }
				}

				/// <java-name>
				/// getDtmfType
				/// </java-name>
				public int DtmfType
				{
				[Dot42.DexImport("getDtmfType", "()I", AccessFlags = 1)]
						get{ return GetDtmfType(); }
				[Dot42.DexImport("setDtmfType", "(I)V", AccessFlags = 1)]
						set{ SetDtmfType(value); }
				}

		}

		/// <java-name>
		/// android/net/rtp/RtpStream
		/// </java-name>
		[Dot42.DexImport("android/net/rtp/RtpStream", AccessFlags = 33)]
		public partial class RtpStream
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// MODE_NORMAL
				/// </java-name>
				[Dot42.DexImport("MODE_NORMAL", "I", AccessFlags = 25)]
				public const int MODE_NORMAL = 0;
				/// <java-name>
				/// MODE_SEND_ONLY
				/// </java-name>
				[Dot42.DexImport("MODE_SEND_ONLY", "I", AccessFlags = 25)]
				public const int MODE_SEND_ONLY = 1;
				/// <java-name>
				/// MODE_RECEIVE_ONLY
				/// </java-name>
				[Dot42.DexImport("MODE_RECEIVE_ONLY", "I", AccessFlags = 25)]
				public const int MODE_RECEIVE_ONLY = 2;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal RtpStream() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getLocalAddress
				/// </java-name>
				[Dot42.DexImport("getLocalAddress", "()Ljava/net/InetAddress;", AccessFlags = 1)]
				public virtual global::Java.Net.InetAddress GetLocalAddress() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.InetAddress);
				}

				/// <java-name>
				/// getLocalPort
				/// </java-name>
				[Dot42.DexImport("getLocalPort", "()I", AccessFlags = 1)]
				public virtual int GetLocalPort() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getRemoteAddress
				/// </java-name>
				[Dot42.DexImport("getRemoteAddress", "()Ljava/net/InetAddress;", AccessFlags = 1)]
				public virtual global::Java.Net.InetAddress GetRemoteAddress() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.InetAddress);
				}

				/// <java-name>
				/// getRemotePort
				/// </java-name>
				[Dot42.DexImport("getRemotePort", "()I", AccessFlags = 1)]
				public virtual int GetRemotePort() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// isBusy
				/// </java-name>
				[Dot42.DexImport("isBusy", "()Z", AccessFlags = 1)]
				public virtual bool IsBusy() /* MethodBuilder.Create */ 
				{
						return default(bool);
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
				/// setMode
				/// </java-name>
				[Dot42.DexImport("setMode", "(I)V", AccessFlags = 1)]
				public virtual void SetMode(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// associate
				/// </java-name>
				[Dot42.DexImport("associate", "(Ljava/net/InetAddress;I)V", AccessFlags = 1)]
				public virtual void Associate(global::Java.Net.InetAddress inetAddress, int int32) /* MethodBuilder.Create */ 
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
				extern ~RtpStream() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getLocalAddress
				/// </java-name>
				public global::Java.Net.InetAddress LocalAddress
				{
				[Dot42.DexImport("getLocalAddress", "()Ljava/net/InetAddress;", AccessFlags = 1)]
						get{ return GetLocalAddress(); }
				}

				/// <java-name>
				/// getLocalPort
				/// </java-name>
				public int LocalPort
				{
				[Dot42.DexImport("getLocalPort", "()I", AccessFlags = 1)]
						get{ return GetLocalPort(); }
				}

				/// <java-name>
				/// getRemoteAddress
				/// </java-name>
				public global::Java.Net.InetAddress RemoteAddress
				{
				[Dot42.DexImport("getRemoteAddress", "()Ljava/net/InetAddress;", AccessFlags = 1)]
						get{ return GetRemoteAddress(); }
				}

				/// <java-name>
				/// getRemotePort
				/// </java-name>
				public int RemotePort
				{
				[Dot42.DexImport("getRemotePort", "()I", AccessFlags = 1)]
						get{ return GetRemotePort(); }
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

		}

		/// <java-name>
		/// android/net/rtp/AudioGroup
		/// </java-name>
		[Dot42.DexImport("android/net/rtp/AudioGroup", AccessFlags = 33)]
		public partial class AudioGroup
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// MODE_ON_HOLD
				/// </java-name>
				[Dot42.DexImport("MODE_ON_HOLD", "I", AccessFlags = 25)]
				public const int MODE_ON_HOLD = 0;
				/// <java-name>
				/// MODE_MUTED
				/// </java-name>
				[Dot42.DexImport("MODE_MUTED", "I", AccessFlags = 25)]
				public const int MODE_MUTED = 1;
				/// <java-name>
				/// MODE_NORMAL
				/// </java-name>
				[Dot42.DexImport("MODE_NORMAL", "I", AccessFlags = 25)]
				public const int MODE_NORMAL = 2;
				/// <java-name>
				/// MODE_ECHO_SUPPRESSION
				/// </java-name>
				[Dot42.DexImport("MODE_ECHO_SUPPRESSION", "I", AccessFlags = 25)]
				public const int MODE_ECHO_SUPPRESSION = 3;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public AudioGroup() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getStreams
				/// </java-name>
				[Dot42.DexImport("getStreams", "()[Landroid/net/rtp/AudioStream;", AccessFlags = 1)]
				public virtual global::Android.Net.Rtp.AudioStream[] GetStreams() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Net.Rtp.AudioStream[]);
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
				/// setMode
				/// </java-name>
				[Dot42.DexImport("setMode", "(I)V", AccessFlags = 1)]
				public virtual void SetMode(int int32) /* MethodBuilder.Create */ 
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
				/// clear
				/// </java-name>
				[Dot42.DexImport("clear", "()V", AccessFlags = 1)]
				public virtual void Clear() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// finalize
				/// </java-name>
				[Dot42.DexImport("finalize", "()V", AccessFlags = 4)]
				extern ~AudioGroup() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getStreams
				/// </java-name>
				public global::Android.Net.Rtp.AudioStream[] Streams
				{
				[Dot42.DexImport("getStreams", "()[Landroid/net/rtp/AudioStream;", AccessFlags = 1)]
						get{ return GetStreams(); }
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

		}

}

