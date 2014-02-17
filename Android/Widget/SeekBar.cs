// Copyright (C) 2014 dot42
//
// Original filename: SeekBar.cs
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
using Dot42;

namespace Android.Widget
{
    partial class SeekBar
    {
#region System resource ID's
#pragma warning disable 649
        [Dot42.ResourceId("__dot42_seekbar_change_listener")]
        private static readonly int changeListenerKey;
#pragma warning restore 649
#endregion // System resource ID's

        /// <summary>
        /// Fired when this progress of this seekbar is clicked on.
        /// </summary>
        [ListenerInterface(typeof(IOnSeekBarChangeListener))]
        public event System.EventHandler<ProgressChangedEventArgs> ProgressChanged
        {
            add { GetOnChangeListener(true).ProgressChanged.Add(value); }
            remove
            {
                var listener = GetOnChangeListener(false);
                if (listener != null) listener.ProgressChanged.Remove(value);
            }
        }

        /// <summary>
        /// Fired when the user has started a touch gesture.
        /// </summary>
        [ListenerInterface(typeof(IOnSeekBarChangeListener))]
        public event System.EventHandler StartTrackingTouch
        {
            add { GetOnChangeListener(true).StartTrackingTouch.Add(value); }
            remove
            {
                var listener = GetOnChangeListener(false);
                if (listener != null) listener.StartTrackingTouch.Remove(value);
            }
        }

        /// <summary>
        /// Fired when the user has finished a touch gesture.
        /// </summary>
        [ListenerInterface(typeof(IOnSeekBarChangeListener))]
        public event System.EventHandler StopTrackingTouch
        {
            add { GetOnChangeListener(true).StopTrackingTouch.Add(value); }
            remove
            {
                var listener = GetOnChangeListener(false);
                if (listener != null) listener.StopTrackingTouch.Remove(value);
            }
        }

        /// <summary>
        /// Gets the on change listener. Create if needed.
        /// </summary>
        private SeekBarOnChangeListener GetOnChangeListener(bool create)
        {
            var listener = (SeekBarOnChangeListener)GetTag(changeListenerKey);
            if ((listener == null) && create)
            {
                listener = new SeekBarOnChangeListener();
                SetTag(changeListenerKey, listener);
                SetOnSeekBarChangeListener(listener);
            }
            return listener;
        }
    }

    /// <summary>
    /// Implementation of the SeekBar events.
    /// </summary>
    internal sealed class SeekBarOnChangeListener : SeekBar.IOnSeekBarChangeListener
    {
        internal readonly Dot42.EventHandlerListener<ProgressChangedEventArgs> ProgressChanged;
        internal readonly Dot42.EventHandlerListener StartTrackingTouch;
        internal readonly Dot42.EventHandlerListener StopTrackingTouch;

        public SeekBarOnChangeListener()
        {
            ProgressChanged = new EventHandlerListener<ProgressChangedEventArgs>();
            StartTrackingTouch = new EventHandlerListener();
            StopTrackingTouch = new EventHandlerListener();
        }

        public void OnProgressChanged(SeekBar seekBar, int progress, bool fromUser)
        {
            ProgressChanged.Invoke(seekBar, new ProgressChangedEventArgs(progress, fromUser));
        }

        public void OnStartTrackingTouch(SeekBar seekBar)
        {
            StartTrackingTouch.Invoke(seekBar, System.EventArgs.Empty);
        }

        public void OnStopTrackingTouch(SeekBar seekBar)
        {
            StopTrackingTouch.Invoke(seekBar, System.EventArgs.Empty);
        }
    }
}

