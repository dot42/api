using System;
using System.Collections.Generic;

namespace Dot42.Internal.Generics
{
    /// <summary>
    /// One of GenericInstanceType, GenericParameter or GenericTypeDefinition
    /// define the generic type. If none of these are set, than the generic
    /// type is already specified by the type of field / parameter.
    /// </summary>
    internal class GenericDefinition
    {

        /// <summary>
        /// if set (!= null) the member is represented by this specialized class
        /// This is mutually exclusive to GenericTypeDefinition and GenericArguments
        /// </summary>
        /// <returns></returns>
        public Type GenericInstanceType;

        /// <summary>
        /// If != -1 this is an index into the parents generic arguments.
        /// This is mutually exclusive to GenericTypeDefinition.
        /// </summary>
        public int GenericParameter = -1;

        /// <summary>
        /// if set (ie. != null) this member contains the generic type definition type,
        /// further specified though arguments below. Will always be set for inheritance; can
        /// be set for members or parameter.
        /// </summary>
        /// <returns></returns>
        public Type GenericTypeDefinition;

        /// <summary>
        /// These are the arguments for a generic type denoted by
        /// either GenericParameter, GenericTypeDefinition or the
        /// annotated member/parameter. 
        /// 
        /// Can contain a mixture of ints as index into the 
        /// generic arguments of the containing class, System.Type's 
        /// for fixed arguments or IGenericDefinitions for 
        /// nested generic types.
        /// </summary>
        public GenericArgument[] GenericArguments;
    }
    
    /// <summary>
    /// Contains an arguments for a generic type.
    /// 
    /// Can be either an ints as index into the 
    /// generic arguments of the containing class, a
    /// System.Type for fixed arguments or an 
    /// IGenericDefinition for nested generic types.
    /// </summary>
    [Include]
    internal class GenericArgument
    {
        /// <summary>
        /// will be -1 if not used
        /// </summary>
        /// <returns></returns>
        public int ContainingTypeArgumentIndex = -1;

        /// <summary>
        /// will be null if not used
        /// </summary>
        /// <returns></returns>
        public Type FixedType;

        /// <summary>
        /// will be null if not used
        /// </summary>
        /// <returns></returns>
        public GenericDefinition NestedType;
    }
     
    internal static class DefinitionParser
    {
        public static GenericDefinition Parse(IGenericDefinition def)
        {
            return Parse(def.Definition());
        }

        public static GenericDefinition Parse(string def)
        {
            return Parse(def, 0, def.Length);
        }

        public static GenericDefinition Parse(string def, int start, int length)
        {
            int end = start + length;

            GenericDefinition ret = new GenericDefinition();

            if (length == 0)
                return ret;

            if (def[end - 1] == '>')
            {
                int descriptorEnd = def.IndexOf('<', start);
                string descriptor = def.Substring(start, descriptorEnd - start);
                ret.GenericTypeDefinition = GetTypeFromDescriptor(descriptor);

                start = descriptorEnd + 1;
                end = end - 1;
                length = end - start;
            }

            if (def[start] == '@')
            {
                string descriptor = def.Substring(start + 1, length - 1);
                ret.GenericInstanceType = GetTypeFromDescriptor(descriptor);
            }
            else if (length > 2 && def[start] == '!' && def[start + 1] == '!')
            {
                int genericParmIdx = int.Parse(def.Substring(2, length - 2));
                ret.GenericParameter = genericParmIdx;
            }
            else
            {
                // must be generic arguments.
                List<GenericArgument> args = new List<GenericArgument>();

                while (start < end)
                {
                    int curEnd = FindNextComma(def, start, end);

                    if(curEnd == start)
                        throw new Exception("definition syntax error");

                    GenericArgument arg = new GenericArgument();
                    if (def[start] == '!')
                    {
                        arg.ContainingTypeArgumentIndex = int.Parse(def.Substring(start+1, curEnd - start - 1));
                    }
                    else if (def[start] == '{')
                    {
                        if(def[curEnd - 1] != '}')
                            throw new Exception("definition syntax error");
                        arg.NestedType = Parse(def, start + 1, curEnd - 2 - start);
                    }
                    else
                    {
                        arg.FixedType = GetTypeFromDescriptor(def.Substring(start, curEnd - start));
                    }

                    args.Add(arg);

                    start = curEnd + 1;
                }

                ret.GenericArguments = args.ToArray();
            }

            return ret;
        }

        private static int FindNextComma(string def, int start, int end)
        {
            int openBrackets = 0;
            int pos = start;
            while (pos < end)
            {
                if (openBrackets == 0 && def[pos] == ',')
                    return pos;
                if (def[pos] == '}')
                    openBrackets -= 1;
                else if (def[pos] == '{')
                    openBrackets += 1;

                if(openBrackets < 0)
                    throw new Exception("definition syntax error");

                pos += 1;
            }

            return pos;
        }

        /// <summary>
        /// note that we do not take a real descriptor: '/' have already
        /// been replaced by '.', 'L' has been removed and the final semi-
        /// colon is missing.
        /// </summary>
        /// <param name="descriptor"></param>
        /// <returns></returns>
        private static Type GetTypeFromDescriptor(string descriptor)
        {
            if (descriptor.Length > 1)
            {
                return Type.ForName(descriptor);
            }
            if (descriptor == "I")
                return typeof(int);
            if (descriptor == "J")
                return typeof(long);
            if (descriptor == "Z")
                return typeof(bool);
            if (descriptor == "B")
                return typeof(byte);
            if (descriptor == "S")
                return typeof(short);
            if (descriptor == "F")
                return typeof(float);
            if (descriptor == "D")
                return typeof(double);
            if (descriptor == "C")
                return typeof(char);

            throw new Exception("unknown descriptor: " + descriptor);
        }
    }
}
