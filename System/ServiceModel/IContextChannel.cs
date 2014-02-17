// Copyright (C) 2014 dot42
//
// Original filename: IContextChannel.cs
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
using System.ServiceModel.Channels;


namespace System.ServiceModel
{
    // Summary:
    //     Defines the interface for the context control of a channel.
    public interface IContextChannel : IChannel, ICommunicationObject //, IExtensibleObject<IContextChannel>
    {
        /*
        /// <summary>
        /// Gets or sets a value that instructs to store a set of messages before giving the messages to the transport.
        /// </summary>
        bool AllowOutputBatching { get; set; }

        /// <summary>
        /// Gets the input session for the channel.
        /// </summary>
        IInputSession InputSession { get; }

        /// <summary>
        /// Gets the local endpoint for the channel.
        /// </summary>
        EndpointAddress LocalAddress { get; }
       
        /// <summary>
        /// the time period within which an operation must complete or an exception is thrown.
        /// </summary>
        TimeSpan OperationTimeout { get; set; }
         
        /// <summary>
        /// Gets the output session associated with the channel, if any.
        /// </summary>
        IOutputSession OutputSession { get; }
         */
        
        /// <summary>
        /// Gets the remote address associated with the channel.
        /// </summary>
        EndpointAddress RemoteAddress { get; }
        
        /// <summary>
        ///  Returns an identifier for the current session, if any.
        /// </summary>
        string SessionId { get; }

    }
}

