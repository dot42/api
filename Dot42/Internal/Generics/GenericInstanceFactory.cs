using System;
using System.Collections.Generic;
using System.Linq;
using Java.Lang.Reflect;
using Java.Nio.Channels;
using Java.Util.Concurrent;

namespace Dot42.Internal.Generics
{
    /// <summary>
    /// Creates Generic Instance Types, i.e. types based on a generic template with the generic parameters
    /// filled in. These types should appear to be the reals thing, even though they are just proxies.
    /// </summary>
    internal static class GenericInstanceFactory
    {
        private static readonly ConcurrentHashMap<GenericTypeInfo, Type> TypeInfoToProxyType = new ConcurrentHashMap<GenericTypeInfo, Type>();
        private static readonly ConcurrentHashMap<Type, GenericTypeInfo> ProxyTypeToTypeInfo = new ConcurrentHashMap<Type, GenericTypeInfo>();

        private static readonly IEnumerator<IEnumerable<Type>> InterfacePermutations;

        static GenericInstanceFactory()
        {
            // should provide for 3.628.800 possible generic classes...
            var perm = new List<Type> { 
                        typeof(IGenericMarker0), typeof(IGenericMarker1), typeof(IGenericMarker2), 
                        typeof(IGenericMarker3), typeof(IGenericMarker4), typeof(IGenericMarker5),
                        typeof(IGenericMarker6),typeof(IGenericMarker7),typeof(IGenericMarker8),
                        typeof(IGenericMarker9)};
            InterfacePermutations = Permutation(perm).GetEnumerator();
        }

        public static Type GetOrMakeGenericRuntimeType(Type baseType, Type[] genericParameters)
        {
            var typeInfo = new GenericTypeInfo(baseType, genericParameters);

            Type proxyType = TypeInfoToProxyType.Get(typeInfo);

            Type previousProxyType = null;

            if (proxyType == null)
            {
                proxyType = CreateUniqueType(baseType, genericParameters);
                previousProxyType = TypeInfoToProxyType.PutIfAbsent(typeInfo, proxyType);

                // always put generic parameters, to avoid 
                // possible race. the final instance doesn't matter.
                ProxyTypeToTypeInfo.Put(proxyType, typeInfo);
            }

            return previousProxyType ?? proxyType;
        }

        public static object CreateGenericInstance(Type proxyType, params object[] arguments)
        {
            var typeInfo = ProxyTypeToTypeInfo.Get(proxyType);

            if (typeInfo == null) // return null if not a generic instance.
                return null;

            var args = new List<object>(arguments) {typeInfo.Arguments}.ToArray();
            var constructor = Activator.GetBestMatchingConstructor(typeInfo.TypeDefinition, args);
            return constructor.NewInstance(args);
        }

        /// <summary>
        /// returns null if not a generic proxy type.
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static Type GetGenericTypeDefinition(Type type)
        {
            var typeInfo = ProxyTypeToTypeInfo.Get(type);
            if (typeInfo == null) 
                return null;

            return typeInfo.TypeDefinition;

        }

        /// <summary>
        /// returns null if not a generic proxy type.
        /// </summary>
        public static Type[] GetGenericArguments(Type type)
        {
            var typeInfo = ProxyTypeToTypeInfo.Get(type);
            if (typeInfo == null)
                return null;
            return typeInfo.Arguments;
        }

        public static GenericTypeInfo GetGenericTypeInfo(Type type)
        {
            return ProxyTypeToTypeInfo.Get(type);
        }

        public static bool IsGenericInstanceType(Type type)
        {
            return ProxyTypeToTypeInfo.ContainsKey(type);
        }

        private static Type CreateUniqueType(Type baseType, Type[] genericParameters)
        {
            Type[] interfaces;
            lock (InterfacePermutations)
            {
                if (!InterfacePermutations.MoveNext())
                    ThrowHelper.ThrowInvalidOperationException(ExceptionResource.MaximumNumberOfGenericTypesReached);

                interfaces = InterfacePermutations.Current.ToArray();

            }
            var classLoader = typeof(GenericInstanceFactory).GetClassLoader();
            return Proxy.GetProxyClass(classLoader, interfaces);
        }

        // as per http://blog.kulman.sk/generating-all-permutations-of-a-list-how-hard-can-that-be/
        private static IEnumerable<IEnumerable<T>> Permutation<T>(System.Collections.Generic.ICollection<T> input)
        {
            if (input == null || !input.Any()) yield break;
            if (input.Count() == 1) yield return input;

            foreach (var item in input)
            {
                var next = input.Where(l => !l.Equals(item)).ToList();
                foreach (var perm in Permutation(next))
                {
                    var ret = new System.Collections.Generic.List<T> { item }.Concat(perm);
                    yield return ret;
                }
            }
        }

        internal interface IGenericMarker0 { }
        internal interface IGenericMarker1 { }
        internal interface IGenericMarker2 { }
        internal interface IGenericMarker3 { }
        internal interface IGenericMarker4 { }
        internal interface IGenericMarker5 { }
        internal interface IGenericMarker6 { }
        internal interface IGenericMarker7 { }
        internal interface IGenericMarker8 { }
        internal interface IGenericMarker9 { }
    }

}
