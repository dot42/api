// Copyright (C) 2014 dot42
//
// Original filename: PatternConverter.cs
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
    internal class PatternConverter
    {
        internal string DotNetPattern { get; private set; }
        internal string JavaPattern { get; private set; }

        private readonly PatternMap patternMap;

        internal PatternConverter(string dotNetPattern, RegexOptions options)
        {
            DotNetPattern = dotNetPattern;

            var isIgnorePatternWhitespace = (options & RegexOptions.IgnorePatternWhitespace) == RegexOptions.IgnorePatternWhitespace;
            var isExpicitCapture = (options & RegexOptions.ExplicitCapture) == RegexOptions.ExplicitCapture;

            var parser = new PatternParser(dotNetPattern, isIgnorePatternWhitespace, isExpicitCapture);

            var parseItems = parser.Parse();
            patternMap = new PatternMap(parseItems);

            var builder = new PatternBuilder(dotNetPattern, patternMap);
            JavaPattern = builder.Build(parseItems);
        }

        internal PatternMap PatternMap
        {
            get { return patternMap; }
        }
    }
}

