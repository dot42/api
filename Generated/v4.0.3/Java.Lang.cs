#pragma warning disable 1717
namespace Java.Lang
{
		/// <java-name>
		/// java/lang/AbstractMethodError
		/// </java-name>
		[Dot42.DexImport("java/lang/AbstractMethodError", AccessFlags = 33)]
		public partial class AbstractMethodError : global::Java.Lang.IncompatibleClassChangeError
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public AbstractMethodError() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public AbstractMethodError(string @string) /* MethodBuilder.Create */ 
				{
				}

		}

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

				/// <java-name>
				/// capacity
				/// </java-name>
				[Dot42.DexImport("capacity", "()I", AccessFlags = 1)]
				public virtual int Capacity() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// charAt
				/// </java-name>
				[Dot42.DexImport("charAt", "(I)C", AccessFlags = 1)]
				public virtual char CharAt(int int32) /* MethodBuilder.Create */ 
				{
						return default(char);
				}

				/// <java-name>
				/// ensureCapacity
				/// </java-name>
				[Dot42.DexImport("ensureCapacity", "(I)V", AccessFlags = 1)]
				public virtual void EnsureCapacity(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getChars
				/// </java-name>
				[Dot42.DexImport("getChars", "(II[CI)V", AccessFlags = 1)]
				public virtual void GetChars(int int32, int int321, char[] @char, int int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// length
				/// </java-name>
				[Dot42.DexImport("length", "()I", AccessFlags = 1)]
				public virtual int Length() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// setCharAt
				/// </java-name>
				[Dot42.DexImport("setCharAt", "(IC)V", AccessFlags = 1)]
				public virtual void SetCharAt(int int32, char @char) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setLength
				/// </java-name>
				[Dot42.DexImport("setLength", "(I)V", AccessFlags = 1)]
				public virtual void SetLength(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// substring
				/// </java-name>
				[Dot42.DexImport("substring", "(I)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string Substring(int int32) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// substring
				/// </java-name>
				[Dot42.DexImport("substring", "(II)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string Substring(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(string);
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
				/// subSequence
				/// </java-name>
				[Dot42.DexImport("subSequence", "(II)Ljava/lang/CharSequence;", AccessFlags = 1)]
				public virtual global::Java.Lang.ICharSequence SubSequence(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <java-name>
				/// indexOf
				/// </java-name>
				[Dot42.DexImport("indexOf", "(Ljava/lang/String;)I", AccessFlags = 1)]
				public virtual int IndexOf(string @string) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// indexOf
				/// </java-name>
				[Dot42.DexImport("indexOf", "(Ljava/lang/String;I)I", AccessFlags = 1)]
				public virtual int IndexOf(string @string, int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// lastIndexOf
				/// </java-name>
				[Dot42.DexImport("lastIndexOf", "(Ljava/lang/String;)I", AccessFlags = 1)]
				public virtual int LastIndexOf(string @string) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// lastIndexOf
				/// </java-name>
				[Dot42.DexImport("lastIndexOf", "(Ljava/lang/String;I)I", AccessFlags = 1)]
				public virtual int LastIndexOf(string @string, int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// trimToSize
				/// </java-name>
				[Dot42.DexImport("trimToSize", "()V", AccessFlags = 1)]
				public virtual void TrimToSize() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// codePointAt
				/// </java-name>
				[Dot42.DexImport("codePointAt", "(I)I", AccessFlags = 1)]
				public virtual int CodePointAt(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// codePointBefore
				/// </java-name>
				[Dot42.DexImport("codePointBefore", "(I)I", AccessFlags = 1)]
				public virtual int CodePointBefore(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// codePointCount
				/// </java-name>
				[Dot42.DexImport("codePointCount", "(II)I", AccessFlags = 1)]
				public virtual int CodePointCount(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// offsetByCodePoints
				/// </java-name>
				[Dot42.DexImport("offsetByCodePoints", "(II)I", AccessFlags = 1)]
				public virtual int OffsetByCodePoints(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

		}

		/// <java-name>
		/// java/lang/ArrayIndexOutOfBoundsException
		/// </java-name>
		[Dot42.DexImport("java/lang/ArrayIndexOutOfBoundsException", AccessFlags = 33)]
		public partial class ArrayIndexOutOfBoundsException : global::System.IndexOutOfRangeException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ArrayIndexOutOfBoundsException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public ArrayIndexOutOfBoundsException(int int32) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public ArrayIndexOutOfBoundsException(string @string) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/lang/AssertionError
		/// </java-name>
		[Dot42.DexImport("java/lang/AssertionError", AccessFlags = 33)]
		public partial class AssertionError : global::Java.Lang.Error
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public AssertionError() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/Object;)V", AccessFlags = 1)]
				public AssertionError(object @object) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Z)V", AccessFlags = 1)]
				public AssertionError(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(C)V", AccessFlags = 1)]
				public AssertionError(char @char) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public AssertionError(int int32) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(J)V", AccessFlags = 1)]
				public AssertionError(long int64) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(F)V", AccessFlags = 1)]
				public AssertionError(float single) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(D)V", AccessFlags = 1)]
				public AssertionError(double @double) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/lang/ClassCircularityError
		/// </java-name>
		[Dot42.DexImport("java/lang/ClassCircularityError", AccessFlags = 33)]
		public partial class ClassCircularityError : global::Java.Lang.LinkageError
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ClassCircularityError() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public ClassCircularityError(string @string) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/lang/ClassFormatError
		/// </java-name>
		[Dot42.DexImport("java/lang/ClassFormatError", AccessFlags = 33)]
		public partial class ClassFormatError : global::Java.Lang.LinkageError
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ClassFormatError() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public ClassFormatError(string @string) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/lang/ClassLoader
		/// </java-name>
		[Dot42.DexImport("java/lang/ClassLoader", AccessFlags = 1057)]
		public abstract partial class ClassLoader
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal ClassLoader() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/ClassLoader;)V", AccessFlags = 4)]
				protected internal ClassLoader(global::Java.Lang.ClassLoader classLoader) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getSystemResource
				/// </java-name>
				[Dot42.DexImport("getSystemResource", "(Ljava/lang/String;)Ljava/net/URL;", AccessFlags = 9)]
				public static global::Java.Net.URL GetSystemResource(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.URL);
				}

				/// <java-name>
				/// getSystemResources
				/// </java-name>
				[Dot42.DexImport("getSystemResources", "(Ljava/lang/String;)Ljava/util/Enumeration;", AccessFlags = 9, Signature = "(Ljava/lang/String;)Ljava/util/Enumeration<Ljava/net/URL;>;")]
				public static global::Java.Util.IEnumeration<global::Java.Net.URL> GetSystemResources(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IEnumeration<global::Java.Net.URL>);
				}

				/// <java-name>
				/// getSystemResourceAsStream
				/// </java-name>
				[Dot42.DexImport("getSystemResourceAsStream", "(Ljava/lang/String;)Ljava/io/InputStream;", AccessFlags = 9)]
				public static global::Java.Io.InputStream GetSystemResourceAsStream(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.InputStream);
				}

				/// <java-name>
				/// defineClass
				/// </java-name>
				[Dot42.DexImport("defineClass", "([BII)Ljava/lang/Class;", AccessFlags = 20, Signature = "([BII)Ljava/lang/Class<*>;")]
				protected internal global::System.Type DefineClass(sbyte[] sByte, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(global::System.Type);
				}

				/// <java-name>
				/// defineClass
				/// </java-name>
				[Dot42.DexImport("defineClass", "([BII)Ljava/lang/Class;", AccessFlags = 20, IgnoreFromJava = true, Signature = "([BII)Ljava/lang/Class<*>;")]
				protected internal global::System.Type DefineClass(byte[] @byte, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(global::System.Type);
				}

				/// <java-name>
				/// defineClass
				/// </java-name>
				[Dot42.DexImport("defineClass", "(Ljava/lang/String;[BII)Ljava/lang/Class;", AccessFlags = 20, Signature = "(Ljava/lang/String;[BII)Ljava/lang/Class<*>;")]
				protected internal global::System.Type DefineClass(string @string, sbyte[] sByte, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(global::System.Type);
				}

				/// <java-name>
				/// defineClass
				/// </java-name>
				[Dot42.DexImport("defineClass", "(Ljava/lang/String;[BII)Ljava/lang/Class;", AccessFlags = 20, IgnoreFromJava = true, Signature = "(Ljava/lang/String;[BII)Ljava/lang/Class<*>;")]
				protected internal global::System.Type DefineClass(string @string, byte[] @byte, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(global::System.Type);
				}

				/// <java-name>
				/// defineClass
				/// </java-name>
				[Dot42.DexImport("defineClass", "(Ljava/lang/String;[BIILjava/security/ProtectionDomain;)Ljava/lang/Class;", AccessFlags = 20, Signature = "(Ljava/lang/String;[BIILjava/security/ProtectionDomain;)Ljava/lang/Class<*>;")]
				protected internal global::System.Type DefineClass(string @string, sbyte[] sByte, int int32, int int321, global::Java.Security.ProtectionDomain protectionDomain) /* MethodBuilder.Create */ 
				{
						return default(global::System.Type);
				}

				/// <java-name>
				/// defineClass
				/// </java-name>
				[Dot42.DexImport("defineClass", "(Ljava/lang/String;[BIILjava/security/ProtectionDomain;)Ljava/lang/Class;", AccessFlags = 20, IgnoreFromJava = true, Signature = "(Ljava/lang/String;[BIILjava/security/ProtectionDomain;)Ljava/lang/Class<*>;")]
				protected internal global::System.Type DefineClass(string @string, byte[] @byte, int int32, int int321, global::Java.Security.ProtectionDomain protectionDomain) /* MethodBuilder.Create */ 
				{
						return default(global::System.Type);
				}

				/// <java-name>
				/// defineClass
				/// </java-name>
				[Dot42.DexImport("defineClass", "(Ljava/lang/String;Ljava/nio/ByteBuffer;Ljava/security/ProtectionDomain;)Ljava/la" +
    "ng/Class;", AccessFlags = 20, Signature = "(Ljava/lang/String;Ljava/nio/ByteBuffer;Ljava/security/ProtectionDomain;)Ljava/la" +
    "ng/Class<*>;")]
				protected internal global::System.Type DefineClass(string @string, global::Java.Nio.ByteBuffer byteBuffer, global::Java.Security.ProtectionDomain protectionDomain) /* MethodBuilder.Create */ 
				{
						return default(global::System.Type);
				}

				/// <java-name>
				/// findClass
				/// </java-name>
				[Dot42.DexImport("findClass", "(Ljava/lang/String;)Ljava/lang/Class;", AccessFlags = 4, Signature = "(Ljava/lang/String;)Ljava/lang/Class<*>;")]
				protected internal virtual global::System.Type FindClass(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::System.Type);
				}

				/// <java-name>
				/// findLoadedClass
				/// </java-name>
				[Dot42.DexImport("findLoadedClass", "(Ljava/lang/String;)Ljava/lang/Class;", AccessFlags = 20, Signature = "(Ljava/lang/String;)Ljava/lang/Class<*>;")]
				protected internal global::System.Type FindLoadedClass(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::System.Type);
				}

				/// <java-name>
				/// findSystemClass
				/// </java-name>
				[Dot42.DexImport("findSystemClass", "(Ljava/lang/String;)Ljava/lang/Class;", AccessFlags = 20, Signature = "(Ljava/lang/String;)Ljava/lang/Class<*>;")]
				protected internal global::System.Type FindSystemClass(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::System.Type);
				}

				/// <java-name>
				/// getResource
				/// </java-name>
				[Dot42.DexImport("getResource", "(Ljava/lang/String;)Ljava/net/URL;", AccessFlags = 1)]
				public virtual global::Java.Net.URL GetResource(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.URL);
				}

				/// <java-name>
				/// getResources
				/// </java-name>
				[Dot42.DexImport("getResources", "(Ljava/lang/String;)Ljava/util/Enumeration;", AccessFlags = 1, Signature = "(Ljava/lang/String;)Ljava/util/Enumeration<Ljava/net/URL;>;")]
				public virtual global::Java.Util.IEnumeration<global::Java.Net.URL> GetResources(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IEnumeration<global::Java.Net.URL>);
				}

				/// <java-name>
				/// getResourceAsStream
				/// </java-name>
				[Dot42.DexImport("getResourceAsStream", "(Ljava/lang/String;)Ljava/io/InputStream;", AccessFlags = 1)]
				public virtual global::Java.Io.InputStream GetResourceAsStream(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.InputStream);
				}

				/// <java-name>
				/// loadClass
				/// </java-name>
				[Dot42.DexImport("loadClass", "(Ljava/lang/String;)Ljava/lang/Class;", AccessFlags = 1, Signature = "(Ljava/lang/String;)Ljava/lang/Class<*>;")]
				public virtual global::System.Type LoadClass(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::System.Type);
				}

				/// <java-name>
				/// loadClass
				/// </java-name>
				[Dot42.DexImport("loadClass", "(Ljava/lang/String;Z)Ljava/lang/Class;", AccessFlags = 4, Signature = "(Ljava/lang/String;Z)Ljava/lang/Class<*>;")]
				protected internal virtual global::System.Type LoadClass(string @string, bool boolean) /* MethodBuilder.Create */ 
				{
						return default(global::System.Type);
				}

				/// <java-name>
				/// resolveClass
				/// </java-name>
				[Dot42.DexImport("resolveClass", "(Ljava/lang/Class;)V", AccessFlags = 20, Signature = "(Ljava/lang/Class<*>;)V")]
				protected internal void ResolveClass(global::System.Type type) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// findResource
				/// </java-name>
				[Dot42.DexImport("findResource", "(Ljava/lang/String;)Ljava/net/URL;", AccessFlags = 4)]
				protected internal virtual global::Java.Net.URL FindResource(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.URL);
				}

				/// <java-name>
				/// findResources
				/// </java-name>
				[Dot42.DexImport("findResources", "(Ljava/lang/String;)Ljava/util/Enumeration;", AccessFlags = 4, Signature = "(Ljava/lang/String;)Ljava/util/Enumeration<Ljava/net/URL;>;")]
				protected internal virtual global::Java.Util.IEnumeration<global::Java.Net.URL> FindResources(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IEnumeration<global::Java.Net.URL>);
				}

				/// <java-name>
				/// findLibrary
				/// </java-name>
				[Dot42.DexImport("findLibrary", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 4)]
				protected internal virtual string FindLibrary(string @string) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getPackage
				/// </java-name>
				[Dot42.DexImport("getPackage", "(Ljava/lang/String;)Ljava/lang/Package;", AccessFlags = 4)]
				protected internal virtual global::Java.Lang.Package GetPackage(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.Package);
				}

				/// <java-name>
				/// definePackage
				/// </java-name>
				[Dot42.DexImport("definePackage", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/la" +
    "ng/String;Ljava/lang/String;Ljava/lang/String;Ljava/net/URL;)Ljava/lang/Package;" +
    "", AccessFlags = 4)]
				protected internal virtual global::Java.Lang.Package DefinePackage(string @string, string string1, string string2, string string3, string string4, string string5, string string6, global::Java.Net.URL uRL) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.Package);
				}

				/// <java-name>
				/// setSigners
				/// </java-name>
				[Dot42.DexImport("setSigners", "(Ljava/lang/Class;[Ljava/lang/Object;)V", AccessFlags = 20, Signature = "(Ljava/lang/Class<*>;[Ljava/lang/Object;)V")]
				protected internal void SetSigners(global::System.Type type, object[] @object) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setClassAssertionStatus
				/// </java-name>
				[Dot42.DexImport("setClassAssertionStatus", "(Ljava/lang/String;Z)V", AccessFlags = 1)]
				public virtual void SetClassAssertionStatus(string @string, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setPackageAssertionStatus
				/// </java-name>
				[Dot42.DexImport("setPackageAssertionStatus", "(Ljava/lang/String;Z)V", AccessFlags = 1)]
				public virtual void SetPackageAssertionStatus(string @string, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setDefaultAssertionStatus
				/// </java-name>
				[Dot42.DexImport("setDefaultAssertionStatus", "(Z)V", AccessFlags = 1)]
				public virtual void SetDefaultAssertionStatus(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// clearAssertionStatus
				/// </java-name>
				[Dot42.DexImport("clearAssertionStatus", "()V", AccessFlags = 1)]
				public virtual void ClearAssertionStatus() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getSystemClassLoader
				/// </java-name>
				public static global::Java.Lang.ClassLoader SystemClassLoader
				{
						[Dot42.DexImport("getSystemClassLoader", "()Ljava/lang/ClassLoader;", AccessFlags = 9)]
						get{ return default(global::Java.Lang.ClassLoader); }
				}

				/// <java-name>
				/// getParent
				/// </java-name>
				public global::Java.Lang.ClassLoader Parent
				{
						[Dot42.DexImport("getParent", "()Ljava/lang/ClassLoader;", AccessFlags = 17)]
						get{ return default(global::Java.Lang.ClassLoader); }
				}

				/// <java-name>
				/// getPackages
				/// </java-name>
				protected internal virtual global::Java.Lang.Package[] Packages
				{
						[Dot42.DexImport("getPackages", "()[Ljava/lang/Package;", AccessFlags = 4)]
						get{ return default(global::Java.Lang.Package[]); }
				}

		}

		/// <java-name>
		/// java/lang/ClassNotFoundException
		/// </java-name>
		[Dot42.DexImport("java/lang/ClassNotFoundException", AccessFlags = 33)]
		public partial class ClassNotFoundException : global::System.Exception
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ClassNotFoundException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public ClassNotFoundException(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public ClassNotFoundException(string @string, global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getException
				/// </java-name>
				public virtual global::System.Exception Exception
				{
						[Dot42.DexImport("getException", "()Ljava/lang/Throwable;", AccessFlags = 1)]
						get{ return default(global::System.Exception); }
				}

				/// <java-name>
				/// getCause
				/// </java-name>
				public override global::System.Exception Cause
				{
						[Dot42.DexImport("getCause", "()Ljava/lang/Throwable;", AccessFlags = 1)]
						get{ return default(global::System.Exception); }
				}

		}

		/// <java-name>
		/// java/lang/CloneNotSupportedException
		/// </java-name>
		[Dot42.DexImport("java/lang/CloneNotSupportedException", AccessFlags = 33)]
		public partial class CloneNotSupportedException : global::System.Exception
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public CloneNotSupportedException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public CloneNotSupportedException(string @string) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/lang/Compiler
		/// </java-name>
		[Dot42.DexImport("java/lang/Compiler", AccessFlags = 49)]
		public sealed partial class Compiler
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal Compiler() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// command
				/// </java-name>
				[Dot42.DexImport("command", "(Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 9)]
				public static object Command(object @object) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <java-name>
				/// compileClass
				/// </java-name>
				[Dot42.DexImport("compileClass", "(Ljava/lang/Class;)Z", AccessFlags = 9, Signature = "(Ljava/lang/Class<*>;)Z")]
				public static bool CompileClass(global::System.Type type) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// compileClasses
				/// </java-name>
				[Dot42.DexImport("compileClasses", "(Ljava/lang/String;)Z", AccessFlags = 9)]
				public static bool CompileClasses(string @string) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// disable
				/// </java-name>
				[Dot42.DexImport("disable", "()V", AccessFlags = 9)]
				public static void Disable() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// enable
				/// </java-name>
				[Dot42.DexImport("enable", "()V", AccessFlags = 9)]
				public static void Enable() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/lang/Enum
		/// </java-name>
		[Dot42.DexImport("java/lang/Enum", AccessFlags = 1057, Signature = "<E:Ljava/lang/Enum<TE;>;>Ljava/lang/Object;Ljava/io/Serializable;Ljava/lang/Compa" +
    "rable<TE;>;")]
		public abstract partial class Enum<E> : global::Java.Io.ISerializable, global::System.IComparable<E>
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;I)V", AccessFlags = 4)]
				protected internal Enum(string @string, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// name
				/// </java-name>
				[Dot42.DexImport("name", "()Ljava/lang/String;", AccessFlags = 17)]
				public string Name() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// ordinal
				/// </java-name>
				[Dot42.DexImport("ordinal", "()I", AccessFlags = 17)]
				public int Ordinal() /* MethodBuilder.Create */ 
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

				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 17)]
				public override bool Equals(object @object) /* MethodBuilder.Create */ 
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

				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/lang/Object;", AccessFlags = 20)]
				protected internal object Clone() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <java-name>
				/// compareTo
				/// </java-name>
				[Dot42.DexImport("compareTo", "(Ljava/lang/Enum;)I", AccessFlags = 17, Signature = "(TE;)I")]
				public int CompareTo(E e) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// valueOf
				/// </java-name>
				[Dot42.DexImport("valueOf", "(Ljava/lang/Class;Ljava/lang/String;)Ljava/lang/Enum;", AccessFlags = 9, Signature = "<T:Ljava/lang/Enum<TT;>;>(Ljava/lang/Class<TT;>;Ljava/lang/String;)TT;")]
				public static T ValueOf<T>(global::System.Type type, string @string) /* MethodBuilder.Create */ 
				{
						return default(T);
				}

				/// <java-name>
				/// finalize
				/// </java-name>
				[Dot42.DexImport("finalize", "()V", AccessFlags = 20)]
				extern ~Enum() /* MethodBuilder.Create */ ;

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal Enum() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getDeclaringClass
				/// </java-name>
				public global::System.Type DeclaringClass
				{
						[Dot42.DexImport("getDeclaringClass", "()Ljava/lang/Class;", AccessFlags = 17, Signature = "()Ljava/lang/Class<TE;>;")]
						get{ return default(global::System.Type); }
				}

		}

		/// <java-name>
		/// java/lang/EnumConstantNotPresentException
		/// </java-name>
		[Dot42.DexImport("java/lang/EnumConstantNotPresentException", AccessFlags = 33)]
		public partial class EnumConstantNotPresentException : global::System.SystemException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/Class;Ljava/lang/String;)V", AccessFlags = 1, Signature = "(Ljava/lang/Class<+Ljava/lang/Enum;>;Ljava/lang/String;)V")]
				public EnumConstantNotPresentException(global::System.Type type, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// enumType
				/// </java-name>
				[Dot42.DexImport("enumType", "()Ljava/lang/Class;", AccessFlags = 1, Signature = "()Ljava/lang/Class<+Ljava/lang/Enum;>;")]
				public virtual global::System.Type EnumType() /* MethodBuilder.Create */ 
				{
						return default(global::System.Type);
				}

				/// <java-name>
				/// constantName
				/// </java-name>
				[Dot42.DexImport("constantName", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string ConstantName() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal EnumConstantNotPresentException() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// java/lang/Error
		/// </java-name>
		[Dot42.DexImport("java/lang/Error", AccessFlags = 33)]
		public partial class Error : global::System.Exception
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Error() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public Error(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public Error(string @string, global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public Error(global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/lang/Exception
		/// </java-name>
		[Dot42.DexImport("java/lang/Exception", AccessFlags = 33)]
		public partial class Exception : global::System.Exception
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Exception() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public Exception(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public Exception(string @string, global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public Exception(global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/lang/ExceptionInInitializerError
		/// </java-name>
		[Dot42.DexImport("java/lang/ExceptionInInitializerError", AccessFlags = 33)]
		public partial class ExceptionInInitializerError : global::Java.Lang.LinkageError
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ExceptionInInitializerError() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public ExceptionInInitializerError(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public ExceptionInInitializerError(global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getException
				/// </java-name>
				public virtual global::System.Exception Exception
				{
						[Dot42.DexImport("getException", "()Ljava/lang/Throwable;", AccessFlags = 1)]
						get{ return default(global::System.Exception); }
				}

				/// <java-name>
				/// getCause
				/// </java-name>
				public override global::System.Exception Cause
				{
						[Dot42.DexImport("getCause", "()Ljava/lang/Throwable;", AccessFlags = 1)]
						get{ return default(global::System.Exception); }
				}

		}

		/// <java-name>
		/// java/lang/Appendable
		/// </java-name>
		[Dot42.DexImport("java/lang/Appendable", AccessFlags = 1537)]
		public partial interface IAppendable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// append
				/// </java-name>
				[Dot42.DexImport("append", "(C)Ljava/lang/Appendable;", AccessFlags = 1025)]
				global::Java.Lang.IAppendable Append(char @char) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// append
				/// </java-name>
				[Dot42.DexImport("append", "(Ljava/lang/CharSequence;)Ljava/lang/Appendable;", AccessFlags = 1025)]
				global::Java.Lang.IAppendable Append(global::Java.Lang.ICharSequence charSequence) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// append
				/// </java-name>
				[Dot42.DexImport("append", "(Ljava/lang/CharSequence;II)Ljava/lang/Appendable;", AccessFlags = 1025)]
				global::Java.Lang.IAppendable JavaAppend(global::Java.Lang.ICharSequence charSequence, int int32, int int321) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// java/lang/CharSequence
		/// </java-name>
		[Dot42.DexImport("java/lang/CharSequence", AccessFlags = 1537)]
		public partial interface ICharSequence
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// length
				/// </java-name>
				[Dot42.DexImport("length", "()I", AccessFlags = 1025)]
				int Length() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// charAt
				/// </java-name>
				[Dot42.DexImport("charAt", "(I)C", AccessFlags = 1025)]
				char CharAt(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// subSequence
				/// </java-name>
				[Dot42.DexImport("subSequence", "(II)Ljava/lang/CharSequence;", AccessFlags = 1025)]
				global::Java.Lang.ICharSequence SubSequence(int int32, int int321) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1025)]
				string ToString() /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// java/lang/Cloneable
		/// </java-name>
		[Dot42.DexImport("java/lang/Cloneable", AccessFlags = 1537)]
		public partial interface ICloneable
 /* scope: __dot42__ */ 
		{
		}

		/// <java-name>
		/// java/lang/Deprecated
		/// </java-name>
		[Dot42.DexImport("java/lang/Deprecated", AccessFlags = 9729)]
		public partial interface IDeprecated : global::Java.Lang.Annotation.IAnnotation
 /* scope: __dot42__ */ 
		{
		}

		/// <java-name>
		/// java/lang/Iterable
		/// </java-name>
		[Dot42.DexImport("java/lang/Iterable", AccessFlags = 1537, Signature = "<T:Ljava/lang/Object;>Ljava/lang/Object;")]
		public partial interface IIterable<T>
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// iterator
				/// </java-name>
				[Dot42.DexImport("iterator", "()Ljava/util/Iterator;", AccessFlags = 1025, Signature = "()Ljava/util/Iterator<TT;>;")]
				global::Java.Util.IIterator<T> Iterator() /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// java/lang/IllegalAccessError
		/// </java-name>
		[Dot42.DexImport("java/lang/IllegalAccessError", AccessFlags = 33)]
		public partial class IllegalAccessError : global::Java.Lang.IncompatibleClassChangeError
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public IllegalAccessError() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public IllegalAccessError(string @string) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/lang/IllegalAccessException
		/// </java-name>
		[Dot42.DexImport("java/lang/IllegalAccessException", AccessFlags = 33)]
		public partial class IllegalAccessException : global::System.Exception
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public IllegalAccessException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public IllegalAccessException(string @string) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/lang/IllegalMonitorStateException
		/// </java-name>
		[Dot42.DexImport("java/lang/IllegalMonitorStateException", AccessFlags = 33)]
		public partial class IllegalMonitorStateException : global::System.SystemException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public IllegalMonitorStateException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public IllegalMonitorStateException(string @string) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/lang/IllegalStateException
		/// </java-name>
		[Dot42.DexImport("java/lang/IllegalStateException", AccessFlags = 33)]
		public partial class IllegalStateException : global::System.SystemException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public IllegalStateException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public IllegalStateException(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public IllegalStateException(string @string, global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public IllegalStateException(global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/lang/IllegalThreadStateException
		/// </java-name>
		[Dot42.DexImport("java/lang/IllegalThreadStateException", AccessFlags = 33)]
		public partial class IllegalThreadStateException : global::System.ArgumentException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public IllegalThreadStateException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public IllegalThreadStateException(string @string) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/lang/IncompatibleClassChangeError
		/// </java-name>
		[Dot42.DexImport("java/lang/IncompatibleClassChangeError", AccessFlags = 33)]
		public partial class IncompatibleClassChangeError : global::Java.Lang.LinkageError
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public IncompatibleClassChangeError() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public IncompatibleClassChangeError(string @string) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/lang/InheritableThreadLocal
		/// </java-name>
		[Dot42.DexImport("java/lang/InheritableThreadLocal", AccessFlags = 33, Signature = "<T:Ljava/lang/Object;>Ljava/lang/ThreadLocal<TT;>;")]
		public partial class InheritableThreadLocal<T> : global::Java.Lang.ThreadLocal<T>
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public InheritableThreadLocal() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// childValue
				/// </java-name>
				[Dot42.DexImport("childValue", "(Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 4, Signature = "(TT;)TT;")]
				protected internal virtual T ChildValue(T t) /* MethodBuilder.Create */ 
				{
						return default(T);
				}

		}

		/// <java-name>
		/// java/lang/InstantiationError
		/// </java-name>
		[Dot42.DexImport("java/lang/InstantiationError", AccessFlags = 33)]
		public partial class InstantiationError : global::Java.Lang.IncompatibleClassChangeError
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public InstantiationError() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public InstantiationError(string @string) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/lang/InstantiationException
		/// </java-name>
		[Dot42.DexImport("java/lang/InstantiationException", AccessFlags = 33)]
		public partial class InstantiationException : global::System.Exception
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public InstantiationException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public InstantiationException(string @string) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/lang/InternalError
		/// </java-name>
		[Dot42.DexImport("java/lang/InternalError", AccessFlags = 33)]
		public partial class InternalError : global::Java.Lang.VirtualMachineError
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public InternalError() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public InternalError(string @string) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/lang/InterruptedException
		/// </java-name>
		[Dot42.DexImport("java/lang/InterruptedException", AccessFlags = 33)]
		public partial class InterruptedException : global::System.Exception
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public InterruptedException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public InterruptedException(string @string) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/lang/Override
		/// </java-name>
		[Dot42.DexImport("java/lang/Override", AccessFlags = 9729)]
		public partial interface IOverride : global::Java.Lang.Annotation.IAnnotation
 /* scope: __dot42__ */ 
		{
		}

		/// <java-name>
		/// java/lang/Readable
		/// </java-name>
		[Dot42.DexImport("java/lang/Readable", AccessFlags = 1537)]
		public partial interface IReadable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "(Ljava/nio/CharBuffer;)I", AccessFlags = 1025)]
				int Read(global::Java.Nio.CharBuffer charBuffer) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// java/lang/Runnable
		/// </java-name>
		[Dot42.DexImport("java/lang/Runnable", AccessFlags = 1537)]
		public partial interface IRunnable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// run
				/// </java-name>
				[Dot42.DexImport("run", "()V", AccessFlags = 1025)]
				void Run() /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// java/lang/SuppressWarnings
		/// </java-name>
		[Dot42.DexImport("java/lang/SuppressWarnings", AccessFlags = 9729)]
		public partial interface ISuppressWarnings : global::Java.Lang.Annotation.IAnnotation
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// value
				/// </java-name>
				[Dot42.DexImport("value", "()[Ljava/lang/String;", AccessFlags = 1025)]
				string[] Value() /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// java/lang/LinkageError
		/// </java-name>
		[Dot42.DexImport("java/lang/LinkageError", AccessFlags = 33)]
		public partial class LinkageError : global::Java.Lang.Error
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public LinkageError() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public LinkageError(string @string) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/lang/NegativeArraySizeException
		/// </java-name>
		[Dot42.DexImport("java/lang/NegativeArraySizeException", AccessFlags = 33)]
		public partial class NegativeArraySizeException : global::System.SystemException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public NegativeArraySizeException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public NegativeArraySizeException(string @string) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/lang/NoClassDefFoundError
		/// </java-name>
		[Dot42.DexImport("java/lang/NoClassDefFoundError", AccessFlags = 33)]
		public partial class NoClassDefFoundError : global::Java.Lang.LinkageError
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public NoClassDefFoundError() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public NoClassDefFoundError(string @string) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/lang/NoSuchFieldException
		/// </java-name>
		[Dot42.DexImport("java/lang/NoSuchFieldException", AccessFlags = 33)]
		public partial class NoSuchFieldException : global::System.Exception
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public NoSuchFieldException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public NoSuchFieldException(string @string) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/lang/NoSuchMethodException
		/// </java-name>
		[Dot42.DexImport("java/lang/NoSuchMethodException", AccessFlags = 33)]
		public partial class NoSuchMethodException : global::System.Exception
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public NoSuchMethodException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public NoSuchMethodException(string @string) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/lang/Number
		/// </java-name>
		[Dot42.DexImport("java/lang/Number", AccessFlags = 1057)]
		public abstract partial class Number : global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Number() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// byteValue
				/// </java-name>
				[Dot42.DexImport("byteValue", "()B", AccessFlags = 1)]
				public virtual sbyte ByteValue() /* MethodBuilder.Create */ 
				{
						return default(sbyte);
				}

				/// <java-name>
				/// doubleValue
				/// </java-name>
				[Dot42.DexImport("doubleValue", "()D", AccessFlags = 1025)]
				public abstract double DoubleValue() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// floatValue
				/// </java-name>
				[Dot42.DexImport("floatValue", "()F", AccessFlags = 1025)]
				public abstract float FloatValue() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// intValue
				/// </java-name>
				[Dot42.DexImport("intValue", "()I", AccessFlags = 1025)]
				public abstract int IntValue() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// longValue
				/// </java-name>
				[Dot42.DexImport("longValue", "()J", AccessFlags = 1025)]
				public abstract long LongValue() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// shortValue
				/// </java-name>
				[Dot42.DexImport("shortValue", "()S", AccessFlags = 1)]
				public virtual short ShortValue() /* MethodBuilder.Create */ 
				{
						return default(short);
				}

		}

		/// <java-name>
		/// java/lang/NumberFormatException
		/// </java-name>
		[Dot42.DexImport("java/lang/NumberFormatException", AccessFlags = 33)]
		public partial class NumberFormatException : global::System.ArgumentException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public NumberFormatException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public NumberFormatException(string @string) /* MethodBuilder.Create */ 
				{
				}

		}

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

				/// <java-name>
				/// getAnnotation
				/// </java-name>
				[Dot42.DexImport("getAnnotation", "(Ljava/lang/Class;)Ljava/lang/annotation/Annotation;", AccessFlags = 1, Signature = "<A::Ljava/lang/annotation/Annotation;>(Ljava/lang/Class<TA;>;)TA;")]
				public virtual A GetAnnotation<A>(global::System.Type type) /* MethodBuilder.Create */ 
				{
						return default(A);
				}

				/// <java-name>
				/// getAnnotations
				/// </java-name>
				[Dot42.DexImport("getAnnotations", "()[Ljava/lang/annotation/Annotation;", AccessFlags = 1)]
				public virtual global::Java.Lang.Annotation.IAnnotation[] GetAnnotations() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.Annotation.IAnnotation[]);
				}

				/// <java-name>
				/// getDeclaredAnnotations
				/// </java-name>
				[Dot42.DexImport("getDeclaredAnnotations", "()[Ljava/lang/annotation/Annotation;", AccessFlags = 1)]
				public virtual global::Java.Lang.Annotation.IAnnotation[] GetDeclaredAnnotations() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.Annotation.IAnnotation[]);
				}

				/// <java-name>
				/// isAnnotationPresent
				/// </java-name>
				[Dot42.DexImport("isAnnotationPresent", "(Ljava/lang/Class;)Z", AccessFlags = 1, Signature = "(Ljava/lang/Class<+Ljava/lang/annotation/Annotation;>;)Z")]
				public virtual bool IsAnnotationPresent(global::System.Type type) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getPackage
				/// </java-name>
				[Dot42.DexImport("getPackage", "(Ljava/lang/String;)Ljava/lang/Package;", AccessFlags = 9)]
				public static global::Java.Lang.Package GetPackage(string @string) /* MethodBuilder.Create */ 
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

				/// <java-name>
				/// isCompatibleWith
				/// </java-name>
				[Dot42.DexImport("isCompatibleWith", "(Ljava/lang/String;)Z", AccessFlags = 1)]
				public virtual bool IsCompatibleWith(string @string) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isSealed
				/// </java-name>
				[Dot42.DexImport("isSealed", "()Z", AccessFlags = 1)]
				public virtual bool IsSealed() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isSealed
				/// </java-name>
				[Dot42.DexImport("isSealed", "(Ljava/net/URL;)Z", AccessFlags = 1)]
				public virtual bool IsSealed(global::Java.Net.URL uRL) /* MethodBuilder.Create */ 
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

				[Dot42.DexImport("java/lang/reflect/AnnotatedElement", "getAnnotation", "(Ljava/lang/Class;)Ljava/lang/annotation/Annotation;", AccessFlags = 1025, Signature = "<T::Ljava/lang/annotation/Annotation;>(Ljava/lang/Class<TT;>;)TT;")]
				T global::Java.Lang.Reflect.IAnnotatedElement.GetAnnotation<T>(global::System.Type type) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(T);
				}

				/// <java-name>
				/// getImplementationTitle
				/// </java-name>
				public virtual string ImplementationTitle
				{
						[Dot42.DexImport("getImplementationTitle", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getImplementationVendor
				/// </java-name>
				public virtual string ImplementationVendor
				{
						[Dot42.DexImport("getImplementationVendor", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getImplementationVersion
				/// </java-name>
				public virtual string ImplementationVersion
				{
						[Dot42.DexImport("getImplementationVersion", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
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
				/// getPackages
				/// </java-name>
				public static global::Java.Lang.Package[] Packages
				{
						[Dot42.DexImport("getPackages", "()[Ljava/lang/Package;", AccessFlags = 9)]
						get{ return default(global::Java.Lang.Package[]); }
				}

				/// <java-name>
				/// getSpecificationTitle
				/// </java-name>
				public virtual string SpecificationTitle
				{
						[Dot42.DexImport("getSpecificationTitle", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getSpecificationVendor
				/// </java-name>
				public virtual string SpecificationVendor
				{
						[Dot42.DexImport("getSpecificationVendor", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getSpecificationVersion
				/// </java-name>
				public virtual string SpecificationVersion
				{
						[Dot42.DexImport("getSpecificationVersion", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

		}

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

				/// <java-name>
				/// destroy
				/// </java-name>
				[Dot42.DexImport("destroy", "()V", AccessFlags = 1025)]
				public abstract void Destroy() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// exitValue
				/// </java-name>
				[Dot42.DexImport("exitValue", "()I", AccessFlags = 1025)]
				public abstract int ExitValue() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// waitFor
				/// </java-name>
				[Dot42.DexImport("waitFor", "()I", AccessFlags = 1025)]
				public abstract int WaitFor() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getErrorStream
				/// </java-name>
				public abstract global::Java.Io.InputStream ErrorStream
				{
						[Dot42.DexImport("getErrorStream", "()Ljava/io/InputStream;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getInputStream
				/// </java-name>
				public abstract global::Java.Io.InputStream InputStream
				{
						[Dot42.DexImport("getInputStream", "()Ljava/io/InputStream;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getOutputStream
				/// </java-name>
				public abstract global::Java.Io.OutputStream OutputStream
				{
						[Dot42.DexImport("getOutputStream", "()Ljava/io/OutputStream;", AccessFlags = 1025)]
						get;
				}

		}

		/// <java-name>
		/// java/lang/ProcessBuilder
		/// </java-name>
		[Dot42.DexImport("java/lang/ProcessBuilder", AccessFlags = 49)]
		public sealed partial class ProcessBuilder
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "([Ljava/lang/String;)V", AccessFlags = 129)]
				public ProcessBuilder(params string[] @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/util/List;)V", AccessFlags = 1, Signature = "(Ljava/util/List<Ljava/lang/String;>;)V")]
				public ProcessBuilder(global::Java.Util.IList<string> list) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// command
				/// </java-name>
				[Dot42.DexImport("command", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Ljava/lang/String;>;")]
				public global::Java.Util.IList<string> Command() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<string>);
				}

				/// <java-name>
				/// command
				/// </java-name>
				[Dot42.DexImport("command", "([Ljava/lang/String;)Ljava/lang/ProcessBuilder;", AccessFlags = 129)]
				public global::Java.Lang.ProcessBuilder Command(params string[] @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ProcessBuilder);
				}

				/// <java-name>
				/// command
				/// </java-name>
				[Dot42.DexImport("command", "(Ljava/util/List;)Ljava/lang/ProcessBuilder;", AccessFlags = 1, Signature = "(Ljava/util/List<Ljava/lang/String;>;)Ljava/lang/ProcessBuilder;")]
				public global::Java.Lang.ProcessBuilder Command(global::Java.Util.IList<string> list) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ProcessBuilder);
				}

				/// <java-name>
				/// directory
				/// </java-name>
				[Dot42.DexImport("directory", "()Ljava/io/File;", AccessFlags = 1)]
				public global::Java.Io.File Directory() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.File);
				}

				/// <java-name>
				/// directory
				/// </java-name>
				[Dot42.DexImport("directory", "(Ljava/io/File;)Ljava/lang/ProcessBuilder;", AccessFlags = 1)]
				public global::Java.Lang.ProcessBuilder Directory(global::Java.Io.File file) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ProcessBuilder);
				}

				/// <java-name>
				/// environment
				/// </java-name>
				[Dot42.DexImport("environment", "()Ljava/util/Map;", AccessFlags = 1, Signature = "()Ljava/util/Map<Ljava/lang/String;Ljava/lang/String;>;")]
				public global::Java.Util.IMap<string, string> Environment() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IMap<string, string>);
				}

				/// <java-name>
				/// redirectErrorStream
				/// </java-name>
				[Dot42.DexImport("redirectErrorStream", "()Z", AccessFlags = 1)]
				public bool RedirectErrorStream() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// redirectErrorStream
				/// </java-name>
				[Dot42.DexImport("redirectErrorStream", "(Z)Ljava/lang/ProcessBuilder;", AccessFlags = 1)]
				public global::Java.Lang.ProcessBuilder RedirectErrorStream(bool boolean) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ProcessBuilder);
				}

				/// <java-name>
				/// start
				/// </java-name>
				[Dot42.DexImport("start", "()Ljava/lang/Process;", AccessFlags = 1)]
				public global::Java.Lang.Process Start() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.Process);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ProcessBuilder() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// java/lang/Runtime
		/// </java-name>
		[Dot42.DexImport("java/lang/Runtime", AccessFlags = 33)]
		public partial class Runtime
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal Runtime() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// exec
				/// </java-name>
				[Dot42.DexImport("exec", "([Ljava/lang/String;)Ljava/lang/Process;", AccessFlags = 1)]
				public virtual global::Java.Lang.Process Exec(string[] @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.Process);
				}

				/// <java-name>
				/// exec
				/// </java-name>
				[Dot42.DexImport("exec", "([Ljava/lang/String;[Ljava/lang/String;)Ljava/lang/Process;", AccessFlags = 1)]
				public virtual global::Java.Lang.Process Exec(string[] @string, string[] string1) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.Process);
				}

				/// <java-name>
				/// exec
				/// </java-name>
				[Dot42.DexImport("exec", "([Ljava/lang/String;[Ljava/lang/String;Ljava/io/File;)Ljava/lang/Process;", AccessFlags = 1)]
				public virtual global::Java.Lang.Process Exec(string[] @string, string[] string1, global::Java.Io.File file) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.Process);
				}

				/// <java-name>
				/// exec
				/// </java-name>
				[Dot42.DexImport("exec", "(Ljava/lang/String;)Ljava/lang/Process;", AccessFlags = 1)]
				public virtual global::Java.Lang.Process Exec(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.Process);
				}

				/// <java-name>
				/// exec
				/// </java-name>
				[Dot42.DexImport("exec", "(Ljava/lang/String;[Ljava/lang/String;)Ljava/lang/Process;", AccessFlags = 1)]
				public virtual global::Java.Lang.Process Exec(string @string, string[] string1) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.Process);
				}

				/// <java-name>
				/// exec
				/// </java-name>
				[Dot42.DexImport("exec", "(Ljava/lang/String;[Ljava/lang/String;Ljava/io/File;)Ljava/lang/Process;", AccessFlags = 1)]
				public virtual global::Java.Lang.Process Exec(string @string, string[] string1, global::Java.Io.File file) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.Process);
				}

				/// <java-name>
				/// exit
				/// </java-name>
				[Dot42.DexImport("exit", "(I)V", AccessFlags = 1)]
				public virtual void Exit(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// freeMemory
				/// </java-name>
				[Dot42.DexImport("freeMemory", "()J", AccessFlags = 257)]
				public virtual long FreeMemory() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// gc
				/// </java-name>
				[Dot42.DexImport("gc", "()V", AccessFlags = 257)]
				public virtual void Gc() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getRuntime
				/// </java-name>
				[Dot42.DexImport("getRuntime", "()Ljava/lang/Runtime;", AccessFlags = 9)]
				public static global::Java.Lang.Runtime GetRuntime() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.Runtime);
				}

				/// <java-name>
				/// load
				/// </java-name>
				[Dot42.DexImport("load", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void Load(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// loadLibrary
				/// </java-name>
				[Dot42.DexImport("loadLibrary", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void LoadLibrary(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// runFinalization
				/// </java-name>
				[Dot42.DexImport("runFinalization", "()V", AccessFlags = 1)]
				public virtual void RunFinalization() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// runFinalizersOnExit
				/// </java-name>
				[Dot42.DexImport("runFinalizersOnExit", "(Z)V", AccessFlags = 9)]
				public static void RunFinalizersOnExit(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// totalMemory
				/// </java-name>
				[Dot42.DexImport("totalMemory", "()J", AccessFlags = 257)]
				public virtual long TotalMemory() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// traceInstructions
				/// </java-name>
				[Dot42.DexImport("traceInstructions", "(Z)V", AccessFlags = 1)]
				public virtual void TraceInstructions(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// traceMethodCalls
				/// </java-name>
				[Dot42.DexImport("traceMethodCalls", "(Z)V", AccessFlags = 1)]
				public virtual void TraceMethodCalls(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getLocalizedInputStream
				/// </java-name>
				[Dot42.DexImport("getLocalizedInputStream", "(Ljava/io/InputStream;)Ljava/io/InputStream;", AccessFlags = 1)]
				public virtual global::Java.Io.InputStream GetLocalizedInputStream(global::Java.Io.InputStream inputStream) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.InputStream);
				}

				/// <java-name>
				/// getLocalizedOutputStream
				/// </java-name>
				[Dot42.DexImport("getLocalizedOutputStream", "(Ljava/io/OutputStream;)Ljava/io/OutputStream;", AccessFlags = 1)]
				public virtual global::Java.Io.OutputStream GetLocalizedOutputStream(global::Java.Io.OutputStream outputStream) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.OutputStream);
				}

				/// <java-name>
				/// addShutdownHook
				/// </java-name>
				[Dot42.DexImport("addShutdownHook", "(Ljava/lang/Thread;)V", AccessFlags = 1)]
				public virtual void AddShutdownHook(global::System.Threading.Thread thread) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// removeShutdownHook
				/// </java-name>
				[Dot42.DexImport("removeShutdownHook", "(Ljava/lang/Thread;)Z", AccessFlags = 1)]
				public virtual bool RemoveShutdownHook(global::System.Threading.Thread thread) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// halt
				/// </java-name>
				[Dot42.DexImport("halt", "(I)V", AccessFlags = 1)]
				public virtual void Halt(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// availableProcessors
				/// </java-name>
				[Dot42.DexImport("availableProcessors", "()I", AccessFlags = 1)]
				public virtual int AvailableProcessors() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// maxMemory
				/// </java-name>
				[Dot42.DexImport("maxMemory", "()J", AccessFlags = 257)]
				public virtual long MaxMemory() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

		}

		/// <java-name>
		/// java/lang/RuntimePermission
		/// </java-name>
		[Dot42.DexImport("java/lang/RuntimePermission", AccessFlags = 49)]
		public sealed partial class RuntimePermission : global::Java.Security.BasicPermission
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public RuntimePermission(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public RuntimePermission(string @string, string string1) /* MethodBuilder.Create */ 
				{
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
				internal RuntimePermission() /* TypeBuilder.AddDefaultConstructor */ 
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

		/// <java-name>
		/// java/lang/SecurityException
		/// </java-name>
		[Dot42.DexImport("java/lang/SecurityException", AccessFlags = 33)]
		public partial class SecurityException : global::System.SystemException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public SecurityException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public SecurityException(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public SecurityException(string @string, global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public SecurityException(global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/lang/SecurityManager
		/// </java-name>
		[Dot42.DexImport("java/lang/SecurityManager", AccessFlags = 33)]
		public partial class SecurityManager
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// inCheck
				/// </java-name>
				[Dot42.DexImport("inCheck", "Z", AccessFlags = 4)]
				protected internal bool InCheck;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public SecurityManager() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// checkAccept
				/// </java-name>
				[Dot42.DexImport("checkAccept", "(Ljava/lang/String;I)V", AccessFlags = 1)]
				public virtual void CheckAccept(string @string, int int32) /* MethodBuilder.Create */ 
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
				public virtual void CheckAccess(global::Java.Lang.ThreadGroup threadGroup) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// checkConnect
				/// </java-name>
				[Dot42.DexImport("checkConnect", "(Ljava/lang/String;I)V", AccessFlags = 1)]
				public virtual void CheckConnect(string @string, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// checkConnect
				/// </java-name>
				[Dot42.DexImport("checkConnect", "(Ljava/lang/String;ILjava/lang/Object;)V", AccessFlags = 1)]
				public virtual void CheckConnect(string @string, int int32, object @object) /* MethodBuilder.Create */ 
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
				public virtual void CheckDelete(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// checkExec
				/// </java-name>
				[Dot42.DexImport("checkExec", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void CheckExec(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// checkExit
				/// </java-name>
				[Dot42.DexImport("checkExit", "(I)V", AccessFlags = 1)]
				public virtual void CheckExit(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// checkLink
				/// </java-name>
				[Dot42.DexImport("checkLink", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void CheckLink(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// checkListen
				/// </java-name>
				[Dot42.DexImport("checkListen", "(I)V", AccessFlags = 1)]
				public virtual void CheckListen(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// checkMemberAccess
				/// </java-name>
				[Dot42.DexImport("checkMemberAccess", "(Ljava/lang/Class;I)V", AccessFlags = 1, Signature = "(Ljava/lang/Class<*>;I)V")]
				public virtual void CheckMemberAccess(global::System.Type type, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// checkMulticast
				/// </java-name>
				[Dot42.DexImport("checkMulticast", "(Ljava/net/InetAddress;)V", AccessFlags = 1)]
				public virtual void CheckMulticast(global::Java.Net.InetAddress inetAddress) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// checkMulticast
				/// </java-name>
				[Dot42.DexImport("checkMulticast", "(Ljava/net/InetAddress;B)V", AccessFlags = 1)]
				public virtual void CheckMulticast(global::Java.Net.InetAddress inetAddress, sbyte sByte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// checkMulticast
				/// </java-name>
				[Dot42.DexImport("checkMulticast", "(Ljava/net/InetAddress;B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual void CheckMulticast(global::Java.Net.InetAddress inetAddress, byte @byte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// checkPackageAccess
				/// </java-name>
				[Dot42.DexImport("checkPackageAccess", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void CheckPackageAccess(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// checkPackageDefinition
				/// </java-name>
				[Dot42.DexImport("checkPackageDefinition", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void CheckPackageDefinition(string @string) /* MethodBuilder.Create */ 
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
				public virtual void CheckPropertyAccess(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// checkRead
				/// </java-name>
				[Dot42.DexImport("checkRead", "(Ljava/io/FileDescriptor;)V", AccessFlags = 1)]
				public virtual void CheckRead(global::Java.Io.FileDescriptor fileDescriptor) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// checkRead
				/// </java-name>
				[Dot42.DexImport("checkRead", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void CheckRead(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// checkRead
				/// </java-name>
				[Dot42.DexImport("checkRead", "(Ljava/lang/String;Ljava/lang/Object;)V", AccessFlags = 1)]
				public virtual void CheckRead(string @string, object @object) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// checkSecurityAccess
				/// </java-name>
				[Dot42.DexImport("checkSecurityAccess", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void CheckSecurityAccess(string @string) /* MethodBuilder.Create */ 
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
				public virtual bool CheckTopLevelWindow(object @object) /* MethodBuilder.Create */ 
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
				public virtual void CheckWrite(global::Java.Io.FileDescriptor fileDescriptor) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// checkWrite
				/// </java-name>
				[Dot42.DexImport("checkWrite", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void CheckWrite(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// currentClassLoader
				/// </java-name>
				[Dot42.DexImport("currentClassLoader", "()Ljava/lang/ClassLoader;", AccessFlags = 4)]
				protected internal virtual global::Java.Lang.ClassLoader CurrentClassLoader() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ClassLoader);
				}

				/// <java-name>
				/// classLoaderDepth
				/// </java-name>
				[Dot42.DexImport("classLoaderDepth", "()I", AccessFlags = 4)]
				protected internal virtual int ClassLoaderDepth() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// currentLoadedClass
				/// </java-name>
				[Dot42.DexImport("currentLoadedClass", "()Ljava/lang/Class;", AccessFlags = 4, Signature = "()Ljava/lang/Class<*>;")]
				protected internal virtual global::System.Type CurrentLoadedClass() /* MethodBuilder.Create */ 
				{
						return default(global::System.Type);
				}

				/// <java-name>
				/// classDepth
				/// </java-name>
				[Dot42.DexImport("classDepth", "(Ljava/lang/String;)I", AccessFlags = 4)]
				protected internal virtual int ClassDepth(string @string) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// inClass
				/// </java-name>
				[Dot42.DexImport("inClass", "(Ljava/lang/String;)Z", AccessFlags = 4)]
				protected internal virtual bool InClass(string @string) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

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
				public virtual void CheckPermission(global::Java.Security.Permission permission, object @object) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getInCheck
				/// </java-name>
				public virtual bool IsInCheck
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

		/// <java-name>
		/// java/lang/StackTraceElement
		/// </java-name>
		[Dot42.DexImport("java/lang/StackTraceElement", AccessFlags = 49)]
		public sealed partial class StackTraceElement : global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;I)V", AccessFlags = 1)]
				public StackTraceElement(string @string, string string1, string string2, int int32) /* MethodBuilder.Create */ 
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
				internal StackTraceElement() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getClassName
				/// </java-name>
				public string ClassName
				{
						[Dot42.DexImport("getClassName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getFileName
				/// </java-name>
				public string FileName
				{
						[Dot42.DexImport("getFileName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getLineNumber
				/// </java-name>
				public int LineNumber
				{
						[Dot42.DexImport("getLineNumber", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getMethodName
				/// </java-name>
				public string MethodName
				{
						[Dot42.DexImport("getMethodName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// isNativeMethod
				/// </java-name>
				public bool IsNativeMethod
				{
						[Dot42.DexImport("isNativeMethod", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

		}

		/// <java-name>
		/// java/lang/StrictMath
		/// </java-name>
		[Dot42.DexImport("java/lang/StrictMath", AccessFlags = 49)]
		public sealed partial class StrictMath
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// E
				/// </java-name>
				[Dot42.DexImport("E", "D", AccessFlags = 25)]
				public const double E = 2.7182818284590451D;
				/// <java-name>
				/// PI
				/// </java-name>
				[Dot42.DexImport("PI", "D", AccessFlags = 25)]
				public const double PI = 3.1415926535897931D;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal StrictMath() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// abs
				/// </java-name>
				[Dot42.DexImport("abs", "(D)D", AccessFlags = 9)]
				public static double Abs(double @double) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <java-name>
				/// abs
				/// </java-name>
				[Dot42.DexImport("abs", "(F)F", AccessFlags = 9)]
				public static float Abs(float single) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// abs
				/// </java-name>
				[Dot42.DexImport("abs", "(I)I", AccessFlags = 9)]
				public static int Abs(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// abs
				/// </java-name>
				[Dot42.DexImport("abs", "(J)J", AccessFlags = 9)]
				public static long Abs(long int64) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// acos
				/// </java-name>
				[Dot42.DexImport("acos", "(D)D", AccessFlags = 265)]
				public static double Acos(double @double) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <java-name>
				/// asin
				/// </java-name>
				[Dot42.DexImport("asin", "(D)D", AccessFlags = 265)]
				public static double Asin(double @double) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <java-name>
				/// atan
				/// </java-name>
				[Dot42.DexImport("atan", "(D)D", AccessFlags = 265)]
				public static double Atan(double @double) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <java-name>
				/// atan2
				/// </java-name>
				[Dot42.DexImport("atan2", "(DD)D", AccessFlags = 265)]
				public static double Atan2(double @double, double double1) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <java-name>
				/// cbrt
				/// </java-name>
				[Dot42.DexImport("cbrt", "(D)D", AccessFlags = 265)]
				public static double Cbrt(double @double) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <java-name>
				/// ceil
				/// </java-name>
				[Dot42.DexImport("ceil", "(D)D", AccessFlags = 265)]
				public static double Ceil(double @double) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <java-name>
				/// cosh
				/// </java-name>
				[Dot42.DexImport("cosh", "(D)D", AccessFlags = 265)]
				public static double Cosh(double @double) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <java-name>
				/// cos
				/// </java-name>
				[Dot42.DexImport("cos", "(D)D", AccessFlags = 265)]
				public static double Cos(double @double) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <java-name>
				/// exp
				/// </java-name>
				[Dot42.DexImport("exp", "(D)D", AccessFlags = 265)]
				public static double Exp(double @double) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <java-name>
				/// expm1
				/// </java-name>
				[Dot42.DexImport("expm1", "(D)D", AccessFlags = 265)]
				public static double Expm1(double @double) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <java-name>
				/// floor
				/// </java-name>
				[Dot42.DexImport("floor", "(D)D", AccessFlags = 265)]
				public static double Floor(double @double) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <java-name>
				/// hypot
				/// </java-name>
				[Dot42.DexImport("hypot", "(DD)D", AccessFlags = 265)]
				public static double Hypot(double @double, double double1) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <java-name>
				/// IEEEremainder
				/// </java-name>
				[Dot42.DexImport("IEEEremainder", "(DD)D", AccessFlags = 265)]
				public static double IEEEremainder(double @double, double double1) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <java-name>
				/// log
				/// </java-name>
				[Dot42.DexImport("log", "(D)D", AccessFlags = 265)]
				public static double Log(double @double) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <java-name>
				/// log10
				/// </java-name>
				[Dot42.DexImport("log10", "(D)D", AccessFlags = 265)]
				public static double Log10(double @double) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <java-name>
				/// log1p
				/// </java-name>
				[Dot42.DexImport("log1p", "(D)D", AccessFlags = 265)]
				public static double Log1p(double @double) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <java-name>
				/// max
				/// </java-name>
				[Dot42.DexImport("max", "(DD)D", AccessFlags = 9)]
				public static double Max(double @double, double double1) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <java-name>
				/// max
				/// </java-name>
				[Dot42.DexImport("max", "(FF)F", AccessFlags = 9)]
				public static float Max(float single, float single1) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// max
				/// </java-name>
				[Dot42.DexImport("max", "(II)I", AccessFlags = 9)]
				public static int Max(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// max
				/// </java-name>
				[Dot42.DexImport("max", "(JJ)J", AccessFlags = 9)]
				public static long Max(long int64, long int641) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// min
				/// </java-name>
				[Dot42.DexImport("min", "(DD)D", AccessFlags = 9)]
				public static double Min(double @double, double double1) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <java-name>
				/// min
				/// </java-name>
				[Dot42.DexImport("min", "(FF)F", AccessFlags = 9)]
				public static float Min(float single, float single1) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// min
				/// </java-name>
				[Dot42.DexImport("min", "(II)I", AccessFlags = 9)]
				public static int Min(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// min
				/// </java-name>
				[Dot42.DexImport("min", "(JJ)J", AccessFlags = 9)]
				public static long Min(long int64, long int641) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// pow
				/// </java-name>
				[Dot42.DexImport("pow", "(DD)D", AccessFlags = 265)]
				public static double Pow(double @double, double double1) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <java-name>
				/// random
				/// </java-name>
				[Dot42.DexImport("random", "()D", AccessFlags = 9)]
				public static double Random() /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <java-name>
				/// rint
				/// </java-name>
				[Dot42.DexImport("rint", "(D)D", AccessFlags = 265)]
				public static double Rint(double @double) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <java-name>
				/// round
				/// </java-name>
				[Dot42.DexImport("round", "(D)J", AccessFlags = 9)]
				public static long Round(double @double) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// round
				/// </java-name>
				[Dot42.DexImport("round", "(F)I", AccessFlags = 9)]
				public static int Round(float single) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// signum
				/// </java-name>
				[Dot42.DexImport("signum", "(D)D", AccessFlags = 9)]
				public static double Signum(double @double) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <java-name>
				/// signum
				/// </java-name>
				[Dot42.DexImport("signum", "(F)F", AccessFlags = 9)]
				public static float Signum(float single) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// sinh
				/// </java-name>
				[Dot42.DexImport("sinh", "(D)D", AccessFlags = 265)]
				public static double Sinh(double @double) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <java-name>
				/// sin
				/// </java-name>
				[Dot42.DexImport("sin", "(D)D", AccessFlags = 265)]
				public static double Sin(double @double) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <java-name>
				/// sqrt
				/// </java-name>
				[Dot42.DexImport("sqrt", "(D)D", AccessFlags = 265)]
				public static double Sqrt(double @double) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <java-name>
				/// tan
				/// </java-name>
				[Dot42.DexImport("tan", "(D)D", AccessFlags = 265)]
				public static double Tan(double @double) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <java-name>
				/// tanh
				/// </java-name>
				[Dot42.DexImport("tanh", "(D)D", AccessFlags = 265)]
				public static double Tanh(double @double) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <java-name>
				/// toDegrees
				/// </java-name>
				[Dot42.DexImport("toDegrees", "(D)D", AccessFlags = 9)]
				public static double ToDegrees(double @double) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <java-name>
				/// toRadians
				/// </java-name>
				[Dot42.DexImport("toRadians", "(D)D", AccessFlags = 9)]
				public static double ToRadians(double @double) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <java-name>
				/// ulp
				/// </java-name>
				[Dot42.DexImport("ulp", "(D)D", AccessFlags = 9)]
				public static double Ulp(double @double) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <java-name>
				/// ulp
				/// </java-name>
				[Dot42.DexImport("ulp", "(F)F", AccessFlags = 9)]
				public static float Ulp(float single) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// copySign
				/// </java-name>
				[Dot42.DexImport("copySign", "(DD)D", AccessFlags = 9)]
				public static double CopySign(double @double, double double1) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <java-name>
				/// copySign
				/// </java-name>
				[Dot42.DexImport("copySign", "(FF)F", AccessFlags = 9)]
				public static float CopySign(float single, float single1) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// getExponent
				/// </java-name>
				[Dot42.DexImport("getExponent", "(F)I", AccessFlags = 9)]
				public static int GetExponent(float single) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getExponent
				/// </java-name>
				[Dot42.DexImport("getExponent", "(D)I", AccessFlags = 9)]
				public static int GetExponent(double @double) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// nextAfter
				/// </java-name>
				[Dot42.DexImport("nextAfter", "(DD)D", AccessFlags = 9)]
				public static double NextAfter(double @double, double double1) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <java-name>
				/// nextAfter
				/// </java-name>
				[Dot42.DexImport("nextAfter", "(FD)F", AccessFlags = 9)]
				public static float NextAfter(float single, double @double) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// nextUp
				/// </java-name>
				[Dot42.DexImport("nextUp", "(D)D", AccessFlags = 9)]
				public static double NextUp(double @double) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <java-name>
				/// nextUp
				/// </java-name>
				[Dot42.DexImport("nextUp", "(F)F", AccessFlags = 9)]
				public static float NextUp(float single) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// scalb
				/// </java-name>
				[Dot42.DexImport("scalb", "(DI)D", AccessFlags = 9)]
				public static double Scalb(double @double, int int32) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <java-name>
				/// scalb
				/// </java-name>
				[Dot42.DexImport("scalb", "(FI)F", AccessFlags = 9)]
				public static float Scalb(float single, int int32) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

		}

		/// <java-name>
		/// java/lang/StringBuffer
		/// </java-name>
		[Dot42.DexImport("java/lang/StringBuffer", AccessFlags = 49)]
		public sealed partial class StringBuffer : global::Java.Lang.IAppendable, global::Java.Io.ISerializable, global::Java.Lang.ICharSequence
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public StringBuffer() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public StringBuffer(int int32) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public StringBuffer(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/CharSequence;)V", AccessFlags = 1)]
				public StringBuffer(global::Java.Lang.ICharSequence charSequence) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// append
				/// </java-name>
				[Dot42.DexImport("append", "(Z)Ljava/lang/StringBuffer;", AccessFlags = 1)]
				public global::Java.Lang.StringBuffer Append(bool boolean) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.StringBuffer);
				}

				/// <java-name>
				/// append
				/// </java-name>
				[Dot42.DexImport("append", "(C)Ljava/lang/StringBuffer;", AccessFlags = 33)]
				public global::Java.Lang.StringBuffer Append(char @char) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.StringBuffer);
				}

				/// <java-name>
				/// append
				/// </java-name>
				[Dot42.DexImport("append", "(D)Ljava/lang/StringBuffer;", AccessFlags = 1)]
				public global::Java.Lang.StringBuffer Append(double @double) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.StringBuffer);
				}

				/// <java-name>
				/// append
				/// </java-name>
				[Dot42.DexImport("append", "(F)Ljava/lang/StringBuffer;", AccessFlags = 1)]
				public global::Java.Lang.StringBuffer Append(float single) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.StringBuffer);
				}

				/// <java-name>
				/// append
				/// </java-name>
				[Dot42.DexImport("append", "(I)Ljava/lang/StringBuffer;", AccessFlags = 1)]
				public global::Java.Lang.StringBuffer Append(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.StringBuffer);
				}

				/// <java-name>
				/// append
				/// </java-name>
				[Dot42.DexImport("append", "(J)Ljava/lang/StringBuffer;", AccessFlags = 1)]
				public global::Java.Lang.StringBuffer Append(long int64) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.StringBuffer);
				}

				/// <java-name>
				/// append
				/// </java-name>
				[Dot42.DexImport("append", "(Ljava/lang/Object;)Ljava/lang/StringBuffer;", AccessFlags = 33)]
				public global::Java.Lang.StringBuffer Append(object @object) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.StringBuffer);
				}

				/// <java-name>
				/// append
				/// </java-name>
				[Dot42.DexImport("append", "(Ljava/lang/String;)Ljava/lang/StringBuffer;", AccessFlags = 33)]
				public global::Java.Lang.StringBuffer Append(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.StringBuffer);
				}

				/// <java-name>
				/// append
				/// </java-name>
				[Dot42.DexImport("append", "(Ljava/lang/StringBuffer;)Ljava/lang/StringBuffer;", AccessFlags = 33)]
				public global::Java.Lang.StringBuffer Append(global::Java.Lang.StringBuffer stringBuffer) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.StringBuffer);
				}

				/// <java-name>
				/// append
				/// </java-name>
				[Dot42.DexImport("append", "([C)Ljava/lang/StringBuffer;", AccessFlags = 33)]
				public global::Java.Lang.StringBuffer Append(char[] @char) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.StringBuffer);
				}

				/// <java-name>
				/// append
				/// </java-name>
				[Dot42.DexImport("append", "([CII)Ljava/lang/StringBuffer;", AccessFlags = 33)]
				public global::Java.Lang.StringBuffer Append(char[] @char, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.StringBuffer);
				}

				/// <java-name>
				/// append
				/// </java-name>
				[Dot42.DexImport("append", "(Ljava/lang/CharSequence;)Ljava/lang/StringBuffer;", AccessFlags = 33)]
				public global::Java.Lang.StringBuffer Append(global::Java.Lang.ICharSequence charSequence) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.StringBuffer);
				}

				/// <java-name>
				/// append
				/// </java-name>
				[Dot42.DexImport("append", "(Ljava/lang/CharSequence;II)Ljava/lang/StringBuffer;", AccessFlags = 33)]
				public global::Java.Lang.StringBuffer JavaAppend(global::Java.Lang.ICharSequence charSequence, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.StringBuffer);
				}

				/// <java-name>
				/// appendCodePoint
				/// </java-name>
				[Dot42.DexImport("appendCodePoint", "(I)Ljava/lang/StringBuffer;", AccessFlags = 1)]
				public global::Java.Lang.StringBuffer AppendCodePoint(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.StringBuffer);
				}

				/// <java-name>
				/// charAt
				/// </java-name>
				[Dot42.DexImport("charAt", "(I)C", AccessFlags = 33)]
				public char CharAt(int int32) /* MethodBuilder.Create */ 
				{
						return default(char);
				}

				/// <java-name>
				/// codePointAt
				/// </java-name>
				[Dot42.DexImport("codePointAt", "(I)I", AccessFlags = 33)]
				public int CodePointAt(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// codePointBefore
				/// </java-name>
				[Dot42.DexImport("codePointBefore", "(I)I", AccessFlags = 33)]
				public int CodePointBefore(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// codePointCount
				/// </java-name>
				[Dot42.DexImport("codePointCount", "(II)I", AccessFlags = 33)]
				public int CodePointCount(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// delete
				/// </java-name>
				[Dot42.DexImport("delete", "(II)Ljava/lang/StringBuffer;", AccessFlags = 33)]
				public global::Java.Lang.StringBuffer Delete(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.StringBuffer);
				}

				/// <java-name>
				/// deleteCharAt
				/// </java-name>
				[Dot42.DexImport("deleteCharAt", "(I)Ljava/lang/StringBuffer;", AccessFlags = 33)]
				public global::Java.Lang.StringBuffer DeleteCharAt(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.StringBuffer);
				}

				/// <java-name>
				/// ensureCapacity
				/// </java-name>
				[Dot42.DexImport("ensureCapacity", "(I)V", AccessFlags = 33)]
				public void EnsureCapacity(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getChars
				/// </java-name>
				[Dot42.DexImport("getChars", "(II[CI)V", AccessFlags = 33)]
				public void GetChars(int int32, int int321, char[] @char, int int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// indexOf
				/// </java-name>
				[Dot42.DexImport("indexOf", "(Ljava/lang/String;I)I", AccessFlags = 33)]
				public int IndexOf(string @string, int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// insert
				/// </java-name>
				[Dot42.DexImport("insert", "(IC)Ljava/lang/StringBuffer;", AccessFlags = 33)]
				public global::Java.Lang.StringBuffer Insert(int int32, char @char) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.StringBuffer);
				}

				/// <java-name>
				/// insert
				/// </java-name>
				[Dot42.DexImport("insert", "(IZ)Ljava/lang/StringBuffer;", AccessFlags = 1)]
				public global::Java.Lang.StringBuffer Insert(int int32, bool boolean) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.StringBuffer);
				}

				/// <java-name>
				/// insert
				/// </java-name>
				[Dot42.DexImport("insert", "(II)Ljava/lang/StringBuffer;", AccessFlags = 1)]
				public global::Java.Lang.StringBuffer Insert(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.StringBuffer);
				}

				/// <java-name>
				/// insert
				/// </java-name>
				[Dot42.DexImport("insert", "(IJ)Ljava/lang/StringBuffer;", AccessFlags = 1)]
				public global::Java.Lang.StringBuffer Insert(int int32, long int64) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.StringBuffer);
				}

				/// <java-name>
				/// insert
				/// </java-name>
				[Dot42.DexImport("insert", "(ID)Ljava/lang/StringBuffer;", AccessFlags = 1)]
				public global::Java.Lang.StringBuffer Insert(int int32, double @double) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.StringBuffer);
				}

				/// <java-name>
				/// insert
				/// </java-name>
				[Dot42.DexImport("insert", "(IF)Ljava/lang/StringBuffer;", AccessFlags = 1)]
				public global::Java.Lang.StringBuffer Insert(int int32, float single) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.StringBuffer);
				}

				/// <java-name>
				/// insert
				/// </java-name>
				[Dot42.DexImport("insert", "(ILjava/lang/Object;)Ljava/lang/StringBuffer;", AccessFlags = 1)]
				public global::Java.Lang.StringBuffer Insert(int int32, object @object) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.StringBuffer);
				}

				/// <java-name>
				/// insert
				/// </java-name>
				[Dot42.DexImport("insert", "(ILjava/lang/String;)Ljava/lang/StringBuffer;", AccessFlags = 33)]
				public global::Java.Lang.StringBuffer Insert(int int32, string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.StringBuffer);
				}

				/// <java-name>
				/// insert
				/// </java-name>
				[Dot42.DexImport("insert", "(I[C)Ljava/lang/StringBuffer;", AccessFlags = 33)]
				public global::Java.Lang.StringBuffer Insert(int int32, char[] @char) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.StringBuffer);
				}

				/// <java-name>
				/// insert
				/// </java-name>
				[Dot42.DexImport("insert", "(I[CII)Ljava/lang/StringBuffer;", AccessFlags = 33)]
				public global::Java.Lang.StringBuffer Insert(int int32, char[] @char, int int321, int int322) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.StringBuffer);
				}

				/// <java-name>
				/// insert
				/// </java-name>
				[Dot42.DexImport("insert", "(ILjava/lang/CharSequence;)Ljava/lang/StringBuffer;", AccessFlags = 33)]
				public global::Java.Lang.StringBuffer Insert(int int32, global::Java.Lang.ICharSequence charSequence) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.StringBuffer);
				}

				/// <java-name>
				/// insert
				/// </java-name>
				[Dot42.DexImport("insert", "(ILjava/lang/CharSequence;II)Ljava/lang/StringBuffer;", AccessFlags = 33)]
				public global::Java.Lang.StringBuffer Insert(int int32, global::Java.Lang.ICharSequence charSequence, int int321, int int322) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.StringBuffer);
				}

				/// <java-name>
				/// lastIndexOf
				/// </java-name>
				[Dot42.DexImport("lastIndexOf", "(Ljava/lang/String;I)I", AccessFlags = 33)]
				public int LastIndexOf(string @string, int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// offsetByCodePoints
				/// </java-name>
				[Dot42.DexImport("offsetByCodePoints", "(II)I", AccessFlags = 33)]
				public int OffsetByCodePoints(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// replace
				/// </java-name>
				[Dot42.DexImport("replace", "(IILjava/lang/String;)Ljava/lang/StringBuffer;", AccessFlags = 33)]
				public global::Java.Lang.StringBuffer Replace(int int32, int int321, string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.StringBuffer);
				}

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
				public void SetCharAt(int int32, char @char) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setLength
				/// </java-name>
				[Dot42.DexImport("setLength", "(I)V", AccessFlags = 33)]
				public void SetLength(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// subSequence
				/// </java-name>
				[Dot42.DexImport("subSequence", "(II)Ljava/lang/CharSequence;", AccessFlags = 33)]
				public global::Java.Lang.ICharSequence SubSequence(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <java-name>
				/// substring
				/// </java-name>
				[Dot42.DexImport("substring", "(I)Ljava/lang/String;", AccessFlags = 33)]
				public string Substring(int int32) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// substring
				/// </java-name>
				[Dot42.DexImport("substring", "(II)Ljava/lang/String;", AccessFlags = 33)]
				public string Substring(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

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
		/// java/lang/StringIndexOutOfBoundsException
		/// </java-name>
		[Dot42.DexImport("java/lang/StringIndexOutOfBoundsException", AccessFlags = 33)]
		public partial class StringIndexOutOfBoundsException : global::System.IndexOutOfRangeException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public StringIndexOutOfBoundsException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public StringIndexOutOfBoundsException(int int32) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public StringIndexOutOfBoundsException(string @string) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/lang/System
		/// </java-name>
		[Dot42.DexImport("java/lang/System", AccessFlags = 49)]
		public sealed partial class System
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// in
				/// </java-name>
				[Dot42.DexImport("in", "Ljava/io/InputStream;", AccessFlags = 25)]
				public static readonly global::Java.Io.InputStream In;
				/// <java-name>
				/// out
				/// </java-name>
				[Dot42.DexImport("out", "Ljava/io/PrintStream;", AccessFlags = 25)]
				public static readonly global::Java.Io.PrintStream Out;
				/// <java-name>
				/// err
				/// </java-name>
				[Dot42.DexImport("err", "Ljava/io/PrintStream;", AccessFlags = 25)]
				public static readonly global::Java.Io.PrintStream Err;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal System() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setIn
				/// </java-name>
				[Dot42.DexImport("setIn", "(Ljava/io/InputStream;)V", AccessFlags = 9)]
				public static void SetIn(global::Java.Io.InputStream inputStream) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setOut
				/// </java-name>
				[Dot42.DexImport("setOut", "(Ljava/io/PrintStream;)V", AccessFlags = 9)]
				public static void SetOut(global::Java.Io.PrintStream printStream) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setErr
				/// </java-name>
				[Dot42.DexImport("setErr", "(Ljava/io/PrintStream;)V", AccessFlags = 9)]
				public static void SetErr(global::Java.Io.PrintStream printStream) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// arraycopy
				/// </java-name>
				[Dot42.DexImport("arraycopy", "(Ljava/lang/Object;ILjava/lang/Object;II)V", AccessFlags = 265)]
				public static void Arraycopy(object @object, int int32, object object1, int int321, int int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// currentTimeMillis
				/// </java-name>
				[Dot42.DexImport("currentTimeMillis", "()J", AccessFlags = 265)]
				public static long CurrentTimeMillis() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// nanoTime
				/// </java-name>
				[Dot42.DexImport("nanoTime", "()J", AccessFlags = 265)]
				public static long NanoTime() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// exit
				/// </java-name>
				[Dot42.DexImport("exit", "(I)V", AccessFlags = 9)]
				public static void Exit(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// gc
				/// </java-name>
				[Dot42.DexImport("gc", "()V", AccessFlags = 9)]
				public static void Gc() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getenv
				/// </java-name>
				[Dot42.DexImport("getenv", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 9)]
				public static string Getenv(string @string) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// inheritedChannel
				/// </java-name>
				[Dot42.DexImport("inheritedChannel", "()Ljava/nio/channels/Channel;", AccessFlags = 9)]
				public static global::Java.Nio.Channels.IChannel InheritedChannel() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Nio.Channels.IChannel);
				}

				/// <java-name>
				/// getProperty
				/// </java-name>
				[Dot42.DexImport("getProperty", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 9)]
				public static string GetProperty(string @string) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getProperty
				/// </java-name>
				[Dot42.DexImport("getProperty", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 9)]
				public static string GetProperty(string @string, string string1) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// setProperty
				/// </java-name>
				[Dot42.DexImport("setProperty", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 9)]
				public static string SetProperty(string @string, string string1) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// clearProperty
				/// </java-name>
				[Dot42.DexImport("clearProperty", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 9)]
				public static string ClearProperty(string @string) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// console
				/// </java-name>
				[Dot42.DexImport("console", "()Ljava/io/Console;", AccessFlags = 9)]
				public static global::Java.Io.Console Console() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.Console);
				}

				/// <java-name>
				/// identityHashCode
				/// </java-name>
				[Dot42.DexImport("identityHashCode", "(Ljava/lang/Object;)I", AccessFlags = 265)]
				public static int IdentityHashCode(object @object) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// load
				/// </java-name>
				[Dot42.DexImport("load", "(Ljava/lang/String;)V", AccessFlags = 9)]
				public static void Load(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// loadLibrary
				/// </java-name>
				[Dot42.DexImport("loadLibrary", "(Ljava/lang/String;)V", AccessFlags = 9)]
				public static void LoadLibrary(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// runFinalization
				/// </java-name>
				[Dot42.DexImport("runFinalization", "()V", AccessFlags = 9)]
				public static void RunFinalization() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// runFinalizersOnExit
				/// </java-name>
				[Dot42.DexImport("runFinalizersOnExit", "(Z)V", AccessFlags = 9)]
				public static void RunFinalizersOnExit(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// mapLibraryName
				/// </java-name>
				[Dot42.DexImport("mapLibraryName", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 265)]
				public static string MapLibraryName(string @string) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getenv
				/// </java-name>
				public static global::Java.Util.IMap<string, string> env
				{
						[Dot42.DexImport("getenv", "()Ljava/util/Map;", AccessFlags = 9, Signature = "()Ljava/util/Map<Ljava/lang/String;Ljava/lang/String;>;")]
						get{ return default(global::Java.Util.IMap<string, string>); }
				}

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

		/// <java-name>
		/// java/lang/ThreadDeath
		/// </java-name>
		[Dot42.DexImport("java/lang/ThreadDeath", AccessFlags = 33)]
		public partial class ThreadDeath : global::Java.Lang.Error
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ThreadDeath() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/lang/ThreadGroup
		/// </java-name>
		[Dot42.DexImport("java/lang/ThreadGroup", AccessFlags = 33)]
		public partial class ThreadGroup : global::System.Threading.Thread.IUncaughtExceptionHandler
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public ThreadGroup(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/ThreadGroup;Ljava/lang/String;)V", AccessFlags = 1)]
				public ThreadGroup(global::Java.Lang.ThreadGroup threadGroup, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// activeCount
				/// </java-name>
				[Dot42.DexImport("activeCount", "()I", AccessFlags = 1)]
				public virtual int ActiveCount() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// activeGroupCount
				/// </java-name>
				[Dot42.DexImport("activeGroupCount", "()I", AccessFlags = 1)]
				public virtual int ActiveGroupCount() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// allowThreadSuspension
				/// </java-name>
				[Dot42.DexImport("allowThreadSuspension", "(Z)Z", AccessFlags = 1)]
				public virtual bool AllowThreadSuspension(bool boolean) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// checkAccess
				/// </java-name>
				[Dot42.DexImport("checkAccess", "()V", AccessFlags = 17)]
				public void CheckAccess() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// destroy
				/// </java-name>
				[Dot42.DexImport("destroy", "()V", AccessFlags = 17)]
				public void Destroy() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// enumerate
				/// </java-name>
				[Dot42.DexImport("enumerate", "([Ljava/lang/Thread;)I", AccessFlags = 1)]
				public virtual int Enumerate(global::System.Threading.Thread[] thread) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// enumerate
				/// </java-name>
				[Dot42.DexImport("enumerate", "([Ljava/lang/Thread;Z)I", AccessFlags = 1)]
				public virtual int Enumerate(global::System.Threading.Thread[] thread, bool boolean) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// enumerate
				/// </java-name>
				[Dot42.DexImport("enumerate", "([Ljava/lang/ThreadGroup;)I", AccessFlags = 1)]
				public virtual int Enumerate(global::Java.Lang.ThreadGroup[] threadGroup) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// enumerate
				/// </java-name>
				[Dot42.DexImport("enumerate", "([Ljava/lang/ThreadGroup;Z)I", AccessFlags = 1)]
				public virtual int Enumerate(global::Java.Lang.ThreadGroup[] threadGroup, bool boolean) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// interrupt
				/// </java-name>
				[Dot42.DexImport("interrupt", "()V", AccessFlags = 17)]
				public void Interrupt() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// list
				/// </java-name>
				[Dot42.DexImport("list", "()V", AccessFlags = 1)]
				public virtual void List() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// parentOf
				/// </java-name>
				[Dot42.DexImport("parentOf", "(Ljava/lang/ThreadGroup;)Z", AccessFlags = 17)]
				public bool ParentOf(global::Java.Lang.ThreadGroup threadGroup) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// resume
				/// </java-name>
				[Dot42.DexImport("resume", "()V", AccessFlags = 17)]
				public void Resume() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// stop
				/// </java-name>
				[Dot42.DexImport("stop", "()V", AccessFlags = 17)]
				public void Stop() /* MethodBuilder.Create */ 
				{
				}

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

				/// <java-name>
				/// uncaughtException
				/// </java-name>
				[Dot42.DexImport("uncaughtException", "(Ljava/lang/Thread;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public virtual void UncaughtException(global::System.Threading.Thread thread, global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ThreadGroup() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

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

				/// <java-name>
				/// getName
				/// </java-name>
				public string Name
				{
						[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 17)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getParent
				/// </java-name>
				public global::Java.Lang.ThreadGroup Parent
				{
						[Dot42.DexImport("getParent", "()Ljava/lang/ThreadGroup;", AccessFlags = 17)]
						get{ return default(global::Java.Lang.ThreadGroup); }
				}

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

				/// <java-name>
				/// isDestroyed
				/// </java-name>
				public virtual bool IsDestroyed
				{
						[Dot42.DexImport("isDestroyed", "()Z", AccessFlags = 33)]
						get{ return default(bool); }
				}

		}

		/// <java-name>
		/// java/lang/ThreadLocal
		/// </java-name>
		[Dot42.DexImport("java/lang/ThreadLocal", AccessFlags = 33, Signature = "<T:Ljava/lang/Object;>Ljava/lang/Object;")]
		public partial class ThreadLocal<T>
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ThreadLocal() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TT;")]
				public virtual T Get() /* MethodBuilder.Create */ 
				{
						return default(T);
				}

				/// <java-name>
				/// initialValue
				/// </java-name>
				[Dot42.DexImport("initialValue", "()Ljava/lang/Object;", AccessFlags = 4, Signature = "()TT;")]
				protected internal virtual T InitialValue() /* MethodBuilder.Create */ 
				{
						return default(T);
				}

				/// <java-name>
				/// set
				/// </java-name>
				[Dot42.DexImport("set", "(Ljava/lang/Object;)V", AccessFlags = 1, Signature = "(TT;)V")]
				public virtual void Set(T t) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// remove
				/// </java-name>
				[Dot42.DexImport("remove", "()V", AccessFlags = 1)]
				public virtual void Remove() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/lang/TypeNotPresentException
		/// </java-name>
		[Dot42.DexImport("java/lang/TypeNotPresentException", AccessFlags = 33)]
		public partial class TypeNotPresentException : global::System.SystemException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public TypeNotPresentException(string @string, global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// typeName
				/// </java-name>
				[Dot42.DexImport("typeName", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string TypeName() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal TypeNotPresentException() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// java/lang/UnknownError
		/// </java-name>
		[Dot42.DexImport("java/lang/UnknownError", AccessFlags = 33)]
		public partial class UnknownError : global::Java.Lang.VirtualMachineError
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public UnknownError() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public UnknownError(string @string) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/lang/UnsatisfiedLinkError
		/// </java-name>
		[Dot42.DexImport("java/lang/UnsatisfiedLinkError", AccessFlags = 33)]
		public partial class UnsatisfiedLinkError : global::Java.Lang.LinkageError
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public UnsatisfiedLinkError() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public UnsatisfiedLinkError(string @string) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/lang/UnsupportedClassVersionError
		/// </java-name>
		[Dot42.DexImport("java/lang/UnsupportedClassVersionError", AccessFlags = 33)]
		public partial class UnsupportedClassVersionError : global::Java.Lang.ClassFormatError
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public UnsupportedClassVersionError() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public UnsupportedClassVersionError(string @string) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/lang/UnsupportedOperationException
		/// </java-name>
		[Dot42.DexImport("java/lang/UnsupportedOperationException", AccessFlags = 33)]
		public partial class UnsupportedOperationException : global::System.SystemException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public UnsupportedOperationException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public UnsupportedOperationException(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public UnsupportedOperationException(string @string, global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public UnsupportedOperationException(global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/lang/VerifyError
		/// </java-name>
		[Dot42.DexImport("java/lang/VerifyError", AccessFlags = 33)]
		public partial class VerifyError : global::Java.Lang.LinkageError
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public VerifyError() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public VerifyError(string @string) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/lang/VirtualMachineError
		/// </java-name>
		[Dot42.DexImport("java/lang/VirtualMachineError", AccessFlags = 1057)]
		public abstract partial class VirtualMachineError : global::Java.Lang.Error
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public VirtualMachineError() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public VirtualMachineError(string @string) /* MethodBuilder.Create */ 
				{
				}

		}

}

