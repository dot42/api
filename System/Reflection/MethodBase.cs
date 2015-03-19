namespace System.Reflection
{
    // (olaf, 19.03.2015) This is a workaround, since 
    // ConstructorInfo and MethodInfo derive from 
    // their java counterparts. Not sure if this was the right decision.
    public class MethodBase
    {
        private readonly MethodInfo _method;
        private readonly ConstructorInfo _ctor;
        private readonly MemberInfo _member;

        public MethodBase(ConstructorInfo ctor)
        {
            _ctor = ctor;
            _member = ctor;
        }

        public MethodBase(MethodInfo method)
        {
            _method = method;
            _member = method;
        }

        public object Invoke(object instance, params object[] args)
        {
            if (_method != null)
                return _method.Invoke(instance, args);
            if(instance != null)
                throw new Exception("instance must be null for constructor call");
            return _ctor.Invoke(args);
        }

        public static explicit operator ConstructorInfo(MethodBase i)
        {
            return i._ctor;
        }

        public static explicit operator MethodInfo(MethodBase i)
        {
            return i._method;
        }

    }
}
