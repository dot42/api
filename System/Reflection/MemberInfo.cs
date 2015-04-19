// Copyright (C) 2014 dot42
//
// Original filename: MemberInfo.cs
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
using Dot42.Internal;
using Java.Lang.Reflect;

namespace System.Reflection
{
    public abstract class JavaMemberInfo : MemberInfo
    {
        protected readonly AccessibleObject Member;

        public JavaMemberInfo(AccessibleObject member)
        {
            Member = member;
        }

        public override object[] GetCustomAttributes(bool inherit)
        {
            return CustomAttributeProvider.GetCustomAttributes(Member, inherit);
        }

        public override object[] GetCustomAttributes(Type attributeType, bool inherit)
        {
            return CustomAttributeProvider.GetCustomAttributes(Member, attributeType, inherit);
        }

        public override bool IsDefined(Type attributeType, bool inherit)
        {
            return CustomAttributeProvider.IsDefined(Member, attributeType, inherit);
        }

        protected bool Equals(JavaMemberInfo other)
        {
            return Equals(Member, other.Member);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((JavaMemberInfo)obj);
        }

        public override int GetHashCode()
        {
            return (Member != null ? Member.GetHashCode() : 0);
        }
    }

    public abstract class MemberInfo : ICustomAttributeProvider
    {
        //public abstract MemberTypes MemberType { get; }
        public abstract Type DeclaringType { get; }
        public abstract string Name { get; }
        
        public abstract MemberTypes MemberType { get; }

        /// <summary>
        /// Returns an array of all attributes defined on this member.
        /// Returns an empty array if no attributes are defined on this member.
        /// </summary>
        /// <param name="inherit">If true, look in base classes for inherited custom attributes.</param>
        public abstract object[] GetCustomAttributes(bool inherit);

        /// <summary>
        /// Returns an array of all attributes defined on this member of the given attribute type.
        /// Returns an empty array if no attributes are defined on this member.
        /// </summary>
        /// <param name="inherit">If true, look in base classes for inherited custom attributes.</param>
        public abstract object[] GetCustomAttributes(Type attributeType, bool inherit);

        /// <summary>
        /// are one or more attributes of the given type defined on this member.
        /// </summary>
        /// <param name="attributeType">The type of the custom attribute</param>
        /// <param name="inherit">If true, look in base classes for inherited custom attributes.</param>
        public abstract bool IsDefined(Type attributeType, bool inherit);

        /// <summary>
        /// this methods performs required implicit conversion for parameters during 
        /// reflection.
        /// </summary>
        protected static object ConvertParameterIfRequired(Type targetType, object value)
        {
            if (targetType.IsEnum)
            {
                var valueType = value.JavaGetClass();
                if (valueType != targetType)
                {
                    value = Dot42.Internal.Enum.GetFromObject(targetType, value);
                }
            }
            else if (value == null && targetType.IsValueType)
            {
                if (targetType.IsPrimitive)
                {
                    // TODO: check if wee need to instantiate the correct type here 
                }
                value = Activator.CreateInstance(targetType);
            }

            // TODO: if targetType is a primitive, we might have to do implicit conversion
            return value;
        }
    }
}

