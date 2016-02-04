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
using Java.Lang.Annotation;

namespace Dot42.Internal
{
    /// <summary>
    /// Interface for annotation that stores the field of a generic type that holds the type arguments.
    /// </summary>
    [Include]
	internal interface ITypeReflectionInfo : IAnnotation
    {
        /// <summary>
        /// Gets the fieldname(s) that hold the type arguments.
        /// </summary>
        [Include]
        string[] GenericArgumentsFields();

        /// <summary>
        /// returns the number of generic arguments of this type
        /// </summary>
        /// <returns></returns>
        [Include]
        int GenericArgumentCount();

        /// <summary>
        /// holds information about generic parameter binding of 
        /// base class and interfaces.
        /// </summary>
        /// <returns></returns>
        [Include]
        IGenericDefinition[] GenericDefinitions();

        /// <summary>
        /// this is used to be able to provide the original order for fields.
        /// (not required by the standard, but useful nonetheless for serialization)
        /// This will not be generated for synthetic classes, and not for static 
        /// or synthetic fields.
        /// </summary>
        [Include]
        string[] Fields();

    }
}

