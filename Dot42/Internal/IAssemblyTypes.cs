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
    /// Holds information on to which assembly a type belongs to.
    /// </summary>
    [Include(TypeCondition = typeof(AssemblyTypes))]
	internal interface IAssemblyTypes : IAnnotation
    {
        /// <summary>
        /// Contains strings an 'Type's, each type belonging to
        /// the assembly denoted by the last string.
        /// </summary>
        [Include]
        object[] AssemblyTypeList();
    }
}

