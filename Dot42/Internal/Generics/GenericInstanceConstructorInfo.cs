using System;
using System.Linq;
using System.Reflection;
using Java.Lang.Reflect;

namespace Dot42.Internal.Generics
{
    internal class GenericInstanceConstructorInfo : ConstructorInfo
    {
        private readonly Type _declaringType;
        private readonly GenericTypeInfo _genericType;

        public GenericInstanceConstructorInfo(Constructor ctor, Type declaringType, GenericTypeInfo genericType) : base(ctor)
        {
            _declaringType = declaringType;
            _genericType = genericType;
        }

        public override Type DeclaringType { get { return _declaringType; } }

        protected override Type[] JavaGetParameterTypes()
        {
            var baseParameters = JavaConstructor.ParameterTypes;
            return baseParameters.Take(baseParameters.Length - _genericType.NumberOfArguments);
        }

        public override object Invoke(object[] args)
        {
            object[] transformedArgs = _genericType.AddOrGetGenericParameters(args);
            return base.Invoke(transformedArgs);
        }
    }
}
