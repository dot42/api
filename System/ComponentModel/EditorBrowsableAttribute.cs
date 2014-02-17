// Copyright (C) 2014 dot42
//
// Original filename: EditorBrowsableAttribute.cs
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

namespace System.ComponentModel
{
    [AttributeUsageAttribute(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Delegate)]
    [Ignore]
    public sealed class EditorBrowsableAttribute : Attribute
	{
        public EditorBrowsableState State { get; private set; }

        /// <summary>
        /// Default ctor
        /// </summary>
        public EditorBrowsableAttribute()
        {
            State = EditorBrowsableState.Always;
        }

        /// <summary>
        /// Default ctor
        /// </summary>
        public EditorBrowsableAttribute(EditorBrowsableState state)
        {
            State = state;
        }
    }
}

