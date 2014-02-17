// Copyright (C) 2014 dot42
//
// Original filename: WebChannelFactory.cs
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

namespace System.ServiceModel.Web
{
    /// <summary>
    /// A class for accessing Web services on a client.
    /// </summary>
    public class WebChannelFactory<TChannel> : ChannelFactory<TChannel> where TChannel : class
    {
        /// <summary>
        /// Initializes a new instance of the WebChannelFactory class.
        /// </summary>
        public WebChannelFactory()
        {   
        }

        /// <summary>
        /// Initializes a new instance of the WebChannelFactory class.
        /// </summary>
        public WebChannelFactory(Binding binding)
            :base(binding)
        {   
        }

        /*
        /// <summary>
        /// Initializes a new instance of the WebChannelFactory class.
        /// </summary>
        public WebChannelFactory(ServiceEndpoint endpoint);
        
        
        /// <summary>
        /// Initializes a new instance of the WebChannelFactory class.
        /// </summary>
        public WebChannelFactory(string endpointConfigurationName);
        
        /// <summary>
        /// Initializes a new instance of the WebChannelFactory class.
        /// </summary>
        public WebChannelFactory(Type channelType);
         */

        /// <summary>
        /// Initializes a new instance of the WebChannelFactory class.
        /// </summary>
        public WebChannelFactory(Uri remoteAddress)
            :this(new WebHttpBinding(), remoteAddress)
        { 
        }

        /// <summary>
        /// Initializes a new instance of the WebChannelFactory class.
        /// </summary>
        public WebChannelFactory(Binding binding, Uri remoteAddress)
            : base(binding, new EndpointAddress(remoteAddress))
        { 
        }

        /*
        /// <summary>
        /// Initializes a new instance of the WebChannelFactory class.
        /// </summary>
        public WebChannelFactory(string endpointConfigurationName, Uri remoteAddress);
  
        /// <summary>
        /// This method is called when the System.ServiceModel.Web.WebChannelFactory<TChannel> is opened.
        /// </summary>
        protected override void OnOpening();
        */
    }
}

