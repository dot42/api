using System;
using System.Reflection;

namespace Dot42.Internal.Generics
{
    internal class GenericInstanceConstructorInfo : ConstructorInfo
    {
        private readonly Type _declaringType;
        private readonly Type[] _genericParameters;

        public GenericInstanceConstructorInfo(JavaConstructor ctor, Type declaringType, Type[] genericParameters) : base(ctor)
        {
            _declaringType = declaringType;
            _genericParameters = genericParameters;
        }

        public override Type DeclaringType { get { return _declaringType; } }

        public override ParameterInfo[] GetParameters()
        {
            var baseParameters = base.GetParameters();
            return baseParameters.Take(baseParameters.Length - 1);
        }

        public override object Invoke(object instance, object[] args)
        {
            object[] transformedArgs = new object[args.Length + 1];
            System.Array.Copy(args, transformedArgs, args.Length);
            transformedArgs[args.Length] = _genericParameters;

            return base.Invoke(instance, args);
        }
    }
}
