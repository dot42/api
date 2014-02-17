// Copyright (C) 2014 dot42
//
// Original filename: Java.Nio.cs
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
namespace Java.Nio
{
		/// <summary>
		/// <para>A buffer of ints. </para><para>A int buffer can be created in either of the following ways: <ul><li><para>Allocate a new int array and create a buffer based on it; </para></li><li><para>Wrap an existing int array to create a new buffer; </para></li><li><para>Use ByteBuffer.asIntBuffer to create a int buffer based on a byte buffer. </para></li></ul></para>    
		/// </summary>
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

				/// <summary>
				/// <para>Creates an int buffer based on a newly allocated int array.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the created int buffer. </para>
				/// </returns>
				/// <java-name>
				/// allocate
				/// </java-name>
				[Dot42.DexImport("allocate", "(I)Ljava/nio/IntBuffer;", AccessFlags = 9)]
				public static global::Java.Nio.IntBuffer Allocate(int capacity) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.IntBuffer);
				}

				/// <summary>
				/// <para>Creates a new int buffer by wrapping the given int array. </para><para>Calling this method has the same effect as <c> wrap(array, 0, array.length) </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the created int buffer. </para>
				/// </returns>
				/// <java-name>
				/// wrap
				/// </java-name>
				[Dot42.DexImport("wrap", "([I)Ljava/nio/IntBuffer;", AccessFlags = 9)]
				public static global::Java.Nio.IntBuffer Wrap(int[] array) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.IntBuffer);
				}

				/// <summary>
				/// <para>Creates a new int buffer by wrapping the given int array. </para><para>The new buffer's position will be <c> start </c> , limit will be <c> start + intCount </c> , capacity will be the length of the array.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the created int buffer. </para>
				/// </returns>
				/// <java-name>
				/// wrap
				/// </java-name>
				[Dot42.DexImport("wrap", "([III)Ljava/nio/IntBuffer;", AccessFlags = 9)]
				public static global::Java.Nio.IntBuffer Wrap(int[] array, int start, int intCount) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.IntBuffer);
				}

				/// <summary>
				/// <para>Returns the array that backs this buffer (optional operation). The returned value is the actual array, not a copy, so modifications to the array write through to the buffer.</para><para>Subclasses should override this method with a covariant return type to provide the exact type of the array.</para><para>Use <c> hasArray </c> to ensure this method won't throw. (A separate call to <c> isReadOnly </c> is not necessary.)</para><para><para>1.6 </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the array </para>
				/// </returns>
				/// <java-name>
				/// array
				/// </java-name>
				[Dot42.DexImport("array", "()[I", AccessFlags = 17)]
				public override object Array() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <summary>
				/// <para>Returns the offset into the array returned by <c> array </c> of the first element of the buffer (optional operation). The backing array (if there is one) is not necessarily the same size as the buffer, and position 0 in the buffer is not necessarily the 0th element in the array. Use <c> buffer.array()[offset + buffer.arrayOffset() </c> to access element <c> offset </c> in <c> buffer </c> .</para><para>Use <c> hasArray </c> to ensure this method won't throw. (A separate call to <c> isReadOnly </c> is not necessary.)</para><para><para>1.6 </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the offset </para>
				/// </returns>
				/// <java-name>
				/// arrayOffset
				/// </java-name>
				[Dot42.DexImport("arrayOffset", "()I", AccessFlags = 17)]
				public override int ArrayOffset() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns a read-only buffer that shares its content with this buffer. </para><para>The returned buffer is guaranteed to be a new instance, even this buffer is read-only itself. The new buffer's position, limit, capacity and mark are the same as this buffer's. </para><para>The new buffer shares its content with this buffer, which means this buffer's change of content will be visible to the new buffer. The two buffer's position, limit and mark are independent.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a read-only version of this buffer. </para>
				/// </returns>
				/// <java-name>
				/// asReadOnlyBuffer
				/// </java-name>
				[Dot42.DexImport("asReadOnlyBuffer", "()Ljava/nio/IntBuffer;", AccessFlags = 1025)]
				public abstract global::Java.Nio.IntBuffer AsReadOnlyBuffer() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Compacts this int buffer. </para><para>The remaining ints will be moved to the head of the buffer, starting from position zero. Then the position is set to <c> remaining() </c> ; the limit is set to capacity; the mark is cleared.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>this buffer. </para>
				/// </returns>
				/// <java-name>
				/// compact
				/// </java-name>
				[Dot42.DexImport("compact", "()Ljava/nio/IntBuffer;", AccessFlags = 1025)]
				public abstract global::Java.Nio.IntBuffer Compact() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Compares the remaining ints of this buffer to another int buffer's remaining ints.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a negative value if this is less than <c> other </c> ; 0 if this equals to <c> other </c> ; a positive value if this is greater than <c> other </c> . </para>
				/// </returns>
				/// <java-name>
				/// compareTo
				/// </java-name>
				[Dot42.DexImport("compareTo", "(Ljava/nio/IntBuffer;)I", AccessFlags = 1)]
				public virtual int CompareTo(global::Java.Nio.IntBuffer otherBuffer) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns a duplicated buffer that shares its content with this buffer. </para><para>The duplicated buffer's position, limit, capacity and mark are the same as this buffer. The duplicated buffer's read-only property and byte order are the same as this buffer's. </para><para>The new buffer shares its content with this buffer, which means either buffer's change of content will be visible to the other. The two buffer's position, limit and mark are independent.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a duplicated buffer that shares its content with this buffer. </para>
				/// </returns>
				/// <java-name>
				/// duplicate
				/// </java-name>
				[Dot42.DexImport("duplicate", "()Ljava/nio/IntBuffer;", AccessFlags = 1025)]
				public abstract global::Java.Nio.IntBuffer Duplicate() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Checks whether this int buffer is equal to another object. </para><para>If <c> other </c> is not a int buffer then <c> false </c> is returned. Two int buffers are equal if and only if their remaining ints are exactly the same. Position, limit, capacity and mark are not considered.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if this int buffer is equal to <c> other </c> , <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object other) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns the int at the current position and increases the position by 1.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the int at the current position. </para>
				/// </returns>
				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "()I", AccessFlags = 1025)]
				public abstract int Get() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns an int at the specified index; the position is not changed.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an int at the specified index. </para>
				/// </returns>
				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "([I)Ljava/nio/IntBuffer;", AccessFlags = 1)]
				public virtual global::Java.Nio.IntBuffer Get(int[] index) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.IntBuffer);
				}

				/// <summary>
				/// <para>Reads ints from the current position into the specified int array, starting from the specified offset, and increases the position by the number of ints read.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>this buffer. </para>
				/// </returns>
				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "([III)Ljava/nio/IntBuffer;", AccessFlags = 1)]
				public virtual global::Java.Nio.IntBuffer Get(int[] dst, int dstOffset, int intCount) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.IntBuffer);
				}

				/// <summary>
				/// <para>Returns an int at the specified index; the position is not changed.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an int at the specified index. </para>
				/// </returns>
				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(I)I", AccessFlags = 1025)]
				public abstract int Get(int index) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns true if <c> array </c> and <c> arrayOffset </c> won't throw. This method does not return true for buffers not backed by arrays because the other methods would throw <c> UnsupportedOperationException </c> , nor does it return true for buffers backed by read-only arrays, because the other methods would throw <c> ReadOnlyBufferException </c> . <para>1.6 </para></para>        
				/// </summary>
				/// <java-name>
				/// hasArray
				/// </java-name>
				[Dot42.DexImport("hasArray", "()Z", AccessFlags = 17)]
				public override bool HasArray() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Calculates this buffer's hash code from the remaining chars. The position, limit, capacity and mark don't affect the hash code.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the hash code calculated from the remaining ints. </para>
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
				/// <para>Indicates whether this buffer is direct. A direct buffer will try its best to take advantage of native memory APIs and it may not stay in the Java heap, so it is not affected by garbage collection. </para><para>An int buffer is direct if it is based on a byte buffer and the byte buffer is direct.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if this buffer is direct, <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isDirect
				/// </java-name>
				[Dot42.DexImport("isDirect", "()Z", AccessFlags = 1025)]
				public override bool IsDirect() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns the byte order used by this buffer when converting ints from/to bytes. </para><para>If this buffer is not based on a byte buffer, then always return the platform's native byte order.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the byte order used by this buffer when converting ints from/to bytes. </para>
				/// </returns>
				/// <java-name>
				/// order
				/// </java-name>
				[Dot42.DexImport("order", "()Ljava/nio/ByteOrder;", AccessFlags = 1025)]
				public abstract global::Java.Nio.ByteOrder Order() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Writes the given int to the current position and increases the position by 1.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>this buffer. </para>
				/// </returns>
				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "(I)Ljava/nio/IntBuffer;", AccessFlags = 1025)]
				public abstract global::Java.Nio.IntBuffer Put(int i) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Writes the given int to the current position and increases the position by 1.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>this buffer. </para>
				/// </returns>
				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "([I)Ljava/nio/IntBuffer;", AccessFlags = 17)]
				public global::Java.Nio.IntBuffer Put(int[] i) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.IntBuffer);
				}

				/// <summary>
				/// <para>Writes ints from the given int array, starting from the specified offset, to the current position and increases the position by the number of ints written.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>this buffer. </para>
				/// </returns>
				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "([III)Ljava/nio/IntBuffer;", AccessFlags = 1)]
				public virtual global::Java.Nio.IntBuffer Put(int[] src, int srcOffset, int intCount) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.IntBuffer);
				}

				/// <summary>
				/// <para>Writes the given int to the current position and increases the position by 1.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>this buffer. </para>
				/// </returns>
				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "(Ljava/nio/IntBuffer;)Ljava/nio/IntBuffer;", AccessFlags = 1)]
				public virtual global::Java.Nio.IntBuffer Put(global::Java.Nio.IntBuffer i) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.IntBuffer);
				}

				/// <summary>
				/// <para>Write a int to the specified index of this buffer; the position is not changed.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>this buffer. </para>
				/// </returns>
				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "(II)Ljava/nio/IntBuffer;", AccessFlags = 1025)]
				public abstract global::Java.Nio.IntBuffer Put(int index, int i) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns a sliced buffer that shares its content with this buffer. </para><para>The sliced buffer's capacity will be this buffer's <c> remaining() </c> , and its zero position will correspond to this buffer's current position. The new buffer's position will be 0, limit will be its capacity, and its mark is cleared. The new buffer's read-only property and byte order are same as this buffer's. </para><para>The new buffer shares its content with this buffer, which means either buffer's change of content will be visible to the other. The two buffer's position, limit and mark are independent.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a sliced buffer that shares its content with this buffer. </para>
				/// </returns>
				/// <java-name>
				/// slice
				/// </java-name>
				[Dot42.DexImport("slice", "()Ljava/nio/IntBuffer;", AccessFlags = 1025)]
				public abstract global::Java.Nio.IntBuffer Slice() /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>A buffer of doubles. </para><para>A double buffer can be created in either one of the following ways: <ul><li><para>Allocate a new double array and create a buffer based on it; </para></li><li><para>Wrap an existing double array to create a new buffer; </para></li><li><para>Use ByteBuffer.asDoubleBuffer to create a double buffer based on a byte buffer. </para></li></ul></para>    
		/// </summary>
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

				/// <summary>
				/// <para>Creates a double buffer based on a newly allocated double array.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the created double buffer. </para>
				/// </returns>
				/// <java-name>
				/// allocate
				/// </java-name>
				[Dot42.DexImport("allocate", "(I)Ljava/nio/DoubleBuffer;", AccessFlags = 9)]
				public static global::Java.Nio.DoubleBuffer Allocate(int capacity) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.DoubleBuffer);
				}

				/// <summary>
				/// <para>Creates a new double buffer by wrapping the given double array. </para><para>Calling this method has the same effect as <c> wrap(array, 0, array.length) </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the created double buffer. </para>
				/// </returns>
				/// <java-name>
				/// wrap
				/// </java-name>
				[Dot42.DexImport("wrap", "([D)Ljava/nio/DoubleBuffer;", AccessFlags = 9)]
				public static global::Java.Nio.DoubleBuffer Wrap(double[] array) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.DoubleBuffer);
				}

				/// <summary>
				/// <para>Creates a new double buffer by wrapping the given double array. </para><para>The new buffer's position will be <c> start </c> , limit will be <c> start + doubleCount </c> , capacity will be the length of the array.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the created double buffer. </para>
				/// </returns>
				/// <java-name>
				/// wrap
				/// </java-name>
				[Dot42.DexImport("wrap", "([DII)Ljava/nio/DoubleBuffer;", AccessFlags = 9)]
				public static global::Java.Nio.DoubleBuffer Wrap(double[] array, int start, int doubleCount) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.DoubleBuffer);
				}

				/// <summary>
				/// <para>Returns the array that backs this buffer (optional operation). The returned value is the actual array, not a copy, so modifications to the array write through to the buffer.</para><para>Subclasses should override this method with a covariant return type to provide the exact type of the array.</para><para>Use <c> hasArray </c> to ensure this method won't throw. (A separate call to <c> isReadOnly </c> is not necessary.)</para><para><para>1.6 </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the array </para>
				/// </returns>
				/// <java-name>
				/// array
				/// </java-name>
				[Dot42.DexImport("array", "()[D", AccessFlags = 17)]
				public override object Array() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <summary>
				/// <para>Returns the offset into the array returned by <c> array </c> of the first element of the buffer (optional operation). The backing array (if there is one) is not necessarily the same size as the buffer, and position 0 in the buffer is not necessarily the 0th element in the array. Use <c> buffer.array()[offset + buffer.arrayOffset() </c> to access element <c> offset </c> in <c> buffer </c> .</para><para>Use <c> hasArray </c> to ensure this method won't throw. (A separate call to <c> isReadOnly </c> is not necessary.)</para><para><para>1.6 </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the offset </para>
				/// </returns>
				/// <java-name>
				/// arrayOffset
				/// </java-name>
				[Dot42.DexImport("arrayOffset", "()I", AccessFlags = 17)]
				public override int ArrayOffset() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns a read-only buffer that shares its content with this buffer. </para><para>The returned buffer is guaranteed to be a new instance, even if this buffer is read-only itself. The new buffer's position, limit, capacity and mark are the same as this buffer's. </para><para>The new buffer shares its content with this buffer, which means that this buffer's change of content will be visible to the new buffer. The two buffer's position, limit and mark are independent.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a read-only version of this buffer. </para>
				/// </returns>
				/// <java-name>
				/// asReadOnlyBuffer
				/// </java-name>
				[Dot42.DexImport("asReadOnlyBuffer", "()Ljava/nio/DoubleBuffer;", AccessFlags = 1025)]
				public abstract global::Java.Nio.DoubleBuffer AsReadOnlyBuffer() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Compacts this double buffer. </para><para>The remaining doubles will be moved to the head of the buffer, staring from position zero. Then the position is set to <c> remaining() </c> ; the limit is set to capacity; the mark is cleared.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>this buffer. </para>
				/// </returns>
				/// <java-name>
				/// compact
				/// </java-name>
				[Dot42.DexImport("compact", "()Ljava/nio/DoubleBuffer;", AccessFlags = 1025)]
				public abstract global::Java.Nio.DoubleBuffer Compact() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Compare the remaining doubles of this buffer to another double buffer's remaining doubles.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a negative value if this is less than <c> other </c> ; 0 if this equals to <c> other </c> ; a positive value if this is greater than <c> other </c> . </para>
				/// </returns>
				/// <java-name>
				/// compareTo
				/// </java-name>
				[Dot42.DexImport("compareTo", "(Ljava/nio/DoubleBuffer;)I", AccessFlags = 1)]
				public virtual int CompareTo(global::Java.Nio.DoubleBuffer otherBuffer) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns a duplicated buffer that shares its content with this buffer. </para><para>The duplicated buffer's position, limit, capacity and mark are the same as this buffer's. The duplicated buffer's read-only property and byte order are the same as this buffer's, too. </para><para>The new buffer shares its content with this buffer, which means either buffer's change of content will be visible to the other. The two buffer's position, limit and mark are independent.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a duplicated buffer that shares its content with this buffer. </para>
				/// </returns>
				/// <java-name>
				/// duplicate
				/// </java-name>
				[Dot42.DexImport("duplicate", "()Ljava/nio/DoubleBuffer;", AccessFlags = 1025)]
				public abstract global::Java.Nio.DoubleBuffer Duplicate() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Checks whether this double buffer is equal to another object. If <c>       other </c> is not a <c> DoubleBuffer </c> then <c> false </c> is returned.</para><para>Two double buffers are equal if their remaining doubles are equal. Position, limit, capacity and mark are not considered.</para><para>This method considers two doubles <c> a </c> and <c> b </c> to be equal if <c> a == b </c> or if <c> a </c> and <c> b </c> are both <c> NaN </c> . Unlike Double#equals, this method considers <c> -0.0 </c> and <c> +0.0 </c> to be equal.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if this double buffer is equal to <c> other </c> , <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object other) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns the double at the current position and increases the position by 1.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the double at the current position. </para>
				/// </returns>
				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "()D", AccessFlags = 1025)]
				public abstract double Get() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns a double at the specified index; the position is not changed.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a double at the specified index. </para>
				/// </returns>
				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "([D)Ljava/nio/DoubleBuffer;", AccessFlags = 1)]
				public virtual global::Java.Nio.DoubleBuffer Get(double[] index) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.DoubleBuffer);
				}

				/// <summary>
				/// <para>Reads doubles from the current position into the specified double array, starting from the specified offset, and increases the position by the number of doubles read.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>this buffer. </para>
				/// </returns>
				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "([DII)Ljava/nio/DoubleBuffer;", AccessFlags = 1)]
				public virtual global::Java.Nio.DoubleBuffer Get(double[] dst, int dstOffset, int doubleCount) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.DoubleBuffer);
				}

				/// <summary>
				/// <para>Returns a double at the specified index; the position is not changed.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a double at the specified index. </para>
				/// </returns>
				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(I)D", AccessFlags = 1025)]
				public abstract double Get(int index) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns true if <c> array </c> and <c> arrayOffset </c> won't throw. This method does not return true for buffers not backed by arrays because the other methods would throw <c> UnsupportedOperationException </c> , nor does it return true for buffers backed by read-only arrays, because the other methods would throw <c> ReadOnlyBufferException </c> . <para>1.6 </para></para>        
				/// </summary>
				/// <java-name>
				/// hasArray
				/// </java-name>
				[Dot42.DexImport("hasArray", "()Z", AccessFlags = 17)]
				public override bool HasArray() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Calculates this buffer's hash code from the remaining chars. The position, limit, capacity and mark don't affect the hash code.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the hash code calculated from the remaining chars. </para>
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
				/// <para>Indicates whether this buffer is direct. A direct buffer will try its best to take advantage of native memory APIs and it may not stay in the Java heap, so it is not affected by garbage collection. </para><para>A double buffer is direct if it is based on a byte buffer and the byte buffer is direct.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if this buffer is direct, <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isDirect
				/// </java-name>
				[Dot42.DexImport("isDirect", "()Z", AccessFlags = 1025)]
				public override bool IsDirect() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns the byte order used by this buffer when converting doubles from/to bytes. </para><para>If this buffer is not based on a byte buffer, then this always returns the platform's native byte order.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the byte order used by this buffer when converting doubles from/to bytes. </para>
				/// </returns>
				/// <java-name>
				/// order
				/// </java-name>
				[Dot42.DexImport("order", "()Ljava/nio/ByteOrder;", AccessFlags = 1025)]
				public abstract global::Java.Nio.ByteOrder Order() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Writes all the remaining doubles of the <c> src </c> double buffer to this buffer's current position, and increases both buffers' position by the number of doubles copied.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>this buffer. </para>
				/// </returns>
				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "(D)Ljava/nio/DoubleBuffer;", AccessFlags = 1025)]
				public abstract global::Java.Nio.DoubleBuffer Put(double src) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Writes all the remaining doubles of the <c> src </c> double buffer to this buffer's current position, and increases both buffers' position by the number of doubles copied.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>this buffer. </para>
				/// </returns>
				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "([D)Ljava/nio/DoubleBuffer;", AccessFlags = 17)]
				public global::Java.Nio.DoubleBuffer Put(double[] src) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.DoubleBuffer);
				}

				/// <summary>
				/// <para>Writes doubles from the given double array, starting from the specified offset, to the current position and increases the position by the number of doubles written.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>this buffer. </para>
				/// </returns>
				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "([DII)Ljava/nio/DoubleBuffer;", AccessFlags = 1)]
				public virtual global::Java.Nio.DoubleBuffer Put(double[] src, int srcOffset, int doubleCount) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.DoubleBuffer);
				}

				/// <summary>
				/// <para>Writes all the remaining doubles of the <c> src </c> double buffer to this buffer's current position, and increases both buffers' position by the number of doubles copied.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>this buffer. </para>
				/// </returns>
				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "(Ljava/nio/DoubleBuffer;)Ljava/nio/DoubleBuffer;", AccessFlags = 1)]
				public virtual global::Java.Nio.DoubleBuffer Put(global::Java.Nio.DoubleBuffer src) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.DoubleBuffer);
				}

				/// <summary>
				/// <para>Write a double to the specified index of this buffer and the position is not changed.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>this buffer. </para>
				/// </returns>
				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "(ID)Ljava/nio/DoubleBuffer;", AccessFlags = 1025)]
				public abstract global::Java.Nio.DoubleBuffer Put(int index, double d) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns a sliced buffer that shares its content with this buffer. </para><para>The sliced buffer's capacity will be this buffer's <c> remaining() </c> , and its zero position will correspond to this buffer's current position. The new buffer's position will be 0, limit will be its capacity, and its mark is cleared. The new buffer's read-only property and byte order are the same as this buffer's. </para><para>The new buffer shares its content with this buffer, which means either buffer's change of content will be visible to the other. The two buffer's position, limit and mark are independent.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a sliced buffer that shares its content with this buffer. </para>
				/// </returns>
				/// <java-name>
				/// slice
				/// </java-name>
				[Dot42.DexImport("slice", "()Ljava/nio/DoubleBuffer;", AccessFlags = 1025)]
				public abstract global::Java.Nio.DoubleBuffer Slice() /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>A <code>BufferUnderflowException</code> is thrown when elements are read from a buffer but there are not enough remaining elements in the buffer. </para>    
		/// </summary>
		/// <java-name>
		/// java/nio/BufferUnderflowException
		/// </java-name>
		[Dot42.DexImport("java/nio/BufferUnderflowException", AccessFlags = 33)]
		public partial class BufferUnderflowException : global::System.SystemException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs a <code>BufferUnderflowException</code>. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public BufferUnderflowException() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>A buffer of chars. </para><para>A char buffer can be created in either one of the following ways: <ul><li><para>Allocate a new char array and create a buffer based on it; </para></li><li><para>Wrap an existing char array to create a new buffer; </para></li><li><para>Wrap an existing char sequence to create a new buffer; </para></li><li><para>Use ByteBuffer.asCharBuffer to create a char buffer based on a byte buffer. </para></li></ul></para>    
		/// </summary>
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

				/// <summary>
				/// <para>Creates a char buffer based on a newly allocated char array.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the created char buffer. </para>
				/// </returns>
				/// <java-name>
				/// allocate
				/// </java-name>
				[Dot42.DexImport("allocate", "(I)Ljava/nio/CharBuffer;", AccessFlags = 9)]
				public static global::Java.Nio.CharBuffer Allocate(int capacity) /* MethodBuilder.Create */ 
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

				/// <summary>
				/// <para>Returns the array that backs this buffer (optional operation). The returned value is the actual array, not a copy, so modifications to the array write through to the buffer.</para><para>Subclasses should override this method with a covariant return type to provide the exact type of the array.</para><para>Use <c> hasArray </c> to ensure this method won't throw. (A separate call to <c> isReadOnly </c> is not necessary.)</para><para><para>1.6 </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the array </para>
				/// </returns>
				/// <java-name>
				/// array
				/// </java-name>
				[Dot42.DexImport("array", "()[C", AccessFlags = 17)]
				public override object Array() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <summary>
				/// <para>Returns the offset into the array returned by <c> array </c> of the first element of the buffer (optional operation). The backing array (if there is one) is not necessarily the same size as the buffer, and position 0 in the buffer is not necessarily the 0th element in the array. Use <c> buffer.array()[offset + buffer.arrayOffset() </c> to access element <c> offset </c> in <c> buffer </c> .</para><para>Use <c> hasArray </c> to ensure this method won't throw. (A separate call to <c> isReadOnly </c> is not necessary.)</para><para><para>1.6 </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the offset </para>
				/// </returns>
				/// <java-name>
				/// arrayOffset
				/// </java-name>
				[Dot42.DexImport("arrayOffset", "()I", AccessFlags = 17)]
				public override int ArrayOffset() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns a read-only buffer that shares its content with this buffer. </para><para>The returned buffer is guaranteed to be a new instance, even if this buffer is read-only itself. The new buffer's position, limit, capacity and mark are the same as this buffer's. </para><para>The new buffer shares its content with this buffer, which means this buffer's change of content will be visible to the new buffer. The two buffer's position, limit and mark are independent.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a read-only version of this buffer. </para>
				/// </returns>
				/// <java-name>
				/// asReadOnlyBuffer
				/// </java-name>
				[Dot42.DexImport("asReadOnlyBuffer", "()Ljava/nio/CharBuffer;", AccessFlags = 1025)]
				public abstract global::Java.Nio.CharBuffer AsReadOnlyBuffer() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the character located at the specified index in the buffer. The index value is referenced from the current buffer position.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the character located at the specified index (referenced from the current position) in the buffer. </para>
				/// </returns>
				/// <java-name>
				/// charAt
				/// </java-name>
				[Dot42.DexImport("charAt", "(I)C", AccessFlags = 17)]
				public char CharAt(int index) /* MethodBuilder.Create */ 
				{
						return default(char);
				}

				/// <summary>
				/// <para>Compacts this char buffer. </para><para>The remaining chars will be moved to the head of the buffer, starting from position zero. Then the position is set to <c> remaining() </c> ; the limit is set to capacity; the mark is cleared.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>this buffer. </para>
				/// </returns>
				/// <java-name>
				/// compact
				/// </java-name>
				[Dot42.DexImport("compact", "()Ljava/nio/CharBuffer;", AccessFlags = 1025)]
				public abstract global::Java.Nio.CharBuffer Compact() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Compare the remaining chars of this buffer to another char buffer's remaining chars.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a negative value if this is less than <c> otherBuffer </c> ; 0 if this equals to <c> otherBuffer </c> ; a positive value if this is greater than <c> otherBuffer </c> . </para>
				/// </returns>
				/// <java-name>
				/// compareTo
				/// </java-name>
				[Dot42.DexImport("compareTo", "(Ljava/nio/CharBuffer;)I", AccessFlags = 1)]
				public virtual int CompareTo(global::Java.Nio.CharBuffer otherBuffer) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns a duplicated buffer that shares its content with this buffer. </para><para>The duplicated buffer's initial position, limit, capacity and mark are the same as this buffer's. The duplicated buffer's read-only property and byte order are the same as this buffer's, too. </para><para>The new buffer shares its content with this buffer, which means either buffer's change of content will be visible to the other. The two buffer's position, limit and mark are independent.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a duplicated buffer that shares its content with this buffer. </para>
				/// </returns>
				/// <java-name>
				/// duplicate
				/// </java-name>
				[Dot42.DexImport("duplicate", "()Ljava/nio/CharBuffer;", AccessFlags = 1025)]
				public abstract global::Java.Nio.CharBuffer Duplicate() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Checks whether this char buffer is equal to another object. </para><para>If <c> other </c> is not a char buffer then <c> false </c> is returned. Two char buffers are equal if and only if their remaining chars are exactly the same. Position, limit, capacity and mark are not considered.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if this char buffer is equal to <c> other </c> , <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object other) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns the char at the current position and increases the position by 1.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the char at the current position. </para>
				/// </returns>
				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "()C", AccessFlags = 1025)]
				public abstract char Get() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns a char at the specified index; the position is not changed.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a char at the specified index. </para>
				/// </returns>
				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "([C)Ljava/nio/CharBuffer;", AccessFlags = 1)]
				public virtual global::Java.Nio.CharBuffer Get(char[] index) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.CharBuffer);
				}

				/// <summary>
				/// <para>Reads chars from the current position into the specified char array, starting from the specified offset, and increases the position by the number of chars read.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>this buffer. </para>
				/// </returns>
				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "([CII)Ljava/nio/CharBuffer;", AccessFlags = 1)]
				public virtual global::Java.Nio.CharBuffer Get(char[] dst, int dstOffset, int charCount) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.CharBuffer);
				}

				/// <summary>
				/// <para>Returns a char at the specified index; the position is not changed.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a char at the specified index. </para>
				/// </returns>
				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(I)C", AccessFlags = 1025)]
				public abstract char Get(int index) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns true if <c> array </c> and <c> arrayOffset </c> won't throw. This method does not return true for buffers not backed by arrays because the other methods would throw <c> UnsupportedOperationException </c> , nor does it return true for buffers backed by read-only arrays, because the other methods would throw <c> ReadOnlyBufferException </c> . <para>1.6 </para></para>        
				/// </summary>
				/// <java-name>
				/// hasArray
				/// </java-name>
				[Dot42.DexImport("hasArray", "()Z", AccessFlags = 17)]
				public override bool HasArray() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Calculates this buffer's hash code from the remaining chars. The position, limit, capacity and mark don't affect the hash code.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the hash code calculated from the remaining chars. </para>
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
				/// <para>Indicates whether this buffer is direct. A direct buffer will try its best to take advantage of native memory APIs and it may not stay in the Java heap, so it is not affected by garbage collection. </para><para>A char buffer is direct if it is based on a byte buffer and the byte buffer is direct.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if this buffer is direct, <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isDirect
				/// </java-name>
				[Dot42.DexImport("isDirect", "()Z", AccessFlags = 1025)]
				public override bool IsDirect() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns the number of remaining chars.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of remaining chars. </para>
				/// </returns>
				/// <java-name>
				/// length
				/// </java-name>
				[Dot42.DexImport("length", "()I", AccessFlags = 17)]
				public int GetLength() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the byte order used by this buffer when converting chars from/to bytes. </para><para>If this buffer is not based on a byte buffer, then this always returns the platform's native byte order.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the byte order used by this buffer when converting chars from/to bytes. </para>
				/// </returns>
				/// <java-name>
				/// order
				/// </java-name>
				[Dot42.DexImport("order", "()Ljava/nio/ByteOrder;", AccessFlags = 1025)]
				public abstract global::Java.Nio.ByteOrder Order() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Writes all the remaining chars of the <c> src </c> char buffer to this buffer's current position, and increases both buffers' position by the number of chars copied.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>this buffer. </para>
				/// </returns>
				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "(C)Ljava/nio/CharBuffer;", AccessFlags = 1025)]
				public abstract global::Java.Nio.CharBuffer Put(char src) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Writes all the remaining chars of the <c> src </c> char buffer to this buffer's current position, and increases both buffers' position by the number of chars copied.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>this buffer. </para>
				/// </returns>
				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "([C)Ljava/nio/CharBuffer;", AccessFlags = 17)]
				public global::Java.Nio.CharBuffer Put(char[] src) /* MethodBuilder.Create */ 
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

				/// <summary>
				/// <para>Writes all the remaining chars of the <c> src </c> char buffer to this buffer's current position, and increases both buffers' position by the number of chars copied.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>this buffer. </para>
				/// </returns>
				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "(Ljava/nio/CharBuffer;)Ljava/nio/CharBuffer;", AccessFlags = 1)]
				public virtual global::Java.Nio.CharBuffer Put(global::Java.Nio.CharBuffer src) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.CharBuffer);
				}

				/// <summary>
				/// <para>Writes a char to the specified index of this buffer; the position is not changed.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>this buffer. </para>
				/// </returns>
				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "(IC)Ljava/nio/CharBuffer;", AccessFlags = 1025)]
				public abstract global::Java.Nio.CharBuffer Put(int index, char c) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Writes all the remaining chars of the <c> src </c> char buffer to this buffer's current position, and increases both buffers' position by the number of chars copied.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>this buffer. </para>
				/// </returns>
				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "(Ljava/lang/String;)Ljava/nio/CharBuffer;", AccessFlags = 17)]
				public global::Java.Nio.CharBuffer Put(string src) /* MethodBuilder.Create */ 
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

				/// <summary>
				/// <para>Returns a sliced buffer that shares its content with this buffer. </para><para>The sliced buffer's capacity will be this buffer's <c> remaining() </c> , and its zero position will correspond to this buffer's current position. The new buffer's position will be 0, limit will be its capacity, and its mark is cleared. The new buffer's read-only property and byte order are same as this buffer. </para><para>The new buffer shares its content with this buffer, which means either buffer's change of content will be visible to the other. The two buffer's position, limit and mark are independent.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a sliced buffer that shares its content with this buffer. </para>
				/// </returns>
				/// <java-name>
				/// slice
				/// </java-name>
				[Dot42.DexImport("slice", "()Ljava/nio/CharBuffer;", AccessFlags = 1025)]
				public abstract global::Java.Nio.CharBuffer Slice() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns a new char buffer representing a sub-sequence of this buffer's current remaining content. </para><para>The new buffer's position will be <c> position() + start </c> , limit will be <c> position() + end </c> , capacity will be the same as this buffer. The new buffer's read-only property and byte order are the same as this buffer. </para><para>The new buffer shares its content with this buffer, which means either buffer's change of content will be visible to the other. The two buffer's position, limit and mark are independent.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a new char buffer represents a sub-sequence of this buffer's current remaining content. </para>
				/// </returns>
				/// <java-name>
				/// subSequence
				/// </java-name>
				[Dot42.DexImport("subSequence", "(II)Ljava/lang/CharSequence;", AccessFlags = 1025)]
				public virtual global::Java.Lang.ICharSequence SubSequence(int start, int end) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <summary>
				/// <para>Returns a string representing the current remaining chars of this buffer. </para>        
				/// </summary>
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

				/// <summary>
				/// <para>Writes chars of the given <c> CharSequence </c> to the current position of this buffer, and increases the position by the number of chars written.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>this buffer. </para>
				/// </returns>
				/// <java-name>
				/// append
				/// </java-name>
				[Dot42.DexImport("append", "(Ljava/lang/CharSequence;II)Ljava/nio/CharBuffer;", AccessFlags = 1)]
				public virtual global::Java.Nio.CharBuffer JavaAppend(global::Java.Lang.ICharSequence csq, int start, int end) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.CharBuffer);
				}

				/// <summary>
				/// <para>Reads characters from this buffer and puts them into <c> target </c> . The number of chars that are copied is either the number of remaining chars in this buffer or the number of remaining chars in <c> target </c> , whichever is smaller.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of chars copied or -1 if there are no chars left to be read from this buffer. </para>
				/// </returns>
				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "(Ljava/nio/CharBuffer;)I", AccessFlags = 1)]
				public virtual int Read(global::Java.Nio.CharBuffer target) /* MethodBuilder.Create */ 
				{
						return default(int);
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

				/// <summary>
				/// <para>Returns the number of remaining chars.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of remaining chars. </para>
				/// </returns>
				/// <java-name>
				/// length
				/// </java-name>
				public int Length
				{
				[Dot42.DexImport("length", "()I", AccessFlags = 17)]
						get{ return GetLength(); }
				}

		}

		/// <summary>
		/// <para>A buffer of floats. </para><para>A float buffer can be created in either of the following ways: <ul><li><para>Allocate a new float array and create a buffer based on it; </para></li><li><para>Wrap an existing float array to create a new buffer; </para></li><li><para>Use ByteBuffer.asFloatBuffer to create a float buffer based on a byte buffer. </para></li></ul></para>    
		/// </summary>
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

				/// <summary>
				/// <para>Creates a float buffer based on a newly allocated float array.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the created float buffer. </para>
				/// </returns>
				/// <java-name>
				/// allocate
				/// </java-name>
				[Dot42.DexImport("allocate", "(I)Ljava/nio/FloatBuffer;", AccessFlags = 9)]
				public static global::Java.Nio.FloatBuffer Allocate(int capacity) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.FloatBuffer);
				}

				/// <summary>
				/// <para>Creates a new float buffer by wrapping the given float array. </para><para>Calling this method has the same effect as <c> wrap(array, 0, array.length) </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the created float buffer. </para>
				/// </returns>
				/// <java-name>
				/// wrap
				/// </java-name>
				[Dot42.DexImport("wrap", "([F)Ljava/nio/FloatBuffer;", AccessFlags = 9)]
				public static global::Java.Nio.FloatBuffer Wrap(float[] array) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.FloatBuffer);
				}

				/// <summary>
				/// <para>Creates a new float buffer by wrapping the given float array. </para><para>The new buffer's position will be <c> start </c> , limit will be <c> start + floatCount </c> , capacity will be the length of the array.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the created float buffer. </para>
				/// </returns>
				/// <java-name>
				/// wrap
				/// </java-name>
				[Dot42.DexImport("wrap", "([FII)Ljava/nio/FloatBuffer;", AccessFlags = 9)]
				public static global::Java.Nio.FloatBuffer Wrap(float[] array, int start, int floatCount) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.FloatBuffer);
				}

				/// <summary>
				/// <para>Returns the array that backs this buffer (optional operation). The returned value is the actual array, not a copy, so modifications to the array write through to the buffer.</para><para>Subclasses should override this method with a covariant return type to provide the exact type of the array.</para><para>Use <c> hasArray </c> to ensure this method won't throw. (A separate call to <c> isReadOnly </c> is not necessary.)</para><para><para>1.6 </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the array </para>
				/// </returns>
				/// <java-name>
				/// array
				/// </java-name>
				[Dot42.DexImport("array", "()[F", AccessFlags = 17)]
				public override object Array() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <summary>
				/// <para>Returns the offset into the array returned by <c> array </c> of the first element of the buffer (optional operation). The backing array (if there is one) is not necessarily the same size as the buffer, and position 0 in the buffer is not necessarily the 0th element in the array. Use <c> buffer.array()[offset + buffer.arrayOffset() </c> to access element <c> offset </c> in <c> buffer </c> .</para><para>Use <c> hasArray </c> to ensure this method won't throw. (A separate call to <c> isReadOnly </c> is not necessary.)</para><para><para>1.6 </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the offset </para>
				/// </returns>
				/// <java-name>
				/// arrayOffset
				/// </java-name>
				[Dot42.DexImport("arrayOffset", "()I", AccessFlags = 17)]
				public override int ArrayOffset() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns a read-only buffer that shares its content with this buffer. </para><para>The returned buffer is guaranteed to be a new instance, even if this buffer is read-only itself. The new buffer's position, limit, capacity and mark are the same as this buffer. </para><para>The new buffer shares its content with this buffer, which means this buffer's change of content will be visible to the new buffer. The two buffer's position, limit and mark are independent.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a read-only version of this buffer. </para>
				/// </returns>
				/// <java-name>
				/// asReadOnlyBuffer
				/// </java-name>
				[Dot42.DexImport("asReadOnlyBuffer", "()Ljava/nio/FloatBuffer;", AccessFlags = 1025)]
				public abstract global::Java.Nio.FloatBuffer AsReadOnlyBuffer() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Compacts this float buffer. </para><para>The remaining floats will be moved to the head of the buffer, starting from position zero. Then the position is set to <c> remaining() </c> ; the limit is set to capacity; the mark is cleared.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>this buffer. </para>
				/// </returns>
				/// <java-name>
				/// compact
				/// </java-name>
				[Dot42.DexImport("compact", "()Ljava/nio/FloatBuffer;", AccessFlags = 1025)]
				public abstract global::Java.Nio.FloatBuffer Compact() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Compare the remaining floats of this buffer to another float buffer's remaining floats.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a negative value if this is less than <c> otherBuffer </c> ; 0 if this equals to <c> otherBuffer </c> ; a positive value if this is greater than <c> otherBuffer </c> . </para>
				/// </returns>
				/// <java-name>
				/// compareTo
				/// </java-name>
				[Dot42.DexImport("compareTo", "(Ljava/nio/FloatBuffer;)I", AccessFlags = 1)]
				public virtual int CompareTo(global::Java.Nio.FloatBuffer otherBuffer) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns a duplicated buffer that shares its content with this buffer. </para><para>The duplicated buffer's position, limit, capacity and mark are the same as this buffer. The duplicated buffer's read-only property and byte order are same as this buffer too. </para><para>The new buffer shares its content with this buffer, which means either buffer's change of content will be visible to the other. The two buffer's position, limit and mark are independent.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a duplicated buffer that shares its content with this buffer. </para>
				/// </returns>
				/// <java-name>
				/// duplicate
				/// </java-name>
				[Dot42.DexImport("duplicate", "()Ljava/nio/FloatBuffer;", AccessFlags = 1025)]
				public abstract global::Java.Nio.FloatBuffer Duplicate() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Checks whether this float buffer is equal to another object. If <c>       other </c> is not a <c> FloatBuffer </c> then <c> false </c> is returned.</para><para>Two float buffers are equal if their remaining floats are equal. Position, limit, capacity and mark are not considered.</para><para>This method considers two floats <c> a </c> and <c> b </c> to be equal if <c> a == b </c> or if <c> a </c> and <c> b </c> are both <c> NaN </c> . Unlike Float#equals, this method considers <c> -0.0 </c> and <c> +0.0 </c> to be equal.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if this float buffer is equal to <c> other </c> , <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object other) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns the float at the current position and increases the position by 1.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the float at the current position. </para>
				/// </returns>
				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "()F", AccessFlags = 1025)]
				public abstract float Get() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns a float at the specified index; the position is not changed.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a float at the specified index. </para>
				/// </returns>
				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "([F)Ljava/nio/FloatBuffer;", AccessFlags = 1)]
				public virtual global::Java.Nio.FloatBuffer Get(float[] index) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.FloatBuffer);
				}

				/// <summary>
				/// <para>Reads floats from the current position into the specified float array, starting from the specified offset, and increases the position by the number of floats read.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>this buffer. </para>
				/// </returns>
				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "([FII)Ljava/nio/FloatBuffer;", AccessFlags = 1)]
				public virtual global::Java.Nio.FloatBuffer Get(float[] dst, int dstOffset, int floatCount) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.FloatBuffer);
				}

				/// <summary>
				/// <para>Returns a float at the specified index; the position is not changed.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a float at the specified index. </para>
				/// </returns>
				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(I)F", AccessFlags = 1025)]
				public abstract float Get(int index) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns true if <c> array </c> and <c> arrayOffset </c> won't throw. This method does not return true for buffers not backed by arrays because the other methods would throw <c> UnsupportedOperationException </c> , nor does it return true for buffers backed by read-only arrays, because the other methods would throw <c> ReadOnlyBufferException </c> . <para>1.6 </para></para>        
				/// </summary>
				/// <java-name>
				/// hasArray
				/// </java-name>
				[Dot42.DexImport("hasArray", "()Z", AccessFlags = 17)]
				public override bool HasArray() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Calculates this buffer's hash code from the remaining chars. The position, limit, capacity and mark don't affect the hash code.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the hash code calculated from the remaining floats. </para>
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
				/// <para>Indicates whether this buffer is direct. A direct buffer will try its best to take advantage of native memory APIs and it may not stay in the Java heap, so it is not affected by garbage collection. </para><para>A float buffer is direct if it is based on a byte buffer and the byte buffer is direct.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if this buffer is direct, <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isDirect
				/// </java-name>
				[Dot42.DexImport("isDirect", "()Z", AccessFlags = 1025)]
				public override bool IsDirect() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns the byte order used by this buffer when converting floats from/to bytes. </para><para>If this buffer is not based on a byte buffer, then always return the platform's native byte order.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the byte order used by this buffer when converting floats from/to bytes. </para>
				/// </returns>
				/// <java-name>
				/// order
				/// </java-name>
				[Dot42.DexImport("order", "()Ljava/nio/ByteOrder;", AccessFlags = 1025)]
				public abstract global::Java.Nio.ByteOrder Order() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Writes all the remaining floats of the <c> src </c> float buffer to this buffer's current position, and increases both buffers' position by the number of floats copied.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>this buffer. </para>
				/// </returns>
				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "(F)Ljava/nio/FloatBuffer;", AccessFlags = 1025)]
				public abstract global::Java.Nio.FloatBuffer Put(float src) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Writes all the remaining floats of the <c> src </c> float buffer to this buffer's current position, and increases both buffers' position by the number of floats copied.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>this buffer. </para>
				/// </returns>
				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "([F)Ljava/nio/FloatBuffer;", AccessFlags = 17)]
				public global::Java.Nio.FloatBuffer Put(float[] src) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.FloatBuffer);
				}

				/// <summary>
				/// <para>Writes floats from the given float array, starting from the specified offset, to the current position and increases the position by the number of floats written.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>this buffer. </para>
				/// </returns>
				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "([FII)Ljava/nio/FloatBuffer;", AccessFlags = 1)]
				public virtual global::Java.Nio.FloatBuffer Put(float[] src, int srcOffset, int floatCount) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.FloatBuffer);
				}

				/// <summary>
				/// <para>Writes all the remaining floats of the <c> src </c> float buffer to this buffer's current position, and increases both buffers' position by the number of floats copied.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>this buffer. </para>
				/// </returns>
				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "(Ljava/nio/FloatBuffer;)Ljava/nio/FloatBuffer;", AccessFlags = 1)]
				public virtual global::Java.Nio.FloatBuffer Put(global::Java.Nio.FloatBuffer src) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.FloatBuffer);
				}

				/// <summary>
				/// <para>Writes a float to the specified index of this buffer; the position is not changed.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>this buffer. </para>
				/// </returns>
				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "(IF)Ljava/nio/FloatBuffer;", AccessFlags = 1025)]
				public abstract global::Java.Nio.FloatBuffer Put(int index, float f) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns a sliced buffer that shares its content with this buffer. </para><para>The sliced buffer's capacity will be this buffer's <c> remaining() </c> , and its zero position will correspond to this buffer's current position. The new buffer's position will be 0, limit will be its capacity, and its mark is cleared. The new buffer's read-only property and byte order are same as this buffer's. </para><para>The new buffer shares its content with this buffer, which means either buffer's change of content will be visible to the other. The two buffer's position, limit and mark are independent.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a sliced buffer that shares its content with this buffer. </para>
				/// </returns>
				/// <java-name>
				/// slice
				/// </java-name>
				[Dot42.DexImport("slice", "()Ljava/nio/FloatBuffer;", AccessFlags = 1025)]
				public abstract global::Java.Nio.FloatBuffer Slice() /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>A buffer of longs. </para><para>A long buffer can be created in either of the following ways: <ul><li><para>Allocate a new long array and create a buffer based on it; </para></li><li><para>Wrap an existing long array to create a new buffer; </para></li><li><para>Use ByteBuffer.asLongBuffer to create a long buffer based on a byte buffer. </para></li></ul></para>    
		/// </summary>
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

				/// <summary>
				/// <para>Creates a long buffer based on a newly allocated long array.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the created long buffer. </para>
				/// </returns>
				/// <java-name>
				/// allocate
				/// </java-name>
				[Dot42.DexImport("allocate", "(I)Ljava/nio/LongBuffer;", AccessFlags = 9)]
				public static global::Java.Nio.LongBuffer Allocate(int capacity) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.LongBuffer);
				}

				/// <summary>
				/// <para>Creates a new long buffer by wrapping the given long array. </para><para>Calling this method has the same effect as <c> wrap(array, 0, array.length) </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the created long buffer. </para>
				/// </returns>
				/// <java-name>
				/// wrap
				/// </java-name>
				[Dot42.DexImport("wrap", "([J)Ljava/nio/LongBuffer;", AccessFlags = 9)]
				public static global::Java.Nio.LongBuffer Wrap(long[] array) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.LongBuffer);
				}

				/// <summary>
				/// <para>Creates a new long buffer by wrapping the given long array. </para><para>The new buffer's position will be <c> start </c> , limit will be <c> start + longCount </c> , capacity will be the length of the array.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the created long buffer. </para>
				/// </returns>
				/// <java-name>
				/// wrap
				/// </java-name>
				[Dot42.DexImport("wrap", "([JII)Ljava/nio/LongBuffer;", AccessFlags = 9)]
				public static global::Java.Nio.LongBuffer Wrap(long[] array, int start, int longCount) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.LongBuffer);
				}

				/// <summary>
				/// <para>Returns the array that backs this buffer (optional operation). The returned value is the actual array, not a copy, so modifications to the array write through to the buffer.</para><para>Subclasses should override this method with a covariant return type to provide the exact type of the array.</para><para>Use <c> hasArray </c> to ensure this method won't throw. (A separate call to <c> isReadOnly </c> is not necessary.)</para><para><para>1.6 </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the array </para>
				/// </returns>
				/// <java-name>
				/// array
				/// </java-name>
				[Dot42.DexImport("array", "()[J", AccessFlags = 17)]
				public override object Array() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <summary>
				/// <para>Returns the offset into the array returned by <c> array </c> of the first element of the buffer (optional operation). The backing array (if there is one) is not necessarily the same size as the buffer, and position 0 in the buffer is not necessarily the 0th element in the array. Use <c> buffer.array()[offset + buffer.arrayOffset() </c> to access element <c> offset </c> in <c> buffer </c> .</para><para>Use <c> hasArray </c> to ensure this method won't throw. (A separate call to <c> isReadOnly </c> is not necessary.)</para><para><para>1.6 </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the offset </para>
				/// </returns>
				/// <java-name>
				/// arrayOffset
				/// </java-name>
				[Dot42.DexImport("arrayOffset", "()I", AccessFlags = 17)]
				public override int ArrayOffset() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns a read-only buffer that shares its content with this buffer. </para><para>The returned buffer is guaranteed to be a new instance, even if this buffer is read-only itself. The new buffer's position, limit, capacity and mark are the same as this buffer's. </para><para>The new buffer shares its content with this buffer, which means this buffer's change of content will be visible to the new buffer. The two buffer's position, limit and mark are independent.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a read-only version of this buffer. </para>
				/// </returns>
				/// <java-name>
				/// asReadOnlyBuffer
				/// </java-name>
				[Dot42.DexImport("asReadOnlyBuffer", "()Ljava/nio/LongBuffer;", AccessFlags = 1025)]
				public abstract global::Java.Nio.LongBuffer AsReadOnlyBuffer() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Compacts this long buffer. </para><para>The remaining longs will be moved to the head of the buffer, staring from position zero. Then the position is set to <c> remaining() </c> ; the limit is set to capacity; the mark is cleared.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>this buffer. </para>
				/// </returns>
				/// <java-name>
				/// compact
				/// </java-name>
				[Dot42.DexImport("compact", "()Ljava/nio/LongBuffer;", AccessFlags = 1025)]
				public abstract global::Java.Nio.LongBuffer Compact() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Compare the remaining longs of this buffer to another long buffer's remaining longs.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a negative value if this is less than <c> otherBuffer </c> ; 0 if this equals to <c> otherBuffer </c> ; a positive value if this is greater than <c> otherBuffer </c> </para>
				/// </returns>
				/// <java-name>
				/// compareTo
				/// </java-name>
				[Dot42.DexImport("compareTo", "(Ljava/nio/LongBuffer;)I", AccessFlags = 1)]
				public virtual int CompareTo(global::Java.Nio.LongBuffer otherBuffer) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns a duplicated buffer that shares its content with this buffer. </para><para>The duplicated buffer's position, limit, capacity and mark are the same as this buffer. The duplicated buffer's read-only property and byte order are same as this buffer's, too. </para><para>The new buffer shares its content with this buffer, which means either buffer's change of content will be visible to the other. The two buffer's position, limit and mark are independent.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a duplicated buffer that shares its content with this buffer. </para>
				/// </returns>
				/// <java-name>
				/// duplicate
				/// </java-name>
				[Dot42.DexImport("duplicate", "()Ljava/nio/LongBuffer;", AccessFlags = 1025)]
				public abstract global::Java.Nio.LongBuffer Duplicate() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Checks whether this long buffer is equal to another object. </para><para>If <c> other </c> is not a long buffer then <c> false </c> is returned. Two long buffers are equal if and only if their remaining longs are exactly the same. Position, limit, capacity and mark are not considered.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if this long buffer is equal to <c> other </c> , <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object other) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns the long at the current position and increase the position by 1.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the long at the current position. </para>
				/// </returns>
				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "()J", AccessFlags = 1025)]
				public abstract long Get() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the long at the specified index; the position is not changed.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the long at the specified index. </para>
				/// </returns>
				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "([J)Ljava/nio/LongBuffer;", AccessFlags = 1)]
				public virtual global::Java.Nio.LongBuffer Get(long[] index) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.LongBuffer);
				}

				/// <summary>
				/// <para>Reads longs from the current position into the specified long array, starting from the specified offset, and increase the position by the number of longs read.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>this buffer. </para>
				/// </returns>
				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "([JII)Ljava/nio/LongBuffer;", AccessFlags = 1)]
				public virtual global::Java.Nio.LongBuffer Get(long[] dst, int dstOffset, int longCount) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.LongBuffer);
				}

				/// <summary>
				/// <para>Returns the long at the specified index; the position is not changed.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the long at the specified index. </para>
				/// </returns>
				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(I)J", AccessFlags = 1025)]
				public abstract long Get(int index) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns true if <c> array </c> and <c> arrayOffset </c> won't throw. This method does not return true for buffers not backed by arrays because the other methods would throw <c> UnsupportedOperationException </c> , nor does it return true for buffers backed by read-only arrays, because the other methods would throw <c> ReadOnlyBufferException </c> . <para>1.6 </para></para>        
				/// </summary>
				/// <java-name>
				/// hasArray
				/// </java-name>
				[Dot42.DexImport("hasArray", "()Z", AccessFlags = 17)]
				public override bool HasArray() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Calculates this buffer's hash code from the remaining chars. The position, limit, capacity and mark don't affect the hash code.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the hash code calculated from the remaining longs. </para>
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
				/// <para>Indicates whether this buffer is direct. A direct buffer will try its best to take advantage of native memory APIs and it may not stay in the Java heap, so it is not affected by garbage collection. </para><para>A long buffer is direct if it is based on a byte buffer and the byte buffer is direct.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if this buffer is direct, <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isDirect
				/// </java-name>
				[Dot42.DexImport("isDirect", "()Z", AccessFlags = 1025)]
				public override bool IsDirect() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns the byte order used by this buffer when converting longs from/to bytes. </para><para>If this buffer is not based on a byte buffer, then always return the platform's native byte order.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the byte order used by this buffer when converting longs from/to bytes. </para>
				/// </returns>
				/// <java-name>
				/// order
				/// </java-name>
				[Dot42.DexImport("order", "()Ljava/nio/ByteOrder;", AccessFlags = 1025)]
				public abstract global::Java.Nio.ByteOrder Order() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Writes all the remaining longs of the <c> src </c> long buffer to this buffer's current position, and increases both buffers' position by the number of longs copied.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>this buffer. </para>
				/// </returns>
				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "(J)Ljava/nio/LongBuffer;", AccessFlags = 1025)]
				public abstract global::Java.Nio.LongBuffer Put(long src) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Writes all the remaining longs of the <c> src </c> long buffer to this buffer's current position, and increases both buffers' position by the number of longs copied.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>this buffer. </para>
				/// </returns>
				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "([J)Ljava/nio/LongBuffer;", AccessFlags = 17)]
				public global::Java.Nio.LongBuffer Put(long[] src) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.LongBuffer);
				}

				/// <summary>
				/// <para>Writes longs from the given long array, starting from the specified offset, to the current position and increases the position by the number of longs written.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>this buffer. </para>
				/// </returns>
				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "([JII)Ljava/nio/LongBuffer;", AccessFlags = 1)]
				public virtual global::Java.Nio.LongBuffer Put(long[] src, int srcOffset, int longCount) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.LongBuffer);
				}

				/// <summary>
				/// <para>Writes all the remaining longs of the <c> src </c> long buffer to this buffer's current position, and increases both buffers' position by the number of longs copied.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>this buffer. </para>
				/// </returns>
				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "(Ljava/nio/LongBuffer;)Ljava/nio/LongBuffer;", AccessFlags = 1)]
				public virtual global::Java.Nio.LongBuffer Put(global::Java.Nio.LongBuffer src) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.LongBuffer);
				}

				/// <summary>
				/// <para>Writes a long to the specified index of this buffer; the position is not changed.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>this buffer. </para>
				/// </returns>
				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "(IJ)Ljava/nio/LongBuffer;", AccessFlags = 1025)]
				public abstract global::Java.Nio.LongBuffer Put(int index, long l) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns a sliced buffer that shares its content with this buffer. </para><para>The sliced buffer's capacity will be this buffer's <c> remaining() </c> , and its zero position will correspond to this buffer's current position. The new buffer's position will be 0, limit will be its capacity, and its mark is cleared. The new buffer's read-only property and byte order are same as this buffer's. </para><para>The new buffer shares its content with this buffer, which means either buffer's change of content will be visible to the other. The two buffer's position, limit and mark are independent.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a sliced buffer that shares its content with this buffer. </para>
				/// </returns>
				/// <java-name>
				/// slice
				/// </java-name>
				[Dot42.DexImport("slice", "()Ljava/nio/LongBuffer;", AccessFlags = 1025)]
				public abstract global::Java.Nio.LongBuffer Slice() /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>A buffer of shorts. </para><para>A short buffer can be created in either of the following ways: <ul><li><para>Allocate a new short array and create a buffer based on it; </para></li><li><para>Wrap an existing short array to create a new buffer; </para></li><li><para>Use ByteBuffer.asShortBuffer to create a short buffer based on a byte buffer. </para></li></ul></para>    
		/// </summary>
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

				/// <summary>
				/// <para>Creates a short buffer based on a newly allocated short array.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the created short buffer. </para>
				/// </returns>
				/// <java-name>
				/// allocate
				/// </java-name>
				[Dot42.DexImport("allocate", "(I)Ljava/nio/ShortBuffer;", AccessFlags = 9)]
				public static global::Java.Nio.ShortBuffer Allocate(int capacity) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.ShortBuffer);
				}

				/// <summary>
				/// <para>Creates a new short buffer by wrapping the given short array. </para><para>Calling this method has the same effect as <c> wrap(array, 0, array.length) </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the created short buffer. </para>
				/// </returns>
				/// <java-name>
				/// wrap
				/// </java-name>
				[Dot42.DexImport("wrap", "([S)Ljava/nio/ShortBuffer;", AccessFlags = 9)]
				public static global::Java.Nio.ShortBuffer Wrap(short[] array) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.ShortBuffer);
				}

				/// <summary>
				/// <para>Creates a new short buffer by wrapping the given short array. </para><para>The new buffer's position will be <c> start </c> , limit will be <c> start + shortCount </c> , capacity will be the length of the array.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the created short buffer. </para>
				/// </returns>
				/// <java-name>
				/// wrap
				/// </java-name>
				[Dot42.DexImport("wrap", "([SII)Ljava/nio/ShortBuffer;", AccessFlags = 9)]
				public static global::Java.Nio.ShortBuffer Wrap(short[] array, int start, int shortCount) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.ShortBuffer);
				}

				/// <summary>
				/// <para>Returns the array that backs this buffer (optional operation). The returned value is the actual array, not a copy, so modifications to the array write through to the buffer.</para><para>Subclasses should override this method with a covariant return type to provide the exact type of the array.</para><para>Use <c> hasArray </c> to ensure this method won't throw. (A separate call to <c> isReadOnly </c> is not necessary.)</para><para><para>1.6 </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the array </para>
				/// </returns>
				/// <java-name>
				/// array
				/// </java-name>
				[Dot42.DexImport("array", "()[S", AccessFlags = 17)]
				public override object Array() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <summary>
				/// <para>Returns the offset into the array returned by <c> array </c> of the first element of the buffer (optional operation). The backing array (if there is one) is not necessarily the same size as the buffer, and position 0 in the buffer is not necessarily the 0th element in the array. Use <c> buffer.array()[offset + buffer.arrayOffset() </c> to access element <c> offset </c> in <c> buffer </c> .</para><para>Use <c> hasArray </c> to ensure this method won't throw. (A separate call to <c> isReadOnly </c> is not necessary.)</para><para><para>1.6 </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the offset </para>
				/// </returns>
				/// <java-name>
				/// arrayOffset
				/// </java-name>
				[Dot42.DexImport("arrayOffset", "()I", AccessFlags = 17)]
				public override int ArrayOffset() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns a read-only buffer that shares its content with this buffer. </para><para>The returned buffer is guaranteed to be a new instance, even if this buffer is read-only itself. The new buffer's position, limit, capacity and mark are the same as this buffer's. </para><para>The new buffer shares its content with this buffer, which means this buffer's change of content will be visible to the new buffer. The two buffer's position, limit and mark are independent.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a read-only version of this buffer. </para>
				/// </returns>
				/// <java-name>
				/// asReadOnlyBuffer
				/// </java-name>
				[Dot42.DexImport("asReadOnlyBuffer", "()Ljava/nio/ShortBuffer;", AccessFlags = 1025)]
				public abstract global::Java.Nio.ShortBuffer AsReadOnlyBuffer() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Compacts this short buffer. </para><para>The remaining shorts will be moved to the head of the buffer, starting from position zero. Then the position is set to <c> remaining() </c> ; the limit is set to capacity; the mark is cleared.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>this buffer. </para>
				/// </returns>
				/// <java-name>
				/// compact
				/// </java-name>
				[Dot42.DexImport("compact", "()Ljava/nio/ShortBuffer;", AccessFlags = 1025)]
				public abstract global::Java.Nio.ShortBuffer Compact() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Compare the remaining shorts of this buffer to another short buffer's remaining shorts.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a negative value if this is less than <c> otherBuffer </c> ; 0 if this equals to <c> otherBuffer </c> ; a positive value if this is greater than <c> otherBuffer </c> . </para>
				/// </returns>
				/// <java-name>
				/// compareTo
				/// </java-name>
				[Dot42.DexImport("compareTo", "(Ljava/nio/ShortBuffer;)I", AccessFlags = 1)]
				public virtual int CompareTo(global::Java.Nio.ShortBuffer otherBuffer) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns a duplicated buffer that shares its content with this buffer. </para><para>The duplicated buffer's position, limit, capacity and mark are the same as this buffer. The duplicated buffer's read-only property and byte order are the same as this buffer's. </para><para>The new buffer shares its content with this buffer, which means either buffer's change of content will be visible to the other. The two buffer's position, limit and mark are independent.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a duplicated buffer that shares its content with this buffer. </para>
				/// </returns>
				/// <java-name>
				/// duplicate
				/// </java-name>
				[Dot42.DexImport("duplicate", "()Ljava/nio/ShortBuffer;", AccessFlags = 1025)]
				public abstract global::Java.Nio.ShortBuffer Duplicate() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Checks whether this short buffer is equal to another object. </para><para>If <c> other </c> is not a short buffer then <c> false </c> is returned. Two short buffers are equal if and only if their remaining shorts are exactly the same. Position, limit, capacity and mark are not considered.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if this short buffer is equal to <c> other </c> , <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object other) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns the short at the current position and increases the position by 1.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the short at the current position. </para>
				/// </returns>
				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "()S", AccessFlags = 1025)]
				public abstract short Get() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the short at the specified index; the position is not changed.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a short at the specified index. </para>
				/// </returns>
				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "([S)Ljava/nio/ShortBuffer;", AccessFlags = 1)]
				public virtual global::Java.Nio.ShortBuffer Get(short[] index) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.ShortBuffer);
				}

				/// <summary>
				/// <para>Reads shorts from the current position into the specified short array, starting from the specified offset, and increases the position by the number of shorts read.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>this buffer. </para>
				/// </returns>
				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "([SII)Ljava/nio/ShortBuffer;", AccessFlags = 1)]
				public virtual global::Java.Nio.ShortBuffer Get(short[] dst, int dstOffset, int shortCount) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.ShortBuffer);
				}

				/// <summary>
				/// <para>Returns the short at the specified index; the position is not changed.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a short at the specified index. </para>
				/// </returns>
				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(I)S", AccessFlags = 1025)]
				public abstract short Get(int index) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns true if <c> array </c> and <c> arrayOffset </c> won't throw. This method does not return true for buffers not backed by arrays because the other methods would throw <c> UnsupportedOperationException </c> , nor does it return true for buffers backed by read-only arrays, because the other methods would throw <c> ReadOnlyBufferException </c> . <para>1.6 </para></para>        
				/// </summary>
				/// <java-name>
				/// hasArray
				/// </java-name>
				[Dot42.DexImport("hasArray", "()Z", AccessFlags = 17)]
				public override bool HasArray() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Calculates this buffer's hash code from the remaining chars. The position, limit, capacity and mark don't affect the hash code.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the hash code calculated from the remaining shorts. </para>
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
				/// <para>Indicates whether this buffer is direct. A direct buffer will try its best to take advantage of native memory APIs and it may not stay in the Java heap, so it is not affected by garbage collection. </para><para>A short buffer is direct if it is based on a byte buffer and the byte buffer is direct.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if this buffer is direct, <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isDirect
				/// </java-name>
				[Dot42.DexImport("isDirect", "()Z", AccessFlags = 1025)]
				public override bool IsDirect() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns the byte order used by this buffer when converting shorts from/to bytes. </para><para>If this buffer is not based on a byte buffer, then always return the platform's native byte order.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the byte order used by this buffer when converting shorts from/to bytes. </para>
				/// </returns>
				/// <java-name>
				/// order
				/// </java-name>
				[Dot42.DexImport("order", "()Ljava/nio/ByteOrder;", AccessFlags = 1025)]
				public abstract global::Java.Nio.ByteOrder Order() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Writes all the remaining shorts of the <c> src </c> short buffer to this buffer's current position, and increases both buffers' position by the number of shorts copied.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>this buffer. </para>
				/// </returns>
				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "(S)Ljava/nio/ShortBuffer;", AccessFlags = 1025)]
				public abstract global::Java.Nio.ShortBuffer Put(short src) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Writes all the remaining shorts of the <c> src </c> short buffer to this buffer's current position, and increases both buffers' position by the number of shorts copied.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>this buffer. </para>
				/// </returns>
				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "([S)Ljava/nio/ShortBuffer;", AccessFlags = 17)]
				public global::Java.Nio.ShortBuffer Put(short[] src) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.ShortBuffer);
				}

				/// <summary>
				/// <para>Writes shorts from the given short array, starting from the specified offset, to the current position and increases the position by the number of shorts written.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>this buffer. </para>
				/// </returns>
				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "([SII)Ljava/nio/ShortBuffer;", AccessFlags = 1)]
				public virtual global::Java.Nio.ShortBuffer Put(short[] src, int srcOffset, int shortCount) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.ShortBuffer);
				}

				/// <summary>
				/// <para>Writes all the remaining shorts of the <c> src </c> short buffer to this buffer's current position, and increases both buffers' position by the number of shorts copied.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>this buffer. </para>
				/// </returns>
				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "(Ljava/nio/ShortBuffer;)Ljava/nio/ShortBuffer;", AccessFlags = 1)]
				public virtual global::Java.Nio.ShortBuffer Put(global::Java.Nio.ShortBuffer src) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.ShortBuffer);
				}

				/// <summary>
				/// <para>Writes a short to the specified index of this buffer; the position is not changed.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>this buffer. </para>
				/// </returns>
				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "(IS)Ljava/nio/ShortBuffer;", AccessFlags = 1025)]
				public abstract global::Java.Nio.ShortBuffer Put(int index, short s) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns a sliced buffer that shares its content with this buffer. </para><para>The sliced buffer's capacity will be this buffer's <c> remaining() </c> , and its zero position will correspond to this buffer's current position. The new buffer's position will be 0, limit will be its capacity, and its mark is cleared. The new buffer's read-only property and byte order are same as this buffer's. </para><para>The new buffer shares its content with this buffer, which means either buffer's change of content will be visible to the other. The two buffer's position, limit and mark are independent.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a sliced buffer that shares its content with this buffer. </para>
				/// </returns>
				/// <java-name>
				/// slice
				/// </java-name>
				[Dot42.DexImport("slice", "()Ljava/nio/ShortBuffer;", AccessFlags = 1025)]
				public abstract global::Java.Nio.ShortBuffer Slice() /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para><c> MappedByteBuffer </c> is a special kind of direct byte buffer which maps a region of file to memory. </para><para><c> MappedByteBuffer </c> can be created by calling FileChannel.map. Once created, the mapping between the byte buffer and the file region remains valid until the byte buffer is garbage collected. </para><para>All or part of a <c> MappedByteBuffer </c> 's content may change or become inaccessible at any time, since the mapped file region can be modified by another thread or process at any time. If this happens, the behavior of the <c> MappedByteBuffer </c> is undefined. </para>    
		/// </summary>
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

				/// <summary>
				/// <para>Returns true if there is a high probability that every page of this buffer is currently loaded in RAM, meaning that accesses will not cause a page fault. It is impossible to give a strong guarantee since this is only a snapshot of a dynamic situation. </para>        
				/// </summary>
				/// <java-name>
				/// isLoaded
				/// </java-name>
				[Dot42.DexImport("isLoaded", "()Z", AccessFlags = 17)]
				public bool IsLoaded() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Attempts to load every page of this buffer into RAM. See isLoaded. </para>        
				/// </summary>
				/// <returns>
				/// <para>this buffer. </para>
				/// </returns>
				/// <java-name>
				/// load
				/// </java-name>
				[Dot42.DexImport("load", "()Ljava/nio/MappedByteBuffer;", AccessFlags = 17)]
				public global::Java.Nio.MappedByteBuffer Load() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.MappedByteBuffer);
				}

				/// <summary>
				/// <para>Writes all changes of the buffer to the mapped file. If the mapped file is stored on a local device, it is guaranteed that the changes are written to the file. No such guarantee is given if the file is located on a remote device.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>this buffer. </para>
				/// </returns>
				/// <java-name>
				/// force
				/// </java-name>
				[Dot42.DexImport("force", "()Ljava/nio/MappedByteBuffer;", AccessFlags = 17)]
				public global::Java.Nio.MappedByteBuffer Force() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.MappedByteBuffer);
				}

		}

		/// <summary>
		/// <para>A <code>BufferOverflowException</code> is thrown when elements are written to a buffer but there is not enough remaining space in the buffer. </para>    
		/// </summary>
		/// <java-name>
		/// java/nio/BufferOverflowException
		/// </java-name>
		[Dot42.DexImport("java/nio/BufferOverflowException", AccessFlags = 33)]
		public partial class BufferOverflowException : global::System.SystemException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs a <code>BufferOverflowException</code>. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public BufferOverflowException() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>An <c> InvalidMarkException </c> is thrown when <c> reset() </c> is called on a buffer, but no mark has been set previously. </para>    
		/// </summary>
		/// <java-name>
		/// java/nio/InvalidMarkException
		/// </java-name>
		[Dot42.DexImport("java/nio/InvalidMarkException", AccessFlags = 33)]
		public partial class InvalidMarkException : global::Java.Lang.IllegalStateException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs an <c> InvalidMarkException </c> . </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public InvalidMarkException() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>Defines byte order constants. </para>    
		/// </summary>
		/// <java-name>
		/// java/nio/ByteOrder
		/// </java-name>
		[Dot42.DexImport("java/nio/ByteOrder", AccessFlags = 49)]
		public sealed partial class ByteOrder
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>This constant represents big endian. </para>        
				/// </summary>
				/// <java-name>
				/// BIG_ENDIAN
				/// </java-name>
				[Dot42.DexImport("BIG_ENDIAN", "Ljava/nio/ByteOrder;", AccessFlags = 25)]
				public static readonly global::Java.Nio.ByteOrder BIG_ENDIAN;
				/// <summary>
				/// <para>This constant represents little endian. </para>        
				/// </summary>
				/// <java-name>
				/// LITTLE_ENDIAN
				/// </java-name>
				[Dot42.DexImport("LITTLE_ENDIAN", "Ljava/nio/ByteOrder;", AccessFlags = 25)]
				public static readonly global::Java.Nio.ByteOrder LITTLE_ENDIAN;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal ByteOrder() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the current platform byte order.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the byte order object, which is either LITTLE_ENDIAN or BIG_ENDIAN. </para>
				/// </returns>
				/// <java-name>
				/// nativeOrder
				/// </java-name>
				[Dot42.DexImport("nativeOrder", "()Ljava/nio/ByteOrder;", AccessFlags = 9)]
				public static global::Java.Nio.ByteOrder NativeOrder() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.ByteOrder);
				}

				/// <summary>
				/// <para>Returns a string that describes this object.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>"BIG_ENDIAN" for ByteOrder.BIG_ENDIAN objects, "LITTLE_ENDIAN" for ByteOrder.LITTLE_ENDIAN objects. </para>
				/// </returns>
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
		/// <para>A buffer for bytes. </para><para>A byte buffer can be created in either one of the following ways: <ul><li><para>Allocate a new byte array and create a buffer based on it; </para></li><li><para>Allocate a memory block and create a direct buffer based on it; </para></li><li><para>Wrap an existing byte array to create a new buffer. </para></li></ul></para>    
		/// </summary>
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

				/// <summary>
				/// <para>Creates a byte buffer based on a newly allocated byte array.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the created byte buffer. </para>
				/// </returns>
				/// <java-name>
				/// allocate
				/// </java-name>
				[Dot42.DexImport("allocate", "(I)Ljava/nio/ByteBuffer;", AccessFlags = 9)]
				public static global::Java.Nio.ByteBuffer Allocate(int capacity) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.ByteBuffer);
				}

				/// <summary>
				/// <para>Creates a direct byte buffer based on a newly allocated memory block.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the created byte buffer. </para>
				/// </returns>
				/// <java-name>
				/// allocateDirect
				/// </java-name>
				[Dot42.DexImport("allocateDirect", "(I)Ljava/nio/ByteBuffer;", AccessFlags = 9)]
				public static global::Java.Nio.ByteBuffer AllocateDirect(int capacity) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.ByteBuffer);
				}

				/// <summary>
				/// <para>Creates a new byte buffer by wrapping the given byte array. </para><para>Calling this method has the same effect as <c> wrap(array, 0, array.length) </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the created byte buffer. </para>
				/// </returns>
				/// <java-name>
				/// wrap
				/// </java-name>
				[Dot42.DexImport("wrap", "([B)Ljava/nio/ByteBuffer;", AccessFlags = 9)]
				public static global::Java.Nio.ByteBuffer Wrap(sbyte[] array) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.ByteBuffer);
				}

				/// <summary>
				/// <para>Creates a new byte buffer by wrapping the given byte array. </para><para>Calling this method has the same effect as <c> wrap(array, 0, array.length) </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the created byte buffer. </para>
				/// </returns>
				/// <java-name>
				/// wrap
				/// </java-name>
				[Dot42.DexImport("wrap", "([B)Ljava/nio/ByteBuffer;", AccessFlags = 9, IgnoreFromJava = true)]
				public static global::Java.Nio.ByteBuffer Wrap(byte[] array) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.ByteBuffer);
				}

				/// <summary>
				/// <para>Creates a new byte buffer by wrapping the given byte array. </para><para>The new buffer's position will be <c> start </c> , limit will be <c> start + byteCount </c> , capacity will be the length of the array.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the created byte buffer. </para>
				/// </returns>
				/// <java-name>
				/// wrap
				/// </java-name>
				[Dot42.DexImport("wrap", "([BII)Ljava/nio/ByteBuffer;", AccessFlags = 9)]
				public static global::Java.Nio.ByteBuffer Wrap(sbyte[] array, int start, int byteCount) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.ByteBuffer);
				}

				/// <summary>
				/// <para>Creates a new byte buffer by wrapping the given byte array. </para><para>The new buffer's position will be <c> start </c> , limit will be <c> start + byteCount </c> , capacity will be the length of the array.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the created byte buffer. </para>
				/// </returns>
				/// <java-name>
				/// wrap
				/// </java-name>
				[Dot42.DexImport("wrap", "([BII)Ljava/nio/ByteBuffer;", AccessFlags = 9, IgnoreFromJava = true)]
				public static global::Java.Nio.ByteBuffer Wrap(byte[] array, int start, int byteCount) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.ByteBuffer);
				}

				/// <summary>
				/// <para>Returns the byte array which this buffer is based on, if there is one.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the byte array which this buffer is based on. </para>
				/// </returns>
				/// <java-name>
				/// array
				/// </java-name>
				[Dot42.DexImport("array", "()[B", AccessFlags = 17)]
				public override object Array() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <summary>
				/// <para>Returns the offset of the byte array which this buffer is based on, if there is one. </para><para>The offset is the index of the array which corresponds to the zero position of the buffer.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the offset of the byte array which this buffer is based on. </para>
				/// </returns>
				/// <java-name>
				/// arrayOffset
				/// </java-name>
				[Dot42.DexImport("arrayOffset", "()I", AccessFlags = 17)]
				public override int ArrayOffset() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns a char buffer which is based on the remaining content of this byte buffer. </para><para>The new buffer's position is zero, its limit and capacity is the number of remaining bytes divided by two, and its mark is not set. The new buffer's read-only property and byte order are the same as this buffer's. The new buffer is direct if this byte buffer is direct. </para><para>The new buffer shares its content with this buffer, which means either buffer's change of content will be visible to the other. The two buffer's position, limit and mark are independent.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a char buffer which is based on the content of this byte buffer. </para>
				/// </returns>
				/// <java-name>
				/// asCharBuffer
				/// </java-name>
				[Dot42.DexImport("asCharBuffer", "()Ljava/nio/CharBuffer;", AccessFlags = 1025)]
				public abstract global::Java.Nio.CharBuffer AsCharBuffer() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns a double buffer which is based on the remaining content of this byte buffer. </para><para>The new buffer's position is zero, its limit and capacity is the number of remaining bytes divided by eight, and its mark is not set. The new buffer's read-only property and byte order are the same as this buffer's. The new buffer is direct if this byte buffer is direct. </para><para>The new buffer shares its content with this buffer, which means either buffer's change of content will be visible to the other. The two buffer's position, limit and mark are independent.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a double buffer which is based on the content of this byte buffer. </para>
				/// </returns>
				/// <java-name>
				/// asDoubleBuffer
				/// </java-name>
				[Dot42.DexImport("asDoubleBuffer", "()Ljava/nio/DoubleBuffer;", AccessFlags = 1025)]
				public abstract global::Java.Nio.DoubleBuffer AsDoubleBuffer() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns a float buffer which is based on the remaining content of this byte buffer. </para><para>The new buffer's position is zero, its limit and capacity is the number of remaining bytes divided by four, and its mark is not set. The new buffer's read-only property and byte order are the same as this buffer's. The new buffer is direct if this byte buffer is direct. </para><para>The new buffer shares its content with this buffer, which means either buffer's change of content will be visible to the other. The two buffer's position, limit and mark are independent.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a float buffer which is based on the content of this byte buffer. </para>
				/// </returns>
				/// <java-name>
				/// asFloatBuffer
				/// </java-name>
				[Dot42.DexImport("asFloatBuffer", "()Ljava/nio/FloatBuffer;", AccessFlags = 1025)]
				public abstract global::Java.Nio.FloatBuffer AsFloatBuffer() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns a int buffer which is based on the remaining content of this byte buffer. </para><para>The new buffer's position is zero, its limit and capacity is the number of remaining bytes divided by four, and its mark is not set. The new buffer's read-only property and byte order are the same as this buffer's. The new buffer is direct if this byte buffer is direct. </para><para>The new buffer shares its content with this buffer, which means either buffer's change of content will be visible to the other. The two buffer's position, limit and mark are independent.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a int buffer which is based on the content of this byte buffer. </para>
				/// </returns>
				/// <java-name>
				/// asIntBuffer
				/// </java-name>
				[Dot42.DexImport("asIntBuffer", "()Ljava/nio/IntBuffer;", AccessFlags = 1025)]
				public abstract global::Java.Nio.IntBuffer AsIntBuffer() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns a long buffer which is based on the remaining content of this byte buffer. </para><para>The new buffer's position is zero, its limit and capacity is the number of remaining bytes divided by eight, and its mark is not set. The new buffer's read-only property and byte order are the same as this buffer's. The new buffer is direct if this byte buffer is direct. </para><para>The new buffer shares its content with this buffer, which means either buffer's change of content will be visible to the other. The two buffer's position, limit and mark are independent.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a long buffer which is based on the content of this byte buffer. </para>
				/// </returns>
				/// <java-name>
				/// asLongBuffer
				/// </java-name>
				[Dot42.DexImport("asLongBuffer", "()Ljava/nio/LongBuffer;", AccessFlags = 1025)]
				public abstract global::Java.Nio.LongBuffer AsLongBuffer() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns a read-only buffer that shares its content with this buffer. </para><para>The returned buffer is guaranteed to be a new instance, even if this buffer is read-only itself. The new buffer's position, limit, capacity and mark are the same as this buffer. </para><para>The new buffer shares its content with this buffer, which means this buffer's change of content will be visible to the new buffer. The two buffer's position, limit and mark are independent.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a read-only version of this buffer. </para>
				/// </returns>
				/// <java-name>
				/// asReadOnlyBuffer
				/// </java-name>
				[Dot42.DexImport("asReadOnlyBuffer", "()Ljava/nio/ByteBuffer;", AccessFlags = 1025)]
				public abstract global::Java.Nio.ByteBuffer AsReadOnlyBuffer() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns a short buffer which is based on the remaining content of this byte buffer. </para><para>The new buffer's position is zero, its limit and capacity is the number of remaining bytes divided by two, and its mark is not set. The new buffer's read-only property and byte order are the same as this buffer's. The new buffer is direct if this byte buffer is direct. </para><para>The new buffer shares its content with this buffer, which means either buffer's change of content will be visible to the other. The two buffer's position, limit and mark are independent.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a short buffer which is based on the content of this byte buffer. </para>
				/// </returns>
				/// <java-name>
				/// asShortBuffer
				/// </java-name>
				[Dot42.DexImport("asShortBuffer", "()Ljava/nio/ShortBuffer;", AccessFlags = 1025)]
				public abstract global::Java.Nio.ShortBuffer AsShortBuffer() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Compacts this byte buffer. </para><para>The remaining bytes will be moved to the head of the buffer, starting from position zero. Then the position is set to <c> remaining() </c> ; the limit is set to capacity; the mark is cleared.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> this </c> </para>
				/// </returns>
				/// <java-name>
				/// compact
				/// </java-name>
				[Dot42.DexImport("compact", "()Ljava/nio/ByteBuffer;", AccessFlags = 1025)]
				public abstract global::Java.Nio.ByteBuffer Compact() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Compares the remaining bytes of this buffer to another byte buffer's remaining bytes.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a negative value if this is less than <c> other </c> ; 0 if this equals to <c> other </c> ; a positive value if this is greater than <c> other </c> . </para>
				/// </returns>
				/// <java-name>
				/// compareTo
				/// </java-name>
				[Dot42.DexImport("compareTo", "(Ljava/nio/ByteBuffer;)I", AccessFlags = 1)]
				public virtual int CompareTo(global::Java.Nio.ByteBuffer otherBuffer) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns a duplicated buffer that shares its content with this buffer. </para><para>The duplicated buffer's position, limit, capacity and mark are the same as this buffer's. The duplicated buffer's read-only property and byte order are the same as this buffer's too. </para><para>The new buffer shares its content with this buffer, which means either buffer's change of content will be visible to the other. The two buffer's position, limit and mark are independent.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a duplicated buffer that shares its content with this buffer. </para>
				/// </returns>
				/// <java-name>
				/// duplicate
				/// </java-name>
				[Dot42.DexImport("duplicate", "()Ljava/nio/ByteBuffer;", AccessFlags = 1025)]
				public abstract global::Java.Nio.ByteBuffer Duplicate() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Checks whether this byte buffer is equal to another object. </para><para>If <c> other </c> is not a byte buffer then <c> false </c> is returned. Two byte buffers are equal if and only if their remaining bytes are exactly the same. Position, limit, capacity and mark are not considered.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if this byte buffer is equal to <c> other </c> , <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object other) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns the byte at the current position and increases the position by 1.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the byte at the current position. </para>
				/// </returns>
				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "()B", AccessFlags = 1025)]
				public abstract sbyte JavaGet() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the byte at the current position and increases the position by 1.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the byte at the current position. </para>
				/// </returns>
				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "()B", AccessFlags = 1025, IgnoreFromJava = true)]
				public abstract byte Get() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the byte at the specified index and does not change the position.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the byte at the specified index. </para>
				/// </returns>
				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "([B)Ljava/nio/ByteBuffer;", AccessFlags = 1)]
				public virtual global::Java.Nio.ByteBuffer Get(sbyte[] index) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.ByteBuffer);
				}

				/// <summary>
				/// <para>Returns the byte at the specified index and does not change the position.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the byte at the specified index. </para>
				/// </returns>
				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "([B)Ljava/nio/ByteBuffer;", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual global::Java.Nio.ByteBuffer Get(byte[] index) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.ByteBuffer);
				}

				/// <summary>
				/// <para>Reads bytes from the current position into the specified byte array, starting at the specified offset, and increases the position by the number of bytes read.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> this </c> </para>
				/// </returns>
				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "([BII)Ljava/nio/ByteBuffer;", AccessFlags = 1)]
				public virtual global::Java.Nio.ByteBuffer Get(sbyte[] dst, int dstOffset, int byteCount) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.ByteBuffer);
				}

				/// <summary>
				/// <para>Reads bytes from the current position into the specified byte array, starting at the specified offset, and increases the position by the number of bytes read.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> this </c> </para>
				/// </returns>
				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "([BII)Ljava/nio/ByteBuffer;", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual global::Java.Nio.ByteBuffer Get(byte[] dst, int dstOffset, int byteCount) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.ByteBuffer);
				}

				/// <summary>
				/// <para>Returns the byte at the specified index and does not change the position.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the byte at the specified index. </para>
				/// </returns>
				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(I)B", AccessFlags = 1025)]
				public abstract sbyte JavaGet(int index) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the byte at the specified index and does not change the position.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the byte at the specified index. </para>
				/// </returns>
				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(I)B", AccessFlags = 1025, IgnoreFromJava = true)]
				public abstract byte Get(int index) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the char at the current position and increases the position by 2. </para><para>The 2 bytes starting at the current position are composed into a char according to the current byte order and returned.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the char at the current position. </para>
				/// </returns>
				/// <java-name>
				/// getChar
				/// </java-name>
				[Dot42.DexImport("getChar", "()C", AccessFlags = 1025)]
				public abstract char GetChar() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the char at the specified index. </para><para>The 2 bytes starting from the specified index are composed into a char according to the current byte order and returned. The position is not changed.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the char at the specified index. </para>
				/// </returns>
				/// <java-name>
				/// getChar
				/// </java-name>
				[Dot42.DexImport("getChar", "(I)C", AccessFlags = 1025)]
				public abstract char GetChar(int index) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the double at the current position and increases the position by 8. </para><para>The 8 bytes starting from the current position are composed into a double according to the current byte order and returned.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the double at the current position. </para>
				/// </returns>
				/// <java-name>
				/// getDouble
				/// </java-name>
				[Dot42.DexImport("getDouble", "()D", AccessFlags = 1025)]
				public abstract double GetDouble() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the double at the specified index. </para><para>The 8 bytes starting at the specified index are composed into a double according to the current byte order and returned. The position is not changed.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the double at the specified index. </para>
				/// </returns>
				/// <java-name>
				/// getDouble
				/// </java-name>
				[Dot42.DexImport("getDouble", "(I)D", AccessFlags = 1025)]
				public abstract double GetDouble(int index) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the float at the current position and increases the position by 4. </para><para>The 4 bytes starting at the current position are composed into a float according to the current byte order and returned.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the float at the current position. </para>
				/// </returns>
				/// <java-name>
				/// getFloat
				/// </java-name>
				[Dot42.DexImport("getFloat", "()F", AccessFlags = 1025)]
				public abstract float GetFloat() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the float at the specified index. </para><para>The 4 bytes starting at the specified index are composed into a float according to the current byte order and returned. The position is not changed.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the float at the specified index. </para>
				/// </returns>
				/// <java-name>
				/// getFloat
				/// </java-name>
				[Dot42.DexImport("getFloat", "(I)F", AccessFlags = 1025)]
				public abstract float GetFloat(int index) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the int at the current position and increases the position by 4. </para><para>The 4 bytes starting at the current position are composed into a int according to the current byte order and returned.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the int at the current position. </para>
				/// </returns>
				/// <java-name>
				/// getInt
				/// </java-name>
				[Dot42.DexImport("getInt", "()I", AccessFlags = 1025)]
				public abstract int GetInt() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the int at the specified index. </para><para>The 4 bytes starting at the specified index are composed into a int according to the current byte order and returned. The position is not changed.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the int at the specified index. </para>
				/// </returns>
				/// <java-name>
				/// getInt
				/// </java-name>
				[Dot42.DexImport("getInt", "(I)I", AccessFlags = 1025)]
				public abstract int GetInt(int index) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the long at the current position and increases the position by 8. </para><para>The 8 bytes starting at the current position are composed into a long according to the current byte order and returned.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the long at the current position. </para>
				/// </returns>
				/// <java-name>
				/// getLong
				/// </java-name>
				[Dot42.DexImport("getLong", "()J", AccessFlags = 1025)]
				public abstract long GetLong() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the long at the specified index. </para><para>The 8 bytes starting at the specified index are composed into a long according to the current byte order and returned. The position is not changed.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the long at the specified index. </para>
				/// </returns>
				/// <java-name>
				/// getLong
				/// </java-name>
				[Dot42.DexImport("getLong", "(I)J", AccessFlags = 1025)]
				public abstract long GetLong(int index) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the short at the current position and increases the position by 2. </para><para>The 2 bytes starting at the current position are composed into a short according to the current byte order and returned.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the short at the current position. </para>
				/// </returns>
				/// <java-name>
				/// getShort
				/// </java-name>
				[Dot42.DexImport("getShort", "()S", AccessFlags = 1025)]
				public abstract short GetShort() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the short at the specified index. </para><para>The 2 bytes starting at the specified index are composed into a short according to the current byte order and returned. The position is not changed.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the short at the specified index. </para>
				/// </returns>
				/// <java-name>
				/// getShort
				/// </java-name>
				[Dot42.DexImport("getShort", "(I)S", AccessFlags = 1025)]
				public abstract short GetShort(int index) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns true if <c> array </c> and <c> arrayOffset </c> won't throw. This method does not return true for buffers not backed by arrays because the other methods would throw <c> UnsupportedOperationException </c> , nor does it return true for buffers backed by read-only arrays, because the other methods would throw <c> ReadOnlyBufferException </c> . <para>1.6 </para></para>        
				/// </summary>
				/// <java-name>
				/// hasArray
				/// </java-name>
				[Dot42.DexImport("hasArray", "()Z", AccessFlags = 17)]
				public override bool HasArray() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Calculates this buffer's hash code from the remaining chars. The position, limit, capacity and mark don't affect the hash code.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the hash code calculated from the remaining bytes. </para>
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
				/// <para>Indicates whether this buffer is direct.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if this buffer is direct, <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isDirect
				/// </java-name>
				[Dot42.DexImport("isDirect", "()Z", AccessFlags = 1025)]
				public override bool IsDirect() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns the byte order used by this buffer when converting bytes from/to other primitive types. </para><para>The default byte order of byte buffer is always BIG_ENDIAN</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the byte order used by this buffer when converting bytes from/to other primitive types. </para>
				/// </returns>
				/// <java-name>
				/// order
				/// </java-name>
				[Dot42.DexImport("order", "()Ljava/nio/ByteOrder;", AccessFlags = 17)]
				public global::Java.Nio.ByteOrder Order() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.ByteOrder);
				}

				/// <summary>
				/// <para>Sets the byte order of this buffer.</para><para><para>ByteOrder </para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> this </c> </para>
				/// </returns>
				/// <java-name>
				/// order
				/// </java-name>
				[Dot42.DexImport("order", "(Ljava/nio/ByteOrder;)Ljava/nio/ByteBuffer;", AccessFlags = 17)]
				public global::Java.Nio.ByteBuffer Order(global::Java.Nio.ByteOrder byteOrder) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.ByteBuffer);
				}

				/// <summary>
				/// <para>Writes all the remaining bytes of the <c> src </c> byte buffer to this buffer's current position, and increases both buffers' position by the number of bytes copied.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> this </c> </para>
				/// </returns>
				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "(B)Ljava/nio/ByteBuffer;", AccessFlags = 1025)]
				public abstract global::Java.Nio.ByteBuffer Put(sbyte src) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Writes all the remaining bytes of the <c> src </c> byte buffer to this buffer's current position, and increases both buffers' position by the number of bytes copied.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> this </c> </para>
				/// </returns>
				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "(B)Ljava/nio/ByteBuffer;", AccessFlags = 1025, IgnoreFromJava = true)]
				public abstract global::Java.Nio.ByteBuffer Put(byte src) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Writes all the remaining bytes of the <c> src </c> byte buffer to this buffer's current position, and increases both buffers' position by the number of bytes copied.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> this </c> </para>
				/// </returns>
				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "([B)Ljava/nio/ByteBuffer;", AccessFlags = 17)]
				public global::Java.Nio.ByteBuffer Put(sbyte[] src) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.ByteBuffer);
				}

				/// <summary>
				/// <para>Writes all the remaining bytes of the <c> src </c> byte buffer to this buffer's current position, and increases both buffers' position by the number of bytes copied.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> this </c> </para>
				/// </returns>
				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "([B)Ljava/nio/ByteBuffer;", AccessFlags = 17, IgnoreFromJava = true)]
				public global::Java.Nio.ByteBuffer Put(byte[] src) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.ByteBuffer);
				}

				/// <summary>
				/// <para>Writes bytes in the given byte array, starting from the specified offset, to the current position and increases the position by the number of bytes written.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> this </c> </para>
				/// </returns>
				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "([BII)Ljava/nio/ByteBuffer;", AccessFlags = 1)]
				public virtual global::Java.Nio.ByteBuffer Put(sbyte[] src, int srcOffset, int byteCount) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.ByteBuffer);
				}

				/// <summary>
				/// <para>Writes bytes in the given byte array, starting from the specified offset, to the current position and increases the position by the number of bytes written.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> this </c> </para>
				/// </returns>
				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "([BII)Ljava/nio/ByteBuffer;", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual global::Java.Nio.ByteBuffer Put(byte[] src, int srcOffset, int byteCount) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.ByteBuffer);
				}

				/// <summary>
				/// <para>Writes all the remaining bytes of the <c> src </c> byte buffer to this buffer's current position, and increases both buffers' position by the number of bytes copied.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> this </c> </para>
				/// </returns>
				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "(Ljava/nio/ByteBuffer;)Ljava/nio/ByteBuffer;", AccessFlags = 1)]
				public virtual global::Java.Nio.ByteBuffer Put(global::Java.Nio.ByteBuffer src) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.ByteBuffer);
				}

				/// <summary>
				/// <para>Write a byte to the specified index of this buffer without changing the position.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> this </c> </para>
				/// </returns>
				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "(IB)Ljava/nio/ByteBuffer;", AccessFlags = 1025)]
				public abstract global::Java.Nio.ByteBuffer Put(int index, sbyte b) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Write a byte to the specified index of this buffer without changing the position.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> this </c> </para>
				/// </returns>
				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "(IB)Ljava/nio/ByteBuffer;", AccessFlags = 1025, IgnoreFromJava = true)]
				public abstract global::Java.Nio.ByteBuffer Put(int index, byte b) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Writes the given char to the current position and increases the position by 2. </para><para>The char is converted to bytes using the current byte order.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> this </c> </para>
				/// </returns>
				/// <java-name>
				/// putChar
				/// </java-name>
				[Dot42.DexImport("putChar", "(C)Ljava/nio/ByteBuffer;", AccessFlags = 1025)]
				public abstract global::Java.Nio.ByteBuffer PutChar(char value) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Writes the given char to the specified index of this buffer. </para><para>The char is converted to bytes using the current byte order. The position is not changed.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> this </c> </para>
				/// </returns>
				/// <java-name>
				/// putChar
				/// </java-name>
				[Dot42.DexImport("putChar", "(IC)Ljava/nio/ByteBuffer;", AccessFlags = 1025)]
				public abstract global::Java.Nio.ByteBuffer PutChar(int index, char value) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Writes the given double to the current position and increases the position by 8. </para><para>The double is converted to bytes using the current byte order.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> this </c> </para>
				/// </returns>
				/// <java-name>
				/// putDouble
				/// </java-name>
				[Dot42.DexImport("putDouble", "(D)Ljava/nio/ByteBuffer;", AccessFlags = 1025)]
				public abstract global::Java.Nio.ByteBuffer PutDouble(double value) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Writes the given double to the specified index of this buffer. </para><para>The double is converted to bytes using the current byte order. The position is not changed.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> this </c> </para>
				/// </returns>
				/// <java-name>
				/// putDouble
				/// </java-name>
				[Dot42.DexImport("putDouble", "(ID)Ljava/nio/ByteBuffer;", AccessFlags = 1025)]
				public abstract global::Java.Nio.ByteBuffer PutDouble(int index, double value) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Writes the given float to the current position and increases the position by 4. </para><para>The float is converted to bytes using the current byte order.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> this </c> </para>
				/// </returns>
				/// <java-name>
				/// putFloat
				/// </java-name>
				[Dot42.DexImport("putFloat", "(F)Ljava/nio/ByteBuffer;", AccessFlags = 1025)]
				public abstract global::Java.Nio.ByteBuffer PutFloat(float value) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Writes the given float to the specified index of this buffer. </para><para>The float is converted to bytes using the current byte order. The position is not changed.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> this </c> </para>
				/// </returns>
				/// <java-name>
				/// putFloat
				/// </java-name>
				[Dot42.DexImport("putFloat", "(IF)Ljava/nio/ByteBuffer;", AccessFlags = 1025)]
				public abstract global::Java.Nio.ByteBuffer PutFloat(int index, float value) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Writes the given int to the current position and increases the position by 4. </para><para>The int is converted to bytes using the current byte order.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> this </c> </para>
				/// </returns>
				/// <java-name>
				/// putInt
				/// </java-name>
				[Dot42.DexImport("putInt", "(I)Ljava/nio/ByteBuffer;", AccessFlags = 1025)]
				public abstract global::Java.Nio.ByteBuffer PutInt(int value) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Writes the given int to the specified index of this buffer. </para><para>The int is converted to bytes using the current byte order. The position is not changed.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> this </c> </para>
				/// </returns>
				/// <java-name>
				/// putInt
				/// </java-name>
				[Dot42.DexImport("putInt", "(II)Ljava/nio/ByteBuffer;", AccessFlags = 1025)]
				public abstract global::Java.Nio.ByteBuffer PutInt(int index, int value) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Writes the given long to the current position and increases the position by 8. </para><para>The long is converted to bytes using the current byte order.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> this </c> </para>
				/// </returns>
				/// <java-name>
				/// putLong
				/// </java-name>
				[Dot42.DexImport("putLong", "(J)Ljava/nio/ByteBuffer;", AccessFlags = 1025)]
				public abstract global::Java.Nio.ByteBuffer PutLong(long value) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Writes the given long to the specified index of this buffer. </para><para>The long is converted to bytes using the current byte order. The position is not changed.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> this </c> </para>
				/// </returns>
				/// <java-name>
				/// putLong
				/// </java-name>
				[Dot42.DexImport("putLong", "(IJ)Ljava/nio/ByteBuffer;", AccessFlags = 1025)]
				public abstract global::Java.Nio.ByteBuffer PutLong(int index, long value) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Writes the given short to the current position and increases the position by 2. </para><para>The short is converted to bytes using the current byte order.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> this </c> </para>
				/// </returns>
				/// <java-name>
				/// putShort
				/// </java-name>
				[Dot42.DexImport("putShort", "(S)Ljava/nio/ByteBuffer;", AccessFlags = 1025)]
				public abstract global::Java.Nio.ByteBuffer PutShort(short value) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Writes the given short to the specified index of this buffer. </para><para>The short is converted to bytes using the current byte order. The position is not changed.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> this </c> </para>
				/// </returns>
				/// <java-name>
				/// putShort
				/// </java-name>
				[Dot42.DexImport("putShort", "(IS)Ljava/nio/ByteBuffer;", AccessFlags = 1025)]
				public abstract global::Java.Nio.ByteBuffer PutShort(int index, short value) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns a sliced buffer that shares its content with this buffer. </para><para>The sliced buffer's capacity will be this buffer's <c> remaining() </c> , and it's zero position will correspond to this buffer's current position. The new buffer's position will be 0, limit will be its capacity, and its mark is cleared. The new buffer's read-only property and byte order are the same as this buffer's. </para><para>The new buffer shares its content with this buffer, which means either buffer's change of content will be visible to the other. The two buffer's position, limit and mark are independent.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a sliced buffer that shares its content with this buffer. </para>
				/// </returns>
				/// <java-name>
				/// slice
				/// </java-name>
				[Dot42.DexImport("slice", "()Ljava/nio/ByteBuffer;", AccessFlags = 1025)]
				public abstract global::Java.Nio.ByteBuffer Slice() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the char at the current position and increases the position by 2. </para><para>The 2 bytes starting at the current position are composed into a char according to the current byte order and returned.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the char at the current position. </para>
				/// </returns>
				/// <java-name>
				/// getChar
				/// </java-name>
				public char Char
				{
				[Dot42.DexImport("getChar", "()C", AccessFlags = 1025)]
						get{ return GetChar(); }
				}

				/// <summary>
				/// <para>Returns the double at the current position and increases the position by 8. </para><para>The 8 bytes starting from the current position are composed into a double according to the current byte order and returned.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the double at the current position. </para>
				/// </returns>
				/// <java-name>
				/// getDouble
				/// </java-name>
				public double Double
				{
				[Dot42.DexImport("getDouble", "()D", AccessFlags = 1025)]
						get{ return GetDouble(); }
				}

				/// <summary>
				/// <para>Returns the float at the current position and increases the position by 4. </para><para>The 4 bytes starting at the current position are composed into a float according to the current byte order and returned.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the float at the current position. </para>
				/// </returns>
				/// <java-name>
				/// getFloat
				/// </java-name>
				public float Float
				{
				[Dot42.DexImport("getFloat", "()F", AccessFlags = 1025)]
						get{ return GetFloat(); }
				}

				/// <summary>
				/// <para>Returns the int at the current position and increases the position by 4. </para><para>The 4 bytes starting at the current position are composed into a int according to the current byte order and returned.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the int at the current position. </para>
				/// </returns>
				/// <java-name>
				/// getInt
				/// </java-name>
				public int Int
				{
				[Dot42.DexImport("getInt", "()I", AccessFlags = 1025)]
						get{ return GetInt(); }
				}

				/// <summary>
				/// <para>Returns the long at the current position and increases the position by 8. </para><para>The 8 bytes starting at the current position are composed into a long according to the current byte order and returned.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the long at the current position. </para>
				/// </returns>
				/// <java-name>
				/// getLong
				/// </java-name>
				public long Long
				{
				[Dot42.DexImport("getLong", "()J", AccessFlags = 1025)]
						get{ return GetLong(); }
				}

				/// <summary>
				/// <para>Returns the short at the current position and increases the position by 2. </para><para>The 2 bytes starting at the current position are composed into a short according to the current byte order and returned.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the short at the current position. </para>
				/// </returns>
				/// <java-name>
				/// getShort
				/// </java-name>
				public short Short
				{
				[Dot42.DexImport("getShort", "()S", AccessFlags = 1025)]
						get{ return GetShort(); }
				}

		}

		/// <summary>
		/// <para>A <c> ReadOnlyBufferException </c> is thrown when some write operation is called on a read-only buffer. </para>    
		/// </summary>
		/// <java-name>
		/// java/nio/ReadOnlyBufferException
		/// </java-name>
		[Dot42.DexImport("java/nio/ReadOnlyBufferException", AccessFlags = 33)]
		public partial class ReadOnlyBufferException : global::Java.Lang.UnsupportedOperationException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs a <c> ReadOnlyBufferException </c> . </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ReadOnlyBufferException() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>A buffer is a list of elements of a specific primitive type. </para><para>A buffer can be described by the following properties: <ul><li><para>Capacity: the number of elements a buffer can hold. Capacity may not be negative and never changes. </para></li><li><para>Position: a cursor of this buffer. Elements are read or written at the position if you do not specify an index explicitly. Position may not be negative and not greater than the limit. </para></li><li><para>Limit: controls the scope of accessible elements. You can only read or write elements from index zero to <code>limit - 1</code>. Accessing elements out of the scope will cause an exception. Limit may not be negative and not greater than capacity. </para></li><li><para>Mark: used to remember the current position, so that you can reset the position later. Mark may not be negative and no greater than position. </para></li><li><para>A buffer can be read-only or read-write. Trying to modify the elements of a read-only buffer will cause a <code>ReadOnlyBufferException</code>, while changing the position, limit and mark of a read-only buffer is OK. </para></li><li><para>A buffer can be direct or indirect. A direct buffer will try its best to take advantage of native memory APIs and it may not stay in the Java heap, thus it is not affected by garbage collection. </para></li></ul></para><para>Buffers are not thread-safe. If concurrent access to a buffer instance is required, then the callers are responsible to take care of the synchronization issues. </para>    
		/// </summary>
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

				/// <summary>
				/// <para>Returns the array that backs this buffer (optional operation). The returned value is the actual array, not a copy, so modifications to the array write through to the buffer.</para><para>Subclasses should override this method with a covariant return type to provide the exact type of the array.</para><para>Use <c> hasArray </c> to ensure this method won't throw. (A separate call to <c> isReadOnly </c> is not necessary.)</para><para><para>1.6 </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the array </para>
				/// </returns>
				/// <java-name>
				/// array
				/// </java-name>
				[Dot42.DexImport("array", "()Ljava/lang/Object;", AccessFlags = 1025)]
				public abstract object Array() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the offset into the array returned by <c> array </c> of the first element of the buffer (optional operation). The backing array (if there is one) is not necessarily the same size as the buffer, and position 0 in the buffer is not necessarily the 0th element in the array. Use <c> buffer.array()[offset + buffer.arrayOffset() </c> to access element <c> offset </c> in <c> buffer </c> .</para><para>Use <c> hasArray </c> to ensure this method won't throw. (A separate call to <c> isReadOnly </c> is not necessary.)</para><para><para>1.6 </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the offset </para>
				/// </returns>
				/// <java-name>
				/// arrayOffset
				/// </java-name>
				[Dot42.DexImport("arrayOffset", "()I", AccessFlags = 1025)]
				public abstract int ArrayOffset() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the capacity of this buffer.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of elements that are contained in this buffer. </para>
				/// </returns>
				/// <java-name>
				/// capacity
				/// </java-name>
				[Dot42.DexImport("capacity", "()I", AccessFlags = 17)]
				public int Capacity() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Clears this buffer. </para><para>While the content of this buffer is not changed, the following internal changes take place: the current position is reset back to the start of the buffer, the value of the buffer limit is made equal to the capacity and mark is cleared.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>this buffer. </para>
				/// </returns>
				/// <java-name>
				/// clear
				/// </java-name>
				[Dot42.DexImport("clear", "()Ljava/nio/Buffer;", AccessFlags = 17)]
				public global::Java.Nio.Buffer Clear() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.Buffer);
				}

				/// <summary>
				/// <para>Flips this buffer. </para><para>The limit is set to the current position, then the position is set to zero, and the mark is cleared. </para><para>The content of this buffer is not changed.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>this buffer. </para>
				/// </returns>
				/// <java-name>
				/// flip
				/// </java-name>
				[Dot42.DexImport("flip", "()Ljava/nio/Buffer;", AccessFlags = 17)]
				public global::Java.Nio.Buffer Flip() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.Buffer);
				}

				/// <summary>
				/// <para>Returns true if <c> array </c> and <c> arrayOffset </c> won't throw. This method does not return true for buffers not backed by arrays because the other methods would throw <c> UnsupportedOperationException </c> , nor does it return true for buffers backed by read-only arrays, because the other methods would throw <c> ReadOnlyBufferException </c> . <para>1.6 </para></para>        
				/// </summary>
				/// <java-name>
				/// hasArray
				/// </java-name>
				[Dot42.DexImport("hasArray", "()Z", AccessFlags = 1025)]
				public abstract bool HasArray() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Indicates if there are elements remaining in this buffer, that is if <c> position &lt; limit </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if there are elements remaining in this buffer, <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// hasRemaining
				/// </java-name>
				[Dot42.DexImport("hasRemaining", "()Z", AccessFlags = 17)]
				public bool HasRemaining() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns true if this is a direct buffer. <para>1.6 </para></para>        
				/// </summary>
				/// <java-name>
				/// isDirect
				/// </java-name>
				[Dot42.DexImport("isDirect", "()Z", AccessFlags = 1025)]
				public abstract bool IsDirect() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Indicates whether this buffer is read-only.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if this buffer is read-only, <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isReadOnly
				/// </java-name>
				[Dot42.DexImport("isReadOnly", "()Z", AccessFlags = 1025)]
				public abstract bool IsReadOnly() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the limit of this buffer.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the limit of this buffer. </para>
				/// </returns>
				/// <java-name>
				/// limit
				/// </java-name>
				[Dot42.DexImport("limit", "()I", AccessFlags = 17)]
				public int Limit() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Sets the limit of this buffer. </para><para>If the current position in the buffer is in excess of <code>newLimit</code> then, on returning from this call, it will have been adjusted to be equivalent to <code>newLimit</code>. If the mark is set and is greater than the new limit, then it is cleared.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>this buffer. </para>
				/// </returns>
				/// <java-name>
				/// limit
				/// </java-name>
				[Dot42.DexImport("limit", "(I)Ljava/nio/Buffer;", AccessFlags = 17)]
				public global::Java.Nio.Buffer Limit(int newLimit) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.Buffer);
				}

				/// <summary>
				/// <para>Marks the current position, so that the position may return to this point later by calling <code>reset()</code>.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>this buffer. </para>
				/// </returns>
				/// <java-name>
				/// mark
				/// </java-name>
				[Dot42.DexImport("mark", "()Ljava/nio/Buffer;", AccessFlags = 17)]
				public global::Java.Nio.Buffer Mark() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.Buffer);
				}

				/// <summary>
				/// <para>Returns the position of this buffer.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the value of this buffer's current position. </para>
				/// </returns>
				/// <java-name>
				/// position
				/// </java-name>
				[Dot42.DexImport("position", "()I", AccessFlags = 17)]
				public int Position() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Sets the position of this buffer. </para><para>If the mark is set and it is greater than the new position, then it is cleared.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>this buffer. </para>
				/// </returns>
				/// <java-name>
				/// position
				/// </java-name>
				[Dot42.DexImport("position", "(I)Ljava/nio/Buffer;", AccessFlags = 17)]
				public global::Java.Nio.Buffer Position(int newPosition) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.Buffer);
				}

				/// <summary>
				/// <para>Returns the number of remaining elements in this buffer, that is <c> limit - position </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of remaining elements in this buffer. </para>
				/// </returns>
				/// <java-name>
				/// remaining
				/// </java-name>
				[Dot42.DexImport("remaining", "()I", AccessFlags = 17)]
				public int Remaining() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Resets the position of this buffer to the <code>mark</code>.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>this buffer. </para>
				/// </returns>
				/// <java-name>
				/// reset
				/// </java-name>
				[Dot42.DexImport("reset", "()Ljava/nio/Buffer;", AccessFlags = 17)]
				public global::Java.Nio.Buffer Reset() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.Buffer);
				}

				/// <summary>
				/// <para>Rewinds this buffer. </para><para>The position is set to zero, and the mark is cleared. The content of this buffer is not changed.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>this buffer. </para>
				/// </returns>
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

		}

}


