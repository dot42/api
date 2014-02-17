// Copyright (C) 2014 dot42
//
// Original filename: Org.Apache.Http.Params.cs
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
namespace Org.Apache.Http.Params
{
		/// <summary>
		/// <para>HttpParams implementation that delegates resolution of a parameter to the given default HttpParams instance if the parameter is not present in the local one. The state of the local collection can be mutated, whereas the default collection is treated as read-only.</para><para><para></para><para></para><title>Revision:</title><para>610763 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/params/DefaultedHttpParams
		/// </java-name>
		[Dot42.DexImport("org/apache/http/params/DefaultedHttpParams", AccessFlags = 49)]
		public sealed partial class DefaultedHttpParams : global::Org.Apache.Http.Params.AbstractHttpParams
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Lorg/apache/http/params/HttpParams;Lorg/apache/http/params/HttpParams;)V", AccessFlags = 1)]
				public DefaultedHttpParams(global::Org.Apache.Http.Params.IHttpParams local, global::Org.Apache.Http.Params.IHttpParams defaults) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a copy of the local collection with the same default </para>        
				/// </summary>
				/// <java-name>
				/// copy
				/// </java-name>
				[Dot42.DexImport("copy", "()Lorg/apache/http/params/HttpParams;", AccessFlags = 1)]
				public override global::Org.Apache.Http.Params.IHttpParams Copy() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Params.IHttpParams);
				}

				/// <summary>
				/// <para>Retrieves the value of the parameter from the local collection and, if the parameter is not set locally, delegates its resolution to the default collection. </para>        
				/// </summary>
				/// <java-name>
				/// getParameter
				/// </java-name>
				[Dot42.DexImport("getParameter", "(Ljava/lang/String;)Ljava/lang/Object;", AccessFlags = 1)]
				public override object GetParameter(string name) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <summary>
				/// <para>Attempts to remove the parameter from the local collection. This method <b>does not</b> modify the default collection. </para>        
				/// </summary>
				/// <java-name>
				/// removeParameter
				/// </java-name>
				[Dot42.DexImport("removeParameter", "(Ljava/lang/String;)Z", AccessFlags = 1)]
				public override bool RemoveParameter(string name) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Sets the parameter in the local collection. This method <b>does not</b> modify the default collection. </para>        
				/// </summary>
				/// <java-name>
				/// setParameter
				/// </java-name>
				[Dot42.DexImport("setParameter", "(Ljava/lang/String;Ljava/lang/Object;)Lorg/apache/http/params/HttpParams;", AccessFlags = 1)]
				public override global::Org.Apache.Http.Params.IHttpParams SetParameter(string name, object value) /* MethodBuilder.Create */ 
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
				public HttpAbstractParamBean(global::Org.Apache.Http.Params.IHttpParams @params) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal HttpAbstractParamBean() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		/// <para>This class implements an adaptor around the HttpParams interface to simplify manipulation of the HTTP protocol specific parameters. <br></br> Note that the <b>implements</b> relation to CoreProtocolPNames is for compatibility with existing application code only. References to the parameter names should use the interface, not this class.</para><para><para></para><para></para><title>Revision:</title><para>576089 </para></para><para><para>4.0</para><para>CoreProtocolPNames </para></para>    
		/// </summary>
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

				/// <summary>
				/// <para>Returns the charset to be used for writing HTTP headers. </para>        
				/// </summary>
				/// <returns>
				/// <para>The charset </para>
				/// </returns>
				/// <java-name>
				/// getHttpElementCharset
				/// </java-name>
				[Dot42.DexImport("getHttpElementCharset", "(Lorg/apache/http/params/HttpParams;)Ljava/lang/String;", AccessFlags = 9)]
				public static string GetHttpElementCharset(global::Org.Apache.Http.Params.IHttpParams @params) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Sets the charset to be used for writing HTTP headers. </para>        
				/// </summary>
				/// <java-name>
				/// setHttpElementCharset
				/// </java-name>
				[Dot42.DexImport("setHttpElementCharset", "(Lorg/apache/http/params/HttpParams;Ljava/lang/String;)V", AccessFlags = 9)]
				public static void SetHttpElementCharset(global::Org.Apache.Http.Params.IHttpParams @params, string charset) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the default charset to be used for writing content body, when no charset explicitly specified. </para>        
				/// </summary>
				/// <returns>
				/// <para>The charset </para>
				/// </returns>
				/// <java-name>
				/// getContentCharset
				/// </java-name>
				[Dot42.DexImport("getContentCharset", "(Lorg/apache/http/params/HttpParams;)Ljava/lang/String;", AccessFlags = 9)]
				public static string GetContentCharset(global::Org.Apache.Http.Params.IHttpParams @params) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Sets the default charset to be used for writing content body, when no charset explicitly specified. </para>        
				/// </summary>
				/// <java-name>
				/// setContentCharset
				/// </java-name>
				[Dot42.DexImport("setContentCharset", "(Lorg/apache/http/params/HttpParams;Ljava/lang/String;)V", AccessFlags = 9)]
				public static void SetContentCharset(global::Org.Apache.Http.Params.IHttpParams @params, string charset) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns protocol version to be used per default.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>protocol version </para>
				/// </returns>
				/// <java-name>
				/// getVersion
				/// </java-name>
				[Dot42.DexImport("getVersion", "(Lorg/apache/http/params/HttpParams;)Lorg/apache/http/ProtocolVersion;", AccessFlags = 9)]
				public static global::Org.Apache.Http.ProtocolVersion GetVersion(global::Org.Apache.Http.Params.IHttpParams @params) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.ProtocolVersion);
				}

				/// <summary>
				/// <para>Assigns the protocol version to be used by the HTTP methods that this collection of parameters applies to.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setVersion
				/// </java-name>
				[Dot42.DexImport("setVersion", "(Lorg/apache/http/params/HttpParams;Lorg/apache/http/ProtocolVersion;)V", AccessFlags = 9)]
				public static void SetVersion(global::Org.Apache.Http.Params.IHttpParams @params, global::Org.Apache.Http.ProtocolVersion version) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getUserAgent
				/// </java-name>
				[Dot42.DexImport("getUserAgent", "(Lorg/apache/http/params/HttpParams;)Ljava/lang/String;", AccessFlags = 9)]
				public static string GetUserAgent(global::Org.Apache.Http.Params.IHttpParams @params) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// setUserAgent
				/// </java-name>
				[Dot42.DexImport("setUserAgent", "(Lorg/apache/http/params/HttpParams;Ljava/lang/String;)V", AccessFlags = 9)]
				public static void SetUserAgent(global::Org.Apache.Http.Params.IHttpParams @params, string useragent) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// useExpectContinue
				/// </java-name>
				[Dot42.DexImport("useExpectContinue", "(Lorg/apache/http/params/HttpParams;)Z", AccessFlags = 9)]
				public static bool UseExpectContinue(global::Org.Apache.Http.Params.IHttpParams @params) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setUseExpectContinue
				/// </java-name>
				[Dot42.DexImport("setUseExpectContinue", "(Lorg/apache/http/params/HttpParams;Z)V", AccessFlags = 9)]
				public static void SetUseExpectContinue(global::Org.Apache.Http.Params.IHttpParams @params, bool b) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>This class represents a collection of HTTP protocol parameters. Protocol parameters may be linked together to form a hierarchy. If a particular parameter value has not been explicitly defined in the collection itself, its value will be drawn from the parent collection of parameters.</para><para><para></para><para></para><title>Revision:</title><para>610464 </para></para>    
		/// </summary>
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
				public override object GetParameter(string name) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <java-name>
				/// setParameter
				/// </java-name>
				[Dot42.DexImport("setParameter", "(Ljava/lang/String;Ljava/lang/Object;)Lorg/apache/http/params/HttpParams;", AccessFlags = 1)]
				public override global::Org.Apache.Http.Params.IHttpParams SetParameter(string name, object value) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Params.IHttpParams);
				}

				/// <summary>
				/// <para>Removes the parameter with the specified name.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if the parameter existed and has been removed, false else. </para>
				/// </returns>
				/// <java-name>
				/// removeParameter
				/// </java-name>
				[Dot42.DexImport("removeParameter", "(Ljava/lang/String;)Z", AccessFlags = 1)]
				public override bool RemoveParameter(string name) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Assigns the value to all the parameter with the given names</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setParameters
				/// </java-name>
				[Dot42.DexImport("setParameters", "([Ljava/lang/String;Ljava/lang/Object;)V", AccessFlags = 1)]
				public void SetParameters(string[] names, object value) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isParameterSet
				/// </java-name>
				[Dot42.DexImport("isParameterSet", "(Ljava/lang/String;)Z", AccessFlags = 1)]
				public bool IsParameterSet(string name) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isParameterSetLocally
				/// </java-name>
				[Dot42.DexImport("isParameterSetLocally", "(Ljava/lang/String;)Z", AccessFlags = 1)]
				public bool IsParameterSetLocally(string name) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Removes all parameters from this collection. </para>        
				/// </summary>
				/// <java-name>
				/// clear
				/// </java-name>
				[Dot42.DexImport("clear", "()V", AccessFlags = 1)]
				public void Clear() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a copy of these parameters. The implementation here instantiates BasicHttpParams, then calls copyParams(HttpParams) to populate the copy.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a new set of params holding a copy of the <b>local</b> parameters in this object. </para>
				/// </returns>
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

				/// <summary>
				/// <para>Copies the locally defined parameters to the argument parameters. This method is called from copy().</para><para></para>        
				/// </summary>
				/// <java-name>
				/// copyParams
				/// </java-name>
				[Dot42.DexImport("copyParams", "(Lorg/apache/http/params/HttpParams;)V", AccessFlags = 4)]
				internal void CopyParams(global::Org.Apache.Http.Params.IHttpParams target) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>Represents a collection of HTTP protocol and framework parameters.</para><para><para></para><para></para><title>Revision:</title><para>610763 </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/params/HttpParams
		/// </java-name>
		[Dot42.DexImport("org/apache/http/params/HttpParams", AccessFlags = 1537)]
		public partial interface IHttpParams
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Obtains the value of the given parameter.</para><para><para>setParameter(String, Object) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>an object that represents the value of the parameter, <code>null</code> if the parameter is not set or if it is explicitly set to <code>null</code></para>
				/// </returns>
				/// <java-name>
				/// getParameter
				/// </java-name>
				[Dot42.DexImport("getParameter", "(Ljava/lang/String;)Ljava/lang/Object;", AccessFlags = 1025)]
				object GetParameter(string name) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Assigns the value to the parameter with the given name.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setParameter
				/// </java-name>
				[Dot42.DexImport("setParameter", "(Ljava/lang/String;Ljava/lang/Object;)Lorg/apache/http/params/HttpParams;", AccessFlags = 1025)]
				global::Org.Apache.Http.Params.IHttpParams SetParameter(string name, object value) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Creates a copy of these parameters.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a new set of parameters holding the same values as this one </para>
				/// </returns>
				/// <java-name>
				/// copy
				/// </java-name>
				[Dot42.DexImport("copy", "()Lorg/apache/http/params/HttpParams;", AccessFlags = 1025)]
				global::Org.Apache.Http.Params.IHttpParams Copy() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Removes the parameter with the specified name.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if the parameter existed and has been removed, false else. </para>
				/// </returns>
				/// <java-name>
				/// removeParameter
				/// </java-name>
				[Dot42.DexImport("removeParameter", "(Ljava/lang/String;)Z", AccessFlags = 1025)]
				bool RemoveParameter(string name) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns a Long parameter value with the given name. If the parameter is not explicitly set, the default value is returned.</para><para><para>setLongParameter(String, long) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>a Long that represents the value of the parameter.</para>
				/// </returns>
				/// <java-name>
				/// getLongParameter
				/// </java-name>
				[Dot42.DexImport("getLongParameter", "(Ljava/lang/String;J)J", AccessFlags = 1025)]
				long GetLongParameter(string name, long defaultValue) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Assigns a Long to the parameter with the given name</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setLongParameter
				/// </java-name>
				[Dot42.DexImport("setLongParameter", "(Ljava/lang/String;J)Lorg/apache/http/params/HttpParams;", AccessFlags = 1025)]
				global::Org.Apache.Http.Params.IHttpParams SetLongParameter(string name, long value) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns an Integer parameter value with the given name. If the parameter is not explicitly set, the default value is returned.</para><para><para>setIntParameter(String, int) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>a Integer that represents the value of the parameter.</para>
				/// </returns>
				/// <java-name>
				/// getIntParameter
				/// </java-name>
				[Dot42.DexImport("getIntParameter", "(Ljava/lang/String;I)I", AccessFlags = 1025)]
				int GetIntParameter(string name, int defaultValue) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Assigns an Integer to the parameter with the given name</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setIntParameter
				/// </java-name>
				[Dot42.DexImport("setIntParameter", "(Ljava/lang/String;I)Lorg/apache/http/params/HttpParams;", AccessFlags = 1025)]
				global::Org.Apache.Http.Params.IHttpParams SetIntParameter(string name, int value) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns a Double parameter value with the given name. If the parameter is not explicitly set, the default value is returned.</para><para><para>setDoubleParameter(String, double) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>a Double that represents the value of the parameter.</para>
				/// </returns>
				/// <java-name>
				/// getDoubleParameter
				/// </java-name>
				[Dot42.DexImport("getDoubleParameter", "(Ljava/lang/String;D)D", AccessFlags = 1025)]
				double GetDoubleParameter(string name, double defaultValue) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Assigns a Double to the parameter with the given name</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setDoubleParameter
				/// </java-name>
				[Dot42.DexImport("setDoubleParameter", "(Ljava/lang/String;D)Lorg/apache/http/params/HttpParams;", AccessFlags = 1025)]
				global::Org.Apache.Http.Params.IHttpParams SetDoubleParameter(string name, double value) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns a Boolean parameter value with the given name. If the parameter is not explicitly set, the default value is returned.</para><para><para>setBooleanParameter(String, boolean) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>a Boolean that represents the value of the parameter.</para>
				/// </returns>
				/// <java-name>
				/// getBooleanParameter
				/// </java-name>
				[Dot42.DexImport("getBooleanParameter", "(Ljava/lang/String;Z)Z", AccessFlags = 1025)]
				bool GetBooleanParameter(string name, bool defaultValue) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Assigns a Boolean to the parameter with the given name</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setBooleanParameter
				/// </java-name>
				[Dot42.DexImport("setBooleanParameter", "(Ljava/lang/String;Z)Lorg/apache/http/params/HttpParams;", AccessFlags = 1025)]
				global::Org.Apache.Http.Params.IHttpParams SetBooleanParameter(string name, bool value) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Checks if a boolean parameter is set to <code>true</code>.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> if the parameter is set to value <code>true</code>, <code>false</code> if it is not set or set to <code>false</code> </para>
				/// </returns>
				/// <java-name>
				/// isParameterTrue
				/// </java-name>
				[Dot42.DexImport("isParameterTrue", "(Ljava/lang/String;)Z", AccessFlags = 1025)]
				bool IsParameterTrue(string name) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Checks if a boolean parameter is not set or <code>false</code>.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> if the parameter is either not set or set to value <code>false</code>, <code>false</code> if it is set to <code>true</code> </para>
				/// </returns>
				/// <java-name>
				/// isParameterFalse
				/// </java-name>
				[Dot42.DexImport("isParameterFalse", "(Ljava/lang/String;)Z", AccessFlags = 1025)]
				bool IsParameterFalse(string name) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>An adaptor for accessing connection parameters in HttpParams. <br></br> Note that the <b>implements</b> relation to CoreConnectionPNames is for compatibility with existing application code only. References to the parameter names should use the interface, not this class.</para><para><para></para><para></para><title>Revision:</title><para>576089 </para></para><para><para>4.0 </para></para>    
		/// </summary>
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

				/// <summary>
				/// <para>Returns the default socket timeout (<code>SO_TIMEOUT</code>) in milliseconds which is the timeout for waiting for data. A timeout value of zero is interpreted as an infinite timeout. This value is used when no socket timeout is set in the method parameters.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>timeout in milliseconds </para>
				/// </returns>
				/// <java-name>
				/// getSoTimeout
				/// </java-name>
				[Dot42.DexImport("getSoTimeout", "(Lorg/apache/http/params/HttpParams;)I", AccessFlags = 9)]
				public static int GetSoTimeout(global::Org.Apache.Http.Params.IHttpParams @params) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Sets the default socket timeout (<code>SO_TIMEOUT</code>) in milliseconds which is the timeout for waiting for data. A timeout value of zero is interpreted as an infinite timeout. This value is used when no socket timeout is set in the method parameters.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setSoTimeout
				/// </java-name>
				[Dot42.DexImport("setSoTimeout", "(Lorg/apache/http/params/HttpParams;I)V", AccessFlags = 9)]
				public static void SetSoTimeout(global::Org.Apache.Http.Params.IHttpParams @params, int timeout) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Tests if Nagle's algorithm is to be used.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> if the Nagle's algorithm is to NOT be used (that is enable TCP_NODELAY), <code>false</code> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// getTcpNoDelay
				/// </java-name>
				[Dot42.DexImport("getTcpNoDelay", "(Lorg/apache/http/params/HttpParams;)Z", AccessFlags = 9)]
				public static bool GetTcpNoDelay(global::Org.Apache.Http.Params.IHttpParams @params) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Determines whether Nagle's algorithm is to be used. The Nagle's algorithm tries to conserve bandwidth by minimizing the number of segments that are sent. When applications wish to decrease network latency and increase performance, they can disable Nagle's algorithm (that is enable TCP_NODELAY). Data will be sent earlier, at the cost of an increase in bandwidth consumption.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setTcpNoDelay
				/// </java-name>
				[Dot42.DexImport("setTcpNoDelay", "(Lorg/apache/http/params/HttpParams;Z)V", AccessFlags = 9)]
				public static void SetTcpNoDelay(global::Org.Apache.Http.Params.IHttpParams @params, bool value) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getSocketBufferSize
				/// </java-name>
				[Dot42.DexImport("getSocketBufferSize", "(Lorg/apache/http/params/HttpParams;)I", AccessFlags = 9)]
				public static int GetSocketBufferSize(global::Org.Apache.Http.Params.IHttpParams @params) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// setSocketBufferSize
				/// </java-name>
				[Dot42.DexImport("setSocketBufferSize", "(Lorg/apache/http/params/HttpParams;I)V", AccessFlags = 9)]
				public static void SetSocketBufferSize(global::Org.Apache.Http.Params.IHttpParams @params, int size) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns linger-on-close timeout. Value <code>0</code> implies that the option is disabled. Value <code>-1</code> implies that the JRE default is used.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the linger-on-close timeout </para>
				/// </returns>
				/// <java-name>
				/// getLinger
				/// </java-name>
				[Dot42.DexImport("getLinger", "(Lorg/apache/http/params/HttpParams;)I", AccessFlags = 9)]
				public static int GetLinger(global::Org.Apache.Http.Params.IHttpParams @params) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns linger-on-close timeout. This option disables/enables immediate return from a close() of a TCP Socket. Enabling this option with a non-zero Integer timeout means that a close() will block pending the transmission and acknowledgement of all data written to the peer, at which point the socket is closed gracefully. Value <code>0</code> implies that the option is disabled. Value <code>-1</code> implies that the JRE default is used.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setLinger
				/// </java-name>
				[Dot42.DexImport("setLinger", "(Lorg/apache/http/params/HttpParams;I)V", AccessFlags = 9)]
				public static void SetLinger(global::Org.Apache.Http.Params.IHttpParams @params, int value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the timeout until a connection is etablished. A value of zero means the timeout is not used. The default value is zero.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>timeout in milliseconds. </para>
				/// </returns>
				/// <java-name>
				/// getConnectionTimeout
				/// </java-name>
				[Dot42.DexImport("getConnectionTimeout", "(Lorg/apache/http/params/HttpParams;)I", AccessFlags = 9)]
				public static int GetConnectionTimeout(global::Org.Apache.Http.Params.IHttpParams @params) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Sets the timeout until a connection is etablished. A value of zero means the timeout is not used. The default value is zero.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setConnectionTimeout
				/// </java-name>
				[Dot42.DexImport("setConnectionTimeout", "(Lorg/apache/http/params/HttpParams;I)V", AccessFlags = 9)]
				public static void SetConnectionTimeout(global::Org.Apache.Http.Params.IHttpParams @params, int timeout) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Tests whether stale connection check is to be used. Disabling stale connection check may result in slight performance improvement at the risk of getting an I/O error when executing a request over a connection that has been closed at the server side.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> if stale connection check is to be used, <code>false</code> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isStaleCheckingEnabled
				/// </java-name>
				[Dot42.DexImport("isStaleCheckingEnabled", "(Lorg/apache/http/params/HttpParams;)Z", AccessFlags = 9)]
				public static bool IsStaleCheckingEnabled(global::Org.Apache.Http.Params.IHttpParams @params) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Defines whether stale connection check is to be used. Disabling stale connection check may result in slight performance improvement at the risk of getting an I/O error when executing a request over a connection that has been closed at the server side.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setStaleCheckingEnabled
				/// </java-name>
				[Dot42.DexImport("setStaleCheckingEnabled", "(Lorg/apache/http/params/HttpParams;Z)V", AccessFlags = 9)]
				public static void SetStaleCheckingEnabled(global::Org.Apache.Http.Params.IHttpParams @params, bool value) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>Defines parameter names for protocol execution in HttpCore.</para><para><para></para><title>Revision:</title><para>576077 </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/params/CoreProtocolPNames
		/// </java-name>
		[Dot42.DexImport("org/apache/http/params/CoreProtocolPNames", AccessFlags = 1537, IgnoreFromJava = true, Priority = 1)]
		public static partial class ICoreProtocolPNamesConstants
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Defines the protocol version used per default. </para><para>This parameter expects a value of type org.apache.http.ProtocolVersion. </para>        
				/// </summary>
				/// <java-name>
				/// PROTOCOL_VERSION
				/// </java-name>
				[Dot42.DexImport("PROTOCOL_VERSION", "Ljava/lang/String;", AccessFlags = 25)]
				public const string PROTOCOL_VERSION = "http.protocol.version";
				/// <summary>
				/// <para>Defines the charset to be used for encoding HTTP protocol elements. </para><para>This parameter expects a value of type String. </para>        
				/// </summary>
				/// <java-name>
				/// HTTP_ELEMENT_CHARSET
				/// </java-name>
				[Dot42.DexImport("HTTP_ELEMENT_CHARSET", "Ljava/lang/String;", AccessFlags = 25)]
				public const string HTTP_ELEMENT_CHARSET = "http.protocol.element-charset";
				/// <summary>
				/// <para>Defines the charset to be used per default for encoding content body. </para><para>This parameter expects a value of type String. </para>        
				/// </summary>
				/// <java-name>
				/// HTTP_CONTENT_CHARSET
				/// </java-name>
				[Dot42.DexImport("HTTP_CONTENT_CHARSET", "Ljava/lang/String;", AccessFlags = 25)]
				public const string HTTP_CONTENT_CHARSET = "http.protocol.content-charset";
				/// <summary>
				/// <para>Defines the content of the <code>User-Agent</code> header. </para><para>This parameter expects a value of type String. </para>        
				/// </summary>
				/// <java-name>
				/// USER_AGENT
				/// </java-name>
				[Dot42.DexImport("USER_AGENT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string USER_AGENT = "http.useragent";
				/// <summary>
				/// <para>Defines the content of the <code>Server</code> header. </para><para>This parameter expects a value of type String. </para>        
				/// </summary>
				/// <java-name>
				/// ORIGIN_SERVER
				/// </java-name>
				[Dot42.DexImport("ORIGIN_SERVER", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ORIGIN_SERVER = "http.origin-server";
				/// <summary>
				/// <para>Defines whether responses with an invalid <code>Transfer-Encoding</code> header should be rejected. </para><para>This parameter expects a value of type Boolean. </para>        
				/// </summary>
				/// <java-name>
				/// STRICT_TRANSFER_ENCODING
				/// </java-name>
				[Dot42.DexImport("STRICT_TRANSFER_ENCODING", "Ljava/lang/String;", AccessFlags = 25)]
				public const string STRICT_TRANSFER_ENCODING = "http.protocol.strict-transfer-encoding";
				/// <summary>
				/// <para>Activates 'Expect: 100-continue' handshake for the entity enclosing methods. The purpose of the 'Expect: 100-continue' handshake to allow a client that is sending a request message with a request body to determine if the origin server is willing to accept the request (based on the request headers) before the client sends the request body. </para><para>The use of the 'Expect: 100-continue' handshake can result in noticable peformance improvement for entity enclosing requests (such as POST and PUT) that require the target server's authentication. </para><para>'Expect: 100-continue' handshake should be used with caution, as it may cause problems with HTTP servers and proxies that do not support HTTP/1.1 protocol. </para><para>This parameter expects a value of type Boolean. </para>        
				/// </summary>
				/// <java-name>
				/// USE_EXPECT_CONTINUE
				/// </java-name>
				[Dot42.DexImport("USE_EXPECT_CONTINUE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string USE_EXPECT_CONTINUE = "http.protocol.expect-continue";
				/// <summary>
				/// <para>Defines the maximum period of time in milliseconds the client should spend waiting for a 100-continue response. </para><para>This parameter expects a value of type Integer. </para>        
				/// </summary>
				/// <java-name>
				/// WAIT_FOR_CONTINUE
				/// </java-name>
				[Dot42.DexImport("WAIT_FOR_CONTINUE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string WAIT_FOR_CONTINUE = "http.protocol.wait-for-continue";
		}

		/// <summary>
		/// <para>Defines parameter names for protocol execution in HttpCore.</para><para><para></para><title>Revision:</title><para>576077 </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/params/CoreProtocolPNames
		/// </java-name>
		[Dot42.DexImport("org/apache/http/params/CoreProtocolPNames", AccessFlags = 1537)]
		public partial interface ICoreProtocolPNames
 /* scope: __dot42__ */ 
		{
		}

		/// <java-name>
		/// org/apache/http/params/HttpConnectionParamBean
		/// </java-name>
		[Dot42.DexImport("org/apache/http/params/HttpConnectionParamBean", AccessFlags = 33)]
		public partial class HttpConnectionParamBean : global::Org.Apache.Http.Params.HttpAbstractParamBean
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Lorg/apache/http/params/HttpParams;)V", AccessFlags = 1)]
				public HttpConnectionParamBean(global::Org.Apache.Http.Params.IHttpParams @params) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setSoTimeout
				/// </java-name>
				[Dot42.DexImport("setSoTimeout", "(I)V", AccessFlags = 1)]
				public virtual void SetSoTimeout(int soTimeout) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setTcpNoDelay
				/// </java-name>
				[Dot42.DexImport("setTcpNoDelay", "(Z)V", AccessFlags = 1)]
				public virtual void SetTcpNoDelay(bool tcpNoDelay) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setSocketBufferSize
				/// </java-name>
				[Dot42.DexImport("setSocketBufferSize", "(I)V", AccessFlags = 1)]
				public virtual void SetSocketBufferSize(int socketBufferSize) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setLinger
				/// </java-name>
				[Dot42.DexImport("setLinger", "(I)V", AccessFlags = 1)]
				public virtual void SetLinger(int linger) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setConnectionTimeout
				/// </java-name>
				[Dot42.DexImport("setConnectionTimeout", "(I)V", AccessFlags = 1)]
				public virtual void SetConnectionTimeout(int connectionTimeout) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setStaleCheckingEnabled
				/// </java-name>
				[Dot42.DexImport("setStaleCheckingEnabled", "(Z)V", AccessFlags = 1)]
				public virtual void SetStaleCheckingEnabled(bool staleCheckingEnabled) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal HttpConnectionParamBean() /* TypeBuilder.AddDefaultConstructor */ 
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
				public HttpProtocolParamBean(global::Org.Apache.Http.Params.IHttpParams @params) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setHttpElementCharset
				/// </java-name>
				[Dot42.DexImport("setHttpElementCharset", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetHttpElementCharset(string httpElementCharset) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setContentCharset
				/// </java-name>
				[Dot42.DexImport("setContentCharset", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetContentCharset(string contentCharset) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setVersion
				/// </java-name>
				[Dot42.DexImport("setVersion", "(Lorg/apache/http/HttpVersion;)V", AccessFlags = 1)]
				public virtual void SetVersion(global::Org.Apache.Http.HttpVersion version) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setUserAgent
				/// </java-name>
				[Dot42.DexImport("setUserAgent", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetUserAgent(string userAgent) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setUseExpectContinue
				/// </java-name>
				[Dot42.DexImport("setUseExpectContinue", "(Z)V", AccessFlags = 1)]
				public virtual void SetUseExpectContinue(bool useExpectContinue) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal HttpProtocolParamBean() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		/// <para>Abstract base class for parameter collections. Type specific setters and getters are mapped to the abstract, generic getters and setters.</para><para><para> </para><simplesectsep></simplesectsep><para></para><para></para><title>Revision:</title><para>542224 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/params/AbstractHttpParams
		/// </java-name>
		[Dot42.DexImport("org/apache/http/params/AbstractHttpParams", AccessFlags = 1057)]
		public abstract partial class AbstractHttpParams : global::Org.Apache.Http.Params.IHttpParams
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Instantiates parameters. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal AbstractHttpParams() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getLongParameter
				/// </java-name>
				[Dot42.DexImport("getLongParameter", "(Ljava/lang/String;J)J", AccessFlags = 1)]
				public virtual long GetLongParameter(string name, long defaultValue) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// setLongParameter
				/// </java-name>
				[Dot42.DexImport("setLongParameter", "(Ljava/lang/String;J)Lorg/apache/http/params/HttpParams;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.Params.IHttpParams SetLongParameter(string name, long value) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Params.IHttpParams);
				}

				/// <java-name>
				/// getIntParameter
				/// </java-name>
				[Dot42.DexImport("getIntParameter", "(Ljava/lang/String;I)I", AccessFlags = 1)]
				public virtual int GetIntParameter(string name, int defaultValue) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// setIntParameter
				/// </java-name>
				[Dot42.DexImport("setIntParameter", "(Ljava/lang/String;I)Lorg/apache/http/params/HttpParams;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.Params.IHttpParams SetIntParameter(string name, int value) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Params.IHttpParams);
				}

				/// <java-name>
				/// getDoubleParameter
				/// </java-name>
				[Dot42.DexImport("getDoubleParameter", "(Ljava/lang/String;D)D", AccessFlags = 1)]
				public virtual double GetDoubleParameter(string name, double defaultValue) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <java-name>
				/// setDoubleParameter
				/// </java-name>
				[Dot42.DexImport("setDoubleParameter", "(Ljava/lang/String;D)Lorg/apache/http/params/HttpParams;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.Params.IHttpParams SetDoubleParameter(string name, double value) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Params.IHttpParams);
				}

				/// <java-name>
				/// getBooleanParameter
				/// </java-name>
				[Dot42.DexImport("getBooleanParameter", "(Ljava/lang/String;Z)Z", AccessFlags = 1)]
				public virtual bool GetBooleanParameter(string name, bool defaultValue) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setBooleanParameter
				/// </java-name>
				[Dot42.DexImport("setBooleanParameter", "(Ljava/lang/String;Z)Lorg/apache/http/params/HttpParams;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.Params.IHttpParams SetBooleanParameter(string name, bool value) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Params.IHttpParams);
				}

				/// <java-name>
				/// isParameterTrue
				/// </java-name>
				[Dot42.DexImport("isParameterTrue", "(Ljava/lang/String;)Z", AccessFlags = 1)]
				public virtual bool IsParameterTrue(string name) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isParameterFalse
				/// </java-name>
				[Dot42.DexImport("isParameterFalse", "(Ljava/lang/String;)Z", AccessFlags = 1)]
				public virtual bool IsParameterFalse(string name) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("org/apache/http/params/HttpParams", "getParameter", "(Ljava/lang/String;)Ljava/lang/Object;", AccessFlags = 1025)]
				public virtual object GetParameter(string name) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(object);
				}

				[Dot42.DexImport("org/apache/http/params/HttpParams", "setParameter", "(Ljava/lang/String;Ljava/lang/Object;)Lorg/apache/http/params/HttpParams;", AccessFlags = 1025)]
				public virtual global::Org.Apache.Http.Params.IHttpParams SetParameter(string name, object value) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Org.Apache.Http.Params.IHttpParams);
				}

				[Dot42.DexImport("org/apache/http/params/HttpParams", "copy", "()Lorg/apache/http/params/HttpParams;", AccessFlags = 1025)]
				public virtual global::Org.Apache.Http.Params.IHttpParams Copy() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Org.Apache.Http.Params.IHttpParams);
				}

				[Dot42.DexImport("org/apache/http/params/HttpParams", "removeParameter", "(Ljava/lang/String;)Z", AccessFlags = 1025)]
				public virtual bool RemoveParameter(string name) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

		}

		/// <summary>
		/// <para>Defines parameter names for connections in HttpCore.</para><para><para></para><title>Revision:</title><para>576077 </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/params/CoreConnectionPNames
		/// </java-name>
		[Dot42.DexImport("org/apache/http/params/CoreConnectionPNames", AccessFlags = 1537, IgnoreFromJava = true, Priority = 1)]
		public static partial class ICoreConnectionPNamesConstants
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Defines the default socket timeout (<code>SO_TIMEOUT</code>) in milliseconds which is the timeout for waiting for data. A timeout value of zero is interpreted as an infinite timeout. This value is used when no socket timeout is set in the method parameters. </para><para>This parameter expects a value of type Integer. </para><para><para>java.net.SocketOptions::SO_TIMEOUT </para></para>        
				/// </summary>
				/// <java-name>
				/// SO_TIMEOUT
				/// </java-name>
				[Dot42.DexImport("SO_TIMEOUT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SO_TIMEOUT = "http.socket.timeout";
				/// <summary>
				/// <para>Determines whether Nagle's algorithm is to be used. The Nagle's algorithm tries to conserve bandwidth by minimizing the number of segments that are sent. When applications wish to decrease network latency and increase performance, they can disable Nagle's algorithm (that is enable TCP_NODELAY). Data will be sent earlier, at the cost of an increase in bandwidth consumption. </para><para>This parameter expects a value of type Boolean. </para><para><para>java.net.SocketOptions::TCP_NODELAY </para></para>        
				/// </summary>
				/// <java-name>
				/// TCP_NODELAY
				/// </java-name>
				[Dot42.DexImport("TCP_NODELAY", "Ljava/lang/String;", AccessFlags = 25)]
				public const string TCP_NODELAY = "http.tcp.nodelay";
				/// <summary>
				/// <para>Determines the size of the internal socket buffer used to buffer data while receiving / transmitting HTTP messages. </para><para>This parameter expects a value of type Integer. </para>        
				/// </summary>
				/// <java-name>
				/// SOCKET_BUFFER_SIZE
				/// </java-name>
				[Dot42.DexImport("SOCKET_BUFFER_SIZE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SOCKET_BUFFER_SIZE = "http.socket.buffer-size";
				/// <summary>
				/// <para>Sets SO_LINGER with the specified linger time in seconds. The maximum timeout value is platform specific. Value <code>0</code> implies that the option is disabled. Value <code>-1</code> implies that the JRE default is used. The setting only affects socket close. </para><para>This parameter expects a value of type Integer. </para><para><para>java.net.SocketOptions::SO_LINGER </para></para>        
				/// </summary>
				/// <java-name>
				/// SO_LINGER
				/// </java-name>
				[Dot42.DexImport("SO_LINGER", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SO_LINGER = "http.socket.linger";
				/// <summary>
				/// <para>Determines the timeout until a connection is etablished. A value of zero means the timeout is not used. The default value is zero. </para><para>This parameter expects a value of type Integer. </para>        
				/// </summary>
				/// <java-name>
				/// CONNECTION_TIMEOUT
				/// </java-name>
				[Dot42.DexImport("CONNECTION_TIMEOUT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string CONNECTION_TIMEOUT = "http.connection.timeout";
				/// <summary>
				/// <para>Determines whether stale connection check is to be used. Disabling stale connection check may result in slight performance improvement at the risk of getting an I/O error when executing a request over a connection that has been closed at the server side. </para><para>This parameter expects a value of type Boolean. </para>        
				/// </summary>
				/// <java-name>
				/// STALE_CONNECTION_CHECK
				/// </java-name>
				[Dot42.DexImport("STALE_CONNECTION_CHECK", "Ljava/lang/String;", AccessFlags = 25)]
				public const string STALE_CONNECTION_CHECK = "http.connection.stalecheck";
				/// <summary>
				/// <para>Determines the maximum line length limit. If set to a positive value, any HTTP line exceeding this limit will cause an IOException. A negative or zero value will effectively disable the check. </para><para>This parameter expects a value of type Integer. </para>        
				/// </summary>
				/// <java-name>
				/// MAX_LINE_LENGTH
				/// </java-name>
				[Dot42.DexImport("MAX_LINE_LENGTH", "Ljava/lang/String;", AccessFlags = 25)]
				public const string MAX_LINE_LENGTH = "http.connection.max-line-length";
				/// <summary>
				/// <para>Determines the maximum HTTP header count allowed. If set to a positive value, the number of HTTP headers received from the data stream exceeding this limit will cause an IOException. A negative or zero value will effectively disable the check. </para><para>This parameter expects a value of type Integer. </para>        
				/// </summary>
				/// <java-name>
				/// MAX_HEADER_COUNT
				/// </java-name>
				[Dot42.DexImport("MAX_HEADER_COUNT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string MAX_HEADER_COUNT = "http.connection.max-header-count";
		}

		/// <summary>
		/// <para>Defines parameter names for connections in HttpCore.</para><para><para></para><title>Revision:</title><para>576077 </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/params/CoreConnectionPNames
		/// </java-name>
		[Dot42.DexImport("org/apache/http/params/CoreConnectionPNames", AccessFlags = 1537)]
		public partial interface ICoreConnectionPNames
 /* scope: __dot42__ */ 
		{
		}

}


