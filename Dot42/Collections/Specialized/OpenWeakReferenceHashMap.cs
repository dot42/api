using Java.Lang.Ref;

namespace Dot42.Collections.Specialized
{
    // Not used at the moment
    internal class OpenWeakReferenceHashMap<TKey, TValue> : OpenReferenceHashMapBase<TKey, TValue>
    {
        public OpenWeakReferenceHashMap(int size, float fillFactor = DefaultFillFactor) 
            : base(size, fillFactor)
        {
        }

        public OpenWeakReferenceHashMap(OpenReferenceHashMapBase<TKey, TValue> other, int newSize) 
            : base(other, newSize)
        {
        }

        public override IOpenHashMap<TKey, TValue> Clone(int newSize)
        {
            return new OpenWeakReferenceHashMap<TKey, TValue>(this, newSize);
        }

        protected override Reference<TKey> CreateReference(TKey key)
        {
            return new WeakReference<TKey>(key, m_queue);
        }
    }
}
