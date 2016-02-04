#pragma warning disable 1717
namespace Java.Util.Zip
{
		/// <summary>
		///  <para>The Adler-32 class is used to compute the <c>Adler32 </c> checksum from a set of data. Compared to CRC32 it trades reliability for speed. Refer to RFC 1950 for the specification. </para>    
		/// </summary>
		/// <java-name>
		/// java/util/zip/Adler32
		/// </java-name>
		[Dot42.DexImport("java/util/zip/Adler32", AccessFlags = 33)]
		public partial class Adler32 : global::Java.Util.Zip.IChecksum
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Adler32() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Reset this instance to its initial checksum. </para>        
				/// </summary>
				/// <java-name>
				/// reset
				/// </java-name>
				[Dot42.DexImport("reset", "()V", AccessFlags = 1)]
				public virtual void Reset() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Update this <c>Adler32 </c> checksum with the single byte provided as argument.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// update
				/// </java-name>
				[Dot42.DexImport("update", "(I)V", AccessFlags = 1)]
				public virtual void Update(int i) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Update this <c>Adler32 </c> checksum with the single byte provided as argument.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// update
				/// </java-name>
				[Dot42.DexImport("update", "([B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual void Update(sbyte[] i) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Update this <c>Adler32 </c> checksum with the single byte provided as argument.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// update
				/// </java-name>
				[Dot42.DexImport("update", "([B)V", AccessFlags = 1)]
				public virtual void Update(byte[] i) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Update this <c>Adler32 </c> checksum with the contents of <c>buf </c> , starting from <c>offset </c> and reading <c>byteCount </c> bytes of data. </para>        
				/// </summary>
				/// <java-name>
				/// update
				/// </java-name>
				[Dot42.DexImport("update", "([BII)V", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual void Update(sbyte[] buf, int offset, int byteCount) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Update this <c>Adler32 </c> checksum with the contents of <c>buf </c> , starting from <c>offset </c> and reading <c>byteCount </c> bytes of data. </para>        
				/// </summary>
				/// <java-name>
				/// update
				/// </java-name>
				[Dot42.DexImport("update", "([BII)V", AccessFlags = 1)]
				public virtual void Update(byte[] buf, int offset, int byteCount) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns the <c>Adler32 </c> checksum for all input received.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The checksum for this instance. </para>
				/// </returns>
				/// <java-name>
				/// getValue
				/// </java-name>
				public virtual long Value
				{
						[Dot42.DexImport("getValue", "()J", AccessFlags = 1)]
						get{ return default(long); }
				}

		}

		/// <summary>
		///  <para>The <c>CheckedInputStream </c> class is used to maintain a checksum at the same time as the data, on which the checksum is computed, is read from a stream. The purpose of this checksum is to establish data integrity, comparing the computed checksum against a published checksum value. </para>    
		/// </summary>
		/// <java-name>
		/// java/util/zip/CheckedInputStream
		/// </java-name>
		[Dot42.DexImport("java/util/zip/CheckedInputStream", AccessFlags = 33)]
		public partial class CheckedInputStream : global::Java.IO.FilterInputStream
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructs a new <c>CheckedInputStream </c> on <c>InputStream </c>  <c>is </c> . The checksum will be calculated using the algorithm implemented by <c>csum </c> .</para> <para> <b>Warning:</b> passing a null source creates an invalid  <c>CheckedInputStream </c> . All operations on such a stream will fail.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/io/InputStream;Ljava/util/zip/Checksum;)V", AccessFlags = 1)]
				public CheckedInputStream(global::Java.IO.InputStream @is, global::Java.Util.Zip.IChecksum csum) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Reads one byte of data from the underlying input stream and updates the checksum with the byte data.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>-1 </c> at the end of the stream, a single byte value otherwise. </para>
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
				///  <para>Reads up to <c>byteCount </c> bytes of data from the underlying input stream, storing it into <c>buffer </c> , starting at offset <c>byteOffset </c> . The checksum is updated with the bytes read. Returns the number of bytes actually read or <c>-1 </c> if arrived at the end of the filtered stream while reading the data.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([BII)I", AccessFlags = 1, IgnoreFromJava = true)]
				public override int Read(sbyte[] buffer, int byteOffset, int byteCount) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Reads up to <c>byteCount </c> bytes of data from the underlying input stream, storing it into <c>buffer </c> , starting at offset <c>byteOffset </c> . The checksum is updated with the bytes read. Returns the number of bytes actually read or <c>-1 </c> if arrived at the end of the filtered stream while reading the data.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([BII)I", AccessFlags = 1)]
				public override int Read(byte[] buffer, int byteOffset, int byteCount) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Skip up to <c>byteCount </c> bytes of data on the underlying input stream. Any skipped bytes are added to the running checksum value.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the number of bytes skipped. </para>
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
				protected internal CheckedInputStream() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Returns the checksum calculated on the stream read so far. </para>        
				/// </summary>
				/// <java-name>
				/// getChecksum
				/// </java-name>
				public virtual global::Java.Util.Zip.IChecksum Checksum
				{
						[Dot42.DexImport("getChecksum", "()Ljava/util/zip/Checksum;", AccessFlags = 1)]
						get{ return default(global::Java.Util.Zip.IChecksum); }
				}

		}

		/// <summary>
		///  <para>The <c>CheckedOutputStream </c> class is used to maintain a running checksum of all data written to a stream. The purpose of this checksum is to establish data integrity, by publishing the checksum to other parties wanting to read the non corrupted data. </para>    
		/// </summary>
		/// <java-name>
		/// java/util/zip/CheckedOutputStream
		/// </java-name>
		[Dot42.DexImport("java/util/zip/CheckedOutputStream", AccessFlags = 33)]
		public partial class CheckedOutputStream : global::Java.IO.FilterOutputStream
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructs a new <c>CheckedOutputStream </c> on <c>OutputStream </c>  <c>os </c> . The checksum is calculated using the algorithm implemented by <c>csum </c> .</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/io/OutputStream;Ljava/util/zip/Checksum;)V", AccessFlags = 1)]
				public CheckedOutputStream(global::Java.IO.OutputStream os, global::Java.Util.Zip.IChecksum cs) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Writes the specified byte to the underlying stream. The checksum is updated with <c>val </c> .</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "(I)V", AccessFlags = 1)]
				public override void Write(int val) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Writes n bytes of data from <c>buf </c> starting at offset <c>off </c> to the underlying stream. The checksum is updated with the bytes written.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([BII)V", AccessFlags = 1, IgnoreFromJava = true)]
				public override void Write(sbyte[] buf, int off, int nbytes) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Writes n bytes of data from <c>buf </c> starting at offset <c>off </c> to the underlying stream. The checksum is updated with the bytes written.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([BII)V", AccessFlags = 1)]
				public override void Write(byte[] buf, int off, int nbytes) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal CheckedOutputStream() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Returns the checksum calculated on the stream read so far.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the updated checksum. </para>
				/// </returns>
				/// <java-name>
				/// getChecksum
				/// </java-name>
				public virtual global::Java.Util.Zip.IChecksum Checksum
				{
						[Dot42.DexImport("getChecksum", "()Ljava/util/zip/Checksum;", AccessFlags = 1)]
						get{ return default(global::Java.Util.Zip.IChecksum); }
				}

		}

		/// <summary>
		///  <para>The CRC32 class is used to compute a CRC32 checksum from data provided as input value. See also Adler32 which is almost as good, but cheaper. </para>    
		/// </summary>
		/// <java-name>
		/// java/util/zip/CRC32
		/// </java-name>
		[Dot42.DexImport("java/util/zip/CRC32", AccessFlags = 33)]
		public partial class CRC32 : global::Java.Util.Zip.IChecksum
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public CRC32() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Resets the CRC32 checksum to it initial state. </para>        
				/// </summary>
				/// <java-name>
				/// reset
				/// </java-name>
				[Dot42.DexImport("reset", "()V", AccessFlags = 1)]
				public virtual void Reset() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Updates this checksum with the byte value provided as integer.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// update
				/// </java-name>
				[Dot42.DexImport("update", "(I)V", AccessFlags = 1)]
				public virtual void Update(int val) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Updates this checksum with the byte value provided as integer.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// update
				/// </java-name>
				[Dot42.DexImport("update", "([B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual void Update(sbyte[] val) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Updates this checksum with the byte value provided as integer.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// update
				/// </java-name>
				[Dot42.DexImport("update", "([B)V", AccessFlags = 1)]
				public virtual void Update(byte[] val) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Update this <c>CRC32 </c> checksum with the contents of <c>buf </c> , starting from <c>offset </c> and reading <c>byteCount </c> bytes of data. </para>        
				/// </summary>
				/// <java-name>
				/// update
				/// </java-name>
				[Dot42.DexImport("update", "([BII)V", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual void Update(sbyte[] buf, int offset, int byteCount) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Update this <c>CRC32 </c> checksum with the contents of <c>buf </c> , starting from <c>offset </c> and reading <c>byteCount </c> bytes of data. </para>        
				/// </summary>
				/// <java-name>
				/// update
				/// </java-name>
				[Dot42.DexImport("update", "([BII)V", AccessFlags = 1)]
				public virtual void Update(byte[] buf, int offset, int byteCount) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns the CRC32 checksum for all input received.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The checksum for this instance. </para>
				/// </returns>
				/// <java-name>
				/// getValue
				/// </java-name>
				public virtual long Value
				{
						[Dot42.DexImport("getValue", "()J", AccessFlags = 1)]
						get{ return default(long); }
				}

		}

		/// <summary>
		///  <para> <c>DataFormatException </c> is used to indicate an error in the format of a particular data stream which is to be uncompressed. </para>    
		/// </summary>
		/// <java-name>
		/// java/util/zip/DataFormatException
		/// </java-name>
		[Dot42.DexImport("java/util/zip/DataFormatException", AccessFlags = 33)]
		public partial class DataFormatException : global::System.Exception
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructs a new <c>DataFormatException </c> instance. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public DataFormatException() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new <c>DataFormatException </c> instance with the specified message.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public DataFormatException(string detailMessage) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>This class compresses data using the  <b>DEFLATE</b> algorithm (see ).</para> <para>It is usually more convenient to use DeflaterOutputStream.</para> <para>To compress an in-memory <c>byte[] </c> to another in-memory <c>byte[] </c> manually:  <pre>
		///     byte[] originalBytes = ...</pre></para> <para> <pre>    Deflater deflater = new Deflater();
		///     deflater.setInput(originalBytes);
		///     deflater.finish();</pre></para> <para> <pre>    ByteArrayOutputStream baos = new ByteArrayOutputStream();
		///     byte[] buf = new byte[8192];
		///     while (!deflater.finished()) {
		///         int byteCount = deflater.deflate(buf);
		///         baos.write(buf, 0, byteCount);
		///     }
		///     deflater.end();</pre></para> <para> <pre>    byte[] compressedBytes = baos.toByteArray();
		/// </pre> </para> <para>In situations where you don't have all the input in one array (or have so much input that you want to feed it to the deflater in chunks), it's possible to call setInput repeatedly, but you're much better off using DeflaterOutputStream to handle all this for you. DeflaterOutputStream also helps minimize memory requirements  the sample code above is very expensive.</para> <para> <h3>Compression levels</h3></para> <para>A compression level must be DEFAULT_COMPRESSION to compromise between speed and compression (currently equivalent to level 6), or between 0 (NO_COMPRESSION, where the input is simply copied) and 9 (BEST_COMPRESSION). Level 1 (BEST_SPEED) performs some compression, but with minimal speed overhead. </para>    
		/// </summary>
		/// <java-name>
		/// java/util/zip/Deflater
		/// </java-name>
		[Dot42.DexImport("java/util/zip/Deflater", AccessFlags = 33)]
		public partial class Deflater
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>This  gives the best compression, but takes the most time. </para>        
				/// </summary>
				/// <java-name>
				/// BEST_COMPRESSION
				/// </java-name>
				[Dot42.DexImport("BEST_COMPRESSION", "I", AccessFlags = 25)]
				public const int BEST_COMPRESSION = 9;
				/// <summary>
				///  <para>This  gives minimal compression, but takes the least time (of any level that actually performs compression; see NO_COMPRESSION). </para>        
				/// </summary>
				/// <java-name>
				/// BEST_SPEED
				/// </java-name>
				[Dot42.DexImport("BEST_SPEED", "I", AccessFlags = 25)]
				public const int BEST_SPEED = 1;
				/// <summary>
				///  <para>The default . This is a trade-off between speed and compression, currently equivalent to level 6. </para>        
				/// </summary>
				/// <java-name>
				/// DEFAULT_COMPRESSION
				/// </java-name>
				[Dot42.DexImport("DEFAULT_COMPRESSION", "I", AccessFlags = 25)]
				public const int DEFAULT_COMPRESSION = -1;
				/// <summary>
				///  <para>The default compression strategy. </para>        
				/// </summary>
				/// <java-name>
				/// DEFAULT_STRATEGY
				/// </java-name>
				[Dot42.DexImport("DEFAULT_STRATEGY", "I", AccessFlags = 25)]
				public const int DEFAULT_STRATEGY = 0;
				/// <summary>
				///  <para>The default compression method. </para>        
				/// </summary>
				/// <java-name>
				/// DEFLATED
				/// </java-name>
				[Dot42.DexImport("DEFLATED", "I", AccessFlags = 25)]
				public const int DEFLATED = 8;
				/// <summary>
				///  <para>A compression strategy. </para>        
				/// </summary>
				/// <java-name>
				/// FILTERED
				/// </java-name>
				[Dot42.DexImport("FILTERED", "I", AccessFlags = 25)]
				public const int FILTERED = 1;
				/// <summary>
				///  <para>A compression strategy. </para>        
				/// </summary>
				/// <java-name>
				/// HUFFMAN_ONLY
				/// </java-name>
				[Dot42.DexImport("HUFFMAN_ONLY", "I", AccessFlags = 25)]
				public const int HUFFMAN_ONLY = 2;
				/// <summary>
				///  <para>This  does no compression. It is even faster than BEST_SPEED. </para>        
				/// </summary>
				/// <java-name>
				/// NO_COMPRESSION
				/// </java-name>
				[Dot42.DexImport("NO_COMPRESSION", "I", AccessFlags = 25)]
				public const int NO_COMPRESSION = 0;
				/// <summary>
				///  <para>Constructs a new <c>Deflater </c> instance using the default . The compression strategy can be specified with setStrategy. A header is added to the output by default; use Deflater(int, boolean) if you need to omit the header. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Deflater() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new <c>Deflater </c> instance with the given . The compression strategy can be specified with setStrategy. A header is added to the output by default; use Deflater(int, boolean) if you need to omit the header. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public Deflater(int level) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new <c>Deflater </c> instance with the given . If <c>noHeader </c> is true, no ZLIB header is added to the output. In a zip file, every entry (compressed file) comes with such a header. The strategy can be specified using setStrategy. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(IZ)V", AccessFlags = 1)]
				public Deflater(int level, bool noHeader) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Deflates the data (previously passed to setInput) into the supplied buffer.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>number of bytes of compressed data written to <c>buf </c> . </para>
				/// </returns>
				/// <java-name>
				/// deflate
				/// </java-name>
				[Dot42.DexImport("deflate", "([B)I", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual int Deflate(sbyte[] buf) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Deflates the data (previously passed to setInput) into the supplied buffer.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>number of bytes of compressed data written to <c>buf </c> . </para>
				/// </returns>
				/// <java-name>
				/// deflate
				/// </java-name>
				[Dot42.DexImport("deflate", "([B)I", AccessFlags = 1)]
				public virtual int Deflate(byte[] buf) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Deflates data (previously passed to setInput) into a specific region within the supplied buffer.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the number of bytes of compressed data written to <c>buf </c> . </para>
				/// </returns>
				/// <java-name>
				/// deflate
				/// </java-name>
				[Dot42.DexImport("deflate", "([BII)I", AccessFlags = 33, IgnoreFromJava = true)]
				public virtual int Deflate(sbyte[] buf, int offset, int byteCount) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Deflates data (previously passed to setInput) into a specific region within the supplied buffer.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the number of bytes of compressed data written to <c>buf </c> . </para>
				/// </returns>
				/// <java-name>
				/// deflate
				/// </java-name>
				[Dot42.DexImport("deflate", "([BII)I", AccessFlags = 33)]
				public virtual int Deflate(byte[] buf, int offset, int byteCount) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Frees all resources held onto by this deflating algorithm. Any unused input or output is discarded. This method should be called explicitly in order to free native resources as soon as possible. After <c>end() </c> is called, other methods will typically throw <c>IllegalStateException </c> . </para>        
				/// </summary>
				/// <java-name>
				/// end
				/// </java-name>
				[Dot42.DexImport("end", "()V", AccessFlags = 33)]
				public virtual void End() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// finalize
				/// </java-name>
				[Dot42.DexImport("finalize", "()V", AccessFlags = 4)]
				extern ~Deflater() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Indicates to the <c>Deflater </c> that all uncompressed input has been provided to it.</para> <para> <para>#finished </para></para>        
				/// </summary>
				/// <java-name>
				/// finish
				/// </java-name>
				[Dot42.DexImport("finish", "()V", AccessFlags = 33)]
				public virtual void Finish() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns true if finish has been called and all data provided by setInput has been successfully compressed and consumed by deflate. </para>        
				/// </summary>
				/// <java-name>
				/// finished
				/// </java-name>
				[Dot42.DexImport("finished", "()Z", AccessFlags = 33)]
				public virtual bool Finished() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Returns true if setInput must be called before deflation can continue. If all uncompressed data has been provided to the <c>Deflater </c> , finish must be called to ensure the compressed data is output. </para>        
				/// </summary>
				/// <java-name>
				/// needsInput
				/// </java-name>
				[Dot42.DexImport("needsInput", "()Z", AccessFlags = 33)]
				public virtual bool NeedsInput() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Resets the <c>Deflater </c> to accept new input without affecting any previously made settings for the compression strategy or level. This operation  <b>must</b> be called after finished returns true if the <c>Deflater </c> is to be reused. </para>        
				/// </summary>
				/// <java-name>
				/// reset
				/// </java-name>
				[Dot42.DexImport("reset", "()V", AccessFlags = 33)]
				public virtual void Reset() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the dictionary to be used for compression by this <c>Deflater </c> . This method can only be called if this <c>Deflater </c> supports the writing of ZLIB headers. This is the default, but can be overridden using Deflater(int, boolean). </para>        
				/// </summary>
				/// <java-name>
				/// setDictionary
				/// </java-name>
				[Dot42.DexImport("setDictionary", "([B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual void SetDictionary(sbyte[] dictionary) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the dictionary to be used for compression by this <c>Deflater </c> . This method can only be called if this <c>Deflater </c> supports the writing of ZLIB headers. This is the default, but can be overridden using Deflater(int, boolean). </para>        
				/// </summary>
				/// <java-name>
				/// setDictionary
				/// </java-name>
				[Dot42.DexImport("setDictionary", "([B)V", AccessFlags = 1)]
				public virtual void SetDictionary(byte[] dictionary) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the dictionary to be used for compression by this <c>Deflater </c> . This method can only be called if this <c>Deflater </c> supports the writing of ZLIB headers. This is the default, but can be overridden using Deflater(int, boolean). </para>        
				/// </summary>
				/// <java-name>
				/// setDictionary
				/// </java-name>
				[Dot42.DexImport("setDictionary", "([BII)V", AccessFlags = 33, IgnoreFromJava = true)]
				public virtual void SetDictionary(sbyte[] buf, int offset, int byteCount) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the dictionary to be used for compression by this <c>Deflater </c> . This method can only be called if this <c>Deflater </c> supports the writing of ZLIB headers. This is the default, but can be overridden using Deflater(int, boolean). </para>        
				/// </summary>
				/// <java-name>
				/// setDictionary
				/// </java-name>
				[Dot42.DexImport("setDictionary", "([BII)V", AccessFlags = 33)]
				public virtual void SetDictionary(byte[] buf, int offset, int byteCount) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the input buffer the <c>Deflater </c> will use to extract uncompressed bytes for later compression. </para>        
				/// </summary>
				/// <java-name>
				/// setInput
				/// </java-name>
				[Dot42.DexImport("setInput", "([B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual void SetInput(sbyte[] buf) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the input buffer the <c>Deflater </c> will use to extract uncompressed bytes for later compression. </para>        
				/// </summary>
				/// <java-name>
				/// setInput
				/// </java-name>
				[Dot42.DexImport("setInput", "([B)V", AccessFlags = 1)]
				public virtual void SetInput(byte[] buf) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the input buffer the <c>Deflater </c> will use to extract uncompressed bytes for later compression. </para>        
				/// </summary>
				/// <java-name>
				/// setInput
				/// </java-name>
				[Dot42.DexImport("setInput", "([BII)V", AccessFlags = 33, IgnoreFromJava = true)]
				public virtual void SetInput(sbyte[] buf, int offset, int byteCount) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the input buffer the <c>Deflater </c> will use to extract uncompressed bytes for later compression. </para>        
				/// </summary>
				/// <java-name>
				/// setInput
				/// </java-name>
				[Dot42.DexImport("setInput", "([BII)V", AccessFlags = 33)]
				public virtual void SetInput(byte[] buf, int offset, int byteCount) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the given  to be used when compressing data. This value must be set prior to calling setInput. </para>        
				/// </summary>
				/// <java-name>
				/// setLevel
				/// </java-name>
				[Dot42.DexImport("setLevel", "(I)V", AccessFlags = 33)]
				public virtual void SetLevel(int level) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the compression strategy to be used. The strategy must be one of FILTERED, HUFFMAN_ONLY or DEFAULT_STRATEGY. This value must be set prior to calling setInput.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setStrategy
				/// </java-name>
				[Dot42.DexImport("setStrategy", "(I)V", AccessFlags = 33)]
				public virtual void SetStrategy(int strategy) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns the Adler32 checksum of the uncompressed data read so far. </para>        
				/// </summary>
				/// <java-name>
				/// getAdler
				/// </java-name>
				public virtual int Adler
				{
						[Dot42.DexImport("getAdler", "()I", AccessFlags = 33)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns the total number of bytes of input read by this <c>Deflater </c> . This method is limited to 32 bits; use getBytesRead instead. </para>        
				/// </summary>
				/// <java-name>
				/// getTotalIn
				/// </java-name>
				public virtual int TotalIn
				{
						[Dot42.DexImport("getTotalIn", "()I", AccessFlags = 33)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns the total number of bytes written to the output buffer by this <c>Deflater </c> . The method is limited to 32 bits; use getBytesWritten instead. </para>        
				/// </summary>
				/// <java-name>
				/// getTotalOut
				/// </java-name>
				public virtual int TotalOut
				{
						[Dot42.DexImport("getTotalOut", "()I", AccessFlags = 33)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns the total number of bytes read by the <c>Deflater </c> . This method is the same as getTotalIn except that it returns a  <c>long </c> value instead of an integer. </para>        
				/// </summary>
				/// <java-name>
				/// getBytesRead
				/// </java-name>
				public virtual long BytesRead
				{
						[Dot42.DexImport("getBytesRead", "()J", AccessFlags = 33)]
						get{ return default(long); }
				}

				/// <summary>
				///  <para>Returns a the total number of bytes written by this <c>Deflater </c> . This method is the same as <c>getTotalOut </c> except it returns a  <c>long </c> value instead of an integer. </para>        
				/// </summary>
				/// <java-name>
				/// getBytesWritten
				/// </java-name>
				public virtual long BytesWritten
				{
						[Dot42.DexImport("getBytesWritten", "()J", AccessFlags = 33)]
						get{ return default(long); }
				}

		}

		/// <summary>
		///  <para>This class provides an implementation of <c>FilterOutputStream </c> that compresses data using the  <b>DEFLATE</b> algorithm. Basically it wraps the  <c>Deflater </c> class and takes care of the buffering.</para> <para> <para>Deflater </para></para>    
		/// </summary>
		/// <java-name>
		/// java/util/zip/DeflaterOutputStream
		/// </java-name>
		[Dot42.DexImport("java/util/zip/DeflaterOutputStream", AccessFlags = 33)]
		public partial class DeflaterOutputStream : global::Java.IO.FilterOutputStream
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>The buffer for the data to be written to. </para>        
				/// </summary>
				/// <java-name>
				/// buf
				/// </java-name>
				[Dot42.DexImport("buf", "[B", AccessFlags = 4)]
				protected internal sbyte[] Buf;
				/// <summary>
				///  <para>The deflater used. </para>        
				/// </summary>
				/// <java-name>
				/// def
				/// </java-name>
				[Dot42.DexImport("def", "Ljava/util/zip/Deflater;", AccessFlags = 4)]
				protected internal global::Java.Util.Zip.Deflater Def;
				/// <summary>
				///  <para>Constructs a new instance with the given <c>Deflater </c> . </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/io/OutputStream;Ljava/util/zip/Deflater;)V", AccessFlags = 1)]
				public DeflaterOutputStream(global::Java.IO.OutputStream os, global::Java.Util.Zip.Deflater def) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new instance with a default-constructed Deflater. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/io/OutputStream;)V", AccessFlags = 1)]
				public DeflaterOutputStream(global::Java.IO.OutputStream os) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new instance with the given <c>Deflater </c> and buffer size. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/io/OutputStream;Ljava/util/zip/Deflater;I)V", AccessFlags = 1)]
				public DeflaterOutputStream(global::Java.IO.OutputStream os, global::Java.Util.Zip.Deflater def, int bufferSize) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Compress the data in the input buffer and write it to the underlying stream.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// deflate
				/// </java-name>
				[Dot42.DexImport("deflate", "()V", AccessFlags = 4)]
				protected internal virtual void Deflate() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Writes any unwritten compressed data to the underlying stream, the closes all underlying streams. This stream can no longer be used after close() has been called.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1)]
				public override void Close() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Writes any unwritten data to the underlying stream. Does not close the stream.</para> <para></para>        
				/// </summary>
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
				public override void Write(int i) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Compresses <c>byteCount </c> bytes of data from <c>buf </c> starting at  <c>offset </c> and writes it to the underlying stream. </para>        
				/// </summary>
				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([BII)V", AccessFlags = 1, IgnoreFromJava = true)]
				public override void Write(sbyte[] buffer, int offset, int byteCount) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Compresses <c>byteCount </c> bytes of data from <c>buf </c> starting at  <c>offset </c> and writes it to the underlying stream. </para>        
				/// </summary>
				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([BII)V", AccessFlags = 1)]
				public override void Write(byte[] buffer, int offset, int byteCount) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal DeflaterOutputStream() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		///  <para>The <c>GZIPInputStream </c> class is used to read data stored in the GZIP format, reading and decompressing GZIP data from the underlying stream into its buffer.</para> <para> <h3>Example</h3></para> <para>Using <c>GZIPInputStream </c> is easier than ZipInputStream because GZIP is only for compression, and is not a container for multiple files. This code decompresses the data from a GZIP stream, similar to the <c>gunzip(1) </c> utility.  <pre>
		/// InputStream is = ...
		/// GZIPInputStream zis = new GZIPInputStream(new BufferedInputStream(is));
		/// try {
		///     // Reading from 'zis' gets you the uncompressed bytes...
		///     processStream(zis);
		/// } finally {
		///     zis.close();
		/// }
		/// </pre> </para>    
		/// </summary>
		/// <java-name>
		/// java/util/zip/GZIPInputStream
		/// </java-name>
		[Dot42.DexImport("java/util/zip/GZIPInputStream", AccessFlags = 33)]
		public partial class GZIPInputStream : global::Java.Util.Zip.InflaterInputStream
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>The magic header for the GZIP format. </para>        
				/// </summary>
				/// <java-name>
				/// GZIP_MAGIC
				/// </java-name>
				[Dot42.DexImport("GZIP_MAGIC", "I", AccessFlags = 25)]
				public const int GZIP_MAGIC = 35615;
				/// <summary>
				///  <para>The checksum algorithm used when handling uncompressed data. </para>        
				/// </summary>
				/// <java-name>
				/// crc
				/// </java-name>
				[Dot42.DexImport("crc", "Ljava/util/zip/CRC32;", AccessFlags = 4)]
				protected internal global::Java.Util.Zip.CRC32 Crc;
				/// <summary>
				///  <para>Indicates the end of the input stream. </para>        
				/// </summary>
				/// <java-name>
				/// eos
				/// </java-name>
				[Dot42.DexImport("eos", "Z", AccessFlags = 4)]
				protected internal bool Eos;
				/// <summary>
				///  <para>Construct a <c>GZIPInputStream </c> to read from GZIP data from the underlying stream.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/io/InputStream;)V", AccessFlags = 1)]
				public GZIPInputStream(global::Java.IO.InputStream @is) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Construct a <c>GZIPInputStream </c> to read from GZIP data from the underlying stream. Set the internal buffer size to <c>size </c> .</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/io/InputStream;I)V", AccessFlags = 1)]
				public GZIPInputStream(global::Java.IO.InputStream @is, int size) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Closes this stream and any underlying streams. </para>        
				/// </summary>
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
				[Dot42.DexImport("read", "([BII)I", AccessFlags = 1, IgnoreFromJava = true)]
				public override int Read(sbyte[] buffer, int byteOffset, int byteCount) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([BII)I", AccessFlags = 1)]
				public override int Read(byte[] buffer, int byteOffset, int byteCount) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal GZIPInputStream() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		///  <para>The <c>GZIPOutputStream </c> class is used to write data to a stream in the GZIP storage format.</para> <para> <h3>Example</h3></para> <para>Using <c>GZIPOutputStream </c> is a little easier than ZipOutputStream because GZIP is only for compression, and is not a container for multiple files. This code creates a GZIP stream, similar to the <c>gzip(1) </c> utility.  <pre>
		/// OutputStream os = ...
		/// byte[] bytes = ...
		/// GZIPOutputStream zos = new GZIPOutputStream(new BufferedOutputStream(os));
		/// try {
		///     zos.write(bytes);
		/// } finally {
		///     zos.close();
		/// }
		/// </pre> </para>    
		/// </summary>
		/// <java-name>
		/// java/util/zip/GZIPOutputStream
		/// </java-name>
		[Dot42.DexImport("java/util/zip/GZIPOutputStream", AccessFlags = 33)]
		public partial class GZIPOutputStream : global::Java.Util.Zip.DeflaterOutputStream
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>The checksum algorithm used when treating uncompressed data. </para>        
				/// </summary>
				/// <java-name>
				/// crc
				/// </java-name>
				[Dot42.DexImport("crc", "Ljava/util/zip/CRC32;", AccessFlags = 4)]
				protected internal global::Java.Util.Zip.CRC32 Crc;
				/// <summary>
				///  <para>Constructs a new <c>GZIPOutputStream </c> to write data in GZIP format to the given stream. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/io/OutputStream;)V", AccessFlags = 1)]
				public GZIPOutputStream(global::Java.IO.OutputStream os) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new <c>GZIPOutputStream </c> to write data in GZIP format to the given stream with the given internal buffer size and flushing behavior (see DeflaterOutputStream#flush). </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/io/OutputStream;I)V", AccessFlags = 1)]
				public GZIPOutputStream(global::Java.IO.OutputStream os, int bufferSize) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Indicates to the stream that all data has been written out, and any GZIP terminal data can now be written.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// finish
				/// </java-name>
				[Dot42.DexImport("finish", "()V", AccessFlags = 1)]
				public override void Finish() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Write up to nbytes of data from the given buffer, starting at offset off, to the underlying stream in GZIP format. </para>        
				/// </summary>
				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([BII)V", AccessFlags = 1, IgnoreFromJava = true)]
				public override void Write(sbyte[] buffer, int off, int nbytes) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Write up to nbytes of data from the given buffer, starting at offset off, to the underlying stream in GZIP format. </para>        
				/// </summary>
				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([BII)V", AccessFlags = 1)]
				public override void Write(byte[] buffer, int off, int nbytes) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal GZIPOutputStream() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		///  <para>The interface common to checksum classes such as Adler32 and CRC32. </para>    
		/// </summary>
		/// <java-name>
		/// java/util/zip/Checksum
		/// </java-name>
		[Dot42.DexImport("java/util/zip/Checksum", AccessFlags = 1537)]
		public partial interface IChecksum
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Resets the checksum value applied before beginning calculations on a new stream of data. </para>        
				/// </summary>
				/// <java-name>
				/// reset
				/// </java-name>
				[Dot42.DexImport("reset", "()V", AccessFlags = 1025)]
				void Reset() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Updates the checksum with the given bytes.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// update
				/// </java-name>
				[Dot42.DexImport("update", "([BII)V", AccessFlags = 1025)]
				void Update(byte[] buf, int off, int nbytes) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Updates the checksum value with the given byte.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// update
				/// </java-name>
				[Dot42.DexImport("update", "(I)V", AccessFlags = 1025)]
				void Update(int val) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns the current calculated checksum value.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the checksum. </para>
				/// </returns>
				/// <java-name>
				/// getValue
				/// </java-name>
				long Value
				{
						[Dot42.DexImport("getValue", "()J", AccessFlags = 1025)]
						get;
				}

		}

		/// <summary>
		///  <para>This class decompresses data that was compressed using the  <b>DEFLATE</b> algorithm (see ).</para> <para>It is usually more convenient to use InflaterInputStream.</para> <para>To decompress an in-memory <c>byte[] </c> to another in-memory <c>byte[] </c> manually:  <pre>
		///     byte[] compressedBytes = ...
		///     int decompressedByteCount = ... // From your format's metadata.
		///     Inflater inflater = new Inflater();
		///     inflater.setInput(compressedBytes, 0, compressedBytes.length);
		///     byte[] decompressedBytes = new byte[decompressedByteCount];
		///     if (inflater.inflate(decompressedBytes) != decompressedByteCount) {
		///         throw new AssertionError();
		///     }
		///     inflater.end();
		/// </pre> </para> <para>In situations where you don't have all the input in one array (or have so much input that you want to feed it to the inflater in chunks), it's possible to call setInput repeatedly, but you're much better off using InflaterInputStream to handle all this for you.</para> <para>If you don't know how big the decompressed data will be, you can call inflate repeatedly on a temporary buffer, copying the bytes to a java.io.ByteArrayOutputStream, but this is probably another sign you'd be better off using InflaterInputStream. </para>    
		/// </summary>
		/// <java-name>
		/// java/util/zip/Inflater
		/// </java-name>
		[Dot42.DexImport("java/util/zip/Inflater", AccessFlags = 33)]
		public partial class Inflater
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>This constructor creates an inflater that expects a header from the input stream. Use Inflater(boolean) if the input comes without a ZLIB header. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Inflater() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>This constructor allows to create an inflater that expects no header from the input stream.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Z)V", AccessFlags = 1)]
				public Inflater(bool noHeader) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Releases resources associated with this <c>Inflater </c> . Any unused input or output is discarded. This method should be called explicitly in order to free native resources as soon as possible. After <c>end() </c> is called, other methods will typically throw <c>IllegalStateException </c> . </para>        
				/// </summary>
				/// <java-name>
				/// end
				/// </java-name>
				[Dot42.DexImport("end", "()V", AccessFlags = 33)]
				public virtual void End() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// finalize
				/// </java-name>
				[Dot42.DexImport("finalize", "()V", AccessFlags = 4)]
				extern ~Inflater() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Indicates if the <c>Inflater </c> has inflated the entire deflated stream. If deflated bytes remain and needsInput returns <c>true </c> this method will return <c>false </c> . This method should be called after all deflated input is supplied to the <c>Inflater </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if all input has been inflated, <c>false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// finished
				/// </java-name>
				[Dot42.DexImport("finished", "()Z", AccessFlags = 33)]
				public virtual bool Finished() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Inflates bytes from the current input and stores them in <c>buf </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the number of bytes inflated. </para>
				/// </returns>
				/// <java-name>
				/// inflate
				/// </java-name>
				[Dot42.DexImport("inflate", "([B)I", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual int Inflate(sbyte[] buf) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Inflates bytes from the current input and stores them in <c>buf </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the number of bytes inflated. </para>
				/// </returns>
				/// <java-name>
				/// inflate
				/// </java-name>
				[Dot42.DexImport("inflate", "([B)I", AccessFlags = 1)]
				public virtual int Inflate(byte[] buf) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Inflates up to <c>byteCount </c> bytes from the current input and stores them in  <c>buf </c> starting at <c>offset </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the number of bytes inflated. </para>
				/// </returns>
				/// <java-name>
				/// inflate
				/// </java-name>
				[Dot42.DexImport("inflate", "([BII)I", AccessFlags = 33, IgnoreFromJava = true)]
				public virtual int Inflate(sbyte[] buf, int offset, int byteCount) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Inflates up to <c>byteCount </c> bytes from the current input and stores them in  <c>buf </c> starting at <c>offset </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the number of bytes inflated. </para>
				/// </returns>
				/// <java-name>
				/// inflate
				/// </java-name>
				[Dot42.DexImport("inflate", "([BII)I", AccessFlags = 33)]
				public virtual int Inflate(byte[] buf, int offset, int byteCount) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Returns true if the input bytes were compressed with a preset dictionary. This method should be called if the first call to inflate returns 0, to determine whether a dictionary is required. If so, setDictionary should be called with the appropriate dictionary before calling <c>inflate </c> again. Use getAdler to determine which dictionary is required. </para>        
				/// </summary>
				/// <java-name>
				/// needsDictionary
				/// </java-name>
				[Dot42.DexImport("needsDictionary", "()Z", AccessFlags = 33)]
				public virtual bool NeedsDictionary() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Returns true if setInput must be called before inflation can continue. </para>        
				/// </summary>
				/// <java-name>
				/// needsInput
				/// </java-name>
				[Dot42.DexImport("needsInput", "()Z", AccessFlags = 33)]
				public virtual bool NeedsInput() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Resets this <c>Inflater </c> . Should be called prior to inflating a new set of data. </para>        
				/// </summary>
				/// <java-name>
				/// reset
				/// </java-name>
				[Dot42.DexImport("reset", "()V", AccessFlags = 33)]
				public virtual void Reset() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the preset dictionary to be used for inflation to <c>dictionary </c> . See needsDictionary for details. </para>        
				/// </summary>
				/// <java-name>
				/// setDictionary
				/// </java-name>
				[Dot42.DexImport("setDictionary", "([B)V", AccessFlags = 33, IgnoreFromJava = true)]
				public virtual void SetDictionary(sbyte[] dictionary) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the preset dictionary to be used for inflation to <c>dictionary </c> . See needsDictionary for details. </para>        
				/// </summary>
				/// <java-name>
				/// setDictionary
				/// </java-name>
				[Dot42.DexImport("setDictionary", "([B)V", AccessFlags = 33)]
				public virtual void SetDictionary(byte[] dictionary) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the preset dictionary to be used for inflation to a subsequence of <c>dictionary </c> starting at <c>offset </c> and continuing for <c>byteCount </c> bytes. See needsDictionary for details. </para>        
				/// </summary>
				/// <java-name>
				/// setDictionary
				/// </java-name>
				[Dot42.DexImport("setDictionary", "([BII)V", AccessFlags = 33, IgnoreFromJava = true)]
				public virtual void SetDictionary(sbyte[] dictionary, int offset, int byteCount) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the preset dictionary to be used for inflation to a subsequence of <c>dictionary </c> starting at <c>offset </c> and continuing for <c>byteCount </c> bytes. See needsDictionary for details. </para>        
				/// </summary>
				/// <java-name>
				/// setDictionary
				/// </java-name>
				[Dot42.DexImport("setDictionary", "([BII)V", AccessFlags = 33)]
				public virtual void SetDictionary(byte[] dictionary, int offset, int byteCount) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the current input to to be decompressed. This method should only be called if needsInput returns <c>true </c> . </para>        
				/// </summary>
				/// <java-name>
				/// setInput
				/// </java-name>
				[Dot42.DexImport("setInput", "([B)V", AccessFlags = 33, IgnoreFromJava = true)]
				public virtual void SetInput(sbyte[] buf) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the current input to to be decompressed. This method should only be called if needsInput returns <c>true </c> . </para>        
				/// </summary>
				/// <java-name>
				/// setInput
				/// </java-name>
				[Dot42.DexImport("setInput", "([B)V", AccessFlags = 33)]
				public virtual void SetInput(byte[] buf) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the current input to to be decompressed. This method should only be called if needsInput returns <c>true </c> . </para>        
				/// </summary>
				/// <java-name>
				/// setInput
				/// </java-name>
				[Dot42.DexImport("setInput", "([BII)V", AccessFlags = 33, IgnoreFromJava = true)]
				public virtual void SetInput(sbyte[] buf, int offset, int byteCount) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the current input to to be decompressed. This method should only be called if needsInput returns <c>true </c> . </para>        
				/// </summary>
				/// <java-name>
				/// setInput
				/// </java-name>
				[Dot42.DexImport("setInput", "([BII)V", AccessFlags = 33)]
				public virtual void SetInput(byte[] buf, int offset, int byteCount) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns the Adler32 checksum of the bytes inflated so far, or the checksum of the preset dictionary if needsDictionary returns true. </para>        
				/// </summary>
				/// <java-name>
				/// getAdler
				/// </java-name>
				public virtual int Adler
				{
						[Dot42.DexImport("getAdler", "()I", AccessFlags = 33)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns the total number of bytes read by the <c>Inflater </c> . This method is the same as getTotalIn except that it returns a  <c>long </c> value instead of an integer. </para>        
				/// </summary>
				/// <java-name>
				/// getBytesRead
				/// </java-name>
				public virtual long BytesRead
				{
						[Dot42.DexImport("getBytesRead", "()J", AccessFlags = 33)]
						get{ return default(long); }
				}

				/// <summary>
				///  <para>Returns a the total number of bytes written by this <c>Inflater </c> . This method is the same as <c>getTotalOut </c> except it returns a  <c>long </c> value instead of an integer. </para>        
				/// </summary>
				/// <java-name>
				/// getBytesWritten
				/// </java-name>
				public virtual long BytesWritten
				{
						[Dot42.DexImport("getBytesWritten", "()J", AccessFlags = 33)]
						get{ return default(long); }
				}

				/// <summary>
				///  <para>Returns the number of bytes of current input remaining to be read by this inflater. </para>        
				/// </summary>
				/// <java-name>
				/// getRemaining
				/// </java-name>
				public virtual int Remaining
				{
						[Dot42.DexImport("getRemaining", "()I", AccessFlags = 33)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns the total number of bytes of input read by this <c>Inflater </c> . This method is limited to 32 bits; use getBytesRead instead. </para>        
				/// </summary>
				/// <java-name>
				/// getTotalIn
				/// </java-name>
				public virtual int TotalIn
				{
						[Dot42.DexImport("getTotalIn", "()I", AccessFlags = 33)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns the total number of bytes written to the output buffer by this <c>Inflater </c> . The method is limited to 32 bits; use getBytesWritten instead. </para>        
				/// </summary>
				/// <java-name>
				/// getTotalOut
				/// </java-name>
				public virtual int TotalOut
				{
						[Dot42.DexImport("getTotalOut", "()I", AccessFlags = 33)]
						get{ return default(int); }
				}

		}

		/// <summary>
		///  <para>This class provides an implementation of <c>FilterInputStream </c> that decompresses data that was compressed using the  <b>DEFLATE</b> algorithm (see ). Basically it wraps the <c>Inflater </c> class and takes care of the buffering.</para> <para> <para>Inflater </para> <para>DeflaterOutputStream </para></para>    
		/// </summary>
		/// <java-name>
		/// java/util/zip/InflaterInputStream
		/// </java-name>
		[Dot42.DexImport("java/util/zip/InflaterInputStream", AccessFlags = 33)]
		public partial class InflaterInputStream : global::Java.IO.FilterInputStream
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>The inflater used for this stream. </para>        
				/// </summary>
				/// <java-name>
				/// inf
				/// </java-name>
				[Dot42.DexImport("inf", "Ljava/util/zip/Inflater;", AccessFlags = 4)]
				protected internal global::Java.Util.Zip.Inflater Inf;
				/// <summary>
				///  <para>The input buffer used for decompression. </para>        
				/// </summary>
				/// <java-name>
				/// buf
				/// </java-name>
				[Dot42.DexImport("buf", "[B", AccessFlags = 4)]
				protected internal sbyte[] Buf;
				/// <summary>
				///  <para>The length of the buffer. </para>        
				/// </summary>
				/// <java-name>
				/// len
				/// </java-name>
				[Dot42.DexImport("len", "I", AccessFlags = 4)]
				protected internal int Len;
				/// <summary>
				///  <para>This is the most basic constructor. You only need to pass the <c>InputStream </c> from which the compressed data is to be read from. Default settings for the <c>Inflater </c> and internal buffer are be used. In particular the Inflater expects a ZLIB header from the input stream.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/io/InputStream;)V", AccessFlags = 1)]
				public InflaterInputStream(global::Java.IO.InputStream @is) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>This constructor lets you pass a specifically initialized Inflater, for example one that expects no ZLIB header.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/io/InputStream;Ljava/util/zip/Inflater;)V", AccessFlags = 1)]
				public InflaterInputStream(global::Java.IO.InputStream @is, global::Java.Util.Zip.Inflater inflater) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>This constructor lets you specify both the <c>Inflater </c> as well as the internal buffer size to be used.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/io/InputStream;Ljava/util/zip/Inflater;I)V", AccessFlags = 1)]
				public InflaterInputStream(global::Java.IO.InputStream @is, global::Java.Util.Zip.Inflater inflater, int bufferSize) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Reads a single byte of decompressed data.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the byte read. </para>
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
				///  <para>Reads up to <c>byteCount </c> bytes of decompressed data and stores it in  <c>buffer </c> starting at <c>byteOffset </c> . Returns the number of uncompressed bytes read, or -1. </para>        
				/// </summary>
				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([BII)I", AccessFlags = 1, IgnoreFromJava = true)]
				public override int Read(sbyte[] buffer, int byteOffset, int byteCount) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Reads up to <c>byteCount </c> bytes of decompressed data and stores it in  <c>buffer </c> starting at <c>byteOffset </c> . Returns the number of uncompressed bytes read, or -1. </para>        
				/// </summary>
				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([BII)I", AccessFlags = 1)]
				public override int Read(byte[] buffer, int byteOffset, int byteCount) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Fills the input buffer with data to be decompressed.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// fill
				/// </java-name>
				[Dot42.DexImport("fill", "()V", AccessFlags = 4)]
				protected internal virtual void Fill() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Skips up to <c>byteCount </c> bytes of uncompressed data.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the number of uncompressed bytes skipped. </para>
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
				///  <para>Returns 0 when when this stream has exhausted its input; and 1 otherwise. A result of 1 does not guarantee that further bytes can be returned, with or without blocking.</para> <para>Although consistent with the RI, this behavior is inconsistent with InputStream#available(), and violates the . This method should not be used.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>0 if no further bytes are available. Otherwise returns 1, which suggests (but does not guarantee) that additional bytes are available. </para>
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
				///  <para>Closes the input stream.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1)]
				public override void Close() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Marks the current position in the stream. This implementation overrides the super type implementation to do nothing at all.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// mark
				/// </java-name>
				[Dot42.DexImport("mark", "(I)V", AccessFlags = 1)]
				public override void Mark(int readlimit) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Reset the position of the stream to the last marked position. This implementation overrides the supertype implementation and always throws an IOException when called.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// reset
				/// </java-name>
				[Dot42.DexImport("reset", "()V", AccessFlags = 1)]
				public override void Reset() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns whether the receiver implements <c>mark </c> semantics. This type does not support <c>mark() </c> , so always responds <c>false </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>false, always </para>
				/// </returns>
				/// <java-name>
				/// markSupported
				/// </java-name>
				[Dot42.DexImport("markSupported", "()Z", AccessFlags = 1)]
				public override bool MarkSupported() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal InflaterInputStream() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		///  <para>An entry within a zip file. An entry has attributes such as its name (which is actually a path) and the uncompressed size of the corresponding data. An entry does not contain the data itself, but can be used as a key with ZipFile#getInputStream. The class documentation for ZipInputStream and ZipOutputStream shows how <c>ZipEntry </c> is used in conjunction with those two classes. </para>    
		/// </summary>
		/// <java-name>
		/// java/util/zip/ZipEntry
		/// </java-name>
		[Dot42.DexImport("java/util/zip/ZipEntry", AccessFlags = 33)]
		public partial class ZipEntry : global::Java.Lang.ICloneable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Zip entry state: Deflated. </para>        
				/// </summary>
				/// <java-name>
				/// DEFLATED
				/// </java-name>
				[Dot42.DexImport("DEFLATED", "I", AccessFlags = 25)]
				public const int DEFLATED = 8;
				/// <summary>
				///  <para>Zip entry state: Stored. </para>        
				/// </summary>
				/// <java-name>
				/// STORED
				/// </java-name>
				[Dot42.DexImport("STORED", "I", AccessFlags = 25)]
				public const int STORED = 0;
				/// <summary>
				///  <para>Constructs a new <c>ZipEntry </c> using the values obtained from <c>ze </c> .</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public ZipEntry(string ze) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new <c>ZipEntry </c> using the values obtained from <c>ze </c> .</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/util/zip/ZipEntry;)V", AccessFlags = 1)]
				public ZipEntry(global::Java.Util.Zip.ZipEntry ze) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Gets the extra information for this <c>ZipEntry </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a byte array containing the extra information, or <c>null </c> if there is none. </para>
				/// </returns>
				/// <java-name>
				/// getExtra
				/// </java-name>
				[Dot42.DexImport("getExtra", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual sbyte[] JavaGetExtra() /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <summary>
				///  <para>Sets the extra information for this <c>ZipEntry </c> .</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setExtra
				/// </java-name>
				[Dot42.DexImport("setExtra", "([B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual void SetExtra(sbyte[] data) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns the string representation of this <c>ZipEntry </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the string representation of this <c>ZipEntry </c> . </para>
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
				///  <para>Returns a deep copy of this zip entry. </para>        
				/// </summary>
				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/lang/Object;", AccessFlags = 1)]
				public virtual object Clone() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <summary>
				///  <para>Returns the hash code for this <c>ZipEntry </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the hash code of the entry. </para>
				/// </returns>
				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 1)]
				public override int GetHashCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal ZipEntry() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Returns the comment for this <c>ZipEntry </c> , or <c>null </c> if there is no comment. If we're reading a zip file using <c>ZipInputStream </c> , the comment is not available. </para>        
				/// </summary>
				/// <java-name>
				/// getComment
				/// </java-name>
				public virtual string Comment
				{
						[Dot42.DexImport("getComment", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
						[Dot42.DexImport("setComment", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Gets the compressed size of this <c>ZipEntry </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the compressed size, or -1 if the compressed size has not been set. </para>
				/// </returns>
				/// <java-name>
				/// getCompressedSize
				/// </java-name>
				public virtual long CompressedSize
				{
						[Dot42.DexImport("getCompressedSize", "()J", AccessFlags = 1)]
						get{ return default(long); }
						[Dot42.DexImport("setCompressedSize", "(J)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Gets the checksum for this <c>ZipEntry </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the checksum, or -1 if the checksum has not been set. </para>
				/// </returns>
				/// <java-name>
				/// getCrc
				/// </java-name>
				public virtual long Crc
				{
						[Dot42.DexImport("getCrc", "()J", AccessFlags = 1)]
						get{ return default(long); }
						[Dot42.DexImport("setCrc", "(J)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Gets the extra information for this <c>ZipEntry </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a byte array containing the extra information, or <c>null </c> if there is none. </para>
				/// </returns>
				/// <java-name>
				/// getExtra
				/// </java-name>
				public virtual byte[] Extra
				{
						[Dot42.DexImport("getExtra", "()[B", AccessFlags = 1)]
						get{ return default(byte[]); }
						[Dot42.DexImport("setExtra", "([B)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Gets the compression method for this <c>ZipEntry </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the compression method, either <c>DEFLATED </c> , <c>STORED </c> or -1 if the compression method has not been set. </para>
				/// </returns>
				/// <java-name>
				/// getMethod
				/// </java-name>
				public virtual int Method
				{
						[Dot42.DexImport("getMethod", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setMethod", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Gets the name of this <c>ZipEntry </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the entry name. </para>
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
				///  <para>Gets the uncompressed size of this <c>ZipEntry </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the uncompressed size, or <c>-1 </c> if the size has not been set. </para>
				/// </returns>
				/// <java-name>
				/// getSize
				/// </java-name>
				public virtual long Size
				{
						[Dot42.DexImport("getSize", "()J", AccessFlags = 1)]
						get{ return default(long); }
						[Dot42.DexImport("setSize", "(J)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Gets the last modification time of this <c>ZipEntry </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the last modification time as the number of milliseconds since Jan. 1, 1970. </para>
				/// </returns>
				/// <java-name>
				/// getTime
				/// </java-name>
				public virtual long Time
				{
						[Dot42.DexImport("getTime", "()J", AccessFlags = 1)]
						get{ return default(long); }
						[Dot42.DexImport("setTime", "(J)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Determine whether or not this <c>ZipEntry </c> is a directory.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> when this <c>ZipEntry </c> is a directory, <c>false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isDirectory
				/// </java-name>
				public virtual bool IsDirectory
				{
						[Dot42.DexImport("isDirectory", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

		}

		/// <summary>
		///  <para>This runtime exception is thrown by <c>ZipFile </c> and <c>ZipInputStream </c> when the file or stream is not a valid zip file.</para> <para> <para>ZipFile </para> <para>ZipInputStream </para></para>    
		/// </summary>
		/// <java-name>
		/// java/util/zip/ZipException
		/// </java-name>
		[Dot42.DexImport("java/util/zip/ZipException", AccessFlags = 33)]
		public partial class ZipException : global::System.IO.IOException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructs a new <c>ZipException </c> instance. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ZipException() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new <c>ZipException </c> instance with the specified message.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public ZipException(string detailMessage) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>This class provides random read access to a zip file. You pay more to read the zip file's central directory up front (from the constructor), but if you're using getEntry to look up multiple files by name, you get the benefit of this index.</para> <para>If you only want to iterate through all the files (using entries(), you should consider ZipInputStream, which provides stream-like read access to a zip file and has a lower up-front cost because you don't pay to build an in-memory index.</para> <para>If you want to create a zip file, use ZipOutputStream. There is no API for updating an existing zip file. </para>    
		/// </summary>
		/// <java-name>
		/// java/util/zip/ZipFile
		/// </java-name>
		[Dot42.DexImport("java/util/zip/ZipFile", AccessFlags = 33)]
		public partial class ZipFile
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Open zip file for reading. </para>        
				/// </summary>
				/// <java-name>
				/// OPEN_READ
				/// </java-name>
				[Dot42.DexImport("OPEN_READ", "I", AccessFlags = 25)]
				public const int OPEN_READ = 1;
				/// <summary>
				///  <para>Delete zip file when closed. </para>        
				/// </summary>
				/// <java-name>
				/// OPEN_DELETE
				/// </java-name>
				[Dot42.DexImport("OPEN_DELETE", "I", AccessFlags = 25)]
				public const int OPEN_DELETE = 4;
				/// <summary>
				///  <para>Constructs a new <c>ZipFile </c> allowing read access to the contents of the given file. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/io/File;)V", AccessFlags = 1)]
				public ZipFile(global::Java.IO.File file) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new <c>ZipFile </c> allowing access to the given file. The <c>mode </c> must be either <c>OPEN_READ </c> or <c>OPEN_READ|OPEN_DELETE </c> .</para> <para>If the <c>OPEN_DELETE </c> flag is supplied, the file will be deleted at or before the time that the <c>ZipFile </c> is closed (the contents will remain accessible until this <c>ZipFile </c> is closed); it also calls <c>File.deleteOnExit </c> .</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/io/File;I)V", AccessFlags = 1)]
				public ZipFile(global::Java.IO.File file, int mode) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new <c>ZipFile </c> allowing read access to the contents of the given file. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public ZipFile(string file) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// finalize
				/// </java-name>
				[Dot42.DexImport("finalize", "()V", AccessFlags = 4)]
				extern ~ZipFile() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Closes this zip file. This method is idempotent. This method may cause I/O if the zip file needs to be deleted.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1)]
				public virtual void Close() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns an enumeration of the entries. The entries are listed in the order in which they appear in the zip file.</para> <para>If you only need to iterate over the entries in a zip file, and don't need random-access entry lookup by name, you should probably use ZipInputStream instead, to avoid paying to construct the in-memory index.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// entries
				/// </java-name>
				[Dot42.DexImport("entries", "()Ljava/util/Enumeration;", AccessFlags = 1, Signature = "()Ljava/util/Enumeration<+Ljava/util/zip/ZipEntry;>;")]
				public virtual global::Java.Util.IEnumeration<global::Java.Util.Zip.ZipEntry> Entries() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IEnumeration<global::Java.Util.Zip.ZipEntry>);
				}

				/// <summary>
				///  <para>Returns the zip entry with the given name, or null if there is no such entry.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// getEntry
				/// </java-name>
				[Dot42.DexImport("getEntry", "(Ljava/lang/String;)Ljava/util/zip/ZipEntry;", AccessFlags = 1)]
				public virtual global::Java.Util.Zip.ZipEntry GetEntry(string entryName) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Zip.ZipEntry);
				}

				/// <summary>
				///  <para>Returns an input stream on the data of the specified <c>ZipEntry </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>an input stream of the data contained in the <c>ZipEntry </c> . </para>
				/// </returns>
				/// <java-name>
				/// getInputStream
				/// </java-name>
				[Dot42.DexImport("getInputStream", "(Ljava/util/zip/ZipEntry;)Ljava/io/InputStream;", AccessFlags = 1)]
				public virtual global::Java.IO.InputStream GetInputStream(global::Java.Util.Zip.ZipEntry entry) /* MethodBuilder.Create */ 
				{
						return default(global::Java.IO.InputStream);
				}

				/// <summary>
				///  <para>Returns the number of <c>ZipEntries </c> in this <c>ZipFile </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the number of entries in this file. </para>
				/// </returns>
				/// <java-name>
				/// size
				/// </java-name>
				[Dot42.DexImport("size", "()I", AccessFlags = 1)]
				public virtual int Size() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal ZipFile() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Gets the file name of this <c>ZipFile </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the file name of this <c>ZipFile </c> . </para>
				/// </returns>
				/// <java-name>
				/// getName
				/// </java-name>
				public virtual string Name
				{
						[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

		}

		/// <summary>
		///  <para>Used to read (decompress) the data from zip files.</para> <para>A zip file (or "archive") is a collection of (possibly) compressed files. When reading from a <c>ZipInputStream </c> , you call getNextEntry which returns a ZipEntry of metadata corresponding to the userdata that follows. When you appear to have hit the end of this stream (which is really just the end of the current entry's userdata), call <c>getNextEntry </c> again. When it returns null, there are no more entries in the input file.</para> <para>Although <c>InflaterInputStream </c> can only read compressed zip entries, this class can read non-compressed entries as well.</para> <para>Use ZipFile if you need random access to entries by name, but use this class if you just want to iterate over all entries.</para> <para> <h3>Example</h3></para> <para>Using <c>ZipInputStream </c> is a little more complicated than GZIPInputStream because zip files are containers that can contain multiple files. This code pulls all the files out of a zip file, similar to the <c>unzip(1) </c> utility.  <pre>
		/// InputStream is = ...
		/// ZipInputStream zis = new ZipInputStream(new BufferedInputStream(is));
		/// try {
		///     ZipEntry ze;
		///     while ((ze = zis.getNextEntry()) != null) {
		///         ByteArrayOutputStream baos = new ByteArrayOutputStream();
		///         byte[] buffer = new byte[1024];
		///         int count;
		///         while ((count = zis.read(buffer)) != -1) {
		///             baos.write(buffer, 0, count);
		///         }
		///         String filename = ze.getName();
		///         byte[] bytes = baos.toByteArray();
		///         // do something with 'filename' and 'bytes'...
		///     }
		/// } finally {
		///     zis.close();
		/// }
		/// </pre> </para>    
		/// </summary>
		/// <java-name>
		/// java/util/zip/ZipInputStream
		/// </java-name>
		[Dot42.DexImport("java/util/zip/ZipInputStream", AccessFlags = 33)]
		public partial class ZipInputStream : global::Java.Util.Zip.InflaterInputStream
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructs a new <c>ZipInputStream </c> to read zip entries from the given input stream. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/io/InputStream;)V", AccessFlags = 1)]
				public ZipInputStream(global::Java.IO.InputStream stream) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Closes this <c>ZipInputStream </c> .</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1)]
				public override void Close() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Closes the current zip entry and prepares to read the next entry.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// closeEntry
				/// </java-name>
				[Dot42.DexImport("closeEntry", "()V", AccessFlags = 1)]
				public virtual void CloseEntry() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Reads up to <c>byteCount </c> uncompressed bytes into the buffer starting at <c>byteOffset </c> . Returns the number of bytes actually read, or -1. </para>        
				/// </summary>
				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([BII)I", AccessFlags = 1, IgnoreFromJava = true)]
				public override int Read(sbyte[] buffer, int byteOffset, int byteCount) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Reads up to <c>byteCount </c> uncompressed bytes into the buffer starting at <c>byteOffset </c> . Returns the number of bytes actually read, or -1. </para>        
				/// </summary>
				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([BII)I", AccessFlags = 1)]
				public override int Read(byte[] buffer, int byteOffset, int byteCount) /* MethodBuilder.Create */ 
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

				/// <java-name>
				/// available
				/// </java-name>
				[Dot42.DexImport("available", "()I", AccessFlags = 1)]
				public override int Available() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>creates a ZipEntry with the given name.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the created <c>ZipEntry </c> . </para>
				/// </returns>
				/// <java-name>
				/// createZipEntry
				/// </java-name>
				[Dot42.DexImport("createZipEntry", "(Ljava/lang/String;)Ljava/util/zip/ZipEntry;", AccessFlags = 4)]
				protected internal virtual global::Java.Util.Zip.ZipEntry CreateZipEntry(string name) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Zip.ZipEntry);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal ZipInputStream() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Returns the next entry from this <c>ZipInputStream </c> or <c>null </c> if no more entries are present.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// getNextEntry
				/// </java-name>
				public virtual global::Java.Util.Zip.ZipEntry NextEntry
				{
						[Dot42.DexImport("getNextEntry", "()Ljava/util/zip/ZipEntry;", AccessFlags = 1)]
						get{ return default(global::Java.Util.Zip.ZipEntry); }
				}

		}

		/// <summary>
		///  <para>Used to write (compress) data into zip files.</para> <para> <c>ZipOutputStream </c> is used to write ZipEntrys to the underlying stream. Output from <c>ZipOutputStream </c> can be read using ZipFile or ZipInputStream.</para> <para>While <c>DeflaterOutputStream </c> can write compressed zip file entries, this extension can write uncompressed entries as well. Use ZipEntry#setMethod or setMethod with the ZipEntry#STORED flag.</para> <para> <h3>Example</h3></para> <para>Using <c>ZipOutputStream </c> is a little more complicated than GZIPOutputStream because zip files are containers that can contain multiple files. This code creates a zip file containing several files, similar to the <c>zip(1) </c> utility.  <pre>
		/// OutputStream os = ...
		/// ZipOutputStream zos = new ZipOutputStream(new BufferedOutputStream(os));
		/// try {
		///     for (int i = 0; i &lt; fileCount; ++i) {
		///         String filename = ...
		///         byte[] bytes = ...
		///         ZipEntry entry = new ZipEntry(filename);
		///         zos.putNextEntry(entry);
		///         zos.write(bytes);
		///         zos.closeEntry();
		///     }
		/// } finally {
		///     zos.close();
		/// }
		/// </pre> </para>    
		/// </summary>
		/// <java-name>
		/// java/util/zip/ZipOutputStream
		/// </java-name>
		[Dot42.DexImport("java/util/zip/ZipOutputStream", AccessFlags = 33)]
		public partial class ZipOutputStream : global::Java.Util.Zip.DeflaterOutputStream
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Indicates deflated entries. </para>        
				/// </summary>
				/// <java-name>
				/// DEFLATED
				/// </java-name>
				[Dot42.DexImport("DEFLATED", "I", AccessFlags = 25)]
				public const int DEFLATED = 8;
				/// <summary>
				///  <para>Indicates uncompressed entries. </para>        
				/// </summary>
				/// <java-name>
				/// STORED
				/// </java-name>
				[Dot42.DexImport("STORED", "I", AccessFlags = 25)]
				public const int STORED = 0;
				/// <summary>
				///  <para>Constructs a new <c>ZipOutputStream </c> that writes a zip file to the given <c>OutputStream </c> . </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/io/OutputStream;)V", AccessFlags = 1)]
				public ZipOutputStream(global::Java.IO.OutputStream os) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Closes the current <c>ZipEntry </c> , if any, and the underlying output stream. If the stream is already closed this method does nothing.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1)]
				public override void Close() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Closes the current <c>ZipEntry </c> . Any entry terminal data is written to the underlying stream.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// closeEntry
				/// </java-name>
				[Dot42.DexImport("closeEntry", "()V", AccessFlags = 1)]
				public virtual void CloseEntry() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Indicates that all entries have been written to the stream. Any terminal information is written to the underlying stream.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// finish
				/// </java-name>
				[Dot42.DexImport("finish", "()V", AccessFlags = 1)]
				public override void Finish() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Writes entry information to the underlying stream. Data associated with the entry can then be written using <c>write() </c> . After data is written <c>closeEntry() </c> must be called to complete the writing of the entry to the underlying stream.</para> <para> <para>write </para></para>        
				/// </summary>
				/// <java-name>
				/// putNextEntry
				/// </java-name>
				[Dot42.DexImport("putNextEntry", "(Ljava/util/zip/ZipEntry;)V", AccessFlags = 1)]
				public virtual void PutNextEntry(global::Java.Util.Zip.ZipEntry ze) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the comment associated with the file being written. See ZipFile#getComment. </para>        
				/// </summary>
				/// <java-name>
				/// setComment
				/// </java-name>
				[Dot42.DexImport("setComment", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetComment(string comment) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the  to be used for writing entry data. </para>        
				/// </summary>
				/// <java-name>
				/// setLevel
				/// </java-name>
				[Dot42.DexImport("setLevel", "(I)V", AccessFlags = 1)]
				public virtual void SetLevel(int level) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the default compression method to be used when a <c>ZipEntry </c> doesn't explicitly specify a method. See ZipEntry#setMethod for more details. </para>        
				/// </summary>
				/// <java-name>
				/// setMethod
				/// </java-name>
				[Dot42.DexImport("setMethod", "(I)V", AccessFlags = 1)]
				public virtual void SetMethod(int method) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Writes data for the current entry to the underlying stream.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([BII)V", AccessFlags = 1, IgnoreFromJava = true)]
				public override void Write(sbyte[] buffer, int offset, int byteCount) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Writes data for the current entry to the underlying stream.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([BII)V", AccessFlags = 1)]
				public override void Write(byte[] buffer, int offset, int byteCount) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal ZipOutputStream() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

}

