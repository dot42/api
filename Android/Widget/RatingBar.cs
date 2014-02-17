// Copyright (C) 2014 dot42
//
// Original filename: RatingBar.cs
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
    partial class RatingBar
    {
#region System resource ID's
#pragma warning disable 649
        [Dot42.ResourceId("__dot42_ratingbar_ratingchanged_listener")]
        private static readonly int ratingChangedListenerKey;
#pragma warning restore 649
#endregion // System resource ID's

        /// <summary>
        /// Fired upon a change of the current rating value.
        /// </summary>
        [ListenerInterface(typeof(IOnRatingBarChangeListener))]
        public event EventHandler<RatingChangedEventArgs> RatingChanged
        {
            add
            {
                var listener = this.GetOrCreate<RatingBarListener>(ratingChangedListenerKey, true, SetOnRatingBarChangeListener);
                listener.RatingChanged.Add(value);
            }
            remove
            {
                var listener = this.GetOrCreate<RatingBarListener>(ratingChangedListenerKey, false, null);
                if (listener != null) listener.RatingChanged.Remove(value);
            }
        }
    }

    /// <summary>
    /// Implementation of the <see cref="RatingBar"/> events.
    /// </summary>
    internal sealed class RatingBarListener : RatingBar.IOnRatingBarChangeListener
    {
        internal readonly Dot42.EventHandlerListener<RatingChangedEventArgs> RatingChanged = new EventHandlerListener<RatingChangedEventArgs>();

        public void OnRatingChanged(RatingBar ratingBar, float rating, bool fromUser)
        {
            RatingChanged.Invoke(ratingBar, new RatingChangedEventArgs(rating, fromUser));
        }
    }
}

