#pragma warning disable 1717
namespace Org.W3c.Dom
{
		/// <summary>
		///  <para>DOM operations only raise exceptions in "exceptional" circumstances, i.e., when an operation is impossible to perform (either for logical reasons, because data is lost, or because the implementation has become unstable). In general, DOM methods return specific error values in ordinary processing situations, such as out-of-bound errors when using  <code>NodeList</code>. </para> <para>Implementations should raise other exceptions under other circumstances. For example, implementations should raise an implementation-dependent exception if a  <code>null</code> argument is passed when  <code>null</code> was not expected. </para> <para>Some languages and object systems do not support the concept of exceptions. For such systems, error conditions may be indicated using native error reporting mechanisms. For some bindings, for example, methods may return error codes similar to those listed in the corresponding method descriptions. </para> <para>See also the . </para>    
		/// </summary>
		/// <java-name>
		/// org/w3c/dom/DOMException
		/// </java-name>
		[Dot42.DexImport("org/w3c/dom/DOMException", AccessFlags = 33)]
		public partial class DOMException : global::System.SystemException
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// code
				/// </java-name>
				[Dot42.DexImport("code", "S", AccessFlags = 1)]
				public short Code;
				/// <summary>
				///  <para>If index or size is negative, or greater than the allowed value. </para>        
				/// </summary>
				/// <java-name>
				/// INDEX_SIZE_ERR
				/// </java-name>
				[Dot42.DexImport("INDEX_SIZE_ERR", "S", AccessFlags = 25)]
				public const short INDEX_SIZE_ERR = 1;
				/// <summary>
				///  <para>If the specified range of text does not fit into a  <code>DOMString</code>. </para>        
				/// </summary>
				/// <java-name>
				/// DOMSTRING_SIZE_ERR
				/// </java-name>
				[Dot42.DexImport("DOMSTRING_SIZE_ERR", "S", AccessFlags = 25)]
				public const short DOMSTRING_SIZE_ERR = 2;
				/// <summary>
				///  <para>If any  <code>Node</code> is inserted somewhere it doesn't belong. </para>        
				/// </summary>
				/// <java-name>
				/// HIERARCHY_REQUEST_ERR
				/// </java-name>
				[Dot42.DexImport("HIERARCHY_REQUEST_ERR", "S", AccessFlags = 25)]
				public const short HIERARCHY_REQUEST_ERR = 3;
				/// <summary>
				///  <para>If a  <code>Node</code> is used in a different document than the one that created it (that doesn't support it). </para>        
				/// </summary>
				/// <java-name>
				/// WRONG_DOCUMENT_ERR
				/// </java-name>
				[Dot42.DexImport("WRONG_DOCUMENT_ERR", "S", AccessFlags = 25)]
				public const short WRONG_DOCUMENT_ERR = 4;
				/// <summary>
				///  <para>If an invalid or illegal character is specified, such as in an XML name. </para>        
				/// </summary>
				/// <java-name>
				/// INVALID_CHARACTER_ERR
				/// </java-name>
				[Dot42.DexImport("INVALID_CHARACTER_ERR", "S", AccessFlags = 25)]
				public const short INVALID_CHARACTER_ERR = 5;
				/// <summary>
				///  <para>If data is specified for a  <code>Node</code> which does not support data. </para>        
				/// </summary>
				/// <java-name>
				/// NO_DATA_ALLOWED_ERR
				/// </java-name>
				[Dot42.DexImport("NO_DATA_ALLOWED_ERR", "S", AccessFlags = 25)]
				public const short NO_DATA_ALLOWED_ERR = 6;
				/// <summary>
				///  <para>If an attempt is made to modify an object where modifications are not allowed. </para>        
				/// </summary>
				/// <java-name>
				/// NO_MODIFICATION_ALLOWED_ERR
				/// </java-name>
				[Dot42.DexImport("NO_MODIFICATION_ALLOWED_ERR", "S", AccessFlags = 25)]
				public const short NO_MODIFICATION_ALLOWED_ERR = 7;
				/// <summary>
				///  <para>If an attempt is made to reference a  <code>Node</code> in a context where it does not exist. </para>        
				/// </summary>
				/// <java-name>
				/// NOT_FOUND_ERR
				/// </java-name>
				[Dot42.DexImport("NOT_FOUND_ERR", "S", AccessFlags = 25)]
				public const short NOT_FOUND_ERR = 8;
				/// <summary>
				///  <para>If the implementation does not support the requested type of object or operation. </para>        
				/// </summary>
				/// <java-name>
				/// NOT_SUPPORTED_ERR
				/// </java-name>
				[Dot42.DexImport("NOT_SUPPORTED_ERR", "S", AccessFlags = 25)]
				public const short NOT_SUPPORTED_ERR = 9;
				/// <summary>
				///  <para>If an attempt is made to add an attribute that is already in use elsewhere. </para>        
				/// </summary>
				/// <java-name>
				/// INUSE_ATTRIBUTE_ERR
				/// </java-name>
				[Dot42.DexImport("INUSE_ATTRIBUTE_ERR", "S", AccessFlags = 25)]
				public const short INUSE_ATTRIBUTE_ERR = 10;
				/// <summary>
				///  <para>If an attempt is made to use an object that is not, or is no longer, usable.  <para>DOM Level 2 </para></para>        
				/// </summary>
				/// <java-name>
				/// INVALID_STATE_ERR
				/// </java-name>
				[Dot42.DexImport("INVALID_STATE_ERR", "S", AccessFlags = 25)]
				public const short INVALID_STATE_ERR = 11;
				/// <summary>
				///  <para>If an invalid or illegal string is specified.  <para>DOM Level 2 </para></para>        
				/// </summary>
				/// <java-name>
				/// SYNTAX_ERR
				/// </java-name>
				[Dot42.DexImport("SYNTAX_ERR", "S", AccessFlags = 25)]
				public const short SYNTAX_ERR = 12;
				/// <summary>
				///  <para>If an attempt is made to modify the type of the underlying object.  <para>DOM Level 2 </para></para>        
				/// </summary>
				/// <java-name>
				/// INVALID_MODIFICATION_ERR
				/// </java-name>
				[Dot42.DexImport("INVALID_MODIFICATION_ERR", "S", AccessFlags = 25)]
				public const short INVALID_MODIFICATION_ERR = 13;
				/// <summary>
				///  <para>If an attempt is made to create or change an object in a way which is incorrect with regard to namespaces.  <para>DOM Level 2 </para></para>        
				/// </summary>
				/// <java-name>
				/// NAMESPACE_ERR
				/// </java-name>
				[Dot42.DexImport("NAMESPACE_ERR", "S", AccessFlags = 25)]
				public const short NAMESPACE_ERR = 14;
				/// <summary>
				///  <para>If a parameter or an operation is not supported by the underlying object.  <para>DOM Level 2 </para></para>        
				/// </summary>
				/// <java-name>
				/// INVALID_ACCESS_ERR
				/// </java-name>
				[Dot42.DexImport("INVALID_ACCESS_ERR", "S", AccessFlags = 25)]
				public const short INVALID_ACCESS_ERR = 15;
				/// <summary>
				///  <para>If a call to a method such as  <code>insertBefore</code> or  <code>removeChild</code> would make the  <code>Node</code> invalid with respect to "partial validity", this exception would be raised and the operation would not be done. This code is used in [] . Refer to this specification for further information.  <para>DOM Level 3 </para></para>        
				/// </summary>
				/// <java-name>
				/// VALIDATION_ERR
				/// </java-name>
				[Dot42.DexImport("VALIDATION_ERR", "S", AccessFlags = 25)]
				public const short VALIDATION_ERR = 16;
				/// <summary>
				///  <para>If the type of an object is incompatible with the expected type of the parameter associated to the object.  <para>DOM Level 3 </para></para>        
				/// </summary>
				/// <java-name>
				/// TYPE_MISMATCH_ERR
				/// </java-name>
				[Dot42.DexImport("TYPE_MISMATCH_ERR", "S", AccessFlags = 25)]
				public const short TYPE_MISMATCH_ERR = 17;
				[Dot42.DexImport("<init>", "(SLjava/lang/String;)V", AccessFlags = 1)]
				public DOMException(short code, string message) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal DOMException() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		///  <para>The  <code>Attr</code> interface represents an attribute in an  <code>Element</code> object. Typically the allowable values for the attribute are defined in a schema associated with the document. </para> <para> <code>Attr</code> objects inherit the  <code>Node</code> interface, but since they are not actually child nodes of the element they describe, the DOM does not consider them part of the document tree. Thus, the  <code>Node</code> attributes  <code>parentNode</code>,  <code>previousSibling</code>, and  <code>nextSibling</code> have a  <code>null</code> value for  <code>Attr</code> objects. The DOM takes the view that attributes are properties of elements rather than having a separate identity from the elements they are associated with; this should make it more efficient to implement such features as default attributes associated with all elements of a given type. Furthermore,  <code>Attr</code> nodes may not be immediate children of a  <code>DocumentFragment</code>. However, they can be associated with  <code>Element</code> nodes contained within a  <code>DocumentFragment</code>. In short, users and implementors of the DOM need to be aware that  <code>Attr</code> nodes have some things in common with other objects inheriting the  <code>Node</code> interface, but they also are quite distinct. </para> <para>The attribute's effective value is determined as follows: if this attribute has been explicitly assigned any value, that value is the attribute's effective value; otherwise, if there is a declaration for this attribute, and that declaration includes a default value, then that default value is the attribute's effective value; otherwise, the attribute does not exist on this element in the structure model until it has been explicitly added. Note that the  <code>Node.nodeValue</code> attribute on the  <code>Attr</code> instance can also be used to retrieve the string version of the attribute's value(s). </para> <para>If the attribute was not explicitly given a value in the instance document but has a default value provided by the schema associated with the document, an attribute node will be created with  <code>specified</code> set to  <code>false</code>. Removing attribute nodes for which a default value is defined in the schema generates a new attribute node with the default value and  <code>specified</code> set to  <code>false</code>. If validation occurred while invoking  <code>Document.normalizeDocument()</code>, attribute nodes with  <code>specified</code> equals to  <code>false</code> are recomputed according to the default attribute values provided by the schema. If no default value is associate with this attribute in the schema, the attribute node is discarded. </para> <para>In XML, where the value of an attribute can contain entity references, the child nodes of the  <code>Attr</code> node may be either  <code>Text</code> or  <code>EntityReference</code> nodes (when these are in use; see the description of  <code>EntityReference</code> for discussion). </para> <para>The DOM Core represents all attribute values as simple strings, even if the DTD or schema associated with the document declares them of some specific type such as tokenized. </para> <para>The way attribute value normalization is performed by the DOM implementation depends on how much the implementation knows about the schema in use. Typically, the  <code>value</code> and  <code>nodeValue</code> attributes of an  <code>Attr</code> node initially returns the normalized value given by the parser. It is also the case after  <code>Document.normalizeDocument()</code> is called (assuming the right options have been set). But this may not be the case after mutation, independently of whether the mutation is performed by setting the string value directly or by changing the  <code>Attr</code> child nodes. In particular, this is true when  are involved, given that they are not represented in the DOM and they impact attribute value normalization. On the other hand, if the implementation knows about the schema in use when the attribute value is changed, and it is of a different type than CDATA, it may normalize it again at that time. This is especially true of specialized DOM implementations, such as SVG DOM implementations, which store attribute values in an internal form different from a string. </para> <para>The following table gives some examples of the relations between the attribute value in the original document (parsed attribute), the value as exposed in the DOM, and the serialization of the value:  <table> <row> <entry> <para>Examples </para></entry> <entry> <para>Parsed attribute value </para></entry> <entry> <para>Initial  <code>Attr.value</code> </para></entry> <entry> <para>Serialized attribute value  </para></entry></row> <row> <entry> <para>Character reference </para></entry> <entry> <para> <pre>"x&amp;amp;#178;=5"</pre>  </para></entry> <entry> <para> <pre>"x\u00b2=5"</pre>  </para></entry> <entry> <para> <pre>"x&amp;amp;#178;=5"</pre>   </para></entry></row> <row> <entry> <para>Built-in character entity </para></entry> <entry> <para> <pre>"y&amp;amp;lt;6"</pre>  </para></entry> <entry> <para> <pre>"y&amp;lt;6"</pre>  </para></entry> <entry> <para> <pre>"y&amp;amp;lt;6"</pre>   </para></entry></row> <row> <entry> <para>Literal newline between </para></entry> <entry> <para> <pre>
		/// "x=5&amp;amp;#10;y=6"</pre>  </para></entry> <entry> <para> <pre>"x=5 y=6"</pre>  </para></entry> <entry> <para> <pre>"x=5&amp;amp;#10;y=6"</pre>   </para></entry></row> <row> <entry> <para>Normalized newline between </para></entry> <entry> <para> <pre>"x=5
		/// y=6"</pre>  </para></entry> <entry> <para> <pre>"x=5 y=6"</pre>  </para></entry> <entry> <para> <pre>"x=5 y=6"</pre>   </para></entry></row> <row> <entry> <para>Entity  <code>e</code> with literal newline </para></entry> <entry> <para> <pre>
		/// &lt;!ENTITY e '...&amp;#10;...'&gt; [...]&gt; "x=5&amp;amp;e;y=6"</pre>  </para></entry> <entry> <para> <b>Dependent on Implementation and Load Options</b> </para></entry> <entry> <para> <b>Dependent on Implementation and Load/Save Options</b>  </para></entry></row></table></para> <para>See also the . </para>    
		/// </summary>
		/// <java-name>
		/// org/w3c/dom/Attr
		/// </java-name>
		[Dot42.DexImport("org/w3c/dom/Attr", AccessFlags = 1537)]
		public partial interface IAttr : global::Org.W3c.Dom.INode
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Returns the name of this attribute. If  <code>Node.localName</code> is different from  <code>null</code>, this attribute is a qualified name. </para>        
				/// </summary>
				/// <java-name>
				/// getName
				/// </java-name>
				string Name
				{
						[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para> <code>True</code> if this attribute was explicitly given a value in the instance document,  <code>false</code> otherwise. If the application changed the value of this attribute node (even if it ends up having the same value as the default value) then it is set to  <code>true</code>. The implementation may handle attributes with default values from other schemas similarly but applications should use  <code>Document.normalizeDocument()</code> to guarantee this information is up-to-date. </para>        
				/// </summary>
				/// <java-name>
				/// getSpecified
				/// </java-name>
				bool IsSpecified
				{
						[Dot42.DexImport("getSpecified", "()Z", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>On retrieval, the value of the attribute is returned as a string. Character and general entity references are replaced with their values. See also the method  <code>getAttribute</code> on the  <code>Element</code> interface.  <br></br>On setting, this creates a  <code>Text</code> node with the unparsed contents of the string, i.e. any characters that an XML processor would recognize as markup are instead treated as literal text. See also the method  <code>Element.setAttribute()</code>.  <br></br> Some specialized implementations, such as some [] implementations, may do normalization automatically, even after mutation; in such case, the value on retrieval may differ from the value on setting. </para>        
				/// </summary>
				/// <java-name>
				/// getValue
				/// </java-name>
				string Value
				{
						[Dot42.DexImport("getValue", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
						[Dot42.DexImport("setValue", "(Ljava/lang/String;)V", AccessFlags = 1025)]
						set;
				}

				/// <summary>
				///  <para>The  <code>Element</code> node this attribute is attached to or  <code>null</code> if this attribute is not in use.  <para>DOM Level 2 </para></para>        
				/// </summary>
				/// <java-name>
				/// getOwnerElement
				/// </java-name>
				global::Org.W3c.Dom.IElement OwnerElement
				{
						[Dot42.DexImport("getOwnerElement", "()Lorg/w3c/dom/Element;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>The type information associated with this attribute. While the type information contained in this attribute is guarantee to be correct after loading the document or invoking  <code>Document.normalizeDocument()</code>,  <code>schemaTypeInfo</code> may not be reliable if the node was moved.  <para>DOM Level 3 </para></para>        
				/// </summary>
				/// <java-name>
				/// getSchemaTypeInfo
				/// </java-name>
				global::Org.W3c.Dom.ITypeInfo SchemaTypeInfo
				{
						[Dot42.DexImport("getSchemaTypeInfo", "()Lorg/w3c/dom/TypeInfo;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Returns whether this attribute is known to be of type ID (i.e. to contain an identifier for its owner element) or not. When it is and its value is unique, the  <code>ownerElement</code> of this attribute can be retrieved using the method  <code>Document.getElementById</code> . The implementation could use several ways to determine if an attribute node is known to contain an identifier:  <ul> <li> <para>If validation occurred using an XML Schema [] while loading the document or while invoking  <code>Document.normalizeDocument()</code>, the post-schema-validation infoset contributions (PSVI contributions) values are used to determine if this attribute is a schema-determined ID attribute using the  definition in [] </para></li> <li> <para>If validation occurred using a DTD while loading the document or while invoking  <code>Document.normalizeDocument()</code>, the infoset  <b>[type definition]</b> value is used to determine if this attribute is a DTD-determined ID attribute using the  definition in [] </para></li> <li> <para>from the use of the methods  <code>Element.setIdAttribute()</code>,  <code>Element.setIdAttributeNS()</code>, or  <code>Element.setIdAttributeNode()</code>, i.e. it is an user-determined ID attribute; </para> <para> <b>Note:</b> XPointer framework (see section 3.2 in [] ) consider the DOM user-determined ID attribute as being part of the XPointer externally-determined ID definition.  </para></li> <li> <para>using mechanisms that are outside the scope of this specification, it is then an externally-determined ID attribute. This includes using schema languages different from XML schema and DTD.  </para></li></ul> <br></br> If validation occurred while invoking  <code>Document.normalizeDocument()</code>, all user-determined ID attributes are reset and all attribute nodes ID information are then reevaluated in accordance to the schema used. As a consequence, if the  <code>Attr.schemaTypeInfo</code> attribute contains an ID type,  <code>isId</code> will always return true.  <para>DOM Level 3 </para></para>        
				/// </summary>
				/// <java-name>
				/// isId
				/// </java-name>
				bool IsId
				{
						[Dot42.DexImport("isId", "()Z", AccessFlags = 1025)]
						get;
				}

		}

		/// <summary>
		///  <para>CDATA sections are used to escape blocks of text containing characters that would otherwise be regarded as markup. The only delimiter that is recognized in a CDATA section is the "]]&amp;gt;" string that ends the CDATA section. CDATA sections cannot be nested. Their primary purpose is for including material such as XML fragments, without needing to escape all the delimiters. </para> <para>The  <code>CharacterData.data</code> attribute holds the text that is contained by the CDATA section. Note that this  <b>may</b> contain characters that need to be escaped outside of CDATA sections and that, depending on the character encoding ("charset") chosen for serialization, it may be impossible to write out some characters as part of a CDATA section. </para> <para>The  <code>CDATASection</code> interface inherits from the  <code>CharacterData</code> interface through the  <code>Text</code> interface. Adjacent  <code>CDATASection</code> nodes are not merged by use of the  <code>normalize</code> method of the  <code>Node</code> interface. </para> <para>No lexical check is done on the content of a CDATA section and it is therefore possible to have the character sequence  <code>"]]&amp;gt;"</code> in the content, which is illegal in a CDATA section per section 2.7 of []. The presence of this character sequence must generate a fatal error during serialization or the cdata section must be splitted before the serialization (see also the parameter  <code>"split-cdata-sections"</code> in the  <code>DOMConfiguration</code> interface). </para> <para> <b>Note:</b> Because no markup is recognized within a  <code>CDATASection</code>, character numeric references cannot be used as an escape mechanism when serializing. Therefore, action needs to be taken when serializing a  <code>CDATASection</code> with a character encoding where some of the contained characters cannot be represented. Failure to do so would not produce well-formed XML. </para> <para> <b>Note:</b> One potential solution in the serialization process is to end the CDATA section before the character, output the character using a character reference or entity reference, and open a new CDATA section for any further characters in the text node. Note, however, that some code conversion libraries at the time of writing do not return an error or exception when a character is missing from the encoding, making the task of ensuring that data is not corrupted on serialization more difficult. </para> <para>See also the . </para>    
		/// </summary>
		/// <java-name>
		/// org/w3c/dom/CDATASection
		/// </java-name>
		[Dot42.DexImport("org/w3c/dom/CDATASection", AccessFlags = 1537)]
		public partial interface ICDATASection : global::Org.W3c.Dom.IText
 /* scope: __dot42__ */ 
		{
		}

		/// <summary>
		///  <para>The  <code>CharacterData</code> interface extends Node with a set of attributes and methods for accessing character data in the DOM. For clarity this set is defined here rather than on each object that uses these attributes and methods. No DOM objects correspond directly to  <code>CharacterData</code>, though  <code>Text</code> and others do inherit the interface from it. All  <code>offsets</code> in this interface start from  <code>0</code>. </para> <para>As explained in the  <code>DOMString</code> interface, text strings in the DOM are represented in UTF-16, i.e. as a sequence of 16-bit units. In the following, the term 16-bit units is used whenever necessary to indicate that indexing on CharacterData is done in 16-bit units. </para> <para>See also the . </para>    
		/// </summary>
		/// <java-name>
		/// org/w3c/dom/CharacterData
		/// </java-name>
		[Dot42.DexImport("org/w3c/dom/CharacterData", AccessFlags = 1537)]
		public partial interface ICharacterData : global::Org.W3c.Dom.INode
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Extracts a range of data from the node. </para>        
				/// </summary>
				/// <returns>
				///  <para>The specified substring. If the sum of  <code>offset</code> and  <code>count</code> exceeds the  <code>length</code>, then all 16-bit units to the end of the data are returned. </para>
				/// </returns>
				/// <java-name>
				/// substringData
				/// </java-name>
				[Dot42.DexImport("substringData", "(II)Ljava/lang/String;", AccessFlags = 1025)]
				string SubstringData(int offset, int count) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Append the string to the end of the character data of the node. Upon success,  <code>data</code> provides access to the concatenation of  <code>data</code> and the  <code>DOMString</code> specified. </para>        
				/// </summary>
				/// <java-name>
				/// appendData
				/// </java-name>
				[Dot42.DexImport("appendData", "(Ljava/lang/String;)V", AccessFlags = 1025)]
				void AppendData(string arg) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Insert a string at the specified 16-bit unit offset. </para>        
				/// </summary>
				/// <java-name>
				/// insertData
				/// </java-name>
				[Dot42.DexImport("insertData", "(ILjava/lang/String;)V", AccessFlags = 1025)]
				void InsertData(int offset, string arg) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Remove a range of 16-bit units from the node. Upon success,  <code>data</code> and  <code>length</code> reflect the change. </para>        
				/// </summary>
				/// <java-name>
				/// deleteData
				/// </java-name>
				[Dot42.DexImport("deleteData", "(II)V", AccessFlags = 1025)]
				void DeleteData(int offset, int count) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Replace the characters starting at the specified 16-bit unit offset with the specified string. </para>        
				/// </summary>
				/// <java-name>
				/// replaceData
				/// </java-name>
				[Dot42.DexImport("replaceData", "(IILjava/lang/String;)V", AccessFlags = 1025)]
				void ReplaceData(int offset, int count, string arg) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>The character data of the node that implements this interface. The DOM implementation may not put arbitrary limits on the amount of data that may be stored in a  <code>CharacterData</code> node. However, implementation limits may mean that the entirety of a node's data may not fit into a single  <code>DOMString</code>. In such cases, the user may call  <code>substringData</code> to retrieve the data in appropriately sized pieces. </para>        
				/// </summary>
				/// <java-name>
				/// getData
				/// </java-name>
				string Data
				{
						[Dot42.DexImport("getData", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
						[Dot42.DexImport("setData", "(Ljava/lang/String;)V", AccessFlags = 1025)]
						set;
				}

				/// <summary>
				///  <para>The number of 16-bit units that are available through  <code>data</code> and the  <code>substringData</code> method below. This may have the value zero, i.e.,  <code>CharacterData</code> nodes may be empty. </para>        
				/// </summary>
				/// <java-name>
				/// getLength
				/// </java-name>
				int Length
				{
						[Dot42.DexImport("getLength", "()I", AccessFlags = 1025)]
						get;
				}

		}

		/// <summary>
		///  <para>This interface inherits from  <code>CharacterData</code> and represents the content of a comment, i.e., all the characters between the starting '  <code>&lt;!</code>' and ending ' <code>&gt;</code>'. Note that this is the definition of a comment in XML, and, in practice, HTML, although some HTML tools may implement the full SGML comment structure. </para> <para>No lexical check is done on the content of a comment and it is therefore possible to have the character sequence  <code>"--"</code> (double-hyphen) in the content, which is illegal in a comment per section 2.5 of []. The presence of this character sequence must generate a fatal error during serialization. </para> <para>See also the . </para>    
		/// </summary>
		/// <java-name>
		/// org/w3c/dom/Comment
		/// </java-name>
		[Dot42.DexImport("org/w3c/dom/Comment", AccessFlags = 1537)]
		public partial interface IComment : global::Org.W3c.Dom.ICharacterData
 /* scope: __dot42__ */ 
		{
		}

		/// <summary>
		///  <para>The  <code>Document</code> interface represents the entire HTML or XML document. Conceptually, it is the root of the document tree, and provides the primary access to the document's data. </para> <para>Since elements, text nodes, comments, processing instructions, etc. cannot exist outside the context of a  <code>Document</code>, the  <code>Document</code> interface also contains the factory methods needed to create these objects. The  <code>Node</code> objects created have a  <code>ownerDocument</code> attribute which associates them with the  <code>Document</code> within whose context they were created. </para> <para>See also the . </para>    
		/// </summary>
		/// <java-name>
		/// org/w3c/dom/Document
		/// </java-name>
		[Dot42.DexImport("org/w3c/dom/Document", AccessFlags = 1537)]
		public partial interface IDocument : global::Org.W3c.Dom.INode
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Creates an element of the type specified. Note that the instance returned implements the  <code>Element</code> interface, so attributes can be specified directly on the returned object.  <br></br>In addition, if there are known attributes with default values,  <code>Attr</code> nodes representing them are automatically created and attached to the element.  <br></br>To create an element with a qualified name and namespace URI, use the  <code>createElementNS</code> method. </para>        
				/// </summary>
				/// <returns>
				///  <para>A new  <code>Element</code> object with the  <code>nodeName</code> attribute set to  <code>tagName</code>, and  <code>localName</code>,  <code>prefix</code>, and  <code>namespaceURI</code> set to  <code>null</code>. </para>
				/// </returns>
				/// <java-name>
				/// createElement
				/// </java-name>
				[Dot42.DexImport("createElement", "(Ljava/lang/String;)Lorg/w3c/dom/Element;", AccessFlags = 1025)]
				global::Org.W3c.Dom.IElement CreateElement(string tagName) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Creates an empty  <code>DocumentFragment</code> object. </para>        
				/// </summary>
				/// <returns>
				///  <para>A new  <code>DocumentFragment</code>. </para>
				/// </returns>
				/// <java-name>
				/// createDocumentFragment
				/// </java-name>
				[Dot42.DexImport("createDocumentFragment", "()Lorg/w3c/dom/DocumentFragment;", AccessFlags = 1025)]
				global::Org.W3c.Dom.IDocumentFragment CreateDocumentFragment() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Creates a  <code>Text</code> node given the specified string. </para>        
				/// </summary>
				/// <returns>
				///  <para>The new  <code>Text</code> object. </para>
				/// </returns>
				/// <java-name>
				/// createTextNode
				/// </java-name>
				[Dot42.DexImport("createTextNode", "(Ljava/lang/String;)Lorg/w3c/dom/Text;", AccessFlags = 1025)]
				global::Org.W3c.Dom.IText CreateTextNode(string data) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Creates a  <code>Comment</code> node given the specified string. </para>        
				/// </summary>
				/// <returns>
				///  <para>The new  <code>Comment</code> object. </para>
				/// </returns>
				/// <java-name>
				/// createComment
				/// </java-name>
				[Dot42.DexImport("createComment", "(Ljava/lang/String;)Lorg/w3c/dom/Comment;", AccessFlags = 1025)]
				global::Org.W3c.Dom.IComment CreateComment(string data) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Creates a  <code>CDATASection</code> node whose value is the specified string. </para>        
				/// </summary>
				/// <returns>
				///  <para>The new  <code>CDATASection</code> object. </para>
				/// </returns>
				/// <java-name>
				/// createCDATASection
				/// </java-name>
				[Dot42.DexImport("createCDATASection", "(Ljava/lang/String;)Lorg/w3c/dom/CDATASection;", AccessFlags = 1025)]
				global::Org.W3c.Dom.ICDATASection CreateCDATASection(string data) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Creates a  <code>ProcessingInstruction</code> node given the specified name and data strings. </para>        
				/// </summary>
				/// <returns>
				///  <para>The new  <code>ProcessingInstruction</code> object. </para>
				/// </returns>
				/// <java-name>
				/// createProcessingInstruction
				/// </java-name>
				[Dot42.DexImport("createProcessingInstruction", "(Ljava/lang/String;Ljava/lang/String;)Lorg/w3c/dom/ProcessingInstruction;", AccessFlags = 1025)]
				global::Org.W3c.Dom.IProcessingInstruction CreateProcessingInstruction(string target, string data) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Creates an  <code>Attr</code> of the given name. Note that the  <code>Attr</code> instance can then be set on an  <code>Element</code> using the  <code>setAttributeNode</code> method.  <br></br>To create an attribute with a qualified name and namespace URI, use the  <code>createAttributeNS</code> method. </para>        
				/// </summary>
				/// <returns>
				///  <para>A new  <code>Attr</code> object with the  <code>nodeName</code> attribute set to  <code>name</code>, and  <code>localName</code>,  <code>prefix</code>, and  <code>namespaceURI</code> set to  <code>null</code>. The value of the attribute is the empty string. </para>
				/// </returns>
				/// <java-name>
				/// createAttribute
				/// </java-name>
				[Dot42.DexImport("createAttribute", "(Ljava/lang/String;)Lorg/w3c/dom/Attr;", AccessFlags = 1025)]
				global::Org.W3c.Dom.IAttr CreateAttribute(string name) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Creates an  <code>EntityReference</code> object. In addition, if the referenced entity is known, the child list of the  <code>EntityReference</code> node is made the same as that of the corresponding  <code>Entity</code> node. </para> <para> <b>Note:</b> If any descendant of the  <code>Entity</code> node has an unbound namespace prefix, the corresponding descendant of the created  <code>EntityReference</code> node is also unbound; (its  <code>namespaceURI</code> is  <code>null</code>). The DOM Level 2 and 3 do not support any mechanism to resolve namespace prefixes in this case. </para>        
				/// </summary>
				/// <returns>
				///  <para>The new  <code>EntityReference</code> object. </para>
				/// </returns>
				/// <java-name>
				/// createEntityReference
				/// </java-name>
				[Dot42.DexImport("createEntityReference", "(Ljava/lang/String;)Lorg/w3c/dom/EntityReference;", AccessFlags = 1025)]
				global::Org.W3c.Dom.IEntityReference CreateEntityReference(string name) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns a  <code>NodeList</code> of all the  <code>Elements</code> in document order with a given tag name and are contained in the document. </para>        
				/// </summary>
				/// <returns>
				///  <para>A new  <code>NodeList</code> object containing all the matched  <code>Elements</code>. </para>
				/// </returns>
				/// <java-name>
				/// getElementsByTagName
				/// </java-name>
				[Dot42.DexImport("getElementsByTagName", "(Ljava/lang/String;)Lorg/w3c/dom/NodeList;", AccessFlags = 1025)]
				global::Org.W3c.Dom.INodeList GetElementsByTagName(string tagname) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Imports a node from another document to this document, without altering or removing the source node from the original document; this method creates a new copy of the source node. The returned node has no parent; ( <code>parentNode</code> is  <code>null</code>).  <br></br>For all nodes, importing a node creates a node object owned by the importing document, with attribute values identical to the source node's  <code>nodeName</code> and  <code>nodeType</code>, plus the attributes related to namespaces ( <code>prefix</code>,  <code>localName</code>, and  <code>namespaceURI</code>). As in the  <code>cloneNode</code> operation, the source node is not altered. User data associated to the imported node is not carried over. However, if any  <code>UserDataHandlers</code> has been specified along with the associated data these handlers will be called with the appropriate parameters before this method returns.  <br></br>Additional information is copied as appropriate to the  <code>nodeType</code>, attempting to mirror the behavior expected if a fragment of XML or HTML source was copied from one document to another, recognizing that the two documents may have different DTDs in the XML case. The following list describes the specifics for each type of node.  <para>DOM Level 2 </para></para>        
				/// </summary>
				/// <returns>
				///  <para>The imported node that belongs to this  <code>Document</code>. </para>
				/// </returns>
				/// <java-name>
				/// importNode
				/// </java-name>
				[Dot42.DexImport("importNode", "(Lorg/w3c/dom/Node;Z)Lorg/w3c/dom/Node;", AccessFlags = 1025)]
				global::Org.W3c.Dom.INode ImportNode(global::Org.W3c.Dom.INode importedNode, bool deep) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Creates an element of the given qualified name and namespace URI.  <br></br>Per [] , applications must use the value  <code>null</code> as the namespaceURI parameter for methods if they wish to have no namespace.  <para>DOM Level 2 </para></para>        
				/// </summary>
				/// <returns>
				///  <para>A new  <code>Element</code> object with the following attributes:  <table> <row> <entry> <para>Attribute </para></entry> <entry> <para>Value  </para></entry></row> <row> <entry> <para> <code>Node.nodeName</code> </para></entry> <entry> <para> <code>qualifiedName</code>  </para></entry></row> <row> <entry> <para> <code>Node.namespaceURI</code> </para></entry> <entry> <para> <code>namespaceURI</code>  </para></entry></row> <row> <entry> <para> <code>Node.prefix</code> </para></entry> <entry> <para>prefix, extracted from  <code>qualifiedName</code>, or  <code>null</code> if there is no prefix  </para></entry></row> <row> <entry> <para> <code>Node.localName</code> </para></entry> <entry> <para>local name, extracted from  <code>qualifiedName</code>  </para></entry></row> <row> <entry> <para> <code>Element.tagName</code> </para></entry> <entry> <para> <code>qualifiedName</code>  </para></entry></row></table></para>
				/// </returns>
				/// <java-name>
				/// createElementNS
				/// </java-name>
				[Dot42.DexImport("createElementNS", "(Ljava/lang/String;Ljava/lang/String;)Lorg/w3c/dom/Element;", AccessFlags = 1025)]
				global::Org.W3c.Dom.IElement CreateElementNS(string namespaceURI, string qualifiedName) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Creates an attribute of the given qualified name and namespace URI.  <br></br>Per [] , applications must use the value  <code>null</code> as the  <code>namespaceURI</code> parameter for methods if they wish to have no namespace.  <para>DOM Level 2 </para></para>        
				/// </summary>
				/// <returns>
				///  <para>A new  <code>Attr</code> object with the following attributes:  <table> <row> <entry> <para>Attribute </para></entry> <entry> <para>Value  </para></entry></row> <row> <entry> <para> <code>Node.nodeName</code> </para></entry> <entry> <para>qualifiedName  </para></entry></row> <row> <entry> <para> <code>Node.namespaceURI</code> </para></entry> <entry> <para> <code>namespaceURI</code>  </para></entry></row> <row> <entry> <para> <code>Node.prefix</code> </para></entry> <entry> <para>prefix, extracted from  <code>qualifiedName</code>, or  <code>null</code> if there is no prefix  </para></entry></row> <row> <entry> <para> <code>Node.localName</code> </para></entry> <entry> <para>local name, extracted from  <code>qualifiedName</code>  </para></entry></row> <row> <entry> <para> <code>Attr.name</code> </para></entry> <entry> <para> <code>qualifiedName</code>  </para></entry></row> <row> <entry> <para> <code>Node.nodeValue</code> </para></entry> <entry> <para>the empty string  </para></entry></row></table></para>
				/// </returns>
				/// <java-name>
				/// createAttributeNS
				/// </java-name>
				[Dot42.DexImport("createAttributeNS", "(Ljava/lang/String;Ljava/lang/String;)Lorg/w3c/dom/Attr;", AccessFlags = 1025)]
				global::Org.W3c.Dom.IAttr CreateAttributeNS(string namespaceURI, string qualifiedName) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns a  <code>NodeList</code> of all the  <code>Elements</code> with a given local name and namespace URI in document order.  <para>DOM Level 2 </para></para>        
				/// </summary>
				/// <returns>
				///  <para>A new  <code>NodeList</code> object containing all the matched  <code>Elements</code>. </para>
				/// </returns>
				/// <java-name>
				/// getElementsByTagNameNS
				/// </java-name>
				[Dot42.DexImport("getElementsByTagNameNS", "(Ljava/lang/String;Ljava/lang/String;)Lorg/w3c/dom/NodeList;", AccessFlags = 1025)]
				global::Org.W3c.Dom.INodeList GetElementsByTagNameNS(string namespaceURI, string localName) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns the  <code>Element</code> that has an ID attribute with the given value. If no such element exists, this returns  <code>null</code> . If more than one element has an ID attribute with that value, what is returned is undefined.  <br></br> The DOM implementation is expected to use the attribute  <code>Attr.isId</code> to determine if an attribute is of type ID. </para> <para> <b>Note:</b> Attributes with the name "ID" or "id" are not of type ID unless so defined.  <para>DOM Level 2 </para></para>        
				/// </summary>
				/// <returns>
				///  <para>The matching element or  <code>null</code> if there is none. </para>
				/// </returns>
				/// <java-name>
				/// getElementById
				/// </java-name>
				[Dot42.DexImport("getElementById", "(Ljava/lang/String;)Lorg/w3c/dom/Element;", AccessFlags = 1025)]
				global::Org.W3c.Dom.IElement GetElementById(string elementId) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Attempts to adopt a node from another document to this document. If supported, it changes the  <code>ownerDocument</code> of the source node, its children, as well as the attached attribute nodes if there are any. If the source node has a parent it is first removed from the child list of its parent. This effectively allows moving a subtree from one document to another (unlike  <code>importNode()</code> which create a copy of the source node instead of moving it). When it fails, applications should use  <code>Document.importNode()</code> instead. Note that if the adopted node is already part of this document (i.e. the source and target document are the same), this method still has the effect of removing the source node from the child list of its parent, if any. The following list describes the specifics for each type of node. </para> <para> <b>Note:</b> Since it does not create new nodes unlike the  <code>Document.importNode()</code> method, this method does not raise an  <code>INVALID_CHARACTER_ERR</code> exception, and applications should use the  <code>Document.normalizeDocument()</code> method to check if an imported name is not an XML name according to the XML version in use.  <para>DOM Level 3 </para></para>        
				/// </summary>
				/// <returns>
				///  <para>The adopted node, or  <code>null</code> if this operation fails, such as when the source node comes from a different implementation. </para>
				/// </returns>
				/// <java-name>
				/// adoptNode
				/// </java-name>
				[Dot42.DexImport("adoptNode", "(Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;", AccessFlags = 1025)]
				global::Org.W3c.Dom.INode AdoptNode(global::Org.W3c.Dom.INode source) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>This method acts as if the document was going through a save and load cycle, putting the document in a "normal" form. As a consequence, this method updates the replacement tree of  <code>EntityReference</code> nodes and normalizes  <code>Text</code> nodes, as defined in the method  <code>Node.normalize()</code>.  <br></br> Otherwise, the actual result depends on the features being set on the  <code>Document.domConfig</code> object and governing what operations actually take place. Noticeably this method could also make the document namespace well-formed according to the algorithm described in , check the character normalization, remove the  <code>CDATASection</code> nodes, etc. See  <code>DOMConfiguration</code> for details.  <pre>// Keep in the document
				/// the information defined // in the XML Information Set (Java example)
				/// DOMConfiguration docConfig = myDocument.getDomConfig();
				/// docConfig.setParameter("infoset", Boolean.TRUE);
				/// myDocument.normalizeDocument();</pre></para> <para> <br></br>Mutation events, when supported, are generated to reflect the changes occurring on the document.  <br></br> If errors occur during the invocation of this method, such as an attempt to update a read-only node or a  <code>Node.nodeName</code> contains an invalid character according to the XML version in use, errors or warnings ( <code>DOMError.SEVERITY_ERROR</code> or  <code>DOMError.SEVERITY_WARNING</code>) will be reported using the  <code>DOMErrorHandler</code> object associated with the "error-handler" parameter. Note this method might also report fatal errors (  <code>DOMError.SEVERITY_FATAL_ERROR</code>) if an implementation cannot recover from an error.  <para>DOM Level 3 </para></para>        
				/// </summary>
				/// <java-name>
				/// normalizeDocument
				/// </java-name>
				[Dot42.DexImport("normalizeDocument", "()V", AccessFlags = 1025)]
				void NormalizeDocument() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Rename an existing node of type  <code>ELEMENT_NODE</code> or  <code>ATTRIBUTE_NODE</code>.  <br></br>When possible this simply changes the name of the given node, otherwise this creates a new node with the specified name and replaces the existing node with the new node as described below.  <br></br>If simply changing the name of the given node is not possible, the following operations are performed: a new node is created, any registered event listener is registered on the new node, any user data attached to the old node is removed from that node, the old node is removed from its parent if it has one, the children are moved to the new node, if the renamed node is an  <code>Element</code> its attributes are moved to the new node, the new node is inserted at the position the old node used to have in its parent's child nodes list if it has one, the user data that was attached to the old node is attached to the new node.  <br></br>When the node being renamed is an  <code>Element</code> only the specified attributes are moved, default attributes originated from the DTD are updated according to the new element name. In addition, the implementation may update default attributes from other schemas. Applications should use  <code>Document.normalizeDocument()</code> to guarantee these attributes are up-to-date.  <br></br>When the node being renamed is an  <code>Attr</code> that is attached to an  <code>Element</code>, the node is first removed from the  <code>Element</code> attributes map. Then, once renamed, either by modifying the existing node or creating a new one as described above, it is put back.  <br></br>In addition,  <ul> <li> <para>a user data event  <code>NODE_RENAMED</code> is fired,  </para></li> <li> <para>when the implementation supports the feature "MutationNameEvents", each mutation operation involved in this method fires the appropriate event, and in the end the event {  <code></code>,  <code>DOMElementNameChanged</code>} or {  <code></code>,  <code>DOMAttributeNameChanged</code>} is fired.  </para></li></ul> <para>DOM Level 3 </para></para>        
				/// </summary>
				/// <returns>
				///  <para>The renamed node. This is either the specified node or the new node that was created to replace the specified node. </para>
				/// </returns>
				/// <java-name>
				/// renameNode
				/// </java-name>
				[Dot42.DexImport("renameNode", "(Lorg/w3c/dom/Node;Ljava/lang/String;Ljava/lang/String;)Lorg/w3c/dom/Node;", AccessFlags = 1025)]
				global::Org.W3c.Dom.INode RenameNode(global::Org.W3c.Dom.INode n, string namespaceURI, string qualifiedName) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>The Document Type Declaration (see  <code>DocumentType</code>) associated with this document. For XML documents without a document type declaration this returns  <code>null</code>. For HTML documents, a  <code>DocumentType</code> object may be returned, independently of the presence or absence of document type declaration in the HTML document.  <br></br>This provides direct access to the  <code>DocumentType</code> node, child node of this  <code>Document</code>. This node can be set at document creation time and later changed through the use of child nodes manipulation methods, such as  <code>Node.insertBefore</code>, or  <code>Node.replaceChild</code>. Note, however, that while some implementations may instantiate different types of  <code>Document</code> objects supporting additional features than the "Core", such as "HTML" [] , based on the  <code>DocumentType</code> specified at creation time, changing it afterwards is very unlikely to result in a change of the features supported.  <para>DOM Level 3 </para></para>        
				/// </summary>
				/// <java-name>
				/// getDoctype
				/// </java-name>
				global::Org.W3c.Dom.IDocumentType Doctype
				{
						[Dot42.DexImport("getDoctype", "()Lorg/w3c/dom/DocumentType;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>The  <code>DOMImplementation</code> object that handles this document. A DOM application may use objects from multiple implementations. </para>        
				/// </summary>
				/// <java-name>
				/// getImplementation
				/// </java-name>
				global::Org.W3c.Dom.IDOMImplementation Implementation
				{
						[Dot42.DexImport("getImplementation", "()Lorg/w3c/dom/DOMImplementation;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>This is a convenience attribute that allows direct access to the child node that is the document element of the document. </para>        
				/// </summary>
				/// <java-name>
				/// getDocumentElement
				/// </java-name>
				global::Org.W3c.Dom.IElement DocumentElement
				{
						[Dot42.DexImport("getDocumentElement", "()Lorg/w3c/dom/Element;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>An attribute specifying the encoding used for this document at the time of the parsing. This is  <code>null</code> when it is not known, such as when the  <code>Document</code> was created in memory.  <para>DOM Level 3 </para></para>        
				/// </summary>
				/// <java-name>
				/// getInputEncoding
				/// </java-name>
				string InputEncoding
				{
						[Dot42.DexImport("getInputEncoding", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>An attribute specifying, as part of the , the encoding of this document. This is  <code>null</code> when unspecified or when it is not known, such as when the  <code>Document</code> was created in memory.  <para>DOM Level 3 </para></para>        
				/// </summary>
				/// <java-name>
				/// getXmlEncoding
				/// </java-name>
				string XmlEncoding
				{
						[Dot42.DexImport("getXmlEncoding", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>An attribute specifying, as part of the , whether this document is standalone. This is  <code>false</code> when unspecified. </para> <para> <b>Note:</b> No verification is done on the value when setting this attribute. Applications should use  <code>Document.normalizeDocument()</code> with the "validate" parameter to verify if the value matches the  as defined in [].  <para>DOM Level 3 </para></para>        
				/// </summary>
				/// <java-name>
				/// getXmlStandalone
				/// </java-name>
				bool IsXmlStandalone
				{
						[Dot42.DexImport("getXmlStandalone", "()Z", AccessFlags = 1025)]
						get;
						[Dot42.DexImport("setXmlStandalone", "(Z)V", AccessFlags = 1025)]
						set;
				}

				/// <summary>
				///  <para>An attribute specifying, as part of the , the version number of this document. If there is no declaration and if this document supports the "XML" feature, the value is  <code>"1.0"</code>. If this document does not support the "XML" feature, the value is always  <code>null</code>. Changing this attribute will affect methods that check for invalid characters in XML names. Application should invoke  <code>Document.normalizeDocument()</code> in order to check for invalid characters in the  <code>Node</code>s that are already part of this  <code>Document</code>.  <br></br> DOM applications may use the  <code>DOMImplementation.hasFeature(feature, version)</code> method with parameter values "XMLVersion" and "1.0" (respectively) to determine if an implementation supports []. DOM applications may use the same method with parameter values "XMLVersion" and "1.1" (respectively) to determine if an implementation supports []. In both cases, in order to support XML, an implementation must also support the "XML" feature defined in this specification.  <code>Document</code> objects supporting a version of the "XMLVersion" feature must not raise a  <code>NOT_SUPPORTED_ERR</code> exception for the same version number when using  <code>Document.xmlVersion</code>.  <para>DOM Level 3 </para></para>        
				/// </summary>
				/// <java-name>
				/// getXmlVersion
				/// </java-name>
				string XmlVersion
				{
						[Dot42.DexImport("getXmlVersion", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
						[Dot42.DexImport("setXmlVersion", "(Ljava/lang/String;)V", AccessFlags = 1025)]
						set;
				}

				/// <summary>
				///  <para>An attribute specifying whether error checking is enforced or not. When set to  <code>false</code>, the implementation is free to not test every possible error case normally defined on DOM operations, and not raise any  <code>DOMException</code> on DOM operations or report errors while using  <code>Document.normalizeDocument()</code>. In case of error, the behavior is undefined. This attribute is  <code>true</code> by default.  <para>DOM Level 3 </para></para>        
				/// </summary>
				/// <java-name>
				/// getStrictErrorChecking
				/// </java-name>
				bool IsStrictErrorChecking
				{
						[Dot42.DexImport("getStrictErrorChecking", "()Z", AccessFlags = 1025)]
						get;
						[Dot42.DexImport("setStrictErrorChecking", "(Z)V", AccessFlags = 1025)]
						set;
				}

				/// <summary>
				///  <para>The location of the document or  <code>null</code> if undefined or if the  <code>Document</code> was created using  <code>DOMImplementation.createDocument</code>. No lexical checking is performed when setting this attribute; this could result in a  <code>null</code> value returned when using  <code>Node.baseURI</code> <br></br> Beware that when the  <code>Document</code> supports the feature "HTML" [] , the href attribute of the HTML BASE element takes precedence over this attribute when computing  <code>Node.baseURI</code>.  <para>DOM Level 3 </para></para>        
				/// </summary>
				/// <java-name>
				/// getDocumentURI
				/// </java-name>
				string DocumentURI
				{
						[Dot42.DexImport("getDocumentURI", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
						[Dot42.DexImport("setDocumentURI", "(Ljava/lang/String;)V", AccessFlags = 1025)]
						set;
				}

				/// <summary>
				///  <para>The configuration used when  <code>Document.normalizeDocument()</code> is invoked.  <para>DOM Level 3 </para></para>        
				/// </summary>
				/// <java-name>
				/// getDomConfig
				/// </java-name>
				global::Org.W3c.Dom.IDOMConfiguration DomConfig
				{
						[Dot42.DexImport("getDomConfig", "()Lorg/w3c/dom/DOMConfiguration;", AccessFlags = 1025)]
						get;
				}

		}

		/// <summary>
		///  <para> <code>DocumentFragment</code> is a "lightweight" or "minimal"  <code>Document</code> object. It is very common to want to be able to extract a portion of a document's tree or to create a new fragment of a document. Imagine implementing a user command like cut or rearranging a document by moving fragments around. It is desirable to have an object which can hold such fragments and it is quite natural to use a Node for this purpose. While it is true that a  <code>Document</code> object could fulfill this role, a  <code>Document</code> object can potentially be a heavyweight object, depending on the underlying implementation. What is really needed for this is a very lightweight object.  <code>DocumentFragment</code> is such an object. </para> <para>Furthermore, various operations  such as inserting nodes as children of another  <code>Node</code>  may take  <code>DocumentFragment</code> objects as arguments; this results in all the child nodes of the  <code>DocumentFragment</code> being moved to the child list of this node. </para> <para>The children of a  <code>DocumentFragment</code> node are zero or more nodes representing the tops of any sub-trees defining the structure of the document.  <code>DocumentFragment</code> nodes do not need to be well-formed XML documents (although they do need to follow the rules imposed upon well-formed XML parsed entities, which can have multiple top nodes). For example, a  <code>DocumentFragment</code> might have only one child and that child node could be a  <code>Text</code> node. Such a structure model represents neither an HTML document nor a well-formed XML document. </para> <para>When a  <code>DocumentFragment</code> is inserted into a  <code>Document</code> (or indeed any other  <code>Node</code> that may take children) the children of the  <code>DocumentFragment</code> and not the  <code>DocumentFragment</code> itself are inserted into the  <code>Node</code>. This makes the  <code>DocumentFragment</code> very useful when the user wishes to create nodes that are siblings; the  <code>DocumentFragment</code> acts as the parent of these nodes so that the user can use the standard methods from the  <code>Node</code> interface, such as  <code>Node.insertBefore</code> and  <code>Node.appendChild</code>. </para> <para>See also the . </para>    
		/// </summary>
		/// <java-name>
		/// org/w3c/dom/DocumentFragment
		/// </java-name>
		[Dot42.DexImport("org/w3c/dom/DocumentFragment", AccessFlags = 1537)]
		public partial interface IDocumentFragment : global::Org.W3c.Dom.INode
 /* scope: __dot42__ */ 
		{
		}

		/// <summary>
		///  <para>Each  <code>Document</code> has a  <code>doctype</code> attribute whose value is either  <code>null</code> or a  <code>DocumentType</code> object. The  <code>DocumentType</code> interface in the DOM Core provides an interface to the list of entities that are defined for the document, and little else because the effect of namespaces and the various XML schema efforts on DTD representation are not clearly understood as of this writing. </para> <para>DOM Level 3 doesn't support editing  <code>DocumentType</code> nodes.  <code>DocumentType</code> nodes are read-only. </para> <para>See also the . </para>    
		/// </summary>
		/// <java-name>
		/// org/w3c/dom/DocumentType
		/// </java-name>
		[Dot42.DexImport("org/w3c/dom/DocumentType", AccessFlags = 1537)]
		public partial interface IDocumentType : global::Org.W3c.Dom.INode
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>The name of DTD; i.e., the name immediately following the  <code>DOCTYPE</code> keyword. </para>        
				/// </summary>
				/// <java-name>
				/// getName
				/// </java-name>
				string Name
				{
						[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>A  <code>NamedNodeMap</code> containing the general entities, both external and internal, declared in the DTD. Parameter entities are not contained. Duplicates are discarded. For example in:  <pre>&lt;!DOCTYPE
				/// ex SYSTEM "ex.dtd" [ &lt;!ENTITY foo "foo"&gt; &lt;!ENTITY bar
				/// "bar"&gt; &lt;!ENTITY bar "bar2"&gt; &lt;!ENTITY % baz "baz"&gt;
				/// ]&gt; &lt;ex/&gt;</pre> the interface provides access to  <code>foo</code> and the first declaration of  <code>bar</code> but not the second declaration of  <code>bar</code> or  <code>baz</code>. Every node in this map also implements the  <code>Entity</code> interface.  <br></br>The DOM Level 2 does not support editing entities, therefore  <code>entities</code> cannot be altered in any way. </para>        
				/// </summary>
				/// <java-name>
				/// getEntities
				/// </java-name>
				global::Org.W3c.Dom.INamedNodeMap Entities
				{
						[Dot42.DexImport("getEntities", "()Lorg/w3c/dom/NamedNodeMap;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>A  <code>NamedNodeMap</code> containing the notations declared in the DTD. Duplicates are discarded. Every node in this map also implements the  <code>Notation</code> interface.  <br></br>The DOM Level 2 does not support editing notations, therefore  <code>notations</code> cannot be altered in any way. </para>        
				/// </summary>
				/// <java-name>
				/// getNotations
				/// </java-name>
				global::Org.W3c.Dom.INamedNodeMap Notations
				{
						[Dot42.DexImport("getNotations", "()Lorg/w3c/dom/NamedNodeMap;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>The public identifier of the external subset.  <para>DOM Level 2 </para></para>        
				/// </summary>
				/// <java-name>
				/// getPublicId
				/// </java-name>
				string PublicId
				{
						[Dot42.DexImport("getPublicId", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>The system identifier of the external subset. This may be an absolute URI or not.  <para>DOM Level 2 </para></para>        
				/// </summary>
				/// <java-name>
				/// getSystemId
				/// </java-name>
				string SystemId
				{
						[Dot42.DexImport("getSystemId", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>The internal subset as a string, or  <code>null</code> if there is none. This is does not contain the delimiting square brackets. </para> <para> <b>Note:</b> The actual content returned depends on how much information is available to the implementation. This may vary depending on various parameters, including the XML processor used to build the document.  <para>DOM Level 2 </para></para>        
				/// </summary>
				/// <java-name>
				/// getInternalSubset
				/// </java-name>
				string InternalSubset
				{
						[Dot42.DexImport("getInternalSubset", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

		}

		/// <summary>
		///  <para>The  <code>DOMConfiguration</code> interface represents the configuration of a document and maintains a table of recognized parameters. Using the configuration, it is possible to change  <code>Document.normalizeDocument()</code> behavior, such as replacing the  <code>CDATASection</code> nodes with  <code>Text</code> nodes or specifying the type of the schema that must be used when the validation of the  <code>Document</code> is requested.  <code>DOMConfiguration</code> objects are also used in [] in the  <code>DOMParser</code> and  <code>DOMSerializer</code> interfaces. </para> <para>The parameter names used by the  <code>DOMConfiguration</code> object are defined throughout the DOM Level 3 specifications. Names are case-insensitive. To avoid possible conflicts, as a convention, names referring to parameters defined outside the DOM specification should be made unique. Because parameters are exposed as properties in the , names are recommended to follow the section 5.16 Identifiers of [Unicode] with the addition of the character '-' (HYPHEN-MINUS) but it is not enforced by the DOM implementation. DOM Level 3 Core Implementations are required to recognize all parameters defined in this specification. Some parameter values may also be required to be supported by the implementation. Refer to the definition of the parameter to know if a value must be supported or not. </para> <para> <b>Note:</b> Parameters are similar to features and properties used in SAX2 []. </para> <para>The following list of parameters defined in the DOM: </para> <para>The resolution of the system identifiers associated with entities is done using  <code>Document.documentURI</code>. However, when the feature "LS" defined in [] is supported by the DOM implementation, the parameter "resource-resolver" can also be used on  <code>DOMConfiguration</code> objects attached to  <code>Document</code> nodes. If this parameter is set,  <code>Document.normalizeDocument()</code> will invoke the resource resolver instead of using  <code>Document.documentURI</code>. </para> <para>See also the .  <para>DOM Level 3 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/w3c/dom/DOMConfiguration
		/// </java-name>
		[Dot42.DexImport("org/w3c/dom/DOMConfiguration", AccessFlags = 1537)]
		public partial interface IDOMConfiguration
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Set the value of a parameter. </para>        
				/// </summary>
				/// <java-name>
				/// setParameter
				/// </java-name>
				[Dot42.DexImport("setParameter", "(Ljava/lang/String;Ljava/lang/Object;)V", AccessFlags = 1025)]
				void SetParameter(string name, object value) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Return the value of a parameter if known. </para>        
				/// </summary>
				/// <returns>
				///  <para>The current object associated with the specified parameter or  <code>null</code> if no object has been associated or if the parameter is not supported. </para>
				/// </returns>
				/// <java-name>
				/// getParameter
				/// </java-name>
				[Dot42.DexImport("getParameter", "(Ljava/lang/String;)Ljava/lang/Object;", AccessFlags = 1025)]
				object GetParameter(string name) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Check if setting a parameter to a specific value is supported. </para>        
				/// </summary>
				/// <returns>
				///  <para> <code>true</code> if the parameter could be successfully set to the specified value, or  <code>false</code> if the parameter is not recognized or the requested value is not supported. This does not change the current value of the parameter itself. </para>
				/// </returns>
				/// <java-name>
				/// canSetParameter
				/// </java-name>
				[Dot42.DexImport("canSetParameter", "(Ljava/lang/String;Ljava/lang/Object;)Z", AccessFlags = 1025)]
				bool CanSetParameter(string name, object value) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>The list of the parameters supported by this  <code>DOMConfiguration</code> object and for which at least one value can be set by the application. Note that this list can also contain parameter names defined outside this specification. </para>        
				/// </summary>
				/// <java-name>
				/// getParameterNames
				/// </java-name>
				global::Org.W3c.Dom.IDOMStringList ParameterNames
				{
						[Dot42.DexImport("getParameterNames", "()Lorg/w3c/dom/DOMStringList;", AccessFlags = 1025)]
						get;
				}

		}

		/// <summary>
		///  <para> <code>DOMError</code> is an interface that describes an error. </para> <para>See also the .  <para>DOM Level 3 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/w3c/dom/DOMError
		/// </java-name>
		[Dot42.DexImport("org/w3c/dom/DOMError", AccessFlags = 1537)]
		public partial interface IDOMError
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>The severity of the error, either  <code>SEVERITY_WARNING</code>,  <code>SEVERITY_ERROR</code>, or  <code>SEVERITY_FATAL_ERROR</code>. </para>        
				/// </summary>
				/// <java-name>
				/// getSeverity
				/// </java-name>
				short Severity
				{
						[Dot42.DexImport("getSeverity", "()S", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>An implementation specific string describing the error that occurred. </para>        
				/// </summary>
				/// <java-name>
				/// getMessage
				/// </java-name>
				string Message
				{
						[Dot42.DexImport("getMessage", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>A  <code>DOMString</code> indicating which related data is expected in  <code>relatedData</code>. Users should refer to the specification of the error in order to find its  <code>DOMString</code> type and  <code>relatedData</code> definitions if any. </para> <para> <b>Note:</b> As an example,  <code>Document.normalizeDocument()</code> does generate warnings when the "split-cdata-sections" parameter is in use. Therefore, the method generates a  <code>SEVERITY_WARNING</code> with  <code>type</code>  <code>"cdata-sections-splitted"</code> and the first  <code>CDATASection</code> node in document order resulting from the split is returned by the  <code>relatedData</code> attribute. </para>        
				/// </summary>
				/// <java-name>
				/// getType
				/// </java-name>
				string Type
				{
						[Dot42.DexImport("getType", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>The related platform dependent exception if any. </para>        
				/// </summary>
				/// <java-name>
				/// getRelatedException
				/// </java-name>
				object RelatedException
				{
						[Dot42.DexImport("getRelatedException", "()Ljava/lang/Object;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>The related  <code>DOMError.type</code> dependent data if any. </para>        
				/// </summary>
				/// <java-name>
				/// getRelatedData
				/// </java-name>
				object RelatedData
				{
						[Dot42.DexImport("getRelatedData", "()Ljava/lang/Object;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>The location of the error. </para>        
				/// </summary>
				/// <java-name>
				/// getLocation
				/// </java-name>
				global::Org.W3c.Dom.IDOMLocator Location
				{
						[Dot42.DexImport("getLocation", "()Lorg/w3c/dom/DOMLocator;", AccessFlags = 1025)]
						get;
				}

		}

		/// <summary>
		///  <para> <code>DOMError</code> is an interface that describes an error. </para> <para>See also the .  <para>DOM Level 3 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/w3c/dom/DOMError
		/// </java-name>
		[Dot42.DexImport("org/w3c/dom/DOMError", AccessFlags = 1537, IgnoreFromJava = true, Priority = 1)]
		public static partial class IDOMErrorConstants
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>The severity of the error described by the  <code>DOMError</code> is warning. A  <code>SEVERITY_WARNING</code> will not cause the processing to stop, unless  <code>DOMErrorHandler.handleError()</code> returns  <code>false</code>. </para>        
				/// </summary>
				/// <java-name>
				/// SEVERITY_WARNING
				/// </java-name>
				[Dot42.DexImport("SEVERITY_WARNING", "S", AccessFlags = 25)]
				public const short SEVERITY_WARNING = 1;
				/// <summary>
				///  <para>The severity of the error described by the  <code>DOMError</code> is error. A  <code>SEVERITY_ERROR</code> may not cause the processing to stop if the error can be recovered, unless  <code>DOMErrorHandler.handleError()</code> returns  <code>false</code>. </para>        
				/// </summary>
				/// <java-name>
				/// SEVERITY_ERROR
				/// </java-name>
				[Dot42.DexImport("SEVERITY_ERROR", "S", AccessFlags = 25)]
				public const short SEVERITY_ERROR = 2;
				/// <summary>
				///  <para>The severity of the error described by the  <code>DOMError</code> is fatal error. A  <code>SEVERITY_FATAL_ERROR</code> will cause the normal processing to stop. The return value of  <code>DOMErrorHandler.handleError()</code> is ignored unless the implementation chooses to continue, in which case the behavior becomes undefined. </para>        
				/// </summary>
				/// <java-name>
				/// SEVERITY_FATAL_ERROR
				/// </java-name>
				[Dot42.DexImport("SEVERITY_FATAL_ERROR", "S", AccessFlags = 25)]
				public const short SEVERITY_FATAL_ERROR = 3;
		}

		/// <summary>
		///  <para> <code>DOMErrorHandler</code> is a callback interface that the DOM implementation can call when reporting errors that happens while processing XML data, or when doing some other processing (e.g. validating a document). A  <code>DOMErrorHandler</code> object can be attached to a  <code>Document</code> using the "error-handler" on the  <code>DOMConfiguration</code> interface. If more than one error needs to be reported during an operation, the sequence and numbers of the errors passed to the error handler are implementation dependent. </para> <para>The application that is using the DOM implementation is expected to implement this interface. </para> <para>See also the .  <para>DOM Level 3 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/w3c/dom/DOMErrorHandler
		/// </java-name>
		[Dot42.DexImport("org/w3c/dom/DOMErrorHandler", AccessFlags = 1537)]
		public partial interface IDOMErrorHandler
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>This method is called on the error handler when an error occurs.  <br></br> If an exception is thrown from this method, it is considered to be equivalent of returning  <code>true</code>. </para>        
				/// </summary>
				/// <returns>
				///  <para>If the  <code>handleError</code> method returns  <code>false</code>, the DOM implementation should stop the current processing when possible. If the method returns  <code>true</code>, the processing may continue depending on  <code>DOMError.severity</code>. </para>
				/// </returns>
				/// <java-name>
				/// handleError
				/// </java-name>
				[Dot42.DexImport("handleError", "(Lorg/w3c/dom/DOMError;)Z", AccessFlags = 1025)]
				bool HandleError(global::Org.W3c.Dom.IDOMError error) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		///  <para>The  <code>DOMImplementation</code> interface provides a number of methods for performing operations that are independent of any particular instance of the document object model. </para> <para>See also the . </para>    
		/// </summary>
		/// <java-name>
		/// org/w3c/dom/DOMImplementation
		/// </java-name>
		[Dot42.DexImport("org/w3c/dom/DOMImplementation", AccessFlags = 1537)]
		public partial interface IDOMImplementation
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Test if the DOM implementation implements a specific feature and version, as specified in . </para>        
				/// </summary>
				/// <returns>
				///  <para> <code>true</code> if the feature is implemented in the specified version,  <code>false</code> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// hasFeature
				/// </java-name>
				[Dot42.DexImport("hasFeature", "(Ljava/lang/String;Ljava/lang/String;)Z", AccessFlags = 1025)]
				bool HasFeature(string feature, string version) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Creates an empty  <code>DocumentType</code> node. Entity declarations and notations are not made available. Entity reference expansions and default attribute additions do not occur..  <para>DOM Level 2 </para></para>        
				/// </summary>
				/// <returns>
				///  <para>A new  <code>DocumentType</code> node with  <code>Node.ownerDocument</code> set to  <code>null</code>. </para>
				/// </returns>
				/// <java-name>
				/// createDocumentType
				/// </java-name>
				[Dot42.DexImport("createDocumentType", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lorg/w3c/dom/DocumentType" +
    ";", AccessFlags = 1025)]
				global::Org.W3c.Dom.IDocumentType CreateDocumentType(string qualifiedName, string publicId, string systemId) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Creates a DOM Document object of the specified type with its document element.  <br></br>Note that based on the  <code>DocumentType</code> given to create the document, the implementation may instantiate specialized  <code>Document</code> objects that support additional features than the "Core", such as "HTML" [] . On the other hand, setting the  <code>DocumentType</code> after the document was created makes this very unlikely to happen. Alternatively, specialized  <code>Document</code> creation methods, such as  <code>createHTMLDocument</code> [] , can be used to obtain specific types of  <code>Document</code> objects.  <para>DOM Level 2 </para></para>        
				/// </summary>
				/// <returns>
				///  <para>A new  <code>Document</code> object with its document element. If the  <code>NamespaceURI</code>,  <code>qualifiedName</code>, and  <code>doctype</code> are  <code>null</code>, the returned  <code>Document</code> is empty with no document element. </para>
				/// </returns>
				/// <java-name>
				/// createDocument
				/// </java-name>
				[Dot42.DexImport("createDocument", "(Ljava/lang/String;Ljava/lang/String;Lorg/w3c/dom/DocumentType;)Lorg/w3c/dom/Docu" +
    "ment;", AccessFlags = 1025)]
				global::Org.W3c.Dom.IDocument CreateDocument(string namespaceURI, string qualifiedName, global::Org.W3c.Dom.IDocumentType doctype) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>This method returns a specialized object which implements the specialized APIs of the specified feature and version, as specified in . The specialized object may also be obtained by using binding-specific casting methods but is not necessarily expected to, as discussed in . This method also allow the implementation to provide specialized objects which do not support the  <code>DOMImplementation</code> interface.  <para>DOM Level 3 </para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns an object which implements the specialized APIs of the specified feature and version, if any, or  <code>null</code> if there is no object which implements interfaces associated with that feature. If the  <code>DOMObject</code> returned by this method implements the  <code>DOMImplementation</code> interface, it must delegate to the primary core  <code>DOMImplementation</code> and not return results inconsistent with the primary core  <code>DOMImplementation</code> such as  <code>hasFeature</code>,  <code>getFeature</code>, etc. </para>
				/// </returns>
				/// <java-name>
				/// getFeature
				/// </java-name>
				[Dot42.DexImport("getFeature", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/Object;", AccessFlags = 1025)]
				object GetFeature(string feature, string version) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		///  <para>The  <code>DOMImplementationList</code> interface provides the abstraction of an ordered collection of DOM implementations, without defining or constraining how this collection is implemented. The items in the  <code>DOMImplementationList</code> are accessible via an integral index, starting from 0. </para> <para>See also the .  <para>DOM Level 3 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/w3c/dom/DOMImplementationList
		/// </java-name>
		[Dot42.DexImport("org/w3c/dom/DOMImplementationList", AccessFlags = 1537)]
		public partial interface IDOMImplementationList
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Returns the  <code>index</code>th item in the collection. If  <code>index</code> is greater than or equal to the number of  <code>DOMImplementation</code>s in the list, this returns  <code>null</code>. </para>        
				/// </summary>
				/// <returns>
				///  <para>The  <code>DOMImplementation</code> at the  <code>index</code> th position in the  <code>DOMImplementationList</code>, or  <code>null</code> if that is not a valid index. </para>
				/// </returns>
				/// <java-name>
				/// item
				/// </java-name>
				[Dot42.DexImport("item", "(I)Lorg/w3c/dom/DOMImplementation;", AccessFlags = 1025)]
				global::Org.W3c.Dom.IDOMImplementation Item(int index) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>The number of  <code>DOMImplementation</code>s in the list. The range of valid child node indices is 0 to  <code>length-1</code> inclusive. </para>        
				/// </summary>
				/// <java-name>
				/// getLength
				/// </java-name>
				int Length
				{
						[Dot42.DexImport("getLength", "()I", AccessFlags = 1025)]
						get;
				}

		}

		/// <summary>
		///  <para>This interface permits a DOM implementer to supply one or more implementations, based upon requested features and versions, as specified in . Each implemented  <code>DOMImplementationSource</code> object is listed in the binding-specific list of available sources so that its  <code>DOMImplementation</code> objects are made available. </para> <para>See also the .  <para>DOM Level 3 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/w3c/dom/DOMImplementationSource
		/// </java-name>
		[Dot42.DexImport("org/w3c/dom/DOMImplementationSource", AccessFlags = 1537)]
		public partial interface IDOMImplementationSource
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>A method to request the first DOM implementation that supports the specified features. </para>        
				/// </summary>
				/// <returns>
				///  <para>The first DOM implementation that support the desired features, or  <code>null</code> if this source has none. </para>
				/// </returns>
				/// <java-name>
				/// getDOMImplementation
				/// </java-name>
				[Dot42.DexImport("getDOMImplementation", "(Ljava/lang/String;)Lorg/w3c/dom/DOMImplementation;", AccessFlags = 1025)]
				global::Org.W3c.Dom.IDOMImplementation GetDOMImplementation(string features) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>A method to request a list of DOM implementations that support the specified features and versions, as specified in . </para>        
				/// </summary>
				/// <returns>
				///  <para>A list of DOM implementations that support the desired features. </para>
				/// </returns>
				/// <java-name>
				/// getDOMImplementationList
				/// </java-name>
				[Dot42.DexImport("getDOMImplementationList", "(Ljava/lang/String;)Lorg/w3c/dom/DOMImplementationList;", AccessFlags = 1025)]
				global::Org.W3c.Dom.IDOMImplementationList GetDOMImplementationList(string features) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		///  <para> <code>DOMLocator</code> is an interface that describes a location (e.g. where an error occurred). </para> <para>See also the .  <para>DOM Level 3 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/w3c/dom/DOMLocator
		/// </java-name>
		[Dot42.DexImport("org/w3c/dom/DOMLocator", AccessFlags = 1537)]
		public partial interface IDOMLocator
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>The line number this locator is pointing to, or  <code>-1</code> if there is no column number available. </para>        
				/// </summary>
				/// <java-name>
				/// getLineNumber
				/// </java-name>
				int LineNumber
				{
						[Dot42.DexImport("getLineNumber", "()I", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>The column number this locator is pointing to, or  <code>-1</code> if there is no column number available. </para>        
				/// </summary>
				/// <java-name>
				/// getColumnNumber
				/// </java-name>
				int ColumnNumber
				{
						[Dot42.DexImport("getColumnNumber", "()I", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>The byte offset into the input source this locator is pointing to or  <code>-1</code> if there is no byte offset available. </para>        
				/// </summary>
				/// <java-name>
				/// getByteOffset
				/// </java-name>
				int ByteOffset
				{
						[Dot42.DexImport("getByteOffset", "()I", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>The UTF-16, as defined in [Unicode] and Amendment 1 of [ISO/IEC 10646], offset into the input source this locator is pointing to or  <code>-1</code> if there is no UTF-16 offset available. </para>        
				/// </summary>
				/// <java-name>
				/// getUtf16Offset
				/// </java-name>
				int Utf16Offset
				{
						[Dot42.DexImport("getUtf16Offset", "()I", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>The node this locator is pointing to, or  <code>null</code> if no node is available. </para>        
				/// </summary>
				/// <java-name>
				/// getRelatedNode
				/// </java-name>
				global::Org.W3c.Dom.INode RelatedNode
				{
						[Dot42.DexImport("getRelatedNode", "()Lorg/w3c/dom/Node;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>The URI this locator is pointing to, or  <code>null</code> if no URI is available. </para>        
				/// </summary>
				/// <java-name>
				/// getUri
				/// </java-name>
				string Uri
				{
						[Dot42.DexImport("getUri", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

		}

		/// <summary>
		///  <para>The  <code>DOMStringList</code> interface provides the abstraction of an ordered collection of  <code>DOMString</code> values, without defining or constraining how this collection is implemented. The items in the  <code>DOMStringList</code> are accessible via an integral index, starting from 0. </para> <para>See also the .  <para>DOM Level 3 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/w3c/dom/DOMStringList
		/// </java-name>
		[Dot42.DexImport("org/w3c/dom/DOMStringList", AccessFlags = 1537)]
		public partial interface IDOMStringList
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Returns the  <code>index</code>th item in the collection. If  <code>index</code> is greater than or equal to the number of  <code>DOMString</code>s in the list, this returns  <code>null</code>. </para>        
				/// </summary>
				/// <returns>
				///  <para>The  <code>DOMString</code> at the  <code>index</code>th position in the  <code>DOMStringList</code>, or  <code>null</code> if that is not a valid index. </para>
				/// </returns>
				/// <java-name>
				/// item
				/// </java-name>
				[Dot42.DexImport("item", "(I)Ljava/lang/String;", AccessFlags = 1025)]
				string Item(int index) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Test if a string is part of this  <code>DOMStringList</code>. </para>        
				/// </summary>
				/// <returns>
				///  <para> <code>true</code> if the string has been found,  <code>false</code> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// contains
				/// </java-name>
				[Dot42.DexImport("contains", "(Ljava/lang/String;)Z", AccessFlags = 1025)]
				bool Contains(string str) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>The number of  <code>DOMString</code>s in the list. The range of valid child node indices is 0 to  <code>length-1</code> inclusive. </para>        
				/// </summary>
				/// <java-name>
				/// getLength
				/// </java-name>
				int Length
				{
						[Dot42.DexImport("getLength", "()I", AccessFlags = 1025)]
						get;
				}

		}

		/// <summary>
		///  <para>The  <code>Element</code> interface represents an element in an HTML or XML document. Elements may have attributes associated with them; since the  <code>Element</code> interface inherits from  <code>Node</code>, the generic  <code>Node</code> interface attribute  <code>attributes</code> may be used to retrieve the set of all attributes for an element. There are methods on the  <code>Element</code> interface to retrieve either an  <code>Attr</code> object by name or an attribute value by name. In XML, where an attribute value may contain entity references, an  <code>Attr</code> object should be retrieved to examine the possibly fairly complex sub-tree representing the attribute value. On the other hand, in HTML, where all attributes have simple string values, methods to directly access an attribute value can safely be used as a convenience. </para> <para> <b>Note:</b> In DOM Level 2, the method  <code>normalize</code> is inherited from the  <code>Node</code> interface where it was moved. </para> <para>See also the . </para>    
		/// </summary>
		/// <java-name>
		/// org/w3c/dom/Element
		/// </java-name>
		[Dot42.DexImport("org/w3c/dom/Element", AccessFlags = 1537)]
		public partial interface IElement : global::Org.W3c.Dom.INode
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Retrieves an attribute value by name. </para>        
				/// </summary>
				/// <returns>
				///  <para>The  <code>Attr</code> value as a string, or the empty string if that attribute does not have a specified or default value. </para>
				/// </returns>
				/// <java-name>
				/// getAttribute
				/// </java-name>
				[Dot42.DexImport("getAttribute", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1025)]
				string GetAttribute(string name) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Adds a new attribute. If an attribute with that name is already present in the element, its value is changed to be that of the value parameter. This value is a simple string; it is not parsed as it is being set. So any markup (such as syntax to be recognized as an entity reference) is treated as literal text, and needs to be appropriately escaped by the implementation when it is written out. In order to assign an attribute value that contains entity references, the user must create an  <code>Attr</code> node plus any  <code>Text</code> and  <code>EntityReference</code> nodes, build the appropriate subtree, and use  <code>setAttributeNode</code> to assign it as the value of an attribute.  <br></br>To set an attribute with a qualified name and namespace URI, use the  <code>setAttributeNS</code> method. </para>        
				/// </summary>
				/// <java-name>
				/// setAttribute
				/// </java-name>
				[Dot42.DexImport("setAttribute", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1025)]
				void SetAttribute(string name, string value) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Removes an attribute by name. If a default value for the removed attribute is defined in the DTD, a new attribute immediately appears with the default value as well as the corresponding namespace URI, local name, and prefix when applicable. The implementation may handle default values from other schemas similarly but applications should use  <code>Document.normalizeDocument()</code> to guarantee this information is up-to-date.  <br></br>If no attribute with this name is found, this method has no effect.  <br></br>To remove an attribute by local name and namespace URI, use the  <code>removeAttributeNS</code> method. </para>        
				/// </summary>
				/// <java-name>
				/// removeAttribute
				/// </java-name>
				[Dot42.DexImport("removeAttribute", "(Ljava/lang/String;)V", AccessFlags = 1025)]
				void RemoveAttribute(string name) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Retrieves an attribute node by name.  <br></br>To retrieve an attribute node by qualified name and namespace URI, use the  <code>getAttributeNodeNS</code> method. </para>        
				/// </summary>
				/// <returns>
				///  <para>The  <code>Attr</code> node with the specified name (  <code>nodeName</code>) or  <code>null</code> if there is no such attribute. </para>
				/// </returns>
				/// <java-name>
				/// getAttributeNode
				/// </java-name>
				[Dot42.DexImport("getAttributeNode", "(Ljava/lang/String;)Lorg/w3c/dom/Attr;", AccessFlags = 1025)]
				global::Org.W3c.Dom.IAttr GetAttributeNode(string name) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Adds a new attribute node. If an attribute with that name (  <code>nodeName</code>) is already present in the element, it is replaced by the new one. Replacing an attribute node by itself has no effect.  <br></br>To add a new attribute node with a qualified name and namespace URI, use the  <code>setAttributeNodeNS</code> method. </para>        
				/// </summary>
				/// <returns>
				///  <para>If the  <code>newAttr</code> attribute replaces an existing attribute, the replaced  <code>Attr</code> node is returned, otherwise  <code>null</code> is returned. </para>
				/// </returns>
				/// <java-name>
				/// setAttributeNode
				/// </java-name>
				[Dot42.DexImport("setAttributeNode", "(Lorg/w3c/dom/Attr;)Lorg/w3c/dom/Attr;", AccessFlags = 1025)]
				global::Org.W3c.Dom.IAttr SetAttributeNode(global::Org.W3c.Dom.IAttr newAttr) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Removes the specified attribute node. If a default value for the removed  <code>Attr</code> node is defined in the DTD, a new node immediately appears with the default value as well as the corresponding namespace URI, local name, and prefix when applicable. The implementation may handle default values from other schemas similarly but applications should use  <code>Document.normalizeDocument()</code> to guarantee this information is up-to-date. </para>        
				/// </summary>
				/// <returns>
				///  <para>The  <code>Attr</code> node that was removed. </para>
				/// </returns>
				/// <java-name>
				/// removeAttributeNode
				/// </java-name>
				[Dot42.DexImport("removeAttributeNode", "(Lorg/w3c/dom/Attr;)Lorg/w3c/dom/Attr;", AccessFlags = 1025)]
				global::Org.W3c.Dom.IAttr RemoveAttributeNode(global::Org.W3c.Dom.IAttr oldAttr) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns a  <code>NodeList</code> of all descendant  <code>Elements</code> with a given tag name, in document order. </para>        
				/// </summary>
				/// <returns>
				///  <para>A list of matching  <code>Element</code> nodes. </para>
				/// </returns>
				/// <java-name>
				/// getElementsByTagName
				/// </java-name>
				[Dot42.DexImport("getElementsByTagName", "(Ljava/lang/String;)Lorg/w3c/dom/NodeList;", AccessFlags = 1025)]
				global::Org.W3c.Dom.INodeList GetElementsByTagName(string name) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Retrieves an attribute value by local name and namespace URI.  <br></br>Per [] , applications must use the value  <code>null</code> as the  <code>namespaceURI</code> parameter for methods if they wish to have no namespace.  <para>DOM Level 2 </para></para>        
				/// </summary>
				/// <returns>
				///  <para>The  <code>Attr</code> value as a string, or the empty string if that attribute does not have a specified or default value. </para>
				/// </returns>
				/// <java-name>
				/// getAttributeNS
				/// </java-name>
				[Dot42.DexImport("getAttributeNS", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1025)]
				string GetAttributeNS(string namespaceURI, string localName) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Adds a new attribute. If an attribute with the same local name and namespace URI is already present on the element, its prefix is changed to be the prefix part of the  <code>qualifiedName</code>, and its value is changed to be the  <code>value</code> parameter. This value is a simple string; it is not parsed as it is being set. So any markup (such as syntax to be recognized as an entity reference) is treated as literal text, and needs to be appropriately escaped by the implementation when it is written out. In order to assign an attribute value that contains entity references, the user must create an  <code>Attr</code> node plus any  <code>Text</code> and  <code>EntityReference</code> nodes, build the appropriate subtree, and use  <code>setAttributeNodeNS</code> or  <code>setAttributeNode</code> to assign it as the value of an attribute.  <br></br>Per [] , applications must use the value  <code>null</code> as the  <code>namespaceURI</code> parameter for methods if they wish to have no namespace.  <para>DOM Level 2 </para></para>        
				/// </summary>
				/// <java-name>
				/// setAttributeNS
				/// </java-name>
				[Dot42.DexImport("setAttributeNS", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1025)]
				void SetAttributeNS(string namespaceURI, string qualifiedName, string value) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Removes an attribute by local name and namespace URI. If a default value for the removed attribute is defined in the DTD, a new attribute immediately appears with the default value as well as the corresponding namespace URI, local name, and prefix when applicable. The implementation may handle default values from other schemas similarly but applications should use  <code>Document.normalizeDocument()</code> to guarantee this information is up-to-date.  <br></br>If no attribute with this local name and namespace URI is found, this method has no effect.  <br></br>Per [] , applications must use the value  <code>null</code> as the  <code>namespaceURI</code> parameter for methods if they wish to have no namespace.  <para>DOM Level 2 </para></para>        
				/// </summary>
				/// <java-name>
				/// removeAttributeNS
				/// </java-name>
				[Dot42.DexImport("removeAttributeNS", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1025)]
				void RemoveAttributeNS(string namespaceURI, string localName) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Retrieves an  <code>Attr</code> node by local name and namespace URI.  <br></br>Per [] , applications must use the value  <code>null</code> as the  <code>namespaceURI</code> parameter for methods if they wish to have no namespace.  <para>DOM Level 2 </para></para>        
				/// </summary>
				/// <returns>
				///  <para>The  <code>Attr</code> node with the specified attribute local name and namespace URI or  <code>null</code> if there is no such attribute. </para>
				/// </returns>
				/// <java-name>
				/// getAttributeNodeNS
				/// </java-name>
				[Dot42.DexImport("getAttributeNodeNS", "(Ljava/lang/String;Ljava/lang/String;)Lorg/w3c/dom/Attr;", AccessFlags = 1025)]
				global::Org.W3c.Dom.IAttr GetAttributeNodeNS(string namespaceURI, string localName) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Adds a new attribute. If an attribute with that local name and that namespace URI is already present in the element, it is replaced by the new one. Replacing an attribute node by itself has no effect.  <br></br>Per [] , applications must use the value  <code>null</code> as the  <code>namespaceURI</code> parameter for methods if they wish to have no namespace.  <para>DOM Level 2 </para></para>        
				/// </summary>
				/// <returns>
				///  <para>If the  <code>newAttr</code> attribute replaces an existing attribute with the same local name and namespace URI, the replaced  <code>Attr</code> node is returned, otherwise  <code>null</code> is returned. </para>
				/// </returns>
				/// <java-name>
				/// setAttributeNodeNS
				/// </java-name>
				[Dot42.DexImport("setAttributeNodeNS", "(Lorg/w3c/dom/Attr;)Lorg/w3c/dom/Attr;", AccessFlags = 1025)]
				global::Org.W3c.Dom.IAttr SetAttributeNodeNS(global::Org.W3c.Dom.IAttr newAttr) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns a  <code>NodeList</code> of all the descendant  <code>Elements</code> with a given local name and namespace URI in document order.  <para>DOM Level 2 </para></para>        
				/// </summary>
				/// <returns>
				///  <para>A new  <code>NodeList</code> object containing all the matched  <code>Elements</code>. </para>
				/// </returns>
				/// <java-name>
				/// getElementsByTagNameNS
				/// </java-name>
				[Dot42.DexImport("getElementsByTagNameNS", "(Ljava/lang/String;Ljava/lang/String;)Lorg/w3c/dom/NodeList;", AccessFlags = 1025)]
				global::Org.W3c.Dom.INodeList GetElementsByTagNameNS(string namespaceURI, string localName) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns  <code>true</code> when an attribute with a given name is specified on this element or has a default value,  <code>false</code> otherwise.  <para>DOM Level 2 </para></para>        
				/// </summary>
				/// <returns>
				///  <para> <code>true</code> if an attribute with the given name is specified on this element or has a default value,  <code>false</code> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// hasAttribute
				/// </java-name>
				[Dot42.DexImport("hasAttribute", "(Ljava/lang/String;)Z", AccessFlags = 1025)]
				bool HasAttribute(string name) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns  <code>true</code> when an attribute with a given local name and namespace URI is specified on this element or has a default value,  <code>false</code> otherwise.  <br></br>Per [] , applications must use the value  <code>null</code> as the  <code>namespaceURI</code> parameter for methods if they wish to have no namespace.  <para>DOM Level 2 </para></para>        
				/// </summary>
				/// <returns>
				///  <para> <code>true</code> if an attribute with the given local name and namespace URI is specified or has a default value on this element,  <code>false</code> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// hasAttributeNS
				/// </java-name>
				[Dot42.DexImport("hasAttributeNS", "(Ljava/lang/String;Ljava/lang/String;)Z", AccessFlags = 1025)]
				bool HasAttributeNS(string namespaceURI, string localName) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>If the parameter  <code>isId</code> is  <code>true</code>, this method declares the specified attribute to be a user-determined ID attribute . This affects the value of  <code>Attr.isId</code> and the behavior of  <code>Document.getElementById</code>, but does not change any schema that may be in use, in particular this does not affect the  <code>Attr.schemaTypeInfo</code> of the specified  <code>Attr</code> node. Use the value  <code>false</code> for the parameter  <code>isId</code> to undeclare an attribute for being a user-determined ID attribute.  <br></br> To specify an attribute by local name and namespace URI, use the  <code>setIdAttributeNS</code> method.  <para>DOM Level 3 </para></para>        
				/// </summary>
				/// <java-name>
				/// setIdAttribute
				/// </java-name>
				[Dot42.DexImport("setIdAttribute", "(Ljava/lang/String;Z)V", AccessFlags = 1025)]
				void SetIdAttribute(string name, bool isId) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>If the parameter  <code>isId</code> is  <code>true</code>, this method declares the specified attribute to be a user-determined ID attribute . This affects the value of  <code>Attr.isId</code> and the behavior of  <code>Document.getElementById</code>, but does not change any schema that may be in use, in particular this does not affect the  <code>Attr.schemaTypeInfo</code> of the specified  <code>Attr</code> node. Use the value  <code>false</code> for the parameter  <code>isId</code> to undeclare an attribute for being a user-determined ID attribute.  <para>DOM Level 3 </para></para>        
				/// </summary>
				/// <java-name>
				/// setIdAttributeNS
				/// </java-name>
				[Dot42.DexImport("setIdAttributeNS", "(Ljava/lang/String;Ljava/lang/String;Z)V", AccessFlags = 1025)]
				void SetIdAttributeNS(string namespaceURI, string localName, bool isId) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>If the parameter  <code>isId</code> is  <code>true</code>, this method declares the specified attribute to be a user-determined ID attribute . This affects the value of  <code>Attr.isId</code> and the behavior of  <code>Document.getElementById</code>, but does not change any schema that may be in use, in particular this does not affect the  <code>Attr.schemaTypeInfo</code> of the specified  <code>Attr</code> node. Use the value  <code>false</code> for the parameter  <code>isId</code> to undeclare an attribute for being a user-determined ID attribute.  <para>DOM Level 3 </para></para>        
				/// </summary>
				/// <java-name>
				/// setIdAttributeNode
				/// </java-name>
				[Dot42.DexImport("setIdAttributeNode", "(Lorg/w3c/dom/Attr;Z)V", AccessFlags = 1025)]
				void SetIdAttributeNode(global::Org.W3c.Dom.IAttr idAttr, bool isId) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>The name of the element. If  <code>Node.localName</code> is different from  <code>null</code>, this attribute is a qualified name. For example, in:  <pre> &lt;elementExample id="demo"&gt; ...
				/// &lt;/elementExample&gt; , </pre>  <code>tagName</code> has the value  <code>"elementExample"</code>. Note that this is case-preserving in XML, as are all of the operations of the DOM. The HTML DOM returns the  <code>tagName</code> of an HTML element in the canonical uppercase form, regardless of the case in the source HTML document. </para>        
				/// </summary>
				/// <java-name>
				/// getTagName
				/// </java-name>
				string TagName
				{
						[Dot42.DexImport("getTagName", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>The type information associated with this element.  <para>DOM Level 3 </para></para>        
				/// </summary>
				/// <java-name>
				/// getSchemaTypeInfo
				/// </java-name>
				global::Org.W3c.Dom.ITypeInfo SchemaTypeInfo
				{
						[Dot42.DexImport("getSchemaTypeInfo", "()Lorg/w3c/dom/TypeInfo;", AccessFlags = 1025)]
						get;
				}

		}

		/// <summary>
		///  <para>This interface represents a known entity, either parsed or unparsed, in an XML document. Note that this models the entity itself  <b>not</b> the entity declaration. </para> <para>The  <code>nodeName</code> attribute that is inherited from  <code>Node</code> contains the name of the entity. </para> <para>An XML processor may choose to completely expand entities before the structure model is passed to the DOM; in this case there will be no  <code>EntityReference</code> nodes in the document tree. </para> <para>XML does not mandate that a non-validating XML processor read and process entity declarations made in the external subset or declared in parameter entities. This means that parsed entities declared in the external subset need not be expanded by some classes of applications, and that the replacement text of the entity may not be available. When the  is available, the corresponding  <code>Entity</code> node's child list represents the structure of that replacement value. Otherwise, the child list is empty. </para> <para>DOM Level 3 does not support editing  <code>Entity</code> nodes; if a user wants to make changes to the contents of an  <code>Entity</code>, every related  <code>EntityReference</code> node has to be replaced in the structure model by a clone of the  <code>Entity</code>'s contents, and then the desired changes must be made to each of those clones instead.  <code>Entity</code> nodes and all their descendants are readonly. </para> <para>An  <code>Entity</code> node does not have any parent. </para> <para> <b>Note:</b> If the entity contains an unbound namespace prefix, the  <code>namespaceURI</code> of the corresponding node in the  <code>Entity</code> node subtree is  <code>null</code>. The same is true for  <code>EntityReference</code> nodes that refer to this entity, when they are created using the  <code>createEntityReference</code> method of the  <code>Document</code> interface. </para> <para>See also the . </para>    
		/// </summary>
		/// <java-name>
		/// org/w3c/dom/Entity
		/// </java-name>
		[Dot42.DexImport("org/w3c/dom/Entity", AccessFlags = 1537)]
		public partial interface IEntity : global::Org.W3c.Dom.INode
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>The public identifier associated with the entity if specified, and  <code>null</code> otherwise. </para>        
				/// </summary>
				/// <java-name>
				/// getPublicId
				/// </java-name>
				string PublicId
				{
						[Dot42.DexImport("getPublicId", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>The system identifier associated with the entity if specified, and  <code>null</code> otherwise. This may be an absolute URI or not. </para>        
				/// </summary>
				/// <java-name>
				/// getSystemId
				/// </java-name>
				string SystemId
				{
						[Dot42.DexImport("getSystemId", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>For unparsed entities, the name of the notation for the entity. For parsed entities, this is  <code>null</code>. </para>        
				/// </summary>
				/// <java-name>
				/// getNotationName
				/// </java-name>
				string NotationName
				{
						[Dot42.DexImport("getNotationName", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>An attribute specifying the encoding used for this entity at the time of parsing, when it is an external parsed entity. This is  <code>null</code> if it an entity from the internal subset or if it is not known.  <para>DOM Level 3 </para></para>        
				/// </summary>
				/// <java-name>
				/// getInputEncoding
				/// </java-name>
				string InputEncoding
				{
						[Dot42.DexImport("getInputEncoding", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>An attribute specifying, as part of the text declaration, the encoding of this entity, when it is an external parsed entity. This is  <code>null</code> otherwise.  <para>DOM Level 3 </para></para>        
				/// </summary>
				/// <java-name>
				/// getXmlEncoding
				/// </java-name>
				string XmlEncoding
				{
						[Dot42.DexImport("getXmlEncoding", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>An attribute specifying, as part of the text declaration, the version number of this entity, when it is an external parsed entity. This is  <code>null</code> otherwise.  <para>DOM Level 3 </para></para>        
				/// </summary>
				/// <java-name>
				/// getXmlVersion
				/// </java-name>
				string XmlVersion
				{
						[Dot42.DexImport("getXmlVersion", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

		}

		/// <summary>
		///  <para> <code>EntityReference</code> nodes may be used to represent an entity reference in the tree. Note that character references and references to predefined entities are considered to be expanded by the HTML or XML processor so that characters are represented by their Unicode equivalent rather than by an entity reference. Moreover, the XML processor may completely expand references to entities while building the  <code>Document</code>, instead of providing  <code>EntityReference</code> nodes. If it does provide such nodes, then for an  <code>EntityReference</code> node that represents a reference to a known entity an  <code>Entity</code> exists, and the subtree of the  <code>EntityReference</code> node is a copy of the  <code>Entity</code> node subtree. However, the latter may not be true when an entity contains an unbound namespace prefix. In such a case, because the namespace prefix resolution depends on where the entity reference is, the descendants of the  <code>EntityReference</code> node may be bound to different namespace URIs. When an  <code>EntityReference</code> node represents a reference to an unknown entity, the node has no children and its replacement value, when used by  <code>Attr.value</code> for example, is empty. </para> <para>As for  <code>Entity</code> nodes,  <code>EntityReference</code> nodes and all their descendants are readonly. </para> <para> <b>Note:</b>  <code>EntityReference</code> nodes may cause element content and attribute value normalization problems when, such as in XML 1.0 and XML Schema, the normalization is performed after entity reference are expanded. </para> <para>See also the . </para>    
		/// </summary>
		/// <java-name>
		/// org/w3c/dom/EntityReference
		/// </java-name>
		[Dot42.DexImport("org/w3c/dom/EntityReference", AccessFlags = 1537)]
		public partial interface IEntityReference : global::Org.W3c.Dom.INode
 /* scope: __dot42__ */ 
		{
		}

		/// <summary>
		///  <para>Objects implementing the  <code>NamedNodeMap</code> interface are used to represent collections of nodes that can be accessed by name. Note that  <code>NamedNodeMap</code> does not inherit from  <code>NodeList</code>;  <code>NamedNodeMaps</code> are not maintained in any particular order. Objects contained in an object implementing  <code>NamedNodeMap</code> may also be accessed by an ordinal index, but this is simply to allow convenient enumeration of the contents of a  <code>NamedNodeMap</code>, and does not imply that the DOM specifies an order to these Nodes. </para> <para> <code>NamedNodeMap</code> objects in the DOM are live. </para> <para>See also the . </para>    
		/// </summary>
		/// <java-name>
		/// org/w3c/dom/NamedNodeMap
		/// </java-name>
		[Dot42.DexImport("org/w3c/dom/NamedNodeMap", AccessFlags = 1537)]
		public partial interface INamedNodeMap
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Retrieves a node specified by name. </para>        
				/// </summary>
				/// <returns>
				///  <para>A  <code>Node</code> (of any type) with the specified  <code>nodeName</code>, or  <code>null</code> if it does not identify any node in this map. </para>
				/// </returns>
				/// <java-name>
				/// getNamedItem
				/// </java-name>
				[Dot42.DexImport("getNamedItem", "(Ljava/lang/String;)Lorg/w3c/dom/Node;", AccessFlags = 1025)]
				global::Org.W3c.Dom.INode GetNamedItem(string name) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Adds a node using its  <code>nodeName</code> attribute. If a node with that name is already present in this map, it is replaced by the new one. Replacing a node by itself has no effect.  <br></br>As the  <code>nodeName</code> attribute is used to derive the name which the node must be stored under, multiple nodes of certain types (those that have a "special" string value) cannot be stored as the names would clash. This is seen as preferable to allowing nodes to be aliased. </para>        
				/// </summary>
				/// <returns>
				///  <para>If the new  <code>Node</code> replaces an existing node the replaced  <code>Node</code> is returned, otherwise  <code>null</code> is returned. </para>
				/// </returns>
				/// <java-name>
				/// setNamedItem
				/// </java-name>
				[Dot42.DexImport("setNamedItem", "(Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;", AccessFlags = 1025)]
				global::Org.W3c.Dom.INode SetNamedItem(global::Org.W3c.Dom.INode arg) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Removes a node specified by name. When this map contains the attributes attached to an element, if the removed attribute is known to have a default value, an attribute immediately appears containing the default value as well as the corresponding namespace URI, local name, and prefix when applicable. </para>        
				/// </summary>
				/// <returns>
				///  <para>The node removed from this map if a node with such a name exists. </para>
				/// </returns>
				/// <java-name>
				/// removeNamedItem
				/// </java-name>
				[Dot42.DexImport("removeNamedItem", "(Ljava/lang/String;)Lorg/w3c/dom/Node;", AccessFlags = 1025)]
				global::Org.W3c.Dom.INode RemoveNamedItem(string name) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns the  <code>index</code>th item in the map. If  <code>index</code> is greater than or equal to the number of nodes in this map, this returns  <code>null</code>. </para>        
				/// </summary>
				/// <returns>
				///  <para>The node at the  <code>index</code>th position in the map, or  <code>null</code> if that is not a valid index. </para>
				/// </returns>
				/// <java-name>
				/// item
				/// </java-name>
				[Dot42.DexImport("item", "(I)Lorg/w3c/dom/Node;", AccessFlags = 1025)]
				global::Org.W3c.Dom.INode Item(int index) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Retrieves a node specified by local name and namespace URI.  <br></br>Per [] , applications must use the value null as the namespaceURI parameter for methods if they wish to have no namespace.  <para>DOM Level 2 </para></para>        
				/// </summary>
				/// <returns>
				///  <para>A  <code>Node</code> (of any type) with the specified local name and namespace URI, or  <code>null</code> if they do not identify any node in this map. </para>
				/// </returns>
				/// <java-name>
				/// getNamedItemNS
				/// </java-name>
				[Dot42.DexImport("getNamedItemNS", "(Ljava/lang/String;Ljava/lang/String;)Lorg/w3c/dom/Node;", AccessFlags = 1025)]
				global::Org.W3c.Dom.INode GetNamedItemNS(string namespaceURI, string localName) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Adds a node using its  <code>namespaceURI</code> and  <code>localName</code>. If a node with that namespace URI and that local name is already present in this map, it is replaced by the new one. Replacing a node by itself has no effect.  <br></br>Per [] , applications must use the value null as the namespaceURI parameter for methods if they wish to have no namespace.  <para>DOM Level 2 </para></para>        
				/// </summary>
				/// <returns>
				///  <para>If the new  <code>Node</code> replaces an existing node the replaced  <code>Node</code> is returned, otherwise  <code>null</code> is returned. </para>
				/// </returns>
				/// <java-name>
				/// setNamedItemNS
				/// </java-name>
				[Dot42.DexImport("setNamedItemNS", "(Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;", AccessFlags = 1025)]
				global::Org.W3c.Dom.INode SetNamedItemNS(global::Org.W3c.Dom.INode arg) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Removes a node specified by local name and namespace URI. A removed attribute may be known to have a default value when this map contains the attributes attached to an element, as returned by the attributes attribute of the  <code>Node</code> interface. If so, an attribute immediately appears containing the default value as well as the corresponding namespace URI, local name, and prefix when applicable.  <br></br>Per [] , applications must use the value null as the namespaceURI parameter for methods if they wish to have no namespace.  <para>DOM Level 2 </para></para>        
				/// </summary>
				/// <returns>
				///  <para>The node removed from this map if a node with such a local name and namespace URI exists. </para>
				/// </returns>
				/// <java-name>
				/// removeNamedItemNS
				/// </java-name>
				[Dot42.DexImport("removeNamedItemNS", "(Ljava/lang/String;Ljava/lang/String;)Lorg/w3c/dom/Node;", AccessFlags = 1025)]
				global::Org.W3c.Dom.INode RemoveNamedItemNS(string namespaceURI, string localName) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>The number of nodes in this map. The range of valid child node indices is  <code>0</code> to  <code>length-1</code> inclusive. </para>        
				/// </summary>
				/// <java-name>
				/// getLength
				/// </java-name>
				int Length
				{
						[Dot42.DexImport("getLength", "()I", AccessFlags = 1025)]
						get;
				}

		}

		/// <summary>
		///  <para>The  <code>NameList</code> interface provides the abstraction of an ordered collection of parallel pairs of name and namespace values (which could be null values), without defining or constraining how this collection is implemented. The items in the  <code>NameList</code> are accessible via an integral index, starting from 0. </para> <para>See also the .  <para>DOM Level 3 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/w3c/dom/NameList
		/// </java-name>
		[Dot42.DexImport("org/w3c/dom/NameList", AccessFlags = 1537)]
		public partial interface INameList
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Returns the  <code>index</code>th name item in the collection. </para>        
				/// </summary>
				/// <returns>
				///  <para>The name at the  <code>index</code>th position in the  <code>NameList</code>, or  <code>null</code> if there is no name for the specified index or if the index is out of range. </para>
				/// </returns>
				/// <java-name>
				/// getName
				/// </java-name>
				[Dot42.DexImport("getName", "(I)Ljava/lang/String;", AccessFlags = 1025)]
				string GetName(int index) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns the  <code>index</code>th namespaceURI item in the collection. </para>        
				/// </summary>
				/// <returns>
				///  <para>The namespace URI at the  <code>index</code>th position in the  <code>NameList</code>, or  <code>null</code> if there is no name for the specified index or if the index is out of range. </para>
				/// </returns>
				/// <java-name>
				/// getNamespaceURI
				/// </java-name>
				[Dot42.DexImport("getNamespaceURI", "(I)Ljava/lang/String;", AccessFlags = 1025)]
				string GetNamespaceURI(int index) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Test if a name is part of this  <code>NameList</code>. </para>        
				/// </summary>
				/// <returns>
				///  <para> <code>true</code> if the name has been found,  <code>false</code> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// contains
				/// </java-name>
				[Dot42.DexImport("contains", "(Ljava/lang/String;)Z", AccessFlags = 1025)]
				bool Contains(string str) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Test if the pair namespaceURI/name is part of this  <code>NameList</code>. </para>        
				/// </summary>
				/// <returns>
				///  <para> <code>true</code> if the pair namespaceURI/name has been found,  <code>false</code> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// containsNS
				/// </java-name>
				[Dot42.DexImport("containsNS", "(Ljava/lang/String;Ljava/lang/String;)Z", AccessFlags = 1025)]
				bool ContainsNS(string namespaceURI, string name) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>The number of pairs (name and namespaceURI) in the list. The range of valid child node indices is 0 to  <code>length-1</code> inclusive. </para>        
				/// </summary>
				/// <java-name>
				/// getLength
				/// </java-name>
				int Length
				{
						[Dot42.DexImport("getLength", "()I", AccessFlags = 1025)]
						get;
				}

		}

		/// <summary>
		///  <para>The  <code>Node</code> interface is the primary datatype for the entire Document Object Model. It represents a single node in the document tree. While all objects implementing the  <code>Node</code> interface expose methods for dealing with children, not all objects implementing the  <code>Node</code> interface may have children. For example,  <code>Text</code> nodes may not have children, and adding children to such nodes results in a  <code>DOMException</code> being raised. </para> <para>The attributes  <code>nodeName</code>,  <code>nodeValue</code> and  <code>attributes</code> are included as a mechanism to get at node information without casting down to the specific derived interface. In cases where there is no obvious mapping of these attributes for a specific  <code>nodeType</code> (e.g.,  <code>nodeValue</code> for an  <code>Element</code> or  <code>attributes</code> for a  <code>Comment</code> ), this returns  <code>null</code>. Note that the specialized interfaces may contain additional and more convenient mechanisms to get and set the relevant information. </para> <para>The values of  <code>nodeName</code>,  <code>nodeValue</code>, and  <code>attributes</code> vary according to the node type as follows:  <table> <row> <entry> <para>Interface </para></entry> <entry> <para>nodeName </para></entry> <entry> <para>nodeValue </para></entry> <entry> <para>attributes  </para></entry></row> <row> <entry> <para> <code>Attr</code> </para></entry> <entry> <para>same as  <code>Attr.name</code> </para></entry> <entry> <para>same as  <code>Attr.value</code> </para></entry> <entry> <para> <code>null</code>  </para></entry></row> <row> <entry> <para> <code>CDATASection</code> </para></entry> <entry> <para> <code>"#cdata-section"</code> </para></entry> <entry> <para>same as  <code>CharacterData.data</code>, the content of the CDATA Section </para></entry> <entry> <para> <code>null</code>  </para></entry></row> <row> <entry> <para> <code>Comment</code> </para></entry> <entry> <para> <code>"#comment"</code> </para></entry> <entry> <para>same as  <code>CharacterData.data</code>, the content of the comment </para></entry> <entry> <para> <code>null</code>  </para></entry></row> <row> <entry> <para> <code>Document</code> </para></entry> <entry> <para> <code>"#document"</code> </para></entry> <entry> <para> <code>null</code> </para></entry> <entry> <para> <code>null</code>  </para></entry></row> <row> <entry> <para> <code>DocumentFragment</code> </para></entry> <entry> <para> <code>"#document-fragment"</code> </para></entry> <entry> <para> <code>null</code> </para></entry> <entry> <para> <code>null</code>  </para></entry></row> <row> <entry> <para> <code>DocumentType</code> </para></entry> <entry> <para>same as  <code>DocumentType.name</code> </para></entry> <entry> <para> <code>null</code> </para></entry> <entry> <para> <code>null</code>  </para></entry></row> <row> <entry> <para> <code>Element</code> </para></entry> <entry> <para>same as  <code>Element.tagName</code> </para></entry> <entry> <para> <code>null</code> </para></entry> <entry> <para> <code>NamedNodeMap</code>  </para></entry></row> <row> <entry> <para> <code>Entity</code> </para></entry> <entry> <para>entity name </para></entry> <entry> <para> <code>null</code> </para></entry> <entry> <para> <code>null</code>  </para></entry></row> <row> <entry> <para> <code>EntityReference</code> </para></entry> <entry> <para>name of entity referenced </para></entry> <entry> <para> <code>null</code> </para></entry> <entry> <para> <code>null</code>  </para></entry></row> <row> <entry> <para> <code>Notation</code> </para></entry> <entry> <para>notation name </para></entry> <entry> <para> <code>null</code> </para></entry> <entry> <para> <code>null</code>  </para></entry></row> <row> <entry> <para> <code>ProcessingInstruction</code> </para></entry> <entry> <para>same as  <code>ProcessingInstruction.target</code> </para></entry> <entry> <para>same as  <code>ProcessingInstruction.data</code> </para></entry> <entry> <para> <code>null</code>  </para></entry></row> <row> <entry> <para> <code>Text</code> </para></entry> <entry> <para> <code>"#text"</code> </para></entry> <entry> <para>same as  <code>CharacterData.data</code>, the content of the text node </para></entry> <entry> <para> <code>null</code>  </para></entry></row></table></para> <para>See also the . </para>    
		/// </summary>
		/// <java-name>
		/// org/w3c/dom/Node
		/// </java-name>
		[Dot42.DexImport("org/w3c/dom/Node", AccessFlags = 1537)]
		public partial interface INode
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Inserts the node  <code>newChild</code> before the existing child node  <code>refChild</code>. If  <code>refChild</code> is  <code>null</code>, insert  <code>newChild</code> at the end of the list of children.  <br></br>If  <code>newChild</code> is a  <code>DocumentFragment</code> object, all of its children are inserted, in the same order, before  <code>refChild</code>. If the  <code>newChild</code> is already in the tree, it is first removed. </para> <para> <b>Note:</b> Inserting a node before itself is implementation dependent.  <para>DOM Level 3 </para></para>        
				/// </summary>
				/// <returns>
				///  <para>The node being inserted. </para>
				/// </returns>
				/// <java-name>
				/// insertBefore
				/// </java-name>
				[Dot42.DexImport("insertBefore", "(Lorg/w3c/dom/Node;Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;", AccessFlags = 1025)]
				global::Org.W3c.Dom.INode InsertBefore(global::Org.W3c.Dom.INode newChild, global::Org.W3c.Dom.INode refChild) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Replaces the child node  <code>oldChild</code> with  <code>newChild</code> in the list of children, and returns the  <code>oldChild</code> node.  <br></br>If  <code>newChild</code> is a  <code>DocumentFragment</code> object,  <code>oldChild</code> is replaced by all of the  <code>DocumentFragment</code> children, which are inserted in the same order. If the  <code>newChild</code> is already in the tree, it is first removed. </para> <para> <b>Note:</b> Replacing a node with itself is implementation dependent.  <para>DOM Level 3 </para></para>        
				/// </summary>
				/// <returns>
				///  <para>The node replaced. </para>
				/// </returns>
				/// <java-name>
				/// replaceChild
				/// </java-name>
				[Dot42.DexImport("replaceChild", "(Lorg/w3c/dom/Node;Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;", AccessFlags = 1025)]
				global::Org.W3c.Dom.INode ReplaceChild(global::Org.W3c.Dom.INode newChild, global::Org.W3c.Dom.INode oldChild) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Removes the child node indicated by  <code>oldChild</code> from the list of children, and returns it.  <para>DOM Level 3 </para></para>        
				/// </summary>
				/// <returns>
				///  <para>The node removed. </para>
				/// </returns>
				/// <java-name>
				/// removeChild
				/// </java-name>
				[Dot42.DexImport("removeChild", "(Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;", AccessFlags = 1025)]
				global::Org.W3c.Dom.INode RemoveChild(global::Org.W3c.Dom.INode oldChild) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Adds the node  <code>newChild</code> to the end of the list of children of this node. If the  <code>newChild</code> is already in the tree, it is first removed.  <para>DOM Level 3 </para></para>        
				/// </summary>
				/// <returns>
				///  <para>The node added. </para>
				/// </returns>
				/// <java-name>
				/// appendChild
				/// </java-name>
				[Dot42.DexImport("appendChild", "(Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;", AccessFlags = 1025)]
				global::Org.W3c.Dom.INode AppendChild(global::Org.W3c.Dom.INode newChild) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns a duplicate of this node, i.e., serves as a generic copy constructor for nodes. The duplicate node has no parent (  <code>parentNode</code> is  <code>null</code>) and no user data. User data associated to the imported node is not carried over. However, if any  <code>UserDataHandlers</code> has been specified along with the associated data these handlers will be called with the appropriate parameters before this method returns.  <br></br>Cloning an  <code>Element</code> copies all attributes and their values, including those generated by the XML processor to represent defaulted attributes, but this method does not copy any children it contains unless it is a deep clone. This includes text contained in an the  <code>Element</code> since the text is contained in a child  <code>Text</code> node. Cloning an  <code>Attr</code> directly, as opposed to be cloned as part of an  <code>Element</code> cloning operation, returns a specified attribute ( <code>specified</code> is  <code>true</code>). Cloning an  <code>Attr</code> always clones its children, since they represent its value, no matter whether this is a deep clone or not. Cloning an  <code>EntityReference</code> automatically constructs its subtree if a corresponding  <code>Entity</code> is available, no matter whether this is a deep clone or not. Cloning any other type of node simply returns a copy of this node.  <br></br>Note that cloning an immutable subtree results in a mutable copy, but the children of an  <code>EntityReference</code> clone are readonly . In addition, clones of unspecified  <code>Attr</code> nodes are specified. And, cloning  <code>Document</code>,  <code>DocumentType</code>,  <code>Entity</code>, and  <code>Notation</code> nodes is implementation dependent. </para>        
				/// </summary>
				/// <returns>
				///  <para>The duplicate node. </para>
				/// </returns>
				/// <java-name>
				/// cloneNode
				/// </java-name>
				[Dot42.DexImport("cloneNode", "(Z)Lorg/w3c/dom/Node;", AccessFlags = 1025)]
				global::Org.W3c.Dom.INode CloneNode(bool deep) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Puts all  <code>Text</code> nodes in the full depth of the sub-tree underneath this  <code>Node</code>, including attribute nodes, into a "normal" form where only structure (e.g., elements, comments, processing instructions, CDATA sections, and entity references) separates  <code>Text</code> nodes, i.e., there are neither adjacent  <code>Text</code> nodes nor empty  <code>Text</code> nodes. This can be used to ensure that the DOM view of a document is the same as if it were saved and re-loaded, and is useful when operations (such as XPointer [] lookups) that depend on a particular document tree structure are to be used. If the parameter "normalize-characters" of the  <code>DOMConfiguration</code> object attached to the  <code>Node.ownerDocument</code> is  <code>true</code>, this method will also fully normalize the characters of the  <code>Text</code> nodes. </para> <para> <b>Note:</b> In cases where the document contains  <code>CDATASections</code>, the normalize operation alone may not be sufficient, since XPointers do not differentiate between  <code>Text</code> nodes and  <code>CDATASection</code> nodes.  <para>DOM Level 3 </para></para>        
				/// </summary>
				/// <java-name>
				/// normalize
				/// </java-name>
				[Dot42.DexImport("normalize", "()V", AccessFlags = 1025)]
				void Normalize() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Tests whether the DOM implementation implements a specific feature and that feature is supported by this node, as specified in .  <para>DOM Level 2 </para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns  <code>true</code> if the specified feature is supported on this node,  <code>false</code> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isSupported
				/// </java-name>
				[Dot42.DexImport("isSupported", "(Ljava/lang/String;Ljava/lang/String;)Z", AccessFlags = 1025)]
				bool IsSupported(string feature, string version) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Compares the reference node, i.e. the node on which this method is being called, with a node, i.e. the one passed as a parameter, with regard to their position in the document and according to the document order.  <para>DOM Level 3 </para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns how the node is positioned relatively to the reference node. </para>
				/// </returns>
				/// <java-name>
				/// compareDocumentPosition
				/// </java-name>
				[Dot42.DexImport("compareDocumentPosition", "(Lorg/w3c/dom/Node;)S", AccessFlags = 1025)]
				short CompareDocumentPosition(global::Org.W3c.Dom.INode other) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns whether this node is the same node as the given one.  <br></br>This method provides a way to determine whether two  <code>Node</code> references returned by the implementation reference the same object. When two  <code>Node</code> references are references to the same object, even if through a proxy, the references may be used completely interchangeably, such that all attributes have the same values and calling the same DOM method on either reference always has exactly the same effect.  <para>DOM Level 3 </para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns  <code>true</code> if the nodes are the same,  <code>false</code> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isSameNode
				/// </java-name>
				[Dot42.DexImport("isSameNode", "(Lorg/w3c/dom/Node;)Z", AccessFlags = 1025)]
				bool IsSameNode(global::Org.W3c.Dom.INode other) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Look up the prefix associated to the given namespace URI, starting from this node. The default namespace declarations are ignored by this method.  <br></br>See for details on the algorithm used by this method.  <para>DOM Level 3 </para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns an associated namespace prefix if found or  <code>null</code> if none is found. If more than one prefix are associated to the namespace prefix, the returned namespace prefix is implementation dependent. </para>
				/// </returns>
				/// <java-name>
				/// lookupPrefix
				/// </java-name>
				[Dot42.DexImport("lookupPrefix", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1025)]
				string LookupPrefix(string namespaceURI) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>This method checks if the specified  <code>namespaceURI</code> is the default namespace or not.  <para>DOM Level 3 </para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns  <code>true</code> if the specified  <code>namespaceURI</code> is the default namespace,  <code>false</code> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isDefaultNamespace
				/// </java-name>
				[Dot42.DexImport("isDefaultNamespace", "(Ljava/lang/String;)Z", AccessFlags = 1025)]
				bool IsDefaultNamespace(string namespaceURI) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Look up the namespace URI associated to the given prefix, starting from this node.  <br></br>See for details on the algorithm used by this method.  <para>DOM Level 3 </para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns the associated namespace URI or  <code>null</code> if none is found. </para>
				/// </returns>
				/// <java-name>
				/// lookupNamespaceURI
				/// </java-name>
				[Dot42.DexImport("lookupNamespaceURI", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1025)]
				string LookupNamespaceURI(string prefix) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Tests whether two nodes are equal.  <br></br>This method tests for equality of nodes, not sameness (i.e., whether the two nodes are references to the same object) which can be tested with  <code>Node.isSameNode()</code>. All nodes that are the same will also be equal, though the reverse may not be true.  <br></br>Two nodes are equal if and only if the following conditions are satisfied:  <ul> <li> <para>The two nodes are of the same type.  </para></li> <li> <para>The following string attributes are equal:  <code>nodeName</code>,  <code>localName</code>,  <code>namespaceURI</code>,  <code>prefix</code>,  <code>nodeValue</code> . This is: they are both  <code>null</code>, or they have the same length and are character for character identical.  </para></li> <li> <para>The  <code>attributes</code>  <code>NamedNodeMaps</code> are equal. This is: they are both  <code>null</code>, or they have the same length and for each node that exists in one map there is a node that exists in the other map and is equal, although not necessarily at the same index.  </para></li> <li> <para>The  <code>childNodes</code>  <code>NodeLists</code> are equal. This is: they are both  <code>null</code>, or they have the same length and contain equal nodes at the same index. Note that normalization can affect equality; to avoid this, nodes should be normalized before being compared.  </para></li></ul> <br></br>For two  <code>DocumentType</code> nodes to be equal, the following conditions must also be satisfied:  <ul> <li> <para>The following string attributes are equal:  <code>publicId</code>,  <code>systemId</code>,  <code>internalSubset</code>.  </para></li> <li> <para>The  <code>entities</code>  <code>NamedNodeMaps</code> are equal.  </para></li> <li> <para>The  <code>notations</code>  <code>NamedNodeMaps</code> are equal.  </para></li></ul> <br></br>On the other hand, the following do not affect equality: the  <code>ownerDocument</code>,  <code>baseURI</code>, and  <code>parentNode</code> attributes, the  <code>specified</code> attribute for  <code>Attr</code> nodes, the  <code>schemaTypeInfo</code> attribute for  <code>Attr</code> and  <code>Element</code> nodes, the  <code>Text.isElementContentWhitespace</code> attribute for  <code>Text</code> nodes, as well as any user data or event listeners registered on the nodes. </para> <para> <b>Note:</b> As a general rule, anything not mentioned in the description above is not significant in consideration of equality checking. Note that future versions of this specification may take into account more attributes and implementations conform to this specification are expected to be updated accordingly.  <para>DOM Level 3 </para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns  <code>true</code> if the nodes are equal,  <code>false</code> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isEqualNode
				/// </java-name>
				[Dot42.DexImport("isEqualNode", "(Lorg/w3c/dom/Node;)Z", AccessFlags = 1025)]
				bool IsEqualNode(global::Org.W3c.Dom.INode arg) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>This method returns a specialized object which implements the specialized APIs of the specified feature and version, as specified in . The specialized object may also be obtained by using binding-specific casting methods but is not necessarily expected to, as discussed in . This method also allow the implementation to provide specialized objects which do not support the  <code>Node</code> interface.  <para>DOM Level 3 </para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns an object which implements the specialized APIs of the specified feature and version, if any, or  <code>null</code> if there is no object which implements interfaces associated with that feature. If the  <code>DOMObject</code> returned by this method implements the  <code>Node</code> interface, it must delegate to the primary core  <code>Node</code> and not return results inconsistent with the primary core  <code>Node</code> such as attributes, childNodes, etc. </para>
				/// </returns>
				/// <java-name>
				/// getFeature
				/// </java-name>
				[Dot42.DexImport("getFeature", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/Object;", AccessFlags = 1025)]
				object GetFeature(string feature, string version) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Associate an object to a key on this node. The object can later be retrieved from this node by calling  <code>getUserData</code> with the same key.  <para>DOM Level 3 </para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns the  <code>DOMUserData</code> previously associated to the given key on this node, or  <code>null</code> if there was none. </para>
				/// </returns>
				/// <java-name>
				/// setUserData
				/// </java-name>
				[Dot42.DexImport("setUserData", "(Ljava/lang/String;Ljava/lang/Object;Lorg/w3c/dom/UserDataHandler;)Ljava/lang/Obj" +
    "ect;", AccessFlags = 1025)]
				object SetUserData(string key, object data, global::Org.W3c.Dom.IUserDataHandler handler) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Retrieves the object associated to a key on a this node. The object must first have been set to this node by calling  <code>setUserData</code> with the same key.  <para>DOM Level 3 </para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns the  <code>DOMUserData</code> associated to the given key on this node, or  <code>null</code> if there was none. </para>
				/// </returns>
				/// <java-name>
				/// getUserData
				/// </java-name>
				[Dot42.DexImport("getUserData", "(Ljava/lang/String;)Ljava/lang/Object;", AccessFlags = 1025)]
				object GetUserData(string key) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>The name of this node, depending on its type; see the table above. </para>        
				/// </summary>
				/// <java-name>
				/// getNodeName
				/// </java-name>
				string NodeName
				{
						[Dot42.DexImport("getNodeName", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>The value of this node, depending on its type; see the table above. When it is defined to be  <code>null</code>, setting it has no effect, including if the node is read-only. </para>        
				/// </summary>
				/// <java-name>
				/// getNodeValue
				/// </java-name>
				string NodeValue
				{
						[Dot42.DexImport("getNodeValue", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
						[Dot42.DexImport("setNodeValue", "(Ljava/lang/String;)V", AccessFlags = 1025)]
						set;
				}

				/// <summary>
				///  <para>A code representing the type of the underlying object, as defined above. </para>        
				/// </summary>
				/// <java-name>
				/// getNodeType
				/// </java-name>
				short NodeType
				{
						[Dot42.DexImport("getNodeType", "()S", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>The parent of this node. All nodes, except  <code>Attr</code>,  <code>Document</code>,  <code>DocumentFragment</code>,  <code>Entity</code>, and  <code>Notation</code> may have a parent. However, if a node has just been created and not yet added to the tree, or if it has been removed from the tree, this is  <code>null</code>. </para>        
				/// </summary>
				/// <java-name>
				/// getParentNode
				/// </java-name>
				global::Org.W3c.Dom.INode ParentNode
				{
						[Dot42.DexImport("getParentNode", "()Lorg/w3c/dom/Node;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>A  <code>NodeList</code> that contains all children of this node. If there are no children, this is a  <code>NodeList</code> containing no nodes. </para>        
				/// </summary>
				/// <java-name>
				/// getChildNodes
				/// </java-name>
				global::Org.W3c.Dom.INodeList ChildNodes
				{
						[Dot42.DexImport("getChildNodes", "()Lorg/w3c/dom/NodeList;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>The first child of this node. If there is no such node, this returns  <code>null</code>. </para>        
				/// </summary>
				/// <java-name>
				/// getFirstChild
				/// </java-name>
				global::Org.W3c.Dom.INode FirstChild
				{
						[Dot42.DexImport("getFirstChild", "()Lorg/w3c/dom/Node;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>The last child of this node. If there is no such node, this returns  <code>null</code>. </para>        
				/// </summary>
				/// <java-name>
				/// getLastChild
				/// </java-name>
				global::Org.W3c.Dom.INode LastChild
				{
						[Dot42.DexImport("getLastChild", "()Lorg/w3c/dom/Node;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>The node immediately preceding this node. If there is no such node, this returns  <code>null</code>. </para>        
				/// </summary>
				/// <java-name>
				/// getPreviousSibling
				/// </java-name>
				global::Org.W3c.Dom.INode PreviousSibling
				{
						[Dot42.DexImport("getPreviousSibling", "()Lorg/w3c/dom/Node;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>The node immediately following this node. If there is no such node, this returns  <code>null</code>. </para>        
				/// </summary>
				/// <java-name>
				/// getNextSibling
				/// </java-name>
				global::Org.W3c.Dom.INode NextSibling
				{
						[Dot42.DexImport("getNextSibling", "()Lorg/w3c/dom/Node;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>A  <code>NamedNodeMap</code> containing the attributes of this node (if it is an  <code>Element</code>) or  <code>null</code> otherwise. </para>        
				/// </summary>
				/// <java-name>
				/// getAttributes
				/// </java-name>
				global::Org.W3c.Dom.INamedNodeMap Attributes
				{
						[Dot42.DexImport("getAttributes", "()Lorg/w3c/dom/NamedNodeMap;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>The  <code>Document</code> object associated with this node. This is also the  <code>Document</code> object used to create new nodes. When this node is a  <code>Document</code> or a  <code>DocumentType</code> which is not used with any  <code>Document</code> yet, this is  <code>null</code>.  <para>DOM Level 2 </para></para>        
				/// </summary>
				/// <java-name>
				/// getOwnerDocument
				/// </java-name>
				global::Org.W3c.Dom.IDocument OwnerDocument
				{
						[Dot42.DexImport("getOwnerDocument", "()Lorg/w3c/dom/Document;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Returns whether this node has any children. </para>        
				/// </summary>
				/// <returns>
				///  <para>Returns  <code>true</code> if this node has any children,  <code>false</code> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// hasChildNodes
				/// </java-name>
				bool HasChildNodes
				{
						[Dot42.DexImport("hasChildNodes", "()Z", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>The namespace URI of this node, or  <code>null</code> if it is unspecified (see ).  <br></br>This is not a computed value that is the result of a namespace lookup based on an examination of the namespace declarations in scope. It is merely the namespace URI given at creation time.  <br></br>For nodes of any type other than  <code>ELEMENT_NODE</code> and  <code>ATTRIBUTE_NODE</code> and nodes created with a DOM Level 1 method, such as  <code>Document.createElement()</code>, this is always  <code>null</code>. </para> <para> <b>Note:</b> Per the  <b>Namespaces in XML</b> Specification [] an attribute does not inherit its namespace from the element it is attached to. If an attribute is not explicitly given a namespace, it simply has no namespace.  <para>DOM Level 2 </para></para>        
				/// </summary>
				/// <java-name>
				/// getNamespaceURI
				/// </java-name>
				string NamespaceURI
				{
						[Dot42.DexImport("getNamespaceURI", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>The namespace prefix of this node, or  <code>null</code> if it is unspecified. When it is defined to be  <code>null</code>, setting it has no effect, including if the node is read-only.  <br></br>Note that setting this attribute, when permitted, changes the  <code>nodeName</code> attribute, which holds the qualified name, as well as the  <code>tagName</code> and  <code>name</code> attributes of the  <code>Element</code> and  <code>Attr</code> interfaces, when applicable.  <br></br>Setting the prefix to  <code>null</code> makes it unspecified, setting it to an empty string is implementation dependent.  <br></br>Note also that changing the prefix of an attribute that is known to have a default value, does not make a new attribute with the default value and the original prefix appear, since the  <code>namespaceURI</code> and  <code>localName</code> do not change.  <br></br>For nodes of any type other than  <code>ELEMENT_NODE</code> and  <code>ATTRIBUTE_NODE</code> and nodes created with a DOM Level 1 method, such as  <code>createElement</code> from the  <code>Document</code> interface, this is always  <code>null</code>.  <para>DOM Level 2 </para></para>        
				/// </summary>
				/// <java-name>
				/// getPrefix
				/// </java-name>
				string Prefix
				{
						[Dot42.DexImport("getPrefix", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
						[Dot42.DexImport("setPrefix", "(Ljava/lang/String;)V", AccessFlags = 1025)]
						set;
				}

				/// <summary>
				///  <para>Returns the local part of the qualified name of this node.  <br></br>For nodes of any type other than  <code>ELEMENT_NODE</code> and  <code>ATTRIBUTE_NODE</code> and nodes created with a DOM Level 1 method, such as  <code>Document.createElement()</code>, this is always  <code>null</code>.  <para>DOM Level 2 </para></para>        
				/// </summary>
				/// <java-name>
				/// getLocalName
				/// </java-name>
				string LocalName
				{
						[Dot42.DexImport("getLocalName", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Returns whether this node (if it is an element) has any attributes.  <para>DOM Level 2 </para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns  <code>true</code> if this node has any attributes,  <code>false</code> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// hasAttributes
				/// </java-name>
				bool HasAttributes
				{
						[Dot42.DexImport("hasAttributes", "()Z", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>The absolute base URI of this node or  <code>null</code> if the implementation wasn't able to obtain an absolute URI. This value is computed as described in . However, when the  <code>Document</code> supports the feature "HTML" [] , the base URI is computed using first the value of the href attribute of the HTML BASE element if any, and the value of the  <code>documentURI</code> attribute from the  <code>Document</code> interface otherwise.  <para>DOM Level 3 </para></para>        
				/// </summary>
				/// <java-name>
				/// getBaseURI
				/// </java-name>
				string BaseURI
				{
						[Dot42.DexImport("getBaseURI", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>This attribute returns the text content of this node and its descendants. When it is defined to be  <code>null</code>, setting it has no effect. On setting, any possible children this node may have are removed and, if it the new string is not empty or  <code>null</code>, replaced by a single  <code>Text</code> node containing the string this attribute is set to.  <br></br> On getting, no serialization is performed, the returned string does not contain any markup. No whitespace normalization is performed and the returned string does not contain the white spaces in element content (see the attribute  <code>Text.isElementContentWhitespace</code>). Similarly, on setting, no parsing is performed either, the input string is taken as pure textual content.  <br></br>The string returned is made of the text content of this node depending on its type, as defined below:  <table> <row> <entry> <para>Node type </para></entry> <entry> <para>Content  </para></entry></row> <row> <entry> <para>ELEMENT_NODE, ATTRIBUTE_NODE, ENTITY_NODE, ENTITY_REFERENCE_NODE, DOCUMENT_FRAGMENT_NODE </para></entry> <entry> <para>concatenation of the  <code>textContent</code> attribute value of every child node, excluding COMMENT_NODE and PROCESSING_INSTRUCTION_NODE nodes. This is the empty string if the node has no children.  </para></entry></row> <row> <entry> <para>TEXT_NODE, CDATA_SECTION_NODE, COMMENT_NODE, PROCESSING_INSTRUCTION_NODE </para></entry> <entry> <para> <code>nodeValue</code>  </para></entry></row> <row> <entry> <para>DOCUMENT_NODE, DOCUMENT_TYPE_NODE, NOTATION_NODE </para></entry> <entry> <para> <b>null</b>  </para></entry></row></table> <para>DOM Level 3 </para></para>        
				/// </summary>
				/// <java-name>
				/// getTextContent
				/// </java-name>
				string TextContent
				{
						[Dot42.DexImport("getTextContent", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
						[Dot42.DexImport("setTextContent", "(Ljava/lang/String;)V", AccessFlags = 1025)]
						set;
				}

		}

		/// <summary>
		///  <para>The  <code>Node</code> interface is the primary datatype for the entire Document Object Model. It represents a single node in the document tree. While all objects implementing the  <code>Node</code> interface expose methods for dealing with children, not all objects implementing the  <code>Node</code> interface may have children. For example,  <code>Text</code> nodes may not have children, and adding children to such nodes results in a  <code>DOMException</code> being raised. </para> <para>The attributes  <code>nodeName</code>,  <code>nodeValue</code> and  <code>attributes</code> are included as a mechanism to get at node information without casting down to the specific derived interface. In cases where there is no obvious mapping of these attributes for a specific  <code>nodeType</code> (e.g.,  <code>nodeValue</code> for an  <code>Element</code> or  <code>attributes</code> for a  <code>Comment</code> ), this returns  <code>null</code>. Note that the specialized interfaces may contain additional and more convenient mechanisms to get and set the relevant information. </para> <para>The values of  <code>nodeName</code>,  <code>nodeValue</code>, and  <code>attributes</code> vary according to the node type as follows:  <table> <row> <entry> <para>Interface </para></entry> <entry> <para>nodeName </para></entry> <entry> <para>nodeValue </para></entry> <entry> <para>attributes  </para></entry></row> <row> <entry> <para> <code>Attr</code> </para></entry> <entry> <para>same as  <code>Attr.name</code> </para></entry> <entry> <para>same as  <code>Attr.value</code> </para></entry> <entry> <para> <code>null</code>  </para></entry></row> <row> <entry> <para> <code>CDATASection</code> </para></entry> <entry> <para> <code>"#cdata-section"</code> </para></entry> <entry> <para>same as  <code>CharacterData.data</code>, the content of the CDATA Section </para></entry> <entry> <para> <code>null</code>  </para></entry></row> <row> <entry> <para> <code>Comment</code> </para></entry> <entry> <para> <code>"#comment"</code> </para></entry> <entry> <para>same as  <code>CharacterData.data</code>, the content of the comment </para></entry> <entry> <para> <code>null</code>  </para></entry></row> <row> <entry> <para> <code>Document</code> </para></entry> <entry> <para> <code>"#document"</code> </para></entry> <entry> <para> <code>null</code> </para></entry> <entry> <para> <code>null</code>  </para></entry></row> <row> <entry> <para> <code>DocumentFragment</code> </para></entry> <entry> <para> <code>"#document-fragment"</code> </para></entry> <entry> <para> <code>null</code> </para></entry> <entry> <para> <code>null</code>  </para></entry></row> <row> <entry> <para> <code>DocumentType</code> </para></entry> <entry> <para>same as  <code>DocumentType.name</code> </para></entry> <entry> <para> <code>null</code> </para></entry> <entry> <para> <code>null</code>  </para></entry></row> <row> <entry> <para> <code>Element</code> </para></entry> <entry> <para>same as  <code>Element.tagName</code> </para></entry> <entry> <para> <code>null</code> </para></entry> <entry> <para> <code>NamedNodeMap</code>  </para></entry></row> <row> <entry> <para> <code>Entity</code> </para></entry> <entry> <para>entity name </para></entry> <entry> <para> <code>null</code> </para></entry> <entry> <para> <code>null</code>  </para></entry></row> <row> <entry> <para> <code>EntityReference</code> </para></entry> <entry> <para>name of entity referenced </para></entry> <entry> <para> <code>null</code> </para></entry> <entry> <para> <code>null</code>  </para></entry></row> <row> <entry> <para> <code>Notation</code> </para></entry> <entry> <para>notation name </para></entry> <entry> <para> <code>null</code> </para></entry> <entry> <para> <code>null</code>  </para></entry></row> <row> <entry> <para> <code>ProcessingInstruction</code> </para></entry> <entry> <para>same as  <code>ProcessingInstruction.target</code> </para></entry> <entry> <para>same as  <code>ProcessingInstruction.data</code> </para></entry> <entry> <para> <code>null</code>  </para></entry></row> <row> <entry> <para> <code>Text</code> </para></entry> <entry> <para> <code>"#text"</code> </para></entry> <entry> <para>same as  <code>CharacterData.data</code>, the content of the text node </para></entry> <entry> <para> <code>null</code>  </para></entry></row></table></para> <para>See also the . </para>    
		/// </summary>
		/// <java-name>
		/// org/w3c/dom/Node
		/// </java-name>
		[Dot42.DexImport("org/w3c/dom/Node", AccessFlags = 1537, IgnoreFromJava = true, Priority = 1)]
		public static partial class INodeConstants
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>The node is an  <code>Element</code>. </para>        
				/// </summary>
				/// <java-name>
				/// ELEMENT_NODE
				/// </java-name>
				[Dot42.DexImport("ELEMENT_NODE", "S", AccessFlags = 25)]
				public const short ELEMENT_NODE = 1;
				/// <summary>
				///  <para>The node is an  <code>Attr</code>. </para>        
				/// </summary>
				/// <java-name>
				/// ATTRIBUTE_NODE
				/// </java-name>
				[Dot42.DexImport("ATTRIBUTE_NODE", "S", AccessFlags = 25)]
				public const short ATTRIBUTE_NODE = 2;
				/// <summary>
				///  <para>The node is a  <code>Text</code> node. </para>        
				/// </summary>
				/// <java-name>
				/// TEXT_NODE
				/// </java-name>
				[Dot42.DexImport("TEXT_NODE", "S", AccessFlags = 25)]
				public const short TEXT_NODE = 3;
				/// <summary>
				///  <para>The node is a  <code>CDATASection</code>. </para>        
				/// </summary>
				/// <java-name>
				/// CDATA_SECTION_NODE
				/// </java-name>
				[Dot42.DexImport("CDATA_SECTION_NODE", "S", AccessFlags = 25)]
				public const short CDATA_SECTION_NODE = 4;
				/// <summary>
				///  <para>The node is an  <code>EntityReference</code>. </para>        
				/// </summary>
				/// <java-name>
				/// ENTITY_REFERENCE_NODE
				/// </java-name>
				[Dot42.DexImport("ENTITY_REFERENCE_NODE", "S", AccessFlags = 25)]
				public const short ENTITY_REFERENCE_NODE = 5;
				/// <summary>
				///  <para>The node is an  <code>Entity</code>. </para>        
				/// </summary>
				/// <java-name>
				/// ENTITY_NODE
				/// </java-name>
				[Dot42.DexImport("ENTITY_NODE", "S", AccessFlags = 25)]
				public const short ENTITY_NODE = 6;
				/// <summary>
				///  <para>The node is a  <code>ProcessingInstruction</code>. </para>        
				/// </summary>
				/// <java-name>
				/// PROCESSING_INSTRUCTION_NODE
				/// </java-name>
				[Dot42.DexImport("PROCESSING_INSTRUCTION_NODE", "S", AccessFlags = 25)]
				public const short PROCESSING_INSTRUCTION_NODE = 7;
				/// <summary>
				///  <para>The node is a  <code>Comment</code>. </para>        
				/// </summary>
				/// <java-name>
				/// COMMENT_NODE
				/// </java-name>
				[Dot42.DexImport("COMMENT_NODE", "S", AccessFlags = 25)]
				public const short COMMENT_NODE = 8;
				/// <summary>
				///  <para>The node is a  <code>Document</code>. </para>        
				/// </summary>
				/// <java-name>
				/// DOCUMENT_NODE
				/// </java-name>
				[Dot42.DexImport("DOCUMENT_NODE", "S", AccessFlags = 25)]
				public const short DOCUMENT_NODE = 9;
				/// <summary>
				///  <para>The node is a  <code>DocumentType</code>. </para>        
				/// </summary>
				/// <java-name>
				/// DOCUMENT_TYPE_NODE
				/// </java-name>
				[Dot42.DexImport("DOCUMENT_TYPE_NODE", "S", AccessFlags = 25)]
				public const short DOCUMENT_TYPE_NODE = 10;
				/// <summary>
				///  <para>The node is a  <code>DocumentFragment</code>. </para>        
				/// </summary>
				/// <java-name>
				/// DOCUMENT_FRAGMENT_NODE
				/// </java-name>
				[Dot42.DexImport("DOCUMENT_FRAGMENT_NODE", "S", AccessFlags = 25)]
				public const short DOCUMENT_FRAGMENT_NODE = 11;
				/// <summary>
				///  <para>The node is a  <code>Notation</code>. </para>        
				/// </summary>
				/// <java-name>
				/// NOTATION_NODE
				/// </java-name>
				[Dot42.DexImport("NOTATION_NODE", "S", AccessFlags = 25)]
				public const short NOTATION_NODE = 12;
				/// <summary>
				///  <para>The two nodes are disconnected. Order between disconnected nodes is always implementation-specific. </para>        
				/// </summary>
				/// <java-name>
				/// DOCUMENT_POSITION_DISCONNECTED
				/// </java-name>
				[Dot42.DexImport("DOCUMENT_POSITION_DISCONNECTED", "S", AccessFlags = 25)]
				public const short DOCUMENT_POSITION_DISCONNECTED = 1;
				/// <summary>
				///  <para>The second node precedes the reference node. </para>        
				/// </summary>
				/// <java-name>
				/// DOCUMENT_POSITION_PRECEDING
				/// </java-name>
				[Dot42.DexImport("DOCUMENT_POSITION_PRECEDING", "S", AccessFlags = 25)]
				public const short DOCUMENT_POSITION_PRECEDING = 2;
				/// <summary>
				///  <para>The node follows the reference node. </para>        
				/// </summary>
				/// <java-name>
				/// DOCUMENT_POSITION_FOLLOWING
				/// </java-name>
				[Dot42.DexImport("DOCUMENT_POSITION_FOLLOWING", "S", AccessFlags = 25)]
				public const short DOCUMENT_POSITION_FOLLOWING = 4;
				/// <summary>
				///  <para>The node contains the reference node. A node which contains is always preceding, too. </para>        
				/// </summary>
				/// <java-name>
				/// DOCUMENT_POSITION_CONTAINS
				/// </java-name>
				[Dot42.DexImport("DOCUMENT_POSITION_CONTAINS", "S", AccessFlags = 25)]
				public const short DOCUMENT_POSITION_CONTAINS = 8;
				/// <summary>
				///  <para>The node is contained by the reference node. A node which is contained is always following, too. </para>        
				/// </summary>
				/// <java-name>
				/// DOCUMENT_POSITION_CONTAINED_BY
				/// </java-name>
				[Dot42.DexImport("DOCUMENT_POSITION_CONTAINED_BY", "S", AccessFlags = 25)]
				public const short DOCUMENT_POSITION_CONTAINED_BY = 16;
				/// <summary>
				///  <para>The determination of preceding versus following is implementation-specific. </para>        
				/// </summary>
				/// <java-name>
				/// DOCUMENT_POSITION_IMPLEMENTATION_SPECIFIC
				/// </java-name>
				[Dot42.DexImport("DOCUMENT_POSITION_IMPLEMENTATION_SPECIFIC", "S", AccessFlags = 25)]
				public const short DOCUMENT_POSITION_IMPLEMENTATION_SPECIFIC = 32;
		}

		/// <summary>
		///  <para>The  <code>NodeList</code> interface provides the abstraction of an ordered collection of nodes, without defining or constraining how this collection is implemented.  <code>NodeList</code> objects in the DOM are live. </para> <para>The items in the  <code>NodeList</code> are accessible via an integral index, starting from 0. </para> <para>See also the . </para>    
		/// </summary>
		/// <java-name>
		/// org/w3c/dom/NodeList
		/// </java-name>
		[Dot42.DexImport("org/w3c/dom/NodeList", AccessFlags = 1537)]
		public partial interface INodeList
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Returns the  <code>index</code>th item in the collection. If  <code>index</code> is greater than or equal to the number of nodes in the list, this returns  <code>null</code>. </para>        
				/// </summary>
				/// <returns>
				///  <para>The node at the  <code>index</code>th position in the  <code>NodeList</code>, or  <code>null</code> if that is not a valid index. </para>
				/// </returns>
				/// <java-name>
				/// item
				/// </java-name>
				[Dot42.DexImport("item", "(I)Lorg/w3c/dom/Node;", AccessFlags = 1025)]
				global::Org.W3c.Dom.INode Item(int index) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>The number of nodes in the list. The range of valid child node indices is 0 to  <code>length-1</code> inclusive. </para>        
				/// </summary>
				/// <java-name>
				/// getLength
				/// </java-name>
				int Length
				{
						[Dot42.DexImport("getLength", "()I", AccessFlags = 1025)]
						get;
				}

		}

		/// <summary>
		///  <para>This interface represents a notation declared in the DTD. A notation either declares, by name, the format of an unparsed entity (see  of the XML 1.0 specification []), or is used for formal declaration of processing instruction targets (see  of the XML 1.0 specification []). The  <code>nodeName</code> attribute inherited from  <code>Node</code> is set to the declared name of the notation. </para> <para>The DOM Core does not support editing  <code>Notation</code> nodes; they are therefore readonly. </para> <para>A  <code>Notation</code> node does not have any parent. </para> <para>See also the . </para>    
		/// </summary>
		/// <java-name>
		/// org/w3c/dom/Notation
		/// </java-name>
		[Dot42.DexImport("org/w3c/dom/Notation", AccessFlags = 1537)]
		public partial interface INotation : global::Org.W3c.Dom.INode
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>The public identifier of this notation. If the public identifier was not specified, this is  <code>null</code>. </para>        
				/// </summary>
				/// <java-name>
				/// getPublicId
				/// </java-name>
				string PublicId
				{
						[Dot42.DexImport("getPublicId", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>The system identifier of this notation. If the system identifier was not specified, this is  <code>null</code>. This may be an absolute URI or not. </para>        
				/// </summary>
				/// <java-name>
				/// getSystemId
				/// </java-name>
				string SystemId
				{
						[Dot42.DexImport("getSystemId", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

		}

		/// <summary>
		///  <para>The  <code>ProcessingInstruction</code> interface represents a "processinginstruction", used in XML as a way to keep processor-specific information in the text of the document. </para> <para>No lexical check is done on the content of a processing instruction and it is therefore possible to have the character sequence  <code>"?&amp;gt;"</code> in the content, which is illegal a processing instruction per section 2.6 of []. The presence of this character sequence must generate a fatal error during serialization. </para> <para>See also the . </para>    
		/// </summary>
		/// <java-name>
		/// org/w3c/dom/ProcessingInstruction
		/// </java-name>
		[Dot42.DexImport("org/w3c/dom/ProcessingInstruction", AccessFlags = 1537)]
		public partial interface IProcessingInstruction : global::Org.W3c.Dom.INode
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>The target of this processing instruction. XML defines this as being the first token following the markup that begins the processing instruction. </para>        
				/// </summary>
				/// <java-name>
				/// getTarget
				/// </java-name>
				string Target
				{
						[Dot42.DexImport("getTarget", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>The content of this processing instruction. This is from the first non white space character after the target to the character immediately preceding the  <code>?&gt;</code>. </para>        
				/// </summary>
				/// <java-name>
				/// getData
				/// </java-name>
				string Data
				{
						[Dot42.DexImport("getData", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
						[Dot42.DexImport("setData", "(Ljava/lang/String;)V", AccessFlags = 1025)]
						set;
				}

		}

		/// <summary>
		///  <para>The  <code>Text</code> interface inherits from  <code>CharacterData</code> and represents the textual content (termed  in XML) of an  <code>Element</code> or  <code>Attr</code>. If there is no markup inside an element's content, the text is contained in a single object implementing the  <code>Text</code> interface that is the only child of the element. If there is markup, it is parsed into the information items (elements, comments, etc.) and  <code>Text</code> nodes that form the list of children of the element. </para> <para>When a document is first made available via the DOM, there is only one  <code>Text</code> node for each block of text. Users may create adjacent  <code>Text</code> nodes that represent the contents of a given element without any intervening markup, but should be aware that there is no way to represent the separations between these nodes in XML or HTML, so they will not (in general) persist between DOM editing sessions. The  <code>Node.normalize()</code> method merges any such adjacent  <code>Text</code> objects into a single node for each block of text. </para> <para>No lexical check is done on the content of a  <code>Text</code> node and, depending on its position in the document, some characters must be escaped during serialization using character references; e.g. the characters "&amp;lt;&amp;amp;" if the textual content is part of an element or of an attribute, the character sequence "]]&amp;gt;" when part of an element, the quotation mark character " or the apostrophe character ' when part of an attribute. </para> <para>See also the . </para>    
		/// </summary>
		/// <java-name>
		/// org/w3c/dom/Text
		/// </java-name>
		[Dot42.DexImport("org/w3c/dom/Text", AccessFlags = 1537)]
		public partial interface IText : global::Org.W3c.Dom.ICharacterData
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Breaks this node into two nodes at the specified  <code>offset</code>, keeping both in the tree as siblings. After being split, this node will contain all the content up to the  <code>offset</code> point. A new node of the same type, which contains all the content at and after the  <code>offset</code> point, is returned. If the original node had a parent node, the new node is inserted as the next sibling of the original node. When the  <code>offset</code> is equal to the length of this node, the new node has no data. </para>        
				/// </summary>
				/// <returns>
				///  <para>The new node, of the same type as this node. </para>
				/// </returns>
				/// <java-name>
				/// splitText
				/// </java-name>
				[Dot42.DexImport("splitText", "(I)Lorg/w3c/dom/Text;", AccessFlags = 1025)]
				global::Org.W3c.Dom.IText SplitText(int offset) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Replaces the text of the current node and all logically-adjacent text nodes with the specified text. All logically-adjacent text nodes are removed including the current node unless it was the recipient of the replacement text.  <br></br>This method returns the node which received the replacement text. The returned node is:  <ul> <li> <para> <code>null</code>, when the replacement text is the empty string;  </para></li> <li> <para>the current node, except when the current node is read-only;  </para></li> <li> <para>a new  <code>Text</code> node of the same type (  <code>Text</code> or  <code>CDATASection</code>) as the current node inserted at the location of the replacement.  </para></li></ul> <br></br>For instance, in the above example calling  <code>replaceWholeText</code> on the  <code>Text</code> node that contains "bar" with "yo" in argument results in the following:  <br></br>Where the nodes to be removed are read-only descendants of an  <code>EntityReference</code>, the  <code>EntityReference</code> must be removed instead of the read-only nodes. If any  <code>EntityReference</code> to be removed has descendants that are not  <code>EntityReference</code>,  <code>Text</code>, or  <code>CDATASection</code> nodes, the  <code>replaceWholeText</code> method must fail before performing any modification of the document, raising a  <code>DOMException</code> with the code  <code>NO_MODIFICATION_ALLOWED_ERR</code>.  <br></br>For instance, in the example below calling  <code>replaceWholeText</code> on the  <code>Text</code> node that contains "bar" fails, because the  <code>EntityReference</code> node "ent" contains an  <code>Element</code> node which cannot be removed.  <para>DOM Level 3 </para></para>        
				/// </summary>
				/// <returns>
				///  <para>The  <code>Text</code> node created with the specified content. </para>
				/// </returns>
				/// <java-name>
				/// replaceWholeText
				/// </java-name>
				[Dot42.DexImport("replaceWholeText", "(Ljava/lang/String;)Lorg/w3c/dom/Text;", AccessFlags = 1025)]
				global::Org.W3c.Dom.IText ReplaceWholeText(string content) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns whether this text node contains , often abusively called "ignorable whitespace". The text node is determined to contain whitespace in element content during the load of the document or if validation occurs while using  <code>Document.normalizeDocument()</code>.  <para>DOM Level 3 </para></para>        
				/// </summary>
				/// <java-name>
				/// isElementContentWhitespace
				/// </java-name>
				bool IsElementContentWhitespace
				{
						[Dot42.DexImport("isElementContentWhitespace", "()Z", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Returns all text of  <code>Text</code> nodes logically-adjacent text nodes to this node, concatenated in document order.  <br></br>For instance, in the example below  <code>wholeText</code> on the  <code>Text</code> node that contains "bar" returns "barfoo", while on the  <code>Text</code> node that contains "foo" it returns "barfoo".  <para>DOM Level 3 </para></para>        
				/// </summary>
				/// <java-name>
				/// getWholeText
				/// </java-name>
				string WholeText
				{
						[Dot42.DexImport("getWholeText", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

		}

		/// <summary>
		///  <para>The  <code>TypeInfo</code> interface represents a type referenced from  <code>Element</code> or  <code>Attr</code> nodes, specified in the schemas associated with the document. The type is a pair of a namespace URI and name properties, and depends on the document's schema. </para> <para>If the document's schema is an XML DTD [], the values are computed as follows:  <ul> <li> <para>If this type is referenced from an  <code>Attr</code> node,  <code>typeNamespace</code> is  <code>"http://www.w3.org/TR/REC-xml"</code> and  <code>typeName</code> represents the  <b>[attribute type]</b> property in the [] . If there is no declaration for the attribute,  <code>typeNamespace</code> and  <code>typeName</code> are  <code>null</code>.  </para></li> <li> <para>If this type is referenced from an  <code>Element</code> node,  <code>typeNamespace</code> and  <code>typeName</code> are  <code>null</code>.  </para></li></ul></para> <para>If the document's schema is an XML Schema [] , the values are computed as follows using the post-schema-validation infoset contributions (also called PSVI contributions):  <ul> <li> <para>If the  <b>[validity]</b> property exists AND is  <b>"invalid"</b> or  <b>"notKnown"</b>: the {target namespace} and {name} properties of the declared type if available, otherwise  <code>null</code>. </para> <para> <b>Note:</b> At the time of writing, the XML Schema specification does not require exposing the declared type. Thus, DOM implementations might choose not to provide type information if validity is not valid.  </para></li> <li> <para>If the  <b>[validity]</b> property exists and is  <b>"valid"</b>:  <ol> <li> <para>If  <b>[member type definition]</b> exists:  <ol> <li> <para>If {name} is not absent, then expose {name} and {target namespace} properties of the  <b>[member type definition]</b> property;  </para></li> <li> <para>Otherwise, expose the namespace and local name of the corresponding anonymous type name.  </para></li></ol></para></li> <li> <para>If the  <b>[type definition]</b> property exists:  <ol> <li> <para>If {name} is not absent, then expose {name} and {target namespace} properties of the  <b>[type definition]</b> property;  </para></li> <li> <para>Otherwise, expose the namespace and local name of the corresponding anonymous type name.  </para></li></ol></para></li> <li> <para>If the  <b>[member type definition anonymous]</b> exists:  <ol> <li> <para>If it is false, then expose  <b>[member type definition name]</b> and  <b>[member type definition namespace]</b> properties;  </para></li> <li> <para>Otherwise, expose the namespace and local name of the corresponding anonymous type name.  </para></li></ol></para></li> <li> <para>If the  <b>[type definition anonymous]</b> exists:  <ol> <li> <para>If it is false, then expose  <b>[type definition name]</b> and  <b>[type definition namespace]</b> properties;  </para></li> <li> <para>Otherwise, expose the namespace and local name of the corresponding anonymous type name.  </para></li></ol></para></li></ol></para></li></ul></para> <para> <b>Note:</b> Other schema languages are outside the scope of the W3C and therefore should define how to represent their type systems using  <code>TypeInfo</code>. </para> <para>See also the .  <para>DOM Level 3 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/w3c/dom/TypeInfo
		/// </java-name>
		[Dot42.DexImport("org/w3c/dom/TypeInfo", AccessFlags = 1537)]
		public partial interface ITypeInfo
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>This method returns if there is a derivation between the reference type definition, i.e. the  <code>TypeInfo</code> on which the method is being called, and the other type definition, i.e. the one passed as parameters. </para>        
				/// </summary>
				/// <returns>
				///  <para>If the document's schema is a DTD or no schema is associated with the document, this method will always return  <code>false</code> . If the document's schema is an XML Schema, the method will  <code>true</code> if the reference type definition is derived from the other type definition according to the derivation parameter. If the value of the parameter is  <code>0</code> (no bit is set to  <code>1</code> for the  <code>derivationMethod</code> parameter), the method will return  <code>true</code> if the other type definition can be reached by recursing any combination of {base type definition}, {item type definition}, or {member type definitions} from the reference type definition. </para>
				/// </returns>
				/// <java-name>
				/// isDerivedFrom
				/// </java-name>
				[Dot42.DexImport("isDerivedFrom", "(Ljava/lang/String;Ljava/lang/String;I)Z", AccessFlags = 1025)]
				bool IsDerivedFrom(string typeNamespaceArg, string typeNameArg, int derivationMethod) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>The name of a type declared for the associated element or attribute, or  <code>null</code> if unknown. </para>        
				/// </summary>
				/// <java-name>
				/// getTypeName
				/// </java-name>
				string TypeName
				{
						[Dot42.DexImport("getTypeName", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>The namespace of the type declared for the associated element or attribute or  <code>null</code> if the element does not have declaration or if no namespace information is available. </para>        
				/// </summary>
				/// <java-name>
				/// getTypeNamespace
				/// </java-name>
				string TypeNamespace
				{
						[Dot42.DexImport("getTypeNamespace", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

		}

		/// <summary>
		///  <para>The  <code>TypeInfo</code> interface represents a type referenced from  <code>Element</code> or  <code>Attr</code> nodes, specified in the schemas associated with the document. The type is a pair of a namespace URI and name properties, and depends on the document's schema. </para> <para>If the document's schema is an XML DTD [], the values are computed as follows:  <ul> <li> <para>If this type is referenced from an  <code>Attr</code> node,  <code>typeNamespace</code> is  <code>"http://www.w3.org/TR/REC-xml"</code> and  <code>typeName</code> represents the  <b>[attribute type]</b> property in the [] . If there is no declaration for the attribute,  <code>typeNamespace</code> and  <code>typeName</code> are  <code>null</code>.  </para></li> <li> <para>If this type is referenced from an  <code>Element</code> node,  <code>typeNamespace</code> and  <code>typeName</code> are  <code>null</code>.  </para></li></ul></para> <para>If the document's schema is an XML Schema [] , the values are computed as follows using the post-schema-validation infoset contributions (also called PSVI contributions):  <ul> <li> <para>If the  <b>[validity]</b> property exists AND is  <b>"invalid"</b> or  <b>"notKnown"</b>: the {target namespace} and {name} properties of the declared type if available, otherwise  <code>null</code>. </para> <para> <b>Note:</b> At the time of writing, the XML Schema specification does not require exposing the declared type. Thus, DOM implementations might choose not to provide type information if validity is not valid.  </para></li> <li> <para>If the  <b>[validity]</b> property exists and is  <b>"valid"</b>:  <ol> <li> <para>If  <b>[member type definition]</b> exists:  <ol> <li> <para>If {name} is not absent, then expose {name} and {target namespace} properties of the  <b>[member type definition]</b> property;  </para></li> <li> <para>Otherwise, expose the namespace and local name of the corresponding anonymous type name.  </para></li></ol></para></li> <li> <para>If the  <b>[type definition]</b> property exists:  <ol> <li> <para>If {name} is not absent, then expose {name} and {target namespace} properties of the  <b>[type definition]</b> property;  </para></li> <li> <para>Otherwise, expose the namespace and local name of the corresponding anonymous type name.  </para></li></ol></para></li> <li> <para>If the  <b>[member type definition anonymous]</b> exists:  <ol> <li> <para>If it is false, then expose  <b>[member type definition name]</b> and  <b>[member type definition namespace]</b> properties;  </para></li> <li> <para>Otherwise, expose the namespace and local name of the corresponding anonymous type name.  </para></li></ol></para></li> <li> <para>If the  <b>[type definition anonymous]</b> exists:  <ol> <li> <para>If it is false, then expose  <b>[type definition name]</b> and  <b>[type definition namespace]</b> properties;  </para></li> <li> <para>Otherwise, expose the namespace and local name of the corresponding anonymous type name.  </para></li></ol></para></li></ol></para></li></ul></para> <para> <b>Note:</b> Other schema languages are outside the scope of the W3C and therefore should define how to represent their type systems using  <code>TypeInfo</code>. </para> <para>See also the .  <para>DOM Level 3 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/w3c/dom/TypeInfo
		/// </java-name>
		[Dot42.DexImport("org/w3c/dom/TypeInfo", AccessFlags = 1537, IgnoreFromJava = true, Priority = 1)]
		public static partial class ITypeInfoConstants
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>If the document's schema is an XML Schema [] , this constant represents the derivation by  if complex types are involved, or a  if simple types are involved.  <br></br> The reference type definition is derived by restriction from the other type definition if the other type definition is the same as the reference type definition, or if the other type definition can be reached recursively following the {base type definition} property from the reference type definition, and all the  <b>derivation methods</b> involved are restriction. </para>        
				/// </summary>
				/// <java-name>
				/// DERIVATION_RESTRICTION
				/// </java-name>
				[Dot42.DexImport("DERIVATION_RESTRICTION", "I", AccessFlags = 25)]
				public const int DERIVATION_RESTRICTION = 1;
				/// <summary>
				///  <para>If the document's schema is an XML Schema [] , this constant represents the derivation by .  <br></br> The reference type definition is derived by extension from the other type definition if the other type definition can be reached recursively following the {base type definition} property from the reference type definition, and at least one of the  <b>derivation methods</b> involved is an extension. </para>        
				/// </summary>
				/// <java-name>
				/// DERIVATION_EXTENSION
				/// </java-name>
				[Dot42.DexImport("DERIVATION_EXTENSION", "I", AccessFlags = 25)]
				public const int DERIVATION_EXTENSION = 2;
				/// <summary>
				///  <para>If the document's schema is an XML Schema [] , this constant represents the  if simple types are involved.  <br></br> The reference type definition is derived by union from the other type definition if there exists two type definitions T1 and T2 such as the reference type definition is derived from T1 by  <code>DERIVATION_RESTRICTION</code> or  <code>DERIVATION_EXTENSION</code>, T2 is derived from the other type definition by  <code>DERIVATION_RESTRICTION</code>, T1 has {variety}  <b>union</b>, and one of the {member type definitions} is T2. Note that T1 could be the same as the reference type definition, and T2 could be the same as the other type definition. </para>        
				/// </summary>
				/// <java-name>
				/// DERIVATION_UNION
				/// </java-name>
				[Dot42.DexImport("DERIVATION_UNION", "I", AccessFlags = 25)]
				public const int DERIVATION_UNION = 4;
				/// <summary>
				///  <para>If the document's schema is an XML Schema [] , this constant represents the .  <br></br> The reference type definition is derived by list from the other type definition if there exists two type definitions T1 and T2 such as the reference type definition is derived from T1 by  <code>DERIVATION_RESTRICTION</code> or  <code>DERIVATION_EXTENSION</code>, T2 is derived from the other type definition by  <code>DERIVATION_RESTRICTION</code>, T1 has {variety}  <b>list</b>, and T2 is the {item type definition}. Note that T1 could be the same as the reference type definition, and T2 could be the same as the other type definition. </para>        
				/// </summary>
				/// <java-name>
				/// DERIVATION_LIST
				/// </java-name>
				[Dot42.DexImport("DERIVATION_LIST", "I", AccessFlags = 25)]
				public const int DERIVATION_LIST = 8;
		}

		/// <summary>
		///  <para>When associating an object to a key on a node using  <code>Node.setUserData()</code> the application can provide a handler that gets called when the node the object is associated to is being cloned, imported, or renamed. This can be used by the application to implement various behaviors regarding the data it associates to the DOM nodes. This interface defines that handler. </para> <para>See also the .  <para>DOM Level 3 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/w3c/dom/UserDataHandler
		/// </java-name>
		[Dot42.DexImport("org/w3c/dom/UserDataHandler", AccessFlags = 1537)]
		public partial interface IUserDataHandler
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>This method is called whenever the node for which this handler is registered is imported or cloned.  <br></br> DOM applications must not raise exceptions in a  <code>UserDataHandler</code>. The effect of throwing exceptions from the handler is DOM implementation dependent. </para>        
				/// </summary>
				/// <java-name>
				/// handle
				/// </java-name>
				[Dot42.DexImport("handle", "(SLjava/lang/String;Ljava/lang/Object;Lorg/w3c/dom/Node;Lorg/w3c/dom/Node;)V", AccessFlags = 1025)]
				void Handle(short operation, string key, object data, global::Org.W3c.Dom.INode src, global::Org.W3c.Dom.INode dst) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		///  <para>When associating an object to a key on a node using  <code>Node.setUserData()</code> the application can provide a handler that gets called when the node the object is associated to is being cloned, imported, or renamed. This can be used by the application to implement various behaviors regarding the data it associates to the DOM nodes. This interface defines that handler. </para> <para>See also the .  <para>DOM Level 3 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/w3c/dom/UserDataHandler
		/// </java-name>
		[Dot42.DexImport("org/w3c/dom/UserDataHandler", AccessFlags = 1537, IgnoreFromJava = true, Priority = 1)]
		public static partial class IUserDataHandlerConstants
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>The node is cloned, using  <code>Node.cloneNode()</code>. </para>        
				/// </summary>
				/// <java-name>
				/// NODE_CLONED
				/// </java-name>
				[Dot42.DexImport("NODE_CLONED", "S", AccessFlags = 25)]
				public const short NODE_CLONED = 1;
				/// <summary>
				///  <para>The node is imported, using  <code>Document.importNode()</code>. </para>        
				/// </summary>
				/// <java-name>
				/// NODE_IMPORTED
				/// </java-name>
				[Dot42.DexImport("NODE_IMPORTED", "S", AccessFlags = 25)]
				public const short NODE_IMPORTED = 2;
				/// <summary>
				///  <para>The node is deleted. </para> <para> <b>Note:</b> This may not be supported or may not be reliable in certain environments, such as Java, where the implementation has no real control over when objects are actually deleted. </para>        
				/// </summary>
				/// <java-name>
				/// NODE_DELETED
				/// </java-name>
				[Dot42.DexImport("NODE_DELETED", "S", AccessFlags = 25)]
				public const short NODE_DELETED = 3;
				/// <summary>
				///  <para>The node is renamed, using  <code>Document.renameNode()</code>. </para>        
				/// </summary>
				/// <java-name>
				/// NODE_RENAMED
				/// </java-name>
				[Dot42.DexImport("NODE_RENAMED", "S", AccessFlags = 25)]
				public const short NODE_RENAMED = 4;
				/// <summary>
				///  <para>The node is adopted, using  <code>Document.adoptNode()</code>. </para>        
				/// </summary>
				/// <java-name>
				/// NODE_ADOPTED
				/// </java-name>
				[Dot42.DexImport("NODE_ADOPTED", "S", AccessFlags = 25)]
				public const short NODE_ADOPTED = 5;
		}

}

