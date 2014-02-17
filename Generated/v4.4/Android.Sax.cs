// Copyright (C) 2014 dot42
//
// Original filename: Android.Sax.cs
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
namespace Android.Sax
{
		/// <summary>
		/// <para>Listens for the end of elements. </para>    
		/// </summary>
		/// <java-name>
		/// android/sax/EndElementListener
		/// </java-name>
		[Dot42.DexImport("android/sax/EndElementListener", AccessFlags = 1537)]
		public partial interface IEndElementListener
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Invoked at the end of an element. </para>        
				/// </summary>
				/// <java-name>
				/// end
				/// </java-name>
				[Dot42.DexImport("end", "()V", AccessFlags = 1025)]
				void End() /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>An XML element. Provides access to child elements and hooks to listen for events related to this element.</para><para><para>RootElement </para></para>    
		/// </summary>
		/// <java-name>
		/// android/sax/Element
		/// </java-name>
		[Dot42.DexImport("android/sax/Element", AccessFlags = 33)]
		public partial class Element
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal Element() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets the child element with the given name. Uses an empty string as the namespace. </para>        
				/// </summary>
				/// <java-name>
				/// getChild
				/// </java-name>
				[Dot42.DexImport("getChild", "(Ljava/lang/String;)Landroid/sax/Element;", AccessFlags = 1)]
				public virtual global::Android.Sax.Element GetChild(string localName) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Sax.Element);
				}

				/// <summary>
				/// <para>Gets the child element with the given name. </para>        
				/// </summary>
				/// <java-name>
				/// getChild
				/// </java-name>
				[Dot42.DexImport("getChild", "(Ljava/lang/String;Ljava/lang/String;)Landroid/sax/Element;", AccessFlags = 1)]
				public virtual global::Android.Sax.Element GetChild(string uri, string localName) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Sax.Element);
				}

				/// <summary>
				/// <para>Gets the child element with the given name. Uses an empty string as the namespace. We will throw a org.xml.sax.SAXException at parsing time if the specified child is missing. This helps you ensure that your listeners are called. </para>        
				/// </summary>
				/// <java-name>
				/// requireChild
				/// </java-name>
				[Dot42.DexImport("requireChild", "(Ljava/lang/String;)Landroid/sax/Element;", AccessFlags = 1)]
				public virtual global::Android.Sax.Element RequireChild(string localName) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Sax.Element);
				}

				/// <summary>
				/// <para>Gets the child element with the given name. We will throw a org.xml.sax.SAXException at parsing time if the specified child is missing. This helps you ensure that your listeners are called. </para>        
				/// </summary>
				/// <java-name>
				/// requireChild
				/// </java-name>
				[Dot42.DexImport("requireChild", "(Ljava/lang/String;Ljava/lang/String;)Landroid/sax/Element;", AccessFlags = 1)]
				public virtual global::Android.Sax.Element RequireChild(string uri, string localName) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Sax.Element);
				}

				/// <summary>
				/// <para>Sets start and end element listeners at the same time. </para>        
				/// </summary>
				/// <java-name>
				/// setElementListener
				/// </java-name>
				[Dot42.DexImport("setElementListener", "(Landroid/sax/ElementListener;)V", AccessFlags = 1)]
				public virtual void SetElementListener(global::Android.Sax.IElementListener elementListener) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets start and end text element listeners at the same time. </para>        
				/// </summary>
				/// <java-name>
				/// setTextElementListener
				/// </java-name>
				[Dot42.DexImport("setTextElementListener", "(Landroid/sax/TextElementListener;)V", AccessFlags = 1)]
				public virtual void SetTextElementListener(global::Android.Sax.ITextElementListener elementListener) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets a listener for the start of this element. </para>        
				/// </summary>
				/// <java-name>
				/// setStartElementListener
				/// </java-name>
				[Dot42.DexImport("setStartElementListener", "(Landroid/sax/StartElementListener;)V", AccessFlags = 1)]
				public virtual void SetStartElementListener(global::Android.Sax.IStartElementListener startElementListener) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets a listener for the end of this element. </para>        
				/// </summary>
				/// <java-name>
				/// setEndElementListener
				/// </java-name>
				[Dot42.DexImport("setEndElementListener", "(Landroid/sax/EndElementListener;)V", AccessFlags = 1)]
				public virtual void SetEndElementListener(global::Android.Sax.IEndElementListener endElementListener) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets a listener for the end of this text element. </para>        
				/// </summary>
				/// <java-name>
				/// setEndTextElementListener
				/// </java-name>
				[Dot42.DexImport("setEndTextElementListener", "(Landroid/sax/EndTextElementListener;)V", AccessFlags = 1)]
				public virtual void SetEndTextElementListener(global::Android.Sax.IEndTextElementListener endTextElementListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

		}

		/// <summary>
		/// <para>Listens for the beginning and ending of elements. </para>    
		/// </summary>
		/// <java-name>
		/// android/sax/ElementListener
		/// </java-name>
		[Dot42.DexImport("android/sax/ElementListener", AccessFlags = 1537)]
		public partial interface IElementListener : global::Android.Sax.IStartElementListener, global::Android.Sax.IEndElementListener
 /* scope: __dot42__ */ 
		{
		}

		/// <summary>
		/// <para>Listens for the end of text elements. </para>    
		/// </summary>
		/// <java-name>
		/// android/sax/EndTextElementListener
		/// </java-name>
		[Dot42.DexImport("android/sax/EndTextElementListener", AccessFlags = 1537)]
		public partial interface IEndTextElementListener
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Invoked at the end of a text element with the body of the element.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// end
				/// </java-name>
				[Dot42.DexImport("end", "(Ljava/lang/String;)V", AccessFlags = 1025)]
				void End(string body) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>Listens for the beginning and ending of text elements. </para>    
		/// </summary>
		/// <java-name>
		/// android/sax/TextElementListener
		/// </java-name>
		[Dot42.DexImport("android/sax/TextElementListener", AccessFlags = 1537)]
		public partial interface ITextElementListener : global::Android.Sax.IStartElementListener, global::Android.Sax.IEndTextElementListener
 /* scope: __dot42__ */ 
		{
		}

		/// <summary>
		/// <para>Listens for the beginning of elements. </para>    
		/// </summary>
		/// <java-name>
		/// android/sax/StartElementListener
		/// </java-name>
		[Dot42.DexImport("android/sax/StartElementListener", AccessFlags = 1537)]
		public partial interface IStartElementListener
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Invoked at the beginning of an element.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// start
				/// </java-name>
				[Dot42.DexImport("start", "(Lorg/xml/sax/Attributes;)V", AccessFlags = 1025)]
				void Start(global::Org.Xml.Sax.IAttributes attributes) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>The root XML element. The entry point for this API. Not safe for concurrent use.</para><para>For example, passing this XML:</para><para><pre>
		///    &lt;feed xmlns='&gt;
		///      &lt;entry&gt;
		///        &lt;id&gt;bob&lt;/id&gt;
		///      &lt;/entry&gt;
		///    &lt;/feed&gt;
		///    </pre></para><para>to this code:</para><para><pre>
		///    static final String ATOM_NAMESPACE = "http://www.w3.org/2005/Atom";
		/// 
		///    ...
		/// 
		///    RootElement root = new RootElement(ATOM_NAMESPACE, "feed");
		///    Element entry = root.getChild(ATOM_NAMESPACE, "entry");
		///    entry.getChild(ATOM_NAMESPACE, "id").setEndTextElementListener(
		///      new EndTextElementListener() {
		///        public void end(String body) {
		///          System.out.println("Entry ID: " + body);
		///        }
		///      });
		/// 
		///    XMLReader reader = ...;
		///    reader.setContentHandler(root.getContentHandler());
		///    reader.parse(...);
		///    </pre></para><para>would output:</para><para><pre>
		///    Entry ID: bob
		///    </pre> </para>    
		/// </summary>
		/// <java-name>
		/// android/sax/RootElement
		/// </java-name>
		[Dot42.DexImport("android/sax/RootElement", AccessFlags = 33)]
		public partial class RootElement : global::Android.Sax.Element
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs a new root element with the given name.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public RootElement(string uri, string localName) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs a new root element with the given name. Uses an empty string as the namespace.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public RootElement(string localName) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets the SAX <c> ContentHandler </c> . Pass this to your SAX parser. </para>        
				/// </summary>
				/// <java-name>
				/// getContentHandler
				/// </java-name>
				[Dot42.DexImport("getContentHandler", "()Lorg/xml/sax/ContentHandler;", AccessFlags = 1)]
				public virtual global::Org.Xml.Sax.IContentHandler GetContentHandler() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Xml.Sax.IContentHandler);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal RootElement() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Gets the SAX <c> ContentHandler </c> . Pass this to your SAX parser. </para>        
				/// </summary>
				/// <java-name>
				/// getContentHandler
				/// </java-name>
				public global::Org.Xml.Sax.IContentHandler ContentHandler
				{
				[Dot42.DexImport("getContentHandler", "()Lorg/xml/sax/ContentHandler;", AccessFlags = 1)]
						get{ return GetContentHandler(); }
				}

		}

}


