// Copyright (C) 2014 dot42
//
// Original filename: SupportsScreensAttribute.cs
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
    /// Used to specify manifest information about the supported screens of an Android application.
    /// </summary>
    [AttributeUsage(AttributeTargets.Assembly)]
    [Ignore]
    public sealed class SupportsScreensAttribute : Attribute
    {
        /// <summary>
        /// Default ctor
        /// </summary>
        /// <param name="name">Application name</param>
        public SupportsScreensAttribute()
        {
            SmallScreens = true;
            NormalScreens = true;
            LargeScreens = true;
            XLargeScreens = true;
        }

        /// <summary>
        /// Does the application support smaller screen form factors?
        /// Defaults to true.
        /// </summary>
        public bool SmallScreens { get; set; }

        /// <summary>
        /// Does the application support normal screen form factors?
        /// Defaults to true.
        /// </summary>
        public bool NormalScreens { get; set; }

        /// <summary>
        /// Does the application support large screen form factors?
        /// Defaults to true.
        /// </summary>
        public bool LargeScreens { get; set; }

        /// <summary>
        /// Does the application support extra large screen form factors?
        /// Defaults to true.
        /// </summary>
        public bool XLargeScreens { get; set; }

        /// <summary>
        /// Specifies the minimum smallest width required.
        /// </summary>
        /// <remarks>
        /// This property is available as of version 3.2 (Honeycomb)
        /// </remarks>
        [AndroidVersion(13)]
        public int RequiresSmallestWidthDp { get; set; }

        /// <summary>
        /// The maximum (user option) "smallest screen width" for which your application is designed.
        /// </summary>
        /// <remarks>
        /// This property is available as of version 3.2 (Honeycomb)
        /// </remarks>
        [AndroidVersion(13)]
        public int CompatibleWidthLimitDp { get; set; }

        /// <summary>
        /// The maximum (forced) "smallest screen width" for which your application is designed.
        /// </summary>
        /// <remarks>
        /// This property is available as of version 3.2 (Honeycomb)
        /// </remarks>
        [AndroidVersion(13)]
        public int LargestWidthLimitDp { get; set; }
    }
}

