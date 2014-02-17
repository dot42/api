// Copyright (C) 2014 dot42
//
// Original filename: SessionMode.cs
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
    /// Specifies the values available to indicate the support for reliable sessions that a contract requires or supports.
    /// </summary>
    public enum SessionMode
    {
        /// <summary>
        /// The contract supports sessions if the incoming binding supports them.
        /// </summary>
        Allowed = 0,

        /// <summary>
        /// The contract requires a sessionful binding.
        /// </summary>
        Required = 1,
       
        /// <summary>
        /// The contract never supports bindings.
        /// </summary>
        NotAllowed = 2,
    }
}
