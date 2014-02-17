// Copyright (C) 2014 dot42
//
// Original filename: PermissionGroupAttribute.cs
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
    /// Used to specify manifest information permission groups.
    /// A permission group declares a name for a logical grouping of related permissions.
    /// This attribute is not required.
    /// </summary>
    /// <seealso cref="PermissionAttribute"/>
    [AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
    [Ignore]
    public sealed class PermissionGroupAttribute : Attribute
    {
        /// <summary>
        /// Default ctor
        /// </summary>
        /// <param name="name">Name of the permission group.</param>
        public PermissionGroupAttribute(string name)
        {
            Name = name;
        }

        /// <summary>
        /// Name of the permission group.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// User readable label of the permission.
        /// This should be set as a reference to a string resource, but it may be a literal string.
        /// </summary>
        public string Label { get; set; }

        /// <summary>
        /// User readable description of the permission group (longer than the <see cref="Label"/>).
        /// The value must be a reference to a string resource.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Name of a drawable resource that holds the icon for this permission group.
        /// </summary>
        public string Icon { get; set; }
    }
}

