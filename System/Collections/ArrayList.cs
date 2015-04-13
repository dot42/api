// Copyright (C) 2014 dot42
//
// Original filename: ArrayList.cs
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
using Dot42;
using Dot42.Collections;
using Java.Util;

namespace System.Collections
{
    public class ArrayList : IList
    {
        private readonly IList<object> list;
        private readonly bool isFixedSize;
        private readonly bool isReadOnly;
        private readonly bool isSynchronized;

        /// <summary>
        /// Default ctor
        /// </summary>
        public ArrayList() :
            this(new ArrayList<object>(), false, false, false)
        {
        }

        /// <summary>
        /// Clone ctor
        /// </summary>
        public ArrayList(ICollection source)
            : this(new ArrayList<object>((source != null) ? source.Count : 0), false, false, false)
        {
            if (source == null)
                throw new ArgumentNullException();
            foreach (var item in source)
            {
                list.Add(item);
            }
        }

        /// <summary>
        /// Default ctor with specified initial capacity.
        /// </summary>
        public ArrayList(int capacity) :
            this(new ArrayList<object>(capacity), false, false, false)
        {            
        }

        /// <summary>
        /// Private ctor
        /// </summary>
        private ArrayList(IList<object> list, bool isFixedSize, bool isReadOnly, bool isSynchronized)
        {
            this.list = list;
            this.isFixedSize = isFixedSize;
            this.isReadOnly = isReadOnly;
            this.isSynchronized = isSynchronized;
        }

        /// <summary>
        /// Gets/sets the capacity of this list.
        /// </summary>
        public virtual int Capacity
        {
            get { return list.Size(); }
            set
            {
                /* ignore */
            }
        }

        /// <summary>
        /// Gets the number of items in this list.
        /// </summary>
        public int Count
        {
            get { return list.Size(); }
        }

        /// <summary>
        /// Does this list have a fixed size?
        /// </summary>
        public virtual bool IsFixedSize
        {
            get { return isFixedSize; }
        }

        /// <summary>
        /// Is this list readonly?
        /// </summary>
        public virtual bool IsReadOnly
        {
            get { return isReadOnly; }
        }

        /// <summary>
        /// Is this list synchronized?
        /// </summary>
        public virtual bool IsSynchronized
        {
            get { return isSynchronized; }
        }

        /// <summary>
        /// Is this list readonly?
        /// </summary>
        public virtual object this[int index]
        {
            get
            {
                if ((index < 0) || (index >= list.Size()))
                    throw new ArgumentOutOfRangeException();
                return list[index];
            }
            set
            {
                if (isReadOnly)
                    throw new NotSupportedException();
                if ((index < 0) || (index >= list.Size()))
                    throw new ArgumentOutOfRangeException();
                list[index] = value;
            }
        }

        /// <summary>
        /// Gets an object that can be used to synchronized access to this list.
        /// </summary>
        public virtual object SyncRoot
        {
            get { return this; }
        }

        /// <summary>
        /// Copy all elements into the given array starting at the given index (into the array).
        /// </summary>
        public virtual void CopyTo(Array array)
        {
            CopyTo(0, array, 0, list.Size());
        }

        /// <summary>
        /// Copy all elements into the given array starting at the given index (into the array).
        /// </summary>
        public virtual void CopyTo(Array array, int index)
        {
            CopyTo(0, array, index, list.Size());
        }

        /// <summary>
        /// Copy all elements into the given array starting at the given index (into the array).
        /// </summary>
        public virtual void CopyTo(int index, Array array, int arrayIndex, int count)
        {
            if (array == null)
                throw new ArgumentNullException();
            if ((index < 0) || (arrayIndex < 0) || (count < 0))
                throw new ArgumentOutOfRangeException();
            var size = list.Size();
            var available = array.Length- arrayIndex;
            if ((index > size) || (count > size) || (index + count > size) || (count > available))
                throw new ArgumentException();
            while (count > 0)
            {
                array.SetValue(list[index++], arrayIndex++);
                count--;
            }
        }

        /// <summary>
        /// Add an object to the end of this list
        /// </summary>
        /// <param name="value"></param>
        public virtual int Add(object value)
        {
            if (isFixedSize || isReadOnly)
                throw new NotSupportedException();
            list.Add(value);
            return list.Size() - 1;
        }

