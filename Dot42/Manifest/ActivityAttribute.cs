// Copyright (C) 2014 dot42
//
// Original filename: ActivityAttribute.cs
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
    public sealed class ActivityAttribute : ApplicationRootAttribute
    {
        private bool _visibleInLauncher;

        /// <summary>
        /// Default ctor
        /// </summary>
        public ActivityAttribute()
        {
            Enabled = true;
            VisibleInLauncher = false;
            Exported = true;
        }

        /// <summary>
        /// User readable label of the activity.
        /// This should be set as a reference to a string resource, but it may be a literal string.
        /// </summary>
        public string Label { get; set; }

        /// <summary>
        /// Name of a drawable resource that holds the icon for this activity.
        /// </summary>
        public string Icon { get; set; }

        /// <summary>
        /// Is this activity visible in the launcher's list of activities?
        /// False by default.
        /// </summary>
        public bool VisibleInLauncher { get { return _visibleInLauncher ||MainLauncher; } set { _visibleInLauncher = value; } }

        /// <summary>
        /// Is this activity the main launcher for the application?
        /// </summary>
        public bool MainLauncher { get; set; }

        /// <summary>
        /// If set, this activity can move from the task that started it to the task it has an affinity for when that task is brought to the front.
        /// </summary>
        public bool AllowTaskReparenting { get; set; }

        /// <summary>
        /// If set, the system will maintain the state of the task that the activity is in.
        /// The default is false.
        /// </summary>
        public bool AlwaysRetainTaskState { get; set; }

        /// <summary>
        /// If set, all activities except the root activity will be removed from the task whenever it is re-launched from the home screen.
        /// </summary>
        public bool ClearTaskOnLaunch { get; set; }

        /// <summary>
        /// List of configuration changes that the activity will handle itself.
        /// </summary>
        public ConfigChanges ConfigChanges { get; set; }

        /// <summary>
        /// Can this activity be instantiated by the system?
        /// True by default.
        /// </summary>
        public bool Enabled { get; set; }

        /// <summary>
        /// If set, this activity should be excluded from the recent applications list.
        /// False by default.
        /// </summary>
        public bool ExcludeFromRecents { get; set; }

        /// <summary>
        /// Can this activity be launched by components of other applications?
        /// True by default.
        /// </summary>
        public bool Exported { get; set; }

        /// <summary>
        /// If set, any existing instance of the activity will be shut down when the user re-launches the task.
        /// </summary>
        public bool FinishOnTaskLaunch { get; set; }

        /// <summary>
        /// Is set, hardward accelerated rendering is disabled on platforms that support it.
        /// </summary>
        public bool HardwareAccelerated { get; set; }

        /// <summary>
        /// How should this activity be launched.
        /// </summary>
        public LaunchModes LaunchMode { get; set; }

        /// <summary>
        /// If set, this activity can be launched into the process of the component that started it.
        /// The default is false.
        /// </summary>
        public bool MultiProcess { get; set; }

        /// <summary>
        /// If set, the activity should be removed from the activity stack and finished when the users navigates away from it.
        /// </summary>
        public bool NoHistory { get; set; }

        /// <summary>
        /// The logical parent of this activity.
        /// This is the activity that should be launched when the user presses the Up button in the action bar.
        /// </summary>
        /// <remarks>
        /// This property is available as of version 4.1 (Jelly Bean)
        /// </remarks>
        [AndroidVersion(16)]
        public Type ParentActivity { get; set; }

        /// <summary>
        /// The permission an entity must have to launch this activity or get to respond to an intent.
        /// </summary>
        public string Permission { get; set; }

        /// <summary>
        /// The name of the process in which this activity is run.
        /// </summary>
        public string Process { get; set; }

        /// <summary>
        /// The orientation of the activity's display on the device.
        /// </summary>
        public ScreenOrientations ScreenOrientation { get; set; }

        /// <summary>
        /// If set, a new instance of this activity can be started without a reference to a previous state.
        /// The default value is false.
        /// </summary>
        public bool StateNotNeeded { get; set; }

        /// <summary>
        /// The task that the activity has an affinity for. 
        /// </summary>
        public string TaskAffinity { get; set; }

        /// <summary>
        /// Name of a style resource defining the overall theme of this activity.
		/// If this property is not set, the default theme of the application is used.
        /// </summary>
        public string Theme { get; set; }

        /// <summary>
        /// Extra options for the activity's UI.
        /// </summary>
        /// /// <remarks>
        /// This property is available as of version 4.0 (Ice Cream Sandwich)
        /// </remarks>
        [AndroidVersion(14)]
        public UIOptions UIOptions { get; set; }

        /// <summary>
        /// How the activities main window interacts with the window containing the soft keyboard.
        /// </summary>
        public WindowSoftInputModes WindowSoftInputMode { get; set; }
    }
}

