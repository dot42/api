// Copyright (C) 2014 dot42
//
// Original filename: Org.Apache.Http.Auth.Params.cs
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
namespace Org.Apache.Http.Auth.Params
{
		/// <summary>
		/// <para>Parameter names for HttpAuth.</para><para><para></para><title>Revision:</title><para>578403 </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/auth/params/AuthPNames
		/// </java-name>
		[Dot42.DexImport("org/apache/http/auth/params/AuthPNames", AccessFlags = 1537, IgnoreFromJava = true, Priority = 1)]
		public static partial class IAuthPNamesConstants
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Defines the charset to be used when encoding org.apache.http.auth.Credentials. </para><para>This parameter expects a value of type String. If not defined, then HttpProtocolParams.HTTP_ELEMENT_CHARSET should be used. </para>        
				/// </summary>
				/// <java-name>
				/// CREDENTIAL_CHARSET
				/// </java-name>
				[Dot42.DexImport("CREDENTIAL_CHARSET", "Ljava/lang/String;", AccessFlags = 25)]
				public const string CREDENTIAL_CHARSET = "http.auth.credential-charset";
		}

		/// <summary>
		/// <para>Parameter names for HttpAuth.</para><para><para></para><title>Revision:</title><para>578403 </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/auth/params/AuthPNames
		/// </java-name>
		[Dot42.DexImport("org/apache/http/auth/params/AuthPNames", AccessFlags = 1537)]
		public partial interface IAuthPNames
 /* scope: __dot42__ */ 
		{
		}

		/// <summary>
		/// <para>This class implements an adaptor around the HttpParams interface to simplify manipulation of the HTTP authentication specific parameters.</para><para><para></para><para></para><title>Revision:</title><para>618365 </para></para><para><para>4.0</para><para>AuthPNames </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/auth/params/AuthParams
		/// </java-name>
		[Dot42.DexImport("org/apache/http/auth/params/AuthParams", AccessFlags = 49)]
		public sealed partial class AuthParams
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal AuthParams() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Obtains the charset for encoding org.apache.http.auth.Credentials. If not configured, HTTP.DEFAULT_PROTOCOL_CHARSET is used instead.</para><para><para>AuthPNames::CREDENTIAL_CHARSET </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The charset</para>
				/// </returns>
				/// <java-name>
				/// getCredentialCharset
				/// </java-name>
				[Dot42.DexImport("getCredentialCharset", "(Lorg/apache/http/params/HttpParams;)Ljava/lang/String;", AccessFlags = 9)]
				public static string GetCredentialCharset(global::Org.Apache.Http.Params.IHttpParams @params) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Sets the charset to be used when encoding org.apache.http.auth.Credentials.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setCredentialCharset
				/// </java-name>
				[Dot42.DexImport("setCredentialCharset", "(Lorg/apache/http/params/HttpParams;Ljava/lang/String;)V", AccessFlags = 9)]
				public static void SetCredentialCharset(global::Org.Apache.Http.Params.IHttpParams @params, string charset) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// org/apache/http/auth/params/AuthParamBean
		/// </java-name>
		[Dot42.DexImport("org/apache/http/auth/params/AuthParamBean", AccessFlags = 33)]
		public partial class AuthParamBean : global::Org.Apache.Http.Params.HttpAbstractParamBean
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Lorg/apache/http/params/HttpParams;)V", AccessFlags = 1)]
				public AuthParamBean(global::Org.Apache.Http.Params.IHttpParams @params) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setCredentialCharset
				/// </java-name>
				[Dot42.DexImport("setCredentialCharset", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetCredentialCharset(string charset) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal AuthParamBean() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

}


