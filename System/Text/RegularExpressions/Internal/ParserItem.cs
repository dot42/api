// Copyright (C) 2014 dot42
//
// Original filename: ParserItem.cs
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
namespace System.Text.RegularExpressions.Internal
{
    internal class ParserItem
    {
        public ParserItem(int startIndex, int endIndex)
        {
            StartIndex = startIndex;
            EndIndex = endIndex;
        }

        public virtual string Replacement(string pattern, PatternMap map)
        {
            return pattern.Substring(StartIndex, EndIndex - StartIndex);
        }

        public int StartIndex { get; private set; }
        public int EndIndex { get; private set; }
    }
}
