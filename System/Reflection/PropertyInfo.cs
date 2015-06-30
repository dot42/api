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
using Dot42.Internal.Generics;

namespace System.Reflection
{
    /// <summary>
    /// Property reflection info.
    /// </summary>
    public class PropertyInfo : MemberInfo, IAttributesProvider
    {
        private static readonly ParameterInfo[] EmptyParameterInfo = new ParameterInfo[0];

        private readonly string name;
        private readonly MethodInfo getter;
        private readonly MethodInfo setter;
        private readonly IAttribute[] attributes;
        private readonly Type declaringType;
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

        public override MemberTypes MemberType { get { return MemberTypes.Property; } }

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
        public virtual MethodInfo GetMethod { get { return getter; } }

        public virtual MethodInfo GetGetMethod(bool nonPublic) { return getter!=null&&getter.IsPublic?getter:null; }

        /// <summary>
        /// Gets the set accessor method.
        /// </summary>
        public virtual MethodInfo GetSetMethod() { return setter; }
        public virtual MethodInfo SetMethod { get { return setter; } }
        public virtual MethodInfo GetSetMethod(bool nonPublic) { return setter != null && setter.IsPublic ? getter : null; }

        /// <summary>
        /// this is not supported and always returns an empty array.
        /// </summary>
        [NotImplemented]
        public ParameterInfo[] GetIndexParameters()
        {
            return EmptyParameterInfo;
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
                        propertyType = GenericsReflection.GetMemberType(getter.ReturnType, DeclaringType, getter.JavaMethod);
                    }
                    else if (setter != null)
                    {
                        var paramType = setter.JavaMethod.ParameterTypes.Last();
                        var genericInfo = (IGenericDefinition)setter.JavaMethod.ParameterAnnotations
                                                                .Last()
                                                                .FirstOrDefault(x => x.AnnotationType() == typeof (IGenericDefinition));
                        
                        if (genericInfo != null)
                        {
                            propertyType = GenericsReflection.ToGenericInstanceType(paramType, DeclaringType, genericInfo);
                        }
                        else
                        {
                            propertyType = paramType;
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
            if (index != null && index.Length > 0)
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
            if(index != null && index.Length > 0)
                throw new ArgumentException("index");
            if (setter == null)
                throw new InvalidOperationException("property has no setter");

            value = ConvertParameterIfRequired(PropertyType, value);

            setter.Invoke(instance, new [] {value});
        }

        /// <summary>
        /// Sets a value of the property for a given instance.
        /// </summary>
        public void SetValue(object instance, object value)
        {
            if (setter == null)
                throw new ArgumentException("property has no setter");

            value = ConvertParameterIfRequired(PropertyType, value);
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
            return DeclaringType.Name + " " + Name;
        }

        /// <summary>
        /// Gets all attributes
        /// </summary>
        IAttributes IAttributesProvider.Attributes()
        {
            return new AttributesWrapper(attributes);
        }

        protected bool Equals(PropertyInfo other)
        {
            return declaringType == other.declaringType && Equals(name, other.name);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((PropertyInfo)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (declaringType.GetHashCode() * 397) ^ (name != null ? name.GetHashCode() : 0);
            }
        }
    }
}

