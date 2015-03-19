// Copyright (C) 2014 dot42
//
// Original filename: Javax.Xml.Parsers.cs
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
namespace Javax.Xml.Parsers
{
		/// <summary>
		/// <para>Defines a factory API that enables applications to configure and obtain a SAX based parser to parse XML documents.</para><para><para> </para><para></para><title>Revision:</title><para>884950 </para>, <title>Date:</title><para>2009-11-27 10:46:18 -0800 (Fri, 27 Nov 2009) </para></para>    
		/// </summary>
		/// <java-name>
		/// javax/xml/parsers/SAXParserFactory
		/// </java-name>
		[Dot42.DexImport("javax/xml/parsers/SAXParserFactory", AccessFlags = 1057)]
		public abstract partial class SAXParserFactory
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Protected constructor to force use of newInstance().</para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal SAXParserFactory() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns Android's implementation of <c> SAXParserFactory </c> . Unlike other Java implementations, this method does not consult system properties, property files, or the services API.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a new SAXParserFactory.</para>
				/// </returns>
				/// <java-name>
				/// newInstance
				/// </java-name>
				[Dot42.DexImport("newInstance", "()Ljavax/xml/parsers/SAXParserFactory;", AccessFlags = 9)]
				public static global::Javax.Xml.Parsers.SAXParserFactory NewInstance() /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Xml.Parsers.SAXParserFactory);
				}

				/// <summary>
				/// <para>Returns an instance of the named implementation of <c> SAXParserFactory </c> .</para><para><para>1.6 </para></para>        
				/// </summary>
				/// <java-name>
				/// newInstance
				/// </java-name>
				[Dot42.DexImport("newInstance", "(Ljava/lang/String;Ljava/lang/ClassLoader;)Ljavax/xml/parsers/SAXParserFactory;", AccessFlags = 9)]
				public static global::Javax.Xml.Parsers.SAXParserFactory NewInstance(string factoryClassName, global::Java.Lang.ClassLoader classLoader) /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Xml.Parsers.SAXParserFactory);
				}

				/// <summary>
				/// <para>Creates a new instance of a SAXParser using the currently configured factory parameters.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>A new instance of a SAXParser.</para>
				/// </returns>
				/// <java-name>
				/// newSAXParser
				/// </java-name>
				[Dot42.DexImport("newSAXParser", "()Ljavax/xml/parsers/SAXParser;", AccessFlags = 1025)]
				public abstract global::Javax.Xml.Parsers.SAXParser NewSAXParser() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Specifies that the parser produced by this code will provide support for XML namespaces. By default the value of this is set to <code>false</code>.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setNamespaceAware
				/// </java-name>
				[Dot42.DexImport("setNamespaceAware", "(Z)V", AccessFlags = 1)]
				public virtual void SetNamespaceAware(bool awareness) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Specifies that the parser produced by this code will validate documents as they are parsed. By default the value of this is set to <code>false</code>.</para><para>Note that "the validation" here means  as defined in the XML recommendation. In other words, it essentially just controls the DTD validation. (except the legacy two properties defined in JAXP 1.2. See  for more details.) </para><para>To use modern schema languages such as W3C XML Schema or RELAX NG instead of DTD, you can configure your parser to be a non-validating parser by leaving the setValidating(boolean) method <code>false</code>, then use the setSchema(Schema) method to associate a schema to a parser. </para><para></para>        
				/// </summary>
				/// <java-name>
				/// setValidating
				/// </java-name>
				[Dot42.DexImport("setValidating", "(Z)V", AccessFlags = 1)]
				public virtual void SetValidating(bool validating) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Indicates whether or not the factory is configured to produce parsers which are namespace aware.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if the factory is configured to produce parsers which are namespace aware; false otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isNamespaceAware
				/// </java-name>
				[Dot42.DexImport("isNamespaceAware", "()Z", AccessFlags = 1)]
				public virtual bool IsNamespaceAware() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Indicates whether or not the factory is configured to produce parsers which validate the XML content during parse.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if the factory is configured to produce parsers which validate the XML content during parse; false otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isValidating
				/// </java-name>
				[Dot42.DexImport("isValidating", "()Z", AccessFlags = 1)]
				public virtual bool IsValidating() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Sets the particular feature in the underlying implementation of org.xml.sax.XMLReader. A list of the core features and properties can be found at </para><para>All implementations are required to support the javax.xml.XMLConstants#FEATURE_SECURE_PROCESSING feature. When the feature is</para><para><ul><li><para><code>true</code>: the implementation will limit XML processing to conform to implementation limits. Examples include entity expansion limits and XML Schema constructs that would consume large amounts of resources. If XML processing is limited for security reasons, it will be reported via a call to the registered org.xml.sax.ErrorHandler#fatalError(SAXParseException exception). See SAXParser <code>parse</code> methods for handler specification.  </para></li><li><para>When the feature is <code>false</code>, the implementation will processing XML according to the XML specifications without regard to possible implementation limits.  </para></li></ul></para><para><para>org.xml.sax.XMLReader::setFeature </para></para>        
				/// </summary>
				/// <java-name>
				/// setFeature
				/// </java-name>
				[Dot42.DexImport("setFeature", "(Ljava/lang/String;Z)V", AccessFlags = 1025)]
				public abstract void SetFeature(string name, bool value) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the particular property requested for in the underlying implementation of org.xml.sax.XMLReader.</para><para><para>org.xml.sax.XMLReader::getProperty </para></para>        
				/// </summary>
				/// <returns>
				/// <para>Value of the requested property.</para>
				/// </returns>
				/// <java-name>
				/// getFeature
				/// </java-name>
				[Dot42.DexImport("getFeature", "(Ljava/lang/String;)Z", AccessFlags = 1025)]
				public abstract bool GetFeature(string name) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Gets the Schema object specified through the setSchema(Schema schema) method.</para><para><para>1.5 </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the Schema object that was last set through the setSchema(Schema) method, or null if the method was not invoked since a SAXParserFactory is created.</para>
				/// </returns>
				/// <java-name>
				/// getSchema
				/// </java-name>
				[Dot42.DexImport("getSchema", "()Ljavax/xml/validation/Schema;", AccessFlags = 1)]
				public virtual global::Javax.Xml.Validation.Schema GetSchema() /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Xml.Validation.Schema);
				}

				/// <summary>
				/// <para>Set the Schema to be used by parsers created from this factory.</para><para>When a Schema is non-null, a parser will use a validator created from it to validate documents before it passes information down to the application.</para><para>When warnings/errors/fatal errors are found by the validator, the parser must handle them as if those errors were found by the parser itself. In other words, if the user-specified org.xml.sax.ErrorHandler is set, it must receive those errors, and if not, they must be treated according to the implementation specific default error handling rules.</para><para>A validator may modify the SAX event stream (for example by adding default values that were missing in documents), and a parser is responsible to make sure that the application will receive those modified event stream.</para><para>Initially, <code>null</code> is set as the Schema.</para><para>This processing will take effect even if the isValidating() method returns <code>false</code>.</para><para>It is an error to use the <code></code> property and/or the <code></code> property in conjunction with a non-null Schema object. Such configuration will cause a SAXException exception when those properties are set on a SAXParser.</para><para><h4>Note for implementors</h4></para><para>A parser must be able to work with any Schema implementation. However, parsers and schemas are allowed to use implementation-specific custom mechanisms as long as they yield the result described in the specification. </para><para><para>1.5 </para></para>        
				/// </summary>
				/// <java-name>
				/// setSchema
				/// </java-name>
				[Dot42.DexImport("setSchema", "(Ljavax/xml/validation/Schema;)V", AccessFlags = 1)]
				public virtual void SetSchema(global::Javax.Xml.Validation.Schema schema) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Set state of XInclude processing.</para><para>If XInclude markup is found in the document instance, should it be processed as specified in .</para><para>XInclude processing defaults to <code>false</code>.</para><para><para>1.5 </para></para>        
				/// </summary>
				/// <java-name>
				/// setXIncludeAware
				/// </java-name>
				[Dot42.DexImport("setXIncludeAware", "(Z)V", AccessFlags = 1)]
				public virtual void SetXIncludeAware(bool state) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Get state of XInclude processing.</para><para><para>1.5 </para></para>        
				/// </summary>
				/// <returns>
				/// <para>current state of XInclude processing</para>
				/// </returns>
				/// <java-name>
				/// isXIncludeAware
				/// </java-name>
				[Dot42.DexImport("isXIncludeAware", "()Z", AccessFlags = 1)]
				public virtual bool IsXIncludeAware() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Gets the Schema object specified through the setSchema(Schema schema) method.</para><para><para>1.5 </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the Schema object that was last set through the setSchema(Schema) method, or null if the method was not invoked since a SAXParserFactory is created.</para>
				/// </returns>
				/// <java-name>
				/// getSchema
				/// </java-name>
				public global::Javax.Xml.Validation.Schema Schema
				{
				[Dot42.DexImport("getSchema", "()Ljavax/xml/validation/Schema;", AccessFlags = 1)]
						get{ return GetSchema(); }
				[Dot42.DexImport("setSchema", "(Ljavax/xml/validation/Schema;)V", AccessFlags = 1)]
						set{ SetSchema(value); }
				}

		}

		/// <summary>
		/// <para>Thrown when a problem with configuration with the Parser Factories exists. This error will typically be thrown when the class of a parser factory specified in the system properties cannot be found or instantiated.</para><para><para> </para><para></para><title>Revision:</title><para>569980 </para>, <title>Date:</title><para>2007-08-26 20:58:15 -0700 (Sun, 26 Aug 2007) </para></para>    
		/// </summary>
		/// <java-name>
		/// javax/xml/parsers/FactoryConfigurationError
		/// </java-name>
		[Dot42.DexImport("javax/xml/parsers/FactoryConfigurationError", AccessFlags = 33)]
		public partial class FactoryConfigurationError : global::Java.Lang.Error
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Create a new <code>FactoryConfigurationError</code> with no detail message. </para>        
				/// </summary>
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

				/// <summary>
				/// <para>Create a new <code>FactoryConfigurationError</code> with the given <code>Exception</code> base cause and detail message.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/Exception;Ljava/lang/String;)V", AccessFlags = 1)]
				public FactoryConfigurationError(global::System.Exception e, string msg) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Return the message (if any) for this error . If there is no message for the exception and there is an encapsulated exception then the message of that exception, if it exists will be returned. Else the name of the encapsulated exception will be returned.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The error message. </para>
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
				/// <para>Return the actual exception (if any) that caused this exception to be raised.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The encapsulated exception, or null if there is none. </para>
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
				/// <para>Return the actual exception (if any) that caused this exception to be raised.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The encapsulated exception, or null if there is none. </para>
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
		/// <para>Defines a factory API that enables applications to obtain a parser that produces DOM object trees from XML documents.</para><para><para> </para><para></para><title>Revision:</title><para>884950 </para>, <title>Date:</title><para>2009-11-27 10:46:18 -0800 (Fri, 27 Nov 2009) </para></para>    
		/// </summary>
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

				/// <summary>
				/// <para>Returns Android's implementation of <c> DocumentBuilderFactory </c> . Unlike other Java implementations, this method does not consult system properties, property files, or the services API.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a new DocumentBuilderFactory. </para>
				/// </returns>
				/// <java-name>
				/// newInstance
				/// </java-name>
				[Dot42.DexImport("newInstance", "()Ljavax/xml/parsers/DocumentBuilderFactory;", AccessFlags = 9)]
				public static global::Javax.Xml.Parsers.DocumentBuilderFactory NewInstance() /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Xml.Parsers.DocumentBuilderFactory);
				}

				/// <summary>
				/// <para>Returns an instance of the named implementation of <c> DocumentBuilderFactory </c> .</para><para><para>1.6 </para></para>        
				/// </summary>
				/// <java-name>
				/// newInstance
				/// </java-name>
				[Dot42.DexImport("newInstance", "(Ljava/lang/String;Ljava/lang/ClassLoader;)Ljavax/xml/parsers/DocumentBuilderFact" +
    "ory;", AccessFlags = 9)]
				public static global::Javax.Xml.Parsers.DocumentBuilderFactory NewInstance(string factoryClassName, global::Java.Lang.ClassLoader classLoader) /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Xml.Parsers.DocumentBuilderFactory);
				}

				/// <summary>
				/// <para>Creates a new instance of a javax.xml.parsers.DocumentBuilder using the currently configured parameters.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>A new instance of a DocumentBuilder. </para>
				/// </returns>
				/// <java-name>
				/// newDocumentBuilder
				/// </java-name>
				[Dot42.DexImport("newDocumentBuilder", "()Ljavax/xml/parsers/DocumentBuilder;", AccessFlags = 1025)]
				public abstract global::Javax.Xml.Parsers.DocumentBuilder NewDocumentBuilder() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Specifies that the parser produced by this code will provide support for XML namespaces. By default the value of this is set to <code>false</code></para><para></para>        
				/// </summary>
				/// <java-name>
				/// setNamespaceAware
				/// </java-name>
				[Dot42.DexImport("setNamespaceAware", "(Z)V", AccessFlags = 1)]
				public virtual void SetNamespaceAware(bool awareness) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Specifies that the parser produced by this code will validate documents as they are parsed. By default the value of this is set to <code>false</code>.</para><para>Note that "the validation" here means  as defined in the XML recommendation. In other words, it essentially just controls the DTD validation. (except the legacy two properties defined in JAXP 1.2. See  for more details.) </para><para>To use modern schema languages such as W3C XML Schema or RELAX NG instead of DTD, you can configure your parser to be a non-validating parser by leaving the setValidating(boolean) method <code>false</code>, then use the setSchema(Schema) method to associate a schema to a parser. </para><para></para>        
				/// </summary>
				/// <java-name>
				/// setValidating
				/// </java-name>
				[Dot42.DexImport("setValidating", "(Z)V", AccessFlags = 1)]
				public virtual void SetValidating(bool validating) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Specifies that the parsers created by this factory must eliminate whitespace in element content (sometimes known loosely as 'ignorable whitespace') when parsing XML documents (see XML Rec 2.10). Note that only whitespace which is directly contained within element content that has an element only content model (see XML Rec 3.2.1) will be eliminated. Due to reliance on the content model this setting requires the parser to be in validating mode. By default the value of this is set to <code>false</code>.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setIgnoringElementContentWhitespace
				/// </java-name>
				[Dot42.DexImport("setIgnoringElementContentWhitespace", "(Z)V", AccessFlags = 1)]
				public virtual void SetIgnoringElementContentWhitespace(bool whitespace) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Specifies that the parser produced by this code will expand entity reference nodes. By default the value of this is set to <code>true</code></para><para></para>        
				/// </summary>
				/// <java-name>
				/// setExpandEntityReferences
				/// </java-name>
				[Dot42.DexImport("setExpandEntityReferences", "(Z)V", AccessFlags = 1)]
				public virtual void SetExpandEntityReferences(bool expandEntityRef) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Specifies that the parser produced by this code will ignore comments. By default the value of this is set to <code>false </code>.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setIgnoringComments
				/// </java-name>
				[Dot42.DexImport("setIgnoringComments", "(Z)V", AccessFlags = 1)]
				public virtual void SetIgnoringComments(bool ignoreComments) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Specifies that the parser produced by this code will convert CDATA nodes to Text nodes and append it to the adjacent (if any) text node. By default the value of this is set to <code>false</code></para><para></para>        
				/// </summary>
				/// <java-name>
				/// setCoalescing
				/// </java-name>
				[Dot42.DexImport("setCoalescing", "(Z)V", AccessFlags = 1)]
				public virtual void SetCoalescing(bool coalescing) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Indicates whether or not the factory is configured to produce parsers which are namespace aware.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if the factory is configured to produce parsers which are namespace aware; false otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isNamespaceAware
				/// </java-name>
				[Dot42.DexImport("isNamespaceAware", "()Z", AccessFlags = 1)]
				public virtual bool IsNamespaceAware() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Indicates whether or not the factory is configured to produce parsers which validate the XML content during parse.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if the factory is configured to produce parsers which validate the XML content during parse; false otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isValidating
				/// </java-name>
				[Dot42.DexImport("isValidating", "()Z", AccessFlags = 1)]
				public virtual bool IsValidating() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Indicates whether or not the factory is configured to produce parsers which ignore ignorable whitespace in element content.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if the factory is configured to produce parsers which ignore ignorable whitespace in element content; false otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isIgnoringElementContentWhitespace
				/// </java-name>
				[Dot42.DexImport("isIgnoringElementContentWhitespace", "()Z", AccessFlags = 1)]
				public virtual bool IsIgnoringElementContentWhitespace() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Indicates whether or not the factory is configured to produce parsers which expand entity reference nodes.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if the factory is configured to produce parsers which expand entity reference nodes; false otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isExpandEntityReferences
				/// </java-name>
				[Dot42.DexImport("isExpandEntityReferences", "()Z", AccessFlags = 1)]
				public virtual bool IsExpandEntityReferences() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Indicates whether or not the factory is configured to produce parsers which ignores comments.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if the factory is configured to produce parsers which ignores comments; false otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isIgnoringComments
				/// </java-name>
				[Dot42.DexImport("isIgnoringComments", "()Z", AccessFlags = 1)]
				public virtual bool IsIgnoringComments() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Indicates whether or not the factory is configured to produce parsers which converts CDATA nodes to Text nodes and appends it to the adjacent (if any) Text node.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if the factory is configured to produce parsers which converts CDATA nodes to Text nodes and appends it to the adjacent (if any) Text node; false otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isCoalescing
				/// </java-name>
				[Dot42.DexImport("isCoalescing", "()Z", AccessFlags = 1)]
				public virtual bool IsCoalescing() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Allows the user to set specific attributes on the underlying implementation. </para>        
				/// </summary>
				/// <java-name>
				/// setAttribute
				/// </java-name>
				[Dot42.DexImport("setAttribute", "(Ljava/lang/String;Ljava/lang/Object;)V", AccessFlags = 1025)]
				public abstract void SetAttribute(string name, object value) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Allows the user to retrieve specific attributes on the underlying implementation. </para>        
				/// </summary>
				/// <returns>
				/// <para>value The value of the attribute. </para>
				/// </returns>
				/// <java-name>
				/// getAttribute
				/// </java-name>
				[Dot42.DexImport("getAttribute", "(Ljava/lang/String;)Ljava/lang/Object;", AccessFlags = 1025)]
				public abstract object GetAttribute(string name) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Set a feature for this <code>DocumentBuilderFactory</code> and <code>DocumentBuilder</code>s created by this factory.</para><para>Feature names are fully qualified java.net.URIs. Implementations may define their own features. An ParserConfigurationException is thrown if this <code>DocumentBuilderFactory</code> or the <code>DocumentBuilder</code>s it creates cannot support the feature. It is possible for an <code>DocumentBuilderFactory</code> to expose a feature value but be unable to change its state. </para><para>All implementations are required to support the javax.xml.XMLConstants#FEATURE_SECURE_PROCESSING feature. When the feature is:</para><para><ul><li><para><code>true</code>: the implementation will limit XML processing to conform to implementation limits. Examples include entity expansion limits and XML Schema constructs that would consume large amounts of resources. If XML processing is limited for security reasons, it will be reported via a call to the registered org.xml.sax.ErrorHandler#fatalError(SAXParseException exception). See DocumentBuilder#setErrorHandler(org.xml.sax.ErrorHandler errorHandler).  </para></li><li><para><code>false</code>: the implementation will processing XML according to the XML specifications without regard to possible implementation limits.  </para></li></ul></para><para></para>        
				/// </summary>
				/// <java-name>
				/// setFeature
				/// </java-name>
				[Dot42.DexImport("setFeature", "(Ljava/lang/String;Z)V", AccessFlags = 1025)]
				public abstract void SetFeature(string name, bool value) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Get the state of the named feature.</para><para>Feature names are fully qualified java.net.URIs. Implementations may define their own features. An ParserConfigurationException is thrown if this <code>DocumentBuilderFactory</code> or the <code>DocumentBuilder</code>s it creates cannot support the feature. It is possible for an <code>DocumentBuilderFactory</code> to expose a feature value but be unable to change its state. </para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>State of the named feature.</para>
				/// </returns>
				/// <java-name>
				/// getFeature
				/// </java-name>
				[Dot42.DexImport("getFeature", "(Ljava/lang/String;)Z", AccessFlags = 1025)]
				public abstract bool GetFeature(string name) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Gets the Schema object specified through the setSchema(Schema schema) method.</para><para><para>1.5 </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the Schema object that was last set through the setSchema(Schema) method, or null if the method was not invoked since a DocumentBuilderFactory is created.</para>
				/// </returns>
				/// <java-name>
				/// getSchema
				/// </java-name>
				[Dot42.DexImport("getSchema", "()Ljavax/xml/validation/Schema;", AccessFlags = 1)]
				public virtual global::Javax.Xml.Validation.Schema GetSchema() /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Xml.Validation.Schema);
				}

				/// <summary>
				/// <para>Set the Schema to be used by parsers created from this factory.</para><para>When a Schema is non-null, a parser will use a validator created from it to validate documents before it passes information down to the application.</para><para>When errors are found by the validator, the parser is responsible to report them to the user-specified org.xml.sax.ErrorHandler (or if the error handler is not set, ignore them or throw them), just like any other errors found by the parser itself. In other words, if the user-specified org.xml.sax.ErrorHandler is set, it must receive those errors, and if not, they must be treated according to the implementation specific default error handling rules.</para><para>A validator may modify the outcome of a parse (for example by adding default values that were missing in documents), and a parser is responsible to make sure that the application will receive modified DOM trees.</para><para>Initially, null is set as the Schema.</para><para>This processing will take effect even if the isValidating() method returns <code>false</code>.</para><para>It is an error to use the <code></code> property and/or the <code></code> property in conjunction with a Schema object. Such configuration will cause a ParserConfigurationException exception when the newDocumentBuilder() is invoked.</para><para><h4>Note for implementors</h4></para><para>A parser must be able to work with any Schema implementation. However, parsers and schemas are allowed to use implementation-specific custom mechanisms as long as they yield the result described in the specification.</para><para><para>1.5 </para></para>        
				/// </summary>
				/// <java-name>
				/// setSchema
				/// </java-name>
				[Dot42.DexImport("setSchema", "(Ljavax/xml/validation/Schema;)V", AccessFlags = 1)]
				public virtual void SetSchema(global::Javax.Xml.Validation.Schema schema) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Set state of XInclude processing.</para><para>If XInclude markup is found in the document instance, should it be processed as specified in .</para><para>XInclude processing defaults to <code>false</code>.</para><para><para>1.5 </para></para>        
				/// </summary>
				/// <java-name>
				/// setXIncludeAware
				/// </java-name>
				[Dot42.DexImport("setXIncludeAware", "(Z)V", AccessFlags = 1)]
				public virtual void SetXIncludeAware(bool state) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Get state of XInclude processing.</para><para><para>1.5 </para></para>        
				/// </summary>
				/// <returns>
				/// <para>current state of XInclude processing</para>
				/// </returns>
				/// <java-name>
				/// isXIncludeAware
				/// </java-name>
				[Dot42.DexImport("isXIncludeAware", "()Z", AccessFlags = 1)]
				public virtual bool IsXIncludeAware() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Gets the Schema object specified through the setSchema(Schema schema) method.</para><para><para>1.5 </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the Schema object that was last set through the setSchema(Schema) method, or null if the method was not invoked since a DocumentBuilderFactory is created.</para>
				/// </returns>
				/// <java-name>
				/// getSchema
				/// </java-name>
				public global::Javax.Xml.Validation.Schema Schema
				{
				[Dot42.DexImport("getSchema", "()Ljavax/xml/validation/Schema;", AccessFlags = 1)]
						get{ return GetSchema(); }
				[Dot42.DexImport("setSchema", "(Ljavax/xml/validation/Schema;)V", AccessFlags = 1)]
						set{ SetSchema(value); }
				}

		}

		/// <summary>
		/// <para>Indicates a serious configuration error.</para><para><para> </para><para></para><title>Revision:</title><para>569981 </para>, <title>Date:</title><para>2007-08-26 20:59:07 -0700 (Sun, 26 Aug 2007) </para></para>    
		/// </summary>
		/// <java-name>
		/// javax/xml/parsers/ParserConfigurationException
		/// </java-name>
		[Dot42.DexImport("javax/xml/parsers/ParserConfigurationException", AccessFlags = 33)]
		public partial class ParserConfigurationException : global::System.Exception
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Create a new <code>ParserConfigurationException</code> with no detail message. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ParserConfigurationException() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Create a new <code>ParserConfigurationException</code> with the <code>String</code> specified as an error message.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public ParserConfigurationException(string msg) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>Defines the API that wraps an org.xml.sax.XMLReader implementation class. In JAXP 1.0, this class wrapped the org.xml.sax.Parser interface, however this interface was replaced by the org.xml.sax.XMLReader. For ease of transition, this class continues to support the same name and interface as well as supporting new methods.</para><para>An instance of this class can be obtained from the javax.xml.parsers.SAXParserFactory#newSAXParser() method. Once an instance of this class is obtained, XML can be parsed from a variety of input sources. These input sources are InputStreams, Files, URLs, and SAX InputSources.</para><para>This static method creates a new factory instance based on a system property setting or uses the platform default if no property has been defined.</para><para>The system property that controls which Factory implementation to create is named <code>"javax.xml.parsers.SAXParserFactory"</code>. This property names a class that is a concrete subclass of this abstract class. If no property is defined, a platform default will be used.</para><para>As the content is parsed by the underlying parser, methods of the given org.xml.sax.HandlerBase or the org.xml.sax.helpers.DefaultHandler are called.</para><para>Implementations of this class which wrap an underlying implementation can consider using the org.xml.sax.helpers.ParserAdapter class to initially adapt their SAX1 implementation to work under this revised class.</para><para><para> </para><para></para><title>Revision:</title><para>584483 </para>, <title>Date:</title><para>2007-10-13 19:54:48 -0700 (Sat, 13 Oct 2007) </para></para>    
		/// </summary>
		/// <java-name>
		/// javax/xml/parsers/SAXParser
		/// </java-name>
		[Dot42.DexImport("javax/xml/parsers/SAXParser", AccessFlags = 1057)]
		public abstract partial class SAXParser
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Protected constructor to prevent instantiation. Use javax.xml.parsers.SAXParserFactory#newSAXParser().</para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal SAXParser() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Reset this <code>SAXParser</code> to its original configuration.</para><para><code>SAXParser</code> is reset to the same state as when it was created with SAXParserFactory#newSAXParser(). <code>reset()</code> is designed to allow the reuse of existing <code>SAXParser</code>s thus saving resources associated with the creation of new <code>SAXParser</code>s.</para><para>The reset <code>SAXParser</code> is not guaranteed to have the same Schema <code>Object</code>, e.g. Object#equals(Object obj). It is guaranteed to have a functionally equal <code>Schema</code>.</para><para><para>1.5 </para></para>        
				/// </summary>
				/// <java-name>
				/// reset
				/// </java-name>
				[Dot42.DexImport("reset", "()V", AccessFlags = 1)]
				public virtual void Reset() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Parse the content of the given java.io.InputStream instance as XML using the specified org.xml.sax.HandlerBase. <b> Use of the DefaultHandler version of this method is recommended as the HandlerBase class has been deprecated in SAX 2.0</b>.</para><para><para>org.xml.sax.DocumentHandler </para></para>        
				/// </summary>
				/// <java-name>
				/// parse
				/// </java-name>
				[Dot42.DexImport("parse", "(Ljava/io/InputStream;Lorg/xml/sax/HandlerBase;)V", AccessFlags = 1)]
				public virtual void Parse(global::Java.Io.InputStream @is, global::Org.Xml.Sax.HandlerBase hb) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// parse
				/// </java-name>
				[Dot42.DexImport("parse", "(Ljava/io/InputStream;Lorg/xml/sax/HandlerBase;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void Parse(global::Java.Io.InputStream inputStream, global::Org.Xml.Sax.HandlerBase handlerBase, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Parse the content of the given java.io.InputStream instance as XML using the specified org.xml.sax.HandlerBase. <b> Use of the DefaultHandler version of this method is recommended as the HandlerBase class has been deprecated in SAX 2.0</b>.</para><para><para>org.xml.sax.DocumentHandler </para></para>        
				/// </summary>
				/// <java-name>
				/// parse
				/// </java-name>
				[Dot42.DexImport("parse", "(Ljava/io/InputStream;Lorg/xml/sax/helpers/DefaultHandler;)V", AccessFlags = 1)]
				public virtual void Parse(global::Java.Io.InputStream @is, global::Org.Xml.Sax.Helpers.DefaultHandler hb) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// parse
				/// </java-name>
				[Dot42.DexImport("parse", "(Ljava/io/InputStream;Lorg/xml/sax/helpers/DefaultHandler;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void Parse(global::Java.Io.InputStream inputStream, global::Org.Xml.Sax.Helpers.DefaultHandler defaultHandler, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Parse the content of the given java.io.InputStream instance as XML using the specified org.xml.sax.HandlerBase. <b> Use of the DefaultHandler version of this method is recommended as the HandlerBase class has been deprecated in SAX 2.0</b>.</para><para><para>org.xml.sax.DocumentHandler </para></para>        
				/// </summary>
				/// <java-name>
				/// parse
				/// </java-name>
				[Dot42.DexImport("parse", "(Ljava/lang/String;Lorg/xml/sax/HandlerBase;)V", AccessFlags = 1)]
				public virtual void Parse(string @is, global::Org.Xml.Sax.HandlerBase hb) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Parse the content of the given java.io.InputStream instance as XML using the specified org.xml.sax.HandlerBase. <b> Use of the DefaultHandler version of this method is recommended as the HandlerBase class has been deprecated in SAX 2.0</b>.</para><para><para>org.xml.sax.DocumentHandler </para></para>        
				/// </summary>
				/// <java-name>
				/// parse
				/// </java-name>
				[Dot42.DexImport("parse", "(Ljava/lang/String;Lorg/xml/sax/helpers/DefaultHandler;)V", AccessFlags = 1)]
				public virtual void Parse(string @is, global::Org.Xml.Sax.Helpers.DefaultHandler hb) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Parse the content of the given java.io.InputStream instance as XML using the specified org.xml.sax.HandlerBase. <b> Use of the DefaultHandler version of this method is recommended as the HandlerBase class has been deprecated in SAX 2.0</b>.</para><para><para>org.xml.sax.DocumentHandler </para></para>        
				/// </summary>
				/// <java-name>
				/// parse
				/// </java-name>
				[Dot42.DexImport("parse", "(Ljava/io/File;Lorg/xml/sax/HandlerBase;)V", AccessFlags = 1)]
				public virtual void Parse(global::Java.Io.File @is, global::Org.Xml.Sax.HandlerBase hb) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Parse the content of the given java.io.InputStream instance as XML using the specified org.xml.sax.HandlerBase. <b> Use of the DefaultHandler version of this method is recommended as the HandlerBase class has been deprecated in SAX 2.0</b>.</para><para><para>org.xml.sax.DocumentHandler </para></para>        
				/// </summary>
				/// <java-name>
				/// parse
				/// </java-name>
				[Dot42.DexImport("parse", "(Ljava/io/File;Lorg/xml/sax/helpers/DefaultHandler;)V", AccessFlags = 1)]
				public virtual void Parse(global::Java.Io.File @is, global::Org.Xml.Sax.Helpers.DefaultHandler hb) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Parse the content of the given java.io.InputStream instance as XML using the specified org.xml.sax.HandlerBase. <b> Use of the DefaultHandler version of this method is recommended as the HandlerBase class has been deprecated in SAX 2.0</b>.</para><para><para>org.xml.sax.DocumentHandler </para></para>        
				/// </summary>
				/// <java-name>
				/// parse
				/// </java-name>
				[Dot42.DexImport("parse", "(Lorg/xml/sax/InputSource;Lorg/xml/sax/HandlerBase;)V", AccessFlags = 1)]
				public virtual void Parse(global::Org.Xml.Sax.InputSource @is, global::Org.Xml.Sax.HandlerBase hb) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Parse the content of the given java.io.InputStream instance as XML using the specified org.xml.sax.HandlerBase. <b> Use of the DefaultHandler version of this method is recommended as the HandlerBase class has been deprecated in SAX 2.0</b>.</para><para><para>org.xml.sax.DocumentHandler </para></para>        
				/// </summary>
				/// <java-name>
				/// parse
				/// </java-name>
				[Dot42.DexImport("parse", "(Lorg/xml/sax/InputSource;Lorg/xml/sax/helpers/DefaultHandler;)V", AccessFlags = 1)]
				public virtual void Parse(global::Org.Xml.Sax.InputSource @is, global::Org.Xml.Sax.Helpers.DefaultHandler hb) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the SAX parser that is encapsulated by the implementation of this class.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The SAX parser that is encapsulated by the implementation of this class.</para>
				/// </returns>
				/// <java-name>
				/// getParser
				/// </java-name>
				[Dot42.DexImport("getParser", "()Lorg/xml/sax/Parser;", AccessFlags = 1025)]
				public abstract global::Org.Xml.Sax.IParser GetParser() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the org.xml.sax.XMLReader that is encapsulated by the implementation of this class.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The XMLReader that is encapsulated by the implementation of this class.</para>
				/// </returns>
				/// <java-name>
				/// getXMLReader
				/// </java-name>
				[Dot42.DexImport("getXMLReader", "()Lorg/xml/sax/XMLReader;", AccessFlags = 1025)]
				public abstract global::Org.Xml.Sax.IXMLReader GetXMLReader() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Indicates whether or not this parser is configured to understand namespaces.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if this parser is configured to understand namespaces; false otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isNamespaceAware
				/// </java-name>
				[Dot42.DexImport("isNamespaceAware", "()Z", AccessFlags = 1025)]
				public abstract bool IsNamespaceAware() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Indicates whether or not this parser is configured to validate XML documents.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if this parser is configured to validate XML documents; false otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isValidating
				/// </java-name>
				[Dot42.DexImport("isValidating", "()Z", AccessFlags = 1025)]
				public abstract bool IsValidating() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets the particular property in the underlying implementation of org.xml.sax.XMLReader. A list of the core features and properties can be found at .</para><para><para>org.xml.sax.XMLReader::setProperty </para></para>        
				/// </summary>
				/// <java-name>
				/// setProperty
				/// </java-name>
				[Dot42.DexImport("setProperty", "(Ljava/lang/String;Ljava/lang/Object;)V", AccessFlags = 1025)]
				public abstract void SetProperty(string name, object value) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the particular property requested for in the underlying implementation of org.xml.sax.XMLReader.</para><para><para>org.xml.sax.XMLReader::getProperty </para></para>        
				/// </summary>
				/// <returns>
				/// <para>Value of the requested property.</para>
				/// </returns>
				/// <java-name>
				/// getProperty
				/// </java-name>
				[Dot42.DexImport("getProperty", "(Ljava/lang/String;)Ljava/lang/Object;", AccessFlags = 1025)]
				public abstract object GetProperty(string name) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Get a reference to the the Schema being used by the XML processor.</para><para>If no schema is being used, <code>null</code> is returned.</para><para><para>1.5 </para></para>        
				/// </summary>
				/// <returns>
				/// <para>Schema being used or <code>null</code> if none in use</para>
				/// </returns>
				/// <java-name>
				/// getSchema
				/// </java-name>
				[Dot42.DexImport("getSchema", "()Ljavax/xml/validation/Schema;", AccessFlags = 1)]
				public virtual global::Javax.Xml.Validation.Schema GetSchema() /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Xml.Validation.Schema);
				}

				/// <summary>
				/// <para>Get the XInclude processing mode for this parser.</para><para><para>1.5</para><para>SAXParserFactory::setXIncludeAware(boolean) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the return value of the SAXParserFactory#isXIncludeAware() when this parser was created from factory.</para>
				/// </returns>
				/// <java-name>
				/// isXIncludeAware
				/// </java-name>
				[Dot42.DexImport("isXIncludeAware", "()Z", AccessFlags = 1)]
				public virtual bool IsXIncludeAware() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns the SAX parser that is encapsulated by the implementation of this class.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The SAX parser that is encapsulated by the implementation of this class.</para>
				/// </returns>
				/// <java-name>
				/// getParser
				/// </java-name>
				public global::Org.Xml.Sax.IParser Parser
				{
				[Dot42.DexImport("getParser", "()Lorg/xml/sax/Parser;", AccessFlags = 1025)]
						get{ return GetParser(); }
				}

				/// <summary>
				/// <para>Returns the org.xml.sax.XMLReader that is encapsulated by the implementation of this class.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The XMLReader that is encapsulated by the implementation of this class.</para>
				/// </returns>
				/// <java-name>
				/// getXMLReader
				/// </java-name>
				public global::Org.Xml.Sax.IXMLReader XMLReader
				{
				[Dot42.DexImport("getXMLReader", "()Lorg/xml/sax/XMLReader;", AccessFlags = 1025)]
						get{ return GetXMLReader(); }
				}

				/// <summary>
				/// <para>Get a reference to the the Schema being used by the XML processor.</para><para>If no schema is being used, <code>null</code> is returned.</para><para><para>1.5 </para></para>        
				/// </summary>
				/// <returns>
				/// <para>Schema being used or <code>null</code> if none in use</para>
				/// </returns>
				/// <java-name>
				/// getSchema
				/// </java-name>
				public global::Javax.Xml.Validation.Schema Schema
				{
				[Dot42.DexImport("getSchema", "()Ljavax/xml/validation/Schema;", AccessFlags = 1)]
						get{ return GetSchema(); }
				}

		}

		/// <summary>
		/// <para>Defines the API to obtain DOM Document instances from an XML document. Using this class, an application programmer can obtain a Document from XML.</para><para>An instance of this class can be obtained from the DocumentBuilderFactory#newDocumentBuilder() method. Once an instance of this class is obtained, XML can be parsed from a variety of input sources. These input sources are InputStreams, Files, URLs, and SAX InputSources.</para><para>Note that this class reuses several classes from the SAX API. This does not require that the implementor of the underlying DOM implementation use a SAX parser to parse XML document into a <code>Document</code>. It merely requires that the implementation communicate with the application using these existing APIs.</para><para><para> </para><para></para><title>Revision:</title><para>584483 </para>, <title>Date:</title><para>2007-10-13 19:54:48 -0700 (Sat, 13 Oct 2007) </para></para>    
		/// </summary>
		/// <java-name>
		/// javax/xml/parsers/DocumentBuilder
		/// </java-name>
		[Dot42.DexImport("javax/xml/parsers/DocumentBuilder", AccessFlags = 1057)]
		public abstract partial class DocumentBuilder
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Protected constructor </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal DocumentBuilder() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Reset this <code>DocumentBuilder</code> to its original configuration.</para><para><code>DocumentBuilder</code> is reset to the same state as when it was created with DocumentBuilderFactory#newDocumentBuilder(). <code>reset()</code> is designed to allow the reuse of existing <code>DocumentBuilder</code>s thus saving resources associated with the creation of new <code>DocumentBuilder</code>s.</para><para>The reset <code>DocumentBuilder</code> is not guaranteed to have the same EntityResolver or ErrorHandler <code>Object</code>s, e.g. Object#equals(Object obj). It is guaranteed to have a functionally equal <code>EntityResolver</code> and <code>ErrorHandler</code>.</para><para><para>1.5 </para></para>        
				/// </summary>
				/// <java-name>
				/// reset
				/// </java-name>
				[Dot42.DexImport("reset", "()V", AccessFlags = 1)]
				public virtual void Reset() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Parse the content of the given <code>InputStream</code> as an XML document and return a new DOM Document object. An <code>IllegalArgumentException</code> is thrown if the <code>InputStream</code> is null.</para><para><para>org.xml.sax.DocumentHandler </para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>Document</code> result of parsing the <code>InputStream</code> </para>
				/// </returns>
				/// <java-name>
				/// parse
				/// </java-name>
				[Dot42.DexImport("parse", "(Ljava/io/InputStream;)Lorg/w3c/dom/Document;", AccessFlags = 1)]
				public virtual global::Org.W3c.Dom.IDocument Parse(global::Java.Io.InputStream @is) /* MethodBuilder.Create */ 
				{
						return default(global::Org.W3c.Dom.IDocument);
				}

				/// <summary>
				/// <para>Parse the content of the given <code>InputStream</code> as an XML document and return a new DOM Document object. An <code>IllegalArgumentException</code> is thrown if the <code>InputStream</code> is null.</para><para><para>org.xml.sax.DocumentHandler </para></para>        
				/// </summary>
				/// <returns>
				/// <para>A new DOM Document object. </para>
				/// </returns>
				/// <java-name>
				/// parse
				/// </java-name>
				[Dot42.DexImport("parse", "(Ljava/io/InputStream;Ljava/lang/String;)Lorg/w3c/dom/Document;", AccessFlags = 1)]
				public virtual global::Org.W3c.Dom.IDocument Parse(global::Java.Io.InputStream @is, string systemId) /* MethodBuilder.Create */ 
				{
						return default(global::Org.W3c.Dom.IDocument);
				}

				/// <summary>
				/// <para>Parse the content of the given <code>InputStream</code> as an XML document and return a new DOM Document object. An <code>IllegalArgumentException</code> is thrown if the <code>InputStream</code> is null.</para><para><para>org.xml.sax.DocumentHandler </para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>Document</code> result of parsing the <code>InputStream</code> </para>
				/// </returns>
				/// <java-name>
				/// parse
				/// </java-name>
				[Dot42.DexImport("parse", "(Ljava/lang/String;)Lorg/w3c/dom/Document;", AccessFlags = 1)]
				public virtual global::Org.W3c.Dom.IDocument Parse(string @is) /* MethodBuilder.Create */ 
				{
						return default(global::Org.W3c.Dom.IDocument);
				}

				/// <summary>
				/// <para>Parse the content of the given <code>InputStream</code> as an XML document and return a new DOM Document object. An <code>IllegalArgumentException</code> is thrown if the <code>InputStream</code> is null.</para><para><para>org.xml.sax.DocumentHandler </para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>Document</code> result of parsing the <code>InputStream</code> </para>
				/// </returns>
				/// <java-name>
				/// parse
				/// </java-name>
				[Dot42.DexImport("parse", "(Ljava/io/File;)Lorg/w3c/dom/Document;", AccessFlags = 1)]
				public virtual global::Org.W3c.Dom.IDocument Parse(global::Java.Io.File @is) /* MethodBuilder.Create */ 
				{
						return default(global::Org.W3c.Dom.IDocument);
				}

				/// <summary>
				/// <para>Parse the content of the given <code>InputStream</code> as an XML document and return a new DOM Document object. An <code>IllegalArgumentException</code> is thrown if the <code>InputStream</code> is null.</para><para><para>org.xml.sax.DocumentHandler </para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>Document</code> result of parsing the <code>InputStream</code> </para>
				/// </returns>
				/// <java-name>
				/// parse
				/// </java-name>
				[Dot42.DexImport("parse", "(Lorg/xml/sax/InputSource;)Lorg/w3c/dom/Document;", AccessFlags = 1025)]
				public abstract global::Org.W3c.Dom.IDocument Parse(global::Org.Xml.Sax.InputSource @is) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Indicates whether or not this parser is configured to understand namespaces.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if this parser is configured to understand namespaces; false otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isNamespaceAware
				/// </java-name>
				[Dot42.DexImport("isNamespaceAware", "()Z", AccessFlags = 1025)]
				public abstract bool IsNamespaceAware() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Indicates whether or not this parser is configured to validate XML documents.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if this parser is configured to validate XML documents; false otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isValidating
				/// </java-name>
				[Dot42.DexImport("isValidating", "()Z", AccessFlags = 1025)]
				public abstract bool IsValidating() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Specify the EntityResolver to be used to resolve entities present in the XML document to be parsed. Setting this to <code>null</code> will result in the underlying implementation using it's own default implementation and behavior.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setEntityResolver
				/// </java-name>
				[Dot42.DexImport("setEntityResolver", "(Lorg/xml/sax/EntityResolver;)V", AccessFlags = 1025)]
				public abstract void SetEntityResolver(global::Org.Xml.Sax.IEntityResolver er) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Specify the ErrorHandler to be used by the parser. Setting this to <code>null</code> will result in the underlying implementation using it's own default implementation and behavior.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setErrorHandler
				/// </java-name>
				[Dot42.DexImport("setErrorHandler", "(Lorg/xml/sax/ErrorHandler;)V", AccessFlags = 1025)]
				public abstract void SetErrorHandler(global::Org.Xml.Sax.IErrorHandler eh) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Obtain a new instance of a DOM Document object to build a DOM tree with.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>A new instance of a DOM Document object. </para>
				/// </returns>
				/// <java-name>
				/// newDocument
				/// </java-name>
				[Dot42.DexImport("newDocument", "()Lorg/w3c/dom/Document;", AccessFlags = 1025)]
				public abstract global::Org.W3c.Dom.IDocument NewDocument() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Obtain an instance of a DOMImplementation object.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>A new instance of a <code>DOMImplementation</code>. </para>
				/// </returns>
				/// <java-name>
				/// getDOMImplementation
				/// </java-name>
				[Dot42.DexImport("getDOMImplementation", "()Lorg/w3c/dom/DOMImplementation;", AccessFlags = 1025)]
				public abstract global::Org.W3c.Dom.IDOMImplementation GetDOMImplementation() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Get a reference to the the Schema being used by the XML processor.</para><para>If no schema is being used, <code>null</code> is returned.</para><para><para>1.5 </para></para>        
				/// </summary>
				/// <returns>
				/// <para>Schema being used or <code>null</code> if none in use</para>
				/// </returns>
				/// <java-name>
				/// getSchema
				/// </java-name>
				[Dot42.DexImport("getSchema", "()Ljavax/xml/validation/Schema;", AccessFlags = 1)]
				public virtual global::Javax.Xml.Validation.Schema GetSchema() /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Xml.Validation.Schema);
				}

				/// <summary>
				/// <para>Get the XInclude processing mode for this parser.</para><para><para>1.5</para><para>DocumentBuilderFactory::setXIncludeAware(boolean) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the return value of the DocumentBuilderFactory#isXIncludeAware() when this parser was created from factory.</para>
				/// </returns>
				/// <java-name>
				/// isXIncludeAware
				/// </java-name>
				[Dot42.DexImport("isXIncludeAware", "()Z", AccessFlags = 1)]
				public virtual bool IsXIncludeAware() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Obtain an instance of a DOMImplementation object.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>A new instance of a <code>DOMImplementation</code>. </para>
				/// </returns>
				/// <java-name>
				/// getDOMImplementation
				/// </java-name>
				public global::Org.W3c.Dom.IDOMImplementation DOMImplementation
				{
				[Dot42.DexImport("getDOMImplementation", "()Lorg/w3c/dom/DOMImplementation;", AccessFlags = 1025)]
						get{ return GetDOMImplementation(); }
				}

				/// <summary>
				/// <para>Get a reference to the the Schema being used by the XML processor.</para><para>If no schema is being used, <code>null</code> is returned.</para><para><para>1.5 </para></para>        
				/// </summary>
				/// <returns>
				/// <para>Schema being used or <code>null</code> if none in use</para>
				/// </returns>
				/// <java-name>
				/// getSchema
				/// </java-name>
				public global::Javax.Xml.Validation.Schema Schema
				{
				[Dot42.DexImport("getSchema", "()Ljavax/xml/validation/Schema;", AccessFlags = 1)]
						get{ return GetSchema(); }
				}

		}

}


