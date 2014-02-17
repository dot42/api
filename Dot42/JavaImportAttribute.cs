// Copyright (C) 2014 dot42
//
// Original filename: JavaImportAttribute.cs
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
using System;

namespace Dot42
{
    /// <summary>
    /// Indicates that a type/member is imported from Java and all Java code is to be compiled into the APK.
    /// </summary>
    [AttributeUsage(AttributeTargets.All)]
    [Ignore]
    public sealed class JavaImportAttribute : Attribute
    {
		public JavaImportAttribute(string javaClassName) { }
		public JavaImportAttribute(string memberName, string typeName) { }
        public JavaImportAttribute(string javaClassName, string memberName, string typeName) { }

        /// <summary>
        /// If set, this class is ignored when importing java code.
        /// This attribute can only be used on attributes attached to a type with a single ctor argument.
        /// </summary>
        public bool IgnoreFromJava { get; set; }

        /// <summary>
        /// If set, this this priority is used to order classes when importing java code.
        /// Low value means earlier in the list.
        /// </summary>
        public int Priority { get; set; }

        /// <summary>
        /// Access flags of the original java member.
        /// </summary>
        public int AccessFlags { get; set; }

        /// <summary>
        /// Java signature containing generics info.
        /// </summary>
        public string Signature { get; set; }
    }
}

