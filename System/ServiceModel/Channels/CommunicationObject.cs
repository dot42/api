// Copyright (C) 2014 dot42
//
// Original filename: CommunicationObject.cs
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
namespace System.ServiceModel.Channels
{
	 // Summary:
    //     Provides a common base implementation for the basic state machine common
    //     to all communication-oriented objects in the system, including channels,
    //     listeners, and the channel and listener factories.
    public abstract class CommunicationObject : ICommunicationObject
    {
        private object mutex;
        private CommunicationState state = CommunicationState.Created;
   
        /// <summary>
        /// Occurs when a communication object transitions into the closed state.
        /// </summary>
        public event EventHandler Closed;
   
        /// <summary>
        /// Occurs when a communication object transitions into the closing state.
        /// </summary>
        public event EventHandler Closing;
           
        /// <summary>
        /// Occurs when a communication object transitions into the faulted state.
        /// </summary>
        public event EventHandler Faulted;
   
        /// <summary>
        /// Occurs when a communication object transitions into the opened state.
        /// </summary>
        public event EventHandler Opened;
  
        /// <summary>
        /// Occurs when a communication object transitions into the opening state.
        /// </summary>
        public event EventHandler Opening;

        /// <summary>
        /// Initializes a new instance of the System.ServiceModel.Channels.CommunicationObject class.
        /// </summary>
        protected CommunicationObject()
        {
            mutex = new object();
        }
        /// <summary>
        /// Initializes a new instance of the System.ServiceModel.Channels.CommunicationObject
        /// class with the mutually exclusive lock to protect the state transitions specified.
        /// </summary>
        protected CommunicationObject(object mutex)
        {
            this.mutex = mutex;
        }

        /*
        // Summary:
        //     When overridden in a derived class, gets the default interval of time provided
        //     for a close operation to complete.
        //
        // Returns:
        //     The default System.Timespan that specifies how long the close operation has
        //     to complete before timing out.
        protected abstract TimeSpan DefaultCloseTimeout { get; }
        //
        // Summary:
        //     When overridden in a derived class, gets the default interval of time provided
        //     for an open operation to complete.
        //
        // Returns:
        //     The default System.Timespan that specifies how long the open operation has
        //     to complete before timing out.
        protected abstract TimeSpan DefaultOpenTimeout { get; }
        */
        
        //
        // Summary:
        //     Gets a value that indicates whether the communication object has been disposed.
        //
        // Returns:
        //     true if the communication object is in a closed state; otherwise, false.
        protected bool IsDisposed
        {
            get { return state == CommunicationState.Closed; }
        }

        /// <summary>
        ///  Gets a value that indicates the current state of the communication object.
        /// </summary>
        public CommunicationState State
        {
            get { return state; }
        }

        /// <summary>
        ///  Gets the mutually exclusive lock that protects the class instance during a state transition.
        /// </summary>
        protected object ThisLock
        {
            get { return mutex; }
        }
 
