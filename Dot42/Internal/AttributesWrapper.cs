using System;

namespace Dot42.Internal
{
    internal class AttributesWrapper : IAttributes
    {
        private readonly IAttribute[] _attr;

        public AttributesWrapper(IAttribute[] attr)
        {
            _attr = attr;
        }

        public Type AnnotationType()
        {
            return typeof(IAttributes);
        }

        public IAttribute[] Attributes()
        {
            return _attr;
        }
    }
}