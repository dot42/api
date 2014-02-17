// Copyright (C) 2014 dot42
//
// Original filename: UIOptions.cs
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
namespace Dot42.Manifest
{
	public enum UIOptions
	{
        /// <summary>
        /// No extra UI options
        /// </summary>
        None,

        /// <summary>
        /// Add a bar at the bottom of the screen to display action items in the ActionBar, when constrained for horizontal space 
        /// (such as when in portrait mode on a handset). Instead of a small number of action items appearing in the action bar at the top of the screen, 
        /// the action bar is split into the top navigation section and the bottom bar for action items. This ensures a reasonable amount of space is made 
        /// available not only for the action items, but also for navigation and title elements at the top. Menu items are not split across the two bars; 
        /// they always appear together.
        /// </summary>
        SplitActionBarWhenNarrow
	}
}

