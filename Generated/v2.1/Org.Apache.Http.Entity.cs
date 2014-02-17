// Copyright (C) 2014 dot42
//
// Original filename: Org.Apache.Http.Entity.cs
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
namespace Org.Apache.Http.Entity
{
		/// <summary>
		/// <para>Entity that delegates the process of content generation to an abstract content producer.</para><para><para></para><para></para><title>Revision:</title><para>496070 </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/entity/EntityTemplate
		/// </java-name>
		[Dot42.DexImport("org/apache/http/entity/EntityTemplate", AccessFlags = 33)]
		public partial class EntityTemplate : global::Org.Apache.Http.Entity.AbstractHttpEntity
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Lorg/apache/http/entity/ContentProducer;)V", AccessFlags = 1)]
				public EntityTemplate(global::Org.Apache.Http.Entity.IContentProducer contentproducer) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Tells the length of the content, if known.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of bytes of the content, or a negative number if unknown. If the content length is known but exceeds Long.MAX_VALUE, a negative number is returned. </para>
				/// </returns>
				/// <java-name>
				/// getContentLength
				/// </java-name>
				[Dot42.DexImport("getContentLength", "()J", AccessFlags = 1)]
				public override long GetContentLength() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>Creates a new InputStream object of the entity. It is a programming error to return the same InputStream object more than once. Entities that are not repeatable will throw an exception if this method is called multiple times.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a new input stream that returns the entity data.</para>
				/// </returns>
				/// <java-name>
				/// getContent
				/// </java-name>
				[Dot42.DexImport("getContent", "()Ljava/io/InputStream;", AccessFlags = 1)]
				public override global::Java.Io.InputStream GetContent() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.InputStream);
				}

				/// <summary>
				/// <para>Tells if the entity is capable to produce its data more than once. A repeatable entity's getContent() and writeTo(OutputStream) methods can be called more than once whereas a non-repeatable entity's can not. </para>        
				/// </summary>
				/// <returns>
				/// <para>true if the entity is repeatable, false otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isRepeatable
				/// </java-name>
				[Dot42.DexImport("isRepeatable", "()Z", AccessFlags = 1)]
				public override bool IsRepeatable() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// writeTo
				/// </java-name>
				[Dot42.DexImport("writeTo", "(Ljava/io/OutputStream;)V", AccessFlags = 1)]
				public override void WriteTo(global::Java.Io.OutputStream outstream) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Tells whether this entity depends on an underlying stream. Streamed entities should return <code>true</code> until the content has been consumed, <code>false</code> afterwards. Self-contained entities should return <code>false</code>. Wrapping entities should delegate this call to the wrapped entity. <br></br> The content of a streamed entity is consumed when the stream returned by getContent has been read to EOF, or after consumeContent has been called. If a streamed entity can not detect whether the stream has been read to EOF, it should return <code>true</code> until consumeContent is called.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> if the entity content is streamed and not yet consumed, <code>false</code> otherwise </para>
				/// </returns>
				/// <java-name>
				/// isStreaming
				/// </java-name>
				[Dot42.DexImport("isStreaming", "()Z", AccessFlags = 1)]
				public override bool IsStreaming() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Does not consume anything. The default implementation does nothing if isStreaming returns <code>false</code>, and throws an exception if it returns <code>true</code>. This removes the burden of implementing an empty method for non-streaming entities.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// consumeContent
				/// </java-name>
				[Dot42.DexImport("consumeContent", "()V", AccessFlags = 1)]
				public override void ConsumeContent() /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal EntityTemplate() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Tells the length of the content, if known.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of bytes of the content, or a negative number if unknown. If the content length is known but exceeds Long.MAX_VALUE, a negative number is returned. </para>
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
				/// <para>Creates a new InputStream object of the entity. It is a programming error to return the same InputStream object more than once. Entities that are not repeatable will throw an exception if this method is called multiple times.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a new input stream that returns the entity data.</para>
				/// </returns>
				/// <java-name>
				/// getContent
				/// </java-name>
				public global::Java.Io.InputStream Content
				{
				[Dot42.DexImport("getContent", "()Ljava/io/InputStream;", AccessFlags = 1)]
						get{ return GetContent(); }
				}

		}

		/// <summary>
		/// <para>Base class for wrapping entities. Keeps a wrappedEntity and delegates all calls to it. Implementations of wrapping entities can derive from this class and need to override only those methods that should not be delegated to the wrapped entity.</para><para><para></para><title>Revision:</title><para>496070 </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/entity/HttpEntityWrapper
		/// </java-name>
		[Dot42.DexImport("org/apache/http/entity/HttpEntityWrapper", AccessFlags = 33)]
		public partial class HttpEntityWrapper : global::Org.Apache.Http.IHttpEntity
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>The wrapped entity. </para>        
				/// </summary>
				/// <java-name>
				/// wrappedEntity
				/// </java-name>
				[Dot42.DexImport("wrappedEntity", "Lorg/apache/http/HttpEntity;", AccessFlags = 4)]
				protected internal global::Org.Apache.Http.IHttpEntity WrappedEntity;
				/// <summary>
				/// <para>Creates a new entity wrapper.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Lorg/apache/http/HttpEntity;)V", AccessFlags = 1)]
				public HttpEntityWrapper(global::Org.Apache.Http.IHttpEntity wrapped) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Tells if the entity is capable to produce its data more than once. A repeatable entity's getContent() and writeTo(OutputStream) methods can be called more than once whereas a non-repeatable entity's can not. </para>        
				/// </summary>
				/// <returns>
				/// <para>true if the entity is repeatable, false otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isRepeatable
				/// </java-name>
				[Dot42.DexImport("isRepeatable", "()Z", AccessFlags = 1)]
				public virtual bool IsRepeatable() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Tells about chunked encoding for this entity. The primary purpose of this method is to indicate whether chunked encoding should be used when the entity is sent. For entities that are received, it can also indicate whether the entity was received with chunked encoding. <br></br> The behavior of wrapping entities is implementation dependent, but should respect the primary purpose.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> if chunked encoding is preferred for this entity, or <code>false</code> if it is not </para>
				/// </returns>
				/// <java-name>
				/// isChunked
				/// </java-name>
				[Dot42.DexImport("isChunked", "()Z", AccessFlags = 1)]
				public virtual bool IsChunked() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Tells the length of the content, if known.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of bytes of the content, or a negative number if unknown. If the content length is known but exceeds Long.MAX_VALUE, a negative number is returned. </para>
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
				/// <para>Obtains the Content-Type header, if known. This is the header that should be used when sending the entity, or the one that was received with the entity. It can include a charset attribute.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the Content-Type header for this entity, or <code>null</code> if the content type is unknown </para>
				/// </returns>
				/// <java-name>
				/// getContentType
				/// </java-name>
				[Dot42.DexImport("getContentType", "()Lorg/apache/http/Header;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.IHeader GetContentType() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IHeader);
				}

				/// <summary>
				/// <para>Obtains the Content-Encoding header, if known. This is the header that should be used when sending the entity, or the one that was received with the entity. Wrapping entities that modify the content encoding should adjust this header accordingly.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the Content-Encoding header for this entity, or <code>null</code> if the content encoding is unknown </para>
				/// </returns>
				/// <java-name>
				/// getContentEncoding
				/// </java-name>
				[Dot42.DexImport("getContentEncoding", "()Lorg/apache/http/Header;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.IHeader GetContentEncoding() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IHeader);
				}

				/// <summary>
				/// <para>Creates a new InputStream object of the entity. It is a programming error to return the same InputStream object more than once. Entities that are not repeatable will throw an exception if this method is called multiple times.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a new input stream that returns the entity data.</para>
				/// </returns>
				/// <java-name>
				/// getContent
				/// </java-name>
				[Dot42.DexImport("getContent", "()Ljava/io/InputStream;", AccessFlags = 1)]
				public virtual global::Java.Io.InputStream GetContent() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.InputStream);
				}

				/// <summary>
				/// <para>Writes the entity content to the output stream.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// writeTo
				/// </java-name>
				[Dot42.DexImport("writeTo", "(Ljava/io/OutputStream;)V", AccessFlags = 1)]
				public virtual void WriteTo(global::Java.Io.OutputStream outstream) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Tells whether this entity depends on an underlying stream. Streamed entities should return <code>true</code> until the content has been consumed, <code>false</code> afterwards. Self-contained entities should return <code>false</code>. Wrapping entities should delegate this call to the wrapped entity. <br></br> The content of a streamed entity is consumed when the stream returned by getContent has been read to EOF, or after consumeContent has been called. If a streamed entity can not detect whether the stream has been read to EOF, it should return <code>true</code> until consumeContent is called.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> if the entity content is streamed and not yet consumed, <code>false</code> otherwise </para>
				/// </returns>
				/// <java-name>
				/// isStreaming
				/// </java-name>
				[Dot42.DexImport("isStreaming", "()Z", AccessFlags = 1)]
				public virtual bool IsStreaming() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>TODO: The name of this method is misnomer. It will be renamed to #finish() in the next major release. <br></br> This method is called to indicate that the content of this entity is no longer required. All entity implementations are expected to release all allocated resources as a result of this method invocation. Content streaming entities are also expected to dispose of the remaining content, if any. Wrapping entities should delegate this call to the wrapped entity. <br></br> This method is of particular importance for entities being received from a connection. The entity needs to be consumed completely in order to re-use the connection with keep-alive.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// consumeContent
				/// </java-name>
				[Dot42.DexImport("consumeContent", "()V", AccessFlags = 1)]
				public virtual void ConsumeContent() /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal HttpEntityWrapper() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Tells the length of the content, if known.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of bytes of the content, or a negative number if unknown. If the content length is known but exceeds Long.MAX_VALUE, a negative number is returned. </para>
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
				/// <para>Obtains the Content-Type header, if known. This is the header that should be used when sending the entity, or the one that was received with the entity. It can include a charset attribute.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the Content-Type header for this entity, or <code>null</code> if the content type is unknown </para>
				/// </returns>
				/// <java-name>
				/// getContentType
				/// </java-name>
				public global::Org.Apache.Http.IHeader ContentType
				{
				[Dot42.DexImport("getContentType", "()Lorg/apache/http/Header;", AccessFlags = 1)]
						get{ return GetContentType(); }
				}

				/// <summary>
				/// <para>Obtains the Content-Encoding header, if known. This is the header that should be used when sending the entity, or the one that was received with the entity. Wrapping entities that modify the content encoding should adjust this header accordingly.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the Content-Encoding header for this entity, or <code>null</code> if the content encoding is unknown </para>
				/// </returns>
				/// <java-name>
				/// getContentEncoding
				/// </java-name>
				public global::Org.Apache.Http.IHeader ContentEncoding
				{
				[Dot42.DexImport("getContentEncoding", "()Lorg/apache/http/Header;", AccessFlags = 1)]
						get{ return GetContentEncoding(); }
				}

				/// <summary>
				/// <para>Creates a new InputStream object of the entity. It is a programming error to return the same InputStream object more than once. Entities that are not repeatable will throw an exception if this method is called multiple times.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a new input stream that returns the entity data.</para>
				/// </returns>
				/// <java-name>
				/// getContent
				/// </java-name>
				public global::Java.Io.InputStream Content
				{
				[Dot42.DexImport("getContent", "()Ljava/io/InputStream;", AccessFlags = 1)]
						get{ return GetContent(); }
				}

		}

		/// <summary>
		/// <para>A generic streamed entity being received on a connection.</para><para><para></para><para></para><title>Revision:</title><para>496070 </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/entity/BasicHttpEntity
		/// </java-name>
		[Dot42.DexImport("org/apache/http/entity/BasicHttpEntity", AccessFlags = 33)]
		public partial class BasicHttpEntity : global::Org.Apache.Http.Entity.AbstractHttpEntity
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new basic entity. The content is initially missing, the content length is set to a negative number. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public BasicHttpEntity() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Tells the length of the content, if known.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of bytes of the content, or a negative number if unknown. If the content length is known but exceeds Long.MAX_VALUE, a negative number is returned. </para>
				/// </returns>
				/// <java-name>
				/// getContentLength
				/// </java-name>
				[Dot42.DexImport("getContentLength", "()J", AccessFlags = 1)]
				public override long GetContentLength() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>Obtains the content, once only.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the content, if this is the first call to this method since setContent has been called</para>
				/// </returns>
				/// <java-name>
				/// getContent
				/// </java-name>
				[Dot42.DexImport("getContent", "()Ljava/io/InputStream;", AccessFlags = 1)]
				public override global::Java.Io.InputStream GetContent() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.InputStream);
				}

				/// <summary>
				/// <para>Tells that this entity is not repeatable.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>false</code> </para>
				/// </returns>
				/// <java-name>
				/// isRepeatable
				/// </java-name>
				[Dot42.DexImport("isRepeatable", "()Z", AccessFlags = 1)]
				public override bool IsRepeatable() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Specifies the length of the content.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setContentLength
				/// </java-name>
				[Dot42.DexImport("setContentLength", "(J)V", AccessFlags = 1)]
				public virtual void SetContentLength(long len) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Specifies the content.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setContent
				/// </java-name>
				[Dot42.DexImport("setContent", "(Ljava/io/InputStream;)V", AccessFlags = 1)]
				public virtual void SetContent(global::Java.Io.InputStream instream) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writeTo
				/// </java-name>
				[Dot42.DexImport("writeTo", "(Ljava/io/OutputStream;)V", AccessFlags = 1)]
				public override void WriteTo(global::Java.Io.OutputStream outstream) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Tells whether this entity depends on an underlying stream. Streamed entities should return <code>true</code> until the content has been consumed, <code>false</code> afterwards. Self-contained entities should return <code>false</code>. Wrapping entities should delegate this call to the wrapped entity. <br></br> The content of a streamed entity is consumed when the stream returned by getContent has been read to EOF, or after consumeContent has been called. If a streamed entity can not detect whether the stream has been read to EOF, it should return <code>true</code> until consumeContent is called.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> if the entity content is streamed and not yet consumed, <code>false</code> otherwise </para>
				/// </returns>
				/// <java-name>
				/// isStreaming
				/// </java-name>
				[Dot42.DexImport("isStreaming", "()Z", AccessFlags = 1)]
				public override bool IsStreaming() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Does not consume anything. The default implementation does nothing if isStreaming returns <code>false</code>, and throws an exception if it returns <code>true</code>. This removes the burden of implementing an empty method for non-streaming entities.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// consumeContent
				/// </java-name>
				[Dot42.DexImport("consumeContent", "()V", AccessFlags = 1)]
				public override void ConsumeContent() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Tells the length of the content, if known.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of bytes of the content, or a negative number if unknown. If the content length is known but exceeds Long.MAX_VALUE, a negative number is returned. </para>
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
				/// <para>Obtains the content, once only.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the content, if this is the first call to this method since setContent has been called</para>
				/// </returns>
				/// <java-name>
				/// getContent
				/// </java-name>
				public global::Java.Io.InputStream Content
				{
				[Dot42.DexImport("getContent", "()Ljava/io/InputStream;", AccessFlags = 1)]
						get{ return GetContent(); }
				}

		}

		/// <summary>
		/// <para>An entity whose content is retrieved from a byte array.</para><para><para></para><para></para><title>Revision:</title><para>604625 </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/entity/ByteArrayEntity
		/// </java-name>
		[Dot42.DexImport("org/apache/http/entity/ByteArrayEntity", AccessFlags = 33)]
		public partial class ByteArrayEntity : global::Org.Apache.Http.Entity.AbstractHttpEntity, global::Java.Lang.ICloneable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// content
				/// </java-name>
				[Dot42.DexImport("content", "[B", AccessFlags = 20)]
				protected internal readonly sbyte[] Content;
				[Dot42.DexImport("<init>", "([B)V", AccessFlags = 1)]
				public ByteArrayEntity(sbyte[] b) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "([B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public ByteArrayEntity(byte[] b) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Tells if the entity is capable to produce its data more than once. A repeatable entity's getContent() and writeTo(OutputStream) methods can be called more than once whereas a non-repeatable entity's can not. </para>        
				/// </summary>
				/// <returns>
				/// <para>true if the entity is repeatable, false otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isRepeatable
				/// </java-name>
				[Dot42.DexImport("isRepeatable", "()Z", AccessFlags = 1)]
				public override bool IsRepeatable() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Tells the length of the content, if known.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of bytes of the content, or a negative number if unknown. If the content length is known but exceeds Long.MAX_VALUE, a negative number is returned. </para>
				/// </returns>
				/// <java-name>
				/// getContentLength
				/// </java-name>
				[Dot42.DexImport("getContentLength", "()J", AccessFlags = 1)]
				public override long GetContentLength() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>Creates a new InputStream object of the entity. It is a programming error to return the same InputStream object more than once. Entities that are not repeatable will throw an exception if this method is called multiple times.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a new input stream that returns the entity data.</para>
				/// </returns>
				/// <java-name>
				/// getContent
				/// </java-name>
				[Dot42.DexImport("getContent", "()Ljava/io/InputStream;", AccessFlags = 1)]
				public override global::Java.Io.InputStream GetContent() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.InputStream);
				}

				/// <java-name>
				/// writeTo
				/// </java-name>
				[Dot42.DexImport("writeTo", "(Ljava/io/OutputStream;)V", AccessFlags = 1)]
				public override void WriteTo(global::Java.Io.OutputStream outstream) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Tells that this entity is not streaming.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>false</code> </para>
				/// </returns>
				/// <java-name>
				/// isStreaming
				/// </java-name>
				[Dot42.DexImport("isStreaming", "()Z", AccessFlags = 1)]
				public override bool IsStreaming() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/lang/Object;", AccessFlags = 1)]
				public virtual object Clone() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ByteArrayEntity() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Tells the length of the content, if known.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of bytes of the content, or a negative number if unknown. If the content length is known but exceeds Long.MAX_VALUE, a negative number is returned. </para>
				/// </returns>
				/// <java-name>
				/// getContentLength
				/// </java-name>
				public long ContentLength
				{
				[Dot42.DexImport("getContentLength", "()J", AccessFlags = 1)]
						get{ return GetContentLength(); }
				}

		}

		/// <summary>
		/// <para>A wrapping entity that buffers it content if necessary. The buffered entity is always repeatable. If the wrapped entity is repeatable itself, calls are passed through. If the wrapped entity is not repeatable, the content is read into a buffer once and provided from there as often as required.</para><para><para></para><para></para><title>Revision:</title><para>496070 </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/entity/BufferedHttpEntity
		/// </java-name>
		[Dot42.DexImport("org/apache/http/entity/BufferedHttpEntity", AccessFlags = 33)]
		public partial class BufferedHttpEntity : global::Org.Apache.Http.Entity.HttpEntityWrapper
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Lorg/apache/http/HttpEntity;)V", AccessFlags = 1)]
				public BufferedHttpEntity(global::Org.Apache.Http.IHttpEntity entity) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Tells the length of the content, if known.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of bytes of the content, or a negative number if unknown. If the content length is known but exceeds Long.MAX_VALUE, a negative number is returned. </para>
				/// </returns>
				/// <java-name>
				/// getContentLength
				/// </java-name>
				[Dot42.DexImport("getContentLength", "()J", AccessFlags = 1)]
				public override long GetContentLength() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>Creates a new InputStream object of the entity. It is a programming error to return the same InputStream object more than once. Entities that are not repeatable will throw an exception if this method is called multiple times.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a new input stream that returns the entity data.</para>
				/// </returns>
				/// <java-name>
				/// getContent
				/// </java-name>
				[Dot42.DexImport("getContent", "()Ljava/io/InputStream;", AccessFlags = 1)]
				public override global::Java.Io.InputStream GetContent() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.InputStream);
				}

				/// <summary>
				/// <para>Tells that this entity does not have to be chunked.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>false</code> </para>
				/// </returns>
				/// <java-name>
				/// isChunked
				/// </java-name>
				[Dot42.DexImport("isChunked", "()Z", AccessFlags = 1)]
				public override bool IsChunked() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Tells that this entity is repeatable.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> </para>
				/// </returns>
				/// <java-name>
				/// isRepeatable
				/// </java-name>
				[Dot42.DexImport("isRepeatable", "()Z", AccessFlags = 1)]
				public override bool IsRepeatable() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// writeTo
				/// </java-name>
				[Dot42.DexImport("writeTo", "(Ljava/io/OutputStream;)V", AccessFlags = 1)]
				public override void WriteTo(global::Java.Io.OutputStream outstream) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Tells whether this entity depends on an underlying stream. Streamed entities should return <code>true</code> until the content has been consumed, <code>false</code> afterwards. Self-contained entities should return <code>false</code>. Wrapping entities should delegate this call to the wrapped entity. <br></br> The content of a streamed entity is consumed when the stream returned by getContent has been read to EOF, or after consumeContent has been called. If a streamed entity can not detect whether the stream has been read to EOF, it should return <code>true</code> until consumeContent is called.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> if the entity content is streamed and not yet consumed, <code>false</code> otherwise </para>
				/// </returns>
				/// <java-name>
				/// isStreaming
				/// </java-name>
				[Dot42.DexImport("isStreaming", "()Z", AccessFlags = 1)]
				public override bool IsStreaming() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal BufferedHttpEntity() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Tells the length of the content, if known.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of bytes of the content, or a negative number if unknown. If the content length is known but exceeds Long.MAX_VALUE, a negative number is returned. </para>
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
				/// <para>Creates a new InputStream object of the entity. It is a programming error to return the same InputStream object more than once. Entities that are not repeatable will throw an exception if this method is called multiple times.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a new input stream that returns the entity data.</para>
				/// </returns>
				/// <java-name>
				/// getContent
				/// </java-name>
				public global::Java.Io.InputStream Content
				{
				[Dot42.DexImport("getContent", "()Ljava/io/InputStream;", AccessFlags = 1)]
						get{ return GetContent(); }
				}

		}

		/// <java-name>
		/// org/apache/http/entity/SerializableEntity
		/// </java-name>
		[Dot42.DexImport("org/apache/http/entity/SerializableEntity", AccessFlags = 33)]
		public partial class SerializableEntity : global::Org.Apache.Http.Entity.AbstractHttpEntity
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/io/Serializable;Z)V", AccessFlags = 1)]
				public SerializableEntity(global::Java.Io.ISerializable ser, bool bufferize) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new InputStream object of the entity. It is a programming error to return the same InputStream object more than once. Entities that are not repeatable will throw an exception if this method is called multiple times.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a new input stream that returns the entity data.</para>
				/// </returns>
				/// <java-name>
				/// getContent
				/// </java-name>
				[Dot42.DexImport("getContent", "()Ljava/io/InputStream;", AccessFlags = 1)]
				public override global::Java.Io.InputStream GetContent() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.InputStream);
				}

				/// <summary>
				/// <para>Tells the length of the content, if known.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of bytes of the content, or a negative number if unknown. If the content length is known but exceeds Long.MAX_VALUE, a negative number is returned. </para>
				/// </returns>
				/// <java-name>
				/// getContentLength
				/// </java-name>
				[Dot42.DexImport("getContentLength", "()J", AccessFlags = 1)]
				public override long GetContentLength() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>Tells if the entity is capable to produce its data more than once. A repeatable entity's getContent() and writeTo(OutputStream) methods can be called more than once whereas a non-repeatable entity's can not. </para>        
				/// </summary>
				/// <returns>
				/// <para>true if the entity is repeatable, false otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isRepeatable
				/// </java-name>
				[Dot42.DexImport("isRepeatable", "()Z", AccessFlags = 1)]
				public override bool IsRepeatable() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Tells whether this entity depends on an underlying stream. Streamed entities should return <code>true</code> until the content has been consumed, <code>false</code> afterwards. Self-contained entities should return <code>false</code>. Wrapping entities should delegate this call to the wrapped entity. <br></br> The content of a streamed entity is consumed when the stream returned by getContent has been read to EOF, or after consumeContent has been called. If a streamed entity can not detect whether the stream has been read to EOF, it should return <code>true</code> until consumeContent is called.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> if the entity content is streamed and not yet consumed, <code>false</code> otherwise </para>
				/// </returns>
				/// <java-name>
				/// isStreaming
				/// </java-name>
				[Dot42.DexImport("isStreaming", "()Z", AccessFlags = 1)]
				public override bool IsStreaming() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Writes the entity content to the output stream.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// writeTo
				/// </java-name>
				[Dot42.DexImport("writeTo", "(Ljava/io/OutputStream;)V", AccessFlags = 1)]
				public override void WriteTo(global::Java.Io.OutputStream outstream) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal SerializableEntity() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Creates a new InputStream object of the entity. It is a programming error to return the same InputStream object more than once. Entities that are not repeatable will throw an exception if this method is called multiple times.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a new input stream that returns the entity data.</para>
				/// </returns>
				/// <java-name>
				/// getContent
				/// </java-name>
				public global::Java.Io.InputStream Content
				{
				[Dot42.DexImport("getContent", "()Ljava/io/InputStream;", AccessFlags = 1)]
						get{ return GetContent(); }
				}

				/// <summary>
				/// <para>Tells the length of the content, if known.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of bytes of the content, or a negative number if unknown. If the content length is known but exceeds Long.MAX_VALUE, a negative number is returned. </para>
				/// </returns>
				/// <java-name>
				/// getContentLength
				/// </java-name>
				public long ContentLength
				{
				[Dot42.DexImport("getContentLength", "()J", AccessFlags = 1)]
						get{ return GetContentLength(); }
				}

		}

		/// <summary>
		/// <para>A streamed entity obtaining content from an InputStream.</para><para><para></para><para></para><title>Revision:</title><para>617591 </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/entity/InputStreamEntity
		/// </java-name>
		[Dot42.DexImport("org/apache/http/entity/InputStreamEntity", AccessFlags = 33)]
		public partial class InputStreamEntity : global::Org.Apache.Http.Entity.AbstractHttpEntity
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/io/InputStream;J)V", AccessFlags = 1)]
				public InputStreamEntity(global::Java.Io.InputStream instream, long length) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Tells if the entity is capable to produce its data more than once. A repeatable entity's getContent() and writeTo(OutputStream) methods can be called more than once whereas a non-repeatable entity's can not. </para>        
				/// </summary>
				/// <returns>
				/// <para>true if the entity is repeatable, false otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isRepeatable
				/// </java-name>
				[Dot42.DexImport("isRepeatable", "()Z", AccessFlags = 1)]
				public override bool IsRepeatable() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Tells the length of the content, if known.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of bytes of the content, or a negative number if unknown. If the content length is known but exceeds Long.MAX_VALUE, a negative number is returned. </para>
				/// </returns>
				/// <java-name>
				/// getContentLength
				/// </java-name>
				[Dot42.DexImport("getContentLength", "()J", AccessFlags = 1)]
				public override long GetContentLength() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>Creates a new InputStream object of the entity. It is a programming error to return the same InputStream object more than once. Entities that are not repeatable will throw an exception if this method is called multiple times.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a new input stream that returns the entity data.</para>
				/// </returns>
				/// <java-name>
				/// getContent
				/// </java-name>
				[Dot42.DexImport("getContent", "()Ljava/io/InputStream;", AccessFlags = 1)]
				public override global::Java.Io.InputStream GetContent() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.InputStream);
				}

				/// <java-name>
				/// writeTo
				/// </java-name>
				[Dot42.DexImport("writeTo", "(Ljava/io/OutputStream;)V", AccessFlags = 1)]
				public override void WriteTo(global::Java.Io.OutputStream outstream) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Tells whether this entity depends on an underlying stream. Streamed entities should return <code>true</code> until the content has been consumed, <code>false</code> afterwards. Self-contained entities should return <code>false</code>. Wrapping entities should delegate this call to the wrapped entity. <br></br> The content of a streamed entity is consumed when the stream returned by getContent has been read to EOF, or after consumeContent has been called. If a streamed entity can not detect whether the stream has been read to EOF, it should return <code>true</code> until consumeContent is called.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> if the entity content is streamed and not yet consumed, <code>false</code> otherwise </para>
				/// </returns>
				/// <java-name>
				/// isStreaming
				/// </java-name>
				[Dot42.DexImport("isStreaming", "()Z", AccessFlags = 1)]
				public override bool IsStreaming() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Does not consume anything. The default implementation does nothing if isStreaming returns <code>false</code>, and throws an exception if it returns <code>true</code>. This removes the burden of implementing an empty method for non-streaming entities.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// consumeContent
				/// </java-name>
				[Dot42.DexImport("consumeContent", "()V", AccessFlags = 1)]
				public override void ConsumeContent() /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal InputStreamEntity() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Tells the length of the content, if known.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of bytes of the content, or a negative number if unknown. If the content length is known but exceeds Long.MAX_VALUE, a negative number is returned. </para>
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
				/// <para>Creates a new InputStream object of the entity. It is a programming error to return the same InputStream object more than once. Entities that are not repeatable will throw an exception if this method is called multiple times.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a new input stream that returns the entity data.</para>
				/// </returns>
				/// <java-name>
				/// getContent
				/// </java-name>
				public global::Java.Io.InputStream Content
				{
				[Dot42.DexImport("getContent", "()Ljava/io/InputStream;", AccessFlags = 1)]
						get{ return GetContent(); }
				}

		}

		/// <summary>
		/// <para>An entity whose content is retrieved from a file.</para><para><para></para><para></para><title>Revision:</title><para>604625 </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/entity/FileEntity
		/// </java-name>
		[Dot42.DexImport("org/apache/http/entity/FileEntity", AccessFlags = 33)]
		public partial class FileEntity : global::Org.Apache.Http.Entity.AbstractHttpEntity, global::Java.Lang.ICloneable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// file
				/// </java-name>
				[Dot42.DexImport("file", "Ljava/io/File;", AccessFlags = 20)]
				protected internal readonly global::Java.Io.File File;
				[Dot42.DexImport("<init>", "(Ljava/io/File;Ljava/lang/String;)V", AccessFlags = 1)]
				public FileEntity(global::Java.Io.File file, string contentType) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Tells if the entity is capable to produce its data more than once. A repeatable entity's getContent() and writeTo(OutputStream) methods can be called more than once whereas a non-repeatable entity's can not. </para>        
				/// </summary>
				/// <returns>
				/// <para>true if the entity is repeatable, false otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isRepeatable
				/// </java-name>
				[Dot42.DexImport("isRepeatable", "()Z", AccessFlags = 1)]
				public override bool IsRepeatable() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Tells the length of the content, if known.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of bytes of the content, or a negative number if unknown. If the content length is known but exceeds Long.MAX_VALUE, a negative number is returned. </para>
				/// </returns>
				/// <java-name>
				/// getContentLength
				/// </java-name>
				[Dot42.DexImport("getContentLength", "()J", AccessFlags = 1)]
				public override long GetContentLength() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>Creates a new InputStream object of the entity. It is a programming error to return the same InputStream object more than once. Entities that are not repeatable will throw an exception if this method is called multiple times.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a new input stream that returns the entity data.</para>
				/// </returns>
				/// <java-name>
				/// getContent
				/// </java-name>
				[Dot42.DexImport("getContent", "()Ljava/io/InputStream;", AccessFlags = 1)]
				public override global::Java.Io.InputStream GetContent() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.InputStream);
				}

				/// <java-name>
				/// writeTo
				/// </java-name>
				[Dot42.DexImport("writeTo", "(Ljava/io/OutputStream;)V", AccessFlags = 1)]
				public override void WriteTo(global::Java.Io.OutputStream outstream) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Tells that this entity is not streaming.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>false</code> </para>
				/// </returns>
				/// <java-name>
				/// isStreaming
				/// </java-name>
				[Dot42.DexImport("isStreaming", "()Z", AccessFlags = 1)]
				public override bool IsStreaming() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/lang/Object;", AccessFlags = 1)]
				public virtual object Clone() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal FileEntity() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Tells the length of the content, if known.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of bytes of the content, or a negative number if unknown. If the content length is known but exceeds Long.MAX_VALUE, a negative number is returned. </para>
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
				/// <para>Creates a new InputStream object of the entity. It is a programming error to return the same InputStream object more than once. Entities that are not repeatable will throw an exception if this method is called multiple times.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a new input stream that returns the entity data.</para>
				/// </returns>
				/// <java-name>
				/// getContent
				/// </java-name>
				public global::Java.Io.InputStream Content
				{
				[Dot42.DexImport("getContent", "()Ljava/io/InputStream;", AccessFlags = 1)]
						get{ return GetContent(); }
				}

		}

		/// <summary>
		/// <para>Abstract base class for entities. Provides the commonly used attributes for streamed and self-contained implementations of HttpEntity.</para><para><para></para><para></para><title>Revision:</title><para>496070 </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/entity/AbstractHttpEntity
		/// </java-name>
		[Dot42.DexImport("org/apache/http/entity/AbstractHttpEntity", AccessFlags = 1057)]
		public abstract partial class AbstractHttpEntity : global::Org.Apache.Http.IHttpEntity
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>The Content-Type header. Returned by getContentType, unless that method is overridden. </para>        
				/// </summary>
				/// <java-name>
				/// contentType
				/// </java-name>
				[Dot42.DexImport("contentType", "Lorg/apache/http/Header;", AccessFlags = 4)]
				protected internal global::Org.Apache.Http.IHeader ContentType;
				/// <summary>
				/// <para>The Content-Encoding header. Returned by getContentEncoding, unless that method is overridden. </para>        
				/// </summary>
				/// <java-name>
				/// contentEncoding
				/// </java-name>
				[Dot42.DexImport("contentEncoding", "Lorg/apache/http/Header;", AccessFlags = 4)]
				protected internal global::Org.Apache.Http.IHeader ContentEncoding;
				/// <summary>
				/// <para>The 'chunked' flag. Returned by isChunked, unless that method is overridden. </para>        
				/// </summary>
				/// <java-name>
				/// chunked
				/// </java-name>
				[Dot42.DexImport("chunked", "Z", AccessFlags = 4)]
				protected internal bool Chunked;
				/// <summary>
				/// <para>Protected default constructor. The attributes of the created object remain <code>null</code> and <code>false</code>, respectively. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal AbstractHttpEntity() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Obtains the Content-Type header. The default implementation returns the value of the contentType attribute.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the Content-Type header, or <code>null</code> </para>
				/// </returns>
				/// <java-name>
				/// getContentType
				/// </java-name>
				[Dot42.DexImport("getContentType", "()Lorg/apache/http/Header;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.IHeader GetContentType() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IHeader);
				}

				/// <summary>
				/// <para>Obtains the Content-Encoding header. The default implementation returns the value of the contentEncoding attribute.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the Content-Encoding header, or <code>null</code> </para>
				/// </returns>
				/// <java-name>
				/// getContentEncoding
				/// </java-name>
				[Dot42.DexImport("getContentEncoding", "()Lorg/apache/http/Header;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.IHeader GetContentEncoding() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IHeader);
				}

				/// <summary>
				/// <para>Obtains the 'chunked' flag. The default implementation returns the value of the chunked attribute.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the 'chunked' flag </para>
				/// </returns>
				/// <java-name>
				/// isChunked
				/// </java-name>
				[Dot42.DexImport("isChunked", "()Z", AccessFlags = 1)]
				public virtual bool IsChunked() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Specifies the Content-Type header. The default implementation sets the value of the contentType attribute.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setContentType
				/// </java-name>
				[Dot42.DexImport("setContentType", "(Lorg/apache/http/Header;)V", AccessFlags = 1)]
				public virtual void SetContentType(global::Org.Apache.Http.IHeader contentType) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Specifies the Content-Type header. The default implementation sets the value of the contentType attribute.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setContentType
				/// </java-name>
				[Dot42.DexImport("setContentType", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetContentType(string contentType) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Specifies the Content-Encoding header. The default implementation sets the value of the contentEncoding attribute.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setContentEncoding
				/// </java-name>
				[Dot42.DexImport("setContentEncoding", "(Lorg/apache/http/Header;)V", AccessFlags = 1)]
				public virtual void SetContentEncoding(global::Org.Apache.Http.IHeader contentEncoding) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Specifies the Content-Encoding header. The default implementation sets the value of the contentEncoding attribute.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setContentEncoding
				/// </java-name>
				[Dot42.DexImport("setContentEncoding", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetContentEncoding(string contentEncoding) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Specifies the 'chunked' flag. The default implementation sets the value of the chunked attribute.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setChunked
				/// </java-name>
				[Dot42.DexImport("setChunked", "(Z)V", AccessFlags = 1)]
				public virtual void SetChunked(bool b) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Does not consume anything. The default implementation does nothing if isStreaming returns <code>false</code>, and throws an exception if it returns <code>true</code>. This removes the burden of implementing an empty method for non-streaming entities.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// consumeContent
				/// </java-name>
				[Dot42.DexImport("consumeContent", "()V", AccessFlags = 1)]
				public virtual void ConsumeContent() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("org/apache/http/HttpEntity", "isRepeatable", "()Z", AccessFlags = 1025)]
				public virtual bool IsRepeatable() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("org/apache/http/HttpEntity", "getContentLength", "()J", AccessFlags = 1025)]
				public virtual long GetContentLength() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(long);
				}

				[Dot42.DexImport("org/apache/http/HttpEntity", "getContent", "()Ljava/io/InputStream;", AccessFlags = 1025)]
				public virtual global::Java.Io.InputStream GetContent() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Java.Io.InputStream);
				}

				[Dot42.DexImport("org/apache/http/HttpEntity", "writeTo", "(Ljava/io/OutputStream;)V", AccessFlags = 1025)]
				public virtual void WriteTo(global::Java.Io.OutputStream outstream) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("org/apache/http/HttpEntity", "isStreaming", "()Z", AccessFlags = 1025)]
				public virtual bool IsStreaming() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				public long ContentLength
				{
				[Dot42.DexImport("org/apache/http/HttpEntity", "getContentLength", "()J", AccessFlags = 1025)]
						get{ return GetContentLength(); }
				}

				public global::Java.Io.InputStream Content
				{
				[Dot42.DexImport("org/apache/http/HttpEntity", "getContent", "()Ljava/io/InputStream;", AccessFlags = 1025)]
						get{ return GetContent(); }
				}

		}

		/// <summary>
		/// <para>Represents a strategy to determine the content length based on the properties of an HTTP message.</para><para><para></para><para></para><title>Revision:</title><para>613298 </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/entity/ContentLengthStrategy
		/// </java-name>
		[Dot42.DexImport("org/apache/http/entity/ContentLengthStrategy", AccessFlags = 1537, IgnoreFromJava = true, Priority = 1)]
		public static partial class IContentLengthStrategyConstants
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// IDENTITY
				/// </java-name>
				[Dot42.DexImport("IDENTITY", "I", AccessFlags = 25)]
				public const int IDENTITY = -1;
				/// <java-name>
				/// CHUNKED
				/// </java-name>
				[Dot42.DexImport("CHUNKED", "I", AccessFlags = 25)]
				public const int CHUNKED = -2;
		}

		/// <summary>
		/// <para>Represents a strategy to determine the content length based on the properties of an HTTP message.</para><para><para></para><para></para><title>Revision:</title><para>613298 </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/entity/ContentLengthStrategy
		/// </java-name>
		[Dot42.DexImport("org/apache/http/entity/ContentLengthStrategy", AccessFlags = 1537)]
		public partial interface IContentLengthStrategy
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// determineLength
				/// </java-name>
				[Dot42.DexImport("determineLength", "(Lorg/apache/http/HttpMessage;)J", AccessFlags = 1025)]
				long DetermineLength(global::Org.Apache.Http.IHttpMessage message) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>An abstract entity content producer.</para><para>Content producers are expected to be able to produce their content multiple times</para><para><para></para><para></para><title>Revision:</title><para>496070 </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/entity/ContentProducer
		/// </java-name>
		[Dot42.DexImport("org/apache/http/entity/ContentProducer", AccessFlags = 1537)]
		public partial interface IContentProducer
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// writeTo
				/// </java-name>
				[Dot42.DexImport("writeTo", "(Ljava/io/OutputStream;)V", AccessFlags = 1025)]
				void WriteTo(global::Java.Io.OutputStream outstream) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>An entity whose content is retrieved from a string.</para><para><para></para><para></para><title>Revision:</title><para>618367 </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/entity/StringEntity
		/// </java-name>
		[Dot42.DexImport("org/apache/http/entity/StringEntity", AccessFlags = 33)]
		public partial class StringEntity : global::Org.Apache.Http.Entity.AbstractHttpEntity, global::Java.Lang.ICloneable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// content
				/// </java-name>
				[Dot42.DexImport("content", "[B", AccessFlags = 20)]
				protected internal readonly sbyte[] Content;
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public StringEntity(string s, string charset) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public StringEntity(string s) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Tells if the entity is capable to produce its data more than once. A repeatable entity's getContent() and writeTo(OutputStream) methods can be called more than once whereas a non-repeatable entity's can not. </para>        
				/// </summary>
				/// <returns>
				/// <para>true if the entity is repeatable, false otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isRepeatable
				/// </java-name>
				[Dot42.DexImport("isRepeatable", "()Z", AccessFlags = 1)]
				public override bool IsRepeatable() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Tells the length of the content, if known.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of bytes of the content, or a negative number if unknown. If the content length is known but exceeds Long.MAX_VALUE, a negative number is returned. </para>
				/// </returns>
				/// <java-name>
				/// getContentLength
				/// </java-name>
				[Dot42.DexImport("getContentLength", "()J", AccessFlags = 1)]
				public override long GetContentLength() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>Creates a new InputStream object of the entity. It is a programming error to return the same InputStream object more than once. Entities that are not repeatable will throw an exception if this method is called multiple times.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a new input stream that returns the entity data.</para>
				/// </returns>
				/// <java-name>
				/// getContent
				/// </java-name>
				[Dot42.DexImport("getContent", "()Ljava/io/InputStream;", AccessFlags = 1)]
				public override global::Java.Io.InputStream GetContent() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.InputStream);
				}

				/// <java-name>
				/// writeTo
				/// </java-name>
				[Dot42.DexImport("writeTo", "(Ljava/io/OutputStream;)V", AccessFlags = 1)]
				public override void WriteTo(global::Java.Io.OutputStream outstream) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Tells that this entity is not streaming.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>false</code> </para>
				/// </returns>
				/// <java-name>
				/// isStreaming
				/// </java-name>
				[Dot42.DexImport("isStreaming", "()Z", AccessFlags = 1)]
				public override bool IsStreaming() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/lang/Object;", AccessFlags = 1)]
				public virtual object Clone() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal StringEntity() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Tells the length of the content, if known.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of bytes of the content, or a negative number if unknown. If the content length is known but exceeds Long.MAX_VALUE, a negative number is returned. </para>
				/// </returns>
				/// <java-name>
				/// getContentLength
				/// </java-name>
				public long ContentLength
				{
				[Dot42.DexImport("getContentLength", "()J", AccessFlags = 1)]
						get{ return GetContentLength(); }
				}

		}

}


