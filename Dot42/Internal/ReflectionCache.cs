//#define DUMP_PERFORMANCE

using System;
using System.Collections.Generic;
using System.Reflection;
using Dot42.Collections.Specialized;
using Java.Lang.Reflect;

namespace Dot42.Internal
{
    /// <summary>
    /// Performs and caches reflection operations.
    /// 
    /// Caching can be easily extended to fields and methods if 
    /// this should show neccessary in profiling.
    /// </summary>
    internal class ReflectionCache
    {
        private const int LookupTypeProperty = 0;
        private const int LookupTypeField    = 2;
        private const int LookupTypeMethod   = 3;

        private static readonly FastConcurrentHashMap<ReflectionLookupKey, object> Cache 
                          = new FastConcurrentHashMap<ReflectionLookupKey, object>(new ReflectionLookupHashMap());
        private static readonly ConcurrentTypeHashMap<Constructor[]> JavaDeclaredConstructorsCache = new ConcurrentTypeHashMap<Constructor[]>();

        static ReflectionCache()
        {
            Application.ReleaseCaches += (s, e) =>
            {
                Cache.Clear();
                JavaDeclaredConstructorsCache.Clear();
            };
        }

        public static PropertyInfo[] GetProperties(Type type, BindingFlags flags)
        {
            var map = (ReflectionLookupHashMap) Cache.BaseMap;
            var retArray = (PropertyInfo[])map.Get(LookupTypeProperty, type, null, flags);
            if (retArray != null) return retArray;

            var key = new ReflectionLookupKey(LookupTypeProperty, type, null, flags);

            retArray = ReflectionHelper.GetProperties(type, flags);

            Cache.Put(key, retArray);
            return retArray;
        }

        public static PropertyInfo[] GetProperties(Type type, string name, BindingFlags flags)
        {
            var map = (ReflectionLookupHashMap)Cache.BaseMap;
            var retArray = (PropertyInfo[])map.Get(LookupTypeProperty, type, name, flags);
            if (retArray != null) return retArray;

            var key = new ReflectionLookupKey(LookupTypeProperty, type, name, flags);

            retArray = GetProperties(type, flags).Where(p => p.Name == name);

            Cache.Put(key, retArray);
            return retArray;
        }

        public static Constructor[] JavaGetDeclaredConstructors(Type type)
        {
            var ret = JavaDeclaredConstructorsCache.Get(type);
            if (ret != null) return ret;

            ret = type.JavaGetDeclaredConstructors();

            JavaDeclaredConstructorsCache.Put(type, ret);
            return ret;
        }

        private sealed class ReflectionLookupKey
        {
            //public readonly int LookupType;
            public readonly Type Type;
            public readonly string MemberName;
            public readonly BindingFlags BindingFlags;
            public readonly int HashCode;

            public ReflectionLookupKey(int lookupType, Type type, string memberName, BindingFlags bindingFlags)
            {
                //LookupType = lookupType;
                Type = type;
                MemberName = memberName;
                BindingFlags = bindingFlags;
                HashCode = GetHashCode(lookupType, type, memberName, bindingFlags);
            }

            [Inline]
            public static bool Equals(ReflectionLookupKey key, int lookupType, int hashCode, Type type, string memberName, BindingFlags bindingFlags)
            {
                return key.HashCode == hashCode
                    //&& key.LookupType == lookupType
                    && key.Type == type
                    && key.BindingFlags == bindingFlags
                    && key.MemberName == memberName;
            }
            [Inline]
            public static bool Equals(ReflectionLookupKey key1, ReflectionLookupKey key2)
            {
                return key1.HashCode == key2.HashCode
                    //&& key1.LookupType == key2.LookupType
                    && key1.Type == key2.Type
                    && key1.BindingFlags == key2.BindingFlags
                    && key1.MemberName == key2.MemberName;
            }

            [Inline]
            public static int GetHashCode(int lookupType, Type type, string memberName, BindingFlags bindingFlags)
            {
                unchecked
                {
                    var hashCode = Java.Lang.System.IdentityHashCode(type);
                    //hashCode = (hashCode * 397) ^ lookupType;
                    hashCode = (hashCode * 397) ^ (memberName != null ? memberName.GetHashCode() : 0);
                    hashCode = (hashCode * 397) ^ Java.Lang.System.IdentityHashCode(bindingFlags);
                    return hashCode;
                }
            }
        }

        /// <summary>
        /// We implement a custom map to avoid the allocation on each lookup.
        /// While this might seem to be a little over the top, it shows how
        /// to do allocation-free lookups, and might come in handy on other 
        /// occasions.
        /// </summary>
        private sealed class ReflectionLookupHashMap : OpenEqualityComparerHashMap<ReflectionLookupKey, object>
        {
            public ReflectionLookupHashMap()
                : base(new EqualityComparer())
            {
            }

            public ReflectionLookupHashMap(ReflectionLookupHashMap other, int newSize)
                : base(other, newSize)
            {
            }

            public object Get(int lookupType, Type type, string memberName, BindingFlags bindingFlags)
            {
#if DUMP_PERFORMANCE
            if (m_totalGets != 0)
            {
                Log.Info("dot42", "fast hash map @{0} get performance: {1}/{2}={3:F1}: size {4} capacity {5}", GetHashCode(), m_totalAccesses, m_totalGets, (float)m_totalAccesses / m_totalGets, m_size, m_data.Length/2);
            }

            ++m_totalGets;
            ++m_totalAccesses;
#endif
                int baseHashCode = ReflectionLookupKey.GetHashCode(lookupType, type, memberName, bindingFlags);
                // this is slightly hackish, as we rely on implementation 
                // details of OpenEqualityComparerHashMap.GetHashCode
                int hashCode = baseHashCode ^ (baseHashCode >> 16); // spread

                int ptr = (hashCode & m_mask) << 1;
                object k = m_data[ptr];

                if (k == FreeKey)
                {
                    return null;
                }

                if (k != RemovedKey
                    && ReflectionLookupKey.Equals((ReflectionLookupKey)k, lookupType, baseHashCode, type, memberName, bindingFlags))
                {
                    return m_data[ptr + 1];
                }

                while (true)
                {
#if DUMP_PERFORMANCE
                ++m_totalAccesses;
#endif
                    ptr = (ptr + 2) & m_mask2; //that's next index
                    k = m_data[ptr];
                    if (k == FreeKey)
                    {
                        return null;
                    }
                    if (k != RemovedKey
                        && ReflectionLookupKey.Equals((ReflectionLookupKey)k, lookupType, baseHashCode, type, memberName, bindingFlags))
                    {
                        return m_data[ptr + 1];
                    }
                }
            }

            public override IOpenHashMap<ReflectionLookupKey, object> Clone(int newSize)
            {
                return new ReflectionLookupHashMap(this, newSize);
            }

            private class EqualityComparer : IEqualityComparer<ReflectionLookupKey>
            {
                public bool Equals(ReflectionLookupKey x, ReflectionLookupKey y)
                {
                    return ReflectionLookupKey.Equals(x, y);
                }

                public int GetHashCode(ReflectionLookupKey obj)
                {
                    return obj.HashCode;
                }
            }
        }
    }
}
