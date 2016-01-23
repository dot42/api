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
    /// Interface for annotation that stores which parameters make up
    /// a generic field, generic method (return) parameter, or a generic
    /// inheritance. This allows for reflection to properly emulate 
    /// .NET behavior.
    /// <para>
    /// As we need a recursive description to allow for nested generic
    /// definitions, we make use of a simple string syntax.
    /// </para>
    /// </summary>
    [Include]
	internal interface IGenericDefinition : IAnnotation
    {
        /// <summary>
        /// TODO: specify the syntax used. currently only implicit specified
        ///       through DefinitionParser.
        /// </summary>
        string Definition();
    }
    
}

