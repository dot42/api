// Copyright (C) 2014 dot42
//
// Original filename: PatternMap.cs
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
using System.Collections.Generic;
using System.Linq;

namespace System.Text.RegularExpressions.Internal
{
    internal class PatternMap
    {
        private readonly Dictionary<string, int> nameToIndexMap = new Dictionary<string, int>();
        private readonly Dictionary<int, int[]> sourceToTargetsIndexMap = new Dictionary<int, int[]>();
        private int targetGroupCount;

        public PatternMap(List<ParserItem> parserItems)
        {
            FillNameToIndexMap(parserItems);
            FillSourceToTargetIndexMap(parserItems);
            if (nameToIndexMap.Count != sourceToTargetsIndexMap.Count) throw new InvalidOperationException("Incorrect length of maps encountered");
        }

        private void FillNameToIndexMap(List<ParserItem> parserItems)
        {
            var index = 0;

            //first capturing group (entire pattern)
            nameToIndexMap.Add(index.ToString(), index);
            
            index++;

            foreach (var parserItem in parserItems.Where(pi => pi is NumberedCaptureGroup).Cast<NumberedCaptureGroup>())
            {
                nameToIndexMap.Add(index.ToString(), index);
                index++;
            }

            foreach (var parserItem in parserItems.Where(pi => pi is NamedCaptureGroup).Cast<NamedCaptureGroup>())
            {
                //name is allowed multiple times, map should use first one
                if (!nameToIndexMap.ContainsKey(parserItem.Name))
                {
                    nameToIndexMap.Add(parserItem.Name, index);
                    index++;
                }
            }
        }

        private void FillSourceToTargetIndexMap(List<ParserItem> parserItems)
        {
            //first capturing group (entire pattern)
            var index = 0;
            AddSourceToTargetsIndexMap(index, index);

            index = 1;
            var numberedIndex = 1;

            foreach (var parserItem in parserItems.Where(pi => pi is NumberedCaptureGroup || pi is NamedCaptureGroup))
            {
                if (parserItem is NumberedCaptureGroup)
                {
                    AddSourceToTargetsIndexMap(numberedIndex, index);
                    numberedIndex++;
                }

                var namedCaptureGroup = parserItem as NamedCaptureGroup;
                if (namedCaptureGroup != null)
                {
                    var namedIndex = nameToIndexMap[namedCaptureGroup.Name];
                    AddSourceToTargetsIndexMap(namedIndex, index);
                }

                index++;
            }

            targetGroupCount = index;
        }

        private void AddSourceToTargetsIndexMap(int sourceIndex, int targetIndex)
        {
            int[] targets;
            targets = sourceToTargetsIndexMap.TryGetValue(sourceIndex, out targets) ? targets.Concat(new[] {targetIndex}).ToArray() : new []{targetIndex};

            sourceToTargetsIndexMap[sourceIndex] = targets;
        }

        internal int GroupNumberFromName(string name)
        {
            int number;
            if (!nameToIndexMap.TryGetValue(name, out number))
            {
                throw new InvalidOperationException("Cannot resolve named capture group:" + name);
            }

            return number;
        }

        internal int[] GetGroupNumbers()
        {
            return sourceToTargetsIndexMap.Keys.OrderBy(k=>k).ToArray();
        }

        internal int[] GetSourceToTargetsIndex(int number)
        {
            int[] targets;
            //do not renumber if not found, it will be interpreted as octal escape
            return sourceToTargetsIndexMap.TryGetValue(number, out targets) ? targets : new []{number};
        }

        /// <summary>
        /// Excl group 0
        /// </summary>
        internal void ValidateSourceGroupCount(int groupCount)
        {
            if(sourceToTargetsIndexMap.Count-1 != groupCount)
                throw new InvalidOperationException(string.Format("The source group count is incorrect, expected: {0} actual: {1}", sourceToTargetsIndexMap.Count-1, groupCount));
        }

        internal int GetSourceGroupCount()
        {
            return sourceToTargetsIndexMap.Count - 1;
        }

        /// <summary>
        /// Excl group 0
        /// </summary>
        internal void ValidateTargetGroupCount(int groupCount)
        {
            if (targetGroupCount-1 != groupCount)
                throw new InvalidOperationException(string.Format("The target group count is incorrect, expected: {0} actual: {1}", targetGroupCount-1, groupCount));
        }
    }
}

