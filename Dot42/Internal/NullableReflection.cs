using System;
using Java.Lang;
using Java.Util.Concurrent;

namespace Dot42.Internal
{
    internal class NullableReflection
    {
        private const string NullablePostfix = "__Nullable";
        
        private static ConcurrentHashMap<Type, Type> _underlayingCache = new ConcurrentHashMap<Type, Type>();

        internal static bool TreatAsSystemNullableT(Type type)
        {
            return TypeHelper.IsBoxedType(type)
                || (type.IsSynthetic && type.Name.EndsWith(NullablePostfix));
        }

        public static Type GetUnderlyingType(Type nullableType)
        {
            if (nullableType == null)
                throw new ArgumentNullException("nullableType");

            var primitiveType = TypeHelper.EnsurePrimitiveType(nullableType);
            if (primitiveType != nullableType)
                return primitiveType;

            return GetUnderlyingTypeForMarked(nullableType);
            
            //// this will not work with Dot42's generic system, and always yield typeof(object)
            //if (nullableType.IsGenericType && nullableType.GetGenericTypeDefinition() == typeof(Nullable<>))
            //    return nullableType.GetGenericArguments()[0];
            //else
            return null;
        }

        public static Type GetUnderlyingTypeForMarked(Type nullableType)
        {
            if (!nullableType.IsSynthetic || !nullableType.Name.EndsWith(NullablePostfix))
                return null;

            var underlying = _underlayingCache.Get(nullableType);

            if (underlying == null)
            {
                // is an internal nullable.
                var underlyingField = nullableType.JavaGetDeclaredField("underlying$");
                underlying = (Type)underlyingField.Get(null);
                _underlayingCache.Put(nullableType, underlying);
            }

            return underlying;
        }

        public static Type GetNullableTFromUnterlyingType(Type type)
        {
            var boxed = TypeHelper.EnsureBoxedType(type);

            if (TypeHelper.IsBoxedType(type)) 
                return boxed;

            // this should not neccessary, but keep for safety,
            // and for not inadversely pulluting our double-use 
            // underlying cache.
            if (type.IsSynthetic && type.Name.EndsWith(NullablePostfix))
            {
                return type;
            }


            Type nullableMarker = _underlayingCache.Get(type);

            if (nullableMarker != null)
                return nullableMarker;

            // for now we have to use plain reflection, since we don't have 
            // annotations or special fields to get the NullableT of a base type.
            try
            {
                nullableMarker = Type.ForName(type.JavaGetName() + NullablePostfix);
            }
            catch (ClassNotFoundException)
            {
                // doesn't have a nullable type.
                nullableMarker = null;
            }

            _underlayingCache.Put(type, nullableMarker);

            return nullableMarker;
        }
    }
}