        /// <summary>
        /// Causes a communication object to transition immediately from its current state into the closing state.
        /// </summary>
        public void Abort()
        {
            SetState(CommunicationState.Closing);
        }

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
        //   System.InvalidOperationException:
        //     The communication object is not in a System.ServiceModel.CommunicationState.Opened
        //     or System.ServiceModel.CommunicationState.Opening state and cannot be modified.
        //
        //   System.ObjectDisposedException:
        //     The communication object is in a System.ServiceModel.CommunicationState.Closing
        //     or System.ServiceModel.CommunicationState.Closed state and cannot be modified.
        //
        //   System.ServiceModel.CommunicationObjectFaultedException:
        //     The communication object is in a System.ServiceModel.CommunicationState.Faulted
        //     state and cannot be modified.
        //
        //   System.TimeoutException:
        //     The default interval of time that was allotted for the operation was exceeded
        //     before the operation was completed.
        public IAsyncResult BeginClose(AsyncCallback callback, object state);
        //
        // Summary:
        //     Begins an asynchronous operation to close a communication object with a specified
        //     timeout.
        //
        // Parameters:
        //   timeout:
        //     The System.Timespan that specifies how long the close operation has to complete
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
        //   System.InvalidOperationException:
        //     The communication object is not in a System.ServiceModel.CommunicationState.Opened
        //     or System.ServiceModel.CommunicationState.Opening state and cannot be modified.
        //
        //   System.ObjectDisposedException:
        //     The communication object is in a System.ServiceModel.CommunicationState.Closing
        //     or System.ServiceModel.CommunicationState.Closed state and cannot be modified.
        //
        //   System.ServiceModel.CommunicationObjectFaultedException:
        //     The communication object is in a System.ServiceModel.CommunicationState.Faulted
        //     state and cannot be modified.
        //
        //   System.TimeoutException:
        //     The default interval of time that was allotted for the operation was exceeded
        //     before the operation was completed.
        public IAsyncResult BeginClose(TimeSpan timeout, AsyncCallback callback, object state);
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
        //   System.InvalidOperationException:
        //     The communication object is not in a System.ServiceModel.CommunicationState.Opened
        //     or System.ServiceModel.CommunicationState.Opening state and cannot be modified.
        //
        //   System.ObjectDisposedException:
        //     The communication object is in a System.ServiceModel.CommunicationState.Closing
        //     or System.ServiceModel.CommunicationState.Closed state and cannot be modified.
        //
        //   System.ServiceModel.CommunicationObjectFaultedException:
        //     The communication object is in a System.ServiceModel.CommunicationState.Faulted
        //     state and cannot be modified.
        //
        //   System.TimeoutException:
        //     The default interval of time that was allotted for the operation was exceeded
        //     before the operation was completed.
        public IAsyncResult BeginOpen(AsyncCallback callback, object state);
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
        //   System.InvalidOperationException:
        //     The communication object is not in a System.ServiceModel.CommunicationState.Opened
        //     or System.ServiceModel.CommunicationState.Opening state and cannot be modified.
        //
        //   System.ObjectDisposedException:
        //     The communication object is in a System.ServiceModel.CommunicationState.Closing
        //     or System.ServiceModel.CommunicationState.Closed state and cannot be modified.
        //
        //   System.ServiceModel.CommunicationObjectFaultedException:
        //     The communication object is in a System.ServiceModel.CommunicationState.Faulted
        //     state and cannot be modified.
        //
        //   System.TimeoutException:
        //     The default interval of time that was allotted for the operation was exceeded
        //     before the operation was completed.
        public IAsyncResult BeginOpen(TimeSpan timeout, AsyncCallback callback, object state);
        */

        //
        // Summary:
        //     Causes a communication object to transition from its current state into the
        //     closed state.
        //
       
        /// <summary>
        /// Causes a communication object to transition from its current state into the closed state.
        /// </summary>
        public void Close()
        {
            SetState(CommunicationState.Closed);
        }

        /// <summary>
        /// Causes a communication object to transition from its current state into the closed state.
        /// </summary>
        public void Close(TimeSpan timeout)
        {
            SetState(CommunicationState.Closed);
        }

