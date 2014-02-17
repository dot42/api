// Copyright (C) 2014 dot42
//
// Original filename: RatingChangedEventArgs.cs
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

namespace Android.Widget
{
	public class RatingChangedEventArgs : EventArgs
	{
	    public RatingChangedEventArgs(float rating, bool fromUser)
	    {
	        FromUser = fromUser;
	        Rating = rating;
	    }

        /// <summary>
        /// The current rating. This will be in the range 0..numStars.
        /// </summary>
	    public float Rating { get; private set; }

        /// <summary>
        /// True if the rating change was initiated by a user's touch gesture or arrow key/horizontal trackbell movement.
        /// </summary>
        public bool FromUser { get; private set; }
    }
}

