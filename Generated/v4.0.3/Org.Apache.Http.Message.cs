#pragma warning disable 1717
namespace Org.Apache.Http.Message
{
		/// <java-name>
		/// org/apache/http/message/AbstractHttpMessage
		/// </java-name>
		[Dot42.DexImport("org/apache/http/message/AbstractHttpMessage", AccessFlags = 1057)]
		public abstract partial class AbstractHttpMessage : global::Org.Apache.Http.IHttpMessage
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// headergroup
				/// </java-name>
				[Dot42.DexImport("headergroup", "Lorg/apache/http/message/HeaderGroup;", AccessFlags = 4)]
				protected internal global::Org.Apache.Http.Message.HeaderGroup Headergroup;
				/// <java-name>
				/// params
				/// </java-name>
				[Dot42.DexImport("params", "Lorg/apache/http/params/HttpParams;", AccessFlags = 4)]
				protected internal global::Org.Apache.Http.Params.IHttpParams Params;
				[Dot42.DexImport("<init>", "(Lorg/apache/http/params/HttpParams;)V", AccessFlags = 4)]
				protected internal AbstractHttpMessage(global::Org.Apache.Http.Params.IHttpParams httpParams) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal AbstractHttpMessage() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// containsHeader
				/// </java-name>
				[Dot42.DexImport("containsHeader", "(Ljava/lang/String;)Z", AccessFlags = 1)]
				public virtual bool ContainsHeader(string @string) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getHeaders
				/// </java-name>
				[Dot42.DexImport("getHeaders", "(Ljava/lang/String;)[Lorg/apache/http/Header;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.IHeader[] GetHeaders(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IHeader[]);
				}

				/// <java-name>
				/// getFirstHeader
				/// </java-name>
				[Dot42.DexImport("getFirstHeader", "(Ljava/lang/String;)Lorg/apache/http/Header;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.IHeader GetFirstHeader(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IHeader);
				}

				/// <java-name>
				/// getLastHeader
				/// </java-name>
				[Dot42.DexImport("getLastHeader", "(Ljava/lang/String;)Lorg/apache/http/Header;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.IHeader GetLastHeader(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IHeader);
				}

				/// <java-name>
				/// getAllHeaders
				/// </java-name>
				[Dot42.DexImport("getAllHeaders", "()[Lorg/apache/http/Header;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.IHeader[] GetAllHeaders() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IHeader[]);
				}

				/// <java-name>
				/// addHeader
				/// </java-name>
				[Dot42.DexImport("addHeader", "(Lorg/apache/http/Header;)V", AccessFlags = 1)]
				public virtual void AddHeader(global::Org.Apache.Http.IHeader header) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addHeader
				/// </java-name>
				[Dot42.DexImport("addHeader", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void AddHeader(string @string, string string1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setHeader
				/// </java-name>
				[Dot42.DexImport("setHeader", "(Lorg/apache/http/Header;)V", AccessFlags = 1)]
				public virtual void SetHeader(global::Org.Apache.Http.IHeader header) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setHeader
				/// </java-name>
				[Dot42.DexImport("setHeader", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetHeader(string @string, string string1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setHeaders
				/// </java-name>
				[Dot42.DexImport("setHeaders", "([Lorg/apache/http/Header;)V", AccessFlags = 1)]
				public virtual void SetHeaders(global::Org.Apache.Http.IHeader[] header) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// removeHeader
				/// </java-name>
				[Dot42.DexImport("removeHeader", "(Lorg/apache/http/Header;)V", AccessFlags = 1)]
				public virtual void RemoveHeader(global::Org.Apache.Http.IHeader header) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// removeHeaders
				/// </java-name>
				[Dot42.DexImport("removeHeaders", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void RemoveHeaders(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// headerIterator
				/// </java-name>
				[Dot42.DexImport("headerIterator", "()Lorg/apache/http/HeaderIterator;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.IHeaderIterator HeaderIterator() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IHeaderIterator);
				}

				/// <java-name>
				/// headerIterator
				/// </java-name>
				[Dot42.DexImport("headerIterator", "(Ljava/lang/String;)Lorg/apache/http/HeaderIterator;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.IHeaderIterator HeaderIterator(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IHeaderIterator);
				}

				/// <java-name>
				/// getParams
				/// </java-name>
				[Dot42.DexImport("getParams", "()Lorg/apache/http/params/HttpParams;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.Params.IHttpParams GetParams() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Params.IHttpParams);
				}

				/// <java-name>
				/// setParams
				/// </java-name>
				[Dot42.DexImport("setParams", "(Lorg/apache/http/params/HttpParams;)V", AccessFlags = 1)]
				public virtual void SetParams(global::Org.Apache.Http.Params.IHttpParams httpParams) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "getProtocolVersion", "()Lorg/apache/http/ProtocolVersion;", AccessFlags = 1025)]
				public virtual global::Org.Apache.Http.ProtocolVersion GetProtocolVersion() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Org.Apache.Http.ProtocolVersion);
				}

				/// <java-name>
				/// getAllHeaders
				/// </java-name>
				public global::Org.Apache.Http.IHeader[] AllHeaders
				{
				[Dot42.DexImport("getAllHeaders", "()[Lorg/apache/http/Header;", AccessFlags = 1)]
						get{ return GetAllHeaders(); }
				}

				public global::Org.Apache.Http.ProtocolVersion ProtocolVersion
				{
				[Dot42.DexImport("org/apache/http/HttpMessage", "getProtocolVersion", "()Lorg/apache/http/ProtocolVersion;", AccessFlags = 1025)]
						get{ return GetProtocolVersion(); }
				}

		}

		/// <java-name>
		/// org/apache/http/message/BasicHeader
		/// </java-name>
		[Dot42.DexImport("org/apache/http/message/BasicHeader", AccessFlags = 33)]
		public partial class BasicHeader : global::Org.Apache.Http.IHeader, global::Java.Lang.ICloneable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public BasicHeader(string @string, string string1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getName
				/// </java-name>
				[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetName() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getValue
				/// </java-name>
				[Dot42.DexImport("getValue", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetValue() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getElements
				/// </java-name>
				[Dot42.DexImport("getElements", "()[Lorg/apache/http/HeaderElement;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.IHeaderElement[] GetElements() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IHeaderElement[]);
				}

				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/lang/Object;", AccessFlags = 1)]
				public virtual object Clone() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal BasicHeader() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getName
				/// </java-name>
				public string Name
				{
				[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetName(); }
				}

				/// <java-name>
				/// getValue
				/// </java-name>
				public string Value
				{
				[Dot42.DexImport("getValue", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetValue(); }
				}

				/// <java-name>
				/// getElements
				/// </java-name>
				public global::Org.Apache.Http.IHeaderElement[] Elements
				{
				[Dot42.DexImport("getElements", "()[Lorg/apache/http/HeaderElement;", AccessFlags = 1)]
						get{ return GetElements(); }
				}

		}

		/// <java-name>
		/// org/apache/http/message/BasicHeaderElement
		/// </java-name>
		[Dot42.DexImport("org/apache/http/message/BasicHeaderElement", AccessFlags = 33)]
		public partial class BasicHeaderElement : global::Org.Apache.Http.IHeaderElement, global::Java.Lang.ICloneable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;[Lorg/apache/http/NameValuePair;)V", AccessFlags = 1)]
				public BasicHeaderElement(string @string, string string1, global::Org.Apache.Http.INameValuePair[] nameValuePair) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public BasicHeaderElement(string @string, string string1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getName
				/// </java-name>
				[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetName() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getValue
				/// </java-name>
				[Dot42.DexImport("getValue", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetValue() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getParameters
				/// </java-name>
				[Dot42.DexImport("getParameters", "()[Lorg/apache/http/NameValuePair;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.INameValuePair[] GetParameters() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.INameValuePair[]);
				}

				/// <java-name>
				/// getParameterCount
				/// </java-name>
				[Dot42.DexImport("getParameterCount", "()I", AccessFlags = 1)]
				public virtual int GetParameterCount() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getParameter
				/// </java-name>
				[Dot42.DexImport("getParameter", "(I)Lorg/apache/http/NameValuePair;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.INameValuePair GetParameter(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.INameValuePair);
				}

				/// <java-name>
				/// getParameterByName
				/// </java-name>
				[Dot42.DexImport("getParameterByName", "(Ljava/lang/String;)Lorg/apache/http/NameValuePair;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.INameValuePair GetParameterByName(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.INameValuePair);
				}

				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 1)]
				public override int GetHashCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/lang/Object;", AccessFlags = 1)]
				public virtual object Clone() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal BasicHeaderElement() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getName
				/// </java-name>
				public string Name
				{
				[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetName(); }
				}

				/// <java-name>
				/// getValue
				/// </java-name>
				public string Value
				{
				[Dot42.DexImport("getValue", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetValue(); }
				}

				/// <java-name>
				/// getParameters
				/// </java-name>
				public global::Org.Apache.Http.INameValuePair[] Parameters
				{
				[Dot42.DexImport("getParameters", "()[Lorg/apache/http/NameValuePair;", AccessFlags = 1)]
						get{ return GetParameters(); }
				}

				/// <java-name>
				/// getParameterCount
				/// </java-name>
				public int ParameterCount
				{
				[Dot42.DexImport("getParameterCount", "()I", AccessFlags = 1)]
						get{ return GetParameterCount(); }
				}

		}

		/// <java-name>
		/// org/apache/http/message/BasicHeaderElementIterator
		/// </java-name>
		[Dot42.DexImport("org/apache/http/message/BasicHeaderElementIterator", AccessFlags = 33)]
		public partial class BasicHeaderElementIterator : global::Org.Apache.Http.IHeaderElementIterator
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Lorg/apache/http/HeaderIterator;Lorg/apache/http/message/HeaderValueParser;)V", AccessFlags = 1)]
				public BasicHeaderElementIterator(global::Org.Apache.Http.IHeaderIterator headerIterator, global::Org.Apache.Http.Message.IHeaderValueParser headerValueParser) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Lorg/apache/http/HeaderIterator;)V", AccessFlags = 1)]
				public BasicHeaderElementIterator(global::Org.Apache.Http.IHeaderIterator headerIterator) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// hasNext
				/// </java-name>
				[Dot42.DexImport("hasNext", "()Z", AccessFlags = 1)]
				public virtual bool HasNext() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// nextElement
				/// </java-name>
				[Dot42.DexImport("nextElement", "()Lorg/apache/http/HeaderElement;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.IHeaderElement NextElement() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IHeaderElement);
				}

				/// <java-name>
				/// next
				/// </java-name>
				[Dot42.DexImport("next", "()Ljava/lang/Object;", AccessFlags = 17)]
				public object Next() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <java-name>
				/// remove
				/// </java-name>
				[Dot42.DexImport("remove", "()V", AccessFlags = 1)]
				public virtual void Remove() /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal BasicHeaderElementIterator() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// org/apache/http/message/BasicHeaderIterator
		/// </java-name>
		[Dot42.DexImport("org/apache/http/message/BasicHeaderIterator", AccessFlags = 33)]
		public partial class BasicHeaderIterator : global::Org.Apache.Http.IHeaderIterator
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// allHeaders
				/// </java-name>
				[Dot42.DexImport("allHeaders", "[Lorg/apache/http/Header;", AccessFlags = 20)]
				protected internal readonly global::Org.Apache.Http.IHeader[] AllHeaders;
				/// <java-name>
				/// currentIndex
				/// </java-name>
				[Dot42.DexImport("currentIndex", "I", AccessFlags = 4)]
				protected internal int CurrentIndex;
				/// <java-name>
				/// headerName
				/// </java-name>
				[Dot42.DexImport("headerName", "Ljava/lang/String;", AccessFlags = 4)]
				protected internal string HeaderName;
				[Dot42.DexImport("<init>", "([Lorg/apache/http/Header;Ljava/lang/String;)V", AccessFlags = 1)]
				public BasicHeaderIterator(global::Org.Apache.Http.IHeader[] header, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// findNext
				/// </java-name>
				[Dot42.DexImport("findNext", "(I)I", AccessFlags = 4)]
				protected internal virtual int FindNext(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// filterHeader
				/// </java-name>
				[Dot42.DexImport("filterHeader", "(I)Z", AccessFlags = 4)]
				protected internal virtual bool FilterHeader(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// hasNext
				/// </java-name>
				[Dot42.DexImport("hasNext", "()Z", AccessFlags = 1)]
				public virtual bool HasNext() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// nextHeader
				/// </java-name>
				[Dot42.DexImport("nextHeader", "()Lorg/apache/http/Header;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.IHeader NextHeader() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IHeader);
				}

				/// <java-name>
				/// next
				/// </java-name>
				[Dot42.DexImport("next", "()Ljava/lang/Object;", AccessFlags = 17)]
				public object Next() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <java-name>
				/// remove
				/// </java-name>
				[Dot42.DexImport("remove", "()V", AccessFlags = 1)]
				public virtual void Remove() /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal BasicHeaderIterator() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// org/apache/http/message/BasicHeaderValueFormatter
		/// </java-name>
		[Dot42.DexImport("org/apache/http/message/BasicHeaderValueFormatter", AccessFlags = 33)]
		public partial class BasicHeaderValueFormatter : global::Org.Apache.Http.Message.IHeaderValueFormatter
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// DEFAULT
				/// </java-name>
				[Dot42.DexImport("DEFAULT", "Lorg/apache/http/message/BasicHeaderValueFormatter;", AccessFlags = 25)]
				public static readonly global::Org.Apache.Http.Message.BasicHeaderValueFormatter DEFAULT;
				/// <java-name>
				/// SEPARATORS
				/// </java-name>
				[Dot42.DexImport("SEPARATORS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SEPARATORS = " ;,:@()<>\\\"/[]?={}\t";
				/// <java-name>
				/// UNSAFE_CHARS
				/// </java-name>
				[Dot42.DexImport("UNSAFE_CHARS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string UNSAFE_CHARS = "\"\\";
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public BasicHeaderValueFormatter() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// formatElements
				/// </java-name>
				[Dot42.DexImport("formatElements", "([Lorg/apache/http/HeaderElement;ZLorg/apache/http/message/HeaderValueFormatter;)" +
    "Ljava/lang/String;", AccessFlags = 25)]
				public static string FormatElements(global::Org.Apache.Http.IHeaderElement[] headerElement, bool boolean, global::Org.Apache.Http.Message.IHeaderValueFormatter headerValueFormatter) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// formatElements
				/// </java-name>
				[Dot42.DexImport("formatElements", "(Lorg/apache/http/util/CharArrayBuffer;[Lorg/apache/http/HeaderElement;Z)Lorg/apa" +
    "che/http/util/CharArrayBuffer;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.Util.CharArrayBuffer FormatElements(global::Org.Apache.Http.Util.CharArrayBuffer charArrayBuffer, global::Org.Apache.Http.IHeaderElement[] headerElement, bool boolean) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Util.CharArrayBuffer);
				}

				/// <java-name>
				/// estimateElementsLen
				/// </java-name>
				[Dot42.DexImport("estimateElementsLen", "([Lorg/apache/http/HeaderElement;)I", AccessFlags = 4)]
				protected internal virtual int EstimateElementsLen(global::Org.Apache.Http.IHeaderElement[] headerElement) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// formatHeaderElement
				/// </java-name>
				[Dot42.DexImport("formatHeaderElement", "(Lorg/apache/http/HeaderElement;ZLorg/apache/http/message/HeaderValueFormatter;)L" +
    "java/lang/String;", AccessFlags = 25)]
				public static string FormatHeaderElement(global::Org.Apache.Http.IHeaderElement headerElement, bool boolean, global::Org.Apache.Http.Message.IHeaderValueFormatter headerValueFormatter) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// formatHeaderElement
				/// </java-name>
				[Dot42.DexImport("formatHeaderElement", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/HeaderElement;Z)Lorg/apac" +
    "he/http/util/CharArrayBuffer;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.Util.CharArrayBuffer FormatHeaderElement(global::Org.Apache.Http.Util.CharArrayBuffer charArrayBuffer, global::Org.Apache.Http.IHeaderElement headerElement, bool boolean) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Util.CharArrayBuffer);
				}

				/// <java-name>
				/// estimateHeaderElementLen
				/// </java-name>
				[Dot42.DexImport("estimateHeaderElementLen", "(Lorg/apache/http/HeaderElement;)I", AccessFlags = 4)]
				protected internal virtual int EstimateHeaderElementLen(global::Org.Apache.Http.IHeaderElement headerElement) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// formatParameters
				/// </java-name>
				[Dot42.DexImport("formatParameters", "([Lorg/apache/http/NameValuePair;ZLorg/apache/http/message/HeaderValueFormatter;)" +
    "Ljava/lang/String;", AccessFlags = 25)]
				public static string FormatParameters(global::Org.Apache.Http.INameValuePair[] nameValuePair, bool boolean, global::Org.Apache.Http.Message.IHeaderValueFormatter headerValueFormatter) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// formatParameters
				/// </java-name>
				[Dot42.DexImport("formatParameters", "(Lorg/apache/http/util/CharArrayBuffer;[Lorg/apache/http/NameValuePair;Z)Lorg/apa" +
    "che/http/util/CharArrayBuffer;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.Util.CharArrayBuffer FormatParameters(global::Org.Apache.Http.Util.CharArrayBuffer charArrayBuffer, global::Org.Apache.Http.INameValuePair[] nameValuePair, bool boolean) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Util.CharArrayBuffer);
				}

				/// <java-name>
				/// estimateParametersLen
				/// </java-name>
				[Dot42.DexImport("estimateParametersLen", "([Lorg/apache/http/NameValuePair;)I", AccessFlags = 4)]
				protected internal virtual int EstimateParametersLen(global::Org.Apache.Http.INameValuePair[] nameValuePair) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// formatNameValuePair
				/// </java-name>
				[Dot42.DexImport("formatNameValuePair", "(Lorg/apache/http/NameValuePair;ZLorg/apache/http/message/HeaderValueFormatter;)L" +
    "java/lang/String;", AccessFlags = 25)]
				public static string FormatNameValuePair(global::Org.Apache.Http.INameValuePair nameValuePair, bool boolean, global::Org.Apache.Http.Message.IHeaderValueFormatter headerValueFormatter) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// formatNameValuePair
				/// </java-name>
				[Dot42.DexImport("formatNameValuePair", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/NameValuePair;Z)Lorg/apac" +
    "he/http/util/CharArrayBuffer;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.Util.CharArrayBuffer FormatNameValuePair(global::Org.Apache.Http.Util.CharArrayBuffer charArrayBuffer, global::Org.Apache.Http.INameValuePair nameValuePair, bool boolean) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Util.CharArrayBuffer);
				}

				/// <java-name>
				/// estimateNameValuePairLen
				/// </java-name>
				[Dot42.DexImport("estimateNameValuePairLen", "(Lorg/apache/http/NameValuePair;)I", AccessFlags = 4)]
				protected internal virtual int EstimateNameValuePairLen(global::Org.Apache.Http.INameValuePair nameValuePair) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// doFormatValue
				/// </java-name>
				[Dot42.DexImport("doFormatValue", "(Lorg/apache/http/util/CharArrayBuffer;Ljava/lang/String;Z)V", AccessFlags = 4)]
				protected internal virtual void DoFormatValue(global::Org.Apache.Http.Util.CharArrayBuffer charArrayBuffer, string @string, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isSeparator
				/// </java-name>
				[Dot42.DexImport("isSeparator", "(C)Z", AccessFlags = 4)]
				protected internal virtual bool IsSeparator(char @char) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isUnsafe
				/// </java-name>
				[Dot42.DexImport("isUnsafe", "(C)Z", AccessFlags = 4)]
				protected internal virtual bool IsUnsafe(char @char) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

		}

		/// <java-name>
		/// org/apache/http/message/BasicHeaderValueParser
		/// </java-name>
		[Dot42.DexImport("org/apache/http/message/BasicHeaderValueParser", AccessFlags = 33)]
		public partial class BasicHeaderValueParser : global::Org.Apache.Http.Message.IHeaderValueParser
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// DEFAULT
				/// </java-name>
				[Dot42.DexImport("DEFAULT", "Lorg/apache/http/message/BasicHeaderValueParser;", AccessFlags = 25)]
				public static readonly global::Org.Apache.Http.Message.BasicHeaderValueParser DEFAULT;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public BasicHeaderValueParser() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// parseElements
				/// </java-name>
				[Dot42.DexImport("parseElements", "(Ljava/lang/String;Lorg/apache/http/message/HeaderValueParser;)[Lorg/apache/http/" +
    "HeaderElement;", AccessFlags = 25)]
				public static global::Org.Apache.Http.IHeaderElement[] ParseElements(string @string, global::Org.Apache.Http.Message.IHeaderValueParser headerValueParser) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IHeaderElement[]);
				}

				/// <java-name>
				/// parseElements
				/// </java-name>
				[Dot42.DexImport("parseElements", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/message/ParserCursor;)[Lo" +
    "rg/apache/http/HeaderElement;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.IHeaderElement[] ParseElements(global::Org.Apache.Http.Util.CharArrayBuffer charArrayBuffer, global::Org.Apache.Http.Message.ParserCursor parserCursor) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IHeaderElement[]);
				}

				/// <java-name>
				/// parseHeaderElement
				/// </java-name>
				[Dot42.DexImport("parseHeaderElement", "(Ljava/lang/String;Lorg/apache/http/message/HeaderValueParser;)Lorg/apache/http/H" +
    "eaderElement;", AccessFlags = 25)]
				public static global::Org.Apache.Http.IHeaderElement ParseHeaderElement(string @string, global::Org.Apache.Http.Message.IHeaderValueParser headerValueParser) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IHeaderElement);
				}

				/// <java-name>
				/// parseHeaderElement
				/// </java-name>
				[Dot42.DexImport("parseHeaderElement", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/message/ParserCursor;)Lor" +
    "g/apache/http/HeaderElement;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.IHeaderElement ParseHeaderElement(global::Org.Apache.Http.Util.CharArrayBuffer charArrayBuffer, global::Org.Apache.Http.Message.ParserCursor parserCursor) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IHeaderElement);
				}

				/// <java-name>
				/// createHeaderElement
				/// </java-name>
				[Dot42.DexImport("createHeaderElement", "(Ljava/lang/String;Ljava/lang/String;[Lorg/apache/http/NameValuePair;)Lorg/apache" +
    "/http/HeaderElement;", AccessFlags = 4)]
				protected internal virtual global::Org.Apache.Http.IHeaderElement CreateHeaderElement(string @string, string string1, global::Org.Apache.Http.INameValuePair[] nameValuePair) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IHeaderElement);
				}

				/// <java-name>
				/// parseParameters
				/// </java-name>
				[Dot42.DexImport("parseParameters", "(Ljava/lang/String;Lorg/apache/http/message/HeaderValueParser;)[Lorg/apache/http/" +
    "NameValuePair;", AccessFlags = 25)]
				public static global::Org.Apache.Http.INameValuePair[] ParseParameters(string @string, global::Org.Apache.Http.Message.IHeaderValueParser headerValueParser) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.INameValuePair[]);
				}

				/// <java-name>
				/// parseParameters
				/// </java-name>
				[Dot42.DexImport("parseParameters", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/message/ParserCursor;)[Lo" +
    "rg/apache/http/NameValuePair;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.INameValuePair[] ParseParameters(global::Org.Apache.Http.Util.CharArrayBuffer charArrayBuffer, global::Org.Apache.Http.Message.ParserCursor parserCursor) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.INameValuePair[]);
				}

				/// <java-name>
				/// parseNameValuePair
				/// </java-name>
				[Dot42.DexImport("parseNameValuePair", "(Ljava/lang/String;Lorg/apache/http/message/HeaderValueParser;)Lorg/apache/http/N" +
    "ameValuePair;", AccessFlags = 25)]
				public static global::Org.Apache.Http.INameValuePair ParseNameValuePair(string @string, global::Org.Apache.Http.Message.IHeaderValueParser headerValueParser) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.INameValuePair);
				}

				/// <java-name>
				/// parseNameValuePair
				/// </java-name>
				[Dot42.DexImport("parseNameValuePair", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/message/ParserCursor;)Lor" +
    "g/apache/http/NameValuePair;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.INameValuePair ParseNameValuePair(global::Org.Apache.Http.Util.CharArrayBuffer charArrayBuffer, global::Org.Apache.Http.Message.ParserCursor parserCursor) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.INameValuePair);
				}

				/// <java-name>
				/// parseNameValuePair
				/// </java-name>
				[Dot42.DexImport("parseNameValuePair", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/message/ParserCursor;[C)L" +
    "org/apache/http/NameValuePair;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.INameValuePair ParseNameValuePair(global::Org.Apache.Http.Util.CharArrayBuffer charArrayBuffer, global::Org.Apache.Http.Message.ParserCursor parserCursor, char[] @char) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.INameValuePair);
				}

				/// <java-name>
				/// createNameValuePair
				/// </java-name>
				[Dot42.DexImport("createNameValuePair", "(Ljava/lang/String;Ljava/lang/String;)Lorg/apache/http/NameValuePair;", AccessFlags = 4)]
				protected internal virtual global::Org.Apache.Http.INameValuePair CreateNameValuePair(string @string, string string1) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.INameValuePair);
				}

		}

		/// <java-name>
		/// org/apache/http/message/BasicHttpEntityEnclosingRequest
		/// </java-name>
		[Dot42.DexImport("org/apache/http/message/BasicHttpEntityEnclosingRequest", AccessFlags = 33)]
		public partial class BasicHttpEntityEnclosingRequest : global::Org.Apache.Http.Message.BasicHttpRequest, global::Org.Apache.Http.IHttpEntityEnclosingRequest
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public BasicHttpEntityEnclosingRequest(string @string, string string1) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;Lorg/apache/http/ProtocolVersion;)V", AccessFlags = 1)]
				public BasicHttpEntityEnclosingRequest(string @string, string string1, global::Org.Apache.Http.ProtocolVersion protocolVersion) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Lorg/apache/http/RequestLine;)V", AccessFlags = 1)]
				public BasicHttpEntityEnclosingRequest(global::Org.Apache.Http.IRequestLine requestLine) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getEntity
				/// </java-name>
				[Dot42.DexImport("getEntity", "()Lorg/apache/http/HttpEntity;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.IHttpEntity GetEntity() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IHttpEntity);
				}

				/// <java-name>
				/// setEntity
				/// </java-name>
				[Dot42.DexImport("setEntity", "(Lorg/apache/http/HttpEntity;)V", AccessFlags = 1)]
				public virtual void SetEntity(global::Org.Apache.Http.IHttpEntity httpEntity) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// expectContinue
				/// </java-name>
				[Dot42.DexImport("expectContinue", "()Z", AccessFlags = 1)]
				public virtual bool ExpectContinue() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal BasicHttpEntityEnclosingRequest() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				[Dot42.DexImport("org/apache/http/HttpRequest", "getRequestLine", "()Lorg/apache/http/RequestLine;", AccessFlags = 1025)]
				public override global::Org.Apache.Http.IRequestLine GetRequestLine() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Org.Apache.Http.IRequestLine);
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "getProtocolVersion", "()Lorg/apache/http/ProtocolVersion;", AccessFlags = 1025)]
				public override global::Org.Apache.Http.ProtocolVersion GetProtocolVersion() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Org.Apache.Http.ProtocolVersion);
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "containsHeader", "(Ljava/lang/String;)Z", AccessFlags = 1025)]
				public override bool ContainsHeader(string @string) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "getHeaders", "(Ljava/lang/String;)[Lorg/apache/http/Header;", AccessFlags = 1025)]
				public override global::Org.Apache.Http.IHeader[] GetHeaders(string @string) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Org.Apache.Http.IHeader[]);
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "getFirstHeader", "(Ljava/lang/String;)Lorg/apache/http/Header;", AccessFlags = 1025)]
				public override global::Org.Apache.Http.IHeader GetFirstHeader(string @string) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Org.Apache.Http.IHeader);
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "getLastHeader", "(Ljava/lang/String;)Lorg/apache/http/Header;", AccessFlags = 1025)]
				public override global::Org.Apache.Http.IHeader GetLastHeader(string @string) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Org.Apache.Http.IHeader);
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "getAllHeaders", "()[Lorg/apache/http/Header;", AccessFlags = 1025)]
				public override global::Org.Apache.Http.IHeader[] GetAllHeaders() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Org.Apache.Http.IHeader[]);
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "addHeader", "(Lorg/apache/http/Header;)V", AccessFlags = 1025)]
				public override void AddHeader(global::Org.Apache.Http.IHeader header) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "addHeader", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1025)]
				public override void AddHeader(string @string, string string1) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "setHeader", "(Lorg/apache/http/Header;)V", AccessFlags = 1025)]
				public override void SetHeader(global::Org.Apache.Http.IHeader header) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "setHeader", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1025)]
				public override void SetHeader(string @string, string string1) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "setHeaders", "([Lorg/apache/http/Header;)V", AccessFlags = 1025)]
				public override void SetHeaders(global::Org.Apache.Http.IHeader[] header) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "removeHeader", "(Lorg/apache/http/Header;)V", AccessFlags = 1025)]
				public override void RemoveHeader(global::Org.Apache.Http.IHeader header) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "removeHeaders", "(Ljava/lang/String;)V", AccessFlags = 1025)]
				public override void RemoveHeaders(string @string) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "headerIterator", "()Lorg/apache/http/HeaderIterator;", AccessFlags = 1025)]
				public override global::Org.Apache.Http.IHeaderIterator HeaderIterator() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Org.Apache.Http.IHeaderIterator);
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "headerIterator", "(Ljava/lang/String;)Lorg/apache/http/HeaderIterator;", AccessFlags = 1025)]
				public override global::Org.Apache.Http.IHeaderIterator HeaderIterator(string @string) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Org.Apache.Http.IHeaderIterator);
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "getParams", "()Lorg/apache/http/params/HttpParams;", AccessFlags = 1025)]
				public override global::Org.Apache.Http.Params.IHttpParams GetParams() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Org.Apache.Http.Params.IHttpParams);
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "setParams", "(Lorg/apache/http/params/HttpParams;)V", AccessFlags = 1025)]
				public override void SetParams(global::Org.Apache.Http.Params.IHttpParams httpParams) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				/// <java-name>
				/// getEntity
				/// </java-name>
				public global::Org.Apache.Http.IHttpEntity Entity
				{
				[Dot42.DexImport("getEntity", "()Lorg/apache/http/HttpEntity;", AccessFlags = 1)]
						get{ return GetEntity(); }
				[Dot42.DexImport("setEntity", "(Lorg/apache/http/HttpEntity;)V", AccessFlags = 1)]
						set{ SetEntity(value); }
				}

				public global::Org.Apache.Http.IRequestLine RequestLine
				{
				[Dot42.DexImport("org/apache/http/HttpRequest", "getRequestLine", "()Lorg/apache/http/RequestLine;", AccessFlags = 1025)]
						get{ return GetRequestLine(); }
				}

				public global::Org.Apache.Http.ProtocolVersion ProtocolVersion
				{
				[Dot42.DexImport("org/apache/http/HttpMessage", "getProtocolVersion", "()Lorg/apache/http/ProtocolVersion;", AccessFlags = 1025)]
						get{ return GetProtocolVersion(); }
				}

				public global::Org.Apache.Http.IHeader[] AllHeaders
				{
				[Dot42.DexImport("org/apache/http/HttpMessage", "getAllHeaders", "()[Lorg/apache/http/Header;", AccessFlags = 1025)]
						get{ return GetAllHeaders(); }
				}

		}

		/// <java-name>
		/// org/apache/http/message/BasicHttpRequest
		/// </java-name>
		[Dot42.DexImport("org/apache/http/message/BasicHttpRequest", AccessFlags = 33)]
		public partial class BasicHttpRequest : global::Org.Apache.Http.Message.AbstractHttpMessage, global::Org.Apache.Http.IHttpRequest
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public BasicHttpRequest(string @string, string string1) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;Lorg/apache/http/ProtocolVersion;)V", AccessFlags = 1)]
				public BasicHttpRequest(string @string, string string1, global::Org.Apache.Http.ProtocolVersion protocolVersion) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Lorg/apache/http/RequestLine;)V", AccessFlags = 1)]
				public BasicHttpRequest(global::Org.Apache.Http.IRequestLine requestLine) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getProtocolVersion
				/// </java-name>
				[Dot42.DexImport("getProtocolVersion", "()Lorg/apache/http/ProtocolVersion;", AccessFlags = 1)]
				public override global::Org.Apache.Http.ProtocolVersion GetProtocolVersion() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.ProtocolVersion);
				}

				/// <java-name>
				/// getRequestLine
				/// </java-name>
				[Dot42.DexImport("getRequestLine", "()Lorg/apache/http/RequestLine;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.IRequestLine GetRequestLine() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IRequestLine);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal BasicHttpRequest() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "containsHeader", "(Ljava/lang/String;)Z", AccessFlags = 1025)]
				public override bool ContainsHeader(string @string) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "getHeaders", "(Ljava/lang/String;)[Lorg/apache/http/Header;", AccessFlags = 1025)]
				public override global::Org.Apache.Http.IHeader[] GetHeaders(string @string) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Org.Apache.Http.IHeader[]);
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "getFirstHeader", "(Ljava/lang/String;)Lorg/apache/http/Header;", AccessFlags = 1025)]
				public override global::Org.Apache.Http.IHeader GetFirstHeader(string @string) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Org.Apache.Http.IHeader);
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "getLastHeader", "(Ljava/lang/String;)Lorg/apache/http/Header;", AccessFlags = 1025)]
				public override global::Org.Apache.Http.IHeader GetLastHeader(string @string) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Org.Apache.Http.IHeader);
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "getAllHeaders", "()[Lorg/apache/http/Header;", AccessFlags = 1025)]
				public override global::Org.Apache.Http.IHeader[] GetAllHeaders() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Org.Apache.Http.IHeader[]);
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "addHeader", "(Lorg/apache/http/Header;)V", AccessFlags = 1025)]
				public override void AddHeader(global::Org.Apache.Http.IHeader header) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "addHeader", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1025)]
				public override void AddHeader(string @string, string string1) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "setHeader", "(Lorg/apache/http/Header;)V", AccessFlags = 1025)]
				public override void SetHeader(global::Org.Apache.Http.IHeader header) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "setHeader", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1025)]
				public override void SetHeader(string @string, string string1) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "setHeaders", "([Lorg/apache/http/Header;)V", AccessFlags = 1025)]
				public override void SetHeaders(global::Org.Apache.Http.IHeader[] header) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "removeHeader", "(Lorg/apache/http/Header;)V", AccessFlags = 1025)]
				public override void RemoveHeader(global::Org.Apache.Http.IHeader header) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "removeHeaders", "(Ljava/lang/String;)V", AccessFlags = 1025)]
				public override void RemoveHeaders(string @string) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "headerIterator", "()Lorg/apache/http/HeaderIterator;", AccessFlags = 1025)]
				public override global::Org.Apache.Http.IHeaderIterator HeaderIterator() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Org.Apache.Http.IHeaderIterator);
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "headerIterator", "(Ljava/lang/String;)Lorg/apache/http/HeaderIterator;", AccessFlags = 1025)]
				public override global::Org.Apache.Http.IHeaderIterator HeaderIterator(string @string) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Org.Apache.Http.IHeaderIterator);
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "getParams", "()Lorg/apache/http/params/HttpParams;", AccessFlags = 1025)]
				public override global::Org.Apache.Http.Params.IHttpParams GetParams() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Org.Apache.Http.Params.IHttpParams);
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "setParams", "(Lorg/apache/http/params/HttpParams;)V", AccessFlags = 1025)]
				public override void SetParams(global::Org.Apache.Http.Params.IHttpParams httpParams) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				/// <java-name>
				/// getProtocolVersion
				/// </java-name>
				public global::Org.Apache.Http.ProtocolVersion ProtocolVersion
				{
				[Dot42.DexImport("getProtocolVersion", "()Lorg/apache/http/ProtocolVersion;", AccessFlags = 1)]
						get{ return GetProtocolVersion(); }
				}

				/// <java-name>
				/// getRequestLine
				/// </java-name>
				public global::Org.Apache.Http.IRequestLine RequestLine
				{
				[Dot42.DexImport("getRequestLine", "()Lorg/apache/http/RequestLine;", AccessFlags = 1)]
						get{ return GetRequestLine(); }
				}

				public global::Org.Apache.Http.IHeader[] AllHeaders
				{
				[Dot42.DexImport("org/apache/http/HttpMessage", "getAllHeaders", "()[Lorg/apache/http/Header;", AccessFlags = 1025)]
						get{ return GetAllHeaders(); }
				}

		}

		/// <java-name>
		/// org/apache/http/message/BasicHttpResponse
		/// </java-name>
		[Dot42.DexImport("org/apache/http/message/BasicHttpResponse", AccessFlags = 33)]
		public partial class BasicHttpResponse : global::Org.Apache.Http.Message.AbstractHttpMessage, global::Org.Apache.Http.IHttpResponse
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Lorg/apache/http/StatusLine;Lorg/apache/http/ReasonPhraseCatalog;Ljava/util/Loca" +
    "le;)V", AccessFlags = 1)]
				public BasicHttpResponse(global::Org.Apache.Http.IStatusLine statusLine, global::Org.Apache.Http.IReasonPhraseCatalog reasonPhraseCatalog, global::Java.Util.Locale locale) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Lorg/apache/http/StatusLine;)V", AccessFlags = 1)]
				public BasicHttpResponse(global::Org.Apache.Http.IStatusLine statusLine) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Lorg/apache/http/ProtocolVersion;ILjava/lang/String;)V", AccessFlags = 1)]
				public BasicHttpResponse(global::Org.Apache.Http.ProtocolVersion protocolVersion, int int32, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getProtocolVersion
				/// </java-name>
				[Dot42.DexImport("getProtocolVersion", "()Lorg/apache/http/ProtocolVersion;", AccessFlags = 1)]
				public override global::Org.Apache.Http.ProtocolVersion GetProtocolVersion() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.ProtocolVersion);
				}

				/// <java-name>
				/// getStatusLine
				/// </java-name>
				[Dot42.DexImport("getStatusLine", "()Lorg/apache/http/StatusLine;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.IStatusLine GetStatusLine() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IStatusLine);
				}

				/// <java-name>
				/// getEntity
				/// </java-name>
				[Dot42.DexImport("getEntity", "()Lorg/apache/http/HttpEntity;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.IHttpEntity GetEntity() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IHttpEntity);
				}

				/// <java-name>
				/// getLocale
				/// </java-name>
				[Dot42.DexImport("getLocale", "()Ljava/util/Locale;", AccessFlags = 1)]
				public virtual global::Java.Util.Locale GetLocale() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Locale);
				}

				/// <java-name>
				/// setStatusLine
				/// </java-name>
				[Dot42.DexImport("setStatusLine", "(Lorg/apache/http/StatusLine;)V", AccessFlags = 1)]
				public virtual void SetStatusLine(global::Org.Apache.Http.IStatusLine statusLine) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setStatusLine
				/// </java-name>
				[Dot42.DexImport("setStatusLine", "(Lorg/apache/http/ProtocolVersion;I)V", AccessFlags = 1)]
				public virtual void SetStatusLine(global::Org.Apache.Http.ProtocolVersion protocolVersion, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setStatusLine
				/// </java-name>
				[Dot42.DexImport("setStatusLine", "(Lorg/apache/http/ProtocolVersion;ILjava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetStatusLine(global::Org.Apache.Http.ProtocolVersion protocolVersion, int int32, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setStatusCode
				/// </java-name>
				[Dot42.DexImport("setStatusCode", "(I)V", AccessFlags = 1)]
				public virtual void SetStatusCode(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setReasonPhrase
				/// </java-name>
				[Dot42.DexImport("setReasonPhrase", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetReasonPhrase(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setEntity
				/// </java-name>
				[Dot42.DexImport("setEntity", "(Lorg/apache/http/HttpEntity;)V", AccessFlags = 1)]
				public virtual void SetEntity(global::Org.Apache.Http.IHttpEntity httpEntity) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setLocale
				/// </java-name>
				[Dot42.DexImport("setLocale", "(Ljava/util/Locale;)V", AccessFlags = 1)]
				public virtual void SetLocale(global::Java.Util.Locale locale) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getReason
				/// </java-name>
				[Dot42.DexImport("getReason", "(I)Ljava/lang/String;", AccessFlags = 4)]
				protected internal virtual string GetReason(int int32) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal BasicHttpResponse() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "containsHeader", "(Ljava/lang/String;)Z", AccessFlags = 1025)]
				public override bool ContainsHeader(string @string) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "getHeaders", "(Ljava/lang/String;)[Lorg/apache/http/Header;", AccessFlags = 1025)]
				public override global::Org.Apache.Http.IHeader[] GetHeaders(string @string) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Org.Apache.Http.IHeader[]);
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "getFirstHeader", "(Ljava/lang/String;)Lorg/apache/http/Header;", AccessFlags = 1025)]
				public override global::Org.Apache.Http.IHeader GetFirstHeader(string @string) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Org.Apache.Http.IHeader);
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "getLastHeader", "(Ljava/lang/String;)Lorg/apache/http/Header;", AccessFlags = 1025)]
				public override global::Org.Apache.Http.IHeader GetLastHeader(string @string) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Org.Apache.Http.IHeader);
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "getAllHeaders", "()[Lorg/apache/http/Header;", AccessFlags = 1025)]
				public override global::Org.Apache.Http.IHeader[] GetAllHeaders() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Org.Apache.Http.IHeader[]);
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "addHeader", "(Lorg/apache/http/Header;)V", AccessFlags = 1025)]
				public override void AddHeader(global::Org.Apache.Http.IHeader header) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "addHeader", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1025)]
				public override void AddHeader(string @string, string string1) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "setHeader", "(Lorg/apache/http/Header;)V", AccessFlags = 1025)]
				public override void SetHeader(global::Org.Apache.Http.IHeader header) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "setHeader", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1025)]
				public override void SetHeader(string @string, string string1) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "setHeaders", "([Lorg/apache/http/Header;)V", AccessFlags = 1025)]
				public override void SetHeaders(global::Org.Apache.Http.IHeader[] header) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "removeHeader", "(Lorg/apache/http/Header;)V", AccessFlags = 1025)]
				public override void RemoveHeader(global::Org.Apache.Http.IHeader header) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "removeHeaders", "(Ljava/lang/String;)V", AccessFlags = 1025)]
				public override void RemoveHeaders(string @string) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "headerIterator", "()Lorg/apache/http/HeaderIterator;", AccessFlags = 1025)]
				public override global::Org.Apache.Http.IHeaderIterator HeaderIterator() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Org.Apache.Http.IHeaderIterator);
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "headerIterator", "(Ljava/lang/String;)Lorg/apache/http/HeaderIterator;", AccessFlags = 1025)]
				public override global::Org.Apache.Http.IHeaderIterator HeaderIterator(string @string) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Org.Apache.Http.IHeaderIterator);
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "getParams", "()Lorg/apache/http/params/HttpParams;", AccessFlags = 1025)]
				public override global::Org.Apache.Http.Params.IHttpParams GetParams() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Org.Apache.Http.Params.IHttpParams);
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "setParams", "(Lorg/apache/http/params/HttpParams;)V", AccessFlags = 1025)]
				public override void SetParams(global::Org.Apache.Http.Params.IHttpParams httpParams) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				/// <java-name>
				/// getProtocolVersion
				/// </java-name>
				public global::Org.Apache.Http.ProtocolVersion ProtocolVersion
				{
				[Dot42.DexImport("getProtocolVersion", "()Lorg/apache/http/ProtocolVersion;", AccessFlags = 1)]
						get{ return GetProtocolVersion(); }
				}

				/// <java-name>
				/// getStatusLine
				/// </java-name>
				public global::Org.Apache.Http.IStatusLine StatusLine
				{
				[Dot42.DexImport("getStatusLine", "()Lorg/apache/http/StatusLine;", AccessFlags = 1)]
						get{ return GetStatusLine(); }
				[Dot42.DexImport("setStatusLine", "(Lorg/apache/http/StatusLine;)V", AccessFlags = 1)]
						set{ SetStatusLine(value); }
				}

				/// <java-name>
				/// getEntity
				/// </java-name>
				public global::Org.Apache.Http.IHttpEntity Entity
				{
				[Dot42.DexImport("getEntity", "()Lorg/apache/http/HttpEntity;", AccessFlags = 1)]
						get{ return GetEntity(); }
				[Dot42.DexImport("setEntity", "(Lorg/apache/http/HttpEntity;)V", AccessFlags = 1)]
						set{ SetEntity(value); }
				}

				/// <java-name>
				/// getLocale
				/// </java-name>
				public global::Java.Util.Locale Locale
				{
				[Dot42.DexImport("getLocale", "()Ljava/util/Locale;", AccessFlags = 1)]
						get{ return GetLocale(); }
				[Dot42.DexImport("setLocale", "(Ljava/util/Locale;)V", AccessFlags = 1)]
						set{ SetLocale(value); }
				}

				public global::Org.Apache.Http.IHeader[] AllHeaders
				{
				[Dot42.DexImport("org/apache/http/HttpMessage", "getAllHeaders", "()[Lorg/apache/http/Header;", AccessFlags = 1025)]
						get{ return GetAllHeaders(); }
				}

		}

		/// <java-name>
		/// org/apache/http/message/BasicLineFormatter
		/// </java-name>
		[Dot42.DexImport("org/apache/http/message/BasicLineFormatter", AccessFlags = 33)]
		public partial class BasicLineFormatter : global::Org.Apache.Http.Message.ILineFormatter
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// DEFAULT
				/// </java-name>
				[Dot42.DexImport("DEFAULT", "Lorg/apache/http/message/BasicLineFormatter;", AccessFlags = 25)]
				public static readonly global::Org.Apache.Http.Message.BasicLineFormatter DEFAULT;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public BasicLineFormatter() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// initBuffer
				/// </java-name>
				[Dot42.DexImport("initBuffer", "(Lorg/apache/http/util/CharArrayBuffer;)Lorg/apache/http/util/CharArrayBuffer;", AccessFlags = 4)]
				protected internal virtual global::Org.Apache.Http.Util.CharArrayBuffer InitBuffer(global::Org.Apache.Http.Util.CharArrayBuffer charArrayBuffer) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Util.CharArrayBuffer);
				}

				/// <java-name>
				/// formatProtocolVersion
				/// </java-name>
				[Dot42.DexImport("formatProtocolVersion", "(Lorg/apache/http/ProtocolVersion;Lorg/apache/http/message/LineFormatter;)Ljava/l" +
    "ang/String;", AccessFlags = 25)]
				public static string FormatProtocolVersion(global::Org.Apache.Http.ProtocolVersion protocolVersion, global::Org.Apache.Http.Message.ILineFormatter lineFormatter) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// appendProtocolVersion
				/// </java-name>
				[Dot42.DexImport("appendProtocolVersion", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/ProtocolVersion;)Lorg/apa" +
    "che/http/util/CharArrayBuffer;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.Util.CharArrayBuffer AppendProtocolVersion(global::Org.Apache.Http.Util.CharArrayBuffer charArrayBuffer, global::Org.Apache.Http.ProtocolVersion protocolVersion) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Util.CharArrayBuffer);
				}

				/// <java-name>
				/// estimateProtocolVersionLen
				/// </java-name>
				[Dot42.DexImport("estimateProtocolVersionLen", "(Lorg/apache/http/ProtocolVersion;)I", AccessFlags = 4)]
				protected internal virtual int EstimateProtocolVersionLen(global::Org.Apache.Http.ProtocolVersion protocolVersion) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// formatRequestLine
				/// </java-name>
				[Dot42.DexImport("formatRequestLine", "(Lorg/apache/http/RequestLine;Lorg/apache/http/message/LineFormatter;)Ljava/lang/" +
    "String;", AccessFlags = 25)]
				public static string FormatRequestLine(global::Org.Apache.Http.IRequestLine requestLine, global::Org.Apache.Http.Message.ILineFormatter lineFormatter) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// formatRequestLine
				/// </java-name>
				[Dot42.DexImport("formatRequestLine", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/RequestLine;)Lorg/apache/" +
    "http/util/CharArrayBuffer;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.Util.CharArrayBuffer FormatRequestLine(global::Org.Apache.Http.Util.CharArrayBuffer charArrayBuffer, global::Org.Apache.Http.IRequestLine requestLine) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Util.CharArrayBuffer);
				}

				/// <java-name>
				/// doFormatRequestLine
				/// </java-name>
				[Dot42.DexImport("doFormatRequestLine", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/RequestLine;)V", AccessFlags = 4)]
				protected internal virtual void DoFormatRequestLine(global::Org.Apache.Http.Util.CharArrayBuffer charArrayBuffer, global::Org.Apache.Http.IRequestLine requestLine) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// formatStatusLine
				/// </java-name>
				[Dot42.DexImport("formatStatusLine", "(Lorg/apache/http/StatusLine;Lorg/apache/http/message/LineFormatter;)Ljava/lang/S" +
    "tring;", AccessFlags = 25)]
				public static string FormatStatusLine(global::Org.Apache.Http.IStatusLine statusLine, global::Org.Apache.Http.Message.ILineFormatter lineFormatter) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// formatStatusLine
				/// </java-name>
				[Dot42.DexImport("formatStatusLine", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/StatusLine;)Lorg/apache/h" +
    "ttp/util/CharArrayBuffer;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.Util.CharArrayBuffer FormatStatusLine(global::Org.Apache.Http.Util.CharArrayBuffer charArrayBuffer, global::Org.Apache.Http.IStatusLine statusLine) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Util.CharArrayBuffer);
				}

				/// <java-name>
				/// doFormatStatusLine
				/// </java-name>
				[Dot42.DexImport("doFormatStatusLine", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/StatusLine;)V", AccessFlags = 4)]
				protected internal virtual void DoFormatStatusLine(global::Org.Apache.Http.Util.CharArrayBuffer charArrayBuffer, global::Org.Apache.Http.IStatusLine statusLine) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// formatHeader
				/// </java-name>
				[Dot42.DexImport("formatHeader", "(Lorg/apache/http/Header;Lorg/apache/http/message/LineFormatter;)Ljava/lang/Strin" +
    "g;", AccessFlags = 25)]
				public static string FormatHeader(global::Org.Apache.Http.IHeader header, global::Org.Apache.Http.Message.ILineFormatter lineFormatter) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// formatHeader
				/// </java-name>
				[Dot42.DexImport("formatHeader", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/Header;)Lorg/apache/http/" +
    "util/CharArrayBuffer;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.Util.CharArrayBuffer FormatHeader(global::Org.Apache.Http.Util.CharArrayBuffer charArrayBuffer, global::Org.Apache.Http.IHeader header) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Util.CharArrayBuffer);
				}

				/// <java-name>
				/// doFormatHeader
				/// </java-name>
				[Dot42.DexImport("doFormatHeader", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/Header;)V", AccessFlags = 4)]
				protected internal virtual void DoFormatHeader(global::Org.Apache.Http.Util.CharArrayBuffer charArrayBuffer, global::Org.Apache.Http.IHeader header) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// org/apache/http/message/BasicLineParser
		/// </java-name>
		[Dot42.DexImport("org/apache/http/message/BasicLineParser", AccessFlags = 33)]
		public partial class BasicLineParser : global::Org.Apache.Http.Message.ILineParser
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// DEFAULT
				/// </java-name>
				[Dot42.DexImport("DEFAULT", "Lorg/apache/http/message/BasicLineParser;", AccessFlags = 25)]
				public static readonly global::Org.Apache.Http.Message.BasicLineParser DEFAULT;
				/// <java-name>
				/// protocol
				/// </java-name>
				[Dot42.DexImport("protocol", "Lorg/apache/http/ProtocolVersion;", AccessFlags = 20)]
				protected internal readonly global::Org.Apache.Http.ProtocolVersion Protocol;
				[Dot42.DexImport("<init>", "(Lorg/apache/http/ProtocolVersion;)V", AccessFlags = 1)]
				public BasicLineParser(global::Org.Apache.Http.ProtocolVersion protocolVersion) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public BasicLineParser() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// parseProtocolVersion
				/// </java-name>
				[Dot42.DexImport("parseProtocolVersion", "(Ljava/lang/String;Lorg/apache/http/message/LineParser;)Lorg/apache/http/Protocol" +
    "Version;", AccessFlags = 25)]
				public static global::Org.Apache.Http.ProtocolVersion ParseProtocolVersion(string @string, global::Org.Apache.Http.Message.ILineParser lineParser) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.ProtocolVersion);
				}

				/// <java-name>
				/// parseProtocolVersion
				/// </java-name>
				[Dot42.DexImport("parseProtocolVersion", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/message/ParserCursor;)Lor" +
    "g/apache/http/ProtocolVersion;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.ProtocolVersion ParseProtocolVersion(global::Org.Apache.Http.Util.CharArrayBuffer charArrayBuffer, global::Org.Apache.Http.Message.ParserCursor parserCursor) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.ProtocolVersion);
				}

				/// <java-name>
				/// createProtocolVersion
				/// </java-name>
				[Dot42.DexImport("createProtocolVersion", "(II)Lorg/apache/http/ProtocolVersion;", AccessFlags = 4)]
				protected internal virtual global::Org.Apache.Http.ProtocolVersion CreateProtocolVersion(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.ProtocolVersion);
				}

				/// <java-name>
				/// hasProtocolVersion
				/// </java-name>
				[Dot42.DexImport("hasProtocolVersion", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/message/ParserCursor;)Z", AccessFlags = 1)]
				public virtual bool HasProtocolVersion(global::Org.Apache.Http.Util.CharArrayBuffer charArrayBuffer, global::Org.Apache.Http.Message.ParserCursor parserCursor) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// parseRequestLine
				/// </java-name>
				[Dot42.DexImport("parseRequestLine", "(Ljava/lang/String;Lorg/apache/http/message/LineParser;)Lorg/apache/http/RequestL" +
    "ine;", AccessFlags = 25)]
				public static global::Org.Apache.Http.IRequestLine ParseRequestLine(string @string, global::Org.Apache.Http.Message.ILineParser lineParser) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IRequestLine);
				}

				/// <java-name>
				/// parseRequestLine
				/// </java-name>
				[Dot42.DexImport("parseRequestLine", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/message/ParserCursor;)Lor" +
    "g/apache/http/RequestLine;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.IRequestLine ParseRequestLine(global::Org.Apache.Http.Util.CharArrayBuffer charArrayBuffer, global::Org.Apache.Http.Message.ParserCursor parserCursor) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IRequestLine);
				}

				/// <java-name>
				/// createRequestLine
				/// </java-name>
				[Dot42.DexImport("createRequestLine", "(Ljava/lang/String;Ljava/lang/String;Lorg/apache/http/ProtocolVersion;)Lorg/apach" +
    "e/http/RequestLine;", AccessFlags = 4)]
				protected internal virtual global::Org.Apache.Http.IRequestLine CreateRequestLine(string @string, string string1, global::Org.Apache.Http.ProtocolVersion protocolVersion) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IRequestLine);
				}

				/// <java-name>
				/// parseStatusLine
				/// </java-name>
				[Dot42.DexImport("parseStatusLine", "(Ljava/lang/String;Lorg/apache/http/message/LineParser;)Lorg/apache/http/StatusLi" +
    "ne;", AccessFlags = 25)]
				public static global::Org.Apache.Http.IStatusLine ParseStatusLine(string @string, global::Org.Apache.Http.Message.ILineParser lineParser) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IStatusLine);
				}

				/// <java-name>
				/// parseStatusLine
				/// </java-name>
				[Dot42.DexImport("parseStatusLine", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/message/ParserCursor;)Lor" +
    "g/apache/http/StatusLine;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.IStatusLine ParseStatusLine(global::Org.Apache.Http.Util.CharArrayBuffer charArrayBuffer, global::Org.Apache.Http.Message.ParserCursor parserCursor) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IStatusLine);
				}

				/// <java-name>
				/// createStatusLine
				/// </java-name>
				[Dot42.DexImport("createStatusLine", "(Lorg/apache/http/ProtocolVersion;ILjava/lang/String;)Lorg/apache/http/StatusLine" +
    ";", AccessFlags = 4)]
				protected internal virtual global::Org.Apache.Http.IStatusLine CreateStatusLine(global::Org.Apache.Http.ProtocolVersion protocolVersion, int int32, string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IStatusLine);
				}

				/// <java-name>
				/// parseHeader
				/// </java-name>
				[Dot42.DexImport("parseHeader", "(Ljava/lang/String;Lorg/apache/http/message/LineParser;)Lorg/apache/http/Header;", AccessFlags = 25)]
				public static global::Org.Apache.Http.IHeader ParseHeader(string @string, global::Org.Apache.Http.Message.ILineParser lineParser) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IHeader);
				}

				/// <java-name>
				/// parseHeader
				/// </java-name>
				[Dot42.DexImport("parseHeader", "(Lorg/apache/http/util/CharArrayBuffer;)Lorg/apache/http/Header;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.IHeader ParseHeader(global::Org.Apache.Http.Util.CharArrayBuffer charArrayBuffer) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IHeader);
				}

				/// <java-name>
				/// skipWhitespace
				/// </java-name>
				[Dot42.DexImport("skipWhitespace", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/message/ParserCursor;)V", AccessFlags = 4)]
				protected internal virtual void SkipWhitespace(global::Org.Apache.Http.Util.CharArrayBuffer charArrayBuffer, global::Org.Apache.Http.Message.ParserCursor parserCursor) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// org/apache/http/message/BasicListHeaderIterator
		/// </java-name>
		[Dot42.DexImport("org/apache/http/message/BasicListHeaderIterator", AccessFlags = 33)]
		public partial class BasicListHeaderIterator : global::Org.Apache.Http.IHeaderIterator
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// allHeaders
				/// </java-name>
				[Dot42.DexImport("allHeaders", "Ljava/util/List;", AccessFlags = 20)]
				protected internal readonly global::Java.Util.IList<object> AllHeaders;
				/// <java-name>
				/// currentIndex
				/// </java-name>
				[Dot42.DexImport("currentIndex", "I", AccessFlags = 4)]
				protected internal int CurrentIndex;
				/// <java-name>
				/// lastIndex
				/// </java-name>
				[Dot42.DexImport("lastIndex", "I", AccessFlags = 4)]
				protected internal int LastIndex;
				/// <java-name>
				/// headerName
				/// </java-name>
				[Dot42.DexImport("headerName", "Ljava/lang/String;", AccessFlags = 4)]
				protected internal string HeaderName;
				[Dot42.DexImport("<init>", "(Ljava/util/List;Ljava/lang/String;)V", AccessFlags = 1)]
				public BasicListHeaderIterator(global::Java.Util.IList<object> list, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// findNext
				/// </java-name>
				[Dot42.DexImport("findNext", "(I)I", AccessFlags = 4)]
				protected internal virtual int FindNext(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// filterHeader
				/// </java-name>
				[Dot42.DexImport("filterHeader", "(I)Z", AccessFlags = 4)]
				protected internal virtual bool FilterHeader(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// hasNext
				/// </java-name>
				[Dot42.DexImport("hasNext", "()Z", AccessFlags = 1)]
				public virtual bool HasNext() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// nextHeader
				/// </java-name>
				[Dot42.DexImport("nextHeader", "()Lorg/apache/http/Header;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.IHeader NextHeader() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IHeader);
				}

				/// <java-name>
				/// next
				/// </java-name>
				[Dot42.DexImport("next", "()Ljava/lang/Object;", AccessFlags = 17)]
				public object Next() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <java-name>
				/// remove
				/// </java-name>
				[Dot42.DexImport("remove", "()V", AccessFlags = 1)]
				public virtual void Remove() /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal BasicListHeaderIterator() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// org/apache/http/message/BasicNameValuePair
		/// </java-name>
		[Dot42.DexImport("org/apache/http/message/BasicNameValuePair", AccessFlags = 33)]
		public partial class BasicNameValuePair : global::Org.Apache.Http.INameValuePair, global::Java.Lang.ICloneable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public BasicNameValuePair(string @string, string string1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getName
				/// </java-name>
				[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetName() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getValue
				/// </java-name>
				[Dot42.DexImport("getValue", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetValue() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 1)]
				public override int GetHashCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/lang/Object;", AccessFlags = 1)]
				public virtual object Clone() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal BasicNameValuePair() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getName
				/// </java-name>
				public string Name
				{
				[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetName(); }
				}

				/// <java-name>
				/// getValue
				/// </java-name>
				public string Value
				{
				[Dot42.DexImport("getValue", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetValue(); }
				}

		}

		/// <java-name>
		/// org/apache/http/message/BasicRequestLine
		/// </java-name>
		[Dot42.DexImport("org/apache/http/message/BasicRequestLine", AccessFlags = 33)]
		public partial class BasicRequestLine : global::Org.Apache.Http.IRequestLine, global::Java.Lang.ICloneable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;Lorg/apache/http/ProtocolVersion;)V", AccessFlags = 1)]
				public BasicRequestLine(string @string, string string1, global::Org.Apache.Http.ProtocolVersion protocolVersion) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getMethod
				/// </java-name>
				[Dot42.DexImport("getMethod", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetMethod() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getProtocolVersion
				/// </java-name>
				[Dot42.DexImport("getProtocolVersion", "()Lorg/apache/http/ProtocolVersion;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.ProtocolVersion GetProtocolVersion() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.ProtocolVersion);
				}

				/// <java-name>
				/// getUri
				/// </java-name>
				[Dot42.DexImport("getUri", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetUri() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/lang/Object;", AccessFlags = 1)]
				public virtual object Clone() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal BasicRequestLine() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getMethod
				/// </java-name>
				public string Method
				{
				[Dot42.DexImport("getMethod", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetMethod(); }
				}

				/// <java-name>
				/// getProtocolVersion
				/// </java-name>
				public global::Org.Apache.Http.ProtocolVersion ProtocolVersion
				{
				[Dot42.DexImport("getProtocolVersion", "()Lorg/apache/http/ProtocolVersion;", AccessFlags = 1)]
						get{ return GetProtocolVersion(); }
				}

				/// <java-name>
				/// getUri
				/// </java-name>
				public string Uri
				{
				[Dot42.DexImport("getUri", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetUri(); }
				}

		}

		/// <java-name>
		/// org/apache/http/message/BasicStatusLine
		/// </java-name>
		[Dot42.DexImport("org/apache/http/message/BasicStatusLine", AccessFlags = 33)]
		public partial class BasicStatusLine : global::Org.Apache.Http.IStatusLine, global::Java.Lang.ICloneable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Lorg/apache/http/ProtocolVersion;ILjava/lang/String;)V", AccessFlags = 1)]
				public BasicStatusLine(global::Org.Apache.Http.ProtocolVersion protocolVersion, int int32, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getStatusCode
				/// </java-name>
				[Dot42.DexImport("getStatusCode", "()I", AccessFlags = 1)]
				public virtual int GetStatusCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getProtocolVersion
				/// </java-name>
				[Dot42.DexImport("getProtocolVersion", "()Lorg/apache/http/ProtocolVersion;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.ProtocolVersion GetProtocolVersion() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.ProtocolVersion);
				}

				/// <java-name>
				/// getReasonPhrase
				/// </java-name>
				[Dot42.DexImport("getReasonPhrase", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetReasonPhrase() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/lang/Object;", AccessFlags = 1)]
				public virtual object Clone() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal BasicStatusLine() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getStatusCode
				/// </java-name>
				public int StatusCode
				{
				[Dot42.DexImport("getStatusCode", "()I", AccessFlags = 1)]
						get{ return GetStatusCode(); }
				}

				/// <java-name>
				/// getProtocolVersion
				/// </java-name>
				public global::Org.Apache.Http.ProtocolVersion ProtocolVersion
				{
				[Dot42.DexImport("getProtocolVersion", "()Lorg/apache/http/ProtocolVersion;", AccessFlags = 1)]
						get{ return GetProtocolVersion(); }
				}

				/// <java-name>
				/// getReasonPhrase
				/// </java-name>
				public string ReasonPhrase
				{
				[Dot42.DexImport("getReasonPhrase", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetReasonPhrase(); }
				}

		}

		/// <java-name>
		/// org/apache/http/message/BasicTokenIterator
		/// </java-name>
		[Dot42.DexImport("org/apache/http/message/BasicTokenIterator", AccessFlags = 33)]
		public partial class BasicTokenIterator : global::Org.Apache.Http.ITokenIterator
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// HTTP_SEPARATORS
				/// </java-name>
				[Dot42.DexImport("HTTP_SEPARATORS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string HTTP_SEPARATORS = " ,;=()<>@:\\\"/[]?{}\t";
				/// <java-name>
				/// headerIt
				/// </java-name>
				[Dot42.DexImport("headerIt", "Lorg/apache/http/HeaderIterator;", AccessFlags = 20)]
				protected internal readonly global::Org.Apache.Http.IHeaderIterator HeaderIt;
				/// <java-name>
				/// currentHeader
				/// </java-name>
				[Dot42.DexImport("currentHeader", "Ljava/lang/String;", AccessFlags = 4)]
				protected internal string CurrentHeader;
				/// <java-name>
				/// currentToken
				/// </java-name>
				[Dot42.DexImport("currentToken", "Ljava/lang/String;", AccessFlags = 4)]
				protected internal string CurrentToken;
				/// <java-name>
				/// searchPos
				/// </java-name>
				[Dot42.DexImport("searchPos", "I", AccessFlags = 4)]
				protected internal int SearchPos;
				[Dot42.DexImport("<init>", "(Lorg/apache/http/HeaderIterator;)V", AccessFlags = 1)]
				public BasicTokenIterator(global::Org.Apache.Http.IHeaderIterator headerIterator) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// hasNext
				/// </java-name>
				[Dot42.DexImport("hasNext", "()Z", AccessFlags = 1)]
				public virtual bool HasNext() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// nextToken
				/// </java-name>
				[Dot42.DexImport("nextToken", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string NextToken() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// next
				/// </java-name>
				[Dot42.DexImport("next", "()Ljava/lang/Object;", AccessFlags = 17)]
				public object Next() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <java-name>
				/// remove
				/// </java-name>
				[Dot42.DexImport("remove", "()V", AccessFlags = 17)]
				public void Remove() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// findNext
				/// </java-name>
				[Dot42.DexImport("findNext", "(I)I", AccessFlags = 4)]
				protected internal virtual int FindNext(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// createToken
				/// </java-name>
				[Dot42.DexImport("createToken", "(Ljava/lang/String;II)Ljava/lang/String;", AccessFlags = 4)]
				protected internal virtual string CreateToken(string @string, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// findTokenStart
				/// </java-name>
				[Dot42.DexImport("findTokenStart", "(I)I", AccessFlags = 4)]
				protected internal virtual int FindTokenStart(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// findTokenSeparator
				/// </java-name>
				[Dot42.DexImport("findTokenSeparator", "(I)I", AccessFlags = 4)]
				protected internal virtual int FindTokenSeparator(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// findTokenEnd
				/// </java-name>
				[Dot42.DexImport("findTokenEnd", "(I)I", AccessFlags = 4)]
				protected internal virtual int FindTokenEnd(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// isTokenSeparator
				/// </java-name>
				[Dot42.DexImport("isTokenSeparator", "(C)Z", AccessFlags = 4)]
				protected internal virtual bool IsTokenSeparator(char @char) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isWhitespace
				/// </java-name>
				[Dot42.DexImport("isWhitespace", "(C)Z", AccessFlags = 4)]
				protected internal virtual bool IsWhitespace(char @char) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isTokenChar
				/// </java-name>
				[Dot42.DexImport("isTokenChar", "(C)Z", AccessFlags = 4)]
				protected internal virtual bool IsTokenChar(char @char) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isHttpSeparator
				/// </java-name>
				[Dot42.DexImport("isHttpSeparator", "(C)Z", AccessFlags = 4)]
				protected internal virtual bool IsHttpSeparator(char @char) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal BasicTokenIterator() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// org/apache/http/message/BufferedHeader
		/// </java-name>
		[Dot42.DexImport("org/apache/http/message/BufferedHeader", AccessFlags = 33)]
		public partial class BufferedHeader : global::Org.Apache.Http.IFormattedHeader, global::Java.Lang.ICloneable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Lorg/apache/http/util/CharArrayBuffer;)V", AccessFlags = 1)]
				public BufferedHeader(global::Org.Apache.Http.Util.CharArrayBuffer charArrayBuffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getName
				/// </java-name>
				[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetName() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getValue
				/// </java-name>
				[Dot42.DexImport("getValue", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetValue() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getElements
				/// </java-name>
				[Dot42.DexImport("getElements", "()[Lorg/apache/http/HeaderElement;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.IHeaderElement[] GetElements() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IHeaderElement[]);
				}

				/// <java-name>
				/// getValuePos
				/// </java-name>
				[Dot42.DexImport("getValuePos", "()I", AccessFlags = 1)]
				public virtual int GetValuePos() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getBuffer
				/// </java-name>
				[Dot42.DexImport("getBuffer", "()Lorg/apache/http/util/CharArrayBuffer;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.Util.CharArrayBuffer GetBuffer() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Util.CharArrayBuffer);
				}

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/lang/Object;", AccessFlags = 1)]
				public virtual object Clone() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal BufferedHeader() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getName
				/// </java-name>
				public string Name
				{
				[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetName(); }
				}

				/// <java-name>
				/// getValue
				/// </java-name>
				public string Value
				{
				[Dot42.DexImport("getValue", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetValue(); }
				}

				/// <java-name>
				/// getElements
				/// </java-name>
				public global::Org.Apache.Http.IHeaderElement[] Elements
				{
				[Dot42.DexImport("getElements", "()[Lorg/apache/http/HeaderElement;", AccessFlags = 1)]
						get{ return GetElements(); }
				}

				/// <java-name>
				/// getValuePos
				/// </java-name>
				public int ValuePos
				{
				[Dot42.DexImport("getValuePos", "()I", AccessFlags = 1)]
						get{ return GetValuePos(); }
				}

				/// <java-name>
				/// getBuffer
				/// </java-name>
				public global::Org.Apache.Http.Util.CharArrayBuffer Buffer
				{
				[Dot42.DexImport("getBuffer", "()Lorg/apache/http/util/CharArrayBuffer;", AccessFlags = 1)]
						get{ return GetBuffer(); }
				}

		}

		/// <java-name>
		/// org/apache/http/message/HeaderGroup
		/// </java-name>
		[Dot42.DexImport("org/apache/http/message/HeaderGroup", AccessFlags = 33)]
		public partial class HeaderGroup : global::Java.Lang.ICloneable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public HeaderGroup() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// clear
				/// </java-name>
				[Dot42.DexImport("clear", "()V", AccessFlags = 1)]
				public virtual void Clear() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addHeader
				/// </java-name>
				[Dot42.DexImport("addHeader", "(Lorg/apache/http/Header;)V", AccessFlags = 1)]
				public virtual void AddHeader(global::Org.Apache.Http.IHeader header) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// removeHeader
				/// </java-name>
				[Dot42.DexImport("removeHeader", "(Lorg/apache/http/Header;)V", AccessFlags = 1)]
				public virtual void RemoveHeader(global::Org.Apache.Http.IHeader header) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// updateHeader
				/// </java-name>
				[Dot42.DexImport("updateHeader", "(Lorg/apache/http/Header;)V", AccessFlags = 1)]
				public virtual void UpdateHeader(global::Org.Apache.Http.IHeader header) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setHeaders
				/// </java-name>
				[Dot42.DexImport("setHeaders", "([Lorg/apache/http/Header;)V", AccessFlags = 1)]
				public virtual void SetHeaders(global::Org.Apache.Http.IHeader[] header) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getCondensedHeader
				/// </java-name>
				[Dot42.DexImport("getCondensedHeader", "(Ljava/lang/String;)Lorg/apache/http/Header;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.IHeader GetCondensedHeader(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IHeader);
				}

				/// <java-name>
				/// getHeaders
				/// </java-name>
				[Dot42.DexImport("getHeaders", "(Ljava/lang/String;)[Lorg/apache/http/Header;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.IHeader[] GetHeaders(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IHeader[]);
				}

				/// <java-name>
				/// getFirstHeader
				/// </java-name>
				[Dot42.DexImport("getFirstHeader", "(Ljava/lang/String;)Lorg/apache/http/Header;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.IHeader GetFirstHeader(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IHeader);
				}

				/// <java-name>
				/// getLastHeader
				/// </java-name>
				[Dot42.DexImport("getLastHeader", "(Ljava/lang/String;)Lorg/apache/http/Header;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.IHeader GetLastHeader(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IHeader);
				}

				/// <java-name>
				/// getAllHeaders
				/// </java-name>
				[Dot42.DexImport("getAllHeaders", "()[Lorg/apache/http/Header;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.IHeader[] GetAllHeaders() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IHeader[]);
				}

				/// <java-name>
				/// containsHeader
				/// </java-name>
				[Dot42.DexImport("containsHeader", "(Ljava/lang/String;)Z", AccessFlags = 1)]
				public virtual bool ContainsHeader(string @string) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// iterator
				/// </java-name>
				[Dot42.DexImport("iterator", "()Lorg/apache/http/HeaderIterator;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.IHeaderIterator Iterator() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IHeaderIterator);
				}

				/// <java-name>
				/// iterator
				/// </java-name>
				[Dot42.DexImport("iterator", "(Ljava/lang/String;)Lorg/apache/http/HeaderIterator;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.IHeaderIterator Iterator(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IHeaderIterator);
				}

				/// <java-name>
				/// copy
				/// </java-name>
				[Dot42.DexImport("copy", "()Lorg/apache/http/message/HeaderGroup;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.Message.HeaderGroup Copy() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Message.HeaderGroup);
				}

				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/lang/Object;", AccessFlags = 1)]
				public virtual object Clone() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <java-name>
				/// getAllHeaders
				/// </java-name>
				public global::Org.Apache.Http.IHeader[] AllHeaders
				{
				[Dot42.DexImport("getAllHeaders", "()[Lorg/apache/http/Header;", AccessFlags = 1)]
						get{ return GetAllHeaders(); }
				}

		}

		/// <java-name>
		/// org/apache/http/message/HeaderValueFormatter
		/// </java-name>
		[Dot42.DexImport("org/apache/http/message/HeaderValueFormatter", AccessFlags = 1537)]
		public partial interface IHeaderValueFormatter
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// formatElements
				/// </java-name>
				[Dot42.DexImport("formatElements", "(Lorg/apache/http/util/CharArrayBuffer;[Lorg/apache/http/HeaderElement;Z)Lorg/apa" +
    "che/http/util/CharArrayBuffer;", AccessFlags = 1025)]
				global::Org.Apache.Http.Util.CharArrayBuffer FormatElements(global::Org.Apache.Http.Util.CharArrayBuffer charArrayBuffer, global::Org.Apache.Http.IHeaderElement[] headerElement, bool boolean) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// formatHeaderElement
				/// </java-name>
				[Dot42.DexImport("formatHeaderElement", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/HeaderElement;Z)Lorg/apac" +
    "he/http/util/CharArrayBuffer;", AccessFlags = 1025)]
				global::Org.Apache.Http.Util.CharArrayBuffer FormatHeaderElement(global::Org.Apache.Http.Util.CharArrayBuffer charArrayBuffer, global::Org.Apache.Http.IHeaderElement headerElement, bool boolean) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// formatParameters
				/// </java-name>
				[Dot42.DexImport("formatParameters", "(Lorg/apache/http/util/CharArrayBuffer;[Lorg/apache/http/NameValuePair;Z)Lorg/apa" +
    "che/http/util/CharArrayBuffer;", AccessFlags = 1025)]
				global::Org.Apache.Http.Util.CharArrayBuffer FormatParameters(global::Org.Apache.Http.Util.CharArrayBuffer charArrayBuffer, global::Org.Apache.Http.INameValuePair[] nameValuePair, bool boolean) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// formatNameValuePair
				/// </java-name>
				[Dot42.DexImport("formatNameValuePair", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/NameValuePair;Z)Lorg/apac" +
    "he/http/util/CharArrayBuffer;", AccessFlags = 1025)]
				global::Org.Apache.Http.Util.CharArrayBuffer FormatNameValuePair(global::Org.Apache.Http.Util.CharArrayBuffer charArrayBuffer, global::Org.Apache.Http.INameValuePair nameValuePair, bool boolean) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// org/apache/http/message/HeaderValueParser
		/// </java-name>
		[Dot42.DexImport("org/apache/http/message/HeaderValueParser", AccessFlags = 1537)]
		public partial interface IHeaderValueParser
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// parseElements
				/// </java-name>
				[Dot42.DexImport("parseElements", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/message/ParserCursor;)[Lo" +
    "rg/apache/http/HeaderElement;", AccessFlags = 1025)]
				global::Org.Apache.Http.IHeaderElement[] ParseElements(global::Org.Apache.Http.Util.CharArrayBuffer charArrayBuffer, global::Org.Apache.Http.Message.ParserCursor parserCursor) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// parseHeaderElement
				/// </java-name>
				[Dot42.DexImport("parseHeaderElement", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/message/ParserCursor;)Lor" +
    "g/apache/http/HeaderElement;", AccessFlags = 1025)]
				global::Org.Apache.Http.IHeaderElement ParseHeaderElement(global::Org.Apache.Http.Util.CharArrayBuffer charArrayBuffer, global::Org.Apache.Http.Message.ParserCursor parserCursor) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// parseParameters
				/// </java-name>
				[Dot42.DexImport("parseParameters", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/message/ParserCursor;)[Lo" +
    "rg/apache/http/NameValuePair;", AccessFlags = 1025)]
				global::Org.Apache.Http.INameValuePair[] ParseParameters(global::Org.Apache.Http.Util.CharArrayBuffer charArrayBuffer, global::Org.Apache.Http.Message.ParserCursor parserCursor) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// parseNameValuePair
				/// </java-name>
				[Dot42.DexImport("parseNameValuePair", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/message/ParserCursor;)Lor" +
    "g/apache/http/NameValuePair;", AccessFlags = 1025)]
				global::Org.Apache.Http.INameValuePair ParseNameValuePair(global::Org.Apache.Http.Util.CharArrayBuffer charArrayBuffer, global::Org.Apache.Http.Message.ParserCursor parserCursor) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// org/apache/http/message/LineFormatter
		/// </java-name>
		[Dot42.DexImport("org/apache/http/message/LineFormatter", AccessFlags = 1537)]
		public partial interface ILineFormatter
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// appendProtocolVersion
				/// </java-name>
				[Dot42.DexImport("appendProtocolVersion", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/ProtocolVersion;)Lorg/apa" +
    "che/http/util/CharArrayBuffer;", AccessFlags = 1025)]
				global::Org.Apache.Http.Util.CharArrayBuffer AppendProtocolVersion(global::Org.Apache.Http.Util.CharArrayBuffer charArrayBuffer, global::Org.Apache.Http.ProtocolVersion protocolVersion) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// formatRequestLine
				/// </java-name>
				[Dot42.DexImport("formatRequestLine", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/RequestLine;)Lorg/apache/" +
    "http/util/CharArrayBuffer;", AccessFlags = 1025)]
				global::Org.Apache.Http.Util.CharArrayBuffer FormatRequestLine(global::Org.Apache.Http.Util.CharArrayBuffer charArrayBuffer, global::Org.Apache.Http.IRequestLine requestLine) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// formatStatusLine
				/// </java-name>
				[Dot42.DexImport("formatStatusLine", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/StatusLine;)Lorg/apache/h" +
    "ttp/util/CharArrayBuffer;", AccessFlags = 1025)]
				global::Org.Apache.Http.Util.CharArrayBuffer FormatStatusLine(global::Org.Apache.Http.Util.CharArrayBuffer charArrayBuffer, global::Org.Apache.Http.IStatusLine statusLine) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// formatHeader
				/// </java-name>
				[Dot42.DexImport("formatHeader", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/Header;)Lorg/apache/http/" +
    "util/CharArrayBuffer;", AccessFlags = 1025)]
				global::Org.Apache.Http.Util.CharArrayBuffer FormatHeader(global::Org.Apache.Http.Util.CharArrayBuffer charArrayBuffer, global::Org.Apache.Http.IHeader header) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// org/apache/http/message/LineParser
		/// </java-name>
		[Dot42.DexImport("org/apache/http/message/LineParser", AccessFlags = 1537)]
		public partial interface ILineParser
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// parseProtocolVersion
				/// </java-name>
				[Dot42.DexImport("parseProtocolVersion", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/message/ParserCursor;)Lor" +
    "g/apache/http/ProtocolVersion;", AccessFlags = 1025)]
				global::Org.Apache.Http.ProtocolVersion ParseProtocolVersion(global::Org.Apache.Http.Util.CharArrayBuffer charArrayBuffer, global::Org.Apache.Http.Message.ParserCursor parserCursor) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// hasProtocolVersion
				/// </java-name>
				[Dot42.DexImport("hasProtocolVersion", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/message/ParserCursor;)Z", AccessFlags = 1025)]
				bool HasProtocolVersion(global::Org.Apache.Http.Util.CharArrayBuffer charArrayBuffer, global::Org.Apache.Http.Message.ParserCursor parserCursor) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// parseRequestLine
				/// </java-name>
				[Dot42.DexImport("parseRequestLine", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/message/ParserCursor;)Lor" +
    "g/apache/http/RequestLine;", AccessFlags = 1025)]
				global::Org.Apache.Http.IRequestLine ParseRequestLine(global::Org.Apache.Http.Util.CharArrayBuffer charArrayBuffer, global::Org.Apache.Http.Message.ParserCursor parserCursor) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// parseStatusLine
				/// </java-name>
				[Dot42.DexImport("parseStatusLine", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/message/ParserCursor;)Lor" +
    "g/apache/http/StatusLine;", AccessFlags = 1025)]
				global::Org.Apache.Http.IStatusLine ParseStatusLine(global::Org.Apache.Http.Util.CharArrayBuffer charArrayBuffer, global::Org.Apache.Http.Message.ParserCursor parserCursor) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// parseHeader
				/// </java-name>
				[Dot42.DexImport("parseHeader", "(Lorg/apache/http/util/CharArrayBuffer;)Lorg/apache/http/Header;", AccessFlags = 1025)]
				global::Org.Apache.Http.IHeader ParseHeader(global::Org.Apache.Http.Util.CharArrayBuffer charArrayBuffer) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// org/apache/http/message/ParserCursor
		/// </java-name>
		[Dot42.DexImport("org/apache/http/message/ParserCursor", AccessFlags = 33)]
		public partial class ParserCursor
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(II)V", AccessFlags = 1)]
				public ParserCursor(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getLowerBound
				/// </java-name>
				[Dot42.DexImport("getLowerBound", "()I", AccessFlags = 1)]
				public virtual int GetLowerBound() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getUpperBound
				/// </java-name>
				[Dot42.DexImport("getUpperBound", "()I", AccessFlags = 1)]
				public virtual int GetUpperBound() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getPos
				/// </java-name>
				[Dot42.DexImport("getPos", "()I", AccessFlags = 1)]
				public virtual int GetPos() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// updatePos
				/// </java-name>
				[Dot42.DexImport("updatePos", "(I)V", AccessFlags = 1)]
				public virtual void UpdatePos(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// atEnd
				/// </java-name>
				[Dot42.DexImport("atEnd", "()Z", AccessFlags = 1)]
				public virtual bool AtEnd() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ParserCursor() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getLowerBound
				/// </java-name>
				public int LowerBound
				{
				[Dot42.DexImport("getLowerBound", "()I", AccessFlags = 1)]
						get{ return GetLowerBound(); }
				}

				/// <java-name>
				/// getUpperBound
				/// </java-name>
				public int UpperBound
				{
				[Dot42.DexImport("getUpperBound", "()I", AccessFlags = 1)]
						get{ return GetUpperBound(); }
				}

				/// <java-name>
				/// getPos
				/// </java-name>
				public int Pos
				{
				[Dot42.DexImport("getPos", "()I", AccessFlags = 1)]
						get{ return GetPos(); }
				}

		}

}

