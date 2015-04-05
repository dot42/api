#pragma warning disable 1717
namespace Org.Xml.Sax.Helpers
{
		/// <java-name>
		/// org/xml/sax/helpers/AttributeListImpl
		/// </java-name>
		[Dot42.DexImport("org/xml/sax/helpers/AttributeListImpl", AccessFlags = 33)]
		public partial class AttributeListImpl : global::Org.Xml.Sax.IAttributeList
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public AttributeListImpl() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Lorg/xml/sax/AttributeList;)V", AccessFlags = 1)]
				public AttributeListImpl(global::Org.Xml.Sax.IAttributeList attributeList) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setAttributeList
				/// </java-name>
				[Dot42.DexImport("setAttributeList", "(Lorg/xml/sax/AttributeList;)V", AccessFlags = 1)]
				public virtual void SetAttributeList(global::Org.Xml.Sax.IAttributeList attributeList) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addAttribute
				/// </java-name>
				[Dot42.DexImport("addAttribute", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void AddAttribute(string @string, string string1, string string2) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// removeAttribute
				/// </java-name>
				[Dot42.DexImport("removeAttribute", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void RemoveAttribute(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// clear
				/// </java-name>
				[Dot42.DexImport("clear", "()V", AccessFlags = 1)]
				public virtual void Clear() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getName
				/// </java-name>
				[Dot42.DexImport("getName", "(I)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetName(int int32) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getType
				/// </java-name>
				[Dot42.DexImport("getType", "(I)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetType(int int32) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getValue
				/// </java-name>
				[Dot42.DexImport("getValue", "(I)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetValue(int int32) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getType
				/// </java-name>
				[Dot42.DexImport("getType", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetType(string @string) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getValue
				/// </java-name>
				[Dot42.DexImport("getValue", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetValue(string @string) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getLength
				/// </java-name>
				public virtual int Length
				{
						[Dot42.DexImport("getLength", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

		}

		/// <java-name>
		/// org/xml/sax/helpers/AttributesImpl
		/// </java-name>
		[Dot42.DexImport("org/xml/sax/helpers/AttributesImpl", AccessFlags = 33)]
		public partial class AttributesImpl : global::Org.Xml.Sax.IAttributes
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public AttributesImpl() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Lorg/xml/sax/Attributes;)V", AccessFlags = 1)]
				public AttributesImpl(global::Org.Xml.Sax.IAttributes attributes) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getURI
				/// </java-name>
				[Dot42.DexImport("getURI", "(I)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetURI(int int32) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getLocalName
				/// </java-name>
				[Dot42.DexImport("getLocalName", "(I)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetLocalName(int int32) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getQName
				/// </java-name>
				[Dot42.DexImport("getQName", "(I)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetQName(int int32) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getType
				/// </java-name>
				[Dot42.DexImport("getType", "(I)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetType(int int32) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getValue
				/// </java-name>
				[Dot42.DexImport("getValue", "(I)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetValue(int int32) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getIndex
				/// </java-name>
				[Dot42.DexImport("getIndex", "(Ljava/lang/String;Ljava/lang/String;)I", AccessFlags = 1)]
				public virtual int GetIndex(string @string, string string1) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getIndex
				/// </java-name>
				[Dot42.DexImport("getIndex", "(Ljava/lang/String;)I", AccessFlags = 1)]
				public virtual int GetIndex(string @string) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getType
				/// </java-name>
				[Dot42.DexImport("getType", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetType(string @string, string string1) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getType
				/// </java-name>
				[Dot42.DexImport("getType", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetType(string @string) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getValue
				/// </java-name>
				[Dot42.DexImport("getValue", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetValue(string @string, string string1) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getValue
				/// </java-name>
				[Dot42.DexImport("getValue", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetValue(string @string) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// clear
				/// </java-name>
				[Dot42.DexImport("clear", "()V", AccessFlags = 1)]
				public virtual void Clear() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setAttributes
				/// </java-name>
				[Dot42.DexImport("setAttributes", "(Lorg/xml/sax/Attributes;)V", AccessFlags = 1)]
				public virtual void SetAttributes(global::Org.Xml.Sax.IAttributes attributes) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addAttribute
				/// </java-name>
				[Dot42.DexImport("addAttribute", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/la" +
    "ng/String;)V", AccessFlags = 1)]
				public virtual void AddAttribute(string @string, string string1, string string2, string string3, string string4) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setAttribute
				/// </java-name>
				[Dot42.DexImport("setAttribute", "(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/l" +
    "ang/String;)V", AccessFlags = 1)]
				public virtual void SetAttribute(int int32, string @string, string string1, string string2, string string3, string string4) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// removeAttribute
				/// </java-name>
				[Dot42.DexImport("removeAttribute", "(I)V", AccessFlags = 1)]
				public virtual void RemoveAttribute(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setURI
				/// </java-name>
				[Dot42.DexImport("setURI", "(ILjava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetURI(int int32, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setLocalName
				/// </java-name>
				[Dot42.DexImport("setLocalName", "(ILjava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetLocalName(int int32, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setQName
				/// </java-name>
				[Dot42.DexImport("setQName", "(ILjava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetQName(int int32, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setType
				/// </java-name>
				[Dot42.DexImport("setType", "(ILjava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetType(int int32, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setValue
				/// </java-name>
				[Dot42.DexImport("setValue", "(ILjava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetValue(int int32, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getLength
				/// </java-name>
				public virtual int Length
				{
						[Dot42.DexImport("getLength", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

		}

		/// <java-name>
		/// org/xml/sax/helpers/DefaultHandler
		/// </java-name>
		[Dot42.DexImport("org/xml/sax/helpers/DefaultHandler", AccessFlags = 33)]
		public partial class DefaultHandler : global::Org.Xml.Sax.IEntityResolver, global::Org.Xml.Sax.IDTDHandler, global::Org.Xml.Sax.IContentHandler, global::Org.Xml.Sax.IErrorHandler
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public DefaultHandler() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// resolveEntity
				/// </java-name>
				[Dot42.DexImport("resolveEntity", "(Ljava/lang/String;Ljava/lang/String;)Lorg/xml/sax/InputSource;", AccessFlags = 1)]
				public virtual global::Org.Xml.Sax.InputSource ResolveEntity(string @string, string string1) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Xml.Sax.InputSource);
				}

				/// <java-name>
				/// notationDecl
				/// </java-name>
				[Dot42.DexImport("notationDecl", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void NotationDecl(string @string, string string1, string string2) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// unparsedEntityDecl
				/// </java-name>
				[Dot42.DexImport("unparsedEntityDecl", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void UnparsedEntityDecl(string @string, string string1, string string2, string string3) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setDocumentLocator
				/// </java-name>
				[Dot42.DexImport("setDocumentLocator", "(Lorg/xml/sax/Locator;)V", AccessFlags = 1)]
				public virtual void SetDocumentLocator(global::Org.Xml.Sax.ILocator locator) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// startDocument
				/// </java-name>
				[Dot42.DexImport("startDocument", "()V", AccessFlags = 1)]
				public virtual void StartDocument() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// endDocument
				/// </java-name>
				[Dot42.DexImport("endDocument", "()V", AccessFlags = 1)]
				public virtual void EndDocument() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// startPrefixMapping
				/// </java-name>
				[Dot42.DexImport("startPrefixMapping", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void StartPrefixMapping(string @string, string string1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// endPrefixMapping
				/// </java-name>
				[Dot42.DexImport("endPrefixMapping", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void EndPrefixMapping(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// startElement
				/// </java-name>
				[Dot42.DexImport("startElement", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lorg/xml/sax/Attributes;)V" +
    "", AccessFlags = 1)]
				public virtual void StartElement(string @string, string string1, string string2, global::Org.Xml.Sax.IAttributes attributes) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// endElement
				/// </java-name>
				[Dot42.DexImport("endElement", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void EndElement(string @string, string string1, string string2) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// characters
				/// </java-name>
				[Dot42.DexImport("characters", "([CII)V", AccessFlags = 1)]
				public virtual void Characters(char[] @char, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// ignorableWhitespace
				/// </java-name>
				[Dot42.DexImport("ignorableWhitespace", "([CII)V", AccessFlags = 1)]
				public virtual void IgnorableWhitespace(char[] @char, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// processingInstruction
				/// </java-name>
				[Dot42.DexImport("processingInstruction", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void ProcessingInstruction(string @string, string string1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// skippedEntity
				/// </java-name>
				[Dot42.DexImport("skippedEntity", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SkippedEntity(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// warning
				/// </java-name>
				[Dot42.DexImport("warning", "(Lorg/xml/sax/SAXParseException;)V", AccessFlags = 1)]
				public virtual void Warning(global::Org.Xml.Sax.SAXParseException sAXParseException) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// error
				/// </java-name>
				[Dot42.DexImport("error", "(Lorg/xml/sax/SAXParseException;)V", AccessFlags = 1)]
				public virtual void Error(global::Org.Xml.Sax.SAXParseException sAXParseException) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// fatalError
				/// </java-name>
				[Dot42.DexImport("fatalError", "(Lorg/xml/sax/SAXParseException;)V", AccessFlags = 1)]
				public virtual void FatalError(global::Org.Xml.Sax.SAXParseException sAXParseException) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// org/xml/sax/helpers/LocatorImpl
		/// </java-name>
		[Dot42.DexImport("org/xml/sax/helpers/LocatorImpl", AccessFlags = 33)]
		public partial class LocatorImpl : global::Org.Xml.Sax.ILocator
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public LocatorImpl() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Lorg/xml/sax/Locator;)V", AccessFlags = 1)]
				public LocatorImpl(global::Org.Xml.Sax.ILocator locator) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setPublicId
				/// </java-name>
				[Dot42.DexImport("setPublicId", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetPublicId(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setSystemId
				/// </java-name>
				[Dot42.DexImport("setSystemId", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetSystemId(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setLineNumber
				/// </java-name>
				[Dot42.DexImport("setLineNumber", "(I)V", AccessFlags = 1)]
				public virtual void SetLineNumber(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setColumnNumber
				/// </java-name>
				[Dot42.DexImport("setColumnNumber", "(I)V", AccessFlags = 1)]
				public virtual void SetColumnNumber(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getPublicId
				/// </java-name>
				public virtual string PublicId
				{
						[Dot42.DexImport("getPublicId", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getSystemId
				/// </java-name>
				public virtual string SystemId
				{
						[Dot42.DexImport("getSystemId", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getLineNumber
				/// </java-name>
				public virtual int LineNumber
				{
						[Dot42.DexImport("getLineNumber", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getColumnNumber
				/// </java-name>
				public virtual int ColumnNumber
				{
						[Dot42.DexImport("getColumnNumber", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

		}

		/// <java-name>
		/// org/xml/sax/helpers/NamespaceSupport
		/// </java-name>
		[Dot42.DexImport("org/xml/sax/helpers/NamespaceSupport", AccessFlags = 33)]
		public partial class NamespaceSupport
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// XMLNS
				/// </java-name>
				[Dot42.DexImport("XMLNS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string XMLNS = "http://www.w3.org/XML/1998/namespace";
				/// <java-name>
				/// NSDECL
				/// </java-name>
				[Dot42.DexImport("NSDECL", "Ljava/lang/String;", AccessFlags = 25)]
				public const string NSDECL = "http://www.w3.org/xmlns/2000/";
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public NamespaceSupport() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// reset
				/// </java-name>
				[Dot42.DexImport("reset", "()V", AccessFlags = 1)]
				public virtual void Reset() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// pushContext
				/// </java-name>
				[Dot42.DexImport("pushContext", "()V", AccessFlags = 1)]
				public virtual void PushContext() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// popContext
				/// </java-name>
				[Dot42.DexImport("popContext", "()V", AccessFlags = 1)]
				public virtual void PopContext() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// declarePrefix
				/// </java-name>
				[Dot42.DexImport("declarePrefix", "(Ljava/lang/String;Ljava/lang/String;)Z", AccessFlags = 1)]
				public virtual bool DeclarePrefix(string @string, string string1) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// processName
				/// </java-name>
				[Dot42.DexImport("processName", "(Ljava/lang/String;[Ljava/lang/String;Z)[Ljava/lang/String;", AccessFlags = 1)]
				public virtual string[] ProcessName(string @string, string[] string1, bool boolean) /* MethodBuilder.Create */ 
				{
						return default(string[]);
				}

				/// <java-name>
				/// getURI
				/// </java-name>
				[Dot42.DexImport("getURI", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetURI(string @string) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getPrefix
				/// </java-name>
				[Dot42.DexImport("getPrefix", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetPrefix(string @string) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getPrefixes
				/// </java-name>
				[Dot42.DexImport("getPrefixes", "(Ljava/lang/String;)Ljava/util/Enumeration;", AccessFlags = 1)]
				public virtual global::Java.Util.IEnumeration<object> GetPrefixes(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IEnumeration<object>);
				}

				/// <java-name>
				/// setNamespaceDeclUris
				/// </java-name>
				[Dot42.DexImport("setNamespaceDeclUris", "(Z)V", AccessFlags = 1)]
				public virtual void SetNamespaceDeclUris(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getPrefixes
				/// </java-name>
				public virtual global::Java.Util.IEnumeration<object> Prefixes
				{
						[Dot42.DexImport("getPrefixes", "()Ljava/util/Enumeration;", AccessFlags = 1)]
						get{ return default(global::Java.Util.IEnumeration<object>); }
				}

				/// <java-name>
				/// getDeclaredPrefixes
				/// </java-name>
				public virtual global::Java.Util.IEnumeration<object> DeclaredPrefixes
				{
						[Dot42.DexImport("getDeclaredPrefixes", "()Ljava/util/Enumeration;", AccessFlags = 1)]
						get{ return default(global::Java.Util.IEnumeration<object>); }
				}

				/// <java-name>
				/// isNamespaceDeclUris
				/// </java-name>
				public virtual bool IsNamespaceDeclUris
				{
						[Dot42.DexImport("isNamespaceDeclUris", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

		}

		/// <java-name>
		/// org/xml/sax/helpers/ParserAdapter
		/// </java-name>
		[Dot42.DexImport("org/xml/sax/helpers/ParserAdapter", AccessFlags = 33)]
		public partial class ParserAdapter : global::Org.Xml.Sax.IXMLReader, global::Org.Xml.Sax.IDocumentHandler
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ParserAdapter() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Lorg/xml/sax/Parser;)V", AccessFlags = 1)]
				public ParserAdapter(global::Org.Xml.Sax.IParser parser) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setFeature
				/// </java-name>
				[Dot42.DexImport("setFeature", "(Ljava/lang/String;Z)V", AccessFlags = 1)]
				public virtual void SetFeature(string @string, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getFeature
				/// </java-name>
				[Dot42.DexImport("getFeature", "(Ljava/lang/String;)Z", AccessFlags = 1)]
				public virtual bool GetFeature(string @string) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setProperty
				/// </java-name>
				[Dot42.DexImport("setProperty", "(Ljava/lang/String;Ljava/lang/Object;)V", AccessFlags = 1)]
				public virtual void SetProperty(string @string, object @object) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getProperty
				/// </java-name>
				[Dot42.DexImport("getProperty", "(Ljava/lang/String;)Ljava/lang/Object;", AccessFlags = 1)]
				public virtual object GetProperty(string @string) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <java-name>
				/// parse
				/// </java-name>
				[Dot42.DexImport("parse", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void Parse(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// parse
				/// </java-name>
				[Dot42.DexImport("parse", "(Lorg/xml/sax/InputSource;)V", AccessFlags = 1)]
				public virtual void Parse(global::Org.Xml.Sax.InputSource inputSource) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setDocumentLocator
				/// </java-name>
				[Dot42.DexImport("setDocumentLocator", "(Lorg/xml/sax/Locator;)V", AccessFlags = 1)]
				public virtual void SetDocumentLocator(global::Org.Xml.Sax.ILocator locator) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// startDocument
				/// </java-name>
				[Dot42.DexImport("startDocument", "()V", AccessFlags = 1)]
				public virtual void StartDocument() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// endDocument
				/// </java-name>
				[Dot42.DexImport("endDocument", "()V", AccessFlags = 1)]
				public virtual void EndDocument() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// startElement
				/// </java-name>
				[Dot42.DexImport("startElement", "(Ljava/lang/String;Lorg/xml/sax/AttributeList;)V", AccessFlags = 1)]
				public virtual void StartElement(string @string, global::Org.Xml.Sax.IAttributeList attributeList) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// endElement
				/// </java-name>
				[Dot42.DexImport("endElement", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void EndElement(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// characters
				/// </java-name>
				[Dot42.DexImport("characters", "([CII)V", AccessFlags = 1)]
				public virtual void Characters(char[] @char, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// ignorableWhitespace
				/// </java-name>
				[Dot42.DexImport("ignorableWhitespace", "([CII)V", AccessFlags = 1)]
				public virtual void IgnorableWhitespace(char[] @char, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// processingInstruction
				/// </java-name>
				[Dot42.DexImport("processingInstruction", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void ProcessingInstruction(string @string, string string1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getEntityResolver
				/// </java-name>
				public virtual global::Org.Xml.Sax.IEntityResolver EntityResolver
				{
						[Dot42.DexImport("getEntityResolver", "()Lorg/xml/sax/EntityResolver;", AccessFlags = 1)]
						get{ return default(global::Org.Xml.Sax.IEntityResolver); }
						[Dot42.DexImport("setEntityResolver", "(Lorg/xml/sax/EntityResolver;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getDTDHandler
				/// </java-name>
				public virtual global::Org.Xml.Sax.IDTDHandler DTDHandler
				{
						[Dot42.DexImport("getDTDHandler", "()Lorg/xml/sax/DTDHandler;", AccessFlags = 1)]
						get{ return default(global::Org.Xml.Sax.IDTDHandler); }
						[Dot42.DexImport("setDTDHandler", "(Lorg/xml/sax/DTDHandler;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getContentHandler
				/// </java-name>
				public virtual global::Org.Xml.Sax.IContentHandler ContentHandler
				{
						[Dot42.DexImport("getContentHandler", "()Lorg/xml/sax/ContentHandler;", AccessFlags = 1)]
						get{ return default(global::Org.Xml.Sax.IContentHandler); }
						[Dot42.DexImport("setContentHandler", "(Lorg/xml/sax/ContentHandler;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getErrorHandler
				/// </java-name>
				public virtual global::Org.Xml.Sax.IErrorHandler ErrorHandler
				{
						[Dot42.DexImport("getErrorHandler", "()Lorg/xml/sax/ErrorHandler;", AccessFlags = 1)]
						get{ return default(global::Org.Xml.Sax.IErrorHandler); }
						[Dot42.DexImport("setErrorHandler", "(Lorg/xml/sax/ErrorHandler;)V", AccessFlags = 1)]
						set{ }
				}

		}

		/// <java-name>
		/// org/xml/sax/helpers/ParserFactory
		/// </java-name>
		[Dot42.DexImport("org/xml/sax/helpers/ParserFactory", AccessFlags = 33)]
		public partial class ParserFactory
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal ParserFactory() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// makeParser
				/// </java-name>
				[Dot42.DexImport("makeParser", "()Lorg/xml/sax/Parser;", AccessFlags = 9)]
				public static global::Org.Xml.Sax.IParser MakeParser() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Xml.Sax.IParser);
				}

				/// <java-name>
				/// makeParser
				/// </java-name>
				[Dot42.DexImport("makeParser", "(Ljava/lang/String;)Lorg/xml/sax/Parser;", AccessFlags = 9)]
				public static global::Org.Xml.Sax.IParser MakeParser(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Xml.Sax.IParser);
				}

		}

		/// <java-name>
		/// org/xml/sax/helpers/XMLFilterImpl
		/// </java-name>
		[Dot42.DexImport("org/xml/sax/helpers/XMLFilterImpl", AccessFlags = 33)]
		public partial class XMLFilterImpl : global::Org.Xml.Sax.IXMLFilter, global::Org.Xml.Sax.IEntityResolver, global::Org.Xml.Sax.IDTDHandler, global::Org.Xml.Sax.IContentHandler, global::Org.Xml.Sax.IErrorHandler
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public XMLFilterImpl() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Lorg/xml/sax/XMLReader;)V", AccessFlags = 1)]
				public XMLFilterImpl(global::Org.Xml.Sax.IXMLReader xMLReader) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setFeature
				/// </java-name>
				[Dot42.DexImport("setFeature", "(Ljava/lang/String;Z)V", AccessFlags = 1)]
				public virtual void SetFeature(string @string, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getFeature
				/// </java-name>
				[Dot42.DexImport("getFeature", "(Ljava/lang/String;)Z", AccessFlags = 1)]
				public virtual bool GetFeature(string @string) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setProperty
				/// </java-name>
				[Dot42.DexImport("setProperty", "(Ljava/lang/String;Ljava/lang/Object;)V", AccessFlags = 1)]
				public virtual void SetProperty(string @string, object @object) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getProperty
				/// </java-name>
				[Dot42.DexImport("getProperty", "(Ljava/lang/String;)Ljava/lang/Object;", AccessFlags = 1)]
				public virtual object GetProperty(string @string) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <java-name>
				/// parse
				/// </java-name>
				[Dot42.DexImport("parse", "(Lorg/xml/sax/InputSource;)V", AccessFlags = 1)]
				public virtual void Parse(global::Org.Xml.Sax.InputSource inputSource) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// parse
				/// </java-name>
				[Dot42.DexImport("parse", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void Parse(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// resolveEntity
				/// </java-name>
				[Dot42.DexImport("resolveEntity", "(Ljava/lang/String;Ljava/lang/String;)Lorg/xml/sax/InputSource;", AccessFlags = 1)]
				public virtual global::Org.Xml.Sax.InputSource ResolveEntity(string @string, string string1) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Xml.Sax.InputSource);
				}

				/// <java-name>
				/// notationDecl
				/// </java-name>
				[Dot42.DexImport("notationDecl", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void NotationDecl(string @string, string string1, string string2) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// unparsedEntityDecl
				/// </java-name>
				[Dot42.DexImport("unparsedEntityDecl", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void UnparsedEntityDecl(string @string, string string1, string string2, string string3) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setDocumentLocator
				/// </java-name>
				[Dot42.DexImport("setDocumentLocator", "(Lorg/xml/sax/Locator;)V", AccessFlags = 1)]
				public virtual void SetDocumentLocator(global::Org.Xml.Sax.ILocator locator) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// startDocument
				/// </java-name>
				[Dot42.DexImport("startDocument", "()V", AccessFlags = 1)]
				public virtual void StartDocument() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// endDocument
				/// </java-name>
				[Dot42.DexImport("endDocument", "()V", AccessFlags = 1)]
				public virtual void EndDocument() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// startPrefixMapping
				/// </java-name>
				[Dot42.DexImport("startPrefixMapping", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void StartPrefixMapping(string @string, string string1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// endPrefixMapping
				/// </java-name>
				[Dot42.DexImport("endPrefixMapping", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void EndPrefixMapping(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// startElement
				/// </java-name>
				[Dot42.DexImport("startElement", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lorg/xml/sax/Attributes;)V" +
    "", AccessFlags = 1)]
				public virtual void StartElement(string @string, string string1, string string2, global::Org.Xml.Sax.IAttributes attributes) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// endElement
				/// </java-name>
				[Dot42.DexImport("endElement", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void EndElement(string @string, string string1, string string2) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// characters
				/// </java-name>
				[Dot42.DexImport("characters", "([CII)V", AccessFlags = 1)]
				public virtual void Characters(char[] @char, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// ignorableWhitespace
				/// </java-name>
				[Dot42.DexImport("ignorableWhitespace", "([CII)V", AccessFlags = 1)]
				public virtual void IgnorableWhitespace(char[] @char, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// processingInstruction
				/// </java-name>
				[Dot42.DexImport("processingInstruction", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void ProcessingInstruction(string @string, string string1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// skippedEntity
				/// </java-name>
				[Dot42.DexImport("skippedEntity", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SkippedEntity(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// warning
				/// </java-name>
				[Dot42.DexImport("warning", "(Lorg/xml/sax/SAXParseException;)V", AccessFlags = 1)]
				public virtual void Warning(global::Org.Xml.Sax.SAXParseException sAXParseException) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// error
				/// </java-name>
				[Dot42.DexImport("error", "(Lorg/xml/sax/SAXParseException;)V", AccessFlags = 1)]
				public virtual void Error(global::Org.Xml.Sax.SAXParseException sAXParseException) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// fatalError
				/// </java-name>
				[Dot42.DexImport("fatalError", "(Lorg/xml/sax/SAXParseException;)V", AccessFlags = 1)]
				public virtual void FatalError(global::Org.Xml.Sax.SAXParseException sAXParseException) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getParent
				/// </java-name>
				public virtual global::Org.Xml.Sax.IXMLReader Parent
				{
						[Dot42.DexImport("getParent", "()Lorg/xml/sax/XMLReader;", AccessFlags = 1)]
						get{ return default(global::Org.Xml.Sax.IXMLReader); }
						[Dot42.DexImport("setParent", "(Lorg/xml/sax/XMLReader;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getEntityResolver
				/// </java-name>
				public virtual global::Org.Xml.Sax.IEntityResolver EntityResolver
				{
						[Dot42.DexImport("getEntityResolver", "()Lorg/xml/sax/EntityResolver;", AccessFlags = 1)]
						get{ return default(global::Org.Xml.Sax.IEntityResolver); }
						[Dot42.DexImport("setEntityResolver", "(Lorg/xml/sax/EntityResolver;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getDTDHandler
				/// </java-name>
				public virtual global::Org.Xml.Sax.IDTDHandler DTDHandler
				{
						[Dot42.DexImport("getDTDHandler", "()Lorg/xml/sax/DTDHandler;", AccessFlags = 1)]
						get{ return default(global::Org.Xml.Sax.IDTDHandler); }
						[Dot42.DexImport("setDTDHandler", "(Lorg/xml/sax/DTDHandler;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getContentHandler
				/// </java-name>
				public virtual global::Org.Xml.Sax.IContentHandler ContentHandler
				{
						[Dot42.DexImport("getContentHandler", "()Lorg/xml/sax/ContentHandler;", AccessFlags = 1)]
						get{ return default(global::Org.Xml.Sax.IContentHandler); }
						[Dot42.DexImport("setContentHandler", "(Lorg/xml/sax/ContentHandler;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getErrorHandler
				/// </java-name>
				public virtual global::Org.Xml.Sax.IErrorHandler ErrorHandler
				{
						[Dot42.DexImport("getErrorHandler", "()Lorg/xml/sax/ErrorHandler;", AccessFlags = 1)]
						get{ return default(global::Org.Xml.Sax.IErrorHandler); }
						[Dot42.DexImport("setErrorHandler", "(Lorg/xml/sax/ErrorHandler;)V", AccessFlags = 1)]
						set{ }
				}

		}

		/// <java-name>
		/// org/xml/sax/helpers/XMLReaderAdapter
		/// </java-name>
		[Dot42.DexImport("org/xml/sax/helpers/XMLReaderAdapter", AccessFlags = 33)]
		public partial class XMLReaderAdapter : global::Org.Xml.Sax.IParser, global::Org.Xml.Sax.IContentHandler
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public XMLReaderAdapter() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Lorg/xml/sax/XMLReader;)V", AccessFlags = 1)]
				public XMLReaderAdapter(global::Org.Xml.Sax.IXMLReader xMLReader) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setLocale
				/// </java-name>
				[Dot42.DexImport("setLocale", "(Ljava/util/Locale;)V", AccessFlags = 1)]
				public virtual void SetLocale(global::Java.Util.Locale locale) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setEntityResolver
				/// </java-name>
				[Dot42.DexImport("setEntityResolver", "(Lorg/xml/sax/EntityResolver;)V", AccessFlags = 1)]
				public virtual void SetEntityResolver(global::Org.Xml.Sax.IEntityResolver entityResolver) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setDTDHandler
				/// </java-name>
				[Dot42.DexImport("setDTDHandler", "(Lorg/xml/sax/DTDHandler;)V", AccessFlags = 1)]
				public virtual void SetDTDHandler(global::Org.Xml.Sax.IDTDHandler dTDHandler) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setDocumentHandler
				/// </java-name>
				[Dot42.DexImport("setDocumentHandler", "(Lorg/xml/sax/DocumentHandler;)V", AccessFlags = 1)]
				public virtual void SetDocumentHandler(global::Org.Xml.Sax.IDocumentHandler documentHandler) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setErrorHandler
				/// </java-name>
				[Dot42.DexImport("setErrorHandler", "(Lorg/xml/sax/ErrorHandler;)V", AccessFlags = 1)]
				public virtual void SetErrorHandler(global::Org.Xml.Sax.IErrorHandler errorHandler) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// parse
				/// </java-name>
				[Dot42.DexImport("parse", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void Parse(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// parse
				/// </java-name>
				[Dot42.DexImport("parse", "(Lorg/xml/sax/InputSource;)V", AccessFlags = 1)]
				public virtual void Parse(global::Org.Xml.Sax.InputSource inputSource) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setDocumentLocator
				/// </java-name>
				[Dot42.DexImport("setDocumentLocator", "(Lorg/xml/sax/Locator;)V", AccessFlags = 1)]
				public virtual void SetDocumentLocator(global::Org.Xml.Sax.ILocator locator) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// startDocument
				/// </java-name>
				[Dot42.DexImport("startDocument", "()V", AccessFlags = 1)]
				public virtual void StartDocument() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// endDocument
				/// </java-name>
				[Dot42.DexImport("endDocument", "()V", AccessFlags = 1)]
				public virtual void EndDocument() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// startPrefixMapping
				/// </java-name>
				[Dot42.DexImport("startPrefixMapping", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void StartPrefixMapping(string @string, string string1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// endPrefixMapping
				/// </java-name>
				[Dot42.DexImport("endPrefixMapping", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void EndPrefixMapping(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// startElement
				/// </java-name>
				[Dot42.DexImport("startElement", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lorg/xml/sax/Attributes;)V" +
    "", AccessFlags = 1)]
				public virtual void StartElement(string @string, string string1, string string2, global::Org.Xml.Sax.IAttributes attributes) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// endElement
				/// </java-name>
				[Dot42.DexImport("endElement", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void EndElement(string @string, string string1, string string2) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// characters
				/// </java-name>
				[Dot42.DexImport("characters", "([CII)V", AccessFlags = 1)]
				public virtual void Characters(char[] @char, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// ignorableWhitespace
				/// </java-name>
				[Dot42.DexImport("ignorableWhitespace", "([CII)V", AccessFlags = 1)]
				public virtual void IgnorableWhitespace(char[] @char, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// processingInstruction
				/// </java-name>
				[Dot42.DexImport("processingInstruction", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void ProcessingInstruction(string @string, string string1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// skippedEntity
				/// </java-name>
				[Dot42.DexImport("skippedEntity", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SkippedEntity(string @string) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// org/xml/sax/helpers/XMLReaderFactory
		/// </java-name>
		[Dot42.DexImport("org/xml/sax/helpers/XMLReaderFactory", AccessFlags = 49)]
		public sealed partial class XMLReaderFactory
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal XMLReaderFactory() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// createXMLReader
				/// </java-name>
				[Dot42.DexImport("createXMLReader", "()Lorg/xml/sax/XMLReader;", AccessFlags = 9)]
				public static global::Org.Xml.Sax.IXMLReader CreateXMLReader() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Xml.Sax.IXMLReader);
				}

				/// <java-name>
				/// createXMLReader
				/// </java-name>
				[Dot42.DexImport("createXMLReader", "(Ljava/lang/String;)Lorg/xml/sax/XMLReader;", AccessFlags = 9)]
				public static global::Org.Xml.Sax.IXMLReader CreateXMLReader(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Xml.Sax.IXMLReader);
				}

		}

}