        /// <summary>
        /// Add all elements in the given collection to the end of this list
        /// </summary>
        /// <param name="value"></param>
        public virtual void AddRange(ICollection c)
        {
            if (isFixedSize || isReadOnly)
                throw new NotSupportedException();
            if (c == null)
                throw new ArgumentNullException();
            foreach (var i in c)
            {
                list.Add(i);
            }
        }

        [NotImplemented]
        public virtual int BinarySearch(object element)
        {
            return Java.Util.Collections.BinarySearch(list, element, Comparer.Default);
        }

        [NotImplemented]
        public virtual int BinarySearch(object element, IComparer comparer)
        {
            comparer = comparer ?? Comparer.Default;
            return Java.Util.Collections.BinarySearch(list, element, comparer);
        }

        [NotImplemented]
        public virtual int BinarySearch(int index, int count, object element, IComparer comparer)
        {
            if ((index < 0) || (count < 0))
                throw new ArgumentOutOfRangeException();
            var size = list.Size();
            if ((index >= size) || (count > size) || (index + count > size))
                throw new ArgumentException();
            comparer = comparer ?? Comparer.Default;
            return Java.Util.Collections.BinarySearch(list.SubList(index, index + count), element, comparer);
        }

        /// <summary>
        /// Remove all elements
        /// </summary>
        public virtual void Clear()
        {
            if (isFixedSize || isReadOnly)
                throw new NotSupportedException();
            list.Clear();
        }

        /// <summary>
        /// Create a shallow clone of this list.
        /// </summary>
        /// <returns></returns>
        public virtual object Clone()
        {
            return new ArrayList(this);
        }

        /// <summary>
        /// Returns an enumerator for the entire list.
        /// </summary>
        /// <returns></returns>
        public virtual IEnumerator GetEnumerator()
        {
            return new IteratorWrapper<object>(list);
        }

        /// <summary>
        /// Returns an enumerator for the given range of this list.
        /// </summary>
        public virtual IEnumerator GetEnumerator(int index, int count)
        {
            if ((index < 0) || (count < 0))
                throw new ArgumentOutOfRangeException();
            var size = list.Size();
            if ((index >= size) || (count > size) || (index + count > size))
                throw new ArgumentException();
            return new IteratorWrapper<object>(list.SubList(index, index + count));
        }

        /// <summary>
        /// Is the given object part of this list?
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public virtual bool Contains(object value)
        {
            return list.Contains(value);
        }

        /// <summary>
        /// Create a list that is a subset of this list.
        /// </summary>
        public virtual ArrayList GetRange(int index, int count)
        {
            if ((index < 0) || (count < 0))
                throw new ArgumentOutOfRangeException();
            if (index + count >= list.Size())
                throw new ArgumentException();
            return new ArrayList(list.SubList(index, index + count), isFixedSize, isReadOnly, isSynchronized);
        }

        /// <summary>
        /// Gets the first index of the given element/
        /// </summary>
        /// <returns>-1 if not found</returns>
        public virtual int IndexOf(object element)
        {
            return list.IndexOf(element);
        }

        /// <summary>
        /// Gets the first index of the given element/
        /// </summary>
        /// <returns>-1 if not found</returns>
        public virtual int IndexOf(object element, int startIndex)
        {
            return IndexOf(element, startIndex, list.Size() - startIndex);
        }

        /// <summary>
        /// Gets the first index of the given element/
        /// </summary>
        /// <returns>-1 if not found</returns>
        public virtual int IndexOf(object element, int startIndex, int count)
        {
            if ((startIndex < 0) || (count < 0) || (startIndex >= list.Size()))
                throw new ArgumentOutOfRangeException();
            var rc = list.SubList(startIndex, startIndex + count).IndexOf(element);
            return (rc >= 0) ? rc + startIndex : rc;
        }

        /// <summary>
        /// Insert the given item at the given index.
        /// </summary>
        public virtual void Insert(int index, object element)
        {
            if (isFixedSize || isReadOnly)
                throw new NotSupportedException();
            if ((index < 0) || (index > list.Size()))
                throw new ArgumentOutOfRangeException();
            list.Add(index, element);
        }

