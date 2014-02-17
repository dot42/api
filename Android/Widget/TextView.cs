// Copyright (C) 2014 dot42
//
// Original filename: TextView.cs
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
    partial class TextView
    {
#region System resource ID's
#pragma warning disable 649
        [Dot42.ResourceId("__dot42_textview_editoraction_listener")]
        private static readonly int editorActionListenerKey;
#pragma warning restore 649
#endregion // System resource ID's

        /// <summary>
        /// Fired when an action is being performed.
        /// </summary>
        [ListenerInterface(typeof(IOnEditorActionListener))]
        public event EventHandler<EditorActionEventArgs> EditorAction
        {
            add
            {
                var listener = (TextViewOnEditorActionListener)GetTag(editorActionListenerKey);
                if (listener == null)
                {
                    listener = new TextViewOnEditorActionListener();
                    SetTag(editorActionListenerKey, listener);
                    SetOnEditorActionListener(listener);
                }
                listener.EditorAction.Add(value);
            }
            remove
            {
                var listener = (TextViewOnEditorActionListener)GetTag(editorActionListenerKey);
                if (listener != null) listener.EditorAction.Remove(value);
            }
        }
    }

    /// <summary>
    /// Implementation of the <see cref="EditorAction"/> event.
    /// </summary>
    internal sealed class TextViewOnEditorActionListener : TextView.IOnEditorActionListener
    {
        internal readonly Dot42.EventHandlerListener<EditorActionEventArgs> EditorAction = new EventHandlerListener<EditorActionEventArgs>();

        public bool OnEditorAction(TextView v, int actionId, KeyEvent @event)
        {
            var args = new EditorActionEventArgs(actionId, @event);
            EditorAction.Invoke(v, args);
            return args.IsHandled;
        }
    }
}

