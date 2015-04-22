using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using Android.Util;
using Dot42.Collections;
using Java.Lang;
using Java.Lang.Reflect;
using Java.Util;
using Java.Util.Concurrent;

namespace Dot42.Internal.Generics
{
    internal class GenericsReflection
    {
        private class TypeInfo
        {
            public Type[] Interfaces;
            public Java.Util.ISet<Type> InterfacesSet;
            public Java.Util.ISet<Type> BaseTypes;
            public Type BaseType;
            public int GenericArgumentCount;
            public Field GenericInstanceField;
        }
        private static readonly ConcurrentHashMap<Type, TypeInfo> TypeInfoCache = new ConcurrentHashMap<Type, TypeInfo>();
        
        
        public const char GenericTickChar = '\x2b9'; // (ʹ)

        public static int GetGenericArgumentCount(Type type)
        {
            var info = GetOrCreateGenericsInfo(type);

            if (info.GenericArgumentCount == -1)
                throw new InvalidOperationException("not a .NET generic type: " + type.FullName);
            return info.GenericArgumentCount;
        }

        public static bool IsGenericType(Type type)
        {
            // Java generic type?
            bool hasTypeParameters = type.GetTypeParameters().Length > 0;
            if (hasTypeParameters) return true;
            
            // Nullable<T>?
            if (NullableReflection.TreatAsSystemNullableT(type))
                return true;

            // generic proxy?
            if (GenericInstanceFactory.IsGenericInstanceType(type))
                return true;

            // .NET generic type definition?
            var info = GetOrCreateGenericsInfo(type);
            return info.GenericArgumentCount > 0;
        }


        /// <summary>
        /// will never return null.
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static Type GetBaseType(Type type)
        {
            var genericTypeInfo = GenericInstanceFactory.GetGenericTypeInfo(type);
            if (genericTypeInfo == null)
            {
                return type.GetSuperclass();
            }

            var info = GetOrCreateTypeInfo(type);

            var ret = info.BaseType;
            if (ret != null)
            {
                return ret;
            }
            
            var typeDef = genericTypeInfo.TypeDefinition;
            var superclass = typeDef.GetSuperclass();

            var annotation = typeDef.GetAnnotation<ITypeReflectionInfo>(typeof(ITypeReflectionInfo));

            if (annotation == null)
                return superclass;
            var def = annotation.GenericDefinitions();

            if (def.Length == 0)
                return superclass;

            info.BaseType = ret = ToMatchedGenericInstanceType(superclass, type, def);
            return ret;
        }

        /// <summary>
        /// will never return null.
        /// </summary>
        public static Type[] GetInterfaces(Type type)
        {
            var info = GetOrCreateTypeInfo(type);

            Type[] cached = info.Interfaces;

            if (cached != null)
                return cached;

            LinkedHashSet<Type> ret = new LinkedHashSet<Type>();

            // Note that JavaGetInterfaces will only return interfaces declared by the current type,
            // while .NET returns a flattened map of all interfaces.
            // http://stackoverflow.com/questions/6616055/get-all-derived-interfaces-of-a-class
            // http://stackoverflow.com/questions/9793242/type-getinterfaces-for-declared-interfaces-only

            Java.Util.IQueue<Type> toVisit = new Java.Util.LinkedList<Type>();
            toVisit.Add(type);

            while (toVisit.Peek() != null)
            {
                var currentType = toVisit.Poll();

                var gti = GenericInstanceFactory.GetGenericTypeInfo(currentType);

                bool isInterface = gti != null ? gti.TypeDefinition.JavaIsInterface() : currentType.JavaIsInterface();

                if (!isInterface)
                {
                    var baseType = currentType.BaseType;
                    if(baseType != null && baseType != typeof(object))
                        toVisit.Add(baseType);
                }

                if (gti == null)
                {
                    AddInterfaces(currentType.JavaGetInterfaces(), ret, toVisit);
                    continue;
                }

                var typeDef = gti.TypeDefinition;
                var interfaces = typeDef.JavaGetInterfaces();

                var genericInstanceClass = typeDef.GetAnnotation<ITypeReflectionInfo>(typeof(ITypeReflectionInfo));
                if (genericInstanceClass == null)
                {
                    AddInterfaces(interfaces, ret, toVisit);
                    continue;
                }

                var def = genericInstanceClass.GenericDefinitions();

                if (def.Length == 0)
                {
                    AddInterfaces(interfaces, ret, toVisit);
                    continue;
                }

                for (int i = 0; i < interfaces.Length; ++i)
                    interfaces[i] = ToMatchedGenericInstanceType(interfaces[i], currentType, def);
                
                AddInterfaces(interfaces, ret, toVisit);
            }

            cached = new JavaCollectionWrapper<Type>(ret).ToArray();
            info.Interfaces = cached;
            return cached;
        }

