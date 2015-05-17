using Dot42;
using Dot42.Internal;
using Dot42.Internal.Generics;

namespace System.Reflection
{
    /// <summary>
    /// Event reflection info.
    /// </summary>
    public class EventInfo : MemberInfo, IAttributesProvider
    {
        private readonly Type _declaringType;
        private readonly string _name;
        private readonly MethodInfo _addMethod;
        private readonly MethodInfo _removeMethod;
        private readonly IAttribute[] _attributes;
        private Type _eventHandlerType;

        internal EventInfo(Type declaringType, string name, MethodInfo addMethod, MethodInfo removeMethod, IAttribute[] attributes)
        {
            _declaringType = declaringType;
            _name = name;
            _addMethod = addMethod;
            _removeMethod = removeMethod;
            _attributes = attributes;
        }

        public override MemberTypes MemberType { get { return MemberTypes.Event; } }
        public override Type DeclaringType { get { return _declaringType; } }
        public override string Name { get { return _name; } }

        public MethodInfo AddMethod { get { return _addMethod; } }
        public MethodInfo GetAddMethod() { return _addMethod; }

        public MethodInfo RemoveMethod { get { return _removeMethod; } }
        public MethodInfo GetRemoveMethod() { return _removeMethod; }

        public override object[] GetCustomAttributes(bool inherit)
        {
            return CustomAttributeProvider.GetCustomAttributes(this, inherit);
        }

        public override object[] GetCustomAttributes(Type attributeType, bool inherit)
        {
            return CustomAttributeProvider.GetCustomAttributes(this, attributeType, inherit);
        }

        public override bool IsDefined(Type attributeType, bool inherit)
        {
            return CustomAttributeProvider.IsDefined(this, attributeType, inherit);
        }

        public override string ToString()
        {
            return DeclaringType.Name + " " + Name;
        }


        public Type EventHandlerType
        {
            get
            {
                if (_eventHandlerType == null)
                {
                    var method = _addMethod ?? _removeMethod;
                    var paramType = method.JavaMethod.ParameterTypes.Last();
                    var genericInfo = (IGenericDefinition)method.JavaMethod.ParameterAnnotations
                                                                .Last()
                                                                .FirstOrDefault(x => x.AnnotationType() == typeof (IGenericDefinition));
                    if (genericInfo != null)
                    {
                        _eventHandlerType = GenericsReflection.ToGenericInstanceType(paramType, DeclaringType, genericInfo);
                    }
                    else
                    {
                        _eventHandlerType = paramType;
                    }
                }

                return _eventHandlerType;
            }
        }

        IAttributes IAttributesProvider.Attributes()
        {
            return new AttributesWrapper(_attributes);
        }

        protected bool Equals(EventInfo other)
        {
            return _declaringType == other._declaringType && Equals(_name, other._name);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((EventInfo)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (_declaringType.GetHashCode() * 397) ^ (_name != null ? _name.GetHashCode() : 0);
            }
        }
    }
}
