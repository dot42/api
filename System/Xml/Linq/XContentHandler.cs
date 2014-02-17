// Copyright (C) 2014 dot42
//
// Original filename: XContentHandler.cs
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
using System.Text;
using Java.Util;
using Org.Xml.Sax;

namespace System.Xml.Linq
{
	internal class XContentHandler : IContentHandler, IErrorHandler
	{
	    private readonly LoadOptions options;
	    private XDocument document;
        private readonly Stack<XElement> elementStack = new Stack<XElement>();

        /// <summary>
        /// Default ctor
        /// </summary>
        internal XContentHandler(LoadOptions options)
        {
            this.options = options;
        }

	    /// <summary>
        /// Gets the generated document.
        /// </summary>
	    internal XDocument Document
	    {
            get { return document; }
	    }

	    public void SetDocumentLocator(ILocator locator)
	    {
	    }

	    public void StartDocument()
	    {
            document = new XDocument();
	    }

	    public void EndDocument()
	    {
	    }

	    public void StartPrefixMapping(string prefix, string uri)
	    {
	    }

	    public void EndPrefixMapping(string prefix)
	    {
	    }

	    /// <summary>
	    /// <para>Receive notification of the beginning of an element.</para><para>The Parser will invoke this method at the beginning of every element in the XML document; there will be a corresponding endElement event for every startElement event (even when the element is empty). All of the element's content will be reported, in order, before the corresponding endElement event.</para><para>This event allows up to three name components for each element:</para><para><ol><li><para>the Namespace URI; </para></li><li><para>the local name; and </para></li><li><para>the qualified (prefixed) name. </para></li></ol></para><para>Any or all of these may be provided, depending on the values of the <b></b> and the <b></b> properties:</para><para><ul><li><para>the Namespace URI and local name are required when the namespaces property is <b>true</b> (the default), and are optional when the namespaces property is <b>false</b> (if one is specified, both must be); </para></li><li><para>the qualified name is required when the namespace-prefixes property is <b>true</b>, and is optional when the namespace-prefixes property is <b>false</b> (the default). </para></li></ul></para><para>Note that the attribute list provided will contain only attributes with explicit values (specified or defaulted): #IMPLIED attributes will be omitted. The attribute list will contain attributes used for Namespace declarations (xmlns* attributes) only if the <code></code> property is true (it is false by default, and support for a true value is optional).</para><para>Like characters(), attribute values may have characters that need more than one <code>char</code> value. </para><para><para>endElement </para><simplesectsep></simplesectsep><para>org.xml.sax.Attributes </para><simplesectsep></simplesectsep><para>org.xml.sax.helpers.AttributesImpl </para></para>        
	    /// </summary>
	    public void StartElement(string uri, string localName, string qName, IAttributes atts)
	    {
	        var element = new XElement(XName.Get(localName, uri));
	        var parent = elementStack.Empty() ? null : elementStack.Peek();
	        if (parent == null)
	        {
	            document.Add(element);
	        }
	        else
	        {
	            parent.Add(element);
	        }
	        var attrCount = atts.GetLength();
	        for (var i = 0; i < attrCount; i++)
	        {
	            var name = XName.Get(atts.GetLocalName(i), atts.GetURI(i));
	            var attr = new XAttribute(name, atts.GetValue(i));
	            element.Add(attr);
	        }
	        elementStack.Push(element);
	    }

	    public void EndElement(string uri, string localName, string qName)
	    {
	        elementStack.Pop();
	    }

	    public void Characters(char[] ch, int start, int length)
	    {
	        var element = elementStack.Peek();
	        if (element == null) return;

	        var lastTextNode = element.LastNode as XText;
            if (lastTextNode != null)
            {
                //append text
                var builder = new StringBuilder(lastTextNode.Value);
                builder.Append(ch, start, length);
                lastTextNode.Value = builder.ToString();
            }
            else
            {
                //add text
                var builder = new StringBuilder();
                builder.Append(ch, start, length);
                element.Add(new XText(builder.ToString()));
            }
	    }

	    public void IgnorableWhitespace(char[] ch, int start, int length)
	    {
	    }

	    public void ProcessingInstruction(string target, string data)
	    {
	    }

	    public void SkippedEntity(string name)
	    {
	    }

	    public void Warning(SAXParseException exception)
	    {
	    }

	    public void Error(SAXParseException exception)
	    {
	    }

	    public void FatalError(SAXParseException exception)
	    {
	    }
	}
}

