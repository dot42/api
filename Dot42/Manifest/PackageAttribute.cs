// Copyright (C) 2014 dot42
//
// Original filename: PackageAttribute.cs
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
    /// Used to specify manifest information about the package.
    /// This attribute is not required.
    /// </summary>
    [AttributeUsage(AttributeTargets.Assembly)]
    [Ignore]
    public sealed class PackageAttribute : Attribute
    {
        /// <summary>
        /// Name of a Linux user ID that will be shared with other applications. Note that the other application must be signed with the same certificate.
        /// </summary>
        public string SharedUserId { get; set; }

        /// <summary>
        /// User readable label for the shared user ID.
        /// This should be set as a reference to a string resource.
        /// </summary>
        public string SharedUserLabel { get; set; }

        /// <summary>
        /// An internal version number. The meaning of value is unspecified, as long as each successive version has a higher number.
        /// If you do not provide a version code, dot42 will used the major version of the assembly's version.
        /// </summary>
        public int VersionCode { get; set; }

        /// <summary>
        /// The version number showns to users.
        /// This can be set as a reference to a string resource or as a literal string.
        /// If you do not provide a version name, dot42 will used the assembly's version.
        /// </summary>
        public string VersionName { get; set; }

        /// <summary>
        /// Default installation location for the application.
        /// </summary>
        public InstallLocations InstallLocation { get; set; }
    }
}

