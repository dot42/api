// Copyright (C) 2014 dot42
//
// Original filename: AbstractExecutorService.cs
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
using Dot42;

namespace Java.Util.Concurrent
{
    [ApiEnhancementIgnoreMethods("Execute", "Remove")]
    partial class AbstractExecutorService
	{
        /// <summary>
        /// Submits an Action task for execution and returns a Future representing that task. The Future's get method will return the given result upon successful completion.
        /// </summary>
        /// <java-name>
        /// submit
        /// </java-name>
        [Dot42.DexImport("submit", "(Ljava/lang/Runnable;Ljava/lang/Object;)Ljava/util/concurrent/Future;", AccessFlags = 1, Signature = "<T:Ljava/lang/Object;>(Ljava/lang/Runnable;TT;)Ljava/util/concurrent/Future<TT;>;", IgnoreFromJava = true)]
        public global::Java.Util.Concurrent.IFuture<T> Submit<T>(global::System.Action task, T result) 
        {
            return default(global::Java.Util.Concurrent.IFuture<T>);
        }

        ///<summary>
        /// Submits an Action task for execution and returns a Future representing that task. The Future's get method will return null upon successful completion.
        /// </summary>
        /// <java-name>
        /// submit
        /// </java-name>
        [Dot42.DexImport("submit", "(Ljava/lang/Runnable;)Ljava/util/concurrent/Future;", AccessFlags = 1, Signature = "(Ljava/lang/Runnable;)Ljava/util/concurrent/Future<*>;", IgnoreFromJava = true)]
        public virtual global::Java.Util.Concurrent.IFuture<object> Submit(global::System.Action runnable) 
        {
            return default(global::Java.Util.Concurrent.IFuture<object>);
        }
    }
}

