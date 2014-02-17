// Copyright (C) 2014 dot42
//
// Original filename: ConditionalAttribute.cs
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

namespace System.Diagnostics
{
    /// <summary>
    /// Indicates to compilers that a method call or attribute should be ignored unless a specified conditional compilation symbol is defined.
    /// </summary>
    [SerializableAttribute]
    [ComVisible(true)]
    [AttributeUsageAttribute(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
    [Ignore]
    public sealed class ConditionalAttribute : Attribute
	{
        private readonly string conditionString;

        public ConditionalAttribute(string conditionString)
        {
            this.conditionString = conditionString;
        }

        public string ConditionString
        {
            get { return conditionString; }
        }
	}
}

