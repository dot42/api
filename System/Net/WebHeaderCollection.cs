// Copyright (C) 2014 dot42
//
// Original filename: WebHeaderCollection.cs
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
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;
//using Java.Util;
using Org.Apache.Http;

// See RFC 2068 par 4.2 Message Headers

namespace System.Net
{
    public class WebHeaderCollection : NameValueCollection
    {
        [Flags]
        internal enum HeaderInfo
        {
            Request = 1,
            Response = 1 << 1,
            MultiValue = 1 << 10
        }

        static readonly bool[] allowed_chars = {
			false, false, false, false, false, false, false, false, false, false, false, false, false, false,
			false, false, false, false, false, false, false, false, false, false, false, false, false, false,
			false, false, false, false, false, true, false, true, true, true, true, false, false, false, true,
			true, false, true, true, false, true, true, true, true, true, true, true, true, true, true, false,
			false, false, false, false, false, false, true, true, true, true, true, true, true, true, true,
			true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true,
			false, false, false, true, true, true, true, true, true, true, true, true, true, true, true, true,
			true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true,
			false, true, false
		};

        static readonly Dictionary<string, HeaderInfo> headers;
        HeaderInfo? headerRestriction;
        HeaderInfo? headerConsistency;

        static WebHeaderCollection()
        {
            headers = new Collections.Generic.Dictionary<string, HeaderInfo>() {
				{ "allow", HeaderInfo.MultiValue },
				{ "accept", HeaderInfo.Request | HeaderInfo.MultiValue },
				{ "accept-charset", HeaderInfo.MultiValue },
				{ "accept-encoding", HeaderInfo.MultiValue },
				{ "accept-language", HeaderInfo.MultiValue },
				{ "accept-ranges", HeaderInfo.MultiValue },
				{ "authorization", HeaderInfo.MultiValue },
				{ "cache-control", HeaderInfo.MultiValue },
				{ "cookie", HeaderInfo.MultiValue },
				{ "connection", HeaderInfo.Request | HeaderInfo.MultiValue },
				{ "content-encoding", HeaderInfo.MultiValue },
				{ "content-length", HeaderInfo.Request | HeaderInfo.Response },
				{ "content-type", HeaderInfo.Request },
				{ "content-language", HeaderInfo.MultiValue },
				{ "date", HeaderInfo.Request },
				{ "expect", HeaderInfo.Request | HeaderInfo.MultiValue},
				{ "host", HeaderInfo.Request },
				{ "if-match", HeaderInfo.MultiValue },
				{ "if-modified-since", HeaderInfo.Request },
				{ "if-none-match", HeaderInfo.MultiValue },
				{ "keep-alive", HeaderInfo.Response },
				{ "pragma", HeaderInfo.MultiValue },
				{ "proxy-authenticate", HeaderInfo.MultiValue },
				{ "proxy-authorization", HeaderInfo.MultiValue },
				{ "proxy-connection", HeaderInfo.Request | HeaderInfo.MultiValue },
				{ "range", HeaderInfo.Request | HeaderInfo.MultiValue },
				{ "referer", HeaderInfo.Request },
				{ "set-cookie", HeaderInfo.MultiValue },
				{ "set-cookie2", HeaderInfo.MultiValue },
				{ "te", HeaderInfo.MultiValue },
				{ "trailer", HeaderInfo.MultiValue },
				{ "transfer-encoding", HeaderInfo.Request | HeaderInfo.Response | HeaderInfo.MultiValue },
				{ "upgrade", HeaderInfo.MultiValue },
				{ "user-agent", HeaderInfo.Request },
				{ "vary", HeaderInfo.MultiValue },
				{ "via", HeaderInfo.MultiValue },
				{ "warning", HeaderInfo.MultiValue },
				{ "www-authenticate", HeaderInfo.Response | HeaderInfo. MultiValue }
			};
        }

        public WebHeaderCollection()
        {
        }

        internal WebHeaderCollection(HeaderInfo headerRestriction)
        {
            this.headerRestriction = headerRestriction;
        }

        internal WebHeaderCollection(IHeader[] headers)
        {
            foreach (var header in headers)
            {
                Add(header.GetName(), header.GetValue());
            }
        }

        public void Add(string header)
        {
            if (header == null)
                throw new ArgumentNullException("header");
            int pos = header.IndexOf(':');
            if (pos == -1)
                throw new ArgumentException("no colon found", "header");

            this.Add(header.Substring(0, pos), header.Substring(pos + 1));
        }

        public override void Add(string name, string value)
        {
            if (name == null)
                throw new ArgumentNullException("name");

            name = name.ToLower();

            CheckRestrictedHeader(name);
            this.AddWithoutValidate(name, value);
        }

