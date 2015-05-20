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

using System.Linq;
using Dot42.Internal;
using Java.Lang;
using Java.Lang.Reflect;
using Java.Util;

namespace System
{
    public abstract partial class Enum
	{
        /// <summary>
        /// Gets the name of the given enum constant or null if not found.
        /// </summary>
        public static string GetName(Type enumType, object value)
        {
            if (value == null)
                throw new ArgumentNullException();
            return ((Java.Lang.Enum<object>) value).Name();
        }

        /// <summary>
        /// Returns an indication whether a constant with a specified value exists in a specified enumeration.
        /// </summary>
        public static bool IsDefined(Type enumType, object value)
        {
            return (GetName(enumType, value) != null);
        }

        /// <summary>
        /// Gets the names of the enum constant in the given enum type.
        /// </summary>
        public static string[] GetNames(Type enumType)
        {
            var values = (Enum<object>[])GetValues(enumType);
            string[] ret = new string[values.Length];

            for (int i = 0; i < ret.Length; ++i)
                ret[i] = values[i].Name();

            return ret;
        }

        /// <summary>
        /// Get the values of the constants in the given enum.
        /// </summary>
        public static Array GetValues(Type enumType)
        {
            if (typeof (Dot42.Internal.Enum).JavaIsAssignableFrom(enumType))
            {
                var info = EnumInfo.GetEnumInfo(enumType);
                return info.Values();
            }

            // Fallback for java enums (do we need this?)
            var fields = enumType.JavaGetDeclaredFields();
            var values = new ArrayList<object>();

            foreach (var field in fields)
            {
                if (!IsEnumMember(field)) continue;
                values.Add(field.Get(null));
            }

            return values.OrderBy(p => p).ToArray();
        }

        private static bool IsEnumMember(Field field)
        {
            return Modifier.IsStatic(field.Modifiers)
                   &&  field.Type == field.DeclaringClass
                   && !field.IsSynthetic
                   && !field.Name.EndsWith("$");
        }

        /// <summary>
        /// Convert a string representation into an enum constant.
        /// </summary>
        public static object Parse(Type enumType, string name)
        {
            return Parse(enumType, name, false);
        }

        /// <summary>
        /// Convert a string representation into an enum constant.
        /// </summary>
        public static object Parse(Type enumType, string name, bool ignoreCase)
        {
            if (enumType == null)
                throw new ArgumentNullException("enumType");
            if (name == null)
                throw new ArgumentNullException("name");

            if (typeof(Dot42.Internal.Enum).JavaIsAssignableFrom(enumType))
            {
                var info = EnumInfo.GetEnumInfo(enumType);
                return info.Parse(name, ignoreCase, true);
            }

            // fallback
            var fields = enumType.JavaGetDeclaredFields();
            foreach (var field in fields)
            {
                if (!IsEnumMember(field)) continue;
                if ((!ignoreCase && field.Name == name) || (ignoreCase && field.Name.EqualsIgnoreCase(name)))
                {
                    return field.Get(null);
                }
            }
            throw new ArgumentException("name");
        }

        /// <summary>
        /// Try to convert a string representation into an enum constant.
        /// </summary>
        public static bool TryParse<TEnum>(string name, out TEnum result)
            where TEnum : struct 
        {
            return TryParse(name, false, out result);
        }

        /// <summary>
        /// Try to convert a string representation into an enum constant.
        /// </summary>
        public static bool TryParse<TEnum>(string name, bool ignoreCase, out TEnum result)
            where TEnum : struct
        {
            if (name == null)
                throw new ArgumentNullException("name");

            var enumType = typeof(TEnum);
            if (typeof(Dot42.Internal.Enum).JavaIsAssignableFrom(enumType))
            {
                var info = EnumInfo.GetEnumInfo(enumType);
                var ret = info.Parse(name, ignoreCase, false);
                if (ret != null)
                {
                    result = (TEnum)(object)ret;
                    return true;
                }
                result = (TEnum)(object)info.DefaultValue();
                return false;
            }

            // fallback.
            var fields = enumType.JavaGetDeclaredFields();
            foreach (var field in fields)
            {
                if (!IsEnumMember(field)) continue;
                {
                    if ((!ignoreCase && field.Name == name) 
                      || (ignoreCase && field.Name.EqualsIgnoreCase(name)))
                    {
                        result = (TEnum)field.Get(null);
                        return true;
                    }
                }
            }
            result = default(TEnum);
            return false;
        }

        public static Type GetUnderlyingType(Type enumType)
        {
            if(!enumType.IsEnum)
                throw new ArgumentException("enumType");

            if (typeof(Dot42.Internal.Enum).JavaIsAssignableFrom(enumType))
            {
                var info = EnumInfo.GetEnumInfo(enumType);
                return info.Underlying;
            }

            return typeof (int);
        }

        public static object ToObject(Type enumType, object value)
        {
            if (typeof (Dot42.Internal.Enum).IsAssignableFrom(enumType))
            {
                return Dot42.Internal.Enum.GetFromObject(enumType, value);
            }

            // Fallback for java enums.
            var vals = GetValues(enumType);
            int val = Convert.ToInt32(value);

            for(int i = 0; i < vals.Length; ++i)
            {
                int e = ((Java.Lang.Enum<object>)vals[i]).Ordinal();
                
                if(val == e)
                    return vals[i];
            }

            throw new InvalidOperationException("enum value not found: " + value);
        }

        // this will actually be redirected by the compiler, and never be called.
        public string ToString(string format)
        {
            // keep the call though, so that the compiler knows he has to include the target method
            return ((Dot42.Internal.Enum)(object)this).ToString(format);
        }

	}
}

