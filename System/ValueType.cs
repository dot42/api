using Dot42;

namespace System
{
    partial class ValueType
    {
        [NotImplemented("Please override Equals in your struct.")]
        public override bool Equals(object o)
        {
            throw new NotImplementedException("Please override Equals in struct " + GetType().FullName);
        }

        [NotImplemented("Please override GetHashCode in your struct.")]
        public override int GetHashCode()
        {
            throw new NotImplementedException("Please override GetHashCode in struct" + GetType().FullName);
        }
    }
}
