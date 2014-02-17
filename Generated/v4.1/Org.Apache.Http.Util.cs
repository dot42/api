// Copyright (C) 2014 dot42
//
// Original filename: Org.Apache.Http.Util.cs
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
namespace Org.Apache.Http.Util
{
		/// <summary>
		/// <para>The home for utility methods that handle various encoding tasks.</para><para><para>Michael Becke </para><simplesectsep></simplesectsep><para></para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/util/EncodingUtils
		/// </java-name>
		[Dot42.DexImport("org/apache/http/util/EncodingUtils", AccessFlags = 49)]
		public sealed partial class EncodingUtils
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>This class should not be instantiated. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal EncodingUtils() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Converts the byte array of HTTP content characters to a string. If the specified charset is not supported, default system encoding is used.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The result of the conversion. </para>
				/// </returns>
				/// <java-name>
				/// getString
				/// </java-name>
				[Dot42.DexImport("getString", "([BIILjava/lang/String;)Ljava/lang/String;", AccessFlags = 9)]
				public static string GetString(sbyte[] data, int offset, int length, string charset) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Converts the byte array of HTTP content characters to a string. If the specified charset is not supported, default system encoding is used.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The result of the conversion. </para>
				/// </returns>
				/// <java-name>
				/// getString
				/// </java-name>
				[Dot42.DexImport("getString", "([BIILjava/lang/String;)Ljava/lang/String;", AccessFlags = 9, IgnoreFromJava = true)]
				public static string GetString(byte[] data, int offset, int length, string charset) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Converts the byte array of HTTP content characters to a string. If the specified charset is not supported, default system encoding is used.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The result of the conversion. </para>
				/// </returns>
				/// <java-name>
				/// getString
				/// </java-name>
				[Dot42.DexImport("getString", "([BLjava/lang/String;)Ljava/lang/String;", AccessFlags = 9)]
				public static string GetString(sbyte[] data, string charset) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Converts the byte array of HTTP content characters to a string. If the specified charset is not supported, default system encoding is used.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The result of the conversion. </para>
				/// </returns>
				/// <java-name>
				/// getString
				/// </java-name>
				[Dot42.DexImport("getString", "([BLjava/lang/String;)Ljava/lang/String;", AccessFlags = 9, IgnoreFromJava = true)]
				public static string GetString(byte[] data, string charset) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Converts the specified string to a byte array. If the charset is not supported the default system charset is used.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The resulting byte array. </para>
				/// </returns>
				/// <java-name>
				/// getBytes
				/// </java-name>
				[Dot42.DexImport("getBytes", "(Ljava/lang/String;Ljava/lang/String;)[B", AccessFlags = 9)]
				public static sbyte[] JavaGetBytes(string data, string charset) /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <summary>
				/// <para>Converts the specified string to a byte array. If the charset is not supported the default system charset is used.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The resulting byte array. </para>
				/// </returns>
				/// <java-name>
				/// getBytes
				/// </java-name>
				[Dot42.DexImport("getBytes", "(Ljava/lang/String;Ljava/lang/String;)[B", AccessFlags = 9, IgnoreFromJava = true)]
				public static byte[] GetBytes(string data, string charset) /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				/// <summary>
				/// <para>Converts the specified string to byte array of ASCII characters.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The string as a byte array. </para>
				/// </returns>
				/// <java-name>
				/// getAsciiBytes
				/// </java-name>
				[Dot42.DexImport("getAsciiBytes", "(Ljava/lang/String;)[B", AccessFlags = 9)]
				public static sbyte[] JavaGetAsciiBytes(string data) /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <summary>
				/// <para>Converts the specified string to byte array of ASCII characters.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The string as a byte array. </para>
				/// </returns>
				/// <java-name>
				/// getAsciiBytes
				/// </java-name>
				[Dot42.DexImport("getAsciiBytes", "(Ljava/lang/String;)[B", AccessFlags = 9, IgnoreFromJava = true)]
				public static byte[] GetAsciiBytes(string data) /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				/// <summary>
				/// <para>Converts the byte array of ASCII characters to a string. This method is to be used when decoding content of HTTP elements (such as response headers)</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The string representation of the byte array </para>
				/// </returns>
				/// <java-name>
				/// getAsciiString
				/// </java-name>
				[Dot42.DexImport("getAsciiString", "([BII)Ljava/lang/String;", AccessFlags = 9)]
				public static string GetAsciiString(sbyte[] data, int offset, int length) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Converts the byte array of ASCII characters to a string. This method is to be used when decoding content of HTTP elements (such as response headers)</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The string representation of the byte array </para>
				/// </returns>
				/// <java-name>
				/// getAsciiString
				/// </java-name>
				[Dot42.DexImport("getAsciiString", "([BII)Ljava/lang/String;", AccessFlags = 9, IgnoreFromJava = true)]
				public static string GetAsciiString(byte[] data, int offset, int length) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Converts the byte array of ASCII characters to a string. This method is to be used when decoding content of HTTP elements (such as response headers)</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The string representation of the byte array </para>
				/// </returns>
				/// <java-name>
				/// getAsciiString
				/// </java-name>
				[Dot42.DexImport("getAsciiString", "([B)Ljava/lang/String;", AccessFlags = 9)]
				public static string GetAsciiString(sbyte[] data) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Converts the byte array of ASCII characters to a string. This method is to be used when decoding content of HTTP elements (such as response headers)</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The string representation of the byte array </para>
				/// </returns>
				/// <java-name>
				/// getAsciiString
				/// </java-name>
				[Dot42.DexImport("getAsciiString", "([B)Ljava/lang/String;", AccessFlags = 9, IgnoreFromJava = true)]
				public static string GetAsciiString(byte[] data) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

		}

		/// <summary>
		/// <para>A resizable char array.</para><para><para></para><para></para><title>Revision:</title><para>496070 </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/util/CharArrayBuffer
		/// </java-name>
		[Dot42.DexImport("org/apache/http/util/CharArrayBuffer", AccessFlags = 49)]
		public sealed partial class CharArrayBuffer
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public CharArrayBuffer(int capacity) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// append
				/// </java-name>
				[Dot42.DexImport("append", "([CII)V", AccessFlags = 1)]
				public void Append(char[] b, int off, int len) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// append
				/// </java-name>
				[Dot42.DexImport("append", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public void Append(string b) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// append
				/// </java-name>
				[Dot42.DexImport("append", "(Lorg/apache/http/util/CharArrayBuffer;II)V", AccessFlags = 1)]
				public void Append(global::Org.Apache.Http.Util.CharArrayBuffer b, int off, int len) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// append
				/// </java-name>
				[Dot42.DexImport("append", "(Lorg/apache/http/util/CharArrayBuffer;)V", AccessFlags = 1)]
				public void Append(global::Org.Apache.Http.Util.CharArrayBuffer b) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// append
				/// </java-name>
				[Dot42.DexImport("append", "(C)V", AccessFlags = 1)]
				public void Append(char b) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// append
				/// </java-name>
				[Dot42.DexImport("append", "([BII)V", AccessFlags = 1)]
				public void Append(sbyte[] b, int off, int len) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// append
				/// </java-name>
				[Dot42.DexImport("append", "([BII)V", AccessFlags = 1, IgnoreFromJava = true)]
				public void Append(byte[] b, int off, int len) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// append
				/// </java-name>
				[Dot42.DexImport("append", "(Lorg/apache/http/util/ByteArrayBuffer;II)V", AccessFlags = 1)]
				public void Append(global::Org.Apache.Http.Util.ByteArrayBuffer b, int off, int len) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// append
				/// </java-name>
				[Dot42.DexImport("append", "(Ljava/lang/Object;)V", AccessFlags = 1)]
				public void Append(object b) /* MethodBuilder.Create */ 
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
				public char CharAt(int i) /* MethodBuilder.Create */ 
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
				public void EnsureCapacity(int required) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setLength
				/// </java-name>
				[Dot42.DexImport("setLength", "(I)V", AccessFlags = 1)]
				public void SetLength(int len) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isEmpty
				/// </java-name>
				[Dot42.DexImport("isEmpty", "()Z", AccessFlags = 1)]
				public bool IsEmpty() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isFull
				/// </java-name>
				[Dot42.DexImport("isFull", "()Z", AccessFlags = 1)]
				public bool IsFull() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// indexOf
				/// </java-name>
				[Dot42.DexImport("indexOf", "(III)I", AccessFlags = 1)]
				public int IndexOf(int ch, int beginIndex, int endIndex) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// indexOf
				/// </java-name>
				[Dot42.DexImport("indexOf", "(I)I", AccessFlags = 1)]
				public int IndexOf(int ch) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// substring
				/// </java-name>
				[Dot42.DexImport("substring", "(II)Ljava/lang/String;", AccessFlags = 1)]
				public string Substring(int beginIndex, int endIndex) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// substringTrimmed
				/// </java-name>
				[Dot42.DexImport("substringTrimmed", "(II)Ljava/lang/String;", AccessFlags = 1)]
				public string SubstringTrimmed(int beginIndex, int endIndex) /* MethodBuilder.Create */ 
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

		}

		/// <summary>
		/// <para>Provides access to version information for HTTP components. Instances of this class provide version information for a single module or informal unit, as explained . Static methods are used to extract version information from property files that are automatically packaged with HTTP component release JARs. <br></br> All available version information is provided in strings, where the string format is informal and subject to change without notice. Version information is provided for debugging output and interpretation by humans, not for automated processing in applications.</para><para><para> </para><simplesectsep></simplesectsep><para>and others </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/util/VersionInfo
		/// </java-name>
		[Dot42.DexImport("org/apache/http/util/VersionInfo", AccessFlags = 33)]
		public partial class VersionInfo
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>A string constant for unavailable information. </para>        
				/// </summary>
				/// <java-name>
				/// UNAVAILABLE
				/// </java-name>
				[Dot42.DexImport("UNAVAILABLE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string UNAVAILABLE = "UNAVAILABLE";
				/// <summary>
				/// <para>The filename of the version information files. </para>        
				/// </summary>
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
				/// <summary>
				/// <para>Instantiates version information.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/la" +
    "ng/String;)V", AccessFlags = 4)]
				protected internal VersionInfo(string pckg, string module, string release, string time, string clsldr) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Obtains the package name. The package name identifies the module or informal unit.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the package name, never <code>null</code> </para>
				/// </returns>
				/// <java-name>
				/// getPackage
				/// </java-name>
				[Dot42.DexImport("getPackage", "()Ljava/lang/String;", AccessFlags = 17)]
				public string GetPackage() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Obtains the name of the versioned module or informal unit. This data is read from the version information for the package.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the module name, never <code>null</code> </para>
				/// </returns>
				/// <java-name>
				/// getModule
				/// </java-name>
				[Dot42.DexImport("getModule", "()Ljava/lang/String;", AccessFlags = 17)]
				public string GetModule() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Obtains the release of the versioned module or informal unit. This data is read from the version information for the package.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the release version, never <code>null</code> </para>
				/// </returns>
				/// <java-name>
				/// getRelease
				/// </java-name>
				[Dot42.DexImport("getRelease", "()Ljava/lang/String;", AccessFlags = 17)]
				public string GetRelease() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Obtains the timestamp of the versioned module or informal unit. This data is read from the version information for the package.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the timestamp, never <code>null</code> </para>
				/// </returns>
				/// <java-name>
				/// getTimestamp
				/// </java-name>
				[Dot42.DexImport("getTimestamp", "()Ljava/lang/String;", AccessFlags = 17)]
				public string GetTimestamp() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Obtains the classloader used to read the version information. This is just the <code>toString</code> output of the classloader, since the version information should not keep a reference to the classloader itself. That could prevent garbage collection.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the classloader description, never <code>null</code> </para>
				/// </returns>
				/// <java-name>
				/// getClassloader
				/// </java-name>
				[Dot42.DexImport("getClassloader", "()Ljava/lang/String;", AccessFlags = 17)]
				public string GetClassloader() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Provides the version information in human-readable format.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a string holding this version information </para>
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

				/// <summary>
				/// <para>Instantiates version information from properties.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the version information </para>
				/// </returns>
				/// <java-name>
				/// fromMap
				/// </java-name>
				[Dot42.DexImport("fromMap", "(Ljava/lang/String;Ljava/util/Map;Ljava/lang/ClassLoader;)Lorg/apache/http/util/V" +
    "ersionInfo;", AccessFlags = 28)]
				protected internal static global::Org.Apache.Http.Util.VersionInfo FromMap(string pckg, global::Java.Util.IMap<object, object> info, global::Java.Lang.ClassLoader clsldr) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Util.VersionInfo);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal VersionInfo() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Obtains the package name. The package name identifies the module or informal unit.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the package name, never <code>null</code> </para>
				/// </returns>
				/// <java-name>
				/// getPackage
				/// </java-name>
				public string Package
				{
				[Dot42.DexImport("getPackage", "()Ljava/lang/String;", AccessFlags = 17)]
						get{ return GetPackage(); }
				}

				/// <summary>
				/// <para>Obtains the name of the versioned module or informal unit. This data is read from the version information for the package.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the module name, never <code>null</code> </para>
				/// </returns>
				/// <java-name>
				/// getModule
				/// </java-name>
				public string Module
				{
				[Dot42.DexImport("getModule", "()Ljava/lang/String;", AccessFlags = 17)]
						get{ return GetModule(); }
				}

				/// <summary>
				/// <para>Obtains the release of the versioned module or informal unit. This data is read from the version information for the package.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the release version, never <code>null</code> </para>
				/// </returns>
				/// <java-name>
				/// getRelease
				/// </java-name>
				public string Release
				{
				[Dot42.DexImport("getRelease", "()Ljava/lang/String;", AccessFlags = 17)]
						get{ return GetRelease(); }
				}

				/// <summary>
				/// <para>Obtains the timestamp of the versioned module or informal unit. This data is read from the version information for the package.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the timestamp, never <code>null</code> </para>
				/// </returns>
				/// <java-name>
				/// getTimestamp
				/// </java-name>
				public string Timestamp
				{
				[Dot42.DexImport("getTimestamp", "()Ljava/lang/String;", AccessFlags = 17)]
						get{ return GetTimestamp(); }
				}

				/// <summary>
				/// <para>Obtains the classloader used to read the version information. This is just the <code>toString</code> output of the classloader, since the version information should not keep a reference to the classloader itself. That could prevent garbage collection.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the classloader description, never <code>null</code> </para>
				/// </returns>
				/// <java-name>
				/// getClassloader
				/// </java-name>
				public string Classloader
				{
				[Dot42.DexImport("getClassloader", "()Ljava/lang/String;", AccessFlags = 17)]
						get{ return GetClassloader(); }
				}

		}

		/// <summary>
		/// <para>A resizable byte array.</para><para><para></para><para></para><title>Revision:</title><para>496070 </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/util/ByteArrayBuffer
		/// </java-name>
		[Dot42.DexImport("org/apache/http/util/ByteArrayBuffer", AccessFlags = 49)]
		public sealed partial class ByteArrayBuffer
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public ByteArrayBuffer(int capacity) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// append
				/// </java-name>
				[Dot42.DexImport("append", "([BII)V", AccessFlags = 1)]
				public void Append(sbyte[] b, int off, int len) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// append
				/// </java-name>
				[Dot42.DexImport("append", "([BII)V", AccessFlags = 1, IgnoreFromJava = true)]
				public void Append(byte[] b, int off, int len) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// append
				/// </java-name>
				[Dot42.DexImport("append", "(I)V", AccessFlags = 1)]
				public void Append(int b) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// append
				/// </java-name>
				[Dot42.DexImport("append", "([CII)V", AccessFlags = 1)]
				public void Append(char[] b, int off, int len) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// append
				/// </java-name>
				[Dot42.DexImport("append", "(Lorg/apache/http/util/CharArrayBuffer;II)V", AccessFlags = 1)]
				public void Append(global::Org.Apache.Http.Util.CharArrayBuffer b, int off, int len) /* MethodBuilder.Create */ 
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
				public int ByteAt(int i) /* MethodBuilder.Create */ 
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
				public void SetLength(int len) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isEmpty
				/// </java-name>
				[Dot42.DexImport("isEmpty", "()Z", AccessFlags = 1)]
				public bool IsEmpty() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isFull
				/// </java-name>
				[Dot42.DexImport("isFull", "()Z", AccessFlags = 1)]
				public bool IsFull() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ByteArrayBuffer() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		/// <para>A set of utility methods to help produce consistent equals and hashCode methods.</para><para><para></para><para>4.0 </para></para>    
		/// </summary>
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
				/// <summary>
				/// <para>Disabled default constructor. </para>        
				/// </summary>
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

		/// <summary>
		/// <para>Static helpers for dealing with entities.</para><para><para></para><para></para><title>Revision:</title><para>569637 </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/util/EntityUtils
		/// </java-name>
		[Dot42.DexImport("org/apache/http/util/EntityUtils", AccessFlags = 49)]
		public sealed partial class EntityUtils
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Disabled default constructor. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal EntityUtils() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// toByteArray
				/// </java-name>
				[Dot42.DexImport("toByteArray", "(Lorg/apache/http/HttpEntity;)[B", AccessFlags = 9)]
				public static sbyte[] JavaToByteArray(global::Org.Apache.Http.IHttpEntity entity) /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <java-name>
				/// toByteArray
				/// </java-name>
				[Dot42.DexImport("toByteArray", "(Lorg/apache/http/HttpEntity;)[B", AccessFlags = 9, IgnoreFromJava = true)]
				public static byte[] ToByteArray(global::Org.Apache.Http.IHttpEntity entity) /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				/// <java-name>
				/// getContentCharSet
				/// </java-name>
				[Dot42.DexImport("getContentCharSet", "(Lorg/apache/http/HttpEntity;)Ljava/lang/String;", AccessFlags = 9)]
				public static string GetContentCharSet(global::Org.Apache.Http.IHttpEntity entity) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "(Lorg/apache/http/HttpEntity;Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 9)]
				public static string ToString(global::Org.Apache.Http.IHttpEntity entity, string defaultCharset) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "(Lorg/apache/http/HttpEntity;)Ljava/lang/String;", AccessFlags = 9)]
				public static string ToString(global::Org.Apache.Http.IHttpEntity entity) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

		}

		/// <summary>
		/// <para>The home for utility methods that handle various exception-related tasks.</para><para><para> </para><simplesectsep></simplesectsep><para></para><para>4.0 </para></para>    
		/// </summary>
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

				/// <summary>
				/// <para>If we're running on JDK 1.4 or later, initialize the cause for the given throwable.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// initCause
				/// </java-name>
				[Dot42.DexImport("initCause", "(Ljava/lang/Throwable;Ljava/lang/Throwable;)V", AccessFlags = 9)]
				public static void InitCause(global::System.Exception throwable, global::System.Exception cause) /* MethodBuilder.Create */ 
				{
				}

		}

}


