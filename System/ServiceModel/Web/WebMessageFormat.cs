// Copyright (C) 2014 dot42
//
// Original filename: WebMessageFormat.cs
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
namespace System.ServiceModel.Web
{
    /// <summary>
    /// The format of Web messages.
    /// </summary>
    public enum WebMessageFormat
    {  
        /// <summary>
        ///  The XML format.
        /// </summary>
        Xml = 0,
  
        /// <summary>
        ///  The JavaScript Object Notation (JSON) format.
        /// </summary>
        Json = 1,
    }
}

