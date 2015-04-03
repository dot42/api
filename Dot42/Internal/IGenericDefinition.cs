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
    /// a generic field, generic method (return) parameter, or a generic
    /// inheritance.
    /// 
    /// - if <ref>GenericInstanceType</ref> is set, all other fields must be unset.
    /// - if this represents an inheritance, GenericTypeDefinition must be set, 
    ///   otherwise it will be inferred from the member/parameter type, if possible
    /// - 
    /// for 
    /// </summary>
    [Include]
	internal interface IGenericDefinition : IAnnotation
    {
        /// <summary>
        /// if set (ie. !typeof(object)) the member is 
        /// represented by this specialized class
        /// </summary>
        /// <returns></returns>
        [Include]
        Type GenericInstanceType();

        /// <summary>
        /// If != -1 this is the index into the parents generic arguments.
        /// This is mutually exclusive to GenericTypeDefinition.
        /// </summary>
        [Include]
        int GenericParameter();

        /// <summary>
        /// if set (ie. !typeof(object)) this member contains the generic type definition type,
        /// further specified though arguments below. Will always be set for inheritance; can
        /// be set for members or parameter.
        /// </summary>
        /// <returns></returns>
        [Include]
        Type GenericTypeDefinition();

        /// <summary>
        /// These are the arguments for a generic type denoted by
        /// either GenericParameter, GenericTypeDefinition or the
        /// annotated member/parameter. 
        /// 
        /// Can contain a mixture of ints as index into the 
        /// generic arguments of the containing class, System.Type's 
        /// for fixed arguments or IGenericDefinitions for 
        /// nested generic types.
        /// </summary>
        [Include]
        object[] GenericArguments();
    }
}
