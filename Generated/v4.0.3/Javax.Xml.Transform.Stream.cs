#pragma warning disable 1717
namespace Javax.Xml.Transform.Stream
{
		/// <java-name>
		/// javax/xml/transform/stream/StreamResult
		/// </java-name>
		[Dot42.DexImport("javax/xml/transform/stream/StreamResult", AccessFlags = 33)]
		public partial class StreamResult : global::Javax.Xml.Transform.IResult
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// FEATURE
				/// </java-name>
				[Dot42.DexImport("FEATURE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string FEATURE = "http://javax.xml.transform.stream.StreamResult/feature";
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public StreamResult() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/io/OutputStream;)V", AccessFlags = 1)]
				public StreamResult(global::Java.Io.OutputStream outputStream) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/io/Writer;)V", AccessFlags = 1)]
				public StreamResult(global::Java.Io.Writer writer) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public StreamResult(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/io/File;)V", AccessFlags = 1)]
				public StreamResult(global::Java.Io.File file) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setOutputStream
				/// </java-name>
				[Dot42.DexImport("setOutputStream", "(Ljava/io/OutputStream;)V", AccessFlags = 1)]
				public virtual void SetOutputStream(global::Java.Io.OutputStream outputStream) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getOutputStream
				/// </java-name>
				[Dot42.DexImport("getOutputStream", "()Ljava/io/OutputStream;", AccessFlags = 1)]
				public virtual global::Java.Io.OutputStream GetOutputStream() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.OutputStream);
				}

				/// <java-name>
				/// setWriter
				/// </java-name>
				[Dot42.DexImport("setWriter", "(Ljava/io/Writer;)V", AccessFlags = 1)]
				public virtual void SetWriter(global::Java.Io.Writer writer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getWriter
				/// </java-name>
				[Dot42.DexImport("getWriter", "()Ljava/io/Writer;", AccessFlags = 1)]
				public virtual global::Java.Io.Writer GetWriter() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.Writer);
				}

				/// <java-name>
				/// setSystemId
				/// </java-name>
				[Dot42.DexImport("setSystemId", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetSystemId(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setSystemId
				/// </java-name>
				[Dot42.DexImport("setSystemId", "(Ljava/io/File;)V", AccessFlags = 1)]
				public virtual void SetSystemId(global::Java.Io.File file) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getSystemId
				/// </java-name>
				[Dot42.DexImport("getSystemId", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetSystemId() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getOutputStream
				/// </java-name>
				public global::Java.Io.OutputStream OutputStream
				{
				[Dot42.DexImport("getOutputStream", "()Ljava/io/OutputStream;", AccessFlags = 1)]
						get{ return GetOutputStream(); }
				[Dot42.DexImport("setOutputStream", "(Ljava/io/OutputStream;)V", AccessFlags = 1)]
						set{ SetOutputStream(value); }
				}

				/// <java-name>
				/// getWriter
				/// </java-name>
				public global::Java.Io.Writer Writer
				{
				[Dot42.DexImport("getWriter", "()Ljava/io/Writer;", AccessFlags = 1)]
						get{ return GetWriter(); }
				[Dot42.DexImport("setWriter", "(Ljava/io/Writer;)V", AccessFlags = 1)]
						set{ SetWriter(value); }
				}

				/// <java-name>
				/// getSystemId
				/// </java-name>
				public string SystemId
				{
				[Dot42.DexImport("getSystemId", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetSystemId(); }
				[Dot42.DexImport("setSystemId", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ SetSystemId(value); }
				}

		}

		/// <java-name>
		/// javax/xml/transform/stream/StreamSource
		/// </java-name>
		[Dot42.DexImport("javax/xml/transform/stream/StreamSource", AccessFlags = 33)]
		public partial class StreamSource : global::Javax.Xml.Transform.ISource
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// FEATURE
				/// </java-name>
				[Dot42.DexImport("FEATURE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string FEATURE = "http://javax.xml.transform.stream.StreamSource/feature";
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public StreamSource() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/io/InputStream;)V", AccessFlags = 1)]
				public StreamSource(global::Java.Io.InputStream inputStream) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/io/InputStream;Ljava/lang/String;)V", AccessFlags = 1)]
				public StreamSource(global::Java.Io.InputStream inputStream, string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/io/Reader;)V", AccessFlags = 1)]
				public StreamSource(global::Java.Io.Reader reader) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/io/Reader;Ljava/lang/String;)V", AccessFlags = 1)]
				public StreamSource(global::Java.Io.Reader reader, string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public StreamSource(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/io/File;)V", AccessFlags = 1)]
				public StreamSource(global::Java.Io.File file) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setInputStream
				/// </java-name>
				[Dot42.DexImport("setInputStream", "(Ljava/io/InputStream;)V", AccessFlags = 1)]
				public virtual void SetInputStream(global::Java.Io.InputStream inputStream) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getInputStream
				/// </java-name>
				[Dot42.DexImport("getInputStream", "()Ljava/io/InputStream;", AccessFlags = 1)]
				public virtual global::Java.Io.InputStream GetInputStream() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.InputStream);
				}

				/// <java-name>
				/// setReader
				/// </java-name>
				[Dot42.DexImport("setReader", "(Ljava/io/Reader;)V", AccessFlags = 1)]
				public virtual void SetReader(global::Java.Io.Reader reader) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getReader
				/// </java-name>
				[Dot42.DexImport("getReader", "()Ljava/io/Reader;", AccessFlags = 1)]
				public virtual global::Java.Io.Reader GetReader() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.Reader);
				}

				/// <java-name>
				/// setPublicId
				/// </java-name>
				[Dot42.DexImport("setPublicId", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetPublicId(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getPublicId
				/// </java-name>
				[Dot42.DexImport("getPublicId", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetPublicId() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// setSystemId
				/// </java-name>
				[Dot42.DexImport("setSystemId", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetSystemId(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getSystemId
				/// </java-name>
				[Dot42.DexImport("getSystemId", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetSystemId() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// setSystemId
				/// </java-name>
				[Dot42.DexImport("setSystemId", "(Ljava/io/File;)V", AccessFlags = 1)]
				public virtual void SetSystemId(global::Java.Io.File file) /* MethodBuilder.Create */ 
				{
				}

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

				/// <java-name>
				/// getReader
				/// </java-name>
				public global::Java.Io.Reader Reader
				{
				[Dot42.DexImport("getReader", "()Ljava/io/Reader;", AccessFlags = 1)]
						get{ return GetReader(); }
				[Dot42.DexImport("setReader", "(Ljava/io/Reader;)V", AccessFlags = 1)]
						set{ SetReader(value); }
				}

				/// <java-name>
				/// getPublicId
				/// </java-name>
				public string PublicId
				{
				[Dot42.DexImport("getPublicId", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetPublicId(); }
				[Dot42.DexImport("setPublicId", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ SetPublicId(value); }
				}

				/// <java-name>
				/// getSystemId
				/// </java-name>
				public string SystemId
				{
				[Dot42.DexImport("getSystemId", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetSystemId(); }
				[Dot42.DexImport("setSystemId", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ SetSystemId(value); }
				}

		}

}

