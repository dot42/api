// Copyright (C) 2014 dot42
//
// Original filename: FutureTask.cs
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
	partial class FutureTask<V>
	{

        /// <summary>
        /// <para>Creates a <c> FutureTask </c> that will, upon running, execute the given <c> Action </c> , and arrange that <c> get </c> will return the given result on successful completion.</para><para></para>        
        /// </summary>
        [Dot42.DexImport("<init>", "(Ljava/lang/Runnable;Ljava/lang/Object;)V", AccessFlags = 1, Signature = "(Ljava/lang/Runnable;TV;)V", IgnoreFromJava = true)]
        public FutureTask(global::System.Action runnable, V result) 
        {
        }
	}
}

