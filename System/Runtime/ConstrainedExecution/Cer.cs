// Copyright (C) 2014 dot42
//
// Original filename: Cer.cs
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
namespace System.Runtime.ConstrainedExecution
{
	public enum Cer
	{
        /// <summary>The method, type, or assembly has no concept of a CER. It does not take advantage of CER guarantees. This implies the following:</summary>
        None,
        /// <summary>In the face of exceptional conditions, the method might fail. In this case, the method will report back to the calling method whether it succeeded or failed. The method must have a CER around the method body to ensure that it can report the return value.</summary>
        MayFail,
        /// <summary>In the face of exceptional conditions, the method is guaranteed to succeed. You should always construct a CER around the method that is called, even when it is called from within a non-CER region. A method is successful if it accomplishes what is intended. For example, marking <see cref="P:System.Collections.ArrayList.Count" /> with ReliabilityContractAttribute(Cer.Success) implies that when it is run under a CER, it always returns a count of the number of elements in the <see cref="T:System.Collections.ArrayList" /> and it can never leave the internal fields in an undetermined state.</summary>
        Success
	}
}

