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

using Dot42;
using Java.Lang.Reflect;

namespace System.Reflection
{
    [Include(TypeCondition = typeof(MulticastDelegate))]
    public class MethodInfo : MethodBase
    {
        private readonly Method _method;
        private readonly Type _declaringType;
        private readonly string _explicitInterfacePrefixIfAny;
        private string _name;
        public Method JavaMethod { get { return _method; } }

        public MethodInfo(Method method, Type declaringType, string explicitInterfacePrefixIfAny=null) : base(method)
        {
            _method = method;
            _declaringType = declaringType;
            _explicitInterfacePrefixIfAny = explicitInterfacePrefixIfAny;
        }

        public override MemberTypes MemberType { get {return MemberTypes.Method; } }
        public override Type DeclaringType { get { return _declaringType; } }

        protected override int Modifiers { get { return _method.Modifiers; } }

        protected override Type[] JavaGetParameterTypes()
        {
            return _method.ParameterTypes;
        }

        public override string Name
        {
            get
            {
                if (_name != null) return _name;
                var name = _method.Name;
                
                // remove possible explicit interface implementation prefix.
                if (_explicitInterfacePrefixIfAny != null && name.StartsWith(_explicitInterfacePrefixIfAny))
                {
                    name = name.Substring(_explicitInterfacePrefixIfAny.Length);
                }

                // remove any compiler generated parts of the name.
                var compilerGenIdx = name.IndexOf("$");
                if (compilerGenIdx != -1)
                    name = name.Substring(0, compilerGenIdx);

                //Console.WriteLine("{1}: {2}: {3}: {0}", DeclaringType.FullName, name, _explicitInterfacePrefixIfAny, _method.Name);

                return _name = name;
            }
        }

        public override bool ContainsGenericParameters { get { return JavaMethod.GenericParameterTypes.Length > 0; } }

        public Type ReturnType { get { return _method.ReturnType; } }

        public MethodInfo GetBaseDefinition()
        {
            var b = _method.DeclaringClass;
            if (b == this.DeclaringType) return this;
            return b.GetMethod(_method.Name, _method.ParameterTypes);
        }

        public override object Invoke(object instance, object[] args)
        {
            // .NET doesn't have accessibility semantics
            if (!_method.IsAccessible) _method.IsAccessible = true;

            return _method.Invoke(instance, args);
        }

        public override string ToString()
        {
            return _method.DeclaringClass.JavaGetName() + "::" + _method.Name;
        }
    }
}

