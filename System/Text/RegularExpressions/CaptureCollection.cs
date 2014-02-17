// Copyright (C) 2014 dot42
//
// Original filename: CaptureCollection.cs
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

namespace System.Text.RegularExpressions
{
    public class CaptureCollection : IEnumerable
	{
        private readonly ArrayList<Capture> captures = new ArrayList<Capture>(); 

        public int Count
        {
            get { return captures.Count; }
        }

        public virtual Capture this[int i]
        {
            get { return captures[i]; }
        }

        public IEnumerator GetEnumerator()
        {
            return captures.GetEnumerator();
        }

        internal void Add(Capture capture)
        {
            captures.Add(capture);
        }
	}
}

