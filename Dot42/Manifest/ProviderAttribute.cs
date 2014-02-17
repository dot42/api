// Copyright (C) 2014 dot42
//
// Original filename: ProviderAttribute.cs
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
    /// Used to specify manifest information about Android activities.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, Inherited = false)]
    [Ignore]
    public sealed class ProviderAttribute : ApplicationRootAttribute
    {
        /// <summary>
        /// Default ctor
        /// </summary>
        public ProviderAttribute()
        {
            Enabled = true;
        }

        /// <summary>
        /// A list of one or more URI authorities that identify data offered by the content provider.
        /// </summary>
        public string[] Authorities { get; set; }

        /// <summary>
        /// Can this content provider be instantiated by the system?
        /// True by default.
        /// </summary>
        public bool Enabled { get; set; }

        /// <summary>
        /// Can this content provider be launched by components of other applications?
        /// False by default.
        /// </summary>
        public bool Exported { get; set; }

        /// <summary>
        /// Whether or not those who ordinarily would not have permission to access the content provider's data can be granted permission to do so.
        /// </summary>
        public bool GrantUriPermissions { get; set; }

        /// <summary>
        /// Name of a drawable resource that holds the icon for this content provider.
        /// </summary>
        public string Icon { get; set; }

        /// <summary>
        /// User readable label of the content provider.
        /// This should be set as a reference to a string resource, but it may be a literal string.
        /// </summary>
        public bool Label { get; set; }

        /// <summary>
        /// If set, this content provider can be launched into the process of the component that started it.
        /// The default is false.
        /// </summary>
        public bool MultiProcess { get; set; }

        /// <summary>
        /// The permission this content provider must have to read or write data.
        /// </summary>
        public string Permission { get; set; }

        /// <summary>
        /// The name of the process in which this content provider is run.
        /// </summary>
        public string Process { get; set; }

        /// <summary>
        /// The permission this content provider must have to query data.
        /// </summary>
        public string ReadPermission { get; set; }

        /// <summary>
        /// Whether or not the data under the content provider's control is to be synchronized with data on a server.
        /// </summary>
        public bool Syncable { get; set; }

        /// <summary>
        /// The permission this content provider must have to change data.
        /// </summary>
        public string WritePermission { get; set; }
    }
}

