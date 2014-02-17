// Copyright (C) 2014 dot42
//
// Original filename: NumberPicker.cs
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
    partial class NumberPicker
    {
#region System resource ID's
#pragma warning disable 649

        #if ANDROID_11P
        [Dot42.ResourceId("__dot42_numberpicker_scroll_listener")]
        private static readonly int scrollListenerKey;

        [Dot42.ResourceId("__dot42_numberpicker_valuechange_listener")]
        private static readonly int valueChangeListenerKey;
#endif

#pragma warning restore 649
#endregion // System resource ID's

#if ANDROID_11P
        /// <summary>
        /// Fired while the number picker scroll state has changed.
        /// </summary>
        [ListenerInterface(typeof(IOnScrollListener))]
        public event EventHandler<ScrollStateChangedEventArgs> ScrollStateChanged
        {
            add
            {
                var listener = (NumberPickerOnScrollListener)GetTag(scrollListenerKey);
                if (listener == null)
                {
                    listener = new NumberPickerOnScrollListener();
                    SetTag(scrollListenerKey, listener);
                    SetOnScrollListener(listener);
                }
                listener.ScrollStateChanged.Add(value);
            }
            remove
            {
                var listener = (NumberPickerOnScrollListener)GetTag(scrollListenerKey);
                if (listener != null) listener.ScrollStateChanged.Remove(value);
            }
        }

        /// <summary>
        /// Fired upon a change of the current value.
        /// </summary>
        [ListenerInterface(typeof(IOnValueChangeListener))]
        public event EventHandler<ValueChangeEventArgs> ValueChange
        {
            add
            {
                var listener = (NumberPickerOnValueChangeListener)GetTag(valueChangeListenerKey);
                if (listener == null)
                {
                    listener = new NumberPickerOnValueChangeListener();
                    SetTag(valueChangeListenerKey, listener);
                    SetOnValueChangedListener(listener);
                }
                listener.ValueChange.Add(value);
            }
            remove
            {
                var listener = (NumberPickerOnValueChangeListener)GetTag(valueChangeListenerKey);
                if (listener != null) listener.ValueChange.Remove(value);
            }
        }
#endif
    }

#if ANDROID_11P
    /// <summary>
    /// Implementation of the <see cref="ScrollStateChanged"/> event.
    /// </summary>
    internal sealed class NumberPickerOnScrollListener : NumberPicker.IOnScrollListener
    {
        internal readonly Dot42.EventHandlerListener<ScrollStateChangedEventArgs> ScrollStateChanged = new EventHandlerListener<ScrollStateChangedEventArgs>();

        public void OnScrollStateChange(NumberPicker view, int scrollState)
        {
            ScrollStateChanged.Invoke(view, new ScrollStateChangedEventArgs((ScrollState)scrollState));
        }
    }

    /// <summary>
    /// Implementation of the <see cref="ValueChange"/> event.
    /// </summary>
    internal sealed class NumberPickerOnValueChangeListener : NumberPicker.IOnValueChangeListener
    {
        internal readonly Dot42.EventHandlerListener<ValueChangeEventArgs> ValueChange = new EventHandlerListener<ValueChangeEventArgs>();

        public void OnValueChange(NumberPicker picker, int oldVal, int newVal)
        {
            ValueChange.Invoke(picker, new ValueChangeEventArgs(oldVal, newVal));
        }
    }
#endif
}

