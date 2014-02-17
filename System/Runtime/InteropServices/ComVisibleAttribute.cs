// Copyright (C) 2014 dot42
//
// Original filename: ComVisibleAttribute.cs
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
    /// Controls accessibility of an individual managed type or member, or of all types within an assembly, to COM.
    /// </summary>
    [AttributeUsageAttribute(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface | AttributeTargets.Delegate, Inherited = false)]
    [ComVisibleAttribute(true)]
    [Ignore]
    public sealed class ComVisibleAttribute : Attribute
	{
	    private readonly bool visibility;

        /// <summary>
        /// Default ctor
        /// </summary>
	    public ComVisibleAttribute(bool visibility)
        {
            this.visibility = visibility;
        }

        /// <summary>
        /// Gets a value that indicates whether the COM type is visible.
        /// </summary>
	    public bool Value
	    {
            get { return visibility; }
	    }
	}
}

