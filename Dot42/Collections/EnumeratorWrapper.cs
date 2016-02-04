using System;
using System.Collections.Generic;
using Java.Util;

namespace Dot42.Collections
{
    public class EnumeratorWrapper<T> : IIterator<T>
    {
        private readonly IEnumerator<T> enumerator;
        private T current;
        private bool finished;

        public EnumeratorWrapper(IEnumerator<T> enumerator)
        {
            this.enumerator = enumerator;
            Advance();
        }

        private void Advance()
        {
            finished = enumerator.MoveNext();
            current = enumerator.Current;
        }

        public T Next()
        {
            var ret = current;
            Advance();
            return ret;
        }

        public bool HasNext { get { return !finished; } }

        public void Remove()
        {
            throw new NotImplementedException();
        }
    }
}