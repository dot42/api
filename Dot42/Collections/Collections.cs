// Copyright (C) 2014 dot42
//
// Original filename: Collections.cs
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

namespace Dot42.Collections
{
	internal static class Collections
	{
        /// <summary>
        /// Copy all my elements to the given array starting at the given index.
        /// </summary>
        /// <param name="collection">Source to copy from</param>
        /// <param name="array">Array to copy my elements into.</param>
        /// <param name="index">Position in <see cref="array"/> where the first element will be copied to.</param>
        public static void CopyTo<E>(Java.Util.ICollection<E> collection, E[] array, int index)
        {
            if (index == 0)
            {
                collection.ToArray(array);
            }
            else
            {
                var all = collection.ToArray(new E[0]);
                for (var i = 0; i < all.Length; i++)
                {
                    array[index + i] = all[i];
                }
            }
        }

        /// <summary>
        /// Copy all my elements to the given array starting at the given index.
        /// </summary>
        /// <param name="collection">Source to copy from</param>
        /// <param name="array">Array to copy my elements into.</param>
        /// <param name="index">Position in <see cref="array"/> where the first element will be copied to.</param>
        public static void CopyTo<E>(Java.Util.ICollection<E> collection, Array array, int index)
        {
            var all = collection.ToArray(new E[0]);
            for (var i = 0; i < all.Length; i++)
            {
                array[index + i] = all[i];
            }
        }

        /// <summary>
        /// Copy all my elements to the given array starting at the given index.
        /// </summary>
        /// <param name="collection">Source to copy from</param>
        /// <param name="array">Array to copy my elements into.</param>
        /// <param name="index">Position in <see cref="array"/> where the first element will be copied to.</param>
        public static void CopyTo<E>(System.Collections.Generic.ICollection<E> collection, Array array, int index)
        {
            foreach (var elem in collection)
            {
                array[index++] = elem;
            }
        }

        /// <summary>
        /// Copy all my elements to the given array starting at the given index.
        /// </summary>
        /// <param name="collection">Source to copy from</param>
        /// <param name="array">Array to copy my elements into.</param>
        /// <param name="index">Position in <see cref="array"/> where the first element will be copied to.</param>
        public static void CopyTo<E>(System.Collections.Generic.ICollection<E> collection, E[] array, int index)
        {
            foreach (var elem in collection)
            {
                array[index++] = elem;
            }
        }
	}
}

