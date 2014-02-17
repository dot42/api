// Copyright (C) 2014 dot42
//
// Original filename: ArgumentException.cs
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
using System.Runtime.InteropServices;

namespace System
{
    /// <summary>
    /// The exception that is thrown when one of the arguments provided to a method is not valid.
    /// </summary>
    [SerializableAttribute]
    [ComVisible(true)]
    partial class ArgumentException 
    {
        /// <summary>
        /// Default ctor
        /// </summary>
        public ArgumentException(string message, string paramName)
            : this(message)
        {
        }

        /// <summary>
        /// Default ctor
        /// </summary>
        public ArgumentException(string message, string paramName, Exception innerException)
            : base(message, innerException)
        {
        }

        /// <summary>
        /// Name of the parameter that caused the exception.
        /// </summary>
        public string ParamName
        {
            get { return ""; }
        }
    }
}

