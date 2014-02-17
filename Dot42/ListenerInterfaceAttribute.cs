// Copyright (C) 2014 dot42
//
// Original filename: ListenerInterfaceAttribute.cs
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

namespace Dot42
{
    /// <summary>
    /// Specifies the interface type that this event uses.
    /// </summary>
    [AttributeUsage(AttributeTargets.Event)]
    [Ignore]
    internal sealed class ListenerInterfaceAttribute : Attribute
    {
        internal ListenerInterfaceAttribute(Type listenerInterface)
        {
        }

        internal ListenerInterfaceAttribute(string listenerInterfaceClassName)
        {
        }
    }
}

