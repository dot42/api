// Copyright (C) 2014 dot42
//
// Original filename: ServiceContractAttribute.cs
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
    /// Indicates that an interface or a class defines a service contract.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, Inherited = false, AllowMultiple = false)]
    [Ignore]
    public sealed class ServiceContractAttribute : Attribute
    {
        /// <summary>
        /// The type of callback contract when the contract is a duplex contract (default is null).
        /// </summary>
        public Type CallbackContract { get; set; }

        /// <summary>
        /// The name used to locate the service in an application configuration file.
        /// </summary>
        public string ConfigurationName { get; set; }

        /// <summary>
        /// The name for the &lt;portType&gt; element in Web Services Description Language (WSDL).
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// the namespace of the &lt;portType&gt; element in Web Services Description Language (WSDL).
        /// </summary>
        public string Namespace { get; set; }

        /// <summary>
        /// The protection level the binding for this contract must support (default is None)
        /// </summary>
        public ProtectionLevel ProtectionLevel { get; set; }

        /// <summary>
        /// Whether sessions are allowed, not allowed or required.
        /// </summary>
        public SessionMode SessionMode { get; set; }
    }
}

