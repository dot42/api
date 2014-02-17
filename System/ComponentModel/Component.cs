// Copyright (C) 2014 dot42
//
// Original filename: Component.cs
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
    /// Base class for IComponent.
    /// </summary>
	public class Component : IComponent, IDisposable
	{
        /// <summary>
        /// Release all resources held by this component
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
        }

        /// <summary>
        /// Release unmanaged resources and optionally release managed resources.
        /// </summary>
        /// <param name="disposing">If true, release managed resources also.</param>
        protected virtual void Dispose(bool disposing)
        {
            // Nothing here
        }

        /// <summary>
        /// Gets/sets the site of this component
        /// </summary>
        public ISite Site { get; set; }
	}
}

