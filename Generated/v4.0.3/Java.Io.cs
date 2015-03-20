#pragma warning disable 1717
namespace Java.Io
{
		/// <java-name>
		/// java/io/DataInputStream
		/// </java-name>
		[Dot42.DexImport("java/io/DataInputStream", AccessFlags = 33)]
		public partial class DataInputStream : global::Java.Io.FilterInputStream, global::Java.Io.IDataInput
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/io/InputStream;)V", AccessFlags = 1)]
				public DataInputStream(global::Java.Io.InputStream inputStream) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([B)I", AccessFlags = 17)]
				public override int Read(sbyte[] sByte) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([B)I", AccessFlags = 17, IgnoreFromJava = true)]
				public override int Read(byte[] @byte) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([BII)I", AccessFlags = 17)]
				public override int Read(sbyte[] sByte, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([BII)I", AccessFlags = 17, IgnoreFromJava = true)]
				public override int Read(byte[] @byte, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// readBoolean
				/// </java-name>
				[Dot42.DexImport("readBoolean", "()Z", AccessFlags = 17)]
				public bool ReadBoolean() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// readByte
				/// </java-name>
				[Dot42.DexImport("readByte", "()B", AccessFlags = 17)]
				public sbyte JavaReadByte() /* MethodBuilder.Create */ 
				{
						return default(sbyte);
				}

				/// <java-name>
				/// readByte
				/// </java-name>
				[Dot42.DexImport("readByte", "()B", AccessFlags = 17, IgnoreFromJava = true)]
				public byte ReadByte() /* MethodBuilder.Create */ 
				{
						return default(byte);
				}

				/// <java-name>
				/// readChar
				/// </java-name>
				[Dot42.DexImport("readChar", "()C", AccessFlags = 17)]
				public char ReadChar() /* MethodBuilder.Create */ 
				{
						return default(char);
				}

				/// <java-name>
				/// readDouble
				/// </java-name>
				[Dot42.DexImport("readDouble", "()D", AccessFlags = 17)]
				public double ReadDouble() /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <java-name>
				/// readFloat
				/// </java-name>
				[Dot42.DexImport("readFloat", "()F", AccessFlags = 17)]
				public float ReadFloat() /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// readFully
				/// </java-name>
				[Dot42.DexImport("readFully", "([B)V", AccessFlags = 17)]
				public void ReadFully(sbyte[] sByte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// readFully
				/// </java-name>
				[Dot42.DexImport("readFully", "([B)V", AccessFlags = 17, IgnoreFromJava = true)]
				public void ReadFully(byte[] @byte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// readFully
				/// </java-name>
				[Dot42.DexImport("readFully", "([BII)V", AccessFlags = 17)]
				public void ReadFully(sbyte[] sByte, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// readFully
				/// </java-name>
				[Dot42.DexImport("readFully", "([BII)V", AccessFlags = 17, IgnoreFromJava = true)]
				public void ReadFully(byte[] @byte, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// readInt
				/// </java-name>
				[Dot42.DexImport("readInt", "()I", AccessFlags = 17)]
				public int ReadInt() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// readLine
				/// </java-name>
				[Dot42.DexImport("readLine", "()Ljava/lang/String;", AccessFlags = 17)]
				public string ReadLine() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// readLong
				/// </java-name>
				[Dot42.DexImport("readLong", "()J", AccessFlags = 17)]
				public long ReadLong() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// readShort
				/// </java-name>
				[Dot42.DexImport("readShort", "()S", AccessFlags = 17)]
				public short ReadShort() /* MethodBuilder.Create */ 
				{
						return default(short);
				}

				/// <java-name>
				/// readUnsignedByte
				/// </java-name>
				[Dot42.DexImport("readUnsignedByte", "()I", AccessFlags = 17)]
				public int ReadUnsignedByte() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// readUnsignedShort
				/// </java-name>
				[Dot42.DexImport("readUnsignedShort", "()I", AccessFlags = 17)]
				public int ReadUnsignedShort() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

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
				public static string ReadUTF(global::Java.Io.IDataInput dataInput) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// skipBytes
				/// </java-name>
				[Dot42.DexImport("skipBytes", "(I)I", AccessFlags = 17)]
				public int SkipBytes(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal DataInputStream() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// java/io/FilterInputStream
		/// </java-name>
		[Dot42.DexImport("java/io/FilterInputStream", AccessFlags = 33)]
		public partial class FilterInputStream : global::Java.Io.InputStream
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// in
				/// </java-name>
				[Dot42.DexImport("in", "Ljava/io/InputStream;", AccessFlags = 68)]
				protected internal global::Java.Io.InputStream In;
				[Dot42.DexImport("<init>", "(Ljava/io/InputStream;)V", AccessFlags = 4)]
				protected internal FilterInputStream(global::Java.Io.InputStream inputStream) /* MethodBuilder.Create */ 
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
				/// mark
				/// </java-name>
				[Dot42.DexImport("mark", "(I)V", AccessFlags = 33)]
				public override void Mark(int int32) /* MethodBuilder.Create */ 
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
				/// reset
				/// </java-name>
				[Dot42.DexImport("reset", "()V", AccessFlags = 33)]
				public override void Reset() /* MethodBuilder.Create */ 
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

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal FilterInputStream() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// java/io/Writer
		/// </java-name>
		[Dot42.DexImport("java/io/Writer", AccessFlags = 1057)]
		public abstract partial class Writer : global::Java.Lang.IAppendable, global::Java.Io.ICloseable, global::Java.Io.IFlushable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// lock
				/// </java-name>
				[Dot42.DexImport("lock", "Ljava/lang/Object;", AccessFlags = 4)]
				protected internal object Lock;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal Writer() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/Object;)V", AccessFlags = 4)]
				protected internal Writer(object @object) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1025)]
				public virtual void Close() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// flush
				/// </java-name>
				[Dot42.DexImport("flush", "()V", AccessFlags = 1025)]
				public virtual void Flush() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([C)V", AccessFlags = 1)]
				public virtual void Write(char[] @char) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([CII)V", AccessFlags = 1025)]
				public abstract void Write(char[] @char, int int32, int int321) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "(I)V", AccessFlags = 1)]
				public virtual void Write(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void Write(string @string) /* MethodBuilder.Create */ 
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
				public virtual global::Java.Io.Writer Append(char @char) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.Writer);
				}

				/// <java-name>
				/// append
				/// </java-name>
				[Dot42.DexImport("append", "(Ljava/lang/CharSequence;)Ljava/io/Writer;", AccessFlags = 1)]
				public virtual global::Java.Io.Writer Append(global::Java.Lang.ICharSequence charSequence) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.Writer);
				}

				/// <java-name>
				/// append
				/// </java-name>
				[Dot42.DexImport("append", "(Ljava/lang/CharSequence;II)Ljava/io/Writer;", AccessFlags = 1)]
				public virtual global::Java.Io.Writer JavaAppend(global::Java.Lang.ICharSequence charSequence, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.Writer);
				}

				[Dot42.DexImport("java/lang/Appendable", "append", "(C)Ljava/lang/Appendable;", AccessFlags = 1025)]
				global::Java.Lang.IAppendable global::Java.Lang.IAppendable.Append(char @char) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Java.Lang.IAppendable);
				}

				[Dot42.DexImport("java/lang/Appendable", "append", "(Ljava/lang/CharSequence;)Ljava/lang/Appendable;", AccessFlags = 1025)]
				global::Java.Lang.IAppendable global::Java.Lang.IAppendable.Append(global::Java.Lang.ICharSequence charSequence) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Java.Lang.IAppendable);
				}

				[Dot42.DexImport("java/lang/Appendable", "append", "(Ljava/lang/CharSequence;II)Ljava/lang/Appendable;", AccessFlags = 1025)]
				global::Java.Lang.IAppendable global::Java.Lang.IAppendable.JavaAppend(global::Java.Lang.ICharSequence charSequence, int int32, int int321) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Java.Lang.IAppendable);
				}

		}

		/// <java-name>
		/// java/io/SyncFailedException
		/// </java-name>
		[Dot42.DexImport("java/io/SyncFailedException", AccessFlags = 33)]
		public partial class SyncFailedException : global::System.IO.IOException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public SyncFailedException(string @string) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal SyncFailedException() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// java/io/OptionalDataException
		/// </java-name>
		[Dot42.DexImport("java/io/OptionalDataException", AccessFlags = 33)]
		public partial class OptionalDataException : global::Java.Io.ObjectStreamException
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// eof
				/// </java-name>
				[Dot42.DexImport("eof", "Z", AccessFlags = 1)]
				public bool Eof;
				/// <java-name>
				/// length
				/// </java-name>
				[Dot42.DexImport("length", "I", AccessFlags = 1)]
				public int Length;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal OptionalDataException() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/io/StringWriter
		/// </java-name>
		[Dot42.DexImport("java/io/StringWriter", AccessFlags = 33)]
		public partial class StringWriter : global::Java.Io.Writer
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public StringWriter() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public StringWriter(int int32) /* MethodBuilder.Create */ 
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
				/// getBuffer
				/// </java-name>
				[Dot42.DexImport("getBuffer", "()Ljava/lang/StringBuffer;", AccessFlags = 1)]
				public virtual global::Java.Lang.StringBuffer GetBuffer() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.StringBuffer);
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
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([CII)V", AccessFlags = 1)]
				public override void Write(char[] @char, int int32, int int321) /* MethodBuilder.Create */ 
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
				[Dot42.DexImport("write", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public override void Write(string @string) /* MethodBuilder.Create */ 
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
				public new virtual global::Java.Io.StringWriter Append(char @char) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.StringWriter);
				}

				/// <java-name>
				/// append
				/// </java-name>
				[Dot42.DexImport("append", "(Ljava/lang/CharSequence;)Ljava/io/StringWriter;", AccessFlags = 1)]
				public new virtual global::Java.Io.StringWriter Append(global::Java.Lang.ICharSequence charSequence) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.StringWriter);
				}

				/// <java-name>
				/// append
				/// </java-name>
				[Dot42.DexImport("append", "(Ljava/lang/CharSequence;II)Ljava/io/StringWriter;", AccessFlags = 1)]
				public new virtual global::Java.Io.StringWriter JavaAppend(global::Java.Lang.ICharSequence charSequence, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.StringWriter);
				}

				/// <java-name>
				/// getBuffer
				/// </java-name>
				public global::Java.Lang.StringBuffer Buffer
				{
				[Dot42.DexImport("getBuffer", "()Ljava/lang/StringBuffer;", AccessFlags = 1)]
						get{ return GetBuffer(); }
				}

		}

		/// <java-name>
		/// java/io/PipedReader
		/// </java-name>
		[Dot42.DexImport("java/io/PipedReader", AccessFlags = 33)]
		public partial class PipedReader : global::Java.Io.Reader
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public PipedReader() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/io/PipedWriter;)V", AccessFlags = 1)]
				public PipedReader(global::Java.Io.PipedWriter pipedWriter) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public PipedReader(int int32) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/io/PipedWriter;I)V", AccessFlags = 1)]
				public PipedReader(global::Java.Io.PipedWriter pipedWriter, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 33)]
				public override void Close() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// connect
				/// </java-name>
				[Dot42.DexImport("connect", "(Ljava/io/PipedWriter;)V", AccessFlags = 1)]
				public virtual void Connect(global::Java.Io.PipedWriter pipedWriter) /* MethodBuilder.Create */ 
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
				[Dot42.DexImport("read", "([CII)I", AccessFlags = 33)]
				public override int Read(char[] @char, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// ready
				/// </java-name>
				[Dot42.DexImport("ready", "()Z", AccessFlags = 33)]
				public override bool Ready() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

		}

		/// <java-name>
		/// java/io/RandomAccessFile
		/// </java-name>
		[Dot42.DexImport("java/io/RandomAccessFile", AccessFlags = 33)]
		public partial class RandomAccessFile : global::Java.Io.IDataInput, global::Java.Io.IDataOutput, global::Java.Io.ICloseable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/io/File;Ljava/lang/String;)V", AccessFlags = 1)]
				public RandomAccessFile(global::Java.Io.File file, string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public RandomAccessFile(string @string, string string1) /* MethodBuilder.Create */ 
				{
				}

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

				/// <java-name>
				/// getChannel
				/// </java-name>
				[Dot42.DexImport("getChannel", "()Ljava/nio/channels/FileChannel;", AccessFlags = 49)]
				public global::Java.Nio.Channels.FileChannel GetChannel() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.Channels.FileChannel);
				}

				/// <java-name>
				/// getFD
				/// </java-name>
				[Dot42.DexImport("getFD", "()Ljava/io/FileDescriptor;", AccessFlags = 17)]
				public global::Java.Io.FileDescriptor GetFD() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.FileDescriptor);
				}

				/// <java-name>
				/// getFilePointer
				/// </java-name>
				[Dot42.DexImport("getFilePointer", "()J", AccessFlags = 1)]
				public virtual long GetFilePointer() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// length
				/// </java-name>
				[Dot42.DexImport("length", "()J", AccessFlags = 1)]
				public virtual long Length() /* MethodBuilder.Create */ 
				{
						return default(long);
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
				[Dot42.DexImport("read", "([B)I", AccessFlags = 1)]
				public virtual int Read(sbyte[] sByte) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([B)I", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual int Read(byte[] @byte) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([BII)I", AccessFlags = 1)]
				public virtual int Read(sbyte[] sByte, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([BII)I", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual int Read(byte[] @byte, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// readBoolean
				/// </java-name>
				[Dot42.DexImport("readBoolean", "()Z", AccessFlags = 17)]
				public bool ReadBoolean() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// readByte
				/// </java-name>
				[Dot42.DexImport("readByte", "()B", AccessFlags = 17)]
				public sbyte JavaReadByte() /* MethodBuilder.Create */ 
				{
						return default(sbyte);
				}

				/// <java-name>
				/// readByte
				/// </java-name>
				[Dot42.DexImport("readByte", "()B", AccessFlags = 17, IgnoreFromJava = true)]
				public byte ReadByte() /* MethodBuilder.Create */ 
				{
						return default(byte);
				}

				/// <java-name>
				/// readChar
				/// </java-name>
				[Dot42.DexImport("readChar", "()C", AccessFlags = 17)]
				public char ReadChar() /* MethodBuilder.Create */ 
				{
						return default(char);
				}

				/// <java-name>
				/// readDouble
				/// </java-name>
				[Dot42.DexImport("readDouble", "()D", AccessFlags = 17)]
				public double ReadDouble() /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <java-name>
				/// readFloat
				/// </java-name>
				[Dot42.DexImport("readFloat", "()F", AccessFlags = 17)]
				public float ReadFloat() /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// readFully
				/// </java-name>
				[Dot42.DexImport("readFully", "([B)V", AccessFlags = 17)]
				public void ReadFully(sbyte[] sByte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// readFully
				/// </java-name>
				[Dot42.DexImport("readFully", "([B)V", AccessFlags = 17, IgnoreFromJava = true)]
				public void ReadFully(byte[] @byte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// readFully
				/// </java-name>
				[Dot42.DexImport("readFully", "([BII)V", AccessFlags = 17)]
				public void ReadFully(sbyte[] sByte, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// readFully
				/// </java-name>
				[Dot42.DexImport("readFully", "([BII)V", AccessFlags = 17, IgnoreFromJava = true)]
				public void ReadFully(byte[] @byte, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// readInt
				/// </java-name>
				[Dot42.DexImport("readInt", "()I", AccessFlags = 17)]
				public int ReadInt() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// readLine
				/// </java-name>
				[Dot42.DexImport("readLine", "()Ljava/lang/String;", AccessFlags = 17)]
				public string ReadLine() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// readLong
				/// </java-name>
				[Dot42.DexImport("readLong", "()J", AccessFlags = 17)]
				public long ReadLong() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// readShort
				/// </java-name>
				[Dot42.DexImport("readShort", "()S", AccessFlags = 17)]
				public short ReadShort() /* MethodBuilder.Create */ 
				{
						return default(short);
				}

				/// <java-name>
				/// readUnsignedByte
				/// </java-name>
				[Dot42.DexImport("readUnsignedByte", "()I", AccessFlags = 17)]
				public int ReadUnsignedByte() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// readUnsignedShort
				/// </java-name>
				[Dot42.DexImport("readUnsignedShort", "()I", AccessFlags = 17)]
				public int ReadUnsignedShort() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// readUTF
				/// </java-name>
				[Dot42.DexImport("readUTF", "()Ljava/lang/String;", AccessFlags = 17)]
				public string ReadUTF() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// seek
				/// </java-name>
				[Dot42.DexImport("seek", "(J)V", AccessFlags = 1)]
				public virtual void Seek(long int64) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setLength
				/// </java-name>
				[Dot42.DexImport("setLength", "(J)V", AccessFlags = 1)]
				public virtual void SetLength(long int64) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// skipBytes
				/// </java-name>
				[Dot42.DexImport("skipBytes", "(I)I", AccessFlags = 1)]
				public virtual int SkipBytes(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([B)V", AccessFlags = 1)]
				public virtual void Write(sbyte[] sByte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual void Write(byte[] @byte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([BII)V", AccessFlags = 1)]
				public virtual void Write(sbyte[] sByte, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([BII)V", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual void Write(byte[] @byte, int int32, int int321) /* MethodBuilder.Create */ 
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
				/// writeBoolean
				/// </java-name>
				[Dot42.DexImport("writeBoolean", "(Z)V", AccessFlags = 17)]
				public void WriteBoolean(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writeByte
				/// </java-name>
				[Dot42.DexImport("writeByte", "(I)V", AccessFlags = 17)]
				public void WriteByte(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writeBytes
				/// </java-name>
				[Dot42.DexImport("writeBytes", "(Ljava/lang/String;)V", AccessFlags = 17)]
				public void WriteBytes(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writeChar
				/// </java-name>
				[Dot42.DexImport("writeChar", "(I)V", AccessFlags = 17)]
				public void WriteChar(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writeChars
				/// </java-name>
				[Dot42.DexImport("writeChars", "(Ljava/lang/String;)V", AccessFlags = 17)]
				public void WriteChars(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writeDouble
				/// </java-name>
				[Dot42.DexImport("writeDouble", "(D)V", AccessFlags = 17)]
				public void WriteDouble(double @double) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writeFloat
				/// </java-name>
				[Dot42.DexImport("writeFloat", "(F)V", AccessFlags = 17)]
				public void WriteFloat(float single) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writeInt
				/// </java-name>
				[Dot42.DexImport("writeInt", "(I)V", AccessFlags = 17)]
				public void WriteInt(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writeLong
				/// </java-name>
				[Dot42.DexImport("writeLong", "(J)V", AccessFlags = 17)]
				public void WriteLong(long int64) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writeShort
				/// </java-name>
				[Dot42.DexImport("writeShort", "(I)V", AccessFlags = 17)]
				public void WriteShort(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writeUTF
				/// </java-name>
				[Dot42.DexImport("writeUTF", "(Ljava/lang/String;)V", AccessFlags = 17)]
				public void WriteUTF(string @string) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal RandomAccessFile() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getChannel
				/// </java-name>
				public global::Java.Nio.Channels.FileChannel Channel
				{
				[Dot42.DexImport("getChannel", "()Ljava/nio/channels/FileChannel;", AccessFlags = 49)]
						get{ return GetChannel(); }
				}

				/// <java-name>
				/// getFD
				/// </java-name>
				public global::Java.Io.FileDescriptor FD
				{
				[Dot42.DexImport("getFD", "()Ljava/io/FileDescriptor;", AccessFlags = 17)]
						get{ return GetFD(); }
				}

				/// <java-name>
				/// getFilePointer
				/// </java-name>
				public long FilePointer
				{
				[Dot42.DexImport("getFilePointer", "()J", AccessFlags = 1)]
						get{ return GetFilePointer(); }
				}

		}

		/// <java-name>
		/// java/io/FilePermission
		/// </java-name>
		[Dot42.DexImport("java/io/FilePermission", AccessFlags = 49)]
		public sealed partial class FilePermission : global::Java.Security.Permission, global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public FilePermission(string @string, string string1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getActions
				/// </java-name>
				[Dot42.DexImport("getActions", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string GetActions() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// implies
				/// </java-name>
				[Dot42.DexImport("implies", "(Ljava/security/Permission;)Z", AccessFlags = 1)]
				public override bool Implies(global::Java.Security.Permission permission) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal FilePermission() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getActions
				/// </java-name>
				public string Actions
				{
				[Dot42.DexImport("getActions", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetActions(); }
				}

		}

		/// <java-name>
		/// java/io/BufferedWriter
		/// </java-name>
		[Dot42.DexImport("java/io/BufferedWriter", AccessFlags = 33)]
		public partial class BufferedWriter : global::Java.Io.Writer
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/io/Writer;)V", AccessFlags = 1)]
				public BufferedWriter(global::Java.Io.Writer writer) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/io/Writer;I)V", AccessFlags = 1)]
				public BufferedWriter(global::Java.Io.Writer writer, int int32) /* MethodBuilder.Create */ 
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
				[Dot42.DexImport("write", "(Ljava/lang/String;II)V", AccessFlags = 1)]
				public override void Write(string @string, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal BufferedWriter() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// java/io/LineNumberInputStream
		/// </java-name>
		[Dot42.DexImport("java/io/LineNumberInputStream", AccessFlags = 33)]
		public partial class LineNumberInputStream : global::Java.Io.FilterInputStream
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/io/InputStream;)V", AccessFlags = 1)]
				public LineNumberInputStream(global::Java.Io.InputStream inputStream) /* MethodBuilder.Create */ 
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
				/// getLineNumber
				/// </java-name>
				[Dot42.DexImport("getLineNumber", "()I", AccessFlags = 1)]
				public virtual int GetLineNumber() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// mark
				/// </java-name>
				[Dot42.DexImport("mark", "(I)V", AccessFlags = 1)]
				public override void Mark(int int32) /* MethodBuilder.Create */ 
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
				/// reset
				/// </java-name>
				[Dot42.DexImport("reset", "()V", AccessFlags = 1)]
				public override void Reset() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setLineNumber
				/// </java-name>
				[Dot42.DexImport("setLineNumber", "(I)V", AccessFlags = 1)]
				public virtual void SetLineNumber(int int32) /* MethodBuilder.Create */ 
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

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal LineNumberInputStream() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getLineNumber
				/// </java-name>
				public int LineNumber
				{
				[Dot42.DexImport("getLineNumber", "()I", AccessFlags = 1)]
						get{ return GetLineNumber(); }
				[Dot42.DexImport("setLineNumber", "(I)V", AccessFlags = 1)]
						set{ SetLineNumber(value); }
				}

		}

		/// <java-name>
		/// java/io/PrintWriter
		/// </java-name>
		[Dot42.DexImport("java/io/PrintWriter", AccessFlags = 33)]
		public partial class PrintWriter : global::Java.Io.Writer
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// out
				/// </java-name>
				[Dot42.DexImport("out", "Ljava/io/Writer;", AccessFlags = 4)]
				protected internal global::Java.Io.Writer Out;
				[Dot42.DexImport("<init>", "(Ljava/io/OutputStream;)V", AccessFlags = 1)]
				public PrintWriter(global::Java.Io.OutputStream outputStream) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/io/OutputStream;Z)V", AccessFlags = 1)]
				public PrintWriter(global::Java.Io.OutputStream outputStream, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/io/Writer;)V", AccessFlags = 1)]
				public PrintWriter(global::Java.Io.Writer writer) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/io/Writer;Z)V", AccessFlags = 1)]
				public PrintWriter(global::Java.Io.Writer writer, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/io/File;)V", AccessFlags = 1)]
				public PrintWriter(global::Java.Io.File file) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/io/File;Ljava/lang/String;)V", AccessFlags = 1)]
				public PrintWriter(global::Java.Io.File file, string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public PrintWriter(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public PrintWriter(string @string, string string1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// checkError
				/// </java-name>
				[Dot42.DexImport("checkError", "()Z", AccessFlags = 1)]
				public virtual bool CheckError() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// clearError
				/// </java-name>
				[Dot42.DexImport("clearError", "()V", AccessFlags = 4)]
				protected internal virtual void ClearError() /* MethodBuilder.Create */ 
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
				/// format
				/// </java-name>
				[Dot42.DexImport("format", "(Ljava/lang/String;[Ljava/lang/Object;)Ljava/io/PrintWriter;", AccessFlags = 129)]
				public virtual global::Java.Io.PrintWriter Format(string @string, params object[] @object) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.PrintWriter);
				}

				/// <java-name>
				/// format
				/// </java-name>
				[Dot42.DexImport("format", "(Ljava/util/Locale;Ljava/lang/String;[Ljava/lang/Object;)Ljava/io/PrintWriter;", AccessFlags = 129)]
				public virtual global::Java.Io.PrintWriter Format(global::Java.Util.Locale locale, string @string, params object[] @object) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.PrintWriter);
				}

				/// <java-name>
				/// printf
				/// </java-name>
				[Dot42.DexImport("printf", "(Ljava/lang/String;[Ljava/lang/Object;)Ljava/io/PrintWriter;", AccessFlags = 129)]
				public virtual global::Java.Io.PrintWriter Printf(string @string, params object[] @object) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.PrintWriter);
				}

				/// <java-name>
				/// printf
				/// </java-name>
				[Dot42.DexImport("printf", "(Ljava/util/Locale;Ljava/lang/String;[Ljava/lang/Object;)Ljava/io/PrintWriter;", AccessFlags = 129)]
				public virtual global::Java.Io.PrintWriter Printf(global::Java.Util.Locale locale, string @string, params object[] @object) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.PrintWriter);
				}

				/// <java-name>
				/// print
				/// </java-name>
				[Dot42.DexImport("print", "([C)V", AccessFlags = 1)]
				public virtual void Print(char[] @char) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// print
				/// </java-name>
				[Dot42.DexImport("print", "(C)V", AccessFlags = 1)]
				public virtual void Print(char @char) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// print
				/// </java-name>
				[Dot42.DexImport("print", "(D)V", AccessFlags = 1)]
				public virtual void Print(double @double) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// print
				/// </java-name>
				[Dot42.DexImport("print", "(F)V", AccessFlags = 1)]
				public virtual void Print(float single) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// print
				/// </java-name>
				[Dot42.DexImport("print", "(I)V", AccessFlags = 1)]
				public virtual void Print(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// print
				/// </java-name>
				[Dot42.DexImport("print", "(J)V", AccessFlags = 1)]
				public virtual void Print(long int64) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// print
				/// </java-name>
				[Dot42.DexImport("print", "(Ljava/lang/Object;)V", AccessFlags = 1)]
				public virtual void Print(object @object) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// print
				/// </java-name>
				[Dot42.DexImport("print", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void Print(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// print
				/// </java-name>
				[Dot42.DexImport("print", "(Z)V", AccessFlags = 1)]
				public virtual void Print(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// println
				/// </java-name>
				[Dot42.DexImport("println", "()V", AccessFlags = 1)]
				public virtual void Println() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// println
				/// </java-name>
				[Dot42.DexImport("println", "([C)V", AccessFlags = 1)]
				public virtual void Println(char[] @char) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// println
				/// </java-name>
				[Dot42.DexImport("println", "(C)V", AccessFlags = 1)]
				public virtual void Println(char @char) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// println
				/// </java-name>
				[Dot42.DexImport("println", "(D)V", AccessFlags = 1)]
				public virtual void Println(double @double) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// println
				/// </java-name>
				[Dot42.DexImport("println", "(F)V", AccessFlags = 1)]
				public virtual void Println(float single) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// println
				/// </java-name>
				[Dot42.DexImport("println", "(I)V", AccessFlags = 1)]
				public virtual void Println(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// println
				/// </java-name>
				[Dot42.DexImport("println", "(J)V", AccessFlags = 1)]
				public virtual void Println(long int64) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// println
				/// </java-name>
				[Dot42.DexImport("println", "(Ljava/lang/Object;)V", AccessFlags = 1)]
				public virtual void Println(object @object) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// println
				/// </java-name>
				[Dot42.DexImport("println", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void Println(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// println
				/// </java-name>
				[Dot42.DexImport("println", "(Z)V", AccessFlags = 1)]
				public virtual void Println(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setError
				/// </java-name>
				[Dot42.DexImport("setError", "()V", AccessFlags = 4)]
				protected internal virtual void SetError() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([C)V", AccessFlags = 1)]
				public override void Write(char[] @char) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([CII)V", AccessFlags = 1)]
				public override void Write(char[] @char, int int32, int int321) /* MethodBuilder.Create */ 
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
				[Dot42.DexImport("write", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public override void Write(string @string) /* MethodBuilder.Create */ 
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
				public new virtual global::Java.Io.PrintWriter Append(char @char) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.PrintWriter);
				}

				/// <java-name>
				/// append
				/// </java-name>
				[Dot42.DexImport("append", "(Ljava/lang/CharSequence;)Ljava/io/PrintWriter;", AccessFlags = 1)]
				public new virtual global::Java.Io.PrintWriter Append(global::Java.Lang.ICharSequence charSequence) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.PrintWriter);
				}

				/// <java-name>
				/// append
				/// </java-name>
				[Dot42.DexImport("append", "(Ljava/lang/CharSequence;II)Ljava/io/PrintWriter;", AccessFlags = 1)]
				public new virtual global::Java.Io.PrintWriter JavaAppend(global::Java.Lang.ICharSequence charSequence, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.PrintWriter);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal PrintWriter() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// java/io/SerializablePermission
		/// </java-name>
		[Dot42.DexImport("java/io/SerializablePermission", AccessFlags = 49)]
		public sealed partial class SerializablePermission : global::Java.Security.BasicPermission
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public SerializablePermission(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public SerializablePermission(string @string, string string1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getActions
				/// </java-name>
				[Dot42.DexImport("getActions", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string GetActions() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// implies
				/// </java-name>
				[Dot42.DexImport("implies", "(Ljava/security/Permission;)Z", AccessFlags = 1)]
				public override bool Implies(global::Java.Security.Permission permission) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal SerializablePermission() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getActions
				/// </java-name>
				public string Actions
				{
				[Dot42.DexImport("getActions", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetActions(); }
				}

		}

		/// <java-name>
		/// java/io/FileInputStream
		/// </java-name>
		[Dot42.DexImport("java/io/FileInputStream", AccessFlags = 33)]
		public partial class FileInputStream : global::Java.Io.InputStream, global::Java.Io.ICloseable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/io/File;)V", AccessFlags = 1)]
				public FileInputStream(global::Java.Io.File file) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/io/FileDescriptor;)V", AccessFlags = 1)]
				public FileInputStream(global::Java.Io.FileDescriptor fileDescriptor) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public FileInputStream(string @string) /* MethodBuilder.Create */ 
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
				/// finalize
				/// </java-name>
				[Dot42.DexImport("finalize", "()V", AccessFlags = 4)]
				extern ~FileInputStream() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getChannel
				/// </java-name>
				[Dot42.DexImport("getChannel", "()Ljava/nio/channels/FileChannel;", AccessFlags = 1)]
				public virtual global::Java.Nio.Channels.FileChannel GetChannel() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.Channels.FileChannel);
				}

				/// <java-name>
				/// getFD
				/// </java-name>
				[Dot42.DexImport("getFD", "()Ljava/io/FileDescriptor;", AccessFlags = 17)]
				public global::Java.Io.FileDescriptor GetFD() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.FileDescriptor);
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
				internal FileInputStream() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getChannel
				/// </java-name>
				public global::Java.Nio.Channels.FileChannel Channel
				{
				[Dot42.DexImport("getChannel", "()Ljava/nio/channels/FileChannel;", AccessFlags = 1)]
						get{ return GetChannel(); }
				}

				/// <java-name>
				/// getFD
				/// </java-name>
				public global::Java.Io.FileDescriptor FD
				{
				[Dot42.DexImport("getFD", "()Ljava/io/FileDescriptor;", AccessFlags = 17)]
						get{ return GetFD(); }
				}

		}

		/// <java-name>
		/// java/io/StringBufferInputStream
		/// </java-name>
		[Dot42.DexImport("java/io/StringBufferInputStream", AccessFlags = 33)]
		public partial class StringBufferInputStream : global::Java.Io.InputStream
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// buffer
				/// </java-name>
				[Dot42.DexImport("buffer", "Ljava/lang/String;", AccessFlags = 4)]
				protected internal string Buffer;
				/// <java-name>
				/// count
				/// </java-name>
				[Dot42.DexImport("count", "I", AccessFlags = 4)]
				protected internal int Count;
				/// <java-name>
				/// pos
				/// </java-name>
				[Dot42.DexImport("pos", "I", AccessFlags = 4)]
				protected internal int Pos;
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public StringBufferInputStream(string @string) /* MethodBuilder.Create */ 
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
				public override int Read(sbyte[] sByte, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([BII)I", AccessFlags = 33, IgnoreFromJava = true)]
				public override int Read(byte[] @byte, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// reset
				/// </java-name>
				[Dot42.DexImport("reset", "()V", AccessFlags = 33)]
				public override void Reset() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// skip
				/// </java-name>
				[Dot42.DexImport("skip", "(J)J", AccessFlags = 33)]
				public override long Skip(long int64) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal StringBufferInputStream() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// java/io/LineNumberReader
		/// </java-name>
		[Dot42.DexImport("java/io/LineNumberReader", AccessFlags = 33)]
		public partial class LineNumberReader : global::Java.Io.BufferedReader
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/io/Reader;)V", AccessFlags = 1)]
				public LineNumberReader(global::Java.Io.Reader reader) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/io/Reader;I)V", AccessFlags = 1)]
				public LineNumberReader(global::Java.Io.Reader reader, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getLineNumber
				/// </java-name>
				[Dot42.DexImport("getLineNumber", "()I", AccessFlags = 1)]
				public virtual int GetLineNumber() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// mark
				/// </java-name>
				[Dot42.DexImport("mark", "(I)V", AccessFlags = 1)]
				public override void Mark(int int32) /* MethodBuilder.Create */ 
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
				[Dot42.DexImport("read", "([CII)I", AccessFlags = 1)]
				public override int Read(char[] @char, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// readLine
				/// </java-name>
				[Dot42.DexImport("readLine", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ReadLine() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// reset
				/// </java-name>
				[Dot42.DexImport("reset", "()V", AccessFlags = 1)]
				public override void Reset() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setLineNumber
				/// </java-name>
				[Dot42.DexImport("setLineNumber", "(I)V", AccessFlags = 1)]
				public virtual void SetLineNumber(int int32) /* MethodBuilder.Create */ 
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

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal LineNumberReader() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getLineNumber
				/// </java-name>
				public int LineNumber
				{
				[Dot42.DexImport("getLineNumber", "()I", AccessFlags = 1)]
						get{ return GetLineNumber(); }
				[Dot42.DexImport("setLineNumber", "(I)V", AccessFlags = 1)]
						set{ SetLineNumber(value); }
				}

		}

		/// <java-name>
		/// java/io/PipedInputStream
		/// </java-name>
		[Dot42.DexImport("java/io/PipedInputStream", AccessFlags = 33)]
		public partial class PipedInputStream : global::Java.Io.InputStream
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// buffer
				/// </java-name>
				[Dot42.DexImport("buffer", "[B", AccessFlags = 4)]
				protected internal sbyte[] Buffer;
				/// <java-name>
				/// in
				/// </java-name>
				[Dot42.DexImport("in", "I", AccessFlags = 4)]
				protected internal int In;
				/// <java-name>
				/// out
				/// </java-name>
				[Dot42.DexImport("out", "I", AccessFlags = 4)]
				protected internal int Out;
				/// <java-name>
				/// PIPE_SIZE
				/// </java-name>
				[Dot42.DexImport("PIPE_SIZE", "I", AccessFlags = 28)]
				protected internal const int PIPE_SIZE = 1024;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public PipedInputStream() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/io/PipedOutputStream;)V", AccessFlags = 1)]
				public PipedInputStream(global::Java.Io.PipedOutputStream pipedOutputStream) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public PipedInputStream(int int32) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/io/PipedOutputStream;I)V", AccessFlags = 1)]
				public PipedInputStream(global::Java.Io.PipedOutputStream pipedOutputStream, int int32) /* MethodBuilder.Create */ 
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

				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 33)]
				public override void Close() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// connect
				/// </java-name>
				[Dot42.DexImport("connect", "(Ljava/io/PipedOutputStream;)V", AccessFlags = 1)]
				public virtual void Connect(global::Java.Io.PipedOutputStream pipedOutputStream) /* MethodBuilder.Create */ 
				{
				}

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
				public override int Read(sbyte[] sByte, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([BII)I", AccessFlags = 33, IgnoreFromJava = true)]
				public override int Read(byte[] @byte, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// receive
				/// </java-name>
				[Dot42.DexImport("receive", "(I)V", AccessFlags = 36)]
				protected internal virtual void Receive(int int32) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/io/UnsupportedEncodingException
		/// </java-name>
		[Dot42.DexImport("java/io/UnsupportedEncodingException", AccessFlags = 33)]
		public partial class UnsupportedEncodingException : global::System.IO.IOException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public UnsupportedEncodingException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public UnsupportedEncodingException(string @string) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/io/ObjectOutput
		/// </java-name>
		[Dot42.DexImport("java/io/ObjectOutput", AccessFlags = 1537)]
		public partial interface IObjectOutput : global::Java.Io.IDataOutput
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1025)]
				void Close() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// flush
				/// </java-name>
				[Dot42.DexImport("flush", "()V", AccessFlags = 1025)]
				void Flush() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([B)V", AccessFlags = 1025)]
				void Write(sbyte[] sByte) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([BII)V", AccessFlags = 1025)]
				void Write(sbyte[] sByte, int int32, int int321) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "(I)V", AccessFlags = 1025)]
				void Write(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// writeObject
				/// </java-name>
				[Dot42.DexImport("writeObject", "(Ljava/lang/Object;)V", AccessFlags = 1025)]
				void WriteObject(object @object) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// java/io/ByteArrayInputStream
		/// </java-name>
		[Dot42.DexImport("java/io/ByteArrayInputStream", AccessFlags = 33)]
		public partial class ByteArrayInputStream : global::Java.Io.InputStream
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// buf
				/// </java-name>
				[Dot42.DexImport("buf", "[B", AccessFlags = 4)]
				protected internal sbyte[] Buf;
				/// <java-name>
				/// pos
				/// </java-name>
				[Dot42.DexImport("pos", "I", AccessFlags = 4)]
				protected internal int Pos;
				/// <java-name>
				/// mark
				/// </java-name>
				[Dot42.DexImport("mark", "I", AccessFlags = 4)]
				protected internal int Mark0;
				/// <java-name>
				/// count
				/// </java-name>
				[Dot42.DexImport("count", "I", AccessFlags = 4)]
				protected internal int Count;
				[Dot42.DexImport("<init>", "([B)V", AccessFlags = 1)]
				public ByteArrayInputStream(sbyte[] sByte) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "([B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public ByteArrayInputStream(byte[] @byte) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "([BII)V", AccessFlags = 1)]
				public ByteArrayInputStream(sbyte[] sByte, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "([BII)V", AccessFlags = 1, IgnoreFromJava = true)]
				public ByteArrayInputStream(byte[] @byte, int int32, int int321) /* MethodBuilder.Create */ 
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
				[Dot42.DexImport("mark", "(I)V", AccessFlags = 33)]
				public override void Mark(int int32) /* MethodBuilder.Create */ 
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
				public override int Read(sbyte[] sByte, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([BII)I", AccessFlags = 33, IgnoreFromJava = true)]
				public override int Read(byte[] @byte, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// reset
				/// </java-name>
				[Dot42.DexImport("reset", "()V", AccessFlags = 33)]
				public override void Reset() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// skip
				/// </java-name>
				[Dot42.DexImport("skip", "(J)J", AccessFlags = 33)]
				public override long Skip(long int64) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ByteArrayInputStream() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// java/io/PipedOutputStream
		/// </java-name>
		[Dot42.DexImport("java/io/PipedOutputStream", AccessFlags = 33)]
		public partial class PipedOutputStream : global::Java.Io.OutputStream
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public PipedOutputStream() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/io/PipedInputStream;)V", AccessFlags = 1)]
				public PipedOutputStream(global::Java.Io.PipedInputStream pipedInputStream) /* MethodBuilder.Create */ 
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
				/// connect
				/// </java-name>
				[Dot42.DexImport("connect", "(Ljava/io/PipedInputStream;)V", AccessFlags = 1)]
				public virtual void Connect(global::Java.Io.PipedInputStream pipedInputStream) /* MethodBuilder.Create */ 
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
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "(I)V", AccessFlags = 1)]
				public override void Write(int int32) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/io/NotActiveException
		/// </java-name>
		[Dot42.DexImport("java/io/NotActiveException", AccessFlags = 33)]
		public partial class NotActiveException : global::Java.Io.ObjectStreamException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public NotActiveException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public NotActiveException(string @string) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/io/CharConversionException
		/// </java-name>
		[Dot42.DexImport("java/io/CharConversionException", AccessFlags = 33)]
		public partial class CharConversionException : global::System.IO.IOException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public CharConversionException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public CharConversionException(string @string) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/io/File
		/// </java-name>
		[Dot42.DexImport("java/io/File", AccessFlags = 33, Signature = "Ljava/lang/Object;Ljava/io/Serializable;Ljava/lang/Comparable<Ljava/io/File;>;")]
		public partial class File : global::Java.Io.ISerializable, global::System.IComparable<global::Java.Io.File>
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// separatorChar
				/// </java-name>
				[Dot42.DexImport("separatorChar", "C", AccessFlags = 25)]
				public static readonly char SeparatorChar;
				/// <java-name>
				/// separator
				/// </java-name>
				[Dot42.DexImport("separator", "Ljava/lang/String;", AccessFlags = 25)]
				public static readonly string Separator;
				/// <java-name>
				/// pathSeparatorChar
				/// </java-name>
				[Dot42.DexImport("pathSeparatorChar", "C", AccessFlags = 25)]
				public static readonly char PathSeparatorChar;
				/// <java-name>
				/// pathSeparator
				/// </java-name>
				[Dot42.DexImport("pathSeparator", "Ljava/lang/String;", AccessFlags = 25)]
				public static readonly string PathSeparator;
				[Dot42.DexImport("<init>", "(Ljava/io/File;Ljava/lang/String;)V", AccessFlags = 1)]
				public File(global::Java.Io.File file, string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public File(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public File(string @string, string string1) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/net/URI;)V", AccessFlags = 1)]
				public File(global::System.Uri uri) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// listRoots
				/// </java-name>
				[Dot42.DexImport("listRoots", "()[Ljava/io/File;", AccessFlags = 9)]
				public static global::Java.Io.File[] ListRoots() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.File[]);
				}

				/// <java-name>
				/// canExecute
				/// </java-name>
				[Dot42.DexImport("canExecute", "()Z", AccessFlags = 1)]
				public virtual bool CanExecute() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// canRead
				/// </java-name>
				[Dot42.DexImport("canRead", "()Z", AccessFlags = 1)]
				public virtual bool CanRead() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// canWrite
				/// </java-name>
				[Dot42.DexImport("canWrite", "()Z", AccessFlags = 1)]
				public virtual bool CanWrite() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// compareTo
				/// </java-name>
				[Dot42.DexImport("compareTo", "(Ljava/io/File;)I", AccessFlags = 1)]
				public virtual int CompareTo(global::Java.Io.File file) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// delete
				/// </java-name>
				[Dot42.DexImport("delete", "()Z", AccessFlags = 1)]
				public virtual bool Delete() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// deleteOnExit
				/// </java-name>
				[Dot42.DexImport("deleteOnExit", "()V", AccessFlags = 1)]
				public virtual void DeleteOnExit() /* MethodBuilder.Create */ 
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
				/// exists
				/// </java-name>
				[Dot42.DexImport("exists", "()Z", AccessFlags = 1)]
				public virtual bool Exists() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getAbsolutePath
				/// </java-name>
				[Dot42.DexImport("getAbsolutePath", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetAbsolutePath() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getAbsoluteFile
				/// </java-name>
				[Dot42.DexImport("getAbsoluteFile", "()Ljava/io/File;", AccessFlags = 1)]
				public virtual global::Java.Io.File GetAbsoluteFile() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.File);
				}

				/// <java-name>
				/// getCanonicalPath
				/// </java-name>
				[Dot42.DexImport("getCanonicalPath", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetCanonicalPath() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getCanonicalFile
				/// </java-name>
				[Dot42.DexImport("getCanonicalFile", "()Ljava/io/File;", AccessFlags = 1)]
				public virtual global::Java.Io.File GetCanonicalFile() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.File);
				}

				/// <java-name>
				/// getName
				/// </java-name>
				[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetName() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getParent
				/// </java-name>
				[Dot42.DexImport("getParent", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetParent() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getParentFile
				/// </java-name>
				[Dot42.DexImport("getParentFile", "()Ljava/io/File;", AccessFlags = 1)]
				public virtual global::Java.Io.File GetParentFile() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.File);
				}

				/// <java-name>
				/// getPath
				/// </java-name>
				[Dot42.DexImport("getPath", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetPath() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 1)]
				public override int GetHashCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// isAbsolute
				/// </java-name>
				[Dot42.DexImport("isAbsolute", "()Z", AccessFlags = 1)]
				public virtual bool IsAbsolute() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isDirectory
				/// </java-name>
				[Dot42.DexImport("isDirectory", "()Z", AccessFlags = 1)]
				public virtual bool IsDirectory() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isFile
				/// </java-name>
				[Dot42.DexImport("isFile", "()Z", AccessFlags = 1)]
				public virtual bool IsFile() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isHidden
				/// </java-name>
				[Dot42.DexImport("isHidden", "()Z", AccessFlags = 1)]
				public virtual bool IsHidden() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// lastModified
				/// </java-name>
				[Dot42.DexImport("lastModified", "()J", AccessFlags = 1)]
				public virtual long LastModified() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// setLastModified
				/// </java-name>
				[Dot42.DexImport("setLastModified", "(J)Z", AccessFlags = 1)]
				public virtual bool SetLastModified(long int64) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setReadOnly
				/// </java-name>
				[Dot42.DexImport("setReadOnly", "()Z", AccessFlags = 1)]
				public virtual bool SetReadOnly() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setExecutable
				/// </java-name>
				[Dot42.DexImport("setExecutable", "(ZZ)Z", AccessFlags = 1)]
				public virtual bool SetExecutable(bool boolean, bool boolean1) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setExecutable
				/// </java-name>
				[Dot42.DexImport("setExecutable", "(Z)Z", AccessFlags = 1)]
				public virtual bool SetExecutable(bool boolean) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setReadable
				/// </java-name>
				[Dot42.DexImport("setReadable", "(ZZ)Z", AccessFlags = 1)]
				public virtual bool SetReadable(bool boolean, bool boolean1) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setReadable
				/// </java-name>
				[Dot42.DexImport("setReadable", "(Z)Z", AccessFlags = 1)]
				public virtual bool SetReadable(bool boolean) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setWritable
				/// </java-name>
				[Dot42.DexImport("setWritable", "(ZZ)Z", AccessFlags = 1)]
				public virtual bool SetWritable(bool boolean, bool boolean1) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setWritable
				/// </java-name>
				[Dot42.DexImport("setWritable", "(Z)Z", AccessFlags = 1)]
				public virtual bool SetWritable(bool boolean) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// length
				/// </java-name>
				[Dot42.DexImport("length", "()J", AccessFlags = 1)]
				public virtual long Length() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// list
				/// </java-name>
				[Dot42.DexImport("list", "()[Ljava/lang/String;", AccessFlags = 1)]
				public virtual string[] List() /* MethodBuilder.Create */ 
				{
						return default(string[]);
				}

				/// <java-name>
				/// list
				/// </java-name>
				[Dot42.DexImport("list", "(Ljava/io/FilenameFilter;)[Ljava/lang/String;", AccessFlags = 1)]
				public virtual string[] List(global::Java.Io.IFilenameFilter filenameFilter) /* MethodBuilder.Create */ 
				{
						return default(string[]);
				}

				/// <java-name>
				/// listFiles
				/// </java-name>
				[Dot42.DexImport("listFiles", "()[Ljava/io/File;", AccessFlags = 1)]
				public virtual global::Java.Io.File[] ListFiles() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.File[]);
				}

				/// <java-name>
				/// listFiles
				/// </java-name>
				[Dot42.DexImport("listFiles", "(Ljava/io/FilenameFilter;)[Ljava/io/File;", AccessFlags = 1)]
				public virtual global::Java.Io.File[] ListFiles(global::Java.Io.IFilenameFilter filenameFilter) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.File[]);
				}

				/// <java-name>
				/// listFiles
				/// </java-name>
				[Dot42.DexImport("listFiles", "(Ljava/io/FileFilter;)[Ljava/io/File;", AccessFlags = 1)]
				public virtual global::Java.Io.File[] ListFiles(global::Java.Io.IFileFilter fileFilter) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.File[]);
				}

				/// <java-name>
				/// mkdir
				/// </java-name>
				[Dot42.DexImport("mkdir", "()Z", AccessFlags = 1)]
				public virtual bool Mkdir() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// mkdirs
				/// </java-name>
				[Dot42.DexImport("mkdirs", "()Z", AccessFlags = 1)]
				public virtual bool Mkdirs() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// createNewFile
				/// </java-name>
				[Dot42.DexImport("createNewFile", "()Z", AccessFlags = 1)]
				public virtual bool CreateNewFile() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// createTempFile
				/// </java-name>
				[Dot42.DexImport("createTempFile", "(Ljava/lang/String;Ljava/lang/String;)Ljava/io/File;", AccessFlags = 9)]
				public static global::Java.Io.File CreateTempFile(string @string, string string1) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.File);
				}

				/// <java-name>
				/// createTempFile
				/// </java-name>
				[Dot42.DexImport("createTempFile", "(Ljava/lang/String;Ljava/lang/String;Ljava/io/File;)Ljava/io/File;", AccessFlags = 9)]
				public static global::Java.Io.File CreateTempFile(string @string, string string1, global::Java.Io.File file) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.File);
				}

				/// <java-name>
				/// renameTo
				/// </java-name>
				[Dot42.DexImport("renameTo", "(Ljava/io/File;)Z", AccessFlags = 1)]
				public virtual bool RenameTo(global::Java.Io.File file) /* MethodBuilder.Create */ 
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

				/// <java-name>
				/// toURI
				/// </java-name>
				[Dot42.DexImport("toURI", "()Ljava/net/URI;", AccessFlags = 1)]
				public virtual global::System.Uri ToURI() /* MethodBuilder.Create */ 
				{
						return default(global::System.Uri);
				}

				/// <java-name>
				/// toURL
				/// </java-name>
				[Dot42.DexImport("toURL", "()Ljava/net/URL;", AccessFlags = 1)]
				public virtual global::Java.Net.URL ToURL() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.URL);
				}

				/// <java-name>
				/// getTotalSpace
				/// </java-name>
				[Dot42.DexImport("getTotalSpace", "()J", AccessFlags = 1)]
				public virtual long GetTotalSpace() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// getUsableSpace
				/// </java-name>
				[Dot42.DexImport("getUsableSpace", "()J", AccessFlags = 1)]
				public virtual long GetUsableSpace() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// getFreeSpace
				/// </java-name>
				[Dot42.DexImport("getFreeSpace", "()J", AccessFlags = 1)]
				public virtual long GetFreeSpace() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal File() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getAbsolutePath
				/// </java-name>
				public string AbsolutePath
				{
				[Dot42.DexImport("getAbsolutePath", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetAbsolutePath(); }
				}

				/// <java-name>
				/// getAbsoluteFile
				/// </java-name>
				public global::Java.Io.File AbsoluteFile
				{
				[Dot42.DexImport("getAbsoluteFile", "()Ljava/io/File;", AccessFlags = 1)]
						get{ return GetAbsoluteFile(); }
				}

				/// <java-name>
				/// getCanonicalPath
				/// </java-name>
				public string CanonicalPath
				{
				[Dot42.DexImport("getCanonicalPath", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetCanonicalPath(); }
				}

				/// <java-name>
				/// getCanonicalFile
				/// </java-name>
				public global::Java.Io.File CanonicalFile
				{
				[Dot42.DexImport("getCanonicalFile", "()Ljava/io/File;", AccessFlags = 1)]
						get{ return GetCanonicalFile(); }
				}

				/// <java-name>
				/// getName
				/// </java-name>
				public string Name
				{
				[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetName(); }
				}

				/// <java-name>
				/// getParent
				/// </java-name>
				public string Parent
				{
				[Dot42.DexImport("getParent", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetParent(); }
				}

				/// <java-name>
				/// getParentFile
				/// </java-name>
				public global::Java.Io.File ParentFile
				{
				[Dot42.DexImport("getParentFile", "()Ljava/io/File;", AccessFlags = 1)]
						get{ return GetParentFile(); }
				}

				/// <java-name>
				/// getPath
				/// </java-name>
				public string Path
				{
				[Dot42.DexImport("getPath", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetPath(); }
				}

				/// <java-name>
				/// getTotalSpace
				/// </java-name>
				public long TotalSpace
				{
				[Dot42.DexImport("getTotalSpace", "()J", AccessFlags = 1)]
						get{ return GetTotalSpace(); }
				}

				/// <java-name>
				/// getUsableSpace
				/// </java-name>
				public long UsableSpace
				{
				[Dot42.DexImport("getUsableSpace", "()J", AccessFlags = 1)]
						get{ return GetUsableSpace(); }
				}

				/// <java-name>
				/// getFreeSpace
				/// </java-name>
				public long FreeSpace
				{
				[Dot42.DexImport("getFreeSpace", "()J", AccessFlags = 1)]
						get{ return GetFreeSpace(); }
				}

		}

		/// <java-name>
		/// java/io/BufferedReader
		/// </java-name>
		[Dot42.DexImport("java/io/BufferedReader", AccessFlags = 33)]
		public partial class BufferedReader : global::Java.Io.Reader
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/io/Reader;)V", AccessFlags = 1)]
				public BufferedReader(global::Java.Io.Reader reader) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/io/Reader;I)V", AccessFlags = 1)]
				public BufferedReader(global::Java.Io.Reader reader, int int32) /* MethodBuilder.Create */ 
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
				/// mark
				/// </java-name>
				[Dot42.DexImport("mark", "(I)V", AccessFlags = 1)]
				public override void Mark(int int32) /* MethodBuilder.Create */ 
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
				[Dot42.DexImport("read", "([CII)I", AccessFlags = 1)]
				public override int Read(char[] @char, int int32, int int321) /* MethodBuilder.Create */ 
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
				/// ready
				/// </java-name>
				[Dot42.DexImport("ready", "()Z", AccessFlags = 1)]
				public override bool Ready() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// reset
				/// </java-name>
				[Dot42.DexImport("reset", "()V", AccessFlags = 1)]
				public override void Reset() /* MethodBuilder.Create */ 
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

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal BufferedReader() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// java/io/ObjectInputStream
		/// </java-name>
		[Dot42.DexImport("java/io/ObjectInputStream", AccessFlags = 33)]
		public partial class ObjectInputStream : global::Java.Io.InputStream, global::Java.Io.IObjectInput, global::Java.Io.IObjectStreamConstants
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal ObjectInputStream() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/io/InputStream;)V", AccessFlags = 1)]
				public ObjectInputStream(global::Java.Io.InputStream inputStream) /* MethodBuilder.Create */ 
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
				/// defaultReadObject
				/// </java-name>
				[Dot42.DexImport("defaultReadObject", "()V", AccessFlags = 1)]
				public virtual void DefaultReadObject() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// enableResolveObject
				/// </java-name>
				[Dot42.DexImport("enableResolveObject", "(Z)Z", AccessFlags = 4)]
				protected internal virtual bool EnableResolveObject(bool boolean) /* MethodBuilder.Create */ 
				{
						return default(bool);
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
				/// readBoolean
				/// </java-name>
				[Dot42.DexImport("readBoolean", "()Z", AccessFlags = 1)]
				public virtual bool ReadBoolean() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// readByte
				/// </java-name>
				[Dot42.DexImport("readByte", "()B", AccessFlags = 1)]
				public virtual sbyte JavaReadByte() /* MethodBuilder.Create */ 
				{
						return default(sbyte);
				}

				/// <java-name>
				/// readByte
				/// </java-name>
				[Dot42.DexImport("readByte", "()B", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual byte ReadByte() /* MethodBuilder.Create */ 
				{
						return default(byte);
				}

				/// <java-name>
				/// readChar
				/// </java-name>
				[Dot42.DexImport("readChar", "()C", AccessFlags = 1)]
				public virtual char ReadChar() /* MethodBuilder.Create */ 
				{
						return default(char);
				}

				/// <java-name>
				/// readDouble
				/// </java-name>
				[Dot42.DexImport("readDouble", "()D", AccessFlags = 1)]
				public virtual double ReadDouble() /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <java-name>
				/// readFields
				/// </java-name>
				[Dot42.DexImport("readFields", "()Ljava/io/ObjectInputStream$GetField;", AccessFlags = 1)]
				public virtual global::Java.Io.ObjectInputStream.GetField ReadFields() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.ObjectInputStream.GetField);
				}

				/// <java-name>
				/// readFloat
				/// </java-name>
				[Dot42.DexImport("readFloat", "()F", AccessFlags = 1)]
				public virtual float ReadFloat() /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// readFully
				/// </java-name>
				[Dot42.DexImport("readFully", "([B)V", AccessFlags = 1)]
				public virtual void ReadFully(sbyte[] sByte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// readFully
				/// </java-name>
				[Dot42.DexImport("readFully", "([B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual void ReadFully(byte[] @byte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// readFully
				/// </java-name>
				[Dot42.DexImport("readFully", "([BII)V", AccessFlags = 1)]
				public virtual void ReadFully(sbyte[] sByte, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// readFully
				/// </java-name>
				[Dot42.DexImport("readFully", "([BII)V", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual void ReadFully(byte[] @byte, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// readInt
				/// </java-name>
				[Dot42.DexImport("readInt", "()I", AccessFlags = 1)]
				public virtual int ReadInt() /* MethodBuilder.Create */ 
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
				/// readLong
				/// </java-name>
				[Dot42.DexImport("readLong", "()J", AccessFlags = 1)]
				public virtual long ReadLong() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// readClassDescriptor
				/// </java-name>
				[Dot42.DexImport("readClassDescriptor", "()Ljava/io/ObjectStreamClass;", AccessFlags = 4)]
				protected internal virtual global::Java.Io.ObjectStreamClass ReadClassDescriptor() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.ObjectStreamClass);
				}

				/// <java-name>
				/// resolveProxyClass
				/// </java-name>
				[Dot42.DexImport("resolveProxyClass", "([Ljava/lang/String;)Ljava/lang/Class;", AccessFlags = 4, Signature = "([Ljava/lang/String;)Ljava/lang/Class<*>;")]
				protected internal virtual global::System.Type ResolveProxyClass(string[] @string) /* MethodBuilder.Create */ 
				{
						return default(global::System.Type);
				}

				/// <java-name>
				/// readObject
				/// </java-name>
				[Dot42.DexImport("readObject", "()Ljava/lang/Object;", AccessFlags = 17)]
				public object ReadObject() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <java-name>
				/// readUnshared
				/// </java-name>
				[Dot42.DexImport("readUnshared", "()Ljava/lang/Object;", AccessFlags = 1)]
				public virtual object ReadUnshared() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <java-name>
				/// readObjectOverride
				/// </java-name>
				[Dot42.DexImport("readObjectOverride", "()Ljava/lang/Object;", AccessFlags = 4)]
				protected internal virtual object ReadObjectOverride() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <java-name>
				/// readShort
				/// </java-name>
				[Dot42.DexImport("readShort", "()S", AccessFlags = 1)]
				public virtual short ReadShort() /* MethodBuilder.Create */ 
				{
						return default(short);
				}

				/// <java-name>
				/// readStreamHeader
				/// </java-name>
				[Dot42.DexImport("readStreamHeader", "()V", AccessFlags = 4)]
				protected internal virtual void ReadStreamHeader() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// readUnsignedByte
				/// </java-name>
				[Dot42.DexImport("readUnsignedByte", "()I", AccessFlags = 1)]
				public virtual int ReadUnsignedByte() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// readUnsignedShort
				/// </java-name>
				[Dot42.DexImport("readUnsignedShort", "()I", AccessFlags = 1)]
				public virtual int ReadUnsignedShort() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// readUTF
				/// </java-name>
				[Dot42.DexImport("readUTF", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string ReadUTF() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// registerValidation
				/// </java-name>
				[Dot42.DexImport("registerValidation", "(Ljava/io/ObjectInputValidation;I)V", AccessFlags = 33)]
				public virtual void RegisterValidation(global::Java.Io.IObjectInputValidation objectInputValidation, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// resolveClass
				/// </java-name>
				[Dot42.DexImport("resolveClass", "(Ljava/io/ObjectStreamClass;)Ljava/lang/Class;", AccessFlags = 4, Signature = "(Ljava/io/ObjectStreamClass;)Ljava/lang/Class<*>;")]
				protected internal virtual global::System.Type ResolveClass(global::Java.Io.ObjectStreamClass objectStreamClass) /* MethodBuilder.Create */ 
				{
						return default(global::System.Type);
				}

				/// <java-name>
				/// resolveObject
				/// </java-name>
				[Dot42.DexImport("resolveObject", "(Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 4)]
				protected internal virtual object ResolveObject(object @object) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <java-name>
				/// skipBytes
				/// </java-name>
				[Dot42.DexImport("skipBytes", "(I)I", AccessFlags = 1)]
				public virtual int SkipBytes(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				[Dot42.DexImport("java/io/ObjectInput", "read", "([B)I", AccessFlags = 1025)]
				public override int Read(sbyte[] sByte) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(int);
				}

				[Dot42.DexImport("java/io/ObjectInput", "skip", "(J)J", AccessFlags = 1025)]
				public override long Skip(long int64) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(long);
				}

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

						/// <java-name>
						/// getObjectStreamClass
						/// </java-name>
						[Dot42.DexImport("getObjectStreamClass", "()Ljava/io/ObjectStreamClass;", AccessFlags = 1025)]
						public abstract global::Java.Io.ObjectStreamClass GetObjectStreamClass() /* MethodBuilder.Create */ ;

						/// <java-name>
						/// defaulted
						/// </java-name>
						[Dot42.DexImport("defaulted", "(Ljava/lang/String;)Z", AccessFlags = 1025)]
						public abstract bool Defaulted(string @string) /* MethodBuilder.Create */ ;

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

						/// <java-name>
						/// getObjectStreamClass
						/// </java-name>
						public global::Java.Io.ObjectStreamClass ObjectStreamClass
						{
						[Dot42.DexImport("getObjectStreamClass", "()Ljava/io/ObjectStreamClass;", AccessFlags = 1025)]
								get{ return GetObjectStreamClass(); }
						}

				}

		}

		/// <java-name>
		/// java/io/BufferedOutputStream
		/// </java-name>
		[Dot42.DexImport("java/io/BufferedOutputStream", AccessFlags = 33)]
		public partial class BufferedOutputStream : global::Java.Io.FilterOutputStream
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// buf
				/// </java-name>
				[Dot42.DexImport("buf", "[B", AccessFlags = 4)]
				protected internal sbyte[] Buf;
				/// <java-name>
				/// count
				/// </java-name>
				[Dot42.DexImport("count", "I", AccessFlags = 4)]
				protected internal int Count;
				[Dot42.DexImport("<init>", "(Ljava/io/OutputStream;)V", AccessFlags = 1)]
				public BufferedOutputStream(global::Java.Io.OutputStream outputStream) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/io/OutputStream;I)V", AccessFlags = 1)]
				public BufferedOutputStream(global::Java.Io.OutputStream outputStream, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// flush
				/// </java-name>
				[Dot42.DexImport("flush", "()V", AccessFlags = 33)]
				public override void Flush() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([BII)V", AccessFlags = 33)]
				public override void Write(sbyte[] sByte, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([BII)V", AccessFlags = 33, IgnoreFromJava = true)]
				public override void Write(byte[] @byte, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 33)]
				public override void Close() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "(I)V", AccessFlags = 33)]
				public override void Write(int int32) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal BufferedOutputStream() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// java/io/OutputStream
		/// </java-name>
		[Dot42.DexImport("java/io/OutputStream", AccessFlags = 1057)]
		public abstract partial class OutputStream : global::Java.Io.ICloseable, global::Java.Io.IFlushable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public OutputStream() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1)]
				public virtual void Close() /* MethodBuilder.Create */ 
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
				[Dot42.DexImport("write", "([B)V", AccessFlags = 1)]
				public virtual void Write(sbyte[] sByte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual void Write(byte[] @byte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([BII)V", AccessFlags = 1)]
				public virtual void Write(sbyte[] sByte, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([BII)V", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual void Write(byte[] @byte, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "(I)V", AccessFlags = 1025)]
				public abstract void Write(int int32) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// java/io/FilenameFilter
		/// </java-name>
		[Dot42.DexImport("java/io/FilenameFilter", AccessFlags = 1537)]
		public partial interface IFilenameFilter
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// accept
				/// </java-name>
				[Dot42.DexImport("accept", "(Ljava/io/File;Ljava/lang/String;)Z", AccessFlags = 1025)]
				bool Accept(global::Java.Io.File file, string @string) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// java/io/StringReader
		/// </java-name>
		[Dot42.DexImport("java/io/StringReader", AccessFlags = 33)]
		public partial class StringReader : global::Java.Io.Reader
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public StringReader(string @string) /* MethodBuilder.Create */ 
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
				/// mark
				/// </java-name>
				[Dot42.DexImport("mark", "(I)V", AccessFlags = 1)]
				public override void Mark(int int32) /* MethodBuilder.Create */ 
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
				[Dot42.DexImport("read", "([CII)I", AccessFlags = 1)]
				public override int Read(char[] @char, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// ready
				/// </java-name>
				[Dot42.DexImport("ready", "()Z", AccessFlags = 1)]
				public override bool Ready() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// reset
				/// </java-name>
				[Dot42.DexImport("reset", "()V", AccessFlags = 1)]
				public override void Reset() /* MethodBuilder.Create */ 
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

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal StringReader() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// java/io/FilterOutputStream
		/// </java-name>
		[Dot42.DexImport("java/io/FilterOutputStream", AccessFlags = 33)]
		public partial class FilterOutputStream : global::Java.Io.OutputStream
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// out
				/// </java-name>
				[Dot42.DexImport("out", "Ljava/io/OutputStream;", AccessFlags = 4)]
				protected internal global::Java.Io.OutputStream Out;
				[Dot42.DexImport("<init>", "(Ljava/io/OutputStream;)V", AccessFlags = 1)]
				public FilterOutputStream(global::Java.Io.OutputStream outputStream) /* MethodBuilder.Create */ 
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
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "(I)V", AccessFlags = 1)]
				public override void Write(int int32) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal FilterOutputStream() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// java/io/InputStream
		/// </java-name>
		[Dot42.DexImport("java/io/InputStream", AccessFlags = 1057)]
		public abstract partial class InputStream : global::Java.Io.ICloseable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public InputStream() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// available
				/// </java-name>
				[Dot42.DexImport("available", "()I", AccessFlags = 1)]
				public virtual int Available() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1)]
				public virtual void Close() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// mark
				/// </java-name>
				[Dot42.DexImport("mark", "(I)V", AccessFlags = 1)]
				public virtual void Mark(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// markSupported
				/// </java-name>
				[Dot42.DexImport("markSupported", "()Z", AccessFlags = 1)]
				public virtual bool MarkSupported() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "()I", AccessFlags = 1025)]
				public abstract int Read() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([B)I", AccessFlags = 1)]
				public virtual int Read(sbyte[] sByte) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([B)I", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual int Read(byte[] @byte) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([BII)I", AccessFlags = 1)]
				public virtual int Read(sbyte[] sByte, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([BII)I", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual int Read(byte[] @byte, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// reset
				/// </java-name>
				[Dot42.DexImport("reset", "()V", AccessFlags = 33)]
				public virtual void Reset() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// skip
				/// </java-name>
				[Dot42.DexImport("skip", "(J)J", AccessFlags = 1)]
				public virtual long Skip(long int64) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

		}

		/// <java-name>
		/// java/io/ObjectInput
		/// </java-name>
		[Dot42.DexImport("java/io/ObjectInput", AccessFlags = 1537)]
		public partial interface IObjectInput : global::Java.Io.IDataInput
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// available
				/// </java-name>
				[Dot42.DexImport("available", "()I", AccessFlags = 1025)]
				int Available() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1025)]
				void Close() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "()I", AccessFlags = 1025)]
				int Read() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([B)I", AccessFlags = 1025)]
				int Read(sbyte[] sByte) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([BII)I", AccessFlags = 1025)]
				int Read(sbyte[] sByte, int int32, int int321) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// readObject
				/// </java-name>
				[Dot42.DexImport("readObject", "()Ljava/lang/Object;", AccessFlags = 1025)]
				object ReadObject() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// skip
				/// </java-name>
				[Dot42.DexImport("skip", "(J)J", AccessFlags = 1025)]
				long Skip(long int64) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// java/io/FileDescriptor
		/// </java-name>
		[Dot42.DexImport("java/io/FileDescriptor", AccessFlags = 49)]
		public sealed partial class FileDescriptor
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// in
				/// </java-name>
				[Dot42.DexImport("in", "Ljava/io/FileDescriptor;", AccessFlags = 25)]
				public static readonly global::Java.Io.FileDescriptor In;
				/// <java-name>
				/// out
				/// </java-name>
				[Dot42.DexImport("out", "Ljava/io/FileDescriptor;", AccessFlags = 25)]
				public static readonly global::Java.Io.FileDescriptor Out;
				/// <java-name>
				/// err
				/// </java-name>
				[Dot42.DexImport("err", "Ljava/io/FileDescriptor;", AccessFlags = 25)]
				public static readonly global::Java.Io.FileDescriptor Err;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public FileDescriptor() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// sync
				/// </java-name>
				[Dot42.DexImport("sync", "()V", AccessFlags = 1)]
				public void Sync() /* MethodBuilder.Create */ 
				{
				}

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

		/// <java-name>
		/// java/io/PrintStream
		/// </java-name>
		[Dot42.DexImport("java/io/PrintStream", AccessFlags = 33)]
		public partial class PrintStream : global::Java.Io.FilterOutputStream, global::Java.Lang.IAppendable, global::Java.Io.ICloseable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/io/OutputStream;)V", AccessFlags = 1)]
				public PrintStream(global::Java.Io.OutputStream outputStream) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/io/OutputStream;Z)V", AccessFlags = 1)]
				public PrintStream(global::Java.Io.OutputStream outputStream, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/io/OutputStream;ZLjava/lang/String;)V", AccessFlags = 1)]
				public PrintStream(global::Java.Io.OutputStream outputStream, bool boolean, string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/io/File;)V", AccessFlags = 1)]
				public PrintStream(global::Java.Io.File file) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/io/File;Ljava/lang/String;)V", AccessFlags = 1)]
				public PrintStream(global::Java.Io.File file, string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public PrintStream(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public PrintStream(string @string, string string1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// checkError
				/// </java-name>
				[Dot42.DexImport("checkError", "()Z", AccessFlags = 1)]
				public virtual bool CheckError() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// clearError
				/// </java-name>
				[Dot42.DexImport("clearError", "()V", AccessFlags = 4)]
				protected internal virtual void ClearError() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 33)]
				public override void Close() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// flush
				/// </java-name>
				[Dot42.DexImport("flush", "()V", AccessFlags = 33)]
				public override void Flush() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// format
				/// </java-name>
				[Dot42.DexImport("format", "(Ljava/lang/String;[Ljava/lang/Object;)Ljava/io/PrintStream;", AccessFlags = 129)]
				public virtual global::Java.Io.PrintStream Format(string @string, params object[] @object) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.PrintStream);
				}

				/// <java-name>
				/// format
				/// </java-name>
				[Dot42.DexImport("format", "(Ljava/util/Locale;Ljava/lang/String;[Ljava/lang/Object;)Ljava/io/PrintStream;", AccessFlags = 129)]
				public virtual global::Java.Io.PrintStream Format(global::Java.Util.Locale locale, string @string, params object[] @object) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.PrintStream);
				}

				/// <java-name>
				/// printf
				/// </java-name>
				[Dot42.DexImport("printf", "(Ljava/lang/String;[Ljava/lang/Object;)Ljava/io/PrintStream;", AccessFlags = 129)]
				public virtual global::Java.Io.PrintStream Printf(string @string, params object[] @object) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.PrintStream);
				}

				/// <java-name>
				/// printf
				/// </java-name>
				[Dot42.DexImport("printf", "(Ljava/util/Locale;Ljava/lang/String;[Ljava/lang/Object;)Ljava/io/PrintStream;", AccessFlags = 129)]
				public virtual global::Java.Io.PrintStream Printf(global::Java.Util.Locale locale, string @string, params object[] @object) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.PrintStream);
				}

				/// <java-name>
				/// print
				/// </java-name>
				[Dot42.DexImport("print", "([C)V", AccessFlags = 1)]
				public virtual void Print(char[] @char) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// print
				/// </java-name>
				[Dot42.DexImport("print", "(C)V", AccessFlags = 1)]
				public virtual void Print(char @char) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// print
				/// </java-name>
				[Dot42.DexImport("print", "(D)V", AccessFlags = 1)]
				public virtual void Print(double @double) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// print
				/// </java-name>
				[Dot42.DexImport("print", "(F)V", AccessFlags = 1)]
				public virtual void Print(float single) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// print
				/// </java-name>
				[Dot42.DexImport("print", "(I)V", AccessFlags = 1)]
				public virtual void Print(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// print
				/// </java-name>
				[Dot42.DexImport("print", "(J)V", AccessFlags = 1)]
				public virtual void Print(long int64) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// print
				/// </java-name>
				[Dot42.DexImport("print", "(Ljava/lang/Object;)V", AccessFlags = 1)]
				public virtual void Print(object @object) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// print
				/// </java-name>
				[Dot42.DexImport("print", "(Ljava/lang/String;)V", AccessFlags = 33)]
				public virtual void Print(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// print
				/// </java-name>
				[Dot42.DexImport("print", "(Z)V", AccessFlags = 1)]
				public virtual void Print(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// println
				/// </java-name>
				[Dot42.DexImport("println", "()V", AccessFlags = 1)]
				public virtual void Println() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// println
				/// </java-name>
				[Dot42.DexImport("println", "([C)V", AccessFlags = 1)]
				public virtual void Println(char[] @char) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// println
				/// </java-name>
				[Dot42.DexImport("println", "(C)V", AccessFlags = 1)]
				public virtual void Println(char @char) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// println
				/// </java-name>
				[Dot42.DexImport("println", "(D)V", AccessFlags = 1)]
				public virtual void Println(double @double) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// println
				/// </java-name>
				[Dot42.DexImport("println", "(F)V", AccessFlags = 1)]
				public virtual void Println(float single) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// println
				/// </java-name>
				[Dot42.DexImport("println", "(I)V", AccessFlags = 1)]
				public virtual void Println(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// println
				/// </java-name>
				[Dot42.DexImport("println", "(J)V", AccessFlags = 1)]
				public virtual void Println(long int64) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// println
				/// </java-name>
				[Dot42.DexImport("println", "(Ljava/lang/Object;)V", AccessFlags = 1)]
				public virtual void Println(object @object) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// println
				/// </java-name>
				[Dot42.DexImport("println", "(Ljava/lang/String;)V", AccessFlags = 33)]
				public virtual void Println(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// println
				/// </java-name>
				[Dot42.DexImport("println", "(Z)V", AccessFlags = 1)]
				public virtual void Println(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setError
				/// </java-name>
				[Dot42.DexImport("setError", "()V", AccessFlags = 4)]
				protected internal virtual void SetError() /* MethodBuilder.Create */ 
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
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "(I)V", AccessFlags = 33)]
				public override void Write(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// append
				/// </java-name>
				[Dot42.DexImport("append", "(C)Ljava/io/PrintStream;", AccessFlags = 1)]
				public virtual global::Java.Io.PrintStream Append(char @char) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.PrintStream);
				}

				/// <java-name>
				/// append
				/// </java-name>
				[Dot42.DexImport("append", "(Ljava/lang/CharSequence;)Ljava/io/PrintStream;", AccessFlags = 1)]
				public virtual global::Java.Io.PrintStream Append(global::Java.Lang.ICharSequence charSequence) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.PrintStream);
				}

				/// <java-name>
				/// append
				/// </java-name>
				[Dot42.DexImport("append", "(Ljava/lang/CharSequence;II)Ljava/io/PrintStream;", AccessFlags = 1)]
				public virtual global::Java.Io.PrintStream JavaAppend(global::Java.Lang.ICharSequence charSequence, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.PrintStream);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal PrintStream() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				[Dot42.DexImport("java/lang/Appendable", "append", "(C)Ljava/lang/Appendable;", AccessFlags = 1025)]
				global::Java.Lang.IAppendable global::Java.Lang.IAppendable.Append(char @char) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Java.Lang.IAppendable);
				}

				[Dot42.DexImport("java/lang/Appendable", "append", "(Ljava/lang/CharSequence;)Ljava/lang/Appendable;", AccessFlags = 1025)]
				global::Java.Lang.IAppendable global::Java.Lang.IAppendable.Append(global::Java.Lang.ICharSequence charSequence) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Java.Lang.IAppendable);
				}

				[Dot42.DexImport("java/lang/Appendable", "append", "(Ljava/lang/CharSequence;II)Ljava/lang/Appendable;", AccessFlags = 1025)]
				global::Java.Lang.IAppendable global::Java.Lang.IAppendable.JavaAppend(global::Java.Lang.ICharSequence charSequence, int int32, int int321) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Java.Lang.IAppendable);
				}

		}

		/// <java-name>
		/// java/io/Serializable
		/// </java-name>
		[Dot42.DexImport("java/io/Serializable", AccessFlags = 1537)]
		public partial interface ISerializable
 /* scope: __dot42__ */ 
		{
		}

		/// <java-name>
		/// java/io/Closeable
		/// </java-name>
		[Dot42.DexImport("java/io/Closeable", AccessFlags = 1537)]
		public partial interface ICloseable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1025)]
				void Close() /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// java/io/FilterReader
		/// </java-name>
		[Dot42.DexImport("java/io/FilterReader", AccessFlags = 1057)]
		public abstract partial class FilterReader : global::Java.Io.Reader
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// in
				/// </java-name>
				[Dot42.DexImport("in", "Ljava/io/Reader;", AccessFlags = 4)]
				protected internal global::Java.Io.Reader In;
				[Dot42.DexImport("<init>", "(Ljava/io/Reader;)V", AccessFlags = 4)]
				protected internal FilterReader(global::Java.Io.Reader reader) /* MethodBuilder.Create */ 
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
				/// mark
				/// </java-name>
				[Dot42.DexImport("mark", "(I)V", AccessFlags = 33)]
				public override void Mark(int int32) /* MethodBuilder.Create */ 
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
				[Dot42.DexImport("read", "([CII)I", AccessFlags = 1)]
				public override int Read(char[] @char, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// ready
				/// </java-name>
				[Dot42.DexImport("ready", "()Z", AccessFlags = 1)]
				public override bool Ready() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// reset
				/// </java-name>
				[Dot42.DexImport("reset", "()V", AccessFlags = 1)]
				public override void Reset() /* MethodBuilder.Create */ 
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

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal FilterReader() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// java/io/ObjectInputValidation
		/// </java-name>
		[Dot42.DexImport("java/io/ObjectInputValidation", AccessFlags = 1537)]
		public partial interface IObjectInputValidation
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// validateObject
				/// </java-name>
				[Dot42.DexImport("validateObject", "()V", AccessFlags = 1025)]
				void ValidateObject() /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// java/io/DataInput
		/// </java-name>
		[Dot42.DexImport("java/io/DataInput", AccessFlags = 1537)]
		public partial interface IDataInput
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// readBoolean
				/// </java-name>
				[Dot42.DexImport("readBoolean", "()Z", AccessFlags = 1025)]
				bool ReadBoolean() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// readByte
				/// </java-name>
				[Dot42.DexImport("readByte", "()B", AccessFlags = 1025, IgnoreFromJava = true)]
				byte ReadByte() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// readChar
				/// </java-name>
				[Dot42.DexImport("readChar", "()C", AccessFlags = 1025)]
				char ReadChar() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// readDouble
				/// </java-name>
				[Dot42.DexImport("readDouble", "()D", AccessFlags = 1025)]
				double ReadDouble() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// readFloat
				/// </java-name>
				[Dot42.DexImport("readFloat", "()F", AccessFlags = 1025)]
				float ReadFloat() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// readFully
				/// </java-name>
				[Dot42.DexImport("readFully", "([B)V", AccessFlags = 1025)]
				void ReadFully(sbyte[] sByte) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// readFully
				/// </java-name>
				[Dot42.DexImport("readFully", "([BII)V", AccessFlags = 1025)]
				void ReadFully(sbyte[] sByte, int int32, int int321) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// readInt
				/// </java-name>
				[Dot42.DexImport("readInt", "()I", AccessFlags = 1025)]
				int ReadInt() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// readLine
				/// </java-name>
				[Dot42.DexImport("readLine", "()Ljava/lang/String;", AccessFlags = 1025)]
				string ReadLine() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// readLong
				/// </java-name>
				[Dot42.DexImport("readLong", "()J", AccessFlags = 1025)]
				long ReadLong() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// readShort
				/// </java-name>
				[Dot42.DexImport("readShort", "()S", AccessFlags = 1025)]
				short ReadShort() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// readUnsignedByte
				/// </java-name>
				[Dot42.DexImport("readUnsignedByte", "()I", AccessFlags = 1025)]
				int ReadUnsignedByte() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// readUnsignedShort
				/// </java-name>
				[Dot42.DexImport("readUnsignedShort", "()I", AccessFlags = 1025)]
				int ReadUnsignedShort() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// readUTF
				/// </java-name>
				[Dot42.DexImport("readUTF", "()Ljava/lang/String;", AccessFlags = 1025)]
				string ReadUTF() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// skipBytes
				/// </java-name>
				[Dot42.DexImport("skipBytes", "(I)I", AccessFlags = 1025)]
				int SkipBytes(int int32) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// java/io/FilterWriter
		/// </java-name>
		[Dot42.DexImport("java/io/FilterWriter", AccessFlags = 1057)]
		public abstract partial class FilterWriter : global::Java.Io.Writer
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// out
				/// </java-name>
				[Dot42.DexImport("out", "Ljava/io/Writer;", AccessFlags = 4)]
				protected internal global::Java.Io.Writer Out;
				[Dot42.DexImport("<init>", "(Ljava/io/Writer;)V", AccessFlags = 4)]
				protected internal FilterWriter(global::Java.Io.Writer writer) /* MethodBuilder.Create */ 
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
				[Dot42.DexImport("write", "([CII)V", AccessFlags = 1)]
				public override void Write(char[] @char, int int32, int int321) /* MethodBuilder.Create */ 
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
				[Dot42.DexImport("write", "(Ljava/lang/String;II)V", AccessFlags = 1)]
				public override void Write(string @string, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal FilterWriter() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// java/io/Flushable
		/// </java-name>
		[Dot42.DexImport("java/io/Flushable", AccessFlags = 1537)]
		public partial interface IFlushable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// flush
				/// </java-name>
				[Dot42.DexImport("flush", "()V", AccessFlags = 1025)]
				void Flush() /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// java/io/UTFDataFormatException
		/// </java-name>
		[Dot42.DexImport("java/io/UTFDataFormatException", AccessFlags = 33)]
		public partial class UTFDataFormatException : global::System.IO.IOException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public UTFDataFormatException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public UTFDataFormatException(string @string) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/io/Console
		/// </java-name>
		[Dot42.DexImport("java/io/Console", AccessFlags = 49)]
		public sealed partial class Console : global::Java.Io.IFlushable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal Console() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// flush
				/// </java-name>
				[Dot42.DexImport("flush", "()V", AccessFlags = 1)]
				public void Flush() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// format
				/// </java-name>
				[Dot42.DexImport("format", "(Ljava/lang/String;[Ljava/lang/Object;)Ljava/io/Console;", AccessFlags = 129)]
				public global::Java.Io.Console Format(string @string, params object[] @object) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.Console);
				}

				/// <java-name>
				/// printf
				/// </java-name>
				[Dot42.DexImport("printf", "(Ljava/lang/String;[Ljava/lang/Object;)Ljava/io/Console;", AccessFlags = 129)]
				public global::Java.Io.Console Printf(string @string, params object[] @object) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.Console);
				}

				/// <java-name>
				/// reader
				/// </java-name>
				[Dot42.DexImport("reader", "()Ljava/io/Reader;", AccessFlags = 1)]
				public global::Java.Io.Reader Reader() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.Reader);
				}

				/// <java-name>
				/// readLine
				/// </java-name>
				[Dot42.DexImport("readLine", "()Ljava/lang/String;", AccessFlags = 1)]
				public string ReadLine() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// readLine
				/// </java-name>
				[Dot42.DexImport("readLine", "(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;", AccessFlags = 129)]
				public string ReadLine(string @string, params object[] @object) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// readPassword
				/// </java-name>
				[Dot42.DexImport("readPassword", "()[C", AccessFlags = 1)]
				public char[] ReadPassword() /* MethodBuilder.Create */ 
				{
						return default(char[]);
				}

				/// <java-name>
				/// readPassword
				/// </java-name>
				[Dot42.DexImport("readPassword", "(Ljava/lang/String;[Ljava/lang/Object;)[C", AccessFlags = 129)]
				public char[] ReadPassword(string @string, params object[] @object) /* MethodBuilder.Create */ 
				{
						return default(char[]);
				}

				/// <java-name>
				/// writer
				/// </java-name>
				[Dot42.DexImport("writer", "()Ljava/io/PrintWriter;", AccessFlags = 1)]
				public global::Java.Io.PrintWriter Writer() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.PrintWriter);
				}

		}

		/// <java-name>
		/// java/io/ByteArrayOutputStream
		/// </java-name>
		[Dot42.DexImport("java/io/ByteArrayOutputStream", AccessFlags = 33)]
		public partial class ByteArrayOutputStream : global::Java.Io.OutputStream
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// buf
				/// </java-name>
				[Dot42.DexImport("buf", "[B", AccessFlags = 4)]
				protected internal sbyte[] Buf;
				/// <java-name>
				/// count
				/// </java-name>
				[Dot42.DexImport("count", "I", AccessFlags = 4)]
				protected internal int Count;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ByteArrayOutputStream() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public ByteArrayOutputStream(int int32) /* MethodBuilder.Create */ 
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
				/// reset
				/// </java-name>
				[Dot42.DexImport("reset", "()V", AccessFlags = 33)]
				public virtual void Reset() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// size
				/// </java-name>
				[Dot42.DexImport("size", "()I", AccessFlags = 1)]
				public virtual int Size() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// toByteArray
				/// </java-name>
				[Dot42.DexImport("toByteArray", "()[B", AccessFlags = 33)]
				public virtual sbyte[] JavaToByteArray() /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <java-name>
				/// toByteArray
				/// </java-name>
				[Dot42.DexImport("toByteArray", "()[B", AccessFlags = 33, IgnoreFromJava = true)]
				public virtual byte[] ToByteArray() /* MethodBuilder.Create */ 
				{
						return default(byte[]);
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
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "(I)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string ToString(int int32) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string ToString(string @string) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([BII)V", AccessFlags = 33)]
				public override void Write(sbyte[] sByte, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([BII)V", AccessFlags = 33, IgnoreFromJava = true)]
				public override void Write(byte[] @byte, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "(I)V", AccessFlags = 33)]
				public override void Write(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writeTo
				/// </java-name>
				[Dot42.DexImport("writeTo", "(Ljava/io/OutputStream;)V", AccessFlags = 33)]
				public virtual void WriteTo(global::Java.Io.OutputStream outputStream) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/io/WriteAbortedException
		/// </java-name>
		[Dot42.DexImport("java/io/WriteAbortedException", AccessFlags = 33)]
		public partial class WriteAbortedException : global::Java.Io.ObjectStreamException
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// detail
				/// </java-name>
				[Dot42.DexImport("detail", "Ljava/lang/Exception;", AccessFlags = 1)]
				public global::System.Exception Detail;
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Exception;)V", AccessFlags = 1)]
				public WriteAbortedException(string @string, global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getMessage
				/// </java-name>
				[Dot42.DexImport("getMessage", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string GetMessage() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getCause
				/// </java-name>
				[Dot42.DexImport("getCause", "()Ljava/lang/Throwable;", AccessFlags = 1)]
				public override global::System.Exception GetCause() /* MethodBuilder.Create */ 
				{
						return default(global::System.Exception);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal WriteAbortedException() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// java/io/FileFilter
		/// </java-name>
		[Dot42.DexImport("java/io/FileFilter", AccessFlags = 1537)]
		public partial interface IFileFilter
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// accept
				/// </java-name>
				[Dot42.DexImport("accept", "(Ljava/io/File;)Z", AccessFlags = 1025)]
				bool Accept(global::Java.Io.File file) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// java/io/PipedWriter
		/// </java-name>
		[Dot42.DexImport("java/io/PipedWriter", AccessFlags = 33)]
		public partial class PipedWriter : global::Java.Io.Writer
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public PipedWriter() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/io/PipedReader;)V", AccessFlags = 1)]
				public PipedWriter(global::Java.Io.PipedReader pipedReader) /* MethodBuilder.Create */ 
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
				/// connect
				/// </java-name>
				[Dot42.DexImport("connect", "(Ljava/io/PipedReader;)V", AccessFlags = 1)]
				public virtual void Connect(global::Java.Io.PipedReader pipedReader) /* MethodBuilder.Create */ 
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
				[Dot42.DexImport("write", "([CII)V", AccessFlags = 1)]
				public override void Write(char[] @char, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "(I)V", AccessFlags = 1)]
				public override void Write(int int32) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/io/DataOutput
		/// </java-name>
		[Dot42.DexImport("java/io/DataOutput", AccessFlags = 1537)]
		public partial interface IDataOutput
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([B)V", AccessFlags = 1025)]
				void Write(sbyte[] sByte) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([BII)V", AccessFlags = 1025)]
				void Write(sbyte[] sByte, int int32, int int321) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "(I)V", AccessFlags = 1025)]
				void Write(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// writeBoolean
				/// </java-name>
				[Dot42.DexImport("writeBoolean", "(Z)V", AccessFlags = 1025)]
				void WriteBoolean(bool boolean) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// writeByte
				/// </java-name>
				[Dot42.DexImport("writeByte", "(I)V", AccessFlags = 1025)]
				void WriteByte(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// writeBytes
				/// </java-name>
				[Dot42.DexImport("writeBytes", "(Ljava/lang/String;)V", AccessFlags = 1025)]
				void WriteBytes(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// writeChar
				/// </java-name>
				[Dot42.DexImport("writeChar", "(I)V", AccessFlags = 1025)]
				void WriteChar(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// writeChars
				/// </java-name>
				[Dot42.DexImport("writeChars", "(Ljava/lang/String;)V", AccessFlags = 1025)]
				void WriteChars(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// writeDouble
				/// </java-name>
				[Dot42.DexImport("writeDouble", "(D)V", AccessFlags = 1025)]
				void WriteDouble(double @double) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// writeFloat
				/// </java-name>
				[Dot42.DexImport("writeFloat", "(F)V", AccessFlags = 1025)]
				void WriteFloat(float single) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// writeInt
				/// </java-name>
				[Dot42.DexImport("writeInt", "(I)V", AccessFlags = 1025)]
				void WriteInt(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// writeLong
				/// </java-name>
				[Dot42.DexImport("writeLong", "(J)V", AccessFlags = 1025)]
				void WriteLong(long int64) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// writeShort
				/// </java-name>
				[Dot42.DexImport("writeShort", "(I)V", AccessFlags = 1025)]
				void WriteShort(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// writeUTF
				/// </java-name>
				[Dot42.DexImport("writeUTF", "(Ljava/lang/String;)V", AccessFlags = 1025)]
				void WriteUTF(string @string) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// java/io/Reader
		/// </java-name>
		[Dot42.DexImport("java/io/Reader", AccessFlags = 1057)]
		public abstract partial class Reader : global::Java.Lang.IReadable, global::Java.Io.ICloseable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// lock
				/// </java-name>
				[Dot42.DexImport("lock", "Ljava/lang/Object;", AccessFlags = 4)]
				protected internal object Lock;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal Reader() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/Object;)V", AccessFlags = 4)]
				protected internal Reader(object @object) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1025)]
				public virtual void Close() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// mark
				/// </java-name>
				[Dot42.DexImport("mark", "(I)V", AccessFlags = 1)]
				public virtual void Mark(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// markSupported
				/// </java-name>
				[Dot42.DexImport("markSupported", "()Z", AccessFlags = 1)]
				public virtual bool MarkSupported() /* MethodBuilder.Create */ 
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
				[Dot42.DexImport("read", "([C)I", AccessFlags = 1)]
				public virtual int Read(char[] @char) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([CII)I", AccessFlags = 1025)]
				public abstract int Read(char[] @char, int int32, int int321) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// ready
				/// </java-name>
				[Dot42.DexImport("ready", "()Z", AccessFlags = 1)]
				public virtual bool Ready() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// reset
				/// </java-name>
				[Dot42.DexImport("reset", "()V", AccessFlags = 1)]
				public virtual void Reset() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// skip
				/// </java-name>
				[Dot42.DexImport("skip", "(J)J", AccessFlags = 1)]
				public virtual long Skip(long int64) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "(Ljava/nio/CharBuffer;)I", AccessFlags = 1)]
				public virtual int Read(global::Java.Nio.CharBuffer charBuffer) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

		}

		/// <java-name>
		/// java/io/InputStreamReader
		/// </java-name>
		[Dot42.DexImport("java/io/InputStreamReader", AccessFlags = 33)]
		public partial class InputStreamReader : global::Java.Io.Reader
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/io/InputStream;)V", AccessFlags = 1)]
				public InputStreamReader(global::Java.Io.InputStream inputStream) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/io/InputStream;Ljava/lang/String;)V", AccessFlags = 1)]
				public InputStreamReader(global::Java.Io.InputStream inputStream, string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/io/InputStream;Ljava/nio/charset/CharsetDecoder;)V", AccessFlags = 1)]
				public InputStreamReader(global::Java.Io.InputStream inputStream, global::Java.Nio.Charset.CharsetDecoder charsetDecoder) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/io/InputStream;Ljava/nio/charset/Charset;)V", AccessFlags = 1)]
				public InputStreamReader(global::Java.Io.InputStream inputStream, global::Java.Nio.Charset.Charset charset) /* MethodBuilder.Create */ 
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
				/// getEncoding
				/// </java-name>
				[Dot42.DexImport("getEncoding", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetEncoding() /* MethodBuilder.Create */ 
				{
						return default(string);
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
				[Dot42.DexImport("read", "([CII)I", AccessFlags = 1)]
				public override int Read(char[] @char, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

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

				/// <java-name>
				/// getEncoding
				/// </java-name>
				public string Encoding
				{
				[Dot42.DexImport("getEncoding", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetEncoding(); }
				}

		}

		/// <java-name>
		/// java/io/ObjectStreamConstants
		/// </java-name>
		[Dot42.DexImport("java/io/ObjectStreamConstants", AccessFlags = 1537, IgnoreFromJava = true, Priority = 1)]
		public static partial class IObjectStreamConstantsConstants
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// STREAM_MAGIC
				/// </java-name>
				[Dot42.DexImport("STREAM_MAGIC", "S", AccessFlags = 25)]
				public const short STREAM_MAGIC = -21267;
				/// <java-name>
				/// STREAM_VERSION
				/// </java-name>
				[Dot42.DexImport("STREAM_VERSION", "S", AccessFlags = 25)]
				public const short STREAM_VERSION = 5;
				/// <java-name>
				/// TC_BASE
				/// </java-name>
				[Dot42.DexImport("TC_BASE", "B", AccessFlags = 25)]
				public const sbyte TC_BASE = 112;
				/// <java-name>
				/// TC_NULL
				/// </java-name>
				[Dot42.DexImport("TC_NULL", "B", AccessFlags = 25)]
				public const sbyte TC_NULL = 112;
				/// <java-name>
				/// TC_REFERENCE
				/// </java-name>
				[Dot42.DexImport("TC_REFERENCE", "B", AccessFlags = 25)]
				public const sbyte TC_REFERENCE = 113;
				/// <java-name>
				/// TC_CLASSDESC
				/// </java-name>
				[Dot42.DexImport("TC_CLASSDESC", "B", AccessFlags = 25)]
				public const sbyte TC_CLASSDESC = 114;
				/// <java-name>
				/// TC_OBJECT
				/// </java-name>
				[Dot42.DexImport("TC_OBJECT", "B", AccessFlags = 25)]
				public const sbyte TC_OBJECT = 115;
				/// <java-name>
				/// TC_STRING
				/// </java-name>
				[Dot42.DexImport("TC_STRING", "B", AccessFlags = 25)]
				public const sbyte TC_STRING = 116;
				/// <java-name>
				/// TC_ARRAY
				/// </java-name>
				[Dot42.DexImport("TC_ARRAY", "B", AccessFlags = 25)]
				public const sbyte TC_ARRAY = 117;
				/// <java-name>
				/// TC_CLASS
				/// </java-name>
				[Dot42.DexImport("TC_CLASS", "B", AccessFlags = 25)]
				public const sbyte TC_CLASS = 118;
				/// <java-name>
				/// TC_BLOCKDATA
				/// </java-name>
				[Dot42.DexImport("TC_BLOCKDATA", "B", AccessFlags = 25)]
				public const sbyte TC_BLOCKDATA = 119;
				/// <java-name>
				/// TC_ENDBLOCKDATA
				/// </java-name>
				[Dot42.DexImport("TC_ENDBLOCKDATA", "B", AccessFlags = 25)]
				public const sbyte TC_ENDBLOCKDATA = 120;
				/// <java-name>
				/// TC_RESET
				/// </java-name>
				[Dot42.DexImport("TC_RESET", "B", AccessFlags = 25)]
				public const sbyte TC_RESET = 121;
				/// <java-name>
				/// TC_BLOCKDATALONG
				/// </java-name>
				[Dot42.DexImport("TC_BLOCKDATALONG", "B", AccessFlags = 25)]
				public const sbyte TC_BLOCKDATALONG = 122;
				/// <java-name>
				/// TC_EXCEPTION
				/// </java-name>
				[Dot42.DexImport("TC_EXCEPTION", "B", AccessFlags = 25)]
				public const sbyte TC_EXCEPTION = 123;
				/// <java-name>
				/// TC_LONGSTRING
				/// </java-name>
				[Dot42.DexImport("TC_LONGSTRING", "B", AccessFlags = 25)]
				public const sbyte TC_LONGSTRING = 124;
				/// <java-name>
				/// TC_PROXYCLASSDESC
				/// </java-name>
				[Dot42.DexImport("TC_PROXYCLASSDESC", "B", AccessFlags = 25)]
				public const sbyte TC_PROXYCLASSDESC = 125;
				/// <java-name>
				/// TC_MAX
				/// </java-name>
				[Dot42.DexImport("TC_MAX", "B", AccessFlags = 25)]
				public const sbyte TC_MAX = 126;
				/// <java-name>
				/// baseWireHandle
				/// </java-name>
				[Dot42.DexImport("baseWireHandle", "I", AccessFlags = 25)]
				public const int BaseWireHandle = 8257536;
				/// <java-name>
				/// PROTOCOL_VERSION_1
				/// </java-name>
				[Dot42.DexImport("PROTOCOL_VERSION_1", "I", AccessFlags = 25)]
				public const int PROTOCOL_VERSION_1 = 1;
				/// <java-name>
				/// PROTOCOL_VERSION_2
				/// </java-name>
				[Dot42.DexImport("PROTOCOL_VERSION_2", "I", AccessFlags = 25)]
				public const int PROTOCOL_VERSION_2 = 2;
				/// <java-name>
				/// SUBCLASS_IMPLEMENTATION_PERMISSION
				/// </java-name>
				[Dot42.DexImport("SUBCLASS_IMPLEMENTATION_PERMISSION", "Ljava/io/SerializablePermission;", AccessFlags = 25)]
				public static readonly global::Java.Io.SerializablePermission SUBCLASS_IMPLEMENTATION_PERMISSION;
				/// <java-name>
				/// SUBSTITUTION_PERMISSION
				/// </java-name>
				[Dot42.DexImport("SUBSTITUTION_PERMISSION", "Ljava/io/SerializablePermission;", AccessFlags = 25)]
				public static readonly global::Java.Io.SerializablePermission SUBSTITUTION_PERMISSION;
				/// <java-name>
				/// SC_WRITE_METHOD
				/// </java-name>
				[Dot42.DexImport("SC_WRITE_METHOD", "B", AccessFlags = 25)]
				public const sbyte SC_WRITE_METHOD = 1;
				/// <java-name>
				/// SC_SERIALIZABLE
				/// </java-name>
				[Dot42.DexImport("SC_SERIALIZABLE", "B", AccessFlags = 25)]
				public const sbyte SC_SERIALIZABLE = 2;
				/// <java-name>
				/// SC_EXTERNALIZABLE
				/// </java-name>
				[Dot42.DexImport("SC_EXTERNALIZABLE", "B", AccessFlags = 25)]
				public const sbyte SC_EXTERNALIZABLE = 4;
				/// <java-name>
				/// SC_BLOCK_DATA
				/// </java-name>
				[Dot42.DexImport("SC_BLOCK_DATA", "B", AccessFlags = 25)]
				public const sbyte SC_BLOCK_DATA = 8;
				/// <java-name>
				/// TC_ENUM
				/// </java-name>
				[Dot42.DexImport("TC_ENUM", "B", AccessFlags = 25)]
				public const sbyte TC_ENUM = 126;
				/// <java-name>
				/// SC_ENUM
				/// </java-name>
				[Dot42.DexImport("SC_ENUM", "B", AccessFlags = 25)]
				public const sbyte SC_ENUM = 16;
		}

		/// <java-name>
		/// java/io/ObjectStreamConstants
		/// </java-name>
		[Dot42.DexImport("java/io/ObjectStreamConstants", AccessFlags = 1537)]
		public partial interface IObjectStreamConstants
 /* scope: __dot42__ */ 
		{
		}

		/// <java-name>
		/// java/io/BufferedInputStream
		/// </java-name>
		[Dot42.DexImport("java/io/BufferedInputStream", AccessFlags = 33)]
		public partial class BufferedInputStream : global::Java.Io.FilterInputStream
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// buf
				/// </java-name>
				[Dot42.DexImport("buf", "[B", AccessFlags = 68)]
				protected internal sbyte[] Buf;
				/// <java-name>
				/// count
				/// </java-name>
				[Dot42.DexImport("count", "I", AccessFlags = 4)]
				protected internal int Count;
				/// <java-name>
				/// marklimit
				/// </java-name>
				[Dot42.DexImport("marklimit", "I", AccessFlags = 4)]
				protected internal int Marklimit;
				/// <java-name>
				/// markpos
				/// </java-name>
				[Dot42.DexImport("markpos", "I", AccessFlags = 4)]
				protected internal int Markpos;
				/// <java-name>
				/// pos
				/// </java-name>
				[Dot42.DexImport("pos", "I", AccessFlags = 4)]
				protected internal int Pos;
				[Dot42.DexImport("<init>", "(Ljava/io/InputStream;)V", AccessFlags = 1)]
				public BufferedInputStream(global::Java.Io.InputStream inputStream) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/io/InputStream;I)V", AccessFlags = 1)]
				public BufferedInputStream(global::Java.Io.InputStream inputStream, int int32) /* MethodBuilder.Create */ 
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
				[Dot42.DexImport("mark", "(I)V", AccessFlags = 33)]
				public override void Mark(int int32) /* MethodBuilder.Create */ 
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
				public override int Read(sbyte[] sByte, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([BII)I", AccessFlags = 33, IgnoreFromJava = true)]
				public override int Read(byte[] @byte, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// reset
				/// </java-name>
				[Dot42.DexImport("reset", "()V", AccessFlags = 33)]
				public override void Reset() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// skip
				/// </java-name>
				[Dot42.DexImport("skip", "(J)J", AccessFlags = 33)]
				public override long Skip(long int64) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal BufferedInputStream() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// java/io/StreamTokenizer
		/// </java-name>
		[Dot42.DexImport("java/io/StreamTokenizer", AccessFlags = 33)]
		public partial class StreamTokenizer
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// nval
				/// </java-name>
				[Dot42.DexImport("nval", "D", AccessFlags = 1)]
				public double Nval;
				/// <java-name>
				/// sval
				/// </java-name>
				[Dot42.DexImport("sval", "Ljava/lang/String;", AccessFlags = 1)]
				public string Sval;
				/// <java-name>
				/// TT_EOF
				/// </java-name>
				[Dot42.DexImport("TT_EOF", "I", AccessFlags = 25)]
				public const int TT_EOF = -1;
				/// <java-name>
				/// TT_EOL
				/// </java-name>
				[Dot42.DexImport("TT_EOL", "I", AccessFlags = 25)]
				public const int TT_EOL = 10;
				/// <java-name>
				/// TT_NUMBER
				/// </java-name>
				[Dot42.DexImport("TT_NUMBER", "I", AccessFlags = 25)]
				public const int TT_NUMBER = -2;
				/// <java-name>
				/// TT_WORD
				/// </java-name>
				[Dot42.DexImport("TT_WORD", "I", AccessFlags = 25)]
				public const int TT_WORD = -3;
				/// <java-name>
				/// ttype
				/// </java-name>
				[Dot42.DexImport("ttype", "I", AccessFlags = 1)]
				public int Ttype;
				[Dot42.DexImport("<init>", "(Ljava/io/InputStream;)V", AccessFlags = 1)]
				public StreamTokenizer(global::Java.Io.InputStream inputStream) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/io/Reader;)V", AccessFlags = 1)]
				public StreamTokenizer(global::Java.Io.Reader reader) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// commentChar
				/// </java-name>
				[Dot42.DexImport("commentChar", "(I)V", AccessFlags = 1)]
				public virtual void CommentChar(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// eolIsSignificant
				/// </java-name>
				[Dot42.DexImport("eolIsSignificant", "(Z)V", AccessFlags = 1)]
				public virtual void EolIsSignificant(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// lineno
				/// </java-name>
				[Dot42.DexImport("lineno", "()I", AccessFlags = 1)]
				public virtual int Lineno() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// lowerCaseMode
				/// </java-name>
				[Dot42.DexImport("lowerCaseMode", "(Z)V", AccessFlags = 1)]
				public virtual void LowerCaseMode(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// nextToken
				/// </java-name>
				[Dot42.DexImport("nextToken", "()I", AccessFlags = 1)]
				public virtual int NextToken() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// ordinaryChar
				/// </java-name>
				[Dot42.DexImport("ordinaryChar", "(I)V", AccessFlags = 1)]
				public virtual void OrdinaryChar(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// ordinaryChars
				/// </java-name>
				[Dot42.DexImport("ordinaryChars", "(II)V", AccessFlags = 1)]
				public virtual void OrdinaryChars(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// parseNumbers
				/// </java-name>
				[Dot42.DexImport("parseNumbers", "()V", AccessFlags = 1)]
				public virtual void ParseNumbers() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// pushBack
				/// </java-name>
				[Dot42.DexImport("pushBack", "()V", AccessFlags = 1)]
				public virtual void PushBack() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// quoteChar
				/// </java-name>
				[Dot42.DexImport("quoteChar", "(I)V", AccessFlags = 1)]
				public virtual void QuoteChar(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// resetSyntax
				/// </java-name>
				[Dot42.DexImport("resetSyntax", "()V", AccessFlags = 1)]
				public virtual void ResetSyntax() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// slashSlashComments
				/// </java-name>
				[Dot42.DexImport("slashSlashComments", "(Z)V", AccessFlags = 1)]
				public virtual void SlashSlashComments(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// slashStarComments
				/// </java-name>
				[Dot42.DexImport("slashStarComments", "(Z)V", AccessFlags = 1)]
				public virtual void SlashStarComments(bool boolean) /* MethodBuilder.Create */ 
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
				/// whitespaceChars
				/// </java-name>
				[Dot42.DexImport("whitespaceChars", "(II)V", AccessFlags = 1)]
				public virtual void WhitespaceChars(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// wordChars
				/// </java-name>
				[Dot42.DexImport("wordChars", "(II)V", AccessFlags = 1)]
				public virtual void WordChars(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal StreamTokenizer() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// java/io/ObjectOutputStream
		/// </java-name>
		[Dot42.DexImport("java/io/ObjectOutputStream", AccessFlags = 33)]
		public partial class ObjectOutputStream : global::Java.Io.OutputStream, global::Java.Io.IObjectOutput, global::Java.Io.IObjectStreamConstants
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal ObjectOutputStream() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/io/OutputStream;)V", AccessFlags = 1)]
				public ObjectOutputStream(global::Java.Io.OutputStream outputStream) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// annotateClass
				/// </java-name>
				[Dot42.DexImport("annotateClass", "(Ljava/lang/Class;)V", AccessFlags = 4, Signature = "(Ljava/lang/Class<*>;)V")]
				protected internal virtual void AnnotateClass(global::System.Type type) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// annotateProxyClass
				/// </java-name>
				[Dot42.DexImport("annotateProxyClass", "(Ljava/lang/Class;)V", AccessFlags = 4, Signature = "(Ljava/lang/Class<*>;)V")]
				protected internal virtual void AnnotateProxyClass(global::System.Type type) /* MethodBuilder.Create */ 
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
				/// defaultWriteObject
				/// </java-name>
				[Dot42.DexImport("defaultWriteObject", "()V", AccessFlags = 1)]
				public virtual void DefaultWriteObject() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// drain
				/// </java-name>
				[Dot42.DexImport("drain", "()V", AccessFlags = 4)]
				protected internal virtual void Drain() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// enableReplaceObject
				/// </java-name>
				[Dot42.DexImport("enableReplaceObject", "(Z)Z", AccessFlags = 4)]
				protected internal virtual bool EnableReplaceObject(bool boolean) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// flush
				/// </java-name>
				[Dot42.DexImport("flush", "()V", AccessFlags = 1)]
				public override void Flush() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// putFields
				/// </java-name>
				[Dot42.DexImport("putFields", "()Ljava/io/ObjectOutputStream$PutField;", AccessFlags = 1)]
				public virtual global::Java.Io.ObjectOutputStream.PutField PutFields() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.ObjectOutputStream.PutField);
				}

				/// <java-name>
				/// replaceObject
				/// </java-name>
				[Dot42.DexImport("replaceObject", "(Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 4)]
				protected internal virtual object ReplaceObject(object @object) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <java-name>
				/// reset
				/// </java-name>
				[Dot42.DexImport("reset", "()V", AccessFlags = 1)]
				public virtual void Reset() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// useProtocolVersion
				/// </java-name>
				[Dot42.DexImport("useProtocolVersion", "(I)V", AccessFlags = 1)]
				public virtual void UseProtocolVersion(int int32) /* MethodBuilder.Create */ 
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
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "(I)V", AccessFlags = 1)]
				public override void Write(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writeBoolean
				/// </java-name>
				[Dot42.DexImport("writeBoolean", "(Z)V", AccessFlags = 1)]
				public virtual void WriteBoolean(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writeByte
				/// </java-name>
				[Dot42.DexImport("writeByte", "(I)V", AccessFlags = 1)]
				public virtual void WriteByte(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writeBytes
				/// </java-name>
				[Dot42.DexImport("writeBytes", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void WriteBytes(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writeChar
				/// </java-name>
				[Dot42.DexImport("writeChar", "(I)V", AccessFlags = 1)]
				public virtual void WriteChar(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writeChars
				/// </java-name>
				[Dot42.DexImport("writeChars", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void WriteChars(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writeDouble
				/// </java-name>
				[Dot42.DexImport("writeDouble", "(D)V", AccessFlags = 1)]
				public virtual void WriteDouble(double @double) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writeFields
				/// </java-name>
				[Dot42.DexImport("writeFields", "()V", AccessFlags = 1)]
				public virtual void WriteFields() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writeFloat
				/// </java-name>
				[Dot42.DexImport("writeFloat", "(F)V", AccessFlags = 1)]
				public virtual void WriteFloat(float single) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writeInt
				/// </java-name>
				[Dot42.DexImport("writeInt", "(I)V", AccessFlags = 1)]
				public virtual void WriteInt(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writeLong
				/// </java-name>
				[Dot42.DexImport("writeLong", "(J)V", AccessFlags = 1)]
				public virtual void WriteLong(long int64) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writeClassDescriptor
				/// </java-name>
				[Dot42.DexImport("writeClassDescriptor", "(Ljava/io/ObjectStreamClass;)V", AccessFlags = 4)]
				protected internal virtual void WriteClassDescriptor(global::Java.Io.ObjectStreamClass objectStreamClass) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writeObject
				/// </java-name>
				[Dot42.DexImport("writeObject", "(Ljava/lang/Object;)V", AccessFlags = 17)]
				public void WriteObject(object @object) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writeUnshared
				/// </java-name>
				[Dot42.DexImport("writeUnshared", "(Ljava/lang/Object;)V", AccessFlags = 1)]
				public virtual void WriteUnshared(object @object) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writeObjectOverride
				/// </java-name>
				[Dot42.DexImport("writeObjectOverride", "(Ljava/lang/Object;)V", AccessFlags = 4)]
				protected internal virtual void WriteObjectOverride(object @object) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writeShort
				/// </java-name>
				[Dot42.DexImport("writeShort", "(I)V", AccessFlags = 1)]
				public virtual void WriteShort(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writeStreamHeader
				/// </java-name>
				[Dot42.DexImport("writeStreamHeader", "()V", AccessFlags = 4)]
				protected internal virtual void WriteStreamHeader() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writeUTF
				/// </java-name>
				[Dot42.DexImport("writeUTF", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void WriteUTF(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("java/io/ObjectOutput", "write", "([B)V", AccessFlags = 1025)]
				public override void Write(sbyte[] sByte) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

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

						/// <java-name>
						/// write
						/// </java-name>
						[Dot42.DexImport("write", "(Ljava/io/ObjectOutput;)V", AccessFlags = 1025)]
						public abstract void Write(global::Java.Io.IObjectOutput objectOutput) /* MethodBuilder.Create */ ;

				}

		}

		/// <java-name>
		/// java/io/IOError
		/// </java-name>
		[Dot42.DexImport("java/io/IOError", AccessFlags = 33)]
		public partial class IOError : global::Java.Lang.Error
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public IOError(global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal IOError() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// java/io/ObjectStreamException
		/// </java-name>
		[Dot42.DexImport("java/io/ObjectStreamException", AccessFlags = 1057)]
		public abstract partial class ObjectStreamException : global::System.IO.IOException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal ObjectStreamException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 4)]
				protected internal ObjectStreamException(string @string) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/io/PushbackReader
		/// </java-name>
		[Dot42.DexImport("java/io/PushbackReader", AccessFlags = 33)]
		public partial class PushbackReader : global::Java.Io.FilterReader
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/io/Reader;)V", AccessFlags = 1)]
				public PushbackReader(global::Java.Io.Reader reader) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/io/Reader;I)V", AccessFlags = 1)]
				public PushbackReader(global::Java.Io.Reader reader, int int32) /* MethodBuilder.Create */ 
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
				/// mark
				/// </java-name>
				[Dot42.DexImport("mark", "(I)V", AccessFlags = 1)]
				public override void Mark(int int32) /* MethodBuilder.Create */ 
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
				[Dot42.DexImport("read", "([CII)I", AccessFlags = 1)]
				public override int Read(char[] @char, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// ready
				/// </java-name>
				[Dot42.DexImport("ready", "()Z", AccessFlags = 1)]
				public override bool Ready() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// reset
				/// </java-name>
				[Dot42.DexImport("reset", "()V", AccessFlags = 1)]
				public override void Reset() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// unread
				/// </java-name>
				[Dot42.DexImport("unread", "([C)V", AccessFlags = 1)]
				public virtual void Unread(char[] @char) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// unread
				/// </java-name>
				[Dot42.DexImport("unread", "([CII)V", AccessFlags = 1)]
				public virtual void Unread(char[] @char, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// unread
				/// </java-name>
				[Dot42.DexImport("unread", "(I)V", AccessFlags = 1)]
				public virtual void Unread(int int32) /* MethodBuilder.Create */ 
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

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal PushbackReader() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// java/io/StreamCorruptedException
		/// </java-name>
		[Dot42.DexImport("java/io/StreamCorruptedException", AccessFlags = 33)]
		public partial class StreamCorruptedException : global::Java.Io.ObjectStreamException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public StreamCorruptedException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public StreamCorruptedException(string @string) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/io/NotSerializableException
		/// </java-name>
		[Dot42.DexImport("java/io/NotSerializableException", AccessFlags = 33)]
		public partial class NotSerializableException : global::Java.Io.ObjectStreamException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public NotSerializableException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public NotSerializableException(string @string) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/io/CharArrayWriter
		/// </java-name>
		[Dot42.DexImport("java/io/CharArrayWriter", AccessFlags = 33)]
		public partial class CharArrayWriter : global::Java.Io.Writer
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// buf
				/// </java-name>
				[Dot42.DexImport("buf", "[C", AccessFlags = 4)]
				protected internal char[] Buf;
				/// <java-name>
				/// count
				/// </java-name>
				[Dot42.DexImport("count", "I", AccessFlags = 4)]
				protected internal int Count;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public CharArrayWriter() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public CharArrayWriter(int int32) /* MethodBuilder.Create */ 
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
				/// reset
				/// </java-name>
				[Dot42.DexImport("reset", "()V", AccessFlags = 1)]
				public virtual void Reset() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// size
				/// </java-name>
				[Dot42.DexImport("size", "()I", AccessFlags = 1)]
				public virtual int Size() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// toCharArray
				/// </java-name>
				[Dot42.DexImport("toCharArray", "()[C", AccessFlags = 1)]
				public virtual char[] ToCharArray() /* MethodBuilder.Create */ 
				{
						return default(char[]);
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
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([CII)V", AccessFlags = 1)]
				public override void Write(char[] @char, int int32, int int321) /* MethodBuilder.Create */ 
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
				[Dot42.DexImport("write", "(Ljava/lang/String;II)V", AccessFlags = 1)]
				public override void Write(string @string, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writeTo
				/// </java-name>
				[Dot42.DexImport("writeTo", "(Ljava/io/Writer;)V", AccessFlags = 1)]
				public virtual void WriteTo(global::Java.Io.Writer writer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// append
				/// </java-name>
				[Dot42.DexImport("append", "(C)Ljava/io/CharArrayWriter;", AccessFlags = 1)]
				public new virtual global::Java.Io.CharArrayWriter Append(char @char) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.CharArrayWriter);
				}

				/// <java-name>
				/// append
				/// </java-name>
				[Dot42.DexImport("append", "(Ljava/lang/CharSequence;)Ljava/io/CharArrayWriter;", AccessFlags = 1)]
				public new virtual global::Java.Io.CharArrayWriter Append(global::Java.Lang.ICharSequence charSequence) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.CharArrayWriter);
				}

				/// <java-name>
				/// append
				/// </java-name>
				[Dot42.DexImport("append", "(Ljava/lang/CharSequence;II)Ljava/io/CharArrayWriter;", AccessFlags = 1)]
				public new virtual global::Java.Io.CharArrayWriter JavaAppend(global::Java.Lang.ICharSequence charSequence, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.CharArrayWriter);
				}

		}

		/// <java-name>
		/// java/io/SequenceInputStream
		/// </java-name>
		[Dot42.DexImport("java/io/SequenceInputStream", AccessFlags = 33)]
		public partial class SequenceInputStream : global::Java.Io.InputStream
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/io/InputStream;Ljava/io/InputStream;)V", AccessFlags = 1)]
				public SequenceInputStream(global::Java.Io.InputStream inputStream, global::Java.Io.InputStream inputStream1) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/util/Enumeration;)V", AccessFlags = 1, Signature = "(Ljava/util/Enumeration<+Ljava/io/InputStream;>;)V")]
				public SequenceInputStream(global::Java.Util.IEnumeration<global::Java.Io.InputStream> enumeration) /* MethodBuilder.Create */ 
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
				internal SequenceInputStream() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// java/io/CharArrayReader
		/// </java-name>
		[Dot42.DexImport("java/io/CharArrayReader", AccessFlags = 33)]
		public partial class CharArrayReader : global::Java.Io.Reader
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// buf
				/// </java-name>
				[Dot42.DexImport("buf", "[C", AccessFlags = 4)]
				protected internal char[] Buf;
				/// <java-name>
				/// pos
				/// </java-name>
				[Dot42.DexImport("pos", "I", AccessFlags = 4)]
				protected internal int Pos;
				/// <java-name>
				/// markedPos
				/// </java-name>
				[Dot42.DexImport("markedPos", "I", AccessFlags = 4)]
				protected internal int MarkedPos;
				/// <java-name>
				/// count
				/// </java-name>
				[Dot42.DexImport("count", "I", AccessFlags = 4)]
				protected internal int Count;
				[Dot42.DexImport("<init>", "([C)V", AccessFlags = 1)]
				public CharArrayReader(char[] @char) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "([CII)V", AccessFlags = 1)]
				public CharArrayReader(char[] @char, int int32, int int321) /* MethodBuilder.Create */ 
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
				/// mark
				/// </java-name>
				[Dot42.DexImport("mark", "(I)V", AccessFlags = 1)]
				public override void Mark(int int32) /* MethodBuilder.Create */ 
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
				[Dot42.DexImport("read", "([CII)I", AccessFlags = 1)]
				public override int Read(char[] @char, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// ready
				/// </java-name>
				[Dot42.DexImport("ready", "()Z", AccessFlags = 1)]
				public override bool Ready() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// reset
				/// </java-name>
				[Dot42.DexImport("reset", "()V", AccessFlags = 1)]
				public override void Reset() /* MethodBuilder.Create */ 
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

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal CharArrayReader() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// java/io/InvalidClassException
		/// </java-name>
		[Dot42.DexImport("java/io/InvalidClassException", AccessFlags = 33)]
		public partial class InvalidClassException : global::Java.Io.ObjectStreamException
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// classname
				/// </java-name>
				[Dot42.DexImport("classname", "Ljava/lang/String;", AccessFlags = 1)]
				public string Classname;
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public InvalidClassException(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public InvalidClassException(string @string, string string1) /* MethodBuilder.Create */ 
				{
				}

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

		/// <java-name>
		/// java/io/ObjectStreamClass
		/// </java-name>
		[Dot42.DexImport("java/io/ObjectStreamClass", AccessFlags = 33)]
		public partial class ObjectStreamClass : global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// NO_FIELDS
				/// </java-name>
				[Dot42.DexImport("NO_FIELDS", "[Ljava/io/ObjectStreamField;", AccessFlags = 25)]
				public static readonly global::Java.Io.ObjectStreamField[] NO_FIELDS;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal ObjectStreamClass() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// forClass
				/// </java-name>
				[Dot42.DexImport("forClass", "()Ljava/lang/Class;", AccessFlags = 1, Signature = "()Ljava/lang/Class<*>;")]
				public virtual global::System.Type ForClass() /* MethodBuilder.Create */ 
				{
						return default(global::System.Type);
				}

				/// <java-name>
				/// getField
				/// </java-name>
				[Dot42.DexImport("getField", "(Ljava/lang/String;)Ljava/io/ObjectStreamField;", AccessFlags = 1)]
				public virtual global::Java.Io.ObjectStreamField GetField(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.ObjectStreamField);
				}

				/// <java-name>
				/// getFields
				/// </java-name>
				[Dot42.DexImport("getFields", "()[Ljava/io/ObjectStreamField;", AccessFlags = 1)]
				public virtual global::Java.Io.ObjectStreamField[] GetFields() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.ObjectStreamField[]);
				}

				/// <java-name>
				/// getName
				/// </java-name>
				[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetName() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getSerialVersionUID
				/// </java-name>
				[Dot42.DexImport("getSerialVersionUID", "()J", AccessFlags = 1)]
				public virtual long GetSerialVersionUID() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// lookup
				/// </java-name>
				[Dot42.DexImport("lookup", "(Ljava/lang/Class;)Ljava/io/ObjectStreamClass;", AccessFlags = 9, Signature = "(Ljava/lang/Class<*>;)Ljava/io/ObjectStreamClass;")]
				public static global::Java.Io.ObjectStreamClass Lookup(global::System.Type type) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.ObjectStreamClass);
				}

				/// <java-name>
				/// lookupAny
				/// </java-name>
				[Dot42.DexImport("lookupAny", "(Ljava/lang/Class;)Ljava/io/ObjectStreamClass;", AccessFlags = 9, Signature = "(Ljava/lang/Class<*>;)Ljava/io/ObjectStreamClass;")]
				public static global::Java.Io.ObjectStreamClass LookupAny(global::System.Type type) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.ObjectStreamClass);
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
				/// getFields
				/// </java-name>
				public global::Java.Io.ObjectStreamField[] Fields
				{
				[Dot42.DexImport("getFields", "()[Ljava/io/ObjectStreamField;", AccessFlags = 1)]
						get{ return GetFields(); }
				}

				/// <java-name>
				/// getName
				/// </java-name>
				public string Name
				{
				[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetName(); }
				}

				/// <java-name>
				/// getSerialVersionUID
				/// </java-name>
				public long SerialVersionUID
				{
				[Dot42.DexImport("getSerialVersionUID", "()J", AccessFlags = 1)]
						get{ return GetSerialVersionUID(); }
				}

		}

		/// <java-name>
		/// java/io/Externalizable
		/// </java-name>
		[Dot42.DexImport("java/io/Externalizable", AccessFlags = 1537)]
		public partial interface IExternalizable : global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// readExternal
				/// </java-name>
				[Dot42.DexImport("readExternal", "(Ljava/io/ObjectInput;)V", AccessFlags = 1025)]
				void ReadExternal(global::Java.Io.IObjectInput objectInput) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// writeExternal
				/// </java-name>
				[Dot42.DexImport("writeExternal", "(Ljava/io/ObjectOutput;)V", AccessFlags = 1025)]
				void WriteExternal(global::Java.Io.IObjectOutput objectOutput) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// java/io/FileReader
		/// </java-name>
		[Dot42.DexImport("java/io/FileReader", AccessFlags = 33)]
		public partial class FileReader : global::Java.Io.InputStreamReader
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/io/File;)V", AccessFlags = 1)]
				public FileReader(global::Java.Io.File file) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/io/FileDescriptor;)V", AccessFlags = 1)]
				public FileReader(global::Java.Io.FileDescriptor fileDescriptor) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public FileReader(string @string) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal FileReader() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// java/io/OutputStreamWriter
		/// </java-name>
		[Dot42.DexImport("java/io/OutputStreamWriter", AccessFlags = 33)]
		public partial class OutputStreamWriter : global::Java.Io.Writer
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/io/OutputStream;)V", AccessFlags = 1)]
				public OutputStreamWriter(global::Java.Io.OutputStream outputStream) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/io/OutputStream;Ljava/lang/String;)V", AccessFlags = 1)]
				public OutputStreamWriter(global::Java.Io.OutputStream outputStream, string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/io/OutputStream;Ljava/nio/charset/Charset;)V", AccessFlags = 1)]
				public OutputStreamWriter(global::Java.Io.OutputStream outputStream, global::Java.Nio.Charset.Charset charset) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/io/OutputStream;Ljava/nio/charset/CharsetEncoder;)V", AccessFlags = 1)]
				public OutputStreamWriter(global::Java.Io.OutputStream outputStream, global::Java.Nio.Charset.CharsetEncoder charsetEncoder) /* MethodBuilder.Create */ 
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
				/// getEncoding
				/// </java-name>
				[Dot42.DexImport("getEncoding", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetEncoding() /* MethodBuilder.Create */ 
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
				[Dot42.DexImport("write", "(Ljava/lang/String;II)V", AccessFlags = 1)]
				public override void Write(string @string, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal OutputStreamWriter() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getEncoding
				/// </java-name>
				public string Encoding
				{
				[Dot42.DexImport("getEncoding", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetEncoding(); }
				}

		}

		/// <java-name>
		/// java/io/InvalidObjectException
		/// </java-name>
		[Dot42.DexImport("java/io/InvalidObjectException", AccessFlags = 33)]
		public partial class InvalidObjectException : global::Java.Io.ObjectStreamException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public InvalidObjectException(string @string) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal InvalidObjectException() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

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

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Class;Z)V", AccessFlags = 1, Signature = "(Ljava/lang/String;Ljava/lang/Class<*>;Z)V")]
				public ObjectStreamField(string @string, global::System.Type type, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// compareTo
				/// </java-name>
				[Dot42.DexImport("compareTo", "(Ljava/lang/Object;)I", AccessFlags = 1)]
				public virtual int CompareTo(object @object) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getName
				/// </java-name>
				[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetName() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getOffset
				/// </java-name>
				[Dot42.DexImport("getOffset", "()I", AccessFlags = 1)]
				public virtual int GetOffset() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getType
				/// </java-name>
				[Dot42.DexImport("getType", "()Ljava/lang/Class;", AccessFlags = 1, Signature = "()Ljava/lang/Class<*>;")]
				public virtual global::System.Type GetType() /* MethodBuilder.Create */ 
				{
						return default(global::System.Type);
				}

				/// <java-name>
				/// getTypeCode
				/// </java-name>
				[Dot42.DexImport("getTypeCode", "()C", AccessFlags = 1)]
				public virtual char GetTypeCode() /* MethodBuilder.Create */ 
				{
						return default(char);
				}

				/// <java-name>
				/// getTypeString
				/// </java-name>
				[Dot42.DexImport("getTypeString", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetTypeString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// isPrimitive
				/// </java-name>
				[Dot42.DexImport("isPrimitive", "()Z", AccessFlags = 1)]
				public virtual bool IsPrimitive() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setOffset
				/// </java-name>
				[Dot42.DexImport("setOffset", "(I)V", AccessFlags = 4)]
				protected internal virtual void SetOffset(int int32) /* MethodBuilder.Create */ 
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
				/// isUnshared
				/// </java-name>
				[Dot42.DexImport("isUnshared", "()Z", AccessFlags = 1)]
				public virtual bool IsUnshared() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ObjectStreamField() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getName
				/// </java-name>
				public string Name
				{
				[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetName(); }
				}

				/// <java-name>
				/// getOffset
				/// </java-name>
				public int Offset
				{
				[Dot42.DexImport("getOffset", "()I", AccessFlags = 1)]
						get{ return GetOffset(); }
				[Dot42.DexImport("setOffset", "(I)V", AccessFlags = 4)]
						set{ SetOffset(value); }
				}

				/// <java-name>
				/// getType
				/// </java-name>
				public global::System.Type Type
				{
				[Dot42.DexImport("getType", "()Ljava/lang/Class;", AccessFlags = 1, Signature = "()Ljava/lang/Class<*>;")]
						get{ return GetType(); }
				}

				/// <java-name>
				/// getTypeCode
				/// </java-name>
				public char TypeCode
				{
				[Dot42.DexImport("getTypeCode", "()C", AccessFlags = 1)]
						get{ return GetTypeCode(); }
				}

				/// <java-name>
				/// getTypeString
				/// </java-name>
				public string TypeString
				{
				[Dot42.DexImport("getTypeString", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetTypeString(); }
				}

		}

		/// <java-name>
		/// java/io/DataOutputStream
		/// </java-name>
		[Dot42.DexImport("java/io/DataOutputStream", AccessFlags = 33)]
		public partial class DataOutputStream : global::Java.Io.FilterOutputStream, global::Java.Io.IDataOutput
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// written
				/// </java-name>
				[Dot42.DexImport("written", "I", AccessFlags = 4)]
				protected internal int Written;
				[Dot42.DexImport("<init>", "(Ljava/io/OutputStream;)V", AccessFlags = 1)]
				public DataOutputStream(global::Java.Io.OutputStream outputStream) /* MethodBuilder.Create */ 
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
				/// size
				/// </java-name>
				[Dot42.DexImport("size", "()I", AccessFlags = 17)]
				public int Size() /* MethodBuilder.Create */ 
				{
						return default(int);
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
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "(I)V", AccessFlags = 1)]
				public override void Write(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writeBoolean
				/// </java-name>
				[Dot42.DexImport("writeBoolean", "(Z)V", AccessFlags = 17)]
				public void WriteBoolean(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writeByte
				/// </java-name>
				[Dot42.DexImport("writeByte", "(I)V", AccessFlags = 17)]
				public void WriteByte(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writeBytes
				/// </java-name>
				[Dot42.DexImport("writeBytes", "(Ljava/lang/String;)V", AccessFlags = 17)]
				public void WriteBytes(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writeChar
				/// </java-name>
				[Dot42.DexImport("writeChar", "(I)V", AccessFlags = 17)]
				public void WriteChar(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writeChars
				/// </java-name>
				[Dot42.DexImport("writeChars", "(Ljava/lang/String;)V", AccessFlags = 17)]
				public void WriteChars(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writeDouble
				/// </java-name>
				[Dot42.DexImport("writeDouble", "(D)V", AccessFlags = 17)]
				public void WriteDouble(double @double) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writeFloat
				/// </java-name>
				[Dot42.DexImport("writeFloat", "(F)V", AccessFlags = 17)]
				public void WriteFloat(float single) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writeInt
				/// </java-name>
				[Dot42.DexImport("writeInt", "(I)V", AccessFlags = 17)]
				public void WriteInt(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writeLong
				/// </java-name>
				[Dot42.DexImport("writeLong", "(J)V", AccessFlags = 17)]
				public void WriteLong(long int64) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writeShort
				/// </java-name>
				[Dot42.DexImport("writeShort", "(I)V", AccessFlags = 17)]
				public void WriteShort(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writeUTF
				/// </java-name>
				[Dot42.DexImport("writeUTF", "(Ljava/lang/String;)V", AccessFlags = 17)]
				public void WriteUTF(string @string) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal DataOutputStream() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				[Dot42.DexImport("java/io/DataOutput", "write", "([B)V", AccessFlags = 1025)]
				public override void Write(sbyte[] sByte) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

		}

		/// <java-name>
		/// java/io/PushbackInputStream
		/// </java-name>
		[Dot42.DexImport("java/io/PushbackInputStream", AccessFlags = 33)]
		public partial class PushbackInputStream : global::Java.Io.FilterInputStream
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// buf
				/// </java-name>
				[Dot42.DexImport("buf", "[B", AccessFlags = 4)]
				protected internal sbyte[] Buf;
				/// <java-name>
				/// pos
				/// </java-name>
				[Dot42.DexImport("pos", "I", AccessFlags = 4)]
				protected internal int Pos;
				[Dot42.DexImport("<init>", "(Ljava/io/InputStream;)V", AccessFlags = 1)]
				public PushbackInputStream(global::Java.Io.InputStream inputStream) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/io/InputStream;I)V", AccessFlags = 1)]
				public PushbackInputStream(global::Java.Io.InputStream inputStream, int int32) /* MethodBuilder.Create */ 
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
				/// markSupported
				/// </java-name>
				[Dot42.DexImport("markSupported", "()Z", AccessFlags = 1)]
				public override bool MarkSupported() /* MethodBuilder.Create */ 
				{
						return default(bool);
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
				/// unread
				/// </java-name>
				[Dot42.DexImport("unread", "([B)V", AccessFlags = 1)]
				public virtual void Unread(sbyte[] sByte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// unread
				/// </java-name>
				[Dot42.DexImport("unread", "([B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual void Unread(byte[] @byte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// unread
				/// </java-name>
				[Dot42.DexImport("unread", "([BII)V", AccessFlags = 1)]
				public virtual void Unread(sbyte[] sByte, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// unread
				/// </java-name>
				[Dot42.DexImport("unread", "([BII)V", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual void Unread(byte[] @byte, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// unread
				/// </java-name>
				[Dot42.DexImport("unread", "(I)V", AccessFlags = 1)]
				public virtual void Unread(int int32) /* MethodBuilder.Create */ 
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

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal PushbackInputStream() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// java/io/FileOutputStream
		/// </java-name>
		[Dot42.DexImport("java/io/FileOutputStream", AccessFlags = 33)]
		public partial class FileOutputStream : global::Java.Io.OutputStream, global::Java.Io.ICloseable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/io/File;)V", AccessFlags = 1)]
				public FileOutputStream(global::Java.Io.File file) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/io/File;Z)V", AccessFlags = 1)]
				public FileOutputStream(global::Java.Io.File file, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/io/FileDescriptor;)V", AccessFlags = 1)]
				public FileOutputStream(global::Java.Io.FileDescriptor fileDescriptor) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public FileOutputStream(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Z)V", AccessFlags = 1)]
				public FileOutputStream(string @string, bool boolean) /* MethodBuilder.Create */ 
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
				/// finalize
				/// </java-name>
				[Dot42.DexImport("finalize", "()V", AccessFlags = 4)]
				extern ~FileOutputStream() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getChannel
				/// </java-name>
				[Dot42.DexImport("getChannel", "()Ljava/nio/channels/FileChannel;", AccessFlags = 1)]
				public virtual global::Java.Nio.Channels.FileChannel GetChannel() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.Channels.FileChannel);
				}

				/// <java-name>
				/// getFD
				/// </java-name>
				[Dot42.DexImport("getFD", "()Ljava/io/FileDescriptor;", AccessFlags = 17)]
				public global::Java.Io.FileDescriptor GetFD() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.FileDescriptor);
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
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "(I)V", AccessFlags = 1)]
				public override void Write(int int32) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal FileOutputStream() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getChannel
				/// </java-name>
				public global::Java.Nio.Channels.FileChannel Channel
				{
				[Dot42.DexImport("getChannel", "()Ljava/nio/channels/FileChannel;", AccessFlags = 1)]
						get{ return GetChannel(); }
				}

				/// <java-name>
				/// getFD
				/// </java-name>
				public global::Java.Io.FileDescriptor FD
				{
				[Dot42.DexImport("getFD", "()Ljava/io/FileDescriptor;", AccessFlags = 17)]
						get{ return GetFD(); }
				}

		}

		/// <java-name>
		/// java/io/FileWriter
		/// </java-name>
		[Dot42.DexImport("java/io/FileWriter", AccessFlags = 33)]
		public partial class FileWriter : global::Java.Io.OutputStreamWriter
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/io/File;)V", AccessFlags = 1)]
				public FileWriter(global::Java.Io.File file) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/io/File;Z)V", AccessFlags = 1)]
				public FileWriter(global::Java.Io.File file, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/io/FileDescriptor;)V", AccessFlags = 1)]
				public FileWriter(global::Java.Io.FileDescriptor fileDescriptor) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public FileWriter(string @string) /* MethodBuilder.Create */ 
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

		/// <java-name>
		/// java/io/InterruptedIOException
		/// </java-name>
		[Dot42.DexImport("java/io/InterruptedIOException", AccessFlags = 33)]
		public partial class InterruptedIOException : global::System.IO.IOException
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// bytesTransferred
				/// </java-name>
				[Dot42.DexImport("bytesTransferred", "I", AccessFlags = 1)]
				public int BytesTransferred;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public InterruptedIOException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public InterruptedIOException(string @string) /* MethodBuilder.Create */ 
				{
				}

		}

}

