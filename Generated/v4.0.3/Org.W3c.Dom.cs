#pragma warning disable 1717
namespace Org.W3c.Dom
{
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
				/// <java-name>
				/// INDEX_SIZE_ERR
				/// </java-name>
				[Dot42.DexImport("INDEX_SIZE_ERR", "S", AccessFlags = 25)]
				public const short INDEX_SIZE_ERR = 1;
				/// <java-name>
				/// DOMSTRING_SIZE_ERR
				/// </java-name>
				[Dot42.DexImport("DOMSTRING_SIZE_ERR", "S", AccessFlags = 25)]
				public const short DOMSTRING_SIZE_ERR = 2;
				/// <java-name>
				/// HIERARCHY_REQUEST_ERR
				/// </java-name>
				[Dot42.DexImport("HIERARCHY_REQUEST_ERR", "S", AccessFlags = 25)]
				public const short HIERARCHY_REQUEST_ERR = 3;
				/// <java-name>
				/// WRONG_DOCUMENT_ERR
				/// </java-name>
				[Dot42.DexImport("WRONG_DOCUMENT_ERR", "S", AccessFlags = 25)]
				public const short WRONG_DOCUMENT_ERR = 4;
				/// <java-name>
				/// INVALID_CHARACTER_ERR
				/// </java-name>
				[Dot42.DexImport("INVALID_CHARACTER_ERR", "S", AccessFlags = 25)]
				public const short INVALID_CHARACTER_ERR = 5;
				/// <java-name>
				/// NO_DATA_ALLOWED_ERR
				/// </java-name>
				[Dot42.DexImport("NO_DATA_ALLOWED_ERR", "S", AccessFlags = 25)]
				public const short NO_DATA_ALLOWED_ERR = 6;
				/// <java-name>
				/// NO_MODIFICATION_ALLOWED_ERR
				/// </java-name>
				[Dot42.DexImport("NO_MODIFICATION_ALLOWED_ERR", "S", AccessFlags = 25)]
				public const short NO_MODIFICATION_ALLOWED_ERR = 7;
				/// <java-name>
				/// NOT_FOUND_ERR
				/// </java-name>
				[Dot42.DexImport("NOT_FOUND_ERR", "S", AccessFlags = 25)]
				public const short NOT_FOUND_ERR = 8;
				/// <java-name>
				/// NOT_SUPPORTED_ERR
				/// </java-name>
				[Dot42.DexImport("NOT_SUPPORTED_ERR", "S", AccessFlags = 25)]
				public const short NOT_SUPPORTED_ERR = 9;
				/// <java-name>
				/// INUSE_ATTRIBUTE_ERR
				/// </java-name>
				[Dot42.DexImport("INUSE_ATTRIBUTE_ERR", "S", AccessFlags = 25)]
				public const short INUSE_ATTRIBUTE_ERR = 10;
				/// <java-name>
				/// INVALID_STATE_ERR
				/// </java-name>
				[Dot42.DexImport("INVALID_STATE_ERR", "S", AccessFlags = 25)]
				public const short INVALID_STATE_ERR = 11;
				/// <java-name>
				/// SYNTAX_ERR
				/// </java-name>
				[Dot42.DexImport("SYNTAX_ERR", "S", AccessFlags = 25)]
				public const short SYNTAX_ERR = 12;
				/// <java-name>
				/// INVALID_MODIFICATION_ERR
				/// </java-name>
				[Dot42.DexImport("INVALID_MODIFICATION_ERR", "S", AccessFlags = 25)]
				public const short INVALID_MODIFICATION_ERR = 13;
				/// <java-name>
				/// NAMESPACE_ERR
				/// </java-name>
				[Dot42.DexImport("NAMESPACE_ERR", "S", AccessFlags = 25)]
				public const short NAMESPACE_ERR = 14;
				/// <java-name>
				/// INVALID_ACCESS_ERR
				/// </java-name>
				[Dot42.DexImport("INVALID_ACCESS_ERR", "S", AccessFlags = 25)]
				public const short INVALID_ACCESS_ERR = 15;
				/// <java-name>
				/// VALIDATION_ERR
				/// </java-name>
				[Dot42.DexImport("VALIDATION_ERR", "S", AccessFlags = 25)]
				public const short VALIDATION_ERR = 16;
				/// <java-name>
				/// TYPE_MISMATCH_ERR
				/// </java-name>
				[Dot42.DexImport("TYPE_MISMATCH_ERR", "S", AccessFlags = 25)]
				public const short TYPE_MISMATCH_ERR = 17;
				[Dot42.DexImport("<init>", "(SLjava/lang/String;)V", AccessFlags = 1)]
				public DOMException(short int16, string @string) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal DOMException() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// org/w3c/dom/Attr
		/// </java-name>
		[Dot42.DexImport("org/w3c/dom/Attr", AccessFlags = 1537)]
		public partial interface IAttr : global::Org.W3c.Dom.INode
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// getName
				/// </java-name>
				string Name
				{
						[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getSpecified
				/// </java-name>
				bool IsSpecified
				{
						[Dot42.DexImport("getSpecified", "()Z", AccessFlags = 1025)]
						get;
				}

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

				/// <java-name>
				/// getOwnerElement
				/// </java-name>
				global::Org.W3c.Dom.IElement OwnerElement
				{
						[Dot42.DexImport("getOwnerElement", "()Lorg/w3c/dom/Element;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getSchemaTypeInfo
				/// </java-name>
				global::Org.W3c.Dom.ITypeInfo SchemaTypeInfo
				{
						[Dot42.DexImport("getSchemaTypeInfo", "()Lorg/w3c/dom/TypeInfo;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// isId
				/// </java-name>
				bool IsId
				{
						[Dot42.DexImport("isId", "()Z", AccessFlags = 1025)]
						get;
				}

		}

		/// <java-name>
		/// org/w3c/dom/CDATASection
		/// </java-name>
		[Dot42.DexImport("org/w3c/dom/CDATASection", AccessFlags = 1537)]
		public partial interface ICDATASection : global::Org.W3c.Dom.IText
 /* scope: __dot42__ */ 
		{
		}

		/// <java-name>
		/// org/w3c/dom/CharacterData
		/// </java-name>
		[Dot42.DexImport("org/w3c/dom/CharacterData", AccessFlags = 1537)]
		public partial interface ICharacterData : global::Org.W3c.Dom.INode
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// substringData
				/// </java-name>
				[Dot42.DexImport("substringData", "(II)Ljava/lang/String;", AccessFlags = 1025)]
				string SubstringData(int int32, int int321) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// appendData
				/// </java-name>
				[Dot42.DexImport("appendData", "(Ljava/lang/String;)V", AccessFlags = 1025)]
				void AppendData(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// insertData
				/// </java-name>
				[Dot42.DexImport("insertData", "(ILjava/lang/String;)V", AccessFlags = 1025)]
				void InsertData(int int32, string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// deleteData
				/// </java-name>
				[Dot42.DexImport("deleteData", "(II)V", AccessFlags = 1025)]
				void DeleteData(int int32, int int321) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// replaceData
				/// </java-name>
				[Dot42.DexImport("replaceData", "(IILjava/lang/String;)V", AccessFlags = 1025)]
				void ReplaceData(int int32, int int321, string @string) /* MethodBuilder.Create */ ;

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

				/// <java-name>
				/// getLength
				/// </java-name>
				int Length
				{
						[Dot42.DexImport("getLength", "()I", AccessFlags = 1025)]
						get;
				}

		}

		/// <java-name>
		/// org/w3c/dom/Comment
		/// </java-name>
		[Dot42.DexImport("org/w3c/dom/Comment", AccessFlags = 1537)]
		public partial interface IComment : global::Org.W3c.Dom.ICharacterData
 /* scope: __dot42__ */ 
		{
		}

		/// <java-name>
		/// org/w3c/dom/Document
		/// </java-name>
		[Dot42.DexImport("org/w3c/dom/Document", AccessFlags = 1537)]
		public partial interface IDocument : global::Org.W3c.Dom.INode
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// createElement
				/// </java-name>
				[Dot42.DexImport("createElement", "(Ljava/lang/String;)Lorg/w3c/dom/Element;", AccessFlags = 1025)]
				global::Org.W3c.Dom.IElement CreateElement(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// createDocumentFragment
				/// </java-name>
				[Dot42.DexImport("createDocumentFragment", "()Lorg/w3c/dom/DocumentFragment;", AccessFlags = 1025)]
				global::Org.W3c.Dom.IDocumentFragment CreateDocumentFragment() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// createTextNode
				/// </java-name>
				[Dot42.DexImport("createTextNode", "(Ljava/lang/String;)Lorg/w3c/dom/Text;", AccessFlags = 1025)]
				global::Org.W3c.Dom.IText CreateTextNode(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// createComment
				/// </java-name>
				[Dot42.DexImport("createComment", "(Ljava/lang/String;)Lorg/w3c/dom/Comment;", AccessFlags = 1025)]
				global::Org.W3c.Dom.IComment CreateComment(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// createCDATASection
				/// </java-name>
				[Dot42.DexImport("createCDATASection", "(Ljava/lang/String;)Lorg/w3c/dom/CDATASection;", AccessFlags = 1025)]
				global::Org.W3c.Dom.ICDATASection CreateCDATASection(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// createProcessingInstruction
				/// </java-name>
				[Dot42.DexImport("createProcessingInstruction", "(Ljava/lang/String;Ljava/lang/String;)Lorg/w3c/dom/ProcessingInstruction;", AccessFlags = 1025)]
				global::Org.W3c.Dom.IProcessingInstruction CreateProcessingInstruction(string @string, string string1) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// createAttribute
				/// </java-name>
				[Dot42.DexImport("createAttribute", "(Ljava/lang/String;)Lorg/w3c/dom/Attr;", AccessFlags = 1025)]
				global::Org.W3c.Dom.IAttr CreateAttribute(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// createEntityReference
				/// </java-name>
				[Dot42.DexImport("createEntityReference", "(Ljava/lang/String;)Lorg/w3c/dom/EntityReference;", AccessFlags = 1025)]
				global::Org.W3c.Dom.IEntityReference CreateEntityReference(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getElementsByTagName
				/// </java-name>
				[Dot42.DexImport("getElementsByTagName", "(Ljava/lang/String;)Lorg/w3c/dom/NodeList;", AccessFlags = 1025)]
				global::Org.W3c.Dom.INodeList GetElementsByTagName(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// importNode
				/// </java-name>
				[Dot42.DexImport("importNode", "(Lorg/w3c/dom/Node;Z)Lorg/w3c/dom/Node;", AccessFlags = 1025)]
				global::Org.W3c.Dom.INode ImportNode(global::Org.W3c.Dom.INode node, bool boolean) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// createElementNS
				/// </java-name>
				[Dot42.DexImport("createElementNS", "(Ljava/lang/String;Ljava/lang/String;)Lorg/w3c/dom/Element;", AccessFlags = 1025)]
				global::Org.W3c.Dom.IElement CreateElementNS(string @string, string string1) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// createAttributeNS
				/// </java-name>
				[Dot42.DexImport("createAttributeNS", "(Ljava/lang/String;Ljava/lang/String;)Lorg/w3c/dom/Attr;", AccessFlags = 1025)]
				global::Org.W3c.Dom.IAttr CreateAttributeNS(string @string, string string1) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getElementsByTagNameNS
				/// </java-name>
				[Dot42.DexImport("getElementsByTagNameNS", "(Ljava/lang/String;Ljava/lang/String;)Lorg/w3c/dom/NodeList;", AccessFlags = 1025)]
				global::Org.W3c.Dom.INodeList GetElementsByTagNameNS(string @string, string string1) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getElementById
				/// </java-name>
				[Dot42.DexImport("getElementById", "(Ljava/lang/String;)Lorg/w3c/dom/Element;", AccessFlags = 1025)]
				global::Org.W3c.Dom.IElement GetElementById(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// adoptNode
				/// </java-name>
				[Dot42.DexImport("adoptNode", "(Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;", AccessFlags = 1025)]
				global::Org.W3c.Dom.INode AdoptNode(global::Org.W3c.Dom.INode node) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// normalizeDocument
				/// </java-name>
				[Dot42.DexImport("normalizeDocument", "()V", AccessFlags = 1025)]
				void NormalizeDocument() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// renameNode
				/// </java-name>
				[Dot42.DexImport("renameNode", "(Lorg/w3c/dom/Node;Ljava/lang/String;Ljava/lang/String;)Lorg/w3c/dom/Node;", AccessFlags = 1025)]
				global::Org.W3c.Dom.INode RenameNode(global::Org.W3c.Dom.INode node, string @string, string string1) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getDoctype
				/// </java-name>
				global::Org.W3c.Dom.IDocumentType Doctype
				{
						[Dot42.DexImport("getDoctype", "()Lorg/w3c/dom/DocumentType;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getImplementation
				/// </java-name>
				global::Org.W3c.Dom.IDOMImplementation Implementation
				{
						[Dot42.DexImport("getImplementation", "()Lorg/w3c/dom/DOMImplementation;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getDocumentElement
				/// </java-name>
				global::Org.W3c.Dom.IElement DocumentElement
				{
						[Dot42.DexImport("getDocumentElement", "()Lorg/w3c/dom/Element;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getInputEncoding
				/// </java-name>
				string InputEncoding
				{
						[Dot42.DexImport("getInputEncoding", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getXmlEncoding
				/// </java-name>
				string XmlEncoding
				{
						[Dot42.DexImport("getXmlEncoding", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

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

				/// <java-name>
				/// getDomConfig
				/// </java-name>
				global::Org.W3c.Dom.IDOMConfiguration DomConfig
				{
						[Dot42.DexImport("getDomConfig", "()Lorg/w3c/dom/DOMConfiguration;", AccessFlags = 1025)]
						get;
				}

		}

		/// <java-name>
		/// org/w3c/dom/DocumentFragment
		/// </java-name>
		[Dot42.DexImport("org/w3c/dom/DocumentFragment", AccessFlags = 1537)]
		public partial interface IDocumentFragment : global::Org.W3c.Dom.INode
 /* scope: __dot42__ */ 
		{
		}

		/// <java-name>
		/// org/w3c/dom/DocumentType
		/// </java-name>
		[Dot42.DexImport("org/w3c/dom/DocumentType", AccessFlags = 1537)]
		public partial interface IDocumentType : global::Org.W3c.Dom.INode
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// getName
				/// </java-name>
				string Name
				{
						[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getEntities
				/// </java-name>
				global::Org.W3c.Dom.INamedNodeMap Entities
				{
						[Dot42.DexImport("getEntities", "()Lorg/w3c/dom/NamedNodeMap;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getNotations
				/// </java-name>
				global::Org.W3c.Dom.INamedNodeMap Notations
				{
						[Dot42.DexImport("getNotations", "()Lorg/w3c/dom/NamedNodeMap;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getPublicId
				/// </java-name>
				string PublicId
				{
						[Dot42.DexImport("getPublicId", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getSystemId
				/// </java-name>
				string SystemId
				{
						[Dot42.DexImport("getSystemId", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getInternalSubset
				/// </java-name>
				string InternalSubset
				{
						[Dot42.DexImport("getInternalSubset", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

		}

		/// <java-name>
		/// org/w3c/dom/DOMConfiguration
		/// </java-name>
		[Dot42.DexImport("org/w3c/dom/DOMConfiguration", AccessFlags = 1537)]
		public partial interface IDOMConfiguration
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// setParameter
				/// </java-name>
				[Dot42.DexImport("setParameter", "(Ljava/lang/String;Ljava/lang/Object;)V", AccessFlags = 1025)]
				void SetParameter(string @string, object @object) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getParameter
				/// </java-name>
				[Dot42.DexImport("getParameter", "(Ljava/lang/String;)Ljava/lang/Object;", AccessFlags = 1025)]
				object GetParameter(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// canSetParameter
				/// </java-name>
				[Dot42.DexImport("canSetParameter", "(Ljava/lang/String;Ljava/lang/Object;)Z", AccessFlags = 1025)]
				bool CanSetParameter(string @string, object @object) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getParameterNames
				/// </java-name>
				global::Org.W3c.Dom.IDOMStringList ParameterNames
				{
						[Dot42.DexImport("getParameterNames", "()Lorg/w3c/dom/DOMStringList;", AccessFlags = 1025)]
						get;
				}

		}

		/// <java-name>
		/// org/w3c/dom/DOMError
		/// </java-name>
		[Dot42.DexImport("org/w3c/dom/DOMError", AccessFlags = 1537)]
		public partial interface IDOMError
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// getSeverity
				/// </java-name>
				short Severity
				{
						[Dot42.DexImport("getSeverity", "()S", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getMessage
				/// </java-name>
				string Message
				{
						[Dot42.DexImport("getMessage", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getType
				/// </java-name>
				string Type
				{
						[Dot42.DexImport("getType", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getRelatedException
				/// </java-name>
				object RelatedException
				{
						[Dot42.DexImport("getRelatedException", "()Ljava/lang/Object;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getRelatedData
				/// </java-name>
				object RelatedData
				{
						[Dot42.DexImport("getRelatedData", "()Ljava/lang/Object;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getLocation
				/// </java-name>
				global::Org.W3c.Dom.IDOMLocator Location
				{
						[Dot42.DexImport("getLocation", "()Lorg/w3c/dom/DOMLocator;", AccessFlags = 1025)]
						get;
				}

		}

		/// <java-name>
		/// org/w3c/dom/DOMError
		/// </java-name>
		[Dot42.DexImport("org/w3c/dom/DOMError", AccessFlags = 1537, IgnoreFromJava = true, Priority = 1)]
		public static partial class IDOMErrorConstants
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// SEVERITY_WARNING
				/// </java-name>
				[Dot42.DexImport("SEVERITY_WARNING", "S", AccessFlags = 25)]
				public const short SEVERITY_WARNING = 1;
				/// <java-name>
				/// SEVERITY_ERROR
				/// </java-name>
				[Dot42.DexImport("SEVERITY_ERROR", "S", AccessFlags = 25)]
				public const short SEVERITY_ERROR = 2;
				/// <java-name>
				/// SEVERITY_FATAL_ERROR
				/// </java-name>
				[Dot42.DexImport("SEVERITY_FATAL_ERROR", "S", AccessFlags = 25)]
				public const short SEVERITY_FATAL_ERROR = 3;
		}

		/// <java-name>
		/// org/w3c/dom/DOMErrorHandler
		/// </java-name>
		[Dot42.DexImport("org/w3c/dom/DOMErrorHandler", AccessFlags = 1537)]
		public partial interface IDOMErrorHandler
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// handleError
				/// </java-name>
				[Dot42.DexImport("handleError", "(Lorg/w3c/dom/DOMError;)Z", AccessFlags = 1025)]
				bool HandleError(global::Org.W3c.Dom.IDOMError dOMError) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// org/w3c/dom/DOMImplementation
		/// </java-name>
		[Dot42.DexImport("org/w3c/dom/DOMImplementation", AccessFlags = 1537)]
		public partial interface IDOMImplementation
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// hasFeature
				/// </java-name>
				[Dot42.DexImport("hasFeature", "(Ljava/lang/String;Ljava/lang/String;)Z", AccessFlags = 1025)]
				bool HasFeature(string @string, string string1) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// createDocumentType
				/// </java-name>
				[Dot42.DexImport("createDocumentType", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lorg/w3c/dom/DocumentType" +
    ";", AccessFlags = 1025)]
				global::Org.W3c.Dom.IDocumentType CreateDocumentType(string @string, string string1, string string2) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// createDocument
				/// </java-name>
				[Dot42.DexImport("createDocument", "(Ljava/lang/String;Ljava/lang/String;Lorg/w3c/dom/DocumentType;)Lorg/w3c/dom/Docu" +
    "ment;", AccessFlags = 1025)]
				global::Org.W3c.Dom.IDocument CreateDocument(string @string, string string1, global::Org.W3c.Dom.IDocumentType documentType) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getFeature
				/// </java-name>
				[Dot42.DexImport("getFeature", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/Object;", AccessFlags = 1025)]
				object GetFeature(string @string, string string1) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// org/w3c/dom/DOMImplementationList
		/// </java-name>
		[Dot42.DexImport("org/w3c/dom/DOMImplementationList", AccessFlags = 1537)]
		public partial interface IDOMImplementationList
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// item
				/// </java-name>
				[Dot42.DexImport("item", "(I)Lorg/w3c/dom/DOMImplementation;", AccessFlags = 1025)]
				global::Org.W3c.Dom.IDOMImplementation Item(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getLength
				/// </java-name>
				int Length
				{
						[Dot42.DexImport("getLength", "()I", AccessFlags = 1025)]
						get;
				}

		}

		/// <java-name>
		/// org/w3c/dom/DOMImplementationSource
		/// </java-name>
		[Dot42.DexImport("org/w3c/dom/DOMImplementationSource", AccessFlags = 1537)]
		public partial interface IDOMImplementationSource
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// getDOMImplementation
				/// </java-name>
				[Dot42.DexImport("getDOMImplementation", "(Ljava/lang/String;)Lorg/w3c/dom/DOMImplementation;", AccessFlags = 1025)]
				global::Org.W3c.Dom.IDOMImplementation GetDOMImplementation(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getDOMImplementationList
				/// </java-name>
				[Dot42.DexImport("getDOMImplementationList", "(Ljava/lang/String;)Lorg/w3c/dom/DOMImplementationList;", AccessFlags = 1025)]
				global::Org.W3c.Dom.IDOMImplementationList GetDOMImplementationList(string @string) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// org/w3c/dom/DOMLocator
		/// </java-name>
		[Dot42.DexImport("org/w3c/dom/DOMLocator", AccessFlags = 1537)]
		public partial interface IDOMLocator
 /* scope: __dot42__ */ 
		{
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
				/// getByteOffset
				/// </java-name>
				int ByteOffset
				{
						[Dot42.DexImport("getByteOffset", "()I", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getUtf16Offset
				/// </java-name>
				int Utf16Offset
				{
						[Dot42.DexImport("getUtf16Offset", "()I", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getRelatedNode
				/// </java-name>
				global::Org.W3c.Dom.INode RelatedNode
				{
						[Dot42.DexImport("getRelatedNode", "()Lorg/w3c/dom/Node;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getUri
				/// </java-name>
				string Uri
				{
						[Dot42.DexImport("getUri", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

		}

		/// <java-name>
		/// org/w3c/dom/DOMStringList
		/// </java-name>
		[Dot42.DexImport("org/w3c/dom/DOMStringList", AccessFlags = 1537)]
		public partial interface IDOMStringList
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// item
				/// </java-name>
				[Dot42.DexImport("item", "(I)Ljava/lang/String;", AccessFlags = 1025)]
				string Item(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// contains
				/// </java-name>
				[Dot42.DexImport("contains", "(Ljava/lang/String;)Z", AccessFlags = 1025)]
				bool Contains(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getLength
				/// </java-name>
				int Length
				{
						[Dot42.DexImport("getLength", "()I", AccessFlags = 1025)]
						get;
				}

		}

		/// <java-name>
		/// org/w3c/dom/Element
		/// </java-name>
		[Dot42.DexImport("org/w3c/dom/Element", AccessFlags = 1537)]
		public partial interface IElement : global::Org.W3c.Dom.INode
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// getAttribute
				/// </java-name>
				[Dot42.DexImport("getAttribute", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1025)]
				string GetAttribute(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setAttribute
				/// </java-name>
				[Dot42.DexImport("setAttribute", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1025)]
				void SetAttribute(string @string, string string1) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// removeAttribute
				/// </java-name>
				[Dot42.DexImport("removeAttribute", "(Ljava/lang/String;)V", AccessFlags = 1025)]
				void RemoveAttribute(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getAttributeNode
				/// </java-name>
				[Dot42.DexImport("getAttributeNode", "(Ljava/lang/String;)Lorg/w3c/dom/Attr;", AccessFlags = 1025)]
				global::Org.W3c.Dom.IAttr GetAttributeNode(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setAttributeNode
				/// </java-name>
				[Dot42.DexImport("setAttributeNode", "(Lorg/w3c/dom/Attr;)Lorg/w3c/dom/Attr;", AccessFlags = 1025)]
				global::Org.W3c.Dom.IAttr SetAttributeNode(global::Org.W3c.Dom.IAttr attr) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// removeAttributeNode
				/// </java-name>
				[Dot42.DexImport("removeAttributeNode", "(Lorg/w3c/dom/Attr;)Lorg/w3c/dom/Attr;", AccessFlags = 1025)]
				global::Org.W3c.Dom.IAttr RemoveAttributeNode(global::Org.W3c.Dom.IAttr attr) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getElementsByTagName
				/// </java-name>
				[Dot42.DexImport("getElementsByTagName", "(Ljava/lang/String;)Lorg/w3c/dom/NodeList;", AccessFlags = 1025)]
				global::Org.W3c.Dom.INodeList GetElementsByTagName(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getAttributeNS
				/// </java-name>
				[Dot42.DexImport("getAttributeNS", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1025)]
				string GetAttributeNS(string @string, string string1) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setAttributeNS
				/// </java-name>
				[Dot42.DexImport("setAttributeNS", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1025)]
				void SetAttributeNS(string @string, string string1, string string2) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// removeAttributeNS
				/// </java-name>
				[Dot42.DexImport("removeAttributeNS", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1025)]
				void RemoveAttributeNS(string @string, string string1) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getAttributeNodeNS
				/// </java-name>
				[Dot42.DexImport("getAttributeNodeNS", "(Ljava/lang/String;Ljava/lang/String;)Lorg/w3c/dom/Attr;", AccessFlags = 1025)]
				global::Org.W3c.Dom.IAttr GetAttributeNodeNS(string @string, string string1) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setAttributeNodeNS
				/// </java-name>
				[Dot42.DexImport("setAttributeNodeNS", "(Lorg/w3c/dom/Attr;)Lorg/w3c/dom/Attr;", AccessFlags = 1025)]
				global::Org.W3c.Dom.IAttr SetAttributeNodeNS(global::Org.W3c.Dom.IAttr attr) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getElementsByTagNameNS
				/// </java-name>
				[Dot42.DexImport("getElementsByTagNameNS", "(Ljava/lang/String;Ljava/lang/String;)Lorg/w3c/dom/NodeList;", AccessFlags = 1025)]
				global::Org.W3c.Dom.INodeList GetElementsByTagNameNS(string @string, string string1) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// hasAttribute
				/// </java-name>
				[Dot42.DexImport("hasAttribute", "(Ljava/lang/String;)Z", AccessFlags = 1025)]
				bool HasAttribute(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// hasAttributeNS
				/// </java-name>
				[Dot42.DexImport("hasAttributeNS", "(Ljava/lang/String;Ljava/lang/String;)Z", AccessFlags = 1025)]
				bool HasAttributeNS(string @string, string string1) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setIdAttribute
				/// </java-name>
				[Dot42.DexImport("setIdAttribute", "(Ljava/lang/String;Z)V", AccessFlags = 1025)]
				void SetIdAttribute(string @string, bool boolean) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setIdAttributeNS
				/// </java-name>
				[Dot42.DexImport("setIdAttributeNS", "(Ljava/lang/String;Ljava/lang/String;Z)V", AccessFlags = 1025)]
				void SetIdAttributeNS(string @string, string string1, bool boolean) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setIdAttributeNode
				/// </java-name>
				[Dot42.DexImport("setIdAttributeNode", "(Lorg/w3c/dom/Attr;Z)V", AccessFlags = 1025)]
				void SetIdAttributeNode(global::Org.W3c.Dom.IAttr attr, bool boolean) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getTagName
				/// </java-name>
				string TagName
				{
						[Dot42.DexImport("getTagName", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getSchemaTypeInfo
				/// </java-name>
				global::Org.W3c.Dom.ITypeInfo SchemaTypeInfo
				{
						[Dot42.DexImport("getSchemaTypeInfo", "()Lorg/w3c/dom/TypeInfo;", AccessFlags = 1025)]
						get;
				}

		}

		/// <java-name>
		/// org/w3c/dom/Entity
		/// </java-name>
		[Dot42.DexImport("org/w3c/dom/Entity", AccessFlags = 1537)]
		public partial interface IEntity : global::Org.W3c.Dom.INode
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// getPublicId
				/// </java-name>
				string PublicId
				{
						[Dot42.DexImport("getPublicId", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getSystemId
				/// </java-name>
				string SystemId
				{
						[Dot42.DexImport("getSystemId", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getNotationName
				/// </java-name>
				string NotationName
				{
						[Dot42.DexImport("getNotationName", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getInputEncoding
				/// </java-name>
				string InputEncoding
				{
						[Dot42.DexImport("getInputEncoding", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getXmlEncoding
				/// </java-name>
				string XmlEncoding
				{
						[Dot42.DexImport("getXmlEncoding", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getXmlVersion
				/// </java-name>
				string XmlVersion
				{
						[Dot42.DexImport("getXmlVersion", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

		}

		/// <java-name>
		/// org/w3c/dom/EntityReference
		/// </java-name>
		[Dot42.DexImport("org/w3c/dom/EntityReference", AccessFlags = 1537)]
		public partial interface IEntityReference : global::Org.W3c.Dom.INode
 /* scope: __dot42__ */ 
		{
		}

		/// <java-name>
		/// org/w3c/dom/NamedNodeMap
		/// </java-name>
		[Dot42.DexImport("org/w3c/dom/NamedNodeMap", AccessFlags = 1537)]
		public partial interface INamedNodeMap
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// getNamedItem
				/// </java-name>
				[Dot42.DexImport("getNamedItem", "(Ljava/lang/String;)Lorg/w3c/dom/Node;", AccessFlags = 1025)]
				global::Org.W3c.Dom.INode GetNamedItem(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setNamedItem
				/// </java-name>
				[Dot42.DexImport("setNamedItem", "(Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;", AccessFlags = 1025)]
				global::Org.W3c.Dom.INode SetNamedItem(global::Org.W3c.Dom.INode node) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// removeNamedItem
				/// </java-name>
				[Dot42.DexImport("removeNamedItem", "(Ljava/lang/String;)Lorg/w3c/dom/Node;", AccessFlags = 1025)]
				global::Org.W3c.Dom.INode RemoveNamedItem(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// item
				/// </java-name>
				[Dot42.DexImport("item", "(I)Lorg/w3c/dom/Node;", AccessFlags = 1025)]
				global::Org.W3c.Dom.INode Item(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getNamedItemNS
				/// </java-name>
				[Dot42.DexImport("getNamedItemNS", "(Ljava/lang/String;Ljava/lang/String;)Lorg/w3c/dom/Node;", AccessFlags = 1025)]
				global::Org.W3c.Dom.INode GetNamedItemNS(string @string, string string1) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setNamedItemNS
				/// </java-name>
				[Dot42.DexImport("setNamedItemNS", "(Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;", AccessFlags = 1025)]
				global::Org.W3c.Dom.INode SetNamedItemNS(global::Org.W3c.Dom.INode node) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// removeNamedItemNS
				/// </java-name>
				[Dot42.DexImport("removeNamedItemNS", "(Ljava/lang/String;Ljava/lang/String;)Lorg/w3c/dom/Node;", AccessFlags = 1025)]
				global::Org.W3c.Dom.INode RemoveNamedItemNS(string @string, string string1) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getLength
				/// </java-name>
				int Length
				{
						[Dot42.DexImport("getLength", "()I", AccessFlags = 1025)]
						get;
				}

		}

		/// <java-name>
		/// org/w3c/dom/NameList
		/// </java-name>
		[Dot42.DexImport("org/w3c/dom/NameList", AccessFlags = 1537)]
		public partial interface INameList
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// getName
				/// </java-name>
				[Dot42.DexImport("getName", "(I)Ljava/lang/String;", AccessFlags = 1025)]
				string GetName(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getNamespaceURI
				/// </java-name>
				[Dot42.DexImport("getNamespaceURI", "(I)Ljava/lang/String;", AccessFlags = 1025)]
				string GetNamespaceURI(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// contains
				/// </java-name>
				[Dot42.DexImport("contains", "(Ljava/lang/String;)Z", AccessFlags = 1025)]
				bool Contains(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// containsNS
				/// </java-name>
				[Dot42.DexImport("containsNS", "(Ljava/lang/String;Ljava/lang/String;)Z", AccessFlags = 1025)]
				bool ContainsNS(string @string, string string1) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getLength
				/// </java-name>
				int Length
				{
						[Dot42.DexImport("getLength", "()I", AccessFlags = 1025)]
						get;
				}

		}

		/// <java-name>
		/// org/w3c/dom/Node
		/// </java-name>
		[Dot42.DexImport("org/w3c/dom/Node", AccessFlags = 1537)]
		public partial interface INode
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// insertBefore
				/// </java-name>
				[Dot42.DexImport("insertBefore", "(Lorg/w3c/dom/Node;Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;", AccessFlags = 1025)]
				global::Org.W3c.Dom.INode InsertBefore(global::Org.W3c.Dom.INode node, global::Org.W3c.Dom.INode node1) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// replaceChild
				/// </java-name>
				[Dot42.DexImport("replaceChild", "(Lorg/w3c/dom/Node;Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;", AccessFlags = 1025)]
				global::Org.W3c.Dom.INode ReplaceChild(global::Org.W3c.Dom.INode node, global::Org.W3c.Dom.INode node1) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// removeChild
				/// </java-name>
				[Dot42.DexImport("removeChild", "(Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;", AccessFlags = 1025)]
				global::Org.W3c.Dom.INode RemoveChild(global::Org.W3c.Dom.INode node) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// appendChild
				/// </java-name>
				[Dot42.DexImport("appendChild", "(Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;", AccessFlags = 1025)]
				global::Org.W3c.Dom.INode AppendChild(global::Org.W3c.Dom.INode node) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// cloneNode
				/// </java-name>
				[Dot42.DexImport("cloneNode", "(Z)Lorg/w3c/dom/Node;", AccessFlags = 1025)]
				global::Org.W3c.Dom.INode CloneNode(bool boolean) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// normalize
				/// </java-name>
				[Dot42.DexImport("normalize", "()V", AccessFlags = 1025)]
				void Normalize() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// isSupported
				/// </java-name>
				[Dot42.DexImport("isSupported", "(Ljava/lang/String;Ljava/lang/String;)Z", AccessFlags = 1025)]
				bool IsSupported(string @string, string string1) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// compareDocumentPosition
				/// </java-name>
				[Dot42.DexImport("compareDocumentPosition", "(Lorg/w3c/dom/Node;)S", AccessFlags = 1025)]
				short CompareDocumentPosition(global::Org.W3c.Dom.INode node) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// isSameNode
				/// </java-name>
				[Dot42.DexImport("isSameNode", "(Lorg/w3c/dom/Node;)Z", AccessFlags = 1025)]
				bool IsSameNode(global::Org.W3c.Dom.INode node) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// lookupPrefix
				/// </java-name>
				[Dot42.DexImport("lookupPrefix", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1025)]
				string LookupPrefix(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// isDefaultNamespace
				/// </java-name>
				[Dot42.DexImport("isDefaultNamespace", "(Ljava/lang/String;)Z", AccessFlags = 1025)]
				bool IsDefaultNamespace(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// lookupNamespaceURI
				/// </java-name>
				[Dot42.DexImport("lookupNamespaceURI", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1025)]
				string LookupNamespaceURI(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// isEqualNode
				/// </java-name>
				[Dot42.DexImport("isEqualNode", "(Lorg/w3c/dom/Node;)Z", AccessFlags = 1025)]
				bool IsEqualNode(global::Org.W3c.Dom.INode node) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getFeature
				/// </java-name>
				[Dot42.DexImport("getFeature", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/Object;", AccessFlags = 1025)]
				object GetFeature(string @string, string string1) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setUserData
				/// </java-name>
				[Dot42.DexImport("setUserData", "(Ljava/lang/String;Ljava/lang/Object;Lorg/w3c/dom/UserDataHandler;)Ljava/lang/Obj" +
    "ect;", AccessFlags = 1025)]
				object SetUserData(string @string, object @object, global::Org.W3c.Dom.IUserDataHandler userDataHandler) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getUserData
				/// </java-name>
				[Dot42.DexImport("getUserData", "(Ljava/lang/String;)Ljava/lang/Object;", AccessFlags = 1025)]
				object GetUserData(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getNodeName
				/// </java-name>
				string NodeName
				{
						[Dot42.DexImport("getNodeName", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

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

				/// <java-name>
				/// getNodeType
				/// </java-name>
				short NodeType
				{
						[Dot42.DexImport("getNodeType", "()S", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getParentNode
				/// </java-name>
				global::Org.W3c.Dom.INode ParentNode
				{
						[Dot42.DexImport("getParentNode", "()Lorg/w3c/dom/Node;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getChildNodes
				/// </java-name>
				global::Org.W3c.Dom.INodeList ChildNodes
				{
						[Dot42.DexImport("getChildNodes", "()Lorg/w3c/dom/NodeList;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getFirstChild
				/// </java-name>
				global::Org.W3c.Dom.INode FirstChild
				{
						[Dot42.DexImport("getFirstChild", "()Lorg/w3c/dom/Node;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getLastChild
				/// </java-name>
				global::Org.W3c.Dom.INode LastChild
				{
						[Dot42.DexImport("getLastChild", "()Lorg/w3c/dom/Node;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getPreviousSibling
				/// </java-name>
				global::Org.W3c.Dom.INode PreviousSibling
				{
						[Dot42.DexImport("getPreviousSibling", "()Lorg/w3c/dom/Node;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getNextSibling
				/// </java-name>
				global::Org.W3c.Dom.INode NextSibling
				{
						[Dot42.DexImport("getNextSibling", "()Lorg/w3c/dom/Node;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getAttributes
				/// </java-name>
				global::Org.W3c.Dom.INamedNodeMap Attributes
				{
						[Dot42.DexImport("getAttributes", "()Lorg/w3c/dom/NamedNodeMap;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getOwnerDocument
				/// </java-name>
				global::Org.W3c.Dom.IDocument OwnerDocument
				{
						[Dot42.DexImport("getOwnerDocument", "()Lorg/w3c/dom/Document;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// hasChildNodes
				/// </java-name>
				bool HasChildNodes
				{
						[Dot42.DexImport("hasChildNodes", "()Z", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getNamespaceURI
				/// </java-name>
				string NamespaceURI
				{
						[Dot42.DexImport("getNamespaceURI", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

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

				/// <java-name>
				/// getLocalName
				/// </java-name>
				string LocalName
				{
						[Dot42.DexImport("getLocalName", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// hasAttributes
				/// </java-name>
				bool HasAttributes
				{
						[Dot42.DexImport("hasAttributes", "()Z", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getBaseURI
				/// </java-name>
				string BaseURI
				{
						[Dot42.DexImport("getBaseURI", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

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

		/// <java-name>
		/// org/w3c/dom/Node
		/// </java-name>
		[Dot42.DexImport("org/w3c/dom/Node", AccessFlags = 1537, IgnoreFromJava = true, Priority = 1)]
		public static partial class INodeConstants
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// ELEMENT_NODE
				/// </java-name>
				[Dot42.DexImport("ELEMENT_NODE", "S", AccessFlags = 25)]
				public const short ELEMENT_NODE = 1;
				/// <java-name>
				/// ATTRIBUTE_NODE
				/// </java-name>
				[Dot42.DexImport("ATTRIBUTE_NODE", "S", AccessFlags = 25)]
				public const short ATTRIBUTE_NODE = 2;
				/// <java-name>
				/// TEXT_NODE
				/// </java-name>
				[Dot42.DexImport("TEXT_NODE", "S", AccessFlags = 25)]
				public const short TEXT_NODE = 3;
				/// <java-name>
				/// CDATA_SECTION_NODE
				/// </java-name>
				[Dot42.DexImport("CDATA_SECTION_NODE", "S", AccessFlags = 25)]
				public const short CDATA_SECTION_NODE = 4;
				/// <java-name>
				/// ENTITY_REFERENCE_NODE
				/// </java-name>
				[Dot42.DexImport("ENTITY_REFERENCE_NODE", "S", AccessFlags = 25)]
				public const short ENTITY_REFERENCE_NODE = 5;
				/// <java-name>
				/// ENTITY_NODE
				/// </java-name>
				[Dot42.DexImport("ENTITY_NODE", "S", AccessFlags = 25)]
				public const short ENTITY_NODE = 6;
				/// <java-name>
				/// PROCESSING_INSTRUCTION_NODE
				/// </java-name>
				[Dot42.DexImport("PROCESSING_INSTRUCTION_NODE", "S", AccessFlags = 25)]
				public const short PROCESSING_INSTRUCTION_NODE = 7;
				/// <java-name>
				/// COMMENT_NODE
				/// </java-name>
				[Dot42.DexImport("COMMENT_NODE", "S", AccessFlags = 25)]
				public const short COMMENT_NODE = 8;
				/// <java-name>
				/// DOCUMENT_NODE
				/// </java-name>
				[Dot42.DexImport("DOCUMENT_NODE", "S", AccessFlags = 25)]
				public const short DOCUMENT_NODE = 9;
				/// <java-name>
				/// DOCUMENT_TYPE_NODE
				/// </java-name>
				[Dot42.DexImport("DOCUMENT_TYPE_NODE", "S", AccessFlags = 25)]
				public const short DOCUMENT_TYPE_NODE = 10;
				/// <java-name>
				/// DOCUMENT_FRAGMENT_NODE
				/// </java-name>
				[Dot42.DexImport("DOCUMENT_FRAGMENT_NODE", "S", AccessFlags = 25)]
				public const short DOCUMENT_FRAGMENT_NODE = 11;
				/// <java-name>
				/// NOTATION_NODE
				/// </java-name>
				[Dot42.DexImport("NOTATION_NODE", "S", AccessFlags = 25)]
				public const short NOTATION_NODE = 12;
				/// <java-name>
				/// DOCUMENT_POSITION_DISCONNECTED
				/// </java-name>
				[Dot42.DexImport("DOCUMENT_POSITION_DISCONNECTED", "S", AccessFlags = 25)]
				public const short DOCUMENT_POSITION_DISCONNECTED = 1;
				/// <java-name>
				/// DOCUMENT_POSITION_PRECEDING
				/// </java-name>
				[Dot42.DexImport("DOCUMENT_POSITION_PRECEDING", "S", AccessFlags = 25)]
				public const short DOCUMENT_POSITION_PRECEDING = 2;
				/// <java-name>
				/// DOCUMENT_POSITION_FOLLOWING
				/// </java-name>
				[Dot42.DexImport("DOCUMENT_POSITION_FOLLOWING", "S", AccessFlags = 25)]
				public const short DOCUMENT_POSITION_FOLLOWING = 4;
				/// <java-name>
				/// DOCUMENT_POSITION_CONTAINS
				/// </java-name>
				[Dot42.DexImport("DOCUMENT_POSITION_CONTAINS", "S", AccessFlags = 25)]
				public const short DOCUMENT_POSITION_CONTAINS = 8;
				/// <java-name>
				/// DOCUMENT_POSITION_CONTAINED_BY
				/// </java-name>
				[Dot42.DexImport("DOCUMENT_POSITION_CONTAINED_BY", "S", AccessFlags = 25)]
				public const short DOCUMENT_POSITION_CONTAINED_BY = 16;
				/// <java-name>
				/// DOCUMENT_POSITION_IMPLEMENTATION_SPECIFIC
				/// </java-name>
				[Dot42.DexImport("DOCUMENT_POSITION_IMPLEMENTATION_SPECIFIC", "S", AccessFlags = 25)]
				public const short DOCUMENT_POSITION_IMPLEMENTATION_SPECIFIC = 32;
		}

		/// <java-name>
		/// org/w3c/dom/NodeList
		/// </java-name>
		[Dot42.DexImport("org/w3c/dom/NodeList", AccessFlags = 1537)]
		public partial interface INodeList
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// item
				/// </java-name>
				[Dot42.DexImport("item", "(I)Lorg/w3c/dom/Node;", AccessFlags = 1025)]
				global::Org.W3c.Dom.INode Item(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getLength
				/// </java-name>
				int Length
				{
						[Dot42.DexImport("getLength", "()I", AccessFlags = 1025)]
						get;
				}

		}

		/// <java-name>
		/// org/w3c/dom/Notation
		/// </java-name>
		[Dot42.DexImport("org/w3c/dom/Notation", AccessFlags = 1537)]
		public partial interface INotation : global::Org.W3c.Dom.INode
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// getPublicId
				/// </java-name>
				string PublicId
				{
						[Dot42.DexImport("getPublicId", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getSystemId
				/// </java-name>
				string SystemId
				{
						[Dot42.DexImport("getSystemId", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

		}

		/// <java-name>
		/// org/w3c/dom/ProcessingInstruction
		/// </java-name>
		[Dot42.DexImport("org/w3c/dom/ProcessingInstruction", AccessFlags = 1537)]
		public partial interface IProcessingInstruction : global::Org.W3c.Dom.INode
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// getTarget
				/// </java-name>
				string Target
				{
						[Dot42.DexImport("getTarget", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

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

		/// <java-name>
		/// org/w3c/dom/Text
		/// </java-name>
		[Dot42.DexImport("org/w3c/dom/Text", AccessFlags = 1537)]
		public partial interface IText : global::Org.W3c.Dom.ICharacterData
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// splitText
				/// </java-name>
				[Dot42.DexImport("splitText", "(I)Lorg/w3c/dom/Text;", AccessFlags = 1025)]
				global::Org.W3c.Dom.IText SplitText(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// replaceWholeText
				/// </java-name>
				[Dot42.DexImport("replaceWholeText", "(Ljava/lang/String;)Lorg/w3c/dom/Text;", AccessFlags = 1025)]
				global::Org.W3c.Dom.IText ReplaceWholeText(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// isElementContentWhitespace
				/// </java-name>
				bool IsElementContentWhitespace
				{
						[Dot42.DexImport("isElementContentWhitespace", "()Z", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getWholeText
				/// </java-name>
				string WholeText
				{
						[Dot42.DexImport("getWholeText", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

		}

		/// <java-name>
		/// org/w3c/dom/TypeInfo
		/// </java-name>
		[Dot42.DexImport("org/w3c/dom/TypeInfo", AccessFlags = 1537)]
		public partial interface ITypeInfo
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// isDerivedFrom
				/// </java-name>
				[Dot42.DexImport("isDerivedFrom", "(Ljava/lang/String;Ljava/lang/String;I)Z", AccessFlags = 1025)]
				bool IsDerivedFrom(string @string, string string1, int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getTypeName
				/// </java-name>
				string TypeName
				{
						[Dot42.DexImport("getTypeName", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getTypeNamespace
				/// </java-name>
				string TypeNamespace
				{
						[Dot42.DexImport("getTypeNamespace", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

		}

		/// <java-name>
		/// org/w3c/dom/TypeInfo
		/// </java-name>
		[Dot42.DexImport("org/w3c/dom/TypeInfo", AccessFlags = 1537, IgnoreFromJava = true, Priority = 1)]
		public static partial class ITypeInfoConstants
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// DERIVATION_RESTRICTION
				/// </java-name>
				[Dot42.DexImport("DERIVATION_RESTRICTION", "I", AccessFlags = 25)]
				public const int DERIVATION_RESTRICTION = 1;
				/// <java-name>
				/// DERIVATION_EXTENSION
				/// </java-name>
				[Dot42.DexImport("DERIVATION_EXTENSION", "I", AccessFlags = 25)]
				public const int DERIVATION_EXTENSION = 2;
				/// <java-name>
				/// DERIVATION_UNION
				/// </java-name>
				[Dot42.DexImport("DERIVATION_UNION", "I", AccessFlags = 25)]
				public const int DERIVATION_UNION = 4;
				/// <java-name>
				/// DERIVATION_LIST
				/// </java-name>
				[Dot42.DexImport("DERIVATION_LIST", "I", AccessFlags = 25)]
				public const int DERIVATION_LIST = 8;
		}

		/// <java-name>
		/// org/w3c/dom/UserDataHandler
		/// </java-name>
		[Dot42.DexImport("org/w3c/dom/UserDataHandler", AccessFlags = 1537)]
		public partial interface IUserDataHandler
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// handle
				/// </java-name>
				[Dot42.DexImport("handle", "(SLjava/lang/String;Ljava/lang/Object;Lorg/w3c/dom/Node;Lorg/w3c/dom/Node;)V", AccessFlags = 1025)]
				void Handle(short int16, string @string, object @object, global::Org.W3c.Dom.INode node, global::Org.W3c.Dom.INode node1) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// org/w3c/dom/UserDataHandler
		/// </java-name>
		[Dot42.DexImport("org/w3c/dom/UserDataHandler", AccessFlags = 1537, IgnoreFromJava = true, Priority = 1)]
		public static partial class IUserDataHandlerConstants
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// NODE_CLONED
				/// </java-name>
				[Dot42.DexImport("NODE_CLONED", "S", AccessFlags = 25)]
				public const short NODE_CLONED = 1;
				/// <java-name>
				/// NODE_IMPORTED
				/// </java-name>
				[Dot42.DexImport("NODE_IMPORTED", "S", AccessFlags = 25)]
				public const short NODE_IMPORTED = 2;
				/// <java-name>
				/// NODE_DELETED
				/// </java-name>
				[Dot42.DexImport("NODE_DELETED", "S", AccessFlags = 25)]
				public const short NODE_DELETED = 3;
				/// <java-name>
				/// NODE_RENAMED
				/// </java-name>
				[Dot42.DexImport("NODE_RENAMED", "S", AccessFlags = 25)]
				public const short NODE_RENAMED = 4;
				/// <java-name>
				/// NODE_ADOPTED
				/// </java-name>
				[Dot42.DexImport("NODE_ADOPTED", "S", AccessFlags = 25)]
				public const short NODE_ADOPTED = 5;
		}

}

