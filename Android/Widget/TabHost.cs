// Copyright (C) 2014 dot42
//
// Original filename: TabHost.cs
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
    partial class TabHost
    {
#region System resource ID's
#pragma warning disable 649
        [Dot42.ResourceId("__dot42_tabhost_tabchanged_listener")]
        private static readonly int tabChangedListenerKey;
#pragma warning restore 649
#endregion // System resource ID's

        /// <summary>
        /// Fired upon a change of the current tab.
        /// </summary>
        [ListenerInterface(typeof(IOnTabChangeListener))]
        public event EventHandler<TabChangedEventArgs> TabChanged
        {
            add
            {
                var listener = (TabHostOnTabChangedListener)GetTag(tabChangedListenerKey);
                if (listener == null)
                {
                    listener = new TabHostOnTabChangedListener();
                    SetTag(tabChangedListenerKey, listener);
                    SetOnTabChangedListener(listener);
                }
                listener.TabChanged.Add(value);
            }
            remove
            {
                var listener = (TabHostOnTabChangedListener)GetTag(tabChangedListenerKey);
                if (listener != null) listener.TabChanged.Remove(value);
            }
        }
    }

    /// <summary>
    /// Implementation of the <see cref="TabChanged"/> event.
    /// </summary>
    internal sealed class TabHostOnTabChangedListener : TabHost.IOnTabChangeListener
    {
        internal readonly Dot42.EventHandlerListener<TabChangedEventArgs> TabChanged = new EventHandlerListener<TabChangedEventArgs>();

        public void OnTabChanged(string tabId)
        {
            TabChanged.Invoke(null, new TabChangedEventArgs(tabId));
        }
    }
}

