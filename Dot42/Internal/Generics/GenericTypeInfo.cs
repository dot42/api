using System;

namespace Dot42.Internal.Generics
{
    internal class GenericTypeInfo
    {
        public readonly Type TypeDefinition;
        public readonly Type[] Arguments;

        public GenericTypeInfo(Type typeDefinition, Type[] arguments)
        {
            TypeDefinition = typeDefinition;
            Arguments = arguments;
        }

        protected bool Equals(GenericTypeInfo other)
        {
            if(TypeDefinition != other.TypeDefinition) return false;
            if(Arguments.Length != other.Arguments.Length) return false;
            for(int i = 0; i < Arguments.Length; ++i)
                if(Arguments[i] !=other.Arguments[i]) return false;
            return true;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.JavaGetClass() != JavaGetClass()) return false;
            return Equals((GenericTypeInfo) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = TypeDefinition.GetHashCode();
                for (int i = 0; i < Arguments.Length; ++i)
                    hashCode = (hashCode*397) ^ Arguments[i].GetHashCode();
                return hashCode;
            }
        }
    }
}