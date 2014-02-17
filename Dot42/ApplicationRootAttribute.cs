// Copyright (C) 2014 dot42
//
// Original filename: ApplicationRootAttribute.cs
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
    /// Indicates that the type to which an attribute derived of this this attribute is attached is a root for the application.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    [Ignore]
    public class ApplicationRootAttribute : Attribute
    {
        /// <summary>
        /// When set to true, the set of root types for application project includ types extended from the type to which this attribute it attached.
        /// </summary>
        public bool IncludeDerivedTypes { get; set; }
    }
}

