
namespace Dot42.Collections.Specialized
{
    internal interface IOpenHashMap<K, V>
    {
        V Get(K key);

        V Put(K key, V value);
        V PutIfAbsent(K key, V value);

        V Remove(K key);

        int Size { get; }

        /// <summary>
        /// Clone the current Map.
        /// </summary>
        /// <param name="newSize">
        /// 0  - size of current map
        /// <para/>
        /// &lt;0 - return an empty map
        /// <para/>
        /// &gt;0 - Max(newSize, currentSize, DefaultSize)                      
        /// </param>
        /// <returns></returns>
        IOpenHashMap<K, V> Clone(int newSize = 0);
    }
}
