using System;

namespace Dot42
{
    /// <summary>
    /// Specifies this method as a serialization method. Arguments passed into this method,
    /// including generic arguments, will have all their fields and properties
    /// preserved and not pruned.
    /// </summary>
    [AttributeUsage(AttributeTargets.Method, Inherited = true, AllowMultiple = false)]
    [Ignore]
    public class SerializationMethodAttribute : Attribute
    {
    }
}
