#pragma warning disable 1717
namespace Android.Net.Rtp
{
		/// <summary>
		///  <para>This class defines a collection of audio codecs to be used with AudioStreams. Their parameters are designed to be exchanged using Session Description Protocol (SDP). Most of the values listed here can be found in RFC 3551, while others are described in separated standards.</para> <para>Few simple configurations are defined as public static instances for the convenience of direct uses. More complicated ones could be obtained using getCodec(int, String, String). For example, one can use the following snippet to create a mode-1-only AMR codec.</para> <para> <pre>
		/// AudioCodec codec = AudioCodec.getCodec(100, "AMR/8000", "mode-set=1");
		/// </pre></para> <para> <para>AudioStream </para></para>    
		/// </summary>
		/// <java-name>
		/// android/net/rtp/AudioCodec
		/// </java-name>
		[Dot42.DexImport("android/net/rtp/AudioCodec", AccessFlags = 33)]
		public partial class AudioCodec
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>The RTP payload type of the encoding. </para>        
				/// </summary>
				/// <java-name>
				/// type
				/// </java-name>
				[Dot42.DexImport("type", "I", AccessFlags = 17)]
				public readonly int Type;
				/// <summary>
				///  <para>The encoding parameters to be used in the corresponding SDP attribute. </para>        
				/// </summary>
				/// <java-name>
				/// rtpmap
				/// </java-name>
				[Dot42.DexImport("rtpmap", "Ljava/lang/String;", AccessFlags = 17)]
				public readonly string Rtpmap;
				/// <summary>
				///  <para>The format parameters to be used in the corresponding SDP attribute. </para>        
				/// </summary>
				/// <java-name>
				/// fmtp
				/// </java-name>
				[Dot42.DexImport("fmtp", "Ljava/lang/String;", AccessFlags = 17)]
				public readonly string Fmtp;
				/// <summary>
				///  <para>G.711 u-law audio codec. </para>        
				/// </summary>
				/// <java-name>
				/// PCMU
				/// </java-name>
				[Dot42.DexImport("PCMU", "Landroid/net/rtp/AudioCodec;", AccessFlags = 25)]
				public static readonly global::Android.Net.Rtp.AudioCodec PCMU;
				/// <summary>
				///  <para>G.711 a-law audio codec. </para>        
				/// </summary>
				/// <java-name>
				/// PCMA
				/// </java-name>
				[Dot42.DexImport("PCMA", "Landroid/net/rtp/AudioCodec;", AccessFlags = 25)]
				public static readonly global::Android.Net.Rtp.AudioCodec PCMA;
				/// <summary>
				///  <para>GSM Full-Rate audio codec, also known as GSM-FR, GSM 06.10, GSM, or simply FR. </para>        
				/// </summary>
				/// <java-name>
				/// GSM
				/// </java-name>
				[Dot42.DexImport("GSM", "Landroid/net/rtp/AudioCodec;", AccessFlags = 25)]
				public static readonly global::Android.Net.Rtp.AudioCodec GSM;
				/// <summary>
				///  <para>GSM Enhanced Full-Rate audio codec, also known as GSM-EFR, GSM 06.60, or simply EFR. </para>        
				/// </summary>
				/// <java-name>
				/// GSM_EFR
				/// </java-name>
				[Dot42.DexImport("GSM_EFR", "Landroid/net/rtp/AudioCodec;", AccessFlags = 25)]
				public static readonly global::Android.Net.Rtp.AudioCodec GSM_EFR;
				/// <summary>
				///  <para>Adaptive Multi-Rate narrowband audio codec, also known as AMR or AMR-NB. Currently CRC, robust sorting, and interleaving are not supported. See more details about these features in RFC 4867. </para>        
				/// </summary>
				/// <java-name>
				/// AMR
				/// </java-name>
				[Dot42.DexImport("AMR", "Landroid/net/rtp/AudioCodec;", AccessFlags = 25)]
				public static readonly global::Android.Net.Rtp.AudioCodec AMR;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal AudioCodec() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Creates an AudioCodec according to the given configuration.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The configured AudioCodec or <c>null </c> if it is not supported. </para>
				/// </returns>
				/// <java-name>
				/// getCodec
				/// </java-name>
				[Dot42.DexImport("getCodec", "(ILjava/lang/String;Ljava/lang/String;)Landroid/net/rtp/AudioCodec;", AccessFlags = 9)]
				public static global::Android.Net.Rtp.AudioCodec GetCodec(int type, string rtpmap, string fmtp) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Net.Rtp.AudioCodec);
				}

				/// <summary>
				///  <para>Returns system supported audio codecs. </para>        
				/// </summary>
				/// <java-name>
				/// getCodecs
				/// </java-name>
				public static global::Android.Net.Rtp.AudioCodec[] Codecs
				{
						[Dot42.DexImport("getCodecs", "()[Landroid/net/rtp/AudioCodec;", AccessFlags = 9)]
						get{ return default(global::Android.Net.Rtp.AudioCodec[]); }
				}

		}

		/// <summary>
		///  <para>An AudioGroup is an audio hub for the speaker, the microphone, and AudioStreams. Each of these components can be logically turned on or off by calling setMode(int) or RtpStream#setMode(int). The AudioGroup will go through these components and process them one by one within its execution loop. The loop consists of four steps. First, for each AudioStream not in RtpStream#MODE_SEND_ONLY, decodes its incoming packets and stores in its buffer. Then, if the microphone is enabled, processes the recorded audio and stores in its buffer. Third, if the speaker is enabled, mixes all AudioStream buffers and plays back. Finally, for each AudioStream not in RtpStream#MODE_RECEIVE_ONLY, mixes all other buffers and sends back the encoded packets. An AudioGroup does nothing if there is no AudioStream in it.</para> <para>Few things must be noticed before using these classes. The performance is highly related to the system load and the network bandwidth. Usually a simpler AudioCodec costs fewer CPU cycles but requires more network bandwidth, and vise versa. Using two AudioStreams at the same time doubles not only the load but also the bandwidth. The condition varies from one device to another, and developers should choose the right combination in order to get the best result.</para> <para>It is sometimes useful to keep multiple AudioGroups at the same time. For example, a Voice over IP (VoIP) application might want to put a conference call on hold in order to make a new call but still allow people in the conference call talking to each other. This can be done easily using two AudioGroups, but there are some limitations. Since the speaker and the microphone are globally shared resources, only one AudioGroup at a time is allowed to run in a mode other than MODE_ON_HOLD. The others will be unable to acquire these resources and fail silently.</para> <para>Using this class requires android.Manifest.permission#RECORD_AUDIO permission. Developers should set the audio mode to AudioManager#MODE_IN_COMMUNICATION using AudioManager#setMode(int) and change it back when none of the AudioGroups is in use.</para> <para> <para>AudioStream </para></para>    
		/// </summary>
		/// <java-name>
		/// android/net/rtp/AudioGroup
		/// </java-name>
		[Dot42.DexImport("android/net/rtp/AudioGroup", AccessFlags = 33)]
		public partial class AudioGroup
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>This mode is similar to MODE_NORMAL except the speaker and the microphone are both disabled. </para>        
				/// </summary>
				/// <java-name>
				/// MODE_ON_HOLD
				/// </java-name>
				[Dot42.DexImport("MODE_ON_HOLD", "I", AccessFlags = 25)]
				public const int MODE_ON_HOLD = 0;
				/// <summary>
				///  <para>This mode is similar to MODE_NORMAL except the microphone is disabled. </para>        
				/// </summary>
				/// <java-name>
				/// MODE_MUTED
				/// </java-name>
				[Dot42.DexImport("MODE_MUTED", "I", AccessFlags = 25)]
				public const int MODE_MUTED = 1;
				/// <summary>
				///  <para>This mode indicates that the speaker, the microphone, and all AudioStreams in the group are enabled. First, the packets received from the streams are decoded and mixed with the audio recorded from the microphone. Then, the results are played back to the speaker, encoded and sent back to each stream. </para>        
				/// </summary>
				/// <java-name>
				/// MODE_NORMAL
				/// </java-name>
				[Dot42.DexImport("MODE_NORMAL", "I", AccessFlags = 25)]
				public const int MODE_NORMAL = 2;
				/// <summary>
				///  <para>This mode is similar to MODE_NORMAL except the echo suppression is enabled. It should be only used when the speaker phone is on. </para>        
				/// </summary>
				/// <java-name>
				/// MODE_ECHO_SUPPRESSION
				/// </java-name>
				[Dot42.DexImport("MODE_ECHO_SUPPRESSION", "I", AccessFlags = 25)]
				public const int MODE_ECHO_SUPPRESSION = 3;
				/// <summary>
				///  <para>Creates an empty AudioGroup. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public AudioGroup() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sends a DTMF digit to every AudioStream in this group. Currently only event <c>0 </c> to <c>15 </c> are supported.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// sendDtmf
				/// </java-name>
				[Dot42.DexImport("sendDtmf", "(I)V", AccessFlags = 1)]
				public virtual void SendDtmf(int @event) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Removes every AudioStream in this group. </para>        
				/// </summary>
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

				/// <summary>
				///  <para>Returns the AudioStreams in this group. </para>        
				/// </summary>
				/// <java-name>
				/// getStreams
				/// </java-name>
				public virtual global::Android.Net.Rtp.AudioStream[] Streams
				{
						[Dot42.DexImport("getStreams", "()[Landroid/net/rtp/AudioStream;", AccessFlags = 1)]
						get{ return default(global::Android.Net.Rtp.AudioStream[]); }
				}

				/// <summary>
				///  <para>Returns the current mode. </para>        
				/// </summary>
				/// <java-name>
				/// getMode
				/// </java-name>
				public virtual int Mode
				{
						[Dot42.DexImport("getMode", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setMode", "(I)V", AccessFlags = 1)]
						set{ }
				}

		}

		/// <summary>
		///  <para>An AudioStream is a RtpStream which carrys audio payloads over Real-time Transport Protocol (RTP). Two different classes are developed in order to support various usages such as audio conferencing. An AudioStream represents a remote endpoint which consists of a network mapping and a configured AudioCodec. On the other side, An AudioGroup represents a local endpoint which mixes all the AudioStreams and optionally interacts with the speaker and the microphone at the same time. The simplest usage includes one for each endpoints. For other combinations, developers should be aware of the limitations described in AudioGroup.</para> <para>An AudioStream becomes busy when it joins an AudioGroup. In this case most of the setter methods are disabled. This is designed to ease the task of managing native resources. One can always make an AudioStream leave its AudioGroup by calling join(AudioGroup) with <c>null </c> and put it back after the modification is done.</para> <para>Using this class requires android.Manifest.permission#INTERNET permission.</para> <para> <para>RtpStream </para> <para>AudioGroup </para></para>    
		/// </summary>
		/// <java-name>
		/// android/net/rtp/AudioStream
		/// </java-name>
		[Dot42.DexImport("android/net/rtp/AudioStream", AccessFlags = 33)]
		public partial class AudioStream : global::Android.Net.Rtp.RtpStream
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Creates an AudioStream on the given local address. Note that the local port is assigned automatically to conform with RFC 3550.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/net/InetAddress;)V", AccessFlags = 1)]
				public AudioStream(global::Java.Net.InetAddress address) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Joins an AudioGroup. Each stream can join only one group at a time. The group can be changed by passing a different one or removed by calling this method with <c>null </c> .</para> <para> <para>AudioGroup </para></para>        
				/// </summary>
				/// <java-name>
				/// join
				/// </java-name>
				[Dot42.DexImport("join", "(Landroid/net/rtp/AudioGroup;)V", AccessFlags = 1)]
				public virtual void Join(global::Android.Net.Rtp.AudioGroup group) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal AudioStream() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Returns <c>true </c> if the stream has already joined an AudioGroup. </para>        
				/// </summary>
				/// <java-name>
				/// isBusy
				/// </java-name>
				public override bool IsBusy
				{
						[Dot42.DexImport("isBusy", "()Z", AccessFlags = 17)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Returns the joined AudioGroup. </para>        
				/// </summary>
				/// <java-name>
				/// getGroup
				/// </java-name>
				public virtual global::Android.Net.Rtp.AudioGroup Group
				{
						[Dot42.DexImport("getGroup", "()Landroid/net/rtp/AudioGroup;", AccessFlags = 1)]
						get{ return default(global::Android.Net.Rtp.AudioGroup); }
				}

				/// <summary>
				///  <para>Returns the AudioCodec, or <c>null </c> if it is not set.</para> <para> <para>setCodec(AudioCodec) </para></para>        
				/// </summary>
				/// <java-name>
				/// getCodec
				/// </java-name>
				public virtual global::Android.Net.Rtp.AudioCodec Codec
				{
						[Dot42.DexImport("getCodec", "()Landroid/net/rtp/AudioCodec;", AccessFlags = 1)]
						get{ return default(global::Android.Net.Rtp.AudioCodec); }
						[Dot42.DexImport("setCodec", "(Landroid/net/rtp/AudioCodec;)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Returns the RTP payload type for dual-tone multi-frequency (DTMF) digits, or <c>-1 </c> if it is not enabled.</para> <para> <para>setDtmfType(int) </para></para>        
				/// </summary>
				/// <java-name>
				/// getDtmfType
				/// </java-name>
				public virtual int DtmfType
				{
						[Dot42.DexImport("getDtmfType", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setDtmfType", "(I)V", AccessFlags = 1)]
						set{ }
				}

		}

		/// <summary>
		///  <para>RtpStream represents the base class of streams which send and receive network packets with media payloads over Real-time Transport Protocol (RTP).</para> <para>Using this class requires android.Manifest.permission#INTERNET permission.</para>    
		/// </summary>
		/// <java-name>
		/// android/net/rtp/RtpStream
		/// </java-name>
		[Dot42.DexImport("android/net/rtp/RtpStream", AccessFlags = 33)]
		public partial class RtpStream
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>This mode indicates that the stream sends and receives packets at the same time. This is the initial mode for new streams. </para>        
				/// </summary>
				/// <java-name>
				/// MODE_NORMAL
				/// </java-name>
				[Dot42.DexImport("MODE_NORMAL", "I", AccessFlags = 25)]
				public const int MODE_NORMAL = 0;
				/// <summary>
				///  <para>This mode indicates that the stream only sends packets. </para>        
				/// </summary>
				/// <java-name>
				/// MODE_SEND_ONLY
				/// </java-name>
				[Dot42.DexImport("MODE_SEND_ONLY", "I", AccessFlags = 25)]
				public const int MODE_SEND_ONLY = 1;
				/// <summary>
				///  <para>This mode indicates that the stream only receives packets. </para>        
				/// </summary>
				/// <java-name>
				/// MODE_RECEIVE_ONLY
				/// </java-name>
				[Dot42.DexImport("MODE_RECEIVE_ONLY", "I", AccessFlags = 25)]
				public const int MODE_RECEIVE_ONLY = 2;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal RtpStream() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Associates with a remote host. This defines the destination of the outgoing packets.</para> <para> <para>isBusy() </para></para>        
				/// </summary>
				/// <java-name>
				/// associate
				/// </java-name>
				[Dot42.DexImport("associate", "(Ljava/net/InetAddress;I)V", AccessFlags = 1)]
				public virtual void Associate(global::Java.Net.InetAddress address, int port) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Releases allocated resources. The stream becomes inoperable after calling this method.</para> <para> <para>isBusy() </para></para>        
				/// </summary>
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

				/// <summary>
				///  <para>Returns the network address of the local host. </para>        
				/// </summary>
				/// <java-name>
				/// getLocalAddress
				/// </java-name>
				public virtual global::Java.Net.InetAddress LocalAddress
				{
						[Dot42.DexImport("getLocalAddress", "()Ljava/net/InetAddress;", AccessFlags = 1)]
						get{ return default(global::Java.Net.InetAddress); }
				}

				/// <summary>
				///  <para>Returns the network port of the local host. </para>        
				/// </summary>
				/// <java-name>
				/// getLocalPort
				/// </java-name>
				public virtual int LocalPort
				{
						[Dot42.DexImport("getLocalPort", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns the network address of the remote host or <c>null </c> if the stream is not associated. </para>        
				/// </summary>
				/// <java-name>
				/// getRemoteAddress
				/// </java-name>
				public virtual global::Java.Net.InetAddress RemoteAddress
				{
						[Dot42.DexImport("getRemoteAddress", "()Ljava/net/InetAddress;", AccessFlags = 1)]
						get{ return default(global::Java.Net.InetAddress); }
				}

				/// <summary>
				///  <para>Returns the network port of the remote host or <c>-1 </c> if the stream is not associated. </para>        
				/// </summary>
				/// <java-name>
				/// getRemotePort
				/// </java-name>
				public virtual int RemotePort
				{
						[Dot42.DexImport("getRemotePort", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns <c>true </c> if the stream is busy. In this case most of the setter methods are disabled. This method is intended to be overridden by subclasses. </para>        
				/// </summary>
				/// <java-name>
				/// isBusy
				/// </java-name>
				public virtual bool IsBusy
				{
						[Dot42.DexImport("isBusy", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Returns the current mode. </para>        
				/// </summary>
				/// <java-name>
				/// getMode
				/// </java-name>
				public virtual int Mode
				{
						[Dot42.DexImport("getMode", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setMode", "(I)V", AccessFlags = 1)]
						set{ }
				}

		}

}

