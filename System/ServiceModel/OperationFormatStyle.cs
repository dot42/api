// Copyright (C) 2014 dot42
//
// Original filename: OperationFormatStyle.cs
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
    /// the SOAP style that determines how the WSDL metadata for the service is formatted.
    /// </summary>
    public enum OperationFormatStyle
    {
        /// <summary>
        /// Operation contain a single element that represents the document.
        /// </summary>
        Document = 0,

        /// <summary>
        /// Operation contains parameters as if it were a remote procedure call.
        /// </summary>
        Rpc = 1,
    }
}
