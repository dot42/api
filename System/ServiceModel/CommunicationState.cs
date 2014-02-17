// Copyright (C) 2014 dot42
//
// Original filename: CommunicationState.cs
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

namespace System.ServiceModel
{
    /// <summary>
    /// Defines the states in which an ICommunicationObject can exist.
    /// </summary>
    public enum CommunicationState
    {
        // Summary:
        //     Indicates that the communication object has been instantiated and is configurable,
        //     but not yet open or ready for use.
        Created = 0,
        //
        // Summary:
        //     Indicates that the communication object is being transitioned from the System.ServiceModel.CommunicationState.Created
        //     state to the System.ServiceModel.CommunicationState.Opened state.
        Opening = 1,
        //
        // Summary:
        //     Indicates that the communication object is now open and ready to be used.
        Opened = 2,
        //
        // Summary:
        //     Indicates that the communication object is transitioning to the System.ServiceModel.CommunicationState.Closed
        //     state.
        Closing = 3,
        //
        // Summary:
        //     Indicates that the communication object has been closed and is no longer
        //     usable.
        Closed = 4,
        //
        // Summary:
        //     Indicates that the communication object has encountered an error or fault
        //     from which it cannot recover and from which it is no longer usable.
        Faulted = 5,
    }
}

