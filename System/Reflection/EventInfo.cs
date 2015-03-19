using Java.Lang.Reflect;

namespace System.Reflection
{
    /// <summary>
    /// events through reflection are not supported, and will 
    /// never be returned by the framework
    /// </summary>
    public class EventInfo : JavaMemberInfo
    {
        public EventInfo(AccessibleObject member) : base(member)
        {
        }

        //public override MemberTypes MemberType { get { return MemberTypes.Event; } }

        public override Type DeclaringType { get { throw new NotImplementedException(); } }

        public override string Name { get { throw new NotImplementedException(); } }

        public Type EventHandlerType { get { throw new NotImplementedException(); } }
    }
}
