#pragma warning disable 1717
namespace Javax.Xml.Transform
{
		/// <java-name>
		/// javax/xml/transform/URIResolver
		/// </java-name>
		[Dot42.DexImport("javax/xml/transform/URIResolver", AccessFlags = 1537)]
		public partial interface IURIResolver
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// resolve
				/// </java-name>
				[Dot42.DexImport("resolve", "(Ljava/lang/String;Ljava/lang/String;)Ljavax/xml/transform/Source;", AccessFlags = 1025)]
				global::Javax.Xml.Transform.ISource Resolve(string @string, string string1) /* MethodBuilder.Create */ ;

		}

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

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljavax/xml/transform/SourceLocator;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public TransformerException(string @string, global::Javax.Xml.Transform.ISourceLocator sourceLocator, global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getLocator
				/// </java-name>
				[Dot42.DexImport("getLocator", "()Ljavax/xml/transform/SourceLocator;", AccessFlags = 1)]
				public virtual global::Javax.Xml.Transform.ISourceLocator GetLocator() /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Xml.Transform.ISourceLocator);
				}

				/// <java-name>
				/// setLocator
				/// </java-name>
				[Dot42.DexImport("setLocator", "(Ljavax/xml/transform/SourceLocator;)V", AccessFlags = 1)]
				public virtual void SetLocator(global::Javax.Xml.Transform.ISourceLocator sourceLocator) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getException
				/// </java-name>
				[Dot42.DexImport("getException", "()Ljava/lang/Throwable;", AccessFlags = 1)]
				public virtual global::System.Exception GetException() /* MethodBuilder.Create */ 
				{
						return default(global::System.Exception);
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
				/// initCause
				/// </java-name>
				[Dot42.DexImport("initCause", "(Ljava/lang/Throwable;)Ljava/lang/Throwable;", AccessFlags = 33)]
				public override global::System.Exception InitCause(global::System.Exception exception) /* MethodBuilder.Create */ 
				{
						return default(global::System.Exception);
				}

				/// <java-name>
				/// getMessageAndLocation
				/// </java-name>
				[Dot42.DexImport("getMessageAndLocation", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetMessageAndLocation() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getLocationAsString
				/// </java-name>
				[Dot42.DexImport("getLocationAsString", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetLocationAsString() /* MethodBuilder.Create */ 
				{
						return default(string);
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
				[Dot42.DexImport("printStackTrace", "(Ljava/io/PrintStream;)V", AccessFlags = 1)]
				public override void PrintStackTrace(global::Java.Io.PrintStream printStream) /* MethodBuilder.Create */ 
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
				internal TransformerException() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getLocator
				/// </java-name>
				public global::Javax.Xml.Transform.ISourceLocator Locator
				{
				[Dot42.DexImport("getLocator", "()Ljavax/xml/transform/SourceLocator;", AccessFlags = 1)]
						get{ return GetLocator(); }
				[Dot42.DexImport("setLocator", "(Ljavax/xml/transform/SourceLocator;)V", AccessFlags = 1)]
						set{ SetLocator(value); }
				}

				/// <java-name>
				/// getException
				/// </java-name>
				public global::System.Exception Exception
				{
				[Dot42.DexImport("getException", "()Ljava/lang/Throwable;", AccessFlags = 1)]
						get{ return GetException(); }
				}

				/// <java-name>
				/// getMessageAndLocation
				/// </java-name>
				public string MessageAndLocation
				{
				[Dot42.DexImport("getMessageAndLocation", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetMessageAndLocation(); }
				}

				/// <java-name>
				/// getLocationAsString
				/// </java-name>
				public string LocationAsString
				{
				[Dot42.DexImport("getLocationAsString", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetLocationAsString(); }
				}

		}

		/// <java-name>
		/// javax/xml/transform/Result
		/// </java-name>
		[Dot42.DexImport("javax/xml/transform/Result", AccessFlags = 1537, IgnoreFromJava = true, Priority = 1)]
		public static partial class IResultConstants
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// PI_DISABLE_OUTPUT_ESCAPING
				/// </java-name>
				[Dot42.DexImport("PI_DISABLE_OUTPUT_ESCAPING", "Ljava/lang/String;", AccessFlags = 25)]
				public const string PI_DISABLE_OUTPUT_ESCAPING = "javax.xml.transform.disable-output-escaping";
				/// <java-name>
				/// PI_ENABLE_OUTPUT_ESCAPING
				/// </java-name>
				[Dot42.DexImport("PI_ENABLE_OUTPUT_ESCAPING", "Ljava/lang/String;", AccessFlags = 25)]
				public const string PI_ENABLE_OUTPUT_ESCAPING = "javax.xml.transform.enable-output-escaping";
		}

		/// <java-name>
		/// javax/xml/transform/Result
		/// </java-name>
		[Dot42.DexImport("javax/xml/transform/Result", AccessFlags = 1537)]
		public partial interface IResult
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// setSystemId
				/// </java-name>
				[Dot42.DexImport("setSystemId", "(Ljava/lang/String;)V", AccessFlags = 1025)]
				void SetSystemId(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getSystemId
				/// </java-name>
				[Dot42.DexImport("getSystemId", "()Ljava/lang/String;", AccessFlags = 1025)]
				string GetSystemId() /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// javax/xml/transform/TransformerConfigurationException
		/// </java-name>
		[Dot42.DexImport("javax/xml/transform/TransformerConfigurationException", AccessFlags = 33)]
		public partial class TransformerConfigurationException : global::Javax.Xml.Transform.TransformerException
 /* scope: __dot42__ */ 
		{
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

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljavax/xml/transform/SourceLocator;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public TransformerConfigurationException(string @string, global::Javax.Xml.Transform.ISourceLocator sourceLocator, global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// javax/xml/transform/Source
		/// </java-name>
		[Dot42.DexImport("javax/xml/transform/Source", AccessFlags = 1537)]
		public partial interface ISource
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// setSystemId
				/// </java-name>
				[Dot42.DexImport("setSystemId", "(Ljava/lang/String;)V", AccessFlags = 1025)]
				void SetSystemId(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getSystemId
				/// </java-name>
				[Dot42.DexImport("getSystemId", "()Ljava/lang/String;", AccessFlags = 1025)]
				string GetSystemId() /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// javax/xml/transform/Transformer
		/// </java-name>
		[Dot42.DexImport("javax/xml/transform/Transformer", AccessFlags = 1057)]
		public abstract partial class Transformer
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal Transformer() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// reset
				/// </java-name>
				[Dot42.DexImport("reset", "()V", AccessFlags = 1)]
				public virtual void Reset() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// transform
				/// </java-name>
				[Dot42.DexImport("transform", "(Ljavax/xml/transform/Source;Ljavax/xml/transform/Result;)V", AccessFlags = 1025)]
				public abstract void Transform(global::Javax.Xml.Transform.ISource source, global::Javax.Xml.Transform.IResult result) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setParameter
				/// </java-name>
				[Dot42.DexImport("setParameter", "(Ljava/lang/String;Ljava/lang/Object;)V", AccessFlags = 1025)]
				public abstract void SetParameter(string @string, object @object) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getParameter
				/// </java-name>
				[Dot42.DexImport("getParameter", "(Ljava/lang/String;)Ljava/lang/Object;", AccessFlags = 1025)]
				public abstract object GetParameter(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// clearParameters
				/// </java-name>
				[Dot42.DexImport("clearParameters", "()V", AccessFlags = 1025)]
				public abstract void ClearParameters() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setURIResolver
				/// </java-name>
				[Dot42.DexImport("setURIResolver", "(Ljavax/xml/transform/URIResolver;)V", AccessFlags = 1025)]
				public abstract void SetURIResolver(global::Javax.Xml.Transform.IURIResolver uRIResolver) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getURIResolver
				/// </java-name>
				[Dot42.DexImport("getURIResolver", "()Ljavax/xml/transform/URIResolver;", AccessFlags = 1025)]
				public abstract global::Javax.Xml.Transform.IURIResolver GetURIResolver() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setOutputProperties
				/// </java-name>
				[Dot42.DexImport("setOutputProperties", "(Ljava/util/Properties;)V", AccessFlags = 1025)]
				public abstract void SetOutputProperties(global::Java.Util.Properties properties) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getOutputProperties
				/// </java-name>
				[Dot42.DexImport("getOutputProperties", "()Ljava/util/Properties;", AccessFlags = 1025)]
				public abstract global::Java.Util.Properties GetOutputProperties() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setOutputProperty
				/// </java-name>
				[Dot42.DexImport("setOutputProperty", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1025)]
				public abstract void SetOutputProperty(string @string, string string1) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getOutputProperty
				/// </java-name>
				[Dot42.DexImport("getOutputProperty", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1025)]
				public abstract string GetOutputProperty(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setErrorListener
				/// </java-name>
				[Dot42.DexImport("setErrorListener", "(Ljavax/xml/transform/ErrorListener;)V", AccessFlags = 1025)]
				public abstract void SetErrorListener(global::Javax.Xml.Transform.IErrorListener errorListener) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getErrorListener
				/// </java-name>
				[Dot42.DexImport("getErrorListener", "()Ljavax/xml/transform/ErrorListener;", AccessFlags = 1025)]
				public abstract global::Javax.Xml.Transform.IErrorListener GetErrorListener() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getURIResolver
				/// </java-name>
				public global::Javax.Xml.Transform.IURIResolver URIResolver
				{
				[Dot42.DexImport("getURIResolver", "()Ljavax/xml/transform/URIResolver;", AccessFlags = 1025)]
						get{ return GetURIResolver(); }
				[Dot42.DexImport("setURIResolver", "(Ljavax/xml/transform/URIResolver;)V", AccessFlags = 1025)]
						set{ SetURIResolver(value); }
				}

				/// <java-name>
				/// getOutputProperties
				/// </java-name>
				public global::Java.Util.Properties OutputProperties
				{
				[Dot42.DexImport("getOutputProperties", "()Ljava/util/Properties;", AccessFlags = 1025)]
						get{ return GetOutputProperties(); }
				[Dot42.DexImport("setOutputProperties", "(Ljava/util/Properties;)V", AccessFlags = 1025)]
						set{ SetOutputProperties(value); }
				}

				/// <java-name>
				/// getErrorListener
				/// </java-name>
				public global::Javax.Xml.Transform.IErrorListener ErrorListener
				{
				[Dot42.DexImport("getErrorListener", "()Ljavax/xml/transform/ErrorListener;", AccessFlags = 1025)]
						get{ return GetErrorListener(); }
				[Dot42.DexImport("setErrorListener", "(Ljavax/xml/transform/ErrorListener;)V", AccessFlags = 1025)]
						set{ SetErrorListener(value); }
				}

		}

		/// <java-name>
		/// javax/xml/transform/TransformerFactory
		/// </java-name>
		[Dot42.DexImport("javax/xml/transform/TransformerFactory", AccessFlags = 1057)]
		public abstract partial class TransformerFactory
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal TransformerFactory() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// newInstance
				/// </java-name>
				[Dot42.DexImport("newInstance", "()Ljavax/xml/transform/TransformerFactory;", AccessFlags = 9)]
				public static global::Javax.Xml.Transform.TransformerFactory NewInstance() /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Xml.Transform.TransformerFactory);
				}

				/// <java-name>
				/// newInstance
				/// </java-name>
				[Dot42.DexImport("newInstance", "(Ljava/lang/String;Ljava/lang/ClassLoader;)Ljavax/xml/transform/TransformerFactor" +
    "y;", AccessFlags = 9)]
				public static global::Javax.Xml.Transform.TransformerFactory NewInstance(string @string, global::Java.Lang.ClassLoader classLoader) /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Xml.Transform.TransformerFactory);
				}

				/// <java-name>
				/// newTransformer
				/// </java-name>
				[Dot42.DexImport("newTransformer", "(Ljavax/xml/transform/Source;)Ljavax/xml/transform/Transformer;", AccessFlags = 1025)]
				public abstract global::Javax.Xml.Transform.Transformer NewTransformer(global::Javax.Xml.Transform.ISource source) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// newTransformer
				/// </java-name>
				[Dot42.DexImport("newTransformer", "()Ljavax/xml/transform/Transformer;", AccessFlags = 1025)]
				public abstract global::Javax.Xml.Transform.Transformer NewTransformer() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// newTemplates
				/// </java-name>
				[Dot42.DexImport("newTemplates", "(Ljavax/xml/transform/Source;)Ljavax/xml/transform/Templates;", AccessFlags = 1025)]
				public abstract global::Javax.Xml.Transform.ITemplates NewTemplates(global::Javax.Xml.Transform.ISource source) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getAssociatedStylesheet
				/// </java-name>
				[Dot42.DexImport("getAssociatedStylesheet", "(Ljavax/xml/transform/Source;Ljava/lang/String;Ljava/lang/String;Ljava/lang/Strin" +
    "g;)Ljavax/xml/transform/Source;", AccessFlags = 1025)]
				public abstract global::Javax.Xml.Transform.ISource GetAssociatedStylesheet(global::Javax.Xml.Transform.ISource source, string @string, string string1, string string2) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setURIResolver
				/// </java-name>
				[Dot42.DexImport("setURIResolver", "(Ljavax/xml/transform/URIResolver;)V", AccessFlags = 1025)]
				public abstract void SetURIResolver(global::Javax.Xml.Transform.IURIResolver uRIResolver) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getURIResolver
				/// </java-name>
				[Dot42.DexImport("getURIResolver", "()Ljavax/xml/transform/URIResolver;", AccessFlags = 1025)]
				public abstract global::Javax.Xml.Transform.IURIResolver GetURIResolver() /* MethodBuilder.Create */ ;

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
				/// setAttribute
				/// </java-name>
				[Dot42.DexImport("setAttribute", "(Ljava/lang/String;Ljava/lang/Object;)V", AccessFlags = 1025)]
				public abstract void SetAttribute(string @string, object @object) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getAttribute
				/// </java-name>
				[Dot42.DexImport("getAttribute", "(Ljava/lang/String;)Ljava/lang/Object;", AccessFlags = 1025)]
				public abstract object GetAttribute(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setErrorListener
				/// </java-name>
				[Dot42.DexImport("setErrorListener", "(Ljavax/xml/transform/ErrorListener;)V", AccessFlags = 1025)]
				public abstract void SetErrorListener(global::Javax.Xml.Transform.IErrorListener errorListener) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getErrorListener
				/// </java-name>
				[Dot42.DexImport("getErrorListener", "()Ljavax/xml/transform/ErrorListener;", AccessFlags = 1025)]
				public abstract global::Javax.Xml.Transform.IErrorListener GetErrorListener() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getURIResolver
				/// </java-name>
				public global::Javax.Xml.Transform.IURIResolver URIResolver
				{
				[Dot42.DexImport("getURIResolver", "()Ljavax/xml/transform/URIResolver;", AccessFlags = 1025)]
						get{ return GetURIResolver(); }
				[Dot42.DexImport("setURIResolver", "(Ljavax/xml/transform/URIResolver;)V", AccessFlags = 1025)]
						set{ SetURIResolver(value); }
				}

				/// <java-name>
				/// getErrorListener
				/// </java-name>
				public global::Javax.Xml.Transform.IErrorListener ErrorListener
				{
				[Dot42.DexImport("getErrorListener", "()Ljavax/xml/transform/ErrorListener;", AccessFlags = 1025)]
						get{ return GetErrorListener(); }
				[Dot42.DexImport("setErrorListener", "(Ljavax/xml/transform/ErrorListener;)V", AccessFlags = 1025)]
						set{ SetErrorListener(value); }
				}

		}

		/// <java-name>
		/// javax/xml/transform/OutputKeys
		/// </java-name>
		[Dot42.DexImport("javax/xml/transform/OutputKeys", AccessFlags = 33)]
		public partial class OutputKeys
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// METHOD
				/// </java-name>
				[Dot42.DexImport("METHOD", "Ljava/lang/String;", AccessFlags = 25)]
				public const string METHOD = "method";
				/// <java-name>
				/// VERSION
				/// </java-name>
				[Dot42.DexImport("VERSION", "Ljava/lang/String;", AccessFlags = 25)]
				public const string VERSION = "version";
				/// <java-name>
				/// ENCODING
				/// </java-name>
				[Dot42.DexImport("ENCODING", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ENCODING = "encoding";
				/// <java-name>
				/// OMIT_XML_DECLARATION
				/// </java-name>
				[Dot42.DexImport("OMIT_XML_DECLARATION", "Ljava/lang/String;", AccessFlags = 25)]
				public const string OMIT_XML_DECLARATION = "omit-xml-declaration";
				/// <java-name>
				/// STANDALONE
				/// </java-name>
				[Dot42.DexImport("STANDALONE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string STANDALONE = "standalone";
				/// <java-name>
				/// DOCTYPE_PUBLIC
				/// </java-name>
				[Dot42.DexImport("DOCTYPE_PUBLIC", "Ljava/lang/String;", AccessFlags = 25)]
				public const string DOCTYPE_PUBLIC = "doctype-public";
				/// <java-name>
				/// DOCTYPE_SYSTEM
				/// </java-name>
				[Dot42.DexImport("DOCTYPE_SYSTEM", "Ljava/lang/String;", AccessFlags = 25)]
				public const string DOCTYPE_SYSTEM = "doctype-system";
				/// <java-name>
				/// CDATA_SECTION_ELEMENTS
				/// </java-name>
				[Dot42.DexImport("CDATA_SECTION_ELEMENTS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string CDATA_SECTION_ELEMENTS = "cdata-section-elements";
				/// <java-name>
				/// INDENT
				/// </java-name>
				[Dot42.DexImport("INDENT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string INDENT = "indent";
				/// <java-name>
				/// MEDIA_TYPE
				/// </java-name>
				[Dot42.DexImport("MEDIA_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string MEDIA_TYPE = "media-type";
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal OutputKeys() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// javax/xml/transform/TransformerFactoryConfigurationError
		/// </java-name>
		[Dot42.DexImport("javax/xml/transform/TransformerFactoryConfigurationError", AccessFlags = 33)]
		public partial class TransformerFactoryConfigurationError : global::Java.Lang.Error
 /* scope: __dot42__ */ 
		{
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

				[Dot42.DexImport("<init>", "(Ljava/lang/Exception;Ljava/lang/String;)V", AccessFlags = 1)]
				public TransformerFactoryConfigurationError(global::System.Exception exception, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getMessage
				/// </java-name>
				[Dot42.DexImport("getMessage", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string GetMessage() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getException
				/// </java-name>
				[Dot42.DexImport("getException", "()Ljava/lang/Exception;", AccessFlags = 1)]
				public virtual global::System.Exception GetException() /* MethodBuilder.Create */ 
				{
						return default(global::System.Exception);
				}

				/// <java-name>
				/// getException
				/// </java-name>
				public global::System.Exception Exception
				{
				[Dot42.DexImport("getException", "()Ljava/lang/Exception;", AccessFlags = 1)]
						get{ return GetException(); }
				}

		}

		/// <java-name>
		/// javax/xml/transform/SourceLocator
		/// </java-name>
		[Dot42.DexImport("javax/xml/transform/SourceLocator", AccessFlags = 1537)]
		public partial interface ISourceLocator
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// getPublicId
				/// </java-name>
				[Dot42.DexImport("getPublicId", "()Ljava/lang/String;", AccessFlags = 1025)]
				string GetPublicId() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getSystemId
				/// </java-name>
				[Dot42.DexImport("getSystemId", "()Ljava/lang/String;", AccessFlags = 1025)]
				string GetSystemId() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getLineNumber
				/// </java-name>
				[Dot42.DexImport("getLineNumber", "()I", AccessFlags = 1025)]
				int GetLineNumber() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getColumnNumber
				/// </java-name>
				[Dot42.DexImport("getColumnNumber", "()I", AccessFlags = 1025)]
				int GetColumnNumber() /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// javax/xml/transform/ErrorListener
		/// </java-name>
		[Dot42.DexImport("javax/xml/transform/ErrorListener", AccessFlags = 1537)]
		public partial interface IErrorListener
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// warning
				/// </java-name>
				[Dot42.DexImport("warning", "(Ljavax/xml/transform/TransformerException;)V", AccessFlags = 1025)]
				void Warning(global::Javax.Xml.Transform.TransformerException transformerException) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// error
				/// </java-name>
				[Dot42.DexImport("error", "(Ljavax/xml/transform/TransformerException;)V", AccessFlags = 1025)]
				void Error(global::Javax.Xml.Transform.TransformerException transformerException) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// fatalError
				/// </java-name>
				[Dot42.DexImport("fatalError", "(Ljavax/xml/transform/TransformerException;)V", AccessFlags = 1025)]
				void FatalError(global::Javax.Xml.Transform.TransformerException transformerException) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// javax/xml/transform/Templates
		/// </java-name>
		[Dot42.DexImport("javax/xml/transform/Templates", AccessFlags = 1537)]
		public partial interface ITemplates
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// newTransformer
				/// </java-name>
				[Dot42.DexImport("newTransformer", "()Ljavax/xml/transform/Transformer;", AccessFlags = 1025)]
				global::Javax.Xml.Transform.Transformer NewTransformer() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getOutputProperties
				/// </java-name>
				[Dot42.DexImport("getOutputProperties", "()Ljava/util/Properties;", AccessFlags = 1025)]
				global::Java.Util.Properties GetOutputProperties() /* MethodBuilder.Create */ ;

		}

}

