// Copyright (C) 2014 dot42
//
// Original filename: Activity.cs
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
namespace Android.App
{
    partial class Activity
    {
        /// <summary>
        /// Look for a child view with the given id. If this view has the given id, return this view.
        /// </summary>
        public T FindViewById<T>(int id)
            where T : Android.Views.View
        {
            return (T) FindViewById(id);
        }

        /// <summary>
        /// <para>Runs the specified action on the UI thread. If the current thread is the UI thread, then the action is executed immediately. If the current thread is not the UI thread, the action is posted to the event queue of the UI thread.</para><para></para>        
        /// </summary>
        /// <java-name>
        /// runOnUiThread
        /// </java-name>
        [Dot42.DexImport("runOnUiThread", "(Ljava/lang/Runnable;)V", AccessFlags = 17, IgnoreFromJava = true)]
        public void RunOnUiThread(System.Action action)
        {
        }
    }
}

