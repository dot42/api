// Copyright (C) 2014 dot42
//
// Original filename: Org.Xmlpull.V1.cs
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
namespace Org.Xmlpull.V1
{
		/// <summary>
		/// <para>XML Pull Parser is an interface that defines parsing functionality provided in  (visit this website to learn more about API and its implementations).</para><para>There are following different kinds of parser depending on which features are set:<ul><li><para><b>non-validating</b> parser as defined in XML 1.0 spec when FEATURE_PROCESS_DOCDECL is set to true </para></li><li><para><b>validating parser</b> as defined in XML 1.0 spec when FEATURE_VALIDATION is true (and that implies that FEATURE_PROCESS_DOCDECL is true) </para></li><li><para>when FEATURE_PROCESS_DOCDECL is false (this is default and if different value is required necessary must be changed before parsing is started) then parser behaves like XML 1.0 compliant non-validating parser under condition that <b>no DOCDECL is present</b> in XML documents (internal entites can still be defined with defineEntityReplacementText()). This mode of operation is intended <b>for operation in constrained environments</b> such as J2ME. </para></li></ul></para><para>There are two key methods: next() and nextToken(). While next() provides access to high level parsing events, nextToken() allows access to lower level tokens.</para><para>The current event state of the parser can be determined by calling the  method. Initially, the parser is in the  state.</para><para>The method  advances the parser to the next event. The int value returned from next determines the current parser state and is identical to the value returned from following calls to getEventType ().</para><para>Th following event types are seen by next()</para><para>after first next() or nextToken() (or any other next*() method) is called user application can obtain XML version, standalone and encoding from XML declaration in following ways:<ul><li><para><b>version</b>: getProperty("") returns String ("1.0") or null if XMLDecl was not read or if property is not supported </para></li><li><para><b>standalone</b>: getProperty("") returns Boolean: null if there was no standalone declaration or if property is not supported otherwise returns Boolean(true) if standalone="yes" and Boolean(false) when standalone="no" </para></li><li><para><b>encoding</b>: obtained from getInputEncoding() null if stream had unknown encoding (not set in setInputStream) and it was not declared in XMLDecl </para></li></ul></para><para>A minimal example for using this API may look as follows: <pre>
		///    import java.io.IOException;
		///    import java.io.StringReader;
		/// 
		///    import org.xmlpull.v1.XmlPullParser;
		///    import org.xmlpull.v1.;
		///    import org.xmlpull.v1.;
		/// 
		///    public class SimpleXmlPullApp
		///    {
		/// 
		///        public static void main (String args[])
		///            throws XmlPullParserException, IOException
		///        {
		///            XmlPullParserFactory factory = XmlPullParserFactory.newInstance();
		///            factory.setNamespaceAware(true);
		///            XmlPullParser xpp = factory.newPullParser();
		/// 
		///            xpp.( new StringReader ( "&amp;lt;foo&gt;Hello World!&amp;lt;/foo&gt;" ) );
		///            int eventType = xpp.getEventType();
		///            while (eventType != XmlPullParser.END_DOCUMENT) {
		///             if(eventType == XmlPullParser.START_DOCUMENT) {
		///                 System.out.println("Start document");
		///             } else if(eventType == XmlPullParser.START_TAG) {
		///                 System.out.println("Start tag "+xpp.);
		///             } else if(eventType == XmlPullParser.END_TAG) {
		///                 System.out.println("End tag "+xpp.getName());
		///             } else if(eventType == XmlPullParser.TEXT) {
		///                 System.out.println("Text "+xpp.);
		///             }
		///             eventType = xpp.next();
		///            }
		///            System.out.println("End document");
		///        }
		///    }
		///    </pre></para><para>The above example will generate the following output: <pre>
		///    Start document
		///    Start tag foo
		///    Text Hello World!
		///    End tag foo
		///    End document
		///    </pre></para><para>For more details on API usage, please refer to the quick Introduction available at </para><para><para>XmlPullParserFactory </para><simplesectsep></simplesectsep><para>defineEntityReplacementText </para><simplesectsep></simplesectsep><para>getName </para><simplesectsep></simplesectsep><para>getNamespace </para><simplesectsep></simplesectsep><para>getText </para><simplesectsep></simplesectsep><para>next </para><simplesectsep></simplesectsep><para>nextToken </para><simplesectsep></simplesectsep><para>setInput </para><simplesectsep></simplesectsep><para>FEATURE_PROCESS_DOCDECL </para><simplesectsep></simplesectsep><para>FEATURE_VALIDATION </para><simplesectsep></simplesectsep><para>START_DOCUMENT </para><simplesectsep></simplesectsep><para>START_TAG </para><simplesectsep></simplesectsep><para>TEXT </para><simplesectsep></simplesectsep><para>END_TAG </para><simplesectsep></simplesectsep><para>END_DOCUMENT</para><para> </para><simplesectsep></simplesectsep><para> </para></para>    
		/// </summary>
		/// <java-name>
		/// org/xmlpull/v1/XmlPullParser
		/// </java-name>
		[Dot42.DexImport("org/xmlpull/v1/XmlPullParser", AccessFlags = 1537, IgnoreFromJava = true, Priority = 1)]
		public static partial class IXmlPullParserConstants
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>This constant represents the default namespace (empty string "") </para>        
				/// </summary>
				/// <java-name>
				/// NO_NAMESPACE
				/// </java-name>
				[Dot42.DexImport("NO_NAMESPACE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string NO_NAMESPACE = "";
				/// <summary>
				/// <para>Signalize that parser is at the very beginning of the document and nothing was read yet. This event type can only be observed by calling getEvent() before the first call to next(), nextToken, or nextTag()).</para><para><para>next </para><simplesectsep></simplesectsep><para>nextToken </para></para>        
				/// </summary>
				/// <java-name>
				/// START_DOCUMENT
				/// </java-name>
				[Dot42.DexImport("START_DOCUMENT", "I", AccessFlags = 25)]
				public const int START_DOCUMENT = 0;
				/// <summary>
				/// <para>Logical end of the xml document. Returned from getEventType, next() and nextToken() when the end of the input document has been reached. </para><para><b>NOTE:</b> subsequent calls to  or  may result in exception being thrown.</para><para><para>next </para><simplesectsep></simplesectsep><para>nextToken </para></para>        
				/// </summary>
				/// <java-name>
				/// END_DOCUMENT
				/// </java-name>
				[Dot42.DexImport("END_DOCUMENT", "I", AccessFlags = 25)]
				public const int END_DOCUMENT = 1;
				/// <summary>
				/// <para>Returned from getEventType(), ,  when a start tag was read. The name of start tag is available from getName(), its namespace and prefix are available from getNamespace() and getPrefix() if . See getAttribute* methods to retrieve element attributes. See getNamespace* methods to retrieve newly declared namespaces.</para><para><para>next </para><simplesectsep></simplesectsep><para>nextToken </para><simplesectsep></simplesectsep><para>getName </para><simplesectsep></simplesectsep><para>getPrefix </para><simplesectsep></simplesectsep><para>getNamespace </para><simplesectsep></simplesectsep><para>getAttributeCount </para><simplesectsep></simplesectsep><para>getDepth </para><simplesectsep></simplesectsep><para>getNamespaceCount </para><simplesectsep></simplesectsep><para>getNamespace </para><simplesectsep></simplesectsep><para>FEATURE_PROCESS_NAMESPACES </para></para>        
				/// </summary>
				/// <java-name>
				/// START_TAG
				/// </java-name>
				[Dot42.DexImport("START_TAG", "I", AccessFlags = 25)]
				public const int START_TAG = 2;
				/// <summary>
				/// <para>Returned from getEventType(), , or  when an end tag was read. The name of start tag is available from getName(), its namespace and prefix are available from getNamespace() and getPrefix().</para><para><para>next </para><simplesectsep></simplesectsep><para>nextToken </para><simplesectsep></simplesectsep><para>getName </para><simplesectsep></simplesectsep><para>getPrefix </para><simplesectsep></simplesectsep><para>getNamespace </para><simplesectsep></simplesectsep><para>FEATURE_PROCESS_NAMESPACES </para></para>        
				/// </summary>
				/// <java-name>
				/// END_TAG
				/// </java-name>
				[Dot42.DexImport("END_TAG", "I", AccessFlags = 25)]
				public const int END_TAG = 3;
				/// <summary>
				/// <para>Character data was read and will is available by calling getText(). </para><para><b>Please note:</b>  will accumulate multiple events into one TEXT event, skipping IGNORABLE_WHITESPACE, PROCESSING_INSTRUCTION and COMMENT events, In contrast,  will stop reading text when any other event is observed. Also, when the state was reached by calling next(), the text value will be normalized, whereas getText() will return unnormalized content in the case of nextToken(). This allows an exact roundtrip without changing line ends when examining low level events, whereas for high level applications the text is normalized appropriately.</para><para><para>next </para><simplesectsep></simplesectsep><para>nextToken </para><simplesectsep></simplesectsep><para>getText </para></para>        
				/// </summary>
				/// <java-name>
				/// TEXT
				/// </java-name>
				[Dot42.DexImport("TEXT", "I", AccessFlags = 25)]
				public const int TEXT = 4;
				/// <summary>
				/// <para>A CDATA sections was just read; this token is available only from calls to . A call to next() will accumulate various text events into a single event of type TEXT. The text contained in the CDATA section is available by calling getText().</para><para><para>nextToken </para><simplesectsep></simplesectsep><para>getText </para></para>        
				/// </summary>
				/// <java-name>
				/// CDSECT
				/// </java-name>
				[Dot42.DexImport("CDSECT", "I", AccessFlags = 25)]
				public const int CDSECT = 5;
				/// <summary>
				/// <para>An entity reference was just read; this token is available from  only. The entity name is available by calling getName(). If available, the replacement text can be obtained by calling getText(); otherwise, the user is responsible for resolving the entity reference. This event type is never returned from next(); next() will accumulate the replacement text and other text events to a single TEXT event.</para><para><para>nextToken </para><simplesectsep></simplesectsep><para>getText </para></para>        
				/// </summary>
				/// <java-name>
				/// ENTITY_REF
				/// </java-name>
				[Dot42.DexImport("ENTITY_REF", "I", AccessFlags = 25)]
				public const int ENTITY_REF = 6;
				/// <summary>
				/// <para>Ignorable whitespace was just read. This token is available only from ). For non-validating parsers, this event is only reported by nextToken() when outside the root element. Validating parsers may be able to detect ignorable whitespace at other locations. The ignorable whitespace string is available by calling getText()</para><para><b>NOTE:</b> this is different from calling the isWhitespace() method, since text content may be whitespace but not ignorable.</para><para>Ignorable whitespace is skipped by next() automatically; this event type is never returned from next().</para><para><para>nextToken </para><simplesectsep></simplesectsep><para>getText </para></para>        
				/// </summary>
				/// <java-name>
				/// IGNORABLE_WHITESPACE
				/// </java-name>
				[Dot42.DexImport("IGNORABLE_WHITESPACE", "I", AccessFlags = 25)]
				public const int IGNORABLE_WHITESPACE = 7;
				/// <summary>
				/// <para>An XML processing instruction declaration was just read. This event type is available only via . getText() will return text that is inside the processing instruction. Calls to next() will skip processing instructions automatically. <para>nextToken </para><simplesectsep></simplesectsep><para>getText </para></para>        
				/// </summary>
				/// <java-name>
				/// PROCESSING_INSTRUCTION
				/// </java-name>
				[Dot42.DexImport("PROCESSING_INSTRUCTION", "I", AccessFlags = 25)]
				public const int PROCESSING_INSTRUCTION = 8;
				/// <summary>
				/// <para>An XML comment was just read. This event type is this token is available via  only; calls to next() will skip comments automatically. The content of the comment can be accessed using the getText() method.</para><para><para>nextToken </para><simplesectsep></simplesectsep><para>getText </para></para>        
				/// </summary>
				/// <java-name>
				/// COMMENT
				/// </java-name>
				[Dot42.DexImport("COMMENT", "I", AccessFlags = 25)]
				public const int COMMENT = 9;
				/// <summary>
				/// <para>An XML document type declaration was just read. This token is available from  only. The unparsed text inside the doctype is available via the getText() method.</para><para><para>nextToken </para><simplesectsep></simplesectsep><para>getText </para></para>        
				/// </summary>
				/// <java-name>
				/// DOCDECL
				/// </java-name>
				[Dot42.DexImport("DOCDECL", "I", AccessFlags = 25)]
				public const int DOCDECL = 10;
				/// <summary>
				/// <para>This array can be used to convert the event type integer constants such as START_TAG or TEXT to to a string. For example, the value of TYPES[START_TAG] is the string "START_TAG".</para><para>This array is intended for diagnostic output only. Relying on the contents of the array may be dangerous since malicious applications may alter the array, although it is final, due to limitations of the Java language. </para>        
				/// </summary>
				/// <java-name>
				/// TYPES
				/// </java-name>
				[Dot42.DexImport("TYPES", "[Ljava/lang/String;", AccessFlags = 25)]
				public static readonly string[] TYPES;
				/// <summary>
				/// <para>This feature determines whether the parser processes namespaces. As for all features, the default value is false. </para><para><b>NOTE:</b> The value can not be changed during parsing an must be set before parsing.</para><para><para>getFeature </para><simplesectsep></simplesectsep><para>setFeature </para></para>        
				/// </summary>
				/// <java-name>
				/// FEATURE_PROCESS_NAMESPACES
				/// </java-name>
				[Dot42.DexImport("FEATURE_PROCESS_NAMESPACES", "Ljava/lang/String;", AccessFlags = 25)]
				public const string FEATURE_PROCESS_NAMESPACES = "http://xmlpull.org/v1/doc/features.html#process-namespaces";
				/// <summary>
				/// <para>This feature determines whether namespace attributes are exposed via the attribute access methods. Like all features, the default value is false. This feature cannot be changed during parsing.</para><para><para>getFeature </para><simplesectsep></simplesectsep><para>setFeature </para></para>        
				/// </summary>
				/// <java-name>
				/// FEATURE_REPORT_NAMESPACE_ATTRIBUTES
				/// </java-name>
				[Dot42.DexImport("FEATURE_REPORT_NAMESPACE_ATTRIBUTES", "Ljava/lang/String;", AccessFlags = 25)]
				public const string FEATURE_REPORT_NAMESPACE_ATTRIBUTES = "http://xmlpull.org/v1/doc/features.html#report-namespace-prefixes";
				/// <summary>
				/// <para>This feature determines whether the document declaration is processed. If set to false, the DOCDECL event type is reported by nextToken() and ignored by next().</para><para>If this feature is activated, then the document declaration must be processed by the parser.</para><para><b>Please note:</b> If the document type declaration was ignored, entity references may cause exceptions later in the parsing process. The default value of this feature is false. It cannot be changed during parsing.</para><para><para>getFeature </para><simplesectsep></simplesectsep><para>setFeature </para></para>        
				/// </summary>
				/// <java-name>
				/// FEATURE_PROCESS_DOCDECL
				/// </java-name>
				[Dot42.DexImport("FEATURE_PROCESS_DOCDECL", "Ljava/lang/String;", AccessFlags = 25)]
				public const string FEATURE_PROCESS_DOCDECL = "http://xmlpull.org/v1/doc/features.html#process-docdecl";
				/// <summary>
				/// <para>If this feature is activated, all validation errors as defined in the XML 1.0 specification are reported. This implies that FEATURE_PROCESS_DOCDECL is true and both, the internal and external document type declaration will be processed. </para><para><b>Please Note:</b> This feature can not be changed during parsing. The default value is false.</para><para><para>getFeature </para><simplesectsep></simplesectsep><para>setFeature </para></para>        
				/// </summary>
				/// <java-name>
				/// FEATURE_VALIDATION
				/// </java-name>
				[Dot42.DexImport("FEATURE_VALIDATION", "Ljava/lang/String;", AccessFlags = 25)]
				public const string FEATURE_VALIDATION = "http://xmlpull.org/v1/doc/features.html#validation";
		}

		/// <summary>
		/// <para>XML Pull Parser is an interface that defines parsing functionality provided in  (visit this website to learn more about API and its implementations).</para><para>There are following different kinds of parser depending on which features are set:<ul><li><para><b>non-validating</b> parser as defined in XML 1.0 spec when FEATURE_PROCESS_DOCDECL is set to true </para></li><li><para><b>validating parser</b> as defined in XML 1.0 spec when FEATURE_VALIDATION is true (and that implies that FEATURE_PROCESS_DOCDECL is true) </para></li><li><para>when FEATURE_PROCESS_DOCDECL is false (this is default and if different value is required necessary must be changed before parsing is started) then parser behaves like XML 1.0 compliant non-validating parser under condition that <b>no DOCDECL is present</b> in XML documents (internal entites can still be defined with defineEntityReplacementText()). This mode of operation is intended <b>for operation in constrained environments</b> such as J2ME. </para></li></ul></para><para>There are two key methods: next() and nextToken(). While next() provides access to high level parsing events, nextToken() allows access to lower level tokens.</para><para>The current event state of the parser can be determined by calling the  method. Initially, the parser is in the  state.</para><para>The method  advances the parser to the next event. The int value returned from next determines the current parser state and is identical to the value returned from following calls to getEventType ().</para><para>Th following event types are seen by next()</para><para>after first next() or nextToken() (or any other next*() method) is called user application can obtain XML version, standalone and encoding from XML declaration in following ways:<ul><li><para><b>version</b>: getProperty("") returns String ("1.0") or null if XMLDecl was not read or if property is not supported </para></li><li><para><b>standalone</b>: getProperty("") returns Boolean: null if there was no standalone declaration or if property is not supported otherwise returns Boolean(true) if standalone="yes" and Boolean(false) when standalone="no" </para></li><li><para><b>encoding</b>: obtained from getInputEncoding() null if stream had unknown encoding (not set in setInputStream) and it was not declared in XMLDecl </para></li></ul></para><para>A minimal example for using this API may look as follows: <pre>
		///    import java.io.IOException;
		///    import java.io.StringReader;
		/// 
		///    import org.xmlpull.v1.XmlPullParser;
		///    import org.xmlpull.v1.;
		///    import org.xmlpull.v1.;
		/// 
		///    public class SimpleXmlPullApp
		///    {
		/// 
		///        public static void main (String args[])
		///            throws XmlPullParserException, IOException
		///        {
		///            XmlPullParserFactory factory = XmlPullParserFactory.newInstance();
		///            factory.setNamespaceAware(true);
		///            XmlPullParser xpp = factory.newPullParser();
		/// 
		///            xpp.( new StringReader ( "&amp;lt;foo&gt;Hello World!&amp;lt;/foo&gt;" ) );
		///            int eventType = xpp.getEventType();
		///            while (eventType != XmlPullParser.END_DOCUMENT) {
		///             if(eventType == XmlPullParser.START_DOCUMENT) {
		///                 System.out.println("Start document");
		///             } else if(eventType == XmlPullParser.START_TAG) {
		///                 System.out.println("Start tag "+xpp.);
		///             } else if(eventType == XmlPullParser.END_TAG) {
		///                 System.out.println("End tag "+xpp.getName());
		///             } else if(eventType == XmlPullParser.TEXT) {
		///                 System.out.println("Text "+xpp.);
		///             }
		///             eventType = xpp.next();
		///            }
		///            System.out.println("End document");
		///        }
		///    }
		///    </pre></para><para>The above example will generate the following output: <pre>
		///    Start document
		///    Start tag foo
		///    Text Hello World!
		///    End tag foo
		///    End document
		///    </pre></para><para>For more details on API usage, please refer to the quick Introduction available at </para><para><para>XmlPullParserFactory </para><simplesectsep></simplesectsep><para>defineEntityReplacementText </para><simplesectsep></simplesectsep><para>getName </para><simplesectsep></simplesectsep><para>getNamespace </para><simplesectsep></simplesectsep><para>getText </para><simplesectsep></simplesectsep><para>next </para><simplesectsep></simplesectsep><para>nextToken </para><simplesectsep></simplesectsep><para>setInput </para><simplesectsep></simplesectsep><para>FEATURE_PROCESS_DOCDECL </para><simplesectsep></simplesectsep><para>FEATURE_VALIDATION </para><simplesectsep></simplesectsep><para>START_DOCUMENT </para><simplesectsep></simplesectsep><para>START_TAG </para><simplesectsep></simplesectsep><para>TEXT </para><simplesectsep></simplesectsep><para>END_TAG </para><simplesectsep></simplesectsep><para>END_DOCUMENT</para><para> </para><simplesectsep></simplesectsep><para> </para></para>    
		/// </summary>
		/// <java-name>
		/// org/xmlpull/v1/XmlPullParser
		/// </java-name>
		[Dot42.DexImport("org/xmlpull/v1/XmlPullParser", AccessFlags = 1537)]
		public partial interface IXmlPullParser
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Use this call to change the general behaviour of the parser, such as namespace processing or doctype declaration handling. This method must be called before the first call to next or nextToken. Otherwise, an exception is thrown. </para><para>Example: call setFeature(FEATURE_PROCESS_NAMESPACES, true) in order to switch on namespace processing. The initial settings correspond to the properties requested from the XML Pull Parser factory. If none were requested, all features are deactivated by default.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setFeature
				/// </java-name>
				[Dot42.DexImport("setFeature", "(Ljava/lang/String;Z)V", AccessFlags = 1025)]
				void SetFeature(string name, bool state) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the current value of the given feature. </para><para><b>Please note:</b> unknown features are <b>always</b> returned as false.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The value of the feature. </para>
				/// </returns>
				/// <java-name>
				/// getFeature
				/// </java-name>
				[Dot42.DexImport("getFeature", "(Ljava/lang/String;)Z", AccessFlags = 1025)]
				bool GetFeature(string name) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Set the value of a property.</para><para>The property name is any fully-qualified URI.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setProperty
				/// </java-name>
				[Dot42.DexImport("setProperty", "(Ljava/lang/String;Ljava/lang/Object;)V", AccessFlags = 1025)]
				void SetProperty(string name, object value) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Look up the value of a property.</para><para>The property name is any fully-qualified URI. </para><para><b>NOTE:</b> unknown properties are <b>always</b> returned as null.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The value of named property. </para>
				/// </returns>
				/// <java-name>
				/// getProperty
				/// </java-name>
				[Dot42.DexImport("getProperty", "(Ljava/lang/String;)Ljava/lang/Object;", AccessFlags = 1025)]
				object GetProperty(string name) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Set the input source for parser to the given reader and resets the parser. The event type is set to the initial value START_DOCUMENT. Setting the reader to null will just stop parsing and reset parser state, allowing the parser to free internal resources such as parsing buffers. </para>        
				/// </summary>
				/// <java-name>
				/// setInput
				/// </java-name>
				[Dot42.DexImport("setInput", "(Ljava/io/Reader;)V", AccessFlags = 1025)]
				void SetInput(global::Java.Io.Reader @in) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets the input stream the parser is going to process. This call resets the parser state and sets the event type to the initial value START_DOCUMENT.</para><para><b>NOTE:</b> If an input encoding string is passed, it MUST be used. Otherwise, if inputEncoding is null, the parser SHOULD try to determine input encoding following XML 1.0 specification (see below). If encoding detection is supported then following feature  MUST be true amd otherwise it must be false</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setInput
				/// </java-name>
				[Dot42.DexImport("setInput", "(Ljava/io/InputStream;Ljava/lang/String;)V", AccessFlags = 1025)]
				void SetInput(global::Java.Io.InputStream inputStream, string inputEncoding) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the input encoding if known, null otherwise. If setInput(InputStream, inputEncoding) was called with an inputEncoding value other than null, this value must be returned from this method. Otherwise, if inputEncoding is null and the parser supports the encoding detection feature (), it must return the detected encoding. If setInput(Reader) was called, null is returned. After first call to next if XML declaration was present this method will return encoding declared. </para>        
				/// </summary>
				/// <java-name>
				/// getInputEncoding
				/// </java-name>
				[Dot42.DexImport("getInputEncoding", "()Ljava/lang/String;", AccessFlags = 1025)]
				string GetInputEncoding() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Set new value for entity replacement text as defined in . If FEATURE_PROCESS_DOCDECL or FEATURE_VALIDATION are set, calling this function will result in an exception  when processing of DOCDECL is enabled, there is no need to the entity replacement text manually.</para><para>The motivation for this function is to allow very small implementations of XMLPULL that will work in J2ME environments. Though these implementations may not be able to process the document type declaration, they still can work with known DTDs by using this function.</para><para><b>Please notes:</b> The given value is used literally as replacement text and it corresponds to declaring entity in DTD that has all special characters escaped: left angle bracket is replaced with &amp;lt;, ampersand with &amp;amp; and so on.</para><para><b>Note:</b> The given value is the literal replacement text and must not contain any other entity reference (if it contains any entity reference there will be no further replacement).</para><para><b>Note:</b> The list of pre-defined entity names will always contain standard XML entities such as amp (&amp;amp;), lt (&amp;lt;), gt (&amp;gt;), quot (&amp;quot;), and apos (&amp;apos;). Those cannot be redefined by this method!</para><para><para>setInput </para><simplesectsep></simplesectsep><para>FEATURE_PROCESS_DOCDECL </para><simplesectsep></simplesectsep><para>FEATURE_VALIDATION </para></para>        
				/// </summary>
				/// <java-name>
				/// defineEntityReplacementText
				/// </java-name>
				[Dot42.DexImport("defineEntityReplacementText", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1025)]
				void DefineEntityReplacementText(string entityName, string replacementText) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the numbers of elements in the namespace stack for the given depth. If namespaces are not enabled, 0 is returned.</para><para><b>NOTE:</b> when parser is on END_TAG then it is allowed to call this function with getDepth()+1 argument to retrieve position of namespace prefixes and URIs that were declared on corresponding START_TAG. </para><para><b>NOTE:</b> to retrieve list of namespaces declared in current element:<pre>
				///              XmlPullParser pp = ...
				///              int nsStart = pp.getNamespaceCount(pp.getDepth()-1);
				///              int nsEnd = pp.getNamespaceCount(pp.getDepth());
				///              for (int i = nsStart; i &lt; nsEnd; i++) {
				///                 String prefix = pp.getNamespacePrefix(i);
				///                 String ns = pp.getNamespaceUri(i);
				///                  // ...
				///             }
				///        </pre></para><para><para>getNamespacePrefix </para><simplesectsep></simplesectsep><para>getNamespaceUri </para><simplesectsep></simplesectsep><para>getNamespace() </para><simplesectsep></simplesectsep><para>getNamespace(String) </para></para>        
				/// </summary>
				/// <java-name>
				/// getNamespaceCount
				/// </java-name>
				[Dot42.DexImport("getNamespaceCount", "(I)I", AccessFlags = 1025)]
				int GetNamespaceCount(int depth) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the namespace prefix for the given position in the namespace stack. Default namespace declaration (xmlns='...') will have null as prefix. If the given index is out of range, an exception is thrown. </para><para><b>Please note:</b> when the parser is on an END_TAG, namespace prefixes that were declared in the corresponding START_TAG are still accessible although they are no longer in scope. </para>        
				/// </summary>
				/// <java-name>
				/// getNamespacePrefix
				/// </java-name>
				[Dot42.DexImport("getNamespacePrefix", "(I)Ljava/lang/String;", AccessFlags = 1025)]
				string GetNamespacePrefix(int pos) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the namespace URI for the given position in the namespace stack If the position is out of range, an exception is thrown. </para><para><b>NOTE:</b> when parser is on END_TAG then namespace prefixes that were declared in corresponding START_TAG are still accessible even though they are not in scope </para>        
				/// </summary>
				/// <java-name>
				/// getNamespaceUri
				/// </java-name>
				[Dot42.DexImport("getNamespaceUri", "(I)Ljava/lang/String;", AccessFlags = 1025)]
				string GetNamespaceUri(int pos) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the URI corresponding to the given prefix, depending on current state of the parser.</para><para>If the prefix was not declared in the current scope, null is returned. The default namespace is included in the namespace table and is available via getNamespace (null).</para><para>This method is a convenience method for</para><para><pre>
				///         for (int i = getNamespaceCount(getDepth ())-1; i &gt;= 0; i) {
				///          if (getNamespacePrefix(i).equals( prefix )) {
				///            return getNamespaceUri(i);
				///          }
				///         }
				///         return null;
				///        </pre></para><para><b>Please note:</b> parser implementations may provide more efficient lookup, e.g. using a Hashtable. The 'xml' prefix is bound to "http://www.w3.org/XML/1998/namespace", as defined in the  specification. Analogous, the 'xmlns' prefix is resolved to </para><para><para>getNamespaceCount </para><simplesectsep></simplesectsep><para>getNamespacePrefix </para><simplesectsep></simplesectsep><para>getNamespaceUri </para></para>        
				/// </summary>
				/// <java-name>
				/// getNamespace
				/// </java-name>
				[Dot42.DexImport("getNamespace", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1025)]
				string GetNamespace(string prefix) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the current depth of the element. Outside the root element, the depth is 0. The depth is incremented by 1 when a start tag is reached. The depth is decremented AFTER the end tag event was observed.</para><para><pre>
				///        &lt;! outside &gt;     0
				///        &lt;root&gt;                  1
				///          sometext                 1
				///            &lt;foobar&gt;         2
				///            &lt;/foobar&gt;        2
				///        &lt;/root&gt;              1
				///        &lt;! outside &gt;     0
				///        </pre> </para>        
				/// </summary>
				/// <java-name>
				/// getDepth
				/// </java-name>
				[Dot42.DexImport("getDepth", "()I", AccessFlags = 1025)]
				int GetDepth() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns a short text describing the current parser state, including the position, a description of the current event and the data source if known. This method is especially useful to provide meaningful error messages and for debugging purposes. </para>        
				/// </summary>
				/// <java-name>
				/// getPositionDescription
				/// </java-name>
				[Dot42.DexImport("getPositionDescription", "()Ljava/lang/String;", AccessFlags = 1025)]
				string GetPositionDescription() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the current line number, starting from 1. When the parser does not know the current line number or can not determine it, -1 is returned (e.g. for WBXML).</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>current line number or -1 if unknown. </para>
				/// </returns>
				/// <java-name>
				/// getLineNumber
				/// </java-name>
				[Dot42.DexImport("getLineNumber", "()I", AccessFlags = 1025)]
				int GetLineNumber() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the current column number, starting from 0. When the parser does not know the current column number or can not determine it, -1 is returned (e.g. for WBXML).</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>current column number or -1 if unknown. </para>
				/// </returns>
				/// <java-name>
				/// getColumnNumber
				/// </java-name>
				[Dot42.DexImport("getColumnNumber", "()I", AccessFlags = 1025)]
				int GetColumnNumber() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Checks whether the current TEXT event contains only whitespace characters. For IGNORABLE_WHITESPACE, this is always true. For TEXT and CDSECT, false is returned when the current event text contains at least one non-white space character. For any other event type an exception is thrown.</para><para><b>Please note:</b> non-validating parsers are not able to distinguish whitespace and ignorable whitespace, except from whitespace outside the root element. Ignorable whitespace is reported as separate event, which is exposed via nextToken only. </para>        
				/// </summary>
				/// <java-name>
				/// isWhitespace
				/// </java-name>
				[Dot42.DexImport("isWhitespace", "()Z", AccessFlags = 1025)]
				bool IsWhitespace() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the text content of the current event as String. The value returned depends on current event type, for example for TEXT event it is element content (this is typical case when next() is used).</para><para>See description of nextToken() for detailed description of possible returned values for different types of events.</para><para><b>NOTE:</b> in case of ENTITY_REF, this method returns the entity replacement text (or null if not available). This is the only case where getText() and getTextCharacters() return different values.</para><para><para>getEventType </para><simplesectsep></simplesectsep><para>next </para><simplesectsep></simplesectsep><para>nextToken </para></para>        
				/// </summary>
				/// <java-name>
				/// getText
				/// </java-name>
				[Dot42.DexImport("getText", "()Ljava/lang/String;", AccessFlags = 1025)]
				string GetText() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the buffer that contains the text of the current event, as well as the start offset and length relevant for the current event. See getText(), next() and nextToken() for description of possible returned values.</para><para><b>Please note:</b> this buffer must not be modified and its content MAY change after a call to next() or nextToken(). This method will always return the same value as getText(), except for ENTITY_REF. In the case of ENTITY ref, getText() returns the replacement text and this method returns the actual input buffer containing the entity name. If getText() returns null, this method returns null as well and the values returned in the holder array MUST be -1 (both start and length).</para><para><para>getText </para><simplesectsep></simplesectsep><para>next </para><simplesectsep></simplesectsep><para>nextToken</para></para>        
				/// </summary>
				/// <returns>
				/// <para>char buffer that contains the text of the current event (null if the current event has no text associated). </para>
				/// </returns>
				/// <java-name>
				/// getTextCharacters
				/// </java-name>
				[Dot42.DexImport("getTextCharacters", "([I)[C", AccessFlags = 1025)]
				char[] GetTextCharacters(int[] holderForStartAndLength) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the namespace URI of the current element. The default namespace is represented as empty string. If namespaces are not enabled, an empty String ("") is always returned. The current event must be START_TAG or END_TAG; otherwise, null is returned. </para>        
				/// </summary>
				/// <java-name>
				/// getNamespace
				/// </java-name>
				[Dot42.DexImport("getNamespace", "()Ljava/lang/String;", AccessFlags = 1025)]
				string GetNamespace() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>For START_TAG or END_TAG events, the (local) name of the current element is returned when namespaces are enabled. When namespace processing is disabled, the raw name is returned. For ENTITY_REF events, the entity name is returned. If the current event is not START_TAG, END_TAG, or ENTITY_REF, null is returned. </para><para><b>Please note:</b> To reconstruct the raw element name when namespaces are enabled and the prefix is not null, you will need to add the prefix and a colon to localName.. </para>        
				/// </summary>
				/// <java-name>
				/// getName
				/// </java-name>
				[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1025)]
				string GetName() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the prefix of the current element. If the element is in the default namespace (has no prefix), null is returned. If namespaces are not enabled, or the current event is not START_TAG or END_TAG, null is returned. </para>        
				/// </summary>
				/// <java-name>
				/// getPrefix
				/// </java-name>
				[Dot42.DexImport("getPrefix", "()Ljava/lang/String;", AccessFlags = 1025)]
				string GetPrefix() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns true if the current event is START_TAG and the tag is degenerated (e.g. &lt;foobar/&gt;). </para><para><b>NOTE:</b> if the parser is not on START_TAG, an exception will be thrown. </para>        
				/// </summary>
				/// <java-name>
				/// isEmptyElementTag
				/// </java-name>
				[Dot42.DexImport("isEmptyElementTag", "()Z", AccessFlags = 1025)]
				bool IsEmptyElementTag() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the number of attributes of the current start tag, or -1 if the current event type is not START_TAG</para><para><para>getAttributeNamespace </para><simplesectsep></simplesectsep><para>getAttributeName </para><simplesectsep></simplesectsep><para>getAttributePrefix </para><simplesectsep></simplesectsep><para>getAttributeValue </para></para>        
				/// </summary>
				/// <java-name>
				/// getAttributeCount
				/// </java-name>
				[Dot42.DexImport("getAttributeCount", "()I", AccessFlags = 1025)]
				int GetAttributeCount() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the namespace URI of the attribute with the given index (starts from 0). Returns an empty string ("") if namespaces are not enabled or the attribute has no namespace. Throws an IndexOutOfBoundsException if the index is out of range or the current event type is not START_TAG.</para><para><b>NOTE:</b> if FEATURE_REPORT_NAMESPACE_ATTRIBUTES is set then namespace attributes (xmlns:ns='...') must be reported with namespace  (visit this URL for description!). The default namespace attribute (xmlns="...") will be reported with empty namespace. </para><para><b>NOTE:</b>The xml prefix is bound as defined in  specification to "http://www.w3.org/XML/1998/namespace".</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>attribute namespace, empty string ("") is returned if namespaces processing is not enabled or namespaces processing is enabled but attribute has no namespace (it has no prefix). </para>
				/// </returns>
				/// <java-name>
				/// getAttributeNamespace
				/// </java-name>
				[Dot42.DexImport("getAttributeNamespace", "(I)Ljava/lang/String;", AccessFlags = 1025)]
				string GetAttributeNamespace(int index) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the local name of the specified attribute if namespaces are enabled or just attribute name if namespaces are disabled. Throws an IndexOutOfBoundsException if the index is out of range or current event type is not START_TAG.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>attribute name (null is never returned) </para>
				/// </returns>
				/// <java-name>
				/// getAttributeName
				/// </java-name>
				[Dot42.DexImport("getAttributeName", "(I)Ljava/lang/String;", AccessFlags = 1025)]
				string GetAttributeName(int index) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the prefix of the specified attribute Returns null if the element has no prefix. If namespaces are disabled it will always return null. Throws an IndexOutOfBoundsException if the index is out of range or current event type is not START_TAG.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>attribute prefix or null if namespaces processing is not enabled. </para>
				/// </returns>
				/// <java-name>
				/// getAttributePrefix
				/// </java-name>
				[Dot42.DexImport("getAttributePrefix", "(I)Ljava/lang/String;", AccessFlags = 1025)]
				string GetAttributePrefix(int index) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the type of the specified attribute If parser is non-validating it MUST return CDATA.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>attribute type (null is never returned) </para>
				/// </returns>
				/// <java-name>
				/// getAttributeType
				/// </java-name>
				[Dot42.DexImport("getAttributeType", "(I)Ljava/lang/String;", AccessFlags = 1025)]
				string GetAttributeType(int index) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns if the specified attribute was not in input was declared in XML. If parser is non-validating it MUST always return false. This information is part of XML infoset:</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>false if attribute was in input </para>
				/// </returns>
				/// <java-name>
				/// isAttributeDefault
				/// </java-name>
				[Dot42.DexImport("isAttributeDefault", "(I)Z", AccessFlags = 1025)]
				bool IsAttributeDefault(int index) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the given attributes value. Throws an IndexOutOfBoundsException if the index is out of range or current event type is not START_TAG.</para><para><b>NOTE:</b> attribute value must be normalized (including entity replacement text if PROCESS_DOCDECL is false) as described in </para><para><para>defineEntityReplacementText</para></para>        
				/// </summary>
				/// <returns>
				/// <para>value of attribute (null is never returned) </para>
				/// </returns>
				/// <java-name>
				/// getAttributeValue
				/// </java-name>
				[Dot42.DexImport("getAttributeValue", "(I)Ljava/lang/String;", AccessFlags = 1025)]
				string GetAttributeValue(int index) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the attributes value identified by namespace URI and namespace localName. If namespaces are disabled namespace must be null. If current event type is not START_TAG then IndexOutOfBoundsException will be thrown.</para><para><b>NOTE:</b> attribute value must be normalized (including entity replacement text if PROCESS_DOCDECL is false) as described in </para><para><para>defineEntityReplacementText</para></para>        
				/// </summary>
				/// <returns>
				/// <para>value of attribute or null if attribute with given name does not exist </para>
				/// </returns>
				/// <java-name>
				/// getAttributeValue
				/// </java-name>
				[Dot42.DexImport("getAttributeValue", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1025)]
				string GetAttributeValue(string @namespace, string name) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the type of the current event (START_TAG, END_TAG, TEXT, etc.)</para><para><para>next() </para><simplesectsep></simplesectsep><para>nextToken() </para></para>        
				/// </summary>
				/// <java-name>
				/// getEventType
				/// </java-name>
				[Dot42.DexImport("getEventType", "()I", AccessFlags = 1025)]
				int GetEventType() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Get next parsing event - element content wil be coalesced and only one TEXT event must be returned for whole element content (comments and processing instructions will be ignored and entity references must be expanded or exception mus be thrown if entity reference can not be expanded). If element content is empty (content is "") then no TEXT event will be reported.</para><para><b>NOTE:</b> empty element (such as &lt;tag/&gt;) will be reported with two separate events: START_TAG, END_TAG - it must be so to preserve parsing equivalency of empty element to &lt;tag&gt;&lt;/tag&gt;. (see isEmptyElementTag ())</para><para><para>isEmptyElementTag </para><simplesectsep></simplesectsep><para>START_TAG </para><simplesectsep></simplesectsep><para>TEXT </para><simplesectsep></simplesectsep><para>END_TAG </para><simplesectsep></simplesectsep><para>END_DOCUMENT </para></para>        
				/// </summary>
				/// <java-name>
				/// next
				/// </java-name>
				[Dot42.DexImport("next", "()I", AccessFlags = 1025)]
				int Next() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>This method works similarly to next() but will expose additional event types (COMMENT, CDSECT, DOCDECL, ENTITY_REF, PROCESSING_INSTRUCTION, or IGNORABLE_WHITESPACE) if they are available in input.</para><para>If special feature  (identified by URI: ) is enabled it is possible to do XML document round trip ie. reproduce exectly on output the XML input using getText(): returned content is always unnormalized (exactly as in input). Otherwise returned content is end-of-line normalized as described  and. Also when this feature is enabled exact content of START_TAG, END_TAG, DOCDECL and PROCESSING_INSTRUCTION is available.</para><para>Here is the list of tokens that can be returned from nextToken() and what getText() and getTextCharacters() returns:</para><para><b>NOTE:</b> there is no guarantee that there will only one TEXT or IGNORABLE_WHITESPACE event from nextToken() as parser may chose to deliver element content in multiple tokens (dividing element content into chunks)</para><para><b>NOTE:</b> whether returned text of token is end-of-line normalized is depending on FEATURE_XML_ROUNDTRIP.</para><para><b>NOTE:</b> XMLDecl (&lt;?xml ...?&gt;) is not reported but its content is available through optional properties (see class description above).</para><para><para>next </para><simplesectsep></simplesectsep><para>START_TAG </para><simplesectsep></simplesectsep><para>TEXT </para><simplesectsep></simplesectsep><para>END_TAG </para><simplesectsep></simplesectsep><para>END_DOCUMENT </para><simplesectsep></simplesectsep><para>COMMENT </para><simplesectsep></simplesectsep><para>DOCDECL </para><simplesectsep></simplesectsep><para>PROCESSING_INSTRUCTION </para><simplesectsep></simplesectsep><para>ENTITY_REF </para><simplesectsep></simplesectsep><para>IGNORABLE_WHITESPACE </para></para>        
				/// </summary>
				/// <java-name>
				/// nextToken
				/// </java-name>
				[Dot42.DexImport("nextToken", "()I", AccessFlags = 1025)]
				int NextToken() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Test if the current event is of the given type and if the namespace and name do match. null will match any namespace and any name. If the test is not passed, an exception is thrown. The exception text indicates the parser position, the expected event and the current event that is not meeting the requirement.</para><para>Essentially it does this <pre>
				///         if (type != getEventType()
				///         || (namespace != null &amp;&amp;  !namespace.equals( getNamespace () ) )
				///         || (name != null &amp;&amp;  !name.equals( getName() ) ) )
				///            throw new XmlPullParserException( "expected "+ TYPES[ type ]+getPositionDescription());
				///        </pre> </para>        
				/// </summary>
				/// <java-name>
				/// require
				/// </java-name>
				[Dot42.DexImport("require", "(ILjava/lang/String;Ljava/lang/String;)V", AccessFlags = 1025)]
				void Require(int type, string @namespace, string name) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>If current event is START_TAG then if next element is TEXT then element content is returned or if next event is END_TAG then empty string is returned, otherwise exception is thrown. After calling this function successfully parser will be positioned on END_TAG.</para><para>The motivation for this function is to allow to parse consistently both empty elements and elements that has non empty content, for example for input: <ol><li><para>&lt;tag&gt;foo&lt;/tag&gt; </para></li><li><para>&lt;tag&gt;&lt;/tag&gt; (which is equivalent to &lt;tag/&gt; both input can be parsed with the same code: <pre>
				///          p.nextTag()
				///          p.requireEvent(p.START_TAG, "", "tag");
				///          String content = p.nextText();
				///          p.requireEvent(p.END_TAG, "", "tag");
				///        </pre> This function together with nextTag make it very easy to parse XML that has no mixed content.</para><para></para><para>Essentially it does this <pre>
				///         if(getEventType() != START_TAG) {
				///            throw new XmlPullParserException(
				///              "parser must be on START_TAG to read next text", this, null);
				///         }
				///         int eventType = next();
				///         if(eventType == TEXT) {
				///            String result = getText();
				///            eventType = next();
				///            if(eventType != END_TAG) {
				///              throw new XmlPullParserException(
				///                 "event TEXT it must be immediately followed by END_TAG", this, null);
				///             }
				///             return result;
				///         } else if(eventType == END_TAG) {
				///            return "";
				///         } else {
				///            throw new XmlPullParserException(
				///              "parser must be on START_TAG or TEXT to read text", this, null);
				///         }
				///        </pre></para><para></para><para><b>Warning:</b> Prior to API level 14, the pull parser returned by <c>       android.util.Xml </c> did not always advance to the END_TAG event when this method was called. Work around by using manually advancing after calls to nextText(): <pre>
				///         String text = xpp.nextText();
				///         if (xpp.getEventType() != XmlPullParser.END_TAG) {
				///             xpp.next();
				///         }
				///        </pre> </para></li></ol></para>        
				/// </summary>
				/// <java-name>
				/// nextText
				/// </java-name>
				[Dot42.DexImport("nextText", "()Ljava/lang/String;", AccessFlags = 1025)]
				string NextText() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Call next() and return event if it is START_TAG or END_TAG otherwise throw an exception. It will skip whitespace TEXT before actual tag if any.</para><para>essentially it does this <pre>
				///          int eventType = next();
				///          if(eventType == TEXT &amp;&amp;  isWhitespace()) {   // skip whitespace
				///             eventType = next();
				///          }
				///          if (eventType != START_TAG &amp;&amp;  eventType != END_TAG) {
				///             throw new XmlPullParserException("expected start or end tag", this, null);
				///          }
				///          return eventType;
				///        </pre> </para>        
				/// </summary>
				/// <java-name>
				/// nextTag
				/// </java-name>
				[Dot42.DexImport("nextTag", "()I", AccessFlags = 1025)]
				int NextTag() /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>This class is used to create implementations of XML Pull Parser defined in XMPULL V1 API. The name of actual factory class will be determined based on several parameters. It works similar to JAXP but tailored to work in J2ME environments (no access to system properties or file system) so name of parser class factory to use and its class used for loading (no class loader - on J2ME no access to context class loaders) must be passed explicitly. If no name of parser factory was passed (or is null) it will try to find name by searching in CLASSPATH for META-INF/services/org.xmlpull.v1.XmlPullParserFactory resource that should contain a comma separated list of class names of factories or parsers to try (in order from left to the right). If none found, it will throw an exception.</para><para><br></br><b>NOTE:</b>In J2SE or J2EE environments, you may want to use <code>newInstance(property, classLoaderCtx)</code> where first argument is <code>System.getProperty(XmlPullParserFactory.PROPERTY_NAME)</code> and second is <code>Thread.getContextClassLoader().getClass()</code> .</para><para><para>XmlPullParser</para><para> </para><simplesectsep></simplesectsep><para>Stefan Haustein </para></para>    
		/// </summary>
		/// <java-name>
		/// org/xmlpull/v1/XmlPullParserFactory
		/// </java-name>
		[Dot42.DexImport("org/xmlpull/v1/XmlPullParserFactory", AccessFlags = 33)]
		public partial class XmlPullParserFactory
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Name of the system or midlet property that should be used for a system property containing a comma separated list of factory or parser class names (value: org.xmlpull.v1.XmlPullParserFactory). </para>        
				/// </summary>
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
				/// <summary>
				/// <para>Protected constructor to be called by factory implementations. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal XmlPullParserFactory() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Set the features to be set when XML Pull Parser is created by this factory. </para><para><b>NOTE:</b> factory features are not used for XML Serializer.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setFeature
				/// </java-name>
				[Dot42.DexImport("setFeature", "(Ljava/lang/String;Z)V", AccessFlags = 1)]
				public virtual void SetFeature(string name, bool state) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Return the current value of the feature with given name. </para><para><b>NOTE:</b> factory features are not used for XML Serializer.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The value of named feature. Unknown features are &lt;string&gt;always returned as false </para>
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
				/// <para>Specifies that the parser produced by this factory will provide support for XML namespaces. By default the value of this is set to false.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setNamespaceAware
				/// </java-name>
				[Dot42.DexImport("setNamespaceAware", "(Z)V", AccessFlags = 1)]
				public virtual void SetNamespaceAware(bool awareness) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Indicates whether or not the factory is configured to produce parsers which are namespace aware (it simply set feature XmlPullParser.FEATURE_PROCESS_NAMESPACES to true or false).</para><para></para>        
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
				/// <para>Specifies that the parser produced by this factory will be validating (it simply set feature XmlPullParser.FEATURE_VALIDATION to true or false).</para><para>By default the value of this is set to false.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setValidating
				/// </java-name>
				[Dot42.DexImport("setValidating", "(Z)V", AccessFlags = 1)]
				public virtual void SetValidating(bool validating) /* MethodBuilder.Create */ 
				{
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
				/// <para>Creates a new instance of a XML Pull Parser using the currently configured factory features.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>A new instance of a XML Pull Parser. </para>
				/// </returns>
				/// <java-name>
				/// newPullParser
				/// </java-name>
				[Dot42.DexImport("newPullParser", "()Lorg/xmlpull/v1/XmlPullParser;", AccessFlags = 1)]
				public virtual global::Org.Xmlpull.V1.IXmlPullParser NewPullParser() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Xmlpull.V1.IXmlPullParser);
				}

