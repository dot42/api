#pragma warning disable 1717
namespace Javax.Xml.Transform
{
		/// <summary>
		///  <para>To provide customized error handling, implement this interface and use the  <code>setErrorListener</code> method to register an instance of the implementation with the javax.xml.transform.Transformer. The  <code>Transformer</code> then reports all errors and warnings through this interface.</para> <para>If an application does  <b>not</b> register its own custom  <code>ErrorListener</code>, the default  <code>ErrorListener</code> is used which reports all warnings and errors to  <code>System.err</code> and does not throw any  <code>Exception</code>s. Applications are  <b>strongly</b> encouraged to register and use  <code>ErrorListener</code>s that insure proper behavior for warnings and errors.</para> <para>For transformation errors, a  <code>Transformer</code> must use this interface instead of throwing an  <code>Exception</code>: it is up to the application to decide whether to throw an  <code>Exception</code> for different types of errors and warnings. Note however that the  <code>Transformer</code> is not required to continue with the transformation after a call to fatalError(TransformerException exception).</para> <para> <code>Transformer</code>s may use this mechanism to report XML parsing errors as well as transformation errors.</para>    
		/// </summary>
		/// <java-name>
		/// javax/xml/transform/ErrorListener
		/// </java-name>
		[Dot42.DexImport("javax/xml/transform/ErrorListener", AccessFlags = 1537)]
		public partial interface IErrorListener
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Receive notification of a warning.</para> <para>javax.xml.transform.Transformer can use this method to report conditions that are not errors or fatal errors. The default behavior is to take no action.</para> <para>After invoking this method, the Transformer must continue with the transformation. It should still be possible for the application to process the document through to the end.</para> <para> <para>javax.xml.transform.TransformerException </para></para>        
				/// </summary>
				/// <java-name>
				/// warning
				/// </java-name>
				[Dot42.DexImport("warning", "(Ljavax/xml/transform/TransformerException;)V", AccessFlags = 1025)]
				void Warning(global::Javax.Xml.Transform.TransformerException exception) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Receive notification of a recoverable error.</para> <para>The transformer must continue to try and provide normal transformation after invoking this method. It should still be possible for the application to process the document through to the end if no other errors are encountered.</para> <para> <para>javax.xml.transform.TransformerException </para></para>        
				/// </summary>
				/// <java-name>
				/// error
				/// </java-name>
				[Dot42.DexImport("error", "(Ljavax/xml/transform/TransformerException;)V", AccessFlags = 1025)]
				void Error(global::Javax.Xml.Transform.TransformerException exception) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Receive notification of a non-recoverable error.</para> <para>The  <code>Transformer</code> must continue to try and provide normal transformation after invoking this method. It should still be possible for the application to process the document through to the end if no other errors are encountered, but there is no guarantee that the output will be useable.</para> <para> <para>javax.xml.transform.TransformerException </para></para>        
				/// </summary>
				/// <java-name>
				/// fatalError
				/// </java-name>
				[Dot42.DexImport("fatalError", "(Ljavax/xml/transform/TransformerException;)V", AccessFlags = 1025)]
				void FatalError(global::Javax.Xml.Transform.TransformerException exception) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		///  <para>An object that implements this interface contains the information needed to build a transformation result tree.</para> <para> <para> </para></para>    
		/// </summary>
		/// <java-name>
		/// javax/xml/transform/Result
		/// </java-name>
		[Dot42.DexImport("javax/xml/transform/Result", AccessFlags = 1537)]
		public partial interface IResult
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Get the system identifier that was set with setSystemId.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The system identifier that was set with setSystemId, or null if setSystemId was not called. </para>
				/// </returns>
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

