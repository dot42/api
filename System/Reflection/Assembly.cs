// Copyright (C) 2014 dot42
//
// Original filename: Assembly.cs
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
using System.IO;
using Android.App;
using Android.Content;
using Dalvik.System;
using Dot42;
using Java.Lang;
using Java.Lang.Ref;
using Java.Util;

namespace System.Reflection
{
    /// <summary>
    /// This class is mostly a stub.
    /// </summary>
	public class Assembly
    {
        private static Context _applicationContext;
        private static readonly WeakHashMap<ClassLoader, Assembly> Assemblies = new WeakHashMap<ClassLoader, Assembly>();

        private readonly ClassLoader _loader;
        private SoftReference<Type[]> _types;
        

        public string FullName { get { return "classLoader" + _loader.GetHashCode(); } }

        public Assembly(ClassLoader loader)
        {
            _loader = loader;
        }

        public Type GetType(string typeName)
        {
            return _loader.LoadClass(typeName); 
        }

        public IEnumerable<TypeInfo> DefinedTypes { get { return GetTypes().Select(t=>new TypeInfo(t)); } }

        public Type[] GetTypes()
        {
            Type[] ret = _types == null ? null : _types.Get();

            if (ret == null)
            {
                ret = GetTypesImpl();
                _types = new SoftReference<Type[]>(ret);
            }
            return ret;
        }

        private Type[] GetTypesImpl()
        {
            // from http://stackoverflow.com/questions/15446036/find-all-classes-in-a-package-in-android
            // another approach might be http://mindtherobot.com/blog/737/android-hacks-scan-android-classpath/
            if (_applicationContext == null)
                throw new InvalidOperationException("call SetApplicationContext before using GetTypes()");

            DexFile dex = null;

            try
            {
                List<Type> ret = new List<Type>();
                dex = new DexFile(_applicationContext.PackageCodePath);

                var e = dex.Entries();
                while (e.HasMoreElements)
                {
                    string className = e.NextElement();
                    Type type = _loader.LoadClass(className);
                    ret.Add(type);
                }

                return ret.ToArray();
            }
            catch (Exception e)
            {
                throw new ReflectionTypeLoadException(e);
            }
            finally
            {
                if (dex != null)
                    dex.Close();
            }
        }

        /// <summary>
        /// this is not implemented, and will always return the classloader of 
        /// the AssemblyClass
        /// </summary>
        /// <param name="load"></param>
        /// <returns></returns>
        public static Assembly Load(string load)
        {
            return FromClassLoader(typeof(Assembly).GetClassLoader());
        }


        /// <summary>
        /// Gets the currently loaded assembly in which the specified class is defined.
        /// </summary>
        public static Assembly GetAssembly(Type type)
        {
            return FromClassLoader(type.GetClassLoader());
        }

        /// <summary>
        /// Gets the Assembly of the method that invoked the currently executing method.
        /// </summary>
        /// <remarks>
        /// This method always returns the assembly corresponding 
        /// to the sytem class loader
        /// </remarks>
        public static Assembly GetCallingAssembly()
        {
            return FromClassLoader(typeof(Assembly).GetClassLoader());
        }

        /// <summary>
        /// Gets the process executable.
        /// </summary>
        /// <remarks>
        /// This method always returns the assembly corresponding 
        /// to the sytem class loader
        /// </remarks>
        public static Assembly GetEntryAssembly()
        {
            return FromClassLoader(typeof(Assembly).GetClassLoader());
        }

        /// <summary>
        /// Gets the assembly that contains the code that is currently executing.
        /// </summary>
        /// <remarks>
        /// This method always returns the assembly corresponding 
        /// to the sytem class loader
        /// </remarks>
        public static Assembly GetExecutingAssembly()
        {
            return FromClassLoader(typeof(Assembly).GetClassLoader());
        }

        public static void SetApplicationContext(Context ctx)
        {
            _applicationContext = ctx;
        }

        private static Assembly FromClassLoader(ClassLoader c)
        {
            lock (Assemblies)
            {
                Assembly ret = Assemblies.Get(c);
                if (ret == null)
                {
                    ret = new Assembly(c);
                    Assemblies.Put(c, ret);
                }
                return ret;
            }
        }

    }
}

