// Copyright (C) 2014 dot42
//
// Original filename: InstrumentationAttribute.cs
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
    /// Used to specify manifest information about an Intrumentation class that enables you to monitor an application's interaction with the system.
    /// </summary>
    [AttributeUsage(AttributeTargets.Assembly)]
    [Ignore]
    public sealed class InstrumentationAttribute : Attribute
    {
        /// <summary>
        /// Name of the Instrumentation subclass.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// User readable label for the Instrumentation.
        /// </summary>
        public string Label { get; set; }

        /// <summary>
        /// The application that the Instrumentation object will run against.
        /// </summary>
        public string TargetPackage { get; set; }

        /// <summary>
        /// Should the Instrumentation class run as functional test?
        /// </summary>
        public bool FunctionalTest { get; set; }

        /// <summary>
        /// Will the Instrumentation object turn profiling on and off?
        /// </summary>
        public bool HandleProfiling { get; set; }
    }
}

