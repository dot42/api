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
    partial class MethodInfo 
    {
        [Dot42.DexImport("getTypeParameters", "()[Ljava/lang/reflect/TypeVariable;")]
        global::Java.Lang.Reflect.ITypeVariable<object>[] IGenericDeclaration.GetTypeParameters()
        {
            return default(global::Java.Lang.Reflect.ITypeVariable<object>[]);
        }

        public Type DeclaringType
        {
            [Dot42.DexImport("getDeclaringClass", "()Ljava/lang/Class;")]
            get { return GetDeclaringClass(); }
        }

        /// <summary>
        /// Is this an abstract method?
        /// </summary>
        public bool IsAbstract { get { return Modifier.IsAbstract(GetModifiers()); } }

        /// <summary>
        /// Is this an final method?
        /// </summary>
        public bool IsFinal { get { return Modifier.IsFinal(GetModifiers()); } }

        /// <summary>
        /// Is this an private method?
        /// </summary>
        public bool IsPrivate { get { return Modifier.IsPrivate(GetModifiers()); } }

        /// <summary>
        /// Is this an public method?
        /// </summary>
        public bool IsPublic { get { return Modifier.IsPublic(GetModifiers()); } }

        /// <summary>
        /// Is this a static method?
        /// </summary>
        public bool IsStatic { get { return Modifier.IsStatic(GetModifiers()); } }

        /// <summary>
        /// Is this an virtual method?
        /// </summary>
        public bool IsVirtual { get { return !Modifier.IsFinal(GetModifiers()); } }

        public bool ContainsGenericParameters { get { return GenericParameterTypes.Length > 0; } }

        public ParameterInfo[] GetParameters()
        {
            var types = GetParameterTypes();
            ParameterInfo[] ret = new ParameterInfo[types.Length];

            for (int idx = 0; idx < types.Length; ++idx)
                ret[idx] = new ParameterInfo(this, "arg" + (idx++), types[idx], idx);
            return ret;
        }

        //public MethodInfo GetBaseDefinition()
        //{
        //    if (this.IsAbstract) return this;
        //    if (this.IsStatic) return this;
        //    if (this.IsVirtual) return this;
        //}

        public static implicit operator MethodBase(MethodInfo i) 
        {
            return new MethodBase(i);
        }
    }
}

