// Copyright (C) 2014 dot42
//
// Original filename: VideoSizeEventArgs.cs
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

namespace Android.Media
{
	public class VideoSizeEventArgs : EventArgs
	{
	    public VideoSizeEventArgs(int width, int height)
	    {
	        Height = height;
	        Width = width;
	    }

	    /// <summary>
        /// The width of the video
        /// </summary>
	    public int Width { get; private set; }

        /// <summary>
        /// The height of the video
        /// </summary>
        public int Height { get; private set; }
    }
}

