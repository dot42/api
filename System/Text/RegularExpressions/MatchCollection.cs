// Copyright (C) 2014 dot42
//
// Original filename: MatchCollection.cs
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
using System.Collections;

using Java.Util;
using Java.Util.Regex;

namespace System.Text.RegularExpressions
{
    public class MatchCollection : IEnumerable
	{
	    private ArrayList<Match> matches = new ArrayList<Match>(); 

        internal MatchCollection(string text, Matcher matcher, Regex regex)
        {
            var match = new Match(text, matcher, regex, 0);
            while (match.Success)
            {
                matches.Add(match);
                match = new Match(text, matcher, regex, match.End);
            }
        }

	    public int Count
	    {
	        get { return matches.Count; }
	    }

        public virtual Match this[int i] 
        {
            get { return matches[i]; }
        }

        public IEnumerator GetEnumerator()
        {
            return matches.GetEnumerator();
        }
    }
}

