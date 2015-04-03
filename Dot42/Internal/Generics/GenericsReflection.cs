using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using Android.Util;
using Java.Lang;
using Java.Lang.Reflect;

namespace Dot42.Internal.Generics
{
    internal class GenericsReflection
    {
        public const char GenericTickChar = '\x2b9'; // (ʹ)

        public static int GetGenericArgumentCount(Type type)
        {
            var info = type.GetAnnotation<ITypeReflectionInfo>(typeof(ITypeReflectionInfo));
            if (info == null)
                throw new InvalidOperationException("not a .NET generic type: " + type.FullName);
            return info.GenericArgumentCount();
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

            // .NET generic type definition
            var annotation = type.GetAnnotation<ITypeReflectionInfo>(typeof(ITypeReflectionInfo));
            return annotation != null && annotation.GenericArgumentCount() > 0;
        }


        /// <summary>
        /// will never return null.
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static Type GetBaseType(Type type)
        {
            var ret = GenericInstanceFactory.GetGenericTypeInfo(type);
            if (ret == null) return type.GetSuperclass();

            var typeDef = ret.TypeDefinition;
            var superclass = typeDef.GetSuperclass();

            var annotation = typeDef.GetAnnotation<ITypeReflectionInfo>(typeof(ITypeReflectionInfo));

            if (annotation == null)
                return superclass;
            var def = annotation.GenericDefinitions();

            if (def.Length == 0)
                return superclass;

            return ToMatchedGenericInstanceType(superclass, type, def);
        }

        /// <summary>
        /// will never return null.
        /// </summary>
        public static Type[] GetInterfaces(Type type)
        {
            var ret = GenericInstanceFactory.GetGenericTypeInfo(type);
            if (ret == null) return type.JavaGetInterfaces();

            var typeDef = ret.TypeDefinition;
            var interfaces = typeDef.GetInterfaces();

            var genericInstanceClass = type.GetAnnotation<ITypeReflectionInfo>(typeof(ITypeReflectionInfo));
            if (genericInstanceClass == null)
                return interfaces;

            var def = genericInstanceClass.GenericDefinitions();

            if (def.Length == 0)
                return interfaces;

            for (int i = 0; i < interfaces.Length; ++i)
            {
                interfaces[i] = ToMatchedGenericInstanceType(interfaces[i], type, def);
            }

            return interfaces;
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

            // generic definition? We can only return the number of objects.
            var annotation = type.GetAnnotation<ITypeReflectionInfo>(typeof(ITypeReflectionInfo));
            if (annotation != null)
            {
                ret = new Type[annotation.GenericArgumentCount()];
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

                return GenericInstanceFactory.GetOrMakeGenericRuntimeType(genericTypeDef, genericParameters);
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

            return GenericInstanceFactory.GetOrMakeGenericRuntimeType(baseType, types);
        }

        public static bool ContainsGenericParameters(Type type)
        {
            // not the real thing, but hopefully suffices.
            return IsGenericTypeDefinition(type);
        }

        public static bool IsGenericTypeDefinition(Type type)
        {
            // TODO: think about caching the return value;

            if (NullableReflection.TreatAsSystemNullableT(type))
                return false;
            if (GenericInstanceFactory.IsGenericInstanceType(type))
                return false;
            
            var annotation = type.GetAnnotation<ITypeReflectionInfo>(typeof(ITypeReflectionInfo));
            return annotation != null && annotation.GenericArgumentCount() > 0;
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
                           .Where(x => TypeHelper.Matches(x.GetModifiers(), flags))
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
            System.Array.Copy(parameters, trueParameters, parameters.Length);
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

            while (type != null)
            {
                GenericTypeInfo typeInfo = GenericInstanceFactory.GetGenericTypeInfo(type);

                var typeDef = typeInfo != null ? typeInfo.TypeDefinition : type;
                var fields = typeDef.JavaGetDeclaredFields();

                int startIndex = ret.Count;

                for (int i = 0; i < fields.Length; ++i)
                {
                    if (!TypeHelper.Matches(fields[i].GetModifiers(), flags))
                        continue;

                    ret.Add(new FieldInfo(fields[i], type));
                }

                ReorderFields(typeDef, startIndex, ret);

                if ((flags & BindingFlags.DeclaredOnly) != 0) break;

                type = type.BaseType;
            }
            return ret.ToArray();
        }

        private static void ReorderFields(Type typeDef, int startIndex, List<FieldInfo> ret)
        {
            var reflInfo = typeDef.GetAnnotation<ITypeReflectionInfo>(typeof (ITypeReflectionInfo));

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

        public static FieldInfo GetField(Type type, string name, BindingFlags flags)
        {
            while (type != null)
            {
                var typeInfo = GenericInstanceFactory.GetGenericTypeInfo(type);
                var typeDef = typeInfo != null ? typeInfo.TypeDefinition : type;

                // NOTE: doesn't throw AmbiguousMatchException
                var fields = typeDef.JavaGetDeclaredFields();

                for (int i = 0; i < fields.Length; ++i)
                {
                    if (fields[i].Name != name) continue;
                    if (!TypeHelper.Matches(fields[i].GetModifiers(), flags))
                        continue;
                    return new FieldInfo(fields[i], type);
                }

                if ((flags & BindingFlags.DeclaredOnly) != 0) 
                    break;

                type = type.BaseType;

                if (type == null)
                   break;
            }
            return null;
        }

        public static MethodInfo[] GetMethods(Type type, BindingFlags flags)
        {
            List<MethodInfo> ret = new List<MethodInfo>();

            while (type != null)
            {
                GenericTypeInfo typeInfo = GenericInstanceFactory.GetGenericTypeInfo(type);

                var typeDef = typeInfo != null? typeInfo.TypeDefinition : type;
                var methods = typeDef.JavaGetDeclaredMethods();

                for (int i = 0; i < methods.Length; ++i)
                {
                    if(!TypeHelper.Matches(methods[i].GetModifiers(), flags))
                        continue;

                    ret.Add(new MethodInfo(methods[i], type));
                }

                if ((flags & BindingFlags.DeclaredOnly) != 0) break;

                type = type.BaseType;
            }
            return ret.ToArray();
        }

        public static MethodInfo GetMethod(Type type, string name, Type[] parameters)
        {
            while (type != null)
            {
                var typeInfo = GenericInstanceFactory.GetGenericTypeInfo(type);
                var typeDef = typeInfo != null ? typeInfo.TypeDefinition : type;

                // NOTE: doesn't throw AmbiguousMatchException
                try
                {
                    JavaMethod m = parameters == null ? typeDef.JavaGetDeclaredMethod(name) : typeDef.JavaGetDeclaredMethod(name, parameters);
                    return new MethodInfo(m, type);
                }
                catch (NoSuchMethodException)
                {
                    type = type.BaseType;

                    if (type == null)
                        break;
                }
            }
            return null;
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

       
    }
}
