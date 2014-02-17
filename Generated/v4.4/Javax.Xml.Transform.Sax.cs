// Copyright (C) 2014 dot42
//
// Original filename: Javax.Xml.Transform.Sax.cs
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
#pragma warning disable 1717
namespace Javax.Xml.Transform.Sax
{
		/// <summary>
		/// <para>This class extends TransformerFactory to provide SAX-specific factory methods. It provides two types of ContentHandlers, one for creating Transformers, the other for creating Templates objects.</para><para>If an application wants to set the ErrorHandler or EntityResolver for an XMLReader used during a transformation, it should use a URIResolver to return the SAXSource which provides (with getXMLReader) a reference to the XMLReader.</para>    
		/// </summary>
		/// <java-name>
		/// javax/xml/transform/sax/SAXTransformerFactory
		/// </java-name>
		[Dot42.DexImport("javax/xml/transform/sax/SAXTransformerFactory", AccessFlags = 1057)]
		public abstract partial class SAXTransformerFactory : global::Javax.Xml.Transform.TransformerFactory
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>If javax.xml.transform.TransformerFactory#getFeature returns true when passed this value as an argument, the TransformerFactory returned from javax.xml.transform.TransformerFactory#newInstance may be safely cast to a SAXTransformerFactory. </para>        
				/// </summary>
				/// <java-name>
				/// FEATURE
				/// </java-name>
				[Dot42.DexImport("FEATURE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string FEATURE = "http://javax.xml.transform.sax.SAXTransformerFactory/feature";
				/// <summary>
				/// <para>If javax.xml.transform.TransformerFactory#getFeature returns true when passed this value as an argument, the newXMLFilter(Source src) and newXMLFilter(Templates templates) methods are supported. </para>        
				/// </summary>
				/// <java-name>
				/// FEATURE_XMLFILTER
				/// </java-name>
				[Dot42.DexImport("FEATURE_XMLFILTER", "Ljava/lang/String;", AccessFlags = 25)]
				public const string FEATURE_XMLFILTER = "http://javax.xml.transform.sax.SAXTransformerFactory/feature/xmlfilter";
				/// <summary>
				/// <para>The default constructor is protected on purpose. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal SAXTransformerFactory() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Get a TransformerHandler object that can process SAX ContentHandler events into a Result, based on the transformation instructions specified by the argument.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>TransformerHandler ready to transform SAX events.</para>
				/// </returns>
				/// <java-name>
				/// newTransformerHandler
				/// </java-name>
				[Dot42.DexImport("newTransformerHandler", "(Ljavax/xml/transform/Source;)Ljavax/xml/transform/sax/TransformerHandler;", AccessFlags = 1025)]
				public abstract global::Javax.Xml.Transform.Sax.ITransformerHandler NewTransformerHandler(global::Javax.Xml.Transform.ISource src) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Get a TransformerHandler object that can process SAX ContentHandler events into a Result, based on the transformation instructions specified by the argument.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>TransformerHandler ready to transform SAX events.</para>
				/// </returns>
				/// <java-name>
				/// newTransformerHandler
				/// </java-name>
				[Dot42.DexImport("newTransformerHandler", "(Ljavax/xml/transform/Templates;)Ljavax/xml/transform/sax/TransformerHandler;", AccessFlags = 1025)]
				public abstract global::Javax.Xml.Transform.Sax.ITransformerHandler NewTransformerHandler(global::Javax.Xml.Transform.ITemplates src) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Get a TransformerHandler object that can process SAX ContentHandler events into a Result. The transformation is defined as an identity (or copy) transformation, for example to copy a series of SAX parse events into a DOM tree.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>A non-null reference to a TransformerHandler, that may be used as a ContentHandler for SAX parse events.</para>
				/// </returns>
				/// <java-name>
				/// newTransformerHandler
				/// </java-name>
				[Dot42.DexImport("newTransformerHandler", "()Ljavax/xml/transform/sax/TransformerHandler;", AccessFlags = 1025)]
				public abstract global::Javax.Xml.Transform.Sax.ITransformerHandler NewTransformerHandler() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Get a TemplatesHandler object that can process SAX ContentHandler events into a Templates object.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>A non-null reference to a TransformerHandler, that may be used as a ContentHandler for SAX parse events.</para>
				/// </returns>
				/// <java-name>
				/// newTemplatesHandler
				/// </java-name>
				[Dot42.DexImport("newTemplatesHandler", "()Ljavax/xml/transform/sax/TemplatesHandler;", AccessFlags = 1025)]
				public abstract global::Javax.Xml.Transform.Sax.ITemplatesHandler NewTemplatesHandler() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Create an XMLFilter that uses the given Source as the transformation instructions.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>An XMLFilter object, or null if this feature is not supported.</para>
				/// </returns>
				/// <java-name>
				/// newXMLFilter
				/// </java-name>
				[Dot42.DexImport("newXMLFilter", "(Ljavax/xml/transform/Source;)Lorg/xml/sax/XMLFilter;", AccessFlags = 1025)]
				public abstract global::Org.Xml.Sax.IXMLFilter NewXMLFilter(global::Javax.Xml.Transform.ISource src) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Create an XMLFilter that uses the given Source as the transformation instructions.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>An XMLFilter object, or null if this feature is not supported.</para>
				/// </returns>
				/// <java-name>
				/// newXMLFilter
				/// </java-name>
				[Dot42.DexImport("newXMLFilter", "(Ljavax/xml/transform/Templates;)Lorg/xml/sax/XMLFilter;", AccessFlags = 1025)]
				public abstract global::Org.Xml.Sax.IXMLFilter NewXMLFilter(global::Javax.Xml.Transform.ITemplates src) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>A TransformerHandler listens for SAX ContentHandler parse events and transforms them to a Result. </para>    
		/// </summary>
		/// <java-name>
		/// javax/xml/transform/sax/TransformerHandler
		/// </java-name>
		[Dot42.DexImport("javax/xml/transform/sax/TransformerHandler", AccessFlags = 1537)]
		public partial interface ITransformerHandler : global::Org.Xml.Sax.IContentHandler, global::Org.Xml.Sax.Ext.ILexicalHandler, global::Org.Xml.Sax.IDTDHandler
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Set the <code>Result</code> associated with this <code>TransformerHandler</code> to be used for the transformation.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setResult
				/// </java-name>
				[Dot42.DexImport("setResult", "(Ljavax/xml/transform/Result;)V", AccessFlags = 1025)]
				void SetResult(global::Javax.Xml.Transform.IResult result) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Set the base ID (URI or system ID) from where relative URLs will be resolved. </para>        
				/// </summary>
				/// <java-name>
				/// setSystemId
				/// </java-name>
				[Dot42.DexImport("setSystemId", "(Ljava/lang/String;)V", AccessFlags = 1025)]
				void SetSystemId(string systemID) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Get the base ID (URI or system ID) from where relative URLs will be resolved. </para>        
				/// </summary>
				/// <returns>
				/// <para>The systemID that was set with setSystemId. </para>
				/// </returns>
				/// <java-name>
				/// getSystemId
				/// </java-name>
				[Dot42.DexImport("getSystemId", "()Ljava/lang/String;", AccessFlags = 1025)]
				string GetSystemId() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Get the <code>Transformer</code> associated with this handler, which is needed in order to set parameters and output properties.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>Transformer</code> associated with this <code>TransformerHandler</code>. </para>
				/// </returns>
				/// <java-name>
				/// getTransformer
				/// </java-name>
				[Dot42.DexImport("getTransformer", "()Ljavax/xml/transform/Transformer;", AccessFlags = 1025)]
				global::Javax.Xml.Transform.Transformer GetTransformer() /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>Acts as an holder for a transformation Result.</para><para><para> </para></para>    
		/// </summary>
		/// <java-name>
		/// javax/xml/transform/sax/SAXResult
		/// </java-name>
		[Dot42.DexImport("javax/xml/transform/sax/SAXResult", AccessFlags = 33)]
		public partial class SAXResult : global::Javax.Xml.Transform.IResult
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>If javax.xml.transform.TransformerFactory#getFeature returns true when passed this value as an argument, the Transformer supports Result output of this type. </para>        
				/// </summary>
				/// <java-name>
				/// FEATURE
				/// </java-name>
				[Dot42.DexImport("FEATURE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string FEATURE = "http://javax.xml.transform.sax.SAXResult/feature";
				/// <summary>
				/// <para>Zero-argument default constructor. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public SAXResult() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Create a SAXResult that targets a SAX2 org.xml.sax.ContentHandler.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Lorg/xml/sax/ContentHandler;)V", AccessFlags = 1)]
				public SAXResult(global::Org.Xml.Sax.IContentHandler handler) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Set the target to be a SAX2 org.xml.sax.ContentHandler.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setHandler
				/// </java-name>
				[Dot42.DexImport("setHandler", "(Lorg/xml/sax/ContentHandler;)V", AccessFlags = 1)]
				public virtual void SetHandler(global::Org.Xml.Sax.IContentHandler handler) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Get the org.xml.sax.ContentHandler that is the Result.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The ContentHandler that is to be transformation output. </para>
				/// </returns>
				/// <java-name>
				/// getHandler
				/// </java-name>
				[Dot42.DexImport("getHandler", "()Lorg/xml/sax/ContentHandler;", AccessFlags = 1)]
				public virtual global::Org.Xml.Sax.IContentHandler GetHandler() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Xml.Sax.IContentHandler);
				}

				/// <summary>
				/// <para>Set the SAX2 org.xml.sax.ext.LexicalHandler for the output.</para><para>This is needed to handle XML comments and the like. If the lexical handler is not set, an attempt should be made by the transformer to cast the org.xml.sax.ContentHandler to a <code>LexicalHandler</code>.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setLexicalHandler
				/// </java-name>
				[Dot42.DexImport("setLexicalHandler", "(Lorg/xml/sax/ext/LexicalHandler;)V", AccessFlags = 1)]
				public virtual void SetLexicalHandler(global::Org.Xml.Sax.Ext.ILexicalHandler handler) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Get a SAX2 org.xml.sax.ext.LexicalHandler for the output.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>A <code>LexicalHandler</code>, or null. </para>
				/// </returns>
				/// <java-name>
				/// getLexicalHandler
				/// </java-name>
				[Dot42.DexImport("getLexicalHandler", "()Lorg/xml/sax/ext/LexicalHandler;", AccessFlags = 1)]
				public virtual global::Org.Xml.Sax.Ext.ILexicalHandler GetLexicalHandler() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Xml.Sax.Ext.ILexicalHandler);
				}

