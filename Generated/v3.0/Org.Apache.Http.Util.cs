#pragma warning disable 1717
namespace Org.Apache.Http.Util
{
		/// <java-name>
		/// org/apache/http/util/ByteArrayBuffer
		/// </java-name>
		[Dot42.DexImport("org/apache/http/util/ByteArrayBuffer", AccessFlags = 49)]
		public sealed partial class ByteArrayBuffer
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public ByteArrayBuffer(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// append
				/// </java-name>
				[Dot42.DexImport("append", "([BII)V", AccessFlags = 1)]
				public void Append(sbyte[] sByte, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// append
				/// </java-name>
				[Dot42.DexImport("append", "([BII)V", AccessFlags = 1, IgnoreFromJava = true)]
				public void Append(byte[] @byte, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// append
				/// </java-name>
				[Dot42.DexImport("append", "(I)V", AccessFlags = 1)]
				public void Append(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// append
				/// </java-name>
				[Dot42.DexImport("append", "([CII)V", AccessFlags = 1)]
				public void Append(char[] @char, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// append
				/// </java-name>
				[Dot42.DexImport("append", "(Lorg/apache/http/util/CharArrayBuffer;II)V", AccessFlags = 1)]
				public void Append(global::Org.Apache.Http.Util.CharArrayBuffer charArrayBuffer, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// clear
				/// </java-name>
				[Dot42.DexImport("clear", "()V", AccessFlags = 1)]
				public void Clear() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// toByteArray
				/// </java-name>
				[Dot42.DexImport("toByteArray", "()[B", AccessFlags = 1)]
				public sbyte[] JavaToByteArray() /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <java-name>
				/// toByteArray
				/// </java-name>
				[Dot42.DexImport("toByteArray", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
				public byte[] ToByteArray() /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				/// <java-name>
				/// byteAt
				/// </java-name>
				[Dot42.DexImport("byteAt", "(I)I", AccessFlags = 1)]
				public int ByteAt(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
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
				/// buffer
				/// </java-name>
				[Dot42.DexImport("buffer", "()[B", AccessFlags = 1)]
				public sbyte[] JavaBuffer() /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <java-name>
				/// buffer
				/// </java-name>
				[Dot42.DexImport("buffer", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
				public byte[] Buffer() /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				/// <java-name>
				/// setLength
				/// </java-name>
				[Dot42.DexImport("setLength", "(I)V", AccessFlags = 1)]
				public void SetLength(int int32) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ByteArrayBuffer() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// isEmpty
				/// </java-name>
				public bool IsEmpty
				{
						[Dot42.DexImport("isEmpty", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// isFull
				/// </java-name>
				public bool IsFull
				{
						[Dot42.DexImport("isFull", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

		}

		/// <java-name>
		/// org/apache/http/util/CharArrayBuffer
		/// </java-name>
		[Dot42.DexImport("org/apache/http/util/CharArrayBuffer", AccessFlags = 49)]
		public sealed partial class CharArrayBuffer
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public CharArrayBuffer(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// append
				/// </java-name>
				[Dot42.DexImport("append", "([CII)V", AccessFlags = 1)]
				public void Append(char[] @char, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// append
				/// </java-name>
				[Dot42.DexImport("append", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public void Append(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// append
				/// </java-name>
				[Dot42.DexImport("append", "(Lorg/apache/http/util/CharArrayBuffer;II)V", AccessFlags = 1)]
				public void Append(global::Org.Apache.Http.Util.CharArrayBuffer charArrayBuffer, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// append
				/// </java-name>
				[Dot42.DexImport("append", "(Lorg/apache/http/util/CharArrayBuffer;)V", AccessFlags = 1)]
				public void Append(global::Org.Apache.Http.Util.CharArrayBuffer charArrayBuffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// append
				/// </java-name>
				[Dot42.DexImport("append", "(C)V", AccessFlags = 1)]
				public void Append(char @char) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// append
				/// </java-name>
				[Dot42.DexImport("append", "([BII)V", AccessFlags = 1)]
				public void Append(sbyte[] sByte, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// append
				/// </java-name>
				[Dot42.DexImport("append", "([BII)V", AccessFlags = 1, IgnoreFromJava = true)]
				public void Append(byte[] @byte, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// append
				/// </java-name>
				[Dot42.DexImport("append", "(Lorg/apache/http/util/ByteArrayBuffer;II)V", AccessFlags = 1)]
				public void Append(global::Org.Apache.Http.Util.ByteArrayBuffer byteArrayBuffer, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// append
				/// </java-name>
				[Dot42.DexImport("append", "(Ljava/lang/Object;)V", AccessFlags = 1)]
				public void Append(object @object) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// clear
				/// </java-name>
				[Dot42.DexImport("clear", "()V", AccessFlags = 1)]
				public void Clear() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// toCharArray
				/// </java-name>
				[Dot42.DexImport("toCharArray", "()[C", AccessFlags = 1)]
				public char[] ToCharArray() /* MethodBuilder.Create */ 
				{
						return default(char[]);
				}

				/// <java-name>
				/// charAt
				/// </java-name>
				[Dot42.DexImport("charAt", "(I)C", AccessFlags = 1)]
				public char CharAt(int int32) /* MethodBuilder.Create */ 
				{
						return default(char);
				}

				/// <java-name>
				/// buffer
				/// </java-name>
				[Dot42.DexImport("buffer", "()[C", AccessFlags = 1)]
				public char[] Buffer() /* MethodBuilder.Create */ 
				{
						return default(char[]);
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
				/// ensureCapacity
				/// </java-name>
				[Dot42.DexImport("ensureCapacity", "(I)V", AccessFlags = 1)]
				public void EnsureCapacity(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setLength
				/// </java-name>
				[Dot42.DexImport("setLength", "(I)V", AccessFlags = 1)]
				public void SetLength(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// indexOf
				/// </java-name>
				[Dot42.DexImport("indexOf", "(III)I", AccessFlags = 1)]
				public int IndexOf(int int32, int int321, int int322) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// indexOf
				/// </java-name>
				[Dot42.DexImport("indexOf", "(I)I", AccessFlags = 1)]
				public int IndexOf(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// substring
				/// </java-name>
				[Dot42.DexImport("substring", "(II)Ljava/lang/String;", AccessFlags = 1)]
				public string Substring(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// substringTrimmed
				/// </java-name>
				[Dot42.DexImport("substringTrimmed", "(II)Ljava/lang/String;", AccessFlags = 1)]
				public string SubstringTrimmed(int int32, int int321) /* MethodBuilder.Create */ 
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

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal CharArrayBuffer() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// isEmpty
				/// </java-name>
				public bool IsEmpty
				{
						[Dot42.DexImport("isEmpty", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// isFull
				/// </java-name>
				public bool IsFull
				{
						[Dot42.DexImport("isFull", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

		}

		/// <java-name>
		/// org/apache/http/util/EncodingUtils
		/// </java-name>
		[Dot42.DexImport("org/apache/http/util/EncodingUtils", AccessFlags = 49)]
		public sealed partial class EncodingUtils
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal EncodingUtils() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getString
				/// </java-name>
				[Dot42.DexImport("getString", "([BIILjava/lang/String;)Ljava/lang/String;", AccessFlags = 9)]
				public static string GetString(sbyte[] sByte, int int32, int int321, string @string) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getString
				/// </java-name>
				[Dot42.DexImport("getString", "([BIILjava/lang/String;)Ljava/lang/String;", AccessFlags = 9, IgnoreFromJava = true)]
				public static string GetString(byte[] @byte, int int32, int int321, string @string) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getString
				/// </java-name>
				[Dot42.DexImport("getString", "([BLjava/lang/String;)Ljava/lang/String;", AccessFlags = 9)]
				public static string GetString(sbyte[] sByte, string @string) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getString
				/// </java-name>
				[Dot42.DexImport("getString", "([BLjava/lang/String;)Ljava/lang/String;", AccessFlags = 9, IgnoreFromJava = true)]
				public static string GetString(byte[] @byte, string @string) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getBytes
				/// </java-name>
				[Dot42.DexImport("getBytes", "(Ljava/lang/String;Ljava/lang/String;)[B", AccessFlags = 9)]
				public static sbyte[] JavaGetBytes(string @string, string string1) /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <java-name>
				/// getBytes
				/// </java-name>
				[Dot42.DexImport("getBytes", "(Ljava/lang/String;Ljava/lang/String;)[B", AccessFlags = 9, IgnoreFromJava = true)]
				public static byte[] GetBytes(string @string, string string1) /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				/// <java-name>
				/// getAsciiBytes
				/// </java-name>
				[Dot42.DexImport("getAsciiBytes", "(Ljava/lang/String;)[B", AccessFlags = 9)]
				public static sbyte[] JavaGetAsciiBytes(string @string) /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <java-name>
				/// getAsciiBytes
				/// </java-name>
				[Dot42.DexImport("getAsciiBytes", "(Ljava/lang/String;)[B", AccessFlags = 9, IgnoreFromJava = true)]
				public static byte[] GetAsciiBytes(string @string) /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				/// <java-name>
				/// getAsciiString
				/// </java-name>
				[Dot42.DexImport("getAsciiString", "([BII)Ljava/lang/String;", AccessFlags = 9)]
				public static string GetAsciiString(sbyte[] sByte, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getAsciiString
				/// </java-name>
				[Dot42.DexImport("getAsciiString", "([BII)Ljava/lang/String;", AccessFlags = 9, IgnoreFromJava = true)]
				public static string GetAsciiString(byte[] @byte, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getAsciiString
				/// </java-name>
				[Dot42.DexImport("getAsciiString", "([B)Ljava/lang/String;", AccessFlags = 9)]
				public static string GetAsciiString(sbyte[] sByte) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getAsciiString
				/// </java-name>
				[Dot42.DexImport("getAsciiString", "([B)Ljava/lang/String;", AccessFlags = 9, IgnoreFromJava = true)]
				public static string GetAsciiString(byte[] @byte) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

		}

		/// <java-name>
		/// org/apache/http/util/EntityUtils
		/// </java-name>
		[Dot42.DexImport("org/apache/http/util/EntityUtils", AccessFlags = 49)]
		public sealed partial class EntityUtils
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal EntityUtils() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// toByteArray
				/// </java-name>
				[Dot42.DexImport("toByteArray", "(Lorg/apache/http/HttpEntity;)[B", AccessFlags = 9)]
				public static sbyte[] JavaToByteArray(global::Org.Apache.Http.IHttpEntity httpEntity) /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <java-name>
				/// toByteArray
				/// </java-name>
				[Dot42.DexImport("toByteArray", "(Lorg/apache/http/HttpEntity;)[B", AccessFlags = 9, IgnoreFromJava = true)]
				public static byte[] ToByteArray(global::Org.Apache.Http.IHttpEntity httpEntity) /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				/// <java-name>
				/// getContentCharSet
				/// </java-name>
				[Dot42.DexImport("getContentCharSet", "(Lorg/apache/http/HttpEntity;)Ljava/lang/String;", AccessFlags = 9)]
				public static string GetContentCharSet(global::Org.Apache.Http.IHttpEntity httpEntity) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "(Lorg/apache/http/HttpEntity;Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 9)]
				public static string ToString(global::Org.Apache.Http.IHttpEntity httpEntity, string @string) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "(Lorg/apache/http/HttpEntity;)Ljava/lang/String;", AccessFlags = 9)]
				public static string ToString(global::Org.Apache.Http.IHttpEntity httpEntity) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

		}

		/// <java-name>
		/// org/apache/http/util/ExceptionUtils
		/// </java-name>
		[Dot42.DexImport("org/apache/http/util/ExceptionUtils", AccessFlags = 49)]
		public sealed partial class ExceptionUtils
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal ExceptionUtils() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// initCause
				/// </java-name>
				[Dot42.DexImport("initCause", "(Ljava/lang/Throwable;Ljava/lang/Throwable;)V", AccessFlags = 9)]
				public static void InitCause(global::System.Exception exception, global::System.Exception exception1) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// org/apache/http/util/LangUtils
		/// </java-name>
		[Dot42.DexImport("org/apache/http/util/LangUtils", AccessFlags = 49)]
		public sealed partial class LangUtils
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// HASH_SEED
				/// </java-name>
				[Dot42.DexImport("HASH_SEED", "I", AccessFlags = 25)]
				public const int HASH_SEED = 17;
				/// <java-name>
				/// HASH_OFFSET
				/// </java-name>
				[Dot42.DexImport("HASH_OFFSET", "I", AccessFlags = 25)]
				public const int HASH_OFFSET = 37;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal LangUtils() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "(II)I", AccessFlags = 9)]
				public static int GetHashCode(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "(IZ)I", AccessFlags = 9)]
				public static int GetHashCode(int int32, bool boolean) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "(ILjava/lang/Object;)I", AccessFlags = 9)]
				public static int GetHashCode(int int32, object @object) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;Ljava/lang/Object;)Z", AccessFlags = 9)]
				public static bool Equals(object @object, object object1) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "([Ljava/lang/Object;[Ljava/lang/Object;)Z", AccessFlags = 9)]
				public static bool Equals(object[] @object, object[] object1) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

		}

		/// <java-name>
		/// org/apache/http/util/VersionInfo
		/// </java-name>
		[Dot42.DexImport("org/apache/http/util/VersionInfo", AccessFlags = 33)]
		public partial class VersionInfo
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// UNAVAILABLE
				/// </java-name>
				[Dot42.DexImport("UNAVAILABLE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string UNAVAILABLE = "UNAVAILABLE";
				/// <java-name>
				/// VERSION_PROPERTY_FILE
				/// </java-name>
				[Dot42.DexImport("VERSION_PROPERTY_FILE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string VERSION_PROPERTY_FILE = "version.properties";
				/// <java-name>
				/// PROPERTY_MODULE
				/// </java-name>
				[Dot42.DexImport("PROPERTY_MODULE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string PROPERTY_MODULE = "info.module";
				/// <java-name>
				/// PROPERTY_RELEASE
				/// </java-name>
				[Dot42.DexImport("PROPERTY_RELEASE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string PROPERTY_RELEASE = "info.release";
				/// <java-name>
				/// PROPERTY_TIMESTAMP
				/// </java-name>
				[Dot42.DexImport("PROPERTY_TIMESTAMP", "Ljava/lang/String;", AccessFlags = 25)]
				public const string PROPERTY_TIMESTAMP = "info.timestamp";
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/la" +
    "ng/String;)V", AccessFlags = 4)]
				protected internal VersionInfo(string @string, string string1, string string2, string string3, string string4) /* MethodBuilder.Create */ 
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
				/// loadVersionInfo
				/// </java-name>
				[Dot42.DexImport("loadVersionInfo", "([Ljava/lang/String;Ljava/lang/ClassLoader;)[Lorg/apache/http/util/VersionInfo;", AccessFlags = 25)]
				public static global::Org.Apache.Http.Util.VersionInfo[] LoadVersionInfo(string[] @string, global::Java.Lang.ClassLoader classLoader) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Util.VersionInfo[]);
				}

				/// <java-name>
				/// loadVersionInfo
				/// </java-name>
				[Dot42.DexImport("loadVersionInfo", "(Ljava/lang/String;Ljava/lang/ClassLoader;)Lorg/apache/http/util/VersionInfo;", AccessFlags = 25)]
				public static global::Org.Apache.Http.Util.VersionInfo LoadVersionInfo(string @string, global::Java.Lang.ClassLoader classLoader) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Util.VersionInfo);
				}

				/// <java-name>
				/// fromMap
				/// </java-name>
				[Dot42.DexImport("fromMap", "(Ljava/lang/String;Ljava/util/Map;Ljava/lang/ClassLoader;)Lorg/apache/http/util/V" +
    "ersionInfo;", AccessFlags = 28)]
				protected internal static global::Org.Apache.Http.Util.VersionInfo FromMap(string @string, global::Java.Util.IMap<object, object> map, global::Java.Lang.ClassLoader classLoader) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Util.VersionInfo);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal VersionInfo() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getPackage
				/// </java-name>
				public string Package
				{
						[Dot42.DexImport("getPackage", "()Ljava/lang/String;", AccessFlags = 17)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getModule
				/// </java-name>
				public string Module
				{
						[Dot42.DexImport("getModule", "()Ljava/lang/String;", AccessFlags = 17)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getRelease
				/// </java-name>
				public string Release
				{
						[Dot42.DexImport("getRelease", "()Ljava/lang/String;", AccessFlags = 17)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getTimestamp
				/// </java-name>
				public string Timestamp
				{
						[Dot42.DexImport("getTimestamp", "()Ljava/lang/String;", AccessFlags = 17)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getClassloader
				/// </java-name>
				public string Classloader
				{
						[Dot42.DexImport("getClassloader", "()Ljava/lang/String;", AccessFlags = 17)]
						get{ return default(string); }
				}

		}

}

