using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Android.Util;
using Java.Lang;
using Java.Lang.Reflect;
using Java.Util;
using Java.Util.Concurrent;
using Exception = System.Exception;

namespace Dot42.Internal
{
    internal static class GenericInstanceFactory
    {
        private static readonly ConcurrentHashMap<Java.Util.IList<Type>, Type> GenericProxyTypes = new ConcurrentHashMap<Java.Util.IList<Type>, Type>();
        private static readonly ConcurrentHashMap<Type, Tuple<Type, Type[]>> GenericProxyTypeArguments = new ConcurrentHashMap<Type, Tuple<Type, Type[]>>();
        private static readonly IEnumerator<System.Collections.Generic.IEnumerable<Type>> InterfacePermutations;

        static GenericInstanceFactory()
        {
            // should provide for 3.628.800 possible generic classes...
            var perm = new System.Collections.Generic.List<Type> { 
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

            if (arguments.Length != 0)
                throw new NotImplementedException("arguments not yet supported.");
            string typeName = string.Format("{0}<{1}>", type.Item1, string.Join(",", (IEnumerable<Type>)type.Item2));
            Log.I("dot42", "creating generic type " + typeName);
            try
            {
                var constructor = type.Item1.GetConstructor(new[] { typeof(Type[]) });
                return constructor.Invoke(new object[] { type.Item2 });
            }
            catch (Exception ex)
            {
                
                throw new InvalidOperationException(string.Format("unable to create instance of " + typeName, ex));
            }
        }

        public static Type GetOrMakeGenericRuntimeType(Type baseType, Type[] genericParameters)
        {
            var expected = GetGenericArgumentCount(baseType);
            if (genericParameters.Length != expected)
                throw new ArgumentOutOfRangeException("typeArguments", string.Format("exected {0} generic arguments, got {1} for type {2}", expected, genericParameters.Length, baseType.FullName));

            var key = new ArrayList<Type>(genericParameters.Length + 1);
            Type[] param = new Type[genericParameters.Length];
            key.Add(baseType);
            for (int i = 0; i < genericParameters.Length; ++i)
            {
                var transformedType = TypeHelper.EnsureBoxedType(genericParameters[i]);
                key.Add(transformedType);
                param[i] = transformedType;
            }

            Type genericType = GenericProxyTypes.Get(baseType);
            Type previousGenericType = null;
            if (genericType == null)
            {
                genericType = CreateUniqueType(baseType, genericParameters);
                previousGenericType = GenericProxyTypes.PutIfAbsent(key, genericType);

                // always put generic parameters, to avoid 
                // possible race. the final instance doesn't matter.
                GenericProxyTypeArguments.Put(genericType, Tuple.Create(baseType, param));
            }

            return previousGenericType ?? genericType;
        }

        private static Type CreateUniqueType(Type baseType, Type[] genericParameters)
        {
            // TODO:would be nice if the proxy had the similar name and would actually derive from 
            //     the baseType. 
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

        private static int GetGenericArgumentCount(Type type)
        {
            var info = type.GetAnnotation<IGenericInstanceClass>(typeof(IGenericInstanceClass));
            if (info == null)
                throw new InvalidOperationException("not a .NET generic type: " + type.FullName);
            return info.ArgumentCount();
        }

        public static bool IsGenericType(Type type)
        {
            bool hasTypeParameters = type.GetTypeParameters().Length > 0;
            if(hasTypeParameters) return true;
            var annotation = type.GetAnnotation<IGenericInstanceClass>(typeof (IGenericInstanceClass));
            return annotation != null;
        }

        public static Type[] GetGenericArguments(Type type)
        {
            if (!IsGenericType(type))
                throw new InvalidOperationException("not a generic type: " + type.FullName);

            int count;
            var tp = type.GetTypeParameters();

            count = tp.Length > 0 ? tp.Length : GetGenericArgumentCount(type);

            Type[] ret = new Type[count];
            for (int i = 0; i < count; ++i)
                ret[i] = typeof(object);
            return ret;
        }

        internal interface IGenericMarker0 { void Foo0(); }
        internal interface IGenericMarker1 { void Foo1(); }
        internal interface IGenericMarker2 { void Foo2(); }
        internal interface IGenericMarker3 { void Foo3(); }
        internal interface IGenericMarker4 { void Foo4(); }
        internal interface IGenericMarker5 { void Foo5(); }
        internal interface IGenericMarker6 { void Foo6(); }
        internal interface IGenericMarker7 { void Foo7(); }
        internal interface IGenericMarker8 { void Foo8(); }
        internal interface IGenericMarker9 { void Foo9(); }
    }

}
