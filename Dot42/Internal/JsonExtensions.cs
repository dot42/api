// Copyright (C) 2014 dot42
//
// Original filename: JsonExtensions.cs
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
using System.ComponentModel;
using System.Text;
using Org.Json;

namespace Dot42.Internal
{
    [EditorBrowsable(EditorBrowsableState.Never)]
	public static class JsonExtensions
	{
        [Inline]
        public static byte GetByte(this JSONObject obj, string name)
        {
            return (byte)obj.OptInt(name);
        }

        [Inline]
        public static char GetChar(this JSONObject obj, string name)
        {
            return obj.GetString(name)[0];
        }

        [Inline]
        public static DateTime GetDateTime(this JSONObject obj, string name)
        {
            return JsonConvert.ToDateTime(obj.GetString(name));
        }

        [Inline]
        public static decimal GetDecimal(this JSONObject obj, string name)
        {
            throw new NotSupportedException("Decimals are not supported in Json");
        }

        [Inline]
        public static Guid GetGuid(this JSONObject obj, string name)
        {
            return new Guid(obj.GetString(name));
        }

        [Inline]
        public static short GetInt16(this JSONObject obj, string name)
        {
            return (short)obj.OptInt(name);
        }

        [Inline]
        public static int GetInt32(this JSONObject obj, string name)
        {
            return obj.OptInt(name);
        }

        [Inline]
        public static long GetInt64(this JSONObject obj, string name)
        {
            return obj.OptLong(name);
        }

        [Inline]
        public static sbyte GetSByte(this JSONObject obj, string name)
        {
            return (sbyte)obj.OptInt(name);
        }

        [Inline]
        public static float GetSingle(this JSONObject obj, string name)
        {
            return (float)obj.OptDouble(name);
        }

        [Inline]
        public static TimeSpan GetTimeSpan(this JSONObject obj, string name)
        {
            return JsonConvert.ToTimeSpan(obj.GetString(name));
        }

        [Inline]
        public static UInt16 GetUInt16(this JSONObject obj, string name)
        {
            return (UInt16)obj.OptInt(name);
        }

        [Inline]
        public static UInt32 GetUInt32(this JSONObject obj, string name)
        {
            return (UInt32)obj.OptLong(name);
        }

        [Inline]
        public static UInt64 GetUInt64(this JSONObject obj, string name)
        {
            return (UInt64)obj.OptLong(name);
        }

        [Inline]
        public static string ToJsonString(this bool obj)
        {
            return JsonConvert.ToString(obj);
        }

        [Inline]
        public static string ToJsonString(this bool[] objs)
        {
            var array = new JSONArray();
            foreach (var obj in objs)
            {
                array.Put(obj);
            }

            return array.ToString();
        }

        [Inline]
        public static string ToJsonString(this byte obj)
        {
            return obj.ToString();
        }

        [Inline]
        public static string ToJsonString(this byte[] objs)
        {
            //TODO: byte array is a special one, convert to base64?
            var array = new JSONArray();
            foreach (var obj in objs)
            {
                array.Put((int)obj);
            }

            return array.ToString();
        }

        [Inline]
        public static string ToJsonString(this char obj)
        {
            return obj.ToString().ToJsonString();
        }

        [Inline]
        public static string ToJsonString(this char[] objs)
        {
            var array = new JSONArray();
            foreach (var obj in objs)
            {
                array.Put(obj.ToString());
            }

            return array.ToString();
        }

        public static string ToJsonString(this DateTime obj)
        {
            return JsonConvert.ToString(obj).ToJsonString();
        }

        public static string ToJsonString(this DateTime[] objs)
        {
            var array = new JSONArray();
            foreach (var obj in objs)
            {
                array.Put(JsonConvert.ToString(obj));
            }

            return array.ToString();
        }

        [Inline]
        public static string ToJsonString(this decimal obj)
        {
            throw new NotSupportedException("Decimals are not supported in Json");
        }

