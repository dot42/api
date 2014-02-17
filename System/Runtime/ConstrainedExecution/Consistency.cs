// Copyright (C) 2014 dot42
//
// Original filename: Consistency.cs
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
    [Serializable]
    public enum  Consistency
	{
        /// <summary>In the face of exceptional conditions, the CLR makes no guarantees regarding state consistency; that is, the condition might corrupt the process.</summary>
        MayCorruptProcess,
        /// <summary>In the face of exceptional conditions, the common language runtime (CLR) makes no guarantees regarding state consistency in the current application domain.</summary>
        MayCorruptAppDomain,
        /// <summary>In the face of exceptional conditions, the method is guaranteed to limit state corruption to the current instance.</summary>
        MayCorruptInstance,
        /// <summary>In the face of exceptional conditions, the method is guaranteed not to corrupt state. </summary>
        WillNotCorruptState
	}
}

