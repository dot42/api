// Copyright (C) 2014 dot42
//
// Original filename: Boxing.cs
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
using JArray = Java.Lang.Reflect.Array;

namespace Dot42.Internal
{
    /// <summary>
    /// Box/unbox array or primitive types.
    /// </summary>
	internal static class Boxing
    {
        /// <summary>
        /// Box a bool array to a Boolean array.
        /// </summary>
        public static object[] Box(bool[] array)
        {
            return (object[])ConvertArray(TypeHelper.BooleanType(), array, false);
        }

        /// <summary>
        /// Box a byte array to a Byte array.
        /// </summary>
        public static object[] Box(sbyte[] array)
        {
            return (object[])ConvertArray(TypeHelper.ByteType(), array, (sbyte)0);
        }

        /// <summary>
        /// Box a char array to a Character array.
        /// </summary>
        public static object[] Box(char[] array)
        {
            return (object[])ConvertArray(TypeHelper.CharacterType(), array, '\0');
        }

        /// <summary>
        /// Box a short array to a Short array.
        /// </summary>
        public static object[] Box(short[] array)
        {
            return (object[])ConvertArray(TypeHelper.ShortType(), array, (short)0);
        }

        /// <summary>
        /// Box a int array to a Integer array.
        /// </summary>
        public static object[] Box(int[] array)
        {
            return (object[])ConvertArray(TypeHelper.IntegerType(), array, 0);
        }

        /// <summary>
        /// Box a long array to a Long array.
        /// </summary>
        public static object[] Box(long[] array)
        {
            return (object[])ConvertArray(TypeHelper.LongType(), array, 0L);
        }

        /// <summary>
        /// Box a float array to a Float array.
        /// </summary>
        public static object[] Box(float[] array)
        {
            return (object[])ConvertArray(TypeHelper.FloatType(), array, 0.0f);
        }

        /// <summary>
        /// Box a double array to a Double array.
        /// </summary>
        public static object[] Box(double[] array)
        {
            return (object[])ConvertArray(TypeHelper.DoubleType(), array, 0.0);
        }

        /// <summary>
        /// Unbox object to bool.
        /// </summary>
        public static bool UnboxBoolean(object value)
        {
            var boxed = value as Java.Lang.Boolean;
            if (boxed != null) return boxed.BooleanValue();
            var number = value as Java.Lang.Number;
            if (number != null) return (number.IntValue() != 0);
            var @enum = value as Dot42.Internal.Enum;
            if (@enum != null) return (@enum.IntValue() != 0);
            return false;
        }

        /// <summary>
        /// Unbox object to sbyte.
        /// </summary>
        public static sbyte UnboxSByte(object value)
        {
            var number = value as Java.Lang.Number;
            if (number != null) return number.ByteValue();
            var @enum = value as Dot42.Internal.Enum;
            if (@enum != null) return (sbyte) @enum.IntValue();
            return 0;
        }

        /// <summary>
        /// Unbox object to char.
        /// </summary>
        public static char UnboxCharacter(object value)
        {
            var ch = value as Java.Lang.Character;
            if (ch != null) return ch.CharValue();
            var number = value as Java.Lang.Number;
            if (number != null) return (char) number.IntValue();
            var @enum = value as Dot42.Internal.Enum;
            if (@enum != null) return (char) @enum.IntValue();
            return '\0';
        }

        /// <summary>
        /// Unbox object to short.
        /// </summary>
        public static short UnboxShort(object value)
        {
            var number = value as Java.Lang.Number;
            if (number != null) return number.ShortValue();
            var @enum = value as Dot42.Internal.Enum;
            if (@enum != null) return (short)@enum.IntValue();
            return 0;
        }

        /// <summary>
        /// Unbox object to int.
        /// </summary>
        public static int UnboxInteger(object value)
        {
            var number = value as Java.Lang.Number;
            if (number != null) return number.IntValue();
            var @enum = value as Dot42.Internal.Enum;
            if (@enum != null) return @enum.IntValue();
            return 0;
        }

        /// <summary>
        /// Unbox object to long.
        /// </summary>
        public static long UnboxLong(object value)
        {
            var number = value as Java.Lang.Number;
            if (number != null) return number.LongValue();
            var @enum = value as Dot42.Internal.Enum;
            if (@enum != null) return @enum.LongValue();
            return 0L;
        }

        /// <summary>
        /// Unbox object to float.
        /// </summary>
        public static float UnboxFloat(object value)
        {
            var number = value as Java.Lang.Number;
            if (number != null) return number.FloatValue();
            var @enum = value as Dot42.Internal.Enum;
            if (@enum != null) return (float)@enum.IntValue();
            return 0.0F;
        }

