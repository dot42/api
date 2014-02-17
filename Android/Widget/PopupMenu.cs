// Copyright (C) 2014 dot42
//
// Original filename: PopupMenu.cs
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
    partial class PopupMenu
    {
#region System resource ID's
#pragma warning disable 649

#if ANDROID_14P
        [Dot42.ResourceId("__dot42_popupmenu_dismiss_listener")]
        private static readonly int dismissListenerKey;
#endif

#if ANDROID_11P
        [Dot42.ResourceId("__dot42_popupmenu_menuitemclick_listener")]
        private static readonly int menuItemClickListenerKey;
#endif

#pragma warning restore 649
#endregion // System resource ID's

#if ANDROID_14P
        /// <summary>
        /// Fired when the associated menu has been dismissed.
        /// </summary>
        [ListenerInterface(typeof(IOnDismissListener))]
        public event EventHandler DismissEvent
        {
            add
            {
                var listener = EventHandlers.GetOrCreate<PopupMenuOnDismissListener>(this, dismissListenerKey, true, SetOnDismissListener);
                listener.Dismiss.Add(value);
            }
            remove
            {
                var listener = EventHandlers.GetOrCreate<PopupMenuOnDismissListener>(this, dismissListenerKey, false, null);
                if (listener != null) listener.Dismiss.Remove(value);
            }
        }
#endif


#if ANDROID_11P
        /// <summary>
        /// Fired when a menu item is clicked if the item itself did not already handle the event.
        /// </summary>
        [ListenerInterface(typeof(IOnMenuItemClickListener))]
        public event EventHandler<MenuItemClickEventArgs> MenuItemClick
        {
            add
            {
                var listener = EventHandlers.GetOrCreate<PopupMenuOnMenuItemClickListener>(this, menuItemClickListenerKey, true, SetOnMenuItemClickListener);
                listener.MenuItemClick.Add(value);
            }
            remove
            {
                var listener = EventHandlers.GetOrCreate<PopupMenuOnMenuItemClickListener>(this, menuItemClickListenerKey, false, null);
                if (listener != null) listener.MenuItemClick.Remove(value);
            }
        }
#endif
    }

#if ANDROID_14P
    /// <summary>
    /// Implementation of the <see cref="DismissEvent"/> event.
    /// </summary>
    internal sealed class PopupMenuOnDismissListener : PopupMenu.IOnDismissListener
    {
        internal readonly Dot42.EventHandlerListener Dismiss = new EventHandlerListener();

        public void OnDismiss(PopupMenu menu)
        {
            Dismiss.Invoke(menu, EventArgs.Empty);
        }
    }
#endif

#if ANDROID_11P
    /// <summary>
    /// Implementation of the <see cref="MenuItemClick"/> event.
    /// </summary>
    internal sealed class PopupMenuOnMenuItemClickListener : PopupMenu.IOnMenuItemClickListener
    {
        internal readonly Dot42.EventHandlerListener<MenuItemClickEventArgs> MenuItemClick = new EventHandlerListener<MenuItemClickEventArgs>();

        public bool OnMenuItemClick(IMenuItem item)
        {
            var args = new MenuItemClickEventArgs(item);
            MenuItemClick.Invoke(null, args);
            return args.IsHandled;
        }
    }
#endif
}

