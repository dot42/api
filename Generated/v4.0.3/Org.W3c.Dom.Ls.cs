#pragma warning disable 1717
namespace Org.W3c.Dom.Ls
{
		/// <java-name>
		/// org/w3c/dom/ls/DOMImplementationLS
		/// </java-name>
		[Dot42.DexImport("org/w3c/dom/ls/DOMImplementationLS", AccessFlags = 1537)]
		public partial interface IDOMImplementationLS
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// createLSParser
				/// </java-name>
				[Dot42.DexImport("createLSParser", "(SLjava/lang/String;)Lorg/w3c/dom/ls/LSParser;", AccessFlags = 1025)]
				global::Org.W3c.Dom.Ls.ILSParser CreateLSParser(short int16, string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// createLSSerializer
				/// </java-name>
				[Dot42.DexImport("createLSSerializer", "()Lorg/w3c/dom/ls/LSSerializer;", AccessFlags = 1025)]
				global::Org.W3c.Dom.Ls.ILSSerializer CreateLSSerializer() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// createLSInput
				/// </java-name>
				[Dot42.DexImport("createLSInput", "()Lorg/w3c/dom/ls/LSInput;", AccessFlags = 1025)]
				global::Org.W3c.Dom.Ls.ILSInput CreateLSInput() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// createLSOutput
				/// </java-name>
				[Dot42.DexImport("createLSOutput", "()Lorg/w3c/dom/ls/LSOutput;", AccessFlags = 1025)]
				global::Org.W3c.Dom.Ls.ILSOutput CreateLSOutput() /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// org/w3c/dom/ls/DOMImplementationLS
		/// </java-name>
		[Dot42.DexImport("org/w3c/dom/ls/DOMImplementationLS", AccessFlags = 1537, IgnoreFromJava = true, Priority = 1)]
		public static partial class IDOMImplementationLSConstants
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// MODE_SYNCHRONOUS
				/// </java-name>
				[Dot42.DexImport("MODE_SYNCHRONOUS", "S", AccessFlags = 25)]
				public const short MODE_SYNCHRONOUS = 1;
				/// <java-name>
				/// MODE_ASYNCHRONOUS
				/// </java-name>
				[Dot42.DexImport("MODE_ASYNCHRONOUS", "S", AccessFlags = 25)]
				public const short MODE_ASYNCHRONOUS = 2;
		}

		/// <java-name>
		/// org/w3c/dom/ls/LSInput
		/// </java-name>
		[Dot42.DexImport("org/w3c/dom/ls/LSInput", AccessFlags = 1537)]
		public partial interface ILSInput
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// getCharacterStream
				/// </java-name>
				global::Java.IO.Reader CharacterStream
				{
						[Dot42.DexImport("getCharacterStream", "()Ljava/io/Reader;", AccessFlags = 1025)]
						get;
						[Dot42.DexImport("setCharacterStream", "(Ljava/io/Reader;)V", AccessFlags = 1025)]
						set;
				}

				/// <java-name>
				/// getByteStream
				/// </java-name>
				global::Java.IO.InputStream ByteStream
				{
						[Dot42.DexImport("getByteStream", "()Ljava/io/InputStream;", AccessFlags = 1025)]
						get;
						[Dot42.DexImport("setByteStream", "(Ljava/io/InputStream;)V", AccessFlags = 1025)]
						set;
				}

