// Copyright (C) 2014 dot42
//
// Original filename: ExpandableListView.cs
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
    partial class ExpandableListView
    {
#region System resource ID's
#pragma warning disable 649

        [Dot42.ResourceId("__dot42_expandablelistview_childclick_listener")]
        private static readonly int childClickListenerKey;

        [Dot42.ResourceId("__dot42_expandablelistview_groupclick_listener")]
        private static readonly int groupClickListenerKey;

        [Dot42.ResourceId("__dot42_expandablelistview_groupcollapse_listener")]
        private static readonly int groupCollapseListenerKey;

        [Dot42.ResourceId("__dot42_expandablelistview_groupexpand_listener")]
        private static readonly int groupExpandListenerKey;

#pragma warning restore 649
#endregion // System resource ID's

        /// <summary>
        /// Fired when a child in this expandable list has been clicked.
        /// </summary>
        [ListenerInterface(typeof(IOnChildClickListener))]
        public event EventHandler<ChildClickEventArgs> ChildClick
        {
            add
            {
                var listener = this.GetOrCreate<ExpandableListViewListener>(childClickListenerKey, true, SetOnChildClickListener);
                listener.ChildClick.Add(value);
            }
            remove
            {
                var listener = this.GetOrCreate<ExpandableListViewListener>(childClickListenerKey, false, null);
                if (listener != null) listener.ChildClick.Remove(value);
            }
        }

        /// <summary>
        /// Fired when a group in this expandable list has been clicked.
        /// </summary>
        [ListenerInterface(typeof(IOnGroupClickListener))]
        public event EventHandler<GroupClickEventArgs> GroupClick
        {
            add
            {
                var listener = this.GetOrCreate<ExpandableListViewListener>(groupClickListenerKey, true, SetOnGroupClickListener);
                listener.GroupClick.Add(value);
            }
            remove
            {
                var listener = this.GetOrCreate<ExpandableListViewListener>(groupClickListenerKey, false, null);
                if (listener != null) listener.GroupClick.Remove(value);
            }
        }

        /// <summary>
        /// Fired when a group in this expandable list has been collapsed.
        /// </summary>
        [ListenerInterface(typeof(IOnGroupCollapseListener))]
        public event EventHandler<GroupPositionEventArgs> GroupCollapse
        {
            add
            {
                var listener = this.GetOrCreate<ExpandableListViewListener>(groupCollapseListenerKey, true, SetOnGroupCollapseListener);
                listener.GroupCollapse.Add(value);
            }
            remove
            {
                var listener = this.GetOrCreate<ExpandableListViewListener>(groupCollapseListenerKey, false, null);
                if (listener != null) listener.GroupCollapse.Remove(value);
            }
        }

        /// <summary>
        /// Fired when a group in this expandable list has been expanded.
        /// </summary>
        [ListenerInterface(typeof(IOnGroupExpandListener))]
        public event EventHandler<GroupPositionEventArgs> GroupExpand
        {
            add
            {
                var listener = this.GetOrCreate<ExpandableListViewListener>(groupExpandListenerKey, true, SetOnGroupExpandListener);
                listener.GroupExpand.Add(value);
            }
            remove
            {
                var listener = this.GetOrCreate<ExpandableListViewListener>(groupExpandListenerKey, false, null);
                if (listener != null) listener.GroupExpand.Remove(value);
            }
        }

    }

    /// <summary>
    /// Implementation of the <see cref="ExpandableListView"/> events.
    /// </summary>
    internal sealed class ExpandableListViewListener : ExpandableListView.IOnChildClickListener, ExpandableListView.IOnGroupClickListener,
        ExpandableListView.IOnGroupCollapseListener, ExpandableListView.IOnGroupExpandListener
    {
        internal readonly Dot42.EventHandlerListener<ChildClickEventArgs> ChildClick = new EventHandlerListener<ChildClickEventArgs>();
        internal readonly Dot42.EventHandlerListener<GroupClickEventArgs> GroupClick = new EventHandlerListener<GroupClickEventArgs>();
        internal readonly Dot42.EventHandlerListener<GroupPositionEventArgs> GroupCollapse = new EventHandlerListener<GroupPositionEventArgs>();
        internal readonly Dot42.EventHandlerListener<GroupPositionEventArgs> GroupExpand = new EventHandlerListener<GroupPositionEventArgs>();

        public bool OnChildClick(ExpandableListView parent, View.View v, int groupPosition, int childPosition, long id)
        {
            var args = new ChildClickEventArgs(v, groupPosition, childPosition, id);
            ChildClick.Invoke(parent, args);
            return args.IsHandled;
        }

        public bool OnGroupClick(ExpandableListView parent, View.View v, int groupPosition, long id)
        {
            var args = new GroupClickEventArgs(v, groupPosition, id);
            GroupClick.Invoke(parent, args);
            return args.IsHandled;
        }

        public void OnGroupCollapse(int groupPosition)
        {
            GroupCollapse.Invoke(null, new GroupPositionEventArgs(groupPosition));
        }

        public void OnGroupExpand(int groupPosition)
        {
            GroupExpand.Invoke(null, new GroupPositionEventArgs(groupPosition));
        }
    }
}

