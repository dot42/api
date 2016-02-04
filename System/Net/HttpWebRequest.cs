// Copyright (C) 2014 dot42
//
// Original filename: HttpWebRequest.cs
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
using System.Net.Cache;

using Android.Net.Http;
using Android.Util;
using Org.Apache.Http;
using Org.Apache.Http.Client.Methods;
using Org.Apache.Http.Client.Params;
using Org.Apache.Http.Entity;
using Org.Apache.Http.Message;
using Org.Apache.Http.Params;

namespace System.Net
{
    /// <summary>
    ///  Provides an HTTP-specific implementation of the WebRequest class.
    /// </summary>
    public class HttpWebRequest : WebRequest
    {
        private Uri _requestUri;
        private Uri _address;

        private Stream _requestStream;
        private HttpRequestBase _request;

        static HttpWebRequest()
        {
            DefaultMaximumErrorResponseLength = -1;
        }

        internal HttpWebRequest(Uri requestUri)
        {
            _requestUri = requestUri;

            Headers = new WebHeaderCollection();

            MaximumAutomaticRedirections = 50;
            AllowAutoRedirect = true;
            AllowWriteStreamBuffering = true;
            Timeout = 100000; //(100 Seconds)
            Method = "GET";
            ProtocolVersion = HttpVersion.Version11;
        }


        /// <summary>
        /// Gets or sets the value of the Accept HTTP header.
        /// </summary>
        public string Accept
        {
            get { return Headers[HttpRequestHeader.Accept]; }
            set { Headers[HttpRequestHeader.Accept ] = value; }
        }

        /// <summary>
        /// Gets the Uniform Resource Identifier (URI) of the Internet resource that actually responds to the request.
        /// </summary>
        public Uri Address { get { return _address; } }

        /// <summary>
        ///  Whether the request should follow redirection responses (default is true).
        /// </summary>
        public bool AllowAutoRedirect { get; set; }

        /// <summary>
        /// Whether to buffer the data sent to the Internet resource (default is true).
        /// </summary>
        public bool AllowWriteStreamBuffering { get; set; }

        /// <summary>
        /// The type of decompression that is used.
        /// </summary>
        public DecompressionMethods AutomaticDecompression { get; set; }

        /*
        /// <summary>
        /// The collection of security certificates that are associated with this request.
        /// </summary>
        public X509CertificateCollection ClientCertificates { get; set; }
        */

        /// <summary>
        /// The value of the Connection HTTP header.
        /// </summary>
        public string Connection
        {
            get { return Headers[HttpRequestHeader.Connection]; }
            set { Headers[HttpRequestHeader.Connection] = value; }
        }

        /// <summary>
        /// the name of the connection group for the request (default = null).
        /// </summary>
        public override string ConnectionGroupName { get; set; }
       
        /// <summary>
        /// The Content-length HTTP header (default = -1, meaning no request data to send).
        /// </summary>
        public override long ContentLength
        {
            get
            {
                var contentLength = Headers[HttpRequestHeader.ContentLength];
                if (string.IsNullOrEmpty(contentLength)) return -1L;
                return long.Parse(contentLength);
            }
            set { Headers.Set(HttpRequestHeader.ContentLength, value.ToString()); }
        }
  
        /// <summary>
        /// he value of the Content-type HTTP header (default = null).
        /// </summary>
        public override string ContentType
        {
            get { return Headers[HttpRequestHeader.ContentType]; }
            set { Headers[HttpRequestHeader.ContentType] = value; }
        }

        /// <summary>
        /// The delegate method called when an HTTP 100-continue response is received from the Internet resource.
        /// </summary>
        public HttpContinueDelegate ContinueDelegate { get; set; }

        /*
        /// <summary>
        /// The cookies associated with the request.
        /// </summary>
        public CookieContainer CookieContainer { get; set; }
        */

        /// <summary>
        /// The authentication information for the request (default = null).
        /// </summary>
        public override ICredentials Credentials { get; set; }

        /// <summary>
        /// The Date HTTP header value to use in an HTTP request.
        /// </summary>
        public DateTime Date
        {
            get
            {
                var date = Headers[HttpRequestHeader.Date];
                if (string.IsNullOrEmpty(date)) return DateTime.MinValue;
                return DateTime.Parse(date);
            }
            set { Headers[HttpRequestHeader.Date] = value.ToString(); }
        }

        /// <summary>
        /// The default cache policy for this request.
        /// </summary>
        public static RequestCachePolicy DefaultCachePolicy { get; set; }
        
        /// <summary>
        /// The default maximum length of an HTTP error response (defualt is -1, meaning unlimited).
        /// </summary>
        public static int DefaultMaximumErrorResponseLength { get; set; }

        /// <summary>
        /// The default for the MaximumResponseHeadersLength property.
        /// </summary>
        public static int DefaultMaximumResponseHeadersLength { get; set; }

        /// <summary>
        /// The value of the Expect HTTP header.
        /// </summary>
        public string Expect
        {
            get { return Headers[HttpRequestHeader.Expect]; }
            set { Headers[HttpRequestHeader.Expect] = value; }
        }
       
