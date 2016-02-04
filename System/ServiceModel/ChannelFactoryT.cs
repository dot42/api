// Copyright (C) 2014 dot42
//
// Original filename: ChannelFactoryT.cs
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
using System.Linq;

using System.ServiceModel.Channels;
using Java.Lang;


namespace System.ServiceModel
{
    /// <summary>
    /// A factory that creates channels of different types that are used by clients 
    /// to send messages to variously configured service endpoints.
    /// </summary>
    /// <typeparam name="TChannel"></typeparam>
    public class ChannelFactory<TChannel> : ChannelFactory, IChannelFactory<TChannel>, IChannelFactory, ICommunicationObject
    {
        private Binding binding;
        //private ServiceEndpoint endpoint;
        private EndpointAddress remoteAddress;

        /// <summary>
        /// Initializes a new instance of the ChannelFactory class.
        /// </summary>
        public ChannelFactory()
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the ChannelFactory class.
        /// </summary>
        public ChannelFactory(Binding binding)
        {
            this.binding = binding;
        }
        
        /*
        /// <summary>
        /// Initializes a new instance of the ChannelFactory class.
        /// </summary>
        public ChannelFactory(ServiceEndpoint endpoint);

        /// <summary>
        /// Initializes a new instance of the ChannelFactory class.
        /// </summary>
        public ChannelFactory(string endpointConfigurationName);
        */

        /*
        /// <summary>
        /// Initializes a new instance of the ChannelFactory class.
        /// </summary>
        protected ChannelFactory(Type channelType);
        */

        /// <summary>
        /// Initializes a new instance of the ChannelFactory class.
        /// </summary>
        public ChannelFactory(Binding binding, EndpointAddress remoteAddress)
        {
            this.binding = binding;
            this.remoteAddress = remoteAddress;
        }

        /// <summary>
        /// Initializes a new instance of the ChannelFactory class.
        /// </summary>
        public ChannelFactory(Binding binding, string remoteAddress)
        {
            this.binding = binding;
            this.remoteAddress = new EndpointAddress(remoteAddress);
        }

        /*
        /// <summary>
        /// Initializes a new instance of the ChannelFactory class.
        /// </summary>
        public ChannelFactory(string endpointConfigurationName, EndpointAddress remoteAddress);
        */
          
        /// <summary>
        ///  Creates a channel of a specified type.
        /// </summary>
        public TChannel CreateChannel()
        {
            return CreateChannel(remoteAddress);
        }
        
        /// <summary>
        /// Creates a channel of a specified type.
        /// </summary>
        public TChannel CreateChannel(EndpointAddress address)
        {
            if(State != CommunicationState.Opened) throw new CommunicationException("ChannelFactory is not in Opened state.");
            return CreateChannel(binding, address);
        }
        
        /*
        //
        // Summary:
        //     Creates a channel that is used to send messages to a service whose endpoint
        //     is configured in a specified way.
        //
        // Parameters:
        //   endpointConfigurationName:
        //     The name of the endpoint configuration used for the service.
        //
        // Returns:
        //     The TChannel of type System.ServiceModel.Channels.IChannel created by the
        //     factory.
        //
        // Exceptions:
        //   System.InvalidOperationException:
        //     The System.ServiceModel.ChannelFactory has duplex operations it does not
        //     support.
        protected static TChannel CreateChannel(string endpointConfigurationName);
        */

        /// <summary>
        /// Creates a channel of a specified type that is used to send messages to a service endpoint
        /// </summary>
        public static TChannel CreateChannel(Binding binding, EndpointAddress endpointAddress)
        {          
            const string @namespace = "dot42.Generated.Wcf";
            const string prefix = "__WcfProxy";

            var interfaceType = typeof (TChannel);
            var interfaceName = interfaceType.Name;

            var className = string.Format("{0}.{1}{2}", @namespace, interfaceName, prefix);

            try
            {
                var proxyType = interfaceType.GetClassLoader().LoadClass(className);
                if (proxyType == null) throw new NotSupportedException("Cannot load proxy class for type: " + interfaceName);

                var constructors = proxyType.GetConstructors();
                if (constructors == null || constructors.Length != 1) throw new NotSupportedException("Cannot resolve constuctors proxy class for type: " + interfaceName);

                var constructor = constructors[0];
                if (constructor == null) throw new NotSupportedException("Cannot resolve constuctor proxy class for type: " + interfaceName);

                var obj = constructor.Invoke(new []{ endpointAddress.Uri });
                if (obj == null) throw new NotSupportedException("Cannot instanciate proxy class for type: " + interfaceName);

                if (!(obj is TChannel)) throw new NotSupportedException("Cannot cast instanciated proxy class for type: " + interfaceName);

                return (TChannel) obj;
            }
            catch (NotSupportedException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new NotSupportedException(string.Format("Cannot create channel for: {0} [implemented by {1}], because {2}", interfaceName, className, ex), ex);
            }
        }
        
        /*
        //
        // Summary:
        //     Creates a channel that is used to send messages to a service at a specific
        //     endpoint address through a specified transport address.
        //
        // Parameters:
        //   address:
        //     The System.ServiceModel.EndpointAddress that provides the location of the
        //     service.
        //
        //   via:
        //     The System.Uri that contains the transport address to which the channel sends
        //     messages.
        //
        // Returns:
        //     The TChannel of type System.ServiceModel.Channels.IChannel created by the
        //     factory.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     address is null.
        //
        //   System.InvalidOperationException:
        //     The System.ServiceModel.ChannelFactory has duplex operations it does not
        //     support.
        public virtual TChannel CreateChannel(EndpointAddress address, Uri via);
        //
        // Summary:
        //     Creates a channel of a specified type that is used to send messages to a
        //     service endpoint at a specified transport address that is configured with
        //     a specified binding.
        //
        // Parameters:
        //   binding:
        //     The System.ServiceModel.Channels.Binding used to configure the endpoint.
        //
        //   endpointAddress:
        //     The System.ServiceModel.EndpointAddress that provides the location of the
        //     service.
        //
        //   via:
        //     The System.Uri that contains the transport address to which the channel sends
        //     messages.
        //
        // Returns:
        //     The TChannel of type System.ServiceModel.Channels.IChannel created by the
        //     factory.
        //
        // Exceptions:
        //   System.InvalidOperationException:
        //     The System.ServiceModel.ChannelFactory has duplex operations it does not
        //     support.
        public static TChannel CreateChannel(Binding binding, EndpointAddress endpointAddress, Uri via);
        //
        // Summary:
        //     Creates a description of the service endpoint.
        //
        // Returns:
        //     The System.ServiceModel.Description.ServiceEndpoint of the service.
        //
        // Exceptions:
        //   System.InvalidOperationException:
        //     The callback contract is null but the service endpoint requires one that
        //     is non-null.
        protected override ServiceEndpoint CreateDescription();
        */

        /// <summary>
        /// Builds the channel factory for the current endpoint of the factory.
        /// </summary>
        protected override IChannelFactory CreateFactory()
        {
            return this;
        }
    }
}

