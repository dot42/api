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
    /// an generic field or method return parameter.
    /// 
    /// Only one of the fields can contain en entry.
    /// </summary>
    [Include]
	internal interface IGenericMember : IAnnotation
    {
        /// <summary>
        /// can contain a mixture of ints as index into the 
        /// generic arguments field (typically $g)
        /// and System.Type's for fixed arguments.
        /// The type of the member will be the generic definition.
        /// </summary>
        [Include]
        object[] GenericArguments();

        /// <summary>
        /// can contains 0 or one element, in which case 
        /// the member is represented by this specialized class
        /// </summary>
        /// <returns></returns>
        [Include]
        Type[] GenericInstanceType();

        /// <summary>
        /// If != -1 this is the index into the parents generic arguments.
        /// </summary>
        [Include]
        int GenericParameter();

    }
}

