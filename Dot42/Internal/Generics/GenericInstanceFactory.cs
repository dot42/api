using System;
using System.Collections.Generic;
using System.Linq;
using Java.Lang.Reflect;
using Java.Util;
using Java.Util.Concurrent;

namespace Dot42.Internal.Generics
{
    /// <summary>
    /// Creates Generic Instance Types, i.e. types based on a generic template with the generic parameters
    /// filled in. These types should appear to be the reals thing, even though they are just proxies.
    /// </summary>
    internal static class GenericInstanceFactory
    {
        private static readonly ConcurrentHashMap<Java.Util.IList<Type>, Type> GenericProxyTypes = new ConcurrentHashMap<Java.Util.IList<Type>, Type>();
        private static readonly ConcurrentHashMap<Type, Tuple<Type, Type[]>> GenericProxyTypeArguments = new ConcurrentHashMap<Type, Tuple<Type, Type[]>>();
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

        public static object CreateGenericInstance(Type markerType, params object[] arguments)
        {
            Tuple<Type, Type[]> type = GenericProxyTypeArguments.Get(markerType);

            if (type == null) // return null if not a generic instance.
                return null;

            
            List<Type> argumentTypes = arguments.Select(a => a == null 
                                                            ? typeof (object) 
                                                            : a.JavaGetClass())
                                                .ToList();
            argumentTypes.Add(typeof(Type[])); // the generic instance parameter.

            try
            {
                var constructor = type.Item1.GetConstructor(argumentTypes.ToArray());

                List<object> args = new List<object>(arguments) {type.Item2};

                return constructor.Invoke(args.ToArray());
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException(string.Format("unable to create instance of " + markerType.FullName, ex));
            }
        }

        /// <summary>
        /// returns null if not a generic proxy type.
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static Type GetGenericTypeDefinition(Type type)
        {
            Tuple<Type, Type[]> typeInfo = GenericProxyTypeArguments.Get(type);

            if (typeInfo == null) // return null if not a generic instance.
                return null;

            return typeInfo.Item1;

        }

        public static Tuple<Type, Type[]> GetGenericTypeInfo(Type type)
        {
            Tuple<Type, Type[]> typeInfo = GenericProxyTypeArguments.Get(type);

            if (typeInfo == null) // return null if not a generic instance.
                return null;

            return typeInfo;

        }


        /// <summary>
        /// returns null if not a generic proxy type.
        /// </summary>
        public static Type[] GetGenericArguments(Type type)
        {
            Tuple<Type, Type[]> typeInfo = GenericProxyTypeArguments.Get(type);

            if (typeInfo == null) // return null if not a generic instance.
                return null;
            return typeInfo.Item2;
        }

        public static bool IsGenericInstanceType(Type type)
        {
            return GenericProxyTypeArguments.ContainsKey(type);
        }

        public static Type GetOrMakeGenericRuntimeType(Type baseType, Type[] genericParameters)
        {
            var key = new ArrayList<Type>(genericParameters.Length + 1);

            key.Add(baseType);
            for (int i = 0; i < genericParameters.Length; ++i)
                key.Add(genericParameters[i]);

            Type genericType = GenericProxyTypes.Get(baseType);

            Type previousGenericType = null;
            if (genericType == null)
            {
                genericType = CreateUniqueType(baseType, genericParameters);
                previousGenericType = GenericProxyTypes.PutIfAbsent(key, genericType);

                // always put generic parameters, to avoid 
                // possible race. the final instance doesn't matter.
                GenericProxyTypeArguments.Put(genericType, Tuple.Create(baseType, genericParameters.ToArray()));
            }

            return previousGenericType ?? genericType;
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
