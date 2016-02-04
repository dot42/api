// Copyright (C) 2014 dot42
//
// Original filename: LayerDrawable.cs
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
	partial class LayerDrawable
	{
        /// <summary>
        /// <para>A Drawable can call this to schedule the next frame of its animation. An implementation can generally simply call android.os.Handler#postAtTime(Runnable, Object, long) with the parameters <b>(what, who, when)</b> to perform the scheduling.</para><para></para>        
        /// </summary>
        /// <java-name>
        /// scheduleDrawable
        /// </java-name>
        [Dot42.DexImport("scheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;J)V", AccessFlags = 1, IgnoreFromJava = true)]
        public void ScheduleDrawable(global::Android.Graphics.Drawables.Drawable who, global::System.Action what, long when) 
        {
        }

        /// <summary>
        /// <para>A Drawable can call this to unschedule an action previously scheduled with scheduleDrawable. An implementation can generally simply call android.os.Handler#removeCallbacks(Runnable, Object) with the parameters <b>(what, who)</b> to unschedule the drawable.</para><para></para>        
        /// </summary>
        /// <java-name>
        /// unscheduleDrawable
        /// </java-name>
        [Dot42.DexImport("unscheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;)V", AccessFlags = 1, IgnoreFromJava = true)]
        public void UnscheduleDrawable(global::Android.Graphics.Drawables.Drawable who, global::System.Action what) 
        {
        }
	}
}

