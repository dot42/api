#pragma warning disable 1717
namespace Org.Xml.Sax
{
		/// <java-name>
		/// org/xml/sax/HandlerBase
		/// </java-name>
		[Dot42.DexImport("org/xml/sax/HandlerBase", AccessFlags = 33)]
		public partial class HandlerBase : global::Org.Xml.Sax.IEntityResolver, global::Org.Xml.Sax.IDTDHandler, global::Org.Xml.Sax.IDocumentHandler, global::Org.Xml.Sax.IErrorHandler
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public HandlerBase() /* MethodBuilder.Create */ 
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
		/// org/xml/sax/AttributeList
		/// </java-name>
		[Dot42.DexImport("org/xml/sax/AttributeList", AccessFlags = 1537)]
		public partial interface IAttributeList
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// getLength
				/// </java-name>
				[Dot42.DexImport("getLength", "()I", AccessFlags = 1025)]
				int GetLength() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getName
				/// </java-name>
				[Dot42.DexImport("getName", "(I)Ljava/lang/String;", AccessFlags = 1025)]
				string GetName(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getType
				/// </java-name>
				[Dot42.DexImport("getType", "(I)Ljava/lang/String;", AccessFlags = 1025)]
				string GetType(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getValue
				/// </java-name>
				[Dot42.DexImport("getValue", "(I)Ljava/lang/String;", AccessFlags = 1025)]
				string GetValue(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getType
				/// </java-name>
				[Dot42.DexImport("getType", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1025)]
				string GetType(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getValue
				/// </java-name>
				[Dot42.DexImport("getValue", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1025)]
				string GetValue(string @string) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// org/xml/sax/Attributes
		/// </java-name>
		[Dot42.DexImport("org/xml/sax/Attributes", AccessFlags = 1537)]
		public partial interface IAttributes
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// getLength
				/// </java-name>
				[Dot42.DexImport("getLength", "()I", AccessFlags = 1025)]
				int GetLength() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getURI
				/// </java-name>
				[Dot42.DexImport("getURI", "(I)Ljava/lang/String;", AccessFlags = 1025)]
				string GetURI(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getLocalName
				/// </java-name>
				[Dot42.DexImport("getLocalName", "(I)Ljava/lang/String;", AccessFlags = 1025)]
				string GetLocalName(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getQName
				/// </java-name>
				[Dot42.DexImport("getQName", "(I)Ljava/lang/String;", AccessFlags = 1025)]
				string GetQName(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getType
				/// </java-name>
				[Dot42.DexImport("getType", "(I)Ljava/lang/String;", AccessFlags = 1025)]
				string GetType(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getValue
				/// </java-name>
				[Dot42.DexImport("getValue", "(I)Ljava/lang/String;", AccessFlags = 1025)]
				string GetValue(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getIndex
				/// </java-name>
				[Dot42.DexImport("getIndex", "(Ljava/lang/String;Ljava/lang/String;)I", AccessFlags = 1025)]
				int GetIndex(string @string, string string1) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getIndex
				/// </java-name>
				[Dot42.DexImport("getIndex", "(Ljava/lang/String;)I", AccessFlags = 1025)]
				int GetIndex(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getType
				/// </java-name>
				[Dot42.DexImport("getType", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1025)]
				string GetType(string @string, string string1) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getType
				/// </java-name>
				[Dot42.DexImport("getType", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1025)]
				string GetType(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getValue
				/// </java-name>
				[Dot42.DexImport("getValue", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1025)]
				string GetValue(string @string, string string1) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getValue
				/// </java-name>
				[Dot42.DexImport("getValue", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1025)]
				string GetValue(string @string) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// org/xml/sax/ContentHandler
		/// </java-name>
		[Dot42.DexImport("org/xml/sax/ContentHandler", AccessFlags = 1537)]
		public partial interface IContentHandler
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// setDocumentLocator
				/// </java-name>
				[Dot42.DexImport("setDocumentLocator", "(Lorg/xml/sax/Locator;)V", AccessFlags = 1025)]
				void SetDocumentLocator(global::Org.Xml.Sax.ILocator locator) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// startDocument
				/// </java-name>
				[Dot42.DexImport("startDocument", "()V", AccessFlags = 1025)]
				void StartDocument() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// endDocument
				/// </java-name>
				[Dot42.DexImport("endDocument", "()V", AccessFlags = 1025)]
				void EndDocument() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// startPrefixMapping
				/// </java-name>
				[Dot42.DexImport("startPrefixMapping", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1025)]
				void StartPrefixMapping(string @string, string string1) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// endPrefixMapping
				/// </java-name>
				[Dot42.DexImport("endPrefixMapping", "(Ljava/lang/String;)V", AccessFlags = 1025)]
				void EndPrefixMapping(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// startElement
				/// </java-name>
				[Dot42.DexImport("startElement", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lorg/xml/sax/Attributes;)V" +
    "", AccessFlags = 1025)]
				void StartElement(string @string, string string1, string string2, global::Org.Xml.Sax.IAttributes attributes) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// endElement
				/// </java-name>
				[Dot42.DexImport("endElement", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1025)]
				void EndElement(string @string, string string1, string string2) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// characters
				/// </java-name>
				[Dot42.DexImport("characters", "([CII)V", AccessFlags = 1025)]
				void Characters(char[] @char, int int32, int int321) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// ignorableWhitespace
				/// </java-name>
				[Dot42.DexImport("ignorableWhitespace", "([CII)V", AccessFlags = 1025)]
				void IgnorableWhitespace(char[] @char, int int32, int int321) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// processingInstruction
				/// </java-name>
				[Dot42.DexImport("processingInstruction", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1025)]
				void ProcessingInstruction(string @string, string string1) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// skippedEntity
				/// </java-name>
				[Dot42.DexImport("skippedEntity", "(Ljava/lang/String;)V", AccessFlags = 1025)]
				void SkippedEntity(string @string) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// org/xml/sax/DocumentHandler
		/// </java-name>
		[Dot42.DexImport("org/xml/sax/DocumentHandler", AccessFlags = 1537)]
		public partial interface IDocumentHandler
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// setDocumentLocator
				/// </java-name>
				[Dot42.DexImport("setDocumentLocator", "(Lorg/xml/sax/Locator;)V", AccessFlags = 1025)]
				void SetDocumentLocator(global::Org.Xml.Sax.ILocator locator) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// startDocument
				/// </java-name>
				[Dot42.DexImport("startDocument", "()V", AccessFlags = 1025)]
				void StartDocument() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// endDocument
				/// </java-name>
				[Dot42.DexImport("endDocument", "()V", AccessFlags = 1025)]
				void EndDocument() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// startElement
				/// </java-name>
				[Dot42.DexImport("startElement", "(Ljava/lang/String;Lorg/xml/sax/AttributeList;)V", AccessFlags = 1025)]
				void StartElement(string @string, global::Org.Xml.Sax.IAttributeList attributeList) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// endElement
				/// </java-name>
				[Dot42.DexImport("endElement", "(Ljava/lang/String;)V", AccessFlags = 1025)]
				void EndElement(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// characters
				/// </java-name>
				[Dot42.DexImport("characters", "([CII)V", AccessFlags = 1025)]
				void Characters(char[] @char, int int32, int int321) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// ignorableWhitespace
				/// </java-name>
				[Dot42.DexImport("ignorableWhitespace", "([CII)V", AccessFlags = 1025)]
				void IgnorableWhitespace(char[] @char, int int32, int int321) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// processingInstruction
				/// </java-name>
				[Dot42.DexImport("processingInstruction", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1025)]
				void ProcessingInstruction(string @string, string string1) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// org/xml/sax/DTDHandler
		/// </java-name>
		[Dot42.DexImport("org/xml/sax/DTDHandler", AccessFlags = 1537)]
		public partial interface IDTDHandler
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// notationDecl
				/// </java-name>
				[Dot42.DexImport("notationDecl", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1025)]
				void NotationDecl(string @string, string string1, string string2) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// unparsedEntityDecl
				/// </java-name>
				[Dot42.DexImport("unparsedEntityDecl", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1025)]
				void UnparsedEntityDecl(string @string, string string1, string string2, string string3) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// org/xml/sax/EntityResolver
		/// </java-name>
		[Dot42.DexImport("org/xml/sax/EntityResolver", AccessFlags = 1537)]
		public partial interface IEntityResolver
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// resolveEntity
				/// </java-name>
				[Dot42.DexImport("resolveEntity", "(Ljava/lang/String;Ljava/lang/String;)Lorg/xml/sax/InputSource;", AccessFlags = 1025)]
				global::Org.Xml.Sax.InputSource ResolveEntity(string @string, string string1) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// org/xml/sax/ErrorHandler
		/// </java-name>
		[Dot42.DexImport("org/xml/sax/ErrorHandler", AccessFlags = 1537)]
		public partial interface IErrorHandler
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// warning
				/// </java-name>
				[Dot42.DexImport("warning", "(Lorg/xml/sax/SAXParseException;)V", AccessFlags = 1025)]
				void Warning(global::Org.Xml.Sax.SAXParseException sAXParseException) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// error
				/// </java-name>
				[Dot42.DexImport("error", "(Lorg/xml/sax/SAXParseException;)V", AccessFlags = 1025)]
				void Error(global::Org.Xml.Sax.SAXParseException sAXParseException) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// fatalError
				/// </java-name>
				[Dot42.DexImport("fatalError", "(Lorg/xml/sax/SAXParseException;)V", AccessFlags = 1025)]
				void FatalError(global::Org.Xml.Sax.SAXParseException sAXParseException) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// org/xml/sax/Locator
		/// </java-name>
		[Dot42.DexImport("org/xml/sax/Locator", AccessFlags = 1537)]
		public partial interface ILocator
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// getPublicId
				/// </java-name>
				[Dot42.DexImport("getPublicId", "()Ljava/lang/String;", AccessFlags = 1025)]
				string GetPublicId() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getSystemId
				/// </java-name>
				[Dot42.DexImport("getSystemId", "()Ljava/lang/String;", AccessFlags = 1025)]
				string GetSystemId() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getLineNumber
				/// </java-name>
				[Dot42.DexImport("getLineNumber", "()I", AccessFlags = 1025)]
				int GetLineNumber() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getColumnNumber
				/// </java-name>
				[Dot42.DexImport("getColumnNumber", "()I", AccessFlags = 1025)]
				int GetColumnNumber() /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// org/xml/sax/InputSource
		/// </java-name>
		[Dot42.DexImport("org/xml/sax/InputSource", AccessFlags = 33)]
		public partial class InputSource
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public InputSource() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public InputSource(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/io/InputStream;)V", AccessFlags = 1)]
				public InputSource(global::Java.Io.InputStream inputStream) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/io/Reader;)V", AccessFlags = 1)]
				public InputSource(global::Java.Io.Reader reader) /* MethodBuilder.Create */ 
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
				/// getPublicId
				/// </java-name>
				[Dot42.DexImport("getPublicId", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetPublicId() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// setSystemId
				/// </java-name>
				[Dot42.DexImport("setSystemId", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetSystemId(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getSystemId
				/// </java-name>
				[Dot42.DexImport("getSystemId", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetSystemId() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// setByteStream
				/// </java-name>
				[Dot42.DexImport("setByteStream", "(Ljava/io/InputStream;)V", AccessFlags = 1)]
				public virtual void SetByteStream(global::Java.Io.InputStream inputStream) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getByteStream
				/// </java-name>
				[Dot42.DexImport("getByteStream", "()Ljava/io/InputStream;", AccessFlags = 1)]
				public virtual global::Java.Io.InputStream GetByteStream() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.InputStream);
				}

				/// <java-name>
				/// setEncoding
				/// </java-name>
				[Dot42.DexImport("setEncoding", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetEncoding(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getEncoding
				/// </java-name>
				[Dot42.DexImport("getEncoding", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetEncoding() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// setCharacterStream
				/// </java-name>
				[Dot42.DexImport("setCharacterStream", "(Ljava/io/Reader;)V", AccessFlags = 1)]
				public virtual void SetCharacterStream(global::Java.Io.Reader reader) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getCharacterStream
				/// </java-name>
				[Dot42.DexImport("getCharacterStream", "()Ljava/io/Reader;", AccessFlags = 1)]
				public virtual global::Java.Io.Reader GetCharacterStream() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.Reader);
				}

				/// <java-name>
				/// getPublicId
				/// </java-name>
				public string PublicId
				{
				[Dot42.DexImport("getPublicId", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetPublicId(); }
				[Dot42.DexImport("setPublicId", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ SetPublicId(value); }
				}

				/// <java-name>
				/// getSystemId
				/// </java-name>
				public string SystemId
				{
				[Dot42.DexImport("getSystemId", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetSystemId(); }
				[Dot42.DexImport("setSystemId", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ SetSystemId(value); }
				}

				/// <java-name>
				/// getByteStream
				/// </java-name>
				public global::Java.Io.InputStream ByteStream
				{
				[Dot42.DexImport("getByteStream", "()Ljava/io/InputStream;", AccessFlags = 1)]
						get{ return GetByteStream(); }
				[Dot42.DexImport("setByteStream", "(Ljava/io/InputStream;)V", AccessFlags = 1)]
						set{ SetByteStream(value); }
				}

				/// <java-name>
				/// getEncoding
				/// </java-name>
				public string Encoding
				{
				[Dot42.DexImport("getEncoding", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetEncoding(); }
				[Dot42.DexImport("setEncoding", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ SetEncoding(value); }
				}

				/// <java-name>
				/// getCharacterStream
				/// </java-name>
				public global::Java.Io.Reader CharacterStream
				{
				[Dot42.DexImport("getCharacterStream", "()Ljava/io/Reader;", AccessFlags = 1)]
						get{ return GetCharacterStream(); }
				[Dot42.DexImport("setCharacterStream", "(Ljava/io/Reader;)V", AccessFlags = 1)]
						set{ SetCharacterStream(value); }
				}

		}

		/// <java-name>
		/// org/xml/sax/Parser
		/// </java-name>
		[Dot42.DexImport("org/xml/sax/Parser", AccessFlags = 1537)]
		public partial interface IParser
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// setLocale
				/// </java-name>
				[Dot42.DexImport("setLocale", "(Ljava/util/Locale;)V", AccessFlags = 1025)]
				void SetLocale(global::Java.Util.Locale locale) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setEntityResolver
				/// </java-name>
				[Dot42.DexImport("setEntityResolver", "(Lorg/xml/sax/EntityResolver;)V", AccessFlags = 1025)]
				void SetEntityResolver(global::Org.Xml.Sax.IEntityResolver entityResolver) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setDTDHandler
				/// </java-name>
				[Dot42.DexImport("setDTDHandler", "(Lorg/xml/sax/DTDHandler;)V", AccessFlags = 1025)]
				void SetDTDHandler(global::Org.Xml.Sax.IDTDHandler dTDHandler) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setDocumentHandler
				/// </java-name>
				[Dot42.DexImport("setDocumentHandler", "(Lorg/xml/sax/DocumentHandler;)V", AccessFlags = 1025)]
				void SetDocumentHandler(global::Org.Xml.Sax.IDocumentHandler documentHandler) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setErrorHandler
				/// </java-name>
				[Dot42.DexImport("setErrorHandler", "(Lorg/xml/sax/ErrorHandler;)V", AccessFlags = 1025)]
				void SetErrorHandler(global::Org.Xml.Sax.IErrorHandler errorHandler) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// parse
				/// </java-name>
				[Dot42.DexImport("parse", "(Lorg/xml/sax/InputSource;)V", AccessFlags = 1025)]
				void Parse(global::Org.Xml.Sax.InputSource inputSource) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// parse
				/// </java-name>
				[Dot42.DexImport("parse", "(Ljava/lang/String;)V", AccessFlags = 1025)]
				void Parse(string @string) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// org/xml/sax/XMLFilter
		/// </java-name>
		[Dot42.DexImport("org/xml/sax/XMLFilter", AccessFlags = 1537)]
		public partial interface IXMLFilter : global::Org.Xml.Sax.IXMLReader
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// setParent
				/// </java-name>
				[Dot42.DexImport("setParent", "(Lorg/xml/sax/XMLReader;)V", AccessFlags = 1025)]
				void SetParent(global::Org.Xml.Sax.IXMLReader xMLReader) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getParent
				/// </java-name>
				[Dot42.DexImport("getParent", "()Lorg/xml/sax/XMLReader;", AccessFlags = 1025)]
				global::Org.Xml.Sax.IXMLReader GetParent() /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// org/xml/sax/XMLReader
		/// </java-name>
		[Dot42.DexImport("org/xml/sax/XMLReader", AccessFlags = 1537)]
		public partial interface IXMLReader
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// getFeature
				/// </java-name>
				[Dot42.DexImport("getFeature", "(Ljava/lang/String;)Z", AccessFlags = 1025)]
				bool GetFeature(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setFeature
				/// </java-name>
				[Dot42.DexImport("setFeature", "(Ljava/lang/String;Z)V", AccessFlags = 1025)]
				void SetFeature(string @string, bool boolean) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getProperty
				/// </java-name>
				[Dot42.DexImport("getProperty", "(Ljava/lang/String;)Ljava/lang/Object;", AccessFlags = 1025)]
				object GetProperty(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setProperty
				/// </java-name>
				[Dot42.DexImport("setProperty", "(Ljava/lang/String;Ljava/lang/Object;)V", AccessFlags = 1025)]
				void SetProperty(string @string, object @object) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setEntityResolver
				/// </java-name>
				[Dot42.DexImport("setEntityResolver", "(Lorg/xml/sax/EntityResolver;)V", AccessFlags = 1025)]
				void SetEntityResolver(global::Org.Xml.Sax.IEntityResolver entityResolver) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getEntityResolver
				/// </java-name>
				[Dot42.DexImport("getEntityResolver", "()Lorg/xml/sax/EntityResolver;", AccessFlags = 1025)]
				global::Org.Xml.Sax.IEntityResolver GetEntityResolver() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setDTDHandler
				/// </java-name>
				[Dot42.DexImport("setDTDHandler", "(Lorg/xml/sax/DTDHandler;)V", AccessFlags = 1025)]
				void SetDTDHandler(global::Org.Xml.Sax.IDTDHandler dTDHandler) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getDTDHandler
				/// </java-name>
				[Dot42.DexImport("getDTDHandler", "()Lorg/xml/sax/DTDHandler;", AccessFlags = 1025)]
				global::Org.Xml.Sax.IDTDHandler GetDTDHandler() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setContentHandler
				/// </java-name>
				[Dot42.DexImport("setContentHandler", "(Lorg/xml/sax/ContentHandler;)V", AccessFlags = 1025)]
				void SetContentHandler(global::Org.Xml.Sax.IContentHandler contentHandler) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getContentHandler
				/// </java-name>
				[Dot42.DexImport("getContentHandler", "()Lorg/xml/sax/ContentHandler;", AccessFlags = 1025)]
				global::Org.Xml.Sax.IContentHandler GetContentHandler() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setErrorHandler
				/// </java-name>
				[Dot42.DexImport("setErrorHandler", "(Lorg/xml/sax/ErrorHandler;)V", AccessFlags = 1025)]
				void SetErrorHandler(global::Org.Xml.Sax.IErrorHandler errorHandler) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getErrorHandler
				/// </java-name>
				[Dot42.DexImport("getErrorHandler", "()Lorg/xml/sax/ErrorHandler;", AccessFlags = 1025)]
				global::Org.Xml.Sax.IErrorHandler GetErrorHandler() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// parse
				/// </java-name>
				[Dot42.DexImport("parse", "(Lorg/xml/sax/InputSource;)V", AccessFlags = 1025)]
				void Parse(global::Org.Xml.Sax.InputSource inputSource) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// parse
				/// </java-name>
				[Dot42.DexImport("parse", "(Ljava/lang/String;)V", AccessFlags = 1025)]
				void Parse(string @string) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// org/xml/sax/SAXException
		/// </java-name>
		[Dot42.DexImport("org/xml/sax/SAXException", AccessFlags = 33)]
		public partial class SAXException : global::System.Exception
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public SAXException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public SAXException(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/Exception;)V", AccessFlags = 1)]
				public SAXException(global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Exception;)V", AccessFlags = 1)]
				public SAXException(string @string, global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getMessage
				/// </java-name>
				[Dot42.DexImport("getMessage", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string GetMessage() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getException
				/// </java-name>
				[Dot42.DexImport("getException", "()Ljava/lang/Exception;", AccessFlags = 1)]
				public virtual global::System.Exception GetException() /* MethodBuilder.Create */ 
				{
						return default(global::System.Exception);
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
				/// getException
				/// </java-name>
				public global::System.Exception Exception
				{
				[Dot42.DexImport("getException", "()Ljava/lang/Exception;", AccessFlags = 1)]
						get{ return GetException(); }
				}

		}

		/// <java-name>
		/// org/xml/sax/SAXNotRecognizedException
		/// </java-name>
		[Dot42.DexImport("org/xml/sax/SAXNotRecognizedException", AccessFlags = 33)]
		public partial class SAXNotRecognizedException : global::Org.Xml.Sax.SAXException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public SAXNotRecognizedException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public SAXNotRecognizedException(string @string) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// org/xml/sax/SAXNotSupportedException
		/// </java-name>
		[Dot42.DexImport("org/xml/sax/SAXNotSupportedException", AccessFlags = 33)]
		public partial class SAXNotSupportedException : global::Org.Xml.Sax.SAXException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public SAXNotSupportedException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public SAXNotSupportedException(string @string) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// org/xml/sax/SAXParseException
		/// </java-name>
		[Dot42.DexImport("org/xml/sax/SAXParseException", AccessFlags = 33)]
		public partial class SAXParseException : global::Org.Xml.Sax.SAXException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Lorg/xml/sax/Locator;)V", AccessFlags = 1)]
				public SAXParseException(string @string, global::Org.Xml.Sax.ILocator locator) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Lorg/xml/sax/Locator;Ljava/lang/Exception;)V", AccessFlags = 1)]
				public SAXParseException(string @string, global::Org.Xml.Sax.ILocator locator, global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;II)V", AccessFlags = 1)]
				public SAXParseException(string @string, string string1, string string2, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;IILjava/lang/Exception;)V", AccessFlags = 1)]
				public SAXParseException(string @string, string string1, string string2, int int32, int int321, global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getPublicId
				/// </java-name>
				[Dot42.DexImport("getPublicId", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetPublicId() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getSystemId
				/// </java-name>
				[Dot42.DexImport("getSystemId", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetSystemId() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getLineNumber
				/// </java-name>
				[Dot42.DexImport("getLineNumber", "()I", AccessFlags = 1)]
				public virtual int GetLineNumber() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getColumnNumber
				/// </java-name>
				[Dot42.DexImport("getColumnNumber", "()I", AccessFlags = 1)]
				public virtual int GetColumnNumber() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal SAXParseException() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getPublicId
				/// </java-name>
				public string PublicId
				{
				[Dot42.DexImport("getPublicId", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetPublicId(); }
				}

				/// <java-name>
				/// getSystemId
				/// </java-name>
				public string SystemId
				{
				[Dot42.DexImport("getSystemId", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetSystemId(); }
				}

				/// <java-name>
				/// getLineNumber
				/// </java-name>
				public int LineNumber
				{
				[Dot42.DexImport("getLineNumber", "()I", AccessFlags = 1)]
						get{ return GetLineNumber(); }
				}

				/// <java-name>
				/// getColumnNumber
				/// </java-name>
				public int ColumnNumber
				{
				[Dot42.DexImport("getColumnNumber", "()I", AccessFlags = 1)]
						get{ return GetColumnNumber(); }
				}

		}

}

