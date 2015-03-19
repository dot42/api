namespace System.Reflection
{
    /// <summary>
    /// events through reflection are not supported.
    /// </summary>
    public class EventInfo : MemberInfo
    {
        public override Type DeclaringType { get { throw new NotImplementedException(); } }

        public override string Name { get { throw new NotImplementedException(); } }

        public Type EventHandlerType { get { throw new NotImplementedException(); } }
    }
}
