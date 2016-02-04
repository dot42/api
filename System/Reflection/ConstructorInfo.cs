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

using Dot42.Internal;
using Java.Lang.Reflect;

namespace System.Reflection
{
    public class ConstructorInfo : MethodBase
    {
        private readonly Constructor _ctor;

        public Constructor JavaConstructor { get { return _ctor; } }

        public ConstructorInfo(Constructor ctor) : base(ctor)
        {
            _ctor = ctor;
        }

        public override Type DeclaringType { get { return _ctor.DeclaringClass; } }
        public override string Name { get { return _ctor.Name; } }
        public override MemberTypes MemberType { get { return MemberTypes.Constructor; } }

        public override bool ContainsGenericParameters { get { return _ctor.GenericParameterTypes.Length > 0; } }

        protected override int Modifiers { get { return _ctor.Modifiers; } }

        protected override Type[] JavaGetParameterTypes()
        {
            return _ctor.ParameterTypes;
        }

        public override string ToString()
        {
            return _ctor.DeclaringClass.JavaGetName() + "::" + _ctor.Name;
        }

        public virtual object Invoke(object[] args)
        {
            // .NET doesn't have accessibility semantics
            if (!_ctor.IsAccessible) _ctor.IsAccessible = true;

            return _ctor.NewInstance(args);
        }

        public override object Invoke(object instance, object[] args)
        {
            if (instance != null)
                throw new InvalidOperationException("instance must be null");
            return Invoke(args);
        }
    }
}

