// Copyright (C) 2014 dot42
//
// Original filename: PermissionAttribute.cs
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
    /// Used to specify manifest information about the security permission defined in this application 
    /// (and can be used to limit access to components of this and other applications).
    /// This attribute is not required.
    /// </summary>
    [AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
    [Ignore]
    public sealed class PermissionAttribute : Attribute
    {
        /// <summary>
        /// Default ctor
        /// </summary>
        /// <param name="name">Name of the permission. The name must be unique, so it should follow package style scoping. E.g. "com.example.myproject.MY_ACTION".</param>
        public PermissionAttribute(string name)
        {
            Name = name;
        }

        /// <summary>
        /// Name of the permission.
        /// The name must be unique, so it should follow package style scoping. E.g. "com.example.myproject.MY_ACTION".
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// User readable label of the permission.
        /// This should be set as a reference to a string resource, but it may be a literal string.
        /// </summary>
        public string Label { get; set; }

        /// <summary>
        /// User readable description of the permission (longer than the <see cref="Label"/>).
        /// The value must be a reference to a string resource.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Name of a drawable resource that holds the icon for this permission.
        /// </summary>
        public string Icon { get; set; }

        /// <summary>
        /// Assigned this permission to a group. 
        /// The name of the group must be declared with a <see cref="PermissionGroupAttribute"/> in this or another application.
        /// </summary>
        public string PermissionGroup { get; set; }

        /// <summary>
        /// Characterizes the potential risk implied in the permission.
        /// </summary>
        public ProtectionLevels ProtectionLevel { get; set; }
    }
}

