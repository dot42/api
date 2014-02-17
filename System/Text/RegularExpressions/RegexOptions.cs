// Copyright (C) 2014 dot42
//
// Original filename: RegexOptions.cs
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
	[FlagsAttribute]
    public enum RegexOptions
	{ 
        /// <summary>
        /// Specifies that no options are set.
        /// </summary>
        None = 0,
 
        /// <summary>
        /// Specifies case-insensitive matching.
        /// </summary>
        IgnoreCase = 1,

        /// <summary>
        /// Multiline mode.
        /// </summary>
        Multiline = 2,

        /// <summary>
        /// Specifies that the only valid captures are explicitly named or numbered.
        /// </summary>
        ExplicitCapture = 4,
       
        /// <summary>
        /// Specifies that the regular expression is compiled to an assembly. (don't care)
        /// </summary>
        Compiled = 8,
        
        /// <summary>
        ///  Specifies single-line mode. 
        /// </summary>
        Singleline = 16,
       
        /// <summary>
        /// Eliminates unescaped white space from the pattern
        /// </summary>
        IgnorePatternWhitespace = 32,
       
        /// <summary>
        /// Specifies that the search will be from right to left
        /// </summary>
        RightToLeft = 64,
       
        /// <summary>
        /// Enables ECMAScript-compliant behavior for the expression.
        /// </summary>
        ECMAScript = 256,
        
        /// <summary>
        ///  Specifies that cultural differences in language is ignored. 
        /// </summary>
        CultureInvariant = 512,
	}
}

