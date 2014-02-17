// Copyright (C) 2014 dot42
//
// Original filename: IChannelFactory.cs
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
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace System.ServiceModel.Channels
{
    /// <summary>
    ///  Defines the interface that must be implemented by a channel factory to produce channels.
    /// </summary>
    public interface IChannelFactory : ICommunicationObject
    {
        /*
        /// <summary>
        /// Returns a typed object requested, if present, from the appropriate layer in the channel stack.
        /// </summary>
        T GetProperty<T>() where T : class;
        */
    }
}

