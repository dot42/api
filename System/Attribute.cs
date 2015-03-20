// Copyright (C) 2014 dot42
//
// Original filename: Attribute.cs
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

using System.Linq;
using System.Reflection;
using Dot42;

namespace System
{
    [AttributeUsageAttribute(AttributeTargets.All, Inherited = true, AllowMultiple = false)]
	public class Attribute
	{
        /// <summary>
        /// will always return an empty array for now.
        /// </summary>
        public static Attribute[] GetCustomAttributes(Assembly element)
        {
            return new Attribute[0];
        }
        
        /// <summary>
        /// will always return an empty array for now.
        /// </summary>
        public static Attribute[] GetCustomAttributes(Assembly element, Type t)
        {
            return new Attribute[0];
        }

        public static Attribute[] GetCustomAttributes(MemberInfo member, bool inherit)
        {
            return member.GetCustomAttributes(inherit).Select(x => (Attribute) x);
        }

        public static Attribute[] GetCustomAttributes(MemberInfo member, Type t, bool inherit)
        {
            return member.GetCustomAttributes(t, inherit).Select(x => (Attribute)x);
        }

        public static Attribute[] GetCustomAttributes(ParameterInfo param, bool inherit)
        {
            return param.GetCustomAttributes(inherit).Select(x => (Attribute)x);
        }

        public static Attribute[] GetCustomAttributes(ParameterInfo param, Type t, bool inherit)
        {
            return param.GetCustomAttributes(t, inherit).Select(x => (Attribute)x);
        }

	}
}

