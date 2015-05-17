// Copyright (C) 2014 dot42
//
// Original filename: IGenericInstanceClass.cs
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
using Java.Lang.Annotation;

namespace Dot42.Internal
{
    /// <summary>
    /// Annotation that preserves reflection information that would be lost in Java.
    /// </summary>
    [Include]
    internal interface IReflectionInfo : IAnnotation
    {
        /// <summary>
        /// Original AccessFlags:
        /// <para/> 0x00 - unset 
        /// <para/> 0x01 - public
        /// <para/> 0x02 - protected
        /// <para/> 0x04 - private
        /// <para/> 0x08 - internal
        /// </summary>
        [Include]
        int AccessFlags();

        /// <summary>
        /// When an annotation to a method, contains the method's parameter names.
        /// </summary>
        /// <returns></returns>
        [Include]
        string[] ParameterNames();
    }
}