        /// <summary>
        /// Whether a response has been received from an Internet resource.
        /// </summary>
        public bool HaveResponse
        {
            get { return _address != null; }
        }

        /// <summary>
        /// Specifies a collection of the name/value pairs that make up the HTTP headers.
        /// </summary>
        public override WebHeaderCollection Headers { get; set; }

        /// <summary>
        /// The Host header value to use in an HTTP request independent from the request URI.
        /// </summary>
        public string Host { get; set; }

        /// <summary>
        /// The value of the If-Modified-Since HTTP header (default is current).
        /// </summary>
        public DateTime IfModifiedSince
        {
            get
            {
                var date = Headers[HttpRequestHeader.Date];
                if (string.IsNullOrEmpty(date)) return DateTime.Now;
                return DateTime.Parse(date);
            }
            set { Headers[HttpRequestHeader.Date] = value.ToString(); }
        }

        /// <summary>
        /// Whether to make a persistent connection to the Internet resource (default = true).
        /// </summary>
        public bool KeepAlive
        {
            get
            {
                var keepAlive = Headers[HttpRequestHeader.KeepAlive];
                if (string.IsNullOrEmpty(keepAlive)) return true;
                return bool.Parse(keepAlive);
            }
            set { Headers[HttpRequestHeader.Date] = value.ToString(); }
        }

        /// <summary>
        /// The maximum number of redirects that the request follows (default = 50).
        /// </summary>
        public int MaximumAutomaticRedirections { get; set; }

        /// <summary>
        /// the maximum allowed length of the response headers (in kilobytes; default = -1)
        /// </summary>
        public int MaximumResponseHeadersLength { get; set; }

        /// <summary>
        /// The media type of the request.
        /// </summary>
        public string MediaType { get; set; }
        
        /// <summary>
        /// The method for the request (default = GET).
        /// </summary>
        public override string Method { get; set; }

        /// <summary>
        ///  whether to pipeline the request to the Internet resource.
        /// </summary>
        public bool Pipelined { get; set; }

        /// <summary>
        ///  Whether to send an Authorization header with the request.
        /// </summary>
        public override bool PreAuthenticate { get; set; }

        /// <summary>
        /// The version of HTTP to use for the request (default = Version 1.1)
        /// </summary>
        public Version ProtocolVersion { get; set; }

        /// <summary>
        /// Proxy information for the request.
        /// </summary>
        public override IWebProxy Proxy { get; set; }
        
        /// <summary>
        /// The time-out in milliseconds when writing to or reading from a stream (default = 300.000 [5 min]).
        /// </summary>
        public int ReadWriteTimeout { get; set; }

        /// <summary>
        /// The value of the Referer HTTP header (default = null).
        /// </summary>
        public string Referer
        {
            get { return Headers[HttpRequestHeader.Referer]; }
            set { Headers[HttpRequestHeader.Referer] = value; }
        }
        //
        // Summary:
        //     Gets the original Uniform Resource Identifier (URI) of the request.
        //
        // Returns:
        //     A System.Uri that contains the URI of the Internet resource passed to the
        //     System.Net.WebRequest.Create(System.String) method.
        public override Uri RequestUri
        {
            get { return _requestUri; }
        }

        /// <summary>
        /// Whether to send data in segments to the Internet resource (default = false).
        /// </summary>
        public bool SendChunked { get; set; }
       
        /*
        /// <summary>
        /// The service point to use for the request.
        /// </summary>
        public ServicePoint ServicePoint { get; }
        */
        
        /// <summary>
        /// the time-out value in milliseconds for the GetResponse() GetRequestStream() methods (default = 100,000 [100 seconds]).
        /// </summary>
        public override int Timeout { get; set; }

        /// <summary>
        /// The value of the Transfer-encoding HTTP header.
        /// </summary>
        public string TransferEncoding
        {
            get { return Headers[HttpRequestHeader.TransferEncoding]; }
            set { Headers[HttpRequestHeader.TransferEncoding] = value; }
        }

        /// <summary>
        /// Whether to allow high-speed NTLM-authenticated connection sharing.
        /// </summary>
        public bool UnsafeAuthenticatedConnectionSharing { get; set; }

        /// <summary>
        /// Whether default credentials are sent with requests (default = false).
        /// </summary>
        public override bool UseDefaultCredentials { get; set; }

        /// <summary>
        /// The value of the User-agent HTTP header.
        /// </summary>
        public string UserAgent
        {
            get { return Headers[HttpRequestHeader.UserAgent]; }
            set { Headers[HttpRequestHeader.UserAgent ] = value; }
        }

        /// <summary>
        /// Cancels a request to an Internet resource.
        /// </summary>
        public override void Abort()
        {
            if (_request != null) _request.Abort();
        }
        