        /// <summary>
        /// Insert the given items at the given index.
        /// </summary>
        public virtual void InsertRange(int index, ICollection c)
        {
            if (isFixedSize || isReadOnly)
                throw new NotSupportedException();
            if (c == null)
                throw new ArgumentNullException();
            if ((index < 0) || (index > list.Size()))
                throw new ArgumentOutOfRangeException();
            foreach (var item in c)
            {
                list.Add(index++, item);
            }
        }

        /// <summary>
        /// Gets the last index of the given element/
        /// </summary>
        /// <returns>-1 if not found</returns>
        public virtual int LastIndexOf(object element)
        {
            return list.LastIndexOf(element);
        }

        /// <summary>
        /// Gets the last index of the given element/
        /// </summary>
        /// <returns>-1 if not found</returns>
        public virtual int LastIndexOf(object element, int startIndex)
        {
            if ((startIndex < 0) || (startIndex >= list.Size()))
                throw new ArgumentOutOfRangeException();
            return list.SubList(0, startIndex).LastIndexOf(element);
        }

        /// <summary>
        /// Gets the last index of the given element/
        /// </summary>
        /// <returns>-1 if not found</returns>
        public virtual int LastIndexOf(object element, int startIndex, int count)
        {
            var size = list.Size();
            if ((startIndex < 0) || (count < 0) || (startIndex >= size))
                throw new ArgumentOutOfRangeException();
            var start = (startIndex - count) + 1;
            if (start < 0)
                throw new ArgumentOutOfRangeException();
            var end = startIndex + 1;
            var rc = list.SubList(start, end).LastIndexOf(element);
            return (rc >= 0) ? start + rc : rc;
        }

        /// <summary>
        /// Remove the given item
        /// </summary>
        public virtual void Remove(object element)
        {
            if (isFixedSize || isReadOnly)
                throw new NotSupportedException();
            list.Remove(element);
        }

        /// <summary>
        /// Remove the item at the given index.
        /// </summary>
        public virtual void RemoveAt(int index)
        {
            if (isFixedSize || isReadOnly)
                throw new NotSupportedException();
            if ((index < 0) || (index >= list.Size()))
                throw new ArgumentOutOfRangeException();
            list.Remove(index);
        }

        /// <summary>
        /// Remove a range of items from list starting at the given the given index.
        /// </summary>
        public virtual void RemoveRange(int index, int count)
        {
            if (isFixedSize || isReadOnly)
                throw new NotSupportedException();
            if ((index < 0) || (count < 0))
                throw new ArgumentOutOfRangeException();
            var size = list.Size();
            if ((index >= size) || (count > size) || (index + count > size))
                throw new ArgumentException();
            while (count > 0)
            {
                list.Remove(index);
                count--;
            }
        }

        /// <summary>
        /// Reverse the order of items in the entire list.
        /// </summary>
        public virtual void Reverse()
        {
            if (isReadOnly)
                throw new NotSupportedException();
            var size = list.Size();
            if (size > 1)
            {
                Java.Util.Collections.Reverse(list);
            }
        }

        /// <summary>
        /// Reverse the order of items in the given range.
        /// </summary>
        public virtual void Reverse(int index, int count)
        {
            if (isReadOnly)
                throw new NotSupportedException();
            if ((index < 0) || (count < 0))
                throw new ArgumentOutOfRangeException();
            var size = list.Size();
            if ((index >= size) || (count > size) || (index + count > size))
                throw new ArgumentException();
            if (count > 1)
            {
                Java.Util.Collections.Reverse(list.SubList(index, index + count));
            }
        }

        /// <summary>
        /// Copies the elements in the collection over the items in this list starting at the given list index.
        /// </summary>
        public virtual void SetRange(int index, ICollection c)
        {
            if (isReadOnly)
                throw new NotSupportedException();
            if (c == null)
                throw new ArgumentNullException();
            var count = c.Count;
            if ((index < 0) || (index + count > list.Size()))
                throw new ArgumentOutOfRangeException();
            foreach (var item in c)
            {
                list[index++] = item;
            }
        }

        /// <summary>
        /// Sort the elements in the entire list.
        /// </summary>
        public virtual void Sort()
        {
            if (isReadOnly)
                throw new NotSupportedException();
            Java.Util.Collections.Sort(list);
        }

