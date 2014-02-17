// Copyright (C) 2014 dot42
//
// Original filename: ConcurrentSkipListMap.cs
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
namespace Java.Util.Concurrent
{
    partial class ConcurrentSkipListMap<K, V>
	{
#if ANDROID_11P
        ISortedMap<K, V> ISortedMap<K, V>.HeadMap(K p0)
        {
            return null;
        }

        ISortedMap<K, V> ISortedMap<K, V>.TailMap(K p0)
        {
            return null;
        }

        ISortedMap<K, V> ISortedMap<K, V>.SubMap(K p0, K p1)
        {
            return null;
        }
#endif

#if ANDROID_10P
        Java.Util.INavigableSet<K> IConcurrentNavigableMap<K, V>.KeySet()
        {
            return null;
        }
#endif
    }
}

