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
using System.Reflection;
using Dot42;
using Dot42.Internal;
using Java.Lang.Reflect;
using Java.Util.Zip;

namespace System
{
	/*abstract*/ partial class Type : ICustomAttributeProvider
	{
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
            get { return JavaGetName(); }
	    }

        /// <summary>
        /// Gets the type name without namespace.
        /// </summary>
        public string Name
        {
            get { return GetSimpleName(); }
        }

        public string Namespace
        {
            get
            {
                string name = FullName;
                int idx = name.LastIndexOf('.');
                if (idx == -1) return "";
                return name.Substring(0, idx);
            }
        }

        /// <summary>
        /// Is the given type a value type.
        /// </summary>
	    public bool IsValueType
	    {
            get { return IsPrimitive || typeof(ValueType).IsAssignableFrom(this); }
	    }

        /// <summary>
        /// Is the given type an enum?
        /// </summary>
        public bool IsEnum
        {
            // java has some quirks regarding enums: http://stackoverflow.com/questions/4166488/checking-if-a-class-is-java-lang-enum
            get { return typeof(Java.Lang.Enum<object>).IsAssignableFrom(this); }
        }

	    public bool IsGenericType
	    {
	        get
	        {
	            return GenericInstanceFactory.IsGenericType(this);
	        }
	    }

	    public bool IsClass
	    {
            get { return !IsPrimitive && !IsInterface && !IsEnum; }
	    }

        public Type BaseType
        {
            get { return GetSuperclass(); }
        }

        public bool IsAbstract
        {
            get { return Modifier.IsAbstract(GetModifiers()); }
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
	        get { return Modifier.IsFinal(this.GetModifiers()); }
	    }
        
        // Note: it should be possible to support this.
        public Type GetGenericTypeDefinition()
        {
            if (!IsGenericType) 
                ThrowHelper.ThrowInvalidOperationException(ExceptionResource.NotAGenericType);
            return this;
        }

        /// <summary>
        /// will return the correct count
        /// but always the values will always be typeof(object)
        /// </summary>
        /// <returns></returns>
        public Type[] GetGenericArguments()
        {
            return GenericInstanceFactory.GetGenericArguments(this);
        }

        /// <summary>
        /// this will only work with .NET types not java types.
        /// the returned type can only be used in Activator.CreateInstance,
        /// and is otherwise useless. 
        /// <para>
        /// In particular the class name, methods, fields, constructors and 
        /// properties as well as the superclass and implemented interfaces can
        /// all not be retrieved from this type.
        /// </para>
        /// </summary>
        public Type MakeGenericType(params Type[] typeArguments)
        {
            return GenericInstanceFactory.GetOrMakeGenericRuntimeType(this, typeArguments);
        }


        /// <summary>
        /// returns true is this is a generic type.
        /// [ should only return true for true GenericTypeDefinitions ]
        /// </summary>
        public bool ContainsGenericParameters
        {
            get { return IsGenericType; }
        }

