using System.Reflection;

namespace Dot42.Internal
{
    [IncludeType]
    internal interface IDelegateMethod
    {
        MethodInfo Method();
    }
}
