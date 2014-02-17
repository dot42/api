// Copyright (C) 2014 dot42
//
// Original filename: EndpointAddress.cs
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
namespace System.ServiceModel
{ 
    /// <summary>
    /// Provides a unique network address that a client uses to communicate with a service endpoint.
    /// </summary>
    public class EndpointAddress
    {
        private readonly Uri uri;

        /// <summary>
        /// Initializes a new instance of the EndpointAddress class
        /// </summary>
        /// <param name="uri"></param>
        public EndpointAddress(string uri)
        {
            this.uri = new Uri(uri);
        }

        /// <summary>
        /// Initializes a new instance of the EndpointAddress class
        /// </summary>
        /// <param name="uri"></param>
        internal EndpointAddress(Uri uri)
        {
            this.uri = uri;
        }

        /// <summary>
        /// Gets the URI for the endpoint.
        /// </summary>
        public Uri Uri 
        {
            get { return uri; }
        }
    }
}

