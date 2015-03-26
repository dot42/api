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
using System.Reflection;
using Java.Lang.Reflect;
using Java.Util;

namespace Dot42.Internal
{
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

	    [Include]
	    internal static Type EnsurePrimitiveType(Type p)
	    {
            return p == BooleanType()   ? typeof(bool) 
                 : p == CharacterType() ? typeof(char) 
                 : p == ByteType()      ? typeof(byte) 
                 : p == ShortType()     ? typeof(short)
                 : p == IntegerType()   ? typeof(int) 
                 : p == LongType()      ? typeof(long)
                 : p == FloatType()     ? typeof(float)
                 : p == DoubleType()    ? typeof(double)
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

        public static bool IsBoxedType(Type type)
        {
            return    type == BooleanType()
                   || type == ByteType()
                   || type == ShortType()
                   || type == IntegerType()
                   || type == LongType()
                   || type == FloatType()
                   || type == DoubleType()
                   || type == CharacterType()
                   || type == CharacterType();
        }

        /// <summary>
        /// never returns synthetic fields.
        /// </summary>
        internal static JavaField[] GetFields(Type type, BindingFlags flags)
        {
            if (((flags & BindingFlags.DeclaredOnly) != 0))
                return type.JavaGetDeclaredFields().Where(x => Matches(x.GetModifiers(), flags));
            if (((flags & BindingFlags.NonPublic) == 0))
                return type.JavaGetFields().Where(x => !x.IsSynthetic() && Matches(x.GetModifiers(), flags));

            ArrayList<JavaField> ret = new ArrayList<JavaField>();

            while (type != null)
            {
                var fields = type.JavaGetDeclaredFields();
                for (int i = 0; i < fields.Length; ++i)
                {
                    var javaField = fields[i];

                    if (javaField.IsSynthetic()) continue;
                    if (Matches(javaField.GetModifiers(), flags))
                        ret.Add(javaField);
                }
                type = type.GetSuperclass();
            }

            return ret.ToArray((JavaField[])Java.Lang.Reflect.Array.NewInstance(typeof(JavaField), ret.Size()));
        }

        /// <summary>
        /// hides synthetic methods
        /// </summary>
        internal static JavaMethod[] GetMethods(Type type, BindingFlags flags)
        {
            if (((flags & BindingFlags.DeclaredOnly) != 0))
                return type.JavaGetDeclaredMethods().Where(x => Matches(x.GetModifiers(), flags));
            if (((flags & BindingFlags.NonPublic) == 0))
                return type.JavaGetMethods().Where(x => x.IsSynthetic() && Matches(x.GetModifiers(), flags));

            ArrayList<JavaMethod> ret = new ArrayList<JavaMethod>();

            while (type != null)
            {
                var methods = type.JavaGetDeclaredMethods();
                for (int i = 0; i < methods.Length; ++i)
                {
                    var javaMethod = methods[i];
                    if (javaMethod.IsSynthetic())
                        continue;
                    if (Matches(javaMethod.GetModifiers(), flags))
                        ret.Add(javaMethod);
                }
                type = type.GetSuperclass();
            }

            return ret.ToArray((JavaMethod[])Java.Lang.Reflect.Array.NewInstance(typeof(JavaMethod), ret.Size()));
        }

        /// <summary>
        /// Do the given modifiers of a member match the given binding flags?
        /// </summary>
        internal static bool Matches(int modifiers, BindingFlags flags)
        {
            // Exclude instance members?
            if (((flags & BindingFlags.Instance) == 0) && !Modifier.IsStatic(modifiers)) return false;
            // Exclude static members?
            if (((flags & BindingFlags.Static) == 0) && Modifier.IsStatic(modifiers)) return false;
            // Exclude public members?
            if (((flags & BindingFlags.Public) == 0) && Modifier.IsPublic(modifiers)) return false;
            // Exclude nonpublic members?
            if (((flags & BindingFlags.NonPublic) == 0) && !Modifier.IsPublic(modifiers)) return false;
            return true;
        }
	}
}

