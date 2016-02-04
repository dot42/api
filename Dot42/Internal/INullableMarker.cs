using System;

namespace Dot42.Internal
{
    /// <summary>
    /// This marker interface is used to quickly check wether an object
    /// is a nullable marker type.
    /// </summary>
    [Include(TypeCondition = typeof(Nullable<>))]
    interface INullableMarker
    {
    }
}
