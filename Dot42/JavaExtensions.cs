// Copyright (C) 2014 dot42
//
// Original filename: JavaExtensions.cs
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
using Dot42.Collections;
using Java.Lang;

namespace Dot42
{
    /// <summary>
    /// Extensions method intended to easy working with java classes.
    /// </summary>
	public static class JavaExtensions
	{
        public static IEnumerable<T> AsEnumerable<T>(this IIterable<T> iterable)
        {
            return (iterable == null) ? null : new IterableWrapper<T>(iterable);
        }
	}
}

