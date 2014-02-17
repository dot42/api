// Copyright (C) 2014 dot42
//
// Original filename: Capture.cs
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
namespace System.Text.RegularExpressions
{
	public class Capture
	{
        private readonly string text;
	    private int start;
        private int end;
        
        internal Capture(string text, int start, int end)
        {
            //start and end are both -1 is it's an unsuccessful capture
            this.text = text;
            this.start = start;
            this.end = end;
        }

        /// <summary>
        /// The start index
        /// </summary>
	    public int Index
	    {
            get { return start ==-1 ? 0 : start; }
	    }

        /// <summary>
        /// the length of the capture
        /// </summary>
	    public int Length
	    {
            get { return end - start; }
	    }

	    internal int End
	    {
            get { return end; }
	    }

        /// <summary>
        /// The actual substing captured from the match
        /// </summary>
	    public string Value
	    {
            get{ return text.Substring(Index, Length); }
	    }

	    internal string Text
	    {
	        get { return text; }
	    }

	    internal void UpdateRegion(int start, int end)
	    {
	        if (this.start == -1) throw new NotSupportedException("it's not allowed to update an not succeeded capture");
            this.start = start;
            this.end = end;
	    }

	    public override string ToString()
        {
            return Value;
        }
	}
}

