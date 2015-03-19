// Copyright (C) 2014 dot42
//
// Original filename: Javax.Xml.Transform.Stream.cs
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
namespace Javax.Xml.Transform.Stream
{
		/// <summary>
		/// <para>Acts as an holder for a transformation Source in the form of a stream of XML markup.</para><para><b>Note:</b> Due to their internal use of either a Reader or InputStream instance, <code>StreamSource</code> instances may only be used once.</para><para><para> </para><para></para><title>Revision:</title><para>829971 </para>, <title>Date:</title><para>2009-10-26 14:15:39 -0700 (Mon, 26 Oct 2009) </para></para>    
		/// </summary>
		/// <java-name>
		/// javax/xml/transform/stream/StreamSource
		/// </java-name>
		[Dot42.DexImport("javax/xml/transform/stream/StreamSource", AccessFlags = 33)]
		public partial class StreamSource : global::Javax.Xml.Transform.ISource
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>If javax.xml.transform.TransformerFactory#getFeature returns true when passed this value as an argument, the Transformer supports Source input of this type. </para>        
				/// </summary>
				/// <java-name>
				/// FEATURE
				/// </java-name>
				[Dot42.DexImport("FEATURE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string FEATURE = "http://javax.xml.transform.stream.StreamSource/feature";
				/// <summary>
				/// <para>Zero-argument default constructor. If this constructor is used, and no Stream source is set using setInputStream(java.io.InputStream inputStream) or setReader(java.io.Reader reader), then the <code>Transformer</code> will create an empty source java.io.InputStream using new InputStream().</para><para><para>javax.xml.transform.Transformer::transform(Source xmlSource, Result outputTarget) </para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public StreamSource() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Construct a StreamSource from a byte stream. Normally, a stream should be used rather than a reader, so the XML parser can resolve character encoding specified by the XML declaration.</para><para>If this constructor is used to process a stylesheet, normally setSystemId should also be called, so that relative URI references can be resolved.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/io/InputStream;)V", AccessFlags = 1)]
				public StreamSource(global::Java.Io.InputStream inputStream) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/io/InputStream;Ljava/lang/String;)V", AccessFlags = 1)]
				public StreamSource(global::Java.Io.InputStream inputStream, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Construct a StreamSource from a byte stream. Normally, a stream should be used rather than a reader, so the XML parser can resolve character encoding specified by the XML declaration.</para><para>If this constructor is used to process a stylesheet, normally setSystemId should also be called, so that relative URI references can be resolved.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/io/Reader;)V", AccessFlags = 1)]
				public StreamSource(global::Java.Io.Reader inputStream) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/io/Reader;Ljava/lang/String;)V", AccessFlags = 1)]
				public StreamSource(global::Java.Io.Reader reader, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Construct a StreamSource from a byte stream. Normally, a stream should be used rather than a reader, so the XML parser can resolve character encoding specified by the XML declaration.</para><para>If this constructor is used to process a stylesheet, normally setSystemId should also be called, so that relative URI references can be resolved.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public StreamSource(string inputStream) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Construct a StreamSource from a byte stream. Normally, a stream should be used rather than a reader, so the XML parser can resolve character encoding specified by the XML declaration.</para><para>If this constructor is used to process a stylesheet, normally setSystemId should also be called, so that relative URI references can be resolved.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/io/File;)V", AccessFlags = 1)]
				public StreamSource(global::Java.Io.File inputStream) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Set the byte stream to be used as input. Normally, a stream should be used rather than a reader, so that the XML parser can resolve character encoding specified by the XML declaration.</para><para>If this Source object is used to process a stylesheet, normally setSystemId should also be called, so that relative URL references can be resolved.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setInputStream
				/// </java-name>
				[Dot42.DexImport("setInputStream", "(Ljava/io/InputStream;)V", AccessFlags = 1)]
				public virtual void SetInputStream(global::Java.Io.InputStream inputStream) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Get the byte stream that was set with setByteStream.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The byte stream that was set with setByteStream, or null if setByteStream or the ByteStream constructor was not called. </para>
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
				/// <para>Set the input to be a character reader. Normally, a stream should be used rather than a reader, so that the XML parser can resolve character encoding specified by the XML declaration. However, in many cases the encoding of the input stream is already resolved, as in the case of reading XML from a StringReader.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setReader
				/// </java-name>
				[Dot42.DexImport("setReader", "(Ljava/io/Reader;)V", AccessFlags = 1)]
				public virtual void SetReader(global::Java.Io.Reader reader) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Get the character stream that was set with setReader.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The character stream that was set with setReader, or null if setReader or the Reader constructor was not called. </para>
				/// </returns>
				/// <java-name>
				/// getReader
				/// </java-name>
				[Dot42.DexImport("getReader", "()Ljava/io/Reader;", AccessFlags = 1)]
				public virtual global::Java.Io.Reader GetReader() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.Reader);
				}

				/// <summary>
				/// <para>Set the public identifier for this Source.</para><para>The public identifier is always optional: if the application writer includes one, it will be provided as part of the location information.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setPublicId
				/// </java-name>
				[Dot42.DexImport("setPublicId", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetPublicId(string publicId) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Get the public identifier that was set with setPublicId.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The public identifier that was set with setPublicId, or null if setPublicId was not called. </para>
				/// </returns>
				/// <java-name>
				/// getPublicId
				/// </java-name>
				[Dot42.DexImport("getPublicId", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetPublicId() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Set the system ID from a File reference.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setSystemId
				/// </java-name>
				[Dot42.DexImport("setSystemId", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetSystemId(string f) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Get the system identifier that was set with setSystemId.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The system identifier that was set with setSystemId, or null if setSystemId was not called. </para>
				/// </returns>
				/// <java-name>
				/// getSystemId
				/// </java-name>
				[Dot42.DexImport("getSystemId", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetSystemId() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Set the system ID from a File reference.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setSystemId
				/// </java-name>
				[Dot42.DexImport("setSystemId", "(Ljava/io/File;)V", AccessFlags = 1)]
				public virtual void SetSystemId(global::Java.Io.File f) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Get the byte stream that was set with setByteStream.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The byte stream that was set with setByteStream, or null if setByteStream or the ByteStream constructor was not called. </para>
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
				/// <para>Get the character stream that was set with setReader.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The character stream that was set with setReader, or null if setReader or the Reader constructor was not called. </para>
				/// </returns>
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

				/// <summary>
				/// <para>Get the public identifier that was set with setPublicId.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The public identifier that was set with setPublicId, or null if setPublicId was not called. </para>
				/// </returns>
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

				/// <summary>
				/// <para>Get the system identifier that was set with setSystemId.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The system identifier that was set with setSystemId, or null if setSystemId was not called. </para>
				/// </returns>
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

		/// <summary>
		/// <para>Acts as an holder for a transformation result, which may be XML, plain Text, HTML, or some other form of markup.</para><para><para> </para></para>    
		/// </summary>
		/// <java-name>
		/// javax/xml/transform/stream/StreamResult
		/// </java-name>
		[Dot42.DexImport("javax/xml/transform/stream/StreamResult", AccessFlags = 33)]
		public partial class StreamResult : global::Javax.Xml.Transform.IResult
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>If javax.xml.transform.TransformerFactory#getFeature returns true when passed this value as an argument, the Transformer supports Result output of this type. </para>        
				/// </summary>
				/// <java-name>
				/// FEATURE
				/// </java-name>
				[Dot42.DexImport("FEATURE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string FEATURE = "http://javax.xml.transform.stream.StreamResult/feature";
				/// <summary>
				/// <para>Zero-argument default constructor. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public StreamResult() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Construct a StreamResult from a byte stream. Normally, a stream should be used rather than a reader, so that the transformer may use instructions contained in the transformation instructions to control the encoding.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/io/OutputStream;)V", AccessFlags = 1)]
				public StreamResult(global::Java.Io.OutputStream outputStream) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Construct a StreamResult from a byte stream. Normally, a stream should be used rather than a reader, so that the transformer may use instructions contained in the transformation instructions to control the encoding.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/io/Writer;)V", AccessFlags = 1)]
				public StreamResult(global::Java.Io.Writer outputStream) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Construct a StreamResult from a byte stream. Normally, a stream should be used rather than a reader, so that the transformer may use instructions contained in the transformation instructions to control the encoding.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public StreamResult(string outputStream) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Construct a StreamResult from a byte stream. Normally, a stream should be used rather than a reader, so that the transformer may use instructions contained in the transformation instructions to control the encoding.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/io/File;)V", AccessFlags = 1)]
				public StreamResult(global::Java.Io.File outputStream) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Set the ByteStream that is to be written to. Normally, a stream should be used rather than a reader, so that the transformer may use instructions contained in the transformation instructions to control the encoding.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setOutputStream
				/// </java-name>
				[Dot42.DexImport("setOutputStream", "(Ljava/io/OutputStream;)V", AccessFlags = 1)]
				public virtual void SetOutputStream(global::Java.Io.OutputStream outputStream) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Get the byte stream that was set with setOutputStream.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The byte stream that was set with setOutputStream, or null if setOutputStream or the ByteStream constructor was not called. </para>
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
				/// <para>Set the writer that is to receive the result. Normally, a stream should be used rather than a writer, so that the transformer may use instructions contained in the transformation instructions to control the encoding. However, there are times when it is useful to write to a writer, such as when using a StringWriter.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setWriter
				/// </java-name>
				[Dot42.DexImport("setWriter", "(Ljava/io/Writer;)V", AccessFlags = 1)]
				public virtual void SetWriter(global::Java.Io.Writer writer) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Get the character stream that was set with setWriter.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The character stream that was set with setWriter, or null if setWriter or the Writer constructor was not called. </para>
				/// </returns>
				/// <java-name>
				/// getWriter
				/// </java-name>
				[Dot42.DexImport("getWriter", "()Ljava/io/Writer;", AccessFlags = 1)]
				public virtual global::Java.Io.Writer GetWriter() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.Writer);
				}

				/// <summary>
				/// <para>Set the system ID from a <code>File</code> reference.</para><para>Note the use of File#toURI() and File#toURL(). <code>toURI()</code> is preferred and used if possible. To allow JAXP 1.3 to run on J2SE 1.3, <code>toURL()</code> is used if a NoSuchMethodException is thrown by the attempt to use <code>toURI()</code>.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setSystemId
				/// </java-name>
				[Dot42.DexImport("setSystemId", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetSystemId(string f) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Set the system ID from a <code>File</code> reference.</para><para>Note the use of File#toURI() and File#toURL(). <code>toURI()</code> is preferred and used if possible. To allow JAXP 1.3 to run on J2SE 1.3, <code>toURL()</code> is used if a NoSuchMethodException is thrown by the attempt to use <code>toURI()</code>.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setSystemId
				/// </java-name>
				[Dot42.DexImport("setSystemId", "(Ljava/io/File;)V", AccessFlags = 1)]
				public virtual void SetSystemId(global::Java.Io.File f) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Get the system identifier that was set with setSystemId.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The system identifier that was set with setSystemId, or null if setSystemId was not called. </para>
				/// </returns>
				/// <java-name>
				/// getSystemId
				/// </java-name>
				[Dot42.DexImport("getSystemId", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetSystemId() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Get the byte stream that was set with setOutputStream.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The byte stream that was set with setOutputStream, or null if setOutputStream or the ByteStream constructor was not called. </para>
				/// </returns>
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

				/// <summary>
				/// <para>Get the character stream that was set with setWriter.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The character stream that was set with setWriter, or null if setWriter or the Writer constructor was not called. </para>
				/// </returns>
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

				/// <summary>
				/// <para>Get the system identifier that was set with setSystemId.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The system identifier that was set with setSystemId, or null if setSystemId was not called. </para>
				/// </returns>
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