        private static void AddInterfaces(Type[] interfaces, Java.Util.ISet<Type> ret, Java.Util.IQueue<Type> toVisit)
        {
            foreach (var i in interfaces)
            {
                if (!ret.Contains(i))
                {
                    ret.Add(i);
                    toVisit.Add(i);
                }
            }
        }
        
        public static Type[] GetGenericArguments(Type type)
        {
            Type[] ret;

            // java generic type?
            var javaTypeParam = type.GetTypeParameters();
            if (javaTypeParam.Length != 0)
            {
                // java generic type. provide some emulation.
                 ret = new Type[javaTypeParam.Length];
                for (int i = 0; i < javaTypeParam.Length; ++i)
                    ret[i] = typeof(object);
                return ret;
            }

            // Nullable<T>?
            Type nullableUnderlying = NullableReflection.GetUnderlyingType(type);
            if (nullableUnderlying != null)
            {
                return new [] { nullableUnderlying };
            }

            // generic instance proxy?
            ret = GenericInstanceFactory.GetGenericArguments(type);
            if (ret != null)
                return ret;

            var info = GetOrCreateGenericsInfo(type);
            if (info.GenericArgumentCount > 0)
            {
                // generic definition? We can only return the number of objects.
                ret = new Type[info.GenericArgumentCount];
                for (int i = 0; i < ret.Length; ++i)
                    ret[i] = typeof(object);
                return ret;
            }

            throw new InvalidOperationException("not a generic type: " + type.FullName);
        }

        private static Type ToMatchedGenericInstanceType(Type perceivedType, Type parentType, IGenericDefinition[] definitions)
        {
            for (int i = 0; i < definitions.Length; ++i)
            {
                if (definitions[i].GenericTypeDefinition() != perceivedType)
                    continue;

                return ToGenericInstanceType(perceivedType, parentType, definitions[i]);
            }

            // we missed it, correct definition not found. just return perceivedType.
            return perceivedType;
        }

        public static Type GetMemberType(Type perceivedType, Type parentType, AccessibleObject member)
        {
            IGenericDefinition m = member.GetAnnotation<IGenericDefinition>(typeof (IGenericDefinition));

            if (m == null) 
                return perceivedType;

            return ToGenericInstanceType(perceivedType, parentType, m);
        }

        public static Type ToGenericInstanceType(Type perceivedType, Type parentType, IGenericDefinition m)
        {
            // is a specialized type defined?
            var genericInstanceType = m.GenericInstanceType();
            if (genericInstanceType != typeof(object))
                return genericInstanceType;

            int genericParameter = -1;
            var genericArguments = m.GenericArguments();

            // is a generic type definition class defined?
            var genericTypeDef = m.GenericTypeDefinition();
            if (genericTypeDef == typeof (object))
            {
                genericTypeDef = perceivedType;
                genericParameter = m.GenericParameter();
            }

            // retrieve generic parameters if required.
            Type[] parentGenericArguments = null;
            bool needParentGenericArguments = genericParameter >= 0
                                           || genericArguments.Any(a => !(a is Type));

            if (needParentGenericArguments)
            {
                parentGenericArguments = GenericInstanceFactory.GetGenericArguments(parentType);

                if (parentGenericArguments == null)
                {
                    // not so nice, but happens if we did'nt propagte the types correctly. 
                    // should be fixed... but bail out for now.
                    Log.W("dot42", string.Format("unable to reconstruct generic type definition for type {0}, parent type {1}", perceivedType.FullName, parentType.FullName));
                    return genericTypeDef;
                }
            }
            
            if (genericParameter != -1)
                genericTypeDef = parentGenericArguments[genericParameter];

            if (genericArguments.Length > 0)
            {
                Type[] genericParameters = new Type[genericArguments.Length];

                for (int i = 0; i < genericArguments.Length; ++i)
                {
                    Type arg;
                    var nestedGenDef = genericArguments[i] as IGenericDefinition;
                    if (nestedGenDef != null)
                    {
                        arg = ToGenericInstanceType(typeof (object), parentType, nestedGenDef);
                    }
                    else
                    {
                        arg = genericArguments[i] as Type;
                        if (arg == null)
                        {
                            arg = parentGenericArguments[(int) genericArguments[i]];
                        }
                    }
                    genericParameters[i] = arg;
                }

                return GenericInstanceFactory.GetOrMakeGenericInstanceType(genericTypeDef, genericParameters);
            }

            // return the type.
            return genericTypeDef;
        }

