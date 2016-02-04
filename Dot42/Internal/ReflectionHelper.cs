using System;
using System.Reflection;
using Java.Util;

namespace Dot42.Internal
{
    internal class ReflectionHelper
    {
        public static PropertyInfo[] GetProperties(Type type, BindingFlags flags)
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
        
    }
}
