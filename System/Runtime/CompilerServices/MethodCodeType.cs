// Copyright (C) 2014 dot42
//
// Original filename: MethodCodeType.cs
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
using System.Runtime.InteropServices;

namespace System.Runtime.CompilerServices
{
    /// <summary>Defines how a method is implemented.</summary>
    [ComVisible(true)]
    [Serializable]
	public enum MethodCodeType
	{
        /// <summary>Specifies that the method implementation is in Microsoft intermediate language (MSIL).</summary>
        IL,
        /// <summary>Specifies that the method is implemented in native code.</summary>
        Native,
        /// <summary>Specifies that the method implementation is in optimized intermediate language (OPTIL).</summary>
        OPTIL,
        /// <summary>Specifies that the method implementation is provided by the runtime.</summary>
        Runtime
	}
}

