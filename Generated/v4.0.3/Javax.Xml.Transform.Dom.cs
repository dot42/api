#pragma warning disable 1717
namespace Javax.Xml.Transform.Dom
{
		/// <summary>
		///  <para>Acts as a holder for a transformation result tree in the form of a Document Object Model (DOM) tree.</para> <para>If no output DOM source is set, the transformation will create a Document node as the holder for the result of the transformation, which may be retrieved with getNode().</para> <para> <para> </para> <para></para> <title>Revision</title> <para>569995 </para>,  <title>Date</title> <para>2007-08-26 21:31:06 -0700 (Sun, 26 Aug 2007) </para></para>    
		/// </summary>
		/// <java-name>
		/// javax/xml/transform/dom/DOMResult
		/// </java-name>
		[Dot42.DexImport("javax/xml/transform/dom/DOMResult", AccessFlags = 33)]
		public partial class DOMResult : global::Javax.Xml.Transform.IResult
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>If javax.xml.transform.TransformerFactory#getFeature returns  <code>true</code> when passed this value as an argument, the  <code>Transformer</code> supports  <code>Result</code> output of this type.</para>        
				/// </summary>
				/// <java-name>
				/// FEATURE
				/// </java-name>
				[Dot42.DexImport("FEATURE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string FEATURE = "http://javax.xml.transform.dom.DOMResult/feature";
				/// <summary>
				///  <para>Zero-argument default constructor.</para> <para> <code>node</code>,  <code>siblingNode</code> and  <code>systemId</code> will be set to  <code>null</code>.</para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public DOMResult() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Use a DOM node to create a new output target.</para> <para>In practice, the node should be a org.w3c.dom.Document node, a org.w3c.dom.DocumentFragment node, or a org.w3c.dom.Element node. In other words, a node that accepts children.</para> <para> <code>siblingNode</code> and  <code>systemId</code> will be set to  <code>null</code>.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Lorg/w3c/dom/Node;)V", AccessFlags = 1)]
				public DOMResult(global::Org.W3c.Dom.INode node) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Use a DOM node to create a new output target specifying the child node where the result nodes should be inserted before.</para> <para>In practice,  <code>node</code> and  <code>nextSibling</code> should be a org.w3c.dom.Document node, a org.w3c.dom.DocumentFragment node, or a org.w3c.dom.Element node. In other words, a node that accepts children.</para> <para>Use  <code>nextSibling</code> to specify the child node where the result nodes should be inserted before. If  <code>nextSibling</code> is not a sibling of  <code>node</code>, then an  <code>IllegalArgumentException</code> is thrown. If  <code>node</code> is  <code>null</code> and  <code>nextSibling</code> is not  <code>null</code>, then an  <code>IllegalArgumentException</code> is thrown. If  <code>nextSibling</code> is  <code>null</code>, then the behavior is the same as calling DOMResult(Node node), i.e. append the result nodes as the last child of the specified  <code>node</code>.</para> <para> <code>systemId</code> will be set to  <code>null</code>.</para> <para> <para>1.5 </para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Lorg/w3c/dom/Node;Ljava/lang/String;)V", AccessFlags = 1)]
				public DOMResult(global::Org.W3c.Dom.INode node, string nextSibling) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Use a DOM node to create a new output target specifying the child node where the result nodes should be inserted before.</para> <para>In practice,  <code>node</code> and  <code>nextSibling</code> should be a org.w3c.dom.Document node, a org.w3c.dom.DocumentFragment node, or a org.w3c.dom.Element node. In other words, a node that accepts children.</para> <para>Use  <code>nextSibling</code> to specify the child node where the result nodes should be inserted before. If  <code>nextSibling</code> is not a sibling of  <code>node</code>, then an  <code>IllegalArgumentException</code> is thrown. If  <code>node</code> is  <code>null</code> and  <code>nextSibling</code> is not  <code>null</code>, then an  <code>IllegalArgumentException</code> is thrown. If  <code>nextSibling</code> is  <code>null</code>, then the behavior is the same as calling DOMResult(Node node), i.e. append the result nodes as the last child of the specified  <code>node</code>.</para> <para> <code>systemId</code> will be set to  <code>null</code>.</para> <para> <para>1.5 </para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Lorg/w3c/dom/Node;Lorg/w3c/dom/Node;)V", AccessFlags = 1)]
				public DOMResult(global::Org.W3c.Dom.INode node, global::Org.W3c.Dom.INode nextSibling) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Use a DOM node to create a new output target specifying the child node where the result nodes should be inserted before and the specified System ID.</para> <para>In practice,  <code>node</code> and  <code>nextSibling</code> should be a org.w3c.dom.Document node, a org.w3c.dom.DocumentFragment node, or a org.w3c.dom.Element node. In other words, a node that accepts children.</para> <para>Use  <code>nextSibling</code> to specify the child node where the result nodes should be inserted before. If  <code>nextSibling</code> is not a sibling of  <code>node</code>, then an  <code>IllegalArgumentException</code> is thrown. If  <code>node</code> is  <code>null</code> and  <code>nextSibling</code> is not  <code>null</code>, then an  <code>IllegalArgumentException</code> is thrown. If  <code>nextSibling</code> is  <code>null</code>, then the behavior is the same as calling DOMResult(Node node, String systemId), i.e. append the result nodes as the last child of the specified node and use the specified System ID.</para> <para> <para>1.5 </para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Lorg/w3c/dom/Node;Lorg/w3c/dom/Node;Ljava/lang/String;)V", AccessFlags = 1)]
				public DOMResult(global::Org.W3c.Dom.INode node, global::Org.W3c.Dom.INode nextSibling, string systemId) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Get the node that will contain the result DOM tree.</para> <para>If no node was set via DOMResult(Node node), DOMResult(Node node, String systeId), DOMResult(Node node, Node nextSibling), DOMResult(Node node, Node nextSibling, String systemId) or setNode(Node node), then the node will be set by the transformation, and may be obtained from this method once the transformation is complete. Calling this method before the transformation will return  <code>null</code>.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The node to which the transformation will be appended. </para>
				/// </returns>
				/// <java-name>
				/// getNode
				/// </java-name>
				public virtual global::Org.W3c.Dom.INode Node
				{
						[Dot42.DexImport("getNode", "()Lorg/w3c/dom/Node;", AccessFlags = 1)]
						get{ return default(global::Org.W3c.Dom.INode); }
						[Dot42.DexImport("setNode", "(Lorg/w3c/dom/Node;)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Get the child node before which the result nodes will be inserted.</para> <para>If no node was set via DOMResult(Node node, Node nextSibling), DOMResult(Node node, Node nextSibling, String systemId) or setNextSibling(Node nextSibling), then  <code>null</code> will be returned.</para> <para> <para>1.5 </para></para>        
				/// </summary>
				/// <returns>
				///  <para>The child node before which the result nodes will be inserted.</para>
				/// </returns>
				/// <java-name>
				/// getNextSibling
				/// </java-name>
				public virtual global::Org.W3c.Dom.INode NextSibling
				{
						[Dot42.DexImport("getNextSibling", "()Lorg/w3c/dom/Node;", AccessFlags = 1)]
						get{ return default(global::Org.W3c.Dom.INode); }
						[Dot42.DexImport("setNextSibling", "(Lorg/w3c/dom/Node;)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Get the System Identifier.</para> <para>If no System ID was set via DOMResult(Node node, String systemId), DOMResult(Node node, Node nextSibling, String systemId) or setSystemId(String systemId), then  <code>null</code> will be returned.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The system identifier. </para>
				/// </returns>
				/// <java-name>
				/// getSystemId
				/// </java-name>
				public virtual string SystemId
				{
						[Dot42.DexImport("getSystemId", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
						[Dot42.DexImport("setSystemId", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ }
				}

		}

		/// <summary>
		///  <para>Acts as a holder for a transformation Source tree in the form of a Document Object Model (DOM) tree.</para> <para>Note that XSLT requires namespace support. Attempting to transform a DOM that was not contructed with a namespace-aware parser may result in errors. Parsers can be made namespace aware by calling javax.xml.parsers.DocumentBuilderFactory#setNamespaceAware(boolean awareness).</para> <para> <para> </para> <para></para> <title>Revision</title> <para>446598 </para>,  <title>Date</title> <para>2006-09-15 05:55:40 -0700 (Fri, 15 Sep 2006) </para> <para> </para></para>    
		/// </summary>
		/// <java-name>
		/// javax/xml/transform/dom/DOMSource
		/// </java-name>
		[Dot42.DexImport("javax/xml/transform/dom/DOMSource", AccessFlags = 33)]
		public partial class DOMSource : global::Javax.Xml.Transform.ISource
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>If javax.xml.transform.TransformerFactory#getFeature returns true when passed this value as an argument, the Transformer supports Source input of this type. </para>        
				/// </summary>
				/// <java-name>
				/// FEATURE
				/// </java-name>
				[Dot42.DexImport("FEATURE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string FEATURE = "http://javax.xml.transform.dom.DOMSource/feature";
				/// <summary>
				///  <para>Zero-argument default constructor. If this constructor is used, and no DOM source is set using setNode(Node node) , then the  <code>Transformer</code> will create an empty source org.w3c.dom.Document using javax.xml.parsers.DocumentBuilder#newDocument().</para> <para> <para>javax.xml.transform.Transformer::transform(Source xmlSource, Result outputTarget) </para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public DOMSource() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Create a new input source with a DOM node. The operation will be applied to the subtree rooted at this node. In XSLT, a "/" pattern still means the root of the tree (not the subtree), and the evaluation of global variables and parameters is done from the root node also.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Lorg/w3c/dom/Node;)V", AccessFlags = 1)]
				public DOMSource(global::Org.W3c.Dom.INode n) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Create a new input source with a DOM node, and with the system ID also passed in as the base URI.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Lorg/w3c/dom/Node;Ljava/lang/String;)V", AccessFlags = 1)]
				public DOMSource(global::Org.W3c.Dom.INode node, string systemID) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Get the node that represents a Source DOM tree.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The node that is to be transformed. </para>
				/// </returns>
				/// <java-name>
				/// getNode
				/// </java-name>
				public virtual global::Org.W3c.Dom.INode Node
				{
						[Dot42.DexImport("getNode", "()Lorg/w3c/dom/Node;", AccessFlags = 1)]
						get{ return default(global::Org.W3c.Dom.INode); }
						[Dot42.DexImport("setNode", "(Lorg/w3c/dom/Node;)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Get the base ID (URL or system ID) from where URLs will be resolved.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Base URL for this DOM tree. </para>
				/// </returns>
				/// <java-name>
				/// getSystemId
				/// </java-name>
				public virtual string SystemId
				{
						[Dot42.DexImport("getSystemId", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
						[Dot42.DexImport("setSystemId", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ }
				}

		}

		/// <summary>
		///  <para>Indicates the position of a node in a source DOM, intended primarily for error reporting. To use a DOMLocator, the receiver of an error must downcast the javax.xml.transform.SourceLocator object returned by an exception. A javax.xml.transform.Transformer may use this object for purposes other than error reporting, for instance, to indicate the source node that originated a result node. </para>    
		/// </summary>
		/// <java-name>
		/// javax/xml/transform/dom/DOMLocator
		/// </java-name>
		[Dot42.DexImport("javax/xml/transform/dom/DOMLocator", AccessFlags = 1537)]
		public partial interface IDOMLocator : global::Javax.Xml.Transform.ISourceLocator
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Return the node where the event occurred.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The node that is the location for the event. </para>
				/// </returns>
				/// <java-name>
				/// getOriginatingNode
				/// </java-name>
				global::Org.W3c.Dom.INode OriginatingNode
				{
						[Dot42.DexImport("getOriginatingNode", "()Lorg/w3c/dom/Node;", AccessFlags = 1025)]
						get;
				}

		}

}