        /// <summary>
        /// Unbox object to double.
        /// </summary>
        public static double UnboxDouble(object value)
        {
            var number = value as Java.Lang.Number;
            if (number != null) return number.DoubleValue();
            var @enum = value as Dot42.Internal.Enum;
            if (@enum != null) return (double)@enum.LongValue();
            return 0.0;
        }

        /// <summary>
        /// Box a Boolean array to a bool array.
        /// </summary>
        public static bool[] UnboxBooleanArray(object array)
        {
            return (bool[])ConvertArray(Boolean.TYPE, array, false);
        }

        /// <summary>
        /// Box a Byte array to a sbyte array.
        /// </summary>
        public static sbyte[] UnboxSByteArray(object array)
        {
            return (sbyte[])ConvertArray(SByte.TYPE, array, (sbyte)0);
        }

        /// <summary>
        /// Box a Character array to a char array.
        /// </summary>
        public static char[] UnboxCharacterArray(object array)
        {
            return (char[])ConvertArray(Char.TYPE, array, '\0');
        }

        /// <summary>
        /// Box a Short array to a short array.
        /// </summary>
        public static short[] UnboxShortArray(object array)
        {
            return (short[])ConvertArray(Int16.TYPE, array, (short)0);
        }

        /// <summary>
        /// Box a Integer array to a int array.
        /// </summary>
        public static int[] UnboxIntegerArray(object array)
        {
            return (int[])ConvertArray(Int32.TYPE, array, 0);
        }

        /// <summary>
        /// Box a Long array to a long array.
        /// </summary>
        public static long[] UnboxLongArray(object array)
        {
            return (long[])ConvertArray(Int64.TYPE, array, 0L);
        }

        /// <summary>
        /// Box a Float array to a float array.
        /// </summary>
        public static float[] UnboxFloatArray(object array)
        {
            return (float[])ConvertArray(Single.TYPE, array, 0.0f);
        }

        /// <summary>
        /// Box a Double array to a double array.
        /// </summary>
        public static double[] UnboxDoubleArray(object array)
        {
            return (double[])ConvertArray(Double.TYPE, array, 0.0);
        }

        /// <summary>
        /// Unbox a Boolean array to a bool array.
        /// </summary>
        public static void UnboxTo(object array, bool[] target)
        {
            CopyArray(array, target, false);
        }

        /// <summary>
        /// Unbox a Byte array to a sbyte array.
        /// </summary>
        public static void UnboxTo(object array, sbyte[] target)
        {
            CopyArray(array, target, (sbyte)0);
        }

        /// <summary>
        /// Unbox a Character array to a char array.
        /// </summary>
        public static void UnboxTo(object array, char[] target)
        {
            CopyArray(array, target, '\0');
        }

        /// <summary>
        /// Unbox a Short array to a short array.
        /// </summary>
        public static void UnboxTo(object array, short[] target)
        {
            CopyArray(array, target, (short)0);
        }

        /// <summary>
        /// Unbox a Integer array to a int array.
        /// </summary>
        public static void UnboxTo(object array, int[] target)
        {
            CopyArray(array, target, 0);
        }

        /// <summary>
        /// Unbox a Long array to a long array.
        /// </summary>
        public static void UnboxTo(object array, long[] target)
        {
            CopyArray(array, target, 0L);
        }

        /// <summary>
        /// Unbox a Float array to a float array.
        /// </summary>
        public static void UnboxTo(object array, float[] target)
        {
            CopyArray(array, target, 0.0f);
        }

        /// <summary>
        /// Unbox a Double array to a double array.
        /// </summary>
        public static void UnboxTo(object array, double[] target)
        {
            CopyArray(array, target, 0.0);
        }

        /// <summary>
        /// Box an entire array of type elements into an array of boxed elements.
        /// </summary>
        private static object ConvertArray(Type boxType, Object primitiveArray, object defaultValue)
        {
            if (ReferenceEquals(primitiveArray, null))
                return null;
            var length = JArray.GetLength(primitiveArray);
            var array = JArray.NewInstance(boxType, length);
            for (var i = 0; i < length; i++)
            {
                // Boxing is done by Get.
                var value = JArray.Get(primitiveArray, i) ?? defaultValue;
                JArray.Set(array, i, value);
            }
            return array;
        }

        /// <summary>
        /// Box an entire array of type elements into an array of boxed elements.
        /// </summary>
        private static void CopyArray(Object source, Object destination, object defaultValue)
        {
            if (ReferenceEquals(source, null) && ReferenceEquals(destination, null))
                return;
            var length = JArray.GetLength(source);
            for (var i = 0; i < length; i++)
            {
                // Boxing is done by Get.
                var value = JArray.Get(source, i) ?? defaultValue;
                JArray.Set(destination, i, value);
            }
        }
    }
}

