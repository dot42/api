using System;

namespace Dot42
{
    /// <summary>
    /// Specifies this method as a serialization method. Arguments passed into this method,
    /// including generic arguments, and the return value will have all their fields 
    /// and properties included in the final output.
    /// </summary>
    [AttributeUsage(AttributeTargets.Method, Inherited = true, AllowMultiple = false)]
    [Ignore]
    public class SerializationMethodAttribute : Attribute
    {
    }
}
