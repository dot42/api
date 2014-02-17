// Copyright (C) 2014 dot42
//
// Original filename: InstrumentationTestCase.cs
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
namespace Android.Test
{
	partial class InstrumentationTestCase
	{
#if ANDROID_3P
        /// <summary>
        /// <para>Helper for running portions of a test on the UI thread.</para><para>Note, in most cases it is simpler to annotate the test method with android.test.UiThreadTest, which will run the entire test method on the UI thread. Use this method if you need to switch in and out of the UI thread to perform your test.</para><para></para>        
        /// </summary>
        /// <java-name>
        /// runTestOnUiThread
        /// </java-name>
        [Dot42.DexImport("runTestOnUiThread", "(Ljava/lang/Runnable;)V", AccessFlags = 1, IgnoreFromJava = true)]
        public void RunTestOnUiThread(global::System.Action r) 
        {
        }
#endif
    }
}

