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

using System;
using Java.Util;
using Java.Util.Concurrent;

namespace Dot42.Internal
{
    /// <summary>
    /// Base class for enum implementations
    /// </summary>
    [Include(TypeCondition = typeof(System.Enum))]
    internal abstract class EnumInfo 
	{
        private static ConcurrentHashMap<Type, EnumInfo> enumInfo = new ConcurrentHashMap<Type, EnumInfo>();

        public readonly Type Underlying;

        private Enum defaultValue;

        private readonly ConcurrentHashMap<object, Enum> valuesByUnderlying = new ConcurrentHashMap<object, Enum>();
        
        private readonly ArrayList<Enum> values = new ArrayList<Enum>();
        private readonly HashMap<string, Enum> valuesByName = new HashMap<string, Enum>();
        private HashMap<string, Enum> valuesByLowerCaseName;

        public EnumInfo(Type underlying)
        {
            Underlying = underlying;
        }

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

        [Include(TypeCondition = typeof (System.Enum))]
        public Enum DefaultValue()
        {
            if (defaultValue == null)
            {
                defaultValue = Underlying == typeof(long)
                                ? GetValue(0L) 
                                : GetValue(0);
            }
            return defaultValue;
        }

        [Include(TypeCondition = typeof (System.Enum))]
        public Array Values()
        {
            var array = Java.Lang.Reflect.Array.NewInstance(DefaultValue().GetType(), values.Count);
            return values.ToArray((object[])array);
        }

        /// <summary>
        /// Gets a value with the given underlying value.
        /// </summary>
        [Include(TypeCondition = typeof(System.Enum))]
        public Enum GetValue(int value)
        {
            var result = valuesByUnderlying.Get(value);
            if (ReferenceEquals(result, null))
            {
                result = Create(value);
                result = valuesByUnderlying.PutIfAbsent(value, result) 
                         ?? result;
            }
            return result;
        }

        /// <summary>
        /// Gets a value with the given underlying value.
        /// </summary>
        [Include(TypeCondition = typeof(System.Enum))]
        public Enum GetValue(long value)
        {
            var result = valuesByUnderlying.Get(value);
            if (ReferenceEquals(result, null))
            {
                result = Create(value);
                result = valuesByUnderlying.PutIfAbsent(value, result)
                         ?? result;
            }
            return result;
        }

        /// <summary>
        /// Gets a value with the given underlying value.
        /// </summary>
        [Include(TypeCondition = typeof(System.Enum))]
        public Enum Parse(string value, bool ignoreCase, bool throwIfNotFound)
        {
            HashMap<string, Enum> hashMap;

            if (ignoreCase)
            {
                 if (valuesByLowerCaseName == null)
                {
                    lock (valuesByName)
                    {
                        valuesByLowerCaseName = new HashMap<string, Enum>();
                        foreach (string name in valuesByName.KeySet().AsEnumerable())
                        {
                            valuesByLowerCaseName.Put(name.ToLowerInvariant(), valuesByName.Get(name));
                        }
                    }
                }
                value = value.ToLowerInvariant();
                hashMap = valuesByLowerCaseName;
            }
            else
            {
                hashMap = valuesByName;
            }

            var ret = hashMap.Get(value);
            if(ret == null && throwIfNotFound)
                throw new ArgumentException();
            return ret;
        }

        /// <summary>
        /// Add a given instance.
        /// </summary>
        [Include(TypeCondition = typeof(System.Enum))]
        public void Add(int value, string name, Enum instance)
        {
            valuesByUnderlying.PutIfAbsent(value, instance);
            values.Add(instance);
            valuesByName.Put(name, instance);
        }

        /// <summary>
        /// Add a given instance.
        /// </summary>
        [Include(TypeCondition = typeof(System.Enum))]
        public void Add(long value, string name, Enum instance)
        {
            valuesByUnderlying.PutIfAbsent(value, instance);
            values.Add(instance);
            valuesByName.Put(name, instance);
        }

        [Include(TypeCondition = typeof(System.Enum))]
        public static EnumInfo GetEnumInfo(Type enumType)
        {
            var info = enumInfo.Get(enumType);
            if (info == null)
            {
                var infoField = enumType.JavaGetDeclaredField("info$");
                info = (EnumInfo) infoField.Get(null);
                enumInfo.Put(enumType, info);
            }

            return info;
        }
    }
}

