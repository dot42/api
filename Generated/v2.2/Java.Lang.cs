#pragma warning disable 1717
namespace Java.Lang
{
		/// <summary>
		///  <para>Thrown by the VM when an abstract method is called. </para> <para>Note that this can only occur when inconsistent class files have been loaded, since invoking an abstract method is a compile time error. </para>    
		/// </summary>
		/// <java-name>
		/// java/lang/AbstractMethodError
		/// </java-name>
		[Dot42.DexImport("java/lang/AbstractMethodError", AccessFlags = 33)]
		public partial class AbstractMethodError : global::Java.Lang.IncompatibleClassChangeError
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructs a new <c>AbstractMethodError </c> that includes the current stack trace. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public AbstractMethodError() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new <c>AbstractMethodError </c> with the current stack trace and the specified detail message.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public AbstractMethodError(string detailMessage) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>A modifiable sequence of characters for use in creating and modifying Strings. This class is intended as a base class for StringBuffer and StringBuilder.</para> <para> <para>StringBuffer </para> <para>StringBuilder </para> <para>1.5 </para></para>    
		/// </summary>
		/// <java-name>
		/// java/lang/AbstractStringBuilder
		/// </java-name>
		[Dot42.DexImport("java/lang/AbstractStringBuilder", AccessFlags = 1056)]
		internal abstract partial class AbstractStringBuilder
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal AbstractStringBuilder() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns the number of characters that can be held without growing.</para> <para> <para>#ensureCapacity </para> <para>#length </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the capacity </para>
				/// </returns>
				/// <java-name>
				/// capacity
				/// </java-name>
				[Dot42.DexImport("capacity", "()I", AccessFlags = 1)]
				public virtual int Capacity() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Retrieves the character at the <c>index </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the char value. </para>
				/// </returns>
				/// <java-name>
				/// charAt
				/// </java-name>
				[Dot42.DexImport("charAt", "(I)C", AccessFlags = 1)]
				public virtual char CharAt(int index) /* MethodBuilder.Create */ 
				{
						return default(char);
				}

				/// <summary>
				///  <para>Ensures that this object has a minimum capacity available before requiring the internal buffer to be enlarged. The general policy of this method is that if the <c>minimumCapacity </c> is larger than the current capacity(), then the capacity will be increased to the largest value of either the <c>minimumCapacity </c> or the current capacity multiplied by two plus two. Although this is the general policy, there is no guarantee that the capacity will change.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// ensureCapacity
				/// </java-name>
				[Dot42.DexImport("ensureCapacity", "(I)V", AccessFlags = 1)]
				public virtual void EnsureCapacity(int min) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Copies the requested sequence of characters into <c>dst </c> passed starting at <c>dst </c> .</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// getChars
				/// </java-name>
				[Dot42.DexImport("getChars", "(II[CI)V", AccessFlags = 1)]
				public virtual void GetChars(int start, int end, char[] dst, int dstStart) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>The current length.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the number of characters contained in this instance. </para>
				/// </returns>
				/// <java-name>
				/// length
				/// </java-name>
				[Dot42.DexImport("length", "()I", AccessFlags = 1)]
				public virtual int Length() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Sets the character at the <c>index </c> .</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setCharAt
				/// </java-name>
				[Dot42.DexImport("setCharAt", "(IC)V", AccessFlags = 1)]
				public virtual void SetCharAt(int index, char ch) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the current length to a new value. If the new length is larger than the current length, then the new characters at the end of this object will contain the <c>char </c> value of <c>\u0000 </c> .</para> <para> <para>#length </para></para>        
				/// </summary>
				/// <java-name>
				/// setLength
				/// </java-name>
				[Dot42.DexImport("setLength", "(I)V", AccessFlags = 1)]
				public virtual void SetLength(int length) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns the String value of the subsequence from the <c>start </c> index to the current end.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a String containing the subsequence. </para>
				/// </returns>
				/// <java-name>
				/// substring
				/// </java-name>
				[Dot42.DexImport("substring", "(I)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string Substring(int start) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Returns the String value of the subsequence from the <c>start </c> index to the <c>end </c> index.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a String containing the subsequence. </para>
				/// </returns>
				/// <java-name>
				/// substring
				/// </java-name>
				[Dot42.DexImport("substring", "(II)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string Substring(int start, int end) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Returns the current String representation.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a String containing the characters in this instance. </para>
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
				///  <para>Returns a <c>CharSequence </c> of the subsequence from the <c>start </c> index to the <c>end </c> index.</para> <para> <para>1.4 </para></para>        
				/// </summary>
				/// <returns>
				///  <para>a CharSequence containing the subsequence. </para>
				/// </returns>
				/// <java-name>
				/// subSequence
				/// </java-name>
				[Dot42.DexImport("subSequence", "(II)Ljava/lang/CharSequence;", AccessFlags = 1)]
				public virtual global::Java.Lang.ICharSequence SubSequence(int start, int end) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <summary>
				///  <para>Searches for the first index of the specified character. The search for the character starts at the beginning and moves towards the end.</para> <para> <para>#lastIndexOf(String) </para> <para>1.4 </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the index of the specified character, -1 if the character isn't found. </para>
				/// </returns>
				/// <java-name>
				/// indexOf
				/// </java-name>
				[Dot42.DexImport("indexOf", "(Ljava/lang/String;)I", AccessFlags = 1)]
				public virtual int IndexOf(string @string) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Searches for the index of the specified character. The search for the character starts at the specified offset and moves towards the end.</para> <para> <para>#lastIndexOf(String,int) </para> <para>1.4 </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the index of the specified character, -1 if the character isn't found </para>
				/// </returns>
				/// <java-name>
				/// indexOf
				/// </java-name>
				[Dot42.DexImport("indexOf", "(Ljava/lang/String;I)I", AccessFlags = 1)]
				public virtual int IndexOf(string subString, int start) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Searches for the last index of the specified character. The search for the character starts at the end and moves towards the beginning.</para> <para> <para>String::lastIndexOf(java.lang.String) </para> <para>1.4 </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the index of the specified character, -1 if the character isn't found. </para>
				/// </returns>
				/// <java-name>
				/// lastIndexOf
				/// </java-name>
				[Dot42.DexImport("lastIndexOf", "(Ljava/lang/String;)I", AccessFlags = 1)]
				public virtual int LastIndexOf(string @string) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Searches for the index of the specified character. The search for the character starts at the specified offset and moves towards the beginning.</para> <para> <para>String::lastIndexOf(String,int) </para> <para>1.4 </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the index of the specified character, -1 if the character isn't found. </para>
				/// </returns>
				/// <java-name>
				/// lastIndexOf
				/// </java-name>
				[Dot42.DexImport("lastIndexOf", "(Ljava/lang/String;I)I", AccessFlags = 1)]
				public virtual int LastIndexOf(string subString, int start) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Trims off any extra capacity beyond the current length. Note, this method is NOT guaranteed to change the capacity of this object.</para> <para> <para>1.5 </para></para>        
				/// </summary>
				/// <java-name>
				/// trimToSize
				/// </java-name>
				[Dot42.DexImport("trimToSize", "()V", AccessFlags = 1)]
				public virtual void TrimToSize() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Retrieves the Unicode code point value at the <c>index </c> .</para> <para> <para>Character </para> <para>Character::codePointAt(char[], int, int) </para> <para>1.5 </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the Unicode code point value. </para>
				/// </returns>
				/// <java-name>
				/// codePointAt
				/// </java-name>
				[Dot42.DexImport("codePointAt", "(I)I", AccessFlags = 1)]
				public virtual int CodePointAt(int index) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Retrieves the Unicode code point value that precedes the <c>index </c> .</para> <para> <para>Character </para> <para>Character::codePointBefore(char[], int, int) </para> <para>1.5 </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the Unicode code point value. </para>
				/// </returns>
				/// <java-name>
				/// codePointBefore
				/// </java-name>
				[Dot42.DexImport("codePointBefore", "(I)I", AccessFlags = 1)]
				public virtual int CodePointBefore(int index) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Calculates the number of Unicode code points between <c>start </c> and <c>end </c> .</para> <para> <para>Character </para> <para>Character::codePointCount(char[], int, int) </para> <para>1.5 </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the number of Unicode code points in the subsequence. </para>
				/// </returns>
				/// <java-name>
				/// codePointCount
				/// </java-name>
				[Dot42.DexImport("codePointCount", "(II)I", AccessFlags = 1)]
				public virtual int CodePointCount(int start, int end) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Returns the index that is offset <c>codePointOffset </c> code points from  <c>index </c> .</para> <para> <para>Character </para> <para>Character::offsetByCodePoints(char[], int, int, int, int) </para> <para>1.5 </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the index that is <c>codePointOffset </c> code points away from index. </para>
				/// </returns>
				/// <java-name>
				/// offsetByCodePoints
				/// </java-name>
				[Dot42.DexImport("offsetByCodePoints", "(II)I", AccessFlags = 1)]
				public virtual int OffsetByCodePoints(int index, int codePointOffset) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

		}

		/// <summary>
		///  <para>Thrown when the an array is indexed with a value less than zero, or greater than or equal to the size of the array. </para>    
		/// </summary>
		/// <java-name>
		/// java/lang/ArrayIndexOutOfBoundsException
		/// </java-name>
		[Dot42.DexImport("java/lang/ArrayIndexOutOfBoundsException", AccessFlags = 33)]
		public partial class ArrayIndexOutOfBoundsException : global::System.IndexOutOfRangeException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructs a new <c>ArrayIndexOutOfBoundsException </c> that includes the current stack trace. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ArrayIndexOutOfBoundsException() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new <c>ArrayIndexOutOfBoundsException </c> with the current stack trace and a detail message that is based on the specified invalid  <c>index </c> .</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public ArrayIndexOutOfBoundsException(int index) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new <c>ArrayIndexOutOfBoundsException </c> with the current stack trace and a detail message that is based on the specified invalid  <c>index </c> .</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public ArrayIndexOutOfBoundsException(string index) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>Thrown when an assertion has failed.</para> <para> <para>1.4 </para></para>    
		/// </summary>
		/// <java-name>
		/// java/lang/AssertionError
		/// </java-name>
		[Dot42.DexImport("java/lang/AssertionError", AccessFlags = 33)]
		public partial class AssertionError : global::Java.Lang.Error
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructs a new <c>AssertionError </c> with no message. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public AssertionError() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new <c>AssertionError </c> with a message based on calling String#valueOf(Object) with the specified object. If the object is an instance of Throwable, then it also becomes the cause of this error.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/Object;)V", AccessFlags = 1)]
				public AssertionError(object detailMessage) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new <c>AssertionError </c> with a message based on calling String#valueOf(Object) with the specified object. If the object is an instance of Throwable, then it also becomes the cause of this error.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Z)V", AccessFlags = 1)]
				public AssertionError(bool detailMessage) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new <c>AssertionError </c> with a message based on calling String#valueOf(Object) with the specified object. If the object is an instance of Throwable, then it also becomes the cause of this error.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(C)V", AccessFlags = 1)]
				public AssertionError(char detailMessage) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new <c>AssertionError </c> with a message based on calling String#valueOf(Object) with the specified object. If the object is an instance of Throwable, then it also becomes the cause of this error.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public AssertionError(int detailMessage) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new <c>AssertionError </c> with a message based on calling String#valueOf(Object) with the specified object. If the object is an instance of Throwable, then it also becomes the cause of this error.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(J)V", AccessFlags = 1)]
				public AssertionError(long detailMessage) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new <c>AssertionError </c> with a message based on calling String#valueOf(Object) with the specified object. If the object is an instance of Throwable, then it also becomes the cause of this error.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(F)V", AccessFlags = 1)]
				public AssertionError(float detailMessage) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new <c>AssertionError </c> with a message based on calling String#valueOf(Object) with the specified object. If the object is an instance of Throwable, then it also becomes the cause of this error.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(D)V", AccessFlags = 1)]
				public AssertionError(double detailMessage) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>Thrown when the VM notices that an attempt is made to load a class which would directly or indirectly inherit from one of its subclasses. </para> <para>Note that this error can only occur when inconsistent class files are loaded, since it would normally be detected at compile time. </para>    
		/// </summary>
		/// <java-name>
		/// java/lang/ClassCircularityError
		/// </java-name>
		[Dot42.DexImport("java/lang/ClassCircularityError", AccessFlags = 33)]
		public partial class ClassCircularityError : global::Java.Lang.LinkageError
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructs a new <c>ClassCircularityError </c> that include the current stack trace. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ClassCircularityError() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new <c>ClassCircularityError </c> with the current stack trace and the specified detail message.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public ClassCircularityError(string detailMessage) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>Thrown by a class loader when a class file has an illegal format or if the data that it contains can not be interpreted as a class. </para>    
		/// </summary>
		/// <java-name>
		/// java/lang/ClassFormatError
		/// </java-name>
		[Dot42.DexImport("java/lang/ClassFormatError", AccessFlags = 33)]
		public partial class ClassFormatError : global::Java.Lang.LinkageError
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructs a new <c>ClassFormatError </c> that includes the current stack trace. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ClassFormatError() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new <c>ClassFormatError </c> with the current stack trace and the specified detail message.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public ClassFormatError(string detailMessage) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>Loads classes and resources from a repository. One or more class loaders are installed at runtime. These are consulted whenever the runtime system needs a specific class that is not yet available in-memory. Typically, class loaders are grouped into a tree where child class loaders delegate all requests to parent class loaders. Only if the parent class loader cannot satisfy the request, the child class loader itself tries to handle it. </para> <para> <c>ClassLoader </c> is an abstract class that implements the common infrastructure required by all class loaders. Android provides several concrete implementations of the class, with dalvik.system.PathClassLoader being the one typically used. Other applications may implement subclasses of <c>ClassLoader </c> to provide special ways for loading classes. </para> <para> <para>Class </para></para>    
		/// </summary>
		/// <java-name>
		/// java/lang/ClassLoader
		/// </java-name>
		[Dot42.DexImport("java/lang/ClassLoader", AccessFlags = 1057)]
		public abstract partial class ClassLoader
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructs a new instance of this class with the system class loader as its parent. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal ClassLoader() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new instance of this class with the specified class loader as its parent.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/ClassLoader;)V", AccessFlags = 4)]
				protected internal ClassLoader(global::Java.Lang.ClassLoader parentLoader) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Finds the URL of the resource with the specified name. The system class loader's resource lookup algorithm is used to find the resource.</para> <para> <para>Class::getResource </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the <c>URL </c> object for the requested resource or <c>null </c> if the resource can not be found. </para>
				/// </returns>
				/// <java-name>
				/// getSystemResource
				/// </java-name>
				[Dot42.DexImport("getSystemResource", "(Ljava/lang/String;)Ljava/net/URL;", AccessFlags = 9)]
				public static global::Java.Net.URL GetSystemResource(string resName) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.URL);
				}

