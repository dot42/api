// Copyright (C) 2014 dot42
//
// Original filename: IProperty.cs
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
using System.Reflection;
using Java.Lang.Annotation;

namespace Dot42.Internal
{
    /// <summary>
    /// Annotation interface for property metadata.
    /// </summary>
    [Include(TypeCondition = typeof(PropertyInfo))]
    internal interface IProperty : IAnnotation
    {
        /// <summary>
        /// Property name.
        /// </summary>
        [Include(TypeCondition = typeof(PropertyInfo))]
        string Name();

        /// <summary>
        /// Name of getter, if not default
        /// </summary>
        [Include(TypeCondition = typeof(PropertyInfo))]
        string Get();

        /// <summary>
        /// Name of setter, if not default
        /// </summary>
        [Include(TypeCondition = typeof(PropertyInfo))]
        string Set();

        /// <summary>
        /// Custom attributes of this property.
        /// </summary>
        [Include(TypeCondition = typeof(PropertyInfo))]
        IAttribute[] Attributes();

        /// <summary>
        /// Specifies the declaring type for framework properties.
        /// <para/>
        /// We use the decriptor, so that the type does not 
        /// need to be loaded by the ClassLoader when accessing
        /// the attribute.
        /// </summary>
        [Include(TypeCondition = typeof(IncludeFrameworkProperties))]
        string DeclaringTypeDescriptor();

    }
}

