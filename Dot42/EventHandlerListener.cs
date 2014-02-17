// Copyright (C) 2014 dot42
//
// Original filename: EventHandlerListener.cs
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
    /// Helper class for event implementations
    /// </summary>
	internal class EventHandlerListener
	{
	    private ArrayList<EventHandler> list;

        /// <summary>
        /// Add the given handler to this list.
        /// </summary>
        internal void Add(EventHandler handler)
        {
            if (list == null)
                list = new ArrayList<EventHandler>();
            list.Add(handler);
        }

        /// <summary>
        /// Remove the given handler from this list.
        /// </summary>
        internal void Remove(EventHandler handler)
        {
            if (list != null)
                list.Remove(handler);
        }

        /// <summary>
        /// Invoke all handlers on the list.
        /// </summary>
        internal void Invoke(object sender, EventArgs args)
        {
            if (list != null)
            {
                var count = list.Size();
                for (var i = 0; i < count; i++)
                {
                    list.Get(i)(sender, args);
                }
            }
        }
    }

    /// <summary>
    /// Helper class for event implementations
    /// </summary>
    internal class EventHandlerListener<T>
        where T : EventArgs
    {
        private ArrayList<EventHandler<T>> list;

        /// <summary>
        /// Add the given handler to this list.
        /// </summary>
        internal void Add(EventHandler<T> handler)
        {
            if (list == null)
                list = new ArrayList<EventHandler<T>>();
            list.Add(handler);
        }

        /// <summary>
        /// Remove the given handler from this list.
        /// </summary>
        internal void Remove(EventHandler<T> handler)
        {
            if (list != null)
                list.Remove(handler);
        }

        /// <summary>
        /// Invoke all handlers on the list.
        /// </summary>
        internal void Invoke(object sender, T args)
        {
            if (list != null)
            {
                var count = list.Size();
                for (var i = 0; i < count; i++)
                {
                    list.Get(i)(sender, args);
                }
            }
        }
    }
}

