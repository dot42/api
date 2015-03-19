// Copyright (C) 2014 dot42
//
// Original filename: FieldInfo.cs
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
    partial class FieldInfo
    {
        /// <summary>
        /// Gets the type that declares this member.
        /// </summary>
        public override Type DeclaringType
        {
            [Dot42.DexImport("getDeclaringClass", "()Ljava/lang/Class;")]
            get { return GetDeclaringClass(); }
        }

        public override string Name { get { return GetName(); } }

        public Type FieldType { get { return this.GetType(); } }

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

        /// <summary>
        /// returns false, Literals are not supported by Java (i think)
        /// </summary>
        public bool IsLiteral { get { return false; } }

        /// <summary>
        /// returns IsFinal
        /// </summary>
        public bool IsInitOnly { get { return IsFinal; } }

        public void SetValue(object instance, object value)
        {
            Set(instance, value);
        }

    }
}

