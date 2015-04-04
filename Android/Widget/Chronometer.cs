// Copyright (C) 2014 dot42
//
// Original filename: Chronometer.cs
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
using System;
using Android.Views;
using Dot42;

namespace Android.Widget
{
    partial class Chronometer
    {
#region System resource ID's
#pragma warning disable 649

#if ANDROID_3P
        [Dot42.ResourceId("__dot42_chronometer_tick_listener")]
        private static readonly int chronometerTickListenerKey;
#endif

#pragma warning restore 649
#endregion // System resource ID's

#if ANDROID_3P
        /// <summary>
        /// Notification that the chronometer has changed.
        /// </summary>
        [ListenerInterface(typeof(IOnChronometerTickListener))]
        public event EventHandler Tick
        {
            add
            {
                var listener = this.GetOrCreate<ChronometerOnChronometerTickListener>(chronometerTickListenerKey, true, SetOnChronometerTickListener);
                listener.Tick.Add(value);
            }
            remove
            {
                var listener = this.GetOrCreate<ChronometerOnChronometerTickListener>(chronometerTickListenerKey, false, null);
                if (listener != null) listener.Tick.Remove(value);
            }
        }
#endif
    }

#if ANDROID_3P
    /// <summary>
    /// Implementation of the <see cref="Tick"/> event.
    /// </summary>
    internal sealed class ChronometerOnChronometerTickListener : Chronometer.IOnChronometerTickListener
    {
        internal readonly Dot42.EventHandlerListener Tick = new EventHandlerListener();

        public void OnChronometerTick(Chronometer chronometer)
        {
            Tick.Invoke(chronometer, System.EventArgs.Empty);
        }
    }
#endif
}

