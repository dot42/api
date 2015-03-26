using System;
using Java.Lang;

namespace Dot42.Internal
{
    internal class NullableReflection
    {
        private const string NullablePostfix = "__Nullable";

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

            if (nullableType.IsSynthetic && nullableType.Name.EndsWith(NullablePostfix))
            {
                // is an internal nullable.
                var underlying = nullableType.JavaGetDeclaredField("underlying$");
                return (Type)underlying.Get(null);
            }

            //// this will not work with Dot42's generic system, and always yield typeof(object)
            //if (nullableType.IsGenericType && nullableType.GetGenericTypeDefinition() == typeof(Nullable<>))
            //    return nullableType.GetGenericArguments()[0];
            //else
            return null;
        }

        public static Type GetNullableTFromUnterlyingType(Type type)
        {
            var boxed = TypeHelper.EnsureBoxedType(type);

            if (TypeHelper.IsBoxedType(type)) 
                return boxed;

            // this should not neccessary, but keep for safety.
            if (type.IsSynthetic && type.Name.EndsWith(NullablePostfix))
            {
                return type;
            }

            // for now we have to use plain reflection, since we don't have 
            // annotations or special fields to get the NullableT of a base type.
            try
            {
                return Type.ForName(type.JavaGetName() + NullablePostfix);
            }
            catch (ClassNotFoundException)
            {
                // doesn't have a nullable type.
                return null;
            }
        }
    }
}
