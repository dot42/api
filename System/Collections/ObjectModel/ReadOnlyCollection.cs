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

namespace System.Collections.ObjectModel
{
	public class ReadOnlyCollection<T> : IList<T>, IList
	{
        private readonly IList<T> source;

        public ReadOnlyCollection(IList<T> source)
        {
            this.source = source;
        }

	    public int Count
	    {
	        get { return source.Count; }
	    }

        bool ICollection.IsSynchronized { get { return ((IList)source).IsSynchronized; } }
        object ICollection.SyncRoot { get { return ((IList)source).SyncRoot; } }

	    public void CopyTo(Array array, int index)
	    {
	        ((IList)source).CopyTo(array, index);
	    }

        public bool IsReadOnly { get { return true; } }

        bool IList.IsFixedSize { get { return ((IList)source).IsFixedSize; } }

	    object IList.this[int index]
	    {
	        get { return this[index]; } 
            set { throw new NotImplementedException(); }
	    }

	    public void Add(T item)
	    {
	        throw new NotImplementedException();
	    }

	    int IList.Add(object element)
	    {
	        throw new NotImplementedException();
	    }

	    public void Clear()
	    {
	        throw new NotImplementedException();
	    }

	    bool IList.Contains(object element)
	    {
	        return Contains((T)element);
	    }

	    int IList.IndexOf(object element)
	    {
	        return IndexOf((T)element);
	    }

	    void IList.Insert(int index, object element)
	    {
	        throw new NotImplementedException();
	    }

	    void IList.Remove(object element)
	    {
	        throw new NotImplementedException();
	    }

	    public bool Contains(T item)
	    {
	        return source.Contains(item);
	    }

	    public bool Remove(T item)
	    {
	        throw new NotImplementedException();
	    }

	    public void CopyTo(T[] array, int index)
	    {
	        source.CopyTo(array, index);
	    }

	    public T this[int index]
	    {
            get { return source[index]; }
            set { throw new NotImplementedException(); }
	    }

	    public int IndexOf(T element)
	    {
	        return source.IndexOf(element);
	    }

	    public void Insert(int index, T element)
	    {
	        throw new NotImplementedException();
	    }

	    public void RemoveAt(int index)
	    {
	        throw new NotImplementedException();
	    }

	    IEnumerator IEnumerable.GetEnumerator()
        {
            return source.GetEnumerator();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return source.GetEnumerator();
        }

	    
	}
}