				/// <java-name>
				/// getStringData
				/// </java-name>
				string StringData
				{
						[Dot42.DexImport("getStringData", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
						[Dot42.DexImport("setStringData", "(Ljava/lang/String;)V", AccessFlags = 1025)]
						set;
				}

				/// <java-name>
				/// getSystemId
				/// </java-name>
				string SystemId
				{
						[Dot42.DexImport("getSystemId", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
						[Dot42.DexImport("setSystemId", "(Ljava/lang/String;)V", AccessFlags = 1025)]
						set;
				}

				/// <java-name>
				/// getPublicId
				/// </java-name>
				string PublicId
				{
						[Dot42.DexImport("getPublicId", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
						[Dot42.DexImport("setPublicId", "(Ljava/lang/String;)V", AccessFlags = 1025)]
						set;
				}

				/// <java-name>
				/// getBaseURI
				/// </java-name>
				string BaseURI
				{
						[Dot42.DexImport("getBaseURI", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
						[Dot42.DexImport("setBaseURI", "(Ljava/lang/String;)V", AccessFlags = 1025)]
						set;
				}

				/// <java-name>
				/// getEncoding
				/// </java-name>
				string Encoding
				{
						[Dot42.DexImport("getEncoding", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
						[Dot42.DexImport("setEncoding", "(Ljava/lang/String;)V", AccessFlags = 1025)]
						set;
				}

				/// <java-name>
				/// getCertifiedText
				/// </java-name>
				bool IsCertifiedText
				{
						[Dot42.DexImport("getCertifiedText", "()Z", AccessFlags = 1025)]
						get;
						[Dot42.DexImport("setCertifiedText", "(Z)V", AccessFlags = 1025)]
						set;
				}

		}

		/// <java-name>
		/// org/w3c/dom/ls/LSOutput
		/// </java-name>
		[Dot42.DexImport("org/w3c/dom/ls/LSOutput", AccessFlags = 1537)]
		public partial interface ILSOutput
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// getCharacterStream
				/// </java-name>
				global::Java.IO.Writer CharacterStream
				{
						[Dot42.DexImport("getCharacterStream", "()Ljava/io/Writer;", AccessFlags = 1025)]
						get;
						[Dot42.DexImport("setCharacterStream", "(Ljava/io/Writer;)V", AccessFlags = 1025)]
						set;
				}

				/// <java-name>
				/// getByteStream
				/// </java-name>
				global::Java.IO.OutputStream ByteStream
				{
						[Dot42.DexImport("getByteStream", "()Ljava/io/OutputStream;", AccessFlags = 1025)]
						get;
						[Dot42.DexImport("setByteStream", "(Ljava/io/OutputStream;)V", AccessFlags = 1025)]
						set;
				}

				/// <java-name>
				/// getSystemId
				/// </java-name>
				string SystemId
				{
						[Dot42.DexImport("getSystemId", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
						[Dot42.DexImport("setSystemId", "(Ljava/lang/String;)V", AccessFlags = 1025)]
						set;
				}

				/// <java-name>
				/// getEncoding
				/// </java-name>
				string Encoding
				{
						[Dot42.DexImport("getEncoding", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
						[Dot42.DexImport("setEncoding", "(Ljava/lang/String;)V", AccessFlags = 1025)]
						set;
				}

		}

		/// <java-name>
		/// org/w3c/dom/ls/LSParser
		/// </java-name>
		[Dot42.DexImport("org/w3c/dom/ls/LSParser", AccessFlags = 1537)]
		public partial interface ILSParser
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// parse
				/// </java-name>
				[Dot42.DexImport("parse", "(Lorg/w3c/dom/ls/LSInput;)Lorg/w3c/dom/Document;", AccessFlags = 1025)]
				global::Org.W3c.Dom.IDocument Parse(global::Org.W3c.Dom.Ls.ILSInput lSInput) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// parseURI
				/// </java-name>
				[Dot42.DexImport("parseURI", "(Ljava/lang/String;)Lorg/w3c/dom/Document;", AccessFlags = 1025)]
				global::Org.W3c.Dom.IDocument ParseURI(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// parseWithContext
				/// </java-name>
				[Dot42.DexImport("parseWithContext", "(Lorg/w3c/dom/ls/LSInput;Lorg/w3c/dom/Node;S)Lorg/w3c/dom/Node;", AccessFlags = 1025)]
				global::Org.W3c.Dom.INode ParseWithContext(global::Org.W3c.Dom.Ls.ILSInput lSInput, global::Org.W3c.Dom.INode node, short int16) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// abort
				/// </java-name>
				[Dot42.DexImport("abort", "()V", AccessFlags = 1025)]
				void Abort() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getDomConfig
				/// </java-name>
				global::Org.W3c.Dom.IDOMConfiguration DomConfig
				{
						[Dot42.DexImport("getDomConfig", "()Lorg/w3c/dom/DOMConfiguration;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getFilter
				/// </java-name>
				global::Org.W3c.Dom.Ls.ILSParserFilter Filter
				{
						[Dot42.DexImport("getFilter", "()Lorg/w3c/dom/ls/LSParserFilter;", AccessFlags = 1025)]
						get;
						[Dot42.DexImport("setFilter", "(Lorg/w3c/dom/ls/LSParserFilter;)V", AccessFlags = 1025)]
						set;
				}

				/// <java-name>
				/// getAsync
				/// </java-name>
				bool IsAsync
				{
						[Dot42.DexImport("getAsync", "()Z", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getBusy
				/// </java-name>
				bool IsBusy
				{
						[Dot42.DexImport("getBusy", "()Z", AccessFlags = 1025)]
						get;
				}

		}

		/// <java-name>
		/// org/w3c/dom/ls/LSParser
		/// </java-name>
		[Dot42.DexImport("org/w3c/dom/ls/LSParser", AccessFlags = 1537, IgnoreFromJava = true, Priority = 1)]
		public static partial class ILSParserConstants
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// ACTION_APPEND_AS_CHILDREN
				/// </java-name>
				[Dot42.DexImport("ACTION_APPEND_AS_CHILDREN", "S", AccessFlags = 25)]
				public const short ACTION_APPEND_AS_CHILDREN = 1;
				/// <java-name>
				/// ACTION_REPLACE_CHILDREN
				/// </java-name>
				[Dot42.DexImport("ACTION_REPLACE_CHILDREN", "S", AccessFlags = 25)]
				public const short ACTION_REPLACE_CHILDREN = 2;
				/// <java-name>
				/// ACTION_INSERT_BEFORE
				/// </java-name>
				[Dot42.DexImport("ACTION_INSERT_BEFORE", "S", AccessFlags = 25)]
				public const short ACTION_INSERT_BEFORE = 3;
				/// <java-name>
				/// ACTION_INSERT_AFTER
				/// </java-name>
				[Dot42.DexImport("ACTION_INSERT_AFTER", "S", AccessFlags = 25)]
				public const short ACTION_INSERT_AFTER = 4;
				/// <java-name>
				/// ACTION_REPLACE
				/// </java-name>
				[Dot42.DexImport("ACTION_REPLACE", "S", AccessFlags = 25)]
				public const short ACTION_REPLACE = 5;
		}

		/// <java-name>
		/// org/w3c/dom/ls/LSParserFilter
		/// </java-name>
		[Dot42.DexImport("org/w3c/dom/ls/LSParserFilter", AccessFlags = 1537)]
		public partial interface ILSParserFilter
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// startElement
				/// </java-name>
				[Dot42.DexImport("startElement", "(Lorg/w3c/dom/Element;)S", AccessFlags = 1025)]
				short StartElement(global::Org.W3c.Dom.IElement element) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// acceptNode
				/// </java-name>
				[Dot42.DexImport("acceptNode", "(Lorg/w3c/dom/Node;)S", AccessFlags = 1025)]
				short AcceptNode(global::Org.W3c.Dom.INode node) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getWhatToShow
				/// </java-name>
				int WhatToShow
				{
						[Dot42.DexImport("getWhatToShow", "()I", AccessFlags = 1025)]
						get;
				}

		}

		/// <java-name>
		/// org/w3c/dom/ls/LSParserFilter
		/// </java-name>
		[Dot42.DexImport("org/w3c/dom/ls/LSParserFilter", AccessFlags = 1537, IgnoreFromJava = true, Priority = 1)]
		public static partial class ILSParserFilterConstants
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// FILTER_ACCEPT
				/// </java-name>
				[Dot42.DexImport("FILTER_ACCEPT", "S", AccessFlags = 25)]
				public const short FILTER_ACCEPT = 1;
				/// <java-name>
				/// FILTER_REJECT
				/// </java-name>
				[Dot42.DexImport("FILTER_REJECT", "S", AccessFlags = 25)]
				public const short FILTER_REJECT = 2;
				/// <java-name>
				/// FILTER_SKIP
				/// </java-name>
				[Dot42.DexImport("FILTER_SKIP", "S", AccessFlags = 25)]
				public const short FILTER_SKIP = 3;
				/// <java-name>
				/// FILTER_INTERRUPT
				/// </java-name>
				[Dot42.DexImport("FILTER_INTERRUPT", "S", AccessFlags = 25)]
				public const short FILTER_INTERRUPT = 4;
		}

		/// <java-name>
		/// org/w3c/dom/ls/LSResourceResolver
		/// </java-name>
		[Dot42.DexImport("org/w3c/dom/ls/LSResourceResolver", AccessFlags = 1537)]
		public partial interface ILSResourceResolver
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// resolveResource
				/// </java-name>
				[Dot42.DexImport("resolveResource", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/la" +
    "ng/String;)Lorg/w3c/dom/ls/LSInput;", AccessFlags = 1025)]
				global::Org.W3c.Dom.Ls.ILSInput ResolveResource(string @string, string string1, string string2, string string3, string string4) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// org/w3c/dom/ls/LSSerializer
		/// </java-name>
		[Dot42.DexImport("org/w3c/dom/ls/LSSerializer", AccessFlags = 1537)]
		public partial interface ILSSerializer
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "(Lorg/w3c/dom/Node;Lorg/w3c/dom/ls/LSOutput;)Z", AccessFlags = 1025)]
				bool Write(global::Org.W3c.Dom.INode node, global::Org.W3c.Dom.Ls.ILSOutput lSOutput) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// writeToURI
				/// </java-name>
				[Dot42.DexImport("writeToURI", "(Lorg/w3c/dom/Node;Ljava/lang/String;)Z", AccessFlags = 1025)]
				bool WriteToURI(global::Org.W3c.Dom.INode node, string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// writeToString
				/// </java-name>
				[Dot42.DexImport("writeToString", "(Lorg/w3c/dom/Node;)Ljava/lang/String;", AccessFlags = 1025)]
				string WriteToString(global::Org.W3c.Dom.INode node) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getDomConfig
				/// </java-name>
				global::Org.W3c.Dom.IDOMConfiguration DomConfig
				{
						[Dot42.DexImport("getDomConfig", "()Lorg/w3c/dom/DOMConfiguration;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getNewLine
				/// </java-name>
				string NewLine
				{
						[Dot42.DexImport("getNewLine", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
						[Dot42.DexImport("setNewLine", "(Ljava/lang/String;)V", AccessFlags = 1025)]
						set;
				}

		}

		/// <java-name>
		/// org/w3c/dom/ls/LSException
		/// </java-name>
		[Dot42.DexImport("org/w3c/dom/ls/LSException", AccessFlags = 33)]
		public partial class LSException : global::System.SystemException
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// code
				/// </java-name>
				[Dot42.DexImport("code", "S", AccessFlags = 1)]
				public short Code;
				/// <java-name>
				/// PARSE_ERR
				/// </java-name>
				[Dot42.DexImport("PARSE_ERR", "S", AccessFlags = 25)]
				public const short PARSE_ERR = 81;
				/// <java-name>
				/// SERIALIZE_ERR
				/// </java-name>
				[Dot42.DexImport("SERIALIZE_ERR", "S", AccessFlags = 25)]
				public const short SERIALIZE_ERR = 82;
				[Dot42.DexImport("<init>", "(SLjava/lang/String;)V", AccessFlags = 1)]
				public LSException(short int16, string @string) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal LSException() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

}

