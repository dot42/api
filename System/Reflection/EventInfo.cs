namespace System.Reflection
{
    /// <summary>
    /// events through reflection are not supported.
    /// </summary>
    public class EventInfo : MemberInfo
    {
        public Type DeclaringType { get { throw new NotImplementedException(); } }

        public string Name { get { throw new NotImplementedException(); } }

        public Type EventHandlerType { get { throw new NotImplementedException(); } }
    }
}
