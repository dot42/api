// Copyright (C) 2014 dot42
//
// Original filename: AbsListView.cs
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
    partial class AbsListView
    {
#region System resource ID's
#pragma warning disable 649
        
        [Dot42.ResourceId("__dot42_abslistview_scroll_listener")]
        private static readonly int scrollListenerKey;

        [Dot42.ResourceId("__dot42_abslistview_recycler_listener")]
        private static readonly int recyclerListenerKey;

#pragma warning restore 649
#endregion // System resource ID's

        /// <summary>
        /// Fired when the list or grid has been scrolled. This will be called after the scroll has completed.
        /// </summary>
        [ListenerInterface(typeof(IOnScrollListener))]
        public event EventHandler<ScrollEventArgs> Scroll
        {
            add
            {
                var listener = this.GetOrCreate<AbsListViewOnScrollListener>(scrollListenerKey, true, SetOnScrollListener);
                listener.Scroll.Add(value);
            }
            remove
            {
                var listener = this.GetOrCreate<AbsListViewOnScrollListener>(scrollListenerKey, false, null);
                if (listener != null) listener.Scroll.Remove(value);
            }
        }

        /// <summary>
        /// Fired while the list view or grid view is being scrolled. If the view is being scrolled, this method will be called 
        /// before the next frame of the scroll is rendered. In particular, it will be called before any calls to GetView(int, View, ViewGroup).
        /// </summary>
        [ListenerInterface(typeof(IOnScrollListener))]
        public event EventHandler<ScrollStateChangedEventArgs> ScrollStateChanged
        {
            add
            {
                var listener = this.GetOrCreate<AbsListViewOnScrollListener>(scrollListenerKey, true, SetOnScrollListener);
                listener.ScrollStateChanged.Add(value);
            }
            remove
            {
                var listener = this.GetOrCreate<AbsListViewOnScrollListener>(scrollListenerKey, false, null);
                if (listener != null) listener.ScrollStateChanged.Remove(value);
            }
        }

        /// <summary>
        /// Indicates that the specified View was moved into the recycler's scrap heap.
        /// </summary>
        [ListenerInterface(typeof(IRecyclerListener))]
        public event EventHandler<MovedToScrapHeapEventArgs> MovedToScrapHeap
        {
            add
            {
                var listener = this.GetOrCreate<AbsListViewRecyclerListener>(recyclerListenerKey, true, SetRecyclerListener);
                listener.MovedToScrapHeap.Add(value);
            }
            remove
            {
                var listener = this.GetOrCreate<AbsListViewRecyclerListener>(recyclerListenerKey, false, null);
                if (listener != null) listener.MovedToScrapHeap.Remove(value);
            }
        }
    }

    /// <summary>
    /// Implementation of the <see cref="Scroll"/> and <see cref="ScrollStateChanged"/> event.
    /// </summary>
    internal sealed class AbsListViewOnScrollListener : AbsListView.IOnScrollListener
    {
        internal readonly Dot42.EventHandlerListener<ScrollEventArgs> Scroll = new EventHandlerListener<ScrollEventArgs>();
        internal readonly Dot42.EventHandlerListener<ScrollStateChangedEventArgs> ScrollStateChanged = new EventHandlerListener<ScrollStateChangedEventArgs>();

        public void OnScrollStateChanged(AbsListView view, int scrollState)
        {
            ScrollStateChanged.Invoke(view, new ScrollStateChangedEventArgs((ScrollState)scrollState));
        }

        public void OnScroll(AbsListView view, int firstVisibleItem, int visibleItemCount, int totalItemCount)
        {
            Scroll.Invoke(view, new ScrollEventArgs(firstVisibleItem, visibleItemCount, totalItemCount));
        }
    }

    /// <summary>
    /// Implementation of the <see cref="MovedToScrapheap"/> event.
    /// </summary>
    internal sealed class AbsListViewRecyclerListener : AbsListView.IRecyclerListener
    {
        internal readonly Dot42.EventHandlerListener<MovedToScrapHeapEventArgs> MovedToScrapHeap = new EventHandlerListener<MovedToScrapHeapEventArgs>();

        public void OnMovedToScrapHeap(Views.View view)
        {
            MovedToScrapHeap.Invoke(null, new MovedToScrapHeapEventArgs(view));
        }
    }
}

