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

using Android;
using Dalvik.System;
using Java.Lang;
using Java.Util;

namespace System.Reflection
{
    /// <summary>
    /// This class is only a stub.
    /// </summary>
	public class Assembly
    {
        private readonly ClassLoader _loader;
        private static readonly WeakHashMap<ClassLoader, Assembly> Assemblies = new WeakHashMap<ClassLoader, Assembly>();

        public string FullName { get { return "classLoader" + _loader.GetHashCode(); } }

        public Assembly(ClassLoader loader)
        {
            _loader = loader;
        }

        public Type GetType(string typeName)
        {
            return _loader.FindClass(typeName); 
        }
        
        /// <summary>
        /// this is not implemented, and will always return the system classloader.
        /// </summary>
        /// <param name="load"></param>
        /// <returns></returns>
        public static Assembly Load(string load)
        {
            return FromClassloader(ClassLoader.SystemClassLoader);
        }


        /// <summary>
        /// Gets the currently loaded assembly in which the specified class is defined.
        /// </summary>
        /// <remarks>
        /// This method is not implemented.
        /// </remarks>
        public static Assembly GetAssembly(Type type)
        {
            return FromClassloader(type.GetClassLoader());
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
            return FromClassloader(ClassLoader.SystemClassLoader);
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
            return FromClassloader(ClassLoader.SystemClassLoader);
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
            return FromClassloader(ClassLoader.SystemClassLoader);
        }

        private static Assembly FromClassloader(ClassLoader c)
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

