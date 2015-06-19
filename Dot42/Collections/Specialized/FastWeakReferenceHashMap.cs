using Java.Lang.Ref;

namespace Dot42.Collections.Specialized
{
    public class FastWeakReferenceHashMap<TKey, TValue> : FastReferenceHashMapBase<TKey, TValue>
    {
        public FastWeakReferenceHashMap(int size, float fillFactor = DefaultFillFactor) 
            : base(size, fillFactor)
        {
        }

        public FastWeakReferenceHashMap(FastReferenceHashMapBase<TKey, TValue> other, int newSize) 
            : base(other, newSize)
        {
        }

        public override IFastHashMap<TKey, TValue> Clone(int newSize)
        {
            return new FastWeakReferenceHashMap<TKey, TValue>(this, newSize);
        }

        protected override Reference<TKey> CreateReference(TKey key)
        {
            return new WeakReference<TKey>(key, m_queue);
        }
    }
}
