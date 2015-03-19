#pragma warning disable 1717
namespace Java.Nio.Charset.Spi
{
		/// <java-name>
		/// java/nio/charset/spi/CharsetProvider
		/// </java-name>
		[Dot42.DexImport("java/nio/charset/spi/CharsetProvider", AccessFlags = 1057)]
		public abstract partial class CharsetProvider
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal CharsetProvider() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// charsets
				/// </java-name>
				[Dot42.DexImport("charsets", "()Ljava/util/Iterator;", AccessFlags = 1025, Signature = "()Ljava/util/Iterator<Ljava/nio/charset/Charset;>;")]
				public abstract global::Java.Util.IIterator<global::Java.Nio.Charset.Charset> Charsets() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// charsetForName
				/// </java-name>
				[Dot42.DexImport("charsetForName", "(Ljava/lang/String;)Ljava/nio/charset/Charset;", AccessFlags = 1025)]
				public abstract global::Java.Nio.Charset.Charset CharsetForName(string @string) /* MethodBuilder.Create */ ;

		}

}

