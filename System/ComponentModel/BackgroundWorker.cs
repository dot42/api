// Copyright (C) 2014 dot42
//
// Original filename: BackgroundWorker.cs
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
using System.Threading;
using Android.OS;

namespace System.ComponentModel
{
    /// <summary>
    /// Executes an action on a background thread.
    /// </summary>
	public class BackgroundWorker : Component
    {
        public event EventHandler<DoWorkEventArgs> DoWork;
        public event EventHandler<ProgressChangedEventArgs> ProgressChanged;
        public event EventHandler<RunWorkerCompletedEventArgs> RunWorkerCompleted;

        private WorkerTask task;

        /// <summary>
        /// Has cancellation been requested?
        /// </summary>
        public bool CancellationPending { get; private set; }

        /// <summary>
        /// Is this worker running a background operation?
        /// </summary>
        public bool IsBusy { get { return (task != null); } }

        /// <summary>
        /// Can this worker report progress updates?
        /// </summary>
        public bool WorkerReportsProgress { get; set; }

        /// <summary>
        /// Does this worker support cancellation?
        /// </summary>
        public bool WorkerSupportsCancellation { get; set; }

        /// <summary>
        /// Request cancellation of the background operation.
        /// </summary>
        /// <exception cref="InvalidOperationException">When <see cref="WorkerSupportsCancellation"/> is false.</exception>
        public void CancelAsync()
        {
            if (!WorkerSupportsCancellation)
                throw new InvalidOperationException();
            CancellationPending = true;
        }

        /// <summary>
        /// Raises the ProgresChanged event.
        /// </summary>
        /// <exception cref="InvalidOperationException">When <see cref="WorkerReportsProgress"/> is false.</exception>
        public void ReportProgress(int percentProgress)
        {
            if (!WorkerReportsProgress)
                throw new InvalidOperationException();
            var theTask = task;
            if (theTask != null)
                theTask.ReportProgress(percentProgress, null);
        }

        /// <summary>
        /// Raises the ProgresChanged event.
        /// </summary>
        /// <exception cref="InvalidOperationException">When <see cref="WorkerReportsProgress"/> is false.</exception>
        public void ReportProgress(int percentProgress, object userState)
        {
            if (!WorkerReportsProgress)
                throw new InvalidOperationException();
            var theTask = task;
            if (theTask != null)
                theTask.ReportProgress(percentProgress, userState);
        }

        /// <summary>
        /// Start the background operation.
        /// </summary>
        /// <exception cref="InvalidOperationException">When <see cref="IsBusy"/> is true.</exception>
        public void RunWorkerAsync()
        {
            if (IsBusy)
                throw new InvalidOperationException();
            task = new WorkerTask(this, null);
        }

        /// <summary>
        /// Start the background operation.
        /// </summary>
        /// <exception cref="InvalidOperationException">When <see cref="IsBusy"/> is true.</exception>
        public void RunWorkerAsync(object argument)
        {
            if (IsBusy)
                throw new InvalidOperationException();
            task = new WorkerTask(this, argument);
        }

        /// <summary>
        /// Raises the DoWork event
        /// </summary>
        protected virtual void OnDoWork(DoWorkEventArgs e)
        {
            if (DoWork != null)
            {
                DoWork(this, e);
            }
        }

        /// <summary>
        /// Raises the ProgressChanged event.
        /// </summary>
        protected virtual void OnProgressChanged(ProgressChangedEventArgs e)
        {
            if (ProgressChanged != null)
            {
                ProgressChanged(this, e);
            }
        }

        /// <summary>
        /// Raises the RunWorkerCompleted event.
        /// </summary>
        protected virtual void OnRunWorkerCompleted(RunWorkerCompletedEventArgs e)
        {
            if (RunWorkerCompleted != null)
            {
                RunWorkerCompleted(this, e);
            }
        }
		
		internal void OnDone() 
		{
			task = null;
		}

        /// <summary>
        /// Background task.
        /// </summary>
        private sealed class WorkerTask 
        {
            private readonly BackgroundWorker worker;
            private readonly object argument;
            private object result;
            private readonly Handler resultHandler;
            private readonly Handler progressHandler;
            private Exception error;

            /// <summary>
            /// Default ctor
            /// </summary>
            public WorkerTask(BackgroundWorker worker, object argument)
            {
                this.worker = worker;
                this.argument = argument;
                resultHandler = new Handler(HandleWorkCompleted);
                progressHandler = new Handler(HandleProgress);

                // Start background thread
                var thread = new Thread(DoWork);
                thread.Start();
            }

            /// <summary>
            /// Report progress back to the initial thread.
            /// </summary>
            internal void ReportProgress(int percentProgress, object userState)
            {
                var m = progressHandler.ObtainMessage(0, percentProgress);
                progressHandler.SendMessage(m);
            }

            /// <summary>
            /// Perform the background work.
            /// </summary>
            private void DoWork()
            {
                // Perform work
                try
                {
                    var args = new DoWorkEventArgs(argument);
                    worker.OnDoWork(args);
                    result = args.Result;
                }
                catch (Exception ex)
                {
                    error = ex;
                }

                // Invoke result handler
                resultHandler.SendEmptyMessage(0);
            }

            /// <summary>
            /// The background work has been completed.
            /// This method is called on the initial thread.
            /// </summary>
            private bool HandleWorkCompleted(Message message)
            {
				try 
				{
					worker.OnRunWorkerCompleted(new RunWorkerCompletedEventArgs(result, error, false));
				}
				finally 
				{
					worker.OnDone();
				}
                return true;
            }

            /// <summary>
            /// The background thread and notified us of some progress.
            /// This method is called on the initial thread.
            /// </summary>
            private bool HandleProgress(Message message)
            {
                worker.OnProgressChanged(new ProgressChangedEventArgs(message.Arg1, null));
                return true;
            }
        }
    }
}

