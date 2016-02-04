// Copyright (C) 2014 dot42
//
// Original filename: AsyncTask.cs
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
namespace Android.OS
{
    partial class AsyncTask<Params, Progress, Result>
	{
#if ANDROID_11P
        /// <java-name>
        /// execute
        /// </java-name>
        [Dot42.DexImport("execute", "(Ljava/lang/Runnable;)V", AccessFlags = 9, IgnoreFromJava = true)]
        public static void Execute(global::System.Action runnable) 
        {
        }
#endif
	}
}

