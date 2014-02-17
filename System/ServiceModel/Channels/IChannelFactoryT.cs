// Copyright (C) 2014 dot42
//
// Original filename: IChannelFactoryT.cs
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
    /// Defines the interface that must be implemented by channel factories that create type-specific channels.
    /// </summary>
    public interface IChannelFactory<TChannel> : IChannelFactory, ICommunicationObject
    {
        /// <summary>
        ///  Creates a channel of a specified type to a specified endpoint address.
        /// </summary>
        TChannel CreateChannel(EndpointAddress to);
        
        /*
        //
        // Summary:
        //     Creates a channel of a specified type to a specified endpoint address and
        //     transport address to which messages are sent.
        //
        // Parameters:
        //   to:
        //     The System.ServiceModel.EndpointAddress that provides the location of the
        //     service.
        //
        //   via:
        //     The System.Uri that contains the transport address to which the message is
        //     sent.
        //
        // Returns:
        //     A channel of type TChannel to the specified endpoint address and transport
        //     address.
        /// <summary>
        /// 
        /// </summary>
        /// <param name="to"></param>
        /// <param name="via"></param>
        /// <returns></returns>
        TChannel CreateChannel(EndpointAddress to, Uri via);
        */
    }
}

