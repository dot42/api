#pragma warning disable 1717
namespace Javax.Xml.Xpath
{
		/// <java-name>
		/// javax/xml/xpath/XPath
		/// </java-name>
		[Dot42.DexImport("javax/xml/xpath/XPath", AccessFlags = 1537)]
		public partial interface IXPath
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// reset
				/// </java-name>
				[Dot42.DexImport("reset", "()V", AccessFlags = 1025)]
				void Reset() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// compile
				/// </java-name>
				[Dot42.DexImport("compile", "(Ljava/lang/String;)Ljavax/xml/xpath/XPathExpression;", AccessFlags = 1025)]
				global::Javax.Xml.Xpath.IXPathExpression Compile(string @string) /* MethodBuilder.Create */ ;

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

				/// <java-name>
				/// getXPathVariableResolver
				/// </java-name>
				global::Javax.Xml.Xpath.IXPathVariableResolver XPathVariableResolver
				{
						[Dot42.DexImport("getXPathVariableResolver", "()Ljavax/xml/xpath/XPathVariableResolver;", AccessFlags = 1025)]
						get;
						[Dot42.DexImport("setXPathVariableResolver", "(Ljavax/xml/xpath/XPathVariableResolver;)V", AccessFlags = 1025)]
						set;
				}

				/// <java-name>
				/// getXPathFunctionResolver
				/// </java-name>
				global::Javax.Xml.Xpath.IXPathFunctionResolver XPathFunctionResolver
				{
						[Dot42.DexImport("getXPathFunctionResolver", "()Ljavax/xml/xpath/XPathFunctionResolver;", AccessFlags = 1025)]
						get;
						[Dot42.DexImport("setXPathFunctionResolver", "(Ljavax/xml/xpath/XPathFunctionResolver;)V", AccessFlags = 1025)]
						set;
				}

