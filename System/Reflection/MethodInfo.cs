// Copyright (C) 2014 dot42
//
// Original filename: MethodInfo.cs
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

using Java.Lang.Reflect;

namespace System.Reflection
{
    public class MethodInfo : MethodBase
    {
        private readonly JavaMethod _method;
        public JavaMethod JavaMethod { get { return _method; } }


        public MethodInfo(JavaMethod method) : base(method)
        {
            _method = method;
        }

        //public override MemberTypes MemberType { get {return MemberTypes.Method; } }
        public override Type DeclaringType { get { return _method.DeclaringClass; } }
        public override string Name { get { return _method.Name; } }

        public override bool ContainsGenericParameters { get { return JavaMethod.GenericParameterTypes.Length > 0; } }

        public override ParameterInfo[] GetParameters()
        {
            var types = JavaMethod.GetParameterTypes();
            ParameterInfo[] ret = new ParameterInfo[types.Length];

            for (int idx = 0; idx < types.Length; ++idx)
            {
                // java doesn't support argument names.
                ret[idx] = new ParameterInfo(this, "arg" + (idx++), types[idx], idx);
            }
            return ret;
        }

        /// <summary>
        /// Is this an abstract method?
        /// </summary>
        public override bool IsAbstract { get { return Modifier.IsAbstract(_method.GetModifiers()); } }

        /// <summary>
        /// Is this an final method?
        /// </summary>
        public override bool IsFinal { get { return Modifier.IsFinal(_method.GetModifiers()); } }

        /// <summary>
        /// Is this an private method?
        /// </summary>
        public override bool IsPrivate { get { return Modifier.IsPrivate(_method.GetModifiers()); } }

        /// <summary>
        /// Is this an public method?
        /// </summary>
        public override bool IsPublic { get { return Modifier.IsPublic(_method.GetModifiers()); } }

        /// <summary>
        /// Is this a static method?
        /// </summary>
        public override bool IsStatic { get { return Modifier.IsStatic(_method.GetModifiers()); } }

        /// <summary>
        /// Is this an virtual method?
        /// </summary>
        public override bool IsVirtual { get { return !Modifier.IsFinal(_method.GetModifiers()); } }

        public Type ReturnType { get { return _method.ReturnType; } }

        //public MethodInfo GetBaseDefinition()
        //{
        //    if (this.IsAbstract) return this;
        //    if (this.IsStatic) return this;
        //    if (this.IsVirtual) return this;
        //}

        public override object Invoke(object instance, params object[] args)
        {
            return _method.Invoke(instance, args);
        }
    }
}

