// Copyright (C) 2014 dot42
//
// Original filename: ItemClickEventArgs.cs
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
using Android.Views;

namespace Android.Widget
{
    /// <summary>
    /// Event arguments for Item click events.
    /// </summary>
	public class ItemClickEventArgs : EventArgs
	{
        /// <summary>
        /// Default ctor
        /// </summary>
	    public ItemClickEventArgs(View view, int position, long id)
	    {
	        Id = id;
	        Position = position;
	        View = view;
	    }

	    /// <summary>
        /// The view that was clicked (provided by the adapter)
        /// </summary>
        public View View { get; private set; }

        /// <summary>
        /// Position of the view within the adapter
        /// </summary>
        public int Position { get; private set; }

        /// <summary>
        /// Row id of the item that was clicked
        /// </summary>
        public long Id { get; private set; }

        /// <summary>
        /// Set this property to true when the listenered has consumed the event.
        /// </summary>
        public bool IsHandled { get; set; }
    }
}