        protected void AddWithoutValidate(string headerName, string headerValue)
        {
            headerName = headerName.ToLower();

            if (!IsHeaderName(headerName))
                throw new ArgumentException("invalid header name: " + headerName, "headerName");
            if (headerValue == null)
                headerValue = String.Empty;
            else
                headerValue = headerValue.Trim();
            if (!IsHeaderValue(headerValue))
                throw new ArgumentException("invalid header value: " + headerValue, "headerValue");

            AddValue(headerName, headerValue);
        }

        internal void AddValue(string headerName, string headerValue)
        {
            base.Add(headerName, headerValue);
        }

        internal string[] GetValues_internal(string header, bool split)
        {
            if (header == null)
                throw new ArgumentNullException("header");

            header = header.ToLower();

            string[] values = base.GetValues(header);
            if (values == null || values.Length == 0)
                return null;

            if (split && IsMultiValue(header))
            {
                List<string> separated = null;
                foreach (var value in values)
                {
                    if (value.IndexOf(',') < 0)
                        continue;

                    if (separated == null)
                    {
                        separated = new List<string>(values.Length + 1);
                        foreach (var v in values)
                        {
                            if (v == value)
                                break;

                            separated.Add(v);
                        }
                    }

                    var slices = value.Split(',');
                    var slices_length = slices.Length;
                    if (value[value.Length - 1] == ',')
                        --slices_length;

                    for (int i = 0; i < slices_length; ++i)
                    {
                        separated.Add(slices[i].Trim());
                    }
                }

                if (separated != null)
                    return separated.ToArray();
            }

            return values;
        }

        public override string[] GetValues(string header)
        {
            return GetValues_internal(header, true);
        }

        public override string[] GetValues(int index)
        {
            string[] values = base.GetValues(index);

            if (values == null || values.Length == 0)
            {
                return null;
            }

            return values;
        }

        public static bool IsRestricted(string headerName)
        {
            return IsRestricted(headerName, false);
        }

        public static bool IsRestricted(string headerName, bool response)
        {
            if (headerName == null)
                throw new ArgumentNullException("headerName");

            if (headerName.Length == 0)
                throw new ArgumentException("empty string", "headerName");

            if (!IsHeaderName(headerName))
                throw new ArgumentException("Invalid character in header");

            HeaderInfo info;
            if (!headers.TryGetValue(headerName, out info))
                return false;

            var flag = response ? HeaderInfo.Response : HeaderInfo.Request;
            return (info & flag) != 0;
        }

        public override void Remove(string name)
        {
            if (name == null)
                throw new ArgumentNullException("name");

            name = name.ToLower();

            CheckRestrictedHeader(name);
            base.Remove(name);
        }

        public override void Set(string name, string value)
        {
            if (name == null)
                throw new ArgumentNullException("name");

            name = name.ToLower();

            if (!IsHeaderName(name))
                throw new ArgumentException("invalid header name");
            if (value == null)
                value = String.Empty;
            else
                value = value.Trim();
            if (!IsHeaderValue(value))
                throw new ArgumentException("invalid header value");

            CheckRestrictedHeader(name);
            base.Set(name, value);
        }

        public byte[] ToByteArray()
        {
            return Encoding.UTF8.GetBytes(ToString());
        }

        internal string ToStringMultiValue()
        {
            StringBuilder sb = new StringBuilder();

            int count = base.Count;
            for (int i = 0; i < count; i++)
            {
                string key = GetKey(i);
                if (IsMultiValue(key))
                {
                    foreach (string v in GetValues(i))
                    {
                        sb.Append(key)
                          .Append(": ")
                          .Append(v)
                          .Append("\r\n");
                    }
                }
                else
                {
                    sb.Append(key)
                      .Append(": ")
                      .Append(Get(i))
                      .Append("\r\n");
                }
            }
            return sb.Append("\r\n").ToString();
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            int count = base.Count;
            for (int i = 0; i < count; i++)
                sb.Append(GetKey(i))
                  .Append(": ")
                  .Append(Get(i))
                  .Append("\r\n");

            return sb.Append("\r\n").ToString();
        }

        public void Add(HttpRequestHeader header, string value)
        {
            Add(RequestHeaderToString(header), value);
        }

        public void Remove(HttpRequestHeader header)
        {
            Remove(RequestHeaderToString(header));
        }

        public void Set(HttpRequestHeader header, string value)
        {
            Set(RequestHeaderToString(header), value);
        }

