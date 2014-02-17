// Copyright (C) 2014 dot42
//
// Original filename: WebRequest.cs
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
using System.IO;
using System.Net.Cache;
using System.Net.Security;
using System.Security.Principal;

namespace System.Net
{    
    /// <summary>
    /// Makes a request to a Uniform Resource Identifier (URI). This is an abstract class.
    /// </summary>
    public abstract class WebRequest : MarshalByRefObject
    {
        private static readonly Dictionary<string, IWebRequestCreate> webRequestCreators = new Dictionary<string, IWebRequestCreate>();
        
        static WebRequest()
        {
            IWebRequestCreate http = new HttpWebRequestCreator();
            RegisterPrefix("http", http);
            RegisterPrefix("https", http);

            //TODO: ftp, file
        }

        /// <summary>
        /// Initializes a new instance of the System.Net.WebRequest class.
        /// </summary>
        protected WebRequest()
        {
        }

        /// <summary>
        /// Gets or sets values indicating the level of authentication and impersonation used for this request.
        /// </summary>
        public AuthenticationLevel AuthenticationLevel { get; set; }
        
        /// <summary>
        /// Gets or sets the cache policy for this request.
        /// </summary>
        public virtual RequestCachePolicy CachePolicy { get; set; }
        
        /// <summary>
        /// When overridden in a descendant class, gets or sets the name of the connection group for the request.
        /// </summary>
        public virtual string ConnectionGroupName 
        { 
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
        
        /// <summary>
        /// When overridden in a descendant class, gets or sets the content length of the request data being sent.
        /// </summary>
        public virtual long ContentLength
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
       
        /// <summary>
        ///  When overridden in a descendant class, gets or sets the content type of the request data being sent.
        /// </summary>
        public virtual string ContentType
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        /// <summary>
        ///  When overridden in a descendant class, gets or sets the network credentials used for authenticating the request with the Internet resource.
        /// </summary>
        public virtual ICredentials Credentials
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Gets or sets the default cache policy for this request.
        /// </summary>
        public static RequestCachePolicy DefaultCachePolicy { get; set; }
        
        /// <summary>
        /// Gets or sets the global HTTP proxy.
        /// </summary>
        public static IWebProxy DefaultWebProxy { get; set; }

        /// <summary>
        /// When overridden in a descendant class, gets or sets the collection of header name/value pairs associated with the request.
        /// </summary>
        public virtual WebHeaderCollection Headers
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        /// <summary>
        ///  Gets or sets the impersonation level for the current request.
        /// </summary>
        public TokenImpersonationLevel ImpersonationLevel { get; set; }

        /// <summary>
        /// When overridden in a descendant class, gets or sets the protocol method to use in this request.
        /// </summary>
        public virtual string Method
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        /// <summary>
        ///  When overridden in a descendant class, indicates whether to pre-authenticate the request.
        /// </summary>
        public virtual bool PreAuthenticate
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        /// <summary>
        /// When overridden in a descendant class, gets or sets the network proxy to use to access this Internet resource.
        /// </summary>
        public virtual IWebProxy Proxy
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        /// <summary>
        /// When overridden in a descendant class, gets the URI of the Internet resource associated with the request.
        /// </summary>
        public virtual Uri RequestUri
        {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        ///  Gets or sets the length of time, in milliseconds, before the request times out.
        /// </summary>
        public virtual int Timeout
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        /// <summary>
        ///  When overridden in a descendant class, controls whether DefaultCredentials are sent with requests.
        /// </summary>
        public virtual bool UseDefaultCredentials
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Aborts the Request
        /// </summary>
        public virtual void Abort()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// When overridden in a descendant class, provides an asynchronous version of the GetRequestStream() method.
        /// </summary>
        public virtual IAsyncResult BeginGetRequestStream(AsyncCallback callback, object state)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// When overridden in a descendant class, begins an asynchronous request for an Internet resource.
        /// </summary>
        public virtual IAsyncResult BeginGetResponse(AsyncCallback callback, object state)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Initializes a new WebRequest instance for the specified URI scheme.
        /// </summary>
        public static WebRequest Create(string requestUriString)
        {
            return Create(new Uri(requestUriString));
        }
       
        /// <summary>
        /// Initializes a new WebRequest instance for the specified URI scheme.
        /// </summary>
        public static WebRequest Create(Uri requestUri)
        {
            return CreateDefault(requestUri);
        }

        /// <summary>
        /// Initializes a new HttpWebRequest instance for the specified URI scheme.
        /// </summary>
        public static HttpWebRequest CreateHttp(string requestUriString)
        {
            return CreateHttp(new Uri(requestUriString));
        }

        /// <summary>
        /// Initializes a new HttpWebRequest instance for the specified URI scheme.
        /// </summary>
        public static HttpWebRequest CreateHttp(Uri requestUri)
        {
            return (HttpWebRequest)CreateDefault(requestUri);
        }

        /// <summary>
        /// Initializes a new System.Net.WebRequest instance for the specified URI scheme.
        /// </summary>
        /// <remarks>
        /// Only the scheme portion of the URI will be taken into account.
        /// </remarks>
        public static WebRequest CreateDefault(Uri requestUri)
        {
            var scheme = requestUri.Scheme.ToLower();

            IWebRequestCreate creator;
            if (webRequestCreators.TryGetValue(scheme, out creator))
            {
                return creator.Create(requestUri);
            }
     
            throw new NotSupportedException("The requested scheme is not registered");
        }

        /// <summary>
        /// When overridden in a descendant class, returns a System.IO.Stream for writing data to the Internet resource.
        /// </summary>
        public virtual Stream EndGetRequestStream(IAsyncResult asyncResult)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// When overridden in a descendant class, returns a WebResponse.
        /// </summary>
        /// <param name="asyncResult"></param>
        /// <returns></returns>
        public virtual WebResponse EndGetResponse(IAsyncResult asyncResult)
        {
            throw new NotImplementedException();
        }
       
        /// <summary>
        ///  When overridden in a descendant class, returns a System.IO.Stream for writing data to the Internet resource.
        /// </summary>
        /// <returns></returns>
        public virtual Stream GetRequestStream()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///  When overridden in a descendant class, returns a response to an Internet request.
        /// </summary>
        public virtual WebResponse GetResponse()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///  Returns a proxy configured with the Internet Explorer settings of the currently impersonated user.
        /// </summary>
        /// <returns></returns>
        public static IWebProxy GetSystemWebProxy()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///  Registers a WebRequest descendant for the specified URI.
        /// </summary>
        public static bool RegisterPrefix(string prefix, IWebRequestCreate creator)
        {
            prefix = prefix.ToLower();

            if (webRequestCreators.ContainsKey(prefix)) return false;
            
            webRequestCreators.Add(prefix, creator);
            
            return true;
        }
    }
}

