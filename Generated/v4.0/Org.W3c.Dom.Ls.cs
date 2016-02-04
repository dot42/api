#pragma warning disable 1717
namespace Org.W3c.Dom.Ls
{
		/// <summary>
		///  <para> <code>DOMImplementationLS</code> contains the factory methods for creating Load and Save objects. </para> <para>The expectation is that an instance of the  <code>DOMImplementationLS</code> interface can be obtained by using binding-specific casting methods on an instance of the  <code>DOMImplementation</code> interface or, if the  <code>Document</code> supports the feature  <code>"Core"</code> version  <code>"3.0"</code> defined in [] , by using the method  <code>DOMImplementation.getFeature</code> with parameter values  <code>"LS"</code> (or  <code>"LS-Async"</code>) and  <code>"3.0"</code> (respectively). </para> <para>See also the . </para>    
		/// </summary>
		/// <java-name>
		/// org/w3c/dom/ls/DOMImplementationLS
		/// </java-name>
		[Dot42.DexImport("org/w3c/dom/ls/DOMImplementationLS", AccessFlags = 1537)]
		public partial interface IDOMImplementationLS
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Create a new  <code>LSParser</code>. The newly constructed parser may then be configured by means of its  <code>DOMConfiguration</code> object, and used to parse documents by means of its  <code>parse</code> method.  <b>Note:</b> For W3C XML Schema [] , applications must use the value  <code>"http://www.w3.org/2001/XMLSchema"</code>. For XML DTD [], applications must use the value  <code>"http://www.w3.org/TR/REC-xml"</code>. Other Schema languages are outside the scope of the W3C and therefore should recommend an absolute URI in order to use this method.  <b>Note:</b> By default, the newly created  <code>LSParser</code> does not contain a  <code>DOMErrorHandler</code>, i.e. the value of the "&lt;a href='http://www.w3.org/TR/DOM-Level-3-Core/core.html#parameter-error-handler'&gt;  error-handler&lt;/a&gt;" configuration parameter is  <code>null</code>. However, implementations may provide a default error handler at creation time. In that case, the initial value of the  <code>"error-handler"</code> configuration parameter on the new  <code>LSParser</code> object contains a reference to the default error handler. </para>        
				/// </summary>
				/// <returns>
				///  <para>The newly created  <code>LSParser</code> object. This  <code>LSParser</code> is either synchronous or asynchronous depending on the value of the  <code>mode</code> argument. </para>
				/// </returns>
				/// <java-name>
				/// createLSParser
				/// </java-name>
				[Dot42.DexImport("createLSParser", "(SLjava/lang/String;)Lorg/w3c/dom/ls/LSParser;", AccessFlags = 1025)]
				global::Org.W3c.Dom.Ls.ILSParser CreateLSParser(short mode, string schemaType) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Create a new  <code>LSSerializer</code> object.  <b>Note:</b> By default, the newly created  <code>LSSerializer</code> has no  <code>DOMErrorHandler</code>, i.e. the value of the  <code>"error-handler"</code> configuration parameter is  <code>null</code>. However, implementations may provide a default error handler at creation time. In that case, the initial value of the  <code>"error-handler"</code> configuration parameter on the new  <code>LSSerializer</code> object contains a reference to the default error handler. </para>        
				/// </summary>
				/// <returns>
				///  <para>The newly created  <code>LSSerializer</code> object. </para>
				/// </returns>
				/// <java-name>
				/// createLSSerializer
				/// </java-name>
				[Dot42.DexImport("createLSSerializer", "()Lorg/w3c/dom/ls/LSSerializer;", AccessFlags = 1025)]
				global::Org.W3c.Dom.Ls.ILSSerializer CreateLSSerializer() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Create a new empty input source object where  <code>LSInput.characterStream</code>,  <code>LSInput.byteStream</code> ,  <code>LSInput.stringData</code>  <code>LSInput.systemId</code>,  <code>LSInput.publicId</code>,  <code>LSInput.baseURI</code>, and  <code>LSInput.encoding</code> are null, and  <code>LSInput.certifiedText</code> is false. </para>        
				/// </summary>
				/// <returns>
				///  <para>The newly created input object. </para>
				/// </returns>
				/// <java-name>
				/// createLSInput
				/// </java-name>
				[Dot42.DexImport("createLSInput", "()Lorg/w3c/dom/ls/LSInput;", AccessFlags = 1025)]
				global::Org.W3c.Dom.Ls.ILSInput CreateLSInput() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Create a new empty output destination object where  <code>LSOutput.characterStream</code>,  <code>LSOutput.byteStream</code>,  <code>LSOutput.systemId</code>,  <code>LSOutput.encoding</code> are null. </para>        
				/// </summary>
				/// <returns>
				///  <para>The newly created output object. </para>
				/// </returns>
				/// <java-name>
				/// createLSOutput
				/// </java-name>
				[Dot42.DexImport("createLSOutput", "()Lorg/w3c/dom/ls/LSOutput;", AccessFlags = 1025)]
				global::Org.W3c.Dom.Ls.ILSOutput CreateLSOutput() /* MethodBuilder.Create */ ;

		}

		/// <summary>
		///  <para> <code>DOMImplementationLS</code> contains the factory methods for creating Load and Save objects. </para> <para>The expectation is that an instance of the  <code>DOMImplementationLS</code> interface can be obtained by using binding-specific casting methods on an instance of the  <code>DOMImplementation</code> interface or, if the  <code>Document</code> supports the feature  <code>"Core"</code> version  <code>"3.0"</code> defined in [] , by using the method  <code>DOMImplementation.getFeature</code> with parameter values  <code>"LS"</code> (or  <code>"LS-Async"</code>) and  <code>"3.0"</code> (respectively). </para> <para>See also the . </para>    
		/// </summary>
		/// <java-name>
		/// org/w3c/dom/ls/DOMImplementationLS
		/// </java-name>
		[Dot42.DexImport("org/w3c/dom/ls/DOMImplementationLS", AccessFlags = 1537, IgnoreFromJava = true, Priority = 1)]
		public static partial class IDOMImplementationLSConstants
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Create a synchronous  <code>LSParser</code>. </para>        
				/// </summary>
				/// <java-name>
				/// MODE_SYNCHRONOUS
				/// </java-name>
				[Dot42.DexImport("MODE_SYNCHRONOUS", "S", AccessFlags = 25)]
				public const short MODE_SYNCHRONOUS = 1;
				/// <summary>
				///  <para>Create an asynchronous  <code>LSParser</code>. </para>        
				/// </summary>
				/// <java-name>
				/// MODE_ASYNCHRONOUS
				/// </java-name>
				[Dot42.DexImport("MODE_ASYNCHRONOUS", "S", AccessFlags = 25)]
				public const short MODE_ASYNCHRONOUS = 2;
		}

		/// <summary>
		///  <para>This interface represents an input source for data. </para> <para>This interface allows an application to encapsulate information about an input source in a single object, which may include a public identifier, a system identifier, a byte stream (possibly with a specified encoding), a base URI, and/or a character stream. </para> <para>The exact definitions of a byte stream and a character stream are binding dependent. </para> <para>The application is expected to provide objects that implement this interface whenever such objects are needed. The application can either provide its own objects that implement this interface, or it can use the generic factory method  <code>DOMImplementationLS.createLSInput()</code> to create objects that implement this interface. </para> <para>The  <code>LSParser</code> will use the  <code>LSInput</code> object to determine how to read data. The  <code>LSParser</code> will look at the different inputs specified in the  <code>LSInput</code> in the following order to know which one to read from, the first one that is not null and not an empty string will be used:  <ol> <li> <para> <code>LSInput.characterStream</code>  </para></li> <li> <para> <code>LSInput.byteStream</code>  </para></li> <li> <para> <code>LSInput.stringData</code>  </para></li> <li> <para> <code>LSInput.systemId</code>  </para></li> <li> <para> <code>LSInput.publicId</code>  </para></li></ol></para> <para>If all inputs are null, the  <code>LSParser</code> will report a  <code>DOMError</code> with its  <code>DOMError.type</code> set to  <code>"no-input-specified"</code> and its  <code>DOMError.severity</code> set to  <code>DOMError.SEVERITY_FATAL_ERROR</code>. </para> <para> <code>LSInput</code> objects belong to the application. The DOM implementation will never modify them (though it may make copies and modify the copies, if necessary). </para> <para>See also the . </para>    
		/// </summary>
		/// <java-name>
		/// org/w3c/dom/ls/LSInput
		/// </java-name>
		[Dot42.DexImport("org/w3c/dom/ls/LSInput", AccessFlags = 1537)]
		public partial interface ILSInput
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>An attribute of a language and binding dependent type that represents a stream of 16-bit units. The application must encode the stream using UTF-16 (defined in [Unicode] and in [ISO/IEC 10646]). It is not a requirement to have an XML declaration when using character streams. If an XML declaration is present, the value of the encoding attribute will be ignored. </para>        
				/// </summary>
				/// <java-name>
				/// getCharacterStream
				/// </java-name>
				global::Java.IO.Reader CharacterStream
				{
						[Dot42.DexImport("getCharacterStream", "()Ljava/io/Reader;", AccessFlags = 1025)]
						get;
						[Dot42.DexImport("setCharacterStream", "(Ljava/io/Reader;)V", AccessFlags = 1025)]
						set;
				}

				/// <summary>
				///  <para>An attribute of a language and binding dependent type that represents a stream of bytes.  <br></br> If the application knows the character encoding of the byte stream, it should set the encoding attribute. Setting the encoding in this way will override any encoding specified in an XML declaration in the data. </para>        
				/// </summary>
				/// <java-name>
				/// getByteStream
				/// </java-name>
				global::Java.IO.InputStream ByteStream
				{
						[Dot42.DexImport("getByteStream", "()Ljava/io/InputStream;", AccessFlags = 1025)]
						get;
						[Dot42.DexImport("setByteStream", "(Ljava/io/InputStream;)V", AccessFlags = 1025)]
						set;
				}

				/// <summary>
				///  <para>String data to parse. If provided, this will always be treated as a sequence of 16-bit units (UTF-16 encoded characters). It is not a requirement to have an XML declaration when using  <code>stringData</code>. If an XML declaration is present, the value of the encoding attribute will be ignored. </para>        
				/// </summary>
				/// <java-name>
				/// getStringData
				/// </java-name>
				string StringData
				{
						[Dot42.DexImport("getStringData", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
						[Dot42.DexImport("setStringData", "(Ljava/lang/String;)V", AccessFlags = 1025)]
						set;
				}

				/// <summary>
				///  <para>The system identifier, a URI reference [], for this input source. The system identifier is optional if there is a byte stream, a character stream, or string data. It is still useful to provide one, since the application will use it to resolve any relative URIs and can include it in error messages and warnings. (The LSParser will only attempt to fetch the resource identified by the URI reference if there is no other input available in the input source.)  <br></br> If the application knows the character encoding of the object pointed to by the system identifier, it can set the encoding using the  <code>encoding</code> attribute.  <br></br> If the specified system ID is a relative URI reference (see section 5 in []), the DOM implementation will attempt to resolve the relative URI with the  <code>baseURI</code> as the base, if that fails, the behavior is implementation dependent. </para>        
				/// </summary>
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

				/// <summary>
				///  <para>The public identifier for this input source. This may be mapped to an input source using an implementation dependent mechanism (such as catalogues or other mappings). The public identifier, if specified, may also be reported as part of the location information when errors are reported. </para>        
				/// </summary>
				/// <java-name>
				/// getPublicId
				/// </java-name>
				string PublicId
				{
						[Dot42.DexImport("getPublicId", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
						[Dot42.DexImport("setPublicId", "(Ljava/lang/String;)V", AccessFlags = 1025)]
						set;
				}

				/// <summary>
				///  <para>The base URI to be used (see section 5.1.4 in []) for resolving a relative  <code>systemId</code> to an absolute URI.  <br></br> If, when used, the base URI is itself a relative URI, an empty string, or null, the behavior is implementation dependent. </para>        
				/// </summary>
				/// <java-name>
				/// getBaseURI
				/// </java-name>
				string BaseURI
				{
						[Dot42.DexImport("getBaseURI", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
						[Dot42.DexImport("setBaseURI", "(Ljava/lang/String;)V", AccessFlags = 1025)]
						set;
				}

				/// <summary>
				///  <para>The character encoding, if known. The encoding must be a string acceptable for an XML encoding declaration ([] section 4.3.3 "Character Encoding in Entities").  <br></br> This attribute has no effect when the application provides a character stream or string data. For other sources of input, an encoding specified by means of this attribute will override any encoding specified in the XML declaration or the Text declaration, or an encoding obtained from a higher level protocol, such as HTTP []. </para>        
				/// </summary>
				/// <java-name>
				/// getEncoding
				/// </java-name>
				string Encoding
				{
						[Dot42.DexImport("getEncoding", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
						[Dot42.DexImport("setEncoding", "(Ljava/lang/String;)V", AccessFlags = 1025)]
						set;
				}

				/// <summary>
				///  <para>If set to true, assume that the input is certified (see section 2.13 in []) when parsing []. </para>        
				/// </summary>
				/// <java-name>
				/// getCertifiedText
				/// </java-name>
				bool CertifiedText
				{
						[Dot42.DexImport("getCertifiedText", "()Z", AccessFlags = 1025)]
						get;
						[Dot42.DexImport("setCertifiedText", "(Z)V", AccessFlags = 1025)]
						set;
				}

		}

		/// <summary>
		///  <para>This interface represents an output destination for data. </para> <para>This interface allows an application to encapsulate information about an output destination in a single object, which may include a URI, a byte stream (possibly with a specified encoding), a base URI, and/or a character stream. </para> <para>The exact definitions of a byte stream and a character stream are binding dependent. </para> <para>The application is expected to provide objects that implement this interface whenever such objects are needed. The application can either provide its own objects that implement this interface, or it can use the generic factory method  <code>DOMImplementationLS.createLSOutput()</code> to create objects that implement this interface. </para> <para>The  <code>LSSerializer</code> will use the  <code>LSOutput</code> object to determine where to serialize the output to. The  <code>LSSerializer</code> will look at the different outputs specified in the  <code>LSOutput</code> in the following order to know which one to output to, the first one that is not null and not an empty string will be used:  <ol> <li> <para> <code>LSOutput.characterStream</code>  </para></li> <li> <para> <code>LSOutput.byteStream</code>  </para></li> <li> <para> <code>LSOutput.systemId</code>  </para></li></ol></para> <para> <code>LSOutput</code> objects belong to the application. The DOM implementation will never modify them (though it may make copies and modify the copies, if necessary). </para> <para>See also the . </para>    
		/// </summary>
		/// <java-name>
		/// org/w3c/dom/ls/LSOutput
		/// </java-name>
		[Dot42.DexImport("org/w3c/dom/ls/LSOutput", AccessFlags = 1537)]
		public partial interface ILSOutput
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>An attribute of a language and binding dependent type that represents a writable stream to which 16-bit units can be output. </para>        
				/// </summary>
				/// <java-name>
				/// getCharacterStream
				/// </java-name>
				global::Java.IO.Writer CharacterStream
				{
						[Dot42.DexImport("getCharacterStream", "()Ljava/io/Writer;", AccessFlags = 1025)]
						get;
						[Dot42.DexImport("setCharacterStream", "(Ljava/io/Writer;)V", AccessFlags = 1025)]
						set;
				}

				/// <summary>
				///  <para>An attribute of a language and binding dependent type that represents a writable stream of bytes. </para>        
				/// </summary>
				/// <java-name>
				/// getByteStream
				/// </java-name>
				global::Java.IO.OutputStream ByteStream
				{
						[Dot42.DexImport("getByteStream", "()Ljava/io/OutputStream;", AccessFlags = 1025)]
						get;
						[Dot42.DexImport("setByteStream", "(Ljava/io/OutputStream;)V", AccessFlags = 1025)]
						set;
				}

				/// <summary>
				///  <para>The system identifier, a URI reference [], for this output destination.  <br></br> If the system ID is a relative URI reference (see section 5 in []), the behavior is implementation dependent. </para>        
				/// </summary>
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

				/// <summary>
				///  <para>The character encoding to use for the output. The encoding must be a string acceptable for an XML encoding declaration ([] section 4.3.3 "Character Encoding in Entities"), it is recommended that character encodings registered (as charsets) with the Internet Assigned Numbers Authority [] should be referred to using their registered names. </para>        
				/// </summary>
				/// <java-name>
				/// getEncoding
				/// </java-name>
				string Encoding
				{
						[Dot42.DexImport("getEncoding", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
						[Dot42.DexImport("setEncoding", "(Ljava/lang/String;)V", AccessFlags = 1025)]
						set;
				}

		}

		/// <summary>
		///  <para>An interface to an object that is able to build, or augment, a DOM tree from various input sources. </para> <para> <code>LSParser</code> provides an API for parsing XML and building the corresponding DOM document structure. A  <code>LSParser</code> instance can be obtained by invoking the  <code>DOMImplementationLS.createLSParser()</code> method. </para> <para>As specified in [] , when a document is first made available via the LSParser:  <ul> <li> <para>there will never be two adjacent nodes of type NODE_TEXT, and there will never be empty text nodes.  </para></li> <li> <para>it is expected that the  <code>value</code> and  <code>nodeValue</code> attributes of an  <code>Attr</code> node initially return the . However, if the parameters "&lt;a href='http://www.w3.org/TR/DOM-Level-3-Core/core.html#parameter-validate-if-schema'&gt;   validate-if-schema&lt;/a&gt;" and "&lt;a href='http://www.w3.org/TR/DOM-Level-3-Core/core.html#parameter-datatype-normalization'&gt;   datatype-normalization&lt;/a&gt;" are set to  <code>true</code>, depending on the attribute normalization used, the attribute values may differ from the ones obtained by the XML 1.0 attribute normalization. If the parameters "&lt;a href='http://www.w3.org/TR/DOM-Level-3-Core/core.html#parameter-datatype-normalization'&gt;   datatype-normalization&lt;/a&gt;" is set to  <code>false</code>, the XML 1.0 attribute normalization is guaranteed to occur, and if the attributes list does not contain namespace declarations, the  <code>attributes</code> attribute on  <code>Element</code> node represents the property  <b>[attributes]</b> defined in []  </para></li></ul></para> <para>Asynchronous  <code>LSParser</code> objects are expected to also implement the  <code>events::EventTarget</code> interface so that event listeners can be registered on asynchronous  <code>LSParser</code> objects. </para> <para>Events supported by asynchronous  <code>LSParser</code> objects are: </para> <para> <b>Note:</b> All events defined in this specification use the namespace URI  <code>"http://www.w3.org/2002/DOMLS"</code>. </para> <para>While parsing an input source, errors are reported to the application through the error handler ( <code>LSParser.domConfig</code>'s "&lt;a href='http://www.w3.org/TR/DOM-Level-3-Core/core.html#parameter-error-handler'&gt;   error-handler&lt;/a&gt;" parameter). This specification does in no way try to define all possible errors that can occur while parsing XML, or any other markup, but some common error cases are defined. The types ( <code>DOMError.type</code>) of errors and warnings defined by this specification are: </para> <para>In addition to raising the defined errors and warnings, implementations are expected to raise implementation specific errors and warnings for any other error and warning cases such as IO errors (file not found, permission denied,...), XML well-formedness errors, and so on. </para> <para>See also the . </para>    
		/// </summary>
		/// <java-name>
		/// org/w3c/dom/ls/LSParser
		/// </java-name>
		[Dot42.DexImport("org/w3c/dom/ls/LSParser", AccessFlags = 1537)]
		public partial interface ILSParser
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Parse an XML document from a resource identified by a  <code>LSInput</code>. </para>        
				/// </summary>
				/// <returns>
				///  <para>If the  <code>LSParser</code> is a synchronous  <code>LSParser</code>, the newly created and populated  <code>Document</code> is returned. If the  <code>LSParser</code> is asynchronous,  <code>null</code> is returned since the document object may not yet be constructed when this method returns. </para>
				/// </returns>
				/// <java-name>
				/// parse
				/// </java-name>
				[Dot42.DexImport("parse", "(Lorg/w3c/dom/ls/LSInput;)Lorg/w3c/dom/Document;", AccessFlags = 1025)]
				global::Org.W3c.Dom.IDocument Parse(global::Org.W3c.Dom.Ls.ILSInput input) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Parse an XML document from a location identified by a URI reference []. If the URI contains a fragment identifier (see section 4.1 in []), the behavior is not defined by this specification, future versions of this specification may define the behavior. </para>        
				/// </summary>
				/// <returns>
				///  <para>If the  <code>LSParser</code> is a synchronous  <code>LSParser</code>, the newly created and populated  <code>Document</code> is returned, or  <code>null</code> if an error occured. If the  <code>LSParser</code> is asynchronous,  <code>null</code> is returned since the document object may not yet be constructed when this method returns. </para>
				/// </returns>
				/// <java-name>
				/// parseURI
				/// </java-name>
				[Dot42.DexImport("parseURI", "(Ljava/lang/String;)Lorg/w3c/dom/Document;", AccessFlags = 1025)]
				global::Org.W3c.Dom.IDocument ParseURI(string uri) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Parse an XML fragment from a resource identified by a  <code>LSInput</code> and insert the content into an existing document at the position specified with the  <code>context</code> and  <code>action</code> arguments. When parsing the input stream, the context node (or its parent, depending on where the result will be inserted) is used for resolving unbound namespace prefixes. The context node's  <code>ownerDocument</code> node (or the node itself if the node of type  <code>DOCUMENT_NODE</code>) is used to resolve default attributes and entity references.  <br></br> As the new data is inserted into the document, at least one mutation event is fired per new immediate child or sibling of the context node.  <br></br> If the context node is a  <code>Document</code> node and the action is  <code>ACTION_REPLACE_CHILDREN</code>, then the document that is passed as the context node will be changed such that its  <code>xmlEncoding</code>,  <code>documentURI</code>,  <code>xmlVersion</code>,  <code>inputEncoding</code>,  <code>xmlStandalone</code>, and all other such attributes are set to what they would be set to if the input source was parsed using  <code>LSParser.parse()</code>.  <br></br> This method is always synchronous, even if the  <code>LSParser</code> is asynchronous ( <code>LSParser.async</code> is  <code>true</code>).  <br></br> If an error occurs while parsing, the caller is notified through the  <code>ErrorHandler</code> instance associated with the "&lt;a href='http://www.w3.org/TR/DOM-Level-3-Core/core.html#parameter-error-handler'&gt;error-handler&lt;/a&gt;" parameter of the  <code>DOMConfiguration</code>.  <br></br> When calling  <code>parseWithContext</code>, the values of the following configuration parameters will be ignored and their default values will always be used instead: "&lt;a href='http://www.w3.org/TR/DOM-Level-3-Core/core.html#parameter-validate'&gt;validate&lt;/a&gt;", "&lt;a href='http://www.w3.org/TR/DOM-Level-3-Core/core.html#parameter-validate-if-schema'&gt;validate-if-schema&lt;/a&gt;", and "&lt;a href='http://www.w3.org/TR/DOM-Level-3-Core/core.html#parameter-element-content-whitespace'&gt;element-content-whitespace&lt;/a&gt;". Other parameters will be treated normally, and the parser is expected to call the  <code>LSParserFilter</code> just as if a whole document was parsed. </para>        
				/// </summary>
				/// <returns>
				///  <para>Return the node that is the result of the parse operation. If the result is more than one top-level node, the first one is returned. </para>
				/// </returns>
				/// <java-name>
				/// parseWithContext
				/// </java-name>
				[Dot42.DexImport("parseWithContext", "(Lorg/w3c/dom/ls/LSInput;Lorg/w3c/dom/Node;S)Lorg/w3c/dom/Node;", AccessFlags = 1025)]
				global::Org.W3c.Dom.INode ParseWithContext(global::Org.W3c.Dom.Ls.ILSInput input, global::Org.W3c.Dom.INode contextArg, short action) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Abort the loading of the document that is currently being loaded by the  <code>LSParser</code>. If the  <code>LSParser</code> is currently not busy, a call to this method does nothing. </para>        
				/// </summary>
				/// <java-name>
				/// abort
				/// </java-name>
				[Dot42.DexImport("abort", "()V", AccessFlags = 1025)]
				void Abort() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>The  <code>DOMConfiguration</code> object used when parsing an input source. This  <code>DOMConfiguration</code> is specific to the parse operation. No parameter values from this  <code>DOMConfiguration</code> object are passed automatically to the  <code>DOMConfiguration</code> object on the  <code>Document</code> that is created, or used, by the parse operation. The DOM application is responsible for passing any needed parameter values from this  <code>DOMConfiguration</code> object to the  <code>DOMConfiguration</code> object referenced by the  <code>Document</code> object.  <br></br> In addition to the parameters recognized in on the  interface defined in [] , the  <code>DOMConfiguration</code> objects for  <code>LSParser</code> add or modify the following parameters: </para>        
				/// </summary>
				/// <java-name>
				/// getDomConfig
				/// </java-name>
				global::Org.W3c.Dom.IDOMConfiguration DomConfig
				{
						[Dot42.DexImport("getDomConfig", "()Lorg/w3c/dom/DOMConfiguration;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>When a filter is provided, the implementation will call out to the filter as it is constructing the DOM tree structure. The filter can choose to remove elements from the document being constructed, or to terminate the parsing early.  <br></br> The filter is invoked after the operations requested by the  <code>DOMConfiguration</code> parameters have been applied. For example, if "&lt;a href='http://www.w3.org/TR/DOM-Level-3-Core/core.html#parameter-validate'&gt;validate&lt;/a&gt;" is set to  <code>true</code>, the validation is done before invoking the filter. </para>        
				/// </summary>
				/// <java-name>
				/// getFilter
				/// </java-name>
				global::Org.W3c.Dom.Ls.ILSParserFilter Filter
				{
						[Dot42.DexImport("getFilter", "()Lorg/w3c/dom/ls/LSParserFilter;", AccessFlags = 1025)]
						get;
						[Dot42.DexImport("setFilter", "(Lorg/w3c/dom/ls/LSParserFilter;)V", AccessFlags = 1025)]
						set;
				}

				/// <summary>
				///  <para> <code>true</code> if the  <code>LSParser</code> is asynchronous,  <code>false</code> if it is synchronous. </para>        
				/// </summary>
				/// <java-name>
				/// getAsync
				/// </java-name>
				bool Async
				{
						[Dot42.DexImport("getAsync", "()Z", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para> <code>true</code> if the  <code>LSParser</code> is currently busy loading a document, otherwise  <code>false</code>. </para>        
				/// </summary>
				/// <java-name>
				/// getBusy
				/// </java-name>
				bool Busy
				{
						[Dot42.DexImport("getBusy", "()Z", AccessFlags = 1025)]
						get;
				}

		}

		/// <summary>
		///  <para>An interface to an object that is able to build, or augment, a DOM tree from various input sources. </para> <para> <code>LSParser</code> provides an API for parsing XML and building the corresponding DOM document structure. A  <code>LSParser</code> instance can be obtained by invoking the  <code>DOMImplementationLS.createLSParser()</code> method. </para> <para>As specified in [] , when a document is first made available via the LSParser:  <ul> <li> <para>there will never be two adjacent nodes of type NODE_TEXT, and there will never be empty text nodes.  </para></li> <li> <para>it is expected that the  <code>value</code> and  <code>nodeValue</code> attributes of an  <code>Attr</code> node initially return the . However, if the parameters "&lt;a href='http://www.w3.org/TR/DOM-Level-3-Core/core.html#parameter-validate-if-schema'&gt;   validate-if-schema&lt;/a&gt;" and "&lt;a href='http://www.w3.org/TR/DOM-Level-3-Core/core.html#parameter-datatype-normalization'&gt;   datatype-normalization&lt;/a&gt;" are set to  <code>true</code>, depending on the attribute normalization used, the attribute values may differ from the ones obtained by the XML 1.0 attribute normalization. If the parameters "&lt;a href='http://www.w3.org/TR/DOM-Level-3-Core/core.html#parameter-datatype-normalization'&gt;   datatype-normalization&lt;/a&gt;" is set to  <code>false</code>, the XML 1.0 attribute normalization is guaranteed to occur, and if the attributes list does not contain namespace declarations, the  <code>attributes</code> attribute on  <code>Element</code> node represents the property  <b>[attributes]</b> defined in []  </para></li></ul></para> <para>Asynchronous  <code>LSParser</code> objects are expected to also implement the  <code>events::EventTarget</code> interface so that event listeners can be registered on asynchronous  <code>LSParser</code> objects. </para> <para>Events supported by asynchronous  <code>LSParser</code> objects are: </para> <para> <b>Note:</b> All events defined in this specification use the namespace URI  <code>"http://www.w3.org/2002/DOMLS"</code>. </para> <para>While parsing an input source, errors are reported to the application through the error handler ( <code>LSParser.domConfig</code>'s "&lt;a href='http://www.w3.org/TR/DOM-Level-3-Core/core.html#parameter-error-handler'&gt;   error-handler&lt;/a&gt;" parameter). This specification does in no way try to define all possible errors that can occur while parsing XML, or any other markup, but some common error cases are defined. The types ( <code>DOMError.type</code>) of errors and warnings defined by this specification are: </para> <para>In addition to raising the defined errors and warnings, implementations are expected to raise implementation specific errors and warnings for any other error and warning cases such as IO errors (file not found, permission denied,...), XML well-formedness errors, and so on. </para> <para>See also the . </para>    
		/// </summary>
		/// <java-name>
		/// org/w3c/dom/ls/LSParser
		/// </java-name>
		[Dot42.DexImport("org/w3c/dom/ls/LSParser", AccessFlags = 1537, IgnoreFromJava = true, Priority = 1)]
		public static partial class ILSParserConstants
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Append the result of the parse operation as children of the context node. For this action to work, the context node must be an  <code>Element</code> or a  <code>DocumentFragment</code>. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_APPEND_AS_CHILDREN
				/// </java-name>
				[Dot42.DexImport("ACTION_APPEND_AS_CHILDREN", "S", AccessFlags = 25)]
				public const short ACTION_APPEND_AS_CHILDREN = 1;
				/// <summary>
				///  <para>Replace all the children of the context node with the result of the parse operation. For this action to work, the context node must be an  <code>Element</code>, a  <code>Document</code>, or a  <code>DocumentFragment</code>. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_REPLACE_CHILDREN
				/// </java-name>
				[Dot42.DexImport("ACTION_REPLACE_CHILDREN", "S", AccessFlags = 25)]
				public const short ACTION_REPLACE_CHILDREN = 2;
				/// <summary>
				///  <para>Insert the result of the parse operation as the immediately preceding sibling of the context node. For this action to work the context node's parent must be an  <code>Element</code> or a  <code>DocumentFragment</code>. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_INSERT_BEFORE
				/// </java-name>
				[Dot42.DexImport("ACTION_INSERT_BEFORE", "S", AccessFlags = 25)]
				public const short ACTION_INSERT_BEFORE = 3;
				/// <summary>
				///  <para>Insert the result of the parse operation as the immediately following sibling of the context node. For this action to work the context node's parent must be an  <code>Element</code> or a  <code>DocumentFragment</code>. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_INSERT_AFTER
				/// </java-name>
				[Dot42.DexImport("ACTION_INSERT_AFTER", "S", AccessFlags = 25)]
				public const short ACTION_INSERT_AFTER = 4;
				/// <summary>
				///  <para>Replace the context node with the result of the parse operation. For this action to work, the context node must have a parent, and the parent must be an  <code>Element</code> or a  <code>DocumentFragment</code>. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_REPLACE
				/// </java-name>
				[Dot42.DexImport("ACTION_REPLACE", "S", AccessFlags = 25)]
				public const short ACTION_REPLACE = 5;
		}

		/// <summary>
		///  <para> <code>LSParserFilter</code>s provide applications the ability to examine nodes as they are being constructed while parsing. As each node is examined, it may be modified or removed, or the entire parse may be terminated early. </para> <para>At the time any of the filter methods are called by the parser, the owner Document and DOMImplementation objects exist and are accessible. The document element is never passed to the  <code>LSParserFilter</code> methods, i.e. it is not possible to filter out the document element.  <code>Document</code>,  <code>DocumentType</code>,  <code>Notation</code>,  <code>Entity</code>, and  <code>Attr</code> nodes are never passed to the  <code>acceptNode</code> method on the filter. The child nodes of an  <code>EntityReference</code> node are passed to the filter if the parameter "&lt;a href='http://www.w3.org/TR/DOM-Level-3-Core/core.html#parameter-entities'&gt;   entities&lt;/a&gt;" is set to  <code>false</code>. Note that, as described by the parameter "&lt;a href='http://www.w3.org/TR/DOM-Level-3-Core/core.html#parameter-entities'&gt;   entities&lt;/a&gt;", unexpanded entity reference nodes are never discarded and are always passed to the filter. </para> <para>All validity checking while parsing a document occurs on the source document as it appears on the input stream, not on the DOM document as it is built in memory. With filters, the document in memory may be a subset of the document on the stream, and its validity may have been affected by the filtering. </para> <para>All default attributes must be present on elements when the elements are passed to the filter methods. All other default content must be passed to the filter methods. </para> <para>DOM applications must not raise exceptions in a filter. The effect of throwing exceptions from a filter is DOM implementation dependent. </para> <para>See also the . </para>    
		/// </summary>
		/// <java-name>
		/// org/w3c/dom/ls/LSParserFilter
		/// </java-name>
		[Dot42.DexImport("org/w3c/dom/ls/LSParserFilter", AccessFlags = 1537)]
		public partial interface ILSParserFilter
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>The parser will call this method after each  <code>Element</code> start tag has been scanned, but before the remainder of the  <code>Element</code> is processed. The intent is to allow the element, including any children, to be efficiently skipped. Note that only element nodes are passed to the  <code>startElement</code> function.  <br></br>The element node passed to  <code>startElement</code> for filtering will include all of the Element's attributes, but none of the children nodes. The Element may not yet be in place in the document being constructed (it may not have a parent node.)  <br></br>A  <code>startElement</code> filter function may access or change the attributes for the Element. Changing Namespace declarations will have no effect on namespace resolution by the parser.  <br></br>For efficiency, the Element node passed to the filter may not be the same one as is actually placed in the tree if the node is accepted. And the actual node (node object identity) may be reused during the process of reading in and filtering a document. </para>        
				/// </summary>
				/// <returns>
				///  <para> <ul> <li> <para> <code>FILTER_ACCEPT</code> if the  <code>Element</code> should be included in the DOM document being built.  </para></li> <li> <para> <code>FILTER_REJECT</code> if the  <code>Element</code> and all of its children should be rejected.  </para></li> <li> <para> <code>FILTER_SKIP</code> if the  <code>Element</code> should be skipped. All of its children are inserted in place of the skipped  <code>Element</code> node.  </para></li> <li> <para> <code>FILTER_INTERRUPT</code> if the filter wants to stop the processing of the document. Interrupting the processing of the document does no longer guarantee that the resulting DOM tree is XML well-formed. The  <code>Element</code> is rejected.  </para></li></ul>Returning any other values will result in unspecified behavior. </para>
				/// </returns>
				/// <java-name>
				/// startElement
				/// </java-name>
				[Dot42.DexImport("startElement", "(Lorg/w3c/dom/Element;)S", AccessFlags = 1025)]
				short StartElement(global::Org.W3c.Dom.IElement elementArg) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>This method will be called by the parser at the completion of the parsing of each node. The node and all of its descendants will exist and be complete. The parent node will also exist, although it may be incomplete, i.e. it may have additional children that have not yet been parsed. Attribute nodes are never passed to this function.  <br></br>From within this method, the new node may be freely modified - children may be added or removed, text nodes modified, etc. The state of the rest of the document outside this node is not defined, and the affect of any attempt to navigate to, or to modify any other part of the document is undefined.  <br></br>For validating parsers, the checks are made on the original document, before any modification by the filter. No validity checks are made on any document modifications made by the filter.  <br></br>If this new node is rejected, the parser might reuse the new node and any of its descendants. </para>        
				/// </summary>
				/// <returns>
				///  <para> <ul> <li> <para> <code>FILTER_ACCEPT</code> if this  <code>Node</code> should be included in the DOM document being built.  </para></li> <li> <para> <code>FILTER_REJECT</code> if the  <code>Node</code> and all of its children should be rejected.  </para></li> <li> <para> <code>FILTER_SKIP</code> if the  <code>Node</code> should be skipped and the  <code>Node</code> should be replaced by all the children of the  <code>Node</code>.  </para></li> <li> <para> <code>FILTER_INTERRUPT</code> if the filter wants to stop the processing of the document. Interrupting the processing of the document does no longer guarantee that the resulting DOM tree is XML well-formed. The  <code>Node</code> is accepted and will be the last completely parsed node.  </para></li></ul></para>
				/// </returns>
				/// <java-name>
				/// acceptNode
				/// </java-name>
				[Dot42.DexImport("acceptNode", "(Lorg/w3c/dom/Node;)S", AccessFlags = 1025)]
				short AcceptNode(global::Org.W3c.Dom.INode nodeArg) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Tells the  <code>LSParser</code> what types of nodes to show to the method  <code>LSParserFilter.acceptNode</code>. If a node is not shown to the filter using this attribute, it is automatically included in the DOM document being built. See  <code>NodeFilter</code> for definition of the constants. The constants  <code>SHOW_ATTRIBUTE</code> ,  <code>SHOW_DOCUMENT</code>,  <code>SHOW_DOCUMENT_TYPE</code>,  <code>SHOW_NOTATION</code>,  <code>SHOW_ENTITY</code>, and  <code>SHOW_DOCUMENT_FRAGMENT</code> are meaningless here. Those nodes will never be passed to  <code>LSParserFilter.acceptNode</code>.  <br></br> The constants used here are defined in []</para>        
				/// </summary>
				/// <java-name>
				/// getWhatToShow
				/// </java-name>
				int WhatToShow
				{
						[Dot42.DexImport("getWhatToShow", "()I", AccessFlags = 1025)]
						get;
				}

		}

		/// <summary>
		///  <para> <code>LSParserFilter</code>s provide applications the ability to examine nodes as they are being constructed while parsing. As each node is examined, it may be modified or removed, or the entire parse may be terminated early. </para> <para>At the time any of the filter methods are called by the parser, the owner Document and DOMImplementation objects exist and are accessible. The document element is never passed to the  <code>LSParserFilter</code> methods, i.e. it is not possible to filter out the document element.  <code>Document</code>,  <code>DocumentType</code>,  <code>Notation</code>,  <code>Entity</code>, and  <code>Attr</code> nodes are never passed to the  <code>acceptNode</code> method on the filter. The child nodes of an  <code>EntityReference</code> node are passed to the filter if the parameter "&lt;a href='http://www.w3.org/TR/DOM-Level-3-Core/core.html#parameter-entities'&gt;   entities&lt;/a&gt;" is set to  <code>false</code>. Note that, as described by the parameter "&lt;a href='http://www.w3.org/TR/DOM-Level-3-Core/core.html#parameter-entities'&gt;   entities&lt;/a&gt;", unexpanded entity reference nodes are never discarded and are always passed to the filter. </para> <para>All validity checking while parsing a document occurs on the source document as it appears on the input stream, not on the DOM document as it is built in memory. With filters, the document in memory may be a subset of the document on the stream, and its validity may have been affected by the filtering. </para> <para>All default attributes must be present on elements when the elements are passed to the filter methods. All other default content must be passed to the filter methods. </para> <para>DOM applications must not raise exceptions in a filter. The effect of throwing exceptions from a filter is DOM implementation dependent. </para> <para>See also the . </para>    
		/// </summary>
		/// <java-name>
		/// org/w3c/dom/ls/LSParserFilter
		/// </java-name>
		[Dot42.DexImport("org/w3c/dom/ls/LSParserFilter", AccessFlags = 1537, IgnoreFromJava = true, Priority = 1)]
		public static partial class ILSParserFilterConstants
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Accept the node. </para>        
				/// </summary>
				/// <java-name>
				/// FILTER_ACCEPT
				/// </java-name>
				[Dot42.DexImport("FILTER_ACCEPT", "S", AccessFlags = 25)]
				public const short FILTER_ACCEPT = 1;
				/// <summary>
				///  <para>Reject the node and its children. </para>        
				/// </summary>
				/// <java-name>
				/// FILTER_REJECT
				/// </java-name>
				[Dot42.DexImport("FILTER_REJECT", "S", AccessFlags = 25)]
				public const short FILTER_REJECT = 2;
				/// <summary>
				///  <para>Skip this single node. The children of this node will still be considered. </para>        
				/// </summary>
				/// <java-name>
				/// FILTER_SKIP
				/// </java-name>
				[Dot42.DexImport("FILTER_SKIP", "S", AccessFlags = 25)]
				public const short FILTER_SKIP = 3;
				/// <summary>
				///  <para>Interrupt the normal processing of the document. </para>        
				/// </summary>
				/// <java-name>
				/// FILTER_INTERRUPT
				/// </java-name>
				[Dot42.DexImport("FILTER_INTERRUPT", "S", AccessFlags = 25)]
				public const short FILTER_INTERRUPT = 4;
		}

		/// <summary>
		///  <para> <code>LSResourceResolver</code> provides a way for applications to redirect references to external resources. </para> <para>Applications needing to implement custom handling for external resources can implement this interface and register their implementation by setting the "resource-resolver" parameter of  <code>DOMConfiguration</code> objects attached to  <code>LSParser</code> and  <code>LSSerializer</code>. It can also be register on  <code>DOMConfiguration</code> objects attached to  <code>Document</code> if the "LS" feature is supported. </para> <para>The  <code>LSParser</code> will then allow the application to intercept any external entities, including the external DTD subset and external parameter entities, before including them. The top-level document entity is never passed to the  <code>resolveResource</code> method. </para> <para>Many DOM applications will not need to implement this interface, but it will be especially useful for applications that build XML documents from databases or other specialized input sources, or for applications that use URNs. </para> <para> <b>Note:</b>  <code>LSResourceResolver</code> is based on the SAX2 []  <code>EntityResolver</code> interface. </para> <para>See also the . </para>    
		/// </summary>
		/// <java-name>
		/// org/w3c/dom/ls/LSResourceResolver
		/// </java-name>
		[Dot42.DexImport("org/w3c/dom/ls/LSResourceResolver", AccessFlags = 1537)]
		public partial interface ILSResourceResolver
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Allow the application to resolve external resources.  <br></br> The  <code>LSParser</code> will call this method before opening any external resource, including the external DTD subset, external entities referenced within the DTD, and external entities referenced within the document element (however, the top-level document entity is not passed to this method). The application may then request that the  <code>LSParser</code> resolve the external resource itself, that it use an alternative URI, or that it use an entirely different input source.  <br></br> Application writers can use this method to redirect external system identifiers to secure and/or local URI, to look up public identifiers in a catalogue, or to read an entity from a database or other input source (including, for example, a dialog box). </para>        
				/// </summary>
				/// <returns>
				///  <para>A  <code>LSInput</code> object describing the new input source, or  <code>null</code> to request that the parser open a regular URI connection to the resource. </para>
				/// </returns>
				/// <java-name>
				/// resolveResource
				/// </java-name>
				[Dot42.DexImport("resolveResource", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/la" +
    "ng/String;)Lorg/w3c/dom/ls/LSInput;", AccessFlags = 1025)]
				global::Org.W3c.Dom.Ls.ILSInput ResolveResource(string type, string namespaceURI, string publicId, string systemId, string baseURI) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		///  <para>A  <code>LSSerializer</code> provides an API for serializing (writing) a DOM document out into XML. The XML data is written to a string or an output stream. Any changes or fixups made during the serialization affect only the serialized data. The  <code>Document</code> object and its children are never altered by the serialization operation. </para> <para>During serialization of XML data, namespace fixup is done as defined in [] , Appendix B. [] allows empty strings as a real namespace URI. If the  <code>namespaceURI</code> of a  <code>Node</code> is empty string, the serialization will treat them as  <code>null</code>, ignoring the prefix if any. </para> <para> <code>LSSerializer</code> accepts any node type for serialization. For nodes of type  <code>Document</code> or  <code>Entity</code>, well-formed XML will be created when possible (well-formedness is guaranteed if the document or entity comes from a parse operation and is unchanged since it was created). The serialized output for these node types is either as a XML document or an External XML Entity, respectively, and is acceptable input for an XML parser. For all other types of nodes the serialized form is implementation dependent. </para> <para>Within a  <code>Document</code>,  <code>DocumentFragment</code>, or  <code>Entity</code> being serialized,  <code>Nodes</code> are processed as follows  <ul> <li> <para> <code>Document</code> nodes are written, including the XML declaration (unless the parameter "xml-declaration" is set to  <code>false</code>) and a DTD subset, if one exists in the DOM. Writing a  <code>Document</code> node serializes the entire document.  </para></li> <li> <para> <code>Entity</code> nodes, when written directly by  <code>LSSerializer.write</code>, outputs the entity expansion but no namespace fixup is done. The resulting output will be valid as an external entity.  </para></li> <li> <para>If the parameter "&lt;a href='http://www.w3.org/TR/DOM-Level-3-Core/core.html#parameter-entities'&gt;   entities&lt;/a&gt;" is set to  <code>true</code>,  <code>EntityReference</code> nodes are serialized as an entity reference of the form "   &lt;code&gt;&amp;amp;entityName;&lt;/code&gt;" in the output. Child nodes (the expansion) of the entity reference are ignored. If the parameter "&lt;a href='http://www.w3.org/TR/DOM-Level-3-Core/core.html#parameter-entities'&gt;   entities&lt;/a&gt;" is set to  <code>false</code>, only the children of the entity reference are serialized.  <code>EntityReference</code> nodes with no children (no corresponding  <code>Entity</code> node or the corresponding  <code>Entity</code> nodes have no children) are always serialized.  </para></li> <li> <para> <code>CDATAsections</code> containing content characters that cannot be represented in the specified output encoding are handled according to the "&lt;a href='http://www.w3.org/TR/DOM-Level-3-Core/core.html#parameter-split-cdata-sections'&gt;   split-cdata-sections&lt;/a&gt;" parameter. If the parameter is set to  <code>true</code>,  <code>CDATAsections</code> are split, and the unrepresentable characters are serialized as numeric character references in ordinary content. The exact position and number of splits is not specified. If the parameter is set to  <code>false</code>, unrepresentable characters in a  <code>CDATAsection</code> are reported as  <code>"wf-invalid-character"</code> errors if the parameter "&lt;a href='http://www.w3.org/TR/DOM-Level-3-Core/core.html#parameter-well-formed'&gt;   well-formed&lt;/a&gt;" is set to  <code>true</code>. The error is not recoverable - there is no mechanism for supplying alternative characters and continuing with the serialization.  </para></li> <li> <para> <code>DocumentFragment</code> nodes are serialized by serializing the children of the document fragment in the order they appear in the document fragment.  </para></li> <li> <para>All other node types (Element, Text, etc.) are serialized to their corresponding XML source form.  </para></li></ul></para> <para> <b>Note:</b> The serialization of a  <code>Node</code> does not always generate a well-formed XML document, i.e. a  <code>LSParser</code> might throw fatal errors when parsing the resulting serialization. </para> <para>Within the character data of a document (outside of markup), any characters that cannot be represented directly are replaced with character references. Occurrences of '&lt;' and '&amp;' are replaced by the predefined entities &amp;lt; and &amp;amp;. The other predefined entities (&amp;gt;, &amp;apos;, and &amp;quot;) might not be used, except where needed (e.g. using &amp;gt; in cases such as ']]&gt;'). Any characters that cannot be represented directly in the output character encoding are serialized as numeric character references (and since character encoding standards commonly use hexadecimal representations of characters, using the hexadecimal representation when serializing character references is encouraged). </para> <para>To allow attribute values to contain both single and double quotes, the apostrophe or single-quote character (') may be represented as "&amp;amp;apos;", and the double-quote character (")  as "&amp;quot;". New line characters and other characters that cannot be represented directly in attribute values in the output character encoding are serialized as a numeric character reference. </para> <para>Within markup, but outside of attributes, any occurrence of a character that cannot be represented in the output character encoding is reported as a  <code>DOMError</code> fatal error. An example would be serializing the element &lt;LaCa/&gt; with  <code>encoding="us-ascii"</code>. This will result with a generation of a  <code>DOMError</code> "wf-invalid-character-in-node-name" (as proposed in "&lt;a href='http://www.w3.org/TR/DOM-Level-3-Core/core.html#parameter-well-formed'&gt;   well-formed&lt;/a&gt;"). </para> <para>When requested by setting the parameter "&lt;a href='http://www.w3.org/TR/DOM-Level-3-Core/core.html#parameter-normalize-characters'&gt;   normalize-characters&lt;/a&gt;" on  <code>LSSerializer</code> to true, character normalization is performed according to the definition of  characters included in appendix E of [] on all data to be serialized, both markup and character data. The character normalization process affects only the data as it is being written; it does not alter the DOM's view of the document after serialization has completed. </para> <para>Implementations are required to support the encodings "UTF-8", "UTF-16", "UTF-16BE", and "UTF-16LE" to guarantee that data is serializable in all encodings that are required to be supported by all XML parsers. When the encoding is UTF-8, whether or not a byte order mark is serialized, or if the output is big-endian or little-endian, is implementation dependent. When the encoding is UTF-16, whether or not the output is big-endian or little-endian is implementation dependent, but a Byte Order Mark must be generated for non-character outputs, such as  <code>LSOutput.byteStream</code> or  <code>LSOutput.systemId</code>. If the Byte Order Mark is not generated, a "byte-order-mark-needed" warning is reported. When the encoding is UTF-16LE or UTF-16BE, the output is big-endian (UTF-16BE) or little-endian (UTF-16LE) and the Byte Order Mark is not be generated. In all cases, the encoding declaration, if generated, will correspond to the encoding used during the serialization (e.g.  <code>encoding="UTF-16"</code> will appear if UTF-16 was requested). </para> <para>Namespaces are fixed up during serialization, the serialization process will verify that namespace declarations, namespace prefixes and the namespace URI associated with elements and attributes are consistent. If inconsistencies are found, the serialized form of the document will be altered to remove them. The method used for doing the namespace fixup while serializing a document is the algorithm defined in Appendix B.1, "Namespace normalization", of [] </para> <para>While serializing a document, the parameter "discard-default-content" controls whether or not non-specified data is serialized. </para> <para>While serializing, errors and warnings are reported to the application through the error handler ( <code>LSSerializer.domConfig</code>'s "&lt;a href='http://www.w3.org/TR/DOM-Level-3-Core/core.html#parameter-error-handler'&gt;   error-handler&lt;/a&gt;" parameter). This specification does in no way try to define all possible errors and warnings that can occur while serializing a DOM node, but some common error and warning cases are defined. The types (  <code>DOMError.type</code>) of errors and warnings defined by this specification are: </para> <para>In addition to raising the defined errors and warnings, implementations are expected to raise implementation specific errors and warnings for any other error and warning cases such as IO errors (file not found, permission denied,...) and so on. </para> <para>See also the . </para>    
		/// </summary>
		/// <java-name>
		/// org/w3c/dom/ls/LSSerializer
		/// </java-name>
		[Dot42.DexImport("org/w3c/dom/ls/LSSerializer", AccessFlags = 1537)]
		public partial interface ILSSerializer
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Serialize the specified node as described above in the general description of the  <code>LSSerializer</code> interface. The output is written to the supplied  <code>LSOutput</code>.  <br></br> When writing to a  <code>LSOutput</code>, the encoding is found by looking at the encoding information that is reachable through the  <code>LSOutput</code> and the item to be written (or its owner document) in this order:  <ol> <li> <para> <code>LSOutput.encoding</code>,  </para></li> <li> <para> <code>Document.inputEncoding</code>,  </para></li> <li> <para> <code>Document.xmlEncoding</code>.  </para></li></ol> <br></br> If no encoding is reachable through the above properties, a default encoding of "UTF-8" will be used. If the specified encoding is not supported an "unsupported-encoding" fatal error is raised.  <br></br> If no output is specified in the  <code>LSOutput</code>, a "no-output-specified" fatal error is raised.  <br></br> The implementation is responsible of associating the appropriate media type with the serialized data.  <br></br> When writing to a HTTP URI, a HTTP PUT is performed. When writing to other types of URIs, the mechanism for writing the data to the URI is implementation dependent. </para>        
				/// </summary>
				/// <returns>
				///  <para>Returns  <code>true</code> if  <code>node</code> was successfully serialized. Return  <code>false</code> in case the normal processing stopped but the implementation kept serializing the document; the result of the serialization being implementation dependent then. </para>
				/// </returns>
				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "(Lorg/w3c/dom/Node;Lorg/w3c/dom/ls/LSOutput;)Z", AccessFlags = 1025)]
				bool Write(global::Org.W3c.Dom.INode nodeArg, global::Org.W3c.Dom.Ls.ILSOutput destination) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>A convenience method that acts as if  <code>LSSerializer.write</code> was called with a  <code>LSOutput</code> with no encoding specified and  <code>LSOutput.systemId</code> set to the  <code>uri</code> argument. </para>        
				/// </summary>
				/// <returns>
				///  <para>Returns  <code>true</code> if  <code>node</code> was successfully serialized. Return  <code>false</code> in case the normal processing stopped but the implementation kept serializing the document; the result of the serialization being implementation dependent then. </para>
				/// </returns>
				/// <java-name>
				/// writeToURI
				/// </java-name>
				[Dot42.DexImport("writeToURI", "(Lorg/w3c/dom/Node;Ljava/lang/String;)Z", AccessFlags = 1025)]
				bool WriteToURI(global::Org.W3c.Dom.INode nodeArg, string uri) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Serialize the specified node as described above in the general description of the  <code>LSSerializer</code> interface. The output is written to a  <code>DOMString</code> that is returned to the caller. The encoding used is the encoding of the  <code>DOMString</code> type, i.e. UTF-16. Note that no Byte Order Mark is generated in a  <code>DOMString</code> object. </para>        
				/// </summary>
				/// <returns>
				///  <para>Returns the serialized data. </para>
				/// </returns>
				/// <java-name>
				/// writeToString
				/// </java-name>
				[Dot42.DexImport("writeToString", "(Lorg/w3c/dom/Node;)Ljava/lang/String;", AccessFlags = 1025)]
				string WriteToString(global::Org.W3c.Dom.INode nodeArg) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>The  <code>DOMConfiguration</code> object used by the  <code>LSSerializer</code> when serializing a DOM node.  <br></br> In addition to the parameters recognized by the  interface defined in [] , the  <code>DOMConfiguration</code> objects for  <code>LSSerializer</code> adds, or modifies, the following parameters: </para>        
				/// </summary>
				/// <java-name>
				/// getDomConfig
				/// </java-name>
				global::Org.W3c.Dom.IDOMConfiguration DomConfig
				{
						[Dot42.DexImport("getDomConfig", "()Lorg/w3c/dom/DOMConfiguration;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>The end-of-line sequence of characters to be used in the XML being written out. Any string is supported, but XML treats only a certain set of characters sequence as end-of-line (See section 2.11, "End-of-Line Handling" in [], if the serialized content is XML 1.0 or section 2.11, "End-of-Line Handling" in [], if the serialized content is XML 1.1). Using other character sequences than the recommended ones can result in a document that is either not serializable or not well-formed).  <br></br> On retrieval, the default value of this attribute is the implementation specific default end-of-line sequence. DOM implementations should choose the default to match the usual convention for text files in the environment being used. Implementations must choose a default sequence that matches one of those allowed by XML 1.0 or XML 1.1, depending on the serialized content. Setting this attribute to  <code>null</code> will reset its value to the default value.  <br></br> </para>        
				/// </summary>
				/// <java-name>
				/// getNewLine
				/// </java-name>
				string NewLine
				{
						[Dot42.DexImport("getNewLine", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
						[Dot42.DexImport("setNewLine", "(Ljava/lang/String;)V", AccessFlags = 1025)]
						set;
				}

		}

		/// <summary>
		///  <para>Parser or write operations may throw an  <code>LSException</code> if the processing is stopped. The processing can be stopped due to a  <code>DOMError</code> with a severity of  <code>DOMError.SEVERITY_FATAL_ERROR</code> or a non recovered  <code>DOMError.SEVERITY_ERROR</code>, or if  <code>DOMErrorHandler.handleError()</code> returned  <code>false</code>. </para> <para> <b>Note:</b> As suggested in the definition of the constants in the  <code>DOMError</code> interface, a DOM implementation may choose to continue after a fatal error, but the resulting DOM tree is then implementation dependent. </para> <para>See also the . </para>    
		/// </summary>
		/// <java-name>
		/// org/w3c/dom/ls/LSException
		/// </java-name>
		[Dot42.DexImport("org/w3c/dom/ls/LSException", AccessFlags = 33)]
		public partial class LSException : global::System.SystemException
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// code
				/// </java-name>
				[Dot42.DexImport("code", "S", AccessFlags = 1)]
				public short Code;
				/// <summary>
				///  <para>If an attempt was made to load a document, or an XML Fragment, using  <code>LSParser</code> and the processing has been stopped. </para>        
				/// </summary>
				/// <java-name>
				/// PARSE_ERR
				/// </java-name>
				[Dot42.DexImport("PARSE_ERR", "S", AccessFlags = 25)]
				public const short PARSE_ERR = 81;
				/// <summary>
				///  <para>If an attempt was made to serialize a  <code>Node</code> using  <code>LSSerializer</code> and the processing has been stopped. </para>        
				/// </summary>
				/// <java-name>
				/// SERIALIZE_ERR
				/// </java-name>
				[Dot42.DexImport("SERIALIZE_ERR", "S", AccessFlags = 25)]
				public const short SERIALIZE_ERR = 82;
				[Dot42.DexImport("<init>", "(SLjava/lang/String;)V", AccessFlags = 1)]
				public LSException(short code, string message) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal LSException() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

}

