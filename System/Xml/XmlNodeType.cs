// Copyright (C) 2014 dot42
//
// Original filename: XmlNodeType.cs
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
namespace System.Xml
{
    /// <summary>
    /// Type of XML node.
    /// </summary>
    public enum XmlNodeType
    {
        /// <summary>This is returned by the <see cref="T:System.Xml.XmlReader" /> if a Read method has not been called.</summary>
        None,

        /// <summary>An element (for example, &lt;item&gt; ).</summary>
        Element,

        /// <summary>An attribute (for example, id='123' ).</summary>
        Attribute,

        /// <summary>The text content of a node.</summary>
        Text,

        /// <summary>A CDATA section (for example, &lt;![CDATA[my escaped text]]&gt; ).</summary>
        CDATA,

        /// <summary>A reference to an entity (for example, &amp;num; ).</summary>
        EntityReference,

        /// <summary>An entity declaration (for example, &lt;!ENTITY...&gt; ).</summary>
        Entity,

        /// <summary>A processing instruction (for example, &lt;?pi test?&gt; ).</summary>
        ProcessingInstruction,

        /// <summary>A comment (for example, &lt;!-- my comment --&gt; ).</summary>
        Comment,

        /// <summary>A document object that, as the root of the document tree, provides access to the entire XML document.</summary>
        Document,

        /// <summary>The document type declaration, indicated by the following tag (for example, &lt;!DOCTYPE...&gt; ).</summary>
        DocumentType,

        /// <summary>A document fragment.</summary>
        DocumentFragment,

        /// <summary>A notation in the document type declaration (for example, &lt;!NOTATION...&gt; ).</summary>
        Notation,

        /// <summary>White space between markup.</summary>
        Whitespace,

        /// <summary>White space between markup in a mixed content model or white space within the xml:space="preserve" scope.</summary>
        SignificantWhitespace,

        /// <summary>An end element tag (for example, &lt;/item&gt; ).</summary>
        EndElement,

        /// <summary>Returned when XmlReader gets to the end of the entity replacement as a result of a call to <see cref="M:System.Xml.XmlReader.ResolveEntity" />.</summary>
        EndEntity,

        /// <summary>The XML declaration (for example, &lt;?xml version='1.0'?&gt; ).</summary>
        XmlDeclaration
    }
}

