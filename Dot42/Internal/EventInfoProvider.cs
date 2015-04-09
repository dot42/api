// Copyright (C) 2014 dot42
//
// Original filename: PropertyInfoProvider.cs
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
using System.Reflection;
using System.Security.Principal;
using Dot42.Collections;
using Java.Util;
using Java.Util.Concurrent;

namespace Dot42.Internal
{
    /// <summary>
    /// Helper for obtaining custom attributes.
    /// </summary>
	internal static class EventInfoProvider
	{
        private static readonly ConcurrentHashMap<Type, EventInfo[]> loadedEvents = new ConcurrentHashMap<Type, EventInfo[]>();

        internal static EventInfo[] GetEvents(Type definingType, Type declaringType)
        {
            EventInfo[] result;

            result = loadedEvents.Get(declaringType);
            if (result != null) return result;

            // Not found, build it
            result = BuildEvents(definingType, declaringType);

            // Store in loaded map
            loadedEvents.Put(declaringType, result);

            return result;
        }

        private class Event
        {
            public string Name;
            public MethodInfo Add, Remove;
        }

        /// <summary>
        /// Build all properties for a given definingType.
        /// </summary>
        private static EventInfo[] BuildEvents(Type definingType, Type declaringType)
        {
            Hashtable<string, Event> events = new Hashtable<string, Event>();

            foreach (var method in declaringType.GetMethods())
            {
                var methodName = method.Name;

                bool isAdd = methodName.StartsWith("add_");
                bool isRemove = methodName.StartsWith("remove_");
                if (!isAdd && !isRemove) continue;

                int idxStart = isAdd ? 4 : 7;
                int len = methodName.Length - idxStart;
 
                // cut out an eventual postfix.
                int wannaBeRichIdx = methodName.IndexOf("$");
                if (wannaBeRichIdx != -1)
                    len = wannaBeRichIdx - idxStart;

                string eventName = methodName.Substring(idxStart, len);

                var @event = events.Get(eventName);
                if (@event == null)
                    events.Put(eventName, @event = new Event() { Name=eventName});

                if (isAdd)
                    @event.Add = method;
                else
                    @event.Remove = method;
            }

            List<EventInfo> p = new List<EventInfo>();

            foreach (var @event in new IterableWrapper<Event>(events.Values()))
            {
                if (@event.Add == null || @event.Remove == null)
                    continue;
                EventInfo e = new EventInfo(declaringType, @event.Name, @event.Add, @event.Remove, new IAttribute[0]);
                p.Add(e);
            }

            return p.ToArray();
        }
	}
}

