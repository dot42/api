#pragma warning disable 1717
namespace Java.Util.Zip
{
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

				/// <java-name>
				/// reset
				/// </java-name>
				[Dot42.DexImport("reset", "()V", AccessFlags = 1)]
				public virtual void Reset() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// update
				/// </java-name>
				[Dot42.DexImport("update", "(I)V", AccessFlags = 1)]
				public virtual void Update(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// update
				/// </java-name>
				[Dot42.DexImport("update", "([B)V", AccessFlags = 1)]
				public virtual void Update(sbyte[] sByte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// update
				/// </java-name>
				[Dot42.DexImport("update", "([B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual void Update(byte[] @byte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// update
				/// </java-name>
				[Dot42.DexImport("update", "([BII)V", AccessFlags = 1)]
				public virtual void Update(sbyte[] sByte, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// update
				/// </java-name>
				[Dot42.DexImport("update", "([BII)V", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual void Update(byte[] @byte, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getValue
				/// </java-name>
				public virtual long Value
				{
						[Dot42.DexImport("getValue", "()J", AccessFlags = 1)]
						get{ return default(long); }
				}

		}

		/// <java-name>
		/// java/util/zip/CheckedInputStream
		/// </java-name>
		[Dot42.DexImport("java/util/zip/CheckedInputStream", AccessFlags = 33)]
		public partial class CheckedInputStream : global::Java.Io.FilterInputStream
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/io/InputStream;Ljava/util/zip/Checksum;)V", AccessFlags = 1)]
				public CheckedInputStream(global::Java.Io.InputStream inputStream, global::Java.Util.Zip.IChecksum checksum) /* MethodBuilder.Create */ 
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
				[Dot42.DexImport("read", "([BII)I", AccessFlags = 1)]
				public override int Read(sbyte[] sByte, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([BII)I", AccessFlags = 1, IgnoreFromJava = true)]
				public override int Read(byte[] @byte, int int32, int int321) /* MethodBuilder.Create */ 
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
				internal CheckedInputStream() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getChecksum
				/// </java-name>
				public virtual global::Java.Util.Zip.IChecksum Checksum
				{
						[Dot42.DexImport("getChecksum", "()Ljava/util/zip/Checksum;", AccessFlags = 1)]
						get{ return default(global::Java.Util.Zip.IChecksum); }
				}

		}

		/// <java-name>
		/// java/util/zip/CheckedOutputStream
		/// </java-name>
		[Dot42.DexImport("java/util/zip/CheckedOutputStream", AccessFlags = 33)]
		public partial class CheckedOutputStream : global::Java.Io.FilterOutputStream
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/io/OutputStream;Ljava/util/zip/Checksum;)V", AccessFlags = 1)]
				public CheckedOutputStream(global::Java.Io.OutputStream outputStream, global::Java.Util.Zip.IChecksum checksum) /* MethodBuilder.Create */ 
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
				[Dot42.DexImport("write", "([BII)V", AccessFlags = 1)]
				public override void Write(sbyte[] sByte, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([BII)V", AccessFlags = 1, IgnoreFromJava = true)]
				public override void Write(byte[] @byte, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal CheckedOutputStream() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getChecksum
				/// </java-name>
				public virtual global::Java.Util.Zip.IChecksum Checksum
				{
						[Dot42.DexImport("getChecksum", "()Ljava/util/zip/Checksum;", AccessFlags = 1)]
						get{ return default(global::Java.Util.Zip.IChecksum); }
				}

		}

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

				/// <java-name>
				/// reset
				/// </java-name>
				[Dot42.DexImport("reset", "()V", AccessFlags = 1)]
				public virtual void Reset() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// update
				/// </java-name>
				[Dot42.DexImport("update", "(I)V", AccessFlags = 1)]
				public virtual void Update(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// update
				/// </java-name>
				[Dot42.DexImport("update", "([B)V", AccessFlags = 1)]
				public virtual void Update(sbyte[] sByte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// update
				/// </java-name>
				[Dot42.DexImport("update", "([B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual void Update(byte[] @byte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// update
				/// </java-name>
				[Dot42.DexImport("update", "([BII)V", AccessFlags = 1)]
				public virtual void Update(sbyte[] sByte, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// update
				/// </java-name>
				[Dot42.DexImport("update", "([BII)V", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual void Update(byte[] @byte, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getValue
				/// </java-name>
				public virtual long Value
				{
						[Dot42.DexImport("getValue", "()J", AccessFlags = 1)]
						get{ return default(long); }
				}

		}

		/// <java-name>
		/// java/util/zip/DataFormatException
		/// </java-name>
		[Dot42.DexImport("java/util/zip/DataFormatException", AccessFlags = 33)]
		public partial class DataFormatException : global::System.Exception
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public DataFormatException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public DataFormatException(string @string) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/util/zip/Deflater
		/// </java-name>
		[Dot42.DexImport("java/util/zip/Deflater", AccessFlags = 33)]
		public partial class Deflater
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// BEST_COMPRESSION
				/// </java-name>
				[Dot42.DexImport("BEST_COMPRESSION", "I", AccessFlags = 25)]
				public const int BEST_COMPRESSION = 9;
				/// <java-name>
				/// BEST_SPEED
				/// </java-name>
				[Dot42.DexImport("BEST_SPEED", "I", AccessFlags = 25)]
				public const int BEST_SPEED = 1;
				/// <java-name>
				/// DEFAULT_COMPRESSION
				/// </java-name>
				[Dot42.DexImport("DEFAULT_COMPRESSION", "I", AccessFlags = 25)]
				public const int DEFAULT_COMPRESSION = -1;
				/// <java-name>
				/// DEFAULT_STRATEGY
				/// </java-name>
				[Dot42.DexImport("DEFAULT_STRATEGY", "I", AccessFlags = 25)]
				public const int DEFAULT_STRATEGY = 0;
				/// <java-name>
				/// DEFLATED
				/// </java-name>
				[Dot42.DexImport("DEFLATED", "I", AccessFlags = 25)]
				public const int DEFLATED = 8;
				/// <java-name>
				/// FILTERED
				/// </java-name>
				[Dot42.DexImport("FILTERED", "I", AccessFlags = 25)]
				public const int FILTERED = 1;
				/// <java-name>
				/// HUFFMAN_ONLY
				/// </java-name>
				[Dot42.DexImport("HUFFMAN_ONLY", "I", AccessFlags = 25)]
				public const int HUFFMAN_ONLY = 2;
				/// <java-name>
				/// NO_COMPRESSION
				/// </java-name>
				[Dot42.DexImport("NO_COMPRESSION", "I", AccessFlags = 25)]
				public const int NO_COMPRESSION = 0;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Deflater() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public Deflater(int int32) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(IZ)V", AccessFlags = 1)]
				public Deflater(int int32, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// deflate
				/// </java-name>
				[Dot42.DexImport("deflate", "([B)I", AccessFlags = 1)]
				public virtual int Deflate(sbyte[] sByte) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// deflate
				/// </java-name>
				[Dot42.DexImport("deflate", "([B)I", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual int Deflate(byte[] @byte) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// deflate
				/// </java-name>
				[Dot42.DexImport("deflate", "([BII)I", AccessFlags = 33)]
				public virtual int Deflate(sbyte[] sByte, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// deflate
				/// </java-name>
				[Dot42.DexImport("deflate", "([BII)I", AccessFlags = 33, IgnoreFromJava = true)]
				public virtual int Deflate(byte[] @byte, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

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

				/// <java-name>
				/// finish
				/// </java-name>
				[Dot42.DexImport("finish", "()V", AccessFlags = 33)]
				public virtual void Finish() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// finished
				/// </java-name>
				[Dot42.DexImport("finished", "()Z", AccessFlags = 33)]
				public virtual bool Finished() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// needsInput
				/// </java-name>
				[Dot42.DexImport("needsInput", "()Z", AccessFlags = 33)]
				public virtual bool NeedsInput() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// reset
				/// </java-name>
				[Dot42.DexImport("reset", "()V", AccessFlags = 33)]
				public virtual void Reset() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setDictionary
				/// </java-name>
				[Dot42.DexImport("setDictionary", "([B)V", AccessFlags = 1)]
				public virtual void SetDictionary(sbyte[] sByte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setDictionary
				/// </java-name>
				[Dot42.DexImport("setDictionary", "([B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual void SetDictionary(byte[] @byte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setDictionary
				/// </java-name>
				[Dot42.DexImport("setDictionary", "([BII)V", AccessFlags = 33)]
				public virtual void SetDictionary(sbyte[] sByte, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setDictionary
				/// </java-name>
				[Dot42.DexImport("setDictionary", "([BII)V", AccessFlags = 33, IgnoreFromJava = true)]
				public virtual void SetDictionary(byte[] @byte, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setInput
				/// </java-name>
				[Dot42.DexImport("setInput", "([B)V", AccessFlags = 1)]
				public virtual void SetInput(sbyte[] sByte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setInput
				/// </java-name>
				[Dot42.DexImport("setInput", "([B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual void SetInput(byte[] @byte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setInput
				/// </java-name>
				[Dot42.DexImport("setInput", "([BII)V", AccessFlags = 33)]
				public virtual void SetInput(sbyte[] sByte, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setInput
				/// </java-name>
				[Dot42.DexImport("setInput", "([BII)V", AccessFlags = 33, IgnoreFromJava = true)]
				public virtual void SetInput(byte[] @byte, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setLevel
				/// </java-name>
				[Dot42.DexImport("setLevel", "(I)V", AccessFlags = 33)]
				public virtual void SetLevel(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setStrategy
				/// </java-name>
				[Dot42.DexImport("setStrategy", "(I)V", AccessFlags = 33)]
				public virtual void SetStrategy(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getAdler
				/// </java-name>
				public virtual int Adler
				{
						[Dot42.DexImport("getAdler", "()I", AccessFlags = 33)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getTotalIn
				/// </java-name>
				public virtual int TotalIn
				{
						[Dot42.DexImport("getTotalIn", "()I", AccessFlags = 33)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getTotalOut
				/// </java-name>
				public virtual int TotalOut
				{
						[Dot42.DexImport("getTotalOut", "()I", AccessFlags = 33)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getBytesRead
				/// </java-name>
				public virtual long BytesRead
				{
						[Dot42.DexImport("getBytesRead", "()J", AccessFlags = 33)]
						get{ return default(long); }
				}

				/// <java-name>
				/// getBytesWritten
				/// </java-name>
				public virtual long BytesWritten
				{
						[Dot42.DexImport("getBytesWritten", "()J", AccessFlags = 33)]
						get{ return default(long); }
				}

		}

		/// <java-name>
		/// java/util/zip/DeflaterInputStream
		/// </java-name>
		[Dot42.DexImport("java/util/zip/DeflaterInputStream", AccessFlags = 33)]
		public partial class DeflaterInputStream : global::Java.Io.FilterInputStream
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// def
				/// </java-name>
				[Dot42.DexImport("def", "Ljava/util/zip/Deflater;", AccessFlags = 20)]
				protected internal readonly global::Java.Util.Zip.Deflater Def;
				/// <java-name>
				/// buf
				/// </java-name>
				[Dot42.DexImport("buf", "[B", AccessFlags = 20)]
				protected internal readonly sbyte[] Buf;
				[Dot42.DexImport("<init>", "(Ljava/io/InputStream;)V", AccessFlags = 1)]
				public DeflaterInputStream(global::Java.Io.InputStream inputStream) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/io/InputStream;Ljava/util/zip/Deflater;)V", AccessFlags = 1)]
				public DeflaterInputStream(global::Java.Io.InputStream inputStream, global::Java.Util.Zip.Deflater deflater) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/io/InputStream;Ljava/util/zip/Deflater;I)V", AccessFlags = 1)]
				public DeflaterInputStream(global::Java.Io.InputStream inputStream, global::Java.Util.Zip.Deflater deflater, int int32) /* MethodBuilder.Create */ 
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
				[Dot42.DexImport("read", "([BII)I", AccessFlags = 1)]
				public override int Read(sbyte[] sByte, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([BII)I", AccessFlags = 1, IgnoreFromJava = true)]
				public override int Read(byte[] @byte, int int32, int int321) /* MethodBuilder.Create */ 
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

				/// <java-name>
				/// markSupported
				/// </java-name>
				[Dot42.DexImport("markSupported", "()Z", AccessFlags = 1)]
				public override bool MarkSupported() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// mark
				/// </java-name>
				[Dot42.DexImport("mark", "(I)V", AccessFlags = 1)]
				public override void Mark(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// reset
				/// </java-name>
				[Dot42.DexImport("reset", "()V", AccessFlags = 1)]
				public override void Reset() /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal DeflaterInputStream() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// java/util/zip/DeflaterOutputStream
		/// </java-name>
		[Dot42.DexImport("java/util/zip/DeflaterOutputStream", AccessFlags = 33)]
		public partial class DeflaterOutputStream : global::Java.Io.FilterOutputStream
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// buf
				/// </java-name>
				[Dot42.DexImport("buf", "[B", AccessFlags = 4)]
				protected internal sbyte[] Buf;
				/// <java-name>
				/// def
				/// </java-name>
				[Dot42.DexImport("def", "Ljava/util/zip/Deflater;", AccessFlags = 4)]
				protected internal global::Java.Util.Zip.Deflater Def;
				[Dot42.DexImport("<init>", "(Ljava/io/OutputStream;Ljava/util/zip/Deflater;)V", AccessFlags = 1)]
				public DeflaterOutputStream(global::Java.Io.OutputStream outputStream, global::Java.Util.Zip.Deflater deflater) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/io/OutputStream;)V", AccessFlags = 1)]
				public DeflaterOutputStream(global::Java.Io.OutputStream outputStream) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/io/OutputStream;Ljava/util/zip/Deflater;I)V", AccessFlags = 1)]
				public DeflaterOutputStream(global::Java.Io.OutputStream outputStream, global::Java.Util.Zip.Deflater deflater, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// deflate
				/// </java-name>
				[Dot42.DexImport("deflate", "()V", AccessFlags = 4)]
				protected internal virtual void Deflate() /* MethodBuilder.Create */ 
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
				[Dot42.DexImport("write", "([BII)V", AccessFlags = 1)]
				public override void Write(sbyte[] sByte, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([BII)V", AccessFlags = 1, IgnoreFromJava = true)]
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

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal DeflaterOutputStream() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// java/util/zip/GZIPInputStream
		/// </java-name>
		[Dot42.DexImport("java/util/zip/GZIPInputStream", AccessFlags = 33)]
		public partial class GZIPInputStream : global::Java.Util.Zip.InflaterInputStream
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// GZIP_MAGIC
				/// </java-name>
				[Dot42.DexImport("GZIP_MAGIC", "I", AccessFlags = 25)]
				public const int GZIP_MAGIC = 35615;
				/// <java-name>
				/// crc
				/// </java-name>
				[Dot42.DexImport("crc", "Ljava/util/zip/CRC32;", AccessFlags = 4)]
				protected internal global::Java.Util.Zip.CRC32 Crc;
				/// <java-name>
				/// eos
				/// </java-name>
				[Dot42.DexImport("eos", "Z", AccessFlags = 4)]
				protected internal bool Eos;
				[Dot42.DexImport("<init>", "(Ljava/io/InputStream;)V", AccessFlags = 1)]
				public GZIPInputStream(global::Java.Io.InputStream inputStream) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/io/InputStream;I)V", AccessFlags = 1)]
				public GZIPInputStream(global::Java.Io.InputStream inputStream, int int32) /* MethodBuilder.Create */ 
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
				[Dot42.DexImport("read", "([BII)I", AccessFlags = 1)]
				public override int Read(sbyte[] sByte, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([BII)I", AccessFlags = 1, IgnoreFromJava = true)]
				public override int Read(byte[] @byte, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal GZIPInputStream() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// java/util/zip/GZIPOutputStream
		/// </java-name>
		[Dot42.DexImport("java/util/zip/GZIPOutputStream", AccessFlags = 33)]
		public partial class GZIPOutputStream : global::Java.Util.Zip.DeflaterOutputStream
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// crc
				/// </java-name>
				[Dot42.DexImport("crc", "Ljava/util/zip/CRC32;", AccessFlags = 4)]
				protected internal global::Java.Util.Zip.CRC32 Crc;
				[Dot42.DexImport("<init>", "(Ljava/io/OutputStream;)V", AccessFlags = 1)]
				public GZIPOutputStream(global::Java.Io.OutputStream outputStream) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/io/OutputStream;I)V", AccessFlags = 1)]
				public GZIPOutputStream(global::Java.Io.OutputStream outputStream, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// finish
				/// </java-name>
				[Dot42.DexImport("finish", "()V", AccessFlags = 1)]
				public override void Finish() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([BII)V", AccessFlags = 1)]
				public override void Write(sbyte[] sByte, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([BII)V", AccessFlags = 1, IgnoreFromJava = true)]
				public override void Write(byte[] @byte, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal GZIPOutputStream() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// java/util/zip/Checksum
		/// </java-name>
		[Dot42.DexImport("java/util/zip/Checksum", AccessFlags = 1537)]
		public partial interface IChecksum
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// reset
				/// </java-name>
				[Dot42.DexImport("reset", "()V", AccessFlags = 1025)]
				void Reset() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// update
				/// </java-name>
				[Dot42.DexImport("update", "([BII)V", AccessFlags = 1025)]
				void Update(sbyte[] sByte, int int32, int int321) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// update
				/// </java-name>
				[Dot42.DexImport("update", "(I)V", AccessFlags = 1025)]
				void Update(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getValue
				/// </java-name>
				long Value
				{
						[Dot42.DexImport("getValue", "()J", AccessFlags = 1025)]
						get;
				}

		}

		/// <java-name>
		/// java/util/zip/Inflater
		/// </java-name>
		[Dot42.DexImport("java/util/zip/Inflater", AccessFlags = 33)]
		public partial class Inflater
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Inflater() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Z)V", AccessFlags = 1)]
				public Inflater(bool boolean) /* MethodBuilder.Create */ 
				{
				}

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

				/// <java-name>
				/// finished
				/// </java-name>
				[Dot42.DexImport("finished", "()Z", AccessFlags = 33)]
				public virtual bool Finished() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// inflate
				/// </java-name>
				[Dot42.DexImport("inflate", "([B)I", AccessFlags = 1)]
				public virtual int Inflate(sbyte[] sByte) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// inflate
				/// </java-name>
				[Dot42.DexImport("inflate", "([B)I", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual int Inflate(byte[] @byte) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// inflate
				/// </java-name>
				[Dot42.DexImport("inflate", "([BII)I", AccessFlags = 33)]
				public virtual int Inflate(sbyte[] sByte, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// inflate
				/// </java-name>
				[Dot42.DexImport("inflate", "([BII)I", AccessFlags = 33, IgnoreFromJava = true)]
				public virtual int Inflate(byte[] @byte, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// needsDictionary
				/// </java-name>
				[Dot42.DexImport("needsDictionary", "()Z", AccessFlags = 33)]
				public virtual bool NeedsDictionary() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// needsInput
				/// </java-name>
				[Dot42.DexImport("needsInput", "()Z", AccessFlags = 33)]
				public virtual bool NeedsInput() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// reset
				/// </java-name>
				[Dot42.DexImport("reset", "()V", AccessFlags = 33)]
				public virtual void Reset() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setDictionary
				/// </java-name>
				[Dot42.DexImport("setDictionary", "([B)V", AccessFlags = 33)]
				public virtual void SetDictionary(sbyte[] sByte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setDictionary
				/// </java-name>
				[Dot42.DexImport("setDictionary", "([B)V", AccessFlags = 33, IgnoreFromJava = true)]
				public virtual void SetDictionary(byte[] @byte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setDictionary
				/// </java-name>
				[Dot42.DexImport("setDictionary", "([BII)V", AccessFlags = 33)]
				public virtual void SetDictionary(sbyte[] sByte, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setDictionary
				/// </java-name>
				[Dot42.DexImport("setDictionary", "([BII)V", AccessFlags = 33, IgnoreFromJava = true)]
				public virtual void SetDictionary(byte[] @byte, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setInput
				/// </java-name>
				[Dot42.DexImport("setInput", "([B)V", AccessFlags = 33)]
				public virtual void SetInput(sbyte[] sByte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setInput
				/// </java-name>
				[Dot42.DexImport("setInput", "([B)V", AccessFlags = 33, IgnoreFromJava = true)]
				public virtual void SetInput(byte[] @byte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setInput
				/// </java-name>
				[Dot42.DexImport("setInput", "([BII)V", AccessFlags = 33)]
				public virtual void SetInput(sbyte[] sByte, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setInput
				/// </java-name>
				[Dot42.DexImport("setInput", "([BII)V", AccessFlags = 33, IgnoreFromJava = true)]
				public virtual void SetInput(byte[] @byte, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getAdler
				/// </java-name>
				public virtual int Adler
				{
						[Dot42.DexImport("getAdler", "()I", AccessFlags = 33)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getBytesRead
				/// </java-name>
				public virtual long BytesRead
				{
						[Dot42.DexImport("getBytesRead", "()J", AccessFlags = 33)]
						get{ return default(long); }
				}

				/// <java-name>
				/// getBytesWritten
				/// </java-name>
				public virtual long BytesWritten
				{
						[Dot42.DexImport("getBytesWritten", "()J", AccessFlags = 33)]
						get{ return default(long); }
				}

				/// <java-name>
				/// getRemaining
				/// </java-name>
				public virtual int Remaining
				{
						[Dot42.DexImport("getRemaining", "()I", AccessFlags = 33)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getTotalIn
				/// </java-name>
				public virtual int TotalIn
				{
						[Dot42.DexImport("getTotalIn", "()I", AccessFlags = 33)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getTotalOut
				/// </java-name>
				public virtual int TotalOut
				{
						[Dot42.DexImport("getTotalOut", "()I", AccessFlags = 33)]
						get{ return default(int); }
				}

		}

		/// <java-name>
		/// java/util/zip/InflaterInputStream
		/// </java-name>
		[Dot42.DexImport("java/util/zip/InflaterInputStream", AccessFlags = 33)]
		public partial class InflaterInputStream : global::Java.Io.FilterInputStream
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// inf
				/// </java-name>
				[Dot42.DexImport("inf", "Ljava/util/zip/Inflater;", AccessFlags = 4)]
				protected internal global::Java.Util.Zip.Inflater Inf;
				/// <java-name>
				/// buf
				/// </java-name>
				[Dot42.DexImport("buf", "[B", AccessFlags = 4)]
				protected internal sbyte[] Buf;
				/// <java-name>
				/// len
				/// </java-name>
				[Dot42.DexImport("len", "I", AccessFlags = 4)]
				protected internal int Len;
				[Dot42.DexImport("<init>", "(Ljava/io/InputStream;)V", AccessFlags = 1)]
				public InflaterInputStream(global::Java.Io.InputStream inputStream) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/io/InputStream;Ljava/util/zip/Inflater;)V", AccessFlags = 1)]
				public InflaterInputStream(global::Java.Io.InputStream inputStream, global::Java.Util.Zip.Inflater inflater) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/io/InputStream;Ljava/util/zip/Inflater;I)V", AccessFlags = 1)]
				public InflaterInputStream(global::Java.Io.InputStream inputStream, global::Java.Util.Zip.Inflater inflater, int int32) /* MethodBuilder.Create */ 
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
				[Dot42.DexImport("read", "([BII)I", AccessFlags = 1)]
				public override int Read(sbyte[] sByte, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([BII)I", AccessFlags = 1, IgnoreFromJava = true)]
				public override int Read(byte[] @byte, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// fill
				/// </java-name>
				[Dot42.DexImport("fill", "()V", AccessFlags = 4)]
				protected internal virtual void Fill() /* MethodBuilder.Create */ 
				{
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

				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1)]
				public override void Close() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// mark
				/// </java-name>
				[Dot42.DexImport("mark", "(I)V", AccessFlags = 1)]
				public override void Mark(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// reset
				/// </java-name>
				[Dot42.DexImport("reset", "()V", AccessFlags = 1)]
				public override void Reset() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// markSupported
				/// </java-name>
				[Dot42.DexImport("markSupported", "()Z", AccessFlags = 1)]
				public override bool MarkSupported() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal InflaterInputStream() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// java/util/zip/InflaterOutputStream
		/// </java-name>
		[Dot42.DexImport("java/util/zip/InflaterOutputStream", AccessFlags = 33)]
		public partial class InflaterOutputStream : global::Java.Io.FilterOutputStream
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// inf
				/// </java-name>
				[Dot42.DexImport("inf", "Ljava/util/zip/Inflater;", AccessFlags = 20)]
				protected internal readonly global::Java.Util.Zip.Inflater Inf;
				/// <java-name>
				/// buf
				/// </java-name>
				[Dot42.DexImport("buf", "[B", AccessFlags = 20)]
				protected internal readonly sbyte[] Buf;
				[Dot42.DexImport("<init>", "(Ljava/io/OutputStream;)V", AccessFlags = 1)]
				public InflaterOutputStream(global::Java.Io.OutputStream outputStream) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/io/OutputStream;Ljava/util/zip/Inflater;)V", AccessFlags = 1)]
				public InflaterOutputStream(global::Java.Io.OutputStream outputStream, global::Java.Util.Zip.Inflater inflater) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/io/OutputStream;Ljava/util/zip/Inflater;I)V", AccessFlags = 1)]
				public InflaterOutputStream(global::Java.Io.OutputStream outputStream, global::Java.Util.Zip.Inflater inflater, int int32) /* MethodBuilder.Create */ 
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
				[Dot42.DexImport("write", "([BII)V", AccessFlags = 1)]
				public override void Write(sbyte[] sByte, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([BII)V", AccessFlags = 1, IgnoreFromJava = true)]
				public override void Write(byte[] @byte, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal InflaterOutputStream() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// java/util/zip/ZipEntry
		/// </java-name>
		[Dot42.DexImport("java/util/zip/ZipEntry", AccessFlags = 33)]
		public partial class ZipEntry : global::Java.Lang.ICloneable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// DEFLATED
				/// </java-name>
				[Dot42.DexImport("DEFLATED", "I", AccessFlags = 25)]
				public const int DEFLATED = 8;
				/// <java-name>
				/// STORED
				/// </java-name>
				[Dot42.DexImport("STORED", "I", AccessFlags = 25)]
				public const int STORED = 0;
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public ZipEntry(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/util/zip/ZipEntry;)V", AccessFlags = 1)]
				public ZipEntry(global::Java.Util.Zip.ZipEntry zipEntry) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getExtra
				/// </java-name>
				[Dot42.DexImport("getExtra", "()[B", AccessFlags = 1)]
				public virtual sbyte[] JavaGetExtra() /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <java-name>
				/// setExtra
				/// </java-name>
				[Dot42.DexImport("setExtra", "([B)V", AccessFlags = 1)]
				public virtual void SetExtra(sbyte[] sByte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/lang/Object;", AccessFlags = 1)]
				public virtual object Clone() /* MethodBuilder.Create */ 
				{
						return default(object);
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
				internal ZipEntry() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

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

				/// <java-name>
				/// getExtra
				/// </java-name>
				public virtual byte[] Extra
				{
						[Dot42.DexImport("getExtra", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
						get{ return default(byte[]); }
						[Dot42.DexImport("setExtra", "([B)V", AccessFlags = 1, IgnoreFromJava = true)]
						set{ }
				}

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

				/// <java-name>
				/// getName
				/// </java-name>
				public virtual string Name
				{
						[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

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

				/// <java-name>
				/// isDirectory
				/// </java-name>
				public virtual bool IsDirectory
				{
						[Dot42.DexImport("isDirectory", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

		}

		/// <java-name>
		/// java/util/zip/ZipError
		/// </java-name>
		[Dot42.DexImport("java/util/zip/ZipError", AccessFlags = 33)]
		public partial class ZipError : global::Java.Lang.InternalError
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public ZipError(string @string) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ZipError() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// java/util/zip/ZipException
		/// </java-name>
		[Dot42.DexImport("java/util/zip/ZipException", AccessFlags = 33)]
		public partial class ZipException : global::System.IO.IOException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ZipException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public ZipException(string @string) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/util/zip/ZipFile
		/// </java-name>
		[Dot42.DexImport("java/util/zip/ZipFile", AccessFlags = 33)]
		public partial class ZipFile
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// OPEN_READ
				/// </java-name>
				[Dot42.DexImport("OPEN_READ", "I", AccessFlags = 25)]
				public const int OPEN_READ = 1;
				/// <java-name>
				/// OPEN_DELETE
				/// </java-name>
				[Dot42.DexImport("OPEN_DELETE", "I", AccessFlags = 25)]
				public const int OPEN_DELETE = 4;
				[Dot42.DexImport("<init>", "(Ljava/io/File;)V", AccessFlags = 1)]
				public ZipFile(global::Java.Io.File file) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/io/File;I)V", AccessFlags = 1)]
				public ZipFile(global::Java.Io.File file, int int32) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public ZipFile(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// finalize
				/// </java-name>
				[Dot42.DexImport("finalize", "()V", AccessFlags = 4)]
				extern ~ZipFile() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1)]
				public virtual void Close() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// entries
				/// </java-name>
				[Dot42.DexImport("entries", "()Ljava/util/Enumeration;", AccessFlags = 1, Signature = "()Ljava/util/Enumeration<+Ljava/util/zip/ZipEntry;>;")]
				public virtual global::Java.Util.IEnumeration<global::Java.Util.Zip.ZipEntry> Entries() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IEnumeration<global::Java.Util.Zip.ZipEntry>);
				}

				/// <java-name>
				/// getEntry
				/// </java-name>
				[Dot42.DexImport("getEntry", "(Ljava/lang/String;)Ljava/util/zip/ZipEntry;", AccessFlags = 1)]
				public virtual global::Java.Util.Zip.ZipEntry GetEntry(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Zip.ZipEntry);
				}

				/// <java-name>
				/// getInputStream
				/// </java-name>
				[Dot42.DexImport("getInputStream", "(Ljava/util/zip/ZipEntry;)Ljava/io/InputStream;", AccessFlags = 1)]
				public virtual global::Java.Io.InputStream GetInputStream(global::Java.Util.Zip.ZipEntry zipEntry) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.InputStream);
				}

				/// <java-name>
				/// size
				/// </java-name>
				[Dot42.DexImport("size", "()I", AccessFlags = 1)]
				public virtual int Size() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ZipFile() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getName
				/// </java-name>
				public virtual string Name
				{
						[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

		}

		/// <java-name>
		/// java/util/zip/ZipInputStream
		/// </java-name>
		[Dot42.DexImport("java/util/zip/ZipInputStream", AccessFlags = 33)]
		public partial class ZipInputStream : global::Java.Util.Zip.InflaterInputStream
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/io/InputStream;)V", AccessFlags = 1)]
				public ZipInputStream(global::Java.Io.InputStream inputStream) /* MethodBuilder.Create */ 
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
				/// closeEntry
				/// </java-name>
				[Dot42.DexImport("closeEntry", "()V", AccessFlags = 1)]
				public virtual void CloseEntry() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([BII)I", AccessFlags = 1)]
				public override int Read(sbyte[] sByte, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([BII)I", AccessFlags = 1, IgnoreFromJava = true)]
				public override int Read(byte[] @byte, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
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
				/// createZipEntry
				/// </java-name>
				[Dot42.DexImport("createZipEntry", "(Ljava/lang/String;)Ljava/util/zip/ZipEntry;", AccessFlags = 4)]
				protected internal virtual global::Java.Util.Zip.ZipEntry CreateZipEntry(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Zip.ZipEntry);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ZipInputStream() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getNextEntry
				/// </java-name>
				public virtual global::Java.Util.Zip.ZipEntry NextEntry
				{
						[Dot42.DexImport("getNextEntry", "()Ljava/util/zip/ZipEntry;", AccessFlags = 1)]
						get{ return default(global::Java.Util.Zip.ZipEntry); }
				}

		}

		/// <java-name>
		/// java/util/zip/ZipOutputStream
		/// </java-name>
		[Dot42.DexImport("java/util/zip/ZipOutputStream", AccessFlags = 33)]
		public partial class ZipOutputStream : global::Java.Util.Zip.DeflaterOutputStream
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// DEFLATED
				/// </java-name>
				[Dot42.DexImport("DEFLATED", "I", AccessFlags = 25)]
				public const int DEFLATED = 8;
				/// <java-name>
				/// STORED
				/// </java-name>
				[Dot42.DexImport("STORED", "I", AccessFlags = 25)]
				public const int STORED = 0;
				[Dot42.DexImport("<init>", "(Ljava/io/OutputStream;)V", AccessFlags = 1)]
				public ZipOutputStream(global::Java.Io.OutputStream outputStream) /* MethodBuilder.Create */ 
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
				/// closeEntry
				/// </java-name>
				[Dot42.DexImport("closeEntry", "()V", AccessFlags = 1)]
				public virtual void CloseEntry() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// finish
				/// </java-name>
				[Dot42.DexImport("finish", "()V", AccessFlags = 1)]
				public override void Finish() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// putNextEntry
				/// </java-name>
				[Dot42.DexImport("putNextEntry", "(Ljava/util/zip/ZipEntry;)V", AccessFlags = 1)]
				public virtual void PutNextEntry(global::Java.Util.Zip.ZipEntry zipEntry) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setComment
				/// </java-name>
				[Dot42.DexImport("setComment", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetComment(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setLevel
				/// </java-name>
				[Dot42.DexImport("setLevel", "(I)V", AccessFlags = 1)]
				public virtual void SetLevel(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setMethod
				/// </java-name>
				[Dot42.DexImport("setMethod", "(I)V", AccessFlags = 1)]
				public virtual void SetMethod(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([BII)V", AccessFlags = 1)]
				public override void Write(sbyte[] sByte, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([BII)V", AccessFlags = 1, IgnoreFromJava = true)]
				public override void Write(byte[] @byte, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ZipOutputStream() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

}

