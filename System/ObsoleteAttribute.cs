// Copyright (C) 2014 dot42
//
// Original filename: ObsoleteAttribute.cs
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
using Dot42;

namespace System
{
    [SerializableAttribute]
    [AttributeUsageAttribute(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Delegate, Inherited = false)]
    [ComVisible(true)]
    [Ignore]
    public /*sealed*/ class ObsoleteAttribute : Attribute
	{
        /// <summary>
        /// Default ctor
        /// </summary>
        public ObsoleteAttribute()
        {
            IsError = false;
            Message = null;
        }

        /// <summary>
        /// Message ctor
        /// </summary>
        public ObsoleteAttribute(string message)
        {
            Message = message;
            IsError = false;
        }

        /// <summary>
        /// Message and IsError ctor
        /// </summary>
        public ObsoleteAttribute(string message, bool error)
        {
            Message = message;
            IsError = error;
        }

        public bool IsError { get; private set; }
        public string Message { get; private set; }
	}
}

