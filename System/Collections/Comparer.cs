// Copyright (C) 2014 dot42
//
// Original filename: Comparer.cs
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
namespace System.Collections
{
    /// <summary>
    /// Default comparer
    /// </summary>
	public sealed class Comparer : IComparer
	{
        /// <summary>
        /// Default ctor
        /// </summary>
        private Comparer()
        {            
        }

        public static readonly Comparer Default = new Comparer();

        /// <summary>
        /// Compare object a with b.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>Return less than 0 if a is less than b, Greater than 0 if  is greater than b, or 0 is a is equal to b.</returns>
        public int Compare(object a, object b)
	    {
	        if (a == b) return 0;
	        if (a == null) return -1;
	        if (b == null) return 1;

	        var sa = a as string;
	        var sb = b as string;
	        if ((sa != null) && (sb != null))
	            return string.Compare(sa, sb);

	        var comparable = a as IComparable;
	        if (comparable != null)
	            return comparable.CompareTo(b);

	        comparable = b as IComparable;
	        if (comparable != null)
	            return -comparable.CompareTo(a);

	        throw new ArgumentException("Implement IComparable");
	    }
	}
}

