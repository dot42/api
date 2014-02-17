// Copyright (C) 2014 dot42
//
// Original filename: DialogInterfaceClickEventArgs.cs
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

namespace Android.Content
{
    /// <summary>
    /// Event arguments used by event handlers of <see cref="IDialogInterface"/>.
    /// </summary>
	public class DialogInterfaceClickEventArgs : EventArgs
	{
	    private readonly int which;

	    public DialogInterfaceClickEventArgs(int which)
	    {
	        this.which = which;
	    }

        /// <summary>
        /// Which button was clicked.
        /// <see cref="IDialogInterfaceConstants.BUTTON_POSITIVE"/>
        /// </summary>
        public int Which { get { return which; } }

        /// <summary>
        /// Was the positive button pressed?
        /// </summary>
        public bool IsButtonPositive { get { return (which == IDialogInterfaceConstants.BUTTON_POSITIVE); } }

        /// <summary>
        /// Was the negative button pressed?
        /// </summary>
        public bool IsButtonNegative { get { return (which == IDialogInterfaceConstants.BUTTON_NEGATIVE); } }

        /// <summary>
        /// Was the neutral button pressed?
        /// </summary>
        public bool IsButtonNeutral { get { return (which == IDialogInterfaceConstants.BUTTON_NEUTRAL); } }
    }
}

