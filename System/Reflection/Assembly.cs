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
namespace System.Reflection
{
    /// <summary>
    /// This class is not implemented.
    /// </summary>
	public abstract class Assembly
	{
        /// <summary>
        /// Gets the currently loaded assembly in which the specified class is defined.
        /// </summary>
        /// <remarks>
        /// This method is not implemented.
        /// </remarks>
        public static Assembly GetAssembly(Type type)
        {
            throw new NotImplementedException("System.Reflection.Assembly.GetAssembly");
        }

        /// <summary>
        /// Gets the Assembly of the method that invoked the currently executing method.
        /// </summary>
        /// <remarks>
        /// This method is not implemented.
        /// </remarks>
        public static Assembly GetCallingAssembly()
        {
            throw new NotImplementedException("System.Reflection.Assembly.GetCallingAssembly");
        }

        /// <summary>
        /// Gets the process executable.
        /// </summary>
        /// <remarks>
        /// This method is not implemented.
        /// </remarks>
        public static Assembly GetEntryAssembly()
        {
            throw new NotImplementedException("System.Reflection.Assembly.GetEntryAssembly");
        }

        /// <summary>
        /// Gets the assembly that contains the code that is currently executing.
        /// </summary>
        /// <remarks>
        /// This method is not implemented.
        /// </remarks>
        public static Assembly GetExecutingAssembly()
        {
            throw new NotImplementedException("System.Reflection.Assembly.GetExecutingAssembly");
        }
    }
}

