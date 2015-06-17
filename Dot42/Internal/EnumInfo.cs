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

        private Enum defaultValue;
        public readonly Type Underlying;

        private class ValuesByUnderlying
        {
            public long[]   LongValues;
            public int[]    IntValues;
            public Enum[]   EnumValues;
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
            if (Underlying == typeof(long))
                return GetValue((long)value);

            // we set up our own data structure, to make sure 
            // there is no boxing on this possibly heavy used path.
            // even better might be an int-based hashmap instead of
            // the binary search.

            if (valuesByUnderlying == null)
                InitializeIntLookup();

            while (true)
            {
                var vals = valuesByUnderlying;

                int idx = Arrays.BinarySearch(vals.IntValues, value);
                if (idx >= 0)
                    return vals.EnumValues[idx];

                // insert a new value into a new instance
                int newIdx = -(idx + 1);
                var newEnum = Create(value);

                if (!InsertNewIntEnum(vals, newIdx, newEnum)) 
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
            if(Underlying != typeof(long))
                return GetValue((int)value);

            // we set up our own data structure, to make sure 
            // there is no boxing on this possibly heavy used path.
            // even better might be a long-based hashmap instead of
            // the binary search.

            if (valuesByUnderlying == null)
                InitializeLongLookup();

            while (true)
            {
                var vals = valuesByUnderlying;

                int idx = Arrays.BinarySearch(vals.LongValues, value);
                if (idx >= 0)
                    return vals.EnumValues[idx];

                // insert a new value into a new instance
                int newIdx = -(idx + 1);
                var newEnum = Create(value);

                if (!InsertNewLongEnum(vals, newIdx, newEnum))
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

        private void InitializeIntLookup()
        {
            // initialize our binary search structure.
            var vals = new ValuesByUnderlying();

            var sortedValues = values.AsEnumerable()
                .Distinct(new EnumIntValueEqualityComparer())
                .OrderBy(e => e.IntValue())
                .ToList();

            int len = sortedValues.Count;

            vals.EnumValues = values.ToArray(new Enum[len]);
            vals.IntValues = vals.EnumValues.Select(p => p.IntValue());

            Interlocked.CompareExchange(ref valuesByUnderlying, vals, null);
        }

        private bool InsertNewIntEnum(ValuesByUnderlying vals, int newIdx, Enum newEnum)
        {
            int i;
            var newLen = vals.IntValues.Length + 1;
            var newVals = new ValuesByUnderlying
            {
                IntValues = new int[newLen],
                EnumValues = new Enum[newLen]
            };

            for (i = 0; i < newIdx; ++i)
            {
                newVals.IntValues[i] = vals.IntValues[i];
                newVals.EnumValues[i] = vals.EnumValues[i];
            }
            newVals.IntValues[newIdx] = newEnum.IntValue();
            newVals.EnumValues[newIdx] = newEnum;
            for (i = newIdx + 1; i < newLen; ++i)
            {
                newVals.IntValues[i]  = vals.IntValues[i - 1];
                newVals.EnumValues[i] = vals.EnumValues[i - 1];
            }

            // only update if no one else was faster.
            return Interlocked.CompareExchange(ref valuesByUnderlying, newVals, vals) == vals;
        }

        private void InitializeLongLookup()
        {
            // initialize our binary search structure.
            var vals = new ValuesByUnderlying();

            var sortedValues = values.AsEnumerable()
                                     .Distinct(new EnumIntValueEqualityComparer())
                                     .OrderBy(e => e.LongValue())
                                     .ToList();

            int len = sortedValues.Count;

            vals.EnumValues = values.ToArray(new Enum[len]);
            vals.LongValues = vals.EnumValues.Select(p => p.LongValue());

            Interlocked.CompareExchange(ref valuesByUnderlying, vals, null);
        }

        private bool InsertNewLongEnum(ValuesByUnderlying vals, int newIdx, Enum newEnum)
        {
            int i;
            var newLen = vals.LongValues.Length + 1;
            var newVals = new ValuesByUnderlying
            {
                LongValues = new long[newLen],
                EnumValues = new Enum[newLen]
            };

            for (i = 0; i < newIdx; ++i)
            {
                newVals.LongValues[i] = vals.LongValues[i];
                newVals.EnumValues[i] = vals.EnumValues[i];
            }
            newVals.LongValues[newIdx] = newEnum.LongValue();
            newVals.EnumValues[newIdx] = newEnum;
            for (i = newIdx + 1; i < newLen; ++i)
            {
                newVals.LongValues[i] = vals.LongValues[i - 1];
                newVals.EnumValues[i] = vals.EnumValues[i - 1];
            }

            // only update if no one else was faster.
            return Interlocked.CompareExchange(ref valuesByUnderlying, newVals, vals) == vals;
        }

        private class EnumIntValueEqualityComparer : IEqualityComparer<Enum>
        {
            public bool Equals(Enum x, Enum y)
            {
                return x.IntValue() == y.IntValue();
            }

            public int GetHashCode(Enum obj)
            {
                return obj.IntValue();
            }
        }

        private class EnumLongValueEqualityComparer : IEqualityComparer<Enum>
        {
            public bool Equals(Enum x, Enum y)
            {
                return x.LongValue() == y.LongValue();
            }

            public int GetHashCode(Enum obj)
            {
                return (int)obj.LongValue();
            }
        }
    }
}

