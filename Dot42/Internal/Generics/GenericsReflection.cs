using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading;
using Android.Util;
using Dot42.Collections;
using Dot42.Collections.Specialized;
using Java.Lang;
using Java.Lang.Reflect;
using Java.Util;

namespace Dot42.Internal.Generics
{
    internal class GenericsReflection
    {
        private class InheritanceInfo
        {
            public Type[] Interfaces;
            public Java.Util.ISet<Type> InterfacesSet;
            public Java.Util.ISet<Type> BaseTypes;
        }

        private class GenericsInfo
        {
            public int GenericArgumentCount;
            public Field[] GenericInstanceFields;
            public bool GenericInstanceFieldIsTypeArray;
        }

        private class NullBaseType { }

        private static readonly ConcurrentTypeHashMap<InheritanceInfo> InheritanceCache = new ConcurrentTypeHashMap<InheritanceInfo>();
        private static readonly ConcurrentTypeHashMap<GenericsInfo> GenericInfoCache = new ConcurrentTypeHashMap<GenericsInfo>();
        private static readonly ConcurrentTypeHashMap<Type> BaseTypeCache = new ConcurrentTypeHashMap<Type>();
        //private static readonly ConcurrentTypeHashMap<TypeInfo> TypeInfoCache = new ConcurrentTypeHashMap<TypeInfo>();

        static GenericsReflection()
        {
            Application.ReleaseCaches += (s, e) =>
            {
                InheritanceCache.Clear();
                GenericInfoCache.Clear();
                BaseTypeCache.Clear();
            };
        }

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
            // this call makes Json.NET deserialization about 2.5 times as slow. 
            // If Java generics have any meanings to us, we would need to cache the 
            // return value.
            //bool hasTypeParameters = type.GetTypeParameters().Length > 0;
            //if (hasTypeParameters) return true;
            
            // Nullable<T>?
            if (NullableReflection.TreatAsSystemNullableT(type))
                return true;

            // generic proxy?
            if (GenericInstanceFactory.IsGenericInstanceType(type))
                return true;

            // .NET generic type definition?
            return IsGenericTypeDefinition(type);
        }


        /// <summary>
        /// will never return null.
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static Type GetBaseType(Type type)
        {
            if (type == typeof (object))
                return null;

            var genericTypeInfo = GenericInstanceFactory.GetGenericTypeInfo(type);
            if (genericTypeInfo == null)
            {
                return type.GetSuperclass();
            }

            var baseType = BaseTypeCache.Get(type);

            if (baseType != null)
                return baseType == typeof(NullBaseType) ? null : baseType;
            
            var typeDef = genericTypeInfo.TypeDefinition;
            baseType = typeDef.GetSuperclass();

            var annotation = typeDef.GetAnnotation<ITypeReflectionInfo>(typeof(ITypeReflectionInfo));

            if (annotation != null)
            {
                var def = annotation.GenericDefinitions();
                if (def.Length > 0)
                {
                    baseType = ToMatchedGenericInstanceType(baseType, type, def);        
                }
                    
            }

            BaseTypeCache.PutIfAbsent(type, baseType ?? typeof(NullBaseType));
            return baseType;
        }

        /// <summary>
        /// will never return null.
        /// </summary>
        public static Type[] GetInterfaces(Type type)
        {
            return GetOrCreateInheritanceInfo(type).Interfaces;
        }

