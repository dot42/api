#pragma warning disable 1717
namespace Org.Apache.Http.Entity
{
		/// <java-name>
		/// org/apache/http/entity/AbstractHttpEntity
		/// </java-name>
		[Dot42.DexImport("org/apache/http/entity/AbstractHttpEntity", AccessFlags = 1057)]
		public abstract partial class AbstractHttpEntity : global::Org.Apache.Http.IHttpEntity
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// contentType
				/// </java-name>
				[Dot42.DexImport("contentType", "Lorg/apache/http/Header;", AccessFlags = 4)]
				protected internal global::Org.Apache.Http.IHeader @contentType;
				/// <java-name>
				/// contentEncoding
				/// </java-name>
				[Dot42.DexImport("contentEncoding", "Lorg/apache/http/Header;", AccessFlags = 4)]
				protected internal global::Org.Apache.Http.IHeader @contentEncoding;
				/// <java-name>
				/// chunked
				/// </java-name>
				[Dot42.DexImport("chunked", "Z", AccessFlags = 4)]
				protected internal bool Chunked;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal AbstractHttpEntity() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setContentType
				/// </java-name>
				[Dot42.DexImport("setContentType", "(Lorg/apache/http/Header;)V", AccessFlags = 1)]
				public virtual void SetContentType(global::Org.Apache.Http.IHeader header) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setContentType
				/// </java-name>
				[Dot42.DexImport("setContentType", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetContentType(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setContentEncoding
				/// </java-name>
				[Dot42.DexImport("setContentEncoding", "(Lorg/apache/http/Header;)V", AccessFlags = 1)]
				public virtual void SetContentEncoding(global::Org.Apache.Http.IHeader header) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setContentEncoding
				/// </java-name>
				[Dot42.DexImport("setContentEncoding", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetContentEncoding(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setChunked
				/// </java-name>
				[Dot42.DexImport("setChunked", "(Z)V", AccessFlags = 1)]
				public virtual void SetChunked(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// consumeContent
				/// </java-name>
				[Dot42.DexImport("consumeContent", "()V", AccessFlags = 1)]
				public virtual void ConsumeContent() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("org/apache/http/HttpEntity", "writeTo", "(Ljava/io/OutputStream;)V", AccessFlags = 1025)]
				public virtual void WriteTo(global::Java.IO.OutputStream outputStream) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				/// <java-name>
				/// getContentType
				/// </java-name>
				public virtual global::Org.Apache.Http.IHeader ContentType
				{
						[Dot42.DexImport("getContentType", "()Lorg/apache/http/Header;", AccessFlags = 1)]
						get{ return default(global::Org.Apache.Http.IHeader); }
				}

				/// <java-name>
				/// getContentEncoding
				/// </java-name>
				public virtual global::Org.Apache.Http.IHeader ContentEncoding
				{
						[Dot42.DexImport("getContentEncoding", "()Lorg/apache/http/Header;", AccessFlags = 1)]
						get{ return default(global::Org.Apache.Http.IHeader); }
				}

				/// <java-name>
				/// isChunked
				/// </java-name>
				public virtual bool IsChunked
				{
						[Dot42.DexImport("isChunked", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				public virtual bool IsRepeatable
				{
						[Dot42.DexImport("org/apache/http/HttpEntity", "isRepeatable", "()Z", AccessFlags = 1025)]
						get{ return default(bool); }
				}

				public virtual long ContentLength
				{
						[Dot42.DexImport("org/apache/http/HttpEntity", "getContentLength", "()J", AccessFlags = 1025)]
						get{ return default(long); }
				}

				public virtual global::Java.IO.InputStream Content
				{
						[Dot42.DexImport("org/apache/http/HttpEntity", "getContent", "()Ljava/io/InputStream;", AccessFlags = 1025)]
						get{ return default(global::Java.IO.InputStream); }
				}

				public virtual bool IsStreaming
				{
						[Dot42.DexImport("org/apache/http/HttpEntity", "isStreaming", "()Z", AccessFlags = 1025)]
						get{ return default(bool); }
				}

		}

		/// <java-name>
		/// org/apache/http/entity/BasicHttpEntity
		/// </java-name>
		[Dot42.DexImport("org/apache/http/entity/BasicHttpEntity", AccessFlags = 33)]
		public partial class BasicHttpEntity : global::Org.Apache.Http.Entity.AbstractHttpEntity
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public BasicHttpEntity() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setContentLength
				/// </java-name>
				[Dot42.DexImport("setContentLength", "(J)V", AccessFlags = 1)]
				public virtual void SetContentLength(long int64) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setContent
				/// </java-name>
				[Dot42.DexImport("setContent", "(Ljava/io/InputStream;)V", AccessFlags = 1)]
				public virtual void SetContent(global::Java.IO.InputStream inputStream) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writeTo
				/// </java-name>
				[Dot42.DexImport("writeTo", "(Ljava/io/OutputStream;)V", AccessFlags = 1)]
				public override void WriteTo(global::Java.IO.OutputStream outputStream) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// consumeContent
				/// </java-name>
				[Dot42.DexImport("consumeContent", "()V", AccessFlags = 1)]
				public override void ConsumeContent() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getContentLength
				/// </java-name>
				public override long ContentLength
				{
						[Dot42.DexImport("getContentLength", "()J", AccessFlags = 1)]
						get{ return default(long); }
				}

				/// <java-name>
				/// getContent
				/// </java-name>
				public override global::Java.IO.InputStream Content
				{
						[Dot42.DexImport("getContent", "()Ljava/io/InputStream;", AccessFlags = 1)]
						get{ return default(global::Java.IO.InputStream); }
				}

				/// <java-name>
				/// isRepeatable
				/// </java-name>
				public override bool IsRepeatable
				{
						[Dot42.DexImport("isRepeatable", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// isStreaming
				/// </java-name>
				public override bool IsStreaming
				{
						[Dot42.DexImport("isStreaming", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

		}

		/// <java-name>
		/// org/apache/http/entity/BufferedHttpEntity
		/// </java-name>
		[Dot42.DexImport("org/apache/http/entity/BufferedHttpEntity", AccessFlags = 33)]
		public partial class BufferedHttpEntity : global::Org.Apache.Http.Entity.HttpEntityWrapper
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Lorg/apache/http/HttpEntity;)V", AccessFlags = 1)]
				public BufferedHttpEntity(global::Org.Apache.Http.IHttpEntity httpEntity) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writeTo
				/// </java-name>
				[Dot42.DexImport("writeTo", "(Ljava/io/OutputStream;)V", AccessFlags = 1)]
				public override void WriteTo(global::Java.IO.OutputStream outputStream) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal BufferedHttpEntity() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getContentLength
				/// </java-name>
				public override long ContentLength
				{
						[Dot42.DexImport("getContentLength", "()J", AccessFlags = 1)]
						get{ return default(long); }
				}

				/// <java-name>
				/// getContent
				/// </java-name>
				public override global::Java.IO.InputStream Content
				{
						[Dot42.DexImport("getContent", "()Ljava/io/InputStream;", AccessFlags = 1)]
						get{ return default(global::Java.IO.InputStream); }
				}

				/// <java-name>
				/// isChunked
				/// </java-name>
				public override bool IsChunked
				{
						[Dot42.DexImport("isChunked", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// isRepeatable
				/// </java-name>
				public override bool IsRepeatable
				{
						[Dot42.DexImport("isRepeatable", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// isStreaming
				/// </java-name>
				public override bool IsStreaming
				{
						[Dot42.DexImport("isStreaming", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

		}

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
				protected internal readonly sbyte[] @content;
				[Dot42.DexImport("<init>", "([B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public ByteArrayEntity(sbyte[] sByte) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "([B)V", AccessFlags = 1)]
				public ByteArrayEntity(byte[] @byte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writeTo
				/// </java-name>
				[Dot42.DexImport("writeTo", "(Ljava/io/OutputStream;)V", AccessFlags = 1)]
				public override void WriteTo(global::Java.IO.OutputStream outputStream) /* MethodBuilder.Create */ 
				{
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
				protected internal ByteArrayEntity() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// isRepeatable
				/// </java-name>
				public override bool IsRepeatable
				{
						[Dot42.DexImport("isRepeatable", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// getContentLength
				/// </java-name>
				public override long ContentLength
				{
						[Dot42.DexImport("getContentLength", "()J", AccessFlags = 1)]
						get{ return default(long); }
				}

				/// <java-name>
				/// getContent
				/// </java-name>
				public override global::Java.IO.InputStream Content
				{
						[Dot42.DexImport("getContent", "()Ljava/io/InputStream;", AccessFlags = 1)]
						get{ return default(global::Java.IO.InputStream); }
				}

				/// <java-name>
				/// isStreaming
				/// </java-name>
				public override bool IsStreaming
				{
						[Dot42.DexImport("isStreaming", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

		}

		/// <java-name>
		/// org/apache/http/entity/EntityTemplate
		/// </java-name>
		[Dot42.DexImport("org/apache/http/entity/EntityTemplate", AccessFlags = 33)]
		public partial class EntityTemplate : global::Org.Apache.Http.Entity.AbstractHttpEntity
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Lorg/apache/http/entity/ContentProducer;)V", AccessFlags = 1)]
				public EntityTemplate(global::Org.Apache.Http.Entity.IContentProducer contentProducer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writeTo
				/// </java-name>
				[Dot42.DexImport("writeTo", "(Ljava/io/OutputStream;)V", AccessFlags = 1)]
				public override void WriteTo(global::Java.IO.OutputStream outputStream) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// consumeContent
				/// </java-name>
				[Dot42.DexImport("consumeContent", "()V", AccessFlags = 1)]
				public override void ConsumeContent() /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal EntityTemplate() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getContentLength
				/// </java-name>
				public override long ContentLength
				{
						[Dot42.DexImport("getContentLength", "()J", AccessFlags = 1)]
						get{ return default(long); }
				}

				/// <java-name>
				/// getContent
				/// </java-name>
				public override global::Java.IO.InputStream Content
				{
						[Dot42.DexImport("getContent", "()Ljava/io/InputStream;", AccessFlags = 1)]
						get{ return default(global::Java.IO.InputStream); }
				}

				/// <java-name>
				/// isRepeatable
				/// </java-name>
				public override bool IsRepeatable
				{
						[Dot42.DexImport("isRepeatable", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// isStreaming
				/// </java-name>
				public override bool IsStreaming
				{
						[Dot42.DexImport("isStreaming", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

		}

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
				protected internal readonly global::Java.IO.File File;
				[Dot42.DexImport("<init>", "(Ljava/io/File;Ljava/lang/String;)V", AccessFlags = 1)]
				public FileEntity(global::Java.IO.File file, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writeTo
				/// </java-name>
				[Dot42.DexImport("writeTo", "(Ljava/io/OutputStream;)V", AccessFlags = 1)]
				public override void WriteTo(global::Java.IO.OutputStream outputStream) /* MethodBuilder.Create */ 
				{
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
				protected internal FileEntity() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// isRepeatable
				/// </java-name>
				public override bool IsRepeatable
				{
						[Dot42.DexImport("isRepeatable", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// getContentLength
				/// </java-name>
				public override long ContentLength
				{
						[Dot42.DexImport("getContentLength", "()J", AccessFlags = 1)]
						get{ return default(long); }
				}

				/// <java-name>
				/// getContent
				/// </java-name>
				public override global::Java.IO.InputStream Content
				{
						[Dot42.DexImport("getContent", "()Ljava/io/InputStream;", AccessFlags = 1)]
						get{ return default(global::Java.IO.InputStream); }
				}

				/// <java-name>
				/// isStreaming
				/// </java-name>
				public override bool IsStreaming
				{
						[Dot42.DexImport("isStreaming", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

		}

		/// <java-name>
		/// org/apache/http/entity/HttpEntityWrapper
		/// </java-name>
		[Dot42.DexImport("org/apache/http/entity/HttpEntityWrapper", AccessFlags = 33)]
		public partial class HttpEntityWrapper : global::Org.Apache.Http.IHttpEntity
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// wrappedEntity
				/// </java-name>
				[Dot42.DexImport("wrappedEntity", "Lorg/apache/http/HttpEntity;", AccessFlags = 4)]
				protected internal global::Org.Apache.Http.IHttpEntity WrappedEntity;
				[Dot42.DexImport("<init>", "(Lorg/apache/http/HttpEntity;)V", AccessFlags = 1)]
				public HttpEntityWrapper(global::Org.Apache.Http.IHttpEntity httpEntity) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writeTo
				/// </java-name>
				[Dot42.DexImport("writeTo", "(Ljava/io/OutputStream;)V", AccessFlags = 1)]
				public virtual void WriteTo(global::Java.IO.OutputStream outputStream) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// consumeContent
				/// </java-name>
				[Dot42.DexImport("consumeContent", "()V", AccessFlags = 1)]
				public virtual void ConsumeContent() /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal HttpEntityWrapper() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// isRepeatable
				/// </java-name>
				public virtual bool IsRepeatable
				{
						[Dot42.DexImport("isRepeatable", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// isChunked
				/// </java-name>
				public virtual bool IsChunked
				{
						[Dot42.DexImport("isChunked", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// getContentLength
				/// </java-name>
				public virtual long ContentLength
				{
						[Dot42.DexImport("getContentLength", "()J", AccessFlags = 1)]
						get{ return default(long); }
				}

				/// <java-name>
				/// getContentType
				/// </java-name>
				public virtual global::Org.Apache.Http.IHeader ContentType
				{
						[Dot42.DexImport("getContentType", "()Lorg/apache/http/Header;", AccessFlags = 1)]
						get{ return default(global::Org.Apache.Http.IHeader); }
				}

				/// <java-name>
				/// getContentEncoding
				/// </java-name>
				public virtual global::Org.Apache.Http.IHeader ContentEncoding
				{
						[Dot42.DexImport("getContentEncoding", "()Lorg/apache/http/Header;", AccessFlags = 1)]
						get{ return default(global::Org.Apache.Http.IHeader); }
				}

				/// <java-name>
				/// getContent
				/// </java-name>
				public virtual global::Java.IO.InputStream Content
				{
						[Dot42.DexImport("getContent", "()Ljava/io/InputStream;", AccessFlags = 1)]
						get{ return default(global::Java.IO.InputStream); }
				}

				/// <java-name>
				/// isStreaming
				/// </java-name>
				public virtual bool IsStreaming
				{
						[Dot42.DexImport("isStreaming", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

		}

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
				long DetermineLength(global::Org.Apache.Http.IHttpMessage httpMessage) /* MethodBuilder.Create */ ;

		}

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
				void WriteTo(global::Java.IO.OutputStream outputStream) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// org/apache/http/entity/InputStreamEntity
		/// </java-name>
		[Dot42.DexImport("org/apache/http/entity/InputStreamEntity", AccessFlags = 33)]
		public partial class InputStreamEntity : global::Org.Apache.Http.Entity.AbstractHttpEntity
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/io/InputStream;J)V", AccessFlags = 1)]
				public InputStreamEntity(global::Java.IO.InputStream inputStream, long int64) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writeTo
				/// </java-name>
				[Dot42.DexImport("writeTo", "(Ljava/io/OutputStream;)V", AccessFlags = 1)]
				public override void WriteTo(global::Java.IO.OutputStream outputStream) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// consumeContent
				/// </java-name>
				[Dot42.DexImport("consumeContent", "()V", AccessFlags = 1)]
				public override void ConsumeContent() /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal InputStreamEntity() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// isRepeatable
				/// </java-name>
				public override bool IsRepeatable
				{
						[Dot42.DexImport("isRepeatable", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// getContentLength
				/// </java-name>
				public override long ContentLength
				{
						[Dot42.DexImport("getContentLength", "()J", AccessFlags = 1)]
						get{ return default(long); }
				}

				/// <java-name>
				/// getContent
				/// </java-name>
				public override global::Java.IO.InputStream Content
				{
						[Dot42.DexImport("getContent", "()Ljava/io/InputStream;", AccessFlags = 1)]
						get{ return default(global::Java.IO.InputStream); }
				}

				/// <java-name>
				/// isStreaming
				/// </java-name>
				public override bool IsStreaming
				{
						[Dot42.DexImport("isStreaming", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
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
				public SerializableEntity(global::Java.IO.ISerializable serializable, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writeTo
				/// </java-name>
				[Dot42.DexImport("writeTo", "(Ljava/io/OutputStream;)V", AccessFlags = 1)]
				public override void WriteTo(global::Java.IO.OutputStream outputStream) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal SerializableEntity() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getContent
				/// </java-name>
				public override global::Java.IO.InputStream Content
				{
						[Dot42.DexImport("getContent", "()Ljava/io/InputStream;", AccessFlags = 1)]
						get{ return default(global::Java.IO.InputStream); }
				}

				/// <java-name>
				/// getContentLength
				/// </java-name>
				public override long ContentLength
				{
						[Dot42.DexImport("getContentLength", "()J", AccessFlags = 1)]
						get{ return default(long); }
				}

				/// <java-name>
				/// isRepeatable
				/// </java-name>
				public override bool IsRepeatable
				{
						[Dot42.DexImport("isRepeatable", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// isStreaming
				/// </java-name>
				public override bool IsStreaming
				{
						[Dot42.DexImport("isStreaming", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

		}

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
				protected internal readonly sbyte[] @content;
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public StringEntity(string @string, string string1) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public StringEntity(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writeTo
				/// </java-name>
				[Dot42.DexImport("writeTo", "(Ljava/io/OutputStream;)V", AccessFlags = 1)]
				public override void WriteTo(global::Java.IO.OutputStream outputStream) /* MethodBuilder.Create */ 
				{
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
				protected internal StringEntity() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// isRepeatable
				/// </java-name>
				public override bool IsRepeatable
				{
						[Dot42.DexImport("isRepeatable", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// getContentLength
				/// </java-name>
				public override long ContentLength
				{
						[Dot42.DexImport("getContentLength", "()J", AccessFlags = 1)]
						get{ return default(long); }
				}

				/// <java-name>
				/// getContent
				/// </java-name>
				public override global::Java.IO.InputStream Content
				{
						[Dot42.DexImport("getContent", "()Ljava/io/InputStream;", AccessFlags = 1)]
						get{ return default(global::Java.IO.InputStream); }
				}

				/// <java-name>
				/// isStreaming
				/// </java-name>
				public override bool IsStreaming
				{
						[Dot42.DexImport("isStreaming", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

		}

}

