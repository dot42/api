
using Dot42.Internal;
using Java.Lang.Reflect;

namespace System.Reflection
{
    public abstract class MethodBase : JavaMemberInfo
    {
        private string[] _parameterNames = null;

        public MethodBase(Constructor ctor):base(ctor)
        {
        }

        public MethodBase(Method method) : base(method)
        {
        }

        /// <summary>
        /// Is this an abstract method?
        /// </summary>
        public bool IsAbstract { get { return Modifier.IsAbstract(Modifiers); } }

        /// <summary>
        /// Is this an virtual method?
        /// </summary>
        public bool IsVirtual { get { return !Modifier.IsFinal(Modifiers); } }

        public ParameterInfo[] GetParameters()
        {
            var types = JavaGetParameterTypes();
            var length = types.Length;

            if (length == 0)
                return new ParameterInfo[0];

            if (_parameterNames == null)
            {
                var reflInfo = Member.GetAnnotation<IReflectionInfo>(typeof(IReflectionInfo));
                _parameterNames = reflInfo == null ? new string[0] : reflInfo.ParameterNames();
            }

            ParameterInfo[] ret = new ParameterInfo[length];

            for (int idx = 0; idx < length; ++idx)
            {
                string paramName = idx < _parameterNames.Length ? _parameterNames[idx] : "arg" + idx;
                ret[idx] = new ParameterInfo(this, paramName, types[idx], idx);
            }

            return ret;
        }

        public abstract bool ContainsGenericParameters { get; }

        public abstract object Invoke(object instance, object[] args);

        protected abstract Type[] JavaGetParameterTypes();
    }
}
