// Copyright (C) 2014 dot42
//
// Original filename: Org.Xml.Sax.Helpers.cs
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
namespace Org.Xml.Sax.Helpers
{
		/// <summary>
		/// <para>Factory for creating an XML reader.</para><para><blockquote><para><b>This module, both source code and documentation, is in the Public Domain, and comes with <b>NO WARRANTY</b>.</b> See  for further information. </para></blockquote></para><para>This class contains static methods for creating an XML reader from an explicit class name, or based on runtime defaults:</para><para><pre>
		///    try {
		///      XMLReader myReader = XMLReaderFactory.createXMLReader();
		///    } catch (SAXException e) {
		///      System.err.println(e.getMessage());
		///    }
		///    </pre></para><para><b>Note to Distributions bundled with parsers:</b> You should modify the implementation of the no-arguments <b>createXMLReader</b> to handle cases where the external configuration mechanisms aren't set up. That method should do its best to return a parser when one is in the class path, even when nothing bound its class name to <code>org.xml.sax.driver</code> so those configuration mechanisms would see it.</para><para><para>SAX 2.0 </para><para>David Megginson, David Brownell </para><para>2.0.1 (sax2r2) </para></para>    
		/// </summary>
		/// <java-name>
		/// org/xml/sax/helpers/XMLReaderFactory
		/// </java-name>
		[Dot42.DexImport("org/xml/sax/helpers/XMLReaderFactory", AccessFlags = 49)]
		public sealed partial class XMLReaderFactory
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Private constructor.</para><para>This constructor prevents the class from being instantiated.</para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal XMLReaderFactory() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Attempt to create an XMLReader from system defaults. In environments which can support it, the name of the XMLReader class is determined by trying each these options in order, and using the first one which succeeds:</para><para><ul><li><para>If the system property <code>org.xml.sax.driver</code> has a value, that is used as an XMLReader class name. </para><para></para></li><li><para>The JAR "Services API" is used to look for a class name in the <b>META-INF/services/org.xml.sax.driver</b> file in jarfiles available to the runtime.</para><para></para></li><li><para>SAX parser distributions are strongly encouraged to provide a default XMLReader class name that will take effect only when previous options (on this list) are not successful.</para><para></para></li><li><para>Finally, if ParserFactory#makeParser() can return a system default SAX1 parser, that parser is wrapped in a ParserAdapter. (This is a migration aid for SAX1 environments, where the <code>org.xml.sax.parser</code> system property will often be usable.) </para><para></para></li></ul></para><para>In environments such as small embedded systems, which can not support that flexibility, other mechanisms to determine the default may be used. </para><para>Note that many Java environments allow system properties to be initialized on a command line. This means that <b>in most cases</b> setting a good value for that property ensures that calls to this method will succeed, except when security policies intervene. This will also maximize application portability to older SAX environments, with less robust implementations of this method. </para><para><para>createXMLReader(java.lang.String) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>A new XMLReader. </para>
				/// </returns>
				/// <java-name>
				/// createXMLReader
				/// </java-name>
				[Dot42.DexImport("createXMLReader", "()Lorg/xml/sax/XMLReader;", AccessFlags = 9)]
				public static global::Org.Xml.Sax.IXMLReader CreateXMLReader() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Xml.Sax.IXMLReader);
				}

				/// <summary>
				/// <para>Attempt to create an XML reader from a class name.</para><para>Given a class name, this method attempts to load and instantiate the class as an XML reader.</para><para></para><para>Note that this method will not be usable in environments where the caller (perhaps an applet) is not permitted to load classes dynamically.</para><para><para>createXMLReader() </para></para>        
				/// </summary>
				/// <returns>
				/// <para>A new XML reader. </para>
				/// </returns>
				/// <java-name>
				/// createXMLReader
				/// </java-name>
				[Dot42.DexImport("createXMLReader", "(Ljava/lang/String;)Lorg/xml/sax/XMLReader;", AccessFlags = 9)]
				public static global::Org.Xml.Sax.IXMLReader CreateXMLReader(string className) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Xml.Sax.IXMLReader);
				}

		}

		/// <summary>
		/// <para>Default implementation of the Attributes interface.</para><para><blockquote><para><b>This module, both source code and documentation, is in the Public Domain, and comes with <b>NO WARRANTY</b>.</b> See  for further information. </para></blockquote></para><para>This class provides a default implementation of the SAX2 Attributes interface, with the addition of manipulators so that the list can be modified or reused.</para><para>There are two typical uses of this class:</para><para><ol><li><para>to take a persistent snapshot of an Attributes object in a startElement event; or </para></li><li><para>to construct or modify an Attributes object in a SAX2 driver or filter. </para></li></ol></para><para>This class replaces the now-deprecated SAX1 AttributeListImpl class; in addition to supporting the updated Attributes interface rather than the deprecated AttributeList interface, it also includes a much more efficient implementation using a single array rather than a set of Vectors.</para><para><para>SAX 2.0 </para><para>David Megginson </para><para>2.0.1 (sax2r2) </para></para>    
		/// </summary>
		/// <java-name>
		/// org/xml/sax/helpers/AttributesImpl
		/// </java-name>
		[Dot42.DexImport("org/xml/sax/helpers/AttributesImpl", AccessFlags = 33)]
		public partial class AttributesImpl : global::Org.Xml.Sax.IAttributes
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Construct a new, empty AttributesImpl object. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public AttributesImpl() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Copy an existing Attributes object.</para><para>This constructor is especially useful inside a startElement event.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Lorg/xml/sax/Attributes;)V", AccessFlags = 1)]
				public AttributesImpl(global::Org.Xml.Sax.IAttributes atts) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Return the number of attributes in the list.</para><para><para>org.xml.sax.Attributes::getLength </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The number of attributes in the list. </para>
				/// </returns>
				/// <java-name>
				/// getLength
				/// </java-name>
				[Dot42.DexImport("getLength", "()I", AccessFlags = 1)]
				public virtual int GetLength() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Return an attribute's Namespace URI.</para><para><para>org.xml.sax.Attributes::getURI </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The Namespace URI, the empty string if none is available, or null if the index is out of range. </para>
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
				/// <para>Return an attribute's local name.</para><para><para>org.xml.sax.Attributes::getLocalName </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The attribute's local name, the empty string if none is available, or null if the index if out of range. </para>
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
				/// <para>Return an attribute's qualified (prefixed) name.</para><para><para>org.xml.sax.Attributes::getQName </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The attribute's qualified name, the empty string if none is available, or null if the index is out of bounds. </para>
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
				/// <para>Return an attribute's type by index.</para><para><para>org.xml.sax.Attributes::getType(int) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The attribute's type, "CDATA" if the type is unknown, or null if the index is out of bounds. </para>
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
				/// <para>Return an attribute's value by index.</para><para><para>org.xml.sax.Attributes::getValue(int) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The attribute's value or null if the index is out of bounds. </para>
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
				/// <para>Look up an attribute's index by Namespace name.</para><para>In many cases, it will be more efficient to look up the name once and use the index query methods rather than using the name query methods repeatedly.</para><para><para>org.xml.sax.Attributes::getIndex(java.lang.String,java.lang.String) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The attribute's index, or -1 if none matches. </para>
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
				/// <para>Look up an attribute's index by qualified (prefixed) name.</para><para><para>org.xml.sax.Attributes::getIndex(java.lang.String) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The attribute's index, or -1 if none matches. </para>
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
				/// <para>Look up an attribute's type by Namespace-qualified name.</para><para><para>org.xml.sax.Attributes::getType(java.lang.String,java.lang.String) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The attribute's type, or null if there is no matching attribute. </para>
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
				/// <para>Return an attribute's type by index.</para><para><para>org.xml.sax.Attributes::getType(int) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The attribute's type, "CDATA" if the type is unknown, or null if the index is out of bounds. </para>
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
				/// <para>Look up an attribute's value by Namespace-qualified name.</para><para><para>org.xml.sax.Attributes::getValue(java.lang.String,java.lang.String) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The attribute's value, or null if there is no matching attribute. </para>
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
				/// <para>Return an attribute's value by index.</para><para><para>org.xml.sax.Attributes::getValue(int) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The attribute's value or null if the index is out of bounds. </para>
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
				/// <para>Clear the attribute list for reuse.</para><para>Note that little memory is freed by this call: the current array is kept so it can be reused.</para>        
				/// </summary>
				/// <java-name>
				/// clear
				/// </java-name>
				[Dot42.DexImport("clear", "()V", AccessFlags = 1)]
				public virtual void Clear() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Copy an entire Attributes object.</para><para>It may be more efficient to reuse an existing object rather than constantly allocating new ones.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setAttributes
				/// </java-name>
				[Dot42.DexImport("setAttributes", "(Lorg/xml/sax/Attributes;)V", AccessFlags = 1)]
				public virtual void SetAttributes(global::Org.Xml.Sax.IAttributes atts) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Add an attribute to the end of the list.</para><para>For the sake of speed, this method does no checking to see if the attribute is already in the list: that is the responsibility of the application.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// addAttribute
				/// </java-name>
				[Dot42.DexImport("addAttribute", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/la" +
    "ng/String;)V", AccessFlags = 1)]
				public virtual void AddAttribute(string uri, string localName, string qName, string type, string value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Set an attribute in the list.</para><para>For the sake of speed, this method does no checking for name conflicts or well-formedness: such checks are the responsibility of the application.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setAttribute
				/// </java-name>
				[Dot42.DexImport("setAttribute", "(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/l" +
    "ang/String;)V", AccessFlags = 1)]
				public virtual void SetAttribute(int index, string uri, string localName, string qName, string type, string value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Remove an attribute from the list.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// removeAttribute
				/// </java-name>
				[Dot42.DexImport("removeAttribute", "(I)V", AccessFlags = 1)]
				public virtual void RemoveAttribute(int index) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Set the Namespace URI of a specific attribute.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setURI
				/// </java-name>
				[Dot42.DexImport("setURI", "(ILjava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetURI(int index, string uri) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Set the local name of a specific attribute.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setLocalName
				/// </java-name>
				[Dot42.DexImport("setLocalName", "(ILjava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetLocalName(int index, string localName) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Set the qualified name of a specific attribute.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setQName
				/// </java-name>
				[Dot42.DexImport("setQName", "(ILjava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetQName(int index, string qName) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Set the type of a specific attribute.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setType
				/// </java-name>
				[Dot42.DexImport("setType", "(ILjava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetType(int index, string type) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Set the value of a specific attribute.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setValue
				/// </java-name>
				[Dot42.DexImport("setValue", "(ILjava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetValue(int index, string value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Return the number of attributes in the list.</para><para><para>org.xml.sax.Attributes::getLength </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The number of attributes in the list. </para>
				/// </returns>
				/// <java-name>
				/// getLength
				/// </java-name>
				public int Length
				{
				[Dot42.DexImport("getLength", "()I", AccessFlags = 1)]
						get{ return GetLength(); }
				}

		}

		/// <summary>
		/// <para>Encapsulate Namespace logic for use by applications using SAX, or internally by SAX drivers.</para><para><blockquote><para><b>This module, both source code and documentation, is in the Public Domain, and comes with <b>NO WARRANTY</b>.</b> See  for further information. </para></blockquote></para><para>This class encapsulates the logic of Namespace processing: it tracks the declarations currently in force for each context and automatically processes qualified XML names into their Namespace parts; it can also be used in reverse for generating XML qnames from Namespaces.</para><para>Namespace support objects are reusable, but the reset method must be invoked between each session.</para><para>Here is a simple session:</para><para><pre>
		///    String parts[] = new String[3];
		///    NamespaceSupport support = new NamespaceSupport();
		/// 
		///    support.pushContext();
		///    support.declarePrefix("", "http://www.w3.org/1999/xhtml");
		///    support.declarePrefix("dc", "http://www.purl.org/dc#");
		/// 
		///    parts = support.processName("p", parts, false);
		///    System.out.println("Namespace URI: " + parts[0]);
		///    System.out.println("Local name: " + parts[1]);
		///    System.out.println("Raw name: " + parts[2]);
		/// 
		///    parts = support.processName("dc:title", parts, false);
		///    System.out.println("Namespace URI: " + parts[0]);
		///    System.out.println("Local name: " + parts[1]);
		///    System.out.println("Raw name: " + parts[2]);
		/// 
		///    support.popContext();
		///    </pre></para><para>Note that this class is optimized for the use case where most elements do not contain Namespace declarations: if the same prefix/URI mapping is repeated for each context (for example), this class will be somewhat less efficient.</para><para>Although SAX drivers (parsers) may choose to use this class to implement namespace handling, they are not required to do so. Applications must track namespace information themselves if they want to use namespace information.</para><para><para>SAX 2.0 </para><para>David Megginson </para><para>2.0.1 (sax2r2) </para></para>    
		/// </summary>
		/// <java-name>
		/// org/xml/sax/helpers/NamespaceSupport
		/// </java-name>
		[Dot42.DexImport("org/xml/sax/helpers/NamespaceSupport", AccessFlags = 33)]
		public partial class NamespaceSupport
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>The XML Namespace URI as a constant. The value is <code></code> as defined in the "Namespaces in XML" * recommendation.</para><para>This is the Namespace URI that is automatically mapped to the "xml" prefix.</para>        
				/// </summary>
				/// <java-name>
				/// XMLNS
				/// </java-name>
				[Dot42.DexImport("XMLNS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string XMLNS = "http://www.w3.org/XML/1998/namespace";
				/// <summary>
				/// <para>The namespace declaration URI as a constant. The value is <code></code>, as defined in a backwards-incompatible erratum to the "Namespaces in XML" recommendation. Because that erratum postdated SAX2, SAX2 defaults to the original recommendation, and does not normally use this URI.</para><para>This is the Namespace URI that is optionally applied to <b>xmlns</b> and <b>xmlns:*</b> attributes, which are used to declare namespaces. </para><para><para>SAX 2.1alpha </para><para>setNamespaceDeclUris </para><simplesectsep></simplesectsep><para>isNamespaceDeclUris </para></para>        
				/// </summary>
				/// <java-name>
				/// NSDECL
				/// </java-name>
				[Dot42.DexImport("NSDECL", "Ljava/lang/String;", AccessFlags = 25)]
				public const string NSDECL = "http://www.w3.org/xmlns/2000/";
				/// <summary>
				/// <para>Create a new Namespace support object. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public NamespaceSupport() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Reset this Namespace support object for reuse.</para><para>It is necessary to invoke this method before reusing the Namespace support object for a new session. If namespace declaration URIs are to be supported, that flag must also be set to a non-default value. </para><para><para>setNamespaceDeclUris </para></para>        
				/// </summary>
				/// <java-name>
				/// reset
				/// </java-name>
				[Dot42.DexImport("reset", "()V", AccessFlags = 1)]
				public virtual void Reset() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Start a new Namespace context. The new context will automatically inherit the declarations of its parent context, but it will also keep track of which declarations were made within this context.</para><para>Event callback code should start a new context once per element. This means being ready to call this in either of two places. For elements that don't include namespace declarations, the <b>ContentHandler.startElement()</b> callback is the right place. For elements with such a declaration, it'd done in the first <b>ContentHandler.startPrefixMapping()</b> callback. A boolean flag can be used to track whether a context has been started yet. When either of those methods is called, it checks the flag to see if a new context needs to be started. If so, it starts the context and sets the flag. After <b>ContentHandler.startElement()</b> does that, it always clears the flag.</para><para>Normally, SAX drivers would push a new context at the beginning of each XML element. Then they perform a first pass over the attributes to process all namespace declarations, making <b>ContentHandler.startPrefixMapping()</b> callbacks. Then a second pass is made, to determine the namespace-qualified names for all attributes and for the element name. Finally all the information for the <b>ContentHandler.startElement()</b> callback is available, so it can then be made.</para><para>The Namespace support object always starts with a base context already in force: in this context, only the "xml" prefix is declared.</para><para><para>org.xml.sax.ContentHandler </para><simplesectsep></simplesectsep><para>popContext </para></para>        
				/// </summary>
				/// <java-name>
				/// pushContext
				/// </java-name>
				[Dot42.DexImport("pushContext", "()V", AccessFlags = 1)]
				public virtual void PushContext() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Revert to the previous Namespace context.</para><para>Normally, you should pop the context at the end of each XML element. After popping the context, all Namespace prefix mappings that were previously in force are restored.</para><para>You must not attempt to declare additional Namespace prefixes after popping a context, unless you push another context first.</para><para><para>pushContext </para></para>        
				/// </summary>
				/// <java-name>
				/// popContext
				/// </java-name>
				[Dot42.DexImport("popContext", "()V", AccessFlags = 1)]
				public virtual void PopContext() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Declare a Namespace prefix. All prefixes must be declared before they are referenced. For example, a SAX driver (parser) would scan an element's attributes in two passes: first for namespace declarations, then a second pass using processName() to interpret prefixes against (potentially redefined) prefixes.</para><para>This method declares a prefix in the current Namespace context; the prefix will remain in force until this context is popped, unless it is shadowed in a descendant context.</para><para>To declare the default element Namespace, use the empty string as the prefix.</para><para>Note that you must <b>not</b> declare a prefix after you've pushed and popped another Namespace context, or treated the declarations phase as complete by processing a prefixed name.</para><para>Note that there is an asymmetry in this library: getPrefix will not return the "" prefix, even if you have declared a default element namespace. To check for a default namespace, you have to look it up explicitly using getURI. This asymmetry exists to make it easier to look up prefixes for attribute names, where the default prefix is not allowed.</para><para><para>processName </para><simplesectsep></simplesectsep><para>getURI </para><simplesectsep></simplesectsep><para>getPrefix </para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if the prefix was legal, false otherwise</para>
				/// </returns>
				/// <java-name>
				/// declarePrefix
				/// </java-name>
				[Dot42.DexImport("declarePrefix", "(Ljava/lang/String;Ljava/lang/String;)Z", AccessFlags = 1)]
				public virtual bool DeclarePrefix(string prefix, string uri) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Process a raw XML qualified name, after all declarations in the current context have been handled by declarePrefix().</para><para>This method processes a raw XML qualified name in the current context by removing the prefix and looking it up among the prefixes currently declared. The return value will be the array supplied by the caller, filled in as follows:</para><para></para><para>All of the strings in the array will be internalized. If the raw name has a prefix that has not been declared, then the return value will be null.</para><para>Note that attribute names are processed differently than element names: an unprefixed element name will receive the default Namespace (if any), while an unprefixed attribute name will not.</para><para><para>declarePrefix </para><simplesectsep></simplesectsep><para>java.lang.String::intern </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The supplied array holding three internalized strings representing the Namespace URI (or empty string), the local name, and the XML qualified name; or null if there is an undeclared prefix. </para>
				/// </returns>
				/// <java-name>
				/// processName
				/// </java-name>
				[Dot42.DexImport("processName", "(Ljava/lang/String;[Ljava/lang/String;Z)[Ljava/lang/String;", AccessFlags = 1)]
				public virtual string[] ProcessName(string qName, string[] parts, bool isAttribute) /* MethodBuilder.Create */ 
				{
						return default(string[]);
				}

				/// <summary>
				/// <para>Look up a prefix and get the currently-mapped Namespace URI.</para><para>This method looks up the prefix in the current context. Use the empty string ("") for the default Namespace.</para><para><para>getPrefix </para><simplesectsep></simplesectsep><para>getPrefixes </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The associated Namespace URI, or null if the prefix is undeclared in this context. </para>
				/// </returns>
				/// <java-name>
				/// getURI
				/// </java-name>
				[Dot42.DexImport("getURI", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetURI(string prefix) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Return an enumeration of all prefixes whose declarations are active in the current context. This includes declarations from parent contexts that have not been overridden.</para><para><b>Note:</b> if there is a default prefix, it will not be returned in this enumeration; check for the default prefix using the getURI with an argument of "".</para><para><para>getDeclaredPrefixes </para><simplesectsep></simplesectsep><para>getURI </para></para>        
				/// </summary>
				/// <returns>
				/// <para>An enumeration of prefixes (never empty). </para>
				/// </returns>
				/// <java-name>
				/// getPrefixes
				/// </java-name>
				[Dot42.DexImport("getPrefixes", "()Ljava/util/Enumeration;", AccessFlags = 1)]
				public virtual global::Java.Util.IEnumeration<object> GetPrefixes() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IEnumeration<object>);
				}

				/// <summary>
				/// <para>Return one of the prefixes mapped to a Namespace URI.</para><para>If more than one prefix is currently mapped to the same URI, this method will make an arbitrary selection; if you want all of the prefixes, use the getPrefixes method instead.</para><para><b>Note:</b> this will never return the empty (default) prefix; to check for a default prefix, use the getURI method with an argument of "".</para><para><para>getPrefixes(java.lang.String) </para><simplesectsep></simplesectsep><para>getURI </para></para>        
				/// </summary>
				/// <returns>
				/// <para>one of the prefixes currently mapped to the URI supplied, or null if none is mapped or if the URI is assigned to the default namespace </para>
				/// </returns>
				/// <java-name>
				/// getPrefix
				/// </java-name>
				[Dot42.DexImport("getPrefix", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetPrefix(string uri) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Return an enumeration of all prefixes for a given URI whose declarations are active in the current context. This includes declarations from parent contexts that have not been overridden.</para><para>This method returns prefixes mapped to a specific Namespace URI. The xml: prefix will be included. If you want only one prefix that's mapped to the Namespace URI, and you don't care which one you get, use the getPrefix method instead.</para><para><b>Note:</b> the empty (default) prefix is <b>never</b> included in this enumeration; to check for the presence of a default Namespace, use the getURI method with an argument of "".</para><para><para>getPrefix </para><simplesectsep></simplesectsep><para>getDeclaredPrefixes </para><simplesectsep></simplesectsep><para>getURI </para></para>        
				/// </summary>
				/// <returns>
				/// <para>An enumeration of prefixes (never empty). </para>
				/// </returns>
				/// <java-name>
				/// getPrefixes
				/// </java-name>
				[Dot42.DexImport("getPrefixes", "(Ljava/lang/String;)Ljava/util/Enumeration;", AccessFlags = 1)]
				public virtual global::Java.Util.IEnumeration<object> GetPrefixes(string uri) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IEnumeration<object>);
				}

				/// <summary>
				/// <para>Return an enumeration of all prefixes declared in this context.</para><para>The empty (default) prefix will be included in this enumeration; note that this behaviour differs from that of getPrefix and getPrefixes.</para><para><para>getPrefixes </para><simplesectsep></simplesectsep><para>getURI </para></para>        
				/// </summary>
				/// <returns>
				/// <para>An enumeration of all prefixes declared in this context. </para>
				/// </returns>
				/// <java-name>
				/// getDeclaredPrefixes
				/// </java-name>
				[Dot42.DexImport("getDeclaredPrefixes", "()Ljava/util/Enumeration;", AccessFlags = 1)]
				public virtual global::Java.Util.IEnumeration<object> GetDeclaredPrefixes() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IEnumeration<object>);
				}

				/// <summary>
				/// <para>Controls whether namespace declaration attributes are placed into the NSDECL namespace by processName(). This may only be changed before any contexts have been pushed.</para><para><para>SAX 2.1alpha</para></para>        
				/// </summary>
				/// <java-name>
				/// setNamespaceDeclUris
				/// </java-name>
				[Dot42.DexImport("setNamespaceDeclUris", "(Z)V", AccessFlags = 1)]
				public virtual void SetNamespaceDeclUris(bool value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns true if namespace declaration attributes are placed into a namespace. This behavior is not the default.</para><para><para>SAX 2.1alpha </para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if namespace declaration attributes are enabled, false otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isNamespaceDeclUris
				/// </java-name>
				[Dot42.DexImport("isNamespaceDeclUris", "()Z", AccessFlags = 1)]
				public virtual bool IsNamespaceDeclUris() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Return an enumeration of all prefixes whose declarations are active in the current context. This includes declarations from parent contexts that have not been overridden.</para><para><b>Note:</b> if there is a default prefix, it will not be returned in this enumeration; check for the default prefix using the getURI with an argument of "".</para><para><para>getDeclaredPrefixes </para><simplesectsep></simplesectsep><para>getURI </para></para>        
				/// </summary>
				/// <returns>
				/// <para>An enumeration of prefixes (never empty). </para>
				/// </returns>
				/// <java-name>
				/// getPrefixes
				/// </java-name>
				public global::Java.Util.IEnumeration<object> Prefixes
				{
				[Dot42.DexImport("getPrefixes", "()Ljava/util/Enumeration;", AccessFlags = 1)]
						get{ return GetPrefixes(); }
				}

				/// <summary>
				/// <para>Return an enumeration of all prefixes declared in this context.</para><para>The empty (default) prefix will be included in this enumeration; note that this behaviour differs from that of getPrefix and getPrefixes.</para><para><para>getPrefixes </para><simplesectsep></simplesectsep><para>getURI </para></para>        
				/// </summary>
				/// <returns>
				/// <para>An enumeration of all prefixes declared in this context. </para>
				/// </returns>
				/// <java-name>
				/// getDeclaredPrefixes
				/// </java-name>
				public global::Java.Util.IEnumeration<object> DeclaredPrefixes
				{
				[Dot42.DexImport("getDeclaredPrefixes", "()Ljava/util/Enumeration;", AccessFlags = 1)]
						get{ return GetDeclaredPrefixes(); }
				}

		}

		/// <summary>
		/// <para>Base class for deriving an XML filter.</para><para><blockquote><para><b>This module, both source code and documentation, is in the Public Domain, and comes with <b>NO WARRANTY</b>.</b> See  for further information. </para></blockquote></para><para>This class is designed to sit between an XMLReader and the client application's event handlers. By default, it does nothing but pass requests up to the reader and events on to the handlers unmodified, but subclasses can override specific methods to modify the event stream or the configuration requests as they pass through.</para><para><para>SAX 2.0 </para><para>David Megginson </para><para>2.0.1 (sax2r2) </para><para>org.xml.sax.XMLFilter </para><simplesectsep></simplesectsep><para>org.xml.sax.XMLReader </para><simplesectsep></simplesectsep><para>org.xml.sax.EntityResolver </para><simplesectsep></simplesectsep><para>org.xml.sax.DTDHandler </para><simplesectsep></simplesectsep><para>org.xml.sax.ContentHandler </para><simplesectsep></simplesectsep><para>org.xml.sax.ErrorHandler </para></para>    
		/// </summary>
		/// <java-name>
		/// org/xml/sax/helpers/XMLFilterImpl
		/// </java-name>
		[Dot42.DexImport("org/xml/sax/helpers/XMLFilterImpl", AccessFlags = 33)]
		public partial class XMLFilterImpl : global::Org.Xml.Sax.IXMLFilter, global::Org.Xml.Sax.IEntityResolver, global::Org.Xml.Sax.IDTDHandler, global::Org.Xml.Sax.IContentHandler, global::Org.Xml.Sax.IErrorHandler
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Construct an empty XML filter, with no parent.</para><para>This filter will have no parent: you must assign a parent before you start a parse or do any configuration with setFeature or setProperty, unless you use this as a pure event consumer rather than as an XMLReader.</para><para><para>org.xml.sax.XMLReader::setFeature </para><simplesectsep></simplesectsep><para>org.xml.sax.XMLReader::setProperty </para><simplesectsep></simplesectsep><para>setParent </para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public XMLFilterImpl() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Construct an XML filter with the specified parent.</para><para><para>setParent </para><simplesectsep></simplesectsep><para>getParent </para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Lorg/xml/sax/XMLReader;)V", AccessFlags = 1)]
				public XMLFilterImpl(global::Org.Xml.Sax.IXMLReader parent) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Set the parent reader.</para><para>This is the XMLReader from which this filter will obtain its events and to which it will pass its configuration requests. The parent may itself be another filter.</para><para>If there is no parent reader set, any attempt to parse or to set or get a feature or property will fail.</para><para><para>getParent </para></para>        
				/// </summary>
				/// <java-name>
				/// setParent
				/// </java-name>
				[Dot42.DexImport("setParent", "(Lorg/xml/sax/XMLReader;)V", AccessFlags = 1)]
				public virtual void SetParent(global::Org.Xml.Sax.IXMLReader parent) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Get the parent reader.</para><para><para>setParent </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The parent XML reader, or null if none is set. </para>
				/// </returns>
				/// <java-name>
				/// getParent
				/// </java-name>
				[Dot42.DexImport("getParent", "()Lorg/xml/sax/XMLReader;", AccessFlags = 1)]
				public virtual global::Org.Xml.Sax.IXMLReader GetParent() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Xml.Sax.IXMLReader);
				}

				/// <summary>
				/// <para>Set the value of a feature.</para><para>This will always fail if the parent is null.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setFeature
				/// </java-name>
				[Dot42.DexImport("setFeature", "(Ljava/lang/String;Z)V", AccessFlags = 1)]
				public virtual void SetFeature(string name, bool value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Look up the value of a feature.</para><para>This will always fail if the parent is null.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The current value of the feature. </para>
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
				/// <para>Set the value of a property.</para><para>This will always fail if the parent is null.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setProperty
				/// </java-name>
				[Dot42.DexImport("setProperty", "(Ljava/lang/String;Ljava/lang/Object;)V", AccessFlags = 1)]
				public virtual void SetProperty(string name, object value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Look up the value of a property.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The current value of the property. </para>
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
				/// <para>Set the entity resolver.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setEntityResolver
				/// </java-name>
				[Dot42.DexImport("setEntityResolver", "(Lorg/xml/sax/EntityResolver;)V", AccessFlags = 1)]
				public virtual void SetEntityResolver(global::Org.Xml.Sax.IEntityResolver resolver) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Get the current entity resolver.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The current entity resolver, or null if none was set. </para>
				/// </returns>
				/// <java-name>
				/// getEntityResolver
				/// </java-name>
				[Dot42.DexImport("getEntityResolver", "()Lorg/xml/sax/EntityResolver;", AccessFlags = 1)]
				public virtual global::Org.Xml.Sax.IEntityResolver GetEntityResolver() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Xml.Sax.IEntityResolver);
				}

				/// <summary>
				/// <para>Set the DTD event handler.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setDTDHandler
				/// </java-name>
				[Dot42.DexImport("setDTDHandler", "(Lorg/xml/sax/DTDHandler;)V", AccessFlags = 1)]
				public virtual void SetDTDHandler(global::Org.Xml.Sax.IDTDHandler handler) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Get the current DTD event handler.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The current DTD handler, or null if none was set. </para>
				/// </returns>
				/// <java-name>
				/// getDTDHandler
				/// </java-name>
				[Dot42.DexImport("getDTDHandler", "()Lorg/xml/sax/DTDHandler;", AccessFlags = 1)]
				public virtual global::Org.Xml.Sax.IDTDHandler GetDTDHandler() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Xml.Sax.IDTDHandler);
				}

				/// <summary>
				/// <para>Set the content event handler.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setContentHandler
				/// </java-name>
				[Dot42.DexImport("setContentHandler", "(Lorg/xml/sax/ContentHandler;)V", AccessFlags = 1)]
				public virtual void SetContentHandler(global::Org.Xml.Sax.IContentHandler handler) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Get the content event handler.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The current content handler, or null if none was set. </para>
				/// </returns>
				/// <java-name>
				/// getContentHandler
				/// </java-name>
				[Dot42.DexImport("getContentHandler", "()Lorg/xml/sax/ContentHandler;", AccessFlags = 1)]
				public virtual global::Org.Xml.Sax.IContentHandler GetContentHandler() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Xml.Sax.IContentHandler);
				}

				/// <summary>
				/// <para>Set the error event handler.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setErrorHandler
				/// </java-name>
				[Dot42.DexImport("setErrorHandler", "(Lorg/xml/sax/ErrorHandler;)V", AccessFlags = 1)]
				public virtual void SetErrorHandler(global::Org.Xml.Sax.IErrorHandler handler) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Get the current error event handler.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The current error handler, or null if none was set. </para>
				/// </returns>
				/// <java-name>
				/// getErrorHandler
				/// </java-name>
				[Dot42.DexImport("getErrorHandler", "()Lorg/xml/sax/ErrorHandler;", AccessFlags = 1)]
				public virtual global::Org.Xml.Sax.IErrorHandler GetErrorHandler() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Xml.Sax.IErrorHandler);
				}

				/// <summary>
				/// <para>Parse a document.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// parse
				/// </java-name>
				[Dot42.DexImport("parse", "(Lorg/xml/sax/InputSource;)V", AccessFlags = 1)]
				public virtual void Parse(global::Org.Xml.Sax.InputSource input) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Parse a document.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// parse
				/// </java-name>
				[Dot42.DexImport("parse", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void Parse(string input) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Filter an external entity resolution.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>A new InputSource or null for the default. </para>
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
				/// <para>Filter a notation declaration event.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// notationDecl
				/// </java-name>
				[Dot42.DexImport("notationDecl", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void NotationDecl(string name, string publicId, string systemId) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Filter an unparsed entity declaration event.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// unparsedEntityDecl
				/// </java-name>
				[Dot42.DexImport("unparsedEntityDecl", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void UnparsedEntityDecl(string name, string publicId, string systemId, string notationName) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Filter a new document locator event.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setDocumentLocator
				/// </java-name>
				[Dot42.DexImport("setDocumentLocator", "(Lorg/xml/sax/Locator;)V", AccessFlags = 1)]
				public virtual void SetDocumentLocator(global::Org.Xml.Sax.ILocator locator) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Filter a start document event.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// startDocument
				/// </java-name>
				[Dot42.DexImport("startDocument", "()V", AccessFlags = 1)]
				public virtual void StartDocument() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Filter an end document event.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// endDocument
				/// </java-name>
				[Dot42.DexImport("endDocument", "()V", AccessFlags = 1)]
				public virtual void EndDocument() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Filter a start Namespace prefix mapping event.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// startPrefixMapping
				/// </java-name>
				[Dot42.DexImport("startPrefixMapping", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void StartPrefixMapping(string prefix, string uri) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Filter an end Namespace prefix mapping event.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// endPrefixMapping
				/// </java-name>
				[Dot42.DexImport("endPrefixMapping", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void EndPrefixMapping(string prefix) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Filter a start element event.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// startElement
				/// </java-name>
				[Dot42.DexImport("startElement", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lorg/xml/sax/Attributes;)V" +
    "", AccessFlags = 1)]
				public virtual void StartElement(string uri, string localName, string qName, global::Org.Xml.Sax.IAttributes atts) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Filter an end element event.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// endElement
				/// </java-name>
				[Dot42.DexImport("endElement", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void EndElement(string uri, string localName, string qName) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Filter a character data event.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// characters
				/// </java-name>
				[Dot42.DexImport("characters", "([CII)V", AccessFlags = 1)]
				public virtual void Characters(char[] ch, int start, int length) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Filter an ignorable whitespace event.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// ignorableWhitespace
				/// </java-name>
				[Dot42.DexImport("ignorableWhitespace", "([CII)V", AccessFlags = 1)]
				public virtual void IgnorableWhitespace(char[] ch, int start, int length) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Filter a processing instruction event.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// processingInstruction
				/// </java-name>
				[Dot42.DexImport("processingInstruction", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void ProcessingInstruction(string target, string data) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Filter a skipped entity event.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// skippedEntity
				/// </java-name>
				[Dot42.DexImport("skippedEntity", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SkippedEntity(string name) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Filter a warning event.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// warning
				/// </java-name>
				[Dot42.DexImport("warning", "(Lorg/xml/sax/SAXParseException;)V", AccessFlags = 1)]
				public virtual void Warning(global::Org.Xml.Sax.SAXParseException e) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Filter an error event.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// error
				/// </java-name>
				[Dot42.DexImport("error", "(Lorg/xml/sax/SAXParseException;)V", AccessFlags = 1)]
				public virtual void Error(global::Org.Xml.Sax.SAXParseException e) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Filter a fatal error event.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// fatalError
				/// </java-name>
				[Dot42.DexImport("fatalError", "(Lorg/xml/sax/SAXParseException;)V", AccessFlags = 1)]
				public virtual void FatalError(global::Org.Xml.Sax.SAXParseException e) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Get the parent reader.</para><para><para>setParent </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The parent XML reader, or null if none is set. </para>
				/// </returns>
				/// <java-name>
				/// getParent
				/// </java-name>
				public global::Org.Xml.Sax.IXMLReader Parent
				{
				[Dot42.DexImport("getParent", "()Lorg/xml/sax/XMLReader;", AccessFlags = 1)]
						get{ return GetParent(); }
				[Dot42.DexImport("setParent", "(Lorg/xml/sax/XMLReader;)V", AccessFlags = 1)]
						set{ SetParent(value); }
				}

				/// <summary>
				/// <para>Get the current entity resolver.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The current entity resolver, or null if none was set. </para>
				/// </returns>
				/// <java-name>
				/// getEntityResolver
				/// </java-name>
				public global::Org.Xml.Sax.IEntityResolver EntityResolver
				{
				[Dot42.DexImport("getEntityResolver", "()Lorg/xml/sax/EntityResolver;", AccessFlags = 1)]
						get{ return GetEntityResolver(); }
				[Dot42.DexImport("setEntityResolver", "(Lorg/xml/sax/EntityResolver;)V", AccessFlags = 1)]
						set{ SetEntityResolver(value); }
				}

				/// <summary>
				/// <para>Get the current DTD event handler.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The current DTD handler, or null if none was set. </para>
				/// </returns>
				/// <java-name>
				/// getDTDHandler
				/// </java-name>
				public global::Org.Xml.Sax.IDTDHandler DTDHandler
				{
				[Dot42.DexImport("getDTDHandler", "()Lorg/xml/sax/DTDHandler;", AccessFlags = 1)]
						get{ return GetDTDHandler(); }
				[Dot42.DexImport("setDTDHandler", "(Lorg/xml/sax/DTDHandler;)V", AccessFlags = 1)]
						set{ SetDTDHandler(value); }
				}

				/// <summary>
				/// <para>Get the content event handler.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The current content handler, or null if none was set. </para>
				/// </returns>
				/// <java-name>
				/// getContentHandler
				/// </java-name>
				public global::Org.Xml.Sax.IContentHandler ContentHandler
				{
				[Dot42.DexImport("getContentHandler", "()Lorg/xml/sax/ContentHandler;", AccessFlags = 1)]
						get{ return GetContentHandler(); }
				[Dot42.DexImport("setContentHandler", "(Lorg/xml/sax/ContentHandler;)V", AccessFlags = 1)]
						set{ SetContentHandler(value); }
				}

				/// <summary>
				/// <para>Get the current error event handler.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The current error handler, or null if none was set. </para>
				/// </returns>
				/// <java-name>
				/// getErrorHandler
				/// </java-name>
				public global::Org.Xml.Sax.IErrorHandler ErrorHandler
				{
				[Dot42.DexImport("getErrorHandler", "()Lorg/xml/sax/ErrorHandler;", AccessFlags = 1)]
						get{ return GetErrorHandler(); }
				[Dot42.DexImport("setErrorHandler", "(Lorg/xml/sax/ErrorHandler;)V", AccessFlags = 1)]
						set{ SetErrorHandler(value); }
				}

		}

		/// <summary>
		/// <para>Default implementation for AttributeList.</para><para><blockquote><para><b>This module, both source code and documentation, is in the Public Domain, and comes with <b>NO WARRANTY</b>.</b> See  for further information. </para></blockquote></para><para>AttributeList implements the deprecated SAX1 AttributeList interface, and has been replaced by the new SAX2 AttributesImpl interface.</para><para>This class provides a convenience implementation of the SAX AttributeList interface. This implementation is useful both for SAX parser writers, who can use it to provide attributes to the application, and for SAX application writers, who can use it to create a persistent copy of an element's attribute specifications:</para><para><pre>
		///    private AttributeList myatts;
		/// 
		///    public void startElement (String name, AttributeList atts)
		///    {
		///                 // create a persistent copy of the attribute list
		///                 // for use outside this method
		///      myatts = new AttributeListImpl(atts);
		///      [...]
		///    }
		///    </pre></para><para>Please note that SAX parsers are not required to use this class to provide an implementation of AttributeList; it is supplied only as an optional convenience. In particular, parser writers are encouraged to invent more efficient implementations.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>This class implements a deprecated interface, AttributeList; that interface has been replaced by Attributes, which is implemented in the AttributesImpl helper class. </para></xrefdescription></xrefsect><para>SAX 1.0 </para><para>David Megginson </para><para>2.0.1 (sax2r2) </para><para>org.xml.sax.AttributeList </para><simplesectsep></simplesectsep><para>org.xml.sax.DocumentHandler::startElement </para></para>    
		/// </summary>
		/// <java-name>
		/// org/xml/sax/helpers/AttributeListImpl
		/// </java-name>
		[Dot42.DexImport("org/xml/sax/helpers/AttributeListImpl", AccessFlags = 33)]
		public partial class AttributeListImpl : global::Org.Xml.Sax.IAttributeList
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Create an empty attribute list.</para><para>This constructor is most useful for parser writers, who will use it to create a single, reusable attribute list that can be reset with the clear method between elements.</para><para><para>addAttribute </para><simplesectsep></simplesectsep><para>clear </para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public AttributeListImpl() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Construct a persistent copy of an existing attribute list.</para><para>This constructor is most useful for application writers, who will use it to create a persistent copy of an existing attribute list.</para><para><para>org.xml.sax.DocumentHandler::startElement </para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Lorg/xml/sax/AttributeList;)V", AccessFlags = 1)]
				public AttributeListImpl(global::Org.Xml.Sax.IAttributeList atts) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Set the attribute list, discarding previous contents.</para><para>This method allows an application writer to reuse an attribute list easily.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setAttributeList
				/// </java-name>
				[Dot42.DexImport("setAttributeList", "(Lorg/xml/sax/AttributeList;)V", AccessFlags = 1)]
				public virtual void SetAttributeList(global::Org.Xml.Sax.IAttributeList atts) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Add an attribute to an attribute list.</para><para>This method is provided for SAX parser writers, to allow them to build up an attribute list incrementally before delivering it to the application.</para><para><para>removeAttribute </para><simplesectsep></simplesectsep><para>org.xml.sax.DocumentHandler::startElement </para></para>        
				/// </summary>
				/// <java-name>
				/// addAttribute
				/// </java-name>
				[Dot42.DexImport("addAttribute", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void AddAttribute(string name, string type, string value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Remove an attribute from the list.</para><para>SAX application writers can use this method to filter an attribute out of an AttributeList. Note that invoking this method will change the length of the attribute list and some of the attribute's indices.</para><para>If the requested attribute is not in the list, this is a no-op.</para><para><para>addAttribute </para></para>        
				/// </summary>
				/// <java-name>
				/// removeAttribute
				/// </java-name>
				[Dot42.DexImport("removeAttribute", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void RemoveAttribute(string name) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Clear the attribute list.</para><para>SAX parser writers can use this method to reset the attribute list between DocumentHandler.startElement events. Normally, it will make sense to reuse the same AttributeListImpl object rather than allocating a new one each time.</para><para><para>org.xml.sax.DocumentHandler::startElement </para></para>        
				/// </summary>
				/// <java-name>
				/// clear
				/// </java-name>
				[Dot42.DexImport("clear", "()V", AccessFlags = 1)]
				public virtual void Clear() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Return the number of attributes in the list.</para><para><para>org.xml.sax.AttributeList::getLength </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The number of attributes in the list. </para>
				/// </returns>
				/// <java-name>
				/// getLength
				/// </java-name>
				[Dot42.DexImport("getLength", "()I", AccessFlags = 1)]
				public virtual int GetLength() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Get the name of an attribute (by position).</para><para><para>org.xml.sax.AttributeList::getName(int) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The attribute name as a string, or null if there is no attribute at that position. </para>
				/// </returns>
				/// <java-name>
				/// getName
				/// </java-name>
				[Dot42.DexImport("getName", "(I)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetName(int i) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Get the type of an attribute (by position).</para><para><para>org.xml.sax.AttributeList::getType(int) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The attribute type as a string ("NMTOKEN" for an enumeration, and "CDATA" if no declaration was read), or null if there is no attribute at that position. </para>
				/// </returns>
				/// <java-name>
				/// getType
				/// </java-name>
				[Dot42.DexImport("getType", "(I)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetType(int i) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Get the value of an attribute (by position).</para><para><para>org.xml.sax.AttributeList::getValue(int) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The attribute value as a string, or null if there is no attribute at that position. </para>
				/// </returns>
				/// <java-name>
				/// getValue
				/// </java-name>
				[Dot42.DexImport("getValue", "(I)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetValue(int i) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Get the type of an attribute (by position).</para><para><para>org.xml.sax.AttributeList::getType(int) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The attribute type as a string ("NMTOKEN" for an enumeration, and "CDATA" if no declaration was read), or null if there is no attribute at that position. </para>
				/// </returns>
				/// <java-name>
				/// getType
				/// </java-name>
				[Dot42.DexImport("getType", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetType(string i) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Get the value of an attribute (by position).</para><para><para>org.xml.sax.AttributeList::getValue(int) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The attribute value as a string, or null if there is no attribute at that position. </para>
				/// </returns>
				/// <java-name>
				/// getValue
				/// </java-name>
				[Dot42.DexImport("getValue", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetValue(string i) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Return the number of attributes in the list.</para><para><para>org.xml.sax.AttributeList::getLength </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The number of attributes in the list. </para>
				/// </returns>
				/// <java-name>
				/// getLength
				/// </java-name>
				public int Length
				{
				[Dot42.DexImport("getLength", "()I", AccessFlags = 1)]
						get{ return GetLength(); }
				}

		}

		/// <summary>
		/// <para>Adapt a SAX1 Parser as a SAX2 XMLReader.</para><para><blockquote><para><b>This module, both source code and documentation, is in the Public Domain, and comes with <b>NO WARRANTY</b>.</b> See  for further information. </para></blockquote></para><para>This class wraps a SAX1 Parser and makes it act as a SAX2 XMLReader, with feature, property, and Namespace support. Note that it is not possible to report skippedEntity events, since SAX1 does not make that information available.</para><para>This adapter does not test for duplicate Namespace-qualified attribute names.</para><para><para>SAX 2.0 </para><para>David Megginson </para><para>2.0.1 (sax2r2) </para><para>org.xml.sax.helpers.XMLReaderAdapter </para><simplesectsep></simplesectsep><para>org.xml.sax.XMLReader </para><simplesectsep></simplesectsep><para>org.xml.sax.Parser </para></para>    
		/// </summary>
		/// <java-name>
		/// org/xml/sax/helpers/ParserAdapter
		/// </java-name>
		[Dot42.DexImport("org/xml/sax/helpers/ParserAdapter", AccessFlags = 33)]
		public partial class ParserAdapter : global::Org.Xml.Sax.IXMLReader, global::Org.Xml.Sax.IDocumentHandler
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Construct a new parser adapter.</para><para>Use the "org.xml.sax.parser" property to locate the embedded SAX1 driver.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ParserAdapter() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Construct a new parser adapter.</para><para>Note that the embedded parser cannot be changed once the adapter is created; to embed a different parser, allocate a new ParserAdapter.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Lorg/xml/sax/Parser;)V", AccessFlags = 1)]
				public ParserAdapter(global::Org.Xml.Sax.IParser parser) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Set a feature flag for the parser.</para><para>The only features recognized are namespaces and namespace-prefixes.</para><para><para>org.xml.sax.XMLReader::setFeature </para></para>        
				/// </summary>
				/// <java-name>
				/// setFeature
				/// </java-name>
				[Dot42.DexImport("setFeature", "(Ljava/lang/String;Z)V", AccessFlags = 1)]
				public virtual void SetFeature(string name, bool value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Check a parser feature flag.</para><para>The only features recognized are namespaces and namespace-prefixes.</para><para><para>org.xml.sax.XMLReader::setFeature </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The current feature value. </para>
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
				/// <para>Set a parser property.</para><para>No properties are currently recognized.</para><para><para>org.xml.sax.XMLReader::setProperty </para></para>        
				/// </summary>
				/// <java-name>
				/// setProperty
				/// </java-name>
				[Dot42.DexImport("setProperty", "(Ljava/lang/String;Ljava/lang/Object;)V", AccessFlags = 1)]
				public virtual void SetProperty(string name, object value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Get a parser property.</para><para>No properties are currently recognized.</para><para><para>org.xml.sax.XMLReader::getProperty </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The property value. </para>
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
				/// <para>Set the entity resolver.</para><para><para>org.xml.sax.XMLReader::setEntityResolver </para></para>        
				/// </summary>
				/// <java-name>
				/// setEntityResolver
				/// </java-name>
				[Dot42.DexImport("setEntityResolver", "(Lorg/xml/sax/EntityResolver;)V", AccessFlags = 1)]
				public virtual void SetEntityResolver(global::Org.Xml.Sax.IEntityResolver resolver) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Return the current entity resolver.</para><para><para>org.xml.sax.XMLReader::getEntityResolver </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The current entity resolver, or null if none was supplied. </para>
				/// </returns>
				/// <java-name>
				/// getEntityResolver
				/// </java-name>
				[Dot42.DexImport("getEntityResolver", "()Lorg/xml/sax/EntityResolver;", AccessFlags = 1)]
				public virtual global::Org.Xml.Sax.IEntityResolver GetEntityResolver() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Xml.Sax.IEntityResolver);
				}

				/// <summary>
				/// <para>Set the DTD handler.</para><para><para>org.xml.sax.XMLReader::setEntityResolver </para></para>        
				/// </summary>
				/// <java-name>
				/// setDTDHandler
				/// </java-name>
				[Dot42.DexImport("setDTDHandler", "(Lorg/xml/sax/DTDHandler;)V", AccessFlags = 1)]
				public virtual void SetDTDHandler(global::Org.Xml.Sax.IDTDHandler handler) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Return the current DTD handler.</para><para><para>org.xml.sax.XMLReader::getEntityResolver </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the current DTD handler, or null if none was supplied </para>
				/// </returns>
				/// <java-name>
				/// getDTDHandler
				/// </java-name>
				[Dot42.DexImport("getDTDHandler", "()Lorg/xml/sax/DTDHandler;", AccessFlags = 1)]
				public virtual global::Org.Xml.Sax.IDTDHandler GetDTDHandler() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Xml.Sax.IDTDHandler);
				}

				/// <summary>
				/// <para>Set the content handler.</para><para><para>org.xml.sax.XMLReader::setEntityResolver </para></para>        
				/// </summary>
				/// <java-name>
				/// setContentHandler
				/// </java-name>
				[Dot42.DexImport("setContentHandler", "(Lorg/xml/sax/ContentHandler;)V", AccessFlags = 1)]
				public virtual void SetContentHandler(global::Org.Xml.Sax.IContentHandler handler) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Return the current content handler.</para><para><para>org.xml.sax.XMLReader::getEntityResolver </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The current content handler, or null if none was supplied. </para>
				/// </returns>
				/// <java-name>
				/// getContentHandler
				/// </java-name>
				[Dot42.DexImport("getContentHandler", "()Lorg/xml/sax/ContentHandler;", AccessFlags = 1)]
				public virtual global::Org.Xml.Sax.IContentHandler GetContentHandler() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Xml.Sax.IContentHandler);
				}

				/// <summary>
				/// <para>Set the error handler.</para><para><para>org.xml.sax.XMLReader::setEntityResolver </para></para>        
				/// </summary>
				/// <java-name>
				/// setErrorHandler
				/// </java-name>
				[Dot42.DexImport("setErrorHandler", "(Lorg/xml/sax/ErrorHandler;)V", AccessFlags = 1)]
				public virtual void SetErrorHandler(global::Org.Xml.Sax.IErrorHandler handler) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Return the current error handler.</para><para><para>org.xml.sax.XMLReader::getEntityResolver </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The current error handler, or null if none was supplied. </para>
				/// </returns>
				/// <java-name>
				/// getErrorHandler
				/// </java-name>
				[Dot42.DexImport("getErrorHandler", "()Lorg/xml/sax/ErrorHandler;", AccessFlags = 1)]
				public virtual global::Org.Xml.Sax.IErrorHandler GetErrorHandler() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Xml.Sax.IErrorHandler);
				}

				/// <summary>
				/// <para>Parse an XML document.</para><para><para>parse(java.lang.String) </para><simplesectsep></simplesectsep><para>org.xml.sax.Parser::parse(org.xml.sax.InputSource) </para></para>        
				/// </summary>
				/// <java-name>
				/// parse
				/// </java-name>
				[Dot42.DexImport("parse", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void Parse(string input) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Parse an XML document.</para><para><para>parse(java.lang.String) </para><simplesectsep></simplesectsep><para>org.xml.sax.Parser::parse(org.xml.sax.InputSource) </para></para>        
				/// </summary>
				/// <java-name>
				/// parse
				/// </java-name>
				[Dot42.DexImport("parse", "(Lorg/xml/sax/InputSource;)V", AccessFlags = 1)]
				public virtual void Parse(global::Org.Xml.Sax.InputSource input) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Adapter implementation method; do not call. Adapt a SAX1 document locator event.</para><para><para>org.xml.sax.ContentHandler::setDocumentLocator </para></para>        
				/// </summary>
				/// <java-name>
				/// setDocumentLocator
				/// </java-name>
				[Dot42.DexImport("setDocumentLocator", "(Lorg/xml/sax/Locator;)V", AccessFlags = 1)]
				public virtual void SetDocumentLocator(global::Org.Xml.Sax.ILocator locator) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Adapter implementation method; do not call. Adapt a SAX1 start document event.</para><para><para>org.xml.sax.DocumentHandler::startDocument </para></para>        
				/// </summary>
				/// <java-name>
				/// startDocument
				/// </java-name>
				[Dot42.DexImport("startDocument", "()V", AccessFlags = 1)]
				public virtual void StartDocument() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Adapter implementation method; do not call. Adapt a SAX1 end document event.</para><para><para>org.xml.sax.DocumentHandler::endDocument </para></para>        
				/// </summary>
				/// <java-name>
				/// endDocument
				/// </java-name>
				[Dot42.DexImport("endDocument", "()V", AccessFlags = 1)]
				public virtual void EndDocument() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Adapter implementation method; do not call. Adapt a SAX1 startElement event.</para><para>If necessary, perform Namespace processing.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// startElement
				/// </java-name>
				[Dot42.DexImport("startElement", "(Ljava/lang/String;Lorg/xml/sax/AttributeList;)V", AccessFlags = 1)]
				public virtual void StartElement(string qName, global::Org.Xml.Sax.IAttributeList qAtts) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Adapter implementation method; do not call. Adapt a SAX1 end element event.</para><para><para>org.xml.sax.DocumentHandler::endElement </para></para>        
				/// </summary>
				/// <java-name>
				/// endElement
				/// </java-name>
				[Dot42.DexImport("endElement", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void EndElement(string qName) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Adapter implementation method; do not call. Adapt a SAX1 characters event.</para><para><para>org.xml.sax.DocumentHandler::characters </para></para>        
				/// </summary>
				/// <java-name>
				/// characters
				/// </java-name>
				[Dot42.DexImport("characters", "([CII)V", AccessFlags = 1)]
				public virtual void Characters(char[] ch, int start, int length) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Adapter implementation method; do not call. Adapt a SAX1 ignorable whitespace event.</para><para><para>org.xml.sax.DocumentHandler::ignorableWhitespace </para></para>        
				/// </summary>
				/// <java-name>
				/// ignorableWhitespace
				/// </java-name>
				[Dot42.DexImport("ignorableWhitespace", "([CII)V", AccessFlags = 1)]
				public virtual void IgnorableWhitespace(char[] ch, int start, int length) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Adapter implementation method; do not call. Adapt a SAX1 processing instruction event.</para><para><para>org.xml.sax.DocumentHandler::processingInstruction </para></para>        
				/// </summary>
				/// <java-name>
				/// processingInstruction
				/// </java-name>
				[Dot42.DexImport("processingInstruction", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void ProcessingInstruction(string target, string data) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Return the current entity resolver.</para><para><para>org.xml.sax.XMLReader::getEntityResolver </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The current entity resolver, or null if none was supplied. </para>
				/// </returns>
				/// <java-name>
				/// getEntityResolver
				/// </java-name>
				public global::Org.Xml.Sax.IEntityResolver EntityResolver
				{
				[Dot42.DexImport("getEntityResolver", "()Lorg/xml/sax/EntityResolver;", AccessFlags = 1)]
						get{ return GetEntityResolver(); }
				[Dot42.DexImport("setEntityResolver", "(Lorg/xml/sax/EntityResolver;)V", AccessFlags = 1)]
						set{ SetEntityResolver(value); }
				}

				/// <summary>
				/// <para>Return the current DTD handler.</para><para><para>org.xml.sax.XMLReader::getEntityResolver </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the current DTD handler, or null if none was supplied </para>
				/// </returns>
				/// <java-name>
				/// getDTDHandler
				/// </java-name>
				public global::Org.Xml.Sax.IDTDHandler DTDHandler
				{
				[Dot42.DexImport("getDTDHandler", "()Lorg/xml/sax/DTDHandler;", AccessFlags = 1)]
						get{ return GetDTDHandler(); }
				[Dot42.DexImport("setDTDHandler", "(Lorg/xml/sax/DTDHandler;)V", AccessFlags = 1)]
						set{ SetDTDHandler(value); }
				}

				/// <summary>
				/// <para>Return the current content handler.</para><para><para>org.xml.sax.XMLReader::getEntityResolver </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The current content handler, or null if none was supplied. </para>
				/// </returns>
				/// <java-name>
				/// getContentHandler
				/// </java-name>
				public global::Org.Xml.Sax.IContentHandler ContentHandler
				{
				[Dot42.DexImport("getContentHandler", "()Lorg/xml/sax/ContentHandler;", AccessFlags = 1)]
						get{ return GetContentHandler(); }
				[Dot42.DexImport("setContentHandler", "(Lorg/xml/sax/ContentHandler;)V", AccessFlags = 1)]
						set{ SetContentHandler(value); }
				}

				/// <summary>
				/// <para>Return the current error handler.</para><para><para>org.xml.sax.XMLReader::getEntityResolver </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The current error handler, or null if none was supplied. </para>
				/// </returns>
				/// <java-name>
				/// getErrorHandler
				/// </java-name>
				public global::Org.Xml.Sax.IErrorHandler ErrorHandler
				{
				[Dot42.DexImport("getErrorHandler", "()Lorg/xml/sax/ErrorHandler;", AccessFlags = 1)]
						get{ return GetErrorHandler(); }
				[Dot42.DexImport("setErrorHandler", "(Lorg/xml/sax/ErrorHandler;)V", AccessFlags = 1)]
						set{ SetErrorHandler(value); }
				}

		}

		/// <summary>
		/// <para>Adapt a SAX2 XMLReader as a SAX1 Parser.</para><para><blockquote><para><b>This module, both source code and documentation, is in the Public Domain, and comes with <b>NO WARRANTY</b>.</b> See  for further information. </para></blockquote></para><para>This class wraps a SAX2 XMLReader and makes it act as a SAX1 Parser. The XMLReader must support a true value for the  property or parsing will fail with a SAXException; if the XMLReader supports a false value for the  property, that will also be used to improve efficiency.</para><para><para>SAX 2.0 </para><para>David Megginson </para><para>2.0.1 (sax2r2) </para><para>org.xml.sax.Parser </para><simplesectsep></simplesectsep><para>org.xml.sax.XMLReader </para></para>    
		/// </summary>
		/// <java-name>
		/// org/xml/sax/helpers/XMLReaderAdapter
		/// </java-name>
		[Dot42.DexImport("org/xml/sax/helpers/XMLReaderAdapter", AccessFlags = 33)]
		public partial class XMLReaderAdapter : global::Org.Xml.Sax.IParser, global::Org.Xml.Sax.IContentHandler
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Create a new adapter.</para><para>Use the "org.xml.sax.driver" property to locate the SAX2 driver to embed.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public XMLReaderAdapter() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Create a new adapter.</para><para>Create a new adapter, wrapped around a SAX2 XMLReader. The adapter will make the XMLReader act like a SAX1 Parser.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Lorg/xml/sax/XMLReader;)V", AccessFlags = 1)]
				public XMLReaderAdapter(global::Org.Xml.Sax.IXMLReader xmlReader) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Set the locale for error reporting.</para><para>This is not supported in SAX2, and will always throw an exception.</para><para><para>org.xml.sax.Parser::setLocale </para></para>        
				/// </summary>
				/// <java-name>
				/// setLocale
				/// </java-name>
				[Dot42.DexImport("setLocale", "(Ljava/util/Locale;)V", AccessFlags = 1)]
				public virtual void SetLocale(global::Java.Util.Locale locale) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Register the entity resolver.</para><para><para>org.xml.sax.Parser::setEntityResolver </para></para>        
				/// </summary>
				/// <java-name>
				/// setEntityResolver
				/// </java-name>
				[Dot42.DexImport("setEntityResolver", "(Lorg/xml/sax/EntityResolver;)V", AccessFlags = 1)]
				public virtual void SetEntityResolver(global::Org.Xml.Sax.IEntityResolver resolver) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Register the DTD event handler.</para><para><para>org.xml.sax.Parser::setDTDHandler </para></para>        
				/// </summary>
				/// <java-name>
				/// setDTDHandler
				/// </java-name>
				[Dot42.DexImport("setDTDHandler", "(Lorg/xml/sax/DTDHandler;)V", AccessFlags = 1)]
				public virtual void SetDTDHandler(global::Org.Xml.Sax.IDTDHandler handler) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Register the SAX1 document event handler.</para><para>Note that the SAX1 document handler has no Namespace support.</para><para><para>org.xml.sax.Parser::setDocumentHandler </para></para>        
				/// </summary>
				/// <java-name>
				/// setDocumentHandler
				/// </java-name>
				[Dot42.DexImport("setDocumentHandler", "(Lorg/xml/sax/DocumentHandler;)V", AccessFlags = 1)]
				public virtual void SetDocumentHandler(global::Org.Xml.Sax.IDocumentHandler handler) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Register the error event handler.</para><para><para>org.xml.sax.Parser::setErrorHandler </para></para>        
				/// </summary>
				/// <java-name>
				/// setErrorHandler
				/// </java-name>
				[Dot42.DexImport("setErrorHandler", "(Lorg/xml/sax/ErrorHandler;)V", AccessFlags = 1)]
				public virtual void SetErrorHandler(global::Org.Xml.Sax.IErrorHandler handler) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Parse the document.</para><para>This method will throw an exception if the embedded XMLReader does not support the  property.</para><para><para>parse(java.lang.String) </para><simplesectsep></simplesectsep><para>org.xml.sax.Parser::parse(org.xml.sax.InputSource) </para></para>        
				/// </summary>
				/// <java-name>
				/// parse
				/// </java-name>
				[Dot42.DexImport("parse", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void Parse(string input) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Parse the document.</para><para>This method will throw an exception if the embedded XMLReader does not support the  property.</para><para><para>parse(java.lang.String) </para><simplesectsep></simplesectsep><para>org.xml.sax.Parser::parse(org.xml.sax.InputSource) </para></para>        
				/// </summary>
				/// <java-name>
				/// parse
				/// </java-name>
				[Dot42.DexImport("parse", "(Lorg/xml/sax/InputSource;)V", AccessFlags = 1)]
				public virtual void Parse(global::Org.Xml.Sax.InputSource input) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Set a document locator.</para><para><para>org.xml.sax.ContentHandler::setDocumentLocator </para></para>        
				/// </summary>
				/// <java-name>
				/// setDocumentLocator
				/// </java-name>
				[Dot42.DexImport("setDocumentLocator", "(Lorg/xml/sax/Locator;)V", AccessFlags = 1)]
				public virtual void SetDocumentLocator(global::Org.Xml.Sax.ILocator locator) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Start document event.</para><para><para>org.xml.sax.ContentHandler::startDocument </para></para>        
				/// </summary>
				/// <java-name>
				/// startDocument
				/// </java-name>
				[Dot42.DexImport("startDocument", "()V", AccessFlags = 1)]
				public virtual void StartDocument() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>End document event.</para><para><para>org.xml.sax.ContentHandler::endDocument </para></para>        
				/// </summary>
				/// <java-name>
				/// endDocument
				/// </java-name>
				[Dot42.DexImport("endDocument", "()V", AccessFlags = 1)]
				public virtual void EndDocument() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Adapt a SAX2 start prefix mapping event.</para><para><para>org.xml.sax.ContentHandler::startPrefixMapping </para></para>        
				/// </summary>
				/// <java-name>
				/// startPrefixMapping
				/// </java-name>
				[Dot42.DexImport("startPrefixMapping", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void StartPrefixMapping(string prefix, string uri) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Adapt a SAX2 end prefix mapping event.</para><para><para>org.xml.sax.ContentHandler::endPrefixMapping </para></para>        
				/// </summary>
				/// <java-name>
				/// endPrefixMapping
				/// </java-name>
				[Dot42.DexImport("endPrefixMapping", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void EndPrefixMapping(string prefix) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Adapt a SAX2 start element event.</para><para><para>org.xml.sax.ContentHandler::endDocument </para></para>        
				/// </summary>
				/// <java-name>
				/// startElement
				/// </java-name>
				[Dot42.DexImport("startElement", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lorg/xml/sax/Attributes;)V" +
    "", AccessFlags = 1)]
				public virtual void StartElement(string uri, string localName, string qName, global::Org.Xml.Sax.IAttributes atts) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Adapt a SAX2 end element event.</para><para><para>org.xml.sax.ContentHandler::endElement </para></para>        
				/// </summary>
				/// <java-name>
				/// endElement
				/// </java-name>
				[Dot42.DexImport("endElement", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void EndElement(string uri, string localName, string qName) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Adapt a SAX2 characters event.</para><para><para>org.xml.sax.ContentHandler::characters </para></para>        
				/// </summary>
				/// <java-name>
				/// characters
				/// </java-name>
				[Dot42.DexImport("characters", "([CII)V", AccessFlags = 1)]
				public virtual void Characters(char[] ch, int start, int length) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Adapt a SAX2 ignorable whitespace event.</para><para><para>org.xml.sax.ContentHandler::ignorableWhitespace </para></para>        
				/// </summary>
				/// <java-name>
				/// ignorableWhitespace
				/// </java-name>
				[Dot42.DexImport("ignorableWhitespace", "([CII)V", AccessFlags = 1)]
				public virtual void IgnorableWhitespace(char[] ch, int start, int length) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Adapt a SAX2 processing instruction event.</para><para><para>org.xml.sax.ContentHandler::processingInstruction </para></para>        
				/// </summary>
				/// <java-name>
				/// processingInstruction
				/// </java-name>
				[Dot42.DexImport("processingInstruction", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void ProcessingInstruction(string target, string data) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Adapt a SAX2 skipped entity event.</para><para><para>org.xml.sax.ContentHandler::skippedEntity </para></para>        
				/// </summary>
				/// <java-name>
				/// skippedEntity
				/// </java-name>
				[Dot42.DexImport("skippedEntity", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SkippedEntity(string name) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>Provide an optional convenience implementation of Locator.</para><para><blockquote><para><b>This module, both source code and documentation, is in the Public Domain, and comes with <b>NO WARRANTY</b>.</b> See  for further information. </para></blockquote></para><para>This class is available mainly for application writers, who can use it to make a persistent snapshot of a locator at any point during a document parse:</para><para><pre>
		///    Locator locator;
		///    Locator startloc;
		/// 
		///    public void setLocator (Locator locator)
		///    {
		///            // note the locator
		///      this.locator = locator;
		///    }
		/// 
		///    public void startDocument ()
		///    {
		///            // save the location of the start of the document
		///            // for future use.
		///      Locator startloc = new LocatorImpl(locator);
		///    }
		///   </pre></para><para>Normally, parser writers will not use this class, since it is more efficient to provide location information only when requested, rather than constantly updating a Locator object.</para><para><para>SAX 1.0 </para><para>David Megginson </para><para>2.0.1 (sax2r2) </para><para>org.xml.sax.Locator Locator </para></para>    
		/// </summary>
		/// <java-name>
		/// org/xml/sax/helpers/LocatorImpl
		/// </java-name>
		[Dot42.DexImport("org/xml/sax/helpers/LocatorImpl", AccessFlags = 33)]
		public partial class LocatorImpl : global::Org.Xml.Sax.ILocator
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Zero-argument constructor.</para><para>This will not normally be useful, since the main purpose of this class is to make a snapshot of an existing Locator.</para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public LocatorImpl() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Copy constructor.</para><para>Create a persistent copy of the current state of a locator. When the original locator changes, this copy will still keep the original values (and it can be used outside the scope of DocumentHandler methods).</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Lorg/xml/sax/Locator;)V", AccessFlags = 1)]
				public LocatorImpl(global::Org.Xml.Sax.ILocator locator) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Return the saved public identifier.</para><para><para>org.xml.sax.Locator::getPublicId </para><simplesectsep></simplesectsep><para>setPublicId </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The public identifier as a string, or null if none is available. </para>
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
				/// <para>Return the saved system identifier.</para><para><para>org.xml.sax.Locator::getSystemId </para><simplesectsep></simplesectsep><para>setSystemId </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The system identifier as a string, or null if none is available. </para>
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
				/// <para>Return the saved line number (1-based).</para><para><para>org.xml.sax.Locator::getLineNumber </para><simplesectsep></simplesectsep><para>setLineNumber </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The line number as an integer, or -1 if none is available. </para>
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
				/// <para>Return the saved column number (1-based).</para><para><para>org.xml.sax.Locator::getColumnNumber </para><simplesectsep></simplesectsep><para>setColumnNumber </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The column number as an integer, or -1 if none is available. </para>
				/// </returns>
				/// <java-name>
				/// getColumnNumber
				/// </java-name>
				[Dot42.DexImport("getColumnNumber", "()I", AccessFlags = 1)]
				public virtual int GetColumnNumber() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Set the public identifier for this locator.</para><para><para>getPublicId </para></para>        
				/// </summary>
				/// <java-name>
				/// setPublicId
				/// </java-name>
				[Dot42.DexImport("setPublicId", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetPublicId(string publicId) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Set the system identifier for this locator.</para><para><para>getSystemId </para></para>        
				/// </summary>
				/// <java-name>
				/// setSystemId
				/// </java-name>
				[Dot42.DexImport("setSystemId", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetSystemId(string systemId) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Set the line number for this locator (1-based).</para><para><para>getLineNumber </para></para>        
				/// </summary>
				/// <java-name>
				/// setLineNumber
				/// </java-name>
				[Dot42.DexImport("setLineNumber", "(I)V", AccessFlags = 1)]
				public virtual void SetLineNumber(int lineNumber) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Set the column number for this locator (1-based).</para><para><para>getColumnNumber </para></para>        
				/// </summary>
				/// <java-name>
				/// setColumnNumber
				/// </java-name>
				[Dot42.DexImport("setColumnNumber", "(I)V", AccessFlags = 1)]
				public virtual void SetColumnNumber(int columnNumber) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Return the saved public identifier.</para><para><para>org.xml.sax.Locator::getPublicId </para><simplesectsep></simplesectsep><para>setPublicId </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The public identifier as a string, or null if none is available. </para>
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
				/// <para>Return the saved system identifier.</para><para><para>org.xml.sax.Locator::getSystemId </para><simplesectsep></simplesectsep><para>setSystemId </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The system identifier as a string, or null if none is available. </para>
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
				/// <para>Return the saved line number (1-based).</para><para><para>org.xml.sax.Locator::getLineNumber </para><simplesectsep></simplesectsep><para>setLineNumber </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The line number as an integer, or -1 if none is available. </para>
				/// </returns>
				/// <java-name>
				/// getLineNumber
				/// </java-name>
				public int LineNumber
				{
				[Dot42.DexImport("getLineNumber", "()I", AccessFlags = 1)]
						get{ return GetLineNumber(); }
				[Dot42.DexImport("setLineNumber", "(I)V", AccessFlags = 1)]
						set{ SetLineNumber(value); }
				}

				/// <summary>
				/// <para>Return the saved column number (1-based).</para><para><para>org.xml.sax.Locator::getColumnNumber </para><simplesectsep></simplesectsep><para>setColumnNumber </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The column number as an integer, or -1 if none is available. </para>
				/// </returns>
				/// <java-name>
				/// getColumnNumber
				/// </java-name>
				public int ColumnNumber
				{
				[Dot42.DexImport("getColumnNumber", "()I", AccessFlags = 1)]
						get{ return GetColumnNumber(); }
				[Dot42.DexImport("setColumnNumber", "(I)V", AccessFlags = 1)]
						set{ SetColumnNumber(value); }
				}

		}

		/// <summary>
		/// <para>Java-specific class for dynamically loading SAX parsers.</para><para><blockquote><para><b>This module, both source code and documentation, is in the Public Domain, and comes with <b>NO WARRANTY</b>.</b> See  for further information. </para></blockquote></para><para><b>Note:</b> This class is designed to work with the now-deprecated SAX1 Parser class. SAX2 applications should use XMLReaderFactory instead.</para><para>ParserFactory is not part of the platform-independent definition of SAX; it is an additional convenience class designed specifically for Java XML application writers. SAX applications can use the static methods in this class to allocate a SAX parser dynamically at run-time based either on the value of the `org.xml.sax.parser' system property or on a string containing the class name.</para><para>Note that the application still requires an XML parser that implements SAX1.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>This class works with the deprecated Parser interface. </para></xrefdescription></xrefsect><para>SAX 1.0 </para><para>David Megginson </para><para>2.0.1 (sax2r2) </para></para>    
		/// </summary>
		/// <java-name>
		/// org/xml/sax/helpers/ParserFactory
		/// </java-name>
		[Dot42.DexImport("org/xml/sax/helpers/ParserFactory", AccessFlags = 33)]
		public partial class ParserFactory
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Private null constructor. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal ParserFactory() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Create a new SAX parser using the `org.xml.sax.parser' system property.</para><para>The named class must exist and must implement the Parser interface.</para><para><para>makeParser(java.lang.String) </para><simplesectsep></simplesectsep><para>org.xml.sax.Parser </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the newly created parser.</para>
				/// </returns>
				/// <java-name>
				/// makeParser
				/// </java-name>
				[Dot42.DexImport("makeParser", "()Lorg/xml/sax/Parser;", AccessFlags = 9)]
				public static global::Org.Xml.Sax.IParser MakeParser() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Xml.Sax.IParser);
				}

				/// <summary>
				/// <para>Create a new SAX parser object using the class name provided.</para><para>The named class must exist and must implement the Parser interface.</para><para><para>makeParser() </para><simplesectsep></simplesectsep><para>org.xml.sax.Parser </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the newly created parser.</para>
				/// </returns>
				/// <java-name>
				/// makeParser
				/// </java-name>
				[Dot42.DexImport("makeParser", "(Ljava/lang/String;)Lorg/xml/sax/Parser;", AccessFlags = 9)]
				public static global::Org.Xml.Sax.IParser MakeParser(string className) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Xml.Sax.IParser);
				}

		}

		/// <summary>
		/// <para>Default base class for SAX2 event handlers.</para><para><blockquote><para><b>This module, both source code and documentation, is in the Public Domain, and comes with <b>NO WARRANTY</b>.</b> See  for further information. </para></blockquote></para><para>This class is available as a convenience base class for SAX2 applications: it provides default implementations for all of the callbacks in the four core SAX2 handler classes:</para><para><ul><li><para>EntityResolver </para></li><li><para>DTDHandler </para></li><li><para>ContentHandler </para></li><li><para>ErrorHandler </para></li></ul></para><para>Application writers can extend this class when they need to implement only part of an interface; parser writers can instantiate this class to provide default handlers when the application has not supplied its own.</para><para>This class replaces the deprecated SAX1 HandlerBase class.</para><para><para>SAX 2.0 </para><para>David Megginson, </para><para>2.0.1 (sax2r2) </para><para>org.xml.sax.EntityResolver </para><simplesectsep></simplesectsep><para>org.xml.sax.DTDHandler </para><simplesectsep></simplesectsep><para>org.xml.sax.ContentHandler </para><simplesectsep></simplesectsep><para>org.xml.sax.ErrorHandler </para></para>    
		/// </summary>
		/// <java-name>
		/// org/xml/sax/helpers/DefaultHandler
		/// </java-name>
		[Dot42.DexImport("org/xml/sax/helpers/DefaultHandler", AccessFlags = 33)]
		public partial class DefaultHandler : global::Org.Xml.Sax.IEntityResolver, global::Org.Xml.Sax.IDTDHandler, global::Org.Xml.Sax.IContentHandler, global::Org.Xml.Sax.IErrorHandler
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public DefaultHandler() /* MethodBuilder.Create */ 
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
				/// <para>Receive a Locator object for document events.</para><para>By default, do nothing. Application writers may override this method in a subclass if they wish to store the locator for use with other document events.</para><para><para>org.xml.sax.ContentHandler::setDocumentLocator </para><simplesectsep></simplesectsep><para>org.xml.sax.Locator </para></para>        
				/// </summary>
				/// <java-name>
				/// setDocumentLocator
				/// </java-name>
				[Dot42.DexImport("setDocumentLocator", "(Lorg/xml/sax/Locator;)V", AccessFlags = 1)]
				public virtual void SetDocumentLocator(global::Org.Xml.Sax.ILocator locator) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Receive notification of the beginning of the document.</para><para>By default, do nothing. Application writers may override this method in a subclass to take specific actions at the beginning of a document (such as allocating the root node of a tree or creating an output file).</para><para><para>org.xml.sax.ContentHandler::startDocument </para></para>        
				/// </summary>
				/// <java-name>
				/// startDocument
				/// </java-name>
				[Dot42.DexImport("startDocument", "()V", AccessFlags = 1)]
				public virtual void StartDocument() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Receive notification of the end of the document.</para><para>By default, do nothing. Application writers may override this method in a subclass to take specific actions at the end of a document (such as finalising a tree or closing an output file).</para><para><para>org.xml.sax.ContentHandler::endDocument </para></para>        
				/// </summary>
				/// <java-name>
				/// endDocument
				/// </java-name>
				[Dot42.DexImport("endDocument", "()V", AccessFlags = 1)]
				public virtual void EndDocument() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Receive notification of the start of a Namespace mapping.</para><para>By default, do nothing. Application writers may override this method in a subclass to take specific actions at the start of each Namespace prefix scope (such as storing the prefix mapping).</para><para><para>org.xml.sax.ContentHandler::startPrefixMapping </para></para>        
				/// </summary>
				/// <java-name>
				/// startPrefixMapping
				/// </java-name>
				[Dot42.DexImport("startPrefixMapping", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void StartPrefixMapping(string prefix, string uri) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Receive notification of the end of a Namespace mapping.</para><para>By default, do nothing. Application writers may override this method in a subclass to take specific actions at the end of each prefix mapping.</para><para><para>org.xml.sax.ContentHandler::endPrefixMapping </para></para>        
				/// </summary>
				/// <java-name>
				/// endPrefixMapping
				/// </java-name>
				[Dot42.DexImport("endPrefixMapping", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void EndPrefixMapping(string prefix) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Receive notification of the start of an element.</para><para>By default, do nothing. Application writers may override this method in a subclass to take specific actions at the start of each element (such as allocating a new tree node or writing output to a file).</para><para><para>org.xml.sax.ContentHandler::startElement </para></para>        
				/// </summary>
				/// <java-name>
				/// startElement
				/// </java-name>
				[Dot42.DexImport("startElement", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lorg/xml/sax/Attributes;)V" +
    "", AccessFlags = 1)]
				public virtual void StartElement(string uri, string localName, string qName, global::Org.Xml.Sax.IAttributes attributes) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Receive notification of the end of an element.</para><para>By default, do nothing. Application writers may override this method in a subclass to take specific actions at the end of each element (such as finalising a tree node or writing output to a file).</para><para><para>org.xml.sax.ContentHandler::endElement </para></para>        
				/// </summary>
				/// <java-name>
				/// endElement
				/// </java-name>
				[Dot42.DexImport("endElement", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void EndElement(string uri, string localName, string qName) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Receive notification of character data inside an element.</para><para>By default, do nothing. Application writers may override this method to take specific actions for each chunk of character data (such as adding the data to a node or buffer, or printing it to a file).</para><para><para>org.xml.sax.ContentHandler::characters </para></para>        
				/// </summary>
				/// <java-name>
				/// characters
				/// </java-name>
				[Dot42.DexImport("characters", "([CII)V", AccessFlags = 1)]
				public virtual void Characters(char[] ch, int start, int length) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Receive notification of ignorable whitespace in element content.</para><para>By default, do nothing. Application writers may override this method to take specific actions for each chunk of ignorable whitespace (such as adding data to a node or buffer, or printing it to a file).</para><para><para>org.xml.sax.ContentHandler::ignorableWhitespace </para></para>        
				/// </summary>
				/// <java-name>
				/// ignorableWhitespace
				/// </java-name>
				[Dot42.DexImport("ignorableWhitespace", "([CII)V", AccessFlags = 1)]
				public virtual void IgnorableWhitespace(char[] ch, int start, int length) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Receive notification of a processing instruction.</para><para>By default, do nothing. Application writers may override this method in a subclass to take specific actions for each processing instruction, such as setting status variables or invoking other methods.</para><para><para>org.xml.sax.ContentHandler::processingInstruction </para></para>        
				/// </summary>
				/// <java-name>
				/// processingInstruction
				/// </java-name>
				[Dot42.DexImport("processingInstruction", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void ProcessingInstruction(string target, string data) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Receive notification of a skipped entity.</para><para>By default, do nothing. Application writers may override this method in a subclass to take specific actions for each processing instruction, such as setting status variables or invoking other methods.</para><para><para>org.xml.sax.ContentHandler::processingInstruction </para></para>        
				/// </summary>
				/// <java-name>
				/// skippedEntity
				/// </java-name>
				[Dot42.DexImport("skippedEntity", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SkippedEntity(string name) /* MethodBuilder.Create */ 
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

}


