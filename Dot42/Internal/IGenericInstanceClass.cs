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
using System.Reflection;
using Java.Lang.Annotation;

namespace Dot42.Internal
{
    /// <summary>
    /// Interface for annotation that stores the field of a generic type that holds the type arguments.
    /// </summary>
    [Include]
	internal interface IGenericInstanceClass : IAnnotation
    {
        ///// <summary>
        ///// Gets the field to holds the type arguments.
        ///// </summary>
        //[Include]
        //FieldInfo Arguments();

        [Include]
        int ArgumentCount();

    }
}

