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
using System.Reflection;
using Java.Lang.Annotation;

namespace Dot42.Internal
{
    /// <summary>
    /// Annotation interface for property metadata.
    /// </summary>
    internal interface IProperty : IAnnotation
    {
        /// <summary>
        /// Property name.
        /// </summary>
        [Include(TypeCondition = typeof(PropertyInfo))]
        string Name();

        /// <summary>
        /// Getter.
        /// Returned array must be length 0 or 1
        /// </summary>
        [Include(TypeCondition = typeof(PropertyInfo))]
        MethodInfo[] Get();

        /// <summary>
        /// Setter.
        /// Returned array must be length 0 or 1
        /// </summary>
        [Include(TypeCondition = typeof(PropertyInfo))]
        MethodInfo[] Set();

        /// <summary>
        /// Custom attributes of this property.
        /// Returned array must be length 0 or 1
        /// </summary>
        [Include(TypeCondition = typeof(PropertyInfo))]
        IAttributes[] Attributes();
    }
}

