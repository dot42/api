// Copyright (C) 2014 dot42
//
// Original filename: SlidingDrawer.cs
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
using Android.View;
using Dot42;

namespace Android.Widget
{
    partial class SlidingDrawer
    {
#region System resource ID's
#pragma warning disable 649

#if ANDROID_3P
        [Dot42.ResourceId("__dot42_slidingdrawer_drawerclose_listener")]
        private static readonly int drawerCloseListenerKey;

        [Dot42.ResourceId("__dot42_slidingdrawer_draweropen_listener")]
        private static readonly int drawerOpenListenerKey;

        [Dot42.ResourceId("__dot42_slidingdrawer_drawerscroll_listener")]
        private static readonly int drawerScrollListenerKey;
#endif

#pragma warning restore 649
#endregion // System resource ID's

#if ANDROID_3P
        /// <summary>
        /// Fired when the drawer becomes fully closed.
        /// </summary>
        [ListenerInterface(typeof(IOnDrawerCloseListener))]
        public event EventHandler DrawerClosed
        {
            add
            {
                var listener = this.GetOrCreate<SlidingDrawerListener>(drawerCloseListenerKey, true, SetOnDrawerCloseListener);
                listener.DrawerClosed.Add(value);
            }
            remove
            {
                var listener = this.GetOrCreate<SlidingDrawerListener>(drawerCloseListenerKey, false, null);
                if (listener != null) listener.DrawerClosed.Remove(value);
            }
        }

        /// <summary>
        /// Fired when the drawer becomes fully open.
        /// </summary>
        [ListenerInterface(typeof(IOnDrawerOpenListener))]
        public event EventHandler DrawerOpened
        {
            add
            {
                var listener = this.GetOrCreate<SlidingDrawerListener>(drawerOpenListenerKey, true, SetOnDrawerOpenListener);
                listener.DrawerOpened.Add(value);
            }
            remove
            {
                var listener = this.GetOrCreate<SlidingDrawerListener>(drawerOpenListenerKey, false, null);
                if (listener != null) listener.DrawerOpened.Remove(value);
            }
        }

        /// <summary>
        /// Fired when the user stops dragging/flinging the drawer's handle.
        /// </summary>
        [ListenerInterface(typeof(IOnDrawerScrollListener))]
        public event EventHandler ScrollEnded
        {
            add
            {
                var listener = this.GetOrCreate<SlidingDrawerListener>(drawerScrollListenerKey, true, SetOnDrawerScrollListener);
                listener.ScrollEnded.Add(value);
            }
            remove
            {
                var listener = this.GetOrCreate<SlidingDrawerListener>(drawerScrollListenerKey, false, null);
                if (listener != null) listener.ScrollEnded.Remove(value);
            }
        }

        /// <summary>
        /// Fired when the user starts dragging/flinging the drawer's handle.
        /// </summary>
        [ListenerInterface(typeof(IOnDrawerScrollListener))]
        public event EventHandler ScrollStarted
        {
            add
            {
                var listener = this.GetOrCreate<SlidingDrawerListener>(drawerScrollListenerKey, true, SetOnDrawerScrollListener);
                listener.ScrollStarted.Add(value);
            }
            remove
            {
                var listener = this.GetOrCreate<SlidingDrawerListener>(drawerScrollListenerKey, false, null);
                if (listener != null) listener.ScrollStarted.Remove(value);
            }
        }
#endif
    }

#if ANDROID_3P
    /// <summary>
    /// Implementation of the <see cref="SlidingDrawer"/> events.
    /// </summary>
    internal sealed class SlidingDrawerListener : SlidingDrawer.IOnDrawerCloseListener, SlidingDrawer.IOnDrawerOpenListener, SlidingDrawer.IOnDrawerScrollListener
    {
        internal readonly Dot42.EventHandlerListener DrawerClosed = new EventHandlerListener();
        internal readonly Dot42.EventHandlerListener DrawerOpened = new EventHandlerListener();
        internal readonly Dot42.EventHandlerListener ScrollEnded = new EventHandlerListener();
        internal readonly Dot42.EventHandlerListener ScrollStarted = new EventHandlerListener();

        public void OnDrawerClosed()
        {
            DrawerClosed.Invoke(null, System.EventArgs.Empty);
        }

        public void OnDrawerOpened()
        {
            DrawerOpened.Invoke(null, System.EventArgs.Empty);
        }

        public void OnScrollStarted()
        {
            ScrollStarted.Invoke(null, System.EventArgs.Empty);
        }

        public void OnScrollEnded()
        {
            ScrollEnded.Invoke(null, System.EventArgs.Empty);
        }
    }
#endif
}

