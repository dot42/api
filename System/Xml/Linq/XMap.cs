// Copyright (C) 2014 dot42
//
// Original filename: XMap.cs
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
using Java.Util.Concurrent;

namespace System.Xml.Linq
{
	internal class XMap<T>
        where T : class
	{
        private readonly ConcurrentHashMap<string, SoftReference<T>> map = new ConcurrentHashMap<string, SoftReference<T>>();

        /// <summary>
        /// Try to get an entry from the map.
        /// </summary>
        internal T TryGet(string key)
        {
            var entry = map.Get(key);
            if (entry == null)
                return default(T);
            var result = entry.Get();
            if (result == null)
            {
                map.Remove(key, entry);
                return null;
            }
            return result;
        }

	    /// <summary>
	    /// Try to add a value to the map.
	    /// </summary>
	    internal T Add(string key, T value)
	    {
	        while (true)
	        {
	            var newEntry = new SoftReference<T>(value);
	            var entry = map.PutIfAbsent(key, newEntry);
	            if (entry != null)
	            {
                    // There was an entry in the map.
	                var result = entry.Get();
                    if (result != null)
                    {
                        // The entry holds a valid reference, we're done
                        return result;
                    }
                    else
                    {
                        // The entry has been cleared
                        map.Replace(key, newEntry);
                    }
	            }
	        }
	    }
	}
}

