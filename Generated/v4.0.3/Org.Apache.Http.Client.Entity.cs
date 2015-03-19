// Copyright (C) 2014 dot42
//
// Original filename: Org.Apache.Http.Client.Entity.cs
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
namespace Org.Apache.Http.Client.Entity
{
		/// <summary>
		/// <para>An entity composed of a list of url-encoded pairs. This is typically useful while sending an HTTP POST request. </para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/client/entity/UrlEncodedFormEntity
		/// </java-name>
		[Dot42.DexImport("org/apache/http/client/entity/UrlEncodedFormEntity", AccessFlags = 33)]
		public partial class UrlEncodedFormEntity : global::Org.Apache.Http.Entity.StringEntity
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs a new UrlEncodedFormEntity with the list of parameters in the specified encoding.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/util/List;Ljava/lang/String;)V", AccessFlags = 1, Signature = "(Ljava/util/List<+Lorg/apache/http/NameValuePair;>;Ljava/lang/String;)V")]
				public UrlEncodedFormEntity(global::Java.Util.IList<global::Org.Apache.Http.INameValuePair> parameters, string encoding) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a new UrlEncodedFormEntity with the list of parameters with the default encoding of HTTP#DEFAULT_CONTENT_CHARSET</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/util/List;)V", AccessFlags = 1, Signature = "(Ljava/util/List<+Lorg/apache/http/NameValuePair;>;)V")]
				public UrlEncodedFormEntity(global::Java.Util.IList<global::Org.Apache.Http.INameValuePair> parameters) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal UrlEncodedFormEntity() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

}


