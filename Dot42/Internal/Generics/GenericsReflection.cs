using System;
using System.Linq;
using System.Reflection;
using System.Text;
using Java.Lang;
using Java.Lang.Reflect;

namespace Dot42.Internal.Generics
{
    internal class GenericsReflection
    {
        public const char GenericTickChar = '\x2b9'; // (ʹ)

        public static int GetGenericArgumentCount(Type type)
        {
            var info = type.GetAnnotation<IGenericInstanceClass>(typeof(IGenericInstanceClass));
            if (info == null)
                throw new InvalidOperationException("not a .NET generic type: " + type.FullName);
            return info.ArgumentCount();
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
            var annotation = type.GetAnnotation<IGenericInstanceClass>(typeof(IGenericInstanceClass));
            return annotation != null;
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
            var annotation = type.GetAnnotation<IGenericInstanceClass>(typeof(IGenericInstanceClass));
            if (annotation != null)
            {
                ret = new Type[annotation.ArgumentCount()];
                for (int i = 0; i < ret.Length; ++i)
                    ret[i] = typeof(object);
                return ret;
            }

            throw new InvalidOperationException("not a generic type: " + type.FullName);
        }

        public static Type GetMemberType(Type perceivedType, Type parentType, AccessibleObject member)
        {
            IGenericMember m = member.GetAnnotation<IGenericMember>(typeof (IGenericMember));

            if (m == null) 
                return perceivedType;

            return GetMemberType(perceivedType, parentType, m);
        }

        public static Type GetMemberType(Type perceivedType, Type parentType, IGenericMember m)
        {
            var genericInstanceType = m.GenericInstanceType().FirstOrDefault();
            if (genericInstanceType != null)
                return genericInstanceType;

            var genericArguments = m.GenericArguments();

            // retrieve generic parameters if required.
            Type[] parentGenericArguments = null;
            bool needParentGenericArguments = genericArguments.Length == 0
                                              || genericArguments.Any(a => !(a is Type));

            if (needParentGenericArguments)
            {
                parentGenericArguments = GenericInstanceFactory.GetGenericArguments(parentType);
                if (parentGenericArguments == null)
                {
                    // this can happen for generic arguments of generic arguments (or something)
                    // should be fixed... but bail out for now.
                    return perceivedType;
                }
            }


            if (genericArguments.Length > 0)
            {
                Type[] genericParameters = new Type[genericArguments.Length];

                for (int i = 0; i < genericArguments.Length; ++i)
                {
                    var argument = genericArguments[i] as Type;
                    if (argument == null)
                    {
                        // ReSharper disable once PossibleNullReferenceException
                        argument = parentGenericArguments[(int) genericArguments[i]];
                    }
                    genericParameters[i] = argument;
                }
                return GenericInstanceFactory.GetOrMakeGenericRuntimeType(perceivedType, genericParameters);
            }

            // must be a generic parameter.

            // ReSharper disable once PossibleNullReferenceException
            return parentGenericArguments[m.GenericParameter()];
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
            // emulate Nullable<T>
            if (NullableReflection.TreatAsSystemNullableT(type))
                return false;

            return IsGenericType(type);

        }

        public static bool IsGenericTypeDefition(Type type)
        {
            if (NullableReflection.TreatAsSystemNullableT(type))
                return false;
            if (GenericInstanceFactory.IsGenericInstanceType(type))
                return false;

            return IsGenericType(type);

        }

        public static ConstructorInfo[] GetConstructors(Type type, BindingFlags flags)
        {
            var typeInfo = GenericInstanceFactory.GetGenericTypeInfo(type);
            if (typeInfo == null)
                return null;

            return typeInfo.Item1.JavaGetDeclaredConstructors()
                           .Where(x => TypeHelper.Matches(x.GetModifiers(), flags))
                           .Select(p => new GenericInstanceConstructorInfo(p, type, typeInfo.Item2))
                           .ToArray();
        }

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
                var javaContructor = typeInfo.Item1.JavaGetConstructor(trueParameters);
                return new GenericInstanceConstructorInfo(javaContructor, type, typeInfo.Item2);
            }
            catch (NoSuchMethodException)
            {
                return null;
            }
        }

        public static string GetFullName(Type type)
        {
            var typeInfo = GenericInstanceFactory.GetGenericTypeInfo(type);
            if (typeInfo == null) 
                return type.JavaGetName().Replace(GenericTickChar, '`');

            StringBuilder b = new StringBuilder();

            b.Append(typeInfo.Item1.JavaGetName().Replace(GenericTickChar, '`'));
            b.Append('[');

            b.Append(string.Join(",", typeInfo.Item2.Select(p => p.FullName)));
            b.Append(']');
            return b.ToString();
        }

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
        public static Type ToGenericTypeDef(Type type)
        {
            return GenericInstanceFactory.GetGenericTypeDefinition(type) ?? type;
        }
    }
}
