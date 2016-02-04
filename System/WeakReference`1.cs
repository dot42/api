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
using Java.Lang.Ref;

namespace System
{
    /// <summary>
    /// Represents a weak reference.
    /// </summary>
	public sealed class WeakReference<T> where T : class
	{
	    private Java.Lang.Ref.WeakReference<T> weakReference;
        private readonly bool trackResurrection;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="target">The target object</param>
        public WeakReference(T target)
            :this(target, false)
        {
            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="target">The target object</param>
        /// <param name="trackResurrection">not used by Dot42</param>
        public WeakReference(T target, bool trackResurrection)
        {
            weakReference = new Java.Lang.Ref.WeakReference<T>(target);
            this.trackResurrection = trackResurrection;
        }


        public void SetTarget(T target)
        {
            if (target == null) throw new InvalidOperationException("Target may not be null");
            weakReference = new Java.Lang.Ref.WeakReference<T>(target);
        }

        public bool TryGetTarget(out T target)
        {
            target = weakReference.Get();
            return target != null;
        }
	}
}

