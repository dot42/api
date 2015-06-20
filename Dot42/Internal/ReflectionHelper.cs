//#define DUMP_PERFORMANCE

using System;
using System.Collections.Generic;
using System.Reflection;
using Android.Util;
using Dot42.Collections.Specialized;
using Java.Util;

namespace Dot42.Internal
{
    /// <summary>
    /// Performs and caches reflection operations.
    /// 
    /// At the moment only caches PropertyInfos, but could easily be extended to cache
    /// FieldInfos and MethodInfos as well. 
    /// </summary>
    internal class ReflectionHelper
    {
        private const int LookupTypeProperty = 0;
        private const int LookupTypeField    = 1;
        private const int LookupTypeMethod   = 2;

        private static readonly FastConcurrentHashMap<ReflectionLookupKey, object> Cache 
                          = new FastConcurrentHashMap<ReflectionLookupKey, object>(new ReflectionLookupHashMap());

        static ReflectionHelper()
        {
            Application.ReleaseCaches += (s, e) => Cache.Clear();
        }

        public static PropertyInfo[] GetProperties(Type type, BindingFlags flags)
        {
            var map = (ReflectionLookupHashMap) Cache.BaseMap;
            var retArray = (PropertyInfo[])map.Get(LookupTypeProperty, type, null, flags);
            if (retArray != null) return retArray;

            var key = new ReflectionLookupKey(LookupTypeProperty, type, null, flags);
            retArray = GetPropertiesImpl(type, flags);

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

        private static PropertyInfo[] GetPropertiesImpl(Type type, BindingFlags flags)
        {
            ArrayList<PropertyInfo> ret = new ArrayList<PropertyInfo>();

            var isDeclaredOnly = ((int)flags & (int)BindingFlags.DeclaredOnly) != 0;
            bool isBase = false;
            Java.Util.HashSet<string> lookedAt = isDeclaredOnly ? null : new Java.Util.HashSet<string>();

            // we have to walk all the way up.
            while (type != null)
            {
                foreach (var prop in type.GetDeclaredProperties())
                {
                    if (!IsMatch(prop, flags))
                        continue;

                    // make sure we don't return overriden properties.
                    if (!isDeclaredOnly)
                    {
                        string getterName = prop.GetMethod != null ? prop.GetMethod.Name : null;
                        string setterName = prop.SetMethod != null ? prop.SetMethod.Name : null;
                        if (isBase)
                        {
                            if (getterName != null && lookedAt.Contains(getterName))
                                continue;
                            if (setterName != null && lookedAt.Contains(setterName))
                                continue;
                        }

                        if (getterName != null)
                            lookedAt.Add(getterName);
                        if (setterName != null)
                            lookedAt.Add(setterName);
                    }

                    ret.Add(prop);
                }

                if (isDeclaredOnly)
                    break;

                type = type.BaseType;
                isBase = true;
            }

            return ret.ToArray(new PropertyInfo[ret.Count]);
        }

        private static bool IsMatch(PropertyInfo propertyInfo, BindingFlags flags)
        {
            // this methods is heavily used during reflection, so we have traded
            // readablility for performance.

            var mainMethod = propertyInfo.GetGetMethod() ?? propertyInfo.GetSetMethod();
            if (mainMethod == null)
                return false;

            if (flags == Type.BindFlags.AllMembers || flags == Type.BindFlags.DeclaredMembers)
                return true;

            bool incStatic   = (flags & BindingFlags.Static) == BindingFlags.Static;
            bool incInstance = (flags & BindingFlags.Instance) == BindingFlags.Instance;

            if (incInstance == incStatic && !incInstance)
                return false;

            if (incInstance != incStatic)
            {
                bool isStatic = mainMethod.IsStatic;

                if (!((incStatic && isStatic) || (incInstance && !isStatic)))
                    return false;
            }

            bool incPublic    = (flags & BindingFlags.Public) == BindingFlags.Public;
            bool incNonPublic = (flags & BindingFlags.NonPublic) == BindingFlags.NonPublic;

            if (incPublic == incNonPublic)
                return incPublic;

            bool isPublic = mainMethod.IsPublic;
            return (incPublic && isPublic) || (incNonPublic && !isPublic);

        }

        private sealed class ReflectionLookupKey
        {
            //private readonly int _lookupType;
            public readonly Type Type;
            public readonly string MemberName;
            public readonly BindingFlags BindingFlags;
            public readonly int HashCode;

            public ReflectionLookupKey(int lookupType, Type type, string memberName, BindingFlags bindingFlags)
            {
                //_lookupType = lookupType;
                Type = type;
                MemberName = memberName;
                BindingFlags = bindingFlags;
                HashCode = GetHashCode(type, memberName, bindingFlags);
            }

            [Inline]
            public static bool Equals(ReflectionLookupKey key, int hashCode, Type type, string memberName, BindingFlags bindingFlags)
            {
                return key.HashCode == hashCode
                    && key.Type == type
                    && key.BindingFlags == bindingFlags
                    && key.MemberName == memberName;
            }
            [Inline]
            public static bool Equals(ReflectionLookupKey key1, ReflectionLookupKey key2)
            {
                return key1.HashCode == key2.HashCode
                    && key1.Type == key2.Type
                    && key1.BindingFlags == key2.BindingFlags
                    && key1.MemberName == key2.MemberName;
            }

            [Inline]
            public static int GetHashCode(Type type, string memberName, BindingFlags bindingFlags)
            {
                unchecked
                {
                    var hashCode = Java.Lang.System.IdentityHashCode(type);
                    hashCode = (hashCode * 397) ^ (memberName != null ? memberName.GetHashCode() : 0);
                    hashCode = (hashCode * 397) ^ Java.Lang.System.IdentityHashCode(bindingFlags);
                    //hashCode = (hashCode*397) ^ (int)_lookupType;
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
                int baseHashCode = ReflectionLookupKey.GetHashCode(type, memberName, bindingFlags);
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
                    && ReflectionLookupKey.Equals((ReflectionLookupKey)k, baseHashCode, type, memberName, bindingFlags))
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
                        && ReflectionLookupKey.Equals((ReflectionLookupKey)k, baseHashCode, type, memberName, bindingFlags))
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
