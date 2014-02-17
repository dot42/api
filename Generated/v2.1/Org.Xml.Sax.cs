// Copyright (C) 2014 dot42
//
// Original filename: Org.Xml.Sax.cs
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
namespace Org.Xml.Sax
{
		/// <summary>
		/// <para>Interface for an element's attribute specifications.</para><para><blockquote><para><b>This module, both source code and documentation, is in the Public Domain, and comes with <b>NO WARRANTY</b>.</b> See  for further information. </para></blockquote></para><para>This is the original SAX1 interface for reporting an element's attributes. Unlike the new Attributes interface, it does not support Namespace-related information.</para><para>When an attribute list is supplied as part of a startElement event, the list will return valid results only during the scope of the event; once the event handler returns control to the parser, the attribute list is invalid. To save a persistent copy of the attribute list, use the SAX1 AttributeListImpl helper class.</para><para>An attribute list includes only attributes that have been specified or defaulted: #IMPLIED attributes will not be included.</para><para>There are two ways for the SAX application to obtain information from the AttributeList. First, it can iterate through the entire list:</para><para><pre>
		///    public void startElement (String name, AttributeList atts) {
		///      for (int i = 0; i &lt; atts.getLength(); i++) {
		///        String name = atts.getName(i);
		///        String type = atts.getType(i);
		///        String value = atts.getValue(i);
		///        [...]
		///      }
		///    }
		///    </pre></para><para>(Note that the result of getLength() will be zero if there are no attributes.)</para><para>As an alternative, the application can request the value or type of specific attributes:</para><para><pre>
		///    public void startElement (String name, AttributeList atts) {
		///      String identifier = atts.getValue("id");
		///      String label = atts.getValue("label");
		///      [...]
		///    }
		///    </pre></para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>This interface has been replaced by the SAX2 Attributes interface, which includes Namespace support. </para></xrefdescription></xrefsect><para>SAX 1.0 </para><para>David Megginson </para><para>2.0.1 (sax2r2) </para><para>org.xml.sax.DocumentHandler::startElement startElement </para><simplesectsep></simplesectsep><para>org.xml.sax.helpers.AttributeListImpl AttributeListImpl </para></para>    
		/// </summary>
		/// <java-name>
		/// org/xml/sax/AttributeList
		/// </java-name>
		[Dot42.DexImport("org/xml/sax/AttributeList", AccessFlags = 1537)]
		public partial interface IAttributeList
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Return the number of attributes in this list.</para><para>The SAX parser may provide attributes in any arbitrary order, regardless of the order in which they were declared or specified. The number of attributes may be zero.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The number of attributes in the list. </para>
				/// </returns>
				/// <java-name>
				/// getLength
				/// </java-name>
				[Dot42.DexImport("getLength", "()I", AccessFlags = 1025)]
				int GetLength() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Return the name of an attribute in this list (by position).</para><para>The names must be unique: the SAX parser shall not include the same attribute twice. Attributes without values (those declared #IMPLIED without a value specified in the start tag) will be omitted from the list.</para><para>If the attribute name has a namespace prefix, the prefix will still be attached.</para><para><para>getLength </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The name of the indexed attribute, or null if the index is out of range. </para>
				/// </returns>
				/// <java-name>
				/// getName
				/// </java-name>
				[Dot42.DexImport("getName", "(I)Ljava/lang/String;", AccessFlags = 1025)]
				string GetName(int i) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Return the type of an attribute in the list (by position).</para><para>The attribute type is one of the strings "CDATA", "ID", "IDREF", "IDREFS", "NMTOKEN", "NMTOKENS", "ENTITY", "ENTITIES", or "NOTATION" (always in upper case).</para><para>If the parser has not read a declaration for the attribute, or if the parser does not report attribute types, then it must return the value "CDATA" as stated in the XML 1.0 Recommentation (clause 3.3.3, "Attribute-Value Normalization").</para><para>For an enumerated attribute that is not a notation, the parser will report the type as "NMTOKEN".</para><para><para>getLength </para><simplesectsep></simplesectsep><para>getType(java.lang.String) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The attribute type as a string, or null if the index is out of range. </para>
				/// </returns>
				/// <java-name>
				/// getType
				/// </java-name>
				[Dot42.DexImport("getType", "(I)Ljava/lang/String;", AccessFlags = 1025)]
				string GetType(int i) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Return the value of an attribute in the list (by position).</para><para>If the attribute value is a list of tokens (IDREFS, ENTITIES, or NMTOKENS), the tokens will be concatenated into a single string separated by whitespace.</para><para><para>getLength </para><simplesectsep></simplesectsep><para>getValue(java.lang.String) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The attribute value as a string, or null if the index is out of range. </para>
				/// </returns>
				/// <java-name>
				/// getValue
				/// </java-name>
				[Dot42.DexImport("getValue", "(I)Ljava/lang/String;", AccessFlags = 1025)]
				string GetValue(int i) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Return the type of an attribute in the list (by position).</para><para>The attribute type is one of the strings "CDATA", "ID", "IDREF", "IDREFS", "NMTOKEN", "NMTOKENS", "ENTITY", "ENTITIES", or "NOTATION" (always in upper case).</para><para>If the parser has not read a declaration for the attribute, or if the parser does not report attribute types, then it must return the value "CDATA" as stated in the XML 1.0 Recommentation (clause 3.3.3, "Attribute-Value Normalization").</para><para>For an enumerated attribute that is not a notation, the parser will report the type as "NMTOKEN".</para><para><para>getLength </para><simplesectsep></simplesectsep><para>getType(java.lang.String) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The attribute type as a string, or null if the index is out of range. </para>
				/// </returns>
				/// <java-name>
				/// getType
				/// </java-name>
				[Dot42.DexImport("getType", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1025)]
				string GetType(string i) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Return the value of an attribute in the list (by position).</para><para>If the attribute value is a list of tokens (IDREFS, ENTITIES, or NMTOKENS), the tokens will be concatenated into a single string separated by whitespace.</para><para><para>getLength </para><simplesectsep></simplesectsep><para>getValue(java.lang.String) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The attribute value as a string, or null if the index is out of range. </para>
				/// </returns>
				/// <java-name>
				/// getValue
				/// </java-name>
				[Dot42.DexImport("getValue", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1025)]
				string GetValue(string i) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>Receive notification of the logical content of a document.</para><para><blockquote><para><b>This module, both source code and documentation, is in the Public Domain, and comes with <b>NO WARRANTY</b>.</b> See  for further information. </para></blockquote></para><para>This is the main interface that most SAX applications implement: if the application needs to be informed of basic parsing events, it implements this interface and registers an instance with the SAX parser using the setContentHandler method. The parser uses the instance to report basic document-related events like the start and end of elements and character data.</para><para>The order of events in this interface is very important, and mirrors the order of information in the document itself. For example, all of an element's content (character data, processing instructions, and/or subelements) will appear, in order, between the startElement event and the corresponding endElement event.</para><para>This interface is similar to the now-deprecated SAX 1.0 DocumentHandler interface, but it adds support for Namespaces and for reporting skipped entities (in non-validating XML processors).</para><para>Implementors should note that there is also a <code>ContentHandler</code> class in the <code>java.net</code> package; that means that it's probably a bad idea to do</para><para><pre>import java.net.*;
		///    import org.xml.sax.*;
		///    </pre></para><para>In fact, "import ...*" is usually a sign of sloppy programming anyway, so the user should consider this a feature rather than a bug.</para><para><para>SAX 2.0 </para><para>David Megginson </para><para>2.0.1+ (sax2r3pre1) </para><para>org.xml.sax.XMLReader </para><simplesectsep></simplesectsep><para>org.xml.sax.DTDHandler </para><simplesectsep></simplesectsep><para>org.xml.sax.ErrorHandler </para></para>    
		/// </summary>
		/// <java-name>
		/// org/xml/sax/ContentHandler
		/// </java-name>
		[Dot42.DexImport("org/xml/sax/ContentHandler", AccessFlags = 1537)]
		public partial interface IContentHandler
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Receive an object for locating the origin of SAX document events.</para><para>SAX parsers are strongly encouraged (though not absolutely required) to supply a locator: if it does so, it must supply the locator to the application by invoking this method before invoking any of the other methods in the ContentHandler interface.</para><para>The locator allows the application to determine the end position of any document-related event, even if the parser is not reporting an error. Typically, the application will use this information for reporting its own errors (such as character content that does not match an application's business rules). The information returned by the locator is probably not sufficient for use with a search engine.</para><para>Note that the locator will return correct information only during the invocation SAX event callbacks after startDocument returns and before endDocument is called. The application should not attempt to use it at any other time.</para><para><para>org.xml.sax.Locator </para></para>        
				/// </summary>
				/// <java-name>
				/// setDocumentLocator
				/// </java-name>
				[Dot42.DexImport("setDocumentLocator", "(Lorg/xml/sax/Locator;)V", AccessFlags = 1025)]
				void SetDocumentLocator(global::Org.Xml.Sax.ILocator locator) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Receive notification of the beginning of a document.</para><para>The SAX parser will invoke this method only once, before any other event callbacks (except for setDocumentLocator).</para><para><para>endDocument </para></para>        
				/// </summary>
				/// <java-name>
				/// startDocument
				/// </java-name>
				[Dot42.DexImport("startDocument", "()V", AccessFlags = 1025)]
				void StartDocument() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Receive notification of the end of a document.</para><para><b>There is an apparent contradiction between the documentation for this method and the documentation for org.xml.sax.ErrorHandler#fatalError. Until this ambiguity is resolved in a future major release, clients should make no assumptions about whether endDocument() will or will not be invoked when the parser has reported a fatalError() or thrown an exception.</b></para><para>The SAX parser will invoke this method only once, and it will be the last method invoked during the parse. The parser shall not invoke this method until it has either abandoned parsing (because of an unrecoverable error) or reached the end of input.</para><para><para>startDocument </para></para>        
				/// </summary>
				/// <java-name>
				/// endDocument
				/// </java-name>
				[Dot42.DexImport("endDocument", "()V", AccessFlags = 1025)]
				void EndDocument() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Begin the scope of a prefix-URI Namespace mapping.</para><para>The information from this event is not necessary for normal Namespace processing: the SAX XML reader will automatically replace prefixes for element and attribute names when the <code></code> feature is <b>true</b> (the default).</para><para>There are cases, however, when applications need to use prefixes in character data or in attribute values, where they cannot safely be expanded automatically; the start/endPrefixMapping event supplies the information to the application to expand prefixes in those contexts itself, if necessary.</para><para>Note that start/endPrefixMapping events are not guaranteed to be properly nested relative to each other: all startPrefixMapping events will occur immediately before the corresponding startElement event, and all endPrefixMapping events will occur immediately after the corresponding endElement event, but their order is not otherwise guaranteed.</para><para>There should never be start/endPrefixMapping events for the "xml" prefix, since it is predeclared and immutable.</para><para><para>endPrefixMapping </para><simplesectsep></simplesectsep><para>startElement </para></para>        
				/// </summary>
				/// <java-name>
				/// startPrefixMapping
				/// </java-name>
				[Dot42.DexImport("startPrefixMapping", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1025)]
				void StartPrefixMapping(string prefix, string uri) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>End the scope of a prefix-URI mapping.</para><para>See startPrefixMapping for details. These events will always occur immediately after the corresponding endElement event, but the order of endPrefixMapping events is not otherwise guaranteed.</para><para><para>startPrefixMapping </para><simplesectsep></simplesectsep><para>endElement </para></para>        
				/// </summary>
				/// <java-name>
				/// endPrefixMapping
				/// </java-name>
				[Dot42.DexImport("endPrefixMapping", "(Ljava/lang/String;)V", AccessFlags = 1025)]
				void EndPrefixMapping(string prefix) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Receive notification of the beginning of an element.</para><para>The Parser will invoke this method at the beginning of every element in the XML document; there will be a corresponding endElement event for every startElement event (even when the element is empty). All of the element's content will be reported, in order, before the corresponding endElement event.</para><para>This event allows up to three name components for each element:</para><para><ol><li><para>the Namespace URI; </para></li><li><para>the local name; and </para></li><li><para>the qualified (prefixed) name. </para></li></ol></para><para>Any or all of these may be provided, depending on the values of the <b></b> and the <b></b> properties:</para><para><ul><li><para>the Namespace URI and local name are required when the namespaces property is <b>true</b> (the default), and are optional when the namespaces property is <b>false</b> (if one is specified, both must be); </para></li><li><para>the qualified name is required when the namespace-prefixes property is <b>true</b>, and is optional when the namespace-prefixes property is <b>false</b> (the default). </para></li></ul></para><para>Note that the attribute list provided will contain only attributes with explicit values (specified or defaulted): #IMPLIED attributes will be omitted. The attribute list will contain attributes used for Namespace declarations (xmlns* attributes) only if the <code></code> property is true (it is false by default, and support for a true value is optional).</para><para>Like characters(), attribute values may have characters that need more than one <code>char</code> value. </para><para><para>endElement </para><simplesectsep></simplesectsep><para>org.xml.sax.Attributes </para><simplesectsep></simplesectsep><para>org.xml.sax.helpers.AttributesImpl </para></para>        
				/// </summary>
				/// <java-name>
				/// startElement
				/// </java-name>
				[Dot42.DexImport("startElement", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lorg/xml/sax/Attributes;)V" +
    "", AccessFlags = 1025)]
				void StartElement(string uri, string localName, string qName, global::Org.Xml.Sax.IAttributes atts) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Receive notification of the end of an element.</para><para>The SAX parser will invoke this method at the end of every element in the XML document; there will be a corresponding startElement event for every endElement event (even when the element is empty).</para><para>For information on the names, see startElement.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// endElement
				/// </java-name>
				[Dot42.DexImport("endElement", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1025)]
				void EndElement(string uri, string localName, string qName) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Receive notification of character data.</para><para>The Parser will call this method to report each chunk of character data. SAX parsers may return all contiguous character data in a single chunk, or they may split it into several chunks; however, all of the characters in any single event must come from the same external entity so that the Locator provides useful information.</para><para>The application must not attempt to read from the array outside of the specified range.</para><para>Individual characters may consist of more than one Java <code>char</code> value. There are two important cases where this happens, because characters can't be represented in just sixteen bits. In one case, characters are represented in a <b>Surrogate Pair</b>, using two special Unicode values. Such characters are in the so-called "Astral Planes", with a code point above U+FFFF. A second case involves composite characters, such as a base character combining with one or more accent characters. </para><para>Your code should not assume that algorithms using <code>char</code>-at-a-time idioms will be working in character units; in some cases they will split characters. This is relevant wherever XML permits arbitrary characters, such as attribute values, processing instruction data, and comments as well as in data reported from this method. It's also generally relevant whenever Java code manipulates internationalized text; the issue isn't unique to XML.</para><para>Note that some parsers will report whitespace in element content using the ignorableWhitespace method rather than this one (validating parsers <b>must</b> do so).</para><para><para>ignorableWhitespace </para><simplesectsep></simplesectsep><para>org.xml.sax.Locator </para></para>        
				/// </summary>
				/// <java-name>
				/// characters
				/// </java-name>
				[Dot42.DexImport("characters", "([CII)V", AccessFlags = 1025)]
				void Characters(char[] ch, int start, int length) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Receive notification of ignorable whitespace in element content.</para><para>Validating Parsers must use this method to report each chunk of whitespace in element content (see the W3C XML 1.0 recommendation, section 2.10): non-validating parsers may also use this method if they are capable of parsing and using content models.</para><para>SAX parsers may return all contiguous whitespace in a single chunk, or they may split it into several chunks; however, all of the characters in any single event must come from the same external entity, so that the Locator provides useful information.</para><para>The application must not attempt to read from the array outside of the specified range.</para><para><para>characters </para></para>        
				/// </summary>
				/// <java-name>
				/// ignorableWhitespace
				/// </java-name>
				[Dot42.DexImport("ignorableWhitespace", "([CII)V", AccessFlags = 1025)]
				void IgnorableWhitespace(char[] ch, int start, int length) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Receive notification of a processing instruction.</para><para>The Parser will invoke this method once for each processing instruction found: note that processing instructions may occur before or after the main document element.</para><para>A SAX parser must never report an XML declaration (XML 1.0, section 2.8) or a text declaration (XML 1.0, section 4.3.1) using this method.</para><para>Like characters(), processing instruction data may have characters that need more than one <code>char</code> value. </para><para></para>        
				/// </summary>
				/// <java-name>
				/// processingInstruction
				/// </java-name>
				[Dot42.DexImport("processingInstruction", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1025)]
				void ProcessingInstruction(string target, string data) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Receive notification of a skipped entity. This is not called for entity references within markup constructs such as element start tags or markup declarations. (The XML recommendation requires reporting skipped external entities. SAX also reports internal entity expansion/non-expansion, except within markup constructs.)</para><para>The Parser will invoke this method each time the entity is skipped. Non-validating processors may skip entities if they have not seen the declarations (because, for example, the entity was declared in an external DTD subset). All processors may skip external entities, depending on the values of the <code></code> and the <code></code> properties.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// skippedEntity
				/// </java-name>
				[Dot42.DexImport("skippedEntity", "(Ljava/lang/String;)V", AccessFlags = 1025)]
				void SkippedEntity(string name) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>Basic interface for resolving entities.</para><para><blockquote><para><b>This module, both source code and documentation, is in the Public Domain, and comes with <b>NO WARRANTY</b>.</b> See  for further information. </para></blockquote></para><para>If a SAX application needs to implement customized handling for external entities, it must implement this interface and register an instance with the SAX driver using the setEntityResolver method.</para><para>The XML reader will then allow the application to intercept any external entities (including the external DTD subset and external parameter entities, if any) before including them.</para><para>Many SAX applications will not need to implement this interface, but it will be especially useful for applications that build XML documents from databases or other specialised input sources, or for applications that use URI types other than URLs.</para><para>The following resolver would provide the application with a special character stream for the entity with the system identifier "http://www.myhost.com/today":</para><para><pre>
		///    import org.xml.sax.EntityResolver;
		///    import org.xml.sax.InputSource;
		/// 
		///    public class MyResolver implements EntityResolver {
		///      public InputSource resolveEntity (String publicId, String systemId)
		///      {
		///        if (systemId.equals("http://www.myhost.com/today")) {
		///                 // return a special input source
		///          MyReader reader = new MyReader();
		///          return new InputSource(reader);
		///        } else {
		///                 // use the default behaviour
		///          return null;
		///        }
		///      }
		///    }
		///    </pre></para><para>The application can also use this interface to redirect system identifiers to local URIs or to look up replacements in a catalog (possibly by using the public identifier).</para><para><para>SAX 1.0 </para><para>David Megginson </para><para>2.0.1 (sax2r2) </para><para>org.xml.sax.XMLReader::setEntityResolver </para><simplesectsep></simplesectsep><para>org.xml.sax.InputSource </para></para>    
		/// </summary>
		/// <java-name>
		/// org/xml/sax/EntityResolver
		/// </java-name>
		[Dot42.DexImport("org/xml/sax/EntityResolver", AccessFlags = 1537)]
		public partial interface IEntityResolver
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Allow the application to resolve external entities.</para><para>The parser will call this method before opening any external entity except the top-level document entity. Such entities include the external DTD subset and external parameter entities referenced within the DTD (in either case, only if the parser reads external parameter entities), and external general entities referenced within the document element (if the parser reads external general entities). The application may request that the parser locate the entity itself, that it use an alternative URI, or that it use data provided by the application (as a character or byte input stream).</para><para>Application writers can use this method to redirect external system identifiers to secure and/or local URIs, to look up public identifiers in a catalogue, or to read an entity from a database or other input source (including, for example, a dialog box). Neither XML nor SAX specifies a preferred policy for using public or system IDs to resolve resources. However, SAX specifies how to interpret any InputSource returned by this method, and that if none is returned, then the system ID will be dereferenced as a URL. </para><para>If the system identifier is a URL, the SAX parser must resolve it fully before reporting it to the application.</para><para><para>org.xml.sax.InputSource </para></para>        
				/// </summary>
				/// <returns>
				/// <para>An InputSource object describing the new input source, or null to request that the parser open a regular URI connection to the system identifier. </para>
				/// </returns>
				/// <java-name>
				/// resolveEntity
				/// </java-name>
				[Dot42.DexImport("resolveEntity", "(Ljava/lang/String;Ljava/lang/String;)Lorg/xml/sax/InputSource;", AccessFlags = 1025)]
				global::Org.Xml.Sax.InputSource ResolveEntity(string publicId, string systemId) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>Basic interface for SAX error handlers.</para><para><blockquote><para><b>This module, both source code and documentation, is in the Public Domain, and comes with <b>NO WARRANTY</b>.</b> See  for further information. </para></blockquote></para><para>If a SAX application needs to implement customized error handling, it must implement this interface and then register an instance with the XML reader using the setErrorHandler method. The parser will then report all errors and warnings through this interface.</para><para><b>WARNING:</b> If an application does <b>not</b> register an ErrorHandler, XML parsing errors will go unreported, except that <b>SAXParseException</b>s will be thrown for fatal errors. In order to detect validity errors, an ErrorHandler that does something with error() calls must be registered.</para><para>For XML processing errors, a SAX driver must use this interface in preference to throwing an exception: it is up to the application to decide whether to throw an exception for different types of errors and warnings. Note, however, that there is no requirement that the parser continue to report additional errors after a call to fatalError. In other words, a SAX driver class may throw an exception after reporting any fatalError. Also parsers may throw appropriate exceptions for non-XML errors. For example, XMLReader.parse() would throw an IOException for errors accessing entities or the document.</para><para><para>SAX 1.0 </para><para>David Megginson </para><para>2.0.1+ (sax2r3pre1) </para><para>org.xml.sax.XMLReader::setErrorHandler </para><simplesectsep></simplesectsep><para>org.xml.sax.SAXParseException </para></para>    
		/// </summary>
		/// <java-name>
		/// org/xml/sax/ErrorHandler
		/// </java-name>
		[Dot42.DexImport("org/xml/sax/ErrorHandler", AccessFlags = 1537)]
		public partial interface IErrorHandler
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Receive notification of a warning.</para><para>SAX parsers will use this method to report conditions that are not errors or fatal errors as defined by the XML recommendation. The default behaviour is to take no action.</para><para>The SAX parser must continue to provide normal parsing events after invoking this method: it should still be possible for the application to process the document through to the end.</para><para>Filters may use this method to report other, non-XML warnings as well.</para><para><para>org.xml.sax.SAXParseException </para></para>        
				/// </summary>
				/// <java-name>
				/// warning
				/// </java-name>
				[Dot42.DexImport("warning", "(Lorg/xml/sax/SAXParseException;)V", AccessFlags = 1025)]
				void Warning(global::Org.Xml.Sax.SAXParseException exception) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Receive notification of a recoverable error.</para><para>This corresponds to the definition of "error" in section 1.2 of the W3C XML 1.0 Recommendation. For example, a validating parser would use this callback to report the violation of a validity constraint. The default behaviour is to take no action.</para><para>The SAX parser must continue to provide normal parsing events after invoking this method: it should still be possible for the application to process the document through to the end. If the application cannot do so, then the parser should report a fatal error even if the XML recommendation does not require it to do so.</para><para>Filters may use this method to report other, non-XML errors as well.</para><para><para>org.xml.sax.SAXParseException </para></para>        
				/// </summary>
				/// <java-name>
				/// error
				/// </java-name>
				[Dot42.DexImport("error", "(Lorg/xml/sax/SAXParseException;)V", AccessFlags = 1025)]
				void Error(global::Org.Xml.Sax.SAXParseException exception) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Receive notification of a non-recoverable error.</para><para><b>There is an apparent contradiction between the documentation for this method and the documentation for org.xml.sax.ContentHandler#endDocument. Until this ambiguity is resolved in a future major release, clients should make no assumptions about whether endDocument() will or will not be invoked when the parser has reported a fatalError() or thrown an exception.</b></para><para>This corresponds to the definition of "fatal error" in section 1.2 of the W3C XML 1.0 Recommendation. For example, a parser would use this callback to report the violation of a well-formedness constraint.</para><para>The application must assume that the document is unusable after the parser has invoked this method, and should continue (if at all) only for the sake of collecting additional error messages: in fact, SAX parsers are free to stop reporting any other events once this method has been invoked.</para><para><para>org.xml.sax.SAXParseException </para></para>        
				/// </summary>
				/// <java-name>
				/// fatalError
				/// </java-name>
				[Dot42.DexImport("fatalError", "(Lorg/xml/sax/SAXParseException;)V", AccessFlags = 1025)]
				void FatalError(global::Org.Xml.Sax.SAXParseException exception) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>A single input source for an XML entity.</para><para><blockquote><para><b>This module, both source code and documentation, is in the Public Domain, and comes with <b>NO WARRANTY</b>.</b> See  for further information. </para></blockquote></para><para>This class allows a SAX application to encapsulate information about an input source in a single object, which may include a public identifier, a system identifier, a byte stream (possibly with a specified encoding), and/or a character stream.</para><para>There are two places that the application can deliver an input source to the parser: as the argument to the Parser.parse method, or as the return value of the EntityResolver.resolveEntity method.</para><para>The SAX parser will use the InputSource object to determine how to read XML input. If there is a character stream available, the parser will read that stream directly, disregarding any text encoding declaration found in that stream. If there is no character stream, but there is a byte stream, the parser will use that byte stream, using the encoding specified in the InputSource or else (if no encoding is specified) autodetecting the character encoding using an algorithm such as the one in the XML specification. If neither a character stream nor a byte stream is available, the parser will attempt to open a URI connection to the resource identified by the system identifier.</para><para>An InputSource object belongs to the application: the SAX parser shall never modify it in any way (it may modify a copy if necessary). However, standard processing of both byte and character streams is to close them on as part of end-of-parse cleanup, so applications should not attempt to re-use such streams after they have been handed to a parser. </para><para><para>SAX 1.0 </para><para>David Megginson </para><para>2.0.1 (sax2r2) </para><para>org.xml.sax.XMLReader::parse(org.xml.sax.InputSource) </para><simplesectsep></simplesectsep><para>org.xml.sax.EntityResolver::resolveEntity </para><simplesectsep></simplesectsep><para>java.io.InputStream </para><simplesectsep></simplesectsep><para>java.io.Reader </para></para>    
		/// </summary>
		/// <java-name>
		/// org/xml/sax/InputSource
		/// </java-name>
		[Dot42.DexImport("org/xml/sax/InputSource", AccessFlags = 33)]
		public partial class InputSource
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Zero-argument default constructor.</para><para><para>setPublicId </para><simplesectsep></simplesectsep><para>setSystemId </para><simplesectsep></simplesectsep><para>setByteStream </para><simplesectsep></simplesectsep><para>setCharacterStream </para><simplesectsep></simplesectsep><para>setEncoding </para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public InputSource() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Create a new input source with a byte stream.</para><para>Application writers should use setSystemId() to provide a base for resolving relative URIs, may use setPublicId to include a public identifier, and may use setEncoding to specify the object's character encoding.</para><para><para>setPublicId </para><simplesectsep></simplesectsep><para>setSystemId </para><simplesectsep></simplesectsep><para>setEncoding </para><simplesectsep></simplesectsep><para>setByteStream </para><simplesectsep></simplesectsep><para>setCharacterStream </para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public InputSource(string byteStream) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Create a new input source with a byte stream.</para><para>Application writers should use setSystemId() to provide a base for resolving relative URIs, may use setPublicId to include a public identifier, and may use setEncoding to specify the object's character encoding.</para><para><para>setPublicId </para><simplesectsep></simplesectsep><para>setSystemId </para><simplesectsep></simplesectsep><para>setEncoding </para><simplesectsep></simplesectsep><para>setByteStream </para><simplesectsep></simplesectsep><para>setCharacterStream </para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/io/InputStream;)V", AccessFlags = 1)]
				public InputSource(global::Java.Io.InputStream byteStream) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Create a new input source with a byte stream.</para><para>Application writers should use setSystemId() to provide a base for resolving relative URIs, may use setPublicId to include a public identifier, and may use setEncoding to specify the object's character encoding.</para><para><para>setPublicId </para><simplesectsep></simplesectsep><para>setSystemId </para><simplesectsep></simplesectsep><para>setEncoding </para><simplesectsep></simplesectsep><para>setByteStream </para><simplesectsep></simplesectsep><para>setCharacterStream </para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/io/Reader;)V", AccessFlags = 1)]
				public InputSource(global::Java.Io.Reader byteStream) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Set the public identifier for this input source.</para><para>The public identifier is always optional: if the application writer includes one, it will be provided as part of the location information.</para><para><para>getPublicId </para><simplesectsep></simplesectsep><para>org.xml.sax.Locator::getPublicId </para><simplesectsep></simplesectsep><para>org.xml.sax.SAXParseException::getPublicId </para></para>        
				/// </summary>
				/// <java-name>
				/// setPublicId
				/// </java-name>
				[Dot42.DexImport("setPublicId", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetPublicId(string publicId) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Get the public identifier for this input source.</para><para><para>setPublicId </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The public identifier, or null if none was supplied. </para>
				/// </returns>
				/// <java-name>
				/// getPublicId
				/// </java-name>
				[Dot42.DexImport("getPublicId", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetPublicId() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Set the system identifier for this input source.</para><para>The system identifier is optional if there is a byte stream or a character stream, but it is still useful to provide one, since the application can use it to resolve relative URIs and can include it in error messages and warnings (the parser will attempt to open a connection to the URI only if there is no byte stream or character stream specified).</para><para>If the application knows the character encoding of the object pointed to by the system identifier, it can register the encoding using the setEncoding method.</para><para>If the system identifier is a URL, it must be fully resolved (it may not be a relative URL).</para><para><para>setEncoding </para><simplesectsep></simplesectsep><para>getSystemId </para><simplesectsep></simplesectsep><para>org.xml.sax.Locator::getSystemId </para><simplesectsep></simplesectsep><para>org.xml.sax.SAXParseException::getSystemId </para></para>        
				/// </summary>
				/// <java-name>
				/// setSystemId
				/// </java-name>
				[Dot42.DexImport("setSystemId", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetSystemId(string systemId) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Get the system identifier for this input source.</para><para>The getEncoding method will return the character encoding of the object pointed to, or null if unknown.</para><para>If the system ID is a URL, it will be fully resolved.</para><para><para>setSystemId </para><simplesectsep></simplesectsep><para>getEncoding </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The system identifier, or null if none was supplied. </para>
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
				/// <para>Set the byte stream for this input source.</para><para>The SAX parser will ignore this if there is also a character stream specified, but it will use a byte stream in preference to opening a URI connection itself.</para><para>If the application knows the character encoding of the byte stream, it should set it with the setEncoding method.</para><para><para>setEncoding </para><simplesectsep></simplesectsep><para>getByteStream </para><simplesectsep></simplesectsep><para>getEncoding </para><simplesectsep></simplesectsep><para>java.io.InputStream </para></para>        
				/// </summary>
				/// <java-name>
				/// setByteStream
				/// </java-name>
				[Dot42.DexImport("setByteStream", "(Ljava/io/InputStream;)V", AccessFlags = 1)]
				public virtual void SetByteStream(global::Java.Io.InputStream byteStream) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Get the byte stream for this input source.</para><para>The getEncoding method will return the character encoding for this byte stream, or null if unknown.</para><para><para>getEncoding </para><simplesectsep></simplesectsep><para>setByteStream </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The byte stream, or null if none was supplied. </para>
				/// </returns>
				/// <java-name>
				/// getByteStream
				/// </java-name>
				[Dot42.DexImport("getByteStream", "()Ljava/io/InputStream;", AccessFlags = 1)]
				public virtual global::Java.Io.InputStream GetByteStream() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.InputStream);
				}

				/// <summary>
				/// <para>Set the character encoding, if known.</para><para>The encoding must be a string acceptable for an XML encoding declaration (see section 4.3.3 of the XML 1.0 recommendation).</para><para>This method has no effect when the application provides a character stream.</para><para><para>setSystemId </para><simplesectsep></simplesectsep><para>setByteStream </para><simplesectsep></simplesectsep><para>getEncoding </para></para>        
				/// </summary>
				/// <java-name>
				/// setEncoding
				/// </java-name>
				[Dot42.DexImport("setEncoding", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetEncoding(string encoding) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Get the character encoding for a byte stream or URI. This value will be ignored when the application provides a character stream.</para><para><para>setByteStream </para><simplesectsep></simplesectsep><para>getSystemId </para><simplesectsep></simplesectsep><para>getByteStream </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The encoding, or null if none was supplied. </para>
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
				/// <para>Set the character stream for this input source.</para><para>If there is a character stream specified, the SAX parser will ignore any byte stream and will not attempt to open a URI connection to the system identifier.</para><para><para>getCharacterStream </para><simplesectsep></simplesectsep><para>java.io.Reader </para></para>        
				/// </summary>
				/// <java-name>
				/// setCharacterStream
				/// </java-name>
				[Dot42.DexImport("setCharacterStream", "(Ljava/io/Reader;)V", AccessFlags = 1)]
				public virtual void SetCharacterStream(global::Java.Io.Reader characterStream) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Get the character stream for this input source.</para><para><para>setCharacterStream </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The character stream, or null if none was supplied. </para>
				/// </returns>
				/// <java-name>
				/// getCharacterStream
				/// </java-name>
				[Dot42.DexImport("getCharacterStream", "()Ljava/io/Reader;", AccessFlags = 1)]
				public virtual global::Java.Io.Reader GetCharacterStream() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.Reader);
				}

				/// <summary>
				/// <para>Get the public identifier for this input source.</para><para><para>setPublicId </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The public identifier, or null if none was supplied. </para>
				/// </returns>
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

				/// <summary>
				/// <para>Get the system identifier for this input source.</para><para>The getEncoding method will return the character encoding of the object pointed to, or null if unknown.</para><para>If the system ID is a URL, it will be fully resolved.</para><para><para>setSystemId </para><simplesectsep></simplesectsep><para>getEncoding </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The system identifier, or null if none was supplied. </para>
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

				/// <summary>
				/// <para>Get the byte stream for this input source.</para><para>The getEncoding method will return the character encoding for this byte stream, or null if unknown.</para><para><para>getEncoding </para><simplesectsep></simplesectsep><para>setByteStream </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The byte stream, or null if none was supplied. </para>
				/// </returns>
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

				/// <summary>
				/// <para>Get the character encoding for a byte stream or URI. This value will be ignored when the application provides a character stream.</para><para><para>setByteStream </para><simplesectsep></simplesectsep><para>getSystemId </para><simplesectsep></simplesectsep><para>getByteStream </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The encoding, or null if none was supplied. </para>
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

				/// <summary>
				/// <para>Get the character stream for this input source.</para><para><para>setCharacterStream </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The character stream, or null if none was supplied. </para>
				/// </returns>
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

		/// <summary>
		/// <para>Receive notification of general document events.</para><para><blockquote><para><b>This module, both source code and documentation, is in the Public Domain, and comes with <b>NO WARRANTY</b>.</b> See  for further information. </para></blockquote></para><para>This was the main event-handling interface for SAX1; in SAX2, it has been replaced by ContentHandler, which provides Namespace support and reporting of skipped entities. This interface is included in SAX2 only to support legacy SAX1 applications.</para><para>The order of events in this interface is very important, and mirrors the order of information in the document itself. For example, all of an element's content (character data, processing instructions, and/or subelements) will appear, in order, between the startElement event and the corresponding endElement event.</para><para>Application writers who do not want to implement the entire interface can derive a class from HandlerBase, which implements the default functionality; parser writers can instantiate HandlerBase to obtain a default handler. The application can find the location of any document event using the Locator interface supplied by the Parser through the setDocumentLocator method.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>This interface has been replaced by the SAX2 ContentHandler interface, which includes Namespace support. </para></xrefdescription></xrefsect><para>SAX 1.0 </para><para>David Megginson </para><para>2.0.1 (sax2r2) </para><para>org.xml.sax.Parser::setDocumentHandler </para><simplesectsep></simplesectsep><para>org.xml.sax.Locator </para><simplesectsep></simplesectsep><para>org.xml.sax.HandlerBase </para></para>    
		/// </summary>
		/// <java-name>
		/// org/xml/sax/DocumentHandler
		/// </java-name>
		[Dot42.DexImport("org/xml/sax/DocumentHandler", AccessFlags = 1537)]
		public partial interface IDocumentHandler
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Receive an object for locating the origin of SAX document events.</para><para>SAX parsers are strongly encouraged (though not absolutely required) to supply a locator: if it does so, it must supply the locator to the application by invoking this method before invoking any of the other methods in the DocumentHandler interface.</para><para>The locator allows the application to determine the end position of any document-related event, even if the parser is not reporting an error. Typically, the application will use this information for reporting its own errors (such as character content that does not match an application's business rules). The information returned by the locator is probably not sufficient for use with a search engine.</para><para>Note that the locator will return correct information only during the invocation of the events in this interface. The application should not attempt to use it at any other time.</para><para><para>org.xml.sax.Locator </para></para>        
				/// </summary>
				/// <java-name>
				/// setDocumentLocator
				/// </java-name>
				[Dot42.DexImport("setDocumentLocator", "(Lorg/xml/sax/Locator;)V", AccessFlags = 1025)]
				void SetDocumentLocator(global::Org.Xml.Sax.ILocator locator) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Receive notification of the beginning of a document.</para><para>The SAX parser will invoke this method only once, before any other methods in this interface or in DTDHandler (except for setDocumentLocator).</para><para></para>        
				/// </summary>
				/// <java-name>
				/// startDocument
				/// </java-name>
				[Dot42.DexImport("startDocument", "()V", AccessFlags = 1025)]
				void StartDocument() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Receive notification of the end of a document.</para><para>The SAX parser will invoke this method only once, and it will be the last method invoked during the parse. The parser shall not invoke this method until it has either abandoned parsing (because of an unrecoverable error) or reached the end of input.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// endDocument
				/// </java-name>
				[Dot42.DexImport("endDocument", "()V", AccessFlags = 1025)]
				void EndDocument() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Receive notification of the beginning of an element.</para><para>The Parser will invoke this method at the beginning of every element in the XML document; there will be a corresponding endElement() event for every startElement() event (even when the element is empty). All of the element's content will be reported, in order, before the corresponding endElement() event.</para><para>If the element name has a namespace prefix, the prefix will still be attached. Note that the attribute list provided will contain only attributes with explicit values (specified or defaulted): #IMPLIED attributes will be omitted.</para><para><para>endElement </para><simplesectsep></simplesectsep><para>org.xml.sax.AttributeList </para></para>        
				/// </summary>
				/// <java-name>
				/// startElement
				/// </java-name>
				[Dot42.DexImport("startElement", "(Ljava/lang/String;Lorg/xml/sax/AttributeList;)V", AccessFlags = 1025)]
				void StartElement(string name, global::Org.Xml.Sax.IAttributeList atts) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Receive notification of the end of an element.</para><para>The SAX parser will invoke this method at the end of every element in the XML document; there will be a corresponding startElement() event for every endElement() event (even when the element is empty).</para><para>If the element name has a namespace prefix, the prefix will still be attached to the name.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// endElement
				/// </java-name>
				[Dot42.DexImport("endElement", "(Ljava/lang/String;)V", AccessFlags = 1025)]
				void EndElement(string name) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Receive notification of character data.</para><para>The Parser will call this method to report each chunk of character data. SAX parsers may return all contiguous character data in a single chunk, or they may split it into several chunks; however, all of the characters in any single event must come from the same external entity, so that the Locator provides useful information.</para><para>The application must not attempt to read from the array outside of the specified range.</para><para>Note that some parsers will report whitespace using the ignorableWhitespace() method rather than this one (validating parsers must do so).</para><para><para>ignorableWhitespace </para><simplesectsep></simplesectsep><para>org.xml.sax.Locator </para></para>        
				/// </summary>
				/// <java-name>
				/// characters
				/// </java-name>
				[Dot42.DexImport("characters", "([CII)V", AccessFlags = 1025)]
				void Characters(char[] ch, int start, int length) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Receive notification of ignorable whitespace in element content.</para><para>Validating Parsers must use this method to report each chunk of ignorable whitespace (see the W3C XML 1.0 recommendation, section 2.10): non-validating parsers may also use this method if they are capable of parsing and using content models.</para><para>SAX parsers may return all contiguous whitespace in a single chunk, or they may split it into several chunks; however, all of the characters in any single event must come from the same external entity, so that the Locator provides useful information.</para><para>The application must not attempt to read from the array outside of the specified range.</para><para><para>characters </para></para>        
				/// </summary>
				/// <java-name>
				/// ignorableWhitespace
				/// </java-name>
				[Dot42.DexImport("ignorableWhitespace", "([CII)V", AccessFlags = 1025)]
				void IgnorableWhitespace(char[] ch, int start, int length) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Receive notification of a processing instruction.</para><para>The Parser will invoke this method once for each processing instruction found: note that processing instructions may occur before or after the main document element.</para><para>A SAX parser should never report an XML declaration (XML 1.0, section 2.8) or a text declaration (XML 1.0, section 4.3.1) using this method.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// processingInstruction
				/// </java-name>
				[Dot42.DexImport("processingInstruction", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1025)]
				void ProcessingInstruction(string target, string data) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>Encapsulate an XML parse error or warning.</para><para><blockquote><para><b>This module, both source code and documentation, is in the Public Domain, and comes with <b>NO WARRANTY</b>.</b> See  for further information. </para></blockquote></para><para>This exception may include information for locating the error in the original XML document, as if it came from a Locator object. Note that although the application will receive a SAXParseException as the argument to the handlers in the ErrorHandler interface, the application is not actually required to throw the exception; instead, it can simply read the information in it and take a different action.</para><para>Since this exception is a subclass of SAXException, it inherits the ability to wrap another exception.</para><para><para>SAX 1.0 </para><para>David Megginson </para><para>2.0.1 (sax2r2) </para><para>org.xml.sax.SAXException </para><simplesectsep></simplesectsep><para>org.xml.sax.Locator </para><simplesectsep></simplesectsep><para>org.xml.sax.ErrorHandler </para></para>    
		/// </summary>
		/// <java-name>
		/// org/xml/sax/SAXParseException
		/// </java-name>
		[Dot42.DexImport("org/xml/sax/SAXParseException", AccessFlags = 33)]
		public partial class SAXParseException : global::Org.Xml.Sax.SAXException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Create a new SAXParseException from a message and a Locator.</para><para>This constructor is especially useful when an application is creating its own exception from within a ContentHandler callback.</para><para><para>org.xml.sax.Locator </para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Lorg/xml/sax/Locator;)V", AccessFlags = 1)]
				public SAXParseException(string message, global::Org.Xml.Sax.ILocator locator) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Wrap an existing exception in a SAXParseException.</para><para>This constructor is especially useful when an application is creating its own exception from within a ContentHandler callback, and needs to wrap an existing exception that is not a subclass of SAXException.</para><para><para>org.xml.sax.Locator </para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Lorg/xml/sax/Locator;Ljava/lang/Exception;)V", AccessFlags = 1)]
				public SAXParseException(string message, global::Org.Xml.Sax.ILocator locator, global::System.Exception e) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Create a new SAXParseException.</para><para>This constructor is most useful for parser writers.</para><para>All parameters except the message are as if they were provided by a Locator. For example, if the system identifier is a URL (including relative filename), the caller must resolve it fully before creating the exception.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;II)V", AccessFlags = 1)]
				public SAXParseException(string message, string publicId, string systemId, int lineNumber, int columnNumber) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Create a new SAXParseException with an embedded exception.</para><para>This constructor is most useful for parser writers who need to wrap an exception that is not a subclass of SAXException.</para><para>All parameters except the message and exception are as if they were provided by a Locator. For example, if the system identifier is a URL (including relative filename), the caller must resolve it fully before creating the exception.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;IILjava/lang/Exception;)V", AccessFlags = 1)]
				public SAXParseException(string message, string publicId, string systemId, int lineNumber, int columnNumber, global::System.Exception e) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Get the public identifier of the entity where the exception occurred.</para><para><para>org.xml.sax.Locator::getPublicId </para></para>        
				/// </summary>
				/// <returns>
				/// <para>A string containing the public identifier, or null if none is available. </para>
				/// </returns>
				/// <java-name>
				/// getPublicId
				/// </java-name>
				[Dot42.DexImport("getPublicId", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetPublicId() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Get the system identifier of the entity where the exception occurred.</para><para>If the system identifier is a URL, it will have been resolved fully.</para><para><para>org.xml.sax.Locator::getSystemId </para></para>        
				/// </summary>
				/// <returns>
				/// <para>A string containing the system identifier, or null if none is available. </para>
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
				/// <para>The line number of the end of the text where the exception occurred.</para><para>The first line is line 1.</para><para><para>org.xml.sax.Locator::getLineNumber </para></para>        
				/// </summary>
				/// <returns>
				/// <para>An integer representing the line number, or -1 if none is available. </para>
				/// </returns>
				/// <java-name>
				/// getLineNumber
				/// </java-name>
				[Dot42.DexImport("getLineNumber", "()I", AccessFlags = 1)]
				public virtual int GetLineNumber() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>The column number of the end of the text where the exception occurred.</para><para>The first column in a line is position 1.</para><para><para>org.xml.sax.Locator::getColumnNumber </para></para>        
				/// </summary>
				/// <returns>
				/// <para>An integer representing the column number, or -1 if none is available. </para>
				/// </returns>
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

				/// <summary>
				/// <para>Get the public identifier of the entity where the exception occurred.</para><para><para>org.xml.sax.Locator::getPublicId </para></para>        
				/// </summary>
				/// <returns>
				/// <para>A string containing the public identifier, or null if none is available. </para>
				/// </returns>
				/// <java-name>
				/// getPublicId
				/// </java-name>
				public string PublicId
				{
				[Dot42.DexImport("getPublicId", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetPublicId(); }
				}

				/// <summary>
				/// <para>Get the system identifier of the entity where the exception occurred.</para><para>If the system identifier is a URL, it will have been resolved fully.</para><para><para>org.xml.sax.Locator::getSystemId </para></para>        
				/// </summary>
				/// <returns>
				/// <para>A string containing the system identifier, or null if none is available. </para>
				/// </returns>
				/// <java-name>
				/// getSystemId
				/// </java-name>
				public string SystemId
				{
				[Dot42.DexImport("getSystemId", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetSystemId(); }
				}

				/// <summary>
				/// <para>The line number of the end of the text where the exception occurred.</para><para>The first line is line 1.</para><para><para>org.xml.sax.Locator::getLineNumber </para></para>        
				/// </summary>
				/// <returns>
				/// <para>An integer representing the line number, or -1 if none is available. </para>
				/// </returns>
				/// <java-name>
				/// getLineNumber
				/// </java-name>
				public int LineNumber
				{
				[Dot42.DexImport("getLineNumber", "()I", AccessFlags = 1)]
						get{ return GetLineNumber(); }
				}

				/// <summary>
				/// <para>The column number of the end of the text where the exception occurred.</para><para>The first column in a line is position 1.</para><para><para>org.xml.sax.Locator::getColumnNumber </para></para>        
				/// </summary>
				/// <returns>
				/// <para>An integer representing the column number, or -1 if none is available. </para>
				/// </returns>
				/// <java-name>
				/// getColumnNumber
				/// </java-name>
				public int ColumnNumber
				{
				[Dot42.DexImport("getColumnNumber", "()I", AccessFlags = 1)]
						get{ return GetColumnNumber(); }
				}

		}

		/// <summary>
		/// <para>Basic interface for SAX (Simple API for XML) parsers.</para><para><blockquote><para><b>This module, both source code and documentation, is in the Public Domain, and comes with <b>NO WARRANTY</b>.</b> See  for further information. </para></blockquote></para><para>This was the main event supplier interface for SAX1; it has been replaced in SAX2 by XMLReader, which includes Namespace support and sophisticated configurability and extensibility.</para><para>All SAX1 parsers must implement this basic interface: it allows applications to register handlers for different types of events and to initiate a parse from a URI, or a character stream.</para><para>All SAX1 parsers must also implement a zero-argument constructor (though other constructors are also allowed).</para><para>SAX1 parsers are reusable but not re-entrant: the application may reuse a parser object (possibly with a different input source) once the first parse has completed successfully, but it may not invoke the parse() methods recursively within a parse.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>This interface has been replaced by the SAX2 XMLReader interface, which includes Namespace support. </para></xrefdescription></xrefsect><para>SAX 1.0 </para><para>David Megginson </para><para>2.0.1 (sax2r2) </para><para>org.xml.sax.EntityResolver </para><simplesectsep></simplesectsep><para>org.xml.sax.DTDHandler </para><simplesectsep></simplesectsep><para>org.xml.sax.DocumentHandler </para><simplesectsep></simplesectsep><para>org.xml.sax.ErrorHandler </para><simplesectsep></simplesectsep><para>org.xml.sax.HandlerBase </para><simplesectsep></simplesectsep><para>org.xml.sax.InputSource </para></para>    
		/// </summary>
		/// <java-name>
		/// org/xml/sax/Parser
		/// </java-name>
		[Dot42.DexImport("org/xml/sax/Parser", AccessFlags = 1537)]
		public partial interface IParser
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Allow an application to request a locale for errors and warnings.</para><para>SAX parsers are not required to provide localisation for errors and warnings; if they cannot support the requested locale, however, they must throw a SAX exception. Applications may not request a locale change in the middle of a parse.</para><para><para>org.xml.sax.SAXException </para><simplesectsep></simplesectsep><para>org.xml.sax.SAXParseException </para></para>        
				/// </summary>
				/// <java-name>
				/// setLocale
				/// </java-name>
				[Dot42.DexImport("setLocale", "(Ljava/util/Locale;)V", AccessFlags = 1025)]
				void SetLocale(global::Java.Util.Locale locale) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Allow an application to register a custom entity resolver.</para><para>If the application does not register an entity resolver, the SAX parser will resolve system identifiers and open connections to entities itself (this is the default behaviour implemented in HandlerBase).</para><para>Applications may register a new or different entity resolver in the middle of a parse, and the SAX parser must begin using the new resolver immediately.</para><para><para>EntityResolver </para><simplesectsep></simplesectsep><para>HandlerBase </para></para>        
				/// </summary>
				/// <java-name>
				/// setEntityResolver
				/// </java-name>
				[Dot42.DexImport("setEntityResolver", "(Lorg/xml/sax/EntityResolver;)V", AccessFlags = 1025)]
				void SetEntityResolver(global::Org.Xml.Sax.IEntityResolver resolver) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Allow an application to register a DTD event handler.</para><para>If the application does not register a DTD handler, all DTD events reported by the SAX parser will be silently ignored (this is the default behaviour implemented by HandlerBase).</para><para>Applications may register a new or different handler in the middle of a parse, and the SAX parser must begin using the new handler immediately.</para><para><para>DTDHandler </para><simplesectsep></simplesectsep><para>HandlerBase </para></para>        
				/// </summary>
				/// <java-name>
				/// setDTDHandler
				/// </java-name>
				[Dot42.DexImport("setDTDHandler", "(Lorg/xml/sax/DTDHandler;)V", AccessFlags = 1025)]
				void SetDTDHandler(global::Org.Xml.Sax.IDTDHandler handler) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Allow an application to register a document event handler.</para><para>If the application does not register a document handler, all document events reported by the SAX parser will be silently ignored (this is the default behaviour implemented by HandlerBase).</para><para>Applications may register a new or different handler in the middle of a parse, and the SAX parser must begin using the new handler immediately.</para><para><para>DocumentHandler </para><simplesectsep></simplesectsep><para>HandlerBase </para></para>        
				/// </summary>
				/// <java-name>
				/// setDocumentHandler
				/// </java-name>
				[Dot42.DexImport("setDocumentHandler", "(Lorg/xml/sax/DocumentHandler;)V", AccessFlags = 1025)]
				void SetDocumentHandler(global::Org.Xml.Sax.IDocumentHandler handler) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Allow an application to register an error event handler.</para><para>If the application does not register an error event handler, all error events reported by the SAX parser will be silently ignored, except for fatalError, which will throw a SAXException (this is the default behaviour implemented by HandlerBase).</para><para>Applications may register a new or different handler in the middle of a parse, and the SAX parser must begin using the new handler immediately.</para><para><para>ErrorHandler </para><simplesectsep></simplesectsep><para>SAXException </para><simplesectsep></simplesectsep><para>HandlerBase </para></para>        
				/// </summary>
				/// <java-name>
				/// setErrorHandler
				/// </java-name>
				[Dot42.DexImport("setErrorHandler", "(Lorg/xml/sax/ErrorHandler;)V", AccessFlags = 1025)]
				void SetErrorHandler(global::Org.Xml.Sax.IErrorHandler handler) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Parse an XML document.</para><para>The application can use this method to instruct the SAX parser to begin parsing an XML document from any valid input source (a character stream, a byte stream, or a URI).</para><para>Applications may not invoke this method while a parse is in progress (they should create a new Parser instead for each additional XML document). Once a parse is complete, an application may reuse the same Parser object, possibly with a different input source.</para><para><para>org.xml.sax.InputSource </para><simplesectsep></simplesectsep><para>parse(java.lang.String) </para><simplesectsep></simplesectsep><para>setEntityResolver </para><simplesectsep></simplesectsep><para>setDTDHandler </para><simplesectsep></simplesectsep><para>setDocumentHandler </para><simplesectsep></simplesectsep><para>setErrorHandler </para></para>        
				/// </summary>
				/// <java-name>
				/// parse
				/// </java-name>
				[Dot42.DexImport("parse", "(Lorg/xml/sax/InputSource;)V", AccessFlags = 1025)]
				void Parse(global::Org.Xml.Sax.InputSource source) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Parse an XML document.</para><para>The application can use this method to instruct the SAX parser to begin parsing an XML document from any valid input source (a character stream, a byte stream, or a URI).</para><para>Applications may not invoke this method while a parse is in progress (they should create a new Parser instead for each additional XML document). Once a parse is complete, an application may reuse the same Parser object, possibly with a different input source.</para><para><para>org.xml.sax.InputSource </para><simplesectsep></simplesectsep><para>parse(java.lang.String) </para><simplesectsep></simplesectsep><para>setEntityResolver </para><simplesectsep></simplesectsep><para>setDTDHandler </para><simplesectsep></simplesectsep><para>setDocumentHandler </para><simplesectsep></simplesectsep><para>setErrorHandler </para></para>        
				/// </summary>
				/// <java-name>
				/// parse
				/// </java-name>
				[Dot42.DexImport("parse", "(Ljava/lang/String;)V", AccessFlags = 1025)]
				void Parse(string source) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>Receive notification of basic DTD-related events.</para><para><blockquote><para><b>This module, both source code and documentation, is in the Public Domain, and comes with <b>NO WARRANTY</b>.</b> See  for further information. </para></blockquote></para><para>If a SAX application needs information about notations and unparsed entities, then the application implements this interface and registers an instance with the SAX parser using the parser's setDTDHandler method. The parser uses the instance to report notation and unparsed entity declarations to the application.</para><para>Note that this interface includes only those DTD events that the XML recommendation <b>requires</b> processors to report: notation and unparsed entity declarations.</para><para>The SAX parser may report these events in any order, regardless of the order in which the notations and unparsed entities were declared; however, all DTD events must be reported after the document handler's startDocument event, and before the first startElement event. (If the LexicalHandler is used, these events must also be reported before the endDTD event.) </para><para>It is up to the application to store the information for future use (perhaps in a hash table or object tree). If the application encounters attributes of type "NOTATION", "ENTITY", or "ENTITIES", it can use the information that it obtained through this interface to find the entity and/or notation corresponding with the attribute value.</para><para><para>SAX 1.0 </para><para>David Megginson </para><para>2.0.1 (sax2r2) </para><para>org.xml.sax.XMLReader::setDTDHandler </para></para>    
		/// </summary>
		/// <java-name>
		/// org/xml/sax/DTDHandler
		/// </java-name>
		[Dot42.DexImport("org/xml/sax/DTDHandler", AccessFlags = 1537)]
		public partial interface IDTDHandler
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Receive notification of a notation declaration event.</para><para>It is up to the application to record the notation for later reference, if necessary; notations may appear as attribute values and in unparsed entity declarations, and are sometime used with processing instruction target names.</para><para>At least one of publicId and systemId must be non-null. If a system identifier is present, and it is a URL, the SAX parser must resolve it fully before passing it to the application through this event.</para><para>There is no guarantee that the notation declaration will be reported before any unparsed entities that use it.</para><para><para>unparsedEntityDecl </para><simplesectsep></simplesectsep><para>org.xml.sax.Attributes </para></para>        
				/// </summary>
				/// <java-name>
				/// notationDecl
				/// </java-name>
				[Dot42.DexImport("notationDecl", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1025)]
				void NotationDecl(string name, string publicId, string systemId) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Receive notification of an unparsed entity declaration event.</para><para>Note that the notation name corresponds to a notation reported by the notationDecl event. It is up to the application to record the entity for later reference, if necessary; unparsed entities may appear as attribute values. </para><para>If the system identifier is a URL, the parser must resolve it fully before passing it to the application.</para><para><para>notationDecl </para><simplesectsep></simplesectsep><para>org.xml.sax.Attributes </para></para>        
				/// </summary>
				/// <java-name>
				/// unparsedEntityDecl
				/// </java-name>
				[Dot42.DexImport("unparsedEntityDecl", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1025)]
				void UnparsedEntityDecl(string name, string publicId, string systemId, string notationName) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>Exception class for an unsupported operation.</para><para><blockquote><para><b>This module, both source code and documentation, is in the Public Domain, and comes with <b>NO WARRANTY</b>.</b> See  for further information. </para></blockquote></para><para>An XMLReader will throw this exception when it recognizes a feature or property identifier, but cannot perform the requested operation (setting a state or value). Other SAX2 applications and extensions may use this class for similar purposes.</para><para><para>SAX 2.0 </para><para>David Megginson </para><para>2.0.1 (sax2r2) </para><para>org.xml.sax.SAXNotRecognizedException </para></para>    
		/// </summary>
		/// <java-name>
		/// org/xml/sax/SAXNotSupportedException
		/// </java-name>
		[Dot42.DexImport("org/xml/sax/SAXNotSupportedException", AccessFlags = 33)]
		public partial class SAXNotSupportedException : global::Org.Xml.Sax.SAXException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Construct a new exception with no message. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public SAXNotSupportedException() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Construct a new exception with the given message.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public SAXNotSupportedException(string message) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>Interface for a list of XML attributes.</para><para><blockquote><para><b>This module, both source code and documentation, is in the Public Domain, and comes with <b>NO WARRANTY</b>.</b> See  for further information. </para></blockquote></para><para>This interface allows access to a list of attributes in three different ways:</para><para><ol><li><para>by attribute index; </para></li><li><para>by Namespace-qualified name; or </para></li><li><para>by qualified (prefixed) name. </para></li></ol></para><para>The list will not contain attributes that were declared #IMPLIED but not specified in the start tag. It will also not contain attributes used as Namespace declarations (xmlns*) unless the <code></code> feature is set to <b>true</b> (it is <b>false</b> by default). Because SAX2 conforms to the original "Namespaces in XML" recommendation, it normally does not give namespace declaration attributes a namespace URI. </para><para>Some SAX2 parsers may support using an optional feature flag (<code></code>) to request that those attributes be given URIs, conforming to a later backwards-incompatible revision of that recommendation. (The attribute's "local name" will be the prefix, or "xmlns" when defining a default element namespace.) For portability, handler code should always resolve that conflict, rather than requiring parsers that can change the setting of that feature flag. </para><para>If the namespace-prefixes feature (see above) is <b>false</b>, access by qualified name may not be available; if the <code></code> feature is <b>false</b>, access by Namespace-qualified names may not be available.</para><para>This interface replaces the now-deprecated SAX1 AttributeList interface, which does not contain Namespace support. In addition to Namespace support, it adds the <b>getIndex</b> methods (below).</para><para>The order of attributes in the list is unspecified, and will vary from implementation to implementation.</para><para><para>SAX 2.0 </para><para>David Megginson </para><para>2.0.1 (sax2r2) </para><para>org.xml.sax.helpers.AttributesImpl </para><simplesectsep></simplesectsep><para>org.xml.sax.ext.DeclHandler::attributeDecl </para></para>    
		/// </summary>
		/// <java-name>
		/// org/xml/sax/Attributes
		/// </java-name>
		[Dot42.DexImport("org/xml/sax/Attributes", AccessFlags = 1537)]
		public partial interface IAttributes
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Return the number of attributes in the list.</para><para>Once you know the number of attributes, you can iterate through the list.</para><para><para>getURI(int) </para><simplesectsep></simplesectsep><para>getLocalName(int) </para><simplesectsep></simplesectsep><para>getQName(int) </para><simplesectsep></simplesectsep><para>getType(int) </para><simplesectsep></simplesectsep><para>getValue(int) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The number of attributes in the list. </para>
				/// </returns>
				/// <java-name>
				/// getLength
				/// </java-name>
				[Dot42.DexImport("getLength", "()I", AccessFlags = 1025)]
				int GetLength() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Look up an attribute's Namespace URI by index.</para><para><para>getLength </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The Namespace URI, or the empty string if none is available, or null if the index is out of range. </para>
				/// </returns>
				/// <java-name>
				/// getURI
				/// </java-name>
				[Dot42.DexImport("getURI", "(I)Ljava/lang/String;", AccessFlags = 1025)]
				string GetURI(int index) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Look up an attribute's local name by index.</para><para><para>getLength </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The local name, or the empty string if Namespace processing is not being performed, or null if the index is out of range. </para>
				/// </returns>
				/// <java-name>
				/// getLocalName
				/// </java-name>
				[Dot42.DexImport("getLocalName", "(I)Ljava/lang/String;", AccessFlags = 1025)]
				string GetLocalName(int index) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Look up an attribute's XML qualified (prefixed) name by index.</para><para><para>getLength </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The XML qualified name, or the empty string if none is available, or null if the index is out of range. </para>
				/// </returns>
				/// <java-name>
				/// getQName
				/// </java-name>
				[Dot42.DexImport("getQName", "(I)Ljava/lang/String;", AccessFlags = 1025)]
				string GetQName(int index) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Look up an attribute's type by index.</para><para>The attribute type is one of the strings "CDATA", "ID", "IDREF", "IDREFS", "NMTOKEN", "NMTOKENS", "ENTITY", "ENTITIES", or "NOTATION" (always in upper case).</para><para>If the parser has not read a declaration for the attribute, or if the parser does not report attribute types, then it must return the value "CDATA" as stated in the XML 1.0 Recommendation (clause 3.3.3, "Attribute-Value Normalization").</para><para>For an enumerated attribute that is not a notation, the parser will report the type as "NMTOKEN".</para><para><para>getLength </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The attribute's type as a string, or null if the index is out of range. </para>
				/// </returns>
				/// <java-name>
				/// getType
				/// </java-name>
				[Dot42.DexImport("getType", "(I)Ljava/lang/String;", AccessFlags = 1025)]
				string GetType(int index) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Look up an attribute's value by index.</para><para>If the attribute value is a list of tokens (IDREFS, ENTITIES, or NMTOKENS), the tokens will be concatenated into a single string with each token separated by a single space.</para><para><para>getLength </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The attribute's value as a string, or null if the index is out of range. </para>
				/// </returns>
				/// <java-name>
				/// getValue
				/// </java-name>
				[Dot42.DexImport("getValue", "(I)Ljava/lang/String;", AccessFlags = 1025)]
				string GetValue(int index) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Look up the index of an attribute by Namespace name.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The index of the attribute, or -1 if it does not appear in the list. </para>
				/// </returns>
				/// <java-name>
				/// getIndex
				/// </java-name>
				[Dot42.DexImport("getIndex", "(Ljava/lang/String;Ljava/lang/String;)I", AccessFlags = 1025)]
				int GetIndex(string uri, string localName) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Look up the index of an attribute by XML qualified (prefixed) name.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The index of the attribute, or -1 if it does not appear in the list. </para>
				/// </returns>
				/// <java-name>
				/// getIndex
				/// </java-name>
				[Dot42.DexImport("getIndex", "(Ljava/lang/String;)I", AccessFlags = 1025)]
				int GetIndex(string qName) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Look up an attribute's type by Namespace name.</para><para>See getType(int) for a description of the possible types.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The attribute type as a string, or null if the attribute is not in the list or if Namespace processing is not being performed. </para>
				/// </returns>
				/// <java-name>
				/// getType
				/// </java-name>
				[Dot42.DexImport("getType", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1025)]
				string GetType(string uri, string localName) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Look up an attribute's type by index.</para><para>The attribute type is one of the strings "CDATA", "ID", "IDREF", "IDREFS", "NMTOKEN", "NMTOKENS", "ENTITY", "ENTITIES", or "NOTATION" (always in upper case).</para><para>If the parser has not read a declaration for the attribute, or if the parser does not report attribute types, then it must return the value "CDATA" as stated in the XML 1.0 Recommendation (clause 3.3.3, "Attribute-Value Normalization").</para><para>For an enumerated attribute that is not a notation, the parser will report the type as "NMTOKEN".</para><para><para>getLength </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The attribute's type as a string, or null if the index is out of range. </para>
				/// </returns>
				/// <java-name>
				/// getType
				/// </java-name>
				[Dot42.DexImport("getType", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1025)]
				string GetType(string index) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Look up an attribute's value by Namespace name.</para><para>See getValue(int) for a description of the possible values.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The attribute value as a string, or null if the attribute is not in the list. </para>
				/// </returns>
				/// <java-name>
				/// getValue
				/// </java-name>
				[Dot42.DexImport("getValue", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1025)]
				string GetValue(string uri, string localName) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Look up an attribute's value by index.</para><para>If the attribute value is a list of tokens (IDREFS, ENTITIES, or NMTOKENS), the tokens will be concatenated into a single string with each token separated by a single space.</para><para><para>getLength </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The attribute's value as a string, or null if the index is out of range. </para>
				/// </returns>
				/// <java-name>
				/// getValue
				/// </java-name>
				[Dot42.DexImport("getValue", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1025)]
				string GetValue(string index) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>Default base class for handlers.</para><para><blockquote><para><b>This module, both source code and documentation, is in the Public Domain, and comes with <b>NO WARRANTY</b>.</b> See  for further information. </para></blockquote></para><para>This class implements the default behaviour for four SAX1 interfaces: EntityResolver, DTDHandler, DocumentHandler, and ErrorHandler. It is now obsolete, but is included in SAX2 to support legacy SAX1 applications. SAX2 applications should use the DefaultHandler class instead.</para><para>Application writers can extend this class when they need to implement only part of an interface; parser writers can instantiate this class to provide default handlers when the application has not supplied its own.</para><para>Note that the use of this class is optional.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>This class works with the deprecated DocumentHandler interface. It has been replaced by the SAX2 DefaultHandler class. </para></xrefdescription></xrefsect><para>SAX 1.0 </para><para>David Megginson </para><para>2.0.1 (sax2r2) </para><para>org.xml.sax.EntityResolver </para><simplesectsep></simplesectsep><para>org.xml.sax.DTDHandler </para><simplesectsep></simplesectsep><para>org.xml.sax.DocumentHandler </para><simplesectsep></simplesectsep><para>org.xml.sax.ErrorHandler </para></para>    
		/// </summary>
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

				/// <summary>
				/// <para>Resolve an external entity.</para><para>Always return null, so that the parser will use the system identifier provided in the XML document. This method implements the SAX default behaviour: application writers can override it in a subclass to do special translations such as catalog lookups or URI redirection.</para><para><para>org.xml.sax.EntityResolver::resolveEntity </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The new input source, or null to require the default behaviour. </para>
				/// </returns>
				/// <java-name>
				/// resolveEntity
				/// </java-name>
				[Dot42.DexImport("resolveEntity", "(Ljava/lang/String;Ljava/lang/String;)Lorg/xml/sax/InputSource;", AccessFlags = 1)]
				public virtual global::Org.Xml.Sax.InputSource ResolveEntity(string publicId, string systemId) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Xml.Sax.InputSource);
				}

				/// <summary>
				/// <para>Receive notification of a notation declaration.</para><para>By default, do nothing. Application writers may override this method in a subclass if they wish to keep track of the notations declared in a document.</para><para><para>org.xml.sax.DTDHandler::notationDecl </para></para>        
				/// </summary>
				/// <java-name>
				/// notationDecl
				/// </java-name>
				[Dot42.DexImport("notationDecl", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void NotationDecl(string name, string publicId, string systemId) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Receive notification of an unparsed entity declaration.</para><para>By default, do nothing. Application writers may override this method in a subclass to keep track of the unparsed entities declared in a document.</para><para><para>org.xml.sax.DTDHandler::unparsedEntityDecl </para></para>        
				/// </summary>
				/// <java-name>
				/// unparsedEntityDecl
				/// </java-name>
				[Dot42.DexImport("unparsedEntityDecl", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void UnparsedEntityDecl(string name, string publicId, string systemId, string notationName) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Receive a Locator object for document events.</para><para>By default, do nothing. Application writers may override this method in a subclass if they wish to store the locator for use with other document events.</para><para><para>org.xml.sax.DocumentHandler::setDocumentLocator </para><simplesectsep></simplesectsep><para>org.xml.sax.Locator </para></para>        
				/// </summary>
				/// <java-name>
				/// setDocumentLocator
				/// </java-name>
				[Dot42.DexImport("setDocumentLocator", "(Lorg/xml/sax/Locator;)V", AccessFlags = 1)]
				public virtual void SetDocumentLocator(global::Org.Xml.Sax.ILocator locator) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Receive notification of the beginning of the document.</para><para>By default, do nothing. Application writers may override this method in a subclass to take specific actions at the beginning of a document (such as allocating the root node of a tree or creating an output file).</para><para><para>org.xml.sax.DocumentHandler::startDocument </para></para>        
				/// </summary>
				/// <java-name>
				/// startDocument
				/// </java-name>
				[Dot42.DexImport("startDocument", "()V", AccessFlags = 1)]
				public virtual void StartDocument() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Receive notification of the end of the document.</para><para>By default, do nothing. Application writers may override this method in a subclass to take specific actions at the beginning of a document (such as finalising a tree or closing an output file).</para><para><para>org.xml.sax.DocumentHandler::endDocument </para></para>        
				/// </summary>
				/// <java-name>
				/// endDocument
				/// </java-name>
				[Dot42.DexImport("endDocument", "()V", AccessFlags = 1)]
				public virtual void EndDocument() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Receive notification of the start of an element.</para><para>By default, do nothing. Application writers may override this method in a subclass to take specific actions at the start of each element (such as allocating a new tree node or writing output to a file).</para><para><para>org.xml.sax.DocumentHandler::startElement </para></para>        
				/// </summary>
				/// <java-name>
				/// startElement
				/// </java-name>
				[Dot42.DexImport("startElement", "(Ljava/lang/String;Lorg/xml/sax/AttributeList;)V", AccessFlags = 1)]
				public virtual void StartElement(string name, global::Org.Xml.Sax.IAttributeList attributes) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Receive notification of the end of an element.</para><para>By default, do nothing. Application writers may override this method in a subclass to take specific actions at the end of each element (such as finalising a tree node or writing output to a file).</para><para><para>org.xml.sax.DocumentHandler::endElement </para></para>        
				/// </summary>
				/// <java-name>
				/// endElement
				/// </java-name>
				[Dot42.DexImport("endElement", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void EndElement(string name) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Receive notification of character data inside an element.</para><para>By default, do nothing. Application writers may override this method to take specific actions for each chunk of character data (such as adding the data to a node or buffer, or printing it to a file).</para><para><para>org.xml.sax.DocumentHandler::characters </para></para>        
				/// </summary>
				/// <java-name>
				/// characters
				/// </java-name>
				[Dot42.DexImport("characters", "([CII)V", AccessFlags = 1)]
				public virtual void Characters(char[] ch, int start, int length) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Receive notification of ignorable whitespace in element content.</para><para>By default, do nothing. Application writers may override this method to take specific actions for each chunk of ignorable whitespace (such as adding data to a node or buffer, or printing it to a file).</para><para><para>org.xml.sax.DocumentHandler::ignorableWhitespace </para></para>        
				/// </summary>
				/// <java-name>
				/// ignorableWhitespace
				/// </java-name>
				[Dot42.DexImport("ignorableWhitespace", "([CII)V", AccessFlags = 1)]
				public virtual void IgnorableWhitespace(char[] ch, int start, int length) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Receive notification of a processing instruction.</para><para>By default, do nothing. Application writers may override this method in a subclass to take specific actions for each processing instruction, such as setting status variables or invoking other methods.</para><para><para>org.xml.sax.DocumentHandler::processingInstruction </para></para>        
				/// </summary>
				/// <java-name>
				/// processingInstruction
				/// </java-name>
				[Dot42.DexImport("processingInstruction", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void ProcessingInstruction(string target, string data) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Receive notification of a parser warning.</para><para>The default implementation does nothing. Application writers may override this method in a subclass to take specific actions for each warning, such as inserting the message in a log file or printing it to the console.</para><para><para>org.xml.sax.ErrorHandler::warning </para><simplesectsep></simplesectsep><para>org.xml.sax.SAXParseException </para></para>        
				/// </summary>
				/// <java-name>
				/// warning
				/// </java-name>
				[Dot42.DexImport("warning", "(Lorg/xml/sax/SAXParseException;)V", AccessFlags = 1)]
				public virtual void Warning(global::Org.Xml.Sax.SAXParseException e) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Receive notification of a recoverable parser error.</para><para>The default implementation does nothing. Application writers may override this method in a subclass to take specific actions for each error, such as inserting the message in a log file or printing it to the console.</para><para><para>org.xml.sax.ErrorHandler::warning </para><simplesectsep></simplesectsep><para>org.xml.sax.SAXParseException </para></para>        
				/// </summary>
				/// <java-name>
				/// error
				/// </java-name>
				[Dot42.DexImport("error", "(Lorg/xml/sax/SAXParseException;)V", AccessFlags = 1)]
				public virtual void Error(global::Org.Xml.Sax.SAXParseException e) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Report a fatal XML parsing error.</para><para>The default implementation throws a SAXParseException. Application writers may override this method in a subclass if they need to take specific actions for each fatal error (such as collecting all of the errors into a single report): in any case, the application must stop all regular processing when this method is invoked, since the document is no longer reliable, and the parser may no longer report parsing events.</para><para><para>org.xml.sax.ErrorHandler::fatalError </para><simplesectsep></simplesectsep><para>org.xml.sax.SAXParseException </para></para>        
				/// </summary>
				/// <java-name>
				/// fatalError
				/// </java-name>
				[Dot42.DexImport("fatalError", "(Lorg/xml/sax/SAXParseException;)V", AccessFlags = 1)]
				public virtual void FatalError(global::Org.Xml.Sax.SAXParseException e) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>Interface for an XML filter.</para><para><blockquote><para><b>This module, both source code and documentation, is in the Public Domain, and comes with <b>NO WARRANTY</b>.</b> See  for further information. </para></blockquote></para><para>An XML filter is like an XML reader, except that it obtains its events from another XML reader rather than a primary source like an XML document or database. Filters can modify a stream of events as they pass on to the final application.</para><para>The XMLFilterImpl helper class provides a convenient base for creating SAX2 filters, by passing on all EntityResolver, DTDHandler, ContentHandler and ErrorHandler events automatically.</para><para><para>SAX 2.0 </para><para>David Megginson </para><para>2.0.1 (sax2r2) </para><para>org.xml.sax.helpers.XMLFilterImpl </para></para>    
		/// </summary>
		/// <java-name>
		/// org/xml/sax/XMLFilter
		/// </java-name>
		[Dot42.DexImport("org/xml/sax/XMLFilter", AccessFlags = 1537)]
		public partial interface IXMLFilter : global::Org.Xml.Sax.IXMLReader
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Set the parent reader.</para><para>This method allows the application to link the filter to a parent reader (which may be another filter). The argument may not be null.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setParent
				/// </java-name>
				[Dot42.DexImport("setParent", "(Lorg/xml/sax/XMLReader;)V", AccessFlags = 1025)]
				void SetParent(global::Org.Xml.Sax.IXMLReader parent) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Get the parent reader.</para><para>This method allows the application to query the parent reader (which may be another filter). It is generally a bad idea to perform any operations on the parent reader directly: they should all pass through this filter.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The parent filter, or null if none has been set. </para>
				/// </returns>
				/// <java-name>
				/// getParent
				/// </java-name>
				[Dot42.DexImport("getParent", "()Lorg/xml/sax/XMLReader;", AccessFlags = 1025)]
				global::Org.Xml.Sax.IXMLReader GetParent() /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>Exception class for an unrecognized identifier.</para><para><blockquote><para><b>This module, both source code and documentation, is in the Public Domain, and comes with <b>NO WARRANTY</b>.</b> See  for further information. </para></blockquote></para><para>An XMLReader will throw this exception when it finds an unrecognized feature or property identifier; SAX applications and extensions may use this class for other, similar purposes.</para><para><para>SAX 2.0 </para><para>David Megginson </para><para>2.0.1 (sax2r2) </para><para>org.xml.sax.SAXNotSupportedException </para></para>    
		/// </summary>
		/// <java-name>
		/// org/xml/sax/SAXNotRecognizedException
		/// </java-name>
		[Dot42.DexImport("org/xml/sax/SAXNotRecognizedException", AccessFlags = 33)]
		public partial class SAXNotRecognizedException : global::Org.Xml.Sax.SAXException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Default constructor. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public SAXNotRecognizedException() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Construct a new exception with the given message.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public SAXNotRecognizedException(string message) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>Encapsulate a general SAX error or warning.</para><para><blockquote><para><b>This module, both source code and documentation, is in the Public Domain, and comes with <b>NO WARRANTY</b>.</b> See  for further information. </para></blockquote></para><para>This class can contain basic error or warning information from either the XML parser or the application: a parser writer or application writer can subclass it to provide additional functionality. SAX handlers may throw this exception or any exception subclassed from it.</para><para>If the application needs to pass through other types of exceptions, it must wrap those exceptions in a SAXException or an exception derived from a SAXException.</para><para>If the parser or application needs to include information about a specific location in an XML document, it should use the SAXParseException subclass.</para><para><para>SAX 1.0 </para><para>David Megginson </para><para>2.0.1 (sax2r2) </para><para>org.xml.sax.SAXParseException </para></para>    
		/// </summary>
		/// <java-name>
		/// org/xml/sax/SAXException
		/// </java-name>
		[Dot42.DexImport("org/xml/sax/SAXException", AccessFlags = 33)]
		public partial class SAXException : global::System.Exception
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Create a new SAXException. </para>        
				/// </summary>
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

				/// <summary>
				/// <para>Create a new SAXException from an existing exception.</para><para>The existing exception will be embedded in the new one, but the new exception will have its own message.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Exception;)V", AccessFlags = 1)]
				public SAXException(string message, global::System.Exception e) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Return a detail message for this exception.</para><para>If there is an embedded exception, and if the SAXException has no detail message of its own, this method will return the detail message from the embedded exception.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The error or warning message. </para>
				/// </returns>
				/// <java-name>
				/// getMessage
				/// </java-name>
				[Dot42.DexImport("getMessage", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string GetMessage() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Return the embedded exception, if any.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The embedded exception, or null if there is none. </para>
				/// </returns>
				/// <java-name>
				/// getException
				/// </java-name>
				[Dot42.DexImport("getException", "()Ljava/lang/Exception;", AccessFlags = 1)]
				public virtual global::System.Exception GetException() /* MethodBuilder.Create */ 
				{
						return default(global::System.Exception);
				}

				/// <summary>
				/// <para>Override toString to pick up any embedded exception.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>A string representation of this exception. </para>
				/// </returns>
				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Return the embedded exception, if any.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The embedded exception, or null if there is none. </para>
				/// </returns>
				/// <java-name>
				/// getException
				/// </java-name>
				public global::System.Exception Exception
				{
				[Dot42.DexImport("getException", "()Ljava/lang/Exception;", AccessFlags = 1)]
						get{ return GetException(); }
				}

		}

		/// <summary>
		/// <para>Interface for associating a SAX event with a document location.</para><para><blockquote><para><b>This module, both source code and documentation, is in the Public Domain, and comes with <b>NO WARRANTY</b>.</b> See  for further information. </para></blockquote></para><para>If a SAX parser provides location information to the SAX application, it does so by implementing this interface and then passing an instance to the application using the content handler's setDocumentLocator method. The application can use the object to obtain the location of any other SAX event in the XML source document.</para><para>Note that the results returned by the object will be valid only during the scope of each callback method: the application will receive unpredictable results if it attempts to use the locator at any other time, or after parsing completes.</para><para>SAX parsers are not required to supply a locator, but they are very strongly encouraged to do so. If the parser supplies a locator, it must do so before reporting any other document events. If no locator has been set by the time the application receives the startDocument event, the application should assume that a locator is not available.</para><para><para>SAX 1.0 </para><para>David Megginson </para><para>2.0.1 (sax2r2) </para><para>org.xml.sax.ContentHandler::setDocumentLocator </para></para>    
		/// </summary>
		/// <java-name>
		/// org/xml/sax/Locator
		/// </java-name>
		[Dot42.DexImport("org/xml/sax/Locator", AccessFlags = 1537)]
		public partial interface ILocator
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Return the public identifier for the current document event.</para><para>The return value is the public identifier of the document entity or of the external parsed entity in which the markup triggering the event appears.</para><para><para>getSystemId </para></para>        
				/// </summary>
				/// <returns>
				/// <para>A string containing the public identifier, or null if none is available. </para>
				/// </returns>
				/// <java-name>
				/// getPublicId
				/// </java-name>
				[Dot42.DexImport("getPublicId", "()Ljava/lang/String;", AccessFlags = 1025)]
				string GetPublicId() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Return the system identifier for the current document event.</para><para>The return value is the system identifier of the document entity or of the external parsed entity in which the markup triggering the event appears.</para><para>If the system identifier is a URL, the parser must resolve it fully before passing it to the application. For example, a file name must always be provided as a <b>.</b> URL, and other kinds of relative URI are also resolved against their bases.</para><para><para>getPublicId </para></para>        
				/// </summary>
				/// <returns>
				/// <para>A string containing the system identifier, or null if none is available. </para>
				/// </returns>
				/// <java-name>
				/// getSystemId
				/// </java-name>
				[Dot42.DexImport("getSystemId", "()Ljava/lang/String;", AccessFlags = 1025)]
				string GetSystemId() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Return the line number where the current document event ends. Lines are delimited by line ends, which are defined in the XML specification.</para><para><b>Warning:</b> The return value from the method is intended only as an approximation for the sake of diagnostics; it is not intended to provide sufficient information to edit the character content of the original XML document. In some cases, these "line" numbers match what would be displayed as columns, and in others they may not match the source text due to internal entity expansion. </para><para>The return value is an approximation of the line number in the document entity or external parsed entity where the markup triggering the event appears.</para><para>If possible, the SAX driver should provide the line position of the first character after the text associated with the document event. The first line is line 1.</para><para><para>getColumnNumber </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The line number, or -1 if none is available. </para>
				/// </returns>
				/// <java-name>
				/// getLineNumber
				/// </java-name>
				[Dot42.DexImport("getLineNumber", "()I", AccessFlags = 1025)]
				int GetLineNumber() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Return the column number where the current document event ends. This is one-based number of Java <code>char</code> values since the last line end.</para><para><b>Warning:</b> The return value from the method is intended only as an approximation for the sake of diagnostics; it is not intended to provide sufficient information to edit the character content of the original XML document. For example, when lines contain combining character sequences, wide characters, surrogate pairs, or bi-directional text, the value may not correspond to the column in a text editor's display. </para><para>The return value is an approximation of the column number in the document entity or external parsed entity where the markup triggering the event appears.</para><para>If possible, the SAX driver should provide the line position of the first character after the text associated with the document event. The first column in each line is column 1.</para><para><para>getLineNumber </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The column number, or -1 if none is available. </para>
				/// </returns>
				/// <java-name>
				/// getColumnNumber
				/// </java-name>
				[Dot42.DexImport("getColumnNumber", "()I", AccessFlags = 1025)]
				int GetColumnNumber() /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>Interface for reading an XML document using callbacks.</para><para><blockquote><para><b>This module, both source code and documentation, is in the Public Domain, and comes with <b>NO WARRANTY</b>.</b> See  for further information. </para></blockquote></para><para><b>Note:</b> despite its name, this interface does <b>not</b> extend the standard Java Reader interface, because reading XML is a fundamentally different activity than reading character data.</para><para>XMLReader is the interface that an XML parser's SAX2 driver must implement. This interface allows an application to set and query features and properties in the parser, to register event handlers for document processing, and to initiate a document parse.</para><para>All SAX interfaces are assumed to be synchronous: the parse methods must not return until parsing is complete, and readers must wait for an event-handler callback to return before reporting the next event.</para><para>This interface replaces the (now deprecated) SAX 1.0 Parser interface. The XMLReader interface contains two important enhancements over the old Parser interface (as well as some minor ones):</para><para><ol><li><para>it adds a standard way to query and set features and properties; and </para></li><li><para>it adds Namespace support, which is required for many higher-level XML standards. </para></li></ol></para><para>There are adapters available to convert a SAX1 Parser to a SAX2 XMLReader and vice-versa.</para><para><para>SAX 2.0 </para><para>David Megginson </para><para>2.0.1+ (sax2r3pre1) </para><para>org.xml.sax.XMLFilter </para><simplesectsep></simplesectsep><para>org.xml.sax.helpers.ParserAdapter </para><simplesectsep></simplesectsep><para>org.xml.sax.helpers.XMLReaderAdapter </para></para>    
		/// </summary>
		/// <java-name>
		/// org/xml/sax/XMLReader
		/// </java-name>
		[Dot42.DexImport("org/xml/sax/XMLReader", AccessFlags = 1537)]
		public partial interface IXMLReader
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Look up the value of a feature flag.</para><para>The feature name is any fully-qualified URI. It is possible for an XMLReader to recognize a feature name but temporarily be unable to return its value. Some feature values may be available only in specific contexts, such as before, during, or after a parse. Also, some feature values may not be programmatically accessible. (In the case of an adapter for SAX1 Parser, there is no implementation-independent way to expose whether the underlying parser is performing validation, expanding external entities, and so forth.) </para><para>All XMLReaders are required to recognize the  and the  feature names.</para><para>Typical usage is something like this:</para><para><pre>
				///        XMLReader r = new MySAXDriver();
				/// 
				///                                // try to activate validation
				///        try {
				///          r.setFeature("http://xml.org/sax/features/validation", true);
				///        } catch (SAXException e) {
				///          System.err.println("Cannot activate validation.");
				///        }
				/// 
				///                                // register event handlers
				///        r.setContentHandler(new MyContentHandler());
				///        r.setErrorHandler(new MyErrorHandler());
				/// 
				///                                // parse the first document
				///        try {
				///          r.parse("http://www.foo.com/mydoc.xml");
				///        } catch (IOException e) {
				///          System.err.println("I/O exception reading XML document");
				///        } catch (SAXException e) {
				///          System.err.println("XML exception reading document.");
				///        }
				///        </pre></para><para>Implementors are free (and encouraged) to invent their own features, using names built on their own URIs.</para><para><para>setFeature </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The current value of the feature (true or false). </para>
				/// </returns>
				/// <java-name>
				/// getFeature
				/// </java-name>
				[Dot42.DexImport("getFeature", "(Ljava/lang/String;)Z", AccessFlags = 1025)]
				bool GetFeature(string name) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Set the value of a feature flag.</para><para>The feature name is any fully-qualified URI. It is possible for an XMLReader to expose a feature value but to be unable to change the current value. Some feature values may be immutable or mutable only in specific contexts, such as before, during, or after a parse.</para><para>All XMLReaders are required to support setting  to true and  to false.</para><para><para>getFeature </para></para>        
				/// </summary>
				/// <java-name>
				/// setFeature
				/// </java-name>
				[Dot42.DexImport("setFeature", "(Ljava/lang/String;Z)V", AccessFlags = 1025)]
				void SetFeature(string name, bool value) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Look up the value of a property.</para><para>The property name is any fully-qualified URI. It is possible for an XMLReader to recognize a property name but temporarily be unable to return its value. Some property values may be available only in specific contexts, such as before, during, or after a parse.</para><para>XMLReaders are not required to recognize any specific property names, though an initial core set is documented for SAX2.</para><para>Implementors are free (and encouraged) to invent their own properties, using names built on their own URIs.</para><para><para>setProperty </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The current value of the property. </para>
				/// </returns>
				/// <java-name>
				/// getProperty
				/// </java-name>
				[Dot42.DexImport("getProperty", "(Ljava/lang/String;)Ljava/lang/Object;", AccessFlags = 1025)]
				object GetProperty(string name) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Set the value of a property.</para><para>The property name is any fully-qualified URI. It is possible for an XMLReader to recognize a property name but to be unable to change the current value. Some property values may be immutable or mutable only in specific contexts, such as before, during, or after a parse.</para><para>XMLReaders are not required to recognize setting any specific property names, though a core set is defined by SAX2.</para><para>This method is also the standard mechanism for setting extended handlers.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setProperty
				/// </java-name>
				[Dot42.DexImport("setProperty", "(Ljava/lang/String;Ljava/lang/Object;)V", AccessFlags = 1025)]
				void SetProperty(string name, object value) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Allow an application to register an entity resolver.</para><para>If the application does not register an entity resolver, the XMLReader will perform its own default resolution.</para><para>Applications may register a new or different resolver in the middle of a parse, and the SAX parser must begin using the new resolver immediately.</para><para><para>getEntityResolver </para></para>        
				/// </summary>
				/// <java-name>
				/// setEntityResolver
				/// </java-name>
				[Dot42.DexImport("setEntityResolver", "(Lorg/xml/sax/EntityResolver;)V", AccessFlags = 1025)]
				void SetEntityResolver(global::Org.Xml.Sax.IEntityResolver resolver) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Return the current entity resolver.</para><para><para>setEntityResolver </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The current entity resolver, or null if none has been registered. </para>
				/// </returns>
				/// <java-name>
				/// getEntityResolver
				/// </java-name>
				[Dot42.DexImport("getEntityResolver", "()Lorg/xml/sax/EntityResolver;", AccessFlags = 1025)]
				global::Org.Xml.Sax.IEntityResolver GetEntityResolver() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Allow an application to register a DTD event handler.</para><para>If the application does not register a DTD handler, all DTD events reported by the SAX parser will be silently ignored.</para><para>Applications may register a new or different handler in the middle of a parse, and the SAX parser must begin using the new handler immediately.</para><para><para>getDTDHandler </para></para>        
				/// </summary>
				/// <java-name>
				/// setDTDHandler
				/// </java-name>
				[Dot42.DexImport("setDTDHandler", "(Lorg/xml/sax/DTDHandler;)V", AccessFlags = 1025)]
				void SetDTDHandler(global::Org.Xml.Sax.IDTDHandler handler) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Return the current DTD handler.</para><para><para>setDTDHandler </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The current DTD handler, or null if none has been registered. </para>
				/// </returns>
				/// <java-name>
				/// getDTDHandler
				/// </java-name>
				[Dot42.DexImport("getDTDHandler", "()Lorg/xml/sax/DTDHandler;", AccessFlags = 1025)]
				global::Org.Xml.Sax.IDTDHandler GetDTDHandler() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Allow an application to register a content event handler.</para><para>If the application does not register a content handler, all content events reported by the SAX parser will be silently ignored.</para><para>Applications may register a new or different handler in the middle of a parse, and the SAX parser must begin using the new handler immediately.</para><para><para>getContentHandler </para></para>        
				/// </summary>
				/// <java-name>
				/// setContentHandler
				/// </java-name>
				[Dot42.DexImport("setContentHandler", "(Lorg/xml/sax/ContentHandler;)V", AccessFlags = 1025)]
				void SetContentHandler(global::Org.Xml.Sax.IContentHandler handler) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Return the current content handler.</para><para><para>setContentHandler </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The current content handler, or null if none has been registered. </para>
				/// </returns>
				/// <java-name>
				/// getContentHandler
				/// </java-name>
				[Dot42.DexImport("getContentHandler", "()Lorg/xml/sax/ContentHandler;", AccessFlags = 1025)]
				global::Org.Xml.Sax.IContentHandler GetContentHandler() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Allow an application to register an error event handler.</para><para>If the application does not register an error handler, all error events reported by the SAX parser will be silently ignored; however, normal processing may not continue. It is highly recommended that all SAX applications implement an error handler to avoid unexpected bugs.</para><para>Applications may register a new or different handler in the middle of a parse, and the SAX parser must begin using the new handler immediately.</para><para><para>getErrorHandler </para></para>        
				/// </summary>
				/// <java-name>
				/// setErrorHandler
				/// </java-name>
				[Dot42.DexImport("setErrorHandler", "(Lorg/xml/sax/ErrorHandler;)V", AccessFlags = 1025)]
				void SetErrorHandler(global::Org.Xml.Sax.IErrorHandler handler) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Return the current error handler.</para><para><para>setErrorHandler </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The current error handler, or null if none has been registered. </para>
				/// </returns>
				/// <java-name>
				/// getErrorHandler
				/// </java-name>
				[Dot42.DexImport("getErrorHandler", "()Lorg/xml/sax/ErrorHandler;", AccessFlags = 1025)]
				global::Org.Xml.Sax.IErrorHandler GetErrorHandler() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Parse an XML document.</para><para>The application can use this method to instruct the XML reader to begin parsing an XML document from any valid input source (a character stream, a byte stream, or a URI).</para><para>Applications may not invoke this method while a parse is in progress (they should create a new XMLReader instead for each nested XML document). Once a parse is complete, an application may reuse the same XMLReader object, possibly with a different input source. Configuration of the XMLReader object (such as handler bindings and values established for feature flags and properties) is unchanged by completion of a parse, unless the definition of that aspect of the configuration explicitly specifies other behavior. (For example, feature flags or properties exposing characteristics of the document being parsed.) </para><para>During the parse, the XMLReader will provide information about the XML document through the registered event handlers.</para><para>This method is synchronous: it will not return until parsing has ended. If a client application wants to terminate parsing early, it should throw an exception.</para><para><para>org.xml.sax.InputSource </para><simplesectsep></simplesectsep><para>parse(java.lang.String) </para><simplesectsep></simplesectsep><para>setEntityResolver </para><simplesectsep></simplesectsep><para>setDTDHandler </para><simplesectsep></simplesectsep><para>setContentHandler </para><simplesectsep></simplesectsep><para>setErrorHandler </para></para>        
				/// </summary>
				/// <java-name>
				/// parse
				/// </java-name>
				[Dot42.DexImport("parse", "(Lorg/xml/sax/InputSource;)V", AccessFlags = 1025)]
				void Parse(global::Org.Xml.Sax.InputSource input) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Parse an XML document.</para><para>The application can use this method to instruct the XML reader to begin parsing an XML document from any valid input source (a character stream, a byte stream, or a URI).</para><para>Applications may not invoke this method while a parse is in progress (they should create a new XMLReader instead for each nested XML document). Once a parse is complete, an application may reuse the same XMLReader object, possibly with a different input source. Configuration of the XMLReader object (such as handler bindings and values established for feature flags and properties) is unchanged by completion of a parse, unless the definition of that aspect of the configuration explicitly specifies other behavior. (For example, feature flags or properties exposing characteristics of the document being parsed.) </para><para>During the parse, the XMLReader will provide information about the XML document through the registered event handlers.</para><para>This method is synchronous: it will not return until parsing has ended. If a client application wants to terminate parsing early, it should throw an exception.</para><para><para>org.xml.sax.InputSource </para><simplesectsep></simplesectsep><para>parse(java.lang.String) </para><simplesectsep></simplesectsep><para>setEntityResolver </para><simplesectsep></simplesectsep><para>setDTDHandler </para><simplesectsep></simplesectsep><para>setContentHandler </para><simplesectsep></simplesectsep><para>setErrorHandler </para></para>        
				/// </summary>
				/// <java-name>
				/// parse
				/// </java-name>
				[Dot42.DexImport("parse", "(Ljava/lang/String;)V", AccessFlags = 1025)]
				void Parse(string input) /* MethodBuilder.Create */ ;

		}

}


