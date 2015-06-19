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
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using Dot42.Collections.Specialized;
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
        private static readonly ConcurrentHashMap<Type, EnumInfo> enumInfo = new ConcurrentHashMap<Type, EnumInfo>();

        private Enum defaultValue;
        public readonly Type Underlying;

        private class ValuesByUnderlying
        {
            public IntIntMap IntMap;
            public LongIntMap LongMap;
            public Enum[] CreatedEnums;
        }

        private ValuesByUnderlying valuesByUnderlying;

        private readonly ArrayList<Enum> values = new ArrayList<Enum>();
        private readonly HashMap<string, Enum> valuesByName = new HashMap<string, Enum>();
        private HashMap<string, Enum> valuesByUpperCase;

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
            if (value == 0 && defaultValue != null)
            {
                return defaultValue;
            }

            if (Underlying == typeof(long))
                return GetValue((long)value);

            if (valuesByUnderlying == null)
            {
                var lookup = InitializeIntLookup();
                Interlocked.CompareExchange(ref valuesByUnderlying, lookup, null);
            }

            // to keep this scalable, we use a lock-free implementation
            while (true)
            {
                var vals = valuesByUnderlying;
                int idx = vals.IntMap.Get(value);

                if (idx != IntIntMap.NoValue)
                {
                    if (idx >= 0)
                        return values[idx];
                    return vals.CreatedEnums[-idx - 1];
                }

                // insert a new value into a new instance
                var newEnum = Create(value);

                if (!AddNewIntEnum(vals, value, newEnum)) 
                    continue;

                return newEnum;
            }
        }

        /// <summary>
        /// Gets a value with the given underlying value.
        /// </summary>
        [Include(TypeCondition = typeof(System.Enum))]
        public Enum GetValue(long value)
        {
            if (value == 0 && defaultValue != null)
            {
                return defaultValue;
            }

            if(Underlying != typeof(long))
                return GetValue((int)value);

            // we set up our own data structure, to make sure 
            // there is no boxing on this possibly heavy used path.
            // even better might be a long-based hashmap instead of
            // the binary search.

            if (valuesByUnderlying == null)
            {
                var lookup = InitializeLongLookup();
                Interlocked.CompareExchange(ref valuesByUnderlying, lookup, null);
            }

            // to keep this scalable, we use a lock-free implementation
            while (true)
            {
                var vals = valuesByUnderlying;
                int idx = vals.LongMap.Get(value);

                if (idx != IntIntMap.NoValue)
                {
                    if (idx >= 0)
                        return values[idx];
                    return vals.CreatedEnums[-idx - 1];
                }

                // insert a new value into a new instance
                var newEnum = Create(value);

                if (!AddNewLongEnum(vals, value, newEnum))
                    continue;

                return newEnum;
            }
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
                if (valuesByUpperCase == null)
                    InitializeValuesByUpperCaseName();

                value = value.ToUpperInvariant();
                hashMap = valuesByUpperCase;
                Debug.Assert(hashMap != null);
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

        private void InitializeValuesByUpperCaseName()
        {
            lock (valuesByName)
            {
                valuesByUpperCase = new HashMap<string, Enum>();
                foreach (var entry in valuesByName.EntrySet().AsEnumerable())
                {
                    valuesByUpperCase.Put(entry.Key.ToUpperInvariant(), entry.Value);
                }
            }
        }

        /// <summary>
        /// Add a given instance. This is only called from the static initializer of each enum.
        /// (and might better be protected and called from the constructor of an enum info)
        /// </summary>
        [Include(TypeCondition = typeof(System.Enum))]
        public void Add(int value, string name, Enum instance)
        {
            values.Add(instance);
            valuesByName.Put(name, instance);
        }

        /// <summary>
        /// Add a given instance. This is only called from the static initializer of each enum.
        /// (and might better be protected and called from the constructor of an enum info)
        /// </summary>
        [Include(TypeCondition = typeof(System.Enum))]
        public void Add(long value, string name, Enum instance)
        {
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

        private ValuesByUnderlying InitializeIntLookup()
        {
            var vals = new IntIntMap(values.Count + 1, 0.75f);

            for (int i = 0; i < values.Count; ++i)
            {
                var value = values[i].IntValue();
                if (vals.Get(value) == IntIntMap.NoValue)
                    vals.Put(value, i);
            }

            return new ValuesByUnderlying {IntMap = vals};
        }

        private bool AddNewIntEnum(ValuesByUnderlying vals, int enumValue, Enum newEnum)
        {
            // create new data structure
            var lookup = InitializeIntLookup();
            var map = lookup.IntMap;

            var prevEnums = vals.CreatedEnums;
            int prevLen;
            if (prevEnums == null)
            {
                prevLen = 0;
                lookup.CreatedEnums = new[] {newEnum};
            }
            else
            {
                prevLen = prevEnums.Length;
                lookup.CreatedEnums = Arrays.CopyOf(prevEnums, prevLen + 1);
                lookup.CreatedEnums[prevLen] = newEnum;

                for (int i = 0; i < prevLen; ++i)
                {
                    map.Put(prevEnums[i].IntValue(), -i - 1);
                }
            }

            map.Put(enumValue, -prevLen - 1);

            // only update if no one else was faster.
            return Interlocked.CompareExchange(ref valuesByUnderlying, lookup, vals) == vals;
        }

        private ValuesByUnderlying InitializeLongLookup()
        {
            var vals = new LongIntMap(values.Count + 1, 0.75f);

            for (int i = 0; i < values.Count; ++i)
            {
                var value = values[i].LongValue();
                if (vals.Get(value) == LongIntMap.NoValue)
                    vals.Put(value, i);
            }

            return new ValuesByUnderlying { LongMap = vals };
        }

        private bool AddNewLongEnum(ValuesByUnderlying vals, long enumValue, Enum newEnum)
        {
            // create new data structure
            var lookup = InitializeLongLookup();
            var map = lookup.LongMap;

            var prevEnums = vals.CreatedEnums;
            int prevLen;
            if (prevEnums == null)
            {
                prevLen = 0;
                lookup.CreatedEnums = new[] { newEnum };
            }
            else
            {
                prevLen = prevEnums.Length;
                lookup.CreatedEnums = Arrays.CopyOf(prevEnums, prevLen + 1);
                lookup.CreatedEnums[prevLen] = newEnum;

                for (int i = 0; i < prevLen; ++i)
                {
                    map.Put(prevEnums[i].LongValue(), -i - 1);
                }
            }

            map.Put(enumValue, -prevLen - 1);

            // only update if no one else was faster.
            return Interlocked.CompareExchange(ref valuesByUnderlying, lookup, vals) == vals;
        }
    }
}

