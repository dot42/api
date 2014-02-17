// Copyright (C) 2014 dot42
//
// Original filename: Org.Apache.Http.Impl.Entity.cs
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
namespace Org.Apache.Http.Impl.Entity
{
		/// <summary>
		/// <para>The strict implementation of the content length strategy. </para><para>This entity generator comforms to the entity transfer rules outlined in the , ,  and  of  </para><para>&lt;h&gt;4.4 Message Length&lt;/h&gt; </para><para>The transfer-length of a message is the length of the message-body as it appears in the message; that is, after any transfer-codings have been applied. When a message-body is included with a message, the transfer-length of that body is determined by one of the following (in order of precedence): </para><para>1.Any response message which "MUST NOT" include a message-body (such as the 1xx, 204, and 304 responses and any response to a HEAD request) is always terminated by the first empty line after the header fields, regardless of the entity-header fields present in the message. </para><para>2.If a Transfer-Encoding header field (section 14.41) is present and has any value other than "identity", then the transfer-length is defined by use of the "chunked" transfer- coding (section 3.6), unless the message is terminated by closing the connection. </para><para>3.If a Content-Length header field (section 14.13) is present, its decimal value in OCTETs represents both the entity-length and the transfer-length. The Content-Length header field MUST NOT be sent if these two lengths are different (i.e., if a Transfer-Encoding </para><para><pre>
		///       header field is present). If a message is received with both a
		///       Transfer-Encoding header field and a Content-Length header field,
		///       the latter MUST be ignored.
		///    </pre> </para><para>4.If the message uses the media type "multipart/byteranges", and the ransfer-length is not otherwise specified, then this self- elimiting media type defines the transfer-length. This media type UST NOT be used unless the sender knows that the recipient can arse it; the presence in a request of a Range header with ultiple byte- range specifiers from a 1.1 client implies that the lient can parse multipart/byteranges responses. </para><para><pre>
		///        A range header might be forwarded by a 1.0 proxy that does not
		///        understand multipart/byteranges; in this case the server MUST
		///        delimit the message using methods defined in items 1,3 or 5 of
		///        this section.
		///    </pre> </para><para>5.By the server closing the connection. (Closing the connection cannot be used to indicate the end of a request body, since that would leave no possibility for the server to send back a response.) </para><para>For compatibility with HTTP/1.0 applications, HTTP/1.1 requests containing a message-body MUST include a valid Content-Length header field unless the server is known to be HTTP/1.1 compliant. If a request contains a message-body and a Content-Length is not given, the server SHOULD respond with 400 (bad request) if it cannot determine the length of the message, or with 411 (length required) if it wishes to insist on receiving a valid Content-Length. </para><para>All HTTP/1.1 applications that receive entities MUST accept the "chunked" transfer-coding (section 3.6), thus allowing this mechanism to be used for messages when the message length cannot be determined in advance. </para><para>&lt;h&gt;3.6 Transfer Codings&lt;/h&gt; </para><para>Transfer-coding values are used to indicate an encoding transformation that has been, can be, or may need to be applied to an entity-body in order to ensure "safe transport" through the network. This differs from a content coding in that the transfer-coding is a property of the message, not of the original entity. </para><para><pre>
		///    transfer-coding         = "chunked" | transfer-extension
		///    transfer-extension      = token *( ";" parameter )
		///    </pre> </para><para>Parameters are in the form of attribute/value pairs. </para><para><pre>
		///    parameter               = attribute "=" value
		///    attribute               = token
		///    value                   = token | quoted-string
		///    </pre> </para><para>All transfer-coding values are case-insensitive. HTTP/1.1 uses transfer-coding values in the TE header field (section 14.39) and in the Transfer-Encoding header field (section 14.41). </para><para>Whenever a transfer-coding is applied to a message-body, the set of transfer-codings MUST include "chunked", unless the message is terminated by closing the connection. When the "chunked" transfer-coding is used, it MUST be the last transfer-coding applied to the message-body. The "chunked" transfer-coding MUST NOT be applied more than once to a message-body. These rules allow the recipient to determine the transfer-length of the message (section 4.4). </para><para>&lt;h&gt;14.41 Transfer-Encoding&lt;/h&gt; </para><para>The Transfer-Encoding general-header field indicates what (if any) type of transformation has been applied to the message body in order to safely transfer it between the sender and the recipient. This differs from the content-coding in that the transfer-coding is a property of the message, not of the entity. </para><para><pre>
		///      Transfer-Encoding       = "Transfer-Encoding" ":" 1#transfer-coding
		///    </pre> </para><para>If multiple encodings have been applied to an entity, the transfer- codings MUST be listed in the order in which they were applied. Additional information about the encoding parameters MAY be provided by other entity-header fields not defined by this specification. </para><para>&lt;h&gt;14.13 Content-Length&lt;/h&gt; </para><para>The Content-Length entity-header field indicates the size of the entity-body, in decimal number of OCTETs, sent to the recipient or, in the case of the HEAD method, the size of the entity-body that would have been sent had the request been a GET. </para><para><pre>
		///      Content-Length    = "Content-Length" ":" 1*DIGIT
		///    </pre> </para><para>Applications SHOULD use this field to indicate the transfer-length of the message-body, unless this is prohibited by the rules in section 4.4. </para><para><para></para><para></para><title>Revision:</title><para>573949 </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/impl/entity/StrictContentLengthStrategy
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/entity/StrictContentLengthStrategy", AccessFlags = 33)]
		public partial class StrictContentLengthStrategy : global::Org.Apache.Http.Entity.IContentLengthStrategy
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public StrictContentLengthStrategy() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// determineLength
				/// </java-name>
				[Dot42.DexImport("determineLength", "(Lorg/apache/http/HttpMessage;)J", AccessFlags = 1)]
				public virtual long DetermineLength(global::Org.Apache.Http.IHttpMessage message) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

		}

		/// <summary>
		/// <para>Default implementation of an entity serializer. </para><para>This entity serializer currently supports only "chunked" and "identitiy" transfer-coding </para><para><para></para><para></para><title>Revision:</title><para>560343 </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/impl/entity/EntitySerializer
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/entity/EntitySerializer", AccessFlags = 33)]
		public partial class EntitySerializer
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Lorg/apache/http/entity/ContentLengthStrategy;)V", AccessFlags = 1)]
				public EntitySerializer(global::Org.Apache.Http.Entity.IContentLengthStrategy lenStrategy) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// doSerialize
				/// </java-name>
				[Dot42.DexImport("doSerialize", "(Lorg/apache/http/io/SessionOutputBuffer;Lorg/apache/http/HttpMessage;)Ljava/io/O" +
    "utputStream;", AccessFlags = 4)]
				protected internal virtual global::Java.Io.OutputStream DoSerialize(global::Org.Apache.Http.Io.ISessionOutputBuffer outbuffer, global::Org.Apache.Http.IHttpMessage message) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.OutputStream);
				}

				/// <java-name>
				/// serialize
				/// </java-name>
				[Dot42.DexImport("serialize", "(Lorg/apache/http/io/SessionOutputBuffer;Lorg/apache/http/HttpMessage;Lorg/apache" +
    "/http/HttpEntity;)V", AccessFlags = 1)]
				public virtual void Serialize(global::Org.Apache.Http.Io.ISessionOutputBuffer outbuffer, global::Org.Apache.Http.IHttpMessage message, global::Org.Apache.Http.IHttpEntity entity) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal EntitySerializer() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		/// <para>The lax implementation of the content length strategy. </para><para>This strategy conforms to the entity transfer rules outlined in , ,  and  of , but is lenient about unsupported transfer codecs and malformed content-length headers. </para><para>&lt;h&gt;4.4 Message Length&lt;/h&gt; </para><para>The transfer-length of a message is the length of the message-body as it appears in the message; that is, after any transfer-codings have been applied. When a message-body is included with a message, the transfer-length of that body is determined by one of the following (in order of precedence): </para><para>1.Any response message which "MUST NOT" include a message-body (such as the 1xx, 204, and 304 responses and any response to a HEAD request) is always terminated by the first empty line after the header fields, regardless of the entity-header fields present in the message. </para><para>2.If a Transfer-Encoding header field (section 14.41) is present and has any value other than "identity", then the transfer-length is defined by use of the "chunked" transfer- coding (section 3.6), unless the message is terminated by closing the connection. </para><para>3.If a Content-Length header field (section 14.13) is present, its decimal value in OCTETs represents both the entity-length and the transfer-length. The Content-Length header field MUST NOT be sent if these two lengths are different (i.e., if a Transfer-Encoding </para><para><pre>
		///       header field is present). If a message is received with both a
		///       Transfer-Encoding header field and a Content-Length header field,
		///       the latter MUST be ignored.
		///    </pre> </para><para>4.If the message uses the media type "multipart/byteranges", and the ransfer-length is not otherwise specified, then this self- elimiting media type defines the transfer-length. This media type UST NOT be used unless the sender knows that the recipient can arse it; the presence in a request of a Range header with ultiple byte- range specifiers from a 1.1 client implies that the lient can parse multipart/byteranges responses. </para><para><pre>
		///        A range header might be forwarded by a 1.0 proxy that does not
		///        understand multipart/byteranges; in this case the server MUST
		///        delimit the message using methods defined in items 1,3 or 5 of
		///        this section.
		///    </pre> </para><para>5.By the server closing the connection. (Closing the connection cannot be used to indicate the end of a request body, since that would leave no possibility for the server to send back a response.) </para><para>For compatibility with HTTP/1.0 applications, HTTP/1.1 requests containing a message-body MUST include a valid Content-Length header field unless the server is known to be HTTP/1.1 compliant. If a request contains a message-body and a Content-Length is not given, the server SHOULD respond with 400 (bad request) if it cannot determine the length of the message, or with 411 (length required) if it wishes to insist on receiving a valid Content-Length. </para><para>All HTTP/1.1 applications that receive entities MUST accept the "chunked" transfer-coding (section 3.6), thus allowing this mechanism to be used for messages when the message length cannot be determined in advance. </para><para>&lt;h&gt;3.6 Transfer Codings&lt;/h&gt; </para><para>Transfer-coding values are used to indicate an encoding transformation that has been, can be, or may need to be applied to an entity-body in order to ensure "safe transport" through the network. This differs from a content coding in that the transfer-coding is a property of the message, not of the original entity. </para><para><pre>
		///    transfer-coding         = "chunked" | transfer-extension
		///    transfer-extension      = token *( ";" parameter )
		///    </pre> </para><para>Parameters are in the form of attribute/value pairs. </para><para><pre>
		///    parameter               = attribute "=" value
		///    attribute               = token
		///    value                   = token | quoted-string
		///    </pre> </para><para>All transfer-coding values are case-insensitive. HTTP/1.1 uses transfer-coding values in the TE header field (section 14.39) and in the Transfer-Encoding header field (section 14.41). </para><para>Whenever a transfer-coding is applied to a message-body, the set of transfer-codings MUST include "chunked", unless the message is terminated by closing the connection. When the "chunked" transfer-coding is used, it MUST be the last transfer-coding applied to the message-body. The "chunked" transfer-coding MUST NOT be applied more than once to a message-body. These rules allow the recipient to determine the transfer-length of the message (section 4.4). </para><para>&lt;h&gt;14.41 Transfer-Encoding&lt;/h&gt; </para><para>The Transfer-Encoding general-header field indicates what (if any) type of transformation has been applied to the message body in order to safely transfer it between the sender and the recipient. This differs from the content-coding in that the transfer-coding is a property of the message, not of the entity. </para><para><pre>
		///      Transfer-Encoding       = "Transfer-Encoding" ":" 1#transfer-coding
		///    </pre> </para><para>If multiple encodings have been applied to an entity, the transfer- codings MUST be listed in the order in which they were applied. Additional information about the encoding parameters MAY be provided by other entity-header fields not defined by this specification. </para><para>&lt;h&gt;14.13 Content-Length&lt;/h&gt; </para><para>The Content-Length entity-header field indicates the size of the entity-body, in decimal number of OCTETs, sent to the recipient or, in the case of the HEAD method, the size of the entity-body that would have been sent had the request been a GET. </para><para><pre>
		///      Content-Length    = "Content-Length" ":" 1*DIGIT
		///    </pre> </para><para>Applications SHOULD use this field to indicate the transfer-length of the message-body, unless this is prohibited by the rules in section 4.4. </para><para><para></para><para></para><title>Revision:</title><para>576073 </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/impl/entity/LaxContentLengthStrategy
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/entity/LaxContentLengthStrategy", AccessFlags = 33)]
		public partial class LaxContentLengthStrategy : global::Org.Apache.Http.Entity.IContentLengthStrategy
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public LaxContentLengthStrategy() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// determineLength
				/// </java-name>
				[Dot42.DexImport("determineLength", "(Lorg/apache/http/HttpMessage;)J", AccessFlags = 1)]
				public virtual long DetermineLength(global::Org.Apache.Http.IHttpMessage message) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

		}

		/// <summary>
		/// <para>Default implementation of an entity deserializer. </para><para>This entity deserializer currently supports only "chunked" and "identitiy" transfer-coding </para><para><para></para><para></para><title>Revision:</title><para>560358 </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/impl/entity/EntityDeserializer
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/entity/EntityDeserializer", AccessFlags = 33)]
		public partial class EntityDeserializer
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Lorg/apache/http/entity/ContentLengthStrategy;)V", AccessFlags = 1)]
				public EntityDeserializer(global::Org.Apache.Http.Entity.IContentLengthStrategy lenStrategy) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// doDeserialize
				/// </java-name>
				[Dot42.DexImport("doDeserialize", "(Lorg/apache/http/io/SessionInputBuffer;Lorg/apache/http/HttpMessage;)Lorg/apache" +
    "/http/entity/BasicHttpEntity;", AccessFlags = 4)]
				protected internal virtual global::Org.Apache.Http.Entity.BasicHttpEntity DoDeserialize(global::Org.Apache.Http.Io.ISessionInputBuffer inbuffer, global::Org.Apache.Http.IHttpMessage message) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Entity.BasicHttpEntity);
				}

				/// <java-name>
				/// deserialize
				/// </java-name>
				[Dot42.DexImport("deserialize", "(Lorg/apache/http/io/SessionInputBuffer;Lorg/apache/http/HttpMessage;)Lorg/apache" +
    "/http/HttpEntity;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.IHttpEntity Deserialize(global::Org.Apache.Http.Io.ISessionInputBuffer inbuffer, global::Org.Apache.Http.IHttpMessage message) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IHttpEntity);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal EntityDeserializer() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

}


