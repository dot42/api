// Copyright (C) 2014 dot42
//
// Original filename: Org.Apache.Http.Impl.Io.cs
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
namespace Org.Apache.Http.Impl.Io
{
		/// <summary>
		/// <para>Socket bound session input buffer.</para><para><para></para><para></para><title>Revision:</title><para>560358 </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/impl/io/SocketInputBuffer
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/io/SocketInputBuffer", AccessFlags = 33)]
		public partial class SocketInputBuffer : global::Org.Apache.Http.Impl.Io.AbstractSessionInputBuffer
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/net/Socket;ILorg/apache/http/params/HttpParams;)V", AccessFlags = 1)]
				public SocketInputBuffer(global::Java.Net.Socket socket, int buffersize, global::Org.Apache.Http.Params.IHttpParams @params) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isDataAvailable
				/// </java-name>
				[Dot42.DexImport("isDataAvailable", "(I)Z", AccessFlags = 1)]
				public override bool IsDataAvailable(int timeout) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal SocketInputBuffer() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		/// <para>A stream for writing with an "identity" transport encoding.</para><para><para></para><para></para><title>Revision:</title><para>560343 </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/impl/io/IdentityOutputStream
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/io/IdentityOutputStream", AccessFlags = 33)]
		public partial class IdentityOutputStream : global::Java.Io.OutputStream
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Lorg/apache/http/io/SessionOutputBuffer;)V", AccessFlags = 1)]
				public IdentityOutputStream(global::Org.Apache.Http.Io.ISessionOutputBuffer @out) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Does not close the underlying socket output.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1)]
				public override void Close() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Flushes this stream. Implementations of this method should ensure that any buffered data is written out. This implementation does nothing.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// flush
				/// </java-name>
				[Dot42.DexImport("flush", "()V", AccessFlags = 1)]
				public override void Flush() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Writes <c> count </c> bytes from the byte array <c> buffer </c> starting at position <c> offset </c> to this stream.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([BII)V", AccessFlags = 1)]
				public override void Write(sbyte[] buffer, int offset, int count) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Writes <c> count </c> bytes from the byte array <c> buffer </c> starting at position <c> offset </c> to this stream.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([BII)V", AccessFlags = 1, IgnoreFromJava = true)]
				public override void Write(byte[] buffer, int offset, int count) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Writes a single byte to this stream. Only the least significant byte of the integer <c> oneByte </c> is written to the stream.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([B)V", AccessFlags = 1)]
				public override void Write(sbyte[] oneByte) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Writes a single byte to this stream. Only the least significant byte of the integer <c> oneByte </c> is written to the stream.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public override void Write(byte[] oneByte) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Writes a single byte to this stream. Only the least significant byte of the integer <c> oneByte </c> is written to the stream.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "(I)V", AccessFlags = 1)]
				public override void Write(int oneByte) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal IdentityOutputStream() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		/// <para>Implements chunked transfer coding. See , . Writes are buffered to an internal buffer (2048 default size).</para><para><para>Mohammad Rezaei (Goldman, Sachs &amp; Co.) </para><simplesectsep></simplesectsep><para></para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/impl/io/ChunkedOutputStream
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/io/ChunkedOutputStream", AccessFlags = 33)]
		public partial class ChunkedOutputStream : global::Java.Io.OutputStream
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Wraps a session output buffer and chunks the output. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Lorg/apache/http/io/SessionOutputBuffer;I)V", AccessFlags = 1)]
				public ChunkedOutputStream(global::Org.Apache.Http.Io.ISessionOutputBuffer @out, int bufferSize) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Wraps a session output buffer and chunks the output. The default buffer size of 2048 was chosen because the chunk overhead is less than 0.5%</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Lorg/apache/http/io/SessionOutputBuffer;)V", AccessFlags = 1)]
				public ChunkedOutputStream(global::Org.Apache.Http.Io.ISessionOutputBuffer @out) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Writes the cache out onto the underlying stream </para>        
				/// </summary>
				/// <java-name>
				/// flushCache
				/// </java-name>
				[Dot42.DexImport("flushCache", "()V", AccessFlags = 4)]
				protected internal virtual void FlushCache() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Writes the cache and bufferToAppend to the underlying stream as one large chunk </para>        
				/// </summary>
				/// <java-name>
				/// flushCacheWithAppend
				/// </java-name>
				[Dot42.DexImport("flushCacheWithAppend", "([BII)V", AccessFlags = 4)]
				protected internal virtual void FlushCacheWithAppend(sbyte[] bufferToAppend, int off, int len) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Writes the cache and bufferToAppend to the underlying stream as one large chunk </para>        
				/// </summary>
				/// <java-name>
				/// flushCacheWithAppend
				/// </java-name>
				[Dot42.DexImport("flushCacheWithAppend", "([BII)V", AccessFlags = 4, IgnoreFromJava = true)]
				protected internal virtual void FlushCacheWithAppend(byte[] bufferToAppend, int off, int len) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writeClosingChunk
				/// </java-name>
				[Dot42.DexImport("writeClosingChunk", "()V", AccessFlags = 4)]
				protected internal virtual void WriteClosingChunk() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Must be called to ensure the internal cache is flushed and the closing chunk is written. </para>        
				/// </summary>
				/// <java-name>
				/// finish
				/// </java-name>
				[Dot42.DexImport("finish", "()V", AccessFlags = 1)]
				public virtual void Finish() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Writes a single byte to this stream. Only the least significant byte of the integer <c> oneByte </c> is written to the stream.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "(I)V", AccessFlags = 1)]
				public override void Write(int oneByte) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Writes a single byte to this stream. Only the least significant byte of the integer <c> oneByte </c> is written to the stream.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([B)V", AccessFlags = 1)]
				public override void Write(sbyte[] oneByte) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Writes a single byte to this stream. Only the least significant byte of the integer <c> oneByte </c> is written to the stream.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public override void Write(byte[] oneByte) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Writes <c> count </c> bytes from the byte array <c> buffer </c> starting at position <c> offset </c> to this stream.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([BII)V", AccessFlags = 1)]
				public override void Write(sbyte[] buffer, int offset, int count) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Writes <c> count </c> bytes from the byte array <c> buffer </c> starting at position <c> offset </c> to this stream.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([BII)V", AccessFlags = 1, IgnoreFromJava = true)]
				public override void Write(byte[] buffer, int offset, int count) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Flushes the content buffer and the underlying stream. </para>        
				/// </summary>
				/// <java-name>
				/// flush
				/// </java-name>
				[Dot42.DexImport("flush", "()V", AccessFlags = 1)]
				public override void Flush() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Finishes writing to the underlying stream, but does NOT close the underlying stream. </para>        
				/// </summary>
				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1)]
				public override void Close() /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ChunkedOutputStream() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		/// <para>Message parser base class.</para><para><para>Michael Becke </para><simplesectsep></simplesectsep><para> </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/impl/io/AbstractMessageParser
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/io/AbstractMessageParser", AccessFlags = 1057)]
		public abstract partial class AbstractMessageParser : global::Org.Apache.Http.Io.IHttpMessageParser
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// lineParser
				/// </java-name>
				[Dot42.DexImport("lineParser", "Lorg/apache/http/message/LineParser;", AccessFlags = 20)]
				protected internal readonly global::Org.Apache.Http.Message.ILineParser LineParser;
				[Dot42.DexImport("<init>", "(Lorg/apache/http/io/SessionInputBuffer;Lorg/apache/http/message/LineParser;Lorg/" +
    "apache/http/params/HttpParams;)V", AccessFlags = 1)]
				public AbstractMessageParser(global::Org.Apache.Http.Io.ISessionInputBuffer buffer, global::Org.Apache.Http.Message.ILineParser parser, global::Org.Apache.Http.Params.IHttpParams @params) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Parses HTTP headers from the data receiver stream according to the generic format as given in Section 3.1 of RFC 822, RFC-2616 Section 4 and 19.3.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>array of HTTP headers</para>
				/// </returns>
				/// <java-name>
				/// parseHeaders
				/// </java-name>
				[Dot42.DexImport("parseHeaders", "(Lorg/apache/http/io/SessionInputBuffer;IILorg/apache/http/message/LineParser;)[L" +
    "org/apache/http/Header;", AccessFlags = 9)]
				public static global::Org.Apache.Http.IHeader[] ParseHeaders(global::Org.Apache.Http.Io.ISessionInputBuffer inbuffer, int maxHeaderCount, int maxLineLen, global::Org.Apache.Http.Message.ILineParser parser) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IHeader[]);
				}

				/// <java-name>
				/// parseHead
				/// </java-name>
				[Dot42.DexImport("parseHead", "(Lorg/apache/http/io/SessionInputBuffer;)Lorg/apache/http/HttpMessage;", AccessFlags = 1028)]
				protected internal abstract global::Org.Apache.Http.IHttpMessage ParseHead(global::Org.Apache.Http.Io.ISessionInputBuffer sessionBuffer) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// parse
				/// </java-name>
				[Dot42.DexImport("parse", "()Lorg/apache/http/HttpMessage;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.IHttpMessage Parse() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IHttpMessage);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal AbstractMessageParser() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		/// <para>Abstract base class for session output buffers that stream data to an OutputStream.</para><para><para> </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/impl/io/AbstractSessionOutputBuffer
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/io/AbstractSessionOutputBuffer", AccessFlags = 1057)]
		public abstract partial class AbstractSessionOutputBuffer : global::Org.Apache.Http.Io.ISessionOutputBuffer
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public AbstractSessionOutputBuffer() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// init
				/// </java-name>
				[Dot42.DexImport("init", "(Ljava/io/OutputStream;ILorg/apache/http/params/HttpParams;)V", AccessFlags = 4)]
				protected internal virtual void Init(global::Java.Io.OutputStream outstream, int buffersize, global::Org.Apache.Http.Params.IHttpParams @params) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// flushBuffer
				/// </java-name>
				[Dot42.DexImport("flushBuffer", "()V", AccessFlags = 4)]
				protected internal virtual void FlushBuffer() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// flush
				/// </java-name>
				[Dot42.DexImport("flush", "()V", AccessFlags = 1)]
				public virtual void Flush() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([BII)V", AccessFlags = 1)]
				public virtual void Write(sbyte[] b, int off, int len) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([BII)V", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual void Write(byte[] b, int off, int len) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([B)V", AccessFlags = 1)]
				public virtual void Write(sbyte[] b) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual void Write(byte[] b) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "(I)V", AccessFlags = 1)]
				public virtual void Write(int b) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writeLine
				/// </java-name>
				[Dot42.DexImport("writeLine", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void WriteLine(string s) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writeLine
				/// </java-name>
				[Dot42.DexImport("writeLine", "(Lorg/apache/http/util/CharArrayBuffer;)V", AccessFlags = 1)]
				public virtual void WriteLine(global::Org.Apache.Http.Util.CharArrayBuffer s) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getMetrics
				/// </java-name>
				[Dot42.DexImport("getMetrics", "()Lorg/apache/http/io/HttpTransportMetrics;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.Io.IHttpTransportMetrics GetMetrics() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Io.IHttpTransportMetrics);
				}

				/// <java-name>
				/// getMetrics
				/// </java-name>
				public global::Org.Apache.Http.Io.IHttpTransportMetrics Metrics
				{
				[Dot42.DexImport("getMetrics", "()Lorg/apache/http/io/HttpTransportMetrics;", AccessFlags = 1)]
						get{ return GetMetrics(); }
				}

		}

		/// <summary>
		/// <para>Stream that cuts off after a specified number of bytes. Note that this class NEVER closes the underlying stream, even when close gets called. Instead, it will read until the "end" of its chunking on close, which allows for the seamless execution of subsequent HTTP 1.1 requests, while not requiring the client to remember to read the entire contents of the response.</para><para>Implementation note: Choices abound. One approach would pass through the InputStream#mark and InputStream#reset calls to the underlying stream. That's tricky, though, because you then have to start duplicating the work of keeping track of how much a reset rewinds. Further, you have to watch out for the "readLimit", and since the semantics for the readLimit leave room for differing implementations, you might get into a lot of trouble.</para><para>Alternatively, you could make this class extend java.io.BufferedInputStream and then use the protected members of that class to avoid duplicated effort. That solution has the side effect of adding yet another possible layer of buffering.</para><para>Then, there is the simple choice, which this takes - simply don't support InputStream#mark and InputStream#reset. That choice has the added benefit of keeping this class very simple.</para><para><para>Ortwin Glueck </para><simplesectsep></simplesectsep><para>Eric Johnson </para><simplesectsep></simplesectsep><para></para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/impl/io/ContentLengthInputStream
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/io/ContentLengthInputStream", AccessFlags = 33)]
		public partial class ContentLengthInputStream : global::Java.Io.InputStream
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new length limited stream</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Lorg/apache/http/io/SessionInputBuffer;J)V", AccessFlags = 1)]
				public ContentLengthInputStream(global::Org.Apache.Http.Io.ISessionInputBuffer @in, long contentLength) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Reads until the end of the known length of content.</para><para>Does not close the underlying socket input, but instead leaves it primed to parse the next response.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1)]
				public override void Close() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Read the next byte from the stream <para>java.io.InputStream::read() </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The next byte or -1 if the end of stream has been reached. </para>
				/// </returns>
				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "()I", AccessFlags = 1)]
				public override int Read() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Does standard InputStream#read(byte[], int, int) behavior, but also notifies the watcher when the contents have been consumed.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The number of bytes read, or -1 if the end of content has been reached.</para>
				/// </returns>
				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([BII)I", AccessFlags = 1)]
				public override int Read(sbyte[] b, int off, int len) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Does standard InputStream#read(byte[], int, int) behavior, but also notifies the watcher when the contents have been consumed.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The number of bytes read, or -1 if the end of content has been reached.</para>
				/// </returns>
				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([BII)I", AccessFlags = 1, IgnoreFromJava = true)]
				public override int Read(byte[] b, int off, int len) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Read more bytes from the stream. <para>java.io.InputStream::read(byte[]) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The number of bytes read into the buffer. </para>
				/// </returns>
				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([B)I", AccessFlags = 1)]
				public override int Read(sbyte[] b) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Read more bytes from the stream. <para>java.io.InputStream::read(byte[]) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The number of bytes read into the buffer. </para>
				/// </returns>
				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([B)I", AccessFlags = 1, IgnoreFromJava = true)]
				public override int Read(byte[] b) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Skips and discards a number of bytes from the input stream. <para>InputStream::skip(long) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The actual number of bytes skipped. &lt;= 0 if no bytes are skipped. </para>
				/// </returns>
				/// <java-name>
				/// skip
				/// </java-name>
				[Dot42.DexImport("skip", "(J)J", AccessFlags = 1)]
				public override long Skip(long n) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ContentLengthInputStream() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// org/apache/http/impl/io/HttpRequestWriter
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/io/HttpRequestWriter", AccessFlags = 33)]
		public partial class HttpRequestWriter : global::Org.Apache.Http.Impl.Io.AbstractMessageWriter
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Lorg/apache/http/io/SessionOutputBuffer;Lorg/apache/http/message/LineFormatter;L" +
    "org/apache/http/params/HttpParams;)V", AccessFlags = 1)]
				public HttpRequestWriter(global::Org.Apache.Http.Io.ISessionOutputBuffer buffer, global::Org.Apache.Http.Message.ILineFormatter formatter, global::Org.Apache.Http.Params.IHttpParams @params) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writeHeadLine
				/// </java-name>
				[Dot42.DexImport("writeHeadLine", "(Lorg/apache/http/HttpMessage;)V", AccessFlags = 4)]
				protected internal override void WriteHeadLine(global::Org.Apache.Http.IHttpMessage message) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal HttpRequestWriter() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// org/apache/http/impl/io/AbstractMessageWriter
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/io/AbstractMessageWriter", AccessFlags = 1057)]
		public abstract partial class AbstractMessageWriter : global::Org.Apache.Http.Io.IHttpMessageWriter
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// sessionBuffer
				/// </java-name>
				[Dot42.DexImport("sessionBuffer", "Lorg/apache/http/io/SessionOutputBuffer;", AccessFlags = 20)]
				protected internal readonly global::Org.Apache.Http.Io.ISessionOutputBuffer SessionBuffer;
				/// <java-name>
				/// lineBuf
				/// </java-name>
				[Dot42.DexImport("lineBuf", "Lorg/apache/http/util/CharArrayBuffer;", AccessFlags = 20)]
				protected internal readonly global::Org.Apache.Http.Util.CharArrayBuffer LineBuf;
				/// <java-name>
				/// lineFormatter
				/// </java-name>
				[Dot42.DexImport("lineFormatter", "Lorg/apache/http/message/LineFormatter;", AccessFlags = 20)]
				protected internal readonly global::Org.Apache.Http.Message.ILineFormatter LineFormatter;
				[Dot42.DexImport("<init>", "(Lorg/apache/http/io/SessionOutputBuffer;Lorg/apache/http/message/LineFormatter;L" +
    "org/apache/http/params/HttpParams;)V", AccessFlags = 1)]
				public AbstractMessageWriter(global::Org.Apache.Http.Io.ISessionOutputBuffer buffer, global::Org.Apache.Http.Message.ILineFormatter formatter, global::Org.Apache.Http.Params.IHttpParams @params) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writeHeadLine
				/// </java-name>
				[Dot42.DexImport("writeHeadLine", "(Lorg/apache/http/HttpMessage;)V", AccessFlags = 1028)]
				protected internal abstract void WriteHeadLine(global::Org.Apache.Http.IHttpMessage message) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "(Lorg/apache/http/HttpMessage;)V", AccessFlags = 1)]
				public virtual void Write(global::Org.Apache.Http.IHttpMessage message) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal AbstractMessageWriter() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// org/apache/http/impl/io/HttpRequestParser
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/io/HttpRequestParser", AccessFlags = 33)]
		public partial class HttpRequestParser : global::Org.Apache.Http.Impl.Io.AbstractMessageParser
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Lorg/apache/http/io/SessionInputBuffer;Lorg/apache/http/message/LineParser;Lorg/" +
    "apache/http/HttpRequestFactory;Lorg/apache/http/params/HttpParams;)V", AccessFlags = 1)]
				public HttpRequestParser(global::Org.Apache.Http.Io.ISessionInputBuffer buffer, global::Org.Apache.Http.Message.ILineParser parser, global::Org.Apache.Http.IHttpRequestFactory requestFactory, global::Org.Apache.Http.Params.IHttpParams @params) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// parseHead
				/// </java-name>
				[Dot42.DexImport("parseHead", "(Lorg/apache/http/io/SessionInputBuffer;)Lorg/apache/http/HttpMessage;", AccessFlags = 4)]
				protected internal override global::Org.Apache.Http.IHttpMessage ParseHead(global::Org.Apache.Http.Io.ISessionInputBuffer sessionBuffer) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IHttpMessage);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal HttpRequestParser() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		/// <para>A stream for reading from a session input buffer.</para><para><para></para><para></para><title>Revision:</title><para>560358 </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/impl/io/IdentityInputStream
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/io/IdentityInputStream", AccessFlags = 33)]
		public partial class IdentityInputStream : global::Java.Io.InputStream
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Lorg/apache/http/io/SessionInputBuffer;)V", AccessFlags = 1)]
				public IdentityInputStream(global::Org.Apache.Http.Io.ISessionInputBuffer @in) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns an estimated number of bytes that can be read or skipped without blocking for more input.</para><para>Note that this method provides such a weak guarantee that it is not very useful in practice.</para><para>Firstly, the guarantee is "without blocking for more input" rather than "without       blocking": a read may still block waiting for I/O to complete  the guarantee is merely that it won't have to wait indefinitely for data to be written. The result of this method should not be used as a license to do I/O on a thread that shouldn't be blocked.</para><para>Secondly, the result is a conservative estimate and may be significantly smaller than the actual number of bytes available. In particular, an implementation that always returns 0 would be correct. In general, callers should only use this method if they'd be satisfied with treating the result as a boolean yes or no answer to the question "is there definitely       data ready?".</para><para>Thirdly, the fact that a given number of bytes is "available" does not guarantee that a read or skip will actually read or skip that many bytes: they may read or skip fewer.</para><para>It is particularly important to realize that you <b>must not</b> use this method to size a container and assume that you can read the entirety of the stream without needing to resize the container. Such callers should probably write everything they read to a ByteArrayOutputStream and convert that to a byte array. Alternatively, if you're reading from a file, File#length returns the current length of the file (though assuming the file's length can't change may be incorrect, reading a file is inherently racy).</para><para>The default implementation of this method in <c> InputStream </c> always returns 0. Subclasses should override this method if they are able to indicate the number of bytes available.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the estimated number of bytes available </para>
				/// </returns>
				/// <java-name>
				/// available
				/// </java-name>
				[Dot42.DexImport("available", "()I", AccessFlags = 1)]
				public override int Available() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Closes this stream. Concrete implementations of this class should free any resources during close. This implementation does nothing.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1)]
				public override void Close() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Reads a single byte from this stream and returns it as an integer in the range from 0 to 255. Returns -1 if the end of the stream has been reached. Blocks until one byte has been read, the end of the source stream is detected or an exception is thrown.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the byte read or -1 if the end of stream has been reached. </para>
				/// </returns>
				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "()I", AccessFlags = 1)]
				public override int Read() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([BII)I", AccessFlags = 1)]
				public override int Read(sbyte[] b, int off, int len) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([BII)I", AccessFlags = 1, IgnoreFromJava = true)]
				public override int Read(byte[] b, int off, int len) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal IdentityInputStream() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		/// <para>Socket bound session output buffer.</para><para><para></para><para></para><title>Revision:</title><para>560358 </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/impl/io/SocketOutputBuffer
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/io/SocketOutputBuffer", AccessFlags = 33)]
		public partial class SocketOutputBuffer : global::Org.Apache.Http.Impl.Io.AbstractSessionOutputBuffer
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/net/Socket;ILorg/apache/http/params/HttpParams;)V", AccessFlags = 1)]
				public SocketOutputBuffer(global::Java.Net.Socket socket, int buffersize, global::Org.Apache.Http.Params.IHttpParams @params) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal SocketOutputBuffer() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		/// <para>Default implementation of HttpTransportMetrics. </para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/impl/io/HttpTransportMetricsImpl
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/io/HttpTransportMetricsImpl", AccessFlags = 33)]
		public partial class HttpTransportMetricsImpl : global::Org.Apache.Http.Io.IHttpTransportMetrics
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public HttpTransportMetricsImpl() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the number of bytes trasferred. </para>        
				/// </summary>
				/// <java-name>
				/// getBytesTransferred
				/// </java-name>
				[Dot42.DexImport("getBytesTransferred", "()J", AccessFlags = 1)]
				public virtual long GetBytesTransferred() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// setBytesTransferred
				/// </java-name>
				[Dot42.DexImport("setBytesTransferred", "(J)V", AccessFlags = 1)]
				public virtual void SetBytesTransferred(long count) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// incrementBytesTransferred
				/// </java-name>
				[Dot42.DexImport("incrementBytesTransferred", "(J)V", AccessFlags = 1)]
				public virtual void IncrementBytesTransferred(long count) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Resets the counts </para>        
				/// </summary>
				/// <java-name>
				/// reset
				/// </java-name>
				[Dot42.DexImport("reset", "()V", AccessFlags = 1)]
				public virtual void Reset() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the number of bytes trasferred. </para>        
				/// </summary>
				/// <java-name>
				/// getBytesTransferred
				/// </java-name>
				public long BytesTransferred
				{
				[Dot42.DexImport("getBytesTransferred", "()J", AccessFlags = 1)]
						get{ return GetBytesTransferred(); }
				[Dot42.DexImport("setBytesTransferred", "(J)V", AccessFlags = 1)]
						set{ SetBytesTransferred(value); }
				}

		}

		/// <java-name>
		/// org/apache/http/impl/io/HttpResponseParser
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/io/HttpResponseParser", AccessFlags = 33)]
		public partial class HttpResponseParser : global::Org.Apache.Http.Impl.Io.AbstractMessageParser
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Lorg/apache/http/io/SessionInputBuffer;Lorg/apache/http/message/LineParser;Lorg/" +
    "apache/http/HttpResponseFactory;Lorg/apache/http/params/HttpParams;)V", AccessFlags = 1)]
				public HttpResponseParser(global::Org.Apache.Http.Io.ISessionInputBuffer buffer, global::Org.Apache.Http.Message.ILineParser parser, global::Org.Apache.Http.IHttpResponseFactory responseFactory, global::Org.Apache.Http.Params.IHttpParams @params) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// parseHead
				/// </java-name>
				[Dot42.DexImport("parseHead", "(Lorg/apache/http/io/SessionInputBuffer;)Lorg/apache/http/HttpMessage;", AccessFlags = 4)]
				protected internal override global::Org.Apache.Http.IHttpMessage ParseHead(global::Org.Apache.Http.Io.ISessionInputBuffer sessionBuffer) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IHttpMessage);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal HttpResponseParser() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		/// <para>A stream wrapper that closes itself after a defined number of bytes.</para><para><para></para><para></para><title>Revision:</title><para>560343 </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/impl/io/ContentLengthOutputStream
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/io/ContentLengthOutputStream", AccessFlags = 33)]
		public partial class ContentLengthOutputStream : global::Java.Io.OutputStream
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new length limited stream</para><para><para>4.0 </para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Lorg/apache/http/io/SessionOutputBuffer;J)V", AccessFlags = 1)]
				public ContentLengthOutputStream(global::Org.Apache.Http.Io.ISessionOutputBuffer @out, long contentLength) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Does not close the underlying socket output.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1)]
				public override void Close() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Flushes this stream. Implementations of this method should ensure that any buffered data is written out. This implementation does nothing.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// flush
				/// </java-name>
				[Dot42.DexImport("flush", "()V", AccessFlags = 1)]
				public override void Flush() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Writes <c> count </c> bytes from the byte array <c> buffer </c> starting at position <c> offset </c> to this stream.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([BII)V", AccessFlags = 1)]
				public override void Write(sbyte[] buffer, int offset, int count) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Writes <c> count </c> bytes from the byte array <c> buffer </c> starting at position <c> offset </c> to this stream.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([BII)V", AccessFlags = 1, IgnoreFromJava = true)]
				public override void Write(byte[] buffer, int offset, int count) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Writes a single byte to this stream. Only the least significant byte of the integer <c> oneByte </c> is written to the stream.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([B)V", AccessFlags = 1)]
				public override void Write(sbyte[] oneByte) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Writes a single byte to this stream. Only the least significant byte of the integer <c> oneByte </c> is written to the stream.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public override void Write(byte[] oneByte) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Writes a single byte to this stream. Only the least significant byte of the integer <c> oneByte </c> is written to the stream.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "(I)V", AccessFlags = 1)]
				public override void Write(int oneByte) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ContentLengthOutputStream() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		/// <para>Abstract base class for session input buffers that stream data from a InputStream.</para><para><para> </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/impl/io/AbstractSessionInputBuffer
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/io/AbstractSessionInputBuffer", AccessFlags = 1057)]
		public abstract partial class AbstractSessionInputBuffer : global::Org.Apache.Http.Io.ISessionInputBuffer
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public AbstractSessionInputBuffer() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// init
				/// </java-name>
				[Dot42.DexImport("init", "(Ljava/io/InputStream;ILorg/apache/http/params/HttpParams;)V", AccessFlags = 4)]
				protected internal virtual void Init(global::Java.Io.InputStream instream, int buffersize, global::Org.Apache.Http.Params.IHttpParams @params) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// fillBuffer
				/// </java-name>
				[Dot42.DexImport("fillBuffer", "()I", AccessFlags = 4)]
				protected internal virtual int FillBuffer() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// hasBufferedData
				/// </java-name>
				[Dot42.DexImport("hasBufferedData", "()Z", AccessFlags = 4)]
				protected internal virtual bool HasBufferedData() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "()I", AccessFlags = 1)]
				public virtual int Read() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([BII)I", AccessFlags = 1)]
				public virtual int Read(sbyte[] b, int off, int len) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([BII)I", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual int Read(byte[] b, int off, int len) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([B)I", AccessFlags = 1)]
				public virtual int Read(sbyte[] b) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([B)I", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual int Read(byte[] b) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// readLine
				/// </java-name>
				[Dot42.DexImport("readLine", "(Lorg/apache/http/util/CharArrayBuffer;)I", AccessFlags = 1)]
				public virtual int ReadLine(global::Org.Apache.Http.Util.CharArrayBuffer charbuffer) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// readLine
				/// </java-name>
				[Dot42.DexImport("readLine", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string ReadLine() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getMetrics
				/// </java-name>
				[Dot42.DexImport("getMetrics", "()Lorg/apache/http/io/HttpTransportMetrics;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.Io.IHttpTransportMetrics GetMetrics() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Io.IHttpTransportMetrics);
				}

				[Dot42.DexImport("org/apache/http/io/SessionInputBuffer", "isDataAvailable", "(I)Z", AccessFlags = 1025)]
				public virtual bool IsDataAvailable(int timeout) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getMetrics
				/// </java-name>
				public global::Org.Apache.Http.Io.IHttpTransportMetrics Metrics
				{
				[Dot42.DexImport("getMetrics", "()Lorg/apache/http/io/HttpTransportMetrics;", AccessFlags = 1)]
						get{ return GetMetrics(); }
				}

		}

		/// <java-name>
		/// org/apache/http/impl/io/HttpResponseWriter
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/io/HttpResponseWriter", AccessFlags = 33)]
		public partial class HttpResponseWriter : global::Org.Apache.Http.Impl.Io.AbstractMessageWriter
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Lorg/apache/http/io/SessionOutputBuffer;Lorg/apache/http/message/LineFormatter;L" +
    "org/apache/http/params/HttpParams;)V", AccessFlags = 1)]
				public HttpResponseWriter(global::Org.Apache.Http.Io.ISessionOutputBuffer buffer, global::Org.Apache.Http.Message.ILineFormatter formatter, global::Org.Apache.Http.Params.IHttpParams @params) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writeHeadLine
				/// </java-name>
				[Dot42.DexImport("writeHeadLine", "(Lorg/apache/http/HttpMessage;)V", AccessFlags = 4)]
				protected internal override void WriteHeadLine(global::Org.Apache.Http.IHttpMessage message) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal HttpResponseWriter() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		/// <para>Implements chunked transfer coding. See , . It transparently coalesces chunks of a HTTP stream that uses chunked transfer coding. After the stream is read to the end, it provides access to the trailers, if any. </para><para>Note that this class NEVER closes the underlying stream, even when close gets called. Instead, it will read until the "end" of its chunking on close, which allows for the seamless execution of subsequent HTTP 1.1 requests, while not requiring the client to remember to read the entire contents of the response. </para><para><para>Ortwin Glueck </para><simplesectsep></simplesectsep><para>Sean C. Sullivan </para><simplesectsep></simplesectsep><para>Martin Elwin </para><simplesectsep></simplesectsep><para>Eric Johnson </para><simplesectsep></simplesectsep><para> </para><simplesectsep></simplesectsep><para>Michael Becke </para><simplesectsep></simplesectsep><para></para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/impl/io/ChunkedInputStream
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/io/ChunkedInputStream", AccessFlags = 33)]
		public partial class ChunkedInputStream : global::Java.Io.InputStream
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Lorg/apache/http/io/SessionInputBuffer;)V", AccessFlags = 1)]
				public ChunkedInputStream(global::Org.Apache.Http.Io.ISessionInputBuffer @in) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns all the data in a chunked stream in coalesced form. A chunk is followed by a CRLF. The method returns -1 as soon as a chunksize of 0 is detected.</para><para>Trailer headers are read automcatically at the end of the stream and can be obtained with the getResponseFooters() method.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>-1 of the end of the stream has been reached or the next data byte </para>
				/// </returns>
				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "()I", AccessFlags = 1)]
				public override int Read() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Read some bytes from the stream. <para>java.io.InputStream::read(byte[], int, int) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The number of bytes returned or -1 if the end of stream has been reached. </para>
				/// </returns>
				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([BII)I", AccessFlags = 1)]
				public override int Read(sbyte[] b, int off, int len) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Read some bytes from the stream. <para>java.io.InputStream::read(byte[], int, int) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The number of bytes returned or -1 if the end of stream has been reached. </para>
				/// </returns>
				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([BII)I", AccessFlags = 1, IgnoreFromJava = true)]
				public override int Read(byte[] b, int off, int len) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Read some bytes from the stream. <para>java.io.InputStream::read(byte[]) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The number of bytes returned or -1 if the end of stream has been reached. </para>
				/// </returns>
				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([B)I", AccessFlags = 1)]
				public override int Read(sbyte[] b) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Read some bytes from the stream. <para>java.io.InputStream::read(byte[]) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The number of bytes returned or -1 if the end of stream has been reached. </para>
				/// </returns>
				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([B)I", AccessFlags = 1, IgnoreFromJava = true)]
				public override int Read(byte[] b) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Upon close, this reads the remainder of the chunked message, leaving the underlying socket at a position to start reading the next response without scanning. </para>        
				/// </summary>
				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1)]
				public override void Close() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getFooters
				/// </java-name>
				[Dot42.DexImport("getFooters", "()[Lorg/apache/http/Header;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.IHeader[] GetFooters() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IHeader[]);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ChunkedInputStream() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getFooters
				/// </java-name>
				public global::Org.Apache.Http.IHeader[] Footers
				{
				[Dot42.DexImport("getFooters", "()[Lorg/apache/http/Header;", AccessFlags = 1)]
						get{ return GetFooters(); }
				}

		}

}


