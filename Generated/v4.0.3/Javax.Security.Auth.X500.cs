#pragma warning disable 1717
namespace Javax.Security.Auth.X500
{
		/// <java-name>
		/// javax/security/auth/x500/X500Principal
		/// </java-name>
		[Dot42.DexImport("javax/security/auth/x500/X500Principal", AccessFlags = 49)]
		public sealed partial class X500Principal : global::Java.Io.ISerializable, global::Java.Security.IPrincipal
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// CANONICAL
				/// </java-name>
				[Dot42.DexImport("CANONICAL", "Ljava/lang/String;", AccessFlags = 25)]
				public const string CANONICAL = "CANONICAL";
				/// <java-name>
				/// RFC1779
				/// </java-name>
				[Dot42.DexImport("RFC1779", "Ljava/lang/String;", AccessFlags = 25)]
				public const string RFC1779 = "RFC1779";
				/// <java-name>
				/// RFC2253
				/// </java-name>
				[Dot42.DexImport("RFC2253", "Ljava/lang/String;", AccessFlags = 25)]
				public const string RFC2253 = "RFC2253";
				[Dot42.DexImport("<init>", "([B)V", AccessFlags = 1)]
				public X500Principal(sbyte[] sByte) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "([B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public X500Principal(byte[] @byte) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/io/InputStream;)V", AccessFlags = 1)]
				public X500Principal(global::Java.Io.InputStream inputStream) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public X500Principal(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/util/Map;)V", AccessFlags = 1, Signature = "(Ljava/lang/String;Ljava/util/Map<Ljava/lang/String;Ljava/lang/String;>;)V")]
				public X500Principal(string @string, global::Java.Util.IMap<string, string> map) /* MethodBuilder.Create */ 
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
				/// getEncoded
				/// </java-name>
				[Dot42.DexImport("getEncoded", "()[B", AccessFlags = 1)]
				public sbyte[] JavaGetEncoded() /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <java-name>
				/// getName
				/// </java-name>
				[Dot42.DexImport("getName", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1)]
				public string GetName(string @string) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getName
				/// </java-name>
				[Dot42.DexImport("getName", "(Ljava/lang/String;Ljava/util/Map;)Ljava/lang/String;", AccessFlags = 1, Signature = "(Ljava/lang/String;Ljava/util/Map<Ljava/lang/String;Ljava/lang/String;>;)Ljava/la" +
    "ng/String;")]
				public string GetName(string @string, global::Java.Util.IMap<string, string> map) /* MethodBuilder.Create */ 
				{
						return default(string);
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
				internal X500Principal() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getEncoded
				/// </java-name>
				public byte[] Encoded
				{
						[Dot42.DexImport("getEncoded", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
						get{ return default(byte[]); }
				}

				/// <java-name>
				/// getName
				/// </java-name>
				public string Name
				{
						[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

		}

}

