// Copyright (C) 2014 dot42
//
// Original filename: IncludeAttribute.cs
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
    /// Indicates that that element to what this attribute is attached should be included in the APK.
    /// </summary>
    [AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface | AttributeTargets.Method | AttributeTargets.Constructor | AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = true)]
    [Ignore]
    public sealed class IncludeAttribute : ApplicationRootAttribute
    {
        /// <summary>
        /// When this property is set, the element to what this attribute attached is only included if the type set in this property
        /// is included.
        /// </summary>
        public Type TypeCondition { get; set; }

        /// <summary>
        /// When this property is set, all types that are instance of the type set in this property are included in the resulting APK.
        /// This property can only be used when this attribute is attached to an assembly.
        /// </summary>
        public Type InstanceOfCondition { get; set; }

        /// <summary>
        /// Include the given type in the resulting APK.
        /// This property can only be used when this attribute is attached to an assembly.
        /// </summary>
        public Type Type { get; set; }

        /// <summary>
        /// If set, all members of the type to which this attribute is attached will be included also.
        /// </summary>
        public bool ApplyToMembers { get; set; }
    }
}

