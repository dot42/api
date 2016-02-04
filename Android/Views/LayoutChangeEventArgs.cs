// Copyright (C) 2014 dot42
//
// Original filename: LayoutChangeEventArgs.cs
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
namespace Android.Views
{
	public class LayoutChangeEventArgs : System.EventArgs
	{
	    public LayoutChangeEventArgs(int left, int top, int right, int bottom, int oldLeft, int oldTop, int oldRight,
	                                 int oldBottom)
	    {
	        Left = left;
	        Top = top;
	        Right = right;
	        Bottom = bottom;
	        OldLeft = oldLeft;
	        OldTop = oldTop;
	        OldRight = oldRight;
	        OldBottom = oldBottom;
	    }

	    public int Left { get; private set; }
        public int Top { get; private set; }
        public int Right { get; private set; }
        public int Bottom { get; private set; }
        public int OldLeft { get; private set; }
        public int OldTop { get; private set; }
        public int OldRight { get; private set; }
        public int OldBottom { get; private set; }
    }
}

