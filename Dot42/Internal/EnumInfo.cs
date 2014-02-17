// Copyright (C) 2014 dot42
//
// Original filename: EnumInfo.cs
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
using Java.Util;

namespace Dot42.Internal
{
    /// <summary>
    /// Base class for enum implementations
    /// </summary>
    [Include(TypeCondition = typeof(System.Enum))]
    internal abstract class EnumInfo 
	{
        private readonly object dataLock = new object();
        private readonly HashMap<object, Enum> customValues = new HashMap<object, Enum>();

        /// <summary>
        /// Create a new instance with given underlying value
        /// </summary>
        [Include(TypeCondition = typeof(System.Enum))]
        protected virtual Enum Create(int value)
        {
            return null;
        }

        /// <summary>
        /// Create a new instance with given underlying value
        /// </summary>
        [Include(TypeCondition = typeof(System.Enum))]
        protected virtual Enum Create(long value)
        {
            return null;
        }

        /// <summary>
        /// Gets a value with the given underlying value.
        /// </summary>
        [Include(TypeCondition = typeof(System.Enum))]
        internal Enum GetValue(int value)
        {
            lock (dataLock)
            {
                var result = customValues.Get(value);
                if (ReferenceEquals(result, null))
                {
                    result = Create(value);
                    customValues.Put(value, result);
                }
                return result;
            }
        }

        /// <summary>
        /// Gets a value with the given underlying value.
        /// </summary>
        [Include(TypeCondition = typeof(System.Enum))]
        internal Enum GetValue(long value)
        {
            lock (dataLock)
            {
                var result = customValues.Get(value);
                if (ReferenceEquals(result, null))
                {
                    result = Create(value);
                    customValues.Put(value, result);
                }
                return result;
            }
        }

        /// <summary>
        /// Add a given instance.
        /// </summary>
        [Include(TypeCondition = typeof(System.Enum))]
        internal void Add(int value, Enum instance)
        {
            lock (dataLock)
            {
                customValues.Put(value, instance);
            }            
        }

        /// <summary>
        /// Add a given instance.
        /// </summary>
        [Include(TypeCondition = typeof(System.Enum))]
        internal void Add(long value, Enum instance)
        {
            lock (dataLock)
            {
                customValues.Put(value, instance);
            }
        }
    }
}