				/// <java-name>
				/// getNamespaceContext
				/// </java-name>
				global::Javax.Xml.Namespace.INamespaceContext NamespaceContext
				{
						[Dot42.DexImport("getNamespaceContext", "()Ljavax/xml/namespace/NamespaceContext;", AccessFlags = 1025)]
						get;
						[Dot42.DexImport("setNamespaceContext", "(Ljavax/xml/namespace/NamespaceContext;)V", AccessFlags = 1025)]
						set;
				}

		}

		/// <java-name>
		/// javax/xml/xpath/XPathExpression
		/// </java-name>
		[Dot42.DexImport("javax/xml/xpath/XPathExpression", AccessFlags = 1537)]
		public partial interface IXPathExpression
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// evaluate
				/// </java-name>
				[Dot42.DexImport("evaluate", "(Ljava/lang/Object;Ljavax/xml/namespace/QName;)Ljava/lang/Object;", AccessFlags = 1025)]
				object Evaluate(object @object, global::Javax.Xml.Namespace.QName qName) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// evaluate
				/// </java-name>
				[Dot42.DexImport("evaluate", "(Ljava/lang/Object;)Ljava/lang/String;", AccessFlags = 1025)]
				string Evaluate(object @object) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// evaluate
				/// </java-name>
				[Dot42.DexImport("evaluate", "(Lorg/xml/sax/InputSource;Ljavax/xml/namespace/QName;)Ljava/lang/Object;", AccessFlags = 1025)]
				object Evaluate(global::Org.Xml.Sax.InputSource inputSource, global::Javax.Xml.Namespace.QName qName) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// evaluate
				/// </java-name>
				[Dot42.DexImport("evaluate", "(Lorg/xml/sax/InputSource;)Ljava/lang/String;", AccessFlags = 1025)]
				string Evaluate(global::Org.Xml.Sax.InputSource inputSource) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// javax/xml/xpath/XPathFunction
		/// </java-name>
		[Dot42.DexImport("javax/xml/xpath/XPathFunction", AccessFlags = 1537)]
		public partial interface IXPathFunction
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// evaluate
				/// </java-name>
				[Dot42.DexImport("evaluate", "(Ljava/util/List;)Ljava/lang/Object;", AccessFlags = 1025)]
				object Evaluate(global::Java.Util.IList<object> list) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// javax/xml/xpath/XPathFunctionResolver
		/// </java-name>
		[Dot42.DexImport("javax/xml/xpath/XPathFunctionResolver", AccessFlags = 1537)]
		public partial interface IXPathFunctionResolver
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// resolveFunction
				/// </java-name>
				[Dot42.DexImport("resolveFunction", "(Ljavax/xml/namespace/QName;I)Ljavax/xml/xpath/XPathFunction;", AccessFlags = 1025)]
				global::Javax.Xml.Xpath.IXPathFunction ResolveFunction(global::Javax.Xml.Namespace.QName qName, int int32) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// javax/xml/xpath/XPathVariableResolver
		/// </java-name>
		[Dot42.DexImport("javax/xml/xpath/XPathVariableResolver", AccessFlags = 1537)]
		public partial interface IXPathVariableResolver
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// resolveVariable
				/// </java-name>
				[Dot42.DexImport("resolveVariable", "(Ljavax/xml/namespace/QName;)Ljava/lang/Object;", AccessFlags = 1025)]
				object ResolveVariable(global::Javax.Xml.Namespace.QName qName) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// javax/xml/xpath/XPathConstants
		/// </java-name>
		[Dot42.DexImport("javax/xml/xpath/XPathConstants", AccessFlags = 33)]
		public partial class XPathConstants
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// NUMBER
				/// </java-name>
				[Dot42.DexImport("NUMBER", "Ljavax/xml/namespace/QName;", AccessFlags = 25)]
				public static readonly global::Javax.Xml.Namespace.QName NUMBER;
				/// <java-name>
				/// STRING
				/// </java-name>
				[Dot42.DexImport("STRING", "Ljavax/xml/namespace/QName;", AccessFlags = 25)]
				public static readonly global::Javax.Xml.Namespace.QName STRING;
				/// <java-name>
				/// BOOLEAN
				/// </java-name>
				[Dot42.DexImport("BOOLEAN", "Ljavax/xml/namespace/QName;", AccessFlags = 25)]
				public static readonly global::Javax.Xml.Namespace.QName BOOLEAN;
				/// <java-name>
				/// NODESET
				/// </java-name>
				[Dot42.DexImport("NODESET", "Ljavax/xml/namespace/QName;", AccessFlags = 25)]
				public static readonly global::Javax.Xml.Namespace.QName NODESET;
				/// <java-name>
				/// NODE
				/// </java-name>
				[Dot42.DexImport("NODE", "Ljavax/xml/namespace/QName;", AccessFlags = 25)]
				public static readonly global::Javax.Xml.Namespace.QName NODE;
				/// <java-name>
				/// DOM_OBJECT_MODEL
				/// </java-name>
				[Dot42.DexImport("DOM_OBJECT_MODEL", "Ljava/lang/String;", AccessFlags = 25)]
				public const string DOM_OBJECT_MODEL = "http://java.sun.com/jaxp/xpath/dom";
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal XPathConstants() /* MethodBuilder.Create */ 
				{
				}

		}

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
				/// printStackTrace
				/// </java-name>
				[Dot42.DexImport("printStackTrace", "(Ljava/io/PrintStream;)V", AccessFlags = 1)]
				public override void PrintStackTrace(global::Java.Io.PrintStream printStream) /* MethodBuilder.Create */ 
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
				public override void PrintStackTrace(global::Java.Io.PrintWriter printWriter) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal XPathException() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getCause
				/// </java-name>
				public override global::System.Exception Cause
				{
						[Dot42.DexImport("getCause", "()Ljava/lang/Throwable;", AccessFlags = 1)]
						get{ return default(global::System.Exception); }
				}

		}

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

		/// <java-name>
		/// javax/xml/xpath/XPathFactory
		/// </java-name>
		[Dot42.DexImport("javax/xml/xpath/XPathFactory", AccessFlags = 1057)]
		public abstract partial class XPathFactory
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// DEFAULT_PROPERTY_NAME
				/// </java-name>
				[Dot42.DexImport("DEFAULT_PROPERTY_NAME", "Ljava/lang/String;", AccessFlags = 25)]
				public const string DEFAULT_PROPERTY_NAME = "javax.xml.xpath.XPathFactory";
				/// <java-name>
				/// DEFAULT_OBJECT_MODEL_URI
				/// </java-name>
				[Dot42.DexImport("DEFAULT_OBJECT_MODEL_URI", "Ljava/lang/String;", AccessFlags = 25)]
				public const string DEFAULT_OBJECT_MODEL_URI = "http://java.sun.com/jaxp/xpath/dom";
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal XPathFactory() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// newInstance
				/// </java-name>
				[Dot42.DexImport("newInstance", "()Ljavax/xml/xpath/XPathFactory;", AccessFlags = 25)]
				public static global::Javax.Xml.Xpath.XPathFactory NewInstance() /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Xml.Xpath.XPathFactory);
				}

				/// <java-name>
				/// newInstance
				/// </java-name>
				[Dot42.DexImport("newInstance", "(Ljava/lang/String;)Ljavax/xml/xpath/XPathFactory;", AccessFlags = 25)]
				public static global::Javax.Xml.Xpath.XPathFactory NewInstance(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Xml.Xpath.XPathFactory);
				}

				/// <java-name>
				/// newInstance
				/// </java-name>
				[Dot42.DexImport("newInstance", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/ClassLoader;)Ljavax/xml/xpath/XPa" +
    "thFactory;", AccessFlags = 9)]
				public static global::Javax.Xml.Xpath.XPathFactory NewInstance(string @string, string string1, global::Java.Lang.ClassLoader classLoader) /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Xml.Xpath.XPathFactory);
				}

				/// <java-name>
				/// isObjectModelSupported
				/// </java-name>
				[Dot42.DexImport("isObjectModelSupported", "(Ljava/lang/String;)Z", AccessFlags = 1025)]
				public abstract bool IsObjectModelSupported(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setFeature
				/// </java-name>
				[Dot42.DexImport("setFeature", "(Ljava/lang/String;Z)V", AccessFlags = 1025)]
				public abstract void SetFeature(string @string, bool boolean) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getFeature
				/// </java-name>
				[Dot42.DexImport("getFeature", "(Ljava/lang/String;)Z", AccessFlags = 1025)]
				public abstract bool GetFeature(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setXPathVariableResolver
				/// </java-name>
				[Dot42.DexImport("setXPathVariableResolver", "(Ljavax/xml/xpath/XPathVariableResolver;)V", AccessFlags = 1025)]
				public abstract void SetXPathVariableResolver(global::Javax.Xml.Xpath.IXPathVariableResolver xPathVariableResolver) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setXPathFunctionResolver
				/// </java-name>
				[Dot42.DexImport("setXPathFunctionResolver", "(Ljavax/xml/xpath/XPathFunctionResolver;)V", AccessFlags = 1025)]
				public abstract void SetXPathFunctionResolver(global::Javax.Xml.Xpath.IXPathFunctionResolver xPathFunctionResolver) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// newXPath
				/// </java-name>
				[Dot42.DexImport("newXPath", "()Ljavax/xml/xpath/XPath;", AccessFlags = 1025)]
				public abstract global::Javax.Xml.Xpath.IXPath NewXPath() /* MethodBuilder.Create */ ;

		}

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

}

