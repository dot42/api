// Copyright (C) 2014 dot42
//
// Original filename: TimePicker.cs
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
using Dot42;

namespace Android.Widget
{
    partial class TimePicker
    {
#region System resource ID's
#pragma warning disable 649
        [Dot42.ResourceId("__dot42_timepicker_timechanged_listener")]
        private static readonly int timeChangedListenerKey;
#pragma warning restore 649
#endregion // System resource ID's

        /// <summary>
        /// Fired upon a change of the current value.
        /// </summary>
        [ListenerInterface(typeof(IOnTimeChangedListener))]
        public event EventHandler<TimeChangedEventArgs> TimeChanged
        {
            add
            {
                var listener = (TimePickerOnTimeChangedListener)GetTag(timeChangedListenerKey);
                if (listener == null)
                {
                    listener = new TimePickerOnTimeChangedListener();
                    SetTag(timeChangedListenerKey, listener);
                    SetOnTimeChangedListener(listener);
                }
                listener.TimeChanged.Add(value);
            }
            remove
            {
                var listener = (TimePickerOnTimeChangedListener)GetTag(timeChangedListenerKey);
                if (listener != null) listener.TimeChanged.Remove(value);
            }
        }
    }

    /// <summary>
    /// Implementation of the <see cref="TimeChanged"/> event.
    /// </summary>
    internal sealed class TimePickerOnTimeChangedListener : TimePicker.IOnTimeChangedListener
    {
        internal readonly Dot42.EventHandlerListener<TimeChangedEventArgs> TimeChanged = new EventHandlerListener<TimeChangedEventArgs>();

        public void OnTimeChanged(TimePicker view, int hourOfDay, int minute)
        {
            TimeChanged.Invoke(view, new TimeChangedEventArgs(hourOfDay, minute));
        }
    }
}

