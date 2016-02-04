using System;
using System.Collections.Generic;
using System.Linq;
using Dot42.Collections.Specialized;
using Java.Lang.Reflect;
using Java.Util;

namespace Dot42.Internal.Generics
{
    /// <summary>
    /// Creates Generic Instance Types, i.e. types based on a generic template with the generic parameters
    /// filled in. These types should appear to be the reals thing, even though they are just proxies.
    /// </summary>
    internal static class GenericInstanceFactory
    {
        // These maps have ID charachter, and must be kept.
        private static readonly FastConcurrentHashMap<GenericTypeInfo, Type> TypeInfoToProxyType = new FastConcurrentHashMap<GenericTypeInfo, Type>();
        private static readonly ConcurrentTypeHashMap<GenericTypeInfo> ProxyTypeToTypeInfo = new ConcurrentTypeHashMap<GenericTypeInfo>();
        //private static readonly ConcurrentHashMap<GenericTypeInfo, Type> TypeInfoToProxyType = new ConcurrentHashMap<GenericTypeInfo, Type>();
        //private static readonly ConcurrentHashMap<Type, GenericTypeInfo> ProxyTypeToTypeInfo = new ConcurrentHashMap<Type, GenericTypeInfo>();

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

        public static Type GetOrMakeGenericInstanceType(Type baseType, Type gp1, Type gp2, Type gp3, Type gp4)
        {
            // TODO: make this work without an allocation.
            Type[] arguments;

            if      (gp2 == null)  arguments = new[] { gp1 };
            else if (gp3 == null)  arguments = new[] { gp1, gp2 };
            else if (gp4 == null)  arguments = new[] { gp1, gp2, gp3 };
            else                   arguments = new[] { gp1, gp2, gp3, gp4 };

            var typeId = new GenericTypeInfo(baseType, arguments);
            return GetOrMakeGenericInstanceType(typeId);
        }
       
        public static Type GetOrMakeGenericInstanceType(Type baseType, Type[] genericParameters)
        {
            // TODO: make this work without an allocation.
            var typeId = new GenericTypeInfo(baseType, genericParameters);
            return GetOrMakeGenericInstanceType(typeId);
        }

        private static Type GetOrMakeGenericInstanceType(GenericTypeInfo typeId)
        {
            Type proxyType = TypeInfoToProxyType.Get(typeId);

            Type previousProxyType = null;

            if (proxyType == null)
            {
                proxyType = CreateUniqueType();
                previousProxyType = TypeInfoToProxyType.PutIfAbsent(typeId, proxyType);

                // always put generic parameters, to avoid 
                // possible race. the final instance doesn't matter.
                ProxyTypeToTypeInfo.Put(proxyType, typeId);
            }

            return previousProxyType ?? proxyType;
        }

        /// <summary>
        /// returns null if 'proxyType' is not a proxy type.
        /// </summary>
        public static object CreateGenericInstance(Type proxyType, params object[] arguments)
        {
            // fast path to avoid the volatile access on the hash map.
            if (!IsGenericInstanceType(proxyType)) 
                // return null if not a generic instance.
                return null; 

            var typeInfo = ProxyTypeToTypeInfo.Get(proxyType);
            var newargs = typeInfo.AddOrGetGenericParameters(arguments);

            var constructor = Activator.GetBestMatchingConstructor(typeInfo.TypeDefinition, newargs);
            return constructor.NewInstance(newargs);
        }

        /// <summary>
        /// returns null if not a generic proxy type.
        /// </summary>
        public static Type GetGenericTypeDefinition(Type proxyType)
        {
            // fast path to avoid the volatile access on the hash map.
            if (!IsGenericInstanceType(proxyType)) return null;

            var typeInfo = ProxyTypeToTypeInfo.Get(proxyType);
            if (typeInfo == null) 
                return null;

            return typeInfo.TypeDefinition;
        }

        /// <summary>
        /// returns null if not a generic proxy type.
        /// </summary>
        public static GenericTypeInfo GetGenericTypeInfo(Type proxyType)
        {
            // fast path to avoid the volatile access on the hash map.
            if (!IsGenericInstanceType(proxyType)) return null;

            return ProxyTypeToTypeInfo.Get(proxyType);
        }

        [Inline]
        public static bool IsGenericInstanceType(Type type)
        {
            // fast path to avoid the volatile access on the hash map.
            return typeof (IGenericMarker0).JavaIsAssignableFrom(type);
        }

        private static Type CreateUniqueType()
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
