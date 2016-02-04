// Copyright (C) 2014 dot42
//
// Original filename: RadioGroup.cs
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
    partial class RadioGroup
    {
#region System resource ID's
#pragma warning disable 649
        [Dot42.ResourceId("__dot42_radiogroup_checkedchanged_listener")]
        private static readonly int checkedChangedListenerKey;
#pragma warning restore 649
#endregion // System resource ID's

        /// <summary>
        /// Fired when the checked radio button has changed.
        /// </summary>
        [ListenerInterface(typeof(IOnCheckedChangeListener))]
        public event EventHandler<CheckedChangeEventArgs> CheckedChange
        {
            add
            {
                var listener = this.GetOrCreate<RadioGroupListener>(checkedChangedListenerKey, true, SetOnCheckedChangeListener);
                listener.CheckedChanged.Add(value);
            }
            remove
            {
                var listener = this.GetOrCreate<RadioGroupListener>(checkedChangedListenerKey, false, null);
                if (listener != null) listener.CheckedChanged.Remove(value);
            }
        }

        public class CheckedChangeEventArgs : EventArgs
        {
            public CheckedChangeEventArgs(int checkedId)
            {
                CheckedId = checkedId;
            }

            public int CheckedId { get; private set; }
        }

    }

    /// <summary>
    /// Implementation of the <see cref="RatingBar"/> events.
    /// </summary>
    internal sealed class RadioGroupListener : RadioGroup.IOnCheckedChangeListener
    {
        internal readonly Dot42.EventHandlerListener<RadioGroup.CheckedChangeEventArgs> CheckedChanged = new EventHandlerListener<RadioGroup.CheckedChangeEventArgs>();

        public void OnCheckedChanged(RadioGroup @group, int checkedId)
        {
            CheckedChanged.Invoke(@group, new RadioGroup.CheckedChangeEventArgs(checkedId));
        }
    }
}

