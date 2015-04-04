// Copyright (C) 2014 dot42
//
// Original filename: ViewEventArgs.cs
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
namespace Android.Views
{
    public class ViewEventArgs : System.EventArgs
    {
        /// <summary>
        /// Set this property to true when the listenered has consumed the event.
        /// </summary>
        public bool IsHandled { get; set; }
    }

    public class ViewEventArgs<T> : ViewEventArgs
    {
        private readonly T source;

        /// <summary>
        /// Default ctor
        /// </summary>
        public ViewEventArgs(T source)
        {
            this.source = source;
        }

        /// <summary>
        /// Gets the original android event.
        /// </summary>
        public T Source
        {
            get { return source; }
        }
    }
}
