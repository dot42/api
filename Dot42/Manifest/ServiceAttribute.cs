// Copyright (C) 2014 dot42
//
// Original filename: ServiceAttribute.cs
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
    /// Used to specify manifest information about Android services provided by this application.
    /// This attribute should be attached to sub classes of <see cref="Android.App.Service"/>.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, Inherited = false)]
    [Ignore]
    public sealed class ServiceAttribute : ApplicationRootAttribute
    {
        /// <summary>
        /// Default ctor
        /// </summary>
        public ServiceAttribute()
        {
            Enabled = true;
        }

        /// <summary>
        /// User readable label of the service.
        /// </summary>
        public string Label { get; set; }

        /// <summary>
        /// Name of a drawable resource that holds the icon for this service.
        /// </summary>
        public string Icon { get; set; }

        /// <summary>
        /// If set to true, the service will runder in a special process that is isolated from the rest of the system. The only communication with it is
        /// through the Service API.
        /// </summary>
        public bool IsolatedProcess { get; set; }

        /// <summary>
        /// Can this service be instantiated by the system?
        /// True by default.
        /// </summary>
        public bool Enabled { get; set; }

        /// <summary>
        /// If set, components from other application can invoke and/or interact with this service.
        /// If there are intent filters specified for this service, the default value is true, otherwise the default value is false.
        /// </summary>
        public bool Exported { get; set; }

        /// <summary>
        /// The permission an entity must have to launch this service or bind to it.
        /// </summary>
        public string Permission { get; set; }

        /// <summary>
        /// The name of the process in which this service is run.
        /// </summary>
        public string Process { get; set; }

        /// <summary>
        /// If set to true, this service will be automatically stopped when the user removes a task rooted in an activity owned by the application. 
        /// The default is false.
        /// </summary>
        /// <remarks>
        /// This property is available as of version 4.0 (Ice Cream Sandwich)
        /// </remarks>
        [AndroidVersion(14)]
        public bool StopWithTask { get; set; }
    }
}

