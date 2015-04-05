#pragma warning disable 1717
namespace Javax.Xml.Transform.Sax
{
		/// <java-name>
		/// javax/xml/transform/sax/TemplatesHandler
		/// </java-name>
		[Dot42.DexImport("javax/xml/transform/sax/TemplatesHandler", AccessFlags = 1537)]
		public partial interface ITemplatesHandler : global::Org.Xml.Sax.IContentHandler
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// getTemplates
				/// </java-name>
				global::Javax.Xml.Transform.ITemplates Templates
				{
						[Dot42.DexImport("getTemplates", "()Ljavax/xml/transform/Templates;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getSystemId
				/// </java-name>
				string SystemId
				{
						[Dot42.DexImport("getSystemId", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
						[Dot42.DexImport("setSystemId", "(Ljava/lang/String;)V", AccessFlags = 1025)]
						set;
				}

		}

		/// <java-name>
		/// javax/xml/transform/sax/TransformerHandler
		/// </java-name>
		[Dot42.DexImport("javax/xml/transform/sax/TransformerHandler", AccessFlags = 1537)]
		public partial interface ITransformerHandler : global::Org.Xml.Sax.IContentHandler, global::Org.Xml.Sax.Ext.ILexicalHandler, global::Org.Xml.Sax.IDTDHandler
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// setResult
				/// </java-name>
				[Dot42.DexImport("setResult", "(Ljavax/xml/transform/Result;)V", AccessFlags = 1025)]
				void SetResult(global::Javax.Xml.Transform.IResult result) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getSystemId
				/// </java-name>
				string SystemId
				{
						[Dot42.DexImport("getSystemId", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
						[Dot42.DexImport("setSystemId", "(Ljava/lang/String;)V", AccessFlags = 1025)]
						set;
				}

				/// <java-name>
				/// getTransformer
				/// </java-name>
				global::Javax.Xml.Transform.Transformer Transformer
				{
						[Dot42.DexImport("getTransformer", "()Ljavax/xml/transform/Transformer;", AccessFlags = 1025)]
						get;
				}

		}

		/// <java-name>
		/// javax/xml/transform/sax/SAXResult
		/// </java-name>
		[Dot42.DexImport("javax/xml/transform/sax/SAXResult", AccessFlags = 33)]
		public partial class SAXResult : global::Javax.Xml.Transform.IResult
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// FEATURE
				/// </java-name>
				[Dot42.DexImport("FEATURE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string FEATURE = "http://javax.xml.transform.sax.SAXResult/feature";
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public SAXResult() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Lorg/xml/sax/ContentHandler;)V", AccessFlags = 1)]
				public SAXResult(global::Org.Xml.Sax.IContentHandler contentHandler) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getHandler
				/// </java-name>
				public virtual global::Org.Xml.Sax.IContentHandler Handler
				{
						[Dot42.DexImport("getHandler", "()Lorg/xml/sax/ContentHandler;", AccessFlags = 1)]
						get{ return default(global::Org.Xml.Sax.IContentHandler); }
						[Dot42.DexImport("setHandler", "(Lorg/xml/sax/ContentHandler;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getLexicalHandler
				/// </java-name>
				public virtual global::Org.Xml.Sax.Ext.ILexicalHandler LexicalHandler
				{
						[Dot42.DexImport("getLexicalHandler", "()Lorg/xml/sax/ext/LexicalHandler;", AccessFlags = 1)]
						get{ return default(global::Org.Xml.Sax.Ext.ILexicalHandler); }
						[Dot42.DexImport("setLexicalHandler", "(Lorg/xml/sax/ext/LexicalHandler;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getSystemId
				/// </java-name>
				public virtual string SystemId
				{
						[Dot42.DexImport("getSystemId", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
						[Dot42.DexImport("setSystemId", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ }
				}

		}

		/// <java-name>
		/// javax/xml/transform/sax/SAXSource
		/// </java-name>
		[Dot42.DexImport("javax/xml/transform/sax/SAXSource", AccessFlags = 33)]
		public partial class SAXSource : global::Javax.Xml.Transform.ISource
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// FEATURE
				/// </java-name>
				[Dot42.DexImport("FEATURE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string FEATURE = "http://javax.xml.transform.sax.SAXSource/feature";
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public SAXSource() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Lorg/xml/sax/XMLReader;Lorg/xml/sax/InputSource;)V", AccessFlags = 1)]
				public SAXSource(global::Org.Xml.Sax.IXMLReader xMLReader, global::Org.Xml.Sax.InputSource inputSource) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Lorg/xml/sax/InputSource;)V", AccessFlags = 1)]
				public SAXSource(global::Org.Xml.Sax.InputSource inputSource) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// sourceToInputSource
				/// </java-name>
				[Dot42.DexImport("sourceToInputSource", "(Ljavax/xml/transform/Source;)Lorg/xml/sax/InputSource;", AccessFlags = 9)]
				public static global::Org.Xml.Sax.InputSource SourceToInputSource(global::Javax.Xml.Transform.ISource source) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Xml.Sax.InputSource);
				}

				/// <java-name>
				/// getXMLReader
				/// </java-name>
				public virtual global::Org.Xml.Sax.IXMLReader XMLReader
				{
						[Dot42.DexImport("getXMLReader", "()Lorg/xml/sax/XMLReader;", AccessFlags = 1)]
						get{ return default(global::Org.Xml.Sax.IXMLReader); }
						[Dot42.DexImport("setXMLReader", "(Lorg/xml/sax/XMLReader;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getInputSource
				/// </java-name>
				public virtual global::Org.Xml.Sax.InputSource InputSource
				{
						[Dot42.DexImport("getInputSource", "()Lorg/xml/sax/InputSource;", AccessFlags = 1)]
						get{ return default(global::Org.Xml.Sax.InputSource); }
						[Dot42.DexImport("setInputSource", "(Lorg/xml/sax/InputSource;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getSystemId
				/// </java-name>
				public virtual string SystemId
				{
						[Dot42.DexImport("getSystemId", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
						[Dot42.DexImport("setSystemId", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ }
				}

		}

		/// <java-name>
		/// javax/xml/transform/sax/SAXTransformerFactory
		/// </java-name>
		[Dot42.DexImport("javax/xml/transform/sax/SAXTransformerFactory", AccessFlags = 1057)]
		public abstract partial class SAXTransformerFactory : global::Javax.Xml.Transform.TransformerFactory
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// FEATURE
				/// </java-name>
				[Dot42.DexImport("FEATURE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string FEATURE = "http://javax.xml.transform.sax.SAXTransformerFactory/feature";
				/// <java-name>
				/// FEATURE_XMLFILTER
				/// </java-name>
				[Dot42.DexImport("FEATURE_XMLFILTER", "Ljava/lang/String;", AccessFlags = 25)]
				public const string FEATURE_XMLFILTER = "http://javax.xml.transform.sax.SAXTransformerFactory/feature/xmlfilter";
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal SAXTransformerFactory() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// newTransformerHandler
				/// </java-name>
				[Dot42.DexImport("newTransformerHandler", "(Ljavax/xml/transform/Source;)Ljavax/xml/transform/sax/TransformerHandler;", AccessFlags = 1025)]
				public abstract global::Javax.Xml.Transform.Sax.ITransformerHandler NewTransformerHandler(global::Javax.Xml.Transform.ISource source) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// newTransformerHandler
				/// </java-name>
				[Dot42.DexImport("newTransformerHandler", "(Ljavax/xml/transform/Templates;)Ljavax/xml/transform/sax/TransformerHandler;", AccessFlags = 1025)]
				public abstract global::Javax.Xml.Transform.Sax.ITransformerHandler NewTransformerHandler(global::Javax.Xml.Transform.ITemplates templates) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// newTransformerHandler
				/// </java-name>
				[Dot42.DexImport("newTransformerHandler", "()Ljavax/xml/transform/sax/TransformerHandler;", AccessFlags = 1025)]
				public abstract global::Javax.Xml.Transform.Sax.ITransformerHandler NewTransformerHandler() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// newTemplatesHandler
				/// </java-name>
				[Dot42.DexImport("newTemplatesHandler", "()Ljavax/xml/transform/sax/TemplatesHandler;", AccessFlags = 1025)]
				public abstract global::Javax.Xml.Transform.Sax.ITemplatesHandler NewTemplatesHandler() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// newXMLFilter
				/// </java-name>
				[Dot42.DexImport("newXMLFilter", "(Ljavax/xml/transform/Source;)Lorg/xml/sax/XMLFilter;", AccessFlags = 1025)]
				public abstract global::Org.Xml.Sax.IXMLFilter NewXMLFilter(global::Javax.Xml.Transform.ISource source) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// newXMLFilter
				/// </java-name>
				[Dot42.DexImport("newXMLFilter", "(Ljavax/xml/transform/Templates;)Lorg/xml/sax/XMLFilter;", AccessFlags = 1025)]
				public abstract global::Org.Xml.Sax.IXMLFilter NewXMLFilter(global::Javax.Xml.Transform.ITemplates templates) /* MethodBuilder.Create */ ;

		}

}

