// Copyright (C) 2014 dot42
//
// Original filename: IWebProxy.cs
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
namespace System.Net
{
    /// <summary>
    ///  Provides the base interface for implementation of proxy access for the System.Net.WebRequest class.
    /// </summary>
    public interface IWebProxy
    {
        /// <summary>
        ///  The credentials to submit to the proxy server for authentication.
        /// </summary>
        ICredentials Credentials { get; set; }

        /// <summary>
        ///  Returns the URI of a proxy.
        /// </summary>
        Uri GetProxy(Uri destination);

        /// <summary>
        /// Indicates that the proxy should not be used for the specified host.
        /// </summary>
        bool IsBypassed(Uri host);
    }
}

