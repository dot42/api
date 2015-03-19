// Copyright (C) 2014 dot42
//
// Original filename: Org.Apache.Http.Client.Utils.cs
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
namespace Org.Apache.Http.Client.Utils
{
		/// <summary>
		/// <para>A collection of utilities for URIs, to workaround bugs within the class or for ease-of-use features. </para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/client/utils/URIUtils
		/// </java-name>
		[Dot42.DexImport("org/apache/http/client/utils/URIUtils", AccessFlags = 33)]
		public partial class URIUtils
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>This class should not be instantiated. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal URIUtils() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a URI using all the parameters. This should be used instead of URI#URI(String, String, String, int, String, String, String) or any of the other URI multi-argument URI constructors.</para><para>See  for more information.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// createURI
				/// </java-name>
				[Dot42.DexImport("createURI", "(Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;Ljava/l" +
    "ang/String;)Ljava/net/URI;", AccessFlags = 9)]
				public static global::System.Uri CreateURI(string scheme, string host, int port, string path, string query, string fragment) /* MethodBuilder.Create */ 
				{
						return default(global::System.Uri);
				}

				/// <summary>
				/// <para>A convenience method for creating a new URI whose scheme, host and port are taken from the target host, but whose path, query and fragment are taken from the existing URI. The fragment is only used if dropFragment is false.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// rewriteURI
				/// </java-name>
				[Dot42.DexImport("rewriteURI", "(Ljava/net/URI;Lorg/apache/http/HttpHost;Z)Ljava/net/URI;", AccessFlags = 9)]
				public static global::System.Uri RewriteURI(global::System.Uri uri, global::Org.Apache.Http.HttpHost target, bool dropFragment) /* MethodBuilder.Create */ 
				{
						return default(global::System.Uri);
				}

				/// <summary>
				/// <para>A convenience method for URIUtils#rewriteURI(URI, HttpHost, boolean) that always keeps the fragment. </para>        
				/// </summary>
				/// <java-name>
				/// rewriteURI
				/// </java-name>
				[Dot42.DexImport("rewriteURI", "(Ljava/net/URI;Lorg/apache/http/HttpHost;)Ljava/net/URI;", AccessFlags = 9)]
				public static global::System.Uri RewriteURI(global::System.Uri uri, global::Org.Apache.Http.HttpHost target) /* MethodBuilder.Create */ 
				{
						return default(global::System.Uri);
				}

				/// <summary>
				/// <para>Resolves a URI reference against a base URI. Work-around for bug in java.net.URI ()</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the resulting URI </para>
				/// </returns>
				/// <java-name>
				/// resolve
				/// </java-name>
				[Dot42.DexImport("resolve", "(Ljava/net/URI;Ljava/lang/String;)Ljava/net/URI;", AccessFlags = 9)]
				public static global::System.Uri Resolve(global::System.Uri baseURI, string reference) /* MethodBuilder.Create */ 
				{
						return default(global::System.Uri);
				}

				/// <summary>
				/// <para>Resolves a URI reference against a base URI. Work-around for bug in java.net.URI ()</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the resulting URI </para>
				/// </returns>
				/// <java-name>
				/// resolve
				/// </java-name>
				[Dot42.DexImport("resolve", "(Ljava/net/URI;Ljava/net/URI;)Ljava/net/URI;", AccessFlags = 9)]
				public static global::System.Uri Resolve(global::System.Uri baseURI, global::System.Uri reference) /* MethodBuilder.Create */ 
				{
						return default(global::System.Uri);
				}

		}

		/// <summary>
		/// <para>A collection of utilities to workaround limitations of Java clone framework. </para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/client/utils/CloneUtils
		/// </java-name>
		[Dot42.DexImport("org/apache/http/client/utils/CloneUtils", AccessFlags = 33)]
		public partial class CloneUtils
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>This class should not be instantiated. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal CloneUtils() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "(Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 9)]
				public static object Clone(object obj) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

		}

		/// <summary>
		/// <para>A collection of utilities for encoding URLs. </para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/client/utils/URLEncodedUtils
		/// </java-name>
		[Dot42.DexImport("org/apache/http/client/utils/URLEncodedUtils", AccessFlags = 33)]
		public partial class URLEncodedUtils
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// CONTENT_TYPE
				/// </java-name>
				[Dot42.DexImport("CONTENT_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string CONTENT_TYPE = "application/x-www-form-urlencoded";
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public URLEncodedUtils() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns a list of NameValuePairs as built from the URI's query portion. For example, a URI of  would return a list of three NameValuePairs, one for a=1, one for b=2, and one for c=3. </para><para>This is typically useful while parsing an HTTP PUT.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// parse
				/// </java-name>
				[Dot42.DexImport("parse", "(Ljava/net/URI;Ljava/lang/String;)Ljava/util/List;", AccessFlags = 9, Signature = "(Ljava/net/URI;Ljava/lang/String;)Ljava/util/List<Lorg/apache/http/NameValuePair;" +
    ">;")]
				public static global::Java.Util.IList<global::Org.Apache.Http.INameValuePair> Parse(global::System.Uri uri, string encoding) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<global::Org.Apache.Http.INameValuePair>);
				}

				/// <summary>
				/// <para>Returns a list of NameValuePairs as parsed from an HttpEntity. The encoding is taken from the entity's Content-Encoding header. </para><para>This is typically used while parsing an HTTP POST.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// parse
				/// </java-name>
				[Dot42.DexImport("parse", "(Lorg/apache/http/HttpEntity;)Ljava/util/List;", AccessFlags = 9, Signature = "(Lorg/apache/http/HttpEntity;)Ljava/util/List<Lorg/apache/http/NameValuePair;>;")]
				public static global::Java.Util.IList<global::Org.Apache.Http.INameValuePair> Parse(global::Org.Apache.Http.IHttpEntity entity) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<global::Org.Apache.Http.INameValuePair>);
				}

				/// <summary>
				/// <para>Returns true if the entity's Content-Type header is <code>application/x-www-form-urlencoded</code>. </para>        
				/// </summary>
				/// <java-name>
				/// isEncoded
				/// </java-name>
				[Dot42.DexImport("isEncoded", "(Lorg/apache/http/HttpEntity;)Z", AccessFlags = 9)]
				public static bool IsEncoded(global::Org.Apache.Http.IHttpEntity entity) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Adds all parameters within the Scanner to the list of <code>parameters</code>, as encoded by <code>encoding</code>. For example, a scanner containing the string <code>a=1&amp;b=2&amp;c=3</code> would add the NameValuePairs a=1, b=2, and c=3 to the list of parameters.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// parse
				/// </java-name>
				[Dot42.DexImport("parse", "(Ljava/util/List;Ljava/util/Scanner;Ljava/lang/String;)V", AccessFlags = 9, Signature = "(Ljava/util/List<Lorg/apache/http/NameValuePair;>;Ljava/util/Scanner;Ljava/lang/S" +
    "tring;)V")]
				public static void Parse(global::Java.Util.IList<global::Org.Apache.Http.INameValuePair> parameters, global::Java.Util.Scanner scanner, string encoding) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns a String that is suitable for use as an <code>application/x-www-form-urlencoded</code> list of parameters in an HTTP PUT or HTTP POST.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// format
				/// </java-name>
				[Dot42.DexImport("format", "(Ljava/util/List;Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 9, Signature = "(Ljava/util/List<+Lorg/apache/http/NameValuePair;>;Ljava/lang/String;)Ljava/lang/" +
    "String;")]
				public static string Format(global::Java.Util.IList<global::Org.Apache.Http.INameValuePair> parameters, string encoding) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

		}

}


