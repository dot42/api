// Copyright (C) 2014 dot42
//
// Original filename: SmallLinq.cs
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
using Java.Util;
using Java.Lang.Reflect;
using Array = Java.Lang.Reflect.Array;

namespace Dot42
{
    /// <summary>
    /// Android optimized Linq methods.
    /// </summary>
	internal static class SmallLinq
	{
        /// <summary>
        /// Create a filtered array.
        /// </summary>
        public static T[] Where<T>(this T[] array, Func<T, bool> predicate)
        {
            if ((array == null) || (array.Length == 0))
                return array;
            ArrayList<T> list = null;
            foreach (var item in array)
            {
                if (predicate(item))
                {
                    if (list == null) list = new ArrayList<T>(array.Length);
                    list.Add(item);
                }
            }
            var elementType = array.GetType().JavaGetComponentType();
            if (list == null) return (T[])Array.NewInstance(elementType, 0);
            return list.ToArray((T[])Array.NewInstance(elementType, list.Count));
        }

        public static T FirstOrDefault<T>(this T[] array, Func<T, bool> predicate)
        {
            int len = array.Length;
            for (int i = 0; i < len; ++i)
            {
                if (predicate(array[i]))
                    return array[i];
            }
            return default(T);
        }

        public static T FirstOrDefault<T>(this T[] array)
        {
            int len = array.Length;
            if (len == 0) return default(T);
            return array[0];
        }

        public static T[] Take<T>(this T[] array, int count)
        {
            var len = Math.Min(count, array.Length);    
            T[] ret = new T[len];
            System.Array.Copy(array, ret, len);
            return ret;
        }

        public static T Last<T>(this T[] array)
        {
            int len = array.Length;
            return array[len-1];
        }

        public static TOut[] Select<TIn,TOut>(this TIn[] array, Func<TIn, TOut> select)
        {
            if ((array == null) || (array.Length == 0))
                return new TOut[0];

            var ret = new TOut[array.Length];

            for (int i = 0; i < array.Length; ++i)
                ret[i] = select(array[i]);

            return ret;
        }
	}
}

