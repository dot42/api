// Copyright (C) 2014 dot42
//
// Original filename: ExecutorCompletionService.cs
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
	partial class ExecutorCompletionService<V>
	{
        /// <summary>
        /// <para>Submits an Action task for execution and returns a Future representing that task. Upon completion, this task may be taken or polled.</para><para></para>        
        /// </summary>
        /// <returns>
        /// <para>a Future representing pending completion of the task, and whose <code>get()</code> method will return the given result value upon completion </para>
        /// </returns>
        /// <java-name>
        /// submit
        /// </java-name>
        [Dot42.DexImport("submit", "(Ljava/lang/Runnable;Ljava/lang/Object;)Ljava/util/concurrent/Future;", AccessFlags = 1, Signature = "(Ljava/lang/Runnable;TV;)Ljava/util/concurrent/Future<TV;>;", IgnoreFromJava = true)]
        public global::Java.Util.Concurrent.IFuture<V> Submit(global::System.Action task, V result) /* MethodBuilder.Create */
        {
            return default(global::Java.Util.Concurrent.IFuture<V>);
        }
	}
}

