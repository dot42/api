using System;
using System.Linq;
using Java.Lang;
using Java.Util;

namespace Dot42.Collections
{
    /// <summary>
    /// Wraps <see cref="System.Collections.Generic.ICollection{T}"/> such that is can be used as <see cref="Java.Util.ICollection{T}"/> .
    /// </summary>
    public class CollectionToJavaWrapper<T> : Java.Util.ICollection<T>
    {
        private readonly System.Collections.Generic.ICollection<T> collection;

        public CollectionToJavaWrapper(System.Collections.Generic.ICollection<T> collection)
        {
            this.collection = collection;
        }

        public bool Add(T e)
        {
            collection.Add(e);
            return true;
        }

        public bool AddAll(Java.Util.ICollection<T> collection)
        {
            var iterator = collection.Iterator();
            while (iterator.HasNext)
            {
                this.collection.Add(iterator.Next());
            }
            return true;
        }

        public void Clear()
        {
            collection.Clear();
        }

        public bool Contains(object @object)
        {
            return collection.Contains((T)@object);
        }

        public bool ContainsAll(Java.Util.ICollection<object> other)
        {
            var iterator = other.Iterator();   
            while (iterator.HasNext)
            {
                if (!this.collection.Contains((T)iterator.Next()))
                    return false;
            }
            return true;
        }

        

        public bool Remove(object @object)
        {
            return collection.Remove((T) @object);
        }

        public bool RemoveAll(Java.Util.ICollection<object> other)
        {
            var iterator = other.Iterator();
            while (iterator.HasNext)
            {
                if (!this.collection.Remove((T)iterator.Next()))
                    return false;
            }
            return true;
        }

        public bool RetainAll(Java.Util.ICollection<object> other)
        {
            throw new NotImplementedException();
        }

        public int Size()
        {
            return collection.Count;
        }

        public object[] ToArray()
        {
            return (object[])(object)collection.ToArray();
        }

        public T1[] ToArray<T1>(T1[] p) 
        {
            return (T1[])(object)collection.ToArray();
        }

        public bool IsEmpty { get { return collection.Count == 0; } }

        public IIterator<T> Iterator()
        {
            return new EnumeratorWrapper<T>(collection.GetEnumerator());
        }
    }
}