        /// <summary>
        /// returns true is this is a generic type.
        /// [ should only return true for true GenericTypeDefinitions ]
        /// </summary>
        public bool IsGenericTypeDefinition { get { return IsGenericType; } }

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
            return CustomAttributeProvider.GetCustomAttributes(this, inherit);
        }

        /// <summary>
        /// Returns an array of all attributes defined on this member of the given attribute type.
        /// Returns an empty array if no attributes are defined on this member.
        /// </summary>
        /// <param name="inherit">If true, look in base classes for inherited custom attributes.</param>
        public object[] GetCustomAttributes(Type attributeType, bool inherit)
        {
            return CustomAttributeProvider.GetCustomAttributes(this, attributeType, inherit);
        }

        /// <summary>
        /// Are one or more attributes of the given type defined on this member.
        /// </summary>
        /// <param name="attributeType">The type of the custom attribute</param>
        /// <param name="inherit">If true, look in base classes for inherited custom attributes.</param>
        public bool IsDefined(Type attributeType, bool inherit)
        {
            return CustomAttributeProvider.IsDefined(this, attributeType, inherit);
        }

        /// <summary>
        /// Gets all public constructors of this type.
        /// </summary>
        public ConstructorInfo[] GetConstructors()
        {
            return JavaGetConstructors()
                         .Where(x => Modifier.IsPublic(x.GetModifiers()))
                         .Select(x => new ConstructorInfo(x));
        }

        /// <summary>
        /// Gets all constructors of this type that match the given binding flags.
        /// </summary>
        public ConstructorInfo[] GetConstructors(BindingFlags flags)
        {
            var ctors = ((flags & BindingFlags.DeclaredOnly) != 0) ? JavaGetDeclaredConstructors() : JavaGetConstructors();
            
            return ctors.Where(x => Matches(x.GetModifiers(), flags))
                        .Select(x => new ConstructorInfo(x));
        }

        public ConstructorInfo GetConstructor(Type[] parameters)
        {
            try
            {
                return new ConstructorInfo(JavaGetConstructor(parameters));
            }
            catch (MissingMethodException)
            {
                return null;
            }
        }

	    public Type[] GetInterfaces()
	    {
	        return JavaGetInterfaces();
	    }

        /// <summary>
        /// Gets all public fields of this type.
        /// </summary>
        public FieldInfo[] GetFields()
        {
            return JavaGetFields().Where(x => Modifier.IsPublic(x.GetModifiers()))
                                  .Select(x => new FieldInfo(x));
        }

        public FieldInfo GetField(string name)
        {
            // NOTE: doesn't throw AmbiguousMatchException
            try
            {
                return new FieldInfo(JavaGetField(name));
            }
            catch (MissingFieldException) 
            {
                return null;
            }
        }

        public FieldInfo GetField(string name, BindingFlags flags)
        {
            var fields = ((flags & BindingFlags.DeclaredOnly) != 0) ? JavaGetDeclaredFields() : JavaGetFields();
            var ret = fields.Where(x => Matches(x.GetModifiers(), flags) && x.Name == name);
            if(ret.Length > 1)
                throw new AmbiguousMatchException();
            return ret.Length == 0 ? null : new FieldInfo(ret[0]);
        }

        /// <summary>
        /// Gets all fields of this type that match the given binding flags.
        /// </summary>
        public FieldInfo[] GetFields(BindingFlags flags)
        {
            var fields = ((flags & BindingFlags.DeclaredOnly) != 0) ? JavaGetDeclaredFields() : JavaGetFields();
            return fields.Where(x => Matches(x.GetModifiers(), flags))
                         .Select(x => new FieldInfo(x));
        }

        /// <summary>
        /// Gets all public methods of this type.
        /// </summary>
        public MethodInfo[] GetMethods()
        {
            return JavaGetMethods().Where(x => Modifier.IsPublic(x.GetModifiers()))
                                   .Select(x=> new MethodInfo(x));
        }

        /// <summary>
        /// Gets all methods of this type that match the given binding flags.
        /// </summary>
        public MethodInfo[] GetMethods(BindingFlags flags)
        {
            var methods = ((flags & BindingFlags.DeclaredOnly) != 0) ? JavaGetDeclaredMethods() : JavaGetMethods();
            return methods.Where(x => Matches(x.GetModifiers(), flags))
                          .Select(x=> new MethodInfo(x));
        }

        public MethodInfo GetMethod(string name)
        {
            // NOTE: doesn't throw AmbiguousMatchException
            try
            {
                return new MethodInfo(JavaGetMethod(name));
            }
            catch (MissingMethodException)
            {
                return null;
            }
        }

        public MethodInfo GetMethod(string name, Type[] parameters)
        {
            // NOTE: doesn't throw AmbiguousMatchException
            try
            {
                return new MethodInfo(JavaGetMethod(name, parameters));
            }
            catch (MissingMethodException)
            {
                return null;
            } 
        }

        /// <summary>
        /// Gets all public properties of this type.
        /// </summary>
        public PropertyInfo[] GetDeclaredProperties()
        {
            return PropertyInfoProvider.GetProperties(this);
        }

	    public PropertyInfo[] GetProperties()
	    {
	        return GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static);
	    }

        public PropertyInfo[] GetProperties(BindingFlags flags)
        {
            List<PropertyInfo> ret = new List<PropertyInfo>();
            Type type = this;
            
            // we have to walk all the ways up.
            while (type != null)
            {
                foreach(var prop in type.GetDeclaredProperties())
                    if (IsMatch(prop, flags))
                        ret.Add(prop);

                if ((flags & BindingFlags.DeclaredOnly) != 0)
                    break;

                type = type.GetSuperclass();
            }
            return ret.ToArray();
        }

        public PropertyInfo GetProperty(string name)
        {
            return GetProperty(name, BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static);
        }

        public PropertyInfo GetProperty(string name, BindingFlags flags)
        {
            var props = GetProperties(flags).Where(p => p.Name == name);

            if (props.Length > 1)
                throw new AmbiguousMatchException("not unique: " + name);

            return props.Length == 0 ? null : props[0];
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

        public MemberInfo[] GetMember(string memberName, BindingFlags flags)
        {
            List<MemberInfo> ret = new List<MemberInfo>();
            if (memberName == ".cctor")
                ret.AddRange(GetConstructors(flags));
            ret.AddRange(GetFields(flags).Where(f => f.Name == memberName));
            ret.AddRange(GetMethods(flags).Where(f => f.Name == memberName));
            ret.AddRange(GetProperties(flags).Where(f => f.Name == memberName));
            //ret.AddRange(GetEvents);
            return ret.ToArray();
        }

        public MemberInfo[] GetMembers(BindingFlags flags)
        {
            List<MemberInfo> ret = new List<MemberInfo>();
            ret.AddRange(GetFields(flags));
            ret.AddRange(GetMethods(flags));
            ret.AddRange(GetProperties(flags));
            //ret.AddRange(GetEvents);
            return ret.ToArray();
        }

        public /*virtual*/ bool IsAssignableFrom(Type other)
        {
            return JavaIsAssignableFrom(other);
            //    if (field.getType().equals(Integer.class) || field.getType().equals(int.class)) {
            //    return obj.getClass().equals(Integer.class) || field.getType().equals(int.class);
            //} else if (field.getType().equals(Float.class) || field.getType().equals(float.class)) {
            //    return obj.getClass().equals(Float.class) || field.getType().equals(float.class);
            //} else if (field.getType().equals(Double.class) || field.getType().equals(double.class)) {
            //    return obj.getClass().equals(Double.class) || field.getType().equals(double.class);
            //} else if (field.getType().equals(Character.class) || field.getType().equals(char.class)) {
            //    return obj.getClass().equals(Character.class) || field.getType().equals(char.class);
            //} else if (field.getType().equals(Long.class) || field.getType().equals(long.class)) {
            //    return obj.getClass().equals(Long.class) || field.getType().equals(long.class);
            //} else if (field.getType().equals(Short.class) || field.getType().equals(short.class)) {
            //    return obj.getClass().equals(Short.class) || field.getType().equals(short.class);
            //} else if (field.getType().equals(Boolean.class) || field.getType().equals(boolean.class)) {
            //    return obj.getClass().equals(Boolean.class) || field.getType().equals(boolean.class);
            //} else if (field.getType().equals(Byte.class) || field.getType().equals(byte.class)) {
            //    return obj.getClass().equals(Byte.class) || field.getType().equals(byte.class);
            //}
            //return field.getType().isAssignableFrom(obj.getClass());
            //    if (o == null) return false;
            //    return IsAssignableFrom(o.GetType());
        }

        [Include,Inline] // used by "x is T" in generic methods.
        public /*virtual*/ bool IsInstanceOfType(Object o)
        {
            if (o == null) return false;
            return JavaIsAssignableFrom(o.GetType());
        }

        public /*virtual*/ bool IsSubclassOf(Type other)
        {
            Type t = this;
            while ((t = t.GetSuperclass()) != null)
            {
                if (t == other) return true;
            }
            return false;
        }

        /// <summary>
        /// this will return 1 for array types, as multidimensional arrays 
        /// are not really supported.
        /// </summary>
        /// <returns></returns>
	    public int GetArrayRank()
	    {
	        if(!IsArray )
                throw new InvalidOperationException("not an array");
	        return 1;
	    }

        /// <summary>
        /// Do the given modifiers of a member match the given binding flags?
        /// </summary>
        private static bool Matches(int modifiers, BindingFlags flags)
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

        [DexNative]
        public static Type GetTypeFromHandle(RuntimeTypeHandle handle)
        {
            return null;
        }

        public static TypeCode GetTypeCode(Type t)
        {
            throw new NotImplementedException("System.Type.GetTypeCode");
        }

	    public static Type GetType(string typeName)
	    {
	        return ForName(typeName);
	    }

        /// <summary>
        /// note that ignoreCase is not ignored.
        /// </summary>
        /// <returns></returns>
        public static Type GetType(string typeName, bool ignoreCase)
        {
            return Type.ForName(typeName);
        }
    }
}

