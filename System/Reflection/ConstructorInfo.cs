// Copyright (C) 2014 dot42
//
// Original filename: ConstructorInfo.cs
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
    public class ConstructorInfo : MethodBase
    {
        private readonly JavaConstructor _ctor;

        public JavaConstructor JavaConstructor { get { return _ctor; } }

        public ConstructorInfo(JavaConstructor ctor) : base(ctor)
        {
            _ctor = ctor;
        }

        //public override MemberTypes MemberType { get { return MemberTypes.Constructor; } }
        public override Type DeclaringType { get { return _ctor.DeclaringClass; } }
        public override string Name { get { return _ctor.Name; } }

        /// <summary>
        /// Is this an abstract method?
        /// </summary>
        public override bool IsAbstract { get { return Modifier.IsAbstract(_ctor.GetModifiers()); } }

        /// <summary>
        /// Is this an final method?
        /// </summary>
        public override bool IsFinal { get { return Modifier.IsFinal(_ctor.GetModifiers()); } }

        /// <summary>
        /// Is this an private method?
        /// </summary>
        public override bool IsPrivate { get { return Modifier.IsPrivate(_ctor.GetModifiers()); } }

        /// <summary>
        /// Is this an public method?
        /// </summary>
        public override bool IsPublic { get { return Modifier.IsPublic(_ctor.GetModifiers()); } }

        /// <summary>
        /// Is this a static method?
        /// </summary>
        public override bool IsStatic { get { return Modifier.IsStatic(_ctor.GetModifiers()); } }

        /// <summary>
        /// Is this an virtual method?
        /// </summary>
        public override bool IsVirtual { get { return !Modifier.IsFinal(_ctor.GetModifiers()); } }

        public override bool ContainsGenericParameters { get { return _ctor.GenericParameterTypes.Length > 0; } }

        public override ParameterInfo[] GetParameters()
        {
            var types = _ctor.GetParameterTypes();
            var length = types.Length;

            ParameterInfo[] ret = new ParameterInfo[length];

            // java doesn't support argument names.
            for (int idx = 0; idx < length; ++idx)
                ret[idx] = new ParameterInfo(this, "arg" + idx, types[idx], idx);
            return ret;
        }

        public object Invoke(params object[] args)
        {
            return _ctor.NewInstance(args);
        }

        public override object Invoke(object instance, params object[] args)
        {
            if (instance != null)
                throw new InvalidOperationException("instance must be null");
            return Invoke(args);
        }

    }
}

