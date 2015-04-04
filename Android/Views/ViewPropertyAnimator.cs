// Copyright (C) 2014 dot42
//
// Original filename: ViewPropertyAnimator.cs
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
namespace Android.Views
{
	partial class ViewPropertyAnimator
	{
#if ANDROID_16P
        /// <summary>
        /// <para>Specifies an action to take place when the next animation runs. If there is a startDelay set on this ViewPropertyAnimator, then the action will run after that startDelay expires, when the actual animation begins. This method, along with withEndAction(Runnable), is intended to help facilitate choreographing ViewPropertyAnimator animations with other animations or actions in the application.</para><para></para>        
        /// </summary>
        /// <returns>
        /// <para>This object, allowing calls to methods in this class to be chained. </para>
        /// </returns>
        /// <java-name>
        /// withStartAction
        /// </java-name>
        [Dot42.DexImport("withStartAction", "(Ljava/lang/Runnable;)Landroid/view/ViewPropertyAnimator;", AccessFlags = 1, IgnoreFromJava = true)]
        public global::Android.View.ViewPropertyAnimator WithStartAction(global::System.Action runnable) 
        {
            return default(global::Android.View.ViewPropertyAnimator);
        }

        /// <summary>
        /// <para>Specifies an action to take place when the next animation ends. The action is only run if the animation ends normally; if the ViewPropertyAnimator is canceled during that animation, the runnable will not run. This method, along with withStartAction(Runnable), is intended to help facilitate choreographing ViewPropertyAnimator animations with other animations or actions in the application.</para><para>For example, the following code animates a view to x=200 and then back to 0:</para><para><pre>
        ///            Runnable endAction = new Runnable() {
        ///                public void run() {
        ///                    view.animate().x(0);
        ///                }
        ///            };
        ///            view.animate().x(200).withEndAction(endAction);
        ///        </pre></para><para></para>        
        /// </summary>
        /// <returns>
        /// <para>This object, allowing calls to methods in this class to be chained. </para>
        /// </returns>
        /// <java-name>
        /// withEndAction
        /// </java-name>
        [Dot42.DexImport("withEndAction", "(Ljava/lang/Runnable;)Landroid/view/ViewPropertyAnimator;", AccessFlags = 1, IgnoreFromJava = true)]
        public global::Android.View.ViewPropertyAnimator WithEndAction(global::System.Action runnable) 
        {
            return default(global::Android.View.ViewPropertyAnimator);
        }
#endif
	}
}

