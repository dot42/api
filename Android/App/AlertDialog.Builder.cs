// Copyright (C) 2014 dot42
//
// Original filename: AlertDialog.Builder.cs
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
using Android.Content;
using Android.Database;
using Android.Widget;
using Java.Lang;

namespace Android.App
{
	partial class AlertDialog
	{
        partial class Builder
        {
            /// <summary>
            /// Set a list of items, which are supplied by the given adapter, to be displayed in the dialog as the content, 
            /// you will be notified of the selected item via the supplied event handler.
            /// </summary>
            public Builder SetAdapter(IListAdapter adapter, EventHandler<DialogInterfaceClickEventArgs> handler)
            {
                return SetAdapter(adapter, new DialogOnClickListener(handler));
            }

            /// <summary>
            /// Set a list of items, which are supplied by the given cursor, to be displayed in the dialog as the content, 
            /// you will be notified of the selected item via the supplied event handler.
            /// </summary>
            public Builder SetCursor(ICursor cursor, EventHandler<DialogInterfaceClickEventArgs> handler, string labelColumn)
            {
                return SetCursor(cursor, new DialogOnClickListener(handler), labelColumn);
            }

            /// <summary>
            /// Set a list of items, to be displayed in the dialog as the content, 
            /// you will be notified of the selected item via the supplied event handler.
            /// </summary>
            public Builder SetItems(int itemsResourceId, EventHandler<DialogInterfaceClickEventArgs> handler)
            {
                return SetItems(itemsResourceId, new DialogOnClickListener(handler));
            }

            /// <summary>
            /// Set a list of items, to be displayed in the dialog as the content, 
            /// you will be notified of the selected item via the supplied event handler.
            /// </summary>
            public Builder SetItems(ICharSequence[] items, EventHandler<DialogInterfaceClickEventArgs> handler)
            {
                return SetItems(items, new DialogOnClickListener(handler));
            }

            /// <summary>
            /// Set the listener to be invoked when the positive button is pressed.
            /// </summary>
            public Builder SetPositiveButton(ICharSequence text, EventHandler<DialogInterfaceClickEventArgs> handler)
            {
                return SetPositiveButton(text, new DialogOnClickListener(handler));
            }

            /// <summary>
            /// Set the listener to be invoked when the positive button is pressed.
            /// </summary>
            public Builder SetPositiveButton(int textResourceId, EventHandler<DialogInterfaceClickEventArgs> handler)
            {
                return SetPositiveButton(textResourceId, new DialogOnClickListener(handler));
            }

            /// <summary>
            /// Set the listener to be invoked when the negative button is pressed.
            /// </summary>
            public Builder SetNegativeButton(ICharSequence text, EventHandler<DialogInterfaceClickEventArgs> handler)
            {
                return SetNegativeButton(text, new DialogOnClickListener(handler));
            }

            /// <summary>
            /// Set the listener to be invoked when the negative button is pressed.
            /// </summary>
            public Builder SetNegativeButton(int textResourceId, EventHandler<DialogInterfaceClickEventArgs> handler)
            {
                return SetNegativeButton(textResourceId, new DialogOnClickListener(handler));
            }

            /// <summary>
            /// Set the listener to be invoked when the neutral button is pressed.
            /// </summary>
            public Builder SetNeutralButton(ICharSequence text, EventHandler<DialogInterfaceClickEventArgs> handler)
            {
                return SetNeutralButton(text, new DialogOnClickListener(handler));
            }

            /// <summary>
            /// Set the listener to be invoked when the neutral button is pressed.
            /// </summary>
            public Builder SetNeutralButton(int textResourceId, EventHandler<DialogInterfaceClickEventArgs> handler)
            {
                return SetNeutralButton(textResourceId, new DialogOnClickListener(handler));
            }
        }
	}

    /// <summary>
    /// Implementation of the SeekBar events.
    /// </summary>
    internal sealed class DialogOnClickListener : IDialogInterface_IOnClickListener
    {
        private readonly EventHandler<DialogInterfaceClickEventArgs> handler;

        internal DialogOnClickListener(EventHandler<DialogInterfaceClickEventArgs> handler)
        {
            this.handler = handler;
        }

        public void OnClick(IDialogInterface dialogInterface, int which)
        {
            handler(dialogInterface, new DialogInterfaceClickEventArgs(which));
        }
    }
}

