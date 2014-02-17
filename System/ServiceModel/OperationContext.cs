// Copyright (C) 2014 dot42
//
// Original filename: OperationContext.cs
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
    ///  Provides access to the execution context of a service method.
    /// </summary>
    public sealed class OperationContext //: IExtensibleObject<OperationContext>
    {
        [ThreadStatic]
        static OperationContext current;

        /// <summary>
        /// Gets or sets the execution context for the current thread.
        /// </summary>
        public static OperationContext Current
        {
            get { return current; }
            set { current = value; }
        }

        private IContextChannel channel;
        private bool isUserContext;

        /// <summary>
        /// Initializes a new instance of the OperationContext class
        /// </summary>
        /// <param name="channel"></param>
        public OperationContext(IContextChannel channel)
            : this(channel, true)
        {
        }

        public OperationContext(IContextChannel channel, bool isUserContext)
        {
            this.channel = channel;
            this.isUserContext = isUserContext;
        }

        /// <summary>
        /// Gets the channel associated with the current OperationContext object.
        /// </summary>
        public IContextChannel Channel {  get { return channel; } }
        
        /// <summary>
        /// This property is intended for system use and should not be called by users.
        /// </summary>
        public bool IsUserContext { get { return isUserContext; } }

        /// <summary>
        /// The identifier for the current session, if any.
        /// </summary>
        public string SessionId { get { return channel.SessionId; } }
    }
}

