// Copyright (C) 2014 dot42
//
// Original filename: ReadOnlyCollection.cs
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
using System.Collections.Generic;
using Java.Util;
using Dot42.Collections;

namespace System.Collections.ObjectModel
{
	public class ReadOnlyCollection<T> : IEnumerable<T>
	{
	    private readonly Java.Util.ArrayList<T> list;

        public ReadOnlyCollection(Generic.IList<T> source)
        {
            list = new ArrayList<T>(source.Count);
            foreach (var item in source)
            {
                list.Add(item);
            }
        }

	    public int Count
	    {
	        get { return list.Count; }
	    }

	    public T this[int index]
	    {
            get { return list[index]; }
	    }

	    IEnumerator IEnumerable.GetEnumerator()
        {
            return new IterableWrapper<T>(list).GetEnumerator();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new IterableWrapper<T>(list).GetEnumerator();
        }
    }
}

