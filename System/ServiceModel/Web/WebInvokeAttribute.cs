// Copyright (C) 2014 dot42
//
// Original filename: WebInvokeAttribute.cs
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
using Dot42;

namespace System.ServiceModel.Web
{
    /// <summary>
    /// A REST invoke operation (contract)
    /// </summary>
    [AttributeUsage(AttributeTargets.Method)]
    [Ignore]
    public sealed class WebInvokeAttribute : Attribute
    {
        /// <summary>
        /// Whether to wrap parameters or not.
        /// </summary>
        public WebMessageBodyStyle BodyStyle { get; set; }
        
        /// <summary>
        ///  The protocol method associated with the operation (PUT, POST, DELETE).
        /// </summary>
        public string Method { get; set; }

        /// <summary>
        /// The request format to use.
        /// </summary>
        public WebMessageFormat RequestFormat { get; set; }

        /// <summary>
        /// The response format to use.
        /// </summary>
        public WebMessageFormat ResponseFormat { get; set; }
   
        /// <summary>
        /// The URI template for the service operation.
        /// </summary>
        public string UriTemplate { get; set; }
    }
}

