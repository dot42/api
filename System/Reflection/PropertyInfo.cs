// Copyright (C) 2014 dot42
//
// Original filename: PropertyInfo.cs
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Dot42;
using Dot42.Internal;

namespace System.Reflection
{
    /// <summary>
    /// Property reflection info.
    /// </summary>
    public class PropertyInfo : MemberInfo, IAttributesProvider
    {
        
        private readonly string name;
        private readonly MethodInfo getter;
        private readonly MethodInfo setter;
        private readonly IAttribute[] attributes;
        private Type declaringType;
        private Type propertyType;

        /// <summary>
        /// Default ctor
        /// </summary>
        internal PropertyInfo(Type declaringType, string name, MethodInfo getter, MethodInfo setter, IAttribute[] attributes)
        {
            this.declaringType = declaringType;
            this.name = name;
            this.getter = getter;
            this.setter = setter;
            this.attributes = attributes;
        }

        public override Type DeclaringType { get { return declaringType; } }

        /// <summary>
        /// Gets the name of this property
        /// </summary>
        public override string Name { get { return name; } }

        /// <summary>
        /// Gets this property be read from?
        /// </summary>
        public virtual bool CanRead { get { return (getter != null); } }

        /// <summary>
        /// Gets this property be written to?
        /// </summary>
        public virtual bool CanWrite { get { return (setter != null); } }

        /// <summary>
        /// Gets the get accessor method.
        /// </summary>
        public virtual MethodInfo GetGetMethod()  { return getter; }

        public virtual MethodInfo GetGetMethod(bool nonPublic) { return getter!=null&&getter.IsPublic?getter:null; }

        /// <summary>
        /// Gets the set accessor method.
        /// </summary>
        public virtual MethodInfo GetSetMethod() { return setter; }

        public virtual MethodInfo GetSetMethod(bool nonPublic) { return setter != null && setter.IsPublic ? getter : null; }

        /// <summary>
        /// this is not supported and always returns an empty array.
        /// </summary>
        /// <returns></returns>
        public ParameterInfo[] GetIndexParameters()
        {
            return new ParameterInfo[0];
        }

        /// <summary>
        /// Gets the type of this property
        /// </summary>
        public virtual Type PropertyType
        {
            get
            {
                if (propertyType == null)
                {
                    if (getter != null)
                    {
                        var nullableT = getter.JavaMethod.GetAnnotation<INullableT>(typeof (INullableT));
                        propertyType = nullableT != null ? nullableT.Type() : getter.ReturnType;
                    }
                    else if (setter != null)
                    {
                        var nullableT = setter.JavaMethod.GetParameterAnnotations()[0]
                                              .FirstOrDefault(x => x.AnnotationType() == typeof (INullableT));
                        if (nullableT != null)
                        {
                            propertyType = ((INullableT) nullableT).Type();
                        }
                        else
                        {
                            var paramTypes = setter.JavaMethod.GetParameterTypes();
                            propertyType = paramTypes[paramTypes.Length - 1];
                        }
                    }
                }
                return propertyType;
            }
        }

        /// <summary>
        /// Gets a value of the property for a given instance.
        /// </summary>
        public object GetValue(object instance)
        {
            if (getter == null)
                throw new InvalidOperationException("property has no getter");
            
            return getter.Invoke(instance, null);
        }

        /// <summary>
        /// Gets a value of the property for a given instance.
        /// </summary>
        public object GetValue(object instance, object[] index)
        {
            if (index != null)
                throw new ArgumentException("index");
            if (getter == null)
                throw new InvalidOperationException("property has no getter");

            return getter.Invoke(instance,null);
        }

        /// <summary>
        /// Sets a value of the property for a given instance.
        /// </summary>
        public void SetValue(object instance, object value, object[] index)
        {
            if(index != null)
                throw new ArgumentException("index");
            if (setter == null)
                throw new InvalidOperationException("property has no setter");
            setter.Invoke(instance, new [] {value});
        }

        /// <summary>
        /// Sets a value of the property for a given instance.
        /// </summary>
        public void SetValue(object instance, object value)
        {
            if (setter == null)
                throw new ArgumentException("property has no setter");
            setter.Invoke(instance, new[] { value });
        }

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
            return DeclaringType.FullName + "::" + Name;
        }

        /// <summary>
        /// Gets all attributes
        /// </summary>
        IAttributes IAttributesProvider.Attributes()
        {
            return new AttributesWrapper(attributes);
        }

        private class AttributesWrapper : IAttributes
        {
            private readonly IAttribute[] _attr;

            public AttributesWrapper(IAttribute[] attr)
            {
                _attr = attr;
            }

            public Type AnnotationType()
            {
                return typeof (IAttributes);
            }

            public IAttribute[] Attributes()
            {
                return _attr;
            }
        }
    }
}

