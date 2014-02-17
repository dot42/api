// Copyright (C) 2014 dot42
//
// Original filename: ApplicationAttribute.cs
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
    /// Used to specify manifest information about the Android application.
    /// You can either add this attribute to the assembly, or to a custom Application type.
    /// </summary>
    [AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class)]
    [Ignore]
    public sealed class ApplicationAttribute : ApplicationRootAttribute
    {
        /// <summary>
        /// Default ctor
        /// </summary>
        /// <param name="name">Application name</param>
        public ApplicationAttribute(string name)
        {
            Name = name;
            HardwareAccelerated = true;
            KillAfterRestore = true;
            Enabled = true;
        }

        /// <summary>
        /// Name of the application
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// User readable (longer) description of the application.
        /// The value must be a reference to a string resource.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Name of a drawable resource that holds the icon for this application.
        /// </summary>
        public string Icon { get; set; }

        /// <summary>
        /// If set, activities that this application defines can move from the task that started them to the task they have an affinity 
        /// for when that task is brought to the front.
        /// </summary>
        public bool AllowTaskReparenting { get; set; }

        /// <summary>
        /// The class that implements the application's backup agent.
        /// This must be a subclass of <see cref="Android.App.Backup.BackupAgent"/>
        /// </summary>
        public Type BackupAgent { get; set; }

        /// <summary>
        /// When set to true, the app can be debugged even in a device running in user mode.
        /// </summary>
        public bool Debuggable { get; set; }

        /// <summary>
        /// When set to true, Android can instantiate components of the application.
        /// </summary>
        public bool Enabled { get; set; }

        /// <summary>
        /// Is set, hardward accelerated rendering is disabled on platforms that support it.
        /// </summary>
        /// <remarks>
        /// This property is available as of version 3.0 (Honeycomb)
        /// </remarks>
        [AndroidVersion(11)]
        public bool HardwareAccelerated { get; set; }

        /// <summary>
        /// If set, this application should be terminated after its settings have been restored during a full-system restore operation.
        /// </summary>
        public bool KillAfterRestore { get; set; }

        /// <summary>
        /// User readable label for the application as a whole and the default label for the application's components.
        /// This should be set as a reference to a string resource, but it may be a literal string.
        /// </summary>
        public string Label { get; set; }

        /// <summary>
        /// Is set, this application will use a large Dalvik heap.
        /// </summary>
        public bool LargeHeap { get; set; }

        /// <summary>
        /// Name of a drawable resource that holds the logo for this application which is also the default icon for activities.
        /// </summary>
        public string Logo { get; set; }

        /// <summary>
        /// Activity class that the system can launch to let users manage the memory occupied by the application.
        /// This class should also have an <see cref="ActivityAttribute"/>.
        /// </summary>
        public Type ManageSpaceActivity { get; set; }

        /// <summary>
        /// If set to true, the application should remain running at all times.
        /// Application should normally not set this flag.
        /// </summary>
        public bool Persistent { get; set; }

        /// <summary>
        /// The name of the process where all components of the application should run. Each component can override this with it's own
        /// Process setting.
        /// </summary>
        public string Process { get; set; }

        /// <summary>
        /// If set, this application is prepared to attempt a restore of any backup data set even if the backup was stored by a newer version of
        /// the application.
        /// </summary>
        public bool RestoreAnyVersion { get; set; }

        /// <summary>
        /// Affinity name that applicaties to all activities in the application except those that specify their own TaskAffinity.
        /// </summary>
        public string TaskAffinity { get; set; }

        /// <summary>
        /// Name of a style resource defining the overall theme of this application.
        /// </summary>
        public string Theme { get; set; }

        /// <summary>
        /// Extra options for an activities UI.
        /// </summary>
        /// <remarks>
        /// This property is available as of version 4.0 (Ice Cream Sandwich)
        /// </remarks>
        [AndroidVersion(14)]
        public UIOptions UIOptions { get; set; }
    }
}

