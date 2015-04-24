#pragma warning disable 1717
namespace Org.Xmlpull.V1.Sax2
{
		/// <summary>
		///  <para>SAX2 Driver that pulls events from XmlPullParser and comverts them into SAX2 callbacks.</para> <para> <para> </para></para>    
		/// </summary>
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
				public Driver(global::Org.Xmlpull.V1.IXmlPullParser pp) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Look up an attribute's Namespace URI by index.</para> <para> <para>getLength </para></para>        
				/// </summary>
				/// <returns>
				///  <para>The Namespace URI, or the empty string if none is available, or null if the index is out of range. </para>
				/// </returns>
				/// <java-name>
				/// getURI
				/// </java-name>
				[Dot42.DexImport("getURI", "(I)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetURI(int index) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Look up an attribute's local name by index.</para> <para> <para>getLength </para></para>        
				/// </summary>
				/// <returns>
				///  <para>The local name, or the empty string if Namespace processing is not being performed, or null if the index is out of range. </para>
				/// </returns>
				/// <java-name>
				/// getLocalName
				/// </java-name>
				[Dot42.DexImport("getLocalName", "(I)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetLocalName(int index) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Look up an attribute's XML qualified (prefixed) name by index.</para> <para> <para>getLength </para></para>        
				/// </summary>
				/// <returns>
				///  <para>The XML qualified name, or the empty string if none is available, or null if the index is out of range. </para>
				/// </returns>
				/// <java-name>
				/// getQName
				/// </java-name>
				[Dot42.DexImport("getQName", "(I)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetQName(int index) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Look up an attribute's type by index.</para> <para>The attribute type is one of the strings "CDATA", "ID", "IDREF", "IDREFS", "NMTOKEN", "NMTOKENS", "ENTITY", "ENTITIES", or "NOTATION" (always in upper case).</para> <para>If the parser has not read a declaration for the attribute, or if the parser does not report attribute types, then it must return the value "CDATA" as stated in the XML 1.0 Recommendation (clause 3.3.3, "Attribute-Value Normalization").</para> <para>For an enumerated attribute that is not a notation, the parser will report the type as "NMTOKEN".</para> <para> <para>getLength </para></para>        
				/// </summary>
				/// <returns>
				///  <para>The attribute's type as a string, or null if the index is out of range. </para>
				/// </returns>
				/// <java-name>
				/// getType
				/// </java-name>
				[Dot42.DexImport("getType", "(I)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetType(int index) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Look up an attribute's value by index.</para> <para>If the attribute value is a list of tokens (IDREFS, ENTITIES, or NMTOKENS), the tokens will be concatenated into a single string with each token separated by a single space.</para> <para> <para>getLength </para></para>        
				/// </summary>
				/// <returns>
				///  <para>The attribute's value as a string, or null if the index is out of range. </para>
				/// </returns>
				/// <java-name>
				/// getValue
				/// </java-name>
				[Dot42.DexImport("getValue", "(I)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetValue(int index) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Look up the index of an attribute by Namespace name.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The index of the attribute, or -1 if it does not appear in the list. </para>
				/// </returns>
				/// <java-name>
				/// getIndex
				/// </java-name>
				[Dot42.DexImport("getIndex", "(Ljava/lang/String;Ljava/lang/String;)I", AccessFlags = 1)]
				public virtual int GetIndex(string uri, string localName) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Look up the index of an attribute by XML qualified (prefixed) name.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The index of the attribute, or -1 if it does not appear in the list. </para>
				/// </returns>
				/// <java-name>
				/// getIndex
				/// </java-name>
				[Dot42.DexImport("getIndex", "(Ljava/lang/String;)I", AccessFlags = 1)]
				public virtual int GetIndex(string qName) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Look up an attribute's type by Namespace name.</para> <para>See getType(int) for a description of the possible types.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The attribute type as a string, or null if the attribute is not in the list or if Namespace processing is not being performed. </para>
				/// </returns>
				/// <java-name>
				/// getType
				/// </java-name>
				[Dot42.DexImport("getType", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetType(string uri, string localName) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Look up an attribute's type by index.</para> <para>The attribute type is one of the strings "CDATA", "ID", "IDREF", "IDREFS", "NMTOKEN", "NMTOKENS", "ENTITY", "ENTITIES", or "NOTATION" (always in upper case).</para> <para>If the parser has not read a declaration for the attribute, or if the parser does not report attribute types, then it must return the value "CDATA" as stated in the XML 1.0 Recommendation (clause 3.3.3, "Attribute-Value Normalization").</para> <para>For an enumerated attribute that is not a notation, the parser will report the type as "NMTOKEN".</para> <para> <para>getLength </para></para>        
				/// </summary>
				/// <returns>
				///  <para>The attribute's type as a string, or null if the index is out of range. </para>
				/// </returns>
				/// <java-name>
				/// getType
				/// </java-name>
				[Dot42.DexImport("getType", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetType(string index) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Look up an attribute's value by Namespace name.</para> <para>See getValue(int) for a description of the possible values.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The attribute value as a string, or null if the attribute is not in the list. </para>
				/// </returns>
				/// <java-name>
				/// getValue
				/// </java-name>
				[Dot42.DexImport("getValue", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetValue(string uri, string localName) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Look up an attribute's value by index.</para> <para>If the attribute value is a list of tokens (IDREFS, ENTITIES, or NMTOKENS), the tokens will be concatenated into a single string with each token separated by a single space.</para> <para> <para>getLength </para></para>        
				/// </summary>
				/// <returns>
				///  <para>The attribute's value as a string, or null if the index is out of range. </para>
				/// </returns>
				/// <java-name>
				/// getValue
				/// </java-name>
				[Dot42.DexImport("getValue", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetValue(string index) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Look up the value of a feature flag.</para> <para>The feature name is any fully-qualified URI. It is possible for an XMLReader to recognize a feature name but temporarily be unable to return its value. Some feature values may be available only in specific contexts, such as before, during, or after a parse. Also, some feature values may not be programmatically accessible. (In the case of an adapter for SAX1 Parser, there is no implementation-independent way to expose whether the underlying parser is performing validation, expanding external entities, and so forth.) </para> <para>All XMLReaders are required to recognize the  and the  feature names.</para> <para>Typical usage is something like this:</para> <para> <pre>
				/// XMLReader r = new MySAXDriver();</pre></para> <para> <pre>                        // try to activate validation
				/// try {
				///   r.setFeature("http://xml.org/sax/features/validation", true);
				/// } catch (SAXException e) {
				///   System.err.println("Cannot activate validation.");
				/// }</pre></para> <para> <pre>                        // register event handlers
				/// r.setContentHandler(new MyContentHandler());
				/// r.setErrorHandler(new MyErrorHandler());</pre></para> <para> <pre>                        // parse the first document
				/// try {
				///   r.parse("http://www.foo.com/mydoc.xml");
				/// } catch (IOException e) {
				///   System.err.println("I/O exception reading XML document");
				/// } catch (SAXException e) {
				///   System.err.println("XML exception reading document.");
				/// }
				/// </pre></para> <para>Implementors are free (and encouraged) to invent their own features, using names built on their own URIs.</para> <para> <para>setFeature </para></para>        
				/// </summary>
				/// <returns>
				///  <para>The current value of the feature (true or false). </para>
				/// </returns>
				/// <java-name>
				/// getFeature
				/// </java-name>
				[Dot42.DexImport("getFeature", "(Ljava/lang/String;)Z", AccessFlags = 1)]
				public virtual bool GetFeature(string name) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Set the value of a feature flag.</para> <para>The feature name is any fully-qualified URI. It is possible for an XMLReader to expose a feature value but to be unable to change the current value. Some feature values may be immutable or mutable only in specific contexts, such as before, during, or after a parse.</para> <para>All XMLReaders are required to support setting  to true and  to false.</para> <para> <para>getFeature </para></para>        
				/// </summary>
				/// <java-name>
				/// setFeature
				/// </java-name>
				[Dot42.DexImport("setFeature", "(Ljava/lang/String;Z)V", AccessFlags = 1)]
				public virtual void SetFeature(string name, bool value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Look up the value of a property.</para> <para>The property name is any fully-qualified URI. It is possible for an XMLReader to recognize a property name but temporarily be unable to return its value. Some property values may be available only in specific contexts, such as before, during, or after a parse.</para> <para>XMLReaders are not required to recognize any specific property names, though an initial core set is documented for SAX2.</para> <para>Implementors are free (and encouraged) to invent their own properties, using names built on their own URIs.</para> <para> <para>setProperty </para></para>        
				/// </summary>
				/// <returns>
				///  <para>The current value of the property. </para>
				/// </returns>
				/// <java-name>
				/// getProperty
				/// </java-name>
				[Dot42.DexImport("getProperty", "(Ljava/lang/String;)Ljava/lang/Object;", AccessFlags = 1)]
				public virtual object GetProperty(string name) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <summary>
				///  <para>Set the value of a property.</para> <para>The property name is any fully-qualified URI. It is possible for an XMLReader to recognize a property name but to be unable to change the current value. Some property values may be immutable or mutable only in specific contexts, such as before, during, or after a parse.</para> <para>XMLReaders are not required to recognize setting any specific property names, though a core set is defined by SAX2.</para> <para>This method is also the standard mechanism for setting extended handlers.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setProperty
				/// </java-name>
				[Dot42.DexImport("setProperty", "(Ljava/lang/String;Ljava/lang/Object;)V", AccessFlags = 1)]
				public virtual void SetProperty(string name, object value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Parse an XML document.</para> <para>The application can use this method to instruct the XML reader to begin parsing an XML document from any valid input source (a character stream, a byte stream, or a URI).</para> <para>Applications may not invoke this method while a parse is in progress (they should create a new XMLReader instead for each nested XML document). Once a parse is complete, an application may reuse the same XMLReader object, possibly with a different input source. Configuration of the XMLReader object (such as handler bindings and values established for feature flags and properties) is unchanged by completion of a parse, unless the definition of that aspect of the configuration explicitly specifies other behavior. (For example, feature flags or properties exposing characteristics of the document being parsed.) </para> <para>During the parse, the XMLReader will provide information about the XML document through the registered event handlers.</para> <para>This method is synchronous: it will not return until parsing has ended. If a client application wants to terminate parsing early, it should throw an exception.</para> <para> <para>org.xml.sax.InputSource </para> <para>parse(java.lang.String) </para> <para>setEntityResolver </para> <para>setDTDHandler </para> <para>setContentHandler </para> <para>setErrorHandler </para></para>        
				/// </summary>
				/// <java-name>
				/// parse
				/// </java-name>
				[Dot42.DexImport("parse", "(Lorg/xml/sax/InputSource;)V", AccessFlags = 1)]
				public virtual void Parse(global::Org.Xml.Sax.InputSource input) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Parse an XML document.</para> <para>The application can use this method to instruct the XML reader to begin parsing an XML document from any valid input source (a character stream, a byte stream, or a URI).</para> <para>Applications may not invoke this method while a parse is in progress (they should create a new XMLReader instead for each nested XML document). Once a parse is complete, an application may reuse the same XMLReader object, possibly with a different input source. Configuration of the XMLReader object (such as handler bindings and values established for feature flags and properties) is unchanged by completion of a parse, unless the definition of that aspect of the configuration explicitly specifies other behavior. (For example, feature flags or properties exposing characteristics of the document being parsed.) </para> <para>During the parse, the XMLReader will provide information about the XML document through the registered event handlers.</para> <para>This method is synchronous: it will not return until parsing has ended. If a client application wants to terminate parsing early, it should throw an exception.</para> <para> <para>org.xml.sax.InputSource </para> <para>parse(java.lang.String) </para> <para>setEntityResolver </para> <para>setDTDHandler </para> <para>setContentHandler </para> <para>setErrorHandler </para></para>        
				/// </summary>
				/// <java-name>
				/// parse
				/// </java-name>
				[Dot42.DexImport("parse", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void Parse(string input) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// parseSubTree
				/// </java-name>
				[Dot42.DexImport("parseSubTree", "(Lorg/xmlpull/v1/XmlPullParser;)V", AccessFlags = 1)]
				public virtual void ParseSubTree(global::Org.Xmlpull.V1.IXmlPullParser pp) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Calls startElement on the  <code>ContentHandler</code> with  <code>this</code> driver object as the Attributes implementation. In default implementation Attributes object is valid only during this method call and may not be stored. Sub-classes can overwrite this method to cache attributes. </para>        
				/// </summary>
				/// <java-name>
				/// startElement
				/// </java-name>
				[Dot42.DexImport("startElement", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 4)]
				protected internal virtual void StartElement(string @namespace, string localName, string qName) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Return the number of attributes in the list.</para> <para>Once you know the number of attributes, you can iterate through the list.</para> <para> <para>getURI(int) </para> <para>getLocalName(int) </para> <para>getQName(int) </para> <para>getType(int) </para> <para>getValue(int) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>The number of attributes in the list. </para>
				/// </returns>
				/// <java-name>
				/// getLength
				/// </java-name>
				public virtual int Length
				{
						[Dot42.DexImport("getLength", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Return the public identifier for the current document event.</para> <para>The return value is the public identifier of the document entity or of the external parsed entity in which the markup triggering the event appears.</para> <para> <para>getSystemId </para></para>        
				/// </summary>
				/// <returns>
				///  <para>A string containing the public identifier, or null if none is available. </para>
				/// </returns>
				/// <java-name>
				/// getPublicId
				/// </java-name>
				public virtual string PublicId
				{
						[Dot42.DexImport("getPublicId", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>Return the system identifier for the current document event.</para> <para>The return value is the system identifier of the document entity or of the external parsed entity in which the markup triggering the event appears.</para> <para>If the system identifier is a URL, the parser must resolve it fully before passing it to the application. For example, a file name must always be provided as a  <b>.</b> URL, and other kinds of relative URI are also resolved against their bases.</para> <para> <para>getPublicId </para></para>        
				/// </summary>
				/// <returns>
				///  <para>A string containing the system identifier, or null if none is available. </para>
				/// </returns>
				/// <java-name>
				/// getSystemId
				/// </java-name>
				public virtual string SystemId
				{
						[Dot42.DexImport("getSystemId", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>Return the line number where the current document event ends. Lines are delimited by line ends, which are defined in the XML specification.</para> <para> <b>Warning:</b> The return value from the method is intended only as an approximation for the sake of diagnostics; it is not intended to provide sufficient information to edit the character content of the original XML document. In some cases, these "line" numbers match what would be displayed as columns, and in others they may not match the source text due to internal entity expansion. </para> <para>The return value is an approximation of the line number in the document entity or external parsed entity where the markup triggering the event appears.</para> <para>If possible, the SAX driver should provide the line position of the first character after the text associated with the document event. The first line is line 1.</para> <para> <para>getColumnNumber </para></para>        
				/// </summary>
				/// <returns>
				///  <para>The line number, or -1 if none is available. </para>
				/// </returns>
				/// <java-name>
				/// getLineNumber
				/// </java-name>
				public virtual int LineNumber
				{
						[Dot42.DexImport("getLineNumber", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Return the column number where the current document event ends. This is one-based number of Java  <code>char</code> values since the last line end.</para> <para> <b>Warning:</b> The return value from the method is intended only as an approximation for the sake of diagnostics; it is not intended to provide sufficient information to edit the character content of the original XML document. For example, when lines contain combining character sequences, wide characters, surrogate pairs, or bi-directional text, the value may not correspond to the column in a text editor's display. </para> <para>The return value is an approximation of the column number in the document entity or external parsed entity where the markup triggering the event appears.</para> <para>If possible, the SAX driver should provide the line position of the first character after the text associated with the document event. The first column in each line is column 1.</para> <para> <para>getLineNumber </para></para>        
				/// </summary>
				/// <returns>
				///  <para>The column number, or -1 if none is available. </para>
				/// </returns>
				/// <java-name>
				/// getColumnNumber
				/// </java-name>
				public virtual int ColumnNumber
				{
						[Dot42.DexImport("getColumnNumber", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Return the current entity resolver.</para> <para> <para>setEntityResolver </para></para>        
				/// </summary>
				/// <returns>
				///  <para>The current entity resolver, or null if none has been registered. </para>
				/// </returns>
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

				/// <summary>
				///  <para>Return the current DTD handler.</para> <para> <para>setDTDHandler </para></para>        
				/// </summary>
				/// <returns>
				///  <para>The current DTD handler, or null if none has been registered. </para>
				/// </returns>
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

				/// <summary>
				///  <para>Return the current content handler.</para> <para> <para>setContentHandler </para></para>        
				/// </summary>
				/// <returns>
				///  <para>The current content handler, or null if none has been registered. </para>
				/// </returns>
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

				/// <summary>
				///  <para>Return the current error handler.</para> <para> <para>setErrorHandler </para></para>        
				/// </summary>
				/// <returns>
				///  <para>The current error handler, or null if none has been registered. </para>
				/// </returns>
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

