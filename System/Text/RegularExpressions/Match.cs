// Copyright (C) 2014 dot42
//
// Original filename: Match.cs
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
using Java.Util.Regex;

namespace System.Text.RegularExpressions
{
	public class Match : Group
	{
        private readonly Matcher matcher;
	    private readonly Regex regex;

        private static Match empty = new Match();

        public static Match Empty {
            get { return empty; }
        }

        private GroupCollection groupCollection;

        private Match()
            :base("", -1, -1)
        {
            //the empty match
        }

        internal Match(string text, Matcher matcher, Regex regex, int start)
            : base(text, start, start)
        {
            this.matcher = matcher;
            this.regex = regex;

            bool success = matcher.Find(start);
            if (success)
            {
                UpdateRegion(matcher.Start(), matcher.End());
                groupCollection = new GroupCollection(text, matcher, this);  
            }
            else
            {
                UpdateRegion(-1, -1);
            }
        }

	    internal Regex Regex
	    {
	        get { return regex; }
	    }

	    public GroupCollection Groups
	    {
            get { return groupCollection; }
	    }

        public Match NextMatch()
        {
            return new Match(Text, matcher, regex, End);
        }
	}
}

