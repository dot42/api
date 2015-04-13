#pragma warning disable 1717
namespace Javax.Xml.Validation
{
		/// <java-name>
		/// javax/xml/validation/Schema
		/// </java-name>
		[Dot42.DexImport("javax/xml/validation/Schema", AccessFlags = 1057)]
		public abstract partial class Schema
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal Schema() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// newValidator
				/// </java-name>
				[Dot42.DexImport("newValidator", "()Ljavax/xml/validation/Validator;", AccessFlags = 1025)]
				public abstract global::Javax.Xml.Validation.Validator NewValidator() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// newValidatorHandler
				/// </java-name>
				[Dot42.DexImport("newValidatorHandler", "()Ljavax/xml/validation/ValidatorHandler;", AccessFlags = 1025)]
				public abstract global::Javax.Xml.Validation.ValidatorHandler NewValidatorHandler() /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// javax/xml/validation/SchemaFactory
		/// </java-name>
		[Dot42.DexImport("javax/xml/validation/SchemaFactory", AccessFlags = 1057)]
		public abstract partial class SchemaFactory
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal SchemaFactory() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// newInstance
				/// </java-name>
				[Dot42.DexImport("newInstance", "(Ljava/lang/String;)Ljavax/xml/validation/SchemaFactory;", AccessFlags = 9)]
				public static global::Javax.Xml.Validation.SchemaFactory NewInstance(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Xml.Validation.SchemaFactory);
				}

				/// <java-name>
				/// newInstance
				/// </java-name>
				[Dot42.DexImport("newInstance", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/ClassLoader;)Ljavax/xml/validatio" +
    "n/SchemaFactory;", AccessFlags = 9)]
				public static global::Javax.Xml.Validation.SchemaFactory NewInstance(string @string, string string1, global::Java.Lang.ClassLoader classLoader) /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Xml.Validation.SchemaFactory);
				}

				/// <java-name>
				/// isSchemaLanguageSupported
				/// </java-name>
				[Dot42.DexImport("isSchemaLanguageSupported", "(Ljava/lang/String;)Z", AccessFlags = 1025)]
				public abstract bool IsSchemaLanguageSupported(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getFeature
				/// </java-name>
				[Dot42.DexImport("getFeature", "(Ljava/lang/String;)Z", AccessFlags = 1)]
				public virtual bool GetFeature(string @string) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setFeature
				/// </java-name>
				[Dot42.DexImport("setFeature", "(Ljava/lang/String;Z)V", AccessFlags = 1)]
				public virtual void SetFeature(string @string, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setProperty
				/// </java-name>
				[Dot42.DexImport("setProperty", "(Ljava/lang/String;Ljava/lang/Object;)V", AccessFlags = 1)]
				public virtual void SetProperty(string @string, object @object) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getProperty
				/// </java-name>
				[Dot42.DexImport("getProperty", "(Ljava/lang/String;)Ljava/lang/Object;", AccessFlags = 1)]
				public virtual object GetProperty(string @string) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <java-name>
				/// newSchema
				/// </java-name>
				[Dot42.DexImport("newSchema", "(Ljavax/xml/transform/Source;)Ljavax/xml/validation/Schema;", AccessFlags = 1)]
				public virtual global::Javax.Xml.Validation.Schema NewSchema(global::Javax.Xml.Transform.ISource source) /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Xml.Validation.Schema);
				}

				/// <java-name>
				/// newSchema
				/// </java-name>
				[Dot42.DexImport("newSchema", "(Ljava/io/File;)Ljavax/xml/validation/Schema;", AccessFlags = 1)]
				public virtual global::Javax.Xml.Validation.Schema NewSchema(global::Java.IO.File file) /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Xml.Validation.Schema);
				}

				/// <java-name>
				/// newSchema
				/// </java-name>
				[Dot42.DexImport("newSchema", "(Ljava/net/URL;)Ljavax/xml/validation/Schema;", AccessFlags = 1)]
				public virtual global::Javax.Xml.Validation.Schema NewSchema(global::Java.Net.URL uRL) /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Xml.Validation.Schema);
				}

				/// <java-name>
				/// newSchema
				/// </java-name>
				[Dot42.DexImport("newSchema", "([Ljavax/xml/transform/Source;)Ljavax/xml/validation/Schema;", AccessFlags = 1025)]
				public abstract global::Javax.Xml.Validation.Schema NewSchema(global::Javax.Xml.Transform.ISource[] source) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// newSchema
				/// </java-name>
				[Dot42.DexImport("newSchema", "()Ljavax/xml/validation/Schema;", AccessFlags = 1025)]
				public abstract global::Javax.Xml.Validation.Schema NewSchema() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getErrorHandler
				/// </java-name>
				public abstract global::Org.Xml.Sax.IErrorHandler ErrorHandler
				{
						[Dot42.DexImport("getErrorHandler", "()Lorg/xml/sax/ErrorHandler;", AccessFlags = 1025)]
						get;
						[Dot42.DexImport("setErrorHandler", "(Lorg/xml/sax/ErrorHandler;)V", AccessFlags = 1025)]
						set;
				}

				/// <java-name>
				/// getResourceResolver
				/// </java-name>
				public abstract global::Org.W3c.Dom.Ls.ILSResourceResolver ResourceResolver
				{
						[Dot42.DexImport("getResourceResolver", "()Lorg/w3c/dom/ls/LSResourceResolver;", AccessFlags = 1025)]
						get;
						[Dot42.DexImport("setResourceResolver", "(Lorg/w3c/dom/ls/LSResourceResolver;)V", AccessFlags = 1025)]
						set;
				}

		}

		/// <java-name>
		/// javax/xml/validation/SchemaFactoryLoader
		/// </java-name>
		[Dot42.DexImport("javax/xml/validation/SchemaFactoryLoader", AccessFlags = 1057)]
		public abstract partial class SchemaFactoryLoader
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal SchemaFactoryLoader() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// newFactory
				/// </java-name>
				[Dot42.DexImport("newFactory", "(Ljava/lang/String;)Ljavax/xml/validation/SchemaFactory;", AccessFlags = 1025)]
				public abstract global::Javax.Xml.Validation.SchemaFactory NewFactory(string @string) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// javax/xml/validation/TypeInfoProvider
		/// </java-name>
		[Dot42.DexImport("javax/xml/validation/TypeInfoProvider", AccessFlags = 1057)]
		public abstract partial class TypeInfoProvider
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal TypeInfoProvider() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getAttributeTypeInfo
				/// </java-name>
				[Dot42.DexImport("getAttributeTypeInfo", "(I)Lorg/w3c/dom/TypeInfo;", AccessFlags = 1025)]
				public abstract global::Org.W3c.Dom.ITypeInfo GetAttributeTypeInfo(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// isIdAttribute
				/// </java-name>
				[Dot42.DexImport("isIdAttribute", "(I)Z", AccessFlags = 1025)]
				public abstract bool IsIdAttribute(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// isSpecified
				/// </java-name>
				[Dot42.DexImport("isSpecified", "(I)Z", AccessFlags = 1025)]
				public abstract bool IsSpecified(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getElementTypeInfo
				/// </java-name>
				public abstract global::Org.W3c.Dom.ITypeInfo ElementTypeInfo
				{
						[Dot42.DexImport("getElementTypeInfo", "()Lorg/w3c/dom/TypeInfo;", AccessFlags = 1025)]
						get;
				}

		}

		/// <java-name>
		/// javax/xml/validation/Validator
		/// </java-name>
		[Dot42.DexImport("javax/xml/validation/Validator", AccessFlags = 1057)]
		public abstract partial class Validator
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal Validator() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// reset
				/// </java-name>
				[Dot42.DexImport("reset", "()V", AccessFlags = 1025)]
				public abstract void Reset() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// validate
				/// </java-name>
				[Dot42.DexImport("validate", "(Ljavax/xml/transform/Source;)V", AccessFlags = 1)]
				public virtual void Validate(global::Javax.Xml.Transform.ISource source) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// validate
				/// </java-name>
				[Dot42.DexImport("validate", "(Ljavax/xml/transform/Source;Ljavax/xml/transform/Result;)V", AccessFlags = 1025)]
				public abstract void Validate(global::Javax.Xml.Transform.ISource source, global::Javax.Xml.Transform.IResult result) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getFeature
				/// </java-name>
				[Dot42.DexImport("getFeature", "(Ljava/lang/String;)Z", AccessFlags = 1)]
				public virtual bool GetFeature(string @string) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setFeature
				/// </java-name>
				[Dot42.DexImport("setFeature", "(Ljava/lang/String;Z)V", AccessFlags = 1)]
				public virtual void SetFeature(string @string, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setProperty
				/// </java-name>
				[Dot42.DexImport("setProperty", "(Ljava/lang/String;Ljava/lang/Object;)V", AccessFlags = 1)]
				public virtual void SetProperty(string @string, object @object) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getProperty
				/// </java-name>
				[Dot42.DexImport("getProperty", "(Ljava/lang/String;)Ljava/lang/Object;", AccessFlags = 1)]
				public virtual object GetProperty(string @string) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <java-name>
				/// getErrorHandler
				/// </java-name>
				public abstract global::Org.Xml.Sax.IErrorHandler ErrorHandler
				{
						[Dot42.DexImport("getErrorHandler", "()Lorg/xml/sax/ErrorHandler;", AccessFlags = 1025)]
						get;
						[Dot42.DexImport("setErrorHandler", "(Lorg/xml/sax/ErrorHandler;)V", AccessFlags = 1025)]
						set;
				}

				/// <java-name>
				/// getResourceResolver
				/// </java-name>
				public abstract global::Org.W3c.Dom.Ls.ILSResourceResolver ResourceResolver
				{
						[Dot42.DexImport("getResourceResolver", "()Lorg/w3c/dom/ls/LSResourceResolver;", AccessFlags = 1025)]
						get;
						[Dot42.DexImport("setResourceResolver", "(Lorg/w3c/dom/ls/LSResourceResolver;)V", AccessFlags = 1025)]
						set;
				}

		}

		/// <java-name>
		/// javax/xml/validation/ValidatorHandler
		/// </java-name>
		[Dot42.DexImport("javax/xml/validation/ValidatorHandler", AccessFlags = 1057)]
		public abstract partial class ValidatorHandler : global::Org.Xml.Sax.IContentHandler
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal ValidatorHandler() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getFeature
				/// </java-name>
				[Dot42.DexImport("getFeature", "(Ljava/lang/String;)Z", AccessFlags = 1)]
				public virtual bool GetFeature(string @string) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setFeature
				/// </java-name>
				[Dot42.DexImport("setFeature", "(Ljava/lang/String;Z)V", AccessFlags = 1)]
				public virtual void SetFeature(string @string, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setProperty
				/// </java-name>
				[Dot42.DexImport("setProperty", "(Ljava/lang/String;Ljava/lang/Object;)V", AccessFlags = 1)]
				public virtual void SetProperty(string @string, object @object) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getProperty
				/// </java-name>
				[Dot42.DexImport("getProperty", "(Ljava/lang/String;)Ljava/lang/Object;", AccessFlags = 1)]
				public virtual object GetProperty(string @string) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				[Dot42.DexImport("org/xml/sax/ContentHandler", "setDocumentLocator", "(Lorg/xml/sax/Locator;)V", AccessFlags = 1025)]
				public virtual void SetDocumentLocator(global::Org.Xml.Sax.ILocator locator) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("org/xml/sax/ContentHandler", "startDocument", "()V", AccessFlags = 1025)]
				public virtual void StartDocument() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("org/xml/sax/ContentHandler", "endDocument", "()V", AccessFlags = 1025)]
				public virtual void EndDocument() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("org/xml/sax/ContentHandler", "startPrefixMapping", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1025)]
				public virtual void StartPrefixMapping(string @string, string string1) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("org/xml/sax/ContentHandler", "endPrefixMapping", "(Ljava/lang/String;)V", AccessFlags = 1025)]
				public virtual void EndPrefixMapping(string @string) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("org/xml/sax/ContentHandler", "startElement", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lorg/xml/sax/Attributes;)V" +
    "", AccessFlags = 1025)]
				public virtual void StartElement(string @string, string string1, string string2, global::Org.Xml.Sax.IAttributes attributes) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("org/xml/sax/ContentHandler", "endElement", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1025)]
				public virtual void EndElement(string @string, string string1, string string2) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("org/xml/sax/ContentHandler", "characters", "([CII)V", AccessFlags = 1025)]
				public virtual void Characters(char[] @char, int int32, int int321) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("org/xml/sax/ContentHandler", "ignorableWhitespace", "([CII)V", AccessFlags = 1025)]
				public virtual void IgnorableWhitespace(char[] @char, int int32, int int321) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("org/xml/sax/ContentHandler", "processingInstruction", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1025)]
				public virtual void ProcessingInstruction(string @string, string string1) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("org/xml/sax/ContentHandler", "skippedEntity", "(Ljava/lang/String;)V", AccessFlags = 1025)]
				public virtual void SkippedEntity(string @string) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				/// <java-name>
				/// getContentHandler
				/// </java-name>
				public abstract global::Org.Xml.Sax.IContentHandler ContentHandler
				{
						[Dot42.DexImport("getContentHandler", "()Lorg/xml/sax/ContentHandler;", AccessFlags = 1025)]
						get;
						[Dot42.DexImport("setContentHandler", "(Lorg/xml/sax/ContentHandler;)V", AccessFlags = 1025)]
						set;
				}

				/// <java-name>
				/// getErrorHandler
				/// </java-name>
				public abstract global::Org.Xml.Sax.IErrorHandler ErrorHandler
				{
						[Dot42.DexImport("getErrorHandler", "()Lorg/xml/sax/ErrorHandler;", AccessFlags = 1025)]
						get;
						[Dot42.DexImport("setErrorHandler", "(Lorg/xml/sax/ErrorHandler;)V", AccessFlags = 1025)]
						set;
				}

				/// <java-name>
				/// getResourceResolver
				/// </java-name>
				public abstract global::Org.W3c.Dom.Ls.ILSResourceResolver ResourceResolver
				{
						[Dot42.DexImport("getResourceResolver", "()Lorg/w3c/dom/ls/LSResourceResolver;", AccessFlags = 1025)]
						get;
						[Dot42.DexImport("setResourceResolver", "(Lorg/w3c/dom/ls/LSResourceResolver;)V", AccessFlags = 1025)]
						set;
				}

				/// <java-name>
				/// getTypeInfoProvider
				/// </java-name>
				public abstract global::Javax.Xml.Validation.TypeInfoProvider TypeInfoProvider
				{
						[Dot42.DexImport("getTypeInfoProvider", "()Ljavax/xml/validation/TypeInfoProvider;", AccessFlags = 1025)]
						get;
				}

		}

}