				/// <summary>
				/// <para>Method setSystemId Set the systemID that may be used in association with the org.xml.sax.ContentHandler.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setSystemId
				/// </java-name>
				[Dot42.DexImport("setSystemId", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetSystemId(string systemId) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Get the system identifier that was set with setSystemId.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The system identifier that was set with setSystemId, or null if setSystemId was not called. </para>
				/// </returns>
				/// <java-name>
				/// getSystemId
				/// </java-name>
				[Dot42.DexImport("getSystemId", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetSystemId() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Get the org.xml.sax.ContentHandler that is the Result.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The ContentHandler that is to be transformation output. </para>
				/// </returns>
				/// <java-name>
				/// getHandler
				/// </java-name>
				public global::Org.Xml.Sax.IContentHandler Handler
				{
				[Dot42.DexImport("getHandler", "()Lorg/xml/sax/ContentHandler;", AccessFlags = 1)]
						get{ return GetHandler(); }
				[Dot42.DexImport("setHandler", "(Lorg/xml/sax/ContentHandler;)V", AccessFlags = 1)]
						set{ SetHandler(value); }
				}

				/// <summary>
				/// <para>Get a SAX2 org.xml.sax.ext.LexicalHandler for the output.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>A <code>LexicalHandler</code>, or null. </para>
				/// </returns>
				/// <java-name>
				/// getLexicalHandler
				/// </java-name>
				public global::Org.Xml.Sax.Ext.ILexicalHandler LexicalHandler
				{
				[Dot42.DexImport("getLexicalHandler", "()Lorg/xml/sax/ext/LexicalHandler;", AccessFlags = 1)]
						get{ return GetLexicalHandler(); }
				[Dot42.DexImport("setLexicalHandler", "(Lorg/xml/sax/ext/LexicalHandler;)V", AccessFlags = 1)]
						set{ SetLexicalHandler(value); }
				}

				/// <summary>
				/// <para>Get the system identifier that was set with setSystemId.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The system identifier that was set with setSystemId, or null if setSystemId was not called. </para>
				/// </returns>
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

		}

		/// <summary>
		/// <para>Acts as an holder for SAX-style Source.</para><para>Note that XSLT requires namespace support. Attempting to transform an input source that is not generated with a namespace-aware parser may result in errors. Parsers can be made namespace aware by calling the javax.xml.parsers.SAXParserFactory#setNamespaceAware(boolean awareness) method.</para><para><para> </para><para></para><title>Revision:</title><para>446598 </para>, <title>Date:</title><para>2006-09-15 05:55:40 -0700 (Fri, 15 Sep 2006) </para></para>    
		/// </summary>
		/// <java-name>
		/// javax/xml/transform/sax/SAXSource
		/// </java-name>
		[Dot42.DexImport("javax/xml/transform/sax/SAXSource", AccessFlags = 33)]
		public partial class SAXSource : global::Javax.Xml.Transform.ISource
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>If javax.xml.transform.TransformerFactory#getFeature returns true when passed this value as an argument, the Transformer supports Source input of this type. </para>        
				/// </summary>
				/// <java-name>
				/// FEATURE
				/// </java-name>
				[Dot42.DexImport("FEATURE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string FEATURE = "http://javax.xml.transform.sax.SAXSource/feature";
				/// <summary>
				/// <para>Zero-argument default constructor. If this constructor is used, and no SAX source is set using setInputSource(InputSource inputSource) , then the <code>Transformer</code> will create an empty source org.xml.sax.InputSource using new InputSource().</para><para><para>javax.xml.transform.Transformer::transform(Source xmlSource, Result outputTarget) </para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public SAXSource() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Create a <code>SAXSource</code>, using an org.xml.sax.XMLReader and a SAX InputSource. The javax.xml.transform.Transformer or javax.xml.transform.sax.SAXTransformerFactory will set itself to be the reader's org.xml.sax.ContentHandler, and then will call reader.parse(inputSource).</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Lorg/xml/sax/XMLReader;Lorg/xml/sax/InputSource;)V", AccessFlags = 1)]
				public SAXSource(global::Org.Xml.Sax.IXMLReader reader, global::Org.Xml.Sax.InputSource inputSource) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Create a <code>SAXSource</code>, using a SAX <code>InputSource</code>. The javax.xml.transform.Transformer or javax.xml.transform.sax.SAXTransformerFactory creates a reader via org.xml.sax.helpers.XMLReaderFactory (if setXMLReader is not used), sets itself as the reader's org.xml.sax.ContentHandler, and calls reader.parse(inputSource).</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Lorg/xml/sax/InputSource;)V", AccessFlags = 1)]
				public SAXSource(global::Org.Xml.Sax.InputSource inputSource) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Set the XMLReader to be used for the Source.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setXMLReader
				/// </java-name>
				[Dot42.DexImport("setXMLReader", "(Lorg/xml/sax/XMLReader;)V", AccessFlags = 1)]
				public virtual void SetXMLReader(global::Org.Xml.Sax.IXMLReader reader) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Get the XMLReader to be used for the Source.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>A valid XMLReader or XMLFilter reference, or null. </para>
				/// </returns>
				/// <java-name>
				/// getXMLReader
				/// </java-name>
				[Dot42.DexImport("getXMLReader", "()Lorg/xml/sax/XMLReader;", AccessFlags = 1)]
				public virtual global::Org.Xml.Sax.IXMLReader GetXMLReader() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Xml.Sax.IXMLReader);
				}

				/// <summary>
				/// <para>Set the SAX InputSource to be used for the Source.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setInputSource
				/// </java-name>
				[Dot42.DexImport("setInputSource", "(Lorg/xml/sax/InputSource;)V", AccessFlags = 1)]
				public virtual void SetInputSource(global::Org.Xml.Sax.InputSource inputSource) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Get the SAX InputSource to be used for the Source.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>A valid InputSource reference, or null. </para>
				/// </returns>
				/// <java-name>
				/// getInputSource
				/// </java-name>
				[Dot42.DexImport("getInputSource", "()Lorg/xml/sax/InputSource;", AccessFlags = 1)]
				public virtual global::Org.Xml.Sax.InputSource GetInputSource() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Xml.Sax.InputSource);
				}

				/// <summary>
				/// <para>Set the system identifier for this Source. If an input source has already been set, it will set the system ID or that input source, otherwise it will create a new input source.</para><para>The system identifier is optional if there is a byte stream or a character stream, but it is still useful to provide one, since the application can use it to resolve relative URIs and can include it in error messages and warnings (the parser will attempt to open a connection to the URI only if no byte stream or character stream is specified).</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setSystemId
				/// </java-name>
				[Dot42.DexImport("setSystemId", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetSystemId(string systemId) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Get the base ID (URI or system ID) from where URIs will be resolved.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Base URL for the <code>Source</code>, or <code>null</code>. </para>
				/// </returns>
				/// <java-name>
				/// getSystemId
				/// </java-name>
				[Dot42.DexImport("getSystemId", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetSystemId() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Attempt to obtain a SAX InputSource object from a Source object.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>An InputSource, or null if Source can not be converted. </para>
				/// </returns>
				/// <java-name>
				/// sourceToInputSource
				/// </java-name>
				[Dot42.DexImport("sourceToInputSource", "(Ljavax/xml/transform/Source;)Lorg/xml/sax/InputSource;", AccessFlags = 9)]
				public static global::Org.Xml.Sax.InputSource SourceToInputSource(global::Javax.Xml.Transform.ISource source) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Xml.Sax.InputSource);
				}

				/// <summary>
				/// <para>Get the XMLReader to be used for the Source.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>A valid XMLReader or XMLFilter reference, or null. </para>
				/// </returns>
				/// <java-name>
				/// getXMLReader
				/// </java-name>
				public global::Org.Xml.Sax.IXMLReader XMLReader
				{
				[Dot42.DexImport("getXMLReader", "()Lorg/xml/sax/XMLReader;", AccessFlags = 1)]
						get{ return GetXMLReader(); }
				[Dot42.DexImport("setXMLReader", "(Lorg/xml/sax/XMLReader;)V", AccessFlags = 1)]
						set{ SetXMLReader(value); }
				}

				/// <summary>
				/// <para>Get the SAX InputSource to be used for the Source.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>A valid InputSource reference, or null. </para>
				/// </returns>
				/// <java-name>
				/// getInputSource
				/// </java-name>
				public global::Org.Xml.Sax.InputSource InputSource
				{
				[Dot42.DexImport("getInputSource", "()Lorg/xml/sax/InputSource;", AccessFlags = 1)]
						get{ return GetInputSource(); }
				[Dot42.DexImport("setInputSource", "(Lorg/xml/sax/InputSource;)V", AccessFlags = 1)]
						set{ SetInputSource(value); }
				}

				/// <summary>
				/// <para>Get the base ID (URI or system ID) from where URIs will be resolved.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Base URL for the <code>Source</code>, or <code>null</code>. </para>
				/// </returns>
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

		}

		/// <summary>
		/// <para>A SAX ContentHandler that may be used to process SAX parse events (parsing transformation instructions) into a Templates object.</para><para>Note that TemplatesHandler does not need to implement LexicalHandler.</para>    
		/// </summary>
		/// <java-name>
		/// javax/xml/transform/sax/TemplatesHandler
		/// </java-name>
		[Dot42.DexImport("javax/xml/transform/sax/TemplatesHandler", AccessFlags = 1537)]
		public partial interface ITemplatesHandler : global::Org.Xml.Sax.IContentHandler
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>When a TemplatesHandler object is used as a ContentHandler for the parsing of transformation instructions, it creates a Templates object, which the caller can get once the SAX events have been completed.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The Templates object that was created during the SAX event process, or null if no Templates object has been created. </para>
				/// </returns>
				/// <java-name>
				/// getTemplates
				/// </java-name>
				[Dot42.DexImport("getTemplates", "()Ljavax/xml/transform/Templates;", AccessFlags = 1025)]
				global::Javax.Xml.Transform.ITemplates GetTemplates() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Set the base ID (URI or system ID) for the Templates object created by this builder. This must be set in order to resolve relative URIs in the stylesheet. This must be called before the startDocument event.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setSystemId
				/// </java-name>
				[Dot42.DexImport("setSystemId", "(Ljava/lang/String;)V", AccessFlags = 1025)]
				void SetSystemId(string systemID) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Get the base ID (URI or system ID) from where relative URLs will be resolved. </para>        
				/// </summary>
				/// <returns>
				/// <para>The systemID that was set with setSystemId. </para>
				/// </returns>
				/// <java-name>
				/// getSystemId
				/// </java-name>
				[Dot42.DexImport("getSystemId", "()Ljava/lang/String;", AccessFlags = 1025)]
				string GetSystemId() /* MethodBuilder.Create */ ;

		}

}


