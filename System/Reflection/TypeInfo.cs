using System.Collections.Generic;
using System.Linq;

namespace System.Reflection
{
    public class TypeInfo
    {
        private readonly Type _type;

        internal TypeInfo(Type type)
        {
            _type = type;
        }

        public Assembly Assembly { get { return _type.Assembly; } }

        public IEnumerable<Type> ImplementedInterfaces
        {
            get { return _type.GetInterfaces(); }
        }

        public IEnumerable<ConstructorInfo> DeclaredConstructors
        {
            get { return _type.GetConstructors(Type.AllMembersBindingFlags); }
        }

        public IEnumerable<PropertyInfo> DeclaredProperties
        {
            get { return _type.GetProperties(Type.AllDeclaredMembersBindingFlags); }
        }

        public IEnumerable<MethodInfo> DeclaredMethods
        {
            get { return _type.GetMethods(Type.AllDeclaredMembersBindingFlags); }
        }

        public IEnumerable<FieldInfo> DeclaredFields
        {
            get { return _type.GetFields(Type.AllDeclaredMembersBindingFlags); }
        }

        public IEnumerable<Attribute> GetCustomAttributes(Type attributeType, bool inherit)
        {
            return _type.GetCustomAttributes(attributeType, inherit).Cast<Attribute>();
        }

        public IEnumerable<Attribute> GetCustomAttributes<T>(bool inherit) where T: Attribute
        {
            return _type.GetCustomAttributes(typeof(T), inherit).Cast<T>();
        }


        public bool IsValueType { get { return _type.IsValueType; } }
        public bool IsInterface { get { return _type.IsInterface; } }
        public bool IsEnum { get { return _type.IsEnum; } }
        public bool IsAbstract { get { return _type.IsAbstract; } }
        public bool IsPublic { get { return _type.IsPublic; } }
        public Type BaseType { get { return _type.BaseType; } }


        public bool IsAssignableFrom(TypeInfo other)
        {
            return _type.IsAssignableFrom(other._type);
        }

        public Type AsType()
        {
            return _type;
        }

    }
}
