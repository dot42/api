// Copyright (C) 2014 dot42
//
// Original filename: CompoundButton.cs
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
    partial class CompoundButton
    {
#region System resource ID's
#pragma warning disable 649
        [Dot42.ResourceId("__dot42_compoundbutton_checkedchanged_listener")]
        private static readonly int checkedChangedListenerKey;
#pragma warning restore 649
#endregion // System resource ID's

        /// <summary>
        /// Fired when this button's checked state has changed.
        /// </summary>
        [ListenerInterface(typeof(IOnCheckedChangeListener))]
        public event System.EventHandler<CheckedChangedEventArgs> CheckedChanged
        {
            add { GetOnCheckedChangedListener(true).Add(value); }
            remove
            {
                var listener = GetOnCheckedChangedListener(false);
                if (listener != null) listener.Remove(value);
            }
        }

        /// <summary>
        /// Gets the on checked changed listener. Create if needed.
        /// </summary>
        private CompoundButtonCheckedChangedListener GetOnCheckedChangedListener(bool create)
        {
            var listener = (CompoundButtonCheckedChangedListener)GetTag(checkedChangedListenerKey);
            if ((listener == null) && create)
            {
                listener = new CompoundButtonCheckedChangedListener();
                SetTag(checkedChangedListenerKey, listener);
                SetOnCheckedChangeListener(listener);
            }
            return listener;
        }
    }

    /// <summary>
    /// Implementation of the SeekBar events.
    /// </summary>
    internal sealed class CompoundButtonCheckedChangedListener : Dot42.EventHandlerListener<CheckedChangedEventArgs>, CompoundButton.IOnCheckedChangeListener
    {
        public void OnCheckedChanged(CompoundButton sender, bool isChecked)
        {
            Invoke(sender, new CheckedChangedEventArgs(isChecked));
        }
    }
}