        /*
        //
        // Summary:
        //     Completes an asynchronous operation to close a communication object.
        //
        // Parameters:
        //   result:
        //     The System.IAsyncResult that is returned by a call to the Overload:System.ServiceModel.Channels.CommunicationObject.BeginClose
        //     method.
        //
        // Exceptions:
        //   System.InvalidOperationException:
        //     The communication object is not in a System.ServiceModel.CommunicationState.Opened
        //     or System.ServiceModel.CommunicationState.Opening state and cannot be modified.
        //
        //   System.ObjectDisposedException:
        //     The communication object is in a System.ServiceModel.CommunicationState.Closing
        //     or System.ServiceModel.CommunicationState.Closed state and cannot be modified.
        //
        //   System.ServiceModel.CommunicationObjectFaultedException:
        //     The communication object is in a System.ServiceModel.CommunicationState.Faulted
        //     state and cannot be modified.
        //
        //   System.TimeoutException:
        //     The default interval of time that was allotted for the operation was exceeded
        //     before the operation was completed.
        public void EndClose(IAsyncResult result);
        //
        // Summary:
        //     Completes an asynchronous operation to open a communication object.
        //
        // Parameters:
        //   result:
        //     The System.IAsyncResult that is returned by a call to the Overload:System.ServiceModel.Channels.CommunicationObject.BeginClose
        //     method.
        //
        // Exceptions:
        //   System.InvalidOperationException:
        //     The communication object is not in a System.ServiceModel.CommunicationState.Opened
        //     or System.ServiceModel.CommunicationState.Opening state and cannot be modified.
        //
        //   System.ObjectDisposedException:
        //     The communication object is in a System.ServiceModel.CommunicationState.Closing
        //     or System.ServiceModel.CommunicationState.Closed state and cannot be modified.
        //
        //   System.ServiceModel.CommunicationObjectFaultedException:
        //     The communication object is in a System.ServiceModel.CommunicationState.Faulted
        //     state and cannot be modified.
        //
        //   System.TimeoutException:
        //     The default interval of time that was allotted for the operation was exceeded
        //     before the operation was completed.
        public void EndOpen(IAsyncResult result);
        */
        //
        // Summary:
        //     Causes a communication object to transition from its current state into the
        //     faulted state.
        protected void Fault()
        {
            SetState(CommunicationState.Faulted);
        }
        /*
        //
        // Summary:
        //     Gets the type of communication object.
        //
        // Returns:
        //     The type of communication object.
        protected virtual Type GetCommunicationObjectType();
     
        //
        // Summary:
        //     Inserts processing on a communication object after it transitions to the
        //     closing state due to the invocation of a synchronous abort operation.
        protected abstract void OnAbort();
        //
        // Summary:
        //     Inserts processing after a communication object transitions to the closing
        //     state due to the invocation of an asynchronous close operation.
        //
        // Parameters:
        //   timeout:
        //     The System.Timespan that specifies how long the on close operation has to
        //     complete before timing out.
        //
        //   callback:
        //     The System.AsyncCallback delegate that receives notification of the completion
        //     of the asynchronous on close operation.
        //
        //   state:
        //     An object, specified by the application, that contains state information
        //     associated with the asynchronous on close operation.
        //
        // Returns:
        //     The System.IAsyncResult that references the asynchronous on close operation.
        //
        // Exceptions:
        //   System.InvalidOperationException:
        //     The communication object is not in a System.ServiceModel.CommunicationState.Opened
        //     or System.ServiceModel.CommunicationState.Opening state and cannot be modified.
        //
        //   System.ObjectDisposedException:
        //     The communication object is in a System.ServiceModel.CommunicationState.Closing
        //     or System.ServiceModel.CommunicationState.Closed state and cannot be modified.
        //
        //   System.ServiceModel.CommunicationObjectFaultedException:
        //     The communication object is in a System.ServiceModel.CommunicationState.Faulted
        //     state and cannot be modified.
        //
        //   System.TimeoutException:
        //     The default interval of time that was allotted for the operation was exceeded
        //     before the operation was completed.
        protected abstract IAsyncResult OnBeginClose(TimeSpan timeout, AsyncCallback callback, object state);
        //
        // Summary:
        //     Inserts processing on a communication object after it transitions to the
        //     opening state due to the invocation of an asynchronous open operation.
        //
        // Parameters:
        //   timeout:
        //     The System.Timespan that specifies how long the on open operation has to
        //     complete before timing out.
        //
        //   callback:
        //     The System.AsyncCallback delegate that receives notification of the completion
        //     of the asynchronous on open operation.
        //
        //   state:
        //     An object, specified by the application, that contains state information
        //     associated with the asynchronous on open operation.
        //
        // Returns:
        //     The System.IAsyncResult that references the asynchronous on open operation.
        //
        // Exceptions:
        //   System.InvalidOperationException:
        //     The communication object is not in a System.ServiceModel.CommunicationState.Opened
        //     or System.ServiceModel.CommunicationState.Opening state and cannot be modified.
        //
        //   System.ObjectDisposedException:
        //     The communication object is in a System.ServiceModel.CommunicationState.Closing
        //     or System.ServiceModel.CommunicationState.Closed state and cannot be modified.
        //
        //   System.ServiceModel.CommunicationObjectFaultedException:
        //     The communication object is in a System.ServiceModel.CommunicationState.Faulted
        //     state and cannot be modified.
        //
        //   System.TimeoutException:
        //     The default interval of time that was allotted for the operation was exceeded
        //     before the operation was completed.
        protected abstract IAsyncResult OnBeginOpen(TimeSpan timeout, AsyncCallback callback, object state);
        //
        // Summary:
        //     Inserts processing on a communication object after it transitions to the
        //     closing state due to the invocation of a synchronous close operation.
        //
        // Parameters:
        //   timeout:
        //     The System.Timespan that specifies how long the on close operation has to
        //     complete before timing out.
        //
        // Exceptions:
        //   System.ServiceModel.CommunicationObjectFaultedException:
        //     Overload:System.ServiceModel.Channels.CommunicationObject.Close was called
        //     on an object in the System.ServiceModel.CommunicationState.Faulted state.
        //
        //   System.TimeoutException:
        //     The default interval of time that was allotted for the operation was exceeded
        //     before the operation was completed.
        //
        //   System.ServiceModel.CommunicationException:
        //     A communication error occurred while closing the object.
        protected abstract void OnClose(TimeSpan timeout);
        //
        // Summary:
        //     Invoked during the transition of a communication object into the closing
        //     state.
        protected virtual void OnClosed()
        //
        // Summary:
        //     Invoked during the transition of a communication object into the closing
        //     state.
        protected virtual void OnClosing();
        //
        // Summary:
        //     Completes an asynchronous operation on the close of a communication object.
        //
        // Parameters:
        //   result:
        //     The System.IAsyncResult that is returned by a call to the System.ServiceModel.Channels.CommunicationObject.OnEndClose(System.IAsyncResult)
        //     method.
        //
        // Exceptions:
        //   System.InvalidOperationException:
        //     The communication object is not in a System.ServiceModel.CommunicationState.Opened
        //     or System.ServiceModel.CommunicationState.Opening state and cannot be modified.
        //
        //   System.ObjectDisposedException:
        //     The communication object is in a System.ServiceModel.CommunicationState.Closing
        //     or System.ServiceModel.CommunicationState.Closed state and cannot be modified.
        //
        //   System.ServiceModel.CommunicationObjectFaultedException:
        //     The communication object is in a System.ServiceModel.CommunicationState.Faulted
        //     state and cannot be modified.
        //
        //   System.TimeoutException:
        //     The default interval of time that was allotted for the operation was exceeded
        //     before the operation was completed.
        protected abstract void OnEndClose(IAsyncResult result);
        //
        // Summary:
        //     Completes an asynchronous operation on the open of a communication object.
        //
        // Parameters:
        //   result:
        //     The System.IAsyncResult that is returned by a call to the System.ServiceModel.Channels.CommunicationObject.OnEndOpen(System.IAsyncResult)
        //     method.
        //
        // Exceptions:
        //   System.InvalidOperationException:
        //     The communication object is not in a System.ServiceModel.CommunicationState.Opened
        //     or System.ServiceModel.CommunicationState.Opening state and cannot be modified.
        //
        //   System.ObjectDisposedException:
        //     The communication object is in a System.ServiceModel.CommunicationState.Closing
        //     or System.ServiceModel.CommunicationState.Closed state and cannot be modified.
        //
        //   System.ServiceModel.CommunicationObjectFaultedException:
        //     The communication object is in a System.ServiceModel.CommunicationState.Faulted
        //     state and cannot be modified.
        //
        //   System.TimeoutException:
        //     The default interval of time that was allotted for the operation was exceeded
        //     before the operation was completed.
        protected abstract void OnEndOpen(IAsyncResult result);
        //
        // Summary:
        //     Inserts processing on a communication object after it transitions to the
        //     faulted state due to the invocation of a synchronous fault operation.
        protected virtual void OnFaulted();
        //
        // Summary:
        //     Inserts processing on a communication object after it transitions into the
        //     opening state which must complete within a specified interval of time.
        //
        // Parameters:
        //   timeout:
        //     The System.Timespan that specifies how long the on open operation has to
        //     complete before timing out.
        //
        // Exceptions:
        //   System.InvalidOperationException:
        //     The communication object is not in a System.ServiceModel.CommunicationState.Opened
        //     or System.ServiceModel.CommunicationState.Opening state and cannot be modified.
        //
        //   System.ObjectDisposedException:
        //     The communication object is in a System.ServiceModel.CommunicationState.Closing
        //     or System.ServiceModel.CommunicationState.Closed state and cannot be modified.
        //
        //   System.ServiceModel.CommunicationObjectFaultedException:
        //     The communication object is in a System.ServiceModel.CommunicationState.Faulted
        //     state and cannot be modified.
        //
        //   System.TimeoutException:
        //     The default interval of time that was allotted for the operation was exceeded
        //     before the operation was completed.
        protected abstract void OnOpen(TimeSpan timeout);
        //
        // Summary:
        //     Invoked during the transition of a communication object into the opened state.
        protected virtual void OnOpened();
        //
        // Summary:
        //     Invoked during the transition of a communication object into the opening
        //     state.
        protected virtual void OnOpening();
        */
        
