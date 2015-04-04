// Copyright (C) 2014 dot42
//
// Original filename: AdapterView.cs
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
    partial class AdapterView<T>
    {
#region System resource ID's
#pragma warning disable 649
        [Dot42.ResourceId("__dot42_adapterview_itemclick_listener")]
        private static readonly int itemClickListenerKey;

        [Dot42.ResourceId("__dot42_adapterview_itemlongclick_listener")]
        private static readonly int itemLongClickListenerKey;

        [Dot42.ResourceId("__dot42_adapterview_itemselected_listener")]
        private static readonly int itemSelectedListenerKey;
#pragma warning restore 649
#endregion // System resource ID's

        /// <summary>
        /// Fired when this view item is clicked on.
        /// </summary>
        [ListenerInterface("android/widget/AdapterView$OnItemClickListener")]
        public event EventHandler<ItemClickEventArgs> ItemClick
        {
            add
            {
                var listener = (AdapterViewOnItemClickListener<T>)GetTag(itemClickListenerKey);
                if (listener == null)
                {
                    listener = new AdapterViewOnItemClickListener<T>();
                    SetTag(itemClickListenerKey, listener);
                    SetOnItemClickListener(listener);
                }
                listener.Add(value);
            }
            remove
            {
                var listener = (AdapterViewOnItemClickListener<T>)GetTag(itemClickListenerKey);
                if (listener != null) listener.Remove(value);
            }
        }

        /// <summary>
        /// Fired when this view item is clicked on long.
        /// </summary>
        [ListenerInterface("android/widget/AdapterView$OnItemLongClickListener")]
        public event EventHandler<ItemClickEventArgs> ItemLongClick
        {
            add
            {
                var listener = (AdapterViewOnItemClickListener<T>)GetTag(itemLongClickListenerKey);
                if (listener == null)
                {
                    listener = new AdapterViewOnItemClickListener<T>();
                    SetTag(itemLongClickListenerKey, listener);
                    SetOnItemLongClickListener(listener);
                }
                listener.Add(value);
            }
            remove
            {
                var listener = (AdapterViewOnItemClickListener<T>)GetTag(itemLongClickListenerKey);
                if (listener != null) listener.Remove(value);
            }
        }

        /// <summary>
        /// Fired when an item in this view has been selected.
        /// </summary>
        [ListenerInterface("android/widget/AdapterView$OnItemSelectedListener")]
        public event EventHandler<ItemSelectedEventArgs> ItemSelected
        {
            add
            {
                var listener = (AdapterViewOnItemSelectedListener<T>)GetTag(itemSelectedListenerKey);
                if (listener == null)
                {
                    listener = new AdapterViewOnItemSelectedListener<T>();
                    SetTag(itemSelectedListenerKey, listener);
                    SetOnItemSelectedListener(listener);
                }
                listener.ItemSelected.Add(value);
            }
            remove
            {
                var listener = (AdapterViewOnItemSelectedListener<T>)GetTag(itemSelectedListenerKey);
                if (listener != null) listener.ItemSelected.Remove(value);
            }
        }

        /// <summary>
        /// Fired when the selection disappears from this view.
        /// </summary>
        [ListenerInterface("android/widget/AdapterView$OnItemSelectedListener")]
        public event EventHandler NothingSelected
        {
            add
            {
                var listener = (AdapterViewOnItemSelectedListener<T>)GetTag(itemSelectedListenerKey);
                if (listener == null)
                {
                    listener = new AdapterViewOnItemSelectedListener<T>();
                    SetTag(itemSelectedListenerKey, listener);
                    SetOnItemSelectedListener(listener);
                }
                listener.NothingSelected.Add(value);
            }
            remove
            {
                var listener = (AdapterViewOnItemSelectedListener<T>)GetTag(itemSelectedListenerKey);
                if (listener != null) listener.NothingSelected.Remove(value);
            }
        }
    }

    /// <summary>
    /// Implementation of the <see cref="ItemClick"/> event.
    /// </summary>
    internal sealed class AdapterViewOnItemClickListener<T> : Dot42.EventHandlerListener<ItemClickEventArgs>,
        AdapterView<T>.IOnItemClickListener, AdapterView<T>.IOnItemLongClickListener
    {
        /// <summary>
        /// Invoke
        /// </summary>
        public void OnItemClick(AdapterView<object> adapterView, View view, int position, long id)
        {
            Invoke(adapterView, new ItemClickEventArgs(view, position, id));
        }

        public bool OnItemLongClick(AdapterView<object> adapterView, View view, int position, long id)
        {
            var args = new ItemClickEventArgs(view, position, id);
            Invoke(adapterView, args);
            return args.IsHandled;
        }
    }

    /// <summary>
    /// Implementation of the <see cref="ItemSelected"/> event.
    /// </summary>
    internal sealed class AdapterViewOnItemSelectedListener<T> : AdapterView<T>.IOnItemSelectedListener
    {
        internal readonly Dot42.EventHandlerListener<ItemSelectedEventArgs> ItemSelected = new EventHandlerListener<ItemSelectedEventArgs>();
        internal readonly Dot42.EventHandlerListener NothingSelected = new EventHandlerListener();

        public void OnItemSelected(AdapterView<object> adapterView, View view, int position, long id)
        {
            ItemSelected.Invoke(adapterView, new ItemSelectedEventArgs(view, position, id));
        }

        public void OnNothingSelected(AdapterView<object> adapterView)
        {
            NothingSelected.Invoke(adapterView, System.EventArgs.Empty);
        }
    }
}

