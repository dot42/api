// Copyright (C) 2014 dot42
//
// Original filename: EventHandlers.cs
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
using Java.Util;

namespace Dot42
{
    /// <summary>
    /// Container for event handler listeners used by classes that have no way to store the listener in the class itself.
    /// </summary>
	internal sealed class EventHandlers
	{
        // Map: resourceId -> (object -> listener)
        private static readonly HashMap<int, WeakHashMap<object, object>> listeners = new HashMap<int, WeakHashMap<object, object>>();

        /// <summary>
        /// Gets the listener recorded for the given owner with the given (unique) resource id.
        /// A listener is created if not found and create it set to true.
        /// </summary>
        /// <remarks>This method is not thread safe.</remarks>
        internal static T GetOrCreate<T>(object owner, int resourceId, bool create, Action<T> initialize)
            where T : class, new()
        {
            var weakMap = listeners.Get(resourceId);
            if (weakMap == null)
            {
                if (!create) return default(T);
                weakMap = new WeakHashMap<object, object>();
                listeners.Put(resourceId, weakMap);
            }
            var listener = (T)weakMap.Get(owner);
            if (listener == null)
            {
                if (!create) return null;
                listener = new T();
                weakMap.Put(owner, listener);
                if (initialize != null)
                {
                    initialize(listener);
                }
            }
            return listener;
        }
	}
}