        [Inline]
        public static string ToJsonString(this decimal[] objs)
        {
            throw new NotSupportedException("Decimals are not supported in Json");
        }

        [Inline]
        public static string ToJsonString(this double obj)
        {
            return obj.ToString();
        }

        [Inline]
        public static string ToJsonString(this double[] objs)
        {
            var array = new JSONArray();
            foreach (var obj in objs)
            {
                array.Put(obj);
            }

            return array.ToString();
        }

        [Inline]
        public static string ToJsonString(this Guid obj)
        {
            return obj.ToString().ToJsonString();
        }

        [Inline]
        public static string ToJsonString(this Guid[] objs)
        {
            var array = new JSONArray();
            foreach (var obj in objs)
            {
                array.Put(obj.ToString());
            }

            return array.ToString();
        }

        [Inline]
        public static string ToJsonString(this short obj)
        {
            return obj.ToString();
        }

        [Inline]
        public static string ToJsonString(this short[] objs)
        {
            var array = new JSONArray();
            foreach (var obj in objs)
            {
                array.Put((long)obj);
            }

            return array.ToString();
        }

        [Inline]
        public static string ToJsonString(this int obj)
        {
            return obj.ToString();
        }

        [Inline]
        public static string ToJsonString(this int[] objs)
        {
            var array = new JSONArray();
            foreach (var obj in objs)
            {
                array.Put((long)obj);
            }

            return array.ToString();
        }

        [Inline]
        public static string ToJsonString(this long obj)
        {
            return obj.ToString();
        }

        [Inline]
        public static string ToJsonString(this long[] objs)
        {
            var array = new JSONArray();
            foreach (var obj in objs)
            {
                array.Put(obj);
            }

            return array.ToString();
        }

        [Inline]
        public static string ToJsonString(this sbyte obj)
        {
            return obj.ToString();
        }

        [Inline]
        public static string ToJsonString(this sbyte[] objs)
        {
            var array = new JSONArray();
            foreach (var obj in objs)
            {
                array.Put(obj.ToString());
            }

            return array.ToString();
        }

        [Inline]
        public static string ToJsonString(this float obj)
        {
            return obj.ToString();
        }

        [Inline]
        public static string ToJsonString(this float[] objs)
        {
            var array = new JSONArray();
            foreach (var obj in objs)
            {
                array.Put((double)obj);
            }

            return array.ToString();
        }

        [Inline]
        public static string ToJsonString(this string objs)
        {
            return JsonConvert.ToString(objs);
        }

        [Inline]
        public static string ToJsonString(this string[] objs)
        {
            var array = new JSONArray();
            foreach (var obj in objs)
            {
                array.Put(obj);
            }

            return array.ToString();
        }

        public static string ToJsonString(this TimeSpan obj)
        {
            return JsonConvert.ToString(obj).ToJsonString();
        }

        public static string ToJsonString(this TimeSpan[] objs)
        {
            var array = new JSONArray();
            foreach (var obj in objs)
            {
                array.Put(JsonConvert.ToString(obj));
            }

            return array.ToString();
        }

        [Inline]
        public static string ToJsonString(this ushort obj)
        {
            return obj.ToString();
        }

        [Inline]
        public static string ToJsonString(this ushort[] objs)
        {
            var array = new JSONArray();
            foreach (var obj in objs)
            {
                array.Put(obj.ToString());
            }

            return array.ToString();
        }

        [Inline]
        public static string ToJsonString(this uint obj)
        {
            return obj.ToString();
        }

        [Inline]
        public static string ToJsonString(this uint[] objs)
        {
            var array = new JSONArray();
            foreach (var obj in objs)
            {
                array.Put(obj.ToString());
            }

            return array.ToString();
        }

        [Inline]
        public static string ToJsonString(this ulong obj)
        {
            return obj.ToString();
        }

        [Inline]
        public static string ToJsonString(this ulong[] objs)
        {
            var array = new JSONArray();
            foreach (var obj in objs)
            {
                array.Put(obj.ToString());
            }

            return array.ToString();
        }
	}
}

