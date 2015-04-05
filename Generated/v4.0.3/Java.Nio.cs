#pragma warning disable 1717
namespace Java.Nio
{
		/// <java-name>
		/// java/nio/Buffer
		/// </java-name>
		[Dot42.DexImport("java/nio/Buffer", AccessFlags = 1057)]
		public abstract partial class Buffer
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal Buffer() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// array
				/// </java-name>
				[Dot42.DexImport("array", "()Ljava/lang/Object;", AccessFlags = 1025)]
				public abstract object Array() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// arrayOffset
				/// </java-name>
				[Dot42.DexImport("arrayOffset", "()I", AccessFlags = 1025)]
				public abstract int ArrayOffset() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// capacity
				/// </java-name>
				[Dot42.DexImport("capacity", "()I", AccessFlags = 17)]
				public int Capacity() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// clear
				/// </java-name>
				[Dot42.DexImport("clear", "()Ljava/nio/Buffer;", AccessFlags = 17)]
				public global::Java.Nio.Buffer Clear() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.Buffer);
				}

				/// <java-name>
				/// flip
				/// </java-name>
				[Dot42.DexImport("flip", "()Ljava/nio/Buffer;", AccessFlags = 17)]
				public global::Java.Nio.Buffer Flip() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.Buffer);
				}

				/// <java-name>
				/// limit
				/// </java-name>
				[Dot42.DexImport("limit", "()I", AccessFlags = 17)]
				public int Limit() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// limit
				/// </java-name>
				[Dot42.DexImport("limit", "(I)Ljava/nio/Buffer;", AccessFlags = 17)]
				public global::Java.Nio.Buffer Limit(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.Buffer);
				}

				/// <java-name>
				/// mark
				/// </java-name>
				[Dot42.DexImport("mark", "()Ljava/nio/Buffer;", AccessFlags = 17)]
				public global::Java.Nio.Buffer Mark() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.Buffer);
				}

				/// <java-name>
				/// position
				/// </java-name>
				[Dot42.DexImport("position", "()I", AccessFlags = 17)]
				public int Position() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// position
				/// </java-name>
				[Dot42.DexImport("position", "(I)Ljava/nio/Buffer;", AccessFlags = 17)]
				public global::Java.Nio.Buffer Position(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.Buffer);
				}

				/// <java-name>
				/// remaining
				/// </java-name>
				[Dot42.DexImport("remaining", "()I", AccessFlags = 17)]
				public int Remaining() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// reset
				/// </java-name>
				[Dot42.DexImport("reset", "()Ljava/nio/Buffer;", AccessFlags = 17)]
				public global::Java.Nio.Buffer Reset() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.Buffer);
				}

				/// <java-name>
				/// rewind
				/// </java-name>
				[Dot42.DexImport("rewind", "()Ljava/nio/Buffer;", AccessFlags = 17)]
				public global::Java.Nio.Buffer Rewind() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.Buffer);
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
				/// hasArray
				/// </java-name>
				public abstract bool HasArray
				{
						[Dot42.DexImport("hasArray", "()Z", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// hasRemaining
				/// </java-name>
				public bool HasRemaining
				{
						[Dot42.DexImport("hasRemaining", "()Z", AccessFlags = 17)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// isDirect
				/// </java-name>
				public abstract bool IsDirect
				{
						[Dot42.DexImport("isDirect", "()Z", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// isReadOnly
				/// </java-name>
				public abstract bool IsReadOnly
				{
						[Dot42.DexImport("isReadOnly", "()Z", AccessFlags = 1025)]
						get;
				}

		}

		/// <java-name>
		/// java/nio/BufferOverflowException
		/// </java-name>
		[Dot42.DexImport("java/nio/BufferOverflowException", AccessFlags = 33)]
		public partial class BufferOverflowException : global::System.SystemException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public BufferOverflowException() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/nio/BufferUnderflowException
		/// </java-name>
		[Dot42.DexImport("java/nio/BufferUnderflowException", AccessFlags = 33)]
		public partial class BufferUnderflowException : global::System.SystemException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public BufferUnderflowException() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/nio/ByteBuffer
		/// </java-name>
		[Dot42.DexImport("java/nio/ByteBuffer", AccessFlags = 1057, Signature = "Ljava/nio/Buffer;Ljava/lang/Comparable<Ljava/nio/ByteBuffer;>;")]
		public abstract partial class ByteBuffer : global::Java.Nio.Buffer, global::System.IComparable<global::Java.Nio.ByteBuffer>
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal ByteBuffer() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// allocate
				/// </java-name>
				[Dot42.DexImport("allocate", "(I)Ljava/nio/ByteBuffer;", AccessFlags = 9)]
				public static global::Java.Nio.ByteBuffer Allocate(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.ByteBuffer);
				}

				/// <java-name>
				/// allocateDirect
				/// </java-name>
				[Dot42.DexImport("allocateDirect", "(I)Ljava/nio/ByteBuffer;", AccessFlags = 9)]
				public static global::Java.Nio.ByteBuffer AllocateDirect(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.ByteBuffer);
				}

				/// <java-name>
				/// wrap
				/// </java-name>
				[Dot42.DexImport("wrap", "([B)Ljava/nio/ByteBuffer;", AccessFlags = 9)]
				public static global::Java.Nio.ByteBuffer Wrap(sbyte[] sByte) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.ByteBuffer);
				}

				/// <java-name>
				/// wrap
				/// </java-name>
				[Dot42.DexImport("wrap", "([B)Ljava/nio/ByteBuffer;", AccessFlags = 9, IgnoreFromJava = true)]
				public static global::Java.Nio.ByteBuffer Wrap(byte[] @byte) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.ByteBuffer);
				}

				/// <java-name>
				/// wrap
				/// </java-name>
				[Dot42.DexImport("wrap", "([BII)Ljava/nio/ByteBuffer;", AccessFlags = 9)]
				public static global::Java.Nio.ByteBuffer Wrap(sbyte[] sByte, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.ByteBuffer);
				}

				/// <java-name>
				/// wrap
				/// </java-name>
				[Dot42.DexImport("wrap", "([BII)Ljava/nio/ByteBuffer;", AccessFlags = 9, IgnoreFromJava = true)]
				public static global::Java.Nio.ByteBuffer Wrap(byte[] @byte, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.ByteBuffer);
				}

				/// <java-name>
				/// array
				/// </java-name>
				[Dot42.DexImport("array", "()[B", AccessFlags = 17)]
				public override object Array() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <java-name>
				/// arrayOffset
				/// </java-name>
				[Dot42.DexImport("arrayOffset", "()I", AccessFlags = 17)]
				public override int ArrayOffset() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// asCharBuffer
				/// </java-name>
				[Dot42.DexImport("asCharBuffer", "()Ljava/nio/CharBuffer;", AccessFlags = 1025)]
				public abstract global::Java.Nio.CharBuffer AsCharBuffer() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// asDoubleBuffer
				/// </java-name>
				[Dot42.DexImport("asDoubleBuffer", "()Ljava/nio/DoubleBuffer;", AccessFlags = 1025)]
				public abstract global::Java.Nio.DoubleBuffer AsDoubleBuffer() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// asFloatBuffer
				/// </java-name>
				[Dot42.DexImport("asFloatBuffer", "()Ljava/nio/FloatBuffer;", AccessFlags = 1025)]
				public abstract global::Java.Nio.FloatBuffer AsFloatBuffer() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// asIntBuffer
				/// </java-name>
				[Dot42.DexImport("asIntBuffer", "()Ljava/nio/IntBuffer;", AccessFlags = 1025)]
				public abstract global::Java.Nio.IntBuffer AsIntBuffer() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// asLongBuffer
				/// </java-name>
				[Dot42.DexImport("asLongBuffer", "()Ljava/nio/LongBuffer;", AccessFlags = 1025)]
				public abstract global::Java.Nio.LongBuffer AsLongBuffer() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// asReadOnlyBuffer
				/// </java-name>
				[Dot42.DexImport("asReadOnlyBuffer", "()Ljava/nio/ByteBuffer;", AccessFlags = 1025)]
				public abstract global::Java.Nio.ByteBuffer AsReadOnlyBuffer() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// asShortBuffer
				/// </java-name>
				[Dot42.DexImport("asShortBuffer", "()Ljava/nio/ShortBuffer;", AccessFlags = 1025)]
				public abstract global::Java.Nio.ShortBuffer AsShortBuffer() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// compact
				/// </java-name>
				[Dot42.DexImport("compact", "()Ljava/nio/ByteBuffer;", AccessFlags = 1025)]
				public abstract global::Java.Nio.ByteBuffer Compact() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// compareTo
				/// </java-name>
				[Dot42.DexImport("compareTo", "(Ljava/nio/ByteBuffer;)I", AccessFlags = 1)]
				public virtual int CompareTo(global::Java.Nio.ByteBuffer byteBuffer) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// duplicate
				/// </java-name>
				[Dot42.DexImport("duplicate", "()Ljava/nio/ByteBuffer;", AccessFlags = 1025)]
				public abstract global::Java.Nio.ByteBuffer Duplicate() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "()B", AccessFlags = 1025)]
				public abstract sbyte JavaGet() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "()B", AccessFlags = 1025, IgnoreFromJava = true)]
				public abstract byte Get() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "([B)Ljava/nio/ByteBuffer;", AccessFlags = 1)]
				public virtual global::Java.Nio.ByteBuffer Get(sbyte[] sByte) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.ByteBuffer);
				}

				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "([B)Ljava/nio/ByteBuffer;", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual global::Java.Nio.ByteBuffer Get(byte[] @byte) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.ByteBuffer);
				}

				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "([BII)Ljava/nio/ByteBuffer;", AccessFlags = 1)]
				public virtual global::Java.Nio.ByteBuffer Get(sbyte[] sByte, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.ByteBuffer);
				}

				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "([BII)Ljava/nio/ByteBuffer;", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual global::Java.Nio.ByteBuffer Get(byte[] @byte, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.ByteBuffer);
				}

				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(I)B", AccessFlags = 1025)]
				public abstract sbyte JavaGet(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(I)B", AccessFlags = 1025, IgnoreFromJava = true)]
				public abstract byte Get(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getChar
				/// </java-name>
				[Dot42.DexImport("getChar", "(I)C", AccessFlags = 1025)]
				public abstract char GetChar(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getDouble
				/// </java-name>
				[Dot42.DexImport("getDouble", "(I)D", AccessFlags = 1025)]
				public abstract double GetDouble(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getFloat
				/// </java-name>
				[Dot42.DexImport("getFloat", "(I)F", AccessFlags = 1025)]
				public abstract float GetFloat(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getInt
				/// </java-name>
				[Dot42.DexImport("getInt", "(I)I", AccessFlags = 1025)]
				public abstract int GetInt(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getLong
				/// </java-name>
				[Dot42.DexImport("getLong", "(I)J", AccessFlags = 1025)]
				public abstract long GetLong(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getShort
				/// </java-name>
				[Dot42.DexImport("getShort", "(I)S", AccessFlags = 1025)]
				public abstract short GetShort(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 1)]
				public override int GetHashCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// order
				/// </java-name>
				[Dot42.DexImport("order", "()Ljava/nio/ByteOrder;", AccessFlags = 17)]
				public global::Java.Nio.ByteOrder Order() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.ByteOrder);
				}

				/// <java-name>
				/// order
				/// </java-name>
				[Dot42.DexImport("order", "(Ljava/nio/ByteOrder;)Ljava/nio/ByteBuffer;", AccessFlags = 17)]
				public global::Java.Nio.ByteBuffer Order(global::Java.Nio.ByteOrder byteOrder) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.ByteBuffer);
				}

				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "(B)Ljava/nio/ByteBuffer;", AccessFlags = 1025)]
				public abstract global::Java.Nio.ByteBuffer Put(sbyte sByte) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "(B)Ljava/nio/ByteBuffer;", AccessFlags = 1025, IgnoreFromJava = true)]
				public abstract global::Java.Nio.ByteBuffer Put(byte @byte) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "([B)Ljava/nio/ByteBuffer;", AccessFlags = 17)]
				public global::Java.Nio.ByteBuffer Put(sbyte[] sByte) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.ByteBuffer);
				}

				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "([B)Ljava/nio/ByteBuffer;", AccessFlags = 17, IgnoreFromJava = true)]
				public global::Java.Nio.ByteBuffer Put(byte[] @byte) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.ByteBuffer);
				}

				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "([BII)Ljava/nio/ByteBuffer;", AccessFlags = 1)]
				public virtual global::Java.Nio.ByteBuffer Put(sbyte[] sByte, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.ByteBuffer);
				}

				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "([BII)Ljava/nio/ByteBuffer;", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual global::Java.Nio.ByteBuffer Put(byte[] @byte, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.ByteBuffer);
				}

				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "(Ljava/nio/ByteBuffer;)Ljava/nio/ByteBuffer;", AccessFlags = 1)]
				public virtual global::Java.Nio.ByteBuffer Put(global::Java.Nio.ByteBuffer byteBuffer) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.ByteBuffer);
				}

				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "(IB)Ljava/nio/ByteBuffer;", AccessFlags = 1025)]
				public abstract global::Java.Nio.ByteBuffer Put(int int32, sbyte sByte) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "(IB)Ljava/nio/ByteBuffer;", AccessFlags = 1025, IgnoreFromJava = true)]
				public abstract global::Java.Nio.ByteBuffer Put(int int32, byte @byte) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// putChar
				/// </java-name>
				[Dot42.DexImport("putChar", "(C)Ljava/nio/ByteBuffer;", AccessFlags = 1025)]
				public abstract global::Java.Nio.ByteBuffer PutChar(char @char) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// putChar
				/// </java-name>
				[Dot42.DexImport("putChar", "(IC)Ljava/nio/ByteBuffer;", AccessFlags = 1025)]
				public abstract global::Java.Nio.ByteBuffer PutChar(int int32, char @char) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// putDouble
				/// </java-name>
				[Dot42.DexImport("putDouble", "(D)Ljava/nio/ByteBuffer;", AccessFlags = 1025)]
				public abstract global::Java.Nio.ByteBuffer PutDouble(double @double) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// putDouble
				/// </java-name>
				[Dot42.DexImport("putDouble", "(ID)Ljava/nio/ByteBuffer;", AccessFlags = 1025)]
				public abstract global::Java.Nio.ByteBuffer PutDouble(int int32, double @double) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// putFloat
				/// </java-name>
				[Dot42.DexImport("putFloat", "(F)Ljava/nio/ByteBuffer;", AccessFlags = 1025)]
				public abstract global::Java.Nio.ByteBuffer PutFloat(float single) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// putFloat
				/// </java-name>
				[Dot42.DexImport("putFloat", "(IF)Ljava/nio/ByteBuffer;", AccessFlags = 1025)]
				public abstract global::Java.Nio.ByteBuffer PutFloat(int int32, float single) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// putInt
				/// </java-name>
				[Dot42.DexImport("putInt", "(I)Ljava/nio/ByteBuffer;", AccessFlags = 1025)]
				public abstract global::Java.Nio.ByteBuffer PutInt(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// putInt
				/// </java-name>
				[Dot42.DexImport("putInt", "(II)Ljava/nio/ByteBuffer;", AccessFlags = 1025)]
				public abstract global::Java.Nio.ByteBuffer PutInt(int int32, int int321) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// putLong
				/// </java-name>
				[Dot42.DexImport("putLong", "(J)Ljava/nio/ByteBuffer;", AccessFlags = 1025)]
				public abstract global::Java.Nio.ByteBuffer PutLong(long int64) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// putLong
				/// </java-name>
				[Dot42.DexImport("putLong", "(IJ)Ljava/nio/ByteBuffer;", AccessFlags = 1025)]
				public abstract global::Java.Nio.ByteBuffer PutLong(int int32, long int64) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// putShort
				/// </java-name>
				[Dot42.DexImport("putShort", "(S)Ljava/nio/ByteBuffer;", AccessFlags = 1025)]
				public abstract global::Java.Nio.ByteBuffer PutShort(short int16) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// putShort
				/// </java-name>
				[Dot42.DexImport("putShort", "(IS)Ljava/nio/ByteBuffer;", AccessFlags = 1025)]
				public abstract global::Java.Nio.ByteBuffer PutShort(int int32, short int16) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// slice
				/// </java-name>
				[Dot42.DexImport("slice", "()Ljava/nio/ByteBuffer;", AccessFlags = 1025)]
				public abstract global::Java.Nio.ByteBuffer Slice() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getChar
				/// </java-name>
				public abstract char Char
				{
						[Dot42.DexImport("getChar", "()C", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getDouble
				/// </java-name>
				public abstract double Double
				{
						[Dot42.DexImport("getDouble", "()D", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getFloat
				/// </java-name>
				public abstract float Float
				{
						[Dot42.DexImport("getFloat", "()F", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getInt
				/// </java-name>
				public abstract int Int
				{
						[Dot42.DexImport("getInt", "()I", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getLong
				/// </java-name>
				public abstract long Long
				{
						[Dot42.DexImport("getLong", "()J", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getShort
				/// </java-name>
				public abstract short Short
				{
						[Dot42.DexImport("getShort", "()S", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// hasArray
				/// </java-name>
				public override bool HasArray
				{
						[Dot42.DexImport("hasArray", "()Z", AccessFlags = 17)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// isDirect
				/// </java-name>
				public override bool IsDirect
				{
						[Dot42.DexImport("isDirect", "()Z", AccessFlags = 1025)]
						get{ return default(bool); }
				}

		}

		/// <java-name>
		/// java/nio/ByteOrder
		/// </java-name>
		[Dot42.DexImport("java/nio/ByteOrder", AccessFlags = 49)]
		public sealed partial class ByteOrder
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// BIG_ENDIAN
				/// </java-name>
				[Dot42.DexImport("BIG_ENDIAN", "Ljava/nio/ByteOrder;", AccessFlags = 25)]
				public static readonly global::Java.Nio.ByteOrder BIG_ENDIAN;
				/// <java-name>
				/// LITTLE_ENDIAN
				/// </java-name>
				[Dot42.DexImport("LITTLE_ENDIAN", "Ljava/nio/ByteOrder;", AccessFlags = 25)]
				public static readonly global::Java.Nio.ByteOrder LITTLE_ENDIAN;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal ByteOrder() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// nativeOrder
				/// </java-name>
				[Dot42.DexImport("nativeOrder", "()Ljava/nio/ByteOrder;", AccessFlags = 9)]
				public static global::Java.Nio.ByteOrder NativeOrder() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.ByteOrder);
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
		/// java/nio/CharBuffer
		/// </java-name>
		[Dot42.DexImport("java/nio/CharBuffer", AccessFlags = 1057, Signature = "Ljava/nio/Buffer;Ljava/lang/Comparable<Ljava/nio/CharBuffer;>;Ljava/lang/CharSequ" +
    "ence;Ljava/lang/Appendable;Ljava/lang/Readable;")]
		public abstract partial class CharBuffer : global::Java.Nio.Buffer, global::System.IComparable<global::Java.Nio.CharBuffer>, global::Java.Lang.ICharSequence, global::Java.Lang.IAppendable, global::Java.Lang.IReadable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal CharBuffer() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// allocate
				/// </java-name>
				[Dot42.DexImport("allocate", "(I)Ljava/nio/CharBuffer;", AccessFlags = 9)]
				public static global::Java.Nio.CharBuffer Allocate(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.CharBuffer);
				}

				/// <java-name>
				/// wrap
				/// </java-name>
				[Dot42.DexImport("wrap", "([C)Ljava/nio/CharBuffer;", AccessFlags = 9)]
				public static global::Java.Nio.CharBuffer Wrap(char[] @char) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.CharBuffer);
				}

				/// <java-name>
				/// wrap
				/// </java-name>
				[Dot42.DexImport("wrap", "([CII)Ljava/nio/CharBuffer;", AccessFlags = 9)]
				public static global::Java.Nio.CharBuffer Wrap(char[] @char, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.CharBuffer);
				}

				/// <java-name>
				/// wrap
				/// </java-name>
				[Dot42.DexImport("wrap", "(Ljava/lang/CharSequence;)Ljava/nio/CharBuffer;", AccessFlags = 9)]
				public static global::Java.Nio.CharBuffer Wrap(global::Java.Lang.ICharSequence charSequence) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.CharBuffer);
				}

				/// <java-name>
				/// wrap
				/// </java-name>
				[Dot42.DexImport("wrap", "(Ljava/lang/CharSequence;II)Ljava/nio/CharBuffer;", AccessFlags = 9)]
				public static global::Java.Nio.CharBuffer Wrap(global::Java.Lang.ICharSequence charSequence, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.CharBuffer);
				}

				/// <java-name>
				/// array
				/// </java-name>
				[Dot42.DexImport("array", "()[C", AccessFlags = 17)]
				public override object Array() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <java-name>
				/// arrayOffset
				/// </java-name>
				[Dot42.DexImport("arrayOffset", "()I", AccessFlags = 17)]
				public override int ArrayOffset() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// asReadOnlyBuffer
				/// </java-name>
				[Dot42.DexImport("asReadOnlyBuffer", "()Ljava/nio/CharBuffer;", AccessFlags = 1025)]
				public abstract global::Java.Nio.CharBuffer AsReadOnlyBuffer() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// charAt
				/// </java-name>
				[Dot42.DexImport("charAt", "(I)C", AccessFlags = 17)]
				public char CharAt(int int32) /* MethodBuilder.Create */ 
				{
						return default(char);
				}

				/// <java-name>
				/// compact
				/// </java-name>
				[Dot42.DexImport("compact", "()Ljava/nio/CharBuffer;", AccessFlags = 1025)]
				public abstract global::Java.Nio.CharBuffer Compact() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// compareTo
				/// </java-name>
				[Dot42.DexImport("compareTo", "(Ljava/nio/CharBuffer;)I", AccessFlags = 1)]
				public virtual int CompareTo(global::Java.Nio.CharBuffer charBuffer) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// duplicate
				/// </java-name>
				[Dot42.DexImport("duplicate", "()Ljava/nio/CharBuffer;", AccessFlags = 1025)]
				public abstract global::Java.Nio.CharBuffer Duplicate() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "()C", AccessFlags = 1025)]
				public abstract char Get() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "([C)Ljava/nio/CharBuffer;", AccessFlags = 1)]
				public virtual global::Java.Nio.CharBuffer Get(char[] @char) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.CharBuffer);
				}

				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "([CII)Ljava/nio/CharBuffer;", AccessFlags = 1)]
				public virtual global::Java.Nio.CharBuffer Get(char[] @char, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.CharBuffer);
				}

				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(I)C", AccessFlags = 1025)]
				public abstract char Get(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 1)]
				public override int GetHashCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// length
				/// </java-name>
				[Dot42.DexImport("length", "()I", AccessFlags = 17)]
				public int GetLength() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// order
				/// </java-name>
				[Dot42.DexImport("order", "()Ljava/nio/ByteOrder;", AccessFlags = 1025)]
				public abstract global::Java.Nio.ByteOrder Order() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "(C)Ljava/nio/CharBuffer;", AccessFlags = 1025)]
				public abstract global::Java.Nio.CharBuffer Put(char @char) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "([C)Ljava/nio/CharBuffer;", AccessFlags = 17)]
				public global::Java.Nio.CharBuffer Put(char[] @char) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.CharBuffer);
				}

				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "([CII)Ljava/nio/CharBuffer;", AccessFlags = 1)]
				public virtual global::Java.Nio.CharBuffer Put(char[] @char, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.CharBuffer);
				}

				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "(Ljava/nio/CharBuffer;)Ljava/nio/CharBuffer;", AccessFlags = 1)]
				public virtual global::Java.Nio.CharBuffer Put(global::Java.Nio.CharBuffer charBuffer) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.CharBuffer);
				}

				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "(IC)Ljava/nio/CharBuffer;", AccessFlags = 1025)]
				public abstract global::Java.Nio.CharBuffer Put(int int32, char @char) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "(Ljava/lang/String;)Ljava/nio/CharBuffer;", AccessFlags = 17)]
				public global::Java.Nio.CharBuffer Put(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.CharBuffer);
				}

				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "(Ljava/lang/String;II)Ljava/nio/CharBuffer;", AccessFlags = 1)]
				public virtual global::Java.Nio.CharBuffer Put(string @string, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.CharBuffer);
				}

				/// <java-name>
				/// slice
				/// </java-name>
				[Dot42.DexImport("slice", "()Ljava/nio/CharBuffer;", AccessFlags = 1025)]
				public abstract global::Java.Nio.CharBuffer Slice() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// subSequence
				/// </java-name>
				[Dot42.DexImport("subSequence", "(II)Ljava/lang/CharSequence;", AccessFlags = 1025)]
				public virtual global::Java.Lang.ICharSequence SubSequence(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
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
				/// append
				/// </java-name>
				[Dot42.DexImport("append", "(C)Ljava/nio/CharBuffer;", AccessFlags = 1)]
				public virtual global::Java.Nio.CharBuffer Append(char @char) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.CharBuffer);
				}

				/// <java-name>
				/// append
				/// </java-name>
				[Dot42.DexImport("append", "(Ljava/lang/CharSequence;)Ljava/nio/CharBuffer;", AccessFlags = 1)]
				public virtual global::Java.Nio.CharBuffer Append(global::Java.Lang.ICharSequence charSequence) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.CharBuffer);
				}

				/// <java-name>
				/// append
				/// </java-name>
				[Dot42.DexImport("append", "(Ljava/lang/CharSequence;II)Ljava/nio/CharBuffer;", AccessFlags = 1)]
				public virtual global::Java.Nio.CharBuffer JavaAppend(global::Java.Lang.ICharSequence charSequence, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.CharBuffer);
				}

				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "(Ljava/nio/CharBuffer;)I", AccessFlags = 1)]
				public virtual int Read(global::Java.Nio.CharBuffer charBuffer) /* MethodBuilder.Create */ 
				{
						return default(int);
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

				/// <java-name>
				/// hasArray
				/// </java-name>
				public override bool HasArray
				{
						[Dot42.DexImport("hasArray", "()Z", AccessFlags = 17)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// isDirect
				/// </java-name>
				public override bool IsDirect
				{
						[Dot42.DexImport("isDirect", "()Z", AccessFlags = 1025)]
						get{ return default(bool); }
				}

		}

		/// <java-name>
		/// java/nio/DoubleBuffer
		/// </java-name>
		[Dot42.DexImport("java/nio/DoubleBuffer", AccessFlags = 1057, Signature = "Ljava/nio/Buffer;Ljava/lang/Comparable<Ljava/nio/DoubleBuffer;>;")]
		public abstract partial class DoubleBuffer : global::Java.Nio.Buffer, global::System.IComparable<global::Java.Nio.DoubleBuffer>
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal DoubleBuffer() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// allocate
				/// </java-name>
				[Dot42.DexImport("allocate", "(I)Ljava/nio/DoubleBuffer;", AccessFlags = 9)]
				public static global::Java.Nio.DoubleBuffer Allocate(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.DoubleBuffer);
				}

				/// <java-name>
				/// wrap
				/// </java-name>
				[Dot42.DexImport("wrap", "([D)Ljava/nio/DoubleBuffer;", AccessFlags = 9)]
				public static global::Java.Nio.DoubleBuffer Wrap(double[] @double) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.DoubleBuffer);
				}

				/// <java-name>
				/// wrap
				/// </java-name>
				[Dot42.DexImport("wrap", "([DII)Ljava/nio/DoubleBuffer;", AccessFlags = 9)]
				public static global::Java.Nio.DoubleBuffer Wrap(double[] @double, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.DoubleBuffer);
				}

				/// <java-name>
				/// array
				/// </java-name>
				[Dot42.DexImport("array", "()[D", AccessFlags = 17)]
				public override object Array() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <java-name>
				/// arrayOffset
				/// </java-name>
				[Dot42.DexImport("arrayOffset", "()I", AccessFlags = 17)]
				public override int ArrayOffset() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// asReadOnlyBuffer
				/// </java-name>
				[Dot42.DexImport("asReadOnlyBuffer", "()Ljava/nio/DoubleBuffer;", AccessFlags = 1025)]
				public abstract global::Java.Nio.DoubleBuffer AsReadOnlyBuffer() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// compact
				/// </java-name>
				[Dot42.DexImport("compact", "()Ljava/nio/DoubleBuffer;", AccessFlags = 1025)]
				public abstract global::Java.Nio.DoubleBuffer Compact() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// compareTo
				/// </java-name>
				[Dot42.DexImport("compareTo", "(Ljava/nio/DoubleBuffer;)I", AccessFlags = 1)]
				public virtual int CompareTo(global::Java.Nio.DoubleBuffer doubleBuffer) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// duplicate
				/// </java-name>
				[Dot42.DexImport("duplicate", "()Ljava/nio/DoubleBuffer;", AccessFlags = 1025)]
				public abstract global::Java.Nio.DoubleBuffer Duplicate() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "()D", AccessFlags = 1025)]
				public abstract double Get() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "([D)Ljava/nio/DoubleBuffer;", AccessFlags = 1)]
				public virtual global::Java.Nio.DoubleBuffer Get(double[] @double) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.DoubleBuffer);
				}

				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "([DII)Ljava/nio/DoubleBuffer;", AccessFlags = 1)]
				public virtual global::Java.Nio.DoubleBuffer Get(double[] @double, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.DoubleBuffer);
				}

				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(I)D", AccessFlags = 1025)]
				public abstract double Get(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 1)]
				public override int GetHashCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// order
				/// </java-name>
				[Dot42.DexImport("order", "()Ljava/nio/ByteOrder;", AccessFlags = 1025)]
				public abstract global::Java.Nio.ByteOrder Order() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "(D)Ljava/nio/DoubleBuffer;", AccessFlags = 1025)]
				public abstract global::Java.Nio.DoubleBuffer Put(double @double) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "([D)Ljava/nio/DoubleBuffer;", AccessFlags = 17)]
				public global::Java.Nio.DoubleBuffer Put(double[] @double) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.DoubleBuffer);
				}

				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "([DII)Ljava/nio/DoubleBuffer;", AccessFlags = 1)]
				public virtual global::Java.Nio.DoubleBuffer Put(double[] @double, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.DoubleBuffer);
				}

				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "(Ljava/nio/DoubleBuffer;)Ljava/nio/DoubleBuffer;", AccessFlags = 1)]
				public virtual global::Java.Nio.DoubleBuffer Put(global::Java.Nio.DoubleBuffer doubleBuffer) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.DoubleBuffer);
				}

				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "(ID)Ljava/nio/DoubleBuffer;", AccessFlags = 1025)]
				public abstract global::Java.Nio.DoubleBuffer Put(int int32, double @double) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// slice
				/// </java-name>
				[Dot42.DexImport("slice", "()Ljava/nio/DoubleBuffer;", AccessFlags = 1025)]
				public abstract global::Java.Nio.DoubleBuffer Slice() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// hasArray
				/// </java-name>
				public override bool HasArray
				{
						[Dot42.DexImport("hasArray", "()Z", AccessFlags = 17)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// isDirect
				/// </java-name>
				public override bool IsDirect
				{
						[Dot42.DexImport("isDirect", "()Z", AccessFlags = 1025)]
						get{ return default(bool); }
				}

		}

		/// <java-name>
		/// java/nio/FloatBuffer
		/// </java-name>
		[Dot42.DexImport("java/nio/FloatBuffer", AccessFlags = 1057, Signature = "Ljava/nio/Buffer;Ljava/lang/Comparable<Ljava/nio/FloatBuffer;>;")]
		public abstract partial class FloatBuffer : global::Java.Nio.Buffer, global::System.IComparable<global::Java.Nio.FloatBuffer>
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal FloatBuffer() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// allocate
				/// </java-name>
				[Dot42.DexImport("allocate", "(I)Ljava/nio/FloatBuffer;", AccessFlags = 9)]
				public static global::Java.Nio.FloatBuffer Allocate(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.FloatBuffer);
				}

				/// <java-name>
				/// wrap
				/// </java-name>
				[Dot42.DexImport("wrap", "([F)Ljava/nio/FloatBuffer;", AccessFlags = 9)]
				public static global::Java.Nio.FloatBuffer Wrap(float[] single) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.FloatBuffer);
				}

				/// <java-name>
				/// wrap
				/// </java-name>
				[Dot42.DexImport("wrap", "([FII)Ljava/nio/FloatBuffer;", AccessFlags = 9)]
				public static global::Java.Nio.FloatBuffer Wrap(float[] single, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.FloatBuffer);
				}

				/// <java-name>
				/// array
				/// </java-name>
				[Dot42.DexImport("array", "()[F", AccessFlags = 17)]
				public override object Array() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <java-name>
				/// arrayOffset
				/// </java-name>
				[Dot42.DexImport("arrayOffset", "()I", AccessFlags = 17)]
				public override int ArrayOffset() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// asReadOnlyBuffer
				/// </java-name>
				[Dot42.DexImport("asReadOnlyBuffer", "()Ljava/nio/FloatBuffer;", AccessFlags = 1025)]
				public abstract global::Java.Nio.FloatBuffer AsReadOnlyBuffer() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// compact
				/// </java-name>
				[Dot42.DexImport("compact", "()Ljava/nio/FloatBuffer;", AccessFlags = 1025)]
				public abstract global::Java.Nio.FloatBuffer Compact() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// compareTo
				/// </java-name>
				[Dot42.DexImport("compareTo", "(Ljava/nio/FloatBuffer;)I", AccessFlags = 1)]
				public virtual int CompareTo(global::Java.Nio.FloatBuffer floatBuffer) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// duplicate
				/// </java-name>
				[Dot42.DexImport("duplicate", "()Ljava/nio/FloatBuffer;", AccessFlags = 1025)]
				public abstract global::Java.Nio.FloatBuffer Duplicate() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "()F", AccessFlags = 1025)]
				public abstract float Get() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "([F)Ljava/nio/FloatBuffer;", AccessFlags = 1)]
				public virtual global::Java.Nio.FloatBuffer Get(float[] single) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.FloatBuffer);
				}

				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "([FII)Ljava/nio/FloatBuffer;", AccessFlags = 1)]
				public virtual global::Java.Nio.FloatBuffer Get(float[] single, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.FloatBuffer);
				}

				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(I)F", AccessFlags = 1025)]
				public abstract float Get(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 1)]
				public override int GetHashCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// order
				/// </java-name>
				[Dot42.DexImport("order", "()Ljava/nio/ByteOrder;", AccessFlags = 1025)]
				public abstract global::Java.Nio.ByteOrder Order() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "(F)Ljava/nio/FloatBuffer;", AccessFlags = 1025)]
				public abstract global::Java.Nio.FloatBuffer Put(float single) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "([F)Ljava/nio/FloatBuffer;", AccessFlags = 17)]
				public global::Java.Nio.FloatBuffer Put(float[] single) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.FloatBuffer);
				}

				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "([FII)Ljava/nio/FloatBuffer;", AccessFlags = 1)]
				public virtual global::Java.Nio.FloatBuffer Put(float[] single, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.FloatBuffer);
				}

				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "(Ljava/nio/FloatBuffer;)Ljava/nio/FloatBuffer;", AccessFlags = 1)]
				public virtual global::Java.Nio.FloatBuffer Put(global::Java.Nio.FloatBuffer floatBuffer) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.FloatBuffer);
				}

				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "(IF)Ljava/nio/FloatBuffer;", AccessFlags = 1025)]
				public abstract global::Java.Nio.FloatBuffer Put(int int32, float single) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// slice
				/// </java-name>
				[Dot42.DexImport("slice", "()Ljava/nio/FloatBuffer;", AccessFlags = 1025)]
				public abstract global::Java.Nio.FloatBuffer Slice() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// hasArray
				/// </java-name>
				public override bool HasArray
				{
						[Dot42.DexImport("hasArray", "()Z", AccessFlags = 17)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// isDirect
				/// </java-name>
				public override bool IsDirect
				{
						[Dot42.DexImport("isDirect", "()Z", AccessFlags = 1025)]
						get{ return default(bool); }
				}

		}

		/// <java-name>
		/// java/nio/IntBuffer
		/// </java-name>
		[Dot42.DexImport("java/nio/IntBuffer", AccessFlags = 1057, Signature = "Ljava/nio/Buffer;Ljava/lang/Comparable<Ljava/nio/IntBuffer;>;")]
		public abstract partial class IntBuffer : global::Java.Nio.Buffer, global::System.IComparable<global::Java.Nio.IntBuffer>
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal IntBuffer() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// allocate
				/// </java-name>
				[Dot42.DexImport("allocate", "(I)Ljava/nio/IntBuffer;", AccessFlags = 9)]
				public static global::Java.Nio.IntBuffer Allocate(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.IntBuffer);
				}

				/// <java-name>
				/// wrap
				/// </java-name>
				[Dot42.DexImport("wrap", "([I)Ljava/nio/IntBuffer;", AccessFlags = 9)]
				public static global::Java.Nio.IntBuffer Wrap(int[] int32) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.IntBuffer);
				}

				/// <java-name>
				/// wrap
				/// </java-name>
				[Dot42.DexImport("wrap", "([III)Ljava/nio/IntBuffer;", AccessFlags = 9)]
				public static global::Java.Nio.IntBuffer Wrap(int[] int32, int int321, int int322) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.IntBuffer);
				}

				/// <java-name>
				/// array
				/// </java-name>
				[Dot42.DexImport("array", "()[I", AccessFlags = 17)]
				public override object Array() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <java-name>
				/// arrayOffset
				/// </java-name>
				[Dot42.DexImport("arrayOffset", "()I", AccessFlags = 17)]
				public override int ArrayOffset() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// asReadOnlyBuffer
				/// </java-name>
				[Dot42.DexImport("asReadOnlyBuffer", "()Ljava/nio/IntBuffer;", AccessFlags = 1025)]
				public abstract global::Java.Nio.IntBuffer AsReadOnlyBuffer() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// compact
				/// </java-name>
				[Dot42.DexImport("compact", "()Ljava/nio/IntBuffer;", AccessFlags = 1025)]
				public abstract global::Java.Nio.IntBuffer Compact() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// compareTo
				/// </java-name>
				[Dot42.DexImport("compareTo", "(Ljava/nio/IntBuffer;)I", AccessFlags = 1)]
				public virtual int CompareTo(global::Java.Nio.IntBuffer intBuffer) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// duplicate
				/// </java-name>
				[Dot42.DexImport("duplicate", "()Ljava/nio/IntBuffer;", AccessFlags = 1025)]
				public abstract global::Java.Nio.IntBuffer Duplicate() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "()I", AccessFlags = 1025)]
				public abstract int Get() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "([I)Ljava/nio/IntBuffer;", AccessFlags = 1)]
				public virtual global::Java.Nio.IntBuffer Get(int[] int32) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.IntBuffer);
				}

				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "([III)Ljava/nio/IntBuffer;", AccessFlags = 1)]
				public virtual global::Java.Nio.IntBuffer Get(int[] int32, int int321, int int322) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.IntBuffer);
				}

				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(I)I", AccessFlags = 1025)]
				public abstract int Get(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 1)]
				public override int GetHashCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// order
				/// </java-name>
				[Dot42.DexImport("order", "()Ljava/nio/ByteOrder;", AccessFlags = 1025)]
				public abstract global::Java.Nio.ByteOrder Order() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "(I)Ljava/nio/IntBuffer;", AccessFlags = 1025)]
				public abstract global::Java.Nio.IntBuffer Put(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "([I)Ljava/nio/IntBuffer;", AccessFlags = 17)]
				public global::Java.Nio.IntBuffer Put(int[] int32) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.IntBuffer);
				}

				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "([III)Ljava/nio/IntBuffer;", AccessFlags = 1)]
				public virtual global::Java.Nio.IntBuffer Put(int[] int32, int int321, int int322) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.IntBuffer);
				}

				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "(Ljava/nio/IntBuffer;)Ljava/nio/IntBuffer;", AccessFlags = 1)]
				public virtual global::Java.Nio.IntBuffer Put(global::Java.Nio.IntBuffer intBuffer) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.IntBuffer);
				}

				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "(II)Ljava/nio/IntBuffer;", AccessFlags = 1025)]
				public abstract global::Java.Nio.IntBuffer Put(int int32, int int321) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// slice
				/// </java-name>
				[Dot42.DexImport("slice", "()Ljava/nio/IntBuffer;", AccessFlags = 1025)]
				public abstract global::Java.Nio.IntBuffer Slice() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// hasArray
				/// </java-name>
				public override bool HasArray
				{
						[Dot42.DexImport("hasArray", "()Z", AccessFlags = 17)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// isDirect
				/// </java-name>
				public override bool IsDirect
				{
						[Dot42.DexImport("isDirect", "()Z", AccessFlags = 1025)]
						get{ return default(bool); }
				}

		}

		/// <java-name>
		/// java/nio/InvalidMarkException
		/// </java-name>
		[Dot42.DexImport("java/nio/InvalidMarkException", AccessFlags = 33)]
		public partial class InvalidMarkException : global::Java.Lang.IllegalStateException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public InvalidMarkException() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/nio/LongBuffer
		/// </java-name>
		[Dot42.DexImport("java/nio/LongBuffer", AccessFlags = 1057, Signature = "Ljava/nio/Buffer;Ljava/lang/Comparable<Ljava/nio/LongBuffer;>;")]
		public abstract partial class LongBuffer : global::Java.Nio.Buffer, global::System.IComparable<global::Java.Nio.LongBuffer>
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal LongBuffer() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// allocate
				/// </java-name>
				[Dot42.DexImport("allocate", "(I)Ljava/nio/LongBuffer;", AccessFlags = 9)]
				public static global::Java.Nio.LongBuffer Allocate(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.LongBuffer);
				}

				/// <java-name>
				/// wrap
				/// </java-name>
				[Dot42.DexImport("wrap", "([J)Ljava/nio/LongBuffer;", AccessFlags = 9)]
				public static global::Java.Nio.LongBuffer Wrap(long[] int64) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.LongBuffer);
				}

				/// <java-name>
				/// wrap
				/// </java-name>
				[Dot42.DexImport("wrap", "([JII)Ljava/nio/LongBuffer;", AccessFlags = 9)]
				public static global::Java.Nio.LongBuffer Wrap(long[] int64, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.LongBuffer);
				}

				/// <java-name>
				/// array
				/// </java-name>
				[Dot42.DexImport("array", "()[J", AccessFlags = 17)]
				public override object Array() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <java-name>
				/// arrayOffset
				/// </java-name>
				[Dot42.DexImport("arrayOffset", "()I", AccessFlags = 17)]
				public override int ArrayOffset() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// asReadOnlyBuffer
				/// </java-name>
				[Dot42.DexImport("asReadOnlyBuffer", "()Ljava/nio/LongBuffer;", AccessFlags = 1025)]
				public abstract global::Java.Nio.LongBuffer AsReadOnlyBuffer() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// compact
				/// </java-name>
				[Dot42.DexImport("compact", "()Ljava/nio/LongBuffer;", AccessFlags = 1025)]
				public abstract global::Java.Nio.LongBuffer Compact() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// compareTo
				/// </java-name>
				[Dot42.DexImport("compareTo", "(Ljava/nio/LongBuffer;)I", AccessFlags = 1)]
				public virtual int CompareTo(global::Java.Nio.LongBuffer longBuffer) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// duplicate
				/// </java-name>
				[Dot42.DexImport("duplicate", "()Ljava/nio/LongBuffer;", AccessFlags = 1025)]
				public abstract global::Java.Nio.LongBuffer Duplicate() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "()J", AccessFlags = 1025)]
				public abstract long Get() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "([J)Ljava/nio/LongBuffer;", AccessFlags = 1)]
				public virtual global::Java.Nio.LongBuffer Get(long[] int64) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.LongBuffer);
				}

				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "([JII)Ljava/nio/LongBuffer;", AccessFlags = 1)]
				public virtual global::Java.Nio.LongBuffer Get(long[] int64, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.LongBuffer);
				}

				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(I)J", AccessFlags = 1025)]
				public abstract long Get(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 1)]
				public override int GetHashCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// order
				/// </java-name>
				[Dot42.DexImport("order", "()Ljava/nio/ByteOrder;", AccessFlags = 1025)]
				public abstract global::Java.Nio.ByteOrder Order() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "(J)Ljava/nio/LongBuffer;", AccessFlags = 1025)]
				public abstract global::Java.Nio.LongBuffer Put(long int64) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "([J)Ljava/nio/LongBuffer;", AccessFlags = 17)]
				public global::Java.Nio.LongBuffer Put(long[] int64) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.LongBuffer);
				}

				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "([JII)Ljava/nio/LongBuffer;", AccessFlags = 1)]
				public virtual global::Java.Nio.LongBuffer Put(long[] int64, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.LongBuffer);
				}

				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "(Ljava/nio/LongBuffer;)Ljava/nio/LongBuffer;", AccessFlags = 1)]
				public virtual global::Java.Nio.LongBuffer Put(global::Java.Nio.LongBuffer longBuffer) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.LongBuffer);
				}

				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "(IJ)Ljava/nio/LongBuffer;", AccessFlags = 1025)]
				public abstract global::Java.Nio.LongBuffer Put(int int32, long int64) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// slice
				/// </java-name>
				[Dot42.DexImport("slice", "()Ljava/nio/LongBuffer;", AccessFlags = 1025)]
				public abstract global::Java.Nio.LongBuffer Slice() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// hasArray
				/// </java-name>
				public override bool HasArray
				{
						[Dot42.DexImport("hasArray", "()Z", AccessFlags = 17)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// isDirect
				/// </java-name>
				public override bool IsDirect
				{
						[Dot42.DexImport("isDirect", "()Z", AccessFlags = 1025)]
						get{ return default(bool); }
				}

		}

		/// <java-name>
		/// java/nio/MappedByteBuffer
		/// </java-name>
		[Dot42.DexImport("java/nio/MappedByteBuffer", AccessFlags = 1057)]
		public abstract partial class MappedByteBuffer : global::Java.Nio.ByteBuffer
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal MappedByteBuffer() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// load
				/// </java-name>
				[Dot42.DexImport("load", "()Ljava/nio/MappedByteBuffer;", AccessFlags = 17)]
				public global::Java.Nio.MappedByteBuffer Load() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.MappedByteBuffer);
				}

				/// <java-name>
				/// force
				/// </java-name>
				[Dot42.DexImport("force", "()Ljava/nio/MappedByteBuffer;", AccessFlags = 17)]
				public global::Java.Nio.MappedByteBuffer Force() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.MappedByteBuffer);
				}

				/// <java-name>
				/// isLoaded
				/// </java-name>
				public bool IsLoaded
				{
						[Dot42.DexImport("isLoaded", "()Z", AccessFlags = 17)]
						get{ return default(bool); }
				}

		}

		/// <java-name>
		/// java/nio/ReadOnlyBufferException
		/// </java-name>
		[Dot42.DexImport("java/nio/ReadOnlyBufferException", AccessFlags = 33)]
		public partial class ReadOnlyBufferException : global::Java.Lang.UnsupportedOperationException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ReadOnlyBufferException() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/nio/ShortBuffer
		/// </java-name>
		[Dot42.DexImport("java/nio/ShortBuffer", AccessFlags = 1057, Signature = "Ljava/nio/Buffer;Ljava/lang/Comparable<Ljava/nio/ShortBuffer;>;")]
		public abstract partial class ShortBuffer : global::Java.Nio.Buffer, global::System.IComparable<global::Java.Nio.ShortBuffer>
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal ShortBuffer() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// allocate
				/// </java-name>
				[Dot42.DexImport("allocate", "(I)Ljava/nio/ShortBuffer;", AccessFlags = 9)]
				public static global::Java.Nio.ShortBuffer Allocate(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.ShortBuffer);
				}

				/// <java-name>
				/// wrap
				/// </java-name>
				[Dot42.DexImport("wrap", "([S)Ljava/nio/ShortBuffer;", AccessFlags = 9)]
				public static global::Java.Nio.ShortBuffer Wrap(short[] int16) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.ShortBuffer);
				}

				/// <java-name>
				/// wrap
				/// </java-name>
				[Dot42.DexImport("wrap", "([SII)Ljava/nio/ShortBuffer;", AccessFlags = 9)]
				public static global::Java.Nio.ShortBuffer Wrap(short[] int16, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.ShortBuffer);
				}

				/// <java-name>
				/// array
				/// </java-name>
				[Dot42.DexImport("array", "()[S", AccessFlags = 17)]
				public override object Array() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <java-name>
				/// arrayOffset
				/// </java-name>
				[Dot42.DexImport("arrayOffset", "()I", AccessFlags = 17)]
				public override int ArrayOffset() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// asReadOnlyBuffer
				/// </java-name>
				[Dot42.DexImport("asReadOnlyBuffer", "()Ljava/nio/ShortBuffer;", AccessFlags = 1025)]
				public abstract global::Java.Nio.ShortBuffer AsReadOnlyBuffer() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// compact
				/// </java-name>
				[Dot42.DexImport("compact", "()Ljava/nio/ShortBuffer;", AccessFlags = 1025)]
				public abstract global::Java.Nio.ShortBuffer Compact() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// compareTo
				/// </java-name>
				[Dot42.DexImport("compareTo", "(Ljava/nio/ShortBuffer;)I", AccessFlags = 1)]
				public virtual int CompareTo(global::Java.Nio.ShortBuffer shortBuffer) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// duplicate
				/// </java-name>
				[Dot42.DexImport("duplicate", "()Ljava/nio/ShortBuffer;", AccessFlags = 1025)]
				public abstract global::Java.Nio.ShortBuffer Duplicate() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "()S", AccessFlags = 1025)]
				public abstract short Get() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "([S)Ljava/nio/ShortBuffer;", AccessFlags = 1)]
				public virtual global::Java.Nio.ShortBuffer Get(short[] int16) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.ShortBuffer);
				}

				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "([SII)Ljava/nio/ShortBuffer;", AccessFlags = 1)]
				public virtual global::Java.Nio.ShortBuffer Get(short[] int16, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.ShortBuffer);
				}

				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(I)S", AccessFlags = 1025)]
				public abstract short Get(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 1)]
				public override int GetHashCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// order
				/// </java-name>
				[Dot42.DexImport("order", "()Ljava/nio/ByteOrder;", AccessFlags = 1025)]
				public abstract global::Java.Nio.ByteOrder Order() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "(S)Ljava/nio/ShortBuffer;", AccessFlags = 1025)]
				public abstract global::Java.Nio.ShortBuffer Put(short int16) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "([S)Ljava/nio/ShortBuffer;", AccessFlags = 17)]
				public global::Java.Nio.ShortBuffer Put(short[] int16) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.ShortBuffer);
				}

				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "([SII)Ljava/nio/ShortBuffer;", AccessFlags = 1)]
				public virtual global::Java.Nio.ShortBuffer Put(short[] int16, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.ShortBuffer);
				}

				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "(Ljava/nio/ShortBuffer;)Ljava/nio/ShortBuffer;", AccessFlags = 1)]
				public virtual global::Java.Nio.ShortBuffer Put(global::Java.Nio.ShortBuffer shortBuffer) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.ShortBuffer);
				}

				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "(IS)Ljava/nio/ShortBuffer;", AccessFlags = 1025)]
				public abstract global::Java.Nio.ShortBuffer Put(int int32, short int16) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// slice
				/// </java-name>
				[Dot42.DexImport("slice", "()Ljava/nio/ShortBuffer;", AccessFlags = 1025)]
				public abstract global::Java.Nio.ShortBuffer Slice() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// hasArray
				/// </java-name>
				public override bool HasArray
				{
						[Dot42.DexImport("hasArray", "()Z", AccessFlags = 17)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// isDirect
				/// </java-name>
				public override bool IsDirect
				{
						[Dot42.DexImport("isDirect", "()Z", AccessFlags = 1025)]
						get{ return default(bool); }
				}

		}

}

