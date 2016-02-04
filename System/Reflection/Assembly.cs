// Copyright (C) 2015 Olaf Pettersson
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
using System.Linq;
using Dot42.Internal;
using Java.Util;

namespace System.Reflection
{
	public class Assembly
    {
        internal static Assembly DefaultAssembly = new Assembly(null);

        private readonly string _name;
        private readonly ArrayList<string> _types = new ArrayList<string>();

	    public string FullName { get { return _name ?? "classes.dex"; } }

        internal Assembly(string name)
        {
            _name = name;
        }

        // This is only called during the static initialization of 
        // AssemblyTypes and therefore needs not be synchronized.
        internal void AddType(string binaryName)
        {
            _types.Add(binaryName);
        }

        public Type GetType(string typeName)
        {
            var classloader = typeof (Assembly).GetClassLoader();
            return classloader.LoadClass(typeName);
        }

	    public IEnumerable<TypeInfo> DefinedTypes
	    {
	        get
	        {
                var classloader = typeof(Assembly).GetClassLoader();
                return _types.Select(soCalledBinaryName => new TypeInfo(classloader.LoadClass(soCalledBinaryName)));
	        }
	    }
	    
	    public override string ToString()
	    {
	        return FullName;
	    }

	    /// <summary>
        /// This is not implemented, and will always return the DefaultAssembly.
        /// </summary>
        public static Assembly Load(string load)
        {
            return DefaultAssembly;
        }

        /// <summary>
        /// Gets the currently loaded assembly in which the specified class is defined.
        /// </summary>
        public static Assembly GetAssembly(Type type)
        {
            return AssemblyTypes.GetAssemblyFromType(type);
        }

        /// <summary>
        /// Gets the Assembly of the method that invoked the currently executing method.
        /// </summary>
        public static Assembly GetCallingAssembly()
        {
            string className = new Exception().JavaStackTrace[2].ClassName;
            return typeof (Assembly).GetClassLoader().LoadClass(className).Assembly;
        }

        /// <summary>
        /// Gets the assembly that contains the code that is currently executing.
        /// </summary>
        public static Assembly GetExecutingAssembly()
        {
            string className = new Exception().JavaStackTrace[1].ClassName;
            return typeof(Assembly).GetClassLoader().LoadClass(className).Assembly;
        }

        /// <summary>
        /// Gets the process executable.
        /// </summary>
        public static Assembly GetEntryAssembly()
        {
            return AssemblyTypes.GetEntryAssembly();
        }
        
    }
}

