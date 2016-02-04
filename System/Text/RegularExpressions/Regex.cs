// Copyright (C) 2014 dot42
//
// Original filename: Regex.cs
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
using System.Text.RegularExpressions.Internal;
using Java.Util.Regex;

namespace System.Text.RegularExpressions
{
	public class Regex
	{
	    [NonSerializedAttribute] 
        public static readonly TimeSpan InfiniteMatchTimeout = TimeSpan.MaxValue;

	    private PatternConverter patternConverter;
	    private RegexOptions options;
	    private TimeSpan matchTimeout;
        

	    public Regex()
	    {
	        
	    }

        public Regex(string pattern)
            :this(pattern, RegexOptions.None)
        { 
        }

        public Regex(string pattern, RegexOptions options)
            :this(pattern, options, Regex.InfiniteMatchTimeout)
        {
            
        }

        public Regex(string pattern, RegexOptions options, TimeSpan matchTimeout)
        {
            patternConverter = new PatternConverter(pattern, options);
            this.options = options;
            this.matchTimeout = matchTimeout;
        }

	    internal PatternConverter PatternConverter
	    {
	        get { return patternConverter; }
	    }

        public RegexOptions Options { get { return options; } }

	    /// <summary>
        /// Searches the specified input string for the first occurrence of the regular expression specified in the Regex constructor.
        /// </summary>
        public Match Match(string input)
        {
            return Match(input, 0);
        }

        /// <summary>
        /// Searches the specified input string for the first occurrence of the regular expression specified in the Regex constructor.
        /// </summary>
        public Match Match(string input, int startat)
        {
            return Match(input, startat, input.Length - startat);
        }

        /// <summary>
        /// Searches the specified input string for the first occurrence of the regular expression specified in the Regex constructor.
        /// </summary>
        public Match Match(string input, int beginning, int length)
        {
            var text = input.Substring(beginning, length);
            var pattern = Pattern.Compile(patternConverter.JavaPattern, JavaFlags(options));
            var matcher = pattern.Matcher(text);
            return new Match(text, matcher, this, 0);
        }

        public static Match Match(string input, string pattern)
        {
            return Match(input, pattern, RegexOptions.None);
        }

        public static Match Match(string input, string pattern, RegexOptions options)
        {
            return Match(input, pattern, options, InfiniteMatchTimeout);
        }

        public static Match Match(string input, string pattern, RegexOptions options, TimeSpan matchTimeout)
        {
            var regex = new Regex(pattern, options, matchTimeout);
            return regex.Match(input);
        }

        /// <summary>
        /// Indicates whether the regular expression finds a match in the input string.
        /// </summary>
        public bool IsMatch(string input)
        {
            return Match(input).Success;
        }

        /// <summary>
        /// Indicates whether the regular expression finds a match in the input string.
        /// </summary>
        public bool IsMatch(string input, int startat)
        {
            return Match(input, startat).Success;
        }

        public static bool IsMatch(string input, string pattern)
        {
            return IsMatch(input, pattern, RegexOptions.None);
        }

        public static bool IsMatch(string input, string pattern, RegexOptions options)
        {
            return IsMatch(input, pattern, options, InfiniteMatchTimeout);
        }

        public static bool IsMatch(string input, string pattern, RegexOptions options, TimeSpan matchTimeout)
        {
            return Match(input, pattern, options, matchTimeout).Success;
        }

        public MatchCollection Matches(string input)
        {
            var pattern = Pattern.Compile(patternConverter.JavaPattern, JavaFlags(options));
            var matcher = pattern.Matcher(input);
        
            return new MatchCollection(input, matcher, this);
        }

        public string Replace(string input, MatchEvaluator evaluator)
        {
            if(input == null) throw new ArgumentNullException("input");
            if (evaluator == null) throw new ArgumentNullException("evaluator");

            var builder = new StringBuilder(input.Length);
            var index = 0;

            foreach (Match match in Matches(input)) //only success matches are in the collection
            {
                builder.Append(input.Substring(index, match.Index - index));
                builder.Append(evaluator(match));
                index += match.Length;
            }
            builder.Append(input.Substring(index));

            return input;
        }

        public string Replace(string input, string replacement)
        {
            if (input == null) throw new ArgumentNullException("input");
            if (replacement == null) throw new ArgumentNullException("replacement");

            var pattern = Pattern.Compile(patternConverter.JavaPattern, JavaFlags(options));
            var matcher = pattern.Matcher(input);

            return matcher.ReplaceAll(replacement);
        }

        public int GroupNumberFromName(string name)
        {
            return patternConverter.PatternMap.GroupNumberFromName(name);
        }

        public int[] GetGroupNumbers()
        {
            return patternConverter.PatternMap.GetGroupNumbers();
        }

        private static int JavaFlags(RegexOptions options)
        {
            int result = 0;

            if (HasEnabled(options, RegexOptions.IgnoreCase)) result += Pattern.CASE_INSENSITIVE;
            if (HasEnabled(options, RegexOptions.Multiline)) result += Pattern.MULTILINE;
            if (HasEnabled(options, RegexOptions.Singleline)) result += Pattern.DOTALL;
            if (HasEnabled(options, RegexOptions.IgnorePatternWhitespace)) result += Pattern.COMMENTS;
            if (HasEnabled(options, RegexOptions.CultureInvariant)) result += Pattern.UNICODE_CASE;

            if (HasEnabled(options, RegexOptions.RightToLeft)) throw new NotSupportedException("RightToLeft option in regular expression is not supported");

            return result;
        }

        private static bool HasEnabled(RegexOptions options, RegexOptions flag)
        {
            return (options & flag) == flag;
        }

	}
}