        /// <summary>
        /// Adds a byte range header to a request for a specific range from the beginning or end of the requested data.
        /// </summary>
        /// <param name="range"></param>
        public void AddRange(int range)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Adds a byte range header to a request for a specific range from the beginning or end of the requested data.
        /// </summary>
        /// <param name="range"></param>
        public void AddRange(long range)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Adds a byte range header to the request for a specified range.
        /// </summary>
        public void AddRange(int from, int to)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Adds a byte range header to the request for a specified range.
        /// </summary>
        public void AddRange(long from, long to)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Adds a Range header to a request for a specific range from the beginning or end of the requested data.
        /// </summary>
        public void AddRange(string rangeSpecifier, int range)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Adds a Range header to a request for a specific range from the beginning or end of the requested data.
        /// </summary>
        /// <param name="rangeSpecifier"></param>
        /// <param name="range"></param>
        public void AddRange(string rangeSpecifier, long range)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Adds a range header to a request for a specified range.
        /// </summary>
        /// <param name="rangeSpecifier"></param>
        /// <param name="from"></param>
        /// <param name="to"></param>
        public void AddRange(string rangeSpecifier, int from, int to)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Adds a range header to a request for a specified range.
        /// </summary>
        public void AddRange(string rangeSpecifier, long from, long to)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Begins an asynchronous request for a System.IO.Stream object to use to write data.
        /// </summary>
        public override IAsyncResult BeginGetRequestStream(AsyncCallback callback, object state)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Begins an asynchronous request to an Internet resource.
        /// </summary>
        public override IAsyncResult BeginGetResponse(AsyncCallback callback, object state)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///  Ends an asynchronous request for a Stream object to use to write data.
        /// </summary>
        public override Stream EndGetRequestStream(IAsyncResult asyncResult)
        {
            throw new NotImplementedException();
        }

        /*
        /// <summary>
        /// Ends an asynchronous request to an Internet resource and outputs the context.
        /// </summary>
        public Stream EndGetRequestStream(IAsyncResult asyncResult, out TransportContext context);
        */

        /// <summary>
        /// Ends an asynchronous request to an Internet resource.
        /// </summary>
        public override WebResponse EndGetResponse(IAsyncResult asyncResult)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        ///  Gets a Stream object to use to write request data.
        /// </summary>
        public override Stream GetRequestStream()
        {
            return _requestStream ?? (_requestStream = new MemoryStream());
        }

        /*
         /// <summary>
        ///  Gets a Stream object to use to write request data and outputs the context.
        /// </summary>
        public Stream GetRequestStream(out TransportContext context);
        */

        /// <summary>
        /// Returns a response from an Internet resource.
        /// </summary>
        /// <remarks>
        /// You must close the returned response to avoid socket and memory leaks.
        /// </remarks>
        public override WebResponse GetResponse()
        {
#if ANDROID_8P
            var method = this.Method.ToLower();
            switch (method)
            {
                case "get":
                    _request = new HttpGet();
                    break;

                case "post":
                    _request = new HttpPost();
                    break;

                case "put":
                    _request = new HttpPut();
                    break;

                case "delete":
                    _request = new HttpDelete();
                    break;

                default: //the switch below is to prevent a C# compiler bug with 7 case statements. 
                    switch (method)
                    {
                        case "options":
                            _request = new HttpOptions();
                            break;

                        case "head":
                            _request = new HttpHead();
                            break;

                        case "trace":
                            _request = new HttpTrace();
                            break;

                        default:
                            throw new NotSupportedException(string.Format("Unsupported Method: {0}", this.Method));
                    }
                    break;
            }

            _request.SetURI(_requestUri);

            if (ContentLength != -1)
            {
                var entityRequest = _request as HttpEntityEnclosingRequestBase;
                if (entityRequest == null)
                    throw new NotSupportedException(string.Format("Method: {0} does not support a request stream",
                                                                  this.Method));
                if (_requestStream.Length < ContentLength)
                    throw new ArgumentException(
                        string.Format("ContentLength={0}, however the request stream contains only {1} bytes",
                                      ContentLength, _requestStream.Length));

                _requestStream.Seek(0L, SeekOrigin.Begin);
                entityRequest.Entity = new InputStreamEntity(_requestStream, ContentLength);
            }

            if (Headers != null)
            {
                var count = Headers.Count;
                for (var i = 0; i < count; i++)
                {
                    var key = Headers.GetKey(i);
                    if (key != "content-length") //The content length is set above.
                        _request.AddHeader(key, Headers.Get(i));
                }
            }

            AndroidHttpClient client = null;
            try
            {
                client = AndroidHttpClient.NewInstance(UserAgent);
                HttpClientParams.SetRedirecting(client.Params, this.AllowAutoRedirect);
                var response = client.Execute(_request);

                if (response == null)
                {
                    throw new Exception("Response is null");
                }

                var header = response.GetFirstHeader(WebHeaderCollection.HeaderToString(HttpResponseHeader.Location));
                var uri = header != null ? header.Value : null;
                _address = new Uri(!string.IsNullOrEmpty(uri) ? uri : _requestUri.ToString());

                var result = new HttpWebResponse(this, response, client);
                client = null; // So we won't release it, HttpWebResponse should now release it.
                return result;
            }
            finally
            {
                if(client != null) client.Close();
            }
#else
            throw new NotSupportedException("The HttpWebRequest is not supported on Android v2.1, but available as of v2.2");
#endif
        }
    }
}

