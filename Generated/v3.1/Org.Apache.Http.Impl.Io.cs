#pragma warning disable 1717
namespace Org.Apache.Http.Impl.Io
{
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
				public AbstractMessageParser(global::Org.Apache.Http.Io.ISessionInputBuffer sessionInputBuffer, global::Org.Apache.Http.Message.ILineParser lineParser, global::Org.Apache.Http.Params.IHttpParams httpParams) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// parseHeaders
				/// </java-name>
				[Dot42.DexImport("parseHeaders", "(Lorg/apache/http/io/SessionInputBuffer;IILorg/apache/http/message/LineParser;)[L" +
    "org/apache/http/Header;", AccessFlags = 9)]
				public static global::Org.Apache.Http.IHeader[] ParseHeaders(global::Org.Apache.Http.Io.ISessionInputBuffer sessionInputBuffer, int int32, int int321, global::Org.Apache.Http.Message.ILineParser lineParser) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IHeader[]);
				}

				/// <java-name>
				/// parseHead
				/// </java-name>
				[Dot42.DexImport("parseHead", "(Lorg/apache/http/io/SessionInputBuffer;)Lorg/apache/http/HttpMessage;", AccessFlags = 1028)]
				protected internal abstract global::Org.Apache.Http.IHttpMessage ParseHead(global::Org.Apache.Http.Io.ISessionInputBuffer sessionInputBuffer) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// parse
				/// </java-name>
				[Dot42.DexImport("parse", "()Lorg/apache/http/HttpMessage;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.IHttpMessage Parse() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IHttpMessage);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal AbstractMessageParser() /* TypeBuilder.AddDefaultConstructor */ 
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
				public AbstractMessageWriter(global::Org.Apache.Http.Io.ISessionOutputBuffer sessionOutputBuffer, global::Org.Apache.Http.Message.ILineFormatter lineFormatter, global::Org.Apache.Http.Params.IHttpParams httpParams) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writeHeadLine
				/// </java-name>
				[Dot42.DexImport("writeHeadLine", "(Lorg/apache/http/HttpMessage;)V", AccessFlags = 1028)]
				protected internal abstract void WriteHeadLine(global::Org.Apache.Http.IHttpMessage httpMessage) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "(Lorg/apache/http/HttpMessage;)V", AccessFlags = 1)]
				public virtual void Write(global::Org.Apache.Http.IHttpMessage httpMessage) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal AbstractMessageWriter() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

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
				protected internal virtual void Init(global::Java.IO.InputStream inputStream, int int32, global::Org.Apache.Http.Params.IHttpParams httpParams) /* MethodBuilder.Create */ 
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
				[Dot42.DexImport("read", "([BII)I", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual int Read(sbyte[] sByte, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([BII)I", AccessFlags = 1)]
				public virtual int Read(byte[] @byte, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([B)I", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual int Read(sbyte[] sByte) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([B)I", AccessFlags = 1)]
				public virtual int Read(byte[] @byte) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// readLine
				/// </java-name>
				[Dot42.DexImport("readLine", "(Lorg/apache/http/util/CharArrayBuffer;)I", AccessFlags = 1)]
				public virtual int ReadLine(global::Org.Apache.Http.Util.CharArrayBuffer charArrayBuffer) /* MethodBuilder.Create */ 
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

				[Dot42.DexImport("org/apache/http/io/SessionInputBuffer", "isDataAvailable", "(I)Z", AccessFlags = 1025)]
				public virtual bool IsDataAvailable(int int32) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// hasBufferedData
				/// </java-name>
				protected internal virtual bool HasBufferedData
				{
						[Dot42.DexImport("hasBufferedData", "()Z", AccessFlags = 4)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// getMetrics
				/// </java-name>
				public virtual global::Org.Apache.Http.Io.IHttpTransportMetrics Metrics
				{
						[Dot42.DexImport("getMetrics", "()Lorg/apache/http/io/HttpTransportMetrics;", AccessFlags = 1)]
						get{ return default(global::Org.Apache.Http.Io.IHttpTransportMetrics); }
				}

		}

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
				protected internal virtual void Init(global::Java.IO.OutputStream outputStream, int int32, global::Org.Apache.Http.Params.IHttpParams httpParams) /* MethodBuilder.Create */ 
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
				[Dot42.DexImport("write", "([BII)V", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual void Write(sbyte[] sByte, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([BII)V", AccessFlags = 1)]
				public virtual void Write(byte[] @byte, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual void Write(sbyte[] sByte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([B)V", AccessFlags = 1)]
				public virtual void Write(byte[] @byte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "(I)V", AccessFlags = 1)]
				public virtual void Write(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writeLine
				/// </java-name>
				[Dot42.DexImport("writeLine", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void WriteLine(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writeLine
				/// </java-name>
				[Dot42.DexImport("writeLine", "(Lorg/apache/http/util/CharArrayBuffer;)V", AccessFlags = 1)]
				public virtual void WriteLine(global::Org.Apache.Http.Util.CharArrayBuffer charArrayBuffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getMetrics
				/// </java-name>
				public virtual global::Org.Apache.Http.Io.IHttpTransportMetrics Metrics
				{
						[Dot42.DexImport("getMetrics", "()Lorg/apache/http/io/HttpTransportMetrics;", AccessFlags = 1)]
						get{ return default(global::Org.Apache.Http.Io.IHttpTransportMetrics); }
				}

		}

		/// <java-name>
		/// org/apache/http/impl/io/ChunkedInputStream
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/io/ChunkedInputStream", AccessFlags = 33)]
		public partial class ChunkedInputStream : global::Java.IO.InputStream
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Lorg/apache/http/io/SessionInputBuffer;)V", AccessFlags = 1)]
				public ChunkedInputStream(global::Org.Apache.Http.Io.ISessionInputBuffer sessionInputBuffer) /* MethodBuilder.Create */ 
				{
				}

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
				[Dot42.DexImport("read", "([BII)I", AccessFlags = 1, IgnoreFromJava = true)]
				public override int Read(sbyte[] sByte, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([BII)I", AccessFlags = 1)]
				public override int Read(byte[] @byte, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([B)I", AccessFlags = 1, IgnoreFromJava = true)]
				public override int Read(sbyte[] sByte) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([B)I", AccessFlags = 1)]
				public override int Read(byte[] @byte) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1)]
				public override void Close() /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal ChunkedInputStream() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getFooters
				/// </java-name>
				public virtual global::Org.Apache.Http.IHeader[] Footers
				{
						[Dot42.DexImport("getFooters", "()[Lorg/apache/http/Header;", AccessFlags = 1)]
						get{ return default(global::Org.Apache.Http.IHeader[]); }
				}

		}

		/// <java-name>
		/// org/apache/http/impl/io/ChunkedOutputStream
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/io/ChunkedOutputStream", AccessFlags = 33)]
		public partial class ChunkedOutputStream : global::Java.IO.OutputStream
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Lorg/apache/http/io/SessionOutputBuffer;I)V", AccessFlags = 1)]
				public ChunkedOutputStream(global::Org.Apache.Http.Io.ISessionOutputBuffer sessionOutputBuffer, int int32) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Lorg/apache/http/io/SessionOutputBuffer;)V", AccessFlags = 1)]
				public ChunkedOutputStream(global::Org.Apache.Http.Io.ISessionOutputBuffer sessionOutputBuffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// flushCache
				/// </java-name>
				[Dot42.DexImport("flushCache", "()V", AccessFlags = 4)]
				protected internal virtual void FlushCache() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// flushCacheWithAppend
				/// </java-name>
				[Dot42.DexImport("flushCacheWithAppend", "([BII)V", AccessFlags = 4, IgnoreFromJava = true)]
				protected internal virtual void FlushCacheWithAppend(sbyte[] sByte, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// flushCacheWithAppend
				/// </java-name>
				[Dot42.DexImport("flushCacheWithAppend", "([BII)V", AccessFlags = 4)]
				protected internal virtual void FlushCacheWithAppend(byte[] @byte, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writeClosingChunk
				/// </java-name>
				[Dot42.DexImport("writeClosingChunk", "()V", AccessFlags = 4)]
				protected internal virtual void WriteClosingChunk() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// finish
				/// </java-name>
				[Dot42.DexImport("finish", "()V", AccessFlags = 1)]
				public virtual void Finish() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "(I)V", AccessFlags = 1)]
				public override void Write(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public override void Write(sbyte[] sByte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([B)V", AccessFlags = 1)]
				public override void Write(byte[] @byte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([BII)V", AccessFlags = 1, IgnoreFromJava = true)]
				public override void Write(sbyte[] sByte, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([BII)V", AccessFlags = 1)]
				public override void Write(byte[] @byte, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// flush
				/// </java-name>
				[Dot42.DexImport("flush", "()V", AccessFlags = 1)]
				public override void Flush() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1)]
				public override void Close() /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal ChunkedOutputStream() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// org/apache/http/impl/io/ContentLengthInputStream
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/io/ContentLengthInputStream", AccessFlags = 33)]
		public partial class ContentLengthInputStream : global::Java.IO.InputStream
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Lorg/apache/http/io/SessionInputBuffer;J)V", AccessFlags = 1)]
				public ContentLengthInputStream(global::Org.Apache.Http.Io.ISessionInputBuffer sessionInputBuffer, long int64) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1)]
				public override void Close() /* MethodBuilder.Create */ 
				{
				}

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
				[Dot42.DexImport("read", "([BII)I", AccessFlags = 1, IgnoreFromJava = true)]
				public override int Read(sbyte[] sByte, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([BII)I", AccessFlags = 1)]
				public override int Read(byte[] @byte, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([B)I", AccessFlags = 1, IgnoreFromJava = true)]
				public override int Read(sbyte[] sByte) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([B)I", AccessFlags = 1)]
				public override int Read(byte[] @byte) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// skip
				/// </java-name>
				[Dot42.DexImport("skip", "(J)J", AccessFlags = 1)]
				public override long Skip(long int64) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal ContentLengthInputStream() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// org/apache/http/impl/io/ContentLengthOutputStream
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/io/ContentLengthOutputStream", AccessFlags = 33)]
		public partial class ContentLengthOutputStream : global::Java.IO.OutputStream
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Lorg/apache/http/io/SessionOutputBuffer;J)V", AccessFlags = 1)]
				public ContentLengthOutputStream(global::Org.Apache.Http.Io.ISessionOutputBuffer sessionOutputBuffer, long int64) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1)]
				public override void Close() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// flush
				/// </java-name>
				[Dot42.DexImport("flush", "()V", AccessFlags = 1)]
				public override void Flush() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([BII)V", AccessFlags = 1, IgnoreFromJava = true)]
				public override void Write(sbyte[] sByte, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([BII)V", AccessFlags = 1)]
				public override void Write(byte[] @byte, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public override void Write(sbyte[] sByte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([B)V", AccessFlags = 1)]
				public override void Write(byte[] @byte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "(I)V", AccessFlags = 1)]
				public override void Write(int int32) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal ContentLengthOutputStream() /* TypeBuilder.AddDefaultConstructor */ 
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
				public HttpRequestParser(global::Org.Apache.Http.Io.ISessionInputBuffer sessionInputBuffer, global::Org.Apache.Http.Message.ILineParser lineParser, global::Org.Apache.Http.IHttpRequestFactory httpRequestFactory, global::Org.Apache.Http.Params.IHttpParams httpParams) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// parseHead
				/// </java-name>
				[Dot42.DexImport("parseHead", "(Lorg/apache/http/io/SessionInputBuffer;)Lorg/apache/http/HttpMessage;", AccessFlags = 4)]
				protected internal override global::Org.Apache.Http.IHttpMessage ParseHead(global::Org.Apache.Http.Io.ISessionInputBuffer sessionInputBuffer) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IHttpMessage);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal HttpRequestParser() /* TypeBuilder.AddDefaultConstructor */ 
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
				public HttpRequestWriter(global::Org.Apache.Http.Io.ISessionOutputBuffer sessionOutputBuffer, global::Org.Apache.Http.Message.ILineFormatter lineFormatter, global::Org.Apache.Http.Params.IHttpParams httpParams) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writeHeadLine
				/// </java-name>
				[Dot42.DexImport("writeHeadLine", "(Lorg/apache/http/HttpMessage;)V", AccessFlags = 4)]
				protected internal override void WriteHeadLine(global::Org.Apache.Http.IHttpMessage httpMessage) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal HttpRequestWriter() /* TypeBuilder.AddDefaultConstructor */ 
				{
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
				public HttpResponseParser(global::Org.Apache.Http.Io.ISessionInputBuffer sessionInputBuffer, global::Org.Apache.Http.Message.ILineParser lineParser, global::Org.Apache.Http.IHttpResponseFactory httpResponseFactory, global::Org.Apache.Http.Params.IHttpParams httpParams) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// parseHead
				/// </java-name>
				[Dot42.DexImport("parseHead", "(Lorg/apache/http/io/SessionInputBuffer;)Lorg/apache/http/HttpMessage;", AccessFlags = 4)]
				protected internal override global::Org.Apache.Http.IHttpMessage ParseHead(global::Org.Apache.Http.Io.ISessionInputBuffer sessionInputBuffer) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IHttpMessage);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal HttpResponseParser() /* TypeBuilder.AddDefaultConstructor */ 
				{
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
				public HttpResponseWriter(global::Org.Apache.Http.Io.ISessionOutputBuffer sessionOutputBuffer, global::Org.Apache.Http.Message.ILineFormatter lineFormatter, global::Org.Apache.Http.Params.IHttpParams httpParams) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writeHeadLine
				/// </java-name>
				[Dot42.DexImport("writeHeadLine", "(Lorg/apache/http/HttpMessage;)V", AccessFlags = 4)]
				protected internal override void WriteHeadLine(global::Org.Apache.Http.IHttpMessage httpMessage) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal HttpResponseWriter() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

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

				/// <java-name>
				/// setBytesTransferred
				/// </java-name>
				[Dot42.DexImport("setBytesTransferred", "(J)V", AccessFlags = 1)]
				public virtual void SetBytesTransferred(long int64) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// incrementBytesTransferred
				/// </java-name>
				[Dot42.DexImport("incrementBytesTransferred", "(J)V", AccessFlags = 1)]
				public virtual void IncrementBytesTransferred(long int64) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// reset
				/// </java-name>
				[Dot42.DexImport("reset", "()V", AccessFlags = 1)]
				public virtual void Reset() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getBytesTransferred
				/// </java-name>
				public virtual long BytesTransferred
				{
						[Dot42.DexImport("getBytesTransferred", "()J", AccessFlags = 1)]
						get{ return default(long); }
				}

		}

		/// <java-name>
		/// org/apache/http/impl/io/IdentityInputStream
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/io/IdentityInputStream", AccessFlags = 33)]
		public partial class IdentityInputStream : global::Java.IO.InputStream
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Lorg/apache/http/io/SessionInputBuffer;)V", AccessFlags = 1)]
				public IdentityInputStream(global::Org.Apache.Http.Io.ISessionInputBuffer sessionInputBuffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// available
				/// </java-name>
				[Dot42.DexImport("available", "()I", AccessFlags = 1)]
				public override int Available() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1)]
				public override void Close() /* MethodBuilder.Create */ 
				{
				}

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
				[Dot42.DexImport("read", "([BII)I", AccessFlags = 1, IgnoreFromJava = true)]
				public override int Read(sbyte[] sByte, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([BII)I", AccessFlags = 1)]
				public override int Read(byte[] @byte, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal IdentityInputStream() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// org/apache/http/impl/io/IdentityOutputStream
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/io/IdentityOutputStream", AccessFlags = 33)]
		public partial class IdentityOutputStream : global::Java.IO.OutputStream
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Lorg/apache/http/io/SessionOutputBuffer;)V", AccessFlags = 1)]
				public IdentityOutputStream(global::Org.Apache.Http.Io.ISessionOutputBuffer sessionOutputBuffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1)]
				public override void Close() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// flush
				/// </java-name>
				[Dot42.DexImport("flush", "()V", AccessFlags = 1)]
				public override void Flush() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([BII)V", AccessFlags = 1, IgnoreFromJava = true)]
				public override void Write(sbyte[] sByte, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([BII)V", AccessFlags = 1)]
				public override void Write(byte[] @byte, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public override void Write(sbyte[] sByte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([B)V", AccessFlags = 1)]
				public override void Write(byte[] @byte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "(I)V", AccessFlags = 1)]
				public override void Write(int int32) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal IdentityOutputStream() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// org/apache/http/impl/io/SocketInputBuffer
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/io/SocketInputBuffer", AccessFlags = 33)]
		public partial class SocketInputBuffer : global::Org.Apache.Http.Impl.Io.AbstractSessionInputBuffer
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/net/Socket;ILorg/apache/http/params/HttpParams;)V", AccessFlags = 1)]
				public SocketInputBuffer(global::Java.Net.Socket socket, int int32, global::Org.Apache.Http.Params.IHttpParams httpParams) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isDataAvailable
				/// </java-name>
				[Dot42.DexImport("isDataAvailable", "(I)Z", AccessFlags = 1)]
				public override bool IsDataAvailable(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal SocketInputBuffer() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// org/apache/http/impl/io/SocketOutputBuffer
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/io/SocketOutputBuffer", AccessFlags = 33)]
		public partial class SocketOutputBuffer : global::Org.Apache.Http.Impl.Io.AbstractSessionOutputBuffer
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/net/Socket;ILorg/apache/http/params/HttpParams;)V", AccessFlags = 1)]
				public SocketOutputBuffer(global::Java.Net.Socket socket, int int32, global::Org.Apache.Http.Params.IHttpParams httpParams) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal SocketOutputBuffer() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

}

