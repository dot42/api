// Copyright (C) 2014 dot42
//
// Original filename: Org.Xml.Sax.Ext.cs
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
namespace Org.Xml.Sax.Ext
{
		/// <summary>
		/// <para>This class extends the SAX2 base handler class to support the SAX2 LexicalHandler, DeclHandler, and EntityResolver2 extensions. Except for overriding the original SAX1 resolveEntity() method the added handler methods just return. Subclassers may override everything on a method-by-method basis.</para><para><blockquote><para><b>This module, both source code and documentation, is in the Public Domain, and comes with <b>NO WARRANTY</b>.</b> </para></blockquote></para><para><b>Note:</b> this class might yet learn that the <b>ContentHandler.setDocumentLocator()</b> call might be passed a Locator2 object, and that the <b>ContentHandler.startElement()</b> call might be passed a Attributes2 object.</para><para><para>SAX 2.0 (extensions 1.1 alpha) </para><para>David Brownell </para><para>TBS </para></para>    
		/// </summary>
		/// <java-name>
		/// org/xml/sax/ext/DefaultHandler2
		/// </java-name>
		[Dot42.DexImport("org/xml/sax/ext/DefaultHandler2", AccessFlags = 33)]
		public partial class DefaultHandler2 : global::Org.Xml.Sax.Helpers.DefaultHandler, global::Org.Xml.Sax.Ext.ILexicalHandler, global::Org.Xml.Sax.Ext.IDeclHandler, global::Org.Xml.Sax.Ext.IEntityResolver2
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs a handler which ignores all parsing events. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public DefaultHandler2() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Report the start of a CDATA section.</para><para>The contents of the CDATA section will be reported through the regular characters event; this event is intended only to report the boundary.</para><para><para>endCDATA </para></para>        
				/// </summary>
				/// <java-name>
				/// startCDATA
				/// </java-name>
				[Dot42.DexImport("startCDATA", "()V", AccessFlags = 1)]
				public virtual void StartCDATA() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Report the end of a CDATA section.</para><para><para>startCDATA </para></para>        
				/// </summary>
				/// <java-name>
				/// endCDATA
				/// </java-name>
				[Dot42.DexImport("endCDATA", "()V", AccessFlags = 1)]
				public virtual void EndCDATA() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Report the start of DTD declarations, if any.</para><para>This method is intended to report the beginning of the DOCTYPE declaration; if the document has no DOCTYPE declaration, this method will not be invoked.</para><para>All declarations reported through DTDHandler or DeclHandler events must appear between the startDTD and endDTD events. Declarations are assumed to belong to the internal DTD subset unless they appear between startEntity and endEntity events. Comments and processing instructions from the DTD should also be reported between the startDTD and endDTD events, in their original order of (logical) occurrence; they are not required to appear in their correct locations relative to DTDHandler or DeclHandler events, however.</para><para>Note that the start/endDTD events will appear within the start/endDocument events from ContentHandler and before the first startElement event.</para><para><para>endDTD </para><simplesectsep></simplesectsep><para>startEntity </para></para>        
				/// </summary>
				/// <java-name>
				/// startDTD
				/// </java-name>
				[Dot42.DexImport("startDTD", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void StartDTD(string name, string publicId, string systemId) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Report the end of DTD declarations.</para><para>This method is intended to report the end of the DOCTYPE declaration; if the document has no DOCTYPE declaration, this method will not be invoked.</para><para><para>startDTD </para></para>        
				/// </summary>
				/// <java-name>
				/// endDTD
				/// </java-name>
				[Dot42.DexImport("endDTD", "()V", AccessFlags = 1)]
				public virtual void EndDTD() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Report the beginning of some internal and external XML entities.</para><para>The reporting of parameter entities (including the external DTD subset) is optional, and SAX2 drivers that report LexicalHandler events may not implement it; you can use the <code></code> feature to query or control the reporting of parameter entities.</para><para>General entities are reported with their regular names, parameter entities have '' prepended to their names, and the external DTD subset has the pseudo-entity name "[dtd]".</para><para>When a SAX2 driver is providing these events, all other events must be properly nested within start/end entity events. There is no additional requirement that events from DeclHandler or DTDHandler be properly ordered.</para><para>Note that skipped entities will be reported through the skippedEntity event, which is part of the ContentHandler interface.</para><para>Because of the streaming event model that SAX uses, some entity boundaries cannot be reported under any circumstances:</para><para><ul><li><para>general entities within attribute values </para></li><li><para>parameter entities within declarations </para></li></ul></para><para>These will be silently expanded, with no indication of where the original entity boundaries were.</para><para>Note also that the boundaries of character references (which are not really entities anyway) are not reported.</para><para>All start/endEntity events must be properly nested.</para><para><para>endEntity </para><simplesectsep></simplesectsep><para>org.xml.sax.ext.DeclHandler::internalEntityDecl </para><simplesectsep></simplesectsep><para>org.xml.sax.ext.DeclHandler::externalEntityDecl </para></para>        
				/// </summary>
				/// <java-name>
				/// startEntity
				/// </java-name>
				[Dot42.DexImport("startEntity", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void StartEntity(string name) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Report the end of an entity.</para><para><para>startEntity </para></para>        
				/// </summary>
				/// <java-name>
				/// endEntity
				/// </java-name>
				[Dot42.DexImport("endEntity", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void EndEntity(string name) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Report an XML comment anywhere in the document.</para><para>This callback will be used for comments inside or outside the document element, including comments in the external DTD subset (if read). Comments in the DTD must be properly nested inside start/endDTD and start/endEntity events (if used).</para><para></para>        
				/// </summary>
				/// <java-name>
				/// comment
				/// </java-name>
				[Dot42.DexImport("comment", "([CII)V", AccessFlags = 1)]
				public virtual void Comment(char[] ch, int start, int length) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Report an attribute type declaration.</para><para>Only the effective (first) declaration for an attribute will be reported. The type will be one of the strings "CDATA", "ID", "IDREF", "IDREFS", "NMTOKEN", "NMTOKENS", "ENTITY", "ENTITIES", a parenthesized token group with the separator "|" and all whitespace removed, or the word "NOTATION" followed by a space followed by a parenthesized token group with all whitespace removed.</para><para>The value will be the value as reported to applications, appropriately normalized and with entity and character references expanded. </para><para></para>        
				/// </summary>
				/// <java-name>
				/// attributeDecl
				/// </java-name>
				[Dot42.DexImport("attributeDecl", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/la" +
    "ng/String;)V", AccessFlags = 1)]
				public virtual void AttributeDecl(string eName, string aName, string type, string mode, string value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Report an element type declaration.</para><para>The content model will consist of the string "EMPTY", the string "ANY", or a parenthesised group, optionally followed by an occurrence indicator. The model will be normalized so that all parameter entities are fully resolved and all whitespace is removed,and will include the enclosing parentheses. Other normalization (such as removing redundant parentheses or simplifying occurrence indicators) is at the discretion of the parser.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// elementDecl
				/// </java-name>
				[Dot42.DexImport("elementDecl", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void ElementDecl(string name, string model) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Report a parsed external entity declaration.</para><para>Only the effective (first) declaration for each entity will be reported.</para><para>If the system identifier is a URL, the parser must resolve it fully before passing it to the application.</para><para><para>internalEntityDecl </para><simplesectsep></simplesectsep><para>org.xml.sax.DTDHandler::unparsedEntityDecl </para></para>        
				/// </summary>
				/// <java-name>
				/// externalEntityDecl
				/// </java-name>
				[Dot42.DexImport("externalEntityDecl", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void ExternalEntityDecl(string name, string publicId, string systemId) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Report an internal entity declaration.</para><para>Only the effective (first) declaration for each entity will be reported. All parameter entities in the value will be expanded, but general entities will not.</para><para><para>externalEntityDecl </para><simplesectsep></simplesectsep><para>org.xml.sax.DTDHandler::unparsedEntityDecl </para></para>        
				/// </summary>
				/// <java-name>
				/// internalEntityDecl
				/// </java-name>
				[Dot42.DexImport("internalEntityDecl", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void InternalEntityDecl(string name, string value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Tells the parser that if no external subset has been declared in the document text, none should be used.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>null (always).</para>
				/// </returns>
				/// <java-name>
				/// getExternalSubset
				/// </java-name>
				[Dot42.DexImport("getExternalSubset", "(Ljava/lang/String;Ljava/lang/String;)Lorg/xml/sax/InputSource;", AccessFlags = 1)]
				public virtual global::Org.Xml.Sax.InputSource GetExternalSubset(string name, string baseURI) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Xml.Sax.InputSource);
				}

				/// <summary>
				/// <para>Tells the parser to resolve the systemId against the baseURI and read the entity text from that resulting absolute URI. Note that because the older DefaultHandler.resolveEntity(), method is overridden to call this one, this method may sometimes be invoked with null <b>name</b> and <b>baseURI</b>, and with the <b>systemId</b> already absolutized.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>An InputSource object describing the new input source.</para>
				/// </returns>
				/// <java-name>
				/// resolveEntity
				/// </java-name>
				[Dot42.DexImport("resolveEntity", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lorg/xm" +
    "l/sax/InputSource;", AccessFlags = 1)]
				public virtual global::Org.Xml.Sax.InputSource ResolveEntity(string name, string publicId, string baseURI, string systemId) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Xml.Sax.InputSource);
				}

				/// <summary>
				/// <para>Invokes EntityResolver2.resolveEntity() with null entity name and base URI. You only need to override that method to use this class.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>An InputSource object describing the new input source.</para>
				/// </returns>
				/// <java-name>
				/// resolveEntity
				/// </java-name>
				[Dot42.DexImport("resolveEntity", "(Ljava/lang/String;Ljava/lang/String;)Lorg/xml/sax/InputSource;", AccessFlags = 1)]
				public override global::Org.Xml.Sax.InputSource ResolveEntity(string publicId, string systemId) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Xml.Sax.InputSource);
				}

		}

		/// <summary>
		/// <para>SAX2 extension helper for holding additional Entity information, implementing the Locator2 interface.</para><para><blockquote><para><b>This module, both source code and documentation, is in the Public Domain, and comes with <b>NO WARRANTY</b>.</b> </para></blockquote></para><para>This is not part of core-only SAX2 distributions.</para><para><para>SAX 2.0.2 </para><para>David Brownell </para><para>TBS </para></para>    
		/// </summary>
		/// <java-name>
		/// org/xml/sax/ext/Locator2Impl
		/// </java-name>
		[Dot42.DexImport("org/xml/sax/ext/Locator2Impl", AccessFlags = 33)]
		public partial class Locator2Impl : global::Org.Xml.Sax.Helpers.LocatorImpl, global::Org.Xml.Sax.Ext.ILocator2
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Construct a new, empty Locator2Impl object. This will not normally be useful, since the main purpose of this class is to make a snapshot of an existing Locator. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Locator2Impl() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Copy an existing Locator or Locator2 object. If the object implements Locator2, values of the <b>encoding</b> and <b>version</b>strings are copied, otherwise they set to <b>null</b>.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Lorg/xml/sax/Locator;)V", AccessFlags = 1)]
				public Locator2Impl(global::Org.Xml.Sax.ILocator locator) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the current value of the version property.</para><para><para>setXMLVersion </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the current value of the version property.</para>
				/// </returns>
				/// <java-name>
				/// getXMLVersion
				/// </java-name>
				[Dot42.DexImport("getXMLVersion", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetXMLVersion() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the current value of the encoding property.</para><para><para>setEncoding </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the current value of the encoding property.</para>
				/// </returns>
				/// <java-name>
				/// getEncoding
				/// </java-name>
				[Dot42.DexImport("getEncoding", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetEncoding() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Assigns the current value of the version property.</para><para><para>getXMLVersion </para></para>        
				/// </summary>
				/// <java-name>
				/// setXMLVersion
				/// </java-name>
				[Dot42.DexImport("setXMLVersion", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetXMLVersion(string version) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Assigns the current value of the encoding property.</para><para><para>getEncoding </para></para>        
				/// </summary>
				/// <java-name>
				/// setEncoding
				/// </java-name>
				[Dot42.DexImport("setEncoding", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetEncoding(string encoding) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("org/xml/sax/Locator", "getPublicId", "()Ljava/lang/String;", AccessFlags = 1025)]
				public override string GetPublicId() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(string);
				}

				[Dot42.DexImport("org/xml/sax/Locator", "getSystemId", "()Ljava/lang/String;", AccessFlags = 1025)]
				public override string GetSystemId() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(string);
				}

				[Dot42.DexImport("org/xml/sax/Locator", "getLineNumber", "()I", AccessFlags = 1025)]
				public override int GetLineNumber() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(int);
				}

				[Dot42.DexImport("org/xml/sax/Locator", "getColumnNumber", "()I", AccessFlags = 1025)]
				public override int GetColumnNumber() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the current value of the version property.</para><para><para>setXMLVersion </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the current value of the version property.</para>
				/// </returns>
				/// <java-name>
				/// getXMLVersion
				/// </java-name>
				public string XMLVersion
				{
				[Dot42.DexImport("getXMLVersion", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetXMLVersion(); }
				[Dot42.DexImport("setXMLVersion", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ SetXMLVersion(value); }
				}

				/// <summary>
				/// <para>Returns the current value of the encoding property.</para><para><para>setEncoding </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the current value of the encoding property.</para>
				/// </returns>
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

				public string PublicId
				{
				[Dot42.DexImport("org/xml/sax/Locator", "getPublicId", "()Ljava/lang/String;", AccessFlags = 1025)]
						get{ return GetPublicId(); }
				}

				public string SystemId
				{
				[Dot42.DexImport("org/xml/sax/Locator", "getSystemId", "()Ljava/lang/String;", AccessFlags = 1025)]
						get{ return GetSystemId(); }
				}

				public int LineNumber
				{
				[Dot42.DexImport("org/xml/sax/Locator", "getLineNumber", "()I", AccessFlags = 1025)]
						get{ return GetLineNumber(); }
				}

				public int ColumnNumber
				{
				[Dot42.DexImport("org/xml/sax/Locator", "getColumnNumber", "()I", AccessFlags = 1025)]
						get{ return GetColumnNumber(); }
				}

		}

		/// <summary>
		/// <para>SAX2 extension handler for lexical events.</para><para><blockquote><para><b>This module, both source code and documentation, is in the Public Domain, and comes with <b>NO WARRANTY</b>.</b> See  for further information. </para></blockquote></para><para>This is an optional extension handler for SAX2 to provide lexical information about an XML document, such as comments and CDATA section boundaries. XML readers are not required to recognize this handler, and it is not part of core-only SAX2 distributions.</para><para>The events in the lexical handler apply to the entire document, not just to the document element, and all lexical handler events must appear between the content handler's startDocument and endDocument events.</para><para>To set the LexicalHandler for an XML reader, use the setProperty method with the property name <code></code> and an object implementing this interface (or null) as the value. If the reader does not report lexical events, it will throw a SAXNotRecognizedException when you attempt to register the handler.</para><para><para>SAX 2.0 (extensions 1.0) </para><para>David Megginson </para><para>2.0.1 (sax2r2) </para></para>    
		/// </summary>
		/// <java-name>
		/// org/xml/sax/ext/LexicalHandler
		/// </java-name>
		[Dot42.DexImport("org/xml/sax/ext/LexicalHandler", AccessFlags = 1537)]
		public partial interface ILexicalHandler
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Report the start of DTD declarations, if any.</para><para>This method is intended to report the beginning of the DOCTYPE declaration; if the document has no DOCTYPE declaration, this method will not be invoked.</para><para>All declarations reported through DTDHandler or DeclHandler events must appear between the startDTD and endDTD events. Declarations are assumed to belong to the internal DTD subset unless they appear between startEntity and endEntity events. Comments and processing instructions from the DTD should also be reported between the startDTD and endDTD events, in their original order of (logical) occurrence; they are not required to appear in their correct locations relative to DTDHandler or DeclHandler events, however.</para><para>Note that the start/endDTD events will appear within the start/endDocument events from ContentHandler and before the first startElement event.</para><para><para>endDTD </para><simplesectsep></simplesectsep><para>startEntity </para></para>        
				/// </summary>
				/// <java-name>
				/// startDTD
				/// </java-name>
				[Dot42.DexImport("startDTD", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1025)]
				void StartDTD(string name, string publicId, string systemId) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Report the end of DTD declarations.</para><para>This method is intended to report the end of the DOCTYPE declaration; if the document has no DOCTYPE declaration, this method will not be invoked.</para><para><para>startDTD </para></para>        
				/// </summary>
				/// <java-name>
				/// endDTD
				/// </java-name>
				[Dot42.DexImport("endDTD", "()V", AccessFlags = 1025)]
				void EndDTD() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Report the beginning of some internal and external XML entities.</para><para>The reporting of parameter entities (including the external DTD subset) is optional, and SAX2 drivers that report LexicalHandler events may not implement it; you can use the <code></code> feature to query or control the reporting of parameter entities.</para><para>General entities are reported with their regular names, parameter entities have '' prepended to their names, and the external DTD subset has the pseudo-entity name "[dtd]".</para><para>When a SAX2 driver is providing these events, all other events must be properly nested within start/end entity events. There is no additional requirement that events from DeclHandler or DTDHandler be properly ordered.</para><para>Note that skipped entities will be reported through the skippedEntity event, which is part of the ContentHandler interface.</para><para>Because of the streaming event model that SAX uses, some entity boundaries cannot be reported under any circumstances:</para><para><ul><li><para>general entities within attribute values </para></li><li><para>parameter entities within declarations </para></li></ul></para><para>These will be silently expanded, with no indication of where the original entity boundaries were.</para><para>Note also that the boundaries of character references (which are not really entities anyway) are not reported.</para><para>All start/endEntity events must be properly nested.</para><para><para>endEntity </para><simplesectsep></simplesectsep><para>org.xml.sax.ext.DeclHandler::internalEntityDecl </para><simplesectsep></simplesectsep><para>org.xml.sax.ext.DeclHandler::externalEntityDecl </para></para>        
				/// </summary>
				/// <java-name>
				/// startEntity
				/// </java-name>
				[Dot42.DexImport("startEntity", "(Ljava/lang/String;)V", AccessFlags = 1025)]
				void StartEntity(string name) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Report the end of an entity.</para><para><para>startEntity </para></para>        
				/// </summary>
				/// <java-name>
				/// endEntity
				/// </java-name>
				[Dot42.DexImport("endEntity", "(Ljava/lang/String;)V", AccessFlags = 1025)]
				void EndEntity(string name) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Report the start of a CDATA section.</para><para>The contents of the CDATA section will be reported through the regular characters event; this event is intended only to report the boundary.</para><para><para>endCDATA </para></para>        
				/// </summary>
				/// <java-name>
				/// startCDATA
				/// </java-name>
				[Dot42.DexImport("startCDATA", "()V", AccessFlags = 1025)]
				void StartCDATA() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Report the end of a CDATA section.</para><para><para>startCDATA </para></para>        
				/// </summary>
				/// <java-name>
				/// endCDATA
				/// </java-name>
				[Dot42.DexImport("endCDATA", "()V", AccessFlags = 1025)]
				void EndCDATA() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Report an XML comment anywhere in the document.</para><para>This callback will be used for comments inside or outside the document element, including comments in the external DTD subset (if read). Comments in the DTD must be properly nested inside start/endDTD and start/endEntity events (if used).</para><para></para>        
				/// </summary>
				/// <java-name>
				/// comment
				/// </java-name>
				[Dot42.DexImport("comment", "([CII)V", AccessFlags = 1025)]
				void Comment(char[] ch, int start, int length) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>Extended interface for mapping external entity references to input sources, or providing a missing external subset. The XMLReader.setEntityResolver() method is used to provide implementations of this interface to parsers. When a parser uses the methods in this interface, the EntityResolver2.resolveEntity() method (in this interface) is used <b>instead of</b> the older (SAX 1.0) EntityResolver.resolveEntity() method.</para><para><blockquote><para><b>This module, both source code and documentation, is in the Public Domain, and comes with <b>NO WARRANTY</b>.</b> </para></blockquote></para><para>If a SAX application requires the customized handling which this interface defines for external entities, it must ensure that it uses an XMLReader with the <b></b> feature flag set to <b>true</b> (which is its default value when the feature is recognized). If that flag is unrecognized, or its value is false, or the resolver does not implement this interface, then only the EntityResolver method will be used. </para><para>That supports three categories of application that modify entity resolution. <b>Old Style</b> applications won't know about this interface; they will provide an EntityResolver. <b>Transitional Mode</b> provide an EntityResolver2 and automatically get the benefit of its methods in any systems (parsers or other tools) supporting it, due to polymorphism. Both <b>Old Style</b> and <b>Transitional Mode</b> applications will work with any SAX2 parser. <b>New style</b> applications will fail to run except on SAX2 parsers that support this particular feature. They will insist that feature flag have a value of "true", and the EntityResolver2 implementation they provide might throw an exception if the original SAX 1.0 style entity resolution method is invoked. </para><para><para>org.xml.sax.XMLReader::setEntityResolver</para><para>SAX 2.0 (extensions 1.1 alpha) </para><para>David Brownell </para><para>TBD </para></para>    
		/// </summary>
		/// <java-name>
		/// org/xml/sax/ext/EntityResolver2
		/// </java-name>
		[Dot42.DexImport("org/xml/sax/ext/EntityResolver2", AccessFlags = 1537)]
		public partial interface IEntityResolver2 : global::Org.Xml.Sax.IEntityResolver
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Allows applications to provide an external subset for documents that don't explicitly define one. Documents with DOCTYPE declarations that omit an external subset can thus augment the declarations available for validation, entity processing, and attribute processing (normalization, defaulting, and reporting types including ID). This augmentation is reported through the startDTD() method as if the document text had originally included the external subset; this callback is made before any internal subset data or errors are reported.</para><para>This method can also be used with documents that have no DOCTYPE declaration. When the root element is encountered, but no DOCTYPE declaration has been seen, this method is invoked. If it returns a value for the external subset, that root element is declared to be the root element, giving the effect of splicing a DOCTYPE declaration at the end the prolog of a document that could not otherwise be valid. The sequence of parser callbacks in that case logically resembles this:</para><para><pre>
				///        ... comments and PIs from the prolog (as usual)
				///        startDTD ("rootName", source.getPublicId (), source.getSystemId ());
				///        startEntity ("[dtd]");
				///        ... declarations, comments, and PIs from the external subset
				///        endEntity ("[dtd]");
				///        endDTD ();
				///        ... then the rest of the document (as usual)
				///        startElement (..., "rootName", ...);
				///        </pre></para><para>Note that the InputSource gets no further resolution. Implementations of this method may wish to invoke resolveEntity() to gain benefits such as use of local caches of DTD entities. Also, this method will never be used by a (non-validating) processor that is not including external parameter entities. </para><para>Uses for this method include facilitating data validation when interoperating with XML processors that would always require undesirable network accesses for external entities, or which for other reasons adopt a "no DTDs" policy. Non-validation motives include forcing documents to include DTDs so that attributes are handled consistently. For example, an XPath processor needs to know which attibutes have type "ID" before it can process a widely used type of reference.</para><para><b>Warning:</b> Returning an external subset modifies the input document. By providing definitions for general entities, it can make a malformed document appear to be well formed. </para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>An InputSource object describing the new external subset to be used by the parser, or null to indicate that no external subset is provided.</para>
				/// </returns>
				/// <java-name>
				/// getExternalSubset
				/// </java-name>
				[Dot42.DexImport("getExternalSubset", "(Ljava/lang/String;Ljava/lang/String;)Lorg/xml/sax/InputSource;", AccessFlags = 1025)]
				global::Org.Xml.Sax.InputSource GetExternalSubset(string name, string baseURI) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Allows applications to map references to external entities into input sources, or tell the parser it should use conventional URI resolution. This method is only called for external entities which have been properly declared. This method provides more flexibility than the EntityResolver interface, supporting implementations of more complex catalogue schemes such as the one defined by the  specification.</para><para>Parsers configured to use this resolver method will call it to determine the input source to use for any external entity being included because of a reference in the XML text. That excludes the document entity, and any external entity returned by getExternalSubset(). When a (non-validating) processor is configured not to include a class of entities (parameter or general) through use of feature flags, this method is not invoked for such entities. </para><para>Note that the entity naming scheme used here is the same one used in the LexicalHandler, or in the ContentHandler.skippedEntity() method. </para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>An InputSource object describing the new input source to be used by the parser. Returning null directs the parser to resolve the system ID against the base URI and open a connection to resulting URI.</para>
				/// </returns>
				/// <java-name>
				/// resolveEntity
				/// </java-name>
				[Dot42.DexImport("resolveEntity", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lorg/xm" +
    "l/sax/InputSource;", AccessFlags = 1025)]
				global::Org.Xml.Sax.InputSource ResolveEntity(string name, string publicId, string baseURI, string systemId) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>SAX2 extension helper for additional Attributes information, implementing the Attributes2 interface.</para><para><blockquote><para><b>This module, both source code and documentation, is in the Public Domain, and comes with <b>NO WARRANTY</b>.</b> </para></blockquote></para><para>This is not part of core-only SAX2 distributions.</para><para>The <b>specified</b> flag for each attribute will always be true, unless it has been set to false in the copy constructor or using setSpecified. Similarly, the <b>declared</b> flag for each attribute will always be false, except for defaulted attributes (<b>specified</b> is false), non-CDATA attributes, or when it is set to true using setDeclared. If you change an attribute's type by hand, you may need to modify its <b>declared</b> flag to match. </para><para><para>SAX 2.0 (extensions 1.1 alpha) </para><para>David Brownell </para><para>TBS </para></para>    
		/// </summary>
		/// <java-name>
		/// org/xml/sax/ext/Attributes2Impl
		/// </java-name>
		[Dot42.DexImport("org/xml/sax/ext/Attributes2Impl", AccessFlags = 33)]
		public partial class Attributes2Impl : global::Org.Xml.Sax.Helpers.AttributesImpl, global::Org.Xml.Sax.Ext.IAttributes2
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Construct a new, empty Attributes2Impl object. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Attributes2Impl() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Copy an existing Attributes or Attributes2 object. If the object implements Attributes2, values of the <b>specified</b> and <b>declared</b> flags for each attribute are copied. Otherwise the flag values are defaulted to assume no DTD was used, unless there is evidence to the contrary (such as attributes with type other than CDATA, which must have been <b>declared</b>).</para><para>This constructor is especially useful inside a startElement event.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Lorg/xml/sax/Attributes;)V", AccessFlags = 1)]
				public Attributes2Impl(global::Org.Xml.Sax.IAttributes atts) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns false unless the attribute was declared in the DTD. This helps distinguish two kinds of attributes that SAX reports as CDATA: ones that were declared (and hence are usually valid), and those that were not (and which are never valid).</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if the attribute was declared in the DTD, false otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isDeclared
				/// </java-name>
				[Dot42.DexImport("isDeclared", "(I)Z", AccessFlags = 1)]
				public virtual bool IsDeclared(int index) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns false unless the attribute was declared in the DTD. This helps distinguish two kinds of attributes that SAX reports as CDATA: ones that were declared (and hence are usually valid), and those that were not (and which are never valid).</para><para>Remember that since DTDs do not "understand" namespaces, the namespace URI associated with an attribute may not have come from the DTD. The declaration will have applied to the attribute's <b>qName</b>.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if the attribute was declared in the DTD, false otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isDeclared
				/// </java-name>
				[Dot42.DexImport("isDeclared", "(Ljava/lang/String;Ljava/lang/String;)Z", AccessFlags = 1)]
				public virtual bool IsDeclared(string uri, string localName) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns false unless the attribute was declared in the DTD. This helps distinguish two kinds of attributes that SAX reports as CDATA: ones that were declared (and hence are usually valid), and those that were not (and which are never valid).</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if the attribute was declared in the DTD, false otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isDeclared
				/// </java-name>
				[Dot42.DexImport("isDeclared", "(Ljava/lang/String;)Z", AccessFlags = 1)]
				public virtual bool IsDeclared(string index) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns the current value of an attribute's "specified" flag.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>current flag value </para>
				/// </returns>
				/// <java-name>
				/// isSpecified
				/// </java-name>
				[Dot42.DexImport("isSpecified", "(I)Z", AccessFlags = 1)]
				public virtual bool IsSpecified(int index) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns the current value of an attribute's "specified" flag.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>current flag value </para>
				/// </returns>
				/// <java-name>
				/// isSpecified
				/// </java-name>
				[Dot42.DexImport("isSpecified", "(Ljava/lang/String;Ljava/lang/String;)Z", AccessFlags = 1)]
				public virtual bool IsSpecified(string uri, string localName) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns the current value of an attribute's "specified" flag.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>current flag value </para>
				/// </returns>
				/// <java-name>
				/// isSpecified
				/// </java-name>
				[Dot42.DexImport("isSpecified", "(Ljava/lang/String;)Z", AccessFlags = 1)]
				public virtual bool IsSpecified(string index) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Copy an entire Attributes object. The "specified" flags are assigned as true, and "declared" flags as false (except when an attribute's type is not CDATA), unless the object is an Attributes2 object. In that case those flag values are all copied.</para><para><para>AttributesImpl::setAttributes </para></para>        
				/// </summary>
				/// <java-name>
				/// setAttributes
				/// </java-name>
				[Dot42.DexImport("setAttributes", "(Lorg/xml/sax/Attributes;)V", AccessFlags = 1)]
				public override void SetAttributes(global::Org.Xml.Sax.IAttributes atts) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Add an attribute to the end of the list, setting its "specified" flag to true. To set that flag's value to false, use setSpecified.</para><para>Unless the attribute <b>type</b> is CDATA, this attribute is marked as being declared in the DTD. To set that flag's value to true for CDATA attributes, use setDeclared.</para><para><para>AttributesImpl::addAttribute </para></para>        
				/// </summary>
				/// <java-name>
				/// addAttribute
				/// </java-name>
				[Dot42.DexImport("addAttribute", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/la" +
    "ng/String;)V", AccessFlags = 1)]
				public override void AddAttribute(string uri, string localName, string qName, string type, string value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Remove an attribute from the list.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// removeAttribute
				/// </java-name>
				[Dot42.DexImport("removeAttribute", "(I)V", AccessFlags = 1)]
				public override void RemoveAttribute(int index) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Assign a value to the "declared" flag of a specific attribute. This is normally needed only for attributes of type CDATA, including attributes whose type is changed to or from CDATA.</para><para><para>setType </para></para>        
				/// </summary>
				/// <java-name>
				/// setDeclared
				/// </java-name>
				[Dot42.DexImport("setDeclared", "(IZ)V", AccessFlags = 1)]
				public virtual void SetDeclared(int index, bool value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Assign a value to the "specified" flag of a specific attribute. This is the only way this flag can be cleared, except clearing by initialization with the copy constructor.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setSpecified
				/// </java-name>
				[Dot42.DexImport("setSpecified", "(IZ)V", AccessFlags = 1)]
				public virtual void SetSpecified(int index, bool value) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("org/xml/sax/Attributes", "getLength", "()I", AccessFlags = 1025)]
				public override int GetLength() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(int);
				}

				[Dot42.DexImport("org/xml/sax/Attributes", "getURI", "(I)Ljava/lang/String;", AccessFlags = 1025)]
				public override string GetURI(int index) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(string);
				}

				[Dot42.DexImport("org/xml/sax/Attributes", "getLocalName", "(I)Ljava/lang/String;", AccessFlags = 1025)]
				public override string GetLocalName(int index) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(string);
				}

				[Dot42.DexImport("org/xml/sax/Attributes", "getQName", "(I)Ljava/lang/String;", AccessFlags = 1025)]
				public override string GetQName(int index) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(string);
				}

				[Dot42.DexImport("org/xml/sax/Attributes", "getType", "(I)Ljava/lang/String;", AccessFlags = 1025)]
				public override string GetType(int index) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(string);
				}

				[Dot42.DexImport("org/xml/sax/Attributes", "getValue", "(I)Ljava/lang/String;", AccessFlags = 1025)]
				public override string GetValue(int index) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(string);
				}

				[Dot42.DexImport("org/xml/sax/Attributes", "getIndex", "(Ljava/lang/String;Ljava/lang/String;)I", AccessFlags = 1025)]
				public override int GetIndex(string uri, string localName) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(int);
				}

				[Dot42.DexImport("org/xml/sax/Attributes", "getIndex", "(Ljava/lang/String;)I", AccessFlags = 1025)]
				public override int GetIndex(string qName) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(int);
				}

				[Dot42.DexImport("org/xml/sax/Attributes", "getType", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1025)]
				public override string GetType(string uri, string localName) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(string);
				}

				[Dot42.DexImport("org/xml/sax/Attributes", "getType", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1025)]
				public override string GetType(string index) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(string);
				}

				[Dot42.DexImport("org/xml/sax/Attributes", "getValue", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1025)]
				public override string GetValue(string uri, string localName) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(string);
				}

				[Dot42.DexImport("org/xml/sax/Attributes", "getValue", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1025)]
				public override string GetValue(string index) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(string);
				}

