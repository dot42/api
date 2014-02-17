// Copyright (C) 2014 dot42
//
// Original filename: AuthenticationLevel.cs
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
namespace System.Net.Security
{
    /// <summary>
    /// Specifies client requirements for authentication and impersonation when using
    /// the System.Net.WebRequest class and derived classes to request a resource.
    /// </summary>
    public enum AuthenticationLevel
    {    
        /// <summary>
        /// No authentication is required for the client and server.
        /// </summary>
        None = 0,
        
        /// <summary>
        /// The client and server may be authenticated.
        /// </summary>
        MutualAuthRequested = 1,
       
        /// <summary>
        ///  The client and server should be authenticated.
        /// </summary>
        MutualAuthRequired = 2,
    }
}
