// Copyright (C) 2014 dot42
//
// Original filename: Drawable.cs
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
namespace Android.Graphics.Drawables
{
	partial class Drawable
	{
        /// <summary>
        /// <para>Use the current Callback implementation to have this Drawable scheduled. Does nothing if there is no Callback attached to the Drawable.</para><para><para>Callback::scheduleDrawable </para></para>        
        /// </summary>
        /// <java-name>
        /// scheduleSelf
        /// </java-name>
        [Dot42.DexImport("scheduleSelf", "(Ljava/lang/Runnable;J)V", AccessFlags = 1, IgnoreFromJava = true)]
        public void ScheduleSelf(global::System.Action what, long when) 
        {
        }

        /// <summary>
        /// <para>Use the current Callback implementation to have this Drawable unscheduled. Does nothing if there is no Callback attached to the Drawable.</para><para><para>Callback::unscheduleDrawable </para></para>        
        /// </summary>
        /// <java-name>
        /// unscheduleSelf
        /// </java-name>
        [Dot42.DexImport("unscheduleSelf", "(Ljava/lang/Runnable;)V", AccessFlags = 1, IgnoreFromJava = true)]
        public void UnscheduleSelf(global::System.Action what) 
        {
        }
	}
}

