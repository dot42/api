#pragma warning disable 1717
namespace Java.IO
{
		/// <summary>
		///  <para>Wraps an existing InputStream and  <b>buffers</b> the input. Expensive interaction with the underlying input stream is minimized, since most (smaller) requests can be satisfied by accessing the buffer alone. The drawback is that some extra space is required to hold the buffer and that copying takes place when filling that buffer, but this is usually outweighed by the performance benefits.</para> <para>A typical application pattern for the class looks like this:</para> <para> <pre>
		/// BufferedInputStream buf = new BufferedInputStream(new FileInputStream("file.java"));
		/// </pre></para> <para> <para>BufferedOutputStream </para></para>    
		/// </summary>
		/// <java-name>
		/// java/io/BufferedInputStream
		/// </java-name>
		[Dot42.DexImport("java/io/BufferedInputStream", AccessFlags = 33)]
		public partial class BufferedInputStream : global::Java.IO.FilterInputStream
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>The buffer containing the current bytes read from the target InputStream. </para>        
				/// </summary>
				/// <java-name>
				/// buf
				/// </java-name>
				[Dot42.DexImport("buf", "[B", AccessFlags = 68)]
				protected internal sbyte[] Buf;
				/// <summary>
				///  <para>The total number of bytes inside the byte array <c>buf </c> . </para>        
				/// </summary>
				/// <java-name>
				/// count
				/// </java-name>
				[Dot42.DexImport("count", "I", AccessFlags = 4)]
				protected internal int Count;
				/// <summary>
				///  <para>The current limit, which when passed, invalidates the current mark. </para>        
				/// </summary>
				/// <java-name>
				/// marklimit
				/// </java-name>
				[Dot42.DexImport("marklimit", "I", AccessFlags = 4)]
				protected internal int Marklimit;
				/// <summary>
				///  <para>The currently marked position. -1 indicates no mark has been set or the mark has been invalidated. </para>        
				/// </summary>
				/// <java-name>
				/// markpos
				/// </java-name>
				[Dot42.DexImport("markpos", "I", AccessFlags = 4)]
				protected internal int Markpos;
				/// <summary>
				///  <para>The current position within the byte array <c>buf </c> . </para>        
				/// </summary>
				/// <java-name>
				/// pos
				/// </java-name>
				[Dot42.DexImport("pos", "I", AccessFlags = 4)]
				protected internal int Pos;
				/// <summary>
				///  <para>Constructs a new <c>BufferedInputStream </c> , providing <c>in </c> with a buffer of 8192 bytes.</para> <para> <b>Warning:</b> passing a null source creates a closed  <c>BufferedInputStream </c> . All read operations on such a stream will fail with an IOException.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/io/InputStream;)V", AccessFlags = 1)]
				public BufferedInputStream(global::Java.IO.InputStream @in) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new <c>BufferedInputStream </c> , providing <c>in </c> with <c>size </c> bytes of buffer.</para> <para> <b>Warning:</b> passing a null source creates a closed  <c>BufferedInputStream </c> . All read operations on such a stream will fail with an IOException.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/io/InputStream;I)V", AccessFlags = 1)]
				public BufferedInputStream(global::Java.IO.InputStream @in, int size) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns an estimated number of bytes that can be read or skipped without blocking for more input. This method returns the number of bytes available in the buffer plus those available in the source stream, but see InputStream#available for important caveats.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the estimated number of bytes available </para>
				/// </returns>
				/// <java-name>
				/// available
				/// </java-name>
				[Dot42.DexImport("available", "()I", AccessFlags = 33)]
				public override int Available() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Closes this stream. The source stream is closed and any resources associated with it are released.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1)]
				public override void Close() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets a mark position in this stream. The parameter <c>readlimit </c> indicates how many bytes can be read before a mark is invalidated. Calling <c>reset() </c> will reposition the stream back to the marked position if <c>readlimit </c> has not been surpassed. The underlying buffer may be increased in size to allow <c>readlimit </c> number of bytes to be supported.</para> <para> <para>reset() </para></para>        
				/// </summary>
				/// <java-name>
				/// mark
				/// </java-name>
				[Dot42.DexImport("mark", "(I)V", AccessFlags = 33)]
				public override void Mark(int readlimit) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Indicates whether <c>BufferedInputStream </c> supports the <c>mark() </c> and <c>reset() </c> methods.</para> <para> <para>mark(int) </para> <para>reset() </para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> for BufferedInputStreams. </para>
				/// </returns>
				/// <java-name>
				/// markSupported
				/// </java-name>
				[Dot42.DexImport("markSupported", "()Z", AccessFlags = 1)]
				public override bool MarkSupported() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Reads a single byte from this stream and returns it as an integer in the range from 0 to 255. Returns -1 if the end of the source string has been reached. If the internal buffer does not contain any available bytes then it is filled from the source stream and the first byte is returned.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the byte read or -1 if the end of the source stream has been reached. </para>
				/// </returns>
				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "()I", AccessFlags = 33)]
				public override int Read() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([BII)I", AccessFlags = 33)]
				public override int Read(sbyte[] buffer, int byteOffset, int byteCount) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([BII)I", AccessFlags = 33, IgnoreFromJava = true)]
				public override int Read(byte[] buffer, int byteOffset, int byteCount) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Resets this stream to the last marked location.</para> <para> <para>mark(int) </para></para>        
				/// </summary>
				/// <java-name>
				/// reset
				/// </java-name>
				[Dot42.DexImport("reset", "()V", AccessFlags = 33)]
				public override void Reset() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Skips <c>byteCount </c> bytes in this stream. Subsequent calls to  <c>read </c> will not return these bytes unless <c>reset </c> is used.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the number of bytes actually skipped. </para>
				/// </returns>
				/// <java-name>
				/// skip
				/// </java-name>
				[Dot42.DexImport("skip", "(J)J", AccessFlags = 33)]
				public override long Skip(long byteCount) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal BufferedInputStream() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		///  <para>Wraps an existing OutputStream and  <b>buffers</b> the output. Expensive interaction with the underlying input stream is minimized, since most (smaller) requests can be satisfied by accessing the buffer alone. The drawback is that some extra space is required to hold the buffer and that copying takes place when flushing that buffer, but this is usually outweighed by the performance benefits.</para> <para>A typical application pattern for the class looks like this:</para> <para> <pre>
		/// BufferedOutputStream buf = new BufferedOutputStream(new FileOutputStream("file.java"));
		/// </pre></para> <para> <para>BufferedInputStream </para></para>    
		/// </summary>
		/// <java-name>
		/// java/io/BufferedOutputStream
		/// </java-name>
		[Dot42.DexImport("java/io/BufferedOutputStream", AccessFlags = 33)]
		public partial class BufferedOutputStream : global::Java.IO.FilterOutputStream
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>The buffer containing the bytes to be written to the target stream. </para>        
				/// </summary>
				/// <java-name>
				/// buf
				/// </java-name>
				[Dot42.DexImport("buf", "[B", AccessFlags = 4)]
				protected internal sbyte[] Buf;
				/// <summary>
				///  <para>The total number of bytes inside the byte array <c>buf </c> . </para>        
				/// </summary>
				/// <java-name>
				/// count
				/// </java-name>
				[Dot42.DexImport("count", "I", AccessFlags = 4)]
				protected internal int Count;
				/// <summary>
				///  <para>Constructs a new <c>BufferedOutputStream </c> , providing <c>out </c> with a buffer of 8192 bytes.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/io/OutputStream;)V", AccessFlags = 1)]
				public BufferedOutputStream(global::Java.IO.OutputStream @out) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new <c>BufferedOutputStream </c> , providing <c>out </c> with <c>size </c> bytes of buffer.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/io/OutputStream;I)V", AccessFlags = 1)]
				public BufferedOutputStream(global::Java.IO.OutputStream @out, int size) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Flushes this stream to ensure all pending data is written out to the target stream. In addition, the target stream is flushed.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// flush
				/// </java-name>
				[Dot42.DexImport("flush", "()V", AccessFlags = 33)]
				public override void Flush() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Writes <c>count </c> bytes from the byte array <c>buffer </c> starting at  <c>offset </c> to this stream. If there is room in the buffer to hold the bytes, they are copied in. If not, the buffered bytes plus the bytes in  <c>buffer </c> are written to the target stream, the target is flushed, and the buffer is cleared.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([BII)V", AccessFlags = 33)]
				public override void Write(sbyte[] buffer, int offset, int length) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Writes <c>count </c> bytes from the byte array <c>buffer </c> starting at  <c>offset </c> to this stream. If there is room in the buffer to hold the bytes, they are copied in. If not, the buffered bytes plus the bytes in  <c>buffer </c> are written to the target stream, the target is flushed, and the buffer is cleared.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([BII)V", AccessFlags = 33, IgnoreFromJava = true)]
				public override void Write(byte[] buffer, int offset, int length) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Closes the object and release any system resources it holds.</para> <para>Although only the first call has any effect, it is safe to call close multiple times on the same object. This is more lenient than the overridden <c>AutoCloseable.close() </c> , which may be called at most once. </para>        
				/// </summary>
				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 33)]
				public override void Close() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Writes one byte to this stream. Only the low order byte of the integer  <c>oneByte </c> is written. If there is room in the buffer, the byte is copied into the buffer and the count incremented. Otherwise, the buffer plus <c>oneByte </c> are written to the target stream, the target is flushed, and the buffer is reset.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "(I)V", AccessFlags = 33)]
				public override void Write(int oneByte) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal BufferedOutputStream() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		///  <para>Wraps an existing Reader and  <b>buffers</b> the input. Expensive interaction with the underlying reader is minimized, since most (smaller) requests can be satisfied by accessing the buffer alone. The drawback is that some extra space is required to hold the buffer and that copying takes place when filling that buffer, but this is usually outweighed by the performance benefits.</para> <para>A typical application pattern for the class looks like this:</para> <para> <pre>
		/// BufferedReader buf = new BufferedReader(new FileReader("file.java"));
		/// </pre></para> <para> <para>BufferedWriter </para> <para>1.1 </para></para>    
		/// </summary>
		/// <java-name>
		/// java/io/BufferedReader
		/// </java-name>
		[Dot42.DexImport("java/io/BufferedReader", AccessFlags = 33)]
		public partial class BufferedReader : global::Java.IO.Reader
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructs a new <c>BufferedReader </c> , providing <c>in </c> with a buffer of 8192 characters.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/io/Reader;)V", AccessFlags = 1)]
				public BufferedReader(global::Java.IO.Reader @in) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new <c>BufferedReader </c> , providing <c>in </c> with <c>size </c> characters of buffer.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/io/Reader;I)V", AccessFlags = 1)]
				public BufferedReader(global::Java.IO.Reader @in, int size) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Closes this reader. This implementation closes the buffered source reader and releases the buffer. Nothing is done if this reader has already been closed.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1)]
				public override void Close() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets a mark position in this reader. The parameter <c>markLimit </c> indicates how many characters can be read before the mark is invalidated. Calling <c>reset() </c> will reposition the reader back to the marked position if <c>markLimit </c> has not been surpassed.</para> <para> <para>markSupported() </para> <para>reset() </para></para>        
				/// </summary>
				/// <java-name>
				/// mark
				/// </java-name>
				[Dot42.DexImport("mark", "(I)V", AccessFlags = 1)]
				public override void Mark(int markLimit) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Indicates whether this reader supports the <c>mark() </c> and  <c>reset() </c> methods. This implementation returns <c>true </c> .</para> <para> <para>mark(int) </para> <para>reset() </para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> for <c>BufferedReader </c> . </para>
				/// </returns>
				/// <java-name>
				/// markSupported
				/// </java-name>
				[Dot42.DexImport("markSupported", "()Z", AccessFlags = 1)]
				public override bool MarkSupported() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Reads a single character from this reader and returns it with the two higher-order bytes set to 0. If possible, BufferedReader returns a character from the buffer. If there are no characters available in the buffer, it fills the buffer and then returns a character. It returns -1 if there are no more characters in the source reader.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the character read or -1 if the end of the source reader has been reached. </para>
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
				///  <para>Reads up to <c>length </c> characters from this reader and stores them at <c>offset </c> in the character array <c>buffer </c> . Returns the number of characters actually read or -1 if the end of the source reader has been reached. If all the buffered characters have been used, a mark has not been set and the requested number of characters is larger than this readers buffer size, BufferedReader bypasses the buffer and simply places the results directly into <c>buffer </c> .</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([CII)I", AccessFlags = 1)]
				public override int Read(char[] buffer, int offset, int length) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Returns the next line of text available from this reader. A line is represented by zero or more characters followed by <c>'\n' </c> ,  <c>'\r' </c> , <c>"\r\n" </c> or the end of the reader. The string does not include the newline sequence.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the contents of the line or <c>null </c> if no characters were read before the end of the reader has been reached. </para>
				/// </returns>
				/// <java-name>
				/// readLine
				/// </java-name>
				[Dot42.DexImport("readLine", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string ReadLine() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Indicates whether this reader is ready to be read without blocking.</para> <para> <para>read() </para> <para>read(char[], int, int) </para> <para>readLine() </para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if this reader will not block when <c>read </c> is called, <c>false </c> if unknown or blocking will occur. </para>
				/// </returns>
				/// <java-name>
				/// ready
				/// </java-name>
				[Dot42.DexImport("ready", "()Z", AccessFlags = 1)]
				public override bool Ready() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Resets this reader's position to the last <c>mark() </c> location. Invocations of <c>read() </c> and <c>skip() </c> will occur from this new location.</para> <para> <para>mark(int) </para> <para>markSupported() </para></para>        
				/// </summary>
				/// <java-name>
				/// reset
				/// </java-name>
				[Dot42.DexImport("reset", "()V", AccessFlags = 1)]
				public override void Reset() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Skips at most <c>charCount </c> chars in this stream. Subsequent calls to  <c>read </c> will not return these chars unless <c>reset </c> is used.</para> <para>Skipping characters may invalidate a mark if <c>markLimit </c> is surpassed.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the number of characters actually skipped. </para>
				/// </returns>
				/// <java-name>
				/// skip
				/// </java-name>
				[Dot42.DexImport("skip", "(J)J", AccessFlags = 1)]
				public override long Skip(long charCount) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal BufferedReader() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		///  <para>Wraps an existing Writer and  <b>buffers</b> the output. Expensive interaction with the underlying reader is minimized, since most (smaller) requests can be satisfied by accessing the buffer alone. The drawback is that some extra space is required to hold the buffer and that copying takes place when filling that buffer, but this is usually outweighed by the performance benefits.</para> <para>A typical application pattern for the class looks like this:</para> <para> <pre>
		/// BufferedWriter buf = new BufferedWriter(new FileWriter("file.java"));
		/// </pre></para> <para> <para>BufferedReader </para></para>    
		/// </summary>
		/// <java-name>
		/// java/io/BufferedWriter
		/// </java-name>
		[Dot42.DexImport("java/io/BufferedWriter", AccessFlags = 33)]
		public partial class BufferedWriter : global::Java.IO.Writer
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructs a new <c>BufferedWriter </c> , providing <c>out </c> with a buffer of 8192 chars.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/io/Writer;)V", AccessFlags = 1)]
				public BufferedWriter(global::Java.IO.Writer @out) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new <c>BufferedWriter </c> , providing <c>out </c> with <c>size </c> chars of buffer.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/io/Writer;I)V", AccessFlags = 1)]
				public BufferedWriter(global::Java.IO.Writer @out, int size) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Closes this writer. The contents of the buffer are flushed, the target writer is closed, and the buffer is released. Only the first invocation of close has any effect.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1)]
				public override void Close() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Flushes this writer. The contents of the buffer are committed to the target writer and it is then flushed.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// flush
				/// </java-name>
				[Dot42.DexImport("flush", "()V", AccessFlags = 1)]
				public override void Flush() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Writes a newline to this writer. On Android, this is <c>"\n" </c> . The target writer may or may not be flushed when a newline is written.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// newLine
				/// </java-name>
				[Dot42.DexImport("newLine", "()V", AccessFlags = 1)]
				public virtual void NewLine() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([CII)V", AccessFlags = 1)]
				public override void Write(char[] @char, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Writes the character <c>oneChar </c> to this writer. If the buffer gets full by writing this character, this writer is flushed. Only the lower two bytes of the integer <c>oneChar </c> are written.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "(I)V", AccessFlags = 1)]
				public override void Write(int oneChar) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "(Ljava/lang/String;II)V", AccessFlags = 1)]
				public override void Write(string @string, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal BufferedWriter() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		///  <para>A specialized InputStream for reading the contents of a byte array.</para> <para> <para>ByteArrayOutputStream </para></para>    
		/// </summary>
		/// <java-name>
		/// java/io/ByteArrayInputStream
		/// </java-name>
		[Dot42.DexImport("java/io/ByteArrayInputStream", AccessFlags = 33)]
		public partial class ByteArrayInputStream : global::Java.IO.InputStream
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>The <c>byte </c> array containing the bytes to stream over. </para>        
				/// </summary>
				/// <java-name>
				/// buf
				/// </java-name>
				[Dot42.DexImport("buf", "[B", AccessFlags = 4)]
				protected internal sbyte[] Buf;
				/// <summary>
				///  <para>The current position within the byte array. </para>        
				/// </summary>
				/// <java-name>
				/// pos
				/// </java-name>
				[Dot42.DexImport("pos", "I", AccessFlags = 4)]
				protected internal int Pos;
				/// <summary>
				///  <para>The current mark position. Initially set to 0 or the  <code>offset</code> parameter within the constructor. </para>        
				/// </summary>
				/// <java-name>
				/// mark
				/// </java-name>
				[Dot42.DexImport("mark", "I", AccessFlags = 4)]
				protected internal int Mark0;
				/// <summary>
				///  <para>The total number of bytes initially available in the byte array  <c>buf </c> . </para>        
				/// </summary>
				/// <java-name>
				/// count
				/// </java-name>
				[Dot42.DexImport("count", "I", AccessFlags = 4)]
				protected internal int Count;
				/// <summary>
				///  <para>Constructs a new <c>ByteArrayInputStream </c> on the byte array  <c>buf </c> .</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "([B)V", AccessFlags = 1)]
				public ByteArrayInputStream(sbyte[] buf) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new <c>ByteArrayInputStream </c> on the byte array  <c>buf </c> .</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "([B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public ByteArrayInputStream(byte[] buf) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new <c>ByteArrayInputStream </c> on the byte array  <c>buf </c> with the initial position set to <c>offset </c> and the number of bytes available set to <c>offset </c> + <c>length </c> .</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "([BII)V", AccessFlags = 1)]
				public ByteArrayInputStream(sbyte[] buf, int offset, int length) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new <c>ByteArrayInputStream </c> on the byte array  <c>buf </c> with the initial position set to <c>offset </c> and the number of bytes available set to <c>offset </c> + <c>length </c> .</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "([BII)V", AccessFlags = 1, IgnoreFromJava = true)]
				public ByteArrayInputStream(byte[] buf, int offset, int length) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns the number of remaining bytes.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>count - pos </c> </para>
				/// </returns>
				/// <java-name>
				/// available
				/// </java-name>
				[Dot42.DexImport("available", "()I", AccessFlags = 33)]
				public override int Available() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Closes this stream and frees resources associated with this stream.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1)]
				public override void Close() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets a mark position in this ByteArrayInputStream. The parameter  <c>readlimit </c> is ignored. Sending <c>reset() </c> will reposition the stream back to the marked position.</para> <para> <para>markSupported() </para> <para>reset() </para></para>        
				/// </summary>
				/// <java-name>
				/// mark
				/// </java-name>
				[Dot42.DexImport("mark", "(I)V", AccessFlags = 33)]
				public override void Mark(int readlimit) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Indicates whether this stream supports the <c>mark() </c> and  <c>reset() </c> methods. Returns <c>true </c> since this class supports these methods.</para> <para> <para>mark(int) </para> <para>reset() </para></para>        
				/// </summary>
				/// <returns>
				///  <para>always <c>true </c> . </para>
				/// </returns>
				/// <java-name>
				/// markSupported
				/// </java-name>
				[Dot42.DexImport("markSupported", "()Z", AccessFlags = 1)]
				public override bool MarkSupported() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Reads a single byte from the source byte array and returns it as an integer in the range from 0 to 255. Returns -1 if the end of the source array has been reached.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the byte read or -1 if the end of this stream has been reached. </para>
				/// </returns>
				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "()I", AccessFlags = 33)]
				public override int Read() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([BII)I", AccessFlags = 33)]
				public override int Read(sbyte[] buffer, int byteOffset, int byteCount) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([BII)I", AccessFlags = 33, IgnoreFromJava = true)]
				public override int Read(byte[] buffer, int byteOffset, int byteCount) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Resets this stream to the last marked location. This implementation resets the position to either the marked position, the start position supplied in the constructor or 0 if neither has been provided.</para> <para> <para>mark(int) </para></para>        
				/// </summary>
				/// <java-name>
				/// reset
				/// </java-name>
				[Dot42.DexImport("reset", "()V", AccessFlags = 33)]
				public override void Reset() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Skips <c>byteCount </c> bytes in this InputStream. Subsequent calls to <c>read </c> will not return these bytes unless <c>reset </c> is used. This implementation skips <c>byteCount </c> number of bytes in the target stream. It does nothing and returns 0 if <c>byteCount </c> is negative.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the number of bytes actually skipped. </para>
				/// </returns>
				/// <java-name>
				/// skip
				/// </java-name>
				[Dot42.DexImport("skip", "(J)J", AccessFlags = 33)]
				public override long Skip(long byteCount) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ByteArrayInputStream() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		///  <para>A specialized OutputStream for class for writing content to an (internal) byte array. As bytes are written to this stream, the byte array may be expanded to hold more bytes. When the writing is considered to be finished, a copy of the byte array can be requested from the class.</para> <para> <para>ByteArrayInputStream </para></para>    
		/// </summary>
		/// <java-name>
		/// java/io/ByteArrayOutputStream
		/// </java-name>
		[Dot42.DexImport("java/io/ByteArrayOutputStream", AccessFlags = 33)]
		public partial class ByteArrayOutputStream : global::Java.IO.OutputStream
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>The byte array containing the bytes written. </para>        
				/// </summary>
				/// <java-name>
				/// buf
				/// </java-name>
				[Dot42.DexImport("buf", "[B", AccessFlags = 4)]
				protected internal sbyte[] Buf;
				/// <summary>
				///  <para>The number of bytes written. </para>        
				/// </summary>
				/// <java-name>
				/// count
				/// </java-name>
				[Dot42.DexImport("count", "I", AccessFlags = 4)]
				protected internal int Count;
				/// <summary>
				///  <para>Constructs a new ByteArrayOutputStream with a default size of 32 bytes. If more than 32 bytes are written to this instance, the underlying byte array will expand. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ByteArrayOutputStream() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new <c>ByteArrayOutputStream </c> with a default size of  <c>size </c> bytes. If more than <c>size </c> bytes are written to this instance, the underlying byte array will expand.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public ByteArrayOutputStream(int size) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Closes this stream. This releases system resources used for this stream.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1)]
				public override void Close() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Resets this stream to the beginning of the underlying byte array. All subsequent writes will overwrite any bytes previously stored in this stream. </para>        
				/// </summary>
				/// <java-name>
				/// reset
				/// </java-name>
				[Dot42.DexImport("reset", "()V", AccessFlags = 33)]
				public virtual void Reset() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns the total number of bytes written to this stream so far.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the number of bytes written to this stream. </para>
				/// </returns>
				/// <java-name>
				/// size
				/// </java-name>
				[Dot42.DexImport("size", "()I", AccessFlags = 1)]
				public virtual int Size() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Returns the contents of this ByteArrayOutputStream as a byte array. Any changes made to the receiver after returning will not be reflected in the byte array returned to the caller.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>this stream's current contents as a byte array. </para>
				/// </returns>
				/// <java-name>
				/// toByteArray
				/// </java-name>
				[Dot42.DexImport("toByteArray", "()[B", AccessFlags = 33)]
				public virtual sbyte[] JavaToByteArray() /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <summary>
				///  <para>Returns the contents of this ByteArrayOutputStream as a byte array. Any changes made to the receiver after returning will not be reflected in the byte array returned to the caller.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>this stream's current contents as a byte array. </para>
				/// </returns>
				/// <java-name>
				/// toByteArray
				/// </java-name>
				[Dot42.DexImport("toByteArray", "()[B", AccessFlags = 33, IgnoreFromJava = true)]
				public virtual byte[] ToByteArray() /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				/// <summary>
				///  <para>Returns the contents of this ByteArrayOutputStream as a string. Any changes made to the receiver after returning will not be reflected in the string returned to the caller.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>this stream's current contents as a string. </para>
				/// </returns>
				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Returns the contents of this ByteArrayOutputStream as a string. Each byte  <c>b </c> in this stream is converted to a character <c>c </c> using the following function:  <c>c == (char)(((hibyte &amp; 0xff) &lt;&lt; 8) | (b &amp; 0xff)) </c> . This method is deprecated and either toString() or toString(String) should be used.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use toString() instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				///  <para>this stream's current contents as a string with the high byte set to <c>hibyte </c> . </para>
				/// </returns>
				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "(I)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string ToString(int hibyte) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Returns the contents of this ByteArrayOutputStream as a string. Each byte  <c>b </c> in this stream is converted to a character <c>c </c> using the following function:  <c>c == (char)(((hibyte &amp; 0xff) &lt;&lt; 8) | (b &amp; 0xff)) </c> . This method is deprecated and either toString() or toString(String) should be used.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use toString() instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				///  <para>this stream's current contents as a string with the high byte set to <c>hibyte </c> . </para>
				/// </returns>
				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string ToString(string hibyte) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Writes <c>count </c> bytes from the byte array <c>buffer </c> starting at offset <c>index </c> to this stream.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([BII)V", AccessFlags = 33)]
				public override void Write(sbyte[] buffer, int offset, int len) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Writes <c>count </c> bytes from the byte array <c>buffer </c> starting at offset <c>index </c> to this stream.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([BII)V", AccessFlags = 33, IgnoreFromJava = true)]
				public override void Write(byte[] buffer, int offset, int len) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Writes the specified byte <c>oneByte </c> to the OutputStream. Only the low order byte of <c>oneByte </c> is written.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "(I)V", AccessFlags = 33)]
				public override void Write(int oneByte) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Takes the contents of this stream and writes it to the output stream  <c>out </c> .</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// writeTo
				/// </java-name>
				[Dot42.DexImport("writeTo", "(Ljava/io/OutputStream;)V", AccessFlags = 33)]
				public virtual void WriteTo(global::Java.IO.OutputStream @out) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>A specialized Reader for reading the contents of a char array.</para> <para> <para>CharArrayWriter </para></para>    
		/// </summary>
		/// <java-name>
		/// java/io/CharArrayReader
		/// </java-name>
		[Dot42.DexImport("java/io/CharArrayReader", AccessFlags = 33)]
		public partial class CharArrayReader : global::Java.IO.Reader
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>The buffer for characters. </para>        
				/// </summary>
				/// <java-name>
				/// buf
				/// </java-name>
				[Dot42.DexImport("buf", "[C", AccessFlags = 4)]
				protected internal char[] Buf;
				/// <summary>
				///  <para>The current buffer position. </para>        
				/// </summary>
				/// <java-name>
				/// pos
				/// </java-name>
				[Dot42.DexImport("pos", "I", AccessFlags = 4)]
				protected internal int Pos;
				/// <summary>
				///  <para>The current mark position. </para>        
				/// </summary>
				/// <java-name>
				/// markedPos
				/// </java-name>
				[Dot42.DexImport("markedPos", "I", AccessFlags = 4)]
				protected internal int MarkedPos;
				/// <summary>
				///  <para>The ending index of the buffer. </para>        
				/// </summary>
				/// <java-name>
				/// count
				/// </java-name>
				[Dot42.DexImport("count", "I", AccessFlags = 4)]
				protected internal int Count;
				/// <summary>
				///  <para>Constructs a CharArrayReader on the char array <c>buf </c> . The size of the reader is set to the length of the buffer and the object to to read from is set to <c>buf </c> .</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "([C)V", AccessFlags = 1)]
				public CharArrayReader(char[] buf) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a CharArrayReader on the char array <c>buf </c> . The size of the reader is set to <c>length </c> and the start position from which to read the buffer is set to <c>offset </c> .</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "([CII)V", AccessFlags = 1)]
				public CharArrayReader(char[] buf, int offset, int length) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>This method closes this CharArrayReader. Once it is closed, you can no longer read from it. Only the first invocation of this method has any effect. </para>        
				/// </summary>
				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1)]
				public override void Close() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets a mark position in this reader. The parameter <c>readLimit </c> is ignored for CharArrayReaders. Calling <c>reset() </c> will reposition the reader back to the marked position provided the mark has not been invalidated.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// mark
				/// </java-name>
				[Dot42.DexImport("mark", "(I)V", AccessFlags = 1)]
				public override void Mark(int readLimit) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Indicates whether this reader supports the <c>mark() </c> and  <c>reset() </c> methods.</para> <para> <para>mark(int) </para> <para>reset() </para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> for CharArrayReader. </para>
				/// </returns>
				/// <java-name>
				/// markSupported
				/// </java-name>
				[Dot42.DexImport("markSupported", "()Z", AccessFlags = 1)]
				public override bool MarkSupported() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Reads a single character from this reader and returns it as an integer with the two higher-order bytes set to 0. Returns -1 if no more characters are available from this reader.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the character read as an int or -1 if the end of the reader has been reached. </para>
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
				///  <para>Reads up to <c>count </c> characters from this CharArrayReader and stores them at <c>offset </c> in the character array <c>buffer </c> . Returns the number of characters actually read or -1 if the end of reader was encountered.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([CII)I", AccessFlags = 1)]
				public override int Read(char[] buffer, int offset, int count) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Indicates whether this reader is ready to be read without blocking. Returns <c>true </c> if the next <c>read </c> will not block. Returns  <c>false </c> if this reader may or may not block when <c>read </c> is called. The implementation in CharArrayReader always returns <c>true </c> even when it has been closed.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if this reader will not block when <c>read </c> is called, <c>false </c> if unknown or blocking will occur. </para>
				/// </returns>
				/// <java-name>
				/// ready
				/// </java-name>
				[Dot42.DexImport("ready", "()Z", AccessFlags = 1)]
				public override bool Ready() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Resets this reader's position to the last <c>mark() </c> location. Invocations of <c>read() </c> and <c>skip() </c> will occur from this new location. If this reader has not been marked, it is reset to the beginning of the string.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// reset
				/// </java-name>
				[Dot42.DexImport("reset", "()V", AccessFlags = 1)]
				public override void Reset() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Skips <c>charCount </c> characters in this reader. Subsequent calls to  <c>read </c> will not return these characters unless <c>reset </c> is used. This method does nothing and returns 0 if <c>charCount &lt;= 0 </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the number of characters actually skipped. </para>
				/// </returns>
				/// <java-name>
				/// skip
				/// </java-name>
				[Dot42.DexImport("skip", "(J)J", AccessFlags = 1)]
				public override long Skip(long charCount) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal CharArrayReader() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		///  <para>A specialized Writer for class for writing content to an (internal) char array. As bytes are written to this writer, the char array may be expanded to hold more characters. When the writing is considered to be finished, a copy of the char array can be requested from the class.</para> <para> <para>CharArrayReader </para></para>    
		/// </summary>
		/// <java-name>
		/// java/io/CharArrayWriter
		/// </java-name>
		[Dot42.DexImport("java/io/CharArrayWriter", AccessFlags = 33)]
		public partial class CharArrayWriter : global::Java.IO.Writer
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>The buffer for characters. </para>        
				/// </summary>
				/// <java-name>
				/// buf
				/// </java-name>
				[Dot42.DexImport("buf", "[C", AccessFlags = 4)]
				protected internal char[] Buf;
				/// <summary>
				///  <para>The ending index of the buffer. </para>        
				/// </summary>
				/// <java-name>
				/// count
				/// </java-name>
				[Dot42.DexImport("count", "I", AccessFlags = 4)]
				protected internal int Count;
				/// <summary>
				///  <para>Constructs a new <c>CharArrayWriter </c> which has a buffer allocated with the default size of 32 characters. This buffer is also used as the  <c>lock </c> to synchronize access to this writer. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public CharArrayWriter() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new <c>CharArrayWriter </c> which has a buffer allocated with the size of <c>initialSize </c> characters. The buffer is also used as the <c>lock </c> to synchronize access to this writer.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public CharArrayWriter(int initialSize) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Closes this writer. The implementation in <c>CharArrayWriter </c> does nothing. </para>        
				/// </summary>
				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1)]
				public override void Close() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Flushes this writer. The implementation in <c>CharArrayWriter </c> does nothing. </para>        
				/// </summary>
				/// <java-name>
				/// flush
				/// </java-name>
				[Dot42.DexImport("flush", "()V", AccessFlags = 1)]
				public override void Flush() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Resets this writer. The current write position is reset to the beginning of the buffer. All written characters are lost and the size of this writer is set to 0. </para>        
				/// </summary>
				/// <java-name>
				/// reset
				/// </java-name>
				[Dot42.DexImport("reset", "()V", AccessFlags = 1)]
				public virtual void Reset() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns the size of this writer, that is the number of characters it stores. This number changes if this writer is reset or when more characters are written to it.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>this CharArrayWriter's current size in characters. </para>
				/// </returns>
				/// <java-name>
				/// size
				/// </java-name>
				[Dot42.DexImport("size", "()I", AccessFlags = 1)]
				public virtual int Size() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Returns the contents of the receiver as a char array. The array returned is a copy and any modifications made to this writer after calling this method are not reflected in the result.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>this CharArrayWriter's contents as a new char array. </para>
				/// </returns>
				/// <java-name>
				/// toCharArray
				/// </java-name>
				[Dot42.DexImport("toCharArray", "()[C", AccessFlags = 1)]
				public virtual char[] ToCharArray() /* MethodBuilder.Create */ 
				{
						return default(char[]);
				}

				/// <summary>
				///  <para>Returns the contents of this <c>CharArrayWriter </c> as a string. The string returned is a copy and any modifications made to this writer after calling this method are not reflected in the result.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>this CharArrayWriters contents as a new string. </para>
				/// </returns>
				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([CII)V", AccessFlags = 1)]
				public override void Write(char[] @char, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Writes the specified character <c>oneChar </c> to this writer. This implementation writes the two low order bytes of the integer  <c>oneChar </c> to the buffer.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "(I)V", AccessFlags = 1)]
				public override void Write(int oneChar) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "(Ljava/lang/String;II)V", AccessFlags = 1)]
				public override void Write(string @string, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Writes the contents of this <c>CharArrayWriter </c> to another <c>Writer </c> . The output is all the characters that have been written to the receiver since the last reset or since it was created.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// writeTo
				/// </java-name>
				[Dot42.DexImport("writeTo", "(Ljava/io/Writer;)V", AccessFlags = 1)]
				public virtual void WriteTo(global::Java.IO.Writer @out) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// append
				/// </java-name>
				[Dot42.DexImport("append", "(C)Ljava/io/CharArrayWriter;", AccessFlags = 1)]
				public new virtual global::Java.IO.CharArrayWriter Append(char @char) /* MethodBuilder.Create */ 
				{
						return default(global::Java.IO.CharArrayWriter);
				}

				/// <java-name>
				/// append
				/// </java-name>
				[Dot42.DexImport("append", "(Ljava/lang/CharSequence;)Ljava/io/CharArrayWriter;", AccessFlags = 1)]
				public new virtual global::Java.IO.CharArrayWriter Append(global::Java.Lang.ICharSequence charSequence) /* MethodBuilder.Create */ 
				{
						return default(global::Java.IO.CharArrayWriter);
				}

				/// <summary>
				///  <para>Append a subsequence of a <c>CharSequence </c> to the <c>CharArrayWriter </c> . The first and last characters of the subsequence are specified by the parameters <c>start </c> and <c>end </c> . A call to  <c>CharArrayWriter.append(csq) </c> works the same way as <c>CharArrayWriter.write(csq.subSequence(start, end).toString) </c> . If <c>csq </c> is <c>null </c> , then it will be substituted with the string <c>"null" </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>this CharArrayWriter. </para>
				/// </returns>
				/// <java-name>
				/// append
				/// </java-name>
				[Dot42.DexImport("append", "(Ljava/lang/CharSequence;II)Ljava/io/CharArrayWriter;", AccessFlags = 1)]
				public new virtual global::Java.IO.CharArrayWriter JavaAppend(global::Java.Lang.ICharSequence csq, int start, int end) /* MethodBuilder.Create */ 
				{
						return default(global::Java.IO.CharArrayWriter);
				}

		}

		/// <summary>
		///  <para>The top level class for character conversion exceptions. </para>    
		/// </summary>
		/// <java-name>
		/// java/io/CharConversionException
		/// </java-name>
		[Dot42.DexImport("java/io/CharConversionException", AccessFlags = 33)]
		public partial class CharConversionException : global::System.IO.IOException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructs a new <c>CharConversionException </c> with its stack trace filled in. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public CharConversionException() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new <c>CharConversionException </c> with its stack trace and detail message filled in.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public CharConversionException(string detailMessage) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>Provides access to the console, if available. The system-wide instance can be accessed via java.lang.System#console.  <para>1.6 </para></para>    
		/// </summary>
		/// <java-name>
		/// java/io/Console
		/// </java-name>
		[Dot42.DexImport("java/io/Console", AccessFlags = 49)]
		public sealed partial class Console : global::Java.IO.IFlushable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal Console() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Flushes the object by writing out any buffered data to the underlying output.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// flush
				/// </java-name>
				[Dot42.DexImport("flush", "()V", AccessFlags = 1)]
				public void Flush() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Writes a formatted string to the console using the specified format string and arguments.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the console instance. </para>
				/// </returns>
				/// <java-name>
				/// format
				/// </java-name>
				[Dot42.DexImport("format", "(Ljava/lang/String;[Ljava/lang/Object;)Ljava/io/Console;", AccessFlags = 129)]
				public global::Java.IO.Console Format(string format, params object[] args) /* MethodBuilder.Create */ 
				{
						return default(global::Java.IO.Console);
				}

				/// <summary>
				///  <para>Equivalent to <c>format(format, args) </c> . </para>        
				/// </summary>
				/// <java-name>
				/// printf
				/// </java-name>
				[Dot42.DexImport("printf", "(Ljava/lang/String;[Ljava/lang/Object;)Ljava/io/Console;", AccessFlags = 129)]
				public global::Java.IO.Console Printf(string format, params object[] args) /* MethodBuilder.Create */ 
				{
						return default(global::Java.IO.Console);
				}

				/// <summary>
				///  <para>Returns the Reader associated with this console. </para>        
				/// </summary>
				/// <java-name>
				/// reader
				/// </java-name>
				[Dot42.DexImport("reader", "()Ljava/io/Reader;", AccessFlags = 1)]
				public global::Java.IO.Reader Reader() /* MethodBuilder.Create */ 
				{
						return default(global::Java.IO.Reader);
				}

				/// <summary>
				///  <para>Reads a line from the console.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the line, or null at EOF. </para>
				/// </returns>
				/// <java-name>
				/// readLine
				/// </java-name>
				[Dot42.DexImport("readLine", "()Ljava/lang/String;", AccessFlags = 1)]
				public string ReadLine() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Reads a line from this console, using the specified prompt. The prompt is given as a format string and optional arguments. Note that this can be a source of errors: if it is possible that your prompt contains <c>% </c> characters, you must use the format string <c>"%s" </c> and pass the actual prompt as a parameter.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the line, or null at EOF. </para>
				/// </returns>
				/// <java-name>
				/// readLine
				/// </java-name>
				[Dot42.DexImport("readLine", "(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;", AccessFlags = 129)]
				public string ReadLine(string format, params object[] args) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Reads a password from the console. The password will not be echoed to the display.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a character array containing the password, or null at EOF. </para>
				/// </returns>
				/// <java-name>
				/// readPassword
				/// </java-name>
				[Dot42.DexImport("readPassword", "()[C", AccessFlags = 1)]
				public char[] ReadPassword() /* MethodBuilder.Create */ 
				{
						return default(char[]);
				}

				/// <summary>
				///  <para>Reads a password from the console. The password will not be echoed to the display. A formatted prompt is also displayed.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a character array containing the password, or null at EOF. </para>
				/// </returns>
				/// <java-name>
				/// readPassword
				/// </java-name>
				[Dot42.DexImport("readPassword", "(Ljava/lang/String;[Ljava/lang/Object;)[C", AccessFlags = 129)]
				public char[] ReadPassword(string format, params object[] args) /* MethodBuilder.Create */ 
				{
						return default(char[]);
				}

				/// <summary>
				///  <para>Returns the Writer associated with this console. </para>        
				/// </summary>
				/// <java-name>
				/// writer
				/// </java-name>
				[Dot42.DexImport("writer", "()Ljava/io/PrintWriter;", AccessFlags = 1)]
				public global::Java.IO.PrintWriter Writer() /* MethodBuilder.Create */ 
				{
						return default(global::Java.IO.PrintWriter);
				}

		}

		/// <summary>
		///  <para>Wraps an existing InputStream and reads big-endian typed data from it. Typically, this stream has been written by a DataOutputStream. Types that can be read include byte, 16-bit short, 32-bit int, 32-bit float, 64-bit long, 64-bit double, byte strings, and strings encoded in modified UTF-8.</para> <para> <para>DataOutputStream </para></para>    
		/// </summary>
		/// <java-name>
		/// java/io/DataInputStream
		/// </java-name>
		[Dot42.DexImport("java/io/DataInputStream", AccessFlags = 33)]
		public partial class DataInputStream : global::Java.IO.FilterInputStream, global::Java.IO.IDataInput
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructs a new DataInputStream on the InputStream <c>in </c> . All reads are then filtered through this stream. Note that data read by this stream is not in a human readable format and was most likely created by a DataOutputStream.</para> <para> <b>Warning:</b> passing a null source creates an invalid  <c>DataInputStream </c> . All operations on such a stream will fail.</para> <para> <para>DataOutputStream </para> <para>RandomAccessFile </para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/io/InputStream;)V", AccessFlags = 1)]
				public DataInputStream(global::Java.IO.InputStream @in) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([B)I", AccessFlags = 17)]
				public override int Read(sbyte[] buffer) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([B)I", AccessFlags = 17, IgnoreFromJava = true)]
				public override int Read(byte[] buffer) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([BII)I", AccessFlags = 17)]
				public override int Read(sbyte[] buffer, int byteOffset, int byteCount) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([BII)I", AccessFlags = 17, IgnoreFromJava = true)]
				public override int Read(byte[] buffer, int byteOffset, int byteCount) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Reads a boolean.</para> <para> <para>DataOutput::writeBoolean(boolean) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the next boolean value. </para>
				/// </returns>
				/// <java-name>
				/// readBoolean
				/// </java-name>
				[Dot42.DexImport("readBoolean", "()Z", AccessFlags = 17)]
				public bool ReadBoolean() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Reads an 8-bit byte value.</para> <para> <para>DataOutput::writeByte(int) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the next byte value. </para>
				/// </returns>
				/// <java-name>
				/// readByte
				/// </java-name>
				[Dot42.DexImport("readByte", "()B", AccessFlags = 17)]
				public sbyte JavaReadByte() /* MethodBuilder.Create */ 
				{
						return default(sbyte);
				}

				/// <summary>
				///  <para>Reads an 8-bit byte value.</para> <para> <para>DataOutput::writeByte(int) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the next byte value. </para>
				/// </returns>
				/// <java-name>
				/// readByte
				/// </java-name>
				[Dot42.DexImport("readByte", "()B", AccessFlags = 17, IgnoreFromJava = true)]
				public byte ReadByte() /* MethodBuilder.Create */ 
				{
						return default(byte);
				}

				/// <summary>
				///  <para>Reads a big-endian 16-bit character value.</para> <para> <para>DataOutput::writeChar(int) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the next char value. </para>
				/// </returns>
				/// <java-name>
				/// readChar
				/// </java-name>
				[Dot42.DexImport("readChar", "()C", AccessFlags = 17)]
				public char ReadChar() /* MethodBuilder.Create */ 
				{
						return default(char);
				}

				/// <summary>
				///  <para>Reads a big-endian 64-bit double value.</para> <para> <para>DataOutput::writeDouble(double) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the next double value. </para>
				/// </returns>
				/// <java-name>
				/// readDouble
				/// </java-name>
				[Dot42.DexImport("readDouble", "()D", AccessFlags = 17)]
				public double ReadDouble() /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <summary>
				///  <para>Reads a big-endian 32-bit float value.</para> <para> <para>DataOutput::writeFloat(float) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the next float value. </para>
				/// </returns>
				/// <java-name>
				/// readFloat
				/// </java-name>
				[Dot42.DexImport("readFloat", "()F", AccessFlags = 17)]
				public float ReadFloat() /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				///  <para>Equivalent to <c>readFully(dst, 0, dst.length); </c> . </para>        
				/// </summary>
				/// <java-name>
				/// readFully
				/// </java-name>
				[Dot42.DexImport("readFully", "([B)V", AccessFlags = 17)]
				public void ReadFully(sbyte[] dst) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Equivalent to <c>readFully(dst, 0, dst.length); </c> . </para>        
				/// </summary>
				/// <java-name>
				/// readFully
				/// </java-name>
				[Dot42.DexImport("readFully", "([B)V", AccessFlags = 17, IgnoreFromJava = true)]
				public void ReadFully(byte[] dst) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Reads <c>byteCount </c> bytes from this stream and stores them in the byte array <c>dst </c> starting at <c>offset </c> . If <c>byteCount </c> is zero, then this method returns without reading any bytes. Otherwise, this method blocks until  <c>byteCount </c> bytes have been read. If insufficient bytes are available,  <c>EOFException </c> is thrown. If an I/O error occurs, <c>IOException </c> is thrown. When an exception is thrown, some bytes may have been consumed from the stream and written into the array.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// readFully
				/// </java-name>
				[Dot42.DexImport("readFully", "([BII)V", AccessFlags = 17)]
				public void ReadFully(sbyte[] dst, int offset, int byteCount) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Reads <c>byteCount </c> bytes from this stream and stores them in the byte array <c>dst </c> starting at <c>offset </c> . If <c>byteCount </c> is zero, then this method returns without reading any bytes. Otherwise, this method blocks until  <c>byteCount </c> bytes have been read. If insufficient bytes are available,  <c>EOFException </c> is thrown. If an I/O error occurs, <c>IOException </c> is thrown. When an exception is thrown, some bytes may have been consumed from the stream and written into the array.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// readFully
				/// </java-name>
				[Dot42.DexImport("readFully", "([BII)V", AccessFlags = 17, IgnoreFromJava = true)]
				public void ReadFully(byte[] dst, int offset, int byteCount) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Reads a big-endian 32-bit integer value.</para> <para> <para>DataOutput::writeInt(int) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the next int value. </para>
				/// </returns>
				/// <java-name>
				/// readInt
				/// </java-name>
				[Dot42.DexImport("readInt", "()I", AccessFlags = 17)]
				public int ReadInt() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>This method cannot be trusted to convert bytes to characters correctly. Wrap this stream with a BufferedReader instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// readLine
				/// </java-name>
				[Dot42.DexImport("readLine", "()Ljava/lang/String;", AccessFlags = 17)]
				public string ReadLine() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Reads a big-endian 64-bit long value.</para> <para> <para>DataOutput::writeLong(long) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the next long value. </para>
				/// </returns>
				/// <java-name>
				/// readLong
				/// </java-name>
				[Dot42.DexImport("readLong", "()J", AccessFlags = 17)]
				public long ReadLong() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				///  <para>Reads a big-endian 16-bit short value.</para> <para> <para>DataOutput::writeShort(int) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the next short value. </para>
				/// </returns>
				/// <java-name>
				/// readShort
				/// </java-name>
				[Dot42.DexImport("readShort", "()S", AccessFlags = 17)]
				public short ReadShort() /* MethodBuilder.Create */ 
				{
						return default(short);
				}

				/// <summary>
				///  <para>Reads an unsigned 8-bit byte value and returns it as an int.</para> <para> <para>DataOutput::writeByte(int) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the next unsigned byte value. </para>
				/// </returns>
				/// <java-name>
				/// readUnsignedByte
				/// </java-name>
				[Dot42.DexImport("readUnsignedByte", "()I", AccessFlags = 17)]
				public int ReadUnsignedByte() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Reads a big-endian 16-bit unsigned short value and returns it as an int.</para> <para> <para>DataOutput::writeShort(int) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the next unsigned short value. </para>
				/// </returns>
				/// <java-name>
				/// readUnsignedShort
				/// </java-name>
				[Dot42.DexImport("readUnsignedShort", "()I", AccessFlags = 17)]
				public int ReadUnsignedShort() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Reads a string encoded with modified UTF-8.</para> <para> <para>DataOutput::writeUTF(java.lang.String) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the next string encoded with modified UTF-8. </para>
				/// </returns>
				/// <java-name>
				/// readUTF
				/// </java-name>
				[Dot42.DexImport("readUTF", "()Ljava/lang/String;", AccessFlags = 17)]
				public string ReadUTF() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// readUTF
				/// </java-name>
				[Dot42.DexImport("readUTF", "(Ljava/io/DataInput;)Ljava/lang/String;", AccessFlags = 25)]
				public static string ReadUTF(global::Java.IO.IDataInput @in) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Skips <c>count </c> number of bytes in this stream. Subsequent <c>read() </c> s will not return these bytes unless <c>reset() </c> is used.</para> <para>This method will not throw an EOFException if the end of the input is reached before <c>count </c> bytes where skipped.</para> <para> <para>mark(int) </para> <para>reset() </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the number of bytes actually skipped. </para>
				/// </returns>
				/// <java-name>
				/// skipBytes
				/// </java-name>
				[Dot42.DexImport("skipBytes", "(I)I", AccessFlags = 17)]
				public int SkipBytes(int count) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal DataInputStream() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		///  <para>Wraps an existing OutputStream and writes big-endian typed data to it. Typically, this stream can be read in by DataInputStream. Types that can be written include byte, 16-bit short, 32-bit int, 32-bit float, 64-bit long, 64-bit double, byte strings, and MUTF-8 encoded strings.</para> <para> <para>DataInputStream </para></para>    
		/// </summary>
		/// <java-name>
		/// java/io/DataOutputStream
		/// </java-name>
		[Dot42.DexImport("java/io/DataOutputStream", AccessFlags = 33)]
		public partial class DataOutputStream : global::Java.IO.FilterOutputStream, global::Java.IO.IDataOutput
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>The number of bytes written out so far. </para>        
				/// </summary>
				/// <java-name>
				/// written
				/// </java-name>
				[Dot42.DexImport("written", "I", AccessFlags = 4)]
				protected internal int Written;
				/// <summary>
				///  <para>Constructs a new <c>DataOutputStream </c> on the <c>OutputStream </c>  <c>out </c> . Note that data written by this stream is not in a human readable form but can be reconstructed by using a DataInputStream on the resulting output.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/io/OutputStream;)V", AccessFlags = 1)]
				public DataOutputStream(global::Java.IO.OutputStream @out) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Flushes this stream to ensure all pending data is sent out to the target stream. This implementation then also flushes the target stream.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// flush
				/// </java-name>
				[Dot42.DexImport("flush", "()V", AccessFlags = 1)]
				public override void Flush() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns the total number of bytes written to the target stream so far.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the number of bytes written to the target stream. </para>
				/// </returns>
				/// <java-name>
				/// size
				/// </java-name>
				[Dot42.DexImport("size", "()I", AccessFlags = 17)]
				public int Size() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Writes <c>count </c> bytes from the byte array <c>buffer </c> starting at  <c>offset </c> to the target stream.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([BII)V", AccessFlags = 1)]
				public override void Write(sbyte[] buffer, int offset, int count) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Writes <c>count </c> bytes from the byte array <c>buffer </c> starting at  <c>offset </c> to the target stream.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([BII)V", AccessFlags = 1, IgnoreFromJava = true)]
				public override void Write(byte[] buffer, int offset, int count) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Writes a byte to the target stream. Only the least significant byte of the integer <c>oneByte </c> is written.</para> <para> <para>DataInputStream::readByte() </para></para>        
				/// </summary>
				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "(I)V", AccessFlags = 1)]
				public override void Write(int oneByte) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Writes a boolean to the target stream.</para> <para> <para>DataInputStream::readBoolean() </para></para>        
				/// </summary>
				/// <java-name>
				/// writeBoolean
				/// </java-name>
				[Dot42.DexImport("writeBoolean", "(Z)V", AccessFlags = 17)]
				public void WriteBoolean(bool val) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Writes an 8-bit byte to the target stream. Only the least significant byte of the integer <c>val </c> is written.</para> <para> <para>DataInputStream::readByte() </para> <para>DataInputStream::readUnsignedByte() </para></para>        
				/// </summary>
				/// <java-name>
				/// writeByte
				/// </java-name>
				[Dot42.DexImport("writeByte", "(I)V", AccessFlags = 17)]
				public void WriteByte(int val) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Writes the low order 8-bit bytes from the specified string.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// writeBytes
				/// </java-name>
				[Dot42.DexImport("writeBytes", "(Ljava/lang/String;)V", AccessFlags = 17)]
				public void WriteBytes(string str) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Writes the specified 16-bit character in big-endian order. Only the two least significant bytes of the integer <c>oneByte </c> are written.</para> <para> <para>DataInput::readChar() </para></para>        
				/// </summary>
				/// <java-name>
				/// writeChar
				/// </java-name>
				[Dot42.DexImport("writeChar", "(I)V", AccessFlags = 17)]
				public void WriteChar(int val) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Writes the 16-bit characters contained in <c>str </c> in big-endian order.</para> <para> <para>DataInput::readChar() </para></para>        
				/// </summary>
				/// <java-name>
				/// writeChars
				/// </java-name>
				[Dot42.DexImport("writeChars", "(Ljava/lang/String;)V", AccessFlags = 17)]
				public void WriteChars(string str) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Writes the specified 64-bit double in big-endian order. The resulting output is the eight bytes returned by Double#doubleToLongBits(double).</para> <para> <para>DataInput::readDouble() </para></para>        
				/// </summary>
				/// <java-name>
				/// writeDouble
				/// </java-name>
				[Dot42.DexImport("writeDouble", "(D)V", AccessFlags = 17)]
				public void WriteDouble(double val) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Writes the specified 32-bit float in big-endian order. The resulting output is the four bytes returned by Float#floatToIntBits(float).</para> <para> <para>DataInput::readFloat() </para></para>        
				/// </summary>
				/// <java-name>
				/// writeFloat
				/// </java-name>
				[Dot42.DexImport("writeFloat", "(F)V", AccessFlags = 17)]
				public void WriteFloat(float val) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Writes the specified 32-bit int in big-endian order.</para> <para> <para>DataInput::readInt() </para></para>        
				/// </summary>
				/// <java-name>
				/// writeInt
				/// </java-name>
				[Dot42.DexImport("writeInt", "(I)V", AccessFlags = 17)]
				public void WriteInt(int val) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Writes the specified 64-bit long in big-endian order.</para> <para> <para>DataInput::readLong() </para></para>        
				/// </summary>
				/// <java-name>
				/// writeLong
				/// </java-name>
				[Dot42.DexImport("writeLong", "(J)V", AccessFlags = 17)]
				public void WriteLong(long val) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Writes the specified 16-bit short in big-endian order. Only the lower two bytes of <c>val </c> are written.</para> <para> <para>DataInput::readShort() </para> <para>DataInput::readUnsignedShort() </para></para>        
				/// </summary>
				/// <java-name>
				/// writeShort
				/// </java-name>
				[Dot42.DexImport("writeShort", "(I)V", AccessFlags = 17)]
				public void WriteShort(int val) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Writes the specified string encoded in modified UTF-8.</para> <para> <para>DataInput::readUTF() </para></para>        
				/// </summary>
				/// <java-name>
				/// writeUTF
				/// </java-name>
				[Dot42.DexImport("writeUTF", "(Ljava/lang/String;)V", AccessFlags = 17)]
				public void WriteUTF(string str) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal DataOutputStream() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				[Dot42.DexImport("java/io/DataOutput", "write", "([B)V", AccessFlags = 1025)]
				public override void Write(sbyte[] oneByte) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

		}

		/// <summary>
		///  <para>An "abstract" representation of a file system entity identified by a pathname. The pathname may be absolute (relative to the root directory of the file system) or relative to the current directory in which the program is running.</para> <para>The actual file referenced by a <c>File </c> may or may not exist. It may also, despite the name <c>File </c> , be a directory or other non-regular file.</para> <para>This class provides limited functionality for getting/setting file permissions, file type, and last modified time.</para> <para>On Android strings are converted to UTF-8 byte sequences when sending filenames to the operating system, and byte sequences returned by the operating system (from the various <c>list </c> methods) are converted to strings by decoding them as UTF-8 byte sequences.</para> <para> <para>java.io.Serializable </para> <para>java.lang.Comparable </para></para>    
		/// </summary>
		/// <java-name>
		/// java/io/File
		/// </java-name>
		[Dot42.DexImport("java/io/File", AccessFlags = 33, Signature = "Ljava/lang/Object;Ljava/io/Serializable;Ljava/lang/Comparable<Ljava/io/File;>;")]
		public partial class File : global::Java.IO.ISerializable, global::System.IComparable<global::Java.IO.File>
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>The system-dependent character used to separate components in filenames ('/'). Use of this (rather than hard-coding '/') helps portability to other operating systems.</para> <para>This field is initialized from the system property "file.separator". Later changes to that property will have no effect on this field or this class. </para>        
				/// </summary>
				/// <java-name>
				/// separatorChar
				/// </java-name>
				[Dot42.DexImport("separatorChar", "C", AccessFlags = 25)]
				public static readonly char SeparatorChar;
				/// <summary>
				///  <para>The system-dependent string used to separate components in filenames ('/'). See separatorChar. </para>        
				/// </summary>
				/// <java-name>
				/// separator
				/// </java-name>
				[Dot42.DexImport("separator", "Ljava/lang/String;", AccessFlags = 25)]
				public static readonly string Separator;
				/// <summary>
				///  <para>The system-dependent character used to separate components in search paths (':'). This is used to split such things as the PATH environment variable and classpath system properties into lists of directories to be searched.</para> <para>This field is initialized from the system property "path.separator". Later changes to that property will have no effect on this field or this class. </para>        
				/// </summary>
				/// <java-name>
				/// pathSeparatorChar
				/// </java-name>
				[Dot42.DexImport("pathSeparatorChar", "C", AccessFlags = 25)]
				public static readonly char PathSeparatorChar;
				/// <summary>
				///  <para>The system-dependent string used to separate components in search paths (":"). See pathSeparatorChar. </para>        
				/// </summary>
				/// <java-name>
				/// pathSeparator
				/// </java-name>
				[Dot42.DexImport("pathSeparator", "Ljava/lang/String;", AccessFlags = 25)]
				public static readonly string PathSeparator;
				[Dot42.DexImport("<init>", "(Ljava/io/File;Ljava/lang/String;)V", AccessFlags = 1)]
				public File(global::Java.IO.File file, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new File using the path of the specified URI. <c>uri </c> needs to be an absolute and hierarchical Unified Resource Identifier with file scheme and non-empty path component, but with undefined authority, query or fragment components.</para> <para> <para>toURI </para> <para>java.net.URI </para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public File(string uri) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public File(string @string, string string1) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new File using the path of the specified URI. <c>uri </c> needs to be an absolute and hierarchical Unified Resource Identifier with file scheme and non-empty path component, but with undefined authority, query or fragment components.</para> <para> <para>toURI </para> <para>java.net.URI </para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/net/URI;)V", AccessFlags = 1)]
				public File(global::System.Uri uri) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns the file system roots. On Android and other Unix systems, there is a single root, <c>/ </c> . </para>        
				/// </summary>
				/// <java-name>
				/// listRoots
				/// </java-name>
				[Dot42.DexImport("listRoots", "()[Ljava/io/File;", AccessFlags = 9)]
				public static global::Java.IO.File[] ListRoots() /* MethodBuilder.Create */ 
				{
						return default(global::Java.IO.File[]);
				}

				/// <summary>
				///  <para>Returns the relative sort ordering of the paths for this file and the file <c>another </c> . The ordering is platform dependent.</para> <para> <para>Comparable </para></para>        
				/// </summary>
				/// <returns>
				///  <para>an int determined by comparing the two paths. Possible values are described in the Comparable interface. </para>
				/// </returns>
				/// <java-name>
				/// compareTo
				/// </java-name>
				[Dot42.DexImport("compareTo", "(Ljava/io/File;)I", AccessFlags = 1)]
				public virtual int CompareTo(global::Java.IO.File another) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Deletes this file. Directories must be empty before they will be deleted.</para> <para>Note that this method does  <b>not</b> throw <c>IOException </c> on failure. Callers must check the return value.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if this file was deleted, <c>false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// delete
				/// </java-name>
				[Dot42.DexImport("delete", "()Z", AccessFlags = 1)]
				public virtual bool Delete() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Schedules this file to be automatically deleted when the VM terminates normally.</para> <para> <b>Note that on Android, the application lifecycle does not include VM termination, so calling this method will not ensure that files are deleted</b>. Instead, you should use the most appropriate out of:  <ul> <li> <para>Use a <c>finally </c> clause to manually invoke delete. </para></li> <li> <para>Maintain your own set of files to delete, and process it at an appropriate point in your application's lifecycle. </para></li> <li> <para>Use the Unix trick of deleting the file as soon as all readers and writers have opened it. No new readers/writers will be able to access the file, but all existing ones will still have access until the last one closes the file. </para></li></ul></para>        
				/// </summary>
				/// <java-name>
				/// deleteOnExit
				/// </java-name>
				[Dot42.DexImport("deleteOnExit", "()V", AccessFlags = 1)]
				public virtual void DeleteOnExit() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Compares <c>obj </c> to this file and returns <c>true </c> if they represent the  <b>same</b> object using a path specific comparison.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if <c>obj </c> is the same as this object,  <c>false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object obj) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Returns a boolean indicating whether this file can be found on the underlying file system.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if this file exists, <c>false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// exists
				/// </java-name>
				[Dot42.DexImport("exists", "()Z", AccessFlags = 1)]
				public virtual bool Exists() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Returns an integer hash code for the receiver. Any two objects for which  <c>equals </c> returns <c>true </c> must return the same hash code.</para> <para> <para>equals </para></para>        
				/// </summary>
				/// <returns>
				///  <para>this files's hash value. </para>
				/// </returns>
				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 1)]
				public override int GetHashCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Returns the time when this file was last modified, measured in milliseconds since January 1st, 1970, midnight. Returns 0 if the file does not exist.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the time when this file was last modified. </para>
				/// </returns>
				/// <java-name>
				/// lastModified
				/// </java-name>
				[Dot42.DexImport("lastModified", "()J", AccessFlags = 1)]
				public virtual long LastModified() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				///  <para>Sets the time this file was last modified, measured in milliseconds since January 1st, 1970, midnight.</para> <para>Note that this method does  <b>not</b> throw <c>IOException </c> on failure. Callers must check the return value.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if the operation is successful, <c>false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// setLastModified
				/// </java-name>
				[Dot42.DexImport("setLastModified", "(J)Z", AccessFlags = 1)]
				public virtual bool SetLastModified(long time) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Equivalent to setWritable(false, false).</para> <para> <para>setWritable(boolean, boolean) </para></para>        
				/// </summary>
				/// <java-name>
				/// setReadOnly
				/// </java-name>
				[Dot42.DexImport("setReadOnly", "()Z", AccessFlags = 1)]
				public virtual bool SetReadOnly() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Manipulates the execute permissions for the abstract path designated by this file.</para> <para>Note that this method does  <b>not</b> throw <c>IOException </c> on failure. Callers must check the return value.</para> <para> <para>1.6 </para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if and only if the operation succeeded. If the user does not have permission to change the access permissions of this abstract pathname the operation will fail. If the underlying file system does not support execute permission and the value of executable is false, this operation will fail. </para>
				/// </returns>
				/// <java-name>
				/// setExecutable
				/// </java-name>
				[Dot42.DexImport("setExecutable", "(ZZ)Z", AccessFlags = 1)]
				public virtual bool SetExecutable(bool executable, bool ownerOnly) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Equivalent to setExecutable(executable, true).  <para>setExecutable(boolean, boolean) </para> <para>1.6 </para></para>        
				/// </summary>
				/// <java-name>
				/// setExecutable
				/// </java-name>
				[Dot42.DexImport("setExecutable", "(Z)Z", AccessFlags = 1)]
				public virtual bool SetExecutable(bool executable) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Manipulates the read permissions for the abstract path designated by this file.</para> <para> <para>1.6 </para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if and only if the operation succeeded. If the user does not have permission to change the access permissions of this abstract pathname the operation will fail. If the underlying file system does not support read permission and the value of readable is false, this operation will fail. </para>
				/// </returns>
				/// <java-name>
				/// setReadable
				/// </java-name>
				[Dot42.DexImport("setReadable", "(ZZ)Z", AccessFlags = 1)]
				public virtual bool SetReadable(bool readable, bool ownerOnly) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Equivalent to setReadable(readable, true).  <para>setReadable(boolean, boolean) </para> <para>1.6 </para></para>        
				/// </summary>
				/// <java-name>
				/// setReadable
				/// </java-name>
				[Dot42.DexImport("setReadable", "(Z)Z", AccessFlags = 1)]
				public virtual bool SetReadable(bool readable) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Manipulates the write permissions for the abstract path designated by this file.</para> <para> <para>1.6 </para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if and only if the operation succeeded. If the user does not have permission to change the access permissions of this abstract pathname the operation will fail. </para>
				/// </returns>
				/// <java-name>
				/// setWritable
				/// </java-name>
				[Dot42.DexImport("setWritable", "(ZZ)Z", AccessFlags = 1)]
				public virtual bool SetWritable(bool writable, bool ownerOnly) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Equivalent to setWritable(writable, true).  <para>setWritable(boolean, boolean) </para> <para>1.6 </para></para>        
				/// </summary>
				/// <java-name>
				/// setWritable
				/// </java-name>
				[Dot42.DexImport("setWritable", "(Z)Z", AccessFlags = 1)]
				public virtual bool SetWritable(bool writable) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Returns the length of this file in bytes. Returns 0 if the file does not exist. The result for a directory is not defined.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the number of bytes in this file. </para>
				/// </returns>
				/// <java-name>
				/// length
				/// </java-name>
				[Dot42.DexImport("length", "()J", AccessFlags = 1)]
				public virtual long Length() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				///  <para>Returns an array of strings with the file names in the directory represented by this file. The result is <c>null </c> if this file is not a directory. </para> <para>The entries <c>. </c> and <c>.. </c> representing the current and parent directory are not returned as part of the list.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>an array of strings with file names or <c>null </c> . </para>
				/// </returns>
				/// <java-name>
				/// list
				/// </java-name>
				[Dot42.DexImport("list", "()[Ljava/lang/String;", AccessFlags = 1)]
				public virtual string[] List() /* MethodBuilder.Create */ 
				{
						return default(string[]);
				}

				/// <summary>
				///  <para>Gets a list of the files in the directory represented by this file. This list is then filtered through a FilenameFilter and the names of files with matching names are returned as an array of strings. Returns  <c>null </c> if this file is not a directory. If <c>filter </c> is  <c>null </c> then all filenames match. </para> <para>The entries <c>. </c> and <c>.. </c> representing the current and parent directories are not returned as part of the list.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>an array of files or <c>null </c> . </para>
				/// </returns>
				/// <java-name>
				/// list
				/// </java-name>
				[Dot42.DexImport("list", "(Ljava/io/FilenameFilter;)[Ljava/lang/String;", AccessFlags = 1)]
				public virtual string[] List(global::Java.IO.IFilenameFilter filter) /* MethodBuilder.Create */ 
				{
						return default(string[]);
				}

				/// <summary>
				///  <para>Returns an array of files contained in the directory represented by this file. The result is <c>null </c> if this file is not a directory. The paths of the files in the array are absolute if the path of this file is absolute, they are relative otherwise.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>an array of files or <c>null </c> . </para>
				/// </returns>
				/// <java-name>
				/// listFiles
				/// </java-name>
				[Dot42.DexImport("listFiles", "()[Ljava/io/File;", AccessFlags = 1)]
				public virtual global::Java.IO.File[] ListFiles() /* MethodBuilder.Create */ 
				{
						return default(global::Java.IO.File[]);
				}

				/// <summary>
				///  <para>Gets a list of the files in the directory represented by this file. This list is then filtered through a FilenameFilter and files with matching names are returned as an array of files. Returns <c>null </c> if this file is not a directory. If <c>filter </c> is <c>null </c> then all filenames match. </para> <para>The entries <c>. </c> and <c>.. </c> representing the current and parent directories are not returned as part of the list.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>an array of files or <c>null </c> . </para>
				/// </returns>
				/// <java-name>
				/// listFiles
				/// </java-name>
				[Dot42.DexImport("listFiles", "(Ljava/io/FilenameFilter;)[Ljava/io/File;", AccessFlags = 1)]
				public virtual global::Java.IO.File[] ListFiles(global::Java.IO.IFilenameFilter filter) /* MethodBuilder.Create */ 
				{
						return default(global::Java.IO.File[]);
				}

				/// <summary>
				///  <para>Gets a list of the files in the directory represented by this file. This list is then filtered through a FilenameFilter and files with matching names are returned as an array of files. Returns <c>null </c> if this file is not a directory. If <c>filter </c> is <c>null </c> then all filenames match. </para> <para>The entries <c>. </c> and <c>.. </c> representing the current and parent directories are not returned as part of the list.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>an array of files or <c>null </c> . </para>
				/// </returns>
				/// <java-name>
				/// listFiles
				/// </java-name>
				[Dot42.DexImport("listFiles", "(Ljava/io/FileFilter;)[Ljava/io/File;", AccessFlags = 1)]
				public virtual global::Java.IO.File[] ListFiles(global::Java.IO.IFileFilter filter) /* MethodBuilder.Create */ 
				{
						return default(global::Java.IO.File[]);
				}

				/// <summary>
				///  <para>Creates the directory named by this file, assuming its parents exist. Use mkdirs if you also want to create missing parents.</para> <para>Note that this method does  <b>not</b> throw <c>IOException </c> on failure. Callers must check the return value. Note also that this method returns false if the directory already existed. If you want to know whether the directory exists on return, either use <c>(f.mkdir() || f.isDirectory()) </c> or simply ignore the return value from this method and simply call isDirectory.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if the directory was created,  <c>false </c> on failure or if the directory already existed. </para>
				/// </returns>
				/// <java-name>
				/// mkdir
				/// </java-name>
				[Dot42.DexImport("mkdir", "()Z", AccessFlags = 1)]
				public virtual bool Mkdir() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Creates the directory named by this file, creating missing parent directories if necessary. Use mkdir if you don't want to create missing parents.</para> <para>Note that this method does  <b>not</b> throw <c>IOException </c> on failure. Callers must check the return value. Note also that this method returns false if the directory already existed. If you want to know whether the directory exists on return, either use <c>(f.mkdirs() || f.isDirectory()) </c> or simply ignore the return value from this method and simply call isDirectory.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if the directory was created,  <c>false </c> on failure or if the directory already existed. </para>
				/// </returns>
				/// <java-name>
				/// mkdirs
				/// </java-name>
				[Dot42.DexImport("mkdirs", "()Z", AccessFlags = 1)]
				public virtual bool Mkdirs() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Creates a new, empty file on the file system according to the path information stored in this file. This method returns true if it creates a file, false if the file already existed. Note that it returns false even if the file is not a file (because it's a directory, say).</para> <para>This method is not generally useful. For creating temporary files, use createTempFile instead. For reading/writing files, use FileInputStream, FileOutputStream, or RandomAccessFile, all of which can create files.</para> <para>Note that this method does  <b>not</b> throw <c>IOException </c> if the file already exists, even if it's not a regular file. Callers should always check the return value, and may additionally want to call isFile.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if the file has been created, false if it already exists. </para>
				/// </returns>
				/// <java-name>
				/// createNewFile
				/// </java-name>
				[Dot42.DexImport("createNewFile", "()Z", AccessFlags = 1)]
				public virtual bool CreateNewFile() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Creates an empty temporary file using the given prefix and suffix as part of the file name. If <c>suffix </c> is null, <c>.tmp </c> is used. This method is a convenience method that calls createTempFile(String, String, File) with the third argument being <c>null </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the temporary file. </para>
				/// </returns>
				/// <java-name>
				/// createTempFile
				/// </java-name>
				[Dot42.DexImport("createTempFile", "(Ljava/lang/String;Ljava/lang/String;)Ljava/io/File;", AccessFlags = 9)]
				public static global::Java.IO.File CreateTempFile(string prefix, string suffix) /* MethodBuilder.Create */ 
				{
						return default(global::Java.IO.File);
				}

				/// <summary>
				///  <para>Creates an empty temporary file in the given directory using the given prefix and suffix as part of the file name. If <c>suffix </c> is null, <c>.tmp </c> is used.</para> <para>Note that this method does  <b>not</b> call deleteOnExit, but see the documentation for that method before you call it manually.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the temporary file. </para>
				/// </returns>
				/// <java-name>
				/// createTempFile
				/// </java-name>
				[Dot42.DexImport("createTempFile", "(Ljava/lang/String;Ljava/lang/String;Ljava/io/File;)Ljava/io/File;", AccessFlags = 9)]
				public static global::Java.IO.File CreateTempFile(string prefix, string suffix, global::Java.IO.File directory) /* MethodBuilder.Create */ 
				{
						return default(global::Java.IO.File);
				}

				/// <summary>
				///  <para>Renames this file to <c>newPath </c> . This operation is supported for both files and directories.</para> <para>Many failures are possible. Some of the more likely failures include:  <ul> <li> <para>Write permission is required on the directories containing both the source and destination paths. </para></li> <li> <para>Search permission is required for all parents of both paths. </para></li> <li> <para>Both paths be on the same mount point. On Android, applications are most likely to hit this restriction when attempting to copy between internal storage and an SD card. </para></li></ul></para> <para>Note that this method does  <b>not</b> throw <c>IOException </c> on failure. Callers must check the return value.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true on success. </para>
				/// </returns>
				/// <java-name>
				/// renameTo
				/// </java-name>
				[Dot42.DexImport("renameTo", "(Ljava/io/File;)Z", AccessFlags = 1)]
				public virtual bool RenameTo(global::Java.IO.File newPath) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Returns a string containing a concise, human-readable description of this file.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a printable representation of this file. </para>
				/// </returns>
				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Returns a Uniform Resource Identifier for this file. The URI is system dependent and may not be transferable between different operating / file systems.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>an URI for this file. </para>
				/// </returns>
				/// <java-name>
				/// toURI
				/// </java-name>
				[Dot42.DexImport("toURI", "()Ljava/net/URI;", AccessFlags = 1)]
				public virtual global::System.Uri ToURI() /* MethodBuilder.Create */ 
				{
						return default(global::System.Uri);
				}

				/// <summary>
				///  <para>Returns a Uniform Resource Locator for this file. The URL is system dependent and may not be transferable between different operating / file systems.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use toURI and java.net.URI#toURL to correctly escape illegal characters. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				///  <para>a URL for this file. </para>
				/// </returns>
				/// <java-name>
				/// toURL
				/// </java-name>
				[Dot42.DexImport("toURL", "()Ljava/net/URL;", AccessFlags = 1)]
				public virtual global::Java.Net.URL ToURL() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.URL);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal File() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Tests whether or not this process is allowed to execute this file. Note that this is a best-effort result; the only way to be certain is to actually attempt the operation.</para> <para> <para>1.6 </para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if this file can be executed, <c>false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// canExecute
				/// </java-name>
				public virtual bool CanExecute
				{
						[Dot42.DexImport("canExecute", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Indicates whether the current context is allowed to read from this file.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if this file can be read, <c>false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// canRead
				/// </java-name>
				public virtual bool CanRead
				{
						[Dot42.DexImport("canRead", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Indicates whether the current context is allowed to write to this file.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if this file can be written, <c>false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// canWrite
				/// </java-name>
				public virtual bool CanWrite
				{
						[Dot42.DexImport("canWrite", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Returns the absolute path of this file. An absolute path is a path that starts at a root of the file system. On Android, there is only one root: <c>/ </c> .</para> <para>A common use for absolute paths is when passing paths to a <c>Process </c> as command-line arguments, to remove the requirement implied by relative paths, that the child must have the same working directory as its parent. </para>        
				/// </summary>
				/// <java-name>
				/// getAbsolutePath
				/// </java-name>
				public virtual string AbsolutePath
				{
						[Dot42.DexImport("getAbsolutePath", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>Returns a new file constructed using the absolute path of this file. Equivalent to <c>new File(this.getAbsolutePath()) </c> . </para>        
				/// </summary>
				/// <java-name>
				/// getAbsoluteFile
				/// </java-name>
				public virtual global::Java.IO.File AbsoluteFile
				{
						[Dot42.DexImport("getAbsoluteFile", "()Ljava/io/File;", AccessFlags = 1)]
						get{ return default(global::Java.IO.File); }
				}

				/// <summary>
				///  <para>Returns the canonical path of this file. An  <b>absolute</b> path is one that begins at the root of the file system. A  <b>canonical</b> path is an absolute path with symbolic links and references to "." or ".." resolved. If a path element does not exist (or is not searchable), there is a conflict between interpreting canonicalization as a textual operation (where "a/../b" is "b" even if "a" does not exist) .</para> <para>Most callers should use getAbsolutePath instead. A canonical path is significantly more expensive to compute, and not generally useful. The primary use for canonical paths is determining whether two paths point to the same file by comparing the canonicalized paths.</para> <para>It can be actively harmful to use a canonical path, specifically because canonicalization removes symbolic links. It's wise to assume that a symbolic link is present for a reason, and that that reason is because the link may need to change. Canonicalization removes this layer of indirection. Good code should generally avoid caching canonical paths.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the canonical path of this file. </para>
				/// </returns>
				/// <java-name>
				/// getCanonicalPath
				/// </java-name>
				public virtual string CanonicalPath
				{
						[Dot42.DexImport("getCanonicalPath", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>Returns a new file created using the canonical path of this file. Equivalent to <c>new File(this.getCanonicalPath()) </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the new file constructed from this file's canonical path. </para>
				/// </returns>
				/// <java-name>
				/// getCanonicalFile
				/// </java-name>
				public virtual global::Java.IO.File CanonicalFile
				{
						[Dot42.DexImport("getCanonicalFile", "()Ljava/io/File;", AccessFlags = 1)]
						get{ return default(global::Java.IO.File); }
				}

				/// <summary>
				///  <para>Returns the name of the file or directory represented by this file.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>this file's name or an empty string if there is no name part in the file's path. </para>
				/// </returns>
				/// <java-name>
				/// getName
				/// </java-name>
				public virtual string Name
				{
						[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>Returns the pathname of the parent of this file. This is the path up to but not including the last name. <c>null </c> is returned if there is no parent.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>this file's parent pathname or <c>null </c> . </para>
				/// </returns>
				/// <java-name>
				/// getParent
				/// </java-name>
				public virtual string Parent
				{
						[Dot42.DexImport("getParent", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>Returns a new file made from the pathname of the parent of this file. This is the path up to but not including the last name. <c>null </c> is returned when there is no parent.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a new file representing this file's parent or <c>null </c> . </para>
				/// </returns>
				/// <java-name>
				/// getParentFile
				/// </java-name>
				public virtual global::Java.IO.File ParentFile
				{
						[Dot42.DexImport("getParentFile", "()Ljava/io/File;", AccessFlags = 1)]
						get{ return default(global::Java.IO.File); }
				}

				/// <summary>
				///  <para>Returns the path of this file. </para>        
				/// </summary>
				/// <java-name>
				/// getPath
				/// </java-name>
				public virtual string Path
				{
						[Dot42.DexImport("getPath", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>Indicates if this file's pathname is absolute. Whether a pathname is absolute is platform specific. On Android, absolute paths start with the character '/'.</para> <para> <para>getPath </para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if this file's pathname is absolute, <c>false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isAbsolute
				/// </java-name>
				public virtual bool IsAbsolute
				{
						[Dot42.DexImport("isAbsolute", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Indicates if this file represents a  <b>directory</b> on the underlying file system.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if this file is a directory, <c>false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isDirectory
				/// </java-name>
				public virtual bool IsDirectory
				{
						[Dot42.DexImport("isDirectory", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Indicates if this file represents a  <b>file</b> on the underlying file system.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if this file is a file, <c>false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isFile
				/// </java-name>
				public virtual bool IsFile
				{
						[Dot42.DexImport("isFile", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Returns whether or not this file is a hidden file as defined by the operating system. The notion of "hidden" is system-dependent. For Unix systems a file is considered hidden if its name starts with a ".". For Windows systems there is an explicit flag in the file system for this purpose.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if the file is hidden, <c>false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isHidden
				/// </java-name>
				public virtual bool IsHidden
				{
						[Dot42.DexImport("isHidden", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Returns the total size in bytes of the partition containing this path. Returns 0 if this path does not exist.</para> <para> <para>1.6 </para></para>        
				/// </summary>
				/// <java-name>
				/// getTotalSpace
				/// </java-name>
				public virtual long TotalSpace
				{
						[Dot42.DexImport("getTotalSpace", "()J", AccessFlags = 1)]
						get{ return default(long); }
				}

				/// <summary>
				///  <para>Returns the number of usable free bytes on the partition containing this path. Returns 0 if this path does not exist.</para> <para>Note that this is likely to be an optimistic over-estimate and should not be taken as a guarantee your application can actually write this many bytes. On Android (and other Unix-based systems), this method returns the number of free bytes available to non-root users, regardless of whether you're actually running as root, and regardless of any quota or other restrictions that might apply to the user. (The <c>getFreeSpace </c> method returns the number of bytes potentially available to root.)</para> <para> <para>1.6 </para></para>        
				/// </summary>
				/// <java-name>
				/// getUsableSpace
				/// </java-name>
				public virtual long UsableSpace
				{
						[Dot42.DexImport("getUsableSpace", "()J", AccessFlags = 1)]
						get{ return default(long); }
				}

				/// <summary>
				///  <para>Returns the number of free bytes on the partition containing this path. Returns 0 if this path does not exist.</para> <para>Note that this is likely to be an optimistic over-estimate and should not be taken as a guarantee your application can actually write this many bytes.</para> <para> <para>1.6 </para></para>        
				/// </summary>
				/// <java-name>
				/// getFreeSpace
				/// </java-name>
				public virtual long FreeSpace
				{
						[Dot42.DexImport("getFreeSpace", "()J", AccessFlags = 1)]
						get{ return default(long); }
				}

		}

		/// <summary>
		///  <para>Wraps a Unix file descriptor. It's possible to get the file descriptor used by some classes (such as FileInputStream, FileOutputStream, and RandomAccessFile), and then create new streams that point to the same file descriptor. </para>    
		/// </summary>
		/// <java-name>
		/// java/io/FileDescriptor
		/// </java-name>
		[Dot42.DexImport("java/io/FileDescriptor", AccessFlags = 49)]
		public sealed partial class FileDescriptor
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Corresponds to <c>stdin </c> . </para>        
				/// </summary>
				/// <java-name>
				/// in
				/// </java-name>
				[Dot42.DexImport("in", "Ljava/io/FileDescriptor;", AccessFlags = 25)]
				public static readonly global::Java.IO.FileDescriptor In;
				/// <summary>
				///  <para>Corresponds to <c>stdout </c> . </para>        
				/// </summary>
				/// <java-name>
				/// out
				/// </java-name>
				[Dot42.DexImport("out", "Ljava/io/FileDescriptor;", AccessFlags = 25)]
				public static readonly global::Java.IO.FileDescriptor Out;
				/// <summary>
				///  <para>Corresponds to <c>stderr </c> . </para>        
				/// </summary>
				/// <java-name>
				/// err
				/// </java-name>
				[Dot42.DexImport("err", "Ljava/io/FileDescriptor;", AccessFlags = 25)]
				public static readonly global::Java.IO.FileDescriptor Err;
				/// <summary>
				///  <para>Constructs a new invalid FileDescriptor. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public FileDescriptor() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Ensures that data which is buffered within the underlying implementation is written out to the appropriate device before returning. </para>        
				/// </summary>
				/// <java-name>
				/// sync
				/// </java-name>
				[Dot42.DexImport("sync", "()V", AccessFlags = 1)]
				public void Sync() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Tests whether this <c>FileDescriptor </c> is valid. </para>        
				/// </summary>
				/// <java-name>
				/// valid
				/// </java-name>
				[Dot42.DexImport("valid", "()Z", AccessFlags = 1)]
				public bool Valid() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

		}

		/// <summary>
		///  <para>An input stream that reads bytes from a file.  <pre>File file = ...
		/// 
		/// InputStream in = null;
		/// 
		/// try {
		/// 
		///   in = new BufferedInputStream(new FileInputStream(file));
		/// 
		///   ...
		/// 
		/// } finally {
		/// 
		///   if (in != null) {
		/// 
		///     in.close();
		/// 
		///   }
		/// 
		/// }
		/// 
		///  </pre></para> <para>This stream is  <b>not buffered</b>. Most callers should wrap this stream with a BufferedInputStream.</para> <para>Use FileReader to read characters, as opposed to bytes, from a file.</para> <para> <para>BufferedInputStream </para> <para>FileOutputStream </para></para>    
		/// </summary>
		/// <java-name>
		/// java/io/FileInputStream
		/// </java-name>
		[Dot42.DexImport("java/io/FileInputStream", AccessFlags = 33)]
		public partial class FileInputStream : global::Java.IO.InputStream, global::Java.IO.ICloseable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructs a new <c>FileInputStream </c> that reads from <c>file </c> .</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/io/File;)V", AccessFlags = 1)]
				public FileInputStream(global::Java.IO.File file) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new <c>FileInputStream </c> that reads from <c>file </c> .</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/io/FileDescriptor;)V", AccessFlags = 1)]
				public FileInputStream(global::Java.IO.FileDescriptor file) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new <c>FileInputStream </c> that reads from <c>file </c> .</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public FileInputStream(string file) /* MethodBuilder.Create */ 
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

				/// <summary>
				///  <para>Closes the object and release any system resources it holds.</para> <para>Although only the first call has any effect, it is safe to call close multiple times on the same object. This is more lenient than the overridden <c>AutoCloseable.close() </c> , which may be called at most once. </para>        
				/// </summary>
				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1)]
				public override void Close() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Ensures that all resources for this stream are released when it is about to be garbage collected.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// finalize
				/// </java-name>
				[Dot42.DexImport("finalize", "()V", AccessFlags = 4)]
				extern ~FileInputStream() /* MethodBuilder.Create */ ;

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
				[Dot42.DexImport("read", "([B)I", AccessFlags = 1)]
				public override int Read(sbyte[] sByte) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([B)I", AccessFlags = 1, IgnoreFromJava = true)]
				public override int Read(byte[] @byte) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([BII)I", AccessFlags = 1)]
				public override int Read(sbyte[] buffer, int byteOffset, int byteCount) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([BII)I", AccessFlags = 1, IgnoreFromJava = true)]
				public override int Read(byte[] buffer, int byteOffset, int byteCount) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// skip
				/// </java-name>
				[Dot42.DexImport("skip", "(J)J", AccessFlags = 1)]
				public override long Skip(long byteCount) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal FileInputStream() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Returns a read-only FileChannel that shares its position with this stream. </para>        
				/// </summary>
				/// <java-name>
				/// getChannel
				/// </java-name>
				public virtual global::Java.Nio.Channels.FileChannel Channel
				{
						[Dot42.DexImport("getChannel", "()Ljava/nio/channels/FileChannel;", AccessFlags = 1)]
						get{ return default(global::Java.Nio.Channels.FileChannel); }
				}

				/// <summary>
				///  <para>Returns the underlying file descriptor. </para>        
				/// </summary>
				/// <java-name>
				/// getFD
				/// </java-name>
				public global::Java.IO.FileDescriptor FD
				{
						[Dot42.DexImport("getFD", "()Ljava/io/FileDescriptor;", AccessFlags = 17)]
						get{ return default(global::Java.IO.FileDescriptor); }
				}

		}

		/// <summary>
		///  <para>An output stream that writes bytes to a file. If the output file exists, it can be replaced or appended to. If it does not exist, a new file will be created.  <pre>File file = ...
		/// 
		/// OutputStream out = null;
		/// 
		/// try {
		/// 
		///   out = new BufferedOutputStream(new FileOutputStream(file));
		/// 
		///   ...
		/// 
		/// } finally {
		/// 
		///   if (out != null) {
		/// 
		///     out.close();
		/// 
		///   }
		/// 
		/// }
		/// 
		///  </pre></para> <para>This stream is  <b>not buffered</b>. Most callers should wrap this stream with a BufferedOutputStream.</para> <para>Use FileWriter to write characters, as opposed to bytes, to a file.</para> <para> <para>BufferedOutputStream </para> <para>FileInputStream </para></para>    
		/// </summary>
		/// <java-name>
		/// java/io/FileOutputStream
		/// </java-name>
		[Dot42.DexImport("java/io/FileOutputStream", AccessFlags = 33)]
		public partial class FileOutputStream : global::Java.IO.OutputStream, global::Java.IO.ICloseable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructs a new <c>FileOutputStream </c> that writes to <c>file </c> . The file will be truncated if it exists, and created if it doesn't exist.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/io/File;)V", AccessFlags = 1)]
				public FileOutputStream(global::Java.IO.File file) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/io/File;Z)V", AccessFlags = 1)]
				public FileOutputStream(global::Java.IO.File file, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new <c>FileOutputStream </c> that writes to <c>file </c> . The file will be truncated if it exists, and created if it doesn't exist.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/io/FileDescriptor;)V", AccessFlags = 1)]
				public FileOutputStream(global::Java.IO.FileDescriptor file) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new <c>FileOutputStream </c> that writes to <c>file </c> . The file will be truncated if it exists, and created if it doesn't exist.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public FileOutputStream(string file) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Z)V", AccessFlags = 1)]
				public FileOutputStream(string @string, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Closes the object and release any system resources it holds.</para> <para>Although only the first call has any effect, it is safe to call close multiple times on the same object. This is more lenient than the overridden <c>AutoCloseable.close() </c> , which may be called at most once. </para>        
				/// </summary>
				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1)]
				public override void Close() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// finalize
				/// </java-name>
				[Dot42.DexImport("finalize", "()V", AccessFlags = 4)]
				extern ~FileOutputStream() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([B)V", AccessFlags = 1)]
				public override void Write(sbyte[] oneByte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public override void Write(byte[] oneByte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([BII)V", AccessFlags = 1)]
				public override void Write(sbyte[] buffer, int byteOffset, int byteCount) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([BII)V", AccessFlags = 1, IgnoreFromJava = true)]
				public override void Write(byte[] buffer, int byteOffset, int byteCount) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "(I)V", AccessFlags = 1)]
				public override void Write(int oneByte) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal FileOutputStream() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Returns a write-only FileChannel that shares its position with this stream. </para>        
				/// </summary>
				/// <java-name>
				/// getChannel
				/// </java-name>
				public virtual global::Java.Nio.Channels.FileChannel Channel
				{
						[Dot42.DexImport("getChannel", "()Ljava/nio/channels/FileChannel;", AccessFlags = 1)]
						get{ return default(global::Java.Nio.Channels.FileChannel); }
				}

				/// <summary>
				///  <para>Returns the underlying file descriptor. </para>        
				/// </summary>
				/// <java-name>
				/// getFD
				/// </java-name>
				public global::Java.IO.FileDescriptor FD
				{
						[Dot42.DexImport("getFD", "()Ljava/io/FileDescriptor;", AccessFlags = 17)]
						get{ return default(global::Java.IO.FileDescriptor); }
				}

		}

		/// <summary>
		///  <para>Legacy security code; do not use. </para>    
		/// </summary>
		/// <java-name>
		/// java/io/FilePermission
		/// </java-name>
		[Dot42.DexImport("java/io/FilePermission", AccessFlags = 49)]
		public sealed partial class FilePermission : global::Java.Security.Permission, global::Java.IO.ISerializable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public FilePermission(string path, string actions) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// implies
				/// </java-name>
				[Dot42.DexImport("implies", "(Ljava/security/Permission;)Z", AccessFlags = 1)]
				public override bool Implies(global::Java.Security.Permission permission) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// newPermissionCollection
				/// </java-name>
				[Dot42.DexImport("newPermissionCollection", "()Ljava/security/PermissionCollection;", AccessFlags = 1)]
				public override global::Java.Security.PermissionCollection NewPermissionCollection() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.PermissionCollection);
				}

				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 1)]
				public override int GetHashCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal FilePermission() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getActions
				/// </java-name>
				public override string Actions
				{
						[Dot42.DexImport("getActions", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

		}

		/// <summary>
		///  <para>A specialized Reader that reads from a file in the file system. All read requests made by calling methods in this class are directly forwarded to the equivalent function of the underlying operating system. Since this may induce some performance penalty, in particular if many small read requests are made, a FileReader is often wrapped by a BufferedReader.</para> <para> <para>BufferedReader </para> <para>FileWriter </para></para>    
		/// </summary>
		/// <java-name>
		/// java/io/FileReader
		/// </java-name>
		[Dot42.DexImport("java/io/FileReader", AccessFlags = 33)]
		public partial class FileReader : global::Java.IO.InputStreamReader
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructs a new FileReader on the given <c>file </c> .</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/io/File;)V", AccessFlags = 1)]
				public FileReader(global::Java.IO.File file) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new FileReader on the given <c>file </c> .</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/io/FileDescriptor;)V", AccessFlags = 1)]
				public FileReader(global::Java.IO.FileDescriptor file) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new FileReader on the given <c>file </c> .</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public FileReader(string file) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal FileReader() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		///  <para>A specialized Writer that writes to a file in the file system. All write requests made by calling methods in this class are directly forwarded to the equivalent function of the underlying operating system. Since this may induce some performance penalty, in particular if many small write requests are made, a FileWriter is often wrapped by a BufferedWriter.</para> <para> <para>BufferedWriter </para> <para>FileReader </para></para>    
		/// </summary>
		/// <java-name>
		/// java/io/FileWriter
		/// </java-name>
		[Dot42.DexImport("java/io/FileWriter", AccessFlags = 33)]
		public partial class FileWriter : global::Java.IO.OutputStreamWriter
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Creates a FileWriter using the File <c>file </c> .</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/io/File;)V", AccessFlags = 1)]
				public FileWriter(global::Java.IO.File file) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/io/File;Z)V", AccessFlags = 1)]
				public FileWriter(global::Java.IO.File file, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Creates a FileWriter using the File <c>file </c> .</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/io/FileDescriptor;)V", AccessFlags = 1)]
				public FileWriter(global::Java.IO.FileDescriptor file) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Creates a FileWriter using the File <c>file </c> .</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public FileWriter(string file) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Z)V", AccessFlags = 1)]
				public FileWriter(string @string, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal FileWriter() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		///  <para>Wraps an existing InputStream and performs some transformation on the input data while it is being read. Transformations can be anything from a simple byte-wise filtering input data to an on-the-fly compression or decompression of the underlying stream. Input streams that wrap another input stream and provide some additional functionality on top of it usually inherit from this class.</para> <para> <para>FilterOutputStream </para></para>    
		/// </summary>
		/// <java-name>
		/// java/io/FilterInputStream
		/// </java-name>
		[Dot42.DexImport("java/io/FilterInputStream", AccessFlags = 33)]
		public partial class FilterInputStream : global::Java.IO.InputStream
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>The source input stream that is filtered. </para>        
				/// </summary>
				/// <java-name>
				/// in
				/// </java-name>
				[Dot42.DexImport("in", "Ljava/io/InputStream;", AccessFlags = 68)]
				protected internal global::Java.IO.InputStream In;
				/// <summary>
				///  <para>Constructs a new <c>FilterInputStream </c> with the specified input stream as source.</para> <para> <b>Warning:</b> passing a null source creates an invalid  <c>FilterInputStream </c> , that fails on every method that is not overridden. Subclasses should check for null in their constructors.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/io/InputStream;)V", AccessFlags = 4)]
				protected internal FilterInputStream(global::Java.IO.InputStream @in) /* MethodBuilder.Create */ 
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

				/// <summary>
				///  <para>Closes this stream. This implementation closes the filtered stream.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1)]
				public override void Close() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets a mark position in this stream. The parameter <c>readlimit </c> indicates how many bytes can be read before the mark is invalidated. Sending <c>reset() </c> will reposition this stream back to the marked position, provided that <c>readlimit </c> has not been surpassed. </para> <para>This implementation sets a mark in the filtered stream.</para> <para> <para>markSupported() </para> <para>reset() </para></para>        
				/// </summary>
				/// <java-name>
				/// mark
				/// </java-name>
				[Dot42.DexImport("mark", "(I)V", AccessFlags = 33)]
				public override void Mark(int readlimit) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Indicates whether this stream supports <c>mark() </c> and <c>reset() </c> . This implementation returns whether or not the filtered stream supports marking.</para> <para> <para>mark(int) </para> <para>reset() </para> <para>skip(long) </para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if <c>mark() </c> and <c>reset() </c> are supported,  <c>false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// markSupported
				/// </java-name>
				[Dot42.DexImport("markSupported", "()Z", AccessFlags = 1)]
				public override bool MarkSupported() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Reads a single byte from the filtered stream and returns it as an integer in the range from 0 to 255. Returns -1 if the end of this stream has been reached.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the byte read or -1 if the end of the filtered stream has been reached. </para>
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
				[Dot42.DexImport("read", "([B)I", AccessFlags = 1)]
				public override int Read(sbyte[] sByte) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([B)I", AccessFlags = 1, IgnoreFromJava = true)]
				public override int Read(byte[] @byte) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([BII)I", AccessFlags = 1)]
				public override int Read(sbyte[] buffer, int byteOffset, int byteCount) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([BII)I", AccessFlags = 1, IgnoreFromJava = true)]
				public override int Read(byte[] buffer, int byteOffset, int byteCount) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Resets this stream to the last marked location. This implementation resets the target stream.</para> <para> <para>mark(int) </para> <para>markSupported() </para></para>        
				/// </summary>
				/// <java-name>
				/// reset
				/// </java-name>
				[Dot42.DexImport("reset", "()V", AccessFlags = 33)]
				public override void Reset() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Skips <c>byteCount </c> bytes in this stream. Subsequent calls to <c>read </c> will not return these bytes unless <c>reset </c> is used. This implementation skips <c>byteCount </c> bytes in the filtered stream.</para> <para> <para>mark(int) </para> <para>reset() </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the number of bytes actually skipped. </para>
				/// </returns>
				/// <java-name>
				/// skip
				/// </java-name>
				[Dot42.DexImport("skip", "(J)J", AccessFlags = 1)]
				public override long Skip(long byteCount) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal FilterInputStream() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		///  <para>Wraps an existing OutputStream and performs some transformation on the output data while it is being written. Transformations can be anything from a simple byte-wise filtering output data to an on-the-fly compression or decompression of the underlying stream. Output streams that wrap another output stream and provide some additional functionality on top of it usually inherit from this class.</para> <para> <para>FilterOutputStream </para></para>    
		/// </summary>
		/// <java-name>
		/// java/io/FilterOutputStream
		/// </java-name>
		[Dot42.DexImport("java/io/FilterOutputStream", AccessFlags = 33)]
		public partial class FilterOutputStream : global::Java.IO.OutputStream
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>The target output stream for this filter stream. </para>        
				/// </summary>
				/// <java-name>
				/// out
				/// </java-name>
				[Dot42.DexImport("out", "Ljava/io/OutputStream;", AccessFlags = 4)]
				protected internal global::Java.IO.OutputStream Out;
				/// <summary>
				///  <para>Constructs a new <c>FilterOutputStream </c> with <c>out </c> as its target stream.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/io/OutputStream;)V", AccessFlags = 1)]
				public FilterOutputStream(global::Java.IO.OutputStream @out) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Closes this stream. This implementation closes the target stream.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1)]
				public override void Close() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Ensures that all pending data is sent out to the target stream. This implementation flushes the target stream.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// flush
				/// </java-name>
				[Dot42.DexImport("flush", "()V", AccessFlags = 1)]
				public override void Flush() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Writes one byte to the target stream. Only the low order byte of the integer <c>oneByte </c> is written.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([B)V", AccessFlags = 1)]
				public override void Write(sbyte[] oneByte) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Writes one byte to the target stream. Only the low order byte of the integer <c>oneByte </c> is written.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public override void Write(byte[] oneByte) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Writes <c>count </c> bytes from the byte array <c>buffer </c> starting at  <c>offset </c> to the target stream.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([BII)V", AccessFlags = 1)]
				public override void Write(sbyte[] buffer, int offset, int length) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Writes <c>count </c> bytes from the byte array <c>buffer </c> starting at  <c>offset </c> to the target stream.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([BII)V", AccessFlags = 1, IgnoreFromJava = true)]
				public override void Write(byte[] buffer, int offset, int length) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Writes one byte to the target stream. Only the low order byte of the integer <c>oneByte </c> is written.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "(I)V", AccessFlags = 1)]
				public override void Write(int oneByte) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal FilterOutputStream() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		///  <para>Wraps an existing Reader and performs some transformation on the input data while it is being read. Transformations can be anything from a simple byte-wise filtering input data to an on-the-fly compression or decompression of the underlying reader. Readers that wrap another reader and provide some additional functionality on top of it usually inherit from this class.</para> <para> <para>FilterWriter </para></para>    
		/// </summary>
		/// <java-name>
		/// java/io/FilterReader
		/// </java-name>
		[Dot42.DexImport("java/io/FilterReader", AccessFlags = 1057)]
		public abstract partial class FilterReader : global::Java.IO.Reader
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>The target Reader which is being filtered. </para>        
				/// </summary>
				/// <java-name>
				/// in
				/// </java-name>
				[Dot42.DexImport("in", "Ljava/io/Reader;", AccessFlags = 4)]
				protected internal global::Java.IO.Reader In;
				/// <summary>
				///  <para>Constructs a new FilterReader on the Reader <c>in </c> .</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/io/Reader;)V", AccessFlags = 4)]
				protected internal FilterReader(global::Java.IO.Reader @in) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Closes this reader. This implementation closes the filtered reader.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1)]
				public override void Close() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets a mark position in this reader. The parameter <c>readlimit </c> indicates how many bytes can be read before the mark is invalidated. Sending <c>reset() </c> will reposition this reader back to the marked position, provided that <c>readlimit </c> has not been surpassed. </para> <para>This implementation sets a mark in the filtered reader.</para> <para> <para>markSupported() </para> <para>reset() </para></para>        
				/// </summary>
				/// <java-name>
				/// mark
				/// </java-name>
				[Dot42.DexImport("mark", "(I)V", AccessFlags = 33)]
				public override void Mark(int readlimit) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Indicates whether this reader supports <c>mark() </c> and <c>reset() </c> . This implementation returns whether the filtered reader supports marking.</para> <para> <para>mark(int) </para> <para>reset() </para> <para>skip(long) </para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if <c>mark() </c> and <c>reset() </c> are supported by the filtered reader, <c>false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// markSupported
				/// </java-name>
				[Dot42.DexImport("markSupported", "()Z", AccessFlags = 1)]
				public override bool MarkSupported() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Reads a single character from the filtered reader and returns it as an integer with the two higher-order bytes set to 0. Returns -1 if the end of the filtered reader has been reached.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The character read or -1 if the end of the filtered reader has been reached. </para>
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
				///  <para>Reads up to <c>count </c> characters from the filtered reader and stores them in the byte array <c>buffer </c> starting at <c>offset </c> . Returns the number of characters actually read or -1 if no characters were read and the end of the filtered reader was encountered.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([CII)I", AccessFlags = 1)]
				public override int Read(char[] buffer, int offset, int count) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Indicates whether this reader is ready to be read without blocking. If the result is <c>true </c> , the next <c>read() </c> will not block. If the result is <c>false </c> , this reader may or may not block when  <c>read() </c> is sent.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if this reader will not block when <c>read() </c> is called, <c>false </c> if unknown or blocking will occur. </para>
				/// </returns>
				/// <java-name>
				/// ready
				/// </java-name>
				[Dot42.DexImport("ready", "()Z", AccessFlags = 1)]
				public override bool Ready() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Resets this reader's position to the last marked location. Invocations of  <c>read() </c> and <c>skip() </c> will occur from this new location. If this reader was not marked, the behavior depends on the implementation of  <c>reset() </c> in the Reader subclass that is filtered by this reader. The default behavior for Reader is to throw an <c>IOException </c> .</para> <para> <para>mark(int) </para> <para>markSupported() </para></para>        
				/// </summary>
				/// <java-name>
				/// reset
				/// </java-name>
				[Dot42.DexImport("reset", "()V", AccessFlags = 1)]
				public override void Reset() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Skips <c>charCount </c> characters in this reader. Subsequent calls to <c>read </c> will not return these characters unless <c>reset </c> is used. The default implementation is to skip characters in the filtered reader.</para> <para> <para>mark(int) </para> <para>markSupported() </para> <para>reset() </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the number of characters actually skipped. </para>
				/// </returns>
				/// <java-name>
				/// skip
				/// </java-name>
				[Dot42.DexImport("skip", "(J)J", AccessFlags = 1)]
				public override long Skip(long charCount) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal FilterReader() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		///  <para>Wraps an existing Writer and performs some transformation on the output data while it is being written. Transformations can be anything from a simple byte-wise filtering output data to an on-the-fly compression or decompression of the underlying writer. Writers that wrap another writer and provide some additional functionality on top of it usually inherit from this class.</para> <para> <para>FilterReader </para></para>    
		/// </summary>
		/// <java-name>
		/// java/io/FilterWriter
		/// </java-name>
		[Dot42.DexImport("java/io/FilterWriter", AccessFlags = 1057)]
		public abstract partial class FilterWriter : global::Java.IO.Writer
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>The Writer being filtered. </para>        
				/// </summary>
				/// <java-name>
				/// out
				/// </java-name>
				[Dot42.DexImport("out", "Ljava/io/Writer;", AccessFlags = 4)]
				protected internal global::Java.IO.Writer Out;
				/// <summary>
				///  <para>Constructs a new FilterWriter on the Writer <c>out </c> . All writes are now filtered through this writer.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/io/Writer;)V", AccessFlags = 4)]
				protected internal FilterWriter(global::Java.IO.Writer @out) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Closes this writer. This implementation closes the target writer.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1)]
				public override void Close() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Flushes this writer to ensure all pending data is sent out to the target writer. This implementation flushes the target writer.</para> <para></para>        
				/// </summary>
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
				[Dot42.DexImport("write", "([CII)V", AccessFlags = 1)]
				public override void Write(char[] @char, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Writes the specified character <c>oneChar </c> to the target writer. Only the two least significant bytes of the integer <c>oneChar </c> are written.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "(I)V", AccessFlags = 1)]
				public override void Write(int oneChar) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "(Ljava/lang/String;II)V", AccessFlags = 1)]
				public override void Write(string @string, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal FilterWriter() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		///  <para>An <c>AutoCloseable </c> whose close method may throw an IOException. </para>    
		/// </summary>
		/// <java-name>
		/// java/io/Closeable
		/// </java-name>
		[Dot42.DexImport("java/io/Closeable", AccessFlags = 1537)]
		public partial interface ICloseable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Closes the object and release any system resources it holds.</para> <para>Although only the first call has any effect, it is safe to call close multiple times on the same object. This is more lenient than the overridden <c>AutoCloseable.close() </c> , which may be called at most once. </para>        
				/// </summary>
				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1025)]
				void Close() /* MethodBuilder.Create */ ;

		}

		/// <summary>
		///  <para>Defines an interface for classes that are able to read big-endian typed data from some source. Typically, this data has been written by a class which implements DataOutput. Types that can be read include byte, 16-bit short, 32-bit int, 32-bit float, 64-bit long, 64-bit double, byte strings, and MUTF-8 strings.</para> <para> <h3>MUTF-8 (Modified UTF-8) Encoding</h3></para> <para>When encoding strings as UTF, implementations of <c>DataInput </c> and  <c>DataOutput </c> use a slightly modified form of UTF-8, hereafter referred to as MUTF-8. This form is identical to standard UTF-8, except:  <ul> <li> <para>Only the one-, two-, and three-byte encodings are used. </para></li> <li> <para>Code points in the range  <code>U+10000</code>  <hellip></hellip>  <code>U+10ffff</code> are encoded as a surrogate pair, each of which is represented as a three-byte encoded value. </para></li> <li> <para>The code point  <code>U+0000</code> is encoded in two-byte form. </para></li></ul></para> <para>Please refer to  for further information about character encoding. MUTF-8 is actually closer to the (relatively less well-known) encoding  than to UTF-8 per se.</para> <para> <para>DataInputStream </para> <para>RandomAccessFile </para></para>    
		/// </summary>
		/// <java-name>
		/// java/io/DataInput
		/// </java-name>
		[Dot42.DexImport("java/io/DataInput", AccessFlags = 1537)]
		public partial interface IDataInput
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Reads a boolean.</para> <para> <para>DataOutput::writeBoolean(boolean) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the next boolean value. </para>
				/// </returns>
				/// <java-name>
				/// readBoolean
				/// </java-name>
				[Dot42.DexImport("readBoolean", "()Z", AccessFlags = 1025)]
				bool ReadBoolean() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Reads an 8-bit byte value.</para> <para> <para>DataOutput::writeByte(int) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the next byte value. </para>
				/// </returns>
				/// <java-name>
				/// readByte
				/// </java-name>
				[Dot42.DexImport("readByte", "()B", AccessFlags = 1025, IgnoreFromJava = true)]
				byte ReadByte() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Reads a big-endian 16-bit character value.</para> <para> <para>DataOutput::writeChar(int) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the next char value. </para>
				/// </returns>
				/// <java-name>
				/// readChar
				/// </java-name>
				[Dot42.DexImport("readChar", "()C", AccessFlags = 1025)]
				char ReadChar() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Reads a big-endian 64-bit double value.</para> <para> <para>DataOutput::writeDouble(double) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the next double value. </para>
				/// </returns>
				/// <java-name>
				/// readDouble
				/// </java-name>
				[Dot42.DexImport("readDouble", "()D", AccessFlags = 1025)]
				double ReadDouble() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Reads a big-endian 32-bit float value.</para> <para> <para>DataOutput::writeFloat(float) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the next float value. </para>
				/// </returns>
				/// <java-name>
				/// readFloat
				/// </java-name>
				[Dot42.DexImport("readFloat", "()F", AccessFlags = 1025)]
				float ReadFloat() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Equivalent to <c>readFully(dst, 0, dst.length); </c> . </para>        
				/// </summary>
				/// <java-name>
				/// readFully
				/// </java-name>
				[Dot42.DexImport("readFully", "([B)V", AccessFlags = 1025)]
				void ReadFully(sbyte[] dst) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Reads <c>byteCount </c> bytes from this stream and stores them in the byte array <c>dst </c> starting at <c>offset </c> . If <c>byteCount </c> is zero, then this method returns without reading any bytes. Otherwise, this method blocks until  <c>byteCount </c> bytes have been read. If insufficient bytes are available,  <c>EOFException </c> is thrown. If an I/O error occurs, <c>IOException </c> is thrown. When an exception is thrown, some bytes may have been consumed from the stream and written into the array.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// readFully
				/// </java-name>
				[Dot42.DexImport("readFully", "([BII)V", AccessFlags = 1025)]
				void ReadFully(sbyte[] dst, int offset, int byteCount) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Reads a big-endian 32-bit integer value.</para> <para> <para>DataOutput::writeInt(int) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the next int value. </para>
				/// </returns>
				/// <java-name>
				/// readInt
				/// </java-name>
				[Dot42.DexImport("readInt", "()I", AccessFlags = 1025)]
				int ReadInt() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns a string containing the next line of text available from this stream. A line is made of zero or more characters followed by <c>'\n' </c> , <c>'\r' </c> , <c>"\r\n" </c> or the end of the stream. The string does not include the newline sequence.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the contents of the line or null if no characters have been read before the end of the stream. </para>
				/// </returns>
				/// <java-name>
				/// readLine
				/// </java-name>
				[Dot42.DexImport("readLine", "()Ljava/lang/String;", AccessFlags = 1025)]
				string ReadLine() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Reads a big-endian 64-bit long value.</para> <para> <para>DataOutput::writeLong(long) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the next long value. </para>
				/// </returns>
				/// <java-name>
				/// readLong
				/// </java-name>
				[Dot42.DexImport("readLong", "()J", AccessFlags = 1025)]
				long ReadLong() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Reads a big-endian 16-bit short value.</para> <para> <para>DataOutput::writeShort(int) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the next short value. </para>
				/// </returns>
				/// <java-name>
				/// readShort
				/// </java-name>
				[Dot42.DexImport("readShort", "()S", AccessFlags = 1025)]
				short ReadShort() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Reads an unsigned 8-bit byte value and returns it as an int.</para> <para> <para>DataOutput::writeByte(int) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the next unsigned byte value. </para>
				/// </returns>
				/// <java-name>
				/// readUnsignedByte
				/// </java-name>
				[Dot42.DexImport("readUnsignedByte", "()I", AccessFlags = 1025)]
				int ReadUnsignedByte() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Reads a big-endian 16-bit unsigned short value and returns it as an int.</para> <para> <para>DataOutput::writeShort(int) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the next unsigned short value. </para>
				/// </returns>
				/// <java-name>
				/// readUnsignedShort
				/// </java-name>
				[Dot42.DexImport("readUnsignedShort", "()I", AccessFlags = 1025)]
				int ReadUnsignedShort() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Reads a string encoded with modified UTF-8.</para> <para> <para>DataOutput::writeUTF(java.lang.String) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the next string encoded with modified UTF-8. </para>
				/// </returns>
				/// <java-name>
				/// readUTF
				/// </java-name>
				[Dot42.DexImport("readUTF", "()Ljava/lang/String;", AccessFlags = 1025)]
				string ReadUTF() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Skips <c>count </c> number of bytes. This method will not throw an EOFException if the end of the input is reached before  <c>count </c> bytes where skipped.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the number of bytes actually skipped. </para>
				/// </returns>
				/// <java-name>
				/// skipBytes
				/// </java-name>
				[Dot42.DexImport("skipBytes", "(I)I", AccessFlags = 1025)]
				int SkipBytes(int count) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		///  <para>Defines an interface for classes that are able to write big-endian typed data to some target. Typically, this data can be read in by a class which implements DataInput. Types that can be written include byte, 16-bit short, 32-bit int, 32-bit float, 64-bit long, 64-bit double, byte strings, and MUTF-8 encoded strings.</para> <para> <para>DataOutputStream </para> <para>RandomAccessFile </para></para>    
		/// </summary>
		/// <java-name>
		/// java/io/DataOutput
		/// </java-name>
		[Dot42.DexImport("java/io/DataOutput", AccessFlags = 1537)]
		public partial interface IDataOutput
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Writes the specified 8-bit byte.</para> <para> <para>DataInput::readByte() </para></para>        
				/// </summary>
				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([B)V", AccessFlags = 1025)]
				void Write(sbyte[] oneByte) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Writes <c>count </c> bytes from the byte array <c>buffer </c> starting at offset <c>index </c> .</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([BII)V", AccessFlags = 1025)]
				void Write(sbyte[] buffer, int offset, int count) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Writes the specified 8-bit byte.</para> <para> <para>DataInput::readByte() </para></para>        
				/// </summary>
				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "(I)V", AccessFlags = 1025)]
				void Write(int oneByte) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Writes the specified boolean.</para> <para> <para>DataInput::readBoolean() </para></para>        
				/// </summary>
				/// <java-name>
				/// writeBoolean
				/// </java-name>
				[Dot42.DexImport("writeBoolean", "(Z)V", AccessFlags = 1025)]
				void WriteBoolean(bool val) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Writes the specified 8-bit byte.</para> <para> <para>DataInput::readByte() </para> <para>DataInput::readUnsignedByte() </para></para>        
				/// </summary>
				/// <java-name>
				/// writeByte
				/// </java-name>
				[Dot42.DexImport("writeByte", "(I)V", AccessFlags = 1025)]
				void WriteByte(int val) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Writes the low order 8-bit bytes from the specified string.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// writeBytes
				/// </java-name>
				[Dot42.DexImport("writeBytes", "(Ljava/lang/String;)V", AccessFlags = 1025)]
				void WriteBytes(string str) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Writes the specified 16-bit character in big-endian order. Only the two least significant bytes of the integer <c>oneByte </c> are written.</para> <para> <para>DataInput::readChar() </para></para>        
				/// </summary>
				/// <java-name>
				/// writeChar
				/// </java-name>
				[Dot42.DexImport("writeChar", "(I)V", AccessFlags = 1025)]
				void WriteChar(int val) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Writes the 16-bit characters contained in <c>str </c> in big-endian order.</para> <para> <para>DataInput::readChar() </para></para>        
				/// </summary>
				/// <java-name>
				/// writeChars
				/// </java-name>
				[Dot42.DexImport("writeChars", "(Ljava/lang/String;)V", AccessFlags = 1025)]
				void WriteChars(string str) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Writes the specified 64-bit double in big-endian order. The resulting output is the eight bytes returned by Double#doubleToLongBits(double).</para> <para> <para>DataInput::readDouble() </para></para>        
				/// </summary>
				/// <java-name>
				/// writeDouble
				/// </java-name>
				[Dot42.DexImport("writeDouble", "(D)V", AccessFlags = 1025)]
				void WriteDouble(double val) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Writes the specified 32-bit float in big-endian order. The resulting output is the four bytes returned by Float#floatToIntBits(float).</para> <para> <para>DataInput::readFloat() </para></para>        
				/// </summary>
				/// <java-name>
				/// writeFloat
				/// </java-name>
				[Dot42.DexImport("writeFloat", "(F)V", AccessFlags = 1025)]
				void WriteFloat(float val) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Writes the specified 32-bit int in big-endian order.</para> <para> <para>DataInput::readInt() </para></para>        
				/// </summary>
				/// <java-name>
				/// writeInt
				/// </java-name>
				[Dot42.DexImport("writeInt", "(I)V", AccessFlags = 1025)]
				void WriteInt(int val) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Writes the specified 64-bit long in big-endian order.</para> <para> <para>DataInput::readLong() </para></para>        
				/// </summary>
				/// <java-name>
				/// writeLong
				/// </java-name>
				[Dot42.DexImport("writeLong", "(J)V", AccessFlags = 1025)]
				void WriteLong(long val) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Writes the specified 16-bit short in big-endian order. Only the lower two bytes of <c>val </c> are written.</para> <para> <para>DataInput::readShort() </para> <para>DataInput::readUnsignedShort() </para></para>        
				/// </summary>
				/// <java-name>
				/// writeShort
				/// </java-name>
				[Dot42.DexImport("writeShort", "(I)V", AccessFlags = 1025)]
				void WriteShort(int val) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Writes the specified string encoded in modified UTF-8.</para> <para> <para>DataInput::readUTF() </para></para>        
				/// </summary>
				/// <java-name>
				/// writeUTF
				/// </java-name>
				[Dot42.DexImport("writeUTF", "(Ljava/lang/String;)V", AccessFlags = 1025)]
				void WriteUTF(string str) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		///  <para>Defines an interface for classes that want to be serializable, but have their own binary representation. </para>    
		/// </summary>
		/// <java-name>
		/// java/io/Externalizable
		/// </java-name>
		[Dot42.DexImport("java/io/Externalizable", AccessFlags = 1537)]
		public partial interface IExternalizable : global::Java.IO.ISerializable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Reads the next object from the ObjectInput  <code>input</code>.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// readExternal
				/// </java-name>
				[Dot42.DexImport("readExternal", "(Ljava/io/ObjectInput;)V", AccessFlags = 1025)]
				void ReadExternal(global::Java.IO.IObjectInput input) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Writes the receiver to the ObjectOutput  <code>output</code>.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// writeExternal
				/// </java-name>
				[Dot42.DexImport("writeExternal", "(Ljava/io/ObjectOutput;)V", AccessFlags = 1025)]
				void WriteExternal(global::Java.IO.IObjectOutput output) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		///  <para>An interface for filtering File objects based on their names or other information.</para> <para> <para>File::listFiles(FileFilter) </para></para>    
		/// </summary>
		/// <java-name>
		/// java/io/FileFilter
		/// </java-name>
		[Dot42.DexImport("java/io/FileFilter", AccessFlags = 1537)]
		public partial interface IFileFilter
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Indicating whether a specific file should be included in a pathname list.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if the file should be included, <c>false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// accept
				/// </java-name>
				[Dot42.DexImport("accept", "(Ljava/io/File;)Z", AccessFlags = 1025)]
				bool Accept(global::Java.IO.File pathname) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		///  <para>An interface for filtering File objects based on their names or the directory they reside in.</para> <para> <para>File </para> <para>File::list(FilenameFilter) </para></para>    
		/// </summary>
		/// <java-name>
		/// java/io/FilenameFilter
		/// </java-name>
		[Dot42.DexImport("java/io/FilenameFilter", AccessFlags = 1537)]
		public partial interface IFilenameFilter
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Indicates if a specific filename matches this filter.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if the filename matches the filter and can be included in the list, <c>false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// accept
				/// </java-name>
				[Dot42.DexImport("accept", "(Ljava/io/File;Ljava/lang/String;)Z", AccessFlags = 1025)]
				bool Accept(global::Java.IO.File dir, string filename) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		///  <para>Defines an interface for classes that can (or need to) be flushed, typically before some output processing is considered to be finished and the object gets closed. </para>    
		/// </summary>
		/// <java-name>
		/// java/io/Flushable
		/// </java-name>
		[Dot42.DexImport("java/io/Flushable", AccessFlags = 1537)]
		public partial interface IFlushable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Flushes the object by writing out any buffered data to the underlying output.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// flush
				/// </java-name>
				[Dot42.DexImport("flush", "()V", AccessFlags = 1025)]
				void Flush() /* MethodBuilder.Create */ ;

		}

		/// <summary>
		///  <para>A readable source of bytes.</para> <para>Most clients will use input streams that read data from the file system (FileInputStream), the network (java.net.Socket#getInputStream()/java.net.HttpURLConnection#getInputStream()), or from an in-memory byte array (ByteArrayInputStream).</para> <para>Use InputStreamReader to adapt a byte stream like this one into a character stream.</para> <para>Most clients should wrap their input stream with BufferedInputStream. Callers that do only bulk reads may omit buffering.</para> <para>Some implementations support marking a position in the input stream and resetting back to this position later. Implementations that don't return false from markSupported() and throw an IOException when reset() is called.</para> <para> <h3>Subclassing InputStream</h3></para> <para>Subclasses that decorate another input stream should consider subclassing FilterInputStream, which delegates all calls to the source input stream.</para> <para>All input stream subclasses should override  <b>both</b> read() and read(byte[],int,int). The three argument overload is necessary for bulk access to the data. This is much more efficient than byte-by-byte access.</para> <para> <para>OutputStream </para></para>    
		/// </summary>
		/// <java-name>
		/// java/io/InputStream
		/// </java-name>
		[Dot42.DexImport("java/io/InputStream", AccessFlags = 1057)]
		public abstract partial class InputStream : global::Java.IO.ICloseable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>This constructor does nothing. It is provided for signature compatibility. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public InputStream() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns an estimated number of bytes that can be read or skipped without blocking for more input.</para> <para>Note that this method provides such a weak guarantee that it is not very useful in practice.</para> <para>Firstly, the guarantee is "without blocking for more input" rather than "withoutblocking": a read may still block waiting for I/O to complete  the guarantee is merely that it won't have to wait indefinitely for data to be written. The result of this method should not be used as a license to do I/O on a thread that shouldn't be blocked.</para> <para>Secondly, the result is a conservative estimate and may be significantly smaller than the actual number of bytes available. In particular, an implementation that always returns 0 would be correct. In general, callers should only use this method if they'd be satisfied with treating the result as a boolean yes or no answer to the question "is there definitelydata ready?".</para> <para>Thirdly, the fact that a given number of bytes is "available" does not guarantee that a read or skip will actually read or skip that many bytes: they may read or skip fewer.</para> <para>It is particularly important to realize that you  <b>must not</b> use this method to size a container and assume that you can read the entirety of the stream without needing to resize the container. Such callers should probably write everything they read to a ByteArrayOutputStream and convert that to a byte array. Alternatively, if you're reading from a file, File#length returns the current length of the file (though assuming the file's length can't change may be incorrect, reading a file is inherently racy).</para> <para>The default implementation of this method in <c>InputStream </c> always returns 0. Subclasses should override this method if they are able to indicate the number of bytes available.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the estimated number of bytes available </para>
				/// </returns>
				/// <java-name>
				/// available
				/// </java-name>
				[Dot42.DexImport("available", "()I", AccessFlags = 1)]
				public virtual int Available() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Closes this stream. Concrete implementations of this class should free any resources during close. This implementation does nothing.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1)]
				public virtual void Close() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets a mark position in this InputStream. The parameter <c>readlimit </c> indicates how many bytes can be read before the mark is invalidated. Sending <c>reset() </c> will reposition the stream back to the marked position provided <c>readLimit </c> has not been surpassed. </para> <para>This default implementation does nothing and concrete subclasses must provide their own implementation.</para> <para> <para>markSupported() </para> <para>reset() </para></para>        
				/// </summary>
				/// <java-name>
				/// mark
				/// </java-name>
				[Dot42.DexImport("mark", "(I)V", AccessFlags = 1)]
				public virtual void Mark(int readlimit) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Indicates whether this stream supports the <c>mark() </c> and  <c>reset() </c> methods. The default implementation returns <c>false </c> .</para> <para> <para>mark(int) </para> <para>reset() </para></para>        
				/// </summary>
				/// <returns>
				///  <para>always <c>false </c> . </para>
				/// </returns>
				/// <java-name>
				/// markSupported
				/// </java-name>
				[Dot42.DexImport("markSupported", "()Z", AccessFlags = 1)]
				public virtual bool MarkSupported() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Reads a single byte from this stream and returns it as an integer in the range from 0 to 255. Returns -1 if the end of the stream has been reached. Blocks until one byte has been read, the end of the source stream is detected or an exception is thrown.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "()I", AccessFlags = 1025)]
				public abstract int Read() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Equivalent to <c>read(buffer, 0, buffer.length) </c> . </para>        
				/// </summary>
				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([B)I", AccessFlags = 1)]
				public virtual int Read(sbyte[] buffer) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Equivalent to <c>read(buffer, 0, buffer.length) </c> . </para>        
				/// </summary>
				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([B)I", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual int Read(byte[] buffer) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Reads up to <c>byteCount </c> bytes from this stream and stores them in the byte array <c>buffer </c> starting at <c>byteOffset </c> . Returns the number of bytes actually read or -1 if the end of the stream has been reached.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([BII)I", AccessFlags = 1)]
				public virtual int Read(sbyte[] buffer, int byteOffset, int byteCount) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Reads up to <c>byteCount </c> bytes from this stream and stores them in the byte array <c>buffer </c> starting at <c>byteOffset </c> . Returns the number of bytes actually read or -1 if the end of the stream has been reached.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([BII)I", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual int Read(byte[] buffer, int byteOffset, int byteCount) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Resets this stream to the last marked location. Throws an  <c>IOException </c> if the number of bytes read since the mark has been set is greater than the limit provided to <c>mark </c> , or if no mark has been set. </para> <para>This implementation always throws an <c>IOException </c> and concrete subclasses should provide the proper implementation.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// reset
				/// </java-name>
				[Dot42.DexImport("reset", "()V", AccessFlags = 33)]
				public virtual void Reset() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Skips at most <c>n </c> bytes in this stream. This method does nothing and returns 0 if <c>n </c> is negative, but some subclasses may throw.</para> <para>Note the "at most" in the description of this method: this method may choose to skip fewer bytes than requested. Callers should  <b>always</b> check the return value.</para> <para>This default implementation reads bytes into a temporary buffer. Concrete subclasses should provide their own implementation.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the number of bytes actually skipped. </para>
				/// </returns>
				/// <java-name>
				/// skip
				/// </java-name>
				[Dot42.DexImport("skip", "(J)J", AccessFlags = 1)]
				public virtual long Skip(long byteCount) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

		}

		/// <summary>
		///  <para>A class for turning a byte stream into a character stream. Data read from the source input stream is converted into characters by either a default or a provided character converter. The default encoding is taken from the "file.encoding" system property. <c>InputStreamReader </c> contains a buffer of bytes read from the source stream and converts these into characters as needed. The buffer size is 8K.</para> <para> <para>OutputStreamWriter </para></para>    
		/// </summary>
		/// <java-name>
		/// java/io/InputStreamReader
		/// </java-name>
		[Dot42.DexImport("java/io/InputStreamReader", AccessFlags = 33)]
		public partial class InputStreamReader : global::Java.IO.Reader
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructs a new <c>InputStreamReader </c> on the InputStream  <c>in </c> . This constructor sets the character converter to the encoding specified in the "file.encoding" property and falls back to ISO 8859_1 (ISO-Latin-1) if the property doesn't exist.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/io/InputStream;)V", AccessFlags = 1)]
				public InputStreamReader(global::Java.IO.InputStream @in) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new InputStreamReader on the InputStream <c>in </c> and CharsetDecoder <c>dec </c> .</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/io/InputStream;Ljava/lang/String;)V", AccessFlags = 1)]
				public InputStreamReader(global::Java.IO.InputStream @in, string dec) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new InputStreamReader on the InputStream <c>in </c> and CharsetDecoder <c>dec </c> .</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/io/InputStream;Ljava/nio/charset/CharsetDecoder;)V", AccessFlags = 1)]
				public InputStreamReader(global::Java.IO.InputStream @in, global::Java.Nio.Charset.CharsetDecoder dec) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new InputStreamReader on the InputStream <c>in </c> and CharsetDecoder <c>dec </c> .</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/io/InputStream;Ljava/nio/charset/Charset;)V", AccessFlags = 1)]
				public InputStreamReader(global::Java.IO.InputStream @in, global::Java.Nio.Charset.Charset dec) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Closes this reader. This implementation closes the source InputStream and releases all local storage.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1)]
				public override void Close() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Reads a single character from this reader and returns it as an integer with the two higher-order bytes set to 0. Returns -1 if the end of the reader has been reached. The byte value is either obtained from converting bytes in this reader's buffer or by first filling the buffer from the source InputStream and then reading from the buffer.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the character read or -1 if the end of the reader has been reached. </para>
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
				///  <para>Reads up to <c>count </c> characters from this reader and stores them at position <c>offset </c> in the character array <c>buffer </c> . Returns the number of characters actually read or -1 if the end of the reader has been reached. The bytes are either obtained from converting bytes in this reader's buffer or by first filling the buffer from the source InputStream and then reading from the buffer.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([CII)I", AccessFlags = 1)]
				public override int Read(char[] buffer, int offset, int count) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Indicates whether this reader is ready to be read without blocking. If the result is <c>true </c> , the next <c>read() </c> will not block. If the result is <c>false </c> then this reader may or may not block when  <c>read() </c> is called. This implementation returns <c>true </c> if there are bytes available in the buffer or the source stream has bytes available.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if the receiver will not block when <c>read() </c> is called, <c>false </c> if unknown or blocking will occur. </para>
				/// </returns>
				/// <java-name>
				/// ready
				/// </java-name>
				[Dot42.DexImport("ready", "()Z", AccessFlags = 1)]
				public override bool Ready() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal InputStreamReader() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Returns the canonical name of the encoding used by this writer to convert characters to bytes, or null if this writer has been closed. Most callers should probably keep track of the String or Charset they passed in; this method may not return the same name. </para>        
				/// </summary>
				/// <java-name>
				/// getEncoding
				/// </java-name>
				public virtual string Encoding
				{
						[Dot42.DexImport("getEncoding", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

		}

		/// <summary>
		///  <para>Signals that a blocking I/O operation has been interrupted. The number of bytes that were transferred successfully before the interruption took place is stored in a field of the exception. </para>    
		/// </summary>
		/// <java-name>
		/// java/io/InterruptedIOException
		/// </java-name>
		[Dot42.DexImport("java/io/InterruptedIOException", AccessFlags = 33)]
		public partial class InterruptedIOException : global::System.IO.IOException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>The number of bytes transferred before the I/O interrupt occurred. </para>        
				/// </summary>
				/// <java-name>
				/// bytesTransferred
				/// </java-name>
				[Dot42.DexImport("bytesTransferred", "I", AccessFlags = 1)]
				public int BytesTransferred;
				/// <summary>
				///  <para>Constructs a new instance. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public InterruptedIOException() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new instance with the given detail message. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public InterruptedIOException(string detailMessage) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>Signals a problem during the serialization or or deserialization of an object. Possible reasons include:  <ul> <li> <para>The SUIDs of the class loaded by the VM and the serialized class info do not match. </para></li> <li> <para>A serializable or externalizable object cannot be instantiated (when deserializing) because the no-arg constructor that needs to be run is not visible or fails. </para></li></ul></para> <para> <para>ObjectInputStream #readObject() </para> <para>ObjectInputValidation::validateObject() </para></para>    
		/// </summary>
		/// <java-name>
		/// java/io/InvalidClassException
		/// </java-name>
		[Dot42.DexImport("java/io/InvalidClassException", AccessFlags = 33)]
		public partial class InvalidClassException : global::Java.IO.ObjectStreamException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>The fully qualified name of the class that caused the problem. </para>        
				/// </summary>
				/// <java-name>
				/// classname
				/// </java-name>
				[Dot42.DexImport("classname", "Ljava/lang/String;", AccessFlags = 1)]
				public string Classname;
				/// <summary>
				///  <para>Constructs a new <c>InvalidClassException </c> with its stack trace and detailed message filled in.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public InvalidClassException(string detailMessage) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new <c>InvalidClassException </c> with its stack trace, detail message and the fully qualified name of the class which caused the exception filled in.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public InvalidClassException(string className, string detailMessage) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns the detail message which was provided when the exception was created. <c>null </c> is returned if no message was provided at creation time. If a detail message as well as a class name are provided, then the values are concatenated and returned.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the detail message, possibly concatenated with the name of the class that caused the problem. </para>
				/// </returns>
				/// <java-name>
				/// getMessage
				/// </java-name>
				[Dot42.DexImport("getMessage", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string GetMessage() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal InvalidClassException() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		///  <para>Signals that, during deserialization, the validation of an object has failed.</para> <para> <para>ObjectInputStream::registerValidation(ObjectInputValidation, int) </para> <para>ObjectInputValidation::validateObject() </para></para>    
		/// </summary>
		/// <java-name>
		/// java/io/InvalidObjectException
		/// </java-name>
		[Dot42.DexImport("java/io/InvalidObjectException", AccessFlags = 33)]
		public partial class InvalidObjectException : global::Java.IO.ObjectStreamException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructs an <c>InvalidObjectException </c> with its stack trace and detail message filled in.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public InvalidObjectException(string detailMessage) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal InvalidObjectException() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		///  <para>Defines an interface for classes that allow reading serialized objects.</para> <para> <para>ObjectInputStream </para> <para>ObjectOutput </para></para>    
		/// </summary>
		/// <java-name>
		/// java/io/ObjectInput
		/// </java-name>
		[Dot42.DexImport("java/io/ObjectInput", AccessFlags = 1537)]
		public partial interface IObjectInput : global::Java.IO.IDataInput
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Indicates the number of bytes of primitive data that can be read without blocking.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the number of bytes available. </para>
				/// </returns>
				/// <java-name>
				/// available
				/// </java-name>
				[Dot42.DexImport("available", "()I", AccessFlags = 1025)]
				int Available() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Closes this stream. Implementations of this method should free any resources used by the stream.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1025)]
				void Close() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Reads a single byte from this stream and returns it as an integer in the range from 0 to 255. Returns -1 if the end of this stream has been reached. Blocks if no input is available.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the byte read or -1 if the end of this stream has been reached. </para>
				/// </returns>
				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "()I", AccessFlags = 1025)]
				int Read() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Reads bytes from this stream into the byte array <c>buffer </c> . Blocks while waiting for input. Returns the number of bytes read, or -1 if the end of this stream has been reached.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([B)I", AccessFlags = 1025)]
				int Read(sbyte[] buffer) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Reads up to <c>byteCount </c> bytes from this stream and stores them in byte array <c>buffer </c> starting at offset <c>byteOffset </c> . Blocks while waiting for input. Returns the number of bytes read or -1 if the end of this stream has been reached.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([BII)I", AccessFlags = 1025)]
				int Read(sbyte[] buffer, int byteOffset, int byteCount) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Reads the next object from this stream.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the object read.</para>
				/// </returns>
				/// <java-name>
				/// readObject
				/// </java-name>
				[Dot42.DexImport("readObject", "()Ljava/lang/Object;", AccessFlags = 1025)]
				object ReadObject() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Skips <c>byteCount </c> bytes on this stream. Less than <c>byteCount </c> byte are skipped if the end of this stream is reached before the operation completes.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the number of bytes actually skipped. </para>
				/// </returns>
				/// <java-name>
				/// skip
				/// </java-name>
				[Dot42.DexImport("skip", "(J)J", AccessFlags = 1025)]
				long Skip(long byteCount) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		///  <para>A callback interface for post-deserialization checks on objects. Allows, for example, the validation of a whole graph of objects after all of them have been loaded.</para> <para> <para>ObjectInputStream::registerValidation(ObjectInputValidation, int) </para></para>    
		/// </summary>
		/// <java-name>
		/// java/io/ObjectInputValidation
		/// </java-name>
		[Dot42.DexImport("java/io/ObjectInputValidation", AccessFlags = 1537)]
		public partial interface IObjectInputValidation
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Validates this object.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// validateObject
				/// </java-name>
				[Dot42.DexImport("validateObject", "()V", AccessFlags = 1025)]
				void ValidateObject() /* MethodBuilder.Create */ ;

		}

		/// <summary>
		///  <para>Defines an interface for classes that allow reading serialized objects.</para> <para> <para>ObjectOutputStream </para> <para>ObjectInput </para></para>    
		/// </summary>
		/// <java-name>
		/// java/io/ObjectOutput
		/// </java-name>
		[Dot42.DexImport("java/io/ObjectOutput", AccessFlags = 1537)]
		public partial interface IObjectOutput : global::Java.IO.IDataOutput
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Closes the target stream. Implementations of this method should free any resources used by the stream.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1025)]
				void Close() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Flushes the target stream. Implementations of this method should ensure that any pending writes are written out to the target stream.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// flush
				/// </java-name>
				[Dot42.DexImport("flush", "()V", AccessFlags = 1025)]
				void Flush() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Writes a single byte to the target stream. Only the least significant byte of the integer <c>value </c> is written to the stream. Blocks until the byte is actually written.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([B)V", AccessFlags = 1025)]
				void Write(sbyte[] value) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Writes <c>count </c> bytes from the byte array <c>buffer </c> starting at position <c>offset </c> to the target stream. Blocks until all bytes are written.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([BII)V", AccessFlags = 1025)]
				void Write(sbyte[] buffer, int offset, int count) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Writes a single byte to the target stream. Only the least significant byte of the integer <c>value </c> is written to the stream. Blocks until the byte is actually written.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "(I)V", AccessFlags = 1025)]
				void Write(int value) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Writes the specified object <c>obj </c> to the target stream.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// writeObject
				/// </java-name>
				[Dot42.DexImport("writeObject", "(Ljava/lang/Object;)V", AccessFlags = 1025)]
				void WriteObject(object obj) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		///  <para>A helper interface with constants used by the serialization implementation. </para>    
		/// </summary>
		/// <java-name>
		/// java/io/ObjectStreamConstants
		/// </java-name>
		[Dot42.DexImport("java/io/ObjectStreamConstants", AccessFlags = 1537)]
		public partial interface IObjectStreamConstants
 /* scope: __dot42__ */ 
		{
		}

		/// <summary>
		///  <para>A helper interface with constants used by the serialization implementation. </para>    
		/// </summary>
		/// <java-name>
		/// java/io/ObjectStreamConstants
		/// </java-name>
		[Dot42.DexImport("java/io/ObjectStreamConstants", AccessFlags = 1537, IgnoreFromJava = true, Priority = 1)]
		public static partial class IObjectStreamConstantsConstants
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>The stream header's magic number. </para>        
				/// </summary>
				/// <java-name>
				/// STREAM_MAGIC
				/// </java-name>
				[Dot42.DexImport("STREAM_MAGIC", "S", AccessFlags = 25)]
				public const short STREAM_MAGIC = -21267;
				/// <summary>
				///  <para>The stream header's version number. </para>        
				/// </summary>
				/// <java-name>
				/// STREAM_VERSION
				/// </java-name>
				[Dot42.DexImport("STREAM_VERSION", "S", AccessFlags = 25)]
				public const short STREAM_VERSION = 5;
				/// <summary>
				///  <para>The minimum tag value. </para>        
				/// </summary>
				/// <java-name>
				/// TC_BASE
				/// </java-name>
				[Dot42.DexImport("TC_BASE", "B", AccessFlags = 25)]
				public const sbyte TC_BASE = 112;
				/// <summary>
				///  <para>Tag to mark a <c>null </c> object reference. </para>        
				/// </summary>
				/// <java-name>
				/// TC_NULL
				/// </java-name>
				[Dot42.DexImport("TC_NULL", "B", AccessFlags = 25)]
				public const sbyte TC_NULL = 112;
				/// <summary>
				///  <para>Tag to mark a reference to an object that has already been written to the stream. </para>        
				/// </summary>
				/// <java-name>
				/// TC_REFERENCE
				/// </java-name>
				[Dot42.DexImport("TC_REFERENCE", "B", AccessFlags = 25)]
				public const sbyte TC_REFERENCE = 113;
				/// <summary>
				///  <para>Tag to mark a new class descriptor. </para>        
				/// </summary>
				/// <java-name>
				/// TC_CLASSDESC
				/// </java-name>
				[Dot42.DexImport("TC_CLASSDESC", "B", AccessFlags = 25)]
				public const sbyte TC_CLASSDESC = 114;
				/// <summary>
				///  <para>Tag to mark a new object. </para>        
				/// </summary>
				/// <java-name>
				/// TC_OBJECT
				/// </java-name>
				[Dot42.DexImport("TC_OBJECT", "B", AccessFlags = 25)]
				public const sbyte TC_OBJECT = 115;
				/// <summary>
				///  <para>Tag to mark a new string. </para>        
				/// </summary>
				/// <java-name>
				/// TC_STRING
				/// </java-name>
				[Dot42.DexImport("TC_STRING", "B", AccessFlags = 25)]
				public const sbyte TC_STRING = 116;
				/// <summary>
				///  <para>Tag to mark a new array. </para>        
				/// </summary>
				/// <java-name>
				/// TC_ARRAY
				/// </java-name>
				[Dot42.DexImport("TC_ARRAY", "B", AccessFlags = 25)]
				public const sbyte TC_ARRAY = 117;
				/// <summary>
				///  <para>Tag to mark a reference to a class. </para>        
				/// </summary>
				/// <java-name>
				/// TC_CLASS
				/// </java-name>
				[Dot42.DexImport("TC_CLASS", "B", AccessFlags = 25)]
				public const sbyte TC_CLASS = 118;
				/// <summary>
				///  <para>Tag to mark a block of optional data. The byte following this tag indicates the size of the block. </para>        
				/// </summary>
				/// <java-name>
				/// TC_BLOCKDATA
				/// </java-name>
				[Dot42.DexImport("TC_BLOCKDATA", "B", AccessFlags = 25)]
				public const sbyte TC_BLOCKDATA = 119;
				/// <summary>
				///  <para>Tag to mark the end of block data blocks for an object. </para>        
				/// </summary>
				/// <java-name>
				/// TC_ENDBLOCKDATA
				/// </java-name>
				[Dot42.DexImport("TC_ENDBLOCKDATA", "B", AccessFlags = 25)]
				public const sbyte TC_ENDBLOCKDATA = 120;
				/// <summary>
				///  <para>Tag to mark a stream reset. </para>        
				/// </summary>
				/// <java-name>
				/// TC_RESET
				/// </java-name>
				[Dot42.DexImport("TC_RESET", "B", AccessFlags = 25)]
				public const sbyte TC_RESET = 121;
				/// <summary>
				///  <para>Tag to mark a long block of data. The long following this tag indicates the size of the block. </para>        
				/// </summary>
				/// <java-name>
				/// TC_BLOCKDATALONG
				/// </java-name>
				[Dot42.DexImport("TC_BLOCKDATALONG", "B", AccessFlags = 25)]
				public const sbyte TC_BLOCKDATALONG = 122;
				/// <summary>
				///  <para>Tag to mark an exception. </para>        
				/// </summary>
				/// <java-name>
				/// TC_EXCEPTION
				/// </java-name>
				[Dot42.DexImport("TC_EXCEPTION", "B", AccessFlags = 25)]
				public const sbyte TC_EXCEPTION = 123;
				/// <summary>
				///  <para>Tag to mark a long string. </para>        
				/// </summary>
				/// <java-name>
				/// TC_LONGSTRING
				/// </java-name>
				[Dot42.DexImport("TC_LONGSTRING", "B", AccessFlags = 25)]
				public const sbyte TC_LONGSTRING = 124;
				/// <summary>
				///  <para>Tag to mark a new proxy class descriptor. </para>        
				/// </summary>
				/// <java-name>
				/// TC_PROXYCLASSDESC
				/// </java-name>
				[Dot42.DexImport("TC_PROXYCLASSDESC", "B", AccessFlags = 25)]
				public const sbyte TC_PROXYCLASSDESC = 125;
				/// <summary>
				///  <para>The maximum tag value. </para>        
				/// </summary>
				/// <java-name>
				/// TC_MAX
				/// </java-name>
				[Dot42.DexImport("TC_MAX", "B", AccessFlags = 25)]
				public const sbyte TC_MAX = 126;
				/// <summary>
				///  <para>Handle for the first object that gets serialized. </para>        
				/// </summary>
				/// <java-name>
				/// baseWireHandle
				/// </java-name>
				[Dot42.DexImport("baseWireHandle", "I", AccessFlags = 25)]
				public const int BaseWireHandle = 8257536;
				/// <summary>
				///  <para>Stream protocol version 1. </para>        
				/// </summary>
				/// <java-name>
				/// PROTOCOL_VERSION_1
				/// </java-name>
				[Dot42.DexImport("PROTOCOL_VERSION_1", "I", AccessFlags = 25)]
				public const int PROTOCOL_VERSION_1 = 1;
				/// <summary>
				///  <para>Stream protocol version 2. </para>        
				/// </summary>
				/// <java-name>
				/// PROTOCOL_VERSION_2
				/// </java-name>
				[Dot42.DexImport("PROTOCOL_VERSION_2", "I", AccessFlags = 25)]
				public const int PROTOCOL_VERSION_2 = 2;
				/// <summary>
				///  <para>Permission constant to enable subclassing of ObjectInputStream and ObjectOutputStream. </para>        
				/// </summary>
				/// <java-name>
				/// SUBCLASS_IMPLEMENTATION_PERMISSION
				/// </java-name>
				[Dot42.DexImport("SUBCLASS_IMPLEMENTATION_PERMISSION", "Ljava/io/SerializablePermission;", AccessFlags = 25)]
				public static readonly global::Java.IO.SerializablePermission SUBCLASS_IMPLEMENTATION_PERMISSION;
				/// <summary>
				///  <para>Permission constant to enable object substitution during serialization and deserialization. </para>        
				/// </summary>
				/// <java-name>
				/// SUBSTITUTION_PERMISSION
				/// </java-name>
				[Dot42.DexImport("SUBSTITUTION_PERMISSION", "Ljava/io/SerializablePermission;", AccessFlags = 25)]
				public static readonly global::Java.IO.SerializablePermission SUBSTITUTION_PERMISSION;
				/// <summary>
				///  <para>Bit mask for the <c>flag </c> field in ObjectStreamClass. Indicates that a serializable class has its own <c>writeObject </c> method. </para>        
				/// </summary>
				/// <java-name>
				/// SC_WRITE_METHOD
				/// </java-name>
				[Dot42.DexImport("SC_WRITE_METHOD", "B", AccessFlags = 25)]
				public const sbyte SC_WRITE_METHOD = 1;
				/// <summary>
				///  <para>Bit mask for the <c>flag </c> field in ObjectStreamClass. Indicates that a class is serializable. </para>        
				/// </summary>
				/// <java-name>
				/// SC_SERIALIZABLE
				/// </java-name>
				[Dot42.DexImport("SC_SERIALIZABLE", "B", AccessFlags = 25)]
				public const sbyte SC_SERIALIZABLE = 2;
				/// <summary>
				///  <para>Bit mask for the <c>flag </c> field in ObjectStreamClass. Indicates that a class is externalizable. </para>        
				/// </summary>
				/// <java-name>
				/// SC_EXTERNALIZABLE
				/// </java-name>
				[Dot42.DexImport("SC_EXTERNALIZABLE", "B", AccessFlags = 25)]
				public const sbyte SC_EXTERNALIZABLE = 4;
				/// <summary>
				///  <para>Bit mask for the <c>flag </c> field in ObjectStreamClass. Indicates that an externalizable class is written in block data mode. </para>        
				/// </summary>
				/// <java-name>
				/// SC_BLOCK_DATA
				/// </java-name>
				[Dot42.DexImport("SC_BLOCK_DATA", "B", AccessFlags = 25)]
				public const sbyte SC_BLOCK_DATA = 8;
				/// <summary>
				///  <para>Tag to mark a new enum. </para>        
				/// </summary>
				/// <java-name>
				/// TC_ENUM
				/// </java-name>
				[Dot42.DexImport("TC_ENUM", "B", AccessFlags = 25)]
				public const sbyte TC_ENUM = 126;
				/// <summary>
				///  <para>Bit mask for the <c>flag </c> field in ObjectStreamClass. Indicates that a class is an enum type. </para>        
				/// </summary>
				/// <java-name>
				/// SC_ENUM
				/// </java-name>
				[Dot42.DexImport("SC_ENUM", "B", AccessFlags = 25)]
				public const sbyte SC_ENUM = 16;
		}

		/// <summary>
		///  <para>This error is thrown when a severe I/O error has happened.</para> <para> <para>1.6 </para></para>    
		/// </summary>
		/// <java-name>
		/// java/io/IOError
		/// </java-name>
		[Dot42.DexImport("java/io/IOError", AccessFlags = 33)]
		public partial class IOError : global::Java.Lang.Error
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructs a new instance with its cause filled in.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public IOError(global::System.Exception cause) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal IOError() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		///  <para>Marks classes that can be serialized by ObjectOutputStream and deserialized by ObjectInputStream.</para> <para> <b>Warning:</b> this interface limits how its implementing classes can change in the future. By implementing <c>Serializable </c> you expose your flexible in-memory implementation details as a rigid binary representation. Simple code changeslike renaming private fieldsare not safe when the changed class is serializable.</para> <para> <h3>The Serialized Form</h3></para> <para>By default, the serialization mechanism encodes an object's class name, the names of its non-transient fields (including non-public fields), and the values of all of those fields. The output is an opaque sequence of bytes. Those bytes can be decoded into a new, equivalent instance as long as the decoder has compatible versions of the originating classes.</para> <para>Changing the class name, field names or field types breaks serialization compatibility and complicates interoperability between old and new versions of the serializable class. Adding or removing fields also complicates serialization between versions of a class because it requires your code to cope with missing fields.</para> <para>Every serializable class is assigned a version identifier called a <c>serialVersionUID </c> . By default, this identifier is computed by hashing the class declaration and its members. This identifier is included in the serialized form so that version conflicts can be detected during deserialization. If the local <c>serialVersionUID </c> differs from the  <c>serialVersionUID </c> in the serialized data, deserialization will fail with an InvalidClassException.</para> <para>You can avoid this failure by declaring an explicit <c>serialVersionUID </c> . Declaring an explicit <c>serialVersionUID </c> tells the serialization mechanism that the class is forward and backward compatible with all versions that share that <c>serialVersionUID </c> . Declaring a  <c>serialVersionUID </c> looks like this:  <pre>private static final long serialVersionUID = 0L;
		/// 
		///  </pre> If you declare a <c>serialVersionUID </c> , you should increment it each time your class changes incompatibly with the previous version. Typically this is when you add, change or remove a non-transient field.</para> <para>You can take control of your serialized form by implementing these two methods with these exact signatures in your serializable classes:  <pre>private void writeObject(java.io.ObjectOutputStream out)
		/// 
		///     throws IOException {
		/// 
		///   // write 'this' to 'out'...
		/// 
		/// }
		/// 
		/// 
		/// 
		/// private void readObject(java.io.ObjectInputStream in)
		/// 
		///     throws IOException, ClassNotFoundException {
		/// 
		///   // populate the fields of 'this' from the data in 'in'...
		/// 
		/// }
		/// 
		///  </pre> It is impossible to maintain serialization compatibility across a class name change. For this reason, implementing <c>Serializable </c> in anonymous inner classes is highly discouraged: simply reordering the members in the file could change the generated class name and break serialization compatibility.</para> <para>You can exclude member fields from serialization by giving them the <c>transient </c> modifier. Upon deserialization, the transient field's value will be null, 0, or false according to its type.</para> <para> <h3>Implement Serializable Judiciously</h3></para> <para>Refer to  <b>Effective Java</b>'s chapter on serialization for thorough coverage of the serialization API. The book explains how to use this interface without harming your application's maintainability.</para> <para> <h3>Recommended Alternatives</h3></para> <para> <b>JSON</b> is concise, human-readable and efficient. Android includes both a streaming API and a tree API to read and write JSON. Use a binding library like  to read and write Java objects directly. </para>    
		/// </summary>
		/// <java-name>
		/// java/io/Serializable
		/// </java-name>
		[Dot42.DexImport("java/io/Serializable", AccessFlags = 1537)]
		public partial interface ISerializable
 /* scope: __dot42__ */ 
		{
		}

		/// <summary>
		///  <para>Wraps an existing InputStream and counts the line terminators encountered while reading the data. Line numbering starts at 0. Recognized line terminator sequences are <c>'\r' </c> , <c>'\n' </c> and <c>"\r\n" </c> . When using <c>read </c> , line terminator sequences are always translated into  <c>'\n' </c> .</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use LineNumberReader instead. </para></xrefdescription></xrefsect></para>    
		/// </summary>
		/// <java-name>
		/// java/io/LineNumberInputStream
		/// </java-name>
		[Dot42.DexImport("java/io/LineNumberInputStream", AccessFlags = 33)]
		public partial class LineNumberInputStream : global::Java.IO.FilterInputStream
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructs a new <c>LineNumberInputStream </c> on the InputStream  <c>in </c> . Line numbers are counted for all data read from this stream.</para> <para> <b>Warning:</b> passing a null source creates an invalid  <c>LineNumberInputStream </c> . All operations on such a stream will fail.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/io/InputStream;)V", AccessFlags = 1)]
				public LineNumberInputStream(global::Java.IO.InputStream @in) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Note that the source stream may just be a sequence of <c>"\r\n" </c> bytes which are converted into <c>'\n' </c> by this stream. Therefore,  <c>available </c> returns only <c>in.available() / 2 </c> bytes as result. </para>        
				/// </summary>
				/// <java-name>
				/// available
				/// </java-name>
				[Dot42.DexImport("available", "()I", AccessFlags = 1)]
				public override int Available() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Sets a mark position in this stream. The parameter <c>readlimit </c> indicates how many bytes can be read before the mark is invalidated. Sending <c>reset() </c> will reposition this stream back to the marked position, provided that <c>readlimit </c> has not been surpassed. The line number count will also be reset to the last marked line number count. </para> <para>This implementation sets a mark in the filtered stream.</para> <para> <para>markSupported() </para> <para>reset() </para></para>        
				/// </summary>
				/// <java-name>
				/// mark
				/// </java-name>
				[Dot42.DexImport("mark", "(I)V", AccessFlags = 1)]
				public override void Mark(int readlimit) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Reads a single byte from the filtered stream and returns it as an integer in the range from 0 to 255. Returns -1 if the end of this stream has been reached. </para> <para>The line number count is incremented if a line terminator is encountered. Recognized line terminator sequences are <c>'\r' </c> , <c>'\n' </c> and  <c>"\r\n" </c> . Line terminator sequences are always translated into  <c>'\n' </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the byte read or -1 if the end of the filtered stream has been reached. </para>
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
				///  <para>Reads up to <c>byteCount </c> bytes from the filtered stream and stores them in the byte array <c>buffer </c> starting at <c>byteOffset </c> . Returns the number of bytes actually read or -1 if no bytes have been read and the end of this stream has been reached.</para> <para>The line number count is incremented if a line terminator is encountered. Recognized line terminator sequences are <c>'\r' </c> , <c>'\n' </c> and  <c>"\r\n" </c> . Line terminator sequences are always translated into  <c>'\n' </c> .</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([BII)I", AccessFlags = 1)]
				public override int Read(sbyte[] buffer, int byteOffset, int byteCount) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Reads up to <c>byteCount </c> bytes from the filtered stream and stores them in the byte array <c>buffer </c> starting at <c>byteOffset </c> . Returns the number of bytes actually read or -1 if no bytes have been read and the end of this stream has been reached.</para> <para>The line number count is incremented if a line terminator is encountered. Recognized line terminator sequences are <c>'\r' </c> , <c>'\n' </c> and  <c>"\r\n" </c> . Line terminator sequences are always translated into  <c>'\n' </c> .</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([BII)I", AccessFlags = 1, IgnoreFromJava = true)]
				public override int Read(byte[] buffer, int byteOffset, int byteCount) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Resets this stream to the last marked location. It also resets the line count to what is was when this stream was marked.</para> <para> <para>mark(int) </para> <para>markSupported() </para></para>        
				/// </summary>
				/// <java-name>
				/// reset
				/// </java-name>
				[Dot42.DexImport("reset", "()V", AccessFlags = 1)]
				public override void Reset() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Skips <c>count </c> number of bytes in this stream. Subsequent calls to <c>read </c> will not return these bytes unless <c>reset </c> is used. This implementation skips <c>byteCount </c> bytes in the filtered stream and increments the line number count whenever line terminator sequences are skipped.</para> <para> <para>mark(int) </para> <para>read() </para> <para>reset() </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the number of bytes actually skipped. </para>
				/// </returns>
				/// <java-name>
				/// skip
				/// </java-name>
				[Dot42.DexImport("skip", "(J)J", AccessFlags = 1)]
				public override long Skip(long byteCount) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal LineNumberInputStream() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Returns the current line number for this stream. Numbering starts at 0.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the current line number. </para>
				/// </returns>
				/// <java-name>
				/// getLineNumber
				/// </java-name>
				public virtual int LineNumber
				{
						[Dot42.DexImport("getLineNumber", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setLineNumber", "(I)V", AccessFlags = 1)]
						set{ }
				}

		}

		/// <summary>
		///  <para>Wraps an existing Reader and counts the line terminators encountered while reading the data. The line number starts at 0 and is incremented any time <c>'\r' </c> , <c>'\n' </c> or <c>"\r\n" </c> is read. The class has an internal buffer for its data. The size of the buffer defaults to 8 KB. </para>    
		/// </summary>
		/// <java-name>
		/// java/io/LineNumberReader
		/// </java-name>
		[Dot42.DexImport("java/io/LineNumberReader", AccessFlags = 33)]
		public partial class LineNumberReader : global::Java.IO.BufferedReader
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructs a new LineNumberReader on the Reader <c>in </c> . The internal buffer gets the default size (8 KB).</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/io/Reader;)V", AccessFlags = 1)]
				public LineNumberReader(global::Java.IO.Reader @in) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new LineNumberReader on the Reader <c>in </c> . The size of the internal buffer is specified by the parameter <c>size </c> .</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/io/Reader;I)V", AccessFlags = 1)]
				public LineNumberReader(global::Java.IO.Reader @in, int size) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets a mark position in this reader. The parameter <c>readlimit </c> indicates how many characters can be read before the mark is invalidated. Sending <c>reset() </c> will reposition this reader back to the marked position, provided that <c>readlimit </c> has not been surpassed. The line number associated with this marked position is also stored so that it can be restored when <c>reset() </c> is called.</para> <para> <para>markSupported() </para> <para>reset() </para></para>        
				/// </summary>
				/// <java-name>
				/// mark
				/// </java-name>
				[Dot42.DexImport("mark", "(I)V", AccessFlags = 1)]
				public override void Mark(int readlimit) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Reads a single character from the source reader and returns it as an integer with the two higher-order bytes set to 0. Returns -1 if the end of the source reader has been reached. </para> <para>The line number count is incremented if a line terminator is encountered. Recognized line terminator sequences are <c>'\r' </c> , <c>'\n' </c> and  <c>"\r\n" </c> . Line terminator sequences are always translated into  <c>'\n' </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the character read or -1 if the end of the source reader has been reached. </para>
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
				///  <para>Reads up to <c>count </c> characters from the source reader and stores them in the character array <c>buffer </c> starting at <c>offset </c> . Returns the number of characters actually read or -1 if no characters have been read and the end of this reader has been reached.</para> <para>The line number count is incremented if a line terminator is encountered. Recognized line terminator sequences are <c>'\r' </c> , <c>'\n' </c> and  <c>"\r\n" </c> .</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([CII)I", AccessFlags = 1)]
				public override int Read(char[] buffer, int offset, int count) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Returns the next line of text available from this reader. A line is represented by 0 or more characters followed by <c>'\r' </c> ,  <c>'\n' </c> , <c>"\r\n" </c> or the end of the stream. The returned string does not include the newline sequence.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the contents of the line or <c>null </c> if no characters have been read before the end of the stream has been reached. </para>
				/// </returns>
				/// <java-name>
				/// readLine
				/// </java-name>
				[Dot42.DexImport("readLine", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ReadLine() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Resets this reader to the last marked location. It also resets the line count to what is was when this reader was marked. This implementation resets the source reader.</para> <para> <para>mark(int) </para> <para>markSupported() </para></para>        
				/// </summary>
				/// <java-name>
				/// reset
				/// </java-name>
				[Dot42.DexImport("reset", "()V", AccessFlags = 1)]
				public override void Reset() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Skips <c>charCount </c> characters in this reader. Subsequent calls to  <c>read </c> will not return these characters unless <c>reset </c> is used. This implementation skips <c>charCount </c> number of characters in the source reader and increments the line number count whenever line terminator sequences are skipped.</para> <para> <para>mark(int) </para> <para>read() </para> <para>reset() </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the number of characters actually skipped. </para>
				/// </returns>
				/// <java-name>
				/// skip
				/// </java-name>
				[Dot42.DexImport("skip", "(J)J", AccessFlags = 1)]
				public override long Skip(long charCount) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal LineNumberReader() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Returns the current line number for this reader. Numbering starts at 0.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the current line number. </para>
				/// </returns>
				/// <java-name>
				/// getLineNumber
				/// </java-name>
				public virtual int LineNumber
				{
						[Dot42.DexImport("getLineNumber", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setLineNumber", "(I)V", AccessFlags = 1)]
						set{ }
				}

		}

		/// <summary>
		///  <para>Signals that a serialization-related method has been invoked in the wrong place. Some methods in <c>ObjectInputStream </c> and <c>ObjectOutputStream </c> can only be called from a nested call to readObject() or writeObject(). Any attempt to call them from another context will cause a  <c>NotActiveException </c> to be thrown. The list of methods that are protected this way is:  <ul> <li> <para>ObjectInputStream#defaultReadObject() </para></li> <li> <para>ObjectInputStream#registerValidation(ObjectInputValidation, int) </para></li> <li> <para>ObjectOutputStream#defaultWriteObject() </para></li></ul></para>    
		/// </summary>
		/// <java-name>
		/// java/io/NotActiveException
		/// </java-name>
		[Dot42.DexImport("java/io/NotActiveException", AccessFlags = 33)]
		public partial class NotActiveException : global::Java.IO.ObjectStreamException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructs a new <c>NotActiveException </c> with its stack trace filled in. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public NotActiveException() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new <c>NotActiveException </c> with its stack trace and detail message filled in.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public NotActiveException(string detailMessage) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>Signals that an object that is not serializable has been passed into the  <c>ObjectOutput.writeObject() </c> method. This can happen if the object does not implement <c>Serializable </c> or <c>Externalizable </c> , or if it is serializable but it overrides <c>writeObject(ObjectOutputStream) </c> and explicitly prevents serialization by throwing this type of exception.</para> <para> <para>ObjectOutput::writeObject(Object) </para> <para>ObjectOutputStream::writeObject(Object) </para></para>    
		/// </summary>
		/// <java-name>
		/// java/io/NotSerializableException
		/// </java-name>
		[Dot42.DexImport("java/io/NotSerializableException", AccessFlags = 33)]
		public partial class NotSerializableException : global::Java.IO.ObjectStreamException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructs a new <c>NotSerializableException </c> with its stack trace filled in. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public NotSerializableException() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new NotSerializableException with its stack trace and detail message filled in.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public NotSerializableException(string detailMessage) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>A specialized InputStream that is able to read (deserialize) Java objects as well as primitive data types (int, byte, char etc.). The data has typically been saved using an ObjectOutputStream.</para> <para> <para>ObjectOutputStream </para> <para>ObjectInput </para> <para>Serializable </para> <para>Externalizable </para></para>    
		/// </summary>
		/// <java-name>
		/// java/io/ObjectInputStream
		/// </java-name>
		[Dot42.DexImport("java/io/ObjectInputStream", AccessFlags = 33)]
		public partial class ObjectInputStream : global::Java.IO.InputStream, global::Java.IO.IObjectInput, global::Java.IO.IObjectStreamConstants
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructs a new ObjectInputStream. This default constructor can be used by subclasses that do not want to use the public constructor if it allocates unneeded data.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal ObjectInputStream() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new ObjectInputStream that reads from the InputStream  <c>input </c> .</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/io/InputStream;)V", AccessFlags = 1)]
				public ObjectInputStream(global::Java.IO.InputStream input) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Indicates the number of bytes of primitive data that can be read without blocking.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the number of bytes available. </para>
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
				///  <para>Closes this stream. This implementation closes the source stream.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1)]
				public override void Close() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Default method to read objects from this stream. Serializable fields defined in the object's class and superclasses are read from the source stream.</para> <para> <para>ObjectOutputStream::defaultWriteObject </para></para>        
				/// </summary>
				/// <java-name>
				/// defaultReadObject
				/// </java-name>
				[Dot42.DexImport("defaultReadObject", "()V", AccessFlags = 1)]
				public virtual void DefaultReadObject() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Enables object replacement for this stream. By default this is not enabled. Only trusted subclasses (loaded with system class loader) are allowed to change this status.</para> <para> <para>resolveObject </para> <para>ObjectOutputStream::enableReplaceObject </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the previous setting. </para>
				/// </returns>
				/// <java-name>
				/// enableResolveObject
				/// </java-name>
				[Dot42.DexImport("enableResolveObject", "(Z)Z", AccessFlags = 4)]
				protected internal virtual bool EnableResolveObject(bool enable) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Reads a single byte from the source stream and returns it as an integer in the range from 0 to 255. Returns -1 if the end of the source stream has been reached. Blocks if no input is available.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the byte read or -1 if the end of the source stream has been reached. </para>
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
				///  <para>Reads up to <c>byteCount </c> bytes from this stream and stores them in byte array <c>buffer </c> starting at offset <c>byteOffset </c> . Blocks while waiting for input. Returns the number of bytes read or -1 if the end of this stream has been reached.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([BII)I", AccessFlags = 1)]
				public override int Read(sbyte[] buffer, int byteOffset, int byteCount) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Reads up to <c>byteCount </c> bytes from this stream and stores them in byte array <c>buffer </c> starting at offset <c>byteOffset </c> . Blocks while waiting for input. Returns the number of bytes read or -1 if the end of this stream has been reached.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([BII)I", AccessFlags = 1, IgnoreFromJava = true)]
				public override int Read(byte[] buffer, int byteOffset, int byteCount) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Reads a boolean from the source stream.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the boolean value read from the source stream. </para>
				/// </returns>
				/// <java-name>
				/// readBoolean
				/// </java-name>
				[Dot42.DexImport("readBoolean", "()Z", AccessFlags = 1)]
				public virtual bool ReadBoolean() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Reads a byte (8 bit) from the source stream.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the byte value read from the source stream. </para>
				/// </returns>
				/// <java-name>
				/// readByte
				/// </java-name>
				[Dot42.DexImport("readByte", "()B", AccessFlags = 1)]
				public virtual sbyte JavaReadByte() /* MethodBuilder.Create */ 
				{
						return default(sbyte);
				}

				/// <summary>
				///  <para>Reads a byte (8 bit) from the source stream.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the byte value read from the source stream. </para>
				/// </returns>
				/// <java-name>
				/// readByte
				/// </java-name>
				[Dot42.DexImport("readByte", "()B", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual byte ReadByte() /* MethodBuilder.Create */ 
				{
						return default(byte);
				}

				/// <summary>
				///  <para>Reads a character (16 bit) from the source stream.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the char value read from the source stream. </para>
				/// </returns>
				/// <java-name>
				/// readChar
				/// </java-name>
				[Dot42.DexImport("readChar", "()C", AccessFlags = 1)]
				public virtual char ReadChar() /* MethodBuilder.Create */ 
				{
						return default(char);
				}

				/// <summary>
				///  <para>Reads a double (64 bit) from the source stream.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the double value read from the source stream. </para>
				/// </returns>
				/// <java-name>
				/// readDouble
				/// </java-name>
				[Dot42.DexImport("readDouble", "()D", AccessFlags = 1)]
				public virtual double ReadDouble() /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <summary>
				///  <para>Reads the persistent fields of the object that is currently being read from the source stream. The values read are stored in a GetField object that provides access to the persistent fields. This GetField object is then returned.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the GetField object from which persistent fields can be accessed by name. </para>
				/// </returns>
				/// <java-name>
				/// readFields
				/// </java-name>
				[Dot42.DexImport("readFields", "()Ljava/io/ObjectInputStream$GetField;", AccessFlags = 1)]
				public virtual global::Java.IO.ObjectInputStream.GetField ReadFields() /* MethodBuilder.Create */ 
				{
						return default(global::Java.IO.ObjectInputStream.GetField);
				}

				/// <summary>
				///  <para>Reads a float (32 bit) from the source stream.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the float value read from the source stream. </para>
				/// </returns>
				/// <java-name>
				/// readFloat
				/// </java-name>
				[Dot42.DexImport("readFloat", "()F", AccessFlags = 1)]
				public virtual float ReadFloat() /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				///  <para>Reads bytes from the source stream into the byte array <c>dst </c> . This method will block until <c>dst.length </c> bytes have been read.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// readFully
				/// </java-name>
				[Dot42.DexImport("readFully", "([B)V", AccessFlags = 1)]
				public virtual void ReadFully(sbyte[] dst) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Reads bytes from the source stream into the byte array <c>dst </c> . This method will block until <c>dst.length </c> bytes have been read.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// readFully
				/// </java-name>
				[Dot42.DexImport("readFully", "([B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual void ReadFully(byte[] dst) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Reads <c>byteCount </c> bytes from the source stream into the byte array <c>dst </c> .</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// readFully
				/// </java-name>
				[Dot42.DexImport("readFully", "([BII)V", AccessFlags = 1)]
				public virtual void ReadFully(sbyte[] dst, int offset, int byteCount) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Reads <c>byteCount </c> bytes from the source stream into the byte array <c>dst </c> .</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// readFully
				/// </java-name>
				[Dot42.DexImport("readFully", "([BII)V", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual void ReadFully(byte[] dst, int offset, int byteCount) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Reads an integer (32 bit) from the source stream.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the integer value read from the source stream. </para>
				/// </returns>
				/// <java-name>
				/// readInt
				/// </java-name>
				[Dot42.DexImport("readInt", "()I", AccessFlags = 1)]
				public virtual int ReadInt() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Reads the next line from the source stream. Lines are terminated by  <c>'\r' </c> , <c>'\n' </c> , <c>"\r\n" </c> or an <c>EOF </c> .</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use BufferedReader instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				///  <para>the string read from the source stream. </para>
				/// </returns>
				/// <java-name>
				/// readLine
				/// </java-name>
				[Dot42.DexImport("readLine", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string ReadLine() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Reads a long (64 bit) from the source stream.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the long value read from the source stream. </para>
				/// </returns>
				/// <java-name>
				/// readLong
				/// </java-name>
				[Dot42.DexImport("readLong", "()J", AccessFlags = 1)]
				public virtual long ReadLong() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				///  <para>Reads a class descriptor from the source stream.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the class descriptor read from the source stream. </para>
				/// </returns>
				/// <java-name>
				/// readClassDescriptor
				/// </java-name>
				[Dot42.DexImport("readClassDescriptor", "()Ljava/io/ObjectStreamClass;", AccessFlags = 4)]
				protected internal virtual global::Java.IO.ObjectStreamClass ReadClassDescriptor() /* MethodBuilder.Create */ 
				{
						return default(global::Java.IO.ObjectStreamClass);
				}

				/// <summary>
				///  <para>Creates the proxy class that implements the interfaces specified in  <c>interfaceNames </c> .</para> <para> <para>ObjectOutputStream::annotateProxyClass(Class) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the proxy class. </para>
				/// </returns>
				/// <java-name>
				/// resolveProxyClass
				/// </java-name>
				[Dot42.DexImport("resolveProxyClass", "([Ljava/lang/String;)Ljava/lang/Class;", AccessFlags = 4, Signature = "([Ljava/lang/String;)Ljava/lang/Class<*>;")]
				protected internal virtual global::System.Type ResolveProxyClass(string[] interfaceNames) /* MethodBuilder.Create */ 
				{
						return default(global::System.Type);
				}

				/// <summary>
				///  <para>Reads the next object from the source stream.</para> <para> <para>ObjectOutputStream::writeObject(Object) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the object read from the source stream. </para>
				/// </returns>
				/// <java-name>
				/// readObject
				/// </java-name>
				[Dot42.DexImport("readObject", "()Ljava/lang/Object;", AccessFlags = 17)]
				public object ReadObject() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <summary>
				///  <para>Reads the next unshared object from the source stream.</para> <para> <para>ObjectOutputStream::writeUnshared </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the new object read. </para>
				/// </returns>
				/// <java-name>
				/// readUnshared
				/// </java-name>
				[Dot42.DexImport("readUnshared", "()Ljava/lang/Object;", AccessFlags = 1)]
				public virtual object ReadUnshared() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <summary>
				///  <para>Method to be overridden by subclasses to read the next object from the source stream.</para> <para> <para>ObjectOutputStream::writeObjectOverride </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the object read from the source stream. </para>
				/// </returns>
				/// <java-name>
				/// readObjectOverride
				/// </java-name>
				[Dot42.DexImport("readObjectOverride", "()Ljava/lang/Object;", AccessFlags = 4)]
				protected internal virtual object ReadObjectOverride() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <summary>
				///  <para>Reads a short (16 bit) from the source stream.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the short value read from the source stream. </para>
				/// </returns>
				/// <java-name>
				/// readShort
				/// </java-name>
				[Dot42.DexImport("readShort", "()S", AccessFlags = 1)]
				public virtual short ReadShort() /* MethodBuilder.Create */ 
				{
						return default(short);
				}

				/// <summary>
				///  <para>Reads and validates the ObjectInputStream header from the source stream.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// readStreamHeader
				/// </java-name>
				[Dot42.DexImport("readStreamHeader", "()V", AccessFlags = 4)]
				protected internal virtual void ReadStreamHeader() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Reads an unsigned byte (8 bit) from the source stream.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the unsigned byte value read from the source stream packaged in an integer. </para>
				/// </returns>
				/// <java-name>
				/// readUnsignedByte
				/// </java-name>
				[Dot42.DexImport("readUnsignedByte", "()I", AccessFlags = 1)]
				public virtual int ReadUnsignedByte() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Reads an unsigned short (16 bit) from the source stream.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the unsigned short value read from the source stream packaged in an integer. </para>
				/// </returns>
				/// <java-name>
				/// readUnsignedShort
				/// </java-name>
				[Dot42.DexImport("readUnsignedShort", "()I", AccessFlags = 1)]
				public virtual int ReadUnsignedShort() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Reads a string encoded in modified UTF-8 from the source stream.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the string encoded in modified UTF-8 read from the source stream. </para>
				/// </returns>
				/// <java-name>
				/// readUTF
				/// </java-name>
				[Dot42.DexImport("readUTF", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string ReadUTF() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Registers a callback for post-deserialization validation of objects. It allows to perform additional consistency checks before the <c>readObject() </c> method of this class returns its result to the caller. This method can only be called from within the <c>readObject() </c> method of a class that implements "special" deserialization rules. It can be called multiple times. Validation callbacks are then done in order of decreasing priority, defined by <c>priority </c> .</para> <para> <para>ObjectInputValidation::validateObject() </para></para>        
				/// </summary>
				/// <java-name>
				/// registerValidation
				/// </java-name>
				[Dot42.DexImport("registerValidation", "(Ljava/io/ObjectInputValidation;I)V", AccessFlags = 33)]
				public virtual void RegisterValidation(global::Java.IO.IObjectInputValidation @object, int priority) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Loads the Java class corresponding to the class descriptor <c>osClass </c> that has just been read from the source stream.</para> <para> <para>ObjectOutputStream::annotateClass(Class) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>a Class corresponding to the descriptor <c>osClass </c> . </para>
				/// </returns>
				/// <java-name>
				/// resolveClass
				/// </java-name>
				[Dot42.DexImport("resolveClass", "(Ljava/io/ObjectStreamClass;)Ljava/lang/Class;", AccessFlags = 4, Signature = "(Ljava/io/ObjectStreamClass;)Ljava/lang/Class<*>;")]
				protected internal virtual global::System.Type ResolveClass(global::Java.IO.ObjectStreamClass osClass) /* MethodBuilder.Create */ 
				{
						return default(global::System.Type);
				}

				/// <summary>
				///  <para>Allows trusted subclasses to substitute the specified original <c>object </c> with a new object. Object substitution has to be activated first with calling <c>enableResolveObject(true) </c> . This implementation just returns <c>object </c> .</para> <para> <para>enableResolveObject </para> <para>ObjectOutputStream::enableReplaceObject </para> <para>ObjectOutputStream::replaceObject </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the replacement object for <c>object </c> . </para>
				/// </returns>
				/// <java-name>
				/// resolveObject
				/// </java-name>
				[Dot42.DexImport("resolveObject", "(Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 4)]
				protected internal virtual object ResolveObject(object @object) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <summary>
				///  <para>Skips <c>length </c> bytes on the source stream. This method should not be used to skip bytes at any arbitrary position, just when reading primitive data types (int, char etc).</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the number of bytes actually skipped. </para>
				/// </returns>
				/// <java-name>
				/// skipBytes
				/// </java-name>
				[Dot42.DexImport("skipBytes", "(I)I", AccessFlags = 1)]
				public virtual int SkipBytes(int length) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				[Dot42.DexImport("java/io/ObjectInput", "read", "([B)I", AccessFlags = 1025)]
				public override int Read(sbyte[] buffer) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(int);
				}

				[Dot42.DexImport("java/io/ObjectInput", "skip", "(J)J", AccessFlags = 1025)]
				public override long Skip(long byteCount) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(long);
				}

				/// <summary>
				///  <para>GetField is an inner class that provides access to the persistent fields read from the source stream. </para>    
				/// </summary>
				/// <java-name>
				/// java/io/ObjectInputStream$GetField
				/// </java-name>
				[Dot42.DexImport("java/io/ObjectInputStream$GetField", AccessFlags = 1033)]
				public abstract partial class GetField
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public GetField() /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Indicates if the field identified by <c>name </c> is defaulted. This means that it has no value in this stream.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para> <c>true </c> if the field is defaulted, <c>false </c> otherwise. </para>
						/// </returns>
						/// <java-name>
						/// defaulted
						/// </java-name>
						[Dot42.DexImport("defaulted", "(Ljava/lang/String;)Z", AccessFlags = 1025)]
						public abstract bool Defaulted(string name) /* MethodBuilder.Create */ ;

						/// <java-name>
						/// get
						/// </java-name>
						[Dot42.DexImport("get", "(Ljava/lang/String;Z)Z", AccessFlags = 1025)]
						public abstract bool Get(string @string, bool boolean) /* MethodBuilder.Create */ ;

						/// <java-name>
						/// get
						/// </java-name>
						[Dot42.DexImport("get", "(Ljava/lang/String;C)C", AccessFlags = 1025)]
						public abstract char Get(string @string, char @char) /* MethodBuilder.Create */ ;

						/// <java-name>
						/// get
						/// </java-name>
						[Dot42.DexImport("get", "(Ljava/lang/String;B)B", AccessFlags = 1025)]
						public abstract sbyte Get(string @string, sbyte sByte) /* MethodBuilder.Create */ ;

						/// <java-name>
						/// get
						/// </java-name>
						[Dot42.DexImport("get", "(Ljava/lang/String;B)B", AccessFlags = 1025, IgnoreFromJava = true)]
						public abstract byte Get(string @string, byte @byte) /* MethodBuilder.Create */ ;

						/// <java-name>
						/// get
						/// </java-name>
						[Dot42.DexImport("get", "(Ljava/lang/String;S)S", AccessFlags = 1025)]
						public abstract short Get(string @string, short int16) /* MethodBuilder.Create */ ;

						/// <java-name>
						/// get
						/// </java-name>
						[Dot42.DexImport("get", "(Ljava/lang/String;I)I", AccessFlags = 1025)]
						public abstract int Get(string @string, int int32) /* MethodBuilder.Create */ ;

						/// <java-name>
						/// get
						/// </java-name>
						[Dot42.DexImport("get", "(Ljava/lang/String;J)J", AccessFlags = 1025)]
						public abstract long Get(string @string, long int64) /* MethodBuilder.Create */ ;

						/// <java-name>
						/// get
						/// </java-name>
						[Dot42.DexImport("get", "(Ljava/lang/String;F)F", AccessFlags = 1025)]
						public abstract float Get(string @string, float single) /* MethodBuilder.Create */ ;

						/// <java-name>
						/// get
						/// </java-name>
						[Dot42.DexImport("get", "(Ljava/lang/String;D)D", AccessFlags = 1025)]
						public abstract double Get(string @string, double @double) /* MethodBuilder.Create */ ;

						/// <java-name>
						/// get
						/// </java-name>
						[Dot42.DexImport("get", "(Ljava/lang/String;Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1025)]
						public abstract object Get(string @string, object @object) /* MethodBuilder.Create */ ;

						/// <summary>
						///  <para>Gets the ObjectStreamClass that describes a field.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>the descriptor class for a serialized field. </para>
						/// </returns>
						/// <java-name>
						/// getObjectStreamClass
						/// </java-name>
						public abstract global::Java.IO.ObjectStreamClass ObjectStreamClass
						{
								[Dot42.DexImport("getObjectStreamClass", "()Ljava/io/ObjectStreamClass;", AccessFlags = 1025)]
								get;
						}

				}

		}

		/// <summary>
		///  <para>A specialized OutputStream that is able to write (serialize) Java objects as well as primitive data types (int, byte, char etc.). The data can later be loaded using an ObjectInputStream.</para> <para> <para>ObjectInputStream </para> <para>ObjectOutput </para> <para>Serializable </para> <para>Externalizable </para></para>    
		/// </summary>
		/// <java-name>
		/// java/io/ObjectOutputStream
		/// </java-name>
		[Dot42.DexImport("java/io/ObjectOutputStream", AccessFlags = 33)]
		public partial class ObjectOutputStream : global::Java.IO.OutputStream, global::Java.IO.IObjectOutput, global::Java.IO.IObjectStreamConstants
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructs a new <c>ObjectOutputStream </c> . This default constructor can be used by subclasses that do not want to use the public constructor if it allocates unneeded data.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal ObjectOutputStream() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new ObjectOutputStream that writes to the OutputStream  <c>output </c> .</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/io/OutputStream;)V", AccessFlags = 1)]
				public ObjectOutputStream(global::Java.IO.OutputStream output) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Writes optional information for class <c>aClass </c> to the output stream. This optional data can be read when deserializing the class descriptor (ObjectStreamClass) for this class from an input stream. By default, no extra data is saved.</para> <para> <para>ObjectInputStream::resolveClass(ObjectStreamClass) </para></para>        
				/// </summary>
				/// <java-name>
				/// annotateClass
				/// </java-name>
				[Dot42.DexImport("annotateClass", "(Ljava/lang/Class;)V", AccessFlags = 4, Signature = "(Ljava/lang/Class<*>;)V")]
				protected internal virtual void AnnotateClass(global::System.Type aClass) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Writes optional information for a proxy class to the target stream. This optional data can be read when deserializing the proxy class from an input stream. By default, no extra data is saved.</para> <para> <para>ObjectInputStream::resolveProxyClass(String[]) </para></para>        
				/// </summary>
				/// <java-name>
				/// annotateProxyClass
				/// </java-name>
				[Dot42.DexImport("annotateProxyClass", "(Ljava/lang/Class;)V", AccessFlags = 4, Signature = "(Ljava/lang/Class<*>;)V")]
				protected internal virtual void AnnotateProxyClass(global::System.Type aClass) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Closes this stream. Any buffered data is flushed. This implementation closes the target stream.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1)]
				public override void Close() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Default method to write objects to this stream. Serializable fields defined in the object's class and superclasses are written to the output stream.</para> <para> <para>ObjectInputStream::defaultReadObject </para></para>        
				/// </summary>
				/// <java-name>
				/// defaultWriteObject
				/// </java-name>
				[Dot42.DexImport("defaultWriteObject", "()V", AccessFlags = 1)]
				public virtual void DefaultWriteObject() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Writes buffered data to the target stream. This is similar to <c>flush </c> but the flush is not propagated to the target stream.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// drain
				/// </java-name>
				[Dot42.DexImport("drain", "()V", AccessFlags = 4)]
				protected internal virtual void Drain() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Enables object replacement for this stream. By default this is not enabled. Only trusted subclasses (loaded with system class loader) are allowed to change this status.</para> <para> <para>replaceObject </para> <para>ObjectInputStream::enableResolveObject </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the previous setting. </para>
				/// </returns>
				/// <java-name>
				/// enableReplaceObject
				/// </java-name>
				[Dot42.DexImport("enableReplaceObject", "(Z)Z", AccessFlags = 4)]
				protected internal virtual bool EnableReplaceObject(bool enable) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Writes buffered data to the target stream and calls the <c>flush </c> method of the target stream.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// flush
				/// </java-name>
				[Dot42.DexImport("flush", "()V", AccessFlags = 1)]
				public override void Flush() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Gets this stream's <c>PutField </c> object. This object provides access to the persistent fields that are eventually written to the output stream. It is used to transfer the values from the fields of the object that is currently being written to the persistent fields.</para> <para> <para>ObjectInputStream::defaultReadObject </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the PutField object from which persistent fields can be accessed by name. </para>
				/// </returns>
				/// <java-name>
				/// putFields
				/// </java-name>
				[Dot42.DexImport("putFields", "()Ljava/io/ObjectOutputStream$PutField;", AccessFlags = 1)]
				public virtual global::Java.IO.ObjectOutputStream.PutField PutFields() /* MethodBuilder.Create */ 
				{
						return default(global::Java.IO.ObjectOutputStream.PutField);
				}

				/// <summary>
				///  <para>Allows trusted subclasses to substitute the specified original <c>object </c> with a new object. Object substitution has to be activated first with calling <c>enableReplaceObject(true) </c> . This implementation just returns <c>object </c> .</para> <para> <para>enableReplaceObject </para> <para>ObjectInputStream::enableResolveObject </para> <para>ObjectInputStream::resolveObject </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the replacement object for <c>object </c> . </para>
				/// </returns>
				/// <java-name>
				/// replaceObject
				/// </java-name>
				[Dot42.DexImport("replaceObject", "(Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 4)]
				protected internal virtual object ReplaceObject(object @object) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <summary>
				///  <para>Resets the state of this stream. A marker is written to the stream, so that the corresponding input stream will also perform a reset at the same point. Objects previously written are no longer remembered, so they will be written again (instead of a cyclical reference) if found in the object graph.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// reset
				/// </java-name>
				[Dot42.DexImport("reset", "()V", AccessFlags = 1)]
				public virtual void Reset() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the specified protocol version to be used by this stream.</para> <para> <para>ObjectStreamConstants::PROTOCOL_VERSION_1 </para> <para>ObjectStreamConstants::PROTOCOL_VERSION_2 </para></para>        
				/// </summary>
				/// <java-name>
				/// useProtocolVersion
				/// </java-name>
				[Dot42.DexImport("useProtocolVersion", "(I)V", AccessFlags = 1)]
				public virtual void UseProtocolVersion(int version) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Writes a single byte to the target stream. Only the least significant byte of the integer <c>value </c> is written to the stream. Blocks until the byte is actually written.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([B)V", AccessFlags = 1)]
				public override void Write(sbyte[] value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Writes a single byte to the target stream. Only the least significant byte of the integer <c>value </c> is written to the stream. Blocks until the byte is actually written.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public override void Write(byte[] value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Writes <c>count </c> bytes from the byte array <c>buffer </c> starting at offset <c>index </c> to the target stream. Blocks until all bytes are written.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([BII)V", AccessFlags = 1)]
				public override void Write(sbyte[] buffer, int offset, int length) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Writes <c>count </c> bytes from the byte array <c>buffer </c> starting at offset <c>index </c> to the target stream. Blocks until all bytes are written.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([BII)V", AccessFlags = 1, IgnoreFromJava = true)]
				public override void Write(byte[] buffer, int offset, int length) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Writes a single byte to the target stream. Only the least significant byte of the integer <c>value </c> is written to the stream. Blocks until the byte is actually written.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "(I)V", AccessFlags = 1)]
				public override void Write(int value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Writes a boolean to the target stream.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// writeBoolean
				/// </java-name>
				[Dot42.DexImport("writeBoolean", "(Z)V", AccessFlags = 1)]
				public virtual void WriteBoolean(bool value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Writes a byte (8 bit) to the target stream.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// writeByte
				/// </java-name>
				[Dot42.DexImport("writeByte", "(I)V", AccessFlags = 1)]
				public virtual void WriteByte(int value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Writes the string <c>value </c> as a sequence of bytes to the target stream. Only the least significant byte of each character in the string is written.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// writeBytes
				/// </java-name>
				[Dot42.DexImport("writeBytes", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void WriteBytes(string value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Writes a character (16 bit) to the target stream.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// writeChar
				/// </java-name>
				[Dot42.DexImport("writeChar", "(I)V", AccessFlags = 1)]
				public virtual void WriteChar(int value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Writes the string <c>value </c> as a sequence of characters to the target stream.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// writeChars
				/// </java-name>
				[Dot42.DexImport("writeChars", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void WriteChars(string value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Writes a double (64 bit) to the target stream.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// writeDouble
				/// </java-name>
				[Dot42.DexImport("writeDouble", "(D)V", AccessFlags = 1)]
				public virtual void WriteDouble(double value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Writes the fields of the object currently being written to the target stream. The field values are buffered in the currently active <c>PutField </c> object, which can be accessed by calling <c>putFields() </c> .</para> <para> <para>putFields </para></para>        
				/// </summary>
				/// <java-name>
				/// writeFields
				/// </java-name>
				[Dot42.DexImport("writeFields", "()V", AccessFlags = 1)]
				public virtual void WriteFields() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Writes a float (32 bit) to the target stream.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// writeFloat
				/// </java-name>
				[Dot42.DexImport("writeFloat", "(F)V", AccessFlags = 1)]
				public virtual void WriteFloat(float value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Writes an integer (32 bit) to the target stream.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// writeInt
				/// </java-name>
				[Dot42.DexImport("writeInt", "(I)V", AccessFlags = 1)]
				public virtual void WriteInt(int value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Writes a long (64 bit) to the target stream.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// writeLong
				/// </java-name>
				[Dot42.DexImport("writeLong", "(J)V", AccessFlags = 1)]
				public virtual void WriteLong(long value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Writes a class descriptor to the target stream.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// writeClassDescriptor
				/// </java-name>
				[Dot42.DexImport("writeClassDescriptor", "(Ljava/io/ObjectStreamClass;)V", AccessFlags = 4)]
				protected internal virtual void WriteClassDescriptor(global::Java.IO.ObjectStreamClass classDesc) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Writes an object to the target stream.</para> <para> <para>ObjectInputStream::readObject() </para></para>        
				/// </summary>
				/// <java-name>
				/// writeObject
				/// </java-name>
				[Dot42.DexImport("writeObject", "(Ljava/lang/Object;)V", AccessFlags = 17)]
				public void WriteObject(object @object) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Writes an unshared object to the target stream. This method is identical to <c>writeObject </c> , except that it always writes a new object to the stream versus the use of back-referencing for identical objects by  <c>writeObject </c> .</para> <para> <para>ObjectInputStream::readUnshared() </para></para>        
				/// </summary>
				/// <java-name>
				/// writeUnshared
				/// </java-name>
				[Dot42.DexImport("writeUnshared", "(Ljava/lang/Object;)V", AccessFlags = 1)]
				public virtual void WriteUnshared(object @object) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Method to be overridden by subclasses to write <c>object </c> to the target stream.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// writeObjectOverride
				/// </java-name>
				[Dot42.DexImport("writeObjectOverride", "(Ljava/lang/Object;)V", AccessFlags = 4)]
				protected internal virtual void WriteObjectOverride(object @object) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Writes a short (16 bit) to the target stream.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// writeShort
				/// </java-name>
				[Dot42.DexImport("writeShort", "(I)V", AccessFlags = 1)]
				public virtual void WriteShort(int value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Writes the ObjectOutputStream header to the target stream.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// writeStreamHeader
				/// </java-name>
				[Dot42.DexImport("writeStreamHeader", "()V", AccessFlags = 4)]
				protected internal virtual void WriteStreamHeader() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Writes a string encoded with modified UTF-8 to the target stream.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// writeUTF
				/// </java-name>
				[Dot42.DexImport("writeUTF", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void WriteUTF(string value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>PutField is an inner class to provide access to the persistent fields that are written to the target stream. </para>    
				/// </summary>
				/// <java-name>
				/// java/io/ObjectOutputStream$PutField
				/// </java-name>
				[Dot42.DexImport("java/io/ObjectOutputStream$PutField", AccessFlags = 1033)]
				public abstract partial class PutField
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public PutField() /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// put
						/// </java-name>
						[Dot42.DexImport("put", "(Ljava/lang/String;Z)V", AccessFlags = 1025)]
						public abstract void Put(string @string, bool boolean) /* MethodBuilder.Create */ ;

						/// <java-name>
						/// put
						/// </java-name>
						[Dot42.DexImport("put", "(Ljava/lang/String;C)V", AccessFlags = 1025)]
						public abstract void Put(string @string, char @char) /* MethodBuilder.Create */ ;

						/// <java-name>
						/// put
						/// </java-name>
						[Dot42.DexImport("put", "(Ljava/lang/String;B)V", AccessFlags = 1025)]
						public abstract void Put(string @string, sbyte sByte) /* MethodBuilder.Create */ ;

						/// <java-name>
						/// put
						/// </java-name>
						[Dot42.DexImport("put", "(Ljava/lang/String;B)V", AccessFlags = 1025, IgnoreFromJava = true)]
						public abstract void Put(string @string, byte @byte) /* MethodBuilder.Create */ ;

						/// <java-name>
						/// put
						/// </java-name>
						[Dot42.DexImport("put", "(Ljava/lang/String;S)V", AccessFlags = 1025)]
						public abstract void Put(string @string, short int16) /* MethodBuilder.Create */ ;

						/// <java-name>
						/// put
						/// </java-name>
						[Dot42.DexImport("put", "(Ljava/lang/String;I)V", AccessFlags = 1025)]
						public abstract void Put(string @string, int int32) /* MethodBuilder.Create */ ;

						/// <java-name>
						/// put
						/// </java-name>
						[Dot42.DexImport("put", "(Ljava/lang/String;J)V", AccessFlags = 1025)]
						public abstract void Put(string @string, long int64) /* MethodBuilder.Create */ ;

						/// <java-name>
						/// put
						/// </java-name>
						[Dot42.DexImport("put", "(Ljava/lang/String;F)V", AccessFlags = 1025)]
						public abstract void Put(string @string, float single) /* MethodBuilder.Create */ ;

						/// <java-name>
						/// put
						/// </java-name>
						[Dot42.DexImport("put", "(Ljava/lang/String;D)V", AccessFlags = 1025)]
						public abstract void Put(string @string, double @double) /* MethodBuilder.Create */ ;

						/// <java-name>
						/// put
						/// </java-name>
						[Dot42.DexImport("put", "(Ljava/lang/String;Ljava/lang/Object;)V", AccessFlags = 1025)]
						public abstract void Put(string @string, object @object) /* MethodBuilder.Create */ ;

						/// <summary>
						///  <para>Writes the fields to the target stream <c>out </c> .</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>This method is unsafe and may corrupt the target stream. Use ObjectOutputStream::writeFields() instead. </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// write
						/// </java-name>
						[Dot42.DexImport("write", "(Ljava/io/ObjectOutput;)V", AccessFlags = 1025)]
						public abstract void Write(global::Java.IO.IObjectOutput @out) /* MethodBuilder.Create */ ;

				}

		}

		/// <summary>
		///  <para>Represents a descriptor for identifying a class during serialization and deserialization. Information contained in the descriptor includes the name and SUID of the class as well as field names and types. Information inherited from the superclasses is also taken into account.</para> <para> <para>ObjectOutputStream </para> <para>ObjectInputStream </para> <para>java.lang.Class </para></para>    
		/// </summary>
		/// <java-name>
		/// java/io/ObjectStreamClass
		/// </java-name>
		[Dot42.DexImport("java/io/ObjectStreamClass", AccessFlags = 33)]
		public partial class ObjectStreamClass : global::Java.IO.ISerializable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constant indicating that the class has no Serializable fields. </para>        
				/// </summary>
				/// <java-name>
				/// NO_FIELDS
				/// </java-name>
				[Dot42.DexImport("NO_FIELDS", "[Ljava/io/ObjectStreamField;", AccessFlags = 25)]
				public static readonly global::Java.IO.ObjectStreamField[] NO_FIELDS;
				/// <summary>
				///  <para>Constructs a new instance of this class. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal ObjectStreamClass() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns the class (java.lang.Class) for this descriptor.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the class in the local VM that this descriptor represents;  <c>null </c> if there is no corresponding class. </para>
				/// </returns>
				/// <java-name>
				/// forClass
				/// </java-name>
				[Dot42.DexImport("forClass", "()Ljava/lang/Class;", AccessFlags = 1, Signature = "()Ljava/lang/Class<*>;")]
				public virtual global::System.Type ForClass() /* MethodBuilder.Create */ 
				{
						return default(global::System.Type);
				}

				/// <summary>
				///  <para>Gets a field descriptor of the class represented by this class descriptor.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the field identified by <c>name </c> or <c>null </c> if there is no such field. </para>
				/// </returns>
				/// <java-name>
				/// getField
				/// </java-name>
				[Dot42.DexImport("getField", "(Ljava/lang/String;)Ljava/io/ObjectStreamField;", AccessFlags = 1)]
				public virtual global::Java.IO.ObjectStreamField GetField(string name) /* MethodBuilder.Create */ 
				{
						return default(global::Java.IO.ObjectStreamField);
				}

				/// <summary>
				///  <para>Returns the descriptor for a serializable class. Returns null if the class doesn't implement <c>Serializable </c> or <c>Externalizable </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the corresponding descriptor if the class is serializable or externalizable; null otherwise. </para>
				/// </returns>
				/// <java-name>
				/// lookup
				/// </java-name>
				[Dot42.DexImport("lookup", "(Ljava/lang/Class;)Ljava/io/ObjectStreamClass;", AccessFlags = 9, Signature = "(Ljava/lang/Class<*>;)Ljava/io/ObjectStreamClass;")]
				public static global::Java.IO.ObjectStreamClass Lookup(global::System.Type cl) /* MethodBuilder.Create */ 
				{
						return default(global::Java.IO.ObjectStreamClass);
				}

				/// <summary>
				///  <para>Returns the descriptor for any class, whether or not the class implements Serializable or Externalizable.</para> <para> <para>1.6 </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the descriptor </para>
				/// </returns>
				/// <java-name>
				/// lookupAny
				/// </java-name>
				[Dot42.DexImport("lookupAny", "(Ljava/lang/Class;)Ljava/io/ObjectStreamClass;", AccessFlags = 9, Signature = "(Ljava/lang/Class<*>;)Ljava/io/ObjectStreamClass;")]
				public static global::Java.IO.ObjectStreamClass LookupAny(global::System.Type cl) /* MethodBuilder.Create */ 
				{
						return default(global::Java.IO.ObjectStreamClass);
				}

				/// <summary>
				///  <para>Returns a string containing a concise, human-readable description of this descriptor.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a printable representation of this descriptor. </para>
				/// </returns>
				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Returns a collection of field descriptors for the serialized fields of the class represented by this class descriptor.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>an array of field descriptors or an array of length zero if there are no fields in this descriptor's class. </para>
				/// </returns>
				/// <java-name>
				/// getFields
				/// </java-name>
				public virtual global::Java.IO.ObjectStreamField[] Fields
				{
						[Dot42.DexImport("getFields", "()[Ljava/io/ObjectStreamField;", AccessFlags = 1)]
						get{ return default(global::Java.IO.ObjectStreamField[]); }
				}

				/// <summary>
				///  <para>Returns the name of the class represented by this descriptor.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the fully qualified name of the class this descriptor represents. </para>
				/// </returns>
				/// <java-name>
				/// getName
				/// </java-name>
				public virtual string Name
				{
						[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>Returns the Serial Version User ID of the class represented by this descriptor.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the SUID for the class represented by this descriptor. </para>
				/// </returns>
				/// <java-name>
				/// getSerialVersionUID
				/// </java-name>
				public virtual long SerialVersionUID
				{
						[Dot42.DexImport("getSerialVersionUID", "()J", AccessFlags = 1)]
						get{ return default(long); }
				}

		}

		/// <summary>
		///  <para>Signals some sort of problem during either serialization or deserialization of objects. This is actually the superclass of several other, more specific exception classes.</para> <para> <para>InvalidObjectException </para> <para>NotActiveException </para> <para>NotSerializableException </para> <para>OptionalDataException </para> <para>StreamCorruptedException </para> <para>WriteAbortedException </para></para>    
		/// </summary>
		/// <java-name>
		/// java/io/ObjectStreamException
		/// </java-name>
		[Dot42.DexImport("java/io/ObjectStreamException", AccessFlags = 1057)]
		public abstract partial class ObjectStreamException : global::System.IO.IOException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructs a new <c>ObjectStreamException </c> with its stack trace filled in. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal ObjectStreamException() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new <c>ObjectStreamException </c> with its stack trace and detail message filled in.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 4)]
				protected internal ObjectStreamException(string detailMessage) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>Describes a field for the purpose of serialization. Classes can define the collection of fields that are serialized, which may be different from the set of all declared fields.</para> <para> <para>ObjectOutputStream::writeFields() </para> <para>ObjectInputStream::readFields() </para></para>    
		/// </summary>
		/// <java-name>
		/// java/io/ObjectStreamField
		/// </java-name>
		[Dot42.DexImport("java/io/ObjectStreamField", AccessFlags = 33, Signature = "Ljava/lang/Object;Ljava/lang/Comparable<Ljava/lang/Object;>;")]
		public partial class ObjectStreamField : global::System.IComparable<object>
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Class;)V", AccessFlags = 1, Signature = "(Ljava/lang/String;Ljava/lang/Class<*>;)V")]
				public ObjectStreamField(string @string, global::System.Type type) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs an ObjectStreamField with the specified name, type and the indication if it is unshared.</para> <para> <para>ObjectOutputStream::writeUnshared(Object) </para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Class;Z)V", AccessFlags = 1, Signature = "(Ljava/lang/String;Ljava/lang/Class<*>;Z)V")]
				public ObjectStreamField(string name, global::System.Type cl, bool unshared) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Compares this field descriptor to the specified one. Checks first if one of the compared fields has a primitive type and the other one not. If so, the field with the primitive type is considered to be "smaller". If both fields are equal, their names are compared.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>-1 if this field is "smaller" than field <c>o </c> , 0 if both fields are equal; 1 if this field is "greater" than field <c>o </c> . </para>
				/// </returns>
				/// <java-name>
				/// compareTo
				/// </java-name>
				[Dot42.DexImport("compareTo", "(Ljava/lang/Object;)I", AccessFlags = 1)]
				public virtual int CompareTo(object o) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Sets this field's offset in the object.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setOffset
				/// </java-name>
				[Dot42.DexImport("setOffset", "(I)V", AccessFlags = 4)]
				protected internal virtual void SetOffset(int newValue) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns a string containing a concise, human-readable description of this field descriptor.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a printable representation of this descriptor. </para>
				/// </returns>
				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ObjectStreamField() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Gets the name of this field.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the field's name. </para>
				/// </returns>
				/// <java-name>
				/// getName
				/// </java-name>
				public virtual string Name
				{
						[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>Gets the offset of this field in the object.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>this field's offset. </para>
				/// </returns>
				/// <java-name>
				/// getOffset
				/// </java-name>
				public virtual int Offset
				{
						[Dot42.DexImport("getOffset", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Gets the type of this field.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a <c>Class </c> object representing the type of the field. </para>
				/// </returns>
				/// <java-name>
				/// getType
				/// </java-name>
				public virtual global::System.Type Type
				{
						[Dot42.DexImport("getType", "()Ljava/lang/Class;", AccessFlags = 1, Signature = "()Ljava/lang/Class<*>;")]
						get{ return default(global::System.Type); }
				}

				/// <summary>
				///  <para>Gets a character code for the type of this field. The following codes are used:</para> <para> <pre>
				/// B     byte
				/// C     char
				/// D     double
				/// F     float
				/// I     int
				/// J     long
				/// L     class or interface
				/// S     short
				/// Z     boolean
				/// [     array
				/// </pre></para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the field's type code. </para>
				/// </returns>
				/// <java-name>
				/// getTypeCode
				/// </java-name>
				public virtual char TypeCode
				{
						[Dot42.DexImport("getTypeCode", "()C", AccessFlags = 1)]
						get{ return default(char); }
				}

				/// <summary>
				///  <para>Gets the type signature used by the VM to represent the type of this field.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the signature of this field's class or <c>null </c> if this field's type is primitive. </para>
				/// </returns>
				/// <java-name>
				/// getTypeString
				/// </java-name>
				public virtual string TypeString
				{
						[Dot42.DexImport("getTypeString", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>Indicates whether this field's type is a primitive type.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if this field's type is primitive; <c>false </c> if the type of this field is a regular class. </para>
				/// </returns>
				/// <java-name>
				/// isPrimitive
				/// </java-name>
				public virtual bool IsPrimitive
				{
						[Dot42.DexImport("isPrimitive", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Indicates whether this field is unshared.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if this field is unshared, <c>false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isUnshared
				/// </java-name>
				public virtual bool IsUnshared
				{
						[Dot42.DexImport("isUnshared", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

		}

		/// <summary>
		///  <para>Signals that the ObjectInputStream class encountered a primitive type ( <c>int </c> , <c>char </c> etc.) instead of an object instance in the input stream.</para> <para> <para>ObjectInputStream::available() </para> <para>ObjectInputStream::readObject() </para> <para>ObjectInputStream::skipBytes(int) </para></para>    
		/// </summary>
		/// <java-name>
		/// java/io/OptionalDataException
		/// </java-name>
		[Dot42.DexImport("java/io/OptionalDataException", AccessFlags = 33)]
		public partial class OptionalDataException : global::Java.IO.ObjectStreamException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para> <c>true </c> indicates that there is no more primitive data available. </para>        
				/// </summary>
				/// <java-name>
				/// eof
				/// </java-name>
				[Dot42.DexImport("eof", "Z", AccessFlags = 1)]
				public bool Eof;
				/// <summary>
				///  <para>The number of bytes of primitive data (int, char, long etc.) that are available. </para>        
				/// </summary>
				/// <java-name>
				/// length
				/// </java-name>
				[Dot42.DexImport("length", "I", AccessFlags = 1)]
				public int Length;
				/// <summary>
				///  <para>Constructs a new <c>OptionalDataException </c> with its stack trace filled in. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal OptionalDataException() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>A writable sink for bytes.</para> <para>Most clients will use output streams that write data to the file system (FileOutputStream), the network (java.net.Socket#getOutputStream()/java.net.HttpURLConnection#getOutputStream()), or to an in-memory byte array (ByteArrayOutputStream).</para> <para>Use OutputStreamWriter to adapt a byte stream like this one into a character stream.</para> <para>Most clients should wrap their output stream with BufferedOutputStream. Callers that do only bulk writes may omit buffering.</para> <para> <h3>Subclassing OutputStream</h3></para> <para>Subclasses that decorate another output stream should consider subclassing FilterOutputStream, which delegates all calls to the target output stream.</para> <para>All output stream subclasses should override  <b>both</b> write(int) and write(byte[],int,int). The three argument overload is necessary for bulk access to the data. This is much more efficient than byte-by-byte access.</para> <para> <para>InputStream </para></para>    
		/// </summary>
		/// <java-name>
		/// java/io/OutputStream
		/// </java-name>
		[Dot42.DexImport("java/io/OutputStream", AccessFlags = 1057)]
		public abstract partial class OutputStream : global::Java.IO.ICloseable, global::Java.IO.IFlushable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Default constructor. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public OutputStream() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Closes this stream. Implementations of this method should free any resources used by the stream. This implementation does nothing.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1)]
				public virtual void Close() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Flushes this stream. Implementations of this method should ensure that any buffered data is written out. This implementation does nothing.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// flush
				/// </java-name>
				[Dot42.DexImport("flush", "()V", AccessFlags = 1)]
				public virtual void Flush() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Writes a single byte to this stream. Only the least significant byte of the integer <c>oneByte </c> is written to the stream.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([B)V", AccessFlags = 1)]
				public virtual void Write(sbyte[] oneByte) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Writes a single byte to this stream. Only the least significant byte of the integer <c>oneByte </c> is written to the stream.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual void Write(byte[] oneByte) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Writes <c>count </c> bytes from the byte array <c>buffer </c> starting at position <c>offset </c> to this stream.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([BII)V", AccessFlags = 1)]
				public virtual void Write(sbyte[] buffer, int offset, int count) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Writes <c>count </c> bytes from the byte array <c>buffer </c> starting at position <c>offset </c> to this stream.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([BII)V", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual void Write(byte[] buffer, int offset, int count) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Writes a single byte to this stream. Only the least significant byte of the integer <c>oneByte </c> is written to the stream.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "(I)V", AccessFlags = 1025)]
				public abstract void Write(int oneByte) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		///  <para>A class for turning a character stream into a byte stream. Data written to the target input stream is converted into bytes by either a default or a provided character converter. The default encoding is taken from the "file.encoding" system property. <c>OutputStreamWriter </c> contains a buffer of bytes to be written to target stream and converts these into characters as needed. The buffer size is 8K.</para> <para> <para>InputStreamReader </para></para>    
		/// </summary>
		/// <java-name>
		/// java/io/OutputStreamWriter
		/// </java-name>
		[Dot42.DexImport("java/io/OutputStreamWriter", AccessFlags = 33)]
		public partial class OutputStreamWriter : global::Java.IO.Writer
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructs a new OutputStreamWriter using <c>out </c> as the target stream to write converted characters to. The default character encoding is used.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/io/OutputStream;)V", AccessFlags = 1)]
				public OutputStreamWriter(global::Java.IO.OutputStream @out) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new OutputStreamWriter using <c>out </c> as the target stream to write converted characters to and <c>cs </c> as the character encoding.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/io/OutputStream;Ljava/lang/String;)V", AccessFlags = 1)]
				public OutputStreamWriter(global::Java.IO.OutputStream @out, string cs) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new OutputStreamWriter using <c>out </c> as the target stream to write converted characters to and <c>cs </c> as the character encoding.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/io/OutputStream;Ljava/nio/charset/Charset;)V", AccessFlags = 1)]
				public OutputStreamWriter(global::Java.IO.OutputStream @out, global::Java.Nio.Charset.Charset cs) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new OutputStreamWriter using <c>out </c> as the target stream to write converted characters to and <c>cs </c> as the character encoding.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/io/OutputStream;Ljava/nio/charset/CharsetEncoder;)V", AccessFlags = 1)]
				public OutputStreamWriter(global::Java.IO.OutputStream @out, global::Java.Nio.Charset.CharsetEncoder cs) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Closes this writer. This implementation flushes the buffer as well as the target stream. The target stream is then closed and the resources for the buffer and converter are released.</para> <para>Only the first invocation of this method has any effect. Subsequent calls do nothing.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1)]
				public override void Close() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Flushes this writer. This implementation ensures that all buffered bytes are written to the target stream. After writing the bytes, the target stream is flushed as well.</para> <para></para>        
				/// </summary>
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
				[Dot42.DexImport("write", "([CII)V", AccessFlags = 1)]
				public override void Write(char[] @char, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Writes the character <c>oneChar </c> to this writer. The lowest two bytes of the integer <c>oneChar </c> are immediately converted to bytes by the character converter and stored in a local buffer. If the buffer gets full by converting this character, this writer is flushed.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "(I)V", AccessFlags = 1)]
				public override void Write(int oneChar) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "(Ljava/lang/String;II)V", AccessFlags = 1)]
				public override void Write(string @string, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal OutputStreamWriter() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Returns the canonical name of the encoding used by this writer to convert characters to bytes, or null if this writer has been closed. Most callers should probably keep track of the String or Charset they passed in; this method may not return the same name. </para>        
				/// </summary>
				/// <java-name>
				/// getEncoding
				/// </java-name>
				public virtual string Encoding
				{
						[Dot42.DexImport("getEncoding", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

		}

		/// <summary>
		///  <para>Receives information from a communications pipe. When two threads want to pass data back and forth, one creates a piped output stream and the other one creates a piped input stream.</para> <para> <para>PipedOutputStream </para></para>    
		/// </summary>
		/// <java-name>
		/// java/io/PipedInputStream
		/// </java-name>
		[Dot42.DexImport("java/io/PipedInputStream", AccessFlags = 33)]
		public partial class PipedInputStream : global::Java.IO.InputStream
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>The circular buffer through which data is passed. Data is read from the range <c>[out, in) </c> and written to the range <c>[in, out) </c> . Data in the buffer is either sequential:  <pre>
				///     { - - - X X X X X X X - - - - - }
				///             ^             ^
				///             |             |
				///            out           in</pre> ...or wrapped around the buffer's end:  <pre>
				///     { X X X X - - - - - - - - X X X }
				///               ^               ^
				///               |               |
				///              in              out</pre> When the buffer is empty, <c>in == -1 </c> . Reading when the buffer is empty will block until data is available. When the buffer is full,  <c>in == out </c> . Writing when the buffer is full will block until free space is available. </para>        
				/// </summary>
				/// <java-name>
				/// buffer
				/// </java-name>
				[Dot42.DexImport("buffer", "[B", AccessFlags = 4)]
				protected internal sbyte[] Buffer;
				/// <summary>
				///  <para>The index in <c>buffer </c> where the next byte will be written. </para>        
				/// </summary>
				/// <java-name>
				/// in
				/// </java-name>
				[Dot42.DexImport("in", "I", AccessFlags = 4)]
				protected internal int In;
				/// <summary>
				///  <para>The index in <c>buffer </c> where the next byte will be read. </para>        
				/// </summary>
				/// <java-name>
				/// out
				/// </java-name>
				[Dot42.DexImport("out", "I", AccessFlags = 4)]
				protected internal int Out;
				/// <summary>
				///  <para>The size of the default pipe in bytes. </para>        
				/// </summary>
				/// <java-name>
				/// PIPE_SIZE
				/// </java-name>
				[Dot42.DexImport("PIPE_SIZE", "I", AccessFlags = 28)]
				protected internal const int PIPE_SIZE = 1024;
				/// <summary>
				///  <para>Constructs a new unconnected <c>PipedInputStream </c> . The resulting stream must be connected to a PipedOutputStream before data may be read from it. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public PipedInputStream() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new <c>PipedInputStream </c> connected to the PipedOutputStream <c>out </c> . Any data written to the output stream can be read from the this input stream.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/io/PipedOutputStream;)V", AccessFlags = 1)]
				public PipedInputStream(global::Java.IO.PipedOutputStream @out) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new <c>PipedInputStream </c> connected to the PipedOutputStream <c>out </c> . Any data written to the output stream can be read from the this input stream.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public PipedInputStream(int @out) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new <c>PipedInputStream </c> connected to the given <c>PipedOutputStream </c> , with the given buffer size. Any data written to the output stream can be read from this input stream.</para> <para> <para>1.6 </para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/io/PipedOutputStream;I)V", AccessFlags = 1)]
				public PipedInputStream(global::Java.IO.PipedOutputStream @out, int pipeSize) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Unlike most streams, <c>PipedInputStream </c> returns 0 rather than throwing  <c>IOException </c> if the stream has been closed. Unconnected and broken pipes also return 0.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// available
				/// </java-name>
				[Dot42.DexImport("available", "()I", AccessFlags = 33)]
				public override int Available() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Closes this stream. This implementation releases the buffer used for the pipe and notifies all threads waiting to read or write.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 33)]
				public override void Close() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Connects this <c>PipedInputStream </c> to a PipedOutputStream. Any data written to the output stream becomes readable in this input stream.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// connect
				/// </java-name>
				[Dot42.DexImport("connect", "(Ljava/io/PipedOutputStream;)V", AccessFlags = 1)]
				public virtual void Connect(global::Java.IO.PipedOutputStream src) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Reads a single byte from this stream and returns it as an integer in the range from 0 to 255. Returns -1 if the end of this stream has been reached. If there is no data in the pipe, this method blocks until data is available, the end of the stream is detected or an exception is thrown. </para> <para>Separate threads should be used to read from a <c>PipedInputStream </c> and to write to the connected PipedOutputStream. If the same thread is used, a deadlock may occur.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the byte read or -1 if the end of the source stream has been reached. </para>
				/// </returns>
				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "()I", AccessFlags = 33)]
				public override int Read() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Reads up to <c>byteCount </c> bytes from this stream and stores them in the byte array <c>bytes </c> starting at <c>byteOffset </c> . Blocks until at least one byte has been read, the end of the stream is detected or an exception is thrown.</para> <para>Separate threads should be used to read from a <c>PipedInputStream </c> and to write to the connected PipedOutputStream. If the same thread is used, a deadlock may occur.</para> <para>Returns the number of bytes actually read or -1 if the end of the stream has been reached.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([BII)I", AccessFlags = 33)]
				public override int Read(sbyte[] bytes, int byteOffset, int byteCount) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Reads up to <c>byteCount </c> bytes from this stream and stores them in the byte array <c>bytes </c> starting at <c>byteOffset </c> . Blocks until at least one byte has been read, the end of the stream is detected or an exception is thrown.</para> <para>Separate threads should be used to read from a <c>PipedInputStream </c> and to write to the connected PipedOutputStream. If the same thread is used, a deadlock may occur.</para> <para>Returns the number of bytes actually read or -1 if the end of the stream has been reached.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([BII)I", AccessFlags = 33, IgnoreFromJava = true)]
				public override int Read(byte[] bytes, int byteOffset, int byteCount) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Receives a byte and stores it in this stream's <c>buffer </c> . This method is called by PipedOutputStream#write(int). The least significant byte of the integer <c>oneByte </c> is stored at index  <c>in </c> in the <c>buffer </c> . </para> <para>This method blocks as long as <c>buffer </c> is full.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// receive
				/// </java-name>
				[Dot42.DexImport("receive", "(I)V", AccessFlags = 36)]
				protected internal virtual void Receive(int oneByte) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>Places information on a communications pipe. When two threads want to pass data back and forth, one creates a piped output stream and the other one creates a piped input stream.</para> <para> <para>PipedInputStream </para></para>    
		/// </summary>
		/// <java-name>
		/// java/io/PipedOutputStream
		/// </java-name>
		[Dot42.DexImport("java/io/PipedOutputStream", AccessFlags = 33)]
		public partial class PipedOutputStream : global::Java.IO.OutputStream
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructs a new unconnected <c>PipedOutputStream </c> . The resulting stream must be connected to a PipedInputStream before data can be written to it. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public PipedOutputStream() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new <c>PipedOutputStream </c> connected to the PipedInputStream <c>target </c> . Any data written to this stream can be read from the target stream.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/io/PipedInputStream;)V", AccessFlags = 1)]
				public PipedOutputStream(global::Java.IO.PipedInputStream target) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Closes this stream. If this stream is connected to an input stream, the input stream is closed and the pipe is disconnected.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1)]
				public override void Close() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Connects this stream to a PipedInputStream. Any data written to this output stream becomes readable in the input stream.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// connect
				/// </java-name>
				[Dot42.DexImport("connect", "(Ljava/io/PipedInputStream;)V", AccessFlags = 1)]
				public virtual void Connect(global::Java.IO.PipedInputStream stream) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Notifies the readers of this PipedInputStream that bytes can be read. This method does nothing if this stream is not connected.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// flush
				/// </java-name>
				[Dot42.DexImport("flush", "()V", AccessFlags = 1)]
				public override void Flush() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Writes <c>count </c> bytes from the byte array <c>buffer </c> starting at  <c>offset </c> to this stream. The written data can then be read from the connected input stream. </para> <para>Separate threads should be used to write to a <c>PipedOutputStream </c> and to read from the connected PipedInputStream. If the same thread is used, a deadlock may occur.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([BII)V", AccessFlags = 1)]
				public override void Write(sbyte[] buffer, int offset, int count) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Writes <c>count </c> bytes from the byte array <c>buffer </c> starting at  <c>offset </c> to this stream. The written data can then be read from the connected input stream. </para> <para>Separate threads should be used to write to a <c>PipedOutputStream </c> and to read from the connected PipedInputStream. If the same thread is used, a deadlock may occur.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([BII)V", AccessFlags = 1, IgnoreFromJava = true)]
				public override void Write(byte[] buffer, int offset, int count) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Writes a single byte to this stream. Only the least significant byte of the integer <c>oneByte </c> is written. The written byte can then be read from the connected input stream. </para> <para>Separate threads should be used to write to a <c>PipedOutputStream </c> and to read from the connected PipedInputStream. If the same thread is used, a deadlock may occur.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "(I)V", AccessFlags = 1)]
				public override void Write(int oneByte) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>Receives information on a communications pipe. When two threads want to pass data back and forth, one creates a piped writer and the other creates a piped reader.</para> <para> <para>PipedWriter </para></para>    
		/// </summary>
		/// <java-name>
		/// java/io/PipedReader
		/// </java-name>
		[Dot42.DexImport("java/io/PipedReader", AccessFlags = 33)]
		public partial class PipedReader : global::Java.IO.Reader
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructs a new unconnected <c>PipedReader </c> . The resulting reader must be connected to a <c>PipedWriter </c> before data may be read from it. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public PipedReader() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new <c>PipedReader </c> connected to the PipedWriter  <c>out </c> . Any data written to the writer can be read from the this reader.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/io/PipedWriter;)V", AccessFlags = 1)]
				public PipedReader(global::Java.IO.PipedWriter @out) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new <c>PipedReader </c> connected to the PipedWriter  <c>out </c> . Any data written to the writer can be read from the this reader.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public PipedReader(int @out) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new <c>PipedReader </c> connected to the given <c>PipedWriter </c> , with the given buffer size. Any data written to the writer can be read from this reader.</para> <para> <para>1.6 </para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/io/PipedWriter;I)V", AccessFlags = 1)]
				public PipedReader(global::Java.IO.PipedWriter @out, int pipeSize) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Closes this reader. This implementation releases the buffer used for the pipe and notifies all threads waiting to read or write.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 33)]
				public override void Close() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Connects this <c>PipedReader </c> to a PipedWriter. Any data written to the writer becomes readable in this reader.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// connect
				/// </java-name>
				[Dot42.DexImport("connect", "(Ljava/io/PipedWriter;)V", AccessFlags = 1)]
				public virtual void Connect(global::Java.IO.PipedWriter src) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Reads a single character from this reader and returns it as an integer with the two higher-order bytes set to 0. Returns -1 if the end of the reader has been reached. If there is no data in the pipe, this method blocks until data is available, the end of the reader is detected or an exception is thrown. </para> <para>Separate threads should be used to read from a <c>PipedReader </c> and to write to the connected PipedWriter. If the same thread is used, a deadlock may occur.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the character read or -1 if the end of the reader has been reached. </para>
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
				///  <para>Reads up to <c>count </c> characters from this reader and stores them in the character array <c>buffer </c> starting at <c>offset </c> . If there is no data in the pipe, this method blocks until at least one byte has been read, the end of the reader is detected or an exception is thrown.</para> <para>Separate threads should be used to read from a <c>PipedReader </c> and to write to the connected PipedWriter. If the same thread is used, a deadlock may occur.</para> <para>Returns the number of characters read or -1 if the end of the reader has been reached.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([CII)I", AccessFlags = 33)]
				public override int Read(char[] buffer, int offset, int count) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Indicates whether this reader is ready to be read without blocking. Returns <c>true </c> if this reader will not block when <c>read </c> is called, <c>false </c> if unknown or blocking will occur. This implementation returns <c>true </c> if the internal buffer contains characters that can be read.</para> <para> <para>read() </para> <para>read(char[], int, int) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>always <c>false </c> . </para>
				/// </returns>
				/// <java-name>
				/// ready
				/// </java-name>
				[Dot42.DexImport("ready", "()Z", AccessFlags = 33)]
				public override bool Ready() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

		}

		/// <summary>
		///  <para>Places information on a communications pipe. When two threads want to pass data back and forth, one creates a piped writer and the other creates a piped reader.</para> <para> <para>PipedReader </para></para>    
		/// </summary>
		/// <java-name>
		/// java/io/PipedWriter
		/// </java-name>
		[Dot42.DexImport("java/io/PipedWriter", AccessFlags = 33)]
		public partial class PipedWriter : global::Java.IO.Writer
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructs a new unconnected <c>PipedWriter </c> . The resulting writer must be connected to a <c>PipedReader </c> before data may be written to it.</para> <para> <para>PipedReader </para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public PipedWriter() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new <c>PipedWriter </c> connected to <c>destination </c> . Any data written to this writer can be read from <c>destination </c> .</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/io/PipedReader;)V", AccessFlags = 1)]
				public PipedWriter(global::Java.IO.PipedReader destination) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Closes this writer. If a PipedReader is connected to this writer, it is closed as well and the pipe is disconnected. Any data buffered in the reader can still be read.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1)]
				public override void Close() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Connects this <c>PipedWriter </c> to a PipedReader. Any data written to this writer becomes readable in the reader.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// connect
				/// </java-name>
				[Dot42.DexImport("connect", "(Ljava/io/PipedReader;)V", AccessFlags = 1)]
				public virtual void Connect(global::Java.IO.PipedReader reader) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Notifies the readers of this <c>PipedReader </c> that characters can be read. This method does nothing if this Writer is not connected.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// flush
				/// </java-name>
				[Dot42.DexImport("flush", "()V", AccessFlags = 1)]
				public override void Flush() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Writes <c>count </c> characters from the character array <c>buffer </c> starting at offset <c>index </c> to this writer. The written data can then be read from the connected PipedReader instance. </para> <para>Separate threads should be used to write to a <c>PipedWriter </c> and to read from the connected <c>PipedReader </c> . If the same thread is used, a deadlock may occur.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([CII)V", AccessFlags = 1)]
				public override void Write(char[] buffer, int offset, int count) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Writes a single character <c>c </c> to this writer. This character can then be read from the connected PipedReader instance. </para> <para>Separate threads should be used to write to a <c>PipedWriter </c> and to read from the connected <c>PipedReader </c> . If the same thread is used, a deadlock may occur.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "(I)V", AccessFlags = 1)]
				public override void Write(int c) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>Wraps an existing OutputStream and provides convenience methods for writing common data types in a human readable format. This is not to be confused with DataOutputStream which is used for encoding common data types so that they can be read back in. No <c>IOException </c> is thrown by this class. Instead, callers should use checkError() to see if a problem has occurred in this stream. </para>    
		/// </summary>
		/// <java-name>
		/// java/io/PrintStream
		/// </java-name>
		[Dot42.DexImport("java/io/PrintStream", AccessFlags = 33)]
		public partial class PrintStream : global::Java.IO.FilterOutputStream, global::Java.Lang.IAppendable, global::Java.IO.ICloseable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructs a new <c>PrintStream </c> with <c>out </c> as its target stream. By default, the new print stream does not automatically flush its contents to the target stream when a newline is encountered.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/io/OutputStream;)V", AccessFlags = 1)]
				public PrintStream(global::Java.IO.OutputStream @out) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/io/OutputStream;Z)V", AccessFlags = 1)]
				public PrintStream(global::Java.IO.OutputStream outputStream, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new <c>PrintStream </c> with <c>out </c> as its target stream and using the character encoding <c>charsetName </c> while writing. The parameter <c>autoFlush </c> determines if the print stream automatically flushes its contents to the target stream when a newline is encountered.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/io/OutputStream;ZLjava/lang/String;)V", AccessFlags = 1)]
				public PrintStream(global::Java.IO.OutputStream @out, bool autoFlush, string charsetName) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new <c>PrintStream </c> with <c>out </c> as its target stream. By default, the new print stream does not automatically flush its contents to the target stream when a newline is encountered.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/io/File;)V", AccessFlags = 1)]
				public PrintStream(global::Java.IO.File @out) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/io/File;Ljava/lang/String;)V", AccessFlags = 1)]
				public PrintStream(global::Java.IO.File file, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new <c>PrintStream </c> with <c>out </c> as its target stream. By default, the new print stream does not automatically flush its contents to the target stream when a newline is encountered.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public PrintStream(string @out) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public PrintStream(string @string, string string1) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Flushes this stream and returns the value of the error flag.</para> <para> <para>setError() </para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if either an <c>IOException </c> has been thrown previously or if <c>setError() </c> has been called;  <c>false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// checkError
				/// </java-name>
				[Dot42.DexImport("checkError", "()Z", AccessFlags = 1)]
				public virtual bool CheckError() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Sets the error state of the stream to false.  <para>1.6 </para></para>        
				/// </summary>
				/// <java-name>
				/// clearError
				/// </java-name>
				[Dot42.DexImport("clearError", "()V", AccessFlags = 4)]
				protected internal virtual void ClearError() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Closes this print stream. Flushes this stream and then closes the target stream. If an I/O error occurs, this stream's error state is set to  <c>true </c> . </para>        
				/// </summary>
				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 33)]
				public override void Close() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Ensures that all pending data is sent out to the target stream. It also flushes the target stream. If an I/O error occurs, this stream's error state is set to <c>true </c> . </para>        
				/// </summary>
				/// <java-name>
				/// flush
				/// </java-name>
				[Dot42.DexImport("flush", "()V", AccessFlags = 33)]
				public override void Flush() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Formats <c>args </c> according to the format string <c>format </c> , and writes the result to this stream. This method uses the user's default locale. See "&lt;a href="../util/Locale.html::default_locale"&gt;Be wary of the default locale&lt;/a&gt;".</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>this stream. </para>
				/// </returns>
				/// <java-name>
				/// format
				/// </java-name>
				[Dot42.DexImport("format", "(Ljava/lang/String;[Ljava/lang/Object;)Ljava/io/PrintStream;", AccessFlags = 129)]
				public virtual global::Java.IO.PrintStream Format(string format, params object[] args) /* MethodBuilder.Create */ 
				{
						return default(global::Java.IO.PrintStream);
				}

				/// <summary>
				///  <para>Writes a string formatted by an intermediate Formatter to this stream using the specified locale, format string and arguments.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>this stream. </para>
				/// </returns>
				/// <java-name>
				/// format
				/// </java-name>
				[Dot42.DexImport("format", "(Ljava/util/Locale;Ljava/lang/String;[Ljava/lang/Object;)Ljava/io/PrintStream;", AccessFlags = 129)]
				public virtual global::Java.IO.PrintStream Format(global::Java.Util.Locale l, string format, params object[] args) /* MethodBuilder.Create */ 
				{
						return default(global::Java.IO.PrintStream);
				}

				/// <summary>
				///  <para>Prints a formatted string. The behavior of this method is the same as this stream's <c>#format(String, Object...) </c> method.</para> <para>The <c>Locale </c> used is the user's default locale. See "&lt;a href="../util/Locale.html::default_locale"&gt;Be wary of the default locale&lt;/a&gt;".</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>this stream. </para>
				/// </returns>
				/// <java-name>
				/// printf
				/// </java-name>
				[Dot42.DexImport("printf", "(Ljava/lang/String;[Ljava/lang/Object;)Ljava/io/PrintStream;", AccessFlags = 129)]
				public virtual global::Java.IO.PrintStream Printf(string format, params object[] args) /* MethodBuilder.Create */ 
				{
						return default(global::Java.IO.PrintStream);
				}

				/// <summary>
				///  <para>Prints a formatted string. The behavior of this method is the same as this stream's <c>#format(Locale, String, Object...) </c> method.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>this stream. </para>
				/// </returns>
				/// <java-name>
				/// printf
				/// </java-name>
				[Dot42.DexImport("printf", "(Ljava/util/Locale;Ljava/lang/String;[Ljava/lang/Object;)Ljava/io/PrintStream;", AccessFlags = 129)]
				public virtual global::Java.IO.PrintStream Printf(global::Java.Util.Locale l, string format, params object[] args) /* MethodBuilder.Create */ 
				{
						return default(global::Java.IO.PrintStream);
				}

				/// <summary>
				///  <para>Prints the string representation of the int <c>i </c> . </para>        
				/// </summary>
				/// <java-name>
				/// print
				/// </java-name>
				[Dot42.DexImport("print", "([C)V", AccessFlags = 1)]
				public virtual void Print(char[] i) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Prints the string representation of the int <c>i </c> . </para>        
				/// </summary>
				/// <java-name>
				/// print
				/// </java-name>
				[Dot42.DexImport("print", "(C)V", AccessFlags = 1)]
				public virtual void Print(char i) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Prints the string representation of the int <c>i </c> . </para>        
				/// </summary>
				/// <java-name>
				/// print
				/// </java-name>
				[Dot42.DexImport("print", "(D)V", AccessFlags = 1)]
				public virtual void Print(double i) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Prints the string representation of the int <c>i </c> . </para>        
				/// </summary>
				/// <java-name>
				/// print
				/// </java-name>
				[Dot42.DexImport("print", "(F)V", AccessFlags = 1)]
				public virtual void Print(float i) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Prints the string representation of the int <c>i </c> . </para>        
				/// </summary>
				/// <java-name>
				/// print
				/// </java-name>
				[Dot42.DexImport("print", "(I)V", AccessFlags = 1)]
				public virtual void Print(int i) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Prints the string representation of the int <c>i </c> . </para>        
				/// </summary>
				/// <java-name>
				/// print
				/// </java-name>
				[Dot42.DexImport("print", "(J)V", AccessFlags = 1)]
				public virtual void Print(long i) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Prints the string representation of the int <c>i </c> . </para>        
				/// </summary>
				/// <java-name>
				/// print
				/// </java-name>
				[Dot42.DexImport("print", "(Ljava/lang/Object;)V", AccessFlags = 1)]
				public virtual void Print(object i) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Prints the string representation of the int <c>i </c> . </para>        
				/// </summary>
				/// <java-name>
				/// print
				/// </java-name>
				[Dot42.DexImport("print", "(Ljava/lang/String;)V", AccessFlags = 33)]
				public virtual void Print(string i) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Prints the string representation of the int <c>i </c> . </para>        
				/// </summary>
				/// <java-name>
				/// print
				/// </java-name>
				[Dot42.DexImport("print", "(Z)V", AccessFlags = 1)]
				public virtual void Print(bool i) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Prints a newline. </para>        
				/// </summary>
				/// <java-name>
				/// println
				/// </java-name>
				[Dot42.DexImport("println", "()V", AccessFlags = 1)]
				public virtual void Println() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Prints the string representation of the int <c>i </c> followed by a newline. </para>        
				/// </summary>
				/// <java-name>
				/// println
				/// </java-name>
				[Dot42.DexImport("println", "([C)V", AccessFlags = 1)]
				public virtual void Println(char[] i) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Prints the string representation of the int <c>i </c> followed by a newline. </para>        
				/// </summary>
				/// <java-name>
				/// println
				/// </java-name>
				[Dot42.DexImport("println", "(C)V", AccessFlags = 1)]
				public virtual void Println(char i) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Prints the string representation of the int <c>i </c> followed by a newline. </para>        
				/// </summary>
				/// <java-name>
				/// println
				/// </java-name>
				[Dot42.DexImport("println", "(D)V", AccessFlags = 1)]
				public virtual void Println(double i) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Prints the string representation of the int <c>i </c> followed by a newline. </para>        
				/// </summary>
				/// <java-name>
				/// println
				/// </java-name>
				[Dot42.DexImport("println", "(F)V", AccessFlags = 1)]
				public virtual void Println(float i) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Prints the string representation of the int <c>i </c> followed by a newline. </para>        
				/// </summary>
				/// <java-name>
				/// println
				/// </java-name>
				[Dot42.DexImport("println", "(I)V", AccessFlags = 1)]
				public virtual void Println(int i) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Prints the string representation of the int <c>i </c> followed by a newline. </para>        
				/// </summary>
				/// <java-name>
				/// println
				/// </java-name>
				[Dot42.DexImport("println", "(J)V", AccessFlags = 1)]
				public virtual void Println(long i) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Prints the string representation of the int <c>i </c> followed by a newline. </para>        
				/// </summary>
				/// <java-name>
				/// println
				/// </java-name>
				[Dot42.DexImport("println", "(Ljava/lang/Object;)V", AccessFlags = 1)]
				public virtual void Println(object i) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Prints the string representation of the int <c>i </c> followed by a newline. </para>        
				/// </summary>
				/// <java-name>
				/// println
				/// </java-name>
				[Dot42.DexImport("println", "(Ljava/lang/String;)V", AccessFlags = 33)]
				public virtual void Println(string i) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Prints the string representation of the int <c>i </c> followed by a newline. </para>        
				/// </summary>
				/// <java-name>
				/// println
				/// </java-name>
				[Dot42.DexImport("println", "(Z)V", AccessFlags = 1)]
				public virtual void Println(bool i) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the error flag of this print stream to true. </para>        
				/// </summary>
				/// <java-name>
				/// setError
				/// </java-name>
				[Dot42.DexImport("setError", "()V", AccessFlags = 4)]
				protected internal virtual void SetError() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Writes <c>count </c> bytes from <c>buffer </c> starting at <c>offset </c> to the target stream. If autoFlush is set, this stream gets flushed after writing the buffer.</para> <para>This stream's error flag is set to <c>true </c> if this stream is closed or an I/O error occurs.</para> <para> <para>flush() </para></para>        
				/// </summary>
				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([BII)V", AccessFlags = 1)]
				public override void Write(sbyte[] buffer, int offset, int length) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Writes <c>count </c> bytes from <c>buffer </c> starting at <c>offset </c> to the target stream. If autoFlush is set, this stream gets flushed after writing the buffer.</para> <para>This stream's error flag is set to <c>true </c> if this stream is closed or an I/O error occurs.</para> <para> <para>flush() </para></para>        
				/// </summary>
				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([BII)V", AccessFlags = 1, IgnoreFromJava = true)]
				public override void Write(byte[] buffer, int offset, int length) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Writes one byte to the target stream. Only the least significant byte of the integer <c>oneByte </c> is written. This stream is flushed if  <c>oneByte </c> is equal to the character <c>'\n' </c> and this stream is set to autoFlush. </para> <para>This stream's error flag is set to <c>true </c> if it is closed or an I/O error occurs.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "(I)V", AccessFlags = 33)]
				public override void Write(int oneByte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// append
				/// </java-name>
				[Dot42.DexImport("append", "(C)Ljava/io/PrintStream;", AccessFlags = 1)]
				public virtual global::Java.IO.PrintStream Append(char @char) /* MethodBuilder.Create */ 
				{
						return default(global::Java.IO.PrintStream);
				}

				/// <java-name>
				/// append
				/// </java-name>
				[Dot42.DexImport("append", "(Ljava/lang/CharSequence;)Ljava/io/PrintStream;", AccessFlags = 1)]
				public virtual global::Java.IO.PrintStream Append(global::Java.Lang.ICharSequence charSequence) /* MethodBuilder.Create */ 
				{
						return default(global::Java.IO.PrintStream);
				}

				/// <summary>
				///  <para>Appends a subsequence of CharSequence <c>charSequence </c> , or <c>"null" </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>this stream. </para>
				/// </returns>
				/// <java-name>
				/// append
				/// </java-name>
				[Dot42.DexImport("append", "(Ljava/lang/CharSequence;II)Ljava/io/PrintStream;", AccessFlags = 1)]
				public virtual global::Java.IO.PrintStream JavaAppend(global::Java.Lang.ICharSequence charSequence, int start, int end) /* MethodBuilder.Create */ 
				{
						return default(global::Java.IO.PrintStream);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal PrintStream() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				[Dot42.DexImport("java/lang/Appendable", "append", "(C)Ljava/lang/Appendable;", AccessFlags = 1025)]
				global::Java.Lang.IAppendable global::Java.Lang.IAppendable.Append(char c) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Java.Lang.IAppendable);
				}

				[Dot42.DexImport("java/lang/Appendable", "append", "(Ljava/lang/CharSequence;)Ljava/lang/Appendable;", AccessFlags = 1025)]
				global::Java.Lang.IAppendable global::Java.Lang.IAppendable.Append(global::Java.Lang.ICharSequence c) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Java.Lang.IAppendable);
				}

				[Dot42.DexImport("java/lang/Appendable", "append", "(Ljava/lang/CharSequence;II)Ljava/lang/Appendable;", AccessFlags = 1025)]
				global::Java.Lang.IAppendable global::Java.Lang.IAppendable.JavaAppend(global::Java.Lang.ICharSequence csq, int start, int end) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Java.Lang.IAppendable);
				}

		}

		/// <summary>
		///  <para>Wraps either an existing OutputStream or an existing Writer and provides convenience methods for printing common data types in a human readable format. No <c>IOException </c> is thrown by this class. Instead, callers should use checkError() to see if a problem has occurred in this writer. </para>    
		/// </summary>
		/// <java-name>
		/// java/io/PrintWriter
		/// </java-name>
		[Dot42.DexImport("java/io/PrintWriter", AccessFlags = 33)]
		public partial class PrintWriter : global::Java.IO.Writer
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>The writer to print data to. </para>        
				/// </summary>
				/// <java-name>
				/// out
				/// </java-name>
				[Dot42.DexImport("out", "Ljava/io/Writer;", AccessFlags = 4)]
				protected internal global::Java.IO.Writer Out;
				/// <summary>
				///  <para>Constructs a new <c>PrintWriter </c> with <c>out </c> as its target stream. By default, the new print writer does not automatically flush its contents to the target stream when a newline is encountered.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/io/OutputStream;)V", AccessFlags = 1)]
				public PrintWriter(global::Java.IO.OutputStream @out) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/io/OutputStream;Z)V", AccessFlags = 1)]
				public PrintWriter(global::Java.IO.OutputStream outputStream, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new <c>PrintWriter </c> with <c>out </c> as its target stream. By default, the new print writer does not automatically flush its contents to the target stream when a newline is encountered.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/io/Writer;)V", AccessFlags = 1)]
				public PrintWriter(global::Java.IO.Writer @out) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/io/Writer;Z)V", AccessFlags = 1)]
				public PrintWriter(global::Java.IO.Writer writer, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new <c>PrintWriter </c> with <c>out </c> as its target stream. By default, the new print writer does not automatically flush its contents to the target stream when a newline is encountered.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/io/File;)V", AccessFlags = 1)]
				public PrintWriter(global::Java.IO.File @out) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/io/File;Ljava/lang/String;)V", AccessFlags = 1)]
				public PrintWriter(global::Java.IO.File file, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new <c>PrintWriter </c> with <c>out </c> as its target stream. By default, the new print writer does not automatically flush its contents to the target stream when a newline is encountered.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public PrintWriter(string @out) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public PrintWriter(string @string, string string1) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Flushes this writer and returns the value of the error flag.</para> <para> <para>setError() </para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if either an <c>IOException </c> has been thrown previously or if <c>setError() </c> has been called;  <c>false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// checkError
				/// </java-name>
				[Dot42.DexImport("checkError", "()Z", AccessFlags = 1)]
				public virtual bool CheckError() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Sets the error state of the stream to false.  <para>1.6 </para></para>        
				/// </summary>
				/// <java-name>
				/// clearError
				/// </java-name>
				[Dot42.DexImport("clearError", "()V", AccessFlags = 4)]
				protected internal virtual void ClearError() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Closes this print writer. Flushes this writer and then closes the target. If an I/O error occurs, this writer's error flag is set to <c>true </c> . </para>        
				/// </summary>
				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1)]
				public override void Close() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Ensures that all pending data is sent out to the target. It also flushes the target. If an I/O error occurs, this writer's error state is set to <c>true </c> . </para>        
				/// </summary>
				/// <java-name>
				/// flush
				/// </java-name>
				[Dot42.DexImport("flush", "()V", AccessFlags = 1)]
				public override void Flush() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Formats <c>args </c> according to the format string <c>format </c> , and writes the result to this stream. This method uses the user's default locale. See "&lt;a href="../util/Locale.html::default_locale"&gt;Be wary of the default locale&lt;/a&gt;". If automatic flushing is enabled then the buffer is flushed as well.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>this writer. </para>
				/// </returns>
				/// <java-name>
				/// format
				/// </java-name>
				[Dot42.DexImport("format", "(Ljava/lang/String;[Ljava/lang/Object;)Ljava/io/PrintWriter;", AccessFlags = 129)]
				public virtual global::Java.IO.PrintWriter Format(string format, params object[] args) /* MethodBuilder.Create */ 
				{
						return default(global::Java.IO.PrintWriter);
				}

				/// <summary>
				///  <para>Writes a string formatted by an intermediate <c>Formatter </c> to the target using the specified locale, format string and arguments. If automatic flushing is enabled then this writer is flushed.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>this writer. </para>
				/// </returns>
				/// <java-name>
				/// format
				/// </java-name>
				[Dot42.DexImport("format", "(Ljava/util/Locale;Ljava/lang/String;[Ljava/lang/Object;)Ljava/io/PrintWriter;", AccessFlags = 129)]
				public virtual global::Java.IO.PrintWriter Format(global::Java.Util.Locale l, string format, params object[] args) /* MethodBuilder.Create */ 
				{
						return default(global::Java.IO.PrintWriter);
				}

				/// <summary>
				///  <para>Prints a formatted string. The behavior of this method is the same as this writer's <c>#format(String, Object...) </c> method.</para> <para>The <c>Locale </c> used is the user's default locale. See "&lt;a href="../util/Locale.html::default_locale"&gt;Be wary of the default locale&lt;/a&gt;".</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>this writer. </para>
				/// </returns>
				/// <java-name>
				/// printf
				/// </java-name>
				[Dot42.DexImport("printf", "(Ljava/lang/String;[Ljava/lang/Object;)Ljava/io/PrintWriter;", AccessFlags = 129)]
				public virtual global::Java.IO.PrintWriter Printf(string format, params object[] args) /* MethodBuilder.Create */ 
				{
						return default(global::Java.IO.PrintWriter);
				}

				/// <summary>
				///  <para>Prints a formatted string. The behavior of this method is the same as this writer's <c>#format(Locale, String, Object...) </c> method.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>this writer. </para>
				/// </returns>
				/// <java-name>
				/// printf
				/// </java-name>
				[Dot42.DexImport("printf", "(Ljava/util/Locale;Ljava/lang/String;[Ljava/lang/Object;)Ljava/io/PrintWriter;", AccessFlags = 129)]
				public virtual global::Java.IO.PrintWriter Printf(global::Java.Util.Locale l, string format, params object[] args) /* MethodBuilder.Create */ 
				{
						return default(global::Java.IO.PrintWriter);
				}

				/// <summary>
				///  <para>Prints the string representation of the specified integer to the target.</para> <para> <para>print(String) </para></para>        
				/// </summary>
				/// <java-name>
				/// print
				/// </java-name>
				[Dot42.DexImport("print", "([C)V", AccessFlags = 1)]
				public virtual void Print(char[] inum) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Prints the string representation of the specified integer to the target.</para> <para> <para>print(String) </para></para>        
				/// </summary>
				/// <java-name>
				/// print
				/// </java-name>
				[Dot42.DexImport("print", "(C)V", AccessFlags = 1)]
				public virtual void Print(char inum) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Prints the string representation of the specified integer to the target.</para> <para> <para>print(String) </para></para>        
				/// </summary>
				/// <java-name>
				/// print
				/// </java-name>
				[Dot42.DexImport("print", "(D)V", AccessFlags = 1)]
				public virtual void Print(double inum) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Prints the string representation of the specified integer to the target.</para> <para> <para>print(String) </para></para>        
				/// </summary>
				/// <java-name>
				/// print
				/// </java-name>
				[Dot42.DexImport("print", "(F)V", AccessFlags = 1)]
				public virtual void Print(float inum) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Prints the string representation of the specified integer to the target.</para> <para> <para>print(String) </para></para>        
				/// </summary>
				/// <java-name>
				/// print
				/// </java-name>
				[Dot42.DexImport("print", "(I)V", AccessFlags = 1)]
				public virtual void Print(int inum) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Prints the string representation of the specified integer to the target.</para> <para> <para>print(String) </para></para>        
				/// </summary>
				/// <java-name>
				/// print
				/// </java-name>
				[Dot42.DexImport("print", "(J)V", AccessFlags = 1)]
				public virtual void Print(long inum) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Prints the string representation of the specified integer to the target.</para> <para> <para>print(String) </para></para>        
				/// </summary>
				/// <java-name>
				/// print
				/// </java-name>
				[Dot42.DexImport("print", "(Ljava/lang/Object;)V", AccessFlags = 1)]
				public virtual void Print(object inum) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Prints the string representation of the specified integer to the target.</para> <para> <para>print(String) </para></para>        
				/// </summary>
				/// <java-name>
				/// print
				/// </java-name>
				[Dot42.DexImport("print", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void Print(string inum) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Prints the string representation of the specified integer to the target.</para> <para> <para>print(String) </para></para>        
				/// </summary>
				/// <java-name>
				/// print
				/// </java-name>
				[Dot42.DexImport("print", "(Z)V", AccessFlags = 1)]
				public virtual void Print(bool inum) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Prints a newline. Flushes this writer if the autoFlush flag is set to <c>true </c> . </para>        
				/// </summary>
				/// <java-name>
				/// println
				/// </java-name>
				[Dot42.DexImport("println", "()V", AccessFlags = 1)]
				public virtual void Println() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Prints the string representation of the int <c>i </c> followed by a newline. Flushes this writer if the autoFlush flag is set to <c>true </c> . </para>        
				/// </summary>
				/// <java-name>
				/// println
				/// </java-name>
				[Dot42.DexImport("println", "([C)V", AccessFlags = 1)]
				public virtual void Println(char[] i) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Prints the string representation of the int <c>i </c> followed by a newline. Flushes this writer if the autoFlush flag is set to <c>true </c> . </para>        
				/// </summary>
				/// <java-name>
				/// println
				/// </java-name>
				[Dot42.DexImport("println", "(C)V", AccessFlags = 1)]
				public virtual void Println(char i) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Prints the string representation of the int <c>i </c> followed by a newline. Flushes this writer if the autoFlush flag is set to <c>true </c> . </para>        
				/// </summary>
				/// <java-name>
				/// println
				/// </java-name>
				[Dot42.DexImport("println", "(D)V", AccessFlags = 1)]
				public virtual void Println(double i) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Prints the string representation of the int <c>i </c> followed by a newline. Flushes this writer if the autoFlush flag is set to <c>true </c> . </para>        
				/// </summary>
				/// <java-name>
				/// println
				/// </java-name>
				[Dot42.DexImport("println", "(F)V", AccessFlags = 1)]
				public virtual void Println(float i) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Prints the string representation of the int <c>i </c> followed by a newline. Flushes this writer if the autoFlush flag is set to <c>true </c> . </para>        
				/// </summary>
				/// <java-name>
				/// println
				/// </java-name>
				[Dot42.DexImport("println", "(I)V", AccessFlags = 1)]
				public virtual void Println(int i) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Prints the string representation of the int <c>i </c> followed by a newline. Flushes this writer if the autoFlush flag is set to <c>true </c> . </para>        
				/// </summary>
				/// <java-name>
				/// println
				/// </java-name>
				[Dot42.DexImport("println", "(J)V", AccessFlags = 1)]
				public virtual void Println(long i) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Prints the string representation of the int <c>i </c> followed by a newline. Flushes this writer if the autoFlush flag is set to <c>true </c> . </para>        
				/// </summary>
				/// <java-name>
				/// println
				/// </java-name>
				[Dot42.DexImport("println", "(Ljava/lang/Object;)V", AccessFlags = 1)]
				public virtual void Println(object i) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Prints the string representation of the int <c>i </c> followed by a newline. Flushes this writer if the autoFlush flag is set to <c>true </c> . </para>        
				/// </summary>
				/// <java-name>
				/// println
				/// </java-name>
				[Dot42.DexImport("println", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void Println(string i) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Prints the string representation of the int <c>i </c> followed by a newline. Flushes this writer if the autoFlush flag is set to <c>true </c> . </para>        
				/// </summary>
				/// <java-name>
				/// println
				/// </java-name>
				[Dot42.DexImport("println", "(Z)V", AccessFlags = 1)]
				public virtual void Println(bool i) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the error flag of this writer to true. </para>        
				/// </summary>
				/// <java-name>
				/// setError
				/// </java-name>
				[Dot42.DexImport("setError", "()V", AccessFlags = 4)]
				protected internal virtual void SetError() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Writes one character to the target. Only the two least significant bytes of the integer <c>oneChar </c> are written. </para> <para>This writer's error flag is set to <c>true </c> if this writer is closed or an I/O error occurs.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([C)V", AccessFlags = 1)]
				public override void Write(char[] oneChar) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([CII)V", AccessFlags = 1)]
				public override void Write(char[] @char, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Writes one character to the target. Only the two least significant bytes of the integer <c>oneChar </c> are written. </para> <para>This writer's error flag is set to <c>true </c> if this writer is closed or an I/O error occurs.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "(I)V", AccessFlags = 1)]
				public override void Write(int oneChar) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Writes one character to the target. Only the two least significant bytes of the integer <c>oneChar </c> are written. </para> <para>This writer's error flag is set to <c>true </c> if this writer is closed or an I/O error occurs.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public override void Write(string oneChar) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "(Ljava/lang/String;II)V", AccessFlags = 1)]
				public override void Write(string @string, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// append
				/// </java-name>
				[Dot42.DexImport("append", "(C)Ljava/io/PrintWriter;", AccessFlags = 1)]
				public new virtual global::Java.IO.PrintWriter Append(char @char) /* MethodBuilder.Create */ 
				{
						return default(global::Java.IO.PrintWriter);
				}

				/// <java-name>
				/// append
				/// </java-name>
				[Dot42.DexImport("append", "(Ljava/lang/CharSequence;)Ljava/io/PrintWriter;", AccessFlags = 1)]
				public new virtual global::Java.IO.PrintWriter Append(global::Java.Lang.ICharSequence charSequence) /* MethodBuilder.Create */ 
				{
						return default(global::Java.IO.PrintWriter);
				}

				/// <summary>
				///  <para>Appends a subsequence of the character sequence <c>csq </c> to the target. This method works the same way as <c>PrintWriter.print(csq.subsequence(start, end).toString()) </c> . If <c>csq </c> is <c>null </c> , then the specified subsequence of the string "null" will be written to the target.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>this writer. </para>
				/// </returns>
				/// <java-name>
				/// append
				/// </java-name>
				[Dot42.DexImport("append", "(Ljava/lang/CharSequence;II)Ljava/io/PrintWriter;", AccessFlags = 1)]
				public new virtual global::Java.IO.PrintWriter JavaAppend(global::Java.Lang.ICharSequence csq, int start, int end) /* MethodBuilder.Create */ 
				{
						return default(global::Java.IO.PrintWriter);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal PrintWriter() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		///  <para>Wraps an existing InputStream and adds functionality to "push back" bytes that have been read, so that they can be read again. Parsers may find this useful. The number of bytes which may be pushed back can be specified during construction. If the buffer of pushed back bytes is empty, bytes are read from the underlying input stream. </para>    
		/// </summary>
		/// <java-name>
		/// java/io/PushbackInputStream
		/// </java-name>
		[Dot42.DexImport("java/io/PushbackInputStream", AccessFlags = 33)]
		public partial class PushbackInputStream : global::Java.IO.FilterInputStream
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>The buffer that contains pushed-back bytes. </para>        
				/// </summary>
				/// <java-name>
				/// buf
				/// </java-name>
				[Dot42.DexImport("buf", "[B", AccessFlags = 4)]
				protected internal sbyte[] Buf;
				/// <summary>
				///  <para>The current position within <c>buf </c> . A value equal to  <c>buf.length </c> indicates that no bytes are available. A value of 0 indicates that the buffer is full. </para>        
				/// </summary>
				/// <java-name>
				/// pos
				/// </java-name>
				[Dot42.DexImport("pos", "I", AccessFlags = 4)]
				protected internal int Pos;
				/// <summary>
				///  <para>Constructs a new <c>PushbackInputStream </c> with the specified input stream as source. The size of the pushback buffer is set to the default value of 1 byte.</para> <para> <b>Warning:</b> passing a null source creates an invalid  <c>PushbackInputStream </c> . All read operations on such a stream will fail.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/io/InputStream;)V", AccessFlags = 1)]
				public PushbackInputStream(global::Java.IO.InputStream @in) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new <c>PushbackInputStream </c> with <c>in </c> as source input stream. The size of the pushback buffer is set to <c>size </c> .</para> <para> <b>Warning:</b> passing a null source creates an invalid  <c>PushbackInputStream </c> . All read operations on such a stream will fail.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/io/InputStream;I)V", AccessFlags = 1)]
				public PushbackInputStream(global::Java.IO.InputStream @in, int size) /* MethodBuilder.Create */ 
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

				/// <summary>
				///  <para>Closes this stream. This implementation closes the source stream and releases the pushback buffer.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1)]
				public override void Close() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Indicates whether this stream supports the <c>mark(int) </c> and  <c>reset() </c> methods. <c>PushbackInputStream </c> does not support them, so it returns <c>false </c> .</para> <para> <para>mark(int) </para> <para>reset() </para></para>        
				/// </summary>
				/// <returns>
				///  <para>always <c>false </c> . </para>
				/// </returns>
				/// <java-name>
				/// markSupported
				/// </java-name>
				[Dot42.DexImport("markSupported", "()Z", AccessFlags = 1)]
				public override bool MarkSupported() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Reads a single byte from this stream and returns it as an integer in the range from 0 to 255. If the pushback buffer does not contain any available bytes then a byte from the source input stream is returned. Blocks until one byte has been read, the end of the source stream is detected or an exception is thrown.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the byte read or -1 if the end of the source stream has been reached. </para>
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
				///  <para>Reads up to <c>byteCount </c> bytes from this stream and stores them in the byte array <c>buffer </c> starting at <c>byteOffset </c> . Bytes are read from the pushback buffer first, then from the source stream if more bytes are required. Blocks until <c>byteCount </c> bytes have been read, the end of the source stream is detected or an exception is thrown. Returns the number of bytes read, or -1 if the end of the source stream has been reached.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([BII)I", AccessFlags = 1)]
				public override int Read(sbyte[] buffer, int byteOffset, int byteCount) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Reads up to <c>byteCount </c> bytes from this stream and stores them in the byte array <c>buffer </c> starting at <c>byteOffset </c> . Bytes are read from the pushback buffer first, then from the source stream if more bytes are required. Blocks until <c>byteCount </c> bytes have been read, the end of the source stream is detected or an exception is thrown. Returns the number of bytes read, or -1 if the end of the source stream has been reached.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([BII)I", AccessFlags = 1, IgnoreFromJava = true)]
				public override int Read(byte[] buffer, int byteOffset, int byteCount) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Skips <c>byteCount </c> bytes in this stream. This implementation skips bytes in the pushback buffer first and then in the source stream if necessary.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the number of bytes actually skipped. </para>
				/// </returns>
				/// <java-name>
				/// skip
				/// </java-name>
				[Dot42.DexImport("skip", "(J)J", AccessFlags = 1)]
				public override long Skip(long byteCount) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				///  <para>Pushes the specified byte <c>oneByte </c> back to this stream. Only the least significant byte of the integer <c>oneByte </c> is pushed back. This is done in such a way that the next byte read from this stream is  <c>(byte) oneByte </c> . </para> <para>If this stream's internal pushback buffer cannot store the byte, an  <c>IOException </c> is thrown.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// unread
				/// </java-name>
				[Dot42.DexImport("unread", "([B)V", AccessFlags = 1)]
				public virtual void Unread(sbyte[] oneByte) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Pushes the specified byte <c>oneByte </c> back to this stream. Only the least significant byte of the integer <c>oneByte </c> is pushed back. This is done in such a way that the next byte read from this stream is  <c>(byte) oneByte </c> . </para> <para>If this stream's internal pushback buffer cannot store the byte, an  <c>IOException </c> is thrown.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// unread
				/// </java-name>
				[Dot42.DexImport("unread", "([B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual void Unread(byte[] oneByte) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Pushes a subset of the bytes in <c>buffer </c> back to this stream. The subset is defined by the start position <c>offset </c> within  <c>buffer </c> and the number of bytes specified by <c>length </c> . The bytes are pushed back in such a way that the next byte read from this stream is <c>buffer[offset] </c> , then <c>buffer[1] </c> and so on. </para> <para>If this stream's internal pushback buffer cannot store the selected subset of <c>buffer </c> , an <c>IOException </c> is thrown. Parts of  <c>buffer </c> may have already been copied to the pushback buffer when the exception is thrown.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// unread
				/// </java-name>
				[Dot42.DexImport("unread", "([BII)V", AccessFlags = 1)]
				public virtual void Unread(sbyte[] buffer, int offset, int length) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Pushes a subset of the bytes in <c>buffer </c> back to this stream. The subset is defined by the start position <c>offset </c> within  <c>buffer </c> and the number of bytes specified by <c>length </c> . The bytes are pushed back in such a way that the next byte read from this stream is <c>buffer[offset] </c> , then <c>buffer[1] </c> and so on. </para> <para>If this stream's internal pushback buffer cannot store the selected subset of <c>buffer </c> , an <c>IOException </c> is thrown. Parts of  <c>buffer </c> may have already been copied to the pushback buffer when the exception is thrown.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// unread
				/// </java-name>
				[Dot42.DexImport("unread", "([BII)V", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual void Unread(byte[] buffer, int offset, int length) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Pushes the specified byte <c>oneByte </c> back to this stream. Only the least significant byte of the integer <c>oneByte </c> is pushed back. This is done in such a way that the next byte read from this stream is  <c>(byte) oneByte </c> . </para> <para>If this stream's internal pushback buffer cannot store the byte, an  <c>IOException </c> is thrown.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// unread
				/// </java-name>
				[Dot42.DexImport("unread", "(I)V", AccessFlags = 1)]
				public virtual void Unread(int oneByte) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Marks the current position in this stream. Setting a mark is not supported in this class; this implementation does nothing.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// mark
				/// </java-name>
				[Dot42.DexImport("mark", "(I)V", AccessFlags = 1)]
				public override void Mark(int readlimit) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Resets this stream to the last marked position. Resetting the stream is not supported in this class; this implementation always throws an  <c>IOException </c> .</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// reset
				/// </java-name>
				[Dot42.DexImport("reset", "()V", AccessFlags = 1)]
				public override void Reset() /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal PushbackInputStream() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		///  <para>Wraps an existing Reader and adds functionality to "push back" characters that have been read, so that they can be read again. Parsers may find this useful. The number of characters which may be pushed back can be specified during construction. If the buffer of pushed back bytes is empty, characters are read from the underlying reader. </para>    
		/// </summary>
		/// <java-name>
		/// java/io/PushbackReader
		/// </java-name>
		[Dot42.DexImport("java/io/PushbackReader", AccessFlags = 33)]
		public partial class PushbackReader : global::Java.IO.FilterReader
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructs a new <c>PushbackReader </c> with the specified reader as source. The size of the pushback buffer is set to the default value of 1 character.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/io/Reader;)V", AccessFlags = 1)]
				public PushbackReader(global::Java.IO.Reader @in) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new <c>PushbackReader </c> with <c>in </c> as source reader. The size of the pushback buffer is set to <c>size </c> .</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/io/Reader;I)V", AccessFlags = 1)]
				public PushbackReader(global::Java.IO.Reader @in, int size) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Closes this reader. This implementation closes the source reader and releases the pushback buffer.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1)]
				public override void Close() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Marks the current position in this stream. Setting a mark is not supported in this class; this implementation always throws an  <c>IOException </c> .</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// mark
				/// </java-name>
				[Dot42.DexImport("mark", "(I)V", AccessFlags = 1)]
				public override void Mark(int readAheadLimit) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Indicates whether this reader supports the <c>mark(int) </c> and  <c>reset() </c> methods. <c>PushbackReader </c> does not support them, so it returns <c>false </c> .</para> <para> <para>mark(int) </para> <para>reset() </para></para>        
				/// </summary>
				/// <returns>
				///  <para>always <c>false </c> . </para>
				/// </returns>
				/// <java-name>
				/// markSupported
				/// </java-name>
				[Dot42.DexImport("markSupported", "()Z", AccessFlags = 1)]
				public override bool MarkSupported() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Reads a single character from this reader and returns it as an integer with the two higher-order bytes set to 0. Returns -1 if the end of the reader has been reached. If the pushback buffer does not contain any available characters then a character from the source reader is returned. Blocks until one character has been read, the end of the source reader is detected or an exception is thrown.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the character read or -1 if the end of the source reader has been reached. </para>
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
				///  <para>Reads up to <c>count </c> characters from this reader and stores them in character array <c>buffer </c> starting at <c>offset </c> . Characters are read from the pushback buffer first, then from the source reader if more bytes are required. Blocks until <c>count </c> characters have been read, the end of the source reader is detected or an exception is thrown. Returns the number of bytes read or -1 if the end of the source reader has been reached.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([CII)I", AccessFlags = 1)]
				public override int Read(char[] buffer, int offset, int count) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Indicates whether this reader is ready to be read without blocking. Returns <c>true </c> if this reader will not block when <c>read </c> is called, <c>false </c> if unknown or blocking will occur.</para> <para> <para>read() </para> <para>read(char[], int, int) </para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if the receiver will not block when  <c>read() </c> is called, <c>false </c> if unknown or blocking will occur. </para>
				/// </returns>
				/// <java-name>
				/// ready
				/// </java-name>
				[Dot42.DexImport("ready", "()Z", AccessFlags = 1)]
				public override bool Ready() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Resets this reader to the last marked position. Resetting the reader is not supported in this class; this implementation always throws an  <c>IOException </c> .</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// reset
				/// </java-name>
				[Dot42.DexImport("reset", "()V", AccessFlags = 1)]
				public override void Reset() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Pushes the specified character <c>oneChar </c> back to this reader. This is done in such a way that the next character read from this reader is  <c>(char) oneChar </c> . </para> <para>If this reader's internal pushback buffer cannot store the character, an  <c>IOException </c> is thrown.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// unread
				/// </java-name>
				[Dot42.DexImport("unread", "([C)V", AccessFlags = 1)]
				public virtual void Unread(char[] oneChar) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Pushes a subset of the characters in <c>buffer </c> back to this reader. The subset is defined by the start position <c>offset </c> within  <c>buffer </c> and the number of characters specified by <c>length </c> . The bytes are pushed back in such a way that the next byte read from this stream is <c>buffer[offset] </c> , then <c>buffer[1] </c> and so on. </para> <para>If this stream's internal pushback buffer cannot store the selected subset of <c>buffer </c> , an <c>IOException </c> is thrown. Parts of  <c>buffer </c> may have already been copied to the pushback buffer when the exception is thrown.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// unread
				/// </java-name>
				[Dot42.DexImport("unread", "([CII)V", AccessFlags = 1)]
				public virtual void Unread(char[] buffer, int offset, int length) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Pushes the specified character <c>oneChar </c> back to this reader. This is done in such a way that the next character read from this reader is  <c>(char) oneChar </c> . </para> <para>If this reader's internal pushback buffer cannot store the character, an  <c>IOException </c> is thrown.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// unread
				/// </java-name>
				[Dot42.DexImport("unread", "(I)V", AccessFlags = 1)]
				public virtual void Unread(int oneChar) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Skips <c>charCount </c> characters in this reader. This implementation skips characters in the pushback buffer first and then in the source reader if necessary.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the number of characters actually skipped. </para>
				/// </returns>
				/// <java-name>
				/// skip
				/// </java-name>
				[Dot42.DexImport("skip", "(J)J", AccessFlags = 1)]
				public override long Skip(long charCount) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal PushbackReader() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		///  <para>Allows reading from and writing to a file in a random-access manner. This is different from the uni-directional sequential access that a FileInputStream or FileOutputStream provides. If the file is opened in read/write mode, write operations are available as well. The position of the next read or write operation can be moved forwards and backwards after every operation. </para>    
		/// </summary>
		/// <java-name>
		/// java/io/RandomAccessFile
		/// </java-name>
		[Dot42.DexImport("java/io/RandomAccessFile", AccessFlags = 33)]
		public partial class RandomAccessFile : global::Java.IO.IDataInput, global::Java.IO.IDataOutput, global::Java.IO.ICloseable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/io/File;Ljava/lang/String;)V", AccessFlags = 1)]
				public RandomAccessFile(global::Java.IO.File file, string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public RandomAccessFile(string @string, string string1) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Closes this file.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1)]
				public virtual void Close() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// finalize
				/// </java-name>
				[Dot42.DexImport("finalize", "()V", AccessFlags = 4)]
				extern ~RandomAccessFile() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns the length of this file in bytes.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the file's length in bytes. </para>
				/// </returns>
				/// <java-name>
				/// length
				/// </java-name>
				[Dot42.DexImport("length", "()J", AccessFlags = 1)]
				public virtual long Length() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				///  <para>Reads a single byte from the current position in this file and returns it as an integer in the range from 0 to 255. Returns -1 if the end of the file has been reached. Blocks until one byte has been read, the end of the file is detected, or an exception is thrown.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the byte read or -1 if the end of the file has been reached. </para>
				/// </returns>
				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "()I", AccessFlags = 1)]
				public virtual int Read() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Reads bytes from the current position in this file and stores them in the byte array <c>buffer </c> . The maximum number of bytes read corresponds to the size of <c>buffer </c> . Blocks until at least one byte has been read, the end of the file is detected, or an exception is thrown. Returns the number of bytes actually read or -1 if the end of the file has been reached. See also readFully.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([B)I", AccessFlags = 1)]
				public virtual int Read(sbyte[] buffer) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Reads bytes from the current position in this file and stores them in the byte array <c>buffer </c> . The maximum number of bytes read corresponds to the size of <c>buffer </c> . Blocks until at least one byte has been read, the end of the file is detected, or an exception is thrown. Returns the number of bytes actually read or -1 if the end of the file has been reached. See also readFully.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([B)I", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual int Read(byte[] buffer) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Reads up to <c>byteCount </c> bytes from the current position in this file and stores them in the byte array <c>buffer </c> starting at <c>byteOffset </c> . Blocks until at least one byte has been read, the end of the file is detected, or an exception is thrown. Returns the number of bytes actually read or -1 if the end of the stream has been reached. See also readFully.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([BII)I", AccessFlags = 1)]
				public virtual int Read(sbyte[] buffer, int byteOffset, int byteCount) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Reads up to <c>byteCount </c> bytes from the current position in this file and stores them in the byte array <c>buffer </c> starting at <c>byteOffset </c> . Blocks until at least one byte has been read, the end of the file is detected, or an exception is thrown. Returns the number of bytes actually read or -1 if the end of the stream has been reached. See also readFully.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([BII)I", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual int Read(byte[] buffer, int byteOffset, int byteCount) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Reads a boolean from the current position in this file. Blocks until one byte has been read, the end of the file is reached or an exception is thrown.</para> <para> <para>writeBoolean(boolean) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the next boolean value from this file. </para>
				/// </returns>
				/// <java-name>
				/// readBoolean
				/// </java-name>
				[Dot42.DexImport("readBoolean", "()Z", AccessFlags = 17)]
				public bool ReadBoolean() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Reads an 8-bit byte from the current position in this file. Blocks until one byte has been read, the end of the file is reached or an exception is thrown.</para> <para> <para>writeBoolean(boolean) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the next signed 8-bit byte value from this file. </para>
				/// </returns>
				/// <java-name>
				/// readByte
				/// </java-name>
				[Dot42.DexImport("readByte", "()B", AccessFlags = 17)]
				public sbyte JavaReadByte() /* MethodBuilder.Create */ 
				{
						return default(sbyte);
				}

				/// <summary>
				///  <para>Reads an 8-bit byte from the current position in this file. Blocks until one byte has been read, the end of the file is reached or an exception is thrown.</para> <para> <para>writeBoolean(boolean) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the next signed 8-bit byte value from this file. </para>
				/// </returns>
				/// <java-name>
				/// readByte
				/// </java-name>
				[Dot42.DexImport("readByte", "()B", AccessFlags = 17, IgnoreFromJava = true)]
				public byte ReadByte() /* MethodBuilder.Create */ 
				{
						return default(byte);
				}

				/// <summary>
				///  <para>Reads a big-endian 16-bit character from the current position in this file. Blocks until two bytes have been read, the end of the file is reached or an exception is thrown.</para> <para> <para>writeChar(int) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the next char value from this file. </para>
				/// </returns>
				/// <java-name>
				/// readChar
				/// </java-name>
				[Dot42.DexImport("readChar", "()C", AccessFlags = 17)]
				public char ReadChar() /* MethodBuilder.Create */ 
				{
						return default(char);
				}

				/// <summary>
				///  <para>Reads a big-endian 64-bit double from the current position in this file. Blocks until eight bytes have been read, the end of the file is reached or an exception is thrown.</para> <para> <para>writeDouble(double) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the next double value from this file. </para>
				/// </returns>
				/// <java-name>
				/// readDouble
				/// </java-name>
				[Dot42.DexImport("readDouble", "()D", AccessFlags = 17)]
				public double ReadDouble() /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <summary>
				///  <para>Reads a big-endian 32-bit float from the current position in this file. Blocks until four bytes have been read, the end of the file is reached or an exception is thrown.</para> <para> <para>writeFloat(float) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the next float value from this file. </para>
				/// </returns>
				/// <java-name>
				/// readFloat
				/// </java-name>
				[Dot42.DexImport("readFloat", "()F", AccessFlags = 17)]
				public float ReadFloat() /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				///  <para>Equivalent to <c>readFully(dst, 0, dst.length); </c> . </para>        
				/// </summary>
				/// <java-name>
				/// readFully
				/// </java-name>
				[Dot42.DexImport("readFully", "([B)V", AccessFlags = 17)]
				public void ReadFully(sbyte[] dst) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Equivalent to <c>readFully(dst, 0, dst.length); </c> . </para>        
				/// </summary>
				/// <java-name>
				/// readFully
				/// </java-name>
				[Dot42.DexImport("readFully", "([B)V", AccessFlags = 17, IgnoreFromJava = true)]
				public void ReadFully(byte[] dst) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Reads <c>byteCount </c> bytes from this stream and stores them in the byte array <c>dst </c> starting at <c>offset </c> . If <c>byteCount </c> is zero, then this method returns without reading any bytes. Otherwise, this method blocks until  <c>byteCount </c> bytes have been read. If insufficient bytes are available,  <c>EOFException </c> is thrown. If an I/O error occurs, <c>IOException </c> is thrown. When an exception is thrown, some bytes may have been consumed from the stream and written into the array.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// readFully
				/// </java-name>
				[Dot42.DexImport("readFully", "([BII)V", AccessFlags = 17)]
				public void ReadFully(sbyte[] dst, int offset, int byteCount) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Reads <c>byteCount </c> bytes from this stream and stores them in the byte array <c>dst </c> starting at <c>offset </c> . If <c>byteCount </c> is zero, then this method returns without reading any bytes. Otherwise, this method blocks until  <c>byteCount </c> bytes have been read. If insufficient bytes are available,  <c>EOFException </c> is thrown. If an I/O error occurs, <c>IOException </c> is thrown. When an exception is thrown, some bytes may have been consumed from the stream and written into the array.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// readFully
				/// </java-name>
				[Dot42.DexImport("readFully", "([BII)V", AccessFlags = 17, IgnoreFromJava = true)]
				public void ReadFully(byte[] dst, int offset, int byteCount) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Reads a big-endian 32-bit integer from the current position in this file. Blocks until four bytes have been read, the end of the file is reached or an exception is thrown.</para> <para> <para>writeInt(int) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the next int value from this file. </para>
				/// </returns>
				/// <java-name>
				/// readInt
				/// </java-name>
				[Dot42.DexImport("readInt", "()I", AccessFlags = 17)]
				public int ReadInt() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Reads a line of text form the current position in this file. A line is represented by zero or more characters followed by <c>'\n' </c> , <c>'\r' </c> , <c>"\r\n" </c> or the end of file marker. The string does not include the line terminating sequence. </para> <para>Blocks until a line terminating sequence has been read, the end of the file is reached or an exception is thrown.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the contents of the line or <c>null </c> if no characters have been read before the end of the file has been reached. </para>
				/// </returns>
				/// <java-name>
				/// readLine
				/// </java-name>
				[Dot42.DexImport("readLine", "()Ljava/lang/String;", AccessFlags = 17)]
				public string ReadLine() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Reads a big-endian 64-bit long from the current position in this file. Blocks until eight bytes have been read, the end of the file is reached or an exception is thrown.</para> <para> <para>writeLong(long) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the next long value from this file. </para>
				/// </returns>
				/// <java-name>
				/// readLong
				/// </java-name>
				[Dot42.DexImport("readLong", "()J", AccessFlags = 17)]
				public long ReadLong() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				///  <para>Reads a big-endian 16-bit short from the current position in this file. Blocks until two bytes have been read, the end of the file is reached or an exception is thrown.</para> <para> <para>writeShort(int) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the next short value from this file. </para>
				/// </returns>
				/// <java-name>
				/// readShort
				/// </java-name>
				[Dot42.DexImport("readShort", "()S", AccessFlags = 17)]
				public short ReadShort() /* MethodBuilder.Create */ 
				{
						return default(short);
				}

				/// <summary>
				///  <para>Reads an unsigned 8-bit byte from the current position in this file and returns it as an integer. Blocks until one byte has been read, the end of the file is reached or an exception is thrown.</para> <para> <para>writeByte(int) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the next unsigned byte value from this file as an int. </para>
				/// </returns>
				/// <java-name>
				/// readUnsignedByte
				/// </java-name>
				[Dot42.DexImport("readUnsignedByte", "()I", AccessFlags = 17)]
				public int ReadUnsignedByte() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Reads an unsigned big-endian 16-bit short from the current position in this file and returns it as an integer. Blocks until two bytes have been read, the end of the file is reached or an exception is thrown.</para> <para> <para>writeShort(int) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the next unsigned short value from this file as an int. </para>
				/// </returns>
				/// <java-name>
				/// readUnsignedShort
				/// </java-name>
				[Dot42.DexImport("readUnsignedShort", "()I", AccessFlags = 17)]
				public int ReadUnsignedShort() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Reads a string that is encoded in modified UTF-8 from this file. The number of bytes that must be read for the complete string is determined by the first two bytes read from the file. Blocks until all required bytes have been read, the end of the file is reached or an exception is thrown.</para> <para> <para>writeUTF(String) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the next string encoded in modified UTF-8 from this file. </para>
				/// </returns>
				/// <java-name>
				/// readUTF
				/// </java-name>
				[Dot42.DexImport("readUTF", "()Ljava/lang/String;", AccessFlags = 17)]
				public string ReadUTF() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Moves this file's file pointer to a new position, from where following  <c>read </c> , <c>write </c> or <c>skip </c> operations are done. The position may be greater than the current length of the file, but the file's length will only change if the moving of the pointer is followed by a <c>write </c> operation.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// seek
				/// </java-name>
				[Dot42.DexImport("seek", "(J)V", AccessFlags = 1)]
				public virtual void Seek(long offset) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the length of this file to <c>newLength </c> . If the current file is smaller, it is expanded but the contents from the previous end of the file to the new end are undefined. The file is truncated if its current size is bigger than <c>newLength </c> . If the current file pointer position is in the truncated part, it is set to the end of the file.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setLength
				/// </java-name>
				[Dot42.DexImport("setLength", "(J)V", AccessFlags = 1)]
				public virtual void SetLength(long newLength) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Skips over <c>count </c> bytes in this file. Less than <c>count </c> bytes are skipped if the end of the file is reached or an exception is thrown during the operation. Nothing is done if <c>count </c> is negative.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the number of bytes actually skipped. </para>
				/// </returns>
				/// <java-name>
				/// skipBytes
				/// </java-name>
				[Dot42.DexImport("skipBytes", "(I)I", AccessFlags = 1)]
				public virtual int SkipBytes(int count) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Writes a byte to this file, starting at the current file pointer. Only the least significant byte of the integer <c>oneByte </c> is written.</para> <para> <para>read() </para></para>        
				/// </summary>
				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([B)V", AccessFlags = 1)]
				public virtual void Write(sbyte[] oneByte) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Writes a byte to this file, starting at the current file pointer. Only the least significant byte of the integer <c>oneByte </c> is written.</para> <para> <para>read() </para></para>        
				/// </summary>
				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual void Write(byte[] oneByte) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Writes <c>byteCount </c> bytes from the byte array <c>buffer </c> to this file, starting at the current file pointer and using <c>byteOffset </c> as the first position within <c>buffer </c> to get bytes.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([BII)V", AccessFlags = 1)]
				public virtual void Write(sbyte[] buffer, int byteOffset, int byteCount) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Writes <c>byteCount </c> bytes from the byte array <c>buffer </c> to this file, starting at the current file pointer and using <c>byteOffset </c> as the first position within <c>buffer </c> to get bytes.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([BII)V", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual void Write(byte[] buffer, int byteOffset, int byteCount) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Writes a byte to this file, starting at the current file pointer. Only the least significant byte of the integer <c>oneByte </c> is written.</para> <para> <para>read() </para></para>        
				/// </summary>
				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "(I)V", AccessFlags = 1)]
				public virtual void Write(int oneByte) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Writes a boolean to this file as a single byte (1 for true, 0 for false), starting at the current file pointer.</para> <para> <para>readBoolean() </para></para>        
				/// </summary>
				/// <java-name>
				/// writeBoolean
				/// </java-name>
				[Dot42.DexImport("writeBoolean", "(Z)V", AccessFlags = 17)]
				public void WriteBoolean(bool val) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Writes an 8-bit byte to this file, starting at the current file pointer. Only the least significant byte of the integer <c>val </c> is written.</para> <para> <para>readByte() </para> <para>readUnsignedByte() </para></para>        
				/// </summary>
				/// <java-name>
				/// writeByte
				/// </java-name>
				[Dot42.DexImport("writeByte", "(I)V", AccessFlags = 17)]
				public void WriteByte(int val) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Writes the low order 8-bit bytes from a string to this file, starting at the current file pointer.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// writeBytes
				/// </java-name>
				[Dot42.DexImport("writeBytes", "(Ljava/lang/String;)V", AccessFlags = 17)]
				public void WriteBytes(string str) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Writes a big-endian 16-bit character to this file, starting at the current file pointer. Only the two least significant bytes of the integer <c>val </c> are written, with the high byte first.</para> <para> <para>readChar() </para></para>        
				/// </summary>
				/// <java-name>
				/// writeChar
				/// </java-name>
				[Dot42.DexImport("writeChar", "(I)V", AccessFlags = 17)]
				public void WriteChar(int val) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Writes big-endian 16-bit characters from <c>str </c> to this file, starting at the current file pointer.</para> <para> <para>readChar() </para></para>        
				/// </summary>
				/// <java-name>
				/// writeChars
				/// </java-name>
				[Dot42.DexImport("writeChars", "(Ljava/lang/String;)V", AccessFlags = 17)]
				public void WriteChars(string str) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Writes a big-endian 64-bit double to this file, starting at the current file pointer. The bytes are those returned by Double#doubleToLongBits(double), meaning a canonical NaN is used.</para> <para> <para>readDouble() </para></para>        
				/// </summary>
				/// <java-name>
				/// writeDouble
				/// </java-name>
				[Dot42.DexImport("writeDouble", "(D)V", AccessFlags = 17)]
				public void WriteDouble(double val) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Writes a big-endian 32-bit float to this file, starting at the current file pointer. The bytes are those returned by Float#floatToIntBits(float), meaning a canonical NaN is used.</para> <para> <para>readFloat() </para></para>        
				/// </summary>
				/// <java-name>
				/// writeFloat
				/// </java-name>
				[Dot42.DexImport("writeFloat", "(F)V", AccessFlags = 17)]
				public void WriteFloat(float val) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Writes a big-endian 32-bit integer to this file, starting at the current file pointer.</para> <para> <para>readInt() </para></para>        
				/// </summary>
				/// <java-name>
				/// writeInt
				/// </java-name>
				[Dot42.DexImport("writeInt", "(I)V", AccessFlags = 17)]
				public void WriteInt(int val) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Writes a big-endian 64-bit long to this file, starting at the current file pointer.</para> <para> <para>readLong() </para></para>        
				/// </summary>
				/// <java-name>
				/// writeLong
				/// </java-name>
				[Dot42.DexImport("writeLong", "(J)V", AccessFlags = 17)]
				public void WriteLong(long val) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Writes a big-endian 16-bit short to this file, starting at the current file pointer. Only the two least significant bytes of the integer <c>val </c> are written.</para> <para> <para>readShort() </para> <para>DataInput::readUnsignedShort() </para></para>        
				/// </summary>
				/// <java-name>
				/// writeShort
				/// </java-name>
				[Dot42.DexImport("writeShort", "(I)V", AccessFlags = 17)]
				public void WriteShort(int val) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Writes a string encoded with modified UTF-8 to this file, starting at the current file pointer.</para> <para> <para>readUTF() </para></para>        
				/// </summary>
				/// <java-name>
				/// writeUTF
				/// </java-name>
				[Dot42.DexImport("writeUTF", "(Ljava/lang/String;)V", AccessFlags = 17)]
				public void WriteUTF(string str) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal RandomAccessFile() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Gets this file's FileChannel object. </para> <para>The file channel's position is the same as this file's file pointer offset (see getFilePointer()). Any changes made to this file's file pointer offset are also visible in the file channel's position and vice versa.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>this file's file channel instance. </para>
				/// </returns>
				/// <java-name>
				/// getChannel
				/// </java-name>
				public global::Java.Nio.Channels.FileChannel Channel
				{
						[Dot42.DexImport("getChannel", "()Ljava/nio/channels/FileChannel;", AccessFlags = 49)]
						get{ return default(global::Java.Nio.Channels.FileChannel); }
				}

				/// <summary>
				///  <para>Gets this file's FileDescriptor. This represents the operating system resource for this random access file.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>this file's file descriptor object. </para>
				/// </returns>
				/// <java-name>
				/// getFD
				/// </java-name>
				public global::Java.IO.FileDescriptor FD
				{
						[Dot42.DexImport("getFD", "()Ljava/io/FileDescriptor;", AccessFlags = 17)]
						get{ return default(global::Java.IO.FileDescriptor); }
				}

				/// <summary>
				///  <para>Gets the current position within this file. All reads and writes take place at the current file pointer position.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the current offset in bytes from the beginning of the file.</para>
				/// </returns>
				/// <java-name>
				/// getFilePointer
				/// </java-name>
				public virtual long FilePointer
				{
						[Dot42.DexImport("getFilePointer", "()J", AccessFlags = 1)]
						get{ return default(long); }
				}

		}

		/// <summary>
		///  <para>The base class for all readers. A reader is a means of reading data from a source in a character-wise manner. Some readers also support marking a position in the input and returning to this position later. </para> <para>This abstract class does not provide a fully working implementation, so it needs to be subclassed, and at least the read(char[], int, int) and close() methods needs to be overridden. Overriding some of the non-abstract methods is also often advised, since it might result in higher efficiency. </para> <para>Many specialized readers for purposes like reading from a file already exist in this package.</para> <para> <para>Writer </para></para>    
		/// </summary>
		/// <java-name>
		/// java/io/Reader
		/// </java-name>
		[Dot42.DexImport("java/io/Reader", AccessFlags = 1057)]
		public abstract partial class Reader : global::Java.Lang.IReadable, global::Java.IO.ICloseable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>The object used to synchronize access to the reader. </para>        
				/// </summary>
				/// <java-name>
				/// lock
				/// </java-name>
				[Dot42.DexImport("lock", "Ljava/lang/Object;", AccessFlags = 4)]
				protected internal object Lock;
				/// <summary>
				///  <para>Constructs a new <c>Reader </c> with <c>this </c> as the object used to synchronize critical sections. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal Reader() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new <c>Reader </c> with <c>lock </c> used to synchronize critical sections.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/Object;)V", AccessFlags = 4)]
				protected internal Reader(object @lock) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Closes this reader. Implementations of this method should free any resources associated with the reader.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1025)]
				public virtual void Close() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets a mark position in this reader. The parameter <c>readLimit </c> indicates how many characters can be read before the mark is invalidated. Calling <c>reset() </c> will reposition the reader back to the marked position if <c>readLimit </c> has not been surpassed. </para> <para>This default implementation simply throws an <c>IOException </c> ; subclasses must provide their own implementation.</para> <para> <para>markSupported() </para> <para>reset() </para></para>        
				/// </summary>
				/// <java-name>
				/// mark
				/// </java-name>
				[Dot42.DexImport("mark", "(I)V", AccessFlags = 1)]
				public virtual void Mark(int readLimit) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Indicates whether this reader supports the <c>mark() </c> and  <c>reset() </c> methods. This default implementation returns  <c>false </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>always <c>false </c> . </para>
				/// </returns>
				/// <java-name>
				/// markSupported
				/// </java-name>
				[Dot42.DexImport("markSupported", "()Z", AccessFlags = 1)]
				public virtual bool MarkSupported() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Reads a single character from this reader and returns it as an integer with the two higher-order bytes set to 0. Returns -1 if the end of the reader has been reached.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the character read or -1 if the end of the reader has been reached. </para>
				/// </returns>
				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "()I", AccessFlags = 1)]
				public virtual int Read() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Reads characters and puts them into the <c>target </c> character buffer.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the number of characters put into <c>target </c> or -1 if the end of this reader has been reached before a character has been read. </para>
				/// </returns>
				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([C)I", AccessFlags = 1)]
				public virtual int Read(char[] target) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Reads up to <c>count </c> characters from this reader and stores them at <c>offset </c> in the character array <c>buffer </c> . Returns the number of characters actually read or -1 if the end of the reader has been reached.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([CII)I", AccessFlags = 1025)]
				public abstract int Read(char[] buffer, int offset, int count) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Indicates whether this reader is ready to be read without blocking. Returns <c>true </c> if this reader will not block when <c>read </c> is called, <c>false </c> if unknown or blocking will occur. This default implementation always returns <c>false </c> .</para> <para> <para>read() </para> <para>read(char[]) </para> <para>read(char[], int, int) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>always <c>false </c> . </para>
				/// </returns>
				/// <java-name>
				/// ready
				/// </java-name>
				[Dot42.DexImport("ready", "()Z", AccessFlags = 1)]
				public virtual bool Ready() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Resets this reader's position to the last <c>mark() </c> location. Invocations of <c>read() </c> and <c>skip() </c> will occur from this new location. If this reader has not been marked, the behavior of  <c>reset() </c> is implementation specific. This default implementation throws an <c>IOException </c> .</para> <para> <para>mark(int) </para> <para>markSupported() </para></para>        
				/// </summary>
				/// <java-name>
				/// reset
				/// </java-name>
				[Dot42.DexImport("reset", "()V", AccessFlags = 1)]
				public virtual void Reset() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Skips <c>charCount </c> characters in this reader. Subsequent calls of  <c>read </c> methods will not return these characters unless <c>reset </c> is used. This method may perform multiple reads to read <c>charCount </c> characters.</para> <para> <para>mark(int) </para> <para>markSupported() </para> <para>reset() </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the number of characters actually skipped. </para>
				/// </returns>
				/// <java-name>
				/// skip
				/// </java-name>
				[Dot42.DexImport("skip", "(J)J", AccessFlags = 1)]
				public virtual long Skip(long charCount) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				///  <para>Reads characters and puts them into the <c>target </c> character buffer.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the number of characters put into <c>target </c> or -1 if the end of this reader has been reached before a character has been read. </para>
				/// </returns>
				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "(Ljava/nio/CharBuffer;)I", AccessFlags = 1)]
				public virtual int Read(global::Java.Nio.CharBuffer target) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

		}

		/// <summary>
		///  <para>Concatenates two or more existing InputStreams. Reads are taken from the first stream until it ends, then the next stream is used, until the last stream returns end of file. </para>    
		/// </summary>
		/// <java-name>
		/// java/io/SequenceInputStream
		/// </java-name>
		[Dot42.DexImport("java/io/SequenceInputStream", AccessFlags = 33)]
		public partial class SequenceInputStream : global::Java.IO.InputStream
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructs a new <c>SequenceInputStream </c> using the two streams  <c>s1 </c> and <c>s2 </c> as the sequence of streams to read from.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/io/InputStream;Ljava/io/InputStream;)V", AccessFlags = 1)]
				public SequenceInputStream(global::Java.IO.InputStream s1, global::Java.IO.InputStream s2) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new SequenceInputStream using the elements returned from Enumeration <c>e </c> as the stream sequence. The instances returned by  <c>e.nextElement() </c> must be of type InputStream.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/util/Enumeration;)V", AccessFlags = 1, Signature = "(Ljava/util/Enumeration<+Ljava/io/InputStream;>;)V")]
				public SequenceInputStream(global::Java.Util.IEnumeration<global::Java.IO.InputStream> e) /* MethodBuilder.Create */ 
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

				/// <summary>
				///  <para>Closes all streams in this sequence of input stream.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1)]
				public override void Close() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Reads a single byte from this sequence of input streams and returns it as an integer in the range from 0 to 255. It tries to read from the current stream first; if the end of this stream has been reached, it reads from the next one. Blocks until one byte has been read, the end of the last input stream in the sequence has been reached, or an exception is thrown.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the byte read or -1 if either the end of the last stream in the sequence has been reached or this input stream sequence is closed. </para>
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
				///  <para>Reads up to <c>byteCount </c> bytes from this sequence of input streams and stores them in the byte array <c>buffer </c> starting at <c>byteOffset </c> . Blocks only until at least 1 byte has been read, the end of the stream has been reached, or an exception is thrown. </para> <para>This SequenceInputStream shows the same behavior as other InputStreams. To do this it will read only as many bytes as a call to read on the current substream returns. If that call does not return as many bytes as requested by <c>byteCount </c> , it will not retry to read more on its own because subsequent reads might block. This would violate the rule that it will only block until at least one byte has been read. </para> <para>If a substream has already reached the end when this call is made, it will close that substream and start with the next one. If there are no more substreams it will return -1.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([BII)I", AccessFlags = 1)]
				public override int Read(sbyte[] buffer, int byteOffset, int byteCount) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Reads up to <c>byteCount </c> bytes from this sequence of input streams and stores them in the byte array <c>buffer </c> starting at <c>byteOffset </c> . Blocks only until at least 1 byte has been read, the end of the stream has been reached, or an exception is thrown. </para> <para>This SequenceInputStream shows the same behavior as other InputStreams. To do this it will read only as many bytes as a call to read on the current substream returns. If that call does not return as many bytes as requested by <c>byteCount </c> , it will not retry to read more on its own because subsequent reads might block. This would violate the rule that it will only block until at least one byte has been read. </para> <para>If a substream has already reached the end when this call is made, it will close that substream and start with the next one. If there are no more substreams it will return -1.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([BII)I", AccessFlags = 1, IgnoreFromJava = true)]
				public override int Read(byte[] buffer, int byteOffset, int byteCount) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal SequenceInputStream() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		///  <para>Legacy security code; do not use. </para>    
		/// </summary>
		/// <java-name>
		/// java/io/SerializablePermission
		/// </java-name>
		[Dot42.DexImport("java/io/SerializablePermission", AccessFlags = 49)]
		public sealed partial class SerializablePermission : global::Java.Security.BasicPermission
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public SerializablePermission(string permissionName) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public SerializablePermission(string name, string actions) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal SerializablePermission() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		///  <para>Signals that the ObjectInputStream#readObject() method could not read an object due to missing information (for example, a cyclic reference that doesn't match a previous instance, or a missing class descriptor for the object to be loaded).</para> <para> <para>ObjectInputStream </para> <para>OptionalDataException </para></para>    
		/// </summary>
		/// <java-name>
		/// java/io/StreamCorruptedException
		/// </java-name>
		[Dot42.DexImport("java/io/StreamCorruptedException", AccessFlags = 33)]
		public partial class StreamCorruptedException : global::Java.IO.ObjectStreamException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructs a new <c>StreamCorruptedException </c> with its stack trace filled in. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public StreamCorruptedException() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new <c>StreamCorruptedException </c> with its stack trace and detail message filled in.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public StreamCorruptedException(string detailMessage) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>Parses a stream into a set of defined tokens, one at a time. The different types of tokens that can be found are numbers, identifiers, quoted strings, and different comment styles. The class can be used for limited processing of source code of programming languages like Java, although it is nowhere near a full parser. </para>    
		/// </summary>
		/// <java-name>
		/// java/io/StreamTokenizer
		/// </java-name>
		[Dot42.DexImport("java/io/StreamTokenizer", AccessFlags = 33)]
		public partial class StreamTokenizer
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Contains a number if the current token is a number ( <c>ttype </c> ==  <c>TT_NUMBER </c> ). </para>        
				/// </summary>
				/// <java-name>
				/// nval
				/// </java-name>
				[Dot42.DexImport("nval", "D", AccessFlags = 1)]
				public double Nval;
				/// <summary>
				///  <para>Contains a string if the current token is a word ( <c>ttype </c> ==  <c>TT_WORD </c> ). </para>        
				/// </summary>
				/// <java-name>
				/// sval
				/// </java-name>
				[Dot42.DexImport("sval", "Ljava/lang/String;", AccessFlags = 1)]
				public string Sval;
				/// <summary>
				///  <para>The constant representing the end of the stream. </para>        
				/// </summary>
				/// <java-name>
				/// TT_EOF
				/// </java-name>
				[Dot42.DexImport("TT_EOF", "I", AccessFlags = 25)]
				public const int TT_EOF = -1;
				/// <summary>
				///  <para>The constant representing the end of the line. </para>        
				/// </summary>
				/// <java-name>
				/// TT_EOL
				/// </java-name>
				[Dot42.DexImport("TT_EOL", "I", AccessFlags = 25)]
				public const int TT_EOL = 10;
				/// <summary>
				///  <para>The constant representing a number token. </para>        
				/// </summary>
				/// <java-name>
				/// TT_NUMBER
				/// </java-name>
				[Dot42.DexImport("TT_NUMBER", "I", AccessFlags = 25)]
				public const int TT_NUMBER = -2;
				/// <summary>
				///  <para>The constant representing a word token. </para>        
				/// </summary>
				/// <java-name>
				/// TT_WORD
				/// </java-name>
				[Dot42.DexImport("TT_WORD", "I", AccessFlags = 25)]
				public const int TT_WORD = -3;
				/// <summary>
				///  <para>After calling <c>nextToken() </c> , <c>ttype </c> contains the type of token that has been read. When a single character is read, its value converted to an integer is stored in <c>ttype </c> . For a quoted string, the value is the quoted character. Otherwise, its value is one of the following:  <ul> <li> <para> <c>TT_WORD </c> - the token is a word. </para></li> <li> <para> <c>TT_NUMBER </c> - the token is a number. </para></li> <li> <para> <c>TT_EOL </c> - the end of line has been reached. Depends on whether <c>eolIsSignificant </c> is <c>true </c> . </para></li> <li> <para> <c>TT_EOF </c> - the end of the stream has been reached. </para></li></ul></para>        
				/// </summary>
				/// <java-name>
				/// ttype
				/// </java-name>
				[Dot42.DexImport("ttype", "I", AccessFlags = 1)]
				public int Ttype;
				/// <summary>
				///  <para>Constructs a new <c>StreamTokenizer </c> with <c>is </c> as source input stream. This constructor is deprecated; instead, the constructor that takes a <c>Reader </c> as an argument should be used.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use StreamTokenizer(Reader) instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/io/InputStream;)V", AccessFlags = 1)]
				public StreamTokenizer(global::Java.IO.InputStream @is) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new <c>StreamTokenizer </c> with <c>is </c> as source input stream. This constructor is deprecated; instead, the constructor that takes a <c>Reader </c> as an argument should be used.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use StreamTokenizer(Reader) instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/io/Reader;)V", AccessFlags = 1)]
				public StreamTokenizer(global::Java.IO.Reader @is) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Specifies that the character <c>ch </c> shall be treated as a comment character.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// commentChar
				/// </java-name>
				[Dot42.DexImport("commentChar", "(I)V", AccessFlags = 1)]
				public virtual void CommentChar(int ch) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Specifies whether the end of a line is significant and should be returned as <c>TT_EOF </c> in <c>ttype </c> by this tokenizer.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// eolIsSignificant
				/// </java-name>
				[Dot42.DexImport("eolIsSignificant", "(Z)V", AccessFlags = 1)]
				public virtual void EolIsSignificant(bool flag) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns the current line number.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>this tokenizer's current line number. </para>
				/// </returns>
				/// <java-name>
				/// lineno
				/// </java-name>
				[Dot42.DexImport("lineno", "()I", AccessFlags = 1)]
				public virtual int Lineno() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Specifies whether word tokens should be converted to lower case when they are stored in <c>sval </c> .</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// lowerCaseMode
				/// </java-name>
				[Dot42.DexImport("lowerCaseMode", "(Z)V", AccessFlags = 1)]
				public virtual void LowerCaseMode(bool flag) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Parses the next token from this tokenizer's source stream or reader. The type of the token is stored in the <c>ttype </c> field, additional information may be stored in the <c>nval </c> or <c>sval </c> fields.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the value of <c>ttype </c> . </para>
				/// </returns>
				/// <java-name>
				/// nextToken
				/// </java-name>
				[Dot42.DexImport("nextToken", "()I", AccessFlags = 1)]
				public virtual int NextToken() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Specifies that the character <c>ch </c> shall be treated as an ordinary character by this tokenizer. That is, it has no special meaning as a comment character, word component, white space, string delimiter or number.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// ordinaryChar
				/// </java-name>
				[Dot42.DexImport("ordinaryChar", "(I)V", AccessFlags = 1)]
				public virtual void OrdinaryChar(int ch) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Specifies that the characters in the range from <c>low </c> to <c>hi </c> shall be treated as an ordinary character by this tokenizer. That is, they have no special meaning as a comment character, word component, white space, string delimiter or number.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// ordinaryChars
				/// </java-name>
				[Dot42.DexImport("ordinaryChars", "(II)V", AccessFlags = 1)]
				public virtual void OrdinaryChars(int low, int hi) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Specifies that this tokenizer shall parse numbers. </para>        
				/// </summary>
				/// <java-name>
				/// parseNumbers
				/// </java-name>
				[Dot42.DexImport("parseNumbers", "()V", AccessFlags = 1)]
				public virtual void ParseNumbers() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Indicates that the current token should be pushed back and returned again the next time <c>nextToken() </c> is called. </para>        
				/// </summary>
				/// <java-name>
				/// pushBack
				/// </java-name>
				[Dot42.DexImport("pushBack", "()V", AccessFlags = 1)]
				public virtual void PushBack() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Specifies that the character <c>ch </c> shall be treated as a quote character.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// quoteChar
				/// </java-name>
				[Dot42.DexImport("quoteChar", "(I)V", AccessFlags = 1)]
				public virtual void QuoteChar(int ch) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Specifies that all characters shall be treated as ordinary characters. </para>        
				/// </summary>
				/// <java-name>
				/// resetSyntax
				/// </java-name>
				[Dot42.DexImport("resetSyntax", "()V", AccessFlags = 1)]
				public virtual void ResetSyntax() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Specifies whether "slash-slash" (C++-style) comments shall be recognized. This kind of comment ends at the end of the line.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// slashSlashComments
				/// </java-name>
				[Dot42.DexImport("slashSlashComments", "(Z)V", AccessFlags = 1)]
				public virtual void SlashSlashComments(bool flag) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Specifies whether "slash-star" (C-style) comments shall be recognized. Slash-star comments cannot be nested and end when a star-slash combination is found.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// slashStarComments
				/// </java-name>
				[Dot42.DexImport("slashStarComments", "(Z)V", AccessFlags = 1)]
				public virtual void SlashStarComments(bool flag) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns the state of this tokenizer in a readable format.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the current state of this tokenizer. </para>
				/// </returns>
				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Specifies that the characters in the range from <c>low </c> to <c>hi </c> shall be treated as whitespace characters by this tokenizer.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// whitespaceChars
				/// </java-name>
				[Dot42.DexImport("whitespaceChars", "(II)V", AccessFlags = 1)]
				public virtual void WhitespaceChars(int low, int hi) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Specifies that the characters in the range from <c>low </c> to <c>hi </c> shall be treated as word characters by this tokenizer. A word consists of a word character followed by zero or more word or number characters.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// wordChars
				/// </java-name>
				[Dot42.DexImport("wordChars", "(II)V", AccessFlags = 1)]
				public virtual void WordChars(int low, int hi) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal StreamTokenizer() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		///  <para>A specialized InputStream that reads bytes from a <c>String </c> in a sequential manner.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use StringReader instead. </para></xrefdescription></xrefsect></para>    
		/// </summary>
		/// <java-name>
		/// java/io/StringBufferInputStream
		/// </java-name>
		[Dot42.DexImport("java/io/StringBufferInputStream", AccessFlags = 33)]
		public partial class StringBufferInputStream : global::Java.IO.InputStream
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>The source string containing the data to read. </para>        
				/// </summary>
				/// <java-name>
				/// buffer
				/// </java-name>
				[Dot42.DexImport("buffer", "Ljava/lang/String;", AccessFlags = 4)]
				protected internal string Buffer;
				/// <summary>
				///  <para>The total number of characters in the source string. </para>        
				/// </summary>
				/// <java-name>
				/// count
				/// </java-name>
				[Dot42.DexImport("count", "I", AccessFlags = 4)]
				protected internal int Count;
				/// <summary>
				///  <para>The current position within the source string. </para>        
				/// </summary>
				/// <java-name>
				/// pos
				/// </java-name>
				[Dot42.DexImport("pos", "I", AccessFlags = 4)]
				protected internal int Pos;
				/// <summary>
				///  <para>Construct a new <c>StringBufferInputStream </c> with <c>str </c> as source. The size of the stream is set to the <c>length() </c> of the string.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public StringBufferInputStream(string str) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// available
				/// </java-name>
				[Dot42.DexImport("available", "()I", AccessFlags = 33)]
				public override int Available() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Reads a single byte from the source string and returns it as an integer in the range from 0 to 255. Returns -1 if the end of the source string has been reached.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the byte read or -1 if the end of the source string has been reached. </para>
				/// </returns>
				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "()I", AccessFlags = 33)]
				public override int Read() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([BII)I", AccessFlags = 33)]
				public override int Read(sbyte[] buffer, int byteOffset, int byteCount) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([BII)I", AccessFlags = 33, IgnoreFromJava = true)]
				public override int Read(byte[] buffer, int byteOffset, int byteCount) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Resets this stream to the beginning of the source string. </para>        
				/// </summary>
				/// <java-name>
				/// reset
				/// </java-name>
				[Dot42.DexImport("reset", "()V", AccessFlags = 33)]
				public override void Reset() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Skips <c>charCount </c> characters in the source string. It does nothing and returns 0 if <c>charCount </c> is negative. Less than <c>charCount </c> characters are skipped if the end of the source string is reached before the operation completes.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the number of characters actually skipped. </para>
				/// </returns>
				/// <java-name>
				/// skip
				/// </java-name>
				[Dot42.DexImport("skip", "(J)J", AccessFlags = 33)]
				public override long Skip(long charCount) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal StringBufferInputStream() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		///  <para>A specialized Reader that reads characters from a <c>String </c> in a sequential manner.</para> <para> <para>StringWriter </para></para>    
		/// </summary>
		/// <java-name>
		/// java/io/StringReader
		/// </java-name>
		[Dot42.DexImport("java/io/StringReader", AccessFlags = 33)]
		public partial class StringReader : global::Java.IO.Reader
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Construct a new <c>StringReader </c> with <c>str </c> as source. The size of the reader is set to the <c>length() </c> of the string and the Object to synchronize access through is set to <c>str </c> .</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public StringReader(string str) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Closes this reader. Once it is closed, read operations on this reader will throw an <c>IOException </c> . Only the first invocation of this method has any effect. </para>        
				/// </summary>
				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1)]
				public override void Close() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets a mark position in this reader. The parameter <c>readLimit </c> is ignored for this class. Calling <c>reset() </c> will reposition the reader back to the marked position.</para> <para> <para>markSupported() </para> <para>reset() </para></para>        
				/// </summary>
				/// <java-name>
				/// mark
				/// </java-name>
				[Dot42.DexImport("mark", "(I)V", AccessFlags = 1)]
				public override void Mark(int readLimit) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Indicates whether this reader supports the <c>mark() </c> and <c>reset() </c> methods. This implementation returns <c>true </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>always <c>true </c> . </para>
				/// </returns>
				/// <java-name>
				/// markSupported
				/// </java-name>
				[Dot42.DexImport("markSupported", "()Z", AccessFlags = 1)]
				public override bool MarkSupported() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Reads a single character from the source string and returns it as an integer with the two higher-order bytes set to 0. Returns -1 if the end of the source string has been reached.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the character read or -1 if the end of the source string has been reached. </para>
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
				///  <para>Reads up to <c>count </c> characters from the source string and stores them at <c>offset </c> in the character array <c>buffer </c> . Returns the number of characters actually read or -1 if the end of the source string has been reached.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([CII)I", AccessFlags = 1)]
				public override int Read(char[] buffer, int offset, int count) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Indicates whether this reader is ready to be read without blocking. This implementation always returns <c>true </c> .</para> <para> <para>read() </para> <para>read(char[], int, int) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>always <c>true </c> . </para>
				/// </returns>
				/// <java-name>
				/// ready
				/// </java-name>
				[Dot42.DexImport("ready", "()Z", AccessFlags = 1)]
				public override bool Ready() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Resets this reader's position to the last <c>mark() </c> location. Invocations of <c>read() </c> and <c>skip() </c> will occur from this new location. If this reader has not been marked, it is reset to the beginning of the source string.</para> <para> <para>mark(int) </para> <para>markSupported() </para></para>        
				/// </summary>
				/// <java-name>
				/// reset
				/// </java-name>
				[Dot42.DexImport("reset", "()V", AccessFlags = 1)]
				public override void Reset() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Moves <c>charCount </c> characters in the source string. Unlike the overridden method, this method may skip negative skip distances: this rewinds the input so that characters may be read again. When the end of the source string has been reached, the input cannot be rewound.</para> <para> <para>mark(int) </para> <para>markSupported() </para> <para>reset() </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the number of characters actually skipped. This is bounded below by the number of characters already read and above by the number of characters remaining: <br></br> <c>-(num chars already          read) &lt;= distance skipped &lt;= num chars remaining </c> . </para>
				/// </returns>
				/// <java-name>
				/// skip
				/// </java-name>
				[Dot42.DexImport("skip", "(J)J", AccessFlags = 1)]
				public override long Skip(long charCount) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal StringReader() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		///  <para>A specialized Writer that writes characters to a <c>StringBuffer </c> in a sequential manner, appending them in the process. The result can later be queried using the StringWriter(int) or toString() methods.</para> <para> <para>StringReader </para></para>    
		/// </summary>
		/// <java-name>
		/// java/io/StringWriter
		/// </java-name>
		[Dot42.DexImport("java/io/StringWriter", AccessFlags = 33)]
		public partial class StringWriter : global::Java.IO.Writer
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructs a new <c>StringWriter </c> which has a StringBuffer allocated with the default size of 16 characters. The <c>StringBuffer </c> is also the <c>lock </c> used to synchronize access to this writer. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public StringWriter() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new <c>StringWriter </c> which has a StringBuffer allocated with a size of <c>initialSize </c> characters. The <c>StringBuffer </c> is also the <c>lock </c> used to synchronize access to this writer.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public StringWriter(int initialSize) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Calling this method has no effect. In contrast to most <c>Writer </c> subclasses, the other methods in <c>StringWriter </c> do not throw an <c>IOException </c> if  <c>close() </c> has been called.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1)]
				public override void Close() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Calling this method has no effect. </para>        
				/// </summary>
				/// <java-name>
				/// flush
				/// </java-name>
				[Dot42.DexImport("flush", "()V", AccessFlags = 1)]
				public override void Flush() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Gets a copy of the contents of this writer as a string.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>this writer's contents as a string. </para>
				/// </returns>
				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([CII)V", AccessFlags = 1)]
				public override void Write(char[] @char, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Writes one character to this writer's <c>StringBuffer </c> . Only the two least significant bytes of the integer <c>oneChar </c> are written.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "(I)V", AccessFlags = 1)]
				public override void Write(int oneChar) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Writes one character to this writer's <c>StringBuffer </c> . Only the two least significant bytes of the integer <c>oneChar </c> are written.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public override void Write(string oneChar) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "(Ljava/lang/String;II)V", AccessFlags = 1)]
				public override void Write(string @string, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// append
				/// </java-name>
				[Dot42.DexImport("append", "(C)Ljava/io/StringWriter;", AccessFlags = 1)]
				public new virtual global::Java.IO.StringWriter Append(char @char) /* MethodBuilder.Create */ 
				{
						return default(global::Java.IO.StringWriter);
				}

				/// <java-name>
				/// append
				/// </java-name>
				[Dot42.DexImport("append", "(Ljava/lang/CharSequence;)Ljava/io/StringWriter;", AccessFlags = 1)]
				public new virtual global::Java.IO.StringWriter Append(global::Java.Lang.ICharSequence charSequence) /* MethodBuilder.Create */ 
				{
						return default(global::Java.IO.StringWriter);
				}

				/// <summary>
				///  <para>Appends a subsequence of the character sequence <c>csq </c> to this writer's <c>StringBuffer </c> . This method works the same way as <c>StringWriter.writer(csq.subsequence(start, end).toString()) </c> . If <c>csq </c> is <c>null </c> , then the specified subsequence of the string "null" will be written to the target.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>this writer. </para>
				/// </returns>
				/// <java-name>
				/// append
				/// </java-name>
				[Dot42.DexImport("append", "(Ljava/lang/CharSequence;II)Ljava/io/StringWriter;", AccessFlags = 1)]
				public new virtual global::Java.IO.StringWriter JavaAppend(global::Java.Lang.ICharSequence csq, int start, int end) /* MethodBuilder.Create */ 
				{
						return default(global::Java.IO.StringWriter);
				}

				/// <summary>
				///  <para>Gets a reference to this writer's internal StringBuffer. Any changes made to the returned buffer are reflected in this writer.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a reference to this writer's internal <c>StringBuffer </c> . </para>
				/// </returns>
				/// <java-name>
				/// getBuffer
				/// </java-name>
				public virtual global::Java.Lang.StringBuffer Buffer
				{
						[Dot42.DexImport("getBuffer", "()Ljava/lang/StringBuffer;", AccessFlags = 1)]
						get{ return default(global::Java.Lang.StringBuffer); }
				}

		}

		/// <summary>
		///  <para>Signals that the FileDescriptor#sync() method has failed to complete. </para>    
		/// </summary>
		/// <java-name>
		/// java/io/SyncFailedException
		/// </java-name>
		[Dot42.DexImport("java/io/SyncFailedException", AccessFlags = 33)]
		public partial class SyncFailedException : global::System.IO.IOException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructs a new <c>SyncFailedException </c> with its stack trace and detail message filled in.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public SyncFailedException(string detailMessage) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal SyncFailedException() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		///  <para>Thrown when a program asks for a particular character converter that is unavailable. </para>    
		/// </summary>
		/// <java-name>
		/// java/io/UnsupportedEncodingException
		/// </java-name>
		[Dot42.DexImport("java/io/UnsupportedEncodingException", AccessFlags = 33)]
		public partial class UnsupportedEncodingException : global::System.IO.IOException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructs a new <c>UnsupportedEncodingException </c> with its stack trace filled in. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public UnsupportedEncodingException() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new <c>UnsupportedEncodingException </c> with its stack trace and detail message filled in.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public UnsupportedEncodingException(string detailMessage) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>Signals that an incorrectly encoded UTF-8 string has been encountered, most likely while reading some DataInputStream.</para> <para> <para>DataInputStream::readUTF() </para></para>    
		/// </summary>
		/// <java-name>
		/// java/io/UTFDataFormatException
		/// </java-name>
		[Dot42.DexImport("java/io/UTFDataFormatException", AccessFlags = 33)]
		public partial class UTFDataFormatException : global::System.IO.IOException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructs a new <c>UTFDataFormatException </c> with its stack trace filled in. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public UTFDataFormatException() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new <c>UTFDataFormatException </c> with its stack trace and detail message filled in.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public UTFDataFormatException(string detailMessage) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>Signals that the ObjectInputStream#readObject() method has detected an exception marker in the input stream. This marker indicates that exception occurred when the object was serialized, and this marker was inserted instead of the original object. It is a way to "propagate" an exception from the code that attempted to write the object to the code that is attempting to read the object.</para> <para> <para>ObjectInputStream::readObject() </para></para>    
		/// </summary>
		/// <java-name>
		/// java/io/WriteAbortedException
		/// </java-name>
		[Dot42.DexImport("java/io/WriteAbortedException", AccessFlags = 33)]
		public partial class WriteAbortedException : global::Java.IO.ObjectStreamException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>The exception that occured when writeObject() was attempting to serialize the object. </para>        
				/// </summary>
				/// <java-name>
				/// detail
				/// </java-name>
				[Dot42.DexImport("detail", "Ljava/lang/Exception;", AccessFlags = 1)]
				public global::System.Exception Detail;
				/// <summary>
				///  <para>Constructs a new <c>WriteAbortedException </c> with its stack trace, detail message and the exception which caused the underlying problem when serializing the object filled in.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Exception;)V", AccessFlags = 1)]
				public WriteAbortedException(string detailMessage, global::System.Exception rootCause) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Gets the extra information message which was provided when this exception was created. Returns <c>null </c> if no message was provided at creation time.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the exception message. </para>
				/// </returns>
				/// <java-name>
				/// getMessage
				/// </java-name>
				[Dot42.DexImport("getMessage", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string GetMessage() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal WriteAbortedException() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Gets the cause of this exception or <c>null </c> if there is no cause.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the exception cause. </para>
				/// </returns>
				/// <java-name>
				/// getCause
				/// </java-name>
				public override global::System.Exception Cause
				{
						[Dot42.DexImport("getCause", "()Ljava/lang/Throwable;", AccessFlags = 1)]
						get{ return default(global::System.Exception); }
				}

		}

		/// <summary>
		///  <para>The base class for all writers. A writer is a means of writing data to a target in a character-wise manner. Most output streams expect the flush() method to be called before closing the stream, to ensure all data is actually written out. </para> <para>This abstract class does not provide a fully working implementation, so it needs to be subclassed, and at least the write(char[], int, int), close() and flush() methods needs to be overridden. Overriding some of the non-abstract methods is also often advised, since it might result in higher efficiency. </para> <para>Many specialized readers for purposes like reading from a file already exist in this package.</para> <para> <para>Reader </para></para>    
		/// </summary>
		/// <java-name>
		/// java/io/Writer
		/// </java-name>
		[Dot42.DexImport("java/io/Writer", AccessFlags = 1057)]
		public abstract partial class Writer : global::Java.Lang.IAppendable, global::Java.IO.ICloseable, global::Java.IO.IFlushable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>The object used to synchronize access to the writer. </para>        
				/// </summary>
				/// <java-name>
				/// lock
				/// </java-name>
				[Dot42.DexImport("lock", "Ljava/lang/Object;", AccessFlags = 4)]
				protected internal object Lock;
				/// <summary>
				///  <para>Constructs a new <c>Writer </c> with <c>this </c> as the object used to synchronize critical sections. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal Writer() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new <c>Writer </c> with <c>lock </c> used to synchronize critical sections.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/Object;)V", AccessFlags = 4)]
				protected internal Writer(object @lock) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Closes this writer. Implementations of this method should free any resources associated with the writer.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1025)]
				public virtual void Close() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Flushes this writer. Implementations of this method should ensure that all buffered characters are written to the target.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// flush
				/// </java-name>
				[Dot42.DexImport("flush", "()V", AccessFlags = 1025)]
				public virtual void Flush() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Writes one character to the target. Only the two least significant bytes of the integer <c>oneChar </c> are written.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([C)V", AccessFlags = 1)]
				public virtual void Write(char[] oneChar) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([CII)V", AccessFlags = 1025)]
				public abstract void Write(char[] @char, int int32, int int321) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Writes one character to the target. Only the two least significant bytes of the integer <c>oneChar </c> are written.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "(I)V", AccessFlags = 1)]
				public virtual void Write(int oneChar) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Writes one character to the target. Only the two least significant bytes of the integer <c>oneChar </c> are written.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void Write(string oneChar) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "(Ljava/lang/String;II)V", AccessFlags = 1)]
				public virtual void Write(string @string, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// append
				/// </java-name>
				[Dot42.DexImport("append", "(C)Ljava/io/Writer;", AccessFlags = 1)]
				public virtual global::Java.IO.Writer Append(char @char) /* MethodBuilder.Create */ 
				{
						return default(global::Java.IO.Writer);
				}

				/// <java-name>
				/// append
				/// </java-name>
				[Dot42.DexImport("append", "(Ljava/lang/CharSequence;)Ljava/io/Writer;", AccessFlags = 1)]
				public virtual global::Java.IO.Writer Append(global::Java.Lang.ICharSequence charSequence) /* MethodBuilder.Create */ 
				{
						return default(global::Java.IO.Writer);
				}

				/// <summary>
				///  <para>Appends a subsequence of the character sequence <c>csq </c> to the target. This method works the same way as <c>Writer.writer(csq.subsequence(start, end).toString()) </c> . If <c>csq </c> is <c>null </c> , then the specified subsequence of the string "null" will be written to the target.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>this writer. </para>
				/// </returns>
				/// <java-name>
				/// append
				/// </java-name>
				[Dot42.DexImport("append", "(Ljava/lang/CharSequence;II)Ljava/io/Writer;", AccessFlags = 1)]
				public virtual global::Java.IO.Writer JavaAppend(global::Java.Lang.ICharSequence csq, int start, int end) /* MethodBuilder.Create */ 
				{
						return default(global::Java.IO.Writer);
				}

				[Dot42.DexImport("java/lang/Appendable", "append", "(C)Ljava/lang/Appendable;", AccessFlags = 1025)]
				global::Java.Lang.IAppendable global::Java.Lang.IAppendable.Append(char c) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Java.Lang.IAppendable);
				}

				[Dot42.DexImport("java/lang/Appendable", "append", "(Ljava/lang/CharSequence;)Ljava/lang/Appendable;", AccessFlags = 1025)]
				global::Java.Lang.IAppendable global::Java.Lang.IAppendable.Append(global::Java.Lang.ICharSequence c) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Java.Lang.IAppendable);
				}

				[Dot42.DexImport("java/lang/Appendable", "append", "(Ljava/lang/CharSequence;II)Ljava/lang/Appendable;", AccessFlags = 1025)]
				global::Java.Lang.IAppendable global::Java.Lang.IAppendable.JavaAppend(global::Java.Lang.ICharSequence csq, int start, int end) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Java.Lang.IAppendable);
				}

		}

}