        public static Type GetGenericTypeDefinition(Type type)
        {
            // emulate Nullable<T>
            if (NullableReflection.TreatAsSystemNullableT(type))
                return typeof(Nullable<>);

            // is generic proxy?
            var ret = GenericInstanceFactory.GetGenericTypeDefinition(type);
            if (ret != null)
                return ret;

            // is generic type? just return itself.
            if (!IsGenericType(type))
                ThrowHelper.ThrowInvalidOperationException(ExceptionResource.NotAGenericType);

            return type;
        }

        public static Type MakeGenericType(Type baseType, Type[] types)
        {
            // emulate Nullable<T>
            if (baseType == typeof(Nullable<>))
            {
                if (types.Length != 1)
                    ThrowHelper.ThrowArgumentException(ExceptionResource.WrongNumberOfArguments);

                var ret = NullableReflection.GetNullableTFromUnterlyingType(types[0]);

                if (ret != null)
                    return ret;

                // can't create an a nullable instance of non-predifined nullable.
                // because of all the compiler-voodoo around Nullables.
                return null;
            }

            var expected = GetGenericArgumentCount(baseType);

            if (types.Length != expected)
                throw new ArgumentOutOfRangeException("types", string.Format("exected {0} generic arguments, got {1} for type {2}", expected, types.Length, baseType.FullName));

            return GenericInstanceFactory.GetOrMakeGenericInstanceType(baseType, types);
        }

        public static bool ContainsGenericParameters(Type type)
        {
            // not the real thing, but hopefully suffices.
            return IsGenericTypeDefinition(type);
        }

        public static bool IsGenericTypeDefinition(Type type)
        {
            TypeInfo info = GetOrCreateGenericsInfo(type);
            return info.GenericArgumentCount > 0;

        }

        public static bool IsAssignableFrom(Type type, Type other)
        {
            if(other == null) throw new ArgumentNullException("other");

            if (ReferenceEquals(type, other))
                return true;

            if (other.IsArray)
            {
                // special array handling code.
                if (type == typeof (IEnumerable) || type == typeof (ICollection) || type == typeof (IList))
                    return true;
                // TODO: make this work with generic collections as well.
            }

            if (type.IsInterface)
            {
                var interfaces = GetInterfacesSet(other);
                return interfaces.Contains(type);
            }
            else
            {
                var baseTypes = GetBaseTypes(other);
                return baseTypes.Contains(type);
            }
        }

        /// <summary>
        /// will return null if not a generic proxy type
        /// </summary>
        public static ConstructorInfo[] GetConstructors(Type type, BindingFlags flags)
        {
            var typeInfo = GenericInstanceFactory.GetGenericTypeInfo(type);
            if (typeInfo == null)
                return null;

            return typeInfo.TypeDefinition.JavaGetDeclaredConstructors()
                           .Where(x => TypeHelper.Matches(x.Modifiers, flags))
                           .Select(p => new GenericInstanceConstructorInfo(p, type, typeInfo.Arguments))
                           .ToArray();
        }

        /// <summary>
        /// will return null if not a generic proxy type
        /// </summary>
        public static ConstructorInfo GetConstructor(Type type, Type[] parameters)
        {
            var typeInfo = GenericInstanceFactory.GetGenericTypeInfo(type);
            if (typeInfo == null)
                return null;

            Type[] trueParameters = new Type[parameters.Length+1];
            
            for (int i = 0; i < parameters.Length; ++i)
                trueParameters[i] = EnsureTypeDef(parameters[i]);
            trueParameters[parameters.Length] = typeof (Type[]);

            try
            {
                var javaContructor = typeInfo.TypeDefinition.JavaGetConstructor(trueParameters);
                return new GenericInstanceConstructorInfo(javaContructor, type, typeInfo.Arguments);
            }
            catch (NoSuchMethodException)
            {
                return null;
            }
        }

