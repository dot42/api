// Copyright (C) 2014 dot42
//
// Original filename: Enum.cs
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

namespace Dot42.Internal
{
    /// <summary>
    /// Base class for enum implementations
    /// </summary>
    [Include(TypeCondition = typeof(System.Enum))]
    internal abstract class Enum : Java.Lang.Enum<Enum>, IFormattable
	{
        /// <summary>
        /// Default ctor
        /// </summary>
        [Include(TypeCondition = typeof(System.Enum))]
        protected Enum(string name, int ordinal)
            : base(name, ordinal)
        {            
        }

        /// <summary>
        /// Gets the underlying value as int.
        /// </summary>
        [Include(TypeCondition = typeof(System.Enum))]
        public virtual int IntValue()
        {
            return (int)LongValue();
        }

        /// <summary>
        /// Gets the underlying value as long.
        /// </summary>
        [Include(TypeCondition = typeof(System.Enum))]
        public virtual long LongValue()
        {
            return (long)IntValue();
        }

        [Include(TypeCondition = typeof(System.Enum))]
        public static Enum Get(System.Type enumType, int value)
        {
            var info = EnumInfo.GetEnumInfo(enumType);

            var result = info.GetValue(value);
            if (result == null)
                throw new ArgumentException();

            return result;
        }

        [Include(TypeCondition = typeof(System.Enum))]
        public static Enum Get(System.Type enumType, long value)
        {
            var info = EnumInfo.GetEnumInfo(enumType);

            var result = info.GetValue(value);

            if (result == null)
                throw new ArgumentException();
            
            return result;
        }

        /// <summary>
        /// Value should be java.lang.Integer, java.lang.Long, java.lang.Short,
        /// java.lang.Byte or another Enum type.
        /// </summary>
        [Include(TypeCondition = typeof(System.Enum))]
        public static Enum GetFromObject(System.Type enumType, object value)
        {
            var info = EnumInfo.GetEnumInfo(enumType);

            bool isLong = info.Underlying == typeof(long);

            if (isLong)
            {
                if (value is long)
                    return Get(enumType, (long)value);
                if (value is int)
                    return Get(enumType, (long)(int)value);
                if (value is short)
                    return Get(enumType, (long)(short)value);
                if (value is char)
                    return Get(enumType, (long)(char)value);
                if (value is byte)
                    return Get(enumType, (long)(byte)value);
                if (value is Enum)
                    return Get(enumType, ((Enum)value).LongValue());
            }
            else
            {
                if (value is long)
                    return Get(enumType, (int)(long)value);
                if (value is int)
                    return Get(enumType, (int)value);
                if (value is short)
                    return Get(enumType, (int)(short)value);
                if (value is char)
                    return Get(enumType, (int)(char)value);
                if (value is byte)
                    return Get(enumType, (int)(byte)value);
                if (value is Enum)
                    return Get(enumType, ((Enum)value).IntValue());
            }

            throw new ArgumentException(string.Format("type: {0}; val: {1}", value.GetType(), value.ToString()), "value");
        }

        public string ToString(string format)
        {
            return CompilerHelper.EnumToString((Java.Lang.Enum<object>)(object)this, format);
        }


        public string ToString(string format, IFormatProvider formatProvider)
        {
            return CompilerHelper.EnumToString((Java.Lang.Enum<object>)(object)this, format);
        }
	}
}

