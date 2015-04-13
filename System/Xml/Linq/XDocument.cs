// Copyright (C) 2014 dot42
//
// Original filename: XDocument.cs
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
using System.IO;
using Java.IO;
using Org.Xmlpull.V1;

namespace System.Xml.Linq
{
    /// <summary>
    /// XML document
    /// </summary>
	public class XDocument : XContainer 
	{
        /// <summary>
        /// Default ctor
        /// </summary>
        public XDocument()
        {            
        }

        /// <summary>
        /// Default ctor
        /// </summary>
        public XDocument(params object[] content)
        {
            Add(content);
        }

        /// <summary>
        /// Copy ctor
        /// </summary>
        public XDocument(XDocument source)
            : base(source)
        {
        }

        /// <summary>
	    /// Gets the type of this node.
	    /// </summary>
	    public override XmlNodeType NodeType
        {
            get { return XmlNodeType.Document; }
        }

        /// <summary>
        /// Gets the root element of this document.
        /// </summary>
        public XElement Root
        {
            get
            {
                foreach (var node in Nodes())
                {
                    var element = node as XElement;
                    if (element != null)
                        return element;
                }
                return null;
            }
        }

        /// <summary>
        /// Parse the XML content in the given stream into a document.
        /// </summary>
        public static XDocument Load(Stream stream)
        {
            return Load(stream, LoadOptions.None);
        }

        /// <summary>
        /// Parse the XML content in the given stream into a document.
        /// </summary>
        public static XDocument Load(Stream stream, LoadOptions options)
        {
            var handler = new XContentHandler(options);
            Android.Util.Xml.Parse(new InputStreamReader(stream), handler);
            return handler.Document;            
        }

        /// <summary>
        /// Parse the XML content in the file with given path into a document.
        /// </summary>
        public static XDocument Load(string path)
        {
            return Load(path, LoadOptions.None);
        }

        /// <summary>
        /// Parse the XML content in the file with given path into a document.
        /// </summary>
        public static XDocument Load(string path, LoadOptions options)
        {
            var handler = new XContentHandler(options);
            Android.Util.Xml.Parse(new FileReader(path), handler);
            return handler.Document;
        }

        /// <summary>
        /// Parse the given XML string into a document.
        /// </summary>
        public static XDocument Parse(string xml)
        {
            return Parse(xml, LoadOptions.None);
        }

        /// <summary>
        /// Parse the given XML string into a document.
        /// </summary>
        public static XDocument Parse(string xml, LoadOptions options)
        {
            var handler = new XContentHandler(options);
            Android.Util.Xml.Parse(xml, handler);
            return handler.Document;
        }

        /// <summary>
        /// Save this document to the file with given path.
        /// </summary>
        public void Save(string path)
        {
            Save(path, SaveOptions.None);
        }

        /// <summary>
        /// Save this document to the file with given path.
        /// </summary>
        public void Save(string path, SaveOptions options)
        {
            var writer = new FileWriter(path);
            try
            {
                ToXml(writer, options);
            }
            finally
            {
                writer.Flush();
                writer.Close();
            }
        }

        /// <summary>
        /// Save this document to the given stream.
        /// </summary>
        public void Save(Stream stream)
        {
            Save(stream, SaveOptions.None);
        }

        /// <summary>
        /// Save this document to the given stream.
        /// </summary>
        public void Save(Stream stream, SaveOptions options)
        {
            ToXml(new OutputStreamWriter(stream), options);
        }

        /// <summary>
        /// Save this document to the given stream.
        /// </summary>
        public void Save(OutputStream stream)
        {
            Save(stream, SaveOptions.None);
        }

        /// <summary>
        /// Save this document to the given stream.
        /// </summary>
        public void Save(OutputStream stream, SaveOptions options)
        {
            ToXml(new OutputStreamWriter(stream), options);
        }

        /// <summary>
        /// Save this document to the given writer.
        /// </summary>
        public void Save(Writer writer)
        {
            Save(writer, SaveOptions.None);
        }

        /// <summary>
        /// Save this document to the given writer.
        /// </summary>
        public void Save(Writer writer, SaveOptions options)
        {
            ToXml(writer, options);
        }

        /// <summary>
        /// Create a clone of this node.
        /// </summary>
        internal override XNode Clone()
        {
            return new XDocument(this);
        }

        /// <summary>
        /// Serialize this object to the given serializer.
        /// </summary>
        public override void WriteTo(IXmlSerializer serializer)
        {
            serializer.StartDocument(null, Boolean.TRUE);
            var root = Root;
            if (root != null)
                root.WriteTo(serializer);
            serializer.EndDocument();
        }
    }
}

