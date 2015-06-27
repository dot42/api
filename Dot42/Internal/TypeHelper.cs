// Copyright (C) 2014 dot42
//
// Original filename: TypeHelper.cs
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
using System.Diagnostics;
using System.Reflection;
using Dot42.Internal.Generics;
using Java.Lang.Reflect;

namespace Dot42.Internal
{
    [DebuggerStepThrough]
	internal static class TypeHelper
	{
        /// <summary>
        /// Type of java.lang.Boolean
        /// </summary>
        [DexNative]
        internal static extern Type BooleanType();

        /// <summary>
        /// Type of java.lang.Byte
        /// </summary>
        [DexNative]
        internal static extern Type ByteType();

        /// <summary>
        /// Type of java.lang.Character
        /// </summary>
        [DexNative]
        internal static extern Type CharacterType();

        /// <summary>
        /// Type of java.lang.Short
        /// </summary>
        [DexNative]
        internal static extern Type ShortType();

        /// <summary>
        /// Type of java.lang.Integer
        /// </summary>
        [DexNative]
        internal static extern Type IntegerType();

        /// <summary>
        /// Type of java.lang.Long
        /// </summary>
        [DexNative]
        internal static extern Type LongType();

        /// <summary>
        /// Type of java.lang.Float
        /// </summary>
        [DexNative]
        internal static extern Type FloatType();

        /// <summary>
        /// Type of java.lang.Double
        /// </summary>
        [DexNative]
        internal static extern Type DoubleType();

        private static bool?   DefaultBool  = false;
        private static char?   DefaultChar  = (char)0;
        private static byte?   DefaultByte  = (byte)0;
        private static short?  DefaultShort = (short)0;
        private static int?    DefaultInt   = (int)0;
        private static long?   DefaultLong  = (long)0;
        private static float?  DefaultFloat = (float)0;
        private static double? DefaultDouble= (double)0;

        /// <summary>
        /// Create an array type with the given component type with dimension 1.
        /// </summary>
        [Include]
        public static Type Array(Type componentType)
        {
            return Java.Lang.Reflect.Array.NewInstance(componentType, 0).GetType();
        }

        /// <summary>
        /// Create an array type with the given component type with multiple dimensions.
        /// </summary>
        [Include]
        public static Type Array(Type componentType, int dimensions)
        {
            while (true)
            {
                var type = Java.Lang.Reflect.Array.NewInstance(componentType, 0).GetType();
                if (dimensions == 1)
                    return type;
                dimensions--;
                componentType = type;
            }
        }

        /// <summary>
        /// this is used by the compiler, to find out in a generic class to which 
        /// runtime class to map a primitive, a nullable marker type or a generic proxy.
        /// </summary>
        [Include][DebuggerHidden]
        internal static Type EnsureGenericRuntimeType(Type p)
        {
            Type t = EnsureBoxedType(p);
            if (t != p) return t;

            return NullableReflection.GetUnderlyingTypeForMarked(p)
                   ?? GenericInstanceFactory.GetGenericTypeDefinition(p)
                   ?? p;
        }

        /// <summary>
        /// this is used by the compiler, to find out in a generic class to which 
        /// runtime class to map a primitive, a nullable marker type or a generic proxy.
        /// </summary>
        [Include][DebuggerHidden]
        internal static Type GetGenericInstanceType(Type baseType, Type[] genericParameters)
        {
            return GenericInstanceFactory.GetOrMakeGenericInstanceType(baseType, genericParameters);
        }

        [Include][DebuggerHidden]
        internal static Type GetGenericInstanceType(Type baseType, Type gp1)
        {
            return GenericInstanceFactory.GetOrMakeGenericInstanceType(baseType, gp1, null, null, null);
        }

        [Include][DebuggerHidden]
        internal static Type GetGenericInstanceType(Type baseType, Type gp1, Type gp2)
        {
            return GenericInstanceFactory.GetOrMakeGenericInstanceType(baseType, gp1, gp2, null, null);
        }

        [Include][DebuggerHidden]
        internal static Type GetGenericInstanceType(Type baseType, Type gp1, Type gp2, Type gp3)
        {
            return GenericInstanceFactory.GetOrMakeGenericInstanceType(baseType, gp1, gp2, gp3, null);
        }

        [Include][DebuggerHidden]
        internal static Type GetGenericInstanceType(Type baseType, Type gp1, Type gp2, Type gp3, Type gp4)
        {
            return GenericInstanceFactory.GetOrMakeGenericInstanceType(baseType, gp1, gp2, gp3, gp4);
        }


