// Copyright (C) 2014 dot42
//
// Original filename: ChannelFactory.cs
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
using System.ServiceModel.Channels;
using System.Text;

namespace System.ServiceModel
{  
    /// <summary>
    /// Creates and manages the channels that are used by clients to send messages to service endpoints.
    /// </summary>
    public abstract class ChannelFactory : CommunicationObject, IChannelFactory, ICommunicationObject, IDisposable
    {
        /// <summary>
        /// Initializes a new instance of the ChannelFactory class.
        /// </summary>
        protected ChannelFactory()
        {
            
        }

        /*
       // Summary:
       //     Gets the credentials used by clients to communicate a service endpoint over
       //     the channels produced by the factory.
       //
       // Returns:
       //     The System.ServiceModel.Description.ClientCredentials used by clients if
       //     they are configured for the factory or if the endpoint is non-null and is
       //     in either the created or opening communication state; otherwise null.
       public ClientCredentials Credentials { get; }
       //
       // Summary:
       //     Gets the default interval of time provided for a close operation to complete.
       //
       // Returns:
       //     The default System.Timespan that specifies how long the close operation has
       //     to complete before timing out.
       protected override TimeSpan DefaultCloseTimeout { get; }
       //
       // Summary:
       //     Gets the default interval of time provided for an open operation to complete.
       //
       // Returns:
       //     The default System.Timespan that specifies how long the open operation has
       //     to complete before timing out.
       protected override TimeSpan DefaultOpenTimeout { get; }
       
        //
        // Summary:
        //     Gets the service endpoint to which the channels produced by the factory connect.
        //
        // Returns:
        //     The System.ServiceModel.Description.ServiceEndpoint to which the channels
        //     produced by the factory connect.
        public ServiceEndpoint Endpoint { get; }

        // Summary:
        //     Initializes the channel factory with the behaviors provided by a specified
        //     configuration file and with those in the service endpoint of the channel
        //     factory.
        //
        // Parameters:
        //   configurationName:
        //     The name of the configuration file.
        //
        // Exceptions:
        //   System.InvalidOperationException:
        //     The service endpoint of the channel factory is null.
        protected virtual void ApplyConfiguration(string configurationName);
        //
        // Summary:
        //     When implemented in a derived class, creates a description of the service
        //     endpoint associated with the channel factory.
        //
        // Returns:
        //     The System.ServiceModel.Description.ServiceEndpoint associated with the channel
        //     factory.
        protected abstract ServiceEndpoint CreateDescription();
        */

        /// <summary>
        /// Builds the channel factory for the current endpoint of the factory.
        /// </summary>
        protected virtual IChannelFactory CreateFactory()
        {
            throw new InvalidOperationException("Create factory should be overridden");
        }

