// Copyright (C) 2014 dot42
//
// Original filename: Javax.Xml.cs
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
namespace Javax.Xml
{
		/// <summary>
		/// <para>Utility class to contain basic XML values as constants.</para><para><para> </para><para></para><title>Revision:</title><para>584477 </para>, <title>Date:</title><para>2007-10-13 19:44:03 -0700 (Sat, 13 Oct 2007) </para><para> </para><simplesectsep></simplesectsep><para> </para><simplesectsep></simplesectsep><para> </para><simplesectsep></simplesectsep><para> </para><simplesectsep></simplesectsep><para> </para><simplesectsep></simplesectsep><para> </para><simplesectsep></simplesectsep><para> </para><para>1.5 </para></para>    
		/// </summary>
		/// <java-name>
		/// javax/xml/XMLConstants
		/// </java-name>
		[Dot42.DexImport("javax/xml/XMLConstants", AccessFlags = 49)]
		public sealed partial class XMLConstants
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Namespace URI to use to represent that there is no Namespace.</para><para>Defined by the Namespace specification to be "".</para><para><para> </para></para>        
				/// </summary>
				/// <java-name>
				/// NULL_NS_URI
				/// </java-name>
				[Dot42.DexImport("NULL_NS_URI", "Ljava/lang/String;", AccessFlags = 25)]
				public const string NULL_NS_URI = "";
				/// <summary>
				/// <para>Prefix to use to represent the default XML Namespace.</para><para>Defined by the XML specification to be "".</para><para><para> </para></para>        
				/// </summary>
				/// <java-name>
				/// DEFAULT_NS_PREFIX
				/// </java-name>
				[Dot42.DexImport("DEFAULT_NS_PREFIX", "Ljava/lang/String;", AccessFlags = 25)]
				public const string DEFAULT_NS_PREFIX = "";
				/// <summary>
				/// <para>The official XML Namespace name URI.</para><para>Defined by the XML specification to be "&lt;code&gt;http://www.w3.org/XML/1998/namespace&lt;/code&gt;".</para><para><para> </para></para>        
				/// </summary>
				/// <java-name>
				/// XML_NS_URI
				/// </java-name>
				[Dot42.DexImport("XML_NS_URI", "Ljava/lang/String;", AccessFlags = 25)]
				public const string XML_NS_URI = "http://www.w3.org/XML/1998/namespace";
				/// <summary>
				/// <para>The official XML Namespace prefix.</para><para>Defined by the XML specification to be "&lt;code&gt;xml&lt;/code&gt;".</para><para><para> </para></para>        
				/// </summary>
				/// <java-name>
				/// XML_NS_PREFIX
				/// </java-name>
				[Dot42.DexImport("XML_NS_PREFIX", "Ljava/lang/String;", AccessFlags = 25)]
				public const string XML_NS_PREFIX = "xml";
				/// <summary>
				/// <para>The official XML attribute used for specifying XML Namespace declarations, XMLConstants.XMLNS_ATTRIBUTE, Namespace name URI.</para><para>Defined by the XML specification to be "&lt;code&gt;http://www.w3.org/2000/xmlns/&lt;/code&gt;".</para><para><para> </para><simplesectsep></simplesectsep><para> </para></para>        
				/// </summary>
				/// <java-name>
				/// XMLNS_ATTRIBUTE_NS_URI
				/// </java-name>
				[Dot42.DexImport("XMLNS_ATTRIBUTE_NS_URI", "Ljava/lang/String;", AccessFlags = 25)]
				public const string XMLNS_ATTRIBUTE_NS_URI = "http://www.w3.org/2000/xmlns/";
				/// <summary>
				/// <para>The official XML attribute used for specifying XML Namespace declarations.</para><para>It is <b><b>NOT</b></b> valid to use as a prefix. Defined by the XML specification to be "&lt;code&gt;xmlns&lt;/code&gt;".</para><para><para> </para></para>        
				/// </summary>
				/// <java-name>
				/// XMLNS_ATTRIBUTE
				/// </java-name>
				[Dot42.DexImport("XMLNS_ATTRIBUTE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string XMLNS_ATTRIBUTE = "xmlns";
				/// <summary>
				/// <para>W3C XML Schema Namespace URI.</para><para>Defined to be "&lt;code&gt;http://www.w3.org/2001/XMLSchema&lt;/code&gt;".</para><para><para> </para></para>        
				/// </summary>
				/// <java-name>
				/// W3C_XML_SCHEMA_NS_URI
				/// </java-name>
				[Dot42.DexImport("W3C_XML_SCHEMA_NS_URI", "Ljava/lang/String;", AccessFlags = 25)]
				public const string W3C_XML_SCHEMA_NS_URI = "http://www.w3.org/2001/XMLSchema";
				/// <summary>
				/// <para>W3C XML Schema Instance Namespace URI.</para><para>Defined to be "&lt;code&gt;http://www.w3.org/2001/XMLSchema-instance&lt;/code&gt;".</para><para><para> </para></para>        
				/// </summary>
				/// <java-name>
				/// W3C_XML_SCHEMA_INSTANCE_NS_URI
				/// </java-name>
				[Dot42.DexImport("W3C_XML_SCHEMA_INSTANCE_NS_URI", "Ljava/lang/String;", AccessFlags = 25)]
				public const string W3C_XML_SCHEMA_INSTANCE_NS_URI = "http://www.w3.org/2001/XMLSchema-instance";
				/// <summary>
				/// <para>W3C XPath Datatype Namespace URI.</para><para>Defined to be "&lt;code&gt;http://www.w3.org/2003/11/xpath-datatypes&lt;/code&gt;".</para><para><para> </para></para>        
				/// </summary>
				/// <java-name>
				/// W3C_XPATH_DATATYPE_NS_URI
				/// </java-name>
				[Dot42.DexImport("W3C_XPATH_DATATYPE_NS_URI", "Ljava/lang/String;", AccessFlags = 25)]
				public const string W3C_XPATH_DATATYPE_NS_URI = "http://www.w3.org/2003/11/xpath-datatypes";
				/// <summary>
				/// <para>XML Document Type Declaration Namespace URI as an arbitrary value.</para><para>Since not formally defined by any existing standard, arbitrarily define to be "&lt;code&gt;http://www.w3.org/TR/REC-xml&lt;/code&gt;". </para>        
				/// </summary>
				/// <java-name>
				/// XML_DTD_NS_URI
				/// </java-name>
				[Dot42.DexImport("XML_DTD_NS_URI", "Ljava/lang/String;", AccessFlags = 25)]
				public const string XML_DTD_NS_URI = "http://www.w3.org/TR/REC-xml";
				/// <summary>
				/// <para>RELAX NG Namespace URI.</para><para>Defined to be "&lt;code&gt;http://relaxng.org/ns/structure/1.0&lt;/code&gt;".</para><para><para> </para></para>        
				/// </summary>
				/// <java-name>
				/// RELAXNG_NS_URI
				/// </java-name>
				[Dot42.DexImport("RELAXNG_NS_URI", "Ljava/lang/String;", AccessFlags = 25)]
				public const string RELAXNG_NS_URI = "http://relaxng.org/ns/structure/1.0";
				/// <summary>
				/// <para>Feature for secure processing.</para><para><ul><li><para><code>true</code> instructs the implementation to process XML securely. This may set limits on XML constructs to avoid conditions such as denial of service attacks.  </para></li><li><para><code>false</code> instructs the implementation to process XML according to the letter of the XML specifications ignoring security issues such as limits on XML constructs to avoid conditions such as denial of service attacks.  </para></li></ul></para>        
				/// </summary>
				/// <java-name>
				/// FEATURE_SECURE_PROCESSING
				/// </java-name>
				[Dot42.DexImport("FEATURE_SECURE_PROCESSING", "Ljava/lang/String;", AccessFlags = 25)]
				public const string FEATURE_SECURE_PROCESSING = "http://javax.xml.XMLConstants/feature/secure-processing";
				/// <summary>
				/// <para>Private constructor to prevent instantiation.</para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal XMLConstants() /* MethodBuilder.Create */ 
				{
				}

		}

}


