// Copyright (C) 2014 dot42
//
// Original filename: WeakReference.cs
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

namespace System
{
    /// <summary>
    /// Represents a weak reference.
    /// </summary>
	public class WeakReference
	{
	    private Java.Lang.Ref.WeakReference<object> weakReference;
        private bool trackResurrection;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="target">The target object</param>
        public WeakReference(object target)
            :this(target, false)
        {
            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="target">The target object</param>
        /// <param name="trackResurrection">not used by Dot42</param>
        public WeakReference(object target, bool trackResurrection)
        {
            weakReference = new Java.Lang.Ref.WeakReference<object>(target);
            this.trackResurrection = trackResurrection;
        }

        /// <summary>
        /// Gets an indication whether the object referenced by the current WeakReference object 
        /// has been garbage collected.
        /// </summary>
        public virtual bool IsAlive
        {
            get { return weakReference.Get() != null; }
        }

        /// <summary>
        /// Gets an indication whether the object referenced by the current WeakReference object 
        /// is tracked after it is finalized.
        /// </summary>
        public virtual bool TrackResurrection
        {
            get { return trackResurrection; }
        }

        public virtual object Target
        {
            get { return weakReference.Get(); }
            set
            {
                if (value == null) throw new InvalidOperationException("Target may not be null");
                weakReference = new Java.Lang.Ref.WeakReference<object>(value);
            }
        }
	}
}