        public void Add(HttpResponseHeader header, string value)
        {
            Add(ResponseHeaderToString(header), value);
        }

        public void Remove(HttpResponseHeader header)
        {
            Remove(ResponseHeaderToString(header));
        }

        public void Set(HttpResponseHeader header, string value)
        {
            Set(ResponseHeaderToString(header), value);
        }

        public string this[HttpRequestHeader header]
        {
            get
            {
                return Get(RequestHeaderToString(header));
            }

            set
            {
                Set(header, value);
            }
        }

        public string this[HttpResponseHeader header]
        {
            get
            {
                return Get(ResponseHeaderToString(header));
            }

            set
            {
                Set(header, value);
            }
        }

        public override string Get(string name)
        {
            return base.Get(name.ToLower());
        }

        public override void Clear()
        {
            base.Clear();
        }

        internal void SetInternal(string header)
        {
            int pos = header.IndexOf(':');
            if (pos == -1)
                throw new ArgumentException("no colon found", "header");

            SetInternal(header.Substring(0, pos), header.Substring(pos + 1));
        }

        internal void SetInternal(string name, string value)
        {
            if (value == null)
                value = String.Empty;
            else
                value = value.Trim();
            if (!IsHeaderValue(value))
                throw new ArgumentException("invalid header value");

            if (IsMultiValue(name))
            {
                base.Add(name, value);
            }
            else
            {
                base.Remove(name);
                base.Set(name, value);
            }
        }

        internal void RemoveAndAdd(string name, string value)
        {
            if (value == null)
                value = String.Empty;
            else
                value = value.Trim();

            base.Remove(name);
            base.Set(name, value);
        }

        internal void RemoveInternal(string name)
        {
            if (name == null)
                throw new ArgumentNullException("name");
            base.Remove(name);
        }

        private string RequestHeaderToString(HttpRequestHeader value)
        {
            CheckHeaderConsistency(HeaderInfo.Request);

            return HeaderToString(value);
        }

        internal static string HeaderToString(HttpRequestHeader value)
        {
            switch (value)
            {
                case HttpRequestHeader.CacheControl:
                    return "cache-control";
                case HttpRequestHeader.Connection:
                    return "connection";
                case HttpRequestHeader.Date:
                    return "date";
                case HttpRequestHeader.KeepAlive:
                    return "keep-alive";
                case HttpRequestHeader.Pragma:
                    return "pragma";
                case HttpRequestHeader.Trailer:
                    return "trailer";
                case HttpRequestHeader.TransferEncoding:
                    return "transfer-encoding";
                case HttpRequestHeader.Upgrade:
                    return "upgrade";
                case HttpRequestHeader.Via:
                    return "via";
                case HttpRequestHeader.Warning:
                    return "warning";
                case HttpRequestHeader.Allow:
                    return "allow";
                case HttpRequestHeader.ContentLength:
                    return "content-length";
                case HttpRequestHeader.ContentType:
                    return "content-type";
                case HttpRequestHeader.ContentEncoding:
                    return "content-encoding";
                case HttpRequestHeader.ContentLanguage:
                    return "content-language";
                case HttpRequestHeader.ContentLocation:
                    return "content-location";
                case HttpRequestHeader.ContentMd5:
                    return "content-md5";
                case HttpRequestHeader.ContentRange:
                    return "content-range";
                case HttpRequestHeader.Expires:
                    return "expires";
                case HttpRequestHeader.LastModified:
                    return "last-modified";
                case HttpRequestHeader.Accept:
                    return "accept";
                case HttpRequestHeader.AcceptCharset:
                    return "accept-charset";
                case HttpRequestHeader.AcceptEncoding:
                    return "accept-encoding";
                case HttpRequestHeader.AcceptLanguage:
                    return "accept-language";
                case HttpRequestHeader.Authorization:
                    return "authorization";
                case HttpRequestHeader.Cookie:
                    return "cookie";
                case HttpRequestHeader.Expect:
                    return "expect";
                case HttpRequestHeader.From:
                    return "from";
                case HttpRequestHeader.Host:
                    return "host";
                case HttpRequestHeader.IfMatch:
                    return "if-match";
                case HttpRequestHeader.IfModifiedSince:
                    return "if-modified-since";
                case HttpRequestHeader.IfNoneMatch:
                    return "if-none-match";
                case HttpRequestHeader.IfRange:
                    return "if-range";
                case HttpRequestHeader.IfUnmodifiedSince:
                    return "if-unmodified-since";
                case HttpRequestHeader.MaxForwards:
                    return "max-forwards";
                case HttpRequestHeader.ProxyAuthorization:
                    return "proxy-authorization";
                case HttpRequestHeader.Referer:
                    return "referer";
                case HttpRequestHeader.Range:
                    return "range";
                case HttpRequestHeader.Te:
                    return "te";
                case HttpRequestHeader.Translate:
                    return "translate";
                case HttpRequestHeader.UserAgent:
                    return "user-agent";
                default:
                    throw new InvalidOperationException();
            }
        }

