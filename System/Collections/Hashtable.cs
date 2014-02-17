// Copyright (C) 2014 dot42
//
// Original filename: Hashtable.cs
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
using System.Runtime.Serialization;
using Dot42;
using Dot42.Collections;
using Java.Lang;
using Java.Util;

namespace System.Collections
{
    /// <summary>
    /// Collection of key-value pairs organized using the hash code of the key.
    /// </summary>
	public class Hashtable : IDictionary
    {
        private readonly Hashtable<object, object> table;

        /// <summary>
        /// Default ctor
        /// </summary>
        public Hashtable()
        {
            table = new Hashtable<object, object>();
        }

        /// <summary>
        /// Default ctor
        /// </summary>
        public Hashtable(IDictionary source)
            : this()
        {
            foreach (var key in source.Keys)
            {
                table.Put(key, source[key]);
            }
        }

        /// <summary>
        /// Default ctor
        /// </summary>
        public Hashtable(IDictionary source, float loadFactory)
            : this(source.Count, loadFactory)
        {
            foreach (var key in source.Keys)
            {
                table.Put(key, source[key]);
            }
        }

        /// <summary>
        /// Default ctor
        /// </summary>
        public Hashtable(int initialCapacity)
        {
            table = new Hashtable<object, object>(initialCapacity);
        }

        /// <summary>
        /// Default ctor
        /// </summary>
        public Hashtable(int initialCapacity, float loadFactor)
        {
            table = new Hashtable<object, object>(initialCapacity, loadFactor);
        }

        /// <summary>
        /// Gets an enummerator to enumerate over all elements in this sequence.
        /// </summary>
        public IDictionaryEnumerator GetEnumerator()
        {
            return new HashtableIterator(table.EntrySet());
        }

        /// <summary>
        /// Gets an enummerator to enumerate over all elements in this sequence.
        /// </summary>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        /// <summary>
        /// Gets number of elements in this collection.
        /// </summary>
        public virtual int Count { get { return table.Size(); } }

        /// <summary>
        /// Is this collection thread safe.
        /// </summary>
        public virtual bool IsSynchronized { get { return false; } }

        /// <summary>
        /// Gets the object used to synchronize access to this collection.
        /// </summary>
        public virtual object SyncRoot { get { return null; } }

        [NotImplemented]
        public void CopyTo(Array array, int index)
        {
            throw new NotImplementedException("System.Collections.HashTable.CopyTo");
        }

        /// <summary>
        /// Does this dictionary have a fixed size?
        /// </summary>
        public bool IsFixedSize { get { return false; } }

        /// <summary>
        /// Is this dictionary read-only?
        /// </summary>
        public bool IsReadOnly { get { return false; } }

        /// <summary>
        /// Gets/sets an item with the given specified key.
        /// </summary>
        /// <value>The element with the specified key, or null if the key does not exist.</value>
        public object this[object key]
        {
            get
            {
                var obj = table.Get(key);
                
                return Null.IsNull(obj) ? null : obj;
            }
            set
            {
                if (value == null) value = Null.Instance;
                table.Put(key, value);
            }
        }

        /// <summary>
        /// Gets the keys of this dictionary.
        /// </summary>
        public ICollection Keys { get { return new JavaCollectionWrapper<object>(table.KeySet()); }}

        /// <summary>
        /// Gets the values of this dictionary.
        /// </summary>
        public ICollection Values
        {
            get { return new JavaCollectionWrapper<object>(table.Values()); }
        }

        /// <summary>
        /// Add the specified key-value pair to this dictionary.
        /// </summary>
        public virtual void Add(object key, object value)
        {
            if (table.ContainsKey(key))
                throw new ArgumentException("Duplicate key");

            if (value == null) value = Null.Instance;

            table.Put(key, value);
        }

        /// <summary>
        /// Remove all key-value pairs.
        /// </summary>
        public virtual void Clear()
        {
            table.Clear();
        }

        /// <summary>
        /// Create a shallow copy of this table.
        /// </summary>
        public virtual object Clone()
        {
            return new Hashtable(this);
        }

        /// <summary>
        /// Does this hashtable contain the given key?
        /// </summary>
        public virtual bool Contains(object key)
        {
            return table.ContainsKey(key);
        }

        /// <summary>
        /// Does this hashtable contain the given key?
        /// </summary>
        public virtual bool ContainsKey(object key)
        {
            return table.ContainsKey(key);
        }

        /// <summary>
        /// Does this hashtable contain the given value?
        /// </summary>
        public virtual bool ContainsValue(object value)
        {
            return table.ContainsValue(value);
        }

        /// <summary>
        /// Remove the key-value pair with the given key from this hashtable.
        /// </summary>
        public virtual void Remove(object key)
        {
            table.Remove(key);
        }

        /// <summary>
        /// Gets a thread safe version of this hashtable.
        /// </summary>
        [NotImplemented]
        public static Hashtable Synchronized(Hashtable table)
        {
            throw new NotImplementedException("System.Collections.HashTable.Synchronized");
        }

        /// <summary>
        /// Implements the ISerializable interface and returns the data needed to serialize the Hashtable.
        /// </summary>
        /// <remarks>Not implemented</remarks>
        [NotImplemented]
        public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
        {            
        }

        internal class HashtableIterator: IteratorWrapper<IMap_IEntry<object, object>>, IDictionaryEnumerator
        {
            public HashtableIterator(IIterable<IMap_IEntry<object, object>> iterator)
                :base(iterator)
            {
                
            }
           
            public DictionaryEntry Entry
            {
                get { return new DictionaryEntry(Key, Value); }
            }

            public object Key
            {
                get { return Current.GetKey(); }
            }
            public object Value
            {
                get { return Current.GetValue(); }
            }
        }
    }
}

