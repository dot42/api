// Copyright (C) 2014 dot42
//
// Original filename: ChildClickEventArgs.cs
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
	public class ChildClickEventArgs : View.ViewEventArgs
	{
	    public ChildClickEventArgs(View.View view, int groupPosition, int childPosition, long id)
	    {
	        Id = id;
	        ChildPosition = childPosition;
	        GroupPosition = groupPosition;
	        View = view;
	    }

        /// <summary>
        /// The view within the expandable list/ListView that was clicked
        /// </summary>
	    public View.View View { get; private set; }

        /// <summary>
        /// The group position that contains the child that was clicked
        /// </summary>
        public int GroupPosition { get; private set; }

        /// <summary>
        /// The child position within the group
        /// </summary>
        public int ChildPosition { get; private set; }

        /// <summary>
        /// The row id of the child that was clicked
        /// </summary>
        public long Id { get; private set; }
    }
}

