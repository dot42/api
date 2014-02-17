// Copyright (C) 2014 dot42
//
// Original filename: IntentFilterAttribute.cs
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
    /// Used to specify manifest information about the types of intents an activity, service or broadcast receiver can respond to.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, Inherited = false)]
    [Ignore]
    public sealed class IntentFilterAttribute : Attribute
    {
        /// <summary>
        /// User readable label for the activity, service or broadcast receiver when that component is
        /// presented to the user as having a specific capability.
        /// </summary>
        public string Label { get; set; }

        /// <summary>
        /// Name of a drawable resource that holds the icon for the activity, service or broadcast receiver when that component is
        /// presented to the user as having a specific capability.
        /// </summary>
        public string Icon { get; set; }

        /// <summary>
        /// The priority that should be given to the activity or broadcast receiver wiuth regard to handling the intent.
        /// </summary>
        public int Priority { get; set; }

        /// <summary>
        /// Names of allowed intent actions.
        /// <see cref="Android.Content.Intent"/>.
        /// </summary>
        public string[] Actions { get; set; }

        /// <summary>
        /// Names of allowed intent categories.
        /// <see cref="Android.Content.Intent"/>.
        /// </summary>
        public string[] Categories { get; set; }
    }
}

