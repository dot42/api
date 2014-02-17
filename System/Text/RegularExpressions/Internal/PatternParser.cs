// Copyright (C) 2014 dot42
//
// Original filename: PatternParser.cs
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
using System.Diagnostics;

namespace System.Text.RegularExpressions.Internal
{
    internal class PatternParser
    {
        private enum EscapeState
        {
            None,
            Escape,                        // \
            NumberedBackReference,         // \number (0-79)
            StartNamedBackReference,       // \k
            NamedBackReference             // \k<
        }

        private enum CommentsState
        {
            None,
            CommentsLine,                  // # if IgnorePatternWhitespace = on
            CommentsGroup,                 // (#
        }

        private enum PatternState
        {
            Other,                              // SubPattern, Modifiers
            StartCharacterClass,                // [ or [^
            CharacterClass,                     // [... or [^...
            StartGroup,                         // (
            StartExtendedGroup,                 // (?
            // NonCaptureGroup,                 // (?: -> Other
            NamedCaptureGroupQuote,             // (?'
            StartNamedCaptureGroupAngleBracket, // (?<
            // PositiveLookBehind,              // (?<= -> Other
            // NegativeLookBehind,              // (?<! -> Other
            NamedCaptureGroupAngleBracket       // (?< and not the two above.
        }

        private readonly string pattern;
        private readonly bool ignorePatternWhitespace;
        private readonly bool explicitCapture;

        private int currentIndex = 0;
        private List<ParserItem> parserItems = new List<ParserItem>();

        private EscapeState escapeState = EscapeState.None;
        private CommentsState commentsState = CommentsState.None;
        private PatternState patternState = PatternState.Other;
        private PatternState previousPatternState = PatternState.Other;

        private int groupLevel = 0;          // ()

        private int escapeStartIndex = -1;
        private int startGroupIndex = -1;
        private int previousStartGroupIndex = -1;

        private int startNamedIndex = -1;
        private int number = 0;

        public PatternParser(string pattern, bool ignorePatternWhitespace, bool explicitCapture)
        {
            this.pattern = pattern;
            this.ignorePatternWhitespace = ignorePatternWhitespace;
            this.explicitCapture = explicitCapture;
        }

        public List<ParserItem> Parse()
        {
            while (currentIndex < pattern.Length)
            {
                var newToken = pattern[currentIndex];

                EvalEscapeState(newToken);

                currentIndex++;
            }

            if (escapeState == EscapeState.NumberedBackReference)
            {
                //handle escape
                EvalEscapeState(' ');
            }

            if (groupLevel != 0) throw new Exception("Unbalanced () found");
            
            if (patternState == PatternState.StartCharacterClass || patternState == PatternState.CharacterClass ) throw new Exception("Unbalanced [] found");
            if (patternState != PatternState.Other) throw new Exception("Pattern state ended in invalid state : " + (int)patternState);

            if (escapeState != EscapeState.None) throw new Exception("Escape state ended in invalid state : " + (int)escapeState);

            return parserItems;
        }

        private void EvalEscapeState(char token)
        {
            switch (escapeState)
            {
                case EscapeState.None:
                    if(token == '\\')
                    {
                        escapeState = EscapeState.Escape;
                        escapeStartIndex = currentIndex;
                    }
                    else
                    {
                        EvalCommentsState(token, false);
                    }
                    break;
                case EscapeState.Escape:   // \
                    if (token == 'k')
                    {
                        escapeState = EscapeState.StartNamedBackReference;
                    }
                    else if (char.IsDigit(token))
                    {
                        escapeState = EscapeState.NumberedBackReference;
                        number = int.Parse(token.ToString());
                        EvalCommentsState(token, true);
                    }
                    else
                    {
                        EvalCommentsState(token, true);
                        escapeState = EscapeState.None;
                    }
                    break;
                case EscapeState.NumberedBackReference:     // \number
                    if (char.IsDigit(token))
                    {
                        number = 10 * number + int.Parse(token.ToString());
                    }
                    else
                    {
                        NumberedBackReferenceFound(escapeStartIndex, currentIndex, number);
                        escapeState = EscapeState.None;
                        EvalCommentsState(token, false);
                    }
                    break;
                case EscapeState.StartNamedBackReference:
                    if(token == '<')
                    {
                        escapeState = EscapeState.NamedBackReference;
                        startNamedIndex = currentIndex+1;
                    }
                    else
                    {
                        escapeState = EscapeState.None;
                        EvalCommentsState(token, false);
                    }
                    break;
                case EscapeState.NamedBackReference:        // \k<name>
                    if(token == '>')
                    {
                        NamedBackReferenceFound(escapeStartIndex, currentIndex+1, GetName(startNamedIndex, currentIndex));
                        escapeState = EscapeState.None;
                    } //else we are inside the name, continue
                    break;
            }
        }

