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

using System.Globalization;
using Dot42;
using Java.Lang.Reflect;
using Java.Text;
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
            var fields = enumType.JavaGetDeclaredFields();
            var names = new ArrayList<string>();
            foreach (var field in fields)
            {
                if (!Modifier.IsStatic(field.GetModifiers()))
                    continue;
                if (field.Type != field.DeclaringClass)
                    continue;
                
                var name = field.Name;
                if (name[name.Length - 1] != '$')
                {
                    names.Add(name);
                }
            }
            return names.ToArray(new string[names.Count]);
        }

        /// <summary>
        /// Get the values of the constants in the given enum.
        /// </summary>
        public static Array GetValues(Type enumType)
        {
            var fields = enumType.JavaGetDeclaredFields();
            var values = new ArrayList<object>();
            foreach (var field in fields)
            {
                if (Modifier.IsStatic(field.GetModifiers()) && (field.Type == field.DeclaringClass))
                {
                    var name = field.Name;
                    if (name[name.Length - 1] != '$')
                    {
                        values.Add(field.Get(null));
                    }
                }
            }
            return values.ToArray();
        }

        /// <summary>
        /// Convert a string representation into an enum constant.
        /// </summary>
        public static object Parse(Type enumType, string name)
        {
            if (enumType == null)
                throw new ArgumentNullException("enumType");
            if (name == null)
                throw new ArgumentNullException("name");
            var fields = enumType.JavaGetDeclaredFields();
            foreach (var field in fields)
            {
                if (Modifier.IsStatic(field.GetModifiers()) && (field.Type == field.DeclaringClass))
                {
                    if (field.Name == name)
                    {
                        return field.Get(null);
                    }
                }
            }
            throw new ArgumentException("name");
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
            var fields = enumType.JavaGetDeclaredFields();
            foreach (var field in fields)
            {
                if (Modifier.IsStatic(field.GetModifiers()) && (field.Type == field.DeclaringClass))
                {
                    if ((!ignoreCase && (field.Name == name)) || (ignoreCase && field.Name.EqualsIgnoreCase(name)))
                    {
                        return field.Get(null);
                    }
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
            if (name == null)
                throw new ArgumentNullException("name");
            var enumType = typeof (TEnum);
            var fields = enumType.JavaGetDeclaredFields();
            foreach (var field in fields)
            {
                if (Modifier.IsStatic(field.GetModifiers()) && (field.Type == field.DeclaringClass))
                {
                    if (field.Name == name)
                    {
                        result = (TEnum)field.Get(null);
                        return true;
                    }
                }
            }
            result = default(TEnum);
            return false;
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
            var fields = enumType.JavaGetDeclaredFields();
            foreach (var field in fields)
            {
                if (Modifier.IsStatic(field.GetModifiers()) && (field.Type == field.DeclaringClass))
                {
                    if ((!ignoreCase && (field.Name == name)) 
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
            var vals = GetValues(enumType);
            if (vals.Length == 0) 
                return typeof (int);
            return vals[0].GetType();
        }

        public static object ToObject(Type enumType, object value)
        {
            var vals = GetValues(enumType);
            for(int i = 0; i < vals.Length; ++i)
            {
                int val = ((Java.Lang.Enum<object>)vals[i]).Ordinal();
                if (val.Equals(value))
                    return vals[i];
            }

            throw new InvalidOperationException("enum value not found: " + value);
        }

        // this will actually direcly be redirected by a call to the method by the compiler.
        public string ToString(string format)
        {
            return ((Dot42.Internal.Enum) (object)this).ToString(format);
        }

	}
}

