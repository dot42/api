// Copyright (C) 2014 dot42
//
// Original filename: PopupWindow.cs
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
    partial class PopupWindow
    {
#region System resource ID's
#pragma warning disable 649
        [Dot42.ResourceId("__dot42_popupwindow_dismiss_listener")]
        private static readonly int dismissListenerKey;
#pragma warning restore 649
#endregion // System resource ID's

        /// <summary>
        /// Fired when this popup window is dismissed.
        /// </summary>
        [ListenerInterface(typeof(IOnDismissListener))]
        public event EventHandler DismissEvent
        {
            add
            {
                var listener = EventHandlers.GetOrCreate<PopupWindowListener>(this, dismissListenerKey, true, SetOnDismissListener);
                listener.Dismiss.Add(value);
            }
            remove
            {
                var listener = EventHandlers.GetOrCreate<PopupWindowListener>(this, dismissListenerKey, false, null);
                if (listener != null) listener.Dismiss.Remove(value);
            }
        }
    }

    /// <summary>
    /// Implementation of the <see cref="PopupWindow"/> events.
    /// </summary>
    internal sealed class PopupWindowListener : PopupWindow.IOnDismissListener
    {
        internal readonly Dot42.EventHandlerListener Dismiss = new EventHandlerListener();

        public void OnDismiss()
        {
            Dismiss.Invoke(null, EventArgs.Empty);
        }
    }
}

