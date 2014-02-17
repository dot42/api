// Copyright (C) 2014 dot42
//
// Original filename: Javax.Xml.Xpath.cs
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
namespace Javax.Xml.Xpath
{
		/// <summary>
		/// <para><code>XPathFunction</code> provides access to XPath functions.</para><para>Functions are identified by QName and arity in XPath.</para><para><para> </para><simplesectsep></simplesectsep><para> </para><para></para><title>Revision:</title><para>446598 </para>, <title>Date:</title><para>2006-09-15 05:55:40 -0700 (Fri, 15 Sep 2006) </para><para>1.5 </para></para>    
		/// </summary>
		/// <java-name>
		/// javax/xml/xpath/XPathFunction
		/// </java-name>
		[Dot42.DexImport("javax/xml/xpath/XPathFunction", AccessFlags = 1537)]
		public partial interface IXPathFunction
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Evaluate the function with the specified arguments.</para><para>To the greatest extent possible, side-effects should be avoided in the definition of extension functions. The implementation evaluating an XPath expression is under no obligation to call extension functions in any particular order or any particular number of times.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The result of evaluating the <code>XPath</code> function as an <code>Object</code>.</para>
				/// </returns>
				/// <java-name>
				/// evaluate
				/// </java-name>
				[Dot42.DexImport("evaluate", "(Ljava/util/List;)Ljava/lang/Object;", AccessFlags = 1025)]
				object Evaluate(global::Java.Util.IList<object> args) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para><code>XPathExpression</code> provides access to compiled XPath expressions.</para><para><table></table></para><para>Evaluation of XPath Expressions.  &lt;/thead&gt; &lt;tbody&gt; </para><para>context </para><para>If a request is made to evaluate the expression in the absence of a context item, an empty document node will be used for the context. For the purposes of evaluating XPath expressions, a DocumentFragment is treated like a Document node.   </para><para>variables </para><para>If the expression contains a variable reference, its value will be found through the XPathVariableResolver. An XPathExpressionException is raised if the variable resolver is undefined or the resolver returns <code>null</code> for the variable. The value of a variable must be immutable through the course of any single evaluation.</para><para>functions </para><para>If the expression contains a function reference, the function will be found through the XPathFunctionResolver. An XPathExpressionException is raised if the function resolver is undefined or the function resolver returns <code>null</code> for the function.</para><para>QNames </para><para>QNames in the expression are resolved against the XPath namespace context.   </para><para>result </para><para>This result of evaluating an expression is converted to an instance of the desired return type. Valid return types are defined in XPathConstants. Conversion to the return type follows XPath conversion rules.</para><para><para> </para><simplesectsep></simplesectsep><para> </para><para></para><title>Revision:</title><para>446598 </para>, <title>Date:</title><para>2006-09-15 05:55:40 -0700 (Fri, 15 Sep 2006) </para><para> </para><para>1.5 </para></para>    
		/// </summary>
		/// <java-name>
		/// javax/xml/xpath/XPathExpression
		/// </java-name>
		[Dot42.DexImport("javax/xml/xpath/XPathExpression", AccessFlags = 1537)]
		public partial interface IXPathExpression
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Evaluate the compiled XPath expression in the context of the specified <code>InputSource</code> and return the result as the specified type.</para><para>This method builds a data model for the InputSource and calls evaluate(Object item, QName returnType) on the resulting document object.</para><para>See  for context item evaluation, variable, function and QName resolution and return type conversion.</para><para>If <code>returnType</code> is not one of the types defined in XPathConstants, then an <code>IllegalArgumentException</code> is thrown.</para><para>If <code>source</code> or <code>returnType</code> is <code>null</code>, then a <code>NullPointerException</code> is thrown.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The <code>Object</code> that is the result of evaluating the expression and converting the result to <code>returnType</code>.</para>
				/// </returns>
				/// <java-name>
				/// evaluate
				/// </java-name>
				[Dot42.DexImport("evaluate", "(Ljava/lang/Object;Ljavax/xml/namespace/QName;)Ljava/lang/Object;", AccessFlags = 1025)]
				object Evaluate(object source, global::Javax.Xml.Namespace.QName returnType) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Evaluate the compiled XPath expression in the context of the specified <code>InputSource</code> and return the result as a <code>String</code>.</para><para>This method calls evaluate(InputSource source, QName returnType) with a <code>returnType</code> of XPathConstants#STRING.</para><para>See  for context item evaluation, variable, function and QName resolution and return type conversion.</para><para>If <code>source</code> is <code>null</code>, then a <code>NullPointerException</code> is thrown.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The <code>String</code> that is the result of evaluating the expression and converting the result to a <code>String</code>.</para>
				/// </returns>
				/// <java-name>
				/// evaluate
				/// </java-name>
				[Dot42.DexImport("evaluate", "(Ljava/lang/Object;)Ljava/lang/String;", AccessFlags = 1025)]
				string Evaluate(object source) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Evaluate the compiled XPath expression in the context of the specified <code>InputSource</code> and return the result as the specified type.</para><para>This method builds a data model for the InputSource and calls evaluate(Object item, QName returnType) on the resulting document object.</para><para>See  for context item evaluation, variable, function and QName resolution and return type conversion.</para><para>If <code>returnType</code> is not one of the types defined in XPathConstants, then an <code>IllegalArgumentException</code> is thrown.</para><para>If <code>source</code> or <code>returnType</code> is <code>null</code>, then a <code>NullPointerException</code> is thrown.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The <code>Object</code> that is the result of evaluating the expression and converting the result to <code>returnType</code>.</para>
				/// </returns>
				/// <java-name>
				/// evaluate
				/// </java-name>
				[Dot42.DexImport("evaluate", "(Lorg/xml/sax/InputSource;Ljavax/xml/namespace/QName;)Ljava/lang/Object;", AccessFlags = 1025)]
				object Evaluate(global::Org.Xml.Sax.InputSource source, global::Javax.Xml.Namespace.QName returnType) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Evaluate the compiled XPath expression in the context of the specified <code>InputSource</code> and return the result as a <code>String</code>.</para><para>This method calls evaluate(InputSource source, QName returnType) with a <code>returnType</code> of XPathConstants#STRING.</para><para>See  for context item evaluation, variable, function and QName resolution and return type conversion.</para><para>If <code>source</code> is <code>null</code>, then a <code>NullPointerException</code> is thrown.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The <code>String</code> that is the result of evaluating the expression and converting the result to a <code>String</code>.</para>
				/// </returns>
				/// <java-name>
				/// evaluate
				/// </java-name>
				[Dot42.DexImport("evaluate", "(Lorg/xml/sax/InputSource;)Ljava/lang/String;", AccessFlags = 1025)]
				string Evaluate(global::Org.Xml.Sax.InputSource source) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>XPath constants.</para><para><para> </para><simplesectsep></simplesectsep><para> </para><para></para><title>Revision:</title><para>446598 </para>, <title>Date:</title><para>2006-09-15 05:55:40 -0700 (Fri, 15 Sep 2006) </para><para> </para><para>1.5 </para></para>    
		/// </summary>
		/// <java-name>
		/// javax/xml/xpath/XPathConstants
		/// </java-name>
		[Dot42.DexImport("javax/xml/xpath/XPathConstants", AccessFlags = 33)]
		public partial class XPathConstants
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>The XPath 1.0 number data type.</para><para>Maps to Java Double.</para>        
				/// </summary>
				/// <java-name>
				/// NUMBER
				/// </java-name>
				[Dot42.DexImport("NUMBER", "Ljavax/xml/namespace/QName;", AccessFlags = 25)]
				public static readonly global::Javax.Xml.Namespace.QName NUMBER;
				/// <summary>
				/// <para>The XPath 1.0 string data type.</para><para>Maps to Java String.</para>        
				/// </summary>
				/// <java-name>
				/// STRING
				/// </java-name>
				[Dot42.DexImport("STRING", "Ljavax/xml/namespace/QName;", AccessFlags = 25)]
				public static readonly global::Javax.Xml.Namespace.QName STRING;
				/// <summary>
				/// <para>The XPath 1.0 boolean data type.</para><para>Maps to Java Boolean.</para>        
				/// </summary>
				/// <java-name>
				/// BOOLEAN
				/// </java-name>
				[Dot42.DexImport("BOOLEAN", "Ljavax/xml/namespace/QName;", AccessFlags = 25)]
				public static readonly global::Javax.Xml.Namespace.QName BOOLEAN;
				/// <summary>
				/// <para>The XPath 1.0 NodeSet data type.</para><para>Maps to Java org.w3c.dom.NodeList.</para>        
				/// </summary>
				/// <java-name>
				/// NODESET
				/// </java-name>
				[Dot42.DexImport("NODESET", "Ljavax/xml/namespace/QName;", AccessFlags = 25)]
				public static readonly global::Javax.Xml.Namespace.QName NODESET;
				/// <summary>
				/// <para>The XPath 1.0 NodeSet data type.</para><para>Maps to Java org.w3c.dom.Node.</para>        
				/// </summary>
				/// <java-name>
				/// NODE
				/// </java-name>
				[Dot42.DexImport("NODE", "Ljavax/xml/namespace/QName;", AccessFlags = 25)]
				public static readonly global::Javax.Xml.Namespace.QName NODE;
				/// <summary>
				/// <para>The URI for the DOM object model, "http://java.sun.com/jaxp/xpath/dom".</para>        
				/// </summary>
				/// <java-name>
				/// DOM_OBJECT_MODEL
				/// </java-name>
				[Dot42.DexImport("DOM_OBJECT_MODEL", "Ljava/lang/String;", AccessFlags = 25)]
				public const string DOM_OBJECT_MODEL = "http://java.sun.com/jaxp/xpath/dom";
				/// <summary>
				/// <para>Private constructor to prevent instantiation.</para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal XPathConstants() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>An <code>XPathFactory</code> instance can be used to create javax.xml.xpath.XPath objects.</para><para>See newInstance(String uri) for lookup mechanism.</para><para><para> </para><simplesectsep></simplesectsep><para> </para><para></para><title>Revision:</title><para>888889 </para>, <title>Date:</title><para>2009-12-09 09:43:18 -0800 (Wed, 09 Dec 2009) </para><para>1.5 </para></para>    
		/// </summary>
		/// <java-name>
		/// javax/xml/xpath/XPathFactory
		/// </java-name>
		[Dot42.DexImport("javax/xml/xpath/XPathFactory", AccessFlags = 1057)]
		public abstract partial class XPathFactory
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>The default property name according to the JAXP spec.</para>        
				/// </summary>
				/// <java-name>
				/// DEFAULT_PROPERTY_NAME
				/// </java-name>
				[Dot42.DexImport("DEFAULT_PROPERTY_NAME", "Ljava/lang/String;", AccessFlags = 25)]
				public const string DEFAULT_PROPERTY_NAME = "javax.xml.xpath.XPathFactory";
				/// <summary>
				/// <para>Default Object Model URI.</para>        
				/// </summary>
				/// <java-name>
				/// DEFAULT_OBJECT_MODEL_URI
				/// </java-name>
				[Dot42.DexImport("DEFAULT_OBJECT_MODEL_URI", "Ljava/lang/String;", AccessFlags = 25)]
				public const string DEFAULT_OBJECT_MODEL_URI = "http://java.sun.com/jaxp/xpath/dom";
				/// <summary>
				/// <para>Protected constructor as newInstance(), newInstance(String uri) or newInstance(String uri, String factoryClassName, ClassLoader classLoader) should be used to create a new instance of an <code>XPathFactory</code>.</para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal XPathFactory() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Get a new <code>XPathFactory</code> instance using the default object model, DEFAULT_OBJECT_MODEL_URI, the W3C DOM.</para><para>This method is functionally equivalent to:</para><para><pre>
				///          newInstance(DEFAULT_OBJECT_MODEL_URI)
				///        </pre></para><para>Since the implementation for the W3C DOM is always available, this method will never fail.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Instance of an <code>XPathFactory</code>. </para>
				/// </returns>
				/// <java-name>
				/// newInstance
				/// </java-name>
				[Dot42.DexImport("newInstance", "()Ljavax/xml/xpath/XPathFactory;", AccessFlags = 25)]
				public static global::Javax.Xml.Xpath.XPathFactory NewInstance() /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Xml.Xpath.XPathFactory);
				}

				/// <summary>
				/// <para>Get a new <code>XPathFactory</code> instance using the specified object model.</para><para>To find a <code>XPathFactory</code> object, this method looks the following places in the following order where "the class loader" refers to the context class loader:</para><para><ol><li><para>If the system property DEFAULT_PROPERTY_NAME + ":uri" is present, where uri is the parameter to this method, then its value is read as a class name. The method will try to create a new instance of this class by using the class loader, and returns it if it is successfully created.  </para></li><li><para>${java.home}/lib/jaxp.properties is read and the value associated with the key being the system property above is looked for. If present, the value is processed just like above.  </para></li><li><para>The class loader is asked for service provider provider-configuration files matching <code>javax.xml.xpath.XPathFactory</code> in the resource directory META-INF/services. See the JAR File Specification for file format and parsing rules. Each potential service provider is required to implement the method: <pre>
				///             isObjectModelSupported(String objectModel)
				///           </pre> The first service provider found in class loader order that supports the specified object model is returned.  </para></li><li><para>Platform default <code>XPathFactory</code> is located in a platform specific way. There must be a platform default XPathFactory for the W3C DOM, i.e. DEFAULT_OBJECT_MODEL_URI.  </para></li></ol></para><para>If everything fails, an <code>XPathFactoryConfigurationException</code> will be thrown.</para><para>Tip for Trouble-shooting:</para><para>See java.util.Properties#load(java.io.InputStream) for exactly how a property file is parsed. In particular, colons ':' need to be escaped in a property file, so make sure the URIs are properly escaped in it. For example:</para><para><pre>
				///         http\://java.sun.com/jaxp/xpath/dom=org.acme.DomXPathFactory
				///       </pre></para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Instance of an <code>XPathFactory</code>.</para>
				/// </returns>
				/// <java-name>
				/// newInstance
				/// </java-name>
				[Dot42.DexImport("newInstance", "(Ljava/lang/String;)Ljavax/xml/xpath/XPathFactory;", AccessFlags = 25)]
				public static global::Javax.Xml.Xpath.XPathFactory NewInstance(string uri) /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Xml.Xpath.XPathFactory);
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>Instance of an <code>XPathFactory</code>.</para>
				/// </returns>
				/// <java-name>
				/// newInstance
				/// </java-name>
				[Dot42.DexImport("newInstance", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/ClassLoader;)Ljavax/xml/xpath/XPa" +
    "thFactory;", AccessFlags = 9)]
				public static global::Javax.Xml.Xpath.XPathFactory NewInstance(string uri, string factoryClassName, global::Java.Lang.ClassLoader classLoader) /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Xml.Xpath.XPathFactory);
				}

				/// <summary>
				/// <para>Is specified object model supported by this <code>XPathFactory</code>?</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> if <code>XPathFactory</code> supports <code>objectModel</code>, else <code>false</code>.</para>
				/// </returns>
				/// <java-name>
				/// isObjectModelSupported
				/// </java-name>
				[Dot42.DexImport("isObjectModelSupported", "(Ljava/lang/String;)Z", AccessFlags = 1025)]
				public abstract bool IsObjectModelSupported(string objectModel) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Set a feature for this <code>XPathFactory</code> and <code>XPath</code>s created by this factory.</para><para>Feature names are fully qualified java.net.URIs. Implementations may define their own features. An XPathFactoryConfigurationException is thrown if this <code>XPathFactory</code> or the <code>XPath</code>s it creates cannot support the feature. It is possible for an <code>XPathFactory</code> to expose a feature value but be unable to change its state. </para><para>All implementations are required to support the javax.xml.XMLConstants#FEATURE_SECURE_PROCESSING feature. When the feature is <code>true</code>, any reference to an external function is an error. Under these conditions, the implementation must not call the XPathFunctionResolver and must throw an XPathFunctionException. </para><para></para>        
				/// </summary>
				/// <java-name>
				/// setFeature
				/// </java-name>
				[Dot42.DexImport("setFeature", "(Ljava/lang/String;Z)V", AccessFlags = 1025)]
				public abstract void SetFeature(string name, bool value) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Get the state of the named feature.</para><para>Feature names are fully qualified java.net.URIs. Implementations may define their own features. An XPathFactoryConfigurationException is thrown if this <code>XPathFactory</code> or the <code>XPath</code>s it creates cannot support the feature. It is possible for an <code>XPathFactory</code> to expose a feature value but be unable to change its state. </para><para></para>        
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
				/// <para>Establish a default variable resolver.</para><para>Any <code>XPath</code> objects constructed from this factory will use the specified resolver by default.</para><para>A <code>NullPointerException</code> is thrown if <code>resolver</code> is <code>null</code>.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setXPathVariableResolver
				/// </java-name>
				[Dot42.DexImport("setXPathVariableResolver", "(Ljavax/xml/xpath/XPathVariableResolver;)V", AccessFlags = 1025)]
				public abstract void SetXPathVariableResolver(global::Javax.Xml.Xpath.IXPathVariableResolver resolver) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Establish a default function resolver.</para><para>Any <code>XPath</code> objects constructed from this factory will use the specified resolver by default.</para><para>A <code>NullPointerException</code> is thrown if <code>resolver</code> is <code>null</code>.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setXPathFunctionResolver
				/// </java-name>
				[Dot42.DexImport("setXPathFunctionResolver", "(Ljavax/xml/xpath/XPathFunctionResolver;)V", AccessFlags = 1025)]
				public abstract void SetXPathFunctionResolver(global::Javax.Xml.Xpath.IXPathFunctionResolver resolver) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Return a new <code>XPath</code> using the underlying object model determined when the <code>XPathFactory</code> was instantiated.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>New instance of an <code>XPath</code>. </para>
				/// </returns>
				/// <java-name>
				/// newXPath
				/// </java-name>
				[Dot42.DexImport("newXPath", "()Ljavax/xml/xpath/XPath;", AccessFlags = 1025)]
				public abstract global::Javax.Xml.Xpath.IXPath NewXPath() /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para><code>XPathExpressionException</code> represents an error in an XPath expression.</para><para><para> </para><simplesectsep></simplesectsep><para> </para><para></para><title>Revision:</title><para>446598 </para>, <title>Date:</title><para>2006-09-15 05:55:40 -0700 (Fri, 15 Sep 2006) </para><para>1.5 </para></para>    
		/// </summary>
		/// <java-name>
		/// javax/xml/xpath/XPathExpressionException
		/// </java-name>
		[Dot42.DexImport("javax/xml/xpath/XPathExpressionException", AccessFlags = 33)]
		public partial class XPathExpressionException : global::Javax.Xml.Xpath.XPathException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public XPathExpressionException(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public XPathExpressionException(global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal XPathExpressionException() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		/// <para><code>XPathFunctionResolver</code> provides access to the set of user defined <code>XPathFunction</code>s.</para><para>XPath functions are resolved by name and arity. The resolver is not needed for XPath built-in functions and the resolver <b><b>cannot</b></b> be used to override those functions.</para><para>In particular, the resolver is only called for functions in an another namespace (functions with an explicit prefix). This means that you cannot use the <code>XPathFunctionResolver</code> to implement specifications like  which extend the function library of XPath 1.0 in the same namespace. This is a consequence of the design of the resolver.</para><para>If you wish to implement additional built-in functions, you will have to extend the underlying implementation directly.</para><para><para> </para><simplesectsep></simplesectsep><para> </para><para></para><title>Revision:</title><para>446598 </para>, <title>Date:</title><para>2006-09-15 05:55:40 -0700 (Fri, 15 Sep 2006) </para><para> </para><para>1.5 </para></para>    
		/// </summary>
		/// <java-name>
		/// javax/xml/xpath/XPathFunctionResolver
		/// </java-name>
		[Dot42.DexImport("javax/xml/xpath/XPathFunctionResolver", AccessFlags = 1537)]
		public partial interface IXPathFunctionResolver
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Find a function in the set of available functions.</para><para>If <code>functionName</code> or <code>arity</code> is <code>null</code>, then a <code>NullPointerException</code> is thrown.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The function or <code>null</code> if no function named <code>functionName</code> with <code>arity</code> arguments exists.</para>
				/// </returns>
				/// <java-name>
				/// resolveFunction
				/// </java-name>
				[Dot42.DexImport("resolveFunction", "(Ljavax/xml/namespace/QName;I)Ljavax/xml/xpath/XPathFunction;", AccessFlags = 1025)]
				global::Javax.Xml.Xpath.IXPathFunction ResolveFunction(global::Javax.Xml.Namespace.QName functionName, int arity) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para><code>XPathFunctionException</code> represents an error with an XPath function.</para><para><para> </para><simplesectsep></simplesectsep><para> </para><para></para><title>Revision:</title><para>446598 </para>, <title>Date:</title><para>2006-09-15 05:55:40 -0700 (Fri, 15 Sep 2006) </para><para>1.5 </para></para>    
		/// </summary>
		/// <java-name>
		/// javax/xml/xpath/XPathFunctionException
		/// </java-name>
		[Dot42.DexImport("javax/xml/xpath/XPathFunctionException", AccessFlags = 33)]
		public partial class XPathFunctionException : global::Javax.Xml.Xpath.XPathExpressionException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public XPathFunctionException(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public XPathFunctionException(global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal XPathFunctionException() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		/// <para><code>XPathVariableResolver</code> provides access to the set of user defined XPath variables.</para><para>The <code>XPathVariableResolver</code> and the XPath evaluator must adhere to a contract that cannot be directly enforced by the API. Although variables may be mutable, that is, an application may wish to evaluate the same XPath expression more than once with different variable values, in the course of evaluating any single XPath expression, a variable's value <b><b>must</b></b> be immutable.</para><para><para> </para><simplesectsep></simplesectsep><para> </para><para></para><title>Revision:</title><para>446598 </para>, <title>Date:</title><para>2006-09-15 05:55:40 -0700 (Fri, 15 Sep 2006) </para><para>1.5 </para></para>    
		/// </summary>
		/// <java-name>
		/// javax/xml/xpath/XPathVariableResolver
		/// </java-name>
		[Dot42.DexImport("javax/xml/xpath/XPathVariableResolver", AccessFlags = 1537)]
		public partial interface IXPathVariableResolver
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Find a variable in the set of available variables.</para><para>If <code>variableName</code> is <code>null</code>, then a <code>NullPointerException</code> is thrown.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The variables value, or <code>null</code> if no variable named <code>variableName</code> exists. The value returned must be of a type appropriate for the underlying object model.</para>
				/// </returns>
				/// <java-name>
				/// resolveVariable
				/// </java-name>
				[Dot42.DexImport("resolveVariable", "(Ljavax/xml/namespace/QName;)Ljava/lang/Object;", AccessFlags = 1025)]
				object ResolveVariable(global::Javax.Xml.Namespace.QName variableName) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para><code>XPathFactoryConfigurationException</code> represents a configuration error in a <code>XPathFactory</code> environment.</para><para><para> </para><simplesectsep></simplesectsep><para> </para><para></para><title>Revision:</title><para>446598 </para>, <title>Date:</title><para>2006-09-15 05:55:40 -0700 (Fri, 15 Sep 2006) </para><para>1.5 </para></para>    
		/// </summary>
		/// <java-name>
		/// javax/xml/xpath/XPathFactoryConfigurationException
		/// </java-name>
		[Dot42.DexImport("javax/xml/xpath/XPathFactoryConfigurationException", AccessFlags = 33)]
		public partial class XPathFactoryConfigurationException : global::Javax.Xml.Xpath.XPathException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public XPathFactoryConfigurationException(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public XPathFactoryConfigurationException(global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal XPathFactoryConfigurationException() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		/// <para><code>XPathException</code> represents a generic XPath exception.</para><para><para> </para><simplesectsep></simplesectsep><para> </para><para></para><title>Revision:</title><para>446598 </para>, <title>Date:</title><para>2006-09-15 05:55:40 -0700 (Fri, 15 Sep 2006) </para><para>1.5 </para></para>    
		/// </summary>
		/// <java-name>
		/// javax/xml/xpath/XPathException
		/// </java-name>
		[Dot42.DexImport("javax/xml/xpath/XPathException", AccessFlags = 33)]
		public partial class XPathException : global::System.Exception
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public XPathException(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public XPathException(global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getCause
				/// </java-name>
				[Dot42.DexImport("getCause", "()Ljava/lang/Throwable;", AccessFlags = 1)]
				public override global::System.Exception GetCause() /* MethodBuilder.Create */ 
				{
						return default(global::System.Exception);
				}

				/// <java-name>
				/// printStackTrace
				/// </java-name>
				[Dot42.DexImport("printStackTrace", "(Ljava/io/PrintStream;)V", AccessFlags = 1)]
				public override void PrintStackTrace(global::Java.Io.PrintStream s) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// printStackTrace
				/// </java-name>
				[Dot42.DexImport("printStackTrace", "()V", AccessFlags = 1)]
				public override void PrintStackTrace() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// printStackTrace
				/// </java-name>
				[Dot42.DexImport("printStackTrace", "(Ljava/io/PrintWriter;)V", AccessFlags = 1)]
				public override void PrintStackTrace(global::Java.Io.PrintWriter s) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal XPathException() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		/// <para><code>XPath</code> provides access to the XPath evaluation environment and expressions.</para><para><table></table></para><para>Evaluation of XPath Expressions.  &lt;/thead&gt; &lt;tbody&gt; </para><para>context </para><para>If a request is made to evaluate the expression in the absence of a context item, an empty document node will be used for the context. For the purposes of evaluating XPath expressions, a DocumentFragment is treated like a Document node.   </para><para>variables </para><para>If the expression contains a variable reference, its value will be found through the XPathVariableResolver set with setXPathVariableResolver(XPathVariableResolver resolver). An XPathExpressionException is raised if the variable resolver is undefined or the resolver returns <code>null</code> for the variable. The value of a variable must be immutable through the course of any single evaluation.</para><para>functions </para><para>If the expression contains a function reference, the function will be found through the XPathFunctionResolver set with setXPathFunctionResolver(XPathFunctionResolver resolver). An XPathExpressionException is raised if the function resolver is undefined or the function resolver returns <code>null</code> for the function.</para><para>QNames </para><para>QNames in the expression are resolved against the XPath namespace context set with setNamespaceContext(NamespaceContext nsContext).   </para><para>result </para><para>This result of evaluating an expression is converted to an instance of the desired return type. Valid return types are defined in XPathConstants. Conversion to the return type follows XPath conversion rules.</para><para><para> </para><simplesectsep></simplesectsep><para> </para><para></para><title>Revision:</title><para>569998 </para>, <title>Date:</title><para>2007-08-26 21:40:02 -0700 (Sun, 26 Aug 2007) </para><para> </para><para>1.5 </para></para>    
		/// </summary>
		/// <java-name>
		/// javax/xml/xpath/XPath
		/// </java-name>
		[Dot42.DexImport("javax/xml/xpath/XPath", AccessFlags = 1537)]
		public partial interface IXPath
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Reset this <code>XPath</code> to its original configuration.</para><para><code>XPath</code> is reset to the same state as when it was created with XPathFactory#newXPath(). <code>reset()</code> is designed to allow the reuse of existing <code>XPath</code>s thus saving resources associated with the creation of new <code>XPath</code>s.</para><para>The reset <code>XPath</code> is not guaranteed to have the same XPathFunctionResolver, XPathVariableResolver or NamespaceContext <code>Object</code>s, e.g. Object#equals(Object obj). It is guaranteed to have a functionally equal <code>XPathFunctionResolver</code>, <code>XPathVariableResolver</code> and <code>NamespaceContext</code>.</para>        
				/// </summary>
				/// <java-name>
				/// reset
				/// </java-name>
				[Dot42.DexImport("reset", "()V", AccessFlags = 1025)]
				void Reset() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Establish a variable resolver.</para><para>A <code>NullPointerException</code> is thrown if <code>resolver</code> is <code>null</code>.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setXPathVariableResolver
				/// </java-name>
				[Dot42.DexImport("setXPathVariableResolver", "(Ljavax/xml/xpath/XPathVariableResolver;)V", AccessFlags = 1025)]
				void SetXPathVariableResolver(global::Javax.Xml.Xpath.IXPathVariableResolver resolver) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Return the current variable resolver.</para><para><code>null</code> is returned in no variable resolver is in effect.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Current variable resolver. </para>
				/// </returns>
				/// <java-name>
				/// getXPathVariableResolver
				/// </java-name>
				[Dot42.DexImport("getXPathVariableResolver", "()Ljavax/xml/xpath/XPathVariableResolver;", AccessFlags = 1025)]
				global::Javax.Xml.Xpath.IXPathVariableResolver GetXPathVariableResolver() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Establish a function resolver.</para><para>A <code>NullPointerException</code> is thrown if <code>resolver</code> is <code>null</code>.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setXPathFunctionResolver
				/// </java-name>
				[Dot42.DexImport("setXPathFunctionResolver", "(Ljavax/xml/xpath/XPathFunctionResolver;)V", AccessFlags = 1025)]
				void SetXPathFunctionResolver(global::Javax.Xml.Xpath.IXPathFunctionResolver resolver) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Return the current function resolver.</para><para><code>null</code> is returned in no function resolver is in effect.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Current function resolver. </para>
				/// </returns>
				/// <java-name>
				/// getXPathFunctionResolver
				/// </java-name>
				[Dot42.DexImport("getXPathFunctionResolver", "()Ljavax/xml/xpath/XPathFunctionResolver;", AccessFlags = 1025)]
				global::Javax.Xml.Xpath.IXPathFunctionResolver GetXPathFunctionResolver() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Establish a namespace context.</para><para>A <code>NullPointerException</code> is thrown if <code>nsContext</code> is <code>null</code>.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setNamespaceContext
				/// </java-name>
				[Dot42.DexImport("setNamespaceContext", "(Ljavax/xml/namespace/NamespaceContext;)V", AccessFlags = 1025)]
				void SetNamespaceContext(global::Javax.Xml.Namespace.INamespaceContext nsContext) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Return the current namespace context.</para><para><code>null</code> is returned in no namespace context is in effect.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Current Namespace context. </para>
				/// </returns>
				/// <java-name>
				/// getNamespaceContext
				/// </java-name>
				[Dot42.DexImport("getNamespaceContext", "()Ljavax/xml/namespace/NamespaceContext;", AccessFlags = 1025)]
				global::Javax.Xml.Namespace.INamespaceContext GetNamespaceContext() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Compile an XPath expression for later evaluation.</para><para>If <code>expression</code> contains any XPathFunctions, they must be available via the XPathFunctionResolver. An XPathExpressionException will be thrown if the <code>XPathFunction</code> cannot be resolved with the <code>XPathFunctionResolver</code>.</para><para>If <code>expression</code> is <code>null</code>, a <code>NullPointerException</code> is thrown.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Compiled XPath expression.</para>
				/// </returns>
				/// <java-name>
				/// compile
				/// </java-name>
				[Dot42.DexImport("compile", "(Ljava/lang/String;)Ljavax/xml/xpath/XPathExpression;", AccessFlags = 1025)]
				global::Javax.Xml.Xpath.IXPathExpression Compile(string expression) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// evaluate
				/// </java-name>
				[Dot42.DexImport("evaluate", "(Ljava/lang/String;Ljava/lang/Object;Ljavax/xml/namespace/QName;)Ljava/lang/Objec" +
    "t;", AccessFlags = 1025)]
				object Evaluate(string @string, object @object, global::Javax.Xml.Namespace.QName qName) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// evaluate
				/// </java-name>
				[Dot42.DexImport("evaluate", "(Ljava/lang/String;Ljava/lang/Object;)Ljava/lang/String;", AccessFlags = 1025)]
				string Evaluate(string @string, object @object) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// evaluate
				/// </java-name>
				[Dot42.DexImport("evaluate", "(Ljava/lang/String;Lorg/xml/sax/InputSource;Ljavax/xml/namespace/QName;)Ljava/lan" +
    "g/Object;", AccessFlags = 1025)]
				object Evaluate(string @string, global::Org.Xml.Sax.InputSource inputSource, global::Javax.Xml.Namespace.QName qName) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// evaluate
				/// </java-name>
				[Dot42.DexImport("evaluate", "(Ljava/lang/String;Lorg/xml/sax/InputSource;)Ljava/lang/String;", AccessFlags = 1025)]
				string Evaluate(string @string, global::Org.Xml.Sax.InputSource inputSource) /* MethodBuilder.Create */ ;

		}

}


