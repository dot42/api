// Copyright (C) 2014 dot42
//
// Original filename: CyclicBarrier.cs
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
namespace Java.Util.Concurrent
{
	partial class CyclicBarrier
	{
        /// <summary>
        /// <para>Creates a new <code>CyclicBarrier</code> that will trip when the given number of parties (threads) are waiting upon it, and which will execute the given barrier action when the barrier is tripped, performed by the last thread entering the barrier.</para><para></para>        
        /// </summary>
        [Dot42.DexImport("<init>", "(ILjava/lang/Runnable;)V", AccessFlags = 1, IgnoreFromJava = true)]
        public CyclicBarrier(int parties, global::System.Action barrierAction) 
        {
        }
	}
}

