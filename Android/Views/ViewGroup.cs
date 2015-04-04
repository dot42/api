// Copyright (C) 2014 dot42
//
// Original filename: ViewGroup.cs
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
using Java.Lang;

namespace Android.Views
{
    partial class ViewGroup
    {
#region System resource ID's
#pragma warning disable 649

        [Dot42.ResourceId("__dot42_viewGroup_hierarchyChange_listener")]
        private static readonly int hierarchyChangeListenerKey;

#pragma warning restore 649
#endregion // System resource ID's

        /// <summary>
        /// Fired when this view is attached to a window.
        /// </summary>
        [ListenerInterface(typeof(IOnHierarchyChangeListener))]
        public event System.EventHandler ChildViewAdded
        {
            add
            {
                var listener = (ViewGroupOnHierarchyChangeListener)GetTag(hierarchyChangeListenerKey);
                if (listener == null)
                {
                    listener = new ViewGroupOnHierarchyChangeListener();
                    SetTag(hierarchyChangeListenerKey, listener);
                    SetOnHierarchyChangeListener(listener);
                }
                listener.ChildViewAdded.Add(value);
            }
            remove
            {
                var listener = (ViewGroupOnHierarchyChangeListener)GetTag(hierarchyChangeListenerKey);
                if (listener != null) listener.ChildViewAdded.Remove(value);                
            }
        }

        /// <summary>
        /// Fired when this view is attached to a window.
        /// </summary>
        [ListenerInterface(typeof(IOnHierarchyChangeListener))]
        public event System.EventHandler ChildViewRemoved
        {
            add
            {
                var listener = (ViewGroupOnHierarchyChangeListener)GetTag(hierarchyChangeListenerKey);
                if (listener == null)
                {
                    listener = new ViewGroupOnHierarchyChangeListener();
                    SetTag(hierarchyChangeListenerKey, listener);
                    SetOnHierarchyChangeListener(listener);
                }
                listener.ChildViewRemoved.Add(value);
            }
            remove
            {
                var listener = (ViewGroupOnHierarchyChangeListener)GetTag(hierarchyChangeListenerKey);
                if (listener != null) listener.ChildViewRemoved.Remove(value);
            }
        }
    }

    /// <summary>
    /// Implementation of the <see cref="ChildViewAdded"/> and <see cref="ChildViewRemoved"/> event.
    /// </summary>
    internal sealed class ViewGroupOnHierarchyChangeListener : ViewGroup.IOnHierarchyChangeListener
    {
        internal readonly Dot42.EventHandlerListener ChildViewAdded = new EventHandlerListener();
        internal readonly Dot42.EventHandlerListener ChildViewRemoved = new EventHandlerListener();

        public void OnChildViewAdded(View parent, View child)
        {
            ChildViewAdded.Invoke(parent, new HierarchyChangeEventArgs(child));
        }

        public void OnChildViewRemoved(View parent, View child)
        {
            ChildViewRemoved.Invoke(parent, new HierarchyChangeEventArgs(child));
        }
    }
}

