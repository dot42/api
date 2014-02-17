// Copyright (C) 2014 dot42
//
// Original filename: ICommunicationObject.cs
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
    /// Defines the contract for the basic state machine for all communication-oriented objects
    /// </summary>
    public interface ICommunicationObject
    {
        /// <summary>
        /// Gets the current state of the communication-oriented object.
        /// </summary>
        CommunicationState State { get; }
 
        /// <summary>
        /// Occurs when the communication object completes its transition from the closing state into the closed state.
        /// </summary>
        event EventHandler Closed;
    
        /// <summary>
        /// Occurs when the communication object first enters the closing state.
        /// </summary>
        event EventHandler Closing;
  
        /// <summary>
        /// Occurs when the communication object first enters the faulted state.
        /// </summary>
        event EventHandler Faulted;
   
        /// <summary>
        /// Occurs when the communication object completes its transition from the opening state into the opened state.
        /// </summary>
        event EventHandler Opened;
       
        /// <summary>
        /// Occurs when the communication object first enters the opening state.
        /// </summary>
        event EventHandler Opening;

        /// <summary>
        /// Causes a communication object to transition immediately from its current state into the closed state.
        /// </summary>
        void Abort();
        
        /*
        //
        // Summary:
        //     Begins an asynchronous operation to close a communication object.
        //
        // Parameters:
        //   callback:
        //     The System.AsyncCallback delegate that receives notification of the completion
        //     of the asynchronous close operation.
        //
        //   state:
        //     An object, specified by the application, that contains state information
        //     associated with the asynchronous close operation.
        //
        // Returns:
        //     The System.IAsyncResult that references the asynchronous close operation.
        //
        // Exceptions:
        //   System.ServiceModel.CommunicationObjectFaultedException:
        //     System.ServiceModel.ICommunicationObject.BeginClose() was called on an object
        //     in the System.ServiceModel.CommunicationState.Faulted state.
        //
        //   System.TimeoutException:
        //     The default timeout elapsed before the System.ServiceModel.ICommunicationObject
        //     was able to close gracefully.
        IAsyncResult BeginClose(AsyncCallback callback, object state);
        //
        // Summary:
        //     Begins an asynchronous operation to close a communication object with a specified
        //     timeout.
        //
        // Parameters:
        //   timeout:
        //     The System.Timespan that specifies how long the send operation has to complete
        //     before timing out.
        //
        //   callback:
        //     The System.AsyncCallback delegate that receives notification of the completion
        //     of the asynchronous close operation.
        //
        //   state:
        //     An object, specified by the application, that contains state information
        //     associated with the asynchronous close operation.
        //
        // Returns:
        //     The System.IAsyncResult that references the asynchronous close operation.
        //
        // Exceptions:
        //   System.ServiceModel.CommunicationObjectFaultedException:
        //     System.ServiceModel.ICommunicationObject.BeginClose() was called on an object
        //     in the System.ServiceModel.CommunicationState.Faulted state.
        //
        //   System.TimeoutException:
        //     The specified timeout elapsed before the System.ServiceModel.ICommunicationObject
        //     was able to close gracefully.
        IAsyncResult BeginClose(TimeSpan timeout, AsyncCallback callback, object state);
        //
        // Summary:
        //     Begins an asynchronous operation to open a communication object.
        //
        // Parameters:
        //   callback:
        //     The System.AsyncCallback delegate that receives notification of the completion
        //     of the asynchronous open operation.
        //
        //   state:
        //     An object, specified by the application, that contains state information
        //     associated with the asynchronous open operation.
        //
        // Returns:
        //     The System.IAsyncResult that references the asynchronous open operation.
        //
        // Exceptions:
        //   System.ServiceModel.CommunicationException:
        //     The System.ServiceModel.ICommunicationObject was unable to be opened and
        //     has entered the System.ServiceModel.CommunicationState.Faulted state.
        //
        //   System.TimeoutException:
        //     The default open timeout elapsed before the System.ServiceModel.ICommunicationObject
        //     was able to enter the System.ServiceModel.CommunicationState.Opened state
        //     and has entered the System.ServiceModel.CommunicationState.Faulted state.
        IAsyncResult BeginOpen(AsyncCallback callback, object state);
        //
        // Summary:
        //     Begins an asynchronous operation to open a communication object within a
        //     specified interval of time.
        //
        // Parameters:
        //   timeout:
        //     The System.Timespan that specifies how long the send operation has to complete
        //     before timing out.
        //
        //   callback:
        //     The System.AsyncCallback delegate that receives notification of the completion
        //     of the asynchronous open operation.
        //
        //   state:
        //     An object, specified by the application, that contains state information
        //     associated with the asynchronous open operation.
        //
        // Returns:
        //     The System.IAsyncResult that references the asynchronous open operation.
        //
        // Exceptions:
        //   System.ServiceModel.CommunicationException:
        //     The System.ServiceModel.ICommunicationObject was unable to be opened and
        //     has entered the System.ServiceModel.CommunicationState.Faulted state.
        //
        //   System.TimeoutException:
        //     The specified timeout elapsed before the System.ServiceModel.ICommunicationObject
        //     was able to enter the System.ServiceModel.CommunicationState.Opened state
        //     and has entered the System.ServiceModel.CommunicationState.Faulted state.
        IAsyncResult BeginOpen(TimeSpan timeout, AsyncCallback callback, object state);
        */

        /// <summary>
        /// Causes a communication object to transition from its current state into the closed state.
        /// </summary>
        void Close();
       
        /// <summary>
        /// Causes a communication object to transition from its current state into the closed state.
        /// </summary>
        void Close(TimeSpan timeout);
        /*
        //
        // Summary:
        //     Completes an asynchronous operation to close a communication object.
        //
        // Parameters:
        //   result:
        //     The System.IAsyncResult that is returned by a call to the System.ServiceModel.ICommunicationObject.BeginClose()
        //     method.
        //
        // Exceptions:
        //   System.ServiceModel.CommunicationObjectFaultedException:
        //     System.ServiceModel.ICommunicationObject.BeginClose() was called on an object
        //     in the System.ServiceModel.CommunicationState.Faulted state.
        //
        //   System.TimeoutException:
        //     The timeout elapsed before the System.ServiceModel.ICommunicationObject was
        //     able to close gracefully.
        void EndClose(IAsyncResult result);
        //
        // Summary:
        //     Completes an asynchronous operation to open a communication object.
        //
        // Parameters:
        //   result:
        //     The System.IAsyncResult that is returned by a call to the System.ServiceModel.ICommunicationObject.BeginOpen()
        //     method.
        //
        // Exceptions:
        //   System.ServiceModel.CommunicationException:
        //     The System.ServiceModel.ICommunicationObject was unable to be opened and
        //     has entered the System.ServiceModel.CommunicationState.Faulted state.
        //
        //   System.TimeoutException:
        //     The timeout elapsed before the System.ServiceModel.ICommunicationObject was
        //     able to enter the System.ServiceModel.CommunicationState.Opened state and
        //     has entered the System.ServiceModel.CommunicationState.Faulted state.
        void EndOpen(IAsyncResult result);
        */
       
        /// <summary>
        ///  Causes a communication object to transition from the created state into the opened state.
        /// </summary>
        void Open();
   
        /// <summary>
        /// Causes a communication object to transition from the created state into the opened state within a specified interval of time.
        /// </summary>
        void Open(TimeSpan timeout);
    }
}

