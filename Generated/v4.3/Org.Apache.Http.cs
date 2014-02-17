// Copyright (C) 2014 dot42
//
// Original filename: Org.Apache.Http.cs
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
namespace Org.Apache.Http
{
		/// <summary>
		/// <para>Signals that an HTTP exception has occurred.</para><para><para>Laura Werner</para><para></para><title>Revision:</title><para>618017 </para><title>Date:</title><para>2008-02-03 08:42:22 -0800 (Sun, 03 Feb 2008) </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/HttpException
		/// </java-name>
		[Dot42.DexImport("org/apache/http/HttpException", AccessFlags = 33)]
		public partial class HttpException : global::System.Exception
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new HttpException with a <code>null</code> detail message. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public HttpException() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new HttpException with the specified detail message.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public HttpException(string message) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new HttpException with the specified detail message and cause.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public HttpException(string message, global::System.Exception cause) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>An HTTP connection over the Internet Protocol (IP).</para><para><para></para><para></para><title>Revision:</title><para>613298 </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/HttpInetConnection
		/// </java-name>
		[Dot42.DexImport("org/apache/http/HttpInetConnection", AccessFlags = 1537)]
		public partial interface IHttpInetConnection : global::Org.Apache.Http.IHttpConnection
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// getLocalAddress
				/// </java-name>
				[Dot42.DexImport("getLocalAddress", "()Ljava/net/InetAddress;", AccessFlags = 1025)]
				global::Java.Net.InetAddress GetLocalAddress() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getLocalPort
				/// </java-name>
				[Dot42.DexImport("getLocalPort", "()I", AccessFlags = 1025)]
				int GetLocalPort() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getRemoteAddress
				/// </java-name>
				[Dot42.DexImport("getRemoteAddress", "()Ljava/net/InetAddress;", AccessFlags = 1025)]
				global::Java.Net.InetAddress GetRemoteAddress() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getRemotePort
				/// </java-name>
				[Dot42.DexImport("getRemotePort", "()I", AccessFlags = 1025)]
				int GetRemotePort() /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>A generic HTTP connection, useful on client and server side.</para><para><para></para><para></para><title>Revision:</title><para>548031 </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/HttpConnection
		/// </java-name>
		[Dot42.DexImport("org/apache/http/HttpConnection", AccessFlags = 1537)]
		public partial interface IHttpConnection
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Closes this connection gracefully. This method will attempt to flush the transmitter's internal buffer prior to closing the underlying socket. This method MUST NOT be called from a different thread to force shutdown of the connection. Use shutdown instead. </para>        
				/// </summary>
				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1025)]
				void Close() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Checks if this connection is open. </para>        
				/// </summary>
				/// <returns>
				/// <para>true if it is open, false if it is closed. </para>
				/// </returns>
				/// <java-name>
				/// isOpen
				/// </java-name>
				[Dot42.DexImport("isOpen", "()Z", AccessFlags = 1025)]
				bool IsOpen() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Checks whether this connection has gone down. Network connections may get closed during some time of inactivity for several reasons. The next time a read is attempted on such a connection it will throw an IOException. This method tries to alleviate this inconvenience by trying to find out if a connection is still usable. Implementations may do that by attempting a read with a very small timeout. Thus this method may block for a small amount of time before returning a result. It is therefore an <b>expensive</b> operation.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> if attempts to use this connection are likely to succeed, or <code>false</code> if they are likely to fail and this connection should be closed </para>
				/// </returns>
				/// <java-name>
				/// isStale
				/// </java-name>
				[Dot42.DexImport("isStale", "()Z", AccessFlags = 1025)]
				bool IsStale() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets the socket timeout value.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setSocketTimeout
				/// </java-name>
				[Dot42.DexImport("setSocketTimeout", "(I)V", AccessFlags = 1025)]
				void SetSocketTimeout(int timeout) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the socket timeout value.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>positive value in milliseconds if a timeout is set, <code>0</code> if timeout is disabled or <code>-1</code> if timeout is undefined. </para>
				/// </returns>
				/// <java-name>
				/// getSocketTimeout
				/// </java-name>
				[Dot42.DexImport("getSocketTimeout", "()I", AccessFlags = 1025)]
				int GetSocketTimeout() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Force-closes this connection. This is the only method of a connection which may be called from a different thread to terminate the connection. This method will not attempt to flush the transmitter's internal buffer prior to closing the underlying socket. </para>        
				/// </summary>
				/// <java-name>
				/// shutdown
				/// </java-name>
				[Dot42.DexImport("shutdown", "()V", AccessFlags = 1025)]
				void Shutdown() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns a collection of connection metrcis </para>        
				/// </summary>
				/// <returns>
				/// <para>HttpConnectionMetrics </para>
				/// </returns>
				/// <java-name>
				/// getMetrics
				/// </java-name>
				[Dot42.DexImport("getMetrics", "()Lorg/apache/http/HttpConnectionMetrics;", AccessFlags = 1025)]
				global::Org.Apache.Http.IHttpConnectionMetrics GetMetrics() /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>Signals that an HTTP protocol violation has occurred. For example a malformed status line or headers, a missing message body, etc.</para><para><para></para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/ProtocolException
		/// </java-name>
		[Dot42.DexImport("org/apache/http/ProtocolException", AccessFlags = 33)]
		public partial class ProtocolException : global::Org.Apache.Http.HttpException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new ProtocolException with a <code>null</code> detail message. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ProtocolException() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new ProtocolException with the specified detail message.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public ProtocolException(string message) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new ProtocolException with the specified detail message and cause.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public ProtocolException(string message, global::System.Exception cause) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>Represents a protocol version, as specified in RFC 2616. RFC 2616 specifies only HTTP versions, like "HTTP/1.1" and "HTTP/1.0". RFC 3261 specifies a message format that is identical to HTTP except for the protocol name. It defines a protocol version "SIP/2.0". There are some nitty-gritty differences between the interpretation of versions in HTTP and SIP. In those cases, HTTP takes precedence. </para><para>This class defines a protocol version as a combination of protocol name, major version number, and minor version number. Note that equals and hashCode are defined as final here, they cannot be overridden in derived classes.</para><para><para> </para><simplesectsep></simplesectsep><para></para><para></para><title>Revision:</title><para>609106 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/ProtocolVersion
		/// </java-name>
		[Dot42.DexImport("org/apache/http/ProtocolVersion", AccessFlags = 33)]
		public partial class ProtocolVersion : global::Java.Io.ISerializable, global::Java.Lang.ICloneable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Name of the protocol. </para>        
				/// </summary>
				/// <java-name>
				/// protocol
				/// </java-name>
				[Dot42.DexImport("protocol", "Ljava/lang/String;", AccessFlags = 20)]
				protected internal readonly string Protocol;
				/// <summary>
				/// <para>Major version number of the protocol </para>        
				/// </summary>
				/// <java-name>
				/// major
				/// </java-name>
				[Dot42.DexImport("major", "I", AccessFlags = 20)]
				protected internal readonly int Major;
				/// <summary>
				/// <para>Minor version number of the protocol </para>        
				/// </summary>
				/// <java-name>
				/// minor
				/// </java-name>
				[Dot42.DexImport("minor", "I", AccessFlags = 20)]
				protected internal readonly int Minor;
				/// <summary>
				/// <para>Create a protocol version designator.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;II)V", AccessFlags = 1)]
				public ProtocolVersion(string protocol, int major, int minor) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the name of the protocol.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the protocol name </para>
				/// </returns>
				/// <java-name>
				/// getProtocol
				/// </java-name>
				[Dot42.DexImport("getProtocol", "()Ljava/lang/String;", AccessFlags = 17)]
				public string GetProtocol() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the major version number of the protocol.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the major version number. </para>
				/// </returns>
				/// <java-name>
				/// getMajor
				/// </java-name>
				[Dot42.DexImport("getMajor", "()I", AccessFlags = 17)]
				public int GetMajor() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the minor version number of the HTTP protocol.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the minor version number. </para>
				/// </returns>
				/// <java-name>
				/// getMinor
				/// </java-name>
				[Dot42.DexImport("getMinor", "()I", AccessFlags = 17)]
				public int GetMinor() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Obtains a specific version of this protocol. This can be used by derived classes to instantiate themselves instead of the base class, and to define constants for commonly used versions. <br></br> The default implementation in this class returns <code>this</code> if the version matches, and creates a new ProtocolVersion otherwise.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a protocol version with the same protocol name and the argument version </para>
				/// </returns>
				/// <java-name>
				/// forVersion
				/// </java-name>
				[Dot42.DexImport("forVersion", "(II)Lorg/apache/http/ProtocolVersion;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.ProtocolVersion ForVersion(int major, int minor) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.ProtocolVersion);
				}

				/// <summary>
				/// <para>Obtains a hash code consistent with equals.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the hashcode of this protocol version </para>
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
				/// <para>Checks equality of this protocol version with an object. The object is equal if it is a protocl version with the same protocol name, major version number, and minor version number. The specific class of the object is <b>not</b> relevant, instances of derived classes with identical attributes are equal to instances of the base class and vice versa.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> if the argument is the same protocol version, <code>false</code> otherwise </para>
				/// </returns>
				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 17)]
				public override bool Equals(object obj) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Checks whether this protocol can be compared to another one. Only protocol versions with the same protocol name can be compared.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> if compareToVersion can be called with the argument, <code>false</code> otherwise </para>
				/// </returns>
				/// <java-name>
				/// isComparable
				/// </java-name>
				[Dot42.DexImport("isComparable", "(Lorg/apache/http/ProtocolVersion;)Z", AccessFlags = 1)]
				public virtual bool IsComparable(global::Org.Apache.Http.ProtocolVersion that) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Compares this protocol version with another one. Only protocol versions with the same protocol name can be compared. This method does <b>not</b> define a total ordering, as it would be required for java.lang.Comparable.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a negative integer, zero, or a positive integer as this version is less than, equal to, or greater than the argument version.</para>
				/// </returns>
				/// <java-name>
				/// compareToVersion
				/// </java-name>
				[Dot42.DexImport("compareToVersion", "(Lorg/apache/http/ProtocolVersion;)I", AccessFlags = 1)]
				public virtual int CompareToVersion(global::Org.Apache.Http.ProtocolVersion that) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Tests if this protocol version is greater or equal to the given one.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> if this protocol version is comparable to the argument and compares as greater or equal, <code>false</code> otherwise </para>
				/// </returns>
				/// <java-name>
				/// greaterEquals
				/// </java-name>
				[Dot42.DexImport("greaterEquals", "(Lorg/apache/http/ProtocolVersion;)Z", AccessFlags = 17)]
				public bool GreaterEquals(global::Org.Apache.Http.ProtocolVersion version) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Tests if this protocol version is less or equal to the given one.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> if this protocol version is comparable to the argument and compares as less or equal, <code>false</code> otherwise </para>
				/// </returns>
				/// <java-name>
				/// lessEquals
				/// </java-name>
				[Dot42.DexImport("lessEquals", "(Lorg/apache/http/ProtocolVersion;)Z", AccessFlags = 17)]
				public bool LessEquals(global::Org.Apache.Http.ProtocolVersion version) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Converts this protocol version to a string.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a protocol version string, like "HTTP/1.1" </para>
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
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/lang/Object;", AccessFlags = 1)]
				public virtual object Clone() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ProtocolVersion() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		/// <para>An HTTP header which is already formatted. For example when headers are received, the original formatting can be preserved. This allows for the header to be sent without another formatting step.</para><para><para></para><title>Revision:</title><para>569781 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/FormattedHeader
		/// </java-name>
		[Dot42.DexImport("org/apache/http/FormattedHeader", AccessFlags = 1537)]
		public partial interface IFormattedHeader : global::Org.Apache.Http.IHeader
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Obtains the buffer with the formatted header. The returned buffer MUST NOT be modified.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the formatted header, in a buffer that must not be modified </para>
				/// </returns>
				/// <java-name>
				/// getBuffer
				/// </java-name>
				[Dot42.DexImport("getBuffer", "()Lorg/apache/http/util/CharArrayBuffer;", AccessFlags = 1025)]
				global::Org.Apache.Http.Util.CharArrayBuffer GetBuffer() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Obtains the start of the header value in the buffer. By accessing the value in the buffer, creation of a temporary string can be avoided.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>index of the first character of the header value in the buffer returned by getBuffer. </para>
				/// </returns>
				/// <java-name>
				/// getValuePos
				/// </java-name>
				[Dot42.DexImport("getValuePos", "()I", AccessFlags = 1025)]
				int GetValuePos() /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>Signals a malformed chunked stream. </para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/MalformedChunkCodingException
		/// </java-name>
		[Dot42.DexImport("org/apache/http/MalformedChunkCodingException", AccessFlags = 33)]
		public partial class MalformedChunkCodingException : global::System.IO.IOException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a MalformedChunkCodingException without a detail message. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public MalformedChunkCodingException() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a MalformedChunkCodingException with the specified detail message.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public MalformedChunkCodingException(string message) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>Indicates an unsupported version of the HTTP protocol.</para><para><para></para><para></para><title>Revision:</title><para>79772 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/UnsupportedHttpVersionException
		/// </java-name>
		[Dot42.DexImport("org/apache/http/UnsupportedHttpVersionException", AccessFlags = 33)]
		public partial class UnsupportedHttpVersionException : global::Org.Apache.Http.ProtocolException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates an exception without a detail message. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public UnsupportedHttpVersionException() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates an exception with the specified detail message.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public UnsupportedHttpVersionException(string message) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>Holds all of the variables needed to describe an HTTP connection to a host. This includes remote host name, port and scheme.</para><para><para> </para><simplesectsep></simplesectsep><para> </para><simplesectsep></simplesectsep><para> </para><simplesectsep></simplesectsep><para>Laura Werner</para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/HttpHost
		/// </java-name>
		[Dot42.DexImport("org/apache/http/HttpHost", AccessFlags = 49)]
		public sealed partial class HttpHost : global::Java.Lang.ICloneable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>The default scheme is "http". </para>        
				/// </summary>
				/// <java-name>
				/// DEFAULT_SCHEME_NAME
				/// </java-name>
				[Dot42.DexImport("DEFAULT_SCHEME_NAME", "Ljava/lang/String;", AccessFlags = 25)]
				public const string DEFAULT_SCHEME_NAME = "http";
				/// <summary>
				/// <para>The host to use. </para>        
				/// </summary>
				/// <java-name>
				/// hostname
				/// </java-name>
				[Dot42.DexImport("hostname", "Ljava/lang/String;", AccessFlags = 20)]
				internal readonly string Hostname;
				/// <summary>
				/// <para>The lowercase host, for equals and hashCode. </para>        
				/// </summary>
				/// <java-name>
				/// lcHostname
				/// </java-name>
				[Dot42.DexImport("lcHostname", "Ljava/lang/String;", AccessFlags = 20)]
				internal readonly string LcHostname;
				/// <summary>
				/// <para>The port to use. </para>        
				/// </summary>
				/// <java-name>
				/// port
				/// </java-name>
				[Dot42.DexImport("port", "I", AccessFlags = 20)]
				internal readonly int Port;
				/// <summary>
				/// <para>The scheme </para>        
				/// </summary>
				/// <java-name>
				/// schemeName
				/// </java-name>
				[Dot42.DexImport("schemeName", "Ljava/lang/String;", AccessFlags = 20)]
				internal readonly string SchemeName;
				/// <summary>
				/// <para>Creates a new HttpHost, specifying all values. Constructor for HttpHost.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;ILjava/lang/String;)V", AccessFlags = 1)]
				public HttpHost(string hostname, int port, string scheme) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new HttpHost, with default scheme.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;I)V", AccessFlags = 1)]
				public HttpHost(string hostname, int port) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Copy constructor for HttpHost.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public HttpHost(string httphost) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Copy constructor for HttpHost.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Lorg/apache/http/HttpHost;)V", AccessFlags = 1)]
				public HttpHost(global::Org.Apache.Http.HttpHost httphost) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the host name.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the host name (IP or DNS name) </para>
				/// </returns>
				/// <java-name>
				/// getHostName
				/// </java-name>
				[Dot42.DexImport("getHostName", "()Ljava/lang/String;", AccessFlags = 1)]
				public string GetHostName() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the port.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the host port, or <code>-1</code> if not set </para>
				/// </returns>
				/// <java-name>
				/// getPort
				/// </java-name>
				[Dot42.DexImport("getPort", "()I", AccessFlags = 1)]
				public int GetPort() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the scheme name.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the scheme name </para>
				/// </returns>
				/// <java-name>
				/// getSchemeName
				/// </java-name>
				[Dot42.DexImport("getSchemeName", "()Ljava/lang/String;", AccessFlags = 1)]
				public string GetSchemeName() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Return the host URI, as a string.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the host URI </para>
				/// </returns>
				/// <java-name>
				/// toURI
				/// </java-name>
				[Dot42.DexImport("toURI", "()Ljava/lang/String;", AccessFlags = 1)]
				public string ToURI() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Obtains the host string, without scheme prefix.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the host string, for example <code>localhost:8080</code> </para>
				/// </returns>
				/// <java-name>
				/// toHostString
				/// </java-name>
				[Dot42.DexImport("toHostString", "()Ljava/lang/String;", AccessFlags = 1)]
				public string ToHostString() /* MethodBuilder.Create */ 
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
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object obj) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para><para>java.lang.Object::hashCode() </para></para>        
				/// </summary>
				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 1)]
				public override int GetHashCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/lang/Object;", AccessFlags = 1)]
				public object Clone() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal HttpHost() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Returns the host name.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the host name (IP or DNS name) </para>
				/// </returns>
				/// <java-name>
				/// getHostName
				/// </java-name>
				public string HostName
				{
				[Dot42.DexImport("getHostName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetHostName(); }
				}

		}

		/// <summary>
		/// <para>Interface for obtaining reason phrases for HTTP status codes.</para><para><para></para><para></para><title>Revision:</title><para>505744 </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/ReasonPhraseCatalog
		/// </java-name>
		[Dot42.DexImport("org/apache/http/ReasonPhraseCatalog", AccessFlags = 1537)]
		public partial interface IReasonPhraseCatalog
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Obtains the reason phrase for a status code. The optional context allows for catalogs that detect the language for the reason phrase.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the reason phrase, or <code>null</code> if unknown </para>
				/// </returns>
				/// <java-name>
				/// getReason
				/// </java-name>
				[Dot42.DexImport("getReason", "(ILjava/util/Locale;)Ljava/lang/String;", AccessFlags = 1025)]
				string GetReason(int status, global::Java.Util.Locale loc) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>One element of an HTTP header value.</para><para><para></para><para></para><title>Revision:</title><para>569828 </para><title>Date:</title><para>2007-08-26 08:49:38 -0700 (Sun, 26 Aug 2007) </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/HeaderElement
		/// </java-name>
		[Dot42.DexImport("org/apache/http/HeaderElement", AccessFlags = 1537)]
		public partial interface IHeaderElement
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// getName
				/// </java-name>
				[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1025)]
				string GetName() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getValue
				/// </java-name>
				[Dot42.DexImport("getValue", "()Ljava/lang/String;", AccessFlags = 1025)]
				string GetValue() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getParameters
				/// </java-name>
				[Dot42.DexImport("getParameters", "()[Lorg/apache/http/NameValuePair;", AccessFlags = 1025)]
				global::Org.Apache.Http.INameValuePair[] GetParameters() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getParameterByName
				/// </java-name>
				[Dot42.DexImport("getParameterByName", "(Ljava/lang/String;)Lorg/apache/http/NameValuePair;", AccessFlags = 1025)]
				global::Org.Apache.Http.INameValuePair GetParameterByName(string name) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getParameterCount
				/// </java-name>
				[Dot42.DexImport("getParameterCount", "()I", AccessFlags = 1025)]
				int GetParameterCount() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getParameter
				/// </java-name>
				[Dot42.DexImport("getParameter", "(I)Lorg/apache/http/NameValuePair;", AccessFlags = 1025)]
				global::Org.Apache.Http.INameValuePair GetParameter(int index) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>Represents a status line as returned from a HTTP server. See , section 6.1. Implementations are expected to be thread safe.</para><para><para>HttpStatus </para><para> </para><simplesectsep></simplesectsep><para> </para><para></para><title>Id:</title><para>StatusLine.java 573864 2007-09-08 15:53:25Z rolandw </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/StatusLine
		/// </java-name>
		[Dot42.DexImport("org/apache/http/StatusLine", AccessFlags = 1537)]
		public partial interface IStatusLine
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// getProtocolVersion
				/// </java-name>
				[Dot42.DexImport("getProtocolVersion", "()Lorg/apache/http/ProtocolVersion;", AccessFlags = 1025)]
				global::Org.Apache.Http.ProtocolVersion GetProtocolVersion() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getStatusCode
				/// </java-name>
				[Dot42.DexImport("getStatusCode", "()I", AccessFlags = 1025)]
				int GetStatusCode() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getReasonPhrase
				/// </java-name>
				[Dot42.DexImport("getReasonPhrase", "()Ljava/lang/String;", AccessFlags = 1025)]
				string GetReasonPhrase() /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>Constants enumerating the HTTP status codes. All status codes defined in RFC1945 (HTTP/1.0), RFC2616 (HTTP/1.1), and RFC2518 (WebDAV) are listed.</para><para><para>StatusLine </para><para>Unascribed </para><simplesectsep></simplesectsep><para> </para><simplesectsep></simplesectsep><para></para><para></para><title>Revision:</title><para>503381 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/HttpStatus
		/// </java-name>
		[Dot42.DexImport("org/apache/http/HttpStatus", AccessFlags = 1537, IgnoreFromJava = true, Priority = 1)]
		public static partial class IHttpStatusConstants
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para><code>100 Continue</code> (HTTP/1.1 - RFC 2616) </para>        
				/// </summary>
				/// <java-name>
				/// SC_CONTINUE
				/// </java-name>
				[Dot42.DexImport("SC_CONTINUE", "I", AccessFlags = 25)]
				public const int SC_CONTINUE = 100;
				/// <summary>
				/// <para><code>101 Switching Protocols</code> (HTTP/1.1 - RFC 2616) </para>        
				/// </summary>
				/// <java-name>
				/// SC_SWITCHING_PROTOCOLS
				/// </java-name>
				[Dot42.DexImport("SC_SWITCHING_PROTOCOLS", "I", AccessFlags = 25)]
				public const int SC_SWITCHING_PROTOCOLS = 101;
				/// <summary>
				/// <para><code>102 Processing</code> (WebDAV - RFC 2518) </para>        
				/// </summary>
				/// <java-name>
				/// SC_PROCESSING
				/// </java-name>
				[Dot42.DexImport("SC_PROCESSING", "I", AccessFlags = 25)]
				public const int SC_PROCESSING = 102;
				/// <summary>
				/// <para><code>200 OK</code> (HTTP/1.0 - RFC 1945) </para>        
				/// </summary>
				/// <java-name>
				/// SC_OK
				/// </java-name>
				[Dot42.DexImport("SC_OK", "I", AccessFlags = 25)]
				public const int SC_OK = 200;
				/// <summary>
				/// <para><code>201 Created</code> (HTTP/1.0 - RFC 1945) </para>        
				/// </summary>
				/// <java-name>
				/// SC_CREATED
				/// </java-name>
				[Dot42.DexImport("SC_CREATED", "I", AccessFlags = 25)]
				public const int SC_CREATED = 201;
				/// <summary>
				/// <para><code>202 Accepted</code> (HTTP/1.0 - RFC 1945) </para>        
				/// </summary>
				/// <java-name>
				/// SC_ACCEPTED
				/// </java-name>
				[Dot42.DexImport("SC_ACCEPTED", "I", AccessFlags = 25)]
				public const int SC_ACCEPTED = 202;
				/// <summary>
				/// <para><code>203 Non Authoritative Information</code> (HTTP/1.1 - RFC 2616) </para>        
				/// </summary>
				/// <java-name>
				/// SC_NON_AUTHORITATIVE_INFORMATION
				/// </java-name>
				[Dot42.DexImport("SC_NON_AUTHORITATIVE_INFORMATION", "I", AccessFlags = 25)]
				public const int SC_NON_AUTHORITATIVE_INFORMATION = 203;
				/// <summary>
				/// <para><code>204 No Content</code> (HTTP/1.0 - RFC 1945) </para>        
				/// </summary>
				/// <java-name>
				/// SC_NO_CONTENT
				/// </java-name>
				[Dot42.DexImport("SC_NO_CONTENT", "I", AccessFlags = 25)]
				public const int SC_NO_CONTENT = 204;
				/// <summary>
				/// <para><code>205 Reset Content</code> (HTTP/1.1 - RFC 2616) </para>        
				/// </summary>
				/// <java-name>
				/// SC_RESET_CONTENT
				/// </java-name>
				[Dot42.DexImport("SC_RESET_CONTENT", "I", AccessFlags = 25)]
				public const int SC_RESET_CONTENT = 205;
				/// <summary>
				/// <para><code>206 Partial Content</code> (HTTP/1.1 - RFC 2616) </para>        
				/// </summary>
				/// <java-name>
				/// SC_PARTIAL_CONTENT
				/// </java-name>
				[Dot42.DexImport("SC_PARTIAL_CONTENT", "I", AccessFlags = 25)]
				public const int SC_PARTIAL_CONTENT = 206;
				/// <summary>
				/// <para><code>207 Multi-Status</code> (WebDAV - RFC 2518) or <code>207 Partial Update OK</code> (HTTP/1.1 - draft-ietf-http-v11-spec-rev-01?) </para>        
				/// </summary>
				/// <java-name>
				/// SC_MULTI_STATUS
				/// </java-name>
				[Dot42.DexImport("SC_MULTI_STATUS", "I", AccessFlags = 25)]
				public const int SC_MULTI_STATUS = 207;
				/// <summary>
				/// <para><code>300 Mutliple Choices</code> (HTTP/1.1 - RFC 2616) </para>        
				/// </summary>
				/// <java-name>
				/// SC_MULTIPLE_CHOICES
				/// </java-name>
				[Dot42.DexImport("SC_MULTIPLE_CHOICES", "I", AccessFlags = 25)]
				public const int SC_MULTIPLE_CHOICES = 300;
				/// <summary>
				/// <para><code>301 Moved Permanently</code> (HTTP/1.0 - RFC 1945) </para>        
				/// </summary>
				/// <java-name>
				/// SC_MOVED_PERMANENTLY
				/// </java-name>
				[Dot42.DexImport("SC_MOVED_PERMANENTLY", "I", AccessFlags = 25)]
				public const int SC_MOVED_PERMANENTLY = 301;
				/// <summary>
				/// <para><code>302 Moved Temporarily</code> (Sometimes <code>Found</code>) (HTTP/1.0 - RFC 1945) </para>        
				/// </summary>
				/// <java-name>
				/// SC_MOVED_TEMPORARILY
				/// </java-name>
				[Dot42.DexImport("SC_MOVED_TEMPORARILY", "I", AccessFlags = 25)]
				public const int SC_MOVED_TEMPORARILY = 302;
				/// <summary>
				/// <para><code>303 See Other</code> (HTTP/1.1 - RFC 2616) </para>        
				/// </summary>
				/// <java-name>
				/// SC_SEE_OTHER
				/// </java-name>
				[Dot42.DexImport("SC_SEE_OTHER", "I", AccessFlags = 25)]
				public const int SC_SEE_OTHER = 303;
				/// <summary>
				/// <para><code>304 Not Modified</code> (HTTP/1.0 - RFC 1945) </para>        
				/// </summary>
				/// <java-name>
				/// SC_NOT_MODIFIED
				/// </java-name>
				[Dot42.DexImport("SC_NOT_MODIFIED", "I", AccessFlags = 25)]
				public const int SC_NOT_MODIFIED = 304;
				/// <summary>
				/// <para><code>305 Use Proxy</code> (HTTP/1.1 - RFC 2616) </para>        
				/// </summary>
				/// <java-name>
				/// SC_USE_PROXY
				/// </java-name>
				[Dot42.DexImport("SC_USE_PROXY", "I", AccessFlags = 25)]
				public const int SC_USE_PROXY = 305;
				/// <summary>
				/// <para><code>307 Temporary Redirect</code> (HTTP/1.1 - RFC 2616) </para>        
				/// </summary>
				/// <java-name>
				/// SC_TEMPORARY_REDIRECT
				/// </java-name>
				[Dot42.DexImport("SC_TEMPORARY_REDIRECT", "I", AccessFlags = 25)]
				public const int SC_TEMPORARY_REDIRECT = 307;
				/// <summary>
				/// <para><code>400 Bad Request</code> (HTTP/1.1 - RFC 2616) </para>        
				/// </summary>
				/// <java-name>
				/// SC_BAD_REQUEST
				/// </java-name>
				[Dot42.DexImport("SC_BAD_REQUEST", "I", AccessFlags = 25)]
				public const int SC_BAD_REQUEST = 400;
				/// <summary>
				/// <para><code>401 Unauthorized</code> (HTTP/1.0 - RFC 1945) </para>        
				/// </summary>
				/// <java-name>
				/// SC_UNAUTHORIZED
				/// </java-name>
				[Dot42.DexImport("SC_UNAUTHORIZED", "I", AccessFlags = 25)]
				public const int SC_UNAUTHORIZED = 401;
				/// <summary>
				/// <para><code>402 Payment Required</code> (HTTP/1.1 - RFC 2616) </para>        
				/// </summary>
				/// <java-name>
				/// SC_PAYMENT_REQUIRED
				/// </java-name>
				[Dot42.DexImport("SC_PAYMENT_REQUIRED", "I", AccessFlags = 25)]
				public const int SC_PAYMENT_REQUIRED = 402;
				/// <summary>
				/// <para><code>403 Forbidden</code> (HTTP/1.0 - RFC 1945) </para>        
				/// </summary>
				/// <java-name>
				/// SC_FORBIDDEN
				/// </java-name>
				[Dot42.DexImport("SC_FORBIDDEN", "I", AccessFlags = 25)]
				public const int SC_FORBIDDEN = 403;
				/// <summary>
				/// <para><code>404 Not Found</code> (HTTP/1.0 - RFC 1945) </para>        
				/// </summary>
				/// <java-name>
				/// SC_NOT_FOUND
				/// </java-name>
				[Dot42.DexImport("SC_NOT_FOUND", "I", AccessFlags = 25)]
				public const int SC_NOT_FOUND = 404;
				/// <summary>
				/// <para><code>405 Method Not Allowed</code> (HTTP/1.1 - RFC 2616) </para>        
				/// </summary>
				/// <java-name>
				/// SC_METHOD_NOT_ALLOWED
				/// </java-name>
				[Dot42.DexImport("SC_METHOD_NOT_ALLOWED", "I", AccessFlags = 25)]
				public const int SC_METHOD_NOT_ALLOWED = 405;
				/// <summary>
				/// <para><code>406 Not Acceptable</code> (HTTP/1.1 - RFC 2616) </para>        
				/// </summary>
				/// <java-name>
				/// SC_NOT_ACCEPTABLE
				/// </java-name>
				[Dot42.DexImport("SC_NOT_ACCEPTABLE", "I", AccessFlags = 25)]
				public const int SC_NOT_ACCEPTABLE = 406;
				/// <summary>
				/// <para><code>407 Proxy Authentication Required</code> (HTTP/1.1 - RFC 2616) </para>        
				/// </summary>
				/// <java-name>
				/// SC_PROXY_AUTHENTICATION_REQUIRED
				/// </java-name>
				[Dot42.DexImport("SC_PROXY_AUTHENTICATION_REQUIRED", "I", AccessFlags = 25)]
				public const int SC_PROXY_AUTHENTICATION_REQUIRED = 407;
				/// <summary>
				/// <para><code>408 Request Timeout</code> (HTTP/1.1 - RFC 2616) </para>        
				/// </summary>
				/// <java-name>
				/// SC_REQUEST_TIMEOUT
				/// </java-name>
				[Dot42.DexImport("SC_REQUEST_TIMEOUT", "I", AccessFlags = 25)]
				public const int SC_REQUEST_TIMEOUT = 408;
				/// <summary>
				/// <para><code>409 Conflict</code> (HTTP/1.1 - RFC 2616) </para>        
				/// </summary>
				/// <java-name>
				/// SC_CONFLICT
				/// </java-name>
				[Dot42.DexImport("SC_CONFLICT", "I", AccessFlags = 25)]
				public const int SC_CONFLICT = 409;
				/// <summary>
				/// <para><code>410 Gone</code> (HTTP/1.1 - RFC 2616) </para>        
				/// </summary>
				/// <java-name>
				/// SC_GONE
				/// </java-name>
				[Dot42.DexImport("SC_GONE", "I", AccessFlags = 25)]
				public const int SC_GONE = 410;
				/// <summary>
				/// <para><code>411 Length Required</code> (HTTP/1.1 - RFC 2616) </para>        
				/// </summary>
				/// <java-name>
				/// SC_LENGTH_REQUIRED
				/// </java-name>
				[Dot42.DexImport("SC_LENGTH_REQUIRED", "I", AccessFlags = 25)]
				public const int SC_LENGTH_REQUIRED = 411;
				/// <summary>
				/// <para><code>412 Precondition Failed</code> (HTTP/1.1 - RFC 2616) </para>        
				/// </summary>
				/// <java-name>
				/// SC_PRECONDITION_FAILED
				/// </java-name>
				[Dot42.DexImport("SC_PRECONDITION_FAILED", "I", AccessFlags = 25)]
				public const int SC_PRECONDITION_FAILED = 412;
				/// <summary>
				/// <para><code>413 Request Entity Too Large</code> (HTTP/1.1 - RFC 2616) </para>        
				/// </summary>
				/// <java-name>
				/// SC_REQUEST_TOO_LONG
				/// </java-name>
				[Dot42.DexImport("SC_REQUEST_TOO_LONG", "I", AccessFlags = 25)]
				public const int SC_REQUEST_TOO_LONG = 413;
				/// <summary>
				/// <para><code>414 Request-URI Too Long</code> (HTTP/1.1 - RFC 2616) </para>        
				/// </summary>
				/// <java-name>
				/// SC_REQUEST_URI_TOO_LONG
				/// </java-name>
				[Dot42.DexImport("SC_REQUEST_URI_TOO_LONG", "I", AccessFlags = 25)]
				public const int SC_REQUEST_URI_TOO_LONG = 414;
				/// <summary>
				/// <para><code>415 Unsupported Media Type</code> (HTTP/1.1 - RFC 2616) </para>        
				/// </summary>
				/// <java-name>
				/// SC_UNSUPPORTED_MEDIA_TYPE
				/// </java-name>
				[Dot42.DexImport("SC_UNSUPPORTED_MEDIA_TYPE", "I", AccessFlags = 25)]
				public const int SC_UNSUPPORTED_MEDIA_TYPE = 415;
				/// <summary>
				/// <para><code>416 Requested Range Not Satisfiable</code> (HTTP/1.1 - RFC 2616) </para>        
				/// </summary>
				/// <java-name>
				/// SC_REQUESTED_RANGE_NOT_SATISFIABLE
				/// </java-name>
				[Dot42.DexImport("SC_REQUESTED_RANGE_NOT_SATISFIABLE", "I", AccessFlags = 25)]
				public const int SC_REQUESTED_RANGE_NOT_SATISFIABLE = 416;
				/// <summary>
				/// <para><code>417 Expectation Failed</code> (HTTP/1.1 - RFC 2616) </para>        
				/// </summary>
				/// <java-name>
				/// SC_EXPECTATION_FAILED
				/// </java-name>
				[Dot42.DexImport("SC_EXPECTATION_FAILED", "I", AccessFlags = 25)]
				public const int SC_EXPECTATION_FAILED = 417;
				/// <summary>
				/// <para>Static constant for a 418 error. <code>418 Unprocessable Entity</code> (WebDAV drafts?) or <code>418 Reauthentication Required</code> (HTTP/1.1 drafts?) Static constant for a 419 error. <code>419 Insufficient Space on Resource</code> (WebDAV - draft-ietf-webdav-protocol-05?) or <code>419 Proxy Reauthentication Required</code> (HTTP/1.1 drafts?) </para>        
				/// </summary>
				/// <java-name>
				/// SC_INSUFFICIENT_SPACE_ON_RESOURCE
				/// </java-name>
				[Dot42.DexImport("SC_INSUFFICIENT_SPACE_ON_RESOURCE", "I", AccessFlags = 25)]
				public const int SC_INSUFFICIENT_SPACE_ON_RESOURCE = 419;
				/// <summary>
				/// <para>Static constant for a 420 error. <code>420 Method Failure</code> (WebDAV - draft-ietf-webdav-protocol-05?) </para>        
				/// </summary>
				/// <java-name>
				/// SC_METHOD_FAILURE
				/// </java-name>
				[Dot42.DexImport("SC_METHOD_FAILURE", "I", AccessFlags = 25)]
				public const int SC_METHOD_FAILURE = 420;
				/// <summary>
				/// <para><code>422 Unprocessable Entity</code> (WebDAV - RFC 2518) </para>        
				/// </summary>
				/// <java-name>
				/// SC_UNPROCESSABLE_ENTITY
				/// </java-name>
				[Dot42.DexImport("SC_UNPROCESSABLE_ENTITY", "I", AccessFlags = 25)]
				public const int SC_UNPROCESSABLE_ENTITY = 422;
				/// <summary>
				/// <para><code>423 Locked</code> (WebDAV - RFC 2518) </para>        
				/// </summary>
				/// <java-name>
				/// SC_LOCKED
				/// </java-name>
				[Dot42.DexImport("SC_LOCKED", "I", AccessFlags = 25)]
				public const int SC_LOCKED = 423;
				/// <summary>
				/// <para><code>424 Failed Dependency</code> (WebDAV - RFC 2518) </para>        
				/// </summary>
				/// <java-name>
				/// SC_FAILED_DEPENDENCY
				/// </java-name>
				[Dot42.DexImport("SC_FAILED_DEPENDENCY", "I", AccessFlags = 25)]
				public const int SC_FAILED_DEPENDENCY = 424;
				/// <summary>
				/// <para><code>500 Server Error</code> (HTTP/1.0 - RFC 1945) </para>        
				/// </summary>
				/// <java-name>
				/// SC_INTERNAL_SERVER_ERROR
				/// </java-name>
				[Dot42.DexImport("SC_INTERNAL_SERVER_ERROR", "I", AccessFlags = 25)]
				public const int SC_INTERNAL_SERVER_ERROR = 500;
				/// <summary>
				/// <para><code>501 Not Implemented</code> (HTTP/1.0 - RFC 1945) </para>        
				/// </summary>
				/// <java-name>
				/// SC_NOT_IMPLEMENTED
				/// </java-name>
				[Dot42.DexImport("SC_NOT_IMPLEMENTED", "I", AccessFlags = 25)]
				public const int SC_NOT_IMPLEMENTED = 501;
				/// <summary>
				/// <para><code>502 Bad Gateway</code> (HTTP/1.0 - RFC 1945) </para>        
				/// </summary>
				/// <java-name>
				/// SC_BAD_GATEWAY
				/// </java-name>
				[Dot42.DexImport("SC_BAD_GATEWAY", "I", AccessFlags = 25)]
				public const int SC_BAD_GATEWAY = 502;
				/// <summary>
				/// <para><code>503 Service Unavailable</code> (HTTP/1.0 - RFC 1945) </para>        
				/// </summary>
				/// <java-name>
				/// SC_SERVICE_UNAVAILABLE
				/// </java-name>
				[Dot42.DexImport("SC_SERVICE_UNAVAILABLE", "I", AccessFlags = 25)]
				public const int SC_SERVICE_UNAVAILABLE = 503;
				/// <summary>
				/// <para><code>504 Gateway Timeout</code> (HTTP/1.1 - RFC 2616) </para>        
				/// </summary>
				/// <java-name>
				/// SC_GATEWAY_TIMEOUT
				/// </java-name>
				[Dot42.DexImport("SC_GATEWAY_TIMEOUT", "I", AccessFlags = 25)]
				public const int SC_GATEWAY_TIMEOUT = 504;
				/// <summary>
				/// <para><code>505 HTTP Version Not Supported</code> (HTTP/1.1 - RFC 2616) </para>        
				/// </summary>
				/// <java-name>
				/// SC_HTTP_VERSION_NOT_SUPPORTED
				/// </java-name>
				[Dot42.DexImport("SC_HTTP_VERSION_NOT_SUPPORTED", "I", AccessFlags = 25)]
				public const int SC_HTTP_VERSION_NOT_SUPPORTED = 505;
				/// <summary>
				/// <para><code>507 Insufficient Storage</code> (WebDAV - RFC 2518) </para>        
				/// </summary>
				/// <java-name>
				/// SC_INSUFFICIENT_STORAGE
				/// </java-name>
				[Dot42.DexImport("SC_INSUFFICIENT_STORAGE", "I", AccessFlags = 25)]
				public const int SC_INSUFFICIENT_STORAGE = 507;
		}

		/// <summary>
		/// <para>Constants enumerating the HTTP status codes. All status codes defined in RFC1945 (HTTP/1.0), RFC2616 (HTTP/1.1), and RFC2518 (WebDAV) are listed.</para><para><para>StatusLine </para><para>Unascribed </para><simplesectsep></simplesectsep><para> </para><simplesectsep></simplesectsep><para></para><para></para><title>Revision:</title><para>503381 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/HttpStatus
		/// </java-name>
		[Dot42.DexImport("org/apache/http/HttpStatus", AccessFlags = 1537)]
		public partial interface IHttpStatus
 /* scope: __dot42__ */ 
		{
		}

		/// <summary>
		/// <para>Represents an HTTP version, as specified in RFC 2616.</para><para><para></para><para></para><title>Revision:</title><para>609106 </para><title>Date:</title><para>2008-01-05 01:15:42 -0800 (Sat, 05 Jan 2008) </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/HttpVersion
		/// </java-name>
		[Dot42.DexImport("org/apache/http/HttpVersion", AccessFlags = 49)]
		public sealed partial class HttpVersion : global::Org.Apache.Http.ProtocolVersion, global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>The protocol name. </para>        
				/// </summary>
				/// <java-name>
				/// HTTP
				/// </java-name>
				[Dot42.DexImport("HTTP", "Ljava/lang/String;", AccessFlags = 25)]
				public const string HTTP = "HTTP";
				/// <summary>
				/// <para>HTTP protocol version 0.9 </para>        
				/// </summary>
				/// <java-name>
				/// HTTP_0_9
				/// </java-name>
				[Dot42.DexImport("HTTP_0_9", "Lorg/apache/http/HttpVersion;", AccessFlags = 25)]
				public static readonly global::Org.Apache.Http.HttpVersion HTTP_0_9;
				/// <summary>
				/// <para>HTTP protocol version 1.0 </para>        
				/// </summary>
				/// <java-name>
				/// HTTP_1_0
				/// </java-name>
				[Dot42.DexImport("HTTP_1_0", "Lorg/apache/http/HttpVersion;", AccessFlags = 25)]
				public static readonly global::Org.Apache.Http.HttpVersion HTTP_1_0;
				/// <summary>
				/// <para>HTTP protocol version 1.1 </para>        
				/// </summary>
				/// <java-name>
				/// HTTP_1_1
				/// </java-name>
				[Dot42.DexImport("HTTP_1_1", "Lorg/apache/http/HttpVersion;", AccessFlags = 25)]
				public static readonly global::Org.Apache.Http.HttpVersion HTTP_1_1;
				/// <summary>
				/// <para>Create an HTTP protocol version designator.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(II)V", AccessFlags = 1)]
				public HttpVersion(int major, int minor) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Obtains a specific HTTP version.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an instance of HttpVersion with the argument version </para>
				/// </returns>
				/// <java-name>
				/// forVersion
				/// </java-name>
				[Dot42.DexImport("forVersion", "(II)Lorg/apache/http/ProtocolVersion;", AccessFlags = 1)]
				public override global::Org.Apache.Http.ProtocolVersion ForVersion(int major, int minor) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.ProtocolVersion);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal HttpVersion() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		/// <para>Interface for deciding whether a connection should be kept alive.</para><para><para></para><para></para><title>Revision:</title><para>496070 </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/ConnectionReuseStrategy
		/// </java-name>
		[Dot42.DexImport("org/apache/http/ConnectionReuseStrategy", AccessFlags = 1537)]
		public partial interface IConnectionReuseStrategy
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Decides whether a connection can be kept open after a request. If this method returns <code>false</code>, the caller MUST close the connection to correctly implement the HTTP protocol. If it returns <code>true</code>, the caller SHOULD attempt to keep the connection open for reuse with another request. <br></br> One can use the HTTP context to retrieve additional objects that may be relevant for the keep-alive strategy: the actual HTTP connection, the original HTTP request, target host if known, number of times the connection has been reused already and so on. <br></br> If the connection is already closed, <code>false</code> is returned. The stale connection check MUST NOT be triggered by a connection reuse strategy.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> if the connection is allowed to be reused, or <code>false</code> if it MUST NOT be reused </para>
				/// </returns>
				/// <java-name>
				/// keepAlive
				/// </java-name>
				[Dot42.DexImport("keepAlive", "(Lorg/apache/http/HttpResponse;Lorg/apache/http/protocol/HttpContext;)Z", AccessFlags = 1025)]
				bool KeepAlive(global::Org.Apache.Http.IHttpResponse response, global::Org.Apache.Http.Protocol.IHttpContext context) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>A type-safe iterator for Header objects.</para><para><para></para><title>Revision:</title><para>581981 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/HeaderIterator
		/// </java-name>
		[Dot42.DexImport("org/apache/http/HeaderIterator", AccessFlags = 1537)]
		public partial interface IHeaderIterator : global::Java.Util.IIterator<object>
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Indicates whether there is another header in this iteration.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> if there is another header, <code>false</code> otherwise </para>
				/// </returns>
				/// <java-name>
				/// hasNext
				/// </java-name>
				[Dot42.DexImport("hasNext", "()Z", AccessFlags = 1025)]
				bool HasNext() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Obtains the next header from this iteration. This method should only be called while hasNext is true.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the next header in this iteration </para>
				/// </returns>
				/// <java-name>
				/// nextHeader
				/// </java-name>
				[Dot42.DexImport("nextHeader", "()Lorg/apache/http/Header;", AccessFlags = 1025)]
				global::Org.Apache.Http.IHeader NextHeader() /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>A request with an entity.</para><para><para></para><para></para><title>Revision:</title><para>618017 </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/HttpEntityEnclosingRequest
		/// </java-name>
		[Dot42.DexImport("org/apache/http/HttpEntityEnclosingRequest", AccessFlags = 1537)]
		public partial interface IHttpEntityEnclosingRequest : global::Org.Apache.Http.IHttpRequest
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Tells if this request should use the expect-continue handshake. The expect continue handshake gives the server a chance to decide whether to accept the entity enclosing request before the possibly lengthy entity is sent across the wire. </para>        
				/// </summary>
				/// <returns>
				/// <para>true if the expect continue handshake should be used, false if not. </para>
				/// </returns>
				/// <java-name>
				/// expectContinue
				/// </java-name>
				[Dot42.DexImport("expectContinue", "()Z", AccessFlags = 1025)]
				bool ExpectContinue() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Hands the entity to the request. </para>        
				/// </summary>
				/// <java-name>
				/// setEntity
				/// </java-name>
				[Dot42.DexImport("setEntity", "(Lorg/apache/http/HttpEntity;)V", AccessFlags = 1025)]
				void SetEntity(global::Org.Apache.Http.IHttpEntity entity) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getEntity
				/// </java-name>
				[Dot42.DexImport("getEntity", "()Lorg/apache/http/HttpEntity;", AccessFlags = 1025)]
				global::Org.Apache.Http.IHttpEntity GetEntity() /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>Indicates that a connection has been closed.</para><para><para></para><para></para><title>Revision:</title><para>618017 </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/ConnectionClosedException
		/// </java-name>
		[Dot42.DexImport("org/apache/http/ConnectionClosedException", AccessFlags = 33)]
		public partial class ConnectionClosedException : global::System.IO.IOException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new ConnectionClosedException with the specified detail message.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public ConnectionClosedException(string message) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ConnectionClosedException() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		/// <para>An HTTP response.</para><para><para></para><para></para><title>Revision:</title><para>652956 </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/HttpResponse
		/// </java-name>
		[Dot42.DexImport("org/apache/http/HttpResponse", AccessFlags = 1537)]
		public partial interface IHttpResponse : global::Org.Apache.Http.IHttpMessage
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Obtains the status line of this response. The status line can be set using one of the setStatusLine methods, or it can be initialized in a constructor.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the status line, or <code>null</code> if not yet set </para>
				/// </returns>
				/// <java-name>
				/// getStatusLine
				/// </java-name>
				[Dot42.DexImport("getStatusLine", "()Lorg/apache/http/StatusLine;", AccessFlags = 1025)]
				global::Org.Apache.Http.IStatusLine GetStatusLine() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets the status line of this response.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setStatusLine
				/// </java-name>
				[Dot42.DexImport("setStatusLine", "(Lorg/apache/http/StatusLine;)V", AccessFlags = 1025)]
				void SetStatusLine(global::Org.Apache.Http.IStatusLine statusline) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets the status line of this response. The reason phrase will be determined based on the current locale.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setStatusLine
				/// </java-name>
				[Dot42.DexImport("setStatusLine", "(Lorg/apache/http/ProtocolVersion;I)V", AccessFlags = 1025)]
				void SetStatusLine(global::Org.Apache.Http.ProtocolVersion ver, int code) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets the status line of this response with a reason phrase.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setStatusLine
				/// </java-name>
				[Dot42.DexImport("setStatusLine", "(Lorg/apache/http/ProtocolVersion;ILjava/lang/String;)V", AccessFlags = 1025)]
				void SetStatusLine(global::Org.Apache.Http.ProtocolVersion ver, int code, string reason) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Updates the status line of this response with a new status code. The status line can only be updated if it is available. It must have been set either explicitly or in a constructor. <br></br> The reason phrase will be updated according to the new status code, based on the current locale. It can be set explicitly using setReasonPhrase.</para><para><para>HttpStatus </para><simplesectsep></simplesectsep><para>setStatusLine(StatusLine) </para><simplesectsep></simplesectsep><para>setStatusLine(ProtocolVersion,int) </para></para>        
				/// </summary>
				/// <java-name>
				/// setStatusCode
				/// </java-name>
				[Dot42.DexImport("setStatusCode", "(I)V", AccessFlags = 1025)]
				void SetStatusCode(int code) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Updates the status line of this response with a new reason phrase. The status line can only be updated if it is available. It must have been set either explicitly or in a constructor.</para><para><para>setStatusLine(StatusLine) </para><simplesectsep></simplesectsep><para>setStatusLine(ProtocolVersion,int) </para></para>        
				/// </summary>
				/// <java-name>
				/// setReasonPhrase
				/// </java-name>
				[Dot42.DexImport("setReasonPhrase", "(Ljava/lang/String;)V", AccessFlags = 1025)]
				void SetReasonPhrase(string reason) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Obtains the message entity of this response, if any. The entity is provided by calling setEntity.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the response entity, or <code>null</code> if there is none </para>
				/// </returns>
				/// <java-name>
				/// getEntity
				/// </java-name>
				[Dot42.DexImport("getEntity", "()Lorg/apache/http/HttpEntity;", AccessFlags = 1025)]
				global::Org.Apache.Http.IHttpEntity GetEntity() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Associates a response entity with this response.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setEntity
				/// </java-name>
				[Dot42.DexImport("setEntity", "(Lorg/apache/http/HttpEntity;)V", AccessFlags = 1025)]
				void SetEntity(global::Org.Apache.Http.IHttpEntity entity) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Obtains the locale of this response. The locale is used to determine the reason phrase for the status code. It can be changed using setLocale.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the locale of this response, never <code>null</code> </para>
				/// </returns>
				/// <java-name>
				/// getLocale
				/// </java-name>
				[Dot42.DexImport("getLocale", "()Ljava/util/Locale;", AccessFlags = 1025)]
				global::Java.Util.Locale GetLocale() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Changes the locale of this response. If there is a status line, it's reason phrase will be updated according to the status code and new locale.</para><para><para>getLocale getLocale </para><simplesectsep></simplesectsep><para>setStatusCode setStatusCode </para></para>        
				/// </summary>
				/// <java-name>
				/// setLocale
				/// </java-name>
				[Dot42.DexImport("setLocale", "(Ljava/util/Locale;)V", AccessFlags = 1025)]
				void SetLocale(global::Java.Util.Locale loc) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>Indicates a parse error. Parse errors when receiving a message will typically trigger ProtocolException. Parse errors that do not occur during protocol execution may be handled differently. This is an unchecked exceptions, since there are cases where the data to be parsed has been generated and is therefore known to be parseable.</para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/ParseException
		/// </java-name>
		[Dot42.DexImport("org/apache/http/ParseException", AccessFlags = 33)]
		public partial class ParseException : global::System.SystemException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a ParseException without details. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ParseException() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a ParseException with a detail message.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public ParseException(string message) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>A factory for HttpResponse objects.</para><para><para></para><para></para><title>Revision:</title><para>573864 </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/HttpResponseFactory
		/// </java-name>
		[Dot42.DexImport("org/apache/http/HttpResponseFactory", AccessFlags = 1537)]
		public partial interface IHttpResponseFactory
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new response from status line elements.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the new response with an initialized status line </para>
				/// </returns>
				/// <java-name>
				/// newHttpResponse
				/// </java-name>
				[Dot42.DexImport("newHttpResponse", "(Lorg/apache/http/ProtocolVersion;ILorg/apache/http/protocol/HttpContext;)Lorg/ap" +
    "ache/http/HttpResponse;", AccessFlags = 1025)]
				global::Org.Apache.Http.IHttpResponse NewHttpResponse(global::Org.Apache.Http.ProtocolVersion ver, int status, global::Org.Apache.Http.Protocol.IHttpContext context) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Creates a new response from a status line.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the new response with the argument status line </para>
				/// </returns>
				/// <java-name>
				/// newHttpResponse
				/// </java-name>
				[Dot42.DexImport("newHttpResponse", "(Lorg/apache/http/StatusLine;Lorg/apache/http/protocol/HttpContext;)Lorg/apache/h" +
    "ttp/HttpResponse;", AccessFlags = 1025)]
				global::Org.Apache.Http.IHttpResponse NewHttpResponse(global::Org.Apache.Http.IStatusLine statusline, global::Org.Apache.Http.Protocol.IHttpContext context) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>An HTTP connection for use on the server side. Requests are received, responses are sent.</para><para><para></para><para></para><title>Revision:</title><para>542199 </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/HttpServerConnection
		/// </java-name>
		[Dot42.DexImport("org/apache/http/HttpServerConnection", AccessFlags = 1537)]
		public partial interface IHttpServerConnection : global::Org.Apache.Http.IHttpConnection
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Receives the request line and all headers available from this connection. The caller should examine the returned request and decide if to receive a request entity as well.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a new HttpRequest object whose request line and headers are initialized. </para>
				/// </returns>
				/// <java-name>
				/// receiveRequestHeader
				/// </java-name>
				[Dot42.DexImport("receiveRequestHeader", "()Lorg/apache/http/HttpRequest;", AccessFlags = 1025)]
				global::Org.Apache.Http.IHttpRequest ReceiveRequestHeader() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Receives the next request entity available from this connection and attaches it to an existing request. </para>        
				/// </summary>
				/// <java-name>
				/// receiveRequestEntity
				/// </java-name>
				[Dot42.DexImport("receiveRequestEntity", "(Lorg/apache/http/HttpEntityEnclosingRequest;)V", AccessFlags = 1025)]
				void ReceiveRequestEntity(global::Org.Apache.Http.IHttpEntityEnclosingRequest request) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sends the response line and headers of a response over this connection. </para>        
				/// </summary>
				/// <java-name>
				/// sendResponseHeader
				/// </java-name>
				[Dot42.DexImport("sendResponseHeader", "(Lorg/apache/http/HttpResponse;)V", AccessFlags = 1025)]
				void SendResponseHeader(global::Org.Apache.Http.IHttpResponse response) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sends the response entity of a response over this connection. </para>        
				/// </summary>
				/// <java-name>
				/// sendResponseEntity
				/// </java-name>
				[Dot42.DexImport("sendResponseEntity", "(Lorg/apache/http/HttpResponse;)V", AccessFlags = 1025)]
				void SendResponseEntity(global::Org.Apache.Http.IHttpResponse response) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sends all pending buffered data over this connection. </para>        
				/// </summary>
				/// <java-name>
				/// flush
				/// </java-name>
				[Dot42.DexImport("flush", "()V", AccessFlags = 1025)]
				void Flush() /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>Processes a request. Provides the ability to process a request before it is sent to the server or after it has received on the server side.</para><para><para></para><para></para><title>Revision:</title><para>618367 </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/HttpRequestInterceptor
		/// </java-name>
		[Dot42.DexImport("org/apache/http/HttpRequestInterceptor", AccessFlags = 1537)]
		public partial interface IHttpRequestInterceptor
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Processes a request. On the client side, this step is performed before the request is sent to the server. On the server side, this step is performed on incoming messages before the message body is evaluated.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// process
				/// </java-name>
				[Dot42.DexImport("process", "(Lorg/apache/http/HttpRequest;Lorg/apache/http/protocol/HttpContext;)V", AccessFlags = 1025)]
				void Process(global::Org.Apache.Http.IHttpRequest request, global::Org.Apache.Http.Protocol.IHttpContext context) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>A type-safe iterator for HeaderElement objects.</para><para><para></para><title>Revision:</title><para>584542 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/HeaderElementIterator
		/// </java-name>
		[Dot42.DexImport("org/apache/http/HeaderElementIterator", AccessFlags = 1537)]
		public partial interface IHeaderElementIterator : global::Java.Util.IIterator<object>
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Indicates whether there is another header element in this iteration.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> if there is another header element, <code>false</code> otherwise </para>
				/// </returns>
				/// <java-name>
				/// hasNext
				/// </java-name>
				[Dot42.DexImport("hasNext", "()Z", AccessFlags = 1025)]
				bool HasNext() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Obtains the next header element from this iteration. This method should only be called while hasNext is true.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the next header element in this iteration </para>
				/// </returns>
				/// <java-name>
				/// nextElement
				/// </java-name>
				[Dot42.DexImport("nextElement", "()Lorg/apache/http/HeaderElement;", AccessFlags = 1025)]
				global::Org.Apache.Http.IHeaderElement NextElement() /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>Indicates that an HTTP method is not supported.</para><para><para></para><para></para><title>Revision:</title><para>618017 </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/MethodNotSupportedException
		/// </java-name>
		[Dot42.DexImport("org/apache/http/MethodNotSupportedException", AccessFlags = 33)]
		public partial class MethodNotSupportedException : global::Org.Apache.Http.HttpException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new MethodNotSupportedException with the specified detail message.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public MethodNotSupportedException(string message) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new MethodNotSupportedException with the specified detail message and cause.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public MethodNotSupportedException(string message, global::System.Exception cause) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal MethodNotSupportedException() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		/// <para>The point of access to the statistics of an HttpConnection. </para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/HttpConnectionMetrics
		/// </java-name>
		[Dot42.DexImport("org/apache/http/HttpConnectionMetrics", AccessFlags = 1537)]
		public partial interface IHttpConnectionMetrics
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Returns the number of requests transferred over the connection, 0 if not available. </para>        
				/// </summary>
				/// <java-name>
				/// getRequestCount
				/// </java-name>
				[Dot42.DexImport("getRequestCount", "()J", AccessFlags = 1025)]
				long GetRequestCount() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the number of responses transferred over the connection, 0 if not available. </para>        
				/// </summary>
				/// <java-name>
				/// getResponseCount
				/// </java-name>
				[Dot42.DexImport("getResponseCount", "()J", AccessFlags = 1025)]
				long GetResponseCount() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the number of bytes transferred over the connection, 0 if not available. </para>        
				/// </summary>
				/// <java-name>
				/// getSentBytesCount
				/// </java-name>
				[Dot42.DexImport("getSentBytesCount", "()J", AccessFlags = 1025)]
				long GetSentBytesCount() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the number of bytes transferred over the connection, 0 if not available. </para>        
				/// </summary>
				/// <java-name>
				/// getReceivedBytesCount
				/// </java-name>
				[Dot42.DexImport("getReceivedBytesCount", "()J", AccessFlags = 1025)]
				long GetReceivedBytesCount() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Return the value for the specified metric.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the object representing the metric requested, <code>null</code> if the metric cannot not found. </para>
				/// </returns>
				/// <java-name>
				/// getMetric
				/// </java-name>
				[Dot42.DexImport("getMetric", "(Ljava/lang/String;)Ljava/lang/Object;", AccessFlags = 1025)]
				object GetMetric(string metricName) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Resets the counts </para>        
				/// </summary>
				/// <java-name>
				/// reset
				/// </java-name>
				[Dot42.DexImport("reset", "()V", AccessFlags = 1025)]
				void Reset() /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>A generic HTTP message. Holds what is common between requests and responses.</para><para><para></para><para></para><title>Revision:</title><para>610823 </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/HttpMessage
		/// </java-name>
		[Dot42.DexImport("org/apache/http/HttpMessage", AccessFlags = 1537)]
		public partial interface IHttpMessage
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Returns the protocol version this message is compatible with. </para>        
				/// </summary>
				/// <java-name>
				/// getProtocolVersion
				/// </java-name>
				[Dot42.DexImport("getProtocolVersion", "()Lorg/apache/http/ProtocolVersion;", AccessFlags = 1025)]
				global::Org.Apache.Http.ProtocolVersion GetProtocolVersion() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Checks if a certain header is present in this message. Header values are ignored.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if at least one header with this name is present. </para>
				/// </returns>
				/// <java-name>
				/// containsHeader
				/// </java-name>
				[Dot42.DexImport("containsHeader", "(Ljava/lang/String;)Z", AccessFlags = 1025)]
				bool ContainsHeader(string name) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns all the headers with a specified name of this message. Header values are ignored. Headers are orderd in the sequence they will be sent over a connection.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the headers whose name property equals <code>name</code>. </para>
				/// </returns>
				/// <java-name>
				/// getHeaders
				/// </java-name>
				[Dot42.DexImport("getHeaders", "(Ljava/lang/String;)[Lorg/apache/http/Header;", AccessFlags = 1025)]
				global::Org.Apache.Http.IHeader[] GetHeaders(string name) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the first header with a specified name of this message. Header values are ignored. If there is more than one matching header in the message the first element of getHeaders(String) is returned. If there is no matching header in the message <code>null</code> is returned.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the first header whose name property equals <code>name</code> or <code>null</code> if no such header could be found. </para>
				/// </returns>
				/// <java-name>
				/// getFirstHeader
				/// </java-name>
				[Dot42.DexImport("getFirstHeader", "(Ljava/lang/String;)Lorg/apache/http/Header;", AccessFlags = 1025)]
				global::Org.Apache.Http.IHeader GetFirstHeader(string name) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the last header with a specified name of this message. Header values are ignored. If there is more than one matching header in the message the last element of getHeaders(String) is returned. If there is no matching header in the message <code>null</code> is returned.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the last header whose name property equals <code>name</code>. or <code>null</code> if no such header could be found. </para>
				/// </returns>
				/// <java-name>
				/// getLastHeader
				/// </java-name>
				[Dot42.DexImport("getLastHeader", "(Ljava/lang/String;)Lorg/apache/http/Header;", AccessFlags = 1025)]
				global::Org.Apache.Http.IHeader GetLastHeader(string name) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns all the headers of this message. Headers are orderd in the sequence they will be sent over a connection.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>all the headers of this message </para>
				/// </returns>
				/// <java-name>
				/// getAllHeaders
				/// </java-name>
				[Dot42.DexImport("getAllHeaders", "()[Lorg/apache/http/Header;", AccessFlags = 1025)]
				global::Org.Apache.Http.IHeader[] GetAllHeaders() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Adds a header to this message. The header will be appended to the end of the list.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// addHeader
				/// </java-name>
				[Dot42.DexImport("addHeader", "(Lorg/apache/http/Header;)V", AccessFlags = 1025)]
				void AddHeader(global::Org.Apache.Http.IHeader header) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Adds a header to this message. The header will be appended to the end of the list.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// addHeader
				/// </java-name>
				[Dot42.DexImport("addHeader", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1025)]
				void AddHeader(string name, string value) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Overwrites the first header with the same name. The new header will be appended to the end of the list, if no header with the given name can be found.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setHeader
				/// </java-name>
				[Dot42.DexImport("setHeader", "(Lorg/apache/http/Header;)V", AccessFlags = 1025)]
				void SetHeader(global::Org.Apache.Http.IHeader header) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Overwrites the first header with the same name. The new header will be appended to the end of the list, if no header with the given name can be found.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setHeader
				/// </java-name>
				[Dot42.DexImport("setHeader", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1025)]
				void SetHeader(string name, string value) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Overwrites all the headers in the message.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setHeaders
				/// </java-name>
				[Dot42.DexImport("setHeaders", "([Lorg/apache/http/Header;)V", AccessFlags = 1025)]
				void SetHeaders(global::Org.Apache.Http.IHeader[] headers) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Removes a header from this message.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// removeHeader
				/// </java-name>
				[Dot42.DexImport("removeHeader", "(Lorg/apache/http/Header;)V", AccessFlags = 1025)]
				void RemoveHeader(global::Org.Apache.Http.IHeader header) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Removes all headers with a certain name from this message.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// removeHeaders
				/// </java-name>
				[Dot42.DexImport("removeHeaders", "(Ljava/lang/String;)V", AccessFlags = 1025)]
				void RemoveHeaders(string name) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns an iterator of all the headers.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Iterator that returns Header objects in the sequence they are sent over a connection. </para>
				/// </returns>
				/// <java-name>
				/// headerIterator
				/// </java-name>
				[Dot42.DexImport("headerIterator", "()Lorg/apache/http/HeaderIterator;", AccessFlags = 1025)]
				global::Org.Apache.Http.IHeaderIterator HeaderIterator() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns an iterator of the headers with a given name.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Iterator that returns Header objects with the argument name in the sequence they are sent over a connection. </para>
				/// </returns>
				/// <java-name>
				/// headerIterator
				/// </java-name>
				[Dot42.DexImport("headerIterator", "(Ljava/lang/String;)Lorg/apache/http/HeaderIterator;", AccessFlags = 1025)]
				global::Org.Apache.Http.IHeaderIterator HeaderIterator(string name) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the parameters effective for this message as set by setParams(HttpParams). </para>        
				/// </summary>
				/// <java-name>
				/// getParams
				/// </java-name>
				[Dot42.DexImport("getParams", "()Lorg/apache/http/params/HttpParams;", AccessFlags = 1025)]
				global::Org.Apache.Http.Params.IHttpParams GetParams() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Provides parameters to be used for the processing of this message. </para>        
				/// </summary>
				/// <java-name>
				/// setParams
				/// </java-name>
				[Dot42.DexImport("setParams", "(Lorg/apache/http/params/HttpParams;)V", AccessFlags = 1025)]
				void SetParams(global::Org.Apache.Http.Params.IHttpParams @params) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>Signals that the target server failed to respond with a valid HTTP response. </para><para><para></para><para></para><title>Revision:</title><para>618017 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/NoHttpResponseException
		/// </java-name>
		[Dot42.DexImport("org/apache/http/NoHttpResponseException", AccessFlags = 33)]
		public partial class NoHttpResponseException : global::System.IO.IOException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new NoHttpResponseException with the specified detail message.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public NoHttpResponseException(string message) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal NoHttpResponseException() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		/// <para>The first line of an HttpRequest. It contains the method, URI, and HTTP version of the request. For details, see RFC 2616.</para><para><para></para><para></para><title>Revision:</title><para>573864 </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/RequestLine
		/// </java-name>
		[Dot42.DexImport("org/apache/http/RequestLine", AccessFlags = 1537)]
		public partial interface IRequestLine
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// getMethod
				/// </java-name>
				[Dot42.DexImport("getMethod", "()Ljava/lang/String;", AccessFlags = 1025)]
				string GetMethod() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getProtocolVersion
				/// </java-name>
				[Dot42.DexImport("getProtocolVersion", "()Lorg/apache/http/ProtocolVersion;", AccessFlags = 1025)]
				global::Org.Apache.Http.ProtocolVersion GetProtocolVersion() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getUri
				/// </java-name>
				[Dot42.DexImport("getUri", "()Ljava/lang/String;", AccessFlags = 1025)]
				string GetUri() /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>A factory for HttpRequest objects.</para><para><para></para><para></para><title>Revision:</title><para>618017 </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/HttpRequestFactory
		/// </java-name>
		[Dot42.DexImport("org/apache/http/HttpRequestFactory", AccessFlags = 1537)]
		public partial interface IHttpRequestFactory
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// newHttpRequest
				/// </java-name>
				[Dot42.DexImport("newHttpRequest", "(Lorg/apache/http/RequestLine;)Lorg/apache/http/HttpRequest;", AccessFlags = 1025)]
				global::Org.Apache.Http.IHttpRequest NewHttpRequest(global::Org.Apache.Http.IRequestLine requestline) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// newHttpRequest
				/// </java-name>
				[Dot42.DexImport("newHttpRequest", "(Ljava/lang/String;Ljava/lang/String;)Lorg/apache/http/HttpRequest;", AccessFlags = 1025)]
				global::Org.Apache.Http.IHttpRequest NewHttpRequest(string method, string uri) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>A simple class encapsulating an attribute/value pair. </para><para>This class comforms to the generic grammar and formatting rules outlined in the  and  of  </para><para>&lt;h&gt;2.2 Basic Rules&lt;/h&gt; </para><para>The following rules are used throughout this specification to describe basic parsing constructs. The US-ASCII coded character set is defined by ANSI X3.4-1986. </para><para><pre>
		///        OCTET          = &lt;any 8-bit sequence of data&gt;
		///        CHAR           = &lt;any US-ASCII character (octets 0 - 127)&gt;
		///        UPALPHA        = &lt;any US-ASCII uppercase letter "A".."Z"&gt;
		///        LOALPHA        = &lt;any US-ASCII lowercase letter "a".."z"&gt;
		///        ALPHA          = UPALPHA | LOALPHA
		///        DIGIT          = &lt;any US-ASCII digit "0".."9"&gt;
		///        CTL            = &lt;any US-ASCII control character
		///                         (octets 0 - 31) and DEL (127)&gt;
		///        CR             = &lt;US-ASCII CR, carriage return (13)&gt;
		///        LF             = &lt;US-ASCII LF, linefeed (10)&gt;
		///        SP             = &lt;US-ASCII SP, space (32)&gt;
		///        HT             = &lt;US-ASCII HT, horizontal-tab (9)&gt;
		///        &lt;"&gt;            = &lt;US-ASCII double-quote mark (34)&gt;
		///    </pre> </para><para>Many HTTP/1.1 header field values consist of words separated by LWS or special characters. These special characters MUST be in a quoted string to be used within a parameter value (as defined in section 3.6). </para><para><pre>
		///    token          = 1*&lt;any char="" except="" ctls="" or="" separators&gt;=""&gt;
		///    separators     = "(" | ")" | "&lt;" | "&gt;" | "@"
		///                   | "," | ";" | ":" | "\" | &lt;"&gt;
		///                   | "/" | "[" | "]" | "?" | "="
		///                   | "{" | "}" | SP | HT
		///    </pre> </para><para>A string of text is parsed as a single word if it is quoted using double-quote marks. </para><para><pre>
		///    quoted-string  = ( &lt;"&gt; *(qdtext | quoted-pair ) &lt;"&gt; )
		///    qdtext         = &lt;any TEXT except &lt;"&gt;&gt;
		///    </pre> </para><para>The backslash character ("\") MAY be used as a single-character quoting mechanism only within quoted-string and comment constructs. </para><para><pre>
		///    quoted-pair    = "\" CHAR
		///    </pre> &lt;h&gt;3.6 Transfer Codings&lt;/h&gt; </para><para>Parameters are in the form of attribute/value pairs. </para><para><pre>
		///    parameter               = attribute "=" value
		///    attribute               = token
		///    value                   = token | quoted-string
		///    </pre></para><para><para> </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/NameValuePair
		/// </java-name>
		[Dot42.DexImport("org/apache/http/NameValuePair", AccessFlags = 1537)]
		public partial interface INameValuePair
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// getName
				/// </java-name>
				[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1025)]
				string GetName() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getValue
				/// </java-name>
				[Dot42.DexImport("getValue", "()Ljava/lang/String;", AccessFlags = 1025)]
				string GetValue() /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>Represents an HTTP header field.</para><para>The HTTP header fields follow the same generic format as that given in Section 3.1 of RFC 822. Each header field consists of a name followed by a colon (":") and the field value. Field names are case-insensitive. The field value MAY be preceded by any amount of LWS, though a single SP is preferred.</para><para><pre>
		///        message-header = field-name ":" [ field-value ]
		///        field-name     = token
		///        field-value    = *( field-content | LWS )
		///        field-content  = &lt;the OCTETs making up the field-value
		///                         and consisting of either *TEXT or combinations
		///                         of token, separators, and quoted-string&gt;
		///  *</pre></para><para><para> </para><simplesectsep></simplesectsep><para> </para><para></para><title>Revision:</title><para>569636 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/Header
		/// </java-name>
		[Dot42.DexImport("org/apache/http/Header", AccessFlags = 1537)]
		public partial interface IHeader
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// getName
				/// </java-name>
				[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1025)]
				string GetName() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getValue
				/// </java-name>
				[Dot42.DexImport("getValue", "()Ljava/lang/String;", AccessFlags = 1025)]
				string GetValue() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getElements
				/// </java-name>
				[Dot42.DexImport("getElements", "()[Lorg/apache/http/HeaderElement;", AccessFlags = 1025)]
				global::Org.Apache.Http.IHeaderElement[] GetElements() /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>An HTTP request.</para><para><para></para><para></para><title>Revision:</title><para>528428 </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/HttpRequest
		/// </java-name>
		[Dot42.DexImport("org/apache/http/HttpRequest", AccessFlags = 1537)]
		public partial interface IHttpRequest : global::Org.Apache.Http.IHttpMessage
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Returns the request line of this request. </para>        
				/// </summary>
				/// <returns>
				/// <para>the request line. </para>
				/// </returns>
				/// <java-name>
				/// getRequestLine
				/// </java-name>
				[Dot42.DexImport("getRequestLine", "()Lorg/apache/http/RequestLine;", AccessFlags = 1025)]
				global::Org.Apache.Http.IRequestLine GetRequestLine() /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>An HTTP connection for use on the client side. It is used for sending requests and receiving responses.</para><para><para></para><para></para><title>Revision:</title><para>542199 </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/HttpClientConnection
		/// </java-name>
		[Dot42.DexImport("org/apache/http/HttpClientConnection", AccessFlags = 1537)]
		public partial interface IHttpClientConnection : global::Org.Apache.Http.IHttpConnection
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Checks if response data is available from the connection. May wait for the specified time until some data becomes available. Note that some implementations may completely ignore the timeout parameter.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if data is available; false if there was no data available even after waiting for <code>timeout</code> milliseconds. </para>
				/// </returns>
				/// <java-name>
				/// isResponseAvailable
				/// </java-name>
				[Dot42.DexImport("isResponseAvailable", "(I)Z", AccessFlags = 1025)]
				bool IsResponseAvailable(int timeout) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sends the request line and all headers over the connection. </para>        
				/// </summary>
				/// <java-name>
				/// sendRequestHeader
				/// </java-name>
				[Dot42.DexImport("sendRequestHeader", "(Lorg/apache/http/HttpRequest;)V", AccessFlags = 1025)]
				void SendRequestHeader(global::Org.Apache.Http.IHttpRequest request) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sends the request entity over the connection. </para>        
				/// </summary>
				/// <java-name>
				/// sendRequestEntity
				/// </java-name>
				[Dot42.DexImport("sendRequestEntity", "(Lorg/apache/http/HttpEntityEnclosingRequest;)V", AccessFlags = 1025)]
				void SendRequestEntity(global::Org.Apache.Http.IHttpEntityEnclosingRequest request) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Receives the request line and headers of the next response available from this connection. The caller should examine the HttpResponse object to find out if it should try to receive a response entity as well.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a new HttpResponse object with status line and headers initialized. </para>
				/// </returns>
				/// <java-name>
				/// receiveResponseHeader
				/// </java-name>
				[Dot42.DexImport("receiveResponseHeader", "()Lorg/apache/http/HttpResponse;", AccessFlags = 1025)]
				global::Org.Apache.Http.IHttpResponse ReceiveResponseHeader() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Receives the next response entity available from this connection and attaches it to an existing HttpResponse object.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// receiveResponseEntity
				/// </java-name>
				[Dot42.DexImport("receiveResponseEntity", "(Lorg/apache/http/HttpResponse;)V", AccessFlags = 1025)]
				void ReceiveResponseEntity(global::Org.Apache.Http.IHttpResponse response) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Writes out all pending buffered data over the open connection.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// flush
				/// </java-name>
				[Dot42.DexImport("flush", "()V", AccessFlags = 1025)]
				void Flush() /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>An iterator for String tokens. This interface is designed as a complement to HeaderElementIterator, in cases where the items are plain strings rather than full header elements.</para><para><para></para><title>Revision:</title><para>601000 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/TokenIterator
		/// </java-name>
		[Dot42.DexImport("org/apache/http/TokenIterator", AccessFlags = 1537)]
		public partial interface ITokenIterator : global::Java.Util.IIterator<object>
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Indicates whether there is another token in this iteration.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> if there is another token, <code>false</code> otherwise </para>
				/// </returns>
				/// <java-name>
				/// hasNext
				/// </java-name>
				[Dot42.DexImport("hasNext", "()Z", AccessFlags = 1025)]
				bool HasNext() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Obtains the next token from this iteration. This method should only be called while hasNext is true.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the next token in this iteration </para>
				/// </returns>
				/// <java-name>
				/// nextToken
				/// </java-name>
				[Dot42.DexImport("nextToken", "()Ljava/lang/String;", AccessFlags = 1025)]
				string NextToken() /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>Processes a response. Provides the ability to process a response before it is sent to the client or after it has been received on the client side.</para><para><para></para><para></para><title>Revision:</title><para>618367 </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/HttpResponseInterceptor
		/// </java-name>
		[Dot42.DexImport("org/apache/http/HttpResponseInterceptor", AccessFlags = 1537)]
		public partial interface IHttpResponseInterceptor
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Processes a response. On the server side, this step is performed before the response is sent to the client. On the client side, this step is performed on incoming messages before the message body is evaluated.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// process
				/// </java-name>
				[Dot42.DexImport("process", "(Lorg/apache/http/HttpResponse;Lorg/apache/http/protocol/HttpContext;)V", AccessFlags = 1025)]
				void Process(global::Org.Apache.Http.IHttpResponse response, global::Org.Apache.Http.Protocol.IHttpContext context) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>An entity that can be sent or received with an HTTP message. Entities can be found in some requests and in responses, where they are optional. </para><para>In some places, the JavaDoc distinguishes three kinds of entities, depending on where their content originates: <ul><li><para><b>streamed</b>: The content is received from a stream, or generated on the fly. In particular, this category includes entities being received from a connection. Streamed entities are generally not repeatable.  </para></li><li><para><b>self-contained</b>: The content is in memory or obtained by means that are independent from a connection or other entity. Self-contained entities are generally repeatable.  </para></li><li><para><b>wrapping</b>: The content is obtained from another entity.  </para></li></ul>This distinction is important for connection management with incoming entities. For entities that are created by an application and only sent using the HTTP components framework, the difference between streamed and self-contained is of little importance. In that case, it is suggested to consider non-repeatable entities as streamed, and those that are repeatable (without a huge effort) as self-contained.</para><para><para></para><para></para><title>Revision:</title><para>645824 </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/HttpEntity
		/// </java-name>
		[Dot42.DexImport("org/apache/http/HttpEntity", AccessFlags = 1537)]
		public partial interface IHttpEntity
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Tells if the entity is capable to produce its data more than once. A repeatable entity's getContent() and writeTo(OutputStream) methods can be called more than once whereas a non-repeatable entity's can not. </para>        
				/// </summary>
				/// <returns>
				/// <para>true if the entity is repeatable, false otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isRepeatable
				/// </java-name>
				[Dot42.DexImport("isRepeatable", "()Z", AccessFlags = 1025)]
				bool IsRepeatable() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Tells about chunked encoding for this entity. The primary purpose of this method is to indicate whether chunked encoding should be used when the entity is sent. For entities that are received, it can also indicate whether the entity was received with chunked encoding. <br></br> The behavior of wrapping entities is implementation dependent, but should respect the primary purpose.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> if chunked encoding is preferred for this entity, or <code>false</code> if it is not </para>
				/// </returns>
				/// <java-name>
				/// isChunked
				/// </java-name>
				[Dot42.DexImport("isChunked", "()Z", AccessFlags = 1025)]
				bool IsChunked() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Tells the length of the content, if known.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of bytes of the content, or a negative number if unknown. If the content length is known but exceeds Long.MAX_VALUE, a negative number is returned. </para>
				/// </returns>
				/// <java-name>
				/// getContentLength
				/// </java-name>
				[Dot42.DexImport("getContentLength", "()J", AccessFlags = 1025)]
				long GetContentLength() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Obtains the Content-Type header, if known. This is the header that should be used when sending the entity, or the one that was received with the entity. It can include a charset attribute.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the Content-Type header for this entity, or <code>null</code> if the content type is unknown </para>
				/// </returns>
				/// <java-name>
				/// getContentType
				/// </java-name>
				[Dot42.DexImport("getContentType", "()Lorg/apache/http/Header;", AccessFlags = 1025)]
				global::Org.Apache.Http.IHeader GetContentType() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Obtains the Content-Encoding header, if known. This is the header that should be used when sending the entity, or the one that was received with the entity. Wrapping entities that modify the content encoding should adjust this header accordingly.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the Content-Encoding header for this entity, or <code>null</code> if the content encoding is unknown </para>
				/// </returns>
				/// <java-name>
				/// getContentEncoding
				/// </java-name>
				[Dot42.DexImport("getContentEncoding", "()Lorg/apache/http/Header;", AccessFlags = 1025)]
				global::Org.Apache.Http.IHeader GetContentEncoding() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Creates a new InputStream object of the entity. It is a programming error to return the same InputStream object more than once. Entities that are not repeatable will throw an exception if this method is called multiple times.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a new input stream that returns the entity data.</para>
				/// </returns>
				/// <java-name>
				/// getContent
				/// </java-name>
				[Dot42.DexImport("getContent", "()Ljava/io/InputStream;", AccessFlags = 1025)]
				global::Java.Io.InputStream GetContent() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Writes the entity content to the output stream.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// writeTo
				/// </java-name>
				[Dot42.DexImport("writeTo", "(Ljava/io/OutputStream;)V", AccessFlags = 1025)]
				void WriteTo(global::Java.Io.OutputStream outstream) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Tells whether this entity depends on an underlying stream. Streamed entities should return <code>true</code> until the content has been consumed, <code>false</code> afterwards. Self-contained entities should return <code>false</code>. Wrapping entities should delegate this call to the wrapped entity. <br></br> The content of a streamed entity is consumed when the stream returned by getContent has been read to EOF, or after consumeContent has been called. If a streamed entity can not detect whether the stream has been read to EOF, it should return <code>true</code> until consumeContent is called.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> if the entity content is streamed and not yet consumed, <code>false</code> otherwise </para>
				/// </returns>
				/// <java-name>
				/// isStreaming
				/// </java-name>
				[Dot42.DexImport("isStreaming", "()Z", AccessFlags = 1025)]
				bool IsStreaming() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>TODO: The name of this method is misnomer. It will be renamed to #finish() in the next major release. <br></br> This method is called to indicate that the content of this entity is no longer required. All entity implementations are expected to release all allocated resources as a result of this method invocation. Content streaming entities are also expected to dispose of the remaining content, if any. Wrapping entities should delegate this call to the wrapped entity. <br></br> This method is of particular importance for entities being received from a connection. The entity needs to be consumed completely in order to re-use the connection with keep-alive.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// consumeContent
				/// </java-name>
				[Dot42.DexImport("consumeContent", "()V", AccessFlags = 1025)]
				void ConsumeContent() /* MethodBuilder.Create */ ;

		}

}


