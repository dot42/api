#pragma warning disable 1717
namespace Javax.Xml.Transform.Dom
{
		/// <java-name>
		/// javax/xml/transform/dom/DOMResult
		/// </java-name>
		[Dot42.DexImport("javax/xml/transform/dom/DOMResult", AccessFlags = 33)]
		public partial class DOMResult : global::Javax.Xml.Transform.IResult
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// FEATURE
				/// </java-name>
				[Dot42.DexImport("FEATURE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string FEATURE = "http://javax.xml.transform.dom.DOMResult/feature";
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public DOMResult() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Lorg/w3c/dom/Node;)V", AccessFlags = 1)]
				public DOMResult(global::Org.W3c.Dom.INode node) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Lorg/w3c/dom/Node;Ljava/lang/String;)V", AccessFlags = 1)]
				public DOMResult(global::Org.W3c.Dom.INode node, string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Lorg/w3c/dom/Node;Lorg/w3c/dom/Node;)V", AccessFlags = 1)]
				public DOMResult(global::Org.W3c.Dom.INode node, global::Org.W3c.Dom.INode node1) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Lorg/w3c/dom/Node;Lorg/w3c/dom/Node;Ljava/lang/String;)V", AccessFlags = 1)]
				public DOMResult(global::Org.W3c.Dom.INode node, global::Org.W3c.Dom.INode node1, string @string) /* MethodBuilder.Create */ 
				{
				}

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

		/// <java-name>
		/// javax/xml/transform/dom/DOMSource
		/// </java-name>
		[Dot42.DexImport("javax/xml/transform/dom/DOMSource", AccessFlags = 33)]
		public partial class DOMSource : global::Javax.Xml.Transform.ISource
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// FEATURE
				/// </java-name>
				[Dot42.DexImport("FEATURE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string FEATURE = "http://javax.xml.transform.dom.DOMSource/feature";
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public DOMSource() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Lorg/w3c/dom/Node;)V", AccessFlags = 1)]
				public DOMSource(global::Org.W3c.Dom.INode node) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Lorg/w3c/dom/Node;Ljava/lang/String;)V", AccessFlags = 1)]
				public DOMSource(global::Org.W3c.Dom.INode node, string @string) /* MethodBuilder.Create */ 
				{
				}

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

		/// <java-name>
		/// javax/xml/transform/dom/DOMLocator
		/// </java-name>
		[Dot42.DexImport("javax/xml/transform/dom/DOMLocator", AccessFlags = 1537)]
		public partial interface IDOMLocator : global::Javax.Xml.Transform.ISourceLocator
 /* scope: __dot42__ */ 
		{
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

