// Copyright (C) 2014 dot42
//
// Original filename: AutoCompleteTextView.cs
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
using Android.Views;
using System;
using Dot42;

namespace Android.Widget
{
    partial class AutoCompleteTextView
    {
#region System resource ID's
#pragma warning disable 649
        
        [Dot42.ResourceId("__dot42_autocompletetextview_itemselected_listener")]
        private static readonly int itemSelectedListenerKey;

        [Dot42.ResourceId("__dot42_autocompletetextview_itemclick_listener")]
        private static readonly int itemClickListenerKey;
#if ANDROID_17P
        [Dot42.ResourceId("__dot42_autocompletetextview_dismiss_listener")]
        private static readonly int dismissListenerKey;
#endif

#pragma warning restore 649
#endregion // System resource ID's

        /// <summary>
        /// Fired when an item in this view has been selected.
        /// </summary>
        [ListenerInterface("android/widget/AdapterView$OnItemSelectedListener")]
        public event EventHandler<AdapterView.ItemSelectedEventArgs> ItemSelected
        {
            add
            {
                var listener = (AdapterViewOnItemSelectedListener<object>)GetTag(itemSelectedListenerKey);
                if (listener == null)
                {
                    listener = new AdapterViewOnItemSelectedListener<object>();
                    SetTag(itemSelectedListenerKey, listener);
                    OnItemSelectedListener = listener;
                }
                listener.ItemSelected.Add(value);
            }
            remove
            {
                var listener = (AdapterViewOnItemSelectedListener<object>)GetTag(itemSelectedListenerKey);
                if (listener != null) listener.ItemSelected.Remove(value);
            }
        }

        /// <summary>
        /// Fired when this view item is clicked on.
        /// </summary>
        [ListenerInterface("android/widget/AdapterView$OnItemClickListener")]
        public event EventHandler<AdapterView.ItemClickEventArgs> ItemClick
        {
            add
            {
                var listener = (AdapterViewOnItemClickListener<object>)GetTag(itemClickListenerKey);
                if (listener == null)
                {
                    listener = new AdapterViewOnItemClickListener<object>();
                    SetTag(itemClickListenerKey, listener);
                    OnItemClickListener = listener;
                }
                listener.Add(value);
            }
            remove
            {
                var listener = (AdapterViewOnItemClickListener<object>)GetTag(itemClickListenerKey);
                if (listener != null) listener.Remove(value);
            }
        }
#if ANDROID_17P
        /// <summary>
        /// Fired whenever the AutoCompleteTextView's list of completion options has been dismissed and is no longer available for user interaction.
        /// </summary>
        [ListenerInterface(typeof(IOnDismissListener))]
        public event EventHandler Dismiss
        {
            add
            {
                var listener = this.GetOrCreate<AutoCompleteTextViewOnDismissListener>(dismissListenerKey, true, SetOnDismissListener);
                listener.Dismiss.Add(value);
            }
            remove
            {
                var listener = this.GetOrCreate<AutoCompleteTextViewOnDismissListener>(dismissListenerKey, false, null);
                if (listener != null) listener.Dismiss.Remove(value);
            }
        }
#endif
    }

#if ANDROID_17P
    /// <summary>
    /// Implementation of the <see cref="Dismiss"/> event.
    /// </summary>
    internal sealed class AutoCompleteTextViewOnDismissListener : AutoCompleteTextView.IOnDismissListener
    {
        internal readonly Dot42.EventHandlerListener Dismiss = new EventHandlerListener();

        public void OnDismiss()
        {
            Dismiss.Invoke(null, System.EventArgs.Empty);
        }
    }
#endif
}

