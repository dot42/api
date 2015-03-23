using System.Collections.Generic;
using System.Diagnostics;

namespace System.Collections.ObjectModel
{
    [Serializable]
    [DebuggerDisplay("Count = {Count}")]
    public abstract class KeyedCollection<TKey, TItem> : Collection<TItem>
    {
        IEqualityComparer<TKey> comparer;
        Dictionary<TKey, TItem> dict;

        public IEqualityComparer<TKey> Comparer { get { return comparer; } }

        protected KeyedCollection() : this(null) { }

        protected KeyedCollection(IEqualityComparer<TKey> comparer)
        {
            this.comparer = comparer;
            dict = new Dictionary<TKey, TItem>(comparer);
        }

        protected KeyedCollection(IEqualityComparer<TKey> comparer, int dictionaryCreationTheshold)
        {
            if(dictionaryCreationTheshold == -1)
                throw new NotImplementedException("KeyedCollection<,>: suppression of dictionary creation not supported.");

            this.comparer = comparer;
            dict = new Dictionary<TKey, TItem>(comparer);
        }


        public TItem this[TKey key]
        {
            get
            {
                return dict[key];
            }
        }

       public bool Contains(TKey key)
       {
            return dict.ContainsKey(key);
       }

        private bool ContainsItem(TItem item)
        {
            return dict.ContainsValue(item);
        }

        public bool Remove(TKey key)
        {
            ThrowHelper.ThrowIfArgumentNullException(key, "key");

            TItem item;
            if (dict.TryGetValue(key, out item))
            {
                int idx = Items.IndexOf(item);
                RemoveItem(idx);
                return true;
            }

            return false;
        }


        protected IDictionary<TKey, TItem> Dictionary
        {
            get { return dict; }
        }

       

        protected void ChangeItemKey(TItem item, TKey newKey)
        {
            // check if the item exists in the collection
            if (!ContainsItem(item))
            {
                throw new ArgumentException("item does not exist");
            }

            TKey oldKey = GetKeyForItem(item);
            //if (!comparer.Equals(oldKey, newKey))
            if (!Equals(oldKey, newKey))
            {
                if (newKey != null)
                {
                    AddKey(newKey, item);
                }

                if (oldKey != null)
                {
                    RemoveKey(oldKey);
                }
            }
        }

        protected override void ClearItems()
        {
            base.ClearItems();
            dict.Clear();
            
        }

        protected abstract TKey GetKeyForItem(TItem item);

        protected override void InsertItem(int index, TItem item)
        {
            if(index < 0 || index > Items.Count)
                ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.item);

            TKey key = GetKeyForItem(item);

            if (key != null)
                AddKey(key, item);

            base.InsertItem(index, item);

            
        }
        
        protected override void RemoveItem(int index)
        {
            TKey key = GetKeyForItem(Items[index]);
            if (key != null)
            {
                RemoveKey(key);
            }
            base.RemoveItem(index);
        }

        protected override void SetItem(int index, TItem item)
        {
            TKey newKey = GetKeyForItem(item);
            TKey oldKey = GetKeyForItem(Items[index]);

            //if (comparer.Equals(oldKey, newKey))
            if (Equals(oldKey,newKey))
            {
                if (newKey != null)
                    dict[newKey] = item;
            }
            else
            {
                if (newKey != null)
                    AddKey(newKey, item);

                if (oldKey != null)
                    RemoveKey(oldKey);
            }
            base.SetItem(index, item);
        }

        private void AddKey(TKey key, TItem item)
        {
            dict.Add(key, item);
        }

        private void RemoveKey(TKey key)
        {
            //Contract.Assert(key != null, "key shouldn't be null!");
            dict.Remove(key);
        }
    }
}