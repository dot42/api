// Copyright (C) 2014 dot42
//
// Original filename: WindowSoftInputModes.cs
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
    [Flags]
    public enum WindowSoftInputModes
	{
        /// <summary>
        /// State of the soft keyboard is unspecified.
        /// This is the default setting.
        /// </summary>
        StateUnspecified = 0x0001,

        /// <summary>
        /// The soft keyboard is kept in whatever state it was before the activity came to the foreground.
        /// </summary>
        StateUnchanged = 0x0002,

        /// <summary>
        /// The soft keyboard is hidden when the user chooses the activity.
        /// </summary>
        StateHidden = 0x0003,

        /// <summary>
        /// The soft keyword is always hidden if the activities main window has the input focus.
        /// </summary>
        StateAlwaysHidden = 0x0004,

        /// <summary>
        /// The soft keyboard is visible when that is normally appropriate.
        /// </summary>
        StateVisible = 0x0005,

        /// <summary>
        /// The soft keyboard is made visible when the user chooses the activity.
        /// </summary>
        StateAlwaysVisible = 0x0006,

        /// <summary>
        /// It is unspecified whether the activity's main window resizes to make room for the soft keyboard, or whether the contents of the window 
        /// pan to make the currentfocus visible on-screen.
        /// </summary>
        AdjustUnspecified = 0x0100,

        /// <summary>
        /// The activity's main window is always resized to make room for the soft keyboard on screen.
        /// </summary>
        AdjustResize = 0x0200,

        /// <summary>
        /// The activity's main window is not resized to make room for the soft keyboard. Rather, the contents of the window are automatically 
        /// panned so that the current focus is never obscured by the keyboard and users can always see what they are typing.
        /// </summary>
        AdjustPan = 0x0300
	}
}

