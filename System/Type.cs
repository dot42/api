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
using Java.Lang.Reflect;
using Java.Util;

namespace System
{
	/*abstract*/ partial class Type : ICustomAttributeProvider
	{
        /// <summary>
        /// Gets the assembly-qualified name of the Type, which includes the name of the assembly from which the Type was loaded.
        /// Not implemented.
        /// </summary>
	    public string AssemblyQualifiedName
	    {
            get { throw new NotImplementedException("System.Type.AssemblyQualifiedName"); }
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
        /// This will always return false, since Android does not support value types.
        /// </summary>
	    public bool IsValueType
	    {
            get { return false; }
	    }

	    public bool IsGenericType
	    {
            get { return this.GetTypeParameters().Length > 0; }
	    }

	    public bool IsClass
	    {
            get { return !IsPrimitive && !IsInterface && !IsEnum; }
	    }

        public Type BaseType
        {
            get { return GetSuperclass(); }
        }

        /// <summary>
        /// return always false, since java does not support abstract classes.
        /// </summary>
        public bool IsAbstract
        {
            get { return Modifier.IsAbstract(GetModifiers()); }
        }

        /// <summary>
        /// returns always false, since we do not support MakeGenericType atm.
        /// </summary>
        public bool IsGenericTypeDefinition { get { return false; } }

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

        public Type GetGenericTypeDefinition()
        {
            throw new NotImplementedException("System.Type.GetGenericTypeDefinition");
        }

        public Type[] GetGenericArguments()
        {
            throw new NotImplementedException("System.Type.GetGenericArguments");
        }

        public static TypeCode GetTypeCode(Type t)
        {
            throw new NotImplementedException("System.Type.GetTypeCode");
        }

        public Type MakeGenericType(params Type[] typeArguments)
        {
            throw new NotImplementedException("System.Type.MakeGenericType");
        }

        [DexNative]
        public static Type GetTypeFromHandle(RuntimeTypeHandle handle)
        {
            return null;
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
            return JavaGetConstructors().Where(x => x.IsPublic);
        }

        /// <summary>
        /// Gets all constructors of this type that match the given binding flags.
        /// </summary>
        public ConstructorInfo[] GetConstructors(BindingFlags flags)
        {
            var ctors = ((flags & BindingFlags.DeclaredOnly) != 0) ? GetDeclaredConstructors() : JavaGetConstructors();
            return ctors.Where(x => Matches(x.GetModifiers(), flags));
        }

        public ConstructorInfo GetConstructor(Type[] parameters)
        {
            return JavaGetConstructor(parameters);
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
            return JavaGetFields().Where(x => x.IsPublic);
        }

        public FieldInfo GetField(string name)
        {
            return JavaGetField(name);
        }

        /// <summary>
        /// Gets all fields of this type that match the given binding flags.
        /// </summary>
        public FieldInfo[] GetFields(BindingFlags flags)
        {
            var fields = ((flags & BindingFlags.DeclaredOnly) != 0) ? GetDeclaredFields() : JavaGetFields();
            return fields.Where(x => Matches(x.GetModifiers(), flags));
        }

        /// <summary>
        /// Gets all public methods of this type.
        /// </summary>
        public MethodInfo[] GetMethods()
        {
            return JavaGetMethods().Where(x => x.IsPublic);
        }

        /// <summary>
        /// Gets all methods of this type that match the given binding flags.
        /// </summary>
        public MethodInfo[] GetMethods(BindingFlags flags)
        {
            var methods = ((flags & BindingFlags.DeclaredOnly) != 0) ? GetDeclaredMethods() : JavaGetMethods();
            return methods.Where(x => Matches(x.GetModifiers(), flags));
        }

        public MethodInfo GetMethod(string name, Type[] parameters)
        {
            return JavaGetMethod(name, parameters);
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
	        return GetProperties(BindingFlags.Public | BindingFlags.CreateInstance | BindingFlags.Static);
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
            return GetProperties(BindingFlags.Public).First(p => p.Name == name);
        }

        private static bool IsMatch(PropertyInfo propertyInfo, BindingFlags flags)
        {
            bool incPublic = (flags & BindingFlags.Public) == BindingFlags.Public;
            bool incNonPublic = (flags & BindingFlags.NonPublic) == BindingFlags.NonPublic;
            bool incStatic = (flags & BindingFlags.Static) == BindingFlags.Static;
            bool incInstance = (flags & BindingFlags.Instance) == BindingFlags.Instance;

            var get = propertyInfo.GetGetMethod();
            var set = propertyInfo.GetSetMethod();

            return (incPublic && ((get != null && get.IsPublic) || (set != null && set.IsPublic)))
                   || (incNonPublic && ((get != null && !get.IsPublic) || (set != null && !set.IsPublic)))
                   || (incStatic && ((get != null && get.IsStatic) || (set != null && set.IsStatic)))
                   || (incInstance && ((get != null && !get.IsStatic) || (set != null && !set.IsStatic)));
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

        
        
        

        public /*virtual*/ bool IsInstanceOfType(Object o)
        {
            if (o == null) return false;
            return IsAssignableFrom(o.Type);
        }

        public /*virtual*/ bool IsSubclassOf(Type other)
        {
            Type t;
            while ((t = Type.GetSuperclass()) != null)
            {
                if (t == other) return true;
            }
            return false;
        }
    }
}

