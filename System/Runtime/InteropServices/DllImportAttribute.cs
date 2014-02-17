// Copyright (C) 2014 dot42
//
// Original filename: DllImportAttribute.cs
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
using Dot42;

namespace System.Runtime.InteropServices
{
    /// <summary>
    /// Indicates that the attributed method is exposed by an unmanaged dynamic-link library (DLL) as a static entry point.
    /// </summary>
    [ComVisibleAttribute(true)]
    [AttributeUsageAttribute(AttributeTargets.Method, Inherited = false)]
    [Ignore]
    public sealed class DllImportAttribute : Attribute
	{
        private readonly string dllName;

        /// <summary>
        /// Default ctor
        /// </summary>
	    public DllImportAttribute(string dllName)
        {
            this.dllName = dllName;
        }

        /// <summary>
        /// Gets the name of the DLL file that contains the entry point.
        /// </summary>
	    public string Value
	    {
            get { return dllName; }
	    }

        /// <summary>
        /// Ignored 
        /// </summary>
        public bool BestFitMapping;

        /// <summary>
        /// Ignored 
        /// </summary>
        public CallingConvention CallingConvention;

        /// <summary>
        /// Ignored 
        /// </summary>
        public CharSet CharSet;

        /// <summary>
        /// Ignored 
        /// </summary>
        public string EntryPoint;

        /// <summary>
        /// Ignored 
        /// </summary>
        public bool ExactSpelling;

        /// <summary>
        /// Ignored 
        /// </summary>
        public bool PreserveSig;

        /// <summary>
        /// Ignored 
        /// </summary>
        public bool SetLastError;

        /// <summary>
        /// Ignored 
        /// </summary>
        public bool ThrowOnUnmappableChar;
	}
}

