#pragma warning disable 1717
namespace Org.Xml.Sax.Ext
{
		/// <java-name>
		/// org/xml/sax/ext/Attributes2Impl
		/// </java-name>
		[Dot42.DexImport("org/xml/sax/ext/Attributes2Impl", AccessFlags = 33)]
		public partial class Attributes2Impl : global::Org.Xml.Sax.Helpers.AttributesImpl, global::Org.Xml.Sax.Ext.IAttributes2
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Attributes2Impl() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Lorg/xml/sax/Attributes;)V", AccessFlags = 1)]
				public Attributes2Impl(global::Org.Xml.Sax.IAttributes attributes) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isDeclared
				/// </java-name>
				[Dot42.DexImport("isDeclared", "(I)Z", AccessFlags = 1)]
				public virtual bool IsDeclared(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isDeclared
				/// </java-name>
				[Dot42.DexImport("isDeclared", "(Ljava/lang/String;Ljava/lang/String;)Z", AccessFlags = 1)]
				public virtual bool IsDeclared(string @string, string string1) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isDeclared
				/// </java-name>
				[Dot42.DexImport("isDeclared", "(Ljava/lang/String;)Z", AccessFlags = 1)]
				public virtual bool IsDeclared(string @string) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isSpecified
				/// </java-name>
				[Dot42.DexImport("isSpecified", "(I)Z", AccessFlags = 1)]
				public virtual bool IsSpecified(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isSpecified
				/// </java-name>
				[Dot42.DexImport("isSpecified", "(Ljava/lang/String;Ljava/lang/String;)Z", AccessFlags = 1)]
				public virtual bool IsSpecified(string @string, string string1) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isSpecified
				/// </java-name>
				[Dot42.DexImport("isSpecified", "(Ljava/lang/String;)Z", AccessFlags = 1)]
				public virtual bool IsSpecified(string @string) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setAttributes
				/// </java-name>
				[Dot42.DexImport("setAttributes", "(Lorg/xml/sax/Attributes;)V", AccessFlags = 1)]
				public override void SetAttributes(global::Org.Xml.Sax.IAttributes attributes) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addAttribute
				/// </java-name>
				[Dot42.DexImport("addAttribute", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/la" +
    "ng/String;)V", AccessFlags = 1)]
				public override void AddAttribute(string @string, string string1, string string2, string string3, string string4) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// removeAttribute
				/// </java-name>
				[Dot42.DexImport("removeAttribute", "(I)V", AccessFlags = 1)]
				public override void RemoveAttribute(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setDeclared
				/// </java-name>
				[Dot42.DexImport("setDeclared", "(IZ)V", AccessFlags = 1)]
				public virtual void SetDeclared(int int32, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setSpecified
				/// </java-name>
				[Dot42.DexImport("setSpecified", "(IZ)V", AccessFlags = 1)]
				public virtual void SetSpecified(int int32, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("org/xml/sax/Attributes", "getURI", "(I)Ljava/lang/String;", AccessFlags = 1025)]
				public override string GetURI(int int32) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(string);
				}

				[Dot42.DexImport("org/xml/sax/Attributes", "getLocalName", "(I)Ljava/lang/String;", AccessFlags = 1025)]
				public override string GetLocalName(int int32) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(string);
				}

				[Dot42.DexImport("org/xml/sax/Attributes", "getQName", "(I)Ljava/lang/String;", AccessFlags = 1025)]
				public override string GetQName(int int32) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(string);
				}

				[Dot42.DexImport("org/xml/sax/Attributes", "getType", "(I)Ljava/lang/String;", AccessFlags = 1025)]
				public override string GetType(int int32) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(string);
				}

				[Dot42.DexImport("org/xml/sax/Attributes", "getValue", "(I)Ljava/lang/String;", AccessFlags = 1025)]
				public override string GetValue(int int32) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(string);
				}

				[Dot42.DexImport("org/xml/sax/Attributes", "getIndex", "(Ljava/lang/String;Ljava/lang/String;)I", AccessFlags = 1025)]
				public override int GetIndex(string @string, string string1) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(int);
				}

				[Dot42.DexImport("org/xml/sax/Attributes", "getIndex", "(Ljava/lang/String;)I", AccessFlags = 1025)]
				public override int GetIndex(string @string) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(int);
				}

				[Dot42.DexImport("org/xml/sax/Attributes", "getType", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1025)]
				public override string GetType(string @string, string string1) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(string);
				}

				[Dot42.DexImport("org/xml/sax/Attributes", "getType", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1025)]
				public override string GetType(string @string) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(string);
				}

				[Dot42.DexImport("org/xml/sax/Attributes", "getValue", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1025)]
				public override string GetValue(string @string, string string1) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(string);
				}

				[Dot42.DexImport("org/xml/sax/Attributes", "getValue", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1025)]
				public override string GetValue(string @string) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(string);
				}

				public override int Length
				{
						[Dot42.DexImport("org/xml/sax/Attributes", "getLength", "()I", AccessFlags = 1025)]
						get{ return default(int); }
				}

		}

		/// <java-name>
		/// org/xml/sax/ext/DefaultHandler2
		/// </java-name>
		[Dot42.DexImport("org/xml/sax/ext/DefaultHandler2", AccessFlags = 33)]
		public partial class DefaultHandler2 : global::Org.Xml.Sax.Helpers.DefaultHandler, global::Org.Xml.Sax.Ext.ILexicalHandler, global::Org.Xml.Sax.Ext.IDeclHandler, global::Org.Xml.Sax.Ext.IEntityResolver2
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public DefaultHandler2() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// startCDATA
				/// </java-name>
				[Dot42.DexImport("startCDATA", "()V", AccessFlags = 1)]
				public virtual void StartCDATA() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// endCDATA
				/// </java-name>
				[Dot42.DexImport("endCDATA", "()V", AccessFlags = 1)]
				public virtual void EndCDATA() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// startDTD
				/// </java-name>
				[Dot42.DexImport("startDTD", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void StartDTD(string @string, string string1, string string2) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// endDTD
				/// </java-name>
				[Dot42.DexImport("endDTD", "()V", AccessFlags = 1)]
				public virtual void EndDTD() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// startEntity
				/// </java-name>
				[Dot42.DexImport("startEntity", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void StartEntity(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// endEntity
				/// </java-name>
				[Dot42.DexImport("endEntity", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void EndEntity(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// comment
				/// </java-name>
				[Dot42.DexImport("comment", "([CII)V", AccessFlags = 1)]
				public virtual void Comment(char[] @char, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// attributeDecl
				/// </java-name>
				[Dot42.DexImport("attributeDecl", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/la" +
    "ng/String;)V", AccessFlags = 1)]
				public virtual void AttributeDecl(string @string, string string1, string string2, string string3, string string4) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// elementDecl
				/// </java-name>
				[Dot42.DexImport("elementDecl", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void ElementDecl(string @string, string string1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// externalEntityDecl
				/// </java-name>
				[Dot42.DexImport("externalEntityDecl", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void ExternalEntityDecl(string @string, string string1, string string2) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// internalEntityDecl
				/// </java-name>
				[Dot42.DexImport("internalEntityDecl", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void InternalEntityDecl(string @string, string string1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getExternalSubset
				/// </java-name>
				[Dot42.DexImport("getExternalSubset", "(Ljava/lang/String;Ljava/lang/String;)Lorg/xml/sax/InputSource;", AccessFlags = 1)]
				public virtual global::Org.Xml.Sax.InputSource GetExternalSubset(string @string, string string1) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Xml.Sax.InputSource);
				}

				/// <java-name>
				/// resolveEntity
				/// </java-name>
				[Dot42.DexImport("resolveEntity", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lorg/xm" +
    "l/sax/InputSource;", AccessFlags = 1)]
				public virtual global::Org.Xml.Sax.InputSource ResolveEntity(string @string, string string1, string string2, string string3) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Xml.Sax.InputSource);
				}

				/// <java-name>
				/// resolveEntity
				/// </java-name>
				[Dot42.DexImport("resolveEntity", "(Ljava/lang/String;Ljava/lang/String;)Lorg/xml/sax/InputSource;", AccessFlags = 1)]
				public override global::Org.Xml.Sax.InputSource ResolveEntity(string @string, string string1) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Xml.Sax.InputSource);
				}

		}

		/// <java-name>
		/// org/xml/sax/ext/Attributes2
		/// </java-name>
		[Dot42.DexImport("org/xml/sax/ext/Attributes2", AccessFlags = 1537)]
		public partial interface IAttributes2 : global::Org.Xml.Sax.IAttributes
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// isDeclared
				/// </java-name>
				[Dot42.DexImport("isDeclared", "(I)Z", AccessFlags = 1025)]
				bool IsDeclared(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// isDeclared
				/// </java-name>
				[Dot42.DexImport("isDeclared", "(Ljava/lang/String;)Z", AccessFlags = 1025)]
				bool IsDeclared(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// isDeclared
				/// </java-name>
				[Dot42.DexImport("isDeclared", "(Ljava/lang/String;Ljava/lang/String;)Z", AccessFlags = 1025)]
				bool IsDeclared(string @string, string string1) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// isSpecified
				/// </java-name>
				[Dot42.DexImport("isSpecified", "(I)Z", AccessFlags = 1025)]
				bool IsSpecified(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// isSpecified
				/// </java-name>
				[Dot42.DexImport("isSpecified", "(Ljava/lang/String;Ljava/lang/String;)Z", AccessFlags = 1025)]
				bool IsSpecified(string @string, string string1) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// isSpecified
				/// </java-name>
				[Dot42.DexImport("isSpecified", "(Ljava/lang/String;)Z", AccessFlags = 1025)]
				bool IsSpecified(string @string) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// org/xml/sax/ext/DeclHandler
		/// </java-name>
		[Dot42.DexImport("org/xml/sax/ext/DeclHandler", AccessFlags = 1537)]
		public partial interface IDeclHandler
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// elementDecl
				/// </java-name>
				[Dot42.DexImport("elementDecl", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1025)]
				void ElementDecl(string @string, string string1) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// attributeDecl
				/// </java-name>
				[Dot42.DexImport("attributeDecl", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/la" +
    "ng/String;)V", AccessFlags = 1025)]
				void AttributeDecl(string @string, string string1, string string2, string string3, string string4) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// internalEntityDecl
				/// </java-name>
				[Dot42.DexImport("internalEntityDecl", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1025)]
				void InternalEntityDecl(string @string, string string1) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// externalEntityDecl
				/// </java-name>
				[Dot42.DexImport("externalEntityDecl", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1025)]
				void ExternalEntityDecl(string @string, string string1, string string2) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// org/xml/sax/ext/EntityResolver2
		/// </java-name>
		[Dot42.DexImport("org/xml/sax/ext/EntityResolver2", AccessFlags = 1537)]
		public partial interface IEntityResolver2 : global::Org.Xml.Sax.IEntityResolver
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// getExternalSubset
				/// </java-name>
				[Dot42.DexImport("getExternalSubset", "(Ljava/lang/String;Ljava/lang/String;)Lorg/xml/sax/InputSource;", AccessFlags = 1025)]
				global::Org.Xml.Sax.InputSource GetExternalSubset(string @string, string string1) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// resolveEntity
				/// </java-name>
				[Dot42.DexImport("resolveEntity", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lorg/xm" +
    "l/sax/InputSource;", AccessFlags = 1025)]
				global::Org.Xml.Sax.InputSource ResolveEntity(string @string, string string1, string string2, string string3) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// org/xml/sax/ext/LexicalHandler
		/// </java-name>
		[Dot42.DexImport("org/xml/sax/ext/LexicalHandler", AccessFlags = 1537)]
		public partial interface ILexicalHandler
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// startDTD
				/// </java-name>
				[Dot42.DexImport("startDTD", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1025)]
				void StartDTD(string @string, string string1, string string2) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// endDTD
				/// </java-name>
				[Dot42.DexImport("endDTD", "()V", AccessFlags = 1025)]
				void EndDTD() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// startEntity
				/// </java-name>
				[Dot42.DexImport("startEntity", "(Ljava/lang/String;)V", AccessFlags = 1025)]
				void StartEntity(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// endEntity
				/// </java-name>
				[Dot42.DexImport("endEntity", "(Ljava/lang/String;)V", AccessFlags = 1025)]
				void EndEntity(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// startCDATA
				/// </java-name>
				[Dot42.DexImport("startCDATA", "()V", AccessFlags = 1025)]
				void StartCDATA() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// endCDATA
				/// </java-name>
				[Dot42.DexImport("endCDATA", "()V", AccessFlags = 1025)]
				void EndCDATA() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// comment
				/// </java-name>
				[Dot42.DexImport("comment", "([CII)V", AccessFlags = 1025)]
				void Comment(char[] @char, int int32, int int321) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// org/xml/sax/ext/Locator2
		/// </java-name>
		[Dot42.DexImport("org/xml/sax/ext/Locator2", AccessFlags = 1537)]
		public partial interface ILocator2 : global::Org.Xml.Sax.ILocator
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// getXMLVersion
				/// </java-name>
				string XMLVersion
				{
						[Dot42.DexImport("getXMLVersion", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getEncoding
				/// </java-name>
				string Encoding
				{
						[Dot42.DexImport("getEncoding", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

		}

		/// <java-name>
		/// org/xml/sax/ext/Locator2Impl
		/// </java-name>
		[Dot42.DexImport("org/xml/sax/ext/Locator2Impl", AccessFlags = 33)]
		public partial class Locator2Impl : global::Org.Xml.Sax.Helpers.LocatorImpl, global::Org.Xml.Sax.Ext.ILocator2
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Locator2Impl() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Lorg/xml/sax/Locator;)V", AccessFlags = 1)]
				public Locator2Impl(global::Org.Xml.Sax.ILocator locator) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setXMLVersion
				/// </java-name>
				[Dot42.DexImport("setXMLVersion", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetXMLVersion(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setEncoding
				/// </java-name>
				[Dot42.DexImport("setEncoding", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetEncoding(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getXMLVersion
				/// </java-name>
				public virtual string XMLVersion
				{
						[Dot42.DexImport("getXMLVersion", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getEncoding
				/// </java-name>
				public virtual string Encoding
				{
						[Dot42.DexImport("getEncoding", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				public override string PublicId
				{
						[Dot42.DexImport("org/xml/sax/Locator", "getPublicId", "()Ljava/lang/String;", AccessFlags = 1025)]
						get{ return default(string); }
				}

				public override string SystemId
				{
						[Dot42.DexImport("org/xml/sax/Locator", "getSystemId", "()Ljava/lang/String;", AccessFlags = 1025)]
						get{ return default(string); }
				}

				public override int LineNumber
				{
						[Dot42.DexImport("org/xml/sax/Locator", "getLineNumber", "()I", AccessFlags = 1025)]
						get{ return default(int); }
				}

				public override int ColumnNumber
				{
						[Dot42.DexImport("org/xml/sax/Locator", "getColumnNumber", "()I", AccessFlags = 1025)]
						get{ return default(int); }
				}

		}

}

