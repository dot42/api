using Dot42.Collections;
using Java.Lang;
using Java.Util;

namespace System.Collections.Generic
{
    public class Queue<T> : IEnumerable<T>, ICollection, ICollection<T>,IJavaCollectionWrapper<T>
    {
        private ArrayDeque<T> queue;
        public Queue()
        {
            queue = new ArrayDeque<T>();
        }

        public Queue(IEnumerable<T> collection)
        {
            queue = new ArrayDeque<T>();
            foreach (var elem in collection)
                queue.Add(elem);
        }

        public Queue(int capacity)
        {
            queue = new ArrayDeque<T>(capacity);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new IteratorWrapper<T>(queue);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Add(T item)
        {
            queue.AddLast(item);
        }

        public void Clear()
        {
            queue.Clear();   
        }

        public bool Contains(T item)
        {
            return queue.Contains(item);
        }

        public bool Remove(T item)
        {
            return queue.Remove(item);
        }

        public T Dequeue()
        {
            if(queue.IsEmpty)
                throw new InvalidOperationException("queue is empty");
            return queue.PollFirst();
        }

        public T Peek()
        {
            if (queue.IsEmpty)
                throw new InvalidOperationException("queue is empty");
            return queue.PeekFirst();
        }

        public void Enqueue(T item)
        {
            queue.AddLast(item);
        }
        

        public int Count { get { return queue.Size(); } }
        public bool IsReadOnly { get; private set; }
        public bool IsSynchronized { get { return false; } }
        public object SyncRoot { get { return queue; } }

        public void CopyTo(Array array, int index)
        {
            Dot42.Collections.Collections.CopyTo(queue, array, index);
        }

        public void CopyTo(T[] array, int index)
        {
            Dot42.Collections.Collections.CopyTo(queue, array, index);
        }

        Java.Util.ICollection<T> IJavaCollectionWrapper<T>.Collection { get { return queue; } }

        public class Enumerator<T> : IteratorWrapper<T>
        {
            public Enumerator(IIterable<T> iterable)
                : base(iterable)
            {
            }
        }
        
    }
}