        private void EvalCommentsState(char token, bool escaped)
        {
            switch (commentsState)
            {
                case CommentsState.None:
                    if (!escaped)
                    {
                        if (token == '#')
                        {
                            if (patternState == PatternState.StartGroup)
                            {
                                commentsState = CommentsState.CommentsGroup;
                            }
                            else if (ignorePatternWhitespace)
                            {
                                commentsState = CommentsState.CommentsLine;
                            }
                            else
                            {
                                EvalGroupState(token, escaped);
                            }
                        }
                        else
                        {
                            EvalGroupState(token, escaped);
                        }
                    }
                    else
                    {
                        EvalGroupState(token, escaped);
                    }
                    break;
                case CommentsState.CommentsLine:
                    if(token == 'n' && escaped)
                    {
                        commentsState = CommentsState.None;
                    }
                    break;
                case CommentsState.CommentsGroup:
                    if (token == ')' && !escaped)
                    {
                        CommentsGroupFound(startGroupIndex, currentIndex+1);

                        groupLevel--;
                        patternState = previousPatternState;
                        startGroupIndex = previousStartGroupIndex;

                        commentsState = CommentsState.None;
                    }
                    break;
            }
        }

        private void EvalGroupState(char token, bool escaped)
        {
            if (!escaped)
            {
                if (patternState != PatternState.StartCharacterClass && patternState != PatternState.CharacterClass)
                {
                    switch (token)
                    {
                        case '(':
                            previousPatternState = patternState;
                            patternState = PatternState.StartGroup;
                            previousStartGroupIndex = startGroupIndex;
                            startGroupIndex = currentIndex;
                            groupLevel++;
                            if (previousPatternState == PatternState.StartGroup) // (( 
                            {
                                NumberedCaptureGroupFound(previousStartGroupIndex, currentIndex);
                            }
                            return;
                        case ')':
                            groupLevel--;
                            return;
                        default:
                            //see switch below
                            break;
                    }
                }

                switch (patternState)
                {
                    case PatternState.Other: // Pattern, Modifiers
                        switch (token)
                        {
                            case '[':
                                patternState = PatternState.StartCharacterClass;
                                break;
                        }
                        break;
                    case PatternState.StartCharacterClass:
                        if (token != '^') patternState = PatternState.CharacterClass;
                        break;
                    case PatternState.CharacterClass:
                        if (token == ']') patternState = PatternState.Other;
                        break;
                    case PatternState.StartGroup: // (
                        if (token == '?')
                        {
                            patternState = PatternState.StartExtendedGroup;
                        }
                        else
                        {
                            if (previousPatternState == PatternState.StartExtendedGroup)
                            {
                                ConditionFound(currentIndex);
                            }
                            else
                            {
                                NumberedCaptureGroupFound(startGroupIndex, currentIndex);
                            }
                            patternState = token == '[' ? PatternState.StartCharacterClass : PatternState.Other;
                        }
                        break;
                    case PatternState.StartExtendedGroup: // (?
                        // NonCaptureGroup:                        // (?: -> Other
                        switch (token)
                        {
                            case '\'':
                                patternState = PatternState.NamedCaptureGroupQuote;
                                startNamedIndex = currentIndex + 1;
                                break;
                            case '<':
                                patternState = PatternState.StartNamedCaptureGroupAngleBracket;
                                startNamedIndex = currentIndex + 1;
                                break;
                            default:
                                patternState = PatternState.Other;
                                break;
                        }
                        break;
                    case PatternState.NamedCaptureGroupQuote: // (?'
                        if (token == '\'')
                        {
                            NamedCaptureGroupFound(startGroupIndex, currentIndex + 1, GetName(startNamedIndex, currentIndex));
                            patternState = PatternState.Other;
                        } //else we are inside the name
                        break;
                    case PatternState.StartNamedCaptureGroupAngleBracket: // (?<
                        // PositiveLookBehind:                          // (?<= -> Other
                        // NegativeLookBehind:                          // (?<! -> Other
                        if (token == '=' || token == '!')
                        {
                            patternState = PatternState.Other;
                        }
                        else
                        {
                            patternState = PatternState.NamedCaptureGroupAngleBracket;
                        }
                        break;
                    case PatternState.NamedCaptureGroupAngleBracket:
                        if (token == '>')
                        {
                            NamedCaptureGroupFound(startGroupIndex, currentIndex + 1, GetName(startNamedIndex, currentIndex));
                            patternState = PatternState.Other;
                        } //else we are inside the name
                        break;
                    default:
                        throw new NotSupportedException("Unknown group state");
                }
            }
            else
            {
                switch (patternState)
                {
                    case PatternState.StartCharacterClass:
                        patternState = PatternState.CharacterClass;
                        break;
                    case PatternState.StartExtendedGroup:
                        patternState = PatternState.Other;
                        break;
                    case PatternState.StartGroup:
                        if (previousPatternState == PatternState.StartExtendedGroup)
                        {
                            ConditionFound(currentIndex-1);
                        }
                        else
                        {
                            NumberedCaptureGroupFound(startGroupIndex, currentIndex-1);
                        }
                        patternState = PatternState.Other;
                        break;
                    case PatternState.StartNamedCaptureGroupAngleBracket:
                        patternState = PatternState.NamedCaptureGroupAngleBracket;
                        break;
                }
            }
        }

