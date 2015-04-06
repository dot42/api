// Copyright (C) 2014 dot42
//
// Original filename: DatePicker.cs
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
    partial class DatePicker
    {
#region System resource ID's
#pragma warning disable 649
        [Dot42.ResourceId("__dot42_datepicker_datechanged_listener")]
        private static readonly int dateChangedListenerKey;
#pragma warning restore 649
#endregion // System resource ID's

        /// <summary>
        /// Fired upon a change of the current value.
        /// </summary>
        /// <remarks>
        /// Do not call the <see cref="Init"/> method after setting this event.
        /// </remarks>
        [ListenerInterface(typeof(IOnDateChangedListener))]
        public event EventHandler<DateChangedEventArgs> DateChanged
        {
            add
            {
                var listener = (DatePickerOnDateChangedListener)GetTag(dateChangedListenerKey);
                if (listener == null)
                {
                    listener = new DatePickerOnDateChangedListener();
                    SetTag(dateChangedListenerKey, listener);
                    Init(Year, Month, DayOfMonth, listener);
                }
                listener.DateChanged.Add(value);
            }
            remove
            {
                var listener = (DatePickerOnDateChangedListener)GetTag(dateChangedListenerKey);
                if (listener != null) listener.DateChanged.Remove(value);
            }
        }
    }

    /// <summary>
    /// Implementation of the <see cref="DateChanged"/> event.
    /// </summary>
    internal sealed class DatePickerOnDateChangedListener : DatePicker.IOnDateChangedListener
    {
        internal readonly Dot42.EventHandlerListener<DateChangedEventArgs> DateChanged = new EventHandlerListener<DateChangedEventArgs>();

        public void OnDateChanged(DatePicker view, int year, int monthOfYear, int dayOfMonth)
        {
            DateChanged.Invoke(view, new DateChangedEventArgs(year, monthOfYear, dayOfMonth));
        }
    }
}

