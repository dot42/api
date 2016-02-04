// Copyright (C) 2014 dot42
//
// Original filename: UiAutomation.cs
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
#if ANDROID_18P
    partial class UiAutomation
    {
        /// <summary>
        /// <para>Executes a command and waits for a specific accessibility event up to a given wait timeout. To detect a sequence of events one can implement a filter that keeps track of seen events of the expected sequence and returns true after the last event of that sequence is received. </para><para><b>Note:</b> It is caller's responsibility to recycle the returned event. </para><para></para>        
        /// </summary>
        /// <java-name>
        /// executeAndWaitForEvent
        /// </java-name>
        [Dot42.DexImport("executeAndWaitForEvent", 
                         "(Ljava/lang/Runnable;Landroid/app/UiAutomation$AccessibilityEventFilter;J)Landroid/view/accessibility/AccessibilityEvent;",
                         AccessFlags = 1,
                         IgnoreFromJava = true)]                         
        public global::Android.Views.Accessibility.AccessibilityEvent ExecuteAndWaitForEvent(global::System.Action command, global::Android.App.UiAutomation.IAccessibilityEventFilter filter, long timeoutMillis) /* MethodBuilder.Create */
        {
            return default(global::Android.Views.Accessibility.AccessibilityEvent);
        }
    }
#endif
}

