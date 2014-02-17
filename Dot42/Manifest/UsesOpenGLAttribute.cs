// Copyright (C) 2014 dot42
//
// Original filename: UsesOpenGLAttribute.cs
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
    /// Used to specify manifest information about the version of the Open GL ES system that is required.
    /// </summary>
    [AttributeUsage(AttributeTargets.Assembly)]
    [Ignore]
    public sealed class UsesOpenGLAttribute : Attribute
    {
        /// <summary>
        /// Default ctor
        /// </summary>
        /// <param name="name">Required version. The higher 16 bits represent the major number and the lower 16 bits represent the minor number. For example, to specify OpenGL ES version 2.0, you would set the value as "0x00020000". To specify OpenGL ES 2.1, if/when such a version were made available, you would set the value as "0x00020001". </param>
        public UsesOpenGLAttribute(int version)
        {
            Version = version;
        }

        /// <summary>
        /// Required version. The higher 16 bits represent the major number and the lower 16 bits represent the minor number. For example, to specify OpenGL ES version 2.0, you would set the value as "0x00020000". To specify OpenGL ES 2.1, if/when such a version were made available, you would set the value as "0x00020001".
        /// </summary>
        public int Version { get; private set; }
    }
}

