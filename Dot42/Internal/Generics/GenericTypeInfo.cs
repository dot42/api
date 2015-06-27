using System;
using System.Text;
using Java.Util;

namespace Dot42.Internal.Generics
{
    internal sealed class GenericTypeInfo
    {
        public const int NumberOfInlinedArguments = 4;

        public readonly Type TypeDefinition;
        public readonly Type[] Arguments;
        public readonly int HashCode;
        public readonly int NumberOfArguments;
        
        public GenericTypeInfo(Type typeDefinition, Type[] arguments)
        {
            TypeDefinition = typeDefinition;

            // always normalize
            var length = arguments.Length;
            NumberOfArguments = length;
            
            Arguments = arguments;
            HashCode = GetHashCode(typeDefinition, arguments);    
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.JavaGetClass() != JavaGetClass()) 
                return false;
            return Equals(this, (GenericTypeInfo) obj);
        }

        public override int GetHashCode()
        {
            return HashCode;
        }

        [Inline]
        private static int GetHashCode(Type typeDef, Type[] arguments)
        {
            unchecked
            {
                int hashCode = typeDef.GetHashCode();
                var length = arguments.Length;  
                for (int i = 0; i < length; ++i)
                    hashCode = (hashCode * 397) ^ arguments[i].GetHashCode();
                return hashCode;
            }
        }

        [Inline]
        private static int GetHashCode(Type typeDef, Type arg1, Type arg2, Type arg3, Type arg4)
        {
            unchecked
            {
                int hashCode = typeDef.GetHashCode();
                hashCode = (hashCode * 397) ^ arg1.GetHashCode();
                if (arg2 != null)
                {
                    hashCode = (hashCode * 397) ^ arg2.GetHashCode();
                    if (arg3 != null)
                    {
                        hashCode = (hashCode * 397) ^ arg3.GetHashCode();
                        if (arg4 != null)
                        {
                            hashCode = (hashCode * 397) ^ arg4.GetHashCode();
                        }
                    }
                }
                return hashCode;
            }
        }


        [Inline]
        internal static bool Equals(GenericTypeInfo gti1, Type typeDefinition, Type[] arguments)
        {
            if (gti1.TypeDefinition != typeDefinition)
                return false;

            var arglen = arguments.Length;
            if (arglen != gti1.NumberOfArguments)
                return false;
            
            var gtiArgs = gti1.Arguments;
            for (int i = 0; i < arglen; ++i)
                if (gtiArgs[i] != arguments[i])
                    return false;
            return true;
        }

        [Inline]
        internal static bool Equals(GenericTypeInfo gti1, Type typeDefinition, Type arg1, Type arg2, Type arg3, Type arg4)
        {
            if (gti1.TypeDefinition != typeDefinition)
                return false;
            var gtiArgs = gti1.Arguments;
            switch (gti1.NumberOfArguments)
            {
                case 4: if (gtiArgs[3] != arg4) return false; goto case 3;
                case 3: if (gtiArgs[2] != arg3) return false; goto case 2;
                case 2: if (gtiArgs[1] != arg2) return false; goto case 1;
                case 1: return gtiArgs[0] == arg1;
                default:
                    return false;
            }
        }

        [Inline]
        internal static bool Equals(GenericTypeInfo gti1, GenericTypeInfo gti2)
        {
            if (gti1.HashCode          != gti2.HashCode) return false;
            if (gti1.TypeDefinition    != gti2.TypeDefinition) return false;
            var len = gti1.NumberOfArguments;
            if (len != gti2.NumberOfArguments) return false;

            var args1 = gti1.Arguments;
            var args2 = gti2.Arguments;
            for (int i = 0; i < len; ++i)
                if (args1[i] != args2[i])     
                    return false;

            return true;
        }

        [Inline]
        public Type GetGenericParameter(int index)
        {
            return Arguments[index];
        }

        /// <summary>
        /// Add the generic parameters to the argument list, and return the new list.
        /// </summary>
        /// <param name="arguments">can be null, in which case a new array with 
        /// the generic parameters is returned. </param>
        public object[] AddOrGetGenericParameters(object[] arguments = null, bool createTypeArray = false)
        {
            object[] newargs;
            int newLength;

            if (arguments != null)
            {
                newLength = arguments.Length + NumberOfArguments;
                newargs = Arrays.CopyOf(arguments, newLength);
            }
            else
            {
                newLength = NumberOfArguments;
                newargs = createTypeArray ? new Type[newLength] : new object[newLength];
            }

            if (NumberOfArguments > NumberOfInlinedArguments)
            {
                newargs[newargs.Length - 1] = Arguments;
            }
            else
            {
                int idx = newLength - 1;
                for (int i = NumberOfArguments - 1; i >= 0; --i, --idx)
                {
                    newargs[idx] = Arguments[i];
                }
            }
            return newargs;
        }

        public string GetFullName()
        {
            StringBuilder b = new StringBuilder();

            b.Append(TypeDefinition.JavaGetName());
            b.Replace(GenericsReflection.GenericTickChar, '`');
            b.Append('[');
            b.Append(string.Join(",", Arguments.Select(p => p.FullName)));
            b.Append(']');
            return b.ToString();
        }
    }
}