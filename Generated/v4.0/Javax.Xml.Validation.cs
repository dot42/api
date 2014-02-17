// Copyright (C) 2014 dot42
//
// Original filename: Javax.Xml.Validation.cs
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
namespace Javax.Xml.Validation
{
		/// <summary>
		/// <para>This class was removed from JAXP 1.3 before it was finalized but was mistakenly included in Java 5. It only exists now for compatibility reasons. Applications should avoid using it.</para>    
		/// </summary>
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
				public abstract global::Javax.Xml.Validation.SchemaFactory NewFactory(string schemaLanguage) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>This class provides access to the type information determined by ValidatorHandler.</para><para>Some schema languages, such as W3C XML Schema, encourages a validator to report the "type" it assigns to each attribute/element. Those applications who wish to access this type information can invoke methods defined on this "interface" to access such type information.</para><para>Implementation of this "interface" can be obtained through the ValidatorHandler#getTypeInfoProvider() method.</para><para><para> </para><para></para><title>Revision:</title><para>884939 </para>, <title>Date:</title><para>2009-11-27 10:20:46 -0800 (Fri, 27 Nov 2009) </para><para>org.w3c.dom.TypeInfo </para><para>1.5 </para></para>    
		/// </summary>
		/// <java-name>
		/// javax/xml/validation/TypeInfoProvider
		/// </java-name>
		[Dot42.DexImport("javax/xml/validation/TypeInfoProvider", AccessFlags = 1057)]
		public abstract partial class TypeInfoProvider
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructor for the derived class.</para><para>The constructor does nothing. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal TypeInfoProvider() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the immutable TypeInfo object for the current element.</para><para>The method may only be called by the startElement and endElement event of the org.xml.sax.ContentHandler that the application sets to the ValidatorHandler.</para><para>Otherwise, this method returns null if the validator is unable to determine the type of the current element for some reason (for example, if the validator is recovering from an earlier error.) </para>        
				/// </summary>
				/// <returns>
				/// <para>An immutable TypeInfo object that represents the type of the current element. Note that the caller can keep references to the obtained TypeInfo longer than the callback scope.</para>
				/// </returns>
				/// <java-name>
				/// getElementTypeInfo
				/// </java-name>
				[Dot42.DexImport("getElementTypeInfo", "()Lorg/w3c/dom/TypeInfo;", AccessFlags = 1025)]
				public abstract global::Org.W3c.Dom.ITypeInfo GetElementTypeInfo() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the immutable TypeInfo object for the specified attribute of the current element.</para><para>The method may only be called by the startElement event of the org.xml.sax.ContentHandler that the application sets to the ValidatorHandler.</para><para>Otherwise, this method returns null if the validator is unable to determine the type. </para>        
				/// </summary>
				/// <returns>
				/// <para>An immutable TypeInfo object that represents the type of the specified attribute. Note that the caller can keep references to the obtained TypeInfo longer than the callback scope.</para>
				/// </returns>
				/// <java-name>
				/// getAttributeTypeInfo
				/// </java-name>
				[Dot42.DexImport("getAttributeTypeInfo", "(I)Lorg/w3c/dom/TypeInfo;", AccessFlags = 1025)]
				public abstract global::Org.W3c.Dom.ITypeInfo GetAttributeTypeInfo(int index) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns <code>true</code> if the specified attribute is determined to be ID.</para><para>Exactly how an attribute is "determined to be ID" is up to the schema language. In case of W3C XML Schema, this means that the actual type of the attribute is the built-in ID type or its derived type.</para><para>A javax.xml.parsers.DocumentBuilder uses this information to properly implement org.w3c.dom.Attr#isId().</para><para>The method may only be called by the startElement event of the org.xml.sax.ContentHandler that the application sets to the ValidatorHandler.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if the type of the specified attribute is ID. </para>
				/// </returns>
				/// <java-name>
				/// isIdAttribute
				/// </java-name>
				[Dot42.DexImport("isIdAttribute", "(I)Z", AccessFlags = 1025)]
				public abstract bool IsIdAttribute(int index) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns <code>false</code> if the attribute was added by the validator.</para><para>This method provides information necessary for a javax.xml.parsers.DocumentBuilder to determine what the DOM tree should return from the org.w3c.dom.Attr#getSpecified() method.</para><para>The method may only be called by the startElement event of the org.xml.sax.ContentHandler that the application sets to the ValidatorHandler.</para><para>A general guideline for validators is to return true if the attribute was originally present in the pipeline, and false if it was added by the validator.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> if the attribute was present before the validator processes input. <code>false</code> if the attribute was added by the validator. </para>
				/// </returns>
				/// <java-name>
				/// isSpecified
				/// </java-name>
				[Dot42.DexImport("isSpecified", "(I)Z", AccessFlags = 1025)]
				public abstract bool IsSpecified(int index) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the immutable TypeInfo object for the current element.</para><para>The method may only be called by the startElement and endElement event of the org.xml.sax.ContentHandler that the application sets to the ValidatorHandler.</para><para>Otherwise, this method returns null if the validator is unable to determine the type of the current element for some reason (for example, if the validator is recovering from an earlier error.) </para>        
				/// </summary>
				/// <returns>
				/// <para>An immutable TypeInfo object that represents the type of the current element. Note that the caller can keep references to the obtained TypeInfo longer than the callback scope.</para>
				/// </returns>
				/// <java-name>
				/// getElementTypeInfo
				/// </java-name>
				public global::Org.W3c.Dom.ITypeInfo ElementTypeInfo
				{
				[Dot42.DexImport("getElementTypeInfo", "()Lorg/w3c/dom/TypeInfo;", AccessFlags = 1025)]
						get{ return GetElementTypeInfo(); }
				}

		}

		/// <summary>
		/// <para>A processor that checks an XML document against Schema.</para><para>A validator is a thread-unsafe and non-reentrant object. In other words, it is the application's responsibility to make sure that one Validator object is not used from more than one thread at any given time, and while the <code>validate</code> method is invoked, applications may not recursively call the <code>validate</code> method. </para><para>Note that while the validate(javax.xml.transform.Source) and validate(javax.xml.transform.Source, javax.xml.transform.Result) methods take a Source instance, the <code>Source</code> instance must be a <code>SAXSource</code>, <code>DOMSource</code>, <code>StAXSource</code> or <code>StreamSource</code>.</para><para><para> </para><para></para><title>Revision:</title><para>888884 </para>, <title>Date:</title><para>2009-12-09 09:36:46 -0800 (Wed, 09 Dec 2009) </para><para>1.5 </para></para>    
		/// </summary>
		/// <java-name>
		/// javax/xml/validation/Validator
		/// </java-name>
		[Dot42.DexImport("javax/xml/validation/Validator", AccessFlags = 1057)]
		public abstract partial class Validator
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructor for derived classes.</para><para>The constructor does nothing.</para><para>Derived classes must create Validator objects that have <code>null</code> ErrorHandler and <code>null</code> LSResourceResolver. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal Validator() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Reset this <code>Validator</code> to its original configuration.</para><para><code>Validator</code> is reset to the same state as when it was created with Schema#newValidator(). <code>reset()</code> is designed to allow the reuse of existing <code>Validator</code>s thus saving resources associated with the creation of new <code>Validator</code>s.</para><para>The reset <code>Validator</code> is not guaranteed to have the same LSResourceResolver or ErrorHandler <code>Object</code>s, e.g. Object#equals(Object obj). It is guaranteed to have a functionally equal <code>LSResourceResolver</code> and <code>ErrorHandler</code>.</para>        
				/// </summary>
				/// <java-name>
				/// reset
				/// </java-name>
				[Dot42.DexImport("reset", "()V", AccessFlags = 1025)]
				public abstract void Reset() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Validates the specified input.</para><para>This is just a convenience method of: <pre>
				///        validate(source,null);
				///        </pre></para><para><para>setErrorHandler(ErrorHandler) </para></para>        
				/// </summary>
				/// <java-name>
				/// validate
				/// </java-name>
				[Dot42.DexImport("validate", "(Ljavax/xml/transform/Source;)V", AccessFlags = 1)]
				public virtual void Validate(global::Javax.Xml.Transform.ISource source) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Validates the specified input and send the augmented validation result to the specified output.</para><para>This method places the following restrictions on the types of the Source/Result accepted.</para><para><h4>Source}/ Result} accepted:</h4></para><para><table></table></para><para>javax.xml.transform.sax.SAXSource </para><para>javax.xml.transform.dom.DOMSource </para><para>javax.xml.transform.stream.StreamSource  &lt;/thead&gt; &lt;tbody&gt; </para><para><code>null</code> </para><para>OK </para><para>OK </para><para>OK </para><para>OK  </para><para>javax.xml.transform.sax.SAXResult </para><para>OK </para><para>Err </para><para>Err </para><para>Err  </para><para>javax.xml.transform.dom.DOMResult </para><para>Err </para><para>OK </para><para>Err </para><para>Err  </para><para>javax.xml.transform.stream.StreamResult </para><para>Err </para><para>Err </para><para>Err </para><para>OK  &lt;/tbody&gt; </para><para>To validate one Source into another kind of Result, use the identity transformer (see javax.xml.transform.TransformerFactory#newTransformer()).</para><para>Errors found during the validation is sent to the specified ErrorHandler.</para><para>If a document is valid, or if a document contains some errors but none of them were fatal and the ErrorHandler didn't throw any exception, then the method returns normally.</para><para>Note that when a javax.xml.transform.dom.DOMResult is used, a validator might just pass the same DOM node from javax.xml.transform.dom.DOMSource to javax.xml.transform.dom.DOMResult (in which case <code>source.getNode()==result.getNode()</code>), it might copy the entire DOM tree, or it might alter the node given by the source.</para><para><para>validate(Source) </para></para>        
				/// </summary>
				/// <java-name>
				/// validate
				/// </java-name>
				[Dot42.DexImport("validate", "(Ljavax/xml/transform/Source;Ljavax/xml/transform/Result;)V", AccessFlags = 1025)]
				public abstract void Validate(global::Javax.Xml.Transform.ISource source, global::Javax.Xml.Transform.IResult result) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets the ErrorHandler to receive errors encountered during the <code>validate</code> method invocation.</para><para>Error handler can be used to customize the error handling process during a validation. When an ErrorHandler is set, errors found during the validation will be first sent to the ErrorHandler.</para><para>The error handler can abort further validation immediately by throwing SAXException from the handler. Or for example it can print an error to the screen and try to continue the validation by returning normally from the ErrorHandler</para><para>If any Throwable is thrown from an ErrorHandler, the caller of the <code>validate</code> method will be thrown the same Throwable object.</para><para>Validator is not allowed to throw SAXException without first reporting it to ErrorHandler.</para><para>When the ErrorHandler is null, the implementation will behave as if the following ErrorHandler is set: <pre>
				///        class DraconianErrorHandler implements ErrorHandler {
				///            public void fatalError( org.xml.sax.SAXParseException e ) throws SAXException {
				///                throw e;
				///            }
				///            public void error( org.xml.sax.SAXParseException e ) throws SAXException {
				///                throw e;
				///            }
				///            public void warning( org.xml.sax.SAXParseException e ) throws SAXException {
				///                // noop
				///            }
				///        }
				///        </pre></para><para>When a new Validator object is created, initially this field is set to null.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setErrorHandler
				/// </java-name>
				[Dot42.DexImport("setErrorHandler", "(Lorg/xml/sax/ErrorHandler;)V", AccessFlags = 1025)]
				public abstract void SetErrorHandler(global::Org.Xml.Sax.IErrorHandler errorHandler) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Gets the current ErrorHandler set to this Validator.</para><para><para>setErrorHandler(ErrorHandler) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>This method returns the object that was last set through the setErrorHandler(ErrorHandler) method, or null if that method has never been called since this Validator has created.</para>
				/// </returns>
				/// <java-name>
				/// getErrorHandler
				/// </java-name>
				[Dot42.DexImport("getErrorHandler", "()Lorg/xml/sax/ErrorHandler;", AccessFlags = 1025)]
				public abstract global::Org.Xml.Sax.IErrorHandler GetErrorHandler() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets the LSResourceResolver to customize resource resolution while in a validation episode.</para><para>Validator uses a LSResourceResolver when it needs to locate external resources while a validation, although exactly what constitutes "locating external resources" is up to each schema language.</para><para>When the LSResourceResolver is null, the implementation will behave as if the following LSResourceResolver is set: <pre>
				///        class DumbLSResourceResolver implements LSResourceResolver {
				///            public org.w3c.dom.ls.LSInput resolveResource(
				///                String publicId, String systemId, String baseURI) {
				/// 
				///                return null; // always return null
				///            }
				///        }
				///        </pre></para><para>If a LSResourceResolver throws a RuntimeException (or instances of its derived classes), then the Validator will abort the parsing and the caller of the <code>validate</code> method will receive the same RuntimeException.</para><para>When a new Validator object is created, initially this field is set to null.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setResourceResolver
				/// </java-name>
				[Dot42.DexImport("setResourceResolver", "(Lorg/w3c/dom/ls/LSResourceResolver;)V", AccessFlags = 1025)]
				public abstract void SetResourceResolver(global::Org.W3c.Dom.Ls.ILSResourceResolver resourceResolver) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Gets the current LSResourceResolver set to this Validator.</para><para><para>setErrorHandler(ErrorHandler) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>This method returns the object that was last set through the setResourceResolver(LSResourceResolver) method, or null if that method has never been called since this Validator has created.</para>
				/// </returns>
				/// <java-name>
				/// getResourceResolver
				/// </java-name>
				[Dot42.DexImport("getResourceResolver", "()Lorg/w3c/dom/ls/LSResourceResolver;", AccessFlags = 1025)]
				public abstract global::Org.W3c.Dom.Ls.ILSResourceResolver GetResourceResolver() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Look up the value of a feature flag.</para><para>The feature name is any fully-qualified URI. It is possible for a Validator to recognize a feature name but temporarily be unable to return its value. Some feature values may be available only in specific contexts, such as before, during, or after a validation.</para><para>Implementors are free (and encouraged) to invent their own features, using names built on their own URIs.</para><para><para>setFeature(String, boolean) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The current value of the feature (true or false). </para>
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
				/// <para>Set the value of a feature flag.</para><para>Feature can be used to control the way a Validator parses schemas, although Validators are not required to recognize any specific property names.</para><para>The feature name is any fully-qualified URI. It is possible for a Validator to expose a feature value but to be unable to change the current value. Some feature values may be immutable or mutable only in specific contexts, such as before, during, or after a validation.</para><para><para>getFeature(String) </para></para>        
				/// </summary>
				/// <java-name>
				/// setFeature
				/// </java-name>
				[Dot42.DexImport("setFeature", "(Ljava/lang/String;Z)V", AccessFlags = 1)]
				public virtual void SetFeature(string name, bool value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Set the value of a property.</para><para>The property name is any fully-qualified URI. It is possible for a Validator to recognize a property name but to be unable to change the current value. Some property values may be immutable or mutable only in specific contexts, such as before, during, or after a validation.</para><para>Validators are not required to recognize setting any specific property names.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setProperty
				/// </java-name>
				[Dot42.DexImport("setProperty", "(Ljava/lang/String;Ljava/lang/Object;)V", AccessFlags = 1)]
				public virtual void SetProperty(string name, object @object) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Look up the value of a property.</para><para>The property name is any fully-qualified URI. It is possible for a Validator to recognize a property name but temporarily be unable to return its value. Some property values may be available only in specific contexts, such as before, during, or after a validation.</para><para>Validators are not required to recognize any specific property names.</para><para>Implementors are free (and encouraged) to invent their own properties, using names built on their own URIs.</para><para><para>setProperty(String, Object) </para></para>        
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
				/// <para>Gets the current ErrorHandler set to this Validator.</para><para><para>setErrorHandler(ErrorHandler) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>This method returns the object that was last set through the setErrorHandler(ErrorHandler) method, or null if that method has never been called since this Validator has created.</para>
				/// </returns>
				/// <java-name>
				/// getErrorHandler
				/// </java-name>
				public global::Org.Xml.Sax.IErrorHandler ErrorHandler
				{
				[Dot42.DexImport("getErrorHandler", "()Lorg/xml/sax/ErrorHandler;", AccessFlags = 1025)]
						get{ return GetErrorHandler(); }
				[Dot42.DexImport("setErrorHandler", "(Lorg/xml/sax/ErrorHandler;)V", AccessFlags = 1025)]
						set{ SetErrorHandler(value); }
				}

				/// <summary>
				/// <para>Gets the current LSResourceResolver set to this Validator.</para><para><para>setErrorHandler(ErrorHandler) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>This method returns the object that was last set through the setResourceResolver(LSResourceResolver) method, or null if that method has never been called since this Validator has created.</para>
				/// </returns>
				/// <java-name>
				/// getResourceResolver
				/// </java-name>
				public global::Org.W3c.Dom.Ls.ILSResourceResolver ResourceResolver
				{
				[Dot42.DexImport("getResourceResolver", "()Lorg/w3c/dom/ls/LSResourceResolver;", AccessFlags = 1025)]
						get{ return GetResourceResolver(); }
				[Dot42.DexImport("setResourceResolver", "(Lorg/w3c/dom/ls/LSResourceResolver;)V", AccessFlags = 1025)]
						set{ SetResourceResolver(value); }
				}

		}

		/// <summary>
		/// <para>Immutable in-memory representation of grammar.</para><para>This object represents a set of constraints that can be checked/ enforced against an XML document.</para><para>A Schema object is thread safe and applications are encouraged to share it across many parsers in many threads.</para><para>A Schema object is immutable in the sense that it shouldn't change the set of constraints once it is created. In other words, if an application validates the same document twice against the same Schema, it must always produce the same result.</para><para>A Schema object is usually created from SchemaFactory.</para><para>Two kinds of validators can be created from a Schema object. One is Validator, which provides highly-level validation operations that cover typical use cases. The other is ValidatorHandler, which works on top of SAX for better modularity.</para><para>This specification does not refine the java.lang.Object#equals(java.lang.Object) method. In other words, if you parse the same schema twice, you may still get <code>!schemaA.equals(schemaB)</code>.</para><para><para> </para><para></para><title>Revision:</title><para>446598 </para>, <title>Date:</title><para>2006-09-15 05:55:40 -0700 (Fri, 15 Sep 2006) </para><para> </para><simplesectsep></simplesectsep><para> </para><simplesectsep></simplesectsep><para> </para><para>1.5 </para></para>    
		/// </summary>
		/// <java-name>
		/// javax/xml/validation/Schema
		/// </java-name>
		[Dot42.DexImport("javax/xml/validation/Schema", AccessFlags = 1057)]
		public abstract partial class Schema
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructor for the derived class.</para><para>The constructor does nothing. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal Schema() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new Validator for this Schema.</para><para>A validator enforces/checks the set of constraints this object represents.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Always return a non-null valid object. </para>
				/// </returns>
				/// <java-name>
				/// newValidator
				/// </java-name>
				[Dot42.DexImport("newValidator", "()Ljavax/xml/validation/Validator;", AccessFlags = 1025)]
				public abstract global::Javax.Xml.Validation.Validator NewValidator() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Creates a new ValidatorHandler for this Schema.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Always return a non-null valid object. </para>
				/// </returns>
				/// <java-name>
				/// newValidatorHandler
				/// </java-name>
				[Dot42.DexImport("newValidatorHandler", "()Ljavax/xml/validation/ValidatorHandler;", AccessFlags = 1025)]
				public abstract global::Javax.Xml.Validation.ValidatorHandler NewValidatorHandler() /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>Streaming validator that works on SAX stream.</para><para>A ValidatorHandler object is a thread-unsafe, non-reentrant object. In other words, it is the application's responsibility to make sure that one ValidatorHandler object is not used from more than one thread at any given time.</para><para>ValidatorHandler checks if the SAX events follow the set of constraints described in the associated Schema, and additionally it may modify the SAX events (for example by adding default values, etc.)</para><para>ValidatorHandler extends from ContentHandler, but it refines the underlying ContentHandler in the following way: <ol><li><para>startElement/endElement events must receive non-null String for <code>uri</code>, <code>localName</code>, and <code>qname</code>, even though SAX allows some of them to be null. Similarly, the user-specified ContentHandler will receive non-null Strings for all three parameters.</para><para></para></li><li><para>Applications must ensure that ValidatorHandler's ContentHandler#startPrefixMapping(String,String) and ContentHandler#endPrefixMapping(String) are invoked properly. Similarly, the user-specified ContentHandler will receive startPrefixMapping/endPrefixMapping events. If the ValidatorHandler introduces additional namespace bindings, the user-specified ContentHandler will receive additional startPrefixMapping/endPrefixMapping events.</para><para></para></li><li><para>org.xml.sax.Attributes for the ContentHandler#startElement(String,String,String,Attributes) method may or may not include xmlns* attributes. </para></li></ol></para><para>A ValidatorHandler is automatically reset every time the startDocument method is invoked.</para><para><h2>Recognized Properties and Features</h2></para><para>This spec defines the following feature that must be recognized by all ValidatorHandler implementations.</para><para><h3><code></code></h3></para><para>This feature controls how a ValidatorHandler introduces namespace bindings that were not present in the original SAX event stream. When this feature is set to true, it must make sure that the user's ContentHandler will see the corresponding <code>xmlns*</code> attribute in the org.xml.sax.Attributes object of the ContentHandler#startElement(String,String,String,Attributes) callback. Otherwise, <code>xmlns*</code> attributes must not be added to org.xml.sax.Attributes that's passed to the user-specified ContentHandler. </para><para>(Note that regardless of this switch, namespace bindings are always notified to applications through ContentHandler#startPrefixMapping(String,String) and ContentHandler#endPrefixMapping(String) methods of the ContentHandler specified by the user.)</para><para>Note that this feature does <b>NOT</b> affect the way a ValidatorHandler receives SAX events. It merely changes the way it augments SAX events.</para><para>This feature is set to <code>false</code> by default.</para><para><para> </para><para></para><title>Revision:</title><para>446598 </para>, <title>Date:</title><para>2006-09-15 05:55:40 -0700 (Fri, 15 Sep 2006) </para><para>1.5 </para></para>    
		/// </summary>
		/// <java-name>
		/// javax/xml/validation/ValidatorHandler
		/// </java-name>
		[Dot42.DexImport("javax/xml/validation/ValidatorHandler", AccessFlags = 1057)]
		public abstract partial class ValidatorHandler : global::Org.Xml.Sax.IContentHandler
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructor for derived classes.</para><para>The constructor does nothing.</para><para>Derived classes must create ValidatorHandler objects that have <code>null</code> ErrorHandler and <code>null</code> LSResourceResolver. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal ValidatorHandler() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the ContentHandler which receives the augmented validation result.</para><para>When a ContentHandler is specified, a ValidatorHandler will work as a filter and basically copy the incoming events to the specified ContentHandler.</para><para>In doing so, a ValidatorHandler may modify the events, for example by adding defaulted attributes.</para><para>A ValidatorHandler may buffer events to certain extent, but to allow ValidatorHandler to be used by a parser, the following requirement has to be met.</para><para><ol><li><para>When ContentHandler#startElement(String, String, String, Attributes), ContentHandler#endElement(String, String, String), ContentHandler#startDocument(), or ContentHandler#endDocument() are invoked on a ValidatorHandler, the same method on the user-specified ContentHandler must be invoked for the same event before the callback returns. </para></li><li><para>ValidatorHandler may not introduce new elements that were not present in the input.</para><para></para></li><li><para>ValidatorHandler may not remove attributes that were present in the input. </para></li></ol></para><para>When a callback method on the specified ContentHandler throws an exception, the same exception object must be thrown from the ValidatorHandler. The ErrorHandler should not be notified of such an exception.</para><para>This method can be called even during a middle of a validation.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setContentHandler
				/// </java-name>
				[Dot42.DexImport("setContentHandler", "(Lorg/xml/sax/ContentHandler;)V", AccessFlags = 1025)]
				public abstract void SetContentHandler(global::Org.Xml.Sax.IContentHandler receiver) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Gets the ContentHandler which receives the augmented validation result.</para><para><para>setContentHandler(ContentHandler) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>This method returns the object that was last set through the getContentHandler() method, or null if that method has never been called since this ValidatorHandler has created.</para>
				/// </returns>
				/// <java-name>
				/// getContentHandler
				/// </java-name>
				[Dot42.DexImport("getContentHandler", "()Lorg/xml/sax/ContentHandler;", AccessFlags = 1025)]
				public abstract global::Org.Xml.Sax.IContentHandler GetContentHandler() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets the ErrorHandler to receive errors encountered during the validation.</para><para>Error handler can be used to customize the error handling process during a validation. When an ErrorHandler is set, errors found during the validation will be first sent to the ErrorHandler.</para><para>The error handler can abort further validation immediately by throwing org.xml.sax.SAXException from the handler. Or for example it can print an error to the screen and try to continue the validation by returning normally from the ErrorHandler</para><para>If any Throwable is thrown from an ErrorHandler, the same Throwable object will be thrown toward the root of the call stack.</para><para>ValidatorHandler is not allowed to throw org.xml.sax.SAXException without first reporting it to ErrorHandler.</para><para>When the ErrorHandler is null, the implementation will behave as if the following ErrorHandler is set: <pre>
				///        class DraconianErrorHandler implements ErrorHandler {
				///            public void fatalError( org.xml.sax.SAXParseException e ) throws org.xml.sax.SAXException {
				///                throw e;
				///            }
				///            public void error( org.xml.sax.SAXParseException e ) throws org.xml.sax.SAXException {
				///                throw e;
				///            }
				///            public void warning( org.xml.sax.SAXParseException e ) throws org.xml.sax.SAXException {
				///                // noop
				///            }
				///        }
				///        </pre></para><para>When a new ValidatorHandler object is created, initially this field is set to null.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setErrorHandler
				/// </java-name>
				[Dot42.DexImport("setErrorHandler", "(Lorg/xml/sax/ErrorHandler;)V", AccessFlags = 1025)]
				public abstract void SetErrorHandler(global::Org.Xml.Sax.IErrorHandler errorHandler) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Gets the current ErrorHandler set to this ValidatorHandler.</para><para><para>setErrorHandler(ErrorHandler) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>This method returns the object that was last set through the setErrorHandler(ErrorHandler) method, or null if that method has never been called since this ValidatorHandler has created.</para>
				/// </returns>
				/// <java-name>
				/// getErrorHandler
				/// </java-name>
				[Dot42.DexImport("getErrorHandler", "()Lorg/xml/sax/ErrorHandler;", AccessFlags = 1025)]
				public abstract global::Org.Xml.Sax.IErrorHandler GetErrorHandler() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets the LSResourceResolver to customize resource resolution while in a validation episode.</para><para>ValidatorHandler uses a LSResourceResolver when it needs to locate external resources while a validation, although exactly what constitutes "locating external resources" is up to each schema language.</para><para>When the LSResourceResolver is null, the implementation will behave as if the following LSResourceResolver is set: <pre>
				///        class DumbLSResourceResolver implements LSResourceResolver {
				///            public org.w3c.dom.ls.LSInput resolveResource(
				///                String publicId, String systemId, String baseURI) {
				/// 
				///                return null; // always return null
				///            }
				///        }
				///        </pre></para><para>If a LSResourceResolver throws a RuntimeException (or instances of its derived classes), then the ValidatorHandler will abort the parsing and the caller of the <code>validate</code> method will receive the same RuntimeException.</para><para>When a new ValidatorHandler object is created, initially this field is set to null.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setResourceResolver
				/// </java-name>
				[Dot42.DexImport("setResourceResolver", "(Lorg/w3c/dom/ls/LSResourceResolver;)V", AccessFlags = 1025)]
				public abstract void SetResourceResolver(global::Org.W3c.Dom.Ls.ILSResourceResolver resourceResolver) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Gets the current LSResourceResolver set to this ValidatorHandler.</para><para><para>setErrorHandler(ErrorHandler) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>This method returns the object that was last set through the setResourceResolver(LSResourceResolver) method, or null if that method has never been called since this ValidatorHandler has created.</para>
				/// </returns>
				/// <java-name>
				/// getResourceResolver
				/// </java-name>
				[Dot42.DexImport("getResourceResolver", "()Lorg/w3c/dom/ls/LSResourceResolver;", AccessFlags = 1025)]
				public abstract global::Org.W3c.Dom.Ls.ILSResourceResolver GetResourceResolver() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Obtains the TypeInfoProvider implementation of this ValidatorHandler.</para><para>The obtained TypeInfoProvider can be queried during a parse to access the type information determined by the validator.</para><para>Some schema languages do not define the notion of type, for those languages, this method may not be supported. However, to be compliant with this specification, implementations for W3C XML Schema 1.0 must support this operation.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>null if the validator / schema language does not support the notion of org.w3c.dom.TypeInfo. Otherwise a non-null valid TypeInfoProvider. </para>
				/// </returns>
				/// <java-name>
				/// getTypeInfoProvider
				/// </java-name>
				[Dot42.DexImport("getTypeInfoProvider", "()Ljavax/xml/validation/TypeInfoProvider;", AccessFlags = 1025)]
				public abstract global::Javax.Xml.Validation.TypeInfoProvider GetTypeInfoProvider() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Look up the value of a feature flag.</para><para>The feature name is any fully-qualified URI. It is possible for a ValidatorHandler to recognize a feature name but temporarily be unable to return its value. Some feature values may be available only in specific contexts, such as before, during, or after a validation.</para><para>Implementors are free (and encouraged) to invent their own features, using names built on their own URIs.</para><para><para>setFeature(String, boolean) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The current value of the feature (true or false). </para>
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
				/// <para>Set the value of a feature flag.</para><para>Feature can be used to control the way a ValidatorHandler parses schemas, although ValidatorHandlers are not required to recognize any specific property names.</para><para>The feature name is any fully-qualified URI. It is possible for a ValidatorHandler to expose a feature value but to be unable to change the current value. Some feature values may be immutable or mutable only in specific contexts, such as before, during, or after a validation.</para><para><para>getFeature(String) </para></para>        
				/// </summary>
				/// <java-name>
				/// setFeature
				/// </java-name>
				[Dot42.DexImport("setFeature", "(Ljava/lang/String;Z)V", AccessFlags = 1)]
				public virtual void SetFeature(string name, bool value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Set the value of a property.</para><para>The property name is any fully-qualified URI. It is possible for a ValidatorHandler to recognize a property name but to be unable to change the current value. Some property values may be immutable or mutable only in specific contexts, such as before, during, or after a validation.</para><para>ValidatorHandlers are not required to recognize setting any specific property names.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setProperty
				/// </java-name>
				[Dot42.DexImport("setProperty", "(Ljava/lang/String;Ljava/lang/Object;)V", AccessFlags = 1)]
				public virtual void SetProperty(string name, object @object) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Look up the value of a property.</para><para>The property name is any fully-qualified URI. It is possible for a ValidatorHandler to recognize a property name but temporarily be unable to return its value. Some property values may be available only in specific contexts, such as before, during, or after a validation.</para><para>ValidatorHandlers are not required to recognize any specific property names.</para><para>Implementors are free (and encouraged) to invent their own properties, using names built on their own URIs.</para><para><para>setProperty(String, Object) </para></para>        
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
				public virtual void StartPrefixMapping(string prefix, string uri) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("org/xml/sax/ContentHandler", "endPrefixMapping", "(Ljava/lang/String;)V", AccessFlags = 1025)]
				public virtual void EndPrefixMapping(string prefix) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("org/xml/sax/ContentHandler", "startElement", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lorg/xml/sax/Attributes;)V" +
    "", AccessFlags = 1025)]
				public virtual void StartElement(string uri, string localName, string qName, global::Org.Xml.Sax.IAttributes atts) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("org/xml/sax/ContentHandler", "endElement", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1025)]
				public virtual void EndElement(string uri, string localName, string qName) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("org/xml/sax/ContentHandler", "characters", "([CII)V", AccessFlags = 1025)]
				public virtual void Characters(char[] ch, int start, int length) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("org/xml/sax/ContentHandler", "ignorableWhitespace", "([CII)V", AccessFlags = 1025)]
				public virtual void IgnorableWhitespace(char[] ch, int start, int length) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("org/xml/sax/ContentHandler", "processingInstruction", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1025)]
				public virtual void ProcessingInstruction(string target, string data) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("org/xml/sax/ContentHandler", "skippedEntity", "(Ljava/lang/String;)V", AccessFlags = 1025)]
				public virtual void SkippedEntity(string name) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				/// <summary>
				/// <para>Gets the ContentHandler which receives the augmented validation result.</para><para><para>setContentHandler(ContentHandler) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>This method returns the object that was last set through the getContentHandler() method, or null if that method has never been called since this ValidatorHandler has created.</para>
				/// </returns>
				/// <java-name>
				/// getContentHandler
				/// </java-name>
				public global::Org.Xml.Sax.IContentHandler ContentHandler
				{
				[Dot42.DexImport("getContentHandler", "()Lorg/xml/sax/ContentHandler;", AccessFlags = 1025)]
						get{ return GetContentHandler(); }
				[Dot42.DexImport("setContentHandler", "(Lorg/xml/sax/ContentHandler;)V", AccessFlags = 1025)]
						set{ SetContentHandler(value); }
				}

				/// <summary>
				/// <para>Gets the current ErrorHandler set to this ValidatorHandler.</para><para><para>setErrorHandler(ErrorHandler) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>This method returns the object that was last set through the setErrorHandler(ErrorHandler) method, or null if that method has never been called since this ValidatorHandler has created.</para>
				/// </returns>
				/// <java-name>
				/// getErrorHandler
				/// </java-name>
				public global::Org.Xml.Sax.IErrorHandler ErrorHandler
				{
				[Dot42.DexImport("getErrorHandler", "()Lorg/xml/sax/ErrorHandler;", AccessFlags = 1025)]
						get{ return GetErrorHandler(); }
				[Dot42.DexImport("setErrorHandler", "(Lorg/xml/sax/ErrorHandler;)V", AccessFlags = 1025)]
						set{ SetErrorHandler(value); }
				}

				/// <summary>
				/// <para>Gets the current LSResourceResolver set to this ValidatorHandler.</para><para><para>setErrorHandler(ErrorHandler) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>This method returns the object that was last set through the setResourceResolver(LSResourceResolver) method, or null if that method has never been called since this ValidatorHandler has created.</para>
				/// </returns>
				/// <java-name>
				/// getResourceResolver
				/// </java-name>
				public global::Org.W3c.Dom.Ls.ILSResourceResolver ResourceResolver
				{
				[Dot42.DexImport("getResourceResolver", "()Lorg/w3c/dom/ls/LSResourceResolver;", AccessFlags = 1025)]
						get{ return GetResourceResolver(); }
				[Dot42.DexImport("setResourceResolver", "(Lorg/w3c/dom/ls/LSResourceResolver;)V", AccessFlags = 1025)]
						set{ SetResourceResolver(value); }
				}

				/// <summary>
				/// <para>Obtains the TypeInfoProvider implementation of this ValidatorHandler.</para><para>The obtained TypeInfoProvider can be queried during a parse to access the type information determined by the validator.</para><para>Some schema languages do not define the notion of type, for those languages, this method may not be supported. However, to be compliant with this specification, implementations for W3C XML Schema 1.0 must support this operation.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>null if the validator / schema language does not support the notion of org.w3c.dom.TypeInfo. Otherwise a non-null valid TypeInfoProvider. </para>
				/// </returns>
				/// <java-name>
				/// getTypeInfoProvider
				/// </java-name>
				public global::Javax.Xml.Validation.TypeInfoProvider TypeInfoProvider
				{
				[Dot42.DexImport("getTypeInfoProvider", "()Ljavax/xml/validation/TypeInfoProvider;", AccessFlags = 1025)]
						get{ return GetTypeInfoProvider(); }
				}

		}

		/// <summary>
		/// <para>Factory that creates Schema objects&amp;#x2E; Entry-point to the validation API.</para><para>SchemaFactory is a schema compiler. It reads external representations of schemas and prepares them for validation.</para><para>The SchemaFactory class is not thread-safe. In other words, it is the application's responsibility to ensure that at most one thread is using a SchemaFactory object at any given moment. Implementations are encouraged to mark methods as <code>synchronized</code> to protect themselves from broken clients.</para><para>SchemaFactory is not re-entrant. While one of the <code>newSchema</code> methods is being invoked, applications may not attempt to recursively invoke the <code>newSchema</code> method, even from the same thread.</para><para><h2>Schema Language</h2></para><para>This spec uses a namespace URI to designate a schema language. The following table shows the values defined by this specification. </para><para>To be compliant with the spec, the implementation is only required to support W3C XML Schema 1.0. However, if it chooses to support other schema languages listed here, it must conform to the relevant behaviors described in this spec.</para><para>Schema languages not listed here are expected to introduce their own URIs to represent themselves. The SchemaFactory class is capable of locating other implementations for other schema languages at run-time.</para><para>Note that because the XML DTD is strongly tied to the parsing process and has a significant effect on the parsing process, it is impossible to define the DTD validation as a process independent from parsing. For this reason, this specification does not define the semantics for the XML DTD. This doesn't prohibit implementers from implementing it in a way they see fit, but <b>users are warned that any DTD validation implemented on this interface necessarily deviate from the XML DTD semantics as defined in the XML 1.0</b>.</para><para><table></table></para><para>value </para><para>language  &lt;/thead&gt; &lt;tbody&gt; </para><para>javax.xml.XMLConstants#W3C_XML_SCHEMA_NS_URI ("&lt;code&gt;http://www.w3.org/2001/XMLSchema&lt;/code&gt;") </para><para>  </para><para>javax.xml.XMLConstants#RELAXNG_NS_URI ("&lt;code&gt;http://relaxng.org/ns/structure/1.0&lt;/code&gt;") </para><para>  &lt;/tbody&gt; </para><para><para> </para><para></para><title>Revision:</title><para>884952 </para>, <title>Date:</title><para>2009-11-27 10:55:08 -0800 (Fri, 27 Nov 2009) </para><para>1.5 </para></para>    
		/// </summary>
		/// <java-name>
		/// javax/xml/validation/SchemaFactory
		/// </java-name>
		[Dot42.DexImport("javax/xml/validation/SchemaFactory", AccessFlags = 1057)]
		public abstract partial class SchemaFactory
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructor for derived classes.</para><para>The constructor does nothing.</para><para>Derived classes must create SchemaFactory objects that have <code>null</code> ErrorHandler and <code>null</code> LSResourceResolver.</para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal SchemaFactory() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Lookup an implementation of the <code>SchemaFactory</code> that supports the specified schema language and return it.</para><para>To find a <code>SchemaFactory</code> object for a given schema language, this method looks the following places in the following order where "the class loader" refers to the context class loader:</para><para><ol><li><para>If the system property <code>"javax.xml.validation.SchemaFactory:&lt;i&gt;schemaLanguage&lt;/i&gt;"</code> is present (where <b>schemaLanguage</b> is the parameter to this method), then its value is read as a class name. The method will try to create a new instance of this class by using the class loader, and returns it if it is successfully created.  </para></li><li><para><code>$java.home/lib/jaxp.properties</code> is read and the value associated with the key being the system property above is looked for. If present, the value is processed just like above.  </para></li><li><para></para><para>The class loader is asked for service provider provider-configuration files matching <code>javax.xml.validation.SchemaFactory</code> in the resource directory META-INF/services. See the JAR File Specification for file format and parsing rules. Each potential service provider is required to implement the method:</para><para><pre>
				///               isSchemaLanguageSupported(String schemaLanguage)
				///            </pre> The first service provider found in class loader order that supports the specified schema language is returned.  </para></li><li><para>Platform default <code>SchemaFactory</code> is located in a implementation specific way. There must be a platform default <code>SchemaFactory</code> for W3C XML Schema.  </para></li></ol></para><para>If everything fails, IllegalArgumentException will be thrown.</para><para><b>Tip for Trouble-shooting:</b></para><para>See java.util.Properties#load(java.io.InputStream) for exactly how a property file is parsed. In particular, colons ':' need to be escaped in a property file, so make sure schema language URIs are properly escaped in it. For example:</para><para><pre>
				///        http\://www.w3.org/2001/XMLSchema=org.acme.foo.XSSchemaFactory
				///        </pre></para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>New instance of a <code>SchemaFactory</code></para>
				/// </returns>
				/// <java-name>
				/// newInstance
				/// </java-name>
				[Dot42.DexImport("newInstance", "(Ljava/lang/String;)Ljavax/xml/validation/SchemaFactory;", AccessFlags = 9)]
				public static global::Javax.Xml.Validation.SchemaFactory NewInstance(string schemaLanguage) /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Xml.Validation.SchemaFactory);
				}

				/// <summary>
				/// <para>Returns an instance of the named implementation of <c> SchemaFactory </c> .</para><para><para>1.6 </para></para>        
				/// </summary>
				/// <java-name>
				/// newInstance
				/// </java-name>
				[Dot42.DexImport("newInstance", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/ClassLoader;)Ljavax/xml/validatio" +
    "n/SchemaFactory;", AccessFlags = 9)]
				public static global::Javax.Xml.Validation.SchemaFactory NewInstance(string schemaLanguage, string factoryClassName, global::Java.Lang.ClassLoader classLoader) /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Xml.Validation.SchemaFactory);
				}

				/// <summary>
				/// <para>Is specified schema supported by this <code>SchemaFactory</code>?</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> if <code>SchemaFactory</code> supports <code>schemaLanguage</code>, else <code>false</code>.</para>
				/// </returns>
				/// <java-name>
				/// isSchemaLanguageSupported
				/// </java-name>
				[Dot42.DexImport("isSchemaLanguageSupported", "(Ljava/lang/String;)Z", AccessFlags = 1025)]
				public abstract bool IsSchemaLanguageSupported(string schemaLanguage) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Look up the value of a feature flag.</para><para>The feature name is any fully-qualified URI. It is possible for a SchemaFactory to recognize a feature name but temporarily be unable to return its value.</para><para>Implementers are free (and encouraged) to invent their own features, using names built on their own URIs.</para><para><para>setFeature(String, boolean) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The current value of the feature (true or false). </para>
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
				/// <para>Set the value of a feature flag.</para><para>Feature can be used to control the way a SchemaFactory parses schemas, although SchemaFactorys are not required to recognize any specific feature names.</para><para>The feature name is any fully-qualified URI. It is possible for a SchemaFactory to expose a feature value but to be unable to change the current value.</para><para>All implementations are required to support the javax.xml.XMLConstants#FEATURE_SECURE_PROCESSING feature. When the feature is:</para><para><ul><li><para><code>true</code>: the implementation will limit XML processing to conform to implementation limits. Examples include entity expansion limits and XML Schema constructs that would consume large amounts of resources. If XML processing is limited for security reasons, it will be reported via a call to the registered ErrorHandler#fatalError(org.xml.sax.SAXParseException). See setErrorHandler(ErrorHandler errorHandler).  </para></li><li><para><code>false</code>: the implementation will processing XML according to the XML specifications without regard to possible implementation limits.  </para></li></ul></para><para><para>getFeature(String) </para></para>        
				/// </summary>
				/// <java-name>
				/// setFeature
				/// </java-name>
				[Dot42.DexImport("setFeature", "(Ljava/lang/String;Z)V", AccessFlags = 1)]
				public virtual void SetFeature(string name, bool value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Set the value of a property.</para><para>The property name is any fully-qualified URI. It is possible for a SchemaFactory to recognize a property name but to be unable to change the current value.</para><para>SchemaFactorys are not required to recognize setting any specific property names.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setProperty
				/// </java-name>
				[Dot42.DexImport("setProperty", "(Ljava/lang/String;Ljava/lang/Object;)V", AccessFlags = 1)]
				public virtual void SetProperty(string name, object @object) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Look up the value of a property.</para><para>The property name is any fully-qualified URI. It is possible for a SchemaFactory to recognize a property name but temporarily be unable to return its value.</para><para>SchemaFactorys are not required to recognize any specific property names.</para><para>Implementers are free (and encouraged) to invent their own properties, using names built on their own URIs.</para><para><para>setProperty(String, Object) </para></para>        
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
				/// <para>Sets the ErrorHandler to receive errors encountered during the <code>newSchema</code> method invocation.</para><para>Error handler can be used to customize the error handling process during schema parsing. When an ErrorHandler is set, errors found during the parsing of schemas will be first sent to the ErrorHandler.</para><para>The error handler can abort the parsing of a schema immediately by throwing SAXException from the handler. Or for example it can print an error to the screen and try to continue the processing by returning normally from the ErrorHandler</para><para>If any Throwable (or instances of its derived classes) is thrown from an ErrorHandler, the caller of the <code>newSchema</code> method will be thrown the same Throwable object.</para><para>SchemaFactory is not allowed to throw SAXException without first reporting it to ErrorHandler.</para><para>Applications can call this method even during a Schema is being parsed.</para><para>When the ErrorHandler is null, the implementation will behave as if the following ErrorHandler is set: <pre>
				///        class DraconianErrorHandler implements ErrorHandler {
				///            public void fatalError( org.xml.sax.SAXParseException e ) throws SAXException {
				///                throw e;
				///            }
				///            public void error( org.xml.sax.SAXParseException e ) throws SAXException {
				///                throw e;
				///            }
				///            public void warning( org.xml.sax.SAXParseException e ) throws SAXException {
				///                // noop
				///            }
				///        }
				///        </pre></para><para>When a new SchemaFactory object is created, initially this field is set to null. This field will <b>NOT</b> be inherited to Schemas, Validators, or ValidatorHandlers that are created from this SchemaFactory.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setErrorHandler
				/// </java-name>
				[Dot42.DexImport("setErrorHandler", "(Lorg/xml/sax/ErrorHandler;)V", AccessFlags = 1025)]
				public abstract void SetErrorHandler(global::Org.Xml.Sax.IErrorHandler errorHandler) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Gets the current ErrorHandler set to this SchemaFactory.</para><para><para>setErrorHandler(ErrorHandler) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>This method returns the object that was last set through the setErrorHandler(ErrorHandler) method, or null if that method has never been called since this SchemaFactory has created.</para>
				/// </returns>
				/// <java-name>
				/// getErrorHandler
				/// </java-name>
				[Dot42.DexImport("getErrorHandler", "()Lorg/xml/sax/ErrorHandler;", AccessFlags = 1025)]
				public abstract global::Org.Xml.Sax.IErrorHandler GetErrorHandler() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets the LSResourceResolver to customize resource resolution when parsing schemas.</para><para>SchemaFactory uses a LSResourceResolver when it needs to locate external resources while parsing schemas, although exactly what constitutes "locating external resources" is up to each schema language. For example, for W3C XML Schema, this includes files <code>&lt;include&gt;</code>d or <code>&lt;import&gt;</code>ed, and DTD referenced from schema files, etc.</para><para>Applications can call this method even during a Schema is being parsed.</para><para>When the LSResourceResolver is null, the implementation will behave as if the following LSResourceResolver is set: <pre>
				///        class DumbDOMResourceResolver implements LSResourceResolver {
				///            public org.w3c.dom.ls.LSInput resolveResource(
				///                String publicId, String systemId, String baseURI) {
				/// 
				///                return null; // always return null
				///            }
				///        }
				///        </pre></para><para>If a LSResourceResolver throws a RuntimeException (or instances of its derived classes), then the SchemaFactory will abort the parsing and the caller of the <code>newSchema</code> method will receive the same RuntimeException.</para><para>When a new SchemaFactory object is created, initially this field is set to null. This field will <b>NOT</b> be inherited to Schemas, Validators, or ValidatorHandlers that are created from this SchemaFactory.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setResourceResolver
				/// </java-name>
				[Dot42.DexImport("setResourceResolver", "(Lorg/w3c/dom/ls/LSResourceResolver;)V", AccessFlags = 1025)]
				public abstract void SetResourceResolver(global::Org.W3c.Dom.Ls.ILSResourceResolver resourceResolver) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Gets the current LSResourceResolver set to this SchemaFactory.</para><para><para>setErrorHandler(ErrorHandler) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>This method returns the object that was last set through the setResourceResolver(LSResourceResolver) method, or null if that method has never been called since this SchemaFactory has created.</para>
				/// </returns>
				/// <java-name>
				/// getResourceResolver
				/// </java-name>
				[Dot42.DexImport("getResourceResolver", "()Lorg/w3c/dom/ls/LSResourceResolver;", AccessFlags = 1025)]
				public abstract global::Org.W3c.Dom.Ls.ILSResourceResolver GetResourceResolver() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Parses the specified source as a schema and returns it as a schema.</para><para>This is a convenience method for newSchema(Source[] schemas).</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>New <code>Schema</code> from parsing <code>schema</code>.</para>
				/// </returns>
				/// <java-name>
				/// newSchema
				/// </java-name>
				[Dot42.DexImport("newSchema", "(Ljavax/xml/transform/Source;)Ljavax/xml/validation/Schema;", AccessFlags = 1)]
				public virtual global::Javax.Xml.Validation.Schema NewSchema(global::Javax.Xml.Transform.ISource schema) /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Xml.Validation.Schema);
				}

				/// <summary>
				/// <para>Parses the specified source as a schema and returns it as a schema.</para><para>This is a convenience method for newSchema(Source[] schemas).</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>New <code>Schema</code> from parsing <code>schema</code>.</para>
				/// </returns>
				/// <java-name>
				/// newSchema
				/// </java-name>
				[Dot42.DexImport("newSchema", "(Ljava/io/File;)Ljavax/xml/validation/Schema;", AccessFlags = 1)]
				public virtual global::Javax.Xml.Validation.Schema NewSchema(global::Java.Io.File schema) /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Xml.Validation.Schema);
				}

				/// <summary>
				/// <para>Parses the specified source as a schema and returns it as a schema.</para><para>This is a convenience method for newSchema(Source[] schemas).</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>New <code>Schema</code> from parsing <code>schema</code>.</para>
				/// </returns>
				/// <java-name>
				/// newSchema
				/// </java-name>
				[Dot42.DexImport("newSchema", "(Ljava/net/URL;)Ljavax/xml/validation/Schema;", AccessFlags = 1)]
				public virtual global::Javax.Xml.Validation.Schema NewSchema(global::Java.Net.URL schema) /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Xml.Validation.Schema);
				}

				/// <summary>
				/// <para>Parses the specified source as a schema and returns it as a schema.</para><para>This is a convenience method for newSchema(Source[] schemas).</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>New <code>Schema</code> from parsing <code>schema</code>.</para>
				/// </returns>
				/// <java-name>
				/// newSchema
				/// </java-name>
				[Dot42.DexImport("newSchema", "([Ljavax/xml/transform/Source;)Ljavax/xml/validation/Schema;", AccessFlags = 1025)]
				public abstract global::Javax.Xml.Validation.Schema NewSchema(global::Javax.Xml.Transform.ISource[] schema) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Creates a special Schema object.</para><para>The exact semantics of the returned Schema object depends on the schema language that this SchemaFactory is created for.</para><para>Also, implementations are allowed to use implementation-specific property/feature to alter the semantics of this method.</para><para><h2>W3C XML Schema 1.0</h2></para><para>For XML Schema, this method creates a Schema object that performs validation by using location hints specified in documents.</para><para>The returned Schema object assumes that if documents refer to the same URL in the schema location hints, they will always resolve to the same schema document. This assumption allows implementations to reuse parsed results of schema documents so that multiple validations against the same schema will run faster.</para><para>Note that the use of schema location hints introduces a vulnerability to denial-of-service attacks.</para><para><h2>RELAX NG</h2></para><para>RELAX NG does not support this operation.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Always return non-null valid Schema object.</para>
				/// </returns>
				/// <java-name>
				/// newSchema
				/// </java-name>
				[Dot42.DexImport("newSchema", "()Ljavax/xml/validation/Schema;", AccessFlags = 1025)]
				public abstract global::Javax.Xml.Validation.Schema NewSchema() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Gets the current ErrorHandler set to this SchemaFactory.</para><para><para>setErrorHandler(ErrorHandler) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>This method returns the object that was last set through the setErrorHandler(ErrorHandler) method, or null if that method has never been called since this SchemaFactory has created.</para>
				/// </returns>
				/// <java-name>
				/// getErrorHandler
				/// </java-name>
				public global::Org.Xml.Sax.IErrorHandler ErrorHandler
				{
				[Dot42.DexImport("getErrorHandler", "()Lorg/xml/sax/ErrorHandler;", AccessFlags = 1025)]
						get{ return GetErrorHandler(); }
				[Dot42.DexImport("setErrorHandler", "(Lorg/xml/sax/ErrorHandler;)V", AccessFlags = 1025)]
						set{ SetErrorHandler(value); }
				}

				/// <summary>
				/// <para>Gets the current LSResourceResolver set to this SchemaFactory.</para><para><para>setErrorHandler(ErrorHandler) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>This method returns the object that was last set through the setResourceResolver(LSResourceResolver) method, or null if that method has never been called since this SchemaFactory has created.</para>
				/// </returns>
				/// <java-name>
				/// getResourceResolver
				/// </java-name>
				public global::Org.W3c.Dom.Ls.ILSResourceResolver ResourceResolver
				{
				[Dot42.DexImport("getResourceResolver", "()Lorg/w3c/dom/ls/LSResourceResolver;", AccessFlags = 1025)]
						get{ return GetResourceResolver(); }
				[Dot42.DexImport("setResourceResolver", "(Lorg/w3c/dom/ls/LSResourceResolver;)V", AccessFlags = 1025)]
						set{ SetResourceResolver(value); }
				}

		}

}


