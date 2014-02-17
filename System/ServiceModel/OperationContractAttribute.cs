// Copyright (C) 2014 dot42
//
// Original filename: OperationContractAttribute.cs
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
using System.Net.Security;
using Dot42;

namespace System.ServiceModel
{
    /// <summary>
    /// Indicates that a method defines an operation that is part of a service contract.
    /// </summary>
    [AttributeUsage(AttributeTargets.Method)]
    [Ignore]
    public sealed class OperationContractAttribute : Attribute
    {
        public OperationContractAttribute()
        {
            IsInitiating = true;
        }

        /// <summary>
        /// Gets or sets the WS-Addressing action of the request message.
        /// </summary>
        public string Action { get; set; }
        
        /// <summary>
        /// Indicates that an operation is implemented asynchronously using a Begin[methodName]
        /// and End[methodName] method pair in a service contract (default is false).
        /// </summary>
        public bool AsyncPattern { get; set; }
        
        /// <summary>
        /// indicates whether the method implements an operation that can initiate a session on the server 
        /// (default is true)
        /// </summary>
        public bool IsInitiating { get; set; }

        /// <summary>
        /// indicates whether an operation returns a reply message. (default is false = two way)
        /// </summary>
        public bool IsOneWay { get; set; }

        /// <summary>
        /// indicates whether the service operation causes the server to close the session after the reply message, if any, is sent.
        /// (default is false)
        /// </summary>
        public bool IsTerminating { get; set; }

        /// <summary>
        /// The name of the operation.
        /// </summary>
        public string Name { get; set; }
        
        /// <summary>
        /// Specifies whether the messages of an operation must be encrypted, signed, or both. (default is None)
        /// </summary>
        public ProtectionLevel ProtectionLevel { get; set; }

        /// <summary>
        /// The value of the SOAP action for the reply message of the operation.
        /// </summary>
        public string ReplyAction { get; set; }
    }
}

