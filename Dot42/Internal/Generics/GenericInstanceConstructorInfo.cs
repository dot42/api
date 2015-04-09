using System;
using System.Reflection;
using Java.Lang.Reflect;

namespace Dot42.Internal.Generics
{
    internal class GenericInstanceConstructorInfo : ConstructorInfo
    {
        private readonly Type _declaringType;
        private readonly Type[] _genericParameters;

        public GenericInstanceConstructorInfo(Constructor ctor, Type declaringType, Type[] genericParameters) : base(ctor)
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

        public override object Invoke(object[] args)
        {
            var numArgs = args == null? 0: args.Length;

            object[] transformedArgs = new object[numArgs + 1];
            if(numArgs > 0)
                System.Array.Copy(args, transformedArgs, numArgs);

            transformedArgs[numArgs] = _genericParameters;

            return base.Invoke(transformedArgs);
        }
    }
}