        /*
        //
        // Summary:
        //     Opens the current channel factory if it is not yet opened.
        //
        // Exceptions:
        //   System.ObjectDisposedException:
        //     The current factory is either closing or closed and so cannot be opened.
        protected void EnsureOpened();
        //
        // Summary:
        //     Returns the typed object requested, if present, from the appropriate layer
        //     in the channel stack, or null if not present.
        //
        // Type parameters:
        //   T:
        //     The typed object for which the method is querying.
        //
        // Returns:
        //     The typed object T requested if it is present or null if it is not.
        public T GetProperty<T>() where T : class;
        //
        // Summary:
        //     Initializes the service endpoint of the channel factory with a specified
        //     endpoint.
        //
        // Parameters:
        //   endpoint:
        //     The System.ServiceModel.Description.ServiceEndpoint to initialize the channel
        //     factory with.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     endpoint is null.
        protected void InitializeEndpoint(ServiceEndpoint endpoint);
        //
        // Summary:
        //     Initializes the service endpoint of the channel factory with a specified
        //     binding and address.
        //
        // Parameters:
        //   binding:
        //     The System.ServiceModel.Channels.Binding with which to initialize the channel
        //     factory.
        //
        //   address:
        //     The System.ServiceModel.EndpointAddress with which to initialize the channel
        //     factory.
        protected void InitializeEndpoint(Binding binding, EndpointAddress address);
        //
        // Summary:
        //     Initializes the service endpoint of the channel factory with a specified
        //     address and configuration.
        //
        // Parameters:
        //   configurationName:
        //     The name of the configuration file used to initialize the channel factory.
        //
        //   address:
        //     The System.ServiceModel.EndpointAddress with which to initialize the channel
        //     factory.
        protected void InitializeEndpoint(string configurationName, EndpointAddress address);
        //
        // Summary:
        //     Terminates the inner channel factory of the current channel factory.
        protected override void OnAbort();
        //
        // Summary:
        //     Begins an asynchronous close operation on the inner channel factory of the
        //     current channel factory that has a state object associated with it.
        //
        // Parameters:
        //   timeout:
        //     The System.Timespan that specifies how long the operation has to complete
        //     before timing out.
        //
        //   callback:
        //     The System.AsyncCallback delegate that receives the notification of the asynchronous
        //     operation completion.
        //
        //   state:
        //     An object, specified by the application, that contains state information
        //     associated with the asynchronous operation.
        //
        // Returns:
        //     The System.IAsyncResult that references the asynchronous operation.
        protected override IAsyncResult OnBeginClose(TimeSpan timeout, AsyncCallback callback, object state);
        //
        // Summary:
        //     Begins an asynchronous open operation on the inner channel factory of the
        //     current channel factory that has a state object associated with it.
        //
        // Parameters:
        //   timeout:
        //     The System.Timespan that specifies how long the operation has to complete
        //     before timing out.
        //
        //   callback:
        //     The System.AsyncCallback delegate that receives the notification of the asynchronous
        //     operation completion.
        //
        //   state:
        //     An object, specified by the application, that contains state information
        //     associated with the asynchronous operation.
        //
        // Returns:
        //     The System.IAsyncResult that references the asynchronous operation.
        protected override IAsyncResult OnBeginOpen(TimeSpan timeout, AsyncCallback callback, object state);
        //
        // Summary:
        //     Calls close on the inner channel factory with a specified time-out for the
        //     completion of the operation.
        //
        // Parameters:
        //   timeout:
        //     The System.Timespan that specifies how long the operation has to complete
        //     before timing out.
        protected override void OnClose(TimeSpan timeout);
        //
        // Summary:
        //     Completes an asynchronous close operation on the inner channel factory of
        //     the current channel factory.
        //
        // Parameters:
        //   result:
        //     The System.IAsyncResult returned by a call to the System.ServiceModel.ChannelFactory.OnBeginClose(System.TimeSpan,System.AsyncCallback,System.Object)
        //     method.
        protected override void OnEndClose(IAsyncResult result);
        //
        // Summary:
        //     Completes an asynchronous open operation on the inner channel factory of
        //     the current channel factory.
        //
        // Parameters:
        //   result:
        //     The System.IAsyncResult returned by a call to the System.ServiceModel.ChannelFactory.OnBeginOpen(System.TimeSpan,System.AsyncCallback,System.Object)
        //     method.
        protected override void OnEndOpen(IAsyncResult result);
        //
        // Summary:
        //     Calls open on the inner channel factory of the current channel factory with
        //     a specified time-out for the completion of the operation.
        //
        // Parameters:
        //   timeout:
        //     The System.Timespan that specifies how long the open operation has to complete
        //     before timing out.
        //
        // Exceptions:
        //   System.InvalidOperationException:
        //     The inner channel of the current channel is null.
        protected override void OnOpen(TimeSpan timeout);
        //
        // Summary:
        //     Initializes a read-only copy of the System.ServiceModel.Description.ClientCredentials
        //     object for the channel factory.
        protected override void OnOpened();
        //
        // Summary:
        //     Builds the inner channel factory for the current channel.
        //
        // Exceptions:
        //   System.InvalidOperationException:
        //     The inner channel factory for the channel factory is null.
        protected override void OnOpening();
        */

        public virtual void Dispose()
        {
            Close();
        }
    }
}

