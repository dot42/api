#pragma warning disable 1717
namespace Javax.Xml.Parsers
{
		/// <java-name>
		/// javax/xml/parsers/DocumentBuilder
		/// </java-name>
		[Dot42.DexImport("javax/xml/parsers/DocumentBuilder", AccessFlags = 1057)]
		public abstract partial class DocumentBuilder
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal DocumentBuilder() /* MethodBuilder.Create */ 
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
				/// parse
				/// </java-name>
				[Dot42.DexImport("parse", "(Ljava/io/InputStream;)Lorg/w3c/dom/Document;", AccessFlags = 1)]
				public virtual global::Org.W3c.Dom.IDocument Parse(global::Java.IO.InputStream inputStream) /* MethodBuilder.Create */ 
				{
						return default(global::Org.W3c.Dom.IDocument);
				}

				/// <java-name>
				/// parse
				/// </java-name>
				[Dot42.DexImport("parse", "(Ljava/io/InputStream;Ljava/lang/String;)Lorg/w3c/dom/Document;", AccessFlags = 1)]
				public virtual global::Org.W3c.Dom.IDocument Parse(global::Java.IO.InputStream inputStream, string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Org.W3c.Dom.IDocument);
				}

				/// <java-name>
				/// parse
				/// </java-name>
				[Dot42.DexImport("parse", "(Ljava/lang/String;)Lorg/w3c/dom/Document;", AccessFlags = 1)]
				public virtual global::Org.W3c.Dom.IDocument Parse(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Org.W3c.Dom.IDocument);
				}

				/// <java-name>
				/// parse
				/// </java-name>
				[Dot42.DexImport("parse", "(Ljava/io/File;)Lorg/w3c/dom/Document;", AccessFlags = 1)]
				public virtual global::Org.W3c.Dom.IDocument Parse(global::Java.IO.File file) /* MethodBuilder.Create */ 
				{
						return default(global::Org.W3c.Dom.IDocument);
				}

				/// <java-name>
				/// parse
				/// </java-name>
				[Dot42.DexImport("parse", "(Lorg/xml/sax/InputSource;)Lorg/w3c/dom/Document;", AccessFlags = 1025)]
				public abstract global::Org.W3c.Dom.IDocument Parse(global::Org.Xml.Sax.InputSource inputSource) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setEntityResolver
				/// </java-name>
				[Dot42.DexImport("setEntityResolver", "(Lorg/xml/sax/EntityResolver;)V", AccessFlags = 1025)]
				public abstract void SetEntityResolver(global::Org.Xml.Sax.IEntityResolver entityResolver) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setErrorHandler
				/// </java-name>
				[Dot42.DexImport("setErrorHandler", "(Lorg/xml/sax/ErrorHandler;)V", AccessFlags = 1025)]
				public abstract void SetErrorHandler(global::Org.Xml.Sax.IErrorHandler errorHandler) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// newDocument
				/// </java-name>
				[Dot42.DexImport("newDocument", "()Lorg/w3c/dom/Document;", AccessFlags = 1025)]
				public abstract global::Org.W3c.Dom.IDocument NewDocument() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// isNamespaceAware
				/// </java-name>
				public abstract bool IsNamespaceAware
				{
						[Dot42.DexImport("isNamespaceAware", "()Z", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// isValidating
				/// </java-name>
				public abstract bool IsValidating
				{
						[Dot42.DexImport("isValidating", "()Z", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getDOMImplementation
				/// </java-name>
				public abstract global::Org.W3c.Dom.IDOMImplementation DOMImplementation
				{
						[Dot42.DexImport("getDOMImplementation", "()Lorg/w3c/dom/DOMImplementation;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getSchema
				/// </java-name>
				public virtual global::Javax.Xml.Validation.Schema Schema
				{
						[Dot42.DexImport("getSchema", "()Ljavax/xml/validation/Schema;", AccessFlags = 1)]
						get{ return default(global::Javax.Xml.Validation.Schema); }
				}

				/// <java-name>
				/// isXIncludeAware
				/// </java-name>
				public virtual bool IsXIncludeAware
				{
						[Dot42.DexImport("isXIncludeAware", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

		}

		/// <java-name>
		/// javax/xml/parsers/DocumentBuilderFactory
		/// </java-name>
		[Dot42.DexImport("javax/xml/parsers/DocumentBuilderFactory", AccessFlags = 1057)]
		public abstract partial class DocumentBuilderFactory
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal DocumentBuilderFactory() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// newInstance
				/// </java-name>
				[Dot42.DexImport("newInstance", "()Ljavax/xml/parsers/DocumentBuilderFactory;", AccessFlags = 9)]
				public static global::Javax.Xml.Parsers.DocumentBuilderFactory NewInstance() /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Xml.Parsers.DocumentBuilderFactory);
				}

				/// <java-name>
				/// newInstance
				/// </java-name>
				[Dot42.DexImport("newInstance", "(Ljava/lang/String;Ljava/lang/ClassLoader;)Ljavax/xml/parsers/DocumentBuilderFact" +
    "ory;", AccessFlags = 9)]
				public static global::Javax.Xml.Parsers.DocumentBuilderFactory NewInstance(string @string, global::Java.Lang.ClassLoader classLoader) /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Xml.Parsers.DocumentBuilderFactory);
				}

				/// <java-name>
				/// newDocumentBuilder
				/// </java-name>
				[Dot42.DexImport("newDocumentBuilder", "()Ljavax/xml/parsers/DocumentBuilder;", AccessFlags = 1025)]
				public abstract global::Javax.Xml.Parsers.DocumentBuilder NewDocumentBuilder() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setAttribute
				/// </java-name>
				[Dot42.DexImport("setAttribute", "(Ljava/lang/String;Ljava/lang/Object;)V", AccessFlags = 1025)]
				public abstract void SetAttribute(string @string, object @object) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getAttribute
				/// </java-name>
				[Dot42.DexImport("getAttribute", "(Ljava/lang/String;)Ljava/lang/Object;", AccessFlags = 1025)]
				public abstract object GetAttribute(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setFeature
				/// </java-name>
				[Dot42.DexImport("setFeature", "(Ljava/lang/String;Z)V", AccessFlags = 1025)]
				public abstract void SetFeature(string @string, bool boolean) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getFeature
				/// </java-name>
				[Dot42.DexImport("getFeature", "(Ljava/lang/String;)Z", AccessFlags = 1025)]
				public abstract bool GetFeature(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// isNamespaceAware
				/// </java-name>
				public virtual bool IsNamespaceAware
				{
						[Dot42.DexImport("isNamespaceAware", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setNamespaceAware", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// isValidating
				/// </java-name>
				public virtual bool IsValidating
				{
						[Dot42.DexImport("isValidating", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setValidating", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// isIgnoringElementContentWhitespace
				/// </java-name>
				public virtual bool IsIgnoringElementContentWhitespace
				{
						[Dot42.DexImport("isIgnoringElementContentWhitespace", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setIgnoringElementContentWhitespace", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// isExpandEntityReferences
				/// </java-name>
				public virtual bool IsExpandEntityReferences
				{
						[Dot42.DexImport("isExpandEntityReferences", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setExpandEntityReferences", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// isIgnoringComments
				/// </java-name>
				public virtual bool IsIgnoringComments
				{
						[Dot42.DexImport("isIgnoringComments", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setIgnoringComments", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// isCoalescing
				/// </java-name>
				public virtual bool IsCoalescing
				{
						[Dot42.DexImport("isCoalescing", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setCoalescing", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getSchema
				/// </java-name>
				public virtual global::Javax.Xml.Validation.Schema Schema
				{
						[Dot42.DexImport("getSchema", "()Ljavax/xml/validation/Schema;", AccessFlags = 1)]
						get{ return default(global::Javax.Xml.Validation.Schema); }
						[Dot42.DexImport("setSchema", "(Ljavax/xml/validation/Schema;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// isXIncludeAware
				/// </java-name>
				public virtual bool IsXIncludeAware
				{
						[Dot42.DexImport("isXIncludeAware", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setXIncludeAware", "(Z)V", AccessFlags = 1)]
						set{ }
				}

		}

		/// <java-name>
		/// javax/xml/parsers/FactoryConfigurationError
		/// </java-name>
		[Dot42.DexImport("javax/xml/parsers/FactoryConfigurationError", AccessFlags = 33)]
		public partial class FactoryConfigurationError : global::Java.Lang.Error
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public FactoryConfigurationError() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public FactoryConfigurationError(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/Exception;)V", AccessFlags = 1)]
				public FactoryConfigurationError(global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/Exception;Ljava/lang/String;)V", AccessFlags = 1)]
				public FactoryConfigurationError(global::System.Exception exception, string @string) /* MethodBuilder.Create */ 
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
				public virtual global::System.Exception Exception
				{
						[Dot42.DexImport("getException", "()Ljava/lang/Exception;", AccessFlags = 1)]
						get{ return default(global::System.Exception); }
				}

		}

		/// <java-name>
		/// javax/xml/parsers/ParserConfigurationException
		/// </java-name>
		[Dot42.DexImport("javax/xml/parsers/ParserConfigurationException", AccessFlags = 33)]
		public partial class ParserConfigurationException : global::System.Exception
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ParserConfigurationException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public ParserConfigurationException(string @string) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// javax/xml/parsers/SAXParser
		/// </java-name>
		[Dot42.DexImport("javax/xml/parsers/SAXParser", AccessFlags = 1057)]
		public abstract partial class SAXParser
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal SAXParser() /* MethodBuilder.Create */ 
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
				/// parse
				/// </java-name>
				[Dot42.DexImport("parse", "(Ljava/io/InputStream;Lorg/xml/sax/HandlerBase;)V", AccessFlags = 1)]
				public virtual void Parse(global::Java.IO.InputStream inputStream, global::Org.Xml.Sax.HandlerBase handlerBase) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// parse
				/// </java-name>
				[Dot42.DexImport("parse", "(Ljava/io/InputStream;Lorg/xml/sax/HandlerBase;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void Parse(global::Java.IO.InputStream inputStream, global::Org.Xml.Sax.HandlerBase handlerBase, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// parse
				/// </java-name>
				[Dot42.DexImport("parse", "(Ljava/io/InputStream;Lorg/xml/sax/helpers/DefaultHandler;)V", AccessFlags = 1)]
				public virtual void Parse(global::Java.IO.InputStream inputStream, global::Org.Xml.Sax.Helpers.DefaultHandler defaultHandler) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// parse
				/// </java-name>
				[Dot42.DexImport("parse", "(Ljava/io/InputStream;Lorg/xml/sax/helpers/DefaultHandler;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void Parse(global::Java.IO.InputStream inputStream, global::Org.Xml.Sax.Helpers.DefaultHandler defaultHandler, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// parse
				/// </java-name>
				[Dot42.DexImport("parse", "(Ljava/lang/String;Lorg/xml/sax/HandlerBase;)V", AccessFlags = 1)]
				public virtual void Parse(string @string, global::Org.Xml.Sax.HandlerBase handlerBase) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// parse
				/// </java-name>
				[Dot42.DexImport("parse", "(Ljava/lang/String;Lorg/xml/sax/helpers/DefaultHandler;)V", AccessFlags = 1)]
				public virtual void Parse(string @string, global::Org.Xml.Sax.Helpers.DefaultHandler defaultHandler) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// parse
				/// </java-name>
				[Dot42.DexImport("parse", "(Ljava/io/File;Lorg/xml/sax/HandlerBase;)V", AccessFlags = 1)]
				public virtual void Parse(global::Java.IO.File file, global::Org.Xml.Sax.HandlerBase handlerBase) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// parse
				/// </java-name>
				[Dot42.DexImport("parse", "(Ljava/io/File;Lorg/xml/sax/helpers/DefaultHandler;)V", AccessFlags = 1)]
				public virtual void Parse(global::Java.IO.File file, global::Org.Xml.Sax.Helpers.DefaultHandler defaultHandler) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// parse
				/// </java-name>
				[Dot42.DexImport("parse", "(Lorg/xml/sax/InputSource;Lorg/xml/sax/HandlerBase;)V", AccessFlags = 1)]
				public virtual void Parse(global::Org.Xml.Sax.InputSource inputSource, global::Org.Xml.Sax.HandlerBase handlerBase) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// parse
				/// </java-name>
				[Dot42.DexImport("parse", "(Lorg/xml/sax/InputSource;Lorg/xml/sax/helpers/DefaultHandler;)V", AccessFlags = 1)]
				public virtual void Parse(global::Org.Xml.Sax.InputSource inputSource, global::Org.Xml.Sax.Helpers.DefaultHandler defaultHandler) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setProperty
				/// </java-name>
				[Dot42.DexImport("setProperty", "(Ljava/lang/String;Ljava/lang/Object;)V", AccessFlags = 1025)]
				public abstract void SetProperty(string @string, object @object) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getProperty
				/// </java-name>
				[Dot42.DexImport("getProperty", "(Ljava/lang/String;)Ljava/lang/Object;", AccessFlags = 1025)]
				public abstract object GetProperty(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getParser
				/// </java-name>
				public abstract global::Org.Xml.Sax.IParser Parser
				{
						[Dot42.DexImport("getParser", "()Lorg/xml/sax/Parser;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getXMLReader
				/// </java-name>
				public abstract global::Org.Xml.Sax.IXMLReader XMLReader
				{
						[Dot42.DexImport("getXMLReader", "()Lorg/xml/sax/XMLReader;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// isNamespaceAware
				/// </java-name>
				public abstract bool IsNamespaceAware
				{
						[Dot42.DexImport("isNamespaceAware", "()Z", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// isValidating
				/// </java-name>
				public abstract bool IsValidating
				{
						[Dot42.DexImport("isValidating", "()Z", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getSchema
				/// </java-name>
				public virtual global::Javax.Xml.Validation.Schema Schema
				{
						[Dot42.DexImport("getSchema", "()Ljavax/xml/validation/Schema;", AccessFlags = 1)]
						get{ return default(global::Javax.Xml.Validation.Schema); }
				}

				/// <java-name>
				/// isXIncludeAware
				/// </java-name>
				public virtual bool IsXIncludeAware
				{
						[Dot42.DexImport("isXIncludeAware", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

		}

		/// <java-name>
		/// javax/xml/parsers/SAXParserFactory
		/// </java-name>
		[Dot42.DexImport("javax/xml/parsers/SAXParserFactory", AccessFlags = 1057)]
		public abstract partial class SAXParserFactory
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal SAXParserFactory() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// newInstance
				/// </java-name>
				[Dot42.DexImport("newInstance", "()Ljavax/xml/parsers/SAXParserFactory;", AccessFlags = 9)]
				public static global::Javax.Xml.Parsers.SAXParserFactory NewInstance() /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Xml.Parsers.SAXParserFactory);
				}

				/// <java-name>
				/// newInstance
				/// </java-name>
				[Dot42.DexImport("newInstance", "(Ljava/lang/String;Ljava/lang/ClassLoader;)Ljavax/xml/parsers/SAXParserFactory;", AccessFlags = 9)]
				public static global::Javax.Xml.Parsers.SAXParserFactory NewInstance(string @string, global::Java.Lang.ClassLoader classLoader) /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Xml.Parsers.SAXParserFactory);
				}

				/// <java-name>
				/// newSAXParser
				/// </java-name>
				[Dot42.DexImport("newSAXParser", "()Ljavax/xml/parsers/SAXParser;", AccessFlags = 1025)]
				public abstract global::Javax.Xml.Parsers.SAXParser NewSAXParser() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setFeature
				/// </java-name>
				[Dot42.DexImport("setFeature", "(Ljava/lang/String;Z)V", AccessFlags = 1025)]
				public abstract void SetFeature(string @string, bool boolean) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getFeature
				/// </java-name>
				[Dot42.DexImport("getFeature", "(Ljava/lang/String;)Z", AccessFlags = 1025)]
				public abstract bool GetFeature(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// isNamespaceAware
				/// </java-name>
				public virtual bool IsNamespaceAware
				{
						[Dot42.DexImport("isNamespaceAware", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setNamespaceAware", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// isValidating
				/// </java-name>
				public virtual bool IsValidating
				{
						[Dot42.DexImport("isValidating", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setValidating", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getSchema
				/// </java-name>
				public virtual global::Javax.Xml.Validation.Schema Schema
				{
						[Dot42.DexImport("getSchema", "()Ljavax/xml/validation/Schema;", AccessFlags = 1)]
						get{ return default(global::Javax.Xml.Validation.Schema); }
						[Dot42.DexImport("setSchema", "(Ljavax/xml/validation/Schema;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// isXIncludeAware
				/// </java-name>
				public virtual bool IsXIncludeAware
				{
						[Dot42.DexImport("isXIncludeAware", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setXIncludeAware", "(Z)V", AccessFlags = 1)]
						set{ }
				}

		}

}