        /// <summary>
        /// Causes a communication object to transition from the created state into the opened state.
        /// </summary>
        public void Open()
        {
            SetState(CommunicationState.Opened);
        }
        /// <summary>
        /// Causes a communication object to transition from the created state into the opened state.
        /// </summary>
        public void Open(TimeSpan timeout)
        {
            SetState(CommunicationState.Opened);
        }

        /*
        //
        // Summary:
        //     Throws an exception if the communication object is disposed.
        //
        // Exceptions:
        //   System.ObjectDisposedException:
        //     The communication object is in a System.ServiceModel.CommunicationState.Closing
        //     or System.ServiceModel.CommunicationState.Closed state.
        //
        //   System.ServiceModel.CommunicationObjectFaultedException:
        //     The communication object is in a System.ServiceModel.CommunicationState.Faulted
        //     state.
        protected internal void ThrowIfDisposed();
        //
        // Summary:
        //     Throws an exception if the communication object the System.ServiceModel.Channels.CommunicationObject.State
        //     property is not set to the System.ServiceModel.CommunicationState.Created
        //     state.
        //
        // Exceptions:
        //   System.InvalidOperationException:
        //     The communication object is in a System.ServiceModel.CommunicationState.Opening
        //     or System.ServiceModel.CommunicationState.Opened state.
        //
        //   System.ObjectDisposedException:
        //     The communication object is in a System.ServiceModel.CommunicationState.Closing
        //     or System.ServiceModel.CommunicationState.Closed state.
        //
        //   System.ServiceModel.CommunicationObjectFaultedException:
        //     The communication object is in a System.ServiceModel.CommunicationState.Faulted
        //     state.
        protected internal void ThrowIfDisposedOrImmutable();
        //
        // Summary:
        //     Throws an exception if the communication object is not in the System.ServiceModel.CommunicationState.Opened
        //     state.
        //
        // Exceptions:
        //   System.InvalidOperationException:
        //     The communication object is not in a System.ServiceModel.CommunicationState.Created
        //     or System.ServiceModel.CommunicationState.Opening state and cannot be used.
        //
        //   System.ObjectDisposedException:
        //     The communication object is in a System.ServiceModel.CommunicationState.Closing
        //     or System.ServiceModel.CommunicationState.Closed state and cannot be modified.
        //
        //   System.ServiceModel.CommunicationObjectFaultedException:
        //     The communication object is in a System.ServiceModel.CommunicationState.Faulted
        //     state and cannot be modified.
        protected internal void ThrowIfDisposedOrNotOpen();
        */

