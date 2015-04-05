#pragma warning disable 1717
namespace Org.Xmlpull.V1.Sax2
{
		/// <java-name>
		/// org/xmlpull/v1/sax2/Driver
		/// </java-name>
		[Dot42.DexImport("org/xmlpull/v1/sax2/Driver", AccessFlags = 33)]
		public partial class Driver : global::Org.Xml.Sax.ILocator, global::Org.Xml.Sax.IXMLReader, global::Org.Xml.Sax.IAttributes
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// DECLARATION_HANDLER_PROPERTY
				/// </java-name>
				[Dot42.DexImport("DECLARATION_HANDLER_PROPERTY", "Ljava/lang/String;", AccessFlags = 28)]
				protected internal const string DECLARATION_HANDLER_PROPERTY = "http://xml.org/sax/properties/declaration-handler";
				/// <java-name>
				/// LEXICAL_HANDLER_PROPERTY
				/// </java-name>
				[Dot42.DexImport("LEXICAL_HANDLER_PROPERTY", "Ljava/lang/String;", AccessFlags = 28)]
				protected internal const string LEXICAL_HANDLER_PROPERTY = "http://xml.org/sax/properties/lexical-handler";
				/// <java-name>
				/// NAMESPACES_FEATURE
				/// </java-name>
				[Dot42.DexImport("NAMESPACES_FEATURE", "Ljava/lang/String;", AccessFlags = 28)]
				protected internal const string NAMESPACES_FEATURE = "http://xml.org/sax/features/namespaces";
				/// <java-name>
				/// NAMESPACE_PREFIXES_FEATURE
				/// </java-name>
				[Dot42.DexImport("NAMESPACE_PREFIXES_FEATURE", "Ljava/lang/String;", AccessFlags = 28)]
				protected internal const string NAMESPACE_PREFIXES_FEATURE = "http://xml.org/sax/features/namespace-prefixes";
				/// <java-name>
				/// VALIDATION_FEATURE
				/// </java-name>
				[Dot42.DexImport("VALIDATION_FEATURE", "Ljava/lang/String;", AccessFlags = 28)]
				protected internal const string VALIDATION_FEATURE = "http://xml.org/sax/features/validation";
				/// <java-name>
				/// APACHE_SCHEMA_VALIDATION_FEATURE
				/// </java-name>
				[Dot42.DexImport("APACHE_SCHEMA_VALIDATION_FEATURE", "Ljava/lang/String;", AccessFlags = 28)]
				protected internal const string APACHE_SCHEMA_VALIDATION_FEATURE = "http://apache.org/xml/features/validation/schema";
				/// <java-name>
				/// APACHE_DYNAMIC_VALIDATION_FEATURE
				/// </java-name>
				[Dot42.DexImport("APACHE_DYNAMIC_VALIDATION_FEATURE", "Ljava/lang/String;", AccessFlags = 28)]
				protected internal const string APACHE_DYNAMIC_VALIDATION_FEATURE = "http://apache.org/xml/features/validation/dynamic";
				/// <java-name>
				/// contentHandler
				/// </java-name>
				[Dot42.DexImport("contentHandler", "Lorg/xml/sax/ContentHandler;", AccessFlags = 4)]
				protected internal global::Org.Xml.Sax.IContentHandler @contenthandler;
				/// <java-name>
				/// errorHandler
				/// </java-name>
				[Dot42.DexImport("errorHandler", "Lorg/xml/sax/ErrorHandler;", AccessFlags = 4)]
				protected internal global::Org.Xml.Sax.IErrorHandler @errorhandler;
				/// <java-name>
				/// systemId
				/// </java-name>
				[Dot42.DexImport("systemId", "Ljava/lang/String;", AccessFlags = 4)]
				protected internal string @systemid;
				/// <java-name>
				/// pp
				/// </java-name>
				[Dot42.DexImport("pp", "Lorg/xmlpull/v1/XmlPullParser;", AccessFlags = 4)]
				protected internal global::Org.Xmlpull.V1.IXmlPullParser Pp;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Driver() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Lorg/xmlpull/v1/XmlPullParser;)V", AccessFlags = 1)]
				public Driver(global::Org.Xmlpull.V1.IXmlPullParser xmlPullParser) /* MethodBuilder.Create */ 
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
				/// getFeature
				/// </java-name>
				[Dot42.DexImport("getFeature", "(Ljava/lang/String;)Z", AccessFlags = 1)]
				public virtual bool GetFeature(string @string) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setFeature
				/// </java-name>
				[Dot42.DexImport("setFeature", "(Ljava/lang/String;Z)V", AccessFlags = 1)]
				public virtual void SetFeature(string @string, bool boolean) /* MethodBuilder.Create */ 
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
				/// setProperty
				/// </java-name>
				[Dot42.DexImport("setProperty", "(Ljava/lang/String;Ljava/lang/Object;)V", AccessFlags = 1)]
				public virtual void SetProperty(string @string, object @object) /* MethodBuilder.Create */ 
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
				/// parse
				/// </java-name>
				[Dot42.DexImport("parse", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void Parse(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// parseSubTree
				/// </java-name>
				[Dot42.DexImport("parseSubTree", "(Lorg/xmlpull/v1/XmlPullParser;)V", AccessFlags = 1)]
				public virtual void ParseSubTree(global::Org.Xmlpull.V1.IXmlPullParser xmlPullParser) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// startElement
				/// </java-name>
				[Dot42.DexImport("startElement", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 4)]
				protected internal virtual void StartElement(string @string, string string1, string string2) /* MethodBuilder.Create */ 
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

}

