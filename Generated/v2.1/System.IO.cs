#pragma warning disable 1717
namespace System.IO
{
		/// <summary>
		///  <para>Thrown when a program encounters the end of a file or stream during an input operation. </para>    
		/// </summary>
		/// <java-name>
		/// java/io/EOFException
		/// </java-name>
		[Dot42.DexImport("java/io/EOFException", AccessFlags = 33)]
		public partial class EndOfStreamException : global::System.IO.IOException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructs a new <c>EOFException </c> with its stack trace filled in. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public EndOfStreamException() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new <c>EOFException </c> with its stack trace and detail message filled in.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public EndOfStreamException(string detailMessage) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>Thrown when a file specified by a program cannot be found. </para>    
		/// </summary>
		/// <java-name>
		/// java/io/FileNotFoundException
		/// </java-name>
		[Dot42.DexImport("java/io/FileNotFoundException", AccessFlags = 33)]
		public partial class FileNotFoundException : global::System.IO.IOException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructs a new <c>FileNotFoundException </c> with its stack trace filled in. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public FileNotFoundException() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new <c>FileNotFoundException </c> with its stack trace and detail message filled in.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public FileNotFoundException(string detailMessage) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>Signals a general, I/O-related error. Error details may be specified when calling the constructor, as usual. Note there are also several subclasses of this class for more specific error situations, such as FileNotFoundException or EOFException. </para>    
		/// </summary>
		/// <java-name>
		/// java/io/IOException
		/// </java-name>
		[Dot42.DexImport("java/io/IOException", AccessFlags = 33)]
		public partial class IOException : global::System.Exception
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructs a new <c>IOException </c> with its stack trace filled in. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public IOException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public IOException(string @string) /* MethodBuilder.Create */ 
				{
				}

		}

}

