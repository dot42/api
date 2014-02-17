// Copyright (C) 2014 dot42
//
// Original filename: Org.Apache.Http.Io.cs
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
namespace Org.Apache.Http.Io
{
		/// <summary>
		/// <para>Generic message writer interface.</para><para><para></para><para></para><title>Revision:</title><para>567370 </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/io/HttpMessageWriter
		/// </java-name>
		[Dot42.DexImport("org/apache/http/io/HttpMessageWriter", AccessFlags = 1537)]
		public partial interface IHttpMessageWriter
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "(Lorg/apache/http/HttpMessage;)V", AccessFlags = 1025)]
				void Write(global::Org.Apache.Http.IHttpMessage message) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>Session output buffer for blocking connections.</para><para><para></para><para></para><title>Revision:</title><para>560528 </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/io/SessionOutputBuffer
		/// </java-name>
		[Dot42.DexImport("org/apache/http/io/SessionOutputBuffer", AccessFlags = 1537)]
		public partial interface ISessionOutputBuffer
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([BII)V", AccessFlags = 1025)]
				void Write(sbyte[] b, int off, int len) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([B)V", AccessFlags = 1025)]
				void Write(sbyte[] b) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "(I)V", AccessFlags = 1025)]
				void Write(int b) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// writeLine
				/// </java-name>
				[Dot42.DexImport("writeLine", "(Ljava/lang/String;)V", AccessFlags = 1025)]
				void WriteLine(string buffer) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// writeLine
				/// </java-name>
				[Dot42.DexImport("writeLine", "(Lorg/apache/http/util/CharArrayBuffer;)V", AccessFlags = 1025)]
				void WriteLine(global::Org.Apache.Http.Util.CharArrayBuffer buffer) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// flush
				/// </java-name>
				[Dot42.DexImport("flush", "()V", AccessFlags = 1025)]
				void Flush() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getMetrics
				/// </java-name>
				[Dot42.DexImport("getMetrics", "()Lorg/apache/http/io/HttpTransportMetrics;", AccessFlags = 1025)]
				global::Org.Apache.Http.Io.IHttpTransportMetrics GetMetrics() /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// org/apache/http/io/HttpTransportMetrics
		/// </java-name>
		[Dot42.DexImport("org/apache/http/io/HttpTransportMetrics", AccessFlags = 1537)]
		public partial interface IHttpTransportMetrics
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Returns the number of bytes trasferred. </para>        
				/// </summary>
				/// <java-name>
				/// getBytesTransferred
				/// </java-name>
				[Dot42.DexImport("getBytesTransferred", "()J", AccessFlags = 1025)]
				long GetBytesTransferred() /* MethodBuilder.Create */ ;

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
		/// <para>Generic message parser interface.</para><para><para></para><para></para><title>Revision:</title><para>567370 </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/io/HttpMessageParser
		/// </java-name>
		[Dot42.DexImport("org/apache/http/io/HttpMessageParser", AccessFlags = 1537)]
		public partial interface IHttpMessageParser
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// parse
				/// </java-name>
				[Dot42.DexImport("parse", "()Lorg/apache/http/HttpMessage;", AccessFlags = 1025)]
				global::Org.Apache.Http.IHttpMessage Parse() /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>Session input buffer for blocking connections.</para><para><para></para><para></para><title>Revision:</title><para>560528 </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/io/SessionInputBuffer
		/// </java-name>
		[Dot42.DexImport("org/apache/http/io/SessionInputBuffer", AccessFlags = 1537)]
		public partial interface ISessionInputBuffer
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([BII)I", AccessFlags = 1025)]
				int Read(sbyte[] b, int off, int len) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([B)I", AccessFlags = 1025)]
				int Read(sbyte[] b) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "()I", AccessFlags = 1025)]
				int Read() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// readLine
				/// </java-name>
				[Dot42.DexImport("readLine", "(Lorg/apache/http/util/CharArrayBuffer;)I", AccessFlags = 1025)]
				int ReadLine(global::Org.Apache.Http.Util.CharArrayBuffer buffer) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// readLine
				/// </java-name>
				[Dot42.DexImport("readLine", "()Ljava/lang/String;", AccessFlags = 1025)]
				string ReadLine() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// isDataAvailable
				/// </java-name>
				[Dot42.DexImport("isDataAvailable", "(I)Z", AccessFlags = 1025)]
				bool IsDataAvailable(int timeout) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getMetrics
				/// </java-name>
				[Dot42.DexImport("getMetrics", "()Lorg/apache/http/io/HttpTransportMetrics;", AccessFlags = 1025)]
				global::Org.Apache.Http.Io.IHttpTransportMetrics GetMetrics() /* MethodBuilder.Create */ ;

		}

}