        public static FieldInfo[] GetFields(Type type, BindingFlags flags)
        {
            List<FieldInfo> ret = new List<FieldInfo>();

            while (type != null && type != typeof(object))
            {
                GenericTypeInfo typeInfo = GenericInstanceFactory.GetGenericTypeInfo(type);

                var typeDef = typeInfo != null ? typeInfo.TypeDefinition : type;
                var fields = typeDef.JavaGetDeclaredFields();

                int startIndex = ret.Count;

                for (int i = 0; i < fields.Length; ++i)
                {
                    if (!TypeHelper.Matches(fields[i].Modifiers, flags))
                        continue;

                    ret.Add(new FieldInfo(fields[i], type));
                }

                ReorderFields(typeDef, startIndex, ret);

                if ((flags & BindingFlags.DeclaredOnly) != 0) break;

                type = type.BaseType;
            }
            return ret.ToArray();
        }

        public static FieldInfo GetField(Type type, string name, BindingFlags flags)
        {
            while (type != null && type != typeof(object))
            {
                var typeInfo = GenericInstanceFactory.GetGenericTypeInfo(type);
                var typeDef = typeInfo != null ? typeInfo.TypeDefinition : type;

                // NOTE: doesn't throw AmbiguousMatchException
                var fields = typeDef.JavaGetDeclaredFields();

                for (int i = 0; i < fields.Length; ++i)
                {
                    if (fields[i].Name != name) continue;
                    if (!TypeHelper.Matches(fields[i].Modifiers, flags))
                        continue;
                    return new FieldInfo(fields[i], type);
                }

                if ((flags & BindingFlags.DeclaredOnly) != 0) 
                    break;

                type = type.BaseType;
            }
            return null;
        }

        public static IEnumerable<MethodInfo> GetMethods(Type type, BindingFlags flags)
        {
            while (type != null)
            {
                GenericTypeInfo typeInfo = GenericInstanceFactory.GetGenericTypeInfo(type);

                var typeDef = typeInfo != null ? typeInfo.TypeDefinition : type;
                
                string possibleExplicitInterfacePrefix = typeDef.JavaIsInterface() ? typeDef.GetSimpleName()  + "_" : null;
                
                var methods = typeDef.JavaGetDeclaredMethods();
                for (int i = 0; i < methods.Length; ++i)
                {
                    if (!TypeHelper.Matches(methods[i].Modifiers, flags))
                        continue;

                    yield return new MethodInfo(methods[i], type, possibleExplicitInterfacePrefix);
                }

                if ((flags & BindingFlags.DeclaredOnly) != 0) break;

                type = type.BaseType;
            }
        }

        public static MethodInfo GetMethod(Type type, string name, BindingFlags flags, Type[] parameters)
        {
            // NOTE: doesn't throw AmbiguousMatchException,
            //       but just returns the first match.
            MethodInfo possibleGenericMatch = null;

            var paramLen = parameters == null ? 0 : parameters.Length;

            foreach (MethodInfo method in GetMethods(type, flags))
            {
                if(method.Name != name)
                    continue;

                if (parameters == null)
                    return method;

                var args = method.GetParameters();
                
                if (args.Length != paramLen)
                    continue;

                bool couldBeGenericMatch = false;

                for (int i = 0; i < paramLen; ++i)
                {
                    var methodParamType = args[i].ParameterType;
                    if(methodParamType == parameters[i])
                        continue;

                    // alternatively, this could be improved to take the actual generic instance and 
                    // type parameters into account; for this to work, GetMethods() would have to determine
                    // the correct parameter types, similar to whats done with getters/setters.

                    // Note that this will stop working when/if generic contrains are used to specialize
                    // generic parameters.
                    if (possibleGenericMatch == null && methodParamType == typeof (object))
                    {
                        couldBeGenericMatch = true;
                        continue;
                    }

                    goto nomatch;
                }
                // method matches!
                if (couldBeGenericMatch)
                    possibleGenericMatch = method;
                else
                    return method;


            nomatch:;
            }
            return possibleGenericMatch;
        }

        private static void ReorderFields(Type typeDef, int startIndex, List<FieldInfo> ret)
        {
            var reflInfo = typeDef.GetAnnotation<ITypeReflectionInfo>(typeof(ITypeReflectionInfo));

            // this is O(n^2), but don't bother: how many fields does a type have?
            if (reflInfo == null) return;

            string[] fieldOrder = reflInfo.Fields();

            for (int order = 0; order < fieldOrder.Length; ++order)
            {
                int curIndex = startIndex + order;
                for (; curIndex < ret.Count; ++curIndex)
                {
                    if (ret[curIndex].Name == fieldOrder[order])
                    {
                        if (curIndex - startIndex != order)
                        {
                            // just swap the two elements.
                            var tmp = ret[curIndex];
                            ret[curIndex] = ret[startIndex + order];
                            ret[startIndex + order] = tmp;
                        }
                        break;
                    }
                }
            }
        }

