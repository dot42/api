// Copyright (C) 2014 dot42
//
// Original filename: System.cs
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
namespace System
{
		/// <summary>
		/// <para>The root class of the Java class hierarchy. All non-primitive types (including arrays) inherit either directly or indirectly from this class.</para><para><h4>Writing a correct  equals  method</h4></para><para>Follow this style to write a canonical <c> equals </c> method: <pre>
		///      // Use  to avoid accidental overloading.
		///      &amp;#x0040;Override public boolean equals(Object o) {
		///        // Return true if the objects are identical.
		///        // (This is just an optimization, not required for correctness.)
		///        if (this == o) {
		///          return true;
		///        }
		/// 
		///        // Return false if the other object has the wrong type.
		///        // This type may be an interface depending on the interface's specification.
		///        if (!(o instanceof MyType)) {
		///          return false;
		///        }
		/// 
		///        // Cast to the appropriate type.
		///        // This will succeed because of the instanceof, and lets us access private fields.
		///        MyType lhs = (MyType) o;
		/// 
		///        // Check each field. Primitive fields, reference fields, and nullable reference
		///        // fields are all treated differently.
		///        return primitiveField == lhs.primitiveField &amp;&amp;
		///                referenceField.equals(lhs.referenceField) &amp;&amp;
		///                (nullableField == null ? lhs.nullableField == null
		///                                       : nullableField.equals(lhs.nullableField));
		///      }
		///    </pre> </para><para>If you override <c> equals </c> , you should also override <c> hashCode </c> : equal instances must have equal hash codes.</para><para>See <b>Effective Java</b> item 8 for much more detail and clarification.</para><para><h4>Writing a correct  hashCode  method</h4></para><para>Follow this style to write a canonical <c> hashCode </c> method: <pre>
		///      &amp;#x0040;Override public int hashCode() {
		///        // Start with a non-zero constant.
		///        int result = 17;
		/// 
		///        // Include a hash for each field.
		///        result = 31 * result + (booleanField ? 1 : 0);
		/// 
		///        result = 31 * result + byteField;
		///        result = 31 * result + charField;
		///        result = 31 * result + shortField;
		///        result = 31 * result + intField;
		/// 
		///        result = 31 * result + (int) (longField ^ (longField &gt;&gt;&gt; 32));
		/// 
		///        result = 31 * result + Float.floatToIntBits(floatField);
		/// 
		///        long doubleFieldBits = Double.doubleToLongBits(doubleField);
		///        result = 31 * result + (int) (doubleFieldBits ^ (doubleFieldBits &gt;&gt;&gt; 32));
		/// 
		///        result = 31 * result + Arrays.hashCode(arrayField);
		/// 
		///        result = 31 * result + referenceField.hashCode();
		///        result = 31 * result +
		///            (nullableReferenceField == null ? 0
		///                                            : nullableReferenceField.hashCode());
		/// 
		///        return result;
		///      }
		///    </pre></para><para>If you don't intend your type to be used as a hash key, don't simply rely on the default <c> hashCode </c> implementation, because that silently and non-obviously breaks any future code that does use your type as a hash key. You should throw instead: <pre>
		///      &amp;#x0040;Override public int hashCode() {
		///        throw new UnsupportedOperationException();
		///      }
		///    </pre></para><para>See <b>Effective Java</b> item 9 for much more detail and clarification.</para><para><h4>Writing a useful  toString  method</h4></para><para>For debugging convenience, it's common to override <c> toString </c> in this style: <pre>
		///      &amp;#x0040;Override public String toString() {
		///        return getClass().getName() + "[" +
		///            "primitiveField=" + primitiveField + ", " +
		///            "referenceField=" + referenceField + ", " +
		///            "arrayField=" + Arrays.toString(arrayField) + "]";
		///      }
		///    </pre> </para><para>The set of fields to include is generally the same as those that would be tested in your <c> equals </c> implementation. </para><para>See <b>Effective Java</b> item 10 for much more detail and clarification. </para>    
		/// </summary>
		/// <java-name>
		/// java/lang/Object
		/// </java-name>
		[Dot42.DexImport("java/lang/Object", AccessFlags = 33)]
		public partial class Object
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs a new instance of <c> Object </c> . </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Object() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Compares this instance with the specified object and indicates if they are equal. In order to be equal, <c> o </c> must represent the same object as this instance using a class-specific comparison. The general contract is that this comparison should be reflexive, symmetric, and transitive. Also, no object reference other than null is equal to null.</para><para>The default implementation returns <c> true </c> only if <c> this ==       o </c> . See  if you intend implementing your own <c> equals </c> method.</para><para>The general contract for the <c> equals </c> and hashCode() methods is that if <c> equals </c> returns <c> true </c> for any two objects, then <c> hashCode() </c> must return the same value for these objects. This means that subclasses of <c> Object </c> usually override either both methods or neither of them.</para><para><para>hashCode </para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the specified object is equal to this <c>               Object </c> ; <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public virtual bool Equals(object o) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Invoked when the garbage collector has detected that this instance is no longer reachable. The default implementation does nothing, but this method can be overridden to free resources.</para><para>Note that objects that override <c> finalize </c> are significantly more expensive than objects that don't. Finalizers may be run a long time after the object is no longer reachable, depending on memory pressure, so it's a bad idea to rely on them for cleanup. Note also that finalizers are run on a single VM-wide finalizer thread, so doing blocking work in a finalizer is a bad idea. A finalizer is usually only necessary for a class that has a native peer and needs to call a native method to destroy that peer. Even then, it's better to provide an explicit <c> close </c> method (and implement java.io.Closeable), and insist that callers manually dispose of instances. This works well for something like files, but less well for something like a <c> BigInteger </c> where typical calling code would have to deal with lots of temporaries. Unfortunately, code that creates lots of temporaries is the worst kind of code from the point of view of the single finalizer thread.</para><para>If you <b>must</b> use finalizers, consider at least providing your own java.lang.ref.ReferenceQueue and having your own thread process that queue.</para><para>Unlike constructors, finalizers are not automatically chained. You are responsible for calling <c> super.finalize() </c> yourself.</para><para>Uncaught exceptions thrown by finalizers are ignored and do not terminate the finalizer thread.</para><para>See <b>Effective Java</b> Item 7, "Avoid finalizers" for more. </para>        
				/// </summary>
				/// <java-name>
				/// finalize
				/// </java-name>
				[Dot42.DexImport("finalize", "()V", AccessFlags = 4)]
				extern ~Object() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the unique instance of Class that represents this object's class. Note that <c> getClass() </c> is a special case in that it actually returns <c> Class&lt;? extends Foo&gt; </c> where <c> Foo </c> is the erasure of the type of the expression <c> getClass() </c> was called upon. </para><para>As an example, the following code actually compiles, although one might think it shouldn't: </para><para><pre>         List&lt;Integer&gt; l = new ArrayList&lt;Integer&gt;();
				/// 
				///          Class&lt;? extends List&gt; c = l.getClass(); 
				/// 
				///  </pre></para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>this object's <c> Class </c> instance. </para>
				/// </returns>
				/// <java-name>
				/// getClass
				/// </java-name>
				[Dot42.DexImport("getClass", "()Ljava/lang/Class;", AccessFlags = 273, Signature = "()Ljava/lang/Class<*>;")]
				public global::System.Type GetType() /* MethodBuilder.Create */ 
				{
						return default(global::System.Type);
				}

				/// <summary>
				/// <para>Returns an integer hash code for this object. By contract, any two objects for which equals returns <c> true </c> must return the same hash code value. This means that subclasses of <c> Object </c> usually override both methods or neither method.</para><para>Note that hash values must not change over time unless information used in equals comparisons also changes.</para><para>See  if you intend implementing your own <c> hashCode </c> method.</para><para><para>equals </para></para>        
				/// </summary>
				/// <returns>
				/// <para>this object's hash code. </para>
				/// </returns>
				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 257)]
				public virtual int GetHashCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Causes a thread which is waiting on this object's monitor (by means of calling one of the <c> wait() </c> methods) to be woken up. If more than one thread is waiting, one of them is chosen at the discretion of the VM. The chosen thread will not run immediately. The thread that called <c> notify() </c> has to release the object's monitor first. Also, the chosen thread still has to compete against other threads that try to synchronize on the same object. </para><para>This method can only be invoked by a thread which owns this object's monitor. A thread becomes owner of an object's monitor </para><para><ul><li><para>by executing a synchronized method of that object; </para></li><li><para>by executing the body of a <c> synchronized </c> statement that synchronizes on the object; </para></li><li><para>by executing a synchronized static method if the object is of type <c> Class </c> . </para></li></ul></para><para><para>notifyAll </para><simplesectsep></simplesectsep><para>wait() </para><simplesectsep></simplesectsep><para>wait(long) </para><simplesectsep></simplesectsep><para>wait(long,int) </para><simplesectsep></simplesectsep><para>java.lang.Thread </para></para>        
				/// </summary>
				/// <java-name>
				/// notify
				/// </java-name>
				[Dot42.DexImport("notify", "()V", AccessFlags = 273)]
				public void Notify() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Causes all threads which are waiting on this object's monitor (by means of calling one of the <c> wait() </c> methods) to be woken up. The threads will not run immediately. The thread that called <c> notify() </c> has to release the object's monitor first. Also, the threads still have to compete against other threads that try to synchronize on the same object. </para><para>This method can only be invoked by a thread which owns this object's monitor. A thread becomes owner of an object's monitor </para><para><ul><li><para>by executing a synchronized method of that object; </para></li><li><para>by executing the body of a <c> synchronized </c> statement that synchronizes on the object; </para></li><li><para>by executing a synchronized static method if the object is of type <c> Class </c> . </para></li></ul></para><para><para>notify </para><simplesectsep></simplesectsep><para>wait() </para><simplesectsep></simplesectsep><para>wait(long) </para><simplesectsep></simplesectsep><para>wait(long,int) </para><simplesectsep></simplesectsep><para>java.lang.Thread </para></para>        
				/// </summary>
				/// <java-name>
				/// notifyAll
				/// </java-name>
				[Dot42.DexImport("notifyAll", "()V", AccessFlags = 273)]
				public void NotifyAll() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns a string containing a concise, human-readable description of this object. Subclasses are encouraged to override this method and provide an implementation that takes into account the object's type and data. The default implementation is equivalent to the following expression: <pre>
				///          getClass().getName() + '@' + Integer.toHexString(hashCode())</pre> </para><para>See  if you intend implementing your own <c> toString </c> method.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a printable representation of this object. </para>
				/// </returns>
				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Causes the calling thread to wait until another thread calls the <c>       notify() </c> or <c> notifyAll() </c> method of this object. This method can only be invoked by a thread which owns this object's monitor; see notify() on how a thread can become the owner of a monitor. </para><para>A waiting thread can be sent <c> interrupt() </c> to cause it to prematurely stop waiting, so <c> wait </c> should be called in a loop to check that the condition that has been waited for has been met before continuing. </para><para>While the thread waits, it gives up ownership of this object's monitor. When it is notified (or interrupted), it re-acquires the monitor before it starts running. </para><para><para>notify </para><simplesectsep></simplesectsep><para>notifyAll </para><simplesectsep></simplesectsep><para>wait(long) </para><simplesectsep></simplesectsep><para>wait(long,int) </para><simplesectsep></simplesectsep><para>java.lang.Thread </para></para>        
				/// </summary>
				/// <java-name>
				/// wait
				/// </java-name>
				[Dot42.DexImport("wait", "()V", AccessFlags = 17)]
				public void JavaWait() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Causes the calling thread to wait until another thread calls the <c>       notify() </c> or <c> notifyAll() </c> method of this object or until the specified timeout expires. This method can only be invoked by a thread which owns this object's monitor; see notify() on how a thread can become the owner of a monitor. </para><para>A waiting thread can be sent <c> interrupt() </c> to cause it to prematurely stop waiting, so <c> wait </c> should be called in a loop to check that the condition that has been waited for has been met before continuing. </para><para>While the thread waits, it gives up ownership of this object's monitor. When it is notified (or interrupted), it re-acquires the monitor before it starts running. </para><para><para>notify </para><simplesectsep></simplesectsep><para>notifyAll </para><simplesectsep></simplesectsep><para>wait() </para><simplesectsep></simplesectsep><para>wait(long,int) </para><simplesectsep></simplesectsep><para>java.lang.Thread </para></para>        
				/// </summary>
				/// <java-name>
				/// wait
				/// </java-name>
				[Dot42.DexImport("wait", "(J)V", AccessFlags = 17)]
				public void JavaWait(long millis) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Causes the calling thread to wait until another thread calls the <c>       notify() </c> or <c> notifyAll() </c> method of this object or until the specified timeout expires. This method can only be invoked by a thread that owns this object's monitor; see notify() on how a thread can become the owner of a monitor. </para><para>A waiting thread can be sent <c> interrupt() </c> to cause it to prematurely stop waiting, so <c> wait </c> should be called in a loop to check that the condition that has been waited for has been met before continuing. </para><para>While the thread waits, it gives up ownership of this object's monitor. When it is notified (or interrupted), it re-acquires the monitor before it starts running. </para><para><para>notify </para><simplesectsep></simplesectsep><para>notifyAll </para><simplesectsep></simplesectsep><para>wait() </para><simplesectsep></simplesectsep><para>wait(long,int) </para><simplesectsep></simplesectsep><para>java.lang.Thread </para></para>        
				/// </summary>
				/// <java-name>
				/// wait
				/// </java-name>
				[Dot42.DexImport("wait", "(JI)V", AccessFlags = 273)]
				public void JavaWait(long millis, int nanos) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the unique instance of Class that represents this object's class. Note that <c> getClass() </c> is a special case in that it actually returns <c> Class&lt;? extends Foo&gt; </c> where <c> Foo </c> is the erasure of the type of the expression <c> getClass() </c> was called upon. </para><para>As an example, the following code actually compiles, although one might think it shouldn't: </para><para><pre>         List&lt;Integer&gt; l = new ArrayList&lt;Integer&gt;();
				/// 
				///          Class&lt;? extends List&gt; c = l.getClass(); 
				/// 
				///  </pre></para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>this object's <c> Class </c> instance. </para>
				/// </returns>
				/// <java-name>
				/// getClass
				/// </java-name>
				public global::System.Type Type
				{
				[Dot42.DexImport("getClass", "()Ljava/lang/Class;", AccessFlags = 273, Signature = "()Ljava/lang/Class<*>;")]
						get{ return GetType(); }
				}

		}

		/// <summary>
		/// <para>An immutable sequence of characters/code units (<c> char </c> s). A <c> String </c> is represented by array of UTF-16 values, such that Unicode supplementary characters (code points) are stored/encoded as surrogate pairs via Unicode code units (<c> char </c> ).</para><para><h3>Backing Arrays</h3></para><para>This class is implemented using a char[]. The length of the array may exceed the length of the string. For example, the string "Hello" may be backed by the array <c> ['H', 'e', 'l', 'l', 'o', 'W'. 'o', 'r', 'l', 'd'] </c> with offset 0 and length 5.</para><para>Multiple strings can share the same char[] because strings are immutable. The substring method <b>always</b> returns a string that shares the backing array of its source string. Generally this is an optimization: fewer character arrays need to be allocated, and less copying is necessary. But this can also lead to unwanted heap retention. Taking a short substring of long string means that the long shared char[] won't be garbage until both strings are garbage. This typically happens when parsing small substrings out of a large input. To avoid this where necessary, call <c> new String(longString.subString(...)) </c> . The string copy constructor always ensures that the backing array is no larger than necessary.</para><para><para>StringBuffer </para><simplesectsep></simplesectsep><para>StringBuilder </para><simplesectsep></simplesectsep><para>Charset </para><para>1.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// java/lang/String
		/// </java-name>
		[Dot42.DexImport("java/lang/String", AccessFlags = 49, Signature = "Ljava/lang/Object;Ljava/io/Serializable;Ljava/lang/Comparable<Ljava/lang/String;>" +
    ";Ljava/lang/CharSequence;")]
		public sealed partial class String : global::Java.Io.ISerializable, global::System.IComparable<string>, global::Java.Lang.ICharSequence
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>A comparator ignoring the case of the characters. </para>        
				/// </summary>
				/// <java-name>
				/// CASE_INSENSITIVE_ORDER
				/// </java-name>
				[Dot42.DexImport("CASE_INSENSITIVE_ORDER", "Ljava/util/Comparator;", AccessFlags = 25)]
				public static readonly global::Java.Util.IComparator<string> CASE_INSENSITIVE_ORDER;
				/// <summary>
				/// <para>Creates an empty string. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public String() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Converts the byte array to a string using the system's default charset. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "([B)V", AccessFlags = 1)]
				public String(sbyte[] data) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Converts the byte array to a string using the system's default charset. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "([B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public String(byte[] data) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Converts the byte array to a string, setting the high byte of every character to the specified value.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>Use String(byte[]) or String(byte[], String) instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "([BI)V", AccessFlags = 1)]
				public String(sbyte[] data, int high) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Converts the byte array to a string, setting the high byte of every character to the specified value.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>Use String(byte[]) or String(byte[], String) instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "([BI)V", AccessFlags = 1, IgnoreFromJava = true)]
				public String(byte[] data, int high) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Converts a subsequence of the byte array to a string using the system's default charset.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "([BII)V", AccessFlags = 1)]
				public String(sbyte[] data, int offset, int byteCount) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Converts a subsequence of the byte array to a string using the system's default charset.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "([BII)V", AccessFlags = 1, IgnoreFromJava = true)]
				public String(byte[] data, int offset, int byteCount) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Converts the byte array to a string, setting the high byte of every character to <c> high </c> .</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>Use String(byte[], int, int) instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "([BIII)V", AccessFlags = 1)]
				public String(sbyte[] data, int high, int offset, int byteCount) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Converts the byte array to a string, setting the high byte of every character to <c> high </c> .</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>Use String(byte[], int, int) instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "([BIII)V", AccessFlags = 1, IgnoreFromJava = true)]
				public String(byte[] data, int high, int offset, int byteCount) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Converts the byte array to a string, setting the high byte of every character to <c> high </c> .</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>Use String(byte[], int, int) instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "([BIILjava/lang/String;)V", AccessFlags = 1)]
				public String(sbyte[] data, int high, int offset, string byteCount) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Converts the byte array to a string, setting the high byte of every character to <c> high </c> .</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>Use String(byte[], int, int) instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "([BIILjava/lang/String;)V", AccessFlags = 1, IgnoreFromJava = true)]
				public String(byte[] data, int high, int offset, string byteCount) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Converts the byte array to a string, setting the high byte of every character to the specified value.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>Use String(byte[]) or String(byte[], String) instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "([BLjava/lang/String;)V", AccessFlags = 1)]
				public String(sbyte[] data, string high) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Converts the byte array to a string, setting the high byte of every character to the specified value.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>Use String(byte[]) or String(byte[], String) instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "([BLjava/lang/String;)V", AccessFlags = 1, IgnoreFromJava = true)]
				public String(byte[] data, string high) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Converts the byte array to a string, setting the high byte of every character to <c> high </c> .</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>Use String(byte[], int, int) instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "([BIILjava/nio/charset/Charset;)V", AccessFlags = 1)]
				public String(sbyte[] data, int high, int offset, global::Java.Nio.Charset.Charset byteCount) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Converts the byte array to a string, setting the high byte of every character to <c> high </c> .</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>Use String(byte[], int, int) instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "([BIILjava/nio/charset/Charset;)V", AccessFlags = 1, IgnoreFromJava = true)]
				public String(byte[] data, int high, int offset, global::Java.Nio.Charset.Charset byteCount) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Converts the byte array to a string, setting the high byte of every character to the specified value.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>Use String(byte[]) or String(byte[], String) instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "([BLjava/nio/charset/Charset;)V", AccessFlags = 1)]
				public String(sbyte[] data, global::Java.Nio.Charset.Charset high) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Converts the byte array to a string, setting the high byte of every character to the specified value.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>Use String(byte[]) or String(byte[], String) instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "([BLjava/nio/charset/Charset;)V", AccessFlags = 1, IgnoreFromJava = true)]
				public String(byte[] data, global::Java.Nio.Charset.Charset high) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Converts the byte array to a string using the system's default charset. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "([C)V", AccessFlags = 1)]
				public String(char[] data) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Converts a subsequence of the byte array to a string using the system's default charset.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "([CII)V", AccessFlags = 1)]
				public String(char[] data, int offset, int byteCount) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Converts the byte array to a string using the system's default charset. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public String(string data) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Converts the byte array to a string using the system's default charset. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/StringBuffer;)V", AccessFlags = 1)]
				public String(global::Java.Lang.StringBuffer data) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Converts a subsequence of the byte array to a string using the system's default charset.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "([III)V", AccessFlags = 1)]
				public String(int[] data, int offset, int byteCount) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Converts the byte array to a string using the system's default charset. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/StringBuilder;)V", AccessFlags = 1)]
				public String(global::System.Text.StringBuilder data) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the character at the specified offset in this string.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the character at the index. </para>
				/// </returns>
				/// <java-name>
				/// charAt
				/// </java-name>
				[Dot42.DexImport("charAt", "(I)C", AccessFlags = 1)]
				public char CharAt(int index) /* MethodBuilder.Create */ 
				{
						return default(char);
				}

				/// <summary>
				/// <para>Compares the specified string to this string using the Unicode values of the characters. Returns 0 if the strings contain the same characters in the same order. Returns a negative integer if the first non-equal character in this string has a Unicode value which is less than the Unicode value of the character at the same position in the specified string, or if this string is a prefix of the specified string. Returns a positive integer if the first non-equal character in this string has a Unicode value which is greater than the Unicode value of the character at the same position in the specified string, or if the specified string is a prefix of this string.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>0 if the strings are equal, a negative integer if this string is before the specified string, or a positive integer if this string is after the specified string. </para>
				/// </returns>
				/// <java-name>
				/// compareTo
				/// </java-name>
				[Dot42.DexImport("compareTo", "(Ljava/lang/String;)I", AccessFlags = 1)]
				public int CompareTo(string @string) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Compares the specified string to this string using the Unicode values of the characters, ignoring case differences. Returns 0 if the strings contain the same characters in the same order. Returns a negative integer if the first non-equal character in this string has a Unicode value which is less than the Unicode value of the character at the same position in the specified string, or if this string is a prefix of the specified string. Returns a positive integer if the first non-equal character in this string has a Unicode value which is greater than the Unicode value of the character at the same position in the specified string, or if the specified string is a prefix of this string.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>0 if the strings are equal, a negative integer if this string is before the specified string, or a positive integer if this string is after the specified string. </para>
				/// </returns>
				/// <java-name>
				/// compareToIgnoreCase
				/// </java-name>
				[Dot42.DexImport("compareToIgnoreCase", "(Ljava/lang/String;)I", AccessFlags = 1)]
				public int CompareToIgnoreCase(string @string) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Concatenates this string and the specified string.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a new string which is the concatenation of this string and the specified string. </para>
				/// </returns>
				/// <java-name>
				/// concat
				/// </java-name>
				[Dot42.DexImport("concat", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1)]
				public string Concat(string @string) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Creates a new string containing the characters in the specified character array. Modifying the character array after creating the string has no effect on the string.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the new string. </para>
				/// </returns>
				/// <java-name>
				/// copyValueOf
				/// </java-name>
				[Dot42.DexImport("copyValueOf", "([C)Ljava/lang/String;", AccessFlags = 9)]
				public static string CopyValueOf(char[] data) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Creates a new string containing the specified characters in the character array. Modifying the character array after creating the string has no effect on the string.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the new string. </para>
				/// </returns>
				/// <java-name>
				/// copyValueOf
				/// </java-name>
				[Dot42.DexImport("copyValueOf", "([CII)Ljava/lang/String;", AccessFlags = 9)]
				public static string CopyValueOf(char[] data, int start, int length) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Compares the specified string to this string to determine if the specified string is a suffix.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the specified string is a suffix of this string, <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// endsWith
				/// </java-name>
				[Dot42.DexImport("endsWith", "(Ljava/lang/String;)Z", AccessFlags = 1)]
				public bool EndsWith(string suffix) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Compares the specified object to this string and returns true if they are equal. The object must be an instance of string with the same characters in the same order.</para><para><para>#hashCode </para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the specified object is equal to this string, <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Compares the specified string to this string ignoring the case of the characters and returns true if they are equal.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the specified string is equal to this string, <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// equalsIgnoreCase
				/// </java-name>
				[Dot42.DexImport("equalsIgnoreCase", "(Ljava/lang/String;)Z", AccessFlags = 1)]
				public bool EqualsIgnoreCase(string @string) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Mangles this string into a byte array by stripping the high order bits from each character. Use getBytes() or getBytes(String) instead.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>Use getBytes() or getBytes(String) </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// getBytes
				/// </java-name>
				[Dot42.DexImport("getBytes", "(II[BI)V", AccessFlags = 1)]
				public void GetBytes(int start, int end, sbyte[] data, int index) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Mangles this string into a byte array by stripping the high order bits from each character. Use getBytes() or getBytes(String) instead.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>Use getBytes() or getBytes(String) </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// getBytes
				/// </java-name>
				[Dot42.DexImport("getBytes", "(II[BI)V", AccessFlags = 1, IgnoreFromJava = true)]
				public void GetBytes(int start, int end, byte[] data, int index) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns a new byte array containing the characters of this string encoded using the system's default charset.</para><para>The behavior when this string cannot be represented in the system's default charset is unspecified. In practice, when the default charset is UTF-8 (as it is on Android), all strings can be encoded. </para>        
				/// </summary>
				/// <java-name>
				/// getBytes
				/// </java-name>
				[Dot42.DexImport("getBytes", "()[B", AccessFlags = 1)]
				public sbyte[] JavaGetBytes() /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <summary>
				/// <para>Returns a new byte array containing the characters of this string encoded using the system's default charset.</para><para>The behavior when this string cannot be represented in the system's default charset is unspecified. In practice, when the default charset is UTF-8 (as it is on Android), all strings can be encoded. </para>        
				/// </summary>
				/// <java-name>
				/// getBytes
				/// </java-name>
				[Dot42.DexImport("getBytes", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
				public byte[] GetBytes() /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				/// <summary>
				/// <para>Returns a new byte array containing the characters of this string encoded using the named charset.</para><para>The behavior when this string cannot be represented in the named charset is unspecified. Use java.nio.charset.CharsetEncoder for more control.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// getBytes
				/// </java-name>
				[Dot42.DexImport("getBytes", "(Ljava/lang/String;)[B", AccessFlags = 1)]
				public sbyte[] JavaGetBytes(string charsetName) /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <summary>
				/// <para>Returns a new byte array containing the characters of this string encoded using the named charset.</para><para>The behavior when this string cannot be represented in the named charset is unspecified. Use java.nio.charset.CharsetEncoder for more control.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// getBytes
				/// </java-name>
				[Dot42.DexImport("getBytes", "(Ljava/lang/String;)[B", AccessFlags = 1, IgnoreFromJava = true)]
				public byte[] GetBytes(string charsetName) /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				/// <summary>
				/// <para>Returns a new byte array containing the characters of this string encoded using the named charset.</para><para>The behavior when this string cannot be represented in the named charset is unspecified. Use java.nio.charset.CharsetEncoder for more control.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// getBytes
				/// </java-name>
				[Dot42.DexImport("getBytes", "(Ljava/nio/charset/Charset;)[B", AccessFlags = 1)]
				public sbyte[] JavaGetBytes(global::Java.Nio.Charset.Charset charsetName) /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <summary>
				/// <para>Returns a new byte array containing the characters of this string encoded using the named charset.</para><para>The behavior when this string cannot be represented in the named charset is unspecified. Use java.nio.charset.CharsetEncoder for more control.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// getBytes
				/// </java-name>
				[Dot42.DexImport("getBytes", "(Ljava/nio/charset/Charset;)[B", AccessFlags = 1, IgnoreFromJava = true)]
				public byte[] GetBytes(global::Java.Nio.Charset.Charset charsetName) /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				/// <summary>
				/// <para>Copies the specified characters in this string to the character array starting at the specified offset in the character array.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// getChars
				/// </java-name>
				[Dot42.DexImport("getChars", "(II[CI)V", AccessFlags = 1)]
				public void GetChars(int start, int end, char[] buffer, int index) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 1)]
				public override int GetHashCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Searches in this string for the first index of the specified character. The search for the character starts at the beginning and moves towards the end of this string.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the index in this string of the specified character, -1 if the character isn't found. </para>
				/// </returns>
				/// <java-name>
				/// indexOf
				/// </java-name>
				[Dot42.DexImport("indexOf", "(I)I", AccessFlags = 1)]
				public int IndexOf(int c) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Searches in this string for the index of the specified character. The search for the character starts at the specified offset and moves towards the end of this string.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the index in this string of the specified character, -1 if the character isn't found. </para>
				/// </returns>
				/// <java-name>
				/// indexOf
				/// </java-name>
				[Dot42.DexImport("indexOf", "(II)I", AccessFlags = 1)]
				public int IndexOf(int c, int start) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Searches in this string for the first index of the specified character. The search for the character starts at the beginning and moves towards the end of this string.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the index in this string of the specified character, -1 if the character isn't found. </para>
				/// </returns>
				/// <java-name>
				/// indexOf
				/// </java-name>
				[Dot42.DexImport("indexOf", "(Ljava/lang/String;)I", AccessFlags = 1)]
				public int IndexOf(string c) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Searches in this string for the index of the specified character. The search for the character starts at the specified offset and moves towards the end of this string.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the index in this string of the specified character, -1 if the character isn't found. </para>
				/// </returns>
				/// <java-name>
				/// indexOf
				/// </java-name>
				[Dot42.DexImport("indexOf", "(Ljava/lang/String;I)I", AccessFlags = 1)]
				public int IndexOf(string c, int start) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns an interned string equal to this string. The VM maintains an internal set of unique strings. All string literals found in loaded classes' constant pools are automatically interned. Manually-interned strings are only weakly referenced, so calling <c> intern </c> won't lead to unwanted retention.</para><para>Interning is typically used because it guarantees that for interned strings <c> a </c> and <c> b </c> , <c> a.equals(b) </c> can be simplified to <c> a == b </c> . (This is not true of non-interned strings.)</para><para>Many applications find it simpler and more convenient to use an explicit java.util.HashMap to implement their own pools. </para>        
				/// </summary>
				/// <java-name>
				/// intern
				/// </java-name>
				[Dot42.DexImport("intern", "()Ljava/lang/String;", AccessFlags = 257)]
				public string Intern() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns true if the length of this string is 0.</para><para><para>1.6 </para></para>        
				/// </summary>
				/// <java-name>
				/// isEmpty
				/// </java-name>
				[Dot42.DexImport("isEmpty", "()Z", AccessFlags = 1)]
				public bool IsEmpty() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns the last index of the code point <c> c </c> , or -1. The search for the character starts at the end and moves towards the beginning of this string. </para>        
				/// </summary>
				/// <java-name>
				/// lastIndexOf
				/// </java-name>
				[Dot42.DexImport("lastIndexOf", "(I)I", AccessFlags = 1)]
				public int LastIndexOf(int c) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the last index of the code point <c> c </c> , or -1. The search for the character starts at offset <c> start </c> and moves towards the beginning of this string. </para>        
				/// </summary>
				/// <java-name>
				/// lastIndexOf
				/// </java-name>
				[Dot42.DexImport("lastIndexOf", "(II)I", AccessFlags = 1)]
				public int LastIndexOf(int c, int start) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the last index of the code point <c> c </c> , or -1. The search for the character starts at the end and moves towards the beginning of this string. </para>        
				/// </summary>
				/// <java-name>
				/// lastIndexOf
				/// </java-name>
				[Dot42.DexImport("lastIndexOf", "(Ljava/lang/String;)I", AccessFlags = 1)]
				public int LastIndexOf(string c) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the last index of the code point <c> c </c> , or -1. The search for the character starts at offset <c> start </c> and moves towards the beginning of this string. </para>        
				/// </summary>
				/// <java-name>
				/// lastIndexOf
				/// </java-name>
				[Dot42.DexImport("lastIndexOf", "(Ljava/lang/String;I)I", AccessFlags = 1)]
				public int LastIndexOf(string c, int start) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the size of this string.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of characters in this string. </para>
				/// </returns>
				/// <java-name>
				/// length
				/// </java-name>
				[Dot42.DexImport("length", "()I", AccessFlags = 1)]
				public int GetLength() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Compares the specified string to this string and compares the specified range of characters to determine if they are the same.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the ranges of characters are equal, <c> false </c> otherwise </para>
				/// </returns>
				/// <java-name>
				/// regionMatches
				/// </java-name>
				[Dot42.DexImport("regionMatches", "(ILjava/lang/String;II)Z", AccessFlags = 1)]
				public bool RegionMatches(int thisStart, string @string, int start, int length) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Compares the specified string to this string and compares the specified range of characters to determine if they are the same. When ignoreCase is true, the case of the characters is ignored during the comparison.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the ranges of characters are equal, <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// regionMatches
				/// </java-name>
				[Dot42.DexImport("regionMatches", "(ZILjava/lang/String;II)Z", AccessFlags = 1)]
				public bool RegionMatches(bool ignoreCase, int thisStart, string @string, int start, int length) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Copies this string replacing occurrences of the specified character with another character.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a new string with occurrences of oldChar replaced by newChar. </para>
				/// </returns>
				/// <java-name>
				/// replace
				/// </java-name>
				[Dot42.DexImport("replace", "(CC)Ljava/lang/String;", AccessFlags = 1)]
				public string Replace(char oldChar, char newChar) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Copies this string replacing occurrences of the specified character with another character.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a new string with occurrences of oldChar replaced by newChar. </para>
				/// </returns>
				/// <java-name>
				/// replace
				/// </java-name>
				[Dot42.DexImport("replace", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;", AccessFlags = 1)]
				public string Replace(global::Java.Lang.ICharSequence oldChar, global::Java.Lang.ICharSequence newChar) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Compares the specified string to this string to determine if the specified string is a prefix.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the specified string is a prefix of this string, <c> false </c> otherwise </para>
				/// </returns>
				/// <java-name>
				/// startsWith
				/// </java-name>
				[Dot42.DexImport("startsWith", "(Ljava/lang/String;)Z", AccessFlags = 1)]
				public bool StartsWith(string prefix) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Compares the specified string to this string, starting at the specified offset, to determine if the specified string is a prefix.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the specified string occurs in this string at the specified offset, <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// startsWith
				/// </java-name>
				[Dot42.DexImport("startsWith", "(Ljava/lang/String;I)Z", AccessFlags = 1)]
				public bool StartsWith(string prefix, int start) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns a string containing a suffix of this string. The returned string shares this string's .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a new string containing the characters from start to the end of the string. </para>
				/// </returns>
				/// <java-name>
				/// substring
				/// </java-name>
				[Dot42.DexImport("substring", "(I)Ljava/lang/String;", AccessFlags = 1)]
				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
				public string JavaSubstring(int start) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns a string containing a subsequence of characters from this string. The returned string shares this string's .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a new string containing the characters from start to end - 1 </para>
				/// </returns>
				/// <java-name>
				/// substring
				/// </java-name>
				[Dot42.DexImport("substring", "(II)Ljava/lang/String;", AccessFlags = 1)]
				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
				public string JavaSubstring(int start, int end) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Copies the characters in this string to a character array.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a character array containing the characters of this string. </para>
				/// </returns>
				/// <java-name>
				/// toCharArray
				/// </java-name>
				[Dot42.DexImport("toCharArray", "()[C", AccessFlags = 1)]
				public char[] ToCharArray() /* MethodBuilder.Create */ 
				{
						return default(char[]);
				}

				/// <summary>
				/// <para>Converts this string to lower case, using the rules of the user's default locale. See "&lt;a href="../util/Locale.html::default_locale"&gt;Be wary of the default locale&lt;/a&gt;".</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a new lower case string, or <c> this </c> if it's already all lower case. </para>
				/// </returns>
				/// <java-name>
				/// toLowerCase
				/// </java-name>
				[Dot42.DexImport("toLowerCase", "()Ljava/lang/String;", AccessFlags = 1)]
				public string ToLower() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Converts this string to lower case, using the rules of <c> locale </c> .</para><para>Most case mappings are unaffected by the language of a <c> Locale </c> . Exceptions include dotted and dotless I in Azeri and Turkish locales, and dotted and dotless I and J in Lithuanian locales. On the other hand, it isn't necessary to provide a Greek locale to get correct case mapping of Greek characters: any locale will do.</para><para>See  for full details of context- and language-specific special cases.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a new lower case string, or <c> this </c> if it's already all lower case. </para>
				/// </returns>
				/// <java-name>
				/// toLowerCase
				/// </java-name>
				[Dot42.DexImport("toLowerCase", "(Ljava/util/Locale;)Ljava/lang/String;", AccessFlags = 1)]
				public string ToLower(global::Java.Util.Locale locale) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns this string. </para>        
				/// </summary>
				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Converts this this string to upper case, using the rules of the user's default locale. See "&lt;a href="../util/Locale.html::default_locale"&gt;Be wary of the default locale&lt;/a&gt;".</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a new upper case string, or <c> this </c> if it's already all upper case. </para>
				/// </returns>
				/// <java-name>
				/// toUpperCase
				/// </java-name>
				[Dot42.DexImport("toUpperCase", "()Ljava/lang/String;", AccessFlags = 1)]
				public string ToUpper() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Converts this this string to upper case, using the rules of <c> locale </c> .</para><para>Most case mappings are unaffected by the language of a <c> Locale </c> . Exceptions include dotted and dotless I in Azeri and Turkish locales, and dotted and dotless I and J in Lithuanian locales. On the other hand, it isn't necessary to provide a Greek locale to get correct case mapping of Greek characters: any locale will do.</para><para>See  for full details of context- and language-specific special cases.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a new upper case string, or <c> this </c> if it's already all upper case. </para>
				/// </returns>
				/// <java-name>
				/// toUpperCase
				/// </java-name>
				[Dot42.DexImport("toUpperCase", "(Ljava/util/Locale;)Ljava/lang/String;", AccessFlags = 1)]
				public string ToUpper(global::Java.Util.Locale locale) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Copies this string removing white space characters from the beginning and end of the string.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a new string with characters <code>&lt;= \u0020</code> removed from the beginning and the end. </para>
				/// </returns>
				/// <java-name>
				/// trim
				/// </java-name>
				[Dot42.DexImport("trim", "()Ljava/lang/String;", AccessFlags = 1)]
				public string Trim() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Creates a new string containing the characters in the specified character array. Modifying the character array after creating the string has no effect on the string.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the new string. </para>
				/// </returns>
				/// <java-name>
				/// valueOf
				/// </java-name>
				[Dot42.DexImport("valueOf", "([C)Ljava/lang/String;", AccessFlags = 9)]
				public static string ValueOf(char[] data) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Creates a new string containing the specified characters in the character array. Modifying the character array after creating the string has no effect on the string.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the new string. </para>
				/// </returns>
				/// <java-name>
				/// valueOf
				/// </java-name>
				[Dot42.DexImport("valueOf", "([CII)Ljava/lang/String;", AccessFlags = 9)]
				public static string ValueOf(char[] data, int start, int length) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Creates a new string containing the characters in the specified character array. Modifying the character array after creating the string has no effect on the string.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the new string. </para>
				/// </returns>
				/// <java-name>
				/// valueOf
				/// </java-name>
				[Dot42.DexImport("valueOf", "(C)Ljava/lang/String;", AccessFlags = 9)]
				public static string ValueOf(char data) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Creates a new string containing the characters in the specified character array. Modifying the character array after creating the string has no effect on the string.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the new string. </para>
				/// </returns>
				/// <java-name>
				/// valueOf
				/// </java-name>
				[Dot42.DexImport("valueOf", "(D)Ljava/lang/String;", AccessFlags = 9)]
				public static string ValueOf(double data) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Creates a new string containing the characters in the specified character array. Modifying the character array after creating the string has no effect on the string.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the new string. </para>
				/// </returns>
				/// <java-name>
				/// valueOf
				/// </java-name>
				[Dot42.DexImport("valueOf", "(F)Ljava/lang/String;", AccessFlags = 9)]
				public static string ValueOf(float data) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Creates a new string containing the characters in the specified character array. Modifying the character array after creating the string has no effect on the string.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the new string. </para>
				/// </returns>
				/// <java-name>
				/// valueOf
				/// </java-name>
				[Dot42.DexImport("valueOf", "(I)Ljava/lang/String;", AccessFlags = 9)]
				public static string ValueOf(int data) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Creates a new string containing the characters in the specified character array. Modifying the character array after creating the string has no effect on the string.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the new string. </para>
				/// </returns>
				/// <java-name>
				/// valueOf
				/// </java-name>
				[Dot42.DexImport("valueOf", "(J)Ljava/lang/String;", AccessFlags = 9)]
				public static string ValueOf(long data) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Creates a new string containing the characters in the specified character array. Modifying the character array after creating the string has no effect on the string.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the new string. </para>
				/// </returns>
				/// <java-name>
				/// valueOf
				/// </java-name>
				[Dot42.DexImport("valueOf", "(Ljava/lang/Object;)Ljava/lang/String;", AccessFlags = 9)]
				public static string ValueOf(object data) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Creates a new string containing the characters in the specified character array. Modifying the character array after creating the string has no effect on the string.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the new string. </para>
				/// </returns>
				/// <java-name>
				/// valueOf
				/// </java-name>
				[Dot42.DexImport("valueOf", "(Z)Ljava/lang/String;", AccessFlags = 9)]
				public static string ValueOf(bool data) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns whether the characters in the StringBuffer <c> strbuf </c> are the same as those in this string.</para><para><para>1.4 </para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the characters in <c> strbuf </c> are identical to those in this string. If they are not, <c> false </c> will be returned. </para>
				/// </returns>
				/// <java-name>
				/// contentEquals
				/// </java-name>
				[Dot42.DexImport("contentEquals", "(Ljava/lang/StringBuffer;)Z", AccessFlags = 1)]
				public bool ContentEquals(global::Java.Lang.StringBuffer strbuf) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns whether the characters in the StringBuffer <c> strbuf </c> are the same as those in this string.</para><para><para>1.4 </para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the characters in <c> strbuf </c> are identical to those in this string. If they are not, <c> false </c> will be returned. </para>
				/// </returns>
				/// <java-name>
				/// contentEquals
				/// </java-name>
				[Dot42.DexImport("contentEquals", "(Ljava/lang/CharSequence;)Z", AccessFlags = 1)]
				public bool ContentEquals(global::Java.Lang.ICharSequence strbuf) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Tests whether this string matches the given <c> regularExpression </c> . This method returns true only if the regular expression matches the <b>entire</b> input string. A common mistake is to assume that this method behaves like contains; if you want to match anywhere within the input string, you need to add <c> .* </c> to the beginning and end of your regular expression. See Pattern#matches.</para><para>If the same regular expression is to be used for multiple operations, it may be more efficient to reuse a compiled <c> Pattern </c> .</para><para><para>1.4 </para></para>        
				/// </summary>
				/// <java-name>
				/// matches
				/// </java-name>
				[Dot42.DexImport("matches", "(Ljava/lang/String;)Z", AccessFlags = 1)]
				public bool Matches(string regularExpression) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Replaces all matches for <c> regularExpression </c> within this string with the given <c> replacement </c> . See Pattern for regular expression syntax.</para><para>If the same regular expression is to be used for multiple operations, it may be more efficient to reuse a compiled <c> Pattern </c> .</para><para><para>Pattern </para><para>1.4 </para></para>        
				/// </summary>
				/// <java-name>
				/// replaceAll
				/// </java-name>
				[Dot42.DexImport("replaceAll", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1)]
				public string ReplaceAll(string regularExpression, string replacement) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Replaces the first match for <c> regularExpression </c> within this string with the given <c> replacement </c> . See Pattern for regular expression syntax.</para><para>If the same regular expression is to be used for multiple operations, it may be more efficient to reuse a compiled <c> Pattern </c> .</para><para><para>Pattern </para><para>1.4 </para></para>        
				/// </summary>
				/// <java-name>
				/// replaceFirst
				/// </java-name>
				[Dot42.DexImport("replaceFirst", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1)]
				public string ReplaceFirst(string regularExpression, string replacement) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Splits this string using the supplied <c> regularExpression </c> . Equivalent to <c> split(regularExpression, 0) </c> . See Pattern#split(CharSequence, int) for an explanation of <c> limit </c> . See Pattern for regular expression syntax.</para><para>If the same regular expression is to be used for multiple operations, it may be more efficient to reuse a compiled <c> Pattern </c> .</para><para><para>Pattern </para><para>1.4 </para></para>        
				/// </summary>
				/// <java-name>
				/// split
				/// </java-name>
				[Dot42.DexImport("split", "(Ljava/lang/String;)[Ljava/lang/String;", AccessFlags = 1)]
				public string[] Split(string regularExpression) /* MethodBuilder.Create */ 
				{
						return default(string[]);
				}

				/// <summary>
				/// <para>Splits this string using the supplied <c> regularExpression </c> . See Pattern#split(CharSequence, int) for an explanation of <c> limit </c> . See Pattern for regular expression syntax.</para><para>If the same regular expression is to be used for multiple operations, it may be more efficient to reuse a compiled <c> Pattern </c> .</para><para><para>1.4 </para></para>        
				/// </summary>
				/// <java-name>
				/// split
				/// </java-name>
				[Dot42.DexImport("split", "(Ljava/lang/String;I)[Ljava/lang/String;", AccessFlags = 1)]
				public string[] Split(string regularExpression, int limit) /* MethodBuilder.Create */ 
				{
						return default(string[]);
				}

				/// <summary>
				/// <para>Has the same result as the substring function, but is present so that string may implement the CharSequence interface.</para><para><para>java.lang.CharSequence::subSequence(int, int) </para><para>1.4 </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the subsequence requested. </para>
				/// </returns>
				/// <java-name>
				/// subSequence
				/// </java-name>
				[Dot42.DexImport("subSequence", "(II)Ljava/lang/CharSequence;", AccessFlags = 1)]
				public global::Java.Lang.ICharSequence SubSequence(int start, int end) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <summary>
				/// <para>Returns the Unicode code point at the given <c> index </c> .</para><para><para>Character::codePointAt(char[], int, int) </para><para>1.5 </para></para>        
				/// </summary>
				/// <java-name>
				/// codePointAt
				/// </java-name>
				[Dot42.DexImport("codePointAt", "(I)I", AccessFlags = 1)]
				public int CodePointAt(int index) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the Unicode code point that precedes the given <c> index </c> .</para><para><para>Character::codePointBefore(char[], int, int) </para><para>1.5 </para></para>        
				/// </summary>
				/// <java-name>
				/// codePointBefore
				/// </java-name>
				[Dot42.DexImport("codePointBefore", "(I)I", AccessFlags = 1)]
				public int CodePointBefore(int index) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Calculates the number of Unicode code points between <c> start </c> and <c> end </c> .</para><para><para>Character::codePointCount(CharSequence, int, int) </para><para>1.5 </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of Unicode code points in the subsequence. </para>
				/// </returns>
				/// <java-name>
				/// codePointCount
				/// </java-name>
				[Dot42.DexImport("codePointCount", "(II)I", AccessFlags = 1)]
				public int CodePointCount(int start, int end) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Determines if this <c> String </c> contains the sequence of characters in the <c> CharSequence </c> passed.</para><para><para>1.5 </para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the sequence of characters are contained in this string, otherwise <c> false </c> . </para>
				/// </returns>
				/// <java-name>
				/// contains
				/// </java-name>
				[Dot42.DexImport("contains", "(Ljava/lang/CharSequence;)Z", AccessFlags = 1)]
				public bool Contains(global::Java.Lang.ICharSequence cs) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns the index within this object that is offset from <c> index </c> by <c> codePointOffset </c> code points.</para><para><para>1.5 </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the index within this object that is the offset. </para>
				/// </returns>
				/// <java-name>
				/// offsetByCodePoints
				/// </java-name>
				[Dot42.DexImport("offsetByCodePoints", "(II)I", AccessFlags = 1)]
				public int OffsetByCodePoints(int index, int codePointOffset) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns a localized formatted string, using the supplied format and arguments, using the user's default locale.</para><para>If you're formatting a string other than for human consumption, you should use the <c> format(Locale, String, Object...) </c> overload and supply <c> Locale.US </c> . See "&lt;a href="../util/Locale.html::default_locale"&gt;Be wary of the default locale&lt;/a&gt;".</para><para><para>1.5 </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the formatted string. </para>
				/// </returns>
				/// <java-name>
				/// format
				/// </java-name>
				[Dot42.DexImport("format", "(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;", AccessFlags = 137)]
				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
				public static string JavaFormat(string format, params object[] args) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns a formatted string, using the supplied format and arguments, localized to the given locale.</para><para><para>1.5 </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the formatted string. </para>
				/// </returns>
				/// <java-name>
				/// format
				/// </java-name>
				[Dot42.DexImport("format", "(Ljava/util/Locale;Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;", AccessFlags = 137)]
				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
				public static string JavaFormat(global::Java.Util.Locale locale, string format, params object[] args) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the character at the specified offset in this string.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the character at the index. </para>
				/// </returns>
				/// <java-name>
				/// charAt
				/// </java-name>
				[global::System.Runtime.CompilerServices.IndexerName("Chars")]
				public char this[int index]
				{
				[Dot42.DexImport("charAt", "(I)C", AccessFlags = 1)]
						get{ return CharAt(index); }
				}

				/// <summary>
				/// <para>Returns the size of this string.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of characters in this string. </para>
				/// </returns>
				/// <java-name>
				/// length
				/// </java-name>
				public int Length
				{
				[Dot42.DexImport("length", "()I", AccessFlags = 1)]
						get{ return GetLength(); }
				}

		}

		public partial struct Byte
 /* scope: __custom__ */ 
		{
		}

		public partial class Delegate
 /* scope: __custom__ */ 
		{
		}

		public abstract partial class Enum
 /* scope: __custom__ */ 
		{
		}

		public partial struct IntPtr
 /* scope: __custom__ */ 
		{
		}

		public partial class MulticastDelegate : global::System.Delegate
 /* scope: __custom__ */ 
		{
		}

		public partial struct RuntimeArgumentHandle
 /* scope: __custom__ */ 
		{
		}

		public partial struct RuntimeFieldHandle
 /* scope: __custom__ */ 
		{
		}

		public partial struct RuntimeMethodHandle
 /* scope: __custom__ */ 
		{
		}

		public partial struct RuntimeTypeHandle
 /* scope: __custom__ */ 
		{
		}

		public partial struct UInt16
 /* scope: __custom__ */ 
		{
		}

		public partial struct UInt32
 /* scope: __custom__ */ 
		{
		}

		public partial struct UInt64
 /* scope: __custom__ */ 
		{
		}

		public partial struct UIntPtr
 /* scope: __custom__ */ 
		{
		}

		public partial class ValueType
 /* scope: __custom__ */ 
		{
		}

		/// <summary>
		/// <para><c> RuntimeException </c> is the superclass of all classes that represent exceptional conditions which occur as a result of executing an application in the VM. Unlike checked exceptions (exceptions where the type doesn't extend <c> RuntimeException </c> or Error), the compiler does not require code to handle runtime exceptions. </para>    
		/// </summary>
		/// <java-name>
		/// java/lang/RuntimeException
		/// </java-name>
		[Dot42.DexImport("java/lang/RuntimeException", AccessFlags = 33)]
		public partial class SystemException : global::System.Exception
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs a new <c> RuntimeException </c> that includes the current stack trace. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public SystemException() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a new <c> RuntimeException </c> with the current stack trace and the specified detail message.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public SystemException(string detailMessage) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a new <c> RuntimeException </c> with the current stack trace, the specified detail message and the specified cause.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public SystemException(string detailMessage, global::System.Exception throwable) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a new <c> RuntimeException </c> with the current stack trace and the specified detail message.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public SystemException(global::System.Exception detailMessage) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>The in-memory representation of a Java class. This representation serves as the starting point for querying class-related information, a process usually called "reflection". There are basically three types of <c> Class </c> instances: those representing real classes and interfaces, those representing primitive types, and those representing array classes.</para><para><h4>Class instances representing object types (classes or interfaces)</h4></para><para>These represent an ordinary class or interface as found in the class hierarchy. The name associated with these <c> Class </c> instances is simply the fully qualified class name of the class or interface that it represents. In addition to this human-readable name, each class is also associated by a so-called <b>signature</b>, which is the letter "L", followed by the class name and a semicolon (";"). The signature is what the runtime system uses internally for identifying the class (for example in a DEX file). </para><para><h4>Classes representing primitive types</h4></para><para>These represent the standard Java primitive types and hence share their names (for example "int" for the <c> int </c> primitive type). Although it is not possible to create new instances based on these <c> Class </c> instances, they are still useful for providing reflection information, and as the component type of array classes. There is one <c> Class </c> instance for each primitive type, and their signatures are: </para><para><ul><li><para><c> B </c> representing the <c> byte </c> primitive type </para></li><li><para><c> S </c> representing the <c> short </c> primitive type </para></li><li><para><c> I </c> representing the <c> int </c> primitive type </para></li><li><para><c> J </c> representing the <c> long </c> primitive type </para></li><li><para><c> F </c> representing the <c> float </c> primitive type </para></li><li><para><c> D </c> representing the <c> double </c> primitive type </para></li><li><para><c> C </c> representing the <c> char </c> primitive type </para></li><li><para><c> Z </c> representing the <c> boolean </c> primitive type </para></li><li><para><c> V </c> representing void function return values </para></li></ul></para><para><h4>Classes representing array classes</h4></para><para>These represent the classes of Java arrays. There is one such <c> Class </c> instance per combination of array leaf component type and arity (number of dimensions). In this case, the name associated with the <c> Class </c> consists of one or more left square brackets (one per dimension in the array) followed by the signature of the class representing the leaf component type, which can be either an object type or a primitive type. The signature of a <c> Class </c> representing an array type is the same as its name. Examples of array class signatures are: </para><para><ul><li><para><c> [I </c> representing the <c> int[] </c> type </para></li><li><para><c> [Ljava/lang/String; </c> representing the <c> String[] </c> type </para></li><li><para><c> [[[C </c> representing the <c> char[][][] </c> type (three dimensions!) </para></li></ul></para>    
		/// </summary>
		/// <java-name>
		/// java/lang/Class
		/// </java-name>
		[Dot42.DexImport("java/lang/Class", AccessFlags = 49, Signature = "<T:Ljava/lang/Object;>Ljava/lang/Object;Ljava/io/Serializable;Ljava/lang/reflect/" +
    "AnnotatedElement;Ljava/lang/reflect/GenericDeclaration;Ljava/lang/reflect/Type;")]
		public sealed partial class Type : global::Java.Io.ISerializable, global::Java.Lang.Reflect.IAnnotatedElement, global::Java.Lang.Reflect.IGenericDeclaration, global::Java.Lang.Reflect.IType
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal Type() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns a <c> Class </c> object which represents the class with the given name. The name should be the name of a non-primitive class, as described in the class definition. Primitive types can not be found using this method; use <c> int.class </c> or <c> Integer.TYPE </c> instead.</para><para>If the class has not yet been loaded, it is loaded and initialized first. This is done through either the class loader of the calling class or one of its parent class loaders. It is possible that a static initializer is run as a result of this call.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// forName
				/// </java-name>
				[Dot42.DexImport("forName", "(Ljava/lang/String;)Ljava/lang/Class;", AccessFlags = 9, Signature = "(Ljava/lang/String;)Ljava/lang/Class<*>;")]
				public static global::System.Type ForName(string className) /* MethodBuilder.Create */ 
				{
						return default(global::System.Type);
				}

				/// <summary>
				/// <para>Returns a <c> Class </c> object which represents the class with the given name. The name should be the name of a non-primitive class, as described in the class definition. Primitive types can not be found using this method; use <c> int.class </c> or <c> Integer.TYPE </c> instead.</para><para>If the class has not yet been loaded, it is loaded first, using the given class loader. If the class has not yet been initialized and <c> shouldInitialize </c> is true, the class will be initialized.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// forName
				/// </java-name>
				[Dot42.DexImport("forName", "(Ljava/lang/String;ZLjava/lang/ClassLoader;)Ljava/lang/Class;", AccessFlags = 9, Signature = "(Ljava/lang/String;ZLjava/lang/ClassLoader;)Ljava/lang/Class<*>;")]
				public static global::System.Type ForName(string className, bool shouldInitialize, global::Java.Lang.ClassLoader classLoader) /* MethodBuilder.Create */ 
				{
						return default(global::System.Type);
				}

				/// <summary>
				/// <para>Returns an array containing <c> Class </c> objects for all public classes and interfaces that are members of this class. This includes public members inherited from super classes and interfaces. If there are no such class members or if this object represents a primitive type then an array of length 0 is returned. </para>        
				/// </summary>
				/// <java-name>
				/// getClasses
				/// </java-name>
				[Dot42.DexImport("getClasses", "()[Ljava/lang/Class;", AccessFlags = 1, Signature = "()[Ljava/lang/Class<*>;")]
				public global::System.Type[] GetClasses() /* MethodBuilder.Create */ 
				{
						return default(global::System.Type[]);
				}

				/// <java-name>
				/// getAnnotation
				/// </java-name>
				[Dot42.DexImport("getAnnotation", "(Ljava/lang/Class;)Ljava/lang/annotation/Annotation;", AccessFlags = 1, Signature = "<A::Ljava/lang/annotation/Annotation;>(Ljava/lang/Class<TA;>;)TA;")]
				public A GetAnnotation<A>(global::System.Type annotationType) /* MethodBuilder.Create */ 
				{
						return default(A);
				}

				/// <summary>
				/// <para>Returns an array containing all the annotations of this class. If there are no annotations then an empty array is returned.</para><para><para>getDeclaredAnnotations() </para></para>        
				/// </summary>
				/// <java-name>
				/// getAnnotations
				/// </java-name>
				[Dot42.DexImport("getAnnotations", "()[Ljava/lang/annotation/Annotation;", AccessFlags = 1)]
				public global::Java.Lang.Annotation.IAnnotation[] GetAnnotations() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.Annotation.IAnnotation[]);
				}

				/// <summary>
				/// <para>Returns the canonical name of this class. If this class does not have a canonical name as defined in the Java Language Specification, then the method returns <c> null </c> . </para>        
				/// </summary>
				/// <java-name>
				/// getCanonicalName
				/// </java-name>
				[Dot42.DexImport("getCanonicalName", "()Ljava/lang/String;", AccessFlags = 1)]
				public string GetCanonicalName() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the class loader which was used to load the class represented by this <c> Class </c> . Implementations are free to return <c> null </c> for classes that were loaded by the bootstrap class loader. The Android reference implementation, though, always returns a reference to an actual class loader. </para>        
				/// </summary>
				/// <java-name>
				/// getClassLoader
				/// </java-name>
				[Dot42.DexImport("getClassLoader", "()Ljava/lang/ClassLoader;", AccessFlags = 1)]
				public global::Java.Lang.ClassLoader GetClassLoader() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ClassLoader);
				}

				/// <summary>
				/// <para>Returns a <c> Class </c> object which represents the component type if this class represents an array type. Returns <c> null </c> if this class does not represent an array type. The component type of an array type is the type of the elements of the array. </para>        
				/// </summary>
				/// <java-name>
				/// getComponentType
				/// </java-name>
				[Dot42.DexImport("getComponentType", "()Ljava/lang/Class;", AccessFlags = 257, Signature = "()Ljava/lang/Class<*>;")]
				public global::System.Type GetElementType() /* MethodBuilder.Create */ 
				{
						return default(global::System.Type);
				}

				/// <summary>
				/// <para>Returns a <c> Constructor </c> object which represents the public constructor matching the given parameter types. <c> (Class[]) null </c> is equivalent to the empty array.</para><para><para>#getDeclaredConstructor(Class[]) </para></para>        
				/// </summary>
				/// <java-name>
				/// getConstructor
				/// </java-name>
				[Dot42.DexImport("getConstructor", "([Ljava/lang/Class;)Ljava/lang/reflect/Constructor;", AccessFlags = 129, Signature = "([Ljava/lang/Class<*>;)Ljava/lang/reflect/Constructor<TT;>;")]
				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				public global::System.Reflection.ConstructorInfo JavaGetConstructor(params global::System.Type[] parameterTypes) /* MethodBuilder.Create */ 
				{
						return default(global::System.Reflection.ConstructorInfo);
				}

				/// <summary>
				/// <para>Returns an array containing <c> Constructor </c> objects for all public constructors for this <c> Class </c> . If there are no public constructors or if this <c> Class </c> represents an array class, a primitive type or void then an empty array is returned.</para><para><para>getDeclaredConstructors() </para></para>        
				/// </summary>
				/// <java-name>
				/// getConstructors
				/// </java-name>
				[Dot42.DexImport("getConstructors", "()[Ljava/lang/reflect/Constructor;", AccessFlags = 1, Signature = "()[Ljava/lang/reflect/Constructor<*>;")]
				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				public global::System.Reflection.ConstructorInfo[] JavaGetConstructors() /* MethodBuilder.Create */ 
				{
						return default(global::System.Reflection.ConstructorInfo[]);
				}

				/// <summary>
				/// <para>Returns the annotations that are directly defined on the class represented by this <c> Class </c> . Annotations that are inherited are not included in the result. If there are no annotations at all, an empty array is returned.</para><para><para>getAnnotations() </para></para>        
				/// </summary>
				/// <java-name>
				/// getDeclaredAnnotations
				/// </java-name>
				[Dot42.DexImport("getDeclaredAnnotations", "()[Ljava/lang/annotation/Annotation;", AccessFlags = 257)]
				public global::Java.Lang.Annotation.IAnnotation[] GetDeclaredAnnotations() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.Annotation.IAnnotation[]);
				}

				/// <summary>
				/// <para>Returns an array containing <c> Class </c> objects for all classes and interfaces that are declared as members of the class which this <c>       Class </c> represents. If there are no classes or interfaces declared or if this class represents an array class, a primitive type or void, then an empty array is returned. </para>        
				/// </summary>
				/// <java-name>
				/// getDeclaredClasses
				/// </java-name>
				[Dot42.DexImport("getDeclaredClasses", "()[Ljava/lang/Class;", AccessFlags = 1, Signature = "()[Ljava/lang/Class<*>;")]
				public global::System.Type[] GetDeclaredClasses() /* MethodBuilder.Create */ 
				{
						return default(global::System.Type[]);
				}

				/// <summary>
				/// <para>Returns a <c> Constructor </c> object which represents the constructor matching the given parameter types that is declared by the class represented by this <c> Class </c> . <c> (Class[]) null </c> is equivalent to the empty array.</para><para><para>#getConstructor(Class[]) </para></para>        
				/// </summary>
				/// <java-name>
				/// getDeclaredConstructor
				/// </java-name>
				[Dot42.DexImport("getDeclaredConstructor", "([Ljava/lang/Class;)Ljava/lang/reflect/Constructor;", AccessFlags = 129, Signature = "([Ljava/lang/Class<*>;)Ljava/lang/reflect/Constructor<TT;>;")]
				public global::System.Reflection.ConstructorInfo GetDeclaredConstructor(params global::System.Type[] parameterTypes) /* MethodBuilder.Create */ 
				{
						return default(global::System.Reflection.ConstructorInfo);
				}

				/// <summary>
				/// <para>Returns an array containing <c> Constructor </c> objects for all constructors declared in the class represented by this <c> Class </c> . If there are no constructors or if this <c> Class </c> represents an array class, a primitive type, or void then an empty array is returned.</para><para><para>getConstructors() </para></para>        
				/// </summary>
				/// <java-name>
				/// getDeclaredConstructors
				/// </java-name>
				[Dot42.DexImport("getDeclaredConstructors", "()[Ljava/lang/reflect/Constructor;", AccessFlags = 1, Signature = "()[Ljava/lang/reflect/Constructor<*>;")]
				public global::System.Reflection.ConstructorInfo[] GetDeclaredConstructors() /* MethodBuilder.Create */ 
				{
						return default(global::System.Reflection.ConstructorInfo[]);
				}

				/// <summary>
				/// <para>Returns a <c> Field </c> object for the field with the given name which is declared in the class represented by this <c> Class </c> .</para><para><para>getField(String) </para></para>        
				/// </summary>
				/// <java-name>
				/// getDeclaredField
				/// </java-name>
				[Dot42.DexImport("getDeclaredField", "(Ljava/lang/String;)Ljava/lang/reflect/Field;", AccessFlags = 1)]
				public global::System.Reflection.FieldInfo GetDeclaredField(string name) /* MethodBuilder.Create */ 
				{
						return default(global::System.Reflection.FieldInfo);
				}

				/// <summary>
				/// <para>Returns an array containing <c> Field </c> objects for all fields declared in the class represented by this <c> Class </c> . If there are no fields or if this <c> Class </c> represents an array class, a primitive type or void then an empty array is returned.</para><para><para>getFields() </para></para>        
				/// </summary>
				/// <java-name>
				/// getDeclaredFields
				/// </java-name>
				[Dot42.DexImport("getDeclaredFields", "()[Ljava/lang/reflect/Field;", AccessFlags = 1)]
				public global::System.Reflection.FieldInfo[] GetDeclaredFields() /* MethodBuilder.Create */ 
				{
						return default(global::System.Reflection.FieldInfo[]);
				}

				/// <summary>
				/// <para>Returns a <c> Method </c> object which represents the method matching the given name and parameter types that is declared by the class represented by this <c> Class </c> . <c> (Class[]) null </c> is equivalent to the empty array.</para><para><para>#getMethod(String, Class[]) </para></para>        
				/// </summary>
				/// <java-name>
				/// getDeclaredMethod
				/// </java-name>
				[Dot42.DexImport("getDeclaredMethod", "(Ljava/lang/String;[Ljava/lang/Class;)Ljava/lang/reflect/Method;", AccessFlags = 129, Signature = "(Ljava/lang/String;[Ljava/lang/Class<*>;)Ljava/lang/reflect/Method;")]
				public global::System.Reflection.MethodInfo GetDeclaredMethod(string name, params global::System.Type[] parameterTypes) /* MethodBuilder.Create */ 
				{
						return default(global::System.Reflection.MethodInfo);
				}

				/// <summary>
				/// <para>Returns an array containing <c> Method </c> objects for all methods declared in the class represented by this <c> Class </c> . If there are no methods or if this <c> Class </c> represents an array class, a primitive type or void then an empty array is returned.</para><para><para>getMethods() </para></para>        
				/// </summary>
				/// <java-name>
				/// getDeclaredMethods
				/// </java-name>
				[Dot42.DexImport("getDeclaredMethods", "()[Ljava/lang/reflect/Method;", AccessFlags = 1)]
				public global::System.Reflection.MethodInfo[] GetDeclaredMethods() /* MethodBuilder.Create */ 
				{
						return default(global::System.Reflection.MethodInfo[]);
				}

				/// <summary>
				/// <para>Returns the declaring <c> Class </c> of this <c> Class </c> . Returns <c> null </c> if the class is not a member of another class or if this <c> Class </c> represents an array class, a primitive type, or void. </para>        
				/// </summary>
				/// <java-name>
				/// getDeclaringClass
				/// </java-name>
				[Dot42.DexImport("getDeclaringClass", "()Ljava/lang/Class;", AccessFlags = 257, Signature = "()Ljava/lang/Class<*>;")]
				public global::System.Type GetDeclaringClass() /* MethodBuilder.Create */ 
				{
						return default(global::System.Type);
				}

				/// <summary>
				/// <para>Returns the enclosing <c> Class </c> of this <c> Class </c> . If there is no enclosing class the method returns <c> null </c> . </para>        
				/// </summary>
				/// <java-name>
				/// getEnclosingClass
				/// </java-name>
				[Dot42.DexImport("getEnclosingClass", "()Ljava/lang/Class;", AccessFlags = 257, Signature = "()Ljava/lang/Class<*>;")]
				public global::System.Type GetEnclosingClass() /* MethodBuilder.Create */ 
				{
						return default(global::System.Type);
				}

				/// <summary>
				/// <para>Returns the enclosing <c> Constructor </c> of this <c> Class </c> , if it is an anonymous or local/automatic class; otherwise <c> null </c> . </para>        
				/// </summary>
				/// <java-name>
				/// getEnclosingConstructor
				/// </java-name>
				[Dot42.DexImport("getEnclosingConstructor", "()Ljava/lang/reflect/Constructor;", AccessFlags = 257, Signature = "()Ljava/lang/reflect/Constructor<*>;")]
				public global::System.Reflection.ConstructorInfo GetEnclosingConstructor() /* MethodBuilder.Create */ 
				{
						return default(global::System.Reflection.ConstructorInfo);
				}

				/// <summary>
				/// <para>Returns the enclosing <c> Method </c> of this <c> Class </c> , if it is an anonymous or local/automatic class; otherwise <c> null </c> . </para>        
				/// </summary>
				/// <java-name>
				/// getEnclosingMethod
				/// </java-name>
				[Dot42.DexImport("getEnclosingMethod", "()Ljava/lang/reflect/Method;", AccessFlags = 257)]
				public global::System.Reflection.MethodInfo GetEnclosingMethod() /* MethodBuilder.Create */ 
				{
						return default(global::System.Reflection.MethodInfo);
				}

				/// <summary>
				/// <para>Returns the <c> enum </c> constants associated with this <c> Class </c> . Returns <c> null </c> if this <c> Class </c> does not represent an <c>       enum </c> type. </para>        
				/// </summary>
				/// <java-name>
				/// getEnumConstants
				/// </java-name>
				[Dot42.DexImport("getEnumConstants", "()[Ljava/lang/Object;", AccessFlags = 1, Signature = "()[TT;")]
				public object[] GetEnumConstants() /* MethodBuilder.Create */ 
				{
						return default(object[]);
				}

				/// <summary>
				/// <para>Returns a <c> Field </c> object which represents the public field with the given name. This method first searches the class C represented by this <c> Class </c> , then the interfaces implemented by C and finally the superclasses of C.</para><para><para>getDeclaredField(String) </para></para>        
				/// </summary>
				/// <java-name>
				/// getField
				/// </java-name>
				[Dot42.DexImport("getField", "(Ljava/lang/String;)Ljava/lang/reflect/Field;", AccessFlags = 1)]
				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				public global::System.Reflection.FieldInfo JavaGetField(string name) /* MethodBuilder.Create */ 
				{
						return default(global::System.Reflection.FieldInfo);
				}

				/// <summary>
				/// <para>Returns an array containing <c> Field </c> objects for all public fields for the class C represented by this <c> Class </c> . Fields may be declared in C, the interfaces it implements or in the superclasses of C. The elements in the returned array are in no particular order.</para><para>If there are no public fields or if this class represents an array class, a primitive type or <c> void </c> then an empty array is returned.</para><para><para>getDeclaredFields() </para></para>        
				/// </summary>
				/// <java-name>
				/// getFields
				/// </java-name>
				[Dot42.DexImport("getFields", "()[Ljava/lang/reflect/Field;", AccessFlags = 1)]
				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				public global::System.Reflection.FieldInfo[] JavaGetFields() /* MethodBuilder.Create */ 
				{
						return default(global::System.Reflection.FieldInfo[]);
				}

				/// <summary>
				/// <para>Returns the Types of the interfaces that this <c> Class </c> directly implements. If the <c> Class </c> represents a primitive type or <c>       void </c> then an empty array is returned. </para>        
				/// </summary>
				/// <java-name>
				/// getGenericInterfaces
				/// </java-name>
				[Dot42.DexImport("getGenericInterfaces", "()[Ljava/lang/reflect/Type;", AccessFlags = 1)]
				public global::Java.Lang.Reflect.IType[] GetGenericInterfaces() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.Reflect.IType[]);
				}

				/// <summary>
				/// <para>Returns the <c> Type </c> that represents the superclass of this <c>       class </c> . </para>        
				/// </summary>
				/// <java-name>
				/// getGenericSuperclass
				/// </java-name>
				[Dot42.DexImport("getGenericSuperclass", "()Ljava/lang/reflect/Type;", AccessFlags = 1)]
				public global::Java.Lang.Reflect.IType GetGenericSuperclass() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.Reflect.IType);
				}

				/// <summary>
				/// <para>Returns an array of <c> Class </c> objects that match the interfaces in the <c> implements </c> declaration of the class represented by this <c> Class </c> . The order of the elements in the array is identical to the order in the original class declaration. If the class does not implement any interfaces, an empty array is returned. </para>        
				/// </summary>
				/// <java-name>
				/// getInterfaces
				/// </java-name>
				[Dot42.DexImport("getInterfaces", "()[Ljava/lang/Class;", AccessFlags = 257, Signature = "()[Ljava/lang/Class<*>;")]
				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				public global::System.Type[] JavaGetInterfaces() /* MethodBuilder.Create */ 
				{
						return default(global::System.Type[]);
				}

				/// <summary>
				/// <para>Returns a <c> Method </c> object which represents the public method with the given name and parameter types. <c> (Class[]) null </c> is equivalent to the empty array. This method first searches the class C represented by this <c> Class </c> , then the superclasses of C and finally the interfaces implemented by C and finally the superclasses of C for a method with matching name.</para><para><para>#getDeclaredMethod(String, Class[]) </para></para>        
				/// </summary>
				/// <java-name>
				/// getMethod
				/// </java-name>
				[Dot42.DexImport("getMethod", "(Ljava/lang/String;[Ljava/lang/Class;)Ljava/lang/reflect/Method;", AccessFlags = 129, Signature = "(Ljava/lang/String;[Ljava/lang/Class<*>;)Ljava/lang/reflect/Method;")]
				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				public global::System.Reflection.MethodInfo JavaGetMethod(string name, params global::System.Type[] parameterTypes) /* MethodBuilder.Create */ 
				{
						return default(global::System.Reflection.MethodInfo);
				}

				/// <summary>
				/// <para>Returns an array containing <c> Method </c> objects for all public methods for the class C represented by this <c> Class </c> . Methods may be declared in C, the interfaces it implements or in the superclasses of C. The elements in the returned array are in no particular order.</para><para>If there are no public methods or if this <c> Class </c> represents a primitive type or <c> void </c> then an empty array is returned.</para><para><para>getDeclaredMethods() </para></para>        
				/// </summary>
				/// <java-name>
				/// getMethods
				/// </java-name>
				[Dot42.DexImport("getMethods", "()[Ljava/lang/reflect/Method;", AccessFlags = 1)]
				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				public global::System.Reflection.MethodInfo[] JavaGetMethods() /* MethodBuilder.Create */ 
				{
						return default(global::System.Reflection.MethodInfo[]);
				}

				/// <summary>
				/// <para>Returns an integer that represents the modifiers of the class represented by this <c> Class </c> . The returned value is a combination of bits defined by constants in the Modifier class. </para>        
				/// </summary>
				/// <java-name>
				/// getModifiers
				/// </java-name>
				[Dot42.DexImport("getModifiers", "()I", AccessFlags = 1)]
				public int GetModifiers() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the name of the class represented by this <c> Class </c> . For a description of the format which is used, see the class definition of Class. </para>        
				/// </summary>
				/// <java-name>
				/// getName
				/// </java-name>
				[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1)]
				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				public string JavaGetName() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the simple name of the class represented by this <c> Class </c> as defined in the source code. If there is no name (that is, the class is anonymous) then an empty string is returned. If the receiver is an array then the name of the underlying type with square braces appended (for example <c> "Integer[]" </c> ) is returned.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the simple name of the class represented by this <c> Class </c> . </para>
				/// </returns>
				/// <java-name>
				/// getSimpleName
				/// </java-name>
				[Dot42.DexImport("getSimpleName", "()Ljava/lang/String;", AccessFlags = 1)]
				public string GetSimpleName() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns null. </para>        
				/// </summary>
				/// <java-name>
				/// getProtectionDomain
				/// </java-name>
				[Dot42.DexImport("getProtectionDomain", "()Ljava/security/ProtectionDomain;", AccessFlags = 1)]
				public global::Java.Security.ProtectionDomain GetProtectionDomain() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.ProtectionDomain);
				}

				/// <summary>
				/// <para>Returns the URL of the given resource, or null if the resource is not found. The mapping between the resource name and the URL is managed by the class' class loader.</para><para><para>ClassLoader </para></para>        
				/// </summary>
				/// <java-name>
				/// getResource
				/// </java-name>
				[Dot42.DexImport("getResource", "(Ljava/lang/String;)Ljava/net/URL;", AccessFlags = 1)]
				public global::Java.Net.URL GetResource(string resourceName) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.URL);
				}

				/// <summary>
				/// <para>Returns a read-only stream for the contents of the given resource, or null if the resource is not found. The mapping between the resource name and the stream is managed by the class' class loader.</para><para><para>ClassLoader </para></para>        
				/// </summary>
				/// <java-name>
				/// getResourceAsStream
				/// </java-name>
				[Dot42.DexImport("getResourceAsStream", "(Ljava/lang/String;)Ljava/io/InputStream;", AccessFlags = 1)]
				public global::Java.Io.InputStream GetResourceAsStream(string resourceName) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.InputStream);
				}

				/// <summary>
				/// <para>Returns null. (On Android, a <c> ClassLoader </c> can load classes from multiple dex files. All classes from any given dex file will have the same signers, but different dex files may have different signers. This does not fit well with the original <c> ClassLoader </c> -based model of <c> getSigners </c> .) </para>        
				/// </summary>
				/// <java-name>
				/// getSigners
				/// </java-name>
				[Dot42.DexImport("getSigners", "()[Ljava/lang/Object;", AccessFlags = 1)]
				public object[] GetSigners() /* MethodBuilder.Create */ 
				{
						return default(object[]);
				}

				/// <summary>
				/// <para>Returns the <c> Class </c> object which represents the superclass of the class represented by this <c> Class </c> . If this <c> Class </c> represents the <c> Object </c> class, a primitive type, an interface or void then the method returns <c> null </c> . If this <c> Class </c> represents an array class then the <c> Object </c> class is returned. </para>        
				/// </summary>
				/// <java-name>
				/// getSuperclass
				/// </java-name>
				[Dot42.DexImport("getSuperclass", "()Ljava/lang/Class;", AccessFlags = 257, Signature = "()Ljava/lang/Class<-TT;>;")]
				public global::System.Type GetSuperclass() /* MethodBuilder.Create */ 
				{
						return default(global::System.Type);
				}

				/// <summary>
				/// <para>Returns an array containing <c> TypeVariable </c> objects for type variables declared by the generic class represented by this <c>       Class </c> . Returns an empty array if the class is not generic. </para>        
				/// </summary>
				/// <java-name>
				/// getTypeParameters
				/// </java-name>
				[Dot42.DexImport("getTypeParameters", "()[Ljava/lang/reflect/TypeVariable;", AccessFlags = 33, Signature = "()[Ljava/lang/reflect/TypeVariable<Ljava/lang/Class<TT;>;>;")]
				public global::Java.Lang.Reflect.ITypeVariable<global::System.Type>[] GetTypeParameters() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.Reflect.ITypeVariable<global::System.Type>[]);
				}

				/// <summary>
				/// <para>Tests whether this <c> Class </c> represents an annotation class. </para>        
				/// </summary>
				/// <java-name>
				/// isAnnotation
				/// </java-name>
				[Dot42.DexImport("isAnnotation", "()Z", AccessFlags = 1)]
				public bool GetIsAnnotation() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Indicates whether or not this element has an annotation with the specified annotation type (including inherited annotations).</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the annotation exists, <c> false </c> otherwise </para>
				/// </returns>
				/// <java-name>
				/// isAnnotationPresent
				/// </java-name>
				[Dot42.DexImport("isAnnotationPresent", "(Ljava/lang/Class;)Z", AccessFlags = 1, Signature = "(Ljava/lang/Class<+Ljava/lang/annotation/Annotation;>;)Z")]
				public bool IsAnnotationPresent(global::System.Type annotationType) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Tests whether the class represented by this <c> Class </c> is anonymous. </para>        
				/// </summary>
				/// <java-name>
				/// isAnonymousClass
				/// </java-name>
				[Dot42.DexImport("isAnonymousClass", "()Z", AccessFlags = 257)]
				public bool GetIsAnonymousClass() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Tests whether the class represented by this <c> Class </c> is an array class. </para>        
				/// </summary>
				/// <java-name>
				/// isArray
				/// </java-name>
				[Dot42.DexImport("isArray", "()Z", AccessFlags = 1)]
				public bool GetIsArray() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Tests whether the given class type can be converted to the class represented by this <c> Class </c> . Conversion may be done via an identity conversion or a widening reference conversion (if either the receiver or the argument represent primitive types, only the identity conversion applies).</para><para></para>        
				/// </summary>
				/// <java-name>
				/// isAssignableFrom
				/// </java-name>
				[Dot42.DexImport("isAssignableFrom", "(Ljava/lang/Class;)Z", AccessFlags = 257, Signature = "(Ljava/lang/Class<*>;)Z")]
				public bool IsAssignableFrom(global::System.Type c) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Tests whether the class represented by this <c> Class </c> is an <c> enum </c> . </para>        
				/// </summary>
				/// <java-name>
				/// isEnum
				/// </java-name>
				[Dot42.DexImport("isEnum", "()Z", AccessFlags = 1)]
				public bool GetIsEnum() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Tests whether the given object can be cast to the class represented by this <c> Class </c> . This is the runtime version of the <c> instanceof </c> operator.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if <c> object </c> can be cast to the type represented by this <c> Class </c> ; <c> false </c> if <c>               object </c> is <c> null </c> or cannot be cast. </para>
				/// </returns>
				/// <java-name>
				/// isInstance
				/// </java-name>
				[Dot42.DexImport("isInstance", "(Ljava/lang/Object;)Z", AccessFlags = 257)]
				public bool IsInstance(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Tests whether this <c> Class </c> represents an interface. </para>        
				/// </summary>
				/// <java-name>
				/// isInterface
				/// </java-name>
				[Dot42.DexImport("isInterface", "()Z", AccessFlags = 257)]
				public bool GetIsInterface() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Tests whether the class represented by this <c> Class </c> is defined locally. </para>        
				/// </summary>
				/// <java-name>
				/// isLocalClass
				/// </java-name>
				[Dot42.DexImport("isLocalClass", "()Z", AccessFlags = 1)]
				public bool GetIsLocalClass() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Tests whether the class represented by this <c> Class </c> is a member class. </para>        
				/// </summary>
				/// <java-name>
				/// isMemberClass
				/// </java-name>
				[Dot42.DexImport("isMemberClass", "()Z", AccessFlags = 1)]
				public bool GetIsMemberClass() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Tests whether this <c> Class </c> represents a primitive type. </para>        
				/// </summary>
				/// <java-name>
				/// isPrimitive
				/// </java-name>
				[Dot42.DexImport("isPrimitive", "()Z", AccessFlags = 257)]
				public bool GetIsPrimitive() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Tests whether this <c> Class </c> represents a synthetic type. </para>        
				/// </summary>
				/// <java-name>
				/// isSynthetic
				/// </java-name>
				[Dot42.DexImport("isSynthetic", "()Z", AccessFlags = 1)]
				public bool GetIsSynthetic() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns a new instance of the class represented by this <c> Class </c> , created by invoking the default (that is, zero-argument) constructor. If there is no such constructor, or if the creation fails (either because of a lack of available memory or because an exception is thrown by the constructor), an <c> InstantiationException </c> is thrown. If the default constructor exists but is not accessible from the context where this method is invoked, an <c> IllegalAccessException </c> is thrown.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// newInstance
				/// </java-name>
				[Dot42.DexImport("newInstance", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TT;")]
				public object NewInstance() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the <c> Package </c> of which the class represented by this <c> Class </c> is a member. Returns <c> null </c> if no <c> Package </c> object was created by the class loader of the class. </para>        
				/// </summary>
				/// <java-name>
				/// getPackage
				/// </java-name>
				[Dot42.DexImport("getPackage", "()Ljava/lang/Package;", AccessFlags = 1)]
				public global::Java.Lang.Package GetPackage() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.Package);
				}

				/// <summary>
				/// <para>Returns the assertion status for the class represented by this <c>       Class </c> . Assertion is enabled / disabled based on the class loader, package or class default at runtime. </para>        
				/// </summary>
				/// <java-name>
				/// desiredAssertionStatus
				/// </java-name>
				[Dot42.DexImport("desiredAssertionStatus", "()Z", AccessFlags = 257)]
				public bool DesiredAssertionStatus() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Casts this <c> Class </c> to represent a subclass of the given class. If successful, this <c> Class </c> is returned; otherwise a <c>       ClassCastException </c> is thrown.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// asSubclass
				/// </java-name>
				[Dot42.DexImport("asSubclass", "(Ljava/lang/Class;)Ljava/lang/Class;", AccessFlags = 1, Signature = "<U:Ljava/lang/Object;>(Ljava/lang/Class<TU;>;)Ljava/lang/Class<+TU;>;")]
				public global::System.Type AsSubclass<U>(global::System.Type c) /* MethodBuilder.Create */ 
				{
						return default(global::System.Type);
				}

				/// <summary>
				/// <para>Casts the given object to the type represented by this <c> Class </c> . If the object is <c> null </c> then the result is also <c> null </c> .</para><para></para>        
				/// </summary>
				/// <java-name>
				/// cast
				/// </java-name>
				[Dot42.DexImport("cast", "(Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1, Signature = "(Ljava/lang/Object;)TT;")]
				public object Cast(object obj) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				[Dot42.DexImport("java/lang/reflect/AnnotatedElement", "getAnnotation", "(Ljava/lang/Class;)Ljava/lang/annotation/Annotation;", AccessFlags = 1025, Signature = "<T::Ljava/lang/annotation/Annotation;>(Ljava/lang/Class<TT;>;)TT;")]
				T global::Java.Lang.Reflect.IAnnotatedElement.GetAnnotation<T>(global::System.Type annotationType) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(T);
				}

				[Dot42.DexImport("java/lang/reflect/GenericDeclaration", "getTypeParameters", "()[Ljava/lang/reflect/TypeVariable;", AccessFlags = 1025, Signature = "()[Ljava/lang/reflect/TypeVariable<*>;")]
				global::Java.Lang.Reflect.ITypeVariable<object>[] global::Java.Lang.Reflect.IGenericDeclaration.GetTypeParameters() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Java.Lang.Reflect.ITypeVariable<object>[]);
				}

				/// <summary>
				/// <para>Tests whether this <c> Class </c> represents an annotation class. </para>        
				/// </summary>
				/// <java-name>
				/// isAnnotation
				/// </java-name>
				public bool IsAnnotation
				{
				[Dot42.DexImport("isAnnotation", "()Z", AccessFlags = 1)]
						get{ return GetIsAnnotation(); }
				}

				/// <summary>
				/// <para>Tests whether the class represented by this <c> Class </c> is anonymous. </para>        
				/// </summary>
				/// <java-name>
				/// isAnonymousClass
				/// </java-name>
				public bool IsAnonymousClass
				{
				[Dot42.DexImport("isAnonymousClass", "()Z", AccessFlags = 257)]
						get{ return GetIsAnonymousClass(); }
				}

				/// <summary>
				/// <para>Tests whether the class represented by this <c> Class </c> is an array class. </para>        
				/// </summary>
				/// <java-name>
				/// isArray
				/// </java-name>
				public bool IsArray
				{
				[Dot42.DexImport("isArray", "()Z", AccessFlags = 1)]
						get{ return GetIsArray(); }
				}

				/// <summary>
				/// <para>Tests whether the class represented by this <c> Class </c> is an <c> enum </c> . </para>        
				/// </summary>
				/// <java-name>
				/// isEnum
				/// </java-name>
				public bool IsEnum
				{
				[Dot42.DexImport("isEnum", "()Z", AccessFlags = 1)]
						get{ return GetIsEnum(); }
				}

				/// <summary>
				/// <para>Tests whether this <c> Class </c> represents an interface. </para>        
				/// </summary>
				/// <java-name>
				/// isInterface
				/// </java-name>
				public bool IsInterface
				{
				[Dot42.DexImport("isInterface", "()Z", AccessFlags = 257)]
						get{ return GetIsInterface(); }
				}

				/// <summary>
				/// <para>Tests whether the class represented by this <c> Class </c> is defined locally. </para>        
				/// </summary>
				/// <java-name>
				/// isLocalClass
				/// </java-name>
				public bool IsLocalClass
				{
				[Dot42.DexImport("isLocalClass", "()Z", AccessFlags = 1)]
						get{ return GetIsLocalClass(); }
				}

				/// <summary>
				/// <para>Tests whether the class represented by this <c> Class </c> is a member class. </para>        
				/// </summary>
				/// <java-name>
				/// isMemberClass
				/// </java-name>
				public bool IsMemberClass
				{
				[Dot42.DexImport("isMemberClass", "()Z", AccessFlags = 1)]
						get{ return GetIsMemberClass(); }
				}

				/// <summary>
				/// <para>Tests whether this <c> Class </c> represents a primitive type. </para>        
				/// </summary>
				/// <java-name>
				/// isPrimitive
				/// </java-name>
				public bool IsPrimitive
				{
				[Dot42.DexImport("isPrimitive", "()Z", AccessFlags = 257)]
						get{ return GetIsPrimitive(); }
				}

				/// <summary>
				/// <para>Tests whether this <c> Class </c> represents a synthetic type. </para>        
				/// </summary>
				/// <java-name>
				/// isSynthetic
				/// </java-name>
				public bool IsSynthetic
				{
				[Dot42.DexImport("isSynthetic", "()Z", AccessFlags = 1)]
						get{ return GetIsSynthetic(); }
				}

		}

		/// <summary>
		/// <para>Thrown when a program attempts to store an element of an incompatible type in an array. </para>    
		/// </summary>
		/// <java-name>
		/// java/lang/ArrayStoreException
		/// </java-name>
		[Dot42.DexImport("java/lang/ArrayStoreException", AccessFlags = 33)]
		public partial class ArrayTypeMismatchException : global::System.SystemException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs a new <c> ArrayStoreException </c> that includes the current stack trace. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ArrayTypeMismatchException() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a new <c> ArrayStoreException </c> with the current stack trace and the specified detail message.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public ArrayTypeMismatchException(string detailMessage) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>Thrown when the VM notices that a program tries to reference, on a class or object, a method that does not exist. </para>    
		/// </summary>
		/// <java-name>
		/// java/lang/NoSuchMethodException
		/// </java-name>
		[Dot42.DexImport("java/lang/NoSuchMethodException", AccessFlags = 33)]
		public partial class MissingMethodException : global::System.Exception
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs a new <c> NoSuchMethodException </c> that includes the current stack trace. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public MissingMethodException() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a new <c> NoSuchMethodException </c> with the current stack trace and the specified detail message.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public MissingMethodException(string detailMessage) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>Thrown when the depth of the stack of the running program exceeds some platform or VM specific limit. Typically, this will occur only when a program becomes infinitely recursive, but it can also occur in correctly written (but deeply recursive) programs. </para>    
		/// </summary>
		/// <java-name>
		/// java/lang/StackOverflowError
		/// </java-name>
		[Dot42.DexImport("java/lang/StackOverflowError", AccessFlags = 33)]
		public partial class StackOverflowException : global::Java.Lang.VirtualMachineError
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs a new <c> StackOverflowError </c> that includes the current stack trace. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public StackOverflowException() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a new <c> StackOverflowError </c> with the current stack trace and the specified detail message.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public StackOverflowException(string detailMessage) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>The superclass of all classes which can be thrown by the VM. The two direct subclasses are recoverable exceptions (<c> Exception </c> ) and unrecoverable errors (<c> Error </c> ). This class provides common methods for accessing a string message which provides extra information about the circumstances in which the <c> Throwable </c> was created (basically an error message in most cases), and for saving a stack trace (that is, a record of the call stack at a particular point in time) which can be printed later. </para><para>A <c> Throwable </c> can also include a cause, which is a nested <c>   Throwable </c> that represents the original problem that led to this <c>   Throwable </c> . It is often used for wrapping various types of errors into a common <c> Throwable </c> without losing the detailed original error information. When printing the stack trace, the trace of the cause is included.</para><para><para>Error </para><simplesectsep></simplesectsep><para>Exception </para><simplesectsep></simplesectsep><para>RuntimeException </para></para>    
		/// </summary>
		/// <java-name>
		/// java/lang/Throwable
		/// </java-name>
		[Dot42.DexImport("java/lang/Throwable", AccessFlags = 33)]
		public partial class Exception : global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs a new <c> Throwable </c> that includes the current stack trace. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Exception() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a new <c> Throwable </c> with the current stack trace and the specified detail message.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public Exception(string detailMessage) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a new <c> Throwable </c> with the current stack trace, the specified detail message and the specified cause.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public Exception(string detailMessage, global::System.Exception throwable) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a new <c> Throwable </c> with the current stack trace and the specified detail message.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public Exception(global::System.Exception detailMessage) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Records the stack trace from the point where this method has been called to this <c> Throwable </c> . This method is invoked by the <c> Throwable </c> constructors.</para><para>This method is public so that code (such as an RPC system) which catches a <c> Throwable </c> and then re-throws it can replace the construction-time stack trace with a stack trace from the location where the exception was re-thrown, by <b>calling</b> <c> fillInStackTrace </c> .</para><para>This method is non-final so that non-Java language implementations can disable VM stack traces for their language. Filling in the stack trace is relatively expensive. <b>Overriding</b> this method in the root of a language's exception hierarchy allows the language to avoid paying for something it doesn't need.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>this <c> Throwable </c> instance. </para>
				/// </returns>
				/// <java-name>
				/// fillInStackTrace
				/// </java-name>
				[Dot42.DexImport("fillInStackTrace", "()Ljava/lang/Throwable;", AccessFlags = 1)]
				public virtual global::System.Exception FillInStackTrace() /* MethodBuilder.Create */ 
				{
						return default(global::System.Exception);
				}

				/// <summary>
				/// <para>Returns the extra information message which was provided when this <c> Throwable </c> was created. Returns <c> null </c> if no message was provided at creation time.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>this <c> Throwable </c> 's detail message. </para>
				/// </returns>
				/// <java-name>
				/// getMessage
				/// </java-name>
				[Dot42.DexImport("getMessage", "()Ljava/lang/String;", AccessFlags = 1)]
				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				public virtual string GetMessage() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the extra information message which was provided when this <c> Throwable </c> was created. Returns <c> null </c> if no message was provided at creation time. Subclasses may override this method to return localized text for the message. Android returns the regular detail message.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>this <c> Throwable </c> 's localized detail message. </para>
				/// </returns>
				/// <java-name>
				/// getLocalizedMessage
				/// </java-name>
				[Dot42.DexImport("getLocalizedMessage", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetLocalizedMessage() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the array of stack trace elements of this <c> Throwable </c> . Each <c> StackTraceElement </c> represents an entry in the call stack. The element at position 0 is the top of the stack, that is, the stack frame where this <c> Throwable </c> is thrown.</para><para><para>printStackTrace() </para></para>        
				/// </summary>
				/// <returns>
				/// <para>a copy of the array of <c> StackTraceElement </c> s representing the call stack. Changes in the array obtained from this call will not change the call stack stored in this <c> Throwable </c> . </para>
				/// </returns>
				/// <java-name>
				/// getStackTrace
				/// </java-name>
				[Dot42.DexImport("getStackTrace", "()[Ljava/lang/StackTraceElement;", AccessFlags = 1)]
				public virtual global::Java.Lang.StackTraceElement[] GetStackTrace() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.StackTraceElement[]);
				}

				/// <summary>
				/// <para>Sets the array of stack trace elements. Each <c> StackTraceElement </c> represents an entry in the call stack. A copy of the specified array is stored in this <c> Throwable </c> . will be returned by <c>       getStackTrace() </c> and printed by <c> printStackTrace() </c> .</para><para><para>printStackTrace() </para></para>        
				/// </summary>
				/// <java-name>
				/// setStackTrace
				/// </java-name>
				[Dot42.DexImport("setStackTrace", "([Ljava/lang/StackTraceElement;)V", AccessFlags = 1)]
				public virtual void SetStackTrace(global::Java.Lang.StackTraceElement[] trace) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Writes a printable representation of this <c> Throwable </c> 's stack trace to the <c> System.err </c> stream. </para>        
				/// </summary>
				/// <java-name>
				/// printStackTrace
				/// </java-name>
				[Dot42.DexImport("printStackTrace", "()V", AccessFlags = 1)]
				public virtual void PrintStackTrace() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Writes a printable representation of this <c> Throwable </c> 's stack trace to the specified print stream. If the <c> Throwable </c> contains a cause, the method will be invoked recursively for the nested <c> Throwable </c> .</para><para></para>        
				/// </summary>
				/// <java-name>
				/// printStackTrace
				/// </java-name>
				[Dot42.DexImport("printStackTrace", "(Ljava/io/PrintStream;)V", AccessFlags = 1)]
				public virtual void PrintStackTrace(global::Java.Io.PrintStream err) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Writes a printable representation of this <c> Throwable </c> 's stack trace to the specified print stream. If the <c> Throwable </c> contains a cause, the method will be invoked recursively for the nested <c> Throwable </c> .</para><para></para>        
				/// </summary>
				/// <java-name>
				/// printStackTrace
				/// </java-name>
				[Dot42.DexImport("printStackTrace", "(Ljava/io/PrintWriter;)V", AccessFlags = 1)]
				public virtual void PrintStackTrace(global::Java.Io.PrintWriter err) /* MethodBuilder.Create */ 
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

				/// <summary>
				/// <para>Initializes the cause of this <c> Throwable </c> . The cause can only be initialized once.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>this <c> Throwable </c> instance. </para>
				/// </returns>
				/// <java-name>
				/// initCause
				/// </java-name>
				[Dot42.DexImport("initCause", "(Ljava/lang/Throwable;)Ljava/lang/Throwable;", AccessFlags = 1)]
				public virtual global::System.Exception InitCause(global::System.Exception throwable) /* MethodBuilder.Create */ 
				{
						return default(global::System.Exception);
				}

				/// <summary>
				/// <para>Returns the cause of this <c> Throwable </c> , or <c> null </c> if there is no cause.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Throwable this <c> Throwable </c> 's cause. </para>
				/// </returns>
				/// <java-name>
				/// getCause
				/// </java-name>
				[Dot42.DexImport("getCause", "()Ljava/lang/Throwable;", AccessFlags = 1)]
				public virtual global::System.Exception GetCause() /* MethodBuilder.Create */ 
				{
						return default(global::System.Exception);
				}

				/// <summary>
				/// <para>Returns the extra information message which was provided when this <c> Throwable </c> was created. Returns <c> null </c> if no message was provided at creation time. Subclasses may override this method to return localized text for the message. Android returns the regular detail message.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>this <c> Throwable </c> 's localized detail message. </para>
				/// </returns>
				/// <java-name>
				/// getLocalizedMessage
				/// </java-name>
				public string LocalizedMessage
				{
				[Dot42.DexImport("getLocalizedMessage", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetLocalizedMessage(); }
				}

				/// <summary>
				/// <para>Returns the array of stack trace elements of this <c> Throwable </c> . Each <c> StackTraceElement </c> represents an entry in the call stack. The element at position 0 is the top of the stack, that is, the stack frame where this <c> Throwable </c> is thrown.</para><para><para>printStackTrace() </para></para>        
				/// </summary>
				/// <returns>
				/// <para>a copy of the array of <c> StackTraceElement </c> s representing the call stack. Changes in the array obtained from this call will not change the call stack stored in this <c> Throwable </c> . </para>
				/// </returns>
				/// <java-name>
				/// getStackTrace
				/// </java-name>
				public global::Java.Lang.StackTraceElement[] JavaStackTrace
				{
				[Dot42.DexImport("getStackTrace", "()[Ljava/lang/StackTraceElement;", AccessFlags = 1)]
						get{ return GetStackTrace(); }
				[Dot42.DexImport("setStackTrace", "([Ljava/lang/StackTraceElement;)V", AccessFlags = 1)]
						set{ SetStackTrace(value); }
				}

				/// <summary>
				/// <para>Returns the cause of this <c> Throwable </c> , or <c> null </c> if there is no cause.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Throwable this <c> Throwable </c> 's cause. </para>
				/// </returns>
				/// <java-name>
				/// getCause
				/// </java-name>
				public global::System.Exception InnerException
				{
				[Dot42.DexImport("getCause", "()Ljava/lang/Throwable;", AccessFlags = 1)]
						get{ return GetCause(); }
				}

		}

		/// <summary>
		/// <para>This interface should be implemented by all classes that wish to define a <b>natural order</b> of their instances. java.util.Collections#sort and <c> java.util.Arrays#sort </c> can then be used to automatically sort lists of classes that implement this interface. </para><para>The order rule must be both transitive (if <c> x.compareTo(y) &lt; 0 </c> and <c> y.compareTo(z) &lt; 0 </c> , then <c> x.compareTo(z) &lt; 0 </c> must hold) and invertible (the sign of the result of x.compareTo(y) must be equal to the negation of the sign of the result of y.compareTo(x) for all combinations of x and y). </para><para>In addition, it is recommended (but not required) that if and only if the result of x.compareTo(y) is zero, then the result of x.equals(y) should be <c> true </c> . </para>    
		/// </summary>
		/// <java-name>
		/// java/lang/Comparable
		/// </java-name>
		[Dot42.DexImport("java/lang/Comparable", AccessFlags = 1537, Signature = "<T:Ljava/lang/Object;>Ljava/lang/Object;")]
		public partial interface IComparable<T>
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Compares this object to the specified object to determine their relative order.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a negative integer if this instance is less than <c> another </c> ; a positive integer if this instance is greater than <c> another </c> ; 0 if this instance has the same order as <c> another </c> . </para>
				/// </returns>
				/// <java-name>
				/// compareTo
				/// </java-name>
				[Dot42.DexImport("compareTo", "(Ljava/lang/Object;)I", AccessFlags = 1025, Signature = "(TT;)I")]
				int CompareTo(T another) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>Placeholder class for the Java keyword <c> void </c> .</para><para><para>1.1 </para></para>    
		/// </summary>
		/// <java-name>
		/// java/lang/Void
		/// </java-name>
		[Dot42.DexImport("java/lang/Void", AccessFlags = 49)]
		public partial struct Void
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>The Class object that represents the primitive type <c> void </c> . </para>        
				/// </summary>
				/// <java-name>
				/// TYPE
				/// </java-name>
				[Dot42.DexImport("TYPE", "Ljava/lang/Class;", AccessFlags = 25)]
				public static readonly global::System.Type TYPE;
		}

		/// <summary>
		/// <para>Thrown when the VM notices that a program tries to reference, on a class or object, a field that does not exist. </para>    
		/// </summary>
		/// <java-name>
		/// java/lang/NoSuchFieldException
		/// </java-name>
		[Dot42.DexImport("java/lang/NoSuchFieldException", AccessFlags = 33)]
		public partial class MissingFieldException : global::System.Exception
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs a new <c> NoSuchFieldException </c> that includes the current stack trace. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public MissingFieldException() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a new <c> NoSuchFieldException </c> with the current stack trace and the specified detail message.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public MissingFieldException(string detailMessage) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>The wrapper for the primitive type <c> float </c> .</para><para><para>java.lang.Number </para><para>1.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// java/lang/Float
		/// </java-name>
		[Dot42.DexImport("java/lang/Float", AccessFlags = 49, Signature = "Ljava/lang/Number;Ljava/lang/Comparable<Ljava/lang/Float;>;")]
		public partial struct Single : global::System.IComparable<float?>
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constant for the maximum <c> float </c> value, (2 - 2<span>-23</span>) * 2<span>127</span>. </para>        
				/// </summary>
				/// <java-name>
				/// MAX_VALUE
				/// </java-name>
				[Dot42.DexImport("MAX_VALUE", "F", AccessFlags = 25)]
				public const float MaxValue = 3.402823E+38F;
				/// <summary>
				/// <para>Constant for the minimum <c> float </c> value, 2<span>-149</span>. </para>        
				/// </summary>
				/// <java-name>
				/// MIN_VALUE
				/// </java-name>
				[Dot42.DexImport("MIN_VALUE", "F", AccessFlags = 25)]
				public const float Epsilon = 1.401298E-45F;
				/// <summary>
				/// <para>Constant for the Not-a-Number (NaN) value of the <c> float </c> type. </para>        
				/// </summary>
				/// <java-name>
				/// NaN
				/// </java-name>
				[Dot42.DexImport("NaN", "F", AccessFlags = 25)]
				public const float NaN = 0.0f / 0.0f;
				/// <summary>
				/// <para>Constant for the positive infinity value of the <c> float </c> type. </para>        
				/// </summary>
				/// <java-name>
				/// POSITIVE_INFINITY
				/// </java-name>
				[Dot42.DexImport("POSITIVE_INFINITY", "F", AccessFlags = 25)]
				public static readonly float PositiveInfinity;
				/// <summary>
				/// <para>Constant for the negative infinity value of the <c> float </c> type. </para>        
				/// </summary>
				/// <java-name>
				/// NEGATIVE_INFINITY
				/// </java-name>
				[Dot42.DexImport("NEGATIVE_INFINITY", "F", AccessFlags = 25)]
				public static readonly float NegativeInfinity;
				/// <summary>
				/// <para>Constant for the smallest positive normal value of the <c> float </c> type.</para><para><para>1.6 </para></para>        
				/// </summary>
				/// <java-name>
				/// MIN_NORMAL
				/// </java-name>
				[Dot42.DexImport("MIN_NORMAL", "F", AccessFlags = 25)]
				public const float MIN_NORMAL = 1.175494E-38F;
				/// <summary>
				/// <para>Maximum base-2 exponent that a finite value of the <c> float </c> type may have. Equal to <c> Math.getExponent(Float.MAX_VALUE) </c> .</para><para><para>1.6 </para></para>        
				/// </summary>
				/// <java-name>
				/// MAX_EXPONENT
				/// </java-name>
				[Dot42.DexImport("MAX_EXPONENT", "I", AccessFlags = 25)]
				public const int MAX_EXPONENT = 127;
				/// <summary>
				/// <para>Minimum base-2 exponent that a normal value of the <c> float </c> type may have. Equal to <c> Math.getExponent(Float.MIN_NORMAL) </c> .</para><para><para>1.6 </para></para>        
				/// </summary>
				/// <java-name>
				/// MIN_EXPONENT
				/// </java-name>
				[Dot42.DexImport("MIN_EXPONENT", "I", AccessFlags = 25)]
				public const int MIN_EXPONENT = -126;
				/// <summary>
				/// <para>The Class object that represents the primitive type <c>       float </c> .</para><para><para>1.1 </para></para>        
				/// </summary>
				/// <java-name>
				/// TYPE
				/// </java-name>
				[Dot42.DexImport("TYPE", "Ljava/lang/Class;", AccessFlags = 25)]
				public static readonly global::System.Type TYPE;
				/// <summary>
				/// <para>Constant for the number of bits needed to represent a <c> float </c> in two's complement form.</para><para><para>1.5 </para></para>        
				/// </summary>
				/// <java-name>
				/// SIZE
				/// </java-name>
				[Dot42.DexImport("SIZE", "I", AccessFlags = 25)]
				public const int SIZE = 32;
				/// <summary>
				/// <para>Constructs a new <c> Float </c> with the specified primitive float value.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(F)V", AccessFlags = 1)]
				public Single(float value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a new <c> Float </c> with the specified primitive float value.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(D)V", AccessFlags = 1)]
				public Single(double value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a new <c> Float </c> with the specified primitive float value.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public Single(string value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Compares this object to the specified float object to determine their relative order. There are two special cases: <ul><li><para><c> Float.NaN </c> is equal to <c> Float.NaN </c> and it is greater than any other float value, including <c> Float.POSITIVE_INFINITY </c> ; </para></li><li><para>+0.0f is greater than -0.0f </para></li></ul></para><para><para>java.lang.Comparable </para><para>1.2 </para></para>        
				/// </summary>
				/// <returns>
				/// <para>a negative value if the value of this float is less than the value of <c> object </c> ; 0 if the value of this float and the value of <c> object </c> are equal; a positive value if the value of this float is greater than the value of <c> object </c> . </para>
				/// </returns>
				/// <java-name>
				/// compareTo
				/// </java-name>
				[Dot42.DexImport("compareTo", "(Ljava/lang/Float;)I", AccessFlags = 1)]
				public int CompareTo(float? @object) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns this object's value as a byte. Might involve rounding and/or truncating the value, so it fits into a byte.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the primitive byte value of this object. </para>
				/// </returns>
				/// <java-name>
				/// byteValue
				/// </java-name>
				[Dot42.DexImport("byteValue", "()B", AccessFlags = 1)]
				public sbyte ByteValue() /* MethodBuilder.Create */ 
				{
						return default(sbyte);
				}

				/// <summary>
				/// <para>Returns this object's value as a double. Might involve rounding.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the primitive double value of this object. </para>
				/// </returns>
				/// <java-name>
				/// doubleValue
				/// </java-name>
				[Dot42.DexImport("doubleValue", "()D", AccessFlags = 1)]
				public double DoubleValue() /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <summary>
				/// <para>Tests this double for equality with <c> object </c> . To be equal, <c> object </c> must be an instance of <c> Float </c> and <c> floatToIntBits </c> must give the same value for both objects.</para><para>Note that, unlike <c> == </c> , <c> -0.0 </c> and <c> +0.0 </c> compare unequal, and <c> NaN </c> s compare equal by this method.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the specified object is equal to this <c> Float </c> ; <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public bool Equals(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns an integer corresponding to the bits of the given  single precision float <c> value </c> . All <b>Not-a-Number (NaN)</b> values are converted to a single NaN representation (<c> 0x7fc00000 </c> ) (compare to floatToRawIntBits). </para>        
				/// </summary>
				/// <java-name>
				/// floatToIntBits
				/// </java-name>
				[Dot42.DexImport("floatToIntBits", "(F)I", AccessFlags = 265)]
				public static int FloatToIntBits(float value) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns an integer corresponding to the bits of the given  single precision float <c> value </c> . <b>Not-a-Number (NaN)</b> values are preserved (compare to floatToIntBits). </para>        
				/// </summary>
				/// <java-name>
				/// floatToRawIntBits
				/// </java-name>
				[Dot42.DexImport("floatToRawIntBits", "(F)I", AccessFlags = 265)]
				public static int FloatToRawIntBits(float value) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Gets the primitive value of this float.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>this object's primitive value. </para>
				/// </returns>
				/// <java-name>
				/// floatValue
				/// </java-name>
				[Dot42.DexImport("floatValue", "()F", AccessFlags = 1)]
				public float FloatValue() /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 1)]
				public int GetHashCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the  single precision float corresponding to the given <c> bits </c> . </para>        
				/// </summary>
				/// <java-name>
				/// intBitsToFloat
				/// </java-name>
				[Dot42.DexImport("intBitsToFloat", "(I)F", AccessFlags = 265)]
				public static float IntBitsToFloat(int bits) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				/// <para>Returns this object's value as an int. Might involve rounding and/or truncating the value, so it fits into an int.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the primitive int value of this object. </para>
				/// </returns>
				/// <java-name>
				/// intValue
				/// </java-name>
				[Dot42.DexImport("intValue", "()I", AccessFlags = 1)]
				public int IntValue() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Indicates whether this object represents an infinite value.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the value of this float is positive or negative infinity; <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isInfinite
				/// </java-name>
				[Dot42.DexImport("isInfinite", "()Z", AccessFlags = 1)]
				public bool IsInfinite() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Indicates whether the specified float represents an infinite value.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the value of <c> f </c> is positive or negative infinity; <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isInfinite
				/// </java-name>
				[Dot42.DexImport("isInfinite", "(F)Z", AccessFlags = 9)]
				public static bool IsInfinity(float f) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Indicates whether this object is a <b>Not-a-Number (NaN)</b> value.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if this float is <b>Not-a-Number</b>; <c> false </c> if it is a (potentially infinite) float number. </para>
				/// </returns>
				/// <java-name>
				/// isNaN
				/// </java-name>
				[Dot42.DexImport("isNaN", "()Z", AccessFlags = 1)]
				public bool IsNaN() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Indicates whether the specified float is a <b>Not-a-Number (NaN)</b> value.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if <c> f </c> is <b>Not-a-Number</b>; <c> false </c> if it is a (potentially infinite) float number. </para>
				/// </returns>
				/// <java-name>
				/// isNaN
				/// </java-name>
				[Dot42.DexImport("isNaN", "(F)Z", AccessFlags = 9)]
				public static bool IsNaN(float f) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns this object's value as a long. Might involve rounding and/or truncating the value, so it fits into a long.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the primitive long value of this object. </para>
				/// </returns>
				/// <java-name>
				/// longValue
				/// </java-name>
				[Dot42.DexImport("longValue", "()J", AccessFlags = 1)]
				public long LongValue() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>Parses the specified string as a float value.</para><para><para>valueOf(String) </para><para>1.2 </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the primitive float value represented by <c> string </c> . </para>
				/// </returns>
				/// <java-name>
				/// parseFloat
				/// </java-name>
				[Dot42.DexImport("parseFloat", "(Ljava/lang/String;)F", AccessFlags = 9)]
				public static float Parse(string @string) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				/// <para>Returns this object's value as a short. Might involve rounding and/or truncating the value, so it fits into a short.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the primitive short value of this object. </para>
				/// </returns>
				/// <java-name>
				/// shortValue
				/// </java-name>
				[Dot42.DexImport("shortValue", "()S", AccessFlags = 1)]
				public short ShortValue() /* MethodBuilder.Create */ 
				{
						return default(short);
				}

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns a string containing a concise, human-readable description of the specified float value.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a printable representation of <c> f </c> . </para>
				/// </returns>
				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "(F)Ljava/lang/String;", AccessFlags = 9)]
				public static string ToString(float f) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Parses the specified string as a float value.</para><para><para>parseFloat(String) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>a <c> Float </c> instance containing the float value represented by <c> string </c> . </para>
				/// </returns>
				/// <java-name>
				/// valueOf
				/// </java-name>
				[Dot42.DexImport("valueOf", "(Ljava/lang/String;)Ljava/lang/Float;", AccessFlags = 9)]
				public static float? ValueOf(string @string) /* MethodBuilder.Create */ 
				{
						return default(float?);
				}

				/// <summary>
				/// <para>Compares the two specified float values. There are two special cases: <ul><li><para><c> Float.NaN </c> is equal to <c> Float.NaN </c> and it is greater than any other float value, including <c> Float.POSITIVE_INFINITY </c> ; </para></li><li><para>+0.0f is greater than -0.0f </para></li></ul></para><para><para>1.4 </para></para>        
				/// </summary>
				/// <returns>
				/// <para>a negative value if <c> float1 </c> is less than <c> float2 </c> ; 0 if <c> float1 </c> and <c> float2 </c> are equal; a positive value if <c> float1 </c> is greater than <c> float2 </c> . </para>
				/// </returns>
				/// <java-name>
				/// compare
				/// </java-name>
				[Dot42.DexImport("compare", "(FF)I", AccessFlags = 9)]
				public static int Compare(float float1, float float2) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Parses the specified string as a float value.</para><para><para>parseFloat(String) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>a <c> Float </c> instance containing the float value represented by <c> string </c> . </para>
				/// </returns>
				/// <java-name>
				/// valueOf
				/// </java-name>
				[Dot42.DexImport("valueOf", "(F)Ljava/lang/Float;", AccessFlags = 9)]
				public static float? ValueOf(float @string) /* MethodBuilder.Create */ 
				{
						return default(float?);
				}

				/// <summary>
				/// <para>Converts the specified float into its hexadecimal string representation.</para><para><para>1.5 </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the hexadecimal string representation of <c> f </c> . </para>
				/// </returns>
				/// <java-name>
				/// toHexString
				/// </java-name>
				[Dot42.DexImport("toHexString", "(F)Ljava/lang/String;", AccessFlags = 9)]
				public static string ToHexString(float f) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

		}

		/// <summary>
		/// <para>The wrapper for the primitive type <c> boolean </c> .</para><para><para>1.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// java/lang/Boolean
		/// </java-name>
		[Dot42.DexImport("java/lang/Boolean", AccessFlags = 49, Signature = "Ljava/lang/Object;Ljava/io/Serializable;Ljava/lang/Comparable<Ljava/lang/Boolean;" +
    ">;")]
		public partial struct Boolean : global::Java.Io.ISerializable, global::System.IComparable<bool?>
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>The Class object that represents the primitive type <c>       boolean </c> . </para>        
				/// </summary>
				/// <java-name>
				/// TYPE
				/// </java-name>
				[Dot42.DexImport("TYPE", "Ljava/lang/Class;", AccessFlags = 25)]
				public static readonly global::System.Type TYPE;
				/// <summary>
				/// <para>The <c> Boolean </c> object that represents the primitive value <c> true </c> . </para>        
				/// </summary>
				/// <java-name>
				/// TRUE
				/// </java-name>
				[Dot42.DexImport("TRUE", "Ljava/lang/Boolean;", AccessFlags = 25)]
				public static readonly bool? TRUE;
				/// <summary>
				/// <para>The <c> Boolean </c> object that represents the primitive value <c> false </c> . </para>        
				/// </summary>
				/// <java-name>
				/// FALSE
				/// </java-name>
				[Dot42.DexImport("FALSE", "Ljava/lang/Boolean;", AccessFlags = 25)]
				public static readonly bool? FALSE;
				/// <summary>
				/// <para>Constructs a new <c> Boolean </c> with its boolean value specified by <c> string </c> . If <c> string </c> is not <c> null </c> and is equal to "true" using a non-case sensitive comparison, the result will be a Boolean representing the primitive value <c> true </c> , otherwise it will be a Boolean representing the primitive value <c> false </c> .</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public Boolean(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a new <c> Boolean </c> with its boolean value specified by <c> string </c> . If <c> string </c> is not <c> null </c> and is equal to "true" using a non-case sensitive comparison, the result will be a Boolean representing the primitive value <c> true </c> , otherwise it will be a Boolean representing the primitive value <c> false </c> .</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Z)V", AccessFlags = 1)]
				public Boolean(bool @string) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets the primitive value of this boolean, either <c> true </c> or <c> false </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>this object's primitive value, <c> true </c> or <c> false </c> . </para>
				/// </returns>
				/// <java-name>
				/// booleanValue
				/// </java-name>
				[Dot42.DexImport("booleanValue", "()Z", AccessFlags = 1)]
				public bool BooleanValue() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Compares this instance with the specified object and indicates if they are equal. In order to be equal, <c> o </c> must be an instance of <c> Boolean </c> and have the same boolean value as this object.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the specified object is equal to this <c> Boolean </c> ; <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object o) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Compares this object to the specified boolean object to determine their relative order.</para><para><para>java.lang.Comparable </para><para>1.5 </para></para>        
				/// </summary>
				/// <returns>
				/// <para>0 if the value of this boolean and the value of <c> that </c> are equal; a positive value if the value of this boolean is <c> true </c> and the value of <c> that </c> is <c> false </c> ; a negative value if the value if this boolean is <c> false </c> and the value of <c> that </c> is <c> true </c> . </para>
				/// </returns>
				/// <java-name>
				/// compareTo
				/// </java-name>
				[Dot42.DexImport("compareTo", "(Ljava/lang/Boolean;)I", AccessFlags = 1)]
				public int CompareTo(bool? that) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns an integer hash code for this boolean.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>this boolean's hash code, which is <c> 1231 </c> for <c> true </c> values and <c> 1237 </c> for <c> false </c> values. </para>
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
				/// <para>Returns a string containing a concise, human-readable description of this boolean.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>"true" if the value of this boolean is <c> true </c> , "false" otherwise. </para>
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
				/// <para>Returns the <c> boolean </c> value of the system property identified by <c> string </c> .</para><para><para>System::getProperty(String) </para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the system property named by <c> string </c> exists and it is equal to "true" using case insensitive comparison, <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// getBoolean
				/// </java-name>
				[Dot42.DexImport("getBoolean", "(Ljava/lang/String;)Z", AccessFlags = 9)]
				public static bool GetBoolean(string @string) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Parses the specified string as a <c> boolean </c> .</para><para><para>1.5 </para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if <c> s </c> is not <c> null </c> and is equal to <c> "true" </c> using case insensitive comparison, <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// parseBoolean
				/// </java-name>
				[Dot42.DexImport("parseBoolean", "(Ljava/lang/String;)Z", AccessFlags = 9)]
				public static bool JavaParse(string s) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Converts the specified boolean to its string representation.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>"true" if <c> value </c> is <c> true </c> , "false" otherwise. </para>
				/// </returns>
				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "(Z)Ljava/lang/String;", AccessFlags = 9)]
				public static string ToString(bool value) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Parses the specified string as a boolean value.</para><para><para>parseBoolean(String) </para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> Boolean.TRUE </c> if <c> string </c> is equal to "true" using case insensitive comparison, <c> Boolean.FALSE </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// valueOf
				/// </java-name>
				[Dot42.DexImport("valueOf", "(Ljava/lang/String;)Ljava/lang/Boolean;", AccessFlags = 9)]
				public static bool? ValueOf(string @string) /* MethodBuilder.Create */ 
				{
						return default(bool?);
				}

				/// <summary>
				/// <para>Parses the specified string as a boolean value.</para><para><para>parseBoolean(String) </para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> Boolean.TRUE </c> if <c> string </c> is equal to "true" using case insensitive comparison, <c> Boolean.FALSE </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// valueOf
				/// </java-name>
				[Dot42.DexImport("valueOf", "(Z)Ljava/lang/Boolean;", AccessFlags = 9)]
				public static bool? ValueOf(bool @string) /* MethodBuilder.Create */ 
				{
						return default(bool?);
				}

		}

		/// <summary>
		/// <para>Thrown when a program tries to access a field or method of an object or an element of an array when there is no instance or array to use, that is if the object or array points to <c> null </c> . It also occurs in some other, less obvious circumstances, like a <c> throw e </c> statement where the Throwable reference is <c> null </c> . </para>    
		/// </summary>
		/// <java-name>
		/// java/lang/NullPointerException
		/// </java-name>
		[Dot42.DexImport("java/lang/NullPointerException", AccessFlags = 33)]
		public partial class NullReferenceException : global::System.SystemException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs a new <c> NullPointerException </c> that includes the current stack trace. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public NullReferenceException() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a new <c> NullPointerException </c> with the current stack trace and the specified detail message.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public NullReferenceException(string detailMessage) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>The wrapper for the primitive type <c> int </c> . </para><para>Implementation note: The "bit twiddling" methods in this class use techniques described in  and </para><para><para>java.lang.Long </para><para>1.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// java/lang/Integer
		/// </java-name>
		[Dot42.DexImport("java/lang/Integer", AccessFlags = 49, Signature = "Ljava/lang/Number;Ljava/lang/Comparable<Ljava/lang/Integer;>;")]
		public partial struct Int32 : global::System.IComparable<int?>
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constant for the maximum <c> int </c> value, 2<span>31</span>-1. </para>        
				/// </summary>
				/// <java-name>
				/// MAX_VALUE
				/// </java-name>
				[Dot42.DexImport("MAX_VALUE", "I", AccessFlags = 25)]
				public const int MaxValue = 2147483647;
				/// <summary>
				/// <para>Constant for the minimum <c> int </c> value, -2<span>31</span>. </para>        
				/// </summary>
				/// <java-name>
				/// MIN_VALUE
				/// </java-name>
				[Dot42.DexImport("MIN_VALUE", "I", AccessFlags = 25)]
				public const int MinValue = -2147483648;
				/// <summary>
				/// <para>Constant for the number of bits needed to represent an <c> int </c> in two's complement form.</para><para><para>1.5 </para></para>        
				/// </summary>
				/// <java-name>
				/// SIZE
				/// </java-name>
				[Dot42.DexImport("SIZE", "I", AccessFlags = 25)]
				public const int SIZE = 32;
				/// <summary>
				/// <para>The Class object that represents the primitive type <c> int </c> . </para>        
				/// </summary>
				/// <java-name>
				/// TYPE
				/// </java-name>
				[Dot42.DexImport("TYPE", "Ljava/lang/Class;", AccessFlags = 25)]
				public static readonly global::System.Type TYPE;
				/// <summary>
				/// <para>Constructs a new <c> Integer </c> with the specified primitive integer value.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public Int32(int value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a new <c> Integer </c> with the specified primitive integer value.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public Int32(string value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns this object's value as a byte. Might involve rounding and/or truncating the value, so it fits into a byte.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the primitive byte value of this object. </para>
				/// </returns>
				/// <java-name>
				/// byteValue
				/// </java-name>
				[Dot42.DexImport("byteValue", "()B", AccessFlags = 1)]
				public sbyte ByteValue() /* MethodBuilder.Create */ 
				{
						return default(sbyte);
				}

				/// <summary>
				/// <para>Compares this object to the specified integer object to determine their relative order.</para><para><para>java.lang.Comparable </para><para>1.2 </para></para>        
				/// </summary>
				/// <returns>
				/// <para>a negative value if the value of this integer is less than the value of <c> object </c> ; 0 if the value of this integer and the value of <c> object </c> are equal; a positive value if the value of this integer is greater than the value of <c> object </c> . </para>
				/// </returns>
				/// <java-name>
				/// compareTo
				/// </java-name>
				[Dot42.DexImport("compareTo", "(Ljava/lang/Integer;)I", AccessFlags = 1)]
				public int CompareTo(int? @object) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Parses the specified string and returns a <c> Integer </c> instance if the string can be decoded into an integer value. The string may be an optional minus sign "-" followed by a hexadecimal ("0x..." or "#..."), octal ("0..."), or decimal ("...") representation of an integer.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an <c> Integer </c> containing the value represented by <c> string </c> . </para>
				/// </returns>
				/// <java-name>
				/// decode
				/// </java-name>
				[Dot42.DexImport("decode", "(Ljava/lang/String;)Ljava/lang/Integer;", AccessFlags = 9)]
				public static int? Decode(string @string) /* MethodBuilder.Create */ 
				{
						return default(int?);
				}

				/// <summary>
				/// <para>Returns this object's value as a double. Might involve rounding.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the primitive double value of this object. </para>
				/// </returns>
				/// <java-name>
				/// doubleValue
				/// </java-name>
				[Dot42.DexImport("doubleValue", "()D", AccessFlags = 1)]
				public double DoubleValue() /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <summary>
				/// <para>Compares this instance with the specified object and indicates if they are equal. In order to be equal, <c> o </c> must be an instance of <c> Integer </c> and have the same integer value as this object.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the specified object is equal to this <c> Integer </c> ; <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public bool Equals(object o) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns this object's value as a float. Might involve rounding.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the primitive float value of this object. </para>
				/// </returns>
				/// <java-name>
				/// floatValue
				/// </java-name>
				[Dot42.DexImport("floatValue", "()F", AccessFlags = 1)]
				public float FloatValue() /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				/// <para>Returns the <c> Integer </c> value of the system property identified by <c> string </c> . Returns <c> null </c> if <c> string </c> is <c> null </c> or empty, if the property can not be found or if its value can not be parsed as an integer.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the requested property's value as an <c> Integer </c> or <c> null </c> . </para>
				/// </returns>
				/// <java-name>
				/// getInteger
				/// </java-name>
				[Dot42.DexImport("getInteger", "(Ljava/lang/String;)Ljava/lang/Integer;", AccessFlags = 9)]
				public static int? GetInteger(string @string) /* MethodBuilder.Create */ 
				{
						return default(int?);
				}

				/// <summary>
				/// <para>Returns the <c> Integer </c> value of the system property identified by <c> string </c> . Returns the specified default value if <c> string </c> is <c> null </c> or empty, if the property can not be found or if its value can not be parsed as an integer.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the requested property's value as an <c> Integer </c> or the default value. </para>
				/// </returns>
				/// <java-name>
				/// getInteger
				/// </java-name>
				[Dot42.DexImport("getInteger", "(Ljava/lang/String;I)Ljava/lang/Integer;", AccessFlags = 9)]
				public static int? GetInteger(string @string, int defaultValue) /* MethodBuilder.Create */ 
				{
						return default(int?);
				}

				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 1)]
				public int GetHashCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Gets the primitive value of this int.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>this object's primitive value. </para>
				/// </returns>
				/// <java-name>
				/// intValue
				/// </java-name>
				[Dot42.DexImport("intValue", "()I", AccessFlags = 1)]
				public int IntValue() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns this object's value as a long. Might involve rounding and/or truncating the value, so it fits into a long.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the primitive long value of this object. </para>
				/// </returns>
				/// <java-name>
				/// longValue
				/// </java-name>
				[Dot42.DexImport("longValue", "()J", AccessFlags = 1)]
				public long LongValue() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>Parses the specified string as a signed decimal integer value. The ASCII character  ('-') is recognized as the minus sign.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the primitive integer value represented by <c> string </c> . </para>
				/// </returns>
				/// <java-name>
				/// parseInt
				/// </java-name>
				[Dot42.DexImport("parseInt", "(Ljava/lang/String;)I", AccessFlags = 9)]
				public static int JavaParse(string @string) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Parses the specified string as a signed integer value using the specified radix. The ASCII character  ('-') is recognized as the minus sign.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the primitive integer value represented by <c> string </c> using <c> radix </c> . </para>
				/// </returns>
				/// <java-name>
				/// parseInt
				/// </java-name>
				[Dot42.DexImport("parseInt", "(Ljava/lang/String;I)I", AccessFlags = 9)]
				public static int JavaParse(string @string, int radix) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns this object's value as a short. Might involve rounding and/or truncating the value, so it fits into a short.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the primitive short value of this object. </para>
				/// </returns>
				/// <java-name>
				/// shortValue
				/// </java-name>
				[Dot42.DexImport("shortValue", "()S", AccessFlags = 1)]
				public short ShortValue() /* MethodBuilder.Create */ 
				{
						return default(short);
				}

				/// <summary>
				/// <para>Converts the specified integer into its binary string representation. The returned string is a concatenation of '0' and '1' characters.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the binary string representation of <c> i </c> . </para>
				/// </returns>
				/// <java-name>
				/// toBinaryString
				/// </java-name>
				[Dot42.DexImport("toBinaryString", "(I)Ljava/lang/String;", AccessFlags = 9)]
				public static string ToBinaryString(int i) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Converts the specified integer into its hexadecimal string representation. The returned string is a concatenation of characters from '0' to '9' and 'a' to 'f'.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the hexadecimal string representation of <c> i </c> . </para>
				/// </returns>
				/// <java-name>
				/// toHexString
				/// </java-name>
				[Dot42.DexImport("toHexString", "(I)Ljava/lang/String;", AccessFlags = 9)]
				public static string ToHexString(int i) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Converts the specified integer into its octal string representation. The returned string is a concatenation of characters from '0' to '7'.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the octal string representation of <c> i </c> . </para>
				/// </returns>
				/// <java-name>
				/// toOctalString
				/// </java-name>
				[Dot42.DexImport("toOctalString", "(I)Ljava/lang/String;", AccessFlags = 9)]
				public static string ToOctalString(int i) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Converts the specified integer into its decimal string representation. The returned string is a concatenation of a minus sign if the number is negative and characters from '0' to '9'.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the decimal string representation of <c> i </c> . </para>
				/// </returns>
				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "(I)Ljava/lang/String;", AccessFlags = 9)]
				public static string ToString(int i) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Converts the specified signed integer into a string representation based on the specified radix. The returned string is a concatenation of a minus sign if the number is negative and characters from '0' to '9' and 'a' to 'z', depending on the radix. If <c> radix </c> is not in the interval defined by <c> Character.MIN_RADIX </c> and <c> Character.MAX_RADIX </c> then 10 is used as the base for the conversion.</para><para>This method treats its argument as signed. If you want to convert an unsigned value to one of the common non-decimal bases, you may find toBinaryString, <c> #toHexString </c> , or toOctalString more convenient.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the string representation of <c> i </c> . </para>
				/// </returns>
				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "(II)Ljava/lang/String;", AccessFlags = 9)]
				public static string ToString(int i, int radix) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Parses the specified string as a signed decimal integer value.</para><para><para>parseInt(String) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>an <c> Integer </c> instance containing the integer value represented by <c> string </c> . </para>
				/// </returns>
				/// <java-name>
				/// valueOf
				/// </java-name>
				[Dot42.DexImport("valueOf", "(Ljava/lang/String;)Ljava/lang/Integer;", AccessFlags = 9)]
				public static int? ValueOf(string @string) /* MethodBuilder.Create */ 
				{
						return default(int?);
				}

				/// <summary>
				/// <para>Parses the specified string as a signed integer value using the specified radix.</para><para><para>parseInt(String, int) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>an <c> Integer </c> instance containing the integer value represented by <c> string </c> using <c> radix </c> . </para>
				/// </returns>
				/// <java-name>
				/// valueOf
				/// </java-name>
				[Dot42.DexImport("valueOf", "(Ljava/lang/String;I)Ljava/lang/Integer;", AccessFlags = 9)]
				public static int? ValueOf(string @string, int radix) /* MethodBuilder.Create */ 
				{
						return default(int?);
				}

				/// <summary>
				/// <para>Determines the highest (leftmost) bit of the specified integer that is 1 and returns the bit mask value for that bit. This is also referred to as the Most Significant 1 Bit. Returns zero if the specified integer is zero.</para><para><para>1.5 </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the bit mask indicating the highest 1 bit in <c> i </c> . </para>
				/// </returns>
				/// <java-name>
				/// highestOneBit
				/// </java-name>
				[Dot42.DexImport("highestOneBit", "(I)I", AccessFlags = 9)]
				public static int HighestOneBit(int i) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Determines the lowest (rightmost) bit of the specified integer that is 1 and returns the bit mask value for that bit. This is also referred to as the Least Significant 1 Bit. Returns zero if the specified integer is zero.</para><para><para>1.5 </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the bit mask indicating the lowest 1 bit in <c> i </c> . </para>
				/// </returns>
				/// <java-name>
				/// lowestOneBit
				/// </java-name>
				[Dot42.DexImport("lowestOneBit", "(I)I", AccessFlags = 9)]
				public static int LowestOneBit(int i) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Determines the number of leading zeros in the specified integer prior to the highest one bit.</para><para><para>1.5 </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of leading zeros in <c> i </c> . </para>
				/// </returns>
				/// <java-name>
				/// numberOfLeadingZeros
				/// </java-name>
				[Dot42.DexImport("numberOfLeadingZeros", "(I)I", AccessFlags = 9)]
				public static int NumberOfLeadingZeros(int i) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Determines the number of trailing zeros in the specified integer after the lowest one bit.</para><para><para>1.5 </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of trailing zeros in <c> i </c> . </para>
				/// </returns>
				/// <java-name>
				/// numberOfTrailingZeros
				/// </java-name>
				[Dot42.DexImport("numberOfTrailingZeros", "(I)I", AccessFlags = 9)]
				public static int NumberOfTrailingZeros(int i) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Counts the number of 1 bits in the specified integer; this is also referred to as population count.</para><para><para>1.5 </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of 1 bits in <c> i </c> . </para>
				/// </returns>
				/// <java-name>
				/// bitCount
				/// </java-name>
				[Dot42.DexImport("bitCount", "(I)I", AccessFlags = 9)]
				public static int BitCount(int i) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Rotates the bits of the specified integer to the left by the specified number of bits.</para><para><para>1.5 </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the rotated value. </para>
				/// </returns>
				/// <java-name>
				/// rotateLeft
				/// </java-name>
				[Dot42.DexImport("rotateLeft", "(II)I", AccessFlags = 9)]
				public static int RotateLeft(int i, int distance) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Rotates the bits of the specified integer to the right by the specified number of bits.</para><para><para>1.5 </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the rotated value. </para>
				/// </returns>
				/// <java-name>
				/// rotateRight
				/// </java-name>
				[Dot42.DexImport("rotateRight", "(II)I", AccessFlags = 9)]
				public static int RotateRight(int i, int distance) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Reverses the order of the bytes of the specified integer.</para><para><para>1.5 </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the reversed value. </para>
				/// </returns>
				/// <java-name>
				/// reverseBytes
				/// </java-name>
				[Dot42.DexImport("reverseBytes", "(I)I", AccessFlags = 9)]
				public static int ReverseBytes(int i) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Reverses the order of the bits of the specified integer.</para><para><para>1.5 </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the reversed value. </para>
				/// </returns>
				/// <java-name>
				/// reverse
				/// </java-name>
				[Dot42.DexImport("reverse", "(I)I", AccessFlags = 9)]
				public static int Reverse(int i) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the value of the <c> signum </c> function for the specified integer.</para><para><para>1.5 </para></para>        
				/// </summary>
				/// <returns>
				/// <para>-1 if <c> i </c> is negative, 1 if <c> i </c> is positive, 0 if <c> i </c> is zero. </para>
				/// </returns>
				/// <java-name>
				/// signum
				/// </java-name>
				[Dot42.DexImport("signum", "(I)I", AccessFlags = 9)]
				public static int Signum(int i) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Parses the specified string as a signed decimal integer value.</para><para><para>parseInt(String) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>an <c> Integer </c> instance containing the integer value represented by <c> string </c> . </para>
				/// </returns>
				/// <java-name>
				/// valueOf
				/// </java-name>
				[Dot42.DexImport("valueOf", "(I)Ljava/lang/Integer;", AccessFlags = 9)]
				public static int? ValueOf(int @string) /* MethodBuilder.Create */ 
				{
						return default(int?);
				}

		}

		/// <summary>
		/// <para>Thrown when a program attempts to access a value in an indexable collection using a value which is outside of the range of valid indices. </para>    
		/// </summary>
		/// <java-name>
		/// java/lang/IndexOutOfBoundsException
		/// </java-name>
		[Dot42.DexImport("java/lang/IndexOutOfBoundsException", AccessFlags = 33)]
		public partial class IndexOutOfRangeException : global::System.SystemException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs a new <c> IndexOutOfBoundsException </c> that includes the current stack trace. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public IndexOutOfRangeException() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a new <c> IndexOutOfBoundsException </c> with the current stack trace and the specified detail message.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public IndexOutOfRangeException(string detailMessage) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>Class Math provides basic math constants and operations such as trigonometric functions, hyperbolic functions, exponential, logarithms, etc. </para>    
		/// </summary>
		/// <java-name>
		/// java/lang/Math
		/// </java-name>
		[Dot42.DexImport("java/lang/Math", AccessFlags = 49)]
		public sealed partial class Math
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>The double value closest to e, the base of the natural logarithm. </para>        
				/// </summary>
				/// <java-name>
				/// E
				/// </java-name>
				[Dot42.DexImport("E", "D", AccessFlags = 25)]
				public const double E = 2.7182818284590451D;
				/// <summary>
				/// <para>The double value closest to pi, the ratio of a circle's circumference to its diameter. </para>        
				/// </summary>
				/// <java-name>
				/// PI
				/// </java-name>
				[Dot42.DexImport("PI", "D", AccessFlags = 25)]
				public const double PI = 3.1415926535897931D;
				/// <summary>
				/// <para>Prevents this class from being instantiated. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal Math() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the absolute value of the argument. </para><para>Special cases: <ul><li><para><c> abs(-0.0) = +0.0 </c>  </para></li><li><para><c> abs(+infinity) = +infinity </c>  </para></li><li><para><c> abs(-infinity) = +infinity </c>  </para></li><li><para><c> abs(NaN) = NaN </c>  </para></li></ul></para>        
				/// </summary>
				/// <java-name>
				/// abs
				/// </java-name>
				[Dot42.DexImport("abs", "(D)D", AccessFlags = 9)]
				public static double Abs(double d) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <summary>
				/// <para>Returns the absolute value of the argument. </para><para>Special cases: <ul><li><para><c> abs(-0.0) = +0.0 </c>  </para></li><li><para><c> abs(+infinity) = +infinity </c>  </para></li><li><para><c> abs(-infinity) = +infinity </c>  </para></li><li><para><c> abs(NaN) = NaN </c>  </para></li></ul></para>        
				/// </summary>
				/// <java-name>
				/// abs
				/// </java-name>
				[Dot42.DexImport("abs", "(F)F", AccessFlags = 9)]
				public static float Abs(float d) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				/// <para>Returns the absolute value of the argument. </para><para>Special cases: <ul><li><para><c> abs(-0.0) = +0.0 </c>  </para></li><li><para><c> abs(+infinity) = +infinity </c>  </para></li><li><para><c> abs(-infinity) = +infinity </c>  </para></li><li><para><c> abs(NaN) = NaN </c>  </para></li></ul></para>        
				/// </summary>
				/// <java-name>
				/// abs
				/// </java-name>
				[Dot42.DexImport("abs", "(I)I", AccessFlags = 9)]
				public static int Abs(int d) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the absolute value of the argument. </para><para>Special cases: <ul><li><para><c> abs(-0.0) = +0.0 </c>  </para></li><li><para><c> abs(+infinity) = +infinity </c>  </para></li><li><para><c> abs(-infinity) = +infinity </c>  </para></li><li><para><c> abs(NaN) = NaN </c>  </para></li></ul></para>        
				/// </summary>
				/// <java-name>
				/// abs
				/// </java-name>
				[Dot42.DexImport("abs", "(J)J", AccessFlags = 9)]
				public static long Abs(long d) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>Returns the closest double approximation of the arc cosine of the argument within the range <c> [0..pi] </c> . The returned result is within 1 ulp (unit in the last place) of the real result. </para><para>Special cases: <ul><li><para><c> acos((anything &gt; 1) = NaN </c>  </para></li><li><para><c> acos((anything &lt; -1) = NaN </c>  </para></li><li><para><c> acos(NaN) = NaN </c>  </para></li></ul></para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the arc cosine of the argument. </para>
				/// </returns>
				/// <java-name>
				/// acos
				/// </java-name>
				[Dot42.DexImport("acos", "(D)D", AccessFlags = 265)]
				public static double Acos(double d) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <summary>
				/// <para>Returns the closest double approximation of the arc sine of the argument within the range <c> [-pi/2..pi/2] </c> . The returned result is within 1 ulp (unit in the last place) of the real result. </para><para>Special cases: <ul><li><para><c> asin((anything &gt; 1)) = NaN </c>  </para></li><li><para><c> asin((anything &lt; -1)) = NaN </c>  </para></li><li><para><c> asin(NaN) = NaN </c>  </para></li></ul></para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the arc sine of the argument. </para>
				/// </returns>
				/// <java-name>
				/// asin
				/// </java-name>
				[Dot42.DexImport("asin", "(D)D", AccessFlags = 265)]
				public static double Asin(double d) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <summary>
				/// <para>Returns the closest double approximation of the arc tangent of the argument within the range <c> [-pi/2..pi/2] </c> . The returned result is within 1 ulp (unit in the last place) of the real result. </para><para>Special cases: <ul><li><para><c> atan(+0.0) = +0.0 </c>  </para></li><li><para><c> atan(-0.0) = -0.0 </c>  </para></li><li><para><c> atan(+infinity) = +pi/2 </c>  </para></li><li><para><c> atan(-infinity) = -pi/2 </c>  </para></li><li><para><c> atan(NaN) = NaN </c>  </para></li></ul></para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the arc tangent of the argument. </para>
				/// </returns>
				/// <java-name>
				/// atan
				/// </java-name>
				[Dot42.DexImport("atan", "(D)D", AccessFlags = 265)]
				public static double Atan(double d) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <summary>
				/// <para>Returns the closest double approximation of the arc tangent of <c>       y/x </c> within the range <c> [-pi..pi] </c> . This is the angle of the polar representation of the rectangular coordinates (x,y). The returned result is within 2 ulps (units in the last place) of the real result. </para><para>Special cases: <ul><li><para><c> atan2((anything), NaN ) = NaN; </c>  </para></li><li><para><c> atan2(NaN , (anything) ) = NaN; </c>  </para></li><li><para><c> atan2(+0.0, +(anything but NaN)) = +0.0 </c>  </para></li><li><para><c> atan2(-0.0, +(anything but NaN)) = -0.0 </c>  </para></li><li><para><c> atan2(+0.0, -(anything but NaN)) = +pi </c>  </para></li><li><para><c> atan2(-0.0, -(anything but NaN)) = -pi </c>  </para></li><li><para><c> atan2(+(anything but 0 and NaN), 0) = +pi/2 </c>  </para></li><li><para><c> atan2(-(anything but 0 and NaN), 0) = -pi/2 </c>  </para></li><li><para><c> atan2(+(anything but infinity and NaN), +infinity) </c> <c> = </c> <c> +0.0 </c>  </para></li><li><para><c> atan2(-(anything but infinity and NaN), +infinity) </c> <c> = </c> <c> -0.0 </c>  </para></li><li><para><c> atan2(+(anything but infinity and NaN), -infinity) = +pi </c>  </para></li><li><para><c> atan2(-(anything but infinity and NaN), -infinity) = -pi </c>  </para></li><li><para><c> atan2(+infinity, +infinity ) = +pi/4 </c>  </para></li><li><para><c> atan2(-infinity, +infinity ) = -pi/4 </c>  </para></li><li><para><c> atan2(+infinity, -infinity ) = +3pi/4 </c>  </para></li><li><para><c> atan2(-infinity, -infinity ) = -3pi/4 </c>  </para></li><li><para><c> atan2(+infinity, (anything but,0, NaN, and infinity)) </c> <c>       = </c> <c> +pi/2 </c>  </para></li><li><para><c> atan2(-infinity, (anything but,0, NaN, and infinity)) </c> <c>       = </c> <c> -pi/2 </c>  </para></li></ul></para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the arc tangent of <c> y/x </c> . </para>
				/// </returns>
				/// <java-name>
				/// atan2
				/// </java-name>
				[Dot42.DexImport("atan2", "(DD)D", AccessFlags = 265)]
				public static double Atan2(double y, double x) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <summary>
				/// <para>Returns the closest double approximation of the cube root of the argument. </para><para>Special cases: <ul><li><para><c> cbrt(+0.0) = +0.0 </c>  </para></li><li><para><c> cbrt(-0.0) = -0.0 </c>  </para></li><li><para><c> cbrt(+infinity) = +infinity </c>  </para></li><li><para><c> cbrt(-infinity) = -infinity </c>  </para></li><li><para><c> cbrt(NaN) = NaN </c>  </para></li></ul></para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the cube root of the argument. </para>
				/// </returns>
				/// <java-name>
				/// cbrt
				/// </java-name>
				[Dot42.DexImport("cbrt", "(D)D", AccessFlags = 265)]
				public static double Cbrt(double d) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <summary>
				/// <para>Returns the double conversion of the most negative (closest to negative infinity) integer value greater than or equal to the argument. </para><para>Special cases: <ul><li><para><c> ceil(+0.0) = +0.0 </c>  </para></li><li><para><c> ceil(-0.0) = -0.0 </c>  </para></li><li><para><c> ceil((anything in range (-1,0)) = -0.0 </c>  </para></li><li><para><c> ceil(+infinity) = +infinity </c>  </para></li><li><para><c> ceil(-infinity) = -infinity </c>  </para></li><li><para><c> ceil(NaN) = NaN </c>  </para></li></ul></para>        
				/// </summary>
				/// <java-name>
				/// ceil
				/// </java-name>
				[Dot42.DexImport("ceil", "(D)D", AccessFlags = 265)]
				public static double Ceiling(double d) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <summary>
				/// <para>Returns the closest double approximation of the cosine of the argument. The returned result is within 1 ulp (unit in the last place) of the real result. </para><para>Special cases: <ul><li><para><c> cos(+infinity) = NaN </c>  </para></li><li><para><c> cos(-infinity) = NaN </c>  </para></li><li><para><c> cos(NaN) = NaN </c>  </para></li></ul></para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the cosine of the argument. </para>
				/// </returns>
				/// <java-name>
				/// cos
				/// </java-name>
				[Dot42.DexImport("cos", "(D)D", AccessFlags = 265)]
				public static double Cos(double d) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <summary>
				/// <para>Returns the closest double approximation of the hyperbolic cosine of the argument. The returned result is within 2.5 ulps (units in the last place) of the real result. </para><para>Special cases: <ul><li><para><c> cosh(+infinity) = +infinity </c>  </para></li><li><para><c> cosh(-infinity) = +infinity </c>  </para></li><li><para><c> cosh(NaN) = NaN </c>  </para></li></ul></para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the hyperbolic cosine of the argument. </para>
				/// </returns>
				/// <java-name>
				/// cosh
				/// </java-name>
				[Dot42.DexImport("cosh", "(D)D", AccessFlags = 265)]
				public static double Cosh(double d) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <summary>
				/// <para>Returns the closest double approximation of the raising "e" to the power of the argument. The returned result is within 1 ulp (unit in the last place) of the real result. </para><para>Special cases: <ul><li><para><c> exp(+infinity) = +infinity </c>  </para></li><li><para><c> exp(-infinity) = +0.0 </c>  </para></li><li><para><c> exp(NaN) = NaN </c>  </para></li></ul></para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the exponential of the argument. </para>
				/// </returns>
				/// <java-name>
				/// exp
				/// </java-name>
				[Dot42.DexImport("exp", "(D)D", AccessFlags = 265)]
				public static double Exp(double d) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <summary>
				/// <para>Returns the closest double approximation of <b><c> e </c> </b><span> <c>       d </c> </span><c> - 1 </c> . If the argument is very close to 0, it is much more accurate to use <c> expm1(d)+1 </c> than <c> exp(d) </c> (due to cancellation of significant digits). The returned result is within 1 ulp (unit in the last place) of the real result. </para><para>For any finite input, the result is not less than -1.0. If the real result is within 0.5 ulp of -1, -1.0 is returned. </para><para>Special cases: <ul><li><para><c> expm1(+0.0) = +0.0 </c>  </para></li><li><para><c> expm1(-0.0) = -0.0 </c>  </para></li><li><para><c> expm1(+infinity) = +infinity </c>  </para></li><li><para><c> expm1(-infinity) = -1.0 </c>  </para></li><li><para><c> expm1(NaN) = NaN </c>  </para></li></ul></para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the <b><c> e </c> </b><span><c> d </c> </span><c> - 1 </c> value of the argument. </para>
				/// </returns>
				/// <java-name>
				/// expm1
				/// </java-name>
				[Dot42.DexImport("expm1", "(D)D", AccessFlags = 265)]
				public static double Expm1(double d) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <summary>
				/// <para>Returns the double conversion of the most positive (closest to positive infinity) integer value less than or equal to the argument. </para><para>Special cases: <ul><li><para><c> floor(+0.0) = +0.0 </c>  </para></li><li><para><c> floor(-0.0) = -0.0 </c>  </para></li><li><para><c> floor(+infinity) = +infinity </c>  </para></li><li><para><c> floor(-infinity) = -infinity </c>  </para></li><li><para><c> floor(NaN) = NaN </c>  </para></li></ul></para>        
				/// </summary>
				/// <java-name>
				/// floor
				/// </java-name>
				[Dot42.DexImport("floor", "(D)D", AccessFlags = 265)]
				public static double Floor(double d) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <summary>
				/// <para>Returns <c> sqrt( </c> <b><c> x </c> </b><span><c> 2 </c> </span><c> + </c> <b> <c> y </c> </b><span><c> 2 </c> </span><c> ) </c> . The final result is without medium underflow or overflow. The returned result is within 1 ulp (unit in the last place) of the real result. If one parameter remains constant, the result should be semi-monotonic. </para><para>Special cases: <ul><li><para><c> hypot(+infinity, (anything including NaN)) = +infinity </c>  </para></li><li><para><c> hypot(-infinity, (anything including NaN)) = +infinity </c>  </para></li><li><para><c> hypot((anything including NaN), +infinity) = +infinity </c>  </para></li><li><para><c> hypot((anything including NaN), -infinity) = +infinity </c>  </para></li><li><para><c> hypot(NaN, NaN) = NaN </c>  </para></li></ul></para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the <c> sqrt( </c> <b><c> x </c> </b><span><c> 2 </c> </span><c> + </c> <b> <c> y </c> </b><span><c> 2 </c> </span><c> ) </c> value of the arguments. </para>
				/// </returns>
				/// <java-name>
				/// hypot
				/// </java-name>
				[Dot42.DexImport("hypot", "(DD)D", AccessFlags = 265)]
				public static double Hypot(double x, double y) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <summary>
				/// <para>Returns the remainder of dividing <c> x </c> by <c> y </c> using the IEEE 754 rules. The result is <c> x-round(x/p)*p </c> where <c> round(x/p) </c> is the nearest integer (rounded to even), but without numerical cancellation problems. </para><para>Special cases: <ul><li><para><c> IEEEremainder((anything), 0) = NaN </c>  </para></li><li><para><c> IEEEremainder(+infinity, (anything)) = NaN </c>  </para></li><li><para><c> IEEEremainder(-infinity, (anything)) = NaN </c>  </para></li><li><para><c> IEEEremainder(NaN, (anything)) = NaN </c>  </para></li><li><para><c> IEEEremainder((anything), NaN) = NaN </c>  </para></li><li><para><c> IEEEremainder(x, +infinity) = x  </c> where x is anything but +/-infinity </para></li><li><para><c> IEEEremainder(x, -infinity) = x  </c> where x is anything but +/-infinity </para></li></ul></para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the IEEE754 floating point reminder of of <c> x/y </c> . </para>
				/// </returns>
				/// <java-name>
				/// IEEEremainder
				/// </java-name>
				[Dot42.DexImport("IEEEremainder", "(DD)D", AccessFlags = 265)]
				public static double IEEEremainder(double x, double y) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <summary>
				/// <para>Returns the closest double approximation of the natural logarithm of the argument. The returned result is within 1 ulp (unit in the last place) of the real result. </para><para>Special cases: <ul><li><para><c> log(+0.0) = -infinity </c>  </para></li><li><para><c> log(-0.0) = -infinity </c>  </para></li><li><para><c> log((anything &lt; 0) = NaN </c>  </para></li><li><para><c> log(+infinity) = +infinity </c>  </para></li><li><para><c> log(-infinity) = NaN </c>  </para></li><li><para><c> log(NaN) = NaN </c>  </para></li></ul></para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the natural logarithm of the argument. </para>
				/// </returns>
				/// <java-name>
				/// log
				/// </java-name>
				[Dot42.DexImport("log", "(D)D", AccessFlags = 265)]
				public static double Log(double d) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <summary>
				/// <para>Returns the closest double approximation of the base 10 logarithm of the argument. The returned result is within 1 ulp (unit in the last place) of the real result. </para><para>Special cases: <ul><li><para><c> log10(+0.0) = -infinity </c>  </para></li><li><para><c> log10(-0.0) = -infinity </c>  </para></li><li><para><c> log10((anything &lt; 0) = NaN </c>  </para></li><li><para><c> log10(+infinity) = +infinity </c>  </para></li><li><para><c> log10(-infinity) = NaN </c>  </para></li><li><para><c> log10(NaN) = NaN </c>  </para></li></ul></para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the natural logarithm of the argument. </para>
				/// </returns>
				/// <java-name>
				/// log10
				/// </java-name>
				[Dot42.DexImport("log10", "(D)D", AccessFlags = 265)]
				public static double Log10(double d) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <summary>
				/// <para>Returns the closest double approximation of the natural logarithm of the sum of the argument and 1. If the argument is very close to 0, it is much more accurate to use <c> log1p(d) </c> than <c> log(1.0+d) </c> (due to numerical cancellation). The returned result is within 1 ulp (unit in the last place) of the real result and is semi-monotonic. </para><para>Special cases: <ul><li><para><c> log1p(+0.0) = +0.0 </c>  </para></li><li><para><c> log1p(-0.0) = -0.0 </c>  </para></li><li><para><c> log1p((anything &lt; 1)) = NaN </c>  </para></li><li><para><c> log1p(-1.0) = -infinity </c>  </para></li><li><para><c> log1p(+infinity) = +infinity </c>  </para></li><li><para><c> log1p(-infinity) = NaN </c>  </para></li><li><para><c> log1p(NaN) = NaN </c>  </para></li></ul></para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the natural logarithm of the sum of the argument and 1. </para>
				/// </returns>
				/// <java-name>
				/// log1p
				/// </java-name>
				[Dot42.DexImport("log1p", "(D)D", AccessFlags = 265)]
				public static double Log1p(double d) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <summary>
				/// <para>Returns the most positive (closest to positive infinity) of the two arguments. </para><para>Special cases: <ul><li><para><c> max(NaN, (anything)) = NaN </c>  </para></li><li><para><c> max((anything), NaN) = NaN </c>  </para></li><li><para><c> max(+0.0, -0.0) = +0.0 </c>  </para></li><li><para><c> max(-0.0, +0.0) = +0.0 </c>  </para></li></ul></para>        
				/// </summary>
				/// <java-name>
				/// max
				/// </java-name>
				[Dot42.DexImport("max", "(DD)D", AccessFlags = 9)]
				public static double Max(double d1, double d2) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <summary>
				/// <para>Returns the most positive (closest to positive infinity) of the two arguments. </para><para>Special cases: <ul><li><para><c> max(NaN, (anything)) = NaN </c>  </para></li><li><para><c> max((anything), NaN) = NaN </c>  </para></li><li><para><c> max(+0.0, -0.0) = +0.0 </c>  </para></li><li><para><c> max(-0.0, +0.0) = +0.0 </c>  </para></li></ul></para>        
				/// </summary>
				/// <java-name>
				/// max
				/// </java-name>
				[Dot42.DexImport("max", "(FF)F", AccessFlags = 9)]
				public static float Max(float d1, float d2) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				/// <para>Returns the most positive (closest to positive infinity) of the two arguments. </para><para>Special cases: <ul><li><para><c> max(NaN, (anything)) = NaN </c>  </para></li><li><para><c> max((anything), NaN) = NaN </c>  </para></li><li><para><c> max(+0.0, -0.0) = +0.0 </c>  </para></li><li><para><c> max(-0.0, +0.0) = +0.0 </c>  </para></li></ul></para>        
				/// </summary>
				/// <java-name>
				/// max
				/// </java-name>
				[Dot42.DexImport("max", "(II)I", AccessFlags = 9)]
				public static int Max(int d1, int d2) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the most positive (closest to positive infinity) of the two arguments. </para><para>Special cases: <ul><li><para><c> max(NaN, (anything)) = NaN </c>  </para></li><li><para><c> max((anything), NaN) = NaN </c>  </para></li><li><para><c> max(+0.0, -0.0) = +0.0 </c>  </para></li><li><para><c> max(-0.0, +0.0) = +0.0 </c>  </para></li></ul></para>        
				/// </summary>
				/// <java-name>
				/// max
				/// </java-name>
				[Dot42.DexImport("max", "(JJ)J", AccessFlags = 9)]
				public static long Max(long d1, long d2) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>Returns the most negative (closest to negative infinity) of the two arguments. </para><para>Special cases: <ul><li><para><c> min(NaN, (anything)) = NaN </c>  </para></li><li><para><c> min((anything), NaN) = NaN </c>  </para></li><li><para><c> min(+0.0, -0.0) = -0.0 </c>  </para></li><li><para><c> min(-0.0, +0.0) = -0.0 </c>  </para></li></ul></para>        
				/// </summary>
				/// <java-name>
				/// min
				/// </java-name>
				[Dot42.DexImport("min", "(DD)D", AccessFlags = 9)]
				public static double Min(double d1, double d2) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <summary>
				/// <para>Returns the most negative (closest to negative infinity) of the two arguments. </para><para>Special cases: <ul><li><para><c> min(NaN, (anything)) = NaN </c>  </para></li><li><para><c> min((anything), NaN) = NaN </c>  </para></li><li><para><c> min(+0.0, -0.0) = -0.0 </c>  </para></li><li><para><c> min(-0.0, +0.0) = -0.0 </c>  </para></li></ul></para>        
				/// </summary>
				/// <java-name>
				/// min
				/// </java-name>
				[Dot42.DexImport("min", "(FF)F", AccessFlags = 9)]
				public static float Min(float d1, float d2) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				/// <para>Returns the most negative (closest to negative infinity) of the two arguments. </para><para>Special cases: <ul><li><para><c> min(NaN, (anything)) = NaN </c>  </para></li><li><para><c> min((anything), NaN) = NaN </c>  </para></li><li><para><c> min(+0.0, -0.0) = -0.0 </c>  </para></li><li><para><c> min(-0.0, +0.0) = -0.0 </c>  </para></li></ul></para>        
				/// </summary>
				/// <java-name>
				/// min
				/// </java-name>
				[Dot42.DexImport("min", "(II)I", AccessFlags = 9)]
				public static int Min(int d1, int d2) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the most negative (closest to negative infinity) of the two arguments. </para><para>Special cases: <ul><li><para><c> min(NaN, (anything)) = NaN </c>  </para></li><li><para><c> min((anything), NaN) = NaN </c>  </para></li><li><para><c> min(+0.0, -0.0) = -0.0 </c>  </para></li><li><para><c> min(-0.0, +0.0) = -0.0 </c>  </para></li></ul></para>        
				/// </summary>
				/// <java-name>
				/// min
				/// </java-name>
				[Dot42.DexImport("min", "(JJ)J", AccessFlags = 9)]
				public static long Min(long d1, long d2) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>Returns the closest double approximation of the result of raising <c>       x </c> to the power of <c> y </c> . </para><para>Special cases: <ul><li><para><c> pow((anything), +0.0) = 1.0 </c>  </para></li><li><para><c> pow((anything), -0.0) = 1.0 </c>  </para></li><li><para><c> pow(x, 1.0) = x </c>  </para></li><li><para><c> pow((anything), NaN) = NaN </c>  </para></li><li><para><c> pow(NaN, (anything except 0)) = NaN </c>  </para></li><li><para><c> pow(+/-(|x| &gt; 1), +infinity) = +infinity </c>  </para></li><li><para><c> pow(+/-(|x| &gt; 1), -infinity) = +0.0 </c>  </para></li><li><para><c> pow(+/-(|x| &lt; 1), +infinity) = +0.0 </c>  </para></li><li><para><c> pow(+/-(|x| &lt; 1), -infinity) = +infinity </c>  </para></li><li><para><c> pow(+/-1.0 , +infinity) = NaN </c>  </para></li><li><para><c> pow(+/-1.0 , -infinity) = NaN </c>  </para></li><li><para><c> pow(+0.0, (+anything except 0, NaN)) = +0.0 </c>  </para></li><li><para><c> pow(-0.0, (+anything except 0, NaN, odd integer)) = +0.0 </c>  </para></li><li><para><c> pow(+0.0, (-anything except 0, NaN)) = +infinity </c>  </para></li><li><para><c> pow(-0.0, (-anything except 0, NAN, odd integer)) </c> <c> = </c> <c> +infinity </c>  </para></li><li><para><c> pow(-0.0, (odd integer)) = -pow( +0 , (odd integer) ) </c>  </para></li><li><para><c> pow(+infinity, (+anything except 0, NaN)) = +infinity </c>  </para></li><li><para><c> pow(+infinity, (-anything except 0, NaN)) = +0.0 </c>  </para></li><li><para><c> pow(-infinity, (anything)) = -pow(0, (-anything)) </c>  </para></li><li><para><c> pow((-anything), (integer)) </c> <c> = </c> <c>       pow(-1,(integer))*pow(+anything,integer)  </c>  </para></li><li><para><c> pow((-anything except 0 and inf), (non-integer)) = NAN </c>  </para></li></ul></para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> x </c> to the power of <c> y </c> . </para>
				/// </returns>
				/// <java-name>
				/// pow
				/// </java-name>
				[Dot42.DexImport("pow", "(DD)D", AccessFlags = 265)]
				public static double Pow(double x, double y) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <summary>
				/// <para>Returns the double conversion of the result of rounding the argument to an integer. Tie breaks are rounded towards even. </para><para>Special cases: <ul><li><para><c> rint(+0.0) = +0.0 </c>  </para></li><li><para><c> rint(-0.0) = -0.0 </c>  </para></li><li><para><c> rint(+infinity) = +infinity </c>  </para></li><li><para><c> rint(-infinity) = -infinity </c>  </para></li><li><para><c> rint(NaN) = NaN </c>  </para></li></ul></para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the closest integer to the argument (as a double). </para>
				/// </returns>
				/// <java-name>
				/// rint
				/// </java-name>
				[Dot42.DexImport("rint", "(D)D", AccessFlags = 265)]
				public static double Rint(double d) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <summary>
				/// <para>Returns the result of rounding the argument to an integer. The result is equivalent to <c> (long) Math.floor(d+0.5) </c> . </para><para>Special cases: <ul><li><para><c> round(+0.0) = +0.0 </c>  </para></li><li><para><c> round(-0.0) = +0.0 </c>  </para></li><li><para><c> round((anything &gt; Long.MAX_VALUE) = Long.MAX_VALUE </c>  </para></li><li><para><c> round((anything &lt; Long.MIN_VALUE) = Long.MIN_VALUE </c>  </para></li><li><para><c> round(+infinity) = Long.MAX_VALUE </c>  </para></li><li><para><c> round(-infinity) = Long.MIN_VALUE </c>  </para></li><li><para><c> round(NaN) = +0.0 </c>  </para></li></ul></para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the closest integer to the argument. </para>
				/// </returns>
				/// <java-name>
				/// round
				/// </java-name>
				[Dot42.DexImport("round", "(D)J", AccessFlags = 9)]
				public static long Round(double d) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>Returns the result of rounding the argument to an integer. The result is equivalent to <c> (long) Math.floor(d+0.5) </c> . </para><para>Special cases: <ul><li><para><c> round(+0.0) = +0.0 </c>  </para></li><li><para><c> round(-0.0) = +0.0 </c>  </para></li><li><para><c> round((anything &gt; Long.MAX_VALUE) = Long.MAX_VALUE </c>  </para></li><li><para><c> round((anything &lt; Long.MIN_VALUE) = Long.MIN_VALUE </c>  </para></li><li><para><c> round(+infinity) = Long.MAX_VALUE </c>  </para></li><li><para><c> round(-infinity) = Long.MIN_VALUE </c>  </para></li><li><para><c> round(NaN) = +0.0 </c>  </para></li></ul></para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the closest integer to the argument. </para>
				/// </returns>
				/// <java-name>
				/// round
				/// </java-name>
				[Dot42.DexImport("round", "(F)I", AccessFlags = 9)]
				public static int Round(float d) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the signum function of the argument. If the argument is less than zero, it returns -1.0. If the argument is greater than zero, 1.0 is returned. If the argument is either positive or negative zero, the argument is returned as result. </para><para>Special cases: <ul><li><para><c> signum(+0.0) = +0.0 </c>  </para></li><li><para><c> signum(-0.0) = -0.0 </c>  </para></li><li><para><c> signum(+infinity) = +1.0 </c>  </para></li><li><para><c> signum(-infinity) = -1.0 </c>  </para></li><li><para><c> signum(NaN) = NaN </c>  </para></li></ul></para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the value of the signum function. </para>
				/// </returns>
				/// <java-name>
				/// signum
				/// </java-name>
				[Dot42.DexImport("signum", "(D)D", AccessFlags = 9)]
				public static double Signum(double d) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <summary>
				/// <para>Returns the signum function of the argument. If the argument is less than zero, it returns -1.0. If the argument is greater than zero, 1.0 is returned. If the argument is either positive or negative zero, the argument is returned as result. </para><para>Special cases: <ul><li><para><c> signum(+0.0) = +0.0 </c>  </para></li><li><para><c> signum(-0.0) = -0.0 </c>  </para></li><li><para><c> signum(+infinity) = +1.0 </c>  </para></li><li><para><c> signum(-infinity) = -1.0 </c>  </para></li><li><para><c> signum(NaN) = NaN </c>  </para></li></ul></para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the value of the signum function. </para>
				/// </returns>
				/// <java-name>
				/// signum
				/// </java-name>
				[Dot42.DexImport("signum", "(F)F", AccessFlags = 9)]
				public static float Signum(float d) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				/// <para>Returns the closest double approximation of the sine of the argument. The returned result is within 1 ulp (unit in the last place) of the real result. </para><para>Special cases: <ul><li><para><c> sin(+0.0) = +0.0 </c>  </para></li><li><para><c> sin(-0.0) = -0.0 </c>  </para></li><li><para><c> sin(+infinity) = NaN </c>  </para></li><li><para><c> sin(-infinity) = NaN </c>  </para></li><li><para><c> sin(NaN) = NaN </c>  </para></li></ul></para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the sine of the argument. </para>
				/// </returns>
				/// <java-name>
				/// sin
				/// </java-name>
				[Dot42.DexImport("sin", "(D)D", AccessFlags = 265)]
				public static double Sin(double d) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <summary>
				/// <para>Returns the closest double approximation of the hyperbolic sine of the argument. The returned result is within 2.5 ulps (units in the last place) of the real result. </para><para>Special cases: <ul><li><para><c> sinh(+0.0) = +0.0 </c>  </para></li><li><para><c> sinh(-0.0) = -0.0 </c>  </para></li><li><para><c> sinh(+infinity) = +infinity </c>  </para></li><li><para><c> sinh(-infinity) = -infinity </c>  </para></li><li><para><c> sinh(NaN) = NaN </c>  </para></li></ul></para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the hyperbolic sine of the argument. </para>
				/// </returns>
				/// <java-name>
				/// sinh
				/// </java-name>
				[Dot42.DexImport("sinh", "(D)D", AccessFlags = 265)]
				public static double Sinh(double d) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <summary>
				/// <para>Returns the closest double approximation of the square root of the argument. </para><para>Special cases: <ul><li><para><c> sqrt(+0.0) = +0.0 </c>  </para></li><li><para><c> sqrt(-0.0) = -0.0 </c>  </para></li><li><para><c> sqrt( (anything &lt; 0) ) = NaN </c>  </para></li><li><para><c> sqrt(+infinity) = +infinity </c>  </para></li><li><para><c> sqrt(NaN) = NaN </c>  </para></li></ul></para>        
				/// </summary>
				/// <java-name>
				/// sqrt
				/// </java-name>
				[Dot42.DexImport("sqrt", "(D)D", AccessFlags = 265)]
				public static double Sqrt(double d) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <summary>
				/// <para>Returns the closest double approximation of the tangent of the argument. The returned result is within 1 ulp (unit in the last place) of the real result. </para><para>Special cases: <ul><li><para><c> tan(+0.0) = +0.0 </c>  </para></li><li><para><c> tan(-0.0) = -0.0 </c>  </para></li><li><para><c> tan(+infinity) = NaN </c>  </para></li><li><para><c> tan(-infinity) = NaN </c>  </para></li><li><para><c> tan(NaN) = NaN </c>  </para></li></ul></para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the tangent of the argument. </para>
				/// </returns>
				/// <java-name>
				/// tan
				/// </java-name>
				[Dot42.DexImport("tan", "(D)D", AccessFlags = 265)]
				public static double Tan(double d) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <summary>
				/// <para>Returns the closest double approximation of the hyperbolic tangent of the argument. The absolute value is always less than 1. The returned result is within 2.5 ulps (units in the last place) of the real result. If the real result is within 0.5ulp of 1 or -1, it should return exactly +1 or -1. </para><para>Special cases: <ul><li><para><c> tanh(+0.0) = +0.0 </c>  </para></li><li><para><c> tanh(-0.0) = -0.0 </c>  </para></li><li><para><c> tanh(+infinity) = +1.0 </c>  </para></li><li><para><c> tanh(-infinity) = -1.0 </c>  </para></li><li><para><c> tanh(NaN) = NaN </c>  </para></li></ul></para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the hyperbolic tangent of the argument. </para>
				/// </returns>
				/// <java-name>
				/// tanh
				/// </java-name>
				[Dot42.DexImport("tanh", "(D)D", AccessFlags = 265)]
				public static double Tanh(double d) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <summary>
				/// <para>Returns a pseudo-random double <c> n </c> , where <c> n &gt;= 0.0 &amp;&amp; n &lt; 1.0 </c> . This method reuses a single instance of java.util.Random. This method is thread-safe because access to the <c> Random </c> is synchronized, but this harms scalability. Applications may find a performance benefit from allocating a <c> Random </c> for each of their threads.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a pseudo-random number. </para>
				/// </returns>
				/// <java-name>
				/// random
				/// </java-name>
				[Dot42.DexImport("random", "()D", AccessFlags = 41)]
				public static double Random() /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <summary>
				/// <para>Returns the measure in radians of the supplied degree angle. The result is <c> angdeg / 180 * pi </c> . </para><para>Special cases: <ul><li><para><c> toRadians(+0.0) = +0.0 </c>  </para></li><li><para><c> toRadians(-0.0) = -0.0 </c>  </para></li><li><para><c> toRadians(+infinity) = +infinity </c>  </para></li><li><para><c> toRadians(-infinity) = -infinity </c>  </para></li><li><para><c> toRadians(NaN) = NaN </c>  </para></li></ul></para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the radian measure of the angle. </para>
				/// </returns>
				/// <java-name>
				/// toRadians
				/// </java-name>
				[Dot42.DexImport("toRadians", "(D)D", AccessFlags = 9)]
				public static double ToRadians(double angdeg) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <summary>
				/// <para>Returns the measure in degrees of the supplied radian angle. The result is <c> angrad * 180 / pi </c> . </para><para>Special cases: <ul><li><para><c> toDegrees(+0.0) = +0.0 </c>  </para></li><li><para><c> toDegrees(-0.0) = -0.0 </c>  </para></li><li><para><c> toDegrees(+infinity) = +infinity </c>  </para></li><li><para><c> toDegrees(-infinity) = -infinity </c>  </para></li><li><para><c> toDegrees(NaN) = NaN </c>  </para></li></ul></para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the degree measure of the angle. </para>
				/// </returns>
				/// <java-name>
				/// toDegrees
				/// </java-name>
				[Dot42.DexImport("toDegrees", "(D)D", AccessFlags = 9)]
				public static double ToDegrees(double angrad) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <summary>
				/// <para>Returns the argument's ulp (unit in the last place). The size of a ulp of a double value is the positive distance between this value and the double value next larger in magnitude. For non-NaN <c> x </c> , <c> ulp(-x) ==       ulp(x) </c> . </para><para>Special cases: <ul><li><para><c> ulp(+0.0) = Double.MIN_VALUE </c>  </para></li><li><para><c> ulp(-0.0) = Double.MIN_VALUE </c>  </para></li><li><para><c> ulp(+infinity) = infinity </c>  </para></li><li><para><c> ulp(-infinity) = infinity </c>  </para></li><li><para><c> ulp(NaN) = NaN </c>  </para></li></ul></para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the size of a ulp of the argument. </para>
				/// </returns>
				/// <java-name>
				/// ulp
				/// </java-name>
				[Dot42.DexImport("ulp", "(D)D", AccessFlags = 9)]
				public static double Ulp(double d) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <summary>
				/// <para>Returns the argument's ulp (unit in the last place). The size of a ulp of a double value is the positive distance between this value and the double value next larger in magnitude. For non-NaN <c> x </c> , <c> ulp(-x) ==       ulp(x) </c> . </para><para>Special cases: <ul><li><para><c> ulp(+0.0) = Double.MIN_VALUE </c>  </para></li><li><para><c> ulp(-0.0) = Double.MIN_VALUE </c>  </para></li><li><para><c> ulp(+infinity) = infinity </c>  </para></li><li><para><c> ulp(-infinity) = infinity </c>  </para></li><li><para><c> ulp(NaN) = NaN </c>  </para></li></ul></para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the size of a ulp of the argument. </para>
				/// </returns>
				/// <java-name>
				/// ulp
				/// </java-name>
				[Dot42.DexImport("ulp", "(F)F", AccessFlags = 9)]
				public static float Ulp(float d) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				/// <para>Returns a double with the given magnitude and the sign of <c> sign </c> . If <c> sign </c> is NaN, the sign of the result is arbitrary. If you need a determinate sign in such cases, use <c> StrictMath.copySign </c> . <para>1.6 </para></para>        
				/// </summary>
				/// <java-name>
				/// copySign
				/// </java-name>
				[Dot42.DexImport("copySign", "(DD)D", AccessFlags = 9)]
				public static double CopySign(double magnitude, double sign) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <summary>
				/// <para>Returns a double with the given magnitude and the sign of <c> sign </c> . If <c> sign </c> is NaN, the sign of the result is arbitrary. If you need a determinate sign in such cases, use <c> StrictMath.copySign </c> . <para>1.6 </para></para>        
				/// </summary>
				/// <java-name>
				/// copySign
				/// </java-name>
				[Dot42.DexImport("copySign", "(FF)F", AccessFlags = 9)]
				public static float CopySign(float magnitude, float sign) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				/// <para>Returns the unbiased base-2 exponent of float <c> f </c> . <para>1.6 </para></para>        
				/// </summary>
				/// <java-name>
				/// getExponent
				/// </java-name>
				[Dot42.DexImport("getExponent", "(F)I", AccessFlags = 9)]
				public static int GetExponent(float f) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the unbiased base-2 exponent of float <c> f </c> . <para>1.6 </para></para>        
				/// </summary>
				/// <java-name>
				/// getExponent
				/// </java-name>
				[Dot42.DexImport("getExponent", "(D)I", AccessFlags = 9)]
				public static int GetExponent(double f) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the next double after <c> start </c> in the given <c> direction </c> . <para>1.6 </para></para>        
				/// </summary>
				/// <java-name>
				/// nextAfter
				/// </java-name>
				[Dot42.DexImport("nextAfter", "(DD)D", AccessFlags = 9)]
				public static double NextAfter(double start, double direction) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <summary>
				/// <para>Returns the next double after <c> start </c> in the given <c> direction </c> . <para>1.6 </para></para>        
				/// </summary>
				/// <java-name>
				/// nextAfter
				/// </java-name>
				[Dot42.DexImport("nextAfter", "(FD)F", AccessFlags = 9)]
				public static float NextAfter(float start, double direction) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				/// <para>Returns the next double larger than <c> d </c> . <para>1.6 </para></para>        
				/// </summary>
				/// <java-name>
				/// nextUp
				/// </java-name>
				[Dot42.DexImport("nextUp", "(D)D", AccessFlags = 9)]
				public static double NextUp(double d) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <summary>
				/// <para>Returns the next double larger than <c> d </c> . <para>1.6 </para></para>        
				/// </summary>
				/// <java-name>
				/// nextUp
				/// </java-name>
				[Dot42.DexImport("nextUp", "(F)F", AccessFlags = 9)]
				public static float NextUp(float d) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				/// <para>Returns <c> d </c> * 2^<c> scaleFactor </c> . The result may be rounded. <para>1.6 </para></para>        
				/// </summary>
				/// <java-name>
				/// scalb
				/// </java-name>
				[Dot42.DexImport("scalb", "(DI)D", AccessFlags = 9)]
				public static double Scalb(double d, int scaleFactor) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <summary>
				/// <para>Returns <c> d </c> * 2^<c> scaleFactor </c> . The result may be rounded. <para>1.6 </para></para>        
				/// </summary>
				/// <java-name>
				/// scalb
				/// </java-name>
				[Dot42.DexImport("scalb", "(FI)F", AccessFlags = 9)]
				public static float Scalb(float d, int scaleFactor) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

		}

		/// <summary>
		/// <para>Thrown when a request for memory is made that can not be satisfied using the available platform resources. Such a request may be made by both the running application or by an internal function of the VM. </para>    
		/// </summary>
		/// <java-name>
		/// java/lang/OutOfMemoryError
		/// </java-name>
		[Dot42.DexImport("java/lang/OutOfMemoryError", AccessFlags = 33)]
		public partial class OutOfMemoryException : global::Java.Lang.VirtualMachineError
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs a new <c> OutOfMemoryError </c> that includes the current stack trace. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public OutOfMemoryException() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a new <c> OutOfMemoryError </c> with the current stack trace and the specified detail message.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public OutOfMemoryException(string detailMessage) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>The wrapper for the primitive type <c> char </c> . This class also provides a number of utility methods for working with characters.</para><para>Character data is kept up to date as Unicode evolves. See the  section of the <c> Locale </c> documentation for details of the Unicode versions implemented by current and historical Android releases.</para><para>The Unicode specification, character tables, and other information are available at .</para><para>Unicode characters are referred to as <b>code points</b>. The range of valid code points is U+0000 to U+10FFFF. The <b>Basic Multilingual Plane (BMP)</b> is the code point range U+0000 to U+FFFF. Characters above the BMP are referred to as <b>Supplementary Characters</b>. On the Java platform, UTF-16 encoding and <c> char </c> pairs are used to represent code points in the supplementary range. A pair of <c> char </c> values that represent a supplementary character are made up of a <b>high surrogate</b> with a value range of 0xD800 to 0xDBFF and a <b>low surrogate</b> with a value range of 0xDC00 to 0xDFFF. </para><para>On the Java platform a <c> char </c> value represents either a single BMP code point or a UTF-16 unit that's part of a surrogate pair. The <c> int </c> type is used to represent all Unicode code points.</para><para><h3>Unicode categories</h3></para><para>Here's a list of the Unicode character categories and the corresponding Java constant, grouped semantically to provide a convenient overview. This table is also useful in conjunction with <c> \p </c> and <c> \P </c> in regular expressions.  &lt;style type="text/css"&gt; .datatable td { padding-right: 20px; } &lt;/style&gt; </para><para><table><row><entry><para>Cn  </para></entry><entry><para>Unassigned  </para></entry><entry><para>UNASSIGNED  </para></entry></row><row><entry><para>Cc  </para></entry><entry><para>Control  </para></entry><entry><para>CONTROL  </para></entry></row><row><entry><para>Cf  </para></entry><entry><para>Format  </para></entry><entry><para>FORMAT  </para></entry></row><row><entry><para>Co  </para></entry><entry><para>Private use  </para></entry><entry><para>PRIVATE_USE  </para></entry></row><row><entry><para>Cs  </para></entry><entry><para>Surrogate  </para></entry><entry><para>SURROGATE  </para></entry></row><row><entry><para><br></br>  </para></entry></row><row><entry><para>Lu  </para></entry><entry><para>Uppercase letter  </para></entry><entry><para>UPPERCASE_LETTER  </para></entry></row><row><entry><para>Ll  </para></entry><entry><para>Lowercase letter  </para></entry><entry><para>LOWERCASE_LETTER  </para></entry></row><row><entry><para>Lt  </para></entry><entry><para>Titlecase letter  </para></entry><entry><para>TITLECASE_LETTER  </para></entry></row><row><entry><para>Lm  </para></entry><entry><para>Modifier letter  </para></entry><entry><para>MODIFIER_LETTER  </para></entry></row><row><entry><para>Lo  </para></entry><entry><para>Other letter  </para></entry><entry><para>OTHER_LETTER  </para></entry></row><row><entry><para><br></br>  </para></entry></row><row><entry><para>Mn  </para></entry><entry><para>Non-spacing mark  </para></entry><entry><para>NON_SPACING_MARK  </para></entry></row><row><entry><para>Me  </para></entry><entry><para>Enclosing mark  </para></entry><entry><para>ENCLOSING_MARK  </para></entry></row><row><entry><para>Mc  </para></entry><entry><para>Combining spacing mark  </para></entry><entry><para>COMBINING_SPACING_MARK  </para></entry></row><row><entry><para><br></br>  </para></entry></row><row><entry><para>Nd  </para></entry><entry><para>Decimal digit number  </para></entry><entry><para>DECIMAL_DIGIT_NUMBER  </para></entry></row><row><entry><para>Nl  </para></entry><entry><para>Letter number  </para></entry><entry><para>LETTER_NUMBER  </para></entry></row><row><entry><para>No  </para></entry><entry><para>Other number  </para></entry><entry><para>OTHER_NUMBER  </para></entry></row><row><entry><para><br></br>  </para></entry></row><row><entry><para>Pd  </para></entry><entry><para>Dash punctuation  </para></entry><entry><para>DASH_PUNCTUATION  </para></entry></row><row><entry><para>Ps  </para></entry><entry><para>Start punctuation  </para></entry><entry><para>START_PUNCTUATION  </para></entry></row><row><entry><para>Pe  </para></entry><entry><para>End punctuation  </para></entry><entry><para>END_PUNCTUATION  </para></entry></row><row><entry><para>Pc  </para></entry><entry><para>Connector punctuation  </para></entry><entry><para>CONNECTOR_PUNCTUATION  </para></entry></row><row><entry><para>Pi  </para></entry><entry><para>Initial quote punctuation  </para></entry><entry><para>INITIAL_QUOTE_PUNCTUATION  </para></entry></row><row><entry><para>Pf  </para></entry><entry><para>Final quote punctuation  </para></entry><entry><para>FINAL_QUOTE_PUNCTUATION  </para></entry></row><row><entry><para>Po  </para></entry><entry><para>Other punctuation  </para></entry><entry><para>OTHER_PUNCTUATION  </para></entry></row><row><entry><para><br></br>  </para></entry></row><row><entry><para>Sm  </para></entry><entry><para>Math symbol  </para></entry><entry><para>MATH_SYMBOL  </para></entry></row><row><entry><para>Sc  </para></entry><entry><para>Currency symbol  </para></entry><entry><para>CURRENCY_SYMBOL  </para></entry></row><row><entry><para>Sk  </para></entry><entry><para>Modifier symbol  </para></entry><entry><para>MODIFIER_SYMBOL  </para></entry></row><row><entry><para>So  </para></entry><entry><para>Other symbol  </para></entry><entry><para>OTHER_SYMBOL  </para></entry></row><row><entry><para><br></br>  </para></entry></row><row><entry><para>Zs  </para></entry><entry><para>Space separator  </para></entry><entry><para>SPACE_SEPARATOR  </para></entry></row><row><entry><para>Zl  </para></entry><entry><para>Line separator  </para></entry><entry><para>LINE_SEPARATOR  </para></entry></row><row><entry><para>Zp  </para></entry><entry><para>Paragraph separator  </para></entry><entry><para>PARAGRAPH_SEPARATOR  </para></entry></row></table></para><para><para>1.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// java/lang/Character
		/// </java-name>
		[Dot42.DexImport("java/lang/Character", AccessFlags = 49, Signature = "Ljava/lang/Object;Ljava/io/Serializable;Ljava/lang/Comparable<Ljava/lang/Characte" +
    "r;>;")]
		public partial struct Char : global::Java.Io.ISerializable, global::System.IComparable<char?>
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>The minimum <c> Character </c> value. </para>        
				/// </summary>
				/// <java-name>
				/// MIN_VALUE
				/// </java-name>
				[Dot42.DexImport("MIN_VALUE", "C", AccessFlags = 25)]
				public const char MinValue = '\0';
				/// <summary>
				/// <para>The maximum <c> Character </c> value. </para>        
				/// </summary>
				/// <java-name>
				/// MAX_VALUE
				/// </java-name>
				[Dot42.DexImport("MAX_VALUE", "C", AccessFlags = 25)]
				public const char MaxValue = '￿';
				/// <summary>
				/// <para>The minimum radix used for conversions between characters and integers. </para>        
				/// </summary>
				/// <java-name>
				/// MIN_RADIX
				/// </java-name>
				[Dot42.DexImport("MIN_RADIX", "I", AccessFlags = 25)]
				public const int MIN_RADIX = 2;
				/// <summary>
				/// <para>The maximum radix used for conversions between characters and integers. </para>        
				/// </summary>
				/// <java-name>
				/// MAX_RADIX
				/// </java-name>
				[Dot42.DexImport("MAX_RADIX", "I", AccessFlags = 25)]
				public const int MAX_RADIX = 36;
				/// <summary>
				/// <para>The Class object that represents the primitive type <c> char </c> . </para>        
				/// </summary>
				/// <java-name>
				/// TYPE
				/// </java-name>
				[Dot42.DexImport("TYPE", "Ljava/lang/Class;", AccessFlags = 25)]
				public static readonly global::System.Type TYPE;
				/// <summary>
				/// <para>Unicode category constant Cn. </para>        
				/// </summary>
				/// <java-name>
				/// UNASSIGNED
				/// </java-name>
				[Dot42.DexImport("UNASSIGNED", "B", AccessFlags = 25)]
				public const sbyte UNASSIGNED = 0;
				/// <summary>
				/// <para>Unicode category constant Lu. </para>        
				/// </summary>
				/// <java-name>
				/// UPPERCASE_LETTER
				/// </java-name>
				[Dot42.DexImport("UPPERCASE_LETTER", "B", AccessFlags = 25)]
				public const sbyte UPPERCASE_LETTER = 1;
				/// <summary>
				/// <para>Unicode category constant Ll. </para>        
				/// </summary>
				/// <java-name>
				/// LOWERCASE_LETTER
				/// </java-name>
				[Dot42.DexImport("LOWERCASE_LETTER", "B", AccessFlags = 25)]
				public const sbyte LOWERCASE_LETTER = 2;
				/// <summary>
				/// <para>Unicode category constant Lt. </para>        
				/// </summary>
				/// <java-name>
				/// TITLECASE_LETTER
				/// </java-name>
				[Dot42.DexImport("TITLECASE_LETTER", "B", AccessFlags = 25)]
				public const sbyte TITLECASE_LETTER = 3;
				/// <summary>
				/// <para>Unicode category constant Lm. </para>        
				/// </summary>
				/// <java-name>
				/// MODIFIER_LETTER
				/// </java-name>
				[Dot42.DexImport("MODIFIER_LETTER", "B", AccessFlags = 25)]
				public const sbyte MODIFIER_LETTER = 4;
				/// <summary>
				/// <para>Unicode category constant Lo. </para>        
				/// </summary>
				/// <java-name>
				/// OTHER_LETTER
				/// </java-name>
				[Dot42.DexImport("OTHER_LETTER", "B", AccessFlags = 25)]
				public const sbyte OTHER_LETTER = 5;
				/// <summary>
				/// <para>Unicode category constant Mn. </para>        
				/// </summary>
				/// <java-name>
				/// NON_SPACING_MARK
				/// </java-name>
				[Dot42.DexImport("NON_SPACING_MARK", "B", AccessFlags = 25)]
				public const sbyte NON_SPACING_MARK = 6;
				/// <summary>
				/// <para>Unicode category constant Me. </para>        
				/// </summary>
				/// <java-name>
				/// ENCLOSING_MARK
				/// </java-name>
				[Dot42.DexImport("ENCLOSING_MARK", "B", AccessFlags = 25)]
				public const sbyte ENCLOSING_MARK = 7;
				/// <summary>
				/// <para>Unicode category constant Mc. </para>        
				/// </summary>
				/// <java-name>
				/// COMBINING_SPACING_MARK
				/// </java-name>
				[Dot42.DexImport("COMBINING_SPACING_MARK", "B", AccessFlags = 25)]
				public const sbyte COMBINING_SPACING_MARK = 8;
				/// <summary>
				/// <para>Unicode category constant Nd. </para>        
				/// </summary>
				/// <java-name>
				/// DECIMAL_DIGIT_NUMBER
				/// </java-name>
				[Dot42.DexImport("DECIMAL_DIGIT_NUMBER", "B", AccessFlags = 25)]
				public const sbyte DECIMAL_DIGIT_NUMBER = 9;
				/// <summary>
				/// <para>Unicode category constant Nl. </para>        
				/// </summary>
				/// <java-name>
				/// LETTER_NUMBER
				/// </java-name>
				[Dot42.DexImport("LETTER_NUMBER", "B", AccessFlags = 25)]
				public const sbyte LETTER_NUMBER = 10;
				/// <summary>
				/// <para>Unicode category constant No. </para>        
				/// </summary>
				/// <java-name>
				/// OTHER_NUMBER
				/// </java-name>
				[Dot42.DexImport("OTHER_NUMBER", "B", AccessFlags = 25)]
				public const sbyte OTHER_NUMBER = 11;
				/// <summary>
				/// <para>Unicode category constant Zs. </para>        
				/// </summary>
				/// <java-name>
				/// SPACE_SEPARATOR
				/// </java-name>
				[Dot42.DexImport("SPACE_SEPARATOR", "B", AccessFlags = 25)]
				public const sbyte SPACE_SEPARATOR = 12;
				/// <summary>
				/// <para>Unicode category constant Zl. </para>        
				/// </summary>
				/// <java-name>
				/// LINE_SEPARATOR
				/// </java-name>
				[Dot42.DexImport("LINE_SEPARATOR", "B", AccessFlags = 25)]
				public const sbyte LINE_SEPARATOR = 13;
				/// <summary>
				/// <para>Unicode category constant Zp. </para>        
				/// </summary>
				/// <java-name>
				/// PARAGRAPH_SEPARATOR
				/// </java-name>
				[Dot42.DexImport("PARAGRAPH_SEPARATOR", "B", AccessFlags = 25)]
				public const sbyte PARAGRAPH_SEPARATOR = 14;
				/// <summary>
				/// <para>Unicode category constant Cc. </para>        
				/// </summary>
				/// <java-name>
				/// CONTROL
				/// </java-name>
				[Dot42.DexImport("CONTROL", "B", AccessFlags = 25)]
				public const sbyte CONTROL = 15;
				/// <summary>
				/// <para>Unicode category constant Cf. </para>        
				/// </summary>
				/// <java-name>
				/// FORMAT
				/// </java-name>
				[Dot42.DexImport("FORMAT", "B", AccessFlags = 25)]
				public const sbyte FORMAT = 16;
				/// <summary>
				/// <para>Unicode category constant Co. </para>        
				/// </summary>
				/// <java-name>
				/// PRIVATE_USE
				/// </java-name>
				[Dot42.DexImport("PRIVATE_USE", "B", AccessFlags = 25)]
				public const sbyte PRIVATE_USE = 18;
				/// <summary>
				/// <para>Unicode category constant Cs. </para>        
				/// </summary>
				/// <java-name>
				/// SURROGATE
				/// </java-name>
				[Dot42.DexImport("SURROGATE", "B", AccessFlags = 25)]
				public const sbyte SURROGATE = 19;
				/// <summary>
				/// <para>Unicode category constant Pd. </para>        
				/// </summary>
				/// <java-name>
				/// DASH_PUNCTUATION
				/// </java-name>
				[Dot42.DexImport("DASH_PUNCTUATION", "B", AccessFlags = 25)]
				public const sbyte DASH_PUNCTUATION = 20;
				/// <summary>
				/// <para>Unicode category constant Ps. </para>        
				/// </summary>
				/// <java-name>
				/// START_PUNCTUATION
				/// </java-name>
				[Dot42.DexImport("START_PUNCTUATION", "B", AccessFlags = 25)]
				public const sbyte START_PUNCTUATION = 21;
				/// <summary>
				/// <para>Unicode category constant Pe. </para>        
				/// </summary>
				/// <java-name>
				/// END_PUNCTUATION
				/// </java-name>
				[Dot42.DexImport("END_PUNCTUATION", "B", AccessFlags = 25)]
				public const sbyte END_PUNCTUATION = 22;
				/// <summary>
				/// <para>Unicode category constant Pc. </para>        
				/// </summary>
				/// <java-name>
				/// CONNECTOR_PUNCTUATION
				/// </java-name>
				[Dot42.DexImport("CONNECTOR_PUNCTUATION", "B", AccessFlags = 25)]
				public const sbyte CONNECTOR_PUNCTUATION = 23;
				/// <summary>
				/// <para>Unicode category constant Po. </para>        
				/// </summary>
				/// <java-name>
				/// OTHER_PUNCTUATION
				/// </java-name>
				[Dot42.DexImport("OTHER_PUNCTUATION", "B", AccessFlags = 25)]
				public const sbyte OTHER_PUNCTUATION = 24;
				/// <summary>
				/// <para>Unicode category constant Sm. </para>        
				/// </summary>
				/// <java-name>
				/// MATH_SYMBOL
				/// </java-name>
				[Dot42.DexImport("MATH_SYMBOL", "B", AccessFlags = 25)]
				public const sbyte MATH_SYMBOL = 25;
				/// <summary>
				/// <para>Unicode category constant Sc. </para>        
				/// </summary>
				/// <java-name>
				/// CURRENCY_SYMBOL
				/// </java-name>
				[Dot42.DexImport("CURRENCY_SYMBOL", "B", AccessFlags = 25)]
				public const sbyte CURRENCY_SYMBOL = 26;
				/// <summary>
				/// <para>Unicode category constant Sk. </para>        
				/// </summary>
				/// <java-name>
				/// MODIFIER_SYMBOL
				/// </java-name>
				[Dot42.DexImport("MODIFIER_SYMBOL", "B", AccessFlags = 25)]
				public const sbyte MODIFIER_SYMBOL = 27;
				/// <summary>
				/// <para>Unicode category constant So. </para>        
				/// </summary>
				/// <java-name>
				/// OTHER_SYMBOL
				/// </java-name>
				[Dot42.DexImport("OTHER_SYMBOL", "B", AccessFlags = 25)]
				public const sbyte OTHER_SYMBOL = 28;
				/// <summary>
				/// <para>Unicode category constant Pi.</para><para><para>1.4 </para></para>        
				/// </summary>
				/// <java-name>
				/// INITIAL_QUOTE_PUNCTUATION
				/// </java-name>
				[Dot42.DexImport("INITIAL_QUOTE_PUNCTUATION", "B", AccessFlags = 25)]
				public const sbyte INITIAL_QUOTE_PUNCTUATION = 29;
				/// <summary>
				/// <para>Unicode category constant Pf.</para><para><para>1.4 </para></para>        
				/// </summary>
				/// <java-name>
				/// FINAL_QUOTE_PUNCTUATION
				/// </java-name>
				[Dot42.DexImport("FINAL_QUOTE_PUNCTUATION", "B", AccessFlags = 25)]
				public const sbyte FINAL_QUOTE_PUNCTUATION = 30;
				/// <summary>
				/// <para>Unicode bidirectional constant.</para><para><para>1.4 </para></para>        
				/// </summary>
				/// <java-name>
				/// DIRECTIONALITY_UNDEFINED
				/// </java-name>
				[Dot42.DexImport("DIRECTIONALITY_UNDEFINED", "B", AccessFlags = 25)]
				public const sbyte DIRECTIONALITY_UNDEFINED = -1;
				/// <summary>
				/// <para>Unicode bidirectional constant L.</para><para><para>1.4 </para></para>        
				/// </summary>
				/// <java-name>
				/// DIRECTIONALITY_LEFT_TO_RIGHT
				/// </java-name>
				[Dot42.DexImport("DIRECTIONALITY_LEFT_TO_RIGHT", "B", AccessFlags = 25)]
				public const sbyte DIRECTIONALITY_LEFT_TO_RIGHT = 0;
				/// <summary>
				/// <para>Unicode bidirectional constant R.</para><para><para>1.4 </para></para>        
				/// </summary>
				/// <java-name>
				/// DIRECTIONALITY_RIGHT_TO_LEFT
				/// </java-name>
				[Dot42.DexImport("DIRECTIONALITY_RIGHT_TO_LEFT", "B", AccessFlags = 25)]
				public const sbyte DIRECTIONALITY_RIGHT_TO_LEFT = 1;
				/// <summary>
				/// <para>Unicode bidirectional constant AL.</para><para><para>1.4 </para></para>        
				/// </summary>
				/// <java-name>
				/// DIRECTIONALITY_RIGHT_TO_LEFT_ARABIC
				/// </java-name>
				[Dot42.DexImport("DIRECTIONALITY_RIGHT_TO_LEFT_ARABIC", "B", AccessFlags = 25)]
				public const sbyte DIRECTIONALITY_RIGHT_TO_LEFT_ARABIC = 2;
				/// <summary>
				/// <para>Unicode bidirectional constant EN.</para><para><para>1.4 </para></para>        
				/// </summary>
				/// <java-name>
				/// DIRECTIONALITY_EUROPEAN_NUMBER
				/// </java-name>
				[Dot42.DexImport("DIRECTIONALITY_EUROPEAN_NUMBER", "B", AccessFlags = 25)]
				public const sbyte DIRECTIONALITY_EUROPEAN_NUMBER = 3;
				/// <summary>
				/// <para>Unicode bidirectional constant ES.</para><para><para>1.4 </para></para>        
				/// </summary>
				/// <java-name>
				/// DIRECTIONALITY_EUROPEAN_NUMBER_SEPARATOR
				/// </java-name>
				[Dot42.DexImport("DIRECTIONALITY_EUROPEAN_NUMBER_SEPARATOR", "B", AccessFlags = 25)]
				public const sbyte DIRECTIONALITY_EUROPEAN_NUMBER_SEPARATOR = 4;
				/// <summary>
				/// <para>Unicode bidirectional constant ET.</para><para><para>1.4 </para></para>        
				/// </summary>
				/// <java-name>
				/// DIRECTIONALITY_EUROPEAN_NUMBER_TERMINATOR
				/// </java-name>
				[Dot42.DexImport("DIRECTIONALITY_EUROPEAN_NUMBER_TERMINATOR", "B", AccessFlags = 25)]
				public const sbyte DIRECTIONALITY_EUROPEAN_NUMBER_TERMINATOR = 5;
				/// <summary>
				/// <para>Unicode bidirectional constant AN.</para><para><para>1.4 </para></para>        
				/// </summary>
				/// <java-name>
				/// DIRECTIONALITY_ARABIC_NUMBER
				/// </java-name>
				[Dot42.DexImport("DIRECTIONALITY_ARABIC_NUMBER", "B", AccessFlags = 25)]
				public const sbyte DIRECTIONALITY_ARABIC_NUMBER = 6;
				/// <summary>
				/// <para>Unicode bidirectional constant CS.</para><para><para>1.4 </para></para>        
				/// </summary>
				/// <java-name>
				/// DIRECTIONALITY_COMMON_NUMBER_SEPARATOR
				/// </java-name>
				[Dot42.DexImport("DIRECTIONALITY_COMMON_NUMBER_SEPARATOR", "B", AccessFlags = 25)]
				public const sbyte DIRECTIONALITY_COMMON_NUMBER_SEPARATOR = 7;
				/// <summary>
				/// <para>Unicode bidirectional constant NSM.</para><para><para>1.4 </para></para>        
				/// </summary>
				/// <java-name>
				/// DIRECTIONALITY_NONSPACING_MARK
				/// </java-name>
				[Dot42.DexImport("DIRECTIONALITY_NONSPACING_MARK", "B", AccessFlags = 25)]
				public const sbyte DIRECTIONALITY_NONSPACING_MARK = 8;
				/// <summary>
				/// <para>Unicode bidirectional constant BN.</para><para><para>1.4 </para></para>        
				/// </summary>
				/// <java-name>
				/// DIRECTIONALITY_BOUNDARY_NEUTRAL
				/// </java-name>
				[Dot42.DexImport("DIRECTIONALITY_BOUNDARY_NEUTRAL", "B", AccessFlags = 25)]
				public const sbyte DIRECTIONALITY_BOUNDARY_NEUTRAL = 9;
				/// <summary>
				/// <para>Unicode bidirectional constant B.</para><para><para>1.4 </para></para>        
				/// </summary>
				/// <java-name>
				/// DIRECTIONALITY_PARAGRAPH_SEPARATOR
				/// </java-name>
				[Dot42.DexImport("DIRECTIONALITY_PARAGRAPH_SEPARATOR", "B", AccessFlags = 25)]
				public const sbyte DIRECTIONALITY_PARAGRAPH_SEPARATOR = 10;
				/// <summary>
				/// <para>Unicode bidirectional constant S.</para><para><para>1.4 </para></para>        
				/// </summary>
				/// <java-name>
				/// DIRECTIONALITY_SEGMENT_SEPARATOR
				/// </java-name>
				[Dot42.DexImport("DIRECTIONALITY_SEGMENT_SEPARATOR", "B", AccessFlags = 25)]
				public const sbyte DIRECTIONALITY_SEGMENT_SEPARATOR = 11;
				/// <summary>
				/// <para>Unicode bidirectional constant WS.</para><para><para>1.4 </para></para>        
				/// </summary>
				/// <java-name>
				/// DIRECTIONALITY_WHITESPACE
				/// </java-name>
				[Dot42.DexImport("DIRECTIONALITY_WHITESPACE", "B", AccessFlags = 25)]
				public const sbyte DIRECTIONALITY_WHITESPACE = 12;
				/// <summary>
				/// <para>Unicode bidirectional constant ON.</para><para><para>1.4 </para></para>        
				/// </summary>
				/// <java-name>
				/// DIRECTIONALITY_OTHER_NEUTRALS
				/// </java-name>
				[Dot42.DexImport("DIRECTIONALITY_OTHER_NEUTRALS", "B", AccessFlags = 25)]
				public const sbyte DIRECTIONALITY_OTHER_NEUTRALS = 13;
				/// <summary>
				/// <para>Unicode bidirectional constant LRE.</para><para><para>1.4 </para></para>        
				/// </summary>
				/// <java-name>
				/// DIRECTIONALITY_LEFT_TO_RIGHT_EMBEDDING
				/// </java-name>
				[Dot42.DexImport("DIRECTIONALITY_LEFT_TO_RIGHT_EMBEDDING", "B", AccessFlags = 25)]
				public const sbyte DIRECTIONALITY_LEFT_TO_RIGHT_EMBEDDING = 14;
				/// <summary>
				/// <para>Unicode bidirectional constant LRO.</para><para><para>1.4 </para></para>        
				/// </summary>
				/// <java-name>
				/// DIRECTIONALITY_LEFT_TO_RIGHT_OVERRIDE
				/// </java-name>
				[Dot42.DexImport("DIRECTIONALITY_LEFT_TO_RIGHT_OVERRIDE", "B", AccessFlags = 25)]
				public const sbyte DIRECTIONALITY_LEFT_TO_RIGHT_OVERRIDE = 15;
				/// <summary>
				/// <para>Unicode bidirectional constant RLE.</para><para><para>1.4 </para></para>        
				/// </summary>
				/// <java-name>
				/// DIRECTIONALITY_RIGHT_TO_LEFT_EMBEDDING
				/// </java-name>
				[Dot42.DexImport("DIRECTIONALITY_RIGHT_TO_LEFT_EMBEDDING", "B", AccessFlags = 25)]
				public const sbyte DIRECTIONALITY_RIGHT_TO_LEFT_EMBEDDING = 16;
				/// <summary>
				/// <para>Unicode bidirectional constant RLO.</para><para><para>1.4 </para></para>        
				/// </summary>
				/// <java-name>
				/// DIRECTIONALITY_RIGHT_TO_LEFT_OVERRIDE
				/// </java-name>
				[Dot42.DexImport("DIRECTIONALITY_RIGHT_TO_LEFT_OVERRIDE", "B", AccessFlags = 25)]
				public const sbyte DIRECTIONALITY_RIGHT_TO_LEFT_OVERRIDE = 17;
				/// <summary>
				/// <para>Unicode bidirectional constant PDF.</para><para><para>1.4 </para></para>        
				/// </summary>
				/// <java-name>
				/// DIRECTIONALITY_POP_DIRECTIONAL_FORMAT
				/// </java-name>
				[Dot42.DexImport("DIRECTIONALITY_POP_DIRECTIONAL_FORMAT", "B", AccessFlags = 25)]
				public const sbyte DIRECTIONALITY_POP_DIRECTIONAL_FORMAT = 18;
				/// <summary>
				/// <para>The minimum value of a high surrogate or leading surrogate unit in UTF-16 encoding, <c> '\uD800' </c> .</para><para><para>1.5 </para></para>        
				/// </summary>
				/// <java-name>
				/// MIN_HIGH_SURROGATE
				/// </java-name>
				[Dot42.DexImport("MIN_HIGH_SURROGATE", "C", AccessFlags = 25)]
				public const char MIN_HIGH_SURROGATE = '\uD800';
				/// <summary>
				/// <para>The maximum value of a high surrogate or leading surrogate unit in UTF-16 encoding, <c> '\uDBFF' </c> .</para><para><para>1.5 </para></para>        
				/// </summary>
				/// <java-name>
				/// MAX_HIGH_SURROGATE
				/// </java-name>
				[Dot42.DexImport("MAX_HIGH_SURROGATE", "C", AccessFlags = 25)]
				public const char MAX_HIGH_SURROGATE = '\uDBFF';
				/// <summary>
				/// <para>The minimum value of a low surrogate or trailing surrogate unit in UTF-16 encoding, <c> '\uDC00' </c> .</para><para><para>1.5 </para></para>        
				/// </summary>
				/// <java-name>
				/// MIN_LOW_SURROGATE
				/// </java-name>
				[Dot42.DexImport("MIN_LOW_SURROGATE", "C", AccessFlags = 25)]
				public const char MIN_LOW_SURROGATE = '\uDC00';
				/// <summary>
				/// <para>The maximum value of a low surrogate or trailing surrogate unit in UTF-16 encoding, <c> '\uDFFF' </c> .</para><para><para>1.5 </para></para>        
				/// </summary>
				/// <java-name>
				/// MAX_LOW_SURROGATE
				/// </java-name>
				[Dot42.DexImport("MAX_LOW_SURROGATE", "C", AccessFlags = 25)]
				public const char MAX_LOW_SURROGATE = '\uDFFF';
				/// <summary>
				/// <para>The minimum value of a surrogate unit in UTF-16 encoding, <c> '\uD800' </c> .</para><para><para>1.5 </para></para>        
				/// </summary>
				/// <java-name>
				/// MIN_SURROGATE
				/// </java-name>
				[Dot42.DexImport("MIN_SURROGATE", "C", AccessFlags = 25)]
				public const char MIN_SURROGATE = '\uD800';
				/// <summary>
				/// <para>The maximum value of a surrogate unit in UTF-16 encoding, <c> '\uDFFF' </c> .</para><para><para>1.5 </para></para>        
				/// </summary>
				/// <java-name>
				/// MAX_SURROGATE
				/// </java-name>
				[Dot42.DexImport("MAX_SURROGATE", "C", AccessFlags = 25)]
				public const char MAX_SURROGATE = '\uDFFF';
				/// <summary>
				/// <para>The minimum value of a supplementary code point, <c> U+010000 </c> .</para><para><para>1.5 </para></para>        
				/// </summary>
				/// <java-name>
				/// MIN_SUPPLEMENTARY_CODE_POINT
				/// </java-name>
				[Dot42.DexImport("MIN_SUPPLEMENTARY_CODE_POINT", "I", AccessFlags = 25)]
				public const int MIN_SUPPLEMENTARY_CODE_POINT = 65536;
				/// <summary>
				/// <para>The minimum code point value, <c> U+0000 </c> .</para><para><para>1.5 </para></para>        
				/// </summary>
				/// <java-name>
				/// MIN_CODE_POINT
				/// </java-name>
				[Dot42.DexImport("MIN_CODE_POINT", "I", AccessFlags = 25)]
				public const int MIN_CODE_POINT = 0;
				/// <summary>
				/// <para>The maximum code point value, <c> U+10FFFF </c> .</para><para><para>1.5 </para></para>        
				/// </summary>
				/// <java-name>
				/// MAX_CODE_POINT
				/// </java-name>
				[Dot42.DexImport("MAX_CODE_POINT", "I", AccessFlags = 25)]
				public const int MAX_CODE_POINT = 1114111;
				/// <summary>
				/// <para>The number of bits required to represent a <c> Character </c> value unsigned form.</para><para><para>1.5 </para></para>        
				/// </summary>
				/// <java-name>
				/// SIZE
				/// </java-name>
				[Dot42.DexImport("SIZE", "I", AccessFlags = 25)]
				public const int SIZE = 16;
				/// <summary>
				/// <para>Constructs a new <c> Character </c> with the specified primitive char value.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(C)V", AccessFlags = 1)]
				public Char(char value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets the primitive value of this character.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>this object's primitive value. </para>
				/// </returns>
				/// <java-name>
				/// charValue
				/// </java-name>
				[Dot42.DexImport("charValue", "()C", AccessFlags = 1)]
				public char CharValue() /* MethodBuilder.Create */ 
				{
						return default(char);
				}

				/// <summary>
				/// <para>Compares this object to the specified character object to determine their relative order.</para><para><para>java.lang.Comparable </para><para>1.2 </para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> 0 </c> if the value of this character and the value of <c> c </c> are equal; a positive value if the value of this character is greater than the value of <c> c </c> ; a negative value if the value of this character is less than the value of <c> c </c> . </para>
				/// </returns>
				/// <java-name>
				/// compareTo
				/// </java-name>
				[Dot42.DexImport("compareTo", "(Ljava/lang/Character;)I", AccessFlags = 1)]
				public int CompareTo(char? c) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns a <c> Character </c> instance for the <c> char </c> value passed. </para><para>If it is not necessary to get a new <c> Character </c> instance, it is recommended to use this method instead of the constructor, since it maintains a cache of instances which may result in better performance.</para><para><para>1.5 </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the <c> Character </c> instance for <c> c </c> . </para>
				/// </returns>
				/// <java-name>
				/// valueOf
				/// </java-name>
				[Dot42.DexImport("valueOf", "(C)Ljava/lang/Character;", AccessFlags = 9)]
				public static char? ValueOf(char c) /* MethodBuilder.Create */ 
				{
						return default(char?);
				}

				/// <summary>
				/// <para>Indicates whether <c> codePoint </c> is a valid Unicode code point.</para><para><para>1.5 </para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if <c> codePoint </c> is a valid Unicode code point; <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isValidCodePoint
				/// </java-name>
				[Dot42.DexImport("isValidCodePoint", "(I)Z", AccessFlags = 9)]
				public static bool IsValidCodePoint(int codePoint) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Indicates whether <c> codePoint </c> is within the supplementary code point range.</para><para><para>1.5 </para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if <c> codePoint </c> is within the supplementary code point range; <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isSupplementaryCodePoint
				/// </java-name>
				[Dot42.DexImport("isSupplementaryCodePoint", "(I)Z", AccessFlags = 9)]
				public static bool IsSupplementaryCodePoint(int codePoint) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Indicates whether <c> ch </c> is a high- (or leading-) surrogate code unit that is used for representing supplementary characters in UTF-16 encoding.</para><para><para>isLowSurrogate(char) </para><para>1.5 </para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if <c> ch </c> is a high-surrogate code unit; <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isHighSurrogate
				/// </java-name>
				[Dot42.DexImport("isHighSurrogate", "(C)Z", AccessFlags = 9)]
				public static bool IsHighSurrogate(char ch) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Indicates whether <c> ch </c> is a low- (or trailing-) surrogate code unit that is used for representing supplementary characters in UTF-16 encoding.</para><para><para>isHighSurrogate(char) </para><para>1.5 </para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if <c> ch </c> is a low-surrogate code unit; <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isLowSurrogate
				/// </java-name>
				[Dot42.DexImport("isLowSurrogate", "(C)Z", AccessFlags = 9)]
				public static bool IsLowSurrogate(char ch) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Indicates whether the specified character pair is a valid surrogate pair.</para><para><para>isHighSurrogate(char) </para><simplesectsep></simplesectsep><para>isLowSurrogate(char) </para><para>1.5 </para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if <c> high </c> is a high-surrogate code unit and <c> low </c> is a low-surrogate code unit; <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isSurrogatePair
				/// </java-name>
				[Dot42.DexImport("isSurrogatePair", "(CC)Z", AccessFlags = 9)]
				public static bool IsSurrogatePair(char high, char low) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Calculates the number of <c> char </c> values required to represent the specified Unicode code point. This method checks if the <c> codePoint </c> is greater than or equal to <c> 0x10000 </c> , in which case <c> 2 </c> is returned, otherwise <c> 1 </c> . To test if the code point is valid, use the isValidCodePoint(int) method.</para><para><para>isValidCodePoint(int) </para><simplesectsep></simplesectsep><para>isSupplementaryCodePoint(int) </para><para>1.5 </para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> 2 </c> if <c> codePoint &gt;= 0x10000 </c> ; <c> 1 </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// charCount
				/// </java-name>
				[Dot42.DexImport("charCount", "(I)I", AccessFlags = 9)]
				public static int CharCount(int codePoint) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Converts a surrogate pair into a Unicode code point. This method assumes that the pair are valid surrogates. If the pair are <b>not</b> valid surrogates, then the result is indeterminate. The isSurrogatePair(char, char) method should be used prior to this method to validate the pair.</para><para><para>isSurrogatePair(char, char) </para><para>1.5 </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the Unicode code point corresponding to the surrogate unit pair. </para>
				/// </returns>
				/// <java-name>
				/// toCodePoint
				/// </java-name>
				[Dot42.DexImport("toCodePoint", "(CC)I", AccessFlags = 9)]
				public static int ToCodePoint(char high, char low) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the code point at <c> index </c> in the specified sequence of character units. If the unit at <c> index </c> is a high-surrogate unit, <c> index + 1 </c> is less than the length of the sequence and the unit at <c> index + 1 </c> is a low-surrogate unit, then the supplementary code point represented by the pair is returned; otherwise the <c> char </c> value at <c> index </c> is returned.</para><para><para>1.5 </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the Unicode code point or <c> char </c> value at <c> index </c> in <c> seq </c> . </para>
				/// </returns>
				/// <java-name>
				/// codePointAt
				/// </java-name>
				[Dot42.DexImport("codePointAt", "(Ljava/lang/CharSequence;I)I", AccessFlags = 9)]
				public static int CodePointAt(global::Java.Lang.ICharSequence seq, int index) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the code point at <c> index </c> in the specified sequence of character units. If the unit at <c> index </c> is a high-surrogate unit, <c> index + 1 </c> is less than the length of the sequence and the unit at <c> index + 1 </c> is a low-surrogate unit, then the supplementary code point represented by the pair is returned; otherwise the <c> char </c> value at <c> index </c> is returned.</para><para><para>1.5 </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the Unicode code point or <c> char </c> value at <c> index </c> in <c> seq </c> . </para>
				/// </returns>
				/// <java-name>
				/// codePointAt
				/// </java-name>
				[Dot42.DexImport("codePointAt", "([CI)I", AccessFlags = 9)]
				public static int CodePointAt(char[] seq, int index) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the code point at <c> index </c> in the specified array of character units, where <c> index </c> has to be less than <c> limit </c> . If the unit at <c> index </c> is a high-surrogate unit, <c> index + 1 </c> is less than <c> limit </c> and the unit at <c> index + 1 </c> is a low-surrogate unit, then the supplementary code point represented by the pair is returned; otherwise the <c> char </c> value at <c> index </c> is returned.</para><para><para>1.5 </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the Unicode code point or <c> char </c> value at <c> index </c> in <c> seq </c> . </para>
				/// </returns>
				/// <java-name>
				/// codePointAt
				/// </java-name>
				[Dot42.DexImport("codePointAt", "([CII)I", AccessFlags = 9)]
				public static int CodePointAt(char[] seq, int index, int limit) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the code point that precedes <c> index </c> in the specified sequence of character units. If the unit at <c> index - 1 </c> is a low-surrogate unit, <c> index - 2 </c> is not negative and the unit at <c> index - 2 </c> is a high-surrogate unit, then the supplementary code point represented by the pair is returned; otherwise the <c> char </c> value at <c> index - 1 </c> is returned.</para><para><para>1.5 </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the Unicode code point or <c> char </c> value before <c> index </c> in <c> seq </c> . </para>
				/// </returns>
				/// <java-name>
				/// codePointBefore
				/// </java-name>
				[Dot42.DexImport("codePointBefore", "(Ljava/lang/CharSequence;I)I", AccessFlags = 9)]
				public static int CodePointBefore(global::Java.Lang.ICharSequence seq, int index) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the code point that precedes <c> index </c> in the specified sequence of character units. If the unit at <c> index - 1 </c> is a low-surrogate unit, <c> index - 2 </c> is not negative and the unit at <c> index - 2 </c> is a high-surrogate unit, then the supplementary code point represented by the pair is returned; otherwise the <c> char </c> value at <c> index - 1 </c> is returned.</para><para><para>1.5 </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the Unicode code point or <c> char </c> value before <c> index </c> in <c> seq </c> . </para>
				/// </returns>
				/// <java-name>
				/// codePointBefore
				/// </java-name>
				[Dot42.DexImport("codePointBefore", "([CI)I", AccessFlags = 9)]
				public static int CodePointBefore(char[] seq, int index) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the code point that precedes the <c> index </c> in the specified array of character units and is not less than <c> start </c> . If the unit at <c> index - 1 </c> is a low-surrogate unit, <c> index - 2 </c> is not less than <c> start </c> and the unit at <c> index - 2 </c> is a high-surrogate unit, then the supplementary code point represented by the pair is returned; otherwise the <c> char </c> value at <c> index - 1 </c> is returned.</para><para><para>1.5 </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the Unicode code point or <c> char </c> value before <c> index </c> in <c> seq </c> . </para>
				/// </returns>
				/// <java-name>
				/// codePointBefore
				/// </java-name>
				[Dot42.DexImport("codePointBefore", "([CII)I", AccessFlags = 9)]
				public static int CodePointBefore(char[] seq, int index, int start) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Converts the specified Unicode code point into a UTF-16 encoded sequence and copies the value(s) into the char array <c> dst </c> , starting at index <c> dstIndex </c> .</para><para><para>1.5 </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of <c> char </c> value units copied into <c> dst </c> . </para>
				/// </returns>
				/// <java-name>
				/// toChars
				/// </java-name>
				[Dot42.DexImport("toChars", "(I[CI)I", AccessFlags = 9)]
				public static int ToChars(int codePoint, char[] dst, int dstIndex) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Converts the specified Unicode code point into a UTF-16 encoded sequence and returns it as a char array.</para><para><para>1.5 </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the UTF-16 encoded char sequence. If <c> codePoint </c> is a supplementary code point, then the returned array contains two characters, otherwise it contains just one character. </para>
				/// </returns>
				/// <java-name>
				/// toChars
				/// </java-name>
				[Dot42.DexImport("toChars", "(I)[C", AccessFlags = 9)]
				public static char[] ToChars(int codePoint) /* MethodBuilder.Create */ 
				{
						return default(char[]);
				}

				/// <summary>
				/// <para>Counts the number of Unicode code points in the subsequence of the specified character sequence, as delineated by <c> beginIndex </c> and <c> endIndex </c> . Any surrogate values with missing pair values will be counted as one code point.</para><para><para>1.5 </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of Unicode code points. </para>
				/// </returns>
				/// <java-name>
				/// codePointCount
				/// </java-name>
				[Dot42.DexImport("codePointCount", "(Ljava/lang/CharSequence;II)I", AccessFlags = 9)]
				public static int CodePointCount(global::Java.Lang.ICharSequence seq, int beginIndex, int endIndex) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Counts the number of Unicode code points in the subsequence of the specified character sequence, as delineated by <c> beginIndex </c> and <c> endIndex </c> . Any surrogate values with missing pair values will be counted as one code point.</para><para><para>1.5 </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of Unicode code points. </para>
				/// </returns>
				/// <java-name>
				/// codePointCount
				/// </java-name>
				[Dot42.DexImport("codePointCount", "([CII)I", AccessFlags = 9)]
				public static int CodePointCount(char[] seq, int beginIndex, int endIndex) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Determines the index in the specified character sequence that is offset <c> codePointOffset </c> code points from <c> index </c> .</para><para><para>1.5 </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the index in <c> seq </c> that is <c> codePointOffset </c> code points away from <c> index </c> . </para>
				/// </returns>
				/// <java-name>
				/// offsetByCodePoints
				/// </java-name>
				[Dot42.DexImport("offsetByCodePoints", "(Ljava/lang/CharSequence;II)I", AccessFlags = 9)]
				public static int OffsetByCodePoints(global::Java.Lang.ICharSequence seq, int index, int codePointOffset) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Determines the index in a subsequence of the specified character array that is offset <c> codePointOffset </c> code points from <c> index </c> . The subsequence is delineated by <c> start </c> and <c> count </c> .</para><para><para>1.5 </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the index in <c> seq </c> that is <c> codePointOffset </c> code points away from <c> index </c> . </para>
				/// </returns>
				/// <java-name>
				/// offsetByCodePoints
				/// </java-name>
				[Dot42.DexImport("offsetByCodePoints", "([CIIII)I", AccessFlags = 9)]
				public static int OffsetByCodePoints(char[] seq, int start, int count, int index, int codePointOffset) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Convenience method to determine the value of the specified character <c> c </c> in the supplied radix. The value of <c> radix </c> must be between MIN_RADIX and MAX_RADIX.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the value of <c> c </c> in <c> radix </c> if <c> radix </c> lies between MIN_RADIX and MAX_RADIX; -1 otherwise. </para>
				/// </returns>
				/// <java-name>
				/// digit
				/// </java-name>
				[Dot42.DexImport("digit", "(CI)I", AccessFlags = 9)]
				public static int Digit(char c, int radix) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Convenience method to determine the value of the specified character <c> c </c> in the supplied radix. The value of <c> radix </c> must be between MIN_RADIX and MAX_RADIX.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the value of <c> c </c> in <c> radix </c> if <c> radix </c> lies between MIN_RADIX and MAX_RADIX; -1 otherwise. </para>
				/// </returns>
				/// <java-name>
				/// digit
				/// </java-name>
				[Dot42.DexImport("digit", "(II)I", AccessFlags = 9)]
				public static int Digit(int c, int radix) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Compares this object with the specified object and indicates if they are equal. In order to be equal, <c> object </c> must be an instance of <c> Character </c> and have the same char value as this object.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the specified object is equal to this <c> Character </c> ; <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns the character which represents the specified digit in the specified radix. The <c> radix </c> must be between <c> MIN_RADIX </c> and <c> MAX_RADIX </c> inclusive; <c> digit </c> must not be negative and smaller than <c> radix </c> . If any of these conditions does not hold, 0 is returned.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the character which represents the <c> digit </c> in the <c> radix </c> . </para>
				/// </returns>
				/// <java-name>
				/// forDigit
				/// </java-name>
				[Dot42.DexImport("forDigit", "(II)C", AccessFlags = 9)]
				public static char ForDigit(int digit, int radix) /* MethodBuilder.Create */ 
				{
						return default(char);
				}

				/// <summary>
				/// <para>Returns the numeric value of the specified Unicode character. See getNumericValue(int).</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a non-negative numeric integer value if a numeric value for <c> c </c> exists, -1 if there is no numeric value for <c> c </c> , -2 if the numeric value can not be represented as an integer. </para>
				/// </returns>
				/// <java-name>
				/// getNumericValue
				/// </java-name>
				[Dot42.DexImport("getNumericValue", "(C)I", AccessFlags = 9)]
				public static int GetNumericValue(char c) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the numeric value of the specified Unicode character. See getNumericValue(int).</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a non-negative numeric integer value if a numeric value for <c> c </c> exists, -1 if there is no numeric value for <c> c </c> , -2 if the numeric value can not be represented as an integer. </para>
				/// </returns>
				/// <java-name>
				/// getNumericValue
				/// </java-name>
				[Dot42.DexImport("getNumericValue", "(I)I", AccessFlags = 9)]
				public static int GetNumericValue(int c) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Gets the general Unicode category of the specified character.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the Unicode category of <c> c </c> . </para>
				/// </returns>
				/// <java-name>
				/// getType
				/// </java-name>
				[Dot42.DexImport("getType", "(C)I", AccessFlags = 9)]
				public static int GetType(char c) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Gets the general Unicode category of the specified character.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the Unicode category of <c> c </c> . </para>
				/// </returns>
				/// <java-name>
				/// getType
				/// </java-name>
				[Dot42.DexImport("getType", "(I)I", AccessFlags = 9)]
				public static int GetType(int c) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Gets the Unicode directionality of the specified character.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the Unicode directionality of <c> c </c> . </para>
				/// </returns>
				/// <java-name>
				/// getDirectionality
				/// </java-name>
				[Dot42.DexImport("getDirectionality", "(C)B", AccessFlags = 9)]
				public static sbyte JavaGetDirectionality(char c) /* MethodBuilder.Create */ 
				{
						return default(sbyte);
				}

				/// <summary>
				/// <para>Gets the Unicode directionality of the specified character.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the Unicode directionality of <c> c </c> . </para>
				/// </returns>
				/// <java-name>
				/// getDirectionality
				/// </java-name>
				[Dot42.DexImport("getDirectionality", "(C)B", AccessFlags = 9, IgnoreFromJava = true)]
				public static byte GetDirectionality(char c) /* MethodBuilder.Create */ 
				{
						return default(byte);
				}

				/// <summary>
				/// <para>Gets the Unicode directionality of the specified character.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the Unicode directionality of <c> c </c> . </para>
				/// </returns>
				/// <java-name>
				/// getDirectionality
				/// </java-name>
				[Dot42.DexImport("getDirectionality", "(I)B", AccessFlags = 9)]
				public static sbyte JavaGetDirectionality(int c) /* MethodBuilder.Create */ 
				{
						return default(sbyte);
				}

				/// <summary>
				/// <para>Gets the Unicode directionality of the specified character.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the Unicode directionality of <c> c </c> . </para>
				/// </returns>
				/// <java-name>
				/// getDirectionality
				/// </java-name>
				[Dot42.DexImport("getDirectionality", "(I)B", AccessFlags = 9, IgnoreFromJava = true)]
				public static byte GetDirectionality(int c) /* MethodBuilder.Create */ 
				{
						return default(byte);
				}

				/// <summary>
				/// <para>Indicates whether the specified character is mirrored.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if <c> c </c> is mirrored; <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isMirrored
				/// </java-name>
				[Dot42.DexImport("isMirrored", "(C)Z", AccessFlags = 9)]
				public static bool IsMirrored(char c) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Indicates whether the specified character is mirrored.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if <c> c </c> is mirrored; <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isMirrored
				/// </java-name>
				[Dot42.DexImport("isMirrored", "(I)Z", AccessFlags = 9)]
				public static bool IsMirrored(int c) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 1)]
				public override int GetHashCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Indicates whether the specified character is defined in the Unicode specification.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the general Unicode category of the character is not <c> UNASSIGNED </c> ; <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isDefined
				/// </java-name>
				[Dot42.DexImport("isDefined", "(C)Z", AccessFlags = 9)]
				public static bool IsDefined(char c) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Indicates whether the specified character is defined in the Unicode specification.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the general Unicode category of the character is not <c> UNASSIGNED </c> ; <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isDefined
				/// </java-name>
				[Dot42.DexImport("isDefined", "(I)Z", AccessFlags = 9)]
				public static bool IsDefined(int c) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Indicates whether the specified character is a digit.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if <c> c </c> is a digit; <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isDigit
				/// </java-name>
				[Dot42.DexImport("isDigit", "(C)Z", AccessFlags = 9)]
				public static bool IsDigit(char c) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Indicates whether the specified character is a digit.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if <c> c </c> is a digit; <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isDigit
				/// </java-name>
				[Dot42.DexImport("isDigit", "(I)Z", AccessFlags = 9)]
				public static bool IsDigit(int c) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Indicates whether the specified character is ignorable in a Java or Unicode identifier.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if <c> c </c> is ignorable; <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isIdentifierIgnorable
				/// </java-name>
				[Dot42.DexImport("isIdentifierIgnorable", "(C)Z", AccessFlags = 9)]
				public static bool IsIdentifierIgnorable(char c) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Indicates whether the specified character is ignorable in a Java or Unicode identifier.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if <c> c </c> is ignorable; <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isIdentifierIgnorable
				/// </java-name>
				[Dot42.DexImport("isIdentifierIgnorable", "(I)Z", AccessFlags = 9)]
				public static bool IsIdentifierIgnorable(int c) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Indicates whether the specified character is an ISO control character.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if <c> c </c> is an ISO control character; <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isISOControl
				/// </java-name>
				[Dot42.DexImport("isISOControl", "(C)Z", AccessFlags = 9)]
				public static bool IsISOControl(char c) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Indicates whether the specified character is an ISO control character.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if <c> c </c> is an ISO control character; <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isISOControl
				/// </java-name>
				[Dot42.DexImport("isISOControl", "(I)Z", AccessFlags = 9)]
				public static bool IsISOControl(int c) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Indicates whether the specified character is a valid part of a Java identifier other than the first character.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if <c> c </c> is valid as part of a Java identifier; <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isJavaIdentifierPart
				/// </java-name>
				[Dot42.DexImport("isJavaIdentifierPart", "(C)Z", AccessFlags = 9)]
				public static bool IsJavaIdentifierPart(char c) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Indicates whether the specified character is a valid part of a Java identifier other than the first character.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if <c> c </c> is valid as part of a Java identifier; <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isJavaIdentifierPart
				/// </java-name>
				[Dot42.DexImport("isJavaIdentifierPart", "(I)Z", AccessFlags = 9)]
				public static bool IsJavaIdentifierPart(int c) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Indicates whether the specified character is a valid first character for a Java identifier.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if <c> c </c> is a valid first character of a Java identifier; <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isJavaIdentifierStart
				/// </java-name>
				[Dot42.DexImport("isJavaIdentifierStart", "(C)Z", AccessFlags = 9)]
				public static bool IsJavaIdentifierStart(char c) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Indicates whether the specified character is a valid first character for a Java identifier.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if <c> c </c> is a valid first character of a Java identifier; <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isJavaIdentifierStart
				/// </java-name>
				[Dot42.DexImport("isJavaIdentifierStart", "(I)Z", AccessFlags = 9)]
				public static bool IsJavaIdentifierStart(int c) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Indicates whether the specified character is a Java letter.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>Use isJavaIdentifierStart(char) </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if <c> c </c> is a Java letter; <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isJavaLetter
				/// </java-name>
				[Dot42.DexImport("isJavaLetter", "(C)Z", AccessFlags = 9)]
				public static bool IsJavaLetter(char c) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Indicates whether the specified character is a Java letter or digit character.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>Use isJavaIdentifierPart(char) </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if <c> c </c> is a Java letter or digit; <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isJavaLetterOrDigit
				/// </java-name>
				[Dot42.DexImport("isJavaLetterOrDigit", "(C)Z", AccessFlags = 9)]
				public static bool IsJavaLetterOrDigit(char c) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Indicates whether the specified character is a letter.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if <c> c </c> is a letter; <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isLetter
				/// </java-name>
				[Dot42.DexImport("isLetter", "(C)Z", AccessFlags = 9)]
				public static bool IsLetter(char c) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Indicates whether the specified character is a letter.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if <c> c </c> is a letter; <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isLetter
				/// </java-name>
				[Dot42.DexImport("isLetter", "(I)Z", AccessFlags = 9)]
				public static bool IsLetter(int c) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Indicates whether the specified character is a letter or a digit.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if <c> c </c> is a letter or a digit; <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isLetterOrDigit
				/// </java-name>
				[Dot42.DexImport("isLetterOrDigit", "(C)Z", AccessFlags = 9)]
				public static bool IsLetterOrDigit(char c) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Indicates whether the specified character is a letter or a digit.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if <c> c </c> is a letter or a digit; <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isLetterOrDigit
				/// </java-name>
				[Dot42.DexImport("isLetterOrDigit", "(I)Z", AccessFlags = 9)]
				public static bool IsLetterOrDigit(int c) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Indicates whether the specified character is a lower case letter.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if <c> c </c> is a lower case letter; <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isLowerCase
				/// </java-name>
				[Dot42.DexImport("isLowerCase", "(C)Z", AccessFlags = 9)]
				public static bool IsLower(char c) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Indicates whether the specified character is a lower case letter.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if <c> c </c> is a lower case letter; <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isLowerCase
				/// </java-name>
				[Dot42.DexImport("isLowerCase", "(I)Z", AccessFlags = 9)]
				public static bool IsLower(int c) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Indicates whether the specified character is a Java space.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>Use isWhitespace(char) </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if <c> c </c> is a Java space; <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isSpace
				/// </java-name>
				[Dot42.DexImport("isSpace", "(C)Z", AccessFlags = 9)]
				public static bool IsSpace(char c) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Indicates whether the specified character is a Unicode space character. That is, if it is a member of one of the Unicode categories Space Separator, Line Separator, or Paragraph Separator.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if <c> c </c> is a Unicode space character, <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isSpaceChar
				/// </java-name>
				[Dot42.DexImport("isSpaceChar", "(C)Z", AccessFlags = 9)]
				public static bool IsSpaceChar(char c) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Indicates whether the specified character is a Unicode space character. That is, if it is a member of one of the Unicode categories Space Separator, Line Separator, or Paragraph Separator.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if <c> c </c> is a Unicode space character, <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isSpaceChar
				/// </java-name>
				[Dot42.DexImport("isSpaceChar", "(I)Z", AccessFlags = 9)]
				public static bool IsSpaceChar(int c) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Indicates whether the specified character is a titlecase character.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if <c> c </c> is a titlecase character, <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isTitleCase
				/// </java-name>
				[Dot42.DexImport("isTitleCase", "(C)Z", AccessFlags = 9)]
				public static bool IsTitleCase(char c) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Indicates whether the specified character is a titlecase character.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if <c> c </c> is a titlecase character, <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isTitleCase
				/// </java-name>
				[Dot42.DexImport("isTitleCase", "(I)Z", AccessFlags = 9)]
				public static bool IsTitleCase(int c) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Indicates whether the specified character is valid as part of a Unicode identifier other than the first character.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if <c> c </c> is valid as part of a Unicode identifier; <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isUnicodeIdentifierPart
				/// </java-name>
				[Dot42.DexImport("isUnicodeIdentifierPart", "(C)Z", AccessFlags = 9)]
				public static bool IsUnicodeIdentifierPart(char c) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Indicates whether the specified character is valid as part of a Unicode identifier other than the first character.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if <c> c </c> is valid as part of a Unicode identifier; <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isUnicodeIdentifierPart
				/// </java-name>
				[Dot42.DexImport("isUnicodeIdentifierPart", "(I)Z", AccessFlags = 9)]
				public static bool IsUnicodeIdentifierPart(int c) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Indicates whether the specified character is a valid initial character for a Unicode identifier.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if <c> c </c> is a valid first character for a Unicode identifier; <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isUnicodeIdentifierStart
				/// </java-name>
				[Dot42.DexImport("isUnicodeIdentifierStart", "(C)Z", AccessFlags = 9)]
				public static bool IsUnicodeIdentifierStart(char c) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Indicates whether the specified character is a valid initial character for a Unicode identifier.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if <c> c </c> is a valid first character for a Unicode identifier; <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isUnicodeIdentifierStart
				/// </java-name>
				[Dot42.DexImport("isUnicodeIdentifierStart", "(I)Z", AccessFlags = 9)]
				public static bool IsUnicodeIdentifierStart(int c) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Indicates whether the specified character is an upper case letter.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if <c> c </c> is a upper case letter; <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isUpperCase
				/// </java-name>
				[Dot42.DexImport("isUpperCase", "(C)Z", AccessFlags = 9)]
				public static bool IsUpper(char c) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Indicates whether the specified character is an upper case letter.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if <c> c </c> is a upper case letter; <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isUpperCase
				/// </java-name>
				[Dot42.DexImport("isUpperCase", "(I)Z", AccessFlags = 9)]
				public static bool IsUpper(int c) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Indicates whether the specified character is a whitespace character in Java.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the supplied <c> c </c> is a whitespace character in Java; <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isWhitespace
				/// </java-name>
				[Dot42.DexImport("isWhitespace", "(C)Z", AccessFlags = 9)]
				public static bool IsWhitespace(char c) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Indicates whether the specified character is a whitespace character in Java.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the supplied <c> c </c> is a whitespace character in Java; <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isWhitespace
				/// </java-name>
				[Dot42.DexImport("isWhitespace", "(I)Z", AccessFlags = 9)]
				public static bool IsWhitespace(int c) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Reverses the order of the first and second byte in the specified character.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the character with reordered bytes. </para>
				/// </returns>
				/// <java-name>
				/// reverseBytes
				/// </java-name>
				[Dot42.DexImport("reverseBytes", "(C)C", AccessFlags = 9)]
				public static char ReverseBytes(char c) /* MethodBuilder.Create */ 
				{
						return default(char);
				}

				/// <summary>
				/// <para>Returns the lower case equivalent for the specified character if the character is an upper case letter. Otherwise, the specified character is returned unchanged.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>if <c> c </c> is an upper case character then its lower case counterpart, otherwise just <c> c </c> . </para>
				/// </returns>
				/// <java-name>
				/// toLowerCase
				/// </java-name>
				[Dot42.DexImport("toLowerCase", "(C)C", AccessFlags = 9)]
				public static char ToLowerCase(char c) /* MethodBuilder.Create */ 
				{
						return default(char);
				}

				/// <summary>
				/// <para>Returns the lower case equivalent for the specified character if the character is an upper case letter. Otherwise, the specified character is returned unchanged.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>if <c> c </c> is an upper case character then its lower case counterpart, otherwise just <c> c </c> . </para>
				/// </returns>
				/// <java-name>
				/// toLowerCase
				/// </java-name>
				[Dot42.DexImport("toLowerCase", "(I)I", AccessFlags = 9)]
				public static int ToLowerCase(int c) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Converts the specified character to its string representation.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the character converted to a string. </para>
				/// </returns>
				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "(C)Ljava/lang/String;", AccessFlags = 9)]
				public static string ToString(char value) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the title case equivalent for the specified character if it exists. Otherwise, the specified character is returned unchanged.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the title case equivalent of <c> c </c> if it exists, otherwise <c> c </c> . </para>
				/// </returns>
				/// <java-name>
				/// toTitleCase
				/// </java-name>
				[Dot42.DexImport("toTitleCase", "(C)C", AccessFlags = 9)]
				public static char ToTitleCase(char c) /* MethodBuilder.Create */ 
				{
						return default(char);
				}

				/// <summary>
				/// <para>Returns the title case equivalent for the specified character if it exists. Otherwise, the specified character is returned unchanged.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the title case equivalent of <c> c </c> if it exists, otherwise <c> c </c> . </para>
				/// </returns>
				/// <java-name>
				/// toTitleCase
				/// </java-name>
				[Dot42.DexImport("toTitleCase", "(I)I", AccessFlags = 9)]
				public static int ToTitleCase(int c) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the upper case equivalent for the specified character if the character is a lower case letter. Otherwise, the specified character is returned unchanged.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>if <c> c </c> is a lower case character then its upper case counterpart, otherwise just <c> c </c> . </para>
				/// </returns>
				/// <java-name>
				/// toUpperCase
				/// </java-name>
				[Dot42.DexImport("toUpperCase", "(C)C", AccessFlags = 9)]
				public static char ToUpperCase(char c) /* MethodBuilder.Create */ 
				{
						return default(char);
				}

				/// <summary>
				/// <para>Returns the upper case equivalent for the specified character if the character is a lower case letter. Otherwise, the specified character is returned unchanged.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>if <c> c </c> is a lower case character then its upper case counterpart, otherwise just <c> c </c> . </para>
				/// </returns>
				/// <java-name>
				/// toUpperCase
				/// </java-name>
				[Dot42.DexImport("toUpperCase", "(I)I", AccessFlags = 9)]
				public static int ToUpperCase(int c) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Represents a block of Unicode characters, as defined by the Unicode 4.0.1 specification.</para><para><para>1.2 </para></para>    
				/// </summary>
				/// <java-name>
				/// java/lang/Character$UnicodeBlock
				/// </java-name>
				[Dot42.DexImport("java/lang/Character$UnicodeBlock", AccessFlags = 25)]
				public sealed partial class UnicodeBlock : global::System.Char.Subset
 /* scope: __dot42__ */ 
				{
						/// <summary>
						/// <para>The "Surrogates Area" Unicode Block.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>As of Java 5, this block has been replaced by HIGH_SURROGATES, HIGH_PRIVATE_USE_SURROGATES and LOW_SURROGATES. </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// SURROGATES_AREA
						/// </java-name>
						[Dot42.DexImport("SURROGATES_AREA", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock SURROGATES_AREA;
						/// <summary>
						/// <para>The "Basic Latin" Unicode Block.</para><para><para>1.2 </para></para>        
						/// </summary>
						/// <java-name>
						/// BASIC_LATIN
						/// </java-name>
						[Dot42.DexImport("BASIC_LATIN", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock BASIC_LATIN;
						/// <summary>
						/// <para>The "Latin-1 Supplement" Unicode Block.</para><para><para>1.2 </para></para>        
						/// </summary>
						/// <java-name>
						/// LATIN_1_SUPPLEMENT
						/// </java-name>
						[Dot42.DexImport("LATIN_1_SUPPLEMENT", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock LATIN_1_SUPPLEMENT;
						/// <summary>
						/// <para>The "Latin Extended-A" Unicode Block.</para><para><para>1.2 </para></para>        
						/// </summary>
						/// <java-name>
						/// LATIN_EXTENDED_A
						/// </java-name>
						[Dot42.DexImport("LATIN_EXTENDED_A", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock LATIN_EXTENDED_A;
						/// <summary>
						/// <para>The "Latin Extended-B" Unicode Block.</para><para><para>1.2 </para></para>        
						/// </summary>
						/// <java-name>
						/// LATIN_EXTENDED_B
						/// </java-name>
						[Dot42.DexImport("LATIN_EXTENDED_B", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock LATIN_EXTENDED_B;
						/// <summary>
						/// <para>The "IPA Extensions" Unicode Block.</para><para><para>1.2 </para></para>        
						/// </summary>
						/// <java-name>
						/// IPA_EXTENSIONS
						/// </java-name>
						[Dot42.DexImport("IPA_EXTENSIONS", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock IPA_EXTENSIONS;
						/// <summary>
						/// <para>The "Spacing Modifier Letters" Unicode Block.</para><para><para>1.2 </para></para>        
						/// </summary>
						/// <java-name>
						/// SPACING_MODIFIER_LETTERS
						/// </java-name>
						[Dot42.DexImport("SPACING_MODIFIER_LETTERS", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock SPACING_MODIFIER_LETTERS;
						/// <summary>
						/// <para>The "Combining Diacritical Marks" Unicode Block.</para><para><para>1.2 </para></para>        
						/// </summary>
						/// <java-name>
						/// COMBINING_DIACRITICAL_MARKS
						/// </java-name>
						[Dot42.DexImport("COMBINING_DIACRITICAL_MARKS", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock COMBINING_DIACRITICAL_MARKS;
						/// <summary>
						/// <para>The "Greek and Coptic" Unicode Block. Previously referred to as "Greek".</para><para><para>1.2 </para></para>        
						/// </summary>
						/// <java-name>
						/// GREEK
						/// </java-name>
						[Dot42.DexImport("GREEK", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock GREEK;
						/// <summary>
						/// <para>The "Cyrillic" Unicode Block.</para><para><para>1.2 </para></para>        
						/// </summary>
						/// <java-name>
						/// CYRILLIC
						/// </java-name>
						[Dot42.DexImport("CYRILLIC", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock CYRILLIC;
						/// <summary>
						/// <para>The "Cyrillic Supplement" Unicode Block. Previously referred to as "Cyrillic Supplementary".</para><para><para>1.5 </para></para>        
						/// </summary>
						/// <java-name>
						/// CYRILLIC_SUPPLEMENTARY
						/// </java-name>
						[Dot42.DexImport("CYRILLIC_SUPPLEMENTARY", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock CYRILLIC_SUPPLEMENTARY;
						/// <summary>
						/// <para>The "Armenian" Unicode Block.</para><para><para>1.2 </para></para>        
						/// </summary>
						/// <java-name>
						/// ARMENIAN
						/// </java-name>
						[Dot42.DexImport("ARMENIAN", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock ARMENIAN;
						/// <summary>
						/// <para>The "Hebrew" Unicode Block.</para><para><para>1.2 </para></para>        
						/// </summary>
						/// <java-name>
						/// HEBREW
						/// </java-name>
						[Dot42.DexImport("HEBREW", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock HEBREW;
						/// <summary>
						/// <para>The "Arabic" Unicode Block.</para><para><para>1.2 </para></para>        
						/// </summary>
						/// <java-name>
						/// ARABIC
						/// </java-name>
						[Dot42.DexImport("ARABIC", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock ARABIC;
						/// <summary>
						/// <para>The "Syriac" Unicode Block.</para><para><para>1.4 </para></para>        
						/// </summary>
						/// <java-name>
						/// SYRIAC
						/// </java-name>
						[Dot42.DexImport("SYRIAC", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock SYRIAC;
						/// <summary>
						/// <para>The "Thaana" Unicode Block.</para><para><para>1.4 </para></para>        
						/// </summary>
						/// <java-name>
						/// THAANA
						/// </java-name>
						[Dot42.DexImport("THAANA", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock THAANA;
						/// <summary>
						/// <para>The "Devanagari" Unicode Block.</para><para><para>1.2 </para></para>        
						/// </summary>
						/// <java-name>
						/// DEVANAGARI
						/// </java-name>
						[Dot42.DexImport("DEVANAGARI", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock DEVANAGARI;
						/// <summary>
						/// <para>The "Bengali" Unicode Block.</para><para><para>1.2 </para></para>        
						/// </summary>
						/// <java-name>
						/// BENGALI
						/// </java-name>
						[Dot42.DexImport("BENGALI", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock BENGALI;
						/// <summary>
						/// <para>The "Gurmukhi" Unicode Block.</para><para><para>1.2 </para></para>        
						/// </summary>
						/// <java-name>
						/// GURMUKHI
						/// </java-name>
						[Dot42.DexImport("GURMUKHI", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock GURMUKHI;
						/// <summary>
						/// <para>The "Gujarati" Unicode Block.</para><para><para>1.2 </para></para>        
						/// </summary>
						/// <java-name>
						/// GUJARATI
						/// </java-name>
						[Dot42.DexImport("GUJARATI", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock GUJARATI;
						/// <summary>
						/// <para>The "Oriya" Unicode Block.</para><para><para>1.2 </para></para>        
						/// </summary>
						/// <java-name>
						/// ORIYA
						/// </java-name>
						[Dot42.DexImport("ORIYA", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock ORIYA;
						/// <summary>
						/// <para>The "Tamil" Unicode Block.</para><para><para>1.2 </para></para>        
						/// </summary>
						/// <java-name>
						/// TAMIL
						/// </java-name>
						[Dot42.DexImport("TAMIL", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock TAMIL;
						/// <summary>
						/// <para>The "Telugu" Unicode Block.</para><para><para>1.2 </para></para>        
						/// </summary>
						/// <java-name>
						/// TELUGU
						/// </java-name>
						[Dot42.DexImport("TELUGU", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock TELUGU;
						/// <summary>
						/// <para>The "Kannada" Unicode Block.</para><para><para>1.2 </para></para>        
						/// </summary>
						/// <java-name>
						/// KANNADA
						/// </java-name>
						[Dot42.DexImport("KANNADA", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock KANNADA;
						/// <summary>
						/// <para>The "Malayalam" Unicode Block.</para><para><para>1.2 </para></para>        
						/// </summary>
						/// <java-name>
						/// MALAYALAM
						/// </java-name>
						[Dot42.DexImport("MALAYALAM", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock MALAYALAM;
						/// <summary>
						/// <para>The "Sinhala" Unicode Block.</para><para><para>1.4 </para></para>        
						/// </summary>
						/// <java-name>
						/// SINHALA
						/// </java-name>
						[Dot42.DexImport("SINHALA", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock SINHALA;
						/// <summary>
						/// <para>The "Thai" Unicode Block.</para><para><para>1.2 </para></para>        
						/// </summary>
						/// <java-name>
						/// THAI
						/// </java-name>
						[Dot42.DexImport("THAI", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock THAI;
						/// <summary>
						/// <para>The "Lao" Unicode Block.</para><para><para>1.2 </para></para>        
						/// </summary>
						/// <java-name>
						/// LAO
						/// </java-name>
						[Dot42.DexImport("LAO", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock LAO;
						/// <summary>
						/// <para>The "Tibetan" Unicode Block.</para><para><para>1.2 </para></para>        
						/// </summary>
						/// <java-name>
						/// TIBETAN
						/// </java-name>
						[Dot42.DexImport("TIBETAN", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock TIBETAN;
						/// <summary>
						/// <para>The "Myanmar" Unicode Block.</para><para><para>1.4 </para></para>        
						/// </summary>
						/// <java-name>
						/// MYANMAR
						/// </java-name>
						[Dot42.DexImport("MYANMAR", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock MYANMAR;
						/// <summary>
						/// <para>The "Georgian" Unicode Block.</para><para><para>1.2 </para></para>        
						/// </summary>
						/// <java-name>
						/// GEORGIAN
						/// </java-name>
						[Dot42.DexImport("GEORGIAN", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock GEORGIAN;
						/// <summary>
						/// <para>The "Hangul Jamo" Unicode Block.</para><para><para>1.2 </para></para>        
						/// </summary>
						/// <java-name>
						/// HANGUL_JAMO
						/// </java-name>
						[Dot42.DexImport("HANGUL_JAMO", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock HANGUL_JAMO;
						/// <summary>
						/// <para>The "Ethiopic" Unicode Block.</para><para><para>1.4 </para></para>        
						/// </summary>
						/// <java-name>
						/// ETHIOPIC
						/// </java-name>
						[Dot42.DexImport("ETHIOPIC", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock ETHIOPIC;
						/// <summary>
						/// <para>The "Cherokee" Unicode Block.</para><para><para>1.4 </para></para>        
						/// </summary>
						/// <java-name>
						/// CHEROKEE
						/// </java-name>
						[Dot42.DexImport("CHEROKEE", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock CHEROKEE;
						/// <summary>
						/// <para>The "Unified Canadian Aboriginal Syllabics" Unicode Block.</para><para><para>1.4 </para></para>        
						/// </summary>
						/// <java-name>
						/// UNIFIED_CANADIAN_ABORIGINAL_SYLLABICS
						/// </java-name>
						[Dot42.DexImport("UNIFIED_CANADIAN_ABORIGINAL_SYLLABICS", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock UNIFIED_CANADIAN_ABORIGINAL_SYLLABICS;
						/// <summary>
						/// <para>The "Ogham" Unicode Block.</para><para><para>1.4 </para></para>        
						/// </summary>
						/// <java-name>
						/// OGHAM
						/// </java-name>
						[Dot42.DexImport("OGHAM", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock OGHAM;
						/// <summary>
						/// <para>The "Runic" Unicode Block.</para><para><para>1.4 </para></para>        
						/// </summary>
						/// <java-name>
						/// RUNIC
						/// </java-name>
						[Dot42.DexImport("RUNIC", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock RUNIC;
						/// <summary>
						/// <para>The "Tagalog" Unicode Block.</para><para><para>1.5 </para></para>        
						/// </summary>
						/// <java-name>
						/// TAGALOG
						/// </java-name>
						[Dot42.DexImport("TAGALOG", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock TAGALOG;
						/// <summary>
						/// <para>The "Hanunoo" Unicode Block.</para><para><para>1.5 </para></para>        
						/// </summary>
						/// <java-name>
						/// HANUNOO
						/// </java-name>
						[Dot42.DexImport("HANUNOO", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock HANUNOO;
						/// <summary>
						/// <para>The "Buhid" Unicode Block.</para><para><para>1.5 </para></para>        
						/// </summary>
						/// <java-name>
						/// BUHID
						/// </java-name>
						[Dot42.DexImport("BUHID", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock BUHID;
						/// <summary>
						/// <para>The "Tagbanwa" Unicode Block.</para><para><para>1.5 </para></para>        
						/// </summary>
						/// <java-name>
						/// TAGBANWA
						/// </java-name>
						[Dot42.DexImport("TAGBANWA", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock TAGBANWA;
						/// <summary>
						/// <para>The "Khmer" Unicode Block.</para><para><para>1.4 </para></para>        
						/// </summary>
						/// <java-name>
						/// KHMER
						/// </java-name>
						[Dot42.DexImport("KHMER", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock KHMER;
						/// <summary>
						/// <para>The "Mongolian" Unicode Block.</para><para><para>1.4 </para></para>        
						/// </summary>
						/// <java-name>
						/// MONGOLIAN
						/// </java-name>
						[Dot42.DexImport("MONGOLIAN", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock MONGOLIAN;
						/// <summary>
						/// <para>The "Limbu" Unicode Block.</para><para><para>1.5 </para></para>        
						/// </summary>
						/// <java-name>
						/// LIMBU
						/// </java-name>
						[Dot42.DexImport("LIMBU", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock LIMBU;
						/// <summary>
						/// <para>The "Tai Le" Unicode Block.</para><para><para>1.5 </para></para>        
						/// </summary>
						/// <java-name>
						/// TAI_LE
						/// </java-name>
						[Dot42.DexImport("TAI_LE", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock TAI_LE;
						/// <summary>
						/// <para>The "Khmer Symbols" Unicode Block.</para><para><para>1.5 </para></para>        
						/// </summary>
						/// <java-name>
						/// KHMER_SYMBOLS
						/// </java-name>
						[Dot42.DexImport("KHMER_SYMBOLS", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock KHMER_SYMBOLS;
						/// <summary>
						/// <para>The "Phonetic Extensions" Unicode Block.</para><para><para>1.5 </para></para>        
						/// </summary>
						/// <java-name>
						/// PHONETIC_EXTENSIONS
						/// </java-name>
						[Dot42.DexImport("PHONETIC_EXTENSIONS", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock PHONETIC_EXTENSIONS;
						/// <summary>
						/// <para>The "Latin Extended Additional" Unicode Block.</para><para><para>1.2 </para></para>        
						/// </summary>
						/// <java-name>
						/// LATIN_EXTENDED_ADDITIONAL
						/// </java-name>
						[Dot42.DexImport("LATIN_EXTENDED_ADDITIONAL", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock LATIN_EXTENDED_ADDITIONAL;
						/// <summary>
						/// <para>The "Greek Extended" Unicode Block.</para><para><para>1.2 </para></para>        
						/// </summary>
						/// <java-name>
						/// GREEK_EXTENDED
						/// </java-name>
						[Dot42.DexImport("GREEK_EXTENDED", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock GREEK_EXTENDED;
						/// <summary>
						/// <para>The "General Punctuation" Unicode Block.</para><para><para>1.2 </para></para>        
						/// </summary>
						/// <java-name>
						/// GENERAL_PUNCTUATION
						/// </java-name>
						[Dot42.DexImport("GENERAL_PUNCTUATION", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock GENERAL_PUNCTUATION;
						/// <summary>
						/// <para>The "Superscripts and Subscripts" Unicode Block.</para><para><para>1.2 </para></para>        
						/// </summary>
						/// <java-name>
						/// SUPERSCRIPTS_AND_SUBSCRIPTS
						/// </java-name>
						[Dot42.DexImport("SUPERSCRIPTS_AND_SUBSCRIPTS", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock SUPERSCRIPTS_AND_SUBSCRIPTS;
						/// <summary>
						/// <para>The "Currency Symbols" Unicode Block.</para><para><para>1.2 </para></para>        
						/// </summary>
						/// <java-name>
						/// CURRENCY_SYMBOLS
						/// </java-name>
						[Dot42.DexImport("CURRENCY_SYMBOLS", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock CURRENCY_SYMBOLS;
						/// <summary>
						/// <para>The "Combining Diacritical Marks for Symbols" Unicode Block. Previously referred to as "Combining Marks for Symbols".</para><para><para>1.2 </para></para>        
						/// </summary>
						/// <java-name>
						/// COMBINING_MARKS_FOR_SYMBOLS
						/// </java-name>
						[Dot42.DexImport("COMBINING_MARKS_FOR_SYMBOLS", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock COMBINING_MARKS_FOR_SYMBOLS;
						/// <summary>
						/// <para>The "Letterlike Symbols" Unicode Block.</para><para><para>1.2 </para></para>        
						/// </summary>
						/// <java-name>
						/// LETTERLIKE_SYMBOLS
						/// </java-name>
						[Dot42.DexImport("LETTERLIKE_SYMBOLS", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock LETTERLIKE_SYMBOLS;
						/// <summary>
						/// <para>The "Number Forms" Unicode Block.</para><para><para>1.2 </para></para>        
						/// </summary>
						/// <java-name>
						/// NUMBER_FORMS
						/// </java-name>
						[Dot42.DexImport("NUMBER_FORMS", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock NUMBER_FORMS;
						/// <summary>
						/// <para>The "Arrows" Unicode Block.</para><para><para>1.2 </para></para>        
						/// </summary>
						/// <java-name>
						/// ARROWS
						/// </java-name>
						[Dot42.DexImport("ARROWS", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock ARROWS;
						/// <summary>
						/// <para>The "Mathematical Operators" Unicode Block.</para><para><para>1.2 </para></para>        
						/// </summary>
						/// <java-name>
						/// MATHEMATICAL_OPERATORS
						/// </java-name>
						[Dot42.DexImport("MATHEMATICAL_OPERATORS", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock MATHEMATICAL_OPERATORS;
						/// <summary>
						/// <para>The "Miscellaneous Technical" Unicode Block.</para><para><para>1.2 </para></para>        
						/// </summary>
						/// <java-name>
						/// MISCELLANEOUS_TECHNICAL
						/// </java-name>
						[Dot42.DexImport("MISCELLANEOUS_TECHNICAL", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock MISCELLANEOUS_TECHNICAL;
						/// <summary>
						/// <para>The "Control Pictures" Unicode Block.</para><para><para>1.2 </para></para>        
						/// </summary>
						/// <java-name>
						/// CONTROL_PICTURES
						/// </java-name>
						[Dot42.DexImport("CONTROL_PICTURES", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock CONTROL_PICTURES;
						/// <summary>
						/// <para>The "Optical Character Recognition" Unicode Block.</para><para><para>1.2 </para></para>        
						/// </summary>
						/// <java-name>
						/// OPTICAL_CHARACTER_RECOGNITION
						/// </java-name>
						[Dot42.DexImport("OPTICAL_CHARACTER_RECOGNITION", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock OPTICAL_CHARACTER_RECOGNITION;
						/// <summary>
						/// <para>The "Enclosed Alphanumerics" Unicode Block.</para><para><para>1.2 </para></para>        
						/// </summary>
						/// <java-name>
						/// ENCLOSED_ALPHANUMERICS
						/// </java-name>
						[Dot42.DexImport("ENCLOSED_ALPHANUMERICS", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock ENCLOSED_ALPHANUMERICS;
						/// <summary>
						/// <para>The "Box Drawing" Unicode Block.</para><para><para>1.2 </para></para>        
						/// </summary>
						/// <java-name>
						/// BOX_DRAWING
						/// </java-name>
						[Dot42.DexImport("BOX_DRAWING", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock BOX_DRAWING;
						/// <summary>
						/// <para>The "Block Elements" Unicode Block.</para><para><para>1.2 </para></para>        
						/// </summary>
						/// <java-name>
						/// BLOCK_ELEMENTS
						/// </java-name>
						[Dot42.DexImport("BLOCK_ELEMENTS", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock BLOCK_ELEMENTS;
						/// <summary>
						/// <para>The "Geometric Shapes" Unicode Block.</para><para><para>1.2 </para></para>        
						/// </summary>
						/// <java-name>
						/// GEOMETRIC_SHAPES
						/// </java-name>
						[Dot42.DexImport("GEOMETRIC_SHAPES", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock GEOMETRIC_SHAPES;
						/// <summary>
						/// <para>The "Miscellaneous Symbols" Unicode Block.</para><para><para>1.2 </para></para>        
						/// </summary>
						/// <java-name>
						/// MISCELLANEOUS_SYMBOLS
						/// </java-name>
						[Dot42.DexImport("MISCELLANEOUS_SYMBOLS", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock MISCELLANEOUS_SYMBOLS;
						/// <summary>
						/// <para>The "Dingbats" Unicode Block.</para><para><para>1.2 </para></para>        
						/// </summary>
						/// <java-name>
						/// DINGBATS
						/// </java-name>
						[Dot42.DexImport("DINGBATS", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock DINGBATS;
						/// <summary>
						/// <para>The "Miscellaneous Mathematical Symbols-A" Unicode Block.</para><para><para>1.5 </para></para>        
						/// </summary>
						/// <java-name>
						/// MISCELLANEOUS_MATHEMATICAL_SYMBOLS_A
						/// </java-name>
						[Dot42.DexImport("MISCELLANEOUS_MATHEMATICAL_SYMBOLS_A", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock MISCELLANEOUS_MATHEMATICAL_SYMBOLS_A;
						/// <summary>
						/// <para>The "Supplemental Arrows-A" Unicode Block.</para><para><para>1.5 </para></para>        
						/// </summary>
						/// <java-name>
						/// SUPPLEMENTAL_ARROWS_A
						/// </java-name>
						[Dot42.DexImport("SUPPLEMENTAL_ARROWS_A", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock SUPPLEMENTAL_ARROWS_A;
						/// <summary>
						/// <para>The "Braille Patterns" Unicode Block.</para><para><para>1.4 </para></para>        
						/// </summary>
						/// <java-name>
						/// BRAILLE_PATTERNS
						/// </java-name>
						[Dot42.DexImport("BRAILLE_PATTERNS", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock BRAILLE_PATTERNS;
						/// <summary>
						/// <para>The "Supplemental Arrows-B" Unicode Block.</para><para><para>1.5 </para></para>        
						/// </summary>
						/// <java-name>
						/// SUPPLEMENTAL_ARROWS_B
						/// </java-name>
						[Dot42.DexImport("SUPPLEMENTAL_ARROWS_B", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock SUPPLEMENTAL_ARROWS_B;
						/// <summary>
						/// <para>The "Miscellaneous Mathematical Symbols-B" Unicode Block.</para><para><para>1.5 </para></para>        
						/// </summary>
						/// <java-name>
						/// MISCELLANEOUS_MATHEMATICAL_SYMBOLS_B
						/// </java-name>
						[Dot42.DexImport("MISCELLANEOUS_MATHEMATICAL_SYMBOLS_B", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock MISCELLANEOUS_MATHEMATICAL_SYMBOLS_B;
						/// <summary>
						/// <para>The "Supplemental Mathematical Operators" Unicode Block.</para><para><para>1.5 </para></para>        
						/// </summary>
						/// <java-name>
						/// SUPPLEMENTAL_MATHEMATICAL_OPERATORS
						/// </java-name>
						[Dot42.DexImport("SUPPLEMENTAL_MATHEMATICAL_OPERATORS", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock SUPPLEMENTAL_MATHEMATICAL_OPERATORS;
						/// <summary>
						/// <para>The "Miscellaneous Symbols and Arrows" Unicode Block.</para><para><para>1.2 </para></para>        
						/// </summary>
						/// <java-name>
						/// MISCELLANEOUS_SYMBOLS_AND_ARROWS
						/// </java-name>
						[Dot42.DexImport("MISCELLANEOUS_SYMBOLS_AND_ARROWS", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock MISCELLANEOUS_SYMBOLS_AND_ARROWS;
						/// <summary>
						/// <para>The "CJK Radicals Supplement" Unicode Block.</para><para><para>1.4 </para></para>        
						/// </summary>
						/// <java-name>
						/// CJK_RADICALS_SUPPLEMENT
						/// </java-name>
						[Dot42.DexImport("CJK_RADICALS_SUPPLEMENT", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock CJK_RADICALS_SUPPLEMENT;
						/// <summary>
						/// <para>The "Kangxi Radicals" Unicode Block.</para><para><para>1.4 </para></para>        
						/// </summary>
						/// <java-name>
						/// KANGXI_RADICALS
						/// </java-name>
						[Dot42.DexImport("KANGXI_RADICALS", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock KANGXI_RADICALS;
						/// <summary>
						/// <para>The "Ideographic Description Characters" Unicode Block.</para><para><para>1.4 </para></para>        
						/// </summary>
						/// <java-name>
						/// IDEOGRAPHIC_DESCRIPTION_CHARACTERS
						/// </java-name>
						[Dot42.DexImport("IDEOGRAPHIC_DESCRIPTION_CHARACTERS", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock IDEOGRAPHIC_DESCRIPTION_CHARACTERS;
						/// <summary>
						/// <para>The "CJK Symbols and Punctuation" Unicode Block.</para><para><para>1.2 </para></para>        
						/// </summary>
						/// <java-name>
						/// CJK_SYMBOLS_AND_PUNCTUATION
						/// </java-name>
						[Dot42.DexImport("CJK_SYMBOLS_AND_PUNCTUATION", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock CJK_SYMBOLS_AND_PUNCTUATION;
						/// <summary>
						/// <para>The "Hiragana" Unicode Block.</para><para><para>1.2 </para></para>        
						/// </summary>
						/// <java-name>
						/// HIRAGANA
						/// </java-name>
						[Dot42.DexImport("HIRAGANA", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock HIRAGANA;
						/// <summary>
						/// <para>The "Katakana" Unicode Block.</para><para><para>1.2 </para></para>        
						/// </summary>
						/// <java-name>
						/// KATAKANA
						/// </java-name>
						[Dot42.DexImport("KATAKANA", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock KATAKANA;
						/// <summary>
						/// <para>The "Bopomofo" Unicode Block.</para><para><para>1.2 </para></para>        
						/// </summary>
						/// <java-name>
						/// BOPOMOFO
						/// </java-name>
						[Dot42.DexImport("BOPOMOFO", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock BOPOMOFO;
						/// <summary>
						/// <para>The "Hangul Compatibility Jamo" Unicode Block.</para><para><para>1.2 </para></para>        
						/// </summary>
						/// <java-name>
						/// HANGUL_COMPATIBILITY_JAMO
						/// </java-name>
						[Dot42.DexImport("HANGUL_COMPATIBILITY_JAMO", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock HANGUL_COMPATIBILITY_JAMO;
						/// <summary>
						/// <para>The "Kanbun" Unicode Block.</para><para><para>1.2 </para></para>        
						/// </summary>
						/// <java-name>
						/// KANBUN
						/// </java-name>
						[Dot42.DexImport("KANBUN", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock KANBUN;
						/// <summary>
						/// <para>The "Bopomofo Extended" Unicode Block.</para><para><para>1.4 </para></para>        
						/// </summary>
						/// <java-name>
						/// BOPOMOFO_EXTENDED
						/// </java-name>
						[Dot42.DexImport("BOPOMOFO_EXTENDED", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock BOPOMOFO_EXTENDED;
						/// <summary>
						/// <para>The "Katakana Phonetic Extensions" Unicode Block.</para><para><para>1.5 </para></para>        
						/// </summary>
						/// <java-name>
						/// KATAKANA_PHONETIC_EXTENSIONS
						/// </java-name>
						[Dot42.DexImport("KATAKANA_PHONETIC_EXTENSIONS", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock KATAKANA_PHONETIC_EXTENSIONS;
						/// <summary>
						/// <para>The "Enclosed CJK Letters and Months" Unicode Block.</para><para><para>1.2 </para></para>        
						/// </summary>
						/// <java-name>
						/// ENCLOSED_CJK_LETTERS_AND_MONTHS
						/// </java-name>
						[Dot42.DexImport("ENCLOSED_CJK_LETTERS_AND_MONTHS", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock ENCLOSED_CJK_LETTERS_AND_MONTHS;
						/// <summary>
						/// <para>The "CJK Compatibility" Unicode Block.</para><para><para>1.2 </para></para>        
						/// </summary>
						/// <java-name>
						/// CJK_COMPATIBILITY
						/// </java-name>
						[Dot42.DexImport("CJK_COMPATIBILITY", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock CJK_COMPATIBILITY;
						/// <summary>
						/// <para>The "CJK Unified Ideographs Extension A" Unicode Block.</para><para><para>1.4 </para></para>        
						/// </summary>
						/// <java-name>
						/// CJK_UNIFIED_IDEOGRAPHS_EXTENSION_A
						/// </java-name>
						[Dot42.DexImport("CJK_UNIFIED_IDEOGRAPHS_EXTENSION_A", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock CJK_UNIFIED_IDEOGRAPHS_EXTENSION_A;
						/// <summary>
						/// <para>The "Yijing Hexagram Symbols" Unicode Block.</para><para><para>1.5 </para></para>        
						/// </summary>
						/// <java-name>
						/// YIJING_HEXAGRAM_SYMBOLS
						/// </java-name>
						[Dot42.DexImport("YIJING_HEXAGRAM_SYMBOLS", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock YIJING_HEXAGRAM_SYMBOLS;
						/// <summary>
						/// <para>The "CJK Unified Ideographs" Unicode Block.</para><para><para>1.2 </para></para>        
						/// </summary>
						/// <java-name>
						/// CJK_UNIFIED_IDEOGRAPHS
						/// </java-name>
						[Dot42.DexImport("CJK_UNIFIED_IDEOGRAPHS", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock CJK_UNIFIED_IDEOGRAPHS;
						/// <summary>
						/// <para>The "Yi Syllables" Unicode Block.</para><para><para>1.4 </para></para>        
						/// </summary>
						/// <java-name>
						/// YI_SYLLABLES
						/// </java-name>
						[Dot42.DexImport("YI_SYLLABLES", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock YI_SYLLABLES;
						/// <summary>
						/// <para>The "Yi Radicals" Unicode Block.</para><para><para>1.4 </para></para>        
						/// </summary>
						/// <java-name>
						/// YI_RADICALS
						/// </java-name>
						[Dot42.DexImport("YI_RADICALS", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock YI_RADICALS;
						/// <summary>
						/// <para>The "Hangul Syllables" Unicode Block.</para><para><para>1.2 </para></para>        
						/// </summary>
						/// <java-name>
						/// HANGUL_SYLLABLES
						/// </java-name>
						[Dot42.DexImport("HANGUL_SYLLABLES", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock HANGUL_SYLLABLES;
						/// <summary>
						/// <para>The "High Surrogates" Unicode Block. This block represents code point values in the high surrogate range 0xD800 to 0xDB7F </para>        
						/// </summary>
						/// <java-name>
						/// HIGH_SURROGATES
						/// </java-name>
						[Dot42.DexImport("HIGH_SURROGATES", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock HIGH_SURROGATES;
						/// <summary>
						/// <para>The "High Private Use Surrogates" Unicode Block. This block represents code point values in the high surrogate range 0xDB80 to 0xDBFF </para>        
						/// </summary>
						/// <java-name>
						/// HIGH_PRIVATE_USE_SURROGATES
						/// </java-name>
						[Dot42.DexImport("HIGH_PRIVATE_USE_SURROGATES", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock HIGH_PRIVATE_USE_SURROGATES;
						/// <summary>
						/// <para>The "Low Surrogates" Unicode Block. This block represents code point values in the low surrogate range 0xDC00 to 0xDFFF </para>        
						/// </summary>
						/// <java-name>
						/// LOW_SURROGATES
						/// </java-name>
						[Dot42.DexImport("LOW_SURROGATES", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock LOW_SURROGATES;
						/// <summary>
						/// <para>The "Private Use Area" Unicode Block.</para><para><para>1.2 </para></para>        
						/// </summary>
						/// <java-name>
						/// PRIVATE_USE_AREA
						/// </java-name>
						[Dot42.DexImport("PRIVATE_USE_AREA", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock PRIVATE_USE_AREA;
						/// <summary>
						/// <para>The "CJK Compatibility Ideographs" Unicode Block.</para><para><para>1.2 </para></para>        
						/// </summary>
						/// <java-name>
						/// CJK_COMPATIBILITY_IDEOGRAPHS
						/// </java-name>
						[Dot42.DexImport("CJK_COMPATIBILITY_IDEOGRAPHS", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock CJK_COMPATIBILITY_IDEOGRAPHS;
						/// <summary>
						/// <para>The "Alphabetic Presentation Forms" Unicode Block.</para><para><para>1.2 </para></para>        
						/// </summary>
						/// <java-name>
						/// ALPHABETIC_PRESENTATION_FORMS
						/// </java-name>
						[Dot42.DexImport("ALPHABETIC_PRESENTATION_FORMS", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock ALPHABETIC_PRESENTATION_FORMS;
						/// <summary>
						/// <para>The "Arabic Presentation Forms-A" Unicode Block.</para><para><para>1.2 </para></para>        
						/// </summary>
						/// <java-name>
						/// ARABIC_PRESENTATION_FORMS_A
						/// </java-name>
						[Dot42.DexImport("ARABIC_PRESENTATION_FORMS_A", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock ARABIC_PRESENTATION_FORMS_A;
						/// <summary>
						/// <para>The "Variation Selectors" Unicode Block.</para><para><para>1.5 </para></para>        
						/// </summary>
						/// <java-name>
						/// VARIATION_SELECTORS
						/// </java-name>
						[Dot42.DexImport("VARIATION_SELECTORS", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock VARIATION_SELECTORS;
						/// <summary>
						/// <para>The "Combining Half Marks" Unicode Block.</para><para><para>1.2 </para></para>        
						/// </summary>
						/// <java-name>
						/// COMBINING_HALF_MARKS
						/// </java-name>
						[Dot42.DexImport("COMBINING_HALF_MARKS", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock COMBINING_HALF_MARKS;
						/// <summary>
						/// <para>The "CJK Compatibility Forms" Unicode Block.</para><para><para>1.2 </para></para>        
						/// </summary>
						/// <java-name>
						/// CJK_COMPATIBILITY_FORMS
						/// </java-name>
						[Dot42.DexImport("CJK_COMPATIBILITY_FORMS", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock CJK_COMPATIBILITY_FORMS;
						/// <summary>
						/// <para>The "Small Form Variants" Unicode Block.</para><para><para>1.2 </para></para>        
						/// </summary>
						/// <java-name>
						/// SMALL_FORM_VARIANTS
						/// </java-name>
						[Dot42.DexImport("SMALL_FORM_VARIANTS", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock SMALL_FORM_VARIANTS;
						/// <summary>
						/// <para>The "Arabic Presentation Forms-B" Unicode Block.</para><para><para>1.2 </para></para>        
						/// </summary>
						/// <java-name>
						/// ARABIC_PRESENTATION_FORMS_B
						/// </java-name>
						[Dot42.DexImport("ARABIC_PRESENTATION_FORMS_B", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock ARABIC_PRESENTATION_FORMS_B;
						/// <summary>
						/// <para>The "Halfwidth and Fullwidth Forms" Unicode Block.</para><para><para>1.2 </para></para>        
						/// </summary>
						/// <java-name>
						/// HALFWIDTH_AND_FULLWIDTH_FORMS
						/// </java-name>
						[Dot42.DexImport("HALFWIDTH_AND_FULLWIDTH_FORMS", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock HALFWIDTH_AND_FULLWIDTH_FORMS;
						/// <summary>
						/// <para>The "Specials" Unicode Block.</para><para><para>1.2 </para></para>        
						/// </summary>
						/// <java-name>
						/// SPECIALS
						/// </java-name>
						[Dot42.DexImport("SPECIALS", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock SPECIALS;
						/// <summary>
						/// <para>The "Linear B Syllabary" Unicode Block.</para><para><para>1.2 </para></para>        
						/// </summary>
						/// <java-name>
						/// LINEAR_B_SYLLABARY
						/// </java-name>
						[Dot42.DexImport("LINEAR_B_SYLLABARY", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock LINEAR_B_SYLLABARY;
						/// <summary>
						/// <para>The "Linear B Ideograms" Unicode Block.</para><para><para>1.5 </para></para>        
						/// </summary>
						/// <java-name>
						/// LINEAR_B_IDEOGRAMS
						/// </java-name>
						[Dot42.DexImport("LINEAR_B_IDEOGRAMS", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock LINEAR_B_IDEOGRAMS;
						/// <summary>
						/// <para>The "Aegean Numbers" Unicode Block.</para><para><para>1.5 </para></para>        
						/// </summary>
						/// <java-name>
						/// AEGEAN_NUMBERS
						/// </java-name>
						[Dot42.DexImport("AEGEAN_NUMBERS", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock AEGEAN_NUMBERS;
						/// <summary>
						/// <para>The "Old Italic" Unicode Block.</para><para><para>1.5 </para></para>        
						/// </summary>
						/// <java-name>
						/// OLD_ITALIC
						/// </java-name>
						[Dot42.DexImport("OLD_ITALIC", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock OLD_ITALIC;
						/// <summary>
						/// <para>The "Gothic" Unicode Block.</para><para><para>1.5 </para></para>        
						/// </summary>
						/// <java-name>
						/// GOTHIC
						/// </java-name>
						[Dot42.DexImport("GOTHIC", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock GOTHIC;
						/// <summary>
						/// <para>The "Ugaritic" Unicode Block.</para><para><para>1.5 </para></para>        
						/// </summary>
						/// <java-name>
						/// UGARITIC
						/// </java-name>
						[Dot42.DexImport("UGARITIC", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock UGARITIC;
						/// <summary>
						/// <para>The "Deseret" Unicode Block.</para><para><para>1.5 </para></para>        
						/// </summary>
						/// <java-name>
						/// DESERET
						/// </java-name>
						[Dot42.DexImport("DESERET", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock DESERET;
						/// <summary>
						/// <para>The "Shavian" Unicode Block.</para><para><para>1.5 </para></para>        
						/// </summary>
						/// <java-name>
						/// SHAVIAN
						/// </java-name>
						[Dot42.DexImport("SHAVIAN", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock SHAVIAN;
						/// <summary>
						/// <para>The "Osmanya" Unicode Block.</para><para><para>1.5 </para></para>        
						/// </summary>
						/// <java-name>
						/// OSMANYA
						/// </java-name>
						[Dot42.DexImport("OSMANYA", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock OSMANYA;
						/// <summary>
						/// <para>The "Cypriot Syllabary" Unicode Block.</para><para><para>1.5 </para></para>        
						/// </summary>
						/// <java-name>
						/// CYPRIOT_SYLLABARY
						/// </java-name>
						[Dot42.DexImport("CYPRIOT_SYLLABARY", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock CYPRIOT_SYLLABARY;
						/// <summary>
						/// <para>The "Byzantine Musical Symbols" Unicode Block.</para><para><para>1.5 </para></para>        
						/// </summary>
						/// <java-name>
						/// BYZANTINE_MUSICAL_SYMBOLS
						/// </java-name>
						[Dot42.DexImport("BYZANTINE_MUSICAL_SYMBOLS", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock BYZANTINE_MUSICAL_SYMBOLS;
						/// <summary>
						/// <para>The "Musical Symbols" Unicode Block.</para><para><para>1.5 </para></para>        
						/// </summary>
						/// <java-name>
						/// MUSICAL_SYMBOLS
						/// </java-name>
						[Dot42.DexImport("MUSICAL_SYMBOLS", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock MUSICAL_SYMBOLS;
						/// <summary>
						/// <para>The "Tai Xuan Jing Symbols" Unicode Block.</para><para><para>1.5 </para></para>        
						/// </summary>
						/// <java-name>
						/// TAI_XUAN_JING_SYMBOLS
						/// </java-name>
						[Dot42.DexImport("TAI_XUAN_JING_SYMBOLS", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock TAI_XUAN_JING_SYMBOLS;
						/// <summary>
						/// <para>The "Mathematical Alphanumeric Symbols" Unicode Block.</para><para><para>1.5 </para></para>        
						/// </summary>
						/// <java-name>
						/// MATHEMATICAL_ALPHANUMERIC_SYMBOLS
						/// </java-name>
						[Dot42.DexImport("MATHEMATICAL_ALPHANUMERIC_SYMBOLS", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock MATHEMATICAL_ALPHANUMERIC_SYMBOLS;
						/// <summary>
						/// <para>The "CJK Unified Ideographs Extension B" Unicode Block.</para><para><para>1.5 </para></para>        
						/// </summary>
						/// <java-name>
						/// CJK_UNIFIED_IDEOGRAPHS_EXTENSION_B
						/// </java-name>
						[Dot42.DexImport("CJK_UNIFIED_IDEOGRAPHS_EXTENSION_B", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock CJK_UNIFIED_IDEOGRAPHS_EXTENSION_B;
						/// <summary>
						/// <para>The "CJK Compatibility Ideographs Supplement" Unicode Block.</para><para><para>1.5 </para></para>        
						/// </summary>
						/// <java-name>
						/// CJK_COMPATIBILITY_IDEOGRAPHS_SUPPLEMENT
						/// </java-name>
						[Dot42.DexImport("CJK_COMPATIBILITY_IDEOGRAPHS_SUPPLEMENT", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock CJK_COMPATIBILITY_IDEOGRAPHS_SUPPLEMENT;
						/// <summary>
						/// <para>The "Tags" Unicode Block.</para><para><para>1.5 </para></para>        
						/// </summary>
						/// <java-name>
						/// TAGS
						/// </java-name>
						[Dot42.DexImport("TAGS", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock TAGS;
						/// <summary>
						/// <para>The "Variation Selectors Supplement" Unicode Block.</para><para><para>1.5 </para></para>        
						/// </summary>
						/// <java-name>
						/// VARIATION_SELECTORS_SUPPLEMENT
						/// </java-name>
						[Dot42.DexImport("VARIATION_SELECTORS_SUPPLEMENT", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock VARIATION_SELECTORS_SUPPLEMENT;
						/// <summary>
						/// <para>The "Supplementary Private Use Area-A" Unicode Block.</para><para><para>1.5 </para></para>        
						/// </summary>
						/// <java-name>
						/// SUPPLEMENTARY_PRIVATE_USE_AREA_A
						/// </java-name>
						[Dot42.DexImport("SUPPLEMENTARY_PRIVATE_USE_AREA_A", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock SUPPLEMENTARY_PRIVATE_USE_AREA_A;
						/// <summary>
						/// <para>The "Supplementary Private Use Area-B" Unicode Block.</para><para><para>1.5 </para></para>        
						/// </summary>
						/// <java-name>
						/// SUPPLEMENTARY_PRIVATE_USE_AREA_B
						/// </java-name>
						[Dot42.DexImport("SUPPLEMENTARY_PRIVATE_USE_AREA_B", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock SUPPLEMENTARY_PRIVATE_USE_AREA_B;
						[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
						internal UnicodeBlock() /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						/// <para>Retrieves the constant that corresponds to the specified block name. The block names are defined by the Unicode 4.0.1 specification in the <c> Blocks-4.0.1.txt </c> file. </para><para>Block names may be one of the following: <ul><li><para>Canonical block name, as defined by the Unicode specification; case-insensitive. </para></li><li><para>Canonical block name without any spaces, as defined by the Unicode specification; case-insensitive. </para></li><li><para><c> UnicodeBlock </c> constant identifier. This is determined by uppercasing the canonical name and replacing all spaces and hyphens with underscores. </para></li></ul></para><para><para>1.5 </para></para>        
						/// </summary>
						/// <returns>
						/// <para>the UnicodeBlock constant corresponding to <c> blockName </c> . </para>
						/// </returns>
						/// <java-name>
						/// forName
						/// </java-name>
						[Dot42.DexImport("forName", "(Ljava/lang/String;)Ljava/lang/Character$UnicodeBlock;", AccessFlags = 9)]
						public static UnicodeBlock ForName(string blockName) /* MethodBuilder.Create */ 
						{
								return default(UnicodeBlock);
						}

						/// <summary>
						/// <para>Gets the constant for the Unicode block that contains the specified Unicode code point.</para><para><para>1.5 </para></para>        
						/// </summary>
						/// <returns>
						/// <para>the <c> UnicodeBlock </c> constant for the block that contains <c> codePoint </c> , or <c> null </c> if <c> codePoint </c> does not belong to any defined block. </para>
						/// </returns>
						/// <java-name>
						/// of
						/// </java-name>
						[Dot42.DexImport("of", "(C)Ljava/lang/Character$UnicodeBlock;", AccessFlags = 9)]
						public static UnicodeBlock Of(char codePoint) /* MethodBuilder.Create */ 
						{
								return default(UnicodeBlock);
						}

						/// <summary>
						/// <para>Gets the constant for the Unicode block that contains the specified Unicode code point.</para><para><para>1.5 </para></para>        
						/// </summary>
						/// <returns>
						/// <para>the <c> UnicodeBlock </c> constant for the block that contains <c> codePoint </c> , or <c> null </c> if <c> codePoint </c> does not belong to any defined block. </para>
						/// </returns>
						/// <java-name>
						/// of
						/// </java-name>
						[Dot42.DexImport("of", "(I)Ljava/lang/Character$UnicodeBlock;", AccessFlags = 9)]
						public static UnicodeBlock Of(int codePoint) /* MethodBuilder.Create */ 
						{
								return default(UnicodeBlock);
						}

				}

				/// <java-name>
				/// java/lang/Character$Subset
				/// </java-name>
				[Dot42.DexImport("java/lang/Character$Subset", AccessFlags = 9)]
				public partial class Subset
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 4)]
						protected internal Subset(string @string) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						/// <para>Compares this character subset with the specified object. Uses java.lang.Object#equals(Object) to do the comparison.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para><c> true </c> if <c> object </c> is this subset, that is, if <c> object == this </c> ; <c> false </c> otherwise. </para>
						/// </returns>
						/// <java-name>
						/// equals
						/// </java-name>
						[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 17)]
						public override bool Equals(object @object) /* MethodBuilder.Create */ 
						{
								return default(bool);
						}

						/// <summary>
						/// <para>Returns the integer hash code for this character subset.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>this subset's hash code, which is the hash code computed by java.lang.Object#hashCode(). </para>
						/// </returns>
						/// <java-name>
						/// hashCode
						/// </java-name>
						[Dot42.DexImport("hashCode", "()I", AccessFlags = 17)]
						public override int GetHashCode() /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <summary>
						/// <para>Returns the string representation of this subset.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>this subset's name. </para>
						/// </returns>
						/// <java-name>
						/// toString
						/// </java-name>
						[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 17)]
						public override string ToString() /* MethodBuilder.Create */ 
						{
								return default(string);
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal Subset() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

				}

		}

		/// <summary>
		/// <para>The wrapper for the primitive type <c> short </c> .</para><para><para>java.lang.Number </para><para>1.1 </para></para>    
		/// </summary>
		/// <java-name>
		/// java/lang/Short
		/// </java-name>
		[Dot42.DexImport("java/lang/Short", AccessFlags = 49, Signature = "Ljava/lang/Number;Ljava/lang/Comparable<Ljava/lang/Short;>;")]
		public partial struct Int16 : global::System.IComparable<short?>
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constant for the maximum <c> short </c> value, 2<span>15</span>-1. </para>        
				/// </summary>
				/// <java-name>
				/// MAX_VALUE
				/// </java-name>
				[Dot42.DexImport("MAX_VALUE", "S", AccessFlags = 25)]
				public const short MaxValue = 32767;
				/// <summary>
				/// <para>Constant for the minimum <c> short </c> value, -2<span>15</span>. </para>        
				/// </summary>
				/// <java-name>
				/// MIN_VALUE
				/// </java-name>
				[Dot42.DexImport("MIN_VALUE", "S", AccessFlags = 25)]
				public const short MinValue = -32768;
				/// <summary>
				/// <para>Constant for the number of bits needed to represent a <c> short </c> in two's complement form.</para><para><para>1.5 </para></para>        
				/// </summary>
				/// <java-name>
				/// SIZE
				/// </java-name>
				[Dot42.DexImport("SIZE", "I", AccessFlags = 25)]
				public const int SIZE = 16;
				/// <summary>
				/// <para>The Class object that represents the primitive type <c>       short </c> . </para>        
				/// </summary>
				/// <java-name>
				/// TYPE
				/// </java-name>
				[Dot42.DexImport("TYPE", "Ljava/lang/Class;", AccessFlags = 25)]
				public static readonly global::System.Type TYPE;
				/// <summary>
				/// <para>Constructs a new <c> Short </c> from the specified string.</para><para><para>parseShort(String) </para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public Int16(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a new <c> Short </c> from the specified string.</para><para><para>parseShort(String) </para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(S)V", AccessFlags = 1)]
				public Int16(short @string) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns this object's value as a byte. Might involve rounding and/or truncating the value, so it fits into a byte.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the primitive byte value of this object. </para>
				/// </returns>
				/// <java-name>
				/// byteValue
				/// </java-name>
				[Dot42.DexImport("byteValue", "()B", AccessFlags = 1)]
				public sbyte ByteValue() /* MethodBuilder.Create */ 
				{
						return default(sbyte);
				}

				/// <summary>
				/// <para>Compares this object to the specified short object to determine their relative order.</para><para><para>java.lang.Comparable </para><para>1.2 </para></para>        
				/// </summary>
				/// <returns>
				/// <para>a negative value if the value of this short is less than the value of <c> object </c> ; 0 if the value of this short and the value of <c> object </c> are equal; a positive value if the value of this short is greater than the value of <c> object </c> . </para>
				/// </returns>
				/// <java-name>
				/// compareTo
				/// </java-name>
				[Dot42.DexImport("compareTo", "(Ljava/lang/Short;)I", AccessFlags = 1)]
				public int CompareTo(short? @object) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Parses the specified string and returns a <c> Short </c> instance if the string can be decoded into a short value. The string may be an optional minus sign "-" followed by a hexadecimal ("0x..." or "#..."), octal ("0..."), or decimal ("...") representation of a short.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a <c> Short </c> containing the value represented by <c> string </c> . </para>
				/// </returns>
				/// <java-name>
				/// decode
				/// </java-name>
				[Dot42.DexImport("decode", "(Ljava/lang/String;)Ljava/lang/Short;", AccessFlags = 9)]
				public static short? Decode(string @string) /* MethodBuilder.Create */ 
				{
						return default(short?);
				}

				/// <summary>
				/// <para>Returns this object's value as a double. Might involve rounding.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the primitive double value of this object. </para>
				/// </returns>
				/// <java-name>
				/// doubleValue
				/// </java-name>
				[Dot42.DexImport("doubleValue", "()D", AccessFlags = 1)]
				public double DoubleValue() /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <summary>
				/// <para>Compares this instance with the specified object and indicates if they are equal. In order to be equal, <c> object </c> must be an instance of <c> Short </c> and have the same short value as this object.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the specified object is equal to this <c> Short </c> ; <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public bool Equals(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns this object's value as a float. Might involve rounding.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the primitive float value of this object. </para>
				/// </returns>
				/// <java-name>
				/// floatValue
				/// </java-name>
				[Dot42.DexImport("floatValue", "()F", AccessFlags = 1)]
				public float FloatValue() /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 1)]
				public int GetHashCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns this object's value as an int. Might involve rounding and/or truncating the value, so it fits into an int.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the primitive int value of this object. </para>
				/// </returns>
				/// <java-name>
				/// intValue
				/// </java-name>
				[Dot42.DexImport("intValue", "()I", AccessFlags = 1)]
				public int IntValue() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns this object's value as a long. Might involve rounding and/or truncating the value, so it fits into a long.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the primitive long value of this object. </para>
				/// </returns>
				/// <java-name>
				/// longValue
				/// </java-name>
				[Dot42.DexImport("longValue", "()J", AccessFlags = 1)]
				public long LongValue() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>Parses the specified string as a signed decimal short value. The ASCII character  ('-') is recognized as the minus sign.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the primitive short value represented by <c> string </c> . </para>
				/// </returns>
				/// <java-name>
				/// parseShort
				/// </java-name>
				[Dot42.DexImport("parseShort", "(Ljava/lang/String;)S", AccessFlags = 9)]
				public static short Parse(string @string) /* MethodBuilder.Create */ 
				{
						return default(short);
				}

				/// <summary>
				/// <para>Parses the specified string as a signed short value using the specified radix. The ASCII character  ('-') is recognized as the minus sign.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the primitive short value represented by <c> string </c> using <c> radix </c> . </para>
				/// </returns>
				/// <java-name>
				/// parseShort
				/// </java-name>
				[Dot42.DexImport("parseShort", "(Ljava/lang/String;I)S", AccessFlags = 9)]
				public static short Parse(string @string, int radix) /* MethodBuilder.Create */ 
				{
						return default(short);
				}

				/// <summary>
				/// <para>Gets the primitive value of this short.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>this object's primitive value. </para>
				/// </returns>
				/// <java-name>
				/// shortValue
				/// </java-name>
				[Dot42.DexImport("shortValue", "()S", AccessFlags = 1)]
				public short ShortValue() /* MethodBuilder.Create */ 
				{
						return default(short);
				}

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns a string containing a concise, human-readable description of the specified short value with radix 10.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a printable representation of <c> value </c> . </para>
				/// </returns>
				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "(S)Ljava/lang/String;", AccessFlags = 9)]
				public static string ToString(short value) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Parses the specified string as a signed decimal short value.</para><para><para>parseShort(String) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>a <c> Short </c> instance containing the short value represented by <c> string </c> . </para>
				/// </returns>
				/// <java-name>
				/// valueOf
				/// </java-name>
				[Dot42.DexImport("valueOf", "(Ljava/lang/String;)Ljava/lang/Short;", AccessFlags = 9)]
				public static short? ValueOf(string @string) /* MethodBuilder.Create */ 
				{
						return default(short?);
				}

				/// <summary>
				/// <para>Parses the specified string as a signed short value using the specified radix.</para><para><para>parseShort(String, int) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>a <c> Short </c> instance containing the short value represented by <c> string </c> using <c> radix </c> . </para>
				/// </returns>
				/// <java-name>
				/// valueOf
				/// </java-name>
				[Dot42.DexImport("valueOf", "(Ljava/lang/String;I)Ljava/lang/Short;", AccessFlags = 9)]
				public static short? ValueOf(string @string, int radix) /* MethodBuilder.Create */ 
				{
						return default(short?);
				}

				/// <summary>
				/// <para>Reverses the bytes of the specified short.</para><para><para>1.5 </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the reversed value. </para>
				/// </returns>
				/// <java-name>
				/// reverseBytes
				/// </java-name>
				[Dot42.DexImport("reverseBytes", "(S)S", AccessFlags = 9)]
				public static short ReverseBytes(short s) /* MethodBuilder.Create */ 
				{
						return default(short);
				}

				/// <summary>
				/// <para>Parses the specified string as a signed decimal short value.</para><para><para>parseShort(String) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>a <c> Short </c> instance containing the short value represented by <c> string </c> . </para>
				/// </returns>
				/// <java-name>
				/// valueOf
				/// </java-name>
				[Dot42.DexImport("valueOf", "(S)Ljava/lang/Short;", AccessFlags = 9)]
				public static short? ValueOf(short @string) /* MethodBuilder.Create */ 
				{
						return default(short?);
				}

		}

		/// <summary>
		/// <para>Thrown when a method is invoked with an argument which it can not reasonably deal with. </para>    
		/// </summary>
		/// <java-name>
		/// java/lang/IllegalArgumentException
		/// </java-name>
		[Dot42.DexImport("java/lang/IllegalArgumentException", AccessFlags = 33)]
		public partial class ArgumentException : global::System.SystemException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs a new <c> IllegalArgumentException </c> that includes the current stack trace. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ArgumentException() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a new <c> IllegalArgumentException </c> with the current stack trace and the specified detail message.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public ArgumentException(string detailMessage) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a new <c> IllegalArgumentException </c> with the current stack trace, the specified detail message and the specified cause.</para><para><para>1.5 </para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public ArgumentException(string message, global::System.Exception cause) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a new <c> IllegalArgumentException </c> with the current stack trace and the specified detail message.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public ArgumentException(global::System.Exception detailMessage) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>The wrapper for the primitive type <c> byte </c> .</para><para><para>1.1 </para></para>    
		/// </summary>
		/// <java-name>
		/// java/lang/Byte
		/// </java-name>
		[Dot42.DexImport("java/lang/Byte", AccessFlags = 49, Signature = "Ljava/lang/Number;Ljava/lang/Comparable<Ljava/lang/Byte;>;")]
		public partial struct SByte : global::System.IComparable<sbyte?>
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>The maximum <c> Byte </c> value, 2<span>7</span>-1. </para>        
				/// </summary>
				/// <java-name>
				/// MAX_VALUE
				/// </java-name>
				[Dot42.DexImport("MAX_VALUE", "B", AccessFlags = 25)]
				public const sbyte MaxValue = 127;
				/// <summary>
				/// <para>The minimum <c> Byte </c> value, -2<span>7</span>. </para>        
				/// </summary>
				/// <java-name>
				/// MIN_VALUE
				/// </java-name>
				[Dot42.DexImport("MIN_VALUE", "B", AccessFlags = 25)]
				public const sbyte MinValue = -128;
				/// <summary>
				/// <para>The number of bits needed to represent a <c> Byte </c> value in two's complement form.</para><para><para>1.5 </para></para>        
				/// </summary>
				/// <java-name>
				/// SIZE
				/// </java-name>
				[Dot42.DexImport("SIZE", "I", AccessFlags = 25)]
				public const int SIZE = 8;
				/// <summary>
				/// <para>The Class object that represents the primitive type <c> byte </c> . </para>        
				/// </summary>
				/// <java-name>
				/// TYPE
				/// </java-name>
				[Dot42.DexImport("TYPE", "Ljava/lang/Class;", AccessFlags = 25)]
				public static readonly global::System.Type TYPE;
				/// <summary>
				/// <para>Constructs a new <c> Byte </c> with the specified primitive byte value.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(B)V", AccessFlags = 1)]
				public SByte(sbyte value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a new <c> Byte </c> with the specified primitive byte value.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public SByte(string value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets the primitive value of this byte.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>this object's primitive value. </para>
				/// </returns>
				/// <java-name>
				/// byteValue
				/// </java-name>
				[Dot42.DexImport("byteValue", "()B", AccessFlags = 1)]
				public sbyte ByteValue() /* MethodBuilder.Create */ 
				{
						return default(sbyte);
				}

				/// <summary>
				/// <para>Compares this object to the specified byte object to determine their relative order.</para><para><para>java.lang.Comparable </para><para>1.2 </para></para>        
				/// </summary>
				/// <returns>
				/// <para>a negative value if the value of this byte is less than the value of <c> object </c> ; 0 if the value of this byte and the value of <c> object </c> are equal; a positive value if the value of this byte is greater than the value of <c> object </c> . </para>
				/// </returns>
				/// <java-name>
				/// compareTo
				/// </java-name>
				[Dot42.DexImport("compareTo", "(Ljava/lang/Byte;)I", AccessFlags = 1)]
				public int CompareTo(sbyte? @object) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Parses the specified string and returns a <c> Byte </c> instance if the string can be decoded into a single byte value. The string may be an optional minus sign "-" followed by a hexadecimal ("0x..." or "#..."), octal ("0..."), or decimal ("...") representation of a byte.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a <c> Byte </c> containing the value represented by <c> string </c> . </para>
				/// </returns>
				/// <java-name>
				/// decode
				/// </java-name>
				[Dot42.DexImport("decode", "(Ljava/lang/String;)Ljava/lang/Byte;", AccessFlags = 9)]
				public static sbyte? Decode(string @string) /* MethodBuilder.Create */ 
				{
						return default(sbyte?);
				}

				/// <summary>
				/// <para>Returns this object's value as a double. Might involve rounding.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the primitive double value of this object. </para>
				/// </returns>
				/// <java-name>
				/// doubleValue
				/// </java-name>
				[Dot42.DexImport("doubleValue", "()D", AccessFlags = 1)]
				public double DoubleValue() /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <summary>
				/// <para>Compares this object with the specified object and indicates if they are equal. In order to be equal, <c> object </c> must be an instance of <c> Byte </c> and have the same byte value as this object.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the specified object is equal to this <c> Byte </c> ; <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public bool Equals(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns this object's value as a float. Might involve rounding.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the primitive float value of this object. </para>
				/// </returns>
				/// <java-name>
				/// floatValue
				/// </java-name>
				[Dot42.DexImport("floatValue", "()F", AccessFlags = 1)]
				public float FloatValue() /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 1)]
				public int GetHashCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns this object's value as an int. Might involve rounding and/or truncating the value, so it fits into an int.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the primitive int value of this object. </para>
				/// </returns>
				/// <java-name>
				/// intValue
				/// </java-name>
				[Dot42.DexImport("intValue", "()I", AccessFlags = 1)]
				public int IntValue() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns this object's value as a long. Might involve rounding and/or truncating the value, so it fits into a long.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the primitive long value of this object. </para>
				/// </returns>
				/// <java-name>
				/// longValue
				/// </java-name>
				[Dot42.DexImport("longValue", "()J", AccessFlags = 1)]
				public long LongValue() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>Parses the specified string as a signed decimal byte value. The ASCII character  ('-') is recognized as the minus sign.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the primitive byte value represented by <c> string </c> . </para>
				/// </returns>
				/// <java-name>
				/// parseByte
				/// </java-name>
				[Dot42.DexImport("parseByte", "(Ljava/lang/String;)B", AccessFlags = 9)]
				public static sbyte Parse(string @string) /* MethodBuilder.Create */ 
				{
						return default(sbyte);
				}

				/// <summary>
				/// <para>Parses the specified string as a signed byte value using the specified radix. The ASCII character  ('-') is recognized as the minus sign.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the primitive byte value represented by <c> string </c> using <c> radix </c> . </para>
				/// </returns>
				/// <java-name>
				/// parseByte
				/// </java-name>
				[Dot42.DexImport("parseByte", "(Ljava/lang/String;I)B", AccessFlags = 9)]
				public static sbyte Parse(string @string, int radix) /* MethodBuilder.Create */ 
				{
						return default(sbyte);
				}

				/// <summary>
				/// <para>Returns this object's value as a short. Might involve rounding and/or truncating the value, so it fits into a short.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the primitive short value of this object. </para>
				/// </returns>
				/// <java-name>
				/// shortValue
				/// </java-name>
				[Dot42.DexImport("shortValue", "()S", AccessFlags = 1)]
				public short ShortValue() /* MethodBuilder.Create */ 
				{
						return default(short);
				}

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns a string containing a concise, human-readable description of the specified byte value.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a printable representation of <c> value </c> . </para>
				/// </returns>
				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "(B)Ljava/lang/String;", AccessFlags = 9)]
				public static string ToString(sbyte value) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Parses the specified string as a signed decimal byte value.</para><para><para>parseByte(String) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>a <c> Byte </c> instance containing the byte value represented by <c> string </c> . </para>
				/// </returns>
				/// <java-name>
				/// valueOf
				/// </java-name>
				[Dot42.DexImport("valueOf", "(Ljava/lang/String;)Ljava/lang/Byte;", AccessFlags = 9)]
				public static sbyte? ValueOf(string @string) /* MethodBuilder.Create */ 
				{
						return default(sbyte?);
				}

				/// <summary>
				/// <para>Parses the specified string as a signed byte value using the specified radix.</para><para><para>parseByte(String, int) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>a <c> Byte </c> instance containing the byte value represented by <c> string </c> using <c> radix </c> . </para>
				/// </returns>
				/// <java-name>
				/// valueOf
				/// </java-name>
				[Dot42.DexImport("valueOf", "(Ljava/lang/String;I)Ljava/lang/Byte;", AccessFlags = 9)]
				public static sbyte? ValueOf(string @string, int radix) /* MethodBuilder.Create */ 
				{
						return default(sbyte?);
				}

				/// <summary>
				/// <para>Parses the specified string as a signed decimal byte value.</para><para><para>parseByte(String) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>a <c> Byte </c> instance containing the byte value represented by <c> string </c> . </para>
				/// </returns>
				/// <java-name>
				/// valueOf
				/// </java-name>
				[Dot42.DexImport("valueOf", "(B)Ljava/lang/Byte;", AccessFlags = 9)]
				public static sbyte? ValueOf(sbyte @string) /* MethodBuilder.Create */ 
				{
						return default(sbyte?);
				}

		}

		/// <summary>
		/// <para>The wrapper for the primitive type <c> long </c> . </para><para>Implementation note: The "bit twiddling" methods in this class use techniques described in  and </para><para><para>java.lang.Integer </para><para>1.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// java/lang/Long
		/// </java-name>
		[Dot42.DexImport("java/lang/Long", AccessFlags = 49, Signature = "Ljava/lang/Number;Ljava/lang/Comparable<Ljava/lang/Long;>;")]
		public partial struct Int64 : global::System.IComparable<long?>
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constant for the maximum <c> long </c> value, 2<span>63</span>-1. </para>        
				/// </summary>
				/// <java-name>
				/// MAX_VALUE
				/// </java-name>
				[Dot42.DexImport("MAX_VALUE", "J", AccessFlags = 25)]
				public const long MaxValue = 9223372036854775807;
				/// <summary>
				/// <para>Constant for the minimum <c> long </c> value, -2<span>63</span>. </para>        
				/// </summary>
				/// <java-name>
				/// MIN_VALUE
				/// </java-name>
				[Dot42.DexImport("MIN_VALUE", "J", AccessFlags = 25)]
				public const long MinValue = -9223372036854775808;
				/// <summary>
				/// <para>The Class object that represents the primitive type <c> long </c> . </para>        
				/// </summary>
				/// <java-name>
				/// TYPE
				/// </java-name>
				[Dot42.DexImport("TYPE", "Ljava/lang/Class;", AccessFlags = 25)]
				public static readonly global::System.Type TYPE;
				/// <summary>
				/// <para>Constant for the number of bits needed to represent a <c> long </c> in two's complement form.</para><para><para>1.5 </para></para>        
				/// </summary>
				/// <java-name>
				/// SIZE
				/// </java-name>
				[Dot42.DexImport("SIZE", "I", AccessFlags = 25)]
				public const int SIZE = 64;
				/// <summary>
				/// <para>Constructs a new <c> Long </c> with the specified primitive long value.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(J)V", AccessFlags = 1)]
				public Int64(long value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a new <c> Long </c> with the specified primitive long value.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public Int64(string value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns this object's value as a byte. Might involve rounding and/or truncating the value, so it fits into a byte.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the primitive byte value of this object. </para>
				/// </returns>
				/// <java-name>
				/// byteValue
				/// </java-name>
				[Dot42.DexImport("byteValue", "()B", AccessFlags = 1)]
				public sbyte ByteValue() /* MethodBuilder.Create */ 
				{
						return default(sbyte);
				}

				/// <summary>
				/// <para>Compares this object to the specified long object to determine their relative order.</para><para><para>java.lang.Comparable </para><para>1.2 </para></para>        
				/// </summary>
				/// <returns>
				/// <para>a negative value if the value of this long is less than the value of <c> object </c> ; 0 if the value of this long and the value of <c> object </c> are equal; a positive value if the value of this long is greater than the value of <c> object </c> . </para>
				/// </returns>
				/// <java-name>
				/// compareTo
				/// </java-name>
				[Dot42.DexImport("compareTo", "(Ljava/lang/Long;)I", AccessFlags = 1)]
				public int CompareTo(long? @object) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Parses the specified string and returns a <c> Long </c> instance if the string can be decoded into a long value. The string may be an optional minus sign "-" followed by a hexadecimal ("0x..." or "#..."), octal ("0..."), or decimal ("...") representation of a long.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a <c> Long </c> containing the value represented by <c> string </c> . </para>
				/// </returns>
				/// <java-name>
				/// decode
				/// </java-name>
				[Dot42.DexImport("decode", "(Ljava/lang/String;)Ljava/lang/Long;", AccessFlags = 9)]
				public static long? Decode(string @string) /* MethodBuilder.Create */ 
				{
						return default(long?);
				}

				/// <summary>
				/// <para>Returns this object's value as a double. Might involve rounding.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the primitive double value of this object. </para>
				/// </returns>
				/// <java-name>
				/// doubleValue
				/// </java-name>
				[Dot42.DexImport("doubleValue", "()D", AccessFlags = 1)]
				public double DoubleValue() /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <summary>
				/// <para>Compares this instance with the specified object and indicates if they are equal. In order to be equal, <c> o </c> must be an instance of <c> Long </c> and have the same long value as this object.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the specified object is equal to this <c> Long </c> ; <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public bool Equals(object o) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns this object's value as a float. Might involve rounding.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the primitive float value of this object. </para>
				/// </returns>
				/// <java-name>
				/// floatValue
				/// </java-name>
				[Dot42.DexImport("floatValue", "()F", AccessFlags = 1)]
				public float FloatValue() /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				/// <para>Returns the <c> Long </c> value of the system property identified by <c> string </c> . Returns <c> null </c> if <c> string </c> is <c> null </c> or empty, if the property can not be found or if its value can not be parsed as a long.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the requested property's value as a <c> Long </c> or <c> null </c> . </para>
				/// </returns>
				/// <java-name>
				/// getLong
				/// </java-name>
				[Dot42.DexImport("getLong", "(Ljava/lang/String;)Ljava/lang/Long;", AccessFlags = 9)]
				public static long? GetLong(string @string) /* MethodBuilder.Create */ 
				{
						return default(long?);
				}

				/// <summary>
				/// <para>Returns the <c> Long </c> value of the system property identified by <c> string </c> . Returns the specified default value if <c> string </c> is <c> null </c> or empty, if the property can not be found or if its value can not be parsed as a long.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the requested property's value as a <c> Long </c> or the default value. </para>
				/// </returns>
				/// <java-name>
				/// getLong
				/// </java-name>
				[Dot42.DexImport("getLong", "(Ljava/lang/String;J)Ljava/lang/Long;", AccessFlags = 9)]
				public static long? GetLong(string @string, long defaultValue) /* MethodBuilder.Create */ 
				{
						return default(long?);
				}

				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 1)]
				public int GetHashCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns this object's value as an int. Might involve rounding and/or truncating the value, so it fits into an int.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the primitive int value of this object. </para>
				/// </returns>
				/// <java-name>
				/// intValue
				/// </java-name>
				[Dot42.DexImport("intValue", "()I", AccessFlags = 1)]
				public int IntValue() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Gets the primitive value of this long.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>this object's primitive value. </para>
				/// </returns>
				/// <java-name>
				/// longValue
				/// </java-name>
				[Dot42.DexImport("longValue", "()J", AccessFlags = 1)]
				public long LongValue() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>Parses the specified string as a signed decimal long value. The ASCII character  ('-') is recognized as the minus sign.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the primitive long value represented by <c> string </c> . </para>
				/// </returns>
				/// <java-name>
				/// parseLong
				/// </java-name>
				[Dot42.DexImport("parseLong", "(Ljava/lang/String;)J", AccessFlags = 9)]
				public static long Parse(string @string) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>Parses the specified string as a signed long value using the specified radix. The ASCII character  ('-') is recognized as the minus sign.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the primitive long value represented by <c> string </c> using <c> radix </c> . </para>
				/// </returns>
				/// <java-name>
				/// parseLong
				/// </java-name>
				[Dot42.DexImport("parseLong", "(Ljava/lang/String;I)J", AccessFlags = 9)]
				public static long Parse(string @string, int radix) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>Returns this object's value as a short. Might involve rounding and/or truncating the value, so it fits into a short.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the primitive short value of this object. </para>
				/// </returns>
				/// <java-name>
				/// shortValue
				/// </java-name>
				[Dot42.DexImport("shortValue", "()S", AccessFlags = 1)]
				public short ShortValue() /* MethodBuilder.Create */ 
				{
						return default(short);
				}

				/// <summary>
				/// <para>Converts the specified long value into its binary string representation. The returned string is a concatenation of '0' and '1' characters.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the binary string representation of <c> v </c> . </para>
				/// </returns>
				/// <java-name>
				/// toBinaryString
				/// </java-name>
				[Dot42.DexImport("toBinaryString", "(J)Ljava/lang/String;", AccessFlags = 9)]
				public static string ToBinaryString(long v) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Converts the specified long value into its hexadecimal string representation. The returned string is a concatenation of characters from '0' to '9' and 'a' to 'f'.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the hexadecimal string representation of <c> l </c> . </para>
				/// </returns>
				/// <java-name>
				/// toHexString
				/// </java-name>
				[Dot42.DexImport("toHexString", "(J)Ljava/lang/String;", AccessFlags = 9)]
				public static string ToHexString(long v) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Converts the specified long value into its octal string representation. The returned string is a concatenation of characters from '0' to '7'.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the octal string representation of <c> l </c> . </para>
				/// </returns>
				/// <java-name>
				/// toOctalString
				/// </java-name>
				[Dot42.DexImport("toOctalString", "(J)Ljava/lang/String;", AccessFlags = 9)]
				public static string ToOctalString(long v) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Converts the specified long value into its decimal string representation. The returned string is a concatenation of a minus sign if the number is negative and characters from '0' to '9'.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the decimal string representation of <c> l </c> . </para>
				/// </returns>
				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "(J)Ljava/lang/String;", AccessFlags = 9)]
				public static string ToString(long n) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Converts the specified signed long value into a string representation based on the specified radix. The returned string is a concatenation of a minus sign if the number is negative and characters from '0' to '9' and 'a' to 'z', depending on the radix. If <c> radix </c> is not in the interval defined by <c> Character.MIN_RADIX </c> and <c> Character.MAX_RADIX </c> then 10 is used as the base for the conversion.</para><para>This method treats its argument as signed. If you want to convert an unsigned value to one of the common non-decimal bases, you may find toBinaryString, <c> #toHexString </c> , or toOctalString more convenient.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the string representation of <c> v </c> . </para>
				/// </returns>
				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "(JI)Ljava/lang/String;", AccessFlags = 9)]
				public static string ToString(long v, int radix) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Parses the specified string as a signed decimal long value.</para><para><para>parseLong(String) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>a <c> Long </c> instance containing the long value represented by <c> string </c> . </para>
				/// </returns>
				/// <java-name>
				/// valueOf
				/// </java-name>
				[Dot42.DexImport("valueOf", "(Ljava/lang/String;)Ljava/lang/Long;", AccessFlags = 9)]
				public static long? ValueOf(string @string) /* MethodBuilder.Create */ 
				{
						return default(long?);
				}

				/// <summary>
				/// <para>Parses the specified string as a signed long value using the specified radix.</para><para><para>parseLong(String, int) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>a <c> Long </c> instance containing the long value represented by <c> string </c> using <c> radix </c> . </para>
				/// </returns>
				/// <java-name>
				/// valueOf
				/// </java-name>
				[Dot42.DexImport("valueOf", "(Ljava/lang/String;I)Ljava/lang/Long;", AccessFlags = 9)]
				public static long? ValueOf(string @string, int radix) /* MethodBuilder.Create */ 
				{
						return default(long?);
				}

				/// <summary>
				/// <para>Determines the highest (leftmost) bit of the specified long value that is 1 and returns the bit mask value for that bit. This is also referred to as the Most Significant 1 Bit. Returns zero if the specified long is zero.</para><para><para>1.5 </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the bit mask indicating the highest 1 bit in <c> v </c> . </para>
				/// </returns>
				/// <java-name>
				/// highestOneBit
				/// </java-name>
				[Dot42.DexImport("highestOneBit", "(J)J", AccessFlags = 9)]
				public static long HighestOneBit(long v) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>Determines the lowest (rightmost) bit of the specified long value that is 1 and returns the bit mask value for that bit. This is also referred to as the Least Significant 1 Bit. Returns zero if the specified long is zero.</para><para><para>1.5 </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the bit mask indicating the lowest 1 bit in <c> v </c> . </para>
				/// </returns>
				/// <java-name>
				/// lowestOneBit
				/// </java-name>
				[Dot42.DexImport("lowestOneBit", "(J)J", AccessFlags = 9)]
				public static long LowestOneBit(long v) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>Determines the number of leading zeros in the specified long value prior to the highest one bit.</para><para><para>1.5 </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of leading zeros in <c> v </c> . </para>
				/// </returns>
				/// <java-name>
				/// numberOfLeadingZeros
				/// </java-name>
				[Dot42.DexImport("numberOfLeadingZeros", "(J)I", AccessFlags = 9)]
				public static int NumberOfLeadingZeros(long v) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Determines the number of trailing zeros in the specified long value after the lowest one bit.</para><para><para>1.5 </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of trailing zeros in <c> v </c> . </para>
				/// </returns>
				/// <java-name>
				/// numberOfTrailingZeros
				/// </java-name>
				[Dot42.DexImport("numberOfTrailingZeros", "(J)I", AccessFlags = 9)]
				public static int NumberOfTrailingZeros(long v) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Counts the number of 1 bits in the specified long value; this is also referred to as population count.</para><para><para>1.5 </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of 1 bits in <c> v </c> . </para>
				/// </returns>
				/// <java-name>
				/// bitCount
				/// </java-name>
				[Dot42.DexImport("bitCount", "(J)I", AccessFlags = 9)]
				public static int BitCount(long v) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Rotates the bits of the specified long value to the left by the specified number of bits.</para><para><para>1.5 </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the rotated value. </para>
				/// </returns>
				/// <java-name>
				/// rotateLeft
				/// </java-name>
				[Dot42.DexImport("rotateLeft", "(JI)J", AccessFlags = 9)]
				public static long RotateLeft(long v, int distance) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>Rotates the bits of the specified long value to the right by the specified number of bits.</para><para><para>1.5 </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the rotated value. </para>
				/// </returns>
				/// <java-name>
				/// rotateRight
				/// </java-name>
				[Dot42.DexImport("rotateRight", "(JI)J", AccessFlags = 9)]
				public static long RotateRight(long v, int distance) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>Reverses the order of the bytes of the specified long value.</para><para><para>1.5 </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the reversed value. </para>
				/// </returns>
				/// <java-name>
				/// reverseBytes
				/// </java-name>
				[Dot42.DexImport("reverseBytes", "(J)J", AccessFlags = 9)]
				public static long ReverseBytes(long v) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>Reverses the order of the bits of the specified long value.</para><para><para>1.5 </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the reversed value. </para>
				/// </returns>
				/// <java-name>
				/// reverse
				/// </java-name>
				[Dot42.DexImport("reverse", "(J)J", AccessFlags = 9)]
				public static long Reverse(long v) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>Returns the value of the <c> signum </c> function for the specified long value.</para><para><para>1.5 </para></para>        
				/// </summary>
				/// <returns>
				/// <para>-1 if <c> v </c> is negative, 1 if <c> v </c> is positive, 0 if <c> v </c> is zero. </para>
				/// </returns>
				/// <java-name>
				/// signum
				/// </java-name>
				[Dot42.DexImport("signum", "(J)I", AccessFlags = 9)]
				public static int Signum(long v) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Parses the specified string as a signed decimal long value.</para><para><para>parseLong(String) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>a <c> Long </c> instance containing the long value represented by <c> string </c> . </para>
				/// </returns>
				/// <java-name>
				/// valueOf
				/// </java-name>
				[Dot42.DexImport("valueOf", "(J)Ljava/lang/Long;", AccessFlags = 9)]
				public static long? ValueOf(long @string) /* MethodBuilder.Create */ 
				{
						return default(long?);
				}

		}

		/// <summary>
		/// <para>Thrown when a program attempts to cast a an object to a type with which it is not compatible. </para>    
		/// </summary>
		/// <java-name>
		/// java/lang/ClassCastException
		/// </java-name>
		[Dot42.DexImport("java/lang/ClassCastException", AccessFlags = 33)]
		public partial class InvalidCastException : global::System.SystemException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs a new <c> ClassCastException </c> that includes the current stack trace. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public InvalidCastException() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a new <c> ClassCastException </c> with the current stack trace and the specified detail message.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public InvalidCastException(string detailMessage) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>The wrapper for the primitive type <c> double </c> .</para><para><para>java.lang.Number </para><para>1.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// java/lang/Double
		/// </java-name>
		[Dot42.DexImport("java/lang/Double", AccessFlags = 49, Signature = "Ljava/lang/Number;Ljava/lang/Comparable<Ljava/lang/Double;>;")]
		public partial struct Double : global::System.IComparable<double?>
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constant for the maximum <c> double </c> value, (2 - 2<span>-52</span>) * 2<span>1023</span>. </para>        
				/// </summary>
				/// <java-name>
				/// MAX_VALUE
				/// </java-name>
				[Dot42.DexImport("MAX_VALUE", "D", AccessFlags = 25)]
				public const double MaxValue = 1.7976931348623157E+308D;
				/// <summary>
				/// <para>Constant for the minimum <c> double </c> value, 2<span>-1074</span>. </para>        
				/// </summary>
				/// <java-name>
				/// MIN_VALUE
				/// </java-name>
				[Dot42.DexImport("MIN_VALUE", "D", AccessFlags = 25)]
				public const double Epsilon = 4.94065645841247E-324D;
				/// <summary>
				/// <para>Constant for the Not-a-Number (NaN) value of the <c> double </c> type. </para>        
				/// </summary>
				/// <java-name>
				/// NaN
				/// </java-name>
				[Dot42.DexImport("NaN", "D", AccessFlags = 25)]
				public const double NaN = 0.0d / 0.0d;
				/// <summary>
				/// <para>Constant for the positive infinity value of the <c> double </c> type. </para>        
				/// </summary>
				/// <java-name>
				/// POSITIVE_INFINITY
				/// </java-name>
				[Dot42.DexImport("POSITIVE_INFINITY", "D", AccessFlags = 25)]
				public static readonly double PositiveInfinity;
				/// <summary>
				/// <para>Constant for the negative infinity value of the <c> double </c> type. </para>        
				/// </summary>
				/// <java-name>
				/// NEGATIVE_INFINITY
				/// </java-name>
				[Dot42.DexImport("NEGATIVE_INFINITY", "D", AccessFlags = 25)]
				public static readonly double NegativeInfinity;
				/// <summary>
				/// <para>Constant for the smallest positive normal value of the <c> double </c> type.</para><para><para>1.6 </para></para>        
				/// </summary>
				/// <java-name>
				/// MIN_NORMAL
				/// </java-name>
				[Dot42.DexImport("MIN_NORMAL", "D", AccessFlags = 25)]
				public const double MIN_NORMAL = 2.2250738585072014E-308D;
				/// <summary>
				/// <para>Maximum base-2 exponent that a finite value of the <c> double </c> type may have. Equal to <c> Math.getExponent(Double.MAX_VALUE) </c> .</para><para><para>1.6 </para></para>        
				/// </summary>
				/// <java-name>
				/// MAX_EXPONENT
				/// </java-name>
				[Dot42.DexImport("MAX_EXPONENT", "I", AccessFlags = 25)]
				public const int MAX_EXPONENT = 1023;
				/// <summary>
				/// <para>Minimum base-2 exponent that a normal value of the <c> double </c> type may have. Equal to <c> Math.getExponent(Double.MIN_NORMAL) </c> .</para><para><para>1.6 </para></para>        
				/// </summary>
				/// <java-name>
				/// MIN_EXPONENT
				/// </java-name>
				[Dot42.DexImport("MIN_EXPONENT", "I", AccessFlags = 25)]
				public const int MIN_EXPONENT = -1022;
				/// <summary>
				/// <para>The Class object that represents the primitive type <c>       double </c> .</para><para><para>1.1 </para></para>        
				/// </summary>
				/// <java-name>
				/// TYPE
				/// </java-name>
				[Dot42.DexImport("TYPE", "Ljava/lang/Class;", AccessFlags = 25)]
				public static readonly global::System.Type TYPE;
				/// <summary>
				/// <para>Constant for the number of bits needed to represent a <c> double </c> in two's complement form.</para><para><para>1.5 </para></para>        
				/// </summary>
				/// <java-name>
				/// SIZE
				/// </java-name>
				[Dot42.DexImport("SIZE", "I", AccessFlags = 25)]
				public const int SIZE = 64;
				/// <summary>
				/// <para>Constructs a new <c> Double </c> with the specified primitive double value.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(D)V", AccessFlags = 1)]
				public Double(double value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a new <c> Double </c> with the specified primitive double value.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public Double(string value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Compares this object to the specified double object to determine their relative order. There are two special cases: <ul><li><para><c> Double.NaN </c> is equal to <c> Double.NaN </c> and it is greater than any other double value, including <c> Double.POSITIVE_INFINITY </c> ; </para></li><li><para>+0.0d is greater than -0.0d </para></li></ul></para><para><para>java.lang.Comparable </para><para>1.2 </para></para>        
				/// </summary>
				/// <returns>
				/// <para>a negative value if the value of this double is less than the value of <c> object </c> ; 0 if the value of this double and the value of <c> object </c> are equal; a positive value if the value of this double is greater than the value of <c> object </c> . </para>
				/// </returns>
				/// <java-name>
				/// compareTo
				/// </java-name>
				[Dot42.DexImport("compareTo", "(Ljava/lang/Double;)I", AccessFlags = 1)]
				public int CompareTo(double? @object) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns this object's value as a byte. Might involve rounding and/or truncating the value, so it fits into a byte.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the primitive byte value of this object. </para>
				/// </returns>
				/// <java-name>
				/// byteValue
				/// </java-name>
				[Dot42.DexImport("byteValue", "()B", AccessFlags = 1)]
				public sbyte ByteValue() /* MethodBuilder.Create */ 
				{
						return default(sbyte);
				}

				/// <summary>
				/// <para>Returns an integer corresponding to the bits of the given  double precision <c> value </c> . All <b>Not-a-Number (NaN)</b> values are converted to a single NaN representation (<c> 0x7ff8000000000000L </c> ) (compare to doubleToRawLongBits). </para>        
				/// </summary>
				/// <java-name>
				/// doubleToLongBits
				/// </java-name>
				[Dot42.DexImport("doubleToLongBits", "(D)J", AccessFlags = 265)]
				public static long DoubleToLongBits(double value) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>Returns an integer corresponding to the bits of the given  double precision <c> value </c> . <b>Not-a-Number (NaN)</b> values are preserved (compare to doubleToLongBits). </para>        
				/// </summary>
				/// <java-name>
				/// doubleToRawLongBits
				/// </java-name>
				[Dot42.DexImport("doubleToRawLongBits", "(D)J", AccessFlags = 265)]
				public static long DoubleToRawLongBits(double value) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>Gets the primitive value of this double.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>this object's primitive value. </para>
				/// </returns>
				/// <java-name>
				/// doubleValue
				/// </java-name>
				[Dot42.DexImport("doubleValue", "()D", AccessFlags = 1)]
				public double DoubleValue() /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <summary>
				/// <para>Tests this double for equality with <c> object </c> . To be equal, <c> object </c> must be an instance of <c> Double </c> and <c> doubleToLongBits </c> must give the same value for both objects.</para><para>Note that, unlike <c> == </c> , <c> -0.0 </c> and <c> +0.0 </c> compare unequal, and <c> NaN </c> s compare equal by this method.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the specified object is equal to this <c> Double </c> ; <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public bool Equals(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns this object's value as a float. Might involve rounding.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the primitive float value of this object. </para>
				/// </returns>
				/// <java-name>
				/// floatValue
				/// </java-name>
				[Dot42.DexImport("floatValue", "()F", AccessFlags = 1)]
				public float FloatValue() /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 1)]
				public int GetHashCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns this object's value as an int. Might involve rounding and/or truncating the value, so it fits into an int.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the primitive int value of this object. </para>
				/// </returns>
				/// <java-name>
				/// intValue
				/// </java-name>
				[Dot42.DexImport("intValue", "()I", AccessFlags = 1)]
				public int IntValue() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Indicates whether this object represents an infinite value.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the value of this double is positive or negative infinity; <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isInfinite
				/// </java-name>
				[Dot42.DexImport("isInfinite", "()Z", AccessFlags = 1)]
				public bool IsInfinite() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Indicates whether the specified double represents an infinite value.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the value of <c> d </c> is positive or negative infinity; <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isInfinite
				/// </java-name>
				[Dot42.DexImport("isInfinite", "(D)Z", AccessFlags = 9)]
				public static bool IsInfinity(double d) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Indicates whether this object is a <b>Not-a-Number (NaN)</b> value.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if this double is <b>Not-a-Number</b>; <c> false </c> if it is a (potentially infinite) double number. </para>
				/// </returns>
				/// <java-name>
				/// isNaN
				/// </java-name>
				[Dot42.DexImport("isNaN", "()Z", AccessFlags = 1)]
				public bool IsNaN() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Indicates whether the specified double is a <b>Not-a-Number (NaN)</b> value.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if <c> d </c> is <b>Not-a-Number</b>; <c> false </c> if it is a (potentially infinite) double number. </para>
				/// </returns>
				/// <java-name>
				/// isNaN
				/// </java-name>
				[Dot42.DexImport("isNaN", "(D)Z", AccessFlags = 9)]
				public static bool IsNaN(double d) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns the  double precision float corresponding to the given <c> bits </c> . </para>        
				/// </summary>
				/// <java-name>
				/// longBitsToDouble
				/// </java-name>
				[Dot42.DexImport("longBitsToDouble", "(J)D", AccessFlags = 265)]
				public static double LongBitsToDouble(long bits) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <summary>
				/// <para>Returns this object's value as a long. Might involve rounding and/or truncating the value, so it fits into a long.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the primitive long value of this object. </para>
				/// </returns>
				/// <java-name>
				/// longValue
				/// </java-name>
				[Dot42.DexImport("longValue", "()J", AccessFlags = 1)]
				public long LongValue() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>Parses the specified string as a double value.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the primitive double value represented by <c> string </c> . </para>
				/// </returns>
				/// <java-name>
				/// parseDouble
				/// </java-name>
				[Dot42.DexImport("parseDouble", "(Ljava/lang/String;)D", AccessFlags = 9)]
				public static double Parse(string @string) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <summary>
				/// <para>Returns this object's value as a short. Might involve rounding and/or truncating the value, so it fits into a short.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the primitive short value of this object. </para>
				/// </returns>
				/// <java-name>
				/// shortValue
				/// </java-name>
				[Dot42.DexImport("shortValue", "()S", AccessFlags = 1)]
				public short ShortValue() /* MethodBuilder.Create */ 
				{
						return default(short);
				}

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns a string containing a concise, human-readable description of the specified double value.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a printable representation of <c> d </c> . </para>
				/// </returns>
				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "(D)Ljava/lang/String;", AccessFlags = 9)]
				public static string ToString(double d) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Parses the specified string as a double value.</para><para><para>parseDouble(String) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>a <c> Double </c> instance containing the double value represented by <c> string </c> . </para>
				/// </returns>
				/// <java-name>
				/// valueOf
				/// </java-name>
				[Dot42.DexImport("valueOf", "(Ljava/lang/String;)Ljava/lang/Double;", AccessFlags = 9)]
				public static double? ValueOf(string @string) /* MethodBuilder.Create */ 
				{
						return default(double?);
				}

				/// <summary>
				/// <para>Compares the two specified double values. There are two special cases: <ul><li><para><c> Double.NaN </c> is equal to <c> Double.NaN </c> and it is greater than any other double value, including <c> Double.POSITIVE_INFINITY </c> ; </para></li><li><para>+0.0d is greater than -0.0d </para></li></ul></para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a negative value if <c> double1 </c> is less than <c> double2 </c> ; 0 if <c> double1 </c> and <c> double2 </c> are equal; a positive value if <c> double1 </c> is greater than <c> double2 </c> . </para>
				/// </returns>
				/// <java-name>
				/// compare
				/// </java-name>
				[Dot42.DexImport("compare", "(DD)I", AccessFlags = 9)]
				public static int Compare(double double1, double double2) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Parses the specified string as a double value.</para><para><para>parseDouble(String) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>a <c> Double </c> instance containing the double value represented by <c> string </c> . </para>
				/// </returns>
				/// <java-name>
				/// valueOf
				/// </java-name>
				[Dot42.DexImport("valueOf", "(D)Ljava/lang/Double;", AccessFlags = 9)]
				public static double? ValueOf(double @string) /* MethodBuilder.Create */ 
				{
						return default(double?);
				}

				/// <summary>
				/// <para>Converts the specified double into its hexadecimal string representation.</para><para><para>1.5 </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the hexadecimal string representation of <c> d </c> . </para>
				/// </returns>
				/// <java-name>
				/// toHexString
				/// </java-name>
				[Dot42.DexImport("toHexString", "(D)Ljava/lang/String;", AccessFlags = 9)]
				public static string ToHexString(double d) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

		}

		/// <summary>
		/// <para>Thrown when the an invalid arithmetic operation is attempted. </para>    
		/// </summary>
		/// <java-name>
		/// java/lang/ArithmeticException
		/// </java-name>
		[Dot42.DexImport("java/lang/ArithmeticException", AccessFlags = 33)]
		public partial class ArithmeticException : global::System.SystemException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs a new <c> ArithmeticException </c> that includes the current stack trace. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ArithmeticException() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a new <c> ArithmeticException </c> with the current stack trace and the specified detail message.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public ArithmeticException(string detailMessage) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>This class provides methods that return pseudo-random values.</para><para>It is dangerous to seed <c> Random </c> with the current time because that value is more predictable to an attacker than the default seed.</para><para>This class is thread-safe.</para><para><para>java.security.SecureRandom </para></para>    
		/// </summary>
		/// <java-name>
		/// java/util/Random
		/// </java-name>
		[Dot42.DexImport("java/util/Random", AccessFlags = 33)]
		public partial class Random : global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs a random generator with an initial state that is unlikely to be duplicated by a subsequent instantiation.</para><para>The initial state (that is, the seed) is <b>partially</b> based on the current time of day in milliseconds. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Random() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Construct a random generator with the given <c> seed </c> as the initial state. Equivalent to <c> Random r = new Random(); r.setSeed(seed); </c> .</para><para>This constructor is mainly useful for <b>predictability</b> in tests. The default constructor is likely to provide better randomness. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(J)V", AccessFlags = 1)]
				public Random(long seed) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns a pseudo-random uniformly distributed <c> int </c> value of the number of bits specified by the argument <c> bits </c> as described by Donald E. Knuth in <b>The Art of Computer Programming, Volume 2: Seminumerical Algorithms</b>, section 3.2.1.</para><para>Most applications will want to use one of this class' convenience methods instead. </para>        
				/// </summary>
				/// <java-name>
				/// next
				/// </java-name>
				[Dot42.DexImport("next", "(I)I", AccessFlags = 36)]
				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal virtual int JavaNext(int bits) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns a pseudo-random uniformly distributed <c> boolean </c> . </para>        
				/// </summary>
				/// <java-name>
				/// nextBoolean
				/// </java-name>
				[Dot42.DexImport("nextBoolean", "()Z", AccessFlags = 1)]
				public virtual bool NextBoolean() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Fills <c> buf </c> with random bytes. </para>        
				/// </summary>
				/// <java-name>
				/// nextBytes
				/// </java-name>
				[Dot42.DexImport("nextBytes", "([B)V", AccessFlags = 1)]
				public virtual void NextBytes(sbyte[] buf) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Fills <c> buf </c> with random bytes. </para>        
				/// </summary>
				/// <java-name>
				/// nextBytes
				/// </java-name>
				[Dot42.DexImport("nextBytes", "([B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual void NextBytes(byte[] buf) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns a pseudo-random uniformly distributed <c> double </c> in the half-open range [0.0, 1.0). </para>        
				/// </summary>
				/// <java-name>
				/// nextDouble
				/// </java-name>
				[Dot42.DexImport("nextDouble", "()D", AccessFlags = 1)]
				public virtual double NextDouble() /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <summary>
				/// <para>Returns a pseudo-random uniformly distributed <c> float </c> in the half-open range [0.0, 1.0). </para>        
				/// </summary>
				/// <java-name>
				/// nextFloat
				/// </java-name>
				[Dot42.DexImport("nextFloat", "()F", AccessFlags = 1)]
				public virtual float NextFloat() /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				/// <para>Returns a pseudo-random (approximately) normally distributed <c> double </c> with mean 0.0 and standard deviation 1.0. This method uses the <b>polar method</b> of G. E. P. Box, M. E. Muller, and G. Marsaglia, as described by Donald E. Knuth in <b>The Art of Computer Programming, Volume 2: Seminumerical Algorithms</b>, section 3.4.1, subsection C, algorithm P. </para>        
				/// </summary>
				/// <java-name>
				/// nextGaussian
				/// </java-name>
				[Dot42.DexImport("nextGaussian", "()D", AccessFlags = 33)]
				public virtual double NextGaussian() /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <summary>
				/// <para>Returns a pseudo-random uniformly distributed <c> int </c> . </para>        
				/// </summary>
				/// <java-name>
				/// nextInt
				/// </java-name>
				[Dot42.DexImport("nextInt", "()I", AccessFlags = 1)]
				public virtual int NextInt() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns a pseudo-random uniformly distributed <c> int </c> in the half-open range [0, n). </para>        
				/// </summary>
				/// <java-name>
				/// nextInt
				/// </java-name>
				[Dot42.DexImport("nextInt", "(I)I", AccessFlags = 1)]
				public virtual int NextInt(int n) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns a pseudo-random uniformly distributed <c> long </c> . </para>        
				/// </summary>
				/// <java-name>
				/// nextLong
				/// </java-name>
				[Dot42.DexImport("nextLong", "()J", AccessFlags = 1)]
				public virtual long NextLong() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>Modifies the seed using a linear congruential formula presented in <b>The Art of Computer Programming, Volume 2</b>, Section 3.2.1. </para>        
				/// </summary>
				/// <java-name>
				/// setSeed
				/// </java-name>
				[Dot42.DexImport("setSeed", "(J)V", AccessFlags = 33)]
				public virtual void SetSeed(long seed) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>A Uniform Resource Identifier that identifies an abstract or physical resource, as specified by .</para><para><h3>Parts of a URI</h3></para><para>A URI is composed of many parts. This class can both parse URI strings into parts and compose URI strings from parts. For example, consider the parts of this URI: <c> http://username:password@host:8080/directory/file?query#fragment </c> <table><row><entry><para>Component </para></entry><entry><para>Example value </para></entry><entry><para>Also known as </para></entry></row><row><entry><para>Scheme </para></entry><entry><para><c> http </c> </para></entry><entry><para>protocol </para></entry></row><row><entry><para>Scheme-specific part</para></entry><entry><para><c> //username:password@host:8080/directory/file?query#fragment </c> </para></entry><entry><para></para></entry></row><row><entry><para>Authority </para></entry><entry><para><c> username:password@host:8080 </c> </para></entry><entry><para></para></entry></row><row><entry><para>User Info </para></entry><entry><para><c> username:password </c> </para></entry><entry><para></para></entry></row><row><entry><para>Host </para></entry><entry><para><c> host </c> </para></entry><entry><para></para></entry></row><row><entry><para>Port </para></entry><entry><para><c> 8080 </c> </para></entry><entry><para></para></entry></row><row><entry><para>Path </para></entry><entry><para><c> /directory/file </c> </para></entry><entry><para></para></entry></row><row><entry><para>Query </para></entry><entry><para><c> query </c> </para></entry><entry><para></para></entry></row><row><entry><para>Fragment </para></entry><entry><para><c> fragment </c> </para></entry><entry><para>ref </para></entry></row></table></para><para><h3>Absolute vs. Relative URIs</h3></para><para>URIs are either absolute or relative. <ul><li><para><b>Absolute:</b> <c> http://android.com/robots.txt </c> </para></li><li><para><b>Relative:</b> <c> robots.txt </c> </para></li></ul></para><para>Absolute URIs always have a scheme. If its scheme is supported by URL, you can use toURL to convert an absolute URI to a URL.</para><para>Relative URIs do not have a scheme and cannot be converted to URLs. If you have the absolute URI that a relative URI is relative to, you can use resolve to compute the referenced absolute URI. Symmetrically, you can use relativize to compute the relative URI from one URI to another. <pre>        URI absolute = new URI("http://android.com/");
		/// 
		///      URI relative = new URI("robots.txt");
		/// 
		///      URI resolved = new URI("http://android.com/robots.txt");
		/// 
		///   
		/// 
		///      // print "http://android.com/robots.txt"
		/// 
		///      System.out.println(absolute.resolve(relative));
		/// 
		///   
		/// 
		///      // print "robots.txt"
		/// 
		///      System.out.println(absolute.relativize(resolved));
		/// 
		///  </pre></para><para><h3>Opaque vs. Hierarchical URIs</h3></para><para>Absolute URIs are either opaque or hierarchical. Relative URIs are always hierarchical. <ul><li><para><b>Hierarchical:</b> <c> http://android.com/robots.txt </c> </para></li><li><para><b>Opaque:</b> <c> mailto:robots@example.com </c> </para></li></ul></para><para>Opaque URIs have both a scheme and a scheme-specific part that does not begin with the slash character: <c> / </c> . The contents of the scheme-specific part of an opaque URI is not parsed so an opaque URI never has an authority, user info, host, port, path or query. An opaque URIs may have a fragment, however. A typical opaque URI is <c> mailto:robots@example.com </c> . <table><row><entry><para>Component </para></entry><entry><para>Example value  </para></entry></row><row><entry><para>Scheme </para></entry><entry><para><c> mailto </c>  </para></entry></row><row><entry><para>Scheme-specific part</para></entry><entry><para><c> robots@example.com </c>  </para></entry></row><row><entry><para>Fragment </para></entry><entry><para></para></entry></row></table></para><para>Hierarchical URIs may have values for any URL component. They always have a non-null path, though that path may be the empty string.</para><para><h3>Encoding and Decoding URI Components</h3></para><para>Each component of a URI permits a limited set of legal characters. Other characters must first be <b>encoded</b> before they can be embedded in a URI. To recover the original characters from a URI, they may be <b>decoded</b>. <b>Contrary to what you might expect,</b> this class uses the term <b>raw</b> to refer to encoded strings. The non-<b>raw</b> accessors return decoded strings. For example, consider how this URI is decoded: <c> http://user:pa55w%3Frd@host:80/doc%7Csearch?q=green%20robots#over%206%22 </c> <table><row><entry><para>Component </para></entry><entry><para>Legal Characters </para></entry><entry><para>Other Constraints </para></entry><entry><para>Raw Value </para></entry><entry><para>Value </para></entry></row><row><entry><para>Scheme </para></entry><entry><para><c> 0-9 </c> , <c> a-z </c> , <c> A-Z </c> , <c> +-. </c> </para></entry><entry><para>First character must be in <c> a-z </c> , <c> A-Z </c> </para></entry><entry><para></para></entry><entry><para><c> http </c>  </para></entry></row><row><entry><para>Scheme-specific part</para></entry><entry><para><c> 0-9 </c> , <c> a-z </c> , <c> A-Z </c> , <c> _-!.~'()*,;:$&amp;+=?/[]@</c> </para></entry><entry><para>Non-ASCII characters okay </para></entry><entry><para><c> //user:pa55w%3Frd@host:80/doc%7Csearch?q=green%20robots </c> </para></entry><entry><para><c> //user:pa55w?rd@host:80/doc|search?q=green robots </c>  </para></entry></row><row><entry><para>Authority </para></entry><entry><para><c> 0-9 </c> , <c> a-z </c> , <c> A-Z </c> , <c> _-!.~'()*,;:$&amp;+=@[] </c> </para></entry><entry><para>Non-ASCII characters okay </para></entry><entry><para><c> user:pa55w%3Frd@host:80 </c> </para></entry><entry><para><c> user:pa55w?rd@host:80 </c>  </para></entry></row><row><entry><para>User Info </para></entry><entry><para><c> 0-9 </c> , <c> a-z </c> , <c> A-Z </c> , <c> _-!.~'()*,;:$&amp;+= </c> </para></entry><entry><para>Non-ASCII characters okay </para></entry><entry><para><c> user:pa55w%3Frd </c> </para></entry><entry><para><c> user:pa55w?rd </c>  </para></entry></row><row><entry><para>Host </para></entry><entry><para><c> 0-9 </c> , <c> a-z </c> , <c> A-Z </c> , <c> -.[] </c> </para></entry><entry><para>Domain name, IPv4 address or [IPv6 address] </para></entry><entry><para></para></entry><entry><para>host </para></entry></row><row><entry><para>Port </para></entry><entry><para><c> 0-9 </c> </para></entry><entry><para></para></entry><entry><para></para></entry><entry><para><c> 80 </c>  </para></entry></row><row><entry><para>Path </para></entry><entry><para><c> 0-9 </c> , <c> a-z </c> , <c> A-Z </c> , <c> _-!.~'()*,;:$&amp;+=/@</c> </para></entry><entry><para>Non-ASCII characters okay </para></entry><entry><para><c> /doc%7Csearch </c> </para></entry><entry><para><c> /doc|search </c>  </para></entry></row><row><entry><para>Query </para></entry><entry><para><c> 0-9 </c> , <c> a-z </c> , <c> A-Z </c> , <c> _-!.~'()*,;:$&amp;+=?/[]@</c> </para></entry><entry><para>Non-ASCII characters okay </para></entry><entry><para><c> q=green%20robots </c> </para></entry><entry><para><c> q=green robots </c>  </para></entry></row><row><entry><para>Fragment </para></entry><entry><para><c> 0-9 </c> , <c> a-z </c> , <c> A-Z </c> , <c> _-!.~'()*,;:$&amp;+=?/[]@</c> </para></entry><entry><para>Non-ASCII characters okay </para></entry><entry><para><c> over%206%22 </c> </para></entry><entry><para><c> over 6" </c>  </para></entry></row></table>A URI's host, port and scheme are not eligible for encoding and must not contain illegal characters.</para><para>To encode a URI, invoke any of the multiple-parameter constructors of this class. These constructors accept your original strings and encode them into their raw form.</para><para>To decode a URI, invoke the single-string constructor, and then use the appropriate accessor methods to get the decoded components.</para><para>The URL class can be used to retrieve resources by their URI. </para>    
		/// </summary>
		/// <java-name>
		/// java/net/URI
		/// </java-name>
		[Dot42.DexImport("java/net/URI", AccessFlags = 49, Signature = "Ljava/lang/Object;Ljava/lang/Comparable<Ljava/net/URI;>;Ljava/io/Serializable;")]
		public sealed partial class Uri : global::System.IComparable<global::System.Uri>, global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new URI instance by parsing <c> spec </c> .</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public Uri(string spec) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new URI instance of the given unencoded component parts.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public Uri(string scheme, string schemeSpecificPart, string fragment) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new URI instance of the given unencoded component parts.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;Ljava/l" +
    "ang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public Uri(string scheme, string userInfo, string host, int port, string path, string query, string fragment) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new URI instance of the given unencoded component parts.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public Uri(string scheme, string host, string path, string fragment) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new URI instance of the given unencoded component parts.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/la" +
    "ng/String;)V", AccessFlags = 1)]
				public Uri(string scheme, string authority, string path, string query, string fragment) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Compares this URI with the given argument <c> uri </c> . This method will return a negative value if this URI instance is less than the given argument and a positive value if this URI instance is greater than the given argument. The return value <c> 0 </c> indicates that the two instances represent the same URI. To define the order the single parts of the URI are compared with each other. String components will be ordered in the natural case-sensitive way. A hierarchical URI is less than an opaque URI and if one part is <c> null </c> the URI with the undefined part is less than the other one.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the value representing the order of the two instances. </para>
				/// </returns>
				/// <java-name>
				/// compareTo
				/// </java-name>
				[Dot42.DexImport("compareTo", "(Ljava/net/URI;)I", AccessFlags = 1)]
				public int CompareTo(global::System.Uri uri) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the URI formed by parsing <c> uri </c> . This method behaves identically to the string constructor but throws a different exception on failure. The constructor fails with a checked URISyntaxException; this method fails with an unchecked IllegalArgumentException. </para>        
				/// </summary>
				/// <java-name>
				/// create
				/// </java-name>
				[Dot42.DexImport("create", "(Ljava/lang/String;)Ljava/net/URI;", AccessFlags = 9)]
				public static global::System.Uri Create(string uri) /* MethodBuilder.Create */ 
				{
						return default(global::System.Uri);
				}

				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object o) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns the decoded authority part of this URI, or null if this URI has no authority. </para>        
				/// </summary>
				/// <java-name>
				/// getAuthority
				/// </java-name>
				[Dot42.DexImport("getAuthority", "()Ljava/lang/String;", AccessFlags = 1)]
				public string GetAuthority() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the decoded fragment of this URI, or null if this URI has no fragment. </para>        
				/// </summary>
				/// <java-name>
				/// getFragment
				/// </java-name>
				[Dot42.DexImport("getFragment", "()Ljava/lang/String;", AccessFlags = 1)]
				public string GetFragment() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the host of this URI, or null if this URI has no host. </para>        
				/// </summary>
				/// <java-name>
				/// getHost
				/// </java-name>
				[Dot42.DexImport("getHost", "()Ljava/lang/String;", AccessFlags = 1)]
				public string GetHost() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the decoded path of this URI, or null if this URI has no path. </para>        
				/// </summary>
				/// <java-name>
				/// getPath
				/// </java-name>
				[Dot42.DexImport("getPath", "()Ljava/lang/String;", AccessFlags = 1)]
				public string GetPath() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the port number of this URI, or <c> -1 </c> if this URI has no explicit port. </para>        
				/// </summary>
				/// <java-name>
				/// getPort
				/// </java-name>
				[Dot42.DexImport("getPort", "()I", AccessFlags = 1)]
				public int GetPort() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the decoded query of this URI, or null if this URI has no query. </para>        
				/// </summary>
				/// <java-name>
				/// getQuery
				/// </java-name>
				[Dot42.DexImport("getQuery", "()Ljava/lang/String;", AccessFlags = 1)]
				public string GetQuery() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the encoded authority of this URI, or null if this URI has no authority. </para>        
				/// </summary>
				/// <java-name>
				/// getRawAuthority
				/// </java-name>
				[Dot42.DexImport("getRawAuthority", "()Ljava/lang/String;", AccessFlags = 1)]
				public string GetRawAuthority() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Gets the encoded fragment of this URI, or null if this URI has no fragment. </para>        
				/// </summary>
				/// <java-name>
				/// getRawFragment
				/// </java-name>
				[Dot42.DexImport("getRawFragment", "()Ljava/lang/String;", AccessFlags = 1)]
				public string GetRawFragment() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the encoded path of this URI, or null if this URI has no path. </para>        
				/// </summary>
				/// <java-name>
				/// getRawPath
				/// </java-name>
				[Dot42.DexImport("getRawPath", "()Ljava/lang/String;", AccessFlags = 1)]
				public string GetRawPath() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the encoded query of this URI, or null if this URI has no query. </para>        
				/// </summary>
				/// <java-name>
				/// getRawQuery
				/// </java-name>
				[Dot42.DexImport("getRawQuery", "()Ljava/lang/String;", AccessFlags = 1)]
				public string GetRawQuery() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the encoded scheme-specific part of this URI, or null if this URI has no scheme-specific part. </para>        
				/// </summary>
				/// <java-name>
				/// getRawSchemeSpecificPart
				/// </java-name>
				[Dot42.DexImport("getRawSchemeSpecificPart", "()Ljava/lang/String;", AccessFlags = 1)]
				public string GetRawSchemeSpecificPart() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the encoded user info of this URI, or null if this URI has no user info. </para>        
				/// </summary>
				/// <java-name>
				/// getRawUserInfo
				/// </java-name>
				[Dot42.DexImport("getRawUserInfo", "()Ljava/lang/String;", AccessFlags = 1)]
				public string GetRawUserInfo() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the scheme of this URI, or null if this URI has no scheme. This is also known as the protocol. </para>        
				/// </summary>
				/// <java-name>
				/// getScheme
				/// </java-name>
				[Dot42.DexImport("getScheme", "()Ljava/lang/String;", AccessFlags = 1)]
				public string GetScheme() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the decoded scheme-specific part of this URI, or null if this URI has no scheme-specific part. </para>        
				/// </summary>
				/// <java-name>
				/// getSchemeSpecificPart
				/// </java-name>
				[Dot42.DexImport("getSchemeSpecificPart", "()Ljava/lang/String;", AccessFlags = 1)]
				public string GetSchemeSpecificPart() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the decoded user info of this URI, or null if this URI has no user info. </para>        
				/// </summary>
				/// <java-name>
				/// getUserInfo
				/// </java-name>
				[Dot42.DexImport("getUserInfo", "()Ljava/lang/String;", AccessFlags = 1)]
				public string GetUserInfo() /* MethodBuilder.Create */ 
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

				/// <summary>
				/// <para>Returns true if this URI is absolute, which means that a scheme is defined. </para>        
				/// </summary>
				/// <java-name>
				/// isAbsolute
				/// </java-name>
				[Dot42.DexImport("isAbsolute", "()Z", AccessFlags = 1)]
				public bool IsAbsolute() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns true if this URI is opaque. Opaque URIs are absolute and have a scheme-specific part that does not start with a slash character. All parts except scheme, scheme-specific and fragment are undefined. </para>        
				/// </summary>
				/// <java-name>
				/// isOpaque
				/// </java-name>
				[Dot42.DexImport("isOpaque", "()Z", AccessFlags = 1)]
				public bool IsOpaque() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Normalizes the path part of this URI.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an URI object which represents this instance with a normalized path. </para>
				/// </returns>
				/// <java-name>
				/// normalize
				/// </java-name>
				[Dot42.DexImport("normalize", "()Ljava/net/URI;", AccessFlags = 1)]
				public global::System.Uri Normalize() /* MethodBuilder.Create */ 
				{
						return default(global::System.Uri);
				}

				/// <summary>
				/// <para>Tries to parse the authority component of this URI to divide it into the host, port, and user-info. If this URI is already determined as a ServerAuthority this instance will be returned without changes.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>this instance with the components of the parsed server authority. </para>
				/// </returns>
				/// <java-name>
				/// parseServerAuthority
				/// </java-name>
				[Dot42.DexImport("parseServerAuthority", "()Ljava/net/URI;", AccessFlags = 1)]
				public global::System.Uri ParseServerAuthority() /* MethodBuilder.Create */ 
				{
						return default(global::System.Uri);
				}

				/// <summary>
				/// <para>Makes the given URI <c> relative </c> to a relative URI against the URI represented by this instance.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the relative URI. </para>
				/// </returns>
				/// <java-name>
				/// relativize
				/// </java-name>
				[Dot42.DexImport("relativize", "(Ljava/net/URI;)Ljava/net/URI;", AccessFlags = 1)]
				public global::System.Uri Relativize(global::System.Uri relative) /* MethodBuilder.Create */ 
				{
						return default(global::System.Uri);
				}

				/// <summary>
				/// <para>Resolves the given URI <c> relative </c> against the URI represented by this instance.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the resolved URI. </para>
				/// </returns>
				/// <java-name>
				/// resolve
				/// </java-name>
				[Dot42.DexImport("resolve", "(Ljava/net/URI;)Ljava/net/URI;", AccessFlags = 1)]
				public global::System.Uri Resolve(global::System.Uri relative) /* MethodBuilder.Create */ 
				{
						return default(global::System.Uri);
				}

				/// <summary>
				/// <para>Resolves the given URI <c> relative </c> against the URI represented by this instance.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the resolved URI. </para>
				/// </returns>
				/// <java-name>
				/// resolve
				/// </java-name>
				[Dot42.DexImport("resolve", "(Ljava/lang/String;)Ljava/net/URI;", AccessFlags = 1)]
				public global::System.Uri Resolve(string relative) /* MethodBuilder.Create */ 
				{
						return default(global::System.Uri);
				}

				/// <summary>
				/// <para>Returns the textual string representation of this URI instance using the US-ASCII encoding.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the US-ASCII string representation of this URI. </para>
				/// </returns>
				/// <java-name>
				/// toASCIIString
				/// </java-name>
				[Dot42.DexImport("toASCIIString", "()Ljava/lang/String;", AccessFlags = 1)]
				public string ToASCIIString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the encoded URI. </para>        
				/// </summary>
				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Converts this URI instance to a URL.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the created URL representing the same resource as this URI. </para>
				/// </returns>
				/// <java-name>
				/// toURL
				/// </java-name>
				[Dot42.DexImport("toURL", "()Ljava/net/URL;", AccessFlags = 1)]
				public global::Java.Net.URL ToURL() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.URL);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal Uri() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Returns the decoded authority part of this URI, or null if this URI has no authority. </para>        
				/// </summary>
				/// <java-name>
				/// getAuthority
				/// </java-name>
				public string Authority
				{
				[Dot42.DexImport("getAuthority", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetAuthority(); }
				}

				/// <summary>
				/// <para>Returns the decoded fragment of this URI, or null if this URI has no fragment. </para>        
				/// </summary>
				/// <java-name>
				/// getFragment
				/// </java-name>
				public string Fragment
				{
				[Dot42.DexImport("getFragment", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetFragment(); }
				}

				/// <summary>
				/// <para>Returns the host of this URI, or null if this URI has no host. </para>        
				/// </summary>
				/// <java-name>
				/// getHost
				/// </java-name>
				public string Host
				{
				[Dot42.DexImport("getHost", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetHost(); }
				}

				/// <summary>
				/// <para>Returns the decoded path of this URI, or null if this URI has no path. </para>        
				/// </summary>
				/// <java-name>
				/// getPath
				/// </java-name>
				public string AbsolutePath
				{
				[Dot42.DexImport("getPath", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetPath(); }
				}

				/// <summary>
				/// <para>Returns the port number of this URI, or <c> -1 </c> if this URI has no explicit port. </para>        
				/// </summary>
				/// <java-name>
				/// getPort
				/// </java-name>
				public int Port
				{
				[Dot42.DexImport("getPort", "()I", AccessFlags = 1)]
						get{ return GetPort(); }
				}

				/// <summary>
				/// <para>Returns the decoded query of this URI, or null if this URI has no query. </para>        
				/// </summary>
				/// <java-name>
				/// getQuery
				/// </java-name>
				public string Query
				{
				[Dot42.DexImport("getQuery", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetQuery(); }
				}

				/// <summary>
				/// <para>Returns the encoded authority of this URI, or null if this URI has no authority. </para>        
				/// </summary>
				/// <java-name>
				/// getRawAuthority
				/// </java-name>
				public string RawAuthority
				{
				[Dot42.DexImport("getRawAuthority", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetRawAuthority(); }
				}

				/// <summary>
				/// <para>Gets the encoded fragment of this URI, or null if this URI has no fragment. </para>        
				/// </summary>
				/// <java-name>
				/// getRawFragment
				/// </java-name>
				public string RawFragment
				{
				[Dot42.DexImport("getRawFragment", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetRawFragment(); }
				}

				/// <summary>
				/// <para>Returns the encoded path of this URI, or null if this URI has no path. </para>        
				/// </summary>
				/// <java-name>
				/// getRawPath
				/// </java-name>
				public string RawPath
				{
				[Dot42.DexImport("getRawPath", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetRawPath(); }
				}

				/// <summary>
				/// <para>Returns the encoded query of this URI, or null if this URI has no query. </para>        
				/// </summary>
				/// <java-name>
				/// getRawQuery
				/// </java-name>
				public string RawQuery
				{
				[Dot42.DexImport("getRawQuery", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetRawQuery(); }
				}

				/// <summary>
				/// <para>Returns the encoded scheme-specific part of this URI, or null if this URI has no scheme-specific part. </para>        
				/// </summary>
				/// <java-name>
				/// getRawSchemeSpecificPart
				/// </java-name>
				public string RawSchemeSpecificPart
				{
				[Dot42.DexImport("getRawSchemeSpecificPart", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetRawSchemeSpecificPart(); }
				}

				/// <summary>
				/// <para>Returns the encoded user info of this URI, or null if this URI has no user info. </para>        
				/// </summary>
				/// <java-name>
				/// getRawUserInfo
				/// </java-name>
				public string RawUserInfo
				{
				[Dot42.DexImport("getRawUserInfo", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetRawUserInfo(); }
				}

				/// <summary>
				/// <para>Returns the scheme of this URI, or null if this URI has no scheme. This is also known as the protocol. </para>        
				/// </summary>
				/// <java-name>
				/// getScheme
				/// </java-name>
				public string Scheme
				{
				[Dot42.DexImport("getScheme", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetScheme(); }
				}

				/// <summary>
				/// <para>Returns the decoded scheme-specific part of this URI, or null if this URI has no scheme-specific part. </para>        
				/// </summary>
				/// <java-name>
				/// getSchemeSpecificPart
				/// </java-name>
				public string SchemeSpecificPart
				{
				[Dot42.DexImport("getSchemeSpecificPart", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetSchemeSpecificPart(); }
				}

				/// <summary>
				/// <para>Returns the decoded user info of this URI, or null if this URI has no user info. </para>        
				/// </summary>
				/// <java-name>
				/// getUserInfo
				/// </java-name>
				public string UserInfo
				{
				[Dot42.DexImport("getUserInfo", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetUserInfo(); }
				}

		}

}


