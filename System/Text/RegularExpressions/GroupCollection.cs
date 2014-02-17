// Copyright (C) 2014 dot42
//
// Original filename: GroupCollection.cs
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
    public class GroupCollection : IEnumerable
	{
        private Match regexMatch;
        private ArrayList<Group> groups = new ArrayList<Group>(); 

        internal GroupCollection(string text, IMatchResult matcher, Match regexMatch)
        {
            this.regexMatch = regexMatch;

            groups.Add(regexMatch);

            regexMatch.Regex.PatternConverter.PatternMap.ValidateTargetGroupCount(matcher.GroupCount());

            for (var i = 1; i <= regexMatch.Regex.PatternConverter.PatternMap.GetSourceGroupCount(); i++)
            {
                var groupIndexes =  regexMatch.Regex.PatternConverter.PatternMap.GetSourceToTargetsIndex(i);

                Group group = null;
                foreach (var groupIndex in groupIndexes)
                {
                    var start = matcher.Start(groupIndex);
                    if (start != -1)
                    {
                        var end = matcher.End(groupIndex);
                        if (group == null)
                        {
                            group = new Group(text, start, end);
                        }
                        else
                        {
                            group.Captures.Add(new Capture(text, start, end));
                        }
                    }
                }

                //no successfull match found
                if(group == null) group = new Group(text, -1, -1);

                groups.Add(group);
            }
        }

        public int Count
        {
            get { return groups.Count; }
        }

        public virtual Group this[int i]
        {
            get { return groups[i]; }
        }

        public virtual Group this[string groupname]
        {
            get
            {
                return groups[regexMatch.Regex.GroupNumberFromName(groupname)];
            }
        }

        public IEnumerator GetEnumerator()
        {
            return groups.GetEnumerator();
        }
	}
}

