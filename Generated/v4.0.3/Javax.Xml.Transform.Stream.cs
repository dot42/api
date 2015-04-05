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
				/// setSystemId
				/// </java-name>
				[Dot42.DexImport("setSystemId", "(Ljava/io/File;)V", AccessFlags = 1)]
				public virtual void SetSystemId(global::Java.Io.File file) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getOutputStream
				/// </java-name>
				public virtual global::Java.Io.OutputStream OutputStream
				{
						[Dot42.DexImport("getOutputStream", "()Ljava/io/OutputStream;", AccessFlags = 1)]
						get{ return default(global::Java.Io.OutputStream); }
						[Dot42.DexImport("setOutputStream", "(Ljava/io/OutputStream;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getWriter
				/// </java-name>
				public virtual global::Java.Io.Writer Writer
				{
						[Dot42.DexImport("getWriter", "()Ljava/io/Writer;", AccessFlags = 1)]
						get{ return default(global::Java.Io.Writer); }
						[Dot42.DexImport("setWriter", "(Ljava/io/Writer;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getSystemId
				/// </java-name>
				public virtual string SystemId
				{
						[Dot42.DexImport("getSystemId", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
						[Dot42.DexImport("setSystemId", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ }
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
				/// setSystemId
				/// </java-name>
				[Dot42.DexImport("setSystemId", "(Ljava/io/File;)V", AccessFlags = 1)]
				public virtual void SetSystemId(global::Java.Io.File file) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getInputStream
				/// </java-name>
				public virtual global::Java.Io.InputStream InputStream
				{
						[Dot42.DexImport("getInputStream", "()Ljava/io/InputStream;", AccessFlags = 1)]
						get{ return default(global::Java.Io.InputStream); }
						[Dot42.DexImport("setInputStream", "(Ljava/io/InputStream;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getReader
				/// </java-name>
				public virtual global::Java.Io.Reader Reader
				{
						[Dot42.DexImport("getReader", "()Ljava/io/Reader;", AccessFlags = 1)]
						get{ return default(global::Java.Io.Reader); }
						[Dot42.DexImport("setReader", "(Ljava/io/Reader;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getPublicId
				/// </java-name>
				public virtual string PublicId
				{
						[Dot42.DexImport("getPublicId", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
						[Dot42.DexImport("setPublicId", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getSystemId
				/// </java-name>
				public virtual string SystemId
				{
						[Dot42.DexImport("getSystemId", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
						[Dot42.DexImport("setSystemId", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ }
				}

		}

}

