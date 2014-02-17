// Copyright (C) 2014 dot42
//
// Original filename: PatternBuilder.cs
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
    internal class PatternBuilder
    {
        private readonly string pattern;
        private readonly PatternMap map;

        public PatternBuilder(string pattern, PatternMap map)
        {
            this.pattern = pattern;
            this.map = map;
        }

        internal string Build(List<ParserItem> parserItems)
        {
            if (!parserItems.Any())
            {
                return pattern;
            }

            var builder = new StringBuilder(pattern.Length);
            var index = 0;

            foreach (var parserItem in parserItems)
            {
                builder.Append(pattern, index, parserItem.StartIndex - index);
                builder.Append(parserItem.Replacement(pattern, map));
                index = parserItem.EndIndex;
            }

            builder.Append(pattern.Substring(index));

            return builder.ToString();
        }
    }
}