        /// <summary>
        /// Sort the elements in the entire list.
        /// </summary>
        public virtual void Sort(IComparer comparer)
        {
            if (isReadOnly)
                throw new NotSupportedException();
            comparer = comparer ?? Comparer.Default;
            Java.Util.Collections.Sort(list, comparer);
        }

        /// <summary>
        /// Sort the elements in the given range.
        /// </summary>
        public virtual void Sort(int index, int count, IComparer comparer)
        {
            if (isReadOnly)
                throw new NotSupportedException();
            if ((index < 0) || (count < 0))
                throw new ArgumentOutOfRangeException();
            var size = list.Size();
            if ((index > size) || (count > size) || (index + count > size))
                throw new ArgumentException();
            comparer = comparer ?? Comparer.Default;
            Java.Util.Collections.Sort(list.SubList(index, index + count), comparer);
        }

        /// <summary>
        /// Copy all items of the list into a new array.
        /// </summary>
        public virtual object[] ToArray()
        {
            return list.ToArray();
        }

        /// <summary>
        /// Copy all items of the list into a new array.
        /// </summary>
        public virtual Array ToArray(Type elementType)
        {
            if (elementType == null)
                throw new ArgumentNullException();

            var arr = (Array)Java.Lang.Reflect.Array.NewInstance(elementType, list.Size());
            CopyTo(arr);
            return arr;
        }

        /// <summary>
        /// Set the capacity of the list to the number of items in the list.
        /// </summary>
        public virtual void TrimToSize()
        {
            if (isFixedSize || isReadOnly)
                throw new NotSupportedException();
        }

        /// <summary>
        /// Create an ArrayList wrapper around the given list.
        /// </summary>
        [NotImplemented]
        public static ArrayList Adapter(IList list)
        {
            if (list == null)
                throw new ArgumentNullException();
            throw new NotImplementedException("System.Collections.ArrayList.Adapter");
        }

        /// <summary>
        /// Create a list wrapper with a fixed size that is backed by the given list.
        /// </summary>
        public static ArrayList FixedSize(ArrayList list)
        {
            if (list == null)
                throw new ArgumentNullException();
            return new ArrayList(list.list, true, list.isReadOnly, list.isSynchronized);
        }

        /// <summary>
        /// Create a list wrapper with a fixed size that is backed by the given list.
        /// </summary>
        [NotImplemented]
        public static ArrayList FixedSize(IList list)
        {
            if (list == null)
                throw new ArgumentNullException();
            throw new NotImplementedException("System.Collections.ArrayList.FixedSize");
        }

        /// <summary>
        /// Create a readonly list wrapper that is backed by the given list.
        /// </summary>
        public static ArrayList ReadOnly(ArrayList list)
        {
            if (list == null)
                throw new ArgumentNullException();
            return new ArrayList(list.list, list.isFixedSize, true, list.isSynchronized);
        }

        /// <summary>
        /// Create a readonly list wrapper that is backed by the given list.
        /// </summary>
        [NotImplemented]
        public static ArrayList ReadOnly(IList list)
        {
            if (list == null)
                throw new ArgumentNullException();
            throw new NotImplementedException("System.Collections.ArrayList.ReadOnly");
        }

        /// <summary>
        /// Return an ArrayList filled count element of the given value.
        /// </summary>
        public static ArrayList Repeat(object value, int count)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException();
            var result = new ArrayList(count);
            while (count > 0)
            {
                result.list.Add(value);
                count--;
            }
            return result;
        }

        /// <summary>
        /// Create a thread safe list wrapper that is backed by the given list.
        /// </summary>
        public static ArrayList Synchronized(ArrayList list)
        {
            if (list == null)
                throw new ArgumentNullException();
            return new ArrayList(Java.Util.Collections.SynchronizedList(list.list), list.isFixedSize, list.isReadOnly, true);
        }

        /// <summary>
        /// Create a thread safe list wrapper that is backed by the given list.
        /// </summary>
        [NotImplemented]
        public static ArrayList Synchronized(IList list)
        {
            if (list == null)
                throw new ArgumentNullException();
            throw new NotImplementedException("System.Collections.ArrayList.Synchronized");
        }
    }
}

