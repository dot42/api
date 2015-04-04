using Dot42;

namespace System.Runtime.CompilerServices
{
    [AttributeUsageAttribute(AttributeTargets.Parameter, Inherited = false)]
    [Ignore]
    public sealed class CallerMemberNameAttribute : Attribute
    {
    }
}