				public int Length
				{
				[Dot42.DexImport("org/xml/sax/Attributes", "getLength", "()I", AccessFlags = 1025)]
						get{ return GetLength(); }
				}

		}

		/// <summary>
		/// <para>SAX2 extension handler for DTD declaration events.</para><para><blockquote><para><b>This module, both source code and documentation, is in the Public Domain, and comes with <b>NO WARRANTY</b>.</b> See  for further information. </para></blockquote></para><para>This is an optional extension handler for SAX2 to provide more complete information about DTD declarations in an XML document. XML readers are not required to recognize this handler, and it is not part of core-only SAX2 distributions.</para><para>Note that data-related DTD declarations (unparsed entities and notations) are already reported through the DTDHandler interface.</para><para>If you are using the declaration handler together with a lexical handler, all of the events will occur between the startDTD and the endDTD events.</para><para>To set the DeclHandler for an XML reader, use the setProperty method with the property name <code></code> and an object implementing this interface (or null) as the value. If the reader does not report declaration events, it will throw a SAXNotRecognizedException when you attempt to register the handler.</para><para><para>SAX 2.0 (extensions 1.0) </para><para>David Megginson </para><para>2.0.1 (sax2r2) </para></para>    
		/// </summary>
		/// <java-name>
		/// org/xml/sax/ext/DeclHandler
		/// </java-name>
		[Dot42.DexImport("org/xml/sax/ext/DeclHandler", AccessFlags = 1537)]
		public partial interface IDeclHandler
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Report an element type declaration.</para><para>The content model will consist of the string "EMPTY", the string "ANY", or a parenthesised group, optionally followed by an occurrence indicator. The model will be normalized so that all parameter entities are fully resolved and all whitespace is removed,and will include the enclosing parentheses. Other normalization (such as removing redundant parentheses or simplifying occurrence indicators) is at the discretion of the parser.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// elementDecl
				/// </java-name>
				[Dot42.DexImport("elementDecl", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1025)]
				void ElementDecl(string name, string model) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Report an attribute type declaration.</para><para>Only the effective (first) declaration for an attribute will be reported. The type will be one of the strings "CDATA", "ID", "IDREF", "IDREFS", "NMTOKEN", "NMTOKENS", "ENTITY", "ENTITIES", a parenthesized token group with the separator "|" and all whitespace removed, or the word "NOTATION" followed by a space followed by a parenthesized token group with all whitespace removed.</para><para>The value will be the value as reported to applications, appropriately normalized and with entity and character references expanded. </para><para></para>        
				/// </summary>
				/// <java-name>
				/// attributeDecl
				/// </java-name>
				[Dot42.DexImport("attributeDecl", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/la" +
    "ng/String;)V", AccessFlags = 1025)]
				void AttributeDecl(string eName, string aName, string type, string mode, string value) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Report an internal entity declaration.</para><para>Only the effective (first) declaration for each entity will be reported. All parameter entities in the value will be expanded, but general entities will not.</para><para><para>externalEntityDecl </para><simplesectsep></simplesectsep><para>org.xml.sax.DTDHandler::unparsedEntityDecl </para></para>        
				/// </summary>
				/// <java-name>
				/// internalEntityDecl
				/// </java-name>
				[Dot42.DexImport("internalEntityDecl", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1025)]
				void InternalEntityDecl(string name, string value) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Report a parsed external entity declaration.</para><para>Only the effective (first) declaration for each entity will be reported.</para><para>If the system identifier is a URL, the parser must resolve it fully before passing it to the application.</para><para><para>internalEntityDecl </para><simplesectsep></simplesectsep><para>org.xml.sax.DTDHandler::unparsedEntityDecl </para></para>        
				/// </summary>
				/// <java-name>
				/// externalEntityDecl
				/// </java-name>
				[Dot42.DexImport("externalEntityDecl", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1025)]
				void ExternalEntityDecl(string name, string publicId, string systemId) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>SAX2 extension to augment the per-attribute information provided though Attributes. If an implementation supports this extension, the attributes provided in ContentHandler.startElement()  will implement this interface, and the <b></b> feature flag will have the value <b>true</b>.</para><para><blockquote><para><b>This module, both source code and documentation, is in the Public Domain, and comes with <b>NO WARRANTY</b>.</b> </para></blockquote></para><para>XMLReader implementations are not required to support this information, and it is not part of core-only SAX2 distributions.</para><para>Note that if an attribute was defaulted (<b>!isSpecified()</b>) it will of necessity also have been declared (<b>isDeclared()</b>) in the DTD. Similarly if an attribute's type is anything except CDATA, then it must have been declared. </para><para><para>SAX 2.0 (extensions 1.1 alpha) </para><para>David Brownell </para><para>TBS </para></para>    
		/// </summary>
		/// <java-name>
		/// org/xml/sax/ext/Attributes2
		/// </java-name>
		[Dot42.DexImport("org/xml/sax/ext/Attributes2", AccessFlags = 1537)]
		public partial interface IAttributes2 : global::Org.Xml.Sax.IAttributes
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Returns false unless the attribute was declared in the DTD. This helps distinguish two kinds of attributes that SAX reports as CDATA: ones that were declared (and hence are usually valid), and those that were not (and which are never valid).</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if the attribute was declared in the DTD, false otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isDeclared
				/// </java-name>
				[Dot42.DexImport("isDeclared", "(I)Z", AccessFlags = 1025)]
				bool IsDeclared(int index) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns false unless the attribute was declared in the DTD. This helps distinguish two kinds of attributes that SAX reports as CDATA: ones that were declared (and hence are usually valid), and those that were not (and which are never valid).</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if the attribute was declared in the DTD, false otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isDeclared
				/// </java-name>
				[Dot42.DexImport("isDeclared", "(Ljava/lang/String;)Z", AccessFlags = 1025)]
				bool IsDeclared(string index) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns false unless the attribute was declared in the DTD. This helps distinguish two kinds of attributes that SAX reports as CDATA: ones that were declared (and hence are usually valid), and those that were not (and which are never valid).</para><para>Remember that since DTDs do not "understand" namespaces, the namespace URI associated with an attribute may not have come from the DTD. The declaration will have applied to the attribute's <b>qName</b>.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if the attribute was declared in the DTD, false otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isDeclared
				/// </java-name>
				[Dot42.DexImport("isDeclared", "(Ljava/lang/String;Ljava/lang/String;)Z", AccessFlags = 1025)]
				bool IsDeclared(string uri, string localName) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns true unless the attribute value was provided by DTD defaulting.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if the value was found in the XML text, false if the value was provided by DTD defaulting. </para>
				/// </returns>
				/// <java-name>
				/// isSpecified
				/// </java-name>
				[Dot42.DexImport("isSpecified", "(I)Z", AccessFlags = 1025)]
				bool IsSpecified(int index) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns true unless the attribute value was provided by DTD defaulting.</para><para>Remember that since DTDs do not "understand" namespaces, the namespace URI associated with an attribute may not have come from the DTD. The declaration will have applied to the attribute's <b>qName</b>.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if the value was found in the XML text, false if the value was provided by DTD defaulting. </para>
				/// </returns>
				/// <java-name>
				/// isSpecified
				/// </java-name>
				[Dot42.DexImport("isSpecified", "(Ljava/lang/String;Ljava/lang/String;)Z", AccessFlags = 1025)]
				bool IsSpecified(string uri, string localName) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns true unless the attribute value was provided by DTD defaulting.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if the value was found in the XML text, false if the value was provided by DTD defaulting. </para>
				/// </returns>
				/// <java-name>
				/// isSpecified
				/// </java-name>
				[Dot42.DexImport("isSpecified", "(Ljava/lang/String;)Z", AccessFlags = 1025)]
				bool IsSpecified(string index) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>SAX2 extension to augment the entity information provided though a Locator. If an implementation supports this extension, the Locator provided in ContentHandler.setDocumentLocator()  will implement this interface, and the <b></b> feature flag will have the value <b>true</b>.</para><para><blockquote><para><b>This module, both source code and documentation, is in the Public Domain, and comes with <b>NO WARRANTY</b>.</b> </para></blockquote></para><para>XMLReader implementations are not required to support this information, and it is not part of core-only SAX2 distributions.</para><para><para>SAX 2.0 (extensions 1.1 alpha) </para><para>David Brownell </para><para>TBS </para></para>    
		/// </summary>
		/// <java-name>
		/// org/xml/sax/ext/Locator2
		/// </java-name>
		[Dot42.DexImport("org/xml/sax/ext/Locator2", AccessFlags = 1537)]
		public partial interface ILocator2 : global::Org.Xml.Sax.ILocator
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Returns the version of XML used for the entity. This will normally be the identifier from the current entity's <b>&lt;?xml version='...' ...?&gt;</b> declaration, or be defaulted by the parser.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Identifier for the XML version being used to interpret the entity's text, or null if that information is not yet available in the current parsing state. </para>
				/// </returns>
				/// <java-name>
				/// getXMLVersion
				/// </java-name>
				[Dot42.DexImport("getXMLVersion", "()Ljava/lang/String;", AccessFlags = 1025)]
				string GetXMLVersion() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the name of the character encoding for the entity. If the encoding was declared externally (for example, in a MIME Content-Type header), that will be the name returned. Else if there was an <b>&lt;?xml ...encoding='...'?&gt;</b> declaration at the start of the document, that encoding name will be returned. Otherwise the encoding will been inferred (normally to be UTF-8, or some UTF-16 variant), and that inferred name will be returned.</para><para>When an InputSource is used to provide an entity's character stream, this method returns the encoding provided in that input stream.</para><para>Note that some recent W3C specifications require that text in some encodings be normalized, using Unicode Normalization Form C, before processing. Such normalization must be performed by applications, and would normally be triggered based on the value returned by this method.</para><para>Encoding names may be those used by the underlying JVM, and comparisons should be case-insensitive.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Name of the character encoding being used to interpret<ul><li><para>the entity's text, or null if this was not provided for a * character stream passed through an InputSource or is otherwise not yet available in the current parsing state. </para></li></ul></para>
				/// </returns>
				/// <java-name>
				/// getEncoding
				/// </java-name>
				[Dot42.DexImport("getEncoding", "()Ljava/lang/String;", AccessFlags = 1025)]
				string GetEncoding() /* MethodBuilder.Create */ ;

		}

}