        private string ResponseHeaderToString(HttpResponseHeader value)
        {
            CheckHeaderConsistency(HeaderInfo.Response);

            return HeaderToString(value);
        }

         internal static string HeaderToString(HttpResponseHeader value)
         {
            switch (value)
            {
                case HttpResponseHeader.CacheControl:
                    return "cache-control";
                case HttpResponseHeader.Connection:
                    return "connection";
                case HttpResponseHeader.Date:
                    return "date";
                case HttpResponseHeader.KeepAlive:
                    return "keep-alive";
                case HttpResponseHeader.Pragma:
                    return "pragma";
                case HttpResponseHeader.Trailer:
                    return "trailer";
                case HttpResponseHeader.TransferEncoding:
                    return "transfer-encoding";
                case HttpResponseHeader.Upgrade:
                    return "upgrade";
                case HttpResponseHeader.Via:
                    return "via";
                case HttpResponseHeader.Warning:
                    return "warning";
                case HttpResponseHeader.Allow:
                    return "allow";
                case HttpResponseHeader.ContentLength:
                    return "content-length";
                case HttpResponseHeader.ContentType:
                    return "content-type";
                case HttpResponseHeader.ContentEncoding:
                    return "content-Eencoding";
                case HttpResponseHeader.ContentLanguage:
                    return "content-language";
                case HttpResponseHeader.ContentLocation:
                    return "content-location";
                case HttpResponseHeader.ContentMd5:
                    return "content-md5";
                case HttpResponseHeader.ContentRange:
                    return "content-range";
                case HttpResponseHeader.Expires:
                    return "expires";
                case HttpResponseHeader.LastModified:
                    return "last-modified";
                case HttpResponseHeader.AcceptRanges:
                    return "accept-ranges";
                case HttpResponseHeader.Age:
                    return "age";
                case HttpResponseHeader.ETag:
                    return "etag";
                case HttpResponseHeader.Location:
                    return "location";
                case HttpResponseHeader.ProxyAuthenticate:
                    return "proxy-authenticate";
                case HttpResponseHeader.RetryAfter:
                    return "retry-after";
                case HttpResponseHeader.Server:
                    return "server";
                case HttpResponseHeader.SetCookie:
                    return "set-cookie";
                case HttpResponseHeader.Vary:
                    return "vary";
                case HttpResponseHeader.WwwAuthenticate:
                    return "www-authenticate";
                default:
                    throw new InvalidOperationException();
            }
        }

        void CheckRestrictedHeader(string headerName)
        {
            if (!headerRestriction.HasValue)
                return;

            HeaderInfo info;
            if (!headers.TryGetValue(headerName, out info))
                return;

            if ((info & headerRestriction.Value) != 0)
                throw new ArgumentException("This header must be modified with the appropiate property.");
        }

        void CheckHeaderConsistency(HeaderInfo value)
        {
            if (!headerConsistency.HasValue)
            {
                headerConsistency = value;
                return;
            }

            if ((headerConsistency & value) == 0)
                throw new InvalidOperationException();
        }

        internal static bool IsMultiValue(string headerName)
        {
            if (headerName == null)
                return false;

            HeaderInfo info;
            return headers.TryGetValue(headerName, out info) && (info & HeaderInfo.MultiValue) != 0;
        }

        internal static bool IsHeaderValue(string value)
        {
            // TEXT any 8 bit value except CTL's (0-31 and 127)
            //      but including \r\n space and \t
            //      after a newline at least one space or \t must follow
            //      certain header fields allow comments ()

            int len = value.Length;
            for (int i = 0; i < len; i++)
            {
                char c = value[i];
                if (c == 127)
                    return false;
                if (c < 0x20 && (c != '\r' && c != '\n' && c != '\t'))
                    return false;
                if (c == '\n' && ++i < len)
                {
                    c = value[i];
                    if (c != ' ' && c != '\t')
                        return false;
                }
            }

            return true;
        }

        internal static bool IsHeaderName(string name)
        {
            if (name == null || name.Length == 0)
                return false;

            int len = name.Length;
            for (int i = 0; i < len; i++)
            {
                char c = name[i];
                if (c > 126 || !allowed_chars[c])
                    return false;
            }

            return true;
        }
    }
}

