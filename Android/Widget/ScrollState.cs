// Copyright (C) 2014 dot42
//
// Original filename: ScrollState.cs
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
namespace Android.Widget
{
	public enum ScrollState
	{
        /// <summary>
        /// The view is not scrolling.
        /// </summary>
        Idle = 0,

        /// <summary>
        /// The user is scrolling using touch, and his finger is still on the screen.
        /// </summary>
        TouchScroll = 1,

        /// <summary>
        /// The user had previously been scrolling using touch and performed a fling.
        /// </summary>
        Fling = 2,
	}
}

