// Copyright (C) 2014 dot42
//
// Original filename: UsesLibraryAttribute.cs
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
    /// Used to specify manifest information about used libraries.
    /// </summary>
    [AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
    [Ignore]
    public sealed class UsesLibraryAttribute : Attribute
    {
        /// <summary>
        /// Default ctor
        /// </summary>
        /// <param name="name">Name of the library</param>
        public UsesLibraryAttribute(string name)
            : this(name, true)
        {
        }

        /// <summary>
        /// Default ctor
        /// </summary>
        /// <param name="name">Name of the library</param>
        /// <param name="required">Is the library indicated by name required?</param>
        public UsesLibraryAttribute(string name, bool required)
        {
            Name = name;
            Required = required;
        }

        /// <summary>
        /// Name of the library
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Is the library indicated by <see cref="Name"/> required.
        /// If True, the application will not function without it.
        /// If False, the application can use the library, but will function without it.
        /// </summary>
        /// <remarks>The default value is True</remarks>
        public bool Required { get; set; }
    }
}

