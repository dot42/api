// Copyright (C) 2014 dot42
//
// Original filename: WaitHandle.cs
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
namespace System.Threading
{
    public abstract class WaitHandle : MarshalByRefObject, IDisposable
    {
        private bool isDisposed = false;
        
        /// <summary>
        /// Blocks the current thread until the current WaitHandle receives a signal.
        /// </summary>
	    public virtual bool WaitOne()
	    {
	        return true;
	    }

        public virtual void Close ()
		{
			Dispose(true);
		}

        public void Dispose()
        {
            Close ();
        }

        protected virtual void Dispose (bool explicitDisposing)
		{
			if (!isDisposed){
				lock (this){
					if (isDisposed)
						return;

					isDisposed = true;
					//cleanup real stuff...
				}
			}
		}

        internal void CheckDisposed()
        {
            if (isDisposed)
                throw new ObjectDisposedException(GetType().FullName);
        }
    }
}

