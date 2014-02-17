// Copyright (C) 2014 dot42
//
// Original filename: Group.cs
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
	public class Group : Capture
	{
	    private readonly CaptureCollection captures;

        internal Group(string text, int start, int end)
            :base(text, start, end)
        {
            captures = new CaptureCollection();
            if (start != -1) captures.Add(this);
        }

	    public CaptureCollection Captures
	    {
            get { return captures; }
	    }

	    public bool Success
	    {
	        get
	        {
                return End != -1;
	        }
	    }
	}
}

