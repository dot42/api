// Copyright (C) 2014 dot42
//
// Original filename: Executors.cs
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
	partial class Executors
	{
        /// <summary>
        /// <para>Returns a Callable object that, when called, runs the given task and returns the given result. This can be useful when applying methods requiring a <code>Callable</code> to an otherwise resultless action. </para>        
        /// </summary>
        /// <returns>
        /// <para>a callable object </para>
        /// </returns>
        /// <java-name>
        /// callable
        /// </java-name>
        [Dot42.DexImport("callable", "(Ljava/lang/Runnable;Ljava/lang/Object;)Ljava/util/concurrent/Callable;", AccessFlags = 9, Signature = "<T:Ljava/lang/Object;>(Ljava/lang/Runnable;TT;)Ljava/util/concurrent/Callable<TT;" +
">;", IgnoreFromJava = true)]
        public static global::Java.Util.Concurrent.ICallable<T> Callable<T>(global::System.Action task, T result) 
        {
            return default(global::Java.Util.Concurrent.ICallable<T>);
        }

        /// <java-name>
        /// callable
        /// </java-name>
        [Dot42.DexImport("callable", "(Ljava/lang/Runnable;)Ljava/util/concurrent/Callable;", AccessFlags = 9, Signature = "(Ljava/lang/Runnable;)Ljava/util/concurrent/Callable<Ljava/lang/Object;>;", IgnoreFromJava = true)]
        public static global::Java.Util.Concurrent.ICallable<object> Callable(global::System.Action runnable) 
        {
            return default(global::Java.Util.Concurrent.ICallable<object>);
        }
	}
}

