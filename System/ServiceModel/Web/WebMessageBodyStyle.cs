// Copyright (C) 2014 dot42
//
// Original filename: WebMessageBodyStyle.cs
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
    /// Whether to wrap parameters or not.
    /// </summary>
    public enum WebMessageBodyStyle
    {  
        /// <summary>
        ///  Both requests and responses are not wrapped.
        /// </summary>
        Bare = 0,
    
        /// <summary>
        /// Both requests and responses are wrapped.
        /// </summary>
        Wrapped = 1,
    
        /// <summary>
        /// Requests are wrapped, responses are not wrapped.
        /// </summary>
        WrappedRequest = 2,
   
        /// <summary>
        /// Responses are wrapped, requests are not wrapped.
        /// </summary>
        WrappedResponse = 3,
    }
}