        private void SetState(CommunicationState newState)
        {
            // TODO: Exceptions:
            //   System.InvalidOperationException:
            //     The communication object is not in a System.ServiceModel.CommunicationState.Opened
            //     or System.ServiceModel.CommunicationState.Opening state and cannot be modified.
            //
            //   System.ObjectDisposedException:
            //     The communication object is in a System.ServiceModel.CommunicationState.Closing
            //     or System.ServiceModel.CommunicationState.Closed state and cannot be modified.
            //
            //   System.ServiceModel.CommunicationObjectFaultedException:
            //     The communication object is in a System.ServiceModel.CommunicationState.Faulted
            //     state and cannot be modified.
            //
            //   System.TimeoutException:
            //     The default interval of time that was allotted for the operation was exceeded
            //     before the operation was completed.

            //TODO: call events
            switch (state)
            {
                case CommunicationState.Created:
                    
                    switch (newState)
                    {
                       case CommunicationState.Opened:
                            if (Opening != null) Opening(this, new EventArgs());
                            state = newState;
                            if (Opened != null) Opened(this, new EventArgs());
                            break;

                        case CommunicationState.Closed:
                             if (Closing != null) Closing(this, new EventArgs());
                            state = newState;
                            if (Closed != null) Closed(this, new EventArgs());
                            break;

                        case CommunicationState.Faulted:
                            if (Faulted != null) Faulted(this, new EventArgs());
                            state = newState;
                            break;

                        default:
                            throw new CommunicationException(string.Format("Invalid state transition {0}->{1}", state, newState));
                    }
                    break;

                case CommunicationState.Opened:
                    switch (newState)
                    {
                       case CommunicationState.Opened:
                            //nothing to do.
                            break;

                        case CommunicationState.Closed:
                             if (Closing != null) Closing(this, new EventArgs());
                            state = newState;
                            if (Closed != null) Closed(this, new EventArgs());
                            break;

                        case CommunicationState.Faulted:
                            if (Faulted != null) Faulted(this, new EventArgs());
                            state = newState;
                            break;

                        default:
                            throw new CommunicationException(string.Format("Invalid state transition {0}->{1}", state, newState));
                    }
                    break;

                case CommunicationState.Closed:
                    switch (newState)
                    {
                        case CommunicationState.Closed:
                            //nothing to do.
                            break;

                        case CommunicationState.Faulted:
                            if (Faulted != null) Faulted(this, new EventArgs());
                            state = newState;
                            break;

                        default:
                            throw new CommunicationException("Cannot (re)use closed object");
                    }
                    break;

                case CommunicationState.Faulted:
                    throw new CommunicationObjectFaultedException("Cannot (re)use faulted object");

                default:
                    throw new CommunicationException(string.Format("Invalid state transition {0}->{1}", state, newState));

            }

            state = newState;

        }
    }
}

