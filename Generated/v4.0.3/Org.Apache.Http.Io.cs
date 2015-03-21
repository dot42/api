#pragma warning disable 1717
namespace Org.Apache.Http.Io
{
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
				void Write(global::Org.Apache.Http.IHttpMessage httpMessage) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// org/apache/http/io/HttpTransportMetrics
		/// </java-name>
		[Dot42.DexImport("org/apache/http/io/HttpTransportMetrics", AccessFlags = 1537)]
		public partial interface IHttpTransportMetrics
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// getBytesTransferred
				/// </java-name>
				[Dot42.DexImport("getBytesTransferred", "()J", AccessFlags = 1025)]
				long GetBytesTransferred() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// reset
				/// </java-name>
				[Dot42.DexImport("reset", "()V", AccessFlags = 1025)]
				void Reset() /* MethodBuilder.Create */ ;

		}

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
				int Read(sbyte[] sByte, int int32, int int321) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([B)I", AccessFlags = 1025)]
				int Read(sbyte[] sByte) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "()I", AccessFlags = 1025)]
				int Read() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// readLine
				/// </java-name>
				[Dot42.DexImport("readLine", "(Lorg/apache/http/util/CharArrayBuffer;)I", AccessFlags = 1025)]
				int ReadLine(global::Org.Apache.Http.Util.CharArrayBuffer charArrayBuffer) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// readLine
				/// </java-name>
				[Dot42.DexImport("readLine", "()Ljava/lang/String;", AccessFlags = 1025)]
				string ReadLine() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// isDataAvailable
				/// </java-name>
				[Dot42.DexImport("isDataAvailable", "(I)Z", AccessFlags = 1025)]
				bool IsDataAvailable(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getMetrics
				/// </java-name>
				[Dot42.DexImport("getMetrics", "()Lorg/apache/http/io/HttpTransportMetrics;", AccessFlags = 1025)]
				global::Org.Apache.Http.Io.IHttpTransportMetrics GetMetrics() /* MethodBuilder.Create */ ;

		}

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
				void Write(sbyte[] sByte, int int32, int int321) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([B)V", AccessFlags = 1025)]
				void Write(sbyte[] sByte) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "(I)V", AccessFlags = 1025)]
				void Write(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// writeLine
				/// </java-name>
				[Dot42.DexImport("writeLine", "(Ljava/lang/String;)V", AccessFlags = 1025)]
				void WriteLine(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// writeLine
				/// </java-name>
				[Dot42.DexImport("writeLine", "(Lorg/apache/http/util/CharArrayBuffer;)V", AccessFlags = 1025)]
				void WriteLine(global::Org.Apache.Http.Util.CharArrayBuffer charArrayBuffer) /* MethodBuilder.Create */ ;

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

}

