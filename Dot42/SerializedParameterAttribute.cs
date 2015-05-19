using System;

namespace Dot42
{
    /// <summary>
    /// Specifies this parameter is used in serialization. Types and objects passed
    /// as this parameter will have all their public fields and public and private 
    /// properties preserved and not pruned.
    /// <para/>
    /// <para/>
    /// Can be used on normal and generic method parameters.
    /// <para/>
    /// Note that this Attribute is not inherited when used on generic method parameters.
    /// </summary>
    [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.GenericParameter, Inherited = true, AllowMultiple = false)]
    [Ignore]
    public class SerializedParameterAttribute : Attribute
    {
    }
}
