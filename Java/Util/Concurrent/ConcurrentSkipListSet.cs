// Copyright (C) 2014 dot42
//
// Original filename: ConcurrentSkipListSet.cs
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
#if ANDROID_11P
    partial class ConcurrentSkipListSet<E>
	{
        ISortedSet<E> ISortedSet<E>.HeadSet(E p0)
        {
            return null;
        }

        ISortedSet<E> ISortedSet<E>.TailSet(E p0)
        {
            return null;
        }

        ISortedSet<E> ISortedSet<E>.SubSet(E p0, E p1)
        {
            return null;
        }
    }
#endif
}

