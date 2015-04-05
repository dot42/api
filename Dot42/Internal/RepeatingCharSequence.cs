// Copyright (C) 2014 dot42
//
// Original filename: RepeatingCharSequence.cs
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
using System;
using Java.Lang;

namespace Dot42.Internal
{
    /// <summary>
    /// A character sequence that repeats a single character for a specific amount of times.
    /// </summary>
	internal sealed class RepeatingCharSequence : ICharSequence
	{
	    private readonly int length;
	    private readonly char value;

	    public RepeatingCharSequence(char value, int length)
	    {
	        this.value = value;
	        this.length = length;
	    }


        int ICharSequence.GetLength()
        {
            return length;
        }

        char ICharSequence.CharAt(int int32)
	    {
	        return value;
	    }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="start">the start offset of the sub-sequence. It is inclusive, that is, the index of the first character that is included in the sub-sequence.</param>
        /// <param name="end">the end offset of the sub-sequence. It is exclusive, that is, the index of the first character after those that are included in the sub-sequence.</param>
	    ICharSequence ICharSequence.SubSequence(int start, int end)
	    {
            if ((start < 0) || (end < 0) || (start > end) || (end > length))
                throw new IndexOutOfRangeException();
            return new RepeatingCharSequence(value, end - start);
	    }

        public int Length { get { return length; } }
	}
}

