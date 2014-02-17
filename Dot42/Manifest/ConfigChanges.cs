// Copyright (C) 2014 dot42
//
// Original filename: ConfigChanges.cs
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
    /// Changes in configuration
    /// </summary>
    [Flags]
    public enum ConfigChanges
	{
        /// <summary>
        /// Mobile country code has changed (a SIM has been detected that causes this change).
        /// </summary>
        MobileCountryCode = 0x0001,

        /// <summary>
        /// Mobile network code has changed (a SIM has been detected that causes this change).
        /// </summary>
        MobileNetworkCode = 0x0002,

        /// <summary>
        /// User has selected a new text language.
        /// </summary>
        Locale = 0x0004,

        /// <summary>
        /// Touchscreen has changed (very rare).
        /// </summary>
        TouchScreen = 0x0008,

        /// <summary>
        /// Type of keyboard has changed.
        /// </summary>
        Keyboard = 0x0010,

        /// <summary>
        /// Keyboard accessibility has changed.
        /// </summary>
        KeyboardHidden = 0x0020,

        /// <summary>
        /// Navigation type has changed (very rare).
        /// </summary>
        Navigation = 0x0040,

        /// <summary>
        /// Screen layout has changed. Might be caused by an activated alternate display.
        /// </summary>
        ScreenLayout = 0x0080,

        /// <summary>
        /// User has selected a different global font size.
        /// </summary>
        FontScale = 0x0100,

        /// <summary>
        /// Userinterface mode has changed. For example user places device in a car dock.
        /// </summary>
        /// <remarks>
        /// This property is available as of version 2.2 (Froyo)
        /// </remarks>
        [AndroidVersion(8)]
        UIMode = 0x0200,

        /// <summary>
        /// User has rotated the device.
        /// </summary>
        Orientation = 0x0400,

        /// <summary>
        /// Current available screen size has changed.
        /// </summary>
        /// <remarks>
        /// This property is available as of version 3.2 (Honeycomb)
        /// </remarks>
        [AndroidVersion(13)]
        ScreenSize = 0x0800,

        /// <summary>
        /// Physical screen size has changed.
        /// </summary>
        /// <remarks>
        /// This property is available as of version 3.2 (Honeycomb)
        /// </remarks>
        [AndroidVersion(13)]
        SmallestScreenSize = 0x1000
	}
}

