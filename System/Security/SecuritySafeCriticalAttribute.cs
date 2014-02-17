// Copyright (C) 2014 dot42
//
// Original filename: SecuritySafeCriticalAttribute.cs
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
using System;

namespace System.Security
{
    // Summary:
    //     Identifies types or members as security-critical and safely accessible by
    //     transparent code.
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Field | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
    public sealed class SecuritySafeCriticalAttribute : Attribute
    {
        // Summary:
        //     Initializes a new instance of the System.Security.SecuritySafeCriticalAttribute
        //     class.
        public SecuritySafeCriticalAttribute()
        {}
    }
}
