// Copyright (C) 2014 dot42
//
// Original filename: Org.W3c.Dom.Ls.cs
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
namespace Org.W3c.Dom.Ls
{
		/// <summary>
		/// <para><span>&lt;code&gt;DOMImplementationLS&lt;/code&gt; contains the factory methods for creating</span> Load and Save objects. </para><para>The expectation is that an instance of the <code>DOMImplementationLS</code> interface can be obtained by using binding-specific casting methods on an instance of the <code>DOMImplementation</code> interface or, if the <code>Document</code> supports the feature <code>"Core"</code> version <code>"3.0"</code> defined in [] , by using the method <code>DOMImplementation.getFeature</code> with parameter values <code>"LS"</code> (or <code>"LS-Async"</code>) and <code>"3.0"</code> (respectively). </para><para>See also the . </para>    
		/// </summary>
		/// <java-name>
		/// org/w3c/dom/ls/DOMImplementationLS
		/// </java-name>
		[Dot42.DexImport("org/w3c/dom/ls/DOMImplementationLS", AccessFlags = 1537, IgnoreFromJava = true, Priority = 1)]
		public static partial class IDOMImplementationLSConstants
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Create a synchronous <code>LSParser</code>. </para>        
				/// </summary>
				/// <java-name>
				/// MODE_SYNCHRONOUS
				/// </java-name>
				[Dot42.DexImport("MODE_SYNCHRONOUS", "S", AccessFlags = 25)]
				public const short MODE_SYNCHRONOUS = 1;
				/// <summary>
				/// <para>Create an asynchronous <code>LSParser</code>. </para>        
				/// </summary>
				/// <java-name>
				/// MODE_ASYNCHRONOUS
				/// </java-name>
				[Dot42.DexImport("MODE_ASYNCHRONOUS", "S", AccessFlags = 25)]
				public const short MODE_ASYNCHRONOUS = 2;
		}

		/// <summary>
		/// <para><span>&lt;code&gt;DOMImplementationLS&lt;/code&gt; contains the factory methods for creating</span> Load and Save objects. </para><para>The expectation is that an instance of the <code>DOMImplementationLS</code> interface can be obtained by using binding-specific casting methods on an instance of the <code>DOMImplementation</code> interface or, if the <code>Document</code> supports the feature <code>"Core"</code> version <code>"3.0"</code> defined in [] , by using the method <code>DOMImplementation.getFeature</code> with parameter values <code>"LS"</code> (or <code>"LS-Async"</code>) and <code>"3.0"</code> (respectively). </para><para>See also the . </para>    
		/// </summary>
		/// <java-name>
		/// org/w3c/dom/ls/DOMImplementationLS
		/// </java-name>
		[Dot42.DexImport("org/w3c/dom/ls/DOMImplementationLS", AccessFlags = 1537)]
		public partial interface IDOMImplementationLS
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Create a new <code>LSParser</code>. The newly constructed parser may then be configured by means of its <code>DOMConfiguration</code> object, and used to parse documents by means of its <code>parse</code> method. <b>Note:</b> For W3C XML Schema [] , applications must use the value <code>"http://www.w3.org/2001/XMLSchema"</code>. For XML DTD [], applications must use the value <code>"http://www.w3.org/TR/REC-xml"</code>. Other Schema languages are outside the scope of the W3C and therefore should recommend an absolute URI in order to use this method. <b>Note:</b> By default, the newly created <code>LSParser</code> does not contain a <code>DOMErrorHandler</code>, i.e. the value of the "&lt;a href='http://www.w3.org/TR/DOM-Level-3-Core/core.html#parameter-error-handler'&gt;         error-handler&lt;/a&gt;" configuration parameter is <code>null</code>. However, implementations may provide a default error handler at creation time. In that case, the initial value of the <code>"error-handler"</code> configuration parameter on the new <code>LSParser</code> object contains a reference to the default error handler. </para>        
				/// </summary>
				/// <returns>
				/// <para>The newly created <code>LSParser</code> object. This <code>LSParser</code> is either synchronous or asynchronous depending on the value of the <code>mode</code> argument. </para>
				/// </returns>
				/// <java-name>
				/// createLSParser
				/// </java-name>
				[Dot42.DexImport("createLSParser", "(SLjava/lang/String;)Lorg/w3c/dom/ls/LSParser;", AccessFlags = 1025)]
				global::Org.W3c.Dom.Ls.ILSParser CreateLSParser(short mode, string schemaType) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Create a new <code>LSSerializer</code> object. <b>Note:</b> By default, the newly created <code>LSSerializer</code> has no <code>DOMErrorHandler</code>, i.e. the value of the <code>"error-handler"</code> configuration parameter is <code>null</code>. However, implementations may provide a default error handler at creation time. In that case, the initial value of the <code>"error-handler"</code> configuration parameter on the new <code>LSSerializer</code> object contains a reference to the default error handler. </para>        
				/// </summary>
				/// <returns>
				/// <para>The newly created <code>LSSerializer</code> object. </para>
				/// </returns>
				/// <java-name>
				/// createLSSerializer
				/// </java-name>
				[Dot42.DexImport("createLSSerializer", "()Lorg/w3c/dom/ls/LSSerializer;", AccessFlags = 1025)]
				global::Org.W3c.Dom.Ls.ILSSerializer CreateLSSerializer() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Create a new empty input source object where <code>LSInput.characterStream</code>, <code>LSInput.byteStream</code> , <code>LSInput.stringData</code> <code>LSInput.systemId</code>, <code>LSInput.publicId</code>, <code>LSInput.baseURI</code>, and <code>LSInput.encoding</code> are null, and <code>LSInput.certifiedText</code> is false. </para>        
				/// </summary>
				/// <returns>
				/// <para>The newly created input object. </para>
				/// </returns>
				/// <java-name>
				/// createLSInput
				/// </java-name>
				[Dot42.DexImport("createLSInput", "()Lorg/w3c/dom/ls/LSInput;", AccessFlags = 1025)]
				global::Org.W3c.Dom.Ls.ILSInput CreateLSInput() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Create a new empty output destination object where <code>LSOutput.characterStream</code>, <code>LSOutput.byteStream</code>, <code>LSOutput.systemId</code>, <code>LSOutput.encoding</code> are null. </para>        
				/// </summary>
				/// <returns>
				/// <para>The newly created output object. </para>
				/// </returns>
				/// <java-name>
				/// createLSOutput
				/// </java-name>
				[Dot42.DexImport("createLSOutput", "()Lorg/w3c/dom/ls/LSOutput;", AccessFlags = 1025)]
				global::Org.W3c.Dom.Ls.ILSOutput CreateLSOutput() /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// org/w3c/dom/ls/LSSerializer
		/// </java-name>
		[Dot42.DexImport("org/w3c/dom/ls/LSSerializer", AccessFlags = 1537)]
		public partial interface ILSSerializer
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// getDomConfig
				/// </java-name>
				[Dot42.DexImport("getDomConfig", "()Lorg/w3c/dom/DOMConfiguration;", AccessFlags = 1025)]
				global::Org.W3c.Dom.IDOMConfiguration GetDomConfig() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getNewLine
				/// </java-name>
				[Dot42.DexImport("getNewLine", "()Ljava/lang/String;", AccessFlags = 1025)]
				string GetNewLine() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setNewLine
				/// </java-name>
				[Dot42.DexImport("setNewLine", "(Ljava/lang/String;)V", AccessFlags = 1025)]
				void SetNewLine(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "(Lorg/w3c/dom/Node;Lorg/w3c/dom/ls/LSOutput;)Z", AccessFlags = 1025)]
				bool Write(global::Org.W3c.Dom.INode node, global::Org.W3c.Dom.Ls.ILSOutput lSOutput) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// writeToURI
				/// </java-name>
				[Dot42.DexImport("writeToURI", "(Lorg/w3c/dom/Node;Ljava/lang/String;)Z", AccessFlags = 1025)]
				bool WriteToURI(global::Org.W3c.Dom.INode node, string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// writeToString
				/// </java-name>
				[Dot42.DexImport("writeToString", "(Lorg/w3c/dom/Node;)Ljava/lang/String;", AccessFlags = 1025)]
				string WriteToString(global::Org.W3c.Dom.INode node) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para><span>This interface represents an output destination for data.</span> </para><para>This interface allows an application to encapsulate information about an output destination in a single object, which may include a URI, a byte stream (possibly with a specified encoding), a base URI, and/or a character stream. </para><para>The exact definitions of a byte stream and a character stream are binding dependent. </para><para>The application is expected to provide objects that implement this interface whenever such objects are needed. The application can either provide its own objects that implement this interface, or it can use the generic factory method <code>DOMImplementationLS.createLSOutput()</code> to create objects that implement this interface. </para><para>The <code>LSSerializer</code> will use the <code>LSOutput</code> object to determine where to serialize the output to. The <code>LSSerializer</code> will look at the different outputs specified in the <code>LSOutput</code> in the following order to know which one to output to, the first one that is not null and not an empty string will be used: <ol><li><para><code>LSOutput.characterStream</code>  </para></li><li><para><code>LSOutput.byteStream</code>  </para></li><li><para><code>LSOutput.systemId</code>  </para></li></ol></para><para><code>LSOutput</code> objects belong to the application. The DOM implementation will never modify them (though it may make copies and modify the copies, if necessary). </para><para>See also the . </para>    
		/// </summary>
		/// <java-name>
		/// org/w3c/dom/ls/LSOutput
		/// </java-name>
		[Dot42.DexImport("org/w3c/dom/ls/LSOutput", AccessFlags = 1537)]
		public partial interface ILSOutput
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>An attribute of a language and binding dependent type that represents a writable stream to which 16-bit units can be output. </para>        
				/// </summary>
				/// <java-name>
				/// getCharacterStream
				/// </java-name>
				[Dot42.DexImport("getCharacterStream", "()Ljava/io/Writer;", AccessFlags = 1025)]
				global::Java.Io.Writer GetCharacterStream() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>An attribute of a language and binding dependent type that represents a writable stream to which 16-bit units can be output. </para>        
				/// </summary>
				/// <java-name>
				/// setCharacterStream
				/// </java-name>
				[Dot42.DexImport("setCharacterStream", "(Ljava/io/Writer;)V", AccessFlags = 1025)]
				void SetCharacterStream(global::Java.Io.Writer characterStream) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>An attribute of a language and binding dependent type that represents a writable stream of bytes. </para>        
				/// </summary>
				/// <java-name>
				/// getByteStream
				/// </java-name>
				[Dot42.DexImport("getByteStream", "()Ljava/io/OutputStream;", AccessFlags = 1025)]
				global::Java.Io.OutputStream GetByteStream() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>An attribute of a language and binding dependent type that represents a writable stream of bytes. </para>        
				/// </summary>
				/// <java-name>
				/// setByteStream
				/// </java-name>
				[Dot42.DexImport("setByteStream", "(Ljava/io/OutputStream;)V", AccessFlags = 1025)]
				void SetByteStream(global::Java.Io.OutputStream byteStream) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>The system identifier, a URI reference [], for this output destination. <br></br> If the system ID is a relative URI reference (see section 5 in []), the behavior is implementation dependent. </para>        
				/// </summary>
				/// <java-name>
				/// getSystemId
				/// </java-name>
				[Dot42.DexImport("getSystemId", "()Ljava/lang/String;", AccessFlags = 1025)]
				string GetSystemId() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>The system identifier, a URI reference [], for this output destination. <br></br> If the system ID is a relative URI reference (see section 5 in []), the behavior is implementation dependent. </para>        
				/// </summary>
				/// <java-name>
				/// setSystemId
				/// </java-name>
				[Dot42.DexImport("setSystemId", "(Ljava/lang/String;)V", AccessFlags = 1025)]
				void SetSystemId(string systemId) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>The character encoding to use for the output. The encoding must be a string acceptable for an XML encoding declaration ([] section 4.3.3 "Character Encoding in Entities"), it is recommended that character encodings registered (as charsets) with the Internet Assigned Numbers Authority [] should be referred to using their registered names. </para>        
				/// </summary>
				/// <java-name>
				/// getEncoding
				/// </java-name>
				[Dot42.DexImport("getEncoding", "()Ljava/lang/String;", AccessFlags = 1025)]
				string GetEncoding() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>The character encoding to use for the output. The encoding must be a string acceptable for an XML encoding declaration ([] section 4.3.3 "Character Encoding in Entities"), it is recommended that character encodings registered (as charsets) with the Internet Assigned Numbers Authority [] should be referred to using their registered names. </para>        
				/// </summary>
				/// <java-name>
				/// setEncoding
				/// </java-name>
				[Dot42.DexImport("setEncoding", "(Ljava/lang/String;)V", AccessFlags = 1025)]
				void SetEncoding(string encoding) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para><span>Parser or write operations may throw an &lt;code&gt;LSException&lt;/code&gt; if the</span> processing is stopped. The processing can be stopped due to a <code>DOMError</code> with a severity of <code>DOMError.SEVERITY_FATAL_ERROR</code> or a non recovered <code>DOMError.SEVERITY_ERROR</code>, or if <code>DOMErrorHandler.handleError()</code> returned <code>false</code>. </para><para><b>Note:</b> As suggested in the definition of the constants in the <code>DOMError</code> interface, a DOM implementation may choose to continue after a fatal error, but the resulting DOM tree is then implementation dependent. </para><para>See also the . </para>    
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
				/// <para>If an attempt was made to load a document, or an XML Fragment, using <code>LSParser</code> and the processing has been stopped. </para>        
				/// </summary>
				/// <java-name>
				/// PARSE_ERR
				/// </java-name>
				[Dot42.DexImport("PARSE_ERR", "S", AccessFlags = 25)]
				public const short PARSE_ERR = 81;
				/// <summary>
				/// <para>If an attempt was made to serialize a <code>Node</code> using <code>LSSerializer</code> and the processing has been stopped. </para>        
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
				internal LSException() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		/// <para><span>&lt;code&gt;LSResourceResolver&lt;/code&gt; provides a way for applications to</span> redirect references to external resources. </para><para>Applications needing to implement custom handling for external resources can implement this interface and register their implementation by setting the "resource-resolver" parameter of <code>DOMConfiguration</code> objects attached to <code>LSParser</code> and <code>LSSerializer</code>. It can also be register on <code>DOMConfiguration</code> objects attached to <code>Document</code> if the "LS" feature is supported. </para><para>The <code>LSParser</code> will then allow the application to intercept any external entities, including the external DTD subset and external parameter entities, before including them. The top-level document entity is never passed to the <code>resolveResource</code> method. </para><para>Many DOM applications will not need to implement this interface, but it will be especially useful for applications that build XML documents from databases or other specialized input sources, or for applications that use URNs. </para><para><b>Note:</b> <code>LSResourceResolver</code> is based on the SAX2 [] <code>EntityResolver</code> interface. </para><para>See also the . </para>    
		/// </summary>
		/// <java-name>
		/// org/w3c/dom/ls/LSResourceResolver
		/// </java-name>
		[Dot42.DexImport("org/w3c/dom/ls/LSResourceResolver", AccessFlags = 1537)]
		public partial interface ILSResourceResolver
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Allow the application to resolve external resources. <br></br> The <code>LSParser</code> will call this method before opening any external resource, including the external DTD subset, external entities referenced within the DTD, and external entities referenced within the document element (however, the top-level document entity is not passed to this method). The application may then request that the <code>LSParser</code> resolve the external resource itself, that it use an alternative URI, or that it use an entirely different input source. <br></br> Application writers can use this method to redirect external system identifiers to secure and/or local URI, to look up public identifiers in a catalogue, or to read an entity from a database or other input source (including, for example, a dialog box). </para>        
				/// </summary>
				/// <returns>
				/// <para>A <code>LSInput</code> object describing the new input source, or <code>null</code> to request that the parser open a regular URI connection to the resource. </para>
				/// </returns>
				/// <java-name>
				/// resolveResource
				/// </java-name>
				[Dot42.DexImport("resolveResource", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/la" +
    "ng/String;)Lorg/w3c/dom/ls/LSInput;", AccessFlags = 1025)]
				global::Org.W3c.Dom.Ls.ILSInput ResolveResource(string type, string namespaceURI, string publicId, string systemId, string baseURI) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para><span>This interface represents an input source for data.</span> </para><para>This interface allows an application to encapsulate information about an input source in a single object, which may include a public identifier, a system identifier, a byte stream (possibly with a specified encoding), a base URI, and/or a character stream. </para><para>The exact definitions of a byte stream and a character stream are binding dependent. </para><para>The application is expected to provide objects that implement this interface whenever such objects are needed. The application can either provide its own objects that implement this interface, or it can use the generic factory method <code>DOMImplementationLS.createLSInput()</code> to create objects that implement this interface. </para><para>The <code>LSParser</code> will use the <code>LSInput</code> object to determine how to read data. The <code>LSParser</code> will look at the different inputs specified in the <code>LSInput</code> in the following order to know which one to read from, the first one that is not null and not an empty string will be used: <ol><li><para><code>LSInput.characterStream</code>  </para></li><li><para><code>LSInput.byteStream</code>  </para></li><li><para><code>LSInput.stringData</code>  </para></li><li><para><code>LSInput.systemId</code>  </para></li><li><para><code>LSInput.publicId</code>  </para></li></ol></para><para>If all inputs are null, the <code>LSParser</code> will report a <code>DOMError</code> with its <code>DOMError.type</code> set to <code>"no-input-specified"</code> and its <code>DOMError.severity</code> set to <code>DOMError.SEVERITY_FATAL_ERROR</code>. </para><para><code>LSInput</code> objects belong to the application. The DOM implementation will never modify them (though it may make copies and modify the copies, if necessary). </para><para>See also the . </para>    
		/// </summary>
		/// <java-name>
		/// org/w3c/dom/ls/LSInput
		/// </java-name>
		[Dot42.DexImport("org/w3c/dom/ls/LSInput", AccessFlags = 1537)]
		public partial interface ILSInput
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>An attribute of a language and binding dependent type that represents a stream of 16-bit units. The application must encode the stream using UTF-16 (defined in [Unicode] and in [ISO/IEC 10646]). It is not a requirement to have an XML declaration when using character streams. If an XML declaration is present, the value of the encoding attribute will be ignored. </para>        
				/// </summary>
				/// <java-name>
				/// getCharacterStream
				/// </java-name>
				[Dot42.DexImport("getCharacterStream", "()Ljava/io/Reader;", AccessFlags = 1025)]
				global::Java.Io.Reader GetCharacterStream() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>An attribute of a language and binding dependent type that represents a stream of 16-bit units. The application must encode the stream using UTF-16 (defined in [Unicode] and in [ISO/IEC 10646]). It is not a requirement to have an XML declaration when using character streams. If an XML declaration is present, the value of the encoding attribute will be ignored. </para>        
				/// </summary>
				/// <java-name>
				/// setCharacterStream
				/// </java-name>
				[Dot42.DexImport("setCharacterStream", "(Ljava/io/Reader;)V", AccessFlags = 1025)]
				void SetCharacterStream(global::Java.Io.Reader characterStream) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>An attribute of a language and binding dependent type that represents a stream of bytes. <br></br> If the application knows the character encoding of the byte stream, it should set the encoding attribute. Setting the encoding in this way will override any encoding specified in an XML declaration in the data. </para>        
				/// </summary>
				/// <java-name>
				/// getByteStream
				/// </java-name>
				[Dot42.DexImport("getByteStream", "()Ljava/io/InputStream;", AccessFlags = 1025)]
				global::Java.Io.InputStream GetByteStream() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>An attribute of a language and binding dependent type that represents a stream of bytes. <br></br> If the application knows the character encoding of the byte stream, it should set the encoding attribute. Setting the encoding in this way will override any encoding specified in an XML declaration in the data. </para>        
				/// </summary>
				/// <java-name>
				/// setByteStream
				/// </java-name>
				[Dot42.DexImport("setByteStream", "(Ljava/io/InputStream;)V", AccessFlags = 1025)]
				void SetByteStream(global::Java.Io.InputStream byteStream) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>String data to parse. If provided, this will always be treated as a sequence of 16-bit units (UTF-16 encoded characters). It is not a requirement to have an XML declaration when using <code>stringData</code>. If an XML declaration is present, the value of the encoding attribute will be ignored. </para>        
				/// </summary>
				/// <java-name>
				/// getStringData
				/// </java-name>
				[Dot42.DexImport("getStringData", "()Ljava/lang/String;", AccessFlags = 1025)]
				string GetStringData() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>String data to parse. If provided, this will always be treated as a sequence of 16-bit units (UTF-16 encoded characters). It is not a requirement to have an XML declaration when using <code>stringData</code>. If an XML declaration is present, the value of the encoding attribute will be ignored. </para>        
				/// </summary>
				/// <java-name>
				/// setStringData
				/// </java-name>
				[Dot42.DexImport("setStringData", "(Ljava/lang/String;)V", AccessFlags = 1025)]
				void SetStringData(string stringData) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>The system identifier, a URI reference [], for this input source. The system identifier is optional if there is a byte stream, a character stream, or string data. It is still useful to provide one, since the application will use it to resolve any relative URIs and can include it in error messages and warnings. (The LSParser will only attempt to fetch the resource identified by the URI reference if there is no other input available in the input source.) <br></br> If the application knows the character encoding of the object pointed to by the system identifier, it can set the encoding using the <code>encoding</code> attribute. <br></br> If the specified system ID is a relative URI reference (see section 5 in []), the DOM implementation will attempt to resolve the relative URI with the <code>baseURI</code> as the base, if that fails, the behavior is implementation dependent. </para>        
				/// </summary>
				/// <java-name>
				/// getSystemId
				/// </java-name>
				[Dot42.DexImport("getSystemId", "()Ljava/lang/String;", AccessFlags = 1025)]
				string GetSystemId() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>The system identifier, a URI reference [], for this input source. The system identifier is optional if there is a byte stream, a character stream, or string data. It is still useful to provide one, since the application will use it to resolve any relative URIs and can include it in error messages and warnings. (The LSParser will only attempt to fetch the resource identified by the URI reference if there is no other input available in the input source.) <br></br> If the application knows the character encoding of the object pointed to by the system identifier, it can set the encoding using the <code>encoding</code> attribute. <br></br> If the specified system ID is a relative URI reference (see section 5 in []), the DOM implementation will attempt to resolve the relative URI with the <code>baseURI</code> as the base, if that fails, the behavior is implementation dependent. </para>        
				/// </summary>
				/// <java-name>
				/// setSystemId
				/// </java-name>
				[Dot42.DexImport("setSystemId", "(Ljava/lang/String;)V", AccessFlags = 1025)]
				void SetSystemId(string systemId) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>The public identifier for this input source. This may be mapped to an input source using an implementation dependent mechanism (such as catalogues or other mappings). The public identifier, if specified, may also be reported as part of the location information when errors are reported. </para>        
				/// </summary>
				/// <java-name>
				/// getPublicId
				/// </java-name>
				[Dot42.DexImport("getPublicId", "()Ljava/lang/String;", AccessFlags = 1025)]
				string GetPublicId() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>The public identifier for this input source. This may be mapped to an input source using an implementation dependent mechanism (such as catalogues or other mappings). The public identifier, if specified, may also be reported as part of the location information when errors are reported. </para>        
				/// </summary>
				/// <java-name>
				/// setPublicId
				/// </java-name>
				[Dot42.DexImport("setPublicId", "(Ljava/lang/String;)V", AccessFlags = 1025)]
				void SetPublicId(string publicId) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>The base URI to be used (see section 5.1.4 in []) for resolving a relative <code>systemId</code> to an absolute URI. <br></br> If, when used, the base URI is itself a relative URI, an empty string, or null, the behavior is implementation dependent. </para>        
				/// </summary>
				/// <java-name>
				/// getBaseURI
				/// </java-name>
				[Dot42.DexImport("getBaseURI", "()Ljava/lang/String;", AccessFlags = 1025)]
				string GetBaseURI() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>The base URI to be used (see section 5.1.4 in []) for resolving a relative <code>systemId</code> to an absolute URI. <br></br> If, when used, the base URI is itself a relative URI, an empty string, or null, the behavior is implementation dependent. </para>        
				/// </summary>
				/// <java-name>
				/// setBaseURI
				/// </java-name>
				[Dot42.DexImport("setBaseURI", "(Ljava/lang/String;)V", AccessFlags = 1025)]
				void SetBaseURI(string baseURI) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>The character encoding, if known. The encoding must be a string acceptable for an XML encoding declaration ([] section 4.3.3 "Character Encoding in Entities"). <br></br> This attribute has no effect when the application provides a character stream or string data. For other sources of input, an encoding specified by means of this attribute will override any encoding specified in the XML declaration or the Text declaration, or an encoding obtained from a higher level protocol, such as HTTP []. </para>        
				/// </summary>
				/// <java-name>
				/// getEncoding
				/// </java-name>
				[Dot42.DexImport("getEncoding", "()Ljava/lang/String;", AccessFlags = 1025)]
				string GetEncoding() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>The character encoding, if known. The encoding must be a string acceptable for an XML encoding declaration ([] section 4.3.3 "Character Encoding in Entities"). <br></br> This attribute has no effect when the application provides a character stream or string data. For other sources of input, an encoding specified by means of this attribute will override any encoding specified in the XML declaration or the Text declaration, or an encoding obtained from a higher level protocol, such as HTTP []. </para>        
				/// </summary>
				/// <java-name>
				/// setEncoding
				/// </java-name>
				[Dot42.DexImport("setEncoding", "(Ljava/lang/String;)V", AccessFlags = 1025)]
				void SetEncoding(string encoding) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>If set to true, assume that the input is certified (see section 2.13 in []) when parsing []. </para>        
				/// </summary>
				/// <java-name>
				/// getCertifiedText
				/// </java-name>
				[Dot42.DexImport("getCertifiedText", "()Z", AccessFlags = 1025)]
				bool GetCertifiedText() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>If set to true, assume that the input is certified (see section 2.13 in []) when parsing []. </para>        
				/// </summary>
				/// <java-name>
				/// setCertifiedText
				/// </java-name>
				[Dot42.DexImport("setCertifiedText", "(Z)V", AccessFlags = 1025)]
				void SetCertifiedText(bool certifiedText) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para><span>&lt;code&gt;LSParserFilter&lt;/code&gt;s provide applications the ability to examine</span> nodes as they are being constructed while parsing. As each node is examined, it may be modified or removed, or the entire parse may be terminated early. </para><para>At the time any of the filter methods are called by the parser, the owner Document and DOMImplementation objects exist and are accessible. The document element is never passed to the <code>LSParserFilter</code> methods, i.e. it is not possible to filter out the document element. <code>Document</code>, <code>DocumentType</code>, <code>Notation</code>, <code>Entity</code>, and <code>Attr</code> nodes are never passed to the <code>acceptNode</code> method on the filter. The child nodes of an <code>EntityReference</code> node are passed to the filter if the parameter "&lt;a href='http://www.w3.org/TR/DOM-Level-3-Core/core.html#parameter-entities'&gt;   entities&lt;/a&gt;" is set to <code>false</code>. Note that, as described by the parameter "&lt;a href='http://www.w3.org/TR/DOM-Level-3-Core/core.html#parameter-entities'&gt;   entities&lt;/a&gt;", unexpanded entity reference nodes are never discarded and are always passed to the filter. </para><para>All validity checking while parsing a document occurs on the source document as it appears on the input stream, not on the DOM document as it is built in memory. With filters, the document in memory may be a subset of the document on the stream, and its validity may have been affected by the filtering. </para><para>All default attributes must be present on elements when the elements are passed to the filter methods. All other default content must be passed to the filter methods. </para><para>DOM applications must not raise exceptions in a filter. The effect of throwing exceptions from a filter is DOM implementation dependent. </para><para>See also the . </para>    
		/// </summary>
		/// <java-name>
		/// org/w3c/dom/ls/LSParserFilter
		/// </java-name>
		[Dot42.DexImport("org/w3c/dom/ls/LSParserFilter", AccessFlags = 1537, IgnoreFromJava = true, Priority = 1)]
		public static partial class ILSParserFilterConstants
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Accept the node. </para>        
				/// </summary>
				/// <java-name>
				/// FILTER_ACCEPT
				/// </java-name>
				[Dot42.DexImport("FILTER_ACCEPT", "S", AccessFlags = 25)]
				public const short FILTER_ACCEPT = 1;
				/// <summary>
				/// <para>Reject the node and its children. </para>        
				/// </summary>
				/// <java-name>
				/// FILTER_REJECT
				/// </java-name>
				[Dot42.DexImport("FILTER_REJECT", "S", AccessFlags = 25)]
				public const short FILTER_REJECT = 2;
				/// <summary>
				/// <para>Skip this single node. The children of this node will still be considered. </para>        
				/// </summary>
				/// <java-name>
				/// FILTER_SKIP
				/// </java-name>
				[Dot42.DexImport("FILTER_SKIP", "S", AccessFlags = 25)]
				public const short FILTER_SKIP = 3;
				/// <summary>
				/// <para>Interrupt the normal processing of the document. </para>        
				/// </summary>
				/// <java-name>
				/// FILTER_INTERRUPT
				/// </java-name>
				[Dot42.DexImport("FILTER_INTERRUPT", "S", AccessFlags = 25)]
				public const short FILTER_INTERRUPT = 4;
		}

		/// <summary>
		/// <para><span>&lt;code&gt;LSParserFilter&lt;/code&gt;s provide applications the ability to examine</span> nodes as they are being constructed while parsing. As each node is examined, it may be modified or removed, or the entire parse may be terminated early. </para><para>At the time any of the filter methods are called by the parser, the owner Document and DOMImplementation objects exist and are accessible. The document element is never passed to the <code>LSParserFilter</code> methods, i.e. it is not possible to filter out the document element. <code>Document</code>, <code>DocumentType</code>, <code>Notation</code>, <code>Entity</code>, and <code>Attr</code> nodes are never passed to the <code>acceptNode</code> method on the filter. The child nodes of an <code>EntityReference</code> node are passed to the filter if the parameter "&lt;a href='http://www.w3.org/TR/DOM-Level-3-Core/core.html#parameter-entities'&gt;   entities&lt;/a&gt;" is set to <code>false</code>. Note that, as described by the parameter "&lt;a href='http://www.w3.org/TR/DOM-Level-3-Core/core.html#parameter-entities'&gt;   entities&lt;/a&gt;", unexpanded entity reference nodes are never discarded and are always passed to the filter. </para><para>All validity checking while parsing a document occurs on the source document as it appears on the input stream, not on the DOM document as it is built in memory. With filters, the document in memory may be a subset of the document on the stream, and its validity may have been affected by the filtering. </para><para>All default attributes must be present on elements when the elements are passed to the filter methods. All other default content must be passed to the filter methods. </para><para>DOM applications must not raise exceptions in a filter. The effect of throwing exceptions from a filter is DOM implementation dependent. </para><para>See also the . </para>    
		/// </summary>
		/// <java-name>
		/// org/w3c/dom/ls/LSParserFilter
		/// </java-name>
		[Dot42.DexImport("org/w3c/dom/ls/LSParserFilter", AccessFlags = 1537)]
		public partial interface ILSParserFilter
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>The parser will call this method after each <code>Element</code> start tag has been scanned, but before the remainder of the <code>Element</code> is processed. The intent is to allow the element, including any children, to be efficiently skipped. Note that only element nodes are passed to the <code>startElement</code> function. <br></br>The element node passed to <code>startElement</code> for filtering will include all of the Element's attributes, but none of the children nodes. The Element may not yet be in place in the document being constructed (it may not have a parent node.) <br></br>A <code>startElement</code> filter function may access or change the attributes for the Element. Changing Namespace declarations will have no effect on namespace resolution by the parser. <br></br>For efficiency, the Element node passed to the filter may not be the same one as is actually placed in the tree if the node is accepted. And the actual node (node object identity) may be reused during the process of reading in and filtering a document. </para>        
				/// </summary>
				/// <returns>
				/// <para><ul><li><para><code>FILTER_ACCEPT</code> if the <code>Element</code> should be included in the DOM document being built.  </para></li><li><para><code>FILTER_REJECT</code> if the <code>Element</code> and all of its children should be rejected.  </para></li><li><para><code>FILTER_SKIP</code> if the <code>Element</code> should be skipped. All of its children are inserted in place of the skipped <code>Element</code> node.  </para></li><li><para><code>FILTER_INTERRUPT</code> if the filter wants to stop the processing of the document. Interrupting the processing of the document does no longer guarantee that the resulting DOM tree is XML well-formed. The <code>Element</code> is rejected.  </para></li></ul>Returning any other values will result in unspecified behavior. </para>
				/// </returns>
				/// <java-name>
				/// startElement
				/// </java-name>
				[Dot42.DexImport("startElement", "(Lorg/w3c/dom/Element;)S", AccessFlags = 1025)]
				short StartElement(global::Org.W3c.Dom.IElement elementArg) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>This method will be called by the parser at the completion of the parsing of each node. The node and all of its descendants will exist and be complete. The parent node will also exist, although it may be incomplete, i.e. it may have additional children that have not yet been parsed. Attribute nodes are never passed to this function. <br></br>From within this method, the new node may be freely modified - children may be added or removed, text nodes modified, etc. The state of the rest of the document outside this node is not defined, and the affect of any attempt to navigate to, or to modify any other part of the document is undefined. <br></br>For validating parsers, the checks are made on the original document, before any modification by the filter. No validity checks are made on any document modifications made by the filter. <br></br>If this new node is rejected, the parser might reuse the new node and any of its descendants. </para>        
				/// </summary>
				/// <returns>
				/// <para><ul><li><para><code>FILTER_ACCEPT</code> if this <code>Node</code> should be included in the DOM document being built.  </para></li><li><para><code>FILTER_REJECT</code> if the <code>Node</code> and all of its children should be rejected.  </para></li><li><para><code>FILTER_SKIP</code> if the <code>Node</code> should be skipped and the <code>Node</code> should be replaced by all the children of the <code>Node</code>.  </para></li><li><para><code>FILTER_INTERRUPT</code> if the filter wants to stop the processing of the document. Interrupting the processing of the document does no longer guarantee that the resulting DOM tree is XML well-formed. The <code>Node</code> is accepted and will be the last completely parsed node.  </para></li></ul></para>
				/// </returns>
				/// <java-name>
				/// acceptNode
				/// </java-name>
				[Dot42.DexImport("acceptNode", "(Lorg/w3c/dom/Node;)S", AccessFlags = 1025)]
				short AcceptNode(global::Org.W3c.Dom.INode nodeArg) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Tells the <code>LSParser</code> what types of nodes to show to the method <code>LSParserFilter.acceptNode</code>. If a node is not shown to the filter using this attribute, it is automatically included in the DOM document being built. See <code>NodeFilter</code> for definition of the constants. The constants <code>SHOW_ATTRIBUTE</code> , <code>SHOW_DOCUMENT</code>, <code>SHOW_DOCUMENT_TYPE</code>, <code>SHOW_NOTATION</code>, <code>SHOW_ENTITY</code>, and <code>SHOW_DOCUMENT_FRAGMENT</code> are meaningless here. Those nodes will never be passed to <code>LSParserFilter.acceptNode</code>. <br></br> The constants used here are defined in []</para>        
				/// </summary>
				/// <java-name>
				/// getWhatToShow
				/// </java-name>
				[Dot42.DexImport("getWhatToShow", "()I", AccessFlags = 1025)]
				int GetWhatToShow() /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// org/w3c/dom/ls/LSParser
		/// </java-name>
		[Dot42.DexImport("org/w3c/dom/ls/LSParser", AccessFlags = 1537, IgnoreFromJava = true, Priority = 1)]
		public static partial class ILSParserConstants
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// ACTION_APPEND_AS_CHILDREN
				/// </java-name>
				[Dot42.DexImport("ACTION_APPEND_AS_CHILDREN", "S", AccessFlags = 25)]
				public const short ACTION_APPEND_AS_CHILDREN = 1;
				/// <java-name>
				/// ACTION_REPLACE_CHILDREN
				/// </java-name>
				[Dot42.DexImport("ACTION_REPLACE_CHILDREN", "S", AccessFlags = 25)]
				public const short ACTION_REPLACE_CHILDREN = 2;
				/// <java-name>
				/// ACTION_INSERT_BEFORE
				/// </java-name>
				[Dot42.DexImport("ACTION_INSERT_BEFORE", "S", AccessFlags = 25)]
				public const short ACTION_INSERT_BEFORE = 3;
				/// <java-name>
				/// ACTION_INSERT_AFTER
				/// </java-name>
				[Dot42.DexImport("ACTION_INSERT_AFTER", "S", AccessFlags = 25)]
				public const short ACTION_INSERT_AFTER = 4;
				/// <java-name>
				/// ACTION_REPLACE
				/// </java-name>
				[Dot42.DexImport("ACTION_REPLACE", "S", AccessFlags = 25)]
				public const short ACTION_REPLACE = 5;
		}

		/// <java-name>
		/// org/w3c/dom/ls/LSParser
		/// </java-name>
		[Dot42.DexImport("org/w3c/dom/ls/LSParser", AccessFlags = 1537)]
		public partial interface ILSParser
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// getDomConfig
				/// </java-name>
				[Dot42.DexImport("getDomConfig", "()Lorg/w3c/dom/DOMConfiguration;", AccessFlags = 1025)]
				global::Org.W3c.Dom.IDOMConfiguration GetDomConfig() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getFilter
				/// </java-name>
				[Dot42.DexImport("getFilter", "()Lorg/w3c/dom/ls/LSParserFilter;", AccessFlags = 1025)]
				global::Org.W3c.Dom.Ls.ILSParserFilter GetFilter() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setFilter
				/// </java-name>
				[Dot42.DexImport("setFilter", "(Lorg/w3c/dom/ls/LSParserFilter;)V", AccessFlags = 1025)]
				void SetFilter(global::Org.W3c.Dom.Ls.ILSParserFilter lSParserFilter) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getAsync
				/// </java-name>
				[Dot42.DexImport("getAsync", "()Z", AccessFlags = 1025)]
				bool GetAsync() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getBusy
				/// </java-name>
				[Dot42.DexImport("getBusy", "()Z", AccessFlags = 1025)]
				bool GetBusy() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// parse
				/// </java-name>
				[Dot42.DexImport("parse", "(Lorg/w3c/dom/ls/LSInput;)Lorg/w3c/dom/Document;", AccessFlags = 1025)]
				global::Org.W3c.Dom.IDocument Parse(global::Org.W3c.Dom.Ls.ILSInput lSInput) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// parseURI
				/// </java-name>
				[Dot42.DexImport("parseURI", "(Ljava/lang/String;)Lorg/w3c/dom/Document;", AccessFlags = 1025)]
				global::Org.W3c.Dom.IDocument ParseURI(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// parseWithContext
				/// </java-name>
				[Dot42.DexImport("parseWithContext", "(Lorg/w3c/dom/ls/LSInput;Lorg/w3c/dom/Node;S)Lorg/w3c/dom/Node;", AccessFlags = 1025)]
				global::Org.W3c.Dom.INode ParseWithContext(global::Org.W3c.Dom.Ls.ILSInput lSInput, global::Org.W3c.Dom.INode node, short int16) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// abort
				/// </java-name>
				[Dot42.DexImport("abort", "()V", AccessFlags = 1025)]
				void Abort() /* MethodBuilder.Create */ ;

		}

}


