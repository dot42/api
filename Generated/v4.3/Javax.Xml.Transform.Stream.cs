#pragma warning disable 1717
namespace Javax.Xml.Transform.Stream
{
		/// <summary>
		///  <para>Acts as an holder for a transformation result, which may be XML, plain Text, HTML, or some other form of markup.</para> <para> <para> </para></para>    
		/// </summary>
		/// <java-name>
		/// javax/xml/transform/stream/StreamResult
		/// </java-name>
		[Dot42.DexImport("javax/xml/transform/stream/StreamResult", AccessFlags = 33)]
		public partial class StreamResult : global::Javax.Xml.Transform.IResult
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>If javax.xml.transform.TransformerFactory#getFeature returns true when passed this value as an argument, the Transformer supports Result output of this type. </para>        
				/// </summary>
				/// <java-name>
				/// FEATURE
				/// </java-name>
				[Dot42.DexImport("FEATURE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string FEATURE = "http://javax.xml.transform.stream.StreamResult/feature";
				/// <summary>
				///  <para>Zero-argument default constructor. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public StreamResult() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Construct a StreamResult from a byte stream. Normally, a stream should be used rather than a reader, so that the transformer may use instructions contained in the transformation instructions to control the encoding.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/io/OutputStream;)V", AccessFlags = 1)]
				public StreamResult(global::Java.IO.OutputStream outputStream) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Construct a StreamResult from a byte stream. Normally, a stream should be used rather than a reader, so that the transformer may use instructions contained in the transformation instructions to control the encoding.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/io/Writer;)V", AccessFlags = 1)]
				public StreamResult(global::Java.IO.Writer outputStream) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Construct a StreamResult from a byte stream. Normally, a stream should be used rather than a reader, so that the transformer may use instructions contained in the transformation instructions to control the encoding.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public StreamResult(string outputStream) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Construct a StreamResult from a byte stream. Normally, a stream should be used rather than a reader, so that the transformer may use instructions contained in the transformation instructions to control the encoding.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/io/File;)V", AccessFlags = 1)]
				public StreamResult(global::Java.IO.File outputStream) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Set the system ID from a  <code>File</code> reference.</para> <para>Note the use of File#toURI() and File#toURL().  <code>toURI()</code> is preferred and used if possible. To allow JAXP 1.3 to run on J2SE 1.3,  <code>toURL()</code> is used if a NoSuchMethodException is thrown by the attempt to use  <code>toURI()</code>.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setSystemId
				/// </java-name>
				[Dot42.DexImport("setSystemId", "(Ljava/io/File;)V", AccessFlags = 1)]
				public virtual void SetSystemId(global::Java.IO.File f) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Get the byte stream that was set with setOutputStream.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The byte stream that was set with setOutputStream, or null if setOutputStream or the ByteStream constructor was not called. </para>
				/// </returns>
				/// <java-name>
				/// getOutputStream
				/// </java-name>
				public virtual global::Java.IO.OutputStream OutputStream
				{
						[Dot42.DexImport("getOutputStream", "()Ljava/io/OutputStream;", AccessFlags = 1)]
						get{ return default(global::Java.IO.OutputStream); }
						[Dot42.DexImport("setOutputStream", "(Ljava/io/OutputStream;)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Get the character stream that was set with setWriter.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The character stream that was set with setWriter, or null if setWriter or the Writer constructor was not called. </para>
				/// </returns>
				/// <java-name>
				/// getWriter
				/// </java-name>
				public virtual global::Java.IO.Writer Writer
				{
						[Dot42.DexImport("getWriter", "()Ljava/io/Writer;", AccessFlags = 1)]
						get{ return default(global::Java.IO.Writer); }
						[Dot42.DexImport("setWriter", "(Ljava/io/Writer;)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Get the system identifier that was set with setSystemId.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The system identifier that was set with setSystemId, or null if setSystemId was not called. </para>
				/// </returns>
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

		/// <summary>
		///  <para>Acts as an holder for a transformation Source in the form of a stream of XML markup.</para> <para> <b>Note:</b> Due to their internal use of either a Reader or InputStream instance,  <code>StreamSource</code> instances may only be used once.</para> <para> <para> </para> <para></para> <title>Revision</title> <para>829971 </para>,  <title>Date</title> <para>2009-10-26 14:15:39 -0700 (Mon, 26 Oct 2009) </para></para>    
		/// </summary>
		/// <java-name>
		/// javax/xml/transform/stream/StreamSource
		/// </java-name>
		[Dot42.DexImport("javax/xml/transform/stream/StreamSource", AccessFlags = 33)]
		public partial class StreamSource : global::Javax.Xml.Transform.ISource
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>If javax.xml.transform.TransformerFactory#getFeature returns true when passed this value as an argument, the Transformer supports Source input of this type. </para>        
				/// </summary>
				/// <java-name>
				/// FEATURE
				/// </java-name>
				[Dot42.DexImport("FEATURE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string FEATURE = "http://javax.xml.transform.stream.StreamSource/feature";
				/// <summary>
				///  <para>Zero-argument default constructor. If this constructor is used, and no Stream source is set using setInputStream(java.io.InputStream inputStream) or setReader(java.io.Reader reader), then the  <code>Transformer</code> will create an empty source java.io.InputStream using new InputStream().</para> <para> <para>javax.xml.transform.Transformer::transform(Source xmlSource, Result outputTarget) </para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public StreamSource() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Construct a StreamSource from a byte stream. Normally, a stream should be used rather than a reader, so the XML parser can resolve character encoding specified by the XML declaration.</para> <para>If this constructor is used to process a stylesheet, normally setSystemId should also be called, so that relative URI references can be resolved.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/io/InputStream;)V", AccessFlags = 1)]
				public StreamSource(global::Java.IO.InputStream inputStream) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/io/InputStream;Ljava/lang/String;)V", AccessFlags = 1)]
				public StreamSource(global::Java.IO.InputStream inputStream, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Construct a StreamSource from a byte stream. Normally, a stream should be used rather than a reader, so the XML parser can resolve character encoding specified by the XML declaration.</para> <para>If this constructor is used to process a stylesheet, normally setSystemId should also be called, so that relative URI references can be resolved.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/io/Reader;)V", AccessFlags = 1)]
				public StreamSource(global::Java.IO.Reader inputStream) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/io/Reader;Ljava/lang/String;)V", AccessFlags = 1)]
				public StreamSource(global::Java.IO.Reader reader, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Construct a StreamSource from a byte stream. Normally, a stream should be used rather than a reader, so the XML parser can resolve character encoding specified by the XML declaration.</para> <para>If this constructor is used to process a stylesheet, normally setSystemId should also be called, so that relative URI references can be resolved.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public StreamSource(string inputStream) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Construct a StreamSource from a byte stream. Normally, a stream should be used rather than a reader, so the XML parser can resolve character encoding specified by the XML declaration.</para> <para>If this constructor is used to process a stylesheet, normally setSystemId should also be called, so that relative URI references can be resolved.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/io/File;)V", AccessFlags = 1)]
				public StreamSource(global::Java.IO.File inputStream) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Set the system ID from a File reference.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setSystemId
				/// </java-name>
				[Dot42.DexImport("setSystemId", "(Ljava/io/File;)V", AccessFlags = 1)]
				public virtual void SetSystemId(global::Java.IO.File f) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Get the byte stream that was set with setByteStream.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The byte stream that was set with setByteStream, or null if setByteStream or the ByteStream constructor was not called. </para>
				/// </returns>
				/// <java-name>
				/// getInputStream
				/// </java-name>
				public virtual global::Java.IO.InputStream InputStream
				{
						[Dot42.DexImport("getInputStream", "()Ljava/io/InputStream;", AccessFlags = 1)]
						get{ return default(global::Java.IO.InputStream); }
						[Dot42.DexImport("setInputStream", "(Ljava/io/InputStream;)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Get the character stream that was set with setReader.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The character stream that was set with setReader, or null if setReader or the Reader constructor was not called. </para>
				/// </returns>
				/// <java-name>
				/// getReader
				/// </java-name>
				public virtual global::Java.IO.Reader Reader
				{
						[Dot42.DexImport("getReader", "()Ljava/io/Reader;", AccessFlags = 1)]
						get{ return default(global::Java.IO.Reader); }
						[Dot42.DexImport("setReader", "(Ljava/io/Reader;)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Get the public identifier that was set with setPublicId.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The public identifier that was set with setPublicId, or null if setPublicId was not called. </para>
				/// </returns>
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

				/// <summary>
				///  <para>Get the system identifier that was set with setSystemId.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The system identifier that was set with setSystemId, or null if setSystemId was not called. </para>
				/// </returns>
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

