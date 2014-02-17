// Copyright (C) 2014 dot42
//
// Original filename: ArgumentOutOfRangeException.cs
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
    /// The exception that is thrown when the value of an argument is outside the allowable range of values as defined by the invoked method.
    /// </summary>
    [SerializableAttribute]
    [ComVisible(true)]
    public class ArgumentOutOfRangeException : ArgumentException
	{
        /// <summary>
        /// Default ctor
        /// </summary>
        public ArgumentOutOfRangeException()
        {            
        }

        /// <summary>
        /// Default ctor
        /// </summary>
        public ArgumentOutOfRangeException(string paramName) 
            : base(paramName)
        {
        }

        /// <summary>
        /// Default ctor
        /// </summary>
        public ArgumentOutOfRangeException(string paramName, string message)
            : base(paramName)
        {
        }

        /// <summary>
        /// Default ctor
        /// </summary>
        public ArgumentOutOfRangeException(string paramName, object actualValue, string message)
            : base(paramName)
        {
        }

    }
}

