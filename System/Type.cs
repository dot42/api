// Copyright (C) 2014 dot42
//
// Original filename: Type.cs
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
using System.Linq;
using System.Reflection;
using Dot42;
using Dot42.Internal;
using Dot42.Internal.Generics;
using Java.Lang;
using Java.Lang.Reflect;
using Java.Util;

namespace System
{
	/*abstract*/ partial class Type : ICustomAttributeProvider
	{
        internal const BindingFlags AllMembersBindingFlags = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Instance;
        internal const BindingFlags PublicMembersBindingFlags = BindingFlags.Public | BindingFlags.Static | BindingFlags.Instance;
        internal const BindingFlags DeclaredMembersBindingFlags = BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Instance;

        /// <summary>
        /// Gets the assembly-qualified name of the Type, which includes the name of the assembly from which the Type was loaded.
        /// 
        /// returns FullName
        /// </summary>
	    public string AssemblyQualifiedName
	    {
            get { return FullName; }
	    }

        /// <summary>
        /// Gets the type name and namespace.
        /// </summary>
	    public string FullName
	    {
            get { return GenericsReflection.GetFullName(this); }
	    }

        /// <summary>
        /// Gets the type name without namespace.
        /// </summary>
        public string Name
        {
            get { return GenericsReflection.GetName(this); }
        }

        public string Namespace
        {
            get
            {
                string name = JavaGetName();
                int idx = name.LastIndexOf((int)'.');
                if (idx == -1) return "";
                return name.Substring(0, idx);
            }
        }

        /// <summary>
        /// Is the given type a value type.
        /// </summary>
	    public bool IsValueType
	    {
            get { return IsPrimitive || typeof(ValueType).JavaIsAssignableFrom(GenericsReflection.EnsureTypeDef(this)); }
	    }

        public bool IsPublic { get { return Modifier.IsPublic(EnsureTypeDef().GetModifiers()); } }

        /// <summary>
        /// Is the given type an enum?
        /// </summary>
        public bool IsEnum
        {
            get
            {
                // java has some quirks regarding enums: http://stackoverflow.com/questions/4166488/checking-if-a-class-is-java-lang-enum
                return !IsPrimitive && !NullableReflection.TreatAsSystemNullableT(this) 
                                    && typeof(Java.Lang.Enum<>).JavaIsAssignableFrom(this);
            }
        }

	    public bool IsGenericType
	    {
	        get
	        {
	            return GenericsReflection.IsGenericType(this);
	        }
	    }

        public bool IsInterface
        {
            get { return EnsureTypeDef().JavaIsInterface(); }
        }

	    public bool IsClass
	    {
	        get
	        {
	            return !IsPrimitive && !IsInterface && !IsEnum;
	        }
	    }

        public Type BaseType
        {
            get { return GenericsReflection.GetBaseType(this); }
        }

        public bool IsAbstract
        {
            get { return Modifier.IsAbstract(GenericsReflection.EnsureTypeDef(this).GetModifiers()); }
        }

	    public bool IsVisible
	    {
	        get
	        {
	            Type t = this;
	            while (Modifier.IsPublic(GetModifiers())
                    && (t = t.GetEnclosingClass()) != null)
	            {
	            }
	            return t == null;
	        }
	    }

        /// <summary>
        /// Is this a serializable type?
        /// </summary>
        /// <remarks>Not implemented, always returns false.</remarks>
	    public bool IsSerializable
	    {
            get { return false; }
	    }

	    public bool IsSealed
	    {
            get { return Modifier.IsFinal(EnsureTypeDef().GetModifiers()); }
	    }

        public Type[] GetInterfaces()
        {
            return GenericsReflection.GetInterfaces(this);
        }

        public Type GetGenericTypeDefinition()
        {
            return GenericsReflection.GetGenericTypeDefinition(this);
        }

	    public Type GetNestedType(string name)
	    {
            // TODO: make this work for generic classes as well.
	        var def = EnsureTypeDef();
	        var nested = def.GetDeclaredClasses();
            
	        for (int i = 0; i < nested.Length; ++i)
	        {
                // TODO: emulate the visibility. here we should only return public classes.
                //Log.I("dot42", string.Format("GetNestedType on {0}: {1}", Name, nested[i].Name));
	            string nestedName = nested[i].Name;
	            if (nestedName == name)
	                return nested[i];
	        }

	        return null;
	    }

        /// <summary>
        /// will return the correct count. For nullable types, 
        /// will return the underlying type.
        /// for other types the count will be right, but
        /// elements are all typeof(object)
        /// </summary>
        /// <returns></returns>
        public Type[] GetGenericArguments()
        {
            return GenericsReflection.GetGenericArguments(this);
        }

        /// <summary>
        /// This will only work with .NET types not java types.
        /// <para>
        /// The returned type can only be used in Activator.CreateInstance,
        /// and is otherwise useless, except if this is Nullable[T].
        ///
        /// In particular the class name, methods, fields, constructors and 
        /// properties as well as the superclass and implemented interfaces can
        /// all not be retrieved from this type.
        /// </para>
        /// </summary>
        public Type MakeGenericType(params Type[] types)
        {
            return GenericsReflection.MakeGenericType(this, types);
        }

        /// <summary>
        /// returns true is this is a generic type.
        /// [ should only return true for true GenericTypeDefinitions ]
        /// </summary>
        public bool ContainsGenericParameters
        {
            get
            {
                return GenericsReflection.ContainsGenericParameters(this);
            }
        }

	    /// <summary>
	    /// returns true is this is a generic type.
	    /// [ should only return true for true GenericTypeDefinitions ]
	    /// </summary>
	    public bool IsGenericTypeDefinition
	    {
	        get
	        {
	            return GenericsReflection.IsGenericTypeDefinition(this);
	        }
	    }

        /// <summary>
        /// returns always false
        /// </summary>
        public bool IsGenericParameter { get { return false; } }

        public Assembly Assembly
	    {
            get { return Assembly.GetAssembly(this); }
	    }

	    /// <summary>
        /// Returns an array of all attributes defined on this member.
        /// Returns an empty array if no attributes are defined on this member.
        /// </summary>
        /// <param name="inherit">If true, look in base classes for inherited custom attributes.</param>
        public object[] GetCustomAttributes(bool inherit)
        {
            return CustomAttributeProvider.GetCustomAttributes(EnsureTypeDef(), inherit);
        }

        /// <summary>
        /// Returns an array of all attributes defined on this member of the given attribute type.
        /// Returns an empty array if no attributes are defined on this member.
        /// </summary>
        /// <param name="inherit">If true, look in base classes for inherited custom attributes.</param>
        public object[] GetCustomAttributes(Type attributeType, bool inherit)
        {
            return CustomAttributeProvider.GetCustomAttributes(EnsureTypeDef(), attributeType, inherit);
        }

        /// <summary>
        /// Are one or more attributes of the given type defined on this member.
        /// </summary>
        /// <param name="attributeType">The type of the custom attribute</param>
        /// <param name="inherit">If true, look in base classes for inherited custom attributes.</param>
        public bool IsDefined(Type attributeType, bool inherit)
        {
            return CustomAttributeProvider.IsDefined(EnsureTypeDef(), attributeType, inherit);
        }

        /// <summary>
        /// Gets all public constructors of this type.
        /// </summary>
        public ConstructorInfo[] GetConstructors()
        {
            return GetConstructors(BindingFlags.Public | BindingFlags.Instance);
        }

        /// <summary>
        /// Gets all constructors of this type that match the given binding flags,
        /// declared in this class.
        /// </summary>
        public ConstructorInfo[] GetConstructors(BindingFlags flags)
        {
            // note that unlike the other member retrival operations
            // GetConstructors never searches base classes.
            return GenericsReflection.GetConstructors(this, flags)
                   ?? JavaGetDeclaredConstructors()
                        .Where(x => TypeHelper.Matches(x.Modifiers, flags))
                        .Select(p => new ConstructorInfo(p))
                        .ToArray();
        }

	    public ConstructorInfo GetConstructor(Type[] parameters)
	    {
            var ci = GenericsReflection.GetConstructor(this, parameters);

            if(ci != null) return ci;

	        var typeDefParams = new Type[parameters.Length];
	        for (int i = 0; i < parameters.Length; ++i)
	            typeDefParams[i] = parameters[i].EnsureTypeDef();

            try
            {
                return new ConstructorInfo(JavaGetConstructor(typeDefParams));
            }
            catch (NoSuchMethodException)
            {
                return null;
            }
	    }
	
        /// <summary>
        /// Gets all public fields of this type.
        /// </summary>
        public FieldInfo[] GetFields()
        {
            return GenericsReflection.GetFields(this, PublicMembersBindingFlags);
        }

        public FieldInfo GetField(string name)
        {
            return GenericsReflection.GetField(this, name, PublicMembersBindingFlags);
        }

        public FieldInfo GetField(string name, BindingFlags flags)
        {
            return GenericsReflection.GetField(this, name, flags);
	    }

        /// <summary>
        /// Gets all fields of this type that match the given binding flags.
        /// </summary>
        public FieldInfo[] GetFields(BindingFlags flags)
	    {
            return GenericsReflection.GetFields(this, flags);
	    }

	    /// <summary>
        /// Gets all public methods of this type.
        /// </summary>
        public MethodInfo[] GetMethods()
	    {
            return GenericsReflection.GetMethods(this, PublicMembersBindingFlags)
                                     .ToArray();
        }

        /// <summary>
        /// Gets all methods of this type that match the given binding flags.
        /// </summary>
        public MethodInfo[] GetMethods(BindingFlags flags)
        {
            return GenericsReflection.GetMethods(this, flags).ToArray();

        }

        public MethodInfo GetMethod(string name)
        {
            return GenericsReflection.GetMethod(this, name, PublicMembersBindingFlags, null);

        }

	    public MethodInfo GetMethod(string name, Type[] parameters)
	    {
            return GenericsReflection.GetMethod(this, name, PublicMembersBindingFlags, parameters);
	    }

        public PropertyInfo[] GetDeclaredProperties()
        {
            return PropertyInfoProvider.GetProperties(GenericsReflection.EnsureTypeDef(this), this);
        }

	    public PropertyInfo[] GetProperties()
	    {
	        return GetProperties(PublicMembersBindingFlags);
	    }

        public PropertyInfo[] GetProperties(BindingFlags flags)
        {
            List<PropertyInfo> ret = new List<PropertyInfo>();

            Type type = this;

            var isDeclaredOnly = (flags & BindingFlags.DeclaredOnly) != 0;
            bool isBase = false;
            Java.Util.HashSet<string> lookedAt = isDeclaredOnly? null : new Java.Util.HashSet<string>();
            
            
            // we have to walk all the way up.
            while (type != null)
            {
                foreach (var prop in type.GetDeclaredProperties())
                {
                    if (IsMatch(prop, flags))
                    {
                        // make sure we don't return overriden properties.
                        if (!isDeclaredOnly)
                        {
                            string getterName = prop.GetMethod != null ? prop.GetMethod.Name : null;
                            string setterName = prop.SetMethod != null ? prop.SetMethod.Name : null;
                            if (isBase)
                            {
                                if (getterName != null && lookedAt.Contains(getterName))
                                    continue;
                                if (setterName != null && lookedAt.Contains(setterName))
                                    continue;
                            }

                            if (getterName != null)
                                lookedAt.Add(getterName);
                            if (setterName != null)
                                lookedAt.Add(setterName);
                        }

                        ret.Add(prop);
                    }
                }


                if (isDeclaredOnly)
                    break;

                type = type.BaseType;
                isBase = true;
            }
            return ret.ToArray();
        }

        public PropertyInfo GetProperty(string name)
        {
            return GetProperty(name, PublicMembersBindingFlags);
        }

        public PropertyInfo GetProperty(string name, BindingFlags flags)
        {
            var props = GetProperties(flags).Where(p => p.Name == name);

            if (props.Length > 1)
                throw new AmbiguousMatchException("not unique: " + name);

            return props.Length == 0 ? null : props[0];
        }

        public EventInfo GetEvent(string name)
        {
            return GetEvents(PublicMembersBindingFlags)
                            .FirstOrDefault(p => p.Name == name);
        }

        public EventInfo[] GetEvents(BindingFlags flags)
        {
            List<EventInfo> ret = new List<EventInfo>();

            Type type = this;

            // we have to walk all the way up.
            while (type != null)
            {
                foreach (var @event in type.GetDeclaredEvents())
                    if (IsMatch(@event, flags))
                        ret.Add(@event);

                if ((flags & BindingFlags.DeclaredOnly) != 0)
                    break;

                type = type.BaseType;
            }
            return ret.ToArray();
        }

        public EventInfo[] GetDeclaredEvents()
        {
            return EventInfoProvider.GetEvents(EnsureTypeDef(), this);
        }

        private static bool IsMatch(PropertyInfo propertyInfo, BindingFlags flags)
        {
            bool incPublic = (flags & BindingFlags.Public) == BindingFlags.Public;
            bool incNonPublic = (flags & BindingFlags.NonPublic) == BindingFlags.NonPublic;
            bool incStatic = (flags & BindingFlags.Static) == BindingFlags.Static;
            bool incInstance = (flags & BindingFlags.Instance) == BindingFlags.Instance;

            var get = propertyInfo.GetGetMethod();
            var set = propertyInfo.GetSetMethod();

            return    ((incPublic    && ((get != null && get.IsPublic)  || (set != null && set.IsPublic)))
                    || (incNonPublic && ((get != null && !get.IsPublic) || (set != null && !set.IsPublic))))
                &&    ((incStatic    && ((get != null && get.IsStatic)  || (set != null && set.IsStatic)))
                    || (incInstance  && ((get != null && !get.IsStatic) || (set != null && !set.IsStatic))));
        }

        private static bool IsMatch(EventInfo eventInfo, BindingFlags flags)
        {
            bool incPublic = (flags & BindingFlags.Public) == BindingFlags.Public;
            bool incNonPublic = (flags & BindingFlags.NonPublic) == BindingFlags.NonPublic;
            bool incStatic = (flags & BindingFlags.Static) == BindingFlags.Static;
            bool incInstance = (flags & BindingFlags.Instance) == BindingFlags.Instance;

            var add = eventInfo.GetAddMethod();
            var rem = eventInfo.GetRemoveMethod();

            return ((incPublic && ((add != null && add.IsPublic) || (rem != null && rem.IsPublic)))
                    || (incNonPublic && ((add != null && !add.IsPublic) || (rem != null && !rem.IsPublic))))
                && ((incStatic && ((add != null && add.IsStatic) || (rem != null && rem.IsStatic)))
                    || (incInstance && ((add != null && !add.IsStatic) || (rem != null && !rem.IsStatic))));
        }

        public MemberInfo[] GetMember(string memberName, BindingFlags flags)
        {
            List<MemberInfo> ret = new List<MemberInfo>();
            if (memberName == ".cctor")
                ret.AddRange(GetConstructors(flags));
            ret.AddRange(GetFields(flags).Where(f => f.Name == memberName));
            ret.AddRange(GetMethods(flags).Where(f => f.Name == memberName));
            ret.AddRange(GetProperties(flags).Where(f => f.Name == memberName));
            ret.AddRange(GetEvents(flags).Where(f => f.Name == memberName));
            return ret.ToArray();
        }

        public MemberInfo[] GetMembers(BindingFlags flags)
        {
            List<MemberInfo> ret = new List<MemberInfo>();
            ret.AddRange(GetFields(flags));
            ret.AddRange(GetMethods(flags));
            ret.AddRange(GetProperties(flags));
            ret.AddRange(GetEvents(flags));
            return ret.ToArray();
        }

        public /*virtual*/ bool IsAssignableFrom(Type other)
        {
            return GenericsReflection.IsAssignableFrom(this, other);
        }

        [Include,Inline] // used by "x is T" in generic methods.
        public /*virtual*/ bool IsInstanceOfType(Object o)
        {
            if (o == null) return false;
            return EnsureTypeDef().JavaIsAssignableFrom(o.GetType());
        }

        public /*virtual*/ bool IsSubclassOf(Type other)
        {
            Type t = EnsureTypeDef();
            other = other.EnsureTypeDef();

            while ((t = t.GetSuperclass()) != null)
            {
                if (t == other) return true;
            }
            return false;
        }

        // We have to make sure we never return 
        // the boxed types to .NET callers.
        public Type GetElementType()
        {
            var type = JavaGetComponentType();
            if (type == null) return null;
            if (type == TypeHelper.BooleanType())
                return typeof(bool);
            if (type == TypeHelper.CharacterType())
                return typeof(char);
            if (type == TypeHelper.ByteType())
                return typeof(byte);
            if (type == TypeHelper.ShortType())
                return typeof(short);
            if (type == TypeHelper.IntegerType())
                return typeof(int);
            if (type == TypeHelper.LongType())
                return typeof(long);
            if (type == TypeHelper.FloatType())
                return typeof(float);
            if (type == TypeHelper.DoubleType())
                return typeof(double);
            return type;
        }

        /// <summary>
        /// this will return 1 for array types.
        /// TODO: find out how to retrieve the rank of our multidimensional arrays.
        /// </summary>
        /// <returns></returns>
	    public int GetArrayRank()
	    {
	        if(!IsArray)
                throw new InvalidOperationException("not an array");
	        return 1;
	    }

        private Type EnsureTypeDef()
        {
            return GenericsReflection.EnsureTypeDef(this);
        }

        [DexNative]
        public static Type GetTypeFromHandle(RuntimeTypeHandle handle)
        {
            return null;
        }

        [NotImplemented]
        public static TypeCode GetTypeCode(Type t)
        {
            throw new NotImplementedException("System.Type.GetTypeCode");
        }

	    public static Type GetType(string typeName)
	    {
            // TODO: implement for generics, with parsing of "[,]" syntax.
	        return ForName(typeName.Replace('`', GenericsReflection.GenericTickChar));
	    }

        /// <summary>
        /// note that ignoreCase is ignored.
        /// </summary>
        public static Type GetType(string typeName, bool ignoreCase)
        {
            return GetType(typeName);
        }
	}
}

