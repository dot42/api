// Copyright (C) 2014 dot42
//
// Original filename: WebResponse.cs
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
using System;
using System.IO;
using System.Runtime;
using System.Runtime.Serialization;

namespace System.Net
{
    /// <summary>
    /// Provides a response from a Uniform Resource Identifier (URI).
    /// </summary>
    public abstract class WebResponse : MarshalByRefObject, IDisposable
    {
        /// <summary>
        /// Creates a new instance of the WebResponse class.
        /// </summary>
        protected WebResponse() {}
        
        /// <summary>
        /// When overridden in a descendant class, gets or sets the content length of data being received.
        /// </summary>
        public virtual long ContentLength
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        /// <summary>
        /// When overridden in a derived class, gets or sets the content type of the data being received.
        /// </summary>
        public virtual string ContentType
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        /// <summary>
        /// When overridden in a derived class, gets a collection of header name-value pairs associated with this request.
        /// </summary>
        public virtual WebHeaderCollection Headers
        {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Whether this response was obtained from the cache.
        /// </summary>
        public virtual bool IsFromCache
        {
            get { return false; }
        }
        //
        // Summary:
        //     Gets a System.Boolean value that indicates whether mutual authentication
        //     occurred.
        //
        // Returns:
        //     true if both client and server were authenticated; otherwise, false.
        /// <summary>
        /// Whether mutual authentication occurred.
        /// </summary>
        public virtual bool IsMutuallyAuthenticated
        {
            get { return false; }
        }

        /// <summary>
        /// When overridden in a derived class, gets the URI of the Internet resource that actually responded to the request.
        /// </summary>
        public virtual Uri ResponseUri
        {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        /// When overridden by a descendant class, closes the response stream.
        /// </summary>
        public virtual void Close()
        {
            throw new NotImplementedException();
        }
     
        /// <summary>
        /// When overridden in a descendant class, returns the data stream from the Internet resource.
        /// </summary>
        /// <returns></returns>
        public virtual Stream GetResponseStream()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// IDisposable implementation
        /// </summary>
        public void Dispose()
        {
            Close();
        }
    }
}
