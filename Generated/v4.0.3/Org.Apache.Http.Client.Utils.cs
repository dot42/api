#pragma warning disable 1717
namespace Org.Apache.Http.Client.Utils
{
		/// <java-name>
		/// org/apache/http/client/utils/URIUtils
		/// </java-name>
		[Dot42.DexImport("org/apache/http/client/utils/URIUtils", AccessFlags = 33)]
		public partial class URIUtils
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal URIUtils() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// createURI
				/// </java-name>
				[Dot42.DexImport("createURI", "(Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;Ljava/l" +
    "ang/String;)Ljava/net/URI;", AccessFlags = 9)]
				public static global::System.Uri CreateURI(string @string, string string1, int int32, string string2, string string3, string string4) /* MethodBuilder.Create */ 
				{
						return default(global::System.Uri);
				}

				/// <java-name>
				/// rewriteURI
				/// </java-name>
				[Dot42.DexImport("rewriteURI", "(Ljava/net/URI;Lorg/apache/http/HttpHost;Z)Ljava/net/URI;", AccessFlags = 9)]
				public static global::System.Uri RewriteURI(global::System.Uri uri, global::Org.Apache.Http.HttpHost httpHost, bool boolean) /* MethodBuilder.Create */ 
				{
						return default(global::System.Uri);
				}

				/// <java-name>
				/// rewriteURI
				/// </java-name>
				[Dot42.DexImport("rewriteURI", "(Ljava/net/URI;Lorg/apache/http/HttpHost;)Ljava/net/URI;", AccessFlags = 9)]
				public static global::System.Uri RewriteURI(global::System.Uri uri, global::Org.Apache.Http.HttpHost httpHost) /* MethodBuilder.Create */ 
				{
						return default(global::System.Uri);
				}

				/// <java-name>
				/// resolve
				/// </java-name>
				[Dot42.DexImport("resolve", "(Ljava/net/URI;Ljava/lang/String;)Ljava/net/URI;", AccessFlags = 9)]
				public static global::System.Uri Resolve(global::System.Uri uri, string @string) /* MethodBuilder.Create */ 
				{
						return default(global::System.Uri);
				}

				/// <java-name>
				/// resolve
				/// </java-name>
				[Dot42.DexImport("resolve", "(Ljava/net/URI;Ljava/net/URI;)Ljava/net/URI;", AccessFlags = 9)]
				public static global::System.Uri Resolve(global::System.Uri uri, global::System.Uri uri1) /* MethodBuilder.Create */ 
				{
						return default(global::System.Uri);
				}

		}

		/// <java-name>
		/// org/apache/http/client/utils/CloneUtils
		/// </java-name>
		[Dot42.DexImport("org/apache/http/client/utils/CloneUtils", AccessFlags = 33)]
		public partial class CloneUtils
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal CloneUtils() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "(Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 9)]
				public static object Clone(object @object) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

		}

		/// <java-name>
		/// org/apache/http/client/utils/URLEncodedUtils
		/// </java-name>
		[Dot42.DexImport("org/apache/http/client/utils/URLEncodedUtils", AccessFlags = 33)]
		public partial class URLEncodedUtils
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// CONTENT_TYPE
				/// </java-name>
				[Dot42.DexImport("CONTENT_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string CONTENT_TYPE = "application/x-www-form-urlencoded";
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public URLEncodedUtils() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// parse
				/// </java-name>
				[Dot42.DexImport("parse", "(Ljava/net/URI;Ljava/lang/String;)Ljava/util/List;", AccessFlags = 9, Signature = "(Ljava/net/URI;Ljava/lang/String;)Ljava/util/List<Lorg/apache/http/NameValuePair;" +
    ">;")]
				public static global::Java.Util.IList<global::Org.Apache.Http.INameValuePair> Parse(global::System.Uri uri, string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<global::Org.Apache.Http.INameValuePair>);
				}

				/// <java-name>
				/// parse
				/// </java-name>
				[Dot42.DexImport("parse", "(Lorg/apache/http/HttpEntity;)Ljava/util/List;", AccessFlags = 9, Signature = "(Lorg/apache/http/HttpEntity;)Ljava/util/List<Lorg/apache/http/NameValuePair;>;")]
				public static global::Java.Util.IList<global::Org.Apache.Http.INameValuePair> Parse(global::Org.Apache.Http.IHttpEntity httpEntity) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<global::Org.Apache.Http.INameValuePair>);
				}

				/// <java-name>
				/// isEncoded
				/// </java-name>
				[Dot42.DexImport("isEncoded", "(Lorg/apache/http/HttpEntity;)Z", AccessFlags = 9)]
				public static bool IsEncoded(global::Org.Apache.Http.IHttpEntity httpEntity) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// parse
				/// </java-name>
				[Dot42.DexImport("parse", "(Ljava/util/List;Ljava/util/Scanner;Ljava/lang/String;)V", AccessFlags = 9, Signature = "(Ljava/util/List<Lorg/apache/http/NameValuePair;>;Ljava/util/Scanner;Ljava/lang/S" +
    "tring;)V")]
				public static void Parse(global::Java.Util.IList<global::Org.Apache.Http.INameValuePair> list, global::Java.Util.Scanner scanner, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// format
				/// </java-name>
				[Dot42.DexImport("format", "(Ljava/util/List;Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 9, Signature = "(Ljava/util/List<+Lorg/apache/http/NameValuePair;>;Ljava/lang/String;)Ljava/lang/" +
    "String;")]
				public static string Format(global::Java.Util.IList<global::Org.Apache.Http.INameValuePair> list, string @string) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

		}

}

