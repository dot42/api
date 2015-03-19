#pragma warning disable 1717
namespace Javax.Xml.Namespace
{
		/// <java-name>
		/// javax/xml/namespace/NamespaceContext
		/// </java-name>
		[Dot42.DexImport("javax/xml/namespace/NamespaceContext", AccessFlags = 1537)]
		public partial interface INamespaceContext
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// getNamespaceURI
				/// </java-name>
				[Dot42.DexImport("getNamespaceURI", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1025)]
				string GetNamespaceURI(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getPrefix
				/// </java-name>
				[Dot42.DexImport("getPrefix", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1025)]
				string GetPrefix(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getPrefixes
				/// </java-name>
				[Dot42.DexImport("getPrefixes", "(Ljava/lang/String;)Ljava/util/Iterator;", AccessFlags = 1025)]
				global::Java.Util.IIterator<object> GetPrefixes(string @string) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// javax/xml/namespace/QName
		/// </java-name>
		[Dot42.DexImport("javax/xml/namespace/QName", AccessFlags = 33)]
		public partial class QName : global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public QName(string @string, string string1) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public QName(string @string, string string1, string string2) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public QName(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getNamespaceURI
				/// </java-name>
				[Dot42.DexImport("getNamespaceURI", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetNamespaceURI() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getLocalPart
				/// </java-name>
				[Dot42.DexImport("getLocalPart", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetLocalPart() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getPrefix
				/// </java-name>
				[Dot42.DexImport("getPrefix", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetPrefix() /* MethodBuilder.Create */ 
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
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// valueOf
				/// </java-name>
				[Dot42.DexImport("valueOf", "(Ljava/lang/String;)Ljavax/xml/namespace/QName;", AccessFlags = 9)]
				public static global::Javax.Xml.Namespace.QName ValueOf(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Xml.Namespace.QName);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal QName() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getNamespaceURI
				/// </java-name>
				public string NamespaceURI
				{
				[Dot42.DexImport("getNamespaceURI", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetNamespaceURI(); }
				}

				/// <java-name>
				/// getLocalPart
				/// </java-name>
				public string LocalPart
				{
				[Dot42.DexImport("getLocalPart", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetLocalPart(); }
				}

				/// <java-name>
				/// getPrefix
				/// </java-name>
				public string Prefix
				{
				[Dot42.DexImport("getPrefix", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetPrefix(); }
				}

		}

}

