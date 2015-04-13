#pragma warning disable 1717
namespace Android.Net
{
		/// <java-name>
		/// android/net/ConnectivityManager
		/// </java-name>
		[Dot42.DexImport("android/net/ConnectivityManager", AccessFlags = 33)]
		public partial class ConnectivityManager
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// CONNECTIVITY_ACTION
				/// </java-name>
				[Dot42.DexImport("CONNECTIVITY_ACTION", "Ljava/lang/String;", AccessFlags = 25)]
				public const string CONNECTIVITY_ACTION = "android.net.conn.CONNECTIVITY_CHANGE";
				/// <java-name>
				/// EXTRA_NETWORK_INFO
				/// </java-name>
				[Dot42.DexImport("EXTRA_NETWORK_INFO", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_NETWORK_INFO = "networkInfo";
				/// <java-name>
				/// EXTRA_IS_FAILOVER
				/// </java-name>
				[Dot42.DexImport("EXTRA_IS_FAILOVER", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_IS_FAILOVER = "isFailover";
				/// <java-name>
				/// EXTRA_OTHER_NETWORK_INFO
				/// </java-name>
				[Dot42.DexImport("EXTRA_OTHER_NETWORK_INFO", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_OTHER_NETWORK_INFO = "otherNetwork";
				/// <java-name>
				/// EXTRA_NO_CONNECTIVITY
				/// </java-name>
				[Dot42.DexImport("EXTRA_NO_CONNECTIVITY", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_NO_CONNECTIVITY = "noConnectivity";
				/// <java-name>
				/// EXTRA_REASON
				/// </java-name>
				[Dot42.DexImport("EXTRA_REASON", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_REASON = "reason";
				/// <java-name>
				/// EXTRA_EXTRA_INFO
				/// </java-name>
				[Dot42.DexImport("EXTRA_EXTRA_INFO", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_EXTRA_INFO = "extraInfo";
				/// <java-name>
				/// ACTION_BACKGROUND_DATA_SETTING_CHANGED
				/// </java-name>
				[Dot42.DexImport("ACTION_BACKGROUND_DATA_SETTING_CHANGED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_BACKGROUND_DATA_SETTING_CHANGED = "android.net.conn.BACKGROUND_DATA_SETTING_CHANGED";
				/// <java-name>
				/// TYPE_MOBILE
				/// </java-name>
				[Dot42.DexImport("TYPE_MOBILE", "I", AccessFlags = 25)]
				public const int TYPE_MOBILE = 0;
				/// <java-name>
				/// TYPE_WIFI
				/// </java-name>
				[Dot42.DexImport("TYPE_WIFI", "I", AccessFlags = 25)]
				public const int TYPE_WIFI = 1;
				/// <java-name>
				/// TYPE_MOBILE_MMS
				/// </java-name>
				[Dot42.DexImport("TYPE_MOBILE_MMS", "I", AccessFlags = 25)]
				public const int TYPE_MOBILE_MMS = 2;
				/// <java-name>
				/// TYPE_MOBILE_SUPL
				/// </java-name>
				[Dot42.DexImport("TYPE_MOBILE_SUPL", "I", AccessFlags = 25)]
				public const int TYPE_MOBILE_SUPL = 3;
				/// <java-name>
				/// TYPE_MOBILE_DUN
				/// </java-name>
				[Dot42.DexImport("TYPE_MOBILE_DUN", "I", AccessFlags = 25)]
				public const int TYPE_MOBILE_DUN = 4;
				/// <java-name>
				/// TYPE_MOBILE_HIPRI
				/// </java-name>
				[Dot42.DexImport("TYPE_MOBILE_HIPRI", "I", AccessFlags = 25)]
				public const int TYPE_MOBILE_HIPRI = 5;
				/// <java-name>
				/// TYPE_WIMAX
				/// </java-name>
				[Dot42.DexImport("TYPE_WIMAX", "I", AccessFlags = 25)]
				public const int TYPE_WIMAX = 6;
				/// <java-name>
				/// TYPE_BLUETOOTH
				/// </java-name>
				[Dot42.DexImport("TYPE_BLUETOOTH", "I", AccessFlags = 25)]
				public const int TYPE_BLUETOOTH = 7;
				/// <java-name>
				/// TYPE_DUMMY
				/// </java-name>
				[Dot42.DexImport("TYPE_DUMMY", "I", AccessFlags = 25)]
				public const int TYPE_DUMMY = 8;
				/// <java-name>
				/// TYPE_ETHERNET
				/// </java-name>
				[Dot42.DexImport("TYPE_ETHERNET", "I", AccessFlags = 25)]
				public const int TYPE_ETHERNET = 9;
				/// <java-name>
				/// DEFAULT_NETWORK_PREFERENCE
				/// </java-name>
				[Dot42.DexImport("DEFAULT_NETWORK_PREFERENCE", "I", AccessFlags = 25)]
				public const int DEFAULT_NETWORK_PREFERENCE = 1;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal ConnectivityManager() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isNetworkTypeValid
				/// </java-name>
				[Dot42.DexImport("isNetworkTypeValid", "(I)Z", AccessFlags = 9)]
				public static bool IsNetworkTypeValid(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getNetworkInfo
				/// </java-name>
				[Dot42.DexImport("getNetworkInfo", "(I)Landroid/net/NetworkInfo;", AccessFlags = 1)]
				public virtual global::Android.Net.NetworkInfo GetNetworkInfo(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Net.NetworkInfo);
				}

				/// <java-name>
				/// startUsingNetworkFeature
				/// </java-name>
				[Dot42.DexImport("startUsingNetworkFeature", "(ILjava/lang/String;)I", AccessFlags = 1)]
				public virtual int StartUsingNetworkFeature(int int32, string @string) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// stopUsingNetworkFeature
				/// </java-name>
				[Dot42.DexImport("stopUsingNetworkFeature", "(ILjava/lang/String;)I", AccessFlags = 1)]
				public virtual int StopUsingNetworkFeature(int int32, string @string) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// requestRouteToHost
				/// </java-name>
				[Dot42.DexImport("requestRouteToHost", "(II)Z", AccessFlags = 1)]
				public virtual bool RequestRouteToHost(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getNetworkPreference
				/// </java-name>
				public virtual int NetworkPreference
				{
						[Dot42.DexImport("getNetworkPreference", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setNetworkPreference", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getActiveNetworkInfo
				/// </java-name>
				public virtual global::Android.Net.NetworkInfo ActiveNetworkInfo
				{
						[Dot42.DexImport("getActiveNetworkInfo", "()Landroid/net/NetworkInfo;", AccessFlags = 1)]
						get{ return default(global::Android.Net.NetworkInfo); }
				}

				/// <java-name>
				/// getAllNetworkInfo
				/// </java-name>
				public virtual global::Android.Net.NetworkInfo[] AllNetworkInfo
				{
						[Dot42.DexImport("getAllNetworkInfo", "()[Landroid/net/NetworkInfo;", AccessFlags = 1)]
						get{ return default(global::Android.Net.NetworkInfo[]); }
				}

				/// <java-name>
				/// getBackgroundDataSetting
				/// </java-name>
				public virtual bool IsBackgroundDataSetting
				{
						[Dot42.DexImport("getBackgroundDataSetting", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

		}

		/// <java-name>
		/// android/net/Credentials
		/// </java-name>
		[Dot42.DexImport("android/net/Credentials", AccessFlags = 33)]
		public partial class Credentials
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(III)V", AccessFlags = 1)]
				public Credentials(int int32, int int321, int int322) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal Credentials() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getPid
				/// </java-name>
				public virtual int Pid
				{
						[Dot42.DexImport("getPid", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getUid
				/// </java-name>
				public virtual int Uid
				{
						[Dot42.DexImport("getUid", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getGid
				/// </java-name>
				public virtual int Gid
				{
						[Dot42.DexImport("getGid", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

		}

		/// <java-name>
		/// android/net/DhcpInfo
		/// </java-name>
		[Dot42.DexImport("android/net/DhcpInfo", AccessFlags = 33)]
		public partial class DhcpInfo : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// ipAddress
				/// </java-name>
				[Dot42.DexImport("ipAddress", "I", AccessFlags = 1)]
				public int IpAddress;
				/// <java-name>
				/// gateway
				/// </java-name>
				[Dot42.DexImport("gateway", "I", AccessFlags = 1)]
				public int Gateway;
				/// <java-name>
				/// netmask
				/// </java-name>
				[Dot42.DexImport("netmask", "I", AccessFlags = 1)]
				public int Netmask;
				/// <java-name>
				/// dns1
				/// </java-name>
				[Dot42.DexImport("dns1", "I", AccessFlags = 1)]
				public int Dns1;
				/// <java-name>
				/// dns2
				/// </java-name>
				[Dot42.DexImport("dns2", "I", AccessFlags = 1)]
				public int Dns2;
				/// <java-name>
				/// serverAddress
				/// </java-name>
				[Dot42.DexImport("serverAddress", "I", AccessFlags = 1)]
				public int ServerAddress;
				/// <java-name>
				/// leaseDuration
				/// </java-name>
				[Dot42.DexImport("leaseDuration", "I", AccessFlags = 1)]
				public int LeaseDuration;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public DhcpInfo() /* MethodBuilder.Create */ 
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

				/// <java-name>
				/// describeContents
				/// </java-name>
				[Dot42.DexImport("describeContents", "()I", AccessFlags = 1)]
				public virtual int DescribeContents() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public virtual void WriteToParcel(global::Android.OS.Parcel parcel, int int32) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// android/net/LocalServerSocket
		/// </java-name>
		[Dot42.DexImport("android/net/LocalServerSocket", AccessFlags = 33)]
		public partial class LocalServerSocket
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public LocalServerSocket(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/io/FileDescriptor;)V", AccessFlags = 1)]
				public LocalServerSocket(global::Java.IO.FileDescriptor fileDescriptor) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// accept
				/// </java-name>
				[Dot42.DexImport("accept", "()Landroid/net/LocalSocket;", AccessFlags = 1)]
				public virtual global::Android.Net.LocalSocket Accept() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Net.LocalSocket);
				}

				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1)]
				public virtual void Close() /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal LocalServerSocket() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getLocalSocketAddress
				/// </java-name>
				public virtual global::Android.Net.LocalSocketAddress LocalSocketAddress
				{
						[Dot42.DexImport("getLocalSocketAddress", "()Landroid/net/LocalSocketAddress;", AccessFlags = 1)]
						get{ return default(global::Android.Net.LocalSocketAddress); }
				}

				/// <java-name>
				/// getFileDescriptor
				/// </java-name>
				public virtual global::Java.IO.FileDescriptor FileDescriptor
				{
						[Dot42.DexImport("getFileDescriptor", "()Ljava/io/FileDescriptor;", AccessFlags = 1)]
						get{ return default(global::Java.IO.FileDescriptor); }
				}

		}

		/// <java-name>
		/// android/net/LocalSocket
		/// </java-name>
		[Dot42.DexImport("android/net/LocalSocket", AccessFlags = 33)]
		public partial class LocalSocket
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public LocalSocket() /* MethodBuilder.Create */ 
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

				/// <java-name>
				/// connect
				/// </java-name>
				[Dot42.DexImport("connect", "(Landroid/net/LocalSocketAddress;)V", AccessFlags = 1)]
				public virtual void Connect(global::Android.Net.LocalSocketAddress localSocketAddress) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// bind
				/// </java-name>
				[Dot42.DexImport("bind", "(Landroid/net/LocalSocketAddress;)V", AccessFlags = 1)]
				public virtual void Bind(global::Android.Net.LocalSocketAddress localSocketAddress) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1)]
				public virtual void Close() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// shutdownInput
				/// </java-name>
				[Dot42.DexImport("shutdownInput", "()V", AccessFlags = 1)]
				public virtual void ShutdownInput() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// shutdownOutput
				/// </java-name>
				[Dot42.DexImport("shutdownOutput", "()V", AccessFlags = 1)]
				public virtual void ShutdownOutput() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// connect
				/// </java-name>
				[Dot42.DexImport("connect", "(Landroid/net/LocalSocketAddress;I)V", AccessFlags = 1)]
				public virtual void Connect(global::Android.Net.LocalSocketAddress localSocketAddress, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setFileDescriptorsForSend
				/// </java-name>
				[Dot42.DexImport("setFileDescriptorsForSend", "([Ljava/io/FileDescriptor;)V", AccessFlags = 1)]
				public virtual void SetFileDescriptorsForSend(global::Java.IO.FileDescriptor[] fileDescriptor) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getLocalSocketAddress
				/// </java-name>
				public virtual global::Android.Net.LocalSocketAddress LocalSocketAddress
				{
						[Dot42.DexImport("getLocalSocketAddress", "()Landroid/net/LocalSocketAddress;", AccessFlags = 1)]
						get{ return default(global::Android.Net.LocalSocketAddress); }
				}

				/// <java-name>
				/// getInputStream
				/// </java-name>
				public virtual global::Java.IO.InputStream InputStream
				{
						[Dot42.DexImport("getInputStream", "()Ljava/io/InputStream;", AccessFlags = 1)]
						get{ return default(global::Java.IO.InputStream); }
				}

				/// <java-name>
				/// getOutputStream
				/// </java-name>
				public virtual global::Java.IO.OutputStream OutputStream
				{
						[Dot42.DexImport("getOutputStream", "()Ljava/io/OutputStream;", AccessFlags = 1)]
						get{ return default(global::Java.IO.OutputStream); }
				}

				/// <java-name>
				/// getReceiveBufferSize
				/// </java-name>
				public virtual int ReceiveBufferSize
				{
						[Dot42.DexImport("getReceiveBufferSize", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setReceiveBufferSize", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getSoTimeout
				/// </java-name>
				public virtual int SoTimeout
				{
						[Dot42.DexImport("getSoTimeout", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setSoTimeout", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getSendBufferSize
				/// </java-name>
				public virtual int SendBufferSize
				{
						[Dot42.DexImport("getSendBufferSize", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setSendBufferSize", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getRemoteSocketAddress
				/// </java-name>
				public virtual global::Android.Net.LocalSocketAddress RemoteSocketAddress
				{
						[Dot42.DexImport("getRemoteSocketAddress", "()Landroid/net/LocalSocketAddress;", AccessFlags = 1)]
						get{ return default(global::Android.Net.LocalSocketAddress); }
				}

				/// <java-name>
				/// isConnected
				/// </java-name>
				public virtual bool IsConnected
				{
						[Dot42.DexImport("isConnected", "()Z", AccessFlags = 33)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// isClosed
				/// </java-name>
				public virtual bool IsClosed
				{
						[Dot42.DexImport("isClosed", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// isBound
				/// </java-name>
				public virtual bool IsBound
				{
						[Dot42.DexImport("isBound", "()Z", AccessFlags = 33)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// isOutputShutdown
				/// </java-name>
				public virtual bool IsOutputShutdown
				{
						[Dot42.DexImport("isOutputShutdown", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// isInputShutdown
				/// </java-name>
				public virtual bool IsInputShutdown
				{
						[Dot42.DexImport("isInputShutdown", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// getAncillaryFileDescriptors
				/// </java-name>
				public virtual global::Java.IO.FileDescriptor[] AncillaryFileDescriptors
				{
						[Dot42.DexImport("getAncillaryFileDescriptors", "()[Ljava/io/FileDescriptor;", AccessFlags = 1)]
						get{ return default(global::Java.IO.FileDescriptor[]); }
				}

				/// <java-name>
				/// getPeerCredentials
				/// </java-name>
				public virtual global::Android.Net.Credentials PeerCredentials
				{
						[Dot42.DexImport("getPeerCredentials", "()Landroid/net/Credentials;", AccessFlags = 1)]
						get{ return default(global::Android.Net.Credentials); }
				}

				/// <java-name>
				/// getFileDescriptor
				/// </java-name>
				public virtual global::Java.IO.FileDescriptor FileDescriptor
				{
						[Dot42.DexImport("getFileDescriptor", "()Ljava/io/FileDescriptor;", AccessFlags = 1)]
						get{ return default(global::Java.IO.FileDescriptor); }
				}

		}

		/// <java-name>
		/// android/net/LocalSocketAddress
		/// </java-name>
		[Dot42.DexImport("android/net/LocalSocketAddress", AccessFlags = 33)]
		public partial class LocalSocketAddress
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Landroid/net/LocalSocketAddress$Namespace;)V", AccessFlags = 1)]
				public LocalSocketAddress(string @string, global::Android.Net.LocalSocketAddress.Namespace @namespace) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public LocalSocketAddress(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getNamespace
				/// </java-name>
				[Dot42.DexImport("getNamespace", "()Landroid/net/LocalSocketAddress$Namespace;", AccessFlags = 1)]
				public virtual global::Android.Net.LocalSocketAddress.Namespace GetNamespace() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Net.LocalSocketAddress.Namespace);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal LocalSocketAddress() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getName
				/// </java-name>
				public virtual string Name
				{
						[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// android/net/LocalSocketAddress$Namespace
				/// </java-name>
				[Dot42.DexImport("android/net/LocalSocketAddress$Namespace", AccessFlags = 16409, Signature = "Ljava/lang/Enum<Landroid/net/LocalSocketAddress$Namespace;>;")]
				public sealed class Namespace
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// ABSTRACT
						/// </java-name>
						[Dot42.DexImport("ABSTRACT", "Landroid/net/LocalSocketAddress$Namespace;", AccessFlags = 16409)]
						public static readonly Namespace ABSTRACT;
						/// <java-name>
						/// FILESYSTEM
						/// </java-name>
						[Dot42.DexImport("FILESYSTEM", "Landroid/net/LocalSocketAddress$Namespace;", AccessFlags = 16409)]
						public static readonly Namespace FILESYSTEM;
						/// <java-name>
						/// RESERVED
						/// </java-name>
						[Dot42.DexImport("RESERVED", "Landroid/net/LocalSocketAddress$Namespace;", AccessFlags = 16409)]
						public static readonly Namespace RESERVED;
						private Namespace() /* TypeBuilder.AddPrivateDefaultCtor */ 
						{
						}

						/// <java-name>
						/// values
						/// </java-name>
						[Dot42.DexImport("values", "()[Landroid/net/LocalSocketAddress$Namespace;", AccessFlags = 9)]
						public static Namespace[] Values() /* MethodBuilder.Create */ 
						{
								return default(Namespace[]);
						}

						/// <java-name>
						/// valueOf
						/// </java-name>
						[Dot42.DexImport("valueOf", "(Ljava/lang/String;)Landroid/net/LocalSocketAddress$Namespace;", AccessFlags = 9)]
						public static Namespace ValueOf(string @string) /* MethodBuilder.Create */ 
						{
								return default(Namespace);
						}

				}

		}

		/// <java-name>
		/// android/net/MailTo
		/// </java-name>
		[Dot42.DexImport("android/net/MailTo", AccessFlags = 33)]
		public partial class MailTo
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// MAILTO_SCHEME
				/// </java-name>
				[Dot42.DexImport("MAILTO_SCHEME", "Ljava/lang/String;", AccessFlags = 25)]
				public const string MAILTO_SCHEME = "mailto:";
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal MailTo() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isMailTo
				/// </java-name>
				[Dot42.DexImport("isMailTo", "(Ljava/lang/String;)Z", AccessFlags = 9)]
				public static bool IsMailTo(string @string) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// parse
				/// </java-name>
				[Dot42.DexImport("parse", "(Ljava/lang/String;)Landroid/net/MailTo;", AccessFlags = 9)]
				public static global::Android.Net.MailTo Parse(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Net.MailTo);
				}

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getTo
				/// </java-name>
				public virtual string To
				{
						[Dot42.DexImport("getTo", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getCc
				/// </java-name>
				public virtual string Cc
				{
						[Dot42.DexImport("getCc", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getSubject
				/// </java-name>
				public virtual string Subject
				{
						[Dot42.DexImport("getSubject", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getBody
				/// </java-name>
				public virtual string Body
				{
						[Dot42.DexImport("getBody", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getHeaders
				/// </java-name>
				public virtual global::Java.Util.IMap<string, string> Headers
				{
						[Dot42.DexImport("getHeaders", "()Ljava/util/Map;", AccessFlags = 1, Signature = "()Ljava/util/Map<Ljava/lang/String;Ljava/lang/String;>;")]
						get{ return default(global::Java.Util.IMap<string, string>); }
				}

		}

		/// <java-name>
		/// android/net/NetworkInfo
		/// </java-name>
		[Dot42.DexImport("android/net/NetworkInfo", AccessFlags = 33)]
		public partial class NetworkInfo : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal NetworkInfo() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getState
				/// </java-name>
				[Dot42.DexImport("getState", "()Landroid/net/NetworkInfo$State;", AccessFlags = 1)]
				public virtual global::Android.Net.NetworkInfo.State GetState() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Net.NetworkInfo.State);
				}

				/// <java-name>
				/// getDetailedState
				/// </java-name>
				[Dot42.DexImport("getDetailedState", "()Landroid/net/NetworkInfo$DetailedState;", AccessFlags = 1)]
				public virtual global::Android.Net.NetworkInfo.DetailedState GetDetailedState() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Net.NetworkInfo.DetailedState);
				}

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
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
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public virtual void WriteToParcel(global::Android.OS.Parcel parcel, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getType
				/// </java-name>
				public virtual int Type
				{
						[Dot42.DexImport("getType", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getSubtype
				/// </java-name>
				public virtual int Subtype
				{
						[Dot42.DexImport("getSubtype", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getTypeName
				/// </java-name>
				public virtual string TypeName
				{
						[Dot42.DexImport("getTypeName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getSubtypeName
				/// </java-name>
				public virtual string SubtypeName
				{
						[Dot42.DexImport("getSubtypeName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// isConnectedOrConnecting
				/// </java-name>
				public virtual bool IsConnectedOrConnecting
				{
						[Dot42.DexImport("isConnectedOrConnecting", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// isConnected
				/// </java-name>
				public virtual bool IsConnected
				{
						[Dot42.DexImport("isConnected", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// isAvailable
				/// </java-name>
				public virtual bool IsAvailable
				{
						[Dot42.DexImport("isAvailable", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// isFailover
				/// </java-name>
				public virtual bool IsFailover
				{
						[Dot42.DexImport("isFailover", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// isRoaming
				/// </java-name>
				public virtual bool IsRoaming
				{
						[Dot42.DexImport("isRoaming", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// getReason
				/// </java-name>
				public virtual string Reason
				{
						[Dot42.DexImport("getReason", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getExtraInfo
				/// </java-name>
				public virtual string ExtraInfo
				{
						[Dot42.DexImport("getExtraInfo", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// android/net/NetworkInfo$DetailedState
				/// </java-name>
				[Dot42.DexImport("android/net/NetworkInfo$DetailedState", AccessFlags = 16409, Signature = "Ljava/lang/Enum<Landroid/net/NetworkInfo$DetailedState;>;")]
				public sealed class DetailedState
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// AUTHENTICATING
						/// </java-name>
						[Dot42.DexImport("AUTHENTICATING", "Landroid/net/NetworkInfo$DetailedState;", AccessFlags = 16409)]
						public static readonly DetailedState AUTHENTICATING;
						/// <java-name>
						/// BLOCKED
						/// </java-name>
						[Dot42.DexImport("BLOCKED", "Landroid/net/NetworkInfo$DetailedState;", AccessFlags = 16409)]
						public static readonly DetailedState BLOCKED;
						/// <java-name>
						/// CONNECTED
						/// </java-name>
						[Dot42.DexImport("CONNECTED", "Landroid/net/NetworkInfo$DetailedState;", AccessFlags = 16409)]
						public static readonly DetailedState CONNECTED;
						/// <java-name>
						/// CONNECTING
						/// </java-name>
						[Dot42.DexImport("CONNECTING", "Landroid/net/NetworkInfo$DetailedState;", AccessFlags = 16409)]
						public static readonly DetailedState CONNECTING;
						/// <java-name>
						/// DISCONNECTED
						/// </java-name>
						[Dot42.DexImport("DISCONNECTED", "Landroid/net/NetworkInfo$DetailedState;", AccessFlags = 16409)]
						public static readonly DetailedState DISCONNECTED;
						/// <java-name>
						/// DISCONNECTING
						/// </java-name>
						[Dot42.DexImport("DISCONNECTING", "Landroid/net/NetworkInfo$DetailedState;", AccessFlags = 16409)]
						public static readonly DetailedState DISCONNECTING;
						/// <java-name>
						/// FAILED
						/// </java-name>
						[Dot42.DexImport("FAILED", "Landroid/net/NetworkInfo$DetailedState;", AccessFlags = 16409)]
						public static readonly DetailedState FAILED;
						/// <java-name>
						/// IDLE
						/// </java-name>
						[Dot42.DexImport("IDLE", "Landroid/net/NetworkInfo$DetailedState;", AccessFlags = 16409)]
						public static readonly DetailedState IDLE;
						/// <java-name>
						/// OBTAINING_IPADDR
						/// </java-name>
						[Dot42.DexImport("OBTAINING_IPADDR", "Landroid/net/NetworkInfo$DetailedState;", AccessFlags = 16409)]
						public static readonly DetailedState OBTAINING_IPADDR;
						/// <java-name>
						/// SCANNING
						/// </java-name>
						[Dot42.DexImport("SCANNING", "Landroid/net/NetworkInfo$DetailedState;", AccessFlags = 16409)]
						public static readonly DetailedState SCANNING;
						/// <java-name>
						/// SUSPENDED
						/// </java-name>
						[Dot42.DexImport("SUSPENDED", "Landroid/net/NetworkInfo$DetailedState;", AccessFlags = 16409)]
						public static readonly DetailedState SUSPENDED;
						private DetailedState() /* TypeBuilder.AddPrivateDefaultCtor */ 
						{
						}

						/// <java-name>
						/// values
						/// </java-name>
						[Dot42.DexImport("values", "()[Landroid/net/NetworkInfo$DetailedState;", AccessFlags = 9)]
						public static DetailedState[] Values() /* MethodBuilder.Create */ 
						{
								return default(DetailedState[]);
						}

						/// <java-name>
						/// valueOf
						/// </java-name>
						[Dot42.DexImport("valueOf", "(Ljava/lang/String;)Landroid/net/NetworkInfo$DetailedState;", AccessFlags = 9)]
						public static DetailedState ValueOf(string @string) /* MethodBuilder.Create */ 
						{
								return default(DetailedState);
						}

				}

				/// <java-name>
				/// android/net/NetworkInfo$State
				/// </java-name>
				[Dot42.DexImport("android/net/NetworkInfo$State", AccessFlags = 16409, Signature = "Ljava/lang/Enum<Landroid/net/NetworkInfo$State;>;")]
				public sealed class State
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// CONNECTED
						/// </java-name>
						[Dot42.DexImport("CONNECTED", "Landroid/net/NetworkInfo$State;", AccessFlags = 16409)]
						public static readonly State CONNECTED;
						/// <java-name>
						/// CONNECTING
						/// </java-name>
						[Dot42.DexImport("CONNECTING", "Landroid/net/NetworkInfo$State;", AccessFlags = 16409)]
						public static readonly State CONNECTING;
						/// <java-name>
						/// DISCONNECTED
						/// </java-name>
						[Dot42.DexImport("DISCONNECTED", "Landroid/net/NetworkInfo$State;", AccessFlags = 16409)]
						public static readonly State DISCONNECTED;
						/// <java-name>
						/// DISCONNECTING
						/// </java-name>
						[Dot42.DexImport("DISCONNECTING", "Landroid/net/NetworkInfo$State;", AccessFlags = 16409)]
						public static readonly State DISCONNECTING;
						/// <java-name>
						/// SUSPENDED
						/// </java-name>
						[Dot42.DexImport("SUSPENDED", "Landroid/net/NetworkInfo$State;", AccessFlags = 16409)]
						public static readonly State SUSPENDED;
						/// <java-name>
						/// UNKNOWN
						/// </java-name>
						[Dot42.DexImport("UNKNOWN", "Landroid/net/NetworkInfo$State;", AccessFlags = 16409)]
						public static readonly State UNKNOWN;
						private State() /* TypeBuilder.AddPrivateDefaultCtor */ 
						{
						}

						/// <java-name>
						/// values
						/// </java-name>
						[Dot42.DexImport("values", "()[Landroid/net/NetworkInfo$State;", AccessFlags = 9)]
						public static State[] Values() /* MethodBuilder.Create */ 
						{
								return default(State[]);
						}

						/// <java-name>
						/// valueOf
						/// </java-name>
						[Dot42.DexImport("valueOf", "(Ljava/lang/String;)Landroid/net/NetworkInfo$State;", AccessFlags = 9)]
						public static State ValueOf(string @string) /* MethodBuilder.Create */ 
						{
								return default(State);
						}

				}

		}

		/// <java-name>
		/// android/net/ParseException
		/// </java-name>
		[Dot42.DexImport("android/net/ParseException", AccessFlags = 33)]
		public partial class ParseException : global::System.SystemException
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// response
				/// </java-name>
				[Dot42.DexImport("response", "Ljava/lang/String;", AccessFlags = 1)]
				public string Response;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal ParseException() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// android/net/Proxy
		/// </java-name>
		[Dot42.DexImport("android/net/Proxy", AccessFlags = 49)]
		public sealed partial class Proxy
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// PROXY_CHANGE_ACTION
				/// </java-name>
				[Dot42.DexImport("PROXY_CHANGE_ACTION", "Ljava/lang/String;", AccessFlags = 25)]
				public const string PROXY_CHANGE_ACTION = "android.intent.action.PROXY_CHANGE";
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Proxy() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getHost
				/// </java-name>
				[Dot42.DexImport("getHost", "(Landroid/content/Context;)Ljava/lang/String;", AccessFlags = 25)]
				public static string GetHost(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getPort
				/// </java-name>
				[Dot42.DexImport("getPort", "(Landroid/content/Context;)I", AccessFlags = 25)]
				public static int GetPort(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getDefaultHost
				/// </java-name>
				public static string DefaultHost
				{
						[Dot42.DexImport("getDefaultHost", "()Ljava/lang/String;", AccessFlags = 25)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getDefaultPort
				/// </java-name>
				public static int DefaultPort
				{
						[Dot42.DexImport("getDefaultPort", "()I", AccessFlags = 25)]
						get{ return default(int); }
				}

		}

		/// <java-name>
		/// android/net/SSLCertificateSocketFactory
		/// </java-name>
		[Dot42.DexImport("android/net/SSLCertificateSocketFactory", AccessFlags = 33)]
		public partial class SSLCertificateSocketFactory : global::Javax.Net.Ssl.SSLSocketFactory
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public SSLCertificateSocketFactory(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getDefault
				/// </java-name>
				[Dot42.DexImport("getDefault", "(I)Ljavax/net/SocketFactory;", AccessFlags = 9)]
				public static global::Javax.Net.SocketFactory GetDefault(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Net.SocketFactory);
				}

				/// <java-name>
				/// getDefault
				/// </java-name>
				[Dot42.DexImport("getDefault", "(ILandroid/net/SSLSessionCache;)Ljavax/net/ssl/SSLSocketFactory;", AccessFlags = 9)]
				public static global::Javax.Net.Ssl.SSLSocketFactory GetDefault(int int32, global::Android.Net.SSLSessionCache sSLSessionCache) /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Net.Ssl.SSLSocketFactory);
				}

				/// <java-name>
				/// getInsecure
				/// </java-name>
				[Dot42.DexImport("getInsecure", "(ILandroid/net/SSLSessionCache;)Ljavax/net/ssl/SSLSocketFactory;", AccessFlags = 9)]
				public static global::Javax.Net.Ssl.SSLSocketFactory GetInsecure(int int32, global::Android.Net.SSLSessionCache sSLSessionCache) /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Net.Ssl.SSLSocketFactory);
				}

				/// <java-name>
				/// getHttpSocketFactory
				/// </java-name>
				[Dot42.DexImport("getHttpSocketFactory", "(ILandroid/net/SSLSessionCache;)Lorg/apache/http/conn/ssl/SSLSocketFactory;", AccessFlags = 9)]
				public static global::Org.Apache.Http.Conn.Ssl.SSLSocketFactory GetHttpSocketFactory(int int32, global::Android.Net.SSLSessionCache sSLSessionCache) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Conn.Ssl.SSLSocketFactory);
				}

				/// <java-name>
				/// setTrustManagers
				/// </java-name>
				[Dot42.DexImport("setTrustManagers", "([Ljavax/net/ssl/TrustManager;)V", AccessFlags = 1)]
				public virtual void SetTrustManagers(global::Javax.Net.Ssl.ITrustManager[] trustManager) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setKeyManagers
				/// </java-name>
				[Dot42.DexImport("setKeyManagers", "([Ljavax/net/ssl/KeyManager;)V", AccessFlags = 1)]
				public virtual void SetKeyManagers(global::Javax.Net.Ssl.IKeyManager[] keyManager) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// createSocket
				/// </java-name>
				[Dot42.DexImport("createSocket", "(Ljava/net/Socket;Ljava/lang/String;IZ)Ljava/net/Socket;", AccessFlags = 1)]
				public override global::Java.Net.Socket CreateSocket(global::Java.Net.Socket socket, string @string, int int32, bool boolean) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.Socket);
				}

				/// <java-name>
				/// createSocket
				/// </java-name>
				[Dot42.DexImport("createSocket", "()Ljava/net/Socket;", AccessFlags = 1)]
				public override global::Java.Net.Socket CreateSocket() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.Socket);
				}

				/// <java-name>
				/// createSocket
				/// </java-name>
				[Dot42.DexImport("createSocket", "(Ljava/net/InetAddress;ILjava/net/InetAddress;I)Ljava/net/Socket;", AccessFlags = 1)]
				public override global::Java.Net.Socket CreateSocket(global::Java.Net.InetAddress inetAddress, int int32, global::Java.Net.InetAddress inetAddress1, int int321) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.Socket);
				}

				/// <java-name>
				/// createSocket
				/// </java-name>
				[Dot42.DexImport("createSocket", "(Ljava/net/InetAddress;I)Ljava/net/Socket;", AccessFlags = 1)]
				public override global::Java.Net.Socket CreateSocket(global::Java.Net.InetAddress inetAddress, int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.Socket);
				}

				/// <java-name>
				/// createSocket
				/// </java-name>
				[Dot42.DexImport("createSocket", "(Ljava/lang/String;ILjava/net/InetAddress;I)Ljava/net/Socket;", AccessFlags = 1)]
				public override global::Java.Net.Socket CreateSocket(string @string, int int32, global::Java.Net.InetAddress inetAddress, int int321) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.Socket);
				}

				/// <java-name>
				/// createSocket
				/// </java-name>
				[Dot42.DexImport("createSocket", "(Ljava/lang/String;I)Ljava/net/Socket;", AccessFlags = 1)]
				public override global::Java.Net.Socket CreateSocket(string @string, int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.Socket);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal SSLCertificateSocketFactory() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getDefaultCipherSuites
				/// </java-name>
				public override string[] DefaultCipherSuites
				{
						[Dot42.DexImport("getDefaultCipherSuites", "()[Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string[]); }
				}

				/// <java-name>
				/// getSupportedCipherSuites
				/// </java-name>
				public override string[] SupportedCipherSuites
				{
						[Dot42.DexImport("getSupportedCipherSuites", "()[Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string[]); }
				}

		}

		/// <java-name>
		/// android/net/SSLSessionCache
		/// </java-name>
		[Dot42.DexImport("android/net/SSLSessionCache", AccessFlags = 49)]
		public sealed partial class SSLSessionCache
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/io/File;)V", AccessFlags = 1)]
				public SSLSessionCache(global::Java.IO.File file) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public SSLSessionCache(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal SSLSessionCache() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// android/net/TrafficStats
		/// </java-name>
		[Dot42.DexImport("android/net/TrafficStats", AccessFlags = 33)]
		public partial class TrafficStats
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// UNSUPPORTED
				/// </java-name>
				[Dot42.DexImport("UNSUPPORTED", "I", AccessFlags = 25)]
				public const int UNSUPPORTED = -1;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public TrafficStats() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// clearThreadStatsTag
				/// </java-name>
				[Dot42.DexImport("clearThreadStatsTag", "()V", AccessFlags = 9)]
				public static void ClearThreadStatsTag() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// tagSocket
				/// </java-name>
				[Dot42.DexImport("tagSocket", "(Ljava/net/Socket;)V", AccessFlags = 9)]
				public static void TagSocket(global::Java.Net.Socket socket) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// untagSocket
				/// </java-name>
				[Dot42.DexImport("untagSocket", "(Ljava/net/Socket;)V", AccessFlags = 9)]
				public static void UntagSocket(global::Java.Net.Socket socket) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// incrementOperationCount
				/// </java-name>
				[Dot42.DexImport("incrementOperationCount", "(I)V", AccessFlags = 9)]
				public static void IncrementOperationCount(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// incrementOperationCount
				/// </java-name>
				[Dot42.DexImport("incrementOperationCount", "(II)V", AccessFlags = 9)]
				public static void IncrementOperationCount(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getUidTxBytes
				/// </java-name>
				[Dot42.DexImport("getUidTxBytes", "(I)J", AccessFlags = 265)]
				public static long GetUidTxBytes(int int32) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// getUidRxBytes
				/// </java-name>
				[Dot42.DexImport("getUidRxBytes", "(I)J", AccessFlags = 265)]
				public static long GetUidRxBytes(int int32) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// getUidTxPackets
				/// </java-name>
				[Dot42.DexImport("getUidTxPackets", "(I)J", AccessFlags = 265)]
				public static long GetUidTxPackets(int int32) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// getUidRxPackets
				/// </java-name>
				[Dot42.DexImport("getUidRxPackets", "(I)J", AccessFlags = 265)]
				public static long GetUidRxPackets(int int32) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// getUidTcpTxBytes
				/// </java-name>
				[Dot42.DexImport("getUidTcpTxBytes", "(I)J", AccessFlags = 265)]
				public static long GetUidTcpTxBytes(int int32) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// getUidTcpRxBytes
				/// </java-name>
				[Dot42.DexImport("getUidTcpRxBytes", "(I)J", AccessFlags = 265)]
				public static long GetUidTcpRxBytes(int int32) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// getUidUdpTxBytes
				/// </java-name>
				[Dot42.DexImport("getUidUdpTxBytes", "(I)J", AccessFlags = 265)]
				public static long GetUidUdpTxBytes(int int32) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// getUidUdpRxBytes
				/// </java-name>
				[Dot42.DexImport("getUidUdpRxBytes", "(I)J", AccessFlags = 265)]
				public static long GetUidUdpRxBytes(int int32) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// getUidTcpTxSegments
				/// </java-name>
				[Dot42.DexImport("getUidTcpTxSegments", "(I)J", AccessFlags = 265)]
				public static long GetUidTcpTxSegments(int int32) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// getUidTcpRxSegments
				/// </java-name>
				[Dot42.DexImport("getUidTcpRxSegments", "(I)J", AccessFlags = 265)]
				public static long GetUidTcpRxSegments(int int32) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// getUidUdpTxPackets
				/// </java-name>
				[Dot42.DexImport("getUidUdpTxPackets", "(I)J", AccessFlags = 265)]
				public static long GetUidUdpTxPackets(int int32) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// getUidUdpRxPackets
				/// </java-name>
				[Dot42.DexImport("getUidUdpRxPackets", "(I)J", AccessFlags = 265)]
				public static long GetUidUdpRxPackets(int int32) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// getThreadStatsTag
				/// </java-name>
				public static int ThreadStatsTag
				{
						[Dot42.DexImport("getThreadStatsTag", "()I", AccessFlags = 9)]
						get{ return default(int); }
						[Dot42.DexImport("setThreadStatsTag", "(I)V", AccessFlags = 9)]
						set{ }
				}

				/// <java-name>
				/// getMobileTxPackets
				/// </java-name>
				public static long MobileTxPackets
				{
						[Dot42.DexImport("getMobileTxPackets", "()J", AccessFlags = 265)]
						get{ return default(long); }
				}

				/// <java-name>
				/// getMobileRxPackets
				/// </java-name>
				public static long MobileRxPackets
				{
						[Dot42.DexImport("getMobileRxPackets", "()J", AccessFlags = 265)]
						get{ return default(long); }
				}

				/// <java-name>
				/// getMobileTxBytes
				/// </java-name>
				public static long MobileTxBytes
				{
						[Dot42.DexImport("getMobileTxBytes", "()J", AccessFlags = 265)]
						get{ return default(long); }
				}

				/// <java-name>
				/// getMobileRxBytes
				/// </java-name>
				public static long MobileRxBytes
				{
						[Dot42.DexImport("getMobileRxBytes", "()J", AccessFlags = 265)]
						get{ return default(long); }
				}

				/// <java-name>
				/// getTotalTxPackets
				/// </java-name>
				public static long TotalTxPackets
				{
						[Dot42.DexImport("getTotalTxPackets", "()J", AccessFlags = 265)]
						get{ return default(long); }
				}

				/// <java-name>
				/// getTotalRxPackets
				/// </java-name>
				public static long TotalRxPackets
				{
						[Dot42.DexImport("getTotalRxPackets", "()J", AccessFlags = 265)]
						get{ return default(long); }
				}

				/// <java-name>
				/// getTotalTxBytes
				/// </java-name>
				public static long TotalTxBytes
				{
						[Dot42.DexImport("getTotalTxBytes", "()J", AccessFlags = 265)]
						get{ return default(long); }
				}

				/// <java-name>
				/// getTotalRxBytes
				/// </java-name>
				public static long TotalRxBytes
				{
						[Dot42.DexImport("getTotalRxBytes", "()J", AccessFlags = 265)]
						get{ return default(long); }
				}

		}

		/// <java-name>
		/// android/net/Uri
		/// </java-name>
		[Dot42.DexImport("android/net/Uri", AccessFlags = 1057, Signature = "Ljava/lang/Object;Landroid/os/Parcelable;Ljava/lang/Comparable<Landroid/net/Uri;>" +
    ";")]
		public abstract partial class Uri : global::Android.OS.IParcelable, global::System.IComparable<global::Android.Net.Uri>
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// EMPTY
				/// </java-name>
				[Dot42.DexImport("EMPTY", "Landroid/net/Uri;", AccessFlags = 25)]
				public static readonly global::Android.Net.Uri EMPTY;
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.Net.Uri> CREATOR;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal Uri() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 1)]
				public override int GetHashCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// compareTo
				/// </java-name>
				[Dot42.DexImport("compareTo", "(Landroid/net/Uri;)I", AccessFlags = 1)]
				public virtual int CompareTo(global::Android.Net.Uri uri) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1025)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// buildUpon
				/// </java-name>
				[Dot42.DexImport("buildUpon", "()Landroid/net/Uri$Builder;", AccessFlags = 1025)]
				public abstract global::Android.Net.Uri.Builder BuildUpon() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// parse
				/// </java-name>
				[Dot42.DexImport("parse", "(Ljava/lang/String;)Landroid/net/Uri;", AccessFlags = 9)]
				public static global::Android.Net.Uri Parse(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Net.Uri);
				}

				/// <java-name>
				/// fromFile
				/// </java-name>
				[Dot42.DexImport("fromFile", "(Ljava/io/File;)Landroid/net/Uri;", AccessFlags = 9)]
				public static global::Android.Net.Uri FromFile(global::Java.IO.File file) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Net.Uri);
				}

				/// <java-name>
				/// fromParts
				/// </java-name>
				[Dot42.DexImport("fromParts", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Landroid/net/Uri;", AccessFlags = 9)]
				public static global::Android.Net.Uri FromParts(string @string, string string1, string string2) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Net.Uri);
				}

				/// <java-name>
				/// getQueryParameters
				/// </java-name>
				[Dot42.DexImport("getQueryParameters", "(Ljava/lang/String;)Ljava/util/List;", AccessFlags = 1, Signature = "(Ljava/lang/String;)Ljava/util/List<Ljava/lang/String;>;")]
				public virtual global::Java.Util.IList<string> GetQueryParameters(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<string>);
				}

				/// <java-name>
				/// getQueryParameter
				/// </java-name>
				[Dot42.DexImport("getQueryParameter", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetQueryParameter(string @string) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getBooleanQueryParameter
				/// </java-name>
				[Dot42.DexImport("getBooleanQueryParameter", "(Ljava/lang/String;Z)Z", AccessFlags = 1)]
				public virtual bool GetBooleanQueryParameter(string @string, bool boolean) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;Landroid/net/Uri;)V", AccessFlags = 9)]
				public static void WriteToParcel(global::Android.OS.Parcel parcel, global::Android.Net.Uri uri) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// encode
				/// </java-name>
				[Dot42.DexImport("encode", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 9)]
				public static string Encode(string @string) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// encode
				/// </java-name>
				[Dot42.DexImport("encode", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 9)]
				public static string Encode(string @string, string string1) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// decode
				/// </java-name>
				[Dot42.DexImport("decode", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 9)]
				public static string Decode(string @string) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// withAppendedPath
				/// </java-name>
				[Dot42.DexImport("withAppendedPath", "(Landroid/net/Uri;Ljava/lang/String;)Landroid/net/Uri;", AccessFlags = 9)]
				public static global::Android.Net.Uri WithAppendedPath(global::Android.Net.Uri uri, string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Net.Uri);
				}

				[Dot42.DexImport("android/os/Parcelable", "describeContents", "()I", AccessFlags = 1025)]
				public virtual int DescribeContents() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(int);
				}

				[Dot42.DexImport("android/os/Parcelable", "writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1025)]
				public virtual void WriteToParcel(global::Android.OS.Parcel parcel, int int32) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				/// <java-name>
				/// isHierarchical
				/// </java-name>
				public abstract bool IsHierarchical
				{
						[Dot42.DexImport("isHierarchical", "()Z", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// isOpaque
				/// </java-name>
				public virtual bool IsOpaque
				{
						[Dot42.DexImport("isOpaque", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// isRelative
				/// </java-name>
				public abstract bool IsRelative
				{
						[Dot42.DexImport("isRelative", "()Z", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// isAbsolute
				/// </java-name>
				public virtual bool IsAbsolute
				{
						[Dot42.DexImport("isAbsolute", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// getScheme
				/// </java-name>
				public abstract string Scheme
				{
						[Dot42.DexImport("getScheme", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getSchemeSpecificPart
				/// </java-name>
				public abstract string SchemeSpecificPart
				{
						[Dot42.DexImport("getSchemeSpecificPart", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getEncodedSchemeSpecificPart
				/// </java-name>
				public abstract string EncodedSchemeSpecificPart
				{
						[Dot42.DexImport("getEncodedSchemeSpecificPart", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getAuthority
				/// </java-name>
				public abstract string Authority
				{
						[Dot42.DexImport("getAuthority", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getEncodedAuthority
				/// </java-name>
				public abstract string EncodedAuthority
				{
						[Dot42.DexImport("getEncodedAuthority", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getUserInfo
				/// </java-name>
				public abstract string UserInfo
				{
						[Dot42.DexImport("getUserInfo", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getEncodedUserInfo
				/// </java-name>
				public abstract string EncodedUserInfo
				{
						[Dot42.DexImport("getEncodedUserInfo", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getHost
				/// </java-name>
				public abstract string Host
				{
						[Dot42.DexImport("getHost", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getPort
				/// </java-name>
				public abstract int Port
				{
						[Dot42.DexImport("getPort", "()I", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getPath
				/// </java-name>
				public abstract string Path
				{
						[Dot42.DexImport("getPath", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getEncodedPath
				/// </java-name>
				public abstract string EncodedPath
				{
						[Dot42.DexImport("getEncodedPath", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getQuery
				/// </java-name>
				public abstract string Query
				{
						[Dot42.DexImport("getQuery", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getEncodedQuery
				/// </java-name>
				public abstract string EncodedQuery
				{
						[Dot42.DexImport("getEncodedQuery", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getFragment
				/// </java-name>
				public abstract string Fragment
				{
						[Dot42.DexImport("getFragment", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getEncodedFragment
				/// </java-name>
				public abstract string EncodedFragment
				{
						[Dot42.DexImport("getEncodedFragment", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getPathSegments
				/// </java-name>
				public abstract global::Java.Util.IList<string> PathSegments
				{
						[Dot42.DexImport("getPathSegments", "()Ljava/util/List;", AccessFlags = 1025, Signature = "()Ljava/util/List<Ljava/lang/String;>;")]
						get;
				}

				/// <java-name>
				/// getLastPathSegment
				/// </java-name>
				public abstract string LastPathSegment
				{
						[Dot42.DexImport("getLastPathSegment", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getQueryParameterNames
				/// </java-name>
				public virtual global::Java.Util.ISet<string> QueryParameterNames
				{
						[Dot42.DexImport("getQueryParameterNames", "()Ljava/util/Set;", AccessFlags = 1, Signature = "()Ljava/util/Set<Ljava/lang/String;>;")]
						get{ return default(global::Java.Util.ISet<string>); }
				}

				/// <java-name>
				/// android/net/Uri$Builder
				/// </java-name>
				[Dot42.DexImport("android/net/Uri$Builder", AccessFlags = 25)]
				public sealed partial class Builder
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public Builder() /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// scheme
						/// </java-name>
						[Dot42.DexImport("scheme", "(Ljava/lang/String;)Landroid/net/Uri$Builder;", AccessFlags = 1)]
						public Builder Scheme(string @string) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// opaquePart
						/// </java-name>
						[Dot42.DexImport("opaquePart", "(Ljava/lang/String;)Landroid/net/Uri$Builder;", AccessFlags = 1)]
						public Builder OpaquePart(string @string) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// encodedOpaquePart
						/// </java-name>
						[Dot42.DexImport("encodedOpaquePart", "(Ljava/lang/String;)Landroid/net/Uri$Builder;", AccessFlags = 1)]
						public Builder EncodedOpaquePart(string @string) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// authority
						/// </java-name>
						[Dot42.DexImport("authority", "(Ljava/lang/String;)Landroid/net/Uri$Builder;", AccessFlags = 1)]
						public Builder Authority(string @string) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// encodedAuthority
						/// </java-name>
						[Dot42.DexImport("encodedAuthority", "(Ljava/lang/String;)Landroid/net/Uri$Builder;", AccessFlags = 1)]
						public Builder EncodedAuthority(string @string) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// path
						/// </java-name>
						[Dot42.DexImport("path", "(Ljava/lang/String;)Landroid/net/Uri$Builder;", AccessFlags = 1)]
						public Builder Path(string @string) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// encodedPath
						/// </java-name>
						[Dot42.DexImport("encodedPath", "(Ljava/lang/String;)Landroid/net/Uri$Builder;", AccessFlags = 1)]
						public Builder EncodedPath(string @string) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// appendPath
						/// </java-name>
						[Dot42.DexImport("appendPath", "(Ljava/lang/String;)Landroid/net/Uri$Builder;", AccessFlags = 1)]
						public Builder AppendPath(string @string) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// appendEncodedPath
						/// </java-name>
						[Dot42.DexImport("appendEncodedPath", "(Ljava/lang/String;)Landroid/net/Uri$Builder;", AccessFlags = 1)]
						public Builder AppendEncodedPath(string @string) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// query
						/// </java-name>
						[Dot42.DexImport("query", "(Ljava/lang/String;)Landroid/net/Uri$Builder;", AccessFlags = 1)]
						public Builder Query(string @string) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// encodedQuery
						/// </java-name>
						[Dot42.DexImport("encodedQuery", "(Ljava/lang/String;)Landroid/net/Uri$Builder;", AccessFlags = 1)]
						public Builder EncodedQuery(string @string) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// fragment
						/// </java-name>
						[Dot42.DexImport("fragment", "(Ljava/lang/String;)Landroid/net/Uri$Builder;", AccessFlags = 1)]
						public Builder Fragment(string @string) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// encodedFragment
						/// </java-name>
						[Dot42.DexImport("encodedFragment", "(Ljava/lang/String;)Landroid/net/Uri$Builder;", AccessFlags = 1)]
						public Builder EncodedFragment(string @string) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// appendQueryParameter
						/// </java-name>
						[Dot42.DexImport("appendQueryParameter", "(Ljava/lang/String;Ljava/lang/String;)Landroid/net/Uri$Builder;", AccessFlags = 1)]
						public Builder AppendQueryParameter(string @string, string string1) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// clearQuery
						/// </java-name>
						[Dot42.DexImport("clearQuery", "()Landroid/net/Uri$Builder;", AccessFlags = 1)]
						public Builder ClearQuery() /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// build
						/// </java-name>
						[Dot42.DexImport("build", "()Landroid/net/Uri;", AccessFlags = 1)]
						public global::Android.Net.Uri Build() /* MethodBuilder.Create */ 
						{
								return default(global::Android.Net.Uri);
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

		}

		/// <java-name>
		/// android/net/UrlQuerySanitizer
		/// </java-name>
		[Dot42.DexImport("android/net/UrlQuerySanitizer", AccessFlags = 33)]
		public partial class UrlQuerySanitizer
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public UrlQuerySanitizer() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public UrlQuerySanitizer(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// parseUrl
				/// </java-name>
				[Dot42.DexImport("parseUrl", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void ParseUrl(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// parseQuery
				/// </java-name>
				[Dot42.DexImport("parseQuery", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void ParseQuery(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// hasParameter
				/// </java-name>
				[Dot42.DexImport("hasParameter", "(Ljava/lang/String;)Z", AccessFlags = 1)]
				public virtual bool HasParameter(string @string) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getValue
				/// </java-name>
				[Dot42.DexImport("getValue", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetValue(string @string) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// registerParameter
				/// </java-name>
				[Dot42.DexImport("registerParameter", "(Ljava/lang/String;Landroid/net/UrlQuerySanitizer$ValueSanitizer;)V", AccessFlags = 1)]
				public virtual void RegisterParameter(string @string, global::Android.Net.UrlQuerySanitizer.IValueSanitizer valueSanitizer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// registerParameters
				/// </java-name>
				[Dot42.DexImport("registerParameters", "([Ljava/lang/String;Landroid/net/UrlQuerySanitizer$ValueSanitizer;)V", AccessFlags = 1)]
				public virtual void RegisterParameters(string[] @string, global::Android.Net.UrlQuerySanitizer.IValueSanitizer valueSanitizer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// parseEntry
				/// </java-name>
				[Dot42.DexImport("parseEntry", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 4)]
				protected internal virtual void ParseEntry(string @string, string string1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addSanitizedEntry
				/// </java-name>
				[Dot42.DexImport("addSanitizedEntry", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 4)]
				protected internal virtual void AddSanitizedEntry(string @string, string string1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getValueSanitizer
				/// </java-name>
				[Dot42.DexImport("getValueSanitizer", "(Ljava/lang/String;)Landroid/net/UrlQuerySanitizer$ValueSanitizer;", AccessFlags = 1)]
				public virtual global::Android.Net.UrlQuerySanitizer.IValueSanitizer GetValueSanitizer(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Net.UrlQuerySanitizer.IValueSanitizer);
				}

				/// <java-name>
				/// getEffectiveValueSanitizer
				/// </java-name>
				[Dot42.DexImport("getEffectiveValueSanitizer", "(Ljava/lang/String;)Landroid/net/UrlQuerySanitizer$ValueSanitizer;", AccessFlags = 1)]
				public virtual global::Android.Net.UrlQuerySanitizer.IValueSanitizer GetEffectiveValueSanitizer(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Net.UrlQuerySanitizer.IValueSanitizer);
				}

				/// <java-name>
				/// unescape
				/// </java-name>
				[Dot42.DexImport("unescape", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string Unescape(string @string) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// isHexDigit
				/// </java-name>
				[Dot42.DexImport("isHexDigit", "(C)Z", AccessFlags = 4)]
				protected internal virtual bool IsHexDigit(char @char) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// decodeHexDigit
				/// </java-name>
				[Dot42.DexImport("decodeHexDigit", "(C)I", AccessFlags = 4)]
				protected internal virtual int DecodeHexDigit(char @char) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// clear
				/// </java-name>
				[Dot42.DexImport("clear", "()V", AccessFlags = 4)]
				protected internal virtual void Clear() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getUnregisteredParameterValueSanitizer
				/// </java-name>
				public virtual global::Android.Net.UrlQuerySanitizer.IValueSanitizer UnregisteredParameterValueSanitizer
				{
						[Dot42.DexImport("getUnregisteredParameterValueSanitizer", "()Landroid/net/UrlQuerySanitizer$ValueSanitizer;", AccessFlags = 1)]
						get{ return default(global::Android.Net.UrlQuerySanitizer.IValueSanitizer); }
						[Dot42.DexImport("setUnregisteredParameterValueSanitizer", "(Landroid/net/UrlQuerySanitizer$ValueSanitizer;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getAllIllegal
				/// </java-name>
				public static global::Android.Net.UrlQuerySanitizer.IValueSanitizer AllIllegal
				{
						[Dot42.DexImport("getAllIllegal", "()Landroid/net/UrlQuerySanitizer$ValueSanitizer;", AccessFlags = 25)]
						get{ return default(global::Android.Net.UrlQuerySanitizer.IValueSanitizer); }
				}

				/// <java-name>
				/// getAllButNulLegal
				/// </java-name>
				public static global::Android.Net.UrlQuerySanitizer.IValueSanitizer AllButNulLegal
				{
						[Dot42.DexImport("getAllButNulLegal", "()Landroid/net/UrlQuerySanitizer$ValueSanitizer;", AccessFlags = 25)]
						get{ return default(global::Android.Net.UrlQuerySanitizer.IValueSanitizer); }
				}

				/// <java-name>
				/// getAllButWhitespaceLegal
				/// </java-name>
				public static global::Android.Net.UrlQuerySanitizer.IValueSanitizer AllButWhitespaceLegal
				{
						[Dot42.DexImport("getAllButWhitespaceLegal", "()Landroid/net/UrlQuerySanitizer$ValueSanitizer;", AccessFlags = 25)]
						get{ return default(global::Android.Net.UrlQuerySanitizer.IValueSanitizer); }
				}

				/// <java-name>
				/// getUrlLegal
				/// </java-name>
				public static global::Android.Net.UrlQuerySanitizer.IValueSanitizer UrlLegal
				{
						[Dot42.DexImport("getUrlLegal", "()Landroid/net/UrlQuerySanitizer$ValueSanitizer;", AccessFlags = 25)]
						get{ return default(global::Android.Net.UrlQuerySanitizer.IValueSanitizer); }
				}

				/// <java-name>
				/// getUrlAndSpaceLegal
				/// </java-name>
				public static global::Android.Net.UrlQuerySanitizer.IValueSanitizer UrlAndSpaceLegal
				{
						[Dot42.DexImport("getUrlAndSpaceLegal", "()Landroid/net/UrlQuerySanitizer$ValueSanitizer;", AccessFlags = 25)]
						get{ return default(global::Android.Net.UrlQuerySanitizer.IValueSanitizer); }
				}

				/// <java-name>
				/// getAmpLegal
				/// </java-name>
				public static global::Android.Net.UrlQuerySanitizer.IValueSanitizer AmpLegal
				{
						[Dot42.DexImport("getAmpLegal", "()Landroid/net/UrlQuerySanitizer$ValueSanitizer;", AccessFlags = 25)]
						get{ return default(global::Android.Net.UrlQuerySanitizer.IValueSanitizer); }
				}

				/// <java-name>
				/// getAmpAndSpaceLegal
				/// </java-name>
				public static global::Android.Net.UrlQuerySanitizer.IValueSanitizer AmpAndSpaceLegal
				{
						[Dot42.DexImport("getAmpAndSpaceLegal", "()Landroid/net/UrlQuerySanitizer$ValueSanitizer;", AccessFlags = 25)]
						get{ return default(global::Android.Net.UrlQuerySanitizer.IValueSanitizer); }
				}

				/// <java-name>
				/// getSpaceLegal
				/// </java-name>
				public static global::Android.Net.UrlQuerySanitizer.IValueSanitizer SpaceLegal
				{
						[Dot42.DexImport("getSpaceLegal", "()Landroid/net/UrlQuerySanitizer$ValueSanitizer;", AccessFlags = 25)]
						get{ return default(global::Android.Net.UrlQuerySanitizer.IValueSanitizer); }
				}

				/// <java-name>
				/// getAllButNulAndAngleBracketsLegal
				/// </java-name>
				public static global::Android.Net.UrlQuerySanitizer.IValueSanitizer AllButNulAndAngleBracketsLegal
				{
						[Dot42.DexImport("getAllButNulAndAngleBracketsLegal", "()Landroid/net/UrlQuerySanitizer$ValueSanitizer;", AccessFlags = 25)]
						get{ return default(global::Android.Net.UrlQuerySanitizer.IValueSanitizer); }
				}

				/// <java-name>
				/// getParameterSet
				/// </java-name>
				public virtual global::Java.Util.ISet<string> ParameterSet
				{
						[Dot42.DexImport("getParameterSet", "()Ljava/util/Set;", AccessFlags = 1, Signature = "()Ljava/util/Set<Ljava/lang/String;>;")]
						get{ return default(global::Java.Util.ISet<string>); }
				}

				/// <java-name>
				/// getParameterList
				/// </java-name>
				public virtual global::Java.Util.IList<global::Android.Net.UrlQuerySanitizer.ParameterValuePair> ParameterList
				{
						[Dot42.DexImport("getParameterList", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Landroid/net/UrlQuerySanitizer$ParameterValuePair;>;")]
						get{ return default(global::Java.Util.IList<global::Android.Net.UrlQuerySanitizer.ParameterValuePair>); }
				}

				/// <java-name>
				/// getAllowUnregisteredParamaters
				/// </java-name>
				public virtual bool IsAllowUnregisteredParamaters
				{
						[Dot42.DexImport("getAllowUnregisteredParamaters", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setAllowUnregisteredParamaters", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getPreferFirstRepeatedParameter
				/// </java-name>
				public virtual bool IsPreferFirstRepeatedParameter
				{
						[Dot42.DexImport("getPreferFirstRepeatedParameter", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setPreferFirstRepeatedParameter", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// android/net/UrlQuerySanitizer$IllegalCharacterValueSanitizer
				/// </java-name>
				[Dot42.DexImport("android/net/UrlQuerySanitizer$IllegalCharacterValueSanitizer", AccessFlags = 9)]
				public partial class IllegalCharacterValueSanitizer : global::Android.Net.UrlQuerySanitizer.IValueSanitizer
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// SPACE_OK
						/// </java-name>
						[Dot42.DexImport("SPACE_OK", "I", AccessFlags = 25)]
						public const int SPACE_OK = 1;
						/// <java-name>
						/// OTHER_WHITESPACE_OK
						/// </java-name>
						[Dot42.DexImport("OTHER_WHITESPACE_OK", "I", AccessFlags = 25)]
						public const int OTHER_WHITESPACE_OK = 2;
						/// <java-name>
						/// NON_7_BIT_ASCII_OK
						/// </java-name>
						[Dot42.DexImport("NON_7_BIT_ASCII_OK", "I", AccessFlags = 25)]
						public const int NON_7_BIT_ASCII_OK = 4;
						/// <java-name>
						/// DQUOTE_OK
						/// </java-name>
						[Dot42.DexImport("DQUOTE_OK", "I", AccessFlags = 25)]
						public const int DQUOTE_OK = 8;
						/// <java-name>
						/// SQUOTE_OK
						/// </java-name>
						[Dot42.DexImport("SQUOTE_OK", "I", AccessFlags = 25)]
						public const int SQUOTE_OK = 16;
						/// <java-name>
						/// LT_OK
						/// </java-name>
						[Dot42.DexImport("LT_OK", "I", AccessFlags = 25)]
						public const int LT_OK = 32;
						/// <java-name>
						/// GT_OK
						/// </java-name>
						[Dot42.DexImport("GT_OK", "I", AccessFlags = 25)]
						public const int GT_OK = 64;
						/// <java-name>
						/// AMP_OK
						/// </java-name>
						[Dot42.DexImport("AMP_OK", "I", AccessFlags = 25)]
						public const int AMP_OK = 128;
						/// <java-name>
						/// PCT_OK
						/// </java-name>
						[Dot42.DexImport("PCT_OK", "I", AccessFlags = 25)]
						public const int PCT_OK = 256;
						/// <java-name>
						/// NUL_OK
						/// </java-name>
						[Dot42.DexImport("NUL_OK", "I", AccessFlags = 25)]
						public const int NUL_OK = 512;
						/// <java-name>
						/// SCRIPT_URL_OK
						/// </java-name>
						[Dot42.DexImport("SCRIPT_URL_OK", "I", AccessFlags = 25)]
						public const int SCRIPT_URL_OK = 1024;
						/// <java-name>
						/// ALL_OK
						/// </java-name>
						[Dot42.DexImport("ALL_OK", "I", AccessFlags = 25)]
						public const int ALL_OK = 2047;
						/// <java-name>
						/// ALL_WHITESPACE_OK
						/// </java-name>
						[Dot42.DexImport("ALL_WHITESPACE_OK", "I", AccessFlags = 25)]
						public const int ALL_WHITESPACE_OK = 3;
						/// <java-name>
						/// ALL_ILLEGAL
						/// </java-name>
						[Dot42.DexImport("ALL_ILLEGAL", "I", AccessFlags = 25)]
						public const int ALL_ILLEGAL = 0;
						/// <java-name>
						/// ALL_BUT_NUL_LEGAL
						/// </java-name>
						[Dot42.DexImport("ALL_BUT_NUL_LEGAL", "I", AccessFlags = 25)]
						public const int ALL_BUT_NUL_LEGAL = 1535;
						/// <java-name>
						/// ALL_BUT_WHITESPACE_LEGAL
						/// </java-name>
						[Dot42.DexImport("ALL_BUT_WHITESPACE_LEGAL", "I", AccessFlags = 25)]
						public const int ALL_BUT_WHITESPACE_LEGAL = 1532;
						/// <java-name>
						/// URL_LEGAL
						/// </java-name>
						[Dot42.DexImport("URL_LEGAL", "I", AccessFlags = 25)]
						public const int URL_LEGAL = 404;
						/// <java-name>
						/// URL_AND_SPACE_LEGAL
						/// </java-name>
						[Dot42.DexImport("URL_AND_SPACE_LEGAL", "I", AccessFlags = 25)]
						public const int URL_AND_SPACE_LEGAL = 405;
						/// <java-name>
						/// AMP_LEGAL
						/// </java-name>
						[Dot42.DexImport("AMP_LEGAL", "I", AccessFlags = 25)]
						public const int AMP_LEGAL = 128;
						/// <java-name>
						/// AMP_AND_SPACE_LEGAL
						/// </java-name>
						[Dot42.DexImport("AMP_AND_SPACE_LEGAL", "I", AccessFlags = 25)]
						public const int AMP_AND_SPACE_LEGAL = 129;
						/// <java-name>
						/// SPACE_LEGAL
						/// </java-name>
						[Dot42.DexImport("SPACE_LEGAL", "I", AccessFlags = 25)]
						public const int SPACE_LEGAL = 1;
						/// <java-name>
						/// ALL_BUT_NUL_AND_ANGLE_BRACKETS_LEGAL
						/// </java-name>
						[Dot42.DexImport("ALL_BUT_NUL_AND_ANGLE_BRACKETS_LEGAL", "I", AccessFlags = 25)]
						public const int ALL_BUT_NUL_AND_ANGLE_BRACKETS_LEGAL = 1439;
						[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
						public IllegalCharacterValueSanitizer(int int32) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// sanitize
						/// </java-name>
						[Dot42.DexImport("sanitize", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1)]
						public virtual string Sanitize(string @string) /* MethodBuilder.Create */ 
						{
								return default(string);
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal IllegalCharacterValueSanitizer() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

				}

				/// <java-name>
				/// android/net/UrlQuerySanitizer$ValueSanitizer
				/// </java-name>
				[Dot42.DexImport("android/net/UrlQuerySanitizer$ValueSanitizer", AccessFlags = 1545)]
				public partial interface IValueSanitizer
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// sanitize
						/// </java-name>
						[Dot42.DexImport("sanitize", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1025)]
						string Sanitize(string @string) /* MethodBuilder.Create */ ;

				}

				/// <java-name>
				/// android/net/UrlQuerySanitizer$ParameterValuePair
				/// </java-name>
				[Dot42.DexImport("android/net/UrlQuerySanitizer$ParameterValuePair", AccessFlags = 1)]
				public partial class ParameterValuePair
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// mParameter
						/// </java-name>
						[Dot42.DexImport("mParameter", "Ljava/lang/String;", AccessFlags = 1)]
						public string MParameter;
						/// <java-name>
						/// mValue
						/// </java-name>
						[Dot42.DexImport("mValue", "Ljava/lang/String;", AccessFlags = 1)]
						public string MValue;
						/// <java-name>
						/// this$0
						/// </java-name>
						[Dot42.DexImport("this$0", "Landroid/net/UrlQuerySanitizer;", AccessFlags = 4112)]
						internal readonly global::Android.Net.UrlQuerySanitizer This_0;
						[Dot42.DexImport("<init>", "(Landroid/net/UrlQuerySanitizer;Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
						public ParameterValuePair(global::Android.Net.UrlQuerySanitizer urlQuerySanitizer, string @string, string string1) /* MethodBuilder.Create */ 
						{
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal ParameterValuePair() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

				}

		}

		/// <java-name>
		/// android/net/VpnService
		/// </java-name>
		[Dot42.DexImport("android/net/VpnService", AccessFlags = 33)]
		public partial class VpnService : global::Android.App.Service
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// SERVICE_INTERFACE
				/// </java-name>
				[Dot42.DexImport("SERVICE_INTERFACE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SERVICE_INTERFACE = "android.net.VpnService";
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public VpnService() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// prepare
				/// </java-name>
				[Dot42.DexImport("prepare", "(Landroid/content/Context;)Landroid/content/Intent;", AccessFlags = 9)]
				public static global::Android.Content.Intent Prepare(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Intent);
				}

				/// <java-name>
				/// protect
				/// </java-name>
				[Dot42.DexImport("protect", "(I)Z", AccessFlags = 1)]
				public virtual bool Protect(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// protect
				/// </java-name>
				[Dot42.DexImport("protect", "(Ljava/net/Socket;)Z", AccessFlags = 1)]
				public virtual bool Protect(global::Java.Net.Socket socket) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// protect
				/// </java-name>
				[Dot42.DexImport("protect", "(Ljava/net/DatagramSocket;)Z", AccessFlags = 1)]
				public virtual bool Protect(global::Java.Net.DatagramSocket datagramSocket) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onBind
				/// </java-name>
				[Dot42.DexImport("onBind", "(Landroid/content/Intent;)Landroid/os/IBinder;", AccessFlags = 1)]
				public override global::Android.OS.IBinder OnBind(global::Android.Content.Intent intent) /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.IBinder);
				}

				/// <java-name>
				/// onRevoke
				/// </java-name>
				[Dot42.DexImport("onRevoke", "()V", AccessFlags = 1)]
				public virtual void OnRevoke() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// android/net/VpnService$Builder
				/// </java-name>
				[Dot42.DexImport("android/net/VpnService$Builder", AccessFlags = 1)]
				public partial class Builder
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// this$0
						/// </java-name>
						[Dot42.DexImport("this$0", "Landroid/net/VpnService;", AccessFlags = 4112)]
						internal readonly global::Android.Net.VpnService This_0;
						[Dot42.DexImport("<init>", "(Landroid/net/VpnService;)V", AccessFlags = 1)]
						public Builder(global::Android.Net.VpnService vpnService) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// setSession
						/// </java-name>
						[Dot42.DexImport("setSession", "(Ljava/lang/String;)Landroid/net/VpnService$Builder;", AccessFlags = 1)]
						public virtual Builder SetSession(string @string) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// setConfigureIntent
						/// </java-name>
						[Dot42.DexImport("setConfigureIntent", "(Landroid/app/PendingIntent;)Landroid/net/VpnService$Builder;", AccessFlags = 1)]
						public virtual Builder SetConfigureIntent(global::Android.App.PendingIntent pendingIntent) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// setMtu
						/// </java-name>
						[Dot42.DexImport("setMtu", "(I)Landroid/net/VpnService$Builder;", AccessFlags = 1)]
						public virtual Builder SetMtu(int int32) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// addAddress
						/// </java-name>
						[Dot42.DexImport("addAddress", "(Ljava/net/InetAddress;I)Landroid/net/VpnService$Builder;", AccessFlags = 1)]
						public virtual Builder AddAddress(global::Java.Net.InetAddress inetAddress, int int32) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// addAddress
						/// </java-name>
						[Dot42.DexImport("addAddress", "(Ljava/lang/String;I)Landroid/net/VpnService$Builder;", AccessFlags = 1)]
						public virtual Builder AddAddress(string @string, int int32) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// addRoute
						/// </java-name>
						[Dot42.DexImport("addRoute", "(Ljava/net/InetAddress;I)Landroid/net/VpnService$Builder;", AccessFlags = 1)]
						public virtual Builder AddRoute(global::Java.Net.InetAddress inetAddress, int int32) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// addRoute
						/// </java-name>
						[Dot42.DexImport("addRoute", "(Ljava/lang/String;I)Landroid/net/VpnService$Builder;", AccessFlags = 1)]
						public virtual Builder AddRoute(string @string, int int32) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// addDnsServer
						/// </java-name>
						[Dot42.DexImport("addDnsServer", "(Ljava/net/InetAddress;)Landroid/net/VpnService$Builder;", AccessFlags = 1)]
						public virtual Builder AddDnsServer(global::Java.Net.InetAddress inetAddress) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// addDnsServer
						/// </java-name>
						[Dot42.DexImport("addDnsServer", "(Ljava/lang/String;)Landroid/net/VpnService$Builder;", AccessFlags = 1)]
						public virtual Builder AddDnsServer(string @string) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// addSearchDomain
						/// </java-name>
						[Dot42.DexImport("addSearchDomain", "(Ljava/lang/String;)Landroid/net/VpnService$Builder;", AccessFlags = 1)]
						public virtual Builder AddSearchDomain(string @string) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// establish
						/// </java-name>
						[Dot42.DexImport("establish", "()Landroid/os/ParcelFileDescriptor;", AccessFlags = 1)]
						public virtual global::Android.OS.ParcelFileDescriptor Establish() /* MethodBuilder.Create */ 
						{
								return default(global::Android.OS.ParcelFileDescriptor);
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal Builder() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

				}

		}

}

