// Copyright (C) 2014 dot42
//
// Original filename: Nullable.cs
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
using Dot42;

namespace System
{
    public static class Nullable
    {
        public static int Compare<T>(T? n1, T? n2) where T : struct
        {
            if (n1.HasValue)
            {
                if (!n2.HasValue)
                    return 1;

                return Comparer<T>.Default.Compare(n1.RawValue, n2.RawValue);
            }

            return n2.HasValue ? -1 : 0;
        }

        public static bool Equals<T>(T? n1, T? n2) where T : struct
        {
            if (n1.HasValue != n2.HasValue)
                return false;

            if (!n1.HasValue)
                return true;

            return EqualityComparer<T>.Default.Equals(n1.RawValue, n2.RawValue);
        }

        public static bool Equals(bool? n1, bool? n2)
        {
            return (n1.HasValue == n2.HasValue) && ((!n1.HasValue) || (n1.RawValue == n2.RawValue));
        }
        public static bool Equals(byte? n1, byte? n2)
        {
            return (n1.HasValue == n2.HasValue) && ((!n1.HasValue) || (n1.RawValue == n2.RawValue));
        }
        public static bool Equals(sbyte? n1, sbyte? n2)
        {
            return (n1.HasValue == n2.HasValue) && ((!n1.HasValue) || (n1.RawValue == n2.RawValue));
        }
        public static bool Equals(char? n1, char? n2)
        {
            return (n1.HasValue == n2.HasValue) && ((!n1.HasValue) || (n1.RawValue == n2.RawValue));
        }
        public static bool Equals(short? n1, short? n2)
        {
            return (n1.HasValue == n2.HasValue) && ((!n1.HasValue) || (n1.RawValue == n2.RawValue));
        }
        public static bool Equals(ushort? n1, ushort? n2)
        {
            return (n1.HasValue == n2.HasValue) && ((!n1.HasValue) || (n1.RawValue == n2.RawValue));
        }
        public static bool Equals(int? n1, int? n2)
        {
            return (n1.HasValue == n2.HasValue) && ((!n1.HasValue) || (n1.RawValue == n2.RawValue));
        }
        public static bool Equals(uint? n1, uint? n2)
        {
            return (n1.HasValue == n2.HasValue) && ((!n1.HasValue) || (n1.RawValue == n2.RawValue));
        }
        public static bool Equals(long? n1, long? n2)
        {
            return (n1.HasValue == n2.HasValue) && ((!n1.HasValue) || (n1.RawValue == n2.RawValue));
        }
        public static bool Equals(ulong? n1, ulong? n2)
        {
            return (n1.HasValue == n2.HasValue) && ((!n1.HasValue) || (n1.RawValue == n2.RawValue));
        }
        public static bool Equals(double? n1, double? n2)
        {
            return (n1.HasValue == n2.HasValue) && ((!n1.HasValue) || (n1.RawValue == n2.RawValue));
        }
        public static bool Equals(float? n1, float? n2)
        {
            return (n1.HasValue == n2.HasValue) && ((!n1.HasValue) || (n1.RawValue == n2.RawValue));
        }


        public static Type GetUnderlyingType(Type nullableType)
        {
            if (nullableType == null)
                throw new ArgumentNullException("nullableType");
            if (nullableType.IsGenericType && nullableType.GetGenericTypeDefinition() == typeof(Nullable<>))
                return nullableType.GetGenericArguments()[0];
            else
                return null;
        }
    }

    [Serializable]
    public struct Nullable<T> where T : struct
    {
        public Nullable(T value)
        {
        }

        /// <summary>
        /// Does the this struct have a valid value?
        /// </summary>
        public bool HasValue
        {
            [DexNative]
            get { return false; }
        }

        /// <summary>
        /// Gets the value of this object without throwing error if it has no value.
        /// </summary>
        internal T RawValue
        {
            [DexNative]
            get { return default(T); }
        }

        /// <summary>
        /// Gets the value.
        /// </summary>
        /// <exception cref="InvalidOperationException">When this struct has no value.</exception>
        public T Value
        {
            [DexNative]
            get { return default(T); }
        }

        [Include]
        internal static T GetValue(object nullable, bool defaultOnNull)
        {
            if (ReferenceEquals(nullable, null))
            {
				if (defaultOnNull)
					return default(T);
				throw new InvalidOperationException("Nullable object must have a value.");
			}
            return (T)nullable;            
        }

        public /*override*/ int GetHashCode()
        {
            return !HasValue ? 0 : RawValue.GetHashCode();
        }

        [DexNative]
        public T GetValueOrDefault()
        {
            return HasValue ? RawValue : default(T);
        }

        public T GetValueOrDefault(T defaultValue)
        {
            return HasValue ? RawValue : defaultValue;
        }

        public override string ToString()
        {
            return HasValue ? RawValue.ToString() : String.Empty;
        }

        [DexNative]
        public static implicit operator Nullable<T>(T value)
        {
            return new Nullable<T>(value);
        }

        public static explicit operator T(Nullable<T> value)
        {
            return value.Value;
        }
    }
}

