// Copyright (C) 2014 dot42
//
// Original filename: Javax.Xml.Namespace.cs
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
namespace Javax.Xml.Namespace
{
		/// <summary>
		/// <para>Interface for read only XML Namespace context processing.</para><para>An XML Namespace has the properties:</para><para><ul><li><para>Namespace URI: Namespace name expressed as a URI to which the prefix is bound </para></li><li><para>prefix: syntactically, this is the part of the attribute name following the <code>XMLConstants.XMLNS_ATTRIBUTE</code> ("xmlns") in the Namespace declaration </para></li></ul></para><para>example: <code>&lt;element xmlns:prefix="http://Namespace-name-URI"&gt;</code></para><para>All <code>get*(*)</code> methods operate in the current scope for Namespace URI and prefix resolution.</para><para>Note that a Namespace URI can be bound to <b>multiple</b> prefixes in the current scope. This can occur when multiple <code>XMLConstants.XMLNS_ATTRIBUTE</code> ("xmlns") Namespace declarations occur in the same Start-Tag and refer to the same Namespace URI. e.g.<br></br> <pre>
		///    &lt;element xmlns:prefix1="http://Namespace-name-URI"
		///             xmlns:prefix2="http://Namespace-name-URI"&gt;
		///    </pre> This can also occur when the same Namespace URI is used in multiple <code>XMLConstants.XMLNS_ATTRIBUTE</code> ("xmlns") Namespace declarations in the logical parent element hierarchy. e.g.<br></br> <pre>
		///    &lt;parent xmlns:prefix1="http://Namespace-name-URI"&gt;
		///      &lt;child xmlns:prefix2="http://Namespace-name-URI"&gt;
		///        ...
		///      &lt;/child&gt;
		///    &lt;/parent&gt;
		///    </pre></para><para>A prefix can only be bound to a <b>single</b> Namespace URI in the current scope.</para><para><para> </para><para></para><title>Revision:</title><para>446598 </para>, <title>Date:</title><para>2006-09-15 05:55:40 -0700 (Fri, 15 Sep 2006) </para><para>javax.xml.XMLConstants javax.XMLConstants for declarations of common XML values </para><simplesectsep></simplesectsep><para> </para><simplesectsep></simplesectsep><para> </para><simplesectsep></simplesectsep><para> </para><para>1.5 </para></para>    
		/// </summary>
		/// <java-name>
		/// javax/xml/namespace/NamespaceContext
		/// </java-name>
		[Dot42.DexImport("javax/xml/namespace/NamespaceContext", AccessFlags = 1537)]
		public partial interface INamespaceContext
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Get Namespace URI bound to a prefix in the current scope.</para><para>When requesting a Namespace URI by prefix, the following table describes the returned Namespace URI value for all possible prefix values:</para><para><table></table></para><para><code>getNamespaceURI(prefix)</code> return value for specified prefixes   </para><para>prefix parameter </para><para>Namespace URI return value  &lt;/thead&gt; &lt;tbody&gt; </para><para><code>DEFAULT_NS_PREFIX</code> ("") </para><para>default Namespace URI in the current scope or <code>XMLConstants.NULL_NS_URI("")</code> when there is no default Namespace URI in the current scope  </para><para>bound prefix </para><para>Namespace URI bound to prefix in current scope  </para><para>unbound prefix </para><para><code>XMLConstants.NULL_NS_URI("")</code>   </para><para><code>XMLConstants.XML_NS_PREFIX</code> ("xml") </para><para><code>XMLConstants.XML_NS_URI</code> ("http://www.w3.org/XML/1998/namespace")  </para><para><code>XMLConstants.XMLNS_ATTRIBUTE</code> ("xmlns") </para><para><code>XMLConstants.XMLNS_ATTRIBUTE_NS_URI</code> ("http://www.w3.org/2000/xmlns/")  </para><para><code>null</code> </para><para><code>IllegalArgumentException</code> is thrown  &lt;/tbody&gt; </para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Namespace URI bound to prefix in the current scope </para>
				/// </returns>
				/// <java-name>
				/// getNamespaceURI
				/// </java-name>
				[Dot42.DexImport("getNamespaceURI", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1025)]
				string GetNamespaceURI(string prefix) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Get prefix bound to Namespace URI in the current scope.</para><para>To get all prefixes bound to a Namespace URI in the current scope, use getPrefixes(String namespaceURI).</para><para>When requesting a prefix by Namespace URI, the following table describes the returned prefix value for all Namespace URI values:</para><para><table></table></para><para><code>getPrefix(namespaceURI)</code> return value for specified Namespace URIs   </para><para>Namespace URI parameter </para><para>prefix value returned  &lt;/thead&gt; &lt;tbody&gt; </para><para>&lt;default Namespace URI&gt; </para><para><code>XMLConstants.DEFAULT_NS_PREFIX</code> ("")   </para><para>bound Namespace URI </para><para>prefix bound to Namespace URI in the current scope, if multiple prefixes are bound to the Namespace URI in the current scope, a single arbitrary prefix, whose choice is implementation dependent, is returned  </para><para>unbound Namespace URI </para><para><code>null</code>  </para><para><code>XMLConstants.XML_NS_URI</code> ("http://www.w3.org/XML/1998/namespace") </para><para><code>XMLConstants.XML_NS_PREFIX</code> ("xml")  </para><para><code>XMLConstants.XMLNS_ATTRIBUTE_NS_URI</code> ("http://www.w3.org/2000/xmlns/") </para><para><code>XMLConstants.XMLNS_ATTRIBUTE</code> ("xmlns")  </para><para><code>null</code> </para><para><code>IllegalArgumentException</code> is thrown  &lt;/tbody&gt; </para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>prefix bound to Namespace URI in current context </para>
				/// </returns>
				/// <java-name>
				/// getPrefix
				/// </java-name>
				[Dot42.DexImport("getPrefix", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1025)]
				string GetPrefix(string namespaceURI) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Get all prefixes bound to a Namespace URI in the current scope.</para><para>An Iterator over String elements is returned in an arbitrary, <b>implementation dependent</b>, order.</para><para><b>The <code>Iterator</code> is <b>not</b> modifiable. e.g. the <code>remove()</code> method will throw <code>UnsupportedOperationException</code>.</b></para><para>When requesting prefixes by Namespace URI, the following table describes the returned prefixes value for all Namespace URI values:</para><para><table></table></para><para><code> getPrefixes(namespaceURI)</code> return value for specified Namespace URIs  </para><para>Namespace URI parameter </para><para>prefixes value returned  &lt;/thead&gt; &lt;tbody&gt; </para><para>bound Namespace URI, including the &lt;default Namespace URI&gt; </para><para><code>Iterator</code> over prefixes bound to Namespace URI in the current scope in an arbitrary, <b>implementation dependent</b>, order  </para><para>unbound Namespace URI </para><para>empty <code>Iterator</code>  </para><para><code>XMLConstants.XML_NS_URI</code> ("http://www.w3.org/XML/1998/namespace") </para><para><code>Iterator</code> with one element set to <code>XMLConstants.XML_NS_PREFIX</code> ("xml")  </para><para><code>XMLConstants.XMLNS_ATTRIBUTE_NS_URI</code> ("http://www.w3.org/2000/xmlns/") </para><para><code>Iterator</code> with one element set to <code>XMLConstants.XMLNS_ATTRIBUTE</code> ("xmlns")  </para><para><code>null</code> </para><para><code>IllegalArgumentException</code> is thrown  &lt;/tbody&gt; </para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>Iterator</code> for all prefixes bound to the Namespace URI in the current scope </para>
				/// </returns>
				/// <java-name>
				/// getPrefixes
				/// </java-name>
				[Dot42.DexImport("getPrefixes", "(Ljava/lang/String;)Ljava/util/Iterator;", AccessFlags = 1025)]
				global::Java.Util.IIterator<object> GetPrefixes(string namespaceURI) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para><code>QName</code> represents a <b>qualified name</b> as defined in the XML specifications: , , .</para><para>The value of a <code>QName</code> contains a <b>Namespace URI</b>, <b>local part</b> and <b>prefix</b>.</para><para>The prefix is included in <code>QName</code> to retain lexical information <b><b>when present</b></b> in an XML input source. The prefix is <b><b>NOT</b></b> used in QName.equals(Object) or to compute the QName.hashCode(). Equality and the hash code are defined using <b><b>only</b></b> the Namespace URI and local part.</para><para>If not specified, the Namespace URI is set to XMLConstants.NULL_NS_URI. If not specified, the prefix is set to XMLConstants.DEFAULT_NS_PREFIX.</para><para><code>QName</code> is immutable.</para><para><para> </para><para></para><title>Revision:</title><para>754581 </para>, <title>Date:</title><para>2009-03-14 18:32:39 -0700 (Sat, 14 Mar 2009) </para><para> </para><simplesectsep></simplesectsep><para> </para><simplesectsep></simplesectsep><para> </para><para>1.5 </para></para>    
		/// </summary>
		/// <java-name>
		/// javax/xml/namespace/QName
		/// </java-name>
		[Dot42.DexImport("javax/xml/namespace/QName", AccessFlags = 33)]
		public partial class QName : global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para><code>QName</code> constructor specifying the Namespace URI and local part.</para><para>If the Namespace URI is <code>null</code>, it is set to XMLConstants.NULL_NS_URI. This value represents no explicitly defined Namespace as defined by the  specification. This action preserves compatible behavior with QName 1.0. Explicitly providing the XMLConstants.NULL_NS_URI value is the preferred coding style.</para><para>If the local part is <code>null</code> an <code>IllegalArgumentException</code> is thrown. A local part of "" is allowed to preserve compatible behavior with QName 1.0. </para><para>When using this constructor, the prefix is set to XMLConstants.DEFAULT_NS_PREFIX.</para><para>The Namespace URI is not validated as a . The local part is not validated as a  as specified in .</para><para><para>QName(String namespaceURI, String localPart, String prefix) QName(String namespaceURI, String localPart, String prefix) </para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public QName(string namespaceURI, string localPart) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para><code>QName</code> constructor specifying the Namespace URI, local part and prefix.</para><para>If the Namespace URI is <code>null</code>, it is set to XMLConstants.NULL_NS_URI. This value represents no explicitly defined Namespace as defined by the  specification. This action preserves compatible behavior with QName 1.0. Explicitly providing the XMLConstants.NULL_NS_URI value is the preferred coding style.</para><para>If the local part is <code>null</code> an <code>IllegalArgumentException</code> is thrown. A local part of "" is allowed to preserve compatible behavior with QName 1.0. </para><para>If the prefix is <code>null</code>, an <code>IllegalArgumentException</code> is thrown. Use XMLConstants.DEFAULT_NS_PREFIX to explicitly indicate that no prefix is present or the prefix is not relevant.</para><para>The Namespace URI is not validated as a . The local part and prefix are not validated as a  as specified in .</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public QName(string namespaceURI, string localPart, string prefix) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para><code>QName</code> constructor specifying the local part.</para><para>If the local part is <code>null</code> an <code>IllegalArgumentException</code> is thrown. A local part of "" is allowed to preserve compatible behavior with QName 1.0. </para><para>When using this constructor, the Namespace URI is set to XMLConstants.NULL_NS_URI and the prefix is set to XMLConstants.DEFAULT_NS_PREFIX.</para><para><b>In an XML context, all Element and Attribute names exist in the context of a Namespace. Making this explicit during the construction of a <code>QName</code> helps prevent hard to diagnosis XML validity errors. The constructors QName(String namespaceURI, String localPart) and QName(String namespaceURI, String localPart, String prefix) are preferred.</b></para><para>The local part is not validated as a  as specified in .</para><para><para>#QName(String namespaceURI, String localPart) QName(String namespaceURI, String localPart) </para><simplesectsep></simplesectsep><para>QName(String namespaceURI, String localPart, String prefix) QName(String namespaceURI, String localPart, String prefix) </para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public QName(string localPart) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Get the Namespace URI of this <code>QName</code>.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Namespace URI of this <code>QName</code> </para>
				/// </returns>
				/// <java-name>
				/// getNamespaceURI
				/// </java-name>
				[Dot42.DexImport("getNamespaceURI", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetNamespaceURI() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Get the local part of this <code>QName</code>.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>local part of this <code>QName</code> </para>
				/// </returns>
				/// <java-name>
				/// getLocalPart
				/// </java-name>
				[Dot42.DexImport("getLocalPart", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetLocalPart() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Get the prefix of this <code>QName</code>.</para><para>The prefix assigned to a <code>QName</code> might <b><b>NOT</b></b> be valid in a different context. For example, a <code>QName</code> may be assigned a prefix in the context of parsing a document but that prefix may be invalid in the context of a different document.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>prefix of this <code>QName</code> </para>
				/// </returns>
				/// <java-name>
				/// getPrefix
				/// </java-name>
				[Dot42.DexImport("getPrefix", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetPrefix() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Test this <code>QName</code> for equality with another <code>Object</code>.</para><para>If the <code>Object</code> to be tested is not a <code>QName</code> or is <code>null</code>, then this method returns <code>false</code>.</para><para>Two <code>QName</code>s are considered equal if and only if both the Namespace URI and local part are equal. This method uses <code>String.equals()</code> to check equality of the Namespace URI and local part. The prefix is <b><b>NOT</b></b> used to determine equality.</para><para>This method satisfies the general contract of Object.equals(Object)</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> if the given <code>Object</code> is equal to this <code>QName</code> else <code>false</code> </para>
				/// </returns>
				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 17)]
				public override bool Equals(object objectToTest) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Generate the hash code for this <code>QName</code>.</para><para>The hash code is calculated using both the Namespace URI and the local part of the <code>QName</code>. The prefix is <b><b>NOT</b></b> used to calculate the hash code.</para><para>This method satisfies the general contract of Object.hashCode().</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>hash code for this <code>QName</code> <code>Object</code> </para>
				/// </returns>
				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 17)]
				public override int GetHashCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para><code>String</code> representation of this <code>QName</code>.</para><para>The commonly accepted way of representing a <code>QName</code> as a <code>String</code> was  by James Clark. Although this is not a <b>standard</b> specification, it is in common use, e.g. javax.xml.transform.Transformer#setParameter(String name, Object value). This implementation represents a <code>QName</code> as: "{" + Namespace URI + "}" + local part. If the Namespace URI <code>.equals(XMLConstants.NULL_NS_URI)</code>, only the local part is returned. An appropriate use of this method is for debugging or logging for human consumption.</para><para>Note the prefix value is <b><b>NOT</b></b> returned as part of the <code>String</code> representation.</para><para>This method satisfies the general contract of Object.toString().</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>String</code> representation of this <code>QName</code> </para>
				/// </returns>
				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para><code>QName</code> derived from parsing the formatted <code>String</code>.</para><para>If the <code>String</code> is <code>null</code> or does not conform to QName.toString() formatting, an <code>IllegalArgumentException</code> is thrown.</para><para><b>The <code>String</code> <b>MUST</b> be in the form returned by QName.toString().</b></para><para>The commonly accepted way of representing a <code>QName</code> as a <code>String</code> was  by James Clark. Although this is not a <b>standard</b> specification, it is in common use, e.g. javax.xml.transform.Transformer#setParameter(String name, Object value). This implementation parses a <code>String</code> formatted as: "{" + Namespace URI + "}" + local part. If the Namespace URI <code>.equals(XMLConstants.NULL_NS_URI)</code>, only the local part should be provided.</para><para>The prefix value <b><b>CANNOT</b></b> be represented in the <code>String</code> and will be set to XMLConstants.DEFAULT_NS_PREFIX.</para><para>This method does not do full validation of the resulting <code>QName</code>. </para><para>The Namespace URI is not validated as a . The local part is not validated as a  as specified in .</para><para><para>toString() QName.toString() </para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>QName</code> corresponding to the given <code>String</code> </para>
				/// </returns>
				/// <java-name>
				/// valueOf
				/// </java-name>
				[Dot42.DexImport("valueOf", "(Ljava/lang/String;)Ljavax/xml/namespace/QName;", AccessFlags = 9)]
				public static global::Javax.Xml.Namespace.QName ValueOf(string qNameAsString) /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Xml.Namespace.QName);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal QName() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Get the Namespace URI of this <code>QName</code>.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Namespace URI of this <code>QName</code> </para>
				/// </returns>
				/// <java-name>
				/// getNamespaceURI
				/// </java-name>
				public string NamespaceURI
				{
				[Dot42.DexImport("getNamespaceURI", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetNamespaceURI(); }
				}

				/// <summary>
				/// <para>Get the local part of this <code>QName</code>.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>local part of this <code>QName</code> </para>
				/// </returns>
				/// <java-name>
				/// getLocalPart
				/// </java-name>
				public string LocalPart
				{
				[Dot42.DexImport("getLocalPart", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetLocalPart(); }
				}

				/// <summary>
				/// <para>Get the prefix of this <code>QName</code>.</para><para>The prefix assigned to a <code>QName</code> might <b><b>NOT</b></b> be valid in a different context. For example, a <code>QName</code> may be assigned a prefix in the context of parsing a document but that prefix may be invalid in the context of a different document.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>prefix of this <code>QName</code> </para>
				/// </returns>
				/// <java-name>
				/// getPrefix
				/// </java-name>
				public string Prefix
				{
				[Dot42.DexImport("getPrefix", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetPrefix(); }
				}

		}

}