				/// <summary>
				/// <para>Creates a new instance of a XML Serializer.</para><para><b>NOTE:</b> factory features are not used for XML Serializer.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>A new instance of a XML Serializer. </para>
				/// </returns>
				/// <java-name>
				/// newSerializer
				/// </java-name>
				[Dot42.DexImport("newSerializer", "()Lorg/xmlpull/v1/XmlSerializer;", AccessFlags = 1)]
				public virtual global::Org.Xmlpull.V1.IXmlSerializer NewSerializer() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Xmlpull.V1.IXmlSerializer);
				}

				/// <summary>
				/// <para>Create a new instance of a PullParserFactory that can be used to create XML pull parsers (see class description for more details).</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a new instance of a PullParserFactory, as returned by newInstance (null, null); </para>
				/// </returns>
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
				public static global::Org.Xmlpull.V1.XmlPullParserFactory NewInstance(string classNames, global::System.Type context) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Xmlpull.V1.XmlPullParserFactory);
				}

		}

		/// <summary>
		/// <para>Define an interface to serialization of XML Infoset. This interface abstracts away if serialized XML is XML 1.0 compatible text or other formats of XML 1.0 serializations (such as binary XML for example with WBXML).</para><para><b>PLEASE NOTE:</b> This interface will be part of XmlPull 1.2 API. It is included as basis for discussion. It may change in any way.</para><para>Exceptions that may be thrown are: IOException or runtime exception (more runtime exceptions can be thrown but are not declared and as such have no semantics defined for this interface): <ul><li><para><b>IllegalArgumentException</b> - for almost all methods to signal that argument is illegal </para></li><li><para><b>IllegalStateException</b> - to signal that call has good arguments but is not expected here (violation of contract) and for features/properties when requesting setting unimplemented feature/property (UnsupportedOperationException would be better but it is not in MIDP) </para></li></ul></para><para><b>NOTE:</b> writing CDSECT, ENTITY_REF, IGNORABLE_WHITESPACE, PROCESSING_INSTRUCTION, COMMENT, and DOCDECL in some implementations may not be supported (for example when serializing to WBXML). In such case IllegalStateException will be thrown and it is recommended to use an optional feature to signal that implementation is not supporting this kind of output. </para>    
		/// </summary>
		/// <java-name>
		/// org/xmlpull/v1/XmlSerializer
		/// </java-name>
		[Dot42.DexImport("org/xmlpull/v1/XmlSerializer", AccessFlags = 1537)]
		public partial interface IXmlSerializer
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Set feature identified by name (recommended to be URI for uniqueness). Some well known optional features are defined in .</para><para>If feature is not recognized or can not be set then IllegalStateException MUST be thrown.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setFeature
				/// </java-name>
				[Dot42.DexImport("setFeature", "(Ljava/lang/String;Z)V", AccessFlags = 1025)]
				void SetFeature(string name, bool state) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Return the current value of the feature with given name. </para><para><b>NOTE:</b> unknown properties are <b>always</b> returned as null</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The value of named feature. </para>
				/// </returns>
				/// <java-name>
				/// getFeature
				/// </java-name>
				[Dot42.DexImport("getFeature", "(Ljava/lang/String;)Z", AccessFlags = 1025)]
				bool GetFeature(string name) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Set the value of a property. (the property name is recommended to be URI for uniqueness). Some well known optional properties are defined in .</para><para>If property is not recognized or can not be set then IllegalStateException MUST be thrown.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setProperty
				/// </java-name>
				[Dot42.DexImport("setProperty", "(Ljava/lang/String;Ljava/lang/Object;)V", AccessFlags = 1025)]
				void SetProperty(string name, object value) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Look up the value of a property.</para><para>The property name is any fully-qualified URI. I </para><para><b>NOTE:</b> unknown properties are &lt;string&gt;always returned as null</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The value of named property. </para>
				/// </returns>
				/// <java-name>
				/// getProperty
				/// </java-name>
				[Dot42.DexImport("getProperty", "(Ljava/lang/String;)Ljava/lang/Object;", AccessFlags = 1025)]
				object GetProperty(string name) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Set to use binary output stream with given encoding. </para>        
				/// </summary>
				/// <java-name>
				/// setOutput
				/// </java-name>
				[Dot42.DexImport("setOutput", "(Ljava/io/OutputStream;Ljava/lang/String;)V", AccessFlags = 1025)]
				void SetOutput(global::Java.Io.OutputStream os, string encoding) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Set the output to the given writer. </para><para><b>WARNING</b> no information about encoding is available! </para>        
				/// </summary>
				/// <java-name>
				/// setOutput
				/// </java-name>
				[Dot42.DexImport("setOutput", "(Ljava/io/Writer;)V", AccessFlags = 1025)]
				void SetOutput(global::Java.Io.Writer writer) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Write &lt;&amp;#63;xml declaration with encoding (if encoding not null) and standalone flag (if standalone not null) This method can only be called just after setOutput. </para>        
				/// </summary>
				/// <java-name>
				/// startDocument
				/// </java-name>
				[Dot42.DexImport("startDocument", "(Ljava/lang/String;Ljava/lang/Boolean;)V", AccessFlags = 1025)]
				void StartDocument(string encoding, bool? standalone) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Finish writing. All unclosed start tags will be closed and output will be flushed. After calling this method no more output can be serialized until next call to setOutput() </para>        
				/// </summary>
				/// <java-name>
				/// endDocument
				/// </java-name>
				[Dot42.DexImport("endDocument", "()V", AccessFlags = 1025)]
				void EndDocument() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Binds the given prefix to the given namespace. This call is valid for the next element including child elements. The prefix and namespace MUST be always declared even if prefix is not used in element (startTag() or attribute()) - for XML 1.0 it must result in declaring <code>xmlns:prefix='namespace'</code> (or <code>xmlns:prefix="namespace"</code> depending what character is used to quote attribute value).</para><para><b>NOTE:</b> this method MUST be called directly before startTag() and if anything but startTag() or setPrefix() is called next there will be exception. </para><para><b>NOTE:</b> prefixes "xml" and "xmlns" are already bound and can not be redefined see: . </para><para><b>NOTE:</b> to set default namespace use as prefix empty string.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setPrefix
				/// </java-name>
				[Dot42.DexImport("setPrefix", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1025)]
				void SetPrefix(string prefix, string @namespace) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Return namespace that corresponds to given prefix If there is no prefix bound to this namespace return null but if generatePrefix is false then return generated prefix.</para><para><b>NOTE:</b> if the prefix is empty string "" and default namespace is bound to this prefix then empty string ("") is returned.</para><para><b>NOTE:</b> prefixes "xml" and "xmlns" are already bound will have values as defined  </para>        
				/// </summary>
				/// <java-name>
				/// getPrefix
				/// </java-name>
				[Dot42.DexImport("getPrefix", "(Ljava/lang/String;Z)Ljava/lang/String;", AccessFlags = 1025)]
				string GetPrefix(string @namespace, bool generatePrefix) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the current depth of the element. Outside the root element, the depth is 0. The depth is incremented by 1 when startTag() is called. The depth is decremented after the call to endTag() event was observed.</para><para><pre>
				///        &lt;! outside &gt;     0
				///        &lt;root&gt;               1
				///          sometext                 1
				///            &lt;foobar&gt;         2
				///            &lt;/foobar&gt;        2
				///        &lt;/root&gt;              1
				///        &lt;! outside &gt;     0
				///        </pre> </para>        
				/// </summary>
				/// <java-name>
				/// getDepth
				/// </java-name>
				[Dot42.DexImport("getDepth", "()I", AccessFlags = 1025)]
				int GetDepth() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the namespace URI of the current element as set by startTag().</para><para><b>NOTE:</b> that means in particular that: <ul><li><para>if there was startTag("", ...) then getNamespace() returns "" </para></li><li><para>if there was startTag(null, ...) then getNamespace() returns null </para></li></ul></para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>namespace set by startTag() that is currently in scope </para>
				/// </returns>
				/// <java-name>
				/// getNamespace
				/// </java-name>
				[Dot42.DexImport("getNamespace", "()Ljava/lang/String;", AccessFlags = 1025)]
				string GetNamespace() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the name of the current element as set by startTag(). It can only be null before first call to startTag() or when last endTag() is called to close first startTag().</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>namespace set by startTag() that is currently in scope </para>
				/// </returns>
				/// <java-name>
				/// getName
				/// </java-name>
				[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1025)]
				string GetName() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Writes a start tag with the given namespace and name. If there is no prefix defined for the given namespace, a prefix will be defined automatically. The explicit prefixes for namespaces can be established by calling setPrefix() immediately before this method. If namespace is null no namespace prefix is printed but just name. If namespace is empty string then serializer will make sure that default empty namespace is declared (in XML 1.0 xmlns='') or throw IllegalStateException if default namespace is already bound to non-empty string. </para>        
				/// </summary>
				/// <java-name>
				/// startTag
				/// </java-name>
				[Dot42.DexImport("startTag", "(Ljava/lang/String;Ljava/lang/String;)Lorg/xmlpull/v1/XmlSerializer;", AccessFlags = 1025)]
				global::Org.Xmlpull.V1.IXmlSerializer StartTag(string @namespace, string name) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Write an attribute. Calls to attribute() MUST follow a call to startTag() immediately. If there is no prefix defined for the given namespace, a prefix will be defined automatically. If namespace is null or empty string no namespace prefix is printed but just name. </para>        
				/// </summary>
				/// <java-name>
				/// attribute
				/// </java-name>
				[Dot42.DexImport("attribute", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lorg/xmlpull/v1/XmlSerial" +
    "izer;", AccessFlags = 1025)]
				global::Org.Xmlpull.V1.IXmlSerializer Attribute(string @namespace, string name, string value) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Write end tag. Repetition of namespace and name is just for avoiding errors. </para><para><b>Background:</b> in kXML endTag had no arguments, and non matching tags were very difficult to find... If namespace is null no namespace prefix is printed but just name. If namespace is empty string then serializer will make sure that default empty namespace is declared (in XML 1.0 xmlns=''). </para>        
				/// </summary>
				/// <java-name>
				/// endTag
				/// </java-name>
				[Dot42.DexImport("endTag", "(Ljava/lang/String;Ljava/lang/String;)Lorg/xmlpull/v1/XmlSerializer;", AccessFlags = 1025)]
				global::Org.Xmlpull.V1.IXmlSerializer EndTag(string @namespace, string name) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para><span>         Writes a start tag with the given namespace and name.         &lt;br /&gt;If there is no prefix defined (prefix == null) for the given namespace,         a prefix will be defined automatically.         &lt;br /&gt;If explicit prefixes is passed (prefix != null) then it will be used</span> *and namespace declared if not already declared or throw IllegalStateException the same prefix was already set on this element (setPrefix()) and was bound to different namespace. <br></br>If namespace is null then prefix must be null too or IllegalStateException is thrown. <br></br>If namespace is null then no namespace prefix is printed but just name. <br></br>If namespace is empty string then serializer will make sure that default empty namespace is declared (in XML 1.0 xmlns='') or throw IllegalStateException if default namespace is already bound to non-empty string. Write an attribute. Calls to attribute() MUST follow a call to startTag() immediately. <br></br>If there is no prefix defined (prefix == null) for the given namespace, a prefix will be defined automatically. <br></br>If explicit prefixes is passed (prefix != null) then it will be used and namespace declared if not already declared or throw IllegalStateException the same prefix was already set on this element (setPrefix()) and was bound to different namespace. <br></br>If namespace is null then prefix must be null too or IllegalStateException is thrown. <br></br>If namespace is null then no namespace prefix is printed but just name. <br></br>If namespace is empty string then serializer will make sure that default empty namespace is declared (in XML 1.0 xmlns='') or throw IllegalStateException if default namespace is already bound to non-empty string. Write end tag. Repetition of namespace, prefix, and name is just for avoiding errors. <br></br>If namespace or name arguments are different from corresponding startTag call then IllegalArgumentException is thrown, if prefix argument is not null and is different from corresponding starTag then IllegalArgumentException is thrown. <br></br>If namespace is null then prefix must be null too or IllegalStateException is thrown. <br></br>If namespace is null then no namespace prefix is printed but just name. <br></br>If namespace is empty string then serializer will make sure that default empty namespace is declared (in XML 1.0 xmlns=''). </para><para><b>Background:</b> in kXML endTag had no arguments, and non matching tags were very difficult to find...</para><para>Writes text, where special XML chars are escaped automatically </para>        
				/// </summary>
				/// <java-name>
				/// text
				/// </java-name>
				[Dot42.DexImport("text", "(Ljava/lang/String;)Lorg/xmlpull/v1/XmlSerializer;", AccessFlags = 1025)]
				global::Org.Xmlpull.V1.IXmlSerializer Text(string text) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Writes text, where special XML chars are escaped automatically </para>        
				/// </summary>
				/// <java-name>
				/// text
				/// </java-name>
				[Dot42.DexImport("text", "([CII)Lorg/xmlpull/v1/XmlSerializer;", AccessFlags = 1025)]
				global::Org.Xmlpull.V1.IXmlSerializer Text(char[] buf, int start, int len) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// cdsect
				/// </java-name>
				[Dot42.DexImport("cdsect", "(Ljava/lang/String;)V", AccessFlags = 1025)]
				void Cdsect(string text) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// entityRef
				/// </java-name>
				[Dot42.DexImport("entityRef", "(Ljava/lang/String;)V", AccessFlags = 1025)]
				void EntityRef(string text) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// processingInstruction
				/// </java-name>
				[Dot42.DexImport("processingInstruction", "(Ljava/lang/String;)V", AccessFlags = 1025)]
				void ProcessingInstruction(string text) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// comment
				/// </java-name>
				[Dot42.DexImport("comment", "(Ljava/lang/String;)V", AccessFlags = 1025)]
				void Comment(string text) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// docdecl
				/// </java-name>
				[Dot42.DexImport("docdecl", "(Ljava/lang/String;)V", AccessFlags = 1025)]
				void Docdecl(string text) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// ignorableWhitespace
				/// </java-name>
				[Dot42.DexImport("ignorableWhitespace", "(Ljava/lang/String;)V", AccessFlags = 1025)]
				void IgnorableWhitespace(string text) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Write all pending output to the stream. If method startTag() or attribute() was called then start tag is closed (final &gt;) before flush() is called on underlying output stream.</para><para><b>NOTE:</b> if there is need to close start tag (so no more attribute() calls are allowed) but without flushing output call method text() with empty string (text("")). </para>        
				/// </summary>
				/// <java-name>
				/// flush
				/// </java-name>
				[Dot42.DexImport("flush", "()V", AccessFlags = 1025)]
				void Flush() /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>This exception is thrown to signal XML Pull Parser related faults.</para><para><para> </para></para>    
		/// </summary>
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
				protected internal global::System.Exception Detail;
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
				public XmlPullParserException(string s) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Lorg/xmlpull/v1/XmlPullParser;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public XmlPullParserException(string msg, global::Org.Xmlpull.V1.IXmlPullParser parser, global::System.Exception chain) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getDetail
				/// </java-name>
				[Dot42.DexImport("getDetail", "()Ljava/lang/Throwable;", AccessFlags = 1)]
				public virtual global::System.Exception GetDetail() /* MethodBuilder.Create */ 
				{
						return default(global::System.Exception);
				}

				/// <java-name>
				/// getLineNumber
				/// </java-name>
				[Dot42.DexImport("getLineNumber", "()I", AccessFlags = 1)]
				public virtual int GetLineNumber() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getColumnNumber
				/// </java-name>
				[Dot42.DexImport("getColumnNumber", "()I", AccessFlags = 1)]
				public virtual int GetColumnNumber() /* MethodBuilder.Create */ 
				{
						return default(int);
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
				/// getLineNumber
				/// </java-name>
				public int LineNumber
				{
				[Dot42.DexImport("getLineNumber", "()I", AccessFlags = 1)]
						get{ return GetLineNumber(); }
				}

				/// <java-name>
				/// getColumnNumber
				/// </java-name>
				public int ColumnNumber
				{
				[Dot42.DexImport("getColumnNumber", "()I", AccessFlags = 1)]
						get{ return GetColumnNumber(); }
				}

		}

}


