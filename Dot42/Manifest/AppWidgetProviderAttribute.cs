// Copyright (C) 2014 dot42
//
// Original filename: AppWidgetProviderAttribute.cs
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
    /// Declares the provider of an app-widget.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, Inherited = false)]
    [Ignore]
    public sealed class AppWidgetProviderAttribute : ApplicationRootAttribute
    {
        /// <summary>
        /// User readable label of the widget.
        /// This should be set as a reference to a string resource, but it may be a literal string.
        /// </summary>
        public string Label { get; set; }

        /// <summary>
        /// Minimum width needed for the widget.
        /// </summary>
        public string MinWidth { get; set; }

        /// <summary>
        /// Minimum height needed for the widget.
        /// </summary>
        public string MinHeight { get; set; }

        /// <summary>
        /// Defines how often the App Widget framework should request an update from the AppWidgetProvider by calling the OnUpdate callback method.
        /// This value is in milliseconds.
        /// </summary>
        public long UpdatePeriod { get; set; }

        /// <summary>
        /// Resource id of the layout to use for the widget.
        /// </summary>
        public string InitialLayout { get; set; }

        /// <summary>
        /// Resource id of a preview image of the widget.
        /// </summary>
        public string PreviewImage { get; set; }

        /// <summary>
        /// Activity type used to configure this widget.
        /// </summary>
        public Type ConfigureActivity { get; set; }

        /// <summary>
        /// Specifies the rules by which this widget can be resized. 
        /// </summary>
        public WidgetResizeModes ResizeMode { get; set; }

        /// <summary>
        /// Declares whether this widget can be displayed on the home screen, the lock screen (keyguard), or both.
        /// </summary>
        public WidgetCategories Category { get; set; }

        /// <summary>
        /// Resource id of the layout resource that defines the lock screen App Widget layout.
        /// </summary>
        public string InitialKeyguardLayout { get; set; }
    }
}