        /// <summary>
        /// will never return null
        /// </summary>
        public static string GetFullName(Type type)
        {
            var typeInfo = GenericInstanceFactory.GetGenericTypeInfo(type);
            if (typeInfo == null) 
                return type.JavaGetName().Replace(GenericTickChar, '`');

            StringBuilder b = new StringBuilder();

            b.Append(typeInfo.TypeDefinition.JavaGetName().Replace(GenericTickChar, '`'));
            b.Append('[');

            b.Append(string.Join(",", typeInfo.Arguments.Select(p => p.FullName)));
            b.Append(']');
            return b.ToString();
        }

        /// <summary>
        /// will never return null
        /// </summary>
        public static string GetName(Type type)
        {
            var baseType = GenericInstanceFactory.GetGenericTypeDefinition(type) ?? type;
            return baseType.GetSimpleName().Replace(GenericTickChar, '`');
        }

        /// <summary>
        /// return the generic type definition if, any or type itself.
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static Type EnsureTypeDef(Type type)
        {
            return GenericInstanceFactory.GetGenericTypeDefinition(type) ?? type;
        }

        private static Java.Util.ISet<Type> GetInterfacesSet(Type type)
        {
            var info = GetOrCreateTypeInfo(type);

            Java.Util.ISet<Type> ret = info.InterfacesSet;
            if (ret != null)
                return ret;

            var interfaces = GetInterfaces(type);

            ret = new Java.Util.HashSet<Type>(interfaces.Length);

            for (int i = 0; i < interfaces.Length; ++i)
                ret.Add(interfaces[i]);
            
            // No harm if we overwrite an ealier race-calculated value. If we use
            // Interlocked.CompareExchange the field would get implicit volatile.
            //return Interlocked.CompareExchange(ref info.InterfacesSet, ret, null) ?? ret;
            info.InterfacesSet = ret;
            return ret;
        }

        private static Java.Util.ISet<Type> GetBaseTypes(Type type)
        {
            var info = GetOrCreateTypeInfo(type);

            Java.Util.ISet<Type> ret = info.BaseTypes;
            
            if (ret != null)
                return ret;

            ret = new Java.Util.HashSet<Type>();

            for (Type baseType = type.BaseType; baseType != null; baseType = baseType.BaseType)
                ret.Add(baseType);

            //return Interlocked.CompareExchange(ref info.BaseTypes, ret, null) ?? ret;
            info.BaseTypes = ret;
            return ret;
        }

        private static TypeInfo GetOrCreateTypeInfo(Type type)
        {
            TypeInfo info = TypeInfoCache.Get(type);
            if (info == null)
            {
                var newInfo = new TypeInfo();
                info = TypeInfoCache.PutIfAbsent(type, newInfo) ?? newInfo;
            }
            return info;
        }

        private static TypeInfo GetOrCreateGenericsInfo(Type type)
        {
            var info = GetOrCreateTypeInfo(type);

            if (info.GenericArgumentCount != 0)
                return info;

            if (NullableReflection.TreatAsSystemNullableT(type))
                info.GenericArgumentCount = -1;
            else if (GenericInstanceFactory.IsGenericInstanceType(type))
                info.GenericArgumentCount = -1;
            else
            {
                var annotation = type.GetAnnotation<ITypeReflectionInfo>(typeof(ITypeReflectionInfo));
                var args = annotation != null ? annotation.GenericArgumentCount() : 0;
                info.GenericArgumentCount = args == 0 ? -1 : args;
                if (args > 0)
                {
                    var fieldName = annotation.GenericArgumentsField();
                    info.GenericInstanceField = type.JavaGetDeclaredFields()
                                                    .FirstOrDefault(f => f.Name == fieldName);
                }
            }

            return info;
        }

        public static Type GetReflectionSafeType(Type type, object obj)
        {
            // Note: If java had ephemerons, we could cache the return value.
            //       Without ephemerons, this doesn't seem to be a good idea.
            var info = GetOrCreateGenericsInfo(type);
            
            Field genericsField = info.GenericInstanceField;
            
            if (genericsField == null)
            {
                return type;
            }
            
            genericsField.IsAccessible = true;
            Type[] genericParameters = (Type[]) genericsField.Get(obj);
            
            return GenericInstanceFactory.GetOrMakeGenericInstanceType(type, genericParameters);
        }
    }
}
