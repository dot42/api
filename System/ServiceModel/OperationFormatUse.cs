// Copyright (C) 2014 dot42
//
// Original filename: OperationFormatUse.cs
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

namespace System.ServiceModel
{
    /// <summary>
    /// The format of the message.
    /// </summary>
    public enum OperationFormatUse
    {
        /// <summary>
        /// The message is a literal instance of the schema in the WSDL.
        /// </summary>
        Literal = 0,

        /// <summary>
        /// The schemas in the WSDL are abstract specifications that are encoded according to the rules found in SOAP 1.1 section 5.
        /// </summary>
        Encoded = 1,
    }
}
