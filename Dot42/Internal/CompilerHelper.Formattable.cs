// Copyright (C) 2014 dot42
//
// Original filename: CompilerHelper.Formattable.cs
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
    /// IFormattable support for primitive types.
    /// </summary>
    partial class CompilerHelper
    {
        /// <summary>
        /// Is the given object instanceof IFormattable but not in dot42.
        /// </summary>
        [Include(TypeCondition = typeof(IFormattable))]
        public static bool IsVirtualFormattable(object value)
        {
            if (value == null) return false;
            var type = value.JavaGetClass();
            return (type == TypeHelper.ByteType())    ||
                   (type == TypeHelper.ShortType())   ||
                   (type == TypeHelper.IntegerType()) ||
                   (type == TypeHelper.LongType())    ||
                   (type == TypeHelper.FloatType())   ||
                   (type == TypeHelper.DoubleType()   ||
                   (type == typeof(Type)));
        }

        /// <summary>
        /// Wrap the primitive object in a formattable interface.
        /// </summary>
        [Include(TypeCondition = typeof(IFormattable))]
        public static IFormattable AsFormattable(object value)
        {
            if (value == null) return null;
            var type = value.JavaGetClass();
            if (type == TypeHelper.ByteType()) return new FormattableByte((byte)value);
            if (type == TypeHelper.ShortType()) return new FormattableShort((short) value);
            if (type == TypeHelper.IntegerType()) return new FormattableInt((int) value);
            if (type == TypeHelper.LongType()) return new FormattableLong((long) value);
            if (type == TypeHelper.FloatType()) return new FormattableFloat((float) value);
            if (type == TypeHelper.DoubleType()) return new FormattableDouble((double) value);
            if (type == typeof(Type)) return new FormattableType((Type)value);
            return null;
        }

        /// <summary>
        /// Wrap the primitive object in a formattable interface.
        /// </summary>
        [Include(TypeCondition = typeof (IFormattable))]
        public static IFormattable CastToFormattable(object value)
        {
            if (value == null) return null;
            var formattable = value as IFormattable;
            if (formattable == null) throw new InvalidCastException();
            return formattable;
        }

        /// <summary>
        /// plain 'as IFormattable'  without any virtual formattables.
        /// </summary>
        [Include(TypeCondition = typeof(IFormattable))][DexNative]
        public static IFormattable AsNativeFormattable(object value)
        {
            return null;
        }

        /// <summary>
        /// Formattable for bytes.
        /// </summary>
        [Include(TypeCondition = typeof(IFormattable))]
        private sealed class FormattableByte : IFormattable
        {
            private readonly byte value;

            /// <summary>
            /// Default ctor
            /// </summary>
            public FormattableByte(byte value)
            {
                this.value = value;
            }

            public string ToString(string format, IFormatProvider formatProvider)
            {
                return value.ToString(format, formatProvider);
            }
        }

        /// <summary>
        /// Formattable for short.
        /// </summary>
        [Include(TypeCondition = typeof(IFormattable))]
        private sealed class FormattableShort : IFormattable
        {
            private readonly short value;

            /// <summary>
            /// Default ctor
            /// </summary>
            public FormattableShort(short value)
            {
                this.value = value;
            }

            public string ToString(string format, IFormatProvider formatProvider)
            {
                return value.ToString(format, formatProvider);
            }
        }

        /// <summary>
        /// Formattable for int.
        /// </summary>
        [Include(TypeCondition = typeof(IFormattable))]
        private sealed class FormattableInt : IFormattable
        {
            private readonly int value;

            /// <summary>
            /// Default ctor
            /// </summary>
            public FormattableInt(int value)
            {
                this.value = value;
            }

            public string ToString(string format, IFormatProvider formatProvider)
            {
                return value.ToString(format, formatProvider);
            }
        }

        /// <summary>
        /// Formattable for long.
        /// </summary>
        [Include(TypeCondition = typeof(IFormattable))]
        private sealed class FormattableLong : IFormattable
        {
            private readonly long value;

            /// <summary>
            /// Default ctor
            /// </summary>
            public FormattableLong(long value)
            {
                this.value = value;
            }

            public string ToString(string format, IFormatProvider formatProvider)
            {
                return value.ToString(format, formatProvider);
            }
        }

        /// <summary>
        /// Formattable for float.
        /// </summary>
        [Include(TypeCondition = typeof(IFormattable))]
        private sealed class FormattableFloat : IFormattable
        {
            private readonly float value;

            /// <summary>
            /// Default ctor
            /// </summary>
            public FormattableFloat(float value)
            {
                this.value = value;
            }

            public string ToString(string format, IFormatProvider formatProvider)
            {
                return value.ToString(format, formatProvider);
            }
        }

        /// <summary>
        /// Formattable for double.
        /// </summary>
        [Include(TypeCondition = typeof(IFormattable))]
        private sealed class FormattableDouble : IFormattable
        {
            private readonly double value;

            /// <summary>
            /// Default ctor
            /// </summary>
            public FormattableDouble(double value)
            {
                this.value = value;
            }

            public string ToString(string format, IFormatProvider formatProvider)
            {
                return value.ToString(format, formatProvider);
            }
        }

        /// <summary>
        /// Formattable for Type
        /// </summary>
        [Include(TypeCondition = typeof(IFormattable))]
        private sealed class FormattableType : IFormattable
        {
            private readonly Type value;

            /// <summary>
            /// Default ctor
            /// </summary>
            public FormattableType(Type value)
            {
                this.value = value;
            }

            public string ToString(string format, IFormatProvider formatProvider)
            {
                return value.FullName;
            }
        }
    }
}

