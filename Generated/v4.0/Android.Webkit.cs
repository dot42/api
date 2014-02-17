// Copyright (C) 2014 dot42
//
// Original filename: Android.Webkit.cs
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
namespace Android.Webkit
{
		/// <summary>
		/// <para>Manages the HTTP cache used by an application's WebView instances. <xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>Access to the HTTP cache will be removed in a future release.  Since android.os.Build.VERSION_CODES#JELLY_BEAN_MR1 </para></xrefdescription></xrefsect></para>    
		/// </summary>
		/// <java-name>
		/// android/webkit/CacheManager
		/// </java-name>
		[Dot42.DexImport("android/webkit/CacheManager", AccessFlags = 49)]
		public sealed partial class CacheManager
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public CacheManager() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets the base directory in which the files used to store the contents of cache entries are placed. See CacheManager.CacheResult.getLocalPath().</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>This method no longer has any effect and always returns null. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				/// <para>the base directory of the cache </para>
				/// </returns>
				/// <java-name>
				/// getCacheFileBaseDir
				/// </java-name>
				[Dot42.DexImport("getCacheFileBaseDir", "()Ljava/io/File;", AccessFlags = 9)]
				public static global::Java.Io.File GetCacheFileBaseDir() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.File);
				}

				/// <summary>
				/// <para>Gets whether the HTTP cache is disabled.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>This method no longer has any effect and always returns false. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				/// <para>true if the HTTP cache is disabled </para>
				/// </returns>
				/// <java-name>
				/// cacheDisabled
				/// </java-name>
				[Dot42.DexImport("cacheDisabled", "()Z", AccessFlags = 9)]
				public static bool CacheDisabled() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Starts a cache transaction. Returns true if this is the only running transaction. Otherwise, this transaction is nested inside currently running transactions and false is returned.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>This method no longer has any effect and always returns false. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				/// <para>true if this is the only running transaction </para>
				/// </returns>
				/// <java-name>
				/// startCacheTransaction
				/// </java-name>
				[Dot42.DexImport("startCacheTransaction", "()Z", AccessFlags = 9)]
				public static bool StartCacheTransaction() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Ends the innermost cache transaction and returns whether this was the only running transaction.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>This method no longer has any effect and always returns false. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				/// <para>true if this was the only running transaction </para>
				/// </returns>
				/// <java-name>
				/// endCacheTransaction
				/// </java-name>
				[Dot42.DexImport("endCacheTransaction", "()Z", AccessFlags = 9)]
				public static bool EndCacheTransaction() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Gets the cache entry for the specified URL, or null if none is found. If a non-null value is provided for the HTTP headers map, and the cache entry needs validation, appropriate headers will be added to the map. The input stream of the CacheEntry object should be closed by the caller when access to the underlying file is no longer required.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>This method no longer has any effect and always returns null. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				/// <para>the cache entry for the specified URL </para>
				/// </returns>
				/// <java-name>
				/// getCacheFile
				/// </java-name>
				[Dot42.DexImport("getCacheFile", "(Ljava/lang/String;Ljava/util/Map;)Landroid/webkit/CacheManager$CacheResult;", AccessFlags = 9, Signature = "(Ljava/lang/String;Ljava/util/Map<Ljava/lang/String;Ljava/lang/String;>;)Landroid" +
    "/webkit/CacheManager$CacheResult;")]
				public static global::Android.Webkit.CacheManager.CacheResult GetCacheFile(string url, global::Java.Util.IMap<string, string> headers) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Webkit.CacheManager.CacheResult);
				}

				/// <summary>
				/// <para>Adds a cache entry to the HTTP cache for the specicifed URL. Also closes the cache entry's output stream.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>Access to the HTTP cache will be removed in a future release. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// saveCacheFile
				/// </java-name>
				[Dot42.DexImport("saveCacheFile", "(Ljava/lang/String;Landroid/webkit/CacheManager$CacheResult;)V", AccessFlags = 9)]
				public static void SaveCacheFile(string url, global::Android.Webkit.CacheManager.CacheResult cacheResult) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets the base directory in which the files used to store the contents of cache entries are placed. See CacheManager.CacheResult.getLocalPath().</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>This method no longer has any effect and always returns null. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				/// <para>the base directory of the cache </para>
				/// </returns>
				/// <java-name>
				/// getCacheFileBaseDir
				/// </java-name>
				public static global::Java.Io.File CacheFileBaseDir
				{
				[Dot42.DexImport("getCacheFileBaseDir", "()Ljava/io/File;", AccessFlags = 9)]
						get{ return GetCacheFileBaseDir(); }
				}

				/// <summary>
				/// <para>Represents a resource stored in the HTTP cache. Instances of this class can be obtained by calling CacheManager.getCacheFile(String, Map&lt;String, String&gt;)).</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>Access to the HTTP cache will be removed in a future release. </para></xrefdescription></xrefsect></para>    
				/// </summary>
				/// <java-name>
				/// android/webkit/CacheManager$CacheResult
				/// </java-name>
				[Dot42.DexImport("android/webkit/CacheManager$CacheResult", AccessFlags = 9)]
				public partial class CacheResult
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public CacheResult() /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						/// <para>Gets the status code of this cache entry.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>the status code of this cache entry </para>
						/// </returns>
						/// <java-name>
						/// getHttpStatusCode
						/// </java-name>
						[Dot42.DexImport("getHttpStatusCode", "()I", AccessFlags = 1)]
						public virtual int GetHttpStatusCode() /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <summary>
						/// <para>Gets the content length of this cache entry.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>the content length of this cache entry </para>
						/// </returns>
						/// <java-name>
						/// getContentLength
						/// </java-name>
						[Dot42.DexImport("getContentLength", "()J", AccessFlags = 1)]
						public virtual long GetContentLength() /* MethodBuilder.Create */ 
						{
								return default(long);
						}

						/// <summary>
						/// <para>Gets the path of the file used to store the content of this cache entry, relative to the base directory of the cache. See CacheManager.getCacheFileBaseDir().</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>the path of the file used to store this cache entry </para>
						/// </returns>
						/// <java-name>
						/// getLocalPath
						/// </java-name>
						[Dot42.DexImport("getLocalPath", "()Ljava/lang/String;", AccessFlags = 1)]
						public virtual string GetLocalPath() /* MethodBuilder.Create */ 
						{
								return default(string);
						}

						/// <summary>
						/// <para>Gets the expiry date of this cache entry, expressed in milliseconds since midnight, January 1, 1970 UTC.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>the expiry date of this cache entry </para>
						/// </returns>
						/// <java-name>
						/// getExpires
						/// </java-name>
						[Dot42.DexImport("getExpires", "()J", AccessFlags = 1)]
						public virtual long GetExpires() /* MethodBuilder.Create */ 
						{
								return default(long);
						}

						/// <summary>
						/// <para>Gets the expiry date of this cache entry, expressed as a string.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>the expiry date of this cache entry </para>
						/// </returns>
						/// <java-name>
						/// getExpiresString
						/// </java-name>
						[Dot42.DexImport("getExpiresString", "()Ljava/lang/String;", AccessFlags = 1)]
						public virtual string GetExpiresString() /* MethodBuilder.Create */ 
						{
								return default(string);
						}

						/// <summary>
						/// <para>Gets the date at which this cache entry was last modified, expressed as a string.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>the date at which this cache entry was last modified </para>
						/// </returns>
						/// <java-name>
						/// getLastModified
						/// </java-name>
						[Dot42.DexImport("getLastModified", "()Ljava/lang/String;", AccessFlags = 1)]
						public virtual string GetLastModified() /* MethodBuilder.Create */ 
						{
								return default(string);
						}

						/// <summary>
						/// <para>Gets the entity tag of this cache entry.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>the entity tag of this cache entry </para>
						/// </returns>
						/// <java-name>
						/// getETag
						/// </java-name>
						[Dot42.DexImport("getETag", "()Ljava/lang/String;", AccessFlags = 1)]
						public virtual string GetETag() /* MethodBuilder.Create */ 
						{
								return default(string);
						}

						/// <summary>
						/// <para>Gets the MIME type of this cache entry.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>the MIME type of this cache entry </para>
						/// </returns>
						/// <java-name>
						/// getMimeType
						/// </java-name>
						[Dot42.DexImport("getMimeType", "()Ljava/lang/String;", AccessFlags = 1)]
						public virtual string GetMimeType() /* MethodBuilder.Create */ 
						{
								return default(string);
						}

						/// <summary>
						/// <para>Gets the value of the HTTP 'Location' header with which this cache entry was received.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>the HTTP 'Location' header for this cache entry </para>
						/// </returns>
						/// <java-name>
						/// getLocation
						/// </java-name>
						[Dot42.DexImport("getLocation", "()Ljava/lang/String;", AccessFlags = 1)]
						public virtual string GetLocation() /* MethodBuilder.Create */ 
						{
								return default(string);
						}

						/// <summary>
						/// <para>Gets the encoding of this cache entry.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>the encoding of this cache entry </para>
						/// </returns>
						/// <java-name>
						/// getEncoding
						/// </java-name>
						[Dot42.DexImport("getEncoding", "()Ljava/lang/String;", AccessFlags = 1)]
						public virtual string GetEncoding() /* MethodBuilder.Create */ 
						{
								return default(string);
						}

						/// <summary>
						/// <para>Gets the value of the HTTP 'Content-Disposition' header with which this cache entry was received.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>the HTTP 'Content-Disposition' header for this cache entry </para>
						/// </returns>
						/// <java-name>
						/// getContentDisposition
						/// </java-name>
						[Dot42.DexImport("getContentDisposition", "()Ljava/lang/String;", AccessFlags = 1)]
						public virtual string GetContentDisposition() /* MethodBuilder.Create */ 
						{
								return default(string);
						}

						/// <summary>
						/// <para>Gets the input stream to the content of this cache entry, to allow content to be read. See CacheManager.getCacheFile(String, Map&lt;String, String&gt;).</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>an input stream to the content of this cache entry </para>
						/// </returns>
						/// <java-name>
						/// getInputStream
						/// </java-name>
						[Dot42.DexImport("getInputStream", "()Ljava/io/InputStream;", AccessFlags = 1)]
						public virtual global::Java.Io.InputStream GetInputStream() /* MethodBuilder.Create */ 
						{
								return default(global::Java.Io.InputStream);
						}

						/// <summary>
						/// <para>Gets an output stream to the content of this cache entry, to allow content to be written. See CacheManager.saveCacheFile(String, CacheResult).</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>an output stream to the content of this cache entry </para>
						/// </returns>
						/// <java-name>
						/// getOutputStream
						/// </java-name>
						[Dot42.DexImport("getOutputStream", "()Ljava/io/OutputStream;", AccessFlags = 1)]
						public virtual global::Java.Io.OutputStream GetOutputStream() /* MethodBuilder.Create */ 
						{
								return default(global::Java.Io.OutputStream);
						}

						/// <summary>
						/// <para>Sets an input stream to the content of this cache entry.</para><para></para>        
						/// </summary>
						/// <java-name>
						/// setInputStream
						/// </java-name>
						[Dot42.DexImport("setInputStream", "(Ljava/io/InputStream;)V", AccessFlags = 1)]
						public virtual void SetInputStream(global::Java.Io.InputStream stream) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						/// <para>Sets the encoding of this cache entry.</para><para></para>        
						/// </summary>
						/// <java-name>
						/// setEncoding
						/// </java-name>
						[Dot42.DexImport("setEncoding", "(Ljava/lang/String;)V", AccessFlags = 1)]
						public virtual void SetEncoding(string encoding) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						/// <para>Gets the status code of this cache entry.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>the status code of this cache entry </para>
						/// </returns>
						/// <java-name>
						/// getHttpStatusCode
						/// </java-name>
						public int HttpStatusCode
						{
						[Dot42.DexImport("getHttpStatusCode", "()I", AccessFlags = 1)]
								get{ return GetHttpStatusCode(); }
						}

						/// <summary>
						/// <para>Gets the content length of this cache entry.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>the content length of this cache entry </para>
						/// </returns>
						/// <java-name>
						/// getContentLength
						/// </java-name>
						public long ContentLength
						{
						[Dot42.DexImport("getContentLength", "()J", AccessFlags = 1)]
								get{ return GetContentLength(); }
						}

						/// <summary>
						/// <para>Gets the path of the file used to store the content of this cache entry, relative to the base directory of the cache. See CacheManager.getCacheFileBaseDir().</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>the path of the file used to store this cache entry </para>
						/// </returns>
						/// <java-name>
						/// getLocalPath
						/// </java-name>
						public string LocalPath
						{
						[Dot42.DexImport("getLocalPath", "()Ljava/lang/String;", AccessFlags = 1)]
								get{ return GetLocalPath(); }
						}

						/// <summary>
						/// <para>Gets the expiry date of this cache entry, expressed in milliseconds since midnight, January 1, 1970 UTC.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>the expiry date of this cache entry </para>
						/// </returns>
						/// <java-name>
						/// getExpires
						/// </java-name>
						public long Expires
						{
						[Dot42.DexImport("getExpires", "()J", AccessFlags = 1)]
								get{ return GetExpires(); }
						}

						/// <summary>
						/// <para>Gets the expiry date of this cache entry, expressed as a string.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>the expiry date of this cache entry </para>
						/// </returns>
						/// <java-name>
						/// getExpiresString
						/// </java-name>
						public string ExpiresString
						{
						[Dot42.DexImport("getExpiresString", "()Ljava/lang/String;", AccessFlags = 1)]
								get{ return GetExpiresString(); }
						}

						/// <summary>
						/// <para>Gets the date at which this cache entry was last modified, expressed as a string.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>the date at which this cache entry was last modified </para>
						/// </returns>
						/// <java-name>
						/// getLastModified
						/// </java-name>
						public string LastModified
						{
						[Dot42.DexImport("getLastModified", "()Ljava/lang/String;", AccessFlags = 1)]
								get{ return GetLastModified(); }
						}

						/// <summary>
						/// <para>Gets the entity tag of this cache entry.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>the entity tag of this cache entry </para>
						/// </returns>
						/// <java-name>
						/// getETag
						/// </java-name>
						public string ETag
						{
						[Dot42.DexImport("getETag", "()Ljava/lang/String;", AccessFlags = 1)]
								get{ return GetETag(); }
						}

						/// <summary>
						/// <para>Gets the MIME type of this cache entry.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>the MIME type of this cache entry </para>
						/// </returns>
						/// <java-name>
						/// getMimeType
						/// </java-name>
						public string MimeType
						{
						[Dot42.DexImport("getMimeType", "()Ljava/lang/String;", AccessFlags = 1)]
								get{ return GetMimeType(); }
						}

						/// <summary>
						/// <para>Gets the value of the HTTP 'Location' header with which this cache entry was received.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>the HTTP 'Location' header for this cache entry </para>
						/// </returns>
						/// <java-name>
						/// getLocation
						/// </java-name>
						public string Location
						{
						[Dot42.DexImport("getLocation", "()Ljava/lang/String;", AccessFlags = 1)]
								get{ return GetLocation(); }
						}

						/// <summary>
						/// <para>Gets the encoding of this cache entry.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>the encoding of this cache entry </para>
						/// </returns>
						/// <java-name>
						/// getEncoding
						/// </java-name>
						public string Encoding
						{
						[Dot42.DexImport("getEncoding", "()Ljava/lang/String;", AccessFlags = 1)]
								get{ return GetEncoding(); }
						[Dot42.DexImport("setEncoding", "(Ljava/lang/String;)V", AccessFlags = 1)]
								set{ SetEncoding(value); }
						}

						/// <summary>
						/// <para>Gets the value of the HTTP 'Content-Disposition' header with which this cache entry was received.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>the HTTP 'Content-Disposition' header for this cache entry </para>
						/// </returns>
						/// <java-name>
						/// getContentDisposition
						/// </java-name>
						public string ContentDisposition
						{
						[Dot42.DexImport("getContentDisposition", "()Ljava/lang/String;", AccessFlags = 1)]
								get{ return GetContentDisposition(); }
						}

						/// <summary>
						/// <para>Gets the input stream to the content of this cache entry, to allow content to be read. See CacheManager.getCacheFile(String, Map&lt;String, String&gt;).</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>an input stream to the content of this cache entry </para>
						/// </returns>
						/// <java-name>
						/// getInputStream
						/// </java-name>
						public global::Java.Io.InputStream InputStream
						{
						[Dot42.DexImport("getInputStream", "()Ljava/io/InputStream;", AccessFlags = 1)]
								get{ return GetInputStream(); }
						[Dot42.DexImport("setInputStream", "(Ljava/io/InputStream;)V", AccessFlags = 1)]
								set{ SetInputStream(value); }
						}

						/// <summary>
						/// <para>Gets an output stream to the content of this cache entry, to allow content to be written. See CacheManager.saveCacheFile(String, CacheResult).</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>an output stream to the content of this cache entry </para>
						/// </returns>
						/// <java-name>
						/// getOutputStream
						/// </java-name>
						public global::Java.Io.OutputStream OutputStream
						{
						[Dot42.DexImport("getOutputStream", "()Ljava/io/OutputStream;", AccessFlags = 1)]
								get{ return GetOutputStream(); }
						}

				}

		}

		/// <summary>
		/// <para>Represents a request for handling an SSL error. Instances of this class are created by the WebView and passed to WebViewClient#onReceivedSslError. The host application must call either proceed or cancel to set the WebView's response to the request. </para>    
		/// </summary>
		/// <java-name>
		/// android/webkit/SslErrorHandler
		/// </java-name>
		[Dot42.DexImport("android/webkit/SslErrorHandler", AccessFlags = 33)]
		public partial class SslErrorHandler : global::Android.Os.Handler
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Only for use by WebViewProvider implementations. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal SslErrorHandler() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Proceed with the SSL certificate. </para>        
				/// </summary>
				/// <java-name>
				/// proceed
				/// </java-name>
				[Dot42.DexImport("proceed", "()V", AccessFlags = 1)]
				public virtual void Proceed() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Cancel this request and all pending requests for the WebView that had the error. </para>        
				/// </summary>
				/// <java-name>
				/// cancel
				/// </java-name>
				[Dot42.DexImport("cancel", "()V", AccessFlags = 1)]
				public virtual void Cancel() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>This interface is used to implement plugins in a WebView. A plugin package may extend this class and implement the abstract functions to create embedded or fullscreeen views displayed in a WebView. The PluginStub implementation will be provided the same NPP instance that is created through the native interface. </para>    
		/// </summary>
		/// <java-name>
		/// android/webkit/PluginStub
		/// </java-name>
		[Dot42.DexImport("android/webkit/PluginStub", AccessFlags = 1537)]
		public partial interface IPluginStub
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Return a custom embedded view to draw the plugin. </para>        
				/// </summary>
				/// <returns>
				/// <para>A custom View that will be managed by WebView. </para>
				/// </returns>
				/// <java-name>
				/// getEmbeddedView
				/// </java-name>
				[Dot42.DexImport("getEmbeddedView", "(ILandroid/content/Context;)Landroid/view/View;", AccessFlags = 1025)]
				global::Android.View.View GetEmbeddedView(int NPP, global::Android.Content.Context context) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Return a custom full-screen view to be displayed when the user requests a plugin display as full-screen. Note that the application may choose not to display this View as completely full-screen. </para>        
				/// </summary>
				/// <returns>
				/// <para>A custom View that will be managed by the application. </para>
				/// </returns>
				/// <java-name>
				/// getFullScreenView
				/// </java-name>
				[Dot42.DexImport("getFullScreenView", "(ILandroid/content/Context;)Landroid/view/View;", AccessFlags = 1025)]
				global::Android.View.View GetFullScreenView(int NPP, global::Android.Content.Context context) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>Encapsulates a resource response. Applications can return an instance of this class from WebViewClient#shouldInterceptRequest to provide a custom response when the WebView requests a particular resource. </para>    
		/// </summary>
		/// <java-name>
		/// android/webkit/WebResourceResponse
		/// </java-name>
		[Dot42.DexImport("android/webkit/WebResourceResponse", AccessFlags = 33)]
		public partial class WebResourceResponse
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs a resource response with the given MIME type, encoding, and input stream. Callers must implement InputStream.read(byte[]) for the input stream.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/io/InputStream;)V", AccessFlags = 1)]
				public WebResourceResponse(string mimeType, string encoding, global::Java.Io.InputStream data) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the resource response's MIME type, for example text/html.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setMimeType
				/// </java-name>
				[Dot42.DexImport("setMimeType", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetMimeType(string mimeType) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets the resource response's MIME type.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the resource response's MIME type </para>
				/// </returns>
				/// <java-name>
				/// getMimeType
				/// </java-name>
				[Dot42.DexImport("getMimeType", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetMimeType() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Sets the resource response's encoding, for example UTF-8. This is used to decode the data from the input stream.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setEncoding
				/// </java-name>
				[Dot42.DexImport("setEncoding", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetEncoding(string encoding) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets the resource response's encoding.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the resource response's encoding </para>
				/// </returns>
				/// <java-name>
				/// getEncoding
				/// </java-name>
				[Dot42.DexImport("getEncoding", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetEncoding() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Sets the input stream that provides the resource respone's data. Callers must implement InputStream.read(byte[]).</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setData
				/// </java-name>
				[Dot42.DexImport("setData", "(Ljava/io/InputStream;)V", AccessFlags = 1)]
				public virtual void SetData(global::Java.Io.InputStream data) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets the input stream that provides the resource respone's data.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the input stream that provides the resource response's data </para>
				/// </returns>
				/// <java-name>
				/// getData
				/// </java-name>
				[Dot42.DexImport("getData", "()Ljava/io/InputStream;", AccessFlags = 1)]
				public virtual global::Java.Io.InputStream GetData() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.InputStream);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal WebResourceResponse() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Gets the resource response's MIME type.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the resource response's MIME type </para>
				/// </returns>
				/// <java-name>
				/// getMimeType
				/// </java-name>
				public string MimeType
				{
				[Dot42.DexImport("getMimeType", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetMimeType(); }
				[Dot42.DexImport("setMimeType", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ SetMimeType(value); }
				}

				/// <summary>
				/// <para>Gets the resource response's encoding.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the resource response's encoding </para>
				/// </returns>
				/// <java-name>
				/// getEncoding
				/// </java-name>
				public string Encoding
				{
				[Dot42.DexImport("getEncoding", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetEncoding(); }
				[Dot42.DexImport("setEncoding", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ SetEncoding(value); }
				}

				/// <summary>
				/// <para>Gets the input stream that provides the resource respone's data.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the input stream that provides the resource response's data </para>
				/// </returns>
				/// <java-name>
				/// getData
				/// </java-name>
				public global::Java.Io.InputStream Data
				{
				[Dot42.DexImport("getData", "()Ljava/io/InputStream;", AccessFlags = 1)]
						get{ return GetData(); }
				[Dot42.DexImport("setData", "(Ljava/io/InputStream;)V", AccessFlags = 1)]
						set{ SetData(value); }
				}

		}

		/// <java-name>
		/// android/webkit/WebSyncManager
		/// </java-name>
		[Dot42.DexImport("android/webkit/WebSyncManager", AccessFlags = 1056)]
		internal abstract partial class WebSyncManager : global::Java.Lang.IRunnable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// mHandler
				/// </java-name>
				[Dot42.DexImport("mHandler", "Landroid/os/Handler;", AccessFlags = 4)]
				protected internal global::Android.Os.Handler MHandler;
				/// <java-name>
				/// mDataBase
				/// </java-name>
				[Dot42.DexImport("mDataBase", "Landroid/webkit/WebViewDatabase;", AccessFlags = 4)]
				protected internal global::Android.Webkit.WebViewDatabase MDataBase;
				/// <java-name>
				/// LOGTAG
				/// </java-name>
				[Dot42.DexImport("LOGTAG", "Ljava/lang/String;", AccessFlags = 28)]
				protected internal const string LOGTAG = "websync";
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Ljava/lang/String;)V", AccessFlags = 4)]
				protected internal WebSyncManager(global::Android.Content.Context context, string name) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/lang/Object;", AccessFlags = 4)]
				protected internal virtual object Clone() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <java-name>
				/// run
				/// </java-name>
				[Dot42.DexImport("run", "()V", AccessFlags = 1)]
				public virtual void Run() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>sync() forces sync manager to sync now </para>        
				/// </summary>
				/// <java-name>
				/// sync
				/// </java-name>
				[Dot42.DexImport("sync", "()V", AccessFlags = 1)]
				public virtual void Sync() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>resetSync() resets sync manager's timer </para>        
				/// </summary>
				/// <java-name>
				/// resetSync
				/// </java-name>
				[Dot42.DexImport("resetSync", "()V", AccessFlags = 1)]
				public virtual void ResetSync() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>startSync() requests sync manager to start sync </para>        
				/// </summary>
				/// <java-name>
				/// startSync
				/// </java-name>
				[Dot42.DexImport("startSync", "()V", AccessFlags = 1)]
				public virtual void StartSync() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>stopSync() requests sync manager to stop sync. remove any SYNC_MESSAGE in the queue to break the sync loop </para>        
				/// </summary>
				/// <java-name>
				/// stopSync
				/// </java-name>
				[Dot42.DexImport("stopSync", "()V", AccessFlags = 1)]
				public virtual void StopSync() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onSyncInit
				/// </java-name>
				[Dot42.DexImport("onSyncInit", "()V", AccessFlags = 4)]
				protected internal virtual void OnSyncInit() /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal WebSyncManager() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		/// <para>Represents a request for HTTP authentication. Instances of this class are created by the WebView and passed to WebViewClient#onReceivedHttpAuthRequest. The host application must call either proceed or cancel to set the WebView's response to the request. </para>    
		/// </summary>
		/// <java-name>
		/// android/webkit/HttpAuthHandler
		/// </java-name>
		[Dot42.DexImport("android/webkit/HttpAuthHandler", AccessFlags = 33)]
		public partial class HttpAuthHandler : global::Android.Os.Handler
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Only for use by WebViewProvider implementations. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal HttpAuthHandler() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets whether the credentials stored for the current host (i.e. the host for which WebViewClient#onReceivedHttpAuthRequest was called) are suitable for use. Credentials are not suitable if they have previously been rejected by the server for the current request.</para><para><para>WebView::getHttpAuthUsernamePassword </para></para>        
				/// </summary>
				/// <returns>
				/// <para>whether the credentials are suitable for use </para>
				/// </returns>
				/// <java-name>
				/// useHttpAuthUsernamePassword
				/// </java-name>
				[Dot42.DexImport("useHttpAuthUsernamePassword", "()Z", AccessFlags = 1)]
				public virtual bool UseHttpAuthUsernamePassword() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Instructs the WebView to cancel the authentication request. </para>        
				/// </summary>
				/// <java-name>
				/// cancel
				/// </java-name>
				[Dot42.DexImport("cancel", "()V", AccessFlags = 1)]
				public virtual void Cancel() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Instructs the WebView to proceed with the authentication with the given credentials. Credentials for use with this method can be retrieved from the WebView's store using WebView#getHttpAuthUsernamePassword. </para>        
				/// </summary>
				/// <java-name>
				/// proceed
				/// </java-name>
				[Dot42.DexImport("proceed", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void Proceed(string username, string password) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// android/webkit/WebViewClient
		/// </java-name>
		[Dot42.DexImport("android/webkit/WebViewClient", AccessFlags = 33)]
		public partial class WebViewClient
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Generic error </para>        
				/// </summary>
				/// <java-name>
				/// ERROR_UNKNOWN
				/// </java-name>
				[Dot42.DexImport("ERROR_UNKNOWN", "I", AccessFlags = 25)]
				public const int ERROR_UNKNOWN = -1;
				/// <summary>
				/// <para>Server or proxy hostname lookup failed </para>        
				/// </summary>
				/// <java-name>
				/// ERROR_HOST_LOOKUP
				/// </java-name>
				[Dot42.DexImport("ERROR_HOST_LOOKUP", "I", AccessFlags = 25)]
				public const int ERROR_HOST_LOOKUP = -2;
				/// <summary>
				/// <para>Unsupported authentication scheme (not basic or digest) </para>        
				/// </summary>
				/// <java-name>
				/// ERROR_UNSUPPORTED_AUTH_SCHEME
				/// </java-name>
				[Dot42.DexImport("ERROR_UNSUPPORTED_AUTH_SCHEME", "I", AccessFlags = 25)]
				public const int ERROR_UNSUPPORTED_AUTH_SCHEME = -3;
				/// <summary>
				/// <para>User authentication failed on server </para>        
				/// </summary>
				/// <java-name>
				/// ERROR_AUTHENTICATION
				/// </java-name>
				[Dot42.DexImport("ERROR_AUTHENTICATION", "I", AccessFlags = 25)]
				public const int ERROR_AUTHENTICATION = -4;
				/// <summary>
				/// <para>User authentication failed on proxy </para>        
				/// </summary>
				/// <java-name>
				/// ERROR_PROXY_AUTHENTICATION
				/// </java-name>
				[Dot42.DexImport("ERROR_PROXY_AUTHENTICATION", "I", AccessFlags = 25)]
				public const int ERROR_PROXY_AUTHENTICATION = -5;
				/// <summary>
				/// <para>Failed to connect to the server </para>        
				/// </summary>
				/// <java-name>
				/// ERROR_CONNECT
				/// </java-name>
				[Dot42.DexImport("ERROR_CONNECT", "I", AccessFlags = 25)]
				public const int ERROR_CONNECT = -6;
				/// <summary>
				/// <para>Failed to read or write to the server </para>        
				/// </summary>
				/// <java-name>
				/// ERROR_IO
				/// </java-name>
				[Dot42.DexImport("ERROR_IO", "I", AccessFlags = 25)]
				public const int ERROR_IO = -7;
				/// <summary>
				/// <para>Connection timed out </para>        
				/// </summary>
				/// <java-name>
				/// ERROR_TIMEOUT
				/// </java-name>
				[Dot42.DexImport("ERROR_TIMEOUT", "I", AccessFlags = 25)]
				public const int ERROR_TIMEOUT = -8;
				/// <summary>
				/// <para>Too many redirects </para>        
				/// </summary>
				/// <java-name>
				/// ERROR_REDIRECT_LOOP
				/// </java-name>
				[Dot42.DexImport("ERROR_REDIRECT_LOOP", "I", AccessFlags = 25)]
				public const int ERROR_REDIRECT_LOOP = -9;
				/// <summary>
				/// <para>Unsupported URI scheme </para>        
				/// </summary>
				/// <java-name>
				/// ERROR_UNSUPPORTED_SCHEME
				/// </java-name>
				[Dot42.DexImport("ERROR_UNSUPPORTED_SCHEME", "I", AccessFlags = 25)]
				public const int ERROR_UNSUPPORTED_SCHEME = -10;
				/// <summary>
				/// <para>Failed to perform SSL handshake </para>        
				/// </summary>
				/// <java-name>
				/// ERROR_FAILED_SSL_HANDSHAKE
				/// </java-name>
				[Dot42.DexImport("ERROR_FAILED_SSL_HANDSHAKE", "I", AccessFlags = 25)]
				public const int ERROR_FAILED_SSL_HANDSHAKE = -11;
				/// <summary>
				/// <para>Malformed URL </para>        
				/// </summary>
				/// <java-name>
				/// ERROR_BAD_URL
				/// </java-name>
				[Dot42.DexImport("ERROR_BAD_URL", "I", AccessFlags = 25)]
				public const int ERROR_BAD_URL = -12;
				/// <summary>
				/// <para>Generic file error </para>        
				/// </summary>
				/// <java-name>
				/// ERROR_FILE
				/// </java-name>
				[Dot42.DexImport("ERROR_FILE", "I", AccessFlags = 25)]
				public const int ERROR_FILE = -13;
				/// <summary>
				/// <para>File not found </para>        
				/// </summary>
				/// <java-name>
				/// ERROR_FILE_NOT_FOUND
				/// </java-name>
				[Dot42.DexImport("ERROR_FILE_NOT_FOUND", "I", AccessFlags = 25)]
				public const int ERROR_FILE_NOT_FOUND = -14;
				/// <summary>
				/// <para>Too many requests during this load </para>        
				/// </summary>
				/// <java-name>
				/// ERROR_TOO_MANY_REQUESTS
				/// </java-name>
				[Dot42.DexImport("ERROR_TOO_MANY_REQUESTS", "I", AccessFlags = 25)]
				public const int ERROR_TOO_MANY_REQUESTS = -15;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public WebViewClient() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Give the host application a chance to take over the control when a new url is about to be loaded in the current WebView. If WebViewClient is not provided, by default WebView will ask Activity Manager to choose the proper handler for the url. If WebViewClient is provided, return true means the host application handles the url, while return false means the current WebView handles the url. This method is not called for requests using the POST "method".</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>True if the host application wants to leave the current WebView and handle the url itself, otherwise return false. </para>
				/// </returns>
				/// <java-name>
				/// shouldOverrideUrlLoading
				/// </java-name>
				[Dot42.DexImport("shouldOverrideUrlLoading", "(Landroid/webkit/WebView;Ljava/lang/String;)Z", AccessFlags = 1)]
				public virtual bool ShouldOverrideUrlLoading(global::Android.Webkit.WebView view, string url) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Notify the host application that a page has started loading. This method is called once for each main frame load so a page with iframes or framesets will call onPageStarted one time for the main frame. This also means that onPageStarted will not be called when the contents of an embedded frame changes, i.e. clicking a link whose target is an iframe.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// onPageStarted
				/// </java-name>
				[Dot42.DexImport("onPageStarted", "(Landroid/webkit/WebView;Ljava/lang/String;Landroid/graphics/Bitmap;)V", AccessFlags = 1)]
				public virtual void OnPageStarted(global::Android.Webkit.WebView view, string url, global::Android.Graphics.Bitmap favicon) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Notify the host application that a page has finished loading. This method is called only for main frame. When onPageFinished() is called, the rendering picture may not be updated yet. To get the notification for the new Picture, use WebView.PictureListener#onNewPicture.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// onPageFinished
				/// </java-name>
				[Dot42.DexImport("onPageFinished", "(Landroid/webkit/WebView;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void OnPageFinished(global::Android.Webkit.WebView view, string url) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Notify the host application that the WebView will load the resource specified by the given url.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// onLoadResource
				/// </java-name>
				[Dot42.DexImport("onLoadResource", "(Landroid/webkit/WebView;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void OnLoadResource(global::Android.Webkit.WebView view, string url) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Notify the host application of a resource request and allow the application to return the data. If the return value is null, the WebView will continue to load the resource as usual. Otherwise, the return response and data will be used. NOTE: This method is called on a thread other than the UI thread so clients should exercise caution when accessing private data or the view system.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>A android.webkit.WebResourceResponse containing the response information or null if the WebView should load the resource itself. </para>
				/// </returns>
				/// <java-name>
				/// shouldInterceptRequest
				/// </java-name>
				[Dot42.DexImport("shouldInterceptRequest", "(Landroid/webkit/WebView;Ljava/lang/String;)Landroid/webkit/WebResourceResponse;", AccessFlags = 1)]
				public virtual global::Android.Webkit.WebResourceResponse ShouldInterceptRequest(global::Android.Webkit.WebView view, string url) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Webkit.WebResourceResponse);
				}

				/// <summary>
				/// <para>Notify the host application that there have been an excessive number of HTTP redirects. As the host application if it would like to continue trying to load the resource. The default behavior is to send the cancel message.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>This method is no longer called. When the WebView encounters a redirect loop, it will cancel the load. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// onTooManyRedirects
				/// </java-name>
				[Dot42.DexImport("onTooManyRedirects", "(Landroid/webkit/WebView;Landroid/os/Message;Landroid/os/Message;)V", AccessFlags = 1)]
				public virtual void OnTooManyRedirects(global::Android.Webkit.WebView view, global::Android.Os.Message cancelMsg, global::Android.Os.Message continueMsg) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Report an error to the host application. These errors are unrecoverable (i.e. the main resource is unavailable). The errorCode parameter corresponds to one of the ERROR_* constants. </para>        
				/// </summary>
				/// <java-name>
				/// onReceivedError
				/// </java-name>
				[Dot42.DexImport("onReceivedError", "(Landroid/webkit/WebView;ILjava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void OnReceivedError(global::Android.Webkit.WebView view, int errorCode, string description, string failingUrl) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>As the host application if the browser should resend data as the requested page was a result of a POST. The default is to not resend the data.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// onFormResubmission
				/// </java-name>
				[Dot42.DexImport("onFormResubmission", "(Landroid/webkit/WebView;Landroid/os/Message;Landroid/os/Message;)V", AccessFlags = 1)]
				public virtual void OnFormResubmission(global::Android.Webkit.WebView view, global::Android.Os.Message dontResend, global::Android.Os.Message resend) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Notify the host application to update its visited links database.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// doUpdateVisitedHistory
				/// </java-name>
				[Dot42.DexImport("doUpdateVisitedHistory", "(Landroid/webkit/WebView;Ljava/lang/String;Z)V", AccessFlags = 1)]
				public virtual void DoUpdateVisitedHistory(global::Android.Webkit.WebView view, string url, bool isReload) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Notify the host application that an SSL error occurred while loading a resource. The host application must call either handler.cancel() or handler.proceed(). Note that the decision may be retained for use in response to future SSL errors. The default behavior is to cancel the load.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// onReceivedSslError
				/// </java-name>
				[Dot42.DexImport("onReceivedSslError", "(Landroid/webkit/WebView;Landroid/webkit/SslErrorHandler;Landroid/net/http/SslErr" +
    "or;)V", AccessFlags = 1)]
				public virtual void OnReceivedSslError(global::Android.Webkit.WebView view, global::Android.Webkit.SslErrorHandler handler, global::Android.Net.Http.SslError error) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Notifies the host application that the WebView received an HTTP authentication request. The host application can use the supplied HttpAuthHandler to set the WebView's response to the request. The default behavior is to cancel the request.</para><para><para>WebView::getHttpAuthUsernamePassword </para></para>        
				/// </summary>
				/// <java-name>
				/// onReceivedHttpAuthRequest
				/// </java-name>
				[Dot42.DexImport("onReceivedHttpAuthRequest", "(Landroid/webkit/WebView;Landroid/webkit/HttpAuthHandler;Ljava/lang/String;Ljava/" +
    "lang/String;)V", AccessFlags = 1)]
				public virtual void OnReceivedHttpAuthRequest(global::Android.Webkit.WebView view, global::Android.Webkit.HttpAuthHandler handler, string host, string realm) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Give the host application a chance to handle the key event synchronously. e.g. menu shortcut key events need to be filtered this way. If return true, WebView will not handle the key event. If return false, WebView will always handle the key event, so none of the super in the view chain will see the key event. The default behavior returns false.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>True if the host application wants to handle the key event itself, otherwise return false </para>
				/// </returns>
				/// <java-name>
				/// shouldOverrideKeyEvent
				/// </java-name>
				[Dot42.DexImport("shouldOverrideKeyEvent", "(Landroid/webkit/WebView;Landroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public virtual bool ShouldOverrideKeyEvent(global::Android.Webkit.WebView view, global::Android.View.KeyEvent @event) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Notify the host application that a key was not handled by the WebView. Except system keys, WebView always consumes the keys in the normal flow or if shouldOverrideKeyEvent returns true. This is called asynchronously from where the key is dispatched. It gives the host application a chance to handle the unhandled key events.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// onUnhandledKeyEvent
				/// </java-name>
				[Dot42.DexImport("onUnhandledKeyEvent", "(Landroid/webkit/WebView;Landroid/view/KeyEvent;)V", AccessFlags = 1)]
				public virtual void OnUnhandledKeyEvent(global::Android.Webkit.WebView view, global::Android.View.KeyEvent @event) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Notify the host application that the scale applied to the WebView has changed.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// onScaleChanged
				/// </java-name>
				[Dot42.DexImport("onScaleChanged", "(Landroid/webkit/WebView;FF)V", AccessFlags = 1)]
				public virtual void OnScaleChanged(global::Android.Webkit.WebView view, float oldScale, float newScale) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Notify the host application that a request to automatically log in the user has been processed. </para>        
				/// </summary>
				/// <java-name>
				/// onReceivedLoginRequest
				/// </java-name>
				[Dot42.DexImport("onReceivedLoginRequest", "(Landroid/webkit/WebView;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V" +
    "", AccessFlags = 1)]
				public virtual void OnReceivedLoginRequest(global::Android.Webkit.WebView view, string realm, string account, string args) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>A convenience class for accessing fields in an entry in the back/forward list of a WebView. Each WebHistoryItem is a snapshot of the requested history item. Each history item may be updated during the load of a page. <para>WebBackForwardList </para></para>    
		/// </summary>
		/// <java-name>
		/// android/webkit/WebHistoryItem
		/// </java-name>
		[Dot42.DexImport("android/webkit/WebHistoryItem", AccessFlags = 33)]
		public partial class WebHistoryItem : global::Java.Lang.ICloneable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal WebHistoryItem() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Return an identifier for this history item. If an item is a copy of another item, the identifiers will be the same even if they are not the same object. <xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>This method is now obsolete.  Since API level android.os.Build.VERSION_CODES#JELLY_BEAN_MR1 </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				/// <para>The id for this item. </para>
				/// </returns>
				/// <java-name>
				/// getId
				/// </java-name>
				[Dot42.DexImport("getId", "()I", AccessFlags = 1)]
				public virtual int GetId() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Return the url of this history item. The url is the base url of this history item. See getTargetUrl() for the url that is the actual target of this history item. </para>        
				/// </summary>
				/// <returns>
				/// <para>The base url of this history item. Note: The VM ensures 32-bit atomic read/write operations so we don't have to synchronize this method. </para>
				/// </returns>
				/// <java-name>
				/// getUrl
				/// </java-name>
				[Dot42.DexImport("getUrl", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetUrl() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Return the original url of this history item. This was the requested url, the final url may be different as there might have been redirects while loading the site. </para>        
				/// </summary>
				/// <returns>
				/// <para>The original url of this history item. </para>
				/// </returns>
				/// <java-name>
				/// getOriginalUrl
				/// </java-name>
				[Dot42.DexImport("getOriginalUrl", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetOriginalUrl() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Return the document title of this history item. </para>        
				/// </summary>
				/// <returns>
				/// <para>The document title of this history item. Note: The VM ensures 32-bit atomic read/write operations so we don't have to synchronize this method. </para>
				/// </returns>
				/// <java-name>
				/// getTitle
				/// </java-name>
				[Dot42.DexImport("getTitle", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetTitle() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Return the favicon of this history item or null if no favicon was found. </para>        
				/// </summary>
				/// <returns>
				/// <para>A Bitmap containing the favicon for this history item or null. Note: The VM ensures 32-bit atomic read/write operations so we don't have to synchronize this method. </para>
				/// </returns>
				/// <java-name>
				/// getFavicon
				/// </java-name>
				[Dot42.DexImport("getFavicon", "()Landroid/graphics/Bitmap;", AccessFlags = 1)]
				public virtual global::Android.Graphics.Bitmap GetFavicon() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Bitmap);
				}

				/// <summary>
				/// <para>Clone the history item for use by clients of WebView. </para>        
				/// </summary>
				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Landroid/webkit/WebHistoryItem;", AccessFlags = 36)]
				protected internal virtual global::Android.Webkit.WebHistoryItem Clone() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Webkit.WebHistoryItem);
				}

				/// <summary>
				/// <para>Return an identifier for this history item. If an item is a copy of another item, the identifiers will be the same even if they are not the same object. <xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>This method is now obsolete.  Since API level android.os.Build.VERSION_CODES#JELLY_BEAN_MR1 </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				/// <para>The id for this item. </para>
				/// </returns>
				/// <java-name>
				/// getId
				/// </java-name>
				public int Id
				{
				[Dot42.DexImport("getId", "()I", AccessFlags = 1)]
						get{ return GetId(); }
				}

				/// <summary>
				/// <para>Return the url of this history item. The url is the base url of this history item. See getTargetUrl() for the url that is the actual target of this history item. </para>        
				/// </summary>
				/// <returns>
				/// <para>The base url of this history item. Note: The VM ensures 32-bit atomic read/write operations so we don't have to synchronize this method. </para>
				/// </returns>
				/// <java-name>
				/// getUrl
				/// </java-name>
				public string Url
				{
				[Dot42.DexImport("getUrl", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetUrl(); }
				}

				/// <summary>
				/// <para>Return the original url of this history item. This was the requested url, the final url may be different as there might have been redirects while loading the site. </para>        
				/// </summary>
				/// <returns>
				/// <para>The original url of this history item. </para>
				/// </returns>
				/// <java-name>
				/// getOriginalUrl
				/// </java-name>
				public string OriginalUrl
				{
				[Dot42.DexImport("getOriginalUrl", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetOriginalUrl(); }
				}

				/// <summary>
				/// <para>Return the document title of this history item. </para>        
				/// </summary>
				/// <returns>
				/// <para>The document title of this history item. Note: The VM ensures 32-bit atomic read/write operations so we don't have to synchronize this method. </para>
				/// </returns>
				/// <java-name>
				/// getTitle
				/// </java-name>
				public string Title
				{
				[Dot42.DexImport("getTitle", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetTitle(); }
				}

				/// <summary>
				/// <para>Return the favicon of this history item or null if no favicon was found. </para>        
				/// </summary>
				/// <returns>
				/// <para>A Bitmap containing the favicon for this history item or null. Note: The VM ensures 32-bit atomic read/write operations so we don't have to synchronize this method. </para>
				/// </returns>
				/// <java-name>
				/// getFavicon
				/// </java-name>
				public global::Android.Graphics.Bitmap Favicon
				{
				[Dot42.DexImport("getFavicon", "()Landroid/graphics/Bitmap;", AccessFlags = 1)]
						get{ return GetFavicon(); }
				}

		}

		/// <summary>
		/// <para>This class contains the back/forward list for a WebView. WebView.copyBackForwardList() will return a copy of this class used to inspect the entries in the list. </para>    
		/// </summary>
		/// <java-name>
		/// android/webkit/WebBackForwardList
		/// </java-name>
		[Dot42.DexImport("android/webkit/WebBackForwardList", AccessFlags = 33)]
		public partial class WebBackForwardList : global::Java.Lang.ICloneable, global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal WebBackForwardList() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Return the current history item. This method returns null if the list is empty. </para>        
				/// </summary>
				/// <returns>
				/// <para>The current history item. </para>
				/// </returns>
				/// <java-name>
				/// getCurrentItem
				/// </java-name>
				[Dot42.DexImport("getCurrentItem", "()Landroid/webkit/WebHistoryItem;", AccessFlags = 33)]
				public virtual global::Android.Webkit.WebHistoryItem GetCurrentItem() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Webkit.WebHistoryItem);
				}

				/// <summary>
				/// <para>Get the index of the current history item. This index can be used to directly index into the array list. </para>        
				/// </summary>
				/// <returns>
				/// <para>The current index from 0...n or -1 if the list is empty. </para>
				/// </returns>
				/// <java-name>
				/// getCurrentIndex
				/// </java-name>
				[Dot42.DexImport("getCurrentIndex", "()I", AccessFlags = 33)]
				public virtual int GetCurrentIndex() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Get the history item at the given index. The index range is from 0...n where 0 is the first item and n is the last item. </para>        
				/// </summary>
				/// <java-name>
				/// getItemAtIndex
				/// </java-name>
				[Dot42.DexImport("getItemAtIndex", "(I)Landroid/webkit/WebHistoryItem;", AccessFlags = 33)]
				public virtual global::Android.Webkit.WebHistoryItem GetItemAtIndex(int index) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Webkit.WebHistoryItem);
				}

				/// <summary>
				/// <para>Get the total size of the back/forward list. </para>        
				/// </summary>
				/// <returns>
				/// <para>The size of the list. </para>
				/// </returns>
				/// <java-name>
				/// getSize
				/// </java-name>
				[Dot42.DexImport("getSize", "()I", AccessFlags = 33)]
				public virtual int GetSize() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Clone the entire object to be used in the UI thread by clients of WebView. This creates a copy that should never be modified by any of the webkit package classes. </para>        
				/// </summary>
				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Landroid/webkit/WebBackForwardList;", AccessFlags = 36)]
				protected internal virtual global::Android.Webkit.WebBackForwardList Clone() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Webkit.WebBackForwardList);
				}

				/// <summary>
				/// <para>Return the current history item. This method returns null if the list is empty. </para>        
				/// </summary>
				/// <returns>
				/// <para>The current history item. </para>
				/// </returns>
				/// <java-name>
				/// getCurrentItem
				/// </java-name>
				public global::Android.Webkit.WebHistoryItem CurrentItem
				{
				[Dot42.DexImport("getCurrentItem", "()Landroid/webkit/WebHistoryItem;", AccessFlags = 33)]
						get{ return GetCurrentItem(); }
				}

				/// <summary>
				/// <para>Get the index of the current history item. This index can be used to directly index into the array list. </para>        
				/// </summary>
				/// <returns>
				/// <para>The current index from 0...n or -1 if the list is empty. </para>
				/// </returns>
				/// <java-name>
				/// getCurrentIndex
				/// </java-name>
				public int CurrentIndex
				{
				[Dot42.DexImport("getCurrentIndex", "()I", AccessFlags = 33)]
						get{ return GetCurrentIndex(); }
				}

				/// <summary>
				/// <para>Get the total size of the back/forward list. </para>        
				/// </summary>
				/// <returns>
				/// <para>The size of the list. </para>
				/// </returns>
				/// <java-name>
				/// getSize
				/// </java-name>
				public int Size
				{
				[Dot42.DexImport("getSize", "()I", AccessFlags = 33)]
						get{ return GetSize(); }
				}

		}

		/// <summary>
		/// <para>This class is used to manage the JavaScript storage APIs provided by the WebView. It manages the Application Cache API, the Web SQL Database API and the HTML5 Web Storage API.</para><para>The Application Cache API provides a mechanism to create and maintain an application cache to power offline Web applications. Use of the Application Cache API can be attributed to an origin WebStorage.Origin, however it is not possible to set per-origin quotas. Note that there can be only one application cache per application.</para><para>The Web SQL Database API provides storage which is private to a given origin. Similar to the Application Cache, use of the Web SQL Database can be attributed to an origin. It is also possible to set per-origin quotas. </para>    
		/// </summary>
		/// <java-name>
		/// android/webkit/WebStorage
		/// </java-name>
		[Dot42.DexImport("android/webkit/WebStorage", AccessFlags = 49)]
		public sealed partial class WebStorage
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>This class should not be instantiated directly, applications must only use getInstance() to obtain the instance. Note this constructor was erroneously public and published in SDK levels prior to 16, but applications using it would receive a non-functional instance of this class (there was no way to call createHandler() and createUIHandler(), so it would not work).  </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public WebStorage() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets the origins currently using either the Application Cache or Web SQL Database APIs. This method operates asynchronously, with the result being provided via a ValueCallback. The origins are provided as a map, of type <c> Map&lt;String, WebStorage.Origin&gt; </c> , from the string representation of the origin to a WebStorage.Origin object. </para>        
				/// </summary>
				/// <java-name>
				/// getOrigins
				/// </java-name>
				[Dot42.DexImport("getOrigins", "(Landroid/webkit/ValueCallback;)V", AccessFlags = 1, Signature = "(Landroid/webkit/ValueCallback<Ljava/util/Map;>;)V")]
				public void GetOrigins(global::Android.Webkit.IValueCallback<global::Java.Util.IMap<object, object>> callback) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets the amount of storage currently being used by both the Application Cache and Web SQL Database APIs by the given origin. The amount is given in bytes and the origin is specified using its string representation. This method operates asynchronously, with the result being provided via a ValueCallback. </para>        
				/// </summary>
				/// <java-name>
				/// getUsageForOrigin
				/// </java-name>
				[Dot42.DexImport("getUsageForOrigin", "(Ljava/lang/String;Landroid/webkit/ValueCallback;)V", AccessFlags = 1, Signature = "(Ljava/lang/String;Landroid/webkit/ValueCallback<Ljava/lang/Long;>;)V")]
				public void GetUsageForOrigin(string origin, global::Android.Webkit.IValueCallback<long?> callback) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets the storage quota for the Web SQL Database API for the given origin. The quota is given in bytes and the origin is specified using its string representation. This method operates asynchronously, with the result being provided via a ValueCallback. Note that a quota is not enforced on a per-origin basis for the Application Cache API. </para>        
				/// </summary>
				/// <java-name>
				/// getQuotaForOrigin
				/// </java-name>
				[Dot42.DexImport("getQuotaForOrigin", "(Ljava/lang/String;Landroid/webkit/ValueCallback;)V", AccessFlags = 1, Signature = "(Ljava/lang/String;Landroid/webkit/ValueCallback<Ljava/lang/Long;>;)V")]
				public void GetQuotaForOrigin(string origin, global::Android.Webkit.IValueCallback<long?> callback) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the storage quota for the Web SQL Database API for the given origin. The quota is specified in bytes and the origin is specified using its string representation. Note that a quota is not enforced on a per-origin basis for the Application Cache API. <xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>Controlling quota per-origin will not be supported in future. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// setQuotaForOrigin
				/// </java-name>
				[Dot42.DexImport("setQuotaForOrigin", "(Ljava/lang/String;J)V", AccessFlags = 1)]
				public void SetQuotaForOrigin(string origin, long quota) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Clears the storage currently being used by both the Application Cache and Web SQL Database APIs by the given origin. The origin is specified using its string representation. </para>        
				/// </summary>
				/// <java-name>
				/// deleteOrigin
				/// </java-name>
				[Dot42.DexImport("deleteOrigin", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public void DeleteOrigin(string origin) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Clears all storage currently being used by the JavaScript storage APIs. This includes the Application Cache, Web SQL Database and the HTML5 Web Storage APIs. </para>        
				/// </summary>
				/// <java-name>
				/// deleteAllData
				/// </java-name>
				[Dot42.DexImport("deleteAllData", "()V", AccessFlags = 1)]
				public void DeleteAllData() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets the singleton instance of this class.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the singleton WebStorage instance </para>
				/// </returns>
				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "()Landroid/webkit/WebStorage;", AccessFlags = 9)]
				public static global::Android.Webkit.WebStorage GetInstance() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Webkit.WebStorage);
				}

				/// <summary>
				/// <para>Gets the singleton instance of this class.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the singleton WebStorage instance </para>
				/// </returns>
				/// <java-name>
				/// getInstance
				/// </java-name>
				public static global::Android.Webkit.WebStorage Instance
				{
				[Dot42.DexImport("getInstance", "()Landroid/webkit/WebStorage;", AccessFlags = 9)]
						get{ return GetInstance(); }
				}

				/// <summary>
				/// <para>This class encapsulates information about the amount of storage currently used by an origin for the JavaScript storage APIs. An origin comprises the host, scheme and port of a URI. See WebStorage for details. </para>    
				/// </summary>
				/// <java-name>
				/// android/webkit/WebStorage$Origin
				/// </java-name>
				[Dot42.DexImport("android/webkit/WebStorage$Origin", AccessFlags = 9)]
				public partial class Origin
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
						internal Origin() /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						/// <para>Gets the string representation of this origin.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>the string representation of this origin </para>
						/// </returns>
						/// <java-name>
						/// getOrigin
						/// </java-name>
						[Dot42.DexImport("getOrigin", "()Ljava/lang/String;", AccessFlags = 1)]
						public virtual string GetOrigin() /* MethodBuilder.Create */ 
						{
								return default(string);
						}

						/// <summary>
						/// <para>Gets the quota for this origin, for the Web SQL Database API, in bytes. If this origin does not use the Web SQL Database API, this quota will be set to zero.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>the quota, in bytes </para>
						/// </returns>
						/// <java-name>
						/// getQuota
						/// </java-name>
						[Dot42.DexImport("getQuota", "()J", AccessFlags = 1)]
						public virtual long GetQuota() /* MethodBuilder.Create */ 
						{
								return default(long);
						}

						/// <summary>
						/// <para>Gets the total amount of storage currently being used by this origin, for all JavaScript storage APIs, in bytes.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>the total amount of storage, in bytes </para>
						/// </returns>
						/// <java-name>
						/// getUsage
						/// </java-name>
						[Dot42.DexImport("getUsage", "()J", AccessFlags = 1)]
						public virtual long GetUsage() /* MethodBuilder.Create */ 
						{
								return default(long);
						}

						/// <summary>
						/// <para>Gets the quota for this origin, for the Web SQL Database API, in bytes. If this origin does not use the Web SQL Database API, this quota will be set to zero.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>the quota, in bytes </para>
						/// </returns>
						/// <java-name>
						/// getQuota
						/// </java-name>
						public long Quota
						{
						[Dot42.DexImport("getQuota", "()J", AccessFlags = 1)]
								get{ return GetQuota(); }
						}

						/// <summary>
						/// <para>Gets the total amount of storage currently being used by this origin, for all JavaScript storage APIs, in bytes.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>the total amount of storage, in bytes </para>
						/// </returns>
						/// <java-name>
						/// getUsage
						/// </java-name>
						public long Usage
						{
						[Dot42.DexImport("getUsage", "()J", AccessFlags = 1)]
								get{ return GetUsage(); }
						}

				}

				/// <summary>
				/// <para>Encapsulates a callback function which is used to provide a new quota for a JavaScript storage API. See WebChromeClient#onExceededDatabaseQuota and WebChromeClient#onReachedMaxAppCacheSize. </para>    
				/// </summary>
				/// <java-name>
				/// android/webkit/WebStorage$QuotaUpdater
				/// </java-name>
				[Dot42.DexImport("android/webkit/WebStorage$QuotaUpdater", AccessFlags = 1545)]
				public partial interface IQuotaUpdater
 /* scope: __dot42__ */ 
				{
						/// <summary>
						/// <para>Provides a new quota, specified in bytes.</para><para></para>        
						/// </summary>
						/// <java-name>
						/// updateQuota
						/// </java-name>
						[Dot42.DexImport("updateQuota", "(J)V", AccessFlags = 1025)]
						void UpdateQuota(long newQuota) /* MethodBuilder.Create */ ;

				}

		}

		/// <summary>
		/// <para>A fragment that displays a WebView. </para><para>The WebView is automically paused or resumed when the Fragment is paused or resumed. </para>    
		/// </summary>
		/// <java-name>
		/// android/webkit/WebViewFragment
		/// </java-name>
		[Dot42.DexImport("android/webkit/WebViewFragment", AccessFlags = 33)]
		public partial class WebViewFragment : global::Android.App.Fragment
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public WebViewFragment() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Called to instantiate the view. Creates and returns the WebView. </para>        
				/// </summary>
				/// <java-name>
				/// onCreateView
				/// </java-name>
				[Dot42.DexImport("onCreateView", "(Landroid/view/LayoutInflater;Landroid/view/ViewGroup;Landroid/os/Bundle;)Landroi" +
    "d/view/View;", AccessFlags = 1)]
				public override global::Android.View.View OnCreateView(global::Android.View.LayoutInflater inflater, global::Android.View.ViewGroup container, global::Android.Os.Bundle savedInstanceState) /* MethodBuilder.Create */ 
				{
						return default(global::Android.View.View);
				}

				/// <summary>
				/// <para>Called when the fragment is visible to the user and actively running. Resumes the WebView. </para>        
				/// </summary>
				/// <java-name>
				/// onPause
				/// </java-name>
				[Dot42.DexImport("onPause", "()V", AccessFlags = 1)]
				public override void OnPause() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Called when the fragment is no longer resumed. Pauses the WebView. </para>        
				/// </summary>
				/// <java-name>
				/// onResume
				/// </java-name>
				[Dot42.DexImport("onResume", "()V", AccessFlags = 1)]
				public override void OnResume() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Called when the WebView has been detached from the fragment. The WebView is no longer available after this time. </para>        
				/// </summary>
				/// <java-name>
				/// onDestroyView
				/// </java-name>
				[Dot42.DexImport("onDestroyView", "()V", AccessFlags = 1)]
				public override void OnDestroyView() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Called when the fragment is no longer in use. Destroys the internal state of the WebView. </para>        
				/// </summary>
				/// <java-name>
				/// onDestroy
				/// </java-name>
				[Dot42.DexImport("onDestroy", "()V", AccessFlags = 1)]
				public override void OnDestroy() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets the WebView. </para>        
				/// </summary>
				/// <java-name>
				/// getWebView
				/// </java-name>
				[Dot42.DexImport("getWebView", "()Landroid/webkit/WebView;", AccessFlags = 1)]
				public virtual global::Android.Webkit.WebView GetWebView() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Webkit.WebView);
				}

				/// <summary>
				/// <para>Gets the WebView. </para>        
				/// </summary>
				/// <java-name>
				/// getWebView
				/// </java-name>
				public global::Android.Webkit.WebView WebView
				{
				[Dot42.DexImport("getWebView", "()Landroid/webkit/WebView;", AccessFlags = 1)]
						get{ return GetWebView(); }
				}

		}

		/// <java-name>
		/// android/webkit/URLUtil
		/// </java-name>
		[Dot42.DexImport("android/webkit/URLUtil", AccessFlags = 49)]
		public sealed partial class URLUtil
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public URLUtil() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Cleans up (if possible) user-entered web addresses </para>        
				/// </summary>
				/// <java-name>
				/// guessUrl
				/// </java-name>
				[Dot42.DexImport("guessUrl", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 9)]
				public static string GuessUrl(string inUrl) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// composeSearchUrl
				/// </java-name>
				[Dot42.DexImport("composeSearchUrl", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 9)]
				public static string ComposeSearchUrl(string inQuery, string template, string queryPlaceHolder) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// decode
				/// </java-name>
				[Dot42.DexImport("decode", "([B)[B", AccessFlags = 9)]
				public static sbyte[] Decode(sbyte[] url) /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <java-name>
				/// decode
				/// </java-name>
				[Dot42.DexImport("decode", "([B)[B", AccessFlags = 9, IgnoreFromJava = true)]
				public static byte[] Decode(byte[] url) /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>True iff the url is an asset file. </para>
				/// </returns>
				/// <java-name>
				/// isAssetUrl
				/// </java-name>
				[Dot42.DexImport("isAssetUrl", "(Ljava/lang/String;)Z", AccessFlags = 9)]
				public static bool IsAssetUrl(string url) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>Cookieless proxy is no longer supported. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				/// <para>True iff the url is a proxy url to allow cookieless network requests from a file url. </para>
				/// </returns>
				/// <java-name>
				/// isCookielessProxyUrl
				/// </java-name>
				[Dot42.DexImport("isCookielessProxyUrl", "(Ljava/lang/String;)Z", AccessFlags = 9)]
				public static bool IsCookielessProxyUrl(string url) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>True iff the url is a local file. </para>
				/// </returns>
				/// <java-name>
				/// isFileUrl
				/// </java-name>
				[Dot42.DexImport("isFileUrl", "(Ljava/lang/String;)Z", AccessFlags = 9)]
				public static bool IsFileUrl(string url) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>True iff the url is an about: url. </para>
				/// </returns>
				/// <java-name>
				/// isAboutUrl
				/// </java-name>
				[Dot42.DexImport("isAboutUrl", "(Ljava/lang/String;)Z", AccessFlags = 9)]
				public static bool IsAboutUrl(string url) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>True iff the url is a data: url. </para>
				/// </returns>
				/// <java-name>
				/// isDataUrl
				/// </java-name>
				[Dot42.DexImport("isDataUrl", "(Ljava/lang/String;)Z", AccessFlags = 9)]
				public static bool IsDataUrl(string url) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>True iff the url is a javascript: url. </para>
				/// </returns>
				/// <java-name>
				/// isJavaScriptUrl
				/// </java-name>
				[Dot42.DexImport("isJavaScriptUrl", "(Ljava/lang/String;)Z", AccessFlags = 9)]
				public static bool IsJavaScriptUrl(string url) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>True iff the url is an http: url. </para>
				/// </returns>
				/// <java-name>
				/// isHttpUrl
				/// </java-name>
				[Dot42.DexImport("isHttpUrl", "(Ljava/lang/String;)Z", AccessFlags = 9)]
				public static bool IsHttpUrl(string url) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>True iff the url is an https: url. </para>
				/// </returns>
				/// <java-name>
				/// isHttpsUrl
				/// </java-name>
				[Dot42.DexImport("isHttpsUrl", "(Ljava/lang/String;)Z", AccessFlags = 9)]
				public static bool IsHttpsUrl(string url) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>True iff the url is a network url. </para>
				/// </returns>
				/// <java-name>
				/// isNetworkUrl
				/// </java-name>
				[Dot42.DexImport("isNetworkUrl", "(Ljava/lang/String;)Z", AccessFlags = 9)]
				public static bool IsNetworkUrl(string url) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>True iff the url is a content: url. </para>
				/// </returns>
				/// <java-name>
				/// isContentUrl
				/// </java-name>
				[Dot42.DexImport("isContentUrl", "(Ljava/lang/String;)Z", AccessFlags = 9)]
				public static bool IsContentUrl(string url) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>True iff the url is valid. </para>
				/// </returns>
				/// <java-name>
				/// isValidUrl
				/// </java-name>
				[Dot42.DexImport("isValidUrl", "(Ljava/lang/String;)Z", AccessFlags = 9)]
				public static bool IsValidUrl(string url) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Strips the url of the anchor. </para>        
				/// </summary>
				/// <java-name>
				/// stripAnchor
				/// </java-name>
				[Dot42.DexImport("stripAnchor", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 9)]
				public static string StripAnchor(string url) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Guesses canonical filename that a download would have, using the URL and contentDisposition. File extension, if not defined, is added based on the mimetype </para>        
				/// </summary>
				/// <returns>
				/// <para>suggested filename </para>
				/// </returns>
				/// <java-name>
				/// guessFileName
				/// </java-name>
				[Dot42.DexImport("guessFileName", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 25)]
				public static string GuessFileName(string url, string contentDisposition, string mimeType) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

		}

		/// <java-name>
		/// android/webkit/DownloadListener
		/// </java-name>
		[Dot42.DexImport("android/webkit/DownloadListener", AccessFlags = 1537)]
		public partial interface IDownloadListener
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Notify the host application that a file should be downloaded </para>        
				/// </summary>
				/// <java-name>
				/// onDownloadStart
				/// </java-name>
				[Dot42.DexImport("onDownloadStart", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;J)V", AccessFlags = 1025)]
				void OnDownloadStart(string url, string userAgent, string contentDisposition, string mimetype, long contentLength) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>Manages the cookies used by an application's WebView instances. Cookies are manipulated according to RFC2109. </para>    
		/// </summary>
		/// <java-name>
		/// android/webkit/CookieManager
		/// </java-name>
		[Dot42.DexImport("android/webkit/CookieManager", AccessFlags = 49)]
		public sealed partial class CookieManager
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Only for use by WebViewProvider implementations </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal CookieManager() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/lang/Object;", AccessFlags = 4)]
				internal object Clone() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <summary>
				/// <para>Gets the singleton CookieManager instance. If this method is used before the application instantiates a WebView instance, CookieSyncManager.createInstance(Context) must be called first.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the singleton CookieManager instance </para>
				/// </returns>
				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "()Landroid/webkit/CookieManager;", AccessFlags = 41)]
				public static global::Android.Webkit.CookieManager GetInstance() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Webkit.CookieManager);
				}

				/// <summary>
				/// <para>Sets whether the application's WebView instances should send and accept cookies.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setAcceptCookie
				/// </java-name>
				[Dot42.DexImport("setAcceptCookie", "(Z)V", AccessFlags = 33)]
				public void SetAcceptCookie(bool accept) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets whether the application's WebView instances send and accept cookies.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if WebView instances send and accept cookies </para>
				/// </returns>
				/// <java-name>
				/// acceptCookie
				/// </java-name>
				[Dot42.DexImport("acceptCookie", "()Z", AccessFlags = 33)]
				public bool AcceptCookie() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Sets a cookie for the given URL. Any existing cookie with the same host, path and name will be replaced with the new cookie. The cookie being set must not have expired and must not be a session cookie, otherwise it will be ignored.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setCookie
				/// </java-name>
				[Dot42.DexImport("setCookie", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public void SetCookie(string url, string value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets cookie(s) for a given uri so that it can be set to "cookie:" in http request header.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>value the cookies as a string, using the format of the 'Cookie' HTTP request header  Used by RequestHandle, no intention to publish. </para>
				/// </returns>
				/// <java-name>
				/// getCookie
				/// </java-name>
				[Dot42.DexImport("getCookie", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1)]
				public string GetCookie(string uri) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Removes all session cookies, which are cookies without an expiration date. </para>        
				/// </summary>
				/// <java-name>
				/// removeSessionCookie
				/// </java-name>
				[Dot42.DexImport("removeSessionCookie", "()V", AccessFlags = 1)]
				public void RemoveSessionCookie() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Removes all cookies. </para>        
				/// </summary>
				/// <java-name>
				/// removeAllCookie
				/// </java-name>
				[Dot42.DexImport("removeAllCookie", "()V", AccessFlags = 1)]
				public void RemoveAllCookie() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets whether there are stored cookies.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if there are stored cookies </para>
				/// </returns>
				/// <java-name>
				/// hasCookies
				/// </java-name>
				[Dot42.DexImport("hasCookies", "()Z", AccessFlags = 33)]
				public bool HasCookies() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Removes all expired cookies. </para>        
				/// </summary>
				/// <java-name>
				/// removeExpiredCookie
				/// </java-name>
				[Dot42.DexImport("removeExpiredCookie", "()V", AccessFlags = 1)]
				public void RemoveExpiredCookie() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets whether the application's WebView instances send and accept cookies for file scheme URLs.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if WebView instances send and accept cookies for file scheme URLs </para>
				/// </returns>
				/// <java-name>
				/// allowFileSchemeCookies
				/// </java-name>
				[Dot42.DexImport("allowFileSchemeCookies", "()Z", AccessFlags = 9)]
				public static bool AllowFileSchemeCookies() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Sets whether the application's WebView instances should send and accept cookies for file scheme URLs. Use of cookies with file scheme URLs is potentially insecure. Do not use this feature unless you can be sure that no unintentional sharing of cookie data can take place. </para><para>Note that calls to this method will have no effect if made after a WebView or CookieManager instance has been created. </para>        
				/// </summary>
				/// <java-name>
				/// setAcceptFileSchemeCookies
				/// </java-name>
				[Dot42.DexImport("setAcceptFileSchemeCookies", "(Z)V", AccessFlags = 9)]
				public static void SetAcceptFileSchemeCookies(bool accept) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets the singleton CookieManager instance. If this method is used before the application instantiates a WebView instance, CookieSyncManager.createInstance(Context) must be called first.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the singleton CookieManager instance </para>
				/// </returns>
				/// <java-name>
				/// getInstance
				/// </java-name>
				public static global::Android.Webkit.CookieManager Instance
				{
				[Dot42.DexImport("getInstance", "()Landroid/webkit/CookieManager;", AccessFlags = 41)]
						get{ return GetInstance(); }
				}

		}

		/// <summary>
		/// <para>Sorts dates into the following groups: Today Yesterday seven days ago one month ago older than a month ago </para>    
		/// </summary>
		/// <java-name>
		/// android/webkit/DateSorter
		/// </java-name>
		[Dot42.DexImport("android/webkit/DateSorter", AccessFlags = 33)]
		public partial class DateSorter
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>must be &gt;= 3 </para>        
				/// </summary>
				/// <java-name>
				/// DAY_COUNT
				/// </java-name>
				[Dot42.DexImport("DAY_COUNT", "I", AccessFlags = 25)]
				public const int DAY_COUNT = 5;
				/// <summary>
				/// <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public DateSorter(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>an index from 0 to (DAY_COUNT - 1) that identifies which date bin this date belongs to </para>
				/// </returns>
				/// <java-name>
				/// getIndex
				/// </java-name>
				[Dot42.DexImport("getIndex", "(J)I", AccessFlags = 1)]
				public virtual int GetIndex(long time) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>string label suitable for display to user </para>
				/// </returns>
				/// <java-name>
				/// getLabel
				/// </java-name>
				[Dot42.DexImport("getLabel", "(I)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetLabel(int index) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>date boundary at given index </para>
				/// </returns>
				/// <java-name>
				/// getBoundary
				/// </java-name>
				[Dot42.DexImport("getBoundary", "(I)J", AccessFlags = 1)]
				public virtual long GetBoundary(int index) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal DateSorter() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		/// <para>A callback interface used to provide values asynchronously. </para>    
		/// </summary>
		/// <java-name>
		/// android/webkit/ValueCallback
		/// </java-name>
		[Dot42.DexImport("android/webkit/ValueCallback", AccessFlags = 1537, Signature = "<T:Ljava/lang/Object;>Ljava/lang/Object;")]
		public partial interface IValueCallback<T>
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Invoked when the value is available. </para>        
				/// </summary>
				/// <java-name>
				/// onReceiveValue
				/// </java-name>
				[Dot42.DexImport("onReceiveValue", "(Ljava/lang/Object;)V", AccessFlags = 1025, Signature = "(TT;)V")]
				void OnReceiveValue(T value) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>This class allows developers to determine whether any WebView used in the application has stored any of the following types of browsing data and to clear any such stored data for all WebViews in the application. <ul><li><para>Username/password pairs for web forms </para></li><li><para>HTTP authentication username/password pairs </para></li><li><para>Data entered into text fields (e.g. for autocomplete suggestions) </para></li></ul></para>    
		/// </summary>
		/// <java-name>
		/// android/webkit/WebViewDatabase
		/// </java-name>
		[Dot42.DexImport("android/webkit/WebViewDatabase", AccessFlags = 33)]
		public partial class WebViewDatabase
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Since API level android.os.Build.VERSION_CODES#JELLY_BEAN_MR1 </para>        
				/// </summary>
				/// <java-name>
				/// LOGTAG
				/// </java-name>
				[Dot42.DexImport("LOGTAG", "Ljava/lang/String;", AccessFlags = 28)]
				protected internal const string LOGTAG = "webviewdatabase";
				/// <summary>
				/// <para>Only for use by WebViewProvider implementations. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal WebViewDatabase() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(Landroid/content/Context;)Landroid/webkit/WebViewDatabase;", AccessFlags = 41)]
				public static global::Android.Webkit.WebViewDatabase GetInstance(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Webkit.WebViewDatabase);
				}

				/// <summary>
				/// <para>Gets whether there are any saved username/password pairs for web forms. Note that these are unrelated to HTTP authentication credentials.</para><para><para>WebView::savePassword </para><simplesectsep></simplesectsep><para>#clearUsernamePassworda </para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>Saving passwords in WebView will not be supported in future versions. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				/// <para>true if there are any saved username/password pairs </para>
				/// </returns>
				/// <java-name>
				/// hasUsernamePassword
				/// </java-name>
				[Dot42.DexImport("hasUsernamePassword", "()Z", AccessFlags = 1)]
				public virtual bool HasUsernamePassword() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Clears any saved username/password pairs for web forms. Note that these are unrelated to HTTP authentication credentials.</para><para><para>WebView::savePassword </para><simplesectsep></simplesectsep><para>hasUsernamePassword </para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>Saving passwords in WebView will not be supported in future versions. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// clearUsernamePassword
				/// </java-name>
				[Dot42.DexImport("clearUsernamePassword", "()V", AccessFlags = 1)]
				public virtual void ClearUsernamePassword() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets whether there are any saved credentials for HTTP authentication.</para><para><para>WebView::getHttpAuthUsernamePassword </para><simplesectsep></simplesectsep><para>WebView::setHttpAuthUsernamePassword </para><simplesectsep></simplesectsep><para>clearHttpAuthUsernamePassword </para></para>        
				/// </summary>
				/// <returns>
				/// <para>whether there are any saved credentials </para>
				/// </returns>
				/// <java-name>
				/// hasHttpAuthUsernamePassword
				/// </java-name>
				[Dot42.DexImport("hasHttpAuthUsernamePassword", "()Z", AccessFlags = 1)]
				public virtual bool HasHttpAuthUsernamePassword() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Clears any saved credentials for HTTP authentication.</para><para><para>WebView::getHttpAuthUsernamePassword </para><simplesectsep></simplesectsep><para>WebView::setHttpAuthUsernamePassword </para><simplesectsep></simplesectsep><para>hasHttpAuthUsernamePassword </para></para>        
				/// </summary>
				/// <java-name>
				/// clearHttpAuthUsernamePassword
				/// </java-name>
				[Dot42.DexImport("clearHttpAuthUsernamePassword", "()V", AccessFlags = 1)]
				public virtual void ClearHttpAuthUsernamePassword() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets whether there is any saved data for web forms.</para><para><para>clearFormData </para></para>        
				/// </summary>
				/// <returns>
				/// <para>whether there is any saved data for web forms </para>
				/// </returns>
				/// <java-name>
				/// hasFormData
				/// </java-name>
				[Dot42.DexImport("hasFormData", "()Z", AccessFlags = 1)]
				public virtual bool HasFormData() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Clears any saved data for web forms.</para><para><para>hasFormData </para></para>        
				/// </summary>
				/// <java-name>
				/// clearFormData
				/// </java-name>
				[Dot42.DexImport("clearFormData", "()V", AccessFlags = 1)]
				public virtual void ClearFormData() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>An instance of this class is passed as a parameter in various WebChromeClient action notifications. The object is used as a handle onto the underlying JavaScript-originated request, and provides a means for the client to indicate whether this action should proceed. </para>    
		/// </summary>
		/// <java-name>
		/// android/webkit/JsResult
		/// </java-name>
		[Dot42.DexImport("android/webkit/JsResult", AccessFlags = 33)]
		public partial class JsResult
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// mResult
				/// </java-name>
				[Dot42.DexImport("mResult", "Z", AccessFlags = 4)]
				protected internal bool MResult;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal JsResult() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Handle the result if the user cancelled the dialog. </para>        
				/// </summary>
				/// <java-name>
				/// cancel
				/// </java-name>
				[Dot42.DexImport("cancel", "()V", AccessFlags = 17)]
				public void Cancel() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Handle a confirmation response from the user. </para>        
				/// </summary>
				/// <java-name>
				/// confirm
				/// </java-name>
				[Dot42.DexImport("confirm", "()V", AccessFlags = 17)]
				public void Confirm() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// wakeUp
				/// </java-name>
				[Dot42.DexImport("wakeUp", "()V", AccessFlags = 20)]
				protected internal void WakeUp() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>The CookieSyncManager is used to synchronize the browser cookie store between RAM and permanent storage. To get the best performance, browser cookies are saved in RAM. A separate thread saves the cookies between, driven by a timer. </para><para>To use the CookieSyncManager, the host application has to call the following when the application starts: </para><para><pre>CookieSyncManager.createInstance(context)</pre></para><para>To set up for sync, the host application has to call</para><para><pre>CookieSyncManager.getInstance().startSync()</pre></para><para>in Activity.onResume(), and call </para><para><pre>
		///    CookieSyncManager.getInstance().stopSync()
		///    </pre></para><para>in Activity.onPause().</para><para>To get instant sync instead of waiting for the timer to trigger, the host can call </para><para><pre>CookieSyncManager.getInstance().sync()</pre></para><para>The sync interval is 5 minutes, so you will want to force syncs manually anyway, for instance in WebViewClient#onPageFinished. Note that even sync() happens asynchronously, so don't do it just as your activity is shutting down. </para>    
		/// </summary>
		/// <java-name>
		/// android/webkit/CookieSyncManager
		/// </java-name>
		[Dot42.DexImport("android/webkit/CookieSyncManager", AccessFlags = 49)]
		public sealed partial class CookieSyncManager : global::Java.Lang.IRunnable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal CookieSyncManager() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Singleton access to a CookieSyncManager. An IllegalStateException will be thrown if CookieSyncManager#createInstance(Context) is not called before.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>CookieSyncManager </para>
				/// </returns>
				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "()Landroid/webkit/CookieSyncManager;", AccessFlags = 41)]
				public static global::Android.Webkit.CookieSyncManager GetInstance() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Webkit.CookieSyncManager);
				}

				/// <summary>
				/// <para>Create a singleton CookieSyncManager within a context </para>        
				/// </summary>
				/// <returns>
				/// <para>CookieSyncManager </para>
				/// </returns>
				/// <java-name>
				/// createInstance
				/// </java-name>
				[Dot42.DexImport("createInstance", "(Landroid/content/Context;)Landroid/webkit/CookieSyncManager;", AccessFlags = 41)]
				public static global::Android.Webkit.CookieSyncManager CreateInstance(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Webkit.CookieSyncManager);
				}

				/// <java-name>
				/// syncFromRamToFlash
				/// </java-name>
				[Dot42.DexImport("syncFromRamToFlash", "()V", AccessFlags = 4)]
				internal void SyncFromRamToFlash() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/lang/Object;", AccessFlags = 4)]
				internal object Clone() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <java-name>
				/// run
				/// </java-name>
				[Dot42.DexImport("run", "()V", AccessFlags = 1)]
				public void Run() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// sync
				/// </java-name>
				[Dot42.DexImport("sync", "()V", AccessFlags = 1)]
				public void Sync() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// resetSync
				/// </java-name>
				[Dot42.DexImport("resetSync", "()V", AccessFlags = 1)]
				public void ResetSync() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// startSync
				/// </java-name>
				[Dot42.DexImport("startSync", "()V", AccessFlags = 1)]
				public void StartSync() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// stopSync
				/// </java-name>
				[Dot42.DexImport("stopSync", "()V", AccessFlags = 1)]
				public void StopSync() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onSyncInit
				/// </java-name>
				[Dot42.DexImport("onSyncInit", "()V", AccessFlags = 4)]
				internal void OnSyncInit() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Singleton access to a CookieSyncManager. An IllegalStateException will be thrown if CookieSyncManager#createInstance(Context) is not called before.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>CookieSyncManager </para>
				/// </returns>
				/// <java-name>
				/// getInstance
				/// </java-name>
				public static global::Android.Webkit.CookieSyncManager Instance
				{
				[Dot42.DexImport("getInstance", "()Landroid/webkit/CookieSyncManager;", AccessFlags = 41)]
						get{ return GetInstance(); }
				}

		}

		/// <java-name>
		/// android/webkit/WebChromeClient
		/// </java-name>
		[Dot42.DexImport("android/webkit/WebChromeClient", AccessFlags = 33)]
		public partial class WebChromeClient
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public WebChromeClient() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Tell the host application the current progress of loading a page. </para>        
				/// </summary>
				/// <java-name>
				/// onProgressChanged
				/// </java-name>
				[Dot42.DexImport("onProgressChanged", "(Landroid/webkit/WebView;I)V", AccessFlags = 1)]
				public virtual void OnProgressChanged(global::Android.Webkit.WebView view, int newProgress) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Notify the host application of a change in the document title. </para>        
				/// </summary>
				/// <java-name>
				/// onReceivedTitle
				/// </java-name>
				[Dot42.DexImport("onReceivedTitle", "(Landroid/webkit/WebView;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void OnReceivedTitle(global::Android.Webkit.WebView view, string title) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Notify the host application of a new favicon for the current page. </para>        
				/// </summary>
				/// <java-name>
				/// onReceivedIcon
				/// </java-name>
				[Dot42.DexImport("onReceivedIcon", "(Landroid/webkit/WebView;Landroid/graphics/Bitmap;)V", AccessFlags = 1)]
				public virtual void OnReceivedIcon(global::Android.Webkit.WebView view, global::Android.Graphics.Bitmap icon) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Notify the host application of the url for an apple-touch-icon. </para>        
				/// </summary>
				/// <java-name>
				/// onReceivedTouchIconUrl
				/// </java-name>
				[Dot42.DexImport("onReceivedTouchIconUrl", "(Landroid/webkit/WebView;Ljava/lang/String;Z)V", AccessFlags = 1)]
				public virtual void OnReceivedTouchIconUrl(global::Android.Webkit.WebView view, string url, bool precomposed) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Notify the host application that the current page would like to show a custom View. This is used for Fullscreen video playback; see "HTML5 Video support" documentation on WebView. </para>        
				/// </summary>
				/// <java-name>
				/// onShowCustomView
				/// </java-name>
				[Dot42.DexImport("onShowCustomView", "(Landroid/view/View;Landroid/webkit/WebChromeClient$CustomViewCallback;)V", AccessFlags = 1)]
				public virtual void OnShowCustomView(global::Android.View.View view, global::Android.Webkit.WebChromeClient.ICustomViewCallback callback) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Notify the host application that the current page would like to show a custom View in a particular orientation. <xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>This method supports the obsolete plugin mechanism, and will not be invoked in future </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// onShowCustomView
				/// </java-name>
				[Dot42.DexImport("onShowCustomView", "(Landroid/view/View;ILandroid/webkit/WebChromeClient$CustomViewCallback;)V", AccessFlags = 1)]
				public virtual void OnShowCustomView(global::Android.View.View view, int requestedOrientation, global::Android.Webkit.WebChromeClient.ICustomViewCallback callback) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Notify the host application that the current page would like to hide its custom view. </para>        
				/// </summary>
				/// <java-name>
				/// onHideCustomView
				/// </java-name>
				[Dot42.DexImport("onHideCustomView", "()V", AccessFlags = 1)]
				public virtual void OnHideCustomView() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Request the host application to create a new window. If the host application chooses to honor this request, it should return true from this method, create a new WebView to host the window, insert it into the View system and send the supplied resultMsg message to its target with the new WebView as an argument. If the host application chooses not to honor the request, it should return false from this method. The default implementation of this method does nothing and hence returns false. </para>        
				/// </summary>
				/// <returns>
				/// <para>This method should return true if the host application will create a new window, in which case resultMsg should be sent to its target. Otherwise, this method should return false. Returning false from this method but also sending resultMsg will result in undefined behavior. </para>
				/// </returns>
				/// <java-name>
				/// onCreateWindow
				/// </java-name>
				[Dot42.DexImport("onCreateWindow", "(Landroid/webkit/WebView;ZZLandroid/os/Message;)Z", AccessFlags = 1)]
				public virtual bool OnCreateWindow(global::Android.Webkit.WebView view, bool isDialog, bool isUserGesture, global::Android.Os.Message resultMsg) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Request display and focus for this WebView. This may happen due to another WebView opening a link in this WebView and requesting that this WebView be displayed. </para>        
				/// </summary>
				/// <java-name>
				/// onRequestFocus
				/// </java-name>
				[Dot42.DexImport("onRequestFocus", "(Landroid/webkit/WebView;)V", AccessFlags = 1)]
				public virtual void OnRequestFocus(global::Android.Webkit.WebView view) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Notify the host application to close the given WebView and remove it from the view system if necessary. At this point, WebCore has stopped any loading in this window and has removed any cross-scripting ability in javascript. </para>        
				/// </summary>
				/// <java-name>
				/// onCloseWindow
				/// </java-name>
				[Dot42.DexImport("onCloseWindow", "(Landroid/webkit/WebView;)V", AccessFlags = 1)]
				public virtual void OnCloseWindow(global::Android.Webkit.WebView window) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Tell the client to display a javascript alert dialog. If the client returns true, WebView will assume that the client will handle the dialog. If the client returns false, it will continue execution. </para>        
				/// </summary>
				/// <returns>
				/// <para>boolean Whether the client will handle the alert dialog. </para>
				/// </returns>
				/// <java-name>
				/// onJsAlert
				/// </java-name>
				[Dot42.DexImport("onJsAlert", "(Landroid/webkit/WebView;Ljava/lang/String;Ljava/lang/String;Landroid/webkit/JsRe" +
    "sult;)Z", AccessFlags = 1)]
				public virtual bool OnJsAlert(global::Android.Webkit.WebView view, string url, string message, global::Android.Webkit.JsResult result) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Tell the client to display a confirm dialog to the user. If the client returns true, WebView will assume that the client will handle the confirm dialog and call the appropriate JsResult method. If the client returns false, a default value of false will be returned to javascript. The default behavior is to return false. </para>        
				/// </summary>
				/// <returns>
				/// <para>boolean Whether the client will handle the confirm dialog. </para>
				/// </returns>
				/// <java-name>
				/// onJsConfirm
				/// </java-name>
				[Dot42.DexImport("onJsConfirm", "(Landroid/webkit/WebView;Ljava/lang/String;Ljava/lang/String;Landroid/webkit/JsRe" +
    "sult;)Z", AccessFlags = 1)]
				public virtual bool OnJsConfirm(global::Android.Webkit.WebView view, string url, string message, global::Android.Webkit.JsResult result) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Tell the client to display a prompt dialog to the user. If the client returns true, WebView will assume that the client will handle the prompt dialog and call the appropriate JsPromptResult method. If the client returns false, a default value of false will be returned to to javascript. The default behavior is to return false. </para>        
				/// </summary>
				/// <returns>
				/// <para>boolean Whether the client will handle the prompt dialog. </para>
				/// </returns>
				/// <java-name>
				/// onJsPrompt
				/// </java-name>
				[Dot42.DexImport("onJsPrompt", "(Landroid/webkit/WebView;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;La" +
    "ndroid/webkit/JsPromptResult;)Z", AccessFlags = 1)]
				public virtual bool OnJsPrompt(global::Android.Webkit.WebView view, string url, string message, string defaultValue, global::Android.Webkit.JsPromptResult result) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Tell the client to display a dialog to confirm navigation away from the current page. This is the result of the onbeforeunload javascript event. If the client returns true, WebView will assume that the client will handle the confirm dialog and call the appropriate JsResult method. If the client returns false, a default value of true will be returned to javascript to accept navigation away from the current page. The default behavior is to return false. Setting the JsResult to true will navigate away from the current page, false will cancel the navigation. </para>        
				/// </summary>
				/// <returns>
				/// <para>boolean Whether the client will handle the confirm dialog. </para>
				/// </returns>
				/// <java-name>
				/// onJsBeforeUnload
				/// </java-name>
				[Dot42.DexImport("onJsBeforeUnload", "(Landroid/webkit/WebView;Ljava/lang/String;Ljava/lang/String;Landroid/webkit/JsRe" +
    "sult;)Z", AccessFlags = 1)]
				public virtual bool OnJsBeforeUnload(global::Android.Webkit.WebView view, string url, string message, global::Android.Webkit.JsResult result) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Tell the client that the quota has been exceeded for the Web SQL Database API for a particular origin and request a new quota. The client must respond by invoking the updateQuota(long) method of the supplied WebStorage.QuotaUpdater instance. The minimum value that can be set for the new quota is the current quota. The default implementation responds with the current quota, so the quota will not be increased. </para>        
				/// </summary>
				/// <java-name>
				/// onExceededDatabaseQuota
				/// </java-name>
				[Dot42.DexImport("onExceededDatabaseQuota", "(Ljava/lang/String;Ljava/lang/String;JJJLandroid/webkit/WebStorage$QuotaUpdater;)" +
    "V", AccessFlags = 1)]
				public virtual void OnExceededDatabaseQuota(string url, string databaseIdentifier, long quota, long estimatedDatabaseSize, long totalQuota, global::Android.Webkit.WebStorage.IQuotaUpdater quotaUpdater) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Notify the host application that the Application Cache has reached the maximum size. The client must respond by invoking the updateQuota(long) method of the supplied WebStorage.QuotaUpdater instance. The minimum value that can be set for the new quota is the current quota. The default implementation responds with the current quota, so the quota will not be increased. </para>        
				/// </summary>
				/// <java-name>
				/// onReachedMaxAppCacheSize
				/// </java-name>
				[Dot42.DexImport("onReachedMaxAppCacheSize", "(JJLandroid/webkit/WebStorage$QuotaUpdater;)V", AccessFlags = 1)]
				public virtual void OnReachedMaxAppCacheSize(long requiredStorage, long quota, global::Android.Webkit.WebStorage.IQuotaUpdater quotaUpdater) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Notify the host application that web content from the specified origin is attempting to use the Geolocation API, but no permission state is currently set for that origin. The host application should invoke the specified callback with the desired permission state. See GeolocationPermissions for details. </para>        
				/// </summary>
				/// <java-name>
				/// onGeolocationPermissionsShowPrompt
				/// </java-name>
				[Dot42.DexImport("onGeolocationPermissionsShowPrompt", "(Ljava/lang/String;Landroid/webkit/GeolocationPermissions$Callback;)V", AccessFlags = 1)]
				public virtual void OnGeolocationPermissionsShowPrompt(string origin, global::Android.Webkit.GeolocationPermissions.ICallback callback) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Notify the host application that a request for Geolocation permissions, made with a previous call to onGeolocationPermissionsShowPrompt() has been canceled. Any related UI should therefore be hidden. </para>        
				/// </summary>
				/// <java-name>
				/// onGeolocationPermissionsHidePrompt
				/// </java-name>
				[Dot42.DexImport("onGeolocationPermissionsHidePrompt", "()V", AccessFlags = 1)]
				public virtual void OnGeolocationPermissionsHidePrompt() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Tell the client that a JavaScript execution timeout has occured. And the client may decide whether or not to interrupt the execution. If the client returns true, the JavaScript will be interrupted. If the client returns false, the execution will continue. Note that in the case of continuing execution, the timeout counter will be reset, and the callback will continue to occur if the script does not finish at the next check point. <xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>This method is no longer supported and will not be invoked. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				/// <para>boolean Whether the JavaScript execution should be interrupted. </para>
				/// </returns>
				/// <java-name>
				/// onJsTimeout
				/// </java-name>
				[Dot42.DexImport("onJsTimeout", "()Z", AccessFlags = 1)]
				public virtual bool OnJsTimeout() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Report a JavaScript error message to the host application. The ChromeClient should override this to process the log message as they see fit. <xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>Use onConsoleMessage(ConsoleMessage) instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// onConsoleMessage
				/// </java-name>
				[Dot42.DexImport("onConsoleMessage", "(Ljava/lang/String;ILjava/lang/String;)V", AccessFlags = 1)]
				public virtual void OnConsoleMessage(string message, int lineNumber, string sourceID) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Report a JavaScript console message to the host application. The ChromeClient should override this to process the log message as they see fit. </para>        
				/// </summary>
				/// <returns>
				/// <para>true if the message is handled by the client. </para>
				/// </returns>
				/// <java-name>
				/// onConsoleMessage
				/// </java-name>
				[Dot42.DexImport("onConsoleMessage", "(Landroid/webkit/ConsoleMessage;)Z", AccessFlags = 1)]
				public virtual bool OnConsoleMessage(global::Android.Webkit.ConsoleMessage consoleMessage) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>When not playing, video elements are represented by a 'poster' image. The image to use can be specified by the poster attribute of the video tag in HTML. If the attribute is absent, then a default poster will be used. This method allows the ChromeClient to provide that default image.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Bitmap The image to use as a default poster, or null if no such image is available. </para>
				/// </returns>
				/// <java-name>
				/// getDefaultVideoPoster
				/// </java-name>
				[Dot42.DexImport("getDefaultVideoPoster", "()Landroid/graphics/Bitmap;", AccessFlags = 1)]
				public virtual global::Android.Graphics.Bitmap GetDefaultVideoPoster() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Bitmap);
				}

				/// <summary>
				/// <para>When the user starts to playback a video element, it may take time for enough data to be buffered before the first frames can be rendered. While this buffering is taking place, the ChromeClient can use this function to provide a View to be displayed. For example, the ChromeClient could show a spinner animation.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>View The View to be displayed whilst the video is loading. </para>
				/// </returns>
				/// <java-name>
				/// getVideoLoadingProgressView
				/// </java-name>
				[Dot42.DexImport("getVideoLoadingProgressView", "()Landroid/view/View;", AccessFlags = 1)]
				public virtual global::Android.View.View GetVideoLoadingProgressView() /* MethodBuilder.Create */ 
				{
						return default(global::Android.View.View);
				}

				/// <summary>
				/// <para>Obtains a list of all visited history items, used for link coloring </para>        
				/// </summary>
				/// <java-name>
				/// getVisitedHistory
				/// </java-name>
				[Dot42.DexImport("getVisitedHistory", "(Landroid/webkit/ValueCallback;)V", AccessFlags = 1, Signature = "(Landroid/webkit/ValueCallback<[Ljava/lang/String;>;)V")]
				public virtual void GetVisitedHistory(global::Android.Webkit.IValueCallback<string[]> callback) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>When not playing, video elements are represented by a 'poster' image. The image to use can be specified by the poster attribute of the video tag in HTML. If the attribute is absent, then a default poster will be used. This method allows the ChromeClient to provide that default image.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Bitmap The image to use as a default poster, or null if no such image is available. </para>
				/// </returns>
				/// <java-name>
				/// getDefaultVideoPoster
				/// </java-name>
				public global::Android.Graphics.Bitmap DefaultVideoPoster
				{
				[Dot42.DexImport("getDefaultVideoPoster", "()Landroid/graphics/Bitmap;", AccessFlags = 1)]
						get{ return GetDefaultVideoPoster(); }
				}

				/// <summary>
				/// <para>When the user starts to playback a video element, it may take time for enough data to be buffered before the first frames can be rendered. While this buffering is taking place, the ChromeClient can use this function to provide a View to be displayed. For example, the ChromeClient could show a spinner animation.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>View The View to be displayed whilst the video is loading. </para>
				/// </returns>
				/// <java-name>
				/// getVideoLoadingProgressView
				/// </java-name>
				public global::Android.View.View VideoLoadingProgressView
				{
				[Dot42.DexImport("getVideoLoadingProgressView", "()Landroid/view/View;", AccessFlags = 1)]
						get{ return GetVideoLoadingProgressView(); }
				}

				/// <summary>
				/// <para>A callback interface used by the host application to notify the current page that its custom view has been dismissed. </para>    
				/// </summary>
				/// <java-name>
				/// android/webkit/WebChromeClient$CustomViewCallback
				/// </java-name>
				[Dot42.DexImport("android/webkit/WebChromeClient$CustomViewCallback", AccessFlags = 1545)]
				public partial interface ICustomViewCallback
 /* scope: __dot42__ */ 
				{
						/// <summary>
						/// <para>Invoked when the host application dismisses the custom view. </para>        
						/// </summary>
						/// <java-name>
						/// onCustomViewHidden
						/// </java-name>
						[Dot42.DexImport("onCustomViewHidden", "()V", AccessFlags = 1025)]
						void OnCustomViewHidden() /* MethodBuilder.Create */ ;

				}

		}

		/// <summary>
		/// <para>This class is used to manage permissions for the WebView's Geolocation JavaScript API.</para><para>Geolocation permissions are applied to an origin, which consists of the host, scheme and port of a URI. In order for web content to use the Geolocation API, permission must be granted for that content's origin.</para><para>This class stores Geolocation permissions. An origin's permission state can be either allowed or denied. This class uses Strings to represent an origin.</para><para>When an origin attempts to use the Geolocation API, but no permission state is currently set for that origin, WebChromeClient.onGeolocationPermissionsShowPrompt() is called. This allows the permission state to be set for that origin.</para><para>The methods of this class can be used to modify and interrogate the stored Geolocation permissions at any time. </para>    
		/// </summary>
		/// <java-name>
		/// android/webkit/GeolocationPermissions
		/// </java-name>
		[Dot42.DexImport("android/webkit/GeolocationPermissions", AccessFlags = 49)]
		public sealed partial class GeolocationPermissions
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>This class should not be instantiated directly, applications must only use getInstance() to obtain the instance. Note this constructor was erroneously public and published in SDK levels prior to 16, but applications using it would receive a non-functional instance of this class (there was no way to call createHandler() and createUIHandler(), so it would not work).  Only for use by WebViewProvider implementations </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public GeolocationPermissions() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets the singleton instance of this class. This method cannot be called before the application instantiates a WebView instance.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the singleton GeolocationPermissions instance </para>
				/// </returns>
				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "()Landroid/webkit/GeolocationPermissions;", AccessFlags = 9)]
				public static global::Android.Webkit.GeolocationPermissions GetInstance() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Webkit.GeolocationPermissions);
				}

				/// <summary>
				/// <para>Gets the set of origins for which Geolocation permissions are stored.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// getOrigins
				/// </java-name>
				[Dot42.DexImport("getOrigins", "(Landroid/webkit/ValueCallback;)V", AccessFlags = 1, Signature = "(Landroid/webkit/ValueCallback<Ljava/util/Set<Ljava/lang/String;>;>;)V")]
				public void GetOrigins(global::Android.Webkit.IValueCallback<global::Java.Util.ISet<string>> callback) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets the Geolocation permission state for the specified origin.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// getAllowed
				/// </java-name>
				[Dot42.DexImport("getAllowed", "(Ljava/lang/String;Landroid/webkit/ValueCallback;)V", AccessFlags = 1, Signature = "(Ljava/lang/String;Landroid/webkit/ValueCallback<Ljava/lang/Boolean;>;)V")]
				public void GetAllowed(string origin, global::Android.Webkit.IValueCallback<bool?> callback) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Clears the Geolocation permission state for the specified origin.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// clear
				/// </java-name>
				[Dot42.DexImport("clear", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public void Clear(string origin) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Allows the specified origin to use the Geolocation API.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// allow
				/// </java-name>
				[Dot42.DexImport("allow", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public void Allow(string origin) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Clears the Geolocation permission state for all origins. </para>        
				/// </summary>
				/// <java-name>
				/// clearAll
				/// </java-name>
				[Dot42.DexImport("clearAll", "()V", AccessFlags = 1)]
				public void ClearAll() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets the singleton instance of this class. This method cannot be called before the application instantiates a WebView instance.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the singleton GeolocationPermissions instance </para>
				/// </returns>
				/// <java-name>
				/// getInstance
				/// </java-name>
				public static global::Android.Webkit.GeolocationPermissions Instance
				{
				[Dot42.DexImport("getInstance", "()Landroid/webkit/GeolocationPermissions;", AccessFlags = 9)]
						get{ return GetInstance(); }
				}

				/// <summary>
				/// <para>A callback interface used by the host application to set the Geolocation permission state for an origin. </para>    
				/// </summary>
				/// <java-name>
				/// android/webkit/GeolocationPermissions$Callback
				/// </java-name>
				[Dot42.DexImport("android/webkit/GeolocationPermissions$Callback", AccessFlags = 1545)]
				public partial interface ICallback
 /* scope: __dot42__ */ 
				{
						/// <summary>
						/// <para>Sets the Geolocation permission state for the supplied origin.</para><para></para>        
						/// </summary>
						/// <java-name>
						/// invoke
						/// </java-name>
						[Dot42.DexImport("invoke", "(Ljava/lang/String;ZZ)V", AccessFlags = 1025)]
						void Invoke(string origin, bool allow, bool retain) /* MethodBuilder.Create */ ;

				}

		}

		/// <summary>
		/// <para>Manages settings state for a WebView. When a WebView is first created, it obtains a set of default settings. These default settings will be returned from any getter call. A WebSettings object obtained from WebView.getSettings() is tied to the life of the WebView. If a WebView has been destroyed, any method call on WebSettings will throw an IllegalStateException. </para>    
		/// </summary>
		/// <java-name>
		/// android/webkit/WebSettings
		/// </java-name>
		[Dot42.DexImport("android/webkit/WebSettings", AccessFlags = 33)]
		public partial class WebSettings
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Default cache usage mode. If the navigation type doesn't impose any specific behavior, use cached resources when they are available and not expired, otherwise load resources from the network. Use with setCacheMode. </para>        
				/// </summary>
				/// <java-name>
				/// LOAD_DEFAULT
				/// </java-name>
				[Dot42.DexImport("LOAD_DEFAULT", "I", AccessFlags = 25)]
				public const int LOAD_DEFAULT = -1;
				/// <summary>
				/// <para>Normal cache usage mode. Use with setCacheMode.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>This value is obsolete, as from API level android.os.Build.VERSION_CODES#HONEYCOMB and onwards it has the same effect as LOAD_DEFAULT. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// LOAD_NORMAL
				/// </java-name>
				[Dot42.DexImport("LOAD_NORMAL", "I", AccessFlags = 25)]
				public const int LOAD_NORMAL = 0;
				/// <summary>
				/// <para>Use cached resources when they are available, even if they have expired. Otherwise load resources from the network. Use with setCacheMode. </para>        
				/// </summary>
				/// <java-name>
				/// LOAD_CACHE_ELSE_NETWORK
				/// </java-name>
				[Dot42.DexImport("LOAD_CACHE_ELSE_NETWORK", "I", AccessFlags = 25)]
				public const int LOAD_CACHE_ELSE_NETWORK = 1;
				/// <summary>
				/// <para>Don't use the cache, load from the network. Use with setCacheMode. </para>        
				/// </summary>
				/// <java-name>
				/// LOAD_NO_CACHE
				/// </java-name>
				[Dot42.DexImport("LOAD_NO_CACHE", "I", AccessFlags = 25)]
				public const int LOAD_NO_CACHE = 2;
				/// <summary>
				/// <para>Don't use the network, load from the cache. Use with setCacheMode. </para>        
				/// </summary>
				/// <java-name>
				/// LOAD_CACHE_ONLY
				/// </java-name>
				[Dot42.DexImport("LOAD_CACHE_ONLY", "I", AccessFlags = 25)]
				public const int LOAD_CACHE_ONLY = 3;
				/// <summary>
				/// <para>Hidden constructor to prevent clients from creating a new settings instance or deriving the class.</para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal WebSettings() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Enables dumping the pages navigation cache to a text file. The default is false.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>This method is now obsolete.  Since API level android.os.Build.VERSION_CODES#JELLY_BEAN_MR1 </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// setNavDump
				/// </java-name>
				[Dot42.DexImport("setNavDump", "(Z)V", AccessFlags = 1)]
				public virtual void SetNavDump(bool enabled) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets whether dumping the navigation cache is enabled.</para><para><para>setNavDump </para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>This method is now obsolete.  Since API level android.os.Build.VERSION_CODES#JELLY_BEAN_MR1 </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				/// <para>whether dumping the navigation cache is enabled </para>
				/// </returns>
				/// <java-name>
				/// getNavDump
				/// </java-name>
				[Dot42.DexImport("getNavDump", "()Z", AccessFlags = 1)]
				public virtual bool GetNavDump() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Sets whether the WebView should support zooming using its on-screen zoom controls and gestures. The particular zoom mechanisms that should be used can be set with setBuiltInZoomControls. This setting does not affect zooming performed using the WebView#zoomIn() and WebView#zoomOut() methods. The default is true.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setSupportZoom
				/// </java-name>
				[Dot42.DexImport("setSupportZoom", "(Z)V", AccessFlags = 1)]
				public virtual void SetSupportZoom(bool support) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets whether the WebView supports zoom.</para><para><para>setSupportZoom </para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if the WebView supports zoom </para>
				/// </returns>
				/// <java-name>
				/// supportZoom
				/// </java-name>
				[Dot42.DexImport("supportZoom", "()Z", AccessFlags = 1)]
				public virtual bool SupportZoom() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Sets whether the WebView should use its built-in zoom mechanisms. The built-in zoom mechanisms comprise on-screen zoom controls, which are displayed over the WebView's content, and the use of a pinch gesture to control zooming. Whether or not these on-screen controls are displayed can be set with setDisplayZoomControls. The default is false. </para><para>The built-in mechanisms are the only currently supported zoom mechanisms, so it is recommended that this setting is always enabled.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setBuiltInZoomControls
				/// </java-name>
				[Dot42.DexImport("setBuiltInZoomControls", "(Z)V", AccessFlags = 1)]
				public virtual void SetBuiltInZoomControls(bool enabled) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets whether the zoom mechanisms built into WebView are being used.</para><para><para>setBuiltInZoomControls </para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if the zoom mechanisms built into WebView are being used </para>
				/// </returns>
				/// <java-name>
				/// getBuiltInZoomControls
				/// </java-name>
				[Dot42.DexImport("getBuiltInZoomControls", "()Z", AccessFlags = 1)]
				public virtual bool GetBuiltInZoomControls() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Sets whether the WebView should display on-screen zoom controls when using the built-in zoom mechanisms. See setBuiltInZoomControls. The default is true.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setDisplayZoomControls
				/// </java-name>
				[Dot42.DexImport("setDisplayZoomControls", "(Z)V", AccessFlags = 1)]
				public virtual void SetDisplayZoomControls(bool enabled) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets whether the WebView displays on-screen zoom controls when using the built-in zoom mechanisms.</para><para><para>setDisplayZoomControls </para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if the WebView displays on-screen zoom controls when using the built-in zoom mechanisms </para>
				/// </returns>
				/// <java-name>
				/// getDisplayZoomControls
				/// </java-name>
				[Dot42.DexImport("getDisplayZoomControls", "()Z", AccessFlags = 1)]
				public virtual bool GetDisplayZoomControls() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Enables or disables file access within WebView. File access is enabled by default. Note that this enables or disables file system access only. Assets and resources are still accessible using  and . </para>        
				/// </summary>
				/// <java-name>
				/// setAllowFileAccess
				/// </java-name>
				[Dot42.DexImport("setAllowFileAccess", "(Z)V", AccessFlags = 1)]
				public virtual void SetAllowFileAccess(bool allow) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets whether this WebView supports file access.</para><para><para>setAllowFileAccess </para></para>        
				/// </summary>
				/// <java-name>
				/// getAllowFileAccess
				/// </java-name>
				[Dot42.DexImport("getAllowFileAccess", "()Z", AccessFlags = 1)]
				public virtual bool GetAllowFileAccess() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Enables or disables content URL access within WebView. Content URL access allows WebView to load content from a content provider installed in the system. The default is enabled. </para>        
				/// </summary>
				/// <java-name>
				/// setAllowContentAccess
				/// </java-name>
				[Dot42.DexImport("setAllowContentAccess", "(Z)V", AccessFlags = 1)]
				public virtual void SetAllowContentAccess(bool allow) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets whether this WebView supports content URL access.</para><para><para>setAllowContentAccess </para></para>        
				/// </summary>
				/// <java-name>
				/// getAllowContentAccess
				/// </java-name>
				[Dot42.DexImport("getAllowContentAccess", "()Z", AccessFlags = 1)]
				public virtual bool GetAllowContentAccess() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Sets whether the WebView loads pages in overview mode. The default is false. </para>        
				/// </summary>
				/// <java-name>
				/// setLoadWithOverviewMode
				/// </java-name>
				[Dot42.DexImport("setLoadWithOverviewMode", "(Z)V", AccessFlags = 1)]
				public virtual void SetLoadWithOverviewMode(bool overview) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets whether this WebView loads pages in overview mode.</para><para><para>setLoadWithOverviewMode </para></para>        
				/// </summary>
				/// <returns>
				/// <para>whether this WebView loads pages in overview mode </para>
				/// </returns>
				/// <java-name>
				/// getLoadWithOverviewMode
				/// </java-name>
				[Dot42.DexImport("getLoadWithOverviewMode", "()Z", AccessFlags = 1)]
				public virtual bool GetLoadWithOverviewMode() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Sets whether the WebView will enable smooth transition while panning or zooming or while the window hosting the WebView does not have focus. If it is true, WebView will choose a solution to maximize the performance. e.g. the WebView's content may not be updated during the transition. If it is false, WebView will keep its fidelity. The default value is false.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>This method is now obsolete, and will become a no-op in future. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// setEnableSmoothTransition
				/// </java-name>
				[Dot42.DexImport("setEnableSmoothTransition", "(Z)V", AccessFlags = 1)]
				public virtual void SetEnableSmoothTransition(bool enable) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets whether the WebView enables smooth transition while panning or zooming.</para><para><para>setEnableSmoothTransition</para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>This method is now obsolete, and will become a no-op in future. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// enableSmoothTransition
				/// </java-name>
				[Dot42.DexImport("enableSmoothTransition", "()Z", AccessFlags = 1)]
				public virtual bool EnableSmoothTransition() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Sets whether the WebView uses its background for over scroll background. If true, it will use the WebView's background. If false, it will use an internal pattern. Default is true.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>This method is now obsolete.  Since API level android.os.Build.VERSION_CODES#JELLY_BEAN_MR1 </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// setUseWebViewBackgroundForOverscrollBackground
				/// </java-name>
				[Dot42.DexImport("setUseWebViewBackgroundForOverscrollBackground", "(Z)V", AccessFlags = 1)]
				public virtual void SetUseWebViewBackgroundForOverscrollBackground(bool view) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets whether this WebView uses WebView's background instead of internal pattern for over scroll background.</para><para><para>setUseWebViewBackgroundForOverscrollBackground </para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>This method is now obsolete.  Since API level android.os.Build.VERSION_CODES#JELLY_BEAN_MR1 </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// getUseWebViewBackgroundForOverscrollBackground
				/// </java-name>
				[Dot42.DexImport("getUseWebViewBackgroundForOverscrollBackground", "()Z", AccessFlags = 1)]
				public virtual bool GetUseWebViewBackgroundForOverscrollBackground() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Sets whether the WebView should save form data. The default is true. </para>        
				/// </summary>
				/// <java-name>
				/// setSaveFormData
				/// </java-name>
				[Dot42.DexImport("setSaveFormData", "(Z)V", AccessFlags = 1)]
				public virtual void SetSaveFormData(bool save) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets whether the WebView saves form data.</para><para><para>setSaveFormData </para></para>        
				/// </summary>
				/// <returns>
				/// <para>whether the WebView saves form data </para>
				/// </returns>
				/// <java-name>
				/// getSaveFormData
				/// </java-name>
				[Dot42.DexImport("getSaveFormData", "()Z", AccessFlags = 1)]
				public virtual bool GetSaveFormData() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Sets whether the WebView should save passwords. The default is true. <xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>Saving passwords in WebView will not be supported in future versions. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// setSavePassword
				/// </java-name>
				[Dot42.DexImport("setSavePassword", "(Z)V", AccessFlags = 1)]
				public virtual void SetSavePassword(bool save) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets whether the WebView saves passwords.</para><para><para>setSavePassword </para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>Saving passwords in WebView will not be supported in future versions. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				/// <para>whether the WebView saves passwords </para>
				/// </returns>
				/// <java-name>
				/// getSavePassword
				/// </java-name>
				[Dot42.DexImport("getSavePassword", "()Z", AccessFlags = 1)]
				public virtual bool GetSavePassword() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Sets the text zoom of the page in percent. The default is 100.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setTextZoom
				/// </java-name>
				[Dot42.DexImport("setTextZoom", "(I)V", AccessFlags = 33)]
				public virtual void SetTextZoom(int textZoom) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets the text zoom of the page in percent.</para><para><para>setTextZoom </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the text zoom of the page in percent </para>
				/// </returns>
				/// <java-name>
				/// getTextZoom
				/// </java-name>
				[Dot42.DexImport("getTextZoom", "()I", AccessFlags = 33)]
				public virtual int GetTextZoom() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Sets the text size of the page. The default is TextSize#NORMAL.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>Use setTextZoom instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// setTextSize
				/// </java-name>
				[Dot42.DexImport("setTextSize", "(Landroid/webkit/WebSettings$TextSize;)V", AccessFlags = 33)]
				public virtual void SetTextSize(global::Android.Webkit.WebSettings.TextSize t) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets the text size of the page. If the text size was previously specified in percent using setTextZoom, this will return the closest matching TextSize.</para><para><para>setTextSize </para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>Use getTextZoom instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				/// <para>the text size as a TextSize value </para>
				/// </returns>
				/// <java-name>
				/// getTextSize
				/// </java-name>
				[Dot42.DexImport("getTextSize", "()Landroid/webkit/WebSettings$TextSize;", AccessFlags = 33)]
				public virtual global::Android.Webkit.WebSettings.TextSize GetTextSize() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Webkit.WebSettings.TextSize);
				}

				/// <summary>
				/// <para>Sets the default zoom density of the page. This must be called from the UI thread. The default is ZoomDensity#MEDIUM.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setDefaultZoom
				/// </java-name>
				[Dot42.DexImport("setDefaultZoom", "(Landroid/webkit/WebSettings$ZoomDensity;)V", AccessFlags = 1)]
				public virtual void SetDefaultZoom(global::Android.Webkit.WebSettings.ZoomDensity zoom) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets the default zoom density of the page. This should be called from the UI thread.</para><para><para>setDefaultZoom </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the zoom density </para>
				/// </returns>
				/// <java-name>
				/// getDefaultZoom
				/// </java-name>
				[Dot42.DexImport("getDefaultZoom", "()Landroid/webkit/WebSettings$ZoomDensity;", AccessFlags = 1)]
				public virtual global::Android.Webkit.WebSettings.ZoomDensity GetDefaultZoom() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Webkit.WebSettings.ZoomDensity);
				}

				/// <summary>
				/// <para>Enables using light touches to make a selection and activate mouseovers. <xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>From android.os.Build.VERSION_CODES#JELLY_BEAN this setting is obsolete and has no effect. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// setLightTouchEnabled
				/// </java-name>
				[Dot42.DexImport("setLightTouchEnabled", "(Z)V", AccessFlags = 1)]
				public virtual void SetLightTouchEnabled(bool enabled) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets whether light touches are enabled. <para>setLightTouchEnabled </para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>This setting is obsolete. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// getLightTouchEnabled
				/// </java-name>
				[Dot42.DexImport("getLightTouchEnabled", "()Z", AccessFlags = 1)]
				public virtual bool GetLightTouchEnabled() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Controlled a rendering optimization that is no longer present. Setting it now has no effect.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>This setting now has no effect.  Since API level android.os.Build.VERSION_CODES#JELLY_BEAN_MR1 </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// setUseDoubleTree
				/// </java-name>
				[Dot42.DexImport("setUseDoubleTree", "(Z)V", AccessFlags = 33)]
				public virtual void SetUseDoubleTree(bool use) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Controlled a rendering optimization that is no longer present. Setting it now has no effect.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>This setting now has no effect.  Since API level android.os.Build.VERSION_CODES#JELLY_BEAN_MR1 </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// getUseDoubleTree
				/// </java-name>
				[Dot42.DexImport("getUseDoubleTree", "()Z", AccessFlags = 33)]
				public virtual bool GetUseDoubleTree() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Sets the user-agent string using an integer code. <ul><li><para>0 means the WebView should use an Android user-agent string </para></li><li><para>1 means the WebView should use a desktop user-agent string </para></li></ul>Other values are ignored. The default is an Android user-agent string, i.e. code value 0.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>Please use setUserAgentString instead.  Since API level android.os.Build.VERSION_CODES#JELLY_BEAN_MR1 </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// setUserAgent
				/// </java-name>
				[Dot42.DexImport("setUserAgent", "(I)V", AccessFlags = 33)]
				public virtual void SetUserAgent(int ua) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets the user-agent as an integer code. <ul><li><para>-1 means the WebView is using a custom user-agent string set with setUserAgentString </para></li><li><para>0 means the WebView should use an Android user-agent string </para></li><li><para>1 means the WebView should use a desktop user-agent string </para></li></ul></para><para><para>setUserAgent </para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>Please use getUserAgentString instead.  Since API level android.os.Build.VERSION_CODES#JELLY_BEAN_MR1 </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				/// <para>the integer code for the user-agent string </para>
				/// </returns>
				/// <java-name>
				/// getUserAgent
				/// </java-name>
				[Dot42.DexImport("getUserAgent", "()I", AccessFlags = 33)]
				public virtual int GetUserAgent() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Sets whether the WebView should enable support for the "viewport" HTML meta tag or should use a wide viewport. When the value of the setting is false, the layout width is always set to the width of the WebView control in device-independent (CSS) pixels. When the value is true and the page contains the viewport meta tag, the value of the width specified in the tag is used. If the page does not contain the tag or does not provide a width, then a wide viewport will be used.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setUseWideViewPort
				/// </java-name>
				[Dot42.DexImport("setUseWideViewPort", "(Z)V", AccessFlags = 33)]
				public virtual void SetUseWideViewPort(bool use) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets whether the WebView supports the "viewport" HTML meta tag or will use a wide viewport.</para><para><para>setUseWideViewPort </para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if the WebView supports the viewport meta tag </para>
				/// </returns>
				/// <java-name>
				/// getUseWideViewPort
				/// </java-name>
				[Dot42.DexImport("getUseWideViewPort", "()Z", AccessFlags = 33)]
				public virtual bool GetUseWideViewPort() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Sets whether the WebView whether supports multiple windows. If set to true, WebChromeClient#onCreateWindow must be implemented by the host application. The default is false.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setSupportMultipleWindows
				/// </java-name>
				[Dot42.DexImport("setSupportMultipleWindows", "(Z)V", AccessFlags = 33)]
				public virtual void SetSupportMultipleWindows(bool support) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets whether the WebView supports multiple windows.</para><para><para>setSupportMultipleWindows </para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if the WebView supports multiple windows </para>
				/// </returns>
				/// <java-name>
				/// supportMultipleWindows
				/// </java-name>
				[Dot42.DexImport("supportMultipleWindows", "()Z", AccessFlags = 33)]
				public virtual bool SupportMultipleWindows() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Sets the underlying layout algorithm. This will cause a relayout of the WebView. The default is LayoutAlgorithm#NARROW_COLUMNS.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setLayoutAlgorithm
				/// </java-name>
				[Dot42.DexImport("setLayoutAlgorithm", "(Landroid/webkit/WebSettings$LayoutAlgorithm;)V", AccessFlags = 33)]
				public virtual void SetLayoutAlgorithm(global::Android.Webkit.WebSettings.LayoutAlgorithm l) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets the current layout algorithm.</para><para><para>setLayoutAlgorithm </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the layout algorithm in use, as a LayoutAlgorithm value </para>
				/// </returns>
				/// <java-name>
				/// getLayoutAlgorithm
				/// </java-name>
				[Dot42.DexImport("getLayoutAlgorithm", "()Landroid/webkit/WebSettings$LayoutAlgorithm;", AccessFlags = 33)]
				public virtual global::Android.Webkit.WebSettings.LayoutAlgorithm GetLayoutAlgorithm() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Webkit.WebSettings.LayoutAlgorithm);
				}

				/// <summary>
				/// <para>Sets the standard font family name. The default is "sans-serif".</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setStandardFontFamily
				/// </java-name>
				[Dot42.DexImport("setStandardFontFamily", "(Ljava/lang/String;)V", AccessFlags = 33)]
				public virtual void SetStandardFontFamily(string font) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets the standard font family name.</para><para><para>setStandardFontFamily </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the standard font family name as a string </para>
				/// </returns>
				/// <java-name>
				/// getStandardFontFamily
				/// </java-name>
				[Dot42.DexImport("getStandardFontFamily", "()Ljava/lang/String;", AccessFlags = 33)]
				public virtual string GetStandardFontFamily() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Sets the fixed font family name. The default is "monospace".</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setFixedFontFamily
				/// </java-name>
				[Dot42.DexImport("setFixedFontFamily", "(Ljava/lang/String;)V", AccessFlags = 33)]
				public virtual void SetFixedFontFamily(string font) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets the fixed font family name.</para><para><para>setFixedFontFamily </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the fixed font family name as a string </para>
				/// </returns>
				/// <java-name>
				/// getFixedFontFamily
				/// </java-name>
				[Dot42.DexImport("getFixedFontFamily", "()Ljava/lang/String;", AccessFlags = 33)]
				public virtual string GetFixedFontFamily() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Sets the sans-serif font family name. The default is "sans-serif".</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setSansSerifFontFamily
				/// </java-name>
				[Dot42.DexImport("setSansSerifFontFamily", "(Ljava/lang/String;)V", AccessFlags = 33)]
				public virtual void SetSansSerifFontFamily(string font) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets the sans-serif font family name.</para><para><para>setSansSerifFontFamily </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the sans-serif font family name as a string </para>
				/// </returns>
				/// <java-name>
				/// getSansSerifFontFamily
				/// </java-name>
				[Dot42.DexImport("getSansSerifFontFamily", "()Ljava/lang/String;", AccessFlags = 33)]
				public virtual string GetSansSerifFontFamily() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Sets the serif font family name. The default is "sans-serif".</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setSerifFontFamily
				/// </java-name>
				[Dot42.DexImport("setSerifFontFamily", "(Ljava/lang/String;)V", AccessFlags = 33)]
				public virtual void SetSerifFontFamily(string font) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets the serif font family name. The default is "serif".</para><para><para>setSerifFontFamily </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the serif font family name as a string </para>
				/// </returns>
				/// <java-name>
				/// getSerifFontFamily
				/// </java-name>
				[Dot42.DexImport("getSerifFontFamily", "()Ljava/lang/String;", AccessFlags = 33)]
				public virtual string GetSerifFontFamily() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Sets the cursive font family name. The default is "cursive".</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setCursiveFontFamily
				/// </java-name>
				[Dot42.DexImport("setCursiveFontFamily", "(Ljava/lang/String;)V", AccessFlags = 33)]
				public virtual void SetCursiveFontFamily(string font) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets the cursive font family name.</para><para><para>setCursiveFontFamily </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the cursive font family name as a string </para>
				/// </returns>
				/// <java-name>
				/// getCursiveFontFamily
				/// </java-name>
				[Dot42.DexImport("getCursiveFontFamily", "()Ljava/lang/String;", AccessFlags = 33)]
				public virtual string GetCursiveFontFamily() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Sets the fantasy font family name. The default is "fantasy".</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setFantasyFontFamily
				/// </java-name>
				[Dot42.DexImport("setFantasyFontFamily", "(Ljava/lang/String;)V", AccessFlags = 33)]
				public virtual void SetFantasyFontFamily(string font) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets the fantasy font family name.</para><para><para>setFantasyFontFamily </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the fantasy font family name as a string </para>
				/// </returns>
				/// <java-name>
				/// getFantasyFontFamily
				/// </java-name>
				[Dot42.DexImport("getFantasyFontFamily", "()Ljava/lang/String;", AccessFlags = 33)]
				public virtual string GetFantasyFontFamily() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Sets the minimum font size. The default is 8.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setMinimumFontSize
				/// </java-name>
				[Dot42.DexImport("setMinimumFontSize", "(I)V", AccessFlags = 33)]
				public virtual void SetMinimumFontSize(int size) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets the minimum font size.</para><para><para>setMinimumFontSize </para></para>        
				/// </summary>
				/// <returns>
				/// <para>a non-negative integer between 1 and 72 </para>
				/// </returns>
				/// <java-name>
				/// getMinimumFontSize
				/// </java-name>
				[Dot42.DexImport("getMinimumFontSize", "()I", AccessFlags = 33)]
				public virtual int GetMinimumFontSize() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Sets the minimum logical font size. The default is 8.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setMinimumLogicalFontSize
				/// </java-name>
				[Dot42.DexImport("setMinimumLogicalFontSize", "(I)V", AccessFlags = 33)]
				public virtual void SetMinimumLogicalFontSize(int size) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets the minimum logical font size.</para><para><para>setMinimumLogicalFontSize </para></para>        
				/// </summary>
				/// <returns>
				/// <para>a non-negative integer between 1 and 72 </para>
				/// </returns>
				/// <java-name>
				/// getMinimumLogicalFontSize
				/// </java-name>
				[Dot42.DexImport("getMinimumLogicalFontSize", "()I", AccessFlags = 33)]
				public virtual int GetMinimumLogicalFontSize() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Sets the default font size. The default is 16.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setDefaultFontSize
				/// </java-name>
				[Dot42.DexImport("setDefaultFontSize", "(I)V", AccessFlags = 33)]
				public virtual void SetDefaultFontSize(int size) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets the default font size.</para><para><para>setDefaultFontSize </para></para>        
				/// </summary>
				/// <returns>
				/// <para>a non-negative integer between 1 and 72 </para>
				/// </returns>
				/// <java-name>
				/// getDefaultFontSize
				/// </java-name>
				[Dot42.DexImport("getDefaultFontSize", "()I", AccessFlags = 33)]
				public virtual int GetDefaultFontSize() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Sets the default fixed font size. The default is 16.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setDefaultFixedFontSize
				/// </java-name>
				[Dot42.DexImport("setDefaultFixedFontSize", "(I)V", AccessFlags = 33)]
				public virtual void SetDefaultFixedFontSize(int size) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets the default fixed font size.</para><para><para>setDefaultFixedFontSize </para></para>        
				/// </summary>
				/// <returns>
				/// <para>a non-negative integer between 1 and 72 </para>
				/// </returns>
				/// <java-name>
				/// getDefaultFixedFontSize
				/// </java-name>
				[Dot42.DexImport("getDefaultFixedFontSize", "()I", AccessFlags = 33)]
				public virtual int GetDefaultFixedFontSize() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Sets whether the WebView should load image resources. Note that this method controls loading of all images, including those embedded using the data URI scheme. Use setBlockNetworkImage to control loading only of images specified using network URI schemes. Note that if the value of this setting is changed from false to true, all images resources referenced by content currently displayed by the WebView are loaded automatically. The default is true.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setLoadsImagesAutomatically
				/// </java-name>
				[Dot42.DexImport("setLoadsImagesAutomatically", "(Z)V", AccessFlags = 33)]
				public virtual void SetLoadsImagesAutomatically(bool flag) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets whether the WebView loads image resources. This includes images embedded using the data URI scheme.</para><para><para>setLoadsImagesAutomatically </para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if the WebView loads image resources </para>
				/// </returns>
				/// <java-name>
				/// getLoadsImagesAutomatically
				/// </java-name>
				[Dot42.DexImport("getLoadsImagesAutomatically", "()Z", AccessFlags = 33)]
				public virtual bool GetLoadsImagesAutomatically() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Sets whether the WebView should not load image resources from the network (resources accessed via http and https URI schemes). Note that this method has no effect unless getLoadsImagesAutomatically returns true. Also note that disabling all network loads using setBlockNetworkLoads will also prevent network images from loading, even if this flag is set to false. When the value of this setting is changed from true to false, network images resources referenced by content currently displayed by the WebView are fetched automatically. The default is false.</para><para><para>setBlockNetworkLoads </para></para>        
				/// </summary>
				/// <java-name>
				/// setBlockNetworkImage
				/// </java-name>
				[Dot42.DexImport("setBlockNetworkImage", "(Z)V", AccessFlags = 33)]
				public virtual void SetBlockNetworkImage(bool flag) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets whether the WebView does not load image resources from the network.</para><para><para>setBlockNetworkImage </para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if the WebView does not load image resources from the network </para>
				/// </returns>
				/// <java-name>
				/// getBlockNetworkImage
				/// </java-name>
				[Dot42.DexImport("getBlockNetworkImage", "()Z", AccessFlags = 33)]
				public virtual bool GetBlockNetworkImage() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Sets whether the WebView should not load resources from the network. Use setBlockNetworkImage to only avoid loading image resources. Note that if the value of this setting is changed from true to false, network resources referenced by content currently displayed by the WebView are not fetched until android.webkit.WebView#reload is called. If the application does not have the android.Manifest.permission#INTERNET permission, attempts to set a value of false will cause a java.lang.SecurityException to be thrown. The default value is false if the application has the android.Manifest.permission#INTERNET permission, otherwise it is true.</para><para><para>android.webkit.WebView::reload </para></para>        
				/// </summary>
				/// <java-name>
				/// setBlockNetworkLoads
				/// </java-name>
				[Dot42.DexImport("setBlockNetworkLoads", "(Z)V", AccessFlags = 33)]
				public virtual void SetBlockNetworkLoads(bool flag) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets whether the WebView does not load any resources from the network.</para><para><para>setBlockNetworkLoads </para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if the WebView does not load any resources from the network </para>
				/// </returns>
				/// <java-name>
				/// getBlockNetworkLoads
				/// </java-name>
				[Dot42.DexImport("getBlockNetworkLoads", "()Z", AccessFlags = 33)]
				public virtual bool GetBlockNetworkLoads() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Tells the WebView to enable JavaScript execution. <b>The default is false.</b></para><para></para>        
				/// </summary>
				/// <java-name>
				/// setJavaScriptEnabled
				/// </java-name>
				[Dot42.DexImport("setJavaScriptEnabled", "(Z)V", AccessFlags = 33)]
				public virtual void SetJavaScriptEnabled(bool flag) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets whether the WebView should enable plugins. The default is false.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>This method has been deprecated in favor of setPluginState  Since API level android.os.Build.VERSION_CODES#JELLY_BEAN_MR2 </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// setPluginsEnabled
				/// </java-name>
				[Dot42.DexImport("setPluginsEnabled", "(Z)V", AccessFlags = 33)]
				public virtual void SetPluginsEnabled(bool flag) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Tells the WebView to enable, disable, or have plugins on demand. On demand mode means that if a plugin exists that can handle the embedded content, a placeholder icon will be shown instead of the plugin. When the placeholder is clicked, the plugin will be enabled. The default is PluginState#OFF.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>Plugins will not be supported in future, and should not be used. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// setPluginState
				/// </java-name>
				[Dot42.DexImport("setPluginState", "(Landroid/webkit/WebSettings$PluginState;)V", AccessFlags = 33)]
				public virtual void SetPluginState(global::Android.Webkit.WebSettings.PluginState state) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets a custom path to plugins used by the WebView. This method is obsolete since each plugin is now loaded from its own package.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>This method is no longer used as plugins are loaded from their own APK via the system's package manager.  Since API level android.os.Build.VERSION_CODES#JELLY_BEAN_MR2 </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// setPluginsPath
				/// </java-name>
				[Dot42.DexImport("setPluginsPath", "(Ljava/lang/String;)V", AccessFlags = 33)]
				public virtual void SetPluginsPath(string pluginsPath) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the path to where database storage API databases should be saved. In order for the database storage API to function correctly, this method must be called with a path to which the application can write. This method should only be called once: repeated calls are ignored.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setDatabasePath
				/// </java-name>
				[Dot42.DexImport("setDatabasePath", "(Ljava/lang/String;)V", AccessFlags = 33)]
				public virtual void SetDatabasePath(string databasePath) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the path where the Geolocation databases should be saved. In order for Geolocation permissions and cached positions to be persisted, this method must be called with a path to which the application can write.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setGeolocationDatabasePath
				/// </java-name>
				[Dot42.DexImport("setGeolocationDatabasePath", "(Ljava/lang/String;)V", AccessFlags = 33)]
				public virtual void SetGeolocationDatabasePath(string databasePath) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets whether the Application Caches API should be enabled. The default is false. Note that in order for the Application Caches API to be enabled, a valid database path must also be supplied to setAppCachePath.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setAppCacheEnabled
				/// </java-name>
				[Dot42.DexImport("setAppCacheEnabled", "(Z)V", AccessFlags = 33)]
				public virtual void SetAppCacheEnabled(bool flag) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the path to the Application Caches files. In order for the Application Caches API to be enabled, this method must be called with a path to which the application can write. This method should only be called once: repeated calls are ignored.</para><para><para>setAppCacheEnabled </para></para>        
				/// </summary>
				/// <java-name>
				/// setAppCachePath
				/// </java-name>
				[Dot42.DexImport("setAppCachePath", "(Ljava/lang/String;)V", AccessFlags = 33)]
				public virtual void SetAppCachePath(string appCachePath) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the maximum size for the Application Cache content. The passed size will be rounded to the nearest value that the database can support, so this should be viewed as a guide, not a hard limit. Setting the size to a value less than current database size does not cause the database to be trimmed. The default size is Long#MAX_VALUE. It is recommended to leave the maximum size set to the default value.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>In future quota will be managed automatically. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// setAppCacheMaxSize
				/// </java-name>
				[Dot42.DexImport("setAppCacheMaxSize", "(J)V", AccessFlags = 33)]
				public virtual void SetAppCacheMaxSize(long appCacheMaxSize) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets whether the database storage API is enabled. The default value is false. See also setDatabasePath for how to correctly set up the database storage API.</para><para>This setting is global in effect, across all WebView instances in a process. Note you should only modify this setting prior to making <b>any</b> WebView page load within a given process, as the WebView implementation may ignore changes to this setting after that point.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setDatabaseEnabled
				/// </java-name>
				[Dot42.DexImport("setDatabaseEnabled", "(Z)V", AccessFlags = 33)]
				public virtual void SetDatabaseEnabled(bool flag) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets whether the DOM storage API is enabled. The default value is false.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setDomStorageEnabled
				/// </java-name>
				[Dot42.DexImport("setDomStorageEnabled", "(Z)V", AccessFlags = 33)]
				public virtual void SetDomStorageEnabled(bool flag) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets whether the DOM Storage APIs are enabled.</para><para><para>setDomStorageEnabled </para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if the DOM Storage APIs are enabled </para>
				/// </returns>
				/// <java-name>
				/// getDomStorageEnabled
				/// </java-name>
				[Dot42.DexImport("getDomStorageEnabled", "()Z", AccessFlags = 33)]
				public virtual bool GetDomStorageEnabled() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Gets the path to where database storage API databases are saved.</para><para><para>setDatabasePath </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the String path to the database storage API databases </para>
				/// </returns>
				/// <java-name>
				/// getDatabasePath
				/// </java-name>
				[Dot42.DexImport("getDatabasePath", "()Ljava/lang/String;", AccessFlags = 33)]
				public virtual string GetDatabasePath() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Gets whether the database storage API is enabled.</para><para><para>setDatabaseEnabled </para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if the database storage API is enabled </para>
				/// </returns>
				/// <java-name>
				/// getDatabaseEnabled
				/// </java-name>
				[Dot42.DexImport("getDatabaseEnabled", "()Z", AccessFlags = 33)]
				public virtual bool GetDatabaseEnabled() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Sets whether Geolocation is enabled. The default is true. </para><para>Please note that in order for the Geolocation API to be usable by a page in the WebView, the following requirements must be met: <ul><li><para>an application must have permission to access the device location, see android.Manifest.permission#ACCESS_COARSE_LOCATION, android.Manifest.permission#ACCESS_FINE_LOCATION; </para></li><li><para>an application must provide an implementation of the WebChromeClient#onGeolocationPermissionsShowPrompt callback to receive notifications that a page is requesting access to location via the JavaScript Geolocation API. </para></li></ul></para><para>As an option, it is possible to store previous locations and web origin permissions in a database. See setGeolocationDatabasePath.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setGeolocationEnabled
				/// </java-name>
				[Dot42.DexImport("setGeolocationEnabled", "(Z)V", AccessFlags = 33)]
				public virtual void SetGeolocationEnabled(bool flag) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets whether JavaScript is enabled.</para><para><para>setJavaScriptEnabled </para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if JavaScript is enabled </para>
				/// </returns>
				/// <java-name>
				/// getJavaScriptEnabled
				/// </java-name>
				[Dot42.DexImport("getJavaScriptEnabled", "()Z", AccessFlags = 33)]
				public virtual bool GetJavaScriptEnabled() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Gets whether plugins are enabled.</para><para><para>setPluginsEnabled </para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>This method has been replaced by getPluginState  Since API level android.os.Build.VERSION_CODES#JELLY_BEAN_MR2 </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				/// <para>true if plugins are enabled </para>
				/// </returns>
				/// <java-name>
				/// getPluginsEnabled
				/// </java-name>
				[Dot42.DexImport("getPluginsEnabled", "()Z", AccessFlags = 33)]
				public virtual bool GetPluginsEnabled() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Gets the current state regarding whether plugins are enabled.</para><para><para>setPluginState </para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>Plugins will not be supported in future, and should not be used. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				/// <para>the plugin state as a PluginState value </para>
				/// </returns>
				/// <java-name>
				/// getPluginState
				/// </java-name>
				[Dot42.DexImport("getPluginState", "()Landroid/webkit/WebSettings$PluginState;", AccessFlags = 33)]
				public virtual global::Android.Webkit.WebSettings.PluginState GetPluginState() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Webkit.WebSettings.PluginState);
				}

				/// <summary>
				/// <para>Gets the directory that contains the plugin libraries. This method is obsolete since each plugin is now loaded from its own package.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>This method is no longer used as plugins are loaded from their own APK via the system's package manager.  Since API level android.os.Build.VERSION_CODES#JELLY_BEAN_MR2 </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				/// <para>an empty string </para>
				/// </returns>
				/// <java-name>
				/// getPluginsPath
				/// </java-name>
				[Dot42.DexImport("getPluginsPath", "()Ljava/lang/String;", AccessFlags = 33)]
				public virtual string GetPluginsPath() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Tells JavaScript to open windows automatically. This applies to the JavaScript function window.open(). The default is false.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setJavaScriptCanOpenWindowsAutomatically
				/// </java-name>
				[Dot42.DexImport("setJavaScriptCanOpenWindowsAutomatically", "(Z)V", AccessFlags = 33)]
				public virtual void SetJavaScriptCanOpenWindowsAutomatically(bool flag) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets whether JavaScript can open windows automatically.</para><para><para>setJavaScriptCanOpenWindowsAutomatically </para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if JavaScript can open windows automatically during window.open() </para>
				/// </returns>
				/// <java-name>
				/// getJavaScriptCanOpenWindowsAutomatically
				/// </java-name>
				[Dot42.DexImport("getJavaScriptCanOpenWindowsAutomatically", "()Z", AccessFlags = 33)]
				public virtual bool GetJavaScriptCanOpenWindowsAutomatically() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Sets the default text encoding name to use when decoding html pages. The default is "Latin-1".</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setDefaultTextEncodingName
				/// </java-name>
				[Dot42.DexImport("setDefaultTextEncodingName", "(Ljava/lang/String;)V", AccessFlags = 33)]
				public virtual void SetDefaultTextEncodingName(string encoding) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets the default text encoding name.</para><para><para>setDefaultTextEncodingName </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the default text encoding name as a string </para>
				/// </returns>
				/// <java-name>
				/// getDefaultTextEncodingName
				/// </java-name>
				[Dot42.DexImport("getDefaultTextEncodingName", "()Ljava/lang/String;", AccessFlags = 33)]
				public virtual string GetDefaultTextEncodingName() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Sets the WebView's user-agent string. If the string is null or empty, the system default value will be used. </para>        
				/// </summary>
				/// <java-name>
				/// setUserAgentString
				/// </java-name>
				[Dot42.DexImport("setUserAgentString", "(Ljava/lang/String;)V", AccessFlags = 33)]
				public virtual void SetUserAgentString(string ua) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets the WebView's user-agent string.</para><para><para>setUserAgentString </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the WebView's user-agent string </para>
				/// </returns>
				/// <java-name>
				/// getUserAgentString
				/// </java-name>
				[Dot42.DexImport("getUserAgentString", "()Ljava/lang/String;", AccessFlags = 33)]
				public virtual string GetUserAgentString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Tells the WebView whether it needs to set a node to have focus when WebView#requestFocus(int, android.graphics.Rect) is called. The default value is true.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setNeedInitialFocus
				/// </java-name>
				[Dot42.DexImport("setNeedInitialFocus", "(Z)V", AccessFlags = 1)]
				public virtual void SetNeedInitialFocus(bool flag) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the priority of the Render thread. Unlike the other settings, this one only needs to be called once per process. The default value is RenderPriority#NORMAL.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>It is not recommended to adjust thread priorities, and this will not be supported in future versions. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// setRenderPriority
				/// </java-name>
				[Dot42.DexImport("setRenderPriority", "(Landroid/webkit/WebSettings$RenderPriority;)V", AccessFlags = 33)]
				public virtual void SetRenderPriority(global::Android.Webkit.WebSettings.RenderPriority priority) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Overrides the way the cache is used. The way the cache is used is based on the navigation type. For a normal page load, the cache is checked and content is re-validated as needed. When navigating back, content is not revalidated, instead the content is just retrieved from the cache. This method allows the client to override this behavior by specifying one of LOAD_DEFAULT, LOAD_CACHE_ELSE_NETWORK, LOAD_NO_CACHE or LOAD_CACHE_ONLY. The default value is LOAD_DEFAULT.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setCacheMode
				/// </java-name>
				[Dot42.DexImport("setCacheMode", "(I)V", AccessFlags = 1)]
				public virtual void SetCacheMode(int mode) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets the current setting for overriding the cache mode.</para><para><para>setCacheMode </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the current setting for overriding the cache mode </para>
				/// </returns>
				/// <java-name>
				/// getCacheMode
				/// </java-name>
				[Dot42.DexImport("getCacheMode", "()I", AccessFlags = 1)]
				public virtual int GetCacheMode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Gets whether dumping the navigation cache is enabled.</para><para><para>setNavDump </para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>This method is now obsolete.  Since API level android.os.Build.VERSION_CODES#JELLY_BEAN_MR1 </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				/// <para>whether dumping the navigation cache is enabled </para>
				/// </returns>
				/// <java-name>
				/// getNavDump
				/// </java-name>
				public bool IsNavDump
				{
				[Dot42.DexImport("getNavDump", "()Z", AccessFlags = 1)]
						get{ return GetNavDump(); }
				[Dot42.DexImport("setNavDump", "(Z)V", AccessFlags = 1)]
						set{ SetNavDump(value); }
				}

				/// <summary>
				/// <para>Gets whether the zoom mechanisms built into WebView are being used.</para><para><para>setBuiltInZoomControls </para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if the zoom mechanisms built into WebView are being used </para>
				/// </returns>
				/// <java-name>
				/// getBuiltInZoomControls
				/// </java-name>
				public bool IsBuiltInZoomControls
				{
				[Dot42.DexImport("getBuiltInZoomControls", "()Z", AccessFlags = 1)]
						get{ return GetBuiltInZoomControls(); }
				[Dot42.DexImport("setBuiltInZoomControls", "(Z)V", AccessFlags = 1)]
						set{ SetBuiltInZoomControls(value); }
				}

				/// <summary>
				/// <para>Gets whether the WebView displays on-screen zoom controls when using the built-in zoom mechanisms.</para><para><para>setDisplayZoomControls </para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if the WebView displays on-screen zoom controls when using the built-in zoom mechanisms </para>
				/// </returns>
				/// <java-name>
				/// getDisplayZoomControls
				/// </java-name>
				public bool IsDisplayZoomControls
				{
				[Dot42.DexImport("getDisplayZoomControls", "()Z", AccessFlags = 1)]
						get{ return GetDisplayZoomControls(); }
				[Dot42.DexImport("setDisplayZoomControls", "(Z)V", AccessFlags = 1)]
						set{ SetDisplayZoomControls(value); }
				}

				/// <summary>
				/// <para>Gets whether this WebView supports file access.</para><para><para>setAllowFileAccess </para></para>        
				/// </summary>
				/// <java-name>
				/// getAllowFileAccess
				/// </java-name>
				public bool IsAllowFileAccess
				{
				[Dot42.DexImport("getAllowFileAccess", "()Z", AccessFlags = 1)]
						get{ return GetAllowFileAccess(); }
				[Dot42.DexImport("setAllowFileAccess", "(Z)V", AccessFlags = 1)]
						set{ SetAllowFileAccess(value); }
				}

				/// <summary>
				/// <para>Gets whether this WebView supports content URL access.</para><para><para>setAllowContentAccess </para></para>        
				/// </summary>
				/// <java-name>
				/// getAllowContentAccess
				/// </java-name>
				public bool IsAllowContentAccess
				{
				[Dot42.DexImport("getAllowContentAccess", "()Z", AccessFlags = 1)]
						get{ return GetAllowContentAccess(); }
				[Dot42.DexImport("setAllowContentAccess", "(Z)V", AccessFlags = 1)]
						set{ SetAllowContentAccess(value); }
				}

				/// <summary>
				/// <para>Gets whether this WebView loads pages in overview mode.</para><para><para>setLoadWithOverviewMode </para></para>        
				/// </summary>
				/// <returns>
				/// <para>whether this WebView loads pages in overview mode </para>
				/// </returns>
				/// <java-name>
				/// getLoadWithOverviewMode
				/// </java-name>
				public bool IsLoadWithOverviewMode
				{
				[Dot42.DexImport("getLoadWithOverviewMode", "()Z", AccessFlags = 1)]
						get{ return GetLoadWithOverviewMode(); }
				[Dot42.DexImport("setLoadWithOverviewMode", "(Z)V", AccessFlags = 1)]
						set{ SetLoadWithOverviewMode(value); }
				}

				/// <summary>
				/// <para>Gets whether this WebView uses WebView's background instead of internal pattern for over scroll background.</para><para><para>setUseWebViewBackgroundForOverscrollBackground </para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>This method is now obsolete.  Since API level android.os.Build.VERSION_CODES#JELLY_BEAN_MR1 </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// getUseWebViewBackgroundForOverscrollBackground
				/// </java-name>
				public bool IsUseWebViewBackgroundForOverscrollBackground
				{
				[Dot42.DexImport("getUseWebViewBackgroundForOverscrollBackground", "()Z", AccessFlags = 1)]
						get{ return GetUseWebViewBackgroundForOverscrollBackground(); }
				[Dot42.DexImport("setUseWebViewBackgroundForOverscrollBackground", "(Z)V", AccessFlags = 1)]
						set{ SetUseWebViewBackgroundForOverscrollBackground(value); }
				}

				/// <summary>
				/// <para>Gets whether the WebView saves form data.</para><para><para>setSaveFormData </para></para>        
				/// </summary>
				/// <returns>
				/// <para>whether the WebView saves form data </para>
				/// </returns>
				/// <java-name>
				/// getSaveFormData
				/// </java-name>
				public bool IsSaveFormData
				{
				[Dot42.DexImport("getSaveFormData", "()Z", AccessFlags = 1)]
						get{ return GetSaveFormData(); }
				[Dot42.DexImport("setSaveFormData", "(Z)V", AccessFlags = 1)]
						set{ SetSaveFormData(value); }
				}

				/// <summary>
				/// <para>Gets whether the WebView saves passwords.</para><para><para>setSavePassword </para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>Saving passwords in WebView will not be supported in future versions. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				/// <para>whether the WebView saves passwords </para>
				/// </returns>
				/// <java-name>
				/// getSavePassword
				/// </java-name>
				public bool IsSavePassword
				{
				[Dot42.DexImport("getSavePassword", "()Z", AccessFlags = 1)]
						get{ return GetSavePassword(); }
				[Dot42.DexImport("setSavePassword", "(Z)V", AccessFlags = 1)]
						set{ SetSavePassword(value); }
				}

				/// <summary>
				/// <para>Gets the text zoom of the page in percent.</para><para><para>setTextZoom </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the text zoom of the page in percent </para>
				/// </returns>
				/// <java-name>
				/// getTextZoom
				/// </java-name>
				public int TextZoom
				{
				[Dot42.DexImport("getTextZoom", "()I", AccessFlags = 33)]
						get{ return GetTextZoom(); }
				[Dot42.DexImport("setTextZoom", "(I)V", AccessFlags = 33)]
						set{ SetTextZoom(value); }
				}

				/// <summary>
				/// <para>Gets the default zoom density of the page. This should be called from the UI thread.</para><para><para>setDefaultZoom </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the zoom density </para>
				/// </returns>
				/// <java-name>
				/// getDefaultZoom
				/// </java-name>
				public global::Android.Webkit.WebSettings.ZoomDensity DefaultZoom
				{
				[Dot42.DexImport("getDefaultZoom", "()Landroid/webkit/WebSettings$ZoomDensity;", AccessFlags = 1)]
						get{ return GetDefaultZoom(); }
				[Dot42.DexImport("setDefaultZoom", "(Landroid/webkit/WebSettings$ZoomDensity;)V", AccessFlags = 1)]
						set{ SetDefaultZoom(value); }
				}

				/// <summary>
				/// <para>Gets whether light touches are enabled. <para>setLightTouchEnabled </para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>This setting is obsolete. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// getLightTouchEnabled
				/// </java-name>
				public bool IsLightTouchEnabled
				{
				[Dot42.DexImport("getLightTouchEnabled", "()Z", AccessFlags = 1)]
						get{ return GetLightTouchEnabled(); }
				[Dot42.DexImport("setLightTouchEnabled", "(Z)V", AccessFlags = 1)]
						set{ SetLightTouchEnabled(value); }
				}

				/// <summary>
				/// <para>Controlled a rendering optimization that is no longer present. Setting it now has no effect.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>This setting now has no effect.  Since API level android.os.Build.VERSION_CODES#JELLY_BEAN_MR1 </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// getUseDoubleTree
				/// </java-name>
				public bool IsUseDoubleTree
				{
				[Dot42.DexImport("getUseDoubleTree", "()Z", AccessFlags = 33)]
						get{ return GetUseDoubleTree(); }
				[Dot42.DexImport("setUseDoubleTree", "(Z)V", AccessFlags = 33)]
						set{ SetUseDoubleTree(value); }
				}

				/// <summary>
				/// <para>Gets the user-agent as an integer code. <ul><li><para>-1 means the WebView is using a custom user-agent string set with setUserAgentString </para></li><li><para>0 means the WebView should use an Android user-agent string </para></li><li><para>1 means the WebView should use a desktop user-agent string </para></li></ul></para><para><para>setUserAgent </para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>Please use getUserAgentString instead.  Since API level android.os.Build.VERSION_CODES#JELLY_BEAN_MR1 </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				/// <para>the integer code for the user-agent string </para>
				/// </returns>
				/// <java-name>
				/// getUserAgent
				/// </java-name>
				public int UserAgent
				{
				[Dot42.DexImport("getUserAgent", "()I", AccessFlags = 33)]
						get{ return GetUserAgent(); }
				[Dot42.DexImport("setUserAgent", "(I)V", AccessFlags = 33)]
						set{ SetUserAgent(value); }
				}

				/// <summary>
				/// <para>Gets whether the WebView supports the "viewport" HTML meta tag or will use a wide viewport.</para><para><para>setUseWideViewPort </para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if the WebView supports the viewport meta tag </para>
				/// </returns>
				/// <java-name>
				/// getUseWideViewPort
				/// </java-name>
				public bool IsUseWideViewPort
				{
				[Dot42.DexImport("getUseWideViewPort", "()Z", AccessFlags = 33)]
						get{ return GetUseWideViewPort(); }
				[Dot42.DexImport("setUseWideViewPort", "(Z)V", AccessFlags = 33)]
						set{ SetUseWideViewPort(value); }
				}

				/// <summary>
				/// <para>Gets the standard font family name.</para><para><para>setStandardFontFamily </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the standard font family name as a string </para>
				/// </returns>
				/// <java-name>
				/// getStandardFontFamily
				/// </java-name>
				public string StandardFontFamily
				{
				[Dot42.DexImport("getStandardFontFamily", "()Ljava/lang/String;", AccessFlags = 33)]
						get{ return GetStandardFontFamily(); }
				[Dot42.DexImport("setStandardFontFamily", "(Ljava/lang/String;)V", AccessFlags = 33)]
						set{ SetStandardFontFamily(value); }
				}

				/// <summary>
				/// <para>Gets the fixed font family name.</para><para><para>setFixedFontFamily </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the fixed font family name as a string </para>
				/// </returns>
				/// <java-name>
				/// getFixedFontFamily
				/// </java-name>
				public string FixedFontFamily
				{
				[Dot42.DexImport("getFixedFontFamily", "()Ljava/lang/String;", AccessFlags = 33)]
						get{ return GetFixedFontFamily(); }
				[Dot42.DexImport("setFixedFontFamily", "(Ljava/lang/String;)V", AccessFlags = 33)]
						set{ SetFixedFontFamily(value); }
				}

				/// <summary>
				/// <para>Gets the sans-serif font family name.</para><para><para>setSansSerifFontFamily </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the sans-serif font family name as a string </para>
				/// </returns>
				/// <java-name>
				/// getSansSerifFontFamily
				/// </java-name>
				public string SansSerifFontFamily
				{
				[Dot42.DexImport("getSansSerifFontFamily", "()Ljava/lang/String;", AccessFlags = 33)]
						get{ return GetSansSerifFontFamily(); }
				[Dot42.DexImport("setSansSerifFontFamily", "(Ljava/lang/String;)V", AccessFlags = 33)]
						set{ SetSansSerifFontFamily(value); }
				}

				/// <summary>
				/// <para>Gets the serif font family name. The default is "serif".</para><para><para>setSerifFontFamily </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the serif font family name as a string </para>
				/// </returns>
				/// <java-name>
				/// getSerifFontFamily
				/// </java-name>
				public string SerifFontFamily
				{
				[Dot42.DexImport("getSerifFontFamily", "()Ljava/lang/String;", AccessFlags = 33)]
						get{ return GetSerifFontFamily(); }
				[Dot42.DexImport("setSerifFontFamily", "(Ljava/lang/String;)V", AccessFlags = 33)]
						set{ SetSerifFontFamily(value); }
				}

				/// <summary>
				/// <para>Gets the cursive font family name.</para><para><para>setCursiveFontFamily </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the cursive font family name as a string </para>
				/// </returns>
				/// <java-name>
				/// getCursiveFontFamily
				/// </java-name>
				public string CursiveFontFamily
				{
				[Dot42.DexImport("getCursiveFontFamily", "()Ljava/lang/String;", AccessFlags = 33)]
						get{ return GetCursiveFontFamily(); }
				[Dot42.DexImport("setCursiveFontFamily", "(Ljava/lang/String;)V", AccessFlags = 33)]
						set{ SetCursiveFontFamily(value); }
				}

				/// <summary>
				/// <para>Gets the fantasy font family name.</para><para><para>setFantasyFontFamily </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the fantasy font family name as a string </para>
				/// </returns>
				/// <java-name>
				/// getFantasyFontFamily
				/// </java-name>
				public string FantasyFontFamily
				{
				[Dot42.DexImport("getFantasyFontFamily", "()Ljava/lang/String;", AccessFlags = 33)]
						get{ return GetFantasyFontFamily(); }
				[Dot42.DexImport("setFantasyFontFamily", "(Ljava/lang/String;)V", AccessFlags = 33)]
						set{ SetFantasyFontFamily(value); }
				}

				/// <summary>
				/// <para>Gets the minimum font size.</para><para><para>setMinimumFontSize </para></para>        
				/// </summary>
				/// <returns>
				/// <para>a non-negative integer between 1 and 72 </para>
				/// </returns>
				/// <java-name>
				/// getMinimumFontSize
				/// </java-name>
				public int MinimumFontSize
				{
				[Dot42.DexImport("getMinimumFontSize", "()I", AccessFlags = 33)]
						get{ return GetMinimumFontSize(); }
				[Dot42.DexImport("setMinimumFontSize", "(I)V", AccessFlags = 33)]
						set{ SetMinimumFontSize(value); }
				}

				/// <summary>
				/// <para>Gets the minimum logical font size.</para><para><para>setMinimumLogicalFontSize </para></para>        
				/// </summary>
				/// <returns>
				/// <para>a non-negative integer between 1 and 72 </para>
				/// </returns>
				/// <java-name>
				/// getMinimumLogicalFontSize
				/// </java-name>
				public int MinimumLogicalFontSize
				{
				[Dot42.DexImport("getMinimumLogicalFontSize", "()I", AccessFlags = 33)]
						get{ return GetMinimumLogicalFontSize(); }
				[Dot42.DexImport("setMinimumLogicalFontSize", "(I)V", AccessFlags = 33)]
						set{ SetMinimumLogicalFontSize(value); }
				}

				/// <summary>
				/// <para>Gets the default font size.</para><para><para>setDefaultFontSize </para></para>        
				/// </summary>
				/// <returns>
				/// <para>a non-negative integer between 1 and 72 </para>
				/// </returns>
				/// <java-name>
				/// getDefaultFontSize
				/// </java-name>
				public int DefaultFontSize
				{
				[Dot42.DexImport("getDefaultFontSize", "()I", AccessFlags = 33)]
						get{ return GetDefaultFontSize(); }
				[Dot42.DexImport("setDefaultFontSize", "(I)V", AccessFlags = 33)]
						set{ SetDefaultFontSize(value); }
				}

				/// <summary>
				/// <para>Gets the default fixed font size.</para><para><para>setDefaultFixedFontSize </para></para>        
				/// </summary>
				/// <returns>
				/// <para>a non-negative integer between 1 and 72 </para>
				/// </returns>
				/// <java-name>
				/// getDefaultFixedFontSize
				/// </java-name>
				public int DefaultFixedFontSize
				{
				[Dot42.DexImport("getDefaultFixedFontSize", "()I", AccessFlags = 33)]
						get{ return GetDefaultFixedFontSize(); }
				[Dot42.DexImport("setDefaultFixedFontSize", "(I)V", AccessFlags = 33)]
						set{ SetDefaultFixedFontSize(value); }
				}

				/// <summary>
				/// <para>Gets whether the WebView loads image resources. This includes images embedded using the data URI scheme.</para><para><para>setLoadsImagesAutomatically </para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if the WebView loads image resources </para>
				/// </returns>
				/// <java-name>
				/// getLoadsImagesAutomatically
				/// </java-name>
				public bool IsLoadsImagesAutomatically
				{
				[Dot42.DexImport("getLoadsImagesAutomatically", "()Z", AccessFlags = 33)]
						get{ return GetLoadsImagesAutomatically(); }
				[Dot42.DexImport("setLoadsImagesAutomatically", "(Z)V", AccessFlags = 33)]
						set{ SetLoadsImagesAutomatically(value); }
				}

				/// <summary>
				/// <para>Gets whether the WebView does not load image resources from the network.</para><para><para>setBlockNetworkImage </para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if the WebView does not load image resources from the network </para>
				/// </returns>
				/// <java-name>
				/// getBlockNetworkImage
				/// </java-name>
				public bool IsBlockNetworkImage
				{
				[Dot42.DexImport("getBlockNetworkImage", "()Z", AccessFlags = 33)]
						get{ return GetBlockNetworkImage(); }
				[Dot42.DexImport("setBlockNetworkImage", "(Z)V", AccessFlags = 33)]
						set{ SetBlockNetworkImage(value); }
				}

				/// <summary>
				/// <para>Gets whether the WebView does not load any resources from the network.</para><para><para>setBlockNetworkLoads </para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if the WebView does not load any resources from the network </para>
				/// </returns>
				/// <java-name>
				/// getBlockNetworkLoads
				/// </java-name>
				public bool IsBlockNetworkLoads
				{
				[Dot42.DexImport("getBlockNetworkLoads", "()Z", AccessFlags = 33)]
						get{ return GetBlockNetworkLoads(); }
				[Dot42.DexImport("setBlockNetworkLoads", "(Z)V", AccessFlags = 33)]
						set{ SetBlockNetworkLoads(value); }
				}

				/// <summary>
				/// <para>Gets whether the DOM Storage APIs are enabled.</para><para><para>setDomStorageEnabled </para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if the DOM Storage APIs are enabled </para>
				/// </returns>
				/// <java-name>
				/// getDomStorageEnabled
				/// </java-name>
				public bool IsDomStorageEnabled
				{
				[Dot42.DexImport("getDomStorageEnabled", "()Z", AccessFlags = 33)]
						get{ return GetDomStorageEnabled(); }
				[Dot42.DexImport("setDomStorageEnabled", "(Z)V", AccessFlags = 33)]
						set{ SetDomStorageEnabled(value); }
				}

				/// <summary>
				/// <para>Gets the path to where database storage API databases are saved.</para><para><para>setDatabasePath </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the String path to the database storage API databases </para>
				/// </returns>
				/// <java-name>
				/// getDatabasePath
				/// </java-name>
				public string DatabasePath
				{
				[Dot42.DexImport("getDatabasePath", "()Ljava/lang/String;", AccessFlags = 33)]
						get{ return GetDatabasePath(); }
				[Dot42.DexImport("setDatabasePath", "(Ljava/lang/String;)V", AccessFlags = 33)]
						set{ SetDatabasePath(value); }
				}

				/// <summary>
				/// <para>Gets whether the database storage API is enabled.</para><para><para>setDatabaseEnabled </para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if the database storage API is enabled </para>
				/// </returns>
				/// <java-name>
				/// getDatabaseEnabled
				/// </java-name>
				public bool IsDatabaseEnabled
				{
				[Dot42.DexImport("getDatabaseEnabled", "()Z", AccessFlags = 33)]
						get{ return GetDatabaseEnabled(); }
				[Dot42.DexImport("setDatabaseEnabled", "(Z)V", AccessFlags = 33)]
						set{ SetDatabaseEnabled(value); }
				}

				/// <summary>
				/// <para>Gets whether JavaScript is enabled.</para><para><para>setJavaScriptEnabled </para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if JavaScript is enabled </para>
				/// </returns>
				/// <java-name>
				/// getJavaScriptEnabled
				/// </java-name>
				public bool IsJavaScriptEnabled
				{
				[Dot42.DexImport("getJavaScriptEnabled", "()Z", AccessFlags = 33)]
						get{ return GetJavaScriptEnabled(); }
				[Dot42.DexImport("setJavaScriptEnabled", "(Z)V", AccessFlags = 33)]
						set{ SetJavaScriptEnabled(value); }
				}

				/// <summary>
				/// <para>Gets whether plugins are enabled.</para><para><para>setPluginsEnabled </para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>This method has been replaced by getPluginState  Since API level android.os.Build.VERSION_CODES#JELLY_BEAN_MR2 </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				/// <para>true if plugins are enabled </para>
				/// </returns>
				/// <java-name>
				/// getPluginsEnabled
				/// </java-name>
				public bool IsPluginsEnabled
				{
				[Dot42.DexImport("getPluginsEnabled", "()Z", AccessFlags = 33)]
						get{ return GetPluginsEnabled(); }
				[Dot42.DexImport("setPluginsEnabled", "(Z)V", AccessFlags = 33)]
						set{ SetPluginsEnabled(value); }
				}

				/// <summary>
				/// <para>Gets the directory that contains the plugin libraries. This method is obsolete since each plugin is now loaded from its own package.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>This method is no longer used as plugins are loaded from their own APK via the system's package manager.  Since API level android.os.Build.VERSION_CODES#JELLY_BEAN_MR2 </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				/// <para>an empty string </para>
				/// </returns>
				/// <java-name>
				/// getPluginsPath
				/// </java-name>
				public string PluginsPath
				{
				[Dot42.DexImport("getPluginsPath", "()Ljava/lang/String;", AccessFlags = 33)]
						get{ return GetPluginsPath(); }
				[Dot42.DexImport("setPluginsPath", "(Ljava/lang/String;)V", AccessFlags = 33)]
						set{ SetPluginsPath(value); }
				}

				/// <summary>
				/// <para>Gets whether JavaScript can open windows automatically.</para><para><para>setJavaScriptCanOpenWindowsAutomatically </para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if JavaScript can open windows automatically during window.open() </para>
				/// </returns>
				/// <java-name>
				/// getJavaScriptCanOpenWindowsAutomatically
				/// </java-name>
				public bool IsJavaScriptCanOpenWindowsAutomatically
				{
				[Dot42.DexImport("getJavaScriptCanOpenWindowsAutomatically", "()Z", AccessFlags = 33)]
						get{ return GetJavaScriptCanOpenWindowsAutomatically(); }
				[Dot42.DexImport("setJavaScriptCanOpenWindowsAutomatically", "(Z)V", AccessFlags = 33)]
						set{ SetJavaScriptCanOpenWindowsAutomatically(value); }
				}

				/// <summary>
				/// <para>Gets the default text encoding name.</para><para><para>setDefaultTextEncodingName </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the default text encoding name as a string </para>
				/// </returns>
				/// <java-name>
				/// getDefaultTextEncodingName
				/// </java-name>
				public string DefaultTextEncodingName
				{
				[Dot42.DexImport("getDefaultTextEncodingName", "()Ljava/lang/String;", AccessFlags = 33)]
						get{ return GetDefaultTextEncodingName(); }
				[Dot42.DexImport("setDefaultTextEncodingName", "(Ljava/lang/String;)V", AccessFlags = 33)]
						set{ SetDefaultTextEncodingName(value); }
				}

				/// <summary>
				/// <para>Gets the WebView's user-agent string.</para><para><para>setUserAgentString </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the WebView's user-agent string </para>
				/// </returns>
				/// <java-name>
				/// getUserAgentString
				/// </java-name>
				public string UserAgentString
				{
				[Dot42.DexImport("getUserAgentString", "()Ljava/lang/String;", AccessFlags = 33)]
						get{ return GetUserAgentString(); }
				[Dot42.DexImport("setUserAgentString", "(Ljava/lang/String;)V", AccessFlags = 33)]
						set{ SetUserAgentString(value); }
				}

				/// <summary>
				/// <para>Gets the current setting for overriding the cache mode.</para><para><para>setCacheMode </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the current setting for overriding the cache mode </para>
				/// </returns>
				/// <java-name>
				/// getCacheMode
				/// </java-name>
				public int CacheMode
				{
				[Dot42.DexImport("getCacheMode", "()I", AccessFlags = 1)]
						get{ return GetCacheMode(); }
				[Dot42.DexImport("setCacheMode", "(I)V", AccessFlags = 1)]
						set{ SetCacheMode(value); }
				}

				/// <java-name>
				/// android/webkit/WebSettings$PluginState
				/// </java-name>
				[Dot42.DexImport("android/webkit/WebSettings$PluginState", AccessFlags = 16409, Signature = "Ljava/lang/Enum<Landroid/webkit/WebSettings$PluginState;>;")]
				public sealed class PluginState
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// OFF
						/// </java-name>
						[Dot42.DexImport("OFF", "Landroid/webkit/WebSettings$PluginState;", AccessFlags = 16409)]
						public static readonly PluginState OFF;
						/// <java-name>
						/// ON
						/// </java-name>
						[Dot42.DexImport("ON", "Landroid/webkit/WebSettings$PluginState;", AccessFlags = 16409)]
						public static readonly PluginState ON;
						/// <java-name>
						/// ON_DEMAND
						/// </java-name>
						[Dot42.DexImport("ON_DEMAND", "Landroid/webkit/WebSettings$PluginState;", AccessFlags = 16409)]
						public static readonly PluginState ON_DEMAND;
						private PluginState() /* TypeBuilder.AddPrivateDefaultCtor */ 
						{
						}

				}

				/// <java-name>
				/// android/webkit/WebSettings$RenderPriority
				/// </java-name>
				[Dot42.DexImport("android/webkit/WebSettings$RenderPriority", AccessFlags = 16409, Signature = "Ljava/lang/Enum<Landroid/webkit/WebSettings$RenderPriority;>;")]
				public sealed class RenderPriority
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// HIGH
						/// </java-name>
						[Dot42.DexImport("HIGH", "Landroid/webkit/WebSettings$RenderPriority;", AccessFlags = 16409)]
						public static readonly RenderPriority HIGH;
						/// <java-name>
						/// LOW
						/// </java-name>
						[Dot42.DexImport("LOW", "Landroid/webkit/WebSettings$RenderPriority;", AccessFlags = 16409)]
						public static readonly RenderPriority LOW;
						/// <java-name>
						/// NORMAL
						/// </java-name>
						[Dot42.DexImport("NORMAL", "Landroid/webkit/WebSettings$RenderPriority;", AccessFlags = 16409)]
						public static readonly RenderPriority NORMAL;
						private RenderPriority() /* TypeBuilder.AddPrivateDefaultCtor */ 
						{
						}

				}

				/// <java-name>
				/// android/webkit/WebSettings$ZoomDensity
				/// </java-name>
				[Dot42.DexImport("android/webkit/WebSettings$ZoomDensity", AccessFlags = 16409, Signature = "Ljava/lang/Enum<Landroid/webkit/WebSettings$ZoomDensity;>;")]
				public sealed class ZoomDensity
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// CLOSE
						/// </java-name>
						[Dot42.DexImport("CLOSE", "Landroid/webkit/WebSettings$ZoomDensity;", AccessFlags = 16409)]
						public static readonly ZoomDensity CLOSE;
						/// <java-name>
						/// FAR
						/// </java-name>
						[Dot42.DexImport("FAR", "Landroid/webkit/WebSettings$ZoomDensity;", AccessFlags = 16409)]
						public static readonly ZoomDensity FAR;
						/// <java-name>
						/// MEDIUM
						/// </java-name>
						[Dot42.DexImport("MEDIUM", "Landroid/webkit/WebSettings$ZoomDensity;", AccessFlags = 16409)]
						public static readonly ZoomDensity MEDIUM;
						private ZoomDensity() /* TypeBuilder.AddPrivateDefaultCtor */ 
						{
						}

				}

				/// <java-name>
				/// android/webkit/WebSettings$TextSize
				/// </java-name>
				[Dot42.DexImport("android/webkit/WebSettings$TextSize", AccessFlags = 16409, Signature = "Ljava/lang/Enum<Landroid/webkit/WebSettings$TextSize;>;")]
				public sealed class TextSize
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// LARGER
						/// </java-name>
						[Dot42.DexImport("LARGER", "Landroid/webkit/WebSettings$TextSize;", AccessFlags = 16409)]
						public static readonly TextSize LARGER;
						/// <java-name>
						/// LARGEST
						/// </java-name>
						[Dot42.DexImport("LARGEST", "Landroid/webkit/WebSettings$TextSize;", AccessFlags = 16409)]
						public static readonly TextSize LARGEST;
						/// <java-name>
						/// NORMAL
						/// </java-name>
						[Dot42.DexImport("NORMAL", "Landroid/webkit/WebSettings$TextSize;", AccessFlags = 16409)]
						public static readonly TextSize NORMAL;
						/// <java-name>
						/// SMALLER
						/// </java-name>
						[Dot42.DexImport("SMALLER", "Landroid/webkit/WebSettings$TextSize;", AccessFlags = 16409)]
						public static readonly TextSize SMALLER;
						/// <java-name>
						/// SMALLEST
						/// </java-name>
						[Dot42.DexImport("SMALLEST", "Landroid/webkit/WebSettings$TextSize;", AccessFlags = 16409)]
						public static readonly TextSize SMALLEST;
						private TextSize() /* TypeBuilder.AddPrivateDefaultCtor */ 
						{
						}

				}

				/// <java-name>
				/// android/webkit/WebSettings$LayoutAlgorithm
				/// </java-name>
				[Dot42.DexImport("android/webkit/WebSettings$LayoutAlgorithm", AccessFlags = 16409, Signature = "Ljava/lang/Enum<Landroid/webkit/WebSettings$LayoutAlgorithm;>;")]
				public sealed class LayoutAlgorithm
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// NARROW_COLUMNS
						/// </java-name>
						[Dot42.DexImport("NARROW_COLUMNS", "Landroid/webkit/WebSettings$LayoutAlgorithm;", AccessFlags = 16409)]
						public static readonly LayoutAlgorithm NARROW_COLUMNS;
						/// <java-name>
						/// NORMAL
						/// </java-name>
						[Dot42.DexImport("NORMAL", "Landroid/webkit/WebSettings$LayoutAlgorithm;", AccessFlags = 16409)]
						public static readonly LayoutAlgorithm NORMAL;
						/// <java-name>
						/// SINGLE_COLUMN
						/// </java-name>
						[Dot42.DexImport("SINGLE_COLUMN", "Landroid/webkit/WebSettings$LayoutAlgorithm;", AccessFlags = 16409)]
						public static readonly LayoutAlgorithm SINGLE_COLUMN;
						private LayoutAlgorithm() /* TypeBuilder.AddPrivateDefaultCtor */ 
						{
						}

				}

		}

		/// <summary>
		/// <para>Public class for handling JavaScript prompt requests. The WebChromeClient will receive a WebChromeClient#onJsPrompt(WebView, String, String, String, JsPromptResult) call with a JsPromptResult instance as a parameter. This parameter is used to return the result of this user dialog prompt back to the WebView instance. The client can call cancel() to cancel the dialog or confirm() with the user's input to confirm the dialog. </para>    
		/// </summary>
		/// <java-name>
		/// android/webkit/JsPromptResult
		/// </java-name>
		[Dot42.DexImport("android/webkit/JsPromptResult", AccessFlags = 33)]
		public partial class JsPromptResult : global::Android.Webkit.JsResult
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal JsPromptResult() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Handle a confirmation response from the user. </para>        
				/// </summary>
				/// <java-name>
				/// confirm
				/// </java-name>
				[Dot42.DexImport("confirm", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void Confirm(string result) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>Public class representing a JavaScript console message from WebCore. This could be a issued by a call to one of the <code>console</code> logging functions (e.g. <code>console.log('...')</code>) or a JavaScript error on the page. To receive notifications of these messages, override the WebChromeClient#onConsoleMessage(ConsoleMessage) function. </para>    
		/// </summary>
		/// <java-name>
		/// android/webkit/ConsoleMessage
		/// </java-name>
		[Dot42.DexImport("android/webkit/ConsoleMessage", AccessFlags = 33)]
		public partial class ConsoleMessage
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;ILandroid/webkit/ConsoleMessage$MessageLevel" +
    ";)V", AccessFlags = 1)]
				public ConsoleMessage(string message, string sourceId, int lineNumber, global::Android.Webkit.ConsoleMessage.JavaMessageLevel msgLevel) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// messageLevel
				/// </java-name>
				[Dot42.DexImport("messageLevel", "()Landroid/webkit/ConsoleMessage$MessageLevel;", AccessFlags = 1)]
				public virtual global::Android.Webkit.ConsoleMessage.JavaMessageLevel MessageLevel() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Webkit.ConsoleMessage.JavaMessageLevel);
				}

				/// <java-name>
				/// message
				/// </java-name>
				[Dot42.DexImport("message", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string Message() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// sourceId
				/// </java-name>
				[Dot42.DexImport("sourceId", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string SourceId() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// lineNumber
				/// </java-name>
				[Dot42.DexImport("lineNumber", "()I", AccessFlags = 1)]
				public virtual int LineNumber() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ConsoleMessage() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// android/webkit/ConsoleMessage$MessageLevel
				/// </java-name>
				[Dot42.DexImport("android/webkit/ConsoleMessage$MessageLevel", AccessFlags = 16409, Signature = "Ljava/lang/Enum<Landroid/webkit/ConsoleMessage$MessageLevel;>;")]
				public sealed class JavaMessageLevel
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// DEBUG
						/// </java-name>
						[Dot42.DexImport("DEBUG", "Landroid/webkit/ConsoleMessage$MessageLevel;", AccessFlags = 16409)]
						public static readonly JavaMessageLevel DEBUG;
						/// <java-name>
						/// ERROR
						/// </java-name>
						[Dot42.DexImport("ERROR", "Landroid/webkit/ConsoleMessage$MessageLevel;", AccessFlags = 16409)]
						public static readonly JavaMessageLevel ERROR;
						/// <java-name>
						/// LOG
						/// </java-name>
						[Dot42.DexImport("LOG", "Landroid/webkit/ConsoleMessage$MessageLevel;", AccessFlags = 16409)]
						public static readonly JavaMessageLevel LOG;
						/// <java-name>
						/// TIP
						/// </java-name>
						[Dot42.DexImport("TIP", "Landroid/webkit/ConsoleMessage$MessageLevel;", AccessFlags = 16409)]
						public static readonly JavaMessageLevel TIP;
						/// <java-name>
						/// WARNING
						/// </java-name>
						[Dot42.DexImport("WARNING", "Landroid/webkit/ConsoleMessage$MessageLevel;", AccessFlags = 16409)]
						public static readonly JavaMessageLevel WARNING;
						private JavaMessageLevel() /* TypeBuilder.AddPrivateDefaultCtor */ 
						{
						}

				}

		}

		/// <summary>
		/// <para>A View that displays web pages. This class is the basis upon which you can roll your own web browser or simply display some online content within your Activity. It uses the WebKit rendering engine to display web pages and includes methods to navigate forward and backward through a history, zoom in and out, perform text searches and more.</para><para>To enable the built-in zoom, set WebSettings.WebSettings#setBuiltInZoomControls(boolean) (introduced in API level android.os.Build.VERSION_CODES#CUPCAKE). </para><para>Note that, in order for your Activity to access the Internet and load web pages in a WebView, you must add the <c> INTERNET </c> permissions to your Android Manifest file:</para><para><pre>&lt;uses-permission android:name="android.permission.INTERNET" /&gt;</pre></para><para>This must be a child of the  element.</para><para>For more information, read .</para><para><h3>Basic usage</h3></para><para>By default, a WebView provides no browser-like widgets, does not enable JavaScript and web page errors are ignored. If your goal is only to display some HTML as a part of your UI, this is probably fine; the user won't need to interact with the web page beyond reading it, and the web page won't need to interact with the user. If you actually want a full-blown web browser, then you probably want to invoke the Browser application with a URL Intent rather than show it with a WebView. For example: <pre>
		///    Uri uri = Uri.parse("http://www.example.com");
		///    Intent intent = new Intent(Intent.ACTION_VIEW, uri);
		///    startActivity(intent);
		///    </pre> </para><para>See android.content.Intent for more information.</para><para>To provide a WebView in your own Activity, include a <c> &lt;WebView&gt; </c> in your layout, or set the entire Activity window as a WebView during onCreate():</para><para><pre>
		///    WebView webview = new WebView(this);
		///    setContentView(webview);
		///    </pre></para><para>Then load the desired web page:</para><para><pre>
		///    // Simplest usage: note that an exception will NOT be thrown
		///    // if there is an error loading this page (see below).
		///    webview.loadUrl("http://slashdot.org/");
		/// 
		///    // OR, you can also load from an HTML string:
		///    String summary = "&amp;lt;html&gt;&amp;lt;body&gt;You scored &amp;lt;b&gt;192&amp;lt;/b&gt; points.&amp;lt;/body&gt;&amp;lt;/html&gt;";
		///    webview.loadData(summary, "text/html", null);
		///    // ... although note that there are restrictions on what this HTML can do.
		///    // See the JavaDocs for loadData() and loadDataWithBaseURL() for more info.
		///    </pre></para><para>A WebView has several customization points where you can add your own behavior. These are:</para><para><ul><li><para>Creating and setting a android.webkit.WebChromeClient subclass. This class is called when something that might impact a browser UI happens, for instance, progress updates and JavaScript alerts are sent here (see ).  </para></li><li><para>Creating and setting a android.webkit.WebViewClient subclass. It will be called when things happen that impact the rendering of the content, eg, errors or form submissions. You can also intercept URL loading here (via shouldOverrideUrlLoading()). </para></li><li><para>Modifying the android.webkit.WebSettings, such as enabling JavaScript with setJavaScriptEnabled().  </para></li><li><para>Injecting Java objects into the WebView using the android.webkit.WebView#addJavascriptInterface method. This method allows you to inject Java objects into a page's JavaScript context, so that they can be accessed by JavaScript in the page. </para></li></ul></para><para>Here's a more complicated example, showing error handling, settings, and progress notification:</para><para><pre>
		///    // Let's display the progress in the activity title bar, like the
		///    // browser app does.
		///    getWindow().requestFeature(Window.FEATURE_PROGRESS);
		/// 
		///    webview.getSettings().setJavaScriptEnabled(true);
		/// 
		///    final Activity activity = this;
		///    webview.setWebChromeClient(new WebChromeClient() {
		///      public void onProgressChanged(WebView view, int progress) {
		///        // Activities and WebViews measure progress with different scales.
		///        // The progress meter will automatically disappear when we reach 100%
		///        activity.setProgress(progress * 1000);
		///      }
		///    });
		///    webview.setWebViewClient(new WebViewClient() {
		///      public void onReceivedError(WebView view, int errorCode, String description, String failingUrl) {
		///        Toast.makeText(activity, "Oh no! " + description, Toast.LENGTH_SHORT).show();
		///      }
		///    });
		/// 
		///    webview.loadUrl("http://slashdot.org/");
		///    </pre></para><para><h3>Cookie and window management</h3></para><para>For obvious security reasons, your application has its own cache, cookie store etc.it does not share the Browser application's data. </para><para>By default, requests by the HTML to open new windows are ignored. This is true whether they be opened by JavaScript or by the target attribute on a link. You can customize your WebChromeClient to provide your own behaviour for opening multiple windows, and render them in whatever manner you want.</para><para>The standard behavior for an Activity is to be destroyed and recreated when the device orientation or any other configuration changes. This will cause the WebView to reload the current page. If you don't want that, you can set your Activity to handle the <c> orientation </c> and <c> keyboardHidden </c> changes, and then just leave the WebView alone. It'll automatically re-orient itself as appropriate. Read  for more information about how to handle configuration changes during runtime.</para><para><h3>Building web pages to support different screen densities</h3></para><para>The screen density of a device is based on the screen resolution. A screen with low density has fewer available pixels per inch, where a screen with high density has more  sometimes significantly more  pixels per inch. The density of a screen is important because, other things being equal, a UI element (such as a button) whose height and width are defined in terms of screen pixels will appear larger on the lower density screen and smaller on the higher density screen. For simplicity, Android collapses all actual screen densities into three generalized densities: high, medium, and low.</para><para>By default, WebView scales a web page so that it is drawn at a size that matches the default appearance on a medium density screen. So, it applies 1.5x scaling on a high density screen (because its pixels are smaller) and 0.75x scaling on a low density screen (because its pixels are bigger). Starting with API level android.os.Build.VERSION_CODES#ECLAIR, WebView supports DOM, CSS, and meta tag features to help you (as a web developer) target screens with different screen densities.</para><para>Here's a summary of the features you can use to handle different screen densities:</para><para><ul><li><para>The <c> window.devicePixelRatio </c> DOM property. The value of this property specifies the default scaling factor used for the current device. For example, if the value of <c>   window.devicePixelRatio </c> is "1.0", then the device is considered a medium density (mdpi) device and default scaling is not applied to the web page; if the value is "1.5", then the device is considered a high density device (hdpi) and the page content is scaled 1.5x; if the value is "0.75", then the device is considered a low density device (ldpi) and the content is scaled 0.75x. </para></li><li><para>The <c> -webkit-device-pixel-ratio </c> CSS media query. Use this to specify the screen densities for which this style sheet is to be used. The corresponding value should be either "0.75", "1", or "1.5", to indicate that the styles are for devices with low density, medium density, or high density screens, respectively. For example: <pre>
		///    &lt;link rel="stylesheet" media="screen and (-webkit-device-pixel-ratio:1.5)" href="hdpi.css" /&gt;</pre> </para><para>The <c> hdpi.css </c> stylesheet is only used for devices with a screen pixel ration of 1.5, which is the high density pixel ratio.</para><para></para><para><h3>HTML5 Video support</h3></para><para></para><para></para><para>In order to support inline HTML5 video in your application, you need to have hardware acceleration turned on, and set a android.webkit.WebChromeClient. For full screen support, implementations of WebChromeClient#onShowCustomView(View, WebChromeClient.CustomViewCallback) and WebChromeClient#onHideCustomView() are required, WebChromeClient#getVideoLoadingProgressView() is optional. </para><para></para></li></ul></para>    
		/// </summary>
		/// <java-name>
		/// android/webkit/WebView
		/// </java-name>
		[Dot42.DexImport("android/webkit/WebView", AccessFlags = 33)]
		public partial class WebView : global::Android.Widget.AbsoluteLayout, global::Android.View.ViewTreeObserver.IOnGlobalFocusChangeListener, global::Android.View.ViewGroup.IOnHierarchyChangeListener
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>URI scheme for telephone number. </para>        
				/// </summary>
				/// <java-name>
				/// SCHEME_TEL
				/// </java-name>
				[Dot42.DexImport("SCHEME_TEL", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SCHEME_TEL = "tel:";
				/// <summary>
				/// <para>URI scheme for email address. </para>        
				/// </summary>
				/// <java-name>
				/// SCHEME_MAILTO
				/// </java-name>
				[Dot42.DexImport("SCHEME_MAILTO", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SCHEME_MAILTO = "mailto:";
				/// <summary>
				/// <para>URI scheme for map address. </para>        
				/// </summary>
				/// <java-name>
				/// SCHEME_GEO
				/// </java-name>
				[Dot42.DexImport("SCHEME_GEO", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SCHEME_GEO = "geo:0,0?q=";
				/// <summary>
				/// <para>Constructs a new WebView with a Context object.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public WebView(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a new WebView with layout parameters.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public WebView(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a new WebView with layout parameters and a default style.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", AccessFlags = 1)]
				public WebView(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs, int defStyle) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a new WebView with layout parameters and a default style.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>Private browsing is no longer supported directly via WebView and will be removed in a future release. Prefer using WebSettings, WebViewDatabase, CookieManager and WebStorage for fine-grained control of privacy data. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;IZ)V", AccessFlags = 1)]
				public WebView(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs, int defStyle, bool privateBrowsing) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Return true if the pressed state should be delayed for children or descendants of this ViewGroup. Generally, this should be done for containers that can scroll, such as a List. This prevents the pressed state from appearing when the user is actually trying to scroll the content.</para><para>The default implementation returns true for compatibility reasons. Subclasses that do not scroll should generally override this method and return false. </para>        
				/// </summary>
				/// <java-name>
				/// shouldDelayChildPressedState
				/// </java-name>
				[Dot42.DexImport("shouldDelayChildPressedState", "()Z", AccessFlags = 1)]
				public override bool ShouldDelayChildPressedState() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Initializes an AccessibilityNodeInfo with information about this view. The base implementation sets: <ul><li><para>AccessibilityNodeInfo#setParent(View), </para></li><li><para>AccessibilityNodeInfo#setBoundsInParent(Rect), </para></li><li><para>AccessibilityNodeInfo#setBoundsInScreen(Rect), </para></li><li><para>AccessibilityNodeInfo#setPackageName(CharSequence), </para></li><li><para>AccessibilityNodeInfo#setClassName(CharSequence), </para></li><li><para>AccessibilityNodeInfo#setContentDescription(CharSequence), </para></li><li><para>AccessibilityNodeInfo#setEnabled(boolean), </para></li><li><para>AccessibilityNodeInfo#setClickable(boolean), </para></li><li><para>AccessibilityNodeInfo#setFocusable(boolean), </para></li><li><para>AccessibilityNodeInfo#setFocused(boolean), </para></li><li><para>AccessibilityNodeInfo#setLongClickable(boolean), </para></li><li><para>AccessibilityNodeInfo#setSelected(boolean), </para></li></ul></para><para>Subclasses should override this method, call the super implementation, and set additional attributes. </para><para>If an AccessibilityDelegate has been specified via calling setAccessibilityDelegate(AccessibilityDelegate) its AccessibilityDelegate#onInitializeAccessibilityNodeInfo(View, AccessibilityNodeInfo) is responsible for handling this call. </para><para></para>        
				/// </summary>
				/// <java-name>
				/// onInitializeAccessibilityNodeInfo
				/// </java-name>
				[Dot42.DexImport("onInitializeAccessibilityNodeInfo", "(Landroid/view/accessibility/AccessibilityNodeInfo;)V", AccessFlags = 1)]
				public override void OnInitializeAccessibilityNodeInfo(global::Android.View.Accessibility.AccessibilityNodeInfo info) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Initializes an AccessibilityEvent with information about this View which is the event source. In other words, the source of an accessibility event is the view whose state change triggered firing the event. </para><para>Example: Setting the password property of an event in addition to properties set by the super implementation: <pre> public void onInitializeAccessibilityEvent(AccessibilityEvent event) {
				///            super.onInitializeAccessibilityEvent(event);
				///            event.setPassword(true);
				///        }</pre> </para><para>If an AccessibilityDelegate has been specified via calling setAccessibilityDelegate(AccessibilityDelegate) its AccessibilityDelegate#onInitializeAccessibilityEvent(View, AccessibilityEvent) is responsible for handling this call. </para><para><b>Note:</b> Always call the super implementation before adding information to the event, in case the default implementation has basic information to add. </para><para><para>sendAccessibilityEvent(int) </para><simplesectsep></simplesectsep><para>dispatchPopulateAccessibilityEvent(AccessibilityEvent) </para></para>        
				/// </summary>
				/// <java-name>
				/// onInitializeAccessibilityEvent
				/// </java-name>
				[Dot42.DexImport("onInitializeAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)V", AccessFlags = 1)]
				public override void OnInitializeAccessibilityEvent(global::Android.View.Accessibility.AccessibilityEvent @event) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setOverScrollMode
				/// </java-name>
				[Dot42.DexImport("setOverScrollMode", "(I)V", AccessFlags = 1)]
				public override void SetOverScrollMode(int mode) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Specify the style of the scrollbars. The scrollbars can be overlaid or inset. When inset, they add to the padding of the view. And the scrollbars can be drawn inside the padding area or on the edge of the view. For example, if a view has a background drawable and you want to draw the scrollbars inside the padding specified by the drawable, you can use SCROLLBARS_INSIDE_OVERLAY or SCROLLBARS_INSIDE_INSET. If you want them to appear at the edge of the view, ignoring the padding, then you can use SCROLLBARS_OUTSIDE_OVERLAY or SCROLLBARS_OUTSIDE_INSET.</para><para><para>SCROLLBARS_INSIDE_OVERLAY </para><simplesectsep></simplesectsep><para>SCROLLBARS_INSIDE_INSET </para><simplesectsep></simplesectsep><para>SCROLLBARS_OUTSIDE_OVERLAY </para><simplesectsep></simplesectsep><para>SCROLLBARS_OUTSIDE_INSET</para>ref android.R.styleable::View_scrollbarStyle </para>        
				/// </summary>
				/// <java-name>
				/// setScrollBarStyle
				/// </java-name>
				[Dot42.DexImport("setScrollBarStyle", "(I)V", AccessFlags = 1)]
				public override void SetScrollBarStyle(int style) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Specifies whether the horizontal scrollbar has overlay style.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setHorizontalScrollbarOverlay
				/// </java-name>
				[Dot42.DexImport("setHorizontalScrollbarOverlay", "(Z)V", AccessFlags = 1)]
				public virtual void SetHorizontalScrollbarOverlay(bool overlay) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Specifies whether the vertical scrollbar has overlay style.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setVerticalScrollbarOverlay
				/// </java-name>
				[Dot42.DexImport("setVerticalScrollbarOverlay", "(Z)V", AccessFlags = 1)]
				public virtual void SetVerticalScrollbarOverlay(bool overlay) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets whether horizontal scrollbar has overlay style.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if horizontal scrollbar has overlay style </para>
				/// </returns>
				/// <java-name>
				/// overlayHorizontalScrollbar
				/// </java-name>
				[Dot42.DexImport("overlayHorizontalScrollbar", "()Z", AccessFlags = 1)]
				public virtual bool OverlayHorizontalScrollbar() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Gets whether vertical scrollbar has overlay style.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if vertical scrollbar has overlay style </para>
				/// </returns>
				/// <java-name>
				/// overlayVerticalScrollbar
				/// </java-name>
				[Dot42.DexImport("overlayVerticalScrollbar", "()Z", AccessFlags = 1)]
				public virtual bool OverlayVerticalScrollbar() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Gets the visible height (in pixels) of the embedded title bar (if any).</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>This method is now obsolete.  Since API level android.os.Build.VERSION_CODES#JELLY_BEAN_MR1 </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// getVisibleTitleHeight
				/// </java-name>
				[Dot42.DexImport("getVisibleTitleHeight", "()I", AccessFlags = 1)]
				public virtual int GetVisibleTitleHeight() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Gets the SSL certificate for the main top-level page or null if there is no certificate (the site is not secure).</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the SSL certificate for the main top-level page </para>
				/// </returns>
				/// <java-name>
				/// getCertificate
				/// </java-name>
				[Dot42.DexImport("getCertificate", "()Landroid/net/http/SslCertificate;", AccessFlags = 1)]
				public virtual global::Android.Net.Http.SslCertificate GetCertificate() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Net.Http.SslCertificate);
				}

				/// <summary>
				/// <para>Sets the SSL certificate for the main top-level page.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>Calling this function has no useful effect, and will be ignored in future releases. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// setCertificate
				/// </java-name>
				[Dot42.DexImport("setCertificate", "(Landroid/net/http/SslCertificate;)V", AccessFlags = 1)]
				public virtual void SetCertificate(global::Android.Net.Http.SslCertificate certificate) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets a username and password pair for the specified host. This data is used by the Webview to autocomplete username and password fields in web forms. Note that this is unrelated to the credentials used for HTTP authentication.</para><para><para>WebViewDatabase::clearUsernamePassword </para><simplesectsep></simplesectsep><para>WebViewDatabase::hasUsernamePassword </para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>Saving passwords in WebView will not be supported in future versions. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// savePassword
				/// </java-name>
				[Dot42.DexImport("savePassword", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SavePassword(string host, string username, string password) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Stores HTTP authentication credentials for a given host and realm. This method is intended to be used with WebViewClient#onReceivedHttpAuthRequest.</para><para><para>getHttpAuthUsernamePassword </para><simplesectsep></simplesectsep><para>WebViewDatabase::hasHttpAuthUsernamePassword </para><simplesectsep></simplesectsep><para>WebViewDatabase::clearHttpAuthUsernamePassword </para></para>        
				/// </summary>
				/// <java-name>
				/// setHttpAuthUsernamePassword
				/// </java-name>
				[Dot42.DexImport("setHttpAuthUsernamePassword", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetHttpAuthUsernamePassword(string host, string realm, string username, string password) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Retrieves HTTP authentication credentials for a given host and realm. This method is intended to be used with WebViewClient#onReceivedHttpAuthRequest.</para><para><para>setHttpAuthUsernamePassword </para><simplesectsep></simplesectsep><para>WebViewDatabase::hasHttpAuthUsernamePassword </para><simplesectsep></simplesectsep><para>WebViewDatabase::clearHttpAuthUsernamePassword </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the credentials as a String array, if found. The first element is the username and the second element is the password. Null if no credentials are found. </para>
				/// </returns>
				/// <java-name>
				/// getHttpAuthUsernamePassword
				/// </java-name>
				[Dot42.DexImport("getHttpAuthUsernamePassword", "(Ljava/lang/String;Ljava/lang/String;)[Ljava/lang/String;", AccessFlags = 1)]
				public virtual string[] GetHttpAuthUsernamePassword(string host, string realm) /* MethodBuilder.Create */ 
				{
						return default(string[]);
				}

				/// <summary>
				/// <para>Destroys the internal state of this WebView. This method should be called after this WebView has been removed from the view system. No other methods may be called on this WebView after destroy. </para>        
				/// </summary>
				/// <java-name>
				/// destroy
				/// </java-name>
				[Dot42.DexImport("destroy", "()V", AccessFlags = 1)]
				public virtual void Destroy() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Enables platform notifications of data state and proxy changes. Notifications are enabled by default.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>This method is now obsolete.  Since API level android.os.Build.VERSION_CODES#JELLY_BEAN_MR1 </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// enablePlatformNotifications
				/// </java-name>
				[Dot42.DexImport("enablePlatformNotifications", "()V", AccessFlags = 9)]
				public static void EnablePlatformNotifications() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Disables platform notifications of data state and proxy changes. Notifications are enabled by default.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>This method is now obsolete.  Since API level android.os.Build.VERSION_CODES#JELLY_BEAN_MR1 </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// disablePlatformNotifications
				/// </java-name>
				[Dot42.DexImport("disablePlatformNotifications", "()V", AccessFlags = 9)]
				public static void DisablePlatformNotifications() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Informs WebView of the network state. This is used to set the JavaScript property window.navigator.isOnline and generates the online/offline event as specified in HTML5, sec. 5.7.7</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setNetworkAvailable
				/// </java-name>
				[Dot42.DexImport("setNetworkAvailable", "(Z)V", AccessFlags = 1)]
				public virtual void SetNetworkAvailable(bool networkUp) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Saves the state of this WebView used in android.app.Activity#onSaveInstanceState. Please note that this method no longer stores the display data for this WebView. The previous behavior could potentially leak files if restoreState was never called.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the same copy of the back/forward list used to save the state. If saveState fails, the returned list will be null. </para>
				/// </returns>
				/// <java-name>
				/// saveState
				/// </java-name>
				[Dot42.DexImport("saveState", "(Landroid/os/Bundle;)Landroid/webkit/WebBackForwardList;", AccessFlags = 1)]
				public virtual global::Android.Webkit.WebBackForwardList SaveState(global::Android.Os.Bundle outState) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Webkit.WebBackForwardList);
				}

				/// <summary>
				/// <para>Saves the current display data to the Bundle given. Used in conjunction with saveState. <xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>This method is now obsolete.  Since API level android.os.Build.VERSION_CODES#JELLY_BEAN_MR1 </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				/// <para>true if the picture was successfully saved </para>
				/// </returns>
				/// <java-name>
				/// savePicture
				/// </java-name>
				[Dot42.DexImport("savePicture", "(Landroid/os/Bundle;Ljava/io/File;)Z", AccessFlags = 1)]
				public virtual bool SavePicture(global::Android.Os.Bundle b, global::Java.Io.File dest) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Restores the display data that was saved in savePicture. Used in conjunction with restoreState. Note that this will not work if this WebView is hardware accelerated.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>This method is now obsolete.  Since API level android.os.Build.VERSION_CODES#JELLY_BEAN_MR1 </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				/// <para>true if the picture was successfully restored </para>
				/// </returns>
				/// <java-name>
				/// restorePicture
				/// </java-name>
				[Dot42.DexImport("restorePicture", "(Landroid/os/Bundle;Ljava/io/File;)Z", AccessFlags = 1)]
				public virtual bool RestorePicture(global::Android.Os.Bundle b, global::Java.Io.File src) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Restores the state of this WebView from the given Bundle. This method is intended for use in android.app.Activity#onRestoreInstanceState and should be called to restore the state of this WebView. If it is called after this WebView has had a chance to build state (load pages, create a back/forward list, etc.) there may be undesirable side-effects. Please note that this method no longer restores the display data for this WebView.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the restored back/forward list or null if restoreState failed </para>
				/// </returns>
				/// <java-name>
				/// restoreState
				/// </java-name>
				[Dot42.DexImport("restoreState", "(Landroid/os/Bundle;)Landroid/webkit/WebBackForwardList;", AccessFlags = 1)]
				public virtual global::Android.Webkit.WebBackForwardList RestoreState(global::Android.Os.Bundle inState) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Webkit.WebBackForwardList);
				}

				/// <summary>
				/// <para>Loads the given URL with the specified additional HTTP headers.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// loadUrl
				/// </java-name>
				[Dot42.DexImport("loadUrl", "(Ljava/lang/String;Ljava/util/Map;)V", AccessFlags = 1, Signature = "(Ljava/lang/String;Ljava/util/Map<Ljava/lang/String;Ljava/lang/String;>;)V")]
				public virtual void LoadUrl(string url, global::Java.Util.IMap<string, string> additionalHttpHeaders) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Loads the given URL.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// loadUrl
				/// </java-name>
				[Dot42.DexImport("loadUrl", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void LoadUrl(string url) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Loads the URL with postData using "POST" method into this WebView. If url is not a network URL, it will be loaded with {link loadUrl(String) instead.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// postUrl
				/// </java-name>
				[Dot42.DexImport("postUrl", "(Ljava/lang/String;[B)V", AccessFlags = 1)]
				public virtual void PostUrl(string url, sbyte[] postData) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Loads the URL with postData using "POST" method into this WebView. If url is not a network URL, it will be loaded with {link loadUrl(String) instead.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// postUrl
				/// </java-name>
				[Dot42.DexImport("postUrl", "(Ljava/lang/String;[B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual void PostUrl(string url, byte[] postData) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Loads the given data into this WebView using a 'data' scheme URL. </para><para>Note that JavaScript's same origin policy means that script running in a page loaded using this method will be unable to access content loaded using any scheme other than 'data', including 'http(s)'. To avoid this restriction, use loadDataWithBaseURL() with an appropriate base URL. </para><para>The encoding parameter specifies whether the data is base64 or URL encoded. If the data is base64 encoded, the value of the encoding parameter must be 'base64'. For all other values of the parameter, including null, it is assumed that the data uses ASCII encoding for octets inside the range of safe URL characters and use the standard xx hex encoding of URLs for octets outside that range. For example, '#', '', '\', '?' should be replaced by %23, %25, %27, %3f respectively. </para><para>The 'data' scheme URL formed by this method uses the default US-ASCII charset. If you need need to set a different charset, you should form a 'data' scheme URL which explicitly specifies a charset parameter in the mediatype portion of the URL and call loadUrl(String) instead. Note that the charset obtained from the mediatype portion of a data URL always overrides that specified in the HTML or XML document itself.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// loadData
				/// </java-name>
				[Dot42.DexImport("loadData", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void LoadData(string data, string mimeType, string encoding) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Loads the given data into this WebView, using baseUrl as the base URL for the content. The base URL is used both to resolve relative URLs and when applying JavaScript's same origin policy. The historyUrl is used for the history entry. </para><para>Note that content specified in this way can access local device files (via 'file' scheme URLs) only if baseUrl specifies a scheme other than 'http', 'https', 'ftp', 'ftps', 'about' or 'javascript'. </para><para>If the base URL uses the data scheme, this method is equivalent to calling loadData() and the historyUrl is ignored.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// loadDataWithBaseURL
				/// </java-name>
				[Dot42.DexImport("loadDataWithBaseURL", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/la" +
    "ng/String;)V", AccessFlags = 1)]
				public virtual void LoadDataWithBaseURL(string baseUrl, string data, string mimeType, string encoding, string historyUrl) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Saves the current view as a web archive.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// saveWebArchive
				/// </java-name>
				[Dot42.DexImport("saveWebArchive", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SaveWebArchive(string filename) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Saves the current view as a web archive.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// saveWebArchive
				/// </java-name>
				[Dot42.DexImport("saveWebArchive", "(Ljava/lang/String;ZLandroid/webkit/ValueCallback;)V", AccessFlags = 1, Signature = "(Ljava/lang/String;ZLandroid/webkit/ValueCallback<Ljava/lang/String;>;)V")]
				public virtual void SaveWebArchive(string basename, bool autoname, global::Android.Webkit.IValueCallback<string> callback) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Stops the current load. </para>        
				/// </summary>
				/// <java-name>
				/// stopLoading
				/// </java-name>
				[Dot42.DexImport("stopLoading", "()V", AccessFlags = 1)]
				public virtual void StopLoading() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Reloads the current URL. </para>        
				/// </summary>
				/// <java-name>
				/// reload
				/// </java-name>
				[Dot42.DexImport("reload", "()V", AccessFlags = 1)]
				public virtual void Reload() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets whether this WebView has a back history item.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true iff this WebView has a back history item </para>
				/// </returns>
				/// <java-name>
				/// canGoBack
				/// </java-name>
				[Dot42.DexImport("canGoBack", "()Z", AccessFlags = 1)]
				public virtual bool CanGoBack() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Goes back in the history of this WebView. </para>        
				/// </summary>
				/// <java-name>
				/// goBack
				/// </java-name>
				[Dot42.DexImport("goBack", "()V", AccessFlags = 1)]
				public virtual void GoBack() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets whether this WebView has a forward history item.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true iff this Webview has a forward history item </para>
				/// </returns>
				/// <java-name>
				/// canGoForward
				/// </java-name>
				[Dot42.DexImport("canGoForward", "()Z", AccessFlags = 1)]
				public virtual bool CanGoForward() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Goes forward in the history of this WebView. </para>        
				/// </summary>
				/// <java-name>
				/// goForward
				/// </java-name>
				[Dot42.DexImport("goForward", "()V", AccessFlags = 1)]
				public virtual void GoForward() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets whether the page can go back or forward the given number of steps.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// canGoBackOrForward
				/// </java-name>
				[Dot42.DexImport("canGoBackOrForward", "(I)Z", AccessFlags = 1)]
				public virtual bool CanGoBackOrForward(int steps) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Goes to the history item that is the number of steps away from the current item. Steps is negative if backward and positive if forward.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// goBackOrForward
				/// </java-name>
				[Dot42.DexImport("goBackOrForward", "(I)V", AccessFlags = 1)]
				public virtual void GoBackOrForward(int steps) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets whether private browsing is enabled in this WebView. </para>        
				/// </summary>
				/// <java-name>
				/// isPrivateBrowsingEnabled
				/// </java-name>
				[Dot42.DexImport("isPrivateBrowsingEnabled", "()Z", AccessFlags = 1)]
				public virtual bool IsPrivateBrowsingEnabled() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Scrolls the contents of this WebView up by half the view size.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if the page was scrolled </para>
				/// </returns>
				/// <java-name>
				/// pageUp
				/// </java-name>
				[Dot42.DexImport("pageUp", "(Z)Z", AccessFlags = 1)]
				public virtual bool PageUp(bool top) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Scrolls the contents of this WebView down by half the page size.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if the page was scrolled </para>
				/// </returns>
				/// <java-name>
				/// pageDown
				/// </java-name>
				[Dot42.DexImport("pageDown", "(Z)Z", AccessFlags = 1)]
				public virtual bool PageDown(bool bottom) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Clears this WebView so that onDraw() will draw nothing but white background, and onMeasure() will return 0 if MeasureSpec is not MeasureSpec.EXACTLY. <xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>Use WebView.loadUrl("about:blank") to reliably reset the view state and release page resources (including any running JavaScript). </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// clearView
				/// </java-name>
				[Dot42.DexImport("clearView", "()V", AccessFlags = 1)]
				public virtual void ClearView() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets a new picture that captures the current contents of this WebView. The picture is of the entire document being displayed, and is not limited to the area currently displayed by this WebView. Also, the picture is a static copy and is unaffected by later changes to the content being displayed. </para><para>Note that due to internal changes, for API levels between android.os.Build.VERSION_CODES#HONEYCOMB and android.os.Build.VERSION_CODES#ICE_CREAM_SANDWICH inclusive, the picture does not include fixed position elements or scrollable divs.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a picture that captures the current contents of this WebView </para>
				/// </returns>
				/// <java-name>
				/// capturePicture
				/// </java-name>
				[Dot42.DexImport("capturePicture", "()Landroid/graphics/Picture;", AccessFlags = 1)]
				public virtual global::Android.Graphics.Picture CapturePicture() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Picture);
				}

				/// <summary>
				/// <para>Gets the current scale of this WebView.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>This method is prone to inaccuracy due to race conditions between the web rendering and UI threads; prefer WebViewClient#onScaleChanged. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				/// <para>the current scale</para>
				/// </returns>
				/// <java-name>
				/// getScale
				/// </java-name>
				[Dot42.DexImport("getScale", "()F", AccessFlags = 1)]
				public virtual float GetScale() /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				/// <para>Sets the initial scale for this WebView. 0 means default. If WebSettings#getUseWideViewPort() is true, it zooms out all the way. Otherwise it starts with 100%. If initial scale is greater than 0, WebView starts with this value as initial scale. Please note that unlike the scale properties in the viewport meta tag, this method doesn't take the screen density into account.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setInitialScale
				/// </java-name>
				[Dot42.DexImport("setInitialScale", "(I)V", AccessFlags = 1)]
				public virtual void SetInitialScale(int scaleInPercent) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Invokes the graphical zoom picker widget for this WebView. This will result in the zoom widget appearing on the screen to control the zoom level of this WebView. </para>        
				/// </summary>
				/// <java-name>
				/// invokeZoomPicker
				/// </java-name>
				[Dot42.DexImport("invokeZoomPicker", "()V", AccessFlags = 1)]
				public virtual void InvokeZoomPicker() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets a HitTestResult based on the current cursor node. If a HTML::a tag is found and the anchor has a non-JavaScript URL, the HitTestResult type is set to SRC_ANCHOR_TYPE and the URL is set in the "extra" field. If the anchor does not have a URL or if it is a JavaScript URL, the type will be UNKNOWN_TYPE and the URL has to be retrieved through requestFocusNodeHref asynchronously. If a HTML::img tag is found, the HitTestResult type is set to IMAGE_TYPE and the URL is set in the "extra" field. A type of SRC_IMAGE_ANCHOR_TYPE indicates an anchor with a URL that has an image as a child node. If a phone number is found, the HitTestResult type is set to PHONE_TYPE and the phone number is set in the "extra" field of HitTestResult. If a map address is found, the HitTestResult type is set to GEO_TYPE and the address is set in the "extra" field of HitTestResult. If an email address is found, the HitTestResult type is set to EMAIL_TYPE and the email is set in the "extra" field of HitTestResult. Otherwise, HitTestResult type is set to UNKNOWN_TYPE. </para>        
				/// </summary>
				/// <java-name>
				/// getHitTestResult
				/// </java-name>
				[Dot42.DexImport("getHitTestResult", "()Landroid/webkit/WebView$HitTestResult;", AccessFlags = 1)]
				public virtual global::Android.Webkit.WebView.HitTestResult GetHitTestResult() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Webkit.WebView.HitTestResult);
				}

				/// <summary>
				/// <para>Requests the anchor or image element URL at the last tapped point. If hrefMsg is null, this method returns immediately and does not dispatch hrefMsg to its target. If the tapped point hits an image, an anchor, or an image in an anchor, the message associates strings in named keys in its data. The value paired with the key may be an empty string.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// requestFocusNodeHref
				/// </java-name>
				[Dot42.DexImport("requestFocusNodeHref", "(Landroid/os/Message;)V", AccessFlags = 1)]
				public virtual void RequestFocusNodeHref(global::Android.Os.Message hrefMsg) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Requests the URL of the image last touched by the user. msg will be sent to its target with a String representing the URL as its object.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// requestImageRef
				/// </java-name>
				[Dot42.DexImport("requestImageRef", "(Landroid/os/Message;)V", AccessFlags = 1)]
				public virtual void RequestImageRef(global::Android.Os.Message msg) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Compute the horizontal range that the horizontal scrollbar represents.</para><para>The range is expressed in arbitrary units that must be the same as the units used by computeHorizontalScrollExtent() and computeHorizontalScrollOffset().</para><para>The default range is the drawing width of this view.</para><para><para>computeHorizontalScrollExtent() </para><simplesectsep></simplesectsep><para>computeHorizontalScrollOffset() </para><simplesectsep></simplesectsep><para>android.widget.ScrollBarDrawable </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the total horizontal range represented by the horizontal scrollbar</para>
				/// </returns>
				/// <java-name>
				/// computeHorizontalScrollRange
				/// </java-name>
				[Dot42.DexImport("computeHorizontalScrollRange", "()I", AccessFlags = 4)]
				protected internal override int ComputeHorizontalScrollRange() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Compute the horizontal offset of the horizontal scrollbar's thumb within the horizontal range. This value is used to compute the position of the thumb within the scrollbar's track.</para><para>The range is expressed in arbitrary units that must be the same as the units used by computeHorizontalScrollRange() and computeHorizontalScrollExtent().</para><para>The default offset is the scroll offset of this view.</para><para><para>computeHorizontalScrollRange() </para><simplesectsep></simplesectsep><para>computeHorizontalScrollExtent() </para><simplesectsep></simplesectsep><para>android.widget.ScrollBarDrawable </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the horizontal offset of the scrollbar's thumb</para>
				/// </returns>
				/// <java-name>
				/// computeHorizontalScrollOffset
				/// </java-name>
				[Dot42.DexImport("computeHorizontalScrollOffset", "()I", AccessFlags = 4)]
				protected internal override int ComputeHorizontalScrollOffset() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Compute the vertical range that the vertical scrollbar represents.</para><para>The range is expressed in arbitrary units that must be the same as the units used by computeVerticalScrollExtent() and computeVerticalScrollOffset().</para><para></para><para>The default range is the drawing height of this view.</para><para><para>computeVerticalScrollExtent() </para><simplesectsep></simplesectsep><para>computeVerticalScrollOffset() </para><simplesectsep></simplesectsep><para>android.widget.ScrollBarDrawable </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the total vertical range represented by the vertical scrollbar</para>
				/// </returns>
				/// <java-name>
				/// computeVerticalScrollRange
				/// </java-name>
				[Dot42.DexImport("computeVerticalScrollRange", "()I", AccessFlags = 4)]
				protected internal override int ComputeVerticalScrollRange() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Compute the vertical offset of the vertical scrollbar's thumb within the horizontal range. This value is used to compute the position of the thumb within the scrollbar's track.</para><para>The range is expressed in arbitrary units that must be the same as the units used by computeVerticalScrollRange() and computeVerticalScrollExtent().</para><para>The default offset is the scroll offset of this view.</para><para><para>computeVerticalScrollRange() </para><simplesectsep></simplesectsep><para>computeVerticalScrollExtent() </para><simplesectsep></simplesectsep><para>android.widget.ScrollBarDrawable </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the vertical offset of the scrollbar's thumb</para>
				/// </returns>
				/// <java-name>
				/// computeVerticalScrollOffset
				/// </java-name>
				[Dot42.DexImport("computeVerticalScrollOffset", "()I", AccessFlags = 4)]
				protected internal override int ComputeVerticalScrollOffset() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Compute the vertical extent of the horizontal scrollbar's thumb within the vertical range. This value is used to compute the length of the thumb within the scrollbar's track.</para><para>The range is expressed in arbitrary units that must be the same as the units used by computeVerticalScrollRange() and computeVerticalScrollOffset().</para><para>The default extent is the drawing height of this view.</para><para><para>computeVerticalScrollRange() </para><simplesectsep></simplesectsep><para>computeVerticalScrollOffset() </para><simplesectsep></simplesectsep><para>android.widget.ScrollBarDrawable </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the vertical extent of the scrollbar's thumb</para>
				/// </returns>
				/// <java-name>
				/// computeVerticalScrollExtent
				/// </java-name>
				[Dot42.DexImport("computeVerticalScrollExtent", "()I", AccessFlags = 4)]
				protected internal override int ComputeVerticalScrollExtent() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// onOverScrolled
				/// </java-name>
				[Dot42.DexImport("onOverScrolled", "(IIZZ)V", AccessFlags = 4)]
				protected internal override void OnOverScrolled(int scrollX, int scrollY, bool clampedX, bool clampedY) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets the URL for the current page. This is not always the same as the URL passed to WebViewClient.onPageStarted because although the load for that URL has begun, the current page may not have changed.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the URL for the current page </para>
				/// </returns>
				/// <java-name>
				/// getUrl
				/// </java-name>
				[Dot42.DexImport("getUrl", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetUrl() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Gets the original URL for the current page. This is not always the same as the URL passed to WebViewClient.onPageStarted because although the load for that URL has begun, the current page may not have changed. Also, there may have been redirects resulting in a different URL to that originally requested.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the URL that was originally requested for the current page </para>
				/// </returns>
				/// <java-name>
				/// getOriginalUrl
				/// </java-name>
				[Dot42.DexImport("getOriginalUrl", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetOriginalUrl() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Gets the title for the current page. This is the title of the current page until WebViewClient.onReceivedTitle is called.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the title for the current page </para>
				/// </returns>
				/// <java-name>
				/// getTitle
				/// </java-name>
				[Dot42.DexImport("getTitle", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetTitle() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Gets the favicon for the current page. This is the favicon of the current page until WebViewClient.onReceivedIcon is called.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the favicon for the current page </para>
				/// </returns>
				/// <java-name>
				/// getFavicon
				/// </java-name>
				[Dot42.DexImport("getFavicon", "()Landroid/graphics/Bitmap;", AccessFlags = 1)]
				public virtual global::Android.Graphics.Bitmap GetFavicon() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Bitmap);
				}

				/// <summary>
				/// <para>Gets the progress for the current page.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the progress for the current page between 0 and 100 </para>
				/// </returns>
				/// <java-name>
				/// getProgress
				/// </java-name>
				[Dot42.DexImport("getProgress", "()I", AccessFlags = 1)]
				public virtual int GetProgress() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Gets the height of the HTML content.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the height of the HTML content </para>
				/// </returns>
				/// <java-name>
				/// getContentHeight
				/// </java-name>
				[Dot42.DexImport("getContentHeight", "()I", AccessFlags = 1)]
				public virtual int GetContentHeight() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Pauses all layout, parsing, and JavaScript timers for all WebViews. This is a global requests, not restricted to just this WebView. This can be useful if the application has been paused. </para>        
				/// </summary>
				/// <java-name>
				/// pauseTimers
				/// </java-name>
				[Dot42.DexImport("pauseTimers", "()V", AccessFlags = 1)]
				public virtual void PauseTimers() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Resumes all layout, parsing, and JavaScript timers for all WebViews. This will resume dispatching all timers. </para>        
				/// </summary>
				/// <java-name>
				/// resumeTimers
				/// </java-name>
				[Dot42.DexImport("resumeTimers", "()V", AccessFlags = 1)]
				public virtual void ResumeTimers() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Pauses any extra processing associated with this WebView and its associated DOM, plugins, JavaScript etc. For example, if this WebView is taken offscreen, this could be called to reduce unnecessary CPU or network traffic. When this WebView is again "active", call onResume(). Note that this differs from pauseTimers(), which affects all WebViews. </para>        
				/// </summary>
				/// <java-name>
				/// onPause
				/// </java-name>
				[Dot42.DexImport("onPause", "()V", AccessFlags = 1)]
				public virtual void OnPause() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Resumes a WebView after a previous call to onPause(). </para>        
				/// </summary>
				/// <java-name>
				/// onResume
				/// </java-name>
				[Dot42.DexImport("onResume", "()V", AccessFlags = 1)]
				public virtual void OnResume() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Informs this WebView that memory is low so that it can free any available memory. </para>        
				/// </summary>
				/// <java-name>
				/// freeMemory
				/// </java-name>
				[Dot42.DexImport("freeMemory", "()V", AccessFlags = 1)]
				public virtual void FreeMemory() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Clears the resource cache. Note that the cache is per-application, so this will clear the cache for all WebViews used.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// clearCache
				/// </java-name>
				[Dot42.DexImport("clearCache", "(Z)V", AccessFlags = 1)]
				public virtual void ClearCache(bool includeDiskFiles) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Removes the autocomplete popup from the currently focused form field, if present. Note this only affects the display of the autocomplete popup, it does not remove any saved form data from this WebView's store. To do that, use WebViewDatabase#clearFormData. </para>        
				/// </summary>
				/// <java-name>
				/// clearFormData
				/// </java-name>
				[Dot42.DexImport("clearFormData", "()V", AccessFlags = 1)]
				public virtual void ClearFormData() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Tells this WebView to clear its internal back/forward list. </para>        
				/// </summary>
				/// <java-name>
				/// clearHistory
				/// </java-name>
				[Dot42.DexImport("clearHistory", "()V", AccessFlags = 1)]
				public virtual void ClearHistory() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Clears the SSL preferences table stored in response to proceeding with SSL certificate errors. </para>        
				/// </summary>
				/// <java-name>
				/// clearSslPreferences
				/// </java-name>
				[Dot42.DexImport("clearSslPreferences", "()V", AccessFlags = 1)]
				public virtual void ClearSslPreferences() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets the WebBackForwardList for this WebView. This contains the back/forward list for use in querying each item in the history stack. This is a copy of the private WebBackForwardList so it contains only a snapshot of the current state. Multiple calls to this method may return different objects. The object returned from this method will not be updated to reflect any new state. </para>        
				/// </summary>
				/// <java-name>
				/// copyBackForwardList
				/// </java-name>
				[Dot42.DexImport("copyBackForwardList", "()Landroid/webkit/WebBackForwardList;", AccessFlags = 1)]
				public virtual global::Android.Webkit.WebBackForwardList CopyBackForwardList() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Webkit.WebBackForwardList);
				}

				/// <summary>
				/// <para>Highlights and scrolls to the next match found by findAllAsync, wrapping around page boundaries as necessary. Notifies any registered FindListener. If findAllAsync(String) has not been called yet, or if clearMatches has been called since the last find operation, this function does nothing.</para><para><para>setFindListener </para></para>        
				/// </summary>
				/// <java-name>
				/// findNext
				/// </java-name>
				[Dot42.DexImport("findNext", "(Z)V", AccessFlags = 1)]
				public virtual void FindNext(bool forward) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Finds all instances of find on the page and highlights them. Notifies any registered FindListener.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>findAllAsync is preferred. </para></xrefdescription></xrefsect><para>setFindListener </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of occurances of the String "find" that were found </para>
				/// </returns>
				/// <java-name>
				/// findAll
				/// </java-name>
				[Dot42.DexImport("findAll", "(Ljava/lang/String;)I", AccessFlags = 1)]
				public virtual int FindAll(string find) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Starts an ActionMode for finding text in this WebView. Only works if this WebView is attached to the view system.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>This method does not work reliably on all Android versions; implementing a custom find dialog using WebView.findAllAsync() provides a more robust solution. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				/// <para>true if the find dialog is shown, false otherwise </para>
				/// </returns>
				/// <java-name>
				/// showFindDialog
				/// </java-name>
				[Dot42.DexImport("showFindDialog", "(Ljava/lang/String;Z)Z", AccessFlags = 1)]
				public virtual bool ShowFindDialog(string text, bool showIme) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Gets the first substring consisting of the address of a physical location. Currently, only addresses in the United States are detected, and consist of: <ul><li><para>a house number </para></li><li><para>a street name </para></li><li><para>a street type (Road, Circle, etc), either spelled out or abbreviated </para></li><li><para>a city name </para></li><li><para>a state or territory, either spelled out or two-letter abbr </para></li><li><para>an optional 5 digit or 9 digit zip code </para></li></ul>All names must be correctly capitalized, and the zip code, if present, must be valid for the state. The street type must be a standard USPS spelling or abbreviation. The state or territory must also be spelled or abbreviated using USPS standards. The house number may not exceed five digits.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the address, or if no address is found, null </para>
				/// </returns>
				/// <java-name>
				/// findAddress
				/// </java-name>
				[Dot42.DexImport("findAddress", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 9)]
				public static string FindAddress(string addr) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Clears the highlighting surrounding text matches created by findAllAsync. </para>        
				/// </summary>
				/// <java-name>
				/// clearMatches
				/// </java-name>
				[Dot42.DexImport("clearMatches", "()V", AccessFlags = 1)]
				public virtual void ClearMatches() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Queries the document to see if it contains any image references. The message object will be dispatched with arg1 being set to 1 if images were found and 0 if the document does not reference any images.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// documentHasImages
				/// </java-name>
				[Dot42.DexImport("documentHasImages", "(Landroid/os/Message;)V", AccessFlags = 1)]
				public virtual void DocumentHasImages(global::Android.Os.Message response) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Called by a parent to request that a child update its values for mScrollX and mScrollY if necessary. This will typically be done if the child is animating a scroll using a Scroller object. </para>        
				/// </summary>
				/// <java-name>
				/// computeScroll
				/// </java-name>
				[Dot42.DexImport("computeScroll", "()V", AccessFlags = 1)]
				public override void ComputeScroll() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the WebViewClient that will receive various notifications and requests. This will replace the current handler.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setWebViewClient
				/// </java-name>
				[Dot42.DexImport("setWebViewClient", "(Landroid/webkit/WebViewClient;)V", AccessFlags = 1)]
				public virtual void SetWebViewClient(global::Android.Webkit.WebViewClient client) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Registers the interface to be used when content can not be handled by the rendering engine, and should be downloaded instead. This will replace the current handler.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setDownloadListener
				/// </java-name>
				[Dot42.DexImport("setDownloadListener", "(Landroid/webkit/DownloadListener;)V", AccessFlags = 1)]
				public virtual void SetDownloadListener(global::Android.Webkit.IDownloadListener listener) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the chrome handler. This is an implementation of WebChromeClient for use in handling JavaScript dialogs, favicons, titles, and the progress. This will replace the current handler.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setWebChromeClient
				/// </java-name>
				[Dot42.DexImport("setWebChromeClient", "(Landroid/webkit/WebChromeClient;)V", AccessFlags = 1)]
				public virtual void SetWebChromeClient(global::Android.Webkit.WebChromeClient client) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the Picture listener. This is an interface used to receive notifications of a new Picture.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>This method is now obsolete. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// setPictureListener
				/// </java-name>
				[Dot42.DexImport("setPictureListener", "(Landroid/webkit/WebView$PictureListener;)V", AccessFlags = 1)]
				public virtual void SetPictureListener(global::Android.Webkit.WebView.IPictureListener listener) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>JavascriptInterface public String toString() { return "injectedObject"; } } webView.addJavascriptInterface(new JsObject(), "injectedObject"); webView.loadData("&lt;!DOCTYPE html&gt;&lt;title&gt;&lt;/title&gt;", "text/html", null); webView.loadUrl("javascript:alert(injectedObject.toString())"); </para><para><b>IMPORTANT:</b> <ul><li><para>This method can be used to allow JavaScript to control the host application. This is a powerful feature, but also presents a security risk for applications targeted to API level android.os.Build.VERSION_CODES#JELLY_BEAN or below, because JavaScript could use reflection to access an injected object's public fields. Use of this method in a WebView containing untrusted content could allow an attacker to manipulate the host application in unintended ways, executing Java code with the permissions of the host application. Use extreme care when using this method in a WebView which could contain untrusted content. </para></li><li><para>JavaScript interacts with Java object on a private, background thread of this WebView. Care is therefore required to maintain thread safety. </para></li><li><para>The Java object's fields are not accessible. </para></li></ul></para><para></para>        
				/// </summary>
				/// <java-name>
				/// addJavascriptInterface
				/// </java-name>
				[Dot42.DexImport("addJavascriptInterface", "(Ljava/lang/Object;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void AddJavascriptInterface(object @object, string name) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Removes a previously injected Java object from this WebView. Note that the removal will not be reflected in JavaScript until the page is next (re)loaded. See addJavascriptInterface.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// removeJavascriptInterface
				/// </java-name>
				[Dot42.DexImport("removeJavascriptInterface", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void RemoveJavascriptInterface(string name) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets the WebSettings object used to control the settings for this WebView.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a WebSettings object that can be used to control this WebView's settings </para>
				/// </returns>
				/// <java-name>
				/// getSettings
				/// </java-name>
				[Dot42.DexImport("getSettings", "()Landroid/webkit/WebSettings;", AccessFlags = 1)]
				public virtual global::Android.Webkit.WebSettings GetSettings() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Webkit.WebSettings);
				}

				/// <java-name>
				/// finalize
				/// </java-name>
				[Dot42.DexImport("finalize", "()V", AccessFlags = 4)]
				extern ~WebView() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// drawChild
				/// </java-name>
				[Dot42.DexImport("drawChild", "(Landroid/graphics/Canvas;Landroid/view/View;J)Z", AccessFlags = 4)]
				protected internal override bool DrawChild(global::Android.Graphics.Canvas canvas, global::Android.View.View view, long int64) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Implement this to do your drawing.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// onDraw
				/// </java-name>
				[Dot42.DexImport("onDraw", "(Landroid/graphics/Canvas;)V", AccessFlags = 4)]
				protected internal override void OnDraw(global::Android.Graphics.Canvas canvas) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setLayoutParams
				/// </java-name>
				[Dot42.DexImport("setLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)V", AccessFlags = 1)]
				public override void SetLayoutParams(global::Android.View.ViewGroup.LayoutParams @params) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Call this view's OnLongClickListener, if it is defined. Invokes the context menu if the OnLongClickListener did not consume the event.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>True if one of the above receivers consumed the event, false otherwise. </para>
				/// </returns>
				/// <java-name>
				/// performLongClick
				/// </java-name>
				[Dot42.DexImport("performLongClick", "()Z", AccessFlags = 1)]
				public override bool PerformLongClick() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Called when the current configuration of the resources being used by the application have changed. You can use this to decide when to reload resources that can changed based on orientation and other configuration characterstics. You only need to use this if you are not relying on the normal android.app.Activity mechanism of recreating the activity instance upon a configuration change.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// onConfigurationChanged
				/// </java-name>
				[Dot42.DexImport("onConfigurationChanged", "(Landroid/content/res/Configuration;)V", AccessFlags = 4)]
				protected internal override void OnConfigurationChanged(global::Android.Content.Res.Configuration newConfig) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Create a new InputConnection for an InputMethod to interact with the view. The default implementation returns null, since it doesn't support input methods. You can override this to implement such support. This is only needed for views that take focus and text input.</para><para>When implementing this, you probably also want to implement onCheckIsTextEditor() to indicate you will return a non-null InputConnection.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// onCreateInputConnection
				/// </java-name>
				[Dot42.DexImport("onCreateInputConnection", "(Landroid/view/inputmethod/EditorInfo;)Landroid/view/inputmethod/InputConnection;" +
    "", AccessFlags = 1)]
				public override global::Android.View.Inputmethod.IInputConnection OnCreateInputConnection(global::Android.View.Inputmethod.EditorInfo outAttrs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.View.Inputmethod.IInputConnection);
				}

				/// <summary>
				/// <para>Default implementation of KeyEvent.Callback.onKeyMultiple(): always returns false (doesn't handle the event). </para><para>Key presses in software keyboards will generally NOT trigger this listener, although some may elect to do so in some situations. Do not rely on this to catch software key presses.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// onKeyMultiple
				/// </java-name>
				[Dot42.DexImport("onKeyMultiple", "(IILandroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public override bool OnKeyMultiple(int keyCode, int repeatCount, global::Android.View.KeyEvent @event) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Default implementation of KeyEvent.Callback.onKeyDown(): perform press of the view when KeyEvent#KEYCODE_DPAD_CENTER or KeyEvent#KEYCODE_ENTER is released, if the view is enabled and clickable.</para><para>Key presses in software keyboards will generally NOT trigger this listener, although some may elect to do so in some situations. Do not rely on this to catch software key presses.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// onKeyDown
				/// </java-name>
				[Dot42.DexImport("onKeyDown", "(ILandroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public override bool OnKeyDown(int keyCode, global::Android.View.KeyEvent @event) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Default implementation of KeyEvent.Callback.onKeyUp(): perform clicking of the view when KeyEvent#KEYCODE_DPAD_CENTER or KeyEvent#KEYCODE_ENTER is released. </para><para>Key presses in software keyboards will generally NOT trigger this listener, although some may elect to do so in some situations. Do not rely on this to catch software key presses.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// onKeyUp
				/// </java-name>
				[Dot42.DexImport("onKeyUp", "(ILandroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public override bool OnKeyUp(int keyCode, global::Android.View.KeyEvent @event) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Puts this WebView into text selection mode. Do not rely on this functionality; it will be deprecated in the future.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>This method is now obsolete.  Since API level android.os.Build.VERSION_CODES#JELLY_BEAN_MR1 </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// emulateShiftHeld
				/// </java-name>
				[Dot42.DexImport("emulateShiftHeld", "()V", AccessFlags = 1)]
				public virtual void EmulateShiftHeld() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>This is called when the view is attached to a window. At this point it has a Surface and will start drawing. Note that this function is guaranteed to be called before onDraw(android.graphics.Canvas), however it may be called any time before the first onDraw  including before or after onMeasure(int, int).</para><para><para>onDetachedFromWindow() </para></para>        
				/// </summary>
				/// <java-name>
				/// onAttachedToWindow
				/// </java-name>
				[Dot42.DexImport("onAttachedToWindow", "()V", AccessFlags = 4)]
				protected internal override void OnAttachedToWindow() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>This is called when the view is detached from a window. At this point it no longer has a surface for drawing.</para><para><para>onAttachedToWindow() </para></para>        
				/// </summary>
				/// <java-name>
				/// onDetachedFromWindow
				/// </java-name>
				[Dot42.DexImport("onDetachedFromWindow", "()V", AccessFlags = 4)]
				protected internal override void OnDetachedFromWindow() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Called when the visibility of the view or an ancestor of the view is changed. </para>        
				/// </summary>
				/// <java-name>
				/// onVisibilityChanged
				/// </java-name>
				[Dot42.DexImport("onVisibilityChanged", "(Landroid/view/View;I)V", AccessFlags = 4)]
				protected internal override void OnVisibilityChanged(global::Android.View.View changedView, int visibility) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>WebView no longer needs to implement ViewGroup.OnHierarchyChangeListener. This method does nothing now. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// onChildViewAdded
				/// </java-name>
				[Dot42.DexImport("onChildViewAdded", "(Landroid/view/View;Landroid/view/View;)V", AccessFlags = 1)]
				public virtual void OnChildViewAdded(global::Android.View.View parent, global::Android.View.View child) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>WebView no longer needs to implement ViewGroup.OnHierarchyChangeListener. This method does nothing now. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// onChildViewRemoved
				/// </java-name>
				[Dot42.DexImport("onChildViewRemoved", "(Landroid/view/View;Landroid/view/View;)V", AccessFlags = 1)]
				public virtual void OnChildViewRemoved(global::Android.View.View p, global::Android.View.View child) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>WebView should not have implemented ViewTreeObserver.OnGlobalFocusChangeListener. This method does nothing now. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// onGlobalFocusChanged
				/// </java-name>
				[Dot42.DexImport("onGlobalFocusChanged", "(Landroid/view/View;Landroid/view/View;)V", AccessFlags = 1)]
				public virtual void OnGlobalFocusChanged(global::Android.View.View oldFocus, global::Android.View.View newFocus) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Called when the window containing this view gains or loses focus. Note that this is separate from view focus: to receive key events, both your view and its window must have focus. If a window is displayed on top of yours that takes input focus, then your own window will lose focus but the view focus will remain unchanged.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// onWindowFocusChanged
				/// </java-name>
				[Dot42.DexImport("onWindowFocusChanged", "(Z)V", AccessFlags = 1)]
				public override void OnWindowFocusChanged(bool hasWindowFocus) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Called by the view system when the focus state of this view changes. When the focus change event is caused by directional navigation, direction and previouslyFocusedRect provide insight into where the focus is coming from. When overriding, be sure to call up through to the super class so that the standard focus handling will occur.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// onFocusChanged
				/// </java-name>
				[Dot42.DexImport("onFocusChanged", "(ZILandroid/graphics/Rect;)V", AccessFlags = 4)]
				protected internal override void OnFocusChanged(bool gainFocus, int direction, global::Android.Graphics.Rect previouslyFocusedRect) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>This is called during layout when the size of this view has changed. If you were just added to the view hierarchy, you're called with the old values of 0.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// onSizeChanged
				/// </java-name>
				[Dot42.DexImport("onSizeChanged", "(IIII)V", AccessFlags = 4)]
				protected internal override void OnSizeChanged(int w, int h, int oldw, int oldh) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>This is called in response to an internal scroll in this view (i.e., the view scrolled its own contents). This is typically as a result of scrollBy(int, int) or scrollTo(int, int) having been called.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// onScrollChanged
				/// </java-name>
				[Dot42.DexImport("onScrollChanged", "(IIII)V", AccessFlags = 4)]
				protected internal override void OnScrollChanged(int l, int t, int oldl, int oldt) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para><para><para>Dispatch a key event to the next view on the focus path. This path runs from the top of the view tree down to the currently focused view. If this view has focus, it will dispatch to itself. Otherwise it will dispatch the next node down the focus path. This method also fires any key listeners.</para><para></para></para> </para>        
				/// </summary>
				/// <returns>
				/// <para>True if the event was handled, false otherwise.</para>
				/// </returns>
				/// <java-name>
				/// dispatchKeyEvent
				/// </java-name>
				[Dot42.DexImport("dispatchKeyEvent", "(Landroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public override bool DispatchKeyEvent(global::Android.View.KeyEvent @event) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Implement this method to handle hover events. </para><para>This method is called whenever a pointer is hovering into, over, or out of the bounds of a view and the view is not currently being touched. Hover events are represented as pointer events with action MotionEvent#ACTION_HOVER_ENTER, MotionEvent#ACTION_HOVER_MOVE, or MotionEvent#ACTION_HOVER_EXIT. </para><para><ul><li><para>The view receives a hover event with action MotionEvent#ACTION_HOVER_ENTER when the pointer enters the bounds of the view. </para></li><li><para>The view receives a hover event with action MotionEvent#ACTION_HOVER_MOVE when the pointer has already entered the bounds of the view and has moved. </para></li><li><para>The view receives a hover event with action MotionEvent#ACTION_HOVER_EXIT when the pointer has exited the bounds of the view or when the pointer is about to go down due to a button click, tap, or similar user action that causes the view to be touched. </para></li></ul></para><para>The view should implement this method to return true to indicate that it is handling the hover event, such as by changing its drawable state. </para><para>The default implementation calls setHovered to update the hovered state of the view when a hover enter or hover exit event is received, if the view is enabled and is clickable. The default implementation also sends hover accessibility events. </para><para><para>isHovered </para><simplesectsep></simplesectsep><para>setHovered </para><simplesectsep></simplesectsep><para>onHoverChanged </para></para>        
				/// </summary>
				/// <returns>
				/// <para>True if the view handled the hover event.</para>
				/// </returns>
				/// <java-name>
				/// onHoverEvent
				/// </java-name>
				[Dot42.DexImport("onHoverEvent", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1)]
				public override bool OnHoverEvent(global::Android.View.MotionEvent @event) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Implement this method to handle touch screen motion events.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>True if the event was handled, false otherwise. </para>
				/// </returns>
				/// <java-name>
				/// onTouchEvent
				/// </java-name>
				[Dot42.DexImport("onTouchEvent", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1)]
				public override bool OnTouchEvent(global::Android.View.MotionEvent @event) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Implement this method to handle generic motion events. </para><para>Generic motion events describe joystick movements, mouse hovers, track pad touches, scroll wheel movements and other input events. The source of the motion event specifies the class of input that was received. Implementations of this method must examine the bits in the source before processing the event. The following code example shows how this is done. </para><para>Generic motion events with source class InputDevice#SOURCE_CLASS_POINTER are delivered to the view under the pointer. All other generic motion events are delivered to the focused view. </para><para><pre> public boolean onGenericMotionEvent(MotionEvent event) {
				///            if (event.isFromSource(InputDevice.SOURCE_CLASS_JOYSTICK)) {
				///                if (event.getAction() == MotionEvent.ACTION_MOVE) {
				///                    // process the joystick movement...
				///                    return true;
				///                }
				///            }
				///            if (event.isFromSource(InputDevice.SOURCE_CLASS_POINTER)) {
				///                switch (event.getAction()) {
				///                    case MotionEvent.ACTION_HOVER_MOVE:
				///                        // process the mouse hover movement...
				///                        return true;
				///                    case MotionEvent.ACTION_SCROLL:
				///                        // process the scroll wheel movement...
				///                        return true;
				///                }
				///            }
				///            return super.onGenericMotionEvent(event);
				///        }</pre></para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>True if the event was handled, false otherwise. </para>
				/// </returns>
				/// <java-name>
				/// onGenericMotionEvent
				/// </java-name>
				[Dot42.DexImport("onGenericMotionEvent", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1)]
				public override bool OnGenericMotionEvent(global::Android.View.MotionEvent @event) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>Only the default case, true, will be supported in a future version. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// setMapTrackballToArrowKeys
				/// </java-name>
				[Dot42.DexImport("setMapTrackballToArrowKeys", "(Z)V", AccessFlags = 1)]
				public virtual void SetMapTrackballToArrowKeys(bool setMap) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Implement this method to handle trackball motion events. The <b>relative</b> movement of the trackball since the last event can be retrieve with MotionEvent.getX() and MotionEvent.getY(). These are normalized so that a movement of 1 corresponds to the user pressing one DPAD key (so they will often be fractional values, representing the more fine-grained movement information available from a trackball).</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>True if the event was handled, false otherwise. </para>
				/// </returns>
				/// <java-name>
				/// onTrackballEvent
				/// </java-name>
				[Dot42.DexImport("onTrackballEvent", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1)]
				public override bool OnTrackballEvent(global::Android.View.MotionEvent @event) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// flingScroll
				/// </java-name>
				[Dot42.DexImport("flingScroll", "(II)V", AccessFlags = 1)]
				public virtual void FlingScroll(int vx, int vy) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets the zoom controls for this WebView, as a separate View. The caller is responsible for inserting this View into the layout hierarchy. </para><para>API level android.os.Build.VERSION_CODES#CUPCAKE introduced built-in zoom mechanisms for the WebView, as opposed to these separate zoom controls. The built-in mechanisms are preferred and can be enabled using WebSettings#setBuiltInZoomControls.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>the built-in zoom mechanisms are preferred  Since API level android.os.Build.VERSION_CODES#JELLY_BEAN </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// getZoomControls
				/// </java-name>
				[Dot42.DexImport("getZoomControls", "()Landroid/view/View;", AccessFlags = 1)]
				public virtual global::Android.View.View GetZoomControls() /* MethodBuilder.Create */ 
				{
						return default(global::Android.View.View);
				}

				/// <summary>
				/// <para>Gets whether this WebView can be zoomed in.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>This method is prone to inaccuracy due to race conditions between the web rendering and UI threads; prefer WebViewClient#onScaleChanged. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				/// <para>true if this WebView can be zoomed in</para>
				/// </returns>
				/// <java-name>
				/// canZoomIn
				/// </java-name>
				[Dot42.DexImport("canZoomIn", "()Z", AccessFlags = 1)]
				public virtual bool CanZoomIn() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Gets whether this WebView can be zoomed out.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>This method is prone to inaccuracy due to race conditions between the web rendering and UI threads; prefer WebViewClient#onScaleChanged. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				/// <para>true if this WebView can be zoomed out</para>
				/// </returns>
				/// <java-name>
				/// canZoomOut
				/// </java-name>
				[Dot42.DexImport("canZoomOut", "()Z", AccessFlags = 1)]
				public virtual bool CanZoomOut() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Performs zoom in in this WebView.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if zoom in succeeds, false if no zoom changes </para>
				/// </returns>
				/// <java-name>
				/// zoomIn
				/// </java-name>
				[Dot42.DexImport("zoomIn", "()Z", AccessFlags = 1)]
				public virtual bool ZoomIn() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Performs zoom out in this WebView.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if zoom out succeeds, false if no zoom changes </para>
				/// </returns>
				/// <java-name>
				/// zoomOut
				/// </java-name>
				[Dot42.DexImport("zoomOut", "()Z", AccessFlags = 1)]
				public virtual bool ZoomOut() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para><para><para>Call this to try to give focus to a specific view or to one of its descendants and give it hints about the direction and a specific rectangle that the focus is coming from. The rectangle can help give larger views a finer grained hint about where focus is coming from, and therefore, where to show selection, or forward focus change internally.</para><para>A view will not actually take focus if it is not focusable (isFocusable returns false), or if it is focusable and it is not focusable in touch mode (isFocusableInTouchMode) while the device is in touch mode.</para><para>A View will not take focus if it is not visible.</para><para>A View will not take focus if one of its parents has android.view.ViewGroup#getDescendantFocusability() equal to ViewGroup#FOCUS_BLOCK_DESCENDANTS.</para><para>See also focusSearch(int), which is what you call to say that you have focus, and you want your parent to look for the next one.</para><para>You may wish to override this method if your custom View has an internal View that it wishes to forward the request to.</para><para></para></para><para>Looks for a view to give focus to respecting the setting specified by getDescendantFocusability().</para><para>Uses onRequestFocusInDescendants(int, android.graphics.Rect) to find focus within the children of this group when appropriate.</para><para><para>FOCUS_BEFORE_DESCENDANTS </para><simplesectsep></simplesectsep><para>FOCUS_AFTER_DESCENDANTS </para><simplesectsep></simplesectsep><para>FOCUS_BLOCK_DESCENDANTS </para><simplesectsep></simplesectsep><para>onRequestFocusInDescendants(int, android.graphics.Rect) </para></para></para><para>Looks for a view to give focus to respecting the setting specified by getDescendantFocusability().</para><para>Uses onRequestFocusInDescendants(int, android.graphics.Rect) to find focus within the children of this group when appropriate.</para><para><para>FOCUS_BEFORE_DESCENDANTS </para><simplesectsep></simplesectsep><para>FOCUS_AFTER_DESCENDANTS </para><simplesectsep></simplesectsep><para>FOCUS_BLOCK_DESCENDANTS </para><simplesectsep></simplesectsep><para>onRequestFocusInDescendants(int, android.graphics.Rect) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>Whether this view or one of its descendants actually took focus.</para>
				/// </returns>
				/// <java-name>
				/// requestFocus
				/// </java-name>
				[Dot42.DexImport("requestFocus", "(ILandroid/graphics/Rect;)Z", AccessFlags = 1)]
				public override bool RequestFocus(int direction, global::Android.Graphics.Rect previouslyFocusedRect) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Measure the view and its content to determine the measured width and the measured height. This method is invoked by measure(int, int) and should be overriden by subclasses to provide accurate and efficient measurement of their contents. </para><para><b>CONTRACT:</b> When overriding this method, you <b>must</b> call setMeasuredDimension(int, int) to store the measured width and height of this view. Failure to do so will trigger an <code>IllegalStateException</code>, thrown by measure(int, int). Calling the superclass' onMeasure(int, int) is a valid use. </para><para>The base class implementation of measure defaults to the background size, unless a larger size is allowed by the MeasureSpec. Subclasses should override onMeasure(int, int) to provide better measurements of their content. </para><para>If this method is overridden, it is the subclass's responsibility to make sure the measured height and width are at least the view's minimum height and width (getSuggestedMinimumHeight() and getSuggestedMinimumWidth()). </para><para><para>getMeasuredWidth() </para><simplesectsep></simplesectsep><para>getMeasuredHeight() </para><simplesectsep></simplesectsep><para>setMeasuredDimension(int, int) </para><simplesectsep></simplesectsep><para>getSuggestedMinimumHeight() </para><simplesectsep></simplesectsep><para>getSuggestedMinimumWidth() </para><simplesectsep></simplesectsep><para>android.view.View.MeasureSpec::getMode(int) </para><simplesectsep></simplesectsep><para>android.view.View.MeasureSpec::getSize(int) </para></para>        
				/// </summary>
				/// <java-name>
				/// onMeasure
				/// </java-name>
				[Dot42.DexImport("onMeasure", "(II)V", AccessFlags = 4)]
				protected internal override void OnMeasure(int widthMeasureSpec, int heightMeasureSpec) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para><para><para>Called when a child of this group wants a particular rectangle to be positioned onto the screen. ViewGroups overriding this can trust that: <ul><li><para>child will be a direct child of this group </para></li><li><para>rectangle will be in the child's coordinates </para></li></ul></para><para>ViewGroups overriding this should uphold the contract:</para><para><ul><li><para>nothing will change if the rectangle is already visible </para></li><li><para>the view port will be scrolled only just enough to make the rectangle visible <ul><li></li></ul>child The direct child making the request. </para></li></ul></para></para> </para>        
				/// </summary>
				/// <returns>
				/// <para>Whether the group scrolled to handle the operation</para>
				/// </returns>
				/// <java-name>
				/// requestChildRectangleOnScreen
				/// </java-name>
				[Dot42.DexImport("requestChildRectangleOnScreen", "(Landroid/view/View;Landroid/graphics/Rect;Z)Z", AccessFlags = 1)]
				public override bool RequestChildRectangleOnScreen(global::Android.View.View child, global::Android.Graphics.Rect rectangle, bool immediate) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Sets the background color for this view. </para>        
				/// </summary>
				/// <java-name>
				/// setBackgroundColor
				/// </java-name>
				[Dot42.DexImport("setBackgroundColor", "(I)V", AccessFlags = 1)]
				public override void SetBackgroundColor(int color) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>This method is now obsolete.  Since API level android.os.Build.VERSION_CODES#JELLY_BEAN_MR1 </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// debugDump
				/// </java-name>
				[Dot42.DexImport("debugDump", "()V", AccessFlags = 1)]
				public virtual void DebugDump() /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal WebView() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Gets the visible height (in pixels) of the embedded title bar (if any).</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>This method is now obsolete.  Since API level android.os.Build.VERSION_CODES#JELLY_BEAN_MR1 </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// getVisibleTitleHeight
				/// </java-name>
				public int VisibleTitleHeight
				{
				[Dot42.DexImport("getVisibleTitleHeight", "()I", AccessFlags = 1)]
						get{ return GetVisibleTitleHeight(); }
				}

				/// <summary>
				/// <para>Gets the SSL certificate for the main top-level page or null if there is no certificate (the site is not secure).</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the SSL certificate for the main top-level page </para>
				/// </returns>
				/// <java-name>
				/// getCertificate
				/// </java-name>
				public global::Android.Net.Http.SslCertificate Certificate
				{
				[Dot42.DexImport("getCertificate", "()Landroid/net/http/SslCertificate;", AccessFlags = 1)]
						get{ return GetCertificate(); }
				[Dot42.DexImport("setCertificate", "(Landroid/net/http/SslCertificate;)V", AccessFlags = 1)]
						set{ SetCertificate(value); }
				}

				/// <summary>
				/// <para>Gets the current scale of this WebView.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>This method is prone to inaccuracy due to race conditions between the web rendering and UI threads; prefer WebViewClient#onScaleChanged. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				/// <para>the current scale</para>
				/// </returns>
				/// <java-name>
				/// getScale
				/// </java-name>
				public float Scale
				{
				[Dot42.DexImport("getScale", "()F", AccessFlags = 1)]
						get{ return GetScale(); }
				}

				/// <summary>
				/// <para>Gets the URL for the current page. This is not always the same as the URL passed to WebViewClient.onPageStarted because although the load for that URL has begun, the current page may not have changed.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the URL for the current page </para>
				/// </returns>
				/// <java-name>
				/// getUrl
				/// </java-name>
				public string Url
				{
				[Dot42.DexImport("getUrl", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetUrl(); }
				}

				/// <summary>
				/// <para>Gets the original URL for the current page. This is not always the same as the URL passed to WebViewClient.onPageStarted because although the load for that URL has begun, the current page may not have changed. Also, there may have been redirects resulting in a different URL to that originally requested.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the URL that was originally requested for the current page </para>
				/// </returns>
				/// <java-name>
				/// getOriginalUrl
				/// </java-name>
				public string OriginalUrl
				{
				[Dot42.DexImport("getOriginalUrl", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetOriginalUrl(); }
				}

				/// <summary>
				/// <para>Gets the title for the current page. This is the title of the current page until WebViewClient.onReceivedTitle is called.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the title for the current page </para>
				/// </returns>
				/// <java-name>
				/// getTitle
				/// </java-name>
				public string Title
				{
				[Dot42.DexImport("getTitle", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetTitle(); }
				}

				/// <summary>
				/// <para>Gets the favicon for the current page. This is the favicon of the current page until WebViewClient.onReceivedIcon is called.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the favicon for the current page </para>
				/// </returns>
				/// <java-name>
				/// getFavicon
				/// </java-name>
				public global::Android.Graphics.Bitmap Favicon
				{
				[Dot42.DexImport("getFavicon", "()Landroid/graphics/Bitmap;", AccessFlags = 1)]
						get{ return GetFavicon(); }
				}

				/// <summary>
				/// <para>Gets the progress for the current page.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the progress for the current page between 0 and 100 </para>
				/// </returns>
				/// <java-name>
				/// getProgress
				/// </java-name>
				public int Progress
				{
				[Dot42.DexImport("getProgress", "()I", AccessFlags = 1)]
						get{ return GetProgress(); }
				}

				/// <summary>
				/// <para>Gets the height of the HTML content.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the height of the HTML content </para>
				/// </returns>
				/// <java-name>
				/// getContentHeight
				/// </java-name>
				public int ContentHeight
				{
				[Dot42.DexImport("getContentHeight", "()I", AccessFlags = 1)]
						get{ return GetContentHeight(); }
				}

				/// <summary>
				/// <para>Gets the WebSettings object used to control the settings for this WebView.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a WebSettings object that can be used to control this WebView's settings </para>
				/// </returns>
				/// <java-name>
				/// getSettings
				/// </java-name>
				public global::Android.Webkit.WebSettings Settings
				{
				[Dot42.DexImport("getSettings", "()Landroid/webkit/WebSettings;", AccessFlags = 1)]
						get{ return GetSettings(); }
				}

				/// <summary>
				/// <para>Gets the zoom controls for this WebView, as a separate View. The caller is responsible for inserting this View into the layout hierarchy. </para><para>API level android.os.Build.VERSION_CODES#CUPCAKE introduced built-in zoom mechanisms for the WebView, as opposed to these separate zoom controls. The built-in mechanisms are preferred and can be enabled using WebSettings#setBuiltInZoomControls.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>the built-in zoom mechanisms are preferred  Since API level android.os.Build.VERSION_CODES#JELLY_BEAN </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// getZoomControls
				/// </java-name>
				public global::Android.View.View ZoomControls
				{
				[Dot42.DexImport("getZoomControls", "()Landroid/view/View;", AccessFlags = 1)]
						get{ return GetZoomControls(); }
				}

				/// <java-name>
				/// android/webkit/WebView$HitTestResult
				/// </java-name>
				[Dot42.DexImport("android/webkit/WebView$HitTestResult", AccessFlags = 1)]
				public partial class HitTestResult
 /* scope: __dot42__ */ 
				{
						/// <summary>
						/// <para>Default HitTestResult, where the target is unknown. </para>        
						/// </summary>
						/// <java-name>
						/// UNKNOWN_TYPE
						/// </java-name>
						[Dot42.DexImport("UNKNOWN_TYPE", "I", AccessFlags = 25)]
						public const int UNKNOWN_TYPE = 0;
						/// <summary>
						/// <para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>This type is no longer used. </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// ANCHOR_TYPE
						/// </java-name>
						[Dot42.DexImport("ANCHOR_TYPE", "I", AccessFlags = 25)]
						public const int ANCHOR_TYPE = 1;
						/// <summary>
						/// <para>HitTestResult for hitting a phone number. </para>        
						/// </summary>
						/// <java-name>
						/// PHONE_TYPE
						/// </java-name>
						[Dot42.DexImport("PHONE_TYPE", "I", AccessFlags = 25)]
						public const int PHONE_TYPE = 2;
						/// <summary>
						/// <para>HitTestResult for hitting a map address. </para>        
						/// </summary>
						/// <java-name>
						/// GEO_TYPE
						/// </java-name>
						[Dot42.DexImport("GEO_TYPE", "I", AccessFlags = 25)]
						public const int GEO_TYPE = 3;
						/// <summary>
						/// <para>HitTestResult for hitting an email address. </para>        
						/// </summary>
						/// <java-name>
						/// EMAIL_TYPE
						/// </java-name>
						[Dot42.DexImport("EMAIL_TYPE", "I", AccessFlags = 25)]
						public const int EMAIL_TYPE = 4;
						/// <summary>
						/// <para>HitTestResult for hitting an HTML::img tag. </para>        
						/// </summary>
						/// <java-name>
						/// IMAGE_TYPE
						/// </java-name>
						[Dot42.DexImport("IMAGE_TYPE", "I", AccessFlags = 25)]
						public const int IMAGE_TYPE = 5;
						/// <summary>
						/// <para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>This type is no longer used. </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// IMAGE_ANCHOR_TYPE
						/// </java-name>
						[Dot42.DexImport("IMAGE_ANCHOR_TYPE", "I", AccessFlags = 25)]
						public const int IMAGE_ANCHOR_TYPE = 6;
						/// <summary>
						/// <para>HitTestResult for hitting a HTML::a tag with src=http. </para>        
						/// </summary>
						/// <java-name>
						/// SRC_ANCHOR_TYPE
						/// </java-name>
						[Dot42.DexImport("SRC_ANCHOR_TYPE", "I", AccessFlags = 25)]
						public const int SRC_ANCHOR_TYPE = 7;
						/// <summary>
						/// <para>HitTestResult for hitting a HTML::a tag with src=http + HTML::img. </para>        
						/// </summary>
						/// <java-name>
						/// SRC_IMAGE_ANCHOR_TYPE
						/// </java-name>
						[Dot42.DexImport("SRC_IMAGE_ANCHOR_TYPE", "I", AccessFlags = 25)]
						public const int SRC_IMAGE_ANCHOR_TYPE = 8;
						/// <summary>
						/// <para>HitTestResult for hitting an edit text area. </para>        
						/// </summary>
						/// <java-name>
						/// EDIT_TEXT_TYPE
						/// </java-name>
						[Dot42.DexImport("EDIT_TEXT_TYPE", "I", AccessFlags = 25)]
						public const int EDIT_TEXT_TYPE = 9;
						/// <java-name>
						/// this$0
						/// </java-name>
						[Dot42.DexImport("this$0", "Landroid/webkit/WebView;", AccessFlags = 4112)]
						internal readonly global::Android.Webkit.WebView This_0;
						[Dot42.DexImport("<init>", "(Landroid/webkit/WebView;)V", AccessFlags = 0)]
						internal HitTestResult(global::Android.Webkit.WebView webView) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						/// <para>Gets the type of the hit test result. See the XXX_TYPE constants defined in this class.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>the type of the hit test result </para>
						/// </returns>
						/// <java-name>
						/// getType
						/// </java-name>
						[Dot42.DexImport("getType", "()I", AccessFlags = 1)]
						public new virtual int GetType() /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <summary>
						/// <para>Gets additional type-dependant information about the result. See WebView#getHitTestResult() for details. May either be null or contain extra information about this result.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>additional type-dependant information about the result </para>
						/// </returns>
						/// <java-name>
						/// getExtra
						/// </java-name>
						[Dot42.DexImport("getExtra", "()Ljava/lang/String;", AccessFlags = 1)]
						public virtual string GetExtra() /* MethodBuilder.Create */ 
						{
								return default(string);
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal HitTestResult() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

						/// <summary>
						/// <para>Gets the type of the hit test result. See the XXX_TYPE constants defined in this class.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>the type of the hit test result </para>
						/// </returns>
						/// <java-name>
						/// getType
						/// </java-name>
						public int Type
						{
						[Dot42.DexImport("getType", "()I", AccessFlags = 1)]
								get{ return GetType(); }
						}

						/// <summary>
						/// <para>Gets additional type-dependant information about the result. See WebView#getHitTestResult() for details. May either be null or contain extra information about this result.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>additional type-dependant information about the result </para>
						/// </returns>
						/// <java-name>
						/// getExtra
						/// </java-name>
						public string Extra
						{
						[Dot42.DexImport("getExtra", "()Ljava/lang/String;", AccessFlags = 1)]
								get{ return GetExtra(); }
						}

				}

				/// <summary>
				/// <para>Interface to listen for new pictures as they change.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>This interface is now obsolete. </para></xrefdescription></xrefsect></para>    
				/// </summary>
				/// <java-name>
				/// android/webkit/WebView$PictureListener
				/// </java-name>
				[Dot42.DexImport("android/webkit/WebView$PictureListener", AccessFlags = 1545)]
				public partial interface IPictureListener
 /* scope: __dot42__ */ 
				{
						/// <summary>
						/// <para>Used to provide notification that the WebView's picture has changed. See WebView#capturePicture for details of the picture.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>Deprecated due to internal changes. </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// onNewPicture
						/// </java-name>
						[Dot42.DexImport("onNewPicture", "(Landroid/webkit/WebView;Landroid/graphics/Picture;)V", AccessFlags = 1025)]
						void OnNewPicture(global::Android.Webkit.WebView view, global::Android.Graphics.Picture picture) /* MethodBuilder.Create */ ;

				}

				/// <summary>
				/// <para>Transportation object for returning WebView across thread boundaries. </para>    
				/// </summary>
				/// <java-name>
				/// android/webkit/WebView$WebViewTransport
				/// </java-name>
				[Dot42.DexImport("android/webkit/WebView$WebViewTransport", AccessFlags = 1)]
				public partial class WebViewTransport
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// this$0
						/// </java-name>
						[Dot42.DexImport("this$0", "Landroid/webkit/WebView;", AccessFlags = 4112)]
						internal readonly global::Android.Webkit.WebView This_0;
						[Dot42.DexImport("<init>", "(Landroid/webkit/WebView;)V", AccessFlags = 1)]
						public WebViewTransport(global::Android.Webkit.WebView webView) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						/// <para>Sets the WebView to the transportation object.</para><para></para>        
						/// </summary>
						/// <java-name>
						/// setWebView
						/// </java-name>
						[Dot42.DexImport("setWebView", "(Landroid/webkit/WebView;)V", AccessFlags = 33)]
						public virtual void SetWebView(global::Android.Webkit.WebView webview) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						/// <para>Gets the WebView object.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>the transported WebView object </para>
						/// </returns>
						/// <java-name>
						/// getWebView
						/// </java-name>
						[Dot42.DexImport("getWebView", "()Landroid/webkit/WebView;", AccessFlags = 33)]
						public virtual global::Android.Webkit.WebView GetWebView() /* MethodBuilder.Create */ 
						{
								return default(global::Android.Webkit.WebView);
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal WebViewTransport() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

						/// <summary>
						/// <para>Gets the WebView object.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>the transported WebView object </para>
						/// </returns>
						/// <java-name>
						/// getWebView
						/// </java-name>
						public global::Android.Webkit.WebView WebView
						{
						[Dot42.DexImport("getWebView", "()Landroid/webkit/WebView;", AccessFlags = 33)]
								get{ return GetWebView(); }
						[Dot42.DexImport("setWebView", "(Landroid/webkit/WebView;)V", AccessFlags = 33)]
								set{ SetWebView(value); }
						}

				}

		}

		/// <summary>
		/// <para>Functions for manipulating the icon database used by WebView. These functions require that a WebView be constructed before being invoked and WebView.getIconDatabase() will return a WebIconDatabase object. This WebIconDatabase object is a single instance and all methods operate on that single object. The main use-case for this class is calling open to enable favicon functionality on all WebView instances in this process.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>This class is only required when running on devices up to android.os.Build.VERSION_CODES#JELLY_BEAN_MR2 </para></xrefdescription></xrefsect></para>    
		/// </summary>
		/// <java-name>
		/// android/webkit/WebIconDatabase
		/// </java-name>
		[Dot42.DexImport("android/webkit/WebIconDatabase", AccessFlags = 49)]
		public sealed partial class WebIconDatabase
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Only for use by WebViewProvider implementations </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal WebIconDatabase() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Open a the icon database and store the icons in the given path. </para>        
				/// </summary>
				/// <java-name>
				/// open
				/// </java-name>
				[Dot42.DexImport("open", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public void Open(string path) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Close the shared instance of the icon database. </para>        
				/// </summary>
				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1)]
				public void Close() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Removes all the icons in the database. </para>        
				/// </summary>
				/// <java-name>
				/// removeAllIcons
				/// </java-name>
				[Dot42.DexImport("removeAllIcons", "()V", AccessFlags = 1)]
				public void RemoveAllIcons() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Request the Bitmap representing the icon for the given page url. If the icon exists, the listener will be called with the result. </para>        
				/// </summary>
				/// <java-name>
				/// requestIconForPageUrl
				/// </java-name>
				[Dot42.DexImport("requestIconForPageUrl", "(Ljava/lang/String;Landroid/webkit/WebIconDatabase$IconListener;)V", AccessFlags = 1)]
				public void RequestIconForPageUrl(string url, global::Android.Webkit.WebIconDatabase.IIconListener listener) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Retain the icon for the given page url. </para>        
				/// </summary>
				/// <java-name>
				/// retainIconForPageUrl
				/// </java-name>
				[Dot42.DexImport("retainIconForPageUrl", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public void RetainIconForPageUrl(string url) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Release the icon for the given page url. </para>        
				/// </summary>
				/// <java-name>
				/// releaseIconForPageUrl
				/// </java-name>
				[Dot42.DexImport("releaseIconForPageUrl", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public void ReleaseIconForPageUrl(string url) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Get the global instance of WebIconDatabase. </para>        
				/// </summary>
				/// <returns>
				/// <para>A single instance of WebIconDatabase. It will be the same instance for the current process each time this method is called. </para>
				/// </returns>
				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "()Landroid/webkit/WebIconDatabase;", AccessFlags = 9)]
				public static global::Android.Webkit.WebIconDatabase GetInstance() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Webkit.WebIconDatabase);
				}

				/// <summary>
				/// <para>Get the global instance of WebIconDatabase. </para>        
				/// </summary>
				/// <returns>
				/// <para>A single instance of WebIconDatabase. It will be the same instance for the current process each time this method is called. </para>
				/// </returns>
				/// <java-name>
				/// getInstance
				/// </java-name>
				public static global::Android.Webkit.WebIconDatabase Instance
				{
				[Dot42.DexImport("getInstance", "()Landroid/webkit/WebIconDatabase;", AccessFlags = 9)]
						get{ return GetInstance(); }
				}

				/// <summary>
				/// <para>Interface for receiving icons from the database. <xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>This interface is obsolete. </para></xrefdescription></xrefsect></para>    
				/// </summary>
				/// <java-name>
				/// android/webkit/WebIconDatabase$IconListener
				/// </java-name>
				[Dot42.DexImport("android/webkit/WebIconDatabase$IconListener", AccessFlags = 1545)]
				public partial interface IIconListener
 /* scope: __dot42__ */ 
				{
						/// <summary>
						/// <para>Called when the icon has been retrieved from the database and the result is non-null. </para>        
						/// </summary>
						/// <java-name>
						/// onReceivedIcon
						/// </java-name>
						[Dot42.DexImport("onReceivedIcon", "(Ljava/lang/String;Landroid/graphics/Bitmap;)V", AccessFlags = 1025)]
						void OnReceivedIcon(string url, global::Android.Graphics.Bitmap icon) /* MethodBuilder.Create */ ;

				}

		}

		/// <summary>
		/// <para>Two-way map that maps MIME-types to file extensions and vice versa.</para><para>See also java.net.URLConnection#guessContentTypeFromName and java.net.URLConnection#guessContentTypeFromStream. This class and <c> URLConnection </c> share the same MIME-type database. </para>    
		/// </summary>
		/// <java-name>
		/// android/webkit/MimeTypeMap
		/// </java-name>
		[Dot42.DexImport("android/webkit/MimeTypeMap", AccessFlags = 33)]
		public partial class MimeTypeMap
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal MimeTypeMap() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the file extension or an empty string iff there is no extension. This method is a convenience method for obtaining the extension of a url and has undefined results for other Strings. </para>        
				/// </summary>
				/// <returns>
				/// <para>The file extension of the given url. </para>
				/// </returns>
				/// <java-name>
				/// getFileExtensionFromUrl
				/// </java-name>
				[Dot42.DexImport("getFileExtensionFromUrl", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 9)]
				public static string GetFileExtensionFromUrl(string url) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Return true if the given MIME type has an entry in the map. </para>        
				/// </summary>
				/// <returns>
				/// <para>True iff there is a mimeType entry in the map. </para>
				/// </returns>
				/// <java-name>
				/// hasMimeType
				/// </java-name>
				[Dot42.DexImport("hasMimeType", "(Ljava/lang/String;)Z", AccessFlags = 1)]
				public virtual bool HasMimeType(string mimeType) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Return the MIME type for the given extension. </para>        
				/// </summary>
				/// <returns>
				/// <para>The MIME type for the given extension or null iff there is none. </para>
				/// </returns>
				/// <java-name>
				/// getMimeTypeFromExtension
				/// </java-name>
				[Dot42.DexImport("getMimeTypeFromExtension", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetMimeTypeFromExtension(string extension) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Return true if the given extension has a registered MIME type. </para>        
				/// </summary>
				/// <returns>
				/// <para>True iff there is an extension entry in the map. </para>
				/// </returns>
				/// <java-name>
				/// hasExtension
				/// </java-name>
				[Dot42.DexImport("hasExtension", "(Ljava/lang/String;)Z", AccessFlags = 1)]
				public virtual bool HasExtension(string extension) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Return the registered extension for the given MIME type. Note that some MIME types map to multiple extensions. This call will return the most common extension for the given MIME type. </para>        
				/// </summary>
				/// <returns>
				/// <para>The extension for the given MIME type or null iff there is none. </para>
				/// </returns>
				/// <java-name>
				/// getExtensionFromMimeType
				/// </java-name>
				[Dot42.DexImport("getExtensionFromMimeType", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetExtensionFromMimeType(string mimeType) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Get the singleton instance of MimeTypeMap. </para>        
				/// </summary>
				/// <returns>
				/// <para>The singleton instance of the MIME-type map. </para>
				/// </returns>
				/// <java-name>
				/// getSingleton
				/// </java-name>
				[Dot42.DexImport("getSingleton", "()Landroid/webkit/MimeTypeMap;", AccessFlags = 9)]
				public static global::Android.Webkit.MimeTypeMap GetSingleton() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Webkit.MimeTypeMap);
				}

				/// <summary>
				/// <para>Get the singleton instance of MimeTypeMap. </para>        
				/// </summary>
				/// <returns>
				/// <para>The singleton instance of the MIME-type map. </para>
				/// </returns>
				/// <java-name>
				/// getSingleton
				/// </java-name>
				public static global::Android.Webkit.MimeTypeMap Singleton
				{
				[Dot42.DexImport("getSingleton", "()Landroid/webkit/MimeTypeMap;", AccessFlags = 9)]
						get{ return GetSingleton(); }
				}

		}

}


