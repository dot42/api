#pragma warning disable 1717
namespace Org.Xmlpull.V1
{
		/// <java-name>
		/// org/xmlpull/v1/XmlPullParser
		/// </java-name>
		[Dot42.DexImport("org/xmlpull/v1/XmlPullParser", AccessFlags = 1537)]
		public partial interface IXmlPullParser
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// setFeature
				/// </java-name>
				[Dot42.DexImport("setFeature", "(Ljava/lang/String;Z)V", AccessFlags = 1025)]
				void SetFeature(string @string, bool boolean) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getFeature
				/// </java-name>
				[Dot42.DexImport("getFeature", "(Ljava/lang/String;)Z", AccessFlags = 1025)]
				bool GetFeature(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setProperty
				/// </java-name>
				[Dot42.DexImport("setProperty", "(Ljava/lang/String;Ljava/lang/Object;)V", AccessFlags = 1025)]
				void SetProperty(string @string, object @object) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getProperty
				/// </java-name>
				[Dot42.DexImport("getProperty", "(Ljava/lang/String;)Ljava/lang/Object;", AccessFlags = 1025)]
				object GetProperty(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setInput
				/// </java-name>
				[Dot42.DexImport("setInput", "(Ljava/io/Reader;)V", AccessFlags = 1025)]
				void SetInput(global::Java.Io.Reader reader) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setInput
				/// </java-name>
				[Dot42.DexImport("setInput", "(Ljava/io/InputStream;Ljava/lang/String;)V", AccessFlags = 1025)]
				void SetInput(global::Java.Io.InputStream inputStream, string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// defineEntityReplacementText
				/// </java-name>
				[Dot42.DexImport("defineEntityReplacementText", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1025)]
				void DefineEntityReplacementText(string @string, string string1) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getNamespaceCount
				/// </java-name>
				[Dot42.DexImport("getNamespaceCount", "(I)I", AccessFlags = 1025)]
				int GetNamespaceCount(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getNamespacePrefix
				/// </java-name>
				[Dot42.DexImport("getNamespacePrefix", "(I)Ljava/lang/String;", AccessFlags = 1025)]
				string GetNamespacePrefix(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getNamespaceUri
				/// </java-name>
				[Dot42.DexImport("getNamespaceUri", "(I)Ljava/lang/String;", AccessFlags = 1025)]
				string GetNamespaceUri(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getNamespace
				/// </java-name>
				[Dot42.DexImport("getNamespace", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1025)]
				string GetNamespace(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getTextCharacters
				/// </java-name>
				[Dot42.DexImport("getTextCharacters", "([I)[C", AccessFlags = 1025)]
				char[] GetTextCharacters(int[] int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getAttributeNamespace
				/// </java-name>
				[Dot42.DexImport("getAttributeNamespace", "(I)Ljava/lang/String;", AccessFlags = 1025)]
				string GetAttributeNamespace(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getAttributeName
				/// </java-name>
				[Dot42.DexImport("getAttributeName", "(I)Ljava/lang/String;", AccessFlags = 1025)]
				string GetAttributeName(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getAttributePrefix
				/// </java-name>
				[Dot42.DexImport("getAttributePrefix", "(I)Ljava/lang/String;", AccessFlags = 1025)]
				string GetAttributePrefix(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getAttributeType
				/// </java-name>
				[Dot42.DexImport("getAttributeType", "(I)Ljava/lang/String;", AccessFlags = 1025)]
				string GetAttributeType(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// isAttributeDefault
				/// </java-name>
				[Dot42.DexImport("isAttributeDefault", "(I)Z", AccessFlags = 1025)]
				bool IsAttributeDefault(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getAttributeValue
				/// </java-name>
				[Dot42.DexImport("getAttributeValue", "(I)Ljava/lang/String;", AccessFlags = 1025)]
				string GetAttributeValue(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getAttributeValue
				/// </java-name>
				[Dot42.DexImport("getAttributeValue", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1025)]
				string GetAttributeValue(string @string, string string1) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// next
				/// </java-name>
				[Dot42.DexImport("next", "()I", AccessFlags = 1025)]
				int Next() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// nextToken
				/// </java-name>
				[Dot42.DexImport("nextToken", "()I", AccessFlags = 1025)]
				int NextToken() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// require
				/// </java-name>
				[Dot42.DexImport("require", "(ILjava/lang/String;Ljava/lang/String;)V", AccessFlags = 1025)]
				void Require(int int32, string @string, string string1) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// nextText
				/// </java-name>
				[Dot42.DexImport("nextText", "()Ljava/lang/String;", AccessFlags = 1025)]
				string NextText() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// nextTag
				/// </java-name>
				[Dot42.DexImport("nextTag", "()I", AccessFlags = 1025)]
				int NextTag() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getInputEncoding
				/// </java-name>
				string InputEncoding
				{
						[Dot42.DexImport("getInputEncoding", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getDepth
				/// </java-name>
				int Depth
				{
						[Dot42.DexImport("getDepth", "()I", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getPositionDescription
				/// </java-name>
				string PositionDescription
				{
						[Dot42.DexImport("getPositionDescription", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getLineNumber
				/// </java-name>
				int LineNumber
				{
						[Dot42.DexImport("getLineNumber", "()I", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getColumnNumber
				/// </java-name>
				int ColumnNumber
				{
						[Dot42.DexImport("getColumnNumber", "()I", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// isWhitespace
				/// </java-name>
				bool IsWhitespace
				{
						[Dot42.DexImport("isWhitespace", "()Z", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getText
				/// </java-name>
				string Text
				{
						[Dot42.DexImport("getText", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getNamespace
				/// </java-name>
				string Namespace
				{
						[Dot42.DexImport("getNamespace", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getName
				/// </java-name>
				string Name
				{
						[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getPrefix
				/// </java-name>
				string Prefix
				{
						[Dot42.DexImport("getPrefix", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// isEmptyElementTag
				/// </java-name>
				bool IsEmptyElementTag
				{
						[Dot42.DexImport("isEmptyElementTag", "()Z", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getAttributeCount
				/// </java-name>
				int AttributeCount
				{
						[Dot42.DexImport("getAttributeCount", "()I", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getEventType
				/// </java-name>
				int EventType
				{
						[Dot42.DexImport("getEventType", "()I", AccessFlags = 1025)]
						get;
				}

		}

		/// <java-name>
		/// org/xmlpull/v1/XmlPullParser
		/// </java-name>
		[Dot42.DexImport("org/xmlpull/v1/XmlPullParser", AccessFlags = 1537, IgnoreFromJava = true, Priority = 1)]
		public static partial class IXmlPullParserConstants
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// NO_NAMESPACE
				/// </java-name>
				[Dot42.DexImport("NO_NAMESPACE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string NO_NAMESPACE = "";
				/// <java-name>
				/// START_DOCUMENT
				/// </java-name>
				[Dot42.DexImport("START_DOCUMENT", "I", AccessFlags = 25)]
				public const int START_DOCUMENT = 0;
				/// <java-name>
				/// END_DOCUMENT
				/// </java-name>
				[Dot42.DexImport("END_DOCUMENT", "I", AccessFlags = 25)]
				public const int END_DOCUMENT = 1;
				/// <java-name>
				/// START_TAG
				/// </java-name>
				[Dot42.DexImport("START_TAG", "I", AccessFlags = 25)]
				public const int START_TAG = 2;
				/// <java-name>
				/// END_TAG
				/// </java-name>
				[Dot42.DexImport("END_TAG", "I", AccessFlags = 25)]
				public const int END_TAG = 3;
				/// <java-name>
				/// TEXT
				/// </java-name>
				[Dot42.DexImport("TEXT", "I", AccessFlags = 25)]
				public const int TEXT = 4;
				/// <java-name>
				/// CDSECT
				/// </java-name>
				[Dot42.DexImport("CDSECT", "I", AccessFlags = 25)]
				public const int CDSECT = 5;
				/// <java-name>
				/// ENTITY_REF
				/// </java-name>
				[Dot42.DexImport("ENTITY_REF", "I", AccessFlags = 25)]
				public const int ENTITY_REF = 6;
				/// <java-name>
				/// IGNORABLE_WHITESPACE
				/// </java-name>
				[Dot42.DexImport("IGNORABLE_WHITESPACE", "I", AccessFlags = 25)]
				public const int IGNORABLE_WHITESPACE = 7;
				/// <java-name>
				/// PROCESSING_INSTRUCTION
				/// </java-name>
				[Dot42.DexImport("PROCESSING_INSTRUCTION", "I", AccessFlags = 25)]
				public const int PROCESSING_INSTRUCTION = 8;
				/// <java-name>
				/// COMMENT
				/// </java-name>
				[Dot42.DexImport("COMMENT", "I", AccessFlags = 25)]
				public const int COMMENT = 9;
				/// <java-name>
				/// DOCDECL
				/// </java-name>
				[Dot42.DexImport("DOCDECL", "I", AccessFlags = 25)]
				public const int DOCDECL = 10;
				/// <java-name>
				/// TYPES
				/// </java-name>
				[Dot42.DexImport("TYPES", "[Ljava/lang/String;", AccessFlags = 25)]
				public static readonly string[] TYPES;
				/// <java-name>
				/// FEATURE_PROCESS_NAMESPACES
				/// </java-name>
				[Dot42.DexImport("FEATURE_PROCESS_NAMESPACES", "Ljava/lang/String;", AccessFlags = 25)]
				public const string FEATURE_PROCESS_NAMESPACES = "http://xmlpull.org/v1/doc/features.html#process-namespaces";
				/// <java-name>
				/// FEATURE_REPORT_NAMESPACE_ATTRIBUTES
				/// </java-name>
				[Dot42.DexImport("FEATURE_REPORT_NAMESPACE_ATTRIBUTES", "Ljava/lang/String;", AccessFlags = 25)]
				public const string FEATURE_REPORT_NAMESPACE_ATTRIBUTES = "http://xmlpull.org/v1/doc/features.html#report-namespace-prefixes";
				/// <java-name>
				/// FEATURE_PROCESS_DOCDECL
				/// </java-name>
				[Dot42.DexImport("FEATURE_PROCESS_DOCDECL", "Ljava/lang/String;", AccessFlags = 25)]
				public const string FEATURE_PROCESS_DOCDECL = "http://xmlpull.org/v1/doc/features.html#process-docdecl";
				/// <java-name>
				/// FEATURE_VALIDATION
				/// </java-name>
				[Dot42.DexImport("FEATURE_VALIDATION", "Ljava/lang/String;", AccessFlags = 25)]
				public const string FEATURE_VALIDATION = "http://xmlpull.org/v1/doc/features.html#validation";
		}

		/// <java-name>
		/// org/xmlpull/v1/XmlSerializer
		/// </java-name>
		[Dot42.DexImport("org/xmlpull/v1/XmlSerializer", AccessFlags = 1537)]
		public partial interface IXmlSerializer
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// setFeature
				/// </java-name>
				[Dot42.DexImport("setFeature", "(Ljava/lang/String;Z)V", AccessFlags = 1025)]
				void SetFeature(string @string, bool boolean) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getFeature
				/// </java-name>
				[Dot42.DexImport("getFeature", "(Ljava/lang/String;)Z", AccessFlags = 1025)]
				bool GetFeature(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setProperty
				/// </java-name>
				[Dot42.DexImport("setProperty", "(Ljava/lang/String;Ljava/lang/Object;)V", AccessFlags = 1025)]
				void SetProperty(string @string, object @object) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getProperty
				/// </java-name>
				[Dot42.DexImport("getProperty", "(Ljava/lang/String;)Ljava/lang/Object;", AccessFlags = 1025)]
				object GetProperty(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setOutput
				/// </java-name>
				[Dot42.DexImport("setOutput", "(Ljava/io/OutputStream;Ljava/lang/String;)V", AccessFlags = 1025)]
				void SetOutput(global::Java.Io.OutputStream outputStream, string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setOutput
				/// </java-name>
				[Dot42.DexImport("setOutput", "(Ljava/io/Writer;)V", AccessFlags = 1025)]
				void SetOutput(global::Java.Io.Writer writer) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// startDocument
				/// </java-name>
				[Dot42.DexImport("startDocument", "(Ljava/lang/String;Ljava/lang/Boolean;)V", AccessFlags = 1025)]
				void StartDocument(string @string, bool? boolean) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// endDocument
				/// </java-name>
				[Dot42.DexImport("endDocument", "()V", AccessFlags = 1025)]
				void EndDocument() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setPrefix
				/// </java-name>
				[Dot42.DexImport("setPrefix", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1025)]
				void SetPrefix(string @string, string string1) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getPrefix
				/// </java-name>
				[Dot42.DexImport("getPrefix", "(Ljava/lang/String;Z)Ljava/lang/String;", AccessFlags = 1025)]
				string GetPrefix(string @string, bool boolean) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// startTag
				/// </java-name>
				[Dot42.DexImport("startTag", "(Ljava/lang/String;Ljava/lang/String;)Lorg/xmlpull/v1/XmlSerializer;", AccessFlags = 1025)]
				global::Org.Xmlpull.V1.IXmlSerializer StartTag(string @string, string string1) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// attribute
				/// </java-name>
				[Dot42.DexImport("attribute", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lorg/xmlpull/v1/XmlSerial" +
    "izer;", AccessFlags = 1025)]
				global::Org.Xmlpull.V1.IXmlSerializer Attribute(string @string, string string1, string string2) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// endTag
				/// </java-name>
				[Dot42.DexImport("endTag", "(Ljava/lang/String;Ljava/lang/String;)Lorg/xmlpull/v1/XmlSerializer;", AccessFlags = 1025)]
				global::Org.Xmlpull.V1.IXmlSerializer EndTag(string @string, string string1) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// text
				/// </java-name>
				[Dot42.DexImport("text", "(Ljava/lang/String;)Lorg/xmlpull/v1/XmlSerializer;", AccessFlags = 1025)]
				global::Org.Xmlpull.V1.IXmlSerializer Text(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// text
				/// </java-name>
				[Dot42.DexImport("text", "([CII)Lorg/xmlpull/v1/XmlSerializer;", AccessFlags = 1025)]
				global::Org.Xmlpull.V1.IXmlSerializer Text(char[] @char, int int32, int int321) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// cdsect
				/// </java-name>
				[Dot42.DexImport("cdsect", "(Ljava/lang/String;)V", AccessFlags = 1025)]
				void Cdsect(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// entityRef
				/// </java-name>
				[Dot42.DexImport("entityRef", "(Ljava/lang/String;)V", AccessFlags = 1025)]
				void EntityRef(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// processingInstruction
				/// </java-name>
				[Dot42.DexImport("processingInstruction", "(Ljava/lang/String;)V", AccessFlags = 1025)]
				void ProcessingInstruction(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// comment
				/// </java-name>
				[Dot42.DexImport("comment", "(Ljava/lang/String;)V", AccessFlags = 1025)]
				void Comment(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// docdecl
				/// </java-name>
				[Dot42.DexImport("docdecl", "(Ljava/lang/String;)V", AccessFlags = 1025)]
				void Docdecl(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// ignorableWhitespace
				/// </java-name>
				[Dot42.DexImport("ignorableWhitespace", "(Ljava/lang/String;)V", AccessFlags = 1025)]
				void IgnorableWhitespace(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// flush
				/// </java-name>
				[Dot42.DexImport("flush", "()V", AccessFlags = 1025)]
				void Flush() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getDepth
				/// </java-name>
				int Depth
				{
						[Dot42.DexImport("getDepth", "()I", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getNamespace
				/// </java-name>
				string Namespace
				{
						[Dot42.DexImport("getNamespace", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getName
				/// </java-name>
				string Name
				{
						[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

		}

		/// <java-name>
		/// org/xmlpull/v1/XmlPullParserException
		/// </java-name>
		[Dot42.DexImport("org/xmlpull/v1/XmlPullParserException", AccessFlags = 33)]
		public partial class XmlPullParserException : global::System.Exception
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// detail
				/// </java-name>
				[Dot42.DexImport("detail", "Ljava/lang/Throwable;", AccessFlags = 4)]
				protected internal global::System.Exception @detail;
				/// <java-name>
				/// row
				/// </java-name>
				[Dot42.DexImport("row", "I", AccessFlags = 4)]
				protected internal int Row;
				/// <java-name>
				/// column
				/// </java-name>
				[Dot42.DexImport("column", "I", AccessFlags = 4)]
				protected internal int Column;
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public XmlPullParserException(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Lorg/xmlpull/v1/XmlPullParser;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public XmlPullParserException(string @string, global::Org.Xmlpull.V1.IXmlPullParser xmlPullParser, global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// printStackTrace
				/// </java-name>
				[Dot42.DexImport("printStackTrace", "()V", AccessFlags = 1)]
				public override void PrintStackTrace() /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal XmlPullParserException() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getDetail
				/// </java-name>
				public virtual global::System.Exception Detail
				{
						[Dot42.DexImport("getDetail", "()Ljava/lang/Throwable;", AccessFlags = 1)]
						get{ return default(global::System.Exception); }
				}

				/// <java-name>
				/// getLineNumber
				/// </java-name>
				public virtual int LineNumber
				{
						[Dot42.DexImport("getLineNumber", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getColumnNumber
				/// </java-name>
				public virtual int ColumnNumber
				{
						[Dot42.DexImport("getColumnNumber", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

		}

		/// <java-name>
		/// org/xmlpull/v1/XmlPullParserFactory
		/// </java-name>
		[Dot42.DexImport("org/xmlpull/v1/XmlPullParserFactory", AccessFlags = 33)]
		public partial class XmlPullParserFactory
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// PROPERTY_NAME
				/// </java-name>
				[Dot42.DexImport("PROPERTY_NAME", "Ljava/lang/String;", AccessFlags = 25)]
				public const string PROPERTY_NAME = "org.xmlpull.v1.XmlPullParserFactory";
				/// <java-name>
				/// parserClasses
				/// </java-name>
				[Dot42.DexImport("parserClasses", "Ljava/util/ArrayList;", AccessFlags = 4)]
				protected internal global::Java.Util.ArrayList<object> ParserClasses;
				/// <java-name>
				/// classNamesLocation
				/// </java-name>
				[Dot42.DexImport("classNamesLocation", "Ljava/lang/String;", AccessFlags = 4)]
				protected internal string ClassNamesLocation;
				/// <java-name>
				/// serializerClasses
				/// </java-name>
				[Dot42.DexImport("serializerClasses", "Ljava/util/ArrayList;", AccessFlags = 4)]
				protected internal global::Java.Util.ArrayList<object> SerializerClasses;
				/// <java-name>
				/// features
				/// </java-name>
				[Dot42.DexImport("features", "Ljava/util/HashMap;", AccessFlags = 4)]
				protected internal global::Java.Util.HashMap<object, object> Features;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal XmlPullParserFactory() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setFeature
				/// </java-name>
				[Dot42.DexImport("setFeature", "(Ljava/lang/String;Z)V", AccessFlags = 1)]
				public virtual void SetFeature(string @string, bool boolean) /* MethodBuilder.Create */ 
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
				/// setNamespaceAware
				/// </java-name>
				[Dot42.DexImport("setNamespaceAware", "(Z)V", AccessFlags = 1)]
				public virtual void SetNamespaceAware(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setValidating
				/// </java-name>
				[Dot42.DexImport("setValidating", "(Z)V", AccessFlags = 1)]
				public virtual void SetValidating(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// newPullParser
				/// </java-name>
				[Dot42.DexImport("newPullParser", "()Lorg/xmlpull/v1/XmlPullParser;", AccessFlags = 1)]
				public virtual global::Org.Xmlpull.V1.IXmlPullParser NewPullParser() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Xmlpull.V1.IXmlPullParser);
				}

				/// <java-name>
				/// newSerializer
				/// </java-name>
				[Dot42.DexImport("newSerializer", "()Lorg/xmlpull/v1/XmlSerializer;", AccessFlags = 1)]
				public virtual global::Org.Xmlpull.V1.IXmlSerializer NewSerializer() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Xmlpull.V1.IXmlSerializer);
				}

				/// <java-name>
				/// newInstance
				/// </java-name>
				[Dot42.DexImport("newInstance", "()Lorg/xmlpull/v1/XmlPullParserFactory;", AccessFlags = 9)]
				public static global::Org.Xmlpull.V1.XmlPullParserFactory NewInstance() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Xmlpull.V1.XmlPullParserFactory);
				}

				/// <java-name>
				/// newInstance
				/// </java-name>
				[Dot42.DexImport("newInstance", "(Ljava/lang/String;Ljava/lang/Class;)Lorg/xmlpull/v1/XmlPullParserFactory;", AccessFlags = 9)]
				public static global::Org.Xmlpull.V1.XmlPullParserFactory NewInstance(string @string, global::System.Type type) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Xmlpull.V1.XmlPullParserFactory);
				}

				/// <java-name>
				/// isNamespaceAware
				/// </java-name>
				public virtual bool IsNamespaceAware
				{
						[Dot42.DexImport("isNamespaceAware", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// isValidating
				/// </java-name>
				public virtual bool IsValidating
				{
						[Dot42.DexImport("isValidating", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

		}

}