        private string GetName(int startIndex, int endIndex)
        {
            return pattern.Substring(startIndex, endIndex - startIndex);
        }

        private void NumberedCaptureGroupFound(int startIndex, int endIndex)
        {
            Debug.WriteLine("NumberedCaptureGroupFound [startAt={0}]: {1}", startIndex, GetName(startIndex, endIndex));
            if (explicitCapture)
            {
                parserItems.Add(new NumberedAsNonCaptureGroup(startIndex, endIndex));
            }
            else
            {
                parserItems.Add(new NumberedCaptureGroup(startIndex, endIndex));
            }
            
        }

        private void NamedCaptureGroupFound(int startIndex, int endIndex, string name)
        {
            Debug.WriteLine("NamedCaptureGroupFound [startAt={0} {1}]: {2}", startIndex, name, GetName(startIndex, endIndex));
            parserItems.Add(new NamedCaptureGroup(startIndex, endIndex, name));
        }

        private void CommentsGroupFound(int startIndex, int endIndex)
        {
            Debug.WriteLine("CommentsGroupFound: " + GetName(startIndex, endIndex));
            parserItems.Add(new CommentsGroup(startIndex, endIndex));
        }

        private void ConditionFound(int startIndex)
        {
            Debug.WriteLine("ConditionFound at index: {0}", startIndex);
            parserItems.Add(new Condition(startIndex, -1));
        }

        private void NumberedBackReferenceFound(int startIndex, int endIndex, int refNumber)
        {
            Debug.WriteLine("NumberedBackReferenceFound [{1}]: {0}", GetName(startIndex, endIndex), number);
            parserItems.Add(new NumberedBackReference(startIndex, endIndex, refNumber));
        }

        private void NamedBackReferenceFound(int startIndex, int endIndex, string name)
        {
            Debug.WriteLine("NamedBackReferenceFound [{1}]: {0}", GetName(startIndex, endIndex), name);
            parserItems.Add(new NamedBackReference(startIndex, endIndex, name));
        }
    }
}

