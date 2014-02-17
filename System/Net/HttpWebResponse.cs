// Copyright (C) 2014 dot42
//
// Original filename: HttpWebResponse.cs
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
using System.Runtime.Serialization;
using System.Threading;
using Android.Net.Http;
using Java.Io;
using Org.Apache.Http;
using Org.Apache.Http.Util;

namespace System.Net
{
    /// <summary>
    ///  Provides an HTTP-specific implementation of the WebResponse class.
    /// </summary>
    public class HttpWebResponse : WebResponse
    {
        private readonly HttpWebRequest _webRequest;
        private readonly IHttpResponse _response;
        private readonly IHttpEntity _entity;
        private WebHeaderCollection _headers;
        private Stream _responseStream;
#if ANDROID_8P
        private AndroidHttpClient client;
#endif
        internal HttpWebResponse(HttpWebRequest webRequest, IHttpResponse response
#if ANDROID_8P
            , AndroidHttpClient client
#endif
            )
        {
            _webRequest = webRequest;
            _response = response;
#if ANDROID_8P
            this.client = client;
#endif
            _entity = _response.GetEntity();

            ThrowExceptionIfProtocolError();
        }

        private void ThrowExceptionIfProtocolError()
        {
            if ((int)StatusCode >= 300)
            {
                var msg = string.Format("The remote server returned an error: [{0}({1})] - {2}", StatusCode, (int)StatusCode, StatusDescription);
                throw new WebException(msg, null, WebExceptionStatus.ProtocolError, this);
            }
        }

        /// <summary>
        /// Gets the character set of the response.
        /// </summary>
        public string CharacterSet
        {
            get
            {
                // Content-Type   = "Content-Type" ":" media-type
                // media-type     = type "/" subtype *( ";" parameter )
                // parameter      = attribute "=" value
                // 3.7.1. default is ISO-8859-1
                var contentType = ContentType;
                if (contentType == null) return "ISO-8859-1";

                var val = contentType.ToLower();
                var pos = val.IndexOf("charset=");
                if (pos == -1) return "ISO-8859-1";
                pos += 8;
                var pos2 = val.IndexOf(';', pos);
                return (pos2 == -1) ? contentType.Substring(pos) : contentType.Substring(pos, pos2 - pos);
            }
        }

        /// <summary>
        /// Gets the method that is used to encode the body of the response.
        /// </summary>
        public string ContentEncoding
        {
            get
            {
                if (_entity == null) return null;
                var header = _entity.GetContentEncoding();
                return header != null ? header.GetValue() : null;
            }
        }

        /// <summary>
        ///  Gets the length of the content returned by the request (without header information).
        /// </summary>
        public override long ContentLength
        {
            get
            {
                if (_entity == null) return 0L;
                return _entity.GetContentLength();
            }
        }

        /// <summary>
        ///  Gets the content type of the response.
        /// </summary>
        public override string ContentType
        {
            get
            {
                if (_entity == null) return null;
                var header = _entity.GetContentType();
                return header != null ? header.GetValue() : null;
            }
        }

        /*
        /// <summary>
        /// Gets or sets the cookies that are associated with this response.
        /// </summary>
        public CookieCollection Cookies { get; set; }
        */

        /// <summary>
        /// Gets the headers that are associated with this response from the server.
        /// </summary>
        public override WebHeaderCollection Headers
        {
            get
            {
                if (_headers == null)
                {
                    _headers = new WebHeaderCollection(_response.GetAllHeaders());
                }

                return _headers;
            }
        }

        /// <summary>
        /// Whether both client and server were authenticated.
        /// </summary>
        public override bool IsMutuallyAuthenticated
        {
            get { return _response.GetParams().GetBooleanParameter("IsMutuallyAuthenticated", false); }
        }

        /// <summary>
        /// The last date and time that the contents of the response were modified.
        /// </summary>
        public DateTime LastModified
        {
            get
            {
                var header = _response.GetFirstHeader(WebHeaderCollection.HeaderToString(HttpResponseHeader.LastModified));
                return header != null ? DateTime.Parse(header.GetValue()) : DateTime.MinValue;
            }
        }

        /// <summary>
        /// The method that is used to return the response.
        /// </summary>
        public string Method
        {
            get { return _webRequest.Method; }
        }

        /// <summary>
        /// The version of the HTTP protocol that is used in the response.
        /// </summary>
        public Version ProtocolVersion
        {
            get
            {
                var version = _response.GetProtocolVersion();
                return new Version(version.GetMajor(), version.GetMinor());
            }
        }

        /// <summary>
        /// The URI of the Internet resource that responded to the request.
        /// </summary>
        public override Uri ResponseUri
        {
            get { return _webRequest.Address; }
        }

        /// <summary>
        /// The name of the server that sent the response.
        /// </summary>
        public string Server
        {
            get
            {
                var header = _response.GetFirstHeader(WebHeaderCollection.HeaderToString(HttpResponseHeader.Server));
                return header != null ? header.GetValue() : null;
            }
        }

        /// <summary>
        /// The status of the response.
        /// </summary>
        public HttpStatusCode StatusCode
        {
            get
            {
                var statusLine = _response.GetStatusLine();
                return (HttpStatusCode)statusLine.GetStatusCode();
            }
        }

        /// <summary>
        /// The status description returned with the response.
        /// </summary>
        public string StatusDescription
        {
            get
            {
                var statusLine = _response.GetStatusLine();
                return statusLine.GetReasonPhrase();
            }
        }

        /// <summary>
        ///  Closes the response stream.
        /// </summary>
        public override void Close()
        {
            if (_responseStream != null)
            {
                _responseStream.Close();
                _responseStream = null;
            }
#if ANDROID_8P
            if (client != null)
            {
                client.Close();
                client = null;
            }
#endif
        }

        /// <summary>
        ///  Gets the contents of a header that was returned with the response.
        /// </summary>
        public string GetResponseHeader(string headerName)
        {
            if (Headers == null) return null;

            return Headers.Get(headerName);
        }

        /// <summary>
        /// Gets the stream that is used to read the body of the response from the server.
        /// </summary>
        public override Stream GetResponseStream()
        {
            if (_entity == null)
                throw new NotSupportedException();
            return _responseStream ?? (_responseStream = new ResponseStream(_entity));
        }

        private sealed class ResponseStream : JavaInputStreamWrapper
        {
            private readonly long length;

            /// <summary>
            /// Default ctor
            /// </summary>
            public ResponseStream(IHttpEntity entity)
                : base(entity.GetContent())
            {
                length = entity.GetContentLength();
            }

            /// <summary>
            /// Gets the length of this sequence in bytes.
            /// </summary>
            public override long Length
            {
                get
                {
                    if (length >= 0)
                        return length;
                    throw new NotSupportedException();
                }
            }
        }
    }
}

