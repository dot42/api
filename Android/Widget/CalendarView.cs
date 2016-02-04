// Copyright (C) 2014 dot42
//
// Original filename: CalendarView.cs
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
    partial class CalendarView
    {
#region System resource ID's
#pragma warning disable 649

#if ANDROID_11P
        [Dot42.ResourceId("__dot42_calendarview_datechange_listener")]
        private static readonly int dateChangeListenerKey;
#endif

#pragma warning restore 649
#endregion // System resource ID's

#if ANDROID_11P
        /// <summary>
        /// Fired upon a change of the current value.
        /// </summary>
        [ListenerInterface(typeof(IOnDateChangeListener))]
        public event EventHandler<DateChangedEventArgs> DateChange
        {
            add
            {
                var listener = this.GetOrCreate<CalendarViewOnDateChangeListener>(dateChangeListenerKey, true, SetOnDateChangeListener);
                listener.DateChange.Add(value);
            }
            remove
            {
                var listener = this.GetOrCreate<CalendarViewOnDateChangeListener>(dateChangeListenerKey, false, null);
                if (listener != null) listener.DateChange.Remove(value);
            }
        }
#endif
    }

#if ANDROID_11P
    /// <summary>
    /// Implementation of the <see cref="DateChange"/> event.
    /// </summary>
    internal sealed class CalendarViewOnDateChangeListener : CalendarView.IOnDateChangeListener
    {
        internal readonly Dot42.EventHandlerListener<DateChangedEventArgs> DateChange = new EventHandlerListener<DateChangedEventArgs>();

        public void OnSelectedDayChange(CalendarView view, int year, int month, int dayOfMonth)
        {
            DateChange.Invoke(view, new DateChangedEventArgs(year, month, dayOfMonth));
        }
    }
#endif
}

