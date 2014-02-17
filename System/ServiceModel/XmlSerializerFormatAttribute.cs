// Copyright (C) 2014 dot42
//
// Original filename: XmlSerializerFormatAttribute.cs
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
    /// Use the XmlSerializer.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method | AttributeTargets.Interface, Inherited = false, AllowMultiple = false)]
    public sealed class XmlSerializerFormatAttribute : Attribute
    {
        /// <summary>
        ///  Gets or sets the SOAP style of the System.Xml.Serialization.XmlSerializer.
        /// </summary>
        public OperationFormatStyle Style { get; set; }
      
        /// <summary>
        /// Whether the XmlSerializer should be used for reading and writing faults (otherwise DataContractSerializer will be used; default = false).
        /// </summary>
        public bool SupportFaults { get; set; }

        /// <summary>
        /// Specifies the format to use (default = Literal).
        /// </summary>
        public OperationFormatUse Use { get; set; }
    }
}

