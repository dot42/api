// Copyright (C) 2014 dot42
//
// Original filename: Message.cs
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
namespace Android.Os
{
	partial class Message
	{
        /// <summary>
        /// <para>Same as obtain(), but sets the values for both <b>target</b> and <b>what</b> members on the Message. </para>        
        /// </summary>
        /// <returns>
        /// <para>A Message object from the global pool. </para>
        /// </returns>
        /// <java-name>
        /// obtain
        /// </java-name>
        [Dot42.DexImport("obtain", "(Landroid/os/Handler;Ljava/lang/Runnable;)Landroid/os/Message;", AccessFlags = 9, IgnoreFromJava = true)]
        public static global::Android.Os.Message Obtain(global::Android.Os.Handler h, global::System.Action what) 
        {
            return default(global::Android.Os.Message);
        }
	}
}

