
namespace Dot42.Collections.Specialized
{
    public interface IFastHashMap<K,V>
    {
        V Get(K key);

        V Put(K key, V value);
        V PutIfAbsent(K key, V value);

        V Remove(K key);

        int Size { get; }

        IFastHashMap<K, V> Clone(int newSize = -1);
    }
}
