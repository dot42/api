// Copyright (C) 2014 dot42
//
// Original filename: Org.Apache.Http.Cookie.Params.cs
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
namespace Org.Apache.Http.Cookie.Params
{
		/// <java-name>
		/// org/apache/http/cookie/params/CookieSpecParamBean
		/// </java-name>
		[Dot42.DexImport("org/apache/http/cookie/params/CookieSpecParamBean", AccessFlags = 33)]
		public partial class CookieSpecParamBean : global::Org.Apache.Http.Params.HttpAbstractParamBean
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Lorg/apache/http/params/HttpParams;)V", AccessFlags = 1)]
				public CookieSpecParamBean(global::Org.Apache.Http.Params.IHttpParams @params) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setDatePatterns
				/// </java-name>
				[Dot42.DexImport("setDatePatterns", "(Ljava/util/Collection;)V", AccessFlags = 1, Signature = "(Ljava/util/Collection<Ljava/lang/String;>;)V")]
				public virtual void SetDatePatterns(global::Java.Util.ICollection<string> patterns) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setSingleHeader
				/// </java-name>
				[Dot42.DexImport("setSingleHeader", "(Z)V", AccessFlags = 1)]
				public virtual void SetSingleHeader(bool singleHeader) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal CookieSpecParamBean() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		/// <para>Parameter names for cookie specifications in HttpCookie.</para><para><para></para><para></para><title>Revision:</title><para>578403 </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/cookie/params/CookieSpecPNames
		/// </java-name>
		[Dot42.DexImport("org/apache/http/cookie/params/CookieSpecPNames", AccessFlags = 1537, IgnoreFromJava = true, Priority = 1)]
		public static partial class ICookieSpecPNamesConstants
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Parameter for the date patterns used for parsing. </para><para>This parameter expects a value of type java.util.Collection. The collection elements are of type String and must be compatible with the syntax of java.text.SimpleDateFormat. </para>        
				/// </summary>
				/// <java-name>
				/// DATE_PATTERNS
				/// </java-name>
				[Dot42.DexImport("DATE_PATTERNS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string DATE_PATTERNS = "http.protocol.cookie-datepatterns";
				/// <summary>
				/// <para>Parameter for Cookie header formatting. Defines whether cookies should be put on a single request header. If not, each cookie is formatted in a seperate Cookie header. </para><para>This parameter expects a value of type Boolean. </para>        
				/// </summary>
				/// <java-name>
				/// SINGLE_COOKIE_HEADER
				/// </java-name>
				[Dot42.DexImport("SINGLE_COOKIE_HEADER", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SINGLE_COOKIE_HEADER = "http.protocol.single-cookie-header";
		}

		/// <summary>
		/// <para>Parameter names for cookie specifications in HttpCookie.</para><para><para></para><para></para><title>Revision:</title><para>578403 </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/cookie/params/CookieSpecPNames
		/// </java-name>
		[Dot42.DexImport("org/apache/http/cookie/params/CookieSpecPNames", AccessFlags = 1537)]
		public partial interface ICookieSpecPNames
 /* scope: __dot42__ */ 
		{
		}

}