		/// <summary>
		///  <para>An object that implements this interface contains the information needed to build a transformation result tree.</para> <para> <para> </para></para>    
		/// </summary>
		/// <java-name>
		/// javax/xml/transform/Result
		/// </java-name>
		[Dot42.DexImport("javax/xml/transform/Result", AccessFlags = 1537, IgnoreFromJava = true, Priority = 1)]
		public static partial class IResultConstants
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>The name of the processing instruction that is sent if the result tree disables output escaping.</para> <para>Normally, result tree serialization escapes &amp; and &lt; (and possibly other characters) when outputting text nodes. This ensures that the output is well-formed XML. However, it is sometimes convenient to be able to produce output that is almost, but not quite well-formed XML; for example, the output may include ill-formed sections that will be transformed into well-formed XML by a subsequent non-XML aware process. If a processing instruction is sent with this name, serialization should be output without any escaping. </para> <para>Result DOM trees may also have PI_DISABLE_OUTPUT_ESCAPING and PI_ENABLE_OUTPUT_ESCAPING inserted into the tree.</para> <para> <para> </para></para>        
				/// </summary>
				/// <java-name>
				/// PI_DISABLE_OUTPUT_ESCAPING
				/// </java-name>
				[Dot42.DexImport("PI_DISABLE_OUTPUT_ESCAPING", "Ljava/lang/String;", AccessFlags = 25)]
				public const string PI_DISABLE_OUTPUT_ESCAPING = "javax.xml.transform.disable-output-escaping";
				/// <summary>
				///  <para>The name of the processing instruction that is sent if the result tree enables output escaping at some point after having received a PI_DISABLE_OUTPUT_ESCAPING processing instruction.</para> <para> <para> </para></para>        
				/// </summary>
				/// <java-name>
				/// PI_ENABLE_OUTPUT_ESCAPING
				/// </java-name>
				[Dot42.DexImport("PI_ENABLE_OUTPUT_ESCAPING", "Ljava/lang/String;", AccessFlags = 25)]
				public const string PI_ENABLE_OUTPUT_ESCAPING = "javax.xml.transform.enable-output-escaping";
		}

		/// <summary>
		///  <para>An object that implements this interface contains the information needed to act as source input (XML source or transformation instructions). </para>    
		/// </summary>
		/// <java-name>
		/// javax/xml/transform/Source
		/// </java-name>
		[Dot42.DexImport("javax/xml/transform/Source", AccessFlags = 1537)]
		public partial interface ISource
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Get the system identifier that was set with setSystemId.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The system identifier that was set with setSystemId, or null if setSystemId was not called. </para>
				/// </returns>
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

		/// <summary>
		///  <para>This interface is primarily for the purposes of reporting where an error occurred in the XML source or transformation instructions. </para>    
		/// </summary>
		/// <java-name>
		/// javax/xml/transform/SourceLocator
		/// </java-name>
		[Dot42.DexImport("javax/xml/transform/SourceLocator", AccessFlags = 1537)]
		public partial interface ISourceLocator
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Return the public identifier for the current document event.</para> <para>The return value is the public identifier of the document entity or of the external parsed entity in which the markup that triggered the event appears.</para> <para> <para>getSystemId </para></para>        
				/// </summary>
				/// <returns>
				///  <para>A string containing the public identifier, or null if none is available. </para>
				/// </returns>
				/// <java-name>
				/// getPublicId
				/// </java-name>
				string PublicId
				{
						[Dot42.DexImport("getPublicId", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Return the system identifier for the current document event.</para> <para>The return value is the system identifier of the document entity or of the external parsed entity in which the markup that triggered the event appears.</para> <para>If the system identifier is a URL, the parser must resolve it fully before passing it to the application.</para> <para> <para>getPublicId </para></para>        
				/// </summary>
				/// <returns>
				///  <para>A string containing the system identifier, or null if none is available. </para>
				/// </returns>
				/// <java-name>
				/// getSystemId
				/// </java-name>
				string SystemId
				{
						[Dot42.DexImport("getSystemId", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Return the line number where the current document event ends.</para> <para> <b>Warning:</b> The return value from the method is intended only as an approximation for the sake of error reporting; it is not intended to provide sufficient information to edit the character content of the original XML document.</para> <para>The return value is an approximation of the line number in the document entity or external parsed entity where the markup that triggered the event appears.</para> <para> <para>getColumnNumber </para></para>        
				/// </summary>
				/// <returns>
				///  <para>The line number, or -1 if none is available. </para>
				/// </returns>
				/// <java-name>
				/// getLineNumber
				/// </java-name>
				int LineNumber
				{
						[Dot42.DexImport("getLineNumber", "()I", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Return the character position where the current document event ends.</para> <para> <b>Warning:</b> The return value from the method is intended only as an approximation for the sake of error reporting; it is not intended to provide sufficient information to edit the character content of the original XML document.</para> <para>The return value is an approximation of the column number in the document entity or external parsed entity where the markup that triggered the event appears.</para> <para> <para>getLineNumber </para></para>        
				/// </summary>
				/// <returns>
				///  <para>The column number, or -1 if none is available. </para>
				/// </returns>
				/// <java-name>
				/// getColumnNumber
				/// </java-name>
				int ColumnNumber
				{
						[Dot42.DexImport("getColumnNumber", "()I", AccessFlags = 1025)]
						get;
				}

		}

		/// <summary>
		///  <para>An object that implements this interface is the runtime representation of processed transformation instructions.</para> <para>Templates must be thread-safe for a given instance over multiple threads running concurrently, and may be used multiple times in a given session.</para>    
		/// </summary>
		/// <java-name>
		/// javax/xml/transform/Templates
		/// </java-name>
		[Dot42.DexImport("javax/xml/transform/Templates", AccessFlags = 1537)]
		public partial interface ITemplates
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Create a new transformation context for this Templates object.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>A valid non-null instance of a Transformer.</para>
				/// </returns>
				/// <java-name>
				/// newTransformer
				/// </java-name>
				[Dot42.DexImport("newTransformer", "()Ljavax/xml/transform/Transformer;", AccessFlags = 1025)]
				global::Javax.Xml.Transform.Transformer NewTransformer() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Get the properties corresponding to the effective xsl:output element. The object returned will be a clone of the internal values. Accordingly, it can be mutated without mutating the Templates object, and then handed in to javax.xml.transform.Transformer#setOutputProperties.</para> <para>The properties returned should contain properties set by the stylesheet, and these properties are "defaulted" by default properties specified by . The properties that were specifically set by the stylesheet should be in the base Properties list, while the XSLT default properties that were not specifically set should be in the "default" Properties list. Thus, getOutputProperties().getProperty(String key) will obtain any property in that was set by the stylesheet,  <b>or</b> the default properties, while getOutputProperties().get(String key) will only retrieve properties that were explicitly set in the stylesheet.</para> <para>For XSLT,  attribute values will be returned unexpanded (since there is no context at this point). The namespace prefixes inside Attribute Value Templates will be unexpanded, so that they remain valid XPath values.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>A Properties object, never null. </para>
				/// </returns>
				/// <java-name>
				/// getOutputProperties
				/// </java-name>
				global::Java.Util.Properties OutputProperties
				{
						[Dot42.DexImport("getOutputProperties", "()Ljava/util/Properties;", AccessFlags = 1025)]
						get;
				}

		}

		/// <summary>
		///  <para>An object that implements this interface that can be called by the processor to turn a URI used in document(), xsl:import, or xsl:include into a Source object. </para>    
		/// </summary>
		/// <java-name>
		/// javax/xml/transform/URIResolver
		/// </java-name>
		[Dot42.DexImport("javax/xml/transform/URIResolver", AccessFlags = 1537)]
		public partial interface IURIResolver
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Called by the processor when it encounters an xsl:include, xsl:import, or document() function.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>A Source object, or null if the href cannot be resolved, and the processor should try to resolve the URI itself.</para>
				/// </returns>
				/// <java-name>
				/// resolve
				/// </java-name>
				[Dot42.DexImport("resolve", "(Ljava/lang/String;Ljava/lang/String;)Ljavax/xml/transform/Source;", AccessFlags = 1025)]
				global::Javax.Xml.Transform.ISource Resolve(string href, string @base) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		///  <para>Provides string constants that can be used to set output properties for a Transformer, or to retrieve output properties from a Transformer or Templates object. </para> <para>All the fields in this class are read-only.</para> <para> <para> </para></para>    
		/// </summary>
		/// <java-name>
		/// javax/xml/transform/OutputKeys
		/// </java-name>
		[Dot42.DexImport("javax/xml/transform/OutputKeys", AccessFlags = 33)]
		public partial class OutputKeys
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>method = "xml" | "html" | "text" |  <b>expanded name</b>.</para> <para>The value of the method property identifies the overall method that should be used for outputting the result tree. Other non-namespaced values may be used, such as "xhtml", but, if accepted, the handling of such values is implementation defined. If any of the method values are not accepted and are not namespace qualified, then javax.xml.transform.Transformer#setOutputProperty or javax.xml.transform.Transformer#setOutputProperties will throw a java.lang.IllegalArgumentException.</para> <para> <para> </para></para>        
				/// </summary>
				/// <java-name>
				/// METHOD
				/// </java-name>
				[Dot42.DexImport("METHOD", "Ljava/lang/String;", AccessFlags = 25)]
				public const string METHOD = "method";
				/// <summary>
				///  <para>version =  <b>nmtoken</b>.</para> <para> <code>version</code> specifies the version of the output method.</para> <para>When the output method is "xml", the version value specifies the version of XML to be used for outputting the result tree. The default value for the xml output method is 1.0. When the output method is "html", the version value indicates the version of the HTML. The default value for the xml output method is 4.0, which specifies that the result should be output as HTML conforming to the HTML 4.0 Recommendation [HTML]. If the output method is "text", the version property is ignored.</para> <para> <para> </para></para>        
				/// </summary>
				/// <java-name>
				/// VERSION
				/// </java-name>
				[Dot42.DexImport("VERSION", "Ljava/lang/String;", AccessFlags = 25)]
				public const string VERSION = "version";
				/// <summary>
				///  <para>encoding =  <b>string</b>.</para> <para> <code>encoding</code> specifies the preferred character encoding that the Transformer should use to encode sequences of characters as sequences of bytes. The value of the encoding property should be treated case-insensitively. The value must only contain characters in the range #x21 to #x7E (i.e., printable ASCII characters). The value should either be a  <code>charset</code> registered with the Internet Assigned Numbers Authority ,  or start with  <code>X-</code>.</para> <para> <para> </para></para>        
				/// </summary>
				/// <java-name>
				/// ENCODING
				/// </java-name>
				[Dot42.DexImport("ENCODING", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ENCODING = "encoding";
				/// <summary>
				///  <para>omit-xml-declaration = "yes" | "no".</para> <para> <code>omit-xml-declaration</code> specifies whether the XSLT processor should output an XML declaration; the value must be  <code>yes</code> or  <code>no</code>.</para> <para> <para> </para></para>        
				/// </summary>
				/// <java-name>
				/// OMIT_XML_DECLARATION
				/// </java-name>
				[Dot42.DexImport("OMIT_XML_DECLARATION", "Ljava/lang/String;", AccessFlags = 25)]
				public const string OMIT_XML_DECLARATION = "omit-xml-declaration";
				/// <summary>
				///  <para>standalone = "yes" | "no".</para> <para> <code>standalone</code> specifies whether the Transformer should output a standalone document declaration; the value must be  <code>yes</code> or  <code>no</code>.</para> <para> <para> </para></para>        
				/// </summary>
				/// <java-name>
				/// STANDALONE
				/// </java-name>
				[Dot42.DexImport("STANDALONE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string STANDALONE = "standalone";
				/// <summary>
				///  <para>doctype-public =  <b>string</b>. </para> <para>See the documentation for the DOCTYPE_SYSTEM property for a description of what the value of the key should be.</para> <para> <para> </para></para>        
				/// </summary>
				/// <java-name>
				/// DOCTYPE_PUBLIC
				/// </java-name>
				[Dot42.DexImport("DOCTYPE_PUBLIC", "Ljava/lang/String;", AccessFlags = 25)]
				public const string DOCTYPE_PUBLIC = "doctype-public";
				/// <summary>
				///  <para>doctype-system =  <b>string</b>. </para> <para> <code>doctype-system</code> specifies the system identifier to be used in the document type declaration.</para> <para>If the doctype-system property is specified, the xml output method should output a document type declaration immediately before the first element. The name following &lt;!DOCTYPE should be the name of the first element. If doctype-public property is also specified, then the xml output method should output PUBLIC followed by the public identifier and then the system identifier; otherwise, it should output SYSTEM followed by the system identifier. The internal subset should be empty. The value of the doctype-public property should be ignored unless the doctype-system property is specified.</para> <para>If the doctype-public or doctype-system properties are specified, then the html output method should output a document type declaration immediately before the first element. The name following &lt;!DOCTYPE should be HTML or html. If the doctype-public property is specified, then the output method should output PUBLIC followed by the specified public identifier; if the doctype-system property is also specified, it should also output the specified system identifier following the public identifier. If the doctype-system property is specified but the doctype-public property is not specified, then the output method should output SYSTEM followed by the specified system identifier.</para> <para> <code>doctype-system</code> specifies the system identifier to be used in the document type declaration.</para> <para> <para> </para></para>        
				/// </summary>
				/// <java-name>
				/// DOCTYPE_SYSTEM
				/// </java-name>
				[Dot42.DexImport("DOCTYPE_SYSTEM", "Ljava/lang/String;", AccessFlags = 25)]
				public const string DOCTYPE_SYSTEM = "doctype-system";
				/// <summary>
				///  <para>cdata-section-elements =  <b>expanded names</b>.</para> <para> <code>cdata-section-elements</code> specifies a whitespace delimited list of the names of elements whose text node children should be output using CDATA sections. Note that these names must use the format described in the section Qualfied Name Representation in javax.xml.transform.</para> <para> <para> </para></para>        
				/// </summary>
				/// <java-name>
				/// CDATA_SECTION_ELEMENTS
				/// </java-name>
				[Dot42.DexImport("CDATA_SECTION_ELEMENTS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string CDATA_SECTION_ELEMENTS = "cdata-section-elements";
				/// <summary>
				///  <para>indent = "yes" | "no".</para> <para> <code>indent</code> specifies whether the Transformer may add additional whitespace when outputting the result tree; the value must be  <code>yes</code> or  <code>no</code>. </para> <para> <para> </para></para>        
				/// </summary>
				/// <java-name>
				/// INDENT
				/// </java-name>
				[Dot42.DexImport("INDENT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string INDENT = "indent";
				/// <summary>
				///  <para>media-type =  <b>string</b>.</para> <para> <code>media-type</code> specifies the media type (MIME content type) of the data that results from outputting the result tree. The  <code>charset</code> parameter should not be specified explicitly; instead, when the top-level media type is  <code>text</code>, a  <code>charset</code> parameter should be added according to the character encoding actually used by the output method. </para> <para> <para> </para></para>        
				/// </summary>
				/// <java-name>
				/// MEDIA_TYPE
				/// </java-name>
				[Dot42.DexImport("MEDIA_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string MEDIA_TYPE = "media-type";
				/// <summary>
				///  <para>Default constructor is private on purpose. This class is only for static variable access, and should never be constructed. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal OutputKeys() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>An instance of this abstract class can transform a source tree into a result tree.</para> <para>An instance of this class can be obtained with the TransformerFactory.newTransformer method. This instance may then be used to process XML from a variety of sources and write the transformation output to a variety of sinks.</para> <para>An object of this class may not be used in multiple threads running concurrently. Different Transformers may be used concurrently by different threads.</para> <para>A  <code>Transformer</code> may be used multiple times. Parameters and output properties are preserved across transformations.</para> <para> <para> </para> <para></para> <title>Revision</title> <para>570103 </para>,  <title>Date</title> <para>2007-08-27 06:24:55 -0700 (Mon, 27 Aug 2007) </para></para>    
		/// </summary>
		/// <java-name>
		/// javax/xml/transform/Transformer
		/// </java-name>
		[Dot42.DexImport("javax/xml/transform/Transformer", AccessFlags = 1057)]
		public abstract partial class Transformer
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Default constructor is protected on purpose. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal Transformer() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Reset this  <code>Transformer</code> to its original configuration.</para> <para> <code>Transformer</code> is reset to the same state as when it was created with TransformerFactory#newTransformer(), TransformerFactory#newTransformer(Source source) or Templates#newTransformer().  <code>reset()</code> is designed to allow the reuse of existing  <code>Transformer</code>s thus saving resources associated with the creation of new  <code>Transformer</code>s.</para> <para>The reset  <code>Transformer</code> is not guaranteed to have the same URIResolver or ErrorListener  <code>Object</code>s, e.g. Object#equals(Object obj). It is guaranteed to have a functionally equal  <code>URIResolver</code> and  <code>ErrorListener</code>.</para> <para> <para>1.5 </para></para>        
				/// </summary>
				/// <java-name>
				/// reset
				/// </java-name>
				[Dot42.DexImport("reset", "()V", AccessFlags = 1)]
				public virtual void Reset() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Transform the XML  <code>Source</code> to a  <code>Result</code>. Specific transformation behavior is determined by the settings of the  <code>TransformerFactory</code> in effect when the  <code>Transformer</code> was instantiated and any modifications made to the  <code>Transformer</code> instance.</para> <para>An empty  <code>Source</code> is represented as an empty document as constructed by javax.xml.parsers.DocumentBuilder#newDocument(). The result of transforming an empty  <code>Source</code> depends on the transformation behavior; it is not always an empty  <code>Result</code>.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// transform
				/// </java-name>
				[Dot42.DexImport("transform", "(Ljavax/xml/transform/Source;Ljavax/xml/transform/Result;)V", AccessFlags = 1025)]
				public abstract void Transform(global::Javax.Xml.Transform.ISource xmlSource, global::Javax.Xml.Transform.IResult outputTarget) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Add a parameter for the transformation.</para> <para>Pass a qualified name as a two-part string, the namespace URI enclosed in curly braces ({}), followed by the local name. If the name has a null URL, the String only contain the local name. An application can safely check for a non-null URI by testing to see if the first character of the name is a '{' character.</para> <para>For example, if a URI and local name were obtained from an element defined with &lt;xyz:foo xmlns:xyz="http://xyz.foo.com/yada/baz.html"/&gt;, then the qualified name would be "{http://xyz.foo.com/yada/baz.html}foo". Note that no prefix is used.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setParameter
				/// </java-name>
				[Dot42.DexImport("setParameter", "(Ljava/lang/String;Ljava/lang/Object;)V", AccessFlags = 1025)]
				public abstract void SetParameter(string name, object value) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Get a parameter that was explicitly set with setParameter.</para> <para>This method does not return a default parameter value, which cannot be determined until the node context is evaluated during the transformation process.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>A parameter that has been set with setParameter. </para>
				/// </returns>
				/// <java-name>
				/// getParameter
				/// </java-name>
				[Dot42.DexImport("getParameter", "(Ljava/lang/String;)Ljava/lang/Object;", AccessFlags = 1025)]
				public abstract object GetParameter(string name) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Set a list of parameters.</para> <para>Note that the list of parameters is specified as a  <code>Properties</code>  <code>Object</code> which limits the parameter values to  <code>String</code>s. Multiple calls to setParameter(String name, Object value) should be used when the desired values are non- <code>String</code>  <code>Object</code>s. The parameter names should conform as specified in setParameter(String name, Object value). An  <code>IllegalArgumentException</code> is thrown if any names do not conform.</para> <para>New parameters in the list are added to any existing parameters. If the name of a new parameter is equal to the name of an existing parameter as determined by java.lang.Object#equals(Object obj), the existing parameter is set to the new value.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// clearParameters
				/// </java-name>
				[Dot42.DexImport("clearParameters", "()V", AccessFlags = 1025)]
				public abstract void ClearParameters() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Set an output property that will be in effect for the transformation.</para> <para>Pass a qualified property name as a two-part string, the namespace URI enclosed in curly braces ({}), followed by the local name. If the name has a null URL, the String only contain the local name. An application can safely check for a non-null URI by testing to see if the first character of the name is a '{' character.</para> <para>For example, if a URI and local name were obtained from an element defined with &lt;xyz:foo xmlns:xyz="http://xyz.foo.com/yada/baz.html"/&gt;, then the qualified name would be "{http://xyz.foo.com/yada/baz.html}foo". Note that no prefix is used.</para> <para>The Properties object that was passed to setOutputProperties won't be effected by calling this method.</para> <para> <para>javax.xml.transform.OutputKeys </para></para>        
				/// </summary>
				/// <java-name>
				/// setOutputProperty
				/// </java-name>
				[Dot42.DexImport("setOutputProperty", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1025)]
				public abstract void SetOutputProperty(string name, string value) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Get an output property that is in effect for the transformer. The property specified may be a property that was set with setOutputProperty, or it may be a property specified in the stylesheet.</para> <para> <para>javax.xml.transform.OutputKeys </para></para>        
				/// </summary>
				/// <returns>
				///  <para>The string value of the output property, or null if no property was found.</para>
				/// </returns>
				/// <java-name>
				/// getOutputProperty
				/// </java-name>
				[Dot42.DexImport("getOutputProperty", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1025)]
				public abstract string GetOutputProperty(string name) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Get an object that will be used to resolve URIs used in document().</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>An object that implements the URIResolver interface, or null. </para>
				/// </returns>
				/// <java-name>
				/// getURIResolver
				/// </java-name>
				public abstract global::Javax.Xml.Transform.IURIResolver URIResolver
				{
						[Dot42.DexImport("getURIResolver", "()Ljavax/xml/transform/URIResolver;", AccessFlags = 1025)]
						get;
						[Dot42.DexImport("setURIResolver", "(Ljavax/xml/transform/URIResolver;)V", AccessFlags = 1025)]
						set;
				}

				/// <summary>
				///  <para>Get a copy of the output properties for the transformation.</para> <para>The properties returned should contain properties set by the user, and properties set by the stylesheet, and these properties are "defaulted" by default properties specified by . The properties that were specifically set by the user or the stylesheet should be in the base Properties list, while the XSLT default properties that were not specifically set should be the default Properties list. Thus, getOutputProperties().getProperty(String key) will obtain any property in that was set by setOutputProperty, setOutputProperties, in the stylesheet,  <b>or</b> the default properties, while getOutputProperties().get(String key) will only retrieve properties that were explicitly set by setOutputProperty, setOutputProperties, or in the stylesheet.</para> <para>Note that mutation of the Properties object returned will not effect the properties that the transformer contains.</para> <para>If any of the argument keys are not recognized and are not namespace qualified, the property will be ignored and not returned. In other words the behavior is not orthogonal with setOutputProperties.</para> <para> <para>javax.xml.transform.OutputKeys </para> <para>java.util.Properties </para> <para> </para></para>        
				/// </summary>
				/// <returns>
				///  <para>A copy of the set of output properties in effect for the next transformation.</para>
				/// </returns>
				/// <java-name>
				/// getOutputProperties
				/// </java-name>
				public abstract global::Java.Util.Properties OutputProperties
				{
						[Dot42.DexImport("getOutputProperties", "()Ljava/util/Properties;", AccessFlags = 1025)]
						get;
						[Dot42.DexImport("setOutputProperties", "(Ljava/util/Properties;)V", AccessFlags = 1025)]
						set;
				}

				/// <summary>
				///  <para>Get the error event handler in effect for the transformation. Implementations must provide a default error listener.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The current error handler, which should never be null. </para>
				/// </returns>
				/// <java-name>
				/// getErrorListener
				/// </java-name>
				public abstract global::Javax.Xml.Transform.IErrorListener ErrorListener
				{
						[Dot42.DexImport("getErrorListener", "()Ljavax/xml/transform/ErrorListener;", AccessFlags = 1025)]
						get;
						[Dot42.DexImport("setErrorListener", "(Ljavax/xml/transform/ErrorListener;)V", AccessFlags = 1025)]
						set;
				}

		}

		/// <summary>
		///  <para>Indicates a serious configuration error. </para>    
		/// </summary>
		/// <java-name>
		/// javax/xml/transform/TransformerConfigurationException
		/// </java-name>
		[Dot42.DexImport("javax/xml/transform/TransformerConfigurationException", AccessFlags = 33)]
		public partial class TransformerConfigurationException : global::Javax.Xml.Transform.TransformerException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Create a new  <code>TransformerConfigurationException</code> with no detail message. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public TransformerConfigurationException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public TransformerConfigurationException(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public TransformerConfigurationException(global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public TransformerConfigurationException(string @string, global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljavax/xml/transform/SourceLocator;)V", AccessFlags = 1)]
				public TransformerConfigurationException(string @string, global::Javax.Xml.Transform.ISourceLocator sourceLocator) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Wrap an existing exception in a TransformerConfigurationException.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljavax/xml/transform/SourceLocator;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public TransformerConfigurationException(string message, global::Javax.Xml.Transform.ISourceLocator locator, global::System.Exception e) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>This class specifies an exceptional condition that occurred during the transformation process. </para>    
		/// </summary>
		/// <java-name>
		/// javax/xml/transform/TransformerException
		/// </java-name>
		[Dot42.DexImport("javax/xml/transform/TransformerException", AccessFlags = 33)]
		public partial class TransformerException : global::System.Exception
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public TransformerException(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public TransformerException(global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public TransformerException(string @string, global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljavax/xml/transform/SourceLocator;)V", AccessFlags = 1)]
				public TransformerException(string @string, global::Javax.Xml.Transform.ISourceLocator sourceLocator) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Wrap an existing exception in a TransformerException.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljavax/xml/transform/SourceLocator;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public TransformerException(string message, global::Javax.Xml.Transform.ISourceLocator locator, global::System.Exception e) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Initializes the  <b>cause</b> of this throwable to the specified value. (The cause is the throwable that caused this throwable to get thrown.)</para> <para>This method can be called at most once. It is generally called from within the constructor, or immediately after creating the throwable. If this throwable was created with TransformerException(Throwable) or TransformerException(String,Throwable), this method cannot be called even once.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a reference to this  <code>Throwable</code> instance. </para>
				/// </returns>
				/// <java-name>
				/// initCause
				/// </java-name>
				[Dot42.DexImport("initCause", "(Ljava/lang/Throwable;)Ljava/lang/Throwable;", AccessFlags = 33)]
				public override global::System.Exception InitCause(global::System.Exception cause) /* MethodBuilder.Create */ 
				{
						return default(global::System.Exception);
				}

				/// <summary>
				///  <para>Print the the trace of methods from where the error originated. This will trace all nested exception objects, as well as this object. </para>        
				/// </summary>
				/// <java-name>
				/// printStackTrace
				/// </java-name>
				[Dot42.DexImport("printStackTrace", "()V", AccessFlags = 1)]
				public override void PrintStackTrace() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Print the the trace of methods from where the error originated. This will trace all nested exception objects, as well as this object. </para>        
				/// </summary>
				/// <java-name>
				/// printStackTrace
				/// </java-name>
				[Dot42.DexImport("printStackTrace", "(Ljava/io/PrintStream;)V", AccessFlags = 1)]
				public override void PrintStackTrace(global::Java.IO.PrintStream s) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Print the the trace of methods from where the error originated. This will trace all nested exception objects, as well as this object. </para>        
				/// </summary>
				/// <java-name>
				/// printStackTrace
				/// </java-name>
				[Dot42.DexImport("printStackTrace", "(Ljava/io/PrintWriter;)V", AccessFlags = 1)]
				public override void PrintStackTrace(global::Java.IO.PrintWriter s) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal TransformerException() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Method getLocator retrieves an instance of a SourceLocator object that specifies where an error occurred.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>A SourceLocator object, or null if none was specified. </para>
				/// </returns>
				/// <java-name>
				/// getLocator
				/// </java-name>
				public virtual global::Javax.Xml.Transform.ISourceLocator Locator
				{
						[Dot42.DexImport("getLocator", "()Ljavax/xml/transform/SourceLocator;", AccessFlags = 1)]
						get{ return default(global::Javax.Xml.Transform.ISourceLocator); }
						[Dot42.DexImport("setLocator", "(Ljavax/xml/transform/SourceLocator;)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>This method retrieves an exception that this exception wraps.</para> <para> <para>getCause </para></para>        
				/// </summary>
				/// <returns>
				///  <para>An Throwable object, or null. </para>
				/// </returns>
				/// <java-name>
				/// getException
				/// </java-name>
				public virtual global::System.Exception Exception
				{
						[Dot42.DexImport("getException", "()Ljava/lang/Throwable;", AccessFlags = 1)]
						get{ return default(global::System.Exception); }
				}

				/// <summary>
				///  <para>Returns the cause of this throwable or  <code>null</code> if the cause is nonexistent or unknown. (The cause is the throwable that caused this throwable to get thrown.) </para>        
				/// </summary>
				/// <java-name>
				/// getCause
				/// </java-name>
				public override global::System.Exception Cause
				{
						[Dot42.DexImport("getCause", "()Ljava/lang/Throwable;", AccessFlags = 1)]
						get{ return default(global::System.Exception); }
				}

				/// <summary>
				///  <para>Get the error message with location information appended.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>A  <code>String</code> representing the error message with location information appended. </para>
				/// </returns>
				/// <java-name>
				/// getMessageAndLocation
				/// </java-name>
				public virtual string MessageAndLocation
				{
						[Dot42.DexImport("getMessageAndLocation", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>Get the location information as a string.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>A string with location info, or null if there is no location information. </para>
				/// </returns>
				/// <java-name>
				/// getLocationAsString
				/// </java-name>
				public virtual string LocationAsString
				{
						[Dot42.DexImport("getLocationAsString", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

		}

		/// <summary>
		///  <para>A TransformerFactory instance can be used to create javax.xml.transform.Transformer and javax.xml.transform.Templates objects.</para> <para>The system property that determines which Factory implementation to create is named  <code>"javax.xml.transform.TransformerFactory"</code>. This property names a concrete subclass of the  <code>TransformerFactory</code> abstract class. If the property is not defined, a platform default is be used.</para> <para> <para> </para></para>    
		/// </summary>
		/// <java-name>
		/// javax/xml/transform/TransformerFactory
		/// </java-name>
		[Dot42.DexImport("javax/xml/transform/TransformerFactory", AccessFlags = 1057)]
		public abstract partial class TransformerFactory
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Default constructor is protected on purpose. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal TransformerFactory() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Get current state of canonicalization.</para> <para>Set canonicalization control to  <code>true</code> or false.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>current state canonicalization control </para>
				/// </returns>
				/// <java-name>
				/// newInstance
				/// </java-name>
				[Dot42.DexImport("newInstance", "()Ljavax/xml/transform/TransformerFactory;", AccessFlags = 9)]
				public static global::Javax.Xml.Transform.TransformerFactory NewInstance() /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Xml.Transform.TransformerFactory);
				}

				/// <summary>
				///  <para>Returns an instance of the named implementation of <c>TransformerFactory </c> .</para> <para> <para>1.6 </para></para>        
				/// </summary>
				/// <java-name>
				/// newInstance
				/// </java-name>
				[Dot42.DexImport("newInstance", "(Ljava/lang/String;Ljava/lang/ClassLoader;)Ljavax/xml/transform/TransformerFactor" +
    "y;", AccessFlags = 9)]
				public static global::Javax.Xml.Transform.TransformerFactory NewInstance(string factoryClassName, global::Java.Lang.ClassLoader classLoader) /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Xml.Transform.TransformerFactory);
				}

				/// <summary>
				///  <para>Process the  <code>Source</code> into a  <code>Transformer</code>  <code>Object</code>. The  <code>Source</code> is an XSLT document that conforms to . Care must be taken not to use this  <code>Transformer</code> in multiple  <code>Thread</code>s running concurrently. Different  <code>TransformerFactories</code> can be used concurrently by different  <code>Thread</code>s.</para> <para> <para> </para></para>        
				/// </summary>
				/// <returns>
				///  <para>A  <code>Transformer</code> object that may be used to perform a transformation in a single  <code>Thread</code>, never  <code>null</code>.</para>
				/// </returns>
				/// <java-name>
				/// newTransformer
				/// </java-name>
				[Dot42.DexImport("newTransformer", "(Ljavax/xml/transform/Source;)Ljavax/xml/transform/Transformer;", AccessFlags = 1025)]
				public abstract global::Javax.Xml.Transform.Transformer NewTransformer(global::Javax.Xml.Transform.ISource source) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Create a new  <code>Transformer</code> that performs a copy of the  <code>Source</code> to the  <code>Result</code>. i.e. the "&lt;em&gt;identity transform&lt;/em&gt;".</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>A Transformer object that may be used to perform a transformation in a single thread, never null.</para>
				/// </returns>
				/// <java-name>
				/// newTransformer
				/// </java-name>
				[Dot42.DexImport("newTransformer", "()Ljavax/xml/transform/Transformer;", AccessFlags = 1025)]
				public abstract global::Javax.Xml.Transform.Transformer NewTransformer() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Process the Source into a Templates object, which is a a compiled representation of the source. This Templates object may then be used concurrently across multiple threads. Creating a Templates object allows the TransformerFactory to do detailed performance optimization of transformation instructions, without penalizing runtime transformation.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>A Templates object capable of being used for transformation purposes, never null.</para>
				/// </returns>
				/// <java-name>
				/// newTemplates
				/// </java-name>
				[Dot42.DexImport("newTemplates", "(Ljavax/xml/transform/Source;)Ljavax/xml/transform/Templates;", AccessFlags = 1025)]
				public abstract global::Javax.Xml.Transform.ITemplates NewTemplates(global::Javax.Xml.Transform.ISource source) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Get the stylesheet specification(s) associated with the XML  <code>Source</code> document via the  that match the given criteria. Note that it is possible to return several stylesheets, in which case they are applied as if they were a list of imports or cascades in a single stylesheet.</para> <para> <para> </para></para>        
				/// </summary>
				/// <returns>
				///  <para>A  <code>Source</code>  <code>Object</code> suitable for passing to the  <code>TransformerFactory</code>.</para>
				/// </returns>
				/// <java-name>
				/// getAssociatedStylesheet
				/// </java-name>
				[Dot42.DexImport("getAssociatedStylesheet", "(Ljavax/xml/transform/Source;Ljava/lang/String;Ljava/lang/String;Ljava/lang/Strin" +
    "g;)Ljavax/xml/transform/Source;", AccessFlags = 1025)]
				public abstract global::Javax.Xml.Transform.ISource GetAssociatedStylesheet(global::Javax.Xml.Transform.ISource source, string media, string title, string charset) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Set a feature for this  <code>TransformerFactory</code> and  <code>Transformer</code>s or  <code>Template</code>s created by this factory.</para> <para>Feature names are fully qualified java.net.URIs. Implementations may define their own features. An TransformerConfigurationException is thrown if this  <code>TransformerFactory</code> or the  <code>Transformer</code>s or  <code>Template</code>s it creates cannot support the feature. It is possible for an  <code>TransformerFactory</code> to expose a feature value but be unable to change its state. </para> <para>All implementations are required to support the javax.xml.XMLConstants#FEATURE_SECURE_PROCESSING feature. When the feature is:</para> <para> <ul> <li> <para> <code>true</code>: the implementation will limit XML processing to conform to implementation limits and behave in a secure fashion as defined by the implementation. Examples include resolving user defined style sheets and functions. If XML processing is limited for security reasons, it will be reported via a call to the registered ErrorListener#fatalError(TransformerException exception). See setErrorListener(ErrorListener listener).  </para></li> <li> <para> <code>false</code>: the implementation will processing XML according to the XML specifications without regard to possible implementation limits.  </para></li></ul></para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setFeature
				/// </java-name>
				[Dot42.DexImport("setFeature", "(Ljava/lang/String;Z)V", AccessFlags = 1025)]
				public abstract void SetFeature(string name, bool value) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Look up the value of a feature.</para> <para>Feature names are fully qualified java.net.URIs. Implementations may define their own features.  <code>false</code> is returned if this  <code>TransformerFactory</code> or the  <code>Transformer</code>s or  <code>Template</code>s it creates cannot support the feature. It is possible for an  <code>TransformerFactory</code> to expose a feature value but be unable to change its state. </para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The current state of the feature,  <code>true</code> or  <code>false</code>.</para>
				/// </returns>
				/// <java-name>
				/// getFeature
				/// </java-name>
				[Dot42.DexImport("getFeature", "(Ljava/lang/String;)Z", AccessFlags = 1025)]
				public abstract bool GetFeature(string name) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Allows the user to set specific attributes on the underlying implementation. An attribute in this context is defined to be an option that the implementation provides. An  <code>IllegalArgumentException</code> is thrown if the underlying implementation doesn't recognize the attribute.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setAttribute
				/// </java-name>
				[Dot42.DexImport("setAttribute", "(Ljava/lang/String;Ljava/lang/Object;)V", AccessFlags = 1025)]
				public abstract void SetAttribute(string name, object value) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Allows the user to retrieve specific attributes on the underlying implementation. An  <code>IllegalArgumentException</code> is thrown if the underlying implementation doesn't recognize the attribute.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>value The value of the attribute. </para>
				/// </returns>
				/// <java-name>
				/// getAttribute
				/// </java-name>
				[Dot42.DexImport("getAttribute", "(Ljava/lang/String;)Ljava/lang/Object;", AccessFlags = 1025)]
				public abstract object GetAttribute(string name) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Get the object that is used by default during the transformation to resolve URIs used in document(), xsl:import, or xsl:include.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The URIResolver that was set with setURIResolver. </para>
				/// </returns>
				/// <java-name>
				/// getURIResolver
				/// </java-name>
				public abstract global::Javax.Xml.Transform.IURIResolver URIResolver
				{
						[Dot42.DexImport("getURIResolver", "()Ljavax/xml/transform/URIResolver;", AccessFlags = 1025)]
						get;
						[Dot42.DexImport("setURIResolver", "(Ljavax/xml/transform/URIResolver;)V", AccessFlags = 1025)]
						set;
				}

				/// <summary>
				///  <para>Get the error event handler for the TransformerFactory.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The current error handler, which should never be null. </para>
				/// </returns>
				/// <java-name>
				/// getErrorListener
				/// </java-name>
				public abstract global::Javax.Xml.Transform.IErrorListener ErrorListener
				{
						[Dot42.DexImport("getErrorListener", "()Ljavax/xml/transform/ErrorListener;", AccessFlags = 1025)]
						get;
						[Dot42.DexImport("setErrorListener", "(Ljavax/xml/transform/ErrorListener;)V", AccessFlags = 1025)]
						set;
				}

		}

		/// <summary>
		///  <para>Thrown when a problem with configuration with the Transformer Factories exists. This error will typically be thrown when the class of a transformation factory specified in the system properties cannot be found or instantiated. </para>    
		/// </summary>
		/// <java-name>
		/// javax/xml/transform/TransformerFactoryConfigurationError
		/// </java-name>
		[Dot42.DexImport("javax/xml/transform/TransformerFactoryConfigurationError", AccessFlags = 33)]
		public partial class TransformerFactoryConfigurationError : global::Java.Lang.Error
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Create a new  <code>TransformerFactoryConfigurationError</code> with no detail message. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public TransformerFactoryConfigurationError() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public TransformerFactoryConfigurationError(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/Exception;)V", AccessFlags = 1)]
				public TransformerFactoryConfigurationError(global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Create a new  <code>TransformerFactoryConfigurationError</code> with the given  <code>Exception</code> base cause and detail message.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/Exception;Ljava/lang/String;)V", AccessFlags = 1)]
				public TransformerFactoryConfigurationError(global::System.Exception e, string msg) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Return the message (if any) for this error . If there is no message for the exception and there is an encapsulated exception then the message of that exception will be returned.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The error message. </para>
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
				///  <para>Return the actual exception (if any) that caused this exception to be raised.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The encapsulated exception, or null if there is none. </para>
				/// </returns>
				/// <java-name>
				/// getException
				/// </java-name>
				public virtual global::System.Exception Exception
				{
						[Dot42.DexImport("getException", "()Ljava/lang/Exception;", AccessFlags = 1)]
						get{ return default(global::System.Exception); }
				}

		}

}