        public static Type EnsurePrimitiveType(Type p)
        {
            return p == BooleanType() ? typeof(bool)
                 : p == CharacterType() ? typeof(char)
                 : p == ByteType() ? typeof(byte)
                 : p == ShortType() ? typeof(short)
                 : p == IntegerType() ? typeof(int)
                 : p == LongType() ? typeof(long)
                 : p == FloatType() ? typeof(float)
                 : p == DoubleType() ? typeof(double)
                 : p;
        }

	    public static Type EnsureBoxedType(Type p)
	    {
	        return p == typeof(bool)  ? BooleanType()
                 : p == typeof(char)  ? CharacterType()
                 : p == typeof(byte)  ? ByteType()
                 : p == typeof(short) ? ShortType()
                 : p == typeof(int)   ? IntegerType()
                 : p == typeof(long)  ? LongType()
                 : p == typeof(float) ? FloatType()
                 : p == typeof(double)? DoubleType()
                 : p;
	    }

        internal static object GetPrimitiveDefault(Type p)
        {
            return p == typeof(bool)   ? DefaultBool
                 : p == typeof(char)   ? DefaultChar
                 : p == typeof(byte)   ? DefaultByte
                 : p == typeof(short)  ? DefaultShort
                 : p == typeof(int)    ? DefaultInt
                 : p == typeof(long)   ? DefaultLong
                 : p == typeof(float)  ? DefaultFloat
                 : p == typeof(double) ? DefaultDouble
                 : (object) null;
        }

        public static bool IsBoxedType(Type type)
        {
            return    type == BooleanType()
                   || type == ByteType()
                   || type == ShortType()
                   || type == IntegerType()
                   || type == LongType()
                   || type == FloatType()
                   || type == DoubleType()
                   || type == CharacterType();
        }

        //internal static JavaField[] GetFields(Type type, BindingFlags flags)
        //{
        //    if (((flags & BindingFlags.DeclaredOnly) != 0))
        //        return type.JavaGetDeclaredFields().Where(x => Matches(x.GetModifiers(), flags));
        //    if (((flags & BindingFlags.NonPublic) == 0))
        //        return type.JavaGetFields().Where(x => Matches(x.GetModifiers(), flags));

        //    ArrayList<JavaField> ret = new ArrayList<JavaField>();

        //    while (type != null)
        //    {
        //        var fields = type.JavaGetDeclaredFields();
        //        for (int i = 0; i < fields.Length; ++i)
        //        {
        //            var javaField = fields[i];
        //            if (Matches(javaField.GetModifiers(), flags))
        //                ret.Add(javaField);
        //        }
        //        type = type.GetSuperclass();
        //    }

        //    return ret.ToArray((JavaField[])Java.Lang.Reflect.Array.NewInstance(typeof(JavaField), ret.Size()));
        //}

        //internal static JavaMethod[] GetMethods(Type type, BindingFlags flags)
        //{
        //    if (((flags & BindingFlags.DeclaredOnly) != 0))
        //        return type.JavaGetDeclaredMethods().Where(x => Matches(x.GetModifiers(), flags));
        //    if (((flags & BindingFlags.NonPublic) == 0))
        //        return type.JavaGetMethods().Where(x => Matches(x.GetModifiers(), flags));

        //    ArrayList<JavaMethod> ret = new ArrayList<JavaMethod>();

        //    while (type != null)
        //    {
        //        var methods = type.JavaGetDeclaredMethods();
        //        for (int i = 0; i < methods.Length; ++i)
        //        {
        //            var javaMethod = methods[i];
        //            if (Matches(javaMethod.GetModifiers(), flags))
        //                ret.Add(javaMethod);
        //        }
        //        type = type.GetSuperclass();
        //    }

        //    return ret.ToArray((JavaMethod[])Java.Lang.Reflect.Array.NewInstance(typeof(JavaMethod), ret.Size()));
        //}

        /// <summary>
        /// Do the given modifiers of a member match the given binding flags?
        /// </summary>
        internal static bool Matches(int modifiers, BindingFlags flags)
        {
            // Exclude instance members?
            if (((flags & BindingFlags.Instance) == 0) && !Modifier.IsStatic(modifiers)) return false;
            // Exclude static members?
            if (((flags & BindingFlags.Static)   == 0) && Modifier.IsStatic(modifiers))  return false;
            // Exclude public members?
            if (((flags & BindingFlags.Public)   == 0) && Modifier.IsPublic(modifiers))  return false;
            // Exclude nonpublic members?
            if (((flags & BindingFlags.NonPublic)== 0) && !Modifier.IsPublic(modifiers)) return false;
            return true;
        }
	}
}

