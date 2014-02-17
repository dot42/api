// Copyright (C) 2014 dot42
//
// Original filename: SearchView.cs
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
    partial class SearchView
    {
#region System resource ID's
#pragma warning disable 649

#if ANDROID_11P
        [Dot42.ResourceId("__dot42_searchview_close_listener")]
        private static readonly int closeListenerKey;

        [Dot42.ResourceId("__dot42_searchview_querytextchange_listener")]
        private static readonly int queryTextChangeListenerKey;

        [Dot42.ResourceId("__dot42_searchview_suggestion_listener")]
        private static readonly int suggestionListenerKey;
#endif

#pragma warning restore 649
#endregion // System resource ID's

#if ANDROID_11P
        /// <summary>
        /// Fired when the user is attempting to close the SearchView.
        /// </summary>
        [ListenerInterface(typeof(IOnCloseListener))]
        public event EventHandler<ViewEventArgs> Close
        {
            add
            {
                var listener = this.GetOrCreate<SearchViewListener>(closeListenerKey, true, SetOnCloseListener);
                listener.Close.Add(value);
            }
            remove
            {
                var listener = this.GetOrCreate<SearchViewListener>(closeListenerKey, false, null);
                if (listener != null) listener.Close.Remove(value);
            }
        }

        /// <summary>
        /// Fired when the query text is changed by the user.
        /// </summary>
        [ListenerInterface(typeof(IOnQueryTextListener))]
        public event EventHandler<QueryTextChangeEventArgs> QueryTextChange
        {
            add
            {
                var listener = this.GetOrCreate<SearchViewListener>(queryTextChangeListenerKey, true, SetOnQueryTextListener);
                listener.QueryTextChange.Add(value);
            }
            remove
            {
                var listener = this.GetOrCreate<SearchViewListener>(queryTextChangeListenerKey, false, null);
                if (listener != null) listener.QueryTextChange.Remove(value);
            }
        }

        /// <summary>
        /// Fired when the user submits the query.
        /// </summary>
        [ListenerInterface(typeof(IOnQueryTextListener))]
        public event EventHandler<QueryTextSubmitEventArgs> QueryTextSubmit
        {
            add
            {
                var listener = this.GetOrCreate<SearchViewListener>(queryTextChangeListenerKey, true, SetOnQueryTextListener);
                listener.QueryTextSubmit.Add(value);
            }
            remove
            {
                var listener = this.GetOrCreate<SearchViewListener>(queryTextChangeListenerKey, false, null);
                if (listener != null) listener.QueryTextSubmit.Remove(value);
            }
        }

        /// <summary>
        /// Fired when a suggestion was clicked.
        /// </summary>
        [ListenerInterface(typeof(IOnSuggestionListener))]
        public event EventHandler<SuggestionEventArgs> SuggestionClick
        {
            add
            {
                var listener = this.GetOrCreate<SearchViewListener>(suggestionListenerKey, true, SetOnSuggestionListener);
                listener.SuggestionClick.Add(value);
            }
            remove
            {
                var listener = this.GetOrCreate<SearchViewListener>(suggestionListenerKey, false, null);
                if (listener != null) listener.SuggestionClick.Remove(value);
            }
        }

        /// <summary>
        /// Fired when a suggestion was selected by navigating to it.
        /// </summary>
        [ListenerInterface(typeof(IOnSuggestionListener))]
        public event EventHandler<SuggestionEventArgs> SuggestionSelect
        {
            add
            {
                var listener = this.GetOrCreate<SearchViewListener>(suggestionListenerKey, true, SetOnSuggestionListener);
                listener.SuggestionSelect.Add(value);
            }
            remove
            {
                var listener = this.GetOrCreate<SearchViewListener>(suggestionListenerKey, false, null);
                if (listener != null) listener.SuggestionSelect.Remove(value);
            }
        }
#endif
    }

#if ANDROID_11P
    /// <summary>
    /// Implementation of the <see cref="SearchView"/> events.
    /// </summary>
    internal sealed class SearchViewListener : SearchView.IOnCloseListener, SearchView.IOnQueryTextListener, SearchView.IOnSuggestionListener
    {
        internal readonly Dot42.EventHandlerListener<View.ViewEventArgs> Close = new EventHandlerListener<ViewEventArgs>();
        internal readonly Dot42.EventHandlerListener<QueryTextChangeEventArgs> QueryTextChange = new EventHandlerListener<QueryTextChangeEventArgs>();
        internal readonly Dot42.EventHandlerListener<QueryTextSubmitEventArgs> QueryTextSubmit = new EventHandlerListener<QueryTextSubmitEventArgs>();
        internal readonly Dot42.EventHandlerListener<SuggestionEventArgs> SuggestionClick = new EventHandlerListener<SuggestionEventArgs>();
        internal readonly Dot42.EventHandlerListener<SuggestionEventArgs> SuggestionSelect = new EventHandlerListener<SuggestionEventArgs>();

        public bool OnClose()
        {
            var args = new ViewEventArgs();
            Close.Invoke(null, args);
            return args.IsHandled;
        }

        public bool OnQueryTextSubmit(string query)
        {
            var args = new QueryTextSubmitEventArgs(query);
            QueryTextSubmit.Invoke(null, args);
            return args.IsHandled;
        }

        public bool OnQueryTextChange(string newText)
        {
            var args = new QueryTextChangeEventArgs(newText);
            QueryTextChange.Invoke(null, args);
            return args.IsHandled;
        }

        public bool OnSuggestionSelect(int position)
        {
            var args = new SuggestionEventArgs(position);
            SuggestionSelect.Invoke(null, args);
            return args.IsHandled;
        }

        public bool OnSuggestionClick(int position)
        {
            var args = new SuggestionEventArgs(position);
            SuggestionClick.Invoke(null, args);
            return args.IsHandled;
        }
    }
#endif
}

