// Copyright (C) 2014 dot42
//
// Original filename: ReceiverAttribute.cs
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

namespace Dot42.Manifest
{
    /// <summary>
    /// Declares a broadcast receiver (a BroadcastReceiver subclass) as one of the application's components. 
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, Inherited = false)]
    [Ignore]
    public sealed class ReceiverAttribute : ApplicationRootAttribute
    {
        /// <summary>
        /// Default ctor
        /// </summary>
        public ReceiverAttribute()
        {
            Enabled = true;
            Exported = true;
        }

        /// <summary>
        /// User readable label of the receiver.
        /// This should be set as a reference to a string resource, but it may be a literal string.
        /// </summary>
        public string Label { get; set; }

        /// <summary>
        /// Name of a drawable resource that holds the icon for this receiver.
        /// </summary>
        public string Icon { get; set; }

        /// <summary>
        /// Can this receiver be instantiated by the system?
        /// True by default.
        /// </summary>
        public bool Enabled { get; set; }

        /// <summary>
        /// Can this receiver receive messages from sources outside its application?
        /// True by default.
        /// </summary>
        public bool Exported { get; set; }

        /// <summary>
        /// The permission that broadcasters must have to send a message to this receiver.
        /// </summary>
        public string Permission { get; set; }

        /// <summary>
        /// The name of the process in which this reciever is run.
        /// </summary>
        public string Process { get; set; }
    }
}

