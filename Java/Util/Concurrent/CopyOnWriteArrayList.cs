// Copyright (C) 2014 dot42
//
// Original filename: CopyOnWriteArrayList.cs
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
using Dot42;

namespace Java.Util.Concurrent
{
	partial class CopyOnWriteArrayList<E>
	{
	    /// <summary>
	    /// Gets the number of elements.
	    /// </summary>
	    public int Count
	    {
            [DexImport("size", "()I")]
            get { return Size(); }
	    }
    
        /// <summary>
        /// Gets/sets an element at the given index from/in this list.
        /// </summary>
        public E this[int index]
        {
            [DexImport("get", "(I)Ljava/lang/Object;")]
            get { return Get(index); }
            [DexImport("set", "(ILjava/lang/Object;)Ljava/lang/Object;")]
            set { Set(index, value); }
        }
    }
}

