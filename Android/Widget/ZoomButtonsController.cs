// Copyright (C) 2014 dot42
//
// Original filename: ZoomButtonsController.cs
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
    partial class ZoomButtonsController
    {
#region System resource ID's
#pragma warning disable 649

#if ANDROID_4P
        [Dot42.ResourceId("__dot42_zoombuttonscontroller_zoom_listener")]
        private static readonly int zoomListenerKey;
#endif

#pragma warning restore 649
#endregion // System resource ID's

#if ANDROID_4P
        /// <summary>
        /// Fired when the zoom controls' visibility changes.
        /// </summary>
        [ListenerInterface(typeof(IOnZoomListener))]
        public event EventHandler<VisibilityChangedEventArgs> VisibilityChanged
        {
            add
            {
                var listener = GetZoomControls().GetOrCreate<ZoomButtonsControllerListener>(zoomListenerKey, true, SetOnZoomListener);
                listener.VisibilityChanged.Add(value);
            }
            remove
            {
                var listener = GetZoomControls().GetOrCreate<ZoomButtonsControllerListener>(zoomListenerKey, false, null);
                if (listener != null) listener.VisibilityChanged.Remove(value);
            }
        }

        /// <summary>
        /// Fired when the owner view needs to be zoomed.
        /// </summary>
        [ListenerInterface(typeof(IOnZoomListener))]
        public event EventHandler<ZoomEventArgs> Zoom
        {
            add
            {
                var listener = GetZoomControls().GetOrCreate<ZoomButtonsControllerListener>(zoomListenerKey, true, SetOnZoomListener);
                listener.Zoom.Add(value);
            }
            remove
            {
                var listener = GetZoomControls().GetOrCreate<ZoomButtonsControllerListener>(zoomListenerKey, false, null);
                if (listener != null) listener.Zoom.Remove(value);
            }
        }
#endif
    }

#if ANDROID_4P
    /// <summary>
    /// Implementation of the <see cref="ZoomButtonsController"/> events.
    /// </summary>
    internal sealed class ZoomButtonsControllerListener : ZoomButtonsController.IOnZoomListener
    {
        internal readonly Dot42.EventHandlerListener<VisibilityChangedEventArgs> VisibilityChanged = new EventHandlerListener<VisibilityChangedEventArgs>();
        internal readonly Dot42.EventHandlerListener<ZoomEventArgs> Zoom = new EventHandlerListener<ZoomEventArgs>();

        public void OnVisibilityChanged(bool visible)
        {
            VisibilityChanged.Invoke(null, new VisibilityChangedEventArgs(visible));
        }

        public void OnZoom(bool zoomIn)
        {
            Zoom.Invoke(null, new ZoomEventArgs(zoomIn));
        }
    }
#endif
}

