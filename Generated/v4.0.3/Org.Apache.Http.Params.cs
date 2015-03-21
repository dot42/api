#pragma warning disable 1717
namespace Org.Apache.Http.Params
{
		/// <java-name>
		/// org/apache/http/params/AbstractHttpParams
		/// </java-name>
		[Dot42.DexImport("org/apache/http/params/AbstractHttpParams", AccessFlags = 1057)]
		public abstract partial class AbstractHttpParams : global::Org.Apache.Http.Params.IHttpParams
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal AbstractHttpParams() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getLongParameter
				/// </java-name>
				[Dot42.DexImport("getLongParameter", "(Ljava/lang/String;J)J", AccessFlags = 1)]
				public virtual long GetLongParameter(string @string, long int64) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// setLongParameter
				/// </java-name>
				[Dot42.DexImport("setLongParameter", "(Ljava/lang/String;J)Lorg/apache/http/params/HttpParams;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.Params.IHttpParams SetLongParameter(string @string, long int64) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Params.IHttpParams);
				}

				/// <java-name>
				/// getIntParameter
				/// </java-name>
				[Dot42.DexImport("getIntParameter", "(Ljava/lang/String;I)I", AccessFlags = 1)]
				public virtual int GetIntParameter(string @string, int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// setIntParameter
				/// </java-name>
				[Dot42.DexImport("setIntParameter", "(Ljava/lang/String;I)Lorg/apache/http/params/HttpParams;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.Params.IHttpParams SetIntParameter(string @string, int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Params.IHttpParams);
				}

				/// <java-name>
				/// getDoubleParameter
				/// </java-name>
				[Dot42.DexImport("getDoubleParameter", "(Ljava/lang/String;D)D", AccessFlags = 1)]
				public virtual double GetDoubleParameter(string @string, double @double) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <java-name>
				/// setDoubleParameter
				/// </java-name>
				[Dot42.DexImport("setDoubleParameter", "(Ljava/lang/String;D)Lorg/apache/http/params/HttpParams;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.Params.IHttpParams SetDoubleParameter(string @string, double @double) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Params.IHttpParams);
				}

				/// <java-name>
				/// getBooleanParameter
				/// </java-name>
				[Dot42.DexImport("getBooleanParameter", "(Ljava/lang/String;Z)Z", AccessFlags = 1)]
				public virtual bool GetBooleanParameter(string @string, bool boolean) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setBooleanParameter
				/// </java-name>
				[Dot42.DexImport("setBooleanParameter", "(Ljava/lang/String;Z)Lorg/apache/http/params/HttpParams;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.Params.IHttpParams SetBooleanParameter(string @string, bool boolean) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Params.IHttpParams);
				}

				/// <java-name>
				/// isParameterTrue
				/// </java-name>
				[Dot42.DexImport("isParameterTrue", "(Ljava/lang/String;)Z", AccessFlags = 1)]
				public virtual bool IsParameterTrue(string @string) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isParameterFalse
				/// </java-name>
				[Dot42.DexImport("isParameterFalse", "(Ljava/lang/String;)Z", AccessFlags = 1)]
				public virtual bool IsParameterFalse(string @string) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("org/apache/http/params/HttpParams", "getParameter", "(Ljava/lang/String;)Ljava/lang/Object;", AccessFlags = 1025)]
				public virtual object GetParameter(string @string) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(object);
				}

				[Dot42.DexImport("org/apache/http/params/HttpParams", "setParameter", "(Ljava/lang/String;Ljava/lang/Object;)Lorg/apache/http/params/HttpParams;", AccessFlags = 1025)]
				public virtual global::Org.Apache.Http.Params.IHttpParams SetParameter(string @string, object @object) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Org.Apache.Http.Params.IHttpParams);
				}

				[Dot42.DexImport("org/apache/http/params/HttpParams", "copy", "()Lorg/apache/http/params/HttpParams;", AccessFlags = 1025)]
				public virtual global::Org.Apache.Http.Params.IHttpParams Copy() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Org.Apache.Http.Params.IHttpParams);
				}

				[Dot42.DexImport("org/apache/http/params/HttpParams", "removeParameter", "(Ljava/lang/String;)Z", AccessFlags = 1025)]
				public virtual bool RemoveParameter(string @string) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

		}

		/// <java-name>
		/// org/apache/http/params/BasicHttpParams
		/// </java-name>
		[Dot42.DexImport("org/apache/http/params/BasicHttpParams", AccessFlags = 49)]
		public sealed partial class BasicHttpParams : global::Org.Apache.Http.Params.AbstractHttpParams, global::Java.Io.ISerializable, global::Java.Lang.ICloneable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public BasicHttpParams() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getParameter
				/// </java-name>
				[Dot42.DexImport("getParameter", "(Ljava/lang/String;)Ljava/lang/Object;", AccessFlags = 1)]
				public override object GetParameter(string @string) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <java-name>
				/// setParameter
				/// </java-name>
				[Dot42.DexImport("setParameter", "(Ljava/lang/String;Ljava/lang/Object;)Lorg/apache/http/params/HttpParams;", AccessFlags = 1)]
				public override global::Org.Apache.Http.Params.IHttpParams SetParameter(string @string, object @object) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Params.IHttpParams);
				}

				/// <java-name>
				/// removeParameter
				/// </java-name>
				[Dot42.DexImport("removeParameter", "(Ljava/lang/String;)Z", AccessFlags = 1)]
				public override bool RemoveParameter(string @string) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setParameters
				/// </java-name>
				[Dot42.DexImport("setParameters", "([Ljava/lang/String;Ljava/lang/Object;)V", AccessFlags = 1)]
				public void SetParameters(string[] @string, object @object) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isParameterSet
				/// </java-name>
				[Dot42.DexImport("isParameterSet", "(Ljava/lang/String;)Z", AccessFlags = 1)]
				public bool IsParameterSet(string @string) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isParameterSetLocally
				/// </java-name>
				[Dot42.DexImport("isParameterSetLocally", "(Ljava/lang/String;)Z", AccessFlags = 1)]
				public bool IsParameterSetLocally(string @string) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// clear
				/// </java-name>
				[Dot42.DexImport("clear", "()V", AccessFlags = 1)]
				public void Clear() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// copy
				/// </java-name>
				[Dot42.DexImport("copy", "()Lorg/apache/http/params/HttpParams;", AccessFlags = 1)]
				public override global::Org.Apache.Http.Params.IHttpParams Copy() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Params.IHttpParams);
				}

				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/lang/Object;", AccessFlags = 1)]
				public object Clone() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <java-name>
				/// copyParams
				/// </java-name>
				[Dot42.DexImport("copyParams", "(Lorg/apache/http/params/HttpParams;)V", AccessFlags = 4)]
				internal void CopyParams(global::Org.Apache.Http.Params.IHttpParams httpParams) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// org/apache/http/params/DefaultedHttpParams
		/// </java-name>
		[Dot42.DexImport("org/apache/http/params/DefaultedHttpParams", AccessFlags = 49)]
		public sealed partial class DefaultedHttpParams : global::Org.Apache.Http.Params.AbstractHttpParams
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Lorg/apache/http/params/HttpParams;Lorg/apache/http/params/HttpParams;)V", AccessFlags = 1)]
				public DefaultedHttpParams(global::Org.Apache.Http.Params.IHttpParams httpParams, global::Org.Apache.Http.Params.IHttpParams httpParams1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// copy
				/// </java-name>
				[Dot42.DexImport("copy", "()Lorg/apache/http/params/HttpParams;", AccessFlags = 1)]
				public override global::Org.Apache.Http.Params.IHttpParams Copy() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Params.IHttpParams);
				}

				/// <java-name>
				/// getParameter
				/// </java-name>
				[Dot42.DexImport("getParameter", "(Ljava/lang/String;)Ljava/lang/Object;", AccessFlags = 1)]
				public override object GetParameter(string @string) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <java-name>
				/// removeParameter
				/// </java-name>
				[Dot42.DexImport("removeParameter", "(Ljava/lang/String;)Z", AccessFlags = 1)]
				public override bool RemoveParameter(string @string) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setParameter
				/// </java-name>
				[Dot42.DexImport("setParameter", "(Ljava/lang/String;Ljava/lang/Object;)Lorg/apache/http/params/HttpParams;", AccessFlags = 1)]
				public override global::Org.Apache.Http.Params.IHttpParams SetParameter(string @string, object @object) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Params.IHttpParams);
				}

				/// <java-name>
				/// getDefaults
				/// </java-name>
				[Dot42.DexImport("getDefaults", "()Lorg/apache/http/params/HttpParams;", AccessFlags = 1)]
				public global::Org.Apache.Http.Params.IHttpParams GetDefaults() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Params.IHttpParams);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal DefaultedHttpParams() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getDefaults
				/// </java-name>
				public global::Org.Apache.Http.Params.IHttpParams Defaults
				{
				[Dot42.DexImport("getDefaults", "()Lorg/apache/http/params/HttpParams;", AccessFlags = 1)]
						get{ return GetDefaults(); }
				}

		}

		/// <java-name>
		/// org/apache/http/params/HttpAbstractParamBean
		/// </java-name>
		[Dot42.DexImport("org/apache/http/params/HttpAbstractParamBean", AccessFlags = 1057)]
		public abstract partial class HttpAbstractParamBean
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// params
				/// </java-name>
				[Dot42.DexImport("params", "Lorg/apache/http/params/HttpParams;", AccessFlags = 20)]
				protected internal readonly global::Org.Apache.Http.Params.IHttpParams Params;
				[Dot42.DexImport("<init>", "(Lorg/apache/http/params/HttpParams;)V", AccessFlags = 1)]
				public HttpAbstractParamBean(global::Org.Apache.Http.Params.IHttpParams httpParams) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal HttpAbstractParamBean() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// org/apache/http/params/HttpConnectionParamBean
		/// </java-name>
		[Dot42.DexImport("org/apache/http/params/HttpConnectionParamBean", AccessFlags = 33)]
		public partial class HttpConnectionParamBean : global::Org.Apache.Http.Params.HttpAbstractParamBean
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Lorg/apache/http/params/HttpParams;)V", AccessFlags = 1)]
				public HttpConnectionParamBean(global::Org.Apache.Http.Params.IHttpParams httpParams) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setSoTimeout
				/// </java-name>
				[Dot42.DexImport("setSoTimeout", "(I)V", AccessFlags = 1)]
				public virtual void SetSoTimeout(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setTcpNoDelay
				/// </java-name>
				[Dot42.DexImport("setTcpNoDelay", "(Z)V", AccessFlags = 1)]
				public virtual void SetTcpNoDelay(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setSocketBufferSize
				/// </java-name>
				[Dot42.DexImport("setSocketBufferSize", "(I)V", AccessFlags = 1)]
				public virtual void SetSocketBufferSize(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setLinger
				/// </java-name>
				[Dot42.DexImport("setLinger", "(I)V", AccessFlags = 1)]
				public virtual void SetLinger(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setConnectionTimeout
				/// </java-name>
				[Dot42.DexImport("setConnectionTimeout", "(I)V", AccessFlags = 1)]
				public virtual void SetConnectionTimeout(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setStaleCheckingEnabled
				/// </java-name>
				[Dot42.DexImport("setStaleCheckingEnabled", "(Z)V", AccessFlags = 1)]
				public virtual void SetStaleCheckingEnabled(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal HttpConnectionParamBean() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// org/apache/http/params/HttpConnectionParams
		/// </java-name>
		[Dot42.DexImport("org/apache/http/params/HttpConnectionParams", AccessFlags = 49)]
		public sealed partial class HttpConnectionParams : global::Org.Apache.Http.Params.ICoreConnectionPNames
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal HttpConnectionParams() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getSoTimeout
				/// </java-name>
				[Dot42.DexImport("getSoTimeout", "(Lorg/apache/http/params/HttpParams;)I", AccessFlags = 9)]
				public static int GetSoTimeout(global::Org.Apache.Http.Params.IHttpParams httpParams) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// setSoTimeout
				/// </java-name>
				[Dot42.DexImport("setSoTimeout", "(Lorg/apache/http/params/HttpParams;I)V", AccessFlags = 9)]
				public static void SetSoTimeout(global::Org.Apache.Http.Params.IHttpParams httpParams, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getTcpNoDelay
				/// </java-name>
				[Dot42.DexImport("getTcpNoDelay", "(Lorg/apache/http/params/HttpParams;)Z", AccessFlags = 9)]
				public static bool GetTcpNoDelay(global::Org.Apache.Http.Params.IHttpParams httpParams) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setTcpNoDelay
				/// </java-name>
				[Dot42.DexImport("setTcpNoDelay", "(Lorg/apache/http/params/HttpParams;Z)V", AccessFlags = 9)]
				public static void SetTcpNoDelay(global::Org.Apache.Http.Params.IHttpParams httpParams, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getSocketBufferSize
				/// </java-name>
				[Dot42.DexImport("getSocketBufferSize", "(Lorg/apache/http/params/HttpParams;)I", AccessFlags = 9)]
				public static int GetSocketBufferSize(global::Org.Apache.Http.Params.IHttpParams httpParams) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// setSocketBufferSize
				/// </java-name>
				[Dot42.DexImport("setSocketBufferSize", "(Lorg/apache/http/params/HttpParams;I)V", AccessFlags = 9)]
				public static void SetSocketBufferSize(global::Org.Apache.Http.Params.IHttpParams httpParams, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getLinger
				/// </java-name>
				[Dot42.DexImport("getLinger", "(Lorg/apache/http/params/HttpParams;)I", AccessFlags = 9)]
				public static int GetLinger(global::Org.Apache.Http.Params.IHttpParams httpParams) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// setLinger
				/// </java-name>
				[Dot42.DexImport("setLinger", "(Lorg/apache/http/params/HttpParams;I)V", AccessFlags = 9)]
				public static void SetLinger(global::Org.Apache.Http.Params.IHttpParams httpParams, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getConnectionTimeout
				/// </java-name>
				[Dot42.DexImport("getConnectionTimeout", "(Lorg/apache/http/params/HttpParams;)I", AccessFlags = 9)]
				public static int GetConnectionTimeout(global::Org.Apache.Http.Params.IHttpParams httpParams) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// setConnectionTimeout
				/// </java-name>
				[Dot42.DexImport("setConnectionTimeout", "(Lorg/apache/http/params/HttpParams;I)V", AccessFlags = 9)]
				public static void SetConnectionTimeout(global::Org.Apache.Http.Params.IHttpParams httpParams, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isStaleCheckingEnabled
				/// </java-name>
				[Dot42.DexImport("isStaleCheckingEnabled", "(Lorg/apache/http/params/HttpParams;)Z", AccessFlags = 9)]
				public static bool IsStaleCheckingEnabled(global::Org.Apache.Http.Params.IHttpParams httpParams) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setStaleCheckingEnabled
				/// </java-name>
				[Dot42.DexImport("setStaleCheckingEnabled", "(Lorg/apache/http/params/HttpParams;Z)V", AccessFlags = 9)]
				public static void SetStaleCheckingEnabled(global::Org.Apache.Http.Params.IHttpParams httpParams, bool boolean) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// org/apache/http/params/HttpProtocolParamBean
		/// </java-name>
		[Dot42.DexImport("org/apache/http/params/HttpProtocolParamBean", AccessFlags = 33)]
		public partial class HttpProtocolParamBean : global::Org.Apache.Http.Params.HttpAbstractParamBean
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Lorg/apache/http/params/HttpParams;)V", AccessFlags = 1)]
				public HttpProtocolParamBean(global::Org.Apache.Http.Params.IHttpParams httpParams) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setHttpElementCharset
				/// </java-name>
				[Dot42.DexImport("setHttpElementCharset", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetHttpElementCharset(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setContentCharset
				/// </java-name>
				[Dot42.DexImport("setContentCharset", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetContentCharset(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setVersion
				/// </java-name>
				[Dot42.DexImport("setVersion", "(Lorg/apache/http/HttpVersion;)V", AccessFlags = 1)]
				public virtual void SetVersion(global::Org.Apache.Http.HttpVersion httpVersion) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setUserAgent
				/// </java-name>
				[Dot42.DexImport("setUserAgent", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetUserAgent(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setUseExpectContinue
				/// </java-name>
				[Dot42.DexImport("setUseExpectContinue", "(Z)V", AccessFlags = 1)]
				public virtual void SetUseExpectContinue(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal HttpProtocolParamBean() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// org/apache/http/params/HttpProtocolParams
		/// </java-name>
		[Dot42.DexImport("org/apache/http/params/HttpProtocolParams", AccessFlags = 49)]
		public sealed partial class HttpProtocolParams : global::Org.Apache.Http.Params.ICoreProtocolPNames
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal HttpProtocolParams() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getHttpElementCharset
				/// </java-name>
				[Dot42.DexImport("getHttpElementCharset", "(Lorg/apache/http/params/HttpParams;)Ljava/lang/String;", AccessFlags = 9)]
				public static string GetHttpElementCharset(global::Org.Apache.Http.Params.IHttpParams httpParams) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// setHttpElementCharset
				/// </java-name>
				[Dot42.DexImport("setHttpElementCharset", "(Lorg/apache/http/params/HttpParams;Ljava/lang/String;)V", AccessFlags = 9)]
				public static void SetHttpElementCharset(global::Org.Apache.Http.Params.IHttpParams httpParams, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getContentCharset
				/// </java-name>
				[Dot42.DexImport("getContentCharset", "(Lorg/apache/http/params/HttpParams;)Ljava/lang/String;", AccessFlags = 9)]
				public static string GetContentCharset(global::Org.Apache.Http.Params.IHttpParams httpParams) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// setContentCharset
				/// </java-name>
				[Dot42.DexImport("setContentCharset", "(Lorg/apache/http/params/HttpParams;Ljava/lang/String;)V", AccessFlags = 9)]
				public static void SetContentCharset(global::Org.Apache.Http.Params.IHttpParams httpParams, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getVersion
				/// </java-name>
				[Dot42.DexImport("getVersion", "(Lorg/apache/http/params/HttpParams;)Lorg/apache/http/ProtocolVersion;", AccessFlags = 9)]
				public static global::Org.Apache.Http.ProtocolVersion GetVersion(global::Org.Apache.Http.Params.IHttpParams httpParams) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.ProtocolVersion);
				}

				/// <java-name>
				/// setVersion
				/// </java-name>
				[Dot42.DexImport("setVersion", "(Lorg/apache/http/params/HttpParams;Lorg/apache/http/ProtocolVersion;)V", AccessFlags = 9)]
				public static void SetVersion(global::Org.Apache.Http.Params.IHttpParams httpParams, global::Org.Apache.Http.ProtocolVersion protocolVersion) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getUserAgent
				/// </java-name>
				[Dot42.DexImport("getUserAgent", "(Lorg/apache/http/params/HttpParams;)Ljava/lang/String;", AccessFlags = 9)]
				public static string GetUserAgent(global::Org.Apache.Http.Params.IHttpParams httpParams) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// setUserAgent
				/// </java-name>
				[Dot42.DexImport("setUserAgent", "(Lorg/apache/http/params/HttpParams;Ljava/lang/String;)V", AccessFlags = 9)]
				public static void SetUserAgent(global::Org.Apache.Http.Params.IHttpParams httpParams, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// useExpectContinue
				/// </java-name>
				[Dot42.DexImport("useExpectContinue", "(Lorg/apache/http/params/HttpParams;)Z", AccessFlags = 9)]
				public static bool UseExpectContinue(global::Org.Apache.Http.Params.IHttpParams httpParams) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setUseExpectContinue
				/// </java-name>
				[Dot42.DexImport("setUseExpectContinue", "(Lorg/apache/http/params/HttpParams;Z)V", AccessFlags = 9)]
				public static void SetUseExpectContinue(global::Org.Apache.Http.Params.IHttpParams httpParams, bool boolean) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// org/apache/http/params/CoreConnectionPNames
		/// </java-name>
		[Dot42.DexImport("org/apache/http/params/CoreConnectionPNames", AccessFlags = 1537)]
		public partial interface ICoreConnectionPNames
 /* scope: __dot42__ */ 
		{
		}

		/// <java-name>
		/// org/apache/http/params/CoreConnectionPNames
		/// </java-name>
		[Dot42.DexImport("org/apache/http/params/CoreConnectionPNames", AccessFlags = 1537, IgnoreFromJava = true, Priority = 1)]
		public static partial class ICoreConnectionPNamesConstants
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// SO_TIMEOUT
				/// </java-name>
				[Dot42.DexImport("SO_TIMEOUT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SO_TIMEOUT = "http.socket.timeout";
				/// <java-name>
				/// TCP_NODELAY
				/// </java-name>
				[Dot42.DexImport("TCP_NODELAY", "Ljava/lang/String;", AccessFlags = 25)]
				public const string TCP_NODELAY = "http.tcp.nodelay";
				/// <java-name>
				/// SOCKET_BUFFER_SIZE
				/// </java-name>
				[Dot42.DexImport("SOCKET_BUFFER_SIZE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SOCKET_BUFFER_SIZE = "http.socket.buffer-size";
				/// <java-name>
				/// SO_LINGER
				/// </java-name>
				[Dot42.DexImport("SO_LINGER", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SO_LINGER = "http.socket.linger";
				/// <java-name>
				/// CONNECTION_TIMEOUT
				/// </java-name>
				[Dot42.DexImport("CONNECTION_TIMEOUT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string CONNECTION_TIMEOUT = "http.connection.timeout";
				/// <java-name>
				/// STALE_CONNECTION_CHECK
				/// </java-name>
				[Dot42.DexImport("STALE_CONNECTION_CHECK", "Ljava/lang/String;", AccessFlags = 25)]
				public const string STALE_CONNECTION_CHECK = "http.connection.stalecheck";
				/// <java-name>
				/// MAX_LINE_LENGTH
				/// </java-name>
				[Dot42.DexImport("MAX_LINE_LENGTH", "Ljava/lang/String;", AccessFlags = 25)]
				public const string MAX_LINE_LENGTH = "http.connection.max-line-length";
				/// <java-name>
				/// MAX_HEADER_COUNT
				/// </java-name>
				[Dot42.DexImport("MAX_HEADER_COUNT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string MAX_HEADER_COUNT = "http.connection.max-header-count";
		}

		/// <java-name>
		/// org/apache/http/params/CoreProtocolPNames
		/// </java-name>
		[Dot42.DexImport("org/apache/http/params/CoreProtocolPNames", AccessFlags = 1537)]
		public partial interface ICoreProtocolPNames
 /* scope: __dot42__ */ 
		{
		}

		/// <java-name>
		/// org/apache/http/params/CoreProtocolPNames
		/// </java-name>
		[Dot42.DexImport("org/apache/http/params/CoreProtocolPNames", AccessFlags = 1537, IgnoreFromJava = true, Priority = 1)]
		public static partial class ICoreProtocolPNamesConstants
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// PROTOCOL_VERSION
				/// </java-name>
				[Dot42.DexImport("PROTOCOL_VERSION", "Ljava/lang/String;", AccessFlags = 25)]
				public const string PROTOCOL_VERSION = "http.protocol.version";
				/// <java-name>
				/// HTTP_ELEMENT_CHARSET
				/// </java-name>
				[Dot42.DexImport("HTTP_ELEMENT_CHARSET", "Ljava/lang/String;", AccessFlags = 25)]
				public const string HTTP_ELEMENT_CHARSET = "http.protocol.element-charset";
				/// <java-name>
				/// HTTP_CONTENT_CHARSET
				/// </java-name>
				[Dot42.DexImport("HTTP_CONTENT_CHARSET", "Ljava/lang/String;", AccessFlags = 25)]
				public const string HTTP_CONTENT_CHARSET = "http.protocol.content-charset";
				/// <java-name>
				/// USER_AGENT
				/// </java-name>
				[Dot42.DexImport("USER_AGENT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string USER_AGENT = "http.useragent";
				/// <java-name>
				/// ORIGIN_SERVER
				/// </java-name>
				[Dot42.DexImport("ORIGIN_SERVER", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ORIGIN_SERVER = "http.origin-server";
				/// <java-name>
				/// STRICT_TRANSFER_ENCODING
				/// </java-name>
				[Dot42.DexImport("STRICT_TRANSFER_ENCODING", "Ljava/lang/String;", AccessFlags = 25)]
				public const string STRICT_TRANSFER_ENCODING = "http.protocol.strict-transfer-encoding";
				/// <java-name>
				/// USE_EXPECT_CONTINUE
				/// </java-name>
				[Dot42.DexImport("USE_EXPECT_CONTINUE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string USE_EXPECT_CONTINUE = "http.protocol.expect-continue";
				/// <java-name>
				/// WAIT_FOR_CONTINUE
				/// </java-name>
				[Dot42.DexImport("WAIT_FOR_CONTINUE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string WAIT_FOR_CONTINUE = "http.protocol.wait-for-continue";
		}

		/// <java-name>
		/// org/apache/http/params/HttpParams
		/// </java-name>
		[Dot42.DexImport("org/apache/http/params/HttpParams", AccessFlags = 1537)]
		public partial interface IHttpParams
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// getParameter
				/// </java-name>
				[Dot42.DexImport("getParameter", "(Ljava/lang/String;)Ljava/lang/Object;", AccessFlags = 1025)]
				object GetParameter(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setParameter
				/// </java-name>
				[Dot42.DexImport("setParameter", "(Ljava/lang/String;Ljava/lang/Object;)Lorg/apache/http/params/HttpParams;", AccessFlags = 1025)]
				global::Org.Apache.Http.Params.IHttpParams SetParameter(string @string, object @object) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// copy
				/// </java-name>
				[Dot42.DexImport("copy", "()Lorg/apache/http/params/HttpParams;", AccessFlags = 1025)]
				global::Org.Apache.Http.Params.IHttpParams Copy() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// removeParameter
				/// </java-name>
				[Dot42.DexImport("removeParameter", "(Ljava/lang/String;)Z", AccessFlags = 1025)]
				bool RemoveParameter(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getLongParameter
				/// </java-name>
				[Dot42.DexImport("getLongParameter", "(Ljava/lang/String;J)J", AccessFlags = 1025)]
				long GetLongParameter(string @string, long int64) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setLongParameter
				/// </java-name>
				[Dot42.DexImport("setLongParameter", "(Ljava/lang/String;J)Lorg/apache/http/params/HttpParams;", AccessFlags = 1025)]
				global::Org.Apache.Http.Params.IHttpParams SetLongParameter(string @string, long int64) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getIntParameter
				/// </java-name>
				[Dot42.DexImport("getIntParameter", "(Ljava/lang/String;I)I", AccessFlags = 1025)]
				int GetIntParameter(string @string, int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setIntParameter
				/// </java-name>
				[Dot42.DexImport("setIntParameter", "(Ljava/lang/String;I)Lorg/apache/http/params/HttpParams;", AccessFlags = 1025)]
				global::Org.Apache.Http.Params.IHttpParams SetIntParameter(string @string, int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getDoubleParameter
				/// </java-name>
				[Dot42.DexImport("getDoubleParameter", "(Ljava/lang/String;D)D", AccessFlags = 1025)]
				double GetDoubleParameter(string @string, double @double) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setDoubleParameter
				/// </java-name>
				[Dot42.DexImport("setDoubleParameter", "(Ljava/lang/String;D)Lorg/apache/http/params/HttpParams;", AccessFlags = 1025)]
				global::Org.Apache.Http.Params.IHttpParams SetDoubleParameter(string @string, double @double) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getBooleanParameter
				/// </java-name>
				[Dot42.DexImport("getBooleanParameter", "(Ljava/lang/String;Z)Z", AccessFlags = 1025)]
				bool GetBooleanParameter(string @string, bool boolean) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setBooleanParameter
				/// </java-name>
				[Dot42.DexImport("setBooleanParameter", "(Ljava/lang/String;Z)Lorg/apache/http/params/HttpParams;", AccessFlags = 1025)]
				global::Org.Apache.Http.Params.IHttpParams SetBooleanParameter(string @string, bool boolean) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// isParameterTrue
				/// </java-name>
				[Dot42.DexImport("isParameterTrue", "(Ljava/lang/String;)Z", AccessFlags = 1025)]
				bool IsParameterTrue(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// isParameterFalse
				/// </java-name>
				[Dot42.DexImport("isParameterFalse", "(Ljava/lang/String;)Z", AccessFlags = 1025)]
				bool IsParameterFalse(string @string) /* MethodBuilder.Create */ ;

		}

}