        public static Type[] GetGenericArguments(Type type)
        {
            Type[] ret;

            // generic instance proxy?
            var genericTypeInfo = GenericInstanceFactory.GetGenericTypeInfo(type);
            if (genericTypeInfo != null)
                return (Type[])genericTypeInfo.AddOrGetGenericParameters(createTypeArray: true);

            // Nullable<T>?
            Type nullableUnderlying = NullableReflection.GetUnderlyingType(type);
            if (nullableUnderlying != null)
            {
                return new[] { nullableUnderlying };
            }

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
            GenericTypeInfo parentGenericArguments = null;
            bool needParentGenericArguments = genericParameter >= 0
                                           || genericArguments.Any(a => !(a is Type));

            if (needParentGenericArguments)
            {
                parentGenericArguments = GenericInstanceFactory.GetGenericTypeInfo(parentType);

                if (parentGenericArguments == null)
                {
                    // Can either happen when the generics reflection annotations where not preserved 
                    // (i.e. a bug),  when the user did not call GetTypeReflectionSafe() on an object, 
                    // or when requesting generics info not for an instance type, e.g. typeof(List<>). 
                    // As the second case can be difficult to debug, we emit a warning. TODO: we should 
                    // probably not emit a warning when the user code runs in release mode.
                    Log.W("dot42", string.Format("Unable to reconstruct generic type definition for type {0}, parent type {1}. Did you use obj.GetTypeReflectionSafe()? If you are reflecting on an open generic type, i.e. typeof(List<>) you can ignore this warning.", perceivedType.FullName, parentType.FullName));
                    return genericTypeDef;
                }
            }


            if (genericParameter != -1)
            {
                // ReSharper disable once PossibleNullReferenceException
                genericTypeDef = parentGenericArguments.GetGenericParameter(genericParameter);
            }

            if (genericArguments.Length > 0)
            {
                Type[] genericParameters = new Type[genericArguments.Length];

                for (int i = 0; i < genericArguments.Length; ++i)
                {
                    Type resolvedArg;
                    var arg = genericArguments[i];
                    if (arg.NestedType().Length > 0)
                    {
                        resolvedArg = ToGenericInstanceType(typeof(object), parentType, arg.NestedType()[0]);
                    }
                    else if (arg.FixedType().Length > 0)
                    {
                        resolvedArg = arg.FixedType()[0];
                    }
                    else
                    {
                        // must be an index
                        // ReSharper disable once PossibleNullReferenceException
                        resolvedArg = parentGenericArguments.GetGenericParameter(arg.ContainingTypeArgumentIndex());
                    }

                    genericParameters[i] = resolvedArg;
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

                // can't create a nullable instance of non-predifined nullable,
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

        [Inline]
        public static bool IsGenericTypeDefinition(Type type)
        {
            return typeof (IGenericTypeDefinition).JavaIsAssignableFrom(type);
            //TypeInfo info = GetOrCreateGenericsInfo(type);
            //return info.GenericArgumentCount > 0;

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

            var inheritanceInfo = GetOrCreateInheritanceInfo(other);
            return type.IsInterface ? inheritanceInfo.Interfaces.Contains(type) 
                                    : inheritanceInfo.BaseTypes.Contains(type);
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
                           .Select(p => (ConstructorInfo)new GenericInstanceConstructorInfo(p, type, typeInfo))
                           .Where(ctor=>Type.IsMatch(ctor, flags));
        }

        /// <summary>
        /// will return null if not a generic proxy type
        /// </summary>
        public static ConstructorInfo GetConstructor(Type type, Type[] parameters)
        {
            var typeInfo = GenericInstanceFactory.GetGenericTypeInfo(type);
            if (typeInfo == null)
                return null;

            Type[] trueParameters = typeInfo.AddGenericParameterTypes(parameters);

            for (int i = 0; i < parameters.Length; ++i)
                trueParameters[i] = EnsureTypeDef(parameters[i]);

            try
            {
                var javaContructor = typeInfo.TypeDefinition.JavaGetConstructor(trueParameters);
                return new GenericInstanceConstructorInfo(javaContructor, type, typeInfo);
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
                GenericTypeInfo typeId = GenericInstanceFactory.GetGenericTypeInfo(type);

                var typeDef = typeId != null ? typeId.TypeDefinition : type;
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
                GenericTypeInfo typeId = GenericInstanceFactory.GetGenericTypeInfo(type);

                var typeDef = typeId != null ? typeId.TypeDefinition : type;
                
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

                    // Note that this will stop working when/if generic constrains are used to specialize
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

            return typeInfo.GetFullName();
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

        private static InheritanceInfo GetOrCreateInheritanceInfo(Type type)
        {
            var info = InheritanceCache.Get(type);
            if (info != null) return info;
            info = CreateInheritanceInfo(type);
            return InheritanceCache.PutIfAbsent(type, info) ?? info;
        }

        private static GenericsInfo GetOrCreateGenericsInfo(Type type)
        {
            var info = GenericInfoCache.Get(type);
            if (info != null) return info;
            info = CreateGenericsInfo(type);
            return GenericInfoCache.PutIfAbsent(type, info) ?? info;
        }

        private static InheritanceInfo CreateInheritanceInfo(Type type)
        {
            LinkedHashSet<Type> intf = new LinkedHashSet<Type>();
            Java.Util.HashSet<Type> baseTypes = new Java.Util.HashSet<Type>();
            baseTypes.Add(typeof(object));

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
                    if (baseType != null && baseType != typeof(object))
                    {
                        toVisit.Add(baseType);
                        baseTypes.Add(baseType);
                    }
                }

                if (gti == null)
                {
                    AddInterfaces(currentType.JavaGetInterfaces(), intf, toVisit);
                    continue;
                }

                var typeDef = gti.TypeDefinition;
                var interfaces = typeDef.JavaGetInterfaces();

                var genericInstanceClass = typeDef.GetAnnotation<ITypeReflectionInfo>(typeof(ITypeReflectionInfo));
                if (genericInstanceClass == null)
                {
                    AddInterfaces(interfaces, intf, toVisit);
                    continue;
                }

                var def = genericInstanceClass.GenericDefinitions();

                if (def.Length == 0)
                {
                    AddInterfaces(interfaces, intf, toVisit);
                    continue;
                }

                for (int i = 0; i < interfaces.Length; ++i)
                    interfaces[i] = ToMatchedGenericInstanceType(interfaces[i], currentType, def);

                AddInterfaces(interfaces, intf, toVisit);
            }

            return new InheritanceInfo
            {
                Interfaces = new JavaCollectionWrapper<Type>(intf).ToArray(),
                InterfacesSet = new Java.Util.HashSet<Type>(intf),
                BaseTypes = baseTypes
            };
        }

        private static void AddInterfaces(Type[] interfaces, Java.Util.ISet<Type> ret, Java.Util.IQueue<Type> toVisit)
        {
            foreach (var i in interfaces)
            {
                if (i == typeof(IGenericTypeDefinition))
                    continue; // hide this marker interface.
                
                if (!ret.Contains(i))
                {
                    ret.Add(i);
                    toVisit.Add(i);
                }
            }
        }

        private static GenericsInfo CreateGenericsInfo(Type type)
        {
            var info = new GenericsInfo();

            if (NullableReflection.TreatAsSystemNullableT(type))
                info.GenericArgumentCount = -1;
            else if (GenericInstanceFactory.IsGenericInstanceType(type))
                info.GenericArgumentCount = -1;
            else
            {
                var annotation = type.GetAnnotation<ITypeReflectionInfo>(typeof(ITypeReflectionInfo));
                var args = annotation != null ? annotation.GenericArgumentCount() : 0;
                
                if (args > 0)
                {
                    var fieldNames = annotation.GenericArgumentsFields();
                    if (fieldNames.Length > 0)
                    {
                        var fields = type.JavaGetDeclaredFields();
                        info.GenericInstanceFields = fieldNames.Select(name =>
                        {
                            var field = fields.FirstOrDefault(f => f.Name == name);
                            field.IsAccessible = true;
                            return field;
                        });
                        info.GenericInstanceFieldIsTypeArray = info.GenericInstanceFields.Length == 1
                                                            && info.GenericInstanceFields[0].Type == typeof (Type[]);
                    }
                }
                info.GenericArgumentCount = args == 0 ? -1 : args;
            }

            return info;
        }

        public static Type GetReflectionSafeType(Type type, object obj)
        {
            if (!(obj is IGenericTypeDefinition)) // fast path
                return type;

            // Note: If java had ephemerons, we could cache the return value.
            //       Without ephemerons, this doesn't seem to be a good idea.
            //       We could though create an extra field in each generic type
            //       to hold the cached value. This would only pay off if 
            //       GetTypeReflectionSafe is actually called multiple times
            //       on the same object.
            var info = GetOrCreateGenericsInfo(type);
            
            Field[] genericsFields = info.GenericInstanceFields;

            int length;
            if (genericsFields == null || (length = genericsFields.Length) == 0)
            {
                return type;
            }

            Type[] genericParameters;

            if (info.GenericInstanceFieldIsTypeArray)
            {
                genericParameters = (Type[]) genericsFields[0].Get(obj);
                return GenericInstanceFactory.GetOrMakeGenericInstanceType(type, genericParameters);
            }
            if (length > 4)
            {
                // This can not happen with the current compiler.
                genericParameters = genericsFields.Select(f => (Type)f.Get(obj));
                return GenericInstanceFactory.GetOrMakeGenericInstanceType(type, genericParameters);
            }

            Type p1 = (Type) genericsFields[0].Get(obj);
            Type p2 = null, p3 = null, p4 = null;
            if (length > 1)
            {
                p2 = (Type) genericsFields[1].Get(obj);
                if (length > 2)
                {
                    p3 = (Type) genericsFields[2].Get(obj);
                    if (length > 3)
                    {
                        p4 = (Type)genericsFields[3].Get(obj);
                    }
                }
            }
            return GenericInstanceFactory.GetOrMakeGenericInstanceType(type, p1, p2, p3, p4);
        }
    }
}
