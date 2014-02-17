// Copyright (C) 2014 dot42
//
// Original filename: EventHandlerAttribute.cs
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
    /// Indicates that the method to which this attribute is attached is an event handler that can be referenced from a layout file.
    /// Attaching this attribute to a method will ensure that the method is included in the Android Package and is not renamed.
    /// </summary>
    [AttributeUsage(AttributeTargets.Method)]
    [Ignore]
    public sealed class EventHandlerAttribute : Attribute
    {
    }
}

