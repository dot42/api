// Copyright (C) 2014 dot42
//
// Original filename: Delegate.cs
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
namespace System
{
	public abstract partial class Delegate
	{
        /// <summary>
        /// Concatenates an invocation list of 2 delegates.
        /// </summary>
        public static Delegate Combine(Delegate a, Delegate b)
        {
            if (a == null) return b;
            if (b == null) return a;
            a.Add(b);
            return a;
        }

        /// <summary>
        /// Remove the value delegate from the source delegate.
        /// </summary>
        public static Delegate Remove(Delegate source, Delegate value)
        {
            if (value == null) return source;
            return source.Remove(value);
        }

        /// <summary>
        /// Add the given delegate to the end of my invocation list.
        /// </summary>
	    protected abstract void Add(Delegate other);

        /// <summary>
        /// Add the given delegate from my invocation list.
        /// </summary>
        protected abstract Delegate Remove(Delegate other);
    }
}

