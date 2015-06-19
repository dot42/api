using System;
using System.Diagnostics;
using System.Reflection;
using Java.Lang.Ref;
using Java.Util;
using Java.Util.Concurrent;

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
        private const int LookupTypeField = 1;
        private const int LookupTypeMethod = 2;

        private static readonly ConcurrentHashMap<ReflectionLookupKey, SoftReference<object>> Cache = new ConcurrentHashMap<ReflectionLookupKey, SoftReference<object>>();
        
        public static PropertyInfo[] GetProperties(Type type, BindingFlags flags)
        {
            var key = new ReflectionLookupKey(LookupTypeProperty, type, null, flags);

            var softRef = Cache.Get(key);
            var retArray = softRef == null ? null : (PropertyInfo[])softRef.Get();
            if (retArray != null)
            {
                return retArray;
            }

            retArray = GetPropertiesImpl(type, flags);

            Cache.Put(key, new SoftReference<object>(retArray));
            return retArray;
        }

        public static PropertyInfo[] GetProperties(Type type, string name, BindingFlags flags)
        {
            var key = new ReflectionLookupKey(LookupTypeProperty, type, name, flags);
            var softRef = Cache.Get(key);
            var retArray = softRef == null ? null : (PropertyInfo[])softRef.Get();
            if (retArray != null)
                return retArray;

            retArray = GetProperties(type, flags).Where(p => p.Name == name);

            Cache.Put(key, new SoftReference<object>(retArray));
            return retArray;
        }

        private static PropertyInfo[] GetPropertiesImpl(Type type, BindingFlags flags)
        {
            ArrayList<PropertyInfo> ret = new ArrayList<PropertyInfo>();

            var isDeclaredOnly = ((int)flags & (int)BindingFlags.DeclaredOnly) != 0;
            bool isBase = false;
            HashSet<string> lookedAt = isDeclaredOnly ? null : new HashSet<string>();

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
            private readonly Type _type;
            private readonly string _memberName;
            private readonly BindingFlags _bindingFlags;

            public ReflectionLookupKey(int lookupType, Type type, string memberName, BindingFlags bindingFlags)
            {
                //_lookupType = lookupType;
                _type = type;
                _memberName = memberName;
                _bindingFlags = bindingFlags;
            }

            private bool Equals(ReflectionLookupKey other)
            {
                return _type == other._type && Equals(_memberName, other._memberName) && _bindingFlags == other._bindingFlags;
            }

            public override bool Equals(object obj)
            {
                if (ReferenceEquals(null, obj)) return false;
                if (ReferenceEquals(this, obj)) return true;
                if (obj.GetType() != typeof (ReflectionLookupKey))
                    return false;
                return Equals((ReflectionLookupKey) obj);
            }

            public override int GetHashCode()
            {
                unchecked
                {
                    var hashCode = _type.GetHashCode();
                    hashCode = (hashCode*397) ^ (_memberName != null ? _memberName.GetHashCode() : 0);
                    hashCode = (hashCode*397) ^ (int) _bindingFlags;
                    //hashCode = (hashCode*397) ^ (int)_lookupType;
                    return hashCode;
                }
            }
        }
    }
}
