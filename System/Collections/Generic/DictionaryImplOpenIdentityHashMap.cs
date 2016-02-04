
using Dot42.Collections.Specialized;

namespace System.Collections.Generic
{
    public class DictionaryImplOpenIdentityHashMap<TKey,TValue> : IDictionaryImpl<TKey, TValue>, IDictionary
    {
        private readonly OpenIdentityHashMap<TKey, TValue> map;

        public DictionaryImplOpenIdentityHashMap()
        {
            map = new OpenIdentityHashMap<TKey, TValue>();
        }

        public DictionaryImplOpenIdentityHashMap(int capacity)
        {
            map = new OpenIdentityHashMap<TKey, TValue>(capacity);
        }
        
        /// <summary>
        /// Default ctor
        /// </summary>
        public DictionaryImplOpenIdentityHashMap(DictionaryImplOpenIdentityHashMap<TKey, TValue> source)
        {
            map = new OpenIdentityHashMap<TKey, TValue>(source.map);
        }

        /// <summary>
        /// Gets the number of elements
        /// </summary>
        public int Count { get { return map.Size; } }

        public bool IsReadOnly { get { return false; } }

        /// <summary>
        /// Gets or sets the value associated with the specified key.
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public TValue this[TKey key]
        {
            get
            {
                TValue value = map.Get(key);
                if(ReferenceEquals(value, default (TValue)) && !map.Contains(key)) // as lookups are lighning fast,  we spare us the implicit 
                                                                                  // allocation a call to TryGetValue would mean.
                    throw new KeyNotFoundException();

                return value;
            }
            set
            {
                map.Put(key, value);
            }
        }

        /// <summary>
        /// Add the given key and value to the dictionary.
        /// </summary>
        public void Add(TKey key, TValue value)
        {
            map.Put(key, value);
        }

        bool IDictionary<TKey, TValue>.Remove(TKey key)
        {
            return map.Remove(key);
        }

        /// <summary>
        /// Removes the given key from the dictionary.
        /// </summary>
        public void Remove(TKey key)
        {
            map.Remove(key);
        }

        public void Add(KeyValuePair<TKey, TValue> item)
        {
            map.Put(item.Key, item.Value);
        }

        /// <summary>
        /// Remove all entries
        /// </summary>
        public void Clear()
        {
            map.Clear();
        }

        public bool Contains(KeyValuePair<TKey, TValue> item)
        {
            TValue current;
            if (!map.TryGetValue(item.Key, out current))
                return false;
            return Equals(current, item.Value);
        }

        public bool Remove(KeyValuePair<TKey, TValue> item)
        {
            if (!Contains(item))
                return false;
            Remove(item.Key);
            return true;
        }

        public void CopyTo(KeyValuePair<TKey, TValue>[] array, int index)
        {
            Dot42.Collections.Collections.CopyTo(this, array, index);
        }
        public void CopyTo(Array array, int index)
        {
            Dot42.Collections.Collections.CopyTo(this, array, index);
        }

        public bool IsSynchronized { get { return false; } }
        public object SyncRoot { get { return map; } }

        ICollection<TValue> IDictionary<TKey, TValue>.Values
        {
            get { return Values; }
        }

        /// <summary>
        /// Does this dictionary contain an element with given key?
        /// </summary>
        public bool ContainsKey(TKey key)
        {
            return map.Contains(key);
        }

        /// <summary>
        /// Does this dictionary contain an element with given key?
        /// </summary>
        public bool ContainsValue(TValue value)
        {
            return map.ContainsValue(value);
        }

        /// <summary>
        /// Try to get a value from this dictionary.
        /// </summary>
        public bool TryGetValue(TKey key, out TValue value)
        {
            return map.TryGetValue(key, out value);
        }

        /// <summary>
        /// Gets the comparer used to compare keys.
        /// </summary>
        public IEqualityComparer<TKey> Comparer
        {
            get { return null; }
        }

        /// <summary>
        /// Gets an enummerator to enumerate over all elements in this sequence.
        /// </summary>
        /// <returns></returns>
        public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
        {
            return map.GetEnumerator();
        }

        /// <summary>
        /// Gets an enummerator to enumerate over all elements in this sequence.
        /// </summary>
        /// <returns></returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return map.GetEnumerator();
        }

        /// <summary>
        /// Gets the keys of the collection.
        /// </summary>
        public IEnumerable<TKey> Keys
        {
            get { return map.Keys; }
        }

        ICollection<TKey> IDictionary<TKey, TValue>.Keys
        {
            get { return map.Keys; }
        }

        /// <summary>
        /// Gets the values of the collection.
        /// </summary>
        public ICollection<TValue> Values
        {
            get { return map.Values; }
        }

        #region IDictionary implementation

        bool IDictionary.IsFixedSize { get { return false; } }

        bool IDictionary.Contains(object key)
        {
            return map.Contains((TKey)key);
        }

        void IDictionary.Add(object key, object value)
        {
            Add((TKey)key, (TValue)value);
        }

        IDictionaryEnumerator IDictionary.GetEnumerator()
        {
            return (IDictionaryEnumerator)map.GetEnumerator();
        }

        object IDictionary.this[object key] { get { return map.Get((TKey)key); } set { map.Put((TKey) key, (TValue) value); } }


        ICollection IDictionary.Keys { get { return (ICollection)map.Keys; } }
        ICollection IDictionary.Values { get { return (ICollection)map.Values; } }
        void IDictionary.Remove(object key) { map.Remove((TKey)key); }

        #endregion
    }
}
