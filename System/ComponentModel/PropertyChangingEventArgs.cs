// Copyright (C) 2014 dot42
//
// Original filename: PropertyChangingEventArgs.cs
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
namespace System.ComponentModel
{
    /// <summary>
    /// Event arguments for property changing notifications.
    /// </summary>
	public class PropertyChangingEventArgs : EventArgs
    {
        private readonly string propertyName;

        /// <summary>
        /// Default ctor
        /// </summary>
        public PropertyChangingEventArgs(string propertyName)
        {
            this.propertyName = propertyName;
        }

        /// <summary>
        /// Gets the name of the property that is changing.
        /// </summary>
        public virtual string PropertyName { get { return propertyName; } }
	}
}

