using System;
using Dot42.Collections.Specialized;
using Java.Lang;

namespace Dot42.Internal.Generics
{
    internal class NullableReflection
    {
        private const string NullablePostfix = "__Nullable";
        
        private static readonly ConcurrentTypeHashMap<Type> UnderlyingCache = new ConcurrentTypeHashMap<Type>();

        internal static bool TreatAsSystemNullableT(Type type)
        {
            return TypeHelper.IsBoxedType(type) || IsNullableType(type);
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
            //return null;
        }

        public static Type GetUnderlyingTypeForMarked(Type nullableType)
        {
            if (!IsNullableType(nullableType))
                return null;

            var underlying = UnderlyingCache.Get(nullableType);

            if (underlying == null)
            {
                // is an internal nullable.
                var underlyingField = nullableType.JavaGetDeclaredField("underlying$");
                underlying = (Type)underlyingField.Get(null);
                UnderlyingCache.Put(nullableType, underlying);
            }

            return underlying;
        }

        public static Type GetNullableTFromUnterlyingType(Type type)
        {
            var boxed = TypeHelper.EnsureBoxedType(type);

            if (TypeHelper.IsBoxedType(boxed)) 
                return boxed;

            // this should not neccessary, but keep for safety,
            // and for not inadversely polluting our double-use 
            // underlying cache.
            if (IsNullableType(type))
            {
                return type;
            }


            Type nullableMarker = UnderlyingCache.Get(type);

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

            UnderlyingCache.Put(type, nullableMarker);

            return nullableMarker;
        }

        [Inline]
        private static bool IsNullableType(Type type)
        {
            return type.JavaGetName().EndsWith(NullablePostfix) && type.IsSynthetic;
        }
    }
}
