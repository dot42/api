
namespace System.Reflection
{
    public abstract class MethodBase : JavaMemberInfo
    {
        public MethodBase(JavaConstructor ctor):base(ctor)
        {
        }

        public MethodBase(JavaMethod method) : base(method)
        {
        }

        /// <summary>
        /// Is this an abstract method?
        /// </summary>
        public abstract bool IsAbstract { get; }

        /// <summary>
        /// Is this an final method?
        /// </summary>
        public abstract bool IsFinal { get; }

        /// <summary>
        /// Is this an private method?
        /// </summary>
        public abstract bool IsPrivate { get; }

        /// <summary>
        /// Is this an public method?
        /// </summary>
        public abstract bool IsPublic { get; }

        /// <summary>
        /// Is this a static method?
        /// </summary>
        public abstract bool IsStatic { get; }

        /// <summary>
        /// Is this an virtual method?
        /// </summary>
        public abstract bool IsVirtual { get; }

        public abstract bool ContainsGenericParameters { get; }

        public abstract object Invoke(object instance, params object[] args);

        public abstract ParameterInfo[] GetParameters();
    }
}
