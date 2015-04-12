using Java.Lang.Annotation;
using Java.Lang.Reflect;

namespace Dot42.Internal
{
    [IncludeType]
    internal interface IDelegateMethod : IAnnotation
    {
        Method Method();
    }
}
