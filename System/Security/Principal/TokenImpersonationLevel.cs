// Copyright (C) 2014 dot42
//
// Original filename: TokenImpersonationLevel.cs
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
namespace System.Security.Principal
{
    /// <summary>
    ///  Defines security impersonation levels.
    /// </summary>
    [Serializable]
    public enum TokenImpersonationLevel
    {
        /// <summary>
        /// An impersonation level is not assigned.
        /// </summary>
        None = 0,
 
        /// <summary>
        /// The server process cannot obtain identification information about the client, and it cannot impersonate the client.
        /// </summary>
        Anonymous = 1,
        
        /// <summary>
        /// The server process can obtain information about the client, such as security identifiers and privileges, but it cannot impersonate the client.
        /// </summary>
        Identification = 2,
      
        /// <summary>
        /// The server process can impersonate the client's security context on its local system.
        /// </summary>
        Impersonation = 3,

        /// <summary>
        ///  The server process can impersonate the client's security context on remote systems.
        /// </summary>
        Delegation = 4,
    }
}