				/// <summary>
				///  <para>Returns an enumeration of URLs for the resource with the specified name. The system class loader's resource lookup algorithm is used to find the resource.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>an enumeration of <c>URL </c> objects containing the requested resources. </para>
				/// </returns>
				/// <java-name>
				/// getSystemResources
				/// </java-name>
				[Dot42.DexImport("getSystemResources", "(Ljava/lang/String;)Ljava/util/Enumeration;", AccessFlags = 9, Signature = "(Ljava/lang/String;)Ljava/util/Enumeration<Ljava/net/URL;>;")]
				public static global::Java.Util.IEnumeration<global::Java.Net.URL> GetSystemResources(string resName) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IEnumeration<global::Java.Net.URL>);
				}

				/// <summary>
				///  <para>Returns a stream for the resource with the specified name. The system class loader's resource lookup algorithm is used to find the resource. Basically, the contents of the java.class.path are searched in order, looking for a path which matches the specified resource.</para> <para> <para>Class::getResourceAsStream </para></para>        
				/// </summary>
				/// <returns>
				///  <para>a stream for the resource or <c>null </c> . </para>
				/// </returns>
				/// <java-name>
				/// getSystemResourceAsStream
				/// </java-name>
				[Dot42.DexImport("getSystemResourceAsStream", "(Ljava/lang/String;)Ljava/io/InputStream;", AccessFlags = 9)]
				public static global::Java.IO.InputStream GetSystemResourceAsStream(string resName) /* MethodBuilder.Create */ 
				{
						return default(global::Java.IO.InputStream);
				}

				/// <summary>
				///  <para>Constructs a new class from an array of bytes containing a class definition in class file format.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use defineClass(String, byte[], int, int) instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				///  <para>the <c>Class </c> object created from the specified subset of data in <c>classRep </c> . </para>
				/// </returns>
				/// <java-name>
				/// defineClass
				/// </java-name>
				[Dot42.DexImport("defineClass", "([BII)Ljava/lang/Class;", AccessFlags = 20, IgnoreFromJava = true, Signature = "([BII)Ljava/lang/Class<*>;")]
				protected internal global::System.Type DefineClass(sbyte[] classRep, int offset, int length) /* MethodBuilder.Create */ 
				{
						return default(global::System.Type);
				}

				/// <summary>
				///  <para>Constructs a new class from an array of bytes containing a class definition in class file format.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use defineClass(String, byte[], int, int) instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				///  <para>the <c>Class </c> object created from the specified subset of data in <c>classRep </c> . </para>
				/// </returns>
				/// <java-name>
				/// defineClass
				/// </java-name>
				[Dot42.DexImport("defineClass", "([BII)Ljava/lang/Class;", AccessFlags = 20, Signature = "([BII)Ljava/lang/Class<*>;")]
				protected internal global::System.Type DefineClass(byte[] classRep, int offset, int length) /* MethodBuilder.Create */ 
				{
						return default(global::System.Type);
				}

				/// <summary>
				///  <para>Constructs a new class from an array of bytes containing a class definition in class file format.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the <c>Class </c> object created from the specified subset of data in <c>classRep </c> . </para>
				/// </returns>
				/// <java-name>
				/// defineClass
				/// </java-name>
				[Dot42.DexImport("defineClass", "(Ljava/lang/String;[BII)Ljava/lang/Class;", AccessFlags = 20, IgnoreFromJava = true, Signature = "(Ljava/lang/String;[BII)Ljava/lang/Class<*>;")]
				protected internal global::System.Type DefineClass(string className, sbyte[] classRep, int offset, int length) /* MethodBuilder.Create */ 
				{
						return default(global::System.Type);
				}

				/// <summary>
				///  <para>Constructs a new class from an array of bytes containing a class definition in class file format.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the <c>Class </c> object created from the specified subset of data in <c>classRep </c> . </para>
				/// </returns>
				/// <java-name>
				/// defineClass
				/// </java-name>
				[Dot42.DexImport("defineClass", "(Ljava/lang/String;[BII)Ljava/lang/Class;", AccessFlags = 20, Signature = "(Ljava/lang/String;[BII)Ljava/lang/Class<*>;")]
				protected internal global::System.Type DefineClass(string className, byte[] classRep, int offset, int length) /* MethodBuilder.Create */ 
				{
						return default(global::System.Type);
				}

				/// <summary>
				///  <para>Constructs a new class from an array of bytes containing a class definition in class file format and assigns the specified protection domain to the new class. If the provided protection domain is  <c>null </c> then a default protection domain is assigned to the class.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the <c>Class </c> object created from the specified subset of data in <c>classRep </c> . </para>
				/// </returns>
				/// <java-name>
				/// defineClass
				/// </java-name>
				[Dot42.DexImport("defineClass", "(Ljava/lang/String;[BIILjava/security/ProtectionDomain;)Ljava/lang/Class;", AccessFlags = 20, IgnoreFromJava = true, Signature = "(Ljava/lang/String;[BIILjava/security/ProtectionDomain;)Ljava/lang/Class<*>;")]
				protected internal global::System.Type DefineClass(string className, sbyte[] classRep, int offset, int length, global::Java.Security.ProtectionDomain protectionDomain) /* MethodBuilder.Create */ 
				{
						return default(global::System.Type);
				}

				/// <summary>
				///  <para>Constructs a new class from an array of bytes containing a class definition in class file format and assigns the specified protection domain to the new class. If the provided protection domain is  <c>null </c> then a default protection domain is assigned to the class.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the <c>Class </c> object created from the specified subset of data in <c>classRep </c> . </para>
				/// </returns>
				/// <java-name>
				/// defineClass
				/// </java-name>
				[Dot42.DexImport("defineClass", "(Ljava/lang/String;[BIILjava/security/ProtectionDomain;)Ljava/lang/Class;", AccessFlags = 20, Signature = "(Ljava/lang/String;[BIILjava/security/ProtectionDomain;)Ljava/lang/Class<*>;")]
				protected internal global::System.Type DefineClass(string className, byte[] classRep, int offset, int length, global::Java.Security.ProtectionDomain protectionDomain) /* MethodBuilder.Create */ 
				{
						return default(global::System.Type);
				}

				/// <summary>
				///  <para>Constructs a new class from an array of bytes containing a class definition in class file format.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use defineClass(String, byte[], int, int) instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				///  <para>the <c>Class </c> object created from the specified subset of data in <c>classRep </c> . </para>
				/// </returns>
				/// <java-name>
				/// defineClass
				/// </java-name>
				[Dot42.DexImport("defineClass", "(Ljava/lang/String;Ljava/nio/ByteBuffer;Ljava/security/ProtectionDomain;)Ljava/la" +
    "ng/Class;", AccessFlags = 20, Signature = "(Ljava/lang/String;Ljava/nio/ByteBuffer;Ljava/security/ProtectionDomain;)Ljava/la" +
    "ng/Class<*>;")]
				protected internal global::System.Type DefineClass(string classRep, global::Java.Nio.ByteBuffer offset, global::Java.Security.ProtectionDomain length) /* MethodBuilder.Create */ 
				{
						return default(global::System.Type);
				}

				/// <summary>
				///  <para>Overridden by subclasses, throws a <c>ClassNotFoundException </c> by default. This method is called by <c>loadClass </c> after the parent  <c>ClassLoader </c> has failed to find a loaded class of the same name.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the <c>Class </c> object that is found. </para>
				/// </returns>
				/// <java-name>
				/// findClass
				/// </java-name>
				[Dot42.DexImport("findClass", "(Ljava/lang/String;)Ljava/lang/Class;", AccessFlags = 4, Signature = "(Ljava/lang/String;)Ljava/lang/Class<*>;")]
				protected internal virtual global::System.Type FindClass(string className) /* MethodBuilder.Create */ 
				{
						return default(global::System.Type);
				}

				/// <summary>
				///  <para>Returns the class with the specified name if it has already been loaded by the VM or <c>null </c> if it has not yet been loaded.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the <c>Class </c> object or <c>null </c> if the requested class has not been loaded. </para>
				/// </returns>
				/// <java-name>
				/// findLoadedClass
				/// </java-name>
				[Dot42.DexImport("findLoadedClass", "(Ljava/lang/String;)Ljava/lang/Class;", AccessFlags = 20, Signature = "(Ljava/lang/String;)Ljava/lang/Class<*>;")]
				protected internal global::System.Type FindLoadedClass(string className) /* MethodBuilder.Create */ 
				{
						return default(global::System.Type);
				}

				/// <summary>
				///  <para>Finds the class with the specified name, loading it using the system class loader if necessary.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the <c>Class </c> object with the requested <c>className </c> . </para>
				/// </returns>
				/// <java-name>
				/// findSystemClass
				/// </java-name>
				[Dot42.DexImport("findSystemClass", "(Ljava/lang/String;)Ljava/lang/Class;", AccessFlags = 20, Signature = "(Ljava/lang/String;)Ljava/lang/Class<*>;")]
				protected internal global::System.Type FindSystemClass(string className) /* MethodBuilder.Create */ 
				{
						return default(global::System.Type);
				}

				/// <summary>
				///  <para>Returns the URL of the resource with the specified name. This implementation first tries to use the parent class loader to find the resource; if this fails then findResource(String) is called to find the requested resource.</para> <para> <para>Class::getResource </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the <c>URL </c> object for the requested resource or <c>null </c> if the resource can not be found </para>
				/// </returns>
				/// <java-name>
				/// getResource
				/// </java-name>
				[Dot42.DexImport("getResource", "(Ljava/lang/String;)Ljava/net/URL;", AccessFlags = 1)]
				public virtual global::Java.Net.URL GetResource(string resName) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.URL);
				}

				/// <summary>
				///  <para>Returns an enumeration of URLs for the resource with the specified name. This implementation first uses this class loader's parent to find the resource, then it calls findResources(String) to get additional URLs. The returned enumeration contains the <c>URL </c> objects of both find operations.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>an enumeration of <c>URL </c> objects for the requested resource. </para>
				/// </returns>
				/// <java-name>
				/// getResources
				/// </java-name>
				[Dot42.DexImport("getResources", "(Ljava/lang/String;)Ljava/util/Enumeration;", AccessFlags = 1, Signature = "(Ljava/lang/String;)Ljava/util/Enumeration<Ljava/net/URL;>;")]
				public virtual global::Java.Util.IEnumeration<global::Java.Net.URL> GetResources(string resName) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IEnumeration<global::Java.Net.URL>);
				}

				/// <summary>
				///  <para>Returns a stream for the resource with the specified name. See getResource(String) for a description of the lookup algorithm used to find the resource.</para> <para> <para>Class::getResourceAsStream </para></para>        
				/// </summary>
				/// <returns>
				///  <para>a stream for the resource or <c>null </c> if the resource can not be found </para>
				/// </returns>
				/// <java-name>
				/// getResourceAsStream
				/// </java-name>
				[Dot42.DexImport("getResourceAsStream", "(Ljava/lang/String;)Ljava/io/InputStream;", AccessFlags = 1)]
				public virtual global::Java.IO.InputStream GetResourceAsStream(string resName) /* MethodBuilder.Create */ 
				{
						return default(global::Java.IO.InputStream);
				}

				/// <summary>
				///  <para>Loads the class with the specified name. Invoking this method is equivalent to calling <c>loadClass(className, false) </c> . </para> <para> <b>Note:</b> In the Android reference implementation, the second parameter of loadClass(String, boolean) is ignored anyway. </para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the <c>Class </c> object. </para>
				/// </returns>
				/// <java-name>
				/// loadClass
				/// </java-name>
				[Dot42.DexImport("loadClass", "(Ljava/lang/String;)Ljava/lang/Class;", AccessFlags = 1, Signature = "(Ljava/lang/String;)Ljava/lang/Class<*>;")]
				public virtual global::System.Type LoadClass(string className) /* MethodBuilder.Create */ 
				{
						return default(global::System.Type);
				}

				/// <summary>
				///  <para>Loads the class with the specified name, optionally linking it after loading. The following steps are performed:  <ol> <li> <para>Call findLoadedClass(String) to determine if the requested class has already been loaded. </para></li> <li> <para>If the class has not yet been loaded: Invoke this method on the parent class loader. </para></li> <li> <para>If the class has still not been loaded: Call findClass(String) to find the class. </para></li></ol></para> <para> <b>Note:</b> In the Android reference implementation, the  <c>resolve </c> parameter is ignored; classes are never linked. </para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the <c>Class </c> object. </para>
				/// </returns>
				/// <java-name>
				/// loadClass
				/// </java-name>
				[Dot42.DexImport("loadClass", "(Ljava/lang/String;Z)Ljava/lang/Class;", AccessFlags = 4, Signature = "(Ljava/lang/String;Z)Ljava/lang/Class<*>;")]
				protected internal virtual global::System.Type LoadClass(string className, bool resolve) /* MethodBuilder.Create */ 
				{
						return default(global::System.Type);
				}

				/// <summary>
				///  <para>Forces a class to be linked (initialized). If the class has already been linked this operation has no effect. </para> <para> <b>Note:</b> In the Android reference implementation, this method has no effect. </para> <para></para>        
				/// </summary>
				/// <java-name>
				/// resolveClass
				/// </java-name>
				[Dot42.DexImport("resolveClass", "(Ljava/lang/Class;)V", AccessFlags = 20, Signature = "(Ljava/lang/Class<*>;)V")]
				protected internal void ResolveClass(global::System.Type clazz) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Finds the URL of the resource with the specified name. This implementation just returns <c>null </c> ; it should be overridden in subclasses.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the <c>URL </c> object for the requested resource. </para>
				/// </returns>
				/// <java-name>
				/// findResource
				/// </java-name>
				[Dot42.DexImport("findResource", "(Ljava/lang/String;)Ljava/net/URL;", AccessFlags = 4)]
				protected internal virtual global::Java.Net.URL FindResource(string resName) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.URL);
				}

				/// <summary>
				///  <para>Finds an enumeration of URLs for the resource with the specified name. This implementation just returns an empty <c>Enumeration </c> ; it should be overridden in subclasses.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>an enumeration of <c>URL </c> objects for the requested resource. </para>
				/// </returns>
				/// <java-name>
				/// findResources
				/// </java-name>
				[Dot42.DexImport("findResources", "(Ljava/lang/String;)Ljava/util/Enumeration;", AccessFlags = 4, Signature = "(Ljava/lang/String;)Ljava/util/Enumeration<Ljava/net/URL;>;")]
				protected internal virtual global::Java.Util.IEnumeration<global::Java.Net.URL> FindResources(string resName) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IEnumeration<global::Java.Net.URL>);
				}

				/// <summary>
				///  <para>Returns the absolute path of the native library with the specified name, or <c>null </c> . If this method returns <c>null </c> then the virtual machine searches the directories specified by the system property "java.library.path". </para> <para>This implementation always returns <c>null </c> . </para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the absolute path of the library. </para>
				/// </returns>
				/// <java-name>
				/// findLibrary
				/// </java-name>
				[Dot42.DexImport("findLibrary", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 4)]
				protected internal virtual string FindLibrary(string libName) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Returns the package with the specified name. Package information is searched in this class loader.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the package with the requested name; <c>null </c> if the package can not be found. </para>
				/// </returns>
				/// <java-name>
				/// getPackage
				/// </java-name>
				[Dot42.DexImport("getPackage", "(Ljava/lang/String;)Ljava/lang/Package;", AccessFlags = 4)]
				protected internal virtual global::Java.Lang.Package GetPackage(string name) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.Package);
				}

				/// <summary>
				///  <para>Defines and returns a new <c>Package </c> using the specified information. If <c>sealBase </c> is <c>null </c> , the package is left unsealed. Otherwise, the package is sealed using this URL.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the <c>Package </c> object that has been created. </para>
				/// </returns>
				/// <java-name>
				/// definePackage
				/// </java-name>
				[Dot42.DexImport("definePackage", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/la" +
    "ng/String;Ljava/lang/String;Ljava/lang/String;Ljava/net/URL;)Ljava/lang/Package;" +
    "", AccessFlags = 4)]
				protected internal virtual global::Java.Lang.Package DefinePackage(string name, string specTitle, string specVersion, string specVendor, string implTitle, string implVersion, string implVendor, global::Java.Net.URL sealBase) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.Package);
				}

				/// <summary>
				///  <para>Sets the signers of the specified class. This implementation does nothing.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setSigners
				/// </java-name>
				[Dot42.DexImport("setSigners", "(Ljava/lang/Class;[Ljava/lang/Object;)V", AccessFlags = 20, Signature = "(Ljava/lang/Class<*>;[Ljava/lang/Object;)V")]
				protected internal void SetSigners(global::System.Type c, object[] signers) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the assertion status of the class with the specified name. </para> <para> <b>Note: </b>This method does nothing in the Android reference implementation. </para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setClassAssertionStatus
				/// </java-name>
				[Dot42.DexImport("setClassAssertionStatus", "(Ljava/lang/String;Z)V", AccessFlags = 1)]
				public virtual void SetClassAssertionStatus(string cname, bool enable) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the assertion status of the package with the specified name. </para> <para> <b>Note: </b>This method does nothing in the Android reference implementation. </para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setPackageAssertionStatus
				/// </java-name>
				[Dot42.DexImport("setPackageAssertionStatus", "(Ljava/lang/String;Z)V", AccessFlags = 1)]
				public virtual void SetPackageAssertionStatus(string pname, bool enable) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the default assertion status for this class loader. </para> <para> <b>Note: </b>This method does nothing in the Android reference implementation. </para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setDefaultAssertionStatus
				/// </java-name>
				[Dot42.DexImport("setDefaultAssertionStatus", "(Z)V", AccessFlags = 1)]
				public virtual void SetDefaultAssertionStatus(bool enable) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the default assertion status for this class loader to <c>false </c> and removes any package default and class assertion status settings. </para> <para> <b>Note:</b> This method does nothing in the Android reference implementation. </para>        
				/// </summary>
				/// <java-name>
				/// clearAssertionStatus
				/// </java-name>
				[Dot42.DexImport("clearAssertionStatus", "()V", AccessFlags = 1)]
				public virtual void ClearAssertionStatus() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns the system class loader. This is the parent for new  <c>ClassLoader </c> instances and is typically the class loader used to start the application. </para>        
				/// </summary>
				/// <java-name>
				/// getSystemClassLoader
				/// </java-name>
				public static global::Java.Lang.ClassLoader SystemClassLoader
				{
						[Dot42.DexImport("getSystemClassLoader", "()Ljava/lang/ClassLoader;", AccessFlags = 9)]
						get{ return default(global::Java.Lang.ClassLoader); }
				}

				/// <summary>
				///  <para>Returns this class loader's parent.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>this class loader's parent or <c>null </c> . </para>
				/// </returns>
				/// <java-name>
				/// getParent
				/// </java-name>
				public global::Java.Lang.ClassLoader Parent
				{
						[Dot42.DexImport("getParent", "()Ljava/lang/ClassLoader;", AccessFlags = 17)]
						get{ return default(global::Java.Lang.ClassLoader); }
				}

				/// <summary>
				///  <para>Returns all the packages known to this class loader.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>an array with all packages known to this class loader. </para>
				/// </returns>
				/// <java-name>
				/// getPackages
				/// </java-name>
				protected internal virtual global::Java.Lang.Package[] Packages
				{
						[Dot42.DexImport("getPackages", "()[Ljava/lang/Package;", AccessFlags = 4)]
						get{ return default(global::Java.Lang.Package[]); }
				}

		}

		/// <summary>
		///  <para>Thrown when a class loader is unable to find a class. </para>    
		/// </summary>
		/// <java-name>
		/// java/lang/ClassNotFoundException
		/// </java-name>
		[Dot42.DexImport("java/lang/ClassNotFoundException", AccessFlags = 33)]
		public partial class ClassNotFoundException : global::System.Exception
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructs a new <c>ClassNotFoundException </c> that includes the current stack trace. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ClassNotFoundException() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new <c>ClassNotFoundException </c> with the current stack trace and the specified detail message.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public ClassNotFoundException(string detailMessage) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new <c>ClassNotFoundException </c> with the current stack trace, the specified detail message and the exception that occurred when loading the class.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public ClassNotFoundException(string detailMessage, global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns the exception which occurred when loading the class.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Throwable the exception which occurred while loading the class. </para>
				/// </returns>
				/// <java-name>
				/// getException
				/// </java-name>
				public virtual global::System.Exception Exception
				{
						[Dot42.DexImport("getException", "()Ljava/lang/Throwable;", AccessFlags = 1)]
						get{ return default(global::System.Exception); }
				}

				/// <summary>
				///  <para>Returns the cause of this Throwable, or <c>null </c> if there is no cause.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Throwable the receiver's cause. </para>
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
		///  <para>Thrown when a program attempts to clone an object which does not support the Cloneable interface.</para> <para> <para>Cloneable </para></para>    
		/// </summary>
		/// <java-name>
		/// java/lang/CloneNotSupportedException
		/// </java-name>
		[Dot42.DexImport("java/lang/CloneNotSupportedException", AccessFlags = 33)]
		public partial class CloneNotSupportedException : global::System.Exception
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructs a new <c>CloneNotSupportedException </c> that includes the current stack trace. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public CloneNotSupportedException() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new <c>CloneNotSupportedException </c> with the current stack trace and the specified detail message.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public CloneNotSupportedException(string detailMessage) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>Does nothing on Android. </para>    
		/// </summary>
		/// <java-name>
		/// java/lang/Compiler
		/// </java-name>
		[Dot42.DexImport("java/lang/Compiler", AccessFlags = 49)]
		public sealed partial class Compiler
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Prevent this class from being instantiated. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal Compiler() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Executes an operation according to the specified command object. This method is the low-level interface to the JIT compiler. It may return any object or <c>null </c> if no JIT compiler is available. Returns null on Android, whether or not the system has a JIT.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the result of executing command or <c>null </c> . </para>
				/// </returns>
				/// <java-name>
				/// command
				/// </java-name>
				[Dot42.DexImport("command", "(Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 9)]
				public static object Command(object cmd) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <summary>
				///  <para>Compiles the specified class using the JIT compiler and indicates if compilation has been successful. Does nothing and returns false on Android.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if the compilation has been successful;  <c>false </c> if it has failed or if there is no JIT compiler available. </para>
				/// </returns>
				/// <java-name>
				/// compileClass
				/// </java-name>
				[Dot42.DexImport("compileClass", "(Ljava/lang/Class;)Z", AccessFlags = 9, Signature = "(Ljava/lang/Class<*>;)Z")]
				public static bool CompileClass(global::System.Type classToCompile) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Compiles all classes whose name matches the specified name using the JIT compiler and indicates if compilation has been successful. Does nothing and returns false on Android.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if the compilation has been successful;  <c>false </c> if it has failed or if there is no JIT compiler available. </para>
				/// </returns>
				/// <java-name>
				/// compileClasses
				/// </java-name>
				[Dot42.DexImport("compileClasses", "(Ljava/lang/String;)Z", AccessFlags = 9)]
				public static bool CompileClasses(string nameRoot) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Disables the JIT compiler. Does nothing on Android. </para>        
				/// </summary>
				/// <java-name>
				/// disable
				/// </java-name>
				[Dot42.DexImport("disable", "()V", AccessFlags = 9)]
				public static void Disable() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Enables the JIT compiler. Does nothing on Android. </para>        
				/// </summary>
				/// <java-name>
				/// enable
				/// </java-name>
				[Dot42.DexImport("enable", "()V", AccessFlags = 9)]
				public static void Enable() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>The superclass of all enumerated types. Actual enumeration types inherit from this class, but extending this class does not make a class an enumeration type, since the compiler needs to generate special information for it. </para>    
		/// </summary>
		/// <java-name>
		/// java/lang/Enum
		/// </java-name>
		[Dot42.DexImport("java/lang/Enum", AccessFlags = 1057, Signature = "<E:Ljava/lang/Enum<TE;>;>Ljava/lang/Object;Ljava/io/Serializable;Ljava/lang/Compa" +
    "rable<TE;>;")]
		public abstract partial class Enum<E> : global::Java.IO.ISerializable, global::System.IComparable<E>
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructor for constants of enum subtypes.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;I)V", AccessFlags = 4)]
				protected internal Enum(string name, int ordinal) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns the name of this enum constant. The name is the field as it appears in the <c>enum </c> declaration.</para> <para> <para>toString() </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the name of this enum constant. </para>
				/// </returns>
				/// <java-name>
				/// name
				/// </java-name>
				[Dot42.DexImport("name", "()Ljava/lang/String;", AccessFlags = 17)]
				public string Name() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Returns the position of the enum constant in the declaration. The first constant has an ordinal value of zero.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the ordinal value of this enum constant. </para>
				/// </returns>
				/// <java-name>
				/// ordinal
				/// </java-name>
				[Dot42.DexImport("ordinal", "()I", AccessFlags = 17)]
				public int Ordinal() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Returns a string containing a concise, human-readable description of this object. In this case, the enum constant's name is returned.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a printable representation of this object. </para>
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
				///  <para>Compares this object with the specified object and indicates if they are equal. In order to be equal, <c>object </c> must be identical to this enum constant.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if the specified object is equal to this  <c>Enum </c> ; <c>false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 17)]
				public override bool Equals(object other) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 17)]
				public override int GetHashCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para> <c>Enum </c> objects are singletons, they may not be cloned. This method always throws a <c>CloneNotSupportedException </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>does not return. </para>
				/// </returns>
				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/lang/Object;", AccessFlags = 20)]
				protected internal object Clone() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <summary>
				///  <para>Compares this object to the specified enum object to determine their relative order. This method compares the object's ordinal values, that is, their position in the enum declaration.</para> <para> <para>java.lang.Comparable </para></para>        
				/// </summary>
				/// <returns>
				///  <para>a negative value if the ordinal value of this enum constant is less than the ordinal value of <c>o </c> ; 0 if the ordinal values of this enum constant and <c>o </c> are equal; a positive value if the ordinal value of this enum constant is greater than the ordinal value of <c>o </c> . </para>
				/// </returns>
				/// <java-name>
				/// compareTo
				/// </java-name>
				[Dot42.DexImport("compareTo", "(Ljava/lang/Enum;)I", AccessFlags = 17, Signature = "(TE;)I")]
				public int CompareTo(E o) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Returns the constant with the specified name of the specified enum type.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the enum constant. </para>
				/// </returns>
				/// <java-name>
				/// valueOf
				/// </java-name>
				[Dot42.DexImport("valueOf", "(Ljava/lang/Class;Ljava/lang/String;)Ljava/lang/Enum;", AccessFlags = 9, Signature = "<T:Ljava/lang/Enum<TT;>;>(Ljava/lang/Class<TT;>;Ljava/lang/String;)TT;")]
				public static T ValueOf<T>(global::System.Type enumType, string name) /* MethodBuilder.Create */ 
				{
						return default(T);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal Enum() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Returns the enum constant's declaring class.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the class object representing the constant's enum type. </para>
				/// </returns>
				/// <java-name>
				/// getDeclaringClass
				/// </java-name>
				public global::System.Type DeclaringClass
				{
						[Dot42.DexImport("getDeclaringClass", "()Ljava/lang/Class;", AccessFlags = 17, Signature = "()Ljava/lang/Class<TE;>;")]
						get{ return default(global::System.Type); }
				}

		}

		/// <summary>
		///  <para>Thrown if an <c>enum </c> constant does not exist for a particular name.</para> <para> <para>1.5 </para></para>    
		/// </summary>
		/// <java-name>
		/// java/lang/EnumConstantNotPresentException
		/// </java-name>
		[Dot42.DexImport("java/lang/EnumConstantNotPresentException", AccessFlags = 33)]
		public partial class EnumConstantNotPresentException : global::System.SystemException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructs a new <c>EnumConstantNotPresentException </c> with the current stack trace and a detail message based on the specified enum type and missing constant name.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/Class;Ljava/lang/String;)V", AccessFlags = 1, Signature = "(Ljava/lang/Class<+Ljava/lang/Enum;>;Ljava/lang/String;)V")]
				public EnumConstantNotPresentException(global::System.Type enumType, string constantName) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Gets the enum type for which the constant name is missing.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the enum type for which a constant name has not been found. </para>
				/// </returns>
				/// <java-name>
				/// enumType
				/// </java-name>
				[Dot42.DexImport("enumType", "()Ljava/lang/Class;", AccessFlags = 1, Signature = "()Ljava/lang/Class<+Ljava/lang/Enum;>;")]
				public virtual global::System.Type EnumType() /* MethodBuilder.Create */ 
				{
						return default(global::System.Type);
				}

				/// <summary>
				///  <para>Gets the name of the missing constant.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the name of the constant that has not been found in the enum type. </para>
				/// </returns>
				/// <java-name>
				/// constantName
				/// </java-name>
				[Dot42.DexImport("constantName", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string ConstantName() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal EnumConstantNotPresentException() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		///  <para> <c>Error </c> is the superclass of all classes that represent unrecoverable errors. When errors are thrown, they should not be caught by application code.</para> <para> <para>Throwable </para> <para>Exception </para> <para>RuntimeException </para></para>    
		/// </summary>
		/// <java-name>
		/// java/lang/Error
		/// </java-name>
		[Dot42.DexImport("java/lang/Error", AccessFlags = 33)]
		public partial class Error : global::System.Exception
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructs a new <c>Error </c> that includes the current stack trace. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Error() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new <c>Error </c> with the current stack trace and the specified detail message.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public Error(string detailMessage) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new <c>Error </c> with the current stack trace, the specified detail message and the specified cause.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public Error(string detailMessage, global::System.Exception throwable) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new <c>Error </c> with the current stack trace and the specified detail message.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public Error(global::System.Exception detailMessage) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para> <c>Exception </c> is the superclass of all classes that represent recoverable exceptions. When exceptions are thrown, they may be caught by application code.</para> <para> <para>Throwable </para> <para>Error </para> <para>RuntimeException </para></para>    
		/// </summary>
		/// <java-name>
		/// java/lang/Exception
		/// </java-name>
		[Dot42.DexImport("java/lang/Exception", AccessFlags = 33)]
		public partial class Exception : global::System.Exception
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructs a new <c>Exception </c> that includes the current stack trace. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Exception() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new <c>Exception </c> with the current stack trace and the specified detail message.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public Exception(string detailMessage) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new <c>Exception </c> with the current stack trace, the specified detail message and the specified cause.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public Exception(string detailMessage, global::System.Exception throwable) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new <c>Exception </c> with the current stack trace and the specified detail message.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public Exception(global::System.Exception detailMessage) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>Thrown when an exception occurs during class initialization. </para>    
		/// </summary>
		/// <java-name>
		/// java/lang/ExceptionInInitializerError
		/// </java-name>
		[Dot42.DexImport("java/lang/ExceptionInInitializerError", AccessFlags = 33)]
		public partial class ExceptionInInitializerError : global::Java.Lang.LinkageError
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructs a new <c>ExceptionInInitializerError </c> that includes the current stack trace. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ExceptionInInitializerError() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new <c>ExceptionInInitializerError </c> with the current stack trace and the specified detail message.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public ExceptionInInitializerError(string detailMessage) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new <c>ExceptionInInitializerError </c> with the current stack trace and the specified detail message.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public ExceptionInInitializerError(global::System.Exception detailMessage) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns the exception that is the cause of this error.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the exception that caused this error. </para>
				/// </returns>
				/// <java-name>
				/// getException
				/// </java-name>
				public virtual global::System.Exception Exception
				{
						[Dot42.DexImport("getException", "()Ljava/lang/Throwable;", AccessFlags = 1)]
						get{ return default(global::System.Exception); }
				}

				/// <summary>
				///  <para>Returns the cause of this error, or <c>null </c> if there is no cause.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the exception that caused this error. </para>
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
		///  <para>Declares methods to append characters or character sequences. Any class that implements this interface can receive data formatted by a java.util.Formatter. The appended character or character sequence should be valid according to the rules described in Unicode Character Representation. </para> <para> <c>Appendable </c> itself does not guarantee thread safety. This responsibility is up to the implementing class. </para> <para>Implementing classes can choose different exception handling mechanism. They can choose to throw exceptions other than <c>IOException </c> or they do not throw any exceptions at all and use error codes instead. </para>    
		/// </summary>
		/// <java-name>
		/// java/lang/Appendable
		/// </java-name>
		[Dot42.DexImport("java/lang/Appendable", AccessFlags = 1537)]
		public partial interface IAppendable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Appends the specified character.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>this <c>Appendable </c> . </para>
				/// </returns>
				/// <java-name>
				/// append
				/// </java-name>
				[Dot42.DexImport("append", "(C)Ljava/lang/Appendable;", AccessFlags = 1025)]
				global::Java.Lang.IAppendable Append(char c) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Appends the specified character.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>this <c>Appendable </c> . </para>
				/// </returns>
				/// <java-name>
				/// append
				/// </java-name>
				[Dot42.DexImport("append", "(Ljava/lang/CharSequence;)Ljava/lang/Appendable;", AccessFlags = 1025)]
				global::Java.Lang.IAppendable Append(global::Java.Lang.ICharSequence c) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Appends a subsequence of <c>csq </c> . </para> <para>If <c>csq </c> is not <c>null </c> then calling this method is equivalent to calling <c>append(csq.subSequence(start, end)) </c> . </para> <para>If <c>csq </c> is <c>null </c> , the characters "null" are appended.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>this <c>Appendable </c> . </para>
				/// </returns>
				/// <java-name>
				/// append
				/// </java-name>
				[Dot42.DexImport("append", "(Ljava/lang/CharSequence;II)Ljava/lang/Appendable;", AccessFlags = 1025)]
				global::Java.Lang.IAppendable JavaAppend(global::Java.Lang.ICharSequence csq, int start, int end) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		///  <para>This interface represents an ordered set of characters and defines the methods to probe them. </para>    
		/// </summary>
		/// <java-name>
		/// java/lang/CharSequence
		/// </java-name>
		[Dot42.DexImport("java/lang/CharSequence", AccessFlags = 1537)]
		public partial interface ICharSequence
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Returns the number of characters in this sequence.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the number of characters. </para>
				/// </returns>
				/// <java-name>
				/// length
				/// </java-name>
				[Dot42.DexImport("length", "()I", AccessFlags = 1025)]
				int Length() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns the character at the specified index, with the first character having index zero.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the requested character. </para>
				/// </returns>
				/// <java-name>
				/// charAt
				/// </java-name>
				[Dot42.DexImport("charAt", "(I)C", AccessFlags = 1025)]
				char CharAt(int index) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns a <c>CharSequence </c> from the <c>start </c> index (inclusive) to the <c>end </c> index (exclusive) of this sequence.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the requested sub-sequence. </para>
				/// </returns>
				/// <java-name>
				/// subSequence
				/// </java-name>
				[Dot42.DexImport("subSequence", "(II)Ljava/lang/CharSequence;", AccessFlags = 1025)]
				global::Java.Lang.ICharSequence SubSequence(int start, int end) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns a string with the same characters in the same order as in this sequence.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a string based on this sequence. </para>
				/// </returns>
				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1025)]
				string ToString() /* MethodBuilder.Create */ ;

		}

		/// <summary>
		///  <para>This (empty) interface must be implemented by all classes that wish to support cloning. The implementation of <c>clone() </c> in <c>Object </c> checks if the object being cloned implements this interface and throws  <c>CloneNotSupportedException </c> if it does not.</para> <para> <para>Object::clone </para> <para>CloneNotSupportedException </para></para>    
		/// </summary>
		/// <java-name>
		/// java/lang/Cloneable
		/// </java-name>
		[Dot42.DexImport("java/lang/Cloneable", AccessFlags = 1537)]
		public partial interface ICloneable
 /* scope: __dot42__ */ 
		{
		}

		/// <summary>
		///  <para>Annotation type used to mark program elements that should no longer be used by programmers. Compilers produce a warning if a deprecated program element is used.</para> <para> <para>1.5 </para></para>    
		/// </summary>
		/// <java-name>
		/// java/lang/Deprecated
		/// </java-name>
		[Dot42.DexImport("java/lang/Deprecated", AccessFlags = 9729)]
		public partial interface IDeprecated : global::Java.Lang.Annotation.IAnnotation
 /* scope: __dot42__ */ 
		{
		}

		/// <summary>
		///  <para>Instances of classes that implement this interface can be used with the enhanced for loop.</para> <para> <para>1.5 </para></para>    
		/// </summary>
		/// <java-name>
		/// java/lang/Iterable
		/// </java-name>
		[Dot42.DexImport("java/lang/Iterable", AccessFlags = 1537, Signature = "<T:Ljava/lang/Object;>Ljava/lang/Object;")]
		public partial interface IIterable<T>
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Returns an Iterator for the elements in this object.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>An <c>Iterator </c> instance. </para>
				/// </returns>
				/// <java-name>
				/// iterator
				/// </java-name>
				[Dot42.DexImport("iterator", "()Ljava/util/Iterator;", AccessFlags = 1025, Signature = "()Ljava/util/Iterator<TT;>;")]
				global::Java.Util.IIterator<T> Iterator() /* MethodBuilder.Create */ ;

		}

		/// <summary>
		///  <para>Thrown when the VM notices that a program tries access a field which is not accessible from where it is referenced. </para> <para>Note that this can only occur when inconsistent class files have been loaded. </para>    
		/// </summary>
		/// <java-name>
		/// java/lang/IllegalAccessError
		/// </java-name>
		[Dot42.DexImport("java/lang/IllegalAccessError", AccessFlags = 33)]
		public partial class IllegalAccessError : global::Java.Lang.IncompatibleClassChangeError
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructs a new <c>IllegalAccessError </c> that includes the current stack trace. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public IllegalAccessError() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new <c>IllegalAccessError </c> with the current stack trace and the specified detail message.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public IllegalAccessError(string detailMessage) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>Thrown when a program attempts to access a field or method which is not accessible from the location where the reference is made. </para>    
		/// </summary>
		/// <java-name>
		/// java/lang/IllegalAccessException
		/// </java-name>
		[Dot42.DexImport("java/lang/IllegalAccessException", AccessFlags = 33)]
		public partial class IllegalAccessException : global::System.Exception
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructs a new <c>IllegalAccessException </c> that includes the current stack trace. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public IllegalAccessException() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new <c>IllegalAccessException </c> with the current stack trace and the specified detail message.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public IllegalAccessException(string detailMessage) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>Thrown when a monitor operation is attempted when the monitor is not in the correct state, for example when a thread attempts to exit a monitor which it does not own. </para>    
		/// </summary>
		/// <java-name>
		/// java/lang/IllegalMonitorStateException
		/// </java-name>
		[Dot42.DexImport("java/lang/IllegalMonitorStateException", AccessFlags = 33)]
		public partial class IllegalMonitorStateException : global::System.SystemException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructs a new <c>IllegalMonitorStateException </c> that includes the current stack trace. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public IllegalMonitorStateException() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new <c>IllegalArgumentException </c> with the current stack trace and the specified detail message.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public IllegalMonitorStateException(string detailMessage) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>Thrown when an action is attempted at a time when the VM is not in the correct state. </para>    
		/// </summary>
		/// <java-name>
		/// java/lang/IllegalStateException
		/// </java-name>
		[Dot42.DexImport("java/lang/IllegalStateException", AccessFlags = 33)]
		public partial class IllegalStateException : global::System.SystemException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructs a new <c>IllegalStateException </c> that includes the current stack trace. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public IllegalStateException() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new <c>IllegalStateException </c> with the current stack trace and the specified detail message.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public IllegalStateException(string detailMessage) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new <c>IllegalStateException </c> with the current stack trace, the specified detail message and the specified cause.</para> <para> <para>1.5 </para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public IllegalStateException(string message, global::System.Exception cause) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new <c>IllegalStateException </c> with the current stack trace and the specified detail message.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public IllegalStateException(global::System.Exception detailMessage) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>Thrown when an operation is attempted which is not possible given the state that the executing thread is in. </para>    
		/// </summary>
		/// <java-name>
		/// java/lang/IllegalThreadStateException
		/// </java-name>
		[Dot42.DexImport("java/lang/IllegalThreadStateException", AccessFlags = 33)]
		public partial class IllegalThreadStateException : global::System.ArgumentException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructs a new <c>IllegalThreadStateException </c> that includes the current stack trace. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public IllegalThreadStateException() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new <c>IllegalThreadStateException </c> with the current stack trace and the specified detail message.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public IllegalThreadStateException(string detailMessage) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para> <c>IncompatibleClassChangeError </c> is the superclass of all classes which represent errors that occur when inconsistent class files are loaded into the same running image.</para> <para> <para>Error </para></para>    
		/// </summary>
		/// <java-name>
		/// java/lang/IncompatibleClassChangeError
		/// </java-name>
		[Dot42.DexImport("java/lang/IncompatibleClassChangeError", AccessFlags = 33)]
		public partial class IncompatibleClassChangeError : global::Java.Lang.LinkageError
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructs a new <c>IncompatibleClassChangeError </c> that includes the current stack trace. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public IncompatibleClassChangeError() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new <c>IncompatibleClassChangeError </c> with the current stack trace and the specified detail message.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public IncompatibleClassChangeError(string detailMessage) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>A thread-local variable whose value is passed from parent to child thread. By default, the value of an inheritable thread-local variable of a child thread is initialized with the value of the parent thread's variable at thread creation time. However, subclasses may override {code #childValue(Object)} to provide an arbitrary function for passing the value of a parent's thread-local variable to the child's thread-local variable.</para> <para> <para>java.lang.Thread </para> <para>java.lang.ThreadLocal </para></para>    
		/// </summary>
		/// <java-name>
		/// java/lang/InheritableThreadLocal
		/// </java-name>
		[Dot42.DexImport("java/lang/InheritableThreadLocal", AccessFlags = 33, Signature = "<T:Ljava/lang/Object;>Ljava/lang/ThreadLocal<TT;>;")]
		public partial class InheritableThreadLocal<T> : global::Java.Lang.ThreadLocal<T>
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Creates a new inheritable thread-local variable. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public InheritableThreadLocal() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Computes the initial value of this thread-local variable for the child thread given the parent thread's value. Called from the parent thread when creating a child thread. The default implementation returns the parent thread's value.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the initial value of the variable for the child thread. </para>
				/// </returns>
				/// <java-name>
				/// childValue
				/// </java-name>
				[Dot42.DexImport("childValue", "(Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 4, Signature = "(TT;)TT;")]
				protected internal virtual T ChildValue(T parentValue) /* MethodBuilder.Create */ 
				{
						return default(T);
				}

		}

		/// <summary>
		///  <para>Thrown when the VM notices that a program tries to create a new instance of a class which has no visible constructors from the location where  <c>new </c> is invoked. </para> <para>Note that this can only occur when inconsistent class files are being loaded. </para>    
		/// </summary>
		/// <java-name>
		/// java/lang/InstantiationError
		/// </java-name>
		[Dot42.DexImport("java/lang/InstantiationError", AccessFlags = 33)]
		public partial class InstantiationError : global::Java.Lang.IncompatibleClassChangeError
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructs a new <c>InstantiationError </c> that includes the current stack trace. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public InstantiationError() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new <c>InstantiationError </c> with the current stack trace and the specified detail message.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public InstantiationError(string detailMessage) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>Thrown when a program attempts to access a constructor which is not accessible from the location where the reference is made. </para>    
		/// </summary>
		/// <java-name>
		/// java/lang/InstantiationException
		/// </java-name>
		[Dot42.DexImport("java/lang/InstantiationException", AccessFlags = 33)]
		public partial class InstantiationException : global::System.Exception
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructs a new <c>InstantiationException </c> that includes the current stack trace. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public InstantiationException() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new <c>InstantiationException </c> with the current stack trace and the specified detail message.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public InstantiationException(string detailMessage) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>Thrown when the VM notices that it has gotten into an undefined state. </para>    
		/// </summary>
		/// <java-name>
		/// java/lang/InternalError
		/// </java-name>
		[Dot42.DexImport("java/lang/InternalError", AccessFlags = 33)]
		public partial class InternalError : global::Java.Lang.VirtualMachineError
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructs a new <c>InternalError </c> that includes the current stack trace. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public InternalError() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new <c>InternalError </c> with the current stack trace and the specified detail message.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public InternalError(string detailMessage) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>Thrown when a waiting thread is activated before the condition it was waiting for has been satisfied. </para>    
		/// </summary>
		/// <java-name>
		/// java/lang/InterruptedException
		/// </java-name>
		[Dot42.DexImport("java/lang/InterruptedException", AccessFlags = 33)]
		public partial class InterruptedException : global::System.Exception
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructs a new <c>InterruptedException </c> that includes the current stack trace. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public InterruptedException() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new <c>InterruptedException </c> with the current stack trace and the specified detail message.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public InterruptedException(string detailMessage) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>Annotation type used to mark methods that override a method declaration in a superclass. Compilers produce an error if a method annotated with  does not actually override a method in a superclass.</para> <para> <para>1.5 </para></para>    
		/// </summary>
		/// <java-name>
		/// java/lang/Override
		/// </java-name>
		[Dot42.DexImport("java/lang/Override", AccessFlags = 9729)]
		public partial interface IOverride : global::Java.Lang.Annotation.IAnnotation
 /* scope: __dot42__ */ 
		{
		}

		/// <summary>
		///  <para>Represents a sequence of characters that can be incrementally read (copied) into a CharBuffer. </para>    
		/// </summary>
		/// <java-name>
		/// java/lang/Readable
		/// </java-name>
		[Dot42.DexImport("java/lang/Readable", AccessFlags = 1537)]
		public partial interface IReadable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Reads characters into the specified <c>CharBuffer </c> . The maximum number of characters read is <c>CharBuffer.remaining() </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the number of characters actually read, or -1 if this  <c>Readable </c> reaches its end </para>
				/// </returns>
				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "(Ljava/nio/CharBuffer;)I", AccessFlags = 1025)]
				int Read(global::Java.Nio.CharBuffer cb) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		///  <para>Represents a command that can be executed. Often used to run code in a different Thread. </para>    
		/// </summary>
		/// <java-name>
		/// java/lang/Runnable
		/// </java-name>
		[Dot42.DexImport("java/lang/Runnable", AccessFlags = 1537)]
		public partial interface IRunnable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Starts executing the active part of the class' code. This method is called when a thread is started that has been created with a class which implements <c>Runnable </c> . </para>        
				/// </summary>
				/// <java-name>
				/// run
				/// </java-name>
				[Dot42.DexImport("run", "()V", AccessFlags = 1025)]
				void Run() /* MethodBuilder.Create */ ;

		}

		/// <summary>
		///  <para>Annotation type used to indicate that the compiler should not issue the specified warnings for the marked program element. Warnings are not only suppressed for the annotated element but also for all program elements contained in that element. </para> <para>It is recommended that programmers always use this annotation on the most deeply nested element where it is actually needed.</para> <para> <para>1.5 </para></para>    
		/// </summary>
		/// <java-name>
		/// java/lang/SuppressWarnings
		/// </java-name>
		[Dot42.DexImport("java/lang/SuppressWarnings", AccessFlags = 9729)]
		public partial interface ISuppressWarnings : global::Java.Lang.Annotation.IAnnotation
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>The list of warnings a compiler should not issue. </para>        
				/// </summary>
				/// <java-name>
				/// value
				/// </java-name>
				[Dot42.DexImport("value", "()[Ljava/lang/String;", AccessFlags = 1025)]
				string[] Value() /* MethodBuilder.Create */ ;

		}

		/// <summary>
		///  <para> <c>LinkageError </c> is the superclass of all error classes that occur when loading and linking class files.</para> <para> <para>Error </para></para>    
		/// </summary>
		/// <java-name>
		/// java/lang/LinkageError
		/// </java-name>
		[Dot42.DexImport("java/lang/LinkageError", AccessFlags = 33)]
		public partial class LinkageError : global::Java.Lang.Error
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructs a new <c>LinkageError </c> that includes the current stack trace. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public LinkageError() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new <c>LinkageError </c> with the current stack trace and the specified detail message.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public LinkageError(string detailMessage) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>Thrown when an attempt is made to create an array with a size of less than zero. </para>    
		/// </summary>
		/// <java-name>
		/// java/lang/NegativeArraySizeException
		/// </java-name>
		[Dot42.DexImport("java/lang/NegativeArraySizeException", AccessFlags = 33)]
		public partial class NegativeArraySizeException : global::System.SystemException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructs a new <c>NegativeArraySizeException </c> that includes the current stack trace. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public NegativeArraySizeException() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new <c>NegativeArraySizeException </c> with the current stack trace and the specified detail message.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public NegativeArraySizeException(string detailMessage) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>Thrown when the VM is unable to locate a class which it has been asked to load. </para>    
		/// </summary>
		/// <java-name>
		/// java/lang/NoClassDefFoundError
		/// </java-name>
		[Dot42.DexImport("java/lang/NoClassDefFoundError", AccessFlags = 33)]
		public partial class NoClassDefFoundError : global::Java.Lang.LinkageError
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructs a new <c>NoClassDefFoundError </c> that includes the current stack trace. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public NoClassDefFoundError() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new <c>NoClassDefFoundError </c> with the current stack trace and the specified detail message.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public NoClassDefFoundError(string detailMessage) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>Thrown when the VM notices that a program tries to reference, on a class or object, a field that does not exist. </para>    
		/// </summary>
		/// <java-name>
		/// java/lang/NoSuchFieldException
		/// </java-name>
		[Dot42.DexImport("java/lang/NoSuchFieldException", AccessFlags = 33)]
		public partial class NoSuchFieldException : global::System.Exception
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructs a new <c>NoSuchFieldException </c> that includes the current stack trace. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public NoSuchFieldException() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new <c>NoSuchFieldException </c> with the current stack trace and the specified detail message.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public NoSuchFieldException(string detailMessage) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>Thrown when the VM notices that a program tries to reference, on a class or object, a method that does not exist. </para>    
		/// </summary>
		/// <java-name>
		/// java/lang/NoSuchMethodException
		/// </java-name>
		[Dot42.DexImport("java/lang/NoSuchMethodException", AccessFlags = 33)]
		public partial class NoSuchMethodException : global::System.Exception
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructs a new <c>NoSuchMethodException </c> that includes the current stack trace. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public NoSuchMethodException() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new <c>NoSuchMethodException </c> with the current stack trace and the specified detail message.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public NoSuchMethodException(string detailMessage) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>The abstract superclass of the classes which represent numeric base types (that is Byte, Short, Integer, Long, Float, and Double. </para>    
		/// </summary>
		/// <java-name>
		/// java/lang/Number
		/// </java-name>
		[Dot42.DexImport("java/lang/Number", AccessFlags = 1057)]
		public abstract partial class Number : global::Java.IO.ISerializable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Empty default constructor. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Number() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns this object's value as a byte. Might involve rounding and/or truncating the value, so it fits into a byte.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the primitive byte value of this object. </para>
				/// </returns>
				/// <java-name>
				/// byteValue
				/// </java-name>
				[Dot42.DexImport("byteValue", "()B", AccessFlags = 1)]
				public virtual sbyte ByteValue() /* MethodBuilder.Create */ 
				{
						return default(sbyte);
				}

				/// <summary>
				///  <para>Returns this object's value as a double. Might involve rounding.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the primitive double value of this object. </para>
				/// </returns>
				/// <java-name>
				/// doubleValue
				/// </java-name>
				[Dot42.DexImport("doubleValue", "()D", AccessFlags = 1025)]
				public abstract double DoubleValue() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns this object's value as a float. Might involve rounding.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the primitive float value of this object. </para>
				/// </returns>
				/// <java-name>
				/// floatValue
				/// </java-name>
				[Dot42.DexImport("floatValue", "()F", AccessFlags = 1025)]
				public abstract float FloatValue() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns this object's value as an int. Might involve rounding and/or truncating the value, so it fits into an int.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the primitive int value of this object. </para>
				/// </returns>
				/// <java-name>
				/// intValue
				/// </java-name>
				[Dot42.DexImport("intValue", "()I", AccessFlags = 1025)]
				public abstract int IntValue() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns this object's value as a long. Might involve rounding and/or truncating the value, so it fits into a long.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the primitive long value of this object. </para>
				/// </returns>
				/// <java-name>
				/// longValue
				/// </java-name>
				[Dot42.DexImport("longValue", "()J", AccessFlags = 1025)]
				public abstract long LongValue() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns this object's value as a short. Might involve rounding and/or truncating the value, so it fits into a short.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the primitive short value of this object. </para>
				/// </returns>
				/// <java-name>
				/// shortValue
				/// </java-name>
				[Dot42.DexImport("shortValue", "()S", AccessFlags = 1)]
				public virtual short ShortValue() /* MethodBuilder.Create */ 
				{
						return default(short);
				}

		}

		/// <summary>
		///  <para>Thrown when an invalid value is passed to a string-to-number conversion method. </para>    
		/// </summary>
		/// <java-name>
		/// java/lang/NumberFormatException
		/// </java-name>
		[Dot42.DexImport("java/lang/NumberFormatException", AccessFlags = 33)]
		public partial class NumberFormatException : global::System.ArgumentException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructs a new <c>NumberFormatException </c> that includes the current stack trace. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public NumberFormatException() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new <c>NumberFormatException </c> with the current stack trace and the specified detail message.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public NumberFormatException(string detailMessage) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>Contains information about a Java package. This includes implementation and specification versions. Typically this information is retrieved from the manifest. </para> <para>Packages are managed by class loaders. All classes loaded by the same loader from the same package share a <c>Package </c> instance. </para> <para> <para>java.lang.ClassLoader </para></para>    
		/// </summary>
		/// <java-name>
		/// java/lang/Package
		/// </java-name>
		[Dot42.DexImport("java/lang/Package", AccessFlags = 33)]
		public partial class Package : global::Java.Lang.Reflect.IAnnotatedElement
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal Package() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns the annotation associated with the specified annotation type and this package, if present.</para> <para> <para>java.lang.reflect.AnnotatedElement::getAnnotation(java.lang.Class) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>an instance of Annotation or <c>null </c> . </para>
				/// </returns>
				/// <java-name>
				/// getAnnotation
				/// </java-name>
				[Dot42.DexImport("getAnnotation", "(Ljava/lang/Class;)Ljava/lang/annotation/Annotation;", AccessFlags = 1, Signature = "<T::Ljava/lang/annotation/Annotation;>(Ljava/lang/Class<TT;>;)TT;")]
				public virtual T GetAnnotation<T>(global::System.Type annotationType) /* MethodBuilder.Create */ 
				{
						return default(T);
				}

				/// <summary>
				///  <para>Returns an array of this package's annotations. </para>        
				/// </summary>
				/// <java-name>
				/// getAnnotations
				/// </java-name>
				[Dot42.DexImport("getAnnotations", "()[Ljava/lang/annotation/Annotation;", AccessFlags = 1)]
				public virtual global::Java.Lang.Annotation.IAnnotation[] GetAnnotations() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.Annotation.IAnnotation[]);
				}

				/// <summary>
				///  <para>Returns an array of this package's declared annotations. Package annotations aren't inherited, so this is equivalent to getAnnotations. </para>        
				/// </summary>
				/// <java-name>
				/// getDeclaredAnnotations
				/// </java-name>
				[Dot42.DexImport("getDeclaredAnnotations", "()[Ljava/lang/annotation/Annotation;", AccessFlags = 1)]
				public virtual global::Java.Lang.Annotation.IAnnotation[] GetDeclaredAnnotations() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.Annotation.IAnnotation[]);
				}

				/// <summary>
				///  <para>Indicates whether the specified annotation is present.</para> <para> <para>java.lang.reflect.AnnotatedElement::isAnnotationPresent(java.lang.Class) </para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if the annotation is present; <c>false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isAnnotationPresent
				/// </java-name>
				[Dot42.DexImport("isAnnotationPresent", "(Ljava/lang/Class;)Z", AccessFlags = 1, Signature = "(Ljava/lang/Class<+Ljava/lang/annotation/Annotation;>;)Z")]
				public virtual bool IsAnnotationPresent(global::System.Type annotationType) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Attempts to locate the requested package in the caller's class loader. If no package information can be located, <c>null </c> is returned.</para> <para> <para>ClassLoader::getPackage(java.lang.String) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the requested package, or <c>null </c> . </para>
				/// </returns>
				/// <java-name>
				/// getPackage
				/// </java-name>
				[Dot42.DexImport("getPackage", "(Ljava/lang/String;)Ljava/lang/Package;", AccessFlags = 9)]
				public static global::Java.Lang.Package GetPackage(string packageName) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.Package);
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
				///  <para>Indicates whether this package's specification version is compatible with the specified version string. Version strings are compared by comparing each dot separated part of the version as an integer.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if the package versions are compatible; <c>false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isCompatibleWith
				/// </java-name>
				[Dot42.DexImport("isCompatibleWith", "(Ljava/lang/String;)Z", AccessFlags = 1)]
				public virtual bool IsCompatibleWith(string version) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Indicates whether this package is sealed.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if this package is sealed; <c>false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isSealed
				/// </java-name>
				[Dot42.DexImport("isSealed", "()Z", AccessFlags = 1)]
				public virtual bool IsSealed() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Indicates whether this package is sealed with respect to the specified URL.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if this package is sealed with <c>url </c> ; <c>false </c> otherwise </para>
				/// </returns>
				/// <java-name>
				/// isSealed
				/// </java-name>
				[Dot42.DexImport("isSealed", "(Ljava/net/URL;)Z", AccessFlags = 1)]
				public virtual bool IsSealed(global::Java.Net.URL url) /* MethodBuilder.Create */ 
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

				/// <summary>
				///  <para>Returns the title of the implementation of this package, or <c>null </c> if this is unknown. The format of this string is unspecified.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the implementation title, may be <c>null </c> . </para>
				/// </returns>
				/// <java-name>
				/// getImplementationTitle
				/// </java-name>
				public virtual string ImplementationTitle
				{
						[Dot42.DexImport("getImplementationTitle", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>Returns the name of the vendor or organization that provides this implementation of the package, or <c>null </c> if this is unknown. The format of this string is unspecified.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the implementation vendor name, may be <c>null </c> . </para>
				/// </returns>
				/// <java-name>
				/// getImplementationVendor
				/// </java-name>
				public virtual string ImplementationVendor
				{
						[Dot42.DexImport("getImplementationVendor", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>Returns the version of the implementation of this package, or <c>null </c> if this is unknown. The format of this string is unspecified.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the implementation version, may be <c>null </c> . </para>
				/// </returns>
				/// <java-name>
				/// getImplementationVersion
				/// </java-name>
				public virtual string ImplementationVersion
				{
						[Dot42.DexImport("getImplementationVersion", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>Returns the name of this package in the standard dot notation; for example: "java.lang".</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the name of this package. </para>
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
				///  <para>Returns all the packages known to the caller's class loader.</para> <para> <para>ClassLoader::getPackages </para></para>        
				/// </summary>
				/// <returns>
				///  <para>all the packages known to the caller's class loader. </para>
				/// </returns>
				/// <java-name>
				/// getPackages
				/// </java-name>
				public static global::Java.Lang.Package[] Packages
				{
						[Dot42.DexImport("getPackages", "()[Ljava/lang/Package;", AccessFlags = 9)]
						get{ return default(global::Java.Lang.Package[]); }
				}

				/// <summary>
				///  <para>Returns the title of the specification this package implements, or  <c>null </c> if this is unknown.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the specification title, may be <c>null </c> . </para>
				/// </returns>
				/// <java-name>
				/// getSpecificationTitle
				/// </java-name>
				public virtual string SpecificationTitle
				{
						[Dot42.DexImport("getSpecificationTitle", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>Returns the name of the vendor or organization that owns and maintains the specification this package implements, or <c>null </c> if this is unknown.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the specification vendor name, may be <c>null </c> . </para>
				/// </returns>
				/// <java-name>
				/// getSpecificationVendor
				/// </java-name>
				public virtual string SpecificationVendor
				{
						[Dot42.DexImport("getSpecificationVendor", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>Returns the version of the specification this package implements, or  <c>null </c> if this is unknown. The version string is a sequence of non-negative integers separated by dots; for example: "1.2.3".</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the specification version string, may be <c>null </c> . </para>
				/// </returns>
				/// <java-name>
				/// getSpecificationVersion
				/// </java-name>
				public virtual string SpecificationVersion
				{
						[Dot42.DexImport("getSpecificationVersion", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

		}

		/// <summary>
		///  <para>Represents an external process. Enables writing to, reading from, destroying, and waiting for the external process, as well as querying its exit value. Use ProcessBuilder to create processes.</para> <para>The child process writes its output to two streams, <c>out </c> and  <c>err </c> . These streams should be read by the parent process using getInputStream() and getErrorStream() respectively. If these streams are not read, the target process may block while it awaits buffer space. It isn't sufficient to read the streams in sequence; to avoid blocking each of the two streams must have its own reader thread. If you are not interested in differentiating the out and err streams, use redirectErrorStream(true) to merge the two streams. This simplifies your reading code and makes it easier to avoid blocking the target process.</para> <para>Running processes hold resources. When a process is no longer used, the process should be closed by calling destroy. This will kill the process and release the resources that it holds.</para> <para>For example, to run <c>/system/bin/ping </c> to ping <c>android.com </c> :  <pre>Process process = new ProcessBuilder()
		/// 
		///     .command("/system/bin/ping", "android.com")
		/// 
		///     .redirectErrorStream(true)
		/// 
		///     .start();
		/// 
		/// try {
		/// 
		///   InputStream in = process.getInputStream();
		/// 
		///   OutputStream out = process.getOutputStream();
		/// 
		/// 
		/// 
		///   readStream(in);
		/// 
		/// 
		/// 
		/// } finally {
		/// 
		///   process.destroy();
		/// 
		/// }
		/// 
		///  </pre> </para>    
		/// </summary>
		/// <java-name>
		/// java/lang/Process
		/// </java-name>
		[Dot42.DexImport("java/lang/Process", AccessFlags = 1057)]
		public abstract partial class Process
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Process() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Terminates this process and closes any associated streams. </para>        
				/// </summary>
				/// <java-name>
				/// destroy
				/// </java-name>
				[Dot42.DexImport("destroy", "()V", AccessFlags = 1025)]
				public abstract void Destroy() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns the exit value of the native process represented by this object. It is available only when the native process has terminated.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the exit value of this process. </para>
				/// </returns>
				/// <java-name>
				/// exitValue
				/// </java-name>
				[Dot42.DexImport("exitValue", "()I", AccessFlags = 1025)]
				public abstract int ExitValue() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Causes the calling thread to wait for the native process associated with this object to finish executing.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the exit value of the native process being waited on. </para>
				/// </returns>
				/// <java-name>
				/// waitFor
				/// </java-name>
				[Dot42.DexImport("waitFor", "()I", AccessFlags = 1025)]
				public abstract int WaitFor() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns an input stream that is connected to the error stream  <b>(stderr)</b> of the native process represented by this object.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the input stream to read from the error stream associated with the native process. </para>
				/// </returns>
				/// <java-name>
				/// getErrorStream
				/// </java-name>
				public abstract global::Java.IO.InputStream ErrorStream
				{
						[Dot42.DexImport("getErrorStream", "()Ljava/io/InputStream;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Returns an input stream that is connected to the standard output stream  <b>(stdout)</b> of the native process represented by this object.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the input stream to read from the output stream associated with the native process. </para>
				/// </returns>
				/// <java-name>
				/// getInputStream
				/// </java-name>
				public abstract global::Java.IO.InputStream InputStream
				{
						[Dot42.DexImport("getInputStream", "()Ljava/io/InputStream;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Returns an output stream that is connected to the standard input stream  <b>(stdin)</b> of the native process represented by this object.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the output stream to write to the input stream associated with the native process. </para>
				/// </returns>
				/// <java-name>
				/// getOutputStream
				/// </java-name>
				public abstract global::Java.IO.OutputStream OutputStream
				{
						[Dot42.DexImport("getOutputStream", "()Ljava/io/OutputStream;", AccessFlags = 1025)]
						get;
				}

		}

		/// <summary>
		///  <para>Creates operating system processes. See Process for documentation and example usage. </para>    
		/// </summary>
		/// <java-name>
		/// java/lang/ProcessBuilder
		/// </java-name>
		[Dot42.DexImport("java/lang/ProcessBuilder", AccessFlags = 49)]
		public sealed partial class ProcessBuilder
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructs a new <c>ProcessBuilder </c> instance with the specified operating system program and its arguments. Note that the list passed to this constructor is not copied, so any subsequent updates to it are reflected in this instance's state.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "([Ljava/lang/String;)V", AccessFlags = 129)]
				public ProcessBuilder(params string[] command) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new <c>ProcessBuilder </c> instance with the specified operating system program and its arguments. Note that the list passed to this constructor is not copied, so any subsequent updates to it are reflected in this instance's state.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/util/List;)V", AccessFlags = 1, Signature = "(Ljava/util/List<Ljava/lang/String;>;)V")]
				public ProcessBuilder(global::Java.Util.IList<string> command) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns this process builder's current program and arguments. Note that the returned list is not a copy and modifications to it will change the state of this instance.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>this process builder's program and arguments. </para>
				/// </returns>
				/// <java-name>
				/// command
				/// </java-name>
				[Dot42.DexImport("command", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Ljava/lang/String;>;")]
				public global::Java.Util.IList<string> Command() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<string>);
				}

				/// <summary>
				///  <para>Changes the program and arguments of this process builder. Note that the list passed to this method is not copied, so any subsequent updates to it are reflected in this instance's state.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>this process builder instance. </para>
				/// </returns>
				/// <java-name>
				/// command
				/// </java-name>
				[Dot42.DexImport("command", "([Ljava/lang/String;)Ljava/lang/ProcessBuilder;", AccessFlags = 129)]
				public global::Java.Lang.ProcessBuilder Command(params string[] command) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ProcessBuilder);
				}

				/// <summary>
				///  <para>Changes the program and arguments of this process builder. Note that the list passed to this method is not copied, so any subsequent updates to it are reflected in this instance's state.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>this process builder instance. </para>
				/// </returns>
				/// <java-name>
				/// command
				/// </java-name>
				[Dot42.DexImport("command", "(Ljava/util/List;)Ljava/lang/ProcessBuilder;", AccessFlags = 1, Signature = "(Ljava/util/List<Ljava/lang/String;>;)Ljava/lang/ProcessBuilder;")]
				public global::Java.Lang.ProcessBuilder Command(global::Java.Util.IList<string> command) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ProcessBuilder);
				}

				/// <summary>
				///  <para>Returns the working directory of this process builder. If <c>null </c> is returned, then the working directory of the Java process is used when a process is started.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the current working directory, may be <c>null </c> . </para>
				/// </returns>
				/// <java-name>
				/// directory
				/// </java-name>
				[Dot42.DexImport("directory", "()Ljava/io/File;", AccessFlags = 1)]
				public global::Java.IO.File Directory() /* MethodBuilder.Create */ 
				{
						return default(global::Java.IO.File);
				}

				/// <summary>
				///  <para>Changes the working directory of this process builder. If the specified directory is <c>null </c> , then the working directory of the Java process is used when a process is started.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>this process builder instance. </para>
				/// </returns>
				/// <java-name>
				/// directory
				/// </java-name>
				[Dot42.DexImport("directory", "(Ljava/io/File;)Ljava/lang/ProcessBuilder;", AccessFlags = 1)]
				public global::Java.Lang.ProcessBuilder Directory(global::Java.IO.File directory) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ProcessBuilder);
				}

				/// <summary>
				///  <para>Returns this process builder's current environment. When a process builder instance is created, the environment is populated with a copy of the environment, as returned by System#getenv(). Note that the map returned by this method is not a copy and any changes made to it are reflected in this instance's state.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the map containing this process builder's environment variables. </para>
				/// </returns>
				/// <java-name>
				/// environment
				/// </java-name>
				[Dot42.DexImport("environment", "()Ljava/util/Map;", AccessFlags = 1, Signature = "()Ljava/util/Map<Ljava/lang/String;Ljava/lang/String;>;")]
				public global::Java.Util.IMap<string, string> Environment() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IMap<string, string>);
				}

				/// <summary>
				///  <para>Indicates whether the standard error should be redirected to standard output. If redirected, the Process#getErrorStream() will always return end of stream and standard error is written to Process#getInputStream().</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if the standard error is redirected; <c>false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// redirectErrorStream
				/// </java-name>
				[Dot42.DexImport("redirectErrorStream", "()Z", AccessFlags = 1)]
				public bool RedirectErrorStream() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Changes the state of whether or not standard error is redirected to standard output.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>this process builder instance. </para>
				/// </returns>
				/// <java-name>
				/// redirectErrorStream
				/// </java-name>
				[Dot42.DexImport("redirectErrorStream", "(Z)Ljava/lang/ProcessBuilder;", AccessFlags = 1)]
				public global::Java.Lang.ProcessBuilder RedirectErrorStream(bool redirectErrorStream) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ProcessBuilder);
				}

				/// <summary>
				///  <para>Starts a new process based on the current state of this process builder.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the new <c>Process </c> instance. </para>
				/// </returns>
				/// <java-name>
				/// start
				/// </java-name>
				[Dot42.DexImport("start", "()Ljava/lang/Process;", AccessFlags = 1)]
				public global::Java.Lang.Process Start() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.Process);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal ProcessBuilder() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		///  <para>Allows Java applications to interface with the environment in which they are running. Applications can not create an instance of this class, but they can get a singleton instance by invoking getRuntime().</para> <para> <para>System </para></para>    
		/// </summary>
		/// <java-name>
		/// java/lang/Runtime
		/// </java-name>
		[Dot42.DexImport("java/lang/Runtime", AccessFlags = 33)]
		public partial class Runtime
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Prevent this class from being instantiated. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal Runtime() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Executes the specified command and its arguments in a separate native process. The new process inherits the environment of the caller. Calling this method is equivalent to calling <c>exec(progArray, null, null) </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the new <c>Process </c> object that represents the native process. </para>
				/// </returns>
				/// <java-name>
				/// exec
				/// </java-name>
				[Dot42.DexImport("exec", "([Ljava/lang/String;)Ljava/lang/Process;", AccessFlags = 1)]
				public virtual global::Java.Lang.Process Exec(string[] progArray) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.Process);
				}

				/// <summary>
				///  <para>Executes the specified command and its arguments in a separate native process. The new process uses the environment provided in <c>envp </c> . Calling this method is equivalent to calling  <c>exec(progArray, envp, null) </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the new <c>Process </c> object that represents the native process. </para>
				/// </returns>
				/// <java-name>
				/// exec
				/// </java-name>
				[Dot42.DexImport("exec", "([Ljava/lang/String;[Ljava/lang/String;)Ljava/lang/Process;", AccessFlags = 1)]
				public virtual global::Java.Lang.Process Exec(string[] progArray, string[] envp) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.Process);
				}

				/// <summary>
				///  <para>Executes the specified command and its arguments in a separate native process. The new process uses the environment provided in <c>envp </c> and the working directory specified by <c>directory </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the new <c>Process </c> object that represents the native process. </para>
				/// </returns>
				/// <java-name>
				/// exec
				/// </java-name>
				[Dot42.DexImport("exec", "([Ljava/lang/String;[Ljava/lang/String;Ljava/io/File;)Ljava/lang/Process;", AccessFlags = 1)]
				public virtual global::Java.Lang.Process Exec(string[] progArray, string[] envp, global::Java.IO.File directory) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.Process);
				}

				/// <summary>
				///  <para>Executes the specified command and its arguments in a separate native process. The new process inherits the environment of the caller. Calling this method is equivalent to calling <c>exec(progArray, null, null) </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the new <c>Process </c> object that represents the native process. </para>
				/// </returns>
				/// <java-name>
				/// exec
				/// </java-name>
				[Dot42.DexImport("exec", "(Ljava/lang/String;)Ljava/lang/Process;", AccessFlags = 1)]
				public virtual global::Java.Lang.Process Exec(string progArray) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.Process);
				}

				/// <summary>
				///  <para>Executes the specified command and its arguments in a separate native process. The new process uses the environment provided in <c>envp </c> . Calling this method is equivalent to calling  <c>exec(progArray, envp, null) </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the new <c>Process </c> object that represents the native process. </para>
				/// </returns>
				/// <java-name>
				/// exec
				/// </java-name>
				[Dot42.DexImport("exec", "(Ljava/lang/String;[Ljava/lang/String;)Ljava/lang/Process;", AccessFlags = 1)]
				public virtual global::Java.Lang.Process Exec(string progArray, string[] envp) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.Process);
				}

				/// <summary>
				///  <para>Executes the specified command and its arguments in a separate native process. The new process uses the environment provided in <c>envp </c> and the working directory specified by <c>directory </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the new <c>Process </c> object that represents the native process. </para>
				/// </returns>
				/// <java-name>
				/// exec
				/// </java-name>
				[Dot42.DexImport("exec", "(Ljava/lang/String;[Ljava/lang/String;Ljava/io/File;)Ljava/lang/Process;", AccessFlags = 1)]
				public virtual global::Java.Lang.Process Exec(string progArray, string[] envp, global::Java.IO.File directory) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.Process);
				}

				/// <summary>
				///  <para>Causes the VM to stop running and the program to exit. If runFinalizersOnExit(boolean) has been previously invoked with a  <c>true </c> argument, then all objects will be properly garbage-collected and finalized first. Use 0 to signal success to the calling process and 1 to signal failure. This method is unlikely to be useful to an Android application. </para>        
				/// </summary>
				/// <java-name>
				/// exit
				/// </java-name>
				[Dot42.DexImport("exit", "(I)V", AccessFlags = 1)]
				public virtual void Exit(int code) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns the number of bytes currently available on the heap without expanding the heap. See totalMemory for the heap's current size. When these bytes are exhausted, the heap may expand. See maxMemory for that limit. </para>        
				/// </summary>
				/// <java-name>
				/// freeMemory
				/// </java-name>
				[Dot42.DexImport("freeMemory", "()J", AccessFlags = 257)]
				public virtual long FreeMemory() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				///  <para>Indicates to the VM that it would be a good time to run the garbage collector. Note that this is a hint only. There is no guarantee that the garbage collector will actually be run. </para>        
				/// </summary>
				/// <java-name>
				/// gc
				/// </java-name>
				[Dot42.DexImport("gc", "()V", AccessFlags = 257)]
				public virtual void Gc() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns the single <c>Runtime </c> instance for the current application. </para>        
				/// </summary>
				/// <java-name>
				/// getRuntime
				/// </java-name>
				[Dot42.DexImport("getRuntime", "()Ljava/lang/Runtime;", AccessFlags = 9)]
				public static global::Java.Lang.Runtime GetRuntime() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.Runtime);
				}

				/// <summary>
				///  <para>Loads and links the dynamic library that is identified through the specified path. This method is similar to loadLibrary(String), but it accepts a full path specification whereas <c>loadLibrary </c> just accepts the name of the library to load.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// load
				/// </java-name>
				[Dot42.DexImport("load", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void Load(string pathName) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Loads and links the library with the specified name. The mapping of the specified library name to the full path for loading the library is implementation-dependent.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// loadLibrary
				/// </java-name>
				[Dot42.DexImport("loadLibrary", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void LoadLibrary(string libName) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Provides a hint to the VM that it would be useful to attempt to perform any outstanding object finalization. </para>        
				/// </summary>
				/// <java-name>
				/// runFinalization
				/// </java-name>
				[Dot42.DexImport("runFinalization", "()V", AccessFlags = 1)]
				public virtual void RunFinalization() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the flag that indicates whether all objects are finalized when the VM is about to exit. Note that all finalization which occurs when the system is exiting is performed after all running threads have been terminated.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>This method is unsafe. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// runFinalizersOnExit
				/// </java-name>
				[Dot42.DexImport("runFinalizersOnExit", "(Z)V", AccessFlags = 9)]
				public static void RunFinalizersOnExit(bool run) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns the number of bytes taken by the heap at its current size. The heap may expand or contract over time, as the number of live objects increases or decreases. See maxMemory for the maximum heap size, and freeMemory for an idea of how much the heap could currently contract. </para>        
				/// </summary>
				/// <java-name>
				/// totalMemory
				/// </java-name>
				[Dot42.DexImport("totalMemory", "()J", AccessFlags = 257)]
				public virtual long TotalMemory() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				///  <para>Switches the output of debug information for instructions on or off. On Android, this method does nothing. </para>        
				/// </summary>
				/// <java-name>
				/// traceInstructions
				/// </java-name>
				[Dot42.DexImport("traceInstructions", "(Z)V", AccessFlags = 1)]
				public virtual void TraceInstructions(bool enable) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Switches the output of debug information for methods on or off. </para>        
				/// </summary>
				/// <java-name>
				/// traceMethodCalls
				/// </java-name>
				[Dot42.DexImport("traceMethodCalls", "(Z)V", AccessFlags = 1)]
				public virtual void TraceMethodCalls(bool enable) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns the localized version of the specified input stream. The input stream that is returned automatically converts all characters from the local character set to Unicode after reading them from the underlying stream.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use InputStreamReader instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				///  <para>the localized input stream. </para>
				/// </returns>
				/// <java-name>
				/// getLocalizedInputStream
				/// </java-name>
				[Dot42.DexImport("getLocalizedInputStream", "(Ljava/io/InputStream;)Ljava/io/InputStream;", AccessFlags = 1)]
				public virtual global::Java.IO.InputStream GetLocalizedInputStream(global::Java.IO.InputStream stream) /* MethodBuilder.Create */ 
				{
						return default(global::Java.IO.InputStream);
				}

				/// <summary>
				///  <para>Returns the localized version of the specified output stream. The output stream that is returned automatically converts all characters from Unicode to the local character set before writing them to the underlying stream.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use OutputStreamWriter instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				///  <para>the localized output stream. </para>
				/// </returns>
				/// <java-name>
				/// getLocalizedOutputStream
				/// </java-name>
				[Dot42.DexImport("getLocalizedOutputStream", "(Ljava/io/OutputStream;)Ljava/io/OutputStream;", AccessFlags = 1)]
				public virtual global::Java.IO.OutputStream GetLocalizedOutputStream(global::Java.IO.OutputStream stream) /* MethodBuilder.Create */ 
				{
						return default(global::Java.IO.OutputStream);
				}

				/// <summary>
				///  <para>Registers a VM shutdown hook. A shutdown hook is a  <c>Thread </c> that is ready to run, but has not yet been started. All registered shutdown hooks will be executed when the VM terminates normally (typically when the exit(int) method is called).</para> <para> <b>Note that on Android, the application lifecycle does not include VM termination, so calling this method will not ensure that your code is run</b>. Instead, you should use the most appropriate lifecycle notification ( <c>Activity.onPause </c> , say).</para> <para>Shutdown hooks are run concurrently and in an unspecified order. Hooks failing due to an unhandled exception are not a problem, but the stack trace might be printed to the console. Once initiated, the whole shutdown process can only be terminated by calling <c>halt() </c> .</para> <para>If runFinalizersOnExit(boolean) has been called with a <c>true </c> argument, garbage collection and finalization will take place after all hooks are either finished or have failed. Then the VM terminates.</para> <para>It is recommended that shutdown hooks do not do any time-consuming activities, in order to not hold up the shutdown process longer than necessary.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// addShutdownHook
				/// </java-name>
				[Dot42.DexImport("addShutdownHook", "(Ljava/lang/Thread;)V", AccessFlags = 1)]
				public virtual void AddShutdownHook(global::System.Threading.Thread hook) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Unregisters a previously registered VM shutdown hook.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if the hook has been removed successfully; <c>false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// removeShutdownHook
				/// </java-name>
				[Dot42.DexImport("removeShutdownHook", "(Ljava/lang/Thread;)Z", AccessFlags = 1)]
				public virtual bool RemoveShutdownHook(global::System.Threading.Thread hook) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Causes the VM to stop running, and the program to exit with the given return code. Use 0 to signal success to the calling process and 1 to signal failure. Neither shutdown hooks nor finalizers are run before exiting. This method is unlikely to be useful to an Android application. </para>        
				/// </summary>
				/// <java-name>
				/// halt
				/// </java-name>
				[Dot42.DexImport("halt", "(I)V", AccessFlags = 1)]
				public virtual void Halt(int code) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns the number of processor cores available to the VM, at least 1. Traditionally this returned the number currently online, but many mobile devices are able to take unused cores offline to save power, so releases newer than Android 4.2 (Jelly Bean) return the maximum number of cores that could be made available if there were no power or heat constraints. </para>        
				/// </summary>
				/// <java-name>
				/// availableProcessors
				/// </java-name>
				[Dot42.DexImport("availableProcessors", "()I", AccessFlags = 1)]
				public virtual int AvailableProcessors() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Returns the maximum number of bytes the heap can expand to. See totalMemory for the current number of bytes taken by the heap, and freeMemory for the current number of those bytes actually used by live objects. </para>        
				/// </summary>
				/// <java-name>
				/// maxMemory
				/// </java-name>
				[Dot42.DexImport("maxMemory", "()J", AccessFlags = 257)]
				public virtual long MaxMemory() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

		}

		/// <summary>
		///  <para>Legacy security code; do not use. </para>    
		/// </summary>
		/// <java-name>
		/// java/lang/RuntimePermission
		/// </java-name>
		[Dot42.DexImport("java/lang/RuntimePermission", AccessFlags = 49)]
		public sealed partial class RuntimePermission : global::Java.Security.BasicPermission
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public RuntimePermission(string permissionName) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public RuntimePermission(string name, string actions) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal RuntimePermission() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		///  <para>Thrown when a security manager check fails. </para>    
		/// </summary>
		/// <java-name>
		/// java/lang/SecurityException
		/// </java-name>
		[Dot42.DexImport("java/lang/SecurityException", AccessFlags = 33)]
		public partial class SecurityException : global::System.SystemException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructs a new <c>SecurityException </c> that includes the current stack trace. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public SecurityException() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new <c>SecurityException </c> with the current stack trace and the specified detail message.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public SecurityException(string detailMessage) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new <c>SecurityException </c> with the current stack trace, the specified detail message and the specified cause.</para> <para> <para>1.5 </para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public SecurityException(string message, global::System.Exception cause) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new <c>SecurityException </c> with the current stack trace and the specified detail message.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public SecurityException(global::System.Exception detailMessage) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>Legacy security code; do not use.</para> <para>Security managers do  <b>not</b> provide a secure environment for executing untrusted code. Untrusted code cannot be safely isolated within the Dalvik VM. </para>    
		/// </summary>
		/// <java-name>
		/// java/lang/SecurityManager
		/// </java-name>
		[Dot42.DexImport("java/lang/SecurityManager", AccessFlags = 33)]
		public partial class SecurityManager
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use checkPermission instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// inCheck
				/// </java-name>
				[Dot42.DexImport("inCheck", "Z", AccessFlags = 4)]
				protected internal bool @inCheck;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public SecurityManager() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// checkAccept
				/// </java-name>
				[Dot42.DexImport("checkAccept", "(Ljava/lang/String;I)V", AccessFlags = 1)]
				public virtual void CheckAccept(string host, int port) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// checkAccess
				/// </java-name>
				[Dot42.DexImport("checkAccess", "(Ljava/lang/Thread;)V", AccessFlags = 1)]
				public virtual void CheckAccess(global::System.Threading.Thread thread) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// checkAccess
				/// </java-name>
				[Dot42.DexImport("checkAccess", "(Ljava/lang/ThreadGroup;)V", AccessFlags = 1)]
				public virtual void CheckAccess(global::Java.Lang.ThreadGroup thread) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// checkConnect
				/// </java-name>
				[Dot42.DexImport("checkConnect", "(Ljava/lang/String;I)V", AccessFlags = 1)]
				public virtual void CheckConnect(string host, int port) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// checkConnect
				/// </java-name>
				[Dot42.DexImport("checkConnect", "(Ljava/lang/String;ILjava/lang/Object;)V", AccessFlags = 1)]
				public virtual void CheckConnect(string host, int port, object context) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// checkCreateClassLoader
				/// </java-name>
				[Dot42.DexImport("checkCreateClassLoader", "()V", AccessFlags = 1)]
				public virtual void CheckCreateClassLoader() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// checkDelete
				/// </java-name>
				[Dot42.DexImport("checkDelete", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void CheckDelete(string file) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// checkExec
				/// </java-name>
				[Dot42.DexImport("checkExec", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void CheckExec(string cmd) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// checkExit
				/// </java-name>
				[Dot42.DexImport("checkExit", "(I)V", AccessFlags = 1)]
				public virtual void CheckExit(int status) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// checkLink
				/// </java-name>
				[Dot42.DexImport("checkLink", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void CheckLink(string libName) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// checkListen
				/// </java-name>
				[Dot42.DexImport("checkListen", "(I)V", AccessFlags = 1)]
				public virtual void CheckListen(int port) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// checkMemberAccess
				/// </java-name>
				[Dot42.DexImport("checkMemberAccess", "(Ljava/lang/Class;I)V", AccessFlags = 1, Signature = "(Ljava/lang/Class<*>;I)V")]
				public virtual void CheckMemberAccess(global::System.Type cls, int type) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// checkMulticast
				/// </java-name>
				[Dot42.DexImport("checkMulticast", "(Ljava/net/InetAddress;)V", AccessFlags = 1)]
				public virtual void CheckMulticast(global::Java.Net.InetAddress maddr) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>use checkMulticast(java.net.InetAddress) instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// checkMulticast
				/// </java-name>
				[Dot42.DexImport("checkMulticast", "(Ljava/net/InetAddress;B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual void CheckMulticast(global::Java.Net.InetAddress maddr, sbyte ttl) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>use checkMulticast(java.net.InetAddress) instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// checkMulticast
				/// </java-name>
				[Dot42.DexImport("checkMulticast", "(Ljava/net/InetAddress;B)V", AccessFlags = 1)]
				public virtual void CheckMulticast(global::Java.Net.InetAddress maddr, byte ttl) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// checkPackageAccess
				/// </java-name>
				[Dot42.DexImport("checkPackageAccess", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void CheckPackageAccess(string packageName) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// checkPackageDefinition
				/// </java-name>
				[Dot42.DexImport("checkPackageDefinition", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void CheckPackageDefinition(string packageName) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// checkPropertiesAccess
				/// </java-name>
				[Dot42.DexImport("checkPropertiesAccess", "()V", AccessFlags = 1)]
				public virtual void CheckPropertiesAccess() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// checkPropertyAccess
				/// </java-name>
				[Dot42.DexImport("checkPropertyAccess", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void CheckPropertyAccess(string key) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// checkRead
				/// </java-name>
				[Dot42.DexImport("checkRead", "(Ljava/io/FileDescriptor;)V", AccessFlags = 1)]
				public virtual void CheckRead(global::Java.IO.FileDescriptor fd) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// checkRead
				/// </java-name>
				[Dot42.DexImport("checkRead", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void CheckRead(string fd) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// checkRead
				/// </java-name>
				[Dot42.DexImport("checkRead", "(Ljava/lang/String;Ljava/lang/Object;)V", AccessFlags = 1)]
				public virtual void CheckRead(string file, object context) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// checkSecurityAccess
				/// </java-name>
				[Dot42.DexImport("checkSecurityAccess", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void CheckSecurityAccess(string target) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// checkSetFactory
				/// </java-name>
				[Dot42.DexImport("checkSetFactory", "()V", AccessFlags = 1)]
				public virtual void CheckSetFactory() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// checkTopLevelWindow
				/// </java-name>
				[Dot42.DexImport("checkTopLevelWindow", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public virtual bool CheckTopLevelWindow(object window) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// checkSystemClipboardAccess
				/// </java-name>
				[Dot42.DexImport("checkSystemClipboardAccess", "()V", AccessFlags = 1)]
				public virtual void CheckSystemClipboardAccess() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// checkAwtEventQueueAccess
				/// </java-name>
				[Dot42.DexImport("checkAwtEventQueueAccess", "()V", AccessFlags = 1)]
				public virtual void CheckAwtEventQueueAccess() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// checkPrintJobAccess
				/// </java-name>
				[Dot42.DexImport("checkPrintJobAccess", "()V", AccessFlags = 1)]
				public virtual void CheckPrintJobAccess() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// checkWrite
				/// </java-name>
				[Dot42.DexImport("checkWrite", "(Ljava/io/FileDescriptor;)V", AccessFlags = 1)]
				public virtual void CheckWrite(global::Java.IO.FileDescriptor fd) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// checkWrite
				/// </java-name>
				[Dot42.DexImport("checkWrite", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void CheckWrite(string fd) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use checkPermission instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// currentClassLoader
				/// </java-name>
				[Dot42.DexImport("currentClassLoader", "()Ljava/lang/ClassLoader;", AccessFlags = 4)]
				protected internal virtual global::Java.Lang.ClassLoader CurrentClassLoader() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ClassLoader);
				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use checkPermission instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// classLoaderDepth
				/// </java-name>
				[Dot42.DexImport("classLoaderDepth", "()I", AccessFlags = 4)]
				protected internal virtual int ClassLoaderDepth() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use checkPermission instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// currentLoadedClass
				/// </java-name>
				[Dot42.DexImport("currentLoadedClass", "()Ljava/lang/Class;", AccessFlags = 4, Signature = "()Ljava/lang/Class<*>;")]
				protected internal virtual global::System.Type CurrentLoadedClass() /* MethodBuilder.Create */ 
				{
						return default(global::System.Type);
				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use checkPermission instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// classDepth
				/// </java-name>
				[Dot42.DexImport("classDepth", "(Ljava/lang/String;)I", AccessFlags = 4)]
				protected internal virtual int ClassDepth(string name) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use checkPermission instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// inClass
				/// </java-name>
				[Dot42.DexImport("inClass", "(Ljava/lang/String;)Z", AccessFlags = 4)]
				protected internal virtual bool InClass(string name) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use checkPermission instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// inClassLoader
				/// </java-name>
				[Dot42.DexImport("inClassLoader", "()Z", AccessFlags = 4)]
				protected internal virtual bool InClassLoader() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// checkPermission
				/// </java-name>
				[Dot42.DexImport("checkPermission", "(Ljava/security/Permission;)V", AccessFlags = 1)]
				public virtual void CheckPermission(global::Java.Security.Permission permission) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// checkPermission
				/// </java-name>
				[Dot42.DexImport("checkPermission", "(Ljava/security/Permission;Ljava/lang/Object;)V", AccessFlags = 1)]
				public virtual void CheckPermission(global::Java.Security.Permission permission, object context) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use checkPermission instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// getInCheck
				/// </java-name>
				public virtual bool InCheck
				{
						[Dot42.DexImport("getInCheck", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// getClassContext
				/// </java-name>
				protected internal virtual global::System.Type[] ClassContext
				{
						[Dot42.DexImport("getClassContext", "()[Ljava/lang/Class;", AccessFlags = 4)]
						get{ return default(global::System.Type[]); }
				}

				/// <summary>
				///  <para>Returns the current thread's thread group. </para>        
				/// </summary>
				/// <java-name>
				/// getThreadGroup
				/// </java-name>
				public virtual global::Java.Lang.ThreadGroup ThreadGroup
				{
						[Dot42.DexImport("getThreadGroup", "()Ljava/lang/ThreadGroup;", AccessFlags = 1)]
						get{ return default(global::Java.Lang.ThreadGroup); }
				}

				/// <java-name>
				/// getSecurityContext
				/// </java-name>
				public virtual object SecurityContext
				{
						[Dot42.DexImport("getSecurityContext", "()Ljava/lang/Object;", AccessFlags = 1)]
						get{ return default(object); }
				}

		}

		/// <summary>
		///  <para>A representation of a single stack frame. Arrays of <c>StackTraceElement </c> are stored in Throwable objects to represent the whole state of the call stack at the time a <c>Throwable </c> gets thrown.</para> <para> <para>Throwable::getStackTrace() </para></para>    
		/// </summary>
		/// <java-name>
		/// java/lang/StackTraceElement
		/// </java-name>
		[Dot42.DexImport("java/lang/StackTraceElement", AccessFlags = 49)]
		public sealed partial class StackTraceElement : global::Java.IO.ISerializable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructs a new <c>StackTraceElement </c> for a specified execution point.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;I)V", AccessFlags = 1)]
				public StackTraceElement(string cls, string method, string file, int line) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Compares this instance with the specified object and indicates if they are equal. In order to be equal, the following conditions must be fulfilled:  <ul> <li> <para> <c>obj </c> must be a stack trace element, </para></li> <li> <para>the method names of this stack trace element and of <c>obj </c> must not be <c>null </c> , </para></li> <li> <para>the class, method and file names as well as the line number of this stack trace element and of <c>obj </c> must be equal. </para></li></ul></para> <para> <para>hashCode </para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if the specified object is equal to this  <c>StackTraceElement </c> ; <c>false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object obj) /* MethodBuilder.Create */ 
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

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal StackTraceElement() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Returns the fully qualified name of the class belonging to this  <c>StackTraceElement </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the fully qualified type name of the class </para>
				/// </returns>
				/// <java-name>
				/// getClassName
				/// </java-name>
				public string ClassName
				{
						[Dot42.DexImport("getClassName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>Returns the name of the Java source file containing class belonging to this <c>StackTraceElement </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the name of the file, or <c>null </c> if this information is not available. </para>
				/// </returns>
				/// <java-name>
				/// getFileName
				/// </java-name>
				public string FileName
				{
						[Dot42.DexImport("getFileName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>Returns the line number in the source for the class belonging to this  <c>StackTraceElement </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the line number, or a negative number if this information is not available. </para>
				/// </returns>
				/// <java-name>
				/// getLineNumber
				/// </java-name>
				public int LineNumber
				{
						[Dot42.DexImport("getLineNumber", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns the name of the method belonging to this <c>StackTraceElement </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the name of the method, or "&lt;unknown method&gt;" if this information is not available. </para>
				/// </returns>
				/// <java-name>
				/// getMethodName
				/// </java-name>
				public string MethodName
				{
						[Dot42.DexImport("getMethodName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>Indicates if the method name returned by getMethodName() is implemented as a native method.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if the method in which this stack trace element is executing is a native method; <c>false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isNativeMethod
				/// </java-name>
				public bool IsNativeMethod
				{
						[Dot42.DexImport("isNativeMethod", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

		}

		/// <summary>
		///  <para>Class StrictMath provides basic math constants and operations such as trigonometric functions, hyperbolic functions, exponential, logarithms, etc. </para> <para>In contrast to class Math, the methods in this class return exactly the same results on all platforms. Algorithms based on these methods thus behave the same (e.g. regarding numerical convergence) on all platforms, complying with the slogan "write once, run everywhere". On the other side, the implementation of class StrictMath may be less efficient than that of class Math, as class StrictMath cannot utilize platform specific features such as an extended precision math co-processors. </para> <para>The methods in this class are specified using the "Freely Distributable MathLibrary" (fdlibm), version 5.3. </para> <para> </para>    
		/// </summary>
		/// <java-name>
		/// java/lang/StrictMath
		/// </java-name>
		[Dot42.DexImport("java/lang/StrictMath", AccessFlags = 49)]
		public sealed partial class StrictMath
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>The double value closest to e, the base of the natural logarithm. </para>        
				/// </summary>
				/// <java-name>
				/// E
				/// </java-name>
				[Dot42.DexImport("E", "D", AccessFlags = 25)]
				public const double E = 2.7182818284590451D;
				/// <summary>
				///  <para>The double value closest to pi, the ratio of a circle's circumference to its diameter. </para>        
				/// </summary>
				/// <java-name>
				/// PI
				/// </java-name>
				[Dot42.DexImport("PI", "D", AccessFlags = 25)]
				public const double PI = 3.1415926535897931D;
				/// <summary>
				///  <para>Prevents this class from being instantiated. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal StrictMath() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns the absolute value of the argument. </para> <para>Special cases:  <ul> <li> <para> <c>abs(-0.0) = +0.0 </c>  </para></li> <li> <para> <c>abs(+infinity) = +infinity </c>  </para></li> <li> <para> <c>abs(-infinity) = +infinity </c>  </para></li> <li> <para> <c>abs(NaN) = NaN </c>  </para></li></ul></para>        
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
				///  <para>Returns the absolute value of the argument. </para> <para>Special cases:  <ul> <li> <para> <c>abs(-0.0) = +0.0 </c>  </para></li> <li> <para> <c>abs(+infinity) = +infinity </c>  </para></li> <li> <para> <c>abs(-infinity) = +infinity </c>  </para></li> <li> <para> <c>abs(NaN) = NaN </c>  </para></li></ul></para>        
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
				///  <para>Returns the absolute value of the argument. </para> <para>Special cases:  <ul> <li> <para> <c>abs(-0.0) = +0.0 </c>  </para></li> <li> <para> <c>abs(+infinity) = +infinity </c>  </para></li> <li> <para> <c>abs(-infinity) = +infinity </c>  </para></li> <li> <para> <c>abs(NaN) = NaN </c>  </para></li></ul></para>        
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
				///  <para>Returns the absolute value of the argument. </para> <para>Special cases:  <ul> <li> <para> <c>abs(-0.0) = +0.0 </c>  </para></li> <li> <para> <c>abs(+infinity) = +infinity </c>  </para></li> <li> <para> <c>abs(-infinity) = +infinity </c>  </para></li> <li> <para> <c>abs(NaN) = NaN </c>  </para></li></ul></para>        
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
				///  <para>Returns the closest double approximation of the arc cosine of the argument within the range <c>[0..pi] </c> . </para> <para>Special cases:  <ul> <li> <para> <c>acos((anything &gt; 1) = NaN </c>  </para></li> <li> <para> <c>acos((anything &lt; -1) = NaN </c>  </para></li> <li> <para> <c>acos(NaN) = NaN </c>  </para></li></ul></para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the arc cosine of the argument. </para>
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
				///  <para>Returns the closest double approximation of the arc sine of the argument within the range <c>[-pi/2..pi/2] </c> . </para> <para>Special cases:  <ul> <li> <para> <c>asin((anything &gt; 1)) = NaN </c>  </para></li> <li> <para> <c>asin((anything &lt; -1)) = NaN </c>  </para></li> <li> <para> <c>asin(NaN) = NaN </c>  </para></li></ul></para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the arc sine of the argument. </para>
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
				///  <para>Returns the closest double approximation of the arc tangent of the argument within the range <c>[-pi/2..pi/2] </c> . </para> <para>Special cases:  <ul> <li> <para> <c>atan(+0.0) = +0.0 </c>  </para></li> <li> <para> <c>atan(-0.0) = -0.0 </c>  </para></li> <li> <para> <c>atan(+infinity) = +pi/2 </c>  </para></li> <li> <para> <c>atan(-infinity) = -pi/2 </c>  </para></li> <li> <para> <c>atan(NaN) = NaN </c>  </para></li></ul></para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the arc tangent of the argument. </para>
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
				///  <para>Returns the closest double approximation of the arc tangent of  <c>y/x </c> within the range <c>[-pi..pi] </c> . This is the angle of the polar representation of the rectangular coordinates (x,y). </para> <para>Special cases:  <ul> <li> <para> <c>atan2((anything), NaN ) = NaN; </c>  </para></li> <li> <para> <c>atan2(NaN , (anything) ) = NaN; </c>  </para></li> <li> <para> <c>atan2(+0.0, +(anything but NaN)) = +0.0 </c>  </para></li> <li> <para> <c>atan2(-0.0, +(anything but NaN)) = -0.0 </c>  </para></li> <li> <para> <c>atan2(+0.0, -(anything but NaN)) = +pi </c>  </para></li> <li> <para> <c>atan2(-0.0, -(anything but NaN)) = -pi </c>  </para></li> <li> <para> <c>atan2(+(anything but 0 and NaN), 0) = +pi/2 </c>  </para></li> <li> <para> <c>atan2(-(anything but 0 and NaN), 0) = -pi/2 </c>  </para></li> <li> <para> <c>atan2(+(anything but infinity and NaN), +infinity) </c> <c>= </c>  <c>+0.0 </c>  </para></li> <li> <para> <c>atan2(-(anything but infinity and NaN), +infinity) </c> <c>= </c>  <c>-0.0 </c>  </para></li> <li> <para> <c>atan2(+(anything but infinity and NaN), -infinity) = +pi </c>  </para></li> <li> <para> <c>atan2(-(anything but infinity and NaN), -infinity) = -pi </c>  </para></li> <li> <para> <c>atan2(+infinity, +infinity ) = +pi/4 </c>  </para></li> <li> <para> <c>atan2(-infinity, +infinity ) = -pi/4 </c>  </para></li> <li> <para> <c>atan2(+infinity, -infinity ) = +3pi/4 </c>  </para></li> <li> <para> <c>atan2(-infinity, -infinity ) = -3pi/4 </c>  </para></li> <li> <para> <c>atan2(+infinity, (anything but,0, NaN, and infinity)) </c>  <c>= </c> <c>+pi/2 </c>  </para></li> <li> <para> <c>atan2(-infinity, (anything but,0, NaN, and infinity)) </c>  <c>= </c> <c>-pi/2 </c>  </para></li></ul></para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the arc tangent of <c>y/x </c> . </para>
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
				///  <para>Returns the closest double approximation of the cube root of the argument. </para> <para>Special cases:  <ul> <li> <para> <c>cbrt(+0.0) = +0.0 </c>  </para></li> <li> <para> <c>cbrt(-0.0) = -0.0 </c>  </para></li> <li> <para> <c>cbrt(+infinity) = +infinity </c>  </para></li> <li> <para> <c>cbrt(-infinity) = -infinity </c>  </para></li> <li> <para> <c>cbrt(NaN) = NaN </c>  </para></li></ul></para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the cube root of the argument. </para>
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
				///  <para>Returns the double conversion of the most negative (closest to negative infinity) integer value greater than or equal to the argument. </para> <para>Special cases:  <ul> <li> <para> <c>ceil(+0.0) = +0.0 </c>  </para></li> <li> <para> <c>ceil(-0.0) = -0.0 </c>  </para></li> <li> <para> <c>ceil((anything in range (-1,0)) = -0.0 </c>  </para></li> <li> <para> <c>ceil(+infinity) = +infinity </c>  </para></li> <li> <para> <c>ceil(-infinity) = -infinity </c>  </para></li> <li> <para> <c>ceil(NaN) = NaN </c>  </para></li></ul></para>        
				/// </summary>
				/// <java-name>
				/// ceil
				/// </java-name>
				[Dot42.DexImport("ceil", "(D)D", AccessFlags = 265)]
				public static double Ceil(double d) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <summary>
				///  <para>Returns the closest double approximation of the hyperbolic cosine of the argument. </para> <para>Special cases:  <ul> <li> <para> <c>cosh(+infinity) = +infinity </c>  </para></li> <li> <para> <c>cosh(-infinity) = +infinity </c>  </para></li> <li> <para> <c>cosh(NaN) = NaN </c>  </para></li></ul></para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the hyperbolic cosine of the argument. </para>
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
				///  <para>Returns the closest double approximation of the cosine of the argument. </para> <para>Special cases:  <ul> <li> <para> <c>cos(+infinity) = NaN </c>  </para></li> <li> <para> <c>cos(-infinity) = NaN </c>  </para></li> <li> <para> <c>cos(NaN) = NaN </c>  </para></li></ul></para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the cosine of the argument. </para>
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
				///  <para>Returns the closest double approximation of the raising "e" to the power of the argument. </para> <para>Special cases:  <ul> <li> <para> <c>exp(+infinity) = +infinity </c>  </para></li> <li> <para> <c>exp(-infinity) = +0.0 </c>  </para></li> <li> <para> <c>exp(NaN) = NaN </c>  </para></li></ul></para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the exponential of the argument. </para>
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
				///  <para>Returns the closest double approximation of  <b> <c>e </c> </b> <span>  <c>d </c> </span> <c>- 1 </c> . If the argument is very close to 0, it is much more accurate to use <c>expm1(d)+1 </c> than <c>exp(d) </c> (due to cancellation of significant digits). </para> <para>Special cases:  <ul> <li> <para> <c>expm1(+0.0) = +0.0 </c>  </para></li> <li> <para> <c>expm1(-0.0) = -0.0 </c>  </para></li> <li> <para> <c>expm1(+infinity) = +infinity </c>  </para></li> <li> <para> <c>expm1(-infinity) = -1.0 </c>  </para></li> <li> <para> <c>expm1(NaN) = NaN </c>  </para></li></ul></para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the  <b> <c>e </c> </b> <span> <c>d </c> </span> <c>- 1 </c> value of the argument. </para>
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
				///  <para>Returns the double conversion of the most positive (closest to positive infinity) integer less than or equal to the argument. </para> <para>Special cases:  <ul> <li> <para> <c>floor(+0.0) = +0.0 </c>  </para></li> <li> <para> <c>floor(-0.0) = -0.0 </c>  </para></li> <li> <para> <c>floor(+infinity) = +infinity </c>  </para></li> <li> <para> <c>floor(-infinity) = -infinity </c>  </para></li> <li> <para> <c>floor(NaN) = NaN </c>  </para></li></ul></para>        
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
				///  <para>Returns <c>sqrt( </c>  <b> <c>x </c> </b> <span> <c>2 </c> </span> <c>+ </c>  <b> <c>y </c> </b> <span> <c>2 </c> </span> <c>) </c> . The final result is without medium underflow or overflow. </para> <para>Special cases:  <ul> <li> <para> <c>hypot(+infinity, (anything including NaN)) = +infinity </c>  </para></li> <li> <para> <c>hypot(-infinity, (anything including NaN)) = +infinity </c>  </para></li> <li> <para> <c>hypot((anything including NaN), +infinity) = +infinity </c>  </para></li> <li> <para> <c>hypot((anything including NaN), -infinity) = +infinity </c>  </para></li> <li> <para> <c>hypot(NaN, NaN) = NaN </c>  </para></li></ul></para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the <c>sqrt( </c>  <b> <c>x </c> </b> <span> <c>2 </c> </span> <c>+ </c>  <b> <c>y </c> </b> <span> <c>2 </c> </span> <c>) </c> value of the arguments. </para>
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
				///  <para>Returns the remainder of dividing <c>x </c> by <c>y </c> using the IEEE 754 rules. The result is <c>x-round(x/p)*p </c> where <c>round(x/p) </c> is the nearest integer (rounded to even), but without numerical cancellation problems. </para> <para>Special cases:  <ul> <li> <para> <c>IEEEremainder((anything), 0) = NaN </c>  </para></li> <li> <para> <c>IEEEremainder(+infinity, (anything)) = NaN </c>  </para></li> <li> <para> <c>IEEEremainder(-infinity, (anything)) = NaN </c>  </para></li> <li> <para> <c>IEEEremainder(NaN, (anything)) = NaN </c>  </para></li> <li> <para> <c>IEEEremainder((anything), NaN) = NaN </c>  </para></li> <li> <para> <c>IEEEremainder(x, +infinity) = x  </c> where x is anything but +/-infinity </para></li> <li> <para> <c>IEEEremainder(x, -infinity) = x  </c> where x is anything but +/-infinity </para></li></ul></para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the IEEE754 floating point reminder of of <c>x/y </c> . </para>
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
				///  <para>Returns the closest double approximation of the natural logarithm of the argument. </para> <para>Special cases:  <ul> <li> <para> <c>log(+0.0) = -infinity </c>  </para></li> <li> <para> <c>log(-0.0) = -infinity </c>  </para></li> <li> <para> <c>log((anything &lt; 0) = NaN </c>  </para></li> <li> <para> <c>log(+infinity) = +infinity </c>  </para></li> <li> <para> <c>log(-infinity) = NaN </c>  </para></li> <li> <para> <c>log(NaN) = NaN </c>  </para></li></ul></para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the natural logarithm of the argument. </para>
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
				///  <para>Returns the closest double approximation of the base 10 logarithm of the argument. </para> <para>Special cases:  <ul> <li> <para> <c>log10(+0.0) = -infinity </c>  </para></li> <li> <para> <c>log10(-0.0) = -infinity </c>  </para></li> <li> <para> <c>log10((anything &lt; 0) = NaN </c>  </para></li> <li> <para> <c>log10(+infinity) = +infinity </c>  </para></li> <li> <para> <c>log10(-infinity) = NaN </c>  </para></li> <li> <para> <c>log10(NaN) = NaN </c>  </para></li></ul></para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the natural logarithm of the argument. </para>
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
				///  <para>Returns the closest double approximation of the natural logarithm of the sum of the argument and 1. If the argument is very close to 0, it is much more accurate to use <c>log1p(d) </c> than <c>log(1.0+d) </c> (due to numerical cancellation). </para> <para>Special cases:  <ul> <li> <para> <c>log1p(+0.0) = +0.0 </c>  </para></li> <li> <para> <c>log1p(-0.0) = -0.0 </c>  </para></li> <li> <para> <c>log1p((anything &lt; 1)) = NaN </c>  </para></li> <li> <para> <c>log1p(-1.0) = -infinity </c>  </para></li> <li> <para> <c>log1p(+infinity) = +infinity </c>  </para></li> <li> <para> <c>log1p(-infinity) = NaN </c>  </para></li> <li> <para> <c>log1p(NaN) = NaN </c>  </para></li></ul></para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the natural logarithm of the sum of the argument and 1. </para>
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
				///  <para>Returns the most positive (closest to positive infinity) of the two arguments. </para> <para>Special cases:  <ul> <li> <para> <c>max(NaN, (anything)) = NaN </c>  </para></li> <li> <para> <c>max((anything), NaN) = NaN </c>  </para></li> <li> <para> <c>max(+0.0, -0.0) = +0.0 </c>  </para></li> <li> <para> <c>max(-0.0, +0.0) = +0.0 </c>  </para></li></ul></para>        
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
				///  <para>Returns the most positive (closest to positive infinity) of the two arguments. </para> <para>Special cases:  <ul> <li> <para> <c>max(NaN, (anything)) = NaN </c>  </para></li> <li> <para> <c>max((anything), NaN) = NaN </c>  </para></li> <li> <para> <c>max(+0.0, -0.0) = +0.0 </c>  </para></li> <li> <para> <c>max(-0.0, +0.0) = +0.0 </c>  </para></li></ul></para>        
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
				///  <para>Returns the most positive (closest to positive infinity) of the two arguments. </para> <para>Special cases:  <ul> <li> <para> <c>max(NaN, (anything)) = NaN </c>  </para></li> <li> <para> <c>max((anything), NaN) = NaN </c>  </para></li> <li> <para> <c>max(+0.0, -0.0) = +0.0 </c>  </para></li> <li> <para> <c>max(-0.0, +0.0) = +0.0 </c>  </para></li></ul></para>        
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
				///  <para>Returns the most positive (closest to positive infinity) of the two arguments. </para> <para>Special cases:  <ul> <li> <para> <c>max(NaN, (anything)) = NaN </c>  </para></li> <li> <para> <c>max((anything), NaN) = NaN </c>  </para></li> <li> <para> <c>max(+0.0, -0.0) = +0.0 </c>  </para></li> <li> <para> <c>max(-0.0, +0.0) = +0.0 </c>  </para></li></ul></para>        
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
				///  <para>Returns the most negative (closest to negative infinity) of the two arguments. </para> <para>Special cases:  <ul> <li> <para> <c>min(NaN, (anything)) = NaN </c>  </para></li> <li> <para> <c>min((anything), NaN) = NaN </c>  </para></li> <li> <para> <c>min(+0.0, -0.0) = -0.0 </c>  </para></li> <li> <para> <c>min(-0.0, +0.0) = -0.0 </c>  </para></li></ul></para>        
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
				///  <para>Returns the most negative (closest to negative infinity) of the two arguments. </para> <para>Special cases:  <ul> <li> <para> <c>min(NaN, (anything)) = NaN </c>  </para></li> <li> <para> <c>min((anything), NaN) = NaN </c>  </para></li> <li> <para> <c>min(+0.0, -0.0) = -0.0 </c>  </para></li> <li> <para> <c>min(-0.0, +0.0) = -0.0 </c>  </para></li></ul></para>        
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
				///  <para>Returns the most negative (closest to negative infinity) of the two arguments. </para> <para>Special cases:  <ul> <li> <para> <c>min(NaN, (anything)) = NaN </c>  </para></li> <li> <para> <c>min((anything), NaN) = NaN </c>  </para></li> <li> <para> <c>min(+0.0, -0.0) = -0.0 </c>  </para></li> <li> <para> <c>min(-0.0, +0.0) = -0.0 </c>  </para></li></ul></para>        
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
				///  <para>Returns the most negative (closest to negative infinity) of the two arguments. </para> <para>Special cases:  <ul> <li> <para> <c>min(NaN, (anything)) = NaN </c>  </para></li> <li> <para> <c>min((anything), NaN) = NaN </c>  </para></li> <li> <para> <c>min(+0.0, -0.0) = -0.0 </c>  </para></li> <li> <para> <c>min(-0.0, +0.0) = -0.0 </c>  </para></li></ul></para>        
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
				///  <para>Returns the closest double approximation of the result of raising  <c>x </c> to the power of <c>y </c> . </para> <para>Special cases:  <ul> <li> <para> <c>pow((anything), +0.0) = 1.0 </c>  </para></li> <li> <para> <c>pow((anything), -0.0) = 1.0 </c>  </para></li> <li> <para> <c>pow(x, 1.0) = x </c>  </para></li> <li> <para> <c>pow((anything), NaN) = NaN </c>  </para></li> <li> <para> <c>pow(NaN, (anything except 0)) = NaN </c>  </para></li> <li> <para> <c>pow(+/-(|x| &gt; 1), +infinity) = +infinity </c>  </para></li> <li> <para> <c>pow(+/-(|x| &gt; 1), -infinity) = +0.0 </c>  </para></li> <li> <para> <c>pow(+/-(|x| &lt; 1), +infinity) = +0.0 </c>  </para></li> <li> <para> <c>pow(+/-(|x| &lt; 1), -infinity) = +infinity </c>  </para></li> <li> <para> <c>pow(+/-1.0 , +infinity) = NaN </c>  </para></li> <li> <para> <c>pow(+/-1.0 , -infinity) = NaN </c>  </para></li> <li> <para> <c>pow(+0.0, (+anything except 0, NaN)) = +0.0 </c>  </para></li> <li> <para> <c>pow(-0.0, (+anything except 0, NaN, odd integer)) = +0.0 </c>  </para></li> <li> <para> <c>pow(+0.0, (-anything except 0, NaN)) = +infinity </c>  </para></li> <li> <para> <c>pow(-0.0, (-anything except 0, NAN, odd integer)) </c> <c>= </c>  <c>+infinity </c>  </para></li> <li> <para> <c>pow(-0.0, (odd integer)) = -pow( +0 , (odd integer) ) </c>  </para></li> <li> <para> <c>pow(+infinity, (+anything except 0, NaN)) = +infinity </c>  </para></li> <li> <para> <c>pow(+infinity, (-anything except 0, NaN)) = +0.0 </c>  </para></li> <li> <para> <c>pow(-infinity, (anything)) = -pow(0, (-anything)) </c>  </para></li> <li> <para> <c>pow((-anything), (integer)) </c> <c>= </c>  <c>pow(-1,(integer))*pow(+anything,integer) </c>  </para></li> <li> <para> <c>pow((-anything except 0 and infinity), (non-integer)) </c>  <c>= </c> <c>NAN </c>  </para></li></ul></para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>x </c> to the power of <c>y </c> . </para>
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
				///  <para>Returns a pseudo-random number between 0.0 (inclusive) and 1.0 (exclusive).</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a pseudo-random number. </para>
				/// </returns>
				/// <java-name>
				/// random
				/// </java-name>
				[Dot42.DexImport("random", "()D", AccessFlags = 9)]
				public static double Random() /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <summary>
				///  <para>Returns the double conversion of the result of rounding the argument to an integer. Tie breaks are rounded towards even. </para> <para>Special cases:  <ul> <li> <para> <c>rint(+0.0) = +0.0 </c>  </para></li> <li> <para> <c>rint(-0.0) = -0.0 </c>  </para></li> <li> <para> <c>rint(+infinity) = +infinity </c>  </para></li> <li> <para> <c>rint(-infinity) = -infinity </c>  </para></li> <li> <para> <c>rint(NaN) = NaN </c>  </para></li></ul></para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the closest integer to the argument (as a double). </para>
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
				///  <para>Returns the result of rounding the argument to an integer. The result is equivalent to <c>(long) Math.floor(d+0.5) </c> . </para> <para>Special cases:  <ul> <li> <para> <c>round(+0.0) = +0.0 </c>  </para></li> <li> <para> <c>round(-0.0) = +0.0 </c>  </para></li> <li> <para> <c>round((anything &gt; Long.MAX_VALUE) = Long.MAX_VALUE </c>  </para></li> <li> <para> <c>round((anything &lt; Long.MIN_VALUE) = Long.MIN_VALUE </c>  </para></li> <li> <para> <c>round(+infinity) = Long.MAX_VALUE </c>  </para></li> <li> <para> <c>round(-infinity) = Long.MIN_VALUE </c>  </para></li> <li> <para> <c>round(NaN) = +0.0 </c>  </para></li></ul></para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the closest integer to the argument. </para>
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
				///  <para>Returns the result of rounding the argument to an integer. The result is equivalent to <c>(long) Math.floor(d+0.5) </c> . </para> <para>Special cases:  <ul> <li> <para> <c>round(+0.0) = +0.0 </c>  </para></li> <li> <para> <c>round(-0.0) = +0.0 </c>  </para></li> <li> <para> <c>round((anything &gt; Long.MAX_VALUE) = Long.MAX_VALUE </c>  </para></li> <li> <para> <c>round((anything &lt; Long.MIN_VALUE) = Long.MIN_VALUE </c>  </para></li> <li> <para> <c>round(+infinity) = Long.MAX_VALUE </c>  </para></li> <li> <para> <c>round(-infinity) = Long.MIN_VALUE </c>  </para></li> <li> <para> <c>round(NaN) = +0.0 </c>  </para></li></ul></para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the closest integer to the argument. </para>
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
				///  <para>Returns the signum function of the argument. If the argument is less than zero, it returns -1.0. If the argument is greater than zero, 1.0 is returned. If the argument is either positive or negative zero, the argument is returned as result. </para> <para>Special cases:  <ul> <li> <para> <c>signum(+0.0) = +0.0 </c>  </para></li> <li> <para> <c>signum(-0.0) = -0.0 </c>  </para></li> <li> <para> <c>signum(+infinity) = +1.0 </c>  </para></li> <li> <para> <c>signum(-infinity) = -1.0 </c>  </para></li> <li> <para> <c>signum(NaN) = NaN </c>  </para></li></ul></para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the value of the signum function. </para>
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
				///  <para>Returns the signum function of the argument. If the argument is less than zero, it returns -1.0. If the argument is greater than zero, 1.0 is returned. If the argument is either positive or negative zero, the argument is returned as result. </para> <para>Special cases:  <ul> <li> <para> <c>signum(+0.0) = +0.0 </c>  </para></li> <li> <para> <c>signum(-0.0) = -0.0 </c>  </para></li> <li> <para> <c>signum(+infinity) = +1.0 </c>  </para></li> <li> <para> <c>signum(-infinity) = -1.0 </c>  </para></li> <li> <para> <c>signum(NaN) = NaN </c>  </para></li></ul></para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the value of the signum function. </para>
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
				///  <para>Returns the closest double approximation of the hyperbolic sine of the argument. </para> <para>Special cases:  <ul> <li> <para> <c>sinh(+0.0) = +0.0 </c>  </para></li> <li> <para> <c>sinh(-0.0) = -0.0 </c>  </para></li> <li> <para> <c>sinh(+infinity) = +infinity </c>  </para></li> <li> <para> <c>sinh(-infinity) = -infinity </c>  </para></li> <li> <para> <c>sinh(NaN) = NaN </c>  </para></li></ul></para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the hyperbolic sine of the argument. </para>
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
				///  <para>Returns the closest double approximation of the sine of the argument. </para> <para>Special cases:  <ul> <li> <para> <c>sin(+0.0) = +0.0 </c>  </para></li> <li> <para> <c>sin(-0.0) = -0.0 </c>  </para></li> <li> <para> <c>sin(+infinity) = NaN </c>  </para></li> <li> <para> <c>sin(-infinity) = NaN </c>  </para></li> <li> <para> <c>sin(NaN) = NaN </c>  </para></li></ul></para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the sine of the argument. </para>
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
				///  <para>Returns the closest double approximation of the square root of the argument. </para> <para>Special cases:  <ul> <li> <para> <c>sqrt(+0.0) = +0.0 </c>  </para></li> <li> <para> <c>sqrt(-0.0) = -0.0 </c>  </para></li> <li> <para> <c>sqrt( (anything &lt; 0) ) = NaN </c>  </para></li> <li> <para> <c>sqrt(+infinity) = +infinity </c>  </para></li> <li> <para> <c>sqrt(NaN) = NaN </c>  </para></li></ul></para>        
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
				///  <para>Returns the closest double approximation of the tangent of the argument. </para> <para>Special cases:  <ul> <li> <para> <c>tan(+0.0) = +0.0 </c>  </para></li> <li> <para> <c>tan(-0.0) = -0.0 </c>  </para></li> <li> <para> <c>tan(+infinity) = NaN </c>  </para></li> <li> <para> <c>tan(-infinity) = NaN </c>  </para></li> <li> <para> <c>tan(NaN) = NaN </c>  </para></li></ul></para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the tangent of the argument. </para>
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
				///  <para>Returns the closest double approximation of the hyperbolic tangent of the argument. The absolute value is always less than 1. </para> <para>Special cases:  <ul> <li> <para> <c>tanh(+0.0) = +0.0 </c>  </para></li> <li> <para> <c>tanh(-0.0) = -0.0 </c>  </para></li> <li> <para> <c>tanh(+infinity) = +1.0 </c>  </para></li> <li> <para> <c>tanh(-infinity) = -1.0 </c>  </para></li> <li> <para> <c>tanh(NaN) = NaN </c>  </para></li></ul></para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the hyperbolic tangent of the argument </para>
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
				///  <para>Returns the measure in degrees of the supplied radian angle. The result is <c>angrad * 180 / pi </c> . </para> <para>Special cases:  <ul> <li> <para> <c>toDegrees(+0.0) = +0.0 </c>  </para></li> <li> <para> <c>toDegrees(-0.0) = -0.0 </c>  </para></li> <li> <para> <c>toDegrees(+infinity) = +infinity </c>  </para></li> <li> <para> <c>toDegrees(-infinity) = -infinity </c>  </para></li> <li> <para> <c>toDegrees(NaN) = NaN </c>  </para></li></ul></para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the degree measure of the angle. </para>
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
				///  <para>Returns the measure in radians of the supplied degree angle. The result is <c>angdeg / 180 * pi </c> . </para> <para>Special cases:  <ul> <li> <para> <c>toRadians(+0.0) = +0.0 </c>  </para></li> <li> <para> <c>toRadians(-0.0) = -0.0 </c>  </para></li> <li> <para> <c>toRadians(+infinity) = +infinity </c>  </para></li> <li> <para> <c>toRadians(-infinity) = -infinity </c>  </para></li> <li> <para> <c>toRadians(NaN) = NaN </c>  </para></li></ul></para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the radian measure of the angle. </para>
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
				///  <para>Returns the argument's ulp (unit in the last place). The size of a ulp of a double value is the positive distance between this value and the double value next larger in magnitude. For non-NaN <c>x </c> ,  <c>ulp(-x) == ulp(x) </c> . </para> <para>Special cases:  <ul> <li> <para> <c>ulp(+0.0) = Double.MIN_VALUE </c>  </para></li> <li> <para> <c>ulp(-0.0) = Double.MIN_VALUE </c>  </para></li> <li> <para> <c>ulp(+infinity) = infinity </c>  </para></li> <li> <para> <c>ulp(-infinity) = infinity </c>  </para></li> <li> <para> <c>ulp(NaN) = NaN </c>  </para></li></ul></para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the size of a ulp of the argument. </para>
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
				///  <para>Returns the argument's ulp (unit in the last place). The size of a ulp of a double value is the positive distance between this value and the double value next larger in magnitude. For non-NaN <c>x </c> ,  <c>ulp(-x) == ulp(x) </c> . </para> <para>Special cases:  <ul> <li> <para> <c>ulp(+0.0) = Double.MIN_VALUE </c>  </para></li> <li> <para> <c>ulp(-0.0) = Double.MIN_VALUE </c>  </para></li> <li> <para> <c>ulp(+infinity) = infinity </c>  </para></li> <li> <para> <c>ulp(-infinity) = infinity </c>  </para></li> <li> <para> <c>ulp(NaN) = NaN </c>  </para></li></ul></para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the size of a ulp of the argument. </para>
				/// </returns>
				/// <java-name>
				/// ulp
				/// </java-name>
				[Dot42.DexImport("ulp", "(F)F", AccessFlags = 9)]
				public static float Ulp(float d) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

		}

		/// <summary>
		///  <para>A modifiable sequence of characters for use in creating strings, where all accesses are synchronized. This class has mostly been replaced by StringBuilder because this synchronization is rarely useful. This class is mainly used to interact with legacy APIs that expose it.</para> <para>For particularly complex string-building needs, consider java.util.Formatter.</para> <para>The majority of the modification methods on this class return <c>this </c> so that method calls can be chained together. For example:  <c>new StringBuffer("a").append("b").append("c").toString() </c> .</para> <para> <para>CharSequence </para> <para>Appendable </para> <para>StringBuilder </para> <para>String </para> <para>String::format </para> <para>1.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// java/lang/StringBuffer
		/// </java-name>
		[Dot42.DexImport("java/lang/StringBuffer", AccessFlags = 49)]
		public sealed partial class StringBuffer : global::Java.Lang.IAppendable, global::Java.IO.ISerializable, global::Java.Lang.ICharSequence
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructs a new StringBuffer using the default capacity which is 16. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public StringBuffer() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new StringBuffer using the specified capacity.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public StringBuffer(int capacity) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new StringBuffer using the specified capacity.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public StringBuffer(string capacity) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new StringBuffer using the specified capacity.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/CharSequence;)V", AccessFlags = 1)]
				public StringBuffer(global::Java.Lang.ICharSequence capacity) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Adds the string representation of the specified boolean to the end of this StringBuffer. </para> <para>If the argument is <c>true </c> the string <c>"true" </c> is appended, otherwise the string <c>"false" </c> is appended.</para> <para> <para>String::valueOf(boolean) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>this StringBuffer. </para>
				/// </returns>
				/// <java-name>
				/// append
				/// </java-name>
				[Dot42.DexImport("append", "(Z)Ljava/lang/StringBuffer;", AccessFlags = 1)]
				public global::Java.Lang.StringBuffer Append(bool b) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.StringBuffer);
				}

				/// <summary>
				///  <para>Adds the string representation of the specified boolean to the end of this StringBuffer. </para> <para>If the argument is <c>true </c> the string <c>"true" </c> is appended, otherwise the string <c>"false" </c> is appended.</para> <para> <para>String::valueOf(boolean) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>this StringBuffer. </para>
				/// </returns>
				/// <java-name>
				/// append
				/// </java-name>
				[Dot42.DexImport("append", "(C)Ljava/lang/StringBuffer;", AccessFlags = 33)]
				public global::Java.Lang.StringBuffer Append(char b) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.StringBuffer);
				}

				/// <summary>
				///  <para>Adds the string representation of the specified boolean to the end of this StringBuffer. </para> <para>If the argument is <c>true </c> the string <c>"true" </c> is appended, otherwise the string <c>"false" </c> is appended.</para> <para> <para>String::valueOf(boolean) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>this StringBuffer. </para>
				/// </returns>
				/// <java-name>
				/// append
				/// </java-name>
				[Dot42.DexImport("append", "(D)Ljava/lang/StringBuffer;", AccessFlags = 1)]
				public global::Java.Lang.StringBuffer Append(double b) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.StringBuffer);
				}

				/// <summary>
				///  <para>Adds the string representation of the specified boolean to the end of this StringBuffer. </para> <para>If the argument is <c>true </c> the string <c>"true" </c> is appended, otherwise the string <c>"false" </c> is appended.</para> <para> <para>String::valueOf(boolean) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>this StringBuffer. </para>
				/// </returns>
				/// <java-name>
				/// append
				/// </java-name>
				[Dot42.DexImport("append", "(F)Ljava/lang/StringBuffer;", AccessFlags = 1)]
				public global::Java.Lang.StringBuffer Append(float b) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.StringBuffer);
				}

				/// <summary>
				///  <para>Adds the string representation of the specified boolean to the end of this StringBuffer. </para> <para>If the argument is <c>true </c> the string <c>"true" </c> is appended, otherwise the string <c>"false" </c> is appended.</para> <para> <para>String::valueOf(boolean) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>this StringBuffer. </para>
				/// </returns>
				/// <java-name>
				/// append
				/// </java-name>
				[Dot42.DexImport("append", "(I)Ljava/lang/StringBuffer;", AccessFlags = 1)]
				public global::Java.Lang.StringBuffer Append(int b) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.StringBuffer);
				}

				/// <summary>
				///  <para>Adds the string representation of the specified boolean to the end of this StringBuffer. </para> <para>If the argument is <c>true </c> the string <c>"true" </c> is appended, otherwise the string <c>"false" </c> is appended.</para> <para> <para>String::valueOf(boolean) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>this StringBuffer. </para>
				/// </returns>
				/// <java-name>
				/// append
				/// </java-name>
				[Dot42.DexImport("append", "(J)Ljava/lang/StringBuffer;", AccessFlags = 1)]
				public global::Java.Lang.StringBuffer Append(long b) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.StringBuffer);
				}

				/// <summary>
				///  <para>Adds the string representation of the specified boolean to the end of this StringBuffer. </para> <para>If the argument is <c>true </c> the string <c>"true" </c> is appended, otherwise the string <c>"false" </c> is appended.</para> <para> <para>String::valueOf(boolean) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>this StringBuffer. </para>
				/// </returns>
				/// <java-name>
				/// append
				/// </java-name>
				[Dot42.DexImport("append", "(Ljava/lang/Object;)Ljava/lang/StringBuffer;", AccessFlags = 33)]
				public global::Java.Lang.StringBuffer Append(object b) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.StringBuffer);
				}

				/// <summary>
				///  <para>Adds the string representation of the specified boolean to the end of this StringBuffer. </para> <para>If the argument is <c>true </c> the string <c>"true" </c> is appended, otherwise the string <c>"false" </c> is appended.</para> <para> <para>String::valueOf(boolean) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>this StringBuffer. </para>
				/// </returns>
				/// <java-name>
				/// append
				/// </java-name>
				[Dot42.DexImport("append", "(Ljava/lang/String;)Ljava/lang/StringBuffer;", AccessFlags = 33)]
				public global::Java.Lang.StringBuffer Append(string b) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.StringBuffer);
				}

				/// <summary>
				///  <para>Adds the string representation of the specified boolean to the end of this StringBuffer. </para> <para>If the argument is <c>true </c> the string <c>"true" </c> is appended, otherwise the string <c>"false" </c> is appended.</para> <para> <para>String::valueOf(boolean) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>this StringBuffer. </para>
				/// </returns>
				/// <java-name>
				/// append
				/// </java-name>
				[Dot42.DexImport("append", "(Ljava/lang/StringBuffer;)Ljava/lang/StringBuffer;", AccessFlags = 33)]
				public global::Java.Lang.StringBuffer Append(global::Java.Lang.StringBuffer b) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.StringBuffer);
				}

				/// <summary>
				///  <para>Adds the string representation of the specified boolean to the end of this StringBuffer. </para> <para>If the argument is <c>true </c> the string <c>"true" </c> is appended, otherwise the string <c>"false" </c> is appended.</para> <para> <para>String::valueOf(boolean) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>this StringBuffer. </para>
				/// </returns>
				/// <java-name>
				/// append
				/// </java-name>
				[Dot42.DexImport("append", "([C)Ljava/lang/StringBuffer;", AccessFlags = 33)]
				public global::Java.Lang.StringBuffer Append(char[] b) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.StringBuffer);
				}

				/// <summary>
				///  <para>Adds the specified sequence of characters to the end of this buffer.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>this StringBuffer. </para>
				/// </returns>
				/// <java-name>
				/// append
				/// </java-name>
				[Dot42.DexImport("append", "([CII)Ljava/lang/StringBuffer;", AccessFlags = 33)]
				public global::Java.Lang.StringBuffer Append(char[] chars, int start, int length) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.StringBuffer);
				}

				/// <summary>
				///  <para>Adds the string representation of the specified boolean to the end of this StringBuffer. </para> <para>If the argument is <c>true </c> the string <c>"true" </c> is appended, otherwise the string <c>"false" </c> is appended.</para> <para> <para>String::valueOf(boolean) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>this StringBuffer. </para>
				/// </returns>
				/// <java-name>
				/// append
				/// </java-name>
				[Dot42.DexImport("append", "(Ljava/lang/CharSequence;)Ljava/lang/StringBuffer;", AccessFlags = 33)]
				public global::Java.Lang.StringBuffer Append(global::Java.Lang.ICharSequence b) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.StringBuffer);
				}

				/// <summary>
				///  <para>Adds the specified sequence of characters to the end of this buffer.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>this StringBuffer. </para>
				/// </returns>
				/// <java-name>
				/// append
				/// </java-name>
				[Dot42.DexImport("append", "(Ljava/lang/CharSequence;II)Ljava/lang/StringBuffer;", AccessFlags = 33)]
				public global::Java.Lang.StringBuffer JavaAppend(global::Java.Lang.ICharSequence chars, int start, int length) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.StringBuffer);
				}

				/// <summary>
				///  <para>Appends the string representation of the specified Unicode code point to the end of this buffer. </para> <para>The code point is converted to a <c>char[] </c> as defined by Character#toChars(int).</para> <para> <para>Character::toChars(int) </para> <para>1.5 </para></para>        
				/// </summary>
				/// <returns>
				///  <para>this StringBuffer. </para>
				/// </returns>
				/// <java-name>
				/// appendCodePoint
				/// </java-name>
				[Dot42.DexImport("appendCodePoint", "(I)Ljava/lang/StringBuffer;", AccessFlags = 1)]
				public global::Java.Lang.StringBuffer AppendCodePoint(int codePoint) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.StringBuffer);
				}

				/// <summary>
				///  <para>Returns the character at the specified index, with the first character having index zero.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the requested character. </para>
				/// </returns>
				/// <java-name>
				/// charAt
				/// </java-name>
				[Dot42.DexImport("charAt", "(I)C", AccessFlags = 33)]
				public char CharAt(int index) /* MethodBuilder.Create */ 
				{
						return default(char);
				}

				/// <java-name>
				/// codePointAt
				/// </java-name>
				[Dot42.DexImport("codePointAt", "(I)I", AccessFlags = 33)]
				public int CodePointAt(int index) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// codePointBefore
				/// </java-name>
				[Dot42.DexImport("codePointBefore", "(I)I", AccessFlags = 33)]
				public int CodePointBefore(int index) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// codePointCount
				/// </java-name>
				[Dot42.DexImport("codePointCount", "(II)I", AccessFlags = 33)]
				public int CodePointCount(int beginIndex, int endIndex) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Deletes a range of characters.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>this StringBuffer. </para>
				/// </returns>
				/// <java-name>
				/// delete
				/// </java-name>
				[Dot42.DexImport("delete", "(II)Ljava/lang/StringBuffer;", AccessFlags = 33)]
				public global::Java.Lang.StringBuffer Delete(int start, int end) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.StringBuffer);
				}

				/// <summary>
				///  <para>Deletes the character at the specified offset.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>this StringBuffer. </para>
				/// </returns>
				/// <java-name>
				/// deleteCharAt
				/// </java-name>
				[Dot42.DexImport("deleteCharAt", "(I)Ljava/lang/StringBuffer;", AccessFlags = 33)]
				public global::Java.Lang.StringBuffer DeleteCharAt(int location) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.StringBuffer);
				}

				/// <java-name>
				/// ensureCapacity
				/// </java-name>
				[Dot42.DexImport("ensureCapacity", "(I)V", AccessFlags = 33)]
				public void EnsureCapacity(int min) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Copies the requested sequence of characters to the <c>char[] </c> passed starting at <c>idx </c> .</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// getChars
				/// </java-name>
				[Dot42.DexImport("getChars", "(II[CI)V", AccessFlags = 33)]
				public void GetChars(int start, int end, char[] buffer, int idx) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// indexOf
				/// </java-name>
				[Dot42.DexImport("indexOf", "(Ljava/lang/String;I)I", AccessFlags = 33)]
				public int IndexOf(string subString, int start) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Inserts the character into this buffer at the specified offset.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>this buffer. </para>
				/// </returns>
				/// <java-name>
				/// insert
				/// </java-name>
				[Dot42.DexImport("insert", "(IC)Ljava/lang/StringBuffer;", AccessFlags = 33)]
				public global::Java.Lang.StringBuffer Insert(int index, char ch) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.StringBuffer);
				}

				/// <summary>
				///  <para>Inserts the character into this buffer at the specified offset.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>this buffer. </para>
				/// </returns>
				/// <java-name>
				/// insert
				/// </java-name>
				[Dot42.DexImport("insert", "(IZ)Ljava/lang/StringBuffer;", AccessFlags = 1)]
				public global::Java.Lang.StringBuffer Insert(int index, bool ch) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.StringBuffer);
				}

				/// <summary>
				///  <para>Inserts the character into this buffer at the specified offset.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>this buffer. </para>
				/// </returns>
				/// <java-name>
				/// insert
				/// </java-name>
				[Dot42.DexImport("insert", "(II)Ljava/lang/StringBuffer;", AccessFlags = 1)]
				public global::Java.Lang.StringBuffer Insert(int index, int ch) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.StringBuffer);
				}

				/// <summary>
				///  <para>Inserts the character into this buffer at the specified offset.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>this buffer. </para>
				/// </returns>
				/// <java-name>
				/// insert
				/// </java-name>
				[Dot42.DexImport("insert", "(IJ)Ljava/lang/StringBuffer;", AccessFlags = 1)]
				public global::Java.Lang.StringBuffer Insert(int index, long ch) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.StringBuffer);
				}

				/// <summary>
				///  <para>Inserts the character into this buffer at the specified offset.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>this buffer. </para>
				/// </returns>
				/// <java-name>
				/// insert
				/// </java-name>
				[Dot42.DexImport("insert", "(ID)Ljava/lang/StringBuffer;", AccessFlags = 1)]
				public global::Java.Lang.StringBuffer Insert(int index, double ch) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.StringBuffer);
				}

				/// <summary>
				///  <para>Inserts the character into this buffer at the specified offset.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>this buffer. </para>
				/// </returns>
				/// <java-name>
				/// insert
				/// </java-name>
				[Dot42.DexImport("insert", "(IF)Ljava/lang/StringBuffer;", AccessFlags = 1)]
				public global::Java.Lang.StringBuffer Insert(int index, float ch) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.StringBuffer);
				}

				/// <summary>
				///  <para>Inserts the character into this buffer at the specified offset.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>this buffer. </para>
				/// </returns>
				/// <java-name>
				/// insert
				/// </java-name>
				[Dot42.DexImport("insert", "(ILjava/lang/Object;)Ljava/lang/StringBuffer;", AccessFlags = 1)]
				public global::Java.Lang.StringBuffer Insert(int index, object ch) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.StringBuffer);
				}

				/// <summary>
				///  <para>Inserts the character into this buffer at the specified offset.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>this buffer. </para>
				/// </returns>
				/// <java-name>
				/// insert
				/// </java-name>
				[Dot42.DexImport("insert", "(ILjava/lang/String;)Ljava/lang/StringBuffer;", AccessFlags = 33)]
				public global::Java.Lang.StringBuffer Insert(int index, string ch) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.StringBuffer);
				}

				/// <summary>
				///  <para>Inserts the character into this buffer at the specified offset.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>this buffer. </para>
				/// </returns>
				/// <java-name>
				/// insert
				/// </java-name>
				[Dot42.DexImport("insert", "(I[C)Ljava/lang/StringBuffer;", AccessFlags = 33)]
				public global::Java.Lang.StringBuffer Insert(int index, char[] ch) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.StringBuffer);
				}

				/// <summary>
				///  <para>Inserts the specified subsequence of characters into this buffer at the specified index.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>this buffer. </para>
				/// </returns>
				/// <java-name>
				/// insert
				/// </java-name>
				[Dot42.DexImport("insert", "(I[CII)Ljava/lang/StringBuffer;", AccessFlags = 33)]
				public global::Java.Lang.StringBuffer Insert(int index, char[] chars, int start, int length) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.StringBuffer);
				}

				/// <summary>
				///  <para>Inserts the character into this buffer at the specified offset.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>this buffer. </para>
				/// </returns>
				/// <java-name>
				/// insert
				/// </java-name>
				[Dot42.DexImport("insert", "(ILjava/lang/CharSequence;)Ljava/lang/StringBuffer;", AccessFlags = 33)]
				public global::Java.Lang.StringBuffer Insert(int index, global::Java.Lang.ICharSequence ch) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.StringBuffer);
				}

				/// <summary>
				///  <para>Inserts the specified subsequence of characters into this buffer at the specified index.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>this buffer. </para>
				/// </returns>
				/// <java-name>
				/// insert
				/// </java-name>
				[Dot42.DexImport("insert", "(ILjava/lang/CharSequence;II)Ljava/lang/StringBuffer;", AccessFlags = 33)]
				public global::Java.Lang.StringBuffer Insert(int index, global::Java.Lang.ICharSequence chars, int start, int length) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.StringBuffer);
				}

				/// <java-name>
				/// lastIndexOf
				/// </java-name>
				[Dot42.DexImport("lastIndexOf", "(Ljava/lang/String;I)I", AccessFlags = 33)]
				public int LastIndexOf(string subString, int start) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// offsetByCodePoints
				/// </java-name>
				[Dot42.DexImport("offsetByCodePoints", "(II)I", AccessFlags = 33)]
				public int OffsetByCodePoints(int index, int codePointOffset) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Replaces the characters in the specified range with the contents of the specified string.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>this buffer. </para>
				/// </returns>
				/// <java-name>
				/// replace
				/// </java-name>
				[Dot42.DexImport("replace", "(IILjava/lang/String;)Ljava/lang/StringBuffer;", AccessFlags = 33)]
				public global::Java.Lang.StringBuffer Replace(int start, int end, string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.StringBuffer);
				}

				/// <summary>
				///  <para>Reverses the order of characters in this buffer.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>this buffer. </para>
				/// </returns>
				/// <java-name>
				/// reverse
				/// </java-name>
				[Dot42.DexImport("reverse", "()Ljava/lang/StringBuffer;", AccessFlags = 33)]
				public global::Java.Lang.StringBuffer Reverse() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.StringBuffer);
				}

				/// <java-name>
				/// setCharAt
				/// </java-name>
				[Dot42.DexImport("setCharAt", "(IC)V", AccessFlags = 33)]
				public void SetCharAt(int index, char ch) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setLength
				/// </java-name>
				[Dot42.DexImport("setLength", "(I)V", AccessFlags = 33)]
				public void SetLength(int length) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns a <c>CharSequence </c> from the <c>start </c> index (inclusive) to the <c>end </c> index (exclusive) of this sequence.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the requested sub-sequence. </para>
				/// </returns>
				/// <java-name>
				/// subSequence
				/// </java-name>
				[Dot42.DexImport("subSequence", "(II)Ljava/lang/CharSequence;", AccessFlags = 33)]
				public global::Java.Lang.ICharSequence SubSequence(int start, int end) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <java-name>
				/// substring
				/// </java-name>
				[Dot42.DexImport("substring", "(I)Ljava/lang/String;", AccessFlags = 33)]
				public string Substring(int start) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// substring
				/// </java-name>
				[Dot42.DexImport("substring", "(II)Ljava/lang/String;", AccessFlags = 33)]
				public string Substring(int start, int end) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Returns a string with the same characters in the same order as in this sequence.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a string based on this sequence. </para>
				/// </returns>
				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 33)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// trimToSize
				/// </java-name>
				[Dot42.DexImport("trimToSize", "()V", AccessFlags = 33)]
				public void TrimToSize() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// capacity
				/// </java-name>
				[Dot42.DexImport("capacity", "()I", AccessFlags = 1)]
				public int Capacity() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// length
				/// </java-name>
				[Dot42.DexImport("length", "()I", AccessFlags = 1)]
				public int Length() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// indexOf
				/// </java-name>
				[Dot42.DexImport("indexOf", "(Ljava/lang/String;)I", AccessFlags = 1)]
				public int IndexOf(string @string) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// lastIndexOf
				/// </java-name>
				[Dot42.DexImport("lastIndexOf", "(Ljava/lang/String;)I", AccessFlags = 1)]
				public int LastIndexOf(string @string) /* MethodBuilder.Create */ 
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

		}

		/// <summary>
		///  <para>Thrown when the a string is indexed with a value less than zero, or greater than or equal to the size of the array. </para>    
		/// </summary>
		/// <java-name>
		/// java/lang/StringIndexOutOfBoundsException
		/// </java-name>
		[Dot42.DexImport("java/lang/StringIndexOutOfBoundsException", AccessFlags = 33)]
		public partial class StringIndexOutOfBoundsException : global::System.IndexOutOfRangeException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructs a new <c>StringIndexOutOfBoundsException </c> that includes the current stack trace. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public StringIndexOutOfBoundsException() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new <c>StringIndexOutOfBoundsException </c> with the current stack trace and a detail message that is based on the specified invalid  <c>index </c> .</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public StringIndexOutOfBoundsException(int index) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new <c>StringIndexOutOfBoundsException </c> with the current stack trace and a detail message that is based on the specified invalid  <c>index </c> .</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public StringIndexOutOfBoundsException(string index) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>Provides access to system-related information and resources including standard input and output. Enables clients to dynamically load native libraries. All methods of this class are accessed in a static way and the class itself can not be instantiated.</para> <para> <para>Runtime </para></para>    
		/// </summary>
		/// <java-name>
		/// java/lang/System
		/// </java-name>
		[Dot42.DexImport("java/lang/System", AccessFlags = 49)]
		public sealed partial class System
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Default input stream. </para>        
				/// </summary>
				/// <java-name>
				/// in
				/// </java-name>
				[Dot42.DexImport("in", "Ljava/io/InputStream;", AccessFlags = 25)]
				public static readonly global::Java.IO.InputStream In;
				/// <summary>
				///  <para>Default output stream. </para>        
				/// </summary>
				/// <java-name>
				/// out
				/// </java-name>
				[Dot42.DexImport("out", "Ljava/io/PrintStream;", AccessFlags = 25)]
				public static readonly global::Java.IO.PrintStream Out;
				/// <summary>
				///  <para>Default error output stream. </para>        
				/// </summary>
				/// <java-name>
				/// err
				/// </java-name>
				[Dot42.DexImport("err", "Ljava/io/PrintStream;", AccessFlags = 25)]
				public static readonly global::Java.IO.PrintStream Err;
				/// <summary>
				///  <para>Prevents this class from being instantiated. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal System() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the standard input stream to the given user defined input stream.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setIn
				/// </java-name>
				[Dot42.DexImport("setIn", "(Ljava/io/InputStream;)V", AccessFlags = 9)]
				public static void SetIn(global::Java.IO.InputStream newIn) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the standard output stream to the given user defined output stream.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setOut
				/// </java-name>
				[Dot42.DexImport("setOut", "(Ljava/io/PrintStream;)V", AccessFlags = 9)]
				public static void SetOut(global::Java.IO.PrintStream newOut) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the standard error output stream to the given user defined output stream.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setErr
				/// </java-name>
				[Dot42.DexImport("setErr", "(Ljava/io/PrintStream;)V", AccessFlags = 9)]
				public static void SetErr(global::Java.IO.PrintStream newErr) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Copies <c>length </c> elements from the array <c>src </c> , starting at offset <c>srcPos </c> , into the array <c>dst </c> , starting at offset <c>dstPos </c> .</para> <para>The source and destination arrays can be the same array, in which case copying is performed as if the source elements are first copied into a temporary array and then into the destination array.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// arraycopy
				/// </java-name>
				[Dot42.DexImport("arraycopy", "(Ljava/lang/Object;ILjava/lang/Object;II)V", AccessFlags = 265)]
				public static void Arraycopy(object src, int srcPos, object dst, int dstPos, int length) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns the current time in milliseconds since January 1, 1970 00:00:00.0 UTC.</para> <para>This method always returns UTC times, regardless of the system's time zone. This is often called "Unix time" or "epoch time". Use a java.text.DateFormat instance to format this time for display to a human.</para> <para>This method shouldn't be used for measuring timeouts or other elapsed time measurements, as changing the system time can affect the results. Use nanoTime for that. </para>        
				/// </summary>
				/// <java-name>
				/// currentTimeMillis
				/// </java-name>
				[Dot42.DexImport("currentTimeMillis", "()J", AccessFlags = 265)]
				public static long CurrentTimeMillis() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				///  <para>Returns the current timestamp of the most precise timer available on the local system, in nanoseconds. Equivalent to Linux's <c>CLOCK_MONOTONIC </c> .</para> <para>This timestamp should only be used to measure a duration by comparing it against another timestamp on the same device. Values returned by this method do not have a defined correspondence to wall clock times; the zero value is typically whenever the device last booted. Use currentTimeMillis if you want to know what time it is. </para>        
				/// </summary>
				/// <java-name>
				/// nanoTime
				/// </java-name>
				[Dot42.DexImport("nanoTime", "()J", AccessFlags = 265)]
				public static long NanoTime() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				///  <para>Causes the VM to stop running and the program to exit with the given exit status. If runFinalizersOnExit(boolean) has been previously invoked with a  <c>true </c> argument, then all objects will be properly garbage-collected and finalized first. </para>        
				/// </summary>
				/// <java-name>
				/// exit
				/// </java-name>
				[Dot42.DexImport("exit", "(I)V", AccessFlags = 9)]
				public static void Exit(int code) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Indicates to the VM that it would be a good time to run the garbage collector. Note that this is a hint only. There is no guarantee that the garbage collector will actually be run. </para>        
				/// </summary>
				/// <java-name>
				/// gc
				/// </java-name>
				[Dot42.DexImport("gc", "()V", AccessFlags = 9)]
				public static void Gc() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns the value of the environment variable with the given name, or null if no such variable exists. </para>        
				/// </summary>
				/// <java-name>
				/// getenv
				/// </java-name>
				[Dot42.DexImport("getenv", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 9)]
				public static string Getenv(string name) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Returns an unmodifiable map of all environment variables to their values. </para>        
				/// </summary>
				/// <java-name>
				/// getenv
				/// </java-name>
				[Dot42.DexImport("getenv", "()Ljava/util/Map;", AccessFlags = 9, Signature = "()Ljava/util/Map<Ljava/lang/String;Ljava/lang/String;>;")]
				public static global::Java.Util.IMap<string, string> Getenv() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IMap<string, string>);
				}

				/// <summary>
				///  <para>Returns the inherited channel from the creator of the current virtual machine.</para> <para> <para>SelectorProvider </para> <para>SelectorProvider::inheritedChannel() </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the inherited Channel or <c>null </c> if none exists. </para>
				/// </returns>
				/// <java-name>
				/// inheritedChannel
				/// </java-name>
				[Dot42.DexImport("inheritedChannel", "()Ljava/nio/channels/Channel;", AccessFlags = 9)]
				public static global::Java.Nio.Channels.IChannel InheritedChannel() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.Channels.IChannel);
				}

				/// <summary>
				///  <para>Returns the value of a particular system property or <c>null </c> if no such property exists.</para> <para>The following properties are always provided by the Dalvik VM: </para> <para> <table> <row> <entry> <para> <b>Name</b> </para></entry> <entry> <para> <b>Meaning</b> </para></entry> <entry> <para> <b>Example</b> </para></entry></row> <row> <entry> <para>file.separator </para></entry> <entry> <para>java.io.File#separator </para></entry> <entry> <para> <c>/ </c> </para> <para></para></entry></row> <row> <entry> <para>java.class.path </para></entry> <entry> <para>System class path </para></entry> <entry> <para> <c>. </c>  </para></entry></row> <row> <entry> <para>java.class.version </para></entry> <entry> <para>(Not useful on Android) </para></entry> <entry> <para> <c>50.0 </c>  </para></entry></row> <row> <entry> <para>java.compiler </para></entry> <entry> <para>(Not useful on Android) </para></entry> <entry> <para>Empty </para></entry></row> <row> <entry> <para>java.ext.dirs </para></entry> <entry> <para>(Not useful on Android) </para></entry> <entry> <para>Empty </para></entry></row> <row> <entry> <para>java.home </para></entry> <entry> <para>Location of the VM on the file system </para></entry> <entry> <para> <c>/system </c>  </para></entry></row> <row> <entry> <para>java.io.tmpdir </para></entry> <entry> <para>See java.io.File#createTempFile </para></entry> <entry> <para> <c>/sdcard </c>  </para></entry></row> <row> <entry> <para>java.library.path </para></entry> <entry> <para>Search path for JNI libraries </para></entry> <entry> <para> <c>/vendor/lib:/system/lib </c>  </para></entry></row> <row> <entry> <para>java.vendor </para></entry> <entry> <para>Human-readable VM vendor </para></entry> <entry> <para> <c>The Android Project </c>  </para></entry></row> <row> <entry> <para>java.vendor.url </para></entry> <entry> <para>URL for VM vendor's web site </para></entry> <entry> <para> <c>http://www.android.com/ </c>  </para></entry></row> <row> <entry> <para>java.version </para></entry> <entry> <para>(Not useful on Android) </para></entry> <entry> <para> <c>0 </c> </para> <para></para></entry></row> <row> <entry> <para>java.specification.version </para></entry> <entry> <para>VM libraries version </para></entry> <entry> <para> <c>0.9 </c>  </para></entry></row> <row> <entry> <para>java.specification.vendor </para></entry> <entry> <para>VM libraries vendor </para></entry> <entry> <para> <c>The Android Project </c>  </para></entry></row> <row> <entry> <para>java.specification.name </para></entry> <entry> <para>VM libraries name </para></entry> <entry> <para> <c>Dalvik Core Library </c>  </para></entry></row> <row> <entry> <para>java.vm.version </para></entry> <entry> <para>VM implementation version </para></entry> <entry> <para> <c>1.2.0 </c>  </para></entry></row> <row> <entry> <para>java.vm.vendor </para></entry> <entry> <para>VM implementation vendor </para></entry> <entry> <para> <c>The Android Project </c>  </para></entry></row> <row> <entry> <para>java.vm.name </para></entry> <entry> <para>VM implementation name </para></entry> <entry> <para> <c>Dalvik </c>  </para></entry></row> <row> <entry> <para>java.vm.specification.version </para></entry> <entry> <para>VM specification version </para></entry> <entry> <para> <c>0.9 </c>  </para></entry></row> <row> <entry> <para>java.vm.specification.vendor </para></entry> <entry> <para>VM specification vendor </para></entry> <entry> <para> <c>The Android Project </c>  </para></entry></row> <row> <entry> <para>java.vm.specification.name </para></entry> <entry> <para>VM specification name </para></entry> <entry> <para> <c>Dalvik Virtual Machine Specification </c> </para> <para></para></entry></row> <row> <entry> <para>line.separator </para></entry> <entry> <para>The system line separator </para></entry> <entry> <para> <c>\n </c> </para> <para></para></entry></row> <row> <entry> <para>os.arch </para></entry> <entry> <para>OS architecture </para></entry> <entry> <para> <c>armv7l </c>  </para></entry></row> <row> <entry> <para>os.name </para></entry> <entry> <para>OS (kernel) name </para></entry> <entry> <para> <c>Linux </c>  </para></entry></row> <row> <entry> <para>os.version </para></entry> <entry> <para>OS (kernel) version </para></entry> <entry> <para> <c>2.6.32.9-g103d848 </c> </para> <para></para></entry></row> <row> <entry> <para>path.separator </para></entry> <entry> <para>See java.io.File#pathSeparator </para></entry> <entry> <para> <c>: </c> </para> <para></para></entry></row> <row> <entry> <para>user.dir </para></entry> <entry> <para>Base of non-absolute paths </para></entry> <entry> <para> <c>/ </c>  </para></entry></row> <row> <entry> <para>user.home </para></entry> <entry> <para>(Not useful on Android) </para></entry> <entry> <para>Empty </para></entry></row> <row> <entry> <para>user.name </para></entry> <entry> <para>(Not useful on Android) </para></entry> <entry> <para>Empty</para> <para></para></entry></row></table></para> <para>It is a mistake to try to override any of these. Doing so will have unpredictable results.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the value of the specified system property or <c>null </c> if the property doesn't exist. </para>
				/// </returns>
				/// <java-name>
				/// getProperty
				/// </java-name>
				[Dot42.DexImport("getProperty", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 9)]
				public static string GetProperty(string propertyName) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Returns the value of a particular system property. The <c>defaultValue </c> will be returned if no such property has been found. </para>        
				/// </summary>
				/// <java-name>
				/// getProperty
				/// </java-name>
				[Dot42.DexImport("getProperty", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 9)]
				public static string GetProperty(string name, string defaultValue) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Sets the value of a particular system property.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the old value of the property or <c>null </c> if the property didn't exist. </para>
				/// </returns>
				/// <java-name>
				/// setProperty
				/// </java-name>
				[Dot42.DexImport("setProperty", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 9)]
				public static string SetProperty(string name, string value) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Removes a specific system property.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the property value or <c>null </c> if the property didn't exist. </para>
				/// </returns>
				/// <java-name>
				/// clearProperty
				/// </java-name>
				[Dot42.DexImport("clearProperty", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 9)]
				public static string ClearProperty(string name) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Returns an integer hash code for the parameter. The hash code returned is the same one that would be returned by the method <c>java.lang.Object.hashCode() </c> , whether or not the object's class has overridden hashCode(). The hash code for <c>null </c> is <c>0 </c> .</para> <para> <para>java.lang.Object::hashCode </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the hash code for the given object. </para>
				/// </returns>
				/// <java-name>
				/// identityHashCode
				/// </java-name>
				[Dot42.DexImport("identityHashCode", "(Ljava/lang/Object;)I", AccessFlags = 265)]
				public static int IdentityHashCode(object anObject) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Loads and links the dynamic library that is identified through the specified path. This method is similar to loadLibrary(String), but it accepts a full path specification whereas <c>loadLibrary </c> just accepts the name of the library to load.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// load
				/// </java-name>
				[Dot42.DexImport("load", "(Ljava/lang/String;)V", AccessFlags = 9)]
				public static void Load(string pathName) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Loads and links the library with the specified name. The mapping of the specified library name to the full path for loading the library is implementation-dependent.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// loadLibrary
				/// </java-name>
				[Dot42.DexImport("loadLibrary", "(Ljava/lang/String;)V", AccessFlags = 9)]
				public static void LoadLibrary(string libName) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Provides a hint to the VM that it would be useful to attempt to perform any outstanding object finalization. </para>        
				/// </summary>
				/// <java-name>
				/// runFinalization
				/// </java-name>
				[Dot42.DexImport("runFinalization", "()V", AccessFlags = 9)]
				public static void RunFinalization() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Ensures that, when the VM is about to exit, all objects are finalized. Note that all finalization which occurs when the system is exiting is performed after all running threads have been terminated.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>This method is unsafe. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// runFinalizersOnExit
				/// </java-name>
				[Dot42.DexImport("runFinalizersOnExit", "(Z)V", AccessFlags = 9)]
				public static void RunFinalizersOnExit(bool flag) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns the platform specific file name format for the shared library named by the argument.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the platform specific filename for the library. </para>
				/// </returns>
				/// <java-name>
				/// mapLibraryName
				/// </java-name>
				[Dot42.DexImport("mapLibraryName", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 265)]
				public static string MapLibraryName(string userLibName) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Returns the system properties. Note that this is not a copy, so that changes made to the returned Properties object will be reflected in subsequent calls to getProperty and getProperties.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the system properties. </para>
				/// </returns>
				/// <java-name>
				/// getProperties
				/// </java-name>
				public static global::Java.Util.Properties Properties
				{
						[Dot42.DexImport("getProperties", "()Ljava/util/Properties;", AccessFlags = 9)]
						get{ return default(global::Java.Util.Properties); }
						[Dot42.DexImport("setProperties", "(Ljava/util/Properties;)V", AccessFlags = 9)]
						set{ }
				}

				/// <summary>
				///  <para>Returns null. Android does not use <c>SecurityManager </c> . This method is only provided for source compatibility.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>null </para>
				/// </returns>
				/// <java-name>
				/// getSecurityManager
				/// </java-name>
				public static global::Java.Lang.SecurityManager SecurityManager
				{
						[Dot42.DexImport("getSecurityManager", "()Ljava/lang/SecurityManager;", AccessFlags = 9)]
						get{ return default(global::Java.Lang.SecurityManager); }
						[Dot42.DexImport("setSecurityManager", "(Ljava/lang/SecurityManager;)V", AccessFlags = 9)]
						set{ }
				}

		}

		/// <summary>
		///  <para>ThreadDeath is thrown when a thread stops executing. It is used to aid in the orderly unrolling of the thread's stack (eg. cleanup of monitors). </para>    
		/// </summary>
		/// <java-name>
		/// java/lang/ThreadDeath
		/// </java-name>
		[Dot42.DexImport("java/lang/ThreadDeath", AccessFlags = 33)]
		public partial class ThreadDeath : global::Java.Lang.Error
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructs a new instance of this class. Note that in the case of ThreadDeath, the stack trace may  <b>not</b> be filled in a way which allows a stack trace to be printed. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ThreadDeath() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para> <c>ThreadGroup </c> is a means of organizing threads into a hierarchical structure. This class is obsolete. See  <b>Effective Java</b> Item 73, "Avoid thread groups" for details.  <para>Thread </para></para>    
		/// </summary>
		/// <java-name>
		/// java/lang/ThreadGroup
		/// </java-name>
		[Dot42.DexImport("java/lang/ThreadGroup", AccessFlags = 33)]
		public partial class ThreadGroup : global::System.Threading.Thread.IUncaughtExceptionHandler
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructs a new <c>ThreadGroup </c> with the given name. The new <c>ThreadGroup </c> will be child of the <c>ThreadGroup </c> to which the calling thread belongs.</para> <para> <para>Thread::currentThread </para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public ThreadGroup(string name) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new <c>ThreadGroup </c> with the given name, as a child of the given <c>ThreadGroup </c> .</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/ThreadGroup;Ljava/lang/String;)V", AccessFlags = 1)]
				public ThreadGroup(global::Java.Lang.ThreadGroup parent, string name) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns the number of running <c>Thread </c> s which are children of this thread group, directly or indirectly.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the number of children </para>
				/// </returns>
				/// <java-name>
				/// activeCount
				/// </java-name>
				[Dot42.DexImport("activeCount", "()I", AccessFlags = 1)]
				public virtual int ActiveCount() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Returns the number of <c>ThreadGroup </c> s which are children of this group, directly or indirectly.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the number of children </para>
				/// </returns>
				/// <java-name>
				/// activeGroupCount
				/// </java-name>
				[Dot42.DexImport("activeGroupCount", "()I", AccessFlags = 1)]
				public virtual int ActiveGroupCount() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Does nothing. The definition of this method depends on the deprecated method suspend(). The exact behavior of this call was never specified.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Required deprecated method suspend(). </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> (always)</para>
				/// </returns>
				/// <java-name>
				/// allowThreadSuspension
				/// </java-name>
				[Dot42.DexImport("allowThreadSuspension", "(Z)Z", AccessFlags = 1)]
				public virtual bool AllowThreadSuspension(bool b) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Does nothing. </para>        
				/// </summary>
				/// <java-name>
				/// checkAccess
				/// </java-name>
				[Dot42.DexImport("checkAccess", "()V", AccessFlags = 17)]
				public void CheckAccess() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Destroys this thread group and recursively all its subgroups. It is only legal to destroy a <c>ThreadGroup </c> that has no threads in it. Any daemon  <c>ThreadGroup </c> is destroyed automatically when it becomes empty (no threads or thread groups in it).</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// destroy
				/// </java-name>
				[Dot42.DexImport("destroy", "()V", AccessFlags = 17)]
				public void Destroy() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Iterates over all active threads in this group (and its sub-groups) and stores the threads in the given array. Returns when the array is full or no more threads remain, whichever happens first.</para> <para>Note that this method will silently ignore any threads that don't fit in the supplied array.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the number of <c>Thread </c> s that were copied </para>
				/// </returns>
				/// <java-name>
				/// enumerate
				/// </java-name>
				[Dot42.DexImport("enumerate", "([Ljava/lang/Thread;)I", AccessFlags = 1)]
				public virtual int Enumerate(global::System.Threading.Thread[] threads) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Iterates over all active threads in this group (and, optionally, its sub-groups) and stores the threads in the given array. Returns when the array is full or no more threads remain, whichever happens first.</para> <para>Note that this method will silently ignore any threads that don't fit in the supplied array.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the number of <c>Thread </c> s that were copied </para>
				/// </returns>
				/// <java-name>
				/// enumerate
				/// </java-name>
				[Dot42.DexImport("enumerate", "([Ljava/lang/Thread;Z)I", AccessFlags = 1)]
				public virtual int Enumerate(global::System.Threading.Thread[] threads, bool recurse) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Iterates over all active threads in this group (and its sub-groups) and stores the threads in the given array. Returns when the array is full or no more threads remain, whichever happens first.</para> <para>Note that this method will silently ignore any threads that don't fit in the supplied array.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the number of <c>Thread </c> s that were copied </para>
				/// </returns>
				/// <java-name>
				/// enumerate
				/// </java-name>
				[Dot42.DexImport("enumerate", "([Ljava/lang/ThreadGroup;)I", AccessFlags = 1)]
				public virtual int Enumerate(global::Java.Lang.ThreadGroup[] threads) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Iterates over all active threads in this group (and, optionally, its sub-groups) and stores the threads in the given array. Returns when the array is full or no more threads remain, whichever happens first.</para> <para>Note that this method will silently ignore any threads that don't fit in the supplied array.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the number of <c>Thread </c> s that were copied </para>
				/// </returns>
				/// <java-name>
				/// enumerate
				/// </java-name>
				[Dot42.DexImport("enumerate", "([Ljava/lang/ThreadGroup;Z)I", AccessFlags = 1)]
				public virtual int Enumerate(global::Java.Lang.ThreadGroup[] threads, bool recurse) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Interrupts every <c>Thread </c> in this group and recursively in all its subgroups.</para> <para> <para>Thread::interrupt </para></para>        
				/// </summary>
				/// <java-name>
				/// interrupt
				/// </java-name>
				[Dot42.DexImport("interrupt", "()V", AccessFlags = 17)]
				public void Interrupt() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Outputs to <c>System.out </c> a text representation of the hierarchy of <c>Thread </c> s and <c>ThreadGroup </c> s in this thread group (and recursively). Proper indentation is used to show the nesting of groups inside groups and threads inside groups. </para>        
				/// </summary>
				/// <java-name>
				/// list
				/// </java-name>
				[Dot42.DexImport("list", "()V", AccessFlags = 1)]
				public virtual void List() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Checks whether this thread group is a direct or indirect parent group of a given <c>ThreadGroup </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if this thread group is parent of <c>g </c> </para>
				/// </returns>
				/// <java-name>
				/// parentOf
				/// </java-name>
				[Dot42.DexImport("parentOf", "(Ljava/lang/ThreadGroup;)Z", AccessFlags = 17)]
				public bool ParentOf(global::Java.Lang.ThreadGroup g) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Resumes every thread in this group and recursively in all its subgroups.</para> <para> <para>Thread::resume </para> <para>suspend</para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Requires deprecated method Thread#resume(). </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// resume
				/// </java-name>
				[Dot42.DexImport("resume", "()V", AccessFlags = 17)]
				public void Resume() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Stops every thread in this group and recursively in all its subgroups.</para> <para> <para>Thread::stop() </para> <para>Thread::stop(Throwable) </para> <para>ThreadDeath</para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Requires deprecated method Thread#stop(). </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// stop
				/// </java-name>
				[Dot42.DexImport("stop", "()V", AccessFlags = 17)]
				public void Stop() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Suspends every thread in this group and recursively in all its subgroups.</para> <para> <para>Thread::suspend </para> <para>resume</para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Requires deprecated method Thread#suspend(). </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// suspend
				/// </java-name>
				[Dot42.DexImport("suspend", "()V", AccessFlags = 17)]
				public void Suspend() /* MethodBuilder.Create */ 
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
				///  <para>Handles uncaught exceptions. Any uncaught exception in any <c>Thread </c> is forwarded to the thread's <c>ThreadGroup </c> by invoking this method.</para> <para>New code should use Thread#setUncaughtExceptionHandler instead of thread groups.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// uncaughtException
				/// </java-name>
				[Dot42.DexImport("uncaughtException", "(Ljava/lang/Thread;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public virtual void UncaughtException(global::System.Threading.Thread t, global::System.Exception e) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal ThreadGroup() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Returns the maximum allowed priority for a <c>Thread </c> in this thread group.</para> <para> <para>setMaxPriority </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the maximum priority</para>
				/// </returns>
				/// <java-name>
				/// getMaxPriority
				/// </java-name>
				public int MaxPriority
				{
						[Dot42.DexImport("getMaxPriority", "()I", AccessFlags = 17)]
						get{ return default(int); }
						[Dot42.DexImport("setMaxPriority", "(I)V", AccessFlags = 17)]
						set{ }
				}

				/// <summary>
				///  <para>Returns the name of this thread group.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the group's name </para>
				/// </returns>
				/// <java-name>
				/// getName
				/// </java-name>
				public string Name
				{
						[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 17)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>Returns this thread group's parent <c>ThreadGroup </c> . It can be null if this is the the root ThreadGroup.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the parent </para>
				/// </returns>
				/// <java-name>
				/// getParent
				/// </java-name>
				public global::Java.Lang.ThreadGroup Parent
				{
						[Dot42.DexImport("getParent", "()Ljava/lang/ThreadGroup;", AccessFlags = 17)]
						get{ return default(global::Java.Lang.ThreadGroup); }
				}

				/// <summary>
				///  <para>Checks whether this thread group is a daemon <c>ThreadGroup </c> .</para> <para> <para>setDaemon </para> <para>destroy </para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if this thread group is a daemon <c>ThreadGroup </c></para>
				/// </returns>
				/// <java-name>
				/// isDaemon
				/// </java-name>
				public bool IsDaemon
				{
						[Dot42.DexImport("isDaemon", "()Z", AccessFlags = 17)]
						get{ return default(bool); }
						[Dot42.DexImport("setDaemon", "(Z)V", AccessFlags = 17)]
						set{ }
				}

				/// <summary>
				///  <para>Checks whether this thread group has already been destroyed.</para> <para> <para>destroy </para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if this thread group has already been destroyed </para>
				/// </returns>
				/// <java-name>
				/// isDestroyed
				/// </java-name>
				public virtual bool IsDestroyed
				{
						[Dot42.DexImport("isDestroyed", "()Z", AccessFlags = 33)]
						get{ return default(bool); }
				}

		}

		/// <summary>
		///  <para>Implements a thread-local storage, that is, a variable for which each thread has its own value. All threads share the same <c>ThreadLocal </c> object, but each sees a different value when accessing it, and changes made by one thread do not affect the other threads. The implementation supports  <c>null </c> values.</para> <para> <para>java.lang.Thread </para> <para>Bob Lee </para></para>    
		/// </summary>
		/// <java-name>
		/// java/lang/ThreadLocal
		/// </java-name>
		[Dot42.DexImport("java/lang/ThreadLocal", AccessFlags = 33, Signature = "<T:Ljava/lang/Object;>Ljava/lang/Object;")]
		public partial class ThreadLocal<T>
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Creates a new thread-local variable. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ThreadLocal() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns the value of this variable for the current thread. If an entry doesn't yet exist for this variable on this thread, this method will create an entry, populating the value with the result of initialValue().</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the current value of the variable for the calling thread. </para>
				/// </returns>
				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TT;")]
				public virtual T Get() /* MethodBuilder.Create */ 
				{
						return default(T);
				}

				/// <summary>
				///  <para>Provides the initial value of this variable for the current thread. The default implementation returns <c>null </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the initial value of the variable. </para>
				/// </returns>
				/// <java-name>
				/// initialValue
				/// </java-name>
				[Dot42.DexImport("initialValue", "()Ljava/lang/Object;", AccessFlags = 4, Signature = "()TT;")]
				protected internal virtual T InitialValue() /* MethodBuilder.Create */ 
				{
						return default(T);
				}

				/// <summary>
				///  <para>Sets the value of this variable for the current thread. If set to  <c>null </c> , the value will be set to null and the underlying entry will still be present.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// set
				/// </java-name>
				[Dot42.DexImport("set", "(Ljava/lang/Object;)V", AccessFlags = 1, Signature = "(TT;)V")]
				public virtual void Set(T value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Removes the entry for this variable in the current thread. If this call is followed by a get() before a set,  <c>#get() </c> will call initialValue() and create a new entry with the resulting value.</para> <para> <para>1.5 </para></para>        
				/// </summary>
				/// <java-name>
				/// remove
				/// </java-name>
				[Dot42.DexImport("remove", "()V", AccessFlags = 1)]
				public virtual void Remove() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>Thrown when a program tries to access a class, interface, enum or annotation type through a string that contains the type's name and the type cannot be found. This exception is an unchecked alternative to java.lang.ClassNotFoundException.</para> <para> <para>1.5 </para></para>    
		/// </summary>
		/// <java-name>
		/// java/lang/TypeNotPresentException
		/// </java-name>
		[Dot42.DexImport("java/lang/TypeNotPresentException", AccessFlags = 33)]
		public partial class TypeNotPresentException : global::System.SystemException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructs a new <c>TypeNotPresentException </c> with the current stack trace, a detail message that includes the name of the type that could not be found and the <c>Throwable </c> that caused this exception.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public TypeNotPresentException(string typeName, global::System.Exception cause) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Gets the fully qualified name of the type that could not be found.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the name of the type that caused this exception. </para>
				/// </returns>
				/// <java-name>
				/// typeName
				/// </java-name>
				[Dot42.DexImport("typeName", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string TypeName() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal TypeNotPresentException() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		///  <para>Thrown when the VM must throw an error which does not match any known exceptional condition. </para>    
		/// </summary>
		/// <java-name>
		/// java/lang/UnknownError
		/// </java-name>
		[Dot42.DexImport("java/lang/UnknownError", AccessFlags = 33)]
		public partial class UnknownError : global::Java.Lang.VirtualMachineError
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructs a new <c>UnknownError </c> that includes the current stack trace. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public UnknownError() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new <c>UnknownError </c> with the current stack trace and the specified detail message.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public UnknownError(string detailMessage) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>Thrown when an attempt is made to invoke a native for which an implementation could not be found. </para>    
		/// </summary>
		/// <java-name>
		/// java/lang/UnsatisfiedLinkError
		/// </java-name>
		[Dot42.DexImport("java/lang/UnsatisfiedLinkError", AccessFlags = 33)]
		public partial class UnsatisfiedLinkError : global::Java.Lang.LinkageError
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructs a new <c>UnsatisfiedLinkError </c> that includes the current stack trace. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public UnsatisfiedLinkError() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new <c>UnsatisfiedLinkError </c> with the current stack trace and the specified detail message.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public UnsatisfiedLinkError(string detailMessage) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>Thrown when an attempt is made to load a class with a format version that is not supported by the VM. </para>    
		/// </summary>
		/// <java-name>
		/// java/lang/UnsupportedClassVersionError
		/// </java-name>
		[Dot42.DexImport("java/lang/UnsupportedClassVersionError", AccessFlags = 33)]
		public partial class UnsupportedClassVersionError : global::Java.Lang.ClassFormatError
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructs a new <c>UnsupportedClassVersionError </c> that includes the current stack trace. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public UnsupportedClassVersionError() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new <c>UnsupportedClassVersionError </c> with the current stack trace and the specified detail message.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public UnsupportedClassVersionError(string detailMessage) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>Thrown when an unsupported operation is attempted. </para>    
		/// </summary>
		/// <java-name>
		/// java/lang/UnsupportedOperationException
		/// </java-name>
		[Dot42.DexImport("java/lang/UnsupportedOperationException", AccessFlags = 33)]
		public partial class UnsupportedOperationException : global::System.SystemException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructs a new <c>UnsupportedOperationException </c> that includes the current stack trace. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public UnsupportedOperationException() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new <c>UnsupportedOperationException </c> with the current stack trace and the specified detail message.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public UnsupportedOperationException(string detailMessage) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new <c>UnsupportedOperationException </c> with the current stack trace, the specified detail message and the specified cause.</para> <para> <para>1.5 </para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public UnsupportedOperationException(string message, global::System.Exception cause) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new <c>UnsupportedOperationException </c> with the current stack trace and the specified detail message.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public UnsupportedOperationException(global::System.Exception detailMessage) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>Thrown when the VM notices that an attempt is made to load a class which does not pass the class verification phase. </para>    
		/// </summary>
		/// <java-name>
		/// java/lang/VerifyError
		/// </java-name>
		[Dot42.DexImport("java/lang/VerifyError", AccessFlags = 33)]
		public partial class VerifyError : global::Java.Lang.LinkageError
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructs a new <c>VerifyError </c> that includes the current stack trace. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public VerifyError() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new <c>VerifyError </c> with the current stack trace and the specified detail message.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public VerifyError(string detailMessage) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para> <c>VirtualMachineError </c> is the superclass of all error classes that occur during the operation of the VM.</para> <para> <para>Error </para></para>    
		/// </summary>
		/// <java-name>
		/// java/lang/VirtualMachineError
		/// </java-name>
		[Dot42.DexImport("java/lang/VirtualMachineError", AccessFlags = 1057)]
		public abstract partial class VirtualMachineError : global::Java.Lang.Error
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructs a new <c>VirtualMachineError </c> that includes the current stack trace. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public VirtualMachineError() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new <c>VirtualMachineError </c> with the current stack trace and the specified detail message.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public VirtualMachineError(string detailMessage) /* MethodBuilder.Create */ 
				{
				}

		}

}

