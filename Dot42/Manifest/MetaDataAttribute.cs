// Copyright (C) 2014 dot42
//
// Original filename: MetaDataAttribute.cs
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

namespace Dot42.Manifest
{
    /// <summary>
    /// A name-value pair for an item of additional, arbitrary data that can be supplied to the parent component.
    /// </summary>
    [AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class, Inherited = false, AllowMultiple = true)]
    [Ignore]
    public sealed class MetaDataAttribute : Attribute
    {
        /// <summary>
        /// A unique name for the item. To ensure that the name is unique, use a Java-style naming convention — for example, "com.example.project.activity.fred".
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The value assigned to the item.
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// A reference to a resource. 
        /// </summary>
        public string Resource { get; set; }
    }
}

